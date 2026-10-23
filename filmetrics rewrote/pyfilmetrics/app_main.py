"""Entry point for the packaged pyFILMeasure desktop app.

Normal launch opens the GUI. `--selftest` runs a headless measurement and exits (used to verify the
packaged exe works without a display).
"""
import multiprocessing
import os
import sys


def _selftest() -> int:
    os.environ.setdefault("QT_QPA_PLATFORM", "offscreen")
    from PySide6 import QtWidgets

    from filmeas.app.gui import FilMeasureWindow

    app = QtWidgets.QApplication.instance() or QtWidgets.QApplication([])
    win = FilMeasureWindow()
    if win.recipe is not None:
        win._on_baseline(); app.processEvents()
        win._on_measure(); app.processEvents()
        print("SELFTEST OK:", win.result_lbl.text())
    else:
        print("SELFTEST OK (GUI constructed; no default recipe present)")
    return 0


if __name__ == "__main__":
    multiprocessing.freeze_support()
    if "--selftest" in sys.argv:
        raise SystemExit(_selftest())
    from filmeas.app.gui import main
    raise SystemExit(main())
