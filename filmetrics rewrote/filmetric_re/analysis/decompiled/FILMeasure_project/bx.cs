using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Filmetrics.My.Resources;

internal class bx
{
	public enum a
	{
		a,
		b
	}

	public enum b
	{
		a,
		b,
		c,
		d
	}

	private PictureBox m_a;

	private Bitmap m_b;

	private Bitmap c;

	private Bitmap d;

	private Bitmap e;

	private bool m_f;

	public bx(PictureBox A_0, bool A_1)
	{
		this.m_a = A_0;
		this.m_f = A_1;
		if (this.m_f)
		{
			this.m_b = Resources.OutlineHorizExpanded;
			c = Resources.OutlineHorizExpandedWhite;
			d = Resources.OutlineHorizContracted;
			e = Resources.OutlineHorizContractedWhite;
		}
		else
		{
			this.m_b = Resources.OutlineVertExpanded;
			c = Resources.OutlineVertExpandedWhite;
			d = Resources.OutlineVertContracted;
			e = Resources.OutlineVertContractedWhite;
		}
		this.m_a.Image = this.m_b;
		this.m_a.Tag = bx.a.a;
	}

	public void f(b A_0)
	{
		PictureBox pictureBox = this.m_a;
		pictureBox.Tag = g(A_0);
		if (this.m_f)
		{
			pictureBox.Width = 1;
		}
		else
		{
			pictureBox.Height = 1;
		}
		f();
		pictureBox = null;
	}

	public void f()
	{
		PictureBox pictureBox = this.m_a;
		a a10 = i();
		if (f(pictureBox.BackColor))
		{
			if (a10 == bx.a.a)
			{
				pictureBox.Image = c;
			}
			else
			{
				pictureBox.Image = e;
			}
		}
		else if (a10 == bx.a.a)
		{
			pictureBox.Image = this.m_b;
		}
		else
		{
			pictureBox.Image = d;
		}
		pictureBox = null;
	}

	public b f(bool A_0)
	{
		if (A_0)
		{
			return bx.b.d;
		}
		return bx.b.c;
	}

	public void g()
	{
		PictureBox pictureBox = this.m_a;
		if (pictureBox.Enabled)
		{
			pictureBox.BackColor = Color.FromKnownColor(KnownColor.HotTrack);
			f();
			pictureBox = null;
		}
	}

	public void h()
	{
		this.m_a.BackColor = Color.Transparent;
		f();
		_ = null;
	}

	[SpecialName]
	public a g(b A_0)
	{
		a a10 = i();
		switch (A_0)
		{
		case bx.b.a:
			if (a10 == bx.a.a)
			{
				return bx.a.b;
			}
			return bx.a.a;
		case bx.b.d:
			return bx.a.b;
		case bx.b.c:
			return bx.a.a;
		default:
			return a10;
		}
	}

	[SpecialName]
	public void g(Color A_0)
	{
		this.m_a.BackColor = A_0;
	}

	[SpecialName]
	public void f(int A_0)
	{
		this.m_a.Width = A_0;
	}

	[SpecialName]
	public void g(int A_0)
	{
		this.m_a.Height = A_0;
	}

	[SpecialName]
	public void f(object A_0)
	{
		this.m_a.Tag = RuntimeHelpers.GetObjectValue(A_0);
	}

	public a i()
	{
		return (a)this.m_a.Tag;
	}

	private bool f(Color A_0)
	{
		return checked(A_0.R + A_0.G + A_0.B) < 384;
	}
}
