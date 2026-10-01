@echo off
setlocal
set "CSC=%WINDIR%\Microsoft.NET\Framework\v4.0.30319\csc.exe"
if not exist "%CSC%" set "CSC=%WINDIR%\Microsoft.NET\Framework64\v4.0.30319\csc.exe"
if not exist "%CSC%" (
  echo .NET Framework 4 compiler was not found.
  echo Install .NET Framework 4 or use the included ControllerBridge.exe.
  pause
  exit /b 1
)
"%CSC%" /nologo /target:exe /platform:x86 /out:"%~dp0ControllerBridge.exe" /reference:"%~dp0MCC4DLL.dll" /reference:System.Windows.Forms.dll "%~dp0ControllerBridge.cs"
if errorlevel 1 (
  echo Bridge build failed.
  pause
  exit /b 1
)
echo ControllerBridge.exe built successfully.
pause
