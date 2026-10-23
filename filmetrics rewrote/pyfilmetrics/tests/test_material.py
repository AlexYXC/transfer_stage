import numpy as np
import pytest

from filmeas.io import material
from filmeas.optics.dispersion import Cauchy, Constant, Tabulated


def test_constant():
    m = Constant(1.5, 0.01)
    assert m(600.0) == 1.5 + 0.01j


def test_cauchy_sio2_near_1p457():
    n = material.get("SiO2")(600.0).real
    assert 1.45 < n < 1.47


def test_tabulated_interpolates():
    t = Tabulated([400, 600], [2.0, 3.0], [0.0, 0.0])
    assert t(500.0).real == pytest.approx(2.5)


def test_si_absorbs_in_blue_more_than_ir():
    si = material.get("Si")
    assert si(400.0).imag > si(1000.0).imag        # k larger in the blue
    assert si(600.0).real == pytest.approx(3.94, abs=0.05)


def test_nk_csv_round_trip(tmp_path):
    p = tmp_path / "m.csv"
    p.write_text("wavelength_nm,n,k\n400,2.0,0.1\n800,2.4,0.0\n", encoding="utf-8")
    t = material.load_nk_csv(str(p))
    assert t(400.0) == pytest.approx(2.0 + 0.1j)
    assert t(800.0).real == pytest.approx(2.4)
