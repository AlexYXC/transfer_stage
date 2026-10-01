@echo off
setlocal EnableDelayedExpansion
cd /d "%~dp0"
for %%F in (gui.py ControllerBridge.exe MCC4DLL.dll) do (
  if not exist "%~dp0%%F" (
    echo Required file is missing: %%F
    echo Keep gui.py, ControllerBridge.exe, and MCC4DLL.dll together in this folder.
    pause
    exit /b 1
  )
)
where py >nul 2>nul
if not errorlevel 1 (
  py -3 gui.py
  set "APP_EXIT=!errorlevel!"
  goto finished
)
where python >nul 2>nul
if not errorlevel 1 (
  python gui.py
  set "APP_EXIT=!errorlevel!"
  goto finished
)
echo Python 3 was not found. Install Python 3 and enable the Windows py launcher.
pause
exit /b 1
:finished
if not "%APP_EXIT%"=="0" (
  echo.
  echo The English GUI exited with code %APP_EXIT%. The error details are shown above.
  pause
)
exit /b %APP_EXIT%
