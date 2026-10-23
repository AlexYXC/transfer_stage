# Findings — FILMeasure RE

## Stage 1: Architecture & triage

### Product context (MEDIUM confidence)
Filmetrics thin-film reflectometer family. Help files present for F20, F3, F3-sX, F40, F70.
F24 is the user's unit. Measurement = spectral reflectance vs wavelength, fit to a film model
(GOF = goodness of fit). A **video microscope** (Logitech UVC camera, Aptina/Micron **MT9M001**
1.3MP CMOS, 1280x1024 Bayer) provides sample view/aiming; a separate **spectrometer** provides the
reflectance spectrum used for the actual measurement.

### PE triage (HIGH confidence — parsed PE headers)
| File | Arch | Managed? | Sub | Linker | Role (hypothesis) |
|------|------|----------|-----|--------|-------------------|
| FILMeasure.exe | x86 | **.NET** | GUI | 11.0 | Main GUI app + automation (namespace `Filmetrics`) |
| FIImage.dll | x86 | native | — | 14.0 (VS2015) | Camera framegrab + likely USB spectrometer I/O |
| FMSolve.dll | x86 | native | — | 12.0 (VS2013) | Thin-film fitting/solver engine (596 KB) |
| FIRemoteCOM.dll | x86 | .NET | Console | 11.0 | COM-callable automation wrapper |
| CustomActions7.dll | x86 | .NET | GUI | 11.0 | MSI installer custom actions |
| FIRemotePureCpp.exe | x86 | native | Console | 10.0 | Sample COM client (pure C++) |
| FIRemoteTest.exe/Cpp/CS | x86 | .NET | GUI | — | Sample automation clients (VB/C++/CS) |
| DirectShowLib-2005.DLL | x86 | .NET | — | 8.0 | DirectShow wrapper (camera capture) |
| FIAutoUpdater / NetFrameworkUpdate | x86 | .NET | GUI | 11.0 | Updater helpers |
| wshom.ocx | x86 | native | — | 9.0 | Windows Script Host OCX (redistributable) |

Third-party managed deps present: Microsoft.Office.Interop.Excel, Microsoft.Vbe.Interop,
Microsoft.WindowsAPICodePack(.Shell), Interop.IWshRuntimeLibrary, office.dll, stdole.dll
→ FILMeasure can export to Excel and script via WSH.

### Transport / device layer (MEDIUM-HIGH confidence, from COM headers)
Two independent hardware paths:
1. **Spectrometer controller over proprietary USB ("FMusb")** — evidence: `IFMusbEnum` interface in
   FIRemoteCOM.h with `EnumerateController/EnumerateController2/EnumerateDevice`, `ResetMicro`
   (microcontroller present), `GetVersion` (firmware MSH/MSL/LSH/LSL), `Close`, `get_XPVer`.
   Types: `FMUSBIntErr`, `FMUSBDeviceType`, `FMLegacyAllSystemTypes`, subsystem index.
   Multi-controller / multi-device / multi-subsystem topology. Serial numbers (SN + friendly SN).
   → NOT a virtual COM port; a vendor USB stack. Actual spectrum-read/integration-time commands
     are NOT in this enum interface — they live elsewhere (FIImage.dll or an FMUSB*.dll). TODO.
2. **Video camera over USB Video Class (UVC)** — Logitech PRO webcam driver (PRO564 / lvuvc /
   lvrs64.sys), captured via DirectShowLib. `sensorConfig.txt` = MT9M001 register map for this path.

### `sensorConfig.txt` = MT9M001 camera-sensor register map (HIGH confidence)
Header comment: "Copyright 2003 Micron Technology". SENSORNAME="MI-1300", PART_NUMBER="MT9M001",
1280x1024 BAYER. Register entries have the schema:
`REGDEF = {ADDR(hex), CORE/IP, MASK(hex), RW/RO, DEFAULT(hex), "DESC", "DETAIL"}` with nested
`{BITDEF, MASK, RW, "DESC","DETAIL"}`. Notable regs: CHIP_VERSION(0x00 RO 0x8431),
ROW/COL_WINDOW_START/SIZE (ROI), INTEG_TIME_REG(0x09, "Shutter Width", rows of integration),
GREEN1/BLUE/RED/GREEN2/GLOBAL_GAIN (0x2B–0x35), READ_MODE_1/2 (skip/mirror/snapshot/strobe),
CAL_* black-level, CHIP_ENABLE(0xF1). This is literally a control list w/ id,name,addr,mask,rw,
default,description — matches the user's Stage-4 struct request. NOTE: these control the *camera*,
not the spectrometer.

### FIRemote automation entry (HIGH confidence — from vendor Python sample)
`.\SourceCode\Python\pythonnetex.py` uses pythonnet:
```
clr.AddReference('FILMeasure'); from Filmetrics import FIRemote
r = FIRemote(FIRemote.GraphicalUserInterfaceType.Standard,
             FIRemote.GraphicalUserInterfaceStartupState.Shown,
             FormWindowState.Normal, warning, warningMessage)
r.AuthenticateRefBac()                # acquire Reference + Background (baseline)
res = r.Measure(False)                # take measurement + fit
res.GOF, res.PrimaryWavelengths[], res.PrimarySpectrum[]
```
→ `FIRemote` (in FILMeasure.exe, namespace `Filmetrics`) is the scriptable control object.
Enums: ConstructorWarning, GraphicalUserInterfaceType{Standard,...},
GraphicalUserInterfaceStartupState{Shown,...}. Result type exposes GOF + spectrum arrays.

### COM identifiers (HIGH confidence — from FIRemoteCOM.h)
- IID IFIRemoteCOM = {A4AAE6FE-2B77-3CA5-83C7-E053511A7AF8}
- CLSID FIREmoteCOM = {265ED61D-5349-3A4A-8781-0BA120BD61D2}
- IID IFMusbEnum    = 55B882B7-5E20-43E5-B36A-AC604F98ADC1
(3CA5/3A4A version fields suggest these are auto-generated from .NET GUIDs.)

### FULL `Filmetrics.FIRemote` automation API (HIGH confidence — from vendor VB harness FormFIRemote.vb)
This is the complete application-level device-control surface. Every method has two overloads:
one taking `MeasSystem/ChannelGuid` (multi-channel systems) and one without (single channel).

- **Lifecycle/GUI:** ctor(GraphicalUserInterfaceType{None,Standard}, GraphicalUserInterfaceStartupState
  {Shown,Hidden}, FormWindowState, ref ConstructorWarning, ref msg); Dispose(); IsRunning; GUIVisible;
  ShutdownRequested (event); StartupFailureMessage; SampleID; OperatorID.
- **Topology:** NumberOfSystems; MeasSystemGuids/Guid/Name/HWName; NumberOfChannels;
  MeasChannelGuid/Name/HWName/HWSerialNumber; NumberOfSubSystems; ActivateMonitor/ChannelDisplayTab;
  OpticsConfiguration (get/set) : OpticsConfigSystemTypes {ReflectanceAndTransmittance, ReflectanceProbe,
  TransmissionStage, MicroscopeObjectiveReflectance, MicroscopeObjectiveTransmittance, ContactProbeHandHeld,
  ContactProbeHandHeldAutoBaseline, ContactStage, ContactStageAutoBaseline, CTMProbe}.
- **Acquisition:** AcquireSpectrum(...primary+secondary, isReflectance...); AnalyzeSpectrum→FIMeasResults;
  OpenSpectrum/SaveSpectrum/SaveSpectrumToBuffer/OpenSpectrumFromBuffer; SpectrometerDiagnostics→FISpecDiagnosticsInfo.
- **Baseline/calibration STATE MACHINE:** BaselineSetRefMat → BaselineAcquireSpectrumFromSample →
  BaselineAcquireReference / BaselineAcquireReferenceUsingOldSampleReflectance / BaselineAcquireReferenceT(transmit)
  → BaselineAcquireBackgroundAfterRef → BaselineCommit. Convenience: AuthenticateRefBac (ref+background).
  HW auto-adjust: GetBaselineHardwareAdjustStatus / BaselineHardwareAdjustInhibit / ...Requested /
  BaselineHardwareAdjustStatus(enum) / BaselineShowDialog; SetUseStandardAndBackground.
- **Recipe / film-model config:** SetRecipe / SetRecipeSpectrumAnalysis / SetRecipeThickness /
  SetRecipeModeToSpectrumAnalysis / SetRecipeModeToThickness; RecipeInfo; RecipePath(Custom); MaterialPath(Custom);
  SetMaterial; SetN; SetAnalysisWavelengthRange; SetRoughness; SetThickness.  ← edit the layer stack/model.
- **Measure:** Measure(...)→FIMeasResults; SystemMeasure→FIMeasResultValuesOnly;
  SystemStartMonitoring/StopMonitoring; SystemMeasurementCompleted(event); HistoryDeleteAllResults.
- **Spectrometer/timing DEVICE PARAMS:** IntegrationTime_ms (prop + indexed by guid,specIndex);
  IntegrationCycles (prop + indexed); MaximumSamplingTime; MeasurementTimingMode {Recommended,Maximum,Manual};
  SpectrometerType {ShortWavelengthsOnly,LongWavelengthsOnly,All,ExtendedWavelengths}; SpectrometerIndex.
- **GPIO:** GeneralPurposeIOIsSupported / GeneralPurposeIOSetValue / GeneralPurposeIOReadValue.
- **Exceptions (error model):** AcquisitionException{Saturation,InvalidAcquisitionSettings,Unknown},
  SpectrumAnalysisException, ArgumentException, IncompatibleHardwareException, InvalidBackgroundException,
  TimeOutException, IllegalCommandException, FileNotFoundException.
- **Result types:** FIMeasResults, FIMeasResultValuesOnly, FISpecDiagnosticsInfo.

NOTE: This is the top of the stack. Below `IntegrationTime_ms`/`AcquireSpectrum` the calls become native
USB transfers (FIImage.dll / an FMUSB layer). That wire protocol is the remaining true-RE target.

### _FIRemoteCOM (COM-exposed subset, from FIRemoteCOM_h.h)
Methods: AcquireSpectrum, Measure(fmtRtf, out thickness[], out GOF, out summary), SetRecipe,
StartupFailureMessage, IsRunning, BaselineSetRefMat, BaselineAcquireSpectrumFromSample,
BaselineAcquireReference, BaselineAcquireBackgroundAfterRef, BaselineCommit, AuthenticateRefBac, Dispose.
Extra COM library GUIDs: FIRemoteCOM coclass {3D7F9E32-1661-3BD3-8BF6-02C333F1E67F};
DllRegisterFunctions {C74FE5BD-...}; DllExportAttribute {ED436777-...}. Built by MIDL from a .NET assembly
(auto-generated ToString/Equals/GetHashCode/GetType present) → confirms FIRemoteCOM.dll = COM wrapper over
managed FIRemote.

### Tooling reality (HIGH confidence)
- .NET **runtime** present but **no SDK** → cannot `dotnet tool install ilspycmd`.
- Python 3.14 + pip + **internet available** (nuget reachable).
- Chosen approach: pure-Python `dnfile` (installed) to read managed metadata WITHOUT executing the assembly
  (safe); `pefile` for native import/export/strings. Real C# body decompilation = optional later pass
  (ICSharpCode.Decompiler via pythonnet, or download ilspy) — evaluate after metadata pass.

### NATIVE DEVICE COMMAND SURFACE — COM interfaces in FIUsbIntLib (HIGH confidence)
FILMeasure.exe is **Dotfuscated** (DotfuscatorAttribute; internal types renamed a/b/c...), BUT the
device layer is preserved as `[ComImport]` interfaces (the `_VtblGapN_M` placeholders = COM vtable slots),
i.e. the managed code calls a **native COM server** (implemented in FIImage.dll/fmimage.dll or a sibling)
that performs the actual USB transfers. Extracted method names (dnfile metadata):

**`FIUsbIntLib.IFIUsbSpectrometer` (240 methods) — THE spectrometer device object:**
- Connect; get_SerialNumber/FriendlySN/DeviceRevLevel/eSpectromType; WriteFirmware; get_FWCorrupt/FWRevNum.
- **Acquire:** SetIntegrationTime / get_IntegrationTime / Min/Max/QuantizedIntegrationTime_ms;
  **GetSpectraStart → GetSpectraStatus → (GetSpectraAbort|GetSpectraFinish)** = async acquisition SM;
  GetSpectraSafe, GetSpectraSmoothedAndUnsmoothedSafe; get_NumPixels/NumHWPixels;
  Set/GetFirstLastValidPixelIdx; ReadTemperature; get_TemperatureSensorExists.
- **Wavelength cal (firmware-stored):** FWCalOffset/FWCalSlope/FWCalCurv/FWCalThird/FWCalFourth (+ *2 set with
  FWCalTemp1/2 for temp-dependent); UpdateWavelengthOffset; UpdateWavelenCal2; EffectiveCalOffset;
  FixedCalOffset; FWWaveRangeStart/End; FindPeaks3 (peak find for cal lamp).
- **Corrections:** FWLinInt/FWLinSlope/FWLinVer/FWLinV2Coeff... (linearity); FWDCScatter*/CorrectForScatterSafe
  (stray light); SetSecondOrderTable/FWSecondOrderCoeffs (2nd-order diffraction); FWResolution*.
- **ADC/gain:** CalibrateVGAGain; SetFWAtoDGainRegisterSetting; PGAGainSetting; CalibrateAtoDOffset2/Gain2;
  FWAtoDOffsetRegisterSetting; get_MaxADValue(implied); get_ReadoutNoiseRms; get_FullWellNumElectrons.
- **Detector HW:** EnableDisableHighVoltage/HasHighVoltageGenerator; SetTECSetpoint2/TECTemperatureSetpoint/
  CalibrateTECCircuit/HasTwoStageTEC (thermoelectric cooler); SetStrobeModeEnable/SetExtTrigEnable/
  LightSourceIsStrobe; SetGPIOBit/GetGPIOBit/HasGPIOBits.
- **On-device memory:** ReadBuiltInMemory/WriteBuiltInMemory/ReadMemBlockID/BuiltInMemorySize (EEPROM/flash).
- SetAcqStatusLEDEnableState; RefreshHardwareSettings; SetCalibrateDataFilePath.

**`FIUsbIntLib.IFIUsbController` (125 methods) — the controller/box:**
- Connect / ConnectAndSetDeviceAddresses; ResetMicro; Shutdown; WriteToEEPROM/ReadFromEEPROM; WriteFirmware;
  RefreshHardwareSettings; RefreshWriteEnabledState; ReadGenIO/WriteGenIO; ValSafe/ValConSafe.
- FW config: FWInstTypeCode(+AsEnum), FWSystemSubtype, FWSubsystemIdx, FWDefOpticConfig, FWDefRefMat(ID),
  FWDefNumCurves, FWMeasurementAngle, FWOemCode, FWMfrDate, FWBoxTotalSubsystems, FWSubsysNumControllers,
  FWRevNum/FWCodeMajorVer/FWCodeMinorVer/FWUpdateRevLevel/FWHighestCompatRevLev, SerialNumber/FriendlySN/
  ParentSerialNumber, FWBitPatt(5/6/7), FWF50Threshold, FWF50XYDkMirX/Y, FWLimCenDist.
- **Light source:** SetLampSetpoint/LampSetpoint/MaxLampSetpoint; LsSetLEDSetpoint/LsLEDSetpoint/LsMaxLEDSetpoint/
  LsfwNumLEDs; SetLightSourcePowerOnState/LightSourcePowerIsOn; LsTemperature; LsUpdatePowerOn{Led,Lamp}Setpoint;
  Ls{Get}PowerOn{Lamp,Led}Setpoint; HasLow/HighPowerLightSource.
- Fan/thermal: SetFanState/GetFanStatus/CheckFan2Status/FanPowerIsOn. RTC: SetRtcTime/HasRtc/RtcDiscrepancy.
- USB: USBHighSpeedActive/USBSelfPowered/HasUSBChargingPort. Status LEDs: SetStatusLEDsEnableState.
- Light on-time meter: ReadLightSourceOnTime/ResetLightSourceOnTime/HasLightSourceOnTimer.

**`FIUsbIntLib.IFIUsbPdLed` (36) — photodiode+LED module (contact/monitor probe path):**
- Connect; TriggerAcquisition; RetrieveAcquiredData; SamplesPerSampleBlock; SamplingFrequency;
  MaxNumSampleBlocksInBuffer; SetActiveChannels/ChannelIsActive; SetGain/Gain/GainMin/GainMax; MaxADValue;
  FWNumPhotodiodes; FWPDWavelength.

**`FIUVSourceLib.IUVSource` (20) — UV/Vis lamp module:**
- Connect; SetD2LampState (deuterium); SetTHLampState (tungsten-halogen); SetShutterState/GetShutterStatus;
  GetStatus; SetFrontPanelDisable/GetFPDisableStatus; GetLampOnTime/ResetLampOnTime/HasLampOnTimer;
  GetFanStatus; SystemSubtype/SystemTypeUV; D2/TH LampOnRequestedViaUSB; ShutterOpenRequestedViaUSB.

**`FIUsbIntLib.IFMusbEnum` (7):** EnumerateDevice, GetVersion, ResetMicro, Close, EnumerateController2, get_XPVer.

**`FISerBuffMultPrj.FISerBuffMult`:** Init2, AddToQueue, GetFromQueue, get_SendQueueEmpty, StopFirmwareApp,
ShutDown → a **buffered command queue** (serial-over-USB command/response multiplexer to the microcontroller).

**Also present (managed, obfuscated bodies):** Filmetrics.TmcmControllerEnums (Trinamic **motorized stage**),
LinearActuatorType, Filmetrics.LightState/LEDChannel/LampChannel/FiberMuxChannel (illumination routing).

### Native P/Invoke boundary summary (from FILMeasure.exe.pinvoke.txt)
- **fmimage.dll / FIImage.dll** = camera+acquisition: InitCam, GrabImageStart2, GetImageData, GetImageSize,
  FMImageSetIntTime/GetIntTime, FMImageSetFrameSize, SSSetCamGainParam, SSSetROIStart, SetHWNumCameras,
  ReportCompSpectrumFromData (image→spectrum), ICBayerConversion/white-balance (video), Mu*DistSensor* (distance).
- **fmsolve.dll** = fit engine: Solve..Solve25, FFTSolve*, SolveCTM4/KProb/NProb, CalculateModelNK,
  ComputeGofIndicesAndWeights, ReadFIBNKFile3/ParseFIBNKFileBuffer (materials), CorrectForLinearity, etc.
- **fmparerf.dll / FIParErf.dll** = recipe/ERF parser: ParseERFwT, ErfParseFileToTemp, ErfParseTempFile.
- **fmintonly.dll** = material writers: WriteFIBNKFile2, WriteFMKKKFile, WriteFMNNNFile.
- **fm_via.dll** = optics advisor: AAdvisor, AGetRSubstrate.
- **kernel32** = File I/O + **Named Pipes** (CreateNamedPipe/Connect/Wait/Disconnect + ReadFile/WriteFile) →
  IPC transport for out-of-process automation clients ↔ FILMeasure. Iphlpapi.GetAdaptersInfo = node-lock/licensing.

### Two hardware families supported by this software (MEDIUM-HIGH)
1. **Dedicated USB spectrometer** (FIUsbIntLib: F10/F20/F50/F60 subtype enums) — microcontroller + CCD/PDA
   spectrometer, light source controller, optional TEC/HV, via native COM server over USB. (Classic F20-class.)
2. **Camera-based imaging** (fmimage.dll InitCam + UVC Logitech camera + MT9M001 regs) — spectrum from a
   dispersed image and/or video microscope. F24 (this unit) most likely uses the camera path; confirm by
   which InstTypeCode/subtype the connected hardware reports at runtime.

### TRANSPORT LAYER — FINAL (HIGH confidence for mechanism; MEDIUM for which path this unit uses)
`FIUsbInt.dll` = **C:\Windows\SysWOW64\FIUsbInt.dll** (730 KB, native x86 **ATL COM server**, built w/ ATL,
DriverVer era 2015, dll 2018). It is the implementation behind all FIUsbIntLib COM interfaces. Imports:
- **SETUPAPI** (SetupDiGetClassDevsA/EnumDeviceInterfaces/GetDeviceInterfaceDetailA) → enumerate by device
  interface (class FMUSBCON, ClassGuid {B50C0992-40FE-4B62-84BE-E30AA1C7AE50}).
- **CreateFileA/W + DeviceIoControl + CancelIo + CreateEvent/WaitForSingleObject** → open device handle +
  overlapped I/O (custom-driver path).
- **WINUSB.DLL** (WinUsb_Initialize/QueryInterfaceSettings/QueryPipe/GetAssociatedInterface/WritePipe/Free)
  → WinUSB path (bulk OUT via WritePipe; reads/spectra likely via overlapped DeviceIoControl or ISO —
  errors kFMUSBIntErrISOPacketSpaceTooSmall/DescrSizeDefIncorrect imply **isochronous IN for spectra**).
- ole32/oleaut32 (COM/SafeArray/TypeLib), advapi32 (registry), version, winmm(timeGetTime), shell32.
Internal bus: strings "WriteRegister", "ucSlaveAddr", "bTwoByteAddress", "Analog read ... board address %d",
"Switching to board address %d" → the controller MCU bridges USB to internal **I2C sub-boards addressed by
board/slave address**, 1- or 2-byte register addressing. So: register read/writes are tunneled over USB.

**COM coclasses in FIUsbInt.dll** (ProgID / CLSID):
- FIUsbController      {8E8A4047-8CAE-4A66-911B-B669635F33A5}  ProgID FIUsbInt.FIUsbController.1
- FIUsbSpectrometer    {7F0418FC-800D-422D-8D35-D40D515031E2}  ProgID FIUsbInt.FIUsbSpectrometer.1
- FIUsbPdLed           {313516E5-F1DA-431C-A946-7241096C4AB5}  ProgID FIUsbInt.FIUsbPdLed.1
- FMusbEnum            {BB8E1A15-4E65-45FA-9DE6-876792487AF7}  ProgID FIUsbInt.FMusbEnum.1
- FMF80Base            {D84C3178-BC23-4CAB-B91D-6A86749CBFD9}  ; FMf80Head {841ADEAD-3DA3-40B8-A9E6-2B62DEE8AE15}
- FMF80LightTower      {E1A00853-CF10-4C7E-86EE-42E2358825C9}  ; FMf64Head {6EAEA516-40BB-49C3-B3D5-69F376664660}
- TypeLib LIBID_FIUsbIntLib = {A44D02B9-A07D-489F-A4AC-9B49E8646871}
Extra native-only interfaces beyond the managed set: IFMF80LightTower, IFMf80Base/Head, IFMf64Head.

### DEVICE ENUMERATION / IDENTITY (HIGH confidence — from C:\Windows\INF\oem360.inf "FIUsb2FSrs.inf", © Filmetrics 2014)
- USB **VID_116D** = Filmetrics, Inc. Custom setup class **FMUSBCON** = "Filmetrics Measurement Instruments".
- Kernel drivers (SERVICE_KERNEL_DRIVER, auto-start, in System32\Drivers):
  - USB2/Gen1: **FILdUSB2.sys** (firmware loader, "Unbooted") → **FIUsb2FSrs.sys** (operational).
  - Gen2:      **FMLdUSB.sys**  (firmware loader)          → **FMUSBGn2.sys** (operational).
  → Device does **firmware-download-on-connect** (renumeration): appears first as PID_0021/0001 "(Unbooted)",
    loader pushes firmware, device re-enumerates as its model PID. (Classic Cypress FX2-style two-stage.)
- **PID → model map** (USB2 group, booted):
  0021 Unbooted IO Controller · 0022 Unknown · 0023 F10 · 0024 F20 · 0025 F30 · 0026 F40 · 0027 F50-300 ·
  0028 F20_F40 · 0029 F80 · 002A F42 · 002B F42OSP · 002C F37 · 002D F50-450 · 002E F32 · 002F F40-NSR ·
  0030 PARTS · 0031 F50XY-510 · 0032 UV Light Source · 0033 F70 · 0034 F50XY-10 · 0035 F2 · 0036 F3 ·
  0037 F1 · 0038 S3 · 0039 Optical Accessory · 003A F60 · 003B FI Heraeus.
  (Gen2 group PID 0001-000D: 0003 F10 · 0004 F20 · 0005 F30 · 0006 F40 · 0007 F50-200 · 0008 F50-300 ·
  0009 F50XY-200 · 000A F50XY-450 · 000B F20_F40 · 000C F80 · 000D F42.)
- **THERE IS NO "F24" PID.** ⇒ The user's "F24" is NOT a distinct enumerated model here. Hypotheses (UNRESOLVED):
  (a) informal name for an F20-class benchtop; (b) an OEM/rebadge that enumerates as one of the above (or as
  "Unknown"/"Optical Accessory"); (c) a model newer than this 2014 INF. RESOLVE by reading the connected
  unit's VID/PID + FWInstTypeCode (Device Manager / FMusbEnum.EnumerateController2). MUST NOT guess.
- Camera path VID = **046D (Logitech)**, PID 0990/0809 (webcam) via UVC+DirectShow. (The vid_2560/203a strings
  seen in FILMeasure.exe are unrelated to the Filmetrics spectrometer; likely other accessories — low priority.)

### Stage-4 control DEFAULTS from FILMeasure.exe.config (HIGH confidence — read directly)
User settings (Filmetrics.My.MySettings), device/measurement-relevant subset:
- Acquisition: LastSetIntegrationTime=40 (ms); UseAutoScaleIntTime=True; NumSpectraToAverage=1;
  NumPointsToSmooth=3; MinSamplingTimeTotal=400 (ms); SetSensitivityRadioOption=0.
- Baseline/reference: LastUsedReflReferenceMaterial=BK7; LastUsedTransReferenceMaterial=1;
  UserSuppliedReflectance=0.33; SampleReflOption=0; ReferenceMinIntenWRTHist=50; ReferenceMaxIntenWRTHist=150;
  BaselineRemindTimeMinutes=60; ForceBaselineIfIntervalExceeded=False; SetUseStandardAndBackground (API).
- Wavelength cal: WavelenCalEnable=True; WavelenCalMode=0; WavelenCalPeriodMinutes=10 (auto neon cal cadence).
- Light source: LightSourceAutoStandby=True; LightSourceAutoStandbyDelayMinutes=60.
- Camera: CameraImageCenterCol=320; CameraImageCenterRow=256; VideoShowSpot=True; DetectGrayImageFromCamera=True.
- Detector model (PrecSim*): FullScaleCounts=4096 (12-bit ADC); ShotNoiseWellDepthElectrons=140000;
  SpectrometerResolution_nm=1; WavelenCalNoise_nm=0.
- Paths: CustomRecipePath, CustomMaterialPath, StandaloneConfiguration, OemSettingsCode=0.
- Wafer/stage: WaferHandlerPrealignerEnabled=False; CassetteDisplayUnits=1; WaferMapUseOptimalPath=True.
- Runtime target: .NETFramework v4.0 Client profile (from <startup>).

### Tooling update (batch 2 setup)
- .NET runtimes present: Microsoft.NETCore.App **8.0.11** and 10.0.9 (+ WindowsDesktop). .NET FW v4.0.30319 present.
- Plan: fetch **ilspycmd** (ILSpy CLI) nupkg from nuget.org, run on net8 runtime → decompile FILMeasure.exe to C#.
  (Reads metadata only; does not execute the target.) pythonnet NOT installed (not needed with ilspycmd route).

### Recipe/control-list format (HIGH) — see recipe_schema.md
`.fitrp`/`.fitra` are **plain text**, self-describing: header `***Machine Readable Structure Export Version, NN`,
`[Section]` + `===== Measure Site N =====` blocks, trailer `***End Machine Readable Structure***` + `CHECKSUM=<int>`.
The film stack lives in `[Layers]` (Medium/Layer/Substrate rows w/ material, thickness Å, roughness, and d/n/k/r
"solve-for" flags). Device acquisition settings live in `[Acqusition Settings]` (integration time/cycles,
spectrometer type, timing mode, reference material). ⇒ The control list the user wants to modify is directly
editable text. CHECKSUM: enforced on load, CONFIRMED (hg.cs:2322 rejects mismatch). Algorithm (hg.bu,
hg.cs:2335; verified 8/8): sum of utf-16-le bytes of content before "CHECKSUM=" (incl End-marker line),
spaces/tabs stripped when schemaVersion>=5, CRLF kept. Tool delivered+tested: tools/recipe_checksum.py.

### Stage 2 sample (FIRemote control flow, from decompiled C#) — see analysis/decompiled/FIRemote.cs
`Filmetrics.FIRemote` is a thread-safe **facade** over an internal measurement engine (obfuscated field `m_k`).
Public calls validate the channel GUID, then post an async task to `m_k` with a completion callback and
**wait on a per-channel ManualResetEvent with a timeout**, then read status + build the result object. Example:
`AnalyzeSpectrum` → `m_k.m2(guid,"Analyzing Spectrum...", …, mSpecAnalysisCompletionTask, …)` →
`aa[guid].WaitOne(60000)` → throws `TimeOutException`/`SpectrumAnalysisException` on failure. This mirrors the
COM async pattern (GetSpectraStart→Status→Finish). Limits seen: IntegrationCycles 1..5000 (per-channel).
Full-assembly decompile → analysis/decompiled/FILMeasure_project/ (in progress) for deep Stage-2 tracing.

## Open threads
- Need full IFIRemoteCOM method list → read FIRemoteCOM_h.h (21 KB) [next].
- Need a .NET decompiler for FILMeasure.exe/FIRemoteCOM.dll.
- Need native import tables for FIImage.dll / FMSolve.dll to find USB APIs (WinUSB? CyUSB? FTDI? custom .sys?).
- Identify the DLL implementing IFMusbEnum + the spectrum-read commands.
