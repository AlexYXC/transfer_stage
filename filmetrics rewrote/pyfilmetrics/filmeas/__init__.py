"""pyfilmetrics — clean-room reimplementation of FILMeasure's measurement core.

Layers:
    filmeas.io      recipe / material / spectrum file formats
    filmeas.optics  dispersion models, transfer-matrix reflectance, thickness fitting
    filmeas.device  spectrometer interfaces (simulated now; FIUsbInt.dll COM later)
    filmeas.app     measure-pipeline controller + GUI
"""

__version__ = "0.1.0"
