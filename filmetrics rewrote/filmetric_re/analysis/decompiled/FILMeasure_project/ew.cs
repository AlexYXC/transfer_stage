using System;

internal class ew
{
	public enum a : byte
	{
		a,
		b,
		c,
		d,
		e
	}

	public static string b(a A_0)
	{
		return A_0 switch
		{
			ew.a.a => "Filmetrics", 
			ew.a.b => "Leybold", 
			ew.a.c => "Allied High Tech Products", 
			ew.a.d => "Heraeus", 
			_ => throw new Exception("Unknown Oem Code"), 
		};
	}

	public static string a(a A_0)
	{
		return b(A_0);
	}
}
