using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class c1 : Form
{
	private delegate void a(string A_0);

	private delegate void b(int A_0);

	private delegate void c(int A_0);

	private delegate void d();

	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private ProgressBar m_c;

	[CompilerGenerated]
	private Label m_d;

	[CompilerGenerated]
	private Timer m_e;

	[CompilerGenerated]
	private TableLayoutPanel f;

	private int m_g;

	private bool m_h;

	private const long m_i = 250L;

	public c1()
	{
		base.FormClosing += a;
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
		a(new Button());
		a(new ProgressBar());
		a(new Label());
		a(new Timer(this.m_a));
		a(new TableLayoutPanel());
		g().SuspendLayout();
		SuspendLayout();
		b().Anchor = AnchorStyles.None;
		b().DialogResult = DialogResult.Cancel;
		b().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b().Location = new Point(137, 131);
		b().Margin = new Padding(3, 0, 3, 10);
		b().Name = "Cancel_Button";
		b().Size = new Size(77, 31);
		b().TabIndex = 1;
		b().Text = "Cancel";
		b().Visible = false;
		c().Anchor = AnchorStyles.None;
		c().Location = new Point(45, 95);
		c().Margin = new Padding(3, 10, 3, 10);
		c().Name = "ProgressBar";
		c().Size = new Size(260, 26);
		c().TabIndex = 1;
		d().Anchor = AnchorStyles.None;
		d().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d().Location = new Point(3, 10);
		d().Margin = new Padding(3, 10, 3, 0);
		d().Name = "WaitMessageLabel";
		d().Size = new Size(345, 75);
		d().TabIndex = 2;
		d().Text = "WaitMessageLabel";
		d().TextAlign = ContentAlignment.MiddleCenter;
		e().Enabled = true;
		e().Interval = 250;
		g().AutoSize = true;
		g().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		g().ColumnCount = 1;
		g().ColumnStyles.Add(new ColumnStyle());
		g().Controls.Add(d(), 0, 0);
		g().Controls.Add(b(), 0, 2);
		g().Controls.Add(c(), 0, 1);
		g().Location = new Point(0, 0);
		g().Name = "TableLayoutPanel1";
		g().RowCount = 3;
		g().RowStyles.Add(new RowStyle());
		g().RowStyles.Add(new RowStyle());
		g().RowStyles.Add(new RowStyle());
		g().Size = new Size(351, 172);
		g().TabIndex = 3;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = b();
		base.ClientSize = new Size(374, 177);
		base.Controls.Add(g());
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogLongStepProgress";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Please Wait ...";
		base.TopMost = true;
		g().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button b()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = b;
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
	internal virtual ProgressBar c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ProgressBar A_0)
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
	internal virtual Timer e()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Timer A_0)
	{
		EventHandler value = a;
		Timer timer = this.m_e;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		this.m_e = A_0;
		timer = this.m_e;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel g()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		f = A_0;
	}

	private void b(object A_0, EventArgs A_1)
	{
		base.DialogResult = DialogResult.Cancel;
		Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		c().Increment(250);
	}

	public void a(string A_0)
	{
		if (base.InvokeRequired)
		{
			Invoke(new a(a), A_0);
		}
		else
		{
			d().Text = A_0;
		}
	}

	[SpecialName]
	public bool h()
	{
		return b().Visible;
	}

	[SpecialName]
	public void a(bool A_0)
	{
		b().Visible = A_0;
	}

	public void a(float A_0, string A_1)
	{
		d().Text = A_1;
		this.m_g = checked((int)Math.Round(1000f * A_0));
		c().Maximum = this.m_g;
		c().Value = 0;
		this.m_h = false;
		Show();
	}

	public void a(int A_0, string A_1)
	{
		e().Enabled = false;
		d().Text = A_1;
		c().Maximum = A_0;
		c().Value = 0;
		this.m_h = false;
		Show();
	}

	public void b(string A_0)
	{
		e().Enabled = false;
		d().Text = A_0;
		c().Value = 0;
		this.m_h = false;
		ShowDialog();
	}

	public void a(int A_0)
	{
		if (base.InvokeRequired)
		{
			Invoke(new b(a), A_0);
		}
		else
		{
			c().Maximum = A_0;
		}
	}

	public void b(int A_0)
	{
		if (base.InvokeRequired)
		{
			try
			{
				Invoke(new c(b), A_0);
				return;
			}
			catch (ObjectDisposedException ex2)
			{
				ProjectData.SetProjectError(ex2);
				ObjectDisposedException ex3 = ex2;
				ProjectData.ClearProjectError();
				return;
			}
		}
		c().Value = A_0;
	}

	public void c(string A_0)
	{
		d().Text = A_0;
		c().Visible = false;
		this.m_h = false;
		ShowDialog();
	}

	public void d(string A_0)
	{
		d().Text = A_0;
		c().Visible = false;
		this.m_h = false;
		Show();
		Refresh();
	}

	public void i()
	{
		if (base.InvokeRequired)
		{
			try
			{
				Invoke(new d(i));
				return;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				ProjectData.ClearProjectError();
				return;
			}
		}
		this.m_h = true;
		base.DialogResult = DialogResult.OK;
		Close();
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		if (!this.m_h)
		{
			base.DialogResult = DialogResult.Cancel;
		}
	}
}
