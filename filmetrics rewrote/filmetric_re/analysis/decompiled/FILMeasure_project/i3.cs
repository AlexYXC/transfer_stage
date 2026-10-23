using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

internal class i3
{
	public delegate void a(BinaryReader A_0, int A_1);

	public delegate void b(BinaryWriter A_0);

	public const string a = ".csv";

	public const string b = "Comma Separated Values (*.csv)";

	public const string c = "*.csv";

	public const string d = ".txt";

	public const string e = "Text Files (*.txt)";

	public const string f = "*.txt";

	private const string m_g = "Filmetrics";

	private static string m_h;

	private static string m_i;

	public const string j = "_";

	public const string k = "___";

	public const string l = ".fiaan";

	public const string m = ".fiwan";

	private const byte m_n = 150;

	private const byte m_o = 105;

	public static string o()
	{
		if (string.IsNullOrEmpty(i3.m_h))
		{
			i3.m_h = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Filmetrics\\" + Assembly.GetExecutingAssembly().GetName().Name;
		}
		return i3.m_h;
	}

	public static string n()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Filmetrics\\" + Assembly.GetExecutingAssembly().GetName().Name;
	}

	public static string m()
	{
		string text = o();
		string text2 = text.Substring(0, text.LastIndexOf("\\"));
		text = null;
		text2 = text2.Substring(0, text2.LastIndexOf("\\"));
		return text2 + "\\Filmetrics";
	}

	public static string l()
	{
		return m() + "\\CommonSettings";
	}

	public static string k()
	{
		return m() + "\\Help";
	}

	public static string j()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Filmetrics\\" + Assembly.GetExecutingAssembly().GetName().Name;
	}

	public static string i()
	{
		return m() + "\\CommonSettings";
	}

	public static string h()
	{
		return m() + "\\Help";
	}

	public static string g()
	{
		return o() + "\\Temp";
	}

	public static string i(string A_0, string A_1)
	{
		return Path.Combine(g(), A_0 + A_1);
	}

	public static string h(string A_0, string A_1)
	{
		string text = i(A_0, A_1);
		string directoryName = Path.GetDirectoryName(text);
		if (!Directory.Exists(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
		return text;
	}

	public static string f()
	{
		return o() + "\\Logs";
	}

	public static string e()
	{
		return "Machine\\";
	}

	public static string d()
	{
		return Path.Combine(o(), e());
	}

	public static string c()
	{
		if (string.IsNullOrEmpty(i3.m_i))
		{
			i3.m_i = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Filmetrics\\" + Assembly.GetExecutingAssembly().GetName().Name;
		}
		return i3.m_i;
	}

	public static void g(string A_0, string A_1)
	{
		if (!string.IsNullOrEmpty(A_0) && !A_0.EndsWith("\\"))
		{
			A_0 += "\\";
		}
		if (A_1.StartsWith("\\"))
		{
			A_1 = A_1.Substring(1);
		}
		if (A_1.Contains("\\"))
		{
			int num = A_1.IndexOf("\\");
			string text = A_0 + A_1.Substring(0, num);
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			g(text, A_1.Substring(checked(num + 1)));
		}
	}

	public static string f(string A_0, string A_1)
	{
		return h(g(A_0) + "___" + g(A_1), ".fiaan");
	}

	public static string e(string A_0, string A_1)
	{
		return h(g(A_0) + "___" + g(A_1), ".fiwan");
	}

	public static void d(string A_0, string A_1, string A_2)
	{
		BinaryWriter binaryWriter = null;
		FileStream fileStream = null;
		try
		{
			fileStream = File.OpenWrite(A_0);
			binaryWriter = new BinaryWriter(fileStream);
			binaryWriter.Write(1);
			binaryWriter.Write(A_1);
			binaryWriter.Write(A_2);
		}
		finally
		{
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

	public static void a(string A_0, ref string A_1, ref string A_2)
	{
		BinaryReader binaryReader = null;
		FileStream fileStream = null;
		try
		{
			fileStream = File.OpenRead(A_0);
			binaryReader = new BinaryReader(fileStream);
			binaryReader.ReadInt32();
			A_1 = binaryReader.ReadString();
			A_2 = binaryReader.ReadString();
		}
		finally
		{
			if (binaryReader != null)
			{
				binaryReader.Close();
			}
			else
			{
				fileStream?.Close();
			}
		}
	}

	public static string b()
	{
		return global::c.e().FileSystem.SpecialDirectories.MyDocuments;
	}

	public static bool a(DateTime A_0, DateTime A_1)
	{
		return Math.Abs(A_0.Subtract(A_1).TotalSeconds) > 2.0999999046325684;
	}

	public static string c(string A_0, DateTime A_1)
	{
		return Path.GetDirectoryName(A_0) + "\\" + a(A_0, A_1);
	}

	public static string b(string A_0, DateTime A_1)
	{
		return a(A_0, A_1, A_2: true);
	}

	public static string a(string A_0, DateTime A_1)
	{
		return a(A_0, A_1, A_2: false);
	}

	private static string a(string A_0, DateTime A_1, bool A_2)
	{
		string text = (A_2 ? string.Empty : ("." + b3.a(A_1.Millisecond, "000")));
		return Path.GetFileNameWithoutExtension(A_0) + " " + b3.a(A_1.Year) + "_" + b3.a(A_1.Month, "00") + "_" + b3.a(A_1.Day, "00") + "-" + b3.a(A_1.Hour, "00") + "_" + b3.a(A_1.Minute, "00") + "_" + b3.a(A_1.Second, "00") + text + Path.GetExtension(A_0);
	}

	public static bool a(string A_0, string[] A_1, ref Collection<string> A_2)
	{
		A_2 = new Collection<string>();
		foreach (string extension in A_1)
		{
			string path = Path.ChangeExtension(A_0, extension);
			if (File.Exists(path))
			{
				A_2.Add(Path.GetFileName(path));
			}
		}
		return A_2.Count > 0;
	}

	public static string a(ref int A_0, string A_1)
	{
		string text = A_1.Substring(A_0, A_1.Substring(A_0).IndexOf('\r'));
		checked
		{
			A_0 += text.Length + 2;
			return text;
		}
	}

	public static void a(ref int A_0, string A_1, ref string A_2)
	{
		a(ref A_0, A_1, ref A_2, A_3: false);
	}

	public static void a(ref int A_0, string A_1, string A_2, ref string A_3)
	{
		bool A_4 = default(bool);
		a(ref A_0, A_1, ref A_3, A_3: false, A_2, ref A_4);
	}

	public static void a(ref int A_0, string A_1, ref string A_2, bool A_3)
	{
		bool A_4 = default(bool);
		a(ref A_0, A_1, ref A_2, A_3, ",", ref A_4);
	}

	public static void a(ref int A_0, string A_1, ref string A_2, bool A_3, string A_4)
	{
		bool A_5 = default(bool);
		a(ref A_0, A_1, ref A_2, A_3, A_4, ref A_5);
	}

	public static void a(ref int A_0, string A_1, ref string A_2, bool A_3, ref bool A_4)
	{
		a(ref A_0, A_1, ref A_2, A_3, ",", ref A_4);
	}

	public static void a(ref int A_0, string A_1, ref string A_2, bool A_3, string A_4, ref bool A_5)
	{
		A_2 = "";
		if (A_0 >= A_1.Length)
		{
			return;
		}
		checked
		{
			char c10;
			do
			{
				c10 = A_1[A_0];
				A_2 += Conversions.ToString(c10);
				A_0++;
			}
			while (c10 != '\r' && Operators.CompareString(Conversions.ToString(c10), "\"", TextCompare: false) != 0 && Operators.CompareString(Conversions.ToString(c10), A_4, TextCompare: false) != 0 && A_0 < A_1.Length);
			if (Operators.CompareString(Conversions.ToString(c10), "\"", TextCompare: false) == 0)
			{
				if (A_3)
				{
					bool flag = false;
					A_2 = "";
					do
					{
						int num = A_1.IndexOf("\"", A_0);
						if (Operators.CompareString(A_1.Substring(num + 1, 1), "\"", TextCompare: false) == 0)
						{
							A_2 += A_1.Substring(A_0, num - A_0 + 1);
							A_0 = num + 2;
						}
						else
						{
							A_2 += A_1.Substring(A_0, num - A_0);
							A_0 = num + 1;
							flag = true;
						}
					}
					while (!flag);
				}
				else
				{
					int num2 = A_1.IndexOf("\"", A_0) - A_0;
					A_2 = A_1.Substring(A_0, num2);
					A_0 += num2;
				}
				do
				{
					c10 = A_1[A_0];
					A_0++;
				}
				while (c10 != '\r' && Operators.CompareString(Conversions.ToString(c10), A_4, TextCompare: false) != 0);
			}
			else if (A_0 < A_1.Length)
			{
				A_2 = A_2.Substring(0, A_2.Length - 1).Trim();
			}
			if (c10 == '\r')
			{
				A_5 = true;
				A_0++;
			}
			else
			{
				A_5 = false;
			}
		}
	}

	public static void c(string A_0, string A_1, string A_2)
	{
		string text = A_1 + Path.GetFileName(A_0);
		if (!Directory.Exists(A_1))
		{
			Directory.CreateDirectory(A_1);
		}
		if (Operators.CompareString(text.ToLower(), A_0.ToLower(), TextCompare: false) != 0 || !string.IsNullOrEmpty(A_2))
		{
			if (File.Exists(text))
			{
				global::c.e().FileSystem.DeleteFile(text);
			}
			if (string.IsNullOrEmpty(A_2))
			{
				File.Copy(A_0, text);
			}
			else
			{
				File.WriteAllText(text, A_2);
			}
		}
	}

	public static double b(long A_0)
	{
		return (double)A_0 / 1073741824.0;
	}

	public static double a(long A_0)
	{
		return (double)A_0 / 1048576.0;
	}

	public static void a(string A_0, ref byte[] A_1)
	{
		A_1 = File.ReadAllBytes(A_0);
	}

	public static Collection<string> j(string A_0)
	{
		return a(A_0, A_1: false, 0);
	}

	public static Collection<string> a(string A_0, bool A_1, int A_2)
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(A_0);
		string extension = Path.GetExtension(A_0);
		string[] files = Directory.GetFiles(Path.GetDirectoryName(A_0), fileNameWithoutExtension + "_*" + extension);
		checked
		{
			int num = fileNameWithoutExtension.Length + 1;
			Collection<string> collection = new Collection<string>();
			string[] array = files;
			foreach (string path in array)
			{
				bool flag = true;
				string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(path);
				int num3 = fileNameWithoutExtension2.Length - 1;
				int num4 = num3;
				for (int num5 = num; num5 <= num4; num5++)
				{
					if (!char.IsNumber(fileNameWithoutExtension2[num5]))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					collection.Add(fileNameWithoutExtension2 + extension);
					if (A_1 && collection.Count > A_2)
					{
						break;
					}
				}
			}
			return collection;
		}
	}

	public static string i(string A_0)
	{
		int num = 1;
		string text = A_0;
		while (File.Exists(text))
		{
			text = Path.GetDirectoryName(A_0) + "\\" + Path.GetFileNameWithoutExtension(A_0) + "_" + num + Path.GetExtension(A_0);
			num = checked(num + 1);
		}
		return text;
	}

	public static char h(string A_0)
	{
		if (Operators.CompareString(Path.GetExtension(A_0).ToLower(), ".txt", TextCompare: false) == 0)
		{
			return '\t';
		}
		if (Operators.CompareString(Path.GetExtension(A_0).ToLower(), ".csv", TextCompare: false) != 0 || Operators.CompareString(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator, ".", TextCompare: false) == 0)
		{
			return ',';
		}
		return ';';
	}

	public static void a(ref string A_0, ref byte[] A_1)
	{
		File.WriteAllBytes(A_0, A_1);
	}

	public static void a(BinaryReader A_0, a A_1, string A_2, int A_3)
	{
		long offset = A_0.ReadInt64();
		int a_ = A_0.ReadInt32();
		int num = A_0.ReadInt32();
		if (num <= A_3)
		{
			A_1(A_0, a_);
			A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
			return;
		}
		throw new au(A_2 + " maximum compatible block file version is " + b3.a(A_3) + " compatible version in file we are attempting to read is " + b3.a(num) + ". Software update is required in order to read file.");
	}

	public static void a(BinaryWriter A_0, b A_1, int A_2, int A_3)
	{
		long position = A_0.BaseStream.Position;
		A_0.Write(position);
		A_0.Write(A_2);
		A_0.Write(A_3);
		A_1(A_0);
		long position2 = A_0.BaseStream.Position;
		A_0.BaseStream.Seek(position, SeekOrigin.Begin);
		A_0.Write(position2);
		A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
	}

	public static void a(ref float[] A_0, BinaryReader A_1)
	{
		int num = A_1.ReadInt32();
		checked
		{
			if (num > 0)
			{
				if (A_0 == null || A_0.GetUpperBound(0) != num - 1)
				{
					A_0 = new float[num - 1 + 1];
				}
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					A_0[num3] = A_1.ReadSingle();
				}
			}
			else
			{
				A_0 = null;
			}
		}
	}

	public static void a(ref double[] A_0, BinaryReader A_1)
	{
		int num = A_1.ReadInt32();
		checked
		{
			if (num > 0)
			{
				if (A_0 == null || A_0.GetUpperBound(0) != num - 1)
				{
					A_0 = new double[num - 1 + 1];
				}
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					A_0[num3] = A_1.ReadDouble();
				}
			}
			else
			{
				A_0 = null;
			}
		}
	}

	public static void a(ref Collection<float[]> A_0, BinaryReader A_1)
	{
		A_0 = null;
		checked
		{
			if (A_1.ReadBoolean())
			{
				int num = A_1.ReadInt32();
				A_0 = new Collection<float[]>();
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					float[] A_2 = null;
					a(ref A_2, A_1);
					A_0.Add(A_2);
				}
			}
		}
	}

	public static void a(ref Collection<double> A_0, BinaryReader A_1)
	{
		A_0 = null;
		checked
		{
			if (A_1.ReadBoolean())
			{
				int num = A_1.ReadInt32();
				A_0 = new Collection<double>();
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					A_0.Add(A_1.ReadDouble());
				}
			}
		}
	}

	public static void a(ref List<float> A_0, BinaryReader A_1)
	{
		int num = A_1.ReadInt32();
		if (num > 0)
		{
			if (A_0 == null)
			{
				A_0 = new List<float>();
			}
			else
			{
				A_0.Clear();
				A_0.TrimExcess();
			}
			int num2 = num;
			for (int num3 = 1; num3 <= num2; num3 = checked(num3 + 1))
			{
				A_0.Add(A_1.ReadSingle());
			}
		}
		else
		{
			A_0 = null;
		}
	}

	public static void a(ref List<double> A_0, BinaryReader A_1)
	{
		int num = A_1.ReadInt32();
		if (num > 0)
		{
			if (A_0 == null)
			{
				A_0 = new List<double>();
			}
			else
			{
				A_0.Clear();
				A_0.TrimExcess();
			}
			int num2 = num;
			for (int num3 = 1; num3 <= num2; num3 = checked(num3 + 1))
			{
				A_0.Add(A_1.ReadDouble());
			}
		}
		else
		{
			A_0 = null;
		}
	}

	private void a(int[] A_0, BinaryWriter A_1)
	{
		if (A_0 != null)
		{
			A_1.Write(A_0.Length);
			foreach (int value in A_0)
			{
				A_1.Write(value);
			}
		}
		else
		{
			A_1.Write(0);
		}
	}

	public static void a(List<float> A_0, BinaryWriter A_1)
	{
		if (A_0 != null)
		{
			A_1.Write(A_0.Count);
			{
				foreach (float item in A_0)
				{
					A_1.Write(item);
				}
				return;
			}
		}
		A_1.Write(0);
	}

	public static void a(List<double> A_0, BinaryWriter A_1)
	{
		if (A_0 != null)
		{
			A_1.Write(A_0.Count);
			{
				foreach (double item in A_0)
				{
					A_1.Write(item);
				}
				return;
			}
		}
		A_1.Write(0);
	}

	public static void a(float[] A_0, BinaryWriter A_1)
	{
		if (A_0 != null)
		{
			A_1.Write(A_0.Length);
			foreach (float value in A_0)
			{
				A_1.Write(value);
			}
		}
		else
		{
			A_1.Write(0);
		}
	}

	public static void a(double[] A_0, BinaryWriter A_1)
	{
		if (A_0 != null)
		{
			A_1.Write(A_0.Length);
			foreach (double value in A_0)
			{
				A_1.Write(value);
			}
		}
		else
		{
			A_1.Write(0);
		}
	}

	private void a(string[] A_0, BinaryWriter A_1)
	{
		checked
		{
			if (A_0 != null)
			{
				int num = A_0.Length;
				A_1.Write(num);
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (A_0[num3] == null)
					{
						A_0[num3] = string.Empty;
					}
					A_1.Write(A_0[num3]);
				}
			}
			else
			{
				A_1.Write(0);
			}
		}
	}

	public static void a(Collection<float[]> A_0, BinaryWriter A_1)
	{
		checked
		{
			if (A_0 != null)
			{
				A_1.Write(value: true);
				A_1.Write(A_0.Count);
				int num = A_0.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					a(A_0[num2], A_1);
				}
			}
			else
			{
				A_1.Write(value: false);
			}
		}
	}

	public static void a(Collection<double> A_0, BinaryWriter A_1)
	{
		checked
		{
			if (A_0 != null)
			{
				A_1.Write(value: true);
				A_1.Write(A_0.Count);
				int num = A_0.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					A_1.Write(A_0[num2]);
				}
			}
			else
			{
				A_1.Write(value: false);
			}
		}
	}

	public static string g(string A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		string text = A_0;
		int upperBound = invalidFileNameChars.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			text = text.Replace(invalidFileNameChars[num], '~');
		}
		return text;
	}

	public static bool f(string A_0)
	{
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		foreach (char c10 in invalidFileNameChars)
		{
			if (A_0.Contains(Conversions.ToString(c10)))
			{
				return false;
			}
		}
		return true;
	}

	public static bool e(string A_0)
	{
		StreamWriter streamWriter = null;
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool result;
		try
		{
			flag = File.Exists(A_0);
			streamWriter = new StreamWriter(File.Open(A_0, FileMode.Append, FileAccess.Write), Encoding.UTF8);
			flag2 = true;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			result = false;
			ProjectData.ClearProjectError();
			goto IL_0049;
		}
		finally
		{
			streamWriter?.Close();
			if (!flag && flag2)
			{
				File.Delete(A_0);
			}
		}
		result = true;
		goto IL_0049;
		IL_0049:
		return result;
	}

	public static string d(string A_0, string A_1)
	{
		if (!A_0.ToUpper().StartsWith(A_1.ToUpper()))
		{
			throw new DirectoryNotFoundException("fullPath does not start with rootDir");
		}
		if (A_1.EndsWith("\\"))
		{
			A_1 = A_1.Substring(0, checked(A_1.Length - 1));
		}
		string text = A_0.Substring(A_1.Length);
		if (!text.StartsWith("\\"))
		{
			throw new DirectoryNotFoundException("rootDir is not a directory in fullPath");
		}
		return text.Substring(1);
	}

	public static void a(string A_0, string A_1, string A_2, bool A_3, bool A_4, ref List<string> A_5)
	{
		if (A_5 == null)
		{
			A_5 = new List<string>();
		}
		string[] files = Directory.GetFiles(A_0, "*" + A_2);
		for (int num = 0; num < files.Length; num = checked(num + 1))
		{
			string text = d(files[num], A_1);
			if (A_4)
			{
				text = text.Substring(0, text.LastIndexOf('.'));
			}
			A_5.Add(text);
		}
		string[] directories = Directory.GetDirectories(A_0);
		foreach (string a_ in directories)
		{
			if (A_3)
			{
				a(a_, A_1, A_2, A_3: true, A_4, ref A_5);
			}
		}
	}

	private static string a()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		return folderPath.Substring(0, checked(folderPath.IndexOf('\\') + 1));
	}

	public static string d(string A_0)
	{
		if (Directory.Exists(A_0))
		{
			return A_0;
		}
		if (Directory.Exists(b()))
		{
			return b();
		}
		return a();
	}

	public static byte[] c(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return null;
		}
		byte[] array = new byte[3] { 5, 113, 52 };
		int num = 0;
		byte[] bytes = new ASCIIEncoding().GetBytes(A_0);
		int upperBound = bytes.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[bytes.GetUpperBound(0) + 1];
			for (int num2 = 0; num2 <= upperBound; num2++)
			{
				byte b10 = bytes[num2];
				if (num2 + 1 <= upperBound)
				{
					byte b11 = bytes[num2 + 1];
					byte b12 = (byte)unchecked((uint)(checked((byte)unchecked((uint)((b10 & 0x96) + (b11 & 0x69)))) + array[num]));
					num++;
					if (num == 3)
					{
						num = 0;
					}
					byte b13 = (byte)unchecked((uint)(checked((byte)unchecked((uint)((b10 & 0x69) + (b11 & 0x96)))) + array[num]));
					num++;
					if (num == 3)
					{
						num = 0;
					}
					array2[num2] = b12;
					num2++;
					array2[num2] = b13;
				}
				else
				{
					array2[num2] = b10;
				}
			}
			return array2;
		}
	}

	public static string a(byte[] A_0)
	{
		if (A_0 == null)
		{
			return "";
		}
		byte[] array = new byte[3] { 5, 113, 52 };
		int num = 0;
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		int upperBound = A_0.GetUpperBound(0);
		int num2 = 0;
		checked
		{
			byte[] array2 = new byte[A_0.GetUpperBound(0) + 1];
			for (; num2 <= upperBound; num2++)
			{
				byte b10 = A_0[num2];
				if (num2 + 1 <= upperBound)
				{
					byte b11 = A_0[num2 + 1];
					b10 = (byte)unchecked((uint)(b10 - array[num]));
					num++;
					if (num == 3)
					{
						num = 0;
					}
					b11 = (byte)unchecked((uint)(b11 - array[num]));
					num++;
					if (num == 3)
					{
						num = 0;
					}
					byte b12 = (byte)unchecked((uint)((b10 & 0x96) + (b11 & 0x69)));
					byte b13 = (byte)unchecked((uint)((b10 & 0x69) + (b11 & 0x96)));
					array2[num2] = b12;
					num2++;
					array2[num2] = b13;
				}
				else
				{
					array2[num2] = b10;
				}
			}
			return aSCIIEncoding.GetString(array2);
		}
	}

	public static void c(string A_0, string A_1)
	{
		if (!Directory.Exists(A_0))
		{
			return;
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(A_0);
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		FileInfo[] files = directoryInfo.GetFiles();
		if (!Directory.Exists(A_1))
		{
			Directory.CreateDirectory(A_1);
		}
		FileInfo[] array = files;
		foreach (FileInfo fileInfo in array)
		{
			if (File.GetAttributes(fileInfo.FullName) != FileAttributes.Normal)
			{
				File.SetAttributes(fileInfo.FullName, FileAttributes.Normal);
			}
			b(A_0, A_1, fileInfo.Name);
		}
		DirectoryInfo[] array2 = directories;
		foreach (DirectoryInfo directoryInfo2 in array2)
		{
			c(directoryInfo2.FullName, A_1 + "\\" + directoryInfo2.Name);
		}
		if (Directory.Exists(A_0))
		{
			global::c.e().FileSystem.DeleteDirectory(A_0, DeleteDirectoryOption.DeleteAllContents);
		}
	}

	public static void b(string A_0, string A_1)
	{
		a(A_0, A_1, A_2: false);
	}

	public static void a(string A_0, string A_1)
	{
		a(A_0, A_1, A_2: true);
	}

	private static void a(string A_0, string A_1, bool A_2)
	{
		a(A_0, A_1, A_2, null);
	}

	public static void a(string A_0, string A_1, bool A_2, List<string> A_3)
	{
		if (!Directory.Exists(A_0))
		{
			return;
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(A_0);
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		FileInfo[] files = directoryInfo.GetFiles();
		if (!Directory.Exists(A_1))
		{
			Directory.CreateDirectory(A_1);
		}
		FileInfo[] array = files;
		foreach (FileInfo fileInfo in array)
		{
			bool flag = false;
			if (A_3 != null)
			{
				foreach (string item in A_3)
				{
					if (string.Compare(Path.GetFileName(fileInfo.FullName), item, StringComparison.OrdinalIgnoreCase) == 0)
					{
						flag = true;
					}
				}
			}
			if (!flag)
			{
				if (File.GetAttributes(fileInfo.FullName) != FileAttributes.Normal)
				{
					File.SetAttributes(fileInfo.FullName, FileAttributes.Normal);
				}
				if (A_2)
				{
					b(A_0, A_1, fileInfo.Name);
				}
				else
				{
					File.Copy(A_0 + "\\" + fileInfo.Name, A_1 + "\\" + fileInfo.Name, overwrite: true);
				}
			}
		}
		DirectoryInfo[] array2 = directories;
		foreach (DirectoryInfo directoryInfo2 in array2)
		{
			a(directoryInfo2.FullName, A_1 + "\\" + directoryInfo2.Name, A_2);
		}
	}

	public static void b(string A_0, string A_1, string A_2)
	{
		string text = A_1 + "\\" + A_2;
		string text2 = A_0 + "\\" + A_2;
		bool num = File.Exists(text);
		DateTime lastWriteTimeUtc = default(DateTime);
		if (num)
		{
			lastWriteTimeUtc = File.GetLastWriteTimeUtc(text);
		}
		DateTime lastWriteTimeUtc2 = File.GetLastWriteTimeUtc(text2);
		if (!num || (a(lastWriteTimeUtc, lastWriteTimeUtc2) && DateTime.Compare(lastWriteTimeUtc, lastWriteTimeUtc2) < 0))
		{
			File.Copy(text2, text, overwrite: true);
		}
	}

	public static void a(string A_0, string A_1, string A_2)
	{
		if (File.Exists(A_0 + "\\" + A_2))
		{
			b(A_0, A_1, A_2);
			File.Delete(A_0 + "\\" + A_2);
		}
	}

	public static bool a(string A_0, a5 A_1)
	{
		FileInfo fileInfo = new FileInfo(A_0);
		DateTime lastWriteTimeUtc = fileInfo.LastWriteTimeUtc;
		if (!a(lastWriteTimeUtc, A_1.g()))
		{
			return true;
		}
		if (lastWriteTimeUtc.Subtract(A_1.g()).TotalHours > 26.0)
		{
			return true;
		}
		if (fileInfo.Length != A_1.f())
		{
			return false;
		}
		return a(fileInfo.FullName, A_1.e);
	}

	private static bool a(string A_0, byte[] A_1)
	{
		FileStream fileStream = null;
		BinaryReader binaryReader = null;
		checked
		{
			byte[] array;
			try
			{
				fileStream = new FileStream(A_0, FileMode.Open, FileAccess.Read);
				binaryReader = new BinaryReader(fileStream);
				array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			}
			finally
			{
				binaryReader.Close();
				fileStream.Close();
			}
			int num = array.Length;
			if (num != A_1.Length)
			{
				return false;
			}
			int num2 = num - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (array[num3] != A_1[num3])
				{
					return false;
				}
			}
			return true;
		}
	}

	public static string[] b(string A_0)
	{
		FileInfo[] files = new DirectoryInfo(A_0).GetFiles();
		checked
		{
			int num = files.Length - 1;
			DateTime[] array = new DateTime[num + 1];
			string[] array2 = new string[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				array[num3] = files[num3].LastWriteTimeUtc;
				array2[num3] = files[num3].FullName;
			}
			Array.Sort(array, array2);
			return array2;
		}
	}

	public static string[] a(string A_0)
	{
		DirectoryInfo[] directories = new DirectoryInfo(A_0).GetDirectories();
		checked
		{
			int num = directories.Length - 1;
			DateTime[] array = new DateTime[num + 1];
			string[] array2 = new string[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				array[num3] = directories[num3].LastWriteTimeUtc;
				array2[num3] = directories[num3].FullName;
			}
			Array.Sort(array, array2);
			return array2;
		}
	}

	public static long b(string A_0, bool A_1)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(A_0);
		FileInfo[] files = directoryInfo.GetFiles();
		checked
		{
			long num2 = default(long);
			foreach (FileInfo fileInfo in files)
			{
				num2 += fileInfo.Length;
			}
			if (A_1)
			{
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				foreach (DirectoryInfo directoryInfo2 in directories)
				{
					num2 += b(directoryInfo2.FullName, A_1);
				}
			}
			return num2;
		}
	}

	public static double a(string A_0, bool A_1)
	{
		return a(b(A_0, A_1));
	}

	public static void a(string A_0, ref double[] A_1, ref double[] A_2)
	{
		StreamReader streamReader = null;
		try
		{
			if (!File.Exists(A_0))
			{
				throw new FileNotFoundException(A_0 + " is missing.");
			}
			streamReader = new StreamReader(A_0);
			string text = streamReader.ReadLine();
			List<double> list = new List<double>();
			List<double> list2 = new List<double>();
			while (!streamReader.EndOfStream)
			{
				text = streamReader.ReadLine().Trim();
				if (!string.IsNullOrEmpty(text))
				{
					string text2 = text;
					int num = text2.IndexOf(",");
					if (!double.TryParse(text2.Substring(0, num), NumberStyles.Float, CultureInfo.InvariantCulture, out var result))
					{
						throw new av(A_0 + " can't be read because it doesn't have the correct format.");
					}
					list.Add(result);
					if (!double.TryParse(checked(text2.Substring(num + 1, text2.Length - num - 1)), NumberStyles.Float, CultureInfo.InvariantCulture, out result))
					{
						throw new av(A_0 + " can't be read because it doesn't have the correct format.");
					}
					list2.Add(result);
					text2 = null;
				}
			}
			A_1 = list.ToArray();
			A_2 = list2.ToArray();
		}
		finally
		{
			streamReader?.Close();
		}
	}

	public static void a(string A_0, ref double[] A_1, ref double[] A_2, ref double[] A_3)
	{
		StreamReader streamReader = null;
		checked
		{
			try
			{
				if (!File.Exists(A_0))
				{
					throw new FileNotFoundException(A_0 + " is missing.");
				}
				streamReader = new StreamReader(A_0);
				string text = streamReader.ReadLine();
				List<double> list = new List<double>();
				List<double> list2 = new List<double>();
				List<double> list3 = new List<double>();
				while (!streamReader.EndOfStream)
				{
					text = streamReader.ReadLine().Trim();
					if (!string.IsNullOrEmpty(text))
					{
						string text2 = text;
						int num = text2.IndexOf(",");
						int num2 = text2.LastIndexOf(",");
						if (!double.TryParse(text2.Substring(0, num), NumberStyles.Float, CultureInfo.InvariantCulture, out var result))
						{
							throw new av(A_0 + " can't be read because it doesn't have the correct format.");
						}
						list.Add(result);
						if (!double.TryParse(text2.Substring(num + 1, num2 - num - 1), NumberStyles.Float, CultureInfo.InvariantCulture, out result))
						{
							throw new av(A_0 + " can't be read because it doesn't have the correct format.");
						}
						list2.Add(result);
						if (!double.TryParse(text2.Substring(num2 + 1, text2.Length - num2 - 1), NumberStyles.Float, CultureInfo.InvariantCulture, out result))
						{
							throw new av(A_0 + " can't be read because it doesn't have the correct format.");
						}
						list3.Add(result);
						text2 = null;
					}
				}
				A_1 = list.ToArray();
				A_2 = list2.ToArray();
				A_3 = list3.ToArray();
			}
			finally
			{
				streamReader?.Close();
			}
		}
	}
}
