"""Fit film thickness(es) to a measured reflectance spectrum via the transfer-matrix model.

Mirrors FILMeasure's flow at a high level: build the model reflectance for a layer stack, then minimize
the residual against the measured spectrum with a nonlinear least-squares solver. A coarse grid search
seeds the initial thickness to avoid the many local minima of interference fits.
"""
from __future__ import annotations

from dataclasses import dataclass, field

import numpy as np
from scipy.optimize import least_squares

from . import tmm


def gof(measured, calculated) -> float:
    """Filmetrics-style goodness of fit: 1 - sqrt(SS_res / SS_tot). 1.0 == perfect."""
    measured = np.asarray(measured, dtype=float)
    calculated = np.asarray(calculated, dtype=float)
    ss_res = float(np.sum((measured - calculated) ** 2))
    ss_tot = float(np.sum((measured - measured.mean()) ** 2))
    if ss_tot <= 0:
        return 0.0
    return 1.0 - np.sqrt(ss_res / ss_tot)


@dataclass
class FitResult:
    thickness_nm: list          # fitted thickness of each solved layer (nm)
    gof: float
    modeled_R: np.ndarray
    success: bool
    message: str = ""


def _apply(layers, solve_idx, thicknesses):
    out = list(layers)
    for idx, t in zip(solve_idx, thicknesses):
        disp, _ = out[idx]
        out[idx] = (disp, float(t))
    return out


def fit_thickness(wavelength_nm, measured_R, layers, solve_idx,
                  bounds_nm=(0.0, 1.0e6), init_nm=None,
                  angle_deg=0.0, pol="TE", grid_nm=None):
    """Fit the thickness (nm) of the layers named in ``solve_idx``.

    layers: [(dispersion, thickness_nm), ...] ambient-first, substrate-last (semi-infinite ends).
    solve_idx: indices into ``layers`` whose thickness is a free parameter.
    """
    wl = np.asarray(wavelength_nm, dtype=float)
    meas = np.asarray(measured_R, dtype=float)
    lo, hi = bounds_nm

    def model(thicknesses):
        return tmm.reflectance(wl, _apply(layers, solve_idx, thicknesses), angle_deg, pol)

    def residual(x):
        return model(x) - meas

    # --- seed via grid search (single unknown) ---
    if init_nm is None:
        if len(solve_idx) == 1:
            top = hi if np.isfinite(hi) and hi < 5.0e5 else 20000.0
            grid = grid_nm if grid_nm is not None else np.linspace(max(lo, 1.0), top, 400)
            errs = [np.sum((model([g]) - meas) ** 2) for g in grid]
            init_nm = [float(grid[int(np.argmin(errs))])]
        else:
            init_nm = [max(lo, 100.0)] * len(solve_idx)

    res = least_squares(residual, x0=np.asarray(init_nm, dtype=float),
                        bounds=(lo, hi), method="trf")
    modeled = model(res.x)
    return FitResult(
        thickness_nm=[float(v) for v in res.x],
        gof=gof(meas, modeled),
        modeled_R=modeled,
        success=bool(res.success),
        message=str(res.message),
    )
