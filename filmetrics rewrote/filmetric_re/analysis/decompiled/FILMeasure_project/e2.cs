using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Filmetrics.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal sealed class e2 : Form
{
	[CompilerGenerated]
	private Label m_a;

	[CompilerGenerated]
	private Label m_b;

	[CompilerGenerated]
	private TableLayoutPanel m_c;

	[CompilerGenerated]
	private TableLayoutPanel m_d;

	private IContainer m_e;

	[CompilerGenerated]
	private Label m_f;

	public e2()
	{
		base.Load += c;
		base.Activated += b;
		a();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.m_e != null)
			{
				this.m_e.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b()
	{
		return this.m_a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_a = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel d()
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
	internal virtual TableLayoutPanel e()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_d = A_0;
	}

	[DebuggerStepThrough]
	private void a()
	{
		a(new TableLayoutPanel());
		b(new TableLayoutPanel());
		a(new Label());
		b(new Label());
		c(new Label());
		d().SuspendLayout();
		e().SuspendLayout();
		SuspendLayout();
		d().BackgroundImage = Resources.SplashPic;
		d().BackgroundImageLayout = ImageLayout.Stretch;
		d().ColumnCount = 2;
		d().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243f));
		d().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 253f));
		d().Controls.Add(e(), 1, 1);
		d().Controls.Add(f(), 1, 0);
		d().Dock = DockStyle.Fill;
		d().Location = new Point(0, 0);
		d().Name = "MainLayoutPanel";
		d().RowStyles.Add(new RowStyle(SizeType.Absolute, 218f));
		d().RowStyles.Add(new RowStyle(SizeType.Absolute, 38f));
		d().Size = new Size(496, 303);
		d().TabIndex = 0;
		e().Anchor = AnchorStyles.None;
		e().BackColor = Color.Transparent;
		e().ColumnCount = 1;
		e().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 247f));
		e().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142f));
		e().Controls.Add(b(), 0, 0);
		e().Controls.Add(c(), 0, 1);
		e().Location = new Point(246, 221);
		e().Name = "DetailsLayoutPanel";
		e().RowStyles.Add(new RowStyle(SizeType.Percent, 33f));
		e().RowStyles.Add(new RowStyle(SizeType.Percent, 33f));
		e().Size = new Size(247, 79);
		e().TabIndex = 1;
		b().Anchor = AnchorStyles.None;
		b().BackColor = Color.Transparent;
		b().Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b().Location = new Point(3, 9);
		b().Name = "Version";
		b().Size = new Size(241, 20);
		b().TabIndex = 1;
		b().Text = "Version {0}.{1}.{2} Rev. {3}";
		c().Anchor = AnchorStyles.None;
		c().BackColor = Color.Transparent;
		c().Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c().Location = new Point(3, 39);
		c().Name = "Copyright";
		c().Size = new Size(241, 40);
		c().TabIndex = 2;
		c().Text = "Copyright";
		f().BackColor = Color.Transparent;
		f().Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f().Location = new Point(246, 0);
		f().Name = "ApplicationTitle";
		f().Size = new Size(247, 212);
		f().TabIndex = 0;
		f().Text = "ApplicationTitle";
		f().TextAlign = ContentAlignment.BottomLeft;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(496, 303);
		base.ControlBox = false;
		base.Controls.Add(d());
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "SplashScreenFILMeasure";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		d().ResumeLayout(performLayout: false);
		e().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
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
	internal virtual void c(Label A_0)
	{
		EventHandler value = a;
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

	private void c(object A_0, EventArgs A_1)
	{
		if (Operators.CompareString(global::c.d().Info.Title, "", TextCompare: false) != 0)
		{
			f().Text = global::c.d().Info.Title;
		}
		else
		{
			f().Text = Path.GetFileNameWithoutExtension(global::c.d().Info.AssemblyName);
		}
		if (!string.IsNullOrEmpty(global::c.d().w()))
		{
			f().Text = f().Text.Replace("FIL", global::c.d().w());
		}
		b().Text = string.Format(b().Text, global::c.d().Info.Version.Major, global::c.d().Info.Version.Minor, global::c.d().Info.Version.Build, global::c.d().Info.Version.Revision);
		if (global::c.d().y())
		{
			string text = global::c.d().Info.Copyright;
			if (text.ToLower().Contains("all rights reserved"))
			{
				int num = text.ToLower().IndexOf("all rights reserved");
				text = text.Substring(0, num) + "\r" + text.Substring(num);
			}
			c().Text = text;
		}
		else
		{
			c().Text = "";
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		Refresh();
	}

	private void a(object A_0, EventArgs A_1)
	{
	}
}
