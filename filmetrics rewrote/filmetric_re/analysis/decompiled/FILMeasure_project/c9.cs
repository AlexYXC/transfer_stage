using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class c9 : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private TableLayoutPanel m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private Label m_e;

	[CompilerGenerated]
	private hx m_f;

	[CompilerGenerated]
	private hx m_g;

	[CompilerGenerated]
	private Label m_h;

	[CompilerGenerated]
	private Label m_i;

	[CompilerGenerated]
	private hx m_j;

	[CompilerGenerated]
	private TableLayoutPanel m_k;

	[CompilerGenerated]
	private TableLayoutPanel m_l;

	[CompilerGenerated]
	private TableLayoutPanel m_m;

	[CompilerGenerated]
	private CheckBox m_n;

	[CompilerGenerated]
	private Label m_o;

	[CompilerGenerated]
	private Button m_p;

	[CompilerGenerated]
	private TextBox m_q;

	private fz m_r;

	private f1 s;

	private b2 t;

	private Guid u;

	private fl v;

	private const string w = "DialogMonitorChartSettingsDetails";

	private static c9 x = null;

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
		b(new Label());
		c(new Label());
		b(new TableLayoutPanel());
		c(new TableLayoutPanel());
		d(new TableLayoutPanel());
		c(new Button());
		a(new TextBox());
		d(new Label());
		a(new CheckBox());
		c(new hx());
		a(new hx());
		b(new hx());
		c().SuspendLayout();
		l().SuspendLayout();
		m().SuspendLayout();
		n().SuspendLayout();
		SuspendLayout();
		c().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		c().ColumnCount = 2;
		c().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		c().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		c().Controls.Add(d(), 0, 0);
		c().Controls.Add(e(), 1, 0);
		c().Location = new Point(140, 194);
		c().Margin = new Padding(4, 8, 4, 4);
		c().Name = "TableLayoutPanel1";
		c().RowCount = 1;
		c().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		c().Size = new Size(195, 36);
		c().TabIndex = 0;
		d().Anchor = AnchorStyles.None;
		d().AutoSize = true;
		d().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d().Location = new Point(4, 4);
		d().Margin = new Padding(4);
		d().Name = "ButtonOK";
		d().Size = new Size(89, 28);
		d().TabIndex = 0;
		d().Text = "OK";
		e().Anchor = AnchorStyles.None;
		e().AutoSize = true;
		e().DialogResult = DialogResult.Cancel;
		e().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e().Location = new Point(101, 4);
		e().Margin = new Padding(4);
		e().Name = "ButtonCancel";
		e().Size = new Size(89, 28);
		e().TabIndex = 1;
		e().Text = "Cancel";
		f().Anchor = AnchorStyles.Right;
		f().AutoSize = true;
		f().ImeMode = ImeMode.NoControl;
		f().Location = new Point(50, 6);
		f().Margin = new Padding(3, 0, 2, 0);
		f().Name = "Label8";
		f().Size = new Size(52, 16);
		f().TabIndex = 59;
		f().Text = "Range:";
		f().TextAlign = ContentAlignment.MiddleRight;
		i().Anchor = AnchorStyles.Right;
		i().AutoSize = true;
		i().ImeMode = ImeMode.NoControl;
		i().Location = new Point(51, 34);
		i().Margin = new Padding(3, 0, 2, 0);
		i().Name = "Label9";
		i().Size = new Size(51, 16);
		i().TabIndex = 61;
		i().Text = "Target:";
		i().TextAlign = ContentAlignment.MiddleRight;
		j().Anchor = AnchorStyles.Right;
		j().AutoSize = true;
		j().ImeMode = ImeMode.NoControl;
		j().Location = new Point(3, 62);
		j().Margin = new Padding(3, 0, 2, 0);
		j().Name = "Label3";
		j().Size = new Size(99, 16);
		j().TabIndex = 63;
		j().Text = "Duration (Sec.):";
		j().TextAlign = ContentAlignment.MiddleRight;
		l().Anchor = AnchorStyles.None;
		l().AutoSize = true;
		l().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		l().ColumnCount = 2;
		l().ColumnStyles.Add(new ColumnStyle());
		l().ColumnStyles.Add(new ColumnStyle());
		l().Controls.Add(f(), 0, 0);
		l().Controls.Add(k(), 1, 2);
		l().Controls.Add(j(), 0, 2);
		l().Controls.Add(g(), 1, 0);
		l().Controls.Add(i(), 0, 1);
		l().Controls.Add(h(), 1, 1);
		l().Location = new Point(75, 3);
		l().Name = "TableLayoutPanel2";
		l().RowCount = 3;
		l().RowStyles.Add(new RowStyle());
		l().RowStyles.Add(new RowStyle());
		l().RowStyles.Add(new RowStyle());
		l().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		l().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		l().Size = new Size(189, 84);
		l().TabIndex = 65;
		m().AutoSize = true;
		m().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		m().ColumnCount = 1;
		m().ColumnStyles.Add(new ColumnStyle());
		m().Controls.Add(n(), 0, 2);
		m().Controls.Add(o(), 0, 1);
		m().Controls.Add(l(), 0, 0);
		m().Controls.Add(c(), 0, 3);
		m().Location = new Point(0, 0);
		m().Name = "TableLayoutPanel3";
		m().RowCount = 4;
		m().RowStyles.Add(new RowStyle());
		m().RowStyles.Add(new RowStyle());
		m().RowStyles.Add(new RowStyle());
		m().RowStyles.Add(new RowStyle());
		m().Size = new Size(339, 234);
		m().TabIndex = 66;
		n().AutoSize = true;
		n().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		n().ColumnCount = 2;
		n().ColumnStyles.Add(new ColumnStyle());
		n().ColumnStyles.Add(new ColumnStyle());
		n().Controls.Add(q(), 0, 1);
		n().Controls.Add(r(), 1, 0);
		n().Controls.Add(p(), 0, 0);
		n().Location = new Point(3, 119);
		n().Name = "TableLayoutPanel4";
		n().RowCount = 2;
		n().RowStyles.Add(new RowStyle());
		n().RowStyles.Add(new RowStyle());
		n().Size = new Size(333, 64);
		n().TabIndex = 67;
		q().Anchor = AnchorStyles.None;
		q().AutoSize = true;
		q().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		n().SetColumnSpan(q(), 2);
		q().Enabled = false;
		q().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		q().Location = new Point(124, 31);
		q().Name = "ButtonBrowse";
		q().Size = new Size(84, 30);
		q().TabIndex = 68;
		q().Text = "Browse...";
		q().UseVisualStyleBackColor = true;
		r().Anchor = AnchorStyles.None;
		r().Enabled = false;
		r().Location = new Point(68, 3);
		r().Margin = new Padding(0, 3, 3, 3);
		r().Name = "TextBoxAutoSaveRoot";
		r().Size = new Size(262, 22);
		r().TabIndex = 68;
		p().Anchor = AnchorStyles.Right;
		p().AutoSize = true;
		p().ImeMode = ImeMode.NoControl;
		p().Location = new Point(3, 6);
		p().Margin = new Padding(3, 0, 2, 0);
		p().Name = "Label1";
		p().Size = new Size(63, 16);
		p().TabIndex = 60;
		p().Text = "File Path:";
		p().TextAlign = ContentAlignment.MiddleRight;
		o().Anchor = AnchorStyles.None;
		o().AutoSize = true;
		o().Location = new Point(84, 93);
		o().Name = "CheckBoxAutoSave";
		o().Size = new Size(170, 20);
		o().TabIndex = 68;
		o().Text = "Automatically save data";
		o().UseVisualStyleBackColor = true;
		k().Anchor = AnchorStyles.None;
		k().Location = new Point(104, 59);
		k().Margin = new Padding(0, 3, 0, 3);
		k().Name = "TextBoxDuration";
		k().Size = new Size(85, 22);
		k().TabIndex = 64;
		g().Anchor = AnchorStyles.None;
		g().Location = new Point(104, 3);
		g().Margin = new Padding(0, 3, 0, 3);
		g().Name = "TextBoxRange";
		g().Size = new Size(85, 22);
		g().TabIndex = 60;
		h().Anchor = AnchorStyles.None;
		h().Location = new Point(104, 31);
		h().Margin = new Padding(0, 3, 0, 3);
		h().Name = "TextBoxTarget";
		h().Size = new Size(85, 22);
		h().TabIndex = 62;
		base.AcceptButton = d();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = e();
		base.ClientSize = new Size(347, 242);
		base.Controls.Add(m());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogMonitorChartSettingsDetails";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.Manual;
		Text = "Settings Details";
		base.TopMost = true;
		c().ResumeLayout(performLayout: false);
		c().PerformLayout();
		l().ResumeLayout(performLayout: false);
		l().PerformLayout();
		m().ResumeLayout(performLayout: false);
		m().PerformLayout();
		n().ResumeLayout(performLayout: false);
		n().PerformLayout();
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
	internal virtual Button e()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = b;
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
	internal virtual Label f()
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
	internal virtual hx g()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hx A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx h()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(hx A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label i()
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
	internal virtual Label j()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
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
	internal virtual TableLayoutPanel l()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel m()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel n()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TableLayoutPanel A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox o()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(CheckBox A_0)
	{
		EventHandler value = a;
		CheckBox checkBox = this.m_n;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_n = A_0;
		checkBox = this.m_n;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label p()
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
	internal virtual Button q()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = c;
		Button button = this.m_p;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_p = A_0;
		button = this.m_p;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox r()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TextBox A_0)
	{
		this.m_q = A_0;
	}

	public c9(fz A_0)
	{
		base.FormClosing += a;
		b();
		this.m_r = A_0;
	}

	public static c9 a(fz A_0)
	{
		if (x == null)
		{
			x = new c9(A_0);
		}
		return x;
	}

	public static void a()
	{
		x = null;
	}

	public void a(fz A_0, f1 A_1, b2 A_2, Guid A_3, ref string A_4, ref string A_5, ref string A_6, fl A_7, Point A_8)
	{
		s = A_1;
		this.m_r = A_0;
		t = A_2;
		u = A_3;
		v = A_7;
		g().Text = A_4;
		h().Text = A_5;
		k().Text = A_6;
		o().Checked = s.we(u);
		r().Text = s.wf(u);
		i6.a(A_8, this);
		BringToFront();
		Show();
	}

	public static void a(fl A_0)
	{
		double num = global::e.a().GraphStripChartDurationSecs;
		fl fl2 = A_0;
		double num2 = fl2.fa();
		double num3 = fl2.gi().a2().aq();
		if (num2 > num3 || num2 < 0.6699999999999999 * num3)
		{
			fr obj = fl2.gi().a2();
			double num4 = num2 - num * 0.8;
			if (num4 < 0.0)
			{
				num4 = 0.0;
			}
			obj.am(num4);
			obj.an(num4 + num);
			_ = null;
		}
		fl2 = null;
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			if (o().Checked)
			{
				string A_2 = string.Empty;
				string text = r().Text;
				if (string.IsNullOrEmpty(text))
				{
					fe.b(this.m_r, "Please specify a filename and location to save the data or else uncheck " + o().Text, i6.a(d()));
					return;
				}
				if (!gx.j(text, ref A_2))
				{
					fe.b(this.m_r, A_2, i6.a(d()));
					return;
				}
			}
			global::e.a().GraphStripChartDurationSecs = iz.e(k().Text);
			fu obj = v.gi();
			obj.am(A_0: false);
			double num = iz.e(g().Text);
			double num2 = iz.e(h().Text);
			obj.am(A_0: false, num2 + num / 2.0);
			obj.am(num2 - num / 2.0);
			_ = null;
			a(v);
			s.sm(u, o().Checked);
			s.m2(u, r().Text);
			Close();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_r, s, null, i6.a(d()), "DialogMonitorChartSettingsDetails.ButtonOK_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			string text = r().Text;
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (!string.IsNullOrEmpty(text))
			{
				string A_2 = null;
				if (gx.j(text, ref A_2))
				{
					saveFileDialog.FileName = text;
				}
			}
			saveFileDialog.Filter = t.b();
			saveFileDialog.OverwritePrompt = false;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				r().Text = t.a(saveFileDialog.FileName, saveFileDialog.FilterIndex);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_r, s, null, i6.a(q()), "DialogMonitorChartSettingsDetails.ButtonBrowse_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			Close();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_r, s, null, i6.a(q()), "DialogMonitorChartSettingsDetails.ButtonCancel_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			r().Enabled = o().Checked;
			q().Enabled = o().Checked;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_r, s, null, i6.a(q()), "DialogMonitorChartSettingsDetails.CheckBoxAutoSave_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		a();
	}
}
