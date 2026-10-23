using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class it : IEquatable<it>
{
	private string a;

	private int b;

	private int c;

	public List<int> d;

	public it(string A_0)
		: this(A_0, 0, 0)
	{
	}

	public it(string A_0, int A_1, int A_2)
	{
		a = A_0;
		b = A_1;
		c = A_2;
	}

	public bool e(it A_0)
	{
		return Operators.CompareString(A_0.e(), a, TextCompare: false) == 0;
	}

	bool IEquatable<it>.Equals(it A_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in e
		return this.e(A_0);
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}
		if (obj is it)
		{
			return e((it)obj);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return a.GetHashCode();
	}

	[SpecialName]
	public static bool f(it A_0, it A_1)
	{
		return A_0.e(A_1);
	}

	[SpecialName]
	public static bool e(it A_0, it A_1)
	{
		return !A_0.e(A_1);
	}

	[SpecialName]
	public string e()
	{
		return a;
	}

	[SpecialName]
	public int f()
	{
		return c;
	}

	[SpecialName]
	public int g()
	{
		return b;
	}
}
