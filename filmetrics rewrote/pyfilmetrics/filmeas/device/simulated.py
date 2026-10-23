"""A physically-plausible simulated instrument (no hardware needed).

Models the real signal chain so the baseline/measure pipeline is exercised end to end:
    counts = dark + lamp(lambda) * R_sample(lambda) * gain * (integration/ref_integration) + noise
With the light off the reflected term vanishes (a dark/background read). Because the baseline divides
out ``lamp``, ``gain`` and ``dark``, the recovered reflectance equals the true stack reflectance —
exactly the property a real baseline relies on.
"""
from __future__ import annotations

import numpy as np

from ..optics import tmm
from .base import Instrument, RawAcquisition, wavelengths_from_cal

_REF_INT_MS = 40.0


class SimulatedInstrument(Instrument):
    def __init__(self, wavelength_nm=None, num_pixels: int = 512, cal=(380.0, 1.24, 0.0),
                 dark: float = 120.0, gain: float = 1500.0, read_noise: float = 2.0,
                 full_scale: float = 60000.0, seed: int = 0):
        if wavelength_nm is None:
            wavelength_nm = wavelengths_from_cal(num_pixels, *cal)
        self._wl = np.asarray(wavelength_nm, dtype=float)
        self._np = len(self._wl)
        # broad, smooth lamp spectrum (arbitrary units, strictly positive)
        self._lamp = 0.4 + np.exp(-((self._wl - 650.0) ** 2) / (2 * 300.0 ** 2))
        self._dark = float(dark)
        self._gain = float(gain)
        self._read_noise = float(read_noise)
        self._full_scale = float(full_scale)
        self._rng = np.random.default_rng(seed)
        self._int_ms = _REF_INT_MS
        self._light = True
        self._sample = None       # list[(dispersion, thickness_nm)] under the probe
        self._connected = False

    # --- lifecycle ---
    def connect(self, serial=None):
        self._connected = True

    def close(self):
        self._connected = False

    # --- static ---
    @property
    def num_pixels(self):
        return self._np

    @property
    def wavelengths_nm(self):
        return self._wl

    @property
    def model(self):
        return "Simulated"

    # --- settings ---
    @property
    def integration_time_ms(self):
        return self._int_ms

    @integration_time_ms.setter
    def integration_time_ms(self, value):
        self._int_ms = float(np.clip(value, self.min_integration_time_ms, self.max_integration_time_ms))

    def set_light(self, on: bool):
        self._light = bool(on)

    # --- simulation control ---
    def mount(self, stack):
        """Place a sample stack [(dispersion, thickness_nm), ...] (ambient-first) under the probe."""
        self._sample = stack

    # --- acquire ---
    def acquire(self, num_spectra: int = 1, averages: int = 1, smooth_pts: int = 0) -> RawAcquisition:
        if self._light and self._sample is not None:
            R = tmm.reflectance(self._wl, self._sample)
        else:
            R = np.zeros_like(self._wl)
        signal = self._lamp * R * self._gain * (self._int_ms / _REF_INT_MS)
        counts = self._dark + signal
        # noise: read noise + shot noise; averaging N reads reduces the std by sqrt(N)
        read = self._rng.normal(0, self._read_noise, counts.shape)
        shot = self._rng.normal(0, 1, counts.shape) * np.sqrt(np.maximum(counts, 0))
        n = counts + (read + shot) / np.sqrt(max(1, int(averages)))
        if smooth_pts and smooth_pts > 1:
            k = int(smooth_pts)
            n = np.convolve(n, np.ones(k) / k, mode="same")
        saturated = bool(np.any(n >= self._full_scale))
        n = np.minimum(n, self._full_scale)
        # zero_error is a hardware fault flag (all-zero buffer); a normal dark read is not a fault.
        return RawAcquisition(self._wl, n, self._int_ms, saturated, zero_error=False)
