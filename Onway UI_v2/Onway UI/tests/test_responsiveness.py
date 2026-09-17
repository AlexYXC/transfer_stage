import importlib
import os
import sys
import threading
import time
import unittest
from unittest.mock import patch

os.environ['QT_QPA_PLATFORM'] = 'offscreen'
sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.abspath(__file__))))

from PyQt5.QtCore import QEventLoop, QTimer
from PyQt5.QtWidgets import QApplication
from controller_worker import ControllerWorker

APP = QApplication.instance() or QApplication([])
APP.setQuitOnLastWindowClosed(False)


def spin(seconds):
    loop = QEventLoop()
    QTimer.singleShot(round(seconds * 1000), loop.quit)
    loop.exec_()


def until(predicate, timeout=3):
    deadline = time.monotonic() + timeout
    while not predicate():
        if time.monotonic() > deadline:
            raise AssertionError('Timed out waiting for condition')
        spin(0.01)


class DeviceState:
    def __init__(self, delay=0, fail_reads=False, fail_writes=False):
        self.delay = delay
        self.fail_reads = fail_reads
        self.fail_writes = fail_writes
        self.events = []
        self.threads = set()
        self.read_started = threading.Event()
        self.write_started = threading.Event()

    def factory(self, port):
        state = self
        state.threads.add(threading.get_ident())

        class Device:
            def read_register(self, name):
                state.threads.add(threading.get_ident())
                state.read_started.set()
                state.events.append(('read', name))
                time.sleep(state.delay)
                if state.fail_reads:
                    raise IOError('No response from mock controller')
                return {'current_temp': 23.4, 'seg1_temp': 250, 'seg1_power': 50,
                        'seg1_heat_time': 0, 'seg1_hold_time': 60}[name]

            def write_register(self, name, value):
                state.threads.add(threading.get_ident())
                state.events.append(('write', name, value))
                state.write_started.set()
                time.sleep(state.delay)
                if state.fail_writes:
                    raise IOError('Lost write acknowledgement')

            def write_coil(self, name, value):
                self.write_register(name, value)

            def close(self):
                state.threads.add(threading.get_ident())
                state.events.append(('close',))

        return Device()


class AsyncTests(unittest.TestCase):
    def setUp(self):
        self.workers = []
        self.windows = []

    def tearDown(self):
        for worker in self.workers:
            worker.stop()
        for window in self.windows:
            window.close()
        for worker in self.workers:
            until(lambda: not worker.isRunning())
        for window in self.windows:
            until(lambda: not window.worker.isRunning())
            window.close()
        spin(0.03)

    def worker(self, state):
        worker = ControllerWorker('MOCK', controller_factory=state.factory,
                                  poll_interval=0.05, retry_interval=0.12)
        self.workers.append(worker)
        worker.start()
        return worker

    def window(self, module, state):
        gui = importlib.import_module(module).TempControlGUI('MOCK', controller_factory=state.factory)
        self.windows.append(gui)
        gui.show()
        return gui

    def test_both_windows_stay_responsive_during_one_second_timeouts(self):
        for module in ('temp_control_gui', 'ui'):
            with self.subTest(module=module):
                state = DeviceState(delay=1, fail_reads=True)
                started = time.monotonic()
                gui = self.window(module, state)
                construction = time.monotonic() - started
                beats = []
                timer = QTimer()
                timer.setInterval(20)
                timer.timeout.connect(lambda: beats.append(time.monotonic()))
                timer.start()
                spin(1.25)
                timer.stop()
                gaps = [b-a for a, b in zip(beats, beats[1:])]
                self.assertLess(construction, 0.3)
                self.assertGreater(len(beats), 35)
                self.assertLess(max(gaps), 0.15)
                self.assertIn('No response', gui.status_label.text())
                self.assertFalse(gui.stop_button.isEnabled())
                self.assertTrue(all(not item.isEnabled() for item in gui.write_controls))
                print(f'{module}: opens in {construction*1000:.1f} ms; largest GUI heartbeat gap {max(gaps)*1000:.1f} ms during 1-second device timeout')
                gui.close()
                until(lambda: not gui.worker.isRunning())

    def test_all_device_access_has_one_background_thread(self):
        state = DeviceState(delay=0.02)
        worker = self.worker(state)
        until(lambda: worker._online)
        self.assertTrue(worker.submit([('register', 'seg1_temp', 260)], 'Saved'))
        until(lambda: ('write', 'seg1_temp', 260) in state.events)
        worker.stop()
        until(lambda: not worker.isRunning())
        self.assertEqual(len(state.threads), 1)
        self.assertNotIn(threading.get_ident(), state.threads)
        self.assertEqual(state.events[-1], ('close',))

    def test_unavailable_port_closes_client_and_has_actionable_error(self):
        from modbus_controller import ModbusController
        with patch('modbus_controller.ModbusSerialClient') as client_class:
            client_class.return_value.connect.return_value = False
            with self.assertRaisesRegex(ConnectionError, 'Cannot open MOCK'):
                ModbusController('MOCK')
            client_class.return_value.close.assert_called_once()
            self.assertEqual(client_class.call_args.kwargs['timeout'], 1)
            self.assertEqual(client_class.call_args.kwargs['retries'], 0)

    def test_stop_preempts_batch_without_a_command_backlog(self):
        state = DeviceState(delay=0.07)
        worker = self.worker(state)
        until(lambda: worker._online)
        self.assertTrue(worker.submit([('register', 'seg1_temp', 260),
                                       ('register', 'seg1_power', 30)], 'Saved'))
        until(state.write_started.is_set)
        for _ in range(20):
            self.assertFalse(worker.submit([('register', 'seg1_temp', 270)], 'Saved'))
        self.assertTrue(worker.submit([('coil', 'run', False)], 'Stopped', priority_stop=True))
        until(lambda: ('write', 'run', False) in state.events)
        worker.stop()
        until(lambda: not worker.isRunning())
        writes = [event for event in state.events if event[0] == 'write']
        self.assertEqual(writes, [('write', 'seg1_temp', 260), ('write', 'run', False)])

    def test_failed_write_is_not_replayed_after_reconnect(self):
        state = DeviceState(delay=0.01, fail_writes=True)
        worker = self.worker(state)
        until(lambda: worker._online)
        worker.submit([('register', 'seg1_temp', 260)], 'Saved')
        until(lambda: ('close',) in state.events)
        until(lambda: worker._online)
        spin(0.2)
        writes = [event for event in state.events if event[0] == 'write']
        self.assertEqual(writes, [('write', 'seg1_temp', 260)])

    def test_disconnected_polling_backs_off_and_recovers(self):
        state = DeviceState(fail_reads=True)
        worker = self.worker(state)
        spin(0.34)
        reads = [event for event in state.events if event[0] == 'read']
        self.assertLessEqual(len(reads), 4)
        self.assertFalse(worker.submit([('coil', 'run', True)], 'Started'))
        state.fail_reads = False
        until(lambda: worker._online)
        self.assertTrue(any(event == ('read', 'seg1_power') for event in state.events))

    def test_ui_writes_preserve_scaling_and_report_only_confirmed_success(self):
        for module in ('temp_control_gui', 'ui'):
            with self.subTest(module=module):
                state = DeviceState(delay=0.02)
                gui = self.window(module, state)
                until(lambda: gui._online)
                self.assertEqual(gui.seg1_temp.text(), '25')
                self.assertEqual(gui.seg1_power.text(), '50')
                self.assertEqual(gui.seg1_heat.text(), '0')
                self.assertEqual(gui.seg1_hold.text(), '60')
                gui.seg1_temp.setText('26.5')
                if module == 'temp_control_gui':
                    gui.write_seg1_temp_immediately()
                else:
                    gui.write_seg1()
                self.assertEqual(gui.status_label.text(), 'Sending command...')
                until(lambda: ('write', 'seg1_temp', 265) in state.events)
                until(lambda: not gui._busy)
                self.assertFalse(any(event[:2] == ('write', 'run') for event in state.events))
                gui.close()
                until(lambda: not gui.worker.isRunning())

    def test_close_during_io_does_not_block_the_gui(self):
        state = DeviceState(delay=0.7, fail_reads=True)
        gui = self.window('temp_control_gui', state)
        until(state.read_started.is_set)
        start = time.monotonic()
        gui.close()
        self.assertLess(time.monotonic()-start, 0.1)
        self.assertTrue(gui.worker.isRunning())
        until(lambda: not gui.worker.isRunning())
        until(lambda: not gui.isVisible())
        self.assertEqual(state.events[-1], ('close',))


if __name__ == '__main__':
    unittest.main(verbosity=2)

