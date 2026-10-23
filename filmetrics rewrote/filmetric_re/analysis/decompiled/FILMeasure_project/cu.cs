using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class cu : Form
{
	private IContainer a;

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
	private GroupBox j;

	[CompilerGenerated]
	private Button k;

	[CompilerGenerated]
	private TextBox l;

	[CompilerGenerated]
	private CheckBox m;

	[CompilerGenerated]
	private Label n;

	[CompilerGenerated]
	private Label o;

	[CompilerGenerated]
	private Label p;

	[CompilerGenerated]
	private Label q;

	[CompilerGenerated]
	private Label r;

	[CompilerGenerated]
	private Label s;

	[CompilerGenerated]
	private Label t;

	[CompilerGenerated]
	private Label u;

	[CompilerGenerated]
	private GroupBox v;

	[CompilerGenerated]
	private Button w;

	[CompilerGenerated]
	private Button x;

	[CompilerGenerated]
	private Button y;

	[CompilerGenerated]
	private Label z;

	[CompilerGenerated]
	private Label aa;

	[CompilerGenerated]
	private Label ab;

	[CompilerGenerated]
	private Label ac;

	[CompilerGenerated]
	private Label ad;

	[CompilerGenerated]
	private Label ae;

	[CompilerGenerated]
	private Label af;

	[CompilerGenerated]
	private Label ag;

	[CompilerGenerated]
	private GroupBox ah;

	[CompilerGenerated]
	private Button ai;

	[CompilerGenerated]
	private Button m_aj;

	[CompilerGenerated]
	private DataGridView ak;

	[CompilerGenerated]
	private Label m_al;

	[CompilerGenerated]
	private RadioButton m_am;

	[CompilerGenerated]
	private RadioButton m_an;

	[CompilerGenerated]
	private Label m_ao;

	[CompilerGenerated]
	private ComboBox m_ap;

	private const short m_aq = 167;

	private const short m_ar = 110;

	private const short m_as = 16;

	private const string m_at = "0.0000";

	private const short m_au = 10;

	private const short m_av = 0;

	private const short m_aw = 1;

	private short m_ax;

	private double[] m_ay;

	private double[] m_az;

	private short m_a0;

	private h4 m_a1;

	private int m_a2;

	private int m_a3;

	private bool m_a4;

	private fz m_a5;

	private hi m_a6;

	private List<iz.a> m_a7;

	private int m_a8;

	private int m_a9;

	private f1 m_ba;

	private object m_bb;

	private int m_bc;

	[DebuggerNonUserCode]
	public cu()
	{
		base.Activated += an;
		this.m_a7 = new List<iz.a>();
		am();
	}

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
	public virtual Label an()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aj(Label A_0)
	{
		c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ao()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void al(Label A_0)
	{
		d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ap()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void am(Label A_0)
	{
		e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aq()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void an(Label A_0)
	{
		f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ar()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ao(Label A_0)
	{
		g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label @as()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ap(Label A_0)
	{
		h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label at()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aq(Label A_0)
	{
		i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox au()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aj(GroupBox A_0)
	{
		j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button av()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aj(Button A_0)
	{
		EventHandler value = ap;
		Button button = k;
		if (button != null)
		{
			button.Click -= value;
		}
		k = A_0;
		button = k;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual TextBox aw()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aj(TextBox A_0)
	{
		l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox ax()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aj(CheckBox A_0)
	{
		EventHandler value = aj;
		CheckBox checkBox = m;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		m = A_0;
		checkBox = m;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ay()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ar(Label A_0)
	{
		n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label az()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void @as(Label A_0)
	{
		o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label a0()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void at(Label A_0)
	{
		p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label a1()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void au(Label A_0)
	{
		q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label a2()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void av(Label A_0)
	{
		r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label a3()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aw(Label A_0)
	{
		s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label a4()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ax(Label A_0)
	{
		t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label a5()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ay(Label A_0)
	{
		u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox a6()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void al(GroupBox A_0)
	{
		v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button a7()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void al(Button A_0)
	{
		EventHandler value = @as;
		Button button = w;
		if (button != null)
		{
			button.Click -= value;
		}
		w = A_0;
		button = w;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button a8()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void am(Button A_0)
	{
		EventHandler value = ao;
		Button button = x;
		if (button != null)
		{
			button.Click -= value;
		}
		x = A_0;
		button = x;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button a9()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void an(Button A_0)
	{
		EventHandler value = aq;
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
	public virtual Label ba()
	{
		return z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void az(Label A_0)
	{
		z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label bb()
	{
		return aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a0(Label A_0)
	{
		aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label bc()
	{
		return ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a1(Label A_0)
	{
		ab = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label bd()
	{
		return ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a2(Label A_0)
	{
		ac = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label be()
	{
		return ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a3(Label A_0)
	{
		ad = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label bf()
	{
		return ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a4(Label A_0)
	{
		ae = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label bg()
	{
		return af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a5(Label A_0)
	{
		af = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label bh()
	{
		return ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a6(Label A_0)
	{
		ag = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox bi()
	{
		return ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void am(GroupBox A_0)
	{
		ah = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button bj()
	{
		return ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ao(Button A_0)
	{
		ai = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button bk()
	{
		return this.m_aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ap(Button A_0)
	{
		EventHandler value = ar;
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

	[DebuggerStepThrough]
	private void am()
	{
		a = new Container();
		b = new ToolTip(a);
		aj(new GroupBox());
		a7(new Label());
		aj(new Label());
		al(new Label());
		am(new Label());
		an(new Label());
		ao(new Label());
		ap(new Label());
		aq(new Label());
		aj(new Button());
		aj(new TextBox());
		aj(new CheckBox());
		al(new GroupBox());
		aj(new ComboBox());
		a8(new Label());
		ar(new Label());
		@as(new Label());
		at(new Label());
		au(new Label());
		av(new Label());
		aw(new Label());
		ax(new Label());
		ay(new Label());
		al(new Button());
		am(new Button());
		am(new GroupBox());
		an(new Button());
		az(new Label());
		a0(new Label());
		a1(new Label());
		a2(new Label());
		a3(new Label());
		a4(new Label());
		a5(new Label());
		a6(new Label());
		ao(new Button());
		ap(new Button());
		aj(new DataGridView());
		aj(new RadioButton());
		al(new RadioButton());
		au().SuspendLayout();
		a6().SuspendLayout();
		bi().SuspendLayout();
		((ISupportInitialize)bl()).BeginInit();
		SuspendLayout();
		au().BackColor = SystemColors.Control;
		au().Controls.Add(bm());
		au().Controls.Add(an());
		au().Controls.Add(ao());
		au().Controls.Add(ap());
		au().Controls.Add(aq());
		au().Controls.Add(ar());
		au().Controls.Add(@as());
		au().Controls.Add(at());
		au().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		au().ForeColor = SystemColors.ControlText;
		au().Location = new Point(480, 179);
		au().Name = "Frame3";
		au().RightToLeft = RightToLeft.No;
		au().Size = new Size(224, 122);
		au().TabIndex = 29;
		au().TabStop = false;
		bm().BackColor = SystemColors.Control;
		bm().Cursor = Cursors.Default;
		bm().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bm().ForeColor = SystemColors.ControlText;
		bm().Location = new Point(125, 72);
		bm().Name = "Label14";
		bm().RightToLeft = RightToLeft.No;
		bm().Size = new Size(86, 17);
		bm().TabIndex = 39;
		bm().Text = "Coefficient B:";
		an().BackColor = SystemColors.Control;
		an().BorderStyle = BorderStyle.Fixed3D;
		an().Cursor = Cursors.Default;
		an().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		an().ForeColor = SystemColors.ControlText;
		an().Location = new Point(125, 90);
		an().Name = "lblgCurrentCoefB";
		an().RightToLeft = RightToLeft.No;
		an().Size = new Size(84, 18);
		an().TabIndex = 37;
		ao().BackColor = SystemColors.Control;
		ao().BorderStyle = BorderStyle.Fixed3D;
		ao().Cursor = Cursors.Default;
		ao().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ao().ForeColor = SystemColors.ControlText;
		ao().Location = new Point(15, 90);
		ao().Name = "lblgCurrentCoefA";
		ao().RightToLeft = RightToLeft.No;
		ao().Size = new Size(86, 18);
		ao().TabIndex = 36;
		ap().BackColor = SystemColors.Control;
		ap().Cursor = Cursors.Default;
		ap().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ap().ForeColor = SystemColors.ControlText;
		ap().Location = new Point(15, 72);
		ap().Name = "Label11";
		ap().RightToLeft = RightToLeft.No;
		ap().Size = new Size(86, 15);
		ap().TabIndex = 34;
		ap().Text = "Coefficient A:";
		aq().BackColor = SystemColors.Control;
		aq().BorderStyle = BorderStyle.Fixed3D;
		aq().Cursor = Cursors.Default;
		aq().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aq().ForeColor = SystemColors.ControlText;
		aq().Location = new Point(93, 48);
		aq().Name = "lblgCurrentMax";
		aq().RightToLeft = RightToLeft.No;
		aq().Size = new Size(105, 18);
		aq().TabIndex = 33;
		ar().BackColor = SystemColors.Control;
		ar().BorderStyle = BorderStyle.Fixed3D;
		ar().Cursor = Cursors.Default;
		ar().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ar().ForeColor = SystemColors.ControlText;
		ar().Location = new Point(94, 24);
		ar().Name = "lblgCurrentMin";
		ar().RightToLeft = RightToLeft.No;
		ar().Size = new Size(105, 18);
		ar().TabIndex = 32;
		@as().BackColor = SystemColors.Control;
		@as().Cursor = Cursors.Default;
		@as().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		@as().ForeColor = SystemColors.ControlText;
		@as().Location = new Point(13, 47);
		@as().Name = "Label8";
		@as().RightToLeft = RightToLeft.No;
		@as().Size = new Size(78, 17);
		@as().TabIndex = 31;
		@as().Text = "Meas. Max:";
		at().BackColor = SystemColors.Control;
		at().Cursor = Cursors.Default;
		at().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		at().ForeColor = SystemColors.ControlText;
		at().Location = new Point(14, 24);
		at().Name = "Label2";
		at().RightToLeft = RightToLeft.No;
		at().Size = new Size(73, 17);
		at().TabIndex = 30;
		at().Text = "Meas. Min:";
		av().BackColor = SystemColors.Control;
		av().Cursor = Cursors.Default;
		av().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		av().ForeColor = SystemColors.ControlText;
		av().Location = new Point(356, 71);
		av().Name = "btnDeleteGrid";
		av().RightToLeft = RightToLeft.No;
		av().Size = new Size(102, 27);
		av().TabIndex = 27;
		av().Text = "Delete Row";
		av().UseVisualStyleBackColor = false;
		aw().AcceptsReturn = true;
		aw().BackColor = SystemColors.Menu;
		aw().Cursor = Cursors.IBeam;
		aw().Enabled = false;
		aw().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		aw().ForeColor = SystemColors.WindowText;
		aw().Location = new Point(16, 8);
		aw().MaxLength = 0;
		aw().Multiline = true;
		aw().Name = "Text2";
		aw().RightToLeft = RightToLeft.No;
		aw().Size = new Size(439, 61);
		aw().TabIndex = 26;
		aw().Text = "          Target Thick. (Y) = Measured Thick. (X) * A + B\r\nUse various samples with significant difference in thickness for \r\nbetter coefficient calculation.\r\n";
		ax().AutoSize = true;
		ax().BackColor = SystemColors.Control;
		ax().Cursor = Cursors.Default;
		ax().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ax().ForeColor = SystemColors.ControlText;
		ax().Location = new Point(480, 8);
		ax().Name = "ckUseCorrCoef";
		ax().RightToLeft = RightToLeft.No;
		ax().Size = new Size(192, 20);
		ax().TabIndex = 25;
		ax().Text = "Use Correlative Coefficients";
		ax().UseVisualStyleBackColor = false;
		a6().BackColor = SystemColors.Control;
		a6().Controls.Add(bq());
		a6().Controls.Add(bp());
		a6().Controls.Add(ay());
		a6().Controls.Add(az());
		a6().Controls.Add(a0());
		a6().Controls.Add(a1());
		a6().Controls.Add(a2());
		a6().Controls.Add(a3());
		a6().Controls.Add(a4());
		a6().Controls.Add(a5());
		a6().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a6().ForeColor = SystemColors.ControlText;
		a6().Location = new Point(480, 32);
		a6().Name = "Frame2";
		a6().RightToLeft = RightToLeft.No;
		a6().Size = new Size(224, 139);
		a6().TabIndex = 16;
		a6().TabStop = false;
		bq().DropDownStyle = ComboBoxStyle.DropDownList;
		bq().Enabled = false;
		bq().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bq().FormattingEnabled = true;
		bq().Location = new Point(58, 20);
		bq().Name = "ComboLayers";
		bq().Size = new Size(160, 24);
		bq().TabIndex = 45;
		bp().AutoSize = true;
		bp().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bp().Location = new Point(6, 24);
		bp().Name = "Label1";
		bp().Size = new Size(55, 16);
		bp().TabIndex = 44;
		bp().Text = "Layers: ";
		ay().BackColor = SystemColors.Control;
		ay().BorderStyle = BorderStyle.Fixed3D;
		ay().Cursor = Cursors.Default;
		ay().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ay().ForeColor = SystemColors.ControlText;
		ay().Location = new Point(91, 49);
		ay().Name = "lblCurrentMin";
		ay().RightToLeft = RightToLeft.No;
		ay().Size = new Size(120, 18);
		ay().TabIndex = 24;
		az().BackColor = SystemColors.Control;
		az().BorderStyle = BorderStyle.Fixed3D;
		az().Cursor = Cursors.Default;
		az().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		az().ForeColor = SystemColors.ControlText;
		az().Location = new Point(91, 70);
		az().Name = "lblCurrentMax";
		az().RightToLeft = RightToLeft.No;
		az().Size = new Size(118, 18);
		az().TabIndex = 23;
		a0().BackColor = SystemColors.Control;
		a0().Cursor = Cursors.Default;
		a0().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a0().ForeColor = SystemColors.ControlText;
		a0().Location = new Point(13, 70);
		a0().Name = "Label12";
		a0().RightToLeft = RightToLeft.No;
		a0().Size = new Size(76, 17);
		a0().TabIndex = 22;
		a0().Text = "Meas. Max:";
		a1().BackColor = SystemColors.Control;
		a1().Cursor = Cursors.Default;
		a1().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a1().ForeColor = SystemColors.ControlText;
		a1().Location = new Point(13, 49);
		a1().Name = "Label10";
		a1().RightToLeft = RightToLeft.No;
		a1().Size = new Size(76, 17);
		a1().TabIndex = 21;
		a1().Text = "Meas. Min:";
		a2().BackColor = SystemColors.Control;
		a2().Cursor = Cursors.Default;
		a2().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a2().ForeColor = SystemColors.ControlText;
		a2().Location = new Point(16, 94);
		a2().Name = "Label9";
		a2().RightToLeft = RightToLeft.No;
		a2().Size = new Size(86, 15);
		a2().TabIndex = 20;
		a2().Text = "Coefficient A:";
		a3().BackColor = SystemColors.Control;
		a3().BorderStyle = BorderStyle.Fixed3D;
		a3().Cursor = Cursors.Default;
		a3().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a3().ForeColor = SystemColors.ControlText;
		a3().Location = new Point(15, 113);
		a3().Name = "lblCurrentCoefA";
		a3().RightToLeft = RightToLeft.No;
		a3().Size = new Size(87, 18);
		a3().TabIndex = 19;
		a4().BackColor = SystemColors.Control;
		a4().Cursor = Cursors.Default;
		a4().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a4().ForeColor = SystemColors.ControlText;
		a4().Location = new Point(125, 94);
		a4().Name = "Label4";
		a4().RightToLeft = RightToLeft.No;
		a4().Size = new Size(86, 17);
		a4().TabIndex = 18;
		a4().Text = "Coefficient B:";
		a5().BackColor = SystemColors.Control;
		a5().BorderStyle = BorderStyle.Fixed3D;
		a5().Cursor = Cursors.Default;
		a5().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a5().ForeColor = SystemColors.ControlText;
		a5().Location = new Point(125, 113);
		a5().Name = "lblCurrentCoefB";
		a5().RightToLeft = RightToLeft.No;
		a5().Size = new Size(91, 18);
		a5().TabIndex = 17;
		a7().BackColor = SystemColors.Control;
		a7().Cursor = Cursors.Default;
		a7().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a7().ForeColor = SystemColors.ControlText;
		a7().Location = new Point(248, 71);
		a7().Name = "btnAddGrid";
		a7().RightToLeft = RightToLeft.No;
		a7().Size = new Size(94, 27);
		a7().TabIndex = 6;
		a7().Text = "Add Row";
		a7().UseVisualStyleBackColor = false;
		a8().BackColor = SystemColors.Control;
		a8().Cursor = Cursors.Default;
		a8().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a8().ForeColor = SystemColors.ControlText;
		a8().Location = new Point(12, 72);
		a8().Name = "btnMeasThickness";
		a8().RightToLeft = RightToLeft.No;
		a8().Size = new Size(125, 27);
		a8().TabIndex = 5;
		a8().Text = "Measure Thickness (X)";
		a8().UseVisualStyleBackColor = false;
		a8().Visible = false;
		bi().BackColor = SystemColors.Control;
		bi().Controls.Add(a9());
		bi().Controls.Add(ba());
		bi().Controls.Add(bb());
		bi().Controls.Add(bc());
		bi().Controls.Add(bd());
		bi().Controls.Add(be());
		bi().Controls.Add(bf());
		bi().Controls.Add(bg());
		bi().Controls.Add(bh());
		bi().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bi().ForeColor = SystemColors.ControlText;
		bi().Location = new Point(480, 307);
		bi().Name = "Frame1";
		bi().RightToLeft = RightToLeft.No;
		bi().Size = new Size(224, 151);
		bi().TabIndex = 4;
		bi().TabStop = false;
		bi().Text = "Updated Correlative Coefficients";
		a9().BackColor = SystemColors.Control;
		a9().Cursor = Cursors.Default;
		a9().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a9().ForeColor = SystemColors.ControlText;
		a9().Location = new Point(22, 110);
		a9().Name = "btnCalcCoef";
		a9().RightToLeft = RightToLeft.No;
		a9().Size = new Size(180, 33);
		a9().TabIndex = 7;
		a9().Text = "Calculate Coefficients";
		a9().UseVisualStyleBackColor = false;
		ba().BackColor = SystemColors.Control;
		ba().BorderStyle = BorderStyle.Fixed3D;
		ba().Cursor = Cursors.Default;
		ba().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ba().ForeColor = SystemColors.ControlText;
		ba().Location = new Point(93, 44);
		ba().Name = "lblCalcThickMax";
		ba().RightToLeft = RightToLeft.No;
		ba().Size = new Size(105, 18);
		ba().TabIndex = 15;
		ba().Text = "0";
		bb().BackColor = SystemColors.Control;
		bb().Cursor = Cursors.Default;
		bb().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bb().ForeColor = SystemColors.ControlText;
		bb().Location = new Point(15, 42);
		bb().Name = "Label6";
		bb().RightToLeft = RightToLeft.No;
		bb().Size = new Size(78, 17);
		bb().TabIndex = 14;
		bb().Text = "Meas. Max:";
		bc().BackColor = SystemColors.Control;
		bc().BorderStyle = BorderStyle.Fixed3D;
		bc().Cursor = Cursors.Default;
		bc().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bc().ForeColor = SystemColors.ControlText;
		bc().Location = new Point(94, 22);
		bc().Name = "lblCalcThickMin";
		bc().RightToLeft = RightToLeft.No;
		bc().Size = new Size(105, 18);
		bc().TabIndex = 13;
		bc().Text = "9999999";
		bd().BackColor = SystemColors.Control;
		bd().Cursor = Cursors.Default;
		bd().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bd().ForeColor = SystemColors.ControlText;
		bd().Location = new Point(16, 22);
		bd().Name = "Label3";
		bd().RightToLeft = RightToLeft.No;
		bd().Size = new Size(72, 17);
		bd().TabIndex = 12;
		bd().Text = "Meas. Min:";
		be().BackColor = SystemColors.Control;
		be().BorderStyle = BorderStyle.Fixed3D;
		be().Cursor = Cursors.Default;
		be().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		be().ForeColor = SystemColors.ControlText;
		be().Location = new Point(125, 86);
		be().Name = "lblCalcCoefB";
		be().RightToLeft = RightToLeft.No;
		be().Size = new Size(86, 18);
		be().TabIndex = 11;
		bf().BackColor = SystemColors.Control;
		bf().Cursor = Cursors.Default;
		bf().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bf().ForeColor = SystemColors.ControlText;
		bf().Location = new Point(125, 67);
		bf().Name = "Label7";
		bf().RightToLeft = RightToLeft.No;
		bf().Size = new Size(86, 17);
		bf().TabIndex = 10;
		bf().Text = "Coefficient B:";
		bf().TextAlign = ContentAlignment.MiddleCenter;
		bg().BackColor = SystemColors.Control;
		bg().BorderStyle = BorderStyle.Fixed3D;
		bg().Cursor = Cursors.Default;
		bg().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bg().ForeColor = SystemColors.ControlText;
		bg().Location = new Point(15, 86);
		bg().Name = "lblCalcCoefA";
		bg().RightToLeft = RightToLeft.No;
		bg().Size = new Size(86, 18);
		bg().TabIndex = 9;
		bh().BackColor = SystemColors.Control;
		bh().Cursor = Cursors.Default;
		bh().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bh().ForeColor = SystemColors.ControlText;
		bh().Location = new Point(15, 67);
		bh().Name = "Label5";
		bh().RightToLeft = RightToLeft.No;
		bh().Size = new Size(89, 17);
		bh().TabIndex = 8;
		bh().Text = "Coefficient A:";
		bh().TextAlign = ContentAlignment.MiddleCenter;
		bj().BackColor = SystemColors.Control;
		bj().Cursor = Cursors.Default;
		bj().DialogResult = DialogResult.Cancel;
		bj().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bj().ForeColor = SystemColors.ControlText;
		bj().Location = new Point(607, 466);
		bj().Name = "btnCancel";
		bj().RightToLeft = RightToLeft.No;
		bj().Size = new Size(97, 71);
		bj().TabIndex = 3;
		bj().Text = "Close";
		bj().UseVisualStyleBackColor = false;
		bk().BackColor = SystemColors.Control;
		bk().Cursor = Cursors.Default;
		bk().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bk().ForeColor = SystemColors.ControlText;
		bk().Location = new Point(480, 466);
		bk().Name = "btnApply";
		bk().RightToLeft = RightToLeft.No;
		bk().Size = new Size(104, 71);
		bk().TabIndex = 2;
		bk().Text = "Apply Updated Coefficients";
		bk().UseVisualStyleBackColor = false;
		bl().AllowUserToAddRows = false;
		bl().AllowUserToDeleteRows = false;
		bl().AllowUserToResizeColumns = false;
		bl().AllowUserToResizeRows = false;
		bl().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		bl().EnableHeadersVisualStyles = false;
		bl().Location = new Point(16, 105);
		bl().Name = "DataGridCorrelation";
		bl().RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		bl().Size = new Size(446, 437);
		bl().TabIndex = 41;
		bn().AutoSize = true;
		bn().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bn().Location = new Point(488, 27);
		bn().Name = "optLocalCC";
		bn().Size = new Size(208, 20);
		bn().TabIndex = 42;
		bn().TabStop = true;
		bn().Text = "Current Correlative Coefficients";
		bn().UseVisualStyleBackColor = true;
		bo().AutoSize = true;
		bo().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bo().Location = new Point(486, 173);
		bo().Name = "optGlobalCC";
		bo().Size = new Size(206, 20);
		bo().TabIndex = 43;
		bo().TabStop = true;
		bo().Text = "Global Correlative Coefficients";
		bo().UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(6f, 14f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = SystemColors.Control;
		base.CancelButton = bj();
		base.ClientSize = new Size(716, 547);
		base.ControlBox = false;
		base.Controls.Add(bo());
		base.Controls.Add(bn());
		base.Controls.Add(bl());
		base.Controls.Add(au());
		base.Controls.Add(av());
		base.Controls.Add(aw());
		base.Controls.Add(ax());
		base.Controls.Add(a6());
		base.Controls.Add(a7());
		base.Controls.Add(a8());
		base.Controls.Add(bi());
		base.Controls.Add(bj());
		base.Controls.Add(bk());
		Cursor = Cursors.Default;
		Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Location = new Point(4, 23);
		base.Name = "DialogEditCorrelation";
		RightToLeft = RightToLeft.No;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "System Matching (Correlative Coeffients Calculation)";
		au().ResumeLayout(performLayout: false);
		a6().ResumeLayout(performLayout: false);
		a6().PerformLayout();
		bi().ResumeLayout(performLayout: false);
		((ISupportInitialize)bl()).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridView bl()
	{
		return ak;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aj(DataGridView A_0)
	{
		DataGridViewCellEventHandler value = aj;
		DataGridViewRowsAddedEventHandler value2 = aj;
		DataGridView dataGridView = ak;
		if (dataGridView != null)
		{
			dataGridView.CellLeave -= value;
			dataGridView.RowsAdded -= value2;
		}
		ak = A_0;
		dataGridView = ak;
		if (dataGridView != null)
		{
			dataGridView.CellLeave += value;
			dataGridView.RowsAdded += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label bm()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a7(Label A_0)
	{
		this.m_al = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton bn()
	{
		return this.m_am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aj(RadioButton A_0)
	{
		EventHandler value = al;
		RadioButton radioButton = this.m_am;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_am = A_0;
		radioButton = this.m_am;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton bo()
	{
		return this.m_an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void al(RadioButton A_0)
	{
		EventHandler value = al;
		RadioButton radioButton = this.m_an;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_an = A_0;
		radioButton = this.m_an;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bp()
	{
		return this.m_ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a8(Label A_0)
	{
		this.m_ao = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox bq()
	{
		return this.m_ap;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aj(ComboBox A_0)
	{
		EventHandler value = am;
		ComboBox comboBox = this.m_ap;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_ap = A_0;
		comboBox = this.m_ap;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	public void aj(fz A_0, hi A_1, h4 A_2, f1 A_3, object A_4)
	{
		short a_ = global::e.a().DisplaySignificantDigits;
		checked
		{
			this.m_ay = new double[this.m_ax - 1 + 1];
			this.m_az = new double[this.m_ax - 1 + 1];
			this.m_a1 = A_2;
			bl().RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			bl().RowHeadersWidth = 110;
			bl().MultiSelect = false;
			bl().SelectionMode = DataGridViewSelectionMode.CellSelect;
			bl().Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular);
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "X:Meas. Thickness(" + h4.e(this.m_a1, false, false) + ")";
			dataGridViewButtonColumn.Name = "Thickness-X";
			dataGridViewButtonColumn.Width = 167;
			dataGridViewButtonColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			_ = null;
			bl().Columns.Add(dataGridViewButtonColumn);
			dataGridViewButtonColumn2.HeaderText = "Y:Target Thickness(" + h4.e(this.m_a1, false, false) + ")";
			dataGridViewButtonColumn2.Name = "Thickness-Y";
			dataGridViewButtonColumn2.Width = 167;
			dataGridViewButtonColumn2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			_ = null;
			bl().Columns.Add(dataGridViewButtonColumn2);
			if (bl().RowCount > 0)
			{
				int num = bl().RowCount - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					bl().Rows.RemoveAt(0);
				}
			}
			int num3 = this.m_ax - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				al();
			}
			this.m_ba = A_3;
			this.m_bb = RuntimeHelpers.GetObjectValue(A_4);
			this.m_a6 = A_1;
			ax().Checked = this.m_a6.hd();
			if (this.m_a6.fi())
			{
				bo().Checked = true;
			}
			else
			{
				bn().Checked = true;
			}
			double A_5 = default(double);
			double A_6 = default(double);
			double A_7 = default(double);
			double A_8 = default(double);
			hg.bu(i3.o() + "\\globalCorr.dat", ref A_5, ref A_6, ref A_7, ref A_8);
			ar().Text = hg.bu(1, A_5, this.m_a1, a_);
			aq().Text = hg.bu(1, A_6, this.m_a1, a_);
			ao().Text = A_7.ToString("0.0000");
			an().Text = hg.bu(1, A_8, this.m_a1, a_);
			this.m_a6.au(this.m_a7);
			foreach (iz.a item in this.m_a7)
			{
				bq().Items.Add(item);
			}
			bq().SelectedIndex = 0;
			a9().Enabled = false;
			bk().Enabled = false;
			bg().Text = "";
			be().Text = "";
			ba().Text = "";
			bc().Text = "";
			bj().Text = "Close";
			a8().Visible = false;
			int count = this.m_a6.el().Count;
			for (int num5 = 2; num5 <= count; num5++)
			{
				string text = ((gc)this.m_a6.el()[num5]).ag();
				if (!gd.l(text) && Operators.CompareString(text, "<Roughness>", TextCompare: false) != 0 && Operators.CompareString(text, "<Graded Interface>", TextCompare: false) != 0)
				{
					this.m_bc = num5;
					break;
				}
			}
			ShowDialog();
		}
	}

	private void @as(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (bl().RowCount < 16)
				{
					al();
				}
				else
				{
					fe.b(this.m_a5, "Maximum number of measure is" + Conversion.Str((short)16), new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_a5, this.m_ba, RuntimeHelpers.GetObjectValue(this.m_bb), i6.a(this), "DialogEditCorrelation.btnAddGrid_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void al()
	{
		DataGridViewRow dataGridViewRow = new DataGridViewRow();
		DataGridViewCell dataGridViewCell = new DataGridViewTextBoxCell();
		dataGridViewCell.Value = "";
		dataGridViewRow.Cells.Add(dataGridViewCell);
		dataGridViewCell = new DataGridViewTextBoxCell();
		dataGridViewCell.Value = "";
		dataGridViewRow.Cells.Add(dataGridViewCell);
		bl().Rows.Add(dataGridViewRow);
		dataGridViewRow.HeaderCell.Value = "Measure " + bl().RowCount;
	}

	private void ar(object A_0, EventArgs A_1)
	{
		try
		{
			ax().Checked = true;
			if (bo().Checked)
			{
				hg.bu(i3.o() + "\\globalCorr.dat", this.m_a1.e(Conversions.ToDouble(bc().Text)), this.m_a1.e(Conversions.ToDouble(ba().Text)), Conversions.ToDouble(bg().Text), this.m_a1.e(Conversions.ToDouble(be().Text)));
				ar().Text = bc().Text;
				aq().Text = ba().Text;
				ao().Text = bg().Text;
				an().Text = be().Text;
				return;
			}
			gc obj = (gc)this.m_a6.el()[this.m_a9];
			if (this.m_a9 == this.m_bc)
			{
				this.m_a6.br.c = this.m_a1.e(iz.e(bc().Text));
				this.m_a6.br.d = this.m_a1.e(iz.e(ba().Text));
				this.m_a6.br.a = iz.e(bg().Text);
				this.m_a6.br.b = this.m_a1.e(iz.e(be().Text));
			}
			obj.x = new gb();
			gb obj2 = obj.x;
			obj2.c = this.m_a1.e(iz.e(bc().Text));
			obj2.d = this.m_a1.e(iz.e(ba().Text));
			obj2.a = iz.e(bg().Text);
			obj2.b = this.m_a1.e(iz.e(be().Text));
			_ = null;
			ay().Text = bc().Text;
			az().Text = ba().Text;
			a3().Text = bg().Text;
			a5().Text = be().Text;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_a5, this.m_ba, RuntimeHelpers.GetObjectValue(this.m_bb), i6.a(this), "DialogEditCorrelation.btnApply_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void aq(object A_0, EventArgs A_1)
	{
		try
		{
			if (aj())
			{
				int A_2 = default(int);
				double A_3 = default(double);
				double A_4 = default(double);
				aj(ref this.m_ay, ref A_2, ref A_3, ref A_4);
				double A_5 = default(double);
				double A_6 = default(double);
				jf.a(this.m_ay, this.m_az, A_2, ref A_5, ref A_6);
				bg().Text = A_6.ToString("0.0000");
				be().Text = A_5.ToString("0.0000");
				bk().Enabled = true;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_a5, this.m_ba, RuntimeHelpers.GetObjectValue(this.m_bb), i6.a(this), "DialogEditCorrelation.btnCalcCoef_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private bool aj()
	{
		checked
		{
			int num = this.m_ax - 1;
			bool flag = default(bool);
			for (int num2 = 0; num2 <= num; num2++)
			{
				double num3 = this.m_ay[num2];
				if (jf.b(Math.Abs(this.m_az[num2] - num3), num3 * 0.1) && !flag)
				{
					fe.b(this.m_a5, "Caution: the difference between measured and target thickness is greater than " + Conversion.Str((short)10) + "%\r\nValues accepted, but make sure they are correct.", "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
					flag = true;
				}
			}
			return true;
		}
	}

	private void ap(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (bl().RowCount > 2)
				{
					bl().Rows.RemoveAt(bl().SelectedCells[0].RowIndex);
				}
				else
				{
					fe.b(this.m_a5, "Minimum of 2 thickness data are needed to calculate correlative coefficients.\r\nCan't delete any more row", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				}
				int num = 0;
				foreach (DataGridViewRow item in (IEnumerable)bl().Rows)
				{
					item.HeaderCell.Value = "Measure " + (num + 1);
					num++;
				}
				ref double[] reference = ref this.m_ay;
				reference = (double[])Utils.CopyArray(reference, new double[bl().RowCount - 1 + 1]);
				ref double[] reference2 = ref this.m_az;
				reference2 = (double[])Utils.CopyArray(reference2, new double[bl().RowCount - 1 + 1]);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_a5, this.m_ba, RuntimeHelpers.GetObjectValue(this.m_bb), i6.a(this), "DialogEditCorrelation.btnDeleteGrid_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ao(object A_0, EventArgs A_1)
	{
	}

	private void an(object A_0, EventArgs A_1)
	{
		try
		{
			if (!this.m_a4)
			{
				this.m_a4 = true;
				bk().Enabled = false;
				bg().Text = "";
				be().Text = "";
				ba().Text = "";
				bc().Text = "";
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_a5, this.m_ba, RuntimeHelpers.GetObjectValue(this.m_bb), i6.a(this), "DialogEditCorrelation.frmCorrelation_Activated", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void aj(string A_0)
	{
		double num = Conversions.ToDouble(A_0);
		if (this.m_a3 == 0)
		{
			this.m_ay[this.m_a2] = num;
		}
		else
		{
			this.m_az[this.m_a2] = num;
		}
		int A_1 = default(int);
		double A_2 = default(double);
		double A_3 = default(double);
		aj(ref this.m_ay, ref A_1, ref A_2, ref A_3);
		bc().Text = Conversions.ToString(A_2);
		ba().Text = Conversions.ToString(A_3);
		if (A_1 >= 2)
		{
			aj(ref this.m_az, ref A_1, ref A_2, ref A_3);
			if (A_1 >= 2)
			{
				a9().Enabled = true;
			}
			else
			{
				a9().Enabled = false;
			}
		}
	}

	private void aj(ref double[] A_0, ref int A_1, ref double A_2, ref double A_3)
	{
		A_1 = 0;
		int num = Information.UBound(A_0);
		checked
		{
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (A_0[num2] == 0.0)
				{
					continue;
				}
				A_1++;
				if (A_1 == 1)
				{
					A_2 = A_0[num2];
					A_3 = A_0[num2];
					continue;
				}
				if (A_0[num2] < A_2)
				{
					A_2 = A_0[num2];
				}
				if (A_0[num2] > A_3)
				{
					A_3 = A_0[num2];
				}
			}
		}
	}

	private void aj(object A_0, DataGridViewCellEventArgs A_1)
	{
		try
		{
			string text = bl().Rows[A_1.RowIndex].Cells[A_1.ColumnIndex].EditedFormattedValue.ToString();
			if (!jg.b(text))
			{
				if (!string.IsNullOrEmpty(text))
				{
					bl().Rows[A_1.RowIndex].Cells[A_1.ColumnIndex].ErrorText = "This cell must contain a number.";
				}
			}
			else
			{
				this.m_a2 = A_1.RowIndex;
				this.m_a3 = A_1.ColumnIndex;
				aj(text);
				bl().Rows[A_1.RowIndex].Cells[A_1.ColumnIndex].ErrorText = string.Empty;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_a5, this.m_ba, RuntimeHelpers.GetObjectValue(this.m_bb), i6.a(this), "DialogEditCorrelation.DataGridCorrelation_CellLeave", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void aj(object A_0, DataGridViewRowsAddedEventArgs A_1)
	{
		checked
		{
			try
			{
				bl().Rows[A_1.RowIndex].HeaderCell.Value = "Measure " + A_1.RowIndex;
				ref double[] reference = ref this.m_ay;
				reference = (double[])Utils.CopyArray(reference, new double[bl().RowCount - 1 + 1]);
				ref double[] reference2 = ref this.m_az;
				reference2 = (double[])Utils.CopyArray(reference2, new double[bl().RowCount - 1 + 1]);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_a5, this.m_ba, RuntimeHelpers.GetObjectValue(this.m_bb), i6.a(this), "DialogEditCorrelation.DataGridCorrelation_RowsAdded", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void am(object A_0, EventArgs A_1)
	{
		short a_ = global::e.a().DisplaySignificantDigits;
		checked
		{
			try
			{
				this.m_a9 = ((iz.a)bq().SelectedItem).b;
				gb gb2 = ((gc)this.m_a6.el()[this.m_a9]).x;
				if (gb2 == null)
				{
					gb2 = this.m_a6.br;
				}
				ay().Text = hg.bu(1, gb2.c, this.m_a1, a_);
				az().Text = hg.bu(1, gb2.d, this.m_a1, a_);
				if (gb2.d == 0.0)
				{
					fe.b(this.m_a5, "Thickness correlative max value is 0. Recipe is corrupted.", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
					return;
				}
				a3().Text = gb2.a.ToString("0.0000");
				a5().Text = hg.bu(1, gb2.b, this.m_a1, a_);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				i5.a(this.m_a5, this.m_ba, RuntimeHelpers.GetObjectValue(this.m_bb), i6.a(this), "DialogEditCorrelation.ComboLayers_SelectedIndexChanged", a_2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void al(object A_0, EventArgs A_1)
	{
		try
		{
			bq().Enabled = bn().Checked;
			this.m_a6.eg(bo().Checked);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_a5, this.m_ba, RuntimeHelpers.GetObjectValue(this.m_bb), i6.a(this), "DialogEditCorrelation.optGlobalCC_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void aj(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_a6.e5(ax().Checked);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_a5, this.m_ba, RuntimeHelpers.GetObjectValue(this.m_bb), i6.a(this), "DialogEditCorrelation.ckUseCorrCoef_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}
}
