"""Entry point for the Tkinter (Windows-7-friendly) build of pyFILMeasure.

Normal launch opens the GUI. `--selftest` runs a headless measurement and exits (verifies the bundle).
"""
import multiprocessing
import sys


def _selftest() -> int:
    import tkinter as tk

    from filmeas.app.gui_tk import App
    root = tk.Tk(); root.withdraw()
    app = App(root)
    if app.recipe is not None:
        app._baseline(); app._measure()
        print("SELFTEST OK:", app.result.get())
    else:
        print("SELFTEST OK (GUI constructed; no default recipe present)")
    root.destroy()
    return 0


if __name__ == "__main__":
    multiprocessing.freeze_support()
    if "--selftest" in sys.argv:
        raise SystemExit(_selftest())
    from filmeas.app.gui_tk import main
    raise SystemExit(main())
