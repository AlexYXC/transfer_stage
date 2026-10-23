import os

import numpy as np
import pytest

from filmeas.io import material
from filmeas.io.recipe import Recipe
from filmeas.device.simulated import SimulatedInstrument
from filmeas.app.controller import MeasureController

AIR, SIO2, SI = material.get("Air"), material.get("SiO2"), material.get("Si")
RECIPES = r"C:\ProgramData\Filmetrics\FILMeasure\Recipes"


def test_measure_requires_baseline():
    ctrl = MeasureController(SimulatedInstrument())
    with pytest.raises(RuntimeError):
        ctrl.measure(_fake_recipe())


def _fake_recipe():
    # minimal in-memory recipe: SiO2 900 nm on Si, solve thickness
    text = (
        "***Machine Readable Structure Export Version (Copy all lines), 12\r\n"
        "Name, \"t\"\r\nNum Location,  1\r\nUnitsMode(A),1\r\n\r\n"
        "===== Measure Site  1 =====\r\n[Layers]\r\nNumber of Layers,  1\r\n"
        "Layer ID      \"Material\"   \"Thick.(A)\"\"Rough.(A)\"  d    n    k    r  \r\n"
        "  Medium  ,      \"Air\"      ,    0     ,    0     ,     ,     ,     ,     \r\n"
        " Layer  1 ,      \"SiO2\"     ,   9000   ,    0     ,  X  ,     ,     ,     \r\n"
        "Substrate ,      \"Si\"       ,    0     ,    0     ,     ,     ,     ,     \r\n\r\n"
        "***End Machine Readable Structure***\r\n"
    )
    return Recipe.loads(text + "CHECKSUM= 0\r\n")


def _run(recipe, true_nm=900.0):
    inst = SimulatedInstrument(seed=11)
    ctrl = MeasureController(inst)
    ctrl.take_baseline("Si", averages=9,
                       mount_reference=lambda: inst.mount([(AIR, 0.0), (SI, 0.0)]))
    return ctrl.measure(recipe, averages=9,
                        mount_sample=lambda: inst.mount([(AIR, 0.0), (SIO2, true_nm), (SI, 0.0)]))


def test_end_to_end_simulated_measurement_recovers_thickness():
    res = _run(_fake_recipe(), true_nm=900.0)
    assert res.thickness_A[0] == pytest.approx(9000.0, rel=0.02)
    assert res.gof > 0.9
    assert res.measured_R.shape == res.wavelength_nm.shape


@pytest.mark.skipif(not os.path.isdir(RECIPES), reason="reference recipes not installed")
def test_end_to_end_with_real_recipe_file():
    recipe = Recipe.load(os.path.join(RECIPES, "SiO2 on Si.fitrp"))
    res = _run(recipe, true_nm=recipe.layers[1].thickness_nm)
    assert res.thickness_A[0] == pytest.approx(recipe.layers[1].thickness_A, rel=0.02)
    assert res.gof > 0.9
