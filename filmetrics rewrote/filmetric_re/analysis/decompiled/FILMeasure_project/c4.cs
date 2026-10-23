using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Filmetrics.FIMatFileDBService;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

[DesignerGenerated]
internal class c4 : Form
{
	public enum a
	{
		a,
		b,
		c,
		d
	}

	private enum b
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g,
		h,
		i
	}

	private delegate bool c(string A_0);

	private IContainer m_a;

	[CompilerGenerated]
	private ListBox m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private Label m_e;

	[CompilerGenerated]
	private hx m_f;

	[CompilerGenerated]
	private Label m_g;

	[CompilerGenerated]
	private Label m_h;

	[CompilerGenerated]
	private Label m_i;

	[CompilerGenerated]
	private ComboBox m_j;

	[CompilerGenerated]
	private Button m_k;

	[CompilerGenerated]
	private Button m_l;

	[CompilerGenerated]
	private TableLayoutPanel m_m;

	[CompilerGenerated]
	private TableLayoutPanel m_n;

	[CompilerGenerated]
	private TableLayoutPanel m_o;

	[CompilerGenerated]
	private TableLayoutPanel m_p;

	[CompilerGenerated]
	private ComboBox m_q;

	[CompilerGenerated]
	private Label m_r;

	[CompilerGenerated]
	private Button m_s;

	[CompilerGenerated]
	private Button m_t;

	[CompilerGenerated]
	private ComboBox m_u;

	[CompilerGenerated]
	private Label m_v;

	[CompilerGenerated]
	private Label m_w;

	[CompilerGenerated]
	private ComboBox m_x;

	[CompilerGenerated]
	private Button m_y;

	private fz m_z;

	private f1 m_aa;

	private f4 m_ab;

	private Collection<jb.c> m_ac;

	private Collection<eb.a> m_ad;

	private Collection<b> ae;

	private Collection<eb.b> af;

	private Collection<string> ag;

	private Collection<string> ah;

	private Collection<string> ai;

	private Collection<string> aj;

	private Collection<string> ak;

	private Collection<string> al;

	private a am;

	private eb.b an;

	private bool ao;

	private LicenseLevel ap;

	private string aq;

	private bool ar;

	private bool @as;

	private bool at;

	private bool au;

	private bool av;

	private bool aw;

	private bool ax;

	private bool ay;

	private bool az;

	private string a0;

	private string a1;

	private bool a2;

	private const string a3 = " (Deleted)";

	public c4()
	{
		f();
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
	private void f()
	{
		a(new ListBox());
		a(new Button());
		b(new Button());
		a(new Label());
		b(new Label());
		c(new Label());
		d(new Label());
		a(new ComboBox());
		c(new Button());
		d(new Button());
		a(new TableLayoutPanel());
		b(new TableLayoutPanel());
		b(new ComboBox());
		e(new Label());
		a(new hx());
		c(new TableLayoutPanel());
		d(new ComboBox());
		g(new Label());
		f(new Label());
		e(new Button());
		f(new Button());
		d(new TableLayoutPanel());
		g(new Button());
		c(new ComboBox());
		r().SuspendLayout();
		s().SuspendLayout();
		t().SuspendLayout();
		u().SuspendLayout();
		SuspendLayout();
		g().FormattingEnabled = true;
		g().ItemHeight = 16;
		g().Location = new Point(108, 3);
		g().Name = "ListBoxMatFiles";
		g().SelectionMode = SelectionMode.MultiExtended;
		g().Size = new Size(250, 388);
		g().TabIndex = 4;
		h().Anchor = AnchorStyles.None;
		h().AutoSize = true;
		h().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		h().Location = new Point(15, 60);
		h().Margin = new Padding(4);
		h().Name = "ButtonOpenSave";
		h().Size = new Size(89, 30);
		h().TabIndex = 5;
		h().Text = "Opn/Sv";
		i().Anchor = AnchorStyles.None;
		i().DialogResult = DialogResult.Cancel;
		i().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		i().Location = new Point(15, 98);
		i().Margin = new Padding(4, 4, 4, 0);
		i().Name = "ButtonCancel";
		i().Size = new Size(89, 30);
		i().TabIndex = 6;
		i().Text = "Cancel";
		j().Anchor = AnchorStyles.Right;
		j().AutoSize = true;
		j().Location = new Point(32, 400);
		j().Name = "LabelFileName";
		j().Size = new Size(70, 16);
		j().TabIndex = 7;
		j().Text = "File name:";
		l().AutoSize = true;
		l().Location = new Point(0, 52);
		l().Margin = new Padding(0, 6, 3, 0);
		l().Name = "Label2";
		l().Size = new Size(168, 16);
		l().TabIndex = 9;
		l().Text = "Display file Release Level:";
		m().Anchor = AnchorStyles.Top | AnchorStyles.Right;
		m().AutoSize = true;
		m().Location = new Point(62, 0);
		m().Name = "Label3";
		m().Size = new Size(40, 16);
		m().TabIndex = 10;
		m().Text = "Files:";
		n().Anchor = AnchorStyles.Right;
		n().AutoSize = true;
		n().Location = new Point(19, 459);
		n().Name = "LabelFileType";
		n().Size = new Size(83, 16);
		n().TabIndex = 21;
		n().Text = "Files of type:";
		o().DropDownStyle = ComboBoxStyle.DropDownList;
		o().FormattingEnabled = true;
		o().Location = new Point(108, 455);
		o().Name = "ComboBoxFileTypes";
		o().Size = new Size(250, 24);
		o().TabIndex = 22;
		p().Anchor = AnchorStyles.None;
		p().AutoSize = true;
		p().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		p().Location = new Point(62, 238);
		p().Margin = new Padding(4);
		p().Name = "ButtonHistory";
		p().Size = new Size(89, 30);
		p().TabIndex = 23;
		p().Text = "History...";
		q().Anchor = AnchorStyles.None;
		q().AutoSize = true;
		q().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		q().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		q().Location = new Point(11, 124);
		q().Margin = new Padding(4);
		q().Name = "ButtonChangeReleaseLevel";
		q().Size = new Size(191, 30);
		q().TabIndex = 24;
		q().Text = "Change Release Level...";
		r().AutoSize = true;
		r().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		r().ColumnCount = 2;
		r().ColumnStyles.Add(new ColumnStyle());
		r().ColumnStyles.Add(new ColumnStyle());
		r().Controls.Add(s(), 0, 0);
		r().Controls.Add(t(), 1, 0);
		r().Location = new Point(0, 0);
		r().Name = "TableLayoutPanel1";
		r().RowCount = 1;
		r().RowStyles.Add(new RowStyle());
		r().Size = new Size(587, 488);
		r().TabIndex = 25;
		s().AutoSize = true;
		s().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		s().ColumnCount = 2;
		s().ColumnStyles.Add(new ColumnStyle());
		s().ColumnStyles.Add(new ColumnStyle());
		s().Controls.Add(v(), 1, 2);
		s().Controls.Add(w(), 0, 2);
		s().Controls.Add(m(), 0, 0);
		s().Controls.Add(j(), 0, 1);
		s().Controls.Add(n(), 0, 3);
		s().Controls.Add(o(), 1, 3);
		s().Controls.Add(g(), 1, 0);
		s().Controls.Add(k(), 1, 1);
		s().Location = new Point(3, 3);
		s().Name = "TableLayoutPanel2";
		s().RowCount = 4;
		s().RowStyles.Add(new RowStyle());
		s().RowStyles.Add(new RowStyle());
		s().RowStyles.Add(new RowStyle());
		s().RowStyles.Add(new RowStyle());
		s().Size = new Size(361, 482);
		s().TabIndex = 0;
		v().DropDownStyle = ComboBoxStyle.DropDownList;
		v().FormattingEnabled = true;
		v().Location = new Point(108, 425);
		v().Name = "ComboBoxNewReleaseLevel";
		v().Size = new Size(250, 24);
		v().TabIndex = 26;
		v().Visible = false;
		w().Anchor = AnchorStyles.Right;
		w().AutoSize = true;
		w().Location = new Point(3, 429);
		w().Name = "LabelStatus";
		w().Size = new Size(99, 16);
		w().TabIndex = 26;
		w().Text = "Release Level:";
		w().Visible = false;
		k().Location = new Point(108, 397);
		k().Name = "TextBoxFileName";
		k().Size = new Size(250, 22);
		k().TabIndex = 8;
		t().AutoSize = true;
		t().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		t().ColumnCount = 1;
		t().ColumnStyles.Add(new ColumnStyle());
		t().Controls.Add(ac(), 0, 1);
		t().Controls.Add(ab(), 0, 0);
		t().Controls.Add(aa(), 0, 4);
		t().Controls.Add(x(), 0, 7);
		t().Controls.Add(y(), 0, 6);
		t().Controls.Add(l(), 0, 2);
		t().Controls.Add(p(), 0, 8);
		t().Controls.Add(q(), 0, 5);
		t().Controls.Add(u(), 0, 9);
		t().Controls.Add(z(), 0, 3);
		t().Dock = DockStyle.Fill;
		t().Location = new Point(370, 3);
		t().Margin = new Padding(3, 3, 3, 0);
		t().Name = "TableLayoutPanel3";
		t().RowCount = 10;
		t().RowStyles.Add(new RowStyle());
		t().RowStyles.Add(new RowStyle());
		t().RowStyles.Add(new RowStyle());
		t().RowStyles.Add(new RowStyle());
		t().RowStyles.Add(new RowStyle());
		t().RowStyles.Add(new RowStyle());
		t().RowStyles.Add(new RowStyle());
		t().RowStyles.Add(new RowStyle());
		t().RowStyles.Add(new RowStyle());
		t().RowStyles.Add(new RowStyle());
		t().Size = new Size(214, 485);
		t().TabIndex = 1;
		ac().DropDownStyle = ComboBoxStyle.DropDownList;
		ac().FormattingEnabled = true;
		ac().Location = new Point(3, 19);
		ac().Name = "ComboBoxFileFamily";
		ac().Size = new Size(208, 24);
		ac().TabIndex = 27;
		ac().Visible = false;
		ab().AutoSize = true;
		ab().Location = new Point(0, 0);
		ab().Margin = new Padding(0, 0, 3, 0);
		ab().Name = "LabelFileFamily";
		ab().Size = new Size(107, 16);
		ab().TabIndex = 26;
		ab().Text = "Select file family:";
		ab().Visible = false;
		aa().AutoSize = true;
		aa().Location = new Point(0, 104);
		aa().Margin = new Padding(0, 6, 3, 0);
		aa().Name = "Label4";
		aa().Size = new Size(133, 16);
		aa().TabIndex = 26;
		aa().Text = "Modify selected files:";
		x().Anchor = AnchorStyles.None;
		x().AutoSize = true;
		x().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x().Location = new Point(62, 200);
		x().Margin = new Padding(4);
		x().Name = "ButtonRecover";
		x().Size = new Size(90, 30);
		x().TabIndex = 27;
		x().Text = "Recover";
		y().Anchor = AnchorStyles.None;
		y().AutoSize = true;
		y().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		y().Location = new Point(62, 162);
		y().Margin = new Padding(4);
		y().Name = "ButtonDelete";
		y().Size = new Size(89, 30);
		y().TabIndex = 26;
		y().Text = "Delete...";
		u().Anchor = AnchorStyles.Bottom;
		u().AutoSize = true;
		u().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		u().ColumnCount = 1;
		u().ColumnStyles.Add(new ColumnStyle());
		u().Controls.Add(ad(), 0, 0);
		u().Controls.Add(h(), 0, 1);
		u().Controls.Add(i(), 0, 2);
		u().Location = new Point(47, 357);
		u().Margin = new Padding(3, 3, 3, 0);
		u().Name = "TableLayoutPanel4";
		u().RowCount = 3;
		u().RowStyles.Add(new RowStyle());
		u().RowStyles.Add(new RowStyle());
		u().RowStyles.Add(new RowStyle());
		u().Size = new Size(120, 128);
		u().TabIndex = 25;
		ad().AutoSize = true;
		ad().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ad().Location = new Point(3, 3);
		ad().Margin = new Padding(3, 3, 3, 23);
		ad().Name = "ButtonOpenFromSaveTo";
		ad().Size = new Size(114, 30);
		ad().TabIndex = 26;
		ad().Text = "Open From...";
		ad().UseVisualStyleBackColor = true;
		ad().Visible = false;
		z().DropDownStyle = ComboBoxStyle.DropDownList;
		z().FormattingEnabled = true;
		z().Location = new Point(3, 71);
		z().Name = "ComboBoxReleaseLevelFilter";
		z().Size = new Size(208, 24);
		z().TabIndex = 26;
		base.AcceptButton = h();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = i();
		base.ClientSize = new Size(590, 492);
		base.Controls.Add(r());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogMaterialsDatabase";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Online Materials Database - {0}";
		r().ResumeLayout(performLayout: false);
		r().PerformLayout();
		s().ResumeLayout(performLayout: false);
		s().PerformLayout();
		t().ResumeLayout(performLayout: false);
		t().PerformLayout();
		u().ResumeLayout(performLayout: false);
		u().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ListBox g()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ListBox A_0)
	{
		MouseEventHandler value = a;
		EventHandler value2 = c;
		ListBox listBox = this.m_b;
		if (listBox != null)
		{
			listBox.MouseDoubleClick -= value;
			listBox.SelectedIndexChanged -= value2;
		}
		this.m_b = A_0;
		listBox = this.m_b;
		if (listBox != null)
		{
			listBox.MouseDoubleClick += value;
			listBox.SelectedIndexChanged += value2;
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
	internal virtual void a(Button A_0)
	{
		EventHandler value = g;
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
	internal virtual void b(Button A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label j()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx k()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hx A_0)
	{
		EventHandler value = b;
		EventHandler value2 = a;
		hx hx2 = this.m_f;
		if (hx2 != null)
		{
			hx2.GotFocus -= value;
			hx2.TextChanged -= value2;
		}
		this.m_f = A_0;
		hx2 = this.m_f;
		if (hx2 != null)
		{
			hx2.GotFocus += value;
			hx2.TextChanged += value2;
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
	internal virtual void b(Label A_0)
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
	internal virtual void c(Label A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label n()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox o()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
	{
		EventHandler value = d;
		ComboBox comboBox = this.m_j;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_j = A_0;
		comboBox = this.m_j;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button p()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = i;
		Button button = this.m_k;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_k = A_0;
		button = this.m_k;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button q()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Button A_0)
	{
		EventHandler value = k;
		Button button = this.m_l;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_l = A_0;
		button = this.m_l;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel r()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel s()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel t()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel u()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TableLayoutPanel A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox v()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ComboBox A_0)
	{
		this.m_q = A_0;
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
	internal virtual void e(Label A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button x()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Button A_0)
	{
		EventHandler value = f;
		Button button = this.m_s;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_s = A_0;
		button = this.m_s;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button y()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Button A_0)
	{
		EventHandler value = j;
		Button button = this.m_t;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_t = A_0;
		button = this.m_t;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox z()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ComboBox A_0)
	{
		EventHandler value = d;
		ComboBox comboBox = this.m_u;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_u = A_0;
		comboBox = this.m_u;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aa()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ab()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Label A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox ac()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(ComboBox A_0)
	{
		EventHandler value = e;
		ComboBox comboBox = this.m_x;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_x = A_0;
		comboBox = this.m_x;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ad()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Button A_0)
	{
		EventHandler value = h;
		Button button = this.m_y;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_y = A_0;
		button = this.m_y;
		if (button != null)
		{
			button.Click += value;
		}
	}

	public void a(fz A_0, f1 A_1, f4 A_2, a A_3, bool A_4, bool A_5, bool A_6, bool A_7, string A_8, LicenseLevel A_9, eb.b A_10, bool A_11, bool A_12, string A_13, bool A_14, ref string A_15, ref eb.a A_16, ref bool A_17, bool A_18, bool A_19, ref bool A_20)
	{
		string[] A_21 = null;
		a(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10, A_11, A_12, A_13, A_14, ref A_15, ref A_16, ref A_17, ref A_21, A_18, A_19, ref A_20);
	}

	public void a(fz A_0, f1 A_1, f4 A_2, a A_3, bool A_4, bool A_5, bool A_6, bool A_7, string A_8, LicenseLevel A_9, eb.b A_10, bool A_11, bool A_12, string A_13, bool A_14, ref string A_15, ref eb.a A_16, ref bool A_17, ref string[] A_18, bool A_19, bool A_20, ref bool A_21)
	{
		Collection<string> collection = jb.k();
		_ = collection[0] + "\\";
		this.m_z = A_0;
		this.m_aa = A_1;
		this.m_ab = A_2;
		am = A_3;
		ap = A_9;
		aq = A_8;
		an = A_10;
		ao = A_11;
		ar = A_4;
		@as = A_5;
		at = A_6;
		au = A_14;
		av = A_7;
		aw = A_19;
		ax = A_20;
		az = A_12;
		a0 = A_13;
		a1 = "";
		this.m_ac = new Collection<jb.c>();
		this.m_ad = new Collection<eb.a>();
		ae = new Collection<b>();
		af = new Collection<eb.b>();
		d();
		ComboBox.ObjectCollection items = z().Items;
		items.Clear();
		items.Add("All (Except Deleted)");
		ae.Add(c4.b.g);
		if (A_9 >= LicenseLevel.ShippingReadOnly)
		{
			items.Add("All Database (Except Deleted)");
			ae.Add(c4.b.h);
		}
		items.Add("Local");
		ae.Add(c4.b.a);
		items.Add("Shipping");
		ae.Add(c4.b.b);
		if (A_9 >= LicenseLevel.ReadOnly)
		{
			items.Add("Unreleased");
			ae.Add(c4.b.c);
			items.Add("Customer");
			ae.Add(c4.b.d);
			items.Add("Released");
			ae.Add(c4.b.e);
			if (A_9 >= LicenseLevel.ReadWrite && am != c4.a.a && am != c4.a.d)
			{
				items.Add("Deleted");
				ae.Add(c4.b.f);
				items.Add("All Release Levels");
				ae.Add(c4.b.i);
			}
		}
		items = null;
		z().SelectedIndex = 0;
		b();
		if (A_3 == c4.a.d)
		{
			g().SelectionMode = SelectionMode.MultiExtended;
		}
		else
		{
			g().SelectionMode = SelectionMode.One;
		}
		if (A_3 == c4.a.b)
		{
			j().Text = "File name:";
		}
		else
		{
			j().Text = "Search:";
		}
		switch (A_3)
		{
		case c4.a.a:
			h().Text = "Open";
			Text = string.Format(Text, "Select File to Open");
			ad().Text = "Open From...";
			ad().Visible = true;
			k().Text = A_15;
			break;
		case c4.a.d:
		{
			h().Text = "Export";
			h().Enabled = false;
			ComboBox.ObjectCollection items3 = ac().Items;
			items3.Add("n and k files");
			af.Add(eb.b.a);
			items3.Add("Reflectance Reference files");
			af.Add(eb.b.b);
			_ = null;
			ab().Visible = true;
			ac().Visible = true;
			ac().SelectedIndex = 0;
			Text = string.Format(Text, "Select Files to Export");
			j().Visible = false;
			k().Visible = false;
			break;
		}
		case c4.a.b:
		{
			h().Text = "Save";
			ComboBox.ObjectCollection items2 = v().Items;
			items2.Clear();
			ComboBox.ObjectCollection objectCollection = items2;
			string A_22 = "MatFileDBLevelLocal";
			objectCollection.Add(hu.a(ref A_22));
			this.m_ad.Add(eb.a.a);
			if (A_9 >= LicenseLevel.ReadWrite && az)
			{
				ComboBox.ObjectCollection objectCollection2 = items2;
				A_22 = "MatFileDBLevelUnreleased";
				objectCollection2.Add(hu.a(ref A_22));
				this.m_ad.Add(eb.a.b);
				ComboBox.ObjectCollection objectCollection3 = items2;
				A_22 = "MatFileDBLevelCustomer";
				objectCollection3.Add(hu.a(ref A_22));
				this.m_ad.Add(eb.a.c);
				ComboBox.ObjectCollection objectCollection4 = items2;
				A_22 = "MatFileDBLevelReleased";
				objectCollection4.Add(hu.a(ref A_22));
				this.m_ad.Add(eb.a.d);
				if (A_9 >= LicenseLevel.ShippingReadWrite)
				{
					ComboBox.ObjectCollection objectCollection5 = items2;
					A_22 = "MatFileDBLevelShipping";
					objectCollection5.Add(hu.a(ref A_22));
					this.m_ad.Add(eb.a.f);
				}
			}
			items2 = null;
			v().SelectedIndex = 0;
			v().Visible = true;
			w().Visible = true;
			if (A_9 <= LicenseLevel.ReadOnly)
			{
				y().Visible = false;
				x().Visible = false;
				p().Visible = false;
			}
			k().Text = Path.GetFileName(A_15);
			Text = string.Format(Text, "Save File");
			ad().Text = "Save To...";
			ad().Visible = true;
			break;
		}
		case c4.a.c:
			h().Visible = false;
			i().Text = "Close";
			j().Visible = false;
			k().Visible = false;
			Text = string.Format(Text, "View Files");
			break;
		}
		base.ActiveControl = k();
		ShowDialog();
		checked
		{
			if (base.DialogResult == DialogResult.OK)
			{
				A_21 = ay;
				if (!string.IsNullOrEmpty(a1))
				{
					A_18 = new string[1];
					A_18 = new string[1] { a1 };
					A_15 = a1;
					A_17 = false;
					A_16 = eb.a.a;
					return;
				}
				ListBox.SelectedObjectCollection selectedItems = g().SelectedItems;
				string[] array;
				if (am != c4.a.d)
				{
					array = ((A_3 == c4.a.b) ? new string[1] { k().Text } : ((g().SelectedItems.Count <= 0) ? new string[1] { string.Empty } : new string[1] { g().SelectedItems[0].ToString() }));
				}
				else
				{
					int num = selectedItems.Count - 1;
					array = new string[num + 1];
					int num2 = num;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						array[num3] = selectedItems[num3].ToString();
					}
				}
				selectedItems = null;
				A_18 = new string[array.GetUpperBound(0) + 1];
				int upperBound = array.GetUpperBound(0);
				for (int num4 = 0; num4 <= upperBound; num4++)
				{
					string text = array[num4];
					string text2 = "";
					switch (A_3)
					{
					case c4.a.a:
					case c4.a.d:
						foreach (string item in collection)
						{
							if (File.Exists(item + "\\" + text))
							{
								text2 = item + "\\" + text;
								break;
							}
						}
						break;
					case c4.a.b:
					{
						A_16 = this.m_ad[v().SelectedIndex];
						A_17 = A_16 != eb.a.a;
						text2 = ((!A_17) ? (collection[1] + "\\" + text) : (collection[0] + "\\" + text));
						string text3 = e();
						if (!text2.ToLower().EndsWith(text3))
						{
							text2 += text3;
						}
						break;
					}
					}
					A_18[num4] = text2;
				}
				A_15 = A_18[0];
			}
			else
			{
				A_15 = "";
				A_18 = null;
			}
		}
	}

	private void a(List<string> A_0, Collection<string> A_1)
	{
		if (o().SelectedIndex < 0 || A_1 == null || checked(this.m_ac.Count - 1) < o().SelectedIndex)
		{
			return;
		}
		jb.c c10 = this.m_ac[o().SelectedIndex];
		switch (an)
		{
		case eb.b.a:
			switch (c10)
			{
			case jb.c.j:
				a(A_0, A_1, m);
				break;
			case jb.c.k:
				a(A_0, A_1, l);
				break;
			case jb.c.c:
				a(A_0, A_1, k);
				break;
			case jb.c.d:
				a(A_0, A_1, j);
				break;
			case jb.c.f:
				a(A_0, A_1, i);
				break;
			case jb.c.g:
				a(A_0, A_1, h);
				break;
			case jb.c.a:
				a(A_0, A_1, g);
				break;
			case jb.c.b:
				a(A_0, A_1, f);
				break;
			case jb.c.e:
			case jb.c.h:
			case jb.c.i:
				break;
			}
			break;
		case eb.b.b:
			switch (c10)
			{
			case jb.c.n:
				a(A_0, A_1, e);
				break;
			case jb.c.l:
				a(A_0, A_1, d);
				break;
			case jb.c.m:
				a(A_0, A_1, c);
				break;
			case jb.c.o:
				a(A_0, A_1, b);
				break;
			}
			break;
		}
	}

	private void a(List<string> A_0, Collection<string> A_1, c A_2)
	{
		int length = " (Deleted)".Length;
		foreach (string item in A_1)
		{
			string a_ = ((!item.EndsWith(" (Deleted)")) ? item : item.Substring(0, checked(item.Length - length)));
			if (A_2(a_))
			{
				A_0.Add(item);
			}
		}
	}

	private bool m(string A_0)
	{
		if (!jb.n(A_0))
		{
			return jb.j(A_0);
		}
		return true;
	}

	private bool l(string A_0)
	{
		if (!jb.p(A_0))
		{
			return jb.j(A_0);
		}
		return true;
	}

	private bool k(string A_0)
	{
		return string.Compare(Path.GetExtension(A_0), ".fibnk", ignoreCase: true) == 0;
	}

	private bool j(string A_0)
	{
		return string.Compare(Path.GetExtension(A_0), ".fitnk", ignoreCase: true) == 0;
	}

	private bool i(string A_0)
	{
		return string.Compare(Path.GetExtension(A_0), ".fmnnn", ignoreCase: true) == 0;
	}

	private bool h(string A_0)
	{
		return string.Compare(Path.GetExtension(A_0), ".nnn", ignoreCase: true) == 0;
	}

	private bool g(string A_0)
	{
		return string.Compare(Path.GetExtension(A_0), ".fibnx", ignoreCase: true) == 0;
	}

	private bool f(string A_0)
	{
		return string.Compare(Path.GetExtension(A_0), ".fitnx", ignoreCase: true) == 0;
	}

	private bool e(string A_0)
	{
		if (jb.ae(A_0) || jb.ac(A_0))
		{
			return ex.h(A_0);
		}
		return false;
	}

	private bool d(string A_0)
	{
		if (string.Compare(Path.GetExtension(A_0), ".fmrrr", ignoreCase: true) == 0)
		{
			return ex.h(A_0);
		}
		return false;
	}

	private bool c(string A_0)
	{
		return string.Compare(Path.GetExtension(A_0), ".rrr", ignoreCase: true) == 0;
	}

	private bool b(string A_0)
	{
		return string.Compare(Path.GetExtension(A_0), ".fitdr", ignoreCase: true) == 0;
	}

	private void a(ref Collection<string> A_0, ref Collection<eb.a> A_1)
	{
		A_0 = new Collection<string>();
		A_1 = new Collection<eb.a>();
		foreach (object selectedItem in g().SelectedItems)
		{
			string item = Conversions.ToString(selectedItem);
			A_0.Add(item);
			eb.a item2;
			if (ag.Contains(item))
			{
				item2 = eb.a.a;
			}
			else if (ai.Contains(item))
			{
				item2 = eb.a.b;
			}
			else if (aj.Contains(item))
			{
				item2 = eb.a.c;
			}
			else if (ak.Contains(item))
			{
				item2 = eb.a.d;
			}
			else if (ah.Contains(item))
			{
				item2 = eb.a.f;
			}
			else
			{
				if (!al.Contains(item))
				{
					throw new ApplicationException("Unhandled release level");
				}
				item2 = eb.a.g;
			}
			A_1.Add(item2);
		}
	}

	[SpecialName]
	private string e()
	{
		return this.m_ac[o().SelectedIndex] switch
		{
			jb.c.c => ".fibnk", 
			jb.c.a => ".fibnx", 
			jb.c.b => ".fitnx", 
			jb.c.d => ".fitnk", 
			jb.c.f => ".fmnnn", 
			jb.c.g => ".nnn", 
			jb.c.l => ".fmrrr", 
			jb.c.m => ".rrr", 
			jb.c.o => ".fitdr", 
			_ => throw new ApplicationException("Software error in Dialog MaterialsDatabase.InitAndShow: Invalid ComboBoxFileTypes.SelectedIndex"), 
		};
	}

	private bool a(string A_0)
	{
		if (Operators.CompareString(A_0, "Insulator", TextCompare: false) != 0)
		{
			return !jb.aa(A_0);
		}
		return false;
	}

	private void d()
	{
		Collection<string> collection = jb.k();
		_ = jb.h() + "\\";
		al = new Collection<string>();
		ah = new Collection<string>();
		ai = new Collection<string>();
		aj = new Collection<string>();
		ak = new Collection<string>();
		Collection<eb.c> A_ = null;
		eb.b a_ = an;
		DateTime A_2 = DateTime.MinValue;
		DateTime A_3 = DateTime.MinValue;
		LicenseLevel A_4 = LicenseLevel.Unlicensed;
		d9.a(a_, ref A_2, ref A_3, ref A_4, ref A_);
		foreach (eb.c item in A_)
		{
			eb.c c10 = item;
			if (a(item.a))
			{
				switch (c10.c)
				{
				case eb.a.b:
					ai.Add(c10.a + c10.b);
					break;
				case eb.a.c:
					aj.Add(c10.a + c10.b);
					break;
				case eb.a.d:
					ak.Add(c10.a + c10.b);
					break;
				case eb.a.f:
					ah.Add(c10.a + c10.b);
					break;
				case eb.a.g:
					al.Add(c10.a + c10.b + " (Deleted)");
					break;
				}
			}
			c10 = null;
		}
		ag = new Collection<string>();
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 1; num2 <= num; num2++)
			{
				ReadOnlyCollection<string> files = global::c.e().FileSystem.GetFiles(collection[num2] + "\\", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, jb.a(an));
				foreach (string item2 in files)
				{
					if (a(Path.GetFileNameWithoutExtension(item2)))
					{
						string fileName = Path.GetFileName(item2);
						if (!ag.Contains(fileName))
						{
							ag.Add(fileName);
						}
					}
				}
			}
		}
	}

	private void c()
	{
		if (z().SelectedIndex < 0 || (am == c4.a.d && ac().SelectedIndex < 0))
		{
			return;
		}
		List<string> list = new List<string>();
		b b10 = ae[z().SelectedIndex];
		switch (b10)
		{
		case c4.b.g:
		case c4.b.i:
			a(list, ag);
			goto case c4.b.h;
		case c4.b.h:
			a(list, ah);
			if (ap >= LicenseLevel.ReadOnly)
			{
				a(list, ai);
				a(list, aj);
				a(list, ak);
				if (b10 == c4.b.i)
				{
					a(list, al);
				}
			}
			break;
		case c4.b.a:
			a(list, ag);
			break;
		case c4.b.c:
			a(list, ai);
			break;
		case c4.b.d:
			a(list, aj);
			break;
		case c4.b.e:
			a(list, ak);
			break;
		case c4.b.b:
			a(list, ah);
			break;
		case c4.b.f:
			a(list, al);
			break;
		}
		list.Sort();
		g().Items.Clear();
		g().Items.AddRange(list.ToArray());
		q().Enabled = false;
		y().Enabled = false;
		x().Enabled = false;
		p().Enabled = false;
	}

	private void b()
	{
		this.m_ac.Clear();
		ComboBox.ObjectCollection items = o().Items;
		items.Clear();
		switch (an)
		{
		case eb.b.a:
			if (!string.IsNullOrEmpty(a0))
			{
				string A_ = "";
				eb.b a_ = an;
				string a_2 = a0;
				string A_2 = null;
				jb.c A_3 = default(jb.c);
				jb.a(a_, a_2, ref A_, ref A_3, ref A_2);
				items.Add(A_);
				this.m_ac.Add(A_3);
				break;
			}
			if (!ao && @as)
			{
				if (ar && au)
				{
					if (am == c4.a.a || am == c4.a.d || am == c4.a.c)
					{
						if (at)
						{
							items.Add("All Filmetrics Material Files");
							this.m_ac.Add(jb.c.j);
						}
						else
						{
							items.Add("All Filmetrics Unmixed Material Files");
							this.m_ac.Add(jb.c.k);
						}
					}
					items.Add("Binary n&k File (*.fibnk)");
					this.m_ac.Add(jb.c.c);
				}
				items.Add("Text n&k File (*.fitnk)");
				this.m_ac.Add(jb.c.d);
			}
			if (at)
			{
				if (ar && au)
				{
					items.Add("Binary mixture File (*.fibnx)");
					this.m_ac.Add(jb.c.a);
				}
				items.Add("Text mixture File (*.fitnx)");
				this.m_ac.Add(jb.c.b);
			}
			if (!ao && (!av || am == c4.a.a || am == c4.a.d || am == c4.a.c))
			{
				if (ar && au)
				{
					items.Add("Binary n File (*.fmnnn)");
					this.m_ac.Add(jb.c.f);
				}
				items.Add("Text n File (*.nnn)");
				this.m_ac.Add(jb.c.g);
			}
			break;
		case eb.b.b:
			if (ar)
			{
				if (am == c4.a.a || am == c4.a.d || am == c4.a.c)
				{
					items.Add("All Filmetrics RRR Files");
					this.m_ac.Add(jb.c.n);
				}
				items.Add("Binary RRR File (*.fmrrr)");
				this.m_ac.Add(jb.c.l);
			}
			items.Add("Text RRR File (*.rrr)");
			this.m_ac.Add(jb.c.m);
			items.Add("Dual R File (*.fitdr)");
			this.m_ac.Add(jb.c.o);
			break;
		}
		items = null;
		o().SelectedIndex = 0;
	}

	private void a()
	{
		dn obj = new dn();
		obj.a(aq, an, i6.a(this));
		if (obj.DialogResult == DialogResult.Cancel)
		{
			ref fz a_ = ref this.m_z;
			Point A_ = i6.a(this);
			fe.b(ref a_, "Material folder update process cancelled by user. Information in dialog may be out of date.\r\nRecommend closing this dialog in order to force refresh", ref A_);
		}
		else
		{
			d();
			c();
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				Collection<string> A_2 = null;
				Collection<eb.a> A_3 = null;
				a(ref A_2, ref A_3);
				c2 obj = new c2();
				bool[] array = new bool[A_2.Count - 1 + 1];
				eb.a A_4 = default(eb.a);
				obj.a(this.m_z, this.m_aa, this.m_ab, A_2, array, ag, A_3, ref A_4);
				if (obj.DialogResult == DialogResult.Cancel)
				{
					return;
				}
				int num = A_2.Count - 1;
				bool A_5 = default(bool);
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (!array[num2])
					{
						continue;
					}
					eb.a a10 = A_3[num2];
					if (a10 == eb.a.g)
					{
						throw new ApplicationException("Software error - attempt to change release level of " + A_2[num2] + " when it is deleted");
					}
					if (a10 == eb.a.a)
					{
						if (A_4 != eb.a.a)
						{
							string text = jb.h() + "\\" + A_2[num2];
							jb.a(text, an);
							File.Copy(jb.d() + "\\" + A_2[num2], text);
							dl obj2 = new dl();
							obj2.a(aq, an, text, A_4, i6.a(this), ref A_5);
							if (obj2.DialogResult == DialogResult.Cancel)
							{
								break;
							}
						}
						else
						{
							A_5 = true;
						}
					}
					else if (a10 != A_4)
					{
						dm obj3 = new dm();
						obj3.a(aq, an, Path.GetFileNameWithoutExtension(A_2[num2]), a10, A_4, i6.a(this), ref A_5);
						if (obj3.DialogResult == DialogResult.Cancel)
						{
							break;
						}
					}
					else
					{
						A_5 = true;
					}
					if (!A_5)
					{
						fe.b(this.m_z, "Change ReleaseLevel on " + A_2[num2] + " has failed, aborting operation", i6.a(this));
					}
				}
				a();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_z, this.m_aa, this.m_ab, i6.a(this), "DialogMaterialsDatabase.ButtonChangeReleaseLevel_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				Collection<string> A_2 = null;
				Collection<eb.a> A_3 = null;
				a(ref A_2, ref A_3);
				dh dh2 = new dh();
				dm dm2 = new dm();
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				bool flag5 = false;
				bool flag6 = false;
				string a_ = "";
				_ = new bool[A_2.Count - 1 + 1];
				if (A_2.Count > 1)
				{
					a_ = "Apply to all";
				}
				int num = A_2.Count - 1;
				bool A_4 = default(bool);
				bool A_5 = default(bool);
				bool flag8 = default(bool);
				for (int num2 = 0; num2 <= num; num2++)
				{
					string text = A_2[num2];
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
					eb.a a10 = A_3[num2];
					bool flag7;
					switch (a10)
					{
					case eb.a.a:
						if (!flag && !flag4)
						{
							SystemSounds.Exclamation.Play();
							flag7 = fe.b(ref this.m_z, "Are you sure you want to delete the Local file " + text + "?", "Warning", "Yes", "No", i6.a(y()), a_, ref A_4);
							if (A_4)
							{
								if (flag7)
								{
									flag = true;
								}
								else
								{
									flag4 = true;
								}
							}
						}
						else
						{
							flag7 = flag;
						}
						break;
					case eb.a.g:
						if (!flag3 && !flag6)
						{
							SystemSounds.Exclamation.Play();
							flag7 = fe.b(ref this.m_z, "Are you sure you want to permanently destroy all Version History information for Deleted Database file " + fileNameWithoutExtension + "?", "Warning", "Yes", "No", i6.a(y()), a_, ref A_4);
							if (A_4)
							{
								if (flag7)
								{
									flag3 = true;
								}
								else
								{
									flag6 = true;
								}
							}
						}
						else
						{
							flag7 = flag3;
						}
						break;
					default:
						if (!flag2 && !flag5)
						{
							SystemSounds.Exclamation.Play();
							flag7 = fe.b(ref this.m_z, "Are you sure you want to delete the Online Database file " + fileNameWithoutExtension + "?", "Warning", "Yes", "No", i6.a(y()), a_, ref A_4);
							if (A_4)
							{
								if (flag7)
								{
									flag2 = true;
								}
								else
								{
									flag5 = true;
								}
							}
						}
						else
						{
							flag7 = flag2;
						}
						break;
					}
					if (!flag7)
					{
						continue;
					}
					if (A_3[num2] == eb.a.g)
					{
						dh2.a(aq, an, fileNameWithoutExtension, i6.a(y()), ref A_5);
						if (dh2.DialogResult == DialogResult.Cancel)
						{
							break;
						}
						if (!A_5)
						{
							this.m_z.c(fz.b.a, "Failed attempting to destroy " + A_2[num2]);
							flag8 = true;
						}
					}
					else if (A_3[num2] == eb.a.a)
					{
						jb.a(jb.d() + "\\" + text, an);
					}
					else
					{
						dm2.a(aq, an, fileNameWithoutExtension, a10, eb.a.g, i6.a(y()), ref A_5);
						if (dm2.DialogResult == DialogResult.Cancel)
						{
							break;
						}
						if (!A_5)
						{
							this.m_z.c(fz.b.a, "Failed attempting to set Release Level to Deleted for " + A_2[num2]);
							flag8 = true;
						}
					}
				}
				if (flag8)
				{
					fe.b(this.m_z, "Errors occurred during deletion process. See log file for details.", i6.a(y()));
				}
				a();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				i5.a(this.m_z, this.m_aa, this.m_ab, i6.a(y()), "DialogMaterialsDatabase.ButtonDelete_Click", a_2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		try
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(g().SelectedItem.ToString());
			bool A_2 = false;
			new c3().a(this.m_z, this.m_aa, this.m_ab, aq, an, fileNameWithoutExtension, i6.a(this), ref A_2);
			if (A_2)
			{
				a();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_z, this.m_aa, this.m_ab, i6.a(p()), "DialogMaterialsDatabase.ButtonHistory_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		try
		{
			switch (am)
			{
			case c4.a.a:
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Title = "Open Material File From Any Location";
				openFileDialog.InitialDirectory = global::e.a().LastOpenSaveExportTargetImportSourcePath;
				openFileDialog.Filter = jb.a(au);
				openFileDialog.FilterIndex = global::e.a().LastUsedOpenMaterialIndex;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					global::e.a().LastUsedOpenMaterialIndex = openFileDialog.FilterIndex;
					global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(openFileDialog.FileName);
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
					if (a(fileNameWithoutExtension))
					{
						a1 = openFileDialog.FileName;
						openFileDialog = null;
						base.DialogResult = DialogResult.OK;
					}
					else
					{
						fe.b(this.m_z, fileNameWithoutExtension + " is a reserved name and a material file with that name can not be opened.", i6.a(ad()));
					}
				}
				break;
			}
			case c4.a.b:
			{
				if (!a(k().Text))
				{
					fe.b(this.m_z, k().Text + " is a reserved name and cannot be used for a material file name.", i6.a(ad()));
					break;
				}
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				b2 b10 = null;
				SaveFileDialog saveFileDialog2 = saveFileDialog;
				saveFileDialog2.Title = "Save Material File to Any Location";
				saveFileDialog2.InitialDirectory = global::e.a().LastOpenSaveExportTargetImportSourcePath;
				saveFileDialog2.FileName = k().Text;
				b10 = jb.a(jb.b.a, ao, ar, @as, a0);
				saveFileDialog2.Filter = b10.b();
				saveFileDialog2.OverwritePrompt = false;
				jb.k k2 = (jb.k)(saveFileDialog.Tag = new jb.k(this.m_z, av, aw, ax, this.m_aa.ui(), this.m_aa.ug(), ap, this.m_aa.uf(), this.m_ad[v().SelectedIndex], az, an, ay, i6.a(h())));
				saveFileDialog2.FileOk += jb.a;
				if (saveFileDialog2.ShowDialog() != DialogResult.Cancel)
				{
					global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(saveFileDialog2.FileName);
					a1 = b10.a(saveFileDialog2.FileName, saveFileDialog2.FilterIndex);
					ay = k2.l;
					saveFileDialog2 = null;
					base.DialogResult = DialogResult.OK;
				}
				break;
			}
			default:
				throw new ApplicationException("Incompatible display style");
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_z, this.m_aa, this.m_ab, i6.a(ad()), "DialogMaterialsDatabase.ButtonOpenFromSaveTo_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		if (am == c4.a.b)
		{
			bool flag = this.m_ad[v().SelectedIndex] != eb.a.a;
			string text = k().Text;
			if (!a(text))
			{
				fe.b(this.m_z, text + " is a reserved name and cannot be used for a material file name.", i6.a(h()));
				return;
			}
			Collection<string> collection = jb.k();
			string text2 = ((!flag) ? (collection[1] + "\\" + text) : (collection[0] + "\\" + text));
			string text3 = e();
			if (!text2.ToLower().EndsWith(text3))
			{
				text2 += text3;
			}
			if (jb.a(this.m_z, text2, av, aw, ax, this.m_aa.ui(), this.m_aa.ug(), ap, this.m_aa.uf(), this.m_ad[v().SelectedIndex], az, an, ref ay, i6.a(h())))
			{
				base.DialogResult = DialogResult.OK;
			}
		}
		else
		{
			base.DialogResult = DialogResult.OK;
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
		{
			dj dj2 = new dj();
			Collection<dj.a> A_2 = null;
			dm dm2 = new dm();
			string a_ = "";
			if (g().SelectedItems.Count > 1)
			{
				a_ = "Apply to all";
			}
			bool A_3 = default(bool);
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool A_4 = default(bool);
			bool A_5 = default(bool);
			bool flag4 = default(bool);
			foreach (object selectedItem in g().SelectedItems)
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(Conversions.ToString(selectedItem));
				dj2.a(aq, an, fileNameWithoutExtension, i6.a(x()), ref ap, ref A_2, ref A_3);
				if (dj2.DialogResult == DialogResult.Cancel)
				{
					break;
				}
				string text = fileNameWithoutExtension + A_2[0].d;
				string text2 = jb.d() + "\\" + text;
				bool flag3;
				if (File.Exists(text2))
				{
					if (!flag && !flag2)
					{
						SystemSounds.Exclamation.Play();
						flag3 = fe.b(ref this.m_z, "Recovering the file " + text + " will result in deletion of the local file.\r\nAre you sure you wish to continue?", "Warning", "Yes", "No", i6.a(x()), a_, ref A_4);
						if (A_4)
						{
							if (flag3)
							{
								flag = true;
							}
							else
							{
								flag2 = true;
							}
						}
					}
					else
					{
						flag3 = flag;
					}
					if (flag3)
					{
						jb.a(text2, an);
					}
				}
				else
				{
					flag3 = true;
				}
				if (!flag3)
				{
					continue;
				}
				eb.a a10 = eb.a.a;
				foreach (dj.a item in A_2)
				{
					if (item.c != eb.a.g)
					{
						a10 = item.c;
						break;
					}
				}
				if (a10 == eb.a.a)
				{
					A_5 = false;
				}
				else
				{
					if (a10 == eb.a.f && ap < LicenseLevel.ShippingReadWrite)
					{
						fe.b(this.m_z, "Recovering the file " + text + " is not permitted because it was a shipping file.\r\nYou must have a ShippingReadWrite license in order to recover this file", i6.a(x()));
						break;
					}
					dm2.a(aq, an, fileNameWithoutExtension, eb.a.g, a10, i6.a(x()), ref A_5);
				}
				if (!A_5)
				{
					this.m_z.c(fz.b.a, "Failed to recover file " + text);
					flag4 = true;
				}
			}
			if (flag4)
			{
				fe.b(this.m_z, "Errors occurred during recovery process. See log file for details.", i6.a(x()));
			}
			a();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_z, this.m_aa, this.m_ab, i6.a(x()), "DialogMaterialsDatabase.ButtonRecover_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			an = af[ac().SelectedIndex];
			b();
			d();
			c();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_z, this.m_aa, this.m_ab, i6.a(this), "DialogMaterialsDatabase.ComboBoxFileFamily_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			c();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_z, this.m_aa, this.m_ab, i6.a(this), "DialogMaterialsDatabase.FileLevelOrType_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, MouseEventArgs A_1)
	{
		try
		{
			if (am != c4.a.c)
			{
				base.DialogResult = DialogResult.OK;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_z, this.m_aa, this.m_ab, i6.a(this), "DialogMaterialsDatabase.ListBoxMatFiles_MouseDoubleClick", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			string text = jb.d() + "\\";
			bool enabled = false;
			if (g().SelectedItems.Count >= 1 && az)
			{
				enabled = true;
				foreach (object selectedItem in g().SelectedItems)
				{
					string item = Conversions.ToString(selectedItem);
					if (ap < LicenseLevel.ReadWriteAdmin && al.Contains(item))
					{
						enabled = false;
						break;
					}
					if (ap < LicenseLevel.ShippingReadWrite && ah.Contains(item))
					{
						enabled = false;
						break;
					}
					if (ap <= LicenseLevel.ReadOnly && !ag.Contains(item))
					{
						enabled = false;
						break;
					}
				}
			}
			y().Enabled = enabled;
			bool enabled2 = false;
			if (g().SelectedItems.Count >= 1 && ap >= LicenseLevel.ReadWrite && az)
			{
				enabled2 = true;
				foreach (object selectedItem2 in g().SelectedItems)
				{
					string text2 = Conversions.ToString(selectedItem2);
					if (al.Contains(text2))
					{
						enabled2 = false;
						break;
					}
					if (ap < LicenseLevel.ShippingReadWrite && ah.Contains(text2))
					{
						enabled2 = false;
						break;
					}
					if (ag.Contains(text2) && an == eb.b.a && !jb.n(text2) && File.Exists(text + Path.ChangeExtension(text2, jb.g(text2))))
					{
						enabled2 = false;
						break;
					}
				}
			}
			q().Enabled = enabled2;
			bool enabled3 = default(bool);
			if (ap >= LicenseLevel.ReadWrite && g().SelectedItems.Count == 1 && az)
			{
				enabled3 = true;
				foreach (object selectedItem3 in g().SelectedItems)
				{
					string item2 = Conversions.ToString(selectedItem3);
					if (ag.Contains(item2))
					{
						enabled3 = false;
						break;
					}
				}
			}
			p().Enabled = enabled3;
			bool enabled4 = default(bool);
			if (ap >= LicenseLevel.ReadWrite && g().SelectedItems.Count >= 1 && az)
			{
				enabled4 = true;
				foreach (object selectedItem4 in g().SelectedItems)
				{
					string item3 = Conversions.ToString(selectedItem4);
					if (!al.Contains(item3))
					{
						enabled4 = false;
						break;
					}
				}
			}
			x().Enabled = enabled4;
			h().Enabled = am != c4.a.d || g().SelectedItems.Count > 0;
			if (g().SelectedItems.Count != 1 || am == c4.a.d || a2)
			{
				return;
			}
			try
			{
				a2 = true;
				string text3 = g().SelectedItem.ToString();
				if (text3.EndsWith(" (Deleted)"))
				{
					text3 = text3.Substring(0, checked(text3.Length - " (Deleted)".Length));
				}
				k().Text = text3;
			}
			finally
			{
				a2 = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_z, this.m_aa, this.m_ab, i6.a(this), "DialogMaterialsDatabase.ListBoxMatFiles_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			if (am == c4.a.b)
			{
				g().ClearSelected();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_z, this.m_aa, this.m_ab, i6.a(p()), "DialogMaterialsDatabase.TextBoxFileName_GotFocus", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (a2)
				{
					return;
				}
				try
				{
					a2 = true;
					ListBox listBox = g();
					if (am == c4.a.d && listBox.SelectedItems.Count > 1)
					{
						listBox.SelectedIndex = -1;
					}
					int num = listBox.Items.Count - 1;
					int num2;
					bool flag = default(bool);
					for (num2 = 0; num2 <= num; num2++)
					{
						if (((string)listBox.Items[num2]).StartsWith(k().Text, StringComparison.CurrentCultureIgnoreCase))
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						int num3 = listBox.Items.Count - 1;
						int num4 = num2;
						int num5;
						for (num5 = num3; num5 >= num4 && !((string)listBox.Items[num5]).StartsWith(k().Text, StringComparison.CurrentCultureIgnoreCase); num5 += -1)
						{
						}
						listBox.SelectedItems.Clear();
						listBox.SelectedIndex = num5;
						listBox.SelectedIndex = num2;
						if (am == c4.a.b)
						{
							listBox.SelectedItems.Clear();
						}
					}
					listBox = null;
				}
				finally
				{
					a2 = false;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_z, this.m_aa, this.m_ab, i6.a(p()), "DialogMaterialsDatabase.TextBoxFileName_TextChanged", a_);
				ProjectData.ClearProjectError();
			}
		}
	}
}
