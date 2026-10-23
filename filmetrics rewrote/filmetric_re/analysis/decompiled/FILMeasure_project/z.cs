using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Filmetrics.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class z : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private TableLayoutPanel m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private TableLayoutPanel m_e;

	[CompilerGenerated]
	private Label m_f;

	[CompilerGenerated]
	private Button g;

	[CompilerGenerated]
	private Button h;

	[CompilerGenerated]
	private Button m_i;

	[CompilerGenerated]
	private Label m_j;

	[CompilerGenerated]
	private RadioButton m_k;

	[CompilerGenerated]
	private Label m_l;

	[CompilerGenerated]
	private RadioButton m_m;

	[CompilerGenerated]
	private RadioButton m_n;

	[CompilerGenerated]
	private Label m_o;

	[CompilerGenerated]
	private Label m_p;

	[CompilerGenerated]
	private Label m_q;

	[CompilerGenerated]
	private CheckBox m_r;

	[CompilerGenerated]
	private Label m_s;

	[CompilerGenerated]
	private Label t;

	[CompilerGenerated]
	private Button m_u;

	[CompilerGenerated]
	private Panel m_v;

	[CompilerGenerated]
	private TableLayoutPanel m_w;

	[CompilerGenerated]
	private ToolTip m_x;

	[CompilerGenerated]
	private ErrorProvider m_y;

	[CompilerGenerated]
	private Label m_z;

	[CompilerGenerated]
	private Label m_aa;

	[CompilerGenerated]
	private Button m_ab;

	private object m_ac;

	private f1 m_ad;

	private fz m_ae;

	private gq m_af;

	private hg m_ag;

	private string m_ah;

	private Guid m_ai;

	private bool m_aj;

	private gr m_ak;

	private string m_al;

	private ge am;

	private e8.d an;

	private e8.a ao;

	private bool ap;

	private e8.e aq;

	private e8.f ar;

	private Collection<Control> @as;

	private Collection<Collection<Control>> at;

	private List<Button> au;

	private List<Button> av;

	private List<Button> aw;

	private List<Label> ax;

	private List<string> ay;

	private List<bool> az;

	private List<Button> a0;

	private List<RadioButton> a1;

	private List<RadioButton> a2;

	private List<RadioButton> a3;

	private List<CheckBox> a4;

	private int a5;

	private int a6;

	private int a7;

	private bool a8;

	private const string a9 = "DialogNestedRecipes";

	private const string ba = "Click to add Recipe";

	private const int bb = 2;

	private const int bc = 18;

	[SpecialName]
	private Size bd;

	public z()
	{
		@as = new Collection<Control>();
		at = new Collection<Collection<Control>>();
		au = new List<Button>();
		av = new List<Button>();
		aw = new List<Button>();
		ax = new List<Label>();
		ay = new List<string>();
		az = new List<bool>();
		a0 = new List<Button>();
		a1 = new List<RadioButton>();
		a2 = new List<RadioButton>();
		a3 = new List<RadioButton>();
		a4 = new List<CheckBox>();
		i();
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
	private void i()
	{
		this.m_a = new Container();
		a(new TableLayoutPanel());
		a(new Button());
		b(new Button());
		b(new TableLayoutPanel());
		i(new Button());
		a(new Label());
		f(new Button());
		c(new Button());
		a(new CheckBox());
		i(new Label());
		j(new Label());
		b(new RadioButton());
		c(new RadioButton());
		d(new Label());
		a(new RadioButton());
		e(new Label());
		f(new Label());
		c(new Label());
		e(new Button());
		d(new Button());
		b(new Label());
		k(new Label());
		l(new Label());
		a(new Panel());
		c(new TableLayoutPanel());
		a(new ToolTip(this.m_a));
		a(new ErrorProvider(this.m_a));
		j().SuspendLayout();
		m().SuspendLayout();
		ae().SuspendLayout();
		af().SuspendLayout();
		((ISupportInitialize)ah()).BeginInit();
		SuspendLayout();
		j().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		j().ColumnCount = 2;
		j().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		j().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		j().Controls.Add(k(), 0, 0);
		j().Controls.Add(l(), 1, 0);
		j().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		j().Location = new Point(377, 102);
		j().Margin = new Padding(4, 10, 4, 4);
		j().Name = "TLPOkCancel";
		j().RowCount = 1;
		j().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		j().Size = new Size(195, 36);
		j().TabIndex = 0;
		k().Anchor = AnchorStyles.None;
		k().Location = new Point(4, 4);
		k().Margin = new Padding(4);
		k().Name = "ButtonOK";
		k().Size = new Size(89, 28);
		k().TabIndex = 0;
		k().Text = "OK";
		k().UseVisualStyleBackColor = true;
		l().Anchor = AnchorStyles.None;
		l().DialogResult = DialogResult.Cancel;
		l().Location = new Point(101, 4);
		l().Margin = new Padding(4);
		l().Name = "ButtonCancel";
		l().Size = new Size(89, 28);
		l().TabIndex = 1;
		l().Text = "Cancel";
		l().UseVisualStyleBackColor = true;
		m().AutoSize = true;
		m().ColumnCount = 10;
		m().ColumnStyles.Add(new ColumnStyle());
		m().ColumnStyles.Add(new ColumnStyle());
		m().ColumnStyles.Add(new ColumnStyle());
		m().ColumnStyles.Add(new ColumnStyle());
		m().ColumnStyles.Add(new ColumnStyle());
		m().ColumnStyles.Add(new ColumnStyle());
		m().ColumnStyles.Add(new ColumnStyle());
		m().ColumnStyles.Add(new ColumnStyle());
		m().ColumnStyles.Add(new ColumnStyle());
		m().ColumnStyles.Add(new ColumnStyle());
		m().Controls.Add(ak(), 4, 2);
		m().Controls.Add(n(), 2, 2);
		m().Controls.Add(ad(), 0, 3);
		m().Controls.Add(o(), 3, 2);
		m().Controls.Add(aa(), 8, 2);
		m().Controls.Add(ab(), 8, 1);
		m().Controls.Add(ac(), 8, 0);
		m().Controls.Add(v(), 7, 2);
		m().Controls.Add(w(), 6, 2);
		m().Controls.Add(x(), 7, 1);
		m().Controls.Add(s(), 5, 2);
		m().Controls.Add(y(), 5, 1);
		m().Controls.Add(z(), 6, 1);
		m().Controls.Add(u(), 5, 0);
		m().Controls.Add(q(), 0, 1);
		m().Controls.Add(p(), 1, 2);
		m().Controls.Add(r(), 2, 1);
		m().Controls.Add(ai(), 9, 2);
		m().Controls.Add(aj(), 9, 3);
		m().Location = new Point(0, 0);
		m().Name = "TLPRecipes";
		m().RowCount = 5;
		m().RowStyles.Add(new RowStyle());
		m().RowStyles.Add(new RowStyle());
		m().RowStyles.Add(new RowStyle());
		m().RowStyles.Add(new RowStyle());
		m().RowStyles.Add(new RowStyle());
		m().Size = new Size(568, 84);
		m().TabIndex = 1;
		ak().Anchor = AnchorStyles.None;
		ak().AutoSize = true;
		ak().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ak().Location = new Point(232, 36);
		ak().Margin = new Padding(4);
		ak().Name = "ButtonEditRecipe";
		m().SetRowSpan(ak(), 2);
		ak().Size = new Size(50, 26);
		ak().TabIndex = 4;
		ak().Text = "Edit...";
		ak().UseVisualStyleBackColor = true;
		n().Anchor = AnchorStyles.None;
		n().AutoSize = true;
		n().BackColor = SystemColors.ButtonHighlight;
		n().BorderStyle = BorderStyle.Fixed3D;
		n().Location = new Point(51, 40);
		n().Margin = new Padding(3, 0, 0, 0);
		n().MinimumSize = new Size(158, 0);
		n().Name = "LabelRecipeName";
		m().SetRowSpan(n(), 2);
		n().Size = new Size(158, 18);
		n().TabIndex = 130;
		n().Text = "Click to add recipe";
		n().TextAlign = ContentAlignment.MiddleLeft;
		n().UseMnemonic = false;
		ad().Anchor = AnchorStyles.None;
		ad().BackColor = SystemColors.Control;
		ad().BackgroundImage = Resources.Insert;
		ad().BackgroundImageLayout = ImageLayout.Center;
		ad().Cursor = Cursors.Default;
		ad().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ad().ForeColor = SystemColors.ControlText;
		ad().Location = new Point(2, 55);
		ad().Margin = new Padding(2, 5, 2, 5);
		ad().Name = "ButtonInsertRecipe1";
		ad().RightToLeft = RightToLeft.No;
		m().SetRowSpan(ad(), 2);
		ad().Size = new Size(24, 24);
		ad().TabIndex = 130;
		ad().TextAlign = ContentAlignment.BottomCenter;
		ag().SetToolTip(ad(), "Insert another Recipe");
		ad().UseVisualStyleBackColor = true;
		o().Anchor = AnchorStyles.None;
		o().BackgroundImage = Resources.DropDownImage;
		o().BackgroundImageLayout = ImageLayout.Center;
		o().Location = new Point(209, 39);
		o().Margin = new Padding(0);
		o().Name = "ButtonGetRecipe";
		m().SetRowSpan(o(), 2);
		o().Size = new Size(19, 20);
		o().TabIndex = 131;
		o().UseVisualStyleBackColor = true;
		aa().Anchor = AnchorStyles.None;
		aa().AutoSize = true;
		aa().Location = new Point(499, 42);
		aa().Name = "CheckBoxAcquire";
		m().SetRowSpan(aa(), 2);
		aa().Size = new Size(15, 14);
		aa().TabIndex = 2;
		ag().SetToolTip(aa(), "If using this recipe, then acquire a new spectrum\r\nusing the acquisition settings in this recipe.");
		aa().UseVisualStyleBackColor = true;
		ab().Anchor = AnchorStyles.None;
		ab().AutoSize = true;
		ab().ForeColor = Color.Black;
		ab().Location = new Point(459, 16);
		ab().Name = "LabelNewSpectrumHeader";
		ab().Size = new Size(95, 16);
		ab().TabIndex = 138;
		ab().Text = "New Spectrum";
		ac().Anchor = AnchorStyles.None;
		ac().AutoSize = true;
		ac().ForeColor = Color.Black;
		ac().Location = new Point(479, 0);
		ac().Name = "LabelAcquireHeader";
		ac().Size = new Size(54, 16);
		ac().TabIndex = 137;
		ac().Text = "Acquire";
		v().Anchor = AnchorStyles.None;
		v().AutoCheck = false;
		v().AutoSize = true;
		v().Location = new Point(423, 42);
		v().Name = "RadioButtonNever";
		m().SetRowSpan(v(), 2);
		v().Size = new Size(14, 13);
		v().TabIndex = 3;
		v().TabStop = true;
		ag().SetToolTip(v(), "Never use this recipe; Recipe is disabled.");
		v().UseVisualStyleBackColor = true;
		w().Anchor = AnchorStyles.None;
		w().AutoCheck = false;
		w().AutoSize = true;
		w().Location = new Point(367, 42);
		w().Name = "RadioButtonIfInvalid";
		m().SetRowSpan(w(), 2);
		w().Size = new Size(14, 13);
		w().TabIndex = 3;
		w().TabStop = true;
		ag().SetToolTip(w(), "Use this recipe if measurement results obtained with\r\nprevious recipe(s) were invalid; keep result with highest GOF.");
		w().UseVisualStyleBackColor = true;
		x().Anchor = AnchorStyles.None;
		x().AutoSize = true;
		x().ForeColor = Color.Black;
		x().Location = new Point(408, 16);
		x().Name = "LabelNeverHeader";
		x().Size = new Size(45, 16);
		x().TabIndex = 139;
		x().Text = "Never";
		s().Anchor = AnchorStyles.None;
		s().AutoCheck = false;
		s().AutoSize = true;
		s().Location = new Point(307, 42);
		s().Name = "RadioButtonAlways";
		m().SetRowSpan(s(), 2);
		s().Size = new Size(14, 13);
		s().TabIndex = 2;
		s().TabStop = true;
		ag().SetToolTip(s(), "Always use this recipe; keep result with highest GOF.");
		s().UseVisualStyleBackColor = true;
		y().Anchor = AnchorStyles.None;
		y().AutoSize = true;
		y().ForeColor = Color.Black;
		y().Location = new Point(289, 16);
		y().Name = "LabelAlwaysHeader";
		y().Size = new Size(51, 16);
		y().TabIndex = 137;
		y().Text = "Always";
		z().Anchor = AnchorStyles.None;
		z().AutoSize = true;
		z().ForeColor = Color.Black;
		z().Location = new Point(346, 16);
		z().Name = "LabelIfInvalidHeader";
		z().Size = new Size(56, 16);
		z().TabIndex = 138;
		z().Text = "If Invalid";
		u().Anchor = AnchorStyles.None;
		u().AutoSize = true;
		m().SetColumnSpan(u(), 3);
		u().ForeColor = Color.Black;
		u().Location = new Point(331, 0);
		u().Name = "LabelUseRecipeHeader";
		u().Size = new Size(80, 16);
		u().TabIndex = 136;
		u().Text = "Use Recipe";
		q().Anchor = AnchorStyles.None;
		q().BackColor = SystemColors.Control;
		q().BackgroundImage = Resources.Insert;
		q().BackgroundImageLayout = ImageLayout.Center;
		q().Cursor = Cursors.Default;
		q().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		q().ForeColor = SystemColors.ControlText;
		q().Location = new Point(2, 21);
		q().Margin = new Padding(2, 5, 2, 5);
		q().Name = "ButtonInsertRecipe0";
		q().RightToLeft = RightToLeft.No;
		m().SetRowSpan(q(), 2);
		q().Size = new Size(24, 24);
		q().TabIndex = 129;
		q().TextAlign = ContentAlignment.BottomCenter;
		ag().SetToolTip(q(), "Insert another Recipe");
		q().UseVisualStyleBackColor = true;
		p().Anchor = AnchorStyles.None;
		p().BackColor = SystemColors.Control;
		p().BackgroundImage = Resources.x;
		p().BackgroundImageLayout = ImageLayout.Center;
		p().Cursor = Cursors.Default;
		p().FlatAppearance.BorderColor = SystemColors.HotTrack;
		p().FlatAppearance.BorderSize = 0;
		p().FlatAppearance.MouseDownBackColor = Color.White;
		p().FlatAppearance.MouseOverBackColor = Color.White;
		p().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		p().ForeColor = SystemColors.ControlText;
		p().Location = new Point(30, 39);
		p().Margin = new Padding(2, 3, 0, 3);
		p().Name = "ButtonDeleteRecipe";
		p().RightToLeft = RightToLeft.No;
		m().SetRowSpan(p(), 2);
		p().Size = new Size(18, 19);
		p().TabIndex = 128;
		p().TextAlign = ContentAlignment.BottomCenter;
		ag().SetToolTip(p(), "Delete Recipe");
		p().UseVisualStyleBackColor = true;
		r().Anchor = AnchorStyles.None;
		r().AutoSize = true;
		m().SetColumnSpan(r(), 3);
		r().ForeColor = Color.Black;
		r().Location = new Point(141, 16);
		r().Name = "LabelRecipeHeader";
		r().Size = new Size(52, 16);
		r().TabIndex = 135;
		r().Text = "Recipe";
		ai().AutoSize = true;
		ai().Location = new Point(557, 32);
		ai().Margin = new Padding(0);
		ai().Name = "LabelSpacer0";
		ai().Size = new Size(11, 16);
		ai().TabIndex = 140;
		ai().Text = " ";
		aj().AutoSize = true;
		aj().Location = new Point(557, 50);
		aj().Margin = new Padding(0);
		aj().Name = "LabelSpacer1";
		aj().Size = new Size(11, 16);
		aj().TabIndex = 141;
		aj().Text = " ";
		ae().AutoScroll = true;
		ae().Controls.Add(m());
		ae().Dock = DockStyle.Fill;
		ae().Location = new Point(3, 3);
		ae().Name = "PanelRecipes";
		ae().Size = new Size(570, 86);
		ae().TabIndex = 2;
		af().AutoSize = true;
		af().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		af().BackColor = Color.Transparent;
		af().ColumnCount = 1;
		af().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		af().Controls.Add(j(), 0, 1);
		af().Controls.Add(ae(), 0, 0);
		af().Dock = DockStyle.Fill;
		af().Location = new Point(0, 0);
		af().Name = "TLPMain";
		af().RowCount = 2;
		af().RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		af().RowStyles.Add(new RowStyle());
		af().Size = new Size(576, 142);
		af().TabIndex = 3;
		ah().ContainerControl = this;
		base.AcceptButton = k();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = SystemColors.Control;
		base.CancelButton = l();
		base.ClientSize = new Size(576, 142);
		base.Controls.Add(af());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Icon = Resources.EditRecipeIcon;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		MinimumSize = new Size(525, 180);
		base.Name = "DialogAdditionalRecipes";
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Show;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Additional Recipes";
		j().ResumeLayout(performLayout: false);
		m().ResumeLayout(performLayout: false);
		m().PerformLayout();
		ae().ResumeLayout(performLayout: false);
		ae().PerformLayout();
		af().ResumeLayout(performLayout: false);
		((ISupportInitialize)ah()).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel j()
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
	internal virtual Button k()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = e;
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
	internal virtual Button l()
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
	internal virtual TableLayoutPanel m()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		EventHandler value = a;
		TableLayoutPanel tableLayoutPanel = this.m_e;
		if (tableLayoutPanel != null)
		{
			tableLayoutPanel.SizeChanged -= value;
		}
		this.m_e = A_0;
		tableLayoutPanel = this.m_e;
		if (tableLayoutPanel != null)
		{
			tableLayoutPanel.SizeChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label n()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		EventHandler value = f;
		Label label = this.m_f;
		if (label != null)
		{
			label.Click -= value;
		}
		this.m_f = A_0;
		label = this.m_f;
		if (label != null)
		{
			label.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button o()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = f;
		Button button = g;
		if (button != null)
		{
			button.Click -= value;
		}
		g = A_0;
		button = g;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button p()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void d(Button A_0)
	{
		EventHandler value = k;
		Button button = h;
		if (button != null)
		{
			button.Click -= value;
		}
		h = A_0;
		button = h;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button q()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void e(Button A_0)
	{
		EventHandler value = i;
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
	internal virtual Label r()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton s()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(RadioButton A_0)
	{
		EventHandler value = d;
		RadioButton radioButton = this.m_k;
		if (radioButton != null)
		{
			radioButton.Click -= value;
		}
		this.m_k = A_0;
		radioButton = this.m_k;
		if (radioButton != null)
		{
			radioButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label u()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton v()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(RadioButton A_0)
	{
		EventHandler value = b;
		RadioButton radioButton = this.m_m;
		if (radioButton != null)
		{
			radioButton.Click -= value;
		}
		this.m_m = A_0;
		radioButton = this.m_m;
		if (radioButton != null)
		{
			radioButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton w()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(RadioButton A_0)
	{
		EventHandler value = c;
		RadioButton radioButton = this.m_n;
		if (radioButton != null)
		{
			radioButton.Click -= value;
		}
		this.m_n = A_0;
		radioButton = this.m_n;
		if (radioButton != null)
		{
			radioButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label x()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label y()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label z()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox aa()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(CheckBox A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ab()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Label A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ac()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Label A_0)
	{
		t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ad()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void f(Button A_0)
	{
		EventHandler value = i;
		Button button = this.m_u;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_u = A_0;
		button = this.m_u;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel ae()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Panel A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel af()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip ag()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolTip A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ErrorProvider ah()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ErrorProvider A_0)
	{
		this.m_y = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ai()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Label A_0)
	{
		this.m_z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aj()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(Label A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ak()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Button A_0)
	{
		EventHandler value = j;
		Button button = this.m_ab;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ab = A_0;
		button = this.m_ab;
		if (button != null)
		{
			button.Click += value;
		}
	}

	public void a(fz A_0, f1 A_1, gq A_2, object A_3, hg A_4, string A_5, Guid A_6, bool A_7, gr A_8, string A_9, ge A_10, e8.d A_11, e8.a A_12, bool A_13, e8.e A_14, e8.f A_15)
	{
		this.m_ae = A_0;
		this.m_ad = A_1;
		this.m_af = A_2;
		this.m_ac = RuntimeHelpers.GetObjectValue(A_3);
		this.m_ag = A_4;
		this.m_ah = A_5;
		this.m_ai = A_6;
		this.m_aj = A_7;
		this.m_ak = A_8;
		this.m_al = A_9;
		am = A_10;
		an = A_11;
		ao = A_12;
		ap = A_13;
		aq = A_14;
		ar = A_15;
		f();
		a(@as);
		au.Add(q());
		global::t.a(q(), Resources.Insert, Resources.InsertDisabled, Resources.InsertDarkGreen, this.m_ae, "DialogNestedRecipes");
		au.Add(ad());
		global::t.a(ad(), Resources.Insert, Resources.InsertDisabled, Resources.InsertDarkGreen, this.m_ae, "DialogNestedRecipes");
		a6 = 1;
		List<hj> list = A_4.ed().es();
		a7 = list.Count;
		m().SuspendLayout();
		checked
		{
			try
			{
				d();
				bool flag = default(bool);
				int num = default(int);
				foreach (hj item in list)
				{
					if (flag)
					{
						al();
						a6++;
					}
					a(num, item.e());
					switch (item.f())
					{
					case hj.a.b:
						a1[num].Checked = true;
						break;
					case hj.a.c:
						a2[num].Checked = true;
						break;
					case hj.a.a:
						a3[num].Checked = true;
						break;
					}
					az[num] = true;
					a4[num].Checked = item.g();
					num++;
					flag = true;
				}
				if (!flag)
				{
					a(0);
				}
			}
			finally
			{
				e();
			}
			a8 = true;
			m().ResumeLayout();
			b();
			ShowDialog();
			if (base.DialogResult != DialogResult.OK)
			{
				return;
			}
			List<hj> list2 = list;
			list2.Clear();
			int num2 = a6 - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (az[num3])
				{
					list2.Add(new hj(ay[num3], b(num3), a4[num3].Checked));
				}
			}
			list2 = null;
		}
	}

	private void a(Collection<Control> A_0)
	{
		Button button = (Button)A_0[@as.IndexOf(p())];
		av.Add(button);
		global::t.a(button, Resources.x, Resources.xGray, Resources.xDarkRed, this.m_ae, "DialogNestedRecipes");
		ax.Add((Label)A_0[@as.IndexOf(n())]);
		az.Add(item: false);
		ay.Add(null);
		a0.Add((Button)A_0[@as.IndexOf(o())]);
		aw.Add((Button)A_0[@as.IndexOf(ak())]);
		a1.Add((RadioButton)A_0[@as.IndexOf(s())]);
		a2.Add((RadioButton)A_0[@as.IndexOf(w())]);
		a3.Add((RadioButton)A_0[@as.IndexOf(v())]);
		a4.Add((CheckBox)A_0[@as.IndexOf(aa())]);
		at.Add(A_0);
		if (A_0 != @as)
		{
			int index = checked(av.Count - 1);
			av[index].Click += k;
			aw[index].Click += j;
			a0[index].Click += f;
			ax[index].Click += f;
			a1[index].Click += d;
			a2[index].Click += c;
			a3[index].Click += b;
		}
	}

	private void f()
	{
		Collection<Control> collection = @as;
		collection.Add(p());
		collection.Add(n());
		collection.Add(o());
		collection.Add(ak());
		collection.Add(s());
		collection.Add(w());
		collection.Add(v());
		collection.Add(aa());
		_ = null;
	}

	public void al()
	{
		checked
		{
			m().RowCount += 2;
			RowStyle rowStyle = m().RowStyles[2];
			m().RowStyles.Add(new RowStyle(rowStyle.SizeType, rowStyle.Height));
			rowStyle = m().RowStyles[3];
			m().RowStyles.Add(new RowStyle(rowStyle.SizeType, rowStyle.Height));
			Collection<Control> a_ = iz.a(@as, m(), 2 + 2 * a6, ag());
			a(a_);
			Button button = iz.a(q());
			au.Add(button);
			ag().SetToolTip(button, ag().GetToolTip(q()));
			global::t.a(button, Resources.Insert, Resources.InsertDisabled, Resources.InsertDarkGreen, this.m_ae, "DialogNestedRecipes");
			button.Click += i;
			m().Controls.Add(button, 0, 2 + 2 * a6 + 1);
			m().SetRowSpan(button, 2);
			Label control = iz.a(ai());
			m().Controls.Add(control, m().GetCellPosition(ai()).Column, 2 + 2 * a6);
			control = iz.a(aj());
			m().Controls.Add(control, m().GetCellPosition(aj()).Column, 2 + 2 * a6 + 1);
		}
	}

	private void a(int A_0, int A_1)
	{
		ax[A_1].Text = ax[A_0].Text;
		ax[A_1].ForeColor = ax[A_0].ForeColor;
		az[A_1] = az[A_0];
		ag().SetToolTip(ax[A_1], ag().GetToolTip(ax[A_0]));
		a1[A_1].Checked = a1[A_0].Checked;
		a2[A_1].Checked = a2[A_0].Checked;
		a3[A_1].Checked = a3[A_0].Checked;
		a4[A_1].Checked = a4[A_0].Checked;
	}

	private void a(object A_0, List<RadioButton> A_1)
	{
		if (c())
		{
			return;
		}
		RadioButton radioButton = (RadioButton)A_0;
		if (radioButton.Checked)
		{
			return;
		}
		try
		{
			d();
			int index = A_1.IndexOf(radioButton);
			radioButton.Checked = true;
			if (A_1 != a1)
			{
				a1[index].Checked = false;
			}
			if (A_1 != a2)
			{
				a2[index].Checked = false;
			}
			if (A_1 != a3)
			{
				a3[index].Checked = false;
			}
		}
		finally
		{
			e();
		}
	}

	private hj.a b(int A_0)
	{
		if (a1[A_0].Checked)
		{
			return hj.a.b;
		}
		if (a2[A_0].Checked)
		{
			return hj.a.c;
		}
		return hj.a.a;
	}

	private void e()
	{
		checked
		{
			a5--;
			if (a5 < 0)
			{
				a5 = 0;
			}
		}
	}

	private void a(int A_0)
	{
		ax[A_0].Text = "Click to add Recipe";
		ax[A_0].ForeColor = SystemColors.GrayText;
		ag().SetToolTip(ax[A_0], null);
		az[A_0] = false;
		a2[A_0].Checked = true;
		a1[A_0].Checked = false;
		a3[A_0].Checked = false;
		a4[A_0].Checked = false;
	}

	private void d()
	{
		checked
		{
			a5++;
		}
	}

	[SpecialName]
	private bool c()
	{
		return a5 > 0;
	}

	private void b()
	{
		checked
		{
			int num = a6 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				av[num2].Enabled = a6 > 1 || (num2 == 0 && az[0]);
				au[num2 + 1].Enabled = az[num2] && (num2 == a6 - 1 || az[num2 + 1]);
				aw[num2].Enabled = az[num2];
			}
			au[0].Enabled = az[0];
			a();
		}
	}

	private void a()
	{
		checked
		{
			int num = a6 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				string value = ((a6 <= 1 || az[num2]) ? null : "Recipe not specified");
				ah().SetError(a0[num2], value);
			}
			int num3 = a6 - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				if (!string.IsNullOrEmpty(ah().GetError(a0[num4])))
				{
					k().Enabled = false;
					return;
				}
			}
			k().Enabled = true;
		}
	}

	private void a(int A_0, string A_1)
	{
		ay[A_0] = A_1;
		Label label = ax[A_0];
		label.Text = Path.GetFileNameWithoutExtension(A_1);
		ag().SetToolTip(label, A_1);
		label.ForeColor = Color.Black;
		az[A_0] = true;
	}

	private void k(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				m().SuspendLayout();
				int num = av.IndexOf((Button)A_0);
				if (a6 > 1)
				{
					int num2 = a6 - 2;
					for (int num3 = num; num3 <= num2; num3++)
					{
						a(num3 + 1, num3);
					}
					foreach (Control item in at[a6 - 1])
					{
						item.Visible = false;
					}
					au[a6].Visible = false;
					a6--;
				}
				else
				{
					a(0);
				}
				b();
				m().ResumeLayout();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_ae, this.m_ad, RuntimeHelpers.GetObjectValue(this.m_ac), i6.a(k()), "DialogNestedRecipes.ButtonDeleteRecipe_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		try
		{
			int index = aw.IndexOf((Button)A_0);
			hg.j a_ = this.m_ag.cd();
			hg hg2 = new hg(this.m_ag.dh(), a_);
			hg2.bu(hg.b0() + ay[index], a_, null, global::r.d.a.b.a, A_4: false, A_5: false, default(Point), null, g2.b.a, A_9: false, this.m_ae, this.m_ad.xk(this.m_ai), A_12: false, A_13: false, null, A_15: false);
			e8 obj = new e8(this.m_ae);
			obj.a(hg2, this.m_aj, this.m_ak, this.m_al, this.m_ad, this.m_af, RuntimeHelpers.GetObjectValue(this.m_ac), this.m_ai, am, ref an, A_10: true, ao, ap, aq, ar);
			hg2.c9();
			obj.Dispose();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_ae, this.m_ad, RuntimeHelpers.GetObjectValue(this.m_ac), i6.a(k()), "DialogNestedRecipes.ButtonEditRecipe_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				int num = au.IndexOf((Button)A_0);
				m().SuspendLayout();
				if (ax.Count == a6)
				{
					al();
				}
				else
				{
					foreach (Control item in at[a6])
					{
						item.Visible = true;
					}
					au[a6 + 1].Visible = true;
				}
				a6++;
				int num2 = a6 - 2;
				int num3 = num;
				for (int num4 = num2; num4 >= num3; num4 += -1)
				{
					a(num4, num4 + 1);
				}
				a(num);
				m().ResumeLayout();
				b();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_ae, this.m_ad, RuntimeHelpers.GetObjectValue(this.m_ac), i6.a(k()), "DialogNestedRecipes.ButtonInsertRecipe_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		Control a_ = (Control)A_0;
		checked
		{
			try
			{
				List<string> a_2 = null;
				if (this.m_af != null && this.m_af.k() && this.m_af.g() && this.m_af.h() <= gq.a.b)
				{
					a_2 = this.m_af.l();
				}
				fk fk2 = new fk(this.m_ae, hg.b0(), this.m_ag.c1(), this.m_ah, fk.a.a, "DefaultRecipe", A_6: false, a_2);
				fk2.a(i6.a((Control)A_0));
				if (fk2.k())
				{
					return;
				}
				int num = ((!(A_0 is Button)) ? ax.IndexOf((Label)A_0) : a0.IndexOf((Button)A_0));
				string text = fk2.q();
				Label a_3 = ax[num];
				if (string.CompareOrdinal(text.ToUpper(), i3.d(this.m_ag.c1(), hg.b0()).ToUpper()) == 0)
				{
					fe.b(this.m_ae, "Duplicate recipe - selected recipe is the same as the parent recipe.", i6.a(a_3));
					return;
				}
				string text2 = i3.d(text, hg.b0());
				int num2 = a6 - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (num3 != num && az[num3] && !string.IsNullOrEmpty(ay[num3]) && string.CompareOrdinal(text2.ToUpper(), ay[num3].ToUpper()) == 0)
					{
						fe.b(this.m_ae, "Duplicate recipe - selected recipe is already in the list.", i6.a(a_3));
						return;
					}
				}
				a(num, text2);
				b();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_4 = ex2;
				i5.a(this.m_ae, this.m_ad, RuntimeHelpers.GetObjectValue(this.m_ac), i6.a(a_), "DialogNestedRecipes.ButtonGetRecipe_Click", a_4);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			base.DialogResult = DialogResult.OK;
			Close();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_ae, this.m_ad, RuntimeHelpers.GetObjectValue(this.m_ac), i6.a(k()), "DialogNestedRecipes.ButtonOK_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			a(RuntimeHelpers.GetObjectValue(A_0), a1);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_ae, this.m_ad, RuntimeHelpers.GetObjectValue(this.m_ac), i6.a(k()), "DialogNestedRecipes.RadioButtonAlways_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			a(RuntimeHelpers.GetObjectValue(A_0), a2);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_ae, this.m_ad, RuntimeHelpers.GetObjectValue(this.m_ac), i6.a(k()), "DialogNestedRecipes.RadioButtonIfInvalid_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			a(RuntimeHelpers.GetObjectValue(A_0), a3);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_ae, this.m_ad, RuntimeHelpers.GetObjectValue(this.m_ac), i6.a(k()), "DialogNestedRecipes.RadioButtonNever_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (a8)
				{
					int num = base.Height - base.ClientSize.Height + af().Top + af().Height + m().Height - ae().Height + 18;
					int num2 = base.Width - base.ClientSize.Width + af().Top + af().Width + m().Width - ae().Width + 18;
					Point point = new Point(base.Location.X + unchecked(base.Width / 2), base.Location.Y + unchecked(base.Height / 2));
					Rectangle workingArea = Screen.AllScreens[i6.a(point.X, point.Y)].WorkingArea;
					if (workingArea.Height < num)
					{
						num = workingArea.Height;
					}
					if (workingArea.Width < num2)
					{
						num2 = workingArea.Width;
					}
					MaximumSize = new Size(num2, num);
					if (bd == default(Size) || m().Width > bd.Width || m().Height > bd.Height)
					{
						int num3 = af().Width + (base.Width - base.ClientSize.Width) + m().Width - ae().Width;
						int num4 = af().Height + (base.Height - base.ClientSize.Height) + m().Height - ae().Height;
						base.Size = new Size(num3, num4);
					}
					bd = m().Size;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_ae, this.m_ad, RuntimeHelpers.GetObjectValue(this.m_ac), i6.a(k()), "DialogNestedRecipes.TLPRecipes_SizeChanged", a_);
				ProjectData.ClearProjectError();
			}
		}
	}
}
