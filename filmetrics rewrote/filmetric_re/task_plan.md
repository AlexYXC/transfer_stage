# Task Plan — Filmetrics FILMeasure (F24) Reverse Engineering

**Goal:** Reconstruct the FILMeasure program logic accurately enough for the owner (authorized) to
understand and modify the *device-control behavior* and the *control list / device-control configuration*
of Filmetrics hardware (F24 and related F20/F40/F70 family). NOT a byte-for-byte clone.

**Owner/authorization:** User owns the hardware and is authorized to analyze it. Legitimate
interoperability / modification work.

**Machine:** Windows 11 (target device historically Win7). Install root:
`C:\Program Files (x86)\Filmetrics\FILMeasure`. Python 3.14 available. No IDA/Ghidra/dumpbin/ILSpy yet.

---

## Stage status

| Stage | Description | Status |
|-------|-------------|--------|
| 1 | Triage & architecture | COMPLETE (batch 1) |
| 2 | Control-flow recovery (per function) | UNBLOCKED — ilspycmd works; FIRemote recovered; full-project decompile running |
| 3 | Device protocol reconstruction | API+transport MECHANISM done; byte-level pending native .sys RE / USB capture |
| 4 | Control-list / config reconstruction | DONE for recipe/config: .fitrp schema reconstructed (recipe_schema.md); checksum enforcement TBD |
| 5 | Clean-room reimplementation (Python first) | P1+P2+P3 DONE: io+optics+device+controller+PySide6 GUI, 49 tests green, GUI measures 9001A. Real-HW backend written (untested, needs instrument) |
| 6 | Validation (safe, read-only first) | plan drafted; must run on the Win7 machine w/ hardware |

### Post-rewrite polish (all requested) — DONE
- Hardware validation: HARDWARE_VALIDATION.md + validate_hardware.py (staged, read-only-first).
- .fibnk: header decoded; n,k payload is vendor-encrypted/protected -> decryptor DECLINED (out of scope). Legit alternatives provided.
- Dispersion models: +Sellmeier/Lorentz/CauchyUrbach; built-ins incl BK7/silica/sapphire. 57 tests green.
- Packaging: PyInstaller onedir -> dist/pyFILMeasure/pyFILMeasure.exe (17MB exe, 252MB folder).
  Frozen exe `--selftest` = "Thickness 9001 A, GOF 0.9438", exit 0. Real-HW needs a 32-bit rebuild.

### Tooling ready
- Decompiler: ilspycmd 11 (net10) at scratchpad/ilspycmd; runs on the .NET 10.0.9 runtime.
  Single type: `dotnet ilspycmd.dll -t <FullTypeName> "<FILMeasure.exe>"`.
  Full project decompile running → analysis/decompiled/FILMeasure_project/ (task bfd66aync).

### Batch-1 outcome
Architecture fully mapped from vendor source + managed metadata + native COM server + INF (no guessing needed
for the layering). Highest remaining uncertainty = the byte-level USB/I2C protocol inside FIUsb2FSrs.sys /
FIUsbInt.dll, and the exact identity of the "F24" (no such PID in the 2014 INF).

---

## Key strategic pivot (vs. the generic RE plan)

This is NOT a blind native-binary RE job. Three force-multipliers were found:

1. **Main app is .NET managed** (`FILMeasure.exe`) → decompiles to near-original C#. Need a .NET
   decompiler (ILSpy/dnSpy/dotnet-ildasm). This is the single highest-leverage next step.
2. **Vendor-shipped SOURCE CODE** for the remote-control API exists on disk under
   `.\SourceCode\` and `.\InstRpr\SourceCode\` (C++, VB.NET, C#, Python + a PDF manual).
   The `FIRemote` automation surface is effectively documented already.
3. **Config/text files** are human-readable (sensorConfig.txt register map, recipe/precision files).

So: the automation/"control list" can be recovered largely from provided source + type library,
and only the low-level USB spectrometer protocol needs true RE (native FIImage.dll / an FMUSB layer).

---

## Phase breakdown (living)

- [x] 1a. Inventory install tree (done — see findings.md)
- [x] 1b. PE triage of all EXE/DLL (arch, managed vs native) (done)
- [ ] 1c. Recover full FIRemote automation API from FIRemoteCOM_h.h + .tlb + example clients
- [ ] 1d. Obtain a .NET decompiler; decompile FILMeasure.exe + FIRemoteCOM.dll
- [ ] 1e. Parse native import tables of FIImage.dll, FMSolve.dll (find the USB/driver APIs)
- [ ] 1f. Identify the FMUSB transport DLL (who implements IFMusbEnum / the read-spectrum calls)
- [ ] 2..6 per user's staged spec

## Decisions / open questions for the user
- What does "control list" mean to you specifically? Candidates: (a) the device register/parameter
  set (e.g., sensorConfig.txt camera regs), (b) the FIRemote automation command set, (c) the
  measurement recipe/"controls" in the GUI. (Tracking all three until clarified.)
