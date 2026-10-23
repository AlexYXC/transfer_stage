using System;
using System.Runtime.CompilerServices;

internal class u : IComparable, IEquatable<u>
{
	public enum a
	{
		a,
		b
	}

	public a a;

	public a4.a b;

	public int c;

	public u(a A_0, a4.a A_1, int A_2)
	{
		this.a = A_0;
		b = A_1;
		c = A_2;
	}

	public int d(object A_0)
	{
		if (!(A_0 is u))
		{
			throw new Exception();
		}
		u u2 = (u)A_0;
		if (this.a == u.a.b)
		{
			if (this.a == u2.a)
			{
				return 0;
			}
			return 1;
		}
		if (b == u2.b)
		{
			if (c == u2.c)
			{
				return 0;
			}
			if (c > u2.c)
			{
				return 1;
			}
			return -1;
		}
		if (b > u2.b)
		{
			return 1;
		}
		return -1;
	}

	int IComparable.CompareTo(object A_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in d
		return this.d(A_0);
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (!(obj is u a_))
		{
			return false;
		}
		return d(a_);
	}

	public bool d(u A_0)
	{
		return d(this, A_0);
	}

	bool IEquatable<u>.Equals(u A_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in d
		return this.d(A_0);
	}

	[SpecialName]
	public static bool e(u A_0, u A_1)
	{
		switch (ix.a(A_0, A_1))
		{
		case ix.a.a:
			return false;
		case ix.a.b:
			return true;
		default:
			if (A_0.a != A_1.a)
			{
				return true;
			}
			if (A_0.a == u.a.a)
			{
				if (A_0.c != A_1.c)
				{
					return true;
				}
				if (A_0.b != A_1.b && (A_0.c > 0 || A_0.b == a4.a.d || A_1.b == a4.a.d))
				{
					return true;
				}
			}
			return false;
		}
	}

	[SpecialName]
	public static bool d(u A_0, u A_1)
	{
		return !e(A_0, A_1);
	}
}
