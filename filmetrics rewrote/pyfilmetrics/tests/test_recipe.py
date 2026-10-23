import glob
import os

import pytest

from filmeas.io import Recipe, recipe_checksum

RECIPES_DIR = r"C:\ProgramData\Filmetrics\FILMeasure\Recipes"
SIO2 = os.path.join(RECIPES_DIR, "SiO2 on Si.fitrp")

pytestmark = pytest.mark.skipif(not os.path.isdir(RECIPES_DIR),
                                reason="FILMeasure reference recipes not installed")


def test_parse_header_and_layers():
    r = Recipe.load(SIO2)
    assert r.name == "SiO2 on Si"
    assert r.num_locations == 1
    assert r.version == 12
    layers = r.layers
    assert len(layers) == 3
    assert layers[0].layer_id == "Medium" and layers[0].material == "Air"
    assert layers[1].material == "SiO2"
    assert layers[1].thickness_A == 9000
    assert layers[1].solve_d is True          # "X" in the d column = solve thickness
    assert layers[2].layer_id == "Substrate" and layers[2].material == "Si"


def test_stored_checksum_verifies():
    r = Recipe.load(SIO2)
    assert r.verify() is True


def test_round_trip_bytes_identical():
    with open(SIO2, "rb") as f:
        original = f.read().decode("utf-8")
    r = Recipe.loads(original)
    assert r.dumps() == original


@pytest.mark.parametrize("path", sorted(glob.glob(os.path.join(RECIPES_DIR, "*.fitr*"))))
def test_all_shipped_recipes_checksum(path):
    r = Recipe.load(path)
    assert r.verify() is True, f"{os.path.basename(path)} checksum mismatch"


def test_edit_thickness_and_recheck():
    r = Recipe.load(SIO2)
    r.set_layer_thickness(1, 12000)
    out = r.dumps()
    r2 = Recipe.loads(out)
    assert r2.layers[1].thickness_A == 12000
    assert r2.verify() is True          # recomputed checksum is self-consistent


def test_acquisition_settings_present():
    r = Recipe.load(SIO2)
    acq = r.section("Acqusition Settings")   # note: FILMeasure's spelling
    assert "Fixed Integration Time (short wavelengths)" in acq
    assert acq["Fixed Integration Time (short wavelengths)"] == "40"


def test_checksum_function_matches_stored():
    with open(SIO2, "rb") as f:
        text = f.read().decode("utf-8")
    content = text[: text.index("CHECKSUM=")]
    assert recipe_checksum(content, 12) == 542698
