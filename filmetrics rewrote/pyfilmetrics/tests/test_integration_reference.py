"""End-to-end: recipe -> stack -> model -> fit, validated against a known thickness; plus real .fmspe ingest.

We can't obtain absolute reflectance from the shipped RAW .fmspe (no paired reference/dark), so absolute-R
fitting of stored spectra is deferred to hardware. Here we validate the full pipeline self-consistently
(the recipe's own nominal stack is the ground truth) and confirm real-file ingestion works.
"""
import os

import numpy as np
import pytest

from filmeas.io import material
from filmeas.io.recipe import Recipe
from filmeas.io.spectrum import load_fmspe
from filmeas.optics import fit, tmm

RECIPES = r"C:\ProgramData\Filmetrics\FILMeasure\Recipes"
PREC = r"C:\ProgramData\Filmetrics\Precision"


def stack_from_recipe(r: Recipe):
    """Build a TMM stack [(dispersion, thickness_nm), ...] and the solve indices from a recipe."""
    layers, solve = [], []
    for i, lay in enumerate(r.layers):
        layers.append((material.get(lay.material), lay.thickness_nm))
        if lay.solve_d:
            solve.append(i)
    return layers, solve


@pytest.mark.skipif(not os.path.isdir(RECIPES), reason="reference recipes not installed")
def test_recipe_pipeline_recovers_nominal_thickness():
    r = Recipe.load(os.path.join(RECIPES, "SiO2 on Si.fitrp"))
    layers, solve = stack_from_recipe(r)
    assert solve == [1]                                   # only Layer 1 (SiO2) is solved
    true_nm = layers[1][1]                                # 9000 A -> 900 nm
    assert true_nm == pytest.approx(900.0)

    wl = np.arange(400.0, 1000.0, 2.0)
    measured = tmm.reflectance(wl, layers)               # simulate the nominal stack
    guess = [(disp, 0.0) if i in solve else (disp, d) for i, (disp, d) in enumerate(layers)]
    res = fit.fit_thickness(wl, measured, guess, solve_idx=solve, bounds_nm=(1.0, 20000.0))
    assert res.thickness_nm[0] == pytest.approx(true_nm, rel=0.01)
    assert res.gof > 0.999


@pytest.mark.skipif(not os.path.isdir(PREC), reason="reference spectra not installed")
def test_real_fmspe_ingest():
    s = load_fmspe(os.path.join(PREC, "Si_F20.fmspe"))
    assert len(s) > 100
    assert np.all(np.diff(s.wavelength_nm) > 0)
    assert s.value.min() >= 0
