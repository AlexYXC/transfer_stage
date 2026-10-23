using System;
using System.Runtime.CompilerServices;
using System.Threading;

internal class fs : fq
{
	public new delegate void a(ref double A_0);

	public delegate void b();

	[CompilerGenerated]
	private a n;

	[CompilerGenerated]
	private a o;

	[CompilerGenerated]
	private b p;

	[SpecialName]
	[CompilerGenerated]
	public void am(a A_0)
	{
		a a10 = n;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Combine(a11, A_0);
			a10 = Interlocked.CompareExchange(ref n, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void an(a A_0)
	{
		a a10 = n;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Remove(a11, A_0);
			a10 = Interlocked.CompareExchange(ref n, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void ao(a A_0)
	{
		a a10 = o;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Combine(a11, A_0);
			a10 = Interlocked.CompareExchange(ref o, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void ap(a A_0)
	{
		a a10 = o;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Remove(a11, A_0);
			a10 = Interlocked.CompareExchange(ref o, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void am(b A_0)
	{
		b b10 = p;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Combine(b11, A_0);
			b10 = Interlocked.CompareExchange(ref p, value, b11);
		}
		while ((object)b10 != b11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void an(b A_0)
	{
		b b10 = p;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Remove(b11, A_0);
			b10 = Interlocked.CompareExchange(ref p, value, b11);
		}
		while ((object)b10 != b11);
	}

	public void am(ref double A_0)
	{
		o?.Invoke(ref A_0);
	}

	public void an(ref double A_0)
	{
		n?.Invoke(ref A_0);
	}

	public void an()
	{
		p?.Invoke();
	}
}
