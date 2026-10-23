using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class dz
{
	public enum a
	{
		a,
		b
	}

	public static byte[] a(string A_0, ICryptoTransform A_1)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(A_0);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, A_1, CryptoStreamMode.Write);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.FlushFinalBlock();
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	public static string c(byte[] A_0, ICryptoTransform A_1)
	{
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, A_1, CryptoStreamMode.Write);
		cryptoStream.Write(A_0, 0, A_0.Length);
		cryptoStream.FlushFinalBlock();
		cryptoStream.Close();
		return Encoding.UTF8.GetString(memoryStream.ToArray());
	}

	public static byte[] b(byte[] A_0, ICryptoTransform A_1)
	{
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, A_1, CryptoStreamMode.Write);
		cryptoStream.Write(A_0, 0, A_0.Length);
		cryptoStream.FlushFinalBlock();
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	public static byte[] a(byte[] A_0, ICryptoTransform A_1)
	{
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, A_1, CryptoStreamMode.Write);
		cryptoStream.Write(A_0, 0, A_0.Length);
		cryptoStream.FlushFinalBlock();
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	public static void a(object A_0, ICryptoTransform A_1, ref string A_2)
	{
		if (A_0 is BinaryReader)
		{
			A_2 = e((BinaryReader)A_0, A_1);
		}
		else
		{
			a((BinaryWriter)A_0, A_1, A_2);
		}
	}

	public static string e(BinaryReader A_0, ICryptoTransform A_1)
	{
		int count = A_0.ReadInt32();
		return c(A_0.ReadBytes(count), A_1);
	}

	public static double d(BinaryReader A_0, ICryptoTransform A_1)
	{
		int count = A_0.ReadInt32();
		return double.Parse(c(A_0.ReadBytes(count), A_1), CultureInfo.InvariantCulture);
	}

	public static float c(BinaryReader A_0, ICryptoTransform A_1)
	{
		return (float)d(A_0, A_1);
	}

	public static int b(BinaryReader A_0, ICryptoTransform A_1)
	{
		return checked((int)Math.Round(d(A_0, A_1)));
	}

	public static bool a(BinaryReader A_0, ICryptoTransform A_1)
	{
		int count = A_0.ReadInt32();
		return bool.Parse(c(A_0.ReadBytes(count), A_1));
	}

	public static byte[] a(BinaryWriter A_0, ICryptoTransform A_1, string A_2)
	{
		byte[] array = a(A_2, A_1);
		A_0.Write(array.Length);
		A_0.Write(array);
		return array;
	}

	public static void a(BinaryWriter A_0, ICryptoTransform A_1, byte[] A_2)
	{
		byte[] array = a(A_2, A_1);
		A_0.Write(array.Length);
		A_0.Write(array);
	}

	public static byte[] a(BinaryWriter A_0, ICryptoTransform A_1, double A_2)
	{
		byte[] array = a(A_2.ToString(CultureInfo.InvariantCulture), A_1);
		A_0.Write(array.Length);
		A_0.Write(array);
		return array;
	}

	public static byte[] a(BinaryWriter A_0, ICryptoTransform A_1, bool A_2)
	{
		byte[] array = a(A_2.ToString(CultureInfo.InvariantCulture), A_1);
		A_0.Write(array.Length);
		A_0.Write(array);
		return array;
	}
}
