using System;
using System.IO;

internal class ii : @if
{
	private new ib m_e;

	private new const int f = 2;

	public byte[] e()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter a_ = new BinaryWriter(memoryStream);
		try
		{
			e(a_);
			this.m_e.d(a_);
			f(a_);
			return memoryStream.GetBuffer();
		}
		finally
		{
			memoryStream.Close();
		}
	}

	public void e(byte[] A_0, bool A_1)
	{
		MemoryStream input = new MemoryStream(A_0);
		BinaryReader a_ = new BinaryReader(input);
		if (A_1)
		{
			e(a_);
		}
		this.m_e.d(a_);
	}

	public ii(ushort A_0, DateTime A_1, double A_2, string A_3, bool A_4, float[] A_5)
		: base(A_0, h8.b, A_3, A_1)
	{
		this.m_e = new ib(A_2, 2, A_4, A_5);
	}

	public ii(ushort A_0, DateTime A_1, double A_2, string A_3, int A_4, bool A_5, float[] A_6)
		: base(A_0, h8.b, A_3, A_1)
	{
		this.m_e = new ib(A_2, A_4, A_5, A_6);
	}

	public ii(ushort A_0, DateTime A_1, string A_2, byte[] A_3)
		: base(A_0, h8.b, A_2, A_1)
	{
		this.m_e = new ib(A_3);
	}
}
