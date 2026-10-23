using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class f8 : Form
{
	public delegate void a(int A_0, int A_1, int A_2, int A_3);

	private IContainer m_a;

	public ToolTip b;

	[CompilerGenerated]
	private Label c;

	[CompilerGenerated]
	private Label d;

	[CompilerGenerated]
	private Label e;

	[CompilerGenerated]
	private Label f;

	[CompilerGenerated]
	private Label g;

	[CompilerGenerated]
	private Label h;

	[CompilerGenerated]
	private Label i;

	[CompilerGenerated]
	private Label j;

	[CompilerGenerated]
	private Label k;

	[CompilerGenerated]
	private Label l;

	[CompilerGenerated]
	private Label m;

	[CompilerGenerated]
	private GroupBox n;

	public OpenFileDialog o;

	public SaveFileDialog p;

	[CompilerGenerated]
	private Button q;

	[CompilerGenerated]
	private Button r;

	[CompilerGenerated]
	private Button s;

	[CompilerGenerated]
	private GroupBox t;

	[CompilerGenerated]
	private System.Windows.Forms.Timer u;

	[CompilerGenerated]
	private PrintDocument m_v;

	[CompilerGenerated]
	private PrintDialog m_w;

	[CompilerGenerated]
	private Panel x;

	[CompilerGenerated]
	private Button y;

	[CompilerGenerated]
	private Button m_z;

	[CompilerGenerated]
	private PictureBox aa;

	private const short m_ab = 5;

	private const float m_ac = 300f;

	private const float m_ad = 406f;

	private const float m_ae = 716f;

	private const float m_af = 506f;

	private const float m_ag = 716f;

	private const string m_ah = "Start";

	private const string m_ai = "Stop";

	private fz m_aj;

	private float m_ak;

	private float m_al;

	private float m_am;

	private float m_an;

	private e4 m_ao;

	private bool m_ap;

	private bool m_aq;

	private bool m_ar;

	private f5 m_as;

	private string m_at;

	private string m_au;

	private string m_av;

	private double m_aw;

	private bool m_ax;

	private string m_ay;

	[CompilerGenerated]
	private a m_az;

	[DebuggerNonUserCode]
	public f8(fz A_0)
	{
		base.Activated += ab;
		base.Deactivate += z;
		base.Resize += w;
		v();
		this.m_aj = A_0;
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool Disposing)
	{
		if (Disposing && this.m_a != null)
		{
			this.m_a.Dispose();
		}
		base.Dispose(Disposing);
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label w()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void v(Label A_0)
	{
		c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label z()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void w(Label A_0)
	{
		d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ab()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void z(Label A_0)
	{
		e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ac()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ab(Label A_0)
	{
		f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ad()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ac(Label A_0)
	{
		g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ae()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ad(Label A_0)
	{
		h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label af()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ae(Label A_0)
	{
		i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ag()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void af(Label A_0)
	{
		j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ah()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ag(Label A_0)
	{
		k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ai()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ah(Label A_0)
	{
		l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aj()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ai(Label A_0)
	{
		m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox ak()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void v(GroupBox A_0)
	{
		n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button al()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void v(Button A_0)
	{
		EventHandler value = ae;
		Button button = q;
		if (button != null)
		{
			button.Click -= value;
		}
		q = A_0;
		button = q;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button am()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void w(Button A_0)
	{
		EventHandler value = ad;
		Button button = r;
		if (button != null)
		{
			button.Click -= value;
		}
		r = A_0;
		button = r;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button an()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void z(Button A_0)
	{
		EventHandler value = ag;
		Button button = s;
		if (button != null)
		{
			button.Click -= value;
		}
		s = A_0;
		button = s;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox ao()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void w(GroupBox A_0)
	{
		t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual System.Windows.Forms.Timer ap()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void v(System.Windows.Forms.Timer A_0)
	{
		EventHandler value = v;
		System.Windows.Forms.Timer timer = u;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		u = A_0;
		timer = u;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	[DebuggerStepThrough]
	private void v()
	{
		this.m_a = new Container();
		b = new ToolTip(this.m_a);
		v(new GroupBox());
		v(new Label());
		w(new Label());
		z(new Label());
		ab(new Label());
		ac(new Label());
		ad(new Label());
		ae(new Label());
		af(new Label());
		ag(new Label());
		ah(new Label());
		ai(new Label());
		o = new OpenFileDialog();
		p = new SaveFileDialog();
		w(new GroupBox());
		v(new Button());
		w(new Button());
		z(new Button());
		v(new System.Windows.Forms.Timer(this.m_a));
		v(new PrintDocument());
		v(new PrintDialog());
		v(new Panel());
		ab(new Button());
		ac(new Button());
		v(new PictureBox());
		ak().SuspendLayout();
		ao().SuspendLayout();
		@as().SuspendLayout();
		((ISupportInitialize)av()).BeginInit();
		SuspendLayout();
		ak().BackColor = SystemColors.Control;
		ak().Controls.Add(w());
		ak().Controls.Add(z());
		ak().Controls.Add(ab());
		ak().Controls.Add(ac());
		ak().Controls.Add(ad());
		ak().Controls.Add(ae());
		ak().Controls.Add(af());
		ak().Controls.Add(ag());
		ak().Controls.Add(ah());
		ak().Controls.Add(ai());
		ak().Controls.Add(aj());
		ak().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ak().ForeColor = SystemColors.ControlText;
		ak().Location = new Point(4, 418);
		ak().Name = "fmeTemplateLegend";
		ak().RightToLeft = RightToLeft.No;
		ak().Size = new Size(165, 90);
		ak().TabIndex = 7;
		ak().TabStop = false;
		ak().Text = "Measurement Legend";
		w().BackColor = SystemColors.WindowText;
		w().Location = new Point(0, 495);
		w().Name = "Line1";
		w().Size = new Size(2445, 1);
		w().TabIndex = 0;
		z().BackColor = SystemColors.Control;
		z().Cursor = Cursors.Default;
		z().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		z().ForeColor = SystemColors.ControlText;
		z().Location = new Point(50, 71);
		z().Name = "Label8";
		z().RightToLeft = RightToLeft.No;
		z().Size = new Size(93, 13);
		z().TabIndex = 15;
		z().Text = "- GOF Violation";
		ab().BackColor = SystemColors.Control;
		ab().Cursor = Cursors.Default;
		ab().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ab().ForeColor = SystemColors.ControlText;
		ab().Location = new Point(51, 53);
		ab().Name = "Label7";
		ab().RightToLeft = RightToLeft.No;
		ab().Size = new Size(98, 14);
		ab().TabIndex = 14;
		ab().Text = "- Bad Thickness";
		ac().BackColor = SystemColors.Control;
		ac().Cursor = Cursors.Default;
		ac().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ac().ForeColor = SystemColors.ControlText;
		ac().Location = new Point(51, 35);
		ac().Name = "Label6";
		ac().RightToLeft = RightToLeft.No;
		ac().Size = new Size(106, 17);
		ac().TabIndex = 13;
		ac().Text = "- Good Thickness";
		ad().BackColor = SystemColors.Control;
		ad().Cursor = Cursors.Default;
		ad().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ad().ForeColor = SystemColors.ControlText;
		ad().Location = new Point(5, 35);
		ad().Name = "Label5";
		ad().RightToLeft = RightToLeft.No;
		ad().Size = new Size(48, 16);
		ad().TabIndex = 12;
		ad().Text = "xxx.xx";
		ae().BackColor = SystemColors.Control;
		ae().Cursor = Cursors.Default;
		ae().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae().ForeColor = SystemColors.ControlText;
		ae().Location = new Point(97, 16);
		ae().Name = "Label4";
		ae().RightToLeft = RightToLeft.No;
		ae().Size = new Size(49, 16);
		ae().TabIndex = 11;
		ae().Text = "Good";
		af().BackColor = SystemColors.Control;
		af().Cursor = Cursors.Default;
		af().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		af().ForeColor = SystemColors.ControlText;
		af().Location = new Point(38, 16);
		af().Name = "Label3";
		af().RightToLeft = RightToLeft.No;
		af().Size = new Size(42, 15);
		af().TabIndex = 10;
		af().Text = "Bad";
		ag().BackColor = SystemColors.Control;
		ag().Cursor = Cursors.Default;
		ag().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ag().ForeColor = SystemColors.ControlText;
		ag().Location = new Point(5, 71);
		ag().Name = "Label2";
		ag().RightToLeft = RightToLeft.No;
		ag().Size = new Size(49, 17);
		ag().TabIndex = 9;
		ag().Text = "Invalid";
		ah().BackColor = SystemColors.Control;
		ah().Cursor = Cursors.Default;
		ah().Font = new Font("Arial", 9.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
		ah().ForeColor = SystemColors.ControlText;
		ah().Location = new Point(5, 53);
		ah().Name = "Label1";
		ah().RightToLeft = RightToLeft.No;
		ah().Size = new Size(45, 18);
		ah().TabIndex = 8;
		ah().Text = "xxx.xx";
		ai().BackColor = Color.Lime;
		ai().BorderStyle = BorderStyle.FixedSingle;
		ai().ForeColor = Color.Black;
		ai().Location = new Point(83, 19);
		ai().Name = "Shape2";
		ai().Size = new Size(9, 9);
		ai().TabIndex = 16;
		ai().Text = "Shape2";
		aj().BackColor = Color.Red;
		aj().BorderStyle = BorderStyle.FixedSingle;
		aj().ForeColor = Color.Black;
		aj().Location = new Point(22, 19);
		aj().Name = "Shape1";
		aj().Size = new Size(9, 9);
		aj().TabIndex = 17;
		aj().Text = "Shape1";
		ao().BackColor = SystemColors.Control;
		ao().Controls.Add(al());
		ao().Controls.Add(am());
		ao().Controls.Add(an());
		ao().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ao().ForeColor = SystemColors.ControlText;
		ao().Location = new Point(371, 418);
		ao().Name = "fmeMeasCommands";
		ao().RightToLeft = RightToLeft.No;
		ao().Size = new Size(163, 90);
		ao().TabIndex = 3;
		ao().TabStop = false;
		ao().Text = "All Measurements";
		al().Cursor = Cursors.Default;
		al().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		al().ForeColor = SystemColors.ControlText;
		al().Location = new Point(83, 19);
		al().Name = "cmdPrintMeasure";
		al().RightToLeft = RightToLeft.No;
		al().Size = new Size(74, 30);
		al().TabIndex = 6;
		al().Text = "Print";
		am().Cursor = Cursors.Default;
		am().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		am().ForeColor = SystemColors.ControlText;
		am().Location = new Point(7, 53);
		am().Name = "cmdSaveMeasure";
		am().RightToLeft = RightToLeft.No;
		am().Size = new Size(150, 30);
		am().TabIndex = 5;
		am().Text = "Save To File";
		an().Cursor = Cursors.Default;
		an().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		an().ForeColor = SystemColors.ControlText;
		an().Location = new Point(7, 19);
		an().Name = "cmdAcceptMeasure";
		an().RightToLeft = RightToLeft.No;
		an().Size = new Size(74, 30);
		an().TabIndex = 4;
		an().Text = "Accept";
		ap().Interval = 250;
		ar().Document = aq();
		ar().UseEXDialog = true;
		@as().Controls.Add(at());
		@as().Controls.Add(au());
		@as().Location = new Point(540, 418);
		@as().Name = "PanelCMDs";
		@as().Size = new Size(174, 88);
		@as().TabIndex = 8;
		at().Cursor = Cursors.Default;
		at().DialogResult = DialogResult.Cancel;
		at().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		at().ForeColor = SystemColors.ControlText;
		at().Location = new Point(91, 34);
		at().Name = "cmdCloseTemplate";
		at().RightToLeft = RightToLeft.No;
		at().Size = new Size(73, 30);
		at().TabIndex = 4;
		at().Text = "Cancel";
		au().Cursor = Cursors.Default;
		au().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		au().ForeColor = SystemColors.ControlText;
		au().Location = new Point(12, 34);
		au().Name = "cmdUndo";
		au().RightToLeft = RightToLeft.No;
		au().Size = new Size(73, 30);
		au().TabIndex = 3;
		au().Text = "Undo";
		av().Location = new Point(0, 0);
		av().Name = "picTemplate";
		av().Size = new Size(724, 406);
		av().TabIndex = 9;
		av().TabStop = false;
		base.AcceptButton = an();
		base.AutoScaleDimensions = new SizeF(6f, 14f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		AutoValidate = AutoValidate.Disable;
		BackColor = SystemColors.Control;
		BackgroundImageLayout = ImageLayout.None;
		base.CancelButton = at();
		base.ClientSize = new Size(716, 511);
		base.ControlBox = false;
		base.Controls.Add(av());
		base.Controls.Add(@as());
		base.Controls.Add(ak());
		base.Controls.Add(ao());
		Cursor = Cursors.Default;
		DoubleBuffered = true;
		Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Location = new Point(4, 30);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogMeasTemplate";
		RightToLeft = RightToLeft.No;
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Show;
		ak().ResumeLayout(performLayout: false);
		ao().ResumeLayout(performLayout: false);
		@as().ResumeLayout(performLayout: false);
		((ISupportInitialize)av()).EndInit();
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PrintDocument aq()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(PrintDocument A_0)
	{
		PrintPageEventHandler value = v;
		PrintDocument printDocument = this.m_v;
		if (printDocument != null)
		{
			printDocument.PrintPage -= value;
		}
		this.m_v = A_0;
		printDocument = this.m_v;
		if (printDocument != null)
		{
			printDocument.PrintPage += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PrintDialog ar()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(PrintDialog A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel @as()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(Panel A_0)
	{
		x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button at()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ab(Button A_0)
	{
		EventHandler value = af;
		Button button = y;
		if (button != null)
		{
			button.Click -= value;
		}
		y = A_0;
		button = y;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button au()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ac(Button A_0)
	{
		EventHandler value = ac;
		Button button = this.m_z;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_z = A_0;
		button = this.m_z;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox av()
	{
		return aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(PictureBox A_0)
	{
		PaintEventHandler value = v;
		PictureBox pictureBox = aa;
		if (pictureBox != null)
		{
			pictureBox.Paint -= value;
		}
		aa = A_0;
		pictureBox = aa;
		if (pictureBox != null)
		{
			pictureBox.Paint += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public void v(a A_0)
	{
		a a10 = this.m_az;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Combine(a11, A_0);
			a10 = Interlocked.CompareExchange(ref this.m_az, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void w(a A_0)
	{
		a a10 = this.m_az;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Remove(a11, A_0);
			a10 = Interlocked.CompareExchange(ref this.m_az, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	public void v(bool A_0)
	{
		this.m_aq = A_0;
	}

	public bool v(string A_0, string A_1, int A_2, bool A_3, Point A_4, int A_5, int A_6, bool A_7, int A_8, int A_9, bool A_10)
	{
		string A_11 = "";
		if (this.m_ao == null)
		{
			this.m_ao = new e4(this.m_aj, av().CreateGraphics(), e4.b.b);
		}
		checked
		{
			float A_12 = default(float);
			double A_13 = default(double);
			if (this.m_ao.a(A_0, A_1: false, ref A_12, ref A_12, ref A_12, ref A_12, ref A_11, ref A_11, ref A_13))
			{
				Text = Path.GetFileNameWithoutExtension(this.m_ao.ab());
				if (A_7)
				{
					this.m_ao.ab((short)A_8);
					this.m_ao.ac((short)A_9);
					this.m_ao.af(this.m_ao.ac());
					this.m_ao.ab(A_10);
				}
				else
				{
					this.m_ao.aa((short)A_2);
					this.m_ao.b(A_3);
					this.m_ao.ae(this.m_ao.ac());
				}
				this.m_aw = DateAndTime.Now.ToOADate();
				this.m_au = Path.GetFileNameWithoutExtension(this.m_ao.ab());
				this.m_av = A_1;
				this.m_ay = A_0.Substring(e4.aa().Length + 1);
				Show();
				base.Left = A_4.X;
				base.Top = A_4.Y;
				base.Height = A_6;
				base.Width = A_5;
				ap().Enabled = true;
				return true;
			}
			return false;
		}
	}

	public bool v(string A_0)
	{
		checked
		{
			bool result;
			try
			{
				if (this.m_ao == null)
				{
					this.m_ao = new e4(this.m_aj, av().CreateGraphics(), e4.b.b);
				}
				float A_1 = default(float);
				float A_2 = default(float);
				float A_3 = default(float);
				float A_4 = default(float);
				if (!this.m_ao.a(A_0, A_1: true, ref A_1, ref A_2, ref A_3, ref A_4, ref this.m_au, ref this.m_av, ref this.m_aw))
				{
					result = false;
				}
				else
				{
					this.m_ar = true;
					this.m_at = Path.GetFileNameWithoutExtension(A_0);
					Text = this.m_au + " - " + this.m_at;
					this.m_at += ".fmtpm";
					base.Left = (int)Math.Round(A_1);
					base.Top = (int)Math.Round(A_2);
					base.Width = (int)Math.Round(A_4);
					base.Height = (int)Math.Round(A_3);
					ao().Visible = false;
					au().Text = "Print";
					at().Text = "Close";
					this.m_ay = A_0.Substring(e4.aa().Length + 1);
					ShowDialog();
					result = true;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	private void ag(object A_0, EventArgs A_1)
	{
		this.m_aq = true;
		az();
	}

	private void af(object A_0, EventArgs A_1)
	{
		checked
		{
			if (this.m_ar)
			{
				this.m_at = "";
				Close();
			}
			else if (this.m_ao.ad() > 0)
			{
				if (fe.b(ref this.m_aj, "Confirm close template and delete all measurements?", "ExitingTemplateString", "OKString", "CancelString", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2))))
				{
					this.m_aq = true;
					az();
				}
			}
			else
			{
				this.m_aq = true;
				az();
			}
		}
	}

	private void ae(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_ax = true;
			if (ar().ShowDialog() == DialogResult.OK)
			{
				aq().Print();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			Interaction.MsgBox("Error Printing Template.");
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.m_ax = false;
		}
	}

	private void ad(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				this.m_ax = true;
				p.OverwritePrompt = true;
				o.ShowReadOnly = false;
				o.Filter = "Template Files (.fmtpm)|*.fmtpm";
				p.Filter = "Template Files (.fmtpm)|*.fmtpm";
				o.InitialDirectory = e4.aa();
				p.InitialDirectory = e4.aa();
				if (p.ShowDialog() == DialogResult.OK)
				{
					o.FileName = p.FileName;
					if (!this.m_ao.a(p.FileName, A_1: true, base.ClientRectangle.Left, base.ClientRectangle.Top, base.ClientRectangle.Height, base.ClientRectangle.Width, this.m_aw))
					{
						ref fz a_ = ref this.m_aj;
						Point A_2 = i6.a(this);
						fe.b(ref a_, "Error while attempting to save file. Please try again.", ref A_2);
					}
				}
				v(default(Rectangle));
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				string a_2 = "Error in FrmMeasTemplate cmdSaveMeasure_Click at location \r\nError is " + Information.Err().Description + ", " + DateAndTime.Now.ToString();
				fe.b(this.m_aj, a_2, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
			finally
			{
				this.m_ax = false;
			}
		}
	}

	private void ac(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (Operators.CompareString(au().Text, "Undo", TextCompare: false) == 0)
				{
					this.m_ao.ax();
				}
				else
				{
					ae(RuntimeHelpers.GetObjectValue(A_0), A_1);
				}
				v(default(Rectangle));
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				fe.b(this.m_aj, "Error attempting cmdUndo_Click.", "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ab(object A_0, EventArgs A_1)
	{
		v(default(Rectangle));
	}

	private void z(object A_0, EventArgs A_1)
	{
		if (!fe.m & !this.m_ax)
		{
			Hide();
			Show();
		}
	}

	private void w(object A_0, EventArgs A_1)
	{
		if (this.m_ao != null)
		{
			if (this.m_ao.al())
			{
				this.m_am = 1f;
				this.m_an = 1f;
			}
			else
			{
				this.m_am = (float)base.ClientRectangle.Width / 716f;
				this.m_an = (float)(((double)base.ClientRectangle.Height - (double)ak().Height / 2.0) / 506.0);
			}
			v(default(Rectangle));
		}
	}

	public void v(Rectangle A_0)
	{
		checked
		{
			@as().Top = (int)Math.Round((double)(base.ClientRectangle.Height - @as().Height) - 2.5);
			ao().Top = @as().Top;
			ak().Top = ao().Top;
			av().Height = base.ClientRectangle.Height - @as().Height - 5;
			@as().Left = base.ClientRectangle.Width - @as().Width - 10;
			ao().Left = @as().Left - ao().Width - 10;
			ak().Left = 5;
			av().Width = base.ClientRectangle.Width;
			if (this.m_ao.ad() > 0)
			{
				au().Enabled = true;
				if (this.m_ao.ak())
				{
					ak().Visible = true;
				}
			}
			else
			{
				au().Enabled = false;
				ak().Visible = false;
			}
			if (this.m_ao.ad() >= this.m_ao.ac())
			{
				an().Enabled = true;
				am().Enabled = true;
				al().Enabled = true;
			}
			else
			{
				an().Enabled = false;
				am().Enabled = false;
				al().Enabled = false;
			}
			av().Invalidate();
		}
	}

	public void v(hc A_0, bool A_1, bool A_2, eo.a A_3, bool A_4)
	{
		this.m_ao.a(A_0, A_1, A_2, A_3, A_4);
		v(default(Rectangle));
	}

	public short aw()
	{
		return this.m_ao.ad();
	}

	public short ax()
	{
		return this.m_ao.ac();
	}

	public bool ay()
	{
		return this.m_ao.ai();
	}

	public void az()
	{
		checked
		{
			try
			{
				ap().Enabled = false;
				this.m_az?.Invoke(base.Left, base.Top, base.Width, base.Height);
				Close();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				fe.b(this.m_aj, "Error attempting to exit the Meas Template form.", "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void v(object A_0, EventArgs A_1)
	{
		this.m_ao.ac(av().CreateGraphics());
	}

	~f8()
	{
		base.Finalize();
	}

	private void v(object A_0, PaintEventArgs A_1)
	{
		this.m_ao.a(A_1.Graphics, this.m_am, this.m_an, e4.c.a);
	}

	private void w(PrintPageEventArgs A_0)
	{
		string[] array = new string[6] { "Mean", "Median", "Std. Dev", "Min", "Max", "Range" };
		Font font = new Font("Verdana", 16f, FontStyle.Bold);
		Font font2 = new Font("Arial", 11f, FontStyle.Regular);
		new Font("Arial", 10f, FontStyle.Regular);
		new Font("Arial", 10f, FontStyle.Bold);
		Font font3 = new Font("Arial", 9f, FontStyle.Bold);
		Font font4 = new Font("Arial", 9f, FontStyle.Regular);
		Font font5 = new Font("Arial", 9f, FontStyle.Italic);
		new Font("Arial", 9f, FontStyle.Regular);
		new Font("Arial", 9f, FontStyle.Bold);
		Font font6 = new Font("Arial", 11f, FontStyle.Bold);
		ew.a a10 = this.m_ao.ar();
		Bitmap bitmap = i5.a(this.m_ao.ar());
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(this.m_ao.ae());
		string text = this.m_ao.av();
		DateTime dateTime = DateTime.FromOADate(this.m_ao.ag());
		DateTime dateTime2 = DateTime.FromOADate(this.m_ao.aw());
		h4 h10 = this.m_ao.an();
		string text2 = h4.e(h10, false, false);
		PageSettings defaultPageSettings = aq().DefaultPageSettings;
		checked
		{
			int num = (int)Math.Round(defaultPageSettings.PrintableArea.Height);
			int num2 = (int)Math.Round(defaultPageSettings.PrintableArea.Width);
			if (defaultPageSettings.Landscape)
			{
				int num3 = num;
				num = num2;
				num2 = num3;
			}
			_ = null;
			string[] array2 = new string[6];
			float num4 = 20f;
			float num5 = 200f;
			A_0.Graphics.Clear(Color.White);
			int num6 = default(int);
			int num7 = default(int);
			switch (a10)
			{
			case ew.a.a:
				num6 = 5;
				num7 = 0;
				break;
			case ew.a.b:
				num6 = 17;
				num7 = 5;
				break;
			case ew.a.c:
				num6 = 5;
				num7 = 0;
				break;
			}
			float num8 = 0f;
			float num9 = (float)((double)num4 * 0.7);
			A_0.Graphics.DrawString("Measurement Report", font, Brushes.Black, num8, num9 + (float)num7);
			A_0.Graphics.DrawImage(bitmap, (float)num2 - 5f - (float)bitmap.Width, num9 - (float)num6 + (float)num7);
			num9 += (float)font.Height + (float)((double)num4 * 0.5) + (float)num6 + (float)num7;
			A_0.Graphics.DrawLine(Pens.Black, 0f, num9, (float)num2 - 5f, num9);
			num9 += num4 * 0.3f;
			num8 = (float)((double)num4 * 1.5);
			A_0.Graphics.DrawString("System Type: ", font2, Brushes.Black, num8, num9);
			A_0.Graphics.DrawString(text, font2, Brushes.Black, num5, num9);
			num9 += (float)font2.Height + num4 * 0.3f;
			num8 = (float)((double)num4 * 1.5);
			A_0.Graphics.DrawString("FileName: ", font2, Brushes.Black, num8, num9);
			A_0.Graphics.DrawString(this.m_ay, font2, Brushes.Black, num5, num9);
			num9 += (float)font2.Height + num4 * 0.3f;
			num8 = (float)((double)num4 * 1.5);
			A_0.Graphics.DrawString("Operator ID: ", font2, Brushes.Black, num8, num9);
			A_0.Graphics.DrawString(this.m_ao.af(), font2, Brushes.Black, num5, num9);
			num9 += (float)font2.Height + num4 * 0.3f;
			num8 = (float)((double)num4 * 1.5);
			A_0.Graphics.DrawString("Template Name: ", font2, Brushes.Black, num8, num9);
			A_0.Graphics.DrawString(Path.GetFileNameWithoutExtension(this.m_ao.ab()), font2, Brushes.Black, num5, num9);
			num9 += (float)font2.Height + num4 * 0.3f;
			num8 = (float)((double)num4 * 1.5);
			A_0.Graphics.DrawString("Template Date: ", font2, Brushes.Black, num8, num9);
			A_0.Graphics.DrawString(Strings.Format(dateTime, "General Date"), font2, Brushes.Black, num5, num9);
			num9 += (float)font2.Height + num4 * 0.3f;
			num8 = (float)((double)num4 * 1.5);
			A_0.Graphics.DrawString("Recipe Name: ", font2, Brushes.Black, num8, num9);
			A_0.Graphics.DrawString(fileNameWithoutExtension, font2, Brushes.Black, num5, num9);
			num9 += (float)font2.Height + num4 * 0.3f;
			num8 = (float)((double)num4 * 1.5);
			A_0.Graphics.DrawString("Measurement Date: ", font2, Brushes.Black, num8, num9);
			A_0.Graphics.DrawString(Strings.Format(dateTime2, "General Date"), font2, Brushes.Black, num5, num9);
			num9 += (float)font2.Height + num4 * 0.3f;
			A_0.Graphics.DrawLine(Pens.Black, 0f, (int)Math.Round(num9), (float)num2 - 5f, (int)Math.Round(num9));
			array2 = ((this.m_ao.aj() <= 5) ? new string[this.m_ao.aj() + 1 + 1] : new string[6]);
			int num10 = default(int);
			array2[num10] = "Meas. Data";
			num10 = 1;
			float[] A_1 = new float[this.m_ao.aj() - 1 + 1];
			int[] array3 = new int[4];
			e4 obj = this.m_ao;
			short A_2 = 0;
			obj.a(ref A_2, ref A_1, this.m_ao.aj());
			int num11 = this.m_ao.aj() - 1;
			int num13 = default(int);
			for (int num12 = 0; num12 <= num11; num12++)
			{
				if ((A_1[num12] != 0f) & (num10 < 5))
				{
					array2[num10] = "Layer " + Conversions.ToString(num12 + 1);
					num10++;
					array3[num13] = num12;
					num13++;
				}
			}
			array3 = (int[])Utils.CopyArray(array3, new int[num13 - 1 + 1]);
			array2[num10] = "GOF";
			num10++;
			Rectangle rect = new Rectangle
			{
				Width = (short)Math.Round((double)num2 / 6.0),
				Height = 20
			};
			float num14 = (float)((double)(num2 - rect.Width * num10) * 0.5);
			float num15 = (int)Math.Round((double)num9 + (double)num4 * 0.5);
			int num16 = num10 - 1;
			for (int num17 = 0; num17 <= num16; num17++)
			{
				string text3 = ((!((num17 > 0) & (num17 < num10 - 1))) ? array2[num17] : (array2[num17] + " (" + text2 + ")"));
				rect.X = (int)Math.Round(num14 + (float)(num17 * rect.Width));
				rect.Y = (int)Math.Round(num15);
				A_0.Graphics.DrawRectangle(Pens.Black, rect);
				num8 = (float)((double)rect.X + (double)((float)rect.Width - A_0.Graphics.MeasureString(array2[num17], font3).Width) * 0.5);
				num9 = (float)((double)rect.Y + (double)((float)rect.Height - A_0.Graphics.MeasureString(array2[num17], font3).Height) * 0.5);
				A_0.Graphics.DrawString(text3, font3, Brushes.Black, num8, num9);
			}
			num15 = (float)((double)num9 + (double)num4 * 0.5);
			float[,] array4 = new float[num13 - 1 + 1, 6];
			float[] array5 = new float[6];
			v(array4, this.m_ao, num13, array3, array5);
			num15 = num9 + (float)rect.Height;
			int num18 = 0;
			bool flag = default(bool);
			do
			{
				float num19 = (int)Math.Round(num15 + (float)(num18 * rect.Height));
				rect.Y = (int)Math.Round(num15 + (float)(num18 * rect.Height));
				int num20 = num10 - 1;
				for (int num17 = 0; num17 <= num20; num17++)
				{
					Font font7 = font4;
					float num21 = (int)Math.Round(num14 + (float)(num17 * rect.Width));
					rect.X = (int)Math.Round(num14 + (float)(num17 * rect.Width));
					if (num17 == 0)
					{
						A_0.Graphics.DrawRectangle(Pens.Black, rect);
						num8 = (float)((double)num21 + (double)((float)rect.Width - A_0.Graphics.MeasureString(array[num18], font7).Width) * 0.5);
						num9 = (float)((double)num19 + (double)((float)rect.Height - A_0.Graphics.MeasureString(array[num18], font7).Height) * 0.5);
						A_0.Graphics.DrawString(array[num18], font7, Brushes.Black, num8, num9);
						continue;
					}
					string text3;
					if (num17 == num10 - 1)
					{
						text3 = hg.bu(hg.o.c, h10, array5[num18], 2, new h4(h4.a.b), 0);
						A_0.Graphics.DrawRectangle(Pens.Black, rect);
						num8 = (float)((double)num21 + (double)((float)rect.Width - A_0.Graphics.MeasureString(Conversions.ToString(text3[num17]), font7).Width) * 0.5);
						num9 = (float)((double)num19 + (double)((float)rect.Height - A_0.Graphics.MeasureString(Conversions.ToString(text3[num17]), font7).Height) * 0.5);
						A_0.Graphics.DrawString(text3, font7, Brushes.Black, num8, num9);
						continue;
					}
					text3 = hg.bu(hg.o.c, h10, array4[num17 - 1, num18], 2, new h4(h4.a.b), 0);
					if (flag)
					{
						text3 = "";
					}
					A_0.Graphics.DrawRectangle(Pens.Black, rect);
					num8 = (float)((double)num21 + (double)((float)rect.Width - A_0.Graphics.MeasureString(Conversions.ToString(text3[num17]), font7).Width) * 0.5);
					num9 = (float)((double)num19 + (double)((float)rect.Height - A_0.Graphics.MeasureString(Conversions.ToString(text3[num17]), font7).Height) * 0.5);
					A_0.Graphics.DrawString(text3, font7, Brushes.Black, num8, num9);
				}
				num18++;
			}
			while (num18 <= 5);
			int num22 = (this.m_ao.ak() ? 3 : 0);
			num8 = (int)Math.Round((double)num4 * 1.5);
			float a_ = (float)((double)num2 / (double)base.ClientRectangle.Width);
			float a_2 = ((float)num - num9 - num4 * (float)num22) / (float)base.ClientRectangle.Height;
			this.m_ao.a(num9);
			this.m_ao.b(num);
			this.m_ao.a(num2);
			this.m_ao.a(A_0.Graphics, a_, a_2, e4.c.c);
			if (this.m_ao.ak())
			{
				num9 = (float)num - num4 * (float)num22;
				A_0.Graphics.DrawLine(Pens.Black, 0f, (float)((double)num9 + (double)num4 * 0.5), (float)num2 - 5f, (float)((double)num9 + (double)num4 * 0.5));
				num8 = (int)Math.Round((double)num4 * 1.5);
				num9 += num4 * 0.3f;
				Font font7 = font6;
				A_0.Graphics.DrawString("Measurement Legend", font7, Brushes.Black, num8, num9 + 8f);
				num8 = (int)Math.Round((double)num4 * 1.25);
				num9 += (float)(int)Math.Round((double)num4 * 1.5);
				A_0.Graphics.FillEllipse(Brushes.Green, new Rectangle((int)Math.Round(num8 + num4), (int)Math.Round(num9 + 3f), 8, 8));
				num8 += num4;
				A_0.Graphics.DrawString("  - Good;", font4, Brushes.Black, num8, num9);
				num8 += A_0.Graphics.MeasureString("  - Good;", font4).Width + num4;
				A_0.Graphics.FillEllipse(Brushes.Red, new Rectangle((int)Math.Round(num8 + num4), (int)Math.Round(num9 + 3f), 8, 8));
				num8 += num4;
				A_0.Graphics.DrawString("  - Bad;", font4, Brushes.Black, num8, num9);
				num8 += A_0.Graphics.MeasureString("  - Bad;", font4).Width + num4;
				A_0.Graphics.DrawString("xxx.xx", font3, Brushes.Black, num8, num9);
				num8 += A_0.Graphics.MeasureString("xxx.xx", font3).Width;
				A_0.Graphics.DrawString(" - Good Thickness;", font4, Brushes.Black, num8, num9);
				num8 += A_0.Graphics.MeasureString(" - Good Thickness;", font3).Width + num4;
				A_0.Graphics.DrawString("xxx.xx", font5, Brushes.Black, num8, num9);
				num8 += A_0.Graphics.MeasureString("xxx.xx", font3).Width;
				A_0.Graphics.DrawString(" - Bad Thickness;", font4, Brushes.Black, num8, num9);
				num8 += A_0.Graphics.MeasureString(" - Bad Thickness;", font3).Width + num4;
				A_0.Graphics.DrawString("Invalid - GOF Violation", font4, Brushes.Black, num8, num9);
			}
			A_0.HasMorePages = false;
		}
	}

	private void v(float[,] A_0, e4 A_1, int A_2, int[] A_3, float[] A_4)
	{
		float[] A_5 = null;
		checked
		{
			int num = A_2 - 1;
			short A_6 = default(short);
			for (int num2 = 0; num2 <= num; num2++)
			{
				A_1.a((short)A_3[num2], ref A_5, ref A_6);
				if (A_6 > 0)
				{
					A_0[num2, 0] = jf.b(A_5, A_6);
					A_0[num2, 1] = jf.a(ref A_5, A_6);
					A_0[num2, 2] = (float)jf.a(ref A_5, A_6, A_0[num2, 0]);
					A_0[num2, 3] = jf.a(A_5, A_6);
					A_0[num2, 4] = jf.c(A_5, A_6);
					A_0[num2, 5] = A_0[num2, 4] - A_0[num2, 3];
				}
				else
				{
					A_0[num2, 0] = -1f;
					A_0[num2, 1] = -1f;
					A_0[num2, 2] = -1f;
					A_0[num2, 3] = -1f;
					A_0[num2, 4] = -1f;
					A_0[num2, 5] = -1f;
				}
			}
			A_6 = A_1.ac();
			A_5 = new float[A_6 - 1 + 1];
			int num3 = A_6 - 1;
			for (int num2 = 0; num2 <= num3; num2++)
			{
				A_5[num2] = A_1.aa(num2);
			}
			A_4[0] = jf.b(A_5, A_6);
			A_4[1] = jf.a(ref A_5, A_6);
			A_4[2] = (float)jf.a(ref A_5, A_6, A_4[0]);
			A_4[3] = jf.a(A_5, A_6);
			A_4[4] = jf.c(A_5, A_6);
			A_4[5] = A_4[4] - A_4[3];
		}
	}

	private void v(PrintPageEventArgs A_0)
	{
	}

	private void v(object A_0, PrintPageEventArgs A_1)
	{
		try
		{
			if (this.m_ao.@as())
			{
				v(A_1);
			}
			else
			{
				w(A_1);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			A_1.Cancel = true;
			this.m_aj.c(fz.b.b, "Error in DialogMeasTemplate PrintDocument1_PrintPage.", a_);
			ProjectData.ClearProjectError();
		}
	}
}
