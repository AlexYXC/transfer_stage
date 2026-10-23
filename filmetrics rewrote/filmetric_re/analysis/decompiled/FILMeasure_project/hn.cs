using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class hn
{
	private short a;

	private float b;

	private double[] c;

	private double[] d;

	private double[] e;

	private const short m_f = 1;

	private const short m_g = 1;

	public hn f()
	{
		return (hn)MemberwiseClone();
	}

	[SpecialName]
	public static bool g(hn A_0, hn A_1)
	{
		checked
		{
			switch (ix.a(A_0, A_1))
			{
			case ix.a.a:
				return false;
			case ix.a.b:
				return true;
			default:
			{
				hn hn2 = A_0;
				if (hn2.h() != A_1.h())
				{
					return true;
				}
				if (hn2.g() != A_1.g())
				{
					return true;
				}
				int num = hn2.g() - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (hn2.i()[num2] != A_1.i()[num2])
					{
						return true;
					}
					if (hn2.j()[num2] != A_1.j()[num2])
					{
						return true;
					}
					if (hn2.k()[num2] != A_1.k()[num2])
					{
						return true;
					}
				}
				hn2 = null;
				return false;
			}
			}
		}
	}

	[SpecialName]
	public static bool f(hn A_0, hn A_1)
	{
		return !g(A_0, A_1);
	}

	[SpecialName]
	public short g()
	{
		return Convert.ToInt16(c.Length);
	}

	[SpecialName]
	public float h()
	{
		return b;
	}

	[SpecialName]
	public double[] i()
	{
		return c;
	}

	[SpecialName]
	public double[] j()
	{
		return d;
	}

	[SpecialName]
	public double[] k()
	{
		return e;
	}

	internal hn(short A_0, float A_1, double[] A_2, double[] A_3, double[] A_4)
	{
		a = A_0;
		b = A_1;
		c = A_2;
		d = A_3;
		e = A_4;
	}

	public void f(BinaryReader A_0)
	{
		long offset = A_0.ReadInt64();
		A_0.ReadInt16();
		if (A_0.ReadInt16() > 1)
		{
			throw new ApplicationException("Incompatible File Format. Newer software version is required to read this file");
		}
		a = A_0.ReadInt16();
		b = A_0.ReadSingle();
		checked
		{
			int num = a - 1;
			c = new double[num + 1];
			d = new double[num + 1];
			e = new double[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				c[num3] = A_0.ReadDouble();
				d[num3] = A_0.ReadDouble();
				e[num3] = A_0.ReadDouble();
			}
			A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
		}
	}

	public void f(BinaryWriter A_0)
	{
		long position = A_0.BaseStream.Position;
		A_0.Write(position);
		A_0.Write((short)1);
		A_0.Write((short)1);
		A_0.Write(a);
		A_0.Write(b);
		checked
		{
			int num = a - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				A_0.Write(c[num2]);
				A_0.Write(d[num2]);
				A_0.Write(e[num2]);
			}
			long position2 = A_0.BaseStream.Position;
			A_0.BaseStream.Seek(position, SeekOrigin.Begin);
			A_0.Write(position2);
			A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
		}
	}
}
