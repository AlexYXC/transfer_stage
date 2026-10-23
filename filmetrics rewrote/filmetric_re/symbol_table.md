# Running Symbol Table (renamed functions / types)

Confidence tags: [H] high, [M] medium, [L] low.

## Managed types (FILMeasure.exe, namespace `Filmetrics`)
| Symbol | Kind | Meaning | Evidence | Conf |
|--------|------|---------|----------|------|
| Filmetrics.FIRemote | class | Scriptable automation control object | pythonnetex.py; clr.AddReference('FILMeasure') | H |
| FIRemote.ctor(GUIType, StartupState, FormWindowState, ref Warning, ref string) | method | Launch/attach FILMeasure w/ GUI options | pythonnetex.py | H |
| FIRemote.AuthenticateRefBac() | method | Acquire Reference + Background baseline scans | pythonnetex.py; name = "Ref"+"Bac(kground)" | H(name) / M(exact semantics) |
| FIRemote.Measure(bool) | method | Take a measurement + fit; returns result object | pythonnetex.py | H |
| FIRemote.ConstructorWarning | enum | ctor warning codes (has member `None`) | pythonnetex.py | H |
| FIRemote.GraphicalUserInterfaceType | enum | has `Standard` | pythonnetex.py | H |
| FIRemote.GraphicalUserInterfaceStartupState | enum | has `Shown` | pythonnetex.py | H |
| (MeasureResult) | class | result of Measure(): .GOF, .PrimaryWavelengths[], .PrimarySpectrum[] | pythonnetex.py | H |

## COM interfaces (FIRemoteCOM)
| Symbol | Kind | Meaning | Evidence | Conf |
|--------|------|---------|----------|------|
| IFIRemoteCOM | COM iface | dual automation iface exposed to COM clients | FIRemoteCOM.h IID | H |
| IFMusbEnum | COM iface | USB device/controller enumeration for spectrometer | FIRemoteCOM.h | H |
| IFMusbEnum.EnumerateController2(...) | method | list controller + system type/subtype | FIRemoteCOM.h | H |
| IFMusbEnum.EnumerateDevice(...) | method | list device under controller (SN, type, rev) | FIRemoteCOM.h | H |
| IFMusbEnum.ResetMicro(ctrlIdx) | method | reset controller microcontroller | FIRemoteCOM.h | H |
| IFMusbEnum.GetVersion(MSH,MSL,LSH,LSL) | method | firmware/driver version | FIRemoteCOM.h | H |
| FMUSBIntErr | enum | USB internal error codes | FIRemoteCOM.h | H |
| FMUSBDeviceType | enum | device type classification | FIRemoteCOM.h | H |
| FMLegacyAllSystemTypes | enum | instrument/system model types | FIRemoteCOM.h | M |

## Native COM device server — FIUsbInt.dll (C:\Windows\SysWOW64), ATL COM [H]
| Symbol | Kind | Meaning | Evidence | Conf |
|--------|------|---------|----------|------|
| CFIUsbSpectrometer (IFIUsbSpectrometer) | coclass | spectrometer: SetIntegrationTime, GetSpectraStart/Status/Finish/Abort, GetSpectraSafe, wavelength cal (FWCalOffset/Slope/Curv...), linearity, scatter, TEC, ADC gain | FIUsbInt strings + device_members.txt | H |
| CFIUsbController (IFIUsbController) | coclass | box/controller: Connect, ResetMicro, R/W EEPROM, light source (SetLampSetpoint/LsSetLEDSetpoint), fans, RTC, GenIO, FWInstTypeCode | same | H |
| CFIUsbPdLed (IFIUsbPdLed) | coclass | photodiode+LED module: TriggerAcquisition/RetrieveAcquiredData, SetActiveChannels, SetGain | same | H |
| CFMusbEnum (IFMusbEnum) | coclass | enumeration: EnumerateController2/EnumerateDevice, GetVersion, ResetMicro | same | H |
| CFMF80Base/Head, CFMf64Head, CFMF80LightTower | coclass | F80/F64 motorized head + light tower | FIUsbInt strings | H |
| (native) WriteRegister / ucSlaveAddr / bTwoByteAddress | routine | I2C register R/W to internal board addresses over USB | FIUsbInt strings | M |

## Native P/Invoke DLLs (called from FILMeasure.exe) [H names / M semantics]
| Symbol | Kind | Meaning | Evidence | Conf |
|--------|------|---------|----------|------|
| fmimage.dll InitCam/GrabImageStart2/GetImageData/FMImageSetIntTime/SSSetROIStart/ReportCompSpectrumFromData | exports | camera framegrab + image→spectrum | pinvoke.txt | H(name) |
| fmsolve.dll Solve..Solve25/FFTSolve*/CalculateModelNK/ReadFIBNKFile3/ComputeGofIndicesAndWeights | exports | thin-film fit engine | pinvoke.txt | H(name) |
| fmparerf.dll ParseERFwT/ErfParseFileToTemp/ErfParseTempFile | exports | recipe/ERF config parser | pinvoke.txt | H(name) |
| fmintonly.dll WriteFIBNKFile2/WriteFMKKKFile/WriteFMNNNFile | exports | material (n,k) file writers | pinvoke.txt | H(name) |
| fm_via.dll AAdvisor/AGetRSubstrate | exports | optics advisor / substrate reflectance | pinvoke.txt | M |
