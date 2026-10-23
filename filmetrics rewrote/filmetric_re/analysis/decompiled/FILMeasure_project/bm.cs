using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class bm : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Label m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private TableLayoutPanel m_e;

	[CompilerGenerated]
	private Label m_f;

	[CompilerGenerated]
	private Label m_g;

	[CompilerGenerated]
	private ProgressBar m_h;

	[CompilerGenerated]
	private TableLayoutPanel m_i;

	[CompilerGenerated]
	private TableLayoutPanel m_j;

	[CompilerGenerated]
	private Label m_k;

	private f1 l;

	private f4 m;

	private Guid n;

	private bool o;

	private bool p;

	private fz q;

	public bm()
	{
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
		a(new Label());
		a(new Button());
		b(new Button());
		a(new TableLayoutPanel());
		b(new Label());
		c(new Label());
		a(new ProgressBar());
		b(new TableLayoutPanel());
		c(new TableLayoutPanel());
		d(new Label());
		e().SuspendLayout();
		i().SuspendLayout();
		j().SuspendLayout();
		SuspendLayout();
		b().ImeMode = ImeMode.NoControl;
		b().Location = new Point(4, 0);
		b().Margin = new Padding(4, 0, 4, 0);
		b().Name = "LabelRefRefreshMessage";
		b().Size = new Size(461, 36);
		b().TabIndex = 4;
		b().Text = "RandT Autobaseline Refresh Instructions";
		c().Cursor = Cursors.Default;
		c().DialogResult = DialogResult.Cancel;
		c().Font = new Font("Microsoft Sans Serif", 12f);
		c().ImeMode = ImeMode.NoControl;
		c().Location = new Point(172, 4);
		c().Margin = new Padding(14, 4, 4, 4);
		c().Name = "ButtonCancel";
		c().Size = new Size(109, 29);
		c().TabIndex = 8;
		c().Text = "Cancel";
		c().UseVisualStyleBackColor = true;
		d().Font = new Font("Microsoft Sans Serif", 12f);
		d().ImeMode = ImeMode.NoControl;
		d().Location = new Point(4, 4);
		d().Margin = new Padding(4, 4, 14, 4);
		d().Name = "ButtonStageEmpty";
		d().Size = new Size(140, 29);
		d().TabIndex = 9;
		d().Text = "Stage Is Empty";
		d().UseVisualStyleBackColor = true;
		e().Anchor = AnchorStyles.None;
		e().AutoSize = true;
		e().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		e().ColumnCount = 3;
		e().ColumnStyles.Add(new ColumnStyle());
		e().ColumnStyles.Add(new ColumnStyle());
		e().ColumnStyles.Add(new ColumnStyle());
		e().Controls.Add(f(), 0, 1);
		e().Controls.Add(g(), 1, 1);
		e().Controls.Add(h(), 0, 0);
		e().Location = new Point(109, 55);
		e().Name = "TableLayoutPanel6";
		e().RowCount = 2;
		e().RowStyles.Add(new RowStyle());
		e().RowStyles.Add(new RowStyle());
		e().Size = new Size(251, 44);
		e().TabIndex = 19;
		f().Anchor = AnchorStyles.Right;
		f().AutoSize = true;
		f().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
		f().ImeMode = ImeMode.NoControl;
		f().Location = new Point(4, 27);
		f().Margin = new Padding(4, 0, 4, 0);
		f().Name = "LabelBaselineRefreshStatusLabel";
		f().Size = new Size(55, 16);
		f().TabIndex = 4;
		f().Text = "Status:";
		g().Anchor = AnchorStyles.Left;
		g().BorderStyle = BorderStyle.Fixed3D;
		g().ImeMode = ImeMode.NoControl;
		g().Location = new Point(67, 26);
		g().Margin = new Padding(4, 0, 4, 0);
		g().Name = "LabelRefreshBaselineStatus";
		g().Size = new Size(140, 18);
		g().TabIndex = 5;
		g().Text = "Baseline out of date";
		g().TextAlign = ContentAlignment.MiddleLeft;
		h().Anchor = AnchorStyles.None;
		e().SetColumnSpan(h(), 2);
		h().Location = new Point(3, 3);
		h().Name = "ProgressBarBaselineRefresh";
		h().Size = new Size(245, 20);
		h().TabIndex = 7;
		i().AutoSize = true;
		i().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		i().ColumnCount = 1;
		i().ColumnStyles.Add(new ColumnStyle());
		i().Controls.Add(j(), 0, 3);
		i().Controls.Add(b(), 0, 0);
		i().Controls.Add(e(), 0, 2);
		i().Controls.Add(k(), 0, 1);
		i().Location = new Point(12, 12);
		i().Name = "TableLayoutPanel1";
		i().RowCount = 4;
		i().RowStyles.Add(new RowStyle());
		i().RowStyles.Add(new RowStyle());
		i().RowStyles.Add(new RowStyle());
		i().RowStyles.Add(new RowStyle());
		i().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		i().Size = new Size(469, 155);
		i().TabIndex = 20;
		j().Anchor = AnchorStyles.None;
		j().AutoSize = true;
		j().ColumnCount = 2;
		j().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		j().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		j().Controls.Add(d(), 0, 0);
		j().Controls.Add(c(), 1, 0);
		j().Location = new Point(76, 115);
		j().Margin = new Padding(3, 13, 3, 3);
		j().Name = "TableLayoutPanel2";
		j().RowCount = 1;
		j().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		j().Size = new Size(316, 37);
		j().TabIndex = 21;
		k().Anchor = AnchorStyles.None;
		k().AutoSize = true;
		k().Location = new Point(197, 36);
		k().Name = "LabelWait";
		k().Size = new Size(75, 16);
		k().TabIndex = 22;
		k().Text = "Updating ...";
		k().Visible = false;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = c();
		base.ClientSize = new Size(495, 172);
		base.Controls.Add(i());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogRandTAutoRefRefresh";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Baseline Refresh";
		e().ResumeLayout(performLayout: false);
		e().PerformLayout();
		i().ResumeLayout(performLayout: false);
		i().PerformLayout();
		j().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
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
		this.m_c = A_0;
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
		EventHandler value = a;
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
	internal virtual TableLayoutPanel e()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label f()
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
	internal virtual Label g()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ProgressBar h()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ProgressBar A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel i()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel j()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label k()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_k = A_0;
	}

	public void a(f1 A_0, f4 A_1, fz A_2, Point A_3)
	{
		l = A_0;
		m = A_1;
		q = A_2;
		n = A_1.hc();
		o = false;
		p = false;
		checked
		{
			int num = ((A_3.X + unchecked(base.Width / 2) <= A_1.Size.Width) ? (A_3.X - unchecked(base.Width / 2)) : (A_1.Size.Width - base.Width));
			int num2 = ((A_3.Y + unchecked(base.Height / 2) <= A_1.Size.Height) ? (A_3.Y - unchecked(base.Height / 2)) : (A_1.Size.Height - base.Height));
			base.StartPosition = FormStartPosition.Manual;
			base.Location = new Point(num, num2);
			string A_4 = "AutoBaselineRefNeedsUpdateTitle";
			Text = hu.a(ref A_4);
			Label label = b();
			A_4 = "AutoBaselineRefNeedsUpdateInstructions";
			label.Text = hu.a(ref A_4);
			g().Text = "Baseline out of date";
			ShowDialog();
		}
	}

	public void a(float A_0, bool A_1, bool A_2)
	{
		if (A_1 && p)
		{
			o = true;
		}
		if (o)
		{
			o = false;
			p = false;
			base.DialogResult = DialogResult.OK;
			Close();
		}
		else if (p)
		{
			g().Text = "Baseline out of date";
			if (A_2)
			{
				fe.b(q, "The attempt to refresh the baseline failed. Please try again and if not successful send a technical support request to Filmetrics", "ErrorTitle", i6.a(this));
				o = false;
				p = false;
				base.DialogResult = DialogResult.OK;
				Close();
				q.c(fz.b.b, "Expected number of forced reference iterations were exceeded without updating the reference.");
			}
			else
			{
				h().Value = checked((int)Math.Round(A_0));
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			string A_2 = "";
			k().Visible = true;
			d().Enabled = false;
			c().Enabled = false;
			o = false;
			if (l.m2(n, null, null, "Contact Probe Measuring...", ref A_2, null, null, r.o.c, A_8: false, 0f, 0f, r.d.a.b.a, 0, null, A_14: false, A_15: false, A_16: false, 0) != ce.ErrPublic.None)
			{
				Interaction.MsgBox("Error executing baseline refresh. " + A_2, MsgBoxStyle.OkOnly, Application.CompanyName);
			}
			p = true;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(q, l, m, i6.a(d()), "DialogRandTAutoRefRefresh.ButtonStageEmpty_Click", a_);
			ProjectData.ClearProjectError();
		}
	}
}
