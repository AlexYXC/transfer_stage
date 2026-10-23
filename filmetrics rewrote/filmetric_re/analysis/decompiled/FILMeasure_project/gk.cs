using System;
using System.Runtime.CompilerServices;
using System.Threading;

internal class gk
{
	public delegate void a(hc A_0, cb A_1, Guid A_2, bool A_3, bool A_4, ref bool A_5);

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

	public void b(hc A_0, cb A_1, Guid A_2, bool A_3, ref bool A_4)
	{
		this.m_a?.Invoke(A_0, A_1, A_2, A_3: true, A_3, ref A_4);
	}
}
