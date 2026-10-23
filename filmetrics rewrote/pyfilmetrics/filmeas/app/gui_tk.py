"""Tkinter GUI — a Windows-7-friendly interface (no PySide6/Qt6, which require Win10+).

Same measurement flow as the Qt GUI (filmeas.app.gui) but built on Tkinter (ships with Python) + a matplotlib
Tk canvas, so it runs on older Python/Windows. Backend is the SimulatedInstrument by default, or the real
FIUsbInstrument when available.

Run:  python -m filmeas.app.gui_tk
"""
from __future__ import annotations

import os
import tkinter as tk
from tkinter import filedialog, messagebox, ttk

import matplotlib
matplotlib.use("TkAgg")
from matplotlib.backends.backend_tkagg import FigureCanvasTkAgg
from matplotlib.figure import Figure

from ..device.simulated import SimulatedInstrument
from ..io import material
from ..io.recipe import Recipe
from .controller import MeasureController

DEFAULT_RECIPE = r"C:\ProgramData\Filmetrics\FILMeasure\Recipes\SiO2 on Si.fitrp"
AIR = material.get("Air")


def _ref_material_name(recipe: Recipe) -> str:
    acq = recipe.section("Acqusition Settings")
    return (acq.get("<Reference Material1>", "").strip().strip('"')) or "Si"


class App:
    def __init__(self, root: tk.Tk):
        self.root = root
        root.title("pyfilmetrics — FILMeasure (clean-room)")
        self.recipe = None
        self.inst = SimulatedInstrument(); self.inst.connect()
        self.ctrl = MeasureController(self.inst)

        # --- controls ---
        top = ttk.Frame(root, padding=8); top.pack(fill="x")
        ttk.Label(top, text="Recipe:").pack(side="left")
        self.recipe_var = tk.StringVar()
        ttk.Entry(top, textvariable=self.recipe_var, width=60).pack(side="left", padx=4)
        ttk.Button(top, text="Load…", command=self._browse).pack(side="left")

        row = ttk.Frame(root, padding=(8, 0)); row.pack(fill="x")
        ttk.Label(row, text="Integration (ms):").pack(side="left")
        self.int_var = tk.DoubleVar(value=40.0)
        ttk.Entry(row, textvariable=self.int_var, width=8).pack(side="left", padx=4)
        ttk.Label(row, text="Averages:").pack(side="left")
        self.avg_var = tk.IntVar(value=9)
        ttk.Entry(row, textvariable=self.avg_var, width=6).pack(side="left", padx=4)
        self.baseline_btn = ttk.Button(row, text="Take Baseline", command=self._baseline)
        self.baseline_btn.pack(side="left", padx=8)
        self.measure_btn = ttk.Button(row, text="Measure", command=self._measure, state="disabled")
        self.measure_btn.pack(side="left")

        # --- plot ---
        self.fig = Figure(figsize=(8, 4.2))
        self.ax = self.fig.add_subplot(111)
        self.ax.set_xlabel("wavelength (nm)"); self.ax.set_ylabel("reflectance"); self.ax.set_ylim(0, 1)
        self.canvas = FigureCanvasTkAgg(self.fig, master=root)
        self.canvas.get_tk_widget().pack(fill="both", expand=True, padx=8, pady=8)

        self.result = tk.StringVar(value="Load a recipe, take a baseline, then Measure.")
        ttk.Label(root, textvariable=self.result, font=("Segoe UI", 11, "bold")).pack(pady=(0, 4))
        self.status = tk.StringVar(value="Simulated instrument ready")
        ttk.Label(root, textvariable=self.status, relief="sunken", anchor="w").pack(fill="x")

        if os.path.exists(DEFAULT_RECIPE):
            self._load(DEFAULT_RECIPE)

    # --- recipe ---
    def _load(self, path):
        try:
            self.recipe = Recipe.load(path)
        except Exception as e:
            messagebox.showerror("Recipe error", str(e)); return
        self.recipe_var.set(path)
        layers = " / ".join(f"{l.material} {l.thickness_A:.0f}A" for l in self.recipe.layers)
        self.status.set(f"Loaded {self.recipe.name!r}: {layers}")

    def _browse(self):
        p = filedialog.askopenfilename(
            initialdir=os.path.dirname(DEFAULT_RECIPE),
            filetypes=[("Recipes", "*.fitrp *.fitra"), ("All", "*.*")])
        if p:
            self._load(p)

    # --- actions ---
    def _baseline(self):
        if self.recipe is None:
            return
        self.inst.integration_time_ms = self.int_var.get()
        ref = _ref_material_name(self.recipe)
        try:
            self.ctrl.take_baseline(
                ref, averages=self.avg_var.get(),
                mount_reference=lambda: self.inst.mount([(AIR, 0.0), (material.get(ref), 0.0)]))
        except Exception as e:
            messagebox.showerror("Baseline error", str(e)); return
        self.measure_btn.config(state="normal")
        self.status.set(f"Baseline done (reference: {ref}). Ready to measure.")

    def _measure(self):
        if self.recipe is None or self.ctrl.baseline is None:
            return
        self.inst.integration_time_ms = self.int_var.get()
        stack = [(AIR, 0.0)]
        for lay in self.recipe.layers[1:-1]:
            stack.append((material.get(lay.material), lay.thickness_nm))
        stack.append((material.get(self.recipe.layers[-1].material), 0.0))
        try:
            res = self.ctrl.measure(self.recipe, averages=self.avg_var.get(),
                                    mount_sample=lambda: self.inst.mount(stack))
        except Exception as e:
            messagebox.showerror("Measure error", str(e)); return
        self.ax.clear()
        self.ax.plot(res.wavelength_nm, res.measured_R, ".", ms=3, alpha=0.5, label="measured")
        self.ax.plot(res.wavelength_nm, res.modeled_R, "-", lw=1.6, label="fitted model")
        self.ax.set_xlabel("wavelength (nm)"); self.ax.set_ylabel("reflectance"); self.ax.set_ylim(0, 1)
        th = ", ".join(f"{t:.0f} A" for t in res.thickness_A)
        self.ax.set_title(f"{self.recipe.name}:  {th}   GOF {res.gof:.4f}")
        self.ax.legend(loc="best"); self.fig.tight_layout(); self.canvas.draw()
        self.result.set(f"Thickness: {th}     GOF: {res.gof:.4f}")
        self.status.set("Measurement complete.")


def main():
    root = tk.Tk()
    App(root)
    root.geometry("940x640")
    root.mainloop()


if __name__ == "__main__":
    main()
