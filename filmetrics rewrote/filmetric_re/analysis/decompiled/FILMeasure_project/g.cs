using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class g
{
	private string a;

	private bool b;

	public const string c = "1";

	[SpecialName]
	public static bool d(g A_0, g A_1)
	{
		switch (ix.a(A_0, A_1))
		{
		case ix.a.a:
			return false;
		case ix.a.b:
			return true;
		default:
		{
			g g10 = A_0;
			if (Operators.CompareString(g10.c(), A_1.c(), TextCompare: false) != 0)
			{
				return true;
			}
			if (g10.d() != A_1.d())
			{
				return true;
			}
			g10 = null;
			return false;
		}
		}
	}

	[SpecialName]
	public static bool c(g A_0, g A_1)
	{
		return !d(A_0, A_1);
	}

	[SpecialName]
	public string c()
	{
		return a;
	}

	[SpecialName]
	public void c(string A_0)
	{
		a = A_0;
	}

	[SpecialName]
	public bool d()
	{
		return b;
	}

	[SpecialName]
	public void c(bool A_0)
	{
		b = A_0;
	}

	public void c(ref g A_0)
	{
		A_0.c(a);
		A_0.c(b);
	}

	public void e()
	{
		a = "Si";
		b = false;
	}

	public void f()
	{
		a = "Si";
		b = true;
	}
}
