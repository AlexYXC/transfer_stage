using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class co : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private ProgressBar m_c;

	[CompilerGenerated]
	private Label m_d;

	[CompilerGenerated]
	private Timer m_e;

	private const int m_f = 5000;

	private const long g = 250L;

	protected bool h;

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
		b(new Timer(this.m_a));
		SuspendLayout();
		c().DialogResult = DialogResult.Cancel;
		c().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c().Location = new Point(249, 91);
		c().Margin = new Padding(4);
		c().Name = "ButtonCancel";
		c().Size = new Size(89, 28);
		c().TabIndex = 1;
		c().Text = "Cancel";
		d().Location = new Point(12, 50);
		d().Name = "ProgressBarWait";
		d().Size = new Size(563, 23);
		d().TabIndex = 2;
		e().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		e().Location = new Point(12, 9);
		e().Name = "LabelMessage";
		e().Size = new Size(563, 21);
		e().TabIndex = 3;
		e().Text = "LabelMessage";
		e().TextAlign = ContentAlignment.MiddleCenter;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = c();
		base.ClientSize = new Size(587, 136);
		base.Controls.Add(e());
		base.Controls.Add(d());
		base.Controls.Add(c());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogCancellableWait";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.Manual;
		Text = "Wait Status Title";
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button c()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ProgressBar d()
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
	internal virtual Label e()
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
	internal virtual Timer f()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Timer A_0)
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

	private void a(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				d().Increment(250);
				if (d().Value >= d().Maximum)
				{
					if (d().Maximum >= 1073741823)
					{
						base.DialogResult = DialogResult.Cancel;
					}
					else
					{
						d().Maximum *= 2;
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				ProjectData.ClearProjectError();
			}
		}
	}

	public co()
	{
		base.FormClosing += a;
		a();
		f().Interval = 250;
		d().Maximum = 5000;
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		try
		{
			f().Stop();
			h = true;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}
}
