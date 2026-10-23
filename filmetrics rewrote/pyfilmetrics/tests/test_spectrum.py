import os

import numpy as np
import pytest

from filmeas.io.spectrum import Spectrum, load_fmspe

PREC = r"C:\ProgramData\Filmetrics\Precision"

pytestmark = pytest.mark.skipif(not os.path.isdir(PREC),
                                reason="FILMeasure Precision spectra not installed")


def test_load_fmspe_small():
    s = load_fmspe(os.path.join(PREC, "Si_F42.fmspe"))
    assert len(s) == 20
    assert s.wavelength_nm[0] == pytest.approx(420.98, abs=0.1)
    assert s.wavelength_nm[-1] == pytest.approx(800.44, abs=0.1)
    assert np.all(np.diff(s.wavelength_nm) > 0)          # monotonic increasing
    assert np.all(s.value > 0)
    assert "Si_F42" in s.label


def test_load_fmspe_large():
    s = load_fmspe(os.path.join(PREC, "Si_F20.fmspe"))
    assert len(s) == 959
    assert np.all(np.diff(s.wavelength_nm) > 0)
    assert 300 < s.wavelength_nm[0] < 450
    assert s.wavelength_nm[-1] > 1000
    assert s.label == "Si_F20"


def test_csv_round_trip(tmp_path):
    s = Spectrum(np.array([400.0, 500.0, 600.0]), np.array([0.1, 0.2, 0.3]),
                 label="demo", kind="reflectance")
    p = tmp_path / "s.csv"
    s.save_csv(str(p))
    s2 = Spectrum.load_csv(str(p), kind="reflectance")
    assert np.allclose(s2.wavelength_nm, s.wavelength_nm)
    assert np.allclose(s2.value, s.value)
