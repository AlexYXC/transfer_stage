import sys
from PyQt5.QtWidgets import (
    QApplication, QVBoxLayout, QHBoxLayout, QGroupBox,
    QLabel, QLineEdit, QPushButton
)
from PyQt5.QtGui import QFont, QIntValidator
from controller_window import ControllerWindow

class TempControlGUI(ControllerWindow):
    def __init__(self, port='COM5', *, controller_factory=None):
        super().__init__()
        self.init_ui()
        self.start_controller(port, controller_factory)

    def init_ui(self):
        self.setWindowTitle("Onway Temperature Controller")

        # Set a larger default font for the entire window
        font = QFont()
        font.setPointSize(12)
        self.setFont(font)

        main_layout = QVBoxLayout(self)
        main_layout.setContentsMargins(20, 20, 20, 20)
        main_layout.setSpacing(20)

        self.status_label = QLabel('Connecting...')
        self.status_label.setWordWrap(True)
        main_layout.addWidget(self.status_label)

        # Current Temperature Display
        self.cur_label = QLabel("Current Temperature: --.- °C")
        main_layout.addWidget(self.cur_label)

        # Segment 1 Settings
        seg1_box = QGroupBox("Segment 1 Settings")
        seg1_layout = QVBoxLayout()
        seg1_layout.setSpacing(15)

        # Target Temp with +/- buttons
        temp_layout = QHBoxLayout()
        self.seg1_temp = QLineEdit()
        lbl_target = QLabel("Target Temperature (°C):")
        temp_layout.addWidget(lbl_target)
        self.seg1_temp.setPlaceholderText("Target Temperature (°C)")
        self.seg1_temp.setText("0")  # Default value
        self.seg1_temp.setFixedWidth(80)
        self.seg1_temp.setValidator(QIntValidator(0, 6553, self))
        btn_temp_inc = QPushButton("+")
        btn_temp_inc.setFixedWidth(30)
        btn_temp_inc.clicked.connect(self.increase_temp)
        btn_temp_dec = QPushButton("-")
        btn_temp_dec.setFixedWidth(30)
        btn_temp_dec.clicked.connect(self.decrease_temp)
        temp_layout.addWidget(self.seg1_temp)
        temp_layout.addWidget(btn_temp_inc)
        temp_layout.addWidget(btn_temp_dec)
        seg1_layout.addLayout(temp_layout)

        # Heating Time (default 0)
        seg1_heat_layout = QHBoxLayout()
        lbl_heat = QLabel("Heating Time (s):")
        seg1_heat_layout.addWidget(lbl_heat)
        self.seg1_heat = QLineEdit("0")
        self.seg1_heat.setPlaceholderText("Heating Time (s)")
        self.seg1_heat.setValidator(QIntValidator(0, 65535, self))
        seg1_heat_layout.addWidget(self.seg1_heat)
        seg1_layout.addLayout(seg1_heat_layout)

        # Holding Time (default 9999)
        seg1_hold_layout = QHBoxLayout()
        lbl_hold = QLabel("Holding Time (s):")
        seg1_hold_layout.addWidget(lbl_hold)
        self.seg1_hold = QLineEdit("9999")
        self.seg1_hold.setPlaceholderText("Holding Time (s)")
        self.seg1_hold.setValidator(QIntValidator(0, 65535, self))
        seg1_hold_layout.addWidget(self.seg1_hold)
        seg1_layout.addLayout(seg1_hold_layout)

        # Power Limit (default 100)\
        seg1_power_layout = QHBoxLayout()
        lbl_power = QLabel("Power Limit (%):")
        seg1_power_layout.addWidget(lbl_power)
        self.seg1_power = QLineEdit("100")
        self.seg1_power.setPlaceholderText("Power Limit (%)")
        self.seg1_power.setValidator(QIntValidator(0, 100, self))
        seg1_power_layout.addWidget(self.seg1_power)
        seg1_layout.addLayout(seg1_power_layout)

        # Update Values button
        btn_seg1 = QPushButton("Update Values")
        btn_seg1.clicked.connect(self.write_seg1)
        seg1_layout.addWidget(btn_seg1)

        seg1_box.setLayout(seg1_layout)
        main_layout.addWidget(seg1_box)

        # Control Buttons (Start/Stop)
        ctrl_layout = QHBoxLayout()
        ctrl_layout.setSpacing(15)
        btn_start = QPushButton("Start")
        btn_start.clicked.connect(lambda: self.write_run(True))
        ctrl_layout.addWidget(btn_start)
        btn_stop = QPushButton("Stop")
        btn_stop.clicked.connect(lambda: self.write_run(False))
        ctrl_layout.addWidget(btn_stop)
        main_layout.addLayout(ctrl_layout)

        self.write_controls = [seg1_box, btn_start]
        self.stop_button = btn_stop

        self.resize(450, 350)

    def load_initial_values(self, values):
        self.seg1_temp.setText(f"{values['seg1_temp'] / 10:g}")
        self.seg1_power.setText(str(int(values['seg1_power'])))
        self.seg1_heat.setText(str(int(values['seg1_heat_time'])))
        self.seg1_hold.setText(str(int(values['seg1_hold_time'])))

    def update_current_temp(self, temperature):
        self._last_temperature = temperature
        self.cur_label.setText(f"Current Temperature: {temperature:.1f} °C")
        # Preserve this interface's suggested power limit without interrupting
        # a manual edit or changing the values of an outstanding command.
        if not self.seg1_power.hasFocus() and not self._busy:
            try:
                target = float(self.seg1_temp.text() or '0')
            except ValueError:
                target = 0.0
            difference = abs(temperature - target)
            self.seg1_power.setText('10' if difference <= 2 else '50' if difference <= 10 else '100')

    def write_seg1(self):
        try:
            t = int(round(float(self.seg1_temp.text()) * 10))
            ht = int(self.seg1_heat.text())
            hold = int(self.seg1_hold.text())
            pl = int(self.seg1_power.text())
            if not all(0 <= v <= 65535 for v in (t, ht, hold)) or not 0 <= pl <= 100:
                raise ValueError('Temperature/time must fit in a register; power must be 0–100%.')
        except (ValueError, OverflowError) as exc:
            self.set_status('Invalid segment values', str(exc))
            return
        self.submit_write([
            ('register', 'seg1_temp', t),
            ('register', 'seg1_heat_time', ht),
            ('register', 'seg1_hold_time', hold),
            ('register', 'seg1_power', pl),
        ], 'Segment values saved')

    def increase_temp(self):
        try:
            val = int(self.seg1_temp.text() or "0")
        except ValueError:
            val = 0
        val += 1
        self.seg1_temp.setText(str(val))

    def decrease_temp(self):
        try:
            val = int(self.seg1_temp.text() or "0")
        except ValueError:
            val = 0
        val = max(0, val - 1)
        self.seg1_temp.setText(str(val))

if __name__ == "__main__":
    app = QApplication(sys.argv)
    gui = TempControlGUI(port="COM5")
    gui.show()
    sys.exit(app.exec_())
