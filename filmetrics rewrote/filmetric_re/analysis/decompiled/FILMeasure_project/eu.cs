using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class eu
{
	private class a
	{
		public string a;

		public bool b;

		public double c;

		public a(string A_0, bool A_1, double A_2)
		{
			a = A_0;
			b = A_1;
			c = A_2;
		}
	}

	private Collection<es> m_a;

	private string b;

	public const string c = "\\Optics\\";

	public const string d = ".fimic";

	public const string e = ".dat";

	private List<a> m_f;

	private const int m_g = 10;

	private const int m_h = 9;

	private const int m_i = 9;

	public int j;

	public eu()
	{
		b = "Microscope";
		this.m_a = new Collection<es>();
		this.m_f = new List<a>();
	}

	[SpecialName]
	public static bool g(eu A_0, eu A_1)
	{
		checked
		{
			switch (ix.a(A_0, A_1))
			{
			case ix.a.a:
				return false;
			case ix.a.b:
				return true;
			default:
			{
				eu eu2 = A_0;
				if (Operators.CompareString(eu2.b, A_1.b, TextCompare: false) != 0)
				{
					return true;
				}
				switch (ix.a(eu2.m_a, A_1.m_a))
				{
				case ix.a.a:
					return false;
				case ix.a.b:
					return true;
				default:
				{
					if (eu2.m_a.Count == 0 && A_1.m_a.Count == 0)
					{
						return false;
					}
					if (eu2.m_a.Count != A_1.m_a.Count)
					{
						return true;
					}
					int num = eu2.m_a.Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						et a_ = eu2.m_a[num2] as et;
						et a_2 = A_1.m_a[num2] as et;
						if (et.u(a_, a_2))
						{
							return true;
						}
					}
					if (eu2.m_f.Count == 0 && A_1.m_f.Count == 0)
					{
						return false;
					}
					if (eu2.m_f.Count != A_1.m_f.Count)
					{
						return true;
					}
					int num3 = eu2.m_f.Count - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						if (Operators.CompareString(eu2.m_f[num4].a, A_1.m_f[num4].a, TextCompare: false) != 0)
						{
							return true;
						}
						if (eu2.m_f[num4].b != A_1.m_f[num4].b)
						{
							return true;
						}
						if (eu2.m_f[num4].c != A_1.m_f[num4].c)
						{
							return true;
						}
					}
					eu2 = null;
					return false;
				}
				}
			}
			}
		}
	}

	[SpecialName]
	public static bool f(eu A_0, eu A_1)
	{
		return !g(A_0, A_1);
	}

	public void f(string A_0)
	{
		BinaryReader binaryReader = null;
		binaryReader = new BinaryReader(File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read));
		checked
		{
			try
			{
				int num = binaryReader.ReadInt32();
				int num2 = binaryReader.ReadInt32();
				if (num2 > 10)
				{
					throw new Exception("Incompatible Objective File Format. Newer software version is required to read this file. FileVer=" + num + ", CompatVer=" + num2);
				}
				bool flag = num >= 9;
				int num3 = binaryReader.ReadInt32();
				this.m_a = new Collection<es>();
				int num4 = num3 - 1;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					es es2 = new et();
					if (flag)
					{
						es2.ab(binaryReader);
					}
					else
					{
						es2.ac(binaryReader, num);
					}
					this.m_a.Add(es2);
				}
				string directoryName = Path.GetDirectoryName(A_0);
				foreach (es item in this.m_a)
				{
					if (item is et et2)
					{
						string text = directoryName + "\\" + item.al() + ".fimpr";
						if (File.Exists(text))
						{
							ev ev2 = new ev();
							ev2.l(text);
							et2.t(ev2);
						}
					}
				}
				if (num > 9)
				{
					int num6 = binaryReader.ReadInt32() - 1;
					for (int num7 = 0; num7 <= num6; num7++)
					{
						string a_ = binaryReader.ReadString();
						bool a_2 = binaryReader.ReadBoolean();
						double a_3 = binaryReader.ReadDouble();
						this.m_f.Add(new a(a_, a_2, a_3));
					}
				}
			}
			finally
			{
				binaryReader?.Close();
			}
		}
	}

	public void f()
	{
		string path = i3.o() + "\\Optics\\" + i() + ".fimic";
		BinaryWriter binaryWriter = null;
		checked
		{
			try
			{
				binaryWriter = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate));
				binaryWriter.Write(10);
				binaryWriter.Write(9);
				if (this.m_a != null)
				{
					binaryWriter.Write(this.m_a.Count);
				}
				else
				{
					binaryWriter.Write(0);
				}
				if (this.m_a != null && this.m_a.Count > 0)
				{
					foreach (es item in this.m_a)
					{
						item.y(binaryWriter);
					}
				}
				binaryWriter.Write(this.m_f.Count);
				int num = this.m_f.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					binaryWriter.Write(this.m_f[num2].a);
					binaryWriter.Write(this.m_f[num2].b);
					binaryWriter.Write(this.m_f[num2].c);
				}
			}
			finally
			{
				binaryWriter?.Close();
			}
		}
	}

	public et g()
	{
		if (this.m_a == null || this.m_a.Count == 0)
		{
			return null;
		}
		et result = null;
		float num = float.MaxValue;
		foreach (es item in this.m_a)
		{
			if (item is et et2 && et2.ag() > 0f && et2.ag() < num)
			{
				num = et2.ag();
				result = et2;
			}
		}
		return result;
	}

	public et h()
	{
		if (this.m_a == null || this.m_a.Count == 0)
		{
			return null;
		}
		et result = null;
		float num = float.MinValue;
		foreach (es item in this.m_a)
		{
			if (item is et et2 && et2.ag() > 0f && et2.ag() > num)
			{
				num = et2.ag();
				result = et2;
			}
		}
		return result;
	}

	public void f(string A_0, string A_1)
	{
		string text = i3.o() + "\\Optics\\";
		global::c.e().FileSystem.RenameFile(text + A_0 + ".fimic", A_1 + ".fimic");
		h(A_1);
	}

	public void g(string A_0)
	{
		string file = i3.o() + "\\Optics\\" + A_0 + ".fimic";
		if (global::c.e().FileSystem.FileExists(file))
		{
			global::c.e().FileSystem.DeleteFile(file);
		}
	}

	public void f(eu A_0)
	{
		if (this.m_a == null || this.m_a.Count <= 0)
		{
			return;
		}
		A_0.f(new Collection<es>());
		foreach (es item in this.m_a)
		{
			es es2 = new et();
			item.ad(es2);
			A_0.l().Add(es2);
		}
	}

	[SpecialName]
	public string i()
	{
		return b;
	}

	[SpecialName]
	public void h(string A_0)
	{
		b = A_0;
	}

	[SpecialName]
	public es f(int A_0)
	{
		return this.m_a[A_0];
	}

	[SpecialName]
	public string[] k()
	{
		checked
		{
			int num = this.m_a.Count - 1;
			if (num < 0)
			{
				return null;
			}
			string[] array = new string[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				array[num3] = this.m_a[num3].al();
			}
			return array;
		}
	}

	[SpecialName]
	public es i(string A_0)
	{
		foreach (es item in this.m_a)
		{
			if (Operators.CompareString(item.al(), A_0, TextCompare: false) == 0)
			{
				return item;
			}
		}
		return null;
	}

	[SpecialName]
	public Collection<es> l()
	{
		return this.m_a;
	}

	[SpecialName]
	public void f(Collection<es> A_0)
	{
		this.m_a = A_0;
	}
}
