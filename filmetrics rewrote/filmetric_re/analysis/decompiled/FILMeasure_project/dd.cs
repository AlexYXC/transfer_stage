using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class dd : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Label m_d;

	[CompilerGenerated]
	private TextBox m_e;

	[CompilerGenerated]
	private TextBox m_f;

	[CompilerGenerated]
	private Label m_g;

	[CompilerGenerated]
	private TextBox m_h;

	[CompilerGenerated]
	private Label m_i;

	[CompilerGenerated]
	private TextBox m_j;

	[CompilerGenerated]
	private Label m_k;

	private DialogResult l;

	private fz m;

	public dd()
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
		a(new Button());
		b(new Button());
		a(new Label());
		a(new TextBox());
		b(new TextBox());
		b(new Label());
		c(new TextBox());
		c(new Label());
		d(new TextBox());
		d(new Label());
		SuspendLayout();
		b().Cursor = Cursors.Default;
		b().DialogResult = DialogResult.Cancel;
		b().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b().ForeColor = SystemColors.ControlText;
		b().Location = new Point(389, 183);
		b().Margin = new Padding(4);
		b().Name = "ButtonCancel";
		b().Size = new Size(90, 35);
		b().TabIndex = 20;
		b().Text = "&Cancel";
		c().Cursor = Cursors.Default;
		c().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c().ForeColor = SystemColors.ControlText;
		c().Location = new Point(291, 183);
		c().Margin = new Padding(4);
		c().Name = "ButtonPrint";
		c().Size = new Size(90, 35);
		c().TabIndex = 19;
		c().Text = "&Print...";
		d().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d().Location = new Point(16, 33);
		d().Margin = new Padding(4, 0, 4, 0);
		d().Name = "LabelCompanyName";
		d().Size = new Size(111, 23);
		d().TabIndex = 21;
		d().Text = "Company Name";
		d().TextAlign = ContentAlignment.MiddleRight;
		e().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e().Location = new Point(135, 33);
		e().Margin = new Padding(4);
		e().Name = "TextBoxCompanyName";
		e().Size = new Size(345, 22);
		e().TabIndex = 22;
		f().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f().Location = new Point(135, 68);
		f().Margin = new Padding(4);
		f().Name = "TextBoxCompanySite";
		f().Size = new Size(345, 22);
		f().TabIndex = 24;
		g().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		g().Location = new Point(16, 69);
		g().Margin = new Padding(4, 0, 4, 0);
		g().Name = "LabelCompanySite";
		g().Size = new Size(111, 23);
		g().TabIndex = 23;
		g().Text = "Company Site";
		g().TextAlign = ContentAlignment.MiddleRight;
		h().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		h().Location = new Point(135, 105);
		h().Margin = new Padding(4);
		h().Name = "TextBoxComment";
		h().Size = new Size(345, 22);
		h().TabIndex = 26;
		i().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		i().Location = new Point(16, 106);
		i().Margin = new Padding(4, 0, 4, 0);
		i().Name = "LabelComment";
		i().Size = new Size(111, 23);
		i().TabIndex = 25;
		i().Text = "Comment";
		i().TextAlign = ContentAlignment.MiddleRight;
		j().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		j().Location = new Point(135, 142);
		j().Margin = new Padding(4);
		j().Name = "TextBoxCoating";
		j().Size = new Size(345, 22);
		j().TabIndex = 28;
		k().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		k().Location = new Point(16, 143);
		k().Margin = new Padding(4, 0, 4, 0);
		k().Name = "LabelCoating";
		k().Size = new Size(111, 23);
		k().TabIndex = 27;
		k().Text = "Coating";
		k().TextAlign = ContentAlignment.MiddleRight;
		base.AcceptButton = c();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = b();
		base.ClientSize = new Size(509, 235);
		base.Controls.Add(j());
		base.Controls.Add(k());
		base.Controls.Add(h());
		base.Controls.Add(i());
		base.Controls.Add(f());
		base.Controls.Add(g());
		base.Controls.Add(e());
		base.Controls.Add(d());
		base.Controls.Add(b());
		base.Controls.Add(c());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ForeColor = Color.Black;
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogPrintHeaderSetup";
		base.ShowInTaskbar = false;
		Text = "Printed Report Information";
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
	internal virtual TextBox e()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TextBox A_0)
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
	internal virtual void b(TextBox A_0)
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
	internal virtual void b(Label A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox h()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TextBox A_0)
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
	internal virtual void d(TextBox A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label k()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_k = A_0;
	}

	public DialogResult a(ref fz A_0, ref string A_1, ref string A_2, ref string A_3, ref string A_4)
	{
		try
		{
			m = A_0;
			l = DialogResult.Cancel;
			e().Text = A_1;
			f().Text = A_2;
			h().Text = A_3;
			j().Text = A_4;
			ShowDialog();
			if (l == DialogResult.OK)
			{
				A_1 = e().Text;
				A_2 = f().Text;
				A_3 = h().Text;
				A_4 = j().Text;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			m.c(fz.b.b, "Exception caught in DialogPrintHeaderSetup.InitAndShow(). Exception is: ", a_);
			ProjectData.ClearProjectError();
		}
		return l;
	}

	private void b(object A_0, EventArgs A_1)
	{
		l = DialogResult.OK;
		Close();
	}

	private void a(object A_0, EventArgs A_1)
	{
		Close();
	}
}
