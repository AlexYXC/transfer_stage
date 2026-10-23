# pyfilmetrics

A clean-room, modern reimplementation of the **relevant** parts of Filmetrics **FILMeasure** — the
device-control, recipe/config, and thin-film measurement logic — reconstructed from the installed
software (see `../filmetric_re/` for the full reverse-engineering record).

Status: **P1 + P2 + P3 complete** (scientific core + device layer + GUI), plus hardware-validation tooling,
extra dispersion models, and a PyInstaller packaging. 57 tests pass.
Run the GUI: `python -m filmeas.app.gui`. The real-hardware backend is written but hardware-untested.

Extras:
- `validate_hardware.py` + `HARDWARE_VALIDATION.md` — safe, read-only-first checklist/script to verify the
  real device on the instrument PC (32-bit Python).
- `filmeas.optics.dispersion` — Constant, Cauchy, CauchyUrbach, Sellmeier, Lorentz, Tabulated models;
  built-in materials incl. BK7, fused-silica/SiO2, sapphire, Si (see `filmeas.io.material`).
- `filmeas.io.fibnk` — reads the `.fibnk` header; the n,k payload is vendor-encoded/protected and is NOT
  decoded (use CSV/models, or export from FILMeasure).
- `BUILD.md` / `app_main.py` — package a clickable `pyFILMeasure.exe` with PyInstaller.

## What works today (no instrument needed)
- **Recipes** (`.fitrp`/`.fitra`): parse, read the film stack + settings, edit, and **auto-refresh the
  checksum** FILMeasure validates on load. (`filmeas.io.recipe`)
- **Materials** (n,k): built-in Air/SiO2/Si, plus generic `wavelength,n,k` CSV; dispersion models
  (Constant, Cauchy, Tabulated). `.fibnk` binary decode is deferred. (`filmeas.io.material`, `filmeas.optics.dispersion`)
- **Spectra** (`.fmspe`): read FILMeasure's stored spectra; CSV read/write. (`filmeas.io.spectrum`)
- **Optics**: transfer-matrix reflectance `R(λ)` for an arbitrary stack (angle, TE/TM). (`filmeas.optics.tmm`)
- **Fit**: recover film thickness + GOF from a measured spectrum (grid seed + least-squares). (`filmeas.optics.fit`)

## Device layer (P2 — done)
- `filmeas.device.base` — `Instrument` interface, `RawAcquisition`, full `FMUSBIntErr` code map,
  `wavelengths_from_cal` (pixel→nm from FWCalOffset/Slope/Curv…).
- `filmeas.device.simulated` — `SimulatedInstrument`: physical signal model (lamp·R·gain + dark + noise),
  light on/off, integration time, saturation. Fully testable now.
- `filmeas.device.baseline` — `Baseline`: absolute reflectance `= (sample-bkg)/(ref-bkg)·R_reference`.
- `filmeas.device.fiusbint` — `FIUsbInstrument`: **real** binding to `FIUsbInt.dll` COM
  (`FIUsbInt.FIUsbController.1` / `.FIUsbSpectrometer.1`) via `comtypes`. Written to the recovered
  interface; **HARDWARE-UNTESTED** (needs 32-bit Python + the instrument).
- `filmeas.app.controller` — `MeasureController.take_baseline()` + `.measure(recipe)`; works with the
  simulator today and, unchanged, with the real instrument later.

Run `python demo_measure.py` for the end-to-end pipeline (simulated instrument → baseline → measure → fit).

## Not done yet
- **GUI (P3)**.
- Real-hardware validation of `fiusbint` (needs the instrument on a Windows PC, 32-bit Python).
- Exact parity with the proprietary `fmsolve.dll` fit (same physics, not bit-identical); exotic n/k models; `.fibnk` decode.

## Install
```
pip install numpy scipy matplotlib pytest
```

## Run the tests
```
python -m pytest
```
Validates: recipe parse/round-trip/checksum against all shipped recipes; `.fmspe` decode; TMM physics
(bare Si R≈0.35, interference fringes); and simulate→fit thickness recovery.

## Run the demo (prints results + writes demo_fit.png)
```
python demo.py
```
It loads the real `SiO2 on Si` recipe, simulates a measurement, fits the thickness back (should recover
9000 Å), edits the recipe with a valid checksum, and reads a real stored spectrum.

## Layout
```
filmeas/io       recipe / material / spectrum file formats
filmeas/optics   dispersion, transfer-matrix reflectance, thickness fit
filmeas/device   spectrometer interfaces (P2: simulated + FIUsbInt.dll COM)
filmeas/app      measure-pipeline controller + GUI (P3)
tests/           validation against on-disk FILMeasure reference data
```
