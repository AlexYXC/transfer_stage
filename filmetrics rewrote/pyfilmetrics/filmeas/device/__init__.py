from .base import DeviceError, Instrument, RawAcquisition, wavelengths_from_cal
from .baseline import Baseline, reference_reflectance
from .simulated import SimulatedInstrument

__all__ = [
    "Instrument", "RawAcquisition", "DeviceError", "wavelengths_from_cal",
    "SimulatedInstrument", "Baseline", "reference_reflectance",
]

# FIUsbInstrument is imported lazily (it pulls in comtypes only when used):
#   from filmeas.device.fiusbint import FIUsbInstrument
