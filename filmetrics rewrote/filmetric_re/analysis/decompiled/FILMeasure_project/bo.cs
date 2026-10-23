using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Filmetrics;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class bo : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private GroupBox m_c;

	[CompilerGenerated]
	private RadioButton m_d;

	[CompilerGenerated]
	private RadioButton m_e;

	[CompilerGenerated]
	private RadioButton m_f;

	[CompilerGenerated]
	private RadioButton m_g;

	[CompilerGenerated]
	private RadioButton m_h;

	[CompilerGenerated]
	private RadioButton m_i;

	[CompilerGenerated]
	private RadioButton m_j;

	[CompilerGenerated]
	private RadioButton m_k;

	[CompilerGenerated]
	private RadioButton m_l;

	[CompilerGenerated]
	private RadioButton m_m;

	[CompilerGenerated]
	private RadioButton m_n;

	[CompilerGenerated]
	private RadioButton m_o;

	[CompilerGenerated]
	private GroupBox m_p;

	[CompilerGenerated]
	private Button m_q;

	[CompilerGenerated]
	private Button m_r;

	[CompilerGenerated]
	private hy m_s;

	[CompilerGenerated]
	private GroupBox m_t;

	[CompilerGenerated]
	private DataGridView m_u;

	[CompilerGenerated]
	private Button m_v;

	[CompilerGenerated]
	private Button m_w;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_x;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_y;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_z;

	[CompilerGenerated]
	private RadioButton m_aa;

	private f1 m_ab;

	private string m_ac;

	private Guid m_ad;

	private f4 m_ae;

	private fz m_af;

	[CompilerGenerated]
	private r.d m_ag;

	[CompilerGenerated]
	private r.d m_ah;

	[CompilerGenerated]
	private r.d ai;

	[CompilerGenerated]
	private r.d aj;

	private const string ak = "DialogSelectScatter";

	public bo()
	{
		a(new r.d());
		b(new r.d());
		c(new r.d());
		d(new r.d());
		d();
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
	private void d()
	{
		this.m_a = new Container();
		a(new Button());
		a(new GroupBox());
		m(new RadioButton());
		a(new RadioButton());
		b(new RadioButton());
		c(new RadioButton());
		d(new RadioButton());
		e(new RadioButton());
		f(new RadioButton());
		g(new RadioButton());
		h(new RadioButton());
		i(new RadioButton());
		j(new RadioButton());
		k(new RadioButton());
		l(new RadioButton());
		b(new GroupBox());
		b(new Button());
		c(new Button());
		a(new hy());
		c(new GroupBox());
		e(new Button());
		a(new DataGridView());
		a(new DataGridViewTextBoxColumn());
		b(new DataGridViewTextBoxColumn());
		c(new DataGridViewTextBoxColumn());
		d(new Button());
		f().SuspendLayout();
		s().SuspendLayout();
		w().SuspendLayout();
		((ISupportInitialize)x()).BeginInit();
		SuspendLayout();
		e().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		e().Location = new Point(217, 388);
		e().Margin = new Padding(4);
		e().Name = "OK_Button";
		e().Size = new Size(89, 28);
		e().TabIndex = 0;
		e().Text = "OK";
		f().Controls.Add(ad());
		f().Controls.Add(g());
		f().Controls.Add(h());
		f().Controls.Add(i());
		f().Controls.Add(j());
		f().Controls.Add(k());
		f().Controls.Add(l());
		f().Controls.Add(m());
		f().Controls.Add(n());
		f().Controls.Add(o());
		f().Controls.Add(p());
		f().Controls.Add(q());
		f().Controls.Add(r());
		f().Location = new Point(12, 12);
		f().Name = "GroupBoxMuxChannel";
		f().Size = new Size(189, 371);
		f().TabIndex = 1;
		f().TabStop = false;
		f().Text = "Mux Channel";
		ad().AutoSize = true;
		ad().Location = new Point(22, 345);
		ad().Name = "RadioButtonDark";
		ad().Size = new Size(55, 20);
		ad().TabIndex = 12;
		ad().TabStop = true;
		ad().Text = "Dark";
		ad().UseVisualStyleBackColor = true;
		g().AutoSize = true;
		g().Location = new Point(22, 320);
		g().Name = "RadioButtonFilterHP1200";
		g().Size = new Size(137, 20);
		g().TabIndex = 11;
		g().TabStop = true;
		g().Text = "Filter (HP 1200 nm)";
		g().UseVisualStyleBackColor = true;
		h().AutoSize = true;
		h().Location = new Point(22, 294);
		h().Name = "RadioButtonFilterLP700";
		h().Size = new Size(127, 20);
		h().TabIndex = 10;
		h().TabStop = true;
		h().Text = "Filter (LP 700 nm)";
		h().UseVisualStyleBackColor = true;
		i().AutoSize = true;
		i().Location = new Point(22, 268);
		i().Name = "RadioButtonFilterHP550";
		i().Size = new Size(130, 20);
		i().TabIndex = 9;
		i().TabStop = true;
		i().Text = "Filter (HP 550 nm)";
		i().UseVisualStyleBackColor = true;
		j().AutoSize = true;
		j().Location = new Point(22, 242);
		j().Name = "RadioButtonSWNIR3LED";
		j().Size = new Size(107, 20);
		j().TabIndex = 8;
		j().TabStop = true;
		j().Text = "SWNIR3 LED";
		j().UseVisualStyleBackColor = true;
		k().AutoSize = true;
		k().Location = new Point(22, 216);
		k().Name = "RadioButtonSWNIR2LED";
		k().Size = new Size(107, 20);
		k().TabIndex = 7;
		k().TabStop = true;
		k().Text = "SWNIR2 LED";
		k().UseVisualStyleBackColor = true;
		l().AutoSize = true;
		l().Location = new Point(22, 190);
		l().Name = "RadioButtonSWIR1LED";
		l().Size = new Size(107, 20);
		l().TabIndex = 6;
		l().TabStop = true;
		l().Text = "SWNIR1 LED";
		l().UseVisualStyleBackColor = true;
		m().AutoSize = true;
		m().Location = new Point(22, 164);
		m().Name = "RadioButtonNIR2LED";
		m().Size = new Size(138, 20);
		m().TabIndex = 5;
		m().TabStop = true;
		m().Text = "NIR2 LED (950 nm)";
		m().UseVisualStyleBackColor = true;
		n().AutoSize = true;
		n().Location = new Point(22, 138);
		n().Name = "RadioButtonNIR1LED";
		n().Size = new Size(138, 20);
		n().TabIndex = 4;
		n().TabStop = true;
		n().Text = "NIR1 LED (780 nm)";
		n().UseVisualStyleBackColor = true;
		o().AutoSize = true;
		o().Location = new Point(22, 112);
		o().Name = "RadioButtonRedLED";
		o().Size = new Size(134, 20);
		o().TabIndex = 3;
		o().TabStop = true;
		o().Text = "Red LED (650 nm)";
		o().UseVisualStyleBackColor = true;
		p().AutoSize = true;
		p().Location = new Point(22, 86);
		p().Name = "RadioButtonGreenLED";
		p().Size = new Size(145, 20);
		p().TabIndex = 2;
		p().TabStop = true;
		p().Text = "Green LED (520 nm)";
		p().UseVisualStyleBackColor = true;
		q().AutoSize = true;
		q().Location = new Point(22, 60);
		q().Name = "RadioButtonVioletLED";
		q().Size = new Size(142, 20);
		q().TabIndex = 1;
		q().TabStop = true;
		q().Text = "Violet LED (405 nm)";
		q().UseVisualStyleBackColor = true;
		r().AutoSize = true;
		r().Location = new Point(22, 34);
		r().Name = "RadioButtonUVLED";
		r().Size = new Size(127, 20);
		r().TabIndex = 0;
		r().TabStop = true;
		r().Text = "UV LED (290 nm)";
		r().UseVisualStyleBackColor = true;
		s().Controls.Add(t());
		s().Controls.Add(u());
		s().Controls.Add(v());
		s().Location = new Point(220, 12);
		s().Name = "GroupBoxAngle";
		s().Size = new Size(189, 92);
		s().TabIndex = 2;
		s().TabStop = false;
		s().Text = "Mux Angle";
		t().Location = new Point(102, 49);
		t().Name = "ButtonSetAngle";
		t().Size = new Size(75, 23);
		t().TabIndex = 2;
		t().Text = "Set";
		t().UseVisualStyleBackColor = true;
		u().Location = new Point(11, 49);
		u().Name = "ButtonReadAngle";
		u().Size = new Size(75, 23);
		u().TabIndex = 1;
		u().Text = "Read";
		u().UseVisualStyleBackColor = true;
		v().f(A_0: false);
		v().Location = new Point(48, 21);
		v().Name = "TextBoxNumericMuxAngle";
		v().e(A_0: false);
		v().Size = new Size(100, 22);
		v().TabIndex = 0;
		w().Controls.Add(z());
		w().Controls.Add(x());
		w().Controls.Add(y());
		w().Location = new Point(220, 110);
		w().Name = "GroupBoxCalibrateAngles";
		w().Size = new Size(278, 271);
		w().TabIndex = 3;
		w().TabStop = false;
		w().Text = "Calibrated Angles";
		z().Location = new Point(159, 236);
		z().Name = "ButtonSaveAngles";
		z().Size = new Size(75, 23);
		z().TabIndex = 4;
		z().Text = "Save";
		z().UseVisualStyleBackColor = true;
		x().AllowUserToAddRows = false;
		x().AllowUserToDeleteRows = false;
		x().AllowUserToResizeColumns = false;
		x().AllowUserToResizeRows = false;
		x().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
		x().AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders;
		x().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		x().Columns.AddRange(aa(), ab(), ac());
		x().Location = new Point(19, 21);
		x().Name = "DataGridViewAngles";
		x().Size = new Size(245, 209);
		x().TabIndex = 3;
		aa().AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
		aa().HeaderText = "Chan.";
		aa().Name = "Channel";
		aa().Width = 67;
		ab().HeaderText = "Orig";
		ab().Name = "origAngle";
		ab().Width = 58;
		ac().HeaderText = "Calib";
		ac().Name = "newAngle";
		ac().Width = 64;
		y().Location = new Point(48, 236);
		y().Name = "ButtonCalibrateAngles";
		y().Size = new Size(75, 23);
		y().TabIndex = 2;
		y().Text = "Calibrate";
		y().UseVisualStyleBackColor = true;
		base.AcceptButton = e();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(510, 429);
		base.Controls.Add(w());
		base.Controls.Add(s());
		base.Controls.Add(f());
		base.Controls.Add(e());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogSelectScatter";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Select Mux Channel";
		f().ResumeLayout(performLayout: false);
		f().PerformLayout();
		s().ResumeLayout(performLayout: false);
		s().PerformLayout();
		w().ResumeLayout(performLayout: false);
		((ISupportInitialize)x()).EndInit();
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button e()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
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
	internal virtual GroupBox f()
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
	internal virtual RadioButton g()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(RadioButton A_0)
	{
		EventHandler value = e;
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
	internal virtual RadioButton h()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(RadioButton A_0)
	{
		EventHandler value = e;
		RadioButton radioButton = this.m_e;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_e = A_0;
		radioButton = this.m_e;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton i()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(RadioButton A_0)
	{
		EventHandler value = e;
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
	internal virtual RadioButton j()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(RadioButton A_0)
	{
		EventHandler value = e;
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
	internal virtual RadioButton k()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(RadioButton A_0)
	{
		EventHandler value = e;
		RadioButton radioButton = this.m_h;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_h = A_0;
		radioButton = this.m_h;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton l()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(RadioButton A_0)
	{
		EventHandler value = e;
		RadioButton radioButton = this.m_i;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_i = A_0;
		radioButton = this.m_i;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton m()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(RadioButton A_0)
	{
		EventHandler value = e;
		RadioButton radioButton = this.m_j;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_j = A_0;
		radioButton = this.m_j;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton n()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(RadioButton A_0)
	{
		EventHandler value = e;
		RadioButton radioButton = this.m_k;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_k = A_0;
		radioButton = this.m_k;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton o()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(RadioButton A_0)
	{
		EventHandler value = e;
		RadioButton radioButton = this.m_l;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_l = A_0;
		radioButton = this.m_l;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton p()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(RadioButton A_0)
	{
		EventHandler value = e;
		RadioButton radioButton = this.m_m;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_m = A_0;
		radioButton = this.m_m;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton q()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(RadioButton A_0)
	{
		EventHandler value = e;
		RadioButton radioButton = this.m_n;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_n = A_0;
		radioButton = this.m_n;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton r()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(RadioButton A_0)
	{
		EventHandler value = e;
		RadioButton radioButton = this.m_o;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_o = A_0;
		radioButton = this.m_o;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox s()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(GroupBox A_0)
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
	internal virtual void b(Button A_0)
	{
		EventHandler value = c;
		Button button = this.m_q;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_q = A_0;
		button = this.m_q;
		if (button != null)
		{
			button.Click += value;
		}
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
	internal virtual void c(Button A_0)
	{
		EventHandler value = d;
		Button button = this.m_r;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_r = A_0;
		button = this.m_r;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy v()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hy A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox w()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(GroupBox A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridView x()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridView A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button y()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Button A_0)
	{
		EventHandler value = a;
		Button button = this.m_v;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_v = A_0;
		button = this.m_v;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button z()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Button A_0)
	{
		EventHandler value = b;
		Button button = this.m_w;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_w = A_0;
		button = this.m_w;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn aa()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridViewTextBoxColumn A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn ab()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(DataGridViewTextBoxColumn A_0)
	{
		this.m_y = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn ac()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(DataGridViewTextBoxColumn A_0)
	{
		this.m_z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ad()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(RadioButton A_0)
	{
		EventHandler value = e;
		RadioButton radioButton = this.m_aa;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_aa = A_0;
		radioButton = this.m_aa;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d ae()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		r.d.b a_ = d;
		this.m_ag?.e(a_);
		this.m_ag = A_0;
		this.m_ag?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d af()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void b(r.d A_0)
	{
		r.d.b a_ = c;
		this.m_ah?.e(a_);
		this.m_ah = A_0;
		this.m_ah?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d ag()
	{
		return ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void c(r.d A_0)
	{
		r.d.b a_ = b;
		ai?.e(a_);
		ai = A_0;
		ai?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d ah()
	{
		return aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void d(r.d A_0)
	{
		r.d.b a_ = a;
		aj?.e(a_);
		aj = A_0;
		aj?.d(a_);
	}

	[SpecialName]
	private Point c()
	{
		checked
		{
			return new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2));
		}
	}

	public void a(f1 A_0, Guid A_1, f4 A_2, fz A_3)
	{
		this.m_ab = A_0;
		this.m_ad = A_1;
		this.m_ac = A_1.ToString();
		this.m_ae = A_2;
		this.m_af = A_3;
		b();
		z().Enabled = this.m_ab.wy(this.m_ad) != null;
		ShowDialog();
	}

	private void a(bool A_0)
	{
		if (!A_0)
		{
			f().Enabled = false;
			s().Enabled = false;
			y().Enabled = false;
			z().Enabled = false;
			e().Enabled = false;
		}
		else
		{
			f().Enabled = true;
			s().Enabled = true;
			y().Enabled = true;
			z().Enabled = this.m_ab.wy(this.m_ad) != null;
			e().Enabled = true;
		}
	}

	private void b()
	{
		double[] array = this.m_ab.wx(this.m_ad);
		double[] array2 = this.m_ab.wy(this.m_ad);
		x().Rows.Clear();
		FiberMuxChannel fiberMuxChannel = FiberMuxChannel.UV;
		do
		{
			DataGridViewRow dataGridViewRow = new DataGridViewRow();
			dataGridViewRow.CreateCells(x());
			DataGridViewRow dataGridViewRow2 = dataGridViewRow;
			dataGridViewRow2.Cells[0].Value = fiberMuxChannel.ToString();
			if (array != null && array.Length > (int)fiberMuxChannel)
			{
				dataGridViewRow2.Cells[1].Value = a(array[(int)fiberMuxChannel]).ToString("0.000");
			}
			else
			{
				dataGridViewRow2.Cells[1].Value = string.Empty;
			}
			if (array2 != null && array2.Length > (int)fiberMuxChannel)
			{
				dataGridViewRow2.Cells[2].Value = a(array2[(int)fiberMuxChannel]).ToString("0.000");
			}
			else
			{
				dataGridViewRow2.Cells[2].Value = string.Empty;
			}
			dataGridViewRow2 = null;
			x().Rows.Add(dataGridViewRow);
			fiberMuxChannel++;
		}
		while (fiberMuxChannel <= FiberMuxChannel.Dark);
	}

	private double a(double A_0)
	{
		return (float)((double)jf.h((float)A_0, 0f) * (180.0 / Math.PI) + 180.0);
	}

	private void a()
	{
		float A_ = default(float);
		this.m_ab.m2(this.m_ad, ref A_);
		v().Text = a(A_).ToString("0.000");
	}

	private void f(object A_0, EventArgs A_1)
	{
		base.DialogResult = DialogResult.OK;
		Close();
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			FiberMuxChannel a_ = default(FiberMuxChannel);
			if (r().Checked)
			{
				a_ = FiberMuxChannel.UV;
			}
			else if (q().Checked)
			{
				a_ = FiberMuxChannel.Violet;
			}
			else if (p().Checked)
			{
				a_ = FiberMuxChannel.Green;
			}
			else if (o().Checked)
			{
				a_ = FiberMuxChannel.Red;
			}
			else if (n().Checked)
			{
				a_ = FiberMuxChannel.NIR1;
			}
			else if (m().Checked)
			{
				a_ = FiberMuxChannel.NIR2;
			}
			else if (l().Checked)
			{
				a_ = FiberMuxChannel.SWIR1;
			}
			else if (k().Checked)
			{
				a_ = FiberMuxChannel.SWIR2;
			}
			else if (j().Checked)
			{
				a_ = FiberMuxChannel.SWIR3;
			}
			else if (i().Checked)
			{
				a_ = FiberMuxChannel.FilterHP550;
			}
			else if (h().Checked)
			{
				a_ = FiberMuxChannel.FilterLP700;
			}
			else if (g().Checked)
			{
				a_ = FiberMuxChannel.FilterHP1200;
			}
			else if (ad().Checked)
			{
				a_ = FiberMuxChannel.Dark;
			}
			this.m_ab.m2(this.m_ad, a_, global::r.d.a.b.a, ag());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_af, this.m_ab, this.m_ae, c(), "DialogSelectScatter " + ((Control)A_0).Name + ".RadioButtonSelectChannel_CheckedChanged", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			a();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_af, this.m_ab, this.m_ae, c(), "DialogSelectScatter " + ((Control)A_0).Name + ".ButtonReadAngle_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			double a_ = (Conversions.ToDouble(v().Text) - 180.0) * (Math.PI / 180.0);
			_ = string.Empty;
			this.m_ab.m2(this.m_ad, a_, global::r.d.a.b.a, af());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_af, this.m_ab, this.m_ae, c(), "DialogSelectScatter " + ((Control)A_0).Name + ".ButtonSetAngle_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_ab.qh(this.m_ad, global::r.d.a.b.a, ah());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_af, this.m_ab, this.m_ae, c(), "DialogSelectScatter " + ((Control)A_0).Name + ".ButtonSaveAngles_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			a(A_0: false);
			Cursor = Cursors.WaitCursor;
			this.m_ab.p9(this.m_ad, global::r.d.a.b.a, ae());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_af, this.m_ab, this.m_ae, c(), "DialogSelectScatter " + ((Control)A_0).Name + ".ButtonCalibrateAngles_Click", a_);
			a(A_0: true);
			Cursor = Cursors.Arrow;
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
			if (A_0.a != global::r.d.a.a.a)
			{
				fe.b(this.m_af, "Angle Calibration has failed.", i6.a(this));
			}
			b();
			a(A_0: true);
			Cursor = Cursors.Arrow;
			r().Checked = true;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_af.c(fz.b.b, "Exception caught in DialogSelectScatter.mAngleCalibrationCompletionTask_TaskFinishedEvent. ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new r.d.b(c), A_0);
				return;
			}
			if (A_0.a != global::r.d.a.a.a)
			{
				fe.b(this.m_af, "Failure in establishing the new Fiber Mux angle. " + A_0.b, i6.a(this));
			}
			a();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_af.c(fz.b.b, "Exception caught in DialogSelectScatter.mSetFiberMuxAngleCompletionTask_TaskFinishedEvent. ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new r.d.b(b), A_0);
				return;
			}
			if (A_0.a != global::r.d.a.a.a)
			{
				fe.b(this.m_af, "Failure in setting the Scatter Channel.", i6.a(this));
			}
			a();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_af.c(fz.b.b, "Exception caught in DialogSelectScatter.mSetScatterChannelCompletionTask_TaskFinishedEvent. ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new r.d.b(a), A_0);
				return;
			}
			if (A_0.a != global::r.d.a.a.a)
			{
				fe.b(this.m_af, "Failure saving the calibrated scatter angles.", i6.a(this));
			}
			b();
			z().Enabled = this.m_ab.wy(this.m_ad) != null;
			r().Checked = true;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_af.c(fz.b.b, "Exception caught in DialogSelectScatter.mSaveScatterAnglesCompletionTask. ", a_);
			ProjectData.ClearProjectError();
		}
	}
}
