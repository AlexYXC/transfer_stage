using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class bq : Form
{
	private enum a
	{
		a,
		b
	}

	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private GroupBox m_c;

	[CompilerGenerated]
	private Label m_d;

	[CompilerGenerated]
	private Label m_e;

	[CompilerGenerated]
	private Label m_f;

	[CompilerGenerated]
	private Label m_g;

	[CompilerGenerated]
	private Label m_h;

	[CompilerGenerated]
	private Label m_i;

	[CompilerGenerated]
	private Label m_j;

	[CompilerGenerated]
	private Label m_k;

	[CompilerGenerated]
	private GroupBox m_l;

	[CompilerGenerated]
	private Label m_m;

	[CompilerGenerated]
	private Label m_n;

	[CompilerGenerated]
	private GroupBox m_o;

	[CompilerGenerated]
	private Button m_p;

	[CompilerGenerated]
	private Label m_q;

	[CompilerGenerated]
	private Label m_r;

	[CompilerGenerated]
	private Label m_s;

	[CompilerGenerated]
	private Label m_t;

	[CompilerGenerated]
	private Label m_u;

	[CompilerGenerated]
	private Label m_v;

	[CompilerGenerated]
	private GroupBox m_w;

	[CompilerGenerated]
	private Button m_x;

	[CompilerGenerated]
	private Label m_y;

	[CompilerGenerated]
	private Label m_z;

	[CompilerGenerated]
	private Label m_aa;

	[CompilerGenerated]
	private Label m_ab;

	[CompilerGenerated]
	private Label m_ac;

	[CompilerGenerated]
	private Label m_ad;

	[CompilerGenerated]
	private Label m_ae;

	[CompilerGenerated]
	private Label m_af;

	[CompilerGenerated]
	private ProgressBar m_ag;

	[CompilerGenerated]
	private ProgressBar m_ah;

	private const string m_ai = "DialogUVLightSource";

	private f1 m_aj;

	private fz m_ak;

	private Guid m_al;

	private bool m_am;

	private bool m_an;

	private bool m_ao;

	private bool m_ap;

	private bool aq;

	private DateTime ar;

	private const int @as = 15;

	private const int at = 10;

	[CompilerGenerated]
	private System.Timers.Timer au;

	[CompilerGenerated]
	private System.Timers.Timer av;

	[CompilerGenerated]
	private r.d aw;

	[CompilerGenerated]
	private r.d ax;

	public bq()
	{
		base.FormClosing += a;
		a(new r.d());
		b(new r.d());
		e();
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
	private void e()
	{
		a(new Button());
		a(new GroupBox());
		a(new Label());
		b(new Label());
		c(new Label());
		d(new Label());
		e(new Label());
		f(new Label());
		g(new Label());
		h(new Label());
		b(new GroupBox());
		i(new Label());
		j(new Label());
		c(new GroupBox());
		b(new Button());
		k(new Label());
		l(new Label());
		m(new Label());
		n(new Label());
		o(new Label());
		p(new Label());
		d(new GroupBox());
		c(new Button());
		q(new Label());
		r(new Label());
		s(new Label());
		t(new Label());
		u(new Label());
		v(new Label());
		w(new Label());
		x(new Label());
		b(new ProgressBar());
		a(new ProgressBar());
		g().SuspendLayout();
		p().SuspendLayout();
		s().SuspendLayout();
		aa().SuspendLayout();
		SuspendLayout();
		f().BackColor = SystemColors.Control;
		f().DialogResult = DialogResult.Cancel;
		f().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f().Location = new Point(116, 428);
		f().Margin = new Padding(4);
		f().Name = "ButtonClose";
		f().Size = new Size(89, 28);
		f().TabIndex = 0;
		f().Text = "Close";
		f().UseVisualStyleBackColor = true;
		g().Controls.Add(h());
		g().Controls.Add(i());
		g().Controls.Add(j());
		g().Controls.Add(k());
		g().Controls.Add(l());
		g().Controls.Add(m());
		g().Controls.Add(n());
		g().Controls.Add(o());
		g().Location = new Point(12, 306);
		g().Name = "GroupBox5";
		g().Size = new Size(297, 115);
		g().TabIndex = 3;
		g().TabStop = false;
		g().Text = "System";
		h().AutoSize = true;
		h().BorderStyle = BorderStyle.FixedSingle;
		h().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		h().Location = new Point(145, 40);
		h().Name = "LabelFanFailureBox";
		h().Size = new Size(65, 18);
		h().TabIndex = 19;
		h().Text = "Unknown";
		i().AutoSize = true;
		i().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		i().Location = new Point(61, 40);
		i().Name = "Label8";
		i().Size = new Size(78, 16);
		i().TabIndex = 18;
		i().Text = "Fan Failure:";
		j().AutoSize = true;
		j().BorderStyle = BorderStyle.FixedSingle;
		j().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		j().Location = new Point(145, 64);
		j().Name = "LabelFanRpmBox";
		j().Size = new Size(65, 18);
		j().TabIndex = 17;
		j().Text = "Unknown";
		k().AutoSize = true;
		k().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		k().Location = new Point(72, 64);
		k().Name = "Label5";
		k().Size = new Size(67, 16);
		k().TabIndex = 16;
		k().Text = "Fan RPM:";
		l().AutoSize = true;
		l().BorderStyle = BorderStyle.FixedSingle;
		l().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		l().Location = new Point(145, 88);
		l().Name = "LabelFrontPanelDisableState";
		l().Size = new Size(65, 18);
		l().TabIndex = 15;
		l().Text = "Unknown";
		m().AutoSize = true;
		m().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		m().Location = new Point(6, 88);
		m().Name = "Label4";
		m().Size = new Size(137, 16);
		m().TabIndex = 14;
		m().Text = "Front Panel Disabled:";
		n().AutoSize = true;
		n().BorderStyle = BorderStyle.FixedSingle;
		n().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		n().Location = new Point(145, 16);
		n().Name = "LabelOverTemperatureState";
		n().Size = new Size(65, 18);
		n().TabIndex = 13;
		n().Text = "Unknown";
		o().AutoSize = true;
		o().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		o().Location = new Point(21, 16);
		o().Name = "Label18";
		o().Size = new Size(118, 16);
		o().TabIndex = 12;
		o().Text = "OverTemperature:";
		p().Controls.Add(q());
		p().Controls.Add(r());
		p().Location = new Point(12, 243);
		p().Name = "GroupBox4";
		p().Size = new Size(297, 57);
		p().TabIndex = 2;
		p().TabStop = false;
		p().Text = "Shutter";
		q().AutoSize = true;
		q().BorderStyle = BorderStyle.FixedSingle;
		q().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		q().Location = new Point(145, 25);
		q().Name = "LabelShutterOpenState";
		q().Size = new Size(65, 18);
		q().TabIndex = 11;
		q().Text = "Unknown";
		r().AutoSize = true;
		r().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		r().Location = new Point(95, 25);
		r().Name = "Label3";
		r().Size = new Size(44, 16);
		r().TabIndex = 2;
		r().Text = "Open:";
		s().Controls.Add(ak());
		s().Controls.Add(t());
		s().Controls.Add(u());
		s().Controls.Add(v());
		s().Controls.Add(w());
		s().Controls.Add(x());
		s().Controls.Add(y());
		s().Controls.Add(z());
		s().Location = new Point(12, 138);
		s().Name = "GroupBox3";
		s().Size = new Size(297, 99);
		s().TabIndex = 1;
		s().TabStop = false;
		s().Text = "Tungsten-Halogen Lamp";
		t().AutoSize = true;
		t().Enabled = false;
		t().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		t().Location = new Point(225, 65);
		t().Name = "ButtonTHOnTimeReset";
		t().Size = new Size(63, 26);
		t().TabIndex = 13;
		t().Text = "Reset...";
		t().UseVisualStyleBackColor = true;
		u().AutoSize = true;
		u().BorderStyle = BorderStyle.FixedSingle;
		u().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		u().Location = new Point(145, 70);
		u().Name = "LabelTHOnTimeBox";
		u().Size = new Size(65, 18);
		u().TabIndex = 15;
		u().Text = "Unknown";
		v().AutoSize = true;
		v().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		v().Location = new Point(11, 70);
		v().Name = "LabelTHOnTime";
		v().Size = new Size(128, 16);
		v().TabIndex = 14;
		v().Text = "Lamp On Time (hrs):";
		w().AutoSize = true;
		w().BorderStyle = BorderStyle.FixedSingle;
		w().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		w().Location = new Point(145, 46);
		w().Name = "LabelTHLampBurnoutState";
		w().Size = new Size(65, 18);
		w().TabIndex = 12;
		w().Text = "Unknown";
		x().AutoSize = true;
		x().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x().Location = new Point(83, 46);
		x().Name = "Label13";
		x().Size = new Size(56, 16);
		x().TabIndex = 11;
		x().Text = "Burnout:";
		y().AutoSize = true;
		y().BorderStyle = BorderStyle.FixedSingle;
		y().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		y().Location = new Point(145, 22);
		y().Name = "LabelTHLampOnState";
		y().Size = new Size(65, 18);
		y().TabIndex = 10;
		y().Text = "Unknown";
		z().AutoSize = true;
		z().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		z().Location = new Point(111, 22);
		z().Name = "Label11";
		z().Size = new Size(28, 16);
		z().TabIndex = 9;
		z().Text = "On:";
		aa().Controls.Add(al());
		aa().Controls.Add(ab());
		aa().Controls.Add(ac());
		aa().Controls.Add(ad());
		aa().Controls.Add(ae());
		aa().Controls.Add(af());
		aa().Controls.Add(ag());
		aa().Controls.Add(ah());
		aa().Controls.Add(ai());
		aa().Controls.Add(aj());
		aa().Location = new Point(12, 12);
		aa().Name = "GroupBox2";
		aa().Size = new Size(297, 123);
		aa().TabIndex = 0;
		aa().TabStop = false;
		aa().Text = "Deuterium Lamp";
		ab().AutoSize = true;
		ab().Enabled = false;
		ab().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ab().Location = new Point(225, 89);
		ab().Name = "ButtonD2OnTimeReset";
		ab().Size = new Size(63, 26);
		ab().TabIndex = 9;
		ab().Text = "Reset...";
		ab().UseVisualStyleBackColor = true;
		ac().AutoSize = true;
		ac().BorderStyle = BorderStyle.FixedSingle;
		ac().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ac().Location = new Point(145, 94);
		ac().Name = "LabelD2OnTimeBox";
		ac().Size = new Size(65, 18);
		ac().TabIndex = 12;
		ac().Text = "Unknown";
		ad().AutoSize = true;
		ad().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ad().Location = new Point(11, 94);
		ad().Name = "LabelD2OnTime";
		ad().Size = new Size(128, 16);
		ad().TabIndex = 11;
		ad().Text = "Lamp On Time (hrs):";
		ae().AutoSize = true;
		ae().BorderStyle = BorderStyle.FixedSingle;
		ae().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae().Location = new Point(145, 70);
		ae().Name = "LabelD2LampFaultState";
		ae().Size = new Size(65, 18);
		ae().TabIndex = 10;
		ae().Text = "Unknown";
		af().AutoSize = true;
		af().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		af().Location = new Point(99, 72);
		af().Name = "Label15";
		af().Size = new Size(40, 16);
		af().TabIndex = 9;
		af().Text = "Fault:";
		ag().AutoSize = true;
		ag().BorderStyle = BorderStyle.FixedSingle;
		ag().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ag().Location = new Point(145, 46);
		ag().Name = "LabelD2LampOnState";
		ag().Size = new Size(65, 18);
		ag().TabIndex = 8;
		ag().Text = "Unknown";
		ah().AutoSize = true;
		ah().BorderStyle = BorderStyle.FixedSingle;
		ah().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ah().Location = new Point(145, 22);
		ah().Name = "LabelD2LampWarmingState";
		ah().Size = new Size(65, 18);
		ah().TabIndex = 7;
		ah().Text = "Unknown";
		ai().AutoSize = true;
		ai().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ai().Location = new Point(74, 22);
		ai().Name = "Label7";
		ai().Size = new Size(65, 16);
		ai().TabIndex = 6;
		ai().Text = "Warming:";
		aj().AutoSize = true;
		aj().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aj().Location = new Point(111, 46);
		aj().Name = "Label1";
		aj().Size = new Size(28, 16);
		aj().TabIndex = 0;
		aj().Text = "On:";
		al().Location = new Point(225, 72);
		al().Name = "ProgressBarD2Reset";
		al().Size = new Size(63, 11);
		al().TabIndex = 4;
		al().Visible = false;
		ak().Location = new Point(225, 48);
		ak().Name = "ProgressBarTHReset";
		ak().Size = new Size(63, 11);
		ak().TabIndex = 13;
		ak().Visible = false;
		base.AcceptButton = f();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = SystemColors.Window;
		base.CancelButton = f();
		base.ClientSize = new Size(320, 465);
		base.Controls.Add(g());
		base.Controls.Add(f());
		base.Controls.Add(p());
		base.Controls.Add(s());
		base.Controls.Add(aa());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogUVLightSource";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "LS-DT2 Light Source Status";
		g().ResumeLayout(performLayout: false);
		g().PerformLayout();
		p().ResumeLayout(performLayout: false);
		p().PerformLayout();
		s().ResumeLayout(performLayout: false);
		s().PerformLayout();
		aa().ResumeLayout(performLayout: false);
		aa().PerformLayout();
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button f()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox g()
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
	internal virtual Label h()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label i()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label j()
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
	internal virtual Label k()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label l()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label m()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label n()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Label A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label o()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Label A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox p()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(GroupBox A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label q()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Label A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label r()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Label A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox s()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(GroupBox A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button t()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = a;
		Button button = this.m_p;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_p = A_0;
		button = this.m_p;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label u()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Label A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label v()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(Label A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label w()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(Label A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label x()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(Label A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label y()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(Label A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label z()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(Label A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox aa()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(GroupBox A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ab()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = b;
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
	internal virtual Label ac()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(Label A_0)
	{
		this.m_y = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ad()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(Label A_0)
	{
		this.m_z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ae()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(Label A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label af()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(Label A_0)
	{
		this.m_ab = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ag()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(Label A_0)
	{
		this.m_ac = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ah()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(Label A_0)
	{
		this.m_ad = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ai()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(Label A_0)
	{
		this.m_ae = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aj()
	{
		return this.m_af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(Label A_0)
	{
		this.m_af = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ProgressBar ak()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ProgressBar A_0)
	{
		this.m_ag = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ProgressBar al()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ProgressBar A_0)
	{
		this.m_ah = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer am()
	{
		return au;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = a;
		System.Timers.Timer timer = au;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		au = A_0;
		timer = au;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer an()
	{
		return av;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void b(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = b;
		System.Timers.Timer timer = av;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		av = A_0;
		timer = av;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d ao()
	{
		return aw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		r.d.b a_ = a;
		aw?.e(a_);
		aw = A_0;
		aw?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d ap()
	{
		return ax;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void b(r.d A_0)
	{
		r.d.b a_ = b;
		ax?.e(a_);
		ax = A_0;
		ax?.d(a_);
	}

	public void a(fz A_0, f1 A_1, Guid A_2, a9.a A_3)
	{
		this.m_aj = A_1;
		this.m_ak = A_0;
		this.m_al = A_2;
		a();
		a(new System.Timers.Timer(1000.0));
		a((object)this, (ElapsedEventArgs)null);
		am().Start();
		Text = a9.ae(A_3) + " Light Source Status";
		ShowDialog();
		am().Stop();
	}

	private ProgressBar d()
	{
		if (aq)
		{
			return al();
		}
		return ak();
	}

	private void a(bool A_0)
	{
		if (A_0)
		{
			Cursor = Cursors.Default;
		}
		else
		{
			Cursor = Cursors.WaitCursor;
		}
		t().Enabled = A_0;
		ab().Enabled = A_0;
		f().Enabled = A_0;
	}

	private void c()
	{
		b(new System.Timers.Timer());
		an().AutoReset = true;
		an().Interval = 100.0;
		ar = DateAndTime.Now;
		ProgressBar progressBar = d();
		progressBar.Value = 0;
		progressBar.Maximum = 150;
		progressBar.Visible = true;
		_ = null;
		an().Start();
	}

	private void b()
	{
		if (an() != null)
		{
			an().Stop();
		}
		b((System.Timers.Timer)null);
	}

	private void a()
	{
		this.m_aj.qh(this.m_al, ao(), global::r.d.a.b.a);
	}

	private void a(Label A_0, int A_1, a A_2)
	{
		Color backColor = Control.DefaultBackColor;
		A_0.Text = (A_1 != 0).ToString();
		switch (A_2)
		{
		case bq.a.a:
			backColor = ((A_1 != 0) ? Color.LightGreen : Color.PaleVioletRed);
			break;
		case bq.a.b:
			backColor = ((A_1 != 0) ? Color.Red : Color.LightGreen);
			break;
		}
		A_0.BackColor = backColor;
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			a(A_0: false);
			aq = true;
			c();
			this.m_aj.sj(this.m_al, ap(), global::r.d.a.b.a);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			b();
			a(A_0: true);
			i5.a(this.m_ak, this.m_aj, null, i6.a(this), "DialogUVLightSource.ButtonD2OnTimeReset_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			a(A_0: false);
			aq = false;
			c();
			this.m_aj.sm(this.m_al, ap(), global::r.d.a.b.a);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			b();
			a(A_0: true);
			i5.a(this.m_ak, this.m_aj, null, i6.a(this), "DialogUVLightSource.ButtonTHOnTimeReset_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		this.m_am = true;
		b();
	}

	private void b(object A_0, ElapsedEventArgs A_1)
	{
		try
		{
			if (this.m_am)
			{
				return;
			}
			if (base.InvokeRequired)
			{
				an().Stop();
				Invoke(new ElapsedEventHandler(b), A_0, A_1);
				an().Start();
			}
			else
			{
				int num = checked((int)Math.Round(DateTime.Now.Subtract(ar).TotalSeconds * 10.0));
				if (num <= 150)
				{
					d().Value = num;
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
			this.m_ak.c(fz.b.b, "Exception Thrown in DialogUVLightSourcemResetProgressTimer_Elapsed(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, ElapsedEventArgs A_1)
	{
		try
		{
			if (!this.m_am)
			{
				if (base.InvokeRequired)
				{
					am().Stop();
					Invoke(new ElapsedEventHandler(a), A_0, A_1);
					am().Start();
				}
				else
				{
					a();
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
			this.m_ak.c(fz.b.b, "Error in DialogUVLightSource.mLSStatusUpdateTimer_Elapsed", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(r.d.a A_0)
	{
		try
		{
			b();
			if (this.m_am)
			{
				return;
			}
			if (base.InvokeRequired)
			{
				BeginInvoke(new r.d.b(b), A_0);
				return;
			}
			if (!base.IsHandleCreated)
			{
				this.m_ak.c(fz.b.b, "Attempt to Reset On-Time before handle created-Aborted", Environment.StackTrace);
				return;
			}
			_ = (r.g.a)A_0;
			if (A_0.a != global::r.d.a.a.a)
			{
				fe.b(this.m_ak, "Failed to reset Lamp-On Timer.", i6.a(this));
			}
			_ = null;
			a(A_0: true);
			d().Visible = false;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ak.c(fz.b.b, "Exception Thrown in DialogUVLightSourcemResetOnTimeCompletion_TaskFinishedEvent(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.d.a A_0)
	{
		try
		{
			if (this.m_am)
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
				this.m_ak.c(fz.b.b, "Attempt to Update Temperature before handle created-Aborted", Environment.StackTrace);
				return;
			}
			hb hb2 = (hb)((r.g.a)A_0).d;
			if (A_0.a == global::r.d.a.a.a)
			{
				if (!this.m_an && !hb2.o)
				{
					Text = "LS-DT Light Source Status";
					this.m_an = true;
				}
				else
				{
					ab().Enabled = true;
					t().Enabled = true;
				}
				a(ah(), hb2.c, bq.a.a);
				a(ag(), hb2.a, bq.a.a);
				a(ae(), hb2.b, bq.a.b);
				a(y(), hb2.d, bq.a.a);
				a(w(), hb2.e, bq.a.b);
				a(n(), hb2.f, bq.a.b);
				a(q(), hb2.g, bq.a.a);
				a(l(), hb2.h, bq.a.a);
				if (hb2.m)
				{
					ac().Text = hb2.k.ToString("0.00");
				}
				if (hb2.n)
				{
					u().Text = hb2.l.ToString("0.00");
				}
				if (hb2.m && hb2.n)
				{
					a(h(), hb2.i, bq.a.b);
					j().Text = hb2.j.ToString("#####");
				}
			}
			else
			{
				ag().Text = "Unknown";
				ae().Text = "Unknown";
				ah().Text = "Unknown";
				y().Text = "Unknown";
				w().Text = "Unknown";
				n().Text = "Unknown";
				q().Text = "Unknown";
				l().Text = "Unknown";
			}
			hb2 = null;
			_ = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ak.c(fz.b.b, "Exception Thrown in DialogUVLightSourcemStatusCompletionTask_TaskFinishedEvent(). ", a_);
			ProjectData.ClearProjectError();
		}
	}
}
