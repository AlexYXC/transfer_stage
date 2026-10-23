import numpy as np
import pytest

from filmeas.io import material
from filmeas.optics.dispersion import CauchyUrbach, Lorentz, Sellmeier


def test_bk7_nd_matches_catalog():
    # Schott BK7 refractive index at the d-line (587.56 nm) is 1.5168
    n = material.get("BK7")(587.56).real
    assert n == pytest.approx(1.5168, abs=0.001)


def test_fused_silica_matches_literature():
    n = material.get("SiO2")(587.56).real
    assert n == pytest.approx(1.4585, abs=0.002)


def test_sapphire_and_water_available_and_reasonable():
    assert 1.74 < material.get("Al2O3")(587.6).real < 1.79
    assert 1.32 < material.get("Water")(587.6).real < 1.34


def test_lorentz_absorbs_near_resonance():
    d = Lorentz(eps_inf=1.0, oscillators=[(20.0, 4.0, 0.4)])   # resonance at 4 eV (~310 nm)
    nk_res = d(310.0)
    nk_ir = d(1000.0)
    assert nk_res.imag > 0.05          # absorbing near resonance
    assert nk_res.imag > nk_ir.imag    # less absorbing far in the IR
    assert nk_res.real > 0


def test_cauchy_urbach_absorption_tail():
    d = CauchyUrbach(1.5, 0.004, 0.0, k_amp=0.01, k_beta=1.0)
    assert d(400.0).imag > d(800.0).imag >= 0     # k falls with wavelength
    assert d(600.0).real > 1.4


def test_sellmeier_k_is_zero():
    s = Sellmeier([(1.0, 0.01)])
    assert s(600.0).imag == 0.0
