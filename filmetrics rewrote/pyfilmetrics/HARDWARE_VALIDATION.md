# Hardware Validation Checklist — pyfilmetrics device layer (FIUsbInt.dll)

Goal: confirm the real-hardware backend (`filmeas.device.fiusbint.FIUsbInstrument`) actually drives your
instrument, **starting with read-only checks** and only later doing (reversible) acquisition. Runs on the
PC that has the instrument (historically the Win7 box). Nothing here writes firmware, calibration, or EEPROM.

Run the companion script `validate_hardware.py` — it performs each stage and gates the physical actions
behind flags so you opt in explicitly.

## Prerequisites
- [ ] Instrument connected via USB and its driver installed (setup class **FMUSBCON**, **VID_116D**;
      drivers `FILdUSB2.sys`/`FIUsb2FSrs.sys`). Confirm it appears under
      "Filmetrics Measurement Instruments" in Device Manager. (First plug-in enumerates as PID_0021
      "(Unbooted)"; the loader pushes firmware and it re-enumerates as the model PID — wait for that.)
- [ ] **32-bit Python** (the COM server `C:\Windows\SysWOW64\FIUsbInt.dll` is x86; 64-bit Python cannot
      load it). Install a 32-bit Python 3.x and, in it: `pip install numpy scipy comtypes`.
- [ ] `FIUsbInt.dll` is registered (FILMeasure's installer does this). Check ProgIDs exist:
      `FIUsbInt.FMusbEnum.1`, `FIUsbInt.FIUsbController.1`, `FIUsbInt.FIUsbSpectrometer.1`.
- [ ] **Close FILMeasure** first — only one process should own the device.

## Stage 0 — environment (read-only, no device I/O)
- [ ] `python validate_hardware.py` (no flags) prints: Python is 32-bit; comtypes present; the three
      ProgIDs resolve. STOP and fix anything that fails before going on.

## Stage 1 — enumerate (read-only)
- [ ] It creates `FMusbEnum` and lists controllers/devices: serial number, friendly SN, device type,
      firmware rev, system type. Expect to see your box + spectrometer. No light, no acquisition.
- [ ] Note the reported **system type / PID→model** and serial(s). (Recall: there is no "F24" PID in the
      driver table — the unit self-reports its model; record what it actually says.)

## Stage 2 — connect + identity (read-only)
- [ ] Connect controller + spectrometer; print (all getters, no writes):
      `SerialNumber`, `NumPixels`, `eSpectromType`, `MinIntegrationTime`/`MaxIntegrationTime`,
      wavelength-cal coeffs `FWCalOffset/Slope/Curv/Third/Fourth` → computed wavelength range,
      controller `FWInstTypeCodeAsEnum`.
- [ ] Sanity: NumPixels is plausible (hundreds–few thousand); wavelength range looks like your instrument
      (e.g. ~380–1050 nm). If these read back sensibly, the COM binding + marshaling are correct.

## Stage 3 — light source on/off  (`--lamp`, reversible)
- [ ] With `--lamp`, toggles `SetLightSourcePowerOnState(1)` then `(0)`, reading `LightSourcePowerIsOn`
      between. Confirm the lamp visibly turns on then off. (Safe/reversible; no setpoint changes.)

## Stage 4 — acquire spectra  (`--acquire`, reversible)
- [ ] With `--acquire`: set a modest integration time (e.g. 40 ms), light OFF → read **dark**; light ON →
      read a **reference** off a bright standard (e.g. bare Si) you place under the probe. Prints count
      ranges + saturation/zero flags. Confirm dark ≈ floor, reference well above dark and not saturated.
- [ ] This exercises `SetIntegrationTime` + `GetSpectraSafe` end to end.

## Stage 5 — full measure  (`--measure <recipe.fitrp>`, reversible)
- [ ] Place the reference standard, run baseline; place your sample, measure. Prints fitted thickness +
      GOF and can save the measured/fitted spectrum. Compare the thickness to FILMeasure's own result on
      the same sample — they should agree closely.

## DO NOT CALL (write / calibration / firmware — can brick or de-calibrate the unit)
Avoid these unless you explicitly intend them and have a backup of the device's calibration:
`WriteFirmware`, `DeletePendingFW`, `SetPendingFWCalDelete`, `WriteBuiltInMemory`,
`WriteFirmware`, any `set_*`/property **setter** for `FWCal*`/`FWLin*`/`FWScatter*`/`FWResolution*`,
`CalibrateVGAGain`, `CalibrateAtoDGain2`, `CalibrateAtoDOffset2`, `CalibrateTECCircuit`,
`SetFWAtoDGainRegisterSetting`, `SetTECSetpoint2`/`SetTECSupplyNVSetpoint2`, `SetLampSetpoint`/
`LsSetLEDSetpoint` (changes stored lamp power), `ResetMicro` (only if you know why), controller EEPROM writes.
The validation script never calls any of these.

## If something fails
- `DevNotFound (-100)` / `FailedToOpenDevice (-105)`: driver not installed, unit still "(Unbooted)", or
  FILMeasure has the device open. `TriedToOpenDeviceAlreadyOpen (-113)`: another process owns it.
- `FailedI2COperation (-106)`: cabling / internal bus issue.
- Import/`CreateObject` fails: not 32-bit Python, or DLL not registered (`regsvr32 FIUsbInt.dll` as admin).
- Wrong-looking spectra/wavelengths: the SafeArray/[in,out] marshaling in `fiusbint.acquire` may need a
  tweak — capture the exact error and we adjust that one method.
