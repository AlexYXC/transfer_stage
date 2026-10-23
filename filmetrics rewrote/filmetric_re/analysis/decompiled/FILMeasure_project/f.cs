using System.Runtime.CompilerServices;

internal class f
{
	public enum a
	{
		a,
		b,
		c,
		d
	}

	public enum b
	{
		a = -1,
		b,
		c,
		d
	}

	public enum c
	{
		a,
		b,
		c
	}

	private a m_a;

	private double[] m_b;

	private int[] m_c;

	private double[] d;

	public f()
	{
		this.m_b = new double[2];
		this.m_c = new int[2];
		d = new double[2];
	}

	[SpecialName]
	public static bool h(f A_0, f A_1)
	{
		switch (ix.a(A_0, A_1))
		{
		case ix.a.a:
			return false;
		case ix.a.b:
			return true;
		default:
		{
			f f10 = A_0;
			if (f10.b(f.b.b) != A_1.b(f.b.b))
			{
				return true;
			}
			if (f10.b(f.b.c) != A_1.b(f.b.c))
			{
				return true;
			}
			if (f10.h(f.b.b) != A_1.h(f.b.b))
			{
				return true;
			}
			if (f10.h(f.b.c) != A_1.h(f.b.c))
			{
				return true;
			}
			if (f10.h() != A_1.h())
			{
				return true;
			}
			f10 = null;
			return false;
		}
		}
	}

	[SpecialName]
	public static bool b(f A_0, f A_1)
	{
		return !h(A_0, A_1);
	}

	[SpecialName]
	public string b()
	{
		return b(this.m_a);
	}

	[SpecialName]
	public static string b(a A_0)
	{
		return A_0 switch
		{
			f.a.a => "All", 
			f.a.b => "Short", 
			f.a.c => "Long", 
			f.a.d => "Extended", 
			_ => throw new ax("Invalid Spectrometer Range Name"), 
		};
	}

	[SpecialName]
	public a b(bool A_0)
	{
		if (A_0 || (this.m_a != f.a.a && this.m_a != f.a.d))
		{
			return this.m_a;
		}
		return f.a.b;
	}

	[SpecialName]
	public a h()
	{
		return this.m_a;
	}

	[SpecialName]
	public void h(a A_0)
	{
		this.m_a = A_0;
	}

	[SpecialName]
	public double b(b A_0)
	{
		return this.m_b[(int)A_0];
	}

	[SpecialName]
	public void b(b A_0, double A_1)
	{
		this.m_b[(int)A_0] = A_1;
	}

	[SpecialName]
	public int h(b A_0)
	{
		return this.m_c[(int)A_0];
	}

	[SpecialName]
	public void b(b A_0, int A_1)
	{
		this.m_c[(int)A_0] = A_1;
	}

	[SpecialName]
	public double i(b A_0)
	{
		return d[(int)A_0];
	}

	[SpecialName]
	public void h(b A_0, double A_1)
	{
		d[(int)A_0] = A_1;
	}

	public void b(b A_0, double A_1, int A_2)
	{
		this.m_b[(int)A_0] = A_1;
		if (A_2 <= 0)
		{
			this.m_c[(int)A_0] = 1;
		}
		else
		{
			this.m_c[(int)A_0] = A_2;
		}
	}

	public void b(ref f A_0)
	{
		f f10 = A_0;
		f10.h(h());
		b b10 = f.b.b;
		do
		{
			f10.b(b10, this.m_b[(int)b10], this.m_c[(int)b10]);
			f10.h(b10, d[(int)b10]);
			b10++;
		}
		while (b10 <= f.b.c);
		f10 = null;
	}

	public void i()
	{
		this.m_a = f.a.a;
		int num = 0;
		do
		{
			this.m_b[num] = 40.0;
			this.m_c[num] = 1;
			d[num] = 0.0;
			num = checked(num + 1);
		}
		while (num <= 1);
	}

	public void j()
	{
		int num = 0;
		do
		{
			this.m_c[num] = 1;
			num = checked(num + 1);
		}
		while (num <= 1);
	}
}
