using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;

internal class gi
{
	public delegate void a(Guid A_0, Point A_1, r.d A_2, ref bool A_3);

	public delegate void b(Guid A_0, Point A_1, ref bb.a A_2);

	[CompilerGenerated]
	private a m_a;

	[CompilerGenerated]
	private b m_b;

	[SpecialName]
	[CompilerGenerated]
	public void c(a A_0)
	{
		a a10 = this.m_a;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Combine(a11, A_0);
			a10 = Interlocked.CompareExchange(ref this.m_a, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void d(a A_0)
	{
		a a10 = this.m_a;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Remove(a11, A_0);
			a10 = Interlocked.CompareExchange(ref this.m_a, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void c(b A_0)
	{
		b b10 = this.m_b;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Combine(b11, A_0);
			b10 = Interlocked.CompareExchange(ref this.m_b, value, b11);
		}
		while ((object)b10 != b11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void d(b A_0)
	{
		b b10 = this.m_b;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Remove(b11, A_0);
			b10 = Interlocked.CompareExchange(ref this.m_b, value, b11);
		}
		while ((object)b10 != b11);
	}

	public void c(Guid A_0, Point A_1, r.d A_2, ref bool A_3)
	{
		this.m_a?.Invoke(A_0, A_1, A_2, ref A_3);
	}

	public void c(Guid A_0, Point A_1, ref bb.a A_2)
	{
		this.m_b?.Invoke(A_0, A_1, ref A_2);
	}
}
