# Design — pyfilmetrics (clean-room reimplementation of FILMeasure's device-control + measurement core)

Date: 2026-09-03
Status: APPROVED (user approved 2026-09-03)
Related RE artifacts: ../../findings.md, ../../recipe_schema.md, ../../symbol_table.md,
../../analysis/decompiled/FILMeasure_project/

## Goal
A modern, layered, clean-room reimplementation of the *relevant* FILMeasure behavior: read/write
recipes & materials, model + fit reflectance spectra to film thickness (with GOF), control the
spectrometer, and present a GUI. NOT a byte-for-byte clone of every FILMeasure feature (no wafer
mapping / Excel export / color / licensing unless later requested).

## Hard constraint
**No hardware available now.** Everything that does not touch the instrument is built and validated
now against on-disk reference data. The device layer is written against the recovered COM interface
(`FIUsbInt.dll`) but cannot be hardware-validated until the user has the F24 on a Windows PC.

## Key decision: device I/O = reuse the vendor's native COM component
The USB byte-level protocol lives inside `FIUsbInt.dll` (native ATL COM) + kernel driver and was NOT
recovered (would need a USB capture / driver RE on real hardware). Rather than block the whole project,
the device layer calls the already-installed, registered `FIUsbInt.dll` COM objects
(`FIUsbInt.FIUsbSpectrometer.1`, `.FIUsbController.1`, `.FMusbEnum.1`) via `comtypes`. This yields real
hardware control the moment hardware is present, with a `SimulatedSpectrometer` standing in until then.
(Alternative considered: pure clean-room USB driver — rejected for now, blocked without the wire protocol.)

## Architecture (layers)
```
filmeas/
├─ io/
│   ├─ recipe.py     parse/write .fitrp/.fitra (text) + checksum (recovered, verified)   [DONE logic]
│   ├─ material.py   n,k: .rrr (CSV), user CSV, dispersion models (Cauchy...), .fibnk (binary, stretch / fmsolve reuse)
│   └─ spectrum.py   .fmspe read/write + generic CSV
├─ optics/
│   ├─ dispersion.py tabulated n,k interpolation + Cauchy/Sellmeier/etc.
│   ├─ tmm.py        transfer-matrix reflectance R(λ) for a stack; angle; TE/TM; roughness (EMA/DW)
│   └─ fit.py        nonlinear LSQ (scipy least_squares/LM) → thickness (+optional n,k); GOF; grid/FFT init
├─ device/
│   ├─ base.py       abstract Spectrometer/Controller/LightSource interfaces (from recovered IFIUsb* API)
│   ├─ simulated.py  synth spectra from a recipe + noise (testable now)
│   ├─ fiusbint.py   comtypes binding to FIUsbInt.dll COM (real hardware; untestable now)
│   └─ baseline.py   reference/background/baseline math (R = (raw-bkg)/(ref-bkg) * Rref)
├─ app/
│   ├─ controller.py measure pipeline (mirrors FIRemote.Measure): device→spectrum→baseline→fit→result
│   └─ gui/          PySide6 desktop: load/measure spectrum, pick recipe, plot measured+modeled, thickness+GOF, edit recipe
└─ tests/            validate vs on-disk .fmspe/.fibnk/recipes; simulate→fit→recover known thickness
```

## Data flow (Measure)
recipe + baseline(ref,bkg) → device.get_spectrum() → R(λ) → optics.fit(R, stack, materials) →
{thickness per layer, GOF, modeled R} → GUI/save.

## Validation (no hardware)
- io: recipe round-trip (checksum tool already verified 8/8); parse materials/spectra.
- optics (the crux): stored spectrum (e.g. Precision\Si_*.fmspe) + its recipe + materials → fit →
  compare thickness/GOF to FILMeasure's known/nominal values; tolerance-based test.
- simulated device: generate at known thickness → fit recovers it within tolerance.
- device/fiusbint: import + interface-shape tests only; hardware test deferred to Win7.

## Tech
Python 3.14 (present). Deps (pip): numpy, scipy, PySide6, comtypes, pytest. matplotlib or Qt charts for plots.

## Delivery phases
- P1 (now): io + optics + tests. The scientific heart; fully testable.
- P2: device (base + simulated + fiusbint) + baseline.
- P3: app controller + GUI.

## Honest caveats
- Fit won't be bit-identical to proprietary fmsolve.dll; same physics (TMM+LM), expected close.
  Exotic models (Bridge Lorentzian-3Term substrate, HC correction, backside) implemented incrementally
  or delegated to fmsolve.dll.
- .fibnk binary decode is a stretch; interim = .rrr/CSV + models, or fmsolve.dll ReadFIBNKFile3 reuse.
- device layer correctness is unverifiable until hardware is available.
```
