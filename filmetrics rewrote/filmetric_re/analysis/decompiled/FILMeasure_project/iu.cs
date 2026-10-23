using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class iu : IEquatable<iu>
{
	public enum a
	{
		a,
		b
	}

	private string m_a;

	public List<string> b;

	public iu(string A_0)
		: this(A_0, iu.a.b)
	{
	}

	public iu(string A_0, a A_1)
	{
		this.m_a = A_0;
		if (A_1 != iu.a.a)
		{
			b = new List<string>();
			b.Add("<Default>");
		}
	}

	public bool c(iu A_0)
	{
		return Operators.CompareString(A_0.c(), this.m_a, TextCompare: false) == 0;
	}

	bool IEquatable<iu>.Equals(iu A_0)
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
		if (obj is iu)
		{
			return c((iu)obj);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.m_a.GetHashCode();
	}

	public override string ToString()
	{
		return this.m_a;
	}

	[SpecialName]
	public static bool d(iu A_0, iu A_1)
	{
		return A_0.c(A_1);
	}

	[SpecialName]
	public static bool c(iu A_0, iu A_1)
	{
		return !A_0.c(A_1);
	}

	[SpecialName]
	public string c()
	{
		return this.m_a;
	}
}
