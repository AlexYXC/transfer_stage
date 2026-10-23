using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class c6
{
	public delegate void a(en A_0, Guid A_1, bool A_2);

	public delegate void b(int A_0, int A_1, int A_2);

	public delegate void c();

	[CompilerGenerated]
	private static a m_a;

	[CompilerGenerated]
	private static b m_b;

	[CompilerGenerated]
	private static c m_c;

	[SpecialName]
	[CompilerGenerated]
	public static void b(a A_0)
	{
		a a10 = c6.m_a;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Combine(a11, A_0);
			a10 = Interlocked.CompareExchange(ref c6.m_a, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public static void a(a A_0)
	{
		a a10 = c6.m_a;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Remove(a11, A_0);
			a10 = Interlocked.CompareExchange(ref c6.m_a, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public static void b(b A_0)
	{
		b b10 = c6.m_b;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Combine(b11, A_0);
			b10 = Interlocked.CompareExchange(ref c6.m_b, value, b11);
		}
		while ((object)b10 != b11);
	}

	[SpecialName]
	[CompilerGenerated]
	public static void a(b A_0)
	{
		b b10 = c6.m_b;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Remove(b11, A_0);
			b10 = Interlocked.CompareExchange(ref c6.m_b, value, b11);
		}
		while ((object)b10 != b11);
	}

	[SpecialName]
	[CompilerGenerated]
	public static void b(c A_0)
	{
		c c10 = c6.m_c;
		c c11;
		do
		{
			c11 = c10;
			c value = (c)Delegate.Combine(c11, A_0);
			c10 = Interlocked.CompareExchange(ref c6.m_c, value, c11);
		}
		while ((object)c10 != c11);
	}

	[SpecialName]
	[CompilerGenerated]
	public static void a(c A_0)
	{
		c c10 = c6.m_c;
		c c11;
		do
		{
			c11 = c10;
			c value = (c)Delegate.Remove(c11, A_0);
			c10 = Interlocked.CompareExchange(ref c6.m_c, value, c11);
		}
		while ((object)c10 != c11);
	}

	public static void a(en A_0, Guid A_1, bool A_2)
	{
		c6.m_a?.Invoke(A_0, A_1, A_2);
	}

	public static void a(int A_0, int A_1, int A_2)
	{
		c6.m_b?.Invoke(A_0, A_1, A_2);
	}

	public static void a()
	{
		c6.m_c?.Invoke();
	}
}
