using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class ch : ga
{
	private new int a;

	private double[] b;

	private short[] c;

	private hd.a d;

	private bool e;

	private string f;

	private string g;

	protected byte[] h;

	protected int i;

	protected new byte[] j;

	private new const int m_k = 16;

	private new const int m_l = 1836;

	private new int m_m;

	public ch(double[] A_0, double[] A_1, int A_2, double[] A_3, short[] A_4, hd.a A_5, gr.d A_6, bool A_7, string A_8, string A_9, string A_10, int A_11, string A_12, bool A_13)
		: base(A_0, A_1, A_6, A_7)
	{
		b = new double[1837];
		c = new short[1837];
		this.m_m = 3;
		a = A_2;
		b = A_3;
		c = A_4;
		d = A_5;
		base.j = A_6;
		f = A_8;
		g = A_8;
		h = i3.c(A_10);
		i = A_11;
		this.j = i3.c(A_12);
		e = A_13;
	}

	public ch()
	{
		b = new double[1837];
		c = new short[1837];
		this.m_m = 3;
	}

	[SpecialName]
	public double[] r()
	{
		return b;
	}

	[SpecialName]
	public new short[] t()
	{
		return c;
	}

	[SpecialName]
	public new hd.a af()
	{
		return d;
	}

	[SpecialName]
	public new string ag()
	{
		return f;
	}

	[SpecialName]
	public void r(string A_0)
	{
		f = A_0;
	}

	[SpecialName]
	public new string ah()
	{
		return g;
	}

	[SpecialName]
	public new void t(string A_0)
	{
		g = A_0;
	}

	[SpecialName]
	public new string am()
	{
		return i3.a(h);
	}

	[SpecialName]
	public new int ao()
	{
		return i;
	}

	[SpecialName]
	public new string ap()
	{
		return i3.a(this.j);
	}

	[SpecialName]
	public new int aq()
	{
		return a;
	}

	public override void j(string A_0)
	{
		k(ref A_0, "", "");
	}

	public override void k(ref string A_0, string A_1, string A_2)
	{
		jb.a a10 = checked(jb.a(A_0, ((fy)this).j, c0(), null, (short)((fy)this).j.Length, (short)base.j, (short)d, (short)a, b, c, f, g, 0, null, null, e));
		if (a10 != jb.a.a)
		{
			int num = (int)a10;
			throw new ApplicationException("Error in DataXYCoeff.Write(String, String, String). Error code =" + num);
		}
	}

	public void r(ref string A_0, string A_1, string A_2, double[] A_3)
	{
		jb.a a10 = checked(jb.a(A_0, ((fy)this).j, c0(), A_3, (short)((fy)this).j.Length, (short)base.j, (short)d, (short)a, b, c, f, g, 0, null, null, e));
		if (a10 != jb.a.a)
		{
			int num = (int)a10;
			throw new ApplicationException("Error in DataXYCoeff.Write(String, String, String, Double). Error code =" + num);
		}
	}

	public override void l(ref BinaryReader A_0)
	{
		long offset = A_0.ReadInt64();
		int num = A_0.ReadInt32();
		int num2 = A_0.ReadInt32();
		if (num2 <= this.m_m)
		{
			a = A_0.ReadInt32();
			checked
			{
				int num3 = a - 1;
				b = new double[a + 1];
				c = new short[a + 1];
				int num4 = num3;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					b[num5] = A_0.ReadDouble();
				}
				int num6 = num3;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					c[num7] = A_0.ReadInt16();
				}
			}
			d = (hd.a)A_0.ReadInt32();
			if (num >= 2)
			{
				int num8 = A_0.ReadInt32();
				if (num8 > 0)
				{
					h = A_0.ReadBytes(num8);
				}
				else
				{
					h = null;
				}
				i = A_0.ReadInt32();
				num8 = A_0.ReadInt32();
				if (num8 > 0)
				{
					this.j = A_0.ReadBytes(num8);
				}
				else
				{
					this.j = null;
				}
			}
			if (num >= 3)
			{
				e = A_0.ReadBoolean();
			}
			A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
			base.l(ref A_0);
			return;
		}
		throw new au("DataXYCoeff maximum compatible block file version is " + this.m_m + " compatible version in file we are attempting to read is " + num2);
	}

	public override void m(ref BinaryWriter A_0)
	{
		long position = A_0.BaseStream.Position;
		A_0.Write(position);
		A_0.Write(this.m_m);
		A_0.Write(1);
		A_0.Write(a);
		checked
		{
			int num = a - 1;
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				A_0.Write(b[num3]);
			}
			int num4 = num;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				A_0.Write(c[num5]);
			}
		}
		A_0.Write((int)d);
		if (h == null || h.GetUpperBound(0) < 0)
		{
			A_0.Write(0);
		}
		else
		{
			A_0.Write(h.Length);
			A_0.Write(h);
		}
		A_0.Write(i);
		if (this.j == null || this.j.GetUpperBound(0) < 0)
		{
			A_0.Write(0);
		}
		else
		{
			A_0.Write(this.j.Length);
			A_0.Write(this.j);
		}
		A_0.Write(e);
		long position2 = A_0.BaseStream.Position;
		A_0.BaseStream.Seek(position, SeekOrigin.Begin);
		A_0.Write(position2);
		A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
		base.m(ref A_0);
	}
}
