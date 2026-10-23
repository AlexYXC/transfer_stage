# pyfilmetrics P1 (io + optics core) Implementation Plan

> **For Claude:** execute task-by-task, TDD. No git repo → "Checkpoint" = run the full test suite green.

**Goal:** Build the hardware-free scientific core: read recipes/materials/spectra, model reflectance with
the transfer-matrix method, and fit measured spectra to film thickness (+GOF) — validated against the
on-disk reference data.

**Architecture:** Layered package `filmeas/` (io → optics), pure Python + numpy/scipy. Device/GUI are P2/P3.

**Tech Stack:** Python 3.14, numpy, scipy, pytest.

Project root: `C:\Users\Owner\proposal writing\pyfilmetrics\`
Reference data (read-only): `C:\ProgramData\Filmetrics\FILMeasure\` and `C:\ProgramData\Filmetrics\Precision\`

---

### Task 0: Environment + package skeleton
**Files:** create `pyfilmetrics/pyproject.toml`, `pyfilmetrics/filmeas/__init__.py`, `pyfilmetrics/tests/__init__.py`
- Step 1: `pip install numpy scipy pytest`
- Step 2: create package dirs `filmeas/{io,optics,device,app}`, `tests/`
- Step 3: minimal `__init__.py` files
- Checkpoint: `python -c "import filmeas"` succeeds; `pytest -q` runs (0 tests).

### Task 1: Recipe I/O + checksum  (port verified logic)
**Files:** create `filmeas/io/recipe.py`, `tests/test_recipe.py`
- Behavior: `load(path)->Recipe`, `Recipe.dumps()->str`, `save(path)`; parse header + sections +
  `[Layers]` (Medium/Layer*/Substrate: material, thickness_A, roughness_A, solve flags d/n/k/r) +
  `[Acqusition Settings]`; recompute checksum on write (utf-16-le byte sum, strip space/tab if ver>=5, keep CRLF).
- Tests: (a) load `SiO2 on Si.fitrp`, assert Name, Num Location, 3 layers, Layer1 material=SiO2, thick=9000,
  solve-d flag True; (b) round-trip: load→dumps→re-parse equal; (c) checksum of dumps matches recomputed and
  the tool's algorithm; (d) edit thickness→save→`recipe_checksum.py verify`=OK.
- Reuse the verified checksum from `filmetric_re/tools/recipe_checksum.py`.
- Checkpoint: tests pass.

### Task 2: Materials (n,k)
**Files:** create `filmeas/io/material.py`, `filmeas/optics/dispersion.py`, `tests/test_material.py`
- `.rrr` reader (CSV `Wavelength(nm),R` — note: .rrr is reflectance-vs-λ, used for some refs) AND a
  generic n,k CSV reader (`wavelength_nm,n,k`).
- Dispersion models: `Tabulated(n,k interp over λ)`, `Cauchy(A,B,C)`, `Constant(n,k)`; common interface
  `nk(wavelength_nm) -> complex`.
- `.fibnk` binary: decode header (int32 magic/model/count...) best-effort; if not decoded, fall back to
  `fmsolve.dll ReadFIBNKFile3` via ctypes OR document as deferred. (Stretch — do not block Task 5/6.)
- Tests: Cauchy returns expected n at 632.8nm; Tabulated interpolates; CSV round-trip.
- Checkpoint: tests pass.

### Task 3: Spectrum I/O (.fmspe)
**Files:** create `filmeas/io/spectrum.py`, `tests/test_spectrum.py`
- First DECODE `.fmspe` (inspect `C:\ProgramData\Filmetrics\Precision\Si_F20.fmspe`): determine text/binary,
  columns (λ, raw/reflectance, maybe reference/background). Implement `load(path)->Spectrum(wavelength_nm, value, kind)`.
- Also generic CSV load/save.
- Tests: load a real `.fmspe`, assert monotonic wavelengths, plausible reflectance range [0..~1] or counts.
- Checkpoint: tests pass.

### Task 4: Transfer-matrix reflectance (TMM)
**Files:** create `filmeas/optics/tmm.py`, `tests/test_tmm.py`
- `reflectance(wavelength_nm, layers, angle_deg=0, pol='TE') -> R` where layers = [ambient, films..., substrate],
  each with nk(λ) and thickness (nm; ambient/substrate semi-infinite). Characteristic-matrix method; complex nk.
- Optional roughness later (skip for P1 unless trivial).
- Tests: (a) bare Si in air at normal incidence → R≈0.35 near 600nm (matches SiO2.rrr's substrate-ish values /
  literature n_Si≈3.9 → R=((3.9-1)/(3.9+1))^2≈0.35); (b) single SiO2 film on Si shows interference fringes
  vs wavelength; (c) zero-thickness film == bare substrate.
- Checkpoint: tests pass.

### Task 5: Fit (thickness from R) + GOF
**Files:** create `filmeas/optics/fit.py`, `tests/test_fit.py`
- `fit_thickness(measured_R(λ), stack, materials, bounds, init) -> {thickness, gof, modeled_R}`.
  scipy.optimize.least_squares (LM/TRF). GOF metric = 1 - sqrt(sum((meas-model)^2)/sum((meas-mean)^2)) or the
  standard Filmetrics GOF (document choice). Grid-search initial thickness; optional FFT init.
- Tests: (a) simulate R for SiO2 9000Å on Si via tmm, add small noise → fit recovers 9000Å within ~1%; (b) GOF≈1
  for noiseless; (c) recovers over a thickness sweep.
- Checkpoint: tests pass.

### Task 6: Integration validation vs FILMeasure reference data
**Files:** create `tests/test_integration_reference.py`
- Load a real stored spectrum (Precision `Si_*.fmspe`) or a measured `.fmspe`, its recipe, materials →
  run full model+fit → assert thickness/GOF within tolerance of the recipe's nominal/known value.
- If exact materials/models unavailable, assert internal consistency (simulate→fit round-trip) and document gap.
- Checkpoint: full `pytest -q` green; write a short `pyfilmetrics/README.md` with how to run tests + a demo script.

---

## P2 (device) and P3 (gui) — outline (detailed after P1 green)
- P2: `device/base.py` (interfaces from recovered IFIUsb* API), `device/simulated.py` (recipe→synthetic R),
  `device/fiusbint.py` (comtypes → FIUsbInt.dll COM), `device/baseline.py`. Tests: simulator + interface shape.
- P3: `app/controller.py` (measure pipeline), `app/gui` (PySide6): load/measure, pick recipe, plot meas+model, thickness+GOF.
