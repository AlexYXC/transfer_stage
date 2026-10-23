using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

internal abstract class p : q
{
	public enum a
	{
		a,
		b
	}

	public enum b
	{
		a,
		b
	}

	private object m_a;

	private string m_b;

	public p(fz A_0)
		: base(ref A_0)
	{
	}

	public a m2(object A_0, ref string A_1, [Optional][DefaultParameterValue("")] ref string A_2)
	{
		if (Monitor.TryEnter(this, 300))
		{
			this.m_a = RuntimeHelpers.GetObjectValue(A_0);
			this.m_b = A_1;
			return p.a.a;
		}
		A_2 = this.m_b;
		return p.a.b;
	}

	public b m2(object A_0, ref string A_1)
	{
		if (A_0.Equals(RuntimeHelpers.GetObjectValue(this.m_a)))
		{
			this.m_a = null;
			this.m_b = "";
			Monitor.Exit(this);
			return p.b.a;
		}
		A_1 = this.m_b;
		return p.b.b;
	}
}
