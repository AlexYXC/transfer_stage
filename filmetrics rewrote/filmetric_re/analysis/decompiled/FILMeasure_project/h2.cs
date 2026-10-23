using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;

internal class h2
{
	public delegate void a();

	private DateTime m_a;

	[CompilerGenerated]
	private a b;

	[SpecialName]
	public DateTime c()
	{
		return this.m_a;
	}

	[SpecialName]
	public void c(DateTime A_0)
	{
		this.m_a = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void c(a A_0)
	{
		a a10 = b;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Combine(a11, A_0);
			a10 = Interlocked.CompareExchange(ref b, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void d(a A_0)
	{
		a a10 = b;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Remove(a11, A_0);
			a10 = Interlocked.CompareExchange(ref b, value, a11);
		}
		while ((object)a10 != a11);
	}

	public static void c(h2 A_0)
	{
		if (A_0 != null && DateTime.Now.Subtract(A_0.c()).TotalMilliseconds > 500.0)
		{
			A_0.d();
			A_0.c(DateAndTime.Now);
		}
	}

	public void d()
	{
		b?.Invoke();
	}

	public h2(a A_0)
	{
		this.m_a = DateTime.MinValue;
		if (A_0 != null)
		{
			c(A_0);
		}
	}

	public void e(a A_0)
	{
		d(A_0);
	}
}
