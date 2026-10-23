using System;
using System.Runtime.CompilerServices;
using System.Threading;

internal class gm
{
	public delegate void a(Guid A_0, int A_1, int A_2);

	[CompilerGenerated]
	private a m_a;

	[SpecialName]
	[CompilerGenerated]
	public void b(a A_0)
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
	public void c(a A_0)
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

	public void b(Guid A_0, int A_1, int A_2)
	{
		this.m_a?.Invoke(A_0, A_1, A_2);
	}
}
