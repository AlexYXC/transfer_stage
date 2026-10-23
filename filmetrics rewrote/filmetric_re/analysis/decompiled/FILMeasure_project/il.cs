using System;
using System.IO;

internal class il : @if
{
	private new ie m_e;

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

	public h7 e(byte[] A_0, short A_1, bool A_2, ref string A_3)
	{
		MemoryStream input = new MemoryStream(A_0);
		BinaryReader binaryReader = new BinaryReader(input);
		if (A_2)
		{
			e(binaryReader);
		}
		binaryReader.ReadBytes(A_1);
		return this.m_e.d(binaryReader, ref A_3);
	}

	public il(ushort A_0, ie A_1, h8 A_2, DateTime A_3)
		: base(A_0, A_2, A_1.e(), A_3)
	{
		this.m_e = A_1;
	}
}
