import os

os.environ.setdefault("QT_QPA_PLATFORM", "offscreen")   # headless Qt

import pytest

pytest.importorskip("PySide6", reason="PySide6 not installed")
pytest.importorskip("matplotlib", reason="matplotlib not installed")

from PySide6 import QtWidgets

from filmeas.app.gui import FilMeasureWindow

RECIPES = r"C:\ProgramData\Filmetrics\FILMeasure\Recipes"


@pytest.fixture(scope="module")
def qapp():
    app = QtWidgets.QApplication.instance() or QtWidgets.QApplication([])
    yield app


def test_window_constructs(qapp):
    win = FilMeasureWindow()
    assert win.inst is not None and win.ctrl is not None
    # measure disabled until a baseline exists
    assert win.measure_btn.isEnabled() is False


@pytest.mark.skipif(not os.path.isdir(RECIPES), reason="reference recipes not installed")
def test_baseline_then_measure_updates_result(qapp):
    win = FilMeasureWindow()
    assert win.recipe is not None                 # auto-loads SiO2 on Si
    win.avg_spin.setValue(9)
    win._on_baseline()
    assert win.measure_btn.isEnabled() is True
    win._on_measure()
    txt = win.result_lbl.text()
    assert "GOF" in txt and "Å" in txt
    # sanity: recovered thickness near the recipe nominal (9000 A)
    import re
    m = re.search(r"([\d.]+)\s*Å", txt)
    assert m and abs(float(m.group(1)) - 9000.0) / 9000.0 < 0.03
