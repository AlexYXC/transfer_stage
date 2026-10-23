using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class he
{
	public enum a
	{
		a = 1,
		b,
		c,
		d,
		e,
		f,
		g
	}

	public const string a = ".ficrp";

	public const string b = " <Composite>";

	public const string c = "Composite Recipe Files (.ficrp)|*.ficrp";

	public const string d = "All";

	public const string e = "All";

	public const string f = "Composite Recipe";

	private const short g = 1;

	private const short h = 1;

	private string i;

	private string j;

	private double k;

	private bool l;

	private Collection<string> m;

	private Collection<hg> n;

	private Collection<int> o;

	private Collection<string> p;

	private Collection<int> q;

	private Collection<string> r;

	private Collection<a> m_s;

	private Collection<double> m_t;

	private string m_u;

	[SpecialName]
	public bool u()
	{
		return l;
	}

	[SpecialName]
	public void s(bool A_0)
	{
		l = A_0;
	}

	public void s(fz A_0, Point A_1, ref bool A_2)
	{
		if (!ae())
		{
			string A_3 = "RecipeUnsavedPromptFmt3";
			if (!fe.b(ref A_0, string.Format(hu.a(ref A_3), Strings.LCase("Composite Recipe"), "\r\n", Strings.LCase("Recipe")), "RecipeLoadTitle", "OKString", "CancelString", A_1))
			{
				A_2 = true;
			}
			else
			{
				A_2 = false;
			}
		}
		else
		{
			A_2 = false;
		}
	}

	[SpecialName]
	public string v()
	{
		int num = Strings.InStr(this.m_u, hg.bz(), CompareMethod.Text);
		int num2 = this.m_u.Substring(num).IndexOf("\\");
		return this.m_u.Substring(checked(num + num2));
	}

	[SpecialName]
	public string w()
	{
		return this.m_u;
	}

	[SpecialName]
	public void v(string A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	public string x()
	{
		return Path.GetFileNameWithoutExtension(this.m_u) + " <Composite>";
	}

	[SpecialName]
	public string y()
	{
		return i;
	}

	[SpecialName]
	public void w(string A_0)
	{
		i = A_0;
	}

	[SpecialName]
	public string z()
	{
		return j;
	}

	[SpecialName]
	public void x(string A_0)
	{
		j = A_0;
	}

	[SpecialName]
	public double aa()
	{
		return k;
	}

	[SpecialName]
	public void s(double A_0)
	{
		k = A_0;
	}

	[SpecialName]
	public int ab()
	{
		return m.Count;
	}

	[SpecialName]
	public int ac()
	{
		return o.Count;
	}

	[SpecialName]
	public Collection<hg> ad()
	{
		return n;
	}

	[SpecialName]
	public void s(Collection<hg> A_0)
	{
		n = A_0;
	}

	[SpecialName]
	public bool ae()
	{
		foreach (hg item in ad())
		{
			if (!item.c9())
			{
				return false;
			}
		}
		if (!u())
		{
			return false;
		}
		return true;
	}

	[SpecialName]
	public Collection<string> af()
	{
		Collection<string> collection = new Collection<string>();
		foreach (string item in m)
		{
			collection.Add(s(item));
		}
		return collection;
	}

	public void y(string A_0)
	{
		m.Add(u(A_0));
	}

	public void s(int A_0)
	{
		m.RemoveAt(A_0);
	}

	public void s(string A_0, int A_1)
	{
		if (A_1 < m.Count)
		{
			string value = u(A_0);
			m[A_1] = value;
		}
	}

	[SpecialName]
	public int t(int A_0)
	{
		if (A_0 <= checked(o.Count - 1))
		{
			return o[A_0];
		}
		return 0;
	}

	[SpecialName]
	public void s(int A_0, int A_1)
	{
		o[A_0] = A_1;
	}

	[SpecialName]
	public string u(int A_0)
	{
		if (A_0 <= checked(o.Count - 1))
		{
			return p[A_0];
		}
		return string.Empty;
	}

	[SpecialName]
	public void s(int A_0, string A_1)
	{
		p[A_0] = A_1;
	}

	[SpecialName]
	public int v(int A_0)
	{
		if (A_0 <= checked(q.Count - 1))
		{
			return q[A_0];
		}
		return 0;
	}

	[SpecialName]
	public void t(int A_0, int A_1)
	{
		q[A_0] = A_1;
	}

	[SpecialName]
	public string w(int A_0)
	{
		if (A_0 <= checked(o.Count - 1))
		{
			return r[A_0];
		}
		return string.Empty;
	}

	[SpecialName]
	public void t(int A_0, string A_1)
	{
		r[A_0] = A_1;
	}

	[SpecialName]
	public a x(int A_0)
	{
		if (A_0 <= checked(o.Count - 1))
		{
			return this.m_s[A_0];
		}
		return (a)0;
	}

	[SpecialName]
	public void s(int A_0, a A_1)
	{
		this.m_s[A_0] = A_1;
	}

	[SpecialName]
	public double y(int A_0)
	{
		if (A_0 <= checked(o.Count - 1))
		{
			return this.m_t[A_0];
		}
		return 0.0;
	}

	[SpecialName]
	public void s(int A_0, double A_1)
	{
		this.m_t[A_0] = A_1;
	}

	public he(string A_0, string A_1, string A_2)
	{
		m = new Collection<string>();
		n = new Collection<hg>();
		o = new Collection<int>();
		p = new Collection<string>();
		q = new Collection<int>();
		r = new Collection<string>();
		this.m_s = new Collection<a>();
		this.m_t = new Collection<double>();
		if (!string.IsNullOrEmpty(A_0))
		{
			aa(A_0);
		}
		else
		{
			s(A_1, A_2);
		}
	}

	public static string t()
	{
		return hg.bz() + s();
	}

	public static string s()
	{
		return "\\New Composite Recipe.ficrp";
	}

	public void s(ref he A_0)
	{
		s(ref A_0, A_1: false);
	}

	public void s(ref he A_0, bool A_1)
	{
		bool a_ = !A_1;
		if (A_0 == null)
		{
			A_0 = new he(string.Empty, string.Empty, string.Empty);
		}
		A_0.t(a_);
		he he2 = A_0;
		he2.v(this.m_u);
		he2.k = k;
		he2.j = j;
		he2.i = i;
		he2.s(l);
		checked
		{
			int num = ab() - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				he2.m.Add(m[num2]);
			}
			if (A_1)
			{
				he2.s(n);
			}
			int num3 = ac() - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				he2.o.Add(o[num4]);
				he2.p.Add(p[num4]);
				he2.q.Add(q[num4]);
				he2.r.Add(r[num4]);
				he2.m_s.Add(this.m_s[num4]);
				he2.m_t.Add(this.m_t[num4]);
			}
			he2 = null;
		}
	}

	[SpecialName]
	public static bool t(he A_0, he A_1)
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
				he he2 = A_0;
				if (Operators.CompareString(he2.w(), A_1.w(), TextCompare: false) != 0)
				{
					return true;
				}
				if (he2.aa() != A_1.aa())
				{
					return true;
				}
				if (Operators.CompareString(he2.z(), A_1.z(), TextCompare: false) != 0)
				{
					return true;
				}
				if (Operators.CompareString(he2.y(), A_1.y(), TextCompare: false) != 0)
				{
					return true;
				}
				if (he2.ab() != A_1.ab())
				{
					return true;
				}
				int num = he2.ab() - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (Operators.CompareString(he2.af()[num2], A_1.af()[num2], TextCompare: false) != 0)
					{
						return true;
					}
				}
				if (he2.ac() != A_1.ac())
				{
					return true;
				}
				int num3 = he2.ac() - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (he2.t(num4) != A_1.t(num4))
					{
						return true;
					}
					if (Operators.CompareString(he2.u(num4), A_1.u(num4), TextCompare: false) != 0)
					{
						return true;
					}
					if (he2.v(num4) != A_1.v(num4))
					{
						return true;
					}
					if (Operators.CompareString(he2.w(num4), A_1.w(num4), TextCompare: false) != 0)
					{
						return true;
					}
					if (he2.x(num4) != A_1.x(num4))
					{
						return true;
					}
					if (he2.y(num4) != A_1.y(num4))
					{
						return true;
					}
				}
				he2 = null;
				return false;
			}
			}
		}
	}

	[SpecialName]
	public static bool s(he A_0, he A_1)
	{
		return !t(A_0, A_1);
	}

	public void ag()
	{
		t(A_0: true);
	}

	public void t(bool A_0)
	{
		m.Clear();
		if (A_0)
		{
			n.Clear();
		}
		o.Clear();
		p.Clear();
		q.Clear();
		r.Clear();
		this.m_s.Clear();
		this.m_t.Clear();
	}

	public void ah()
	{
		o.Add(0);
		p.Add("1");
		q.Add(1);
		r.Add("1");
		this.m_s.Add(he.a.a);
		this.m_t.Add(1.0);
	}

	public void z(int A_0)
	{
		o.RemoveAt(A_0);
		p.RemoveAt(A_0);
		q.RemoveAt(A_0);
		r.RemoveAt(A_0);
		this.m_s.RemoveAt(A_0);
		this.m_t.RemoveAt(A_0);
	}

	public void s(string A_0, string A_1)
	{
		string item = u(A_0);
		j = A_1;
		k = DateTime.Now.ToOADate();
		i = Guid.NewGuid().ToString();
		ag();
		m.Add(item);
		this.m_u = t();
		l = false;
	}

	public void z(string A_0)
	{
		BinaryWriter binaryWriter = new BinaryWriter(File.Open(A_0, FileMode.Create));
		checked
		{
			int num = ab() - 1;
			int num2 = ac() - 1;
			try
			{
				l = true;
				binaryWriter.Write((short)1);
				binaryWriter.Write((short)1);
				binaryWriter.Write(j);
				binaryWriter.Write(k);
				binaryWriter.Write(i);
				binaryWriter.Write(ab());
				int num3 = num;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					binaryWriter.Write(m[num4]);
				}
				binaryWriter.Write(ac());
				int num5 = num2;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					binaryWriter.Write(o[num6]);
				}
				int num7 = num2;
				for (int num6 = 0; num6 <= num7; num6++)
				{
					binaryWriter.Write(p[num6]);
				}
				int num8 = num2;
				for (int num6 = 0; num6 <= num8; num6++)
				{
					binaryWriter.Write(q[num6]);
				}
				int num9 = num2;
				for (int num6 = 0; num6 <= num9; num6++)
				{
					binaryWriter.Write(r[num6]);
				}
				int num10 = num2;
				for (int num6 = 0; num6 <= num10; num6++)
				{
					binaryWriter.Write((short)this.m_s[num6]);
				}
				int num11 = num2;
				for (int num6 = 0; num6 <= num11; num6++)
				{
					binaryWriter.Write(this.m_t[num6]);
				}
			}
			finally
			{
				binaryWriter.Close();
			}
		}
	}

	public void aa(string A_0)
	{
		BinaryReader binaryReader = new BinaryReader(File.Open(A_0, FileMode.Open));
		checked
		{
			try
			{
				binaryReader.ReadInt16();
				short num = binaryReader.ReadInt16();
				j = binaryReader.ReadString();
				k = binaryReader.ReadDouble();
				i = binaryReader.ReadString();
				if (num > 1)
				{
					throw new ApplicationException("Incompatible File Format. A later software version is required to read this file.");
				}
				ag();
				int num2 = binaryReader.ReadInt32();
				for (int num3 = 1; num3 <= num2; num3++)
				{
					string item = binaryReader.ReadString();
					m.Add(item);
				}
				int num4 = binaryReader.ReadInt32();
				int num5 = num4;
				for (int num6 = 1; num6 <= num5; num6++)
				{
					int item2 = binaryReader.ReadInt32();
					o.Add(item2);
				}
				int num7 = num4;
				for (int num6 = 1; num6 <= num7; num6++)
				{
					string item = binaryReader.ReadString();
					p.Add(item);
				}
				int num8 = num4;
				for (int num6 = 1; num6 <= num8; num6++)
				{
					int item2 = binaryReader.ReadInt32();
					q.Add(item2);
				}
				int num9 = num4;
				for (int num6 = 1; num6 <= num9; num6++)
				{
					string item = binaryReader.ReadString();
					r.Add(item);
				}
				int num10 = num4;
				for (int num6 = 1; num6 <= num10; num6++)
				{
					short item3 = binaryReader.ReadInt16();
					this.m_s.Add(unchecked((a)item3));
				}
				int num11 = num4;
				for (int num6 = 1; num6 <= num11; num6++)
				{
					double item4 = binaryReader.ReadDouble();
					this.m_t.Add(item4);
				}
				l = true;
			}
			finally
			{
				binaryReader.Close();
			}
		}
	}

	public bool s(eo A_0, hg.j A_1, r.d.a.b A_2, bool A_3, bool A_4, Point A_5, string A_6, g2.b A_7, bool A_8, fz A_9)
	{
		ad().Clear();
		hg hg2 = null;
		checked
		{
			for (int num = af().Count - 1; num >= 0; num += -1)
			{
				hg2 = new hg(A_0, A_1);
				if (hg2.bu(af()[num], A_1, null, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, null, A_12: true, A_13: false, null, A_15: false))
				{
					ad().Insert(0, hg2);
					continue;
				}
				return false;
			}
			return true;
		}
	}

	public bool s(string A_0, eo A_1, hg A_2, hg.j A_3, r.d A_4, r.d.a.b A_5, bool A_6, bool A_7, Point A_8, string A_9, g2.b A_10, bool A_11, fz A_12)
	{
		if (File.Exists(A_0) && Operators.CompareString(Path.GetExtension(A_0), ".ficrp", TextCompare: false) == 0)
		{
			aa(A_0);
			v(A_0);
			if (s(A_1, A_3, A_5, A_6, A_7, A_8, A_9, A_10, A_11, A_12))
			{
				ad()[0].bu(ref A_2);
				A_2.bv(A_4, A_6);
				return true;
			}
			return false;
		}
		return false;
	}

	public void s(BinaryWriter A_0)
	{
		long position = A_0.BaseStream.Position;
		A_0.Write(position);
		A_0.Write((short)1);
		A_0.Write((short)1);
		t(A_0);
		long position2 = A_0.BaseStream.Position;
		A_0.BaseStream.Seek(position, SeekOrigin.Begin);
		A_0.Write(position2);
		A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
	}

	public void s(BinaryReader A_0)
	{
		int num = 0;
		int num2 = 0;
		long offset = A_0.ReadInt64();
		num2 = A_0.ReadInt16();
		num = A_0.ReadInt16();
		if (num <= 1)
		{
			s(A_0, num2);
			A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
			return;
		}
		throw new au("CompositeMeasResults maximum compatible block file version is " + (short)1 + " compatible version in file we are attempting to read is " + num);
	}

	public void t(BinaryWriter A_0)
	{
		A_0.Write(i);
		A_0.Write(j);
		A_0.Write(k);
		s(m, A_0);
		s(o, A_0);
		s(p, A_0);
		s(q, A_0);
		s(r, A_0);
		s(this.m_s, A_0);
		s(this.m_t, A_0);
		A_0.Write(this.m_u);
	}

	public void s(BinaryReader A_0, int A_1)
	{
		i = A_0.ReadString();
		j = A_0.ReadString();
		k = A_0.ReadDouble();
		s(ref m, A_0);
		s(ref o, A_0);
		s(ref p, A_0);
		s(ref q, A_0);
		s(ref r, A_0);
		s(ref this.m_s, A_0);
		s(ref this.m_t, A_0);
		this.m_u = A_0.ReadString();
		l = false;
	}

	private void s(Collection<string> A_0, BinaryWriter A_1)
	{
		if (A_0 != null && A_0.Count > 0)
		{
			A_1.Write(A_0.Count);
			{
				foreach (string item in A_0)
				{
					A_1.Write(item);
				}
				return;
			}
		}
		A_1.Write(0);
	}

	private void s(ref Collection<string> A_0, BinaryReader A_1)
	{
		int num = A_1.ReadInt32();
		checked
		{
			if (num > 0)
			{
				if (A_0 == null)
				{
					A_0 = new Collection<string>();
				}
				else
				{
					A_0.Clear();
				}
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					A_0.Add(A_1.ReadString());
				}
			}
			else
			{
				A_0 = null;
			}
		}
	}

	private void s(Collection<int> A_0, BinaryWriter A_1)
	{
		if (A_0 != null && A_0.Count > 0)
		{
			A_1.Write(A_0.Count);
			{
				foreach (int item in A_0)
				{
					A_1.Write(item);
				}
				return;
			}
		}
		A_1.Write(0);
	}

	private void s(ref Collection<int> A_0, BinaryReader A_1)
	{
		int num = A_1.ReadInt32();
		checked
		{
			if (num > 0)
			{
				if (A_0 == null)
				{
					A_0 = new Collection<int>();
				}
				else
				{
					A_0.Clear();
				}
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					A_0.Add(A_1.ReadInt32());
				}
			}
			else
			{
				A_0 = null;
			}
		}
	}

	private void s(Collection<a> A_0, BinaryWriter A_1)
	{
		if (A_0 != null && A_0.Count > 0)
		{
			A_1.Write(A_0.Count);
			{
				foreach (a item in A_0)
				{
					A_1.Write(checked((short)item));
				}
				return;
			}
		}
		A_1.Write(0);
	}

	private void s(ref Collection<a> A_0, BinaryReader A_1)
	{
		int num = A_1.ReadInt32();
		if (num > 0)
		{
			if (A_0 == null)
			{
				A_0 = new Collection<a>();
			}
			else
			{
				A_0.Clear();
			}
			int num2 = checked(num - 1);
			for (int num3 = 0; num3 <= num2; num3 = checked(num3 + 1))
			{
				short item = A_1.ReadInt16();
				A_0.Add((a)item);
			}
		}
		else
		{
			A_0 = null;
		}
	}

	private void s(Collection<double> A_0, BinaryWriter A_1)
	{
		if (A_0 != null && A_0.Count > 0)
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

	private void s(ref Collection<double> A_0, BinaryReader A_1)
	{
		int num = A_1.ReadInt32();
		checked
		{
			if (num > 0)
			{
				if (A_0 == null)
				{
					A_0 = new Collection<double>();
				}
				else
				{
					A_0.Clear();
				}
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					A_0.Add(A_1.ReadDouble());
				}
			}
			else
			{
				A_0 = null;
			}
		}
	}

	public static string u(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return A_0;
		}
		return "\\" + i3.d(A_0, hg.bz());
	}

	public static string t(string A_0)
	{
		string text = i3.d(A_0, hg.bz());
		int num = text.LastIndexOf(".");
		if (num >= 0)
		{
			return text.Substring(0, num);
		}
		return text;
	}

	public static string s(string A_0)
	{
		return hg.bz() + A_0;
	}
}
