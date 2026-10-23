using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class bd : Form
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
	private CheckBox m_f;

	private fz g;

	public bd()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(bd));
		a(new TableLayoutPanel());
		a(new Button());
		b(new Button());
		a(new CheckBox());
		b(new CheckBox());
		b().SuspendLayout();
		SuspendLayout();
		componentResourceManager.ApplyResources(b(), "TableLayoutPanel1");
		b().Controls.Add(c(), 0, 0);
		b().Controls.Add(d(), 1, 0);
		b().Name = "TableLayoutPanel1";
		componentResourceManager.ApplyResources(c(), "OK_Button");
		c().Name = "OK_Button";
		componentResourceManager.ApplyResources(d(), "Cancel_Button");
		d().DialogResult = DialogResult.Cancel;
		d().Name = "Cancel_Button";
		componentResourceManager.ApplyResources(e(), "ChkBoxAutoTrackActiveCurve");
		e().Checked = true;
		e().CheckState = CheckState.Checked;
		e().Name = "ChkBoxAutoTrackActiveCurve";
		e().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(f(), "ChkBoxAutoTrackCalcCurve");
		f().Checked = true;
		f().CheckState = CheckState.Checked;
		f().Name = "ChkBoxAutoTrackCalcCurve";
		f().UseVisualStyleBackColor = true;
		base.AcceptButton = c();
		componentResourceManager.ApplyResources(this, "$this");
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = d();
		base.Controls.Add(f());
		base.Controls.Add(e());
		base.Controls.Add(b());
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogCursorSettings";
		base.ShowInTaskbar = false;
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
	internal virtual CheckBox e()
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
	internal virtual CheckBox f()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(CheckBox A_0)
	{
		this.m_f = A_0;
	}

	public void a(fz A_0)
	{
		g = A_0;
		e().Checked = global::e.a().AutoTrackActiveCurve;
		f().Checked = global::e.a().AutoTrackCalcCurve;
		ShowDialog();
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			base.DialogResult = DialogResult.OK;
			global::e.a().AutoTrackActiveCurve = e().Checked;
			global::e.a().AutoTrackCalcCurve = f().Checked;
			Close();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			g.c(fz.b.a, "Error in OK_Button_Click", a_);
			ProjectData.ClearProjectError();
		}
	}
}
