"""Measure pipeline controller — the clean-room analogue of FILMeasure's FIRemote.Measure flow.

Ties the device layer (any ``Instrument``), the baseline calibration, and the optics fit together:
    take_baseline(reference_material) -> Baseline
    measure(recipe) -> MeasureResult (fitted thickness + GOF + spectra)

Works with the SimulatedInstrument today and, unchanged, with the real FIUsbInstrument once hardware
is present.
"""
from __future__ import annotations

from dataclasses import dataclass

import numpy as np

from ..device.baseline import Baseline, reference_reflectance
from ..io import material
from ..io.recipe import Recipe
from ..optics import fit
from ..optics.fit import FitResult


@dataclass
class MeasureResult:
    thickness_A: list            # fitted thickness of each solved layer, angstroms
    gof: float
    wavelength_nm: np.ndarray
    measured_R: np.ndarray
    modeled_R: np.ndarray
    fit: FitResult


class MeasureController:
    def __init__(self, instrument, material_lookup=material.get):
        self.inst = instrument
        self.get_material = material_lookup
        self.baseline: Baseline | None = None

    # --- baseline ---
    def take_baseline(self, reference_material_name: str,
                      averages: int = 1, mount_reference=None) -> Baseline:
        """Acquire reference (light on, reference standard) + background (light off)."""
        ref_disp = self.get_material(reference_material_name)
        if mount_reference is not None:
            mount_reference()                       # e.g. simulator: mount the bare reference standard
        self.inst.set_light(True)
        ref = self.inst.acquire(averages=averages)
        self.inst.set_light(False)
        bkg = self.inst.acquire(averages=averages)
        self.inst.set_light(True)
        wl = ref.wavelength_nm
        rref = reference_reflectance(wl, ref_disp)
        self.baseline = Baseline(wl, ref.counts, bkg.counts, rref)
        return self.baseline

    # --- measure ---
    def stack_from_recipe(self, recipe: Recipe):
        layers, solve = [], []
        for i, lay in enumerate(recipe.layers):
            layers.append((self.get_material(lay.material), lay.thickness_nm))
            if lay.solve_d:
                solve.append(i)
        return layers, solve

    def measure(self, recipe: Recipe, averages: int = 1, mount_sample=None) -> MeasureResult:
        if self.baseline is None:
            raise RuntimeError("no baseline; call take_baseline() first")
        if mount_sample is not None:
            mount_sample()
        self.inst.set_light(True)
        raw = self.inst.acquire(averages=averages)
        measured_R = self.baseline.reflectance(raw.counts)

        layers, solve = self.stack_from_recipe(recipe)
        # start the solved layers "unknown"
        guess = [(d, 0.0) if i in solve else (d, t) for i, (d, t) in enumerate(layers)]
        res = fit.fit_thickness(raw.wavelength_nm, measured_R, guess,
                                solve_idx=solve, bounds_nm=(1.0, 50000.0))
        return MeasureResult(
            thickness_A=[t * 10.0 for t in res.thickness_nm],
            gof=res.gof,
            wavelength_nm=raw.wavelength_nm,
            measured_R=measured_R,
            modeled_R=res.modeled_R,
            fit=res,
        )
