using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Filmetrics.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

internal class fb : fj
{
	private new delegate void a();

	private new const int m_a = 120;

	private new const int m_b = 90;

	private new const int m_c = 10;

	private new const int m_d = 7;

	private new fu m_e;

	private new fl m_f;

	private new short m_g;

	private new string m_h;

	private bool m_i;

	private Control m_j;

	private Font m_k;

	private int m_l;

	private int m;

	private int n;

	private int m_o;

	private int m_p;

	private bool m_q;

	private const string m_r = "DialogGraphLimits.";

	[CompilerGenerated]
	private CheckBox m_s;

	[CompilerGenerated]
	private CheckBox m_t;

	[CompilerGenerated]
	private hy m_u;

	[CompilerGenerated]
	private hy m_v;

	[CompilerGenerated]
	private hy w;

	[CompilerGenerated]
	private hy m_x;

	[CompilerGenerated]
	private hy m_y;

	[CompilerGenerated]
	private hy m_z;

	[CompilerGenerated]
	private PictureBox m_aa;

	[CompilerGenerated]
	private ToolTip m_ab;

	[CompilerGenerated]
	private TabPage m_ac;

	[CompilerGenerated]
	private TabControl m_ad;

	[CompilerGenerated]
	private CheckBox m_ae;

	[CompilerGenerated]
	private CheckBox m_ag;

	[CompilerGenerated]
	private Button m_ah;

	[CompilerGenerated]
	private Button m_ai;

	[CompilerGenerated]
	private Button m_aj;

	private static fb m_ak;

	[CompilerGenerated]
	private CheckBox m_al;

	[CompilerGenerated]
	private CheckBox m_am;

	[CompilerGenerated]
	private CheckBox an;

	[CompilerGenerated]
	private CheckBox ao;

	private IContainer ap;

	static fb()
	{
		fb.m_ak = null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox p()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(CheckBox A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox q()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void c(CheckBox A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy r()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(hy A_0)
	{
		EventHandler value = h;
		EventHandler value2 = g;
		hy hy2 = this.m_u;
		if (hy2 != null)
		{
			hy2.GotFocus -= value;
			hy2.TextChanged -= value2;
		}
		this.m_u = A_0;
		hy2 = this.m_u;
		if (hy2 != null)
		{
			hy2.GotFocus += value;
			hy2.TextChanged += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy s()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void c(hy A_0)
	{
		EventHandler value = j;
		EventHandler value2 = h;
		hy hy2 = this.m_v;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
			hy2.GotFocus -= value2;
		}
		this.m_v = A_0;
		hy2 = this.m_v;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
			hy2.GotFocus += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy t()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void d(hy A_0)
	{
		EventHandler value = i;
		EventHandler value2 = h;
		hy hy2 = w;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
			hy2.GotFocus -= value2;
		}
		w = A_0;
		hy2 = w;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
			hy2.GotFocus += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy u()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void e(hy A_0)
	{
		EventHandler value = h;
		EventHandler value2 = f;
		hy hy2 = this.m_x;
		if (hy2 != null)
		{
			hy2.GotFocus -= value;
			hy2.TextChanged -= value2;
		}
		this.m_x = A_0;
		hy2 = this.m_x;
		if (hy2 != null)
		{
			hy2.GotFocus += value;
			hy2.TextChanged += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy v()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void f(hy A_0)
	{
		EventHandler value = h;
		EventHandler value2 = d;
		hy hy2 = this.m_y;
		if (hy2 != null)
		{
			hy2.GotFocus -= value;
			hy2.TextChanged -= value2;
		}
		this.m_y = A_0;
		hy2 = this.m_y;
		if (hy2 != null)
		{
			hy2.GotFocus += value;
			hy2.TextChanged += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy x()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void g(hy A_0)
	{
		EventHandler value = h;
		EventHandler value2 = e;
		hy hy2 = this.m_z;
		if (hy2 != null)
		{
			hy2.GotFocus -= value;
			hy2.TextChanged -= value2;
		}
		this.m_z = A_0;
		hy2 = this.m_z;
		if (hy2 != null)
		{
			hy2.GotFocus += value;
			hy2.TextChanged += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox y()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(PictureBox A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip z()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ToolTip A_0)
	{
		this.m_ab = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage aa()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TabPage A_0)
	{
		PaintEventHandler value = b;
		TabPage tabPage = this.m_ac;
		if (tabPage != null)
		{
			tabPage.Paint -= value;
		}
		this.m_ac = A_0;
		tabPage = this.m_ac;
		if (tabPage != null)
		{
			tabPage.Paint += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabControl ab()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TabControl A_0)
	{
		this.m_ad = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ac()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void d(CheckBox A_0)
	{
		EventHandler value = c;
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
	internal virtual CheckBox ad()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void e(CheckBox A_0)
	{
		EventHandler value = b;
		CheckBox checkBox = this.m_ag;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_ag = A_0;
		checkBox = this.m_ag;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ae()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = k;
		Button button = this.m_ah;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ah = A_0;
		button = this.m_ah;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ag()
	{
		return this.m_ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void c(Button A_0)
	{
		EventHandler value = o;
		Button button = this.m_ai;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ai = A_0;
		button = this.m_ai;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ah()
	{
		return this.m_aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void d(Button A_0)
	{
		EventHandler value = l;
		Button button = this.m_aj;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_aj = A_0;
		button = this.m_aj;
		if (button != null)
		{
			button.Click += value;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && ap != null)
		{
			ap.Dispose();
		}
		base.Dispose(disposing);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ai()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void f(CheckBox A_0)
	{
		this.m_al = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox aj()
	{
		return this.m_am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void g(CheckBox A_0)
	{
		this.m_am = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ak()
	{
		return an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void h(CheckBox A_0)
	{
		an = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox al()
	{
		return ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(CheckBox A_0)
	{
		ao = A_0;
	}

	[DebuggerNonUserCode]
	private void o()
	{
		ap = new Container();
		c(new hy());
		d(new hy());
		f(new CheckBox());
		h(new CheckBox());
		e(new hy());
		b(new hy());
		g(new CheckBox());
		i(new CheckBox());
		f(new hy());
		g(new hy());
		b(new CheckBox());
		c(new CheckBox());
		b(new PictureBox());
		b(new ToolTip(ap));
		d(new CheckBox());
		e(new CheckBox());
		b(new TabPage());
		b(new TabControl());
		b(new Button());
		c(new Button());
		d(new Button());
		((ISupportInitialize)y()).BeginInit();
		aa().SuspendLayout();
		ab().SuspendLayout();
		SuspendLayout();
		s().f(A_0: false);
		s().Location = new Point(191, 226);
		s().Margin = new Padding(4);
		s().Name = "xMaxBox";
		s().e(A_0: true);
		s().Size = new Size(53, 22);
		s().TabIndex = 3;
		s().TextAlign = HorizontalAlignment.Center;
		t().f(A_0: false);
		t().Location = new Point(32, 226);
		t().Margin = new Padding(4);
		t().Name = "xMinBox";
		t().e(A_0: true);
		t().Size = new Size(53, 22);
		t().TabIndex = 2;
		t().TextAlign = HorizontalAlignment.Center;
		ai().AutoSize = true;
		ai().BackColor = SystemColors.ControlLightLight;
		ai().Cursor = Cursors.Default;
		ai().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ai().ForeColor = SystemColors.ControlText;
		ai().Location = new Point(42, 253);
		ai().Margin = new Padding(1);
		ai().Name = "xMinAutoScaleCheck";
		ai().RightToLeft = RightToLeft.No;
		ai().Size = new Size(54, 20);
		ai().TabIndex = 10;
		ai().Text = "Auto";
		z().SetToolTip(ai(), "Automatically adjust the limit");
		ai().UseVisualStyleBackColor = false;
		ai().Visible = false;
		ak().AutoSize = true;
		ak().BackColor = SystemColors.ControlLightLight;
		ak().Cursor = Cursors.Default;
		ak().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ak().ForeColor = SystemColors.ControlText;
		ak().Location = new Point(201, 253);
		ak().Margin = new Padding(1);
		ak().Name = "xMaxAutoScaleCheck";
		ak().RightToLeft = RightToLeft.No;
		ak().Size = new Size(54, 20);
		ak().TabIndex = 11;
		ak().Text = "Auto";
		z().SetToolTip(ak(), "Automatically adjust the limit");
		ak().UseVisualStyleBackColor = false;
		ak().Visible = false;
		u().f(A_0: false);
		u().Location = new Point(7, 196);
		u().Margin = new Padding(4);
		u().Name = "yMinBox";
		u().e(A_0: true);
		u().Size = new Size(46, 22);
		u().TabIndex = 1;
		u().TextAlign = HorizontalAlignment.Right;
		r().f(A_0: false);
		r().Location = new Point(7, 7);
		r().Margin = new Padding(4);
		r().Name = "yMaxBox";
		r().e(A_0: true);
		r().Size = new Size(46, 22);
		r().TabIndex = 0;
		r().Text = "100.45";
		r().TextAlign = HorizontalAlignment.Right;
		aj().AutoSize = true;
		aj().BackColor = Color.Transparent;
		aj().Cursor = Cursors.Default;
		aj().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aj().ForeColor = SystemColors.ControlText;
		aj().Location = new Point(7, 172);
		aj().Margin = new Padding(1);
		aj().Name = "yMinAutoScaleCheck";
		aj().RightToLeft = RightToLeft.No;
		aj().Size = new Size(54, 20);
		aj().TabIndex = 7;
		aj().Text = "Auto";
		z().SetToolTip(aj(), "Automatically adjust the limit");
		aj().UseVisualStyleBackColor = false;
		aj().Visible = false;
		al().AutoSize = true;
		al().BackColor = Color.Transparent;
		al().Checked = true;
		al().CheckState = CheckState.Checked;
		al().Cursor = Cursors.Default;
		al().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		al().ForeColor = SystemColors.ControlText;
		al().Location = new Point(7, 32);
		al().Margin = new Padding(1);
		al().Name = "yMaxAutoScaleCheck";
		al().RightToLeft = RightToLeft.No;
		al().Size = new Size(54, 20);
		al().TabIndex = 6;
		al().Text = "Auto";
		z().SetToolTip(al(), "Automatically adjust the limit");
		al().UseVisualStyleBackColor = false;
		v().f(A_0: false);
		v().Location = new Point(226, 196);
		v().Margin = new Padding(4);
		v().Name = "y2MinBox";
		v().e(A_0: true);
		v().Size = new Size(46, 22);
		v().TabIndex = 4;
		x().f(A_0: false);
		x().Location = new Point(226, 7);
		x().Margin = new Padding(4);
		x().Name = "y2MaxBox";
		x().e(A_0: true);
		x().Size = new Size(46, 22);
		x().TabIndex = 5;
		p().AutoSize = true;
		p().BackColor = Color.Transparent;
		p().Cursor = Cursors.Default;
		p().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		p().ForeColor = SystemColors.ControlText;
		p().Location = new Point(226, 172);
		p().Margin = new Padding(1);
		p().Name = "y2MinAutoScaleCheck";
		p().RightToLeft = RightToLeft.No;
		p().Size = new Size(54, 20);
		p().TabIndex = 9;
		p().Text = "Auto";
		z().SetToolTip(p(), "Automatically adjust the limit");
		p().UseVisualStyleBackColor = false;
		p().Visible = false;
		q().AutoSize = true;
		q().BackColor = Color.Transparent;
		q().Checked = true;
		q().CheckState = CheckState.Checked;
		q().Cursor = Cursors.Default;
		q().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		q().ForeColor = SystemColors.ControlText;
		q().Location = new Point(226, 32);
		q().Margin = new Padding(1);
		q().Name = "y2MaxAutoScaleCheck";
		q().RightToLeft = RightToLeft.No;
		q().Size = new Size(54, 20);
		q().TabIndex = 8;
		q().Text = "Auto";
		z().SetToolTip(q(), "Automatically adjust the limit");
		q().UseVisualStyleBackColor = false;
		y().BorderStyle = BorderStyle.FixedSingle;
		y().Image = Resources.chart;
		y().Location = new Point(61, 18);
		y().Margin = new Padding(4);
		y().Name = "PictureBoxGraphImage";
		y().Size = new Size(160, 190);
		y().SizeMode = PictureBoxSizeMode.StretchImage;
		y().TabIndex = 7;
		y().TabStop = false;
		ac().Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		ac().AutoSize = true;
		ac().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ac().Location = new Point(67, 278);
		ac().Margin = new Padding(4);
		ac().Name = "CheckBoxGraphDataPercent";
		ac().Size = new Size(152, 20);
		ac().TabIndex = 13;
		ac().Text = "Y axis as percent (%)";
		z().SetToolTip(ac(), "Plot data as percent.");
		ac().UseVisualStyleBackColor = true;
		ad().AutoSize = true;
		ad().BackColor = Color.Transparent;
		ad().Cursor = Cursors.Default;
		ad().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ad().ForeColor = SystemColors.ControlText;
		ad().Location = new Point(78, 171);
		ad().Margin = new Padding(4);
		ad().Name = "CheckGrid";
		ad().RightToLeft = RightToLeft.No;
		ad().Size = new Size(114, 20);
		ad().TabIndex = 12;
		ad().Text = "Show Gridlines";
		z().SetToolTip(ad(), "Show gridlines on the chart.");
		ad().UseVisualStyleBackColor = false;
		aa().Controls.Add(ai());
		aa().Controls.Add(ac());
		aa().Controls.Add(ak());
		aa().Controls.Add(p());
		aa().Controls.Add(ad());
		aa().Controls.Add(q());
		aa().Controls.Add(aj());
		aa().Controls.Add(al());
		aa().Controls.Add(y());
		aa().Controls.Add(s());
		aa().Controls.Add(r());
		aa().Controls.Add(t());
		aa().Controls.Add(x());
		aa().Controls.Add(v());
		aa().Controls.Add(u());
		aa().Location = new Point(4, 25);
		aa().Margin = new Padding(3, 1, 3, 3);
		aa().Name = "TabPageLimits";
		aa().Padding = new Padding(3);
		aa().Size = new Size(288, 304);
		aa().TabIndex = 0;
		aa().Text = "Limits";
		aa().UseVisualStyleBackColor = true;
		ab().Controls.Add(aa());
		ab().Location = new Point(10, 10);
		ab().Margin = new Padding(1);
		ab().Name = "TabControlGraph";
		ab().SelectedIndex = 0;
		ab().Size = new Size(296, 333);
		ab().TabIndex = 17;
		ab().TabStop = false;
		ae().Cursor = Cursors.Default;
		ae().DialogResult = DialogResult.Cancel;
		ae().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae().Location = new Point(138, 346);
		ae().Margin = new Padding(4);
		ae().Name = "SetLimitsCancelButton";
		ae().Size = new Size(78, 30);
		ae().TabIndex = 15;
		ae().Text = "&Cancel";
		ag().Cursor = Cursors.Default;
		ag().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ag().Location = new Point(56, 346);
		ag().Margin = new Padding(4);
		ag().Name = "SetLimitsOkButton";
		ag().Size = new Size(78, 30);
		ag().TabIndex = 14;
		ag().Text = "&OK";
		ah().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ah().Location = new Point(220, 346);
		ah().Margin = new Padding(4, 4, 8, 8);
		ah().Name = "SetLimitsApplyButton";
		ah().Size = new Size(78, 30);
		ah().TabIndex = 16;
		ah().Text = "&Apply";
		ah().UseVisualStyleBackColor = true;
		base.AcceptButton = ag();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = ae();
		base.ClientSize = new Size(316, 386);
		base.ControlBox = true;
		base.Controls.Add(ah());
		base.Controls.Add(ag());
		base.Controls.Add(ae());
		base.Controls.Add(ab());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogGraphLimits";
		Text = "Graph";
		base.TopMost = true;
		((ISupportInitialize)y()).EndInit();
		aa().ResumeLayout(performLayout: false);
		aa().PerformLayout();
		ab().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	private fb()
	{
		base.FormClosing += b;
		this.m_h = "0.##";
		this.m_i = false;
		this.m_k = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point);
		o();
	}

	private fb(fz A_0)
		: this()
	{
		base.c = A_0;
	}

	public static fb b(fz A_0)
	{
		if (fb.m_ak == null)
		{
			fb.m_ak = new fb(A_0);
		}
		return fb.m_ak;
	}

	public static void l()
	{
		fb.m_ak = null;
	}

	[SpecialName]
	protected override Control af()
	{
		return base.f.ar();
	}

	[SpecialName]
	public short am()
	{
		return this.m_g;
	}

	[SpecialName]
	public void b(short A_0)
	{
		this.m_g = A_0;
	}

	public void b(fl A_0, Point A_1)
	{
		Conversions.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
		checked
		{
			try
			{
				j();
				this.m_o = al().Top - r().Top - r().Height;
				this.m_f = A_0;
				this.m_e = this.m_f.gi();
				fu fu2 = this.m_e;
				al().Checked = fu2.ao();
				aj().Checked = fu2.ap();
				this.m_i = A_0.gl();
				x().Visible = this.m_i;
				v().Visible = this.m_i;
				q().Visible = this.m_i;
				q().Checked = fu2.aq();
				p().Checked = fu2.ar();
				ak().Visible = this.m_f.gn;
				if (this.m_f.gy() == null || !this.m_f.gy().g() || ((this.m_f.gy().h() >= gq.a.c || !this.m_f.ek) && this.m_f.gy().g()))
				{
					this.m_q = true;
					fr fr2 = fu2.a2();
					ak().Checked = fr2.ar();
					ai().Checked = fr2.@as();
					fr2 = null;
				}
				else
				{
					this.m_q = false;
					t().Text = null;
					s().Text = null;
				}
				t().Enabled = this.m_q;
				s().Enabled = this.m_q;
				ad().Checked = fu2.av();
				b();
				b(A_0: true);
				ac().Checked = fu2.at();
				ac().Visible = this.m_f.fm();
				c();
				fu2 = null;
			}
			finally
			{
				k();
			}
			BringToFront();
			base.Left = A_1.X - unchecked(base.Width / 2);
			base.Top = A_1.Y - unchecked(base.Height / 2);
			if (this.m_j != null && this.m_j.Enabled)
			{
				base.ActiveControl = this.m_j;
			}
			this.m_e.am(h);
			Refresh();
			Show();
		}
	}

	private void b(bool A_0)
	{
		char c10 = Conversions.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
		fu fu2 = this.m_e;
		double num = fu2.a0();
		double num2 = fu2.at(false);
		double num3 = fu2.a1();
		double num4 = fu2.au(false);
		string right;
		string left;
		if (ak().Checked || A_0)
		{
			fr fr2 = fu2.a2();
			right = fr2.ap().ToString(this.m_h).TrimEnd(c10);
			left = fr2.aq().ToString(this.m_h).TrimEnd(c10);
			if (Operators.CompareString(left, right, TextCompare: false) != 0)
			{
				if (base.ActiveControl != t() || A_0)
				{
					t().Text = right;
				}
				if (base.ActiveControl != s() || A_0)
				{
					s().Text = left;
				}
			}
			else
			{
				if (base.ActiveControl != t() || A_0)
				{
					t().Text = fr2.ap().ToString();
				}
				if (base.ActiveControl != s() || A_0)
				{
					s().Text = fr2.aq().ToString();
				}
			}
			fr2 = null;
		}
		fu2 = null;
		if (this.m_f.gp())
		{
			num *= 100.0;
			num2 *= 100.0;
			num3 *= 100.0;
			num4 *= 100.0;
		}
		right = num.ToString(this.m_h).TrimEnd(c10);
		left = num2.ToString(this.m_h).TrimEnd(c10);
		string text = num3.ToString(this.m_h).TrimEnd(c10);
		string text2 = num4.ToString(this.m_h).TrimEnd(c10);
		string text3;
		string text4;
		string text5;
		string text6;
		if (Operators.CompareString(left, right, TextCompare: false) != 0)
		{
			text3 = right;
			text4 = left;
			text5 = text;
			text6 = text2;
		}
		else
		{
			text3 = num.ToString();
			text4 = num2.ToString();
			text5 = num3.ToString();
			text6 = num4.ToString();
		}
		if (al().Checked || A_0)
		{
			if (base.ActiveControl != u() || A_0)
			{
				u().Text = text3;
			}
			if (base.ActiveControl != r() || A_0)
			{
				r().Text = text4;
			}
		}
		if (p().Checked || A_0)
		{
			if (base.ActiveControl != v() || A_0)
			{
				v().Text = text5;
			}
			if (base.ActiveControl != x() || A_0)
			{
				x().Text = text6;
			}
		}
	}

	private void k()
	{
		checked
		{
			this.m_p--;
			if (this.m_p < 0)
			{
				this.m_p = 0;
			}
		}
	}

	private void j()
	{
		checked
		{
			this.m_p++;
		}
	}

	[SpecialName]
	private bool i()
	{
		return this.m_p > 0;
	}

	private new void h()
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new a(h));
				return;
			}
			try
			{
				j();
				b(A_0: false);
			}
			finally
			{
				k();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			base.c.c(fz.b.a, " Error in DialogGraphLimits.SettingChangedEventHandler", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		try
		{
			if (g())
			{
				this.m_e.an(h);
				Hide();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(base.c, null, null, e(), "DialogGraphLimits.SetLimitsOkButton_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		try
		{
			g();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(base.c, null, null, e(), "DialogGraphLimits.SetLimitsApplyButton_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private new bool g()
	{
		bool result2;
		try
		{
			float result3;
			float result4;
			float result5;
			float result6;
			float result7;
			if (!float.TryParse(s().Text, out var result))
			{
				fz a_ = base.c;
				string A_ = "InvalidEntryFmt";
				fe.b(a_, string.Format(hu.a(ref A_), "x Max: "), i6.a(s()));
				base.ActiveControl = s();
				result2 = false;
			}
			else if (!float.TryParse(t().Text, out result3))
			{
				fz a_2 = base.c;
				string A_ = "InvalidEntryFmt";
				fe.b(a_2, string.Format(hu.a(ref A_), "x Min: "), i6.a(t()));
				base.ActiveControl = t();
				result2 = false;
			}
			else if (!float.TryParse(r().Text, out result4))
			{
				fz a_3 = base.c;
				string A_ = "InvalidEntryFmt";
				fe.b(a_3, string.Format(hu.a(ref A_), "Left y Max: "), i6.a(r()));
				base.ActiveControl = r();
				result2 = false;
			}
			else if (!float.TryParse(u().Text, out result5))
			{
				fz a_4 = base.c;
				string A_ = "InvalidEntryFmt";
				fe.b(a_4, string.Format(hu.a(ref A_), "Left y Min: "), i6.a(u()));
				base.ActiveControl = u();
				result2 = false;
			}
			else if (!float.TryParse(x().Text, out result6))
			{
				fz a_5 = base.c;
				string A_ = "InvalidEntryFmt";
				fe.b(a_5, string.Format(hu.a(ref A_), "Right y Max: "), i6.a(x()));
				base.ActiveControl = x();
				result2 = false;
			}
			else if (!float.TryParse(v().Text, out result7))
			{
				fz a_6 = base.c;
				string A_ = "InvalidEntryFmt";
				fe.b(a_6, string.Format(hu.a(ref A_), "Right y Min: "), i6.a(v()));
				base.ActiveControl = v();
				result2 = false;
			}
			else if (result - result3 <= 0f)
			{
				Point point = i6.a(t());
				Point point2 = i6.a(s());
				fe.b(base.c, "x Max - Min must be > 0.", new Point(checked(point.X + point2.X) / 2, checked(point.Y + point2.Y) / 2));
				base.ActiveControl = t();
				t().SelectAll();
				result2 = false;
			}
			else if (result4 - result5 <= 0f)
			{
				Point point = i6.a(u());
				Point point2 = i6.a(r());
				fe.b(base.c, "Left y Max - Min must be > 0.", new Point(checked(point.X + point2.X) / 2, checked(point.Y + point2.Y) / 2));
				base.ActiveControl = r();
				r().SelectAll();
				result2 = false;
			}
			else if (this.m_i && result6 - result7 <= 0f)
			{
				Point point = i6.a(v());
				Point point2 = i6.a(x());
				fe.b(base.c, "Right y Max - Min must be > 0.", new Point(checked(point.X + point2.X) / 2, checked(point.Y + point2.Y) / 2));
				base.ActiveControl = x();
				x().SelectAll();
				result2 = false;
			}
			else
			{
				f();
				result2 = true;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_7 = ex2;
			base.c.c(fz.b.a, " Error in DialogGraphLimits.SetLimitsOkButton_Click", a_7);
			result2 = false;
			ProjectData.ClearProjectError();
		}
		return result2;
	}

	private void k(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_e.an(h);
			Hide();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(base.c, null, null, e(), "DialogGraphLimits.SetLimitsCancelButton_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private new void f()
	{
		double num = Convert.ToDouble(r().Text);
		double num2 = Convert.ToDouble(u().Text);
		double num3 = Convert.ToDouble(x().Text);
		double num4 = Convert.ToDouble(v().Text);
		fu obj = this.m_e;
		obj.ar(ac().CheckState != CheckState.Unchecked);
		if (this.m_f.gp())
		{
			num /= 100.0;
			num2 /= 100.0;
			num3 /= 100.0;
			num4 /= 100.0;
		}
		obj.am(A_0: false, num);
		obj.am(num2);
		obj.an(A_0: false, num3);
		obj.an(num4);
		obj.@as(ad().Checked);
		obj.am(al().Checked);
		obj.an(aj().Checked);
		obj.ao(q().Checked);
		obj.ap(p().Checked);
		fr fr2 = obj.a2();
		if (this.m_f.gn)
		{
			fr2.am(ak().Checked);
			fr2.an(ai().Checked);
		}
		else
		{
			fr2.am(A_0: false);
			fr2.an(A_0: false);
		}
		fr2.an(Convert.ToDouble(s().Text));
		fr2.am(Convert.ToDouble(t().Text));
		fr2 = null;
		_ = null;
		this.m_f.g7();
	}

	private void j(object A_0, EventArgs A_1)
	{
		try
		{
			if (!i())
			{
				ak().Checked = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			base.c.c(fz.b.a, " Error in DialogGraphLimits.xMaxBox_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		try
		{
			if (!i())
			{
				ai().Checked = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			base.c.c(fz.b.a, " Error in DialogGraphLimits.xMinBox_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private new void h(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_j = (Control)A_0;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			base.c.c(fz.b.a, " Error in DialogGraphLimits.LimitBox_GotFocus", a_);
			ProjectData.ClearProjectError();
		}
	}

	private new void g(object A_0, EventArgs A_1)
	{
		try
		{
			if (!i())
			{
				al().Checked = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			base.c.c(fz.b.a, " Error in DialogGraphLimits.yMaxBox_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private new void f(object A_0, EventArgs A_1)
	{
		try
		{
			if (!i())
			{
				al().Checked = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			base.c.c(fz.b.a, " Error in DialogGraphLimits.yMinBox_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private new void e(object A_0, EventArgs A_1)
	{
		try
		{
			if (!i())
			{
				q().Checked = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			base.c.c(fz.b.a, " Error in DialogGraphLimits.y2MaxBox_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private new void d(object A_0, EventArgs A_1)
	{
		try
		{
			if (!i())
			{
				q().Checked = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			base.c.c(fz.b.a, " Error in DialogGraphLimits.y2MinBox_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private new void c(object A_0, EventArgs A_1)
	{
		try
		{
			char c10 = Conversions.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
			if (i())
			{
				return;
			}
			try
			{
				j();
				double num = Convert.ToDouble(r().Text);
				double num2 = Convert.ToDouble(u().Text);
				double num3 = Convert.ToDouble(x().Text);
				double num4 = Convert.ToDouble(v().Text);
				if (ac().Checked)
				{
					num *= 100.0;
					num2 *= 100.0;
					num3 *= 100.0;
					num4 *= 100.0;
					u().Text = num2.ToString(this.m_h).TrimEnd(c10);
					r().Text = num.ToString(this.m_h).TrimEnd(c10);
					v().Text = num4.ToString(this.m_h).TrimEnd(c10);
					x().Text = num3.ToString(this.m_h).TrimEnd(c10);
				}
				else
				{
					num /= 100.0;
					num2 /= 100.0;
					u().Text = num2.ToString(this.m_h).TrimEnd(c10);
					r().Text = num.ToString(this.m_h).TrimEnd(c10);
					num3 /= 100.0;
					num4 /= 100.0;
					v().Text = num4.ToString(this.m_h).TrimEnd(c10);
					x().Text = num3.ToString(this.m_h).TrimEnd(c10);
				}
				c();
			}
			finally
			{
				k();
				aa().Refresh();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(base.c, null, null, e(), "DialogGraphLimits.CheckGraphDataPercent_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	private new Point e()
	{
		return i6.a(this);
	}

	private void b(object A_0, FormClosingEventArgs A_1)
	{
		try
		{
			this.m_e.an(h);
			l();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			base.c.c(fz.b.a, " Error in DialogGraphLimits.DialogGraphLimits_FormClosing", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, PaintEventArgs A_1)
	{
		checked
		{
			try
			{
				Graphics graphics = A_1.Graphics;
				SolidBrush brush = new SolidBrush(Color.Gray);
				PictureBox pictureBox = y();
				if (this.m_f.f3())
				{
					string text = this.m_f.gj();
					float num = (float)((double)pictureBox.Left + (double)(pictureBox.Width - this.m_l) * 0.5);
					float num2 = pictureBox.Bottom;
					graphics.DrawString(text, this.m_k, brush, num, num2);
				}
				if (this.m_f.gg())
				{
					string text = (ac().Checked ? this.m_f.hf() : this.m_f.hd());
					float num = 0f - (float)((double)pictureBox.Top + (double)(pictureBox.Height + m + al().Height) * 0.5);
					float num2 = pictureBox.Left - this.m_k.Height;
					graphics.RotateTransform(270f);
					graphics.DrawString(text, this.m_k, brush, num, num2);
					graphics.ResetTransform();
					if (this.m_f.gl())
					{
						text = (ac().Checked ? this.m_f.hi() : this.m_f.hg());
						num = (float)((double)pictureBox.Top + (double)(pictureBox.Height + q().Height - this.m_o - n) * 0.5);
						num2 = -(pictureBox.Left + pictureBox.Width + this.m_k.Height);
						graphics.RotateTransform(90f);
						graphics.DrawString(text, this.m_k, brush, num, num2);
						graphics.ResetTransform();
					}
				}
				pictureBox = null;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				base.c.c(fz.b.a, " Error in DialogGraphLimits.TabPageLimits_Paint", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private new void d()
	{
		Graphics a_ = aa().CreateGraphics();
		this.m_l = jg.a(a_, this.m_f.gj(), this.m_k);
		checked
		{
			int num = this.m_l + 20 + t().Width;
			if (this.m_f.f3() && num > 120)
			{
				y().Width = num;
			}
			else
			{
				y().Width = 120;
			}
			string a_2 = (ac().Checked ? this.m_f.hf() : this.m_f.hd());
			string a_3 = (ac().Checked ? this.m_f.hi() : this.m_f.hg());
			m = jg.a(a_, a_2, this.m_k);
			n = jg.a(a_, a_3, this.m_k);
			if (this.m_f.gg())
			{
				int num2 = ((!this.m_f.gl()) ? m : Math.Max(m, n));
				int val = num2 + 20 + t().Height + al().Height + this.m_o;
				y().Height = Math.Max(val, 90);
			}
			else
			{
				y().Height = 90;
			}
		}
	}

	private new void c()
	{
		SuspendLayout();
		d();
		checked
		{
			int left = y().Right + 7;
			x().Left = left;
			q().Left = left;
			v().Location = new Point(left, (int)Math.Round((double)y().Bottom - 0.5 * (double)v().Height));
			p().Location = new Point(left, v().Top - p().Height - this.m_o);
			u().Top = v().Top;
			aj().Top = p().Top;
			t().Location = new Point((int)Math.Round((double)y().Left - 0.5 * (double)t().Width + 1.0), u().Bottom + this.m_o);
			s().Location = new Point((int)Math.Round((double)y().Right - 0.5 * (double)s().Width), t().Top);
			if (this.m_f.gn)
			{
				ai().Location = new Point(t().Left, t().Bottom + this.m_o);
				ak().Location = new Point(s().Left, s().Bottom + this.m_o);
				ac().Location = new Point((int)Math.Round((double)y().Left + (double)(y().Width - ac().Width) * 0.5), ai().Bottom + this.m_o + 6);
			}
			else
			{
				ac().Location = new Point((int)Math.Round((double)y().Left + (double)(y().Width - ac().Width) * 0.5), t().Bottom + this.m_o + 6);
			}
			ad().Location = new Point((int)Math.Round((double)y().Left + (double)(y().Width - ad().Width) * 0.5), y().Bottom - ad().Height - 10);
			if (this.m_i)
			{
				ab().Width = q().Right + 10;
			}
			else
			{
				ab().Width = s().Right + 16;
			}
			if (this.m_f.fm())
			{
				ab().Height = ac().Bottom + 36;
			}
			else if (this.m_f.gn)
			{
				ab().Height = ak().Bottom + 36;
			}
			else
			{
				ab().Height = s().Bottom + 36;
			}
			ah().Location = new Point(ab().Right - ah().Width - 1, ab().Bottom + this.m_o + 4);
			ae().Location = new Point(ah().Left - ae().Width - this.m_o, ah().Top);
			ag().Location = new Point(ae().Left - ag().Width - this.m_o, ah().Top);
			ResumeLayout();
		}
	}

	private void b()
	{
		if (ad().Checked)
		{
			y().Image = Resources.chart;
		}
		else
		{
			y().Image = null;
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			b();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(base.c, null, null, e(), "DialogGraphLimits.CheckGrid_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}
}
