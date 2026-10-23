using System.IO;
using System.Runtime.CompilerServices;

internal class id
{
	private float a;

	private const byte m_b = 1;

	[SpecialName]
	public double b()
	{
		return a;
	}

	public void b(BinaryWriter A_0)
	{
		A_0.Write((byte)1);
		A_0.Write((byte)1);
		A_0.Write(a);
	}

	public void b(byte[] A_0)
	{
		MemoryStream input = new MemoryStream(A_0);
		BinaryReader a_ = new BinaryReader(input);
		string A_1 = null;
		b(a_, ref A_1);
	}

	public h7 b(BinaryReader A_0, ref string A_1)
	{
		A_0.ReadByte();
		byte b10 = A_0.ReadByte();
		A_1 = null;
		if ((uint)b10 > 1u)
		{
			A_1 = "OrigTIntTime firmware compatible version is " + b10 + ", this software version only understands file versions <=" + (byte)1;
			return h7.b;
		}
		a = A_0.ReadSingle();
		return h7.a;
	}

	public id()
	{
	}

	public id(double A_0)
	{
		a = (float)A_0;
	}
}
