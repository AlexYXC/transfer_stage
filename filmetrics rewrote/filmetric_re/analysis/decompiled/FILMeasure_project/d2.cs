using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class d2 : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private TableLayoutPanel m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private CheckBox m_e;

	[CompilerGenerated]
	private Button m_f;

	[CompilerGenerated]
	private TrackBar m_g;

	[CompilerGenerated]
	private Label m_h;

	[CompilerGenerated]
	private RadioButton m_i;

	[CompilerGenerated]
	private RadioButton m_j;

	[CompilerGenerated]
	private GroupBox m_k;

	[CompilerGenerated]
	private GroupBox m_l;

	[CompilerGenerated]
	private Label m_m;

	[CompilerGenerated]
	private ComboBox m_n;

	[CompilerGenerated]
	private TableLayoutPanel m_o;

	[CompilerGenerated]
	private Label m_p;

	[CompilerGenerated]
	private hy m_q;

	[CompilerGenerated]
	private TableLayoutPanel m_r;

	[CompilerGenerated]
	private Button m_s;

	[CompilerGenerated]
	private ToolTip m_t;

	[CompilerGenerated]
	private TableLayoutPanel m_u;

	[CompilerGenerated]
	private TableLayoutPanel m_v;

	[CompilerGenerated]
	private ComboBox m_w;

	[CompilerGenerated]
	private Label m_x;

	private bool m_y;

	private ej.b z;

	private bool aa;

	private fz ab;

	private f1 ac;

	private f4 ad;

	private string ae;

	private Guid af;

	private bool ag;

	private bool ah;

	[CompilerGenerated]
	private r.d ai;

	private const int aj = 255;

	private int ak;

	private const string al = "Unrotated";

	private const string am = "Rotated CW 90 Degrees";

	private const string an = "Rotated CCW 90 Degrees";

	private const string ao = "Rotated 180 Degrees";

	private d4.e ap;

	public d2()
	{
		a(new r.d());
		a();
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
	private void a()
	{
		this.m_a = new Container();
		a(new TableLayoutPanel());
		a(new Button());
		b(new Button());
		a(new CheckBox());
		c(new Button());
		a(new TrackBar());
		a(new Label());
		a(new RadioButton());
		b(new RadioButton());
		a(new GroupBox());
		c(new Label());
		b(new GroupBox());
		a(new ComboBox());
		b(new Label());
		b(new TableLayoutPanel());
		c(new TableLayoutPanel());
		d(new Button());
		d(new TableLayoutPanel());
		e(new TableLayoutPanel());
		b(new ComboBox());
		d(new Label());
		a(new ToolTip(this.m_a));
		a(new hy());
		b().SuspendLayout();
		((ISupportInitialize)g()).BeginInit();
		k().SuspendLayout();
		l().SuspendLayout();
		o().SuspendLayout();
		r().SuspendLayout();
		u().SuspendLayout();
		v().SuspendLayout();
		SuspendLayout();
		b().Anchor = AnchorStyles.Right;
		b().ColumnCount = 2;
		b().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		b().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		b().Controls.Add(c(), 0, 0);
		b().Controls.Add(d(), 1, 0);
		b().Location = new Point(213, 310);
		b().Margin = new Padding(4, 20, 4, 20);
		b().Name = "TableLayoutPanel1";
		b().RowCount = 1;
		b().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		b().Size = new Size(235, 47);
		b().TabIndex = 0;
		c().Anchor = AnchorStyles.None;
		c().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c().Location = new Point(4, 4);
		c().Margin = new Padding(4);
		c().Name = "OK_Button";
		c().Size = new Size(109, 38);
		c().TabIndex = 0;
		c().Text = "OK";
		c().UseVisualStyleBackColor = true;
		d().Anchor = AnchorStyles.None;
		d().DialogResult = DialogResult.Cancel;
		d().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d().Location = new Point(121, 4);
		d().Margin = new Padding(4);
		d().Name = "Cancel_Button";
		d().Size = new Size(109, 38);
		d().TabIndex = 1;
		d().Text = "Cancel";
		d().UseVisualStyleBackColor = true;
		e().Anchor = AnchorStyles.None;
		e().AutoSize = true;
		e().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e().Location = new Point(0, 1);
		e().Margin = new Padding(0);
		e().Name = "CheckBoxShowSpot";
		e().Size = new Size(277, 20);
		e().TabIndex = 6;
		e().Text = "Show Measurement Spot using Opacity of:";
		e().UseVisualStyleBackColor = true;
		f().Anchor = AnchorStyles.None;
		f().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f().Location = new Point(4, 4);
		f().Margin = new Padding(4);
		f().Name = "ButtonMeasSpot";
		f().Size = new Size(172, 43);
		f().TabIndex = 8;
		f().Text = "Set Spot Location...";
		f().UseVisualStyleBackColor = true;
		g().Enabled = false;
		g().Location = new Point(132, 22);
		g().Margin = new Padding(4);
		g().Maximum = 50;
		g().Name = "TrackBarFocus";
		g().Size = new Size(307, 45);
		g().TabIndex = 7;
		h().AutoSize = true;
		h().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		h().Location = new Point(22, 29);
		h().Margin = new Padding(4, 0, 4, 0);
		h().Name = "LabelCameraFocus";
		h().Size = new Size(97, 16);
		h().TabIndex = 6;
		h().Text = "Camera focus: ";
		i().AutoSize = true;
		i().Location = new Point(19, -2);
		i().Margin = new Padding(4);
		i().Name = "RadioButtonStage";
		i().Size = new Size(111, 20);
		i().TabIndex = 8;
		i().TabStop = true;
		i().Text = "Stage camera";
		i().UseVisualStyleBackColor = true;
		j().AutoSize = true;
		j().Location = new Point(20, 209);
		j().Margin = new Padding(20, 4, 4, 4);
		j().Name = "RadioButtonMicroscope";
		j().Size = new Size(197, 20);
		j().TabIndex = 9;
		j().TabStop = true;
		j().Text = "Microscope Adapter camera";
		j().UseVisualStyleBackColor = true;
		k().Controls.Add(g());
		k().Controls.Add(h());
		k().Controls.Add(i());
		k().Location = new Point(3, 67);
		k().Name = "GroupBox1";
		k().Size = new Size(446, 73);
		k().TabIndex = 10;
		k().TabStop = false;
		p().Anchor = AnchorStyles.None;
		p().AutoSize = true;
		p().Location = new Point(333, 3);
		p().Margin = new Padding(0);
		p().Name = "LabelOpacityPercentage";
		p().Size = new Size(20, 16);
		p().TabIndex = 12;
		p().Text = "%";
		l().Controls.Add(n());
		l().Controls.Add(m());
		l().Location = new Point(3, 146);
		l().Name = "GroupBoxImageOrientation";
		l().Size = new Size(444, 56);
		l().TabIndex = 11;
		l().TabStop = false;
		l().Text = "Image Orientation";
		n().DropDownStyle = ComboBoxStyle.DropDownList;
		n().FormattingEnabled = true;
		n().Location = new Point(131, 21);
		n().Name = "ComboImageRotation";
		n().Size = new Size(307, 24);
		n().TabIndex = 1;
		m().AutoSize = true;
		m().Location = new Point(15, 24);
		m().Name = "Label1";
		m().Size = new Size(116, 16);
		m().TabIndex = 0;
		m().Text = "Image Orientation:";
		o().AutoSize = true;
		o().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		o().BackColor = SystemColors.Window;
		o().ColumnCount = 1;
		o().ColumnStyles.Add(new ColumnStyle());
		o().Controls.Add(r(), 0, 5);
		o().Controls.Add(k(), 0, 2);
		o().Controls.Add(b(), 0, 6);
		o().Controls.Add(l(), 0, 3);
		o().Controls.Add(j(), 0, 4);
		o().Controls.Add(u(), 0, 0);
		o().Controls.Add(v(), 0, 1);
		o().Location = new Point(0, 0);
		o().Name = "TableLayoutPanel2";
		o().RowCount = 7;
		o().RowStyles.Add(new RowStyle());
		o().RowStyles.Add(new RowStyle());
		o().RowStyles.Add(new RowStyle());
		o().RowStyles.Add(new RowStyle());
		o().RowStyles.Add(new RowStyle());
		o().RowStyles.Add(new RowStyle());
		o().RowStyles.Add(new RowStyle());
		o().Size = new Size(452, 377);
		o().TabIndex = 12;
		r().Anchor = AnchorStyles.None;
		r().AutoSize = true;
		r().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		r().ColumnCount = 2;
		r().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		r().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		r().Controls.Add(f(), 0, 0);
		r().Controls.Add(s(), 1, 0);
		r().Location = new Point(46, 236);
		r().Name = "TableLayoutPanel3";
		r().RowCount = 1;
		r().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		r().Size = new Size(360, 51);
		r().TabIndex = 13;
		s().Anchor = AnchorStyles.None;
		s().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		s().Location = new Point(184, 4);
		s().Margin = new Padding(4);
		s().Name = "ButtonCalibration";
		s().Size = new Size(172, 43);
		s().TabIndex = 9;
		s().Text = "Calibration...";
		s().UseVisualStyleBackColor = true;
		s().Visible = false;
		u().Anchor = AnchorStyles.None;
		u().AutoSize = true;
		u().ColumnCount = 3;
		u().ColumnStyles.Add(new ColumnStyle());
		u().ColumnStyles.Add(new ColumnStyle());
		u().ColumnStyles.Add(new ColumnStyle());
		u().Controls.Add(p(), 2, 0);
		u().Controls.Add(e(), 0, 0);
		u().Controls.Add(q(), 1, 0);
		u().Location = new Point(49, 3);
		u().Name = "TableLayoutPanel4";
		u().RowCount = 1;
		u().RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		u().RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
		u().Size = new Size(353, 22);
		u().TabIndex = 14;
		v().Anchor = AnchorStyles.None;
		v().AutoSize = true;
		v().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		v().ColumnCount = 2;
		v().ColumnStyles.Add(new ColumnStyle());
		v().ColumnStyles.Add(new ColumnStyle());
		v().Controls.Add(w(), 0, 0);
		v().Controls.Add(x(), 0, 0);
		v().Location = new Point(97, 31);
		v().Name = "TableLayoutPanel5";
		v().RowCount = 1;
		v().RowStyles.Add(new RowStyle());
		v().Size = new Size(258, 30);
		v().TabIndex = 15;
		w().AllowDrop = true;
		w().DropDownStyle = ComboBoxStyle.DropDownList;
		w().DropDownWidth = 90;
		w().FormattingEnabled = true;
		w().Location = new Point(165, 3);
		w().Name = "ComboBoxSpotColor";
		w().Size = new Size(90, 24);
		w().TabIndex = 2;
		x().Anchor = AnchorStyles.Right;
		x().AutoSize = true;
		x().Location = new Point(3, 7);
		x().Margin = new Padding(3, 0, 0, 0);
		x().Name = "Label2";
		x().Size = new Size(159, 16);
		x().TabIndex = 1;
		x().Text = "Measurement Spot Color:";
		t().AutoPopDelay = 15000;
		t().InitialDelay = 500;
		t().ReshowDelay = 100;
		q().Anchor = AnchorStyles.None;
		q().f(A_0: true);
		q().Location = new Point(280, 0);
		q().Margin = new Padding(3, 0, 3, 0);
		q().Name = "TextOpacity";
		q().e(A_0: false);
		q().Size = new Size(50, 22);
		q().TabIndex = 11;
		base.AcceptButton = c();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = d();
		base.ClientSize = new Size(452, 362);
		base.Controls.Add(o());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogVideoSettings";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Video Settings";
		b().ResumeLayout(performLayout: false);
		((ISupportInitialize)g()).EndInit();
		k().ResumeLayout(performLayout: false);
		k().PerformLayout();
		l().ResumeLayout(performLayout: false);
		l().PerformLayout();
		o().ResumeLayout(performLayout: false);
		o().PerformLayout();
		r().ResumeLayout(performLayout: false);
		u().ResumeLayout(performLayout: false);
		u().PerformLayout();
		v().ResumeLayout(performLayout: false);
		v().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel b()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
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
	internal virtual Button d()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox e()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(CheckBox A_0)
	{
		EventHandler value = a;
		CheckBox checkBox = this.m_e;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_e = A_0;
		checkBox = this.m_e;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button f()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = e;
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
	internal virtual TrackBar g()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TrackBar A_0)
	{
		EventHandler value = d;
		TrackBar trackBar = this.m_g;
		if (trackBar != null)
		{
			trackBar.ValueChanged -= value;
		}
		this.m_g = A_0;
		trackBar = this.m_g;
		if (trackBar != null)
		{
			trackBar.ValueChanged += value;
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
	internal virtual RadioButton i()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(RadioButton A_0)
	{
		EventHandler value = c;
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
	internal virtual RadioButton j()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(RadioButton A_0)
	{
		EventHandler value = b;
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
	internal virtual GroupBox k()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(GroupBox A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox l()
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
	internal virtual Label m()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox n()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel o()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
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
	internal virtual void c(Label A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy q()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hy A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel r()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button s()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Button A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip t()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolTip A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel u()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TableLayoutPanel A_0)
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
	internal virtual void e(TableLayoutPanel A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox w()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ComboBox A_0)
	{
		DrawItemEventHandler value = a;
		ComboBox comboBox = this.m_w;
		if (comboBox != null)
		{
			comboBox.DrawItem -= value;
		}
		this.m_w = A_0;
		comboBox = this.m_w;
		if (comboBox != null)
		{
			comboBox.DrawItem += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label x()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d y()
	{
		return ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		r.d.b a_ = a;
		ai?.e(a_);
		ai = A_0;
		ai?.d(a_);
	}

	public void a(fz A_0, bool A_1, ej.b A_2, bool A_3, int A_4, f1 A_5, f4 A_6, Guid A_7)
	{
		this.m_y = A_1;
		z = A_2;
		aa = A_3;
		ab = A_0;
		ac = A_5;
		ad = A_6;
		af = A_7;
		ae = A_7.ToString();
		ak = 255 / g().Maximum;
		if (A_3)
		{
			g().Value = A_4 / ak;
		}
		else
		{
			Text = "Image Settings";
		}
		if (A_2 == ej.b.b)
		{
			j().Checked = true;
		}
		else
		{
			i().Checked = true;
		}
		e().Checked = global::e.a().VideoShowSpot;
		q().Text = global::e.a().VideoOpacity.ToString();
		i().Enabled = A_3 && ac.wz(af);
		j().Enabled = A_3 && (ac.w0(af) || ac.ul(af));
		_ = (et)ac.t0(ae).d0().r();
		l().Visible = A_3;
		w().DrawMode = DrawMode.OwnerDrawFixed;
		w().Items.Add(Color.Yellow.Name);
		w().Items.Add(Color.Cyan.Name);
		w().Items.Add(Color.Magenta.Name);
		w().Items.Add(Color.Red.Name);
		w().Items.Add(Color.Green.Name);
		w().Items.Add(Color.Blue.Name);
		w().SelectedIndex = w().Items.IndexOf(global::e.a().MeasureSpotColor.Name);
		ShowDialog();
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
		{
			if (this.m_y && aa)
			{
				ej.b a_ = ((!i().Checked) ? ej.b.b : ej.b.a);
				switch (n().SelectedItem.ToString())
				{
				case "Unrotated":
					ap = d4.e.a;
					break;
				case "Rotated CW 90 Degrees":
					ap = d4.e.b;
					break;
				case "Rotated CCW 90 Degrees":
					ap = d4.e.c;
					break;
				case "Rotated 180 Degrees":
					ap = d4.e.d;
					break;
				}
				ac.m2(ae, e().Checked, checked(g().Value * ak), a_);
			}
			global::e.a().VideoShowSpot = e().Checked;
			int num = iz.c(q().Text);
			if (num > 100 || num < 0)
			{
				fz a_2 = ab;
				string A_2 = "InvalidValueFor1Between2And3Fmt3";
				string format = hu.a(ref A_2);
				A_2 = "Opacity";
				fe.b(a_2, string.Format(format, hu.a(ref A_2), 0.ToString(), 100.ToString()), i6.a(this));
			}
			else
			{
				global::e.a().VideoOpacity = num;
				global::e.a().MeasureSpotColor = Color.FromName(w().SelectedItem.ToString());
				base.DialogResult = DialogResult.OK;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			ab.c(fz.b.b, "Error in DialogVideoSettings.OK_Button_Click", a_3);
			fe.b(ab, "Error in OK Button Click. Error details have been logged.", i6.a(c()));
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, DrawItemEventArgs A_1)
	{
		try
		{
			_ = A_1.Graphics;
			if (A_1.Index >= 0)
			{
				Color color = Color.FromName(w().Items[A_1.Index].ToString());
				Brush brush = new SolidBrush(color);
				A_1.DrawBackground();
				Brush brush2 = ((!(color == Color.Red) && !(color == Color.Green) && !(color == Color.Blue)) ? Brushes.Black : Brushes.White);
				A_1.Graphics.FillRectangle(brush2, A_1.Bounds);
				A_1.Graphics.DrawString(w().Items[A_1.Index].ToString(), A_1.Font, brush, A_1.Bounds, StringFormat.GenericDefault);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ab.c(fz.b.b, "Error in ComboBoxSpotColor_DrawItem", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			string a_;
			if (j().Checked)
			{
				string A_2 = "VideoPrepareToCalibrateSpotF40";
				a_ = hu.a(ref A_2);
			}
			else if (ac.vl(af))
			{
				string A_2 = "VideoPrepareToCalibrateSpotF10VC";
				a_ = hu.a(ref A_2);
			}
			else if (ac.ul(af))
			{
				string A_2 = "VideoPrepareToCalibrateSpotDualSpotStage";
				a_ = hu.a(ref A_2);
			}
			else
			{
				string A_2 = "VideoPrepareToCalibrateSpot";
				a_ = hu.a(ref A_2);
			}
			if (fe.b(ref ab, a_, "Information", "OKString", "CancelString", i6.a(this)))
			{
				ej.b a_2 = ((!i().Checked) ? ej.b.b : ej.b.a);
				ac.m2(ae, e().Checked, checked(g().Value * ak), a_2);
				ac.m2(ae, y());
				Cursor = Cursors.WaitCursor;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			Cursor = Cursors.Default;
			ab.c(fz.b.b, "Error in DialogVideoSettings.ButtonMeasSpot_Click", a_3);
			ProjectData.ClearProjectError();
		}
	}

	public void a(fz A_0, bool A_1, ej.b A_2, bool A_3, int A_4, f1 A_5, f4 A_6, Guid A_7, ref d4.e A_8)
	{
		ap = A_8;
		string selectedItem;
		if (A_8 == d4.e.b)
		{
			selectedItem = "Rotated CW 90 Degrees";
		}
		else if (A_8 == d4.e.c)
		{
			selectedItem = "Rotated CCW 90 Degrees";
		}
		else if (A_8 == d4.e.a)
		{
			selectedItem = "Unrotated";
		}
		else
		{
			if (A_8 != d4.e.d)
			{
				throw new ApplicationException("UnDefined camera rotation");
			}
			selectedItem = "Rotated 180 Degrees";
		}
		ComboBox.ObjectCollection items = n().Items;
		items.Clear();
		items.Add("Unrotated");
		items.Add("Rotated CW 90 Degrees");
		items.Add("Rotated CCW 90 Degrees");
		items.Add("Rotated 180 Degrees");
		_ = null;
		n().SelectedItem = selectedItem;
		l().Visible = A_3;
		a(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7);
		A_8 = ap;
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			if (aa)
			{
				ac.p9(ae, checked(g().Value * ak));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ab.c(fz.b.b, "Error in DialogVideoSettings.TrackBarFocus_ValueChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(bool A_0)
	{
		g().Enabled = !A_0 && aa;
		h().Enabled = g().Enabled;
		f().Enabled = this.m_y;
		s().Enabled = this.m_y;
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			bool flag = i().Checked;
			j().Checked = !flag;
			a(!flag);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(ab, ac, ad, i6.a(this), "DialogVideoSettings.RadioButtonStage_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			bool flag = j().Checked;
			i().Checked = !flag;
			a(flag);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(ab, ac, ad, i6.a(this), "DialogVideoSettings.RadioButtonMicroscope_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			q().Enabled = e().Checked;
			p().Enabled = e().Checked;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(ab, ac, ad, i6.a(this), "DialogVideoSettings.CheckBoxShowSpot_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.d.a A_0)
	{
		if (base.InvokeRequired)
		{
			Invoke(new r.d.b(a), A_0);
			return;
		}
		Cursor = Cursors.Default;
		if (A_0.a == global::r.d.a.a.a)
		{
			if (i().Checked)
			{
				ref fz a_ = ref ab;
				string A_1 = "VideoCalibrateSpotIsDone";
				if (fe.b(ref a_, string.Format(hu.a(ref A_1)), "Information", "OKString", "CancelString", i6.a(this)))
				{
					e().Checked = true;
				}
			}
			else
			{
				fe.b(ab, "Measurement spot location calibration completed.", "Information", i6.a(this));
			}
		}
		else
		{
			fe.b(ab, "There is a error in finding the measurement spot.", i6.a(this));
		}
	}
}
