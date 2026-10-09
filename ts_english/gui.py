"""English Tkinter front end for the MCC4 four-axis motion controller demo."""
from __future__ import annotations

import base64
import csv
import math
import queue
import subprocess
import threading
import time
import tkinter as tk
from collections import deque
from datetime import datetime
from pathlib import Path
from tkinter import filedialog, messagebox, simpledialog, ttk


APP_DIR = Path(__file__).resolve().parent
BRIDGE_EXE = APP_DIR / "ControllerBridge.exe"
AXES = ("X", "Y", "Z", "T")
T_AXIS_INDEX = AXES.index("T")
T_AXIS_DISPLAY_SCALE = 2.0
PARAMETERS = (
    "Manual distance", "Low-speed range", "Manual speed", "Acceleration",
    "Pulse equivalent", "Home speed", "Signal level", "Home switch distance",
    "Soft negative limit", "Soft positive limit",
)
LIMIT_BITS = {"X-": 9, "X+": 10, "Y-": 6, "Y+": 7,
              "Z-": 3, "Z+": 4, "T-": 0, "T+": 1}
TEMP_SETPOINT_SCALE = 1.41442716
TEMP_SETPOINT_OFFSET = 6.19
TEMP_WANTED_MIN = 190.0
TEMP_WANTED_MAX = 325.0


class BridgeError(RuntimeError):
    pass


class Tooltip:
    """Small hover hint for controls whose direction may be ambiguous."""
    def __init__(self, widget, text):
        self.widget = widget
        self.text = text
        self.window = None
        widget.bind("<Enter>", self.show, add="+")
        widget.bind("<Leave>", self.hide, add="+")
        widget.bind("<ButtonPress>", self.hide, add="+")

    def show(self, _event=None):
        if self.window is not None or not self.widget.winfo_exists():
            return
        x = self.widget.winfo_rootx() + 10
        y = self.widget.winfo_rooty() + self.widget.winfo_height() + 4
        self.window = window = tk.Toplevel(self.widget)
        window.wm_overrideredirect(True)
        window.wm_geometry("+%d+%d" % (x, y))
        tk.Label(window, text=self.text, bg="#fff8dc", fg="#1f2937",
                 relief="solid", borderwidth=1, padx=6, pady=3,
                 font=("Segoe UI", 9)).pack()

    def hide(self, _event=None):
        if self.window is not None:
            self.window.destroy()
            self.window = None


class ControllerClient:
    """Serialized request/response client for the x86 vendor DLL bridge."""
    def __init__(self):
        self.proc = None
        self.lock = threading.Lock()
        self.counter = 0

    def start(self):
        if self.proc and self.proc.poll() is None:
            return
        if not BRIDGE_EXE.exists():
            raise BridgeError("ControllerBridge.exe is missing. Run BuildBridge.bat first.")
        flags = getattr(subprocess, "CREATE_NO_WINDOW", 0)
        self.proc = subprocess.Popen(
            [str(BRIDGE_EXE)], cwd=str(APP_DIR), stdin=subprocess.PIPE,
            stdout=subprocess.PIPE, stderr=subprocess.DEVNULL, text=True,
            encoding="utf-8", errors="replace", bufsize=1, creationflags=flags)

    def request(self, command, *args):
        with self.lock:
            self.start()
            self.counter += 1
            request_id = str(self.counter)
            fields = [request_id, command] + [str(a) for a in args]
            self.proc.stdin.write("\t".join(fields) + "\n")
            self.proc.stdin.flush()
            line = self.proc.stdout.readline()
            if not line:
                code = self.proc.poll()
                raise BridgeError("Controller bridge closed unexpectedly (exit code %s)." % code)
            parts = line.rstrip("\r\n").split("\t", 2)
            if len(parts) != 3 or parts[0] != request_id:
                raise BridgeError("Invalid response from controller bridge: " + line.strip())
            if parts[1] != "OK":
                raise BridgeError(parts[2])
            return parts[2]

    def close(self):
        if self.proc and self.proc.poll() is None:
            try:
                self.request("QUIT")
            except Exception:
                pass
            try:
                self.proc.stdin.close()
                self.proc.wait(timeout=2)
            except Exception:
                self.proc.kill()


class TemperatureWorker(threading.Thread):
    """Owns temperature-controller requests away from Tk's event loop."""
    REGISTER_NAMES = ("seg1_temp", "seg1_power", "seg1_heat_time", "seg1_hold_time", "P", "I", "D")

    def __init__(self, client, events, port="COM5"):
        super().__init__(name="temperature-controller", daemon=True)
        self.client = client
        self.events = events
        self.port = port
        self._condition = threading.Condition()
        self._commands = deque()
        self._want_connection = True
        self._reconfigure = True
        self._stopping = False
        self._online = False
        self._opened = False
        self._busy = False

    @property
    def online(self):
        with self._condition:
            return self._online

    @property
    def wanted_port(self):
        with self._condition:
            return self.port if self._want_connection else None

    def connect(self, port):
        with self._condition:
            self.port = port
            self._want_connection = True
            self._reconfigure = True
            self._online = False
            self._busy = False
            self._commands.clear()
            self.events.put(("temp_online", False))
            self.events.put(("temp_busy", False))
            self._condition.notify_all()

    def disconnect(self):
        with self._condition:
            self._want_connection = False
            self._reconfigure = True
            self._online = False
            self._busy = False
            self._commands.clear()
            self.events.put(("temp_online", False))
            self.events.put(("temp_busy", False))
            self._condition.notify_all()

    def submit(self, operations, description, *, priority_stop=False):
        with self._condition:
            if self._stopping or not self._online:
                return False
            if priority_stop:
                self._commands.clear()
            elif self._busy or self._commands:
                return False
            self._commands.append((tuple(operations), description, priority_stop))
            self._busy = True
            self.events.put(("temp_busy", True))
            self._condition.notify()
        return True

    def stop(self):
        with self._condition:
            self._stopping = True
            self._commands.clear()
            self._condition.notify_all()

    def _close_port(self):
        if self._opened:
            try:
                self.client.request("TEMP_CLOSE")
            except Exception:
                pass
            self._opened = False

    def _lost_connection(self, message, detail=""):
        self._close_port()
        with self._condition:
            self._online = False
            self._busy = False
            self._commands.clear()
            self.events.put(("temp_online", False))
            self.events.put(("temp_busy", False))
            self.events.put(("temp_status", message, detail))

    def run(self):
        next_poll = 0.0
        retry_at = 0.0
        try:
            while True:
                action = None
                command = None
                with self._condition:
                    while action is None:
                        if self._stopping:
                            action = "stop"
                            break
                        now = time.monotonic()
                        if self._reconfigure:
                            self._reconfigure = False
                            action = "configure"
                            break
                        if self._commands:
                            command = self._commands.popleft()
                            action = "command"
                            break
                        if self._online and now >= next_poll:
                            action = "poll"
                            break
                        if self._want_connection and not self._online and now >= retry_at:
                            action = "configure"
                            break
                        deadlines = []
                        if self._online:
                            deadlines.append(next_poll)
                        elif self._want_connection:
                            deadlines.append(retry_at)
                        timeout = max(0.01, min(deadlines) - now) if deadlines else None
                        self._condition.wait(timeout)

                if action == "stop":
                    self._close_port()
                    break
                if action == "configure":
                    self._close_port()
                    with self._condition:
                        wants_connection = self._want_connection
                        port = self.port
                    if not wants_connection:
                        with self._condition:
                            self._online = False
                        self.events.put(("temp_online", False))
                        self.events.put(("temp_status", "Disconnected", ""))
                        continue
                    self.events.put(("temp_status", "Connecting to " + port + "...", ""))
                    try:
                        self.client.request("TEMP_OPEN", port)
                        self._opened = True
                        values = {}
                        for name in self.REGISTER_NAMES:
                            with self._condition:
                                if self._stopping:
                                    break
                            values[name] = int(self.client.request("TEMP_READ_REGISTER", name))
                        with self._condition:
                            if self._stopping:
                                continue
                        with self._condition:
                            self._online = True
                        self.events.put(("temp_online", True))
                        self.events.put(("temp_initial", values))
                        self.events.put(("temp_status", "Connected to " + port, ""))
                        next_poll = time.monotonic() + 0.3
                    except Exception as exc:
                        self._lost_connection("Connection error on " + port + "; retrying", str(exc))
                        retry_at = time.monotonic() + 2.0
                    continue
                if action == "poll":
                    try:
                        raw = int(self.client.request("TEMP_READ_REGISTER", "current_temp"))
                        self.events.put(("temp_read", raw / 10.0))
                        next_poll = time.monotonic() + 0.3
                    except Exception as exc:
                        self._lost_connection("Connection lost; retrying", str(exc))
                        retry_at = time.monotonic() + 2.0
                    continue
                if action == "command":
                    operations, description, _priority_stop = command
                    try:
                        for kind, name, value in operations:
                            with self._condition:
                                if self._stopping:
                                    break
                                if self._commands and self._commands[0][2]:
                                    self.events.put(("temp_status", "Update interrupted by Stop", ""))
                                    break
                            if kind == "register":
                                self.client.request("TEMP_WRITE_REGISTER", name, int(value))
                            elif kind == "coil":
                                self.client.request("TEMP_WRITE_COIL", name, "1" if value else "0")
                            else:
                                raise ValueError("Unknown temperature operation: " + kind)
                        else:
                            self.events.put(("temp_status", description, ""))
                    except Exception as exc:
                        self._lost_connection("Command not confirmed; reconnecting", str(exc))
                        retry_at = time.monotonic() + 2.0
                    finally:
                        with self._condition:
                            self._busy = bool(self._commands)
                            self.events.put(("temp_busy", self._busy))
                            if self._commands:
                                self._condition.notify()
                    continue
        finally:
            self._close_port()
            with self._condition:
                self._online = False
                self._busy = False
            self.events.put(("temp_online", False))
            self.events.put(("temp_busy", False))


class MotionApp(tk.Tk):
    def __init__(self):
        super().__init__()
        self.title("MCC4 Motion and Temperature Control GUI")
        self.geometry("1280x850")
        self.minsize(1060, 720)
        self.configure(bg="#edf1f5")
        self.client = ControllerClient()
        self.events = queue.Queue()
        self.poll_stop = None
        self.connected = False
        self.poll_busy = False
        self.params = [None] * 40
        self.parameter_widgets = []
        self.motion_active = False
        self.motion_pending = False
        self.motion_pending_until = 0.0
        self.manual_command_queue = []
        self.manual_queue_lock = threading.Lock()
        self.manual_dispatch_lock = threading.Lock()
        self.manual_queue_worker_active = False
        self.manual_queue_generation = 0
        self.manual_queue_stop_pending = False
        self.speed_vars = []
        self.accel_vars = []
        self.manual_distance_vars = []
        self.neg_vars = []
        self.pos_vars = []
        self.axis_positions = [None] * len(AXES)
        self.z_position_canvas = None
        self.t_rotation_canvas = None
        self.z_value_var = tk.StringVar(value="Z: —")
        self.t_value_var = tk.StringVar(value="T: —")
        self.soft_vars = [tk.BooleanVar(value=False) for _ in AXES]
        self.hard_vars = [tk.BooleanVar(value=False) for _ in AXES]
        self.pos_labels = {}
        self.speed_labels = {}
        self.limit_text = tk.StringVar(value="No limit signal reported")
        self.link_text = tk.StringVar(value="NOT LINKED")
        self.run_text = tk.StringVar(value="STOPPED")
        self.limit_badge_text = tk.StringVar(value="LIMITS CLEAR")
        self.footer_text = tk.StringVar(value="Ready. Connect to a controller to read its live status.")
        self.motion_queue_count_var = tk.StringVar(value="Commands in queue: 0 (active included)")
        self.port_var = tk.StringVar(value="COM4")
        self.temp_port_var = tk.StringVar(value="COM5")
        self.temp_status_var = tk.StringVar(value="Connecting to COM5...")
        self.temp_current_var = tk.StringVar(value="--.- °C")
        self.temp_estimated_wanted_var = tk.StringVar(value="--.- °C")
        self.temp_target_var = tk.StringVar(value="200")
        self.temp_machine_set_var = tk.StringVar(value="--.-")
        self.temp_machine_set_display_var = tk.StringVar(value="--.- °C")
        self.temp_manual_machine_var = tk.BooleanVar(value=False)
        self.temp_target_var.trace_add("write", self._update_machine_setpoint_display)
        self.temp_machine_set_var.trace_add("write", self._update_machine_set_readout)
        self._update_machine_setpoint_display()
        self._update_machine_set_readout()
        self.temp_heat_var = tk.StringVar(value="0")
        self.temp_hold_var = tk.StringVar(value="9999")
        self.temp_power_var = tk.StringVar(value="100")
        self.temp_pid_vars = {name: tk.StringVar(value="") for name in ("P", "I", "D")}
        self.temp_online = False
        self.temp_busy = False
        self.temp_power_manual_override = False
        self.temp_last_temperature = None
        self.temp_recording = False
        self.temp_record_start = None
        self.temp_samples = []
        self.cycle_var = tk.StringVar(value="1")
        self.program_active = False
        self.program_cancel = threading.Event()
        self.program_gate = threading.Event()
        self.program_gate.set()
        self.program_thread = None
        self.current_file = None
        self.debug_open = False
        self._configure_style()
        self._build_menu()
        self._build_ui()
        self.temperature_worker = TemperatureWorker(self.client, self.events, self.temp_port_var.get())
        self.temperature_worker.start()
        self.protocol("WM_DELETE_WINDOW", self.close_app)
        self.after(100, self._pump_events)
        self.after(500, self._poll_state)

    def _configure_style(self):
        style = ttk.Style(self)
        try:
            style.theme_use("clam")
        except tk.TclError:
            pass
        style.configure("TFrame", background="#edf1f5")
        style.configure("Card.TFrame", background="#ffffff", relief="flat")
        style.configure("TLabel", background="#edf1f5", foreground="#1e293b", font=("Segoe UI", 9))
        style.configure("Card.TLabel", background="#ffffff", foreground="#1e293b", font=("Segoe UI", 9))
        style.configure("Title.TLabel", background="#edf1f5", foreground="#12243a", font=("Segoe UI Semibold", 18))
        style.configure("Section.TLabel", background="#ffffff", foreground="#15283d", font=("Segoe UI Semibold", 10))
        style.configure("Hint.TLabel", background="#ffffff", foreground="#64748b", font=("Segoe UI", 8))
        style.configure("TButton", font=("Segoe UI", 9), padding=(9, 5))
        style.configure("Accent.TButton", font=("Segoe UI Semibold", 9), padding=(12, 6))
        style.map("Accent.TButton", background=[("active", "#155eaa"), ("!disabled", "#1976d2")], foreground=[("!disabled", "white")])
        style.configure("Danger.TButton", padding=(10, 5))
        style.configure("Treeview", rowheight=25, font=("Segoe UI", 9))
        style.configure("Treeview.Heading", font=("Segoe UI Semibold", 9))

    def _build_menu(self):
        bar = tk.Menu(self)
        file_menu = tk.Menu(bar, tearoff=False)
        file_menu.add_command(label="New", accelerator="Ctrl+N", command=self.file_new)
        file_menu.add_command(label="Open…", accelerator="Ctrl+O", command=self.file_open)
        file_menu.add_command(label="Save", accelerator="Ctrl+S", command=self.file_save)
        file_menu.add_command(label="Save As…", command=self.file_save_as)
        file_menu.add_separator()
        file_menu.add_command(label="Close Program", command=self.file_close)
        file_menu.add_command(label="Quit", command=self.close_app)
        bar.add_cascade(label="File", menu=file_menu)

        program_menu = tk.Menu(bar, tearoff=False)
        program_menu.add_command(label="Insert Line…", command=self.insert_line)
        program_menu.add_command(label="Append Line…", command=self.append_line)
        program_menu.add_command(label="Modify Selected Line…", command=self.modify_line)
        program_menu.add_command(label="Delete Selected Line", command=self.delete_line)
        program_menu.add_separator()
        program_menu.add_command(label="Read Program From File…", command=self.file_open)
        program_menu.add_command(label="Save Program To File…", command=self.file_save_as)
        program_menu.add_separator()
        program_menu.add_command(label="Download Parameters From Controller", command=self.download_parameters)
        program_menu.add_command(label="Upload Parameters To Controller", command=self.upload_parameters)
        program_menu.add_command(label="Show Parameters…", command=self.open_parameters)
        program_menu.add_separator()
        program_menu.add_command(label="Start Program", command=self.start_program)
        program_menu.add_command(label="Pause Program", command=self.pause_program)
        program_menu.add_command(label="Resume Program", command=self.resume_program)
        program_menu.add_command(label="Stop Program", command=self.stop_program)
        bar.add_cascade(label="Program", menu=program_menu)

        parameter_menu = tk.Menu(bar, tearoff=False)
        parameter_menu.add_command(label="Controller Parameters…", command=self.open_parameters)
        parameter_menu.add_command(label="Save Parameters To Controller", command=self.save_rom)
        bar.add_cascade(label="Parameter", menu=parameter_menu)

        other_menu = tk.Menu(bar, tearoff=False)
        other_menu.add_command(label="Serial Debug Window", command=self.toggle_debug)
        other_menu.add_command(label="Joystick Settings…", command=self.joystick_dialog)
        other_menu.add_command(label="Test Communication Window…", command=self.test_move_dialog)
        other_menu.add_command(label="COM Port Assistant…", command=self.port_assistant)
        other_menu.add_command(label="Extended Control…", command=self.extended_control)
        bar.add_cascade(label="Other", menu=other_menu)

        help_menu = tk.Menu(bar, tearoff=False)
        help_menu.add_command(label="About MCC4 Motion and Temperature Control GUI", command=self.about)
        bar.add_cascade(label="About", menu=help_menu)
        self.config(menu=bar)
        self.bind_all("<Control-n>", lambda e: self.file_new())
        self.bind_all("<Control-o>", lambda e: self.file_open())
        self.bind_all("<Control-s>", lambda e: self.file_save())

    def _build_ui(self):
        outer = ttk.Frame(self, padding=(14, 12, 14, 8))
        outer.pack(fill="both", expand=True)
        top = ttk.Frame(outer)
        top.pack(fill="x", pady=(0, 10))
        ttk.Label(top, text="MCC4 Motion and Temperature Control GUI", style="Title.TLabel").pack(side="left")
        ttk.Label(top, text="Four-axis motion + temperature controller", foreground="#607286").pack(side="left", padx=(12, 0), pady=(8, 0))

        connect = ttk.Frame(outer, style="Card.TFrame", padding=10)
        connect.pack(fill="x", pady=(0, 10))
        ttk.Label(connect, text="Controller connection", style="Section.TLabel").pack(side="left", padx=(0, 12))
        ttk.Label(connect, text="Serial port", style="Card.TLabel").pack(side="left")
        self.port_box = ttk.Combobox(connect, textvariable=self.port_var, width=12, values=["COM1", "COM2", "COM3", "COM4"], state="normal")
        self.port_box.pack(side="left", padx=(6, 8))
        ttk.Button(connect, text="Refresh Ports", command=self.refresh_ports).pack(side="left", padx=(0, 8))
        self.connect_button = ttk.Button(connect, text="Connect", style="Accent.TButton", command=self.connect_controller)
        self.connect_button.pack(side="left", padx=(0, 6))
        self.disconnect_button = ttk.Button(connect, text="Disconnect", command=self.disconnect_controller, state="disabled")
        self.disconnect_button.pack(side="left")
        ttk.Separator(connect, orient="vertical").pack(side="left", fill="y", padx=14)
        self.link_badge = self._badge(connect, "Link", self.link_text, "#64748b")
        self.run_badge = self._badge(connect, "Motion", self.run_text, "#64748b")
        self.limit_badge = self._badge(connect, "Limit", self.limit_badge_text, "#15803d")

        tabs = ttk.Notebook(outer)
        tabs.pack(fill="both", expand=True)
        program_tab = ttk.Frame(tabs, style="Card.TFrame", padding=10)
        manual_tab = ttk.Frame(tabs, style="Card.TFrame", padding=10)
        temperature_tab = ttk.Frame(tabs, style="Card.TFrame", padding=10)
        tabs.add(program_tab, text="Program Mode")
        tabs.add(manual_tab, text="Manual Mode")
        tabs.add(temperature_tab, text="Temperature Control")
        tabs.select(manual_tab)
        self._build_temperature_tab(temperature_tab)

        program_head = ttk.Frame(program_tab, style="Card.TFrame")
        program_head.pack(fill="x", pady=(0, 7))
        ttk.Label(program_head, text="Program editor", style="Section.TLabel").pack(side="left")
        ttk.Label(program_head, text="One controller command per line", style="Hint.TLabel").pack(side="right")
        text_frame = ttk.Frame(program_tab, style="Card.TFrame")
        text_frame.pack(fill="both", expand=True)
        self.program_text = tk.Text(text_frame, wrap="none", undo=True, font=("Consolas", 10),
                                    bg="#fbfdff", fg="#1f2b3a", insertbackground="#1f2b3a",
                                    relief="solid", bd=1, padx=9, pady=7)
        yscroll = ttk.Scrollbar(text_frame, orient="vertical", command=self.program_text.yview)
        xscroll = ttk.Scrollbar(text_frame, orient="horizontal", command=self.program_text.xview)
        self.program_text.configure(yscrollcommand=yscroll.set, xscrollcommand=xscroll.set)
        self.program_text.grid(row=0, column=0, sticky="nsew")
        yscroll.grid(row=0, column=1, sticky="ns")
        xscroll.grid(row=1, column=0, sticky="ew")
        text_frame.rowconfigure(0, weight=1)
        text_frame.columnconfigure(0, weight=1)
        self.program_text.insert("1.0", "; MCC4 program\n; Example: G01 X10 Y10 F100\n")

        run_row = ttk.Frame(program_tab, style="Card.TFrame")
        run_row.pack(fill="x", pady=(9, 2))
        ttk.Label(run_row, text="Cycles", style="Card.TLabel").pack(side="left")
        ttk.Entry(run_row, textvariable=self.cycle_var, width=5).pack(side="left", padx=(6, 12))
        ttk.Button(run_row, text="Start Program", style="Accent.TButton", command=self.start_program).pack(side="left", padx=(0, 6))
        ttk.Button(run_row, text="Pause", command=self.pause_program).pack(side="left", padx=3)
        ttk.Button(run_row, text="Resume", command=self.resume_program).pack(side="left", padx=3)
        ttk.Button(run_row, text="Stop", command=self.stop_program).pack(side="left", padx=3)
        ttk.Button(run_row, text="Emergency Stop", style="Danger.TButton", command=self.emergency_stop).pack(side="right")

        parameter_bar = ttk.Frame(manual_tab, style="Card.TFrame")
        parameter_bar.pack(fill="x", pady=(0, 9))
        ttk.Button(parameter_bar, text="Controller Parameters", command=self.open_parameters).pack(side="left")

        manual_panes = ttk.Panedwindow(manual_tab, orient="horizontal")
        manual_panes.pack(fill="both", expand=True)
        visual_card = ttk.Frame(manual_panes, style="Card.TFrame", padding=10)
        controls_card = ttk.Frame(manual_panes, style="Card.TFrame", padding=10)
        manual_panes.add(visual_card, weight=1)
        manual_panes.add(controls_card, weight=2)

        z_panel = ttk.LabelFrame(visual_card, text="Z position", padding=6)
        z_panel.pack(fill="both", expand=True, pady=(0, 7))
        self.z_position_canvas = tk.Canvas(z_panel, width=300, height=280, bg="white",
                                          highlightthickness=1, highlightbackground="#cbd5e1")
        self.z_position_canvas.pack(fill="both", expand=True)
        self.z_position_canvas.bind("<Configure>", lambda _event: self._draw_position_visuals())
        ttk.Label(z_panel, textvariable=self.z_value_var, style="Section.TLabel").pack(anchor="center", pady=(4, 0))

        t_panel = ttk.LabelFrame(visual_card, text="T rotation", padding=6)
        t_panel.pack(fill="both", expand=True)
        self.t_rotation_canvas = tk.Canvas(t_panel, width=300, height=230, bg="white",
                                          highlightthickness=1, highlightbackground="#cbd5e1")
        self.t_rotation_canvas.pack(fill="both", expand=True)
        self.t_rotation_canvas.bind("<Configure>", lambda _event: self._draw_position_visuals())
        ttk.Label(t_panel, textvariable=self.t_value_var, style="Section.TLabel").pack(anchor="center", pady=(4, 0))

        settings_row = ttk.Frame(controls_card, style="Card.TFrame")
        settings_row.pack(fill="x", pady=(0, 8))
        settings_row.columnconfigure(0, weight=1)
        settings_row.columnconfigure(1, weight=1)

        speed_card = ttk.LabelFrame(settings_row, text="Axis Speed", padding=7)
        speed_card.grid(row=0, column=0, sticky="nsew", padx=(0, 4))
        ttk.Label(speed_card, text="Speed and acceleration apply per axis.",
                  style="Hint.TLabel").pack(anchor="w", pady=(0, 5))
        speed_table = ttk.Frame(speed_card, style="Card.TFrame")
        speed_table.pack(fill="x")
        speed_headers = (("Axis", 4), ("Speed", 8), ("Accel", 8), ("Apply", 7))
        for col, (label, width) in enumerate(speed_headers):
            ttk.Label(speed_table, text=label, width=width, style="Hint.TLabel",
                      anchor="center").grid(row=0, column=col, padx=1, pady=3)
        for i, axis in enumerate(AXES):
            row = i + 1
            ttk.Label(speed_table, text=axis, width=4, style="Card.TLabel",
                      font=("Segoe UI Semibold", 10)).grid(row=row, column=0, padx=2, pady=3)
            speed_var = tk.StringVar(value="")
            accel_var = tk.StringVar(value="")
            self.speed_vars.append(speed_var)
            self.accel_vars.append(accel_var)
            for col, var, width in ((1, speed_var, 8), (2, accel_var, 8)):
                widget = ttk.Entry(speed_table, textvariable=var, width=width, justify="right")
                widget.grid(row=row, column=col, padx=2, pady=2)
                self.parameter_widgets.append(widget)
            apply_button = ttk.Button(speed_table, text="Apply",
                                      command=lambda idx=i: self.apply_axis_speed(idx))
            apply_button.grid(row=row, column=3, padx=2, pady=2)
            self.parameter_widgets.append(apply_button)

        limits_card = ttk.LabelFrame(settings_row, text="Limits", padding=7)
        limits_card.grid(row=0, column=1, sticky="nsew", padx=(4, 0))
        ttk.Label(limits_card, text="Limit values use displayed axis units. T uses the same doubled scale as manual movement (180 displayed = 90 controller units).",
                  style="Hint.TLabel", wraplength=280, justify="left").pack(anchor="w", pady=(0, 5))
        limits_table = ttk.Frame(limits_card, style="Card.TFrame")
        limits_table.pack(fill="x")
        limit_headers = (("Axis", 4), ("Soft −", 7), ("Soft +", 7),
                         ("Soft", 4), ("Hard", 4), ("Apply", 7))
        for col, (label, width) in enumerate(limit_headers):
            ttk.Label(limits_table, text=label, width=width, style="Hint.TLabel",
                      anchor="center").grid(row=0, column=col, padx=1, pady=3)
        for i, axis in enumerate(AXES):
            row = i + 1
            ttk.Label(limits_table, text=axis, width=4, style="Card.TLabel",
                      font=("Segoe UI Semibold", 10)).grid(row=row, column=0, padx=2, pady=3)
            negative_var = tk.StringVar(value="")
            positive_var = tk.StringVar(value="")
            self.neg_vars.append(negative_var)
            self.pos_vars.append(positive_var)
            for col, var in ((1, negative_var), (2, positive_var)):
                widget = ttk.Entry(limits_table, textvariable=var, width=7, justify="right")
                widget.grid(row=row, column=col, padx=2, pady=2)
                self.parameter_widgets.append(widget)
            soft_check = ttk.Checkbutton(limits_table, variable=self.soft_vars[i])
            soft_check.grid(row=row, column=3, padx=2)
            hard_check = ttk.Checkbutton(limits_table, variable=self.hard_vars[i])
            hard_check.grid(row=row, column=4, padx=2)
            apply_button = ttk.Button(limits_table, text="Apply",
                                      command=lambda idx=i: self.apply_axis_limits(idx))
            apply_button.grid(row=row, column=5, padx=2, pady=2)
            self.parameter_widgets.extend((soft_check, hard_check, apply_button))

        axis_group = ttk.LabelFrame(controls_card, text="Manual Movements", padding=8)
        axis_group.pack(fill="x", pady=(0, 8))
        axis_group.columnconfigure(1, weight=1)
        axis_group.columnconfigure(4, weight=1)
        axis_group.columnconfigure(6, weight=1)
        axis_group.columnconfigure(7, weight=1)
        ttk.Label(axis_group, text="Axis", style="Hint.TLabel").grid(row=0, column=0, sticky="w")
        ttk.Label(axis_group, text="Position", style="Hint.TLabel").grid(row=0, column=1, sticky="w", padx=4)
        ttk.Label(axis_group, text="Current Speed", style="Hint.TLabel").grid(row=0, column=2, sticky="w", padx=4)
        ttk.Label(axis_group, text="Jog", style="Hint.TLabel").grid(row=0, column=3)
        ttk.Label(axis_group, text="Set Step Distance", style="Hint.TLabel").grid(row=0, column=4, columnspan=2)
        ttk.Label(axis_group, text="Set Zero", style="Hint.TLabel").grid(row=0, column=6)
        ttk.Label(axis_group, text="Home", style="Hint.TLabel").grid(row=0, column=7)
        for i, axis in enumerate(AXES):
            row = i + 2
            ttk.Label(axis_group, text=axis, style="Card.TLabel", font=("Segoe UI Semibold", 10)).grid(row=row, column=0, sticky="w", pady=3)
            self.pos_labels[axis] = ttk.Label(axis_group, text="—", width=15, style="Card.TLabel")
            self.pos_labels[axis].grid(row=row, column=1, sticky="w", padx=4)
            self.speed_labels[axis] = ttk.Label(axis_group, text="—", width=10, style="Card.TLabel")
            self.speed_labels[axis].grid(row=row, column=2, sticky="w", padx=4)
            jog_frame = ttk.Frame(axis_group)
            jog_frame.grid(row=row, column=3, padx=2, pady=2)
            plus_button = ttk.Button(jog_frame, text=axis+"+", width=4,
                                     command=lambda idx=i: self.manual_step(idx, 1))
            minus_button = ttk.Button(jog_frame, text=axis+"−", width=4,
                                      command=lambda idx=i: self.manual_step(idx, -1))
            plus_button.pack(side="left", padx=(0, 1))
            minus_button.pack(side="left")
            if axis == "Z":
                plus_button.tooltip = Tooltip(plus_button, "Up")
                minus_button.tooltip = Tooltip(minus_button, "Down")
            elif axis == "T":
                plus_button.tooltip = Tooltip(plus_button, "Counterclockwise rotation")
                minus_button.tooltip = Tooltip(minus_button, "Clockwise rotation")
            distance_var = tk.StringVar(value="")
            self.manual_distance_vars.append(distance_var)
            distance_entry = ttk.Entry(axis_group, textvariable=distance_var, width=9, justify="right")
            distance_entry.grid(row=row, column=4, padx=2, pady=2)
            set_distance_button = ttk.Button(axis_group, text="Set", command=lambda idx=i: self.apply_manual_distance(idx))
            set_distance_button.grid(row=row, column=5, padx=2, pady=2)
            self.parameter_widgets.extend((distance_entry, set_distance_button))
            zero_button = ttk.Button(axis_group, text="Zero Location",
                                     command=lambda idx=i: self.zero_axis(idx))
            zero_button.grid(row=row, column=6, padx=3, pady=2)
            zero_button.tooltip = Tooltip(zero_button, "Set current location as zero")
            ttk.Button(axis_group, text="Home", width=7,
                       command=lambda idx=i: self.return_axis_to_zero(idx)).grid(row=row, column=7, padx=3, pady=2)

        queue_section = ttk.LabelFrame(controls_card, text="Motion command queue", padding=8)
        queue_section.pack(fill="x", pady=(0, 8))
        ttk.Label(queue_section, textvariable=self.motion_queue_count_var, style="Card.TLabel").pack(side="left", padx=(0, 10))
        ttk.Button(queue_section, text="Stop Motion & Clear Queue",
                   command=self.stop_motion_and_clear_queue).pack(side="right")

        ttk.Label(controls_card, text="The Set button updates that axis's step distance. T distance is halved before writing (180 → 90). Save to ROM to keep changes after reboot.",
                  style="Hint.TLabel", wraplength=700).pack(fill="x", anchor="w", pady=(0, 6))
        self.limit_detail = ttk.Label(controls_card, textvariable=self.limit_text, style="Hint.TLabel", wraplength=700)
        self.limit_detail.pack(fill="x", anchor="w", pady=(0, 8))
        ttk.Button(controls_card, text="Emergency Stop", style="Danger.TButton",
                   command=self.emergency_stop).pack(anchor="e")
        self._draw_position_visuals()

        self._set_link_visual(False)
        self._set_run_visual(False)
        self._refresh_parameter_controls()

        footer = ttk.Frame(outer)
        footer.pack(fill="x", pady=(8, 0))
        ttk.Separator(footer).pack(fill="x", pady=(0, 6))
        ttk.Label(footer, textvariable=self.footer_text).pack(side="left", fill="x", expand=True)
        ttk.Label(footer, text="MCC4DLL x86 bridge", foreground="#64748b").pack(side="right")

    def _build_temperature_tab(self, parent):
        main = ttk.Frame(parent, style="Card.TFrame")
        main.pack(fill="both", expand=True)

        body = ttk.Frame(main, style="Card.TFrame")
        body.pack(fill="both", expand=True)
        body.columnconfigure(0, weight=1)
        body.columnconfigure(1, weight=0)
        body.rowconfigure(0, weight=1)
        left = ttk.Frame(body, style="Card.TFrame")
        left.grid(row=0, column=0, sticky="nsew")
        right = ttk.Frame(body, style="Card.TFrame", width=270)
        right.grid(row=0, column=1, sticky="ns", padx=(10, 0))
        right.grid_propagate(False)

        heating_panel = ttk.LabelFrame(right, text="Heating Module", padding=10)
        heating_panel.pack(fill="x", pady=(0, 10))
        self.temp_start_button = ttk.Button(
            heating_panel, text="Start Heating", style="Accent.TButton",
            command=lambda: self._write_temperature_run(True))
        self.temp_start_button.pack(fill="x", pady=(0, 5))
        self.temp_stop_button = ttk.Button(
            heating_panel, text="Stop Heating Module",
            command=lambda: self._write_temperature_run(False))
        self.temp_stop_button.pack(fill="x")

        pid_panel = ttk.LabelFrame(right, text="PID Values", padding=10)
        pid_panel.pack(fill="x")
        ttk.Label(pid_panel, text="Sets the controller PID values. Default is P=150, I=15, and D=3",
                  style="Hint.TLabel", wraplength=210, justify="left").pack(anchor="w", pady=(0, 10))
        self.temp_pid_entries = {}
        self.temp_pid_buttons = []
        for row, name in enumerate(("P", "I", "D")):
            line = ttk.Frame(pid_panel, style="Card.TFrame")
            line.pack(fill="x", pady=4)
            ttk.Label(line, text=name, width=3, style="Card.TLabel",
                      font=("Segoe UI Semibold", 10)).pack(side="left")
            entry = ttk.Entry(line, textvariable=self.temp_pid_vars[name], width=9, justify="right")
            entry.pack(side="left", padx=(4, 6))
            entry.bind("<Return>", lambda _event, key=name: self.write_temperature_pid(key))
            button = ttk.Button(line, text="Set", width=5,
                                command=lambda key=name: self.write_temperature_pid(key))
            button.pack(side="left")
            self.temp_pid_entries[name] = entry
            self.temp_pid_buttons.append(button)

        connection = ttk.LabelFrame(right, text="Temperature Controller Connection", padding=10)
        connection.pack(fill="x", pady=(10, 0))
        port_row = ttk.Frame(connection, style="Card.TFrame")
        port_row.pack(fill="x", pady=(0, 7))
        ttk.Label(port_row, text="Serial port").pack(side="left")
        self.temp_port_box = ttk.Combobox(
            port_row, textvariable=self.temp_port_var, width=9,
            values=["COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8"],
            state="normal")
        self.temp_port_box.pack(side="right")
        connection_buttons = ttk.Frame(connection, style="Card.TFrame")
        connection_buttons.pack(fill="x", pady=(0, 7))
        self.temp_connect_button = ttk.Button(
            connection_buttons, text="Connect", command=self.connect_temperature_controller)
        self.temp_connect_button.pack(side="left", fill="x", expand=True, padx=(0, 3))
        self.temp_disconnect_button = ttk.Button(
            connection_buttons, text="Disconnect", command=self.disconnect_temperature_controller)
        self.temp_disconnect_button.pack(side="left", fill="x", expand=True, padx=(3, 0))
        self.temp_status_label = ttk.Label(
            connection, textvariable=self.temp_status_var, wraplength=220, justify="left")
        self.temp_status_label.pack(fill="x")
        self.temp_status_tooltip = Tooltip(self.temp_status_label, "")

        current_panel = ttk.LabelFrame(left, text="Current Temperature", padding=10)
        current_panel.pack(fill="x", pady=(0, 8))
        temperature_readouts = ttk.Frame(current_panel, style="Card.TFrame")
        temperature_readouts.pack(fill="x")
        for column in range(3):
            temperature_readouts.columnconfigure(column, weight=1)
        for column, (label, variable) in enumerate((
                ("Module Output Temperature", self.temp_current_var),
                ("Module Set Temperature", self.temp_machine_set_display_var),
                ("Estimated Wanted Temperature", self.temp_estimated_wanted_var))):
            ttk.Label(temperature_readouts, text=label, anchor="center",
                      style="Hint.TLabel").grid(row=0, column=column, sticky="ew", padx=4, pady=(0, 3))
            ttk.Label(temperature_readouts, textvariable=variable, anchor="center",
                      justify="center", font=("Segoe UI Semibold", 16),
                      style="Card.TLabel").grid(row=1, column=column, sticky="ew", padx=4)

        settings = ttk.LabelFrame(left, text="Temperature Control", padding=10)
        settings.pack(fill="x", pady=(0, 8))
        for column, weight in ((1, 0), (2, 0), (3, 0), (4, 0), (5, 0)):
            settings.columnconfigure(column, weight=weight)

        ttk.Label(settings, text="Wanted Temp (°C)").grid(row=0, column=0, sticky="w", padx=(0, 8), pady=4)
        self.temp_target_entry = ttk.Entry(settings, textvariable=self.temp_target_var, width=12, justify="right")
        self.temp_target_entry.grid(row=0, column=1, sticky="w", pady=4)
        self.temp_target_entry.bind("<Return>", lambda _event: self.write_temperature_target())
        temp_plus = ttk.Button(settings, text="+", width=4, command=self.increase_temperature)
        temp_minus = ttk.Button(settings, text="−", width=4, command=self.decrease_temperature)
        temp_plus.grid(row=0, column=2, padx=(3, 1), pady=4)
        temp_minus.grid(row=0, column=3, padx=(1, 8), pady=4)
        ttk.Label(settings, text="Module Set Temp (°C)").grid(row=0, column=4, sticky="w", padx=(0, 6), pady=4)
        self.temp_machine_set_entry = ttk.Entry(
            settings, textvariable=self.temp_machine_set_var, width=10, justify="right")
        self.temp_machine_set_entry.grid(row=0, column=5, sticky="w", pady=4)
        self.temp_machine_set_entry.bind(
            "<Return>", lambda _event: self.write_machine_set_temperature())
        self.temp_machine_set_button = ttk.Button(
            settings, text="Set", width=5, command=self.write_machine_set_temperature)
        self.temp_machine_set_button.grid(row=0, column=6, padx=(5, 0), pady=4)
        ttk.Checkbutton(
            settings, text="Set module temperature directly",
            variable=self.temp_manual_machine_var,
            command=self._toggle_temperature_input_mode
        ).grid(row=1, column=4, columnspan=3, sticky="w", padx=(0, 4), pady=4)

        ttk.Label(settings, text="Heating Time (min)").grid(row=1, column=0, sticky="w", padx=(0, 8), pady=4)
        self.temp_heat_entry = ttk.Entry(settings, textvariable=self.temp_heat_var, width=16, justify="right")
        self.temp_heat_entry.grid(row=1, column=1, sticky="w", pady=4)
        self.temp_heat_entry.bind("<Return>", lambda _event: self.write_temperature_heat_time())

        ttk.Label(settings, text="Holding Time (min)").grid(row=2, column=0, sticky="w", padx=(0, 8), pady=4)
        self.temp_hold_entry = ttk.Entry(settings, textvariable=self.temp_hold_var, width=16, justify="right")
        self.temp_hold_entry.grid(row=2, column=1, sticky="w", pady=4)
        self.temp_hold_entry.bind("<Return>", lambda _event: self.write_temperature_hold_time())

        ttk.Label(settings, text="Power Limit (%)").grid(row=3, column=0, sticky="w", padx=(0, 8), pady=4)
        self.temp_power_entry = ttk.Entry(settings, textvariable=self.temp_power_var, width=16, justify="right")
        self.temp_power_entry.grid(row=3, column=1, sticky="w", pady=4)
        self.temp_power_entry.bind("<Return>", lambda _event: self.write_temperature_power())
        power_plus = ttk.Button(settings, text="+", width=4, command=self.increase_temperature_power)
        power_minus = ttk.Button(settings, text="−", width=4, command=self.decrease_temperature_power)
        power_plus.grid(row=3, column=2, padx=(8, 2), pady=4)
        power_minus.grid(row=3, column=3, padx=2, pady=4)
        ttk.Label(settings, text="Wanted mode: 190–325 °C with calibration. Direct mode bypasses that range and calibration; the controller register limit still applies. Max measured module temperature: 235 °C.",
                  style="Hint.TLabel", wraplength=780).grid(row=4, column=0, columnspan=7, sticky="w", pady=(6, 0))

        curve_box = ttk.LabelFrame(left, text="Temperature Curve", padding=6)
        curve_box.pack(fill="both", expand=True, pady=(0, 8))
        self.temp_plot = tk.Canvas(curve_box, height=225, bg="white",
                                   highlightthickness=1, highlightbackground="#cbd5e1")
        self.temp_plot.pack(fill="both", expand=True)
        self.temp_plot.bind("<Configure>", lambda _event: self._draw_temperature_curve())

        tools = ttk.Frame(left, style="Card.TFrame")
        tools.pack(fill="x", pady=(0, 7))
        self.temp_record_button = ttk.Button(tools, text="Start Recording", command=self.start_temperature_recording)
        self.temp_stop_record_button = ttk.Button(tools, text="Stop Recording", command=self.stop_temperature_recording, state="disabled")
        self.temp_export_button = ttk.Button(tools, text="Export CSV", command=self.export_temperature_csv)
        self.temp_clear_button = ttk.Button(tools, text="Clear Curve", command=self.clear_temperature_curve)
        for widget in (self.temp_record_button, self.temp_stop_record_button,
                       self.temp_export_button, self.temp_clear_button):
            widget.pack(side="left", padx=(0, 6))

        self.temp_wanted_controls = [self.temp_target_entry, temp_plus, temp_minus]
        self.temp_machine_controls = [self.temp_machine_set_entry, self.temp_machine_set_button]
        self.temp_write_controls = [
            self.temp_heat_entry, self.temp_hold_entry, self.temp_power_entry,
            power_plus, power_minus, self.temp_start_button,
            *self.temp_pid_entries.values(), *self.temp_pid_buttons,
        ]
        self._update_temperature_controls()
        self._draw_temperature_curve()

    def _update_temperature_controls(self):
        enabled = self.temp_online and not self.temp_busy
        state = "normal" if enabled else "disabled"
        for widget in getattr(self, "temp_write_controls", []):
            widget.configure(state=state)
        wanted_state = "normal" if enabled and not self.temp_manual_machine_var.get() else "disabled"
        machine_state = "normal" if enabled and self.temp_manual_machine_var.get() else "disabled"
        for widget in getattr(self, "temp_wanted_controls", []):
            widget.configure(state=wanted_state)
        for widget in getattr(self, "temp_machine_controls", []):
            widget.configure(state=machine_state)
        if hasattr(self, "temp_stop_button"):
            self.temp_stop_button.configure(state="normal" if self.temp_online else "disabled")
        if hasattr(self, "temp_connect_button"):
            self.temp_connect_button.configure(state="disabled" if self.temp_online else "normal")
            wanted = self.temperature_worker.wanted_port if hasattr(self, "temperature_worker") else self.temp_port_var.get()
            self.temp_disconnect_button.configure(state="normal" if wanted else "disabled")

    def connect_temperature_controller(self):
        port = self.temp_port_var.get().strip().upper()
        if not port:
            messagebox.showwarning("Port required", "Select a temperature controller COM port.", parent=self)
            return
        motion_port = self.port_var.get().strip().upper()
        motion_connecting = str(self.connect_button.cget("state")) == "disabled" and not self.connected
        if (self.connected or motion_connecting) and motion_port == port:
            self.temp_status_var.set("This COM port is already used by the motion controller.")
            return
        self.temp_port_var.set(port)
        self.temp_status_var.set("Connecting to " + port + "...")
        self.temp_status_tooltip.text = ""
        self.temperature_worker.connect(port)
        self._update_temperature_controls()

    def disconnect_temperature_controller(self):
        self.temperature_worker.disconnect()
        self.temp_status_var.set("Disconnecting...")
        self._update_temperature_controls()

    def _submit_temperature(self, operations, description, *, priority_stop=False):
        if not self.temperature_worker.submit(operations, description, priority_stop=priority_stop):
            self.temp_status_var.set("Controller unavailable or command still pending")

    def _temperature_target_value(self):
        if self.temp_manual_machine_var.get():
            value = self.temp_machine_set_var.get()
        else:
            value = self.temp_target_var.get()
        try:
            return float(value or 0)
        except ValueError:
            return 0.0

    def _wanted_temperature_value(self):
        try:
            return float(self.temp_target_var.get() or 0)
        except ValueError:
            return 0.0

    def _machine_setpoint_raw(self, wanted_temperature):
        machine_temperature = TEMP_SETPOINT_SCALE * (wanted_temperature - TEMP_SETPOINT_OFFSET)
        return int(round(machine_temperature * 10))

    def _update_machine_setpoint_display(self, *_args):
        if self.temp_manual_machine_var.get():
            return
        try:
            wanted = float(self.temp_target_var.get())
        except (ValueError, tk.TclError):
            self.temp_machine_set_var.set("--.-")
            return
        raw = self._machine_setpoint_raw(wanted)
        self.temp_machine_set_var.set("%.1f" % (raw / 10.0))

    def _update_machine_set_readout(self, *_args):
        try:
            machine_temperature = float(self.temp_machine_set_var.get())
        except (ValueError, tk.TclError):
            self.temp_machine_set_display_var.set("--.- °C")
            return
        self.temp_machine_set_display_var.set("%.1f °C" % machine_temperature)

    def _set_measured_temperature_readouts(self, machine_temperature, offline=False):
        prefix = "Last: " if offline else ""
        suffix = " (offline)" if offline else ""
        wanted_temperature = machine_temperature / TEMP_SETPOINT_SCALE + TEMP_SETPOINT_OFFSET
        self.temp_current_var.set("%s%.1f °C%s" % (prefix, machine_temperature, suffix))
        self.temp_estimated_wanted_var.set("%s%.1f °C%s" % (prefix, wanted_temperature, suffix))

    def _toggle_temperature_input_mode(self):
        if not self.temp_manual_machine_var.get():
            try:
                machine_temperature = float(self.temp_machine_set_var.get())
                wanted_temperature = machine_temperature / TEMP_SETPOINT_SCALE + TEMP_SETPOINT_OFFSET
                self.temp_target_var.set("%.1f" % wanted_temperature)
            except (ValueError, ZeroDivisionError, tk.TclError):
                pass
        self._update_machine_setpoint_display()
        self._update_temperature_controls()

    def write_temperature_target(self):
        try:
            value = float(self.temp_target_var.get())
            if not TEMP_WANTED_MIN <= value <= TEMP_WANTED_MAX:
                raise ValueError("Wanted temperature must be from 190 to 325 °C.")
            raw = self._machine_setpoint_raw(value)
            if not 0 <= raw <= 65535:
                raise ValueError("Converted module setpoint must fit in one controller register.")
        except (ValueError, OverflowError) as exc:
            self.temp_status_var.set("Invalid target temperature")
            self.temp_status_tooltip.text = str(exc)
            return
        machine_temperature = raw / 10.0
        self._submit_temperature(
            [("register", "seg1_temp", raw)],
            "Module set temperature saved: %.1f °C" % machine_temperature)

    def write_machine_set_temperature(self):
        try:
            machine_temperature = float(self.temp_machine_set_var.get())
            raw = int(round(machine_temperature * 10))
            if not 0 <= raw <= 65535:
                raise ValueError("Module set temperature must fit in one controller register.")
        except (ValueError, OverflowError) as exc:
            self.temp_status_var.set("Invalid module set temperature")
            self.temp_status_tooltip.text = str(exc)
            return
        machine_temperature = raw / 10.0
        self.temp_machine_set_var.set("%.1f" % machine_temperature)
        self._submit_temperature(
            [("register", "seg1_temp", raw)],
            "Module set temperature saved: %.1f °C" % machine_temperature)

    def write_temperature_heat_time(self):
        self._write_temperature_integer("seg1_heat_time", self.temp_heat_var.get(), "Heating time saved")

    def write_temperature_hold_time(self):
        self._write_temperature_integer("seg1_hold_time", self.temp_hold_var.get(), "Holding time saved")

    def _write_temperature_integer(self, name, text, description):
        try:
            value = int(text)
            if not 0 <= value <= 65535:
                raise ValueError("Value must be from 0 to 65535.")
        except (ValueError, OverflowError) as exc:
            self.temp_status_var.set("Invalid time value")
            self.temp_status_tooltip.text = str(exc)
            return
        self._submit_temperature([("register", name, value)], description)

    def write_temperature_power(self):
        self.temp_power_manual_override = True
        try:
            value = max(0, min(100, int(self.temp_power_var.get())))
        except (ValueError, OverflowError):
            self.temp_status_var.set("Enter a power limit from 0 to 100")
            return
        self.temp_power_var.set(str(value))
        self._submit_temperature([("register", "seg1_power", value)], "Power limit saved")

    def write_temperature_pid(self, name):
        try:
            value = int(self.temp_pid_vars[name].get())
            if not 0 <= value <= 65535:
                raise ValueError("PID register values must be from 0 to 65535.")
        except (ValueError, OverflowError) as exc:
            self.temp_status_var.set("Invalid %s value" % name)
            self.temp_status_tooltip.text = str(exc)
            return
        self.temp_pid_vars[name].set(str(value))
        self._submit_temperature([("register", name, value)], "%s value saved" % name)

    def increase_temperature(self):
        value = self._wanted_temperature_value()
        value = TEMP_WANTED_MIN if value < TEMP_WANTED_MIN else min(TEMP_WANTED_MAX, value + 1)
        self.temp_target_var.set("%g" % value)
        self.write_temperature_target()

    def decrease_temperature(self):
        value = self._wanted_temperature_value()
        value = TEMP_WANTED_MIN if value <= TEMP_WANTED_MIN else max(TEMP_WANTED_MIN, value - 1)
        self.temp_target_var.set("%g" % value)
        self.write_temperature_target()

    def increase_temperature_power(self):
        try:
            value = int(self.temp_power_var.get() or 0)
        except ValueError:
            value = 0
        self.temp_power_var.set(str(min(100, value + 10)))
        self.write_temperature_power()

    def decrease_temperature_power(self):
        try:
            value = int(self.temp_power_var.get() or 0)
        except ValueError:
            value = 0
        self.temp_power_var.set(str(max(0, value - 10)))
        self.write_temperature_power()

    def _write_temperature_run(self, start):
        self._submit_temperature([("coil", "run", start)],
                                 "Started" if start else "Stopped",
                                 priority_stop=not start)

    def start_temperature_recording(self):
        self.temp_samples = []
        self.temp_record_start = time.monotonic()
        self.temp_recording = True
        self.temp_record_button.configure(state="disabled")
        self.temp_stop_record_button.configure(state="normal")
        self._draw_temperature_curve()
        self.temp_status_var.set("Recording")

    def stop_temperature_recording(self):
        self.temp_recording = False
        self.temp_record_start = None
        self.temp_record_button.configure(state="normal")
        self.temp_stop_record_button.configure(state="disabled")
        self.temp_status_var.set("Recording stopped")

    def clear_temperature_curve(self):
        self.temp_samples = []
        self.temp_record_start = time.monotonic() if self.temp_recording else None
        self._draw_temperature_curve()

    def export_temperature_csv(self):
        if not self.temp_samples:
            messagebox.showinfo("Export CSV", "No recorded data to export.", parent=self)
            return
        path = filedialog.asksaveasfilename(
            parent=self, title="Export Temperature Data",
            initialfile="temperature_%s.csv" % datetime.now().strftime("%Y%m%d_%H%M%S"),
            defaultextension=".csv", filetypes=[("CSV Files", "*.csv")])
        if not path:
            return
        try:
            with open(path, "w", newline="", encoding="utf-8") as handle:
                writer = csv.writer(handle)
                writer.writerow(["Time (s)", "Actual Temperature (C)", "Target Temperature (C)"])
                writer.writerows(self.temp_samples)
            messagebox.showinfo("Export CSV", "Saved %d samples to:\n%s" % (len(self.temp_samples), path), parent=self)
        except Exception as exc:
            messagebox.showerror("Export Error", str(exc), parent=self)

    def _draw_temperature_curve(self):
        canvas = getattr(self, "temp_plot", None)
        if canvas is None:
            return
        canvas.delete("all")
        width = max(300, canvas.winfo_width())
        height = max(150, canvas.winfo_height())
        left, top, right, bottom = 55, 18, 18, 34
        plot_width = max(1, width - left - right)
        plot_height = max(1, height - top - bottom)
        canvas.create_rectangle(left, top, left + plot_width, top + plot_height, outline="#1f2937")
        if not self.temp_samples:
            canvas.create_text(left + plot_width / 2, top + plot_height / 2,
                               text="Start Recording to capture temperature", fill="#64748b")
            canvas.create_text(left, height - 8, anchor="w", text="Time (s)", fill="#1f2937")
            return
        times = [sample[0] for sample in self.temp_samples]
        actual = [sample[1] for sample in self.temp_samples]
        target = [sample[2] for sample in self.temp_samples]
        xmin, xmax = times[0], max(times[-1], times[0] + 1)
        ymin, ymax = min(actual + target), max(actual + target)
        if ymax - ymin < 1:
            ymin -= 1
            ymax += 1
        else:
            padding = (ymax - ymin) * 0.08
            ymin -= padding
            ymax += padding
        for index in range(1, 5):
            y = top + plot_height * index / 5
            canvas.create_line(left, y, left + plot_width, y, fill="#d1d5db", dash=(3, 3))
        def point(x, value):
            return (left + (x - xmin) / (xmax - xmin) * plot_width,
                    top + plot_height - (value - ymin) / (ymax - ymin) * plot_height)
        for values, color, dash in ((actual, "#2563eb", ()), (target, "#dc2626", (5, 3))):
            coords = []
            for x, value in zip(times, values):
                coords.extend(point(x, value))
            if len(coords) >= 4:
                options = {"fill": color, "width": 2}
                if dash:
                    options["dash"] = dash
                canvas.create_line(*coords, **options)
        canvas.create_text(8, top, anchor="w", text="%.1f" % ymax, fill="#1f2937")
        canvas.create_text(8, top + plot_height, anchor="w", text="%.1f" % ymin, fill="#1f2937")
        canvas.create_text(left, height - 8, anchor="w", text="Time (s)", fill="#1f2937")
        canvas.create_line(width - 150, 13, width - 130, 13, fill="#2563eb", width=2)
        canvas.create_text(width - 125, 13, anchor="w", text="Actual", fill="#1f2937")
        canvas.create_line(width - 75, 13, width - 55, 13, fill="#dc2626", width=2, dash=(5, 3))
        canvas.create_text(width - 50, 13, anchor="w", text="Target", fill="#1f2937")

    def _badge(self, parent, label, variable, color):
        holder = ttk.Frame(parent, style="Card.TFrame", padding=(8, 3))
        holder.pack(side="left", padx=3)
        dot = tk.Canvas(holder, width=10, height=10, bg="white", highlightthickness=0)
        dot.pack(side="left", padx=(0, 5))
        oval = dot.create_oval(1, 1, 9, 9, fill=color, outline=color)
        ttk.Label(holder, text=label+":", style="Card.TLabel").pack(side="left")
        ttk.Label(holder, textvariable=variable, style="Card.TLabel", font=("Segoe UI Semibold", 8)).pack(side="left", padx=(4, 0))
        return (dot, oval)

    def _set_badge(self, badge, color):
        badge[0].itemconfigure(badge[1], fill=color, outline=color)

    def _set_link_visual(self, linked):
        self.link_text.set("LINKED" if linked else "NOT LINKED")
        self._set_badge(self.link_badge, "#16a34a" if linked else "#94a3b8")
        self.connect_button.configure(state="disabled" if linked else "normal")
        self.disconnect_button.configure(state="normal" if linked else "disabled")

    def _set_run_visual(self, moving):
        self.run_text.set("RUNNING" if moving else "STOPPED")
        self._set_badge(self.run_badge, "#16a34a" if moving else "#94a3b8")

    def _parameters_locked(self):
        return (self.motion_active or self.motion_pending or self.program_active
                or self._manual_queue_pending())

    def _manual_queue_pending(self):
        with self.manual_queue_lock:
            return bool(self.manual_command_queue or self.manual_queue_worker_active
                        or self.manual_queue_stop_pending)

    def _enqueue_manual_command(self, command, args, label, wait_for_motion):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect to the controller before sending motion commands.", parent=self)
            return
        if self.program_active:
            messagebox.showinfo("Program running", "Manual actions cannot be queued while a program is running.", parent=self)
            return
        with self.manual_queue_lock:
            if self.manual_queue_stop_pending:
                blocked_by_stop = True
                count = len(self.manual_command_queue)
            else:
                blocked_by_stop = False
                item = (command, tuple(args), label, wait_for_motion)
                self.manual_command_queue.append(item)
                count = len(self.manual_command_queue)
        if blocked_by_stop:
            messagebox.showinfo("Stop in progress", "Wait for the stop command to finish before queuing another action.", parent=self)
            return
        self.events.put(("motion_queue_count", count))
        self.footer_text.set("Queued: " + label)
        self._refresh_parameter_controls()
        self._start_manual_queue_worker()

    def _start_manual_queue_worker(self):
        with self.manual_queue_lock:
            if (self.manual_queue_worker_active or self.manual_queue_stop_pending
                    or not self.manual_command_queue):
                return
            self.manual_queue_worker_active = True
            generation = self.manual_queue_generation
        threading.Thread(target=self._manual_queue_worker, args=(generation,), daemon=True).start()

    def _manual_queue_generation_is_current(self, generation):
        with self.manual_queue_lock:
            return generation == self.manual_queue_generation

    def _wait_until_controller_idle(self, generation):
        while self._manual_queue_generation_is_current(generation):
            if self.program_active:
                time.sleep(0.1)
                continue
            state = self.client.request("STATE").split("|")
            if len(state) < 2:
                raise BridgeError("Could not read controller motion state.")
            if state[0] != "1":
                raise BridgeError("The controller connection was lost while actions were queued.")
            if state[1] == "0":
                return state
            time.sleep(0.08)
        return None

    def _wait_for_queued_motion(self, generation):
        sent_at = time.monotonic()
        saw_motion = False
        while self._manual_queue_generation_is_current(generation):
            state = self.client.request("STATE").split("|")
            if len(state) < 2:
                raise BridgeError("Could not read controller motion state.")
            if state[0] != "1":
                raise BridgeError("The controller connection was lost during motion.")
            moving = state[1] == "1"
            if moving:
                saw_motion = True
            elif saw_motion or time.monotonic() - sent_at >= 0.5:
                return True
            time.sleep(0.08)
        return False

    def _manual_queue_worker(self, generation):
        try:
            while self._manual_queue_generation_is_current(generation):
                with self.manual_queue_lock:
                    if not self.manual_command_queue:
                        break
                    item = self.manual_command_queue[0]
                command, args, label, wait_for_motion = item
                idle_state = self._wait_until_controller_idle(generation)
                if idle_state is None:
                    break
                if command == "RETURN_ZERO":
                    axis, speed, acceleration = args
                    positions = idle_state[2].split(",") if len(idle_state) > 2 and idle_state[2] else []
                    if axis >= len(positions):
                        raise BridgeError("Could not read the current %s position." % AXES[axis])
                    current_position = float(positions[axis])
                    if not math.isfinite(current_position):
                        raise BridgeError("The current %s position is not a finite number." % AXES[axis])
                    distance = abs(current_position)
                    unit = "°" if axis == AXES.index("T") else "mm"
                    shown_distance = distance * 2 if axis == AXES.index("T") else distance
                    if distance <= 0.0001:
                        label = "%s is already at zero" % AXES[axis]
                        value = "Already at zero"
                        command = None
                        wait_for_motion = False
                    else:
                        label = "Home %s (%.4f %s to zero)" % (AXES[axis], shown_distance, unit)
                        command = "ABS"
                        args = (axis, 0.0, speed, acceleration)
                if command is not None:
                    with self.manual_dispatch_lock:
                        if not self._manual_queue_generation_is_current(generation):
                            break
                        value = self.client.request(command, *args)
                if wait_for_motion and not self._wait_for_queued_motion(generation):
                    break
                with self.manual_queue_lock:
                    if generation != self.manual_queue_generation:
                        break
                    if self.manual_command_queue and self.manual_command_queue[0] is item:
                        self.manual_command_queue.pop(0)
                    count = len(self.manual_command_queue)
                self.events.put(("motion_queue_count", count))
                self.events.put(("motion_queue_result", label, value, None))
        except Exception as exc:
            with self.manual_queue_lock:
                if generation == self.manual_queue_generation:
                    self.manual_command_queue.clear()
                    count = 0
                else:
                    count = len(self.manual_command_queue)
            self.events.put(("motion_queue_count", count))
            if generation == self.manual_queue_generation:
                self.events.put(("motion_queue_result", "Queued action", None, str(exc)))
        finally:
            with self.manual_queue_lock:
                self.manual_queue_worker_active = False
                count = len(self.manual_command_queue)
                restart = bool(count and not self.manual_queue_stop_pending)
            self.events.put(("motion_queue_count", count))
            self.events.put(("motion_queue_idle",))
            if restart:
                self._start_manual_queue_worker()

    def _refresh_parameter_controls(self):
        enabled = not self._parameters_locked()
        state = "normal" if enabled else "disabled"
        for widget in self.parameter_widgets:
            widget.configure(state=state)
        dialog = getattr(self, "parameter_dialog", None)
        if dialog and dialog.winfo_exists():
            dialog.set_parameter_controls_enabled(enabled)

    def _require_idle_for_parameter_change(self):
        if not self._parameters_locked():
            return True
        messagebox.showinfo("Motion in progress", "Wait until all motion has stopped before changing controller parameters.", parent=self)
        return False

    def _mark_motion_pending(self):
        self.motion_pending = True
        self.motion_pending_until = time.monotonic() + 1.5
        self._refresh_parameter_controls()

    def _motion_request_done(self, value, error):
        if error:
            self.motion_pending = False
            self._refresh_parameter_controls()
        self._set_footer(value, error)

    def _call(self, command, *args, on_done=None):
        def run():
            try:
                value = self.client.request(command, *args)
                self.events.put(("done", on_done, value, None))
            except Exception as exc:
                self.events.put(("done", on_done, None, str(exc)))
        threading.Thread(target=run, daemon=True).start()

    def _call_motion_barrier(self, command, *args, on_done=None):
        """Order a stop/disconnect after any in-flight queued or program move."""
        def run():
            try:
                with self.manual_dispatch_lock:
                    value = self.client.request(command, *args)
                self.events.put(("done", on_done, value, None))
            except Exception as exc:
                self.events.put(("done", on_done, None, str(exc)))
        threading.Thread(target=run, daemon=True).start()

    def _sequence(self, commands, on_done=None):
        def run():
            try:
                last = ""
                for command, args in commands:
                    last = self.client.request(command, *args)
                self.events.put(("done", on_done, last, None))
            except Exception as exc:
                self.events.put(("done", on_done, None, str(exc)))
        threading.Thread(target=run, daemon=True).start()

    def _pump_events(self):
        try:
            while True:
                item = self.events.get_nowait()
                if item[0] == "done":
                    _, callback, value, error = item
                    if callback:
                        callback(value, error)
                elif item[0] == "state":
                    self._apply_state(item[1])
                elif item[0] == "program":
                    self.footer_text.set(item[1])
                    if item[2] is not None:
                        self.program_active = False
                        self.program_gate.set()
                        self._refresh_parameter_controls()
                elif item[0] == "poll_end":
                    self.poll_busy = False
                elif item[0] == "motion_queue_count":
                    self._refresh_parameter_controls()
                elif item[0] == "motion_queue_result":
                    _, label, value, error = item
                    if error:
                        self.footer_text.set("%s failed: %s. Remaining queued actions were cleared." % (label, error))
                        messagebox.showerror("Queued action failed", error, parent=self)
                    else:
                        self.footer_text.set(label + " complete.")
                elif item[0] == "motion_queue_idle":
                    self._refresh_parameter_controls()
                elif item[0] == "temp_online":
                    self.temp_online = item[1]
                    if not self.temp_online and self.temp_last_temperature is not None:
                        self._set_measured_temperature_readouts(self.temp_last_temperature, offline=True)
                    self._update_temperature_controls()
                elif item[0] == "temp_busy":
                    self.temp_busy = item[1]
                    self._update_temperature_controls()
                elif item[0] == "temp_status":
                    _, message, detail = item
                    self.temp_status_var.set(message)
                    self.temp_status_tooltip.text = detail or message
                elif item[0] == "temp_initial":
                    values = item[1]
                    self.temp_power_var.set(str(int(values["seg1_power"])))
                    self.temp_heat_var.set(str(int(values["seg1_heat_time"])))
                    self.temp_hold_var.set(str(int(values["seg1_hold_time"])))
                    for name in ("P", "I", "D"):
                        self.temp_pid_vars[name].set(str(int(values[name])))
                    self.temp_power_manual_override = True
                elif item[0] == "temp_read":
                    temperature = item[1]
                    self.temp_last_temperature = temperature
                    self._set_measured_temperature_readouts(temperature)
                    if (not self.temp_power_manual_override and not self.temp_busy
                            and self.focus_get() is not self.temp_power_entry):
                        difference = abs(temperature - self._temperature_target_value())
                        self.temp_power_var.set("10" if difference <= 2 else "50" if difference <= 10 else "100")
                    if self.temp_recording:
                        elapsed = time.monotonic() - self.temp_record_start
                        self.temp_samples.append((elapsed, temperature, self._temperature_target_value()))
                        self._draw_temperature_curve()
                    self.temp_status_var.set("Recording" if self.temp_recording else "OK")
                    self.temp_status_tooltip.text = self.temp_status_var.get()
        except queue.Empty:
            pass
        with self.manual_queue_lock:
            count = len(self.manual_command_queue)
        self.motion_queue_count_var.set("Commands in queue: %d (active included)" % count)
        self.after(100, self._pump_events)

    def _poll_state(self):
        if self.connected and not self.poll_busy:
            self.poll_busy = True
            def run_poll():
                try:
                    state = self.client.request("STATE")
                    self.events.put(("state", state))
                except Exception as exc:
                    self.events.put(("done", lambda v,e: self.footer_text.set("Controller status error: " + e), None, str(exc)))
                finally:
                    self.events.put(("poll_end",))
            threading.Thread(target=run_poll, daemon=True).start()
        self.after(500, self._poll_state)

    def _apply_state(self, payload):
        parts = payload.split("|")
        if len(parts) < 6:
            return
        linked = parts[0] == "1"
        moving = parts[1] == "1"
        self.connected = linked
        self._set_link_visual(linked)
        self._set_run_visual(moving)
        self.motion_active = moving
        if moving:
            self.motion_pending = False
        elif self.motion_pending and time.monotonic() >= self.motion_pending_until:
            self.motion_pending = False
        self._refresh_parameter_controls()
        try:
            positions = [float(v) for v in parts[2].split(",")]
            speeds = [float(v) for v in parts[3].split(",")]
            for i, axis in enumerate(AXES):
                if i < len(positions):
                    self.axis_positions[i] = positions[i]
                    display_position = positions[i] * 2 if axis == "T" else positions[i]
                    suffix = "°" if axis == "T" else " mm"
                    self.pos_labels[axis].configure(text="%.4f%s" % (display_position, suffix))
                if i < len(speeds): self.speed_labels[axis].configure(text="%.3f" % speeds[i])
            self._draw_position_visuals()
        except (ValueError, IndexError):
            pass
        try:
            inputs = int(parts[4], 16)
            active = [name for name, bit in LIMIT_BITS.items() if inputs & (1 << bit)]
            if active:
                self.limit_badge_text.set("LIMIT STOP" if not moving else "LIMIT SIGNAL")
                self._set_badge(self.limit_badge, "#dc2626")
                self.limit_detail.configure(foreground="#b91c1c")
                self.limit_text.set("Limit input signal: " + ", ".join(active) + (" (motion idle)" if not moving else " (motion active)"))
            else:
                self.limit_badge_text.set("LIMITS CLEAR")
                self._set_badge(self.limit_badge, "#16a34a")
                self.limit_detail.configure(foreground="#64748b")
                self.limit_text.set("No limit input signal reported")
        except ValueError:
            pass

    def _draw_position_visuals(self):
        if self.z_position_canvas is not None:
            canvas = self.z_position_canvas
            canvas.delete("all")
            width = canvas.winfo_width() if canvas.winfo_width() > 1 else int(canvas.cget("width"))
            height = canvas.winfo_height() if canvas.winfo_height() > 1 else int(canvas.cget("height"))
            top, bottom = 28, height - 28
            bar_left, bar_right = width * 0.34, width * 0.64
            try:
                low = float(self.neg_vars[2].get())
                high = float(self.pos_vars[2].get())
                if not math.isfinite(low) or not math.isfinite(high) or low >= high:
                    raise ValueError()
            except (ValueError, IndexError):
                low, high = -100.0, 100.0
            canvas.create_text((bar_left + bar_right) / 2, 14, text="+Z", fill="#1e293b",
                               font=("Segoe UI Semibold", 10))
            canvas.create_rectangle(bar_left, top, bar_right, bottom, fill="#eaf2fb",
                                    outline="#475569", width=2)
            canvas.create_text(bar_left - 7, top, text="%.4g" % high, anchor="e",
                               fill="#64748b", font=("Segoe UI", 8))
            canvas.create_text(bar_left - 7, bottom, text="%.4g" % low, anchor="e",
                               fill="#64748b", font=("Segoe UI", 8))
            canvas.create_text((bar_left + bar_right) / 2, height - 12, text="−Z", fill="#1e293b",
                               font=("Segoe UI Semibold", 10))
            position = self.axis_positions[2]
            if position is None or not math.isfinite(position):
                self.z_value_var.set("Z: —")
            else:
                fraction = min(1.0, max(0.0, (position - low) / (high - low)))
                y = bottom - fraction * (bottom - top)
                canvas.create_line(bar_left - 20, y, bar_right + 8, y, fill="#dc2626", width=2)
                canvas.create_polygon(bar_left - 21, y - 6, bar_left - 9, y, bar_left - 21, y + 6,
                                      fill="#dc2626", outline="#dc2626")
                canvas.create_text(bar_right + 12, y, text="%.4f" % position, anchor="w",
                                   fill="#b91c1c", font=("Segoe UI Semibold", 9))
                self.z_value_var.set("Z: %.4f" % position)

        if self.t_rotation_canvas is not None:
            canvas = self.t_rotation_canvas
            canvas.delete("all")
            width = canvas.winfo_width() if canvas.winfo_width() > 1 else int(canvas.cget("width"))
            height = canvas.winfo_height() if canvas.winfo_height() > 1 else int(canvas.cget("height"))
            radius = max(35, min(width, height) / 2 - 30)
            center_x, center_y = width / 2, height / 2
            canvas.create_oval(center_x - radius, center_y - radius,
                               center_x + radius, center_y + radius,
                               outline="#475569", width=2, fill="#f8fafc")
            for degrees, label in ((0, "0° / 360°"), (90, "90°"), (180, "180°"), (270, "270°")):
                angle = math.radians(90 - degrees)
                inner = radius - 7
                outer = radius + 1
                canvas.create_line(center_x + inner * math.cos(angle), center_y + inner * math.sin(angle),
                                   center_x + outer * math.cos(angle), center_y + outer * math.sin(angle),
                                   fill="#64748b", width=2)
                label_radius = radius + 15
                canvas.create_text(center_x + label_radius * math.cos(angle),
                                   center_y + label_radius * math.sin(angle), text=label,
                                   fill="#64748b", font=("Segoe UI", 8))
            position = self.axis_positions[3]
            if position is None or not math.isfinite(position):
                self.t_value_var.set("T: —")
            else:
                displayed_degrees = position * 2.0
                angle = math.radians(90.0 - (displayed_degrees % 360.0))
                pointer_x = center_x + radius * 0.78 * math.cos(angle)
                pointer_y = center_y + radius * 0.78 * math.sin(angle)
                canvas.create_line(center_x, center_y, pointer_x, pointer_y,
                                   fill="#dc2626", width=3, arrow="last")
                canvas.create_oval(center_x - 4, center_y - 4, center_x + 4, center_y + 4,
                                   fill="#dc2626", outline="#dc2626")
                self.t_value_var.set("T: %.4f°" % displayed_degrees)

    def _set_footer(self, value, error):
        self.footer_text.set(error if error else value)

    def refresh_ports(self):
        def done(value, error):
            if error:
                self.footer_text.set("Port scan failed: " + error)
                return
            ports = sorted(value.split(","), key=lambda p: (not p.startswith("COM"), int(p[3:]) if p.startswith("COM") and p[3:].isdigit() else 999)) if value else []
            self.port_box["values"] = ports or ["COM1", "COM2", "COM3", "COM4"]
            self.temp_port_box["values"] = ports or ["COM1", "COM2", "COM3", "COM4", "COM5"]
            if ports and self.port_var.get() not in ports:
                self.port_var.set(ports[0])
            self.footer_text.set("Found %d serial port(s)." % len(ports))
        self._call("PORTS", on_done=done)

    def connect_controller(self):
        port = self.port_var.get().strip().upper()
        if not port:
            messagebox.showwarning("Port required", "Select a serial port first.", parent=self)
            return
        if self.temperature_worker.wanted_port == port:
            messagebox.showwarning(
                "COM port in use",
                "The temperature controller is using %s. Choose a different COM port or disconnect temperature control first." % port,
                parent=self)
            return
        self.connect_button.configure(state="disabled")
        self.footer_text.set("Connecting to " + port + "…")
        def connected(value, error):
            if error:
                self.connect_button.configure(state="normal")
                if error == "MCC4DLL returned 2":
                    detail = ("MCC4DLL could not initialize the serial connection on %s.\n\n"
                              "Check that this is the controller's COM port, the controller is powered, "
                              "and the original MCCDEMO or another serial monitor is closed. "
                              "Then refresh the port list and try again." % port)
                else:
                    detail = error
                self.footer_text.set("Connection failed on %s: %s" % (port, error))
                messagebox.showerror("Connection failed", detail, parent=self)
                return
            self.connected = True
            self._set_link_visual(True)
            self.footer_text.set("Connected to " + port + ". Reading axis parameters…")
            self._begin_polling()
            self._call("GETPARAS", on_done=self._loaded_parameters)
        self._call("CONNECT", port, on_done=connected)

    def _begin_polling(self):
        if self.poll_stop:
            self.poll_stop.set()
        self.poll_stop = threading.Event()

    def disconnect_controller(self):
        self.program_cancel.set()
        self.program_gate.set()
        with self.manual_queue_lock:
            self.manual_queue_generation += 1
            self.manual_command_queue.clear()
            self.manual_queue_stop_pending = True
            queue_count = len(self.manual_command_queue)
        self.events.put(("motion_queue_count", queue_count))
        if self.debug_open:
            self._call("DEBUG", "0")
            self.debug_open = False
        if self.poll_stop:
            self.poll_stop.set()
        self.footer_text.set("Disconnecting…")
        def done(value, error):
            self.connected = False
            self.motion_active = False
            self.motion_pending = False
            self._set_link_visual(False)
            self._set_run_visual(False)
            with self.manual_queue_lock:
                self.manual_queue_stop_pending = False
            self._refresh_parameter_controls()
            self.limit_badge_text.set("LIMIT STATUS UNKNOWN")
            self._set_badge(self.limit_badge, "#94a3b8")
            self.footer_text.set(error if error else "Disconnected from controller.")
        self._call_motion_barrier("DISCONNECT", on_done=done)

    def _loaded_parameters(self, value, error):
        if error:
            self.footer_text.set("Connected. Parameter read failed: " + error)
            return
        self._store_params(value)
        dialog = getattr(self, "parameter_dialog", None)
        if dialog and dialog.winfo_exists():
            dialog._populate()
        self.footer_text.set("Connected. Axis parameters loaded.")

    def _store_params(self, payload):
        try:
            values = [float(v) for v in payload.split(";")]
            if len(values) != 40:
                raise ValueError("expected 40 values")
            self.params = values
        except ValueError as exc:
            self.footer_text.set("Parameter data could not be read: " + str(exc))
            return
        for axis in range(4):
            base = axis * 10
            scale = T_AXIS_DISPLAY_SCALE if axis == T_AXIS_INDEX else 1.0
            display_distance = values[base] * scale
            self.manual_distance_vars[axis].set(self._fmt_param(display_distance))
            self.speed_vars[axis].set(self._fmt_param(values[base+2]))
            self.accel_vars[axis].set(self._fmt_param(values[base+3]))
            self.neg_vars[axis].set(self._fmt_param(values[base+8] * scale))
            self.pos_vars[axis].set(self._fmt_param(values[base+9] * scale))
            signal = int(round(values[base+6]))
            self.soft_vars[axis].set(bool(signal & 32))
            self.hard_vars[axis].set(bool(signal & 64))
        self._draw_position_visuals()

    @staticmethod
    def _fmt_param(value):
        return ("%.6f" % value).rstrip("0").rstrip(".") if value % 1 else str(int(value))

    @staticmethod
    def _number(text, label):
        try:
            return float(text.strip())
        except (ValueError, AttributeError):
            raise ValueError(label + " must be a number.")

    def apply_axis_speed(self, axis):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect to the controller before applying speed settings.", parent=self)
            return
        if not self._require_idle_for_parameter_change():
            return
        try:
            speed = self._number(self.speed_vars[axis].get(), "Speed")
            accel = self._number(self.accel_vars[axis].get(), "Acceleration")
            if not math.isfinite(speed) or not math.isfinite(accel):
                raise ValueError("Speed and acceleration must be finite numbers.")
        except ValueError as exc:
            messagebox.showerror("Invalid speed settings", str(exc), parent=self)
            return

        def done(value, error):
            if error:
                self.footer_text.set("Axis %s speed settings failed: %s" % (AXES[axis], error))
                messagebox.showerror("Controller rejected setting", error, parent=self)
                return
            base = axis * 10
            self.params[base+2], self.params[base+3] = speed, accel
            self.footer_text.set("Axis %s speed and acceleration applied." % AXES[axis])
        self._call("SETSPEED", axis, speed, accel, on_done=done)

    def apply_axis_limits(self, axis):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect to the controller before applying limits.", parent=self)
            return
        if not self._require_idle_for_parameter_change():
            return
        try:
            negative = self._number(self.neg_vars[axis].get(), "Negative limit")
            positive = self._number(self.pos_vars[axis].get(), "Positive limit")
            if not math.isfinite(negative) or not math.isfinite(positive):
                raise ValueError("Limit values must be finite numbers.")
            if negative >= positive:
                raise ValueError("The negative limit must be less than the positive limit.")
        except ValueError as exc:
            messagebox.showerror("Invalid axis limits", str(exc), parent=self)
            return

        soft_enabled = bool(self.soft_vars[axis].get())
        hard_enabled = bool(self.hard_vars[axis].get())
        scale = T_AXIS_DISPLAY_SCALE if axis == T_AXIS_INDEX else 1.0
        controller_negative = negative / scale
        controller_positive = positive / scale
        def done(value, error):
            if error:
                self.footer_text.set("Axis %s limit settings failed: %s" % (AXES[axis], error))
                messagebox.showerror("Controller rejected setting", error, parent=self)
                return
            base = axis * 10
            self.params[base+8], self.params[base+9] = controller_negative, controller_positive
            self.params[base+6] = self._set_flag(self.params[base+6] or 0, 32, soft_enabled)
            self.params[base+6] = self._set_flag(self.params[base+6], 64, hard_enabled)
            self.footer_text.set("Axis %s limits applied." % AXES[axis])
        self._call("SETLIMITS", axis, controller_negative, controller_positive,
                   int(soft_enabled), int(hard_enabled), on_done=done)

    def apply_manual_distance(self, axis):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect before changing manual distance.", parent=self)
            return
        if not self._require_idle_for_parameter_change():
            return
        try:
            entered_distance = self._number(self.manual_distance_vars[axis].get(), "Manual distance")
            if not math.isfinite(entered_distance) or entered_distance <= 0:
                raise ValueError("Manual distance must be greater than zero.")
        except ValueError as exc:
            messagebox.showerror("Invalid manual distance", str(exc), parent=self)
            return
        distance = entered_distance / T_AXIS_DISPLAY_SCALE if axis == T_AXIS_INDEX else entered_distance

        self.footer_text.set("Setting %s manual distance…" % AXES[axis])
        def done(value, error):
            if error:
                self.footer_text.set("Could not set %s manual distance: %s" % (AXES[axis], error))
                messagebox.showerror("Controller rejected setting", error, parent=self)
                return
            self._call("GETPARAS", on_done=self._loaded_parameters)
        self._call("SETPARAM", axis, 0, distance, on_done=done)

    @staticmethod
    def _set_flag(value, mask, enabled):
        raw = int(round(float(value)))
        return float((raw | mask) if enabled else (raw & ~mask))

    def manual_step(self, axis, direction):
        # Each click is preserved and sent only after the prior move completes.
        direction_name = "positive" if direction > 0 else "negative"
        self._enqueue_manual_command("MANUAL_STEP", (axis, direction),
                                     "%s %s jog" % (AXES[axis], direction_name), True)

    def home_axis(self, axis):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect before homing an axis.", parent=self)
            return
        if not messagebox.askyesno("Home axis", "Start homing axis %s?" % AXES[axis], parent=self):
            return
        self._enqueue_manual_command("HOME", (axis,), "Home %s" % AXES[axis], True)

    def zero_axis(self, axis):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect before resetting an axis coordinate.", parent=self)
            return
        confirm = messagebox.askyesno(
            "Set Zero Location",
            "Set the current %s location as zero?\n\n"
            "This resets the coordinate only; the motor will not move. Position-based commands and soft limits use this coordinate, so their reference will change.\n\n"
            "Continue only if this new zero location is intended." % AXES[axis],
            icon="warning", parent=self)
        if confirm:
            self._enqueue_manual_command("RESETCOORD", (axis, 0.0),
                                         "Zero %s location" % AXES[axis], False)

    def return_axis_to_zero(self, axis):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect to the controller before homing an axis to its zero location.", parent=self)
            return
        try:
            speed = self._number(self.speed_vars[axis].get(), "Speed")
            acceleration = self._number(self.accel_vars[axis].get(), "Acceleration")
            if not math.isfinite(speed) or speed <= 0:
                raise ValueError("Speed must be greater than zero.")
            if not math.isfinite(acceleration) or acceleration <= 0:
                raise ValueError("Acceleration must be greater than zero.")
        except ValueError as exc:
            messagebox.showerror("Invalid axis settings", str(exc), parent=self)
            return
        self._enqueue_manual_command("RETURN_ZERO", (axis, speed, acceleration),
                                     "Home %s to zero" % AXES[axis], True)

    def start_program(self):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect to the controller before starting a program.", parent=self)
            return
        if self.program_active:
            messagebox.showinfo("Program running", "A program is already active.", parent=self)
            return
        if self._manual_queue_pending():
            messagebox.showinfo("Manual queue active", "Wait for queued manual actions to finish before starting a program.", parent=self)
            return
        lines = [line.strip() for line in self.program_text.get("1.0", "end-1c").splitlines()
                 if line.strip() and not line.strip().startswith(";")
                 and not (line.strip().startswith("(") and line.strip().endswith(")"))]
        if not lines:
            messagebox.showinfo("Empty program", "Add one controller command per line first.", parent=self)
            return
        try:
            cycles = int(self.cycle_var.get())
            if cycles < 1 or cycles > 100000:
                raise ValueError()
        except ValueError:
            messagebox.showerror("Invalid cycle count", "Cycles must be an integer from 1 to 100000.", parent=self)
            return
        if not messagebox.askyesno("Start program", "Send %d command(s) for %d cycle(s) to the controller?" % (len(lines), cycles), parent=self):
            return
        self.program_active = True
        self._refresh_parameter_controls()
        self.program_cancel.clear()
        self.program_gate.set()
        self.footer_text.set("Program starting…")
        self.program_thread = threading.Thread(target=self._program_worker, args=(lines, cycles), daemon=True)
        self.program_thread.start()

    def _program_worker(self, lines, cycles):
        try:
            total = len(lines) * cycles
            sent = 0
            for cycle in range(cycles):
                for index, line in enumerate(lines):
                    if self.program_cancel.is_set():
                        self.events.put(("program", "Program stopped by user.", True))
                        return
                    self.program_gate.wait()
                    if self.program_cancel.is_set():
                        self.events.put(("program", "Program stopped by user.", True))
                        return
                    with self.manual_dispatch_lock:
                        if self.program_cancel.is_set():
                            self.events.put(("program", "Program stopped by user.", True))
                            return
                        self.client.request("MDI", base64.b64encode(line.encode("utf-8")).decode("ascii"))
                    sent += 1
                    self.events.put(("program", "Cycle %d/%d · command %d/%d: %s" % (cycle+1, cycles, index+1, len(lines), line), None))
                    sent_at = time.monotonic()
                    saw_motion = False
                    while True:
                        if self.program_cancel.is_set():
                            self.events.put(("program", "Program stopped by user.", True))
                            return
                        if not self.program_gate.is_set():
                            self.program_gate.wait()
                            continue
                        state = self.client.request("STATE").split("|")
                        moving = len(state) > 1 and state[1] == "1"
                        if moving:
                            saw_motion = True
                        elif saw_motion or time.monotonic() - sent_at >= 0.35:
                            break
                        if time.monotonic() - sent_at > 900:
                            raise BridgeError("Timed out waiting for controller motion to finish.")
                        self.program_cancel.wait(0.08)
            self.events.put(("program", "Program complete: %d command(s) sent." % total, True))
        except Exception as exc:
            self.events.put(("program", "Program stopped: " + str(exc), True))

    def pause_program(self):
        if self.program_active:
            self.program_gate.clear()
        if self.connected:
            self._call("PAUSE", on_done=self._set_footer)
        else:
            self.footer_text.set("Connect to pause controller motion.")

    def resume_program(self):
        if self.connected:
            self._call("RESUME", on_done=lambda value, error: self._resume_done(value, error))
        else:
            self.footer_text.set("Connect to resume controller motion.")

    def _resume_done(self, value, error):
        if not error:
            self.program_gate.set()
        self._set_footer(value, error)

    def stop_program(self):
        self.program_cancel.set()
        self.program_gate.set()
        if self.connected:
            self.stop_motion_and_clear_queue()
        else:
            self.footer_text.set("Program canceled.")

    def stop_motion_and_clear_queue(self, emergency=False):
        self.program_cancel.set()
        self.program_gate.set()
        with self.manual_queue_lock:
            self.manual_queue_generation += 1
            self.manual_command_queue.clear()
            connected = self.connected
            self.manual_queue_stop_pending = connected
        self.motion_pending = False
        self.events.put(("motion_queue_count", 0))
        self._refresh_parameter_controls()
        if not connected:
            self.footer_text.set("Queued actions cleared. The controller is disconnected, so no stop command was sent.")
            return
        command = "EMERGENCY" if emergency else "STOP"
        self.footer_text.set("Sending %s stop; clearing queued actions…" % ("emergency" if emergency else "controlled"))
        self._call_motion_barrier(command, on_done=lambda value, error: self._motion_stop_done(value, error, emergency))

    def _motion_stop_done(self, value, error, emergency):
        with self.manual_queue_lock:
            self.manual_queue_stop_pending = False
        if error:
            self.footer_text.set("Stop command failed: " + error)
            messagebox.showerror("Stop command failed", error, parent=self)
        else:
            kind = "Emergency stop" if emergency else "Motion stopped"
            self.footer_text.set("%s. Queue cleared; controller remains connected." % kind)
        self._refresh_parameter_controls()
        self._start_manual_queue_worker()

    def emergency_stop(self):
        if not self.connected:
            messagebox.showinfo("Not connected", "No controller is linked.", parent=self)
            return
        if messagebox.askyesno("Emergency stop", "Immediately stop all four axes without deceleration?", parent=self):
            self.stop_motion_and_clear_queue(emergency=True)

    def _selected_line(self):
        index = self.program_text.index("insert").split(".")[0]
        return int(index)

    def insert_line(self):
        text = simpledialog.askstring("Insert line", "Controller command:", parent=self)
        if text:
            self.program_text.insert("%d.0" % self._selected_line(), text.rstrip()+"\n")

    def append_line(self):
        text = simpledialog.askstring("Append line", "Controller command:", parent=self)
        if text:
            self.program_text.insert("end-1c", "\n"+text.rstrip()+"\n")

    def modify_line(self):
        line = self._selected_line()
        current = self.program_text.get("%d.0" % line, "%d.end" % line)
        replacement = simpledialog.askstring("Modify line", "Controller command:", initialvalue=current, parent=self)
        if replacement is not None:
            self.program_text.delete("%d.0" % line, "%d.end" % line)
            self.program_text.insert("%d.0" % line, replacement)

    def delete_line(self):
        line = self._selected_line()
        self.program_text.delete("%d.0" % line, "%d+1line.0" % line)

    def file_new(self):
        if self.program_text.get("1.0", "end-1c").strip() and not messagebox.askyesno("New program", "Discard the current program?", parent=self):
            return
        self.program_text.delete("1.0", "end")
        self.current_file = None
        self.title("MCC4 Motion and Temperature Control GUI")

    def file_open(self):
        path = filedialog.askopenfilename(parent=self, title="Open program", filetypes=[("G-code / text", "*.gcode *.nc *.txt"), ("All files", "*.*")])
        if not path: return
        try:
            text = Path(path).read_text(encoding="utf-8-sig")
        except (OSError, UnicodeError) as exc:
            messagebox.showerror("Open failed", str(exc), parent=self); return
        self.program_text.delete("1.0", "end")
        self.program_text.insert("1.0", text)
        self.current_file = Path(path)
        self.title("%s — MCC4 Motion and Temperature Control GUI" % self.current_file.name)
        self.footer_text.set("Opened " + str(self.current_file))

    def file_save(self):
        if self.current_file is None:
            return self.file_save_as()
        self._save_to(self.current_file)

    def file_save_as(self):
        path = filedialog.asksaveasfilename(parent=self, title="Save program", defaultextension=".gcode", filetypes=[("G-code", "*.gcode"), ("NC program", "*.nc"), ("Text", "*.txt"), ("All files", "*.*")])
        if path:
            self.current_file = Path(path)
            self._save_to(self.current_file)

    def _save_to(self, path):
        try:
            Path(path).write_text(self.program_text.get("1.0", "end-1c"), encoding="utf-8")
            self.footer_text.set("Saved " + str(path))
        except OSError as exc:
            messagebox.showerror("Save failed", str(exc), parent=self)

    def file_close(self):
        self.program_text.delete("1.0", "end")
        self.current_file = None
        self.title("MCC4 Motion and Temperature Control GUI")

    def download_parameters(self):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect to download controller parameters.", parent=self); return
        if not self._require_idle_for_parameter_change():
            return
        self.footer_text.set("Reading parameters from controller…")
        self._call("GETPARAS", on_done=self._loaded_parameters)

    def upload_parameters(self, from_dialog=False):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect before uploading parameters.", parent=self); return
        if not self._require_idle_for_parameter_change():
            return
        if from_dialog:
            dialog = getattr(self, "parameter_dialog", None)
            if not dialog or not dialog.winfo_exists():
                return
            try:
                dialog._read_entries()
            except ValueError as exc:
                messagebox.showerror("Invalid parameter", str(exc), parent=dialog)
                return
        else:
            try:
                for axis in range(4):
                    base = axis * 10
                    for index, var in ((2, self.speed_vars[axis]), (3, self.accel_vars[axis]),
                                       (8, self.neg_vars[axis]), (9, self.pos_vars[axis])):
                        text = var.get().strip()
                        if text:
                            value = self._number(text, PARAMETERS[index])
                            if axis == T_AXIS_INDEX and index in (8, 9):
                                value /= T_AXIS_DISPLAY_SCALE
                            self.params[base+index] = value
                    signal = self.params[base+6] or 0
                    signal = self._set_flag(signal, 32, self.soft_vars[axis].get())
                    signal = self._set_flag(signal, 64, self.hard_vars[axis].get())
                    self.params[base+6] = signal
            except ValueError as exc:
                messagebox.showerror("Invalid axis setting", str(exc), parent=self)
                return
        if any(v is None for v in self.params):
            self.footer_text.set("Download controller parameters first, or enter all fields in Parameter Set.")
            self.open_parameters()
            return
        if not messagebox.askyesno("Upload parameters", "Write all 40 parameter values to the controller?", parent=self): return
        commands = [("SETPARAM", (axis, idx, self.params[axis*10+idx])) for axis in range(4) for idx in range(10)]
        self.footer_text.set("Uploading 40 controller parameters…")
        def uploaded(value, error):
            if error:
                self._set_footer(value, error)
                return
            self.footer_text.set("Upload complete. Verifying controller parameters…")
            self._call("GETPARAS", on_done=self._loaded_parameters)
        self._sequence(commands, on_done=uploaded)

    def save_rom(self):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect before saving controller parameters.", parent=self); return
        if not self._require_idle_for_parameter_change():
            return
        if messagebox.askyesno("Save to controller", "Save current controller parameters to non-volatile memory?", parent=self):
            self._call("SAVE_ROM", on_done=self._set_footer)

    def open_parameters(self):
        dialog = getattr(self, "parameter_dialog", None)
        if dialog and dialog.winfo_exists():
            dialog.lift(); return
        self.parameter_dialog = ParameterDialog(self)
        self._refresh_parameter_controls()

    def port_assistant(self):
        win = tk.Toplevel(self); win.title("COM Port Assistant"); win.resizable(False, False); win.transient(self)
        frame = ttk.Frame(win, padding=14); frame.pack(fill="both", expand=True)
        ttk.Label(frame, text="Available Windows serial ports", style="Section.TLabel").pack(anchor="w")
        listing = tk.Listbox(frame, height=8, width=30, font=("Consolas", 10)); listing.pack(fill="both", expand=True, pady=8)
        def refresh():
            listing.delete(0, "end")
            def done(value, error):
                if error: listing.insert("end", error); return
                ports = value.split(",") if value else []
                for port in ports: listing.insert("end", port)
                if not ports: listing.insert("end", "No serial ports found")
            self._call("PORTS", on_done=done)
        def choose(_event=None):
            selected = listing.curselection()
            if selected and listing.get(selected[0]).startswith("COM"):
                self.port_var.set(listing.get(selected[0])); win.destroy()
        listing.bind("<Double-Button-1>", choose)
        row = ttk.Frame(frame); row.pack(fill="x")
        ttk.Button(row, text="Refresh", command=refresh).pack(side="left")
        ttk.Button(row, text="Use Selected", command=choose).pack(side="right")
        refresh()

    def toggle_debug(self):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect before opening serial diagnostics.", parent=self); return
        target = not self.debug_open
        def done(value, error):
            if not error:
                self.debug_open = target
                self.footer_text.set(value)
            else: self.footer_text.set("Serial debug window: " + error)
        self._call("DEBUG", int(target), on_done=done)

    def joystick_dialog(self):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect before changing joystick settings.", parent=self); return
        win = tk.Toplevel(self); win.title("Joystick Settings"); win.transient(self)
        frame = ttk.Frame(win, padding=14); frame.pack(fill="both", expand=True)
        ttk.Label(frame, text="Enable analog joystick control per axis", style="Section.TLabel").grid(row=0, column=0, columnspan=2, sticky="w", pady=(0, 8))
        vars_ = []
        for i, axis in enumerate(AXES):
            var = tk.BooleanVar(value=False); vars_.append(var)
            ttk.Checkbutton(frame, text=axis+" axis", variable=var).grid(row=i+1, column=0, sticky="w", padx=6, pady=3)
        def apply():
            commands = [("JOYSTICK", (i, int(var.get()))) for i, var in enumerate(vars_)]
            self._sequence(commands, on_done=self._set_footer); win.destroy()
        ttk.Button(frame, text="Apply", style="Accent.TButton", command=apply).grid(row=5, column=0, sticky="w", pady=(9, 0))
        ttk.Button(frame, text="Close", command=win.destroy).grid(row=5, column=1, sticky="e", pady=(9, 0))

    def test_move_dialog(self):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect before sending a communication test move.", parent=self); return
        win = tk.Toplevel(self); win.title("Test Communication / Move"); win.transient(self)
        frame = ttk.Frame(win, padding=14); frame.pack(fill="both", expand=True)
        ttk.Label(frame, text="Send an absolute move to one axis", style="Section.TLabel").grid(row=0, column=0, columnspan=2, sticky="w", pady=(0, 8))
        axis = tk.StringVar(value="X"); target = tk.StringVar(value="0"); velocity = tk.StringVar(value="100"); accel = tk.StringVar(value="100")
        for r, (label, var) in enumerate((("Axis", axis), ("Target position", target), ("Speed", velocity), ("Acceleration", accel)), start=1):
            ttk.Label(frame, text=label).grid(row=r, column=0, sticky="w", padx=(0, 10), pady=4)
            if r == 1: ttk.Combobox(frame, textvariable=var, values=AXES, state="readonly", width=15).grid(row=r, column=1, sticky="ew", pady=4)
            else: ttk.Entry(frame, textvariable=var, width=18).grid(row=r, column=1, sticky="ew", pady=4)
        def send():
            try: args = (AXES.index(axis.get()), self._number(target.get(), "Target"), self._number(velocity.get(), "Speed"), self._number(accel.get(), "Acceleration"))
            except ValueError as exc: messagebox.showerror("Invalid move", str(exc), parent=win); return
            if messagebox.askyesno("Confirm test move", "Move %s to %s?" % (axis.get(), target.get()), parent=win):
                self._enqueue_manual_command("ABS", args,
                                             "Absolute move on %s" % axis.get(), True)
        ttk.Button(frame, text="Send Move", style="Accent.TButton", command=send).grid(row=5, column=0, pady=(10, 0), sticky="w")
        ttk.Button(frame, text="Close", command=win.destroy).grid(row=5, column=1, pady=(10, 0), sticky="e")

    def extended_control(self):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect before changing digital outputs.", parent=self); return
        win = tk.Toplevel(self); win.title("Extended Control — Digital Outputs"); win.geometry("520x380"); win.transient(self)
        frame = ttk.Frame(win, padding=12); frame.pack(fill="both", expand=True)
        ttk.Label(frame, text="Set controller output pins 0–31", style="Section.TLabel").pack(anchor="w", pady=(0, 8))
        grid = ttk.Frame(frame); grid.pack(fill="both", expand=True)
        vars_ = []
        for i in range(32):
            var = tk.BooleanVar(value=False); vars_.append(var)
            ttk.Checkbutton(grid, text="OUT %02d" % i, variable=var, command=lambda idx=i, v=var: self._call("OUTPUT", idx, int(v.get()), on_done=self._set_footer)).grid(row=i//4, column=i%4, sticky="w", padx=5, pady=3)
        ttk.Button(frame, text="Close", command=win.destroy).pack(anchor="e", pady=(8, 0))

    def about(self):
        messagebox.showinfo(
            "MCC4 Motion and Temperature Control GUI",
            "MCC4 Motion and Temperature Control GUI\n\n"
            "Python/Tkinter interface for the MCC4 motion controller and the Onway temperature controller.\n"
            "The original MCCDEMO application is not modified by this interface.",
            parent=self)

    def close_app(self):
        if self.program_active and not messagebox.askyesno("Program active", "Stop the active program and close?", parent=self):
            return
        self.program_cancel.set(); self.program_gate.set()
        with self.manual_queue_lock:
            self.manual_queue_generation += 1
            self.manual_command_queue.clear()
            self.manual_queue_stop_pending = False
        if self.poll_stop: self.poll_stop.set()
        self.temperature_worker.stop()
        self.temperature_worker.join(timeout=2.5)
        try:
            if self.connected:
                with self.manual_dispatch_lock:
                    self.client.request("STOP")
                    if self.debug_open: self.client.request("DEBUG", "0")
                    self.client.request("DISCONNECT")
            self.client.close()
        except Exception:
            pass
        self.destroy()


class ParameterDialog(tk.Toplevel):
    def __init__(self, app):
        super().__init__(app)
        self.app = app
        self.title("Controller Parameters")
        self.geometry("940x510")
        self.minsize(820, 450)
        self.transient(app)
        self.value_widgets = []
        self.action_widgets = []
        self.vars = [[tk.StringVar(value=self._display_parameter(app.params[a*10+p], a, p))
                      for a in range(4)] for p in range(10)]
        outer = ttk.Frame(self, padding=14); outer.pack(fill="both", expand=True)
        ttk.Label(outer, text="Controller parameters by axis", style="Section.TLabel").pack(anchor="w")
        ttk.Label(outer, text="Parameter indexes follow the vendor DLL. T manual distance and soft limits are displayed doubled (180 here writes 90); edits are sent only when you choose Upload.", style="Hint.TLabel", wraplength=900).pack(anchor="w", pady=(2, 10))
        table = ttk.Frame(outer); table.pack(fill="both", expand=True)
        ttk.Label(table, text="Parameter", width=28, style="Hint.TLabel").grid(row=0, column=0, sticky="w", padx=4, pady=4)
        for a, axis in enumerate(AXES):
            ttk.Label(table, text=axis, width=18, style="Hint.TLabel", anchor="center").grid(row=0, column=a+1, padx=4, pady=4)
        for p, name in enumerate(PARAMETERS):
            ttk.Label(table, text="%d · %s" % (p, name), width=28, style="Card.TLabel").grid(row=p+1, column=0, sticky="w", padx=4, pady=3)
            for a in range(4):
                entry = ttk.Entry(table, textvariable=self.vars[p][a], width=18, justify="right")
                entry.grid(row=p+1, column=a+1, padx=4, pady=3, sticky="ew")
                self.value_widgets.append(entry)
        for col in range(1, 5): table.columnconfigure(col, weight=1)
        ttk.Label(outer, text="Changes to the controller are not permanent until you select Save Parameters To Controller.", style="Hint.TLabel").pack(anchor="w", pady=(9, 4))
        buttons = ttk.Frame(outer); buttons.pack(fill="x", pady=(5, 0))
        download_button = ttk.Button(buttons, text="Download From Controller", command=app.download_parameters)
        download_button.pack(side="left")
        upload_button = ttk.Button(buttons, text="Upload To Controller", style="Accent.TButton",
                                   command=lambda: app.upload_parameters(from_dialog=True))
        upload_button.pack(side="left", padx=6)
        save_button = ttk.Button(buttons, text="Save To ROM", command=app.save_rom)
        save_button.pack(side="left")
        self.action_widgets.extend((download_button, upload_button, save_button))
        ttk.Button(buttons, text="Close", command=self.destroy).pack(side="right")
        self.bind("<Destroy>", self._on_destroy, add=True)
        self.set_parameter_controls_enabled(not app._parameters_locked())

    def set_parameter_controls_enabled(self, enabled):
        state = "normal" if enabled else "disabled"
        for widget in self.value_widgets + self.action_widgets:
            widget.configure(state=state)

    def _populate(self):
        for p in range(10):
            for a in range(4):
                value = self.app.params[a*10+p]
                self.vars[p][a].set(self._display_parameter(value, a, p))

    def _display_parameter(self, value, axis, parameter):
        if value is None:
            return ""
        if axis == T_AXIS_INDEX and parameter in (0, 8, 9):
            value *= T_AXIS_DISPLAY_SCALE
        return self.app._fmt_param(value)

    def _read_entries(self):
        values = [None] * 40
        for p in range(10):
            for a in range(4):
                raw = self.vars[p][a].get().strip()
                if not raw:
                    continue
                try:
                    value = float(raw)
                    if a == T_AXIS_INDEX and p in (0, 8, 9):
                        value /= T_AXIS_DISPLAY_SCALE
                    values[a*10+p] = value
                except ValueError:
                    raise ValueError("Parameter %d for axis %s must be numeric." % (p, AXES[a]))
        self.app.params = values

    def _on_destroy(self, _event):
        if _event.widget is self:
            self.app.parameter_dialog = None


def main():
    app = MotionApp()
    app.mainloop()


if __name__ == "__main__":
    main()
