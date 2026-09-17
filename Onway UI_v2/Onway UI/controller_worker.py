"""One serial owner; device waits never run on the Qt GUI thread."""

from collections import deque
from threading import Condition
from time import monotonic

from PyQt5.QtCore import QThread, pyqtSignal

from modbus_controller import ModbusController


class ControllerWorker(QThread):
    temperature_read = pyqtSignal(float)
    initial_values = pyqtSignal(dict)
    connection_changed = pyqtSignal(bool)
    busy_changed = pyqtSignal(bool)
    status_changed = pyqtSignal(str, str)

    def __init__(self, port, parent=None, *, controller_factory=None,
                 poll_interval=0.3, retry_interval=2.0):
        super().__init__(parent)
        self.port = port
        self._factory = controller_factory or ModbusController
        self._poll_interval = poll_interval
        self._retry_interval = retry_interval
        self._condition = Condition()
        self._commands = deque()
        self._stopping = False
        self._online = False
        self._in_flight = False
        self._controller = None
        self._initial_loaded = False

    def submit(self, operations, description, *, priority_stop=False):
        """Called by the GUI; never performs serial I/O or waits for it.

        Only one ordinary command may be outstanding. Stop may replace a
        queued command and interrupt a batch between serial transactions.
        """
        operations = tuple(operations)
        with self._condition:
            if self._stopping or not self._online:
                return False
            if priority_stop:
                if operations != (('coil', 'run', False),):
                    raise ValueError('Only Stop can take priority')
                self._commands.clear()
            elif self._in_flight or self._commands:
                return False
            self._commands.append((operations, description, priority_stop))
            self.busy_changed.emit(True)
            self._condition.notify()
        return True

    def stop(self):
        """Request shutdown; the GUI remains alive until finished is emitted."""
        with self._condition:
            self._stopping = True
            self._commands.clear()
            self._condition.notify()

    def _should_stop(self):
        with self._condition:
            return self._stopping

    def _disconnect(self):
        with self._condition:
            self._online = False
            # Never replay an old user command after reconnection.
            self._commands.clear()
            self.busy_changed.emit(False)
        self.connection_changed.emit(False)
        self._initial_loaded = False
        if self._controller is not None:
            try:
                self._controller.close()
            except Exception:
                pass
            self._controller = None

    def _poll(self):
        try:
            if self._controller is None:
                self._controller = self._factory(self.port)
            if self._should_stop():
                return False
            temperature = self._controller.read_register('current_temp')
            self.temperature_read.emit(temperature)
            if not self._initial_loaded:
                values = {}
                for name in ('seg1_temp', 'seg1_power', 'seg1_heat_time', 'seg1_hold_time'):
                    if self._should_stop():
                        return False
                    values[name] = self._controller.read_register(name)
                self.initial_values.emit(values)
                self._initial_loaded = True
            with self._condition:
                was_online = self._online
                self._online = True
            if not was_online:
                self.connection_changed.emit(True)
                self.status_changed.emit(f'Connected to {self.port}', '')
            return True
        except Exception as exc:
            self._disconnect()
            if 'Cannot open' in str(exc):
                message = f'Cannot open {self.port}; retrying'
            elif 'No response' in str(exc):
                message = f'No response on {self.port}; retrying'
            else:
                message = f'Connection error on {self.port}; retrying'
            self.status_changed.emit(message, str(exc))
            return False

    def _execute(self, command):
        operations, description, priority_stop = command
        try:
            for kind, name, value in operations:
                with self._condition:
                    if self._stopping:
                        return False
                    if not priority_stop and self._commands and self._commands[0][2]:
                        self.status_changed.emit('Update interrupted by Stop', '')
                        return True
                if kind == 'register':
                    self._controller.write_register(name, value)
                elif kind == 'coil':
                    self._controller.write_coil(name, value)
                else:
                    raise ValueError(f'Unknown operation: {kind}')
            self.status_changed.emit(description, '')
            return True
        except Exception as exc:
            self._disconnect()
            self.status_changed.emit('Command not confirmed; reconnecting', str(exc))
            return False
        finally:
            with self._condition:
                self._in_flight = False
                self.busy_changed.emit(bool(self._commands))

    def run(self):
        next_poll = monotonic()
        self.status_changed.emit(f'Connecting to {self.port}...', '')
        try:
            while True:
                with self._condition:
                    while not self._stopping and not self._commands:
                        delay = next_poll - monotonic()
                        if delay <= 0:
                            break
                        self._condition.wait(delay)
                    if self._stopping:
                        break
                    command = self._commands.popleft() if self._commands else None
                    self._in_flight = command is not None
                if command is not None:
                    success = self._execute(command)
                    next_poll = monotonic() + (0 if success else self._retry_interval)
                else:
                    started = monotonic()
                    success = self._poll()
                    # Fixed healthy cadence, with no queue of missed polls.
                    next_poll = (max(started + self._poll_interval, monotonic() + 0.01)
                                 if success else monotonic() + self._retry_interval)
        finally:
            self._disconnect()
