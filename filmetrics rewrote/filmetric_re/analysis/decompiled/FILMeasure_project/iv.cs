using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class iv : IEquatable<iv>
{
	public enum a
	{
		a,
		b
	}

	private string m_a;

	public List<iu> b;

	public iv(string A_0)
		: this(A_0, iv.a.b)
	{
	}

	public iv(string A_0, a A_1)
	{
		this.m_a = A_0;
		if (A_1 == iv.a.b)
		{
			b = new List<iu>();
			b.Add(new iu("<Default>"));
		}
	}

	public bool c(iv A_0)
	{
		return Operators.CompareString(A_0.c(), this.m_a, TextCompare: false) == 0;
	}

	bool IEquatable<iv>.Equals(iv A_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in c
		return this.c(A_0);
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}
		if (obj is iv)
		{
			return c((iv)obj);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.m_a.GetHashCode();
	}

	[SpecialName]
	public static bool d(iv A_0, iv A_1)
	{
		return A_0.c(A_1);
	}

	[SpecialName]
	public static bool c(iv A_0, iv A_1)
	{
		return !A_0.c(A_1);
	}

	[SpecialName]
	public string c()
	{
		return this.m_a;
	}
}
