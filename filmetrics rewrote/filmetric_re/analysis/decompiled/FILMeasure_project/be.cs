using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class be : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private CheckBox m_b;

	[CompilerGenerated]
	private CheckBox m_c;

	private fz m_d;

	private f1 m_e;

	private f4 m_f;

	private Guid m_g;

	private string h;

	[CompilerGenerated]
	private r.d i;

	private int j;

	public be()
	{
		h = "DialogDualFiberShutterTest";
		a(new r.d());
		d();
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
	private void d()
	{
		a(new CheckBox());
		b(new CheckBox());
		SuspendLayout();
		e().AutoSize = true;
		e().Location = new Point(60, 27);
		e().Margin = new Padding(4);
		e().Name = "CheckBoxShutter1Open";
		e().Size = new Size(121, 20);
		e().TabIndex = 0;
		e().Text = "Shutter #1 Open";
		e().UseVisualStyleBackColor = true;
		f().AutoSize = true;
		f().Location = new Point(60, 55);
		f().Margin = new Padding(4);
		f().Name = "CheckBoxShutter2Open";
		f().Size = new Size(121, 20);
		f().TabIndex = 1;
		f().Text = "Shutter #2 Open";
		f().UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(233, 105);
		base.Controls.Add(f());
		base.Controls.Add(e());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogDualFiberShutterTest";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Dual Fiber Shutter Test";
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox e()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(CheckBox A_0)
	{
		EventHandler value = a;
		CheckBox checkBox = this.m_b;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_b = A_0;
		checkBox = this.m_b;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox f()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(CheckBox A_0)
	{
		EventHandler value = a;
		CheckBox checkBox = this.m_c;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_c = A_0;
		checkBox = this.m_c;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d g()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		r.d.b a_ = a;
		i?.e(a_);
		i = A_0;
		i?.d(a_);
	}

	public void a(fz A_0, f1 A_1, f4 A_2)
	{
		this.m_d = A_0;
		this.m_e = A_1;
		this.m_f = A_2;
		this.m_g = this.m_f.hc();
		bool A_3 = default(bool);
		bool A_4 = default(bool);
		this.m_e.m2(this.m_g, ref A_3, ref A_4);
		a();
		try
		{
			e().Checked = A_3;
			f().Checked = A_4;
		}
		finally
		{
			b();
		}
		ShowDialog();
	}

	[SpecialName]
	private bool c()
	{
		return j > 0;
	}

	private void b()
	{
		checked
		{
			j--;
			if (j < 0)
			{
				j = 0;
			}
		}
	}

	private void a()
	{
		checked
		{
			j++;
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			if (!c())
			{
				this.m_e.m2(this.m_g, e().Checked, f().Checked, g(), r.d.a.b.a);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_d, this.m_e, null, i6.a(e()), h + ".CheckBoxShutterOpen_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.d.a A_0)
	{
		if (base.InvokeRequired)
		{
			BeginInvoke(new r.d.b(a), A_0);
			return;
		}
		try
		{
			if (A_0.a != r.d.a.a.a)
			{
				fe.b(this.m_d, "Shutter State Change Failure:" + A_0.b, i6.a(this));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_d.c(fz.b.b, "Exception in " + h + ".mCompletionTask_TaskFinishedEvent(). ", a_);
			ProjectData.ClearProjectError();
		}
	}
}
