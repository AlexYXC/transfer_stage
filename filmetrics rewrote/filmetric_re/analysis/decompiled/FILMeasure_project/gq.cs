using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class gq
{
	public enum a
	{
		a,
		b,
		c,
		d,
		e
	}

	private bool m_a;

	private a b;

	private string c;

	private Exception d;

	private List<string> e;

	private bool f;

	private const string m_g = "Password.dat";

	private const string m_h = "PassWor_.dat";

	private const string m_i = "OpRecipes.dat";

	public const string j = "AccConOff";

	public const string k = " FiLmEtRiCs";

	[SpecialName]
	public bool g()
	{
		return this.m_a;
	}

	[SpecialName]
	public void g(bool A_0)
	{
		this.m_a = A_0;
	}

	[SpecialName]
	public a h()
	{
		return b;
	}

	[SpecialName]
	public void g(a A_0)
	{
		b = A_0;
	}

	[SpecialName]
	public string i()
	{
		if (b != gq.a.a && this.m_a)
		{
			return c;
		}
		return "";
	}

	[SpecialName]
	public Exception j()
	{
		return d;
	}

	[SpecialName]
	public bool k()
	{
		return f;
	}

	[SpecialName]
	public void h(bool A_0)
	{
		f = A_0;
	}

	[SpecialName]
	public List<string> l()
	{
		return e;
	}

	[SpecialName]
	public void g(List<string> A_0)
	{
		e = A_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public a g(string A_0, string A_1)
	{
		string Value = string.Empty;
		string Value2 = string.Empty;
		int num = default(int);
		try
		{
			num = FileSystem.FreeFile();
			if (A_1.Length > 15)
			{
				A_1 = A_1.Substring(0, 14);
			}
			string fileName = i3.o() + "\\Password.dat";
			bool flag = false;
			FileSystem.FileOpen(num, fileName, OpenMode.Input);
			int Value3 = default(int);
			while (!FileSystem.EOF(num) && !flag)
			{
				FileSystem.Input(num, ref Value);
				FileSystem.Input(num, ref Value2);
				FileSystem.Input(num, ref Value3);
				if (Operators.CompareString(A_0, Value, TextCompare: false) == 0)
				{
					string A_2 = Value + Value3 + A_1;
					if (Operators.CompareString(hh.b(ref A_2), Value2, TextCompare: false) == 0)
					{
						flag = true;
					}
				}
			}
			if (flag)
			{
				c = Value;
				return (a)Value3;
			}
			c = "";
			return gq.a.a;
		}
		finally
		{
			FileSystem.FileClose(num);
		}
	}

	public bool g(string A_0)
	{
		if (e == null)
		{
			return false;
		}
		foreach (string item in e)
		{
			if (Operators.CompareString(item.ToLower(), A_0, TextCompare: false) == 0)
			{
				return true;
			}
		}
		return false;
	}

	public static bool g(gq A_0)
	{
		if (A_0 != null && A_0.g())
		{
			return A_0.h() >= gq.a.c;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public void g(string A_0, string A_1, a A_2)
	{
		string Value = string.Empty;
		string Value2 = string.Empty;
		string text = i3.o() + "\\Password.dat";
		string fileName = i3.o() + "\\PassWor_.dat";
		int num = (int)A_2;
		string A_3 = A_0 + num + A_1;
		string text2 = hh.b(ref A_3);
		bool flag = false;
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			num2 = FileSystem.FreeFile();
			FileSystem.FileOpen(num2, text, OpenMode.Input);
			num3 = FileSystem.FreeFile();
			FileSystem.FileOpen(num3, fileName, OpenMode.Output);
			short Value3 = default(short);
			while (!FileSystem.EOF(num2))
			{
				FileSystem.Input(num2, ref Value2);
				FileSystem.Input(num2, ref Value);
				FileSystem.Input(num2, ref Value3);
				if (Operators.CompareString(Value2, A_0, TextCompare: false) == 0)
				{
					FileSystem.WriteLine(num3, A_0, text2, A_2);
					flag = true;
				}
				else
				{
					FileSystem.WriteLine(num3, Value2, Value, Value3);
				}
			}
			if (!flag)
			{
				FileSystem.WriteLine(num3, A_0, text2, A_2);
			}
			FileSystem.FileClose(num2);
			FileSystem.FileClose(num3);
			FileSystem.Kill(text);
			FileSystem.Rename(i3.o() + "\\PassWor_.dat", text);
		}
		finally
		{
			FileSystem.FileClose(num2);
			FileSystem.FileClose(num3);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public void h(string A_0, string A_1)
	{
		string Value = string.Empty;
		string Value2 = string.Empty;
		string text = i3.o() + "\\Password.dat";
		string text2 = i3.o() + "\\PassWor_.dat";
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = FileSystem.FreeFile();
			FileSystem.FileOpen(num, text, OpenMode.Input);
			num2 = FileSystem.FreeFile();
			FileSystem.FileOpen(num2, text2, OpenMode.Output);
			int Value3 = default(int);
			while (!FileSystem.EOF(num))
			{
				FileSystem.Input(num, ref Value2);
				FileSystem.Input(num, ref Value);
				FileSystem.Input(num, ref Value3);
				if (Operators.CompareString(Value2, A_0, TextCompare: false) != 0)
				{
					FileSystem.WriteLine(num2, Value2, Value, Value3);
				}
			}
			FileSystem.FileClose(num);
			FileSystem.FileClose(num2);
			FileSystem.Kill(text);
			FileSystem.Rename(text2, text);
		}
		finally
		{
			FileSystem.FileClose(num);
			FileSystem.FileClose(num2);
		}
	}

	public void m()
	{
		try
		{
			this.m_a = true;
			b = gq.a.a;
			if (g(" FiLmEtRiCs", "AccConOff") != gq.a.a)
			{
				this.m_a = false;
				b = gq.a.c;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			d = ex3;
			ProjectData.ClearProjectError();
		}
	}

	public void n()
	{
		StreamWriter streamWriter = null;
		try
		{
			string path = i3.o() + "\\OpRecipes.dat";
			streamWriter = new StreamWriter(path);
			streamWriter.WriteLine(f.ToString());
			foreach (string item in e)
			{
				streamWriter.WriteLine(item);
			}
		}
		finally
		{
			streamWriter?.Close();
		}
	}

	public gq()
	{
		StreamReader streamReader = null;
		try
		{
			string path = i3.o() + "\\OpRecipes.dat";
			if (File.Exists(path))
			{
				streamReader = new StreamReader(path);
				f = bool.Parse(streamReader.ReadLine());
				List<string> list = new List<string>();
				while (!streamReader.EndOfStream)
				{
					list.Add(streamReader.ReadLine());
				}
				e = list;
			}
			else
			{
				e = new List<string>();
			}
		}
		finally
		{
			streamReader?.Close();
		}
	}
}
