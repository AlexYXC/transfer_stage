# Building the clickable pyFILMeasure app

The GUI can be packaged into a standalone Windows app with **PyInstaller** so you just double-click it —
no Python needed on the target machine.

## Build (from the project root)
```
pip install pyinstaller
python -m PyInstaller --noconfirm --windowed --name pyFILMeasure \
    --collect-data matplotlib --collect-submodules scipy.optimize app_main.py
```
Output: `dist/pyFILMeasure/pyFILMeasure.exe` (a folder you can zip and copy). Double-click the exe to run.

- Prefer this **onedir** build (a folder) — it's the most reliable for Qt/scipy.
- For a single file instead, add `--onefile` (bigger, slower first start, occasionally flakier).
- Keep `--windowed` for no console window; drop it while debugging so errors print.

## Verify the packaged app (no display needed)
```
dist\pyFILMeasure\pyFILMeasure.exe --selftest
```
Prints `SELFTEST OK: Thickness: 9001 A   GOF: 0.94…` if the bundle is healthy (runs the simulated
baseline+measure+fit and exits).

## Using it with real hardware
The exe includes the real-hardware backend, but note the constraint from the device layer:
`FIUsbInt.dll` is **32-bit**, so to talk to the instrument the app must be built with **32-bit Python**
(install 32-bit Python + the deps, then run the same PyInstaller command there). The 64-bit build runs the
**simulator** fine but cannot open the COM device. Validate hardware first with `validate_hardware.py`
(see HARDWARE_VALIDATION.md).

## Optional niceties
- Icon: add `--icon path\to\app.ico`.
- Version/name: change `--name`.
- Bundle default recipes/materials next to the exe, or point the app at `C:\ProgramData\Filmetrics\...`
  which it already reads by default.
