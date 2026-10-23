using System;
using System.Runtime.CompilerServices;
using System.Threading;

internal class bw
{
	private h5 a;

	private bool b;

	private short c;

	private short m_d;

	private DateTime m_e;

	private bool m_f;

	private bool g;

	private const int h = 600;

	public bw(h5 A_0)
	{
		a = A_0;
	}

	[SpecialName]
	public h5 d()
	{
		return a;
	}

	public void d(bool A_0, bool A_1)
	{
		e(A_0, A_1, A_2: false);
	}

	public void e(bool A_0, bool A_1)
	{
		e(A_0, A_1, A_2: true);
	}

	private void e(bool A_0, bool A_1, bool A_2)
	{
		d(A_0, A_1, A_2);
		d(600);
	}

	public void f(bool A_0, bool A_1)
	{
		d(A_0, A_1, A_2: true);
	}

	private void d(bool A_0, bool A_1, bool A_2)
	{
		byte b10 = 0;
		checked
		{
			if (A_2)
			{
				if (A_0)
				{
					ref short reference = ref c;
					reference = (short)unchecked(reference - 1);
					if (c < 0)
					{
						c = 0;
					}
				}
				else
				{
					ref short reference2 = ref c;
					reference2 = (short)unchecked(reference2 + 1);
				}
				if (A_1)
				{
					ref short reference3 = ref this.m_d;
					reference3 = (short)unchecked(reference3 - 1);
					if (this.m_d < 0)
					{
						this.m_d = 0;
					}
				}
				else
				{
					ref short reference4 = ref this.m_d;
					reference4 = (short)unchecked(reference4 + 1);
				}
			}
			if (!b || (A_0 != this.m_f && (!A_2 || (A_0 ? (c == 0) : (c == 1)))) || (A_1 != g && (!A_2 || (A_1 ? (this.m_d == 0) : (this.m_d == 1)))))
			{
				if (!A_0)
				{
					b10 = (byte)unchecked((uint)(b10 + 1));
				}
				if (!A_1)
				{
					b10 = (byte)unchecked((uint)(b10 + 2));
				}
				int num = a.abk().WriteGenIO(b10);
				this.m_f = A_0;
				g = A_1;
				this.m_e = DateTime.UtcNow;
				if (num != 0)
				{
					throw new ai("Failure attempting SetShutterState. ErrCode=" + num);
				}
				b = false;
			}
		}
	}

	public void d(int A_0)
	{
		if (!b)
		{
			int num = checked((int)Math.Round(this.m_e.AddMilliseconds(A_0).Subtract(DateTime.UtcNow).TotalMilliseconds));
			if (num > 0)
			{
				Thread.Sleep(num);
			}
			b = true;
		}
	}

	[SpecialName]
	public bool e()
	{
		return this.m_f;
	}

	[SpecialName]
	public bool f()
	{
		return g;
	}
}
