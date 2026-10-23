using System;
using System.Runtime.CompilerServices;

internal class l
{
	public enum a
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g,
		h,
		i
	}

	private string m_a;

	private string b;

	private bool c;

	private a d;

	private DateTime e;

	private string f;

	private bool g;

	private bool h;

	public l(string A_0, string A_1, bool A_2, a A_3, DateTime A_4, string A_5, bool A_6, bool A_7)
	{
		this.m_a = A_0;
		b = A_1;
		c = A_2;
		d = A_3;
		e = A_4;
		f = A_5;
		g = A_6;
		h = A_7;
	}

	[SpecialName]
	public string i()
	{
		return this.m_a;
	}

	[SpecialName]
	public string j()
	{
		return b;
	}

	[SpecialName]
	public bool k()
	{
		return c;
	}

	[SpecialName]
	public a l()
	{
		return d;
	}

	[SpecialName]
	public DateTime m()
	{
		return e;
	}

	[SpecialName]
	public string n()
	{
		return f;
	}

	[SpecialName]
	public bool o()
	{
		return g;
	}

	[SpecialName]
	public bool p()
	{
		return h;
	}
}
