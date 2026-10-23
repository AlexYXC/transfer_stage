using System;
using System.IO;
using System.Text;

internal class ig : @if
{
	private new string m_e;

	public byte[] e()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		try
		{
			e(binaryWriter);
			binaryWriter.Write(Encoding.Unicode.GetBytes(this.m_e));
			f(binaryWriter);
			return memoryStream.GetBuffer();
		}
		finally
		{
			memoryStream.Close();
		}
	}

	public void e(byte[] A_0, short A_1, bool A_2)
	{
		MemoryStream input = new MemoryStream(A_0);
		BinaryReader binaryReader = new BinaryReader(input);
		if (A_2)
		{
			e(binaryReader);
		}
		byte[] bytes = binaryReader.ReadBytes(A_1);
		this.m_e = new string(Encoding.Unicode.GetChars(bytes));
	}

	public ig(ushort A_0, DateTime A_1, string A_2)
		: base(A_0, h8.a, ia.h(h8.a), A_1)
	{
		this.m_e = A_2;
	}

	public ig(ushort A_0, DateTime A_1, string A_2, string A_3)
		: base(A_0, h8.a, A_2, A_1)
	{
		this.m_e = A_3;
	}
}
