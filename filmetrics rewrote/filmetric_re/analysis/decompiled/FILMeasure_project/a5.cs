using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

internal class a5
{
	public enum a
	{
		a,
		b
	}

	private string m_a;

	private long b;

	private DateTime c;

	private const int m_d = 2;

	public byte[] e;

	public const string f = "FI Packed Folder (*.fibpf)|*.fibpf";

	public const string g = "Zip folder (*.zip)|*.zip";

	[SpecialName]
	public string d()
	{
		return this.m_a;
	}

	[SpecialName]
	public void f(string A_0)
	{
		this.m_a = A_0;
	}

	[SpecialName]
	public long f()
	{
		return b;
	}

	[SpecialName]
	public void d(long A_0)
	{
		b = A_0;
	}

	[SpecialName]
	public DateTime g()
	{
		return c;
	}

	[SpecialName]
	public void d(DateTime A_0)
	{
		c = A_0;
	}

	public void h()
	{
		FileStream fileStream = null;
		BinaryReader binaryReader = null;
		try
		{
			fileStream = new FileStream(this.m_a, FileMode.Open, FileAccess.Read);
			try
			{
				binaryReader = new BinaryReader(fileStream);
				e = binaryReader.ReadBytes(checked((int)binaryReader.BaseStream.Length));
			}
			finally
			{
				binaryReader?.Dispose();
			}
		}
		finally
		{
			fileStream?.Dispose();
		}
	}

	public static void d(string A_0, string A_1, string[] A_2, string[] A_3)
	{
		Collection<a5> a_ = new Collection<a5>();
		d(A_0, a_, A_2, A_3);
		d(A_1, a_, A_0);
	}

	public static void d(string A_0, string A_1)
	{
		string A_2 = "";
		Collection<a5> collection = d(A_0, ref A_2);
		d(collection, 0, checked(collection.Count - 1), A_2, A_1);
		foreach (a5 item in collection)
		{
			d(item);
		}
	}

	public static void d(string A_0, Collection<a5> A_1, string[] A_2, string[] A_3)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(A_0);
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		foreach (DirectoryInfo directoryInfo2 in directories)
		{
			bool flag = false;
			foreach (string strB in A_3)
			{
				if (string.Compare(directoryInfo2.FullName, strB, StringComparison.OrdinalIgnoreCase) == 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				d(directoryInfo2.FullName, A_1, A_2, A_3);
			}
		}
		FileInfo[] files = directoryInfo.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			bool flag2 = false;
			if (A_2 != null)
			{
				foreach (string value in A_2)
				{
					if (fileInfo.Name.Equals(value, StringComparison.OrdinalIgnoreCase))
					{
						flag2 = true;
						break;
					}
				}
			}
			if (!flag2)
			{
				d(fileInfo, A_1);
			}
		}
	}

	public static void d(FileInfo A_0, Collection<a5> A_1)
	{
		a5 a10 = new a5();
		FileInfo fileInfo = A_0;
		a10.f(fileInfo.FullName);
		a10.d(fileInfo.LastWriteTimeUtc);
		fileInfo = null;
		a10.h();
		a10.d(a10.e.Length);
		A_1.Add(a10);
	}

	public static void f(string A_0, Collection<a5> A_1)
	{
		d(new FileInfo(A_0), A_1);
	}

	public static Collection<a5> d(string A_0)
	{
		string A_1 = null;
		return d(A_0, ref A_1);
	}

	public static Collection<a5> d(string A_0, ref string A_1)
	{
		Collection<a5> collection = new Collection<a5>();
		FileStream fileStream = null;
		BinaryReader binaryReader = null;
		checked
		{
			try
			{
				fileStream = new FileStream(A_0, FileMode.Open, FileAccess.Read);
				try
				{
					binaryReader = new BinaryReader(fileStream);
					int num = binaryReader.ReadInt32();
					int num2 = binaryReader.ReadInt32();
					if (num2 > 2)
					{
						throw new au("Incompatible file format in ReadFromCombinedFile. Newer software version is required to read this file. FileVer=" + num.ToString(CultureInfo.InvariantCulture) + ", CompatVer=" + num2.ToString(CultureInfo.InvariantCulture));
					}
					int num3 = binaryReader.ReadInt32() - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						a5 a10 = new a5();
						a5 a11 = a10;
						a11.f(binaryReader.ReadString());
						a11.d(binaryReader.ReadInt64());
						a11.d(DateTime.FromBinary(binaryReader.ReadInt64()));
						a11.e = binaryReader.ReadBytes((int)a11.f());
						a11 = null;
						collection.Add(a10);
					}
					if (num >= 2)
					{
						A_1 = binaryReader.ReadString();
					}
					else
					{
						A_1 = "";
					}
				}
				finally
				{
					binaryReader?.Dispose();
				}
			}
			finally
			{
				fileStream?.Dispose();
			}
			return collection;
		}
	}

	public static void d(string A_0, Collection<a5> A_1)
	{
		d(A_0, A_1, string.Empty);
	}

	public static void d(string A_0, Collection<a5> A_1, string A_2)
	{
		FileStream fileStream = null;
		BinaryWriter binaryWriter = null;
		checked
		{
			try
			{
				fileStream = new FileStream(A_0, FileMode.OpenOrCreate, FileAccess.ReadWrite);
				try
				{
					binaryWriter = new BinaryWriter(fileStream);
					binaryWriter.Write(2);
					binaryWriter.Write(1);
					binaryWriter.Write(A_1.Count);
					int num = A_1.Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						a5 a10 = A_1[num2];
						binaryWriter.Write(a10.d());
						binaryWriter.Write(a10.f());
						binaryWriter.Write(a10.g().ToBinary());
						int num3 = a10.e.Length - 1;
						for (int num4 = 0; num4 <= num3; num4++)
						{
							binaryWriter.Write(a10.e[num4]);
						}
						a10 = null;
					}
					if (A_2 == null)
					{
						A_2 = string.Empty;
					}
					binaryWriter.Write(A_2);
				}
				finally
				{
					binaryWriter?.Dispose();
				}
			}
			finally
			{
				fileStream?.Dispose();
			}
		}
	}

	public static void d(Collection<a5> A_0, int A_1, int A_2, string A_3)
	{
		d(A_0, A_1, A_2, "", A_3);
	}

	public static void d(Collection<a5> A_0, int A_1, int A_2, string A_3, string A_4)
	{
		if (!string.IsNullOrEmpty(A_3) && !A_3.EndsWith("\\"))
		{
			A_3 += "\\";
		}
		for (int num = A_1; num <= A_2; num = checked(num + 1))
		{
			a5 a10 = A_0[num];
			if (string.IsNullOrEmpty(A_3))
			{
				a10.f(Path.Combine(A_4, Path.GetFileName(a10.d())));
				if (!Directory.Exists(A_4))
				{
					Directory.CreateDirectory(A_4);
				}
			}
			else
			{
				string text = a10.d().Substring(A_3.Length);
				a10.f(Path.Combine(A_4, text));
				i3.g(A_4, text);
			}
			a10 = null;
		}
	}

	public static void d(a5 A_0)
	{
		FileStream fileStream = null;
		BinaryWriter binaryWriter = null;
		checked
		{
			try
			{
				fileStream = new FileStream(A_0.d(), FileMode.OpenOrCreate);
				try
				{
					binaryWriter = new BinaryWriter(fileStream);
					int num = A_0.e.Length - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						binaryWriter.Write(A_0.e[num2]);
					}
				}
				finally
				{
					binaryWriter?.Dispose();
				}
			}
			finally
			{
				fileStream?.Dispose();
			}
			if (File.Exists(A_0.d()))
			{
				File.SetLastWriteTime(A_0.d(), A_0.g().ToLocalTime());
			}
		}
	}
}
