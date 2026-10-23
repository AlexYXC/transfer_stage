import numpy as np
import pytest

from filmeas.io import material
from filmeas.optics import tmm

AIR = material.get("Air")
SIO2 = material.get("SiO2")
SI = material.get("Si")


def test_bare_silicon_reflectance_normal_incidence():
    # n_Si ~ 3.94 at 600 nm -> R = ((3.94-1)/(3.94+1))^2 ~ 0.354
    wl = np.array([600.0])
    R = tmm.reflectance(wl, [(AIR, 0.0), (SI, 0.0)])
    assert R[0] == pytest.approx(0.354, abs=0.02)


def test_sio2_film_shows_interference_fringes():
    wl = np.arange(400.0, 800.0, 1.0)
    R = tmm.reflectance(wl, [(AIR, 0.0), (SIO2, 500.0), (SI, 0.0)])  # 500 nm SiO2
    assert (R.max() - R.min()) > 0.1          # clear interference modulation
    assert np.all((R >= 0) & (R <= 1))


def test_zero_thickness_equals_bare_substrate():
    wl = np.arange(400.0, 900.0, 5.0)
    bare = tmm.reflectance(wl, [(AIR, 0.0), (SI, 0.0)])
    withfilm0 = tmm.reflectance(wl, [(AIR, 0.0), (SIO2, 0.0), (SI, 0.0)])
    assert np.allclose(bare, withfilm0, atol=1e-9)


def test_reflectance_in_unit_interval_with_absorption():
    wl = np.arange(400.0, 1000.0, 10.0)
    R = tmm.reflectance(wl, [(AIR, 0.0), (SIO2, 1200.0), (SI, 0.0)])
    assert np.all((R >= 0) & (R <= 1))
