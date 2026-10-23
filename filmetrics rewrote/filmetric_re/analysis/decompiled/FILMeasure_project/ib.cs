using System.IO;
using System.Runtime.CompilerServices;

internal class ib
{
	private const byte a = 2;

	private const byte b = 1;

	private float c;

	private byte m_d;

	private ushort m_e;

	private ushort[] f;

	private byte g;

	private const short h = 14;

	[SpecialName]
	public double d()
	{
		return c;
	}

	[SpecialName]
	public float[] d(int A_0)
	{
		return iy.b(A_0, 14.0, this.m_e, this.m_d, f);
	}

	[SpecialName]
	public bool e()
	{
		return g != 0;
	}

	public void d(BinaryWriter A_0)
	{
		A_0.Write((byte)2);
		A_0.Write((byte)1);
		A_0.Write(c);
		A_0.Write(this.m_d);
		A_0.Write(this.m_e);
		checked
		{
			int num = f.Length - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				A_0.Write(f[num2]);
			}
			A_0.Write(g);
		}
	}

	public void d(byte[] A_0)
	{
		MemoryStream input = new MemoryStream(A_0);
		BinaryReader a_ = new BinaryReader(input);
		d(a_);
	}

	public void d(BinaryReader A_0)
	{
		byte b10 = A_0.ReadByte();
		A_0.ReadByte();
		c = A_0.ReadSingle();
		this.m_d = A_0.ReadByte();
		this.m_e = A_0.ReadUInt16();
		checked
		{
			f = new ushort[this.m_e - 1 + 1];
			int num = this.m_e - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				f[num2] = A_0.ReadUInt16();
			}
			if (b10 > 1)
			{
				g = A_0.ReadByte();
			}
			else
			{
				g = 0;
			}
		}
	}

	public ib()
	{
		f = null;
	}

	public ib(byte[] A_0)
	{
		f = null;
		d(A_0);
	}

	public ib(double A_0, int A_1, bool A_2, float[] A_3)
	{
		f = null;
		c = (float)A_0;
		this.m_d = checked((byte)A_1);
		iy.a(A_3.Length, A_3, A_1, 14.0, ref this.m_e, ref f);
		g = (byte)(0u - (A_2 ? 1u : 0u));
	}
}
