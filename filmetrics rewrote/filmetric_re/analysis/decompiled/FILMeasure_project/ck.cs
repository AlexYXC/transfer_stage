using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class ck : Form
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
	private TextBox m_f;

	[CompilerGenerated]
	private Label m_g;

	[CompilerGenerated]
	private Label m_h;

	[CompilerGenerated]
	private TableLayoutPanel m_i;

	private string[] j;

	private jb.d k;

	public ck()
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
		a(new Button());
		b(new Button());
		a(new ComboBox());
		a(new TextBox());
		a(new Label());
		b(new Label());
		b(new TableLayoutPanel());
		b().SuspendLayout();
		i().SuspendLayout();
		SuspendLayout();
		b().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		b().ColumnCount = 2;
		b().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		b().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		b().Controls.Add(c(), 0, 0);
		b().Controls.Add(d(), 1, 0);
		b().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b().Location = new Point(117, 219);
		b().Margin = new Padding(4, 4, 0, 0);
		b().Name = "TableLayoutPanel1";
		b().RowCount = 1;
		b().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		b().Size = new Size(195, 36);
		b().TabIndex = 0;
		c().Anchor = AnchorStyles.None;
		c().Location = new Point(4, 4);
		c().Margin = new Padding(4);
		c().Name = "OK_Button";
		c().Size = new Size(89, 28);
		c().TabIndex = 0;
		c().Text = "OK";
		d().Anchor = AnchorStyles.None;
		d().DialogResult = DialogResult.Cancel;
		d().Location = new Point(101, 4);
		d().Margin = new Padding(4);
		d().Name = "Cancel_Button";
		d().Size = new Size(89, 28);
		d().TabIndex = 1;
		d().Text = "Cancel";
		e().DropDownStyle = ComboBoxStyle.DropDownList;
		e().FormattingEnabled = true;
		e().Location = new Point(6, 22);
		e().Name = "ComboBoxAttrType";
		e().Size = new Size(189, 24);
		e().TabIndex = 1;
		f().AcceptsTab = true;
		f().Location = new Point(6, 68);
		f().Multiline = true;
		f().Name = "TextBoxAttrs";
		f().Size = new Size(300, 144);
		f().TabIndex = 2;
		g().AutoSize = true;
		g().Location = new Point(6, 49);
		g().Name = "Label1";
		g().Size = new Size(303, 16);
		g().TabIndex = 3;
		g().Text = "Enter list of Attributes separated by ',', ';', or <Tab>:";
		h().AutoSize = true;
		h().Location = new Point(6, 3);
		h().Name = "Label2";
		h().Size = new Size(94, 16);
		h().TabIndex = 4;
		h().Text = "Attribute Type:";
		i().AutoSize = true;
		i().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		i().ColumnCount = 1;
		i().ColumnStyles.Add(new ColumnStyle());
		i().Controls.Add(h(), 0, 0);
		i().Controls.Add(b(), 0, 4);
		i().Controls.Add(f(), 0, 3);
		i().Controls.Add(g(), 0, 2);
		i().Controls.Add(e(), 0, 1);
		i().Location = new Point(0, 0);
		i().Name = "TableLayoutPanel2";
		i().Padding = new Padding(3);
		i().RowCount = 5;
		i().RowStyles.Add(new RowStyle());
		i().RowStyles.Add(new RowStyle());
		i().RowStyles.Add(new RowStyle());
		i().RowStyles.Add(new RowStyle());
		i().RowStyles.Add(new RowStyle());
		i().Size = new Size(315, 258);
		i().TabIndex = 5;
		base.AcceptButton = c();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = d();
		base.ClientSize = new Size(320, 265);
		base.Controls.Add(i());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogAddAttributes";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Add Attributes";
		b().ResumeLayout(performLayout: false);
		i().ResumeLayout(performLayout: false);
		i().PerformLayout();
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
		EventHandler value = a;
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
		this.m_d = A_0;
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

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label g()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
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
	internal virtual TableLayoutPanel i()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_i = A_0;
	}

	public void a(jb.d A_0, bool A_1, ref string[] A_2, ref jb.d A_3)
	{
		k = A_0;
		if (!A_1)
		{
			e().Items.Add(jb.d(jb.d.a));
			e().Items.Add(jb.d(jb.d.c));
		}
		e().Items.Add(jb.d(jb.d.b));
		e().Text = jb.d(A_0);
		ShowDialog();
		A_2 = j;
		A_3 = k;
	}

	private void a(object A_0, EventArgs A_1)
	{
		string[] array = f().Text.Split(";,\t".ToCharArray());
		int num = 0;
		int upperBound = array.GetUpperBound(0);
		checked
		{
			for (int num2 = 0; num2 <= upperBound; num2++)
			{
				if (array[num2].Trim().Length > 0)
				{
					num++;
				}
			}
			if (num > 0)
			{
				int num3 = num - 1;
				int num4 = 0;
				j = new string[num3 + 1];
				int num5 = num3;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					string text = array[num6].Trim();
					if (text.Length > 0)
					{
						j[num4] = text;
						num4++;
					}
				}
				k = jb.al(e().Text);
			}
			base.DialogResult = DialogResult.OK;
		}
	}
}
