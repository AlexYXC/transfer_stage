using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class dc : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private TableLayoutPanel m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private Label m_e;

	[CompilerGenerated]
	private TextBox m_f;

	[CompilerGenerated]
	private TableLayoutPanel m_g;

	private fz h;

	public dc()
	{
		base.Activated += b;
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
		a(new Label());
		a(new TextBox());
		b(new TableLayoutPanel());
		b().SuspendLayout();
		g().SuspendLayout();
		SuspendLayout();
		b().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		b().AutoSize = true;
		b().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		b().ColumnCount = 2;
		b().ColumnStyles.Add(new ColumnStyle());
		b().ColumnStyles.Add(new ColumnStyle());
		b().Controls.Add(c(), 0, 0);
		b().Controls.Add(d(), 1, 0);
		b().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b().Location = new Point(131, 43);
		b().Margin = new Padding(3, 15, 0, 0);
		b().Name = "TableLayoutPanel1";
		b().RowCount = 1;
		b().RowStyles.Add(new RowStyle());
		b().Size = new Size(148, 36);
		b().TabIndex = 0;
		c().AccessibleRole = AccessibleRole.None;
		c().Anchor = AnchorStyles.None;
		c().AutoSize = true;
		c().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c().Location = new Point(3, 3);
		c().Name = "OK_Button";
		c().Size = new Size(68, 30);
		c().TabIndex = 1;
		c().Text = "OK";
		d().Anchor = AnchorStyles.None;
		d().AutoSize = true;
		d().DialogResult = DialogResult.Cancel;
		d().Location = new Point(77, 3);
		d().Name = "Cancel_Button";
		d().Size = new Size(68, 30);
		d().TabIndex = 1;
		d().Text = "Cancel";
		e().Anchor = AnchorStyles.Right;
		e().AutoSize = true;
		e().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e().Location = new Point(3, 6);
		e().Margin = new Padding(3, 0, 2, 0);
		e().Name = "Label1";
		e().Size = new Size(74, 16);
		e().TabIndex = 1;
		e().Text = "Password: ";
		f().Anchor = AnchorStyles.None;
		f().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f().Location = new Point(79, 3);
		f().Margin = new Padding(0, 3, 3, 3);
		f().Name = "TextBoxPassword";
		f().Size = new Size(197, 22);
		f().TabIndex = 0;
		f().UseSystemPasswordChar = true;
		g().AutoSize = true;
		g().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		g().ColumnCount = 2;
		g().ColumnStyles.Add(new ColumnStyle());
		g().ColumnStyles.Add(new ColumnStyle());
		g().Controls.Add(b(), 1, 1);
		g().Controls.Add(e(), 0, 0);
		g().Controls.Add(f(), 1, 0);
		g().Location = new Point(12, 12);
		g().Name = "TableLayoutPanel2";
		g().RowCount = 2;
		g().RowStyles.Add(new RowStyle());
		g().RowStyles.Add(new RowStyle());
		g().Size = new Size(279, 79);
		g().TabIndex = 3;
		base.AcceptButton = c();
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = d();
		base.ClientSize = new Size(416, 142);
		base.Controls.Add(g());
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogPassword";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Enter Password";
		b().ResumeLayout(performLayout: false);
		b().PerformLayout();
		g().ResumeLayout(performLayout: false);
		g().PerformLayout();
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
	internal virtual Label e()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
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
	internal virtual TableLayoutPanel g()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_g = A_0;
	}

	public void a(fz A_0)
	{
		h = A_0;
		ShowDialog();
	}

	private void b(object A_0, EventArgs A_1)
	{
		f().Focus();
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			if (Operators.CompareString(f().Text, "FI*Service", TextCompare: false) == 0)
			{
				base.DialogResult = DialogResult.OK;
				return;
			}
			ref fz a_ = ref h;
			Point A_2 = i6.a(this);
			fe.b(ref a_, "Password is not correct. Retry the password or cancel", ref A_2);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			h.c(fz.b.b, "Error in DialogPassword OK_Button_Click", ex3.ToString());
			ProjectData.ClearProjectError();
		}
	}
}
