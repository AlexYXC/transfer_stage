using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class fj : Form
{
	internal class a
	{
		protected bool u;

		protected Control v;

		public a()
		{
			u = false;
		}

		[SpecialName]
		public bool aq()
		{
			return u;
		}

		[SpecialName]
		public void z(bool A_0)
		{
			u = A_0;
		}

		[SpecialName]
		public Control ar()
		{
			return v;
		}

		[SpecialName]
		public void w(Control A_0)
		{
			v = A_0;
		}
	}

	public delegate void b(object A_0);

	private IContainer m_a;

	[CompilerGenerated]
	private b m_b;

	protected fz c;

	protected fj d;

	protected Collection e;

	protected a f;

	protected fe g;

	protected DialogResult h;

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
		SuspendLayout();
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(292, 266);
		base.ControlBox = false;
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.Name = "DialogTemplate";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.Manual;
		Text = "Title here";
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	public void b(b A_0)
	{
		b b10 = this.m_b;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Combine(b11, A_0);
			b10 = Interlocked.CompareExchange(ref this.m_b, value, b11);
		}
		while ((object)b10 != b11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void c(b A_0)
	{
		b b10 = this.m_b;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Remove(b11, A_0);
			b10 = Interlocked.CompareExchange(ref this.m_b, value, b11);
		}
		while ((object)b10 != b11);
	}

	[SpecialName]
	protected void c(fz A_0)
	{
		this.c = A_0;
	}

	[SpecialName]
	protected fz c3()
	{
		return this.c;
	}

	[SpecialName]
	protected virtual Control af()
	{
		return f.ar();
	}

	protected DialogResult b(Point A_0)
	{
		h = DialogResult.OK;
		i6.a(A_0, this);
		return ShowDialog();
	}

	public void c4()
	{
		Close();
	}

	public void b(object A_0)
	{
		if (d != null)
		{
			d.c(this);
			Control control = d.af();
			d.Close();
			d = null;
			if (control != null)
			{
				if (control.CanFocus)
				{
					control.Focus();
				}
				if (control.CanSelect)
				{
					control.Select();
				}
			}
		}
		else
		{
			c3().c(fz.b.b, "Error closing open dialog.", Environment.StackTrace);
		}
	}

	public void c(bool A_0)
	{
		if (d != null)
		{
			d.TopMost = A_0;
			d.c(A_0);
		}
	}

	public fj()
	{
		fz A_ = null;
		this._002Ector(ref A_);
	}

	public fj(ref fz A_0)
	{
		b();
		c(A_0);
		e = new Collection();
		f = new a();
	}

	public void c5()
	{
		if (d != null)
		{
			d.c5();
		}
		h = DialogResult.Cancel;
		c4();
	}

	public void c6()
	{
		h = DialogResult.OK;
		c4();
	}

	public void b(p A_0)
	{
		e.Add(A_0);
	}

	public void c(object A_0)
	{
		string A_1 = "";
		foreach (p item in e)
		{
			if (item.m2(RuntimeHelpers.GetObjectValue(A_0), ref A_1) == p.b.b && c3() != null)
			{
				c3().c(fz.b.b, "Error unlocking locked object. Locked message is: " + A_1);
			}
		}
	}
}
