using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class hq
{
	public const int a = 20;

	private short[] b;

	private short[] c;

	private short[] d;

	private string e;

	private float[] m_f;

	private const short m_g = 2;

	private const short m_h = 1;

	[SpecialName]
	public short[] f()
	{
		return b;
	}

	[SpecialName]
	public void f(short[] A_0)
	{
		b = A_0;
	}

	[SpecialName]
	public short[] g()
	{
		return c;
	}

	[SpecialName]
	public void g(short[] A_0)
	{
		c = A_0;
	}

	[SpecialName]
	public short[] h()
	{
		return d;
	}

	[SpecialName]
	public void h(short[] A_0)
	{
		d = A_0;
	}

	[SpecialName]
	public string i()
	{
		return e;
	}

	[SpecialName]
	public void f(string A_0)
	{
		e = A_0;
	}

	[SpecialName]
	public float[] j()
	{
		return this.m_f;
	}

	[SpecialName]
	public void f(float[] A_0)
	{
		this.m_f = A_0;
	}

	public void f(BinaryWriter A_0)
	{
		long position = A_0.BaseStream.Position;
		A_0.Write(position);
		A_0.Write((short)2);
		A_0.Write((short)1);
		f(b, A_0);
		f(d, A_0);
		if (e == null)
		{
			e = string.Empty;
		}
		A_0.Write(e);
		f(this.m_f, A_0);
		f(c, A_0);
		long position2 = A_0.BaseStream.Position;
		A_0.BaseStream.Seek(position, SeekOrigin.Begin);
		A_0.Write(position2);
		A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
	}

	public void f(BinaryReader A_0)
	{
		long offset = A_0.ReadInt64();
		short num = A_0.ReadInt16();
		if (A_0.ReadInt16() > 2)
		{
			throw new ApplicationException("Incompatible File Format. Newer software version is required to read this file");
		}
		f(ref b, A_0);
		f(ref d, A_0);
		e = A_0.ReadString();
		f(ref this.m_f, A_0);
		if (num >= 2)
		{
			f(ref c, A_0);
		}
		else
		{
			c = null;
		}
		A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
	}

	private void f(short[] A_0, BinaryWriter A_1)
	{
		if (A_0 != null)
		{
			A_1.Write(A_0.Length);
			foreach (short value in A_0)
			{
				A_1.Write(value);
			}
		}
		else
		{
			A_1.Write(0);
		}
	}

	private void f(float[] A_0, BinaryWriter A_1)
	{
		if (A_0 != null)
		{
			A_1.Write(A_0.Length);
			foreach (float value in A_0)
			{
				A_1.Write(value);
			}
		}
		else
		{
			A_1.Write(0);
		}
	}

	private void f(ref short[] A_0, BinaryReader A_1)
	{
		int num = A_1.ReadInt32();
		checked
		{
			if (num > 0)
			{
				if (A_0 == null || A_0.GetUpperBound(0) != num - 1)
				{
					A_0 = new short[num - 1 + 1];
				}
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					A_0[num3] = A_1.ReadInt16();
				}
			}
			else
			{
				A_0 = null;
			}
		}
	}

	private void f(ref float[] A_0, BinaryReader A_1)
	{
		int num = A_1.ReadInt32();
		checked
		{
			if (num > 0)
			{
				if (A_0 == null || A_0.GetUpperBound(0) != num - 1)
				{
					A_0 = new float[num - 1 + 1];
				}
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					A_0[num3] = A_1.ReadSingle();
				}
			}
			else
			{
				A_0 = null;
			}
		}
	}
}
