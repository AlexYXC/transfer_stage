using System;

internal class eb
{
	public enum a : byte
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g
	}

	public enum b : byte
	{
		a,
		b,
		c
	}

	public class c
	{
		public string a;

		public string b;

		public a c;

		public c()
		{
		}

		public c(string A_0, string A_1, a A_2)
		{
			a = A_0;
			b = A_1;
			c = A_2;
		}
	}

	public class d
	{
		public string a;

		public DateTime b;

		public d()
		{
		}

		public d(string A_0, DateTime A_1)
		{
			a = A_0;
			b = A_1;
		}
	}

	public const string a = "Local";

	public const string b = "Unreleased";

	public const string c = "Customer";

	public const string d = "Released";

	public const string e = "Shipping";

	public const string f = "Deleted";

	public const string g = "nk";

	public const string h = "rrr";

	public const string i = "ttt";

	public static string a(b A_0)
	{
		return A_0 switch
		{
			eb.b.a => "nk", 
			eb.b.b => "rrr", 
			eb.b.c => "ttt", 
			_ => throw new ApplicationException("Unknown file type"), 
		};
	}

	public static string a(a A_0)
	{
		return A_0 switch
		{
			eb.a.a => "Local", 
			eb.a.b => "Unreleased", 
			eb.a.c => "Customer", 
			eb.a.d => "Released", 
			eb.a.f => "Shipping", 
			eb.a.g => "Deleted", 
			_ => throw new ApplicationException("Unknown release level in MatFileDB.ReleaseLevelDescr"), 
		};
	}
}
