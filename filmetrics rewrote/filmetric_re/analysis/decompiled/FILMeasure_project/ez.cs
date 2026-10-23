using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class ez : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private ComboBox m_c;

	[CompilerGenerated]
	private Label m_d;

	[CompilerGenerated]
	private Button m_e;

	public ez()
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
		a(new ComboBox());
		a(new Label());
		b(new Button());
		SuspendLayout();
		b().DialogResult = DialogResult.OK;
		b().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b().Location = new Point(27, 109);
		b().Margin = new Padding(4, 4, 4, 4);
		b().Name = "ButtonOK";
		b().Size = new Size(110, 33);
		b().TabIndex = 2;
		b().Text = "OK";
		b().UseVisualStyleBackColor = true;
		c().DropDownStyle = ComboBoxStyle.DropDownList;
		c().FormattingEnabled = true;
		c().Location = new Point(13, 46);
		c().Margin = new Padding(4, 4, 4, 4);
		c().Name = "ComboBoxDataNames";
		c().Size = new Size(257, 24);
		c().TabIndex = 0;
		d().AutoSize = true;
		d().Location = new Point(56, 21);
		d().Name = "Label1";
		d().Size = new Size(170, 16);
		d().TabIndex = 3;
		d().Text = "Please select data to save:";
		e().DialogResult = DialogResult.Cancel;
		e().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e().Location = new Point(145, 109);
		e().Margin = new Padding(4);
		e().Name = "ButtonCancel";
		e().Size = new Size(110, 33);
		e().TabIndex = 4;
		e().Text = "Cancel";
		e().UseVisualStyleBackColor = true;
		base.AcceptButton = b();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = e();
		base.ClientSize = new Size(283, 157);
		base.Controls.Add(e());
		base.Controls.Add(d());
		base.Controls.Add(c());
		base.Controls.Add(b());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4, 4, 4, 4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogSaveWhich";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		Text = "Vs Time Data Selection";
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
	internal virtual ComboBox c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
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

	public void a(List<string> A_0, int A_1, ref int A_2)
	{
		c().Items.AddRange(A_0.ToArray());
		if (A_1 >= 0)
		{
			c().SelectedIndex = A_1;
		}
		else
		{
			c().SelectedIndex = 0;
		}
		if (ShowDialog() == DialogResult.OK)
		{
			A_2 = c().SelectedIndex;
		}
	}
}
