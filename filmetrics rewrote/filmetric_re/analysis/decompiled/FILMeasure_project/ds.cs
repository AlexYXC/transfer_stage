using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class ds : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private WebBrowser m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private hx m_e;

	private fz f;

	private f1 g;

	private f4 h;

	private const string i = "DialogShowHtml";

	public ds()
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
		a(new WebBrowser());
		b(new Button());
		a(new hx());
		SuspendLayout();
		b().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		b().DialogResult = DialogResult.OK;
		b().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b().Location = new Point(772, 453);
		b().Name = "ButtonClose";
		b().Size = new Size(67, 28);
		b().TabIndex = 1;
		b().Text = "Close";
		c().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		c().Location = new Point(12, 37);
		c().MinimumSize = new Size(20, 20);
		c().Name = "WebBrowserMain";
		c().Size = new Size(827, 406);
		c().TabIndex = 2;
		d().Anchor = AnchorStyles.Top | AnchorStyles.Right;
		d().AutoSize = true;
		d().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		d().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d().Location = new Point(810, 9);
		d().Name = "ButtonGo";
		d().Size = new Size(36, 26);
		d().TabIndex = 4;
		d().Text = "Go";
		e().Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		e().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e().Location = new Point(12, 11);
		e().Name = "TextBoxUrl";
		e().Size = new Size(792, 22);
		e().TabIndex = 3;
		base.AcceptButton = d();
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = b();
		base.ClientSize = new Size(851, 493);
		base.Controls.Add(d());
		base.Controls.Add(e());
		base.Controls.Add(c());
		base.Controls.Add(b());
		base.MinimizeBox = false;
		base.Name = "DialogShowHtml";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Browser Dialog";
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
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual WebBrowser c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(WebBrowser A_0)
	{
		WebBrowserNavigatedEventHandler value = a;
		WebBrowser webBrowser = this.m_c;
		if (webBrowser != null)
		{
			webBrowser.Navigated -= value;
		}
		this.m_c = A_0;
		webBrowser = this.m_c;
		if (webBrowser != null)
		{
			webBrowser.Navigated += value;
		}
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
	internal virtual hx e()
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

	public void a(fz A_0, f1 A_1, f4 A_2, string A_3)
	{
		string text = null;
		try
		{
			f = A_0;
			g = A_1;
			h = A_2;
			text = global::c.e().FileSystem.SpecialDirectories.Temp + "\\" + Guid.NewGuid().ToString() + ".htm";
			File.WriteAllText(text, A_3, Encoding.UTF8);
			c().Navigate(text);
			ShowDialog();
		}
		finally
		{
			if (File.Exists(text))
			{
				File.Delete(text);
			}
		}
	}

	private void a(object A_0, WebBrowserNavigatedEventArgs A_1)
	{
		try
		{
			e().Text = c().Url.ToString();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(f, g, h, i6.a(this), "DialogShowHtml.DataGridViewAttributes_CellEnter", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			c().Navigate(e().Text);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(f, g, h, i6.a(this), "DialogShowHtml.DataGridViewAttributes_CellEnter", a_);
			ProjectData.ClearProjectError();
		}
	}
}
