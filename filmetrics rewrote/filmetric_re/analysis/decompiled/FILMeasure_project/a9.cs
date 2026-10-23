using System.Runtime.CompilerServices;

internal class a9
{
	public enum a
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g
	}

	public enum b
	{
		a,
		b,
		c,
		d
	}

	public b a;

	public bool b;

	public a c;

	public double d;

	public int e;

	public float[] f;

	public float[] g;

	public float h;

	public float i;

	public float j;

	public float k;

	public float l;

	public float m;

	public double n;

	public bool o;

	public bool p;

	public double q;

	public int r;

	public float[] s;

	public float[] t;

	public float u;

	public float v;

	public float w;

	public float x;

	public float y;

	public float z;

	public double aa;

	public h.f ab;

	public float ac;

	public int ad;

	[SpecialName]
	public static string ae(a A_0)
	{
		return A_0 switch
		{
			a9.a.b => "High Power", 
			a9.a.c => "Low Power", 
			a9.a.d => "Infrared", 
			a9.a.e => "LS-DT", 
			a9.a.f => "LS-DT2", 
			a9.a.g => "HST-DB566", 
			a9.a.a => "Unknown", 
			_ => "Unknown Type", 
		};
	}

	[SpecialName]
	public static string ae(b A_0)
	{
		return A_0 switch
		{
			a9.b.b => "External", 
			a9.b.c => "USB", 
			a9.b.d => "USB Charging Port", 
			_ => "Unknown Type", 
		};
	}
}
