"""Shared asynchronous connection and window shutdown behavior."""

from PyQt5.QtWidgets import QWidget

from controller_worker import ControllerWorker


class ControllerWindow(QWidget):
    def start_controller(self, port, controller_factory=None):
        self._online = False
        self._busy = False
        self._closing = False
        self._last_temperature = None
        self.worker = ControllerWorker(port, self, controller_factory=controller_factory)
        self.worker.temperature_read.connect(self.update_current_temp)
        self.worker.initial_values.connect(self.load_initial_values)
        self.worker.connection_changed.connect(self._connection_changed)
        self.worker.busy_changed.connect(self._busy_changed)
        self.worker.status_changed.connect(self.set_status)
        self.worker.finished.connect(self._worker_finished)
        self._update_controls()
        self.worker.start()

    def set_status(self, message, detail=''):
        if not self._closing:
            self.status_label.setText(message)
            self.status_label.setToolTip(detail or message)

    def _connection_changed(self, online):
        self._online = online
        self._update_controls()
        if not online and self._last_temperature is not None:
            self.cur_label.setText(f'Last Temperature: {self._last_temperature:.1f} °C (offline)')

    def _busy_changed(self, busy):
        self._busy = busy
        self._update_controls()

    def _update_controls(self):
        for control in self.write_controls:
            control.setEnabled(self._online and not self._busy and not self._closing)
        # Stop stays available during an outstanding command.
        self.stop_button.setEnabled(self._online and not self._closing)

    def submit_write(self, operations, description, *, priority_stop=False):
        if self.worker.submit(operations, description, priority_stop=priority_stop):
            self.set_status('Sending command...')
        else:
            self.set_status('Controller unavailable or command still pending')

    def write_run(self, start):
        self.submit_write([('coil', 'run', start)],
                          'Start command acknowledged' if start else 'Stop command acknowledged',
                          priority_stop=not start)

    def closeEvent(self, event):
        if self.worker.isRunning():
            self._closing = True
            self.status_label.setText('Closing connection...')
            self._update_controls()
            self.worker.stop()
            event.ignore()
        else:
            event.accept()

    def _worker_finished(self):
        if self._closing:
            self.close()
