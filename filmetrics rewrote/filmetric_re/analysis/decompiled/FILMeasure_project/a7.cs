using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class a7 : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private ComboBox m_d;

	[CompilerGenerated]
	private ComboBox m_e;

	[CompilerGenerated]
	private TableLayoutPanel f;

	private ek g;

	private fz m_h;

	private f1 m_i;

	private el m_j;

	private em k;

	public a7()
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
		b(new Button());
		a(new ComboBox());
		b(new ComboBox());
		a(new TableLayoutPanel());
		h().SuspendLayout();
		SuspendLayout();
		b().Anchor = AnchorStyles.None;
		b().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b().Location = new Point(13, 35);
		b().Margin = new Padding(5, 5, 5, 5);
		b().Name = "ButtonOK";
		b().Size = new Size(100, 30);
		b().TabIndex = 6;
		b().Text = "OK";
		b().UseVisualStyleBackColor = true;
		c().Anchor = AnchorStyles.None;
		c().DialogResult = DialogResult.Cancel;
		c().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c().Location = new Point(139, 35);
		c().Margin = new Padding(5, 5, 5, 5);
		c().Name = "ButtonCancel";
		c().Size = new Size(100, 30);
		c().TabIndex = 7;
		c().Text = "Cancel";
		c().UseVisualStyleBackColor = true;
		d().DropDownStyle = ComboBoxStyle.DropDownList;
		d().FormattingEnabled = true;
		d().Location = new Point(3, 3);
		d().Name = "ComboBoxSamples";
		d().Size = new Size(120, 24);
		d().TabIndex = 12;
		e().DropDownStyle = ComboBoxStyle.DropDownList;
		e().FormattingEnabled = true;
		e().Location = new Point(129, 3);
		e().Name = "ComboBoxLocations";
		e().Size = new Size(120, 24);
		e().TabIndex = 13;
		h().AutoSize = true;
		h().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		h().ColumnCount = 2;
		h().ColumnStyles.Add(new ColumnStyle());
		h().ColumnStyles.Add(new ColumnStyle());
		h().Controls.Add(c(), 1, 1);
		h().Controls.Add(e(), 1, 0);
		h().Controls.Add(d(), 0, 0);
		h().Controls.Add(b(), 0, 1);
		h().Location = new Point(5, 7);
		h().Name = "TableLayoutPanel1";
		h().RowCount = 2;
		h().RowStyles.Add(new RowStyle());
		h().RowStyles.Add(new RowStyle());
		h().Size = new Size(252, 70);
		h().TabIndex = 14;
		base.AcceptButton = b();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = c();
		base.ClientSize = new Size(262, 83);
		base.Controls.Add(h());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4, 4, 4, 4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogAddOrMoveResults";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Choose New Location";
		h().ResumeLayout(performLayout: false);
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
	internal virtual Button c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox d()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
	{
		EventHandler value = b;
		ComboBox comboBox = this.m_d;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_d = A_0;
		comboBox = this.m_d;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
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
	internal virtual void b(ComboBox A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel h()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		f = A_0;
	}

	public void a(ek A_0, f1 A_1, fz A_2, Point A_3)
	{
		g = A_0;
		this.m_h = A_2;
		this.m_i = A_1;
		ComboBox comboBox = d();
		foreach (el item in g.c)
		{
			comboBox.Items.Add(item.d());
		}
		comboBox.SelectedIndex = 0;
		comboBox = null;
		i6.a(A_3, this);
		ShowDialog();
	}

	private void b(object A_0, EventArgs A_1)
	{
		e().Items.Clear();
		this.m_j = null;
		foreach (el item in g.c)
		{
			if (Operators.CompareString(item.d(), d().SelectedItem.ToString(), TextCompare: false) == 0)
			{
				this.m_j = item;
				break;
			}
		}
		if (this.m_j == null)
		{
			return;
		}
		foreach (em item2 in this.m_j.b)
		{
			e().Items.Add(item2.f());
		}
		e().SelectedIndex = 0;
	}

	[SpecialName]
	public el i()
	{
		return this.m_j;
	}

	[SpecialName]
	public em j()
	{
		return k;
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			k = null;
			if (this.m_j != null)
			{
				foreach (em item in this.m_j.b)
				{
					if (Operators.CompareString(item.f(), e().SelectedItem.ToString(), TextCompare: false) == 0)
					{
						k = item;
						break;
					}
				}
			}
			base.DialogResult = DialogResult.OK;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_h, this.m_i, null, i6.a(this), "DialogAddOrMoveResults.ButtonOK_Click", a_);
			ProjectData.ClearProjectError();
		}
	}
}
