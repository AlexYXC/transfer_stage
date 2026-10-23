using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class dy : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private RichTextBox m_c;

	private const int d = 10;

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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(dy));
		a(new Button());
		a(new RichTextBox());
		SuspendLayout();
		b().Anchor = AnchorStyles.Bottom;
		b().DialogResult = DialogResult.OK;
		b().Location = new Point(246, 350);
		b().Margin = new Padding(4);
		b().Name = "OK_Button";
		b().Size = new Size(89, 28);
		b().TabIndex = 0;
		b().Text = "OK";
		c().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		c().Location = new Point(12, 12);
		c().Name = "RichTextBoxTheText";
		c().Size = new Size(556, 328);
		c().TabIndex = 1;
		c().Text = "";
		base.AcceptButton = b();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(580, 388);
		base.Controls.Add(c());
		base.Controls.Add(b());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.Margin = new Padding(4);
		base.MinimizeBox = false;
		base.Name = "DialogTextViewer";
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Show;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "DialogTextViewer";
		ResumeLayout(performLayout: false);
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
	internal virtual RichTextBox c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(RichTextBox A_0)
	{
		this.m_c = A_0;
	}

	public dy()
	{
		a();
	}

	public void a(string A_0, string A_1, bool A_2)
	{
		string text;
		if (!A_0.StartsWith("{\\rtf1"))
		{
			text = "{\\rtf1\\ansi\\deff0{\\fonttbl{\\f0\\fswiss MS Sans Serif;}{\\f1\\froman\\fcharset2 Symbol;}{\\f2\\froman Times New Roman;}{\\f3\\farial Arial;}}{\\colortbl ;\\red255\\green0\\blue0; \\red0\\green0\\blue255;}";
			text = text + "\\plain\\f3\\fs20 " + A_0.Replace("\r", "\\par ") + "}";
		}
		else
		{
			text = A_0;
		}
		c().Rtf = text;
		Text = A_1;
		if (A_2)
		{
			base.WindowState = FormWindowState.Maximized;
		}
		ShowDialog();
	}
}
