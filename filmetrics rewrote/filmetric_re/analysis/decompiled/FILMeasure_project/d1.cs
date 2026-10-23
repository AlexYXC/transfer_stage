using System;
using System.Runtime.CompilerServices;
using System.Threading;

internal class d1
{
	public delegate void a();

	public delegate void b(ref long A_0);

	public delegate void c(r.d.a.b A_0);

	public delegate void d(object A_0);

	[CompilerGenerated]
	private a m_a;

	[CompilerGenerated]
	private b m_b;

	[CompilerGenerated]
	private c m_c;

	[CompilerGenerated]
	private d m_d;

	[SpecialName]
	[CompilerGenerated]
	public void e(a A_0)
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
	public void f(a A_0)
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
	public void e(b A_0)
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
	public void f(b A_0)
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

	[SpecialName]
	[CompilerGenerated]
	public void e(c A_0)
	{
		c c10 = this.m_c;
		c c11;
		do
		{
			c11 = c10;
			c value = (c)Delegate.Combine(c11, A_0);
			c10 = Interlocked.CompareExchange(ref this.m_c, value, c11);
		}
		while ((object)c10 != c11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void f(c A_0)
	{
		c c10 = this.m_c;
		c c11;
		do
		{
			c11 = c10;
			c value = (c)Delegate.Remove(c11, A_0);
			c10 = Interlocked.CompareExchange(ref this.m_c, value, c11);
		}
		while ((object)c10 != c11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void e(d A_0)
	{
		d d10 = this.m_d;
		d d11;
		do
		{
			d11 = d10;
			d value = (d)Delegate.Combine(d11, A_0);
			d10 = Interlocked.CompareExchange(ref this.m_d, value, d11);
		}
		while ((object)d10 != d11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void f(d A_0)
	{
		d d10 = this.m_d;
		d d11;
		do
		{
			d11 = d10;
			d value = (d)Delegate.Remove(d11, A_0);
			d10 = Interlocked.CompareExchange(ref this.m_d, value, d11);
		}
		while ((object)d10 != d11);
	}

	public void e()
	{
		this.m_a?.Invoke();
	}

	public void e(ref long A_0)
	{
		this.m_b?.Invoke(ref A_0);
	}

	public void e(r.d.a.b A_0)
	{
		this.m_c?.Invoke(A_0);
	}

	public void e(object A_0)
	{
		this.m_d?.Invoke(RuntimeHelpers.GetObjectValue(A_0));
	}
}
