using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class cg
{
	private Collection<cf> a;

	public void f(fz A_0, ref string A_1)
	{
		List<string> list = new List<string>();
		A_1 = null;
		bool flag = true;
		a.Clear();
		string text = i3.o() + cf.l();
		string searchPattern = "*.fictm";
		if (!c.e().FileSystem.DirectoryExists(text))
		{
			c.e().FileSystem.CreateDirectory(text);
		}
		string[] files = Directory.GetFiles(text, searchPattern);
		if (files.Length > 0)
		{
			Array.Sort(files);
			string A_2 = string.Empty;
			string[] array = files;
			foreach (string text2 in array)
			{
				cf cf2 = new cf();
				if (cf2.l(text2, ref A_2) == cf.b.a)
				{
					a.Add(cf2);
					continue;
				}
				flag = false;
				list.Add("\"" + text2 + "\": " + A_2);
			}
		}
		if (flag)
		{
			return;
		}
		A_1 = "One (or more) CTM Optic Files are incompatible with this version of software and requires the latest software version:\r\n\r\n";
		foreach (string item in list)
		{
			A_0.c(fz.b.a, item);
			A_1 = A_1 + item + "\r\n";
		}
	}

	public cg()
	{
		a = new Collection<cf>();
	}

	[SpecialName]
	public int f()
	{
		return a.Count;
	}

	[SpecialName]
	public cf f(int A_0)
	{
		return a[A_0];
	}

	[SpecialName]
	public cf g()
	{
		if (f() > 0)
		{
			return a[0];
		}
		return null;
	}

	[SpecialName]
	public string[] h()
	{
		checked
		{
			int num = a.Count - 1;
			if (num < 0)
			{
				return null;
			}
			string[] array = new string[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				array[num3] = a[num3].n();
			}
			return array;
		}
	}

	[SpecialName]
	public cf f(string A_0)
	{
		foreach (cf item in a)
		{
			if (Operators.CompareString(item.n(), A_0, TextCompare: false) == 0)
			{
				return item;
			}
		}
		return null;
	}
}
