using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class cp : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private RadioButton m_d;

	[CompilerGenerated]
	private ToolTip m_e;

	[CompilerGenerated]
	private TableLayoutPanel m_f;

	[CompilerGenerated]
	private GroupBox m_g;

	[CompilerGenerated]
	private TableLayoutPanel m_h;

	[CompilerGenerated]
	private TableLayoutPanel m_i;

	[CompilerGenerated]
	private TableLayoutPanel m_j;

	[CompilerGenerated]
	private TableLayoutPanel m_k;

	[CompilerGenerated]
	private ComboBox m_l;

	[CompilerGenerated]
	private Label m_m;

	[CompilerGenerated]
	private TableLayoutPanel m_n;

	[CompilerGenerated]
	private Button m_o;

	[CompilerGenerated]
	private TableLayoutPanel m_p;

	[CompilerGenerated]
	private hy m_q;

	[CompilerGenerated]
	private CheckBox m_r;

	[CompilerGenerated]
	private CheckBox m_s;

	[CompilerGenerated]
	private CheckBox m_t;

	[CompilerGenerated]
	private hy m_u;

	[CompilerGenerated]
	private hy m_v;

	[CompilerGenerated]
	private Label m_w;

	[CompilerGenerated]
	private Label m_x;

	[CompilerGenerated]
	private Label m_y;

	[CompilerGenerated]
	private TableLayoutPanel m_z;

	[CompilerGenerated]
	private GroupBox m_aa;

	[CompilerGenerated]
	private TableLayoutPanel m_ab;

	[CompilerGenerated]
	private Label m_ac;

	[CompilerGenerated]
	private hy m_ad;

	[CompilerGenerated]
	private CheckBox m_ae;

	[CompilerGenerated]
	private RadioButton m_af;

	[CompilerGenerated]
	private TableLayoutPanel m_ag;

	[CompilerGenerated]
	private Label m_ah;

	[CompilerGenerated]
	private hy m_ai;

	[CompilerGenerated]
	private CheckBox m_aj;

	[CompilerGenerated]
	private TableLayoutPanel m_ak;

	[CompilerGenerated]
	private Label m_al;

	[CompilerGenerated]
	private Label m_am;

	[CompilerGenerated]
	private Label m_an;

	[CompilerGenerated]
	private Label m_ao;

	[CompilerGenerated]
	private GroupBox m_ap;

	[CompilerGenerated]
	private Label m_aq;

	[CompilerGenerated]
	private Label m_ar;

	private ho m_as;

	private ho m_at;

	private string au;

	private string av;

	private bool aw;

	private ho.a ax;

	private fz ay;

	private bool az;

	private bool a0;

	private bool a1;

	private const string a2 = "Unknown";

	private const string a3 = "0.00";

	public cp()
	{
		base.Activated += l;
		this.m_as = new ho();
		this.m_at = new ho();
		a1 = false;
		c();
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
	private void c()
	{
		this.m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(cp));
		b(new Button());
		a(new Button());
		a(new RadioButton());
		a(new ToolTip(this.m_a));
		b(new RadioButton());
		a(new TableLayoutPanel());
		b(new GroupBox());
		i(new TableLayoutPanel());
		e(new Label());
		d(new CheckBox());
		a(new GroupBox());
		c(new TableLayoutPanel());
		c(new GroupBox());
		k(new TableLayoutPanel());
		g(new Label());
		k(new Label());
		h(new Label());
		l(new Label());
		j(new Label());
		i(new Label());
		d(new TableLayoutPanel());
		e(new TableLayoutPanel());
		a(new ComboBox());
		a(new Label());
		f(new TableLayoutPanel());
		c(new Button());
		g(new TableLayoutPanel());
		d(new Label());
		a(new CheckBox());
		b(new CheckBox());
		c(new CheckBox());
		b(new Label());
		c(new Label());
		b(new TableLayoutPanel());
		j(new TableLayoutPanel());
		f(new Label());
		e(new CheckBox());
		h(new TableLayoutPanel());
		d(new hy());
		a(new hy());
		b(new hy());
		c(new hy());
		e(new hy());
		h().SuspendLayout();
		ac().SuspendLayout();
		ad().SuspendLayout();
		i().SuspendLayout();
		k().SuspendLayout();
		ar().SuspendLayout();
		am().SuspendLayout();
		l().SuspendLayout();
		m().SuspendLayout();
		p().SuspendLayout();
		r().SuspendLayout();
		j().SuspendLayout();
		ai().SuspendLayout();
		SuspendLayout();
		e().Anchor = AnchorStyles.None;
		e().AutoSize = true;
		e().DialogResult = DialogResult.Cancel;
		e().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e().Location = new Point(112, 4);
		e().Margin = new Padding(4);
		e().Name = "Cancel_Button";
		e().Size = new Size(100, 33);
		e().TabIndex = 1;
		e().Text = "Cancel";
		d().Anchor = AnchorStyles.None;
		d().AutoSize = true;
		d().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d().Location = new Point(4, 4);
		d().Margin = new Padding(4);
		d().Name = "OK_Button";
		d().Size = new Size(100, 33);
		d().TabIndex = 0;
		d().Text = "OK";
		f().AutoSize = true;
		f().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f().Location = new Point(28, 7);
		f().Margin = new Padding(4);
		f().Name = "RadioButtonSelectConfiguration";
		f().Size = new Size(127, 20);
		f().TabIndex = 0;
		f().TabStop = true;
		f().Text = "Specify Hardware";
		g().SetToolTip(f(), "Compute precision for the specified hardware configuration.");
		f().UseVisualStyleBackColor = true;
		g().AutoPopDelay = 5000;
		g().InitialDelay = 1;
		g().IsBalloon = true;
		g().ReshowDelay = 1;
		ah().Anchor = AnchorStyles.Left;
		ah().AutoSize = true;
		ah().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ah().Location = new Point(28, 357);
		ah().Margin = new Padding(16, 11, 4, 7);
		ah().Name = "RadioButtonFromSpectrum";
		ah().Size = new Size(116, 20);
		ah().TabIndex = 1;
		ah().TabStop = true;
		ah().Text = "From Spectrum";
		g().SetToolTip(ah(), "Compute precision for the hardware configuration used to acquire the active spectrum.");
		ah().UseVisualStyleBackColor = true;
		h().AutoSize = true;
		h().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		h().ColumnCount = 1;
		h().ColumnStyles.Add(new ColumnStyle());
		h().Controls.Add(ac(), 0, 2);
		h().Controls.Add(i(), 0, 0);
		h().Controls.Add(j(), 0, 5);
		h().Controls.Add(ai(), 0, 3);
		h().Location = new Point(12, 7);
		h().Margin = new Padding(12, 7, 12, 4);
		h().Name = "TableLayoutPanelMain";
		h().RowCount = 6;
		h().RowStyles.Add(new RowStyle());
		h().RowStyles.Add(new RowStyle(SizeType.Absolute, 10f));
		h().RowStyles.Add(new RowStyle());
		h().RowStyles.Add(new RowStyle());
		h().RowStyles.Add(new RowStyle());
		h().RowStyles.Add(new RowStyle());
		h().Size = new Size(473, 491);
		h().TabIndex = 6;
		ac().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		ac().AutoSize = true;
		ac().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ac().Controls.Add(ad());
		ac().Location = new Point(3, 328);
		ac().Name = "GroupBoxFromSpectrum";
		ac().Padding = new Padding(4, 4, 4, 14);
		ac().Size = new Size(467, 63);
		ac().TabIndex = 0;
		ac().TabStop = false;
		ad().AutoSize = true;
		ad().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ad().ColumnCount = 3;
		ad().ColumnStyles.Add(new ColumnStyle());
		ad().ColumnStyles.Add(new ColumnStyle());
		ad().ColumnStyles.Add(new ColumnStyle());
		ad().Controls.Add(ae(), 0, 0);
		ad().Controls.Add(af(), 0, 0);
		ad().Controls.Add(ag(), 0, 0);
		ad().Dock = DockStyle.Fill;
		ad().Location = new Point(4, 19);
		ad().Name = "TableLayoutPanel3";
		ad().RowCount = 1;
		ad().RowStyles.Add(new RowStyle());
		ad().Size = new Size(459, 30);
		ad().TabIndex = 0;
		ae().Anchor = AnchorStyles.Left;
		ae().AutoSize = true;
		ae().Location = new Point(355, 7);
		ae().Margin = new Padding(4, 0, 4, 0);
		ae().Name = "LabelSpecDCAmplitudeUncertainty";
		ae().Size = new Size(20, 16);
		ae().TabIndex = 17;
		ae().Text = "%";
		ag().AutoSize = true;
		ag().Location = new Point(4, 4);
		ag().Margin = new Padding(4);
		ag().Name = "CheckBoxCustomSpecDCAmplitudeUncertainty";
		ag().Padding = new Padding(3, 0, 0, 0);
		ag().Size = new Size(238, 20);
		ag().TabIndex = 1;
		ag().Text = "Reflectance Amplitude Uncertainty:";
		ag().UseVisualStyleBackColor = true;
		i().AutoSize = true;
		i().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		i().Controls.Add(k());
		i().Dock = DockStyle.Fill;
		i().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		i().Location = new Point(4, 4);
		i().Margin = new Padding(4);
		i().Name = "GroupBoxSpecifyHardware";
		i().Padding = new Padding(4, 4, 4, 14);
		i().Size = new Size(465, 307);
		i().TabIndex = 2;
		i().TabStop = false;
		k().AutoSize = true;
		k().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		k().ColumnCount = 1;
		k().ColumnStyles.Add(new ColumnStyle());
		k().Controls.Add(ar(), 0, 2);
		k().Controls.Add(l(), 0, 0);
		k().Controls.Add(r(), 0, 1);
		k().Dock = DockStyle.Fill;
		k().Location = new Point(4, 19);
		k().Margin = new Padding(4);
		k().Name = "TableLayoutPanel16";
		k().RowCount = 3;
		k().RowStyles.Add(new RowStyle());
		k().RowStyles.Add(new RowStyle());
		k().RowStyles.Add(new RowStyle());
		k().Size = new Size(457, 274);
		k().TabIndex = 7;
		ar().AutoSize = true;
		ar().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ar().Controls.Add(am());
		ar().Dock = DockStyle.Fill;
		ar().Location = new Point(3, 178);
		ar().Name = "GroupBoxInfo";
		ar().Padding = new Padding(4);
		ar().Size = new Size(451, 93);
		ar().TabIndex = 11;
		ar().TabStop = false;
		ar().Text = "Info";
		am().Anchor = AnchorStyles.None;
		am().AutoSize = true;
		am().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		am().ColumnCount = 3;
		am().ColumnStyles.Add(new ColumnStyle());
		am().ColumnStyles.Add(new ColumnStyle());
		am().ColumnStyles.Add(new ColumnStyle());
		am().Controls.Add(an(), 2, 1);
		am().Controls.Add(@as(), 1, 1);
		am().Controls.Add(ao(), 0, 1);
		am().Controls.Add(at(), 1, 0);
		am().Controls.Add(aq(), 0, 0);
		am().Controls.Add(ap(), 2, 0);
		am().Location = new Point(103, 23);
		am().Name = "TableLayoutPanel5";
		am().RowCount = 2;
		am().RowStyles.Add(new RowStyle());
		am().RowStyles.Add(new RowStyle());
		am().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		am().Size = new Size(236, 48);
		am().TabIndex = 0;
		an().Anchor = AnchorStyles.Left;
		an().AutoSize = true;
		an().Location = new Point(193, 28);
		an().Margin = new Padding(0, 0, 3, 0);
		an().Name = "LabelSamplingTimeUnits";
		an().Size = new Size(40, 16);
		an().TabIndex = 8;
		an().Text = "msec";
		@as().Anchor = AnchorStyles.None;
		@as().BorderStyle = BorderStyle.FixedSingle;
		@as().Location = new Point(110, 26);
		@as().Margin = new Padding(3, 2, 3, 2);
		@as().Name = "LabelSamplingTimeValue";
		@as().Size = new Size(80, 20);
		@as().TabIndex = 7;
		@as().Text = "0";
		@as().TextAlign = ContentAlignment.MiddleRight;
		ao().Anchor = AnchorStyles.Right;
		ao().AutoSize = true;
		ao().Location = new Point(9, 28);
		ao().Margin = new Padding(3, 0, 0, 0);
		ao().Name = "LabelSamplingTimeLabel";
		ao().Size = new Size(98, 16);
		ao().TabIndex = 6;
		ao().Text = "Sampling Time:";
		at().Anchor = AnchorStyles.None;
		at().BorderStyle = BorderStyle.FixedSingle;
		at().ForeColor = SystemColors.ControlText;
		at().Location = new Point(110, 2);
		at().Margin = new Padding(3, 2, 3, 2);
		at().Name = "LabelIntegrationTimeValue";
		at().Size = new Size(80, 20);
		at().TabIndex = 1;
		at().Text = "0";
		at().TextAlign = ContentAlignment.MiddleRight;
		aq().Anchor = AnchorStyles.Right;
		aq().AutoSize = true;
		aq().Location = new Point(3, 4);
		aq().Margin = new Padding(3, 0, 0, 0);
		aq().Name = "LabelIntegrationTimeLabel";
		aq().Size = new Size(104, 16);
		aq().TabIndex = 0;
		aq().Text = "Integration Time:";
		ap().Anchor = AnchorStyles.Left;
		ap().AutoSize = true;
		ap().Location = new Point(193, 4);
		ap().Margin = new Padding(0, 0, 3, 0);
		ap().Name = "LabelIntegrationTimeUnits";
		ap().Size = new Size(40, 16);
		ap().TabIndex = 5;
		ap().Text = "msec";
		l().AutoSize = true;
		l().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		l().ColumnCount = 2;
		l().ColumnStyles.Add(new ColumnStyle());
		l().ColumnStyles.Add(new ColumnStyle());
		l().Controls.Add(m(), 0, 0);
		l().Controls.Add(p(), 1, 0);
		l().Dock = DockStyle.Fill;
		l().Location = new Point(4, 4);
		l().Margin = new Padding(4);
		l().Name = "TableLayoutPanel17";
		l().RowCount = 1;
		l().RowStyles.Add(new RowStyle());
		l().Size = new Size(449, 44);
		l().TabIndex = 0;
		m().Anchor = AnchorStyles.None;
		m().AutoSize = true;
		m().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		m().ColumnCount = 2;
		m().ColumnStyles.Add(new ColumnStyle());
		m().ColumnStyles.Add(new ColumnStyle());
		m().Controls.Add(n(), 1, 0);
		m().Controls.Add(o(), 0, 0);
		m().Location = new Point(4, 6);
		m().Margin = new Padding(4);
		m().Name = "TableLayoutPanel6";
		m().RowCount = 1;
		m().RowStyles.Add(new RowStyle());
		m().Size = new Size(367, 32);
		m().TabIndex = 9;
		n().AllowDrop = true;
		n().DropDownStyle = ComboBoxStyle.DropDownList;
		n().FormattingEnabled = true;
		n().Location = new Point(98, 4);
		n().Margin = new Padding(4);
		n().Name = "ComboBoxSelectedConfiguration";
		n().Size = new Size(265, 24);
		n().TabIndex = 0;
		o().Anchor = AnchorStyles.Right;
		o().AutoSize = true;
		o().Location = new Point(4, 8);
		o().Margin = new Padding(4, 0, 3, 0);
		o().Name = "LabelSelectConfig";
		o().Size = new Size(87, 16);
		o().TabIndex = 5;
		o().Text = "Configuration:";
		p().Anchor = AnchorStyles.None;
		p().AutoSize = true;
		p().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		p().ColumnCount = 1;
		p().ColumnStyles.Add(new ColumnStyle());
		p().Controls.Add(q(), 0, 0);
		p().Location = new Point(379, 4);
		p().Margin = new Padding(4);
		p().Name = "TableLayoutPanel19";
		p().RowCount = 1;
		p().RowStyles.Add(new RowStyle());
		p().Size = new Size(66, 36);
		p().TabIndex = 10;
		q().Anchor = AnchorStyles.None;
		q().AutoSize = true;
		q().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		q().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		q().Location = new Point(4, 4);
		q().Margin = new Padding(4);
		q().Name = "ButtonEditConfig";
		q().Size = new Size(58, 28);
		q().TabIndex = 0;
		q().Text = "Edit...";
		q().UseVisualStyleBackColor = true;
		r().AutoSize = true;
		r().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		r().ColumnCount = 3;
		r().ColumnStyles.Add(new ColumnStyle());
		r().ColumnStyles.Add(new ColumnStyle());
		r().ColumnStyles.Add(new ColumnStyle());
		r().Controls.Add(aa(), 0, 0);
		r().Controls.Add(s(), 1, 1);
		r().Controls.Add(t(), 0, 1);
		r().Controls.Add(u(), 0, 2);
		r().Controls.Add(v(), 0, 3);
		r().Controls.Add(w(), 1, 2);
		r().Controls.Add(x(), 1, 3);
		r().Controls.Add(y(), 2, 3);
		r().Controls.Add(z(), 2, 2);
		r().Dock = DockStyle.Fill;
		r().GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
		r().Location = new Point(4, 56);
		r().Margin = new Padding(4);
		r().Name = "TableLayoutPanel18";
		r().RowCount = 4;
		r().RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
		r().RowStyles.Add(new RowStyle());
		r().RowStyles.Add(new RowStyle());
		r().RowStyles.Add(new RowStyle());
		r().Size = new Size(449, 115);
		r().TabIndex = 1;
		aa().Anchor = AnchorStyles.Left;
		aa().AutoSize = true;
		aa().Location = new Point(4, 4);
		aa().Margin = new Padding(4, 0, 3, 0);
		aa().Name = "Label1";
		aa().Size = new Size(128, 16);
		aa().TabIndex = 7;
		aa().Text = "Custom Parameters:";
		t().AutoSize = true;
		t().Location = new Point(4, 29);
		t().Margin = new Padding(4);
		t().Name = "CheckBoxCustomIntegrationCycles";
		t().Size = new Size(146, 20);
		t().TabIndex = 0;
		t().Text = "# Integration Cycles:";
		t().UseVisualStyleBackColor = true;
		u().AutoSize = true;
		u().Location = new Point(4, 59);
		u().Margin = new Padding(4);
		u().Name = "CheckBoxCustomPeakSignal";
		u().Size = new Size(154, 20);
		u().TabIndex = 2;
		u().Text = "Peak Signal Intensity:";
		u().UseVisualStyleBackColor = true;
		v().AutoSize = true;
		v().Location = new Point(4, 89);
		v().Margin = new Padding(4);
		v().Name = "CheckBoxCustomDCAmplitudeUncertainty";
		v().Size = new Size(231, 20);
		v().TabIndex = 4;
		v().Text = "Reflectance Amplitude Uncertainty:";
		v().UseVisualStyleBackColor = true;
		y().Anchor = AnchorStyles.Left;
		y().AutoSize = true;
		y().Location = new Point(348, 92);
		y().Margin = new Padding(4, 0, 4, 0);
		y().Name = "LabelDCAmplitudeUncertaintyUnits";
		y().Size = new Size(20, 16);
		y().TabIndex = 16;
		y().Text = "%";
		z().Anchor = AnchorStyles.Left;
		z().AutoSize = true;
		z().Location = new Point(348, 62);
		z().Margin = new Padding(4, 0, 4, 0);
		z().Name = "LabelPeakSignalIntensityUnits";
		z().Size = new Size(47, 16);
		z().TabIndex = 19;
		z().Text = "counts";
		j().Anchor = AnchorStyles.None;
		j().AutoSize = true;
		j().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		j().ColumnCount = 2;
		j().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		j().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		j().Controls.Add(d(), 0, 0);
		j().Controls.Add(e(), 1, 0);
		j().Location = new Point(128, 446);
		j().Margin = new Padding(4);
		j().Name = "TableLayoutPanel2";
		j().RowCount = 1;
		j().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		j().Size = new Size(216, 41);
		j().TabIndex = 6;
		ai().AutoSize = true;
		ai().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ai().ColumnCount = 3;
		ai().ColumnStyles.Add(new ColumnStyle());
		ai().ColumnStyles.Add(new ColumnStyle());
		ai().ColumnStyles.Add(new ColumnStyle());
		ai().Controls.Add(aj(), 2, 0);
		ai().Controls.Add(ak(), 1, 0);
		ai().Controls.Add(al(), 0, 0);
		ai().Dock = DockStyle.Fill;
		ai().Location = new Point(3, 397);
		ai().Name = "TableLayoutPanel4";
		ai().Padding = new Padding(0, 6, 0, 6);
		ai().RowCount = 1;
		ai().RowStyles.Add(new RowStyle());
		ai().Size = new Size(467, 42);
		ai().TabIndex = 5;
		aj().Anchor = AnchorStyles.Left;
		aj().AutoSize = true;
		aj().Location = new Point(411, 13);
		aj().Margin = new Padding(4, 0, 4, 0);
		aj().Name = "LabelStabilityWavelengthRangeReductionUnits";
		aj().Size = new Size(26, 16);
		aj().TabIndex = 20;
		aj().Text = "nm";
		al().Anchor = AnchorStyles.Right;
		al().AutoSize = true;
		al().Location = new Point(3, 11);
		al().Name = "CheckBoxStabilityWavelengthRangeReductionAmount";
		al().Size = new Size(352, 20);
		al().TabIndex = 0;
		al().Text = "Repeat computation, altering start/end wavelengths by:";
		al().UseVisualStyleBackColor = true;
		ab().Location = new Point(0, 0);
		ab().Name = "TableLayoutPanel1";
		ab().Size = new Size(200, 100);
		ab().TabIndex = 0;
		af().Anchor = AnchorStyles.None;
		af().f(A_0: false);
		af().Location = new Point(246, 4);
		af().Margin = new Padding(0, 4, 0, 4);
		af().Name = "TextBoxNumericSpecDCAmplitudeUncertainty";
		af().e(A_0: false);
		af().Size = new Size(105, 22);
		af().TabIndex = 1;
		af().TextAlign = HorizontalAlignment.Right;
		g().SetToolTip(af(), "Enter the Peak-Peak (6*Sigma) Reflectance Amplitude Uncertainty in Percent");
		s().Anchor = AnchorStyles.None;
		s().f(A_0: false);
		s().Location = new Point(239, 29);
		s().Margin = new Padding(0, 4, 0, 4);
		s().Name = "TextBoxNumericIntegrationCycles";
		s().e(A_0: false);
		s().Size = new Size(105, 22);
		s().TabIndex = 1;
		s().TextAlign = HorizontalAlignment.Right;
		w().Anchor = AnchorStyles.None;
		w().f(A_0: false);
		w().Location = new Point(239, 59);
		w().Margin = new Padding(0, 4, 0, 4);
		w().Name = "TextBoxNumericPeakSignalIntensity";
		w().e(A_0: false);
		w().Size = new Size(105, 22);
		w().TabIndex = 3;
		w().TextAlign = HorizontalAlignment.Right;
		x().Anchor = AnchorStyles.None;
		x().f(A_0: false);
		x().Location = new Point(239, 89);
		x().Margin = new Padding(0, 4, 0, 4);
		x().Name = "TextBoxNumericDCAmplitudeUncertainty";
		x().e(A_0: false);
		x().Size = new Size(105, 22);
		x().TabIndex = 5;
		x().TextAlign = HorizontalAlignment.Right;
		g().SetToolTip(x(), "Enter the Peak-Peak (6*Sigma) Reflectance Amplitude Uncertainty in Percent");
		ak().AcceptsReturn = true;
		ak().Anchor = AnchorStyles.None;
		ak().Enabled = false;
		ak().f(A_0: false);
		ak().Location = new Point(358, 10);
		ak().Margin = new Padding(0, 4, 0, 4);
		ak().Name = "TextBoxNumericStabilityWavelengthRangeReductionAmount";
		ak().e(A_0: false);
		ak().Size = new Size(49, 22);
		ak().TabIndex = 1;
		ak().TextAlign = HorizontalAlignment.Right;
		g().SetToolTip(ak(), componentResourceManager.GetString("TextBoxNumericStabilityWavelengthRangeReductionAmount.ToolTip"));
		base.AcceptButton = d();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = e();
		base.ClientSize = new Size(499, 535);
		base.Controls.Add(ah());
		base.Controls.Add(f());
		base.Controls.Add(h());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogConfigurePrecision";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Precision Computation Setup";
		h().ResumeLayout(performLayout: false);
		h().PerformLayout();
		ac().ResumeLayout(performLayout: false);
		ac().PerformLayout();
		ad().ResumeLayout(performLayout: false);
		ad().PerformLayout();
		i().ResumeLayout(performLayout: false);
		i().PerformLayout();
		k().ResumeLayout(performLayout: false);
		k().PerformLayout();
		ar().ResumeLayout(performLayout: false);
		ar().PerformLayout();
		am().ResumeLayout(performLayout: false);
		am().PerformLayout();
		l().ResumeLayout(performLayout: false);
		l().PerformLayout();
		m().ResumeLayout(performLayout: false);
		m().PerformLayout();
		p().ResumeLayout(performLayout: false);
		p().PerformLayout();
		r().ResumeLayout(performLayout: false);
		r().PerformLayout();
		j().ResumeLayout(performLayout: false);
		j().PerformLayout();
		ai().ResumeLayout(performLayout: false);
		ai().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button d()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = q;
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
	internal virtual Button e()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = p;
		Button button = this.m_c;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_c = A_0;
		button = this.m_c;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton f()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(RadioButton A_0)
	{
		EventHandler value = o;
		RadioButton radioButton = this.m_d;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_d = A_0;
		radioButton = this.m_d;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip g()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolTip A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel h()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox i()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(GroupBox A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel j()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel k()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel l()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TableLayoutPanel A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel m()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TableLayoutPanel A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox n()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
	{
		EventHandler value = m;
		ComboBox comboBox = this.m_l;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_l = A_0;
		comboBox = this.m_l;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label o()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel p()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(TableLayoutPanel A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button q()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = k;
		Button button = this.m_o;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_o = A_0;
		button = this.m_o;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel r()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(TableLayoutPanel A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy s()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hy A_0)
	{
		EventHandler value = e;
		hy hy2 = this.m_q;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_q = A_0;
		hy2 = this.m_q;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox t()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(CheckBox A_0)
	{
		EventHandler value = j;
		CheckBox checkBox = this.m_r;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_r = A_0;
		checkBox = this.m_r;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox u()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(CheckBox A_0)
	{
		EventHandler value = i;
		CheckBox checkBox = this.m_s;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_s = A_0;
		checkBox = this.m_s;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox v()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(CheckBox A_0)
	{
		EventHandler value = h;
		CheckBox checkBox = this.m_t;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_t = A_0;
		checkBox = this.m_t;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy w()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(hy A_0)
	{
		EventHandler value = d;
		hy hy2 = this.m_u;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_u = A_0;
		hy2 = this.m_u;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy x()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(hy A_0)
	{
		EventHandler value = c;
		hy hy2 = this.m_v;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_v = A_0;
		hy2 = this.m_v;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label y()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label z()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aa()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_y = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ab()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(TableLayoutPanel A_0)
	{
		this.m_z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ac()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(GroupBox A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ad()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TableLayoutPanel A_0)
	{
		this.m_ab = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ae()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_ac = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy af()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(hy A_0)
	{
		EventHandler value = b;
		hy hy2 = this.m_ad;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_ad = A_0;
		hy2 = this.m_ad;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ag()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(CheckBox A_0)
	{
		EventHandler value = g;
		CheckBox checkBox = this.m_ae;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_ae = A_0;
		checkBox = this.m_ae;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ah()
	{
		return this.m_af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(RadioButton A_0)
	{
		EventHandler value = n;
		RadioButton radioButton = this.m_af;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_af = A_0;
		radioButton = this.m_af;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ai()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(TableLayoutPanel A_0)
	{
		this.m_ag = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aj()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_ah = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ak()
	{
		return this.m_ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(hy A_0)
	{
		EventHandler value = a;
		hy hy2 = this.m_ai;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_ai = A_0;
		hy2 = this.m_ai;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox al()
	{
		return this.m_aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(CheckBox A_0)
	{
		EventHandler value = f;
		CheckBox checkBox = this.m_aj;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_aj = A_0;
		checkBox = this.m_aj;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel am()
	{
		return this.m_ak;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(TableLayoutPanel A_0)
	{
		this.m_ak = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label an()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Label A_0)
	{
		this.m_al = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ao()
	{
		return this.m_am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Label A_0)
	{
		this.m_am = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ap()
	{
		return this.m_an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Label A_0)
	{
		this.m_an = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aq()
	{
		return this.m_ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Label A_0)
	{
		this.m_ao = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ar()
	{
		return this.m_ap;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(GroupBox A_0)
	{
		this.m_ap = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label @as()
	{
		return this.m_aq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Label A_0)
	{
		this.m_aq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label at()
	{
		return this.m_ar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(Label A_0)
	{
		this.m_ar = A_0;
	}

	public void a(ho A_0, bool A_1)
	{
		ho A_2 = new ho();
		az = A_1;
		q().Enabled = az;
		A_0.a(ref A_2, A_1: true);
		A_0.a(ref this.m_as, A_1: true);
		ho ho2 = this.m_as;
		t().Checked = global::e.a().PrecSimUseCustomIntegrationCycles;
		u().Checked = global::e.a().PrecSimUseCustomPeakSignalIntensity;
		v().Checked = global::e.a().PrecSimUseCustomDCAmplUncert;
		ag().Checked = global::e.a().PrecSimOverrideSpecAmplitudeUncertainty;
		al().Checked = global::e.a().PrecSimDoWavelengthRangeStabilityCheck;
		a0 = global::e.a().PrecSimAcqSettingsFromSpectrumIfAvailable;
		switch (global::e.a().PrecSimSetupMethod)
		{
		case 0:
			f().Checked = true;
			break;
		case 1:
			ah().Checked = true;
			break;
		}
		a();
		av = global::e.a().PrecSimConfigFile;
		if (f().Checked && File.Exists(av))
		{
			n().SelectedItem = Path.GetFileNameWithoutExtension(av);
		}
		if (t().Checked)
		{
			ho2.h = A_2.h;
		}
		if (u().Checked)
		{
			ho2.m = A_2.m;
		}
		if (v().Checked)
		{
			ho2.p = A_2.p;
		}
		if (ag().Checked)
		{
			ho2.w = A_2.w;
		}
		ho2.y = A_2.y;
		s().Text = ho2.h.ToString();
		w().Text = ho2.m.ToString("0");
		x().Text = ho2.p.ToString();
		af().Text = ho2.w.ToString();
		ak().Text = ho2.y.ToString();
		ho2 = null;
		ShowDialog();
		if (base.DialogResult == DialogResult.OK)
		{
			global::e.a().PrecSimNumIterations = this.m_as.g;
			global::e.a().PrecSimNumIntegrationCycles = this.m_as.h;
			global::e.a().PrecSimIntegrationTime = this.m_as.s;
			global::e.a().PrecSimSpectrometerResolution_nm = this.m_as.i;
			global::e.a().PrecSimFullScaleCounts = this.m_as.j;
			global::e.a().PrecSimShotNoiseWellDepthElectrons = this.m_as.k;
			global::e.a().PrecSimRawFile = this.m_as.l;
			global::e.a().PrecSimPeakSignalIntensity = this.m_as.m;
			global::e.a().PrecSimConfigFile = av;
			global::e.a().PrecSimPixToPixNoisePkToPkRaw = this.m_as.n;
			global::e.a().PrecSimDCNoisePkToPkRaw = this.m_as.o;
			global::e.a().PrecSimDCAmplitudeUncertaintyPkToPkPct = this.m_as.p;
			global::e.a().PrecSimDCAmplitudeUncertaintyPkToPkPctSpecOverride = this.m_as.w;
			global::e.a().PrecSimWavelengthRangeReductionAmount = this.m_as.y;
			global::e.a().PrecSimWavelenCalNoise_nm = this.m_as.r;
			global::e.a().PrecSimSetupMethod = (int)ax;
			this.m_as.u = ax == ho.a.b;
			global::e.a().PrecSimUseCustomIntegrationCycles = t().Checked;
			global::e.a().PrecSimUseCustomPeakSignalIntensity = u().Checked;
			global::e.a().PrecSimUseCustomDCAmplUncert = v().Checked;
			global::e.a().PrecSimOverrideSpecAmplitudeUncertainty = ag().Checked;
			this.m_as.v = ag().Checked;
			global::e.a().PrecSimDoWavelengthRangeStabilityCheck = al().Checked;
			this.m_as.x = al().Checked;
			this.m_as.a(ref A_0, A_1: true);
		}
		else
		{
			A_2.a(ref A_0, A_1: true);
		}
	}

	private bool b()
	{
		if (t().Checked && (Operators.CompareString(s().Text, string.Empty, TextCompare: false) == 0 || Conversions.ToInteger(s().Text) < 1 || Conversions.ToInteger(s().Text) > 500))
		{
			ref fz a_ = ref ay;
			string a_2 = "Invalid Integration Cycles. The number must be between " + Conversions.ToString(1) + " and " + Conversions.ToString(500);
			Point A_ = i6.a(this);
			fe.b(ref a_, a_2, ref A_);
			return false;
		}
		if (u().Checked && (iz.e(w().Text) < 0.0 || iz.e(w().Text) > 4095.0))
		{
			ref fz a_3 = ref ay;
			string a_4 = "Invalid Peak Signal Intensity. The number must be between " + Conversions.ToString(0.0) + " and " + Conversions.ToString(4095.0);
			Point A_ = i6.a(this);
			fe.b(ref a_3, a_4, ref A_);
			return false;
		}
		if (v().Checked && Operators.CompareString(x().Text, string.Empty, TextCompare: false) == 0)
		{
			ref fz a_5 = ref ay;
			Point A_ = i6.a(this);
			fe.b(ref a_5, "Invalid Reflectance Amplitude Uncertainty. Please enter a value", ref A_);
			return false;
		}
		if (ag().Checked && Operators.CompareString(af().Text, string.Empty, TextCompare: false) == 0)
		{
			ref fz a_6 = ref ay;
			Point A_ = i6.a(this);
			fe.b(ref a_6, "Invalid Reflectance Amplitude Uncertainty. Please enter a value", ref A_);
			return false;
		}
		if (al().Checked && Operators.CompareString(ak().Text, string.Empty, TextCompare: false) == 0)
		{
			ref fz a_7 = ref ay;
			Point A_ = i6.a(this);
			fe.b(ref a_7, "Invalid Wavelength range variation. Please enter a value", ref A_);
			return false;
		}
		return true;
	}

	private void a()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(ho.f);
		n().Items.Clear();
		FileInfo[] files = directoryInfo.GetFiles("*.fiprc");
		foreach (FileInfo fileInfo in files)
		{
			n().Items.Add(Path.GetFileNameWithoutExtension(fileInfo.Name));
		}
	}

	private void q(object A_0, EventArgs A_1)
	{
		if (b())
		{
			base.DialogResult = DialogResult.OK;
			Close();
		}
	}

	private void p(object A_0, EventArgs A_1)
	{
		base.DialogResult = DialogResult.Cancel;
		Close();
	}

	private void o(object A_0, EventArgs A_1)
	{
		try
		{
			if (f().Checked)
			{
				ar().Enabled = true;
				at().BorderStyle = BorderStyle.FixedSingle;
				@as().BorderStyle = BorderStyle.FixedSingle;
				n().Enabled = true;
				s().Enabled = t().Checked;
				w().Enabled = u().Checked;
				x().Enabled = v().Checked;
				t().Enabled = true;
				u().Enabled = true;
				v().Enabled = true;
				af().Enabled = false;
				ag().Enabled = false;
				ax = ho.a.a;
				if (az)
				{
					q().Enabled = true;
				}
				a();
				if (File.Exists(av))
				{
					n().SelectedItem = Path.GetFileNameWithoutExtension(av);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ay.c(fz.b.b, "Error in RadioButtonSelectConfiguration_CheckedChanged. Error is: ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void n(object A_0, EventArgs A_1)
	{
		if (!f().Checked)
		{
			ar().Enabled = false;
			at().BorderStyle = BorderStyle.None;
			@as().BorderStyle = BorderStyle.None;
			n().Enabled = false;
			s().Enabled = false;
			w().Enabled = false;
			x().Enabled = false;
			t().Enabled = false;
			u().Enabled = false;
			v().Enabled = false;
			af().Enabled = ag().Checked;
			ag().Enabled = true;
			ax = ho.a.b;
			q().Enabled = false;
		}
	}

	private void m(object A_0, EventArgs A_1)
	{
		try
		{
			hr A_2 = null;
			ho A_3 = new ho();
			av = ho.f + "\\" + n().SelectedItem.ToString() + ".fiprc";
			this.m_as.a(ref A_3, A_1: true);
			this.m_at.b(av);
			a0 = this.m_at.t;
			this.m_at.a(ref this.m_as, A_1: false);
			ho ho2 = this.m_as;
			bool A_4 = default(bool);
			hr.r(ho2.l, ref A_2, ref A_4);
			if (A_2 == null)
			{
				ref fz a_ = ref ay;
				string a_2 = "The selected configuration raw file (" + ho2.l + ") is missing or corrupted.";
				Point A_5 = i6.a(this);
				fe.b(ref a_, a_2, ref A_5);
			}
			if (t().Checked)
			{
				ho2.h = A_3.h;
			}
			else
			{
				s().Text = ho2.h.ToString();
			}
			if (ho2.t && A_4)
			{
				if (A_2 != null)
				{
					hp hp2 = A_2.br()[0];
					at().Text = hp2.z().ToString("0.00");
					@as().Text = (hp2.z() * (double)hp2.s()).ToString("0.00");
					hp2 = null;
				}
				else
				{
					at().Text = "Unknown";
					@as().Text = "Unknown";
				}
			}
			else if (!ho2.t)
			{
				at().Text = ho2.s.ToString("0.00");
				@as().Text = (ho2.s * (double)ho2.h).ToString("0.00");
			}
			else
			{
				at().Text = "Unknown";
				@as().Text = "Unknown";
			}
			if (u().Checked)
			{
				ho2.m = A_3.m;
			}
			else
			{
				w().Text = ho2.m.ToString("0");
			}
			if (v().Checked)
			{
				ho2.p = A_3.p;
			}
			else
			{
				x().Text = ho2.p.ToString();
			}
			ho2.w = A_3.w;
			ho2 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			ay.c(fz.b.b, "Error in ComboBoxSelectedConfiguration_SelectedIndexChanged. Error is: ", a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				s().Enabled = t().Checked && f().Checked;
				w().Enabled = u().Checked && f().Checked;
				x().Enabled = v().Checked && f().Checked;
				int num = i6.a(ah(), 0, 0).X - i6.a(f(), 0, 0).X;
				int num2 = i6.a(i(), 0, 0).Y - i6.a(f(), 0, 0).Y;
				int num3 = i6.a(ac(), 0, 0).Y - i6.a(ah(), 0, 0).Y;
				f().Left += num;
				f().Top += num2 - 2;
				ah().Top += num3 - 2;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				ay.c(fz.b.b, "Error in DialogConfigurePrecision_Activated. Error is: ", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		try
		{
			new cw().a(this.m_as, av);
			a();
			n().SelectedItem = Path.GetFileNameWithoutExtension(av);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ay.c(fz.b.b, "Error in ButtonEditConfig_Click. Error is: ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		try
		{
			ho ho2 = this.m_at;
			s().Enabled = t().Checked;
			if (!t().Checked)
			{
				s().Text = ho2.h.ToString();
				this.m_as.h = ho2.h;
				@as().Text = (ho2.s * (double)ho2.h).ToString("0.00");
			}
			ho2 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ay.c(fz.b.b, "Error in CheckBoxCustomIntegrationCycles_CheckedChanged. Error is: ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		try
		{
			w().Enabled = u().Checked;
			if (!u().Checked)
			{
				w().Text = this.m_at.m.ToString();
				this.m_as.m = this.m_at.m;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ay.c(fz.b.b, "Error in CheckBoxCustomPeakSignal_CheckedChanged. Error is: ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		try
		{
			x().Enabled = v().Checked;
			if (!v().Checked)
			{
				x().Text = this.m_at.p.ToString();
				if (f().Checked)
				{
					this.m_as.p = this.m_at.p;
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ay.c(fz.b.b, "Error in CheckBoxCustomDCAmplitudeUncertainty_CheckedChanged. Error is: ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		try
		{
			af().Enabled = ag().Checked;
			if (ag().Checked && Operators.CompareString(af().Text, string.Empty, TextCompare: false) != 0)
			{
				this.m_as.w = Conversions.ToSingle(af().Text);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ay.c(fz.b.b, "Error in CheckBoxCustomspecDCAmplitudeUncertainty_CheckedChanged. Error is: ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
		{
			ak().Enabled = al().Checked;
			if (Operators.CompareString(ak().Text, string.Empty, TextCompare: false) != 0)
			{
				this.m_as.y = Conversions.ToSingle(ak().Text);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ay.c(fz.b.b, "Error in CheckBoxCustomWavelengthRangeReductionAmount_CheckedChanged. Error is: ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			ho ho2 = this.m_as;
			if (t().Checked)
			{
				ho2.h = iz.c(s().Text);
				@as().Text = (ho2.s * (double)ho2.h).ToString("0.00");
			}
			ho2 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ay.c(fz.b.b, "Error in TextBoxNumericIntegrationCycles_TextChanged. Error is: ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			if (u().Checked)
			{
				this.m_as.m = iz.e(w().Text);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ay.c(fz.b.b, "Error in TextBoxNumericPeakSignalIntensity_TextChanged. Error is: ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			if (v().Checked)
			{
				this.m_as.p = iz.d(x().Text);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ay.c(fz.b.b, "Error in TextBoxNumericDCAmplitudeUncertainty_TextChanged. Error is: ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			if (ag().Checked)
			{
				this.m_as.w = iz.d(af().Text);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ay.c(fz.b.b, "Error in TextBoxNumericSpecDCAmplitudeUncertainty_TextChanged. Error is: ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_as.y = iz.d(ak().Text);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ay.c(fz.b.b, "Error in TextBoxNumericCustomWavelengthRangeReductionAmount_TextChanged. Error is: ", a_);
			ProjectData.ClearProjectError();
		}
	}
}
