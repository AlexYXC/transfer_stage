using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

internal abstract class d0
{
	private const int m_a = 2;

	private const int m_b = 2;

	private int c;

	private int d;

	private string e;

	private string f;

	private string g;

	private string h;

	private bool i;

	public d0(int A_0, int A_1, string A_2, string A_3, string A_4, string A_5, bool A_6)
	{
		c = A_0;
		d = A_1;
		e = A_2;
		f = A_3;
		g = A_4;
		h = A_5;
		i = A_6;
	}

	[SpecialName]
	private byte[] b(bool A_0)
	{
		if (A_0)
		{
			return Encoding.ASCII.GetBytes(g);
		}
		return Convert.FromBase64String(e);
	}

	[SpecialName]
	private byte[] a(bool A_0)
	{
		if (A_0)
		{
			return Encoding.ASCII.GetBytes(h);
		}
		return Convert.FromBase64String(f);
	}

	public abstract void ae(object A_0, ICryptoTransform A_1, int A_2);

	private void a(Stream A_0)
	{
		BinaryReader binaryReader = null;
		ICryptoTransform cryptoTransform = null;
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = null;
		RijndaelManaged rijndaelManaged = null;
		try
		{
			binaryReader = new BinaryReader(A_0);
			int num = binaryReader.ReadInt32();
			int num2 = binaryReader.ReadInt32();
			bool flag = i;
			if (1 == num && 1 == num2)
			{
				c = num;
				d = num2;
				num = 0;
				num2 = 0;
				flag = false;
			}
			else
			{
				if (num > 2)
				{
					throw new ApplicationException("Incompatible Encrypt File Format. Newer software version is required to read this file. FileVer=" + num + ", CompatVer=" + 2);
				}
				c = binaryReader.ReadInt32();
				d = binaryReader.ReadInt32();
			}
			if (d > c)
			{
				throw new ApplicationException("Incompatible Objective File Format. Newer software version is required to read this file. FileVer=" + c + ", CompatVer=" + d);
			}
			if (flag)
			{
				tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
				cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor(b(A_0: true), a(A_0: true));
			}
			else
			{
				rijndaelManaged = new RijndaelManaged();
				cryptoTransform = rijndaelManaged.CreateDecryptor(b(A_0: false), a(A_0: false));
			}
			ae(binaryReader, cryptoTransform, c);
		}
		finally
		{
			tripleDESCryptoServiceProvider?.Dispose();
			rijndaelManaged?.Dispose();
			cryptoTransform?.Dispose();
			binaryReader?.Close();
		}
	}

	public void a(string A_0)
	{
		Stream stream = null;
		try
		{
			stream = File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read);
			a(stream);
		}
		finally
		{
			stream?.Close();
		}
	}

	public void a(byte[] A_0)
	{
		Stream stream = null;
		try
		{
			stream = new MemoryStream(A_0);
			a(stream);
		}
		finally
		{
			stream?.Close();
		}
	}

	public void b(string A_0)
	{
		ICryptoTransform cryptoTransform = null;
		BinaryWriter binaryWriter = null;
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = null;
		RijndaelManaged rijndaelManaged = null;
		FileStream fileStream = null;
		try
		{
			if (i)
			{
				tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
				cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor(b(A_0: true), a(A_0: true));
			}
			else
			{
				rijndaelManaged = new RijndaelManaged();
				cryptoTransform = rijndaelManaged.CreateEncryptor(b(A_0: false), a(A_0: false));
			}
			fileStream = File.Open(A_0, FileMode.Create);
			binaryWriter = new BinaryWriter(fileStream);
			if (i)
			{
				binaryWriter.Write(2);
				binaryWriter.Write(2);
			}
			binaryWriter.Write(c);
			binaryWriter.Write(d);
			ae(binaryWriter, cryptoTransform, c);
		}
		finally
		{
			tripleDESCryptoServiceProvider?.Dispose();
			rijndaelManaged?.Dispose();
			cryptoTransform?.Dispose();
			if (binaryWriter != null)
			{
				binaryWriter.Close();
			}
			else
			{
				fileStream?.Close();
			}
		}
	}
}
