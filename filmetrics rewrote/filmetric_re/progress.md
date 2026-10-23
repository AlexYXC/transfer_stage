# Progress Log — FILMeasure RE

## Session 2026-09-03

- Set up planning-with-files tracking (task_plan / findings / progress / symbol_table / constants_strings / xrefs).
- Enumerated full install tree (468 entries) → saved reasoning in findings.md.
- Ran custom Python PE-header triage (`scratchpad/pe_triage.py`) over 14 binaries → arch + managed/native table.
- Read `sensorConfig.txt` (MT9M001 camera register map).
- Read `SourceCode\FIRemotePureCpp\...\FIRemoteCOM.h` (COM IIDs/CLSID + IFMusbEnum enum interface).
- Read `SourceCode\Python\pythonnetex.py` (FIRemote automation usage).

### Tooling status
- Python 3.14: available.
- Missing: dumpbin, strings, ILSpy/dnSpy, Ghidra, IDA. (Plan: build PE/import/.NET metadata parsing in Python;
  seek a .NET decompiler — check dotnet SDK / pip availability.)

### Errors Encountered
| Error | Attempt | Resolution |
|-------|---------|------------|
| (none yet) | | |

### Next actions (superseded — see below)
1. Read FIRemoteCOM_h.h (full automation interface) + C++/C# readmes.
2. Check for dotnet SDK / pip / internet to obtain a .NET decompiler.
3. Parse native import tables (FIImage.dll, FMSolve.dll).

## Session 2026-09-03 (cont.) — Batch 1 completion
- Extracted managed metadata via dnfile (meta_extract2.py): 1087 types, 206 P/Invoke, 295 enums, 12325 #US strings.
  Outputs in analysis/: FILMeasure.exe.{pinvoke,types,enums,device_members,userstrings}.txt
- Recovered full Filmetrics.FIRemote automation API (306 members) + FIUsbIntLib COM device interfaces
  (IFIUsbSpectrometer 240, IFIUsbController 125, IFIUsbPdLed 36, IUVSource 20, IFMusbEnum 7).
- Native analysis (native_analyze.py): FIUsbInt.dll imports=WinUSB+SetupAPI+DeviceIoControl → transport identified.
  Outputs: analysis/{FIUsbInt.dll,FIImage.dll,FMSolve.dll}.{native,strings}.txt
- Located FIUsbInt.dll @ C:\Windows\SysWOW64; runtime data @ C:\ProgramData\Filmetrics\FILMeasure(+Precision).
- Parsed C:\Windows\INF\oem360.inf → VID_116D, FMUSBCON class, driver .sys names, full PID→model table.
- Determined: NO hardware attached to this Win11 box; this is an analysis machine (real F24 on the Win7 box).

### Errors Encountered
| Error | Attempt | Resolution |
|-------|---------|------------|
| PowerShell Get-ChildItem C:\ -Recurse timed out (decompiler search) | 1 | Abandoned drive-wide scan; used targeted -Path lists |
| PowerShell registry+recurse combo timed out (2 min) | 1 | Split into targeted queries; got FIUsbInt.dll via SysWOW64 hit before timeout |
| dnfile method/field owner mapping empty (v1) | 1 | Root cause: MethodList/FieldList are lists of MDTableIndex; rewrote (meta_extract2.py) |
| Python 3.14 regex bad-escape on backslash patterns | 1 | Switched to substring matching for path patterns |

## Session 2026-09-03 (cont.) — Batch 2 progress
- Read full FILMeasure.exe.config → Stage-4 device defaults captured in findings.md.
- Confirmed .NET runtimes 8.0.11 + 10.0.9 present (no SDK). Fetched ilspycmd 11 (net10) from nuget.org
  (4.86 MB nupkg) → scratchpad/ilspycmd; verified it runs on the 10.0.9 runtime.
- Decompiled Filmetrics.FIRemote → analysis/decompiled/FIRemote.cs (4848 lines). Recovered facade/async-engine pattern.
- Characterized recipe files: .fitrp/.fitra are PLAIN TEXT; reconstructed full schema → recipe_schema.md.
- Attempted CHECKSUM crack: not a contiguous byte-sum; deferred to decompiled loader analysis.
- Started full-assembly decompile to analysis/decompiled/FILMeasure_project/ (background task bfd66aync).

### Errors Encountered (cont.)
| Error | Attempt | Resolution |
|-------|---------|------------|
| ilspycmd 11 only ships net10.0 TFM | 1 | OK — 10.0.9 runtime present; runs fine |
| Recipe CHECKSUM not a simple sum | 1 | SOLVED: full decompile → hg.bu (hg.cs:2335). utf-16-le byte sum, spaces/tabs stripped (v>=5), CRLF kept. Enforced on load (hg.cs:2322). Verified 8/8. Tool: tools/recipe_checksum.py |
| Python text-mode dropped \r in checksum calc | 1 | Read files as bytes (preserve CRLF) → 8/8 match |

### Batch 2 outcome
- Full assembly decompiled → analysis/decompiled/FILMeasure_project/ (469 .cs files). Recipe engine = hg.cs.
- Stage 4 COMPLETE for recipes/config: schema (recipe_schema.md) + working checksum tool (tools/recipe_checksum.py).
- Remaining hard blockers unchanged (byte-level USB protocol + F24 identity) → need Win7 hardware / native .sys RE.

## Session 2026-09-03 (cont.) — Rewrite P1 (pyfilmetrics)
- Brainstormed + approved design (docs/plans/2026-09-03-pyfilmetrics-design.md); wrote P1 plan.
- Built pyfilmetrics/ (Python): io.recipe (parse/edit/checksum), io.material + optics.dispersion,
  io.spectrum (.fmspe decoder — int32[2]=data offset, double (wl,val) pairs), optics.tmm (transfer matrix),
  optics.fit (grid+least_squares thickness + GOF).
- Decoded .fmspe format (was unknown): .NET BinaryWriter serialized; header int32[2]=offset to (wl,value) double array.
- 35 pytest tests pass (recipe checksum vs all shipped recipes, .fmspe ingest, TMM physics bare-Si R~0.35,
  simulate->fit recovers thickness). demo.py fits SiO2/Si to 9000A, GOF~0.96, writes demo_fit.png.
- Deps installed: numpy scipy matplotlib pytest. pytest basetemp set to .pytmp (perm issue on %TEMP%).
- Deferred: .fibnk binary decode (using built-in Air/SiO2/Si + CSV for now); device layer + GUI = P2/P3.

## Session 2026-09-04 — Rewrite P2 (device layer)
- Grounded device interface on decompiled FIUsbIntLib/IFIUsbSpectrometer.cs + IFIUsbController.cs + FMUSBIntErr.cs.
- Built filmeas/device: base (Instrument ABC, RawAcquisition, FMUSB error map, wavelengths_from_cal),
  simulated (SimulatedInstrument: lamp*R*gain+dark+noise model), baseline (R=(s-bkg)/(ref-bkg)*Rref),
  fiusbint (comtypes binding to FIUsbInt.dll COM — HARDWARE-UNTESTED, faithful to recovered iface),
  app/controller (MeasureController: take_baseline + measure(recipe)->fit).
- Tests: +12 (device sim, baseline recovers true R within 0.01, end-to-end sim measure recovers 9000A, fiusbint import). Total 47 green.
- demo_measure.py: sim instrument -> baseline -> measure -> 9001 A, GOF 0.94, writes demo_measure.png.
- Key recovered facts used: SetIntegrationTime/GetSpectraSafe/GetSpectraStart-Status-Finish; wavelength=FWCalOffset+Slope*pix+Curv*pix^2(+3rd/4th); Controller.SetLightSourcePowerOnState/SetLampSetpoint/Connect; FMUSBIntErr codes.

## Session 2026-09-04 — Rewrite P3 (GUI)
- Built filmeas/app/gui.py (PySide6): recipe load, integration/averages controls, Take Baseline + Measure,
  live measured-vs-fitted matplotlib plot with thickness+GOF title, Simulated/Real(FIUsbInt) backend selector.
- Installed PySide6 (Py3.14 wheel OK). Headless render via QT_QPA_PLATFORM=offscreen + widget.grab().
- Added demo_gui.py (screenshot) + test_gui.py (offscreen smoke: construct, baseline, measure -> ~9000A). 49 tests green.
- Screenshot: GUI measures SiO2/Si -> 9001 A, GOF 0.94 (Qt chrome text boxes = headless font artifact only; plot fine).
- ALL THREE rewrite phases (P1 io+optics, P2 device, P3 gui) complete. Remaining: real-hardware validation
  of fiusbint (needs instrument + 32-bit Python), .fibnk decode, exotic n/k models, packaging.

## Session 2026-09-04 — Post-rewrite polish (hardware checklist / .fibnk / models / exe)
- HARDWARE_VALIDATION.md + validate_hardware.py: staged read-only-first device validation (env->enumerate->
  identity->lamp->acquire->measure), lists dangerous write/calibrate methods to avoid. Stage 0 smoke-tested.
- .fibnk: decoded plaintext HEADER only (version, model_type, num_points=(int32[4]>>16)). Payload is
  ENCODED/PROTECTED (28.5 B/pt, no float table, garbage strings; FIMatFileSecurityService.RequestDecryptKey
  in assembly). DECLINED to build a decryptor (circumventing vendor content protection on proprietary
  material DB — out of scope). filmeas/io/fibnk.py = header reader + FibnkProtectedError + legit alternatives.
- More n/k models: Sellmeier, Lorentz, CauchyUrbach added; built-ins BK7/fused-silica/sapphire/Si3N4/TiO2/
  water/PMMA (published Sellmeier/Cauchy, not proprietary). Verified BK7 nd=1.5168, silica=1.4585.
- Packaging: app_main.py (+ --selftest) + BUILD.md; PyInstaller onedir build of pyFILMeasure.exe (in progress).
- Tests now 57 green.

## Session 2026-09-12 — Win7 offline bundle
- Win7 can't run the Py3.14/Qt6 exe (need Win10+). Built a Win7-native bundle instead:
  private 32-bit Python 3.8.10 (+tkinter) installed to %LOCALAPPDATA%\py38x86; deps numpy 1.24.4 /
  scipy 1.9.1 (newest with cp38 win32 wheel) / matplotlib 3.7.5; PyInstaller 5.13.2 (last w/ Win7 support).
- Added filmeas/app/gui_tk.py (Tkinter GUI, no Qt) + app_main_tk.py (--selftest). PyInstaller onedir ->
  dist/pyFILMeasure-win7/ (168 MB). Frozen 32-bit exe --selftest = 9001 A, GOF 0.94, exit 0.
- Bundled sample_recipes + 先看我-README.txt. Zipped -> proposal writing/pyFILMeasure-win7-offline.zip (63 MB).
- Caveat: app-local UCRT not bundled (no SDK redist on build box); Win7 running FILMeasure already has UCRT;
  documented KB2999226 fallback. 32-bit build is hardware-ready (FIUsbInt.dll is x86); real backend still gated.

### Next actions (Batch 2/3 candidates)
1. Obtain a .NET decompiler (ICSharpCode.Decompiler via pythonnet, or ilspy) → real C# bodies for FIRemote +
   the managed FIUsbIntLib wrappers → Stage 2 control-flow + how AcquireSpectrum flows to COM.
2. Decode the recipe format: read a .fitrp as bytes + find the managed (de)serializer / fmparerf.dll ParseERFwT.
3. Decode/annotate the enum-heavy config: dump FILMeasure.exe.config + FIRemoteCOM.tlb (oleview-style).
4. Native RE of FIUsbInt.dll GetSpectraStart/SetIntegrationTime (needs Ghidra-class tool) OR USB capture on Win7.
5. On the Win7 machine: identify the actual unit's VID/PID + FWInstTypeCode (resolve "F24").
