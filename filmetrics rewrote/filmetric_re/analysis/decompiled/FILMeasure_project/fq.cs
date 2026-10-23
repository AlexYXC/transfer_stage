using System.Runtime.CompilerServices;

internal class fq : fp
{
	protected double c;

	protected double d;

	protected bool e;

	protected bool f;

	public fq()
	{
		c = 0.0;
		d = 1.0;
	}

	[SpecialName]
	public double aw()
	{
		return c;
	}

	[SpecialName]
	public void ao(double A_0)
	{
		if (!jf.e(A_0, c))
		{
			c = A_0;
			a7();
		}
	}

	[SpecialName]
	public double ax()
	{
		return d;
	}

	[SpecialName]
	public void ap(double A_0)
	{
		if (!jf.e(A_0, d))
		{
			d = A_0;
			a7();
		}
	}

	[SpecialName]
	public bool ay()
	{
		return f;
	}

	[SpecialName]
	public void ar(bool A_0)
	{
		if (A_0 != f)
		{
			f = A_0;
			a7();
		}
	}

	[SpecialName]
	public bool az()
	{
		return e;
	}

	[SpecialName]
	public void @as(bool A_0)
	{
		if (A_0 != e)
		{
			e = A_0;
			a7();
		}
	}
}
