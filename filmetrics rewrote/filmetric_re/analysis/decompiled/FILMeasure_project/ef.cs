using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class ef : Form
{
	private IContainer a;

	public ToolTip b;

	[CompilerGenerated]
	private Button c;

	[CompilerGenerated]
	private RadioButton d;

	[CompilerGenerated]
	private RadioButton e;

	[CompilerGenerated]
	private Button f;

	[CompilerGenerated]
	private Button g;

	[CompilerGenerated]
	private Label h;

	[CompilerGenerated]
	private Label m_i;

	[CompilerGenerated]
	private CheckBox m_j;

	[CompilerGenerated]
	private CheckBox m_k;

	[CompilerGenerated]
	private hy m_l;

	[CompilerGenerated]
	private hy m_m;

	[CompilerGenerated]
	private hx m_n;

	[CompilerGenerated]
	private ComboBox o;

	[CompilerGenerated]
	private Label m_p;

	[CompilerGenerated]
	private TableLayoutPanel m_q;

	[CompilerGenerated]
	private Panel m_r;

	[CompilerGenerated]
	private TableLayoutPanel m_s;

	[CompilerGenerated]
	private Panel m_t;

	[CompilerGenerated]
	private CheckBox m_u;

	private const string m_v = "DialogObjectiveDetails";

	private et m_w;

	private et m_x;

	private int m_y;

	private string[] m_z;

	private fz m_aa;

	private f1 m_ab;

	private f4 m_ac;

	private string m_ad;

	private Guid ae;

	private gr af;

	[DebuggerNonUserCode]
	protected override void Dispose(bool Disposing)
	{
		if (Disposing && a != null)
		{
			a.Dispose();
		}
		base.Dispose(Disposing);
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button k()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void i(Button A_0)
	{
		EventHandler value = m;
		Button button = c;
		if (button != null)
		{
			button.Click -= value;
		}
		c = A_0;
		button = c;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton l()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void i(RadioButton A_0)
	{
		EventHandler value = i;
		RadioButton radioButton = d;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		d = A_0;
		radioButton = d;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton m()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void j(RadioButton A_0)
	{
		EventHandler value = i;
		RadioButton radioButton = e;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		e = A_0;
		radioButton = e;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button n()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void j(Button A_0)
	{
		f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button p()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void k(Button A_0)
	{
		EventHandler value = l;
		Button button = g;
		if (button != null)
		{
			button.Click -= value;
		}
		g = A_0;
		button = g;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label q()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void i(Label A_0)
	{
		h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label r()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void j(Label A_0)
	{
		this.m_i = A_0;
	}

	[DebuggerStepThrough]
	private void j()
	{
		a = new Container();
		b = new ToolTip(a);
		i(new Button());
		i(new RadioButton());
		j(new RadioButton());
		j(new Button());
		k(new Button());
		i(new Label());
		j(new Label());
		i(new CheckBox());
		j(new CheckBox());
		i(new ComboBox());
		k(new Label());
		i(new TableLayoutPanel());
		i(new Panel());
		i(new hx());
		j(new hy());
		i(new hy());
		j(new TableLayoutPanel());
		k(new CheckBox());
		j(new Panel());
		z().SuspendLayout();
		aa().SuspendLayout();
		ab().SuspendLayout();
		ac().SuspendLayout();
		SuspendLayout();
		k().BackColor = SystemColors.Control;
		k().Cursor = Cursors.Default;
		k().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		k().ForeColor = SystemColors.ControlText;
		k().Location = new Point(26, 134);
		k().Name = "ButtonCalibrate";
		k().RightToLeft = RightToLeft.No;
		k().Size = new Size(97, 33);
		k().TabIndex = 16;
		k().Text = "Calibrate...";
		k().UseVisualStyleBackColor = true;
		l().BackColor = SystemColors.Control;
		l().Cursor = Cursors.Default;
		l().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		l().ForeColor = SystemColors.ControlText;
		l().Location = new Point(11, 108);
		l().Name = "OptionUseCalibratedNA";
		l().RightToLeft = RightToLeft.No;
		l().Size = new Size(169, 17);
		l().TabIndex = 15;
		l().TabStop = true;
		l().Text = "Use calibrated NA";
		l().UseVisualStyleBackColor = false;
		m().BackColor = SystemColors.Control;
		m().Checked = true;
		m().Cursor = Cursors.Default;
		m().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		m().ForeColor = SystemColors.ControlText;
		m().Location = new Point(11, 33);
		m().Name = "OptionUseNominalNA";
		m().RightToLeft = RightToLeft.No;
		m().Size = new Size(169, 17);
		m().TabIndex = 8;
		m().TabStop = true;
		m().Text = "Use nominal NA";
		m().UseVisualStyleBackColor = false;
		n().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		n().BackColor = SystemColors.Control;
		n().Cursor = Cursors.Default;
		n().DialogResult = DialogResult.Cancel;
		n().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		n().ForeColor = SystemColors.ControlText;
		n().Location = new Point(83, 4);
		n().Name = "ButtonCancel";
		n().RightToLeft = RightToLeft.No;
		n().Size = new Size(73, 33);
		n().TabIndex = 2;
		n().Text = "Cancel";
		n().UseVisualStyleBackColor = true;
		p().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		p().BackColor = SystemColors.Control;
		p().Cursor = Cursors.Default;
		p().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		p().ForeColor = SystemColors.ControlText;
		p().Location = new Point(4, 4);
		p().Name = "ButtonOk";
		p().RightToLeft = RightToLeft.No;
		p().Size = new Size(73, 33);
		p().TabIndex = 1;
		p().Text = "OK";
		p().UseVisualStyleBackColor = true;
		q().BackColor = SystemColors.Control;
		q().Cursor = Cursors.Default;
		q().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		q().ForeColor = SystemColors.ControlText;
		q().Location = new Point(11, 6);
		q().Name = "LabelName";
		q().RightToLeft = RightToLeft.No;
		q().Size = new Size(57, 17);
		q().TabIndex = 7;
		q().Text = "Name: ";
		q().TextAlign = ContentAlignment.MiddleCenter;
		r().BackColor = SystemColors.Control;
		r().Cursor = Cursors.Default;
		r().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		r().ForeColor = SystemColors.ControlText;
		r().Location = new Point(23, 58);
		r().Name = "LabelNA";
		r().RightToLeft = RightToLeft.No;
		r().Size = new Size(83, 17);
		r().TabIndex = 6;
		r().Text = "Nominal NA:";
		s().Location = new Point(136, 134);
		s().Name = "CheckBoxUseExistingSpectrum";
		s().Size = new Size(146, 36);
		s().TabIndex = 17;
		s().Text = "Use existing spectrum (Internal)";
		s().UseVisualStyleBackColor = true;
		s().Visible = false;
		t().AutoSize = true;
		t().Enabled = false;
		t().Location = new Point(26, 85);
		t().Name = "CheckBoxImmersion";
		t().Size = new Size(212, 20);
		t().TabIndex = 12;
		t().Text = "Immersion lens; Medium index=";
		t().UseVisualStyleBackColor = true;
		x().Anchor = AnchorStyles.None;
		x().DropDownStyle = ComboBoxStyle.DropDownList;
		x().FormattingEnabled = true;
		x().Location = new Point(172, 3);
		x().Name = "ComboBoxTurretLocation";
		x().Size = new Size(74, 24);
		x().TabIndex = 23;
		y().Anchor = AnchorStyles.None;
		y().AutoSize = true;
		y().BackColor = SystemColors.Control;
		y().Cursor = Cursors.Default;
		y().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		y().ForeColor = SystemColors.ControlText;
		y().Location = new Point(3, 7);
		y().Name = "LabelTurretLocation";
		y().RightToLeft = RightToLeft.No;
		y().Size = new Size(163, 16);
		y().TabIndex = 18;
		y().Text = "Objective location in turret:";
		y().TextAlign = ContentAlignment.MiddleCenter;
		z().Anchor = AnchorStyles.None;
		z().AutoSize = true;
		z().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		z().ColumnCount = 2;
		z().ColumnStyles.Add(new ColumnStyle());
		z().ColumnStyles.Add(new ColumnStyle());
		z().Controls.Add(y(), 0, 0);
		z().Controls.Add(x(), 1, 0);
		z().Location = new Point(24, 213);
		z().Name = "TLPTurretLocation";
		z().RowCount = 1;
		z().RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		z().Size = new Size(249, 30);
		z().TabIndex = 19;
		z().Visible = false;
		aa().Anchor = AnchorStyles.None;
		aa().Controls.Add(w());
		aa().Controls.Add(r());
		aa().Controls.Add(q());
		aa().Controls.Add(m());
		aa().Controls.Add(l());
		aa().Controls.Add(v());
		aa().Controls.Add(k());
		aa().Controls.Add(u());
		aa().Controls.Add(s());
		aa().Controls.Add(t());
		aa().Location = new Point(3, 3);
		aa().Name = "Panel1";
		aa().Size = new Size(291, 174);
		aa().TabIndex = 20;
		w().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		w().Location = new Point(74, 3);
		w().Name = "TextName";
		w().Size = new Size(185, 22);
		w().TabIndex = 3;
		w().Text = "Objective Name";
		w().e(A_0: true);
		v().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		v().f(A_0: false);
		v().Location = new Point(112, 55);
		v().Name = "TextNA";
		v().e(A_0: false);
		v().Size = new Size(68, 22);
		v().TabIndex = 10;
		u().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		u().f(A_0: false);
		u().Location = new Point(233, 83);
		u().Name = "TextMediumIndex";
		u().e(A_0: false);
		u().Size = new Size(49, 22);
		u().TabIndex = 14;
		ab().AutoSize = true;
		ab().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ab().ColumnCount = 1;
		ab().ColumnStyles.Add(new ColumnStyle());
		ab().Controls.Add(ad(), 0, 1);
		ab().Controls.Add(ac(), 0, 3);
		ab().Controls.Add(aa(), 0, 0);
		ab().Controls.Add(z(), 0, 2);
		ab().Location = new Point(7, 6);
		ab().Name = "TableLayoutPanel1";
		ab().RowCount = 4;
		ab().RowStyles.Add(new RowStyle());
		ab().RowStyles.Add(new RowStyle(SizeType.Absolute, 30f));
		ab().RowStyles.Add(new RowStyle());
		ab().RowStyles.Add(new RowStyle());
		ab().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		ab().Size = new Size(297, 292);
		ab().TabIndex = 21;
		ad().AutoSize = true;
		ad().Location = new Point(13, 183);
		ad().Margin = new Padding(13, 3, 3, 3);
		ad().Name = "CheckBoxReflectiveObjective";
		ad().Size = new Size(139, 20);
		ad().TabIndex = 22;
		ad().Text = "Reflective Objective";
		ad().UseVisualStyleBackColor = true;
		ac().Anchor = AnchorStyles.Right;
		ac().Controls.Add(p());
		ac().Controls.Add(n());
		ac().Location = new Point(135, 249);
		ac().Name = "Panel2";
		ac().Size = new Size(159, 40);
		ac().TabIndex = 21;
		base.AcceptButton = p();
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		BackColor = SystemColors.Control;
		base.CancelButton = n();
		base.ClientSize = new Size(313, 374);
		base.Controls.Add(ab());
		Cursor = Cursors.Default;
		Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Location = new Point(3, 29);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogObjectiveDetails";
		RightToLeft = RightToLeft.No;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Objective Details";
		z().ResumeLayout(performLayout: false);
		z().PerformLayout();
		aa().ResumeLayout(performLayout: false);
		aa().PerformLayout();
		ab().ResumeLayout(performLayout: false);
		ab().PerformLayout();
		ac().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox s()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(CheckBox A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox t()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(CheckBox A_0)
	{
		EventHandler value = j;
		CheckBox checkBox = this.m_k;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_k = A_0;
		checkBox = this.m_k;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy u()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(hy A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy v()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(hy A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx w()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(hx A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox x()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(ComboBox A_0)
	{
		o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label y()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void k(Label A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel z()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TableLayoutPanel A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel aa()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Panel A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ab()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(TableLayoutPanel A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel ac()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Panel A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ad()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(CheckBox A_0)
	{
		this.m_u = A_0;
	}

	public ef(fz A_0)
	{
		base.Activated += k;
		j();
		this.m_aa = A_0;
	}

	private void m(object A_0, EventArgs A_1)
	{
		float A_2 = default(float);
		float A_3 = default(float);
		if (i(ref A_2, ref A_3))
		{
			hr a_ = ((!s().Checked) ? null : this.m_ac.h1().cw());
			bool a_2 = this.m_x.aa();
			this.m_x.t(A_0: false);
			this.m_x.t(w().Text);
			this.m_x.t(A_2);
			this.m_x.u(A_2);
			this.m_x.v(A_2);
			this.m_x.t(A_0: false);
			this.m_x.v(t().Checked);
			this.m_x.w(ad().Checked);
			this.m_x.aa(A_3);
			da obj = new da(this.m_aa);
			obj.a(this.m_ab, this.m_ac, ae, af, this.m_x, a_, i6.a(this));
			if (obj.DialogResult != DialogResult.OK)
			{
				this.m_x.t(a_2);
			}
			i();
			obj.Dispose();
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		float A_2 = default(float);
		float A_3 = default(float);
		if (i(ref A_2, ref A_3))
		{
			this.m_x.t(w().Text);
			this.m_x.t(A_2);
			this.m_x.t(m().Checked);
			this.m_x.v(t().Checked);
			this.m_x.w(ad().Checked);
			this.m_x.aa(A_3);
			this.m_x.ad(this.m_w);
			base.DialogResult = DialogResult.OK;
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		w().Focus();
	}

	public void i(f1 A_0, f4 A_1, Guid A_2, gr A_3, et A_4, int A_5, string[] A_6, bool A_7, List<short> A_8, Point A_9)
	{
		this.m_ab = A_0;
		this.m_ac = A_1;
		this.m_ad = A_2.ToString();
		ae = A_2;
		af = A_3;
		this.m_w = A_4;
		this.m_x = new et();
		this.m_w.ad(this.m_x);
		this.m_z = A_6;
		this.m_y = A_5;
		w().Text = this.m_x.al();
		v().Text = (this.m_x.t() * this.m_x.ae()).ToString();
		t().Checked = this.m_x.ac();
		ad().Checked = this.m_x.ad();
		u().Text = this.m_x.ae().ToString();
		i();
		if (this.m_ac.h1() != null && this.m_ab.ui())
		{
			s().Visible = true;
		}
		i6.a(A_9, this);
		ShowDialog();
	}

	private bool i(ref float A_0, ref float A_1)
	{
		checked
		{
			if (!float.TryParse(v().Text, out A_0))
			{
				v().Focus();
				fe.b(this.m_aa, "Please make sure you enter a valid Numerical Aperture value for the objective.", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				return false;
			}
			A_1 = Conversions.ToSingle(u().Text);
			if (A_1 >= 1f)
			{
				A_0 /= A_1;
			}
			if (Operators.CompareString(w().Text, "", TextCompare: false) != 0 && ((A_0 >= 0f && A_0 <= 1f && A_1 >= 1f && A_1 <= 10f) || l().Checked) && !es.t(this.m_z, w().Text, this.m_y))
			{
				return true;
			}
			if (Operators.CompareString(w().Text, "", TextCompare: false) == 0)
			{
				fe.b(this.m_aa, "Please make sure you enter a valid Name for the objective.", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				w().Focus();
			}
			else if (es.t(this.m_z, w().Text, this.m_y))
			{
				fe.b(this.m_aa, "Objective Name must be unique. Original name will be replaced with a unique name.", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				w().Text = es.u(this.m_z, w().Text, this.m_y);
			}
			else if (A_1 < 1f || A_1 > 10f)
			{
				fe.b(this.m_aa, "Please make sure you enter a valid Medium Index value for the objective.", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				u().Focus();
			}
			else if (A_0 <= 0f || A_0 >= 1f)
			{
				fe.b(this.m_aa, "Please make sure you enter a valid Numerical Aperture value for the objective.", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				v().Focus();
			}
			return false;
		}
	}

	private void i()
	{
		if (!this.m_x.ab())
		{
			this.m_x.t(A_0: true);
		}
		m().Checked = this.m_x.aa();
		l().Checked = !this.m_x.aa();
		l().Enabled = this.m_x.ab();
		v().Enabled = m().Checked;
		t().Enabled = m().Checked;
		u().Enabled = m().Checked && t().Checked;
	}

	private void j(object A_0, EventArgs A_1)
	{
		try
		{
			u().Enabled = t().Checked;
			if (t().Checked)
			{
				u().Text = 1.515f.ToString();
			}
			else
			{
				u().Text = 1f.ToString();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_aa, this.m_ab, null, i6.a(this), "DialogObjectiveDetails.CheckBoxImmersion_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		try
		{
			v().Enabled = m().Checked;
			t().Enabled = m().Checked;
			u().Enabled = m().Checked && t().Checked;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_aa, this.m_ab, null, i6.a(this), "DialogObjectiveDetails.OptionUseNominalNAORCalibratedNA_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}
}
