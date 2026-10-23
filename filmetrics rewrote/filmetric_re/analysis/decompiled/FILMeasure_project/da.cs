using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class da : Form
{
	private enum a
	{
		a,
		b,
		c
	}

	private enum b
	{
		a,
		b
	}

	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private hy m_e;

	[CompilerGenerated]
	private Button m_f;

	[CompilerGenerated]
	private Label m_g;

	[CompilerGenerated]
	private Label m_h;

	[CompilerGenerated]
	private GroupBox m_i;

	[CompilerGenerated]
	private Label m_j;

	[CompilerGenerated]
	private GroupBox m_k;

	[CompilerGenerated]
	private Label m_l;

	[CompilerGenerated]
	private GroupBox m_m;

	[CompilerGenerated]
	private Label m_n;

	[CompilerGenerated]
	private Label m_o;

	[CompilerGenerated]
	private Label m_p;

	[CompilerGenerated]
	private Button m_q;

	[CompilerGenerated]
	private Label m_r;

	[CompilerGenerated]
	private ProgressBar m_s;

	[CompilerGenerated]
	private Label m_t;

	[CompilerGenerated]
	private Label m_u;

	[CompilerGenerated]
	private Button m_v;

	private fz m_w;

	private f1 m_x;

	private f4 m_y;

	private hr m_z;

	private hr m_aa;

	private string m_ab;

	private Guid m_ac;

	private gr m_ad;

	private et m_ae;

	private et m_af;

	private bool ag;

	private bool ah;

	private a ai;

	private hg aj;

	private h4 ak;

	private string al;

	private bool am;

	private bool an;

	private const string ao = "DialogObjectiveCalibWiz";

	[CompilerGenerated]
	private r.d ap;

	[CompilerGenerated]
	private r.d aq;

	[CompilerGenerated]
	private r.c ar;

	[CompilerGenerated]
	private r.d @as;

	[CompilerGenerated]
	private System.Timers.Timer at;

	private bool au;

	private int av;

	private int aw;

	private DateTime ax;

	private float ay;

	private r.c az;

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
	private void f()
	{
		a(new Button());
		b(new Button());
		c(new Button());
		d(new Button());
		a(new Label());
		b(new Label());
		a(new GroupBox());
		c(new Label());
		b(new GroupBox());
		d(new Label());
		c(new GroupBox());
		f(new Button());
		j(new Label());
		i(new Label());
		a(new ProgressBar());
		e(new Button());
		h(new Label());
		e(new Label());
		f(new Label());
		g(new Label());
		a(new hy());
		n().SuspendLayout();
		p().SuspendLayout();
		r().SuspendLayout();
		SuspendLayout();
		g().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		g().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		g().Location = new Point(215, 222);
		g().Name = "ButtonNext";
		g().Size = new Size(90, 35);
		g().TabIndex = 0;
		g().Text = "Next -->";
		g().UseVisualStyleBackColor = true;
		h().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		h().DialogResult = DialogResult.Cancel;
		h().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		h().Location = new Point(422, 222);
		h().Name = "ButtonCancel";
		h().Size = new Size(90, 35);
		h().TabIndex = 1;
		h().Text = "Cancel";
		h().UseVisualStyleBackColor = true;
		i().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		i().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		i().Location = new Point(119, 222);
		i().Name = "ButtonPrev";
		i().Size = new Size(90, 35);
		i().TabIndex = 2;
		i().Text = "<-- Prev";
		i().UseVisualStyleBackColor = true;
		k().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		k().Location = new Point(206, 115);
		k().Name = "ButtonDoBaseline";
		k().Size = new Size(90, 35);
		k().TabIndex = 5;
		k().Text = "Baseline...";
		k().UseVisualStyleBackColor = true;
		l().BorderStyle = BorderStyle.Fixed3D;
		l().Location = new Point(185, 163);
		l().Name = "LabelStatusBaseline";
		l().Size = new Size(184, 22);
		l().TabIndex = 7;
		l().Text = "Not yet completed";
		m().AutoSize = true;
		m().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		m().Location = new Point(129, 165);
		m().Name = "Label1";
		m().Size = new Size(55, 16);
		m().TabIndex = 6;
		m().Text = "Status:";
		n().Controls.Add(o());
		n().Location = new Point(12, 12);
		n().Name = "GroupBoxPositionTurret";
		n().Size = new Size(500, 197);
		n().TabIndex = 8;
		n().TabStop = false;
		n().Text = "Step 1 of 3";
		o().Location = new Point(6, 18);
		o().Name = "LabelPositionTurretInstr";
		o().Size = new Size(488, 161);
		o().TabIndex = 0;
		o().Text = "LabelPositionTurretInstr";
		o().TextAlign = ContentAlignment.MiddleCenter;
		p().Controls.Add(q());
		p().Controls.Add(k());
		p().Controls.Add(l());
		p().Controls.Add(m());
		p().Location = new Point(534, 12);
		p().Name = "GroupBoxBaseline";
		p().Size = new Size(500, 197);
		p().TabIndex = 9;
		p().TabStop = false;
		p().Text = "Step 2 of 3";
		p().Visible = false;
		q().Location = new Point(6, 18);
		q().Name = "LabelBaselineInstr";
		q().Size = new Size(488, 83);
		q().TabIndex = 0;
		q().Text = "LabelBaselineInstr";
		q().TextAlign = ContentAlignment.MiddleCenter;
		r().Controls.Add(aa());
		r().Controls.Add(z());
		r().Controls.Add(y());
		r().Controls.Add(x());
		r().Controls.Add(v());
		r().Controls.Add(w());
		r().Controls.Add(s());
		r().Controls.Add(t());
		r().Controls.Add(u());
		r().Controls.Add(j());
		r().Location = new Point(534, 215);
		r().Name = "GroupBoxCalibrate";
		r().Size = new Size(500, 197);
		r().TabIndex = 10;
		r().TabStop = false;
		r().Text = "Step 3 of 3";
		r().Visible = false;
		aa().Location = new Point(406, 76);
		aa().Name = "ButtonObjCalAdvanced";
		aa().Size = new Size(87, 26);
		aa().TabIndex = 13;
		aa().Text = "Advanced...";
		aa().UseVisualStyleBackColor = true;
		z().AutoSize = true;
		z().Location = new Point(358, 63);
		z().Name = "LabelCalSampleThicknessUnits";
		z().Size = new Size(38, 16);
		z().TabIndex = 12;
		z().Text = "Units";
		y().AutoSize = true;
		y().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		y().Location = new Point(101, 167);
		y().Name = "Label2";
		y().Size = new Size(75, 16);
		y().TabIndex = 11;
		y().Text = "Progress:";
		x().Location = new Point(176, 163);
		x().Name = "ProgressBarStatus";
		x().Size = new Size(187, 26);
		x().TabIndex = 10;
		v().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		v().Location = new Point(176, 91);
		v().Name = "ButtonCalibrate";
		v().Size = new Size(187, 35);
		v().TabIndex = 9;
		v().Text = "Calibrate Objective...";
		v().UseVisualStyleBackColor = true;
		w().Location = new Point(81, 64);
		w().Name = "LabelCalThickness";
		w().Size = new Size(174, 16);
		w().TabIndex = 8;
		w().Text = "SiO2 Thickness";
		w().TextAlign = ContentAlignment.TopRight;
		s().Location = new Point(6, 18);
		s().Name = "LabelCalibrateInstr";
		s().Size = new Size(488, 38);
		s().TabIndex = 0;
		s().Text = "LabelCalibrateInstr";
		s().TextAlign = ContentAlignment.MiddleCenter;
		t().BorderStyle = BorderStyle.Fixed3D;
		t().Location = new Point(177, 135);
		t().Name = "LabelStatusCalibrate";
		t().Size = new Size(184, 22);
		t().TabIndex = 7;
		t().Text = "Not yet completed";
		u().AutoSize = true;
		u().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		u().Location = new Point(121, 137);
		u().Name = "Label4";
		u().Size = new Size(55, 16);
		u().TabIndex = 6;
		u().Text = "Status:";
		j().f(A_0: false);
		j().Location = new Point(261, 61);
		j().Name = "TextBoxActualThickness";
		j().e(A_0: false);
		j().Size = new Size(83, 22);
		j().TabIndex = 4;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = h();
		base.ClientSize = new Size(524, 269);
		base.Controls.Add(i());
		base.Controls.Add(h());
		base.Controls.Add(g());
		base.Controls.Add(r());
		base.Controls.Add(p());
		base.Controls.Add(n());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogObjectiveCalibWiz";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Objective Calibration";
		n().ResumeLayout(performLayout: false);
		p().ResumeLayout(performLayout: false);
		p().PerformLayout();
		r().ResumeLayout(performLayout: false);
		r().PerformLayout();
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button g()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = e;
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
	internal virtual Button h()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = d;
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
	internal virtual Button i()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = f;
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
	internal virtual hy j()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hy A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button k()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Button A_0)
	{
		EventHandler value = c;
		Button button = this.m_f;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_f = A_0;
		button = this.m_f;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label l()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label m()
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
	internal virtual GroupBox n()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(GroupBox A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label o()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox p()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(GroupBox A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label q()
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
	internal virtual GroupBox r()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(GroupBox A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label s()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label t()
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
	internal virtual Label u()
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
	internal virtual Button v()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Button A_0)
	{
		EventHandler value = a;
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
	internal virtual Label w()
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
	internal virtual ProgressBar x()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ProgressBar A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label y()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Label A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label z()
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
	internal virtual Button aa()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Button A_0)
	{
		EventHandler value = b;
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
	private virtual r.d ab()
	{
		return ap;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		r.d.b a_ = c;
		ap?.e(a_);
		ap = A_0;
		ap?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d ac()
	{
		return aq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void b(r.d A_0)
	{
		r.d.b a_ = b;
		aq?.e(a_);
		aq = A_0;
		aq?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.c ad()
	{
		return ar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.c A_0)
	{
		r.c.b a_ = a;
		ar?.u(a_);
		ar = A_0;
		ar?.t(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d ae()
	{
		return @as;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void c(r.d A_0)
	{
		r.d.b a_ = a;
		@as?.e(a_);
		@as = A_0;
		@as?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer af()
	{
		return at;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = a;
		System.Timers.Timer timer = at;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		at = A_0;
		timer = at;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	public da(fz A_0)
	{
		base.FormClosing += a;
		base.Load += g;
		ak = new h4(h4.a.b);
		a(new System.Timers.Timer());
		f();
		this.m_w = A_0;
		a(new r.d());
		b(new r.d());
		a(new r.c());
		c(new r.d());
	}

	public void a(f1 A_0, f4 A_1, Guid A_2, gr A_3, et A_4, hr A_5, Point A_6)
	{
		this.m_ab = A_2.ToString();
		hg A_7 = A_0.t0(this.m_ab);
		this.m_x = A_0;
		this.m_y = A_1;
		this.m_z = A_5;
		an = this.m_z != null;
		this.m_ac = A_2;
		this.m_ad = A_3;
		ag = false;
		ah = false;
		this.m_af = new et();
		this.m_ae = A_4;
		this.m_ae.ad(this.m_af);
		az = this.m_x.tg(this.m_ab);
		az.t(b);
		if (A_0.sm(A_2, 0) > 850f)
		{
			al = "Parylene";
			ak = new h4(h4.a.c);
		}
		else
		{
			al = "SiO2";
			ak = new h4(h4.a.a);
		}
		w().Text = al + " Thickness";
		z().Text = h4.e(ak, false, false);
		j().Text = h4.e(1, this.m_ae.z(), ak).ToString();
		A_7.bu(ref aj);
		if (A_0.u2())
		{
			c();
		}
		else if (this.m_z == null)
		{
			e();
		}
		else
		{
			c();
		}
		i6.a(A_6, this);
		ShowDialog();
		aj.bu(ref A_7);
		A_7.bv(ae(), A_1: true);
	}

	private void e()
	{
		ai = da.a.a;
		Label label = o();
		string A_ = "ObjectiveCalPositionPromptFmt";
		label.Text = string.Format(hu.a(ref A_), this.m_af.al());
		a(da.a.a);
		i().Enabled = false;
		Button button = g();
		A_ = "WizardNext";
		button.Text = hu.a(ref A_);
		g().Enabled = true;
		h().Enabled = true;
		base.ActiveControl = g();
	}

	private void d()
	{
		ai = da.a.b;
		Label label = q();
		string A_ = "WizardObjCalBaselineInstr";
		label.Text = string.Format(hu.a(ref A_));
		a(da.a.b);
		i().Enabled = true;
		Button button = g();
		A_ = "WizardNext";
		button.Text = hu.a(ref A_);
		g().Enabled = ag;
		h().Enabled = true;
		if (ag)
		{
			Label label2 = l();
			A_ = "BaselineStatusComplete";
			label2.Text = hu.a(ref A_);
			base.ActiveControl = g();
		}
		else
		{
			Label label3 = l();
			A_ = "BaselineStatusIncomplete";
			label3.Text = hu.a(ref A_);
			base.ActiveControl = k();
		}
	}

	private void c()
	{
		ai = da.a.c;
		Label label = s();
		string A_ = "WizardObjCalCalibrateInstrFmt";
		label.Text = string.Format(hu.a(ref A_), al);
		a(da.a.c);
		i().Enabled = this.m_z == null;
		Button button = g();
		A_ = "WizardFinish";
		button.Text = hu.a(ref A_);
		g().Enabled = ah;
		v().Enabled = true;
		h().Enabled = true;
		if (ah)
		{
			Label label2 = t();
			A_ = "BaselineStatusComplete";
			label2.Text = hu.a(ref A_);
			x().Value = 100;
			base.ActiveControl = g();
		}
		else
		{
			Label label3 = t();
			A_ = "BaselineStatusIncomplete";
			label3.Text = hu.a(ref A_);
			x().Value = 0;
			base.ActiveControl = v();
		}
	}

	private void a(a A_0)
	{
		n().Visible = A_0 == da.a.a;
		p().Visible = A_0 == da.a.b;
		r().Visible = A_0 == da.a.c;
	}

	private void a(ref a A_0, b A_1)
	{
		switch (A_0)
		{
		case da.a.a:
			if (A_1 == da.b.a)
			{
				d();
				break;
			}
			throw new am("Attempt to change state other than next when current state is PositionTurret");
		case da.a.b:
			if (A_1 == da.b.a)
			{
				c();
			}
			else
			{
				e();
			}
			break;
		case da.a.c:
			if (A_1 == da.b.a)
			{
				this.m_af.ad(this.m_ae);
				base.DialogResult = DialogResult.OK;
			}
			else
			{
				d();
			}
			break;
		default:
			base.DialogResult = DialogResult.Cancel;
			throw new ArgumentOutOfRangeException("Invalid state in DialogObjectiveCalibWiz");
		}
	}

	private void b()
	{
		lock (af())
		{
			if (au)
			{
				a();
			}
		}
	}

	private void a()
	{
		au = false;
		af().Stop();
		av = 0;
		x().Value = 0;
	}

	private void b(r.c A_0, bool A_1)
	{
		lock (af())
		{
			av = A_0.v();
			aw = A_0.w();
			ax = A_0.x();
			ay = A_0.y();
		}
	}

	private void a(object A_0, ElapsedEventArgs A_1)
	{
		checked
		{
			float num3 = default(float);
			try
			{
				if (this.m_x.tc())
				{
					return;
				}
				if (base.InvokeRequired)
				{
					try
					{
						af().Stop();
						Invoke(new ElapsedEventHandler(a), A_0, A_1);
						return;
					}
					finally
					{
						lock (af())
						{
							if (au)
							{
								af().Start();
							}
						}
					}
				}
				float num = 2f;
				lock (af())
				{
					if (av > 0 && aw > 0)
					{
						float num2 = (float)(100.0 / (double)av);
						num3 = (float)DateTime.Now.Subtract(ax).TotalMilliseconds;
						num = num2 * (float)(aw - 1) + num2 * (1f - (float)Math.Exp(-3f * num3 / ay));
					}
				}
				x().Value = (int)Math.Round((double)num * 0.01 * (double)x().Maximum);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				if (this.m_x.tc())
				{
					ProjectData.ClearProjectError();
					return;
				}
				this.m_w.c(fz.b.b, "Exception caught in FIControlPanelMeasModule.mAcqProgressTimer_Elapsed, elapsed time = " + num3 + ", mAcqProgressCurrentSegmentStartTime = " + ax.ToString() + ", mAcqProgressSegmentTime = " + ay, a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void d(r.d.a A_0)
	{
		try
		{
			r.h.a a10 = (r.h.a)A_0;
			if (((r.d.a)a10).a == global::r.d.a.a.a && !a10.x)
			{
				return;
			}
			if (base.InvokeRequired)
			{
				BeginInvoke(new r.d.b(d), A_0);
				return;
			}
			if (!base.IsHandleCreated)
			{
				this.m_w.c(fz.b.b, "Attempted SpectrumAcquiredEventHandler before handle created-Aborted", Environment.StackTrace);
				return;
			}
			if (((r.d.a)a10).a == global::r.d.a.a.a)
			{
				string A_1 = "";
				this.m_aa = a10.w;
				hr obj = this.m_aa;
				obj.r(obj.cu().i(this.m_af));
				_ = null;
				b();
				Label label = t();
				string A_2 = "CalibratingObjective";
				label.Text = hu.a(ref A_2);
				ce.ErrPublic errPublic = this.m_x.m2(this.m_ab, ref A_1, a10.w, am, ad(), ac(), global::r.d.a.b.a);
				if (errPublic != ce.ErrPublic.None)
				{
					this.m_w.c(fz.b.b, "Error attempting to start calibration of objective in DialogObjectiveCalibWiz.SpectrumAcquiredEventHandler", Environment.StackTrace);
					fz a_ = this.m_w;
					int num = (int)errPublic;
					fe.b(a_, "Error attempting to start calibration of objective. Error return code is " + num, i6.a(this));
					c();
					return;
				}
			}
			this.m_x.v4(this.m_ac).e((r.d.b)d);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			this.m_w.c(fz.b.b, "Exception in DialogObjectiveCalibWiz.SpectrumAcquiredEventHandler", a_2);
			fe.b(this.m_w, "Exception caught in DialogObjectiveCalibWiz.SpectrumAcquiredEventHandler(). Error details have been logged.", i6.a(this));
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
			}
			else if (!base.IsHandleCreated)
			{
				this.m_w.c(fz.b.b, "Attempted mSpectrumAcquireCompletionTask_TaskFinishedEvent before handle created-Aborted", Environment.StackTrace);
			}
			else if (A_0.a == global::r.d.a.a.b)
			{
				b();
				r.g.a a10 = (r.g.a)A_0;
				if (a10.j == global::r.g.a.a.a)
				{
					fz a_ = this.m_w;
					string A_1 = "ErrSingleAcq";
					fe.b(a_, hu.a(ref A_1), i6.a(this));
				}
				else
				{
					fe.b(this.m_w, a10.a6(), i6.a(this));
				}
				c();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			b();
			this.m_w.c(fz.b.b, "Exception caught in DialogObjectiveCalibWiz.mSpectrumAcquireCompletionTask_TaskFinishedEvent(). Exception is: ", a_2);
			fe.b(this.m_w, "Exception caught in DialogObjectiveCalibWiz.mSpectrumAcquireCompletionTask_TaskFinishedEvent(). Error details have been logged.", i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.c A_0, bool A_1)
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new r.c.b(a), A_0, A_1);
			}
			else if (!base.IsHandleCreated)
			{
				this.m_w.c(fz.b.b, "Attempted mCalibrationStatus_StatusChangedEvent before handle created-Aborted", Environment.StackTrace);
			}
			else
			{
				x().Value = checked((int)Math.Round(A_0.t()));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_w.c(fz.b.b, "Exception caught in DialogObjectiveCalibWiz.mCalibrationStatus_StatusChangedEvent(). Exception is: ", a_);
			fe.b(this.m_w, "Exception caught in DialogObjectiveCalibWiz.mCalibrationStatus_StatusChangedEvent(). Error details have been logged.", i6.a(this));
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
			if (!base.IsHandleCreated)
			{
				this.m_w.c(fz.b.b, "Attempted mCalibrationCompletionTask_TaskFinishedEvent before handle created-Aborted", Environment.StackTrace);
				return;
			}
			if (A_0.a == global::r.d.a.a.a)
			{
				this.m_aa.cu().p().ad(this.m_af);
				ah = true;
			}
			else
			{
				fe.b(this.m_w, "Objective calibration failed. " + A_0.b, i6.a(this));
			}
			c();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_w.c(fz.b.b, "Exception caught in DialogObjectiveCalibWiz.mSpectrumAcquireCompletionTask_TaskFinishedEvent(). Exception is: ", a_);
			fe.b(this.m_w, "Exception caught in DialogObjectiveCalibWiz.mCalibrationCompletionTask_TaskFinishedEvent(). Error details have been logged.", i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				r.d.b method = a;
				BeginInvoke(method, A_0);
			}
			else if (A_0.a != global::r.d.a.a.a)
			{
				fe.b(this.m_w, "Error attempting to update recipe", i6.a(this));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_w.c(fz.b.b, "Exception caught in DialogObjectiveCalibWiz.RecipeChangedFinishedHandler()", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		try
		{
			az.u(b);
			if (!h().Enabled)
			{
				A_1.Cancel = true;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_w.c(fz.b.b, "Exception caught in DialogObjectiveCalibWiz.DialogObjectiveCalibWiz_FormClosing(). Exception is: ", a_);
			fe.b(this.m_w, "Exception caught in DialogObjectiveCalibWiz.DialogObjectiveCalibWiz_FormClosing(). Error details have been logged.", i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		p().Location = n().Location;
		r().Location = n().Location;
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
		{
			a(ref ai, da.b.b);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_w, this.m_x, this.m_y, i6.a(i()), "DialogObjectiveCalibWiz", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			a(ref ai, da.b.a);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_w, this.m_x, this.m_y, i6.a(g()), "DialogObjectiveCalibWiz", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		base.DialogResult = DialogResult.Cancel;
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			hg A_2 = this.m_x.t0(this.m_ab);
			hg obj = new hg(A_2.dh(), A_2.cd());
			hi hi2 = new hi(A_2.dh());
			hi2.au(A_2.cd());
			obj.bu(hi2);
			obj.bx(1);
			obj.cc(A_2.c1());
			obj.b9(A_2.ci());
			h obj2 = obj.b8();
			obj2.a(0).h(global::f.a.b);
			obj2.d().a = A_2.b8().d().a;
			obj2.d().i(A_2.b8().d().i());
			_ = null;
			obj.bu(ref A_2);
			A_2.bv(ae(), A_1: true);
			e6.b a_ = e6.b.c;
			e6 e10 = new e6(this.m_w);
			e10.c(a_, this.m_ad, this.m_x, this.m_y, this.m_ac, A_5: false);
			ag = e10.DialogResult == DialogResult.OK;
			d();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_w, this.m_x, this.m_y, i6.a(k()), "DialogObjectiveCalibWiz", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			new a8().n(this.m_af, ref am, this.m_w, this.m_x, this.m_y);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_w, this.m_x, this.m_y, i6.a(aa()), "DialogObjectiveCalibWiz", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			string A_2 = "";
			v().Enabled = false;
			i().Enabled = false;
			g().Enabled = false;
			h().Enabled = false;
			if (!an && this.m_x.qh(this.m_ac))
			{
				bool A_3 = default(bool);
				this.m_y.i(A_0: false, A_1: false, A_2: false, A_3: false, null, ref A_3, i6.a(v()), this);
				if (!A_3)
				{
					c();
					return;
				}
			}
			if (!an)
			{
				System.Timers.Timer timer = af();
				if (!timer.Enabled)
				{
					timer.Interval = 100.0;
					timer.AutoReset = false;
					lock (af())
					{
						au = true;
						timer.Start();
					}
				}
				timer = null;
			}
			Label label = t();
			string A_4 = "AcquiringSpectrum";
			label.Text = hu.a(ref A_4);
			this.m_x.v4(this.m_ac).d((r.d.b)d);
			this.m_af.z((float)ak.e(iz.e(j().Text)));
			this.m_x.m2(this.m_ac, "Thickness Standard", "", "Acquiring spectrum for objective calibration", ref A_2, ab(), null, global::r.d.a.b.a, 3, this.m_z);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			b();
			i5.a(this.m_w, this.m_x, this.m_y, i6.a(v()), "DialogObjectiveCalibWiz", a_);
			ProjectData.ClearProjectError();
		}
	}
}
