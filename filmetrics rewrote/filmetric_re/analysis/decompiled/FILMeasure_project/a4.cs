internal class a4
{
	public enum a
	{
		a,
		b,
		c,
		d
	}

	public enum b : short
	{
		a,
		b
	}

	public enum c : short
	{
		a,
		b,
		c
	}

	internal class d
	{
		public a a;

		public b b;

		public c c;
	}

	public void a()
	{
	}

	public static string a(a A_0)
	{
		return A_0 switch
		{
			a4.a.a => "CIE-L*a*b*", 
			a4.a.c => "CIE-L*C*h", 
			a4.a.b => "CIE-L*u*v*", 
			a4.a.d => "CIE-XYZ", 
			_ => "Unknown", 
		};
	}

	public static string a(b A_0)
	{
		return A_0 switch
		{
			b.a => "2 Degrees", 
			b.b => "10 Degrees", 
			_ => "Unknown", 
		};
	}

	public static string a(c A_0)
	{
		return A_0 switch
		{
			c.a => "D65", 
			c.b => "C", 
			c.c => "D50", 
			_ => "Unknown", 
		};
	}
}
