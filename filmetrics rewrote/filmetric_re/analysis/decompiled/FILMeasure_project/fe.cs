using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class fe : fj
{
	internal new class a : fj.a
	{
		private string m_a;

		private MsgBoxStyle b;

		private string c;

		private ContentAlignment d;

		private string e;

		private string f;

		private string g;

		private string h;

		private b i;

		private string j;

		private string k;

		private b l;

		private double m;

		private double n;

		private Form o;

		private Point p;

		private bool q;

		private string r;

		private bool s;

		private bool t;

		public a()
		{
			m_a = "";
			w(MsgBoxStyle.OkOnly);
			c = "FilmetricsMessage";
			d = ContentAlignment.MiddleLeft;
			e = "OKString";
			g = "CancelString";
			f = null;
			h = null;
			i = fe.b.b;
			j = "WidestResponse";
			k = "";
			l = fe.b.d;
			m = 0.0;
			n = 1.0;
			o = null;
			v = null;
			q = false;
			t = false;
		}

		[SpecialName]
		public string w()
		{
			return m_a;
		}

		[SpecialName]
		public void w(string A_0)
		{
			m_a = A_0;
		}

		[SpecialName]
		public MsgBoxStyle x()
		{
			return b;
		}

		[SpecialName]
		public void w(MsgBoxStyle A_0)
		{
			b = A_0;
		}

		[SpecialName]
		public string y()
		{
			return c;
		}

		[SpecialName]
		public void x(string A_0)
		{
			c = A_0;
		}

		[SpecialName]
		public ContentAlignment z()
		{
			return d;
		}

		[SpecialName]
		public void w(ContentAlignment A_0)
		{
			d = A_0;
		}

		[SpecialName]
		public string aa()
		{
			return e;
		}

		[SpecialName]
		public void y(string A_0)
		{
			e = A_0;
		}

		[SpecialName]
		public string ab()
		{
			return f;
		}

		[SpecialName]
		public void z(string A_0)
		{
			f = A_0;
		}

		[SpecialName]
		public string ac()
		{
			return g;
		}

		[SpecialName]
		public void aa(string A_0)
		{
			g = A_0;
		}

		[SpecialName]
		public string ad()
		{
			return h;
		}

		[SpecialName]
		public void ab(string A_0)
		{
			h = A_0;
		}

		[SpecialName]
		public b ae()
		{
			return i;
		}

		[SpecialName]
		public void w(b A_0)
		{
			i = A_0;
		}

		[SpecialName]
		public string af()
		{
			return j;
		}

		[SpecialName]
		public void ac(string A_0)
		{
			j = A_0;
		}

		[SpecialName]
		public string ag()
		{
			return k;
		}

		[SpecialName]
		public void ad(string A_0)
		{
			k = A_0;
		}

		[SpecialName]
		public b ah()
		{
			return l;
		}

		[SpecialName]
		public void x(b A_0)
		{
			l = A_0;
		}

		[SpecialName]
		public double ai()
		{
			return m;
		}

		[SpecialName]
		public void w(double A_0)
		{
			m = A_0;
		}

		[SpecialName]
		public double aj()
		{
			return n;
		}

		[SpecialName]
		public void x(double A_0)
		{
			n = A_0;
		}

		[SpecialName]
		public Form ak()
		{
			return o;
		}

		[SpecialName]
		public void w(Form A_0)
		{
			o = A_0;
		}

		[SpecialName]
		public Point al()
		{
			return p;
		}

		[SpecialName]
		public void w(Point A_0)
		{
			p = A_0;
		}

		[SpecialName]
		public bool am()
		{
			return q;
		}

		[SpecialName]
		public void w(bool A_0)
		{
			q = A_0;
		}

		[SpecialName]
		public string an()
		{
			return r;
		}

		[SpecialName]
		public void ae(string A_0)
		{
			r = A_0;
		}

		[SpecialName]
		public bool ao()
		{
			return s;
		}

		[SpecialName]
		public void x(bool A_0)
		{
			s = A_0;
		}

		[SpecialName]
		public bool ap()
		{
			return t;
		}

		[SpecialName]
		public void y(bool A_0)
		{
			t = A_0;
		}
	}

	internal new enum b
	{
		a,
		b,
		c,
		d
	}

	[CompilerGenerated]
	private new TextBox m_a;

	[CompilerGenerated]
	private new Button m_b;

	[CompilerGenerated]
	private new Button m_c;

	[CompilerGenerated]
	private new Label m_d;

	[CompilerGenerated]
	private new Label m_e;

	[CompilerGenerated]
	private new Label m_f;

	[CompilerGenerated]
	private new Label m_g;

	[CompilerGenerated]
	private new CheckBox m_h;

	[CompilerGenerated]
	private Button m_i;

	[CompilerGenerated]
	private Label m_j;

	[CompilerGenerated]
	private LinkLabel m_k;

	private IContainer m_l;

	public static bool m;

	private int n;

	private int m_o;

	private int m_p;

	private int m_q;

	private int m_r;

	private string s;

	[CompilerGenerated]
	private string t;

	[CompilerGenerated]
	private string u;

	public fe(fz A_0)
		: base(ref A_0)
	{
		base.Activated += e;
		base.Load += d;
		c();
		n = checked(e().Left - f().Left - f().Width);
		this.m_o = base.ClientRectangle.Width;
		this.m_p = f().Width;
		this.m_q = d().Width;
		this.m_r = j().Width;
		k().Text = "";
		o().Text = "";
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_l != null)
		{
			this.m_l.Dispose();
		}
		base.Dispose(disposing);
	}

	[SpecialName]
	[CompilerGenerated]
	internal new virtual TextBox d()
	{
		return this.m_a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TextBox A_0)
	{
		EventHandler value = c;
		TextBox textBox = this.m_a;
		if (textBox != null)
		{
			textBox.Enter -= value;
		}
		this.m_a = A_0;
		textBox = this.m_a;
		if (textBox != null)
		{
			textBox.Enter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal new virtual Button e()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = g;
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
	internal new virtual Button f()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void c(Button A_0)
	{
		EventHandler value = f;
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
	internal new virtual Label g()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal new virtual Label h()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void c(Label A_0)
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
	internal new virtual void d(Label A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label j()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void e(Label A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox k()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(CheckBox A_0)
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
	internal new virtual void d(Button A_0)
	{
		EventHandler value = b;
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
	internal virtual Label o()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void f(Label A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual LinkLabel p()
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

	[DebuggerNonUserCode]
	private new void c()
	{
		b(new TextBox());
		b(new Button());
		c(new Button());
		b(new Label());
		c(new Label());
		d(new Label());
		e(new Label());
		b(new CheckBox());
		d(new Button());
		f(new Label());
		b(new LinkLabel());
		SuspendLayout();
		d().AcceptsReturn = true;
		d().BackColor = SystemColors.Window;
		d().Cursor = Cursors.IBeam;
		d().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d().ForeColor = SystemColors.WindowText;
		d().Location = new Point(586, 7);
		d().MaxLength = 0;
		d().Name = "txtInput";
		d().RightToLeft = RightToLeft.No;
		d().Size = new Size(47, 26);
		d().TabIndex = 19;
		d().Text = "txtInput";
		e().Cursor = Cursors.Default;
		e().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e().ForeColor = SystemColors.ControlText;
		e().Location = new Point(532, 104);
		e().Name = "cmdCancel";
		e().Size = new Size(104, 28);
		e().TabIndex = 16;
		e().Text = "Cancel";
		f().Cursor = Cursors.Default;
		f().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f().ForeColor = SystemColors.ControlText;
		f().Location = new Point(417, 104);
		f().Name = "cmdOK";
		f().Size = new Size(104, 28);
		f().TabIndex = 15;
		f().Text = "OK";
		g().AutoSize = true;
		g().BackColor = SystemColors.Control;
		g().Cursor = Cursors.Default;
		g().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		g().ForeColor = SystemColors.ControlText;
		g().Location = new Point(420, 33);
		g().Name = "lblInputWidthTest";
		g().RightToLeft = RightToLeft.No;
		g().Size = new Size(123, 18);
		g().TabIndex = 20;
		g().Text = "lblInputWidthTest";
		g().UseMnemonic = false;
		g().Visible = false;
		h().AutoSize = true;
		h().BackColor = SystemColors.Control;
		h().Cursor = Cursors.Default;
		h().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		h().ForeColor = SystemColors.ControlText;
		h().Location = new Point(419, 81);
		h().Name = "lblButtonTextWidthTest";
		h().RightToLeft = RightToLeft.No;
		h().Size = new Size(162, 18);
		h().TabIndex = 18;
		h().Text = "lblButtonTextWidthTest";
		h().Visible = false;
		i().AutoSize = true;
		i().BackColor = SystemColors.Control;
		i().Cursor = Cursors.Default;
		i().Font = new Font("Trebuchet MS", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		i().ForeColor = SystemColors.ControlText;
		i().Location = new Point(10, 37);
		i().Name = "lblTitleWidthTest";
		i().RightToLeft = RightToLeft.No;
		i().Size = new Size(115, 18);
		i().TabIndex = 17;
		i().Text = "lblTitleWidthTest";
		i().UseMnemonic = false;
		i().Visible = false;
		j().AutoSize = true;
		j().BackColor = SystemColors.Control;
		j().Cursor = Cursors.Default;
		j().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		j().ForeColor = SystemColors.ControlText;
		j().Location = new Point(7, 7);
		j().Name = "lblMessage";
		j().RightToLeft = RightToLeft.No;
		j().Size = new Size(88, 18);
		j().TabIndex = 14;
		j().Text = "lblMessage";
		j().UseMnemonic = false;
		k().AutoSize = true;
		k().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		k().Location = new Point(10, 82);
		k().Name = "CheckBoxAutomaticOkInFuture";
		k().Size = new Size(211, 20);
		k().TabIndex = 21;
		k().Text = "CheckBoxAutomaticOkInFuture";
		k().UseVisualStyleBackColor = true;
		k().Visible = false;
		l().AutoSize = true;
		l().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		l().Location = new Point(10, 105);
		l().Name = "ButtonReset";
		l().Size = new Size(62, 26);
		l().TabIndex = 22;
		l().Text = "Reset";
		l().UseVisualStyleBackColor = true;
		l().Visible = false;
		o().AutoSize = true;
		o().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		o().Location = new Point(73, 110);
		o().Name = "LabelResetDescrip";
		o().Size = new Size(160, 16);
		o().TabIndex = 23;
		o().Text = "(Reset button description)";
		o().Visible = false;
		p().AutoSize = true;
		p().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		p().Location = new Point(10, 110);
		p().Name = "LinkLabelInfo";
		p().Size = new Size(73, 16);
		p().TabIndex = 24;
		p().TabStop = true;
		p().Text = "LinkLabel1";
		p().Visible = false;
		base.AcceptButton = f();
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.ClientSize = new Size(643, 139);
		base.Controls.Add(p());
		base.Controls.Add(o());
		base.Controls.Add(l());
		base.Controls.Add(k());
		base.Controls.Add(d());
		base.Controls.Add(e());
		base.Controls.Add(f());
		base.Controls.Add(g());
		base.Controls.Add(h());
		base.Controls.Add(i());
		base.Controls.Add(j());
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogMsgBox";
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	protected override Control af()
	{
		return base.f.ar();
	}

	public static bool b(ref fz A_0, string A_1, string A_2, string A_3, string A_4, Point A_5)
	{
		fz a_ = A_0;
		bool A_6 = false;
		return b(a_, A_1, A_2, A_3, A_4, A_5, "", ref A_6, A_8: false);
	}

	public static bool b(ref fz A_0, string A_1, string A_2, bool A_3, string A_4, string A_5, Point A_6)
	{
		fz a_ = A_0;
		bool A_7 = false;
		return b(a_, A_1, A_2, A_3, A_4, A_5, A_6, "", ref A_7, A_9: false);
	}

	public static bool b(ref fz A_0, string A_1, string A_2, string A_3, string A_4, Point A_5, string A_6, ref bool A_7)
	{
		return b(A_0, A_1, A_2, A_3, A_4, A_5, A_6, ref A_7, A_8: false);
	}

	public static bool b(fz A_0, string A_1, string A_2, string A_3, string A_4, Point A_5, string A_6, ref bool A_7, bool A_8)
	{
		string A_9 = null;
		return b(A_0, A_1, A_2, A_3, A_4, A_5, fe.b.b, A_7: false, ref A_9, null, A_6, ref A_7, fe.b.d, 0.0, 0.0, A_8);
	}

	public static bool b(fz A_0, string A_1, string A_2, bool A_3, string A_4, string A_5, Point A_6, string A_7, ref bool A_8, bool A_9)
	{
		string A_10 = null;
		return b(A_0, A_1, A_2, A_3, A_4, A_5, A_6, fe.b.b, A_8: false, ref A_10, null, A_7, ref A_8, fe.b.d, 0.0, 0.0, A_9);
	}

	public static bool b(fz A_0, string A_1, string A_2, string A_3, string A_4, Point A_5, b A_6, bool A_7, ref string A_8, string A_9, string A_10, ref bool A_11, b A_12, double A_13, double A_14, bool A_15)
	{
		return b(A_0, A_1, A_2, A_3: false, A_3, A_4, A_5, A_6, A_7, ref A_8, A_9, A_10, ref A_11, A_12, A_13, A_14, A_15);
	}

	public static bool b(fz A_0, string A_1, string A_2, bool A_3, string A_4, string A_5, Point A_6, b A_7, bool A_8, ref string A_9, string A_10, string A_11, ref bool A_12, b A_13, double A_14, double A_15, bool A_16)
	{
		fe obj = new fe(A_0);
		a a10 = new a();
		a a11 = a10;
		a11.w(A_1);
		a11.x(A_2);
		if (A_3)
		{
			a11.y(A_0: true);
			a11.z(A_4);
			a11.ab(A_5);
		}
		else
		{
			a11.y(A_4);
			a11.aa(A_5);
		}
		a11.w(MsgBoxStyle.OkCancel);
		a11.w(A_6);
		a11.w(A_7);
		a11.ad(A_9);
		a11.ac(A_10);
		a11.x(A_8);
		a11.w(A_14);
		a11.x(A_15);
		a11.x(A_13);
		a11 = null;
		fe fe2 = obj;
		fe2.k().Visible = !string.IsNullOrEmpty(A_11);
		fe2.k().Text = A_11;
		fe2.k().Checked = A_12;
		if (A_16)
		{
			fe2.TopMost = true;
		}
		DialogResult num = fe2.b(a10);
		A_12 = fe2.k().Checked;
		if (A_7 == fe.b.a)
		{
			A_9 = a10.ag();
		}
		fe2 = null;
		return num == DialogResult.OK;
	}

	public static void b(fz A_0, string A_1, string A_2, Point A_3, Form A_4 = null)
	{
		b(A_0, A_1, A_2, "", A_3, A_4);
	}

	public static void b(fz A_0, string A_1, string A_2, Point A_3, bool A_4, Form A_5 = null)
	{
		b(A_0, A_1, A_2, "", A_3, A_4, null, null, A_5);
	}

	public static bool b(fz A_0, string A_1, string A_2, Point A_3, ref string A_4)
	{
		fe obj = new fe(A_0);
		a a10 = new a();
		a10.w(A_1);
		a10.x(A_2);
		a10.y("OKString");
		a10.aa("CancelString");
		a10.w(MsgBoxStyle.OkCancel);
		a10.w(A_3);
		a10.w(fe.b.a);
		a10.ad(A_4);
		_ = null;
		obj.b(a10);
		if (obj.DialogResult == DialogResult.OK)
		{
			A_4 = a10.ag();
			return true;
		}
		return false;
	}

	public static void b(fz A_0, string A_1, string A_2, string A_3, Point A_4, Form A_5 = null)
	{
		b(A_0, A_1, A_2, A_3, A_4, A_5: false, null, null, A_5);
	}

	public static void b(fz A_0, string A_1, string A_2, string A_3, Point A_4, bool A_5, string A_6, string A_7, Form A_8 = null)
	{
		bool A_9 = false;
		b(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, null, ref A_9, A_8);
	}

	public static void b(fz A_0, string A_1, string A_2, string A_3, Point A_4, bool A_5, string A_6, string A_7, string A_8, ref bool A_9, Form A_10 = null)
	{
		fe obj = new fe(A_0);
		a a10 = new a();
		a10.w(A_1);
		a10.x(A_2);
		a10.ae(A_3);
		a10.y("OKString");
		a10.w(MsgBoxStyle.OkOnly);
		a10.w(A_4);
		_ = null;
		obj.Owner = A_10;
		fe fe2 = obj;
		fe2.k().Visible = !string.IsNullOrEmpty(A_8);
		fe2.k().Text = A_8;
		fe2.k().Checked = A_9;
		if (!string.IsNullOrEmpty(A_7))
		{
			fe2.c(A_7);
			fe2.b(A_6);
		}
		fe2.b(a10);
		A_9 = fe2.k().Checked;
		fe2 = null;
	}

	public static void b(fz A_0, string A_1, Point A_2, Form A_3 = null)
	{
		b(A_0, A_1, A_2, A_3: false, A_3);
	}

	public static void b(fz A_0, string A_1, Point A_2, bool A_3, Form A_4 = null)
	{
		SystemSounds.Exclamation.Play();
		b(A_0, A_1, "ErrorTitle", A_2, A_3, A_4);
	}

	public static void b(ref fz A_0, string A_1, ref Point A_2)
	{
		b(ref A_0, A_1, ref A_2, A_3: false);
	}

	public static void b(ref fz A_0, string A_1, ref Point A_2, bool A_3)
	{
		SystemSounds.Exclamation.Play();
		b(A_0, A_1, "Warning", A_2, A_3);
	}

	public static void b(ref fz A_0, string A_1, string A_2, ref Point A_3)
	{
		SystemSounds.Exclamation.Play();
		b(A_0, A_1, "Warning", A_2, A_3, null);
	}

	public static void b(fz A_0, string A_1, string A_2, string A_3, Point A_4, ref bool A_5)
	{
		b(A_0, A_1, A_2, A_3, A_4, ref A_5, A_6: false);
	}

	public static void b(fz A_0, string A_1, string A_2, string A_3, Point A_4, ref bool A_5, bool A_6)
	{
		SystemSounds.Exclamation.Play();
		fe obj = new fe(A_0);
		a a10 = new a();
		a10.w(A_1);
		a10.x("Warning");
		a10.ae(A_2);
		a10.y("OKString");
		a10.w(MsgBoxStyle.OkOnly);
		a10.w(A_4);
		_ = null;
		obj.l().Visible = true;
		obj.o().Visible = true;
		obj.l().Enabled = true;
		obj.o().Text = A_3;
		Button button = obj.l();
		string A_7 = "Reset";
		button.Text = hu.a(ref A_7);
		obj.TopMost = A_6;
		obj.b(a10);
		A_5 = a10.am();
	}

	public new static void c(fz A_0, string A_1, string A_2, string A_3, Point A_4)
	{
		fe obj = new fe(A_0);
		a a10 = new a();
		a10.w(A_1);
		a10.x(A_2);
		a10.ae(A_3);
		a10.w(MsgBoxStyle.OkOnly);
		a10.w(A_4);
		_ = null;
		obj.b(a10);
		_ = null;
	}

	public static void b(fz A_0, string A_1, string A_2, string A_3, Point A_4)
	{
		fe obj = new fe(A_0);
		a a10 = new a();
		a10.w(A_1);
		a10.x(A_2);
		a10.ae(A_3);
		a10.w(MsgBoxStyle.Information);
		a10.w(A_4);
		_ = null;
		obj.b(a10);
		_ = null;
	}

	public DialogResult b(a A_0)
	{
		checked
		{
			try
			{
				base.f = A_0;
				a a10 = A_0;
				Point a_;
				if (a10.ak() != null)
				{
					Form form = a10.ak();
					a_ = new Point(form.Location.X + unchecked(form.Width / 2), form.Location.Y + unchecked(form.Height / 2));
					form = null;
				}
				else
				{
					a_ = a10.al();
				}
				a10 = null;
				if (!base.TopMost)
				{
					foreach (Form openForm in global::c.d().OpenForms)
					{
						if (openForm.TopMost)
						{
							base.TopMost = true;
							break;
						}
					}
				}
				this.m_o = Screen.AllScreens[i6.a(a_.X, a_.Y)].Bounds.Width - (base.Width - base.ClientRectangle.Width);
				a a11;
				string A_1 = (a11 = A_0).y();
				string obj = hu.a(ref A_1);
				a11.x(A_1);
				Text = obj;
				a a12 = (a)base.f;
				if (!string.IsNullOrEmpty(a12.an()))
				{
					Text = Text + " - " + a12.an();
				}
				a12 = null;
				int num;
				if (((a)base.f).ae() == fe.b.a)
				{
					Label label = g();
					A_1 = (a11 = A_0).af();
					string obj2 = hu.a(ref A_1);
					a11.ac(A_1);
					label.Text = obj2;
					if (g().Width + 9 < this.m_q)
					{
						d().Width = this.m_q;
					}
					else
					{
						d().Width = g().Width + 9;
					}
					if (this.m_o - d().Width - 8 - j().Left < this.m_r)
					{
						d().Width = this.m_o - this.m_r - 8 - j().Left;
					}
					num = this.m_o - d().Width - 8 - j().Left;
					d().Text = A_0.ag();
					d().Visible = true;
				}
				else
				{
					num = this.m_o - j().Left;
					d().Visible = false;
				}
				j().Text = A_0.w();
				j().TextAlign = A_0.z();
				if (j().Left + j().Width + 8 > num)
				{
					j().AutoSize = false;
					j().Width = num - j().Left - 8;
					SizeF layoutArea = new SizeF(j().Width, 5000f);
					Graphics graphics = Graphics.FromHwnd(j().Handle);
					SizeF sizeF = graphics.MeasureString(A_0.w(), j().Font, layoutArea);
					graphics.Dispose();
					j().Height = (int)Math.Round(sizeF.Height);
				}
				int num2 = j().Left + j().Width + 8;
				if (((a)base.f).ae() == fe.b.a)
				{
					d().Left = j().Left + j().Width + 8;
					d().Top = (int)Math.Round((double)j().Top + (double)j().Height / 2.0 - (double)d().Height / 2.0);
					num2 = num2 + 8 + d().Width;
				}
				Label label2 = i();
				A_1 = (a11 = A_0).y();
				string obj3 = hu.a(ref A_1);
				a11.x(A_1);
				label2.Text = obj3;
				int num3 = i().Width + 17;
				if (num3 > this.m_o)
				{
					num3 = this.m_o;
				}
				if (num3 > num2)
				{
					num2 = num3;
				}
				h().Font = f().Font;
				if (A_0.ap())
				{
					h().Text = A_0.ab();
				}
				else
				{
					Label label3 = h();
					A_1 = (a11 = A_0).aa();
					string obj4 = hu.a(ref A_1);
					a11.y(A_1);
					label3.Text = obj4;
				}
				f().Width = h().Width + 37;
				if (f().Width < this.m_p)
				{
					f().Width = this.m_p;
				}
				else if (f().Width + 16 > this.m_o)
				{
					f().Width = this.m_o - 16;
				}
				int num4 = f().Width + 16;
				if (A_0.x() != MsgBoxStyle.OkOnly)
				{
					if (A_0.ap())
					{
						h().Text = A_0.ad();
					}
					else
					{
						Label label4 = h();
						A_1 = (a11 = A_0).ac();
						string obj5 = hu.a(ref A_1);
						a11.aa(A_1);
						label4.Text = obj5;
					}
					int num5 = h().Width + 37;
					bool flag;
					if (num5 + 16 + n + f().Width > this.m_o)
					{
						num5 = this.m_o - 16 - n - f().Width;
						flag = true;
					}
					else
					{
						flag = false;
					}
					if (flag && num5 < this.m_p)
					{
						f().Width = this.m_o - 16 - n - this.m_p;
					}
					if (num5 < this.m_p)
					{
						num5 = this.m_p;
					}
					e().Width = num5;
					num4 = f().Width + 16 + n + e().Width;
				}
				if (num4 > num2)
				{
					num2 = num4;
				}
				base.Width = num2 + base.Width - base.ClientRectangle.Width;
				if (A_0.ap())
				{
					e().Text = A_0.ad();
					f().Text = A_0.ab();
				}
				else
				{
					Button button = e();
					A_1 = (a11 = A_0).ac();
					string obj6 = hu.a(ref A_1);
					a11.aa(A_1);
					button.Text = obj6;
					Button button2 = f();
					A_1 = (a11 = A_0).aa();
					string obj7 = hu.a(ref A_1);
					a11.y(A_1);
					button2.Text = obj7;
				}
				e().Top = j().Top + j().Height + 17;
				f().Top = e().Top;
				if (!string.IsNullOrEmpty(r()))
				{
					p().Text = r();
					p().Visible = true;
					p().Top = f().Top + unchecked(f().Height / 2) - unchecked(p().Height / 2);
				}
				bool flag2;
				if (!string.IsNullOrEmpty(k().Text) || !string.IsNullOrEmpty(o().Text))
				{
					if (!string.IsNullOrEmpty(k().Text))
					{
						k().Top = e().Top + unchecked(e().Height / 2) - unchecked(k().Height / 2);
						if (A_0.x() == MsgBoxStyle.OkOnly)
						{
							int num6 = k().Right + 16 + f().Width;
							if (num6 > base.ClientRectangle.Width)
							{
								base.Width = num6 + base.Width - base.ClientRectangle.Width;
							}
							flag2 = false;
							f().Left = base.ClientRectangle.Width - f().Width - 8;
						}
						else
						{
							int num6 = k().Right + 16 + e().Width + n + f().Width;
							if (num6 > base.ClientRectangle.Width)
							{
								base.Width = num6 + base.Width - base.ClientRectangle.Width;
							}
							flag2 = true;
							e().Left = base.ClientRectangle.Width - e().Width - 8;
							f().Left = e().Left - n - f().Width;
						}
					}
					else
					{
						l().Top = e().Top + unchecked(e().Height / 2) - unchecked(l().Height / 2);
						o().Top = l().Top + unchecked(l().Height / 2) - unchecked(o().Height / 2);
						if (A_0.x() == MsgBoxStyle.OkOnly)
						{
							int num6 = o().Right + 32 + f().Width;
							if (num6 > base.ClientRectangle.Width)
							{
								base.Width = num6 + base.Width - base.ClientRectangle.Width;
							}
							flag2 = false;
							f().Left = base.ClientRectangle.Width - f().Width - 8;
						}
						else
						{
							int num6 = o().Right + 32 + e().Width + n + f().Width;
							if (num6 > base.ClientRectangle.Width)
							{
								base.Width = num6 + base.Width - base.ClientRectangle.Width;
							}
							flag2 = true;
							e().Left = base.ClientRectangle.Width - e().Width - 8;
							f().Left = e().Left - n - f().Width;
						}
					}
				}
				else if (A_0.x() == MsgBoxStyle.OkOnly)
				{
					flag2 = false;
					f().Left = unchecked(base.ClientRectangle.Width / 2) - unchecked(f().Width / 2);
				}
				else
				{
					flag2 = true;
					f().Left = unchecked(base.ClientRectangle.Width / 2) - unchecked(checked(f().Width + e().Width) / 2) - unchecked(n / 2);
					e().Left = f().Right + n;
				}
				e().Visible = flag2;
				if (flag2)
				{
					string left = e().Text.ToLower();
					A_1 = "CancelString";
					if (Operators.CompareString(left, hu.a(ref A_1).ToLower(), TextCompare: false) == 0)
					{
						base.CancelButton = e();
					}
					else
					{
						base.CancelButton = null;
					}
				}
				else
				{
					base.CancelButton = null;
				}
				base.Height = f().Top + f().Height + 8 + base.Height - base.ClientRectangle.Height;
				m = true;
				b(a_);
				return base.h;
			}
			finally
			{
				m = false;
			}
		}
	}

	private new void g(object A_0, EventArgs A_1)
	{
		if (((a)base.f).ao())
		{
			((a)base.f).ad(d().Text);
		}
		if (!((a)base.f).ao() || !b())
		{
			base.f.z(A_0: true);
			base.h = DialogResult.Cancel;
			base.DialogResult = base.h;
			c4();
		}
	}

	private bool b()
	{
		if (((((a)base.f).ae() == fe.b.a) & (((a)base.f).ah() == fe.b.c)) && (!double.TryParse(d().Text, out var result) || result < ((a)base.f).ai() || result > ((a)base.f).aj()))
		{
			fe fe2 = (fe)(base.d = new fe(c3()));
			base.d.b(base.b);
			string A_ = "ValuesBetweenFmt3";
			string format = hu.a(ref A_);
			A_ = "Value";
			string a_ = string.Format(format, hu.a(ref A_), Strings.Trim(Conversion.Str(((a)base.f).ai())), Strings.Trim(Conversion.Str(((a)base.f).aj())));
			a a10 = new a();
			a10.w(a_);
			a10.x(((a)base.f).y());
			a10.w(this);
			fe2.b(a10);
			return true;
		}
		((a)base.f).ad(d().Text);
		return false;
	}

	private new void f(object A_0, EventArgs A_1)
	{
		if (!b())
		{
			base.f.z(A_0: false);
			base.h = DialogResult.OK;
			base.DialogResult = base.h;
			c4();
		}
	}

	private new void e(object A_0, EventArgs A_1)
	{
		if (d().Visible)
		{
			d().Focus();
		}
	}

	private new void d(object A_0, EventArgs A_1)
	{
		n = checked(e().Left - f().Left - f().Width);
		this.m_o = base.ClientRectangle.Width;
		this.m_p = f().Width;
		this.m_q = d().Width;
		this.m_r = j().Width;
	}

	private new void c(object A_0, EventArgs A_1)
	{
		d().SelectAll();
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			((a)base.f).w(A_0: true);
			_ = null;
			l().Enabled = false;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (base.c == null)
			{
				throw ex3;
			}
			base.c.c(fz.b.b, "Error in DialogMsgBox.ButtonReset_Click", ex3);
			b(base.c, "Error in DialogMsgBox.ButtonReset_Click. Error is " + ex3.ToString(), i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public string q()
	{
		return t;
	}

	[SpecialName]
	[CompilerGenerated]
	public void b(string A_0)
	{
		t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public string r()
	{
		return u;
	}

	[SpecialName]
	[CompilerGenerated]
	public new void c(string A_0)
	{
		u = A_0;
	}

	private void b(object A_0, LinkLabelLinkClickedEventArgs A_1)
	{
		try
		{
			Process.Start(q());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (base.c == null)
			{
				throw ex3;
			}
			base.c.c(fz.b.b, "Error in DialogMsgBox.LinkLabelInfo_LinkClicked", ex3);
			b(base.c, "Error in DialogMsgBox.LinkLabelInfo_LinkClicked. Error is " + ex3.ToString(), i6.a(this));
			ProjectData.ClearProjectError();
		}
	}
}
