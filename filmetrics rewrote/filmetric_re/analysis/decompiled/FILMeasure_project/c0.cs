using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class c0 : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private TableLayoutPanel m_c;

	[CompilerGenerated]
	private Label d;

	private bool e;

	private bool m_f;

	public c0()
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
		a(new Button());
		a(new TableLayoutPanel());
		a(new Label());
		c().SuspendLayout();
		SuspendLayout();
		b().Anchor = AnchorStyles.Bottom;
		b().AutoSize = true;
		b().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b().Location = new Point(14, 30);
		b().Margin = new Padding(4);
		b().Name = "TheButton";
		b().Size = new Size(161, 30);
		b().TabIndex = 0;
		b().Text = "Cancel";
		b().UseVisualStyleBackColor = true;
		c().AutoSize = true;
		c().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		c().ColumnCount = 1;
		c().ColumnStyles.Add(new ColumnStyle());
		c().Controls.Add(b(), 0, 1);
		c().Controls.Add(f(), 0, 0);
		c().Location = new Point(0, 0);
		c().Name = "TableLayoutPanel1";
		c().Padding = new Padding(10);
		c().RowCount = 2;
		c().RowStyles.Add(new RowStyle());
		c().RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		c().Size = new Size(189, 74);
		c().TabIndex = 1;
		f().Anchor = AnchorStyles.None;
		f().AutoSize = true;
		f().Location = new Point(70, 10);
		f().Name = "TheLabel";
		f().Size = new Size(49, 16);
		f().TabIndex = 1;
		f().Text = "Label1";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.ClientSize = new Size(206, 83);
		base.ControlBox = false;
		base.Controls.Add(c());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogLegacyStatus";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Status";
		base.TopMost = true;
		c().ResumeLayout(performLayout: false);
		c().PerformLayout();
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
		EventHandler value = a;
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
	internal virtual TableLayoutPanel c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label f()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		d = A_0;
	}

	public void a(bool A_0)
	{
		a(A_0, "Cancel");
	}

	public void a(bool A_0, string A_1)
	{
		if (A_0)
		{
			b().Text = A_1;
		}
		b().Visible = A_0;
	}

	[SpecialName]
	public bool g()
	{
		return e;
	}

	[SpecialName]
	public bool h()
	{
		return this.m_f;
	}

	public void a(string A_0)
	{
		f().Text = A_0;
	}

	public void b(string A_0)
	{
		f().Text = A_0;
		this.m_f = true;
		Show();
	}

	public void i()
	{
		this.m_f = false;
		Hide();
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			e = true;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			Interaction.MsgBox("Error in DialogLegacyStatus.TheButton_Click");
			ProjectData.ClearProjectError();
		}
	}
}
