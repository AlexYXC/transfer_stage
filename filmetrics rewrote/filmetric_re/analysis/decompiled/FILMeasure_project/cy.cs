using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class cy : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private TableLayoutPanel m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private ComboBox m_e;

	[CompilerGenerated]
	private Label m_f;

	[CompilerGenerated]
	private TextBox m_g;

	[CompilerGenerated]
	private Label m_h;

	[CompilerGenerated]
	private Label m_i;

	[CompilerGenerated]
	private TextBox m_j;

	public cy()
	{
		a();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_a != null)
		{
			this.m_a.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void a()
	{
		a(new TableLayoutPanel());
		a(new Button());
		b(new Button());
		a(new ComboBox());
		a(new Label());
		a(new TextBox());
		b(new Label());
		c(new Label());
		b(new TextBox());
		b().SuspendLayout();
		SuspendLayout();
		b().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		b().ColumnCount = 2;
		b().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		b().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		b().Controls.Add(c(), 0, 0);
		b().Controls.Add(d(), 1, 0);
		b().Location = new Point(140, 237);
		b().Margin = new Padding(4);
		b().Name = "TableLayoutPanel1";
		b().RowCount = 1;
		b().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		b().Size = new Size(195, 36);
		b().TabIndex = 0;
		c().Anchor = AnchorStyles.None;
		c().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c().Location = new Point(4, 4);
		c().Margin = new Padding(4);
		c().Name = "OK_Button";
		c().Size = new Size(89, 28);
		c().TabIndex = 0;
		c().Text = "OK";
		d().Anchor = AnchorStyles.None;
		d().DialogResult = DialogResult.Cancel;
		d().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d().Location = new Point(101, 4);
		d().Margin = new Padding(4);
		d().Name = "Cancel_Button";
		d().Size = new Size(89, 28);
		d().TabIndex = 1;
		d().Text = "Cancel";
		e().DropDownStyle = ComboBoxStyle.DropDownList;
		e().FormattingEnabled = true;
		e().Location = new Point(127, 28);
		e().Name = "ComboBoxNkLayer";
		e().Size = new Size(148, 24);
		e().TabIndex = 1;
		f().AutoSize = true;
		f().Location = new Point(76, 31);
		f().Name = "Label1";
		f().Size = new Size(45, 16);
		f().TabIndex = 2;
		f().Text = "Layer:";
		g().AcceptsReturn = true;
		g().Location = new Point(12, 79);
		g().Multiline = true;
		g().Name = "TextBoxInfo";
		g().Size = new Size(327, 55);
		g().TabIndex = 3;
		h().AutoSize = true;
		h().Location = new Point(9, 60);
		h().Name = "Label2";
		h().Size = new Size(127, 16);
		h().TabIndex = 4;
		h().Text = "Material Information:";
		i().AutoSize = true;
		i().Location = new Point(9, 145);
		i().Name = "LabelPrivateInfo";
		i().Size = new Size(219, 16);
		i().TabIndex = 6;
		i().Text = "Private Information (FI Internal Only):";
		j().AcceptsReturn = true;
		j().Location = new Point(12, 164);
		j().Multiline = true;
		j().Name = "TextBoxPrivateInfo";
		j().Size = new Size(327, 55);
		j().TabIndex = 5;
		base.AcceptButton = c();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = d();
		base.ClientSize = new Size(351, 287);
		base.Controls.Add(i());
		base.Controls.Add(j());
		base.Controls.Add(h());
		base.Controls.Add(g());
		base.Controls.Add(f());
		base.Controls.Add(e());
		base.Controls.Add(b());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogGetnkLayerID";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Save N and K to File";
		b().ResumeLayout(performLayout: false);
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
	internal virtual Button c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = b;
		Button button = this.m_c;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_c = A_0;
		button = this.m_c;
		if (button != null)
		{
			button.Click += value;
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
	internal virtual ComboBox e()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
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
	internal virtual void a(Label A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox g()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TextBox A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label h()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label i()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox j()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TextBox A_0)
	{
		this.m_j = A_0;
	}

	private void b(object A_0, EventArgs A_1)
	{
		base.DialogResult = DialogResult.OK;
		Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		base.DialogResult = DialogResult.Cancel;
		Close();
	}

	public int a(bool A_0, hc A_1, ref bool A_2, ref string A_3, ref string A_4)
	{
		bool a_ = A_1.cy().dh().ax(A_1.c0());
		hi hi2 = A_1.cy().b3(A_1.cf());
		checked
		{
			int num = hi2.g7() + 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				bool flag = num2 == hi2.g7() + 1;
				gc gc2 = hi2.eu(num2);
				if (gc2.ah(a_) || gc2.aj(a_))
				{
					if (flag)
					{
						e().Items.Add(new iz.a("Substrate", num2));
					}
					else if (num2 == 0)
					{
						e().Items.Add(new iz.a("Medium", num2));
					}
					else
					{
						e().Items.Add(new iz.a("Layer " + num2, num2));
					}
				}
				gc2 = null;
			}
			e().SelectedIndex = 0;
			hi2 = null;
			if (!A_0)
			{
				j().Visible = false;
				i().Visible = false;
				g().Height = j().Bottom - g().Top;
			}
			ShowDialog();
			A_2 = base.DialogResult == DialogResult.Cancel;
			if (!A_2)
			{
				A_3 = g().Text;
				A_4 = j().Text;
			}
			ComboBox comboBox = e();
			return ((iz.a)comboBox.Items[comboBox.SelectedIndex]).b;
		}
	}
}
