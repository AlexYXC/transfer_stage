"""Real-hardware backend: binds the vendor's native COM server FIUsbInt.dll (SysWOW64).

*** HARDWARE-UNTESTED ***
Written against the recovered COM interfaces (IFIUsbController / IFIUsbSpectrometer, see
filmetric_re/analysis/decompiled/FILMeasure_project/FIUsbIntLib/) but NOT yet run against an instrument
(none available). Requires 32-bit Python (the server is x86), the ``comtypes`` package, and the device
present. Method/DispId names are taken verbatim from the decompiled interface; exact comtypes marshaling
of the SafeArray/[in,out] parameters must be confirmed on real hardware.

ProgIDs (from constants_strings.md): FIUsbInt.FIUsbController.1, FIUsbInt.FIUsbSpectrometer.1
"""
from __future__ import annotations

import numpy as np

from .base import Instrument, RawAcquisition, check, wavelengths_from_cal

CONTROLLER_PROGID = "FIUsbInt.FIUsbController.1"
SPECTROMETER_PROGID = "FIUsbInt.FIUsbSpectrometer.1"
ENUM_PROGID = "FIUsbInt.FMusbEnum.1"


def enumerate_controllers(max_controllers: int = 8):  # pragma: no cover - needs hardware
    """Read-only: list attached controllers via FMusbEnum.EnumerateController2.

    Returns a list of dicts. Requires comtypes + hardware. Never opens/writes the device.
    """
    import comtypes.client
    enum = comtypes.client.CreateObject(ENUM_PROGID)
    found = []
    for idx in range(max_controllers):
        try:
            # EnumerateController2(idx, out errCode, out SN, out friendlySN, out devType,
            #   out revLevel, out subsysIdx, out systemType, out systemSubtype)
            res = enum.EnumerateController2(idx)
        except Exception:
            break
        vals = list(res) if isinstance(res, (tuple, list)) else [res]
        err = next((int(v) for v in vals if isinstance(v, int)), 0)
        if err < 0:
            break
        found.append({"index": idx, "raw": vals})
    try:
        enum.Close()
    except Exception:
        pass
    return found


class FIUsbInstrument(Instrument):
    def __init__(self):
        self._ctrl = None
        self._spec = None
        self._npix = 0

    def _com(self):
        try:
            import comtypes.client  # noqa: F401
            return comtypes.client
        except Exception as e:  # pragma: no cover - environment dependent
            raise RuntimeError(
                "comtypes is required for the real device backend: pip install comtypes "
                "(and use 32-bit Python — FIUsbInt.dll is x86)"
            ) from e

    # --- lifecycle ---
    def connect(self, serial: str | None = None):  # pragma: no cover - needs hardware
        com = self._com()
        self._ctrl = com.CreateObject(CONTROLLER_PROGID)
        self._spec = com.CreateObject(SPECTROMETER_PROGID)
        sn = serial or ""
        use_first = 0 if serial else 1
        # Controller.Connect(bUseFirstAvail, serialNumber, ref lErrCode)
        err = self._ctrl.Connect(use_first, sn)
        check(_as_code(err), "Controller.Connect")
        # Spectrometer.Connect(bUseFirstAvail, controllerSN, ucDevIdx, ref plErrCode)
        err = self._spec.Connect(use_first, sn, 0)
        check(_as_code(err), "Spectrometer.Connect")
        self._npix = int(self._spec.NumPixels)

    def close(self):  # pragma: no cover - needs hardware
        for obj in (self._spec, self._ctrl):
            try:
                if obj is not None:
                    obj.Release()
            except Exception:
                pass
        self._spec = self._ctrl = None

    # --- static ---
    @property
    def num_pixels(self):  # pragma: no cover - needs hardware
        return self._npix or int(self._spec.NumPixels)

    @property
    def wavelengths_nm(self):  # pragma: no cover - needs hardware
        s = self._spec
        return wavelengths_from_cal(
            self.num_pixels, float(s.FWCalOffset), float(s.FWCalSlope),
            float(s.FWCalCurv), float(s.FWCalThird), float(s.FWCalFourth),
        )

    @property
    def model(self):  # pragma: no cover - needs hardware
        try:
            return str(self._ctrl.FWInstTypeCodeAsEnum)
        except Exception:
            return "unknown"

    # --- settings ---
    @property
    def integration_time_ms(self):  # pragma: no cover - needs hardware
        return float(self._spec.IntegrationTime)

    @integration_time_ms.setter
    def integration_time_ms(self, value):  # pragma: no cover - needs hardware
        check(int(self._spec.SetIntegrationTime(float(value))), "SetIntegrationTime")

    @property
    def min_integration_time_ms(self):  # pragma: no cover - needs hardware
        return float(self._spec.MinIntegrationTime)

    @property
    def max_integration_time_ms(self):  # pragma: no cover - needs hardware
        return float(self._spec.MaxIntegrationTime)

    # --- light ---
    def set_light(self, on: bool):  # pragma: no cover - needs hardware
        check(int(self._ctrl.SetLightSourcePowerOnState(1 if on else 0)), "SetLightSourcePowerOnState")

    # --- acquire ---
    def acquire(self, num_spectra: int = 1, averages: int = 1, smooth_pts: int = 0) -> RawAcquisition:  # pragma: no cover - needs hardware
        n = self.num_pixels
        buf = np.zeros(n, dtype=np.float64)
        # GetSpectraSafe(sNumSpectra, sNumAveragesPerSpectrum, sSmoothPts,
        #                ref bZeroError, ref bSatError, lBufferSize, dBuffer[])
        rc, zero_err, sat_err, out = self._spec.GetSpectraSafe(
            int(num_spectra), int(averages), int(smooth_pts), 0, 0, n, buf
        )
        check(int(rc), "GetSpectraSafe")
        counts = np.asarray(out, dtype=float) if out is not None else buf
        return RawAcquisition(self.wavelengths_nm, counts, self.integration_time_ms,
                              saturated=bool(sat_err), zero_error=bool(zero_err))


def _as_code(ret):
    """Normalize a COM [in,out]/return error value (comtypes may return a scalar or tuple)."""
    if isinstance(ret, (tuple, list)):
        return int(ret[-1])
    try:
        return int(ret)
    except Exception:
        return 0
