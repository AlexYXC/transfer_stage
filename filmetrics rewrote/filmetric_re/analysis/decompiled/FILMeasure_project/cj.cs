using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class cj : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private TableLayoutPanel m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private CheckBox m_e;

	[CompilerGenerated]
	private Button m_f;

	[CompilerGenerated]
	private Button m_g;

	[CompilerGenerated]
	private ListBox m_h;

	private fz m_i;

	private f1 j;

	private List<string> k;

	private bool l;

	public cj()
	{
		b();
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
	private void b()
	{
		a(new TableLayoutPanel());
		a(new Button());
		b(new Button());
		a(new CheckBox());
		c(new Button());
		d(new Button());
		a(new ListBox());
		c().SuspendLayout();
		SuspendLayout();
		c().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		c().ColumnCount = 2;
		c().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		c().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		c().Controls.Add(d(), 0, 0);
		c().Controls.Add(e(), 1, 0);
		c().Location = new Point(369, 421);
		c().Margin = new Padding(4);
		c().Name = "TableLayoutPanel1";
		c().RowCount = 1;
		c().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		c().Size = new Size(195, 36);
		c().TabIndex = 0;
		d().Anchor = AnchorStyles.None;
		d().DialogResult = DialogResult.OK;
		d().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d().Location = new Point(4, 4);
		d().Margin = new Padding(4);
		d().Name = "OK_Button";
		d().Size = new Size(89, 28);
		d().TabIndex = 0;
		d().Text = "OK";
		e().Anchor = AnchorStyles.None;
		e().DialogResult = DialogResult.Cancel;
		e().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e().Location = new Point(101, 4);
		e().Margin = new Padding(4);
		e().Name = "Cancel_Button";
		e().Size = new Size(89, 28);
		e().TabIndex = 1;
		e().Text = "Cancel";
		f().AutoSize = true;
		f().Location = new Point(12, 12);
		f().Name = "CheckBoxRestrictOperatorRecipes";
		f().Size = new Size(309, 20);
		f().TabIndex = 1;
		f().Text = "Operators are restricted to the following recipes:";
		f().UseVisualStyleBackColor = true;
		g().AutoSize = true;
		g().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		g().Location = new Point(144, 370);
		g().Name = "ButtonAdd";
		g().Size = new Size(60, 37);
		g().TabIndex = 3;
		g().Text = "Add...";
		g().UseVisualStyleBackColor = true;
		h().AutoSize = true;
		h().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		h().Location = new Point(210, 370);
		h().Name = "ButtonDeleteSelected";
		h().Size = new Size(227, 37);
		h().TabIndex = 4;
		h().Text = "Delete Selected Permissions";
		h().UseVisualStyleBackColor = true;
		i().FormattingEnabled = true;
		i().ItemHeight = 16;
		i().Location = new Point(12, 34);
		i().Name = "ListBoxPermittedRecipes";
		i().SelectionMode = SelectionMode.MultiExtended;
		i().Size = new Size(556, 324);
		i().TabIndex = 5;
		base.AcceptButton = d();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = e();
		base.ClientSize = new Size(580, 472);
		base.Controls.Add(i());
		base.Controls.Add(h());
		base.Controls.Add(g());
		base.Controls.Add(f());
		base.Controls.Add(c());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogAccessControlEditRecipeRestriction";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Edit Operator Recipe Restrictions";
		c().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel c()
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
	internal virtual Button d()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button e()
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
	internal virtual CheckBox f()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(CheckBox A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button g()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = b;
		Button button = this.m_f;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_f = A_0;
		button = this.m_f;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button h()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Button A_0)
	{
		EventHandler value = a;
		Button button = this.m_g;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_g = A_0;
		button = this.m_g;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ListBox i()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ListBox A_0)
	{
		this.m_h = A_0;
	}

	public void a(fz A_0, f1 A_1, gq A_2, ref bool A_3)
	{
		this.m_i = A_0;
		j = A_1;
		k = new List<string>(A_2.l());
		f().Checked = A_2.k();
		a();
		ShowDialog();
		if (base.DialogResult == DialogResult.OK)
		{
			A_2.h(f().Checked);
			A_3 = l;
			if (A_3)
			{
				A_2.g(k);
			}
		}
	}

	private void a()
	{
		if (k == null)
		{
			return;
		}
		int selectedIndex = i().SelectedIndex;
		i().Items.Clear();
		foreach (string item in k)
		{
			i().Items.Add(item);
		}
		if (i().Items.Count > selectedIndex)
		{
			i().SelectedIndex = selectedIndex;
		}
		else if (i().Items.Count > 0)
		{
			i().SelectedIndex = checked(i().Items.Count - 1);
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.InitialDirectory = hg.b0();
				openFileDialog.Multiselect = true;
				openFileDialog.SupportMultiDottedExtensions = true;
				openFileDialog.Filter = "All files (*.*)|*.*";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					int num = openFileDialog.FileNames.Length - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						k.Add(openFileDialog.FileNames[num2].Substring(hg.b0().Length));
					}
					k.Sort();
					a();
					l = true;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_i, j, null, i6.a(this), "DialogAccessControlEditRecipeRestriction.ButtonAdd_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (i().SelectedItems.Count > 0)
				{
					for (int num = i().SelectedItems.Count - 1; num >= 0; num += -1)
					{
						int index = i().Items.IndexOf(RuntimeHelpers.GetObjectValue(i().SelectedItems[num]));
						i().Items.RemoveAt(index);
						k.RemoveAt(index);
					}
					a();
					l = true;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_i, j, null, i6.a(this), "DialogAccessControlEditRecipeRestriction.ButtonDeleteSelected_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}
}
