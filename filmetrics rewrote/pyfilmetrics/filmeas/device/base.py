"""Device-layer abstractions shared by the simulator and the real FIUsbInt.dll binding.

Modeled on the recovered COM interfaces IFIUsbSpectrometer / IFIUsbController (see
filmetric_re/analysis/decompiled/FILMeasure_project/FIUsbIntLib/). An ``Instrument`` exposes the few
operations the measurement pipeline needs; concrete backends (SimulatedInstrument, FIUsbInstrument)
implement them.
"""
from __future__ import annotations

import abc
from dataclasses import dataclass

import numpy as np

# FMUSBIntErr (from decompiled FIUsbIntLib.FMUSBIntErr) — negative device error codes.
FMUSB_ERRORS = {
    0: "NoErr", -100: "DevNotFound", -101: "MemAllocFail", -102: "DevListCreateFail",
    -103: "DevListMissing", -104: "NoMoreControllersInList", -105: "FailedToOpenDevice",
    -106: "FailedI2COperation", -107: "ControllerFWIncompatible", -108: "DeviceFWIncompatible",
    -109: "DevSpecificFWIncompatible", -110: "ObjectNotInstantiated", -111: "CreateEventFailure",
    -112: "Timeout", -113: "TriedToOpenDeviceAlreadyOpen", -114: "DCVoltZeroStuck",
    -117: "StringBufTooSmall", -118: "UnrecognizedDevType", -120: "BufferTooSmall",
    -123: "DeviceConnectNotDone", -124: "AnalogChipFailure", -127: "IntegrationTimeChanged",
    -128: "OverlappedStateMismatch", -133: "AcqAttemptWillCauseFIFOOverrun",
    -134: "AttemptToOverWriteFW", -135: "SignalTooSmall", -146: "CommandNotSupportedByHW",
    -147: "CommandNotAllowed",
}


class DeviceError(Exception):
    """A device operation returned a negative FMUSBIntErr code."""
    def __init__(self, code: int, context: str = ""):
        self.code = int(code)
        self.name = FMUSB_ERRORS.get(int(code), "Unknown")
        msg = f"{self.name} ({self.code})"
        if context:
            msg = f"{context}: {msg}"
        super().__init__(msg)


def check(code: int, context: str = "") -> int:
    """Raise DeviceError if ``code`` is a negative FMUSBIntErr; otherwise return it."""
    if code is not None and code < 0:
        raise DeviceError(code, context)
    return code


def wavelengths_from_cal(num_pixels: int, offset: float, slope: float,
                         curv: float = 0.0, third: float = 0.0, fourth: float = 0.0) -> np.ndarray:
    """Pixel->wavelength(nm) polynomial used by the spectrometer firmware (FWCalOffset/Slope/Curv/...)."""
    p = np.arange(int(num_pixels), dtype=float)
    return offset + slope * p + curv * p**2 + third * p**3 + fourth * p**4


@dataclass
class RawAcquisition:
    """One raw (uncalibrated) spectrum read from the detector."""
    wavelength_nm: np.ndarray
    counts: np.ndarray            # raw detector counts (dark NOT subtracted)
    integration_time_ms: float
    saturated: bool = False
    zero_error: bool = False      # signal at/near zero (dark stuck)


class Instrument(abc.ABC):
    """Minimal instrument surface the measurement pipeline depends on."""

    # --- lifecycle ---
    @abc.abstractmethod
    def connect(self, serial: str | None = None) -> None: ...

    @abc.abstractmethod
    def close(self) -> None: ...

    # --- static properties ---
    @property
    @abc.abstractmethod
    def num_pixels(self) -> int: ...

    @property
    @abc.abstractmethod
    def wavelengths_nm(self) -> np.ndarray: ...

    @property
    def model(self) -> str:
        return "unknown"

    # --- acquisition settings ---
    @property
    @abc.abstractmethod
    def integration_time_ms(self) -> float: ...

    @integration_time_ms.setter
    @abc.abstractmethod
    def integration_time_ms(self, value: float) -> None: ...

    @property
    def min_integration_time_ms(self) -> float:
        return 1.0

    @property
    def max_integration_time_ms(self) -> float:
        return 10000.0

    # --- light source ---
    @abc.abstractmethod
    def set_light(self, on: bool) -> None: ...

    # --- acquire ---
    @abc.abstractmethod
    def acquire(self, num_spectra: int = 1, averages: int = 1,
                smooth_pts: int = 0) -> RawAcquisition: ...

    def __enter__(self):
        self.connect()
        return self

    def __exit__(self, *exc):
        self.close()
