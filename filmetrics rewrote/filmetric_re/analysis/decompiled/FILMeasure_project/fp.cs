using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;

internal class fp
{
	public delegate void a();

	public bool a;

	[CompilerGenerated]
	private a b;

	[CompilerGenerated]
	private System.Timers.Timer c;

	[SpecialName]
	[CompilerGenerated]
	public void am(a A_0)
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
	public void an(a A_0)
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

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer a6()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void am(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = am;
		System.Timers.Timer timer = c;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		c = A_0;
		timer = c;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	public fp()
	{
		am(new System.Timers.Timer());
		System.Timers.Timer timer = a6();
		timer.Interval = 1.0;
		timer.AutoReset = false;
		_ = null;
		this.a = true;
	}

	protected void a7()
	{
		if (this.a)
		{
			a6().Start();
		}
	}

	private void am(object A_0, ElapsedEventArgs A_1)
	{
		b?.Invoke();
	}
}
