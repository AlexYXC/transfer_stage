using System.Runtime.CompilerServices;

internal class jk
{
	public enum a : short
	{
		a = 1,
		b,
		c
	}

	public a a;

	public float b;

	public float c;

	public int d;

	public float e;

	public bool f;

	public bool g;

	public bool h;

	public float i;

	public bool j;

	public float k;

	public bool l;

	public float m;

	public bool n;

	public float o;

	public bool p;

	public float q;

	public jk()
	{
		this.a = jk.a.b;
		f = true;
		i = 1f;
		r();
	}

	[SpecialName]
	public static bool s(jk A_0, jk A_1)
	{
		switch (ix.a(A_0, A_1))
		{
		case ix.a.a:
			return false;
		case ix.a.b:
			return true;
		default:
		{
			jk jk2 = A_0;
			if (jk2.a != A_1.a)
			{
				return true;
			}
			if (jk2.b != A_1.b)
			{
				return true;
			}
			if (jk2.c != A_1.c)
			{
				return true;
			}
			if (jk2.d != A_1.d)
			{
				return true;
			}
			if (jk2.e != A_1.e)
			{
				return true;
			}
			if (jk2.f != A_1.f)
			{
				return true;
			}
			if (jk2.g != A_1.g)
			{
				return true;
			}
			if (jk2.h != A_1.h)
			{
				return true;
			}
			if (jk2.i != A_1.i)
			{
				return true;
			}
			if (jk2.j != A_1.j)
			{
				return true;
			}
			if (jk2.k != A_1.k)
			{
				return true;
			}
			if (jk2.l != A_1.l)
			{
				return true;
			}
			if (jk2.m != A_1.m)
			{
				return true;
			}
			if (jk2.n != A_1.n)
			{
				return true;
			}
			if (jk2.o != A_1.o)
			{
				return true;
			}
			if (jk2.p != A_1.p)
			{
				return true;
			}
			if (jk2.q != A_1.q)
			{
				return true;
			}
			jk2 = null;
			return false;
		}
		}
	}

	[SpecialName]
	public static bool r(jk A_0, jk A_1)
	{
		return !s(A_0, A_1);
	}

	public bool r(jk A_0)
	{
		return r(this, A_0);
	}

	public void r(ref jk A_0)
	{
		if (A_0 == null)
		{
			A_0 = new jk();
		}
		jk obj = A_0;
		obj.a = this.a;
		obj.b = b;
		obj.c = c;
		obj.d = d;
		obj.e = e;
		obj.f = f;
		obj.g = g;
		obj.h = h;
		obj.i = i;
		obj.j = j;
		obj.k = k;
		obj.l = l;
		obj.m = m;
		obj.n = n;
		obj.o = o;
		obj.p = p;
		obj.q = q;
		_ = null;
	}

	public static float s(float A_0, float A_1)
	{
		return (float)(3.6865 + 0.0011817 * (double)A_0 - 4.85962E-07 * (double)A_0 * (double)A_0 - 0.00332 * ((double)A_1 - 600.48));
	}

	public static float r(float A_0, float A_1)
	{
		return (float)(3.0431 + 0.00044937 * (double)A_0 - 0.001378 * ((double)A_1 - 600.48));
	}

	public void r()
	{
		this.a = jk.a.b;
		b = 4f;
		c = 650f;
		d = 0;
		e = 0f;
		f = true;
		g = false;
		h = true;
		i = 1f;
		j = false;
		k = 0f;
		l = false;
		m = 4f;
		n = true;
		o = 0f;
		p = false;
		q = 600f;
	}

	public static float t(float A_0, a A_1)
	{
		return A_1 switch
		{
			jk.a.a => 10f * A_0, 
			jk.a.b => A_0, 
			jk.a.c => 3.6f * A_0, 
			_ => A_0, 
		};
	}

	public static float s(float A_0, a A_1)
	{
		return A_1 switch
		{
			jk.a.a => 0.1f * A_0, 
			jk.a.b => A_0, 
			jk.a.c => A_0 / 3.6f, 
			_ => A_0, 
		};
	}

	public static string r(a A_0)
	{
		return A_0 switch
		{
			jk.a.a => h4.e(new h4(h4.a.a), false, false) + "/s", 
			jk.a.b => h4.e(new h4(h4.a.b), false, false) + "/s", 
			jk.a.c => h4.e(new h4(h4.a.c), false, false) + "/h", 
			_ => null, 
		};
	}

	public static string r(float A_0, a A_1)
	{
		return A_1 switch
		{
			jk.a.a => t(A_0, A_1).ToString("#0.0000"), 
			jk.a.b => t(A_0, A_1).ToString("#0.000"), 
			jk.a.c => t(A_0, A_1).ToString("#0.000"), 
			_ => null, 
		};
	}
}
