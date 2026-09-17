# import sys
# from PyQt5.QtWidgets import (
#     QApplication, QVBoxLayout, QHBoxLayout, QGroupBox,
#     QLabel, QLineEdit, QPushButton, QGridLayout, QSizePolicy
# )
# from PyQt5.QtGui import QIntValidator, QFont
# from controller_window import ControllerWindow


# class TempControlGUI(ControllerWindow):
#     def __init__(self, port='COM5', *, controller_factory=None):
#         super().__init__()
#         self.power_manual_override = False
#         self.init_ui()
#         self.start_controller(port, controller_factory)

#     def init_ui(self):
#         self.setWindowTitle("Onway Temperature Controller")

#         # ---- Global font scaling (this is the key change) ----
#         base_font = QFont()
#         base_font.setPointSize(13)   # ← increase base font
#         self.setFont(base_font)

#         main = QVBoxLayout(self)
#         main.setContentsMargins(16, 10, 16, 14)
#         main.setSpacing(10)

#         # ---- Top row ----
#         top_row = QHBoxLayout()
#         top_row.setSpacing(12)

#         self.status_label = QLabel("Connecting...")
#         self.status_label.setFont(QFont("", 11))  # slightly smaller than main
#         self.status_label.setSizePolicy(QSizePolicy.Expanding, QSizePolicy.Preferred)
#         self.status_label.setWordWrap(True)

#         self.cur_label = QLabel("Current Temperature: --.- °C")
#         self.cur_label.setFont(QFont("", 14))     # slightly emphasized
#         self.cur_label.setSizePolicy(QSizePolicy.Expanding, QSizePolicy.Fixed)

#         top_row.addWidget(self.status_label)
#         top_row.addStretch(1)
#         top_row.addWidget(self.cur_label)
#         main.addLayout(top_row)

#         # ================= Segment Box =================
#         seg_box = QGroupBox("Workmanship 1 — Segment 1")
#         seg_box.setFont(QFont("", 14, QFont.Bold))
#         seg_box.setSizePolicy(QSizePolicy.Expanding, QSizePolicy.Expanding)

#         grid = QGridLayout()
#         grid.setContentsMargins(14, 14, 14, 14)
#         grid.setVerticalSpacing(16)
#         grid.setHorizontalSpacing(14)

#         # Validators
#         temp_val = QIntValidator(0, 10000, self)
#         time_val = QIntValidator(0, 65535, self)
#         pct_val = QIntValidator(0, 100, self)

#         def pm_button(txt):
#             b = QPushButton(txt)
#             b.setFixedSize(52, 38)        # slightly bigger
#             b.setFont(QFont("", 14))
#             return b

#         def big_edit(width=170):
#             e = QLineEdit()
#             e.setFixedSize(width, 38)     # taller for readability
#             e.setFont(QFont("", 14))
#             return e

#         label_font = QFont("", 14)

#         # Row 0: Target Temp
#         lbl_temp = QLabel("Target Temp (°C)")
#         lbl_temp.setFont(label_font)

#         self.seg1_temp = big_edit()
#         self.seg1_temp.setValidator(temp_val)
#         self.seg1_temp.returnPressed.connect(self.write_seg1_temp_immediately)

#         btn_temp_inc = pm_button("+")
#         btn_temp_dec = pm_button("-")
#         btn_temp_inc.clicked.connect(self.increase_temp)
#         btn_temp_dec.clicked.connect(self.decrease_temp)

#         grid.addWidget(lbl_temp, 0, 0)
#         grid.addWidget(self.seg1_temp, 0, 1)
#         grid.addWidget(btn_temp_inc, 0, 2)
#         grid.addWidget(btn_temp_dec, 0, 3)

#         # Row 1: Heating Time
#         lbl_heat = QLabel("Heating Time (s)")
#         lbl_heat.setFont(label_font)

#         self.seg1_heat = big_edit()
#         self.seg1_heat.setText("0")
#         self.seg1_heat.setValidator(time_val)
#         self.seg1_heat.returnPressed.connect(self.write_seg1_heat_time_immediately)

#         grid.addWidget(lbl_heat, 1, 0)
#         grid.addWidget(self.seg1_heat, 1, 1, 1, 3)

#         # Row 2: Holding Time
#         lbl_hold = QLabel("Holding Time (s)")
#         lbl_hold.setFont(label_font)

#         self.seg1_hold = big_edit()
#         self.seg1_hold.setText("9999")
#         self.seg1_hold.setValidator(time_val)
#         self.seg1_hold.returnPressed.connect(self.write_seg1_hold_time_immediately)

#         grid.addWidget(lbl_hold, 2, 0)
#         grid.addWidget(self.seg1_hold, 2, 1, 1, 3)

#         # Row 3: Power Limit
#         lbl_power = QLabel("Power Limit (%)")
#         lbl_power.setFont(label_font)

#         self.seg1_power = big_edit()
#         self.seg1_power.setValidator(pct_val)
#         self.seg1_power.returnPressed.connect(self.write_seg1_power_immediately_manual)

#         btn_power_inc = pm_button("+")
#         btn_power_dec = pm_button("-")
#         btn_power_inc.clicked.connect(self.increase_power)
#         btn_power_dec.clicked.connect(self.decrease_power)

#         grid.addWidget(lbl_power, 3, 0)
#         grid.addWidget(self.seg1_power, 3, 1)
#         grid.addWidget(btn_power_inc, 3, 2)
#         grid.addWidget(btn_power_dec, 3, 3)

#         seg_box.setLayout(grid)
#         main.addWidget(seg_box, stretch=1)

#         # ---- Start / Stop ----
#         ctrl = QHBoxLayout()
#         ctrl.setSpacing(18)

#         btn_start = QPushButton("Start")
#         btn_stop = QPushButton("Stop")
#         btn_start.setFixedSize(150, 42)
#         btn_stop.setFixedSize(150, 42)
#         btn_start.setFont(QFont("", 14))
#         btn_stop.setFont(QFont("", 14))

#         btn_start.clicked.connect(lambda: self.write_run(True))
#         btn_stop.clicked.connect(lambda: self.write_run(False))

#         ctrl.addStretch(1)
#         ctrl.addWidget(btn_start)
#         ctrl.addWidget(btn_stop)
#         ctrl.addStretch(1)
#         main.addLayout(ctrl)

#         self.write_controls = [seg_box, btn_start]
#         self.stop_button = btn_stop

#         self.resize(680, 400)

#     def load_initial_values(self, values):
#         self.seg1_temp.setText(f"{values['seg1_temp'] / 10:g}")
#         self.seg1_power.setText(str(int(values['seg1_power'])))
#         self.seg1_heat.setText(str(int(values['seg1_heat_time'])))
#         self.seg1_hold.setText(str(int(values['seg1_hold_time'])))
#         self.power_manual_override = True

#     def update_current_temp(self, temperature):
#         self._last_temperature = temperature
#         self.cur_label.setText(f"Current Temperature: {temperature:.1f} °C")

#     def _write_value(self, name, field, *, scale=1):
#         try:
#             value = int(round(float(field.text()) * scale))
#             if not 0 <= value <= 65535:
#                 raise ValueError('Value must fit in one controller register (0–65535).')
#         except (ValueError, OverflowError) as exc:
#             self.set_status('Invalid value', str(exc))
#             return
#         self.submit_write([('register', name, value)], 'Value saved')

#     def write_seg1_temp_immediately(self):
#         self._write_value('seg1_temp', self.seg1_temp, scale=10)

#     def write_seg1_heat_time_immediately(self):
#         self._write_value('seg1_heat_time', self.seg1_heat)

#     def write_seg1_hold_time_immediately(self):
#         self._write_value('seg1_hold_time', self.seg1_hold)

#     def write_seg1_power_immediately_manual(self):
#         self.power_manual_override = True
#         try:
#             val = max(0, min(100, int(self.seg1_power.text())))
#         except ValueError:
#             self.set_status('Enter a power limit from 0 to 100')
#             return
#         self.seg1_power.setText(str(val))
#         self._write_value('seg1_power', self.seg1_power)

#     def increase_temp(self):
#         self.seg1_temp.setText(str(float(self.seg1_temp.text() or 0) + 1))
#         self.write_seg1_temp_immediately()

#     def decrease_temp(self):
#         self.seg1_temp.setText(str(max(0, float(self.seg1_temp.text() or 0) - 1)))
#         self.write_seg1_temp_immediately()

#     def increase_power(self):
#         self.power_manual_override = True
#         self.seg1_power.setText(str(min(100, int(self.seg1_power.text() or 0) + 10)))
#         self.write_seg1_power_immediately_manual()

#     def decrease_power(self):
#         self.power_manual_override = True
#         self.seg1_power.setText(str(max(0, int(self.seg1_power.text() or 0) - 10)))
#         self.write_seg1_power_immediately_manual()


# if __name__ == "__main__":
#     app = QApplication(sys.argv)
#     gui = TempControlGUI(port="COM5")
#     gui.show()
#     sys.exit(app.exec_())

