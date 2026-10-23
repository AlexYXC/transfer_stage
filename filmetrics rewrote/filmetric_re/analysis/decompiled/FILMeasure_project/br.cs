using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class br : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private hy m_c;

	[CompilerGenerated]
	private Label m_d;

	[CompilerGenerated]
	private Label m_e;

	[CompilerGenerated]
	private hy m_f;

	[CompilerGenerated]
	private Button m_g;

	private Guid m_h;

	private fz m_i;

	private f1 m_j;

	private f4 k;

	private object l;

	private c1 m;

	private const string n = "DialogUVLightSourceTest";

	[CompilerGenerated]
	private r.c o;

	[CompilerGenerated]
	private r.d p;

	[CompilerGenerated]
	private r.d q;

	public br()
	{
		l = RuntimeHelpers.GetObjectValue(new object());
		c(new r.c());
		a(new r.d());
		b(new r.d());
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
		this.m_a = new Container();
		a(new Button());
		a(new Label());
		b(new Label());
		b(new Button());
		b(new hy());
		a(new hy());
		SuspendLayout();
		b().DialogResult = DialogResult.Cancel;
		b().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b().Location = new Point(71, 188);
		b().Margin = new Padding(4);
		b().Name = "ButtonClose";
		b().Size = new Size(100, 28);
		b().TabIndex = 1;
		b().Text = "Close";
		b().UseVisualStyleBackColor = true;
		d().AutoSize = true;
		d().Location = new Point(111, 32);
		d().Name = "Label1";
		d().Size = new Size(62, 16);
		d().TabIndex = 3;
		d().Text = "# Cycles:";
		e().AutoSize = true;
		e().Location = new Point(12, 60);
		e().Name = "Label2";
		e().Size = new Size(161, 16);
		e().TabIndex = 5;
		e().Text = "Delay between cycles (s):";
		g().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		g().Location = new Point(71, 95);
		g().Margin = new Padding(4);
		g().Name = "ButtonStart";
		g().Size = new Size(100, 28);
		g().TabIndex = 6;
		g().Text = "Start Test";
		g().UseVisualStyleBackColor = true;
		f().f(A_0: false);
		f().Location = new Point(179, 57);
		f().Name = "TextBoxNumDelay";
		f().e(A_0: false);
		f().Size = new Size(50, 22);
		f().TabIndex = 4;
		f().Text = "0.5";
		c().f(A_0: true);
		c().Location = new Point(179, 29);
		c().Name = "TextBoxNumCycles";
		c().e(A_0: false);
		c().Size = new Size(50, 22);
		c().TabIndex = 2;
		c().Text = "1000";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = b();
		base.ClientSize = new Size(242, 228);
		base.Controls.Add(g());
		base.Controls.Add(e());
		base.Controls.Add(f());
		base.Controls.Add(d());
		base.Controls.Add(c());
		base.Controls.Add(b());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogUVLightSourceTest";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "UV Light Source Test";
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
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hy A_0)
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
	internal virtual void a(Label A_0)
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
	internal virtual void b(Label A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy f()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(hy A_0)
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
	internal virtual void b(Button A_0)
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
	private virtual r.c h()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void c(r.c A_0)
	{
		r.c.a a_ = b;
		r.c.a a_2 = a;
		r.c.b a_3 = a;
		r.c c10 = o;
		if (c10 != null)
		{
			c10.w(a_);
			c10.u(a_2);
			c10.u(a_3);
		}
		o = A_0;
		c10 = o;
		if (c10 != null)
		{
			c10.v(a_);
			c10.t(a_2);
			c10.t(a_3);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d i()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		r.d.b a_ = b;
		p?.e(a_);
		p = A_0;
		p?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d j()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void b(r.d A_0)
	{
		r.d.b a_ = a;
		q?.e(a_);
		q = A_0;
		q?.d(a_);
	}

	public void a(fz A_0, f1 A_1, f4 A_2)
	{
		this.m_i = A_0;
		this.m_h = A_2.hc();
		this.m_j = A_1;
		k = A_2;
		ShowDialog();
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			int a_ = iz.c(c().Text);
			float a_2 = iz.d(f().Text);
			m = new c1();
			m.a(100);
			m.a(A_0: true);
			h().t(0f);
			h().a = false;
			this.m_j.m2(this.m_h, a_, a_2, h(), i(), r.d.a.b.a);
			m.b("Initializing...");
			object obj = l;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				if (m != null && m.DialogResult == DialogResult.Cancel)
				{
					h().a = true;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			i5.a(this.m_i, this.m_j, k, i6.a(this), "DialogUVLightSourceTest.ButtonStart_Click", a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void b(r.c A_0)
	{
		if (base.InvokeRequired)
		{
			BeginInvoke(new r.c.a(b), A_0);
			return;
		}
		try
		{
			object obj = l;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				if (m != null)
				{
					m.i();
					m = null;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_i.c(fz.b.b, "Exception in DialogUVLightSourceTest.mStatus_LongStepStartingEvent(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.c A_0)
	{
		if (base.InvokeRequired)
		{
			BeginInvoke(new r.c.a(a), A_0);
			return;
		}
		try
		{
			if (m != null)
			{
				m.a("Testing...");
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_i.c(fz.b.b, "Exception in DialogUVLightSourceTest.mStatus_LongStepStartingEvent(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.c A_0, bool A_1)
	{
		if (base.InvokeRequired)
		{
			BeginInvoke(new r.c.b(a), A_0, A_1);
			return;
		}
		try
		{
			if (m != null)
			{
				r.c c10 = A_0;
				m.b(checked((int)Math.Round(c10.t())));
				m.a(c10.u());
				c10 = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_i.c(fz.b.b, "Exception in DialogUVLightSourceTest.mStatus_StatusChangedEvent(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(r.d.a A_0)
	{
		if (base.InvokeRequired)
		{
			BeginInvoke(new r.d.b(b), A_0);
			return;
		}
		try
		{
			if (A_0.a != r.d.a.a.a)
			{
				fe.b(this.m_i, "Test Failure:" + A_0.b, i6.a(this));
				object obj = l;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					if (m != null)
					{
						m.i();
						m = null;
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
			}
			this.m_j.s4(this.m_h, j(), r.d.a.b.a);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_i.c(fz.b.b, "Exception in DialogUVLightSourceTest.mCompletionTask_TaskFinishedEvent(). ", a_);
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
			if (A_0.a == r.d.a.a.a)
			{
				fe.b(this.m_i, "Test completed", "Information", i6.a(this));
			}
			else
			{
				fe.b(this.m_i, "Error attempting to release USB control of light source:" + A_0.b, i6.a(this));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_i.c(fz.b.b, "Exception in DialogUVLightSourceTest.mCleanupCompletionTask_TaskFinishedEvent(). ", a_);
			ProjectData.ClearProjectError();
		}
	}
}
