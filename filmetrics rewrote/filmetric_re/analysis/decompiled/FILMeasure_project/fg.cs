using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class fg : Form
{
	public enum a
	{
		a,
		b,
		c,
		d
	}

	private IContainer m_a;

	[CompilerGenerated]
	private RadioButton m_b;

	[CompilerGenerated]
	private RadioButton m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private Button m_e;

	[CompilerGenerated]
	private RadioButton m_f;

	[CompilerGenerated]
	private RadioButton m_g;

	[CompilerGenerated]
	private Label m_h;

	[CompilerGenerated]
	private Label m_i;

	[CompilerGenerated]
	private GroupBox m_j;

	[CompilerGenerated]
	private Label m_k;

	[CompilerGenerated]
	private Label m_l;

	[CompilerGenerated]
	private hy m_m;

	[CompilerGenerated]
	private hy m_n;

	[CompilerGenerated]
	private Label m_o;

	[CompilerGenerated]
	private Label m_p;

	[CompilerGenerated]
	private Label m_q;

	[CompilerGenerated]
	private Label m_r;

	[CompilerGenerated]
	private Label m_s;

	[CompilerGenerated]
	private hy m_t;

	[CompilerGenerated]
	private Label m_u;

	[CompilerGenerated]
	private TableLayoutPanel m_v;

	[CompilerGenerated]
	private TableLayoutPanel m_w;

	private f1 x;

	private fz y;

	private Guid z;

	private bool aa;

	private bool ab;

	private float ac;

	private float ad;

	public fg()
	{
		a();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_a != null)
		{
			this.m_a.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void a()
	{
		this.m_a = new Container();
		a(new RadioButton());
		b(new RadioButton());
		a(new Button());
		b(new Button());
		c(new RadioButton());
		d(new RadioButton());
		a(new Label());
		b(new Label());
		a(new GroupBox());
		a(new TableLayoutPanel());
		g(new Label());
		e(new Label());
		f(new Label());
		d(new Label());
		a(new hy());
		c(new Label());
		h(new Label());
		i(new Label());
		j(new Label());
		c(new hy());
		b(new hy());
		b(new TableLayoutPanel());
		j().SuspendLayout();
		v().SuspendLayout();
		w().SuspendLayout();
		SuspendLayout();
		b().AutoSize = true;
		b().Location = new Point(30, 186);
		b().Name = "RadioUserSuppliedReflectance";
		b().Size = new Size(219, 20);
		b().TabIndex = 15;
		b().TabStop = true;
		b().Text = "Use User-Supplied Reflectance:";
		b().UseVisualStyleBackColor = true;
		c().AutoSize = true;
		c().Location = new Point(30, 212);
		c().Name = "RadioUseRecipe";
		c().Size = new Size(291, 20);
		c().TabIndex = 25;
		c().Text = "Use Recipe to estimate Sample Reflectance";
		c().UseVisualStyleBackColor = true;
		c().Visible = false;
		d().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d().Location = new Point(139, 239);
		d().Name = "ButtonOK";
		d().Size = new Size(90, 32);
		d().TabIndex = 26;
		d().Text = "OK";
		d().UseVisualStyleBackColor = true;
		e().DialogResult = DialogResult.Cancel;
		e().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e().Location = new Point(235, 239);
		e().Name = "ButtonCancel";
		e().Size = new Size(90, 32);
		e().TabIndex = 27;
		e().Text = "Cancel";
		e().UseVisualStyleBackColor = true;
		f().Location = new Point(30, 38);
		f().Name = "RadioLastMeasReflectance";
		f().Size = new Size(271, 20);
		f().TabIndex = 13;
		f().TabStop = true;
		f().Text = "Use Last Measured Sample Reflectance:";
		f().UseVisualStyleBackColor = true;
		g().AutoSize = true;
		g().Checked = true;
		g().Location = new Point(30, 13);
		g().Name = "RadioNone";
		g().Size = new Size(167, 20);
		g().TabIndex = 11;
		g().TabStop = true;
		g().Text = "None (Do Not Override)";
		g().UseVisualStyleBackColor = true;
		h().Anchor = AnchorStyles.None;
		h().AutoSize = true;
		h().BorderStyle = BorderStyle.FixedSingle;
		h().Location = new Point(12, 28);
		h().Margin = new Padding(3, 6, 3, 3);
		h().Name = "LabelLastMeasReflPrim";
		h().Size = new Size(65, 18);
		h().TabIndex = 22;
		h().Text = "Unknown";
		h().TextAlign = ContentAlignment.MiddleRight;
		i().Anchor = AnchorStyles.Left;
		i().AutoSize = true;
		i().Location = new Point(77, 32);
		i().Margin = new Padding(3, 6, 3, 0);
		i().Name = "LabelUserSuppliedReflPercent";
		i().Size = new Size(20, 16);
		i().TabIndex = 23;
		i().Text = "%";
		j().Controls.Add(v());
		j().Controls.Add(l());
		j().Controls.Add(m());
		j().Controls.Add(k());
		j().Location = new Point(19, 39);
		j().Name = "GroupBox1";
		j().Size = new Size(428, 115);
		j().TabIndex = 24;
		j().TabStop = false;
		v().AutoSize = true;
		v().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		v().ColumnCount = 2;
		v().ColumnStyles.Add(new ColumnStyle());
		v().ColumnStyles.Add(new ColumnStyle());
		v().Controls.Add(q(), 1, 1);
		v().Controls.Add(o(), 1, 0);
		v().Controls.Add(h(), 0, 1);
		v().Controls.Add(p(), 0, 0);
		v().Location = new Point(114, 22);
		v().Name = "TableLayoutPanel1";
		v().RowCount = 2;
		v().RowStyles.Add(new RowStyle());
		v().RowStyles.Add(new RowStyle());
		v().Size = new Size(184, 49);
		v().TabIndex = 33;
		q().Anchor = AnchorStyles.None;
		q().AutoSize = true;
		q().BorderStyle = BorderStyle.FixedSingle;
		q().Location = new Point(104, 28);
		q().Margin = new Padding(3, 6, 3, 3);
		q().Name = "LabelLastMeasReflAngle1";
		q().Size = new Size(65, 18);
		q().TabIndex = 25;
		q().Text = "Unknown";
		q().TextAlign = ContentAlignment.MiddleRight;
		q().Visible = false;
		o().AutoSize = true;
		o().Location = new Point(93, 3);
		o().Margin = new Padding(3);
		o().Name = "AtAngleReflLabel";
		o().Size = new Size(88, 16);
		o().TabIndex = 27;
		o().Text = "Refl. At Angle";
		o().Visible = false;
		p().AutoSize = true;
		p().Location = new Point(3, 3);
		p().Margin = new Padding(3);
		p().Name = "PrimReflLabel";
		p().Size = new Size(84, 16);
		p().TabIndex = 26;
		p().Text = "Primary Refl.";
		l().AutoSize = true;
		l().Location = new Point(354, 84);
		l().Name = "Label1";
		l().Size = new Size(20, 16);
		l().TabIndex = 24;
		l().Text = "%";
		m().f(A_0: false);
		m().Location = new Point(295, 81);
		m().Name = "txtIncreasePercent";
		m().e(A_0: true);
		m().Size = new Size(57, 22);
		m().TabIndex = 14;
		k().Location = new Point(41, 84);
		k().Name = "Label";
		k().Size = new Size(258, 20);
		k().TabIndex = 18;
		k().Text = "Increase expected sample reflectance by:";
		r().AutoSize = true;
		w().SetColumnSpan(r(), 2);
		r().Location = new Point(103, 3);
		r().Margin = new Padding(3);
		r().Name = "AtAngleReflTextLabel";
		r().Size = new Size(88, 16);
		r().TabIndex = 30;
		r().Text = "Refl. At Angle";
		r().Visible = false;
		s().AutoSize = true;
		w().SetColumnSpan(s(), 2);
		s().Location = new Point(3, 3);
		s().Margin = new Padding(3);
		s().Name = "PrimReflTextLabel";
		s().Size = new Size(84, 16);
		s().TabIndex = 29;
		s().Text = "Primary Refl.";
		u().Anchor = AnchorStyles.Left;
		u().AutoSize = true;
		u().Location = new Point(177, 32);
		u().Margin = new Padding(3, 6, 3, 0);
		u().Name = "LabelUserSuppliedReflPercent2";
		u().Size = new Size(20, 16);
		u().TabIndex = 31;
		u().Text = "%";
		u().Visible = false;
		t().Anchor = AnchorStyles.Left;
		t().f(A_0: false);
		t().Location = new Point(103, 28);
		t().Margin = new Padding(3, 6, 3, 3);
		t().Name = "TextBoxReflAtAngle";
		t().e(A_0: false);
		t().Size = new Size(68, 22);
		t().TabIndex = 32;
		t().Visible = false;
		n().Anchor = AnchorStyles.Left;
		n().f(A_0: false);
		n().Location = new Point(3, 28);
		n().Margin = new Padding(3, 6, 3, 3);
		n().Name = "TextBoxPrimRefl";
		n().e(A_0: false);
		n().Size = new Size(68, 22);
		n().TabIndex = 28;
		w().AutoSize = true;
		w().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		w().ColumnCount = 4;
		w().ColumnStyles.Add(new ColumnStyle());
		w().ColumnStyles.Add(new ColumnStyle());
		w().ColumnStyles.Add(new ColumnStyle());
		w().ColumnStyles.Add(new ColumnStyle());
		w().Controls.Add(s(), 0, 0);
		w().Controls.Add(u(), 3, 1);
		w().Controls.Add(t(), 2, 1);
		w().Controls.Add(r(), 2, 0);
		w().Controls.Add(n(), 0, 1);
		w().Controls.Add(i(), 1, 1);
		w().Location = new Point(247, 156);
		w().Name = "TableLayoutPanel2";
		w().RowCount = 2;
		w().RowStyles.Add(new RowStyle());
		w().RowStyles.Add(new RowStyle());
		w().Size = new Size(200, 53);
		w().TabIndex = 33;
		base.AcceptButton = d();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = e();
		base.ClientSize = new Size(463, 283);
		base.Controls.Add(w());
		base.Controls.Add(f());
		base.Controls.Add(j());
		base.Controls.Add(g());
		base.Controls.Add(e());
		base.Controls.Add(d());
		base.Controls.Add(b());
		base.Controls.Add(c());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogSampleReflectanceOptions";
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Sample Reflectance Override Methods";
		j().ResumeLayout(performLayout: false);
		j().PerformLayout();
		v().ResumeLayout(performLayout: false);
		v().PerformLayout();
		w().ResumeLayout(performLayout: false);
		w().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton b()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(RadioButton A_0)
	{
		EventHandler value = b;
		RadioButton radioButton = this.m_b;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_b = A_0;
		radioButton = this.m_b;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(RadioButton A_0)
	{
		EventHandler value = b;
		RadioButton radioButton = this.m_c;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_c = A_0;
		radioButton = this.m_c;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button d()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = a;
		Button button = this.m_d;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_d = A_0;
		button = this.m_d;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button e()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton f()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(RadioButton A_0)
	{
		EventHandler value = b;
		RadioButton radioButton = this.m_f;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_f = A_0;
		radioButton = this.m_f;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton g()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(RadioButton A_0)
	{
		EventHandler value = b;
		RadioButton radioButton = this.m_g;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_g = A_0;
		radioButton = this.m_g;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label h()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label i()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox j()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(GroupBox A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label k()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label l()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy m()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hy A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy n()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(hy A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label o()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label p()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label q()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Label A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label r()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Label A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label s()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Label A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy t()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(hy A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label u()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Label A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel v()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel w()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_w = A_0;
	}

	private void a(bool A_0, bool A_1, string A_2)
	{
		p().Visible = A_0;
		h().Visible = A_0;
		s().Visible = A_0;
		n().Visible = A_0;
		i().Visible = A_0;
		if (A_1)
		{
			o().Text = A_2;
			r().Text = A_2;
		}
		o().Visible = A_1;
		q().Visible = A_1;
		r().Visible = A_1;
		t().Visible = A_1;
		u().Visible = A_1;
	}

	public void a(fz A_0, f1 A_1, Guid A_2, bool A_3, bool A_4, string A_5, ref a A_6, ref float A_7, ref float A_8)
	{
		checked
		{
			float[] array = new float[Enum.GetValues(typeof(h.h)).GetUpperBound(0) + 1];
			char c10 = Conversions.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
			bool flag = Conversions.ToBoolean(global::e.a().GraphMeasYLabelPercent[0]);
			z = A_2;
			x = A_1;
			y = A_0;
			aa = A_3;
			ab = A_4;
			ac = A_7;
			ad = A_8;
			a(A_3, A_4, A_5);
			switch (A_6)
			{
			case fg.a.a:
				g().Checked = true;
				break;
			case fg.a.b:
				f().Checked = true;
				break;
			case fg.a.c:
				b().Checked = true;
				break;
			case fg.a.d:
				c().Checked = true;
				break;
			}
			m().Text = x.xg(z).ToString();
			array = x.uk(z);
			if (aa)
			{
				if (array[0] <= 0f || !x.wp(z))
				{
					f().Enabled = false;
					h().Text = "Unknown";
				}
				else if (flag)
				{
					h().Text = (array[0] * 100f).ToString("0.##").TrimEnd(c10) + "%";
				}
				else
				{
					h().Text = array[0].ToString("0.##").TrimEnd(c10);
				}
			}
			if (ab)
			{
				if (array[1] <= 0f || !x.wp(z))
				{
					f().Enabled = false;
					q().Text = "Unknown";
				}
				else if (flag)
				{
					q().Text = (array[1] * 100f).ToString("0.##").TrimEnd(c10) + "%";
				}
				else
				{
					q().Text = array[1].ToString("0.##").TrimEnd(c10);
				}
			}
			double[] array2 = new double[Enum.GetValues(typeof(h.h)).GetUpperBound(0) + 1];
			if (aa)
			{
				array2[0] = A_7;
				if (flag)
				{
					array2[0] *= 100.0;
				}
				n().Text = array2[0].ToString("0.##").TrimEnd(c10);
				i().Visible = flag;
			}
			if (ab)
			{
				array2[1] = A_8;
				if (flag)
				{
					array2[1] *= 100.0;
				}
				t().Text = array2[1].ToString("0.##").TrimEnd(c10);
				u().Visible = flag;
			}
			ShowDialog();
			if (base.DialogResult != DialogResult.Cancel)
			{
				if (f().Checked)
				{
					A_6 = fg.a.b;
				}
				else if (b().Checked)
				{
					A_6 = fg.a.c;
				}
				else if (c().Checked)
				{
					A_6 = fg.a.d;
				}
				else if (g().Checked)
				{
					A_6 = fg.a.a;
				}
				if (aa)
				{
					A_7 = ac;
				}
				if (ab)
				{
					A_8 = ad;
				}
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		n().Enabled = b().Checked;
		t().Enabled = b().Checked;
		m().Enabled = f().Checked;
	}

	private void a(object A_0, EventArgs A_1)
	{
		if (b().Checked)
		{
			float[] array = new float[checked(Enum.GetValues(typeof(h.h)).GetUpperBound(0) + 1)];
			bool flag = Conversions.ToBoolean(global::e.a().GraphMeasYLabelPercent[0]);
			int num = 1;
			if (flag)
			{
				num = 100;
			}
			if (aa)
			{
				if (!float.TryParse(n().Text, out array[0]))
				{
					array[0] = 0f;
				}
				if (flag)
				{
					array[0] /= 100f;
				}
			}
			if (ab)
			{
				if (!float.TryParse(t().Text, out array[1]))
				{
					array[1] = 0f;
				}
				if (flag)
				{
					array[1] /= 100f;
				}
			}
			if (aa && (array[0] <= 0f || array[0] > 1f))
			{
				ref fz a_ = ref y;
				string A_2 = "ErrSampleReflectanceFmt";
				string a_2 = string.Format(hu.a(ref A_2), num.ToString());
				Point A_3 = i6.a(d());
				fe.b(ref a_, a_2, ref A_3);
				return;
			}
			if (ab && (array[1] <= 0f || array[1] > 1f))
			{
				ref fz a_3 = ref y;
				string A_2 = "ErrSampleReflectanceFmt";
				string a_4 = string.Format(hu.a(ref A_2), num.ToString());
				Point A_3 = i6.a(d());
				fe.b(ref a_3, a_4, ref A_3);
				return;
			}
			if (aa)
			{
				ac = array[0];
			}
			if (ab)
			{
				ad = array[1];
			}
		}
		x.m2(z, (float)Conversions.ToInteger(m().Text));
		base.DialogResult = DialogResult.OK;
	}
}
