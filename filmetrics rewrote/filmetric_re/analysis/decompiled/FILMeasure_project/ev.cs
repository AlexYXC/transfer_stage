using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class ev
{
	public const string a = "\\CalPatterns\\";

	public const string b = "Micropos";

	public const string c = ".fimpr";

	private const int d = 2;

	private const int e = 2;

	private string f;

	private float g;

	private float h;

	private float i;

	private float[] j;

	private float[] k;

	private Collection<float[]> m_l;

	private Collection<float[]> m_m;

	private Collection<float[]> m_n;

	private Collection<float[]> m_o;

	private Guid m_p;

	public ev()
	{
	}

	public ev(string A_0, float A_1, float A_2, float A_3, float[] A_4, float[] A_5, Collection<float[]> A_6, Collection<float[]> A_7, Collection<float[]> A_8, Collection<float[]> A_9)
	{
		if (A_6 == null || A_8 == null)
		{
			throw new Exception("shortSpecRatioArrays and shortSpecBacRatioArrays can not be Nothing.");
		}
		f = A_0;
		g = A_1;
		h = A_2;
		i = A_3;
		j = A_4;
		k = A_5;
		this.m_l = A_6;
		this.m_m = A_7;
		this.m_n = A_8;
		this.m_o = A_9;
		this.m_p = Guid.NewGuid();
	}

	[SpecialName]
	public string l()
	{
		return f;
	}

	[SpecialName]
	public float m()
	{
		return g;
	}

	[SpecialName]
	public float n()
	{
		return h;
	}

	[SpecialName]
	public float o()
	{
		return i;
	}

	[SpecialName]
	public float[] p()
	{
		return j;
	}

	[SpecialName]
	public float[] q()
	{
		return k;
	}

	[SpecialName]
	public Collection<float[]> r()
	{
		return this.m_n;
	}

	[SpecialName]
	public Collection<float[]> s()
	{
		return this.m_o;
	}

	[SpecialName]
	public Collection<float[]> t()
	{
		return this.m_l;
	}

	[SpecialName]
	public Collection<float[]> u()
	{
		return this.m_m;
	}

	[SpecialName]
	public Guid v()
	{
		return this.m_p;
	}

	public void l(string A_0)
	{
		BinaryReader binaryReader = null;
		checked
		{
			try
			{
				binaryReader = new BinaryReader(File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read));
				int num = binaryReader.ReadInt32();
				int num2 = binaryReader.ReadInt32();
				if (num2 > 2)
				{
					throw new Exception("Incompatible ObjectiveRatio File Format. Newer software version is required to read this file. FileVer=" + num + ", CompatVer=" + num2);
				}
				f = binaryReader.ReadString();
				string text = binaryReader.ReadString();
				this.m_p = new Guid(text);
				g = binaryReader.ReadSingle();
				h = binaryReader.ReadSingle();
				i = binaryReader.ReadSingle();
				int num3 = binaryReader.ReadInt32();
				int num4 = binaryReader.ReadInt32() - 1;
				j = new float[num3 - 1 + 1];
				k = new float[num3 - 1 + 1];
				this.m_l = new Collection<float[]>();
				int num5 = num3 - 1;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					j[num6] = binaryReader.ReadSingle();
					k[num6] = binaryReader.ReadSingle();
					float[] array = new float[num4 + 1];
					int num7 = num4;
					for (int num8 = 0; num8 <= num7; num8++)
					{
						array[num8] = binaryReader.ReadSingle();
					}
					this.m_l.Add(array);
				}
				bool flag = binaryReader.ReadBoolean();
				int num9 = default(int);
				if (flag)
				{
					this.m_m = new Collection<float[]>();
					num9 = binaryReader.ReadInt32() - 1;
					int num10 = num3 - 1;
					for (int num6 = 0; num6 <= num10; num6++)
					{
						float[] array = new float[num9 + 1];
						int num11 = num9;
						for (int num8 = 0; num8 <= num11; num8++)
						{
							array[num8] = binaryReader.ReadSingle();
						}
						this.m_m.Add(array);
					}
				}
				if (num <= 1)
				{
					return;
				}
				this.m_n = new Collection<float[]>();
				int num12 = num3 - 1;
				for (int num6 = 0; num6 <= num12; num6++)
				{
					float[] array = new float[num4 + 1];
					int num13 = num4;
					for (int num8 = 0; num8 <= num13; num8++)
					{
						array[num8] = binaryReader.ReadSingle();
					}
					this.m_n.Add(array);
				}
				if (!flag)
				{
					return;
				}
				this.m_o = new Collection<float[]>();
				int num14 = num3 - 1;
				for (int num6 = 0; num6 <= num14; num6++)
				{
					float[] array = new float[num9 + 1];
					int num15 = num9;
					for (int num8 = 0; num8 <= num15; num8++)
					{
						array[num8] = binaryReader.ReadSingle();
					}
					this.m_o.Add(array);
				}
			}
			finally
			{
				binaryReader?.Close();
			}
		}
	}

	public void w()
	{
		string path = i3.o() + "\\Optics\\" + f + ".fimpr";
		BinaryWriter binaryWriter = null;
		string value = b3.a(this.m_p);
		bool flag = this.m_m != null && this.m_o.Count > 0;
		checked
		{
			try
			{
				if (File.Exists(path))
				{
					File.Delete(path);
				}
				binaryWriter = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate));
				BinaryWriter binaryWriter2 = binaryWriter;
				binaryWriter2.Write(2);
				binaryWriter2.Write(2);
				binaryWriter2.Write(f);
				binaryWriter2.Write(value);
				binaryWriter2.Write(g);
				binaryWriter2.Write(h);
				binaryWriter2.Write(i);
				binaryWriter2.Write(j.Length);
				binaryWriter2.Write(this.m_l[0].Length);
				int num = j.Length - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					binaryWriter2.Write(j[num2]);
					binaryWriter2.Write(k[num2]);
					float[] array = this.m_l[num2];
					int num3 = array.Length - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						binaryWriter2.Write(array[num4]);
					}
				}
				binaryWriter2.Write(flag);
				if (flag)
				{
					binaryWriter2.Write(this.m_m[0].Length);
					int num5 = j.Length - 1;
					for (int num2 = 0; num2 <= num5; num2++)
					{
						float[] array = this.m_m[num2];
						int num6 = array.Length - 1;
						for (int num4 = 0; num4 <= num6; num4++)
						{
							binaryWriter2.Write(array[num4]);
						}
					}
				}
				int num7 = j.Length - 1;
				for (int num2 = 0; num2 <= num7; num2++)
				{
					float[] array = this.m_n[num2];
					int num8 = array.Length - 1;
					for (int num4 = 0; num4 <= num8; num4++)
					{
						binaryWriter2.Write(array[num4]);
					}
				}
				if (flag)
				{
					int num9 = j.Length - 1;
					for (int num2 = 0; num2 <= num9; num2++)
					{
						float[] array = this.m_o[num2];
						int num10 = array.Length - 1;
						for (int num4 = 0; num4 <= num10; num4++)
						{
							binaryWriter2.Write(array[num4]);
						}
					}
				}
				binaryWriter2 = null;
			}
			finally
			{
				binaryWriter?.Close();
			}
		}
	}

	public void x()
	{
		string path = i3.o() + "\\Optics\\" + f + ".fimpr";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
	}

	[SpecialName]
	public static bool m(ev A_0, ev A_1)
	{
		switch (ix.a(A_0, A_1))
		{
		case ix.a.a:
			return false;
		case ix.a.b:
			return true;
		default:
		{
			ev ev2 = A_0;
			if (Operators.CompareString(ev2.f, A_1.f, TextCompare: false) != 0)
			{
				return true;
			}
			if (ev2.m_p != A_1.m_p)
			{
				return true;
			}
			ev2 = null;
			return false;
		}
		}
	}

	[SpecialName]
	public static bool l(ev A_0, ev A_1)
	{
		return !m(A_0, A_1);
	}
}
