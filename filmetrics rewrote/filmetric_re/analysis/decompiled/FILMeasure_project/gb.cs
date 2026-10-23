using System.Runtime.CompilerServices;

internal class gb
{
	public double a;

	public double b;

	public double c;

	public double d;

	public void e(ref gb A_0)
	{
		A_0 = new gb();
		gb obj = A_0;
		obj.a = a;
		obj.b = b;
		obj.c = c;
		obj.d = d;
		_ = null;
	}

	public gb()
	{
	}

	public gb(double A_0, double A_1, double A_2, double A_3)
	{
		a = A_0;
		b = A_1;
		c = A_2;
		d = A_3;
	}

	[SpecialName]
	public static bool f(gb A_0, gb A_1)
	{
		if (A_0 == null && A_1 != null)
		{
			return true;
		}
		if (A_0 != null && A_1 == null)
		{
			return true;
		}
		if (A_0 == null && A_1 == null)
		{
			return false;
		}
		gb gb2 = A_0;
		if (gb2.a != A_1.a)
		{
			return true;
		}
		if (gb2.b != A_1.b)
		{
			return true;
		}
		if (gb2.c != A_1.c)
		{
			return true;
		}
		if (gb2.d != A_1.d)
		{
			return true;
		}
		gb2 = null;
		return false;
	}

	[SpecialName]
	public static bool e(gb A_0, gb A_1)
	{
		return !f(A_0, A_1);
	}
}
