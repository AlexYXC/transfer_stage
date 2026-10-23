using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class dx : Form
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
	private Button m_g;

	[CompilerGenerated]
	private Button m_h;

	[CompilerGenerated]
	private TextBox m_i;

	[CompilerGenerated]
	private Label m_j;

	[CompilerGenerated]
	private CheckBox m_k;

	private string l;

	private string m;

	private fz n;

	public dx()
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
		a(new Label());
		a(new TextBox());
		c(new Button());
		d(new Button());
		b(new TextBox());
		b(new Label());
		a(new CheckBox());
		b().SuspendLayout();
		SuspendLayout();
		b().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		b().ColumnCount = 2;
		b().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		b().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		b().Controls.Add(c(), 0, 0);
		b().Controls.Add(d(), 1, 0);
		b().Location = new Point(473, 143);
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
		e().AutoSize = true;
		e().Location = new Point(19, 15);
		e().Name = "Label1";
		e().Size = new Size(246, 16);
		e().TabIndex = 1;
		e().Text = "Root path for imported tech support files:";
		f().Location = new Point(22, 34);
		f().Name = "TextBoxFilesRootPath";
		f().ReadOnly = true;
		f().Size = new Size(544, 22);
		f().TabIndex = 2;
		g().Anchor = AnchorStyles.Top | AnchorStyles.Right;
		g().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		g().Location = new Point(578, 30);
		g().Margin = new Padding(4);
		g().Name = "ButtonFilesRootBrowse";
		g().Size = new Size(89, 28);
		g().TabIndex = 3;
		g().Text = "Browse...";
		h().Anchor = AnchorStyles.Top | AnchorStyles.Right;
		h().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		h().Location = new Point(578, 88);
		h().Margin = new Padding(4);
		h().Name = "ButtonRecipesRootBrowse";
		h().Size = new Size(89, 28);
		h().TabIndex = 6;
		h().Text = "Browse...";
		i().Location = new Point(22, 92);
		i().Name = "TextBoxRecipesRootPath";
		i().ReadOnly = true;
		i().Size = new Size(544, 22);
		i().TabIndex = 5;
		j().AutoSize = true;
		j().Location = new Point(19, 73);
		j().Name = "Label2";
		j().Size = new Size(267, 16);
		j().TabIndex = 4;
		j().Text = "Root path for imported tech support recipes:";
		k().AutoSize = true;
		k().Location = new Point(22, 134);
		k().Name = "CheckBoxAutoOpenFolder";
		k().Size = new Size(339, 20);
		k().TabIndex = 7;
		k().Text = "Automatically Open Folder Containing Imported Files";
		k().UseVisualStyleBackColor = true;
		base.AcceptButton = c();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = d();
		base.ClientSize = new Size(684, 194);
		base.Controls.Add(k());
		base.Controls.Add(h());
		base.Controls.Add(i());
		base.Controls.Add(j());
		base.Controls.Add(g());
		base.Controls.Add(f());
		base.Controls.Add(e());
		base.Controls.Add(b());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogTechSupportSettings";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Technical Support Settings";
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
		EventHandler value = d;
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
		EventHandler value = c;
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
	internal virtual Button g()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = b;
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
	internal virtual Button h()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Button A_0)
	{
		EventHandler value = a;
		Button button = this.m_h;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_h = A_0;
		button = this.m_h;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox i()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TextBox A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label j()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox k()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(CheckBox A_0)
	{
		this.m_k = A_0;
	}

	public void a(fz A_0)
	{
		n = A_0;
		l = global::e.a().TechSupportFilesRootPath;
		m = global::e.a().TechSupportRecipesRootPath;
		f().Text = l;
		i().Text = m;
		k().Checked = global::e.a().TechSupportOpenFolderInExplorer;
		ShowDialog();
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			base.DialogResult = DialogResult.OK;
			global::e.a().TechSupportFilesRootPath = l;
			global::e.a().TechSupportRecipesRootPath = m;
			global::e.a().TechSupportOpenFolderInExplorer = k().Checked;
			Close();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			n.c(fz.b.a, "Error in DialogTechnicalSupportSettings.ButtonFilesRootBrowse_Click", ex3);
			fe.b(n, "Error in DialogTechSupportSettings.OK_Button_Click. Error is: " + ex3.Message, i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			base.DialogResult = DialogResult.Cancel;
			Close();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			n.c(fz.b.a, "Error in DialogTechnicalSupportSettings.ButtonFilesRootBrowse_Click", ex3);
			fe.b(n, "Error in DialogTechSupportSettings.Cancel_Button_Click. Error is: " + ex3.Message, i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void a(ref string A_0)
	{
		ay ay2 = new ay();
		ay2.g(i3.d(A_0));
		ay2.h("Specify folder for files imported from Tech Support Archives");
		if (ay2.g(this) == DialogResult.OK)
		{
			A_0 = ay2.f();
			ay2 = null;
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			a(ref l);
			f().Text = l;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			n.c(fz.b.a, "Error in DialogTechnicalSupportSettings.ButtonFilesRootBrowse_Click", ex3);
			fe.b(n, "Error in DialogTechSupportSettings.ButtonFilesRootBrowse_Click. Error is: " + ex3.Message, i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			a(ref m);
			i().Text = m;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			n.c(fz.b.a, "Error in DialogTechnicalSupportSettings.ButtonRecipesRootBrowse_Click", ex3);
			fe.b(n, "Error in DialogTechSupportSettings.ButtonRecipesRootBrowse_Click. Error is: " + ex3.Message, i6.a(this));
			ProjectData.ClearProjectError();
		}
	}
}
