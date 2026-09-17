#standard Python libraries
import sys, csv, time
from datetime import datetime

# PyQt5 imports for GUI 
from PyQt5.QtWidgets import (
    QApplication, QWidget, QVBoxLayout, QHBoxLayout, QGroupBox,
    QLabel, QLineEdit, QPushButton, QGridLayout, QSizePolicy,
    QFileDialog, QMessageBox, QCheckBox
)
from PyQt5.QtCore import QTimer, Qt, QPointF
from PyQt5.QtGui import QIntValidator, QFont, QPainter, QPen, QBrush

# Modbus controller, actual temperature controller
from modbus_controller import ModbusController


class CurveWidget(QWidget):
    """Lightweight live plot without requiring matplotlib/pyqtgraph."""

    # initiates the graphing object
    def __init__(self, parent=None):
        super().__init__(parent)
        self.actual, self.target, self.times = [], [], []
        self.setMinimumHeight(230)
        self.setAutoFillBackground(True)

    # updates the graph with current data
    def set_data(self, times, actual, target):
        self.times, self.actual, self.target = list(times), list(actual), list(target)
        self.update()

    # deletes the data
    def clear(self):
        self.times.clear(); self.actual.clear(); self.target.clear(); self.update()

    # how the graph looks
    def paintEvent(self, event):
        p = QPainter(self); p.setRenderHint(QPainter.Antialiasing)
        r = self.rect(); p.fillRect(r, QBrush(Qt.white))
        left, top, right, bottom = 55, 18, 15, 35
        w, h = max(1, r.width()-left-right), max(1, r.height()-top-bottom)
        p.setPen(QPen(Qt.black, 1)); p.drawRect(left, top, w, h)
        if not self.times: return
        xmin, xmax = self.times[0], max(self.times[-1], self.times[0]+1)
        vals = self.actual + self.target
        ymin, ymax = min(vals), max(vals)
        if ymax-ymin < 1: ymin -= 1; ymax += 1
        else: pad=(ymax-ymin)*.08; ymin-=pad; ymax+=pad
        def pt(x,y): return QPointF(left+(x-xmin)/(xmax-xmin)*w, top+h-(y-ymin)/(ymax-ymin)*h)
        p.setPen(QPen(Qt.gray, 1, Qt.DashLine))
        for i in range(1,5):
            yy=top+h*i/5; p.drawLine(left, int(yy), left+w, int(yy))
        p.setPen(QPen(Qt.blue, 2)); self._line(p, self.times, self.actual, pt)
        p.setPen(QPen(Qt.red, 2, Qt.DashLine)); self._line(p, self.times, self.target, pt)
        p.setPen(Qt.black); p.drawText(8, 18, f"{ymax:.1f}"); p.drawText(8, top+h, f"{ymin:.1f}")
        p.drawText(left, r.height()-8, "Time (s)")
        p.setPen(QPen(Qt.blue, 2)); p.drawLine(r.width()-125, 14, r.width()-105, 14); p.setPen(Qt.black); p.drawText(r.width()-100, 18, "Actual")
        p.setPen(QPen(Qt.red, 2, Qt.DashLine)); p.drawLine(r.width()-55, 14, r.width()-35, 14); p.setPen(Qt.black); p.drawText(r.width()-30, 18, "Target")

    # helper function for drawing lines between dots
    def _line(self, p, xs, ys, fn):
        if len(xs) < 2: return
        for i in range(1, len(xs)): p.drawLine(fn(xs[i-1], ys[i-1]), fn(xs[i], ys[i]))


class TempControlGUI(QWidget):
    """Main temperature controller module"""

    # initiates the controller and port
    def __init__(self, port='COM5'):
        super().__init__(); self.modbus=ModbusController(port); self.power_manual_override=False
        self.recording=False; self.record_start=None; self.samples=[]
        self.init_ui(); self.load_initial_values()
        self.timer=QTimer(self); self.timer.timeout.connect(self.update_current_temp); self.timer.start(300)

    def init_ui(self):
        self.setWindowTitle("Onway Temperature Controller")
        base_font=QFont(); base_font.setPointSize(13); self.setFont(base_font)
        main=QVBoxLayout(self); main.setContentsMargins(16,10,16,14); main.setSpacing(10)
        top=QHBoxLayout(); self.status_label=QLabel("Ready"); self.cur_label=QLabel("Current Temperature: --.- °C"); self.cur_label.setFont(QFont("",14)); top.addWidget(self.status_label); top.addStretch(1); top.addWidget(self.cur_label); main.addLayout(top)
        seg=QGroupBox("Workmanship 1 — Segment 1"); seg.setFont(QFont("",14,QFont.Bold)); grid=QGridLayout(); grid.setContentsMargins(14,14,14,14); grid.setVerticalSpacing(16); grid.setHorizontalSpacing(14)
        temp_val=QIntValidator(0,10000,self); time_val=QIntValidator(0,100000000,self); pct_val=QIntValidator(0,100,self)
        def pm(txt): b=QPushButton(txt); b.setFixedSize(52,38); b.setFont(QFont("",14)); return b
        def edit(width=170): e=QLineEdit(); e.setFixedSize(width,38); e.setFont(QFont("",14)); return e
        lf=QFont("",14)
        grid.addWidget(QLabel("Target Temp (°C)"),0,0); self.seg1_temp=edit(); self.seg1_temp.setValidator(temp_val); self.seg1_temp.returnPressed.connect(self.write_seg1_temp_immediately); grid.addWidget(self.seg1_temp,0,1); b=pm("+"); b.clicked.connect(self.increase_temp); grid.addWidget(b,0,2); b=pm("-"); b.clicked.connect(self.decrease_temp); grid.addWidget(b,0,3)
        grid.addWidget(QLabel("Heating Time (min)"),1,0); self.seg1_heat=edit(); self.seg1_heat.setText("0"); self.seg1_heat.setValidator(time_val); self.seg1_heat.returnPressed.connect(self.write_seg1_heat_time_immediately); grid.addWidget(self.seg1_heat,1,1,1,3)
        grid.addWidget(QLabel("Holding Time (min)"),2,0); self.seg1_hold=edit(); self.seg1_hold.setText("9999"); self.seg1_hold.setValidator(time_val); self.seg1_hold.returnPressed.connect(self.write_seg1_hold_time_immediately); grid.addWidget(self.seg1_hold,2,1,1,3)
        grid.addWidget(QLabel("Power Limit (%)"),3,0); self.seg1_power=edit(); self.seg1_power.setValidator(pct_val); self.seg1_power.returnPressed.connect(self.write_seg1_power_immediately_manual); grid.addWidget(self.seg1_power,3,1); b=pm("+"); b.clicked.connect(self.increase_power); grid.addWidget(b,3,2); b=pm("-"); b.clicked.connect(self.decrease_power); grid.addWidget(b,3,3)
        seg.setLayout(grid); main.addWidget(seg)
        main.addWidget(QLabel("Temperature Curve")); self.plot=CurveWidget(); main.addWidget(self.plot)
        tools=QHBoxLayout(); self.record_btn=QPushButton("Start Recording"); self.stop_record_btn=QPushButton("Stop Recording"); self.export_btn=QPushButton("Export CSV"); self.clear_btn=QPushButton("Clear Curve")
        self.stop_record_btn.setEnabled(False); self.record_btn.clicked.connect(self.start_recording); self.stop_record_btn.clicked.connect(self.stop_recording); self.export_btn.clicked.connect(self.export_csv); self.clear_btn.clicked.connect(self.clear_data)
        for x in (self.record_btn,self.stop_record_btn,self.export_btn,self.clear_btn): tools.addWidget(x)
        main.addLayout(tools)
        ctrl=QHBoxLayout(); start=QPushButton("Start"); stop=QPushButton("Stop"); start.setFixedSize(150,42); stop.setFixedSize(150,42); start.clicked.connect(lambda:self.write_run(True)); stop.clicked.connect(lambda:self.write_run(False)); ctrl.addStretch(1); ctrl.addWidget(start); ctrl.addWidget(stop); ctrl.addStretch(1); main.addLayout(ctrl)
        self.resize(760,700)

    def set_status(self,msg): self.status_label.setText(msg)
    def load_initial_values(self):
        try:
            self.seg1_temp.setText(f"{self.modbus.read_register('seg1_temp')/10:g}"); self.seg1_power.setText(str(int(self.modbus.read_register('seg1_power')))); self.power_manual_override=True; self.set_status("Loaded values")
        except Exception as e: self.set_status(f"Init error: {e}")
    def update_current_temp(self):
        try:
            t=float(self.modbus.read_register('current_temp')); self.cur_label.setText(f"Current Temperature: {t:.1f} °C")
            if not self.power_manual_override and not self.seg1_power.hasFocus():
                target=float(self.seg1_temp.text() or 0); diff=abs(t-target); self.seg1_power.setText("10" if diff<=2 else "50" if diff<=10 else "100")
            target=float(self.seg1_temp.text() or 0); elapsed=(time.monotonic()-self.record_start) if self.record_start else (self.samples[-1][0] if self.samples else 0)
            if self.recording: self.samples.append((elapsed,t,target)); self.plot.set_data([x[0] for x in self.samples],[x[1] for x in self.samples],[x[2] for x in self.samples])
            self.set_status("Recording" if self.recording else "OK")
        except Exception as e: self.set_status(f"Read error: {e}")
    def start_recording(self): self.samples=[]; self.record_start=time.monotonic(); self.recording=True; self.record_btn.setEnabled(False); self.stop_record_btn.setEnabled(True); self.plot.clear(); self.set_status("Recording")
    def stop_recording(self): self.recording=False; self.record_start=None; self.record_btn.setEnabled(True); self.stop_record_btn.setEnabled(False); self.set_status("Recording stopped")
    def clear_data(self): self.samples=[]; self.record_start=time.monotonic() if self.recording else None; self.plot.clear()
    def export_csv(self):
        if not self.samples: QMessageBox.information(self,"Export CSV","No recorded data to export."); return
        path,_=QFileDialog.getSaveFileName(self,"Export Temperature Data",f"temperature_{datetime.now():%Y%m%d_%H%M%S}.csv","CSV Files (*.csv)")
        if not path:return
        try:
            with open(path,"w",newline="") as f:
                w=csv.writer(f); w.writerow(["Time (s)","Actual Temperature (C)","Target Temperature (C)"]); w.writerows(self.samples)
            QMessageBox.information(self,"Export CSV",f"Saved {len(self.samples)} samples to:\n{path}")
        except Exception as e: QMessageBox.critical(self,"Export Error",str(e))
    def write_seg1_temp_immediately(self): self.modbus.write_register('seg1_temp',int(round(float(self.seg1_temp.text() or 0)*10)))
    def write_seg1_heat_time_immediately(self): self.modbus.write_register('seg1_heat_time',int(self.seg1_heat.text() or 0))
    def write_seg1_hold_time_immediately(self): self.modbus.write_register('seg1_hold_time',int(self.seg1_hold.text() or 0))
    def write_seg1_power_immediately_manual(self): self.power_manual_override=True; val=max(0,min(100,int(self.seg1_power.text() or 0))); self.seg1_power.setText(str(val)); self.modbus.write_register('seg1_power',val)
    def write_run(self,start): self.modbus.write_coil('run',start); self.set_status("Started" if start else "Stopped")
    def increase_temp(self): self.seg1_temp.setText(str(float(self.seg1_temp.text() or 0)+1)); self.write_seg1_temp_immediately()
    def decrease_temp(self): self.seg1_temp.setText(str(max(0,float(self.seg1_temp.text() or 0)-1))); self.write_seg1_temp_immediately()
    def increase_power(self): self.power_manual_override=True; self.seg1_power.setText(str(min(100,int(self.seg1_power.text() or 0)+10))); self.write_seg1_power_immediately_manual()
    def decrease_power(self): self.power_manual_override=True; self.seg1_power.setText(str(max(0,int(self.seg1_power.text() or 0)-10))); self.write_seg1_power_immediately_manual()

if __name__ == "__main__":
    app=QApplication(sys.argv); gui=TempControlGUI(port="COM5"); gui.show(); sys.exit(app.exec_())
