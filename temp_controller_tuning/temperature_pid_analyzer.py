import tkinter as tk
from tkinter import ttk, filedialog, messagebox
from pathlib import Path
import math

import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
from matplotlib.backends.backend_tkagg import FigureCanvasTkAgg, NavigationToolbar2Tk


# ============================================================
# Temperature PID Step-Response Analyzer
#
# Expected CSV columns (exact names are preferred):
#   Time (s)
#   Actual Temperature (C)
#   Target Temperature (C)
#
# The program automatically calculates:
#   - Initial / final / target temperature
#   - Step amplitude
#   - Peak temperature and peak time
#   - Overshoot (°C and % of commanded step)
#   - 10%, 50%, 90% crossing times
#   - 10–90% rise time
#   - 5%, 2%, 1% settling times
#   - Steady-state error
#   - MAE, RMSE, IAE, ISE, ITAE
#   - Final temperature noise / standard deviation
#   - Maximum heating and cooling rates
#   - Approximate apparent dead time
#   - Apparent closed-loop FOPDT time constant/dead time
#
# NOTE:
# A setpoint-response CSV alone is NOT sufficient to identify
# the open-loop plant gain needed for reliable model-based PID
# gain calculation. Heater/controller output should also be logged
# for a proper plant bump test.
# ============================================================


TIME_CANDIDATES = [
    "Time (s)", "Time", "time", "Seconds", "Elapsed Time (s)"
]
ACTUAL_CANDIDATES = [
    "Actual Temperature (C)", "Actual Temperature",
    "Temperature (C)", "Temperature", "PV", "Process Value"
]
TARGET_CANDIDATES = [
    "Target Temperature (C)", "Target Temperature",
    "Setpoint (C)", "Setpoint", "SP"
]


def find_column(df, candidates):
    """Return the first matching column using exact then case-insensitive matching."""
    for name in candidates:
        if name in df.columns:
            return name

    lower_map = {str(c).strip().lower(): c for c in df.columns}
    for name in candidates:
        key = name.strip().lower()
        if key in lower_map:
            return lower_map[key]

    return None


def first_crossing_time(t, y, level, direction):
    """
    Find first interpolated time y crosses 'level'.
    direction = +1 for increasing response, -1 for decreasing response.
    """
    z = direction * (y - level)

    # Already beyond threshold at first point
    if z[0] >= 0:
        return float(t[0])

    for i in range(1, len(y)):
        if z[i] >= 0 and z[i - 1] < 0:
            y0, y1 = y[i - 1], y[i]
            t0, t1 = t[i - 1], t[i]

            if y1 == y0:
                return float(t1)

            frac = (level - y0) / (y1 - y0)
            return float(t0 + frac * (t1 - t0))

    return np.nan


def settling_time(t, y, target, amplitude, percent):
    """
    Earliest time after which all remaining samples stay inside
    ±percent of the commanded temperature step.
    """
    band = abs(amplitude) * percent / 100.0

    if band == 0:
        return np.nan, np.nan

    inside = np.abs(y - target) <= band

    # suffix_all[i] = True if every sample i:end is inside
    suffix_all = np.logical_and.accumulate(inside[::-1])[::-1]
    indices = np.flatnonzero(suffix_all)

    if len(indices) == 0:
        return np.nan, band

    return float(t[indices[0]]), band


def safe_trapezoid(values, t):
    """Compatibility helper for NumPy versions with trapezoid or trapz."""
    if hasattr(np, "trapezoid"):
        return float(np.trapezoid(values, t))
    return float(np.trapz(values, t))


def analyze_temperature_data(df):
    time_col = find_column(df, TIME_CANDIDATES)
    actual_col = find_column(df, ACTUAL_CANDIDATES)
    target_col = find_column(df, TARGET_CANDIDATES)

    missing = []
    if time_col is None:
        missing.append("time")
    if actual_col is None:
        missing.append("actual temperature")
    if target_col is None:
        missing.append("target temperature")

    if missing:
        raise ValueError(
            "Could not identify: " + ", ".join(missing) +
            "\n\nCSV columns found:\n" + "\n".join(map(str, df.columns))
        )

    work = df[[time_col, actual_col, target_col]].copy()
    work.columns = ["time", "actual", "target"]

    for c in ["time", "actual", "target"]:
        work[c] = pd.to_numeric(work[c], errors="coerce")

    work = work.dropna().sort_values("time")
    work = work.drop_duplicates(subset="time", keep="last").reset_index(drop=True)

    if len(work) < 10:
        raise ValueError("Not enough valid samples to analyze.")

    t = work["time"].to_numpy(dtype=float)
    y = work["actual"].to_numpy(dtype=float)
    sp = work["target"].to_numpy(dtype=float)

    # Shift time so metrics are relative to the start of the recording.
    t0_record = float(t[0])
    tr = t - t0_record

    n = len(work)
    n_initial = max(5, int(round(n * 0.02)))
    n_final = max(10, int(round(n * 0.10)))

    initial_temp = float(np.median(y[:n_initial]))
    target_final = float(np.median(sp[-n_final:]))
    final_temp = float(np.mean(y[-n_final:]))
    final_temp_median = float(np.median(y[-n_final:]))
    final_std = float(np.std(y[-n_final:], ddof=1)) if n_final > 1 else 0.0

    amplitude = target_final - initial_temp
    direction = 1.0 if amplitude >= 0 else -1.0

    if abs(amplitude) < 1e-12:
        raise ValueError(
            "The target is too close to the initial temperature; "
            "a meaningful step response could not be detected."
        )

    # Peak in direction of response
    if direction > 0:
        peak_idx = int(np.argmax(y))
        peak_temp = float(y[peak_idx])
        overshoot_c = max(0.0, peak_temp - target_final)
    else:
        peak_idx = int(np.argmin(y))
        peak_temp = float(y[peak_idx])
        overshoot_c = max(0.0, target_final - peak_temp)

    peak_time = float(tr[peak_idx])
    overshoot_pct = 100.0 * overshoot_c / abs(amplitude)

    # Thresholds referenced to commanded target step
    level_10 = initial_temp + 0.10 * amplitude
    level_28 = initial_temp + 0.283 * amplitude
    level_50 = initial_temp + 0.50 * amplitude
    level_63 = initial_temp + 0.632 * amplitude
    level_90 = initial_temp + 0.90 * amplitude

    t10 = first_crossing_time(tr, y, level_10, direction)
    t28 = first_crossing_time(tr, y, level_28, direction)
    t50 = first_crossing_time(tr, y, level_50, direction)
    t63 = first_crossing_time(tr, y, level_63, direction)
    t90 = first_crossing_time(tr, y, level_90, direction)

    rise_time = t90 - t10 if np.isfinite(t10) and np.isfinite(t90) else np.nan

    ts5, band5 = settling_time(tr, y, target_final, amplitude, 5.0)
    ts2, band2 = settling_time(tr, y, target_final, amplitude, 2.0)
    ts1, band1 = settling_time(tr, y, target_final, amplitude, 1.0)

    error = sp - y
    steady_state_error = target_final - final_temp
    steady_state_error_pct = 100.0 * steady_state_error / abs(amplitude)

    mae = float(np.mean(np.abs(error)))
    rmse = float(np.sqrt(np.mean(error ** 2)))
    iae = safe_trapezoid(np.abs(error), tr)
    ise = safe_trapezoid(error ** 2, tr)
    itae = safe_trapezoid(tr * np.abs(error), tr)

    # Smooth temperature before differentiating to reduce sensor quantization noise.
    # Window is roughly 1% of samples, forced to an odd number.
    window = max(5, int(round(n * 0.01)))
    if window % 2 == 0:
        window += 1

    smooth = (
        pd.Series(y)
        .rolling(window=window, center=True, min_periods=1)
        .mean()
        .to_numpy()
    )
    dydt = np.gradient(smooth, tr)
    max_heat_rate = float(np.max(dydt))
    max_cool_rate = float(np.min(dydt))

    # "Apparent dead time": first 2% crossing.
    dead_level = initial_temp + 0.02 * amplitude
    apparent_dead_time = first_crossing_time(tr, y, dead_level, direction)

    # Smith two-point apparent FOPDT fit of the CLOSED-LOOP setpoint response:
    # t28.3 = L + 0.333*tau
    # t63.2 = L + 1.000*tau
    # tau = 1.5*(t63.2 - t28.3)
    # L = t63.2 - tau
    if np.isfinite(t28) and np.isfinite(t63) and t63 > t28:
        apparent_tau = 1.5 * (t63 - t28)
        apparent_L = t63 - apparent_tau
        apparent_L = max(0.0, apparent_L)
    else:
        apparent_tau = np.nan
        apparent_L = np.nan

    duration = float(tr[-1] - tr[0])
    sample_dt = float(np.median(np.diff(tr)))

    metrics = {
        "Samples": n,
        "Duration (s)": duration,
        "Median sample interval (s)": sample_dt,
        "Initial temperature (°C)": initial_temp,
        "Target temperature (°C)": target_final,
        "Commanded step (°C)": amplitude,
        "Final mean temperature (°C)": final_temp,
        "Final median temperature (°C)": final_temp_median,
        "Final temperature std dev (°C)": final_std,
        "Peak temperature (°C)": peak_temp,
        "Peak time (s)": peak_time,
        "Overshoot (°C)": overshoot_c,
        "Overshoot (% of step)": overshoot_pct,
        "10% crossing time (s)": t10,
        "50% crossing time (s)": t50,
        "90% crossing time (s)": t90,
        "10–90% rise time (s)": rise_time,
        "5% settling time (s)": ts5,
        "2% settling time (s)": ts2,
        "1% settling time (s)": ts1,
        "Steady-state error (°C)": steady_state_error,
        "Steady-state error (% of step)": steady_state_error_pct,
        "MAE (°C)": mae,
        "RMSE (°C)": rmse,
        "IAE (°C·s)": iae,
        "ISE (°C²·s)": ise,
        "ITAE (°C·s²)": itae,
        "Maximum smoothed heating rate (°C/s)": max_heat_rate,
        "Maximum smoothed cooling rate (°C/s)": max_cool_rate,
        "Apparent 2% response delay (s)": apparent_dead_time,
        "Apparent closed-loop FOPDT tau (s)": apparent_tau,
        "Apparent closed-loop FOPDT L (s)": apparent_L,
    }

    extra = {
        "time": tr,
        "actual": y,
        "target": sp,
        "error": error,
        "smooth": smooth,
        "dydt": dydt,
        "initial_temp": initial_temp,
        "target_final": target_final,
        "amplitude": amplitude,
        "peak_idx": peak_idx,
        "levels": {
            "10%": level_10,
            "50%": level_50,
            "90%": level_90,
        },
        "crossings": {
            "10%": t10,
            "50%": t50,
            "90%": t90,
        },
        "settling": {
            "5%": (ts5, band5),
            "2%": (ts2, band2),
            "1%": (ts1, band1),
        },
        "apparent_tau": apparent_tau,
        "apparent_L": apparent_L,
    }

    return metrics, extra


def format_value(value):
    if isinstance(value, (int, np.integer)):
        return str(value)
    try:
        value = float(value)
    except Exception:
        return str(value)

    if not np.isfinite(value):
        return "Not reached / unavailable"

    av = abs(value)
    if av >= 10000:
        return f"{value:,.1f}"
    if av >= 100:
        return f"{value:.2f}"
    if av >= 1:
        return f"{value:.3f}"
    return f"{value:.5f}"


def metrics_to_text(metrics, filename=""):
    lines = []
    lines.append("TEMPERATURE PID STEP-RESPONSE ANALYSIS")
    lines.append("=" * 48)
    if filename:
        lines.append(f"File: {filename}")
    lines.append("")

    groups = [
        ("DATA / OPERATING POINT", [
            "Samples",
            "Duration (s)",
            "Median sample interval (s)",
            "Initial temperature (°C)",
            "Target temperature (°C)",
            "Commanded step (°C)",
            "Final mean temperature (°C)",
            "Final median temperature (°C)",
            "Final temperature std dev (°C)",
        ]),
        ("TRANSIENT RESPONSE", [
            "Peak temperature (°C)",
            "Peak time (s)",
            "Overshoot (°C)",
            "Overshoot (% of step)",
            "10% crossing time (s)",
            "50% crossing time (s)",
            "90% crossing time (s)",
            "10–90% rise time (s)",
            "5% settling time (s)",
            "2% settling time (s)",
            "1% settling time (s)",
        ]),
        ("ERROR / PERFORMANCE INDICES", [
            "Steady-state error (°C)",
            "Steady-state error (% of step)",
            "MAE (°C)",
            "RMSE (°C)",
            "IAE (°C·s)",
            "ISE (°C²·s)",
            "ITAE (°C·s²)",
        ]),
        ("THERMAL RESPONSE / MODEL INDICATORS", [
            "Maximum smoothed heating rate (°C/s)",
            "Maximum smoothed cooling rate (°C/s)",
            "Apparent 2% response delay (s)",
            "Apparent closed-loop FOPDT tau (s)",
            "Apparent closed-loop FOPDT L (s)",
        ]),
    ]

    for title, keys in groups:
        lines.append(title)
        lines.append("-" * len(title))
        for key in keys:
            lines.append(f"{key:<42} {format_value(metrics[key])}")
        lines.append("")

    lines.append("PID-TUNING INTERPRETATION")
    lines.append("-" * 25)

    os_pct = metrics["Overshoot (% of step)"]
    ts2 = metrics["2% settling time (s)"]
    sse = metrics["Steady-state error (°C)"]

    if np.isfinite(os_pct):
        if os_pct < 1:
            lines.append("• Overshoot is very small (<1% of the commanded temperature step).")
        elif os_pct < 5:
            lines.append("• Overshoot is modest (<5% of the commanded temperature step).")
        else:
            lines.append("• Overshoot is significant and may warrant more damping / less aggressive integral action.")

    if np.isfinite(ts2):
        lines.append(f"• The 2% settling time is approximately {ts2:.1f} s.")
    else:
        lines.append("• The response did not remain inside the 2% settling band before the recording ended.")

    lines.append(f"• Final steady-state error is approximately {sse:.3f} °C.")

    lines.append("")
    lines.append("MODEL LIMITATION")
    lines.append("-" * 16)
    lines.append(
        "The FOPDT values above describe an APPARENT CLOSED-LOOP setpoint response. "
        "They are useful for comparing tuning runs, but they are not a replacement "
        "for an open-loop plant model."
    )
    lines.append(
        "For reliable IMC / Cohen-Coon / reaction-curve PID gain calculation, log "
        "the heater/controller output (for example, heater power or PWM %) and perform "
        "a controlled bump test. With temperature and setpoint alone, the true process "
        "gain cannot be identified reliably."
    )

    return "\n".join(lines)


class PIDAnalyzerApp:
    def __init__(self, root):
        self.root = root
        self.root.title("Temperature PID Step-Response Analyzer")
        self.root.geometry("1320x850")

        self.df = None
        self.metrics = None
        self.extra = None
        self.file_path = None

        self._build_ui()

    def _build_ui(self):
        top = ttk.Frame(self.root, padding=8)
        top.pack(fill="x")

        ttk.Button(top, text="Open CSV", command=self.open_csv).pack(side="left", padx=4)
        ttk.Button(top, text="Analyze", command=self.run_analysis).pack(side="left", padx=4)
        ttk.Button(top, text="Save report", command=self.save_report).pack(side="left", padx=4)
        ttk.Button(top, text="Save plots", command=self.save_plots).pack(side="left", padx=4)
        ttk.Button(top, text="Export metrics CSV", command=self.export_metrics).pack(side="left", padx=4)

        self.filename_label = ttk.Label(top, text="No CSV loaded")
        self.filename_label.pack(side="left", padx=12)

        self.notebook = ttk.Notebook(self.root)
        self.notebook.pack(fill="both", expand=True, padx=8, pady=(0, 8))

        # Summary tab
        summary_frame = ttk.Frame(self.notebook)
        self.notebook.add(summary_frame, text="Analysis report")

        self.report_text = tk.Text(summary_frame, wrap="word", font=("Consolas", 10))
        report_scroll = ttk.Scrollbar(summary_frame, orient="vertical", command=self.report_text.yview)
        self.report_text.configure(yscrollcommand=report_scroll.set)
        self.report_text.pack(side="left", fill="both", expand=True)
        report_scroll.pack(side="right", fill="y")

        # Metrics table
        metrics_frame = ttk.Frame(self.notebook)
        self.notebook.add(metrics_frame, text="Metrics table")

        self.metric_tree = ttk.Treeview(
            metrics_frame, columns=("metric", "value"), show="headings"
        )
        self.metric_tree.heading("metric", text="Metric")
        self.metric_tree.heading("value", text="Value")
        self.metric_tree.column("metric", width=480, anchor="w")
        self.metric_tree.column("value", width=220, anchor="e")
        self.metric_tree.pack(fill="both", expand=True)

        # Plot tabs
        self.response_frame = ttk.Frame(self.notebook)
        self.notebook.add(self.response_frame, text="Response")

        self.error_frame = ttk.Frame(self.notebook)
        self.notebook.add(self.error_frame, text="Error")

        self.rate_frame = ttk.Frame(self.notebook)
        self.notebook.add(self.rate_frame, text="Heating rate")

        self.settling_frame = ttk.Frame(self.notebook)
        self.notebook.add(self.settling_frame, text="Settling / rise")

        self.figures = {}

    def open_csv(self):
        path = filedialog.askopenfilename(
            title="Select temperature CSV",
            filetypes=[("CSV files", "*.csv"), ("All files", "*.*")]
        )
        if not path:
            return

        try:
            self.df = pd.read_csv(path)
            self.file_path = Path(path)
            self.filename_label.config(text=self.file_path.name)
            self.run_analysis()
        except Exception as exc:
            messagebox.showerror("Open CSV failed", str(exc))

    def run_analysis(self):
        if self.df is None:
            messagebox.showwarning("No data", "Open a CSV file first.")
            return

        try:
            self.metrics, self.extra = analyze_temperature_data(self.df)
        except Exception as exc:
            messagebox.showerror("Analysis failed", str(exc))
            return

        report = metrics_to_text(
            self.metrics,
            self.file_path.name if self.file_path else ""
        )
        self.report_text.delete("1.0", tk.END)
        self.report_text.insert("1.0", report)

        for item in self.metric_tree.get_children():
            self.metric_tree.delete(item)

        for key, value in self.metrics.items():
            self.metric_tree.insert("", "end", values=(key, format_value(value)))

        self.make_plots()

    def clear_frame(self, frame):
        for widget in frame.winfo_children():
            widget.destroy()

    def embed_figure(self, frame, fig):
        self.clear_frame(frame)
        canvas = FigureCanvasTkAgg(fig, master=frame)
        canvas.draw()

        toolbar = NavigationToolbar2Tk(canvas, frame, pack_toolbar=False)
        toolbar.update()
        toolbar.pack(side="top", fill="x")

        canvas.get_tk_widget().pack(side="top", fill="both", expand=True)
        return canvas

    def make_plots(self):
        x = self.extra["time"]
        y = self.extra["actual"]
        sp = self.extra["target"]
        error = self.extra["error"]
        dydt = self.extra["dydt"]
        target = self.extra["target_final"]
        amp = self.extra["amplitude"]

        # ----------------------------------------------------
        # 1. Main response plot
        # ----------------------------------------------------
        fig1, ax1 = plt.subplots(figsize=(11, 6))
        ax1.plot(x, y, label="Actual temperature")
        ax1.plot(x, sp, "--", label="Target temperature")

        peak_idx = self.extra["peak_idx"]
        ax1.scatter(
            [x[peak_idx]], [y[peak_idx]],
            s=55,
            label=f"Peak = {y[peak_idx]:.2f} °C"
        )

        ax1.set_title("Temperature step response")
        ax1.set_xlabel("Time (s)")
        ax1.set_ylabel("Temperature (°C)")
        ax1.grid(True, alpha=0.3)
        ax1.legend()
        fig1.tight_layout()

        self.figures["response"] = fig1
        self.embed_figure(self.response_frame, fig1)

        # ----------------------------------------------------
        # 2. Error plot
        # ----------------------------------------------------
        fig2, ax2 = plt.subplots(figsize=(11, 6))
        ax2.plot(x, error, label="Setpoint error = target - actual")
        ax2.axhline(0, linewidth=1)
        ax2.set_title("Control error")
        ax2.set_xlabel("Time (s)")
        ax2.set_ylabel("Error (°C)")
        ax2.grid(True, alpha=0.3)
        ax2.legend()
        fig2.tight_layout()

        self.figures["error"] = fig2
        self.embed_figure(self.error_frame, fig2)

        # ----------------------------------------------------
        # 3. Heating/cooling rate
        # ----------------------------------------------------
        fig3, ax3 = plt.subplots(figsize=(11, 6))
        ax3.plot(x, dydt, label="Smoothed dT/dt")
        ax3.axhline(0, linewidth=1)
        ax3.set_title("Temperature rate of change")
        ax3.set_xlabel("Time (s)")
        ax3.set_ylabel("dT/dt (°C/s)")
        ax3.grid(True, alpha=0.3)
        ax3.legend()
        fig3.tight_layout()

        self.figures["rate"] = fig3
        self.embed_figure(self.rate_frame, fig3)

        # ----------------------------------------------------
        # 4. Rise/settling diagnostic
        # ----------------------------------------------------
        fig4, ax4 = plt.subplots(figsize=(11, 6))
        ax4.plot(x, y, label="Actual")
        ax4.plot(x, sp, "--", label="Target")

        # 2% settling band
        ts2, band2 = self.extra["settling"]["2%"]
        if np.isfinite(band2):
            ax4.axhline(target + band2, linestyle=":", label="+2% band")
            ax4.axhline(target - band2, linestyle=":", label="-2% band")

        if np.isfinite(ts2):
            ax4.axvline(ts2, linestyle="--", label=f"2% settling = {ts2:.1f} s")

        # 10%, 50%, 90% thresholds and crossings
        for name in ["10%", "50%", "90%"]:
            level = self.extra["levels"][name]
            tcross = self.extra["crossings"][name]
            ax4.axhline(level, linewidth=0.8, alpha=0.5)
            if np.isfinite(tcross):
                ax4.scatter([tcross], [level], s=35, label=f"{name} = {tcross:.1f} s")

        ax4.set_title("Rise-time and settling-time diagnostics")
        ax4.set_xlabel("Time (s)")
        ax4.set_ylabel("Temperature (°C)")
        ax4.grid(True, alpha=0.3)
        ax4.legend()
        fig4.tight_layout()

        self.figures["settling"] = fig4
        self.embed_figure(self.settling_frame, fig4)

    def save_report(self):
        if self.metrics is None:
            messagebox.showwarning("No analysis", "Analyze a CSV first.")
            return

        path = filedialog.asksaveasfilename(
            defaultextension=".txt",
            filetypes=[("Text file", "*.txt"), ("All files", "*.*")],
            initialfile="temperature_pid_analysis.txt"
        )
        if not path:
            return

        text = metrics_to_text(
            self.metrics,
            self.file_path.name if self.file_path else ""
        )
        Path(path).write_text(text, encoding="utf-8")
        messagebox.showinfo("Saved", f"Report saved to:\n{path}")

    def export_metrics(self):
        if self.metrics is None:
            messagebox.showwarning("No analysis", "Analyze a CSV first.")
            return

        path = filedialog.asksaveasfilename(
            defaultextension=".csv",
            filetypes=[("CSV file", "*.csv")],
            initialfile="temperature_pid_metrics.csv"
        )
        if not path:
            return

        out = pd.DataFrame(
            {"Metric": list(self.metrics.keys()),
             "Value": list(self.metrics.values())}
        )
        out.to_csv(path, index=False)
        messagebox.showinfo("Saved", f"Metrics saved to:\n{path}")

    def save_plots(self):
        if not self.figures:
            messagebox.showwarning("No plots", "Analyze a CSV first.")
            return

        folder = filedialog.askdirectory(title="Choose folder for plots")
        if not folder:
            return

        folder = Path(folder)
        stem = self.file_path.stem if self.file_path else "temperature"

        for name, fig in self.figures.items():
            fig.savefig(
                folder / f"{stem}_{name}.png",
                dpi=300,
                bbox_inches="tight"
            )

        messagebox.showinfo(
            "Saved",
            f"Saved {len(self.figures)} plot files to:\n{folder}"
        )


def main():
    root = tk.Tk()
    app = PIDAnalyzerApp(root)
    root.mainloop()


if __name__ == "__main__":
    main()
