using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class ep
{
	private Collection<eu> a;

	public void e()
	{
		a = new Collection<eu>();
		string text = i3.o() + "\\Optics\\";
		string searchPattern = "*.fimic";
		if (!c.e().FileSystem.DirectoryExists(text))
		{
			c.e().FileSystem.CreateDirectory(text);
		}
		string[] files = Directory.GetFiles(text, searchPattern);
		if (files.Length == 0)
		{
			eu item = new eu();
			a.Add(item);
			return;
		}
		Array.Sort(files);
		string[] array = files;
		foreach (string text2 in array)
		{
			eu eu2 = new eu();
			eu2.h(Path.GetFileNameWithoutExtension(text2));
			eu2.f(text2);
			a.Add(eu2);
		}
	}

	[SpecialName]
	public string[] f()
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
				array[num3] = a[num3].i();
			}
			return array;
		}
	}

	[SpecialName]
	public eu e(int A_0)
	{
		return a[A_0];
	}

	[SpecialName]
	public eu e(string A_0)
	{
		checked
		{
			int num = a.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (Operators.CompareString(a[num2].i(), A_0, TextCompare: false) == 0)
				{
					return a[num2];
				}
			}
			return null;
		}
	}

	[SpecialName]
	public Collection<eu> g()
	{
		return a;
	}

	public void e(g2 A_0, ref bool A_1)
	{
		A_1 = false;
		if (A_0.p())
		{
			eu eu2 = e(A_0.w);
			if (eu2 == null)
			{
				eu2 = e(0);
				A_0.w = eu2.i();
				A_0.a((es)null);
				A_1 = true;
			}
			es es2 = null;
			if (A_0.r() != null)
			{
				es2 = eu2.i(A_0.r().al());
			}
			if (A_0.r() == null || es2 == null)
			{
				if (eu2.l().Count > 0)
				{
					A_0.a(eu2.f(0));
					A_1 = true;
				}
				else
				{
					A_1 = A_0.r() != null;
					A_0.a((es)null);
				}
			}
			else if (et.u((et)A_0.r(), (et)es2))
			{
				A_0.a(es2);
			}
		}
		else if (A_0.m())
		{
			et et2 = new et();
			if (et.u((et)A_0.r(), et2))
			{
				A_0.a(et2);
			}
		}
		else if (A_0.r() != null)
		{
			A_0.a((es)null);
		}
	}
}
