using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

internal class ek
{
	public delegate void a(ek A_0, en A_1);

	internal class b
	{
		public hg a;

		public Collection<en> b;

		public b(en A_0)
		{
			b = new Collection<en>();
			a = new hg(A_0.b.cy().dh(), A_0.b.cy().cd());
			A_0.b.cy().bu(ref a);
			b.Add(A_0);
		}
	}

	public string a;

	public DateTime b;

	public Collection<el> c;

	public string d;

	public string e;

	public DateTime f;

	public hc g;

	[CompilerGenerated]
	private int h;

	[CompilerGenerated]
	private int i;

	[CompilerGenerated]
	private int j;

	public const string k = "MeasReport2.xlt";

	public const string l = ".fibcm";

	public const string m = "*.fibcm";

	public const string n = "Filmetrics Complete Measurement Document (*.fibcm)";

	public Collection<hg> o;

	[CompilerGenerated]
	private a m_p;

	private const int q = 1;

	public const string r = "yyyy-MM-dd";

	[SpecialName]
	[CompilerGenerated]
	public int l()
	{
		return h;
	}

	[SpecialName]
	[CompilerGenerated]
	public void l(int A_0)
	{
		h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public int m()
	{
		return i;
	}

	[SpecialName]
	[CompilerGenerated]
	public void m(int A_0)
	{
		i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public int n()
	{
		return j;
	}

	[SpecialName]
	[CompilerGenerated]
	public void n(int A_0)
	{
		j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void l(a A_0)
	{
		a a10 = this.m_p;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Combine(a11, A_0);
			a10 = Interlocked.CompareExchange(ref this.m_p, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void m(a A_0)
	{
		a a10 = this.m_p;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Remove(a11, A_0);
			a10 = Interlocked.CompareExchange(ref this.m_p, value, a11);
		}
		while ((object)a10 != a11);
	}

	public void l(en A_0)
	{
		this.m_p?.Invoke(this, A_0);
	}

	public void l(string A_0, fz A_1, eo A_2, hg.j A_3)
	{
		BinaryReader binaryReader = null;
		checked
		{
			try
			{
				binaryReader = new BinaryReader(File.Open(A_0, FileMode.Open));
				long offset = binaryReader.ReadInt64();
				binaryReader.ReadInt32();
				int num = binaryReader.ReadInt32();
				if (1 >= num)
				{
					d = A_0;
					e = binaryReader.ReadString();
					this.a = binaryReader.ReadString();
					this.b = DateTime.FromOADate(binaryReader.ReadDouble());
					int num2 = binaryReader.ReadInt32();
					f = DateTime.FromOADate(binaryReader.ReadDouble());
					int num3 = num2 - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						el el2 = new el();
						el2.b.Clear();
						el2.d(binaryReader, A_1, A_2, A_3);
						c.Add(el2);
					}
					binaryReader.BaseStream.Seek(offset, SeekOrigin.Begin);
					return;
				}
				throw new au("MeasReports maximum compatible block file version is " + 1 + " compatible version in file we are attempting to read is " + num);
			}
			finally
			{
				binaryReader.Close();
			}
		}
	}

	public void l(string A_0)
	{
		BinaryWriter binaryWriter = null;
		try
		{
			binaryWriter = new BinaryWriter(File.Open(A_0, FileMode.Create));
			long position = binaryWriter.BaseStream.Position;
			binaryWriter.Write(position);
			binaryWriter.Write(1);
			binaryWriter.Write(1);
			binaryWriter.Write(e);
			binaryWriter.Write(this.a);
			binaryWriter.Write(this.b.ToOADate());
			binaryWriter.Write(c.Count);
			binaryWriter.Write(f.ToOADate());
			foreach (el item in c)
			{
				item.d(binaryWriter);
			}
			long position2 = binaryWriter.BaseStream.Position;
			binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);
			binaryWriter.Write(position2);
			binaryWriter.BaseStream.Seek(position2, SeekOrigin.Begin);
		}
		finally
		{
			binaryWriter.Close();
		}
	}

	public Collection<b> p()
	{
		Collection<b> collection = new Collection<b>();
		checked
		{
			int num = c.Count - 1;
			int A_ = default(int);
			for (int num2 = 0; num2 <= num; num2++)
			{
				int num3 = c[num2].b.Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					int num5 = c[num2].b[num4].b.Count - 1;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						en en2 = c[num2].b[num4].b[num6];
						if (en2.b != null)
						{
							string a_ = en2.b.cy().cl();
							if (collection.Count == 0)
							{
								collection.Add(new b(en2));
							}
							else if (l(collection, a_, ref A_))
							{
								collection[A_].b.Add(en2);
							}
							else
							{
								collection.Add(new b(en2));
							}
						}
					}
				}
			}
			l(collection);
			return collection;
		}
	}

	public void l(hr A_0, int A_1, int A_2)
	{
		en en2 = new en();
		em em2 = c[A_1].b[A_2];
		em2.k();
		A_0.ak(c[A_1].d() + "-" + em2.f() + "-" + A_0.cb().ToString("yyyy-MM-dd") + "-" + em2.c);
		en2.a = A_0;
		en2.i(A_0.b5());
		en2.g = A_0.cb().ToString("yyyy-MM-dd") + "-" + em2.c;
		em2.b.Add(en2);
		checked
		{
			em2.c++;
			em2 = null;
		}
	}

	public void l(en A_0, el A_1, em A_2)
	{
		hr hr2 = A_0.b.cn();
		em em2 = A_2;
		em2.k();
		hr2.ak(A_1.d() + "-" + em2.f() + "-" + hr2.cb().ToString("yyyy-MM-dd") + "-" + em2.c);
		checked
		{
			hr hr3;
			(hr3 = hr2).t(hr3.ca() + 1);
			A_0.a = hr2;
			A_0.i(hr2.b5());
			A_0.g = hr2.cb().ToString("yyyy-MM-dd") + "-" + em2.c;
			em2.b.Add(A_0);
			em2.c++;
			em2 = null;
		}
		A_0.b.cf((a4.a)global::e.a().ShowSpectrumCoordOption, global::e.a().AlwayShowSpectrumCoordXYZ);
	}

	private bool l(Collection<b> A_0, string A_1, ref int A_2)
	{
		checked
		{
			int num = A_0.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (Operators.CompareString(A_0[num2].a.cl(), A_1, TextCompare: false) == 0)
				{
					A_2 = num2;
					return true;
				}
			}
			return false;
		}
	}

	public bool l(long A_0, ref bool A_1)
	{
		int A_2 = 0;
		int A_3 = 0;
		int A_4 = 0;
		return l(A_0, ref A_1, ref A_2, ref A_3, ref A_4);
	}

	public bool l(long A_0, ref bool A_1, ref int A_2, ref int A_3, ref int A_4)
	{
		checked
		{
			int num = c.Count - 1;
			for (A_2 = 0; A_2 <= num; A_2++)
			{
				el el2 = c[A_2];
				int num2 = el2.b.Count - 1;
				for (A_3 = 0; A_3 <= num2; A_3++)
				{
					em em2 = el2.b[A_3];
					int num3 = em2.b.Count - 1;
					for (A_4 = 0; A_4 <= num3; A_4++)
					{
						en en2 = em2.b[A_4];
						if (en2.a.b9() == A_0)
						{
							A_1 = en2.b != null;
							return true;
						}
					}
				}
			}
			return false;
		}
	}

	public void l(string A_0, Collection<b> A_1)
	{
		TextWriter textWriter = new StreamWriter(A_0, append: false);
		textWriter.WriteLine("SpectrumName\tRecipeName");
		try
		{
			foreach (b item in A_1)
			{
				foreach (en item2 in item.b)
				{
					textWriter.WriteLine(item2.j() + "\t" + item.a.ci());
				}
			}
		}
		finally
		{
			textWriter.Close();
		}
	}

	public void l(ek A_0)
	{
		ek ek2 = A_0;
		ek2.a = this.a;
		ek2.b = this.b;
		ek2.c = new Collection<el>();
		checked
		{
			int num = c.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				el el2 = new el();
				c[num2].d(el2);
				ek2.c.Add(el2);
			}
			ek2.d = d;
			ek2.e = e;
			ek2.f = f;
			ek2 = null;
		}
	}

	public void m(string A_0)
	{
		checked
		{
			int num = c.Count - 1;
			bool flag = default(bool);
			for (int num2 = 0; num2 <= num; num2++)
			{
				int num3 = c[num2].b.Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					int num5 = c[num2].b[num4].b.Count - 1;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						en en2 = c[num2].b[num4].b[num6];
						if (en2.a == null)
						{
							continue;
						}
						en en3 = en2;
						string text;
						if (en3.k() || en3.l())
						{
							text = A_0;
						}
						else
						{
							text = A_0 + "\\Unmarked";
							if (!flag && !Directory.Exists(A_0 + "\\Unmarked"))
							{
								Directory.CreateDirectory(A_0 + "\\Unmarked");
							}
							flag = true;
						}
						hr obj = en3.a;
						string A_1 = text + "\\" + en3.a.b5() + ".fmspe";
						obj.k(ref A_1, en3.a.bz(), en3.a.by());
						en3 = null;
					}
				}
			}
		}
	}

	public void l(string A_0, Collection<b> A_1, Point A_2, fz A_3, hg.j A_4)
	{
		string text = i3.o() + "\\Temp\\ExportRecipe\\";
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		checked
		{
			int num = A_1.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				string extension = Path.GetExtension(A_1[num2].a.c1());
				A_1[num2].a.ch(text + A_1[num2].a.ci() + extension);
				string[] a_ = new string[1] { text + A_1[num2].a.ci() + extension };
				hg.bu(A_3, hg.g.a, A_0, a_, A_2, global::r.d.a.b.a, A_4);
			}
		}
	}

	public void n(string A_0)
	{
		Collection<hc> collection = new Collection<hc>();
		checked
		{
			int num = c.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				int num3 = c[num2].b.Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					int num5 = c[num2].b[num4].b.Count - 1;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						en en2 = c[num2].b[num4].b[num6];
						if (en2.b != null)
						{
							collection.Add(en2.b);
						}
					}
				}
			}
			string a_ = A_0 + "\\" + this.a + ".fibhi";
			Collection<cb> a_2 = new Collection<cb>();
			DateTime a_3 = f;
			hc A_1 = null;
			cc.cf(a_, 2, collection, a_2, a_3, A_5: false, 0, ref A_1);
		}
	}

	private void l(Collection<b> A_0)
	{
		Collection<hg> collection = new Collection<hg>();
		int num = 1;
		foreach (b item in A_0)
		{
			collection.Add(item.a);
		}
		if (collection.Count <= 1)
		{
			return;
		}
		checked
		{
			for (int num2 = collection.Count - 1; num2 >= 0; num2 += -1)
			{
				bool flag = false;
				for (int num3 = num2 - 1; num3 >= 0; num3 += -1)
				{
					if (string.Compare(collection[num3].ci(), collection[num2].ci(), ignoreCase: true) == 0)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					continue;
				}
				string text;
				bool flag2;
				do
				{
					text = collection[num2].ci() + "_" + Conversions.ToString(num);
					flag2 = false;
					int num4 = collection.Count - 1;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						if (string.Compare(collection[num5].ci(), text, ignoreCase: true) == 0)
						{
							flag2 = true;
							num++;
							break;
						}
					}
				}
				while (flag2);
				collection[num2].b9(text);
			}
		}
	}

	public void l(hc A_0)
	{
		int A_1 = -1;
		if (o.Count == 0)
		{
			hg hg2 = l(A_0.cy());
			o.Insert(o.Count, hg2);
			A_0.cg(hg2);
		}
		else if (!l(A_0.cy().cl(), ref A_1))
		{
			hg hg2 = l(A_0.cy());
			o.Insert(o.Count, hg2);
			A_0.cg(hg2);
		}
		else
		{
			A_0.cg(o[A_1]);
		}
	}

	private bool l(string A_0, ref int A_1)
	{
		checked
		{
			int num = o.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (Operators.CompareString(o[num2].cl(), A_0, TextCompare: false) == 0)
				{
					A_1 = num2;
					return true;
				}
			}
			return false;
		}
	}

	private hg l(hg A_0)
	{
		hg A_1 = new hg(A_0.dh(), A_0.cd());
		A_0.bu(ref A_1);
		return A_1;
	}

	public void m(hg A_0)
	{
		bool flag = false;
		checked
		{
			int num = c.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				int num3 = c[num2].b.Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					int num5 = c[num2].b[num4].b.Count - 1;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						en en2 = c[num2].b[num4].b[num6];
						if (en2.b != null && en2.b.cy() == A_0)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						break;
					}
				}
				if (flag)
				{
					break;
				}
			}
			if (!flag)
			{
				o.Remove(A_0);
			}
		}
	}

	public ek()
	{
		this.a = string.Empty;
		this.b = DateTime.Now;
		c = new Collection<el>();
		e = string.Empty;
		f = DateTime.Now;
		g = null;
		o = new Collection<hg>();
		new el().d("Sample #1");
		c.Add(new el());
	}
}
