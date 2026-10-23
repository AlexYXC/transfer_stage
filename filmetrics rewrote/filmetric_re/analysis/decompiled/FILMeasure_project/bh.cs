using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class bh : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private GroupBox m_c;

	[CompilerGenerated]
	private TableLayoutPanel m_d;

	[CompilerGenerated]
	private hy m_e;

	[CompilerGenerated]
	private Label m_f;

	[CompilerGenerated]
	private hy m_g;

	[CompilerGenerated]
	private Label m_h;

	[CompilerGenerated]
	private Label m_i;

	[CompilerGenerated]
	private Label m_j;

	[CompilerGenerated]
	private hy m_k;

	[CompilerGenerated]
	private Label m_l;

	[CompilerGenerated]
	private hy m_m;

	[CompilerGenerated]
	private CheckBox m_n;

	[CompilerGenerated]
	private Label m_o;

	[CompilerGenerated]
	private Label m_p;

	[CompilerGenerated]
	private CheckBox m_q;

	[CompilerGenerated]
	private CheckBox m_r;

	[CompilerGenerated]
	private ErrorProvider m_s;

	[CompilerGenerated]
	private TableLayoutPanel m_t;

	[CompilerGenerated]
	private TableLayoutPanel m_u;

	[CompilerGenerated]
	private TableLayoutPanel m_v;

	[CompilerGenerated]
	private Button m_w;

	[CompilerGenerated]
	private Button m_x;

	[CompilerGenerated]
	private TableLayoutPanel m_y;

	[CompilerGenerated]
	private Label m_z;

	[CompilerGenerated]
	private Label m_aa;

	[CompilerGenerated]
	private TableLayoutPanel m_ab;

	[CompilerGenerated]
	private Label m_ac;

	[CompilerGenerated]
	private Label m_ad;

	[CompilerGenerated]
	private TableLayoutPanel m_ae;

	[CompilerGenerated]
	private Label m_af;

	[CompilerGenerated]
	private Label m_ag;

	[CompilerGenerated]
	private CheckBox m_ah;

	[CompilerGenerated]
	private hy m_ai;

	[CompilerGenerated]
	private Label m_aj;

	[CompilerGenerated]
	private RadioButton m_ak;

	[CompilerGenerated]
	private RadioButton m_al;

	[CompilerGenerated]
	private TableLayoutPanel m_am;

	[CompilerGenerated]
	private CheckBox m_an;

	[CompilerGenerated]
	private CheckBox m_ao;

	[CompilerGenerated]
	private CheckBox m_ap;

	[CompilerGenerated]
	private TableLayoutPanel m_aq;

	[CompilerGenerated]
	private Label m_ar;

	[CompilerGenerated]
	private Label m_as;

	[CompilerGenerated]
	private TableLayoutPanel m_at;

	[CompilerGenerated]
	private Label m_au;

	[CompilerGenerated]
	private Label m_av;

	[CompilerGenerated]
	private Label m_aw;

	[CompilerGenerated]
	private Label m_ax;

	[CompilerGenerated]
	private TableLayoutPanel m_ay;

	[CompilerGenerated]
	private TableLayoutPanel m_az;

	[CompilerGenerated]
	private TableLayoutPanel m_a0;

	[CompilerGenerated]
	private Label m_a1;

	[CompilerGenerated]
	private Label m_a2;

	[CompilerGenerated]
	private TableLayoutPanel m_a3;

	[CompilerGenerated]
	private Label m_a4;

	[CompilerGenerated]
	private Label m_a5;

	[CompilerGenerated]
	private CheckBox m_a6;

	private const string m_a7 = "DialogLightSource";

	private f1 m_a8;

	private fz m_a9;

	private Guid m_ba;

	private int m_bb;

	private bool m_bc;

	private int m_bd;

	private g9[] m_be;

	private bool m_bf;

	private bool m_bg;

	private bool m_bh;

	private string bi;

	private string bj;

	[CompilerGenerated]
	private r.d bk;

	[CompilerGenerated]
	private System.Timers.Timer bl;

	[CompilerGenerated]
	private r.d bm;

	private const string bn = "0.0";

	public bh()
	{
		base.FormClosing += a;
		a(new r.d());
		b(new r.d());
		h();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.m_a != null)
			{
				this.m_a.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void h()
	{
		this.m_a = new Container();
		a(new Button());
		a(new GroupBox());
		a(new TableLayoutPanel());
		e(new hy());
		n(new Label());
		a(new RadioButton());
		b(new RadioButton());
		a(new hy());
		a(new Label());
		b(new hy());
		b(new Label());
		c(new Label());
		d(new Label());
		c(new hy());
		e(new Label());
		d(new hy());
		a(new CheckBox());
		f(new Label());
		g(new Label());
		b(new CheckBox());
		c(new CheckBox());
		a(new ErrorProvider(this.m_a));
		b(new TableLayoutPanel());
		h(new TableLayoutPanel());
		h(new CheckBox());
		n(new TableLayoutPanel());
		w(new Label());
		x(new Label());
		l(new TableLayoutPanel());
		j(new TableLayoutPanel());
		q(new Label());
		r(new Label());
		e(new CheckBox());
		i(new TableLayoutPanel());
		o(new Label());
		p(new Label());
		f(new CheckBox());
		g(new CheckBox());
		k(new TableLayoutPanel());
		c(new TableLayoutPanel());
		g(new TableLayoutPanel());
		l(new Label());
		m(new Label());
		d(new CheckBox());
		s(new Label());
		t(new Label());
		m(new TableLayoutPanel());
		u(new Label());
		v(new Label());
		e(new TableLayoutPanel());
		h(new Label());
		i(new Label());
		f(new TableLayoutPanel());
		j(new Label());
		k(new Label());
		d(new TableLayoutPanel());
		c(new Button());
		b(new Button());
		j().SuspendLayout();
		k().SuspendLayout();
		((ISupportInitialize)z()).BeginInit();
		aa().SuspendLayout();
		at().SuspendLayout();
		ba().SuspendLayout();
		a6().SuspendLayout();
		a0().SuspendLayout();
		ax().SuspendLayout();
		a5().SuspendLayout();
		ab().SuspendLayout();
		al().SuspendLayout();
		a7().SuspendLayout();
		af().SuspendLayout();
		ai().SuspendLayout();
		ac().SuspendLayout();
		SuspendLayout();
		i().Anchor = AnchorStyles.None;
		i().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		i().Location = new Point(4, 4);
		i().Margin = new Padding(4);
		i().Name = "ButtonOK";
		i().Size = new Size(89, 28);
		i().TabIndex = 0;
		i().Text = "OK";
		j().Anchor = AnchorStyles.None;
		j().AutoSize = true;
		j().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		j().Controls.Add(k());
		j().Controls.Add(u());
		j().Location = new Point(81, 3);
		j().Name = "GroupBoxLampAndLeds";
		j().Size = new Size(248, 249);
		j().TabIndex = 1;
		j().TabStop = false;
		j().Visible = false;
		k().AutoSize = true;
		k().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		k().ColumnCount = 2;
		k().ColumnStyles.Add(new ColumnStyle());
		k().ColumnStyles.Add(new ColumnStyle());
		k().Controls.Add(ap(), 1, 7);
		k().Controls.Add(aq(), 0, 7);
		k().Controls.Add(ar(), 0, 6);
		k().Controls.Add(@as(), 0, 0);
		k().Controls.Add(l(), 1, 5);
		k().Controls.Add(m(), 0, 5);
		k().Controls.Add(n(), 1, 4);
		k().Controls.Add(o(), 0, 4);
		k().Controls.Add(p(), 0, 2);
		k().Controls.Add(q(), 1, 1);
		k().Controls.Add(r(), 1, 2);
		k().Controls.Add(s(), 0, 3);
		k().Controls.Add(t(), 1, 3);
		k().Location = new Point(18, 23);
		k().Margin = new Padding(3, 3, 15, 0);
		k().Name = "TableLayoutPanelSetpoints";
		k().RowCount = 8;
		k().RowStyles.Add(new RowStyle());
		k().RowStyles.Add(new RowStyle());
		k().RowStyles.Add(new RowStyle());
		k().RowStyles.Add(new RowStyle());
		k().RowStyles.Add(new RowStyle());
		k().RowStyles.Add(new RowStyle());
		k().RowStyles.Add(new RowStyle());
		k().RowStyles.Add(new RowStyle());
		k().Size = new Size(212, 208);
		k().TabIndex = 2;
		k().Visible = false;
		ap().Anchor = AnchorStyles.None;
		ap().Enabled = false;
		ap().f(A_0: false);
		ap().Location = new Point(128, 183);
		ap().Name = "TextBoxNumMasterLevel";
		ap().e(A_0: false);
		ap().Size = new Size(49, 22);
		ap().TabIndex = 14;
		aq().Anchor = AnchorStyles.None;
		aq().AutoSize = true;
		aq().Location = new Point(3, 186);
		aq().Name = "Label2";
		aq().Size = new Size(88, 16);
		aq().TabIndex = 14;
		aq().Text = "Master Level:";
		ar().AutoSize = true;
		k().SetColumnSpan(ar(), 2);
		ar().Location = new Point(3, 157);
		ar().Name = "RadioButtonMasterLevel";
		ar().Size = new Size(165, 20);
		ar().TabIndex = 15;
		ar().TabStop = true;
		ar().Text = "Control via Master level";
		ar().UseVisualStyleBackColor = true;
		@as().AutoSize = true;
		k().SetColumnSpan(@as(), 2);
		@as().Location = new Point(3, 3);
		@as().Name = "RadioButtonIndividualSetpoints";
		@as().Size = new Size(206, 20);
		@as().TabIndex = 14;
		@as().TabStop = true;
		@as().Text = "Control via individual setpoints";
		@as().UseVisualStyleBackColor = true;
		l().Anchor = AnchorStyles.None;
		l().Enabled = false;
		l().f(A_0: false);
		l().Location = new Point(128, 129);
		l().Name = "TextBoxNumUVNewSetpoint";
		l().e(A_0: false);
		l().Size = new Size(49, 22);
		l().TabIndex = 7;
		m().Anchor = AnchorStyles.None;
		m().AutoSize = true;
		m().Location = new Point(32, 132);
		m().Name = "LabelUV";
		m().Size = new Size(30, 16);
		m().TabIndex = 6;
		m().Text = "UV:";
		n().Anchor = AnchorStyles.None;
		n().Enabled = false;
		n().f(A_0: false);
		n().Location = new Point(128, 101);
		n().Name = "TextBoxNumVioletNewSetpoint";
		n().e(A_0: false);
		n().Size = new Size(49, 22);
		n().TabIndex = 3;
		o().Anchor = AnchorStyles.None;
		o().AutoSize = true;
		o().Location = new Point(24, 104);
		o().Name = "LabelViolet";
		o().Size = new Size(45, 16);
		o().TabIndex = 2;
		o().Text = "Violet:";
		p().Anchor = AnchorStyles.None;
		p().AutoSize = true;
		p().Location = new Point(24, 48);
		p().Name = "LabelLamp";
		p().Size = new Size(45, 16);
		p().TabIndex = 0;
		p().Text = "Lamp:";
		q().Anchor = AnchorStyles.None;
		q().AutoSize = true;
		q().Location = new Point(113, 26);
		q().Name = "LabelNew";
		q().Size = new Size(80, 16);
		q().TabIndex = 1;
		q().Text = "Setpoint (%)";
		r().Anchor = AnchorStyles.None;
		r().Enabled = false;
		r().f(A_0: false);
		r().Location = new Point(128, 45);
		r().Name = "TextBoxNumLampNewSetpoint";
		r().e(A_0: false);
		r().Size = new Size(49, 22);
		r().TabIndex = 2;
		s().Anchor = AnchorStyles.None;
		s().AutoSize = true;
		s().Location = new Point(24, 76);
		s().Name = "LabelWhite";
		s().Size = new Size(45, 16);
		s().TabIndex = 6;
		s().Text = "White:";
		t().Anchor = AnchorStyles.None;
		t().Enabled = false;
		t().f(A_0: false);
		t().Location = new Point(128, 73);
		t().Name = "TextBoxNumWhiteNewSetpoint";
		t().e(A_0: false);
		t().Size = new Size(49, 22);
		t().TabIndex = 7;
		u().AutoSize = true;
		u().Location = new Point(14, -2);
		u().Name = "CheckBoxLightSourceOn";
		u().Size = new Size(117, 20);
		u().TabIndex = 2;
		u().Text = "Light source on";
		u().UseVisualStyleBackColor = true;
		v().AutoSize = true;
		v().Location = new Point(3, 0);
		v().Name = "LabelTemperature";
		v().Size = new Size(113, 16);
		v().TabIndex = 3;
		v().Text = "Temperature (°C):";
		w().AutoSize = true;
		w().BorderStyle = BorderStyle.Fixed3D;
		w().Location = new Point(122, 0);
		w().Name = "LabelTemperatureReading";
		w().Size = new Size(65, 18);
		w().TabIndex = 10;
		w().Text = "Unknown";
		x().Anchor = AnchorStyles.Left;
		x().AutoSize = true;
		x().Location = new Point(10, 51);
		x().Margin = new Padding(10, 3, 3, 3);
		x().Name = "CheckBoxCalibA";
		x().Size = new Size(159, 20);
		x().TabIndex = 11;
		x().Text = "Calibration lamp{0} on";
		x().UseVisualStyleBackColor = true;
		x().Visible = false;
		y().Anchor = AnchorStyles.Left;
		y().AutoSize = true;
		y().Location = new Point(10, 77);
		y().Margin = new Padding(10, 3, 3, 3);
		y().Name = "CheckBoxCalibB";
		y().Size = new Size(159, 20);
		y().TabIndex = 12;
		y().Text = "Calibration lamp{0} on";
		y().UseVisualStyleBackColor = true;
		y().Visible = false;
		z().ContainerControl = this;
		aa().AutoSize = true;
		aa().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		aa().ColumnCount = 1;
		aa().ColumnStyles.Add(new ColumnStyle());
		aa().Controls.Add(at(), 0, 1);
		aa().Controls.Add(af(), 0, 3);
		aa().Controls.Add(ai(), 0, 2);
		aa().Controls.Add(ac(), 0, 4);
		aa().Controls.Add(j(), 0, 0);
		aa().Location = new Point(12, 12);
		aa().Margin = new Padding(12);
		aa().Name = "TableLayoutPanel1";
		aa().RowCount = 5;
		aa().RowStyles.Add(new RowStyle());
		aa().RowStyles.Add(new RowStyle());
		aa().RowStyles.Add(new RowStyle());
		aa().RowStyles.Add(new RowStyle());
		aa().RowStyles.Add(new RowStyle());
		aa().Size = new Size(410, 606);
		aa().TabIndex = 13;
		at().Anchor = AnchorStyles.None;
		at().AutoSize = true;
		at().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		at().ColumnCount = 2;
		at().ColumnStyles.Add(new ColumnStyle());
		at().ColumnStyles.Add(new ColumnStyle());
		at().Controls.Add(bd(), 0, 2);
		at().Controls.Add(ba(), 0, 1);
		at().Controls.Add(a6(), 1, 4);
		at().Controls.Add(a5(), 0, 4);
		at().Controls.Add(a3(), 1, 3);
		at().Controls.Add(a4(), 0, 3);
		at().Controls.Add(a7(), 0, 0);
		at().Location = new Point(3, 258);
		at().Name = "TableLayoutPanel7";
		at().RowCount = 5;
		at().RowStyles.Add(new RowStyle());
		at().RowStyles.Add(new RowStyle());
		at().RowStyles.Add(new RowStyle());
		at().RowStyles.Add(new RowStyle());
		at().RowStyles.Add(new RowStyle());
		at().Size = new Size(404, 229);
		at().TabIndex = 14;
		bd().Anchor = AnchorStyles.None;
		bd().AutoSize = true;
		at().SetColumnSpan(bd(), 2);
		bd().Location = new Point(146, 51);
		bd().Name = "CheckBoxRAndTFanOn";
		bd().Size = new Size(112, 20);
		bd().TabIndex = 15;
		bd().Text = "Cooling fan on";
		bd().UseVisualStyleBackColor = true;
		bd().Visible = false;
		ba().Anchor = AnchorStyles.None;
		ba().AutoSize = true;
		ba().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ba().ColumnCount = 2;
		at().SetColumnSpan(ba(), 2);
		ba().ColumnStyles.Add(new ColumnStyle());
		ba().ColumnStyles.Add(new ColumnStyle());
		ba().Controls.Add(bb(), 0, 0);
		ba().Controls.Add(bc(), 1, 0);
		ba().Location = new Point(133, 27);
		ba().Name = "TLPRAndTFan";
		ba().RowCount = 1;
		ba().RowStyles.Add(new RowStyle());
		ba().Size = new Size(137, 18);
		ba().TabIndex = 16;
		ba().Visible = false;
		bb().AutoSize = true;
		bb().Location = new Point(3, 0);
		bb().Name = "LabelRAndTFanRpm";
		bb().Size = new Size(60, 16);
		bb().TabIndex = 3;
		bb().Text = "Fan rpm:";
		bc().AutoSize = true;
		bc().BorderStyle = BorderStyle.Fixed3D;
		bc().Location = new Point(69, 0);
		bc().Name = "LabelRAndTFanRpmReading";
		bc().Size = new Size(65, 18);
		bc().TabIndex = 10;
		bc().Text = "Unknown";
		a6().AutoSize = true;
		a6().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		a6().ColumnCount = 1;
		a6().ColumnStyles.Add(new ColumnStyle());
		a6().Controls.Add(a0(), 0, 0);
		a6().Controls.Add(au(), 0, 4);
		a6().Controls.Add(ax(), 0, 1);
		a6().Controls.Add(av(), 0, 3);
		a6().Controls.Add(aw(), 0, 2);
		a6().Location = new Point(205, 100);
		a6().Name = "TableLayoutPanel6";
		a6().RowCount = 5;
		a6().RowStyles.Add(new RowStyle());
		a6().RowStyles.Add(new RowStyle());
		a6().RowStyles.Add(new RowStyle());
		a6().RowStyles.Add(new RowStyle());
		a6().RowStyles.Add(new RowStyle());
		a6().Size = new Size(196, 126);
		a6().TabIndex = 14;
		a0().Anchor = AnchorStyles.Left;
		a0().AutoSize = true;
		a0().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		a0().ColumnCount = 2;
		a0().ColumnStyles.Add(new ColumnStyle());
		a0().ColumnStyles.Add(new ColumnStyle());
		a0().Controls.Add(a1(), 0, 0);
		a0().Controls.Add(a2(), 1, 0);
		a0().Location = new Point(3, 3);
		a0().Name = "TLPTTemp";
		a0().RowCount = 1;
		a0().RowStyles.Add(new RowStyle());
		a0().Size = new Size(190, 18);
		a0().TabIndex = 15;
		a0().Visible = false;
		a1().AutoSize = true;
		a1().Location = new Point(3, 0);
		a1().Name = "Label6";
		a1().Size = new Size(113, 16);
		a1().TabIndex = 3;
		a1().Text = "Temperature (°C):";
		a2().AutoSize = true;
		a2().BorderStyle = BorderStyle.Fixed3D;
		a2().Location = new Point(122, 0);
		a2().Name = "LabelTemperatureTReading";
		a2().Size = new Size(65, 18);
		a2().TabIndex = 10;
		a2().Text = "Unknown";
		au().Anchor = AnchorStyles.Left;
		au().AutoSize = true;
		au().Location = new Point(10, 103);
		au().Margin = new Padding(10, 3, 3, 3);
		au().Name = "CheckBoxTFanOn";
		au().Size = new Size(112, 20);
		au().TabIndex = 15;
		au().Text = "Cooling fan on";
		au().UseVisualStyleBackColor = true;
		au().Visible = false;
		ax().Anchor = AnchorStyles.Left;
		ax().AutoSize = true;
		ax().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ax().ColumnCount = 2;
		ax().ColumnStyles.Add(new ColumnStyle());
		ax().ColumnStyles.Add(new ColumnStyle());
		ax().Controls.Add(ay(), 0, 0);
		ax().Controls.Add(az(), 1, 0);
		ax().Location = new Point(3, 27);
		ax().Name = "TLPTFan";
		ax().RowCount = 1;
		ax().RowStyles.Add(new RowStyle());
		ax().Size = new Size(137, 18);
		ax().TabIndex = 16;
		ax().Visible = false;
		ay().AutoSize = true;
		ay().Location = new Point(3, 0);
		ay().Name = "Label7";
		ay().Size = new Size(60, 16);
		ay().TabIndex = 3;
		ay().Text = "Fan rpm:";
		az().AutoSize = true;
		az().BorderStyle = BorderStyle.Fixed3D;
		az().Location = new Point(69, 0);
		az().Name = "LabelTFanRpmReading";
		az().Size = new Size(65, 18);
		az().TabIndex = 10;
		az().Text = "Unknown";
		az().Visible = false;
		av().Anchor = AnchorStyles.Left;
		av().AutoSize = true;
		av().Location = new Point(10, 77);
		av().Margin = new Padding(10, 3, 3, 3);
		av().Name = "CheckBoxTCalibB";
		av().Size = new Size(159, 20);
		av().TabIndex = 15;
		av().Text = "Calibration lamp{0} on";
		av().UseVisualStyleBackColor = true;
		av().Visible = false;
		aw().Anchor = AnchorStyles.Left;
		aw().AutoSize = true;
		aw().Location = new Point(10, 51);
		aw().Margin = new Padding(10, 3, 3, 3);
		aw().Name = "CheckBoxTCalibA";
		aw().Size = new Size(159, 20);
		aw().TabIndex = 15;
		aw().Text = "Calibration lamp{0} on";
		aw().UseVisualStyleBackColor = true;
		aw().Visible = false;
		a5().AutoSize = true;
		a5().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		a5().ColumnCount = 1;
		a5().ColumnStyles.Add(new ColumnStyle());
		a5().Controls.Add(ab(), 0, 0);
		a5().Controls.Add(al(), 0, 1);
		a5().Controls.Add(x(), 0, 2);
		a5().Controls.Add(y(), 0, 3);
		a5().Controls.Add(ao(), 0, 4);
		a5().Location = new Point(3, 100);
		a5().Name = "TableLayoutPanel3";
		a5().RowCount = 5;
		a5().RowStyles.Add(new RowStyle());
		a5().RowStyles.Add(new RowStyle());
		a5().RowStyles.Add(new RowStyle());
		a5().RowStyles.Add(new RowStyle());
		a5().RowStyles.Add(new RowStyle());
		a5().Size = new Size(196, 126);
		a5().TabIndex = 14;
		ab().Anchor = AnchorStyles.Left;
		ab().AutoSize = true;
		ab().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ab().ColumnCount = 2;
		ab().ColumnStyles.Add(new ColumnStyle());
		ab().ColumnStyles.Add(new ColumnStyle());
		ab().Controls.Add(v(), 0, 0);
		ab().Controls.Add(w(), 1, 0);
		ab().Location = new Point(3, 3);
		ab().Name = "TLPTemp";
		ab().RowCount = 1;
		ab().RowStyles.Add(new RowStyle());
		ab().Size = new Size(190, 18);
		ab().TabIndex = 14;
		ab().Visible = false;
		al().Anchor = AnchorStyles.Left;
		al().AutoSize = true;
		al().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		al().ColumnCount = 2;
		al().ColumnStyles.Add(new ColumnStyle());
		al().ColumnStyles.Add(new ColumnStyle());
		al().Controls.Add(am(), 0, 0);
		al().Controls.Add(an(), 1, 0);
		al().Location = new Point(3, 27);
		al().Name = "TLPFan";
		al().RowCount = 1;
		al().RowStyles.Add(new RowStyle());
		al().Size = new Size(137, 18);
		al().TabIndex = 15;
		al().Visible = false;
		am().AutoSize = true;
		am().Location = new Point(3, 0);
		am().Name = "LabelFanRpm";
		am().Size = new Size(60, 16);
		am().TabIndex = 3;
		am().Text = "Fan rpm:";
		an().AutoSize = true;
		an().BorderStyle = BorderStyle.Fixed3D;
		an().Location = new Point(69, 0);
		an().Name = "LabelFanRpmReading";
		an().Size = new Size(65, 18);
		an().TabIndex = 10;
		an().Text = "Unknown";
		an().Visible = false;
		ao().Anchor = AnchorStyles.Left;
		ao().AutoSize = true;
		ao().Location = new Point(10, 103);
		ao().Margin = new Padding(10, 3, 3, 3);
		ao().Name = "CheckBoxFanOn";
		ao().Size = new Size(112, 20);
		ao().TabIndex = 14;
		ao().Text = "Cooling fan on";
		ao().UseVisualStyleBackColor = true;
		ao().Visible = false;
		a3().Anchor = AnchorStyles.Left;
		a3().AutoSize = true;
		a3().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		a3().Location = new Point(205, 81);
		a3().Margin = new Padding(3, 7, 3, 0);
		a3().Name = "LabelTColumn";
		a3().Size = new Size(110, 16);
		a3().TabIndex = 16;
		a3().Text = "Transmittance:";
		a3().Visible = false;
		a4().Anchor = AnchorStyles.Left;
		a4().AutoSize = true;
		a4().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		a4().Location = new Point(3, 81);
		a4().Margin = new Padding(3, 7, 3, 0);
		a4().Name = "LabelRColumn";
		a4().Size = new Size(95, 16);
		a4().TabIndex = 15;
		a4().Text = "Reflectance:";
		a4().Visible = false;
		a7().Anchor = AnchorStyles.None;
		a7().AutoSize = true;
		a7().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		a7().ColumnCount = 2;
		at().SetColumnSpan(a7(), 2);
		a7().ColumnStyles.Add(new ColumnStyle());
		a7().ColumnStyles.Add(new ColumnStyle());
		a7().Controls.Add(a8(), 0, 0);
		a7().Controls.Add(a9(), 1, 0);
		a7().Location = new Point(107, 3);
		a7().Name = "TLPRAndTTemp";
		a7().RowCount = 1;
		a7().RowStyles.Add(new RowStyle());
		a7().Size = new Size(190, 18);
		a7().TabIndex = 15;
		a7().Visible = false;
		a8().AutoSize = true;
		a8().Location = new Point(3, 0);
		a8().Name = "Label4";
		a8().Size = new Size(113, 16);
		a8().TabIndex = 3;
		a8().Text = "Temperature (°C):";
		a9().AutoSize = true;
		a9().BorderStyle = BorderStyle.Fixed3D;
		a9().Location = new Point(122, 0);
		a9().Name = "LabelRandTTemp";
		a9().Size = new Size(65, 18);
		a9().TabIndex = 10;
		a9().Text = "Unknown";
		af().Anchor = AnchorStyles.None;
		af().AutoSize = true;
		af().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		af().ColumnCount = 2;
		af().ColumnStyles.Add(new ColumnStyle());
		af().ColumnStyles.Add(new ColumnStyle());
		af().Controls.Add(ag(), 1, 0);
		af().Controls.Add(ah(), 0, 0);
		af().Location = new Point(117, 525);
		af().Name = "TLPFailDescrip";
		af().RowCount = 1;
		af().RowStyles.Add(new RowStyle());
		af().Size = new Size(176, 16);
		af().TabIndex = 15;
		af().Visible = false;
		ag().Anchor = AnchorStyles.Left;
		ag().AutoSize = true;
		ag().Location = new Point(132, 0);
		ag().Name = "LabelStatusFailDescrip";
		ag().Size = new Size(41, 16);
		ag().TabIndex = 16;
		ag().Text = "None";
		ah().Anchor = AnchorStyles.Right;
		ah().AutoSize = true;
		ah().Location = new Point(3, 0);
		ah().Name = "Label3";
		ah().Size = new Size(123, 16);
		ah().TabIndex = 15;
		ah().Text = "Failure Description:";
		ai().Anchor = AnchorStyles.None;
		ai().AutoSize = true;
		ai().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ai().ColumnCount = 2;
		ai().ColumnStyles.Add(new ColumnStyle());
		ai().ColumnStyles.Add(new ColumnStyle());
		ai().Controls.Add(aj(), 1, 0);
		ai().Controls.Add(ak(), 0, 0);
		ai().Location = new Point(144, 503);
		ai().Margin = new Padding(3, 13, 3, 3);
		ai().Name = "TableLayoutPanelStatus";
		ai().RowCount = 1;
		ai().RowStyles.Add(new RowStyle());
		ai().Size = new Size(122, 16);
		ai().TabIndex = 14;
		ai().Visible = false;
		aj().Anchor = AnchorStyles.Left;
		aj().AutoSize = true;
		aj().Location = new Point(57, 0);
		aj().Name = "LabelTestStatus";
		aj().Size = new Size(62, 16);
		aj().TabIndex = 16;
		aj().Text = "Untested";
		ak().Anchor = AnchorStyles.Right;
		ak().AutoSize = true;
		ak().Location = new Point(3, 0);
		ak().Name = "Label1";
		ak().Size = new Size(48, 16);
		ak().TabIndex = 15;
		ak().Text = "Status:";
		ac().Anchor = AnchorStyles.None;
		ac().AutoSize = true;
		ac().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ac().ColumnCount = 3;
		ac().ColumnStyles.Add(new ColumnStyle());
		ac().ColumnStyles.Add(new ColumnStyle());
		ac().ColumnStyles.Add(new ColumnStyle());
		ac().Controls.Add(ae(), 2, 0);
		ac().Controls.Add(ad(), 1, 0);
		ac().Controls.Add(i(), 0, 0);
		ac().Location = new Point(59, 557);
		ac().Margin = new Padding(3, 13, 3, 13);
		ac().Name = "TableLayoutPanel4";
		ac().RowCount = 1;
		ac().RowStyles.Add(new RowStyle());
		ac().Size = new Size(291, 36);
		ac().TabIndex = 14;
		ae().Anchor = AnchorStyles.None;
		ae().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae().Location = new Point(198, 4);
		ae().Margin = new Padding(4);
		ae().Name = "ButtonApply";
		ae().Size = new Size(89, 28);
		ae().TabIndex = 2;
		ae().Text = "Apply";
		ad().Anchor = AnchorStyles.None;
		ad().DialogResult = DialogResult.Cancel;
		ad().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ad().Location = new Point(101, 4);
		ad().Margin = new Padding(4);
		ad().Name = "ButtonCancel";
		ad().Size = new Size(89, 28);
		ad().TabIndex = 1;
		ad().Text = "Cancel";
		base.AcceptButton = i();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = ad();
		base.ClientSize = new Size(434, 620);
		base.Controls.Add(aa());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogLightSource";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Light Source Settings";
		j().ResumeLayout(performLayout: false);
		j().PerformLayout();
		k().ResumeLayout(performLayout: false);
		k().PerformLayout();
		((ISupportInitialize)z()).EndInit();
		aa().ResumeLayout(performLayout: false);
		aa().PerformLayout();
		at().ResumeLayout(performLayout: false);
		at().PerformLayout();
		ba().ResumeLayout(performLayout: false);
		ba().PerformLayout();
		a6().ResumeLayout(performLayout: false);
		a6().PerformLayout();
		a0().ResumeLayout(performLayout: false);
		a0().PerformLayout();
		ax().ResumeLayout(performLayout: false);
		ax().PerformLayout();
		a5().ResumeLayout(performLayout: false);
		a5().PerformLayout();
		ab().ResumeLayout(performLayout: false);
		ab().PerformLayout();
		al().ResumeLayout(performLayout: false);
		al().PerformLayout();
		a7().ResumeLayout(performLayout: false);
		a7().PerformLayout();
		af().ResumeLayout(performLayout: false);
		af().PerformLayout();
		ai().ResumeLayout(performLayout: false);
		ai().PerformLayout();
		ac().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button i()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = d;
		Button button = this.m_b;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_b = A_0;
		button = this.m_b;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox j()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(GroupBox A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel k()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy l()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hy A_0)
	{
		EventHandler value = a;
		hy hy2 = this.m_e;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_e = A_0;
		hy2 = this.m_e;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label m()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy n()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(hy A_0)
	{
		EventHandler value = a;
		hy hy2 = this.m_g;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_g = A_0;
		hy2 = this.m_g;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label o()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label p()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label q()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy r()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(hy A_0)
	{
		EventHandler value = a;
		hy hy2 = this.m_k;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_k = A_0;
		hy2 = this.m_k;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label s()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy t()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(hy A_0)
	{
		EventHandler value = a;
		hy hy2 = this.m_m;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_m = A_0;
		hy2 = this.m_m;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox u()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(CheckBox A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label v()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label w()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Label A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox x()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(CheckBox A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox y()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(CheckBox A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ErrorProvider z()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ErrorProvider A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel aa()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ab()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ac()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TableLayoutPanel A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ad()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ae()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = e;
		Button button = this.m_x;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_x = A_0;
		button = this.m_x;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel af()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TableLayoutPanel A_0)
	{
		this.m_y = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ag()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Label A_0)
	{
		this.m_z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ah()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Label A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ai()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(TableLayoutPanel A_0)
	{
		this.m_ab = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aj()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Label A_0)
	{
		this.m_ac = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ak()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Label A_0)
	{
		this.m_ad = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel al()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(TableLayoutPanel A_0)
	{
		this.m_ae = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label am()
	{
		return this.m_af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(Label A_0)
	{
		this.m_af = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label an()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(Label A_0)
	{
		this.m_ag = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ao()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(CheckBox A_0)
	{
		this.m_ah = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ap()
	{
		return this.m_ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(hy A_0)
	{
		this.m_ai = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aq()
	{
		return this.m_aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(Label A_0)
	{
		this.m_aj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ar()
	{
		return this.m_ak;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(RadioButton A_0)
	{
		EventHandler value = b;
		RadioButton radioButton = this.m_ak;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_ak = A_0;
		radioButton = this.m_ak;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton @as()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(RadioButton A_0)
	{
		EventHandler value = c;
		RadioButton radioButton = this.m_al;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_al = A_0;
		radioButton = this.m_al;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel at()
	{
		return this.m_am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(TableLayoutPanel A_0)
	{
		this.m_am = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox au()
	{
		return this.m_an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(CheckBox A_0)
	{
		this.m_an = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox av()
	{
		return this.m_ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(CheckBox A_0)
	{
		this.m_ao = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox aw()
	{
		return this.m_ap;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(CheckBox A_0)
	{
		this.m_ap = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ax()
	{
		return this.m_aq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TableLayoutPanel A_0)
	{
		this.m_aq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ay()
	{
		return this.m_ar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(Label A_0)
	{
		this.m_ar = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label az()
	{
		return this.m_as;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(Label A_0)
	{
		this.m_as = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel a0()
	{
		return this.m_at;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(TableLayoutPanel A_0)
	{
		this.m_at = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a1()
	{
		return this.m_au;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(Label A_0)
	{
		this.m_au = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a2()
	{
		return this.m_av;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(Label A_0)
	{
		this.m_av = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a3()
	{
		return this.m_aw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(Label A_0)
	{
		this.m_aw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a4()
	{
		return this.m_ax;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(Label A_0)
	{
		this.m_ax = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel a5()
	{
		return this.m_ay;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(TableLayoutPanel A_0)
	{
		this.m_ay = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel a6()
	{
		return this.m_az;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(TableLayoutPanel A_0)
	{
		this.m_az = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel a7()
	{
		return this.m_a0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(TableLayoutPanel A_0)
	{
		this.m_a0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a8()
	{
		return this.m_a1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(Label A_0)
	{
		this.m_a1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a9()
	{
		return this.m_a2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(Label A_0)
	{
		this.m_a2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ba()
	{
		return this.m_a3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(TableLayoutPanel A_0)
	{
		this.m_a3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bb()
	{
		return this.m_a4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(Label A_0)
	{
		this.m_a4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bc()
	{
		return this.m_a5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(Label A_0)
	{
		this.m_a5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox bd()
	{
		return this.m_a6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(CheckBox A_0)
	{
		this.m_a6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d be()
	{
		return bk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		r.d.b a_ = b;
		bk?.e(a_);
		bk = A_0;
		bk?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer bf()
	{
		return bl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = a;
		System.Timers.Timer timer = bl;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		bl = A_0;
		timer = bl;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d bg()
	{
		return bm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void b(r.d A_0)
	{
		r.d.b a_ = a;
		bm?.e(a_);
		bm = A_0;
		bm?.d(a_);
	}

	public void a(fz A_0, f1 A_1, Guid A_2, int A_3)
	{
		this.m_a8 = A_1;
		this.m_a9 = A_0;
		this.m_ba = A_2;
		this.m_bb = A_3;
		bi = x().Text;
		bj = y().Text;
		g9[] array = (this.m_be = this.m_a8.m2(this.m_ba, A_3));
		g9 g10 = array[0];
		if (g10.c != null)
		{
			j().Visible = true;
			k().Visible = !g10.h;
			ai().Visible = !g10.h;
			af().Visible = g10.c.e && g10.c.f;
			j().Visible = !g10.i;
		}
		this.m_bf = (g10.a != null && g10.b != null && g10.a.c != g10.b.c) || (array.Length > 1 && array[1].a != null && array[1].a.c != g10.a.c);
		m_bh = array.Length > 1;
		bool flag = m_bh || this.m_bf;
		if (g10.a != null)
		{
			x().Visible = true;
			if (g10.a.a)
			{
				x().Text = string.Format(bi, " short");
			}
			else
			{
				x().Text = string.Format(bi, "");
			}
		}
		if (g10.b != null)
		{
			CheckBox checkBox = f();
			checkBox.Visible = true;
			if (g10.b.a)
			{
				checkBox.Text = string.Format(bj, " long");
			}
			else
			{
				checkBox.Text = string.Format(bj, "");
			}
		}
		if (m_bh)
		{
			ab().Visible = true;
			if (g10.d)
			{
				al().Visible = true;
				ao().Visible = true;
			}
		}
		else
		{
			a7().Visible = true;
			if (g10.d)
			{
				ba().Visible = true;
				bd().Visible = true;
			}
		}
		g10 = null;
		if (array.Length > 1)
		{
			g9 g11 = array[1];
			if (g11.a != null)
			{
				aw().Visible = true;
				if (g11.a.a)
				{
					aw().Text = string.Format(bi, " short");
				}
				else
				{
					aw().Text = string.Format(bi, "");
				}
			}
			if (g11.b != null)
			{
				av().Visible = true;
				if (g11.b.a)
				{
					av().Text = string.Format(bj, " long");
				}
				else
				{
					av().Text = string.Format(bj, "");
				}
			}
			au().Visible = g11.d;
			ax().Visible = g11.d;
			a0().Visible = true;
			g11 = null;
		}
		a4().Visible = this.m_bf || flag;
		if (!this.m_bf)
		{
			a4().Text = "Short Wavelength Spec.";
		}
		a3().Visible = this.m_bf || flag;
		if (!this.m_bf)
		{
			a3().Text = "Long Wavelength Spec.";
		}
		e();
		a(new System.Timers.Timer(1000.0));
		a((object)this, (ElapsedEventArgs)null);
		bf().Start();
		ShowDialog();
		bf().Stop();
	}

	[SpecialName]
	private CheckBox g()
	{
		if (m_bh)
		{
			return ao();
		}
		return bd();
	}

	private CheckBox f()
	{
		g9 g10 = this.m_be[0];
		if (g10.a != null && g10.a.c == g10.b.c)
		{
			return y();
		}
		return aw();
	}

	private void e()
	{
		c();
		try
		{
			g9[] array = this.m_a8.m2(this.m_ba, this.m_bb);
			g9 g10 = array[0];
			if (g10.c != null)
			{
				g9.b b10 = g10.c;
				if (b10.d == 100f && !ar().Checked)
				{
					@as().Checked = true;
				}
				else
				{
					ar().Checked = true;
				}
				u().Checked = b10.a;
				b10 = null;
			}
			x().Checked = g10.a != null && g10.a.b;
			if (g10.b != null)
			{
				f().Checked = g10.b.b;
			}
			if (g10.c != null)
			{
				g9.b b11 = g10.c;
				r().Text = i6.a(b11.b, "0.0");
				t().Text = i6.a(b11.c[0], "0.0");
				n().Text = i6.a(b11.c[1], "0.0");
				l().Text = i6.a(b11.c[2], "0.0");
				if (ap().Enabled)
				{
					ap().Text = i6.a(b11.d, "0.0");
				}
				else
				{
					ap().Text = null;
				}
				if (b11.e)
				{
					if (b11.f)
					{
						aj().Text = "Hardware Test Failure";
						ag().Text = b11.g;
					}
					else
					{
						aj().Text = "Hardware Tested OK";
					}
				}
				else
				{
					aj().Text = "Hardware Untested";
				}
				b11 = null;
			}
			if (g10.d)
			{
				g().Checked = g10.e;
			}
			g10 = null;
			if (array.Length > 1)
			{
				g9 g11 = array[1];
				if (g11.a != null)
				{
					aw().Checked = g11.a.b;
				}
				if (g11.b != null)
				{
					av().Checked = g11.b.b;
				}
				if (g11.d)
				{
					au().Checked = g11.e;
				}
				g11 = null;
			}
		}
		finally
		{
			d();
		}
	}

	private void d()
	{
		checked
		{
			this.m_bd--;
		}
	}

	private void c()
	{
		checked
		{
			this.m_bd++;
		}
	}

	[SpecialName]
	private bool b()
	{
		return this.m_bd > 0;
	}

	private void a()
	{
		hy hy2 = null;
		string a_ = null;
		g9[] array = this.m_a8.m2(this.m_ba, this.m_bb);
		g9 g10 = array[0];
		checked
		{
			if (g10.c != null)
			{
				g9.b b10 = g10.c;
				if (@as().Checked)
				{
					bool flag = default(bool);
					float a_2;
					if (b10.d != 100f && @as().Checked)
					{
						int num = 0;
						do
						{
							a_2 = iz.d(hy2.Text);
							if (this.m_a8.m2(this.m_ba, num, b10.c[num], a_2))
							{
								flag = true;
								break;
							}
							num++;
						}
						while (num <= 2);
						if (!flag)
						{
							a_2 = iz.d(r().Text);
							flag = this.m_a8.m2(this.m_ba, b10.b, a_2);
						}
						if (flag)
						{
							this.m_a8.m2(this.m_ba, 100f, A_2: false, be(), global::r.d.a.b.a);
						}
					}
					int num2 = 0;
					do
					{
						switch (num2)
						{
						case 0:
							a_ = "set White LED setpoint";
							hy2 = t();
							break;
						case 1:
							a_ = "set Violet LED setpoint";
							hy2 = n();
							break;
						case 2:
							a_ = "set UV LED setpoint";
							hy2 = l();
							break;
						}
						a_2 = iz.d(hy2.Text);
						if (flag || this.m_a8.m2(this.m_ba, num2, b10.c[num2], a_2))
						{
							this.m_a8.m2(this.m_ba, num2, a_2, a_, be(), global::r.d.a.b.a);
						}
						num2++;
					}
					while (num2 <= 2);
					a_2 = iz.d(r().Text);
					if (flag || this.m_a8.m2(this.m_ba, b10.b, a_2))
					{
						this.m_a8.m2(this.m_ba, a_2, "change lamp setpoint", be(), global::r.d.a.b.a);
					}
				}
				else
				{
					float a_2 = iz.d(ap().Text);
					if (a_2 != b10.d)
					{
						this.m_a8.m2(this.m_ba, a_2, A_2: false, be(), global::r.d.a.b.a);
					}
				}
				if (u().Checked != b10.a)
				{
					this.m_a8.m2(this.m_ba, u().Checked, "change light source power state", be(), global::r.d.a.b.a);
				}
				b10 = null;
			}
			if (g10.a != null)
			{
				g9.a a10 = g10.a;
				if (x().Checked != a10.b)
				{
					this.m_a8.m2(this.m_ba, a10.c, a10.d, x().Checked, "change calibration lamp A state", be(), global::r.d.a.b.a);
				}
				a10 = null;
			}
			if (g10.b != null)
			{
				g9.a a11 = g10.b;
				CheckBox checkBox = f();
				if (checkBox.Checked != a11.b)
				{
					this.m_a8.m2(this.m_ba, a11.c, a11.d, checkBox.Checked, "change calibration lamp A state", be(), global::r.d.a.b.a);
				}
				a11 = null;
			}
			CheckBox checkBox2 = g();
			if (g10.d && g10.e != checkBox2.Checked)
			{
				this.m_a8.p9(this.m_ba, g10.f, g10.g, checkBox2.Checked, "change fan power state", be(), global::r.d.a.b.a);
			}
			g10 = null;
			if (array.Length <= 1)
			{
				return;
			}
			g9 g11 = array[1];
			if (g11.a != null)
			{
				g9.a a12 = g11.a;
				if (aw().Checked != a12.b)
				{
					this.m_a8.m2(this.m_ba, a12.c, a12.d, aw().Checked, "change calibration lamp T A state", be(), global::r.d.a.b.a);
				}
				a12 = null;
			}
			if (g11.b != null)
			{
				g9.a a13 = g11.b;
				if (av().Checked != a13.b)
				{
					this.m_a8.m2(this.m_ba, a13.c, a13.d, av().Checked, "change calibration lamp T B state", be(), global::r.d.a.b.a);
				}
				a13 = null;
			}
			if (g11.d && g11.e != au().Checked)
			{
				this.m_a8.p9(this.m_ba, g11.f, g11.g, au().Checked, "change fan power state", be(), global::r.d.a.b.a);
			}
			g11 = null;
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			a();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_a9, this.m_a8, null, i6.a(this), "DialogLightSource.ButtonApply_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			a();
			base.DialogResult = DialogResult.OK;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_a9, this.m_a8, null, i6.a(this), "DialogLightSource.ButtonOK_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		this.m_bc = true;
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			bool enabled = @as().Checked;
			r().Enabled = enabled;
			t().Enabled = enabled;
			n().Enabled = enabled;
			l().Enabled = enabled;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (b())
			{
				this.m_a9.c(fz.b.b, "Error in DialogLightSource.RadioButtonIndividualSetpoints_CheckedChanged", ex3);
			}
			else
			{
				i5.a(this.m_a9, this.m_a8, null, i6.a(this), "DialogLightSource.RadioButtonIndividualSetpoints_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			ap().Enabled = ar().Checked;
			if (ap().Enabled)
			{
				g9[] array = this.m_a8.m2(this.m_ba, this.m_bb);
				ap().Text = i6.a(array[0].c.d, "0.0");
			}
			else
			{
				ap().Text = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (b())
			{
				this.m_a9.c(fz.b.b, "Error in DialogLightSource.RadioButtonMasterLevel_CheckedChanged", ex3);
			}
			else
			{
				i5.a(this.m_a9, this.m_a8, null, i6.a(this), "DialogLightSource.RadioButtonMasterLevel_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			if (!b())
			{
				hy hy2 = (hy)A_0;
				double num = iz.e(hy2.Text);
				if (num < 0.0 || num > 100.0)
				{
					z().SetError(hy2, "Value must be in the range 0 to " + 100f);
				}
				else
				{
					z().SetError(hy2, null);
				}
				ae().Enabled = string.IsNullOrEmpty(z().GetError(r())) && string.IsNullOrEmpty(z().GetError(t())) && string.IsNullOrEmpty(z().GetError(n())) && string.IsNullOrEmpty(z().GetError(l()));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_a9, this.m_a8, null, i6.a(this), "DialogLightSource.TextBoxNumSetpoint_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, ElapsedEventArgs A_1)
	{
		try
		{
			if (this.m_bc)
			{
				return;
			}
			if (base.InvokeRequired)
			{
				bf().Stop();
				Invoke(new ElapsedEventHandler(a), A_0, A_1);
				bf().Start();
			}
			else
			{
				this.m_a8.m2(this.m_ba, this.m_be[0].f, this.m_be[0].g, bg(), global::r.d.a.b.a);
				if (m_bh)
				{
					this.m_a8.m2(this.m_ba, this.m_be[1].f, this.m_be[1].g, bg(), global::r.d.a.b.a);
				}
			}
		}
		catch (ObjectDisposedException ex2)
		{
			ProjectData.SetProjectError(ex2);
			ObjectDisposedException ex3 = ex2;
			ProjectData.ClearProjectError();
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception a_ = ex4;
			this.m_a9.c(fz.b.b, "Error in DialogLightSource.mLSStatusUpdateTimer_Elapsed", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(r.d.a A_0)
	{
		try
		{
			if (this.m_bc)
			{
				return;
			}
			if (base.InvokeRequired)
			{
				Invoke(new r.d.b(b), A_0);
				return;
			}
			e();
			if (A_0.a != global::r.d.a.a.a || !string.IsNullOrEmpty(A_0.b))
			{
				fe.b(A_1: (!string.IsNullOrEmpty(A_0.b)) ? A_0.b : ((A_0.d != null) ? ("Error attempting to " + A_0.d.ToString()) : "Error attempting light source task"), A_0: this.m_a9, A_2: i6.a(this));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_a9, this.m_a8, null, i6.a(this), "DialogLightSource.mCompletionTask_TaskFinishedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.d.a A_0)
	{
		try
		{
			if (this.m_bc)
			{
				return;
			}
			if (base.InvokeRequired)
			{
				BeginInvoke(new r.d.b(a), A_0);
				return;
			}
			if (!base.IsHandleCreated)
			{
				this.m_a9.c(fz.b.b, "Attempt to Update Temperature before handle created-Aborted", Environment.StackTrace);
				return;
			}
			r.g.a obj = (r.g.a)A_0;
			ha ha2 = (ha)obj.d;
			Label label;
			Label label2;
			bool flag;
			if (ha2.a == this.m_be[0].f && ha2.b == this.m_be[0].g)
			{
				if (!m_bh)
				{
					label = a9();
					label2 = bc();
				}
				else
				{
					label = w();
					label2 = an();
				}
				flag = this.m_be[0].d;
			}
			else
			{
				label = a2();
				label2 = az();
				flag = this.m_be[1].d;
			}
			if (((r.d.a)obj).a == global::r.d.a.a.a)
			{
				ha ha3 = ha2;
				label.Text = ha3.c.ToString("#.0");
				if (flag)
				{
					if (ha3.d)
					{
						if (ha3.e)
						{
							label2.Text = ha3.f.ToString("0");
						}
						else
						{
							label2.Text = "Fan Failure";
						}
					}
					else
					{
						label2.Text = "Fan Off";
					}
				}
				ha3 = null;
			}
			else
			{
				label.Text = "Err";
			}
			_ = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_a9.c(fz.b.b, "Exception Thrown in mTemperatureCompletionTask_TaskFinishedEvent(). ", a_);
			ProjectData.ClearProjectError();
		}
	}
}
