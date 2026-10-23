using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class hj
{
	public enum a
	{
		a,
		b,
		c
	}

	private string m_a;

	private a b;

	private bool c;

	public hj(string A_0, a A_1, bool A_2)
	{
		this.m_a = A_0;
		b = A_1;
		c = A_2;
	}

	public hj d()
	{
		return new hj(this.m_a, b, c);
	}

	[SpecialName]
	public string e()
	{
		return this.m_a;
	}

	[SpecialName]
	public a f()
	{
		return b;
	}

	[SpecialName]
	public bool g()
	{
		return c;
	}

	[SpecialName]
	public static bool e(hj A_0, hj A_1)
	{
		switch (ix.a(A_0, A_1))
		{
		case ix.a.a:
			return false;
		case ix.a.b:
			return true;
		default:
		{
			hj hj2 = A_0;
			if (hj2.g() != A_1.g())
			{
				return true;
			}
			if (Operators.CompareString(hj2.e(), A_1.e(), TextCompare: false) != 0)
			{
				return true;
			}
			if (hj2.f() != A_1.f())
			{
				return true;
			}
			hj2 = null;
			return false;
		}
		}
	}

	[SpecialName]
	public static bool d(hj A_0, hj A_1)
	{
		return !e(A_0, A_1);
	}
}
