# Reconstructed Schema — FILMeasure Recipe / Control-List files (.fitrp / .fitra)

**Confidence: HIGH** (format is plain text and self-describing; read directly from real files).
Source example: `C:\ProgramData\Filmetrics\FILMeasure\Recipes\SiO2 on Si.fitrp`.

## File format
- **Plain UTF-8/ASCII text, CRLF line endings.** Comma-separated `Key, Value` lines; `[Section]` headers;
  and `===== Measure Site N =====` blocks (one per measurement location).
- Extensions: `.fitrp` = thickness/precision recipe (version 12 seen); `.fitra` = analysis/AR recipe (version 10).
  `.fiprc` = precision config; `.fmspe` = stored spectrum; `.rrr`/`.fibnk`/`.fibnx` = materials.
- First line: `***Machine Readable Structure Export Version (Copy all lines), <schemaVersion>`
- Last two lines: `***End Machine Readable Structure***` then `CHECKSUM= <int>`.
- **CHECKSUM** (CONFIRMED, verified 8/8 recipes; algorithm from decompiled `hg.bu(string,int)` in hg.cs:2335):
  it **IS validated on load** (hg.cs ~2322 rejects a mismatched file). Algorithm:
  `content = file text up to (excluding) "CHECKSUM="` (this INCLUDES the `***End Machine Readable Structure***\r\n`
  line); if schemaVersion >= 5, remove all spaces and tabs (keep CRLF); then `checksum = sum(content.encode('utf-16-le'))`
  (for ASCII text this equals the plain sum of each non-space/non-tab byte, CRLF included).
  → After hand-editing, refresh it with `tools/recipe_checksum.py fix <file>` (tested; makes a .bak).
  Value is written as `CHECKSUM= <n>` (leading space is VB `Conversion.Str`, not part of the sum).
- `StartupRecipe.txt` / `StartupRecipeAR.txt` contain just the recipe *name* to auto-load at launch.

## Top-level (header) fields
| Key | Meaning | Example |
|-----|---------|---------|
| Name | recipe name | "SiO2 on Si" |
| GUID | recipe unique id | 75ac132f-... |
| UserID | author | "" / "Filmetrics, Inc." |
| Mod. Date(...) | modified date + OLE serial | 42821.7232... |
| Num Location | # measure sites | 1 |
| UnitsMode(A/nm/um) | thickness display units (1=Å,2=nm,3=µm) | 1 |
| CustomUnitName/Abbr/NanometersPerCustomUnit | custom thickness unit | Custom/Cstm/1 |

## Per Measure-Site block  (`===== Measure Site N =====` … `======End of measure site N ======`)
### [Layers]  ← THE FILM STACK (core control list)
```
Number of Layers, N
Layer ID   "Material"  "Thick.(A)" "Rough.(A)"  d  n  k  r
  Medium ,  "Air"    ,   0   , 0 , , , ,       # ambient
 Layer 1 ,  "SiO2"   , 9000  , 0 , X, , ,      # X in 'd' col = SOLVE this thickness
Substrate, "Si"      ,   0   , 0 , , , ,       # substrate
```
- Columns after material: Thick(Å), Rough(Å), then flags **d n k r** = "solve-for" markers
  (`X` = float this parameter during the fit). Add/replace layers here to change the stack.
### [Correlative Coefficients]  A, B, min/max thickness, Active — post-fit linear calibration of thickness.
### [Constraints]  per-layer Thick(%) / N / K allowed variation; Account for nonplanarity/nonuniformity; Lock identical layers.
### [Options]  solver config:
Reflectance/Transmittance/Simultaneous flags; Angle; TE Polarization; grid vs Fourier initial-thickness search;
Back Reflectance; **SolverGOFTarget (.999)**; **Max Iterations (400)**; per-layer n/k **models**
("Cauchy", "Bridge Lorentzian-3Term", …); n&k display wavelength (632.8); **Fixed Range? + Range From/To (200..2000 nm)**.
### [Alarms]  per-layer Nominal/Min/Max thickness pass-fail limits; Spot Size; NA correction.
### [Site Z-Stage]  motorized Z: Max wafer thickness/height variation; ForceSetZ; SetZ at fixed wavelength (1200nm); peaks required; CTM lens report.
### Other site sections: [SiteMapParams], [Additional Options] (# potential spectra, R1/T1 options),
[Regional Spectral Analysis], [SUV Weighting], [Region Spectral Analysis - Addon], [FFT Window],
[Layer Parameters V2] (grading/nonuniformity per layer), [Site Average Reflectance], [Color Alarm], [LayerReps].

## Global sections (after the site blocks)
### [Acqusition Settings]  ← DEVICE-CONTROL SETTINGS (what to modify to change acquisition)
| Key | Meaning |
|-----|---------|
| Number of Smoothing Points | spectral smoothing |
| Measurement Timing | 0=Recommended,1=Maximum,2=Manual (→ MeasurementTimingModes) |
| Spectrometer Type | 0=All / short / long / extended (→ SpectrometerTypes) |
| Maximum Integration Time | ms cap |
| Fixed Integration Time (short/long wavelengths) | ms per spectrometer |
| Fixed Integration Cycles (short/long wavelengths) | averaging cycles |
| Peak Value (short/long) | target signal peak for auto-scale |
| <Reference Material1>, <ReferenceMaterialKnown1> | baseline reference (e.g. "Si", known=True) |
| Smoothing Thickness um / Graph limits start,end / Measure delay / Stored baseline name | misc |
- `[Acquisition2 Settings]` / `[Acquisition3 Settings]` = alternate acquisition presets; Dual-meas config;
  `<Reference Material2>` etc.
### [Optics Configuration]  Microscope name, System GUID, Use-with-any-system, Optics Configuration (enum),
last meas-type flags, Objective Exists. (Ties recipe to a specific system GUID unless "Use With Any System".)
### [CTM Optics Configuration], [Backside Subtraction] (substrate material, ignore-baseline),
[AutoFocus Settings]/[AutoFocus2 Settings] (Z offsets, edge find, map origin),
[SpectrometervsTime Acq. Settings] (monitor-mode wavelengths list), [Z Optics] (ZOpticsType, GUID),
Reflective Objective focus range/step, Map Origin Offset.

## Editing workflow (for Stage 6 validation — do on a COPY, offline)
1. Copy a recipe, edit the text (e.g., change Layer 1 thickness or add a layer), keep exact section/column layout.
2. **Checksum** (SOLVED): FILMeasure rejects a stale checksum on load, so after editing run
   `python tools/recipe_checksum.py fix "<yourRecipe>.fitrp"` to regenerate it (verified round-trip).
   `... verify <file>` just checks. Confirm the edited recipe opens in the GUI before any hardware use.
3. Safer than editing bytes: use the **FIRemote API** (SetRecipe / SetThickness / SetMaterial / SetN /
   SetRoughness / SetAnalysisWavelengthRange / IntegrationTime_ms / IntegrationCycles) to change controls at
   runtime without touching files.
