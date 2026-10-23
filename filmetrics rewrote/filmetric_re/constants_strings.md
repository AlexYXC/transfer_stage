# Running List of Discovered Constants & Strings

## GUIDs (COM)
- IID_IFIRemoteCOM = {A4AAE6FE-2B77-3CA5-83C7-E053511A7AF8}   [FIRemoteCOM.h]
- CLSID_FIREmoteCOM = {265ED61D-5349-3A4A-8781-0BA120BD61D2}  [FIRemoteCOM.h]
- IID_IFMusbEnum   = {55B882B7-5E20-43E5-B36A-AC604F98ADC1}   [FIRemoteCOM.h]

## MT9M001 camera sensor (sensorConfig.txt) — register addresses
- 0x00 CHIP_VERSION (RO, default 0x8431)
- 0x01 ROW_WINDOW_START, 0x02 COL_WINDOW_START, 0x03 ROW_WINDOW_SIZE(height-1), 0x04 COL_WINDOW_SIZE(width-1)
- 0x05 HORZ_BLANK, 0x06 VERT_BLANK, 0x07 CONTROL_MODE (chip enable/sync)
- 0x09 INTEG_TIME_REG ("Shutter Width" = rows of integration; default 0x0419)
- 0x0B RESTART, 0x0C SHUTTER_DELAY, 0x0D RESET
- 0x1E READ_MODE_1 (skip/snapshot/strobe), 0x20 READ_MODE_2 (skip/mirror/dark rows)
- 0x2B GREEN1_GAIN, 0x2C BLUE_GAIN, 0x2D RED_GAIN, 0x2E GREEN2_GAIN, 0x35 GLOBAL_GAIN (6-bit + double bit)
- 0x5F CAL_THRESHOLD, 0x60-0x64 CAL_G1/G2/R/B + CAL_CTRL, 0x65 CLOCK_CTRL, 0xF1 CHIP_ENABLE
- Sensor two-wire base address SHIP_BASE_ADDRESS = 0xBA

## File-type extensions (Filmetrics data model)
- .fibnk / .fibnx = material optical constants (n,k) "film bank"
- .rrr = reference reflectance data (older format)
- .fitra / .fitrp = recipe ("transfer"?) files (AR / stack recipes)
- .fiprc = precision/standard config; .fmspe = stored spectrum
- .dat (Cal\10.dat) = calibration data
- StartupRecipe.txt / StartupRecipeAR.txt = which recipe loads on startup

## USB device identity (VID_116D = Filmetrics) — from oem360.inf
- Setup class FMUSBCON, ClassGuid {B50C0992-40FE-4B62-84BE-E30AA1C7AE50} ("Filmetrics Measurement Instruments")
- Kernel drivers: FILdUSB2.sys(loader)/FIUsb2FSrs.sys(op) [USB2/Gen1]; FMLdUSB.sys/FMUSBGn2.sys [Gen2]
- This install: USB2 driver v1.23 (FIUsbDrvrVers.dat); FILMeasure v8.12.6.0; NO hardware currently attached.
- PID→model (USB2 booted): 0021 Unbooted·0023 F10·0024 F20·0025 F30·0026 F40·0027 F50-300·0028 F20_F40·
  0029 F80·002A F42·002B F42OSP·002C F37·002D F50-450·002E F32·002F F40-NSR·0030 PARTS·0031 F50XY-510·
  0032 UV Light Source·0033 F70·0034 F50XY-10·0035 F2·0036 F3·0037 F1·0038 S3·0039 Optical Accessory·
  003A F60·003B Heraeus.  ***No F24 exists in this table.***
- Two-stage renumeration: connects as PID_0021 "(Unbooted)" → loader pushes firmware → re-enumerates as model PID.

## COM (native FIUsbInt.dll ATL server, C:\Windows\SysWOW64\FIUsbInt.dll)
- TypeLib LIBID_FIUsbIntLib = {A44D02B9-A07D-489F-A4AC-9B49E8646871}
- CLSIDs: FIUsbController {8E8A4047-8CAE-4A66-911B-B669635F33A5}; FIUsbSpectrometer {7F0418FC-800D-422D-8D35-D40D515031E2};
  FIUsbPdLed {313516E5-F1DA-431C-A946-7241096C4AB5}; FMusbEnum {BB8E1A15-4E65-45FA-9DE6-876792487AF7};
  FMF80Base {D84C3178-...}; FMf80Head {841ADEAD-...}; FMF80LightTower {E1A00853-...}; FMf64Head {6EAEA516-...}
- ProgIDs: FIUsbInt.FIUsbSpectrometer.1 / .FIUsbController.1 / .FIUsbPdLed.1 / .FMusbEnum.1

## Device error codes (FMUSBIntErr, negative) — see analysis/FILMeasure.exe.enums.txt for full set
- 0 NoErr; -100 DevNotFound; -105 FailedToOpenDevice; -106 FailedI2COperation; -107..-109 FW incompatible;
  -112 Timeout; -113 AlreadyOpen; -127 IntegrationTimeChanged; -128 OverlappedStateMismatch;
  -133 AcqWillCauseFIFOOverrun; -135 SignalTooSmall; -146 CommandNotSupportedByHW; -147 CommandNotAllowed.

## Native COM server transport imports (FIUsbInt.dll)
- SetupAPI (enumerate) + CreateFile/DeviceIoControl/overlapped + WINUSB.DLL(WinUsb_WritePipe/QueryPipe/Init...)
- Internal I2C: "WriteRegister", "ucSlaveAddr", "bTwoByteAddress", "board address %d"

## Misc
- AUFilename.txt (8 bytes) = auto-update filename marker
- Camera hardware: Logitech PRO564 UVC; sys drivers lvuvc64.sys / lvrs64.sys
