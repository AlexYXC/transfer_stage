using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class dt : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Label m_b;

	[CompilerGenerated]
	private Label m_c;

	[CompilerGenerated]
	private Label m_d;

	[CompilerGenerated]
	private Label m_e;

	[CompilerGenerated]
	private Label m_f;

	[CompilerGenerated]
	private TextBox m_g;

	[CompilerGenerated]
	private TextBox m_h;

	[CompilerGenerated]
	private TextBox m_i;

	[CompilerGenerated]
	private TextBox m_j;

	[CompilerGenerated]
	private LinkLabel m_k;

	[CompilerGenerated]
	private Label m_l;

	[CompilerGenerated]
	private Label m_m;

	[CompilerGenerated]
	private Label m_n;

	[CompilerGenerated]
	private Label m_o;

	[CompilerGenerated]
	private Label m_p;

	[CompilerGenerated]
	private Button m_q;

	[CompilerGenerated]
	private TextBox m_r;

	[CompilerGenerated]
	private Label m_s;

	[CompilerGenerated]
	private LinkLabel m_t;

	private fz u;

	private string v;

	private string w;

	public dt()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(dt));
		a(new Label());
		b(new Label());
		c(new Label());
		d(new Label());
		e(new Label());
		a(new TextBox());
		b(new TextBox());
		c(new TextBox());
		d(new TextBox());
		a(new LinkLabel());
		f(new Label());
		g(new Label());
		h(new Label());
		i(new Label());
		j(new Label());
		a(new Button());
		e(new TextBox());
		k(new Label());
		b(new LinkLabel());
		SuspendLayout();
		b().AutoSize = true;
		b().Location = new Point(12, 9);
		b().Name = "Label1";
		b().Size = new Size(444, 80);
		b().TabIndex = 1;
		b().Text = componentResourceManager.GetString("Label1.Text");
		c().AutoSize = true;
		c().Location = new Point(53, 114);
		c().Name = "Label2";
		c().Size = new Size(76, 16);
		c().TabIndex = 2;
		c().Text = "First Name:";
		d().AutoSize = true;
		d().Location = new Point(20, 198);
		d().Name = "Label3";
		d().Size = new Size(109, 16);
		d().TabIndex = 3;
		d().Text = "Company Name:";
		e().AutoSize = true;
		e().Location = new Point(53, 142);
		e().Name = "Label4";
		e().Size = new Size(76, 16);
		e().TabIndex = 4;
		e().Text = "Last Name:";
		f().AutoSize = true;
		f().Location = new Point(26, 170);
		f().Name = "Label5";
		f().Size = new Size(103, 16);
		f().TabIndex = 5;
		f().Text = "E-mail Address:";
		g().Location = new Point(131, 111);
		g().Name = "TextBoxFirstName";
		g().Size = new Size(206, 22);
		g().TabIndex = 0;
		h().Location = new Point(131, 139);
		h().Name = "TextBoxLastName";
		h().Size = new Size(206, 22);
		h().TabIndex = 1;
		i().Location = new Point(131, 167);
		i().Name = "TextBoxEmailAddr";
		i().Size = new Size(206, 22);
		i().TabIndex = 2;
		j().Location = new Point(131, 195);
		j().Name = "TextBoxCompanyName";
		j().Size = new Size(206, 22);
		j().TabIndex = 3;
		k().AutoSize = true;
		k().Location = new Point(350, 170);
		k().Name = "LinkLabelEmailWhy";
		k().Size = new Size(131, 16);
		k().TabIndex = 6;
		k().TabStop = true;
		k().Text = "Why is this required?";
		l().AutoSize = true;
		l().ForeColor = Color.DarkRed;
		l().Location = new Point(339, 114);
		l().Name = "Label6";
		l().Size = new Size(13, 16);
		l().TabIndex = 23;
		l().Text = "*";
		m().AutoSize = true;
		m().BackColor = SystemColors.Control;
		m().ForeColor = Color.DarkRed;
		m().Location = new Point(343, 257);
		m().Name = "Label14";
		m().Size = new Size(13, 16);
		m().TabIndex = 29;
		m().Text = "*";
		n().AutoSize = true;
		n().Location = new Point(352, 257);
		n().Name = "Label15";
		n().Size = new Size(97, 16);
		n().TabIndex = 30;
		n().Text = "Required Field";
		o().AutoSize = true;
		o().ForeColor = Color.DarkRed;
		o().Location = new Point(339, 142);
		o().Name = "Label7";
		o().Size = new Size(13, 16);
		o().TabIndex = 31;
		o().Text = "*";
		p().AutoSize = true;
		p().ForeColor = Color.DarkRed;
		p().Location = new Point(339, 170);
		p().Name = "Label8";
		p().Size = new Size(13, 16);
		p().TabIndex = 32;
		p().Text = "*";
		q().Anchor = AnchorStyles.Bottom;
		q().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		q().Location = new Point(172, 276);
		q().Name = "ButtonSubmit";
		q().Size = new Size(135, 28);
		q().TabIndex = 5;
		q().Text = "Submit Request";
		q().UseVisualStyleBackColor = true;
		r().Location = new Point(131, 223);
		r().Name = "TextBoxStationName";
		r().Size = new Size(206, 22);
		r().TabIndex = 4;
		s().AutoSize = true;
		s().Location = new Point(37, 226);
		s().Name = "Label9";
		s().Size = new Size(92, 16);
		s().TabIndex = 34;
		s().Text = "Station Name:";
		t().AutoSize = true;
		t().Location = new Point(343, 226);
		t().Name = "LinkLabelStationWhat";
		t().Size = new Size(82, 16);
		t().TabIndex = 7;
		t().TabStop = true;
		t().Text = "What is this?";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(479, 316);
		base.Controls.Add(t());
		base.Controls.Add(r());
		base.Controls.Add(s());
		base.Controls.Add(q());
		base.Controls.Add(p());
		base.Controls.Add(o());
		base.Controls.Add(m());
		base.Controls.Add(n());
		base.Controls.Add(l());
		base.Controls.Add(k());
		base.Controls.Add(j());
		base.Controls.Add(i());
		base.Controls.Add(h());
		base.Controls.Add(g());
		base.Controls.Add(f());
		base.Controls.Add(e());
		base.Controls.Add(d());
		base.Controls.Add(c());
		base.Controls.Add(b());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogSoftwareRegistration";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Register Software";
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
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
	internal virtual void c(Label A_0)
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
	internal virtual void d(Label A_0)
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
	internal virtual void e(Label A_0)
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
	internal virtual TextBox h()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TextBox A_0)
	{
		this.m_h = A_0;
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
	internal virtual void c(TextBox A_0)
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
	internal virtual LinkLabel k()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(LinkLabel A_0)
	{
		LinkLabelLinkClickedEventHandler value = b;
		LinkLabel linkLabel = this.m_k;
		if (linkLabel != null)
		{
			linkLabel.LinkClicked -= value;
		}
		this.m_k = A_0;
		linkLabel = this.m_k;
		if (linkLabel != null)
		{
			linkLabel.LinkClicked += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label l()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label m()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Label A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label n()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Label A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label o()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Label A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label p()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Label A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button q()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = a;
		Button button = this.m_q;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_q = A_0;
		button = this.m_q;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox r()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TextBox A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label s()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Label A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual LinkLabel t()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(LinkLabel A_0)
	{
		LinkLabelLinkClickedEventHandler value = a;
		LinkLabel linkLabel = this.m_t;
		if (linkLabel != null)
		{
			linkLabel.LinkClicked -= value;
		}
		this.m_t = A_0;
		linkLabel = this.m_t;
		if (linkLabel != null)
		{
			linkLabel.LinkClicked += value;
		}
	}

	public void a(fz A_0, string A_1, string A_2)
	{
		u = A_0;
		v = A_1;
		w = A_2;
		ShowDialog();
	}

	private void b(object A_0, LinkLabelLinkClickedEventArgs A_1)
	{
		try
		{
			fz a_ = u;
			string A_2 = "SoftwareRegEmailWhy";
			fe.b(a_, hu.a(ref A_2), "Information", i6.a(k()));
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			string text = "Error in DialogSoftwareRegistration.LinkLabelEmailWhy_LinkClicked";
			u.c(fz.b.b, text, a_2);
			Interaction.MsgBox(text + ", error has been logged.");
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, LinkLabelLinkClickedEventArgs A_1)
	{
		try
		{
			fz a_ = u;
			string A_2 = "SoftwareRegStationWhatIs";
			fe.b(a_, hu.a(ref A_2), "Information", i6.a(k()));
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			string text = " Error in DialogSoftwareRegistration.LinkLabelStationWhat_LinkClicked";
			u.c(fz.b.b, text, a_2);
			Interaction.MsgBox(text + ", error has been logged.");
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			string text = g().Text.Trim();
			if (text.Contains("."))
			{
				fe.b(u, "First name cannot contain '.'", i6.a(q()));
				return;
			}
			if (text.Length == 0)
			{
				fe.b(u, "Please enter a First name", i6.a(q()));
				return;
			}
			string text2 = h().Text.Trim();
			if (text2.Contains("."))
			{
				fe.b(u, "Last name cannot contain '.'", i6.a(q()));
				return;
			}
			if (text2.Length == 0)
			{
				fe.b(u, "Please enter a Last name", i6.a(q()));
				return;
			}
			string text3 = i().Text.Trim();
			if (text3.Length == 0)
			{
				fe.b(u, "Please enter an email address", i6.a(q()));
				return;
			}
			string a_ = j().Text.Trim();
			string a_2 = r().Text.Trim();
			string a_3 = text + "." + text2;
			string a_4 = i7.c();
			bool A_2 = default(bool);
			new dq().a(a_3, text3, a_, a_2, v, a_4, w, i6.a(q()), ref A_2);
			if (A_2)
			{
				a2.a.c(a_3, text3, a_, a_2);
				base.DialogResult = DialogResult.OK;
			}
			else
			{
				fz a_5 = u;
				string A_3 = "SoftwareRegFailure";
				fe.b(a_5, hu.a(ref A_3), i6.a(q()));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_6 = ex2;
			u.c(fz.b.b, "Error in DialogSoftwareRegistration.ButtonSubmit_Click", a_6);
			Interaction.MsgBox("Error in DialogSoftwareRegistration.ButtonSubmit_Click, error has been logged.");
			ProjectData.ClearProjectError();
		}
	}
}
