using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class dr : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private TableLayoutPanel m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private hx m_e;

	[CompilerGenerated]
	private Label m_f;

	[CompilerGenerated]
	private ListBox m_g;

	[CompilerGenerated]
	private hx m_h;

	[CompilerGenerated]
	private Label m_i;

	[CompilerGenerated]
	private hx m_j;

	[CompilerGenerated]
	private Label m_k;

	[CompilerGenerated]
	private Label m_l;

	[CompilerGenerated]
	private hx m_m;

	[CompilerGenerated]
	private Label m_n;

	[CompilerGenerated]
	private hx m_o;

	[CompilerGenerated]
	private TableLayoutPanel m_p;

	[CompilerGenerated]
	private TableLayoutPanel m_q;

	[CompilerGenerated]
	private RadioButton m_r;

	[CompilerGenerated]
	private RadioButton m_s;

	[CompilerGenerated]
	private TableLayoutPanel m_t;

	[CompilerGenerated]
	private TableLayoutPanel m_u;

	[CompilerGenerated]
	private hx m_v;

	[CompilerGenerated]
	private Label m_w;

	[CompilerGenerated]
	private hx m_x;

	[CompilerGenerated]
	private Label m_y;

	[CompilerGenerated]
	private ListBox m_z;

	private fz m_aa;

	private f1 ab;

	private f4 ac;

	private Collection<gr.a> ad;

	private Collection<gr.a> ae;

	private eo af;

	private eo.a ag;

	private bool ah;

	public dr()
	{
		base.Activated += f;
		base.KeyDown += a;
		b();
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
	private void b()
	{
		a(new TableLayoutPanel());
		a(new Button());
		b(new Button());
		a(new Label());
		a(new ListBox());
		b(new Label());
		c(new Label());
		d(new Label());
		e(new Label());
		b(new TableLayoutPanel());
		d(new TableLayoutPanel());
		f(new Label());
		g(new Label());
		e(new TableLayoutPanel());
		c(new TableLayoutPanel());
		a(new RadioButton());
		b(new RadioButton());
		b(new ListBox());
		f(new hx());
		g(new hx());
		c(new hx());
		e(new hx());
		a(new hx());
		d(new hx());
		b(new hx());
		c().SuspendLayout();
		q().SuspendLayout();
		u().SuspendLayout();
		v().SuspendLayout();
		r().SuspendLayout();
		SuspendLayout();
		c().Anchor = AnchorStyles.Right;
		c().AutoSize = true;
		c().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		c().ColumnCount = 2;
		c().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		c().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		c().Controls.Add(d(), 0, 0);
		c().Controls.Add(e(), 1, 0);
		c().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c().Location = new Point(367, 503);
		c().Margin = new Padding(4, 4, 0, 0);
		c().Name = "TableLayoutPanel1";
		c().RowCount = 1;
		c().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		c().Size = new Size(194, 36);
		c().TabIndex = 0;
		d().Anchor = AnchorStyles.None;
		d().DialogResult = DialogResult.OK;
		d().Location = new Point(4, 4);
		d().Margin = new Padding(4);
		d().Name = "ButtonSelect";
		d().Size = new Size(89, 28);
		d().TabIndex = 0;
		d().Text = "Select";
		e().Anchor = AnchorStyles.None;
		e().DialogResult = DialogResult.Cancel;
		e().Location = new Point(101, 4);
		e().Margin = new Padding(4);
		e().Name = "ButtonCancel";
		e().Size = new Size(89, 28);
		e().TabIndex = 1;
		e().Text = "Cancel";
		g().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		g().AutoSize = true;
		g().Location = new Point(0, 34);
		g().Margin = new Padding(0, 0, 3, 0);
		g().Name = "Label2";
		g().Size = new Size(79, 16);
		g().TabIndex = 15;
		g().Text = "Description:";
		h().FormattingEnabled = true;
		h().ItemHeight = 16;
		h().Items.AddRange(new object[1] { "Alumina" });
		h().Location = new Point(3, 99);
		h().Name = "ListBoxResults";
		h().Size = new Size(171, 388);
		h().TabIndex = 3;
		j().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		j().AutoSize = true;
		j().Location = new Point(3, 80);
		j().Name = "Label1";
		j().Size = new Size(123, 16);
		j().TabIndex = 12;
		j().Text = "Matching Materials:";
		l().AutoSize = true;
		l().Location = new Point(0, 373);
		l().Margin = new Padding(0, 0, 3, 0);
		l().Name = "LabelPrivateInfo";
		l().Size = new Size(77, 16);
		l().TabIndex = 17;
		l().Text = "Private Info:";
		l().Visible = false;
		m().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		m().AutoSize = true;
		m().Location = new Point(0, 164);
		m().Margin = new Padding(0, 0, 3, 0);
		m().Name = "Label7";
		m().Size = new Size(74, 16);
		m().TabIndex = 18;
		m().Text = "Synonyms:";
		o().Anchor = AnchorStyles.Left;
		o().AutoSize = true;
		o().Location = new Point(3, 6);
		o().Margin = new Padding(3, 0, 2, 0);
		o().Name = "Label8";
		o().Size = new Size(84, 16);
		o().TabIndex = 20;
		o().Text = "Material File:";
		q().AutoSize = true;
		q().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		q().ColumnCount = 2;
		q().ColumnStyles.Add(new ColumnStyle());
		q().ColumnStyles.Add(new ColumnStyle());
		q().Controls.Add(u(), 1, 0);
		q().Controls.Add(r(), 0, 0);
		q().Controls.Add(c(), 1, 1);
		q().Location = new Point(0, 0);
		q().Name = "TableLayoutPanel2";
		q().Padding = new Padding(3);
		q().RowCount = 2;
		q().RowStyles.Add(new RowStyle());
		q().RowStyles.Add(new RowStyle());
		q().Size = new Size(564, 542);
		q().TabIndex = 24;
		u().AutoSize = true;
		u().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		u().ColumnCount = 1;
		u().ColumnStyles.Add(new ColumnStyle());
		u().Controls.Add(w(), 0, 8);
		u().Controls.Add(x(), 0, 7);
		u().Controls.Add(y(), 0, 6);
		u().Controls.Add(k(), 0, 10);
		u().Controls.Add(l(), 0, 9);
		u().Controls.Add(z(), 0, 5);
		u().Controls.Add(v(), 1, 0);
		u().Controls.Add(g(), 0, 1);
		u().Controls.Add(f(), 0, 2);
		u().Controls.Add(n(), 0, 4);
		u().Controls.Add(m(), 0, 3);
		u().Dock = DockStyle.Fill;
		u().Location = new Point(193, 6);
		u().Name = "TableLayoutPanel4";
		u().RowCount = 11;
		u().RowStyles.Add(new RowStyle());
		u().RowStyles.Add(new RowStyle());
		u().RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		u().RowStyles.Add(new RowStyle());
		u().RowStyles.Add(new RowStyle());
		u().RowStyles.Add(new RowStyle());
		u().RowStyles.Add(new RowStyle());
		u().RowStyles.Add(new RowStyle());
		u().RowStyles.Add(new RowStyle());
		u().RowStyles.Add(new RowStyle());
		u().RowStyles.Add(new RowStyle());
		u().Size = new Size(365, 490);
		u().TabIndex = 25;
		x().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		x().AutoSize = true;
		x().Location = new Point(0, 307);
		x().Margin = new Padding(0, 0, 3, 0);
		x().Name = "Label9";
		x().Size = new Size(110, 16);
		x().TabIndex = 28;
		x().Text = "Similar Materials:";
		z().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		z().AutoSize = true;
		z().Location = new Point(0, 237);
		z().Margin = new Padding(0, 0, 3, 0);
		z().Name = "Label4";
		z().Size = new Size(70, 16);
		z().TabIndex = 27;
		z().Text = "Keywords:";
		v().Anchor = AnchorStyles.None;
		v().AutoSize = true;
		v().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		v().ColumnCount = 2;
		v().ColumnStyles.Add(new ColumnStyle());
		v().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		v().Controls.Add(o(), 0, 0);
		v().Controls.Add(p(), 1, 0);
		v().Location = new Point(67, 3);
		v().Name = "TableLayoutPanel5";
		v().RowCount = 1;
		v().RowStyles.Add(new RowStyle());
		v().Size = new Size(231, 28);
		v().TabIndex = 26;
		r().AutoSize = true;
		r().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		r().ColumnCount = 1;
		r().ColumnStyles.Add(new ColumnStyle());
		r().Controls.Add(s(), 0, 1);
		r().Controls.Add(t(), 0, 0);
		r().Controls.Add(i(), 0, 2);
		r().Controls.Add(j(), 0, 3);
		r().Controls.Add(h(), 0, 4);
		r().Location = new Point(6, 6);
		r().Name = "TableLayoutPanelLeft";
		r().RowCount = 5;
		r().RowStyles.Add(new RowStyle());
		r().RowStyles.Add(new RowStyle());
		r().RowStyles.Add(new RowStyle());
		r().RowStyles.Add(new RowStyle());
		r().RowStyles.Add(new RowStyle());
		r().Size = new Size(181, 490);
		r().TabIndex = 25;
		s().Anchor = AnchorStyles.Left;
		s().AutoSize = true;
		s().Location = new Point(3, 29);
		s().Name = "RadioButtonKeyword";
		s().Size = new Size(142, 20);
		s().TabIndex = 1;
		s().Text = "Search by Keyword";
		s().UseVisualStyleBackColor = true;
		t().Anchor = AnchorStyles.Left;
		t().AutoSize = true;
		t().Location = new Point(3, 3);
		t().Name = "RadioButtonMatName";
		t().Size = new Size(175, 20);
		t().TabIndex = 0;
		t().Text = "Search by material name";
		t().UseVisualStyleBackColor = true;
		aa().FormattingEnabled = true;
		aa().ItemHeight = 16;
		aa().Location = new Point(31, 2);
		aa().Name = "ListBoxAutoComplete";
		aa().Size = new Size(171, 36);
		aa().TabIndex = 25;
		aa().Visible = false;
		w().Location = new Point(3, 326);
		w().Multiline = true;
		w().Name = "TextBoxSimilarMaterials";
		w().ReadOnly = true;
		w().ScrollBars = ScrollBars.Vertical;
		w().Size = new Size(359, 44);
		w().TabIndex = 27;
		w().TabStop = false;
		w().Text = "We got this data from published measurements found in a book";
		y().Location = new Point(3, 256);
		y().Multiline = true;
		y().Name = "TextBoxKeywords";
		y().ReadOnly = true;
		y().ScrollBars = ScrollBars.Vertical;
		y().Size = new Size(359, 48);
		y().TabIndex = 26;
		y().TabStop = false;
		y().Text = "We got this data from published measurements found in a book";
		k().Location = new Point(3, 392);
		k().Multiline = true;
		k().Name = "TextBoxPrivateInfo";
		k().ReadOnly = true;
		k().ScrollBars = ScrollBars.Vertical;
		k().Size = new Size(359, 95);
		k().TabIndex = 16;
		k().TabStop = false;
		k().Text = "We got this data from published measurements found in a book";
		k().Visible = false;
		p().Anchor = AnchorStyles.None;
		p().Location = new Point(89, 3);
		p().Margin = new Padding(0, 3, 3, 3);
		p().Name = "TextBoxMatFile";
		p().ReadOnly = true;
		p().Size = new Size(139, 22);
		p().TabIndex = 21;
		p().TabStop = false;
		p().Text = "Al2O3";
		f().Dock = DockStyle.Fill;
		f().Location = new Point(3, 53);
		f().Multiline = true;
		f().Name = "TextBoxInfo";
		f().ReadOnly = true;
		f().ScrollBars = ScrollBars.Vertical;
		f().Size = new Size(359, 108);
		f().TabIndex = 11;
		f().TabStop = false;
		f().Text = "This material usually has a very stable refractive index value";
		n().Location = new Point(3, 183);
		n().Multiline = true;
		n().Name = "TextBoxSynonyms";
		n().ReadOnly = true;
		n().ScrollBars = ScrollBars.Vertical;
		n().Size = new Size(359, 51);
		n().TabIndex = 19;
		n().TabStop = false;
		n().Text = "Diamond; LiNbO3; LiTaO3";
		i().Anchor = AnchorStyles.Left;
		i().Location = new Point(3, 55);
		i().Name = "TextBoxSearch";
		i().Size = new Size(171, 22);
		i().TabIndex = 2;
		i().Text = "Alumina";
		base.AcceptButton = d();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = e();
		base.ClientSize = new Size(576, 555);
		base.Controls.Add(aa());
		base.Controls.Add(q());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.KeyPreview = true;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogSearchMaterials";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Search Materials";
		c().ResumeLayout(performLayout: false);
		q().ResumeLayout(performLayout: false);
		q().PerformLayout();
		u().ResumeLayout(performLayout: false);
		u().PerformLayout();
		v().ResumeLayout(performLayout: false);
		v().PerformLayout();
		r().ResumeLayout(performLayout: false);
		r().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel c()
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
	internal virtual Button d()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button e()
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
	internal virtual hx f()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hx A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label g()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ListBox h()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ListBox A_0)
	{
		EventHandler value = c;
		ListBox listBox = this.m_g;
		if (listBox != null)
		{
			listBox.SelectedIndexChanged -= value;
		}
		this.m_g = A_0;
		listBox = this.m_g;
		if (listBox != null)
		{
			listBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx i()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(hx A_0)
	{
		hx.b a_ = a;
		EventHandler value = i;
		EventHandler value2 = h;
		EventHandler value3 = g;
		hx hx2 = this.m_h;
		if (hx2 != null)
		{
			hx2.f(a_);
			hx2.Enter -= value;
			hx2.Leave -= value2;
			hx2.TextChanged -= value3;
		}
		this.m_h = A_0;
		hx2 = this.m_h;
		if (hx2 != null)
		{
			hx2.e(a_);
			hx2.Enter += value;
			hx2.Leave += value2;
			hx2.TextChanged += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label j()
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
	internal virtual hx k()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(hx A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label l()
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
	internal virtual Label m()
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
	internal virtual hx n()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(hx A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label o()
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
	internal virtual hx p()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(hx A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel q()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel r()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton s()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(RadioButton A_0)
	{
		EventHandler value = d;
		RadioButton radioButton = this.m_r;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_r = A_0;
		radioButton = this.m_r;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton t()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(RadioButton A_0)
	{
		EventHandler value = e;
		RadioButton radioButton = this.m_s;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_s = A_0;
		radioButton = this.m_s;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel u()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TableLayoutPanel A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel v()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TableLayoutPanel A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx w()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(hx A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label x()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx y()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(hx A_0)
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
	internal virtual void g(Label A_0)
	{
		this.m_y = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ListBox aa()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ListBox A_0)
	{
		EventHandler value = b;
		EventHandler value2 = a;
		ListBox listBox = this.m_z;
		if (listBox != null)
		{
			listBox.Click -= value;
			listBox.Leave -= value2;
		}
		this.m_z = A_0;
		listBox = this.m_z;
		if (listBox != null)
		{
			listBox.Click += value;
			listBox.Leave += value2;
		}
	}

	public void a(fz A_0, f1 A_1, f4 A_2, Collection<gr.a> A_3, Collection<gr.a> A_4, eo A_5, eo.a A_6, ref string A_7)
	{
		this.m_aa = A_0;
		ab = A_1;
		ac = A_2;
		ad = A_3;
		ae = A_4;
		af = A_5;
		k().Visible = A_5.a8();
		l().Visible = A_5.a8();
		t().Checked = true;
		i().Text = A_7;
		base.ActiveControl = i();
		ShowDialog();
		A_7 = p().Text;
	}

	private void a()
	{
		string right = "";
		string value = jb.x(i().Text.Trim());
		ListBox.ObjectCollection items = aa().Items;
		items.Clear();
		checked
		{
			foreach (gr.a item in ad)
			{
				if (Operators.CompareString(item.b, right, TextCompare: false) == 0)
				{
					continue;
				}
				if (item.b.StartsWith(value, StringComparison.CurrentCultureIgnoreCase))
				{
					items.Add(jb.a(item.b, item.d));
					right = item.b;
					continue;
				}
				string[] array = item.b.Split(' ');
				int upperBound = array.GetUpperBound(0);
				for (int num = 0; num <= upperBound; num++)
				{
					if (array[num].StartsWith(value, StringComparison.CurrentCultureIgnoreCase))
					{
						items.Add(jb.a(item.b, item.d));
						right = item.b;
						break;
					}
				}
			}
			if (items.Count > 0)
			{
				ListBox listBox = aa();
				int num2 = listBox.Height - listBox.ItemHeight * unchecked(listBox.Height / listBox.ItemHeight);
				listBox.SelectedIndex = 0;
				int num3 = listBox.GetItemHeight(0) * listBox.Items.Count + num2;
				if (num3 > h().Height)
				{
					num3 = h().Height;
				}
				listBox.Height = num3;
				listBox = null;
			}
			aa().Visible = items.Count > 0 && base.ActiveControl == i();
			items = null;
			a(ad);
		}
	}

	private void a(Collection<gr.a> A_0)
	{
		string text = i().Text.TrimStart();
		string value = null;
		bool flag = A_0 == ad;
		List<string> list = null;
		if (flag)
		{
			list = new List<string>();
		}
		ListBox.ObjectCollection items = h().Items;
		items.Clear();
		checked
		{
			if (string.IsNullOrEmpty(text))
			{
				foreach (gr.a item in A_0)
				{
					if (flag)
					{
						list.Add(jb.a(item.a, item.d));
					}
					else
					{
						items.Add(jb.a(item.b, item.d));
					}
				}
			}
			else
			{
				bool flag2 = default(bool);
				if (!flag)
				{
					int length = " <Universal>".Length;
					for (int num = 1; num <= length; num++)
					{
						if (text.EndsWith(" <Universal>".Substring(0, num)))
						{
							flag2 = true;
							value = text.Substring(0, text.Length - num);
							break;
						}
					}
				}
				foreach (gr.a item2 in A_0)
				{
					if (flag)
					{
						if (item2.b.StartsWith(text, StringComparison.CurrentCultureIgnoreCase))
						{
							list.Add(jb.a(item2.a, item2.d));
							continue;
						}
						string[] array = item2.b.Split(' ');
						int upperBound = array.GetUpperBound(0);
						for (int num2 = 0; num2 <= upperBound; num2++)
						{
							if (array[num2].StartsWith(text, StringComparison.CurrentCultureIgnoreCase))
							{
								list.Add(jb.a(item2.a, item2.d));
								break;
							}
						}
					}
					else if (item2.b.StartsWith(text, StringComparison.CurrentCultureIgnoreCase))
					{
						items.Add(jb.a(item2.b, item2.d));
					}
					else if (flag2 && item2.b.StartsWith(value, StringComparison.CurrentCultureIgnoreCase) && item2.d)
					{
						items.Add(jb.a(item2.b, item2.d));
					}
				}
			}
			if (flag)
			{
				list.Sort();
				foreach (string item3 in list)
				{
					items.Add(item3);
				}
			}
			if (items.Count > 0)
			{
				h().SelectedIndex = 0;
			}
			else
			{
				c(h(), new EventArgs());
			}
			items = null;
		}
	}

	private void a(object A_0, hx.a A_1)
	{
		try
		{
			switch (A_1.a)
			{
			case Keys.Return:
			case Keys.Escape:
			case Keys.Up:
			case Keys.Down:
				if (base.ActiveControl == i() && aa().Visible)
				{
					A_1.c = true;
					A_1.b = true;
				}
				break;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_aa.c(fz.b.b, "Error in DialogSearchMaterials.TextBoxSearch_DetermineInputKeyStatus", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		try
		{
			if (s().Checked)
			{
				a();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_aa, ab, ac, i6.a(this), "DialogSearchMaterials.TextBoxSearch_Enter", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		try
		{
			if (base.ActiveControl != aa())
			{
				aa().Visible = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_aa, ab, ac, i6.a(this), "DialogSearchMaterials.TextBoxSearch_Leave", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		try
		{
			if (!ah)
			{
				if (t().Checked)
				{
					a(ae);
				}
				else if (s().Checked)
				{
					a();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_aa, ab, ac, i6.a(this), "DialogSearchMaterials.TextBoxSearch_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				Point point = PointToClient(r().PointToScreen(i().Location));
				aa().Top = point.Y + i().Height;
				aa().Left = point.X + 10;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_aa, ab, ac, i6.a(this), "DialogSearchMaterials.DialogSearchMaterials_Activated", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		checked
		{
			try
			{
				ListBox listBox = aa();
				if (base.ActiveControl == i() && listBox.Visible)
				{
					switch (A_1.KeyCode)
					{
					case Keys.Escape:
						listBox.Visible = false;
						A_1.Handled = true;
						A_1.SuppressKeyPress = true;
						break;
					case Keys.Up:
					case Keys.Down:
						if (A_1.KeyCode == Keys.Down)
						{
							if (listBox.SelectedIndex < listBox.Items.Count - 1)
							{
								listBox.SelectedIndex++;
							}
						}
						else if (listBox.SelectedIndex > 0)
						{
							listBox.SelectedIndex--;
						}
						A_1.Handled = true;
						A_1.SuppressKeyPress = true;
						break;
					case Keys.Return:
						listBox.Visible = false;
						try
						{
							ah = true;
							i().Text = listBox.Text;
							i().SelectionStart = i().Text.Length;
							a(ad);
						}
						finally
						{
							ah = false;
						}
						A_1.Handled = true;
						A_1.SuppressKeyPress = true;
						break;
					}
				}
				listBox = null;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_aa, ab, ac, i6.a(this), "DialogSearchMaterials.DialogSearchMaterials_KeyDown", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			if (t().Checked)
			{
				aa().Visible = false;
				a(ae);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_aa, ab, ac, i6.a(this), "DialogSearchMaterials.RadioButtonMatName_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			if (s().Checked)
			{
				a();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_aa, ab, ac, i6.a(this), "DialogSearchMaterials.RadioButtonKeyword_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			string A_2 = "";
			string A_3 = "";
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			if (h().SelectedIndex >= 0)
			{
				if (Operators.CompareString(h().SelectedItem.ToString(), "Air", TextCompare: false) == 0)
				{
					text4 = "Air";
				}
				else
				{
					jb.d[] A_4 = null;
					string[] A_5 = null;
					if (t().Checked)
					{
						string right = jb.x(h().SelectedItem.ToString());
						foreach (gr.a item in ae)
						{
							if (Operators.CompareString(item.b, right, TextCompare: false) == 0)
							{
								text4 = jb.a(item.a, item.d);
								break;
							}
						}
					}
					else
					{
						text4 = h().SelectedItem.ToString();
					}
					string a_ = text4;
					double[] A_6 = null;
					double[] A_7 = null;
					double[] A_8 = null;
					int A_9 = 0;
					short A_10 = 0;
					int A_11 = 0;
					short[] A_12 = null;
					double[] A_13 = null;
					eo a_2 = af;
					string A_14 = null;
					bool A_15 = false;
					bool A_16 = false;
					bool A_17 = false;
					int A_18 = 0;
					string A_19 = null;
					bool A_20 = false;
					string A_21 = null;
					jc A_22 = null;
					short A_23 = default(short);
					int A_24 = default(int);
					jb.a(a_, A_1: false, ref A_6, ref A_7, ref A_8, A_5: true, A_6: true, ref A_9, null, ref A_23, ref A_10, ref A_11, ref A_12, ref A_13, a_2, ref A_14, ref A_15, ref A_16, ref A_17, ref A_2, ref A_3, ref A_18, ref A_19, ref A_24, ref A_4, ref A_5, ref A_20, ref A_21, ref A_22, ag);
					text = "";
					text2 = "";
					text3 = "";
					switch ((gr.d)A_23)
					{
					case gr.d.c:
						text2 = "Dielectric";
						break;
					case gr.d.a:
						text2 = "Metal";
						break;
					case gr.d.f:
						text2 = "Photoresist";
						break;
					case gr.d.b:
						text2 = "Semiconductor";
						break;
					}
					checked
					{
						A_18 = A_24 - 1;
						for (int num = 0; num <= A_18; num++)
						{
							switch (A_4[num])
							{
							case jb.d.a:
								if (!string.IsNullOrEmpty(text))
								{
									text += "; ";
								}
								text += A_5[num];
								break;
							case jb.d.b:
								if (!string.IsNullOrEmpty(text2))
								{
									text2 += "; ";
								}
								text2 += A_5[num];
								break;
							case jb.d.c:
								if (!string.IsNullOrEmpty(text3))
								{
									text3 += "; ";
								}
								text3 += A_5[num];
								break;
							}
						}
					}
				}
				d().Enabled = true;
			}
			else
			{
				d().Enabled = false;
			}
			p().Text = text4;
			f().Text = A_2;
			n().Text = text;
			y().Text = text2;
			w().Text = text3;
			if (af.a8())
			{
				k().Text = A_3;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			i5.a(this.m_aa, ab, ac, i6.a(this), "DialogSearchMaterials.ListBoxResults_SelectedIndexChanged", a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			if (aa().SelectedIndex >= 0)
			{
				i().Text = aa().SelectedItem.ToString();
				aa().Visible = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_aa, ab, ac, i6.a(this), "DialogSearchMaterials.ListBoxAutoComplete_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			if (base.ActiveControl != i())
			{
				aa().Visible = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_aa, ab, ac, i6.a(this), "DialogSearchMaterials.ListBoxAutoComplete_Leave", a_);
			ProjectData.ClearProjectError();
		}
	}
}
