# Cross-Reference Tracker

Format: symbol/constant → where referenced / who calls whom.

## Automation call graph (from vendor samples)
- pythonnetex.py → Filmetrics.FIRemote (FILMeasure.exe)
- FIRemoteTest (VB) → FormFIRemote.vb (64 KB) exercises the full FIRemote/COM API → GOOD reference for
  the complete command surface. [TODO read]
- FIRemotePureCpp.cpp / FIRemoteTestCpp / FIRemoteTestCS → COM clients of FIRemoteCOM.dll (CLSID above)
- FIRemoteCOM.dll (.NET) → wraps → Filmetrics.FIRemote in FILMeasure.exe (hypothesis) [verify by decompile]

## Transport
- IFMusbEnum (COM) → implemented by ??? DLL (FIImage.dll or an FMUSB*.dll) [TODO: parse exports/imports]
- FILMeasure.exe → FIImage.dll (native, P/Invoke) [hypothesis] → USB driver [TODO]
- FILMeasure.exe → FMSolve.dll (native, P/Invoke) for fitting [hypothesis]
- FILMeasure.exe → DirectShowLib → Logitech UVC camera (video path)

## RESOLVED transport chain (batch 1)
```
FIRemoteTest/COM client ─(named pipe, kernel32)─┐
pythonnet script ──(CLR, in-proc)───────────────┤
                                                 ▼
                                       FILMeasure.exe  (managed, Dotfuscated; namespace Filmetrics)
                                         │  Filmetrics.FIRemote (306 members) = automation facade
                                         │  FIUsbIntLib.FIUsbSpectrometer/Controller/PdLed (managed [ComImport] wrappers)
                                         ├─(COM interop)──▶ FIUsbInt.dll  (SysWOW64, native ATL COM server)
                                         │                     ├ SetupAPI enumerate (class FMUSBCON / VID_116D)
                                         │                     ├ CreateFile + DeviceIoControl (overlapped)  ← custom driver path
                                         │                     ├ WinUsb_WritePipe / QueryPipe            ← WinUSB path
                                         │                     └ I2C WriteRegister to board addresses (spectrometer/LS/PD)
                                         │                          ▼ FIUsb2FSrs.sys (op) / FILdUSB2.sys (loader) ▼ USB ▼ instrument MCU
                                         ├─(P/Invoke)────▶ fmimage.dll  (camera framegrab via UVC/DirectShow; image→spectrum)
                                         │                          ▼ Logitech UVC camera (VID_046D)
                                         ├─(P/Invoke)────▶ fmsolve.dll  (thin-film fit) / fmparerf.dll (recipe) / fmintonly.dll (materials)
                                         └─(SOAP)────────▶ Filmetrics web services (material DB / security / registration)
```

## To search once decompiler available
- All callers of FIImage.dll exports
- All references to INTEG_TIME / integration time / gain in FILMeasure.exe
- Where sensorConfig.txt is parsed (which class reads the register map)
- Where .fitrp/.fitra/.fiprc recipe files are (de)serialized
