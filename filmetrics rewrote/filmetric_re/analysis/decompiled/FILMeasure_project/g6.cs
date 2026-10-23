using System.Runtime.CompilerServices;

internal class g6
{
	internal enum a
	{
		a,
		b,
		c
	}

	private a m_a;

	private bool b;

	private float c;

	public g6()
		: this(global::e.a().WavelenCalEnable, (a)global::e.a().WavelenCalMode, global::e.a().WavelenCalPeriodMinutes)
	{
	}

	public g6(bool A_0, a A_1, float A_2)
	{
		b = A_0;
		this.m_a = A_1;
		c = A_2;
	}

	[SpecialName]
	public static bool e(g6 A_0, g6 A_1)
	{
		switch (ix.a(A_0, A_1))
		{
		case ix.a.a:
			return false;
		case ix.a.b:
			return true;
		default:
		{
			g6 g10 = A_0;
			if (g10.d() != A_1.d())
			{
				return true;
			}
			if (g10.e() != A_1.e())
			{
				return true;
			}
			if (g10.f() != A_1.f())
			{
				return true;
			}
			g10 = null;
			return false;
		}
		}
	}

	[SpecialName]
	public static bool d(g6 A_0, g6 A_1)
	{
		return !e(A_0, A_1);
	}

	[SpecialName]
	public a d()
	{
		return this.m_a;
	}

	[SpecialName]
	public bool e()
	{
		return b;
	}

	[SpecialName]
	public float f()
	{
		return c;
	}
}
