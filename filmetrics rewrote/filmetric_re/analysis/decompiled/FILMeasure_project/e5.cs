using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FIUsbIntLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class e5 : fj
{
	private new f1 a;

	private new Collection<string> m_b;

	private new Collection<string> m_c;

	[CompilerGenerated]
	private new Button m_d;

	[CompilerGenerated]
	private new GroupBox m_e;

	[CompilerGenerated]
	private new Label m_f;

	[CompilerGenerated]
	private new Label m_g;

	[CompilerGenerated]
	private new Label m_h;

	[CompilerGenerated]
	private Label m_i;

	private Collection<string> m_j;

	[CompilerGenerated]
	private LinkLabel m_k;

	private eo m_l;

	[CompilerGenerated]
	private GroupBox m;

	[CompilerGenerated]
	private Label n;

	[CompilerGenerated]
	private Label m_o;

	[CompilerGenerated]
	private Label m_p;

	[CompilerGenerated]
	private Label m_q;

	[CompilerGenerated]
	private Button m_r;

	[CompilerGenerated]
	private Label m_s;

	[CompilerGenerated]
	private Label m_t;

	[CompilerGenerated]
	private Label m_u;

	[CompilerGenerated]
	private Label m_v;

	[CompilerGenerated]
	private Label w;

	[CompilerGenerated]
	private Label m_x;

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
	private Label m_ag;

	[CompilerGenerated]
	private ComboBox m_ah;

	private IContainer m_ai;

	[SpecialName]
	[CompilerGenerated]
	internal new virtual Button d()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = c;
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
	internal new virtual GroupBox e()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(GroupBox A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal new virtual Label f()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal new virtual Label g()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void c(Label A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal new virtual Label h()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void d(Label A_0)
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
	internal new virtual void e(Label A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual LinkLabel j()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(LinkLabel A_0)
	{
		LinkLabelLinkClickedEventHandler value = b;
		LinkLabel linkLabel = this.m_k;
		if (linkLabel != null)
		{
			linkLabel.LinkClicked -= value;
		}
		this.m_k = A_0;
		linkLabel = this.m_k;
		if (linkLabel != null)
		{
			linkLabel.LinkClicked += value;
		}
	}

	public e5(fz A_0, f1 A_1)
		: base(ref A_0)
	{
		base.Load += b;
		c();
		a = A_1;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_ai != null)
		{
			this.m_ai.Dispose();
		}
		base.Dispose(disposing);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox k()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void c(GroupBox A_0)
	{
		m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label l()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void f(Label A_0)
	{
		n = A_0;
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
	internal new virtual void g(Label A_0)
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
	internal new virtual void h(Label A_0)
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
	internal virtual void i(Label A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button r()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void c(Button A_0)
	{
		EventHandler value = e;
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
	internal virtual Label s()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Label A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label t()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Label A_0)
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
	internal virtual void l(Label A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label v()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(Label A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label x()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(Label A_0)
	{
		w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label y()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(Label A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label z()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(Label A_0)
	{
		this.m_y = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aa()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(Label A_0)
	{
		this.m_z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ab()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(Label A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ac()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(Label A_0)
	{
		this.m_ab = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ad()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(Label A_0)
	{
		this.m_ac = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ae()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(Label A_0)
	{
		this.m_ad = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ag()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(Label A_0)
	{
		this.m_ae = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ah()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(Label A_0)
	{
		this.m_ag = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox ai()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ComboBox A_0)
	{
		EventHandler value = d;
		ComboBox comboBox = this.m_ah;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_ah = A_0;
		comboBox = this.m_ah;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[DebuggerNonUserCode]
	private new void c()
	{
		c(new GroupBox());
		z(new Label());
		b(new ComboBox());
		f(new Label());
		g(new Label());
		h(new Label());
		i(new Label());
		c(new Button());
		j(new Label());
		k(new Label());
		l(new Label());
		o(new Label());
		p(new Label());
		q(new Label());
		r(new Label());
		s(new Label());
		t(new Label());
		u(new Label());
		v(new Label());
		x(new Label());
		y(new Label());
		b(new Button());
		b(new GroupBox());
		e(new Label());
		b(new Label());
		c(new Label());
		d(new Label());
		b(new LinkLabel());
		k().SuspendLayout();
		e().SuspendLayout();
		SuspendLayout();
		k().BackColor = SystemColors.Control;
		k().Controls.Add(ah());
		k().Controls.Add(ai());
		k().Controls.Add(l());
		k().Controls.Add(o());
		k().Controls.Add(p());
		k().Controls.Add(q());
		k().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		k().Location = new Point(12, 248);
		k().Name = "SystemInfo";
		k().RightToLeft = RightToLeft.No;
		k().Size = new Size(293, 157);
		k().TabIndex = 65;
		k().TabStop = false;
		k().Text = "Hardware Information";
		ah().BackColor = SystemColors.Control;
		ah().Cursor = Cursors.Default;
		ah().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ah().ForeColor = SystemColors.ControlText;
		ah().Location = new Point(59, 31);
		ah().Name = "Label4";
		ah().RightToLeft = RightToLeft.No;
		ah().Size = new Size(70, 21);
		ah().TabIndex = 73;
		ah().Text = "System:";
		ah().TextAlign = ContentAlignment.TopRight;
		ai().DropDownStyle = ComboBoxStyle.DropDownList;
		ai().FormattingEnabled = true;
		ai().Location = new Point(136, 28);
		ai().Name = "ComboBoxSystem";
		ai().Size = new Size(133, 24);
		ai().TabIndex = 72;
		l().BackColor = SystemColors.Control;
		l().Cursor = Cursors.Default;
		l().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		l().ForeColor = SystemColors.ControlText;
		l().Location = new Point(32, 117);
		l().Name = "SystemSNlabel";
		l().RightToLeft = RightToLeft.No;
		l().Size = new Size(97, 17);
		l().TabIndex = 24;
		l().Text = "System S/N:";
		l().TextAlign = ContentAlignment.TopRight;
		o().BackColor = SystemColors.Control;
		o().BorderStyle = BorderStyle.Fixed3D;
		o().Cursor = Cursors.Default;
		o().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		o().ForeColor = SystemColors.ControlText;
		o().Location = new Point(136, 63);
		o().Name = "TextBoxCommMode";
		o().RightToLeft = RightToLeft.No;
		o().Size = new Size(133, 42);
		o().TabIndex = 22;
		p().BackColor = SystemColors.Control;
		p().Cursor = Cursors.Default;
		p().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		p().ForeColor = SystemColors.ControlText;
		p().Location = new Point(24, 64);
		p().Name = "Label15";
		p().RightToLeft = RightToLeft.No;
		p().Size = new Size(105, 41);
		p().TabIndex = 21;
		p().Text = "Communication Mode:";
		p().TextAlign = ContentAlignment.TopRight;
		q().BackColor = SystemColors.Control;
		q().BorderStyle = BorderStyle.Fixed3D;
		q().Cursor = Cursors.Default;
		q().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		q().ForeColor = SystemColors.ControlText;
		q().Location = new Point(136, 116);
		q().Name = "SystemNumlabel";
		q().RightToLeft = RightToLeft.No;
		q().Size = new Size(133, 22);
		q().TabIndex = 19;
		r().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		r().Cursor = Cursors.Default;
		r().DialogResult = DialogResult.Cancel;
		r().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		r().ForeColor = SystemColors.ControlText;
		r().Location = new Point(259, 418);
		r().Name = "ButtonOK";
		r().Size = new Size(97, 31);
		r().TabIndex = 62;
		r().Text = "OK";
		s().BackColor = SystemColors.Control;
		s().Cursor = Cursors.Default;
		s().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		s().ForeColor = SystemColors.WindowText;
		s().Location = new Point(333, 126);
		s().Name = "VersionFMImageLabel";
		s().RightToLeft = RightToLeft.No;
		s().Size = new Size(79, 17);
		s().TabIndex = 71;
		s().Text = "none";
		t().BackColor = SystemColors.Control;
		t().Cursor = Cursors.Default;
		t().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		t().ForeColor = SystemColors.WindowText;
		t().Location = new Point(200, 126);
		t().Name = "LabelFMImageVerLbl";
		t().RightToLeft = RightToLeft.No;
		t().Size = new Size(126, 17);
		t().TabIndex = 70;
		t().Text = "FIImage Version:";
		t().TextAlign = ContentAlignment.TopRight;
		u().BackColor = SystemColors.Control;
		u().Cursor = Cursors.Default;
		u().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		u().ForeColor = SystemColors.WindowText;
		u().Location = new Point(203, 89);
		u().Name = "LabelUSBIntVerLbl";
		u().RightToLeft = RightToLeft.No;
		u().Size = new Size(123, 17);
		u().TabIndex = 69;
		u().Text = "USB Int. Version:";
		u().TextAlign = ContentAlignment.TopRight;
		v().BackColor = SystemColors.Control;
		v().Cursor = Cursors.Default;
		v().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		v().ForeColor = SystemColors.WindowText;
		v().Location = new Point(333, 89);
		v().Name = "lblUSBIntVersion";
		v().RightToLeft = RightToLeft.No;
		v().Size = new Size(79, 17);
		v().TabIndex = 68;
		v().Text = "none";
		x().BackColor = SystemColors.Control;
		x().Cursor = Cursors.Default;
		x().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x().ForeColor = Color.FromArgb(0, 0, 128);
		x().Location = new Point(232, 201);
		x().Name = "Label866PhoneNumber";
		x().RightToLeft = RightToLeft.No;
		x().Size = new Size(136, 17);
		x().TabIndex = 67;
		x().Text = "1-866-FAST-MAP";
		x().TextAlign = ContentAlignment.TopCenter;
		x().Visible = false;
		y().BackColor = SystemColors.Control;
		y().Cursor = Cursors.Default;
		y().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		y().ForeColor = SystemColors.WindowText;
		y().Location = new Point(215, 28);
		y().Name = "LabelMinorRev";
		y().RightToLeft = RightToLeft.No;
		y().Size = new Size(161, 17);
		y().TabIndex = 66;
		y().Text = "Build #: ";
		y().TextAlign = ContentAlignment.TopCenter;
		z().BackColor = SystemColors.Control;
		z().Cursor = Cursors.Default;
		z().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		z().ForeColor = SystemColors.WindowText;
		z().Location = new Point(333, 108);
		z().Name = "VersionSolverLabel";
		z().RightToLeft = RightToLeft.No;
		z().Size = new Size(79, 17);
		z().TabIndex = 64;
		z().Text = "none";
		aa().BackColor = SystemColors.Control;
		aa().Cursor = Cursors.Default;
		aa().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aa().ForeColor = SystemColors.WindowText;
		aa().Location = new Point(203, 108);
		aa().Name = "LabelSolverVerLbl";
		aa().RightToLeft = RightToLeft.No;
		aa().Size = new Size(123, 17);
		aa().TabIndex = 63;
		aa().Text = "Solver Version:";
		aa().TextAlign = ContentAlignment.TopRight;
		ab().BackColor = SystemColors.Control;
		ab().Cursor = Cursors.Default;
		ab().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ab().ForeColor = Color.FromArgb(0, 0, 128);
		ab().Location = new Point(246, 184);
		ab().Name = "LabelPhoneNumber";
		ab().RightToLeft = RightToLeft.No;
		ab().Size = new Size(109, 17);
		ab().TabIndex = 61;
		ab().Text = "(858) 573-9300";
		ab().TextAlign = ContentAlignment.TopCenter;
		ac().BackColor = SystemColors.Control;
		ac().Cursor = Cursors.Default;
		ac().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ac().ForeColor = Color.FromArgb(0, 0, 128);
		ac().Location = new Point(229, 167);
		ac().Name = "CityState";
		ac().RightToLeft = RightToLeft.No;
		ac().Size = new Size(143, 17);
		ac().TabIndex = 60;
		ac().Text = "San Diego, CA 92121";
		ac().TextAlign = ContentAlignment.TopCenter;
		ad().BackColor = SystemColors.Control;
		ad().Cursor = Cursors.Default;
		ad().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ad().ForeColor = Color.FromArgb(0, 0, 128);
		ad().Location = new Point(215, 150);
		ad().Name = "StreetAddress";
		ad().RightToLeft = RightToLeft.No;
		ad().Size = new Size(170, 17);
		ad().TabIndex = 59;
		ad().Text = "10655 Roselle St.";
		ad().TextAlign = ContentAlignment.TopCenter;
		ae().BackColor = SystemColors.Control;
		ae().Cursor = Cursors.Default;
		ae().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae().ForeColor = Color.FromArgb(0, 0, 128);
		ae().Location = new Point(186, 50);
		ae().Name = "Label2";
		ae().RightToLeft = RightToLeft.No;
		ae().Size = new Size(226, 41);
		ae().TabIndex = 58;
		ae().Text = "Copyright © 2018 Filmetrics, Inc.\r\nAll rights reserved.";
		ae().TextAlign = ContentAlignment.TopCenter;
		ag().BackColor = SystemColors.Control;
		ag().Cursor = Cursors.Default;
		ag().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ag().ForeColor = Color.FromArgb(0, 0, 128);
		ag().Location = new Point(141, 10);
		ag().Name = "TitleLabel";
		ag().RightToLeft = RightToLeft.No;
		ag().Size = new Size(313, 17);
		ag().TabIndex = 57;
		ag().Text = "TitleLabel";
		ag().TextAlign = ContentAlignment.TopCenter;
		d().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d().Location = new Point(74, 101);
		d().Name = "ButtonRegister";
		d().Size = new Size(159, 33);
		d().TabIndex = 72;
		d().Text = "Register Software...";
		d().UseVisualStyleBackColor = true;
		e().Controls.Add(i());
		e().Controls.Add(f());
		e().Controls.Add(g());
		e().Controls.Add(d());
		e().Controls.Add(h());
		e().Location = new Point(311, 248);
		e().Name = "GroupBoxRegistrationInfo";
		e().Size = new Size(293, 157);
		e().TabIndex = 73;
		e().TabStop = false;
		e().Text = "Software Registration";
		i().BorderStyle = BorderStyle.FixedSingle;
		i().Location = new Point(130, 62);
		i().Name = "LabelCompanyName";
		i().Size = new Size(157, 20);
		i().TabIndex = 74;
		i().Text = "Unknown";
		f().BorderStyle = BorderStyle.FixedSingle;
		f().Location = new Point(101, 31);
		f().Name = "LabelUserName";
		f().Size = new Size(186, 20);
		f().TabIndex = 73;
		f().Text = "Unregistered";
		g().AutoSize = true;
		g().Location = new Point(15, 63);
		g().Name = "Label6";
		g().Size = new Size(109, 16);
		g().TabIndex = 1;
		g().Text = "Company Name:";
		h().AutoSize = true;
		h().Location = new Point(15, 31);
		h().Name = "Label5";
		h().Size = new Size(80, 16);
		h().TabIndex = 0;
		h().Text = "User Name:";
		j().AutoSize = true;
		j().Location = new Point(238, 222);
		j().Name = "LinkLabelOpenFIHomePage";
		j().Size = new Size(124, 16);
		j().TabIndex = 74;
		j().TabStop = true;
		j().Text = "www.Filmetrics.com";
		j().TextAlign = ContentAlignment.TopCenter;
		base.AcceptButton = r();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.CancelButton = r();
		base.ClientSize = new Size(615, 461);
		base.ControlBox = true;
		base.Controls.Add(j());
		base.Controls.Add(e());
		base.Controls.Add(k());
		base.Controls.Add(r());
		base.Controls.Add(s());
		base.Controls.Add(t());
		base.Controls.Add(u());
		base.Controls.Add(v());
		base.Controls.Add(x());
		base.Controls.Add(y());
		base.Controls.Add(z());
		base.Controls.Add(aa());
		base.Controls.Add(ab());
		base.Controls.Add(ac());
		base.Controls.Add(ad());
		base.Controls.Add(ae());
		base.Controls.Add(ag());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogAbout";
		Text = "About FILMeasure";
		k().ResumeLayout(performLayout: false);
		e().ResumeLayout(performLayout: false);
		e().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	protected override Control af()
	{
		return base.f.ar();
	}

	public void b(Form A_0, f1 A_1)
	{
		Collection<Guid> collection = null;
		string A_2 = "";
		bool flag = false;
		this.m_b = new Collection<string>();
		this.m_c = new Collection<string>();
		this.m_j = new Collection<string>();
		ag().Text = global::c.d().Info.Title;
		Text = "About " + global::c.d().Info.Title;
		Version version = global::c.d().Info.Version;
		ag().Text = ag().Text + ", Version " + version.Major + "." + version.Minor + "." + version.Build;
		version = null;
		collection = A_1.tj();
		foreach (Guid item in collection)
		{
			string text = item.ToString();
			Guid a_ = item;
			string A_3 = null;
			A_1.m2(a_, ref A_3, ref A_2);
			this.m_c.Add(A_2);
			ai().Items.Add(A_1.uu(item));
			this.m_b.Add(text);
			this.m_j.Add(A_1.sj(text));
			if (!flag && a.qh(text) == ew.a.a)
			{
				flag = true;
			}
		}
		ai().SelectedIndex = 0;
		y().Text = "Revision: " + global::c.d().Info.Version.Revision;
		z().Text = jg.a(f6.FMSolveVer(1));
		short A_4 = default(short);
		short A_5 = default(short);
		short A_6 = default(short);
		short A_7 = default(short);
		if (a.m2(ref A_4, ref A_5, ref A_6, ref A_7) == 0)
		{
			s().Text = Conversions.ToString((int)A_4) + "." + Conversions.ToString((int)A_5) + "." + Conversions.ToString((int)A_6) + "." + Conversions.ToString((int)A_7);
		}
		((FMusbEnum)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("BB8E1A15-4E65-45FA-9DE6-876792487AF7")))).GetVersion(ref A_4, ref A_5, ref A_6, ref A_7);
		v().Text = Strings.Trim(Conversion.Str(A_4)) + "." + Strings.Trim(Conversion.Str(A_5)) + "." + Conversions.ToString((int)A_6) + "." + Strings.Trim(Conversion.Str(A_7));
		this.m_l = a.t0(collection[0].ToString()).dh();
		b();
		if (!x().Visible)
		{
			j().Top = x().Top;
		}
		j().Visible = flag;
		ad().Visible = flag;
		ac().Visible = flag;
		ab().Visible = flag;
		b(i6.a(A_0));
	}

	private void b()
	{
		if (this.m_l.a8())
		{
			if (!string.IsNullOrEmpty(this.m_l.a9()))
			{
				f().Text = this.m_l.a9();
			}
			i().Text = "Filmetrics (Internal)";
			i().BackColor = Color.Green;
			i().ForeColor = Color.White;
			d().Enabled = false;
		}
		else if (this.m_l.bc())
		{
			f().Text = this.m_l.ba();
			i().Text = "On Record";
			i().BackColor = Color.Blue;
			i().ForeColor = Color.White;
			d().Enabled = false;
		}
		else if (!string.IsNullOrEmpty(this.m_l.ba()))
		{
			f().Text = this.m_l.ba();
			i().Text = this.m_l.be();
			d().Enabled = false;
		}
	}

	private new void e(object A_0, EventArgs A_1)
	{
		c6();
	}

	private new void d(object A_0, EventArgs A_1)
	{
		o().Text = this.m_j[ai().SelectedIndex];
		q().Text = this.m_c[ai().SelectedIndex];
	}

	private new void c(object A_0, EventArgs A_1)
	{
		try
		{
			new dt().a(c3(), this.m_l.bg(), this.m_c[0]);
			this.m_l.ax();
			b();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			c3().c(fz.b.b, "Error in DialogAbout.ButtonRegister_Click", a_);
			Interaction.MsgBox("Error attempting to register software. Error has been logged.");
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, LinkLabelLinkClickedEventArgs A_1)
	{
		try
		{
			Process.Start("http://www.filmetrics.com");
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			c3().c(fz.b.b, "Error in DialogAbout.LinkLabelOpenFIHomePage_LinkClicked", a_);
			Interaction.MsgBox("Error attempting to open browser window to Filmetrics.com. Error has been logged.");
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
	}
}
