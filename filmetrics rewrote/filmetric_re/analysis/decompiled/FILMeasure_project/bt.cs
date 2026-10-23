using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class bt : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private ProgressBar m_b;

	[CompilerGenerated]
	private Label m_c;

	[CompilerGenerated]
	private Timer m_d;

	[CompilerGenerated]
	private Button m_e;

	[CompilerGenerated]
	private TableLayoutPanel m_f;

	private const int g = 200;

	private bool h;

	private ix.b i;

	public bt()
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
		this.m_a = new Container();
		a(new ProgressBar());
		a(new Label());
		a(new Timer(this.m_a));
		a(new Button());
		a(new TableLayoutPanel());
		f().SuspendLayout();
		SuspendLayout();
		b().Anchor = AnchorStyles.None;
		b().Location = new Point(4, 40);
		b().Margin = new Padding(4, 4, 4, 18);
		b().Name = "WaitRestartProgressBar";
		b().Size = new Size(373, 28);
		b().TabIndex = 0;
		c().Anchor = AnchorStyles.None;
		c().AutoSize = true;
		c().Location = new Point(65, 10);
		c().Margin = new Padding(4, 10, 4, 10);
		c().Name = "LabelWaitMessage";
		c().Size = new Size(250, 16);
		c().TabIndex = 1;
		c().Text = "Please wait while hardware is restarted ...";
		d().Interval = 50;
		e().Anchor = AnchorStyles.None;
		e().Location = new Point(140, 90);
		e().Margin = new Padding(4);
		e().Name = "ButtonCancel";
		e().Size = new Size(100, 28);
		e().TabIndex = 2;
		e().Text = "Cancel";
		e().UseVisualStyleBackColor = true;
		e().Visible = false;
		f().AutoSize = true;
		f().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		f().ColumnCount = 1;
		f().ColumnStyles.Add(new ColumnStyle());
		f().Controls.Add(c(), 0, 0);
		f().Controls.Add(b(), 0, 1);
		f().Controls.Add(e(), 0, 2);
		f().Location = new Point(12, 12);
		f().Name = "TableLayoutPanel1";
		f().RowCount = 3;
		f().RowStyles.Add(new RowStyle());
		f().RowStyles.Add(new RowStyle());
		f().RowStyles.Add(new RowStyle());
		f().Size = new Size(381, 122);
		f().TabIndex = 3;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CausesValidation = false;
		base.ClientSize = new Size(406, 134);
		base.Controls.Add(f());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogWaitRestart";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Hardware Restart";
		base.TopMost = true;
		f().ResumeLayout(performLayout: false);
		f().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ProgressBar b()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ProgressBar A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer d()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Timer A_0)
	{
		EventHandler value = b;
		Timer timer = this.m_d;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		this.m_d = A_0;
		timer = this.m_d;
		if (timer != null)
		{
			timer.Tick += value;
		}
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
		EventHandler value = a;
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
	internal virtual TableLayoutPanel f()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_f = A_0;
	}

	public void a(string A_0, string A_1, float A_2, ix.b A_3)
	{
		h = false;
		i = A_3;
		e().Visible = false;
		Text = A_0;
		b().Value = 0;
		c().Text = A_1;
		d().Interval = 200;
		b().Maximum = checked((int)Math.Round(1000f * A_2));
		d().Start();
		ShowDialog();
	}

	private void b(object A_0, EventArgs A_1)
	{
		b().Increment(200);
		if (b().Value >= b().Maximum || i.a)
		{
			Close();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		Close();
	}
}
