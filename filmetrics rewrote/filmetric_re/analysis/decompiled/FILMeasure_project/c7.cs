using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class c7 : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private TableLayoutPanel m_b;

	[CompilerGenerated]
	private TableLayoutPanel m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private Button m_e;

	[CompilerGenerated]
	private TextBox m_f;

	public c7()
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
		a(new TableLayoutPanel());
		b(new TableLayoutPanel());
		a(new Button());
		b(new Button());
		a(new TextBox());
		b().SuspendLayout();
		c().SuspendLayout();
		SuspendLayout();
		b().AutoSize = true;
		b().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		b().ColumnCount = 1;
		b().ColumnStyles.Add(new ColumnStyle());
		b().Controls.Add(c(), 0, 1);
		b().Controls.Add(f(), 0, 0);
		b().Location = new Point(16, 15);
		b().Margin = new Padding(4);
		b().Name = "TableLayoutPanel1";
		b().RowCount = 2;
		b().RowStyles.Add(new RowStyle());
		b().RowStyles.Add(new RowStyle());
		b().Size = new Size(436, 205);
		b().TabIndex = 0;
		c().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		c().AutoSize = true;
		c().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		c().ColumnCount = 2;
		c().ColumnStyles.Add(new ColumnStyle());
		c().ColumnStyles.Add(new ColumnStyle());
		c().Controls.Add(d(), 0, 0);
		c().Controls.Add(e(), 1, 0);
		c().Location = new Point(192, 158);
		c().Margin = new Padding(4);
		c().Name = "TableLayoutPanel2";
		c().RowCount = 1;
		c().RowStyles.Add(new RowStyle());
		c().Size = new Size(240, 43);
		c().TabIndex = 0;
		d().DialogResult = DialogResult.OK;
		d().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d().Location = new Point(4, 4);
		d().Margin = new Padding(4);
		d().Name = "ButtonOK";
		d().Size = new Size(112, 35);
		d().TabIndex = 0;
		d().Text = "OK";
		d().UseVisualStyleBackColor = true;
		e().DialogResult = DialogResult.Cancel;
		e().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e().Location = new Point(124, 4);
		e().Margin = new Padding(4);
		e().Name = "ButtonCancel";
		e().Size = new Size(112, 35);
		e().TabIndex = 1;
		e().Text = "Cancel";
		e().UseVisualStyleBackColor = true;
		f().Anchor = AnchorStyles.None;
		f().Location = new Point(4, 4);
		f().Margin = new Padding(4);
		f().Multiline = true;
		f().Name = "TextBoxNote";
		f().Size = new Size(428, 146);
		f().TabIndex = 1;
		base.AcceptButton = d();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = e();
		base.ClientSize = new Size(465, 232);
		base.Controls.Add(b());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogMesaReportNote";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Note Text";
		b().ResumeLayout(performLayout: false);
		b().PerformLayout();
		c().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel b()
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
	internal virtual TableLayoutPanel c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
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
	internal virtual void a(Button A_0)
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
	internal virtual void b(Button A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox f()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TextBox A_0)
	{
		this.m_f = A_0;
	}

	public void a(string A_0)
	{
		if (A_0 == null)
		{
			A_0 = string.Empty;
		}
		f().Text = A_0;
		ShowDialog();
	}
}
