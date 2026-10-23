using System.IO;

internal class ij : @if
{
	private new ic m_e;

	public byte[] e()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter a_ = new BinaryWriter(memoryStream);
		try
		{
			e(a_);
			this.m_e.b(a_);
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
		return this.m_e.b(binaryReader, ref A_3);
	}

	public ij(ushort A_0, cf A_1)
		: base(A_0, h8.c, A_1.n(), A_1.s())
	{
		this.m_e = new ic(A_1);
	}
}
