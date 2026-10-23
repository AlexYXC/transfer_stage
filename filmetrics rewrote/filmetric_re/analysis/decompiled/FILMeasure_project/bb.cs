using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class bb : Form
{
	public enum a
	{
		a,
		b,
		c
	}

	private IContainer m_a;

	[CompilerGenerated]
	private TabControl m_b;

	[CompilerGenerated]
	private TabPage m_c;

	[CompilerGenerated]
	private Label m_d;

	[CompilerGenerated]
	private Button m_e;

	[CompilerGenerated]
	private Button m_f;

	[CompilerGenerated]
	private Button m_g;

	[CompilerGenerated]
	private Label m_h;

	[CompilerGenerated]
	private hy m_i;

	[CompilerGenerated]
	private Label m_j;

	[CompilerGenerated]
	private CheckBox m_k;

	[CompilerGenerated]
	private TableLayoutPanel m_l;

	[CompilerGenerated]
	private TableLayoutPanel m_m;

	[CompilerGenerated]
	private TableLayoutPanel m_n;

	[CompilerGenerated]
	private TableLayoutPanel m_o;

	[CompilerGenerated]
	private TableLayoutPanel m_p;

	private bool q;

	public bb()
	{
		q = true;
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
		a(new TabControl());
		a(new TabPage());
		a(new TableLayoutPanel());
		c(new TableLayoutPanel());
		b(new TableLayoutPanel());
		c(new Label());
		a(new hy());
		b(new Label());
		a(new CheckBox());
		a(new Label());
		a(new Button());
		b(new Button());
		c(new Button());
		d(new TableLayoutPanel());
		e(new TableLayoutPanel());
		b().SuspendLayout();
		c().SuspendLayout();
		l().SuspendLayout();
		n().SuspendLayout();
		m().SuspendLayout();
		o().SuspendLayout();
		p().SuspendLayout();
		SuspendLayout();
		b().Controls.Add(c());
		b().Location = new Point(1, 1);
		b().Margin = new Padding(1, 1, 2, 1);
		b().Name = "TabControl";
		b().SelectedIndex = 0;
		b().Size = new Size(571, 107);
		b().TabIndex = 0;
		c().Controls.Add(l());
		c().Location = new Point(4, 25);
		c().Name = "TabPage1";
		c().Padding = new Padding(3);
		c().Size = new Size(563, 78);
		c().TabIndex = 0;
		c().Text = "Reminder";
		c().UseVisualStyleBackColor = true;
		l().AutoSize = true;
		l().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		l().ColumnCount = 2;
		l().ColumnStyles.Add(new ColumnStyle());
		l().ColumnStyles.Add(new ColumnStyle());
		l().Controls.Add(n(), 1, 0);
		l().Controls.Add(d(), 0, 0);
		l().Location = new Point(3, 3);
		l().Name = "TableLayoutPanel1";
		l().RowCount = 1;
		l().RowStyles.Add(new RowStyle());
		l().Size = new Size(249, 60);
		l().TabIndex = 5;
		n().Anchor = AnchorStyles.None;
		n().AutoSize = true;
		n().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		n().ColumnCount = 1;
		n().ColumnStyles.Add(new ColumnStyle());
		n().Controls.Add(k(), 0, 1);
		n().Controls.Add(m(), 0, 0);
		n().Location = new Point(58, 3);
		n().Name = "TableLayoutPanel3";
		n().RowCount = 2;
		n().RowStyles.Add(new RowStyle());
		n().RowStyles.Add(new RowStyle());
		n().Size = new Size(188, 54);
		n().TabIndex = 23;
		m().AutoSize = true;
		m().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		m().ColumnCount = 3;
		m().ColumnStyles.Add(new ColumnStyle());
		m().ColumnStyles.Add(new ColumnStyle());
		m().ColumnStyles.Add(new ColumnStyle());
		m().Controls.Add(j(), 0, 0);
		m().Controls.Add(i(), 1, 0);
		m().Controls.Add(h(), 2, 0);
		m().Location = new Point(3, 3);
		m().Name = "TableLayoutPanelSettings";
		m().RowCount = 1;
		m().RowStyles.Add(new RowStyle());
		m().Size = new Size(182, 22);
		m().TabIndex = 22;
		j().AutoSize = true;
		j().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		j().Location = new Point(0, 3);
		j().Margin = new Padding(0, 3, 0, 0);
		j().Name = "LabelBaselineReminderInterval";
		j().Size = new Size(116, 16);
		j().TabIndex = 19;
		j().Text = "Reminder Interval:";
		i().f(A_0: false);
		i().Location = new Point(116, 0);
		i().Margin = new Padding(0);
		i().Name = "TextBoxNumericBaselineReminderInterval";
		i().e(A_0: false);
		i().Size = new Size(40, 22);
		i().TabIndex = 18;
		i().TextAlign = HorizontalAlignment.Right;
		h().AutoSize = true;
		h().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		h().Location = new Point(156, 3);
		h().Margin = new Padding(0, 3, 0, 0);
		h().Name = "Label17";
		h().Size = new Size(26, 16);
		h().TabIndex = 20;
		h().Text = "hrs";
		k().AutoSize = true;
		k().Location = new Point(6, 31);
		k().Margin = new Padding(6, 3, 3, 3);
		k().Name = "CheckBoxDontRemind";
		k().Size = new Size(95, 20);
		k().TabIndex = 21;
		k().Text = "CheckBox1";
		k().UseVisualStyleBackColor = true;
		d().AutoSize = true;
		d().Location = new Point(3, 0);
		d().Name = "LabelDetails";
		d().Size = new Size(49, 16);
		d().TabIndex = 0;
		d().Text = "Label1";
		e().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		e().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e().Location = new Point(3, 3);
		e().Name = "ButtonMeasure";
		e().Size = new Size(103, 32);
		e().TabIndex = 2;
		e().Text = "Measure";
		e().UseVisualStyleBackColor = true;
		f().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		f().AutoSize = true;
		f().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		f().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f().Location = new Point(112, 5);
		f().Name = "ButtonBaseline";
		f().Size = new Size(92, 30);
		f().TabIndex = 3;
		f().Text = "Baseline...";
		f().UseVisualStyleBackColor = true;
		g().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		g().DialogResult = DialogResult.Cancel;
		g().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		g().Location = new Point(210, 3);
		g().Margin = new Padding(3, 3, 0, 3);
		g().Name = "ButtonCancel";
		g().Size = new Size(103, 32);
		g().TabIndex = 4;
		g().Text = "Cancel";
		g().UseVisualStyleBackColor = true;
		o().AutoSize = true;
		o().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		o().ColumnCount = 3;
		o().ColumnStyles.Add(new ColumnStyle());
		o().ColumnStyles.Add(new ColumnStyle());
		o().ColumnStyles.Add(new ColumnStyle());
		o().Controls.Add(e(), 0, 0);
		o().Controls.Add(g(), 2, 0);
		o().Controls.Add(f(), 1, 0);
		o().Dock = DockStyle.Right;
		o().Location = new Point(258, 112);
		o().Name = "TableLayoutPanel4";
		o().RowCount = 1;
		o().RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		o().Size = new Size(313, 38);
		o().TabIndex = 5;
		p().AutoSize = true;
		p().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		p().ColumnCount = 1;
		p().ColumnStyles.Add(new ColumnStyle());
		p().Controls.Add(o(), 0, 1);
		p().Controls.Add(b(), 0, 0);
		p().Location = new Point(6, 6);
		p().Margin = new Padding(1, 1, 3, 1);
		p().Name = "TableLayoutPanel5";
		p().RowCount = 2;
		p().RowStyles.Add(new RowStyle());
		p().RowStyles.Add(new RowStyle());
		p().Size = new Size(574, 153);
		p().TabIndex = 6;
		base.AcceptButton = f();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = g();
		base.ClientSize = new Size(587, 249);
		base.Controls.Add(p());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogBaselineReminder";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.Manual;
		Text = "Baseline";
		base.TopMost = true;
		b().ResumeLayout(performLayout: false);
		c().ResumeLayout(performLayout: false);
		c().PerformLayout();
		l().ResumeLayout(performLayout: false);
		l().PerformLayout();
		n().ResumeLayout(performLayout: false);
		n().PerformLayout();
		m().ResumeLayout(performLayout: false);
		m().PerformLayout();
		o().ResumeLayout(performLayout: false);
		o().PerformLayout();
		p().ResumeLayout(performLayout: false);
		p().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabControl b()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TabControl A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TabPage A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label d()
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
	internal virtual Button e()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = b;
		Button button = this.m_e;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_e = A_0;
		button = this.m_e;
		if (button != null)
		{
			button.Click += value;
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
	internal virtual void b(Button A_0)
	{
		EventHandler value = a;
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
	internal virtual Button g()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		this.m_g = A_0;
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
	internal virtual void b(Label A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy i()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hy A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label j()
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
	internal virtual CheckBox k()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(CheckBox A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel l()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel m()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel n()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
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
	internal virtual void d(TableLayoutPanel A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel p()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TableLayoutPanel A_0)
	{
		this.m_p = A_0;
	}

	public a a(ref float A_0, ref bool A_1, Point A_2, bool A_3, bool A_4)
	{
		string empty = string.Empty;
		string empty2 = string.Empty;
		string empty3 = string.Empty;
		empty = ((A_0 != 1f) ? "Hours" : "Hour");
		if (A_3)
		{
			empty2 = ey.g() + "...";
			empty3 = ey.e();
		}
		else
		{
			empty2 = ey.d() + "...";
			empty3 = ey.d();
		}
		f().Text = empty2;
		Text = empty3;
		string A_5;
		if (A_4)
		{
			Label label = d();
			A_5 = "BaselineForcedPromptTextFmt5";
			label.Text = string.Format(hu.a(ref A_5), empty2, A_0, hu.a(ref empty), f().Text, empty2);
			e().Visible = false;
			n().Visible = false;
		}
		else
		{
			Label label2 = d();
			A_5 = "BaselineReminderText";
			label2.Text = string.Format(hu.a(ref A_5), empty2, A_0, hu.a(ref empty), empty2, f().Text, empty2, empty2);
		}
		CheckBox checkBox = k();
		A_5 = "DontRemindMeAgain";
		checkBox.Text = hu.a(ref A_5);
		k().Checked = A_1;
		i().Text = A_0.ToString();
		SuspendLayout();
		TableLayoutPanel tableLayoutPanel = l();
		b().ClientSize = checked(new Size(tableLayoutPanel.Location.X + tableLayoutPanel.Width, tableLayoutPanel.Location.Y + tableLayoutPanel.Height + 30));
		tableLayoutPanel = null;
		ResumeLayout();
		i6.a(A_2, this);
		ShowDialog();
		if (base.DialogResult == DialogResult.OK)
		{
			A_0 = iz.d(i().Text);
			A_1 = k().Checked;
			return (!q) ? bb.a.b : bb.a.c;
		}
		return bb.a.a;
	}

	private void b(object A_0, EventArgs A_1)
	{
		q = false;
		base.DialogResult = DialogResult.OK;
	}

	private void a(object A_0, EventArgs A_1)
	{
		q = true;
		base.DialogResult = DialogResult.OK;
	}
}
