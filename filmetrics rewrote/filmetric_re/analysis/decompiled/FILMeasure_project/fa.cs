using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class fa : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Label m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private Button m_e;

	[CompilerGenerated]
	private TableLayoutPanel m_f;

	[CompilerGenerated]
	private TableLayoutPanel m_g;

	private short m_h;

	public fa()
	{
		b();
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
	private void b()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fa));
		a(new Label());
		a(new Button());
		b(new Button());
		c(new Button());
		b(new TableLayoutPanel());
		a(new TableLayoutPanel());
		h().SuspendLayout();
		g().SuspendLayout();
		SuspendLayout();
		componentResourceManager.ApplyResources(c(), "LabelMessage");
		c().Name = "LabelMessage";
		componentResourceManager.ApplyResources(d(), "ButtonCancel");
		g().SetColumnSpan(d(), 2);
		d().DialogResult = DialogResult.Cancel;
		d().Name = "ButtonCancel";
		d().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(e(), "ButtonNo");
		e().Name = "ButtonNo";
		e().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(f(), "ButtonYes");
		f().Name = "ButtonYes";
		f().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(h(), "TableLayoutPanel1");
		h().Controls.Add(g(), 0, 1);
		h().Controls.Add(c(), 0, 0);
		h().Name = "TableLayoutPanel1";
		componentResourceManager.ApplyResources(g(), "TableLayoutPanel2");
		g().Controls.Add(f(), 0, 0);
		g().Controls.Add(d(), 0, 1);
		g().Controls.Add(e(), 1, 0);
		g().Name = "TableLayoutPanel2";
		base.AcceptButton = f();
		componentResourceManager.ApplyResources(this, "$this");
		base.AutoScaleMode = AutoScaleMode.None;
		base.CancelButton = d();
		base.ControlBox = false;
		base.Controls.Add(h());
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Name = "DialogExitSoftware";
		base.ShowInTaskbar = false;
		h().ResumeLayout(performLayout: false);
		h().PerformLayout();
		g().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c()
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
	internal virtual Button d()
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
	internal virtual Button e()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = b;
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
	internal virtual Button f()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = c;
		Button button = this.m_e;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_e = A_0;
		button = this.m_e;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel g()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel h()
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

	public void a(string A_0, string A_1, string A_2, ref short A_3)
	{
		string A_4 = "NotSaved";
		Text = A_2 + hu.a(ref A_4);
		c().Text = A_0;
		Button button = d();
		A_4 = "ReturnToFmt";
		button.Text = string.Format(hu.a(ref A_4), A_1);
		ShowDialog();
		A_3 = this.m_h;
	}

	private void a()
	{
		this.m_h = -1;
	}

	private void c(object A_0, EventArgs A_1)
	{
		this.m_h = 6;
		Hide();
	}

	private void b(object A_0, EventArgs A_1)
	{
		this.m_h = 7;
		Hide();
	}

	private void a(object A_0, EventArgs A_1)
	{
		this.m_h = 2;
		Hide();
	}
}
