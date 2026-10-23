using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

internal abstract class a1
{
	protected const string a = "\\Licenses\\";

	public const string b = "Software Only";

	public const int c = 4;

	public const int d = 5;

	public abstract string bg(int A_0);

	public abstract int bf(string A_0);

	public abstract bool bh(int A_0, bool A_1);

	public abstract void b2(int A_0, string A_1, string A_2, ref string A_3, ref string A_4);

	public abstract string br(int A_0);

	public abstract string b1();

	public abstract List<int> bs();

	public abstract List<int> bt();

	public abstract List<int> bu();

	public abstract void b3(ref string A_0, int A_1, string A_2, string A_3, string A_4, ref bool A_5, ref string A_6);

	public abstract int bi(string A_0);

	public abstract bool bj(int A_0);

	public abstract bool bk(int A_0);

	public abstract bool bl(int A_0);

	public abstract void bm(int A_0, string A_1, ref bool A_2);

	public abstract bool bn(int A_0);

	public abstract bool bo(int A_0, string A_1);

	public abstract bool bp(int A_0);

	public abstract bool bq(int A_0);

	public abstract string bv();

	public abstract List<int> bw(int A_0);

	public abstract List<string> bx(int A_0);

	public abstract string by(int A_0);

	public abstract string bz(int A_0);

	public abstract string b0(int A_0);

	public string c(string A_0)
	{
		return bg(bf(A_0));
	}

	public static string d()
	{
		return i3.o() + "\\Licenses\\";
	}

	public static string c()
	{
		return i3.c() + "\\Licenses\\";
	}

	public List<string> l()
	{
		List<string> list = new List<string>();
		foreach (int item in bs())
		{
			list.Add(br(item));
		}
		return list;
	}

	public List<string> m()
	{
		List<string> list = new List<string>();
		foreach (int item in bt())
		{
			list.Add(br(item));
		}
		return list;
	}

	public bool f(int A_0)
	{
		if (!bq(A_0))
		{
			return bp(A_0);
		}
		return true;
	}

	public bool g(int A_0)
	{
		if (!bk(A_0) && !bq(A_0))
		{
			return bl(A_0);
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public static string c(ref string A_0, ref short A_1, ref int A_2, ref string A_3, ref string A_4)
	{
		string Value = "";
		int num = default(int);
		try
		{
			num = Microsoft.VisualBasic.FileSystem.FreeFile();
			Microsoft.VisualBasic.FileSystem.FileOpen(num, A_0, OpenMode.Input);
			Microsoft.VisualBasic.FileSystem.Input(num, ref A_1);
			Microsoft.VisualBasic.FileSystem.Input(num, ref Value);
			if (A_1 >= 4)
			{
				Microsoft.VisualBasic.FileSystem.Input(num, ref A_2);
			}
			else
			{
				A_2 = 0;
			}
			if (A_1 >= 5)
			{
				Microsoft.VisualBasic.FileSystem.Input(num, ref A_3);
			}
			else
			{
				A_3 = "";
			}
			if (!Microsoft.VisualBasic.FileSystem.EOF(num))
			{
				try
				{
					Microsoft.VisualBasic.FileSystem.Input(num, ref A_4);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex3 = ex2;
					A_4 = string.Empty;
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				A_4 = string.Empty;
			}
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception ex5 = ex4;
			ProjectData.ClearProjectError();
		}
		finally
		{
			Microsoft.VisualBasic.FileSystem.FileClose(num);
		}
		return Value;
	}

	public bool c(string A_0, string A_1, int A_2, bool A_3, ref int A_4, ref string A_5, ref string[] A_6)
	{
		string text = "";
		string text2 = "";
		bool flag = false;
		string A_7 = null;
		string A_8 = null;
		string A_9 = null;
		try
		{
			string text3 = bg(A_2);
			if (global::c.e().FileSystem.DirectoryExists(text3))
			{
				bool flag2 = bh(A_2, A_3);
				b2(A_2, A_1, A_0, ref A_8, ref A_9);
				bool flag3 = false;
				List<string> list;
				short A_11 = default(short);
				bool flag5 = default(bool);
				do
				{
					string text4 = br(A_2);
					list = new List<string>();
					ReadOnlyCollection<string> readOnlyCollection;
					if (!flag3 && !flag2)
					{
						List<string> list2 = new List<string>();
						string text5 = text3 + text4 + "_" + A_9 + b1();
						if (File.Exists(text5))
						{
							list2.Add(text5);
						}
						readOnlyCollection = new ReadOnlyCollection<string>(list2);
					}
					else
					{
						readOnlyCollection = global::c.e().FileSystem.GetFiles(text3, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, text4 + b1(), text4 + "_?" + b1());
					}
					foreach (string item in readOnlyCollection)
					{
						string A_10 = item;
						if (flag2)
						{
							return true;
						}
						text = c(ref A_10, ref A_11, ref A_4, ref A_5, ref A_7);
						bool flag4 = A_11 == 2;
						text2 = ((A_4 != 0 || !string.IsNullOrEmpty(A_5)) ? (Strings.Left(A_8, 10) + Strings.Right(A_1, 3) + Strings.Right(A_8, 10) + A_2.ToString().Trim() + A_5 + A_4.ToString().Trim()) : (Strings.Left(A_8, 10) + Strings.Right(A_1, 3) + Strings.Right(A_8, 10) + Conversions.ToString(A_2)));
						string left = ((!flag4) ? hh.b(ref text2) : hh.a(ref text2));
						if (Operators.CompareString(left, text, TextCompare: false) == 0)
						{
							flag5 = true;
							list.Add(A_7);
							flag = true;
						}
					}
					if (!flag)
					{
						if (!flag3)
						{
							flag3 = true;
						}
						else
						{
							flag5 = true;
						}
					}
				}
				while (!flag5);
				A_6 = list.ToArray();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			flag = false;
			ProjectData.ClearProjectError();
		}
		return flag;
	}
}
