using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

internal class e1 : PictureBox
{
	private IContainer a;

	[CompilerGenerated]
	private ScrollEventHandler b;

	private bool c;

	private HScrollBar d;

	private VScrollBar e;

	private Control f;

	private int g;

	private int m_h;

	[DebuggerNonUserCode]
	public e1(IContainer A_0)
		: this()
	{
		A_0?.Add(this);
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && a != null)
			{
				a.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void l()
	{
		a = new Container();
	}

	[SpecialName]
	[CompilerGenerated]
	public void h(ScrollEventHandler A_0)
	{
		ScrollEventHandler scrollEventHandler = b;
		ScrollEventHandler scrollEventHandler2;
		do
		{
			scrollEventHandler2 = scrollEventHandler;
			ScrollEventHandler value = (ScrollEventHandler)Delegate.Combine(scrollEventHandler2, A_0);
			scrollEventHandler = Interlocked.CompareExchange(ref b, value, scrollEventHandler2);
		}
		while ((object)scrollEventHandler != scrollEventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(ScrollEventHandler A_0)
	{
		ScrollEventHandler scrollEventHandler = b;
		ScrollEventHandler scrollEventHandler2;
		do
		{
			scrollEventHandler2 = scrollEventHandler;
			ScrollEventHandler value = (ScrollEventHandler)Delegate.Remove(scrollEventHandler2, A_0);
			scrollEventHandler = Interlocked.CompareExchange(ref b, value, scrollEventHandler2);
		}
		while ((object)scrollEventHandler != scrollEventHandler2);
	}

	[SpecialName]
	public HScrollBar m()
	{
		return d;
	}

	[SpecialName]
	public int n()
	{
		return g;
	}

	[SpecialName]
	public void h(int A_0)
	{
		g = A_0;
	}

	[SpecialName]
	public int o()
	{
		return this.m_h;
	}

	[SpecialName]
	public void i(int A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	public VScrollBar p()
	{
		return e;
	}

	[SpecialName]
	private Control k()
	{
		return f;
	}

	public e1()
	{
		c = true;
		d = new HScrollBar();
		e = new VScrollBar();
		f = new Control();
		l();
		m().Visible = false;
		m().Dock = DockStyle.Bottom;
		m().Minimum = 0;
		m().Maximum = g;
		m().Scroll += h;
		k().Visible = false;
		k().Width = p().Width;
		k().Height = base.Height;
		k().Dock = DockStyle.Right;
		k().BackColor = SystemColors.ButtonFace;
		p().Top = 0;
		p().Left = 0;
		p().Height = checked(k().Height - m().Height);
		p().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		p().Minimum = 0;
		p().Maximum = this.m_h;
		p().Scroll += h;
		k().Controls.Add(p());
		base.Controls.Add(m());
		base.Controls.Add(k());
		DoubleBuffered = true;
		base.SizeMode = PictureBoxSizeMode.Normal;
	}

	[SpecialName]
	public bool q()
	{
		return c;
	}

	[SpecialName]
	public void h(bool A_0)
	{
		if (c != A_0)
		{
			c = A_0;
			Invalidate();
		}
	}

	protected virtual void h(ScrollEventArgs A_0)
	{
		b?.Invoke(this, A_0);
	}

	protected void h(object A_0, ScrollEventArgs A_1)
	{
		Refresh();
		h(A_1);
	}

	protected override void OnResize(EventArgs e)
	{
		base.OnResize(e);
		if (j())
		{
			i();
			Refresh();
		}
	}

	private bool j()
	{
		if (r() == null || !q() || (base.SizeMode != PictureBoxSizeMode.CenterImage && base.SizeMode != PictureBoxSizeMode.Normal))
		{
			m().Visible = false;
			k().Visible = false;
		}
		else
		{
			m().Visible = base.Width < g;
			k().Visible = base.Height < this.m_h;
		}
		if (!m().Visible)
		{
			return k().Visible;
		}
		return true;
	}

	private void i()
	{
		checked
		{
			if (m().Visible)
			{
				m().Maximum = g - 1;
				m().LargeChange = base.Width;
				m().SmallChange = 1;
			}
			if (k().Visible)
			{
				p().Maximum = this.m_h - 1;
				p().LargeChange = base.Height;
				p().SmallChange = 1;
			}
		}
	}

	protected override void OnSizeModeChanged(EventArgs e)
	{
		base.OnSizeModeChanged(e);
		h();
	}

	private void h()
	{
		if (r() != null && j())
		{
			i();
		}
	}

	[SpecialName]
	public Image r()
	{
		return base.Image;
	}

	[SpecialName]
	public void h(Image A_0)
	{
		base.Image = A_0;
		h();
	}
}
