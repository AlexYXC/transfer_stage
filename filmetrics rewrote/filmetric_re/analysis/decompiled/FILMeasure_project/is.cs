using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class @is
{
	public enum a
	{
		a,
		b,
		c,
		d,
		e
	}

	private const string m_a = "SpecData\\";

	private const string m_b = ".fmsdf";

	private const string m_c = ".fibpb";

	private const string d = "Spec_";

	private const string m_e = ".fmspdf";

	private const string m_f = "PersistSpec_";

	private const string m_g = "SpecLin_";

	private const string h = ".fmslb";

	private const string i = ".fmpdf";

	private const string j = "PD_";

	private const string k = ".fmcdf";

	private const string l = "Con_";

	private a m;

	public const string n = "<Default>";

	public const string o = "<Default>";

	public @is(a A_0)
	{
		m = A_0;
	}

	[SpecialName]
	public string e()
	{
		return f(m);
	}

	[SpecialName]
	public static string f(a A_0)
	{
		return A_0 switch
		{
			@is.a.a => ".fmsdf", 
			@is.a.b => ".fmpdf", 
			@is.a.c => ".fmcdf", 
			@is.a.d => ".fmspdf", 
			@is.a.e => ".fmslb", 
			_ => null, 
		};
	}

	[SpecialName]
	public static string e(a A_0)
	{
		if (A_0 == @is.a.a)
		{
			return ".fibpb";
		}
		int num = (int)A_0;
		throw new aw("Unsupported PendingFileExt FileType. aFileType=" + num);
	}

	[SpecialName]
	public string f()
	{
		return c(m);
	}

	[SpecialName]
	public static string c(a A_0)
	{
		return A_0 switch
		{
			@is.a.a => "Spec_", 
			@is.a.b => "PD_", 
			@is.a.c => "Con_", 
			@is.a.d => "PersistSpec_", 
			@is.a.e => "SpecLin_", 
			_ => null, 
		};
	}

	[SpecialName]
	public static string b(a A_0)
	{
		return b(A_0, null, null);
	}

	[SpecialName]
	public static string c(a A_0, string A_1)
	{
		if (Operators.CompareString(A_1, "<Default>", TextCompare: false) == 0)
		{
			A_1 = string.Empty;
		}
		return b(A_0, null, A_1);
	}

	[SpecialName]
	public static string b(a A_0, string A_1)
	{
		return b(A_0, A_1, null);
	}

	[SpecialName]
	public bool b(string A_0)
	{
		if (A_0.Split('_').Length == 3 || m == @is.a.c || m == @is.a.d || m == @is.a.e)
		{
			return true;
		}
		return false;
	}

	[SpecialName]
	public static string b(a A_0, string A_1, string A_2)
	{
		string text = "*" + f(A_0);
		bool flag = A_2 != null;
		bool flag2 = !string.IsNullOrEmpty(A_1);
		if (flag)
		{
			text = A_2 + text;
		}
		if (flag2)
		{
			text = ((!flag) ? (A_1 + text) : (A_1 + "_" + text));
		}
		else if (flag)
		{
			text = "*" + text;
		}
		if (flag || flag2)
		{
			text = c(A_0) + text;
		}
		return text;
	}

	[SpecialName]
	public static string c()
	{
		return "SpecData\\";
	}

	public static string b()
	{
		return i3.o() + "\\" + c();
	}

	public void b(Collection<FileInfo> A_0, string A_1)
	{
		if (!Directory.Exists(A_1))
		{
			Directory.CreateDirectory(A_1);
		}
		foreach (FileInfo item in A_0)
		{
			c(A_1, item.Name);
		}
		foreach (FileInfo item2 in A_0)
		{
			File.Copy(item2.FullName, A_1 + item2.Name, overwrite: true);
		}
	}

	public void c(string A_0, string A_1)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(A_0);
		string searchPattern;
		if (m == @is.a.c || m == @is.a.d || m == @is.a.e)
		{
			searchPattern = A_1;
			FileInfo[] files = directoryInfo.GetFiles(searchPattern);
			foreach (FileInfo fileInfo in files)
			{
				if (fileInfo.Attributes != FileAttributes.Normal)
				{
					fileInfo.Attributes = FileAttributes.Normal;
				}
				File.Delete(fileInfo.FullName);
			}
			return;
		}
		string[] array = A_1.Split('_');
		bool flag;
		if (array.Length == 3)
		{
			searchPattern = array[0] + "_" + array[1] + "*" + e();
			flag = true;
		}
		else
		{
			searchPattern = array[0] + "_" + array[1] + "_" + array[2] + "*" + e();
			flag = false;
		}
		FileInfo[] files2 = directoryInfo.GetFiles(searchPattern);
		foreach (FileInfo fileInfo2 in files2)
		{
			if (fileInfo2.Attributes != FileAttributes.Normal)
			{
				fileInfo2.Attributes = FileAttributes.Normal;
			}
			if (flag)
			{
				if (fileInfo2.Name.Split('_').Length == 3)
				{
					File.Delete(fileInfo2.FullName);
				}
			}
			else
			{
				File.Delete(fileInfo2.FullName);
			}
		}
	}

	public bool g()
	{
		if (m != @is.a.d)
		{
			return m == @is.a.e;
		}
		return true;
	}

	public void b(string A_0, ref Collection<FileInfo> A_1)
	{
		if (A_1 == null)
		{
			A_1 = new Collection<FileInfo>();
		}
		if (Directory.Exists(A_0) && g())
		{
			string searchPattern = f() + "*" + e();
			FileInfo[] files = new DirectoryInfo(A_0).GetFiles(searchPattern);
			foreach (FileInfo item in files)
			{
				A_1.Add(item);
			}
		}
	}

	public void b(string A_0, string A_1, string A_2, bool A_3, ref Collection<FileInfo> A_4)
	{
		if (A_4 == null)
		{
			A_4 = new Collection<FileInfo>();
		}
		if (!Directory.Exists(A_2))
		{
			return;
		}
		if (m == @is.a.c || m == @is.a.d || m == @is.a.e)
		{
			string searchPattern = f() + A_0.ToString() + e();
			FileInfo[] files = new DirectoryInfo(A_2).GetFiles(searchPattern);
			foreach (FileInfo item in files)
			{
				A_4.Add(item);
			}
			return;
		}
		int num2 = 0;
		checked
		{
			FileInfo[] array;
			int num5;
			if (A_3)
			{
				string searchPattern = f() + A_0.ToString() + "_*" + e();
				FileInfo[] files2 = new DirectoryInfo(A_2).GetFiles(searchPattern);
				array = new FileInfo[files2.GetUpperBound(0) + 1];
				int num3 = 0;
				FileInfo[] array2 = files2;
				foreach (FileInfo fileInfo in array2)
				{
					if (fileInfo.Name.Split('_').Length == 3)
					{
						array[num3] = fileInfo;
						num3++;
					}
				}
				num5 = num3;
			}
			else
			{
				string searchPattern = f() + A_0.ToString() + "_" + A_1 + "_*" + e();
				array = new DirectoryInfo(A_2).GetFiles(searchPattern);
				num5 = array.Length;
			}
			num2 = 0;
			bool flag;
			do
			{
				flag = false;
				int num6 = num5 - 1;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					FileInfo fileInfo2 = array[num7];
					if (b(fileInfo2.Name, num2))
					{
						A_4.Add(fileInfo2);
						flag = true;
						break;
					}
				}
				num2++;
			}
			while (flag);
		}
	}

	public static string b(string A_0, string A_1)
	{
		checked
		{
			if (A_0.Contains(A_1))
			{
				int num = A_0.IndexOf(A_1) + A_1.Length + 1;
				int num2 = A_0.LastIndexOf("_") - num;
				if (num2 > 0)
				{
					return A_0.Substring(num, num2);
				}
				return "<Default>";
			}
			return null;
		}
	}

	public string c(string A_0)
	{
		string empty = string.Empty;
		string text = A_0.Substring(checked(A_0.IndexOf("_") + 1));
		empty = ((m != @is.a.c && m != @is.a.d && m != @is.a.e) ? "_" : ".");
		return text.Substring(0, text.IndexOf(empty));
	}

	private bool b(string A_0, int A_1)
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(A_0);
		if (int.TryParse(fileNameWithoutExtension.Substring(checked(fileNameWithoutExtension.LastIndexOf("_") + 1)), out var result))
		{
			return result == A_1;
		}
		return false;
	}

	public void b(string A_0, string A_1, bool A_2, List<it> A_3, ref Collection<FileInfo> A_4)
	{
		if (A_4 == null)
		{
			A_4 = new Collection<FileInfo>();
		}
		checked
		{
			if (A_3 != null)
			{
				int num = A_3.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					b(A_3[num2].e(), A_0, A_1, A_2, ref A_4);
				}
			}
		}
	}
}
