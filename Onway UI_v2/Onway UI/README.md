# Onway Temperature Controller

Double-click **temp_control_gui - Shortcut** for the main interface, or
**ui - Shortcut** for the alternate interface. Run one interface at a time;
both use COM5. `modbus_controller.py` is a shared module, not a separate app.

The shortcuts use the Python environment in `.venv`. From a terminal in this
folder, the main interface can also be opened with:

```powershell
.\.venv\Scripts\python.exe .\temp_control_gui.py
```

## Connection and responsiveness

The existing controller settings are COM5, 9600 baud, 8 data bits, no parity,
1 stop bit, and Modbus device ID 10.

Device communication runs on a single background thread. Healthy temperature
reads are scheduled about every 300 ms, subject to the controller's response
time. Each request has a one-second timeout and no immediate retransmission.
After a connection failure, the app waits two seconds before trying again.
Device waits do not block window movement, redraws, or closing the app.

The status line reports connection or command results. Hover over it for more
detail. An old temperature is marked offline after a failed read. Settings
controls are enabled after the controller replies and its initial values load.
Temperature, power, heating time, and holding time fields load from the device.
Start/Stop acknowledgements confirm the serial command was accepted; they do
not independently verify heater output or physical temperature changes.

Writes are serialized. Repeated input cannot build up a backlog, Stop takes
priority over queued updates between requests, and failed commands are not
replayed after reconnection. A successful command status requires a controller
acknowledgement. No register addresses, baud rate, or device ID were changed
by the responsiveness update.

If COM5 cannot open, check that the USB adapter is connected and that another
program or another Onway window is not using it. If COM5 opens but does not
respond, check the controller's power, wiring, and communication settings.

## Verification and dependencies

The mock-device tests cover slow replies, disconnection/reconnection, a single
thread owning the serial client, command ordering, Stop priority, no replay
after a failed write, temperature scaling, and closing during a timeout.
They do not access physical hardware:

```powershell
.\.venv\Scripts\python.exe .\tests\test_responsiveness.py
```

The installed package versions are recorded in `requirements.txt`. To restore
them in this environment:

```powershell
.\.venv\Scripts\python.exe -m pip install -r .\requirements.txt
```
