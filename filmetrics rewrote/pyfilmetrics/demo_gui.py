"""Render a screenshot of the GUI headlessly (no display needed) after running a simulated measurement.

Uses Qt's 'offscreen' platform so it works on a server. On a real desktop just run:
    python -m filmeas.app.gui
"""
import os

os.environ.setdefault("QT_QPA_PLATFORM", "offscreen")

from PySide6 import QtWidgets  # noqa: E402

from filmeas.app.gui import FilMeasureWindow  # noqa: E402

HERE = os.path.dirname(os.path.abspath(__file__))


def main():
    app = QtWidgets.QApplication.instance() or QtWidgets.QApplication([])
    win = FilMeasureWindow()
    win.resize(940, 620)
    win.show()
    app.processEvents()
    if win.recipe is not None:
        win._on_baseline()
        app.processEvents()
        win._on_measure()
        app.processEvents()
    png = os.path.join(HERE, "demo_gui.png")
    win.grab().save(png)
    print("saved", png)
    print("result:", win.result_lbl.text())


if __name__ == "__main__":
    main()
