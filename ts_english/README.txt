MCC4 Motion and Temperature Control GUI
=======================================

This is a separate English interface for the MCC4 four-axis controller. It
calls the supplied MCC4DLL.dll through a small 32-bit .NET bridge. The original
MCCDEMO application and its files are not modified by this interface.
Use only one motion controller application at a time: close MCCDEMO before
connecting here, because both programs need exclusive use of the motion
controller's serial port. Close the separate Onway temperature GUI before
connecting the integrated Temperature Control tab to the same COM port.

Start
-----
1. Install Python 3 for Windows (Tkinter is included in the standard Windows
   installer).
2. Double-click StartEnglishGUI.bat.
3. Select the controller's COM port and click Connect.

Controller communication uses the vendor DLL's documented 115200, N, 8, 1
serial settings. ControllerBridge.exe is included. BuildBridge.bat can rebuild
it with the .NET Framework 4 compiler if needed. The bridge must remain next to
MCC4DLL.dll because the DLL is loaded from its application folder.

Main controls
-------------
* Connect / Disconnect selects and opens the serial port.
* Start Program sends non-comment editor lines to the controller, one command
  at a time, and waits for the controller's run state between commands.
* Pause, Resume, Stop, and Emergency Stop map to the DLL's motion functions.
* The axis table edits speed, acceleration, and negative/positive soft-limit
  coordinates. Apply sends those values to the selected axis.
* Each X+/X−, Y+/Y−, Z+/Z−, or T+/T− click makes one bounded relative move
  equal to that axis's Manual distance parameter, then stops at the target.
  Home starts the controller's homing routine for that axis.
* Each axis has a Zero button. It asks for confirmation, then resets that
  axis's controller coordinate to zero without commanding physical motion.
  Position-based commands and soft-limit coordinates use the new reference.
* Parameter Set exposes all 10 per-axis DLL parameter slots. Download reads
  them from the controller; Upload writes the values shown in the dialog.
  Save To ROM stores the current controller parameters in controller memory.
* Other contains the demo's serial debug, joystick, communication test, COM
  assistant, and extended digital-output controls.

Temperature control tab
-----------------------
The Temperature Control tab starts with a wanted-temperature default of 200 °C
and accepts values from 190 to 325 °C. In wanted-temperature mode, before writing Segment 1, it converts the
input to the module set temperature with
`1.41442716 * (wanted_temperature - 6.19)`. The converted set temperature is
displayed beside the temperature adjustment buttons; the live measured
temperature is centered in its own section. The “Set module temperature
directly” checkbox grays out the wanted-temperature input and enables direct
editing of the module setpoint. Direct mode bypasses the calibration and
wanted-temperature range; the converted or direct value must still fit the
controller's register. The tab also includes
heating and holding times, power limit, Start/Stop, curve recording, CSV
export, and curve clearing. The right column has Heating Module buttons above
the PID Values panel and the temperature controller connection below it. The
PID panel reads and sets P, I, and D; its note gives defaults of P=150, I=15,
and D=3. PID fields use raw integer register values; their units and valid
tuning ranges depend on the controller. Heating is started with
“Start Heating” and stopped with “Stop Heating Module”. It connects to
COM5 by default using 9600 baud, 8 data bits, no parity, 1 stop bit, and Modbus
device ID 10.
Choose the temperature controller's port in that tab if it uses a different
COM port. The temperature and motion controllers must use different COM ports
while both are connected. Temperature serial communication runs through the
bridge and does not require additional Python packages.

Limit status
------------
The DLL exposes raw controller input bits, not a dedicated limit-fault code.
The red Limit indicator lists limit inputs reported high by the controller;
when the controller run bit is idle it labels this “LIMIT STOP.” The meaning
of an asserted input depends on the controller's configured signal polarity
and wiring. The Soft/Hard checkboxes call the same limit-setting API used by
the original demo.

Hardware note
-------------
The GUI and bridge were built without a motion controller connected, so the
hardware behavior was not exercised. Before sending a program or a move,
confirm the selected COM port, axis calibration, limit polarity, travel range,
and emergency-stop behavior on the actual machine.
