using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

internal class gf
{
	private const string m_a = ".fienk";

	private const string m_b = "~1~2~3xyz";

	private const string m_c = "~1~2~3~4x";

	private const long m_d = 102399L;

	[DateTimeConstant(633881273490000000L)]
	private static readonly DateTime m_e;

	private const int f = 1;

	public const string g = "\\En\\";

	private static void a(BinaryWriter A_0, ICryptoTransform A_1, string A_2, DateTime A_3, long A_4)
	{
		A_0.Write(1);
		A_0.Write(1);
		dz.a(A_0, A_1, A_2);
		A_0.Write(A_3.ToBinary());
		A_0.Write(A_4);
	}

	public static void e(string A_0)
	{
		FileInfo fileInfo = new FileInfo(A_0);
		long length = fileInfo.Length;
		DateTime lastWriteTimeUtc = fileInfo.LastWriteTimeUtc;
		byte[] a_;
		using (FileStream input = new FileStream(A_0, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			using BinaryReader binaryReader = new BinaryReader(input);
			a_ = binaryReader.ReadBytes(checked((int)binaryReader.BaseStream.Length));
		}
		a(Path.GetFileName(A_0), length, lastWriteTimeUtc, a_);
	}

	private static void a(string A_0, long A_1, DateTime A_2, byte[] A_3)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor(Encoding.ASCII.GetBytes("T7XxeC6nlV0QUvBflF73Sh6m5KTapH8j"), Encoding.ASCII.GetBytes("EbV8n5b16PE4c04b"));
		ICryptoTransform a_ = rijndaelManaged.CreateDecryptor(Encoding.ASCII.GetBytes("T7XxeC6nlV0QUvBflF73Sh6m5KTapH8j"), Encoding.ASCII.GetBytes("EbV8n5b16PE4c04b"));
		string text = b() + a(A_0, rijndaelManaged, cryptoTransform) + ".fienk";
		bool flag;
		if (File.Exists(text))
		{
			string A_4 = null;
			DateTime A_5 = default(DateTime);
			a(text, a_, ref A_4, ref A_5);
			flag = i3.a(A_2, A_5);
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			byte[] array = new byte[102400];
			a(A_3, array);
			BinaryWriter binaryWriter = null;
			try
			{
				binaryWriter = new BinaryWriter(File.Open(text, FileMode.OpenOrCreate));
				a(binaryWriter, cryptoTransform, A_0, A_2, A_1);
				dz.a(binaryWriter, cryptoTransform, array);
			}
			finally
			{
				binaryWriter.Close();
			}
			File.SetLastWriteTime(text, new DateTime(633881273490000000L));
		}
	}

	public static string d(string A_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		ICryptoTransform a_ = rijndaelManaged.CreateEncryptor(Encoding.ASCII.GetBytes("T7XxeC6nlV0QUvBflF73Sh6m5KTapH8j"), Encoding.ASCII.GetBytes("EbV8n5b16PE4c04b"));
		string text = b() + a(Path.GetFileName(A_0), rijndaelManaged, a_) + ".fienk";
		if (File.Exists(text))
		{
			return text;
		}
		return null;
	}

	private static string a(string A_0, RijndaelManaged A_1, ICryptoTransform A_2)
	{
		int num = A_1.BlockSize / 8;
		if (A_0.Length < num)
		{
			A_0 += "~1~2~3~4x";
		}
		return a(dz.a(A_0, A_2));
	}

	private static void a(BinaryReader A_0, ICryptoTransform A_1, ref int A_2, ref string A_3, ref DateTime A_4)
	{
		A_2 = A_0.ReadInt32();
		if (A_0.ReadInt32() > 1)
		{
			throw new au("En MatFile format is too new - newer software version required.");
		}
		int count = A_0.ReadInt32();
		A_3 = dz.c(A_0.ReadBytes(count), A_1);
		A_4 = DateTime.FromBinary(A_0.ReadInt64());
	}

	public static string b()
	{
		return jb.d() + "\\En\\";
	}

	public static string c(string A_0)
	{
		string A_1 = null;
		byte[] A_2 = null;
		a(A_0, ref A_1, A_2: false, ref A_2);
		return A_1;
	}

	public static void a(string A_0, ref string A_1, ref byte[] A_2)
	{
		a(A_0, ref A_1, A_2: true, ref A_2);
	}

	private static void a(string A_0, ref string A_1, bool A_2, ref byte[] A_3)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		ICryptoTransform a_ = rijndaelManaged.CreateEncryptor(Encoding.ASCII.GetBytes("T7XxeC6nlV0QUvBflF73Sh6m5KTapH8j"), Encoding.ASCII.GetBytes("EbV8n5b16PE4c04b"));
		ICryptoTransform a_2 = rijndaelManaged.CreateDecryptor(Encoding.ASCII.GetBytes("T7XxeC6nlV0QUvBflF73Sh6m5KTapH8j"), Encoding.ASCII.GetBytes("EbV8n5b16PE4c04b"));
		string path = ((!A_0.EndsWith(".fienk", StringComparison.CurrentCultureIgnoreCase)) ? (b() + a(A_0, rijndaelManaged, a_) + ".fienk") : (b() + A_0));
		long num;
		using (BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
		{
			int A_4 = default(int);
			DateTime A_5 = default(DateTime);
			a(binaryReader, a_2, ref A_4, ref A_1, ref A_5);
			if (!A_2)
			{
				return;
			}
			num = binaryReader.ReadInt64();
			int count = binaryReader.ReadInt32();
			A_3 = dz.b(binaryReader.ReadBytes(count), a_2);
		}
		A_3 = (byte[])Utils.CopyArray(A_3, new byte[checked((int)(num - 1) + 1)]);
	}

	public static void a(string A_0, string A_1)
	{
		Collection<a5> a_ = new Collection<a5>();
		a5.f(A_0, a_);
		List<string> list = b(A_0);
		bool flag = ((Operators.CompareString(Path.GetExtension(A_0), ".fibls", TextCompare: false) == 0 || Operators.CompareString(Path.GetExtension(A_0), ".fibss", TextCompare: false) == 0) ? true : false);
		checked
		{
			int num = list.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				Collection<string> collection = new Collection<string>();
				string a_2 = ((!flag) ? jb.a(new string[6]
				{
					list[num2] + ".fibnk",
					list[num2] + ".fitnk",
					list[num2] + ".fmnnn",
					list[num2] + ".nnn",
					list[num2] + ".fibnx",
					list[num2] + ".fitnx"
				}) : (b() + list[num2] + ".fienk"));
				jb.a(a_2, flag, A_2: false, collection);
				foreach (string item in collection)
				{
					a5.d(new FileInfo(item), a_);
				}
			}
			a5.d(A_1, a_);
		}
	}

	public static void a(fz A_0, string A_1, string A_2, bool A_3, ref bool A_4)
	{
		Collection<a5> collection = a5.d(A_1);
		string text = jb.h();
		checked
		{
			int num = collection.Count - 1;
			int num2 = 100 - collection.Count + 1;
			a5.d(collection, 0, 0, A_2);
			if (string.Compare(Path.GetExtension(A_1), ".fibbl", ignoreCase: true) == 0 || string.Compare(Path.GetExtension(A_1), ".fibbs") == 0)
			{
				string text2 = jb.d();
				a5.d(A_3: b(), A_0: collection, A_1: 1, A_2: collection.Count - 1);
				A_4 = true;
			}
			else
			{
				jb.a(collection, 1, collection.Count - 1);
			}
			int num3 = num;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				if (!File.Exists(text + "\\" + Path.GetFileName(collection[num4].d())) || !i3.a(collection[num4].d(), collection[num4]))
				{
					if (gd.i(Path.GetExtension(collection[num4].d())) && A_3)
					{
						a(collection[num4], "ImportLayerStackFile", A_0);
					}
					else
					{
						a5.d(collection[num4]);
					}
				}
				else if (File.Exists(text + "\\" + Path.GetFileName(collection[num4].d())))
				{
					A_0.c(fz.b.a, "File '" + Path.GetFileName(collection[num4].d()) + "' was not extracted when importing recipe '" + Path.GetFileName(collection[0].d()) + "' because a file with the same name already exists in the duplicate path.");
				}
			}
			int num5 = num2;
			for (int num6 = 0; num6 <= num5; num6++)
			{
				a(num6);
			}
		}
	}

	public static void a(a5 A_0, string A_1, fz A_2)
	{
		bool A_3 = false;
		a(A_0, A_1, A_2, ref A_3);
	}

	public static void a(a5 A_0, string A_1, fz A_2, ref bool A_3)
	{
		FileInfo fileInfo = new FileInfo(A_0.d());
		string name = fileInfo.Directory.Name;
		a5 a10 = A_0;
		string A_4 = "RecipeReplaceMsg1Fmt1";
		string text = string.Format(hu.a(ref A_4), Path.GetFileName(a10.d()), name) + "\r\n\r\n\r\n";
		string[] obj = new string[7] { text, null, null, null, null, null, null };
		A_4 = "RecipeReplaceMsg2";
		obj[1] = string.Format(hu.a(ref A_4));
		obj[2] = "\r\n        ";
		obj[3] = Conversions.ToString(fileInfo.Length);
		obj[4] = " bytes\r\n        Modified: ";
		obj[5] = fileInfo.LastWriteTime.ToString();
		obj[6] = "\r\n\r\n";
		text = string.Concat(obj);
		string[] obj2 = new string[6] { text, null, null, null, null, null };
		A_4 = "RecipeReplaceMsg3";
		obj2[1] = string.Format(hu.a(ref A_4));
		obj2[2] = "\r\n        ";
		obj2[3] = Conversions.ToString(fileInfo.Length);
		obj2[4] = " bytes\r\n        Modified: ";
		obj2[5] = TimeZone.CurrentTimeZone.ToLocalTime(a10.g()).ToString();
		text = string.Concat(obj2);
		a10 = null;
		checked
		{
			if (fe.b(ref A_2, text, A_1, "Yes", "No", new Point(global::c.b().gm().Left + unchecked(global::c.b().gm().Width / 2), global::c.b().gm().Top + unchecked(global::c.b().gm().Height / 2))))
			{
				File.Delete(A_0.d());
				a5.d(A_0);
				A_3 = false;
			}
			else
			{
				A_3 = true;
			}
		}
	}

	private static List<string> b(string A_0)
	{
		List<string> list = new List<string>();
		new RijndaelManaged().CreateEncryptor(Encoding.ASCII.GetBytes("T7XxeC6nlV0QUvBflF73Sh6m5KTapH8j"), Encoding.ASCII.GetBytes("EbV8n5b16PE4c04b"));
		gd gd2 = new gd();
		gd2.n(A_0);
		if (!gd2.k())
		{
			foreach (gc item in gd2.l())
			{
				if (jb.y(item.ag()))
				{
					list.Add(item.ag());
				}
			}
		}
		else
		{
			string text = null;
			foreach (gc item2 in gd2.l())
			{
				if (jb.y(item2.ag()))
				{
					text = d(item2.ag() + ".fibnk");
					if (string.IsNullOrEmpty(text))
					{
						text = d(item2.ag() + ".fibnx");
					}
					list.Add(Path.GetFileNameWithoutExtension(text));
				}
			}
		}
		return list;
	}

	private static string a(byte[] A_0)
	{
		string text = string.Empty;
		checked
		{
			int num = A_0.Length - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				text += A_0[num2].ToString("X2");
			}
			return text;
		}
	}

	public static void a()
	{
		string path = b();
		if (!Directory.Exists(path))
		{
			return;
		}
		jb.k();
		string empty = string.Empty;
		string A_ = string.Empty;
		ICryptoTransform a_ = new RijndaelManaged().CreateDecryptor(Encoding.ASCII.GetBytes("T7XxeC6nlV0QUvBflF73Sh6m5KTapH8j"), Encoding.ASCII.GetBytes("EbV8n5b16PE4c04b"));
		FileInfo[] files = new DirectoryInfo(path).GetFiles();
		checked
		{
			int num = files.Length - 1;
			DateTime A_2 = default(DateTime);
			short A_13 = default(short);
			short A_14 = default(short);
			int A_15 = default(int);
			short A_16 = default(short);
			short A_17 = default(short);
			int A_18 = default(int);
			int A_19 = default(int);
			short A_21 = default(short);
			for (int num2 = 0; num2 <= num; num2++)
			{
				a(files[num2].FullName, a_, ref A_, ref A_2);
				if (A_.StartsWith("~1~2~3xyz"))
				{
					continue;
				}
				empty = jb.a(new string[1] { A_ });
				if (empty != null)
				{
					FileInfo fileInfo = new FileInfo(empty);
					if (i3.a(fileInfo.LastWriteTimeUtc, A_2))
					{
						e(fileInfo.FullName);
					}
					continue;
				}
				string A_3 = null;
				string A_4 = null;
				string A_5 = null;
				jb.d[] A_6 = null;
				string[] A_7 = null;
				string text = jb.d() + "\\" + A_;
				if (jb.p(A_))
				{
					double[] A_8 = null;
					short[] A_9 = null;
					double[] A_10 = null;
					double[] A_11 = null;
					double[] A_12 = null;
					jb.a(A_, A_1: true, ref A_13, ref A_14, ref A_15, ref A_8, ref A_9, ref A_16, ref A_17, ref A_10, ref A_11, ref A_12, ref A_3, ref A_4, ref A_18, ref A_5, ref A_19, ref A_6, ref A_7);
					jb.a(text, A_10, A_11, A_12, (short)A_15, A_13, A_14, A_16, A_8, A_9, A_3, A_4, A_19, A_6, A_7, A_16 > 0);
				}
				else
				{
					jc A_20 = null;
					jb.b(A_, A_1: true, ref A_20, ref A_21, ref A_3, ref A_5, ref A_18, ref A_4, ref A_19, ref A_6, ref A_7);
					jc jc2 = A_20;
					jb.a(text, A_21, jc2.b, jc2.h, jc2.i, jc2.j, A_3, jc2.k, jc2.l, jc2.m, jc2.n, A_4, A_19, A_6, A_7);
					jc2 = null;
				}
				File.SetLastWriteTimeUtc(text, A_2);
			}
		}
	}

	private static void a(string A_0, ICryptoTransform A_1, ref string A_2, ref DateTime A_3)
	{
		using BinaryReader a_ = new BinaryReader(File.Open(A_0, FileMode.Open));
		int A_4 = 0;
		a(a_, A_1, ref A_4, ref A_2, ref A_3);
	}

	public static bool a(string A_0)
	{
		if (Operators.CompareString(A_0.ToLower(), ".fibbl", TextCompare: false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(A_0.ToLower(), ".fibtl", TextCompare: false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(A_0.ToLower(), ".fibbs", TextCompare: false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(A_0.ToLower(), ".fibts", TextCompare: false) == 0)
		{
			return true;
		}
		return false;
	}

	public static void a(int A_0)
	{
		byte[] array = new byte[101];
		byte[] array2 = new byte[102400];
		checked
		{
			byte b10 = (byte)A_0;
			int num = 0;
			do
			{
				array[num] = b10;
				b10 = (byte)unchecked((uint)(b10 + 1));
				num++;
			}
			while (num <= 100);
			a("~1~2~3xyz" + A_0 + ".fibnk", array2.Length, new DateTime(633881273490000000L), array2);
		}
	}

	private static void a(byte[] A_0, byte[] A_1)
	{
		int num = A_1.Length;
		int num2 = A_0.Length;
		int num3 = num / num2;
		int num4 = num % num2;
		checked
		{
			int num5 = num3 - 1;
			for (int num6 = 0; num6 <= num5; num6++)
			{
				int num7 = num2 - 1;
				for (int num8 = 0; num8 <= num7; num8++)
				{
					A_1[num6 * num2 + num8] = A_0[num8];
				}
			}
			int num9 = num4 - 1;
			for (int num10 = 0; num10 <= num9; num10++)
			{
				A_1[102399 - num4 + num10] = A_0[num10];
			}
		}
	}

	static gf()
	{
		gf.m_e = new DateTime(633881273490000000L);
	}
}
