# Running pyfilmetrics on Windows 7

## Why not just copy the .exe?
The `dist\pyFILMeasure\` build was made with **Python 3.14 + Qt6 (PySide6)**, and **both require Windows 10+**.
It will not launch on Windows 7. So instead of shipping that 252 MB folder, this package ships the **source**
(a few hundred KB) plus a **Tkinter GUI** that runs on older Python/Windows. You install a Win7-compatible
Python once, then run it.

## One-time setup on the Win7 machine
1. **Install Python 3.8.10** (the last Python with official Windows 7 support), from python.org.
   - Choose **32-bit** if you will connect the real instrument (the `FIUsbInt.dll` COM server is 32-bit).
   - 64-bit is fine if you only want the **simulator**.
   - Tick "Add Python to PATH" during install.
2. Unzip this package somewhere, e.g. `C:\pyfilmetrics\`.
3. Open **Command Prompt** in that folder and install the dependencies:
   ```
   python -m pip install -r requirements-win7.txt
   ```
   (This installs numpy/scipy/matplotlib pinned to Win7-compatible versions. It does NOT install PySide6.)

## Run the app (Tkinter GUI — simulator works with no hardware)
```
python -m filmeas.app.gui_tk
```
Load a recipe → **Take Baseline** → **Measure**. You'll see the measured vs. fitted spectrum and the
thickness + GOF.

## Connect the real instrument
1. Use **32-bit Python 3.8** and also install comtypes (it's already in requirements-win7.txt).
2. Make sure the FILMeasure driver is installed and the unit is connected (see HARDWARE_VALIDATION.md).
3. **Validate first (read-only):**
   ```
   python validate_hardware.py
   ```
   then, when those pass, `--lamp`, `--acquire`, and `--measure <recipe>` as described in HARDWARE_VALIDATION.md.
4. To use the real device from the GUI, we wire the GUI's backend to `FIUsbInstrument` — tell me once the
   read-only validation passes and I'll flip that switch (it's a small change; kept off until the COM
   marshaling is confirmed on your hardware).

## Optional: make a clickable .exe ON the Win7 machine
```
python -m pip install pyinstaller
python -m PyInstaller --noconfirm --windowed --name pyFILMeasure --collect-data matplotlib app_main_tk.py
```
Result: `dist\pyFILMeasure\pyFILMeasure.exe` (built with Win7's Python, so it runs on Win7).

## What's in this package
- `filmeas/` — the library (io / optics / device / app)
- `filmeas/app/gui_tk.py` — the Win7 Tkinter GUI;  `gui.py` — the Qt6 GUI (Win10+ only)
- `validate_hardware.py`, `HARDWARE_VALIDATION.md` — device bring-up
- `tools/recipe_checksum.py` — edit recipes and refresh their checksum
- `tests/`, `demo*.py`, `requirements-win7.txt`, `README.md`, `BUILD.md`
