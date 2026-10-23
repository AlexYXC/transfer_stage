"""Desktop GUI (PySide6) — the clean-room analogue of FILMeasure's measure screen.

A window to: load a recipe, take a baseline, measure, and see the measured vs. fitted reflectance with
the recovered thickness + GOF. Backend is pluggable: the SimulatedInstrument (default, works everywhere)
or the real FIUsbInstrument (FIUsbInt.dll) once hardware is present.

Run:  python -m filmeas.app.gui        (or: python demo_gui.py)
"""
from __future__ import annotations

import os
import sys

import numpy as np

from matplotlib.backends.backend_qtagg import FigureCanvasQTAgg
from matplotlib.figure import Figure
from PySide6 import QtCore, QtWidgets

from ..device.simulated import SimulatedInstrument
from ..io import material
from ..io.recipe import Recipe
from .controller import MeasureController

DEFAULT_RECIPE = r"C:\ProgramData\Filmetrics\FILMeasure\Recipes\SiO2 on Si.fitrp"
AIR = material.get("Air")


def _ref_material_name(recipe: Recipe) -> str:
    acq = recipe.section("Acqusition Settings")
    raw = acq.get("<Reference Material1>", "").strip().strip('"')
    return raw or "Si"


class FilMeasureWindow(QtWidgets.QMainWindow):
    def __init__(self, backend: str = "Simulated"):
        super().__init__()
        self.setWindowTitle("pyfilmetrics — FILMeasure (clean-room)")
        self.resize(940, 620)
        self.recipe: Recipe | None = None
        self.inst = None
        self.ctrl: MeasureController | None = None
        self._build_ui()
        self._set_backend(backend)
        if os.path.exists(DEFAULT_RECIPE):
            self._load_recipe(DEFAULT_RECIPE)

    # ---- UI ----
    def _build_ui(self):
        central = QtWidgets.QWidget()
        self.setCentralWidget(central)
        root = QtWidgets.QVBoxLayout(central)

        # top row: recipe + backend
        top = QtWidgets.QHBoxLayout()
        self.recipe_edit = QtWidgets.QLineEdit()
        self.recipe_edit.setPlaceholderText("recipe .fitrp / .fitra …")
        browse = QtWidgets.QPushButton("Load Recipe…")
        browse.clicked.connect(self._on_browse)
        self.backend_combo = QtWidgets.QComboBox()
        self.backend_combo.addItems(["Simulated", "Real (FIUsbInt.dll)"])
        self.backend_combo.currentTextChanged.connect(
            lambda _t: self._set_backend("Real" if self.backend_combo.currentIndex() == 1 else "Simulated"))
        top.addWidget(QtWidgets.QLabel("Recipe:"))
        top.addWidget(self.recipe_edit, 1)
        top.addWidget(browse)
        top.addSpacing(12)
        top.addWidget(QtWidgets.QLabel("Instrument:"))
        top.addWidget(self.backend_combo)
        root.addLayout(top)

        # controls row
        ctr = QtWidgets.QHBoxLayout()
        self.int_spin = QtWidgets.QDoubleSpinBox()
        self.int_spin.setRange(1, 10000); self.int_spin.setValue(40); self.int_spin.setSuffix(" ms")
        self.avg_spin = QtWidgets.QSpinBox()
        self.avg_spin.setRange(1, 200); self.avg_spin.setValue(9)
        self.baseline_btn = QtWidgets.QPushButton("Take Baseline")
        self.baseline_btn.clicked.connect(self._on_baseline)
        self.measure_btn = QtWidgets.QPushButton("Measure")
        self.measure_btn.clicked.connect(self._on_measure)
        self.measure_btn.setEnabled(False)
        ctr.addWidget(QtWidgets.QLabel("Integration:"))
        ctr.addWidget(self.int_spin)
        ctr.addWidget(QtWidgets.QLabel("Averages:"))
        ctr.addWidget(self.avg_spin)
        ctr.addStretch(1)
        ctr.addWidget(self.baseline_btn)
        ctr.addWidget(self.measure_btn)
        root.addLayout(ctr)

        # plot
        self.fig = Figure(figsize=(8, 4.2))
        self.ax = self.fig.add_subplot(111)
        self.ax.set_xlabel("wavelength (nm)"); self.ax.set_ylabel("reflectance")
        self.ax.set_ylim(0, 1)
        self.canvas = FigureCanvasQTAgg(self.fig)
        root.addWidget(self.canvas, 1)

        # results + status
        self.result_lbl = QtWidgets.QLabel("Load a recipe, take a baseline, then Measure.")
        f = self.result_lbl.font(); f.setPointSize(f.pointSize() + 2); f.setBold(True)
        self.result_lbl.setFont(f)
        root.addWidget(self.result_lbl)
        self.status = self.statusBar()

    # ---- backend / recipe ----
    def _set_backend(self, backend: str):
        self.backend = backend
        if backend == "Real":
            try:
                from ..device.fiusbint import FIUsbInstrument
                self.inst = FIUsbInstrument()
                self.inst.connect()
                self.status.showMessage(f"Connected: {self.inst.model}")
            except Exception as e:
                self.status.showMessage(f"Real hardware unavailable ({e}); using simulator")
                self.backend = "Simulated"
                self.inst = SimulatedInstrument()
                self.inst.connect()
        else:
            self.inst = SimulatedInstrument()
            self.inst.connect()
            self.status.showMessage("Simulated instrument ready")
        self.ctrl = MeasureController(self.inst)
        self.measure_btn.setEnabled(False)

    def _load_recipe(self, path: str):
        try:
            self.recipe = Recipe.load(path)
        except Exception as e:
            QtWidgets.QMessageBox.critical(self, "Recipe error", str(e))
            return
        self.recipe_edit.setText(path)
        layers = " / ".join(f"{l.material} {l.thickness_A:.0f}Å" for l in self.recipe.layers)
        self.status.showMessage(f"Loaded {self.recipe.name!r}: {layers}")

    def _on_browse(self):
        path, _ = QtWidgets.QFileDialog.getOpenFileName(
            self, "Open recipe", os.path.dirname(DEFAULT_RECIPE), "Recipes (*.fitrp *.fitra);;All (*)")
        if path:
            self._load_recipe(path)

    # ---- actions ----
    def _sim(self):
        return isinstance(self.inst, SimulatedInstrument)

    def _on_baseline(self):
        if self.recipe is None:
            return
        self.inst.integration_time_ms = self.int_spin.value()
        ref_name = _ref_material_name(self.recipe)
        mount = None
        if self._sim():
            mount = lambda: self.inst.mount([(AIR, 0.0), (material.get(ref_name), 0.0)])
        try:
            self.ctrl.take_baseline(ref_name, averages=self.avg_spin.value(), mount_reference=mount)
        except Exception as e:
            QtWidgets.QMessageBox.critical(self, "Baseline error", str(e)); return
        self.measure_btn.setEnabled(True)
        self.status.showMessage(f"Baseline done (reference: {ref_name}). Ready to measure.")

    def _on_measure(self):
        if self.recipe is None or self.ctrl.baseline is None:
            return
        self.inst.integration_time_ms = self.int_spin.value()
        mount = None
        if self._sim():
            stack = [(AIR, 0.0)]
            for lay in self.recipe.layers[1:-1]:
                stack.append((material.get(lay.material), lay.thickness_nm))
            stack.append((material.get(self.recipe.layers[-1].material), 0.0))
            mount = lambda: self.inst.mount(stack)
        try:
            res = self.ctrl.measure(self.recipe, averages=self.avg_spin.value(), mount_sample=mount)
        except Exception as e:
            QtWidgets.QMessageBox.critical(self, "Measure error", str(e)); return
        self._plot(res)
        th = ", ".join(f"{t:.0f} Å" for t in res.thickness_A)
        self.result_lbl.setText(f"Thickness: {th}     GOF: {res.gof:.4f}")
        self.status.showMessage("Measurement complete.")

    def _plot(self, res):
        self.ax.clear()
        self.ax.plot(res.wavelength_nm, res.measured_R, ".", ms=3, alpha=0.5, label="measured")
        self.ax.plot(res.wavelength_nm, res.modeled_R, "-", lw=1.6, label="fitted model")
        self.ax.set_xlabel("wavelength (nm)"); self.ax.set_ylabel("reflectance")
        self.ax.set_ylim(0, 1); self.ax.legend(loc="best")
        th = ", ".join(f"{t:.0f} A" for t in res.thickness_A)
        name = self.recipe.name if self.recipe else ""
        self.ax.set_title(f"{name}:  thickness {th}   GOF {res.gof:.4f}")
        self.fig.tight_layout()
        self.canvas.draw_idle()


def main(argv=None):
    app = QtWidgets.QApplication(argv or sys.argv)
    win = FilMeasureWindow()
    win.show()
    return app.exec()


if __name__ == "__main__":
    raise SystemExit(main())
