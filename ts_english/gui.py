"""English Tkinter front end for the MCC4 four-axis motion controller demo."""
from __future__ import annotations

import base64
import queue
import subprocess
import threading
import time
import tkinter as tk
from pathlib import Path
from tkinter import filedialog, messagebox, simpledialog, ttk


APP_DIR = Path(__file__).resolve().parent
BRIDGE_EXE = APP_DIR / "ControllerBridge.exe"
AXES = ("X", "Y", "Z", "T")
PARAMETERS = (
    "Manual distance", "Low-speed range", "Manual speed", "Acceleration",
    "Pulse equivalent", "Home speed", "Signal level", "Home switch distance",
    "Soft negative limit", "Soft positive limit",
)
LIMIT_BITS = {"X-": 9, "X+": 10, "Y-": 6, "Y+": 7,
              "Z-": 3, "Z+": 4, "T-": 0, "T+": 1}


class BridgeError(RuntimeError):
    pass


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


class MotionApp(tk.Tk):
    def __init__(self):
        super().__init__()
        self.title("MCC4 Motion Control — English")
        self.geometry("1280x850")
        self.minsize(1060, 720)
        self.configure(bg="#edf1f5")
        self.client = ControllerClient()
        self.events = queue.Queue()
        self.poll_stop = None
        self.connected = False
        self.poll_busy = False
        self.params = [None] * 40
        self.speed_vars = []
        self.accel_vars = []
        self.neg_vars = []
        self.pos_vars = []
        self.soft_vars = [tk.BooleanVar(value=False) for _ in AXES]
        self.hard_vars = [tk.BooleanVar(value=False) for _ in AXES]
        self.pos_labels = {}
        self.speed_labels = {}
        self.limit_text = tk.StringVar(value="No limit signal reported")
        self.link_text = tk.StringVar(value="NOT LINKED")
        self.run_text = tk.StringVar(value="STOPPED")
        self.limit_badge_text = tk.StringVar(value="LIMITS CLEAR")
        self.footer_text = tk.StringVar(value="Ready. Connect to a controller to read its live status.")
        self.port_var = tk.StringVar(value="COM1")
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
        parameter_menu.add_command(label="Parameter Set…", command=self.open_parameters)
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
        help_menu.add_command(label="About MCC4 English UI", command=self.about)
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
        ttk.Label(top, text="MCC4 Motion Control", style="Title.TLabel").pack(side="left")
        ttk.Label(top, text="Four-axis controller", foreground="#607286").pack(side="left", padx=(12, 0), pady=(8, 0))

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

        content = ttk.Panedwindow(outer, orient="horizontal")
        content.pack(fill="both", expand=True)
        left = ttk.Frame(content, style="Card.TFrame", padding=10)
        right = ttk.Frame(content, style="Card.TFrame", padding=10)
        content.add(left, weight=3)
        content.add(right, weight=2)

        left_head = ttk.Frame(left, style="Card.TFrame")
        left_head.pack(fill="x", pady=(0, 7))
        ttk.Label(left_head, text="Program editor", style="Section.TLabel").pack(side="left")
        ttk.Label(left_head, text="One controller command per line", style="Hint.TLabel").pack(side="right")
        text_frame = ttk.Frame(left, style="Card.TFrame")
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

        run_row = ttk.Frame(left, style="Card.TFrame")
        run_row.pack(fill="x", pady=(9, 2))
        ttk.Label(run_row, text="Cycles", style="Card.TLabel").pack(side="left")
        ttk.Entry(run_row, textvariable=self.cycle_var, width=5).pack(side="left", padx=(6, 12))
        ttk.Button(run_row, text="Start Program", style="Accent.TButton", command=self.start_program).pack(side="left", padx=(0, 6))
        ttk.Button(run_row, text="Pause", command=self.pause_program).pack(side="left", padx=3)
        ttk.Button(run_row, text="Resume", command=self.resume_program).pack(side="left", padx=3)
        ttk.Button(run_row, text="Stop", command=self.stop_program).pack(side="left", padx=3)
        ttk.Button(run_row, text="Emergency Stop", command=self.emergency_stop).pack(side="right")

        right_title = ttk.Frame(right, style="Card.TFrame")
        right_title.pack(fill="x", pady=(0, 7))
        ttk.Label(right_title, text="Axis speed & limits", style="Section.TLabel").pack(side="left")
        ttk.Button(right_title, text="Load From Controller", command=self.download_parameters).pack(side="right")
        ttk.Label(right, text="Speed and acceleration apply per axis. Limits are coordinates in controller units.",
                  style="Hint.TLabel", wraplength=410).pack(fill="x", anchor="w", pady=(0, 7))

        table = ttk.Frame(right, style="Card.TFrame")
        table.pack(fill="x")
        headers = ["Axis", "Speed", "Accel", "Soft −", "Soft +", "Soft", "Hard", ""]
        widths = [4, 8, 8, 8, 8, 5, 5, 7]
        for col, (label, width) in enumerate(zip(headers, widths)):
            ttk.Label(table, text=label, width=width, style="Hint.TLabel", anchor="center").grid(row=0, column=col, padx=1, pady=3)
        for i, axis in enumerate(AXES):
            ttk.Label(table, text=axis, width=4, style="Card.TLabel", font=("Segoe UI Semibold", 10)).grid(row=i+1, column=0, padx=2, pady=4)
            vars_row = [tk.StringVar(value="") for _ in range(4)]
            self.speed_vars.append(vars_row[0]); self.accel_vars.append(vars_row[1])
            self.neg_vars.append(vars_row[2]); self.pos_vars.append(vars_row[3])
            for col, var in enumerate(vars_row, start=1):
                ttk.Entry(table, textvariable=var, width=widths[col], justify="right").grid(row=i+1, column=col, padx=2, pady=3)
            ttk.Checkbutton(table, variable=self.soft_vars[i]).grid(row=i+1, column=5, padx=3)
            ttk.Checkbutton(table, variable=self.hard_vars[i]).grid(row=i+1, column=6, padx=3)
            apply_button = ttk.Button(table, text="Apply", command=lambda idx=i: self.apply_axis(idx))
            apply_button.grid(row=i+1, column=7, padx=2)
        ttk.Label(right, text="Soft/Hard match the controller demo's limit setting. Limit inputs are monitored below.",
                  style="Hint.TLabel", wraplength=410).pack(fill="x", anchor="w", pady=(6, 9))

        axis_group = ttk.LabelFrame(right, text="Live axes & manual moves", padding=8)
        axis_group.pack(fill="x", pady=(0, 8))
        axis_group.columnconfigure(1, weight=1)
        ttk.Label(axis_group, text="Axis", style="Hint.TLabel").grid(row=0, column=0, sticky="w")
        ttk.Label(axis_group, text="Position", style="Hint.TLabel").grid(row=0, column=1, sticky="w", padx=4)
        ttk.Label(axis_group, text="Current speed", style="Hint.TLabel").grid(row=0, column=2, sticky="w", padx=4)
        ttk.Label(axis_group, text="One manual step", style="Hint.TLabel").grid(row=0, column=3, columnspan=3)
        ttk.Label(axis_group, text="Coordinate", style="Hint.TLabel").grid(row=0, column=6, sticky="w", padx=4)
        for i, axis in enumerate(AXES):
            row = i + 1
            ttk.Label(axis_group, text=axis, style="Card.TLabel", font=("Segoe UI Semibold", 10)).grid(row=row, column=0, sticky="w", pady=3)
            self.pos_labels[axis] = ttk.Label(axis_group, text="—", width=12, style="Card.TLabel")
            self.pos_labels[axis].grid(row=row, column=1, sticky="w", padx=4)
            self.speed_labels[axis] = ttk.Label(axis_group, text="—", width=10, style="Card.TLabel")
            self.speed_labels[axis].grid(row=row, column=2, sticky="w", padx=4)
            ttk.Button(axis_group, text=axis+"+", width=4, command=lambda idx=i: self.manual_step(idx, 1)).grid(row=row, column=3, padx=2, pady=2)
            ttk.Button(axis_group, text=axis+"−", width=4, command=lambda idx=i: self.manual_step(idx, -1)).grid(row=row, column=4, padx=2, pady=2)
            ttk.Button(axis_group, text="Home", width=6, command=lambda idx=i: self.home_axis(idx)).grid(row=row, column=5, padx=2, pady=2)
            ttk.Button(axis_group, text="Zero", width=7, command=lambda idx=i: self.zero_axis(idx)).grid(row=row, column=6, padx=3, pady=2)

        self.limit_detail = ttk.Label(right, textvariable=self.limit_text, style="Hint.TLabel", wraplength=415)
        self.limit_detail.pack(fill="x", anchor="w")
        self._set_link_visual(False)
        self._set_run_visual(False)

        footer = ttk.Frame(outer)
        footer.pack(fill="x", pady=(8, 0))
        ttk.Separator(footer).pack(fill="x", pady=(0, 6))
        ttk.Label(footer, textvariable=self.footer_text).pack(side="left", fill="x", expand=True)
        ttk.Label(footer, text="MCC4DLL x86 bridge", foreground="#64748b").pack(side="right")

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

    def _call(self, command, *args, on_done=None):
        def run():
            try:
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
                elif item[0] == "poll_end":
                    self.poll_busy = False
        except queue.Empty:
            pass
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
        try:
            positions = [float(v) for v in parts[2].split(",")]
            speeds = [float(v) for v in parts[3].split(",")]
            for i, axis in enumerate(AXES):
                if i < len(positions): self.pos_labels[axis].configure(text="%.4f" % positions[i])
                if i < len(speeds): self.speed_labels[axis].configure(text="%.3f" % speeds[i])
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

    def _set_footer(self, value, error):
        self.footer_text.set(error if error else value)

    def refresh_ports(self):
        def done(value, error):
            if error:
                self.footer_text.set("Port scan failed: " + error)
                return
            ports = sorted(value.split(","), key=lambda p: (not p.startswith("COM"), int(p[3:]) if p.startswith("COM") and p[3:].isdigit() else 999)) if value else []
            self.port_box["values"] = ports or ["COM1", "COM2", "COM3", "COM4"]
            if ports and self.port_var.get() not in ports:
                self.port_var.set(ports[0])
            self.footer_text.set("Found %d serial port(s)." % len(ports))
        self._call("PORTS", on_done=done)

    def connect_controller(self):
        port = self.port_var.get().strip().upper()
        if not port:
            messagebox.showwarning("Port required", "Select a serial port first.", parent=self)
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
        if self.debug_open:
            self._call("DEBUG", "0")
            self.debug_open = False
        if self.poll_stop:
            self.poll_stop.set()
        self.footer_text.set("Disconnecting…")
        def done(value, error):
            self.connected = False
            self._set_link_visual(False)
            self._set_run_visual(False)
            self.limit_badge_text.set("LIMIT STATUS UNKNOWN")
            self._set_badge(self.limit_badge, "#94a3b8")
            self.footer_text.set(error if error else "Disconnected from controller.")
        self._call("DISCONNECT", on_done=done)

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
            self.speed_vars[axis].set(self._fmt_param(values[base+2]))
            self.accel_vars[axis].set(self._fmt_param(values[base+3]))
            self.neg_vars[axis].set(self._fmt_param(values[base+8]))
            self.pos_vars[axis].set(self._fmt_param(values[base+9]))
            signal = int(round(values[base+6]))
            self.soft_vars[axis].set(bool(signal & 32))
            self.hard_vars[axis].set(bool(signal & 64))

    @staticmethod
    def _fmt_param(value):
        return ("%.6f" % value).rstrip("0").rstrip(".") if value % 1 else str(int(value))

    @staticmethod
    def _number(text, label):
        try:
            return float(text.strip())
        except (ValueError, AttributeError):
            raise ValueError(label + " must be a number.")

    def apply_axis(self, axis):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect to the controller before applying axis settings.", parent=self)
            return
        try:
            speed = self._number(self.speed_vars[axis].get(), "Speed")
            accel = self._number(self.accel_vars[axis].get(), "Acceleration")
            negative = self._number(self.neg_vars[axis].get(), "Negative limit")
            positive = self._number(self.pos_vars[axis].get(), "Positive limit")
            if negative >= positive:
                raise ValueError("The negative limit must be less than the positive limit.")
        except ValueError as exc:
            messagebox.showerror("Invalid axis settings", str(exc), parent=self)
            return
        commands = [("SETSPEED", (axis, speed, accel)),
                    ("SETLIMITS", (axis, negative, positive, int(self.soft_vars[axis].get()), int(self.hard_vars[axis].get())))]
        def done(value, error):
            if error:
                self.footer_text.set("Axis %s settings failed: %s" % (AXES[axis], error))
                messagebox.showerror("Controller rejected setting", error, parent=self)
                return
            base = axis * 10
            self.params[base+2], self.params[base+3] = speed, accel
            self.params[base+8], self.params[base+9] = negative, positive
            self.params[base+6] = self._set_flag(self.params[base+6] or 0, 32, self.soft_vars[axis].get())
            self.params[base+6] = self._set_flag(self.params[base+6], 64, self.hard_vars[axis].get())
            self.footer_text.set("Axis %s speed and limit settings applied." % AXES[axis])
        self._sequence(commands, on_done=done)

    @staticmethod
    def _set_flag(value, mask, enabled):
        raw = int(round(float(value)))
        return float((raw | mask) if enabled else (raw & ~mask))

    def manual_step(self, axis, direction):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect before moving an axis.", parent=self)
            return
        # Read parameter 0 inside the bridge and issue a bounded relative move,
        # so each click travels exactly one controller-configured manual distance.
        self._call("MANUAL_STEP", axis, direction, on_done=self._set_footer)

    def home_axis(self, axis):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect before homing an axis.", parent=self)
            return
        if not messagebox.askyesno("Home axis", "Start homing axis %s?" % AXES[axis], parent=self):
            return
        self._call("HOME", axis, on_done=self._set_footer)

    def zero_axis(self, axis):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect before resetting an axis coordinate.", parent=self)
            return
        confirm = messagebox.askyesno(
            "Warning — Zero Axis Coordinate",
            "Set the controller's current %s position reading to zero?\n\n"
            "This resets the coordinate only; the motor will not move. Position-based commands and soft limits use this coordinate, so their reference will change.\n\n"
            "Continue only if the machine is stationary and this is intended." % AXES[axis],
            icon="warning", parent=self)
        if confirm:
            self._call("RESETCOORD", axis, 0.0, on_done=self._set_footer)

    def start_program(self):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect to the controller before starting a program.", parent=self)
            return
        if self.program_active:
            messagebox.showinfo("Program running", "A program is already active.", parent=self)
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
            self._call("STOP", on_done=self._set_footer)
        else:
            self.footer_text.set("Program canceled.")

    def emergency_stop(self):
        if not self.connected:
            messagebox.showinfo("Not connected", "No controller is linked.", parent=self)
            return
        if messagebox.askyesno("Emergency stop", "Immediately stop all four axes without deceleration?", parent=self):
            self.program_cancel.set()
            self.program_gate.set()
            self._call("EMERGENCY", on_done=self._set_footer)

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
        self.title("MCC4 Motion Control — English")

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
        self.title("%s — MCC4 Motion Control" % self.current_file.name)
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
        self.title("MCC4 Motion Control — English")

    def download_parameters(self):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect to download controller parameters.", parent=self); return
        self.footer_text.set("Reading parameters from controller…")
        self._call("GETPARAS", on_done=self._loaded_parameters)

    def upload_parameters(self):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect before uploading parameters.", parent=self); return
        dialog = getattr(self, "parameter_dialog", None)
        if dialog and dialog.winfo_exists():
            try:
                dialog._read_entries()
            except ValueError as exc:
                messagebox.showerror("Invalid parameter", str(exc), parent=dialog)
                return
        try:
            for axis in range(4):
                base = axis * 10
                for index, var in ((2, self.speed_vars[axis]), (3, self.accel_vars[axis]),
                                   (8, self.neg_vars[axis]), (9, self.pos_vars[axis])):
                    text = var.get().strip()
                    if text:
                        self.params[base+index] = self._number(text, PARAMETERS[index])
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
        self._sequence(commands, on_done=lambda value, error: self._set_footer(value, error))

    def save_rom(self):
        if not self.connected:
            messagebox.showinfo("Not connected", "Connect before saving controller parameters.", parent=self); return
        if messagebox.askyesno("Save to controller", "Save current controller parameters to non-volatile memory?", parent=self):
            self._call("SAVE_ROM", on_done=self._set_footer)

    def open_parameters(self):
        dialog = getattr(self, "parameter_dialog", None)
        if dialog and dialog.winfo_exists():
            dialog.lift(); return
        self.parameter_dialog = ParameterDialog(self)

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
            if messagebox.askyesno("Confirm test move", "Move %s to %s?" % (axis.get(), target.get()), parent=win): self._call("ABS", *args, on_done=self._set_footer)
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
        messagebox.showinfo("About", "MCC4 Motion Control — English\n\nPython/Tkinter front end for the vendor MCC4DLL controller API.\nThe original MCCDEMO application is not modified by this interface.", parent=self)

    def close_app(self):
        if self.program_active and not messagebox.askyesno("Program active", "Stop the active program and close?", parent=self):
            return
        self.program_cancel.set(); self.program_gate.set()
        if self.poll_stop: self.poll_stop.set()
        try:
            if self.connected:
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
        self.title("Controller Parameter Set")
        self.geometry("940x510")
        self.minsize(820, 450)
        self.transient(app)
        self.vars = [[tk.StringVar(value=app._fmt_param(app.params[a*10+p]) if app.params[a*10+p] is not None else "")
                      for a in range(4)] for p in range(10)]
        outer = ttk.Frame(self, padding=14); outer.pack(fill="both", expand=True)
        ttk.Label(outer, text="Controller parameters by axis", style="Section.TLabel").pack(anchor="w")
        ttk.Label(outer, text="Parameter indexes follow the vendor DLL; edits are sent only when you choose Upload.", style="Hint.TLabel").pack(anchor="w", pady=(2, 10))
        table = ttk.Frame(outer); table.pack(fill="both", expand=True)
        ttk.Label(table, text="Parameter", width=28, style="Hint.TLabel").grid(row=0, column=0, sticky="w", padx=4, pady=4)
        for a, axis in enumerate(AXES):
            ttk.Label(table, text=axis, width=18, style="Hint.TLabel", anchor="center").grid(row=0, column=a+1, padx=4, pady=4)
        for p, name in enumerate(PARAMETERS):
            ttk.Label(table, text="%d · %s" % (p, name), width=28, style="Card.TLabel").grid(row=p+1, column=0, sticky="w", padx=4, pady=3)
            for a in range(4):
                ttk.Entry(table, textvariable=self.vars[p][a], width=18, justify="right").grid(row=p+1, column=a+1, padx=4, pady=3, sticky="ew")
        for col in range(1, 5): table.columnconfigure(col, weight=1)
        ttk.Label(outer, text="Changes to the controller are not permanent until you select Save Parameters To Controller.", style="Hint.TLabel").pack(anchor="w", pady=(9, 4))
        buttons = ttk.Frame(outer); buttons.pack(fill="x", pady=(5, 0))
        ttk.Button(buttons, text="Download From Controller", command=app.download_parameters).pack(side="left")
        ttk.Button(buttons, text="Upload To Controller", style="Accent.TButton", command=app.upload_parameters).pack(side="left", padx=6)
        ttk.Button(buttons, text="Save To ROM", command=app.save_rom).pack(side="left")
        ttk.Button(buttons, text="Close", command=self.destroy).pack(side="right")
        self.bind("<Destroy>", self._on_destroy, add=True)

    def _populate(self):
        for p in range(10):
            for a in range(4):
                value = self.app.params[a*10+p]
                self.vars[p][a].set(self.app._fmt_param(value) if value is not None else "")

    def _read_entries(self):
        values = [None] * 40
        for p in range(10):
            for a in range(4):
                raw = self.vars[p][a].get().strip()
                if not raw:
                    continue
                try: values[a*10+p] = float(raw)
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
