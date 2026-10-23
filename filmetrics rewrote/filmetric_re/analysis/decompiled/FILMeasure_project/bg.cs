using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Filmetrics.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class bg : Form
{
	public enum a : short
	{
		a = 1,
		b,
		c,
		d,
		e
	}

	public enum b : short
	{
		a,
		b,
		c
	}

	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private TableLayoutPanel m_d;

	[CompilerGenerated]
	private TableLayoutPanel m_e;

	[CompilerGenerated]
	private Label m_f;

	[CompilerGenerated]
	private Button m_g;

	[CompilerGenerated]
	private Button m_h;

	[CompilerGenerated]
	private Button m_i;

	[CompilerGenerated]
	private ToolTip m_j;

	[CompilerGenerated]
	private Button m_k;

	[CompilerGenerated]
	private Button m_l;

	[CompilerGenerated]
	private Button m_m;

	[CompilerGenerated]
	private Button m_n;

	[CompilerGenerated]
	private Button m_o;

	[CompilerGenerated]
	private Button m_p;

	[CompilerGenerated]
	private Button m_q;

	[CompilerGenerated]
	private Button m_r;

	[CompilerGenerated]
	private Button m_s;

	[CompilerGenerated]
	private Button m_t;

	[CompilerGenerated]
	private Panel m_u;

	[CompilerGenerated]
	private TableLayoutPanel m_v;

	[CompilerGenerated]
	private TableLayoutPanel m_w;

	[CompilerGenerated]
	private hy m_x;

	[CompilerGenerated]
	private Label m_y;

	[CompilerGenerated]
	private Label m_z;

	[CompilerGenerated]
	private hy m_aa;

	[CompilerGenerated]
	private TableLayoutPanel m_ab;

	[CompilerGenerated]
	private TableLayoutPanel m_ac;

	[CompilerGenerated]
	private Label m_ad;

	[CompilerGenerated]
	private hy m_ae;

	[CompilerGenerated]
	private Button m_af;

	[CompilerGenerated]
	private Button m_ag;

	[CompilerGenerated]
	private Button m_ah;

	[CompilerGenerated]
	private Button m_ai;

	[CompilerGenerated]
	private Label m_aj;

	[CompilerGenerated]
	private Label m_ak;

	[CompilerGenerated]
	private TableLayoutPanel m_al;

	[CompilerGenerated]
	private Button m_am;

	[CompilerGenerated]
	private Button m_an;

	[CompilerGenerated]
	private Button m_ao;

	[CompilerGenerated]
	private Button m_ap;

	[CompilerGenerated]
	private Button m_aq;

	[CompilerGenerated]
	private Button m_ar;

	[CompilerGenerated]
	private Button m_as;

	[CompilerGenerated]
	private Button m_at;

	[CompilerGenerated]
	private TableLayoutPanel m_au;

	private f1 m_av;

	private fz m_aw;

	private Guid m_ax;

	private double m_ay;

	private bool m_az;

	private bool m_a0;

	private a m_a1;

	[CompilerGenerated]
	private r.d a2;

	[CompilerGenerated]
	private r.d a3;

	[CompilerGenerated]
	private r.d a4;

	[CompilerGenerated]
	private r.d a5;

	private const string a6 = "DialogFocusImage";

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
	private void d()
	{
		this.m_a = new Container();
		c(new Button());
		d(new Button());
		c(new TableLayoutPanel());
		c(new Label());
		e(new TableLayoutPanel());
		i(new TableLayoutPanel());
		d(new hy());
		e(new Label());
		v(new Button());
		w(new Button());
		d(new Label());
		x(new Button());
		y(new Button());
		z(new Button());
		aa(new Button());
		ab(new Button());
		ac(new Button());
		c(new hy());
		g(new TableLayoutPanel());
		d(new TableLayoutPanel());
		c(new Panel());
		q(new Button());
		g(new Button());
		e(new Button());
		f(new Button());
		p(new Button());
		j(new TableLayoutPanel());
		h(new TableLayoutPanel());
		f(new Label());
		e(new hy());
		r(new Button());
		s(new Button());
		t(new Button());
		u(new Button());
		f(new TableLayoutPanel());
		g(new Label());
		m(new Button());
		h(new Label());
		h(new Button());
		k(new Button());
		i(new Button());
		j(new Button());
		o(new Button());
		l(new Button());
		n(new Button());
		c(new ToolTip(this.m_a));
		g().SuspendLayout();
		y().SuspendLayout();
		ao().SuspendLayout();
		ae().SuspendLayout();
		h().SuspendLayout();
		x().SuspendLayout();
		ax().SuspendLayout();
		af().SuspendLayout();
		z().SuspendLayout();
		SuspendLayout();
		e().Anchor = AnchorStyles.None;
		e().BackColor = SystemColors.Control;
		e().Cursor = Cursors.Default;
		e().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e().ForeColor = SystemColors.ControlText;
		e().Location = new Point(3, 0);
		e().Margin = new Padding(3, 0, 3, 0);
		e().Name = "ButtonOK";
		e().RightToLeft = RightToLeft.No;
		e().Size = new Size(97, 33);
		e().TabIndex = 20;
		e().Text = "OK";
		m().SetToolTip(e(), "Accept current focus and continue with baseline");
		e().UseVisualStyleBackColor = true;
		f().Anchor = AnchorStyles.None;
		f().BackColor = SystemColors.Control;
		f().Cursor = Cursors.Default;
		f().DialogResult = DialogResult.Cancel;
		f().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f().ForeColor = SystemColors.ControlText;
		f().Location = new Point(106, 0);
		f().Margin = new Padding(3, 0, 3, 0);
		f().Name = "ButtonCancel";
		f().RightToLeft = RightToLeft.No;
		f().Size = new Size(97, 33);
		f().TabIndex = 21;
		f().Text = "Cancel";
		m().SetToolTip(f(), "Accept current focus but do not continue baseline");
		f().UseVisualStyleBackColor = true;
		g().AutoSize = true;
		g().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		g().ColumnCount = 1;
		g().ColumnStyles.Add(new ColumnStyle());
		g().Controls.Add(i(), 0, 0);
		g().Controls.Add(y(), 0, 1);
		g().Location = new Point(0, 0);
		g().Name = "TableLayoutPanelFocusImage";
		g().RowCount = 2;
		g().RowStyles.Add(new RowStyle());
		g().RowStyles.Add(new RowStyle());
		g().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		g().Size = new Size(316, 377);
		g().TabIndex = 7;
		i().Anchor = AnchorStyles.None;
		i().AutoSize = true;
		i().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		i().Location = new Point(3, 3);
		i().Margin = new Padding(3);
		i().Name = "LabelInstruction";
		i().Size = new Size(310, 32);
		i().TabIndex = 9;
		i().Text = "Adjust Focus until the signal is maximized.\r\nClick OK to continue Baseline, click Cancel to abort.";
		y().Anchor = AnchorStyles.Top;
		y().AutoSize = true;
		y().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		y().ColumnCount = 1;
		y().ColumnStyles.Add(new ColumnStyle());
		y().Controls.Add(ao(), 0, 0);
		y().Controls.Add(ae(), 0, 2);
		y().Controls.Add(ax(), 0, 1);
		y().Location = new Point(7, 41);
		y().Name = "TableLayoutPanel4";
		y().RowCount = 3;
		y().RowStyles.Add(new RowStyle());
		y().RowStyles.Add(new RowStyle());
		y().RowStyles.Add(new RowStyle());
		y().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		y().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		y().Size = new Size(301, 333);
		y().TabIndex = 4;
		ao().Anchor = AnchorStyles.None;
		ao().AutoSize = true;
		ao().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ao().ColumnCount = 6;
		ao().ColumnStyles.Add(new ColumnStyle());
		ao().ColumnStyles.Add(new ColumnStyle());
		ao().ColumnStyles.Add(new ColumnStyle());
		ao().ColumnStyles.Add(new ColumnStyle());
		ao().ColumnStyles.Add(new ColumnStyle());
		ao().ColumnStyles.Add(new ColumnStyle());
		ao().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
		ao().Controls.Add(ad(), 4, 1);
		ao().Controls.Add(ac(), 5, 1);
		ao().Controls.Add(ap(), 1, 1);
		ao().Controls.Add(aq(), 3, 0);
		ao().Controls.Add(ab(), 5, 0);
		ao().Controls.Add(ar(), 0, 0);
		ao().Controls.Add(@as(), 2, 0);
		ao().Controls.Add(at(), 1, 0);
		ao().Controls.Add(au(), 3, 1);
		ao().Controls.Add(av(), 0, 1);
		ao().Controls.Add(aw(), 2, 1);
		ao().Controls.Add(aa(), 4, 0);
		ao().Location = new Point(3, 3);
		ao().Margin = new Padding(3, 3, 3, 0);
		ao().Name = "TableLayoutPanelXY";
		ao().RowCount = 2;
		ao().RowStyles.Add(new RowStyle());
		ao().RowStyles.Add(new RowStyle());
		ao().Size = new Size(295, 70);
		ao().TabIndex = 10;
		ad().Anchor = AnchorStyles.Right;
		ad().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ad().f(A_0: false);
		ad().Location = new Point(171, 41);
		ad().Name = "TextBoxNumericYPosition";
		ad().e(A_0: true);
		ad().Size = new Size(65, 22);
		ad().TabIndex = 2;
		m().SetToolTip(ad(), "To set Y, enter Y here and click Move");
		ac().Anchor = AnchorStyles.Left;
		ac().AutoSize = true;
		ac().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ac().ImeMode = ImeMode.NoControl;
		ac().Location = new Point(242, 44);
		ac().Name = "LabelYPosition";
		ac().Size = new Size(50, 16);
		ac().TabIndex = 89;
		ac().Text = "Y (mm)";
		ap().Anchor = AnchorStyles.Left;
		ap().Font = new Font("Microsoft Sans Serif", 12f);
		ap().Image = Resources.SlowDescend;
		ap().ImeMode = ImeMode.NoControl;
		ap().Location = new Point(45, 38);
		ap().Name = "ButtonYDownSlow";
		ap().Size = new Size(36, 29);
		ap().TabIndex = 31;
		ap().TabStop = false;
		ap().UseVisualStyleBackColor = true;
		aq().Anchor = AnchorStyles.Left;
		aq().Font = new Font("Microsoft Sans Serif", 12f);
		aq().ImeMode = ImeMode.NoControl;
		aq().Location = new Point(129, 3);
		aq().Name = "ButtonXUpFast";
		aq().Size = new Size(36, 29);
		aq().TabIndex = 85;
		aq().TabStop = false;
		aq().UseVisualStyleBackColor = true;
		ab().Anchor = AnchorStyles.Left;
		ab().AutoSize = true;
		ab().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ab().ImeMode = ImeMode.NoControl;
		ab().Location = new Point(242, 9);
		ab().Name = "LabelX";
		ab().Size = new Size(49, 16);
		ab().TabIndex = 87;
		ab().Text = "X (mm)";
		ar().Anchor = AnchorStyles.Left;
		ar().Font = new Font("Microsoft Sans Serif", 12f);
		ar().ImeMode = ImeMode.NoControl;
		ar().Location = new Point(3, 3);
		ar().Name = "ButtonXDownFast";
		ar().Size = new Size(36, 29);
		ar().TabIndex = 82;
		ar().TabStop = false;
		ar().UseVisualStyleBackColor = true;
		@as().Anchor = AnchorStyles.Left;
		@as().Font = new Font("Microsoft Sans Serif", 12f);
		@as().ImeMode = ImeMode.NoControl;
		@as().Location = new Point(87, 3);
		@as().Name = "ButtonXUpSlow";
		@as().Size = new Size(36, 29);
		@as().TabIndex = 84;
		@as().TabStop = false;
		@as().UseVisualStyleBackColor = true;
		at().Anchor = AnchorStyles.Left;
		at().Font = new Font("Microsoft Sans Serif", 12f);
		at().ImeMode = ImeMode.NoControl;
		at().Location = new Point(45, 3);
		at().Name = "ButtonXDownSlow";
		at().Size = new Size(36, 29);
		at().TabIndex = 83;
		at().TabStop = false;
		at().UseVisualStyleBackColor = true;
		au().Anchor = AnchorStyles.Left;
		au().Font = new Font("Microsoft Sans Serif", 12f);
		au().Image = Resources.FastAscend;
		au().ImeMode = ImeMode.NoControl;
		au().Location = new Point(129, 38);
		au().Name = "ButtonYUpFast";
		au().Size = new Size(36, 29);
		au().TabIndex = 33;
		au().TabStop = false;
		au().UseVisualStyleBackColor = true;
		av().Anchor = AnchorStyles.Left;
		av().Font = new Font("Microsoft Sans Serif", 12f);
		av().Image = Resources.FastDescend;
		av().ImeMode = ImeMode.NoControl;
		av().Location = new Point(3, 38);
		av().Name = "ButtonYDownFast";
		av().Size = new Size(36, 29);
		av().TabIndex = 30;
		av().TabStop = false;
		av().UseVisualStyleBackColor = true;
		aw().Anchor = AnchorStyles.Left;
		aw().Font = new Font("Microsoft Sans Serif", 12f);
		aw().Image = Resources.SlowAscend;
		aw().ImeMode = ImeMode.NoControl;
		aw().Location = new Point(87, 38);
		aw().Name = "ButtonYUpSlow";
		aw().Size = new Size(36, 29);
		aw().TabIndex = 32;
		aw().TabStop = false;
		aw().UseVisualStyleBackColor = true;
		aa().Anchor = AnchorStyles.Right;
		aa().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aa().f(A_0: false);
		aa().Location = new Point(171, 6);
		aa().Name = "TextBoxNumericXPosition";
		aa().e(A_0: true);
		aa().Size = new Size(65, 22);
		aa().TabIndex = 1;
		m().SetToolTip(aa(), "To set X, enter X here and click Move");
		ae().Anchor = AnchorStyles.Top;
		ae().AutoSize = true;
		ae().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ae().ColumnCount = 2;
		ae().ColumnStyles.Add(new ColumnStyle());
		ae().ColumnStyles.Add(new ColumnStyle());
		ae().Controls.Add(h(), 0, 3);
		ae().Controls.Add(x(), 0, 2);
		ae().Controls.Add(l(), 1, 1);
		ae().Controls.Add(j(), 0, 0);
		ae().Controls.Add(k(), 1, 0);
		ae().Controls.Add(v(), 0, 1);
		ae().Location = new Point(16, 187);
		ae().Name = "TableLayoutPanel6";
		ae().RowCount = 4;
		ae().RowStyles.Add(new RowStyle());
		ae().RowStyles.Add(new RowStyle());
		ae().RowStyles.Add(new RowStyle());
		ae().RowStyles.Add(new RowStyle());
		ae().Size = new Size(268, 143);
		ae().TabIndex = 5;
		ae().TabStop = true;
		h().Anchor = AnchorStyles.None;
		h().AutoSize = true;
		h().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		h().ColumnCount = 2;
		ae().SetColumnSpan(h(), 2);
		h().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		h().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		h().Controls.Add(e(), 0, 0);
		h().Controls.Add(f(), 1, 0);
		h().Location = new Point(31, 109);
		h().Margin = new Padding(1, 3, 1, 1);
		h().Name = "TableLayoutPanel2";
		h().RowCount = 1;
		h().RowStyles.Add(new RowStyle());
		h().Size = new Size(206, 33);
		h().TabIndex = 13;
		h().TabStop = true;
		x().Anchor = AnchorStyles.None;
		ae().SetColumnSpan(x(), 2);
		x().Controls.Add(w());
		x().Location = new Point(3, 70);
		x().Margin = new Padding(3, 0, 3, 3);
		x().Name = "PanelAutoscaleGain";
		x().Size = new Size(261, 33);
		x().TabIndex = 11;
		x().TabStop = true;
		x().Visible = false;
		w().Anchor = AnchorStyles.None;
		w().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		w().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		w().Location = new Point(67, 3);
		w().Name = "ButtonAdjustCountsWhenNoMotorizedZMotor";
		w().Size = new Size(128, 29);
		w().TabIndex = 12;
		w().Text = "Autoscale Gain";
		m().SetToolTip(w(), "Optimize spectrometer gain to display a good amplitude");
		w().UseVisualStyleBackColor = true;
		w().Visible = false;
		l().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		l().Font = new Font("Microsoft Sans Serif", 12f);
		l().ImeMode = ImeMode.NoControl;
		l().Location = new Point(137, 38);
		l().Name = "ButtonAdjustCounts";
		l().Size = new Size(128, 29);
		l().TabIndex = 10;
		l().Text = "Autoscale Gain";
		m().SetToolTip(l(), "Optimize spectrometer gain to display a good amplitude");
		l().UseVisualStyleBackColor = true;
		l().Visible = false;
		j().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		j().Font = new Font("Microsoft Sans Serif", 12f);
		j().ImeMode = ImeMode.NoControl;
		j().Location = new Point(3, 3);
		j().Name = "ButtonMoveToPosition";
		j().Size = new Size(128, 29);
		j().TabIndex = 7;
		j().Text = "Move";
		m().SetToolTip(j(), "Moves to the position entered above");
		j().UseVisualStyleBackColor = true;
		k().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		k().Font = new Font("Microsoft Sans Serif", 12f);
		k().ImeMode = ImeMode.NoControl;
		k().Location = new Point(137, 3);
		k().Name = "ButtonGetPosition";
		k().Size = new Size(128, 29);
		k().TabIndex = 8;
		k().Text = "Current";
		m().SetToolTip(k(), "Displays the current position above");
		k().UseVisualStyleBackColor = true;
		v().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		v().Font = new Font("Microsoft Sans Serif", 12f);
		v().ImeMode = ImeMode.NoControl;
		v().Location = new Point(3, 38);
		v().Name = "ButtonAutoFocus";
		v().Size = new Size(128, 29);
		v().TabIndex = 9;
		v().Text = "Auto Focus";
		m().SetToolTip(v(), "Auto focus using image");
		v().UseVisualStyleBackColor = true;
		v().Visible = false;
		ax().Anchor = AnchorStyles.Top;
		ax().AutoSize = true;
		ax().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ax().ColumnCount = 1;
		ax().ColumnStyles.Add(new ColumnStyle());
		ax().Controls.Add(af(), 0, 1);
		ax().Controls.Add(z(), 0, 0);
		ax().Location = new Point(3, 76);
		ax().Name = "TableLayoutPanel1";
		ax().RowCount = 2;
		ax().RowStyles.Add(new RowStyle());
		ax().RowStyles.Add(new RowStyle());
		ax().Size = new Size(294, 105);
		ax().TabIndex = 11;
		af().AutoSize = true;
		af().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		af().ColumnCount = 6;
		af().ColumnStyles.Add(new ColumnStyle());
		af().ColumnStyles.Add(new ColumnStyle());
		af().ColumnStyles.Add(new ColumnStyle());
		af().ColumnStyles.Add(new ColumnStyle());
		af().ColumnStyles.Add(new ColumnStyle());
		af().ColumnStyles.Add(new ColumnStyle());
		af().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
		af().Controls.Add(ag(), 5, 0);
		af().Controls.Add(ah(), 4, 0);
		af().Controls.Add(ai(), 2, 0);
		af().Controls.Add(aj(), 3, 0);
		af().Controls.Add(ak(), 1, 0);
		af().Controls.Add(al(), 0, 0);
		af().Location = new Point(0, 70);
		af().Margin = new Padding(0);
		af().Name = "TableLayoutPanelZ";
		af().RowCount = 1;
		af().RowStyles.Add(new RowStyle());
		af().Size = new Size(294, 35);
		af().TabIndex = 5;
		af().Visible = false;
		ag().Anchor = AnchorStyles.Left;
		ag().AutoSize = true;
		ag().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ag().ImeMode = ImeMode.NoControl;
		ag().Location = new Point(242, 9);
		ag().Name = "LabelZ";
		ag().Size = new Size(49, 16);
		ag().TabIndex = 85;
		ag().Text = "Z (mm)";
		ah().Anchor = AnchorStyles.Left;
		ah().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ah().f(A_0: false);
		ah().Location = new Point(171, 6);
		ah().Name = "TextBoxNumericZPosition";
		ah().e(A_0: true);
		ah().Size = new Size(65, 22);
		ah().TabIndex = 4;
		m().SetToolTip(ah(), "To set height, enter height here and click Move");
		ai().Anchor = AnchorStyles.Left;
		ai().Font = new Font("Microsoft Sans Serif", 12f);
		ai().Image = Resources.SlowAscend;
		ai().ImeMode = ImeMode.NoControl;
		ai().Location = new Point(87, 3);
		ai().Name = "ButtonZSlowUp";
		ai().Size = new Size(36, 29);
		ai().TabIndex = 78;
		ai().TabStop = false;
		ai().UseVisualStyleBackColor = true;
		aj().Anchor = AnchorStyles.Left;
		aj().Font = new Font("Microsoft Sans Serif", 12f);
		aj().Image = Resources.FastAscend;
		aj().ImeMode = ImeMode.NoControl;
		aj().Location = new Point(129, 3);
		aj().Name = "ButtonZFastUp";
		aj().Size = new Size(36, 29);
		aj().TabIndex = 77;
		aj().TabStop = false;
		aj().UseVisualStyleBackColor = true;
		ak().Anchor = AnchorStyles.Left;
		ak().Font = new Font("Microsoft Sans Serif", 12f);
		ak().Image = Resources.SlowDescend;
		ak().ImeMode = ImeMode.NoControl;
		ak().Location = new Point(45, 3);
		ak().Name = "ButtonZSlowDown";
		ak().Size = new Size(36, 29);
		ak().TabIndex = 79;
		ak().TabStop = false;
		ak().UseVisualStyleBackColor = true;
		al().Anchor = AnchorStyles.Left;
		al().Font = new Font("Microsoft Sans Serif", 12f);
		al().Image = Resources.FastDescend;
		al().ImeMode = ImeMode.NoControl;
		al().Location = new Point(3, 3);
		al().Name = "ButtonZFastDown";
		al().Size = new Size(36, 29);
		al().TabIndex = 80;
		al().TabStop = false;
		al().UseVisualStyleBackColor = true;
		z().AutoSize = true;
		z().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		z().ColumnCount = 5;
		z().ColumnStyles.Add(new ColumnStyle());
		z().ColumnStyles.Add(new ColumnStyle());
		z().ColumnStyles.Add(new ColumnStyle());
		z().ColumnStyles.Add(new ColumnStyle());
		z().ColumnStyles.Add(new ColumnStyle());
		z().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
		z().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
		z().Controls.Add(am(), 4, 1);
		z().Controls.Add(s(), 1, 1);
		z().Controls.Add(an(), 4, 0);
		z().Controls.Add(n(), 3, 0);
		z().Controls.Add(q(), 0, 0);
		z().Controls.Add(o(), 2, 0);
		z().Controls.Add(p(), 1, 0);
		z().Controls.Add(u(), 3, 1);
		z().Controls.Add(r(), 0, 1);
		z().Controls.Add(t(), 2, 1);
		z().Location = new Point(0, 0);
		z().Margin = new Padding(0);
		z().Name = "TableLayoutPanelRTheta";
		z().RowCount = 2;
		z().RowStyles.Add(new RowStyle());
		z().RowStyles.Add(new RowStyle());
		z().Size = new Size(249, 70);
		z().TabIndex = 0;
		z().Visible = false;
		am().Anchor = AnchorStyles.Left;
		am().AutoSize = true;
		am().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		am().ImeMode = ImeMode.NoControl;
		am().Location = new Point(171, 44);
		am().Name = "Label2";
		am().Size = new Size(75, 16);
		am().TabIndex = 89;
		am().Text = "Translation";
		s().Anchor = AnchorStyles.Left;
		s().Font = new Font("Microsoft Sans Serif", 12f);
		s().Image = Resources.SlowDescend;
		s().ImeMode = ImeMode.NoControl;
		s().Location = new Point(45, 38);
		s().Name = "ButtonRInSlow";
		s().Size = new Size(36, 29);
		s().TabIndex = 31;
		s().TabStop = false;
		s().UseVisualStyleBackColor = true;
		an().Anchor = AnchorStyles.Left;
		an().AutoSize = true;
		an().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		an().ImeMode = ImeMode.NoControl;
		an().Location = new Point(171, 9);
		an().Name = "Label3";
		an().Size = new Size(58, 16);
		an().TabIndex = 87;
		an().Text = "Rotation";
		n().Anchor = AnchorStyles.Left;
		n().Font = new Font("Microsoft Sans Serif", 12f);
		n().ImeMode = ImeMode.NoControl;
		n().Location = new Point(129, 3);
		n().Name = "ButtonCWFast";
		n().Size = new Size(36, 29);
		n().TabIndex = 85;
		n().TabStop = false;
		n().UseVisualStyleBackColor = true;
		q().Anchor = AnchorStyles.Left;
		q().Font = new Font("Microsoft Sans Serif", 12f);
		q().ImeMode = ImeMode.NoControl;
		q().Location = new Point(3, 3);
		q().Name = "ButtonCCWFast";
		q().Size = new Size(36, 29);
		q().TabIndex = 82;
		q().TabStop = false;
		q().UseVisualStyleBackColor = true;
		o().Anchor = AnchorStyles.Left;
		o().Font = new Font("Microsoft Sans Serif", 12f);
		o().ImeMode = ImeMode.NoControl;
		o().Location = new Point(87, 3);
		o().Name = "ButtonCWSlow";
		o().Size = new Size(36, 29);
		o().TabIndex = 84;
		o().TabStop = false;
		o().UseVisualStyleBackColor = true;
		p().Anchor = AnchorStyles.Left;
		p().Font = new Font("Microsoft Sans Serif", 12f);
		p().ImeMode = ImeMode.NoControl;
		p().Location = new Point(45, 3);
		p().Name = "ButtonCCWSlow";
		p().Size = new Size(36, 29);
		p().TabIndex = 83;
		p().TabStop = false;
		p().UseVisualStyleBackColor = true;
		u().Anchor = AnchorStyles.Left;
		u().Font = new Font("Microsoft Sans Serif", 12f);
		u().Image = Resources.FastAscend;
		u().ImeMode = ImeMode.NoControl;
		u().Location = new Point(129, 38);
		u().Name = "ButtonROutFast";
		u().Size = new Size(36, 29);
		u().TabIndex = 33;
		u().TabStop = false;
		u().UseVisualStyleBackColor = true;
		r().Anchor = AnchorStyles.Left;
		r().Font = new Font("Microsoft Sans Serif", 12f);
		r().Image = Resources.FastDescend;
		r().ImeMode = ImeMode.NoControl;
		r().Location = new Point(3, 38);
		r().Name = "ButtonRInFast";
		r().Size = new Size(36, 29);
		r().TabIndex = 30;
		r().TabStop = false;
		r().UseVisualStyleBackColor = true;
		t().Anchor = AnchorStyles.Left;
		t().Font = new Font("Microsoft Sans Serif", 12f);
		t().Image = Resources.SlowAscend;
		t().ImeMode = ImeMode.NoControl;
		t().Location = new Point(87, 38);
		t().Name = "ButtonROutSlow";
		t().Size = new Size(36, 29);
		t().TabIndex = 32;
		t().TabStop = false;
		t().UseVisualStyleBackColor = true;
		base.AcceptButton = e();
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = f();
		base.ClientSize = new Size(315, 380);
		base.Controls.Add(g());
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogFocusImage";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.Manual;
		Text = "Measurement Spot Focus";
		g().ResumeLayout(performLayout: false);
		g().PerformLayout();
		y().ResumeLayout(performLayout: false);
		y().PerformLayout();
		ao().ResumeLayout(performLayout: false);
		ao().PerformLayout();
		ae().ResumeLayout(performLayout: false);
		ae().PerformLayout();
		h().ResumeLayout(performLayout: false);
		x().ResumeLayout(performLayout: false);
		ax().ResumeLayout(performLayout: false);
		ax().PerformLayout();
		af().ResumeLayout(performLayout: false);
		af().PerformLayout();
		z().ResumeLayout(performLayout: false);
		z().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button e()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c(Button A_0)
	{
		EventHandler value = f;
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
	public virtual Button f()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void d(Button A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel g()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel h()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TableLayoutPanel A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label i()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button j()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Button A_0)
	{
		EventHandler value = c;
		Button button = this.m_g;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_g = A_0;
		button = this.m_g;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button k()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Button A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button l()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Button A_0)
	{
		EventHandler value = e;
		Button button = this.m_i;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_i = A_0;
		button = this.m_i;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip m()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ToolTip A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button n()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Button A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button o()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Button A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button p()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Button A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button q()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Button A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button r()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(Button A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button s()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(Button A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button t()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(Button A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button u()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(Button A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button v()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(Button A_0)
	{
		EventHandler value = d;
		Button button = this.m_s;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_s = A_0;
		button = this.m_s;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button w()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(Button A_0)
	{
		EventHandler value = e;
		Button button = this.m_t;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_t = A_0;
		button = this.m_t;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel x()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Panel A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel y()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TableLayoutPanel A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel z()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(TableLayoutPanel A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy aa()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(hy A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ab()
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
	internal virtual Label ac()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ad()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(hy A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ae()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(TableLayoutPanel A_0)
	{
		this.m_ab = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel af()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(TableLayoutPanel A_0)
	{
		this.m_ac = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ag()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_ad = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ah()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(hy A_0)
	{
		this.m_ae = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ai()
	{
		return this.m_af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(Button A_0)
	{
		this.m_af = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button aj()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(Button A_0)
	{
		this.m_ag = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ak()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(Button A_0)
	{
		this.m_ah = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button al()
	{
		return this.m_ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(Button A_0)
	{
		this.m_ai = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label am()
	{
		return this.m_aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Label A_0)
	{
		this.m_aj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label an()
	{
		return this.m_ak;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Label A_0)
	{
		this.m_ak = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ao()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TableLayoutPanel A_0)
	{
		this.m_al = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ap()
	{
		return this.m_am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(Button A_0)
	{
		this.m_am = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button aq()
	{
		return this.m_an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(Button A_0)
	{
		this.m_an = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ar()
	{
		return this.m_ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(Button A_0)
	{
		this.m_ao = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button @as()
	{
		return this.m_ap;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(Button A_0)
	{
		this.m_ap = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button at()
	{
		return this.m_aq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(Button A_0)
	{
		this.m_aq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button au()
	{
		return this.m_ar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aa(Button A_0)
	{
		this.m_ar = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button av()
	{
		return this.m_as;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(Button A_0)
	{
		this.m_as = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button aw()
	{
		return this.m_at;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(Button A_0)
	{
		this.m_at = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ax()
	{
		return this.m_au;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(TableLayoutPanel A_0)
	{
		this.m_au = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d ay()
	{
		return a2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void c(r.d A_0)
	{
		r.d.b a_ = e;
		a2?.e(a_);
		a2 = A_0;
		a2?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d az()
	{
		return a3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void d(r.d A_0)
	{
		r.d.b a_ = d;
		a3?.e(a_);
		a3 = A_0;
		a3?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d a0()
	{
		return a4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void e(r.d A_0)
	{
		r.d.b a_ = c;
		a4?.e(a_);
		a4 = A_0;
		a4?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d a1()
	{
		return a5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void f(r.d A_0)
	{
		r.d.b a_ = c;
		a5?.e(a_);
		a5 = A_0;
		a5?.d(a_);
	}

	public bg(f1 A_0, fz A_1, Guid A_2)
	{
		c(new r.d());
		d(new r.d());
		e(new r.d());
		d();
		this.m_av = A_0;
		this.m_aw = A_1;
		this.m_ax = A_2;
	}

	private void c()
	{
		ar().Visible = false;
		at().Visible = false;
		@as().Visible = false;
		aq().Visible = false;
		av().Visible = false;
		ap().Visible = false;
		aw().Visible = false;
		au().Visible = false;
	}

	private void c(Guid A_0, ref string A_1, ref string A_2, ref bool A_3, ref bool A_4, bool A_5)
	{
		string text = null;
		if (this.m_ay == 1.0)
		{
			A_1 = text;
		}
		else
		{
			A_1 = Conversions.ToString(this.m_ay * double.Parse(text));
		}
	}

	public void c(Point A_0, a A_1, b A_2, bool A_3, r.d A_4)
	{
		bool flag = this.m_av.p9(this.m_ax);
		bool flag2 = this.m_av.qh(this.m_ax);
		f(A_4);
		this.m_a1 = A_1;
		if (flag || flag2)
		{
			if (flag)
			{
				af().Visible = true;
			}
			else
			{
				af().Visible = false;
			}
			bool flag3 = default(bool);
			v().Visible = flag || flag3;
			l().Visible = flag && !flag3;
			bool flag4 = default(bool);
			j().Visible = flag4 || (flag && !flag3);
			k().Visible = flag4 || (flag && !flag3);
			w().Visible = flag2 || flag3;
			x().Visible = flag2 || flag3;
			switch (this.m_a1)
			{
			case bg.a.a:
				if (A_2 == bg.b.b && !flag3)
				{
					i().Text = "Adjust Focus until image is focused.\r\nClick OK to continue Baseline, click Cancel to abort.";
				}
				else if (A_2 == bg.b.c)
				{
					i().Text = "Adjust Focus until image is focused and/or the signal is maximized.\r\nClick OK to continue Baseline, click Cancel to abort.";
				}
				break;
			case bg.a.e:
				if (A_2 == bg.b.b && !flag3)
				{
					i().Text = "Adjust Focus until image is focused.\r\nClick OK to continue calibration, click Cancel to abort.";
				}
				else if (A_2 == bg.b.c)
				{
					i().Text = "Adjust Focus until image is focused and/or the signal is maximized.\r\nClick OK to continue calibration, click Cancel to abort.";
				}
				else
				{
					i().Text = "Adjust Focus until the signal is maximized.\r\nClick OK to continue calibration, click Cancel to abort.";
				}
				break;
			}
			if (!flag4)
			{
				ao().Visible = false;
			}
		}
		i6.a(A_0, this);
		ShowDialog();
	}

	private void f(object A_0, EventArgs A_1)
	{
		base.DialogResult = DialogResult.OK;
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			Cursor = Cursors.WaitCursor;
			this.m_av.m2(this.m_ax, global::r.d.a.b.a, ay());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			Cursor = Cursors.Default;
			i5.a(this.m_aw, this.m_av, this, i6.a(l()), "DialogFocusImage.ButtonAdjustCounts_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			Cursor = Cursors.WaitCursor;
			if (this.m_a1 == bg.a.c)
			{
				_ = 1;
			}
			else
				_ = this.m_a1 == bg.a.b;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			Cursor = Cursors.Default;
			i5.a(this.m_aw, this.m_av, this, i6.a(v()), "DialogFocusImage.ButtonAutoFocus_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			string A_2 = null;
			string A_3 = null;
			bool flag = false;
			Guid a_ = this.m_ax;
			bool A_4 = false;
			bool A_5 = false;
			c(a_, ref A_2, ref A_3, ref A_4, ref A_5, A_5: false);
			if (Operators.CompareString(A_2, aa().Text, TextCompare: false) != 0 || Operators.CompareString(A_3, ad().Text, TextCompare: false) != 0)
			{
				double num = iz.e(aa().Text);
				if (!jf.e(this.m_ay, 1.0))
				{
					num /= this.m_ay;
				}
				if (flag)
				{
					fz a_2 = this.m_aw;
					string A_6 = "ErrInvalidLocation";
					fe.b(a_2, hw.a(ref A_6), i6.a(this));
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			i5.a(this.m_aw, this.m_av, this, i6.a(l()), "DialogFocusImage.ButtonAutoFocus_Click", a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void e(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new r.d.b(e), A_0);
				return;
			}
			Cursor = Cursors.Default;
			if (A_0.a != global::r.d.a.a.a)
			{
				fe.b(this.m_aw, "Error encountered while attempting to optimize the spectrometer counts.", i6.a(this));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_aw.c(fz.b.b, "Exception caught in DialogFocusImage.AdjustCountsFinishedHandler()", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new r.d.b(d), A_0);
				return;
			}
			Cursor = Cursors.Default;
			if (A_0.a != global::r.d.a.a.a)
			{
				fe.b(this.m_aw, "Error encountered while attempting to auto focus.", i6.a(this));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_aw.c(fz.b.b, "Exception caught in DialogFocusImage.AutoFocusFinishedHandler()", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(r.d.a A_0)
	{
		if (base.InvokeRequired)
		{
			Invoke(new r.d.b(c), A_0);
			return;
		}
		r.d.a a10 = A_0;
		if (a10.a != global::r.d.a.a.a)
		{
			fe.b(this.m_aw, a10.b, i6.a(this));
		}
		else
		{
			k().PerformClick();
		}
		a10 = null;
	}
}
