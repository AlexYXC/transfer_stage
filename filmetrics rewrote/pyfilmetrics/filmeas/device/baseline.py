"""Baseline / reflectance calibration.

FILMeasure computes a sample's absolute reflectance from three raw reads and the known reflectance of a
reference standard:

    R_sample(lambda) = (raw_sample - background) / (reference - background) * R_reference(lambda)

where ``background`` is a light-off (dark) read and ``reference`` is a light-on read of a standard whose
reflectance R_reference is known (e.g. bare Si, or BK7). The lamp shape, detector gain and dark level
cancel. Mirrors the API's BaselineAcquireReference / BaselineAcquireBackgroundAfterRef / measure flow.
"""
from __future__ import annotations

import numpy as np

from ..optics import tmm


def reference_reflectance(wavelength_nm, reference_material, ambient=None):
    """Known reflectance of a bare reference standard (semi-infinite ``reference_material`` in ``ambient``)."""
    from ..io import material
    amb = ambient if ambient is not None else material.get("Air")
    return tmm.reflectance(wavelength_nm, [(amb, 0.0), (reference_material, 0.0)])


class Baseline:
    def __init__(self, wavelength_nm, reference_raw, background_raw, reference_reflectance_curve):
        self.wavelength_nm = np.asarray(wavelength_nm, dtype=float)
        self.reference_raw = np.asarray(reference_raw, dtype=float)
        self.background_raw = np.asarray(background_raw, dtype=float)
        self.reference_reflectance = np.asarray(reference_reflectance_curve, dtype=float)
        denom = self.reference_raw - self.background_raw
        if np.any(denom <= 0):
            # reference must be brighter than background at every pixel
            raise ValueError("reference is not above background at all pixels (bad baseline)")
        self._denom = denom

    def reflectance(self, sample_raw) -> np.ndarray:
        sample_raw = np.asarray(sample_raw, dtype=float)
        return (sample_raw - self.background_raw) / self._denom * self.reference_reflectance
