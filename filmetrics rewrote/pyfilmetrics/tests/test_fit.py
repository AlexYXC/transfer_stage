import numpy as np
import pytest

from filmeas.io import material
from filmeas.optics import fit, tmm

AIR = material.get("Air")
SIO2 = material.get("SiO2")
SI = material.get("Si")


def _stack(thickness_nm):
    return [(AIR, 0.0), (SIO2, thickness_nm), (SI, 0.0)]


def test_recovers_known_thickness_noiseless():
    wl = np.arange(400.0, 1000.0, 2.0)
    true_nm = 900.0                       # 9000 A
    meas = tmm.reflectance(wl, _stack(true_nm))
    r = fit.fit_thickness(wl, meas, _stack(0.0), solve_idx=[1], bounds_nm=(1.0, 20000.0))
    assert r.thickness_nm[0] == pytest.approx(true_nm, rel=0.01)
    assert r.gof > 0.999


def test_recovers_with_noise():
    rng = np.random.default_rng(0)
    wl = np.arange(400.0, 1000.0, 2.0)
    true_nm = 450.0
    meas = tmm.reflectance(wl, _stack(true_nm)) + rng.normal(0, 0.003, wl.shape)
    r = fit.fit_thickness(wl, meas, _stack(0.0), solve_idx=[1], bounds_nm=(1.0, 20000.0))
    assert r.thickness_nm[0] == pytest.approx(true_nm, rel=0.02)
    assert r.gof > 0.95


@pytest.mark.parametrize("true_nm", [120.0, 300.0, 1500.0, 5000.0])
def test_thickness_sweep(true_nm):
    wl = np.arange(400.0, 1000.0, 1.0)
    meas = tmm.reflectance(wl, _stack(true_nm))
    r = fit.fit_thickness(wl, meas, _stack(0.0), solve_idx=[1], bounds_nm=(1.0, 20000.0))
    assert r.thickness_nm[0] == pytest.approx(true_nm, rel=0.01)


def test_gof_perfect_for_identical():
    x = np.linspace(0, 1, 50)
    assert fit.gof(x, x) == pytest.approx(1.0)
