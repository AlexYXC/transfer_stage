using System;
using System.IO;

internal class ih : @if
{
	private new byte[] m_e;

	public byte[] e()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		try
		{
			e(binaryWriter);
			byte[] array = this.m_e;
			foreach (byte value in array)
			{
				binaryWriter.Write(value);
			}
			f(binaryWriter);
			return memoryStream.GetBuffer();
		}
		finally
		{
			memoryStream.Close();
		}
	}

	public ih(ushort A_0, h8 A_1, DateTime A_2, string A_3, byte[] A_4)
		: base(A_0, A_1, A_3, A_2)
	{
		this.m_e = A_4;
	}
}
