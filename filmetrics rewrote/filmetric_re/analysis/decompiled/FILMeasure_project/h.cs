using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class h
{
	public class a
	{
		public bool a;

		public string b;

		public float c;

		public float d;

		[SpecialName]
		public static bool f(a A_0, a A_1)
		{
			switch (ix.a(A_0, A_1))
			{
			case ix.a.a:
				return false;
			case ix.a.b:
				return true;
			default:
				if (A_0.d != A_1.d)
				{
					return true;
				}
				if (A_0.a != A_1.a)
				{
					return true;
				}
				if (Operators.CompareString(A_0.b, A_1.b, TextCompare: false) != 0)
				{
					return true;
				}
				if (A_0.c != A_1.c)
				{
					return true;
				}
				return false;
			}
		}

		[SpecialName]
		public static bool e(a A_0, a A_1)
		{
			return !f(A_0, A_1);
		}

		public a(float A_0, string A_1, bool A_2, float A_3)
		{
			d = A_0;
			b = A_1;
			a = A_2;
			c = A_3;
		}

		public void e(a A_0)
		{
			A_0.a = a;
			A_0.b = b;
			A_0.c = c;
			A_0.d = d;
			_ = null;
		}
	}

	public class b : a
	{
		public b(float A_0, bool A_1)
			: base(A_0, null, A_1, 1f)
		{
		}
	}

	public class c
	{
		public string a;

		public List<float> b;

		public int c;

		public List<float> d;

		public List<float> e;

		public c(string A_0, List<float> A_1, int A_2, List<float> A_3, List<float> A_4)
		{
			a = A_0;
			b = A_1;
			c = A_2;
			d = A_3;
			e = A_4;
		}
	}

	internal class d
	{
		public enum a
		{
			a,
			b,
			c
		}

		public bool a;

		private a b;

		public float c;

		public float d;

		public float e;

		public float f;

		public float g;

		[SpecialName]
		public a i(bool A_0)
		{
			if (!A_0 && b == global::h.d.a.c)
			{
				return global::h.d.a.b;
			}
			return b;
		}

		[SpecialName]
		public a i()
		{
			return b;
		}

		[SpecialName]
		public void i(a A_0)
		{
			b = A_0;
		}

		[SpecialName]
		public static bool j(d A_0, d A_1)
		{
			switch (ix.a(A_0, A_1))
			{
			case ix.a.a:
				return false;
			case ix.a.b:
				return true;
			default:
			{
				d d10 = A_0;
				if (d10.a != A_1.a)
				{
					return true;
				}
				if (d10.b != A_1.b)
				{
					return true;
				}
				if (d10.c != A_1.c)
				{
					return true;
				}
				if (d10.d != A_1.d)
				{
					return true;
				}
				if (d10.e != A_1.e)
				{
					return true;
				}
				if (d10.f != A_1.f)
				{
					return true;
				}
				if (d10.g != A_1.g)
				{
					return true;
				}
				d10 = null;
				return false;
			}
			}
		}

		[SpecialName]
		public static bool i(d A_0, d A_1)
		{
			return !j(A_0, A_1);
		}

		public void i(ref d A_0)
		{
			if (A_0 == null)
			{
				A_0 = new d();
			}
			d obj = A_0;
			obj.a = this.a;
			obj.b = b;
			obj.c = c;
			obj.d = d;
			obj.e = e;
			obj.f = f;
			obj.g = g;
			_ = null;
		}

		public void j()
		{
			this.a = false;
			b = global::h.d.a.b;
			c = 0f;
			d = 0f;
			e = 0f;
			f = 100f;
			g = 100f;
		}
	}

	public enum MeasurementTimingType
	{
		Recommended,
		Maximum,
		Manual,
		NumMeasTimings
	}

	public enum e
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g
	}

	public enum f
	{
		a,
		b,
		c
	}

	public enum g
	{
		a,
		b
	}

	public enum h
	{
		a,
		b
	}

	public enum i
	{
		a,
		b
	}

	public const int a = 10;

	public const double b = 60000.0;

	public const double c = 1.0;

	public const int d = 5000;

	public const int e = 1;

	private MeasurementTimingType m_f;

	private double m_g;

	private global::f[] m_h;

	private global::g[] m_i;

	private bool j;

	private e k;

	private bool l;

	private string m;

	private float m_n;

	private int o;

	private int m_p;

	private eo q;

	private bool m_r;

	private List<a> s;

	private List<b> m_t;

	private d u;

	private const string m_v = "ZOffsetCalibrationTest.csv";

	[CompilerGenerated]
	private float w;

	[CompilerGenerated]
	private bool m_x;

	[CompilerGenerated]
	private int y;

	[CompilerGenerated]
	private float z;

	[CompilerGenerated]
	private bool aa;

	[SpecialName]
	public static string b()
	{
		return i3.o() + "\\ZOffsetCalibrationTest.csv";
	}

	[SpecialName]
	public static int a()
	{
		return checked(Enum.GetValues(typeof(f)).Length - 1);
	}

	[SpecialName]
	public d d()
	{
		return u;
	}

	[SpecialName]
	public static bool b(global::h A_0, global::h A_1)
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
				global::h h10 = A_0;
				int num = a();
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (global::f.h(h10.a(num2), A_1.a(num2)))
					{
						return true;
					}
				}
				foreach (object value in Enum.GetValues(typeof(g)))
				{
					g a_ = unchecked((g)Conversions.ToInteger(value));
					if (global::g.d(h10.a(a_), A_1.a(a_)))
					{
						return true;
					}
				}
				if (h10.p() != A_1.p())
				{
					return true;
				}
				if (h10.r() != A_1.r())
				{
					return true;
				}
				if (h10.t() != A_1.t())
				{
					return true;
				}
				if (h10.aq() != A_1.aq())
				{
					return true;
				}
				if (h10.ar() != A_1.ar())
				{
					return true;
				}
				if (h10.at() != A_1.at())
				{
					return true;
				}
				if (Operators.CompareString(h10.@as(), A_1.@as(), TextCompare: false) != 0)
				{
					return true;
				}
				if (h10.m_r != A_1.m_r)
				{
					return true;
				}
				if (h10.aw() != A_1.aw())
				{
					return true;
				}
				if (h10.ax() != A_1.ax())
				{
					return true;
				}
				if (h10.ay() != A_1.ay())
				{
					return true;
				}
				if (h10.az() != A_1.az())
				{
					return true;
				}
				if (h10.a0() != A_1.a0())
				{
					return true;
				}
				List<a> list = h10.a2();
				List<a> list2 = A_1.a2();
				if (list.Count != list2.Count)
				{
					return true;
				}
				int num3 = h10.a2().Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (global::h.a.f(list[num4], list2[num4]))
					{
						return true;
					}
				}
				List<b> list3 = h10.au();
				List<b> list4 = A_1.au();
				if (list3.Count != list4.Count)
				{
					return true;
				}
				int num5 = h10.au().Count - 1;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					if (global::h.a.f(list3[num6], list4[num6]))
					{
						return true;
					}
				}
				if (global::h.d.j(h10.u, A_1.u))
				{
					return true;
				}
				h10 = null;
				return false;
			}
			}
		}
	}

	[SpecialName]
	public static bool a(global::h A_0, global::h A_1)
	{
		return !b(A_0, A_1);
	}

	public bool a(global::h A_0)
	{
		return a(this, A_0);
	}

	[SpecialName]
	public static string a(MeasurementTimingType A_0)
	{
		return A_0 switch
		{
			MeasurementTimingType.Manual => "Manual", 
			MeasurementTimingType.Maximum => "Maximum", 
			MeasurementTimingType.Recommended => "Recommended", 
			_ => "", 
		};
	}

	[SpecialName]
	public bool n()
	{
		return (this.m_f == MeasurementTimingType.Maximum) | (this.m_f == MeasurementTimingType.Recommended);
	}

	[SpecialName]
	public global::f a(int A_0)
	{
		return this.m_h[A_0];
	}

	[SpecialName]
	public global::g a(g A_0)
	{
		return this.m_i[(int)A_0];
	}

	[SpecialName]
	public void a(bool A_0)
	{
		j = A_0;
	}

	[SpecialName]
	public bool p()
	{
		return j;
	}

	[SpecialName]
	public bool a(f A_0, bool[] A_1)
	{
		e e10 = a(A_1);
		bool flag = default(bool);
		return A_0 switch
		{
			global::h.f.a => e10 == global::h.e.a || e10 == global::h.e.f || e10 == global::h.e.e || e10 == global::h.e.b, 
			global::h.f.c => e10 == global::h.e.a || e10 == global::h.e.d || e10 == global::h.e.f || e10 == global::h.e.g, 
			global::h.f.b => e10 == global::h.e.a || e10 == global::h.e.e || e10 == global::h.e.g || e10 == global::h.e.c, 
			_ => flag, 
		};
	}

	[SpecialName]
	public e a(bool[] A_0)
	{
		if (A_0 == null)
		{
			return global::h.e.b;
		}
		switch (k)
		{
		case global::h.e.a:
			if (A_0[0] && A_0[1] && A_0[2])
			{
				return global::h.e.a;
			}
			if (A_0[0] && A_0[1])
			{
				return global::h.e.e;
			}
			if (A_0[1] && A_0[2])
			{
				return global::h.e.g;
			}
			if (A_0[0] && A_0[2])
			{
				return global::h.e.f;
			}
			if (A_0[0])
			{
				return global::h.e.b;
			}
			if (A_0[1])
			{
				return global::h.e.c;
			}
			if (A_0[2])
			{
				return global::h.e.d;
			}
			break;
		case global::h.e.b:
			if (A_0[0])
			{
				return global::h.e.b;
			}
			if (A_0[1])
			{
				return global::h.e.c;
			}
			if (A_0[2])
			{
				return global::h.e.d;
			}
			break;
		case global::h.e.c:
			if (A_0[1])
			{
				return global::h.e.c;
			}
			if (A_0[0])
			{
				return global::h.e.b;
			}
			if (A_0[2])
			{
				return global::h.e.d;
			}
			break;
		case global::h.e.d:
			if (A_0[2])
			{
				return global::h.e.d;
			}
			if (A_0[0])
			{
				return global::h.e.b;
			}
			if (A_0[1])
			{
				return global::h.e.c;
			}
			break;
		case global::h.e.e:
			if (A_0[0] && A_0[1])
			{
				return global::h.e.e;
			}
			if (A_0[0])
			{
				return global::h.e.b;
			}
			if (A_0[1])
			{
				return global::h.e.c;
			}
			if (A_0[2])
			{
				return global::h.e.d;
			}
			break;
		case global::h.e.g:
			if (A_0[1] && A_0[2])
			{
				return global::h.e.g;
			}
			if (A_0[1])
			{
				return global::h.e.c;
			}
			if (A_0[2])
			{
				return global::h.e.d;
			}
			if (A_0[0])
			{
				return global::h.e.b;
			}
			break;
		case global::h.e.f:
			if (A_0[0] && A_0[2])
			{
				return global::h.e.f;
			}
			if (A_0[0])
			{
				return global::h.e.b;
			}
			if (A_0[2])
			{
				return global::h.e.d;
			}
			if (A_0[1])
			{
				return global::h.e.c;
			}
			break;
		}
		throw new ax("Invalid meas type");
	}

	[SpecialName]
	public e r()
	{
		return k;
	}

	[SpecialName]
	public void r(e A_0)
	{
		k = A_0;
	}

	[SpecialName]
	public bool t()
	{
		return l;
	}

	[SpecialName]
	public void b(bool A_0)
	{
		l = A_0;
	}

	[SpecialName]
	public bool v()
	{
		return p(k);
	}

	[SpecialName]
	public static bool p(e A_0)
	{
		if (A_0 != global::h.e.a && A_0 != global::h.e.f && A_0 != global::h.e.e)
		{
			return A_0 == global::h.e.b;
		}
		return true;
	}

	[SpecialName]
	public bool x()
	{
		return n(k);
	}

	[SpecialName]
	public static bool n(e A_0)
	{
		if (A_0 != global::h.e.a && A_0 != global::h.e.e && A_0 != global::h.e.g)
		{
			return A_0 == global::h.e.c;
		}
		return true;
	}

	[SpecialName]
	public bool an()
	{
		return d(k);
	}

	[SpecialName]
	public static bool d(e A_0)
	{
		if (A_0 != global::h.e.a && A_0 != global::h.e.f && A_0 != global::h.e.g)
		{
			return A_0 == global::h.e.d;
		}
		return true;
	}

	[SpecialName]
	public bool ao()
	{
		return b(k);
	}

	[SpecialName]
	public static bool b(e A_0)
	{
		return A_0 != global::h.e.c;
	}

	[SpecialName]
	public g d(bool A_0)
	{
		return a(A_0, k);
	}

	[SpecialName]
	public static g a(bool A_0, e A_1)
	{
		if (A_0 && A_1 == global::h.e.c)
		{
			return global::h.g.b;
		}
		return global::h.g.a;
	}

	[SpecialName]
	public f ap()
	{
		return a(k);
	}

	[SpecialName]
	public static f a(e A_0)
	{
		if (A_0 == global::h.e.c)
		{
			return global::h.f.b;
		}
		if (p(A_0))
		{
			return global::h.f.a;
		}
		if (d(A_0))
		{
			return global::h.f.c;
		}
		return global::h.f.a;
	}

	[SpecialName]
	public MeasurementTimingType n(bool A_0)
	{
		if (A_0)
		{
			return MeasurementTimingType.Manual;
		}
		return this.m_f;
	}

	[SpecialName]
	public MeasurementTimingType aq()
	{
		return this.m_f;
	}

	[SpecialName]
	public void b(MeasurementTimingType A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	public double ar()
	{
		return this.m_g;
	}

	[SpecialName]
	public void a(double A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	public string @as()
	{
		return m;
	}

	[SpecialName]
	public void a(string A_0)
	{
		m = A_0;
	}

	[SpecialName]
	public float at()
	{
		return this.m_n;
	}

	[SpecialName]
	public void a(float A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	public List<b> au()
	{
		return this.m_t;
	}

	[SpecialName]
	public bool av()
	{
		return !this.m_r;
	}

	[SpecialName]
	public bool a(bool A_0, bool A_1)
	{
		if (A_0)
		{
			if (!this.m_r)
			{
				return A_1;
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	public void a(bool A_0, bool A_1, bool A_2)
	{
		this.m_r = A_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public float aw()
	{
		return w;
	}

	[SpecialName]
	[CompilerGenerated]
	public void b(float A_0)
	{
		w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool ax()
	{
		return this.m_x;
	}

	[SpecialName]
	[CompilerGenerated]
	public void p(bool A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public int ay()
	{
		return y;
	}

	[SpecialName]
	[CompilerGenerated]
	public void b(int A_0)
	{
		y = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public float az()
	{
		return z;
	}

	[SpecialName]
	[CompilerGenerated]
	public void d(float A_0)
	{
		z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool a0()
	{
		return aa;
	}

	[SpecialName]
	[CompilerGenerated]
	public void r(bool A_0)
	{
		aa = A_0;
	}

	public double a(bool A_0, int A_1)
	{
		if (A_0)
		{
			return ar();
		}
		return ar() / (double)A_1;
	}

	public static string b(f A_0)
	{
		return A_0 switch
		{
			global::h.f.a => "R", 
			global::h.f.b => "T", 
			global::h.f.c => "R70", 
			_ => throw new ax("Invalid meas type"), 
		};
	}

	public static string a(f A_0)
	{
		return A_0 switch
		{
			global::h.f.a => "Reflectance Only", 
			global::h.f.b => "Transmittance Only", 
			global::h.f.c => "Reflectance Only", 
			_ => throw new ax("Invalid meas type"), 
		};
	}

	public void a(ref global::h A_0)
	{
		global::h h10 = A_0;
		int num = o;
		for (int num2 = 0; num2 <= num; num2 = checked(num2 + 1))
		{
			global::f obj = this.m_h[num2];
			global::f A_1 = h10.a(num2);
			obj.b(ref A_1);
		}
		int num3 = this.m_p;
		for (int num4 = 0; num4 <= num3; num4 = checked(num4 + 1))
		{
			global::g obj2 = this.m_i[num4];
			global::g A_2 = h10.a((g)num4);
			obj2.c(ref A_2);
		}
		h10.a(j);
		h10.b(this.m_f);
		h10.r(k);
		h10.b(l);
		h10.a(this.m_g);
		h10.a(this.m_n);
		h10.a(m);
		h10.m_r = this.m_r;
		h10.b(aw());
		h10.p(ax());
		h10.b(ay());
		h10.d(az());
		h10.r(a0());
		List<a> list = new List<a>();
		foreach (a item in s)
		{
			list.Add(new a(item.d, item.b, item.a, item.c));
		}
		h10.s = list;
		List<b> list2 = new List<b>();
		foreach (b item2 in this.m_t)
		{
			list2.Add(new b(item2.d, item2.a));
		}
		h10.m_t = list2;
		u.i(ref h10.u);
		h10 = null;
	}

	public void a1()
	{
		int num = o;
		checked
		{
			for (int num2 = 0; num2 <= num; num2++)
			{
				this.m_h[num2].i();
			}
			int num3 = this.m_p;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				this.m_i[num4].e();
			}
			this.m_f = MeasurementTimingType.Recommended;
			k = global::h.e.a;
			l = false;
			this.m_g = 40.0;
			this.m_n = 0f;
			m = "";
			b(1f);
			p(A_0: false);
			b(1);
			d(600f);
			s.Clear();
			this.m_r = false;
			List<b> list = this.m_t;
			list.Clear();
			list.Add(new b(400f, A_1: true));
			list.Add(new b(600f, A_1: true));
			list.Add(new b(800f, A_1: true));
			_ = null;
			j = false;
			u.j();
		}
	}

	public h(eo A_0)
	{
		s = new List<a>();
		this.m_t = new List<b>();
		q = A_0;
		checked
		{
			o = Enum.GetValues(typeof(f)).Length - 1;
			this.m_p = Enum.GetValues(typeof(g)).Length - 1;
			this.m_h = new global::f[o + 1];
			this.m_i = new global::g[this.m_p + 1];
			int num = o;
			for (int num2 = 0; num2 <= num; num2++)
			{
				this.m_h[num2] = new global::f();
			}
			int num3 = this.m_p;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				this.m_i[num4] = new global::g();
			}
			u = new d();
			a1();
		}
	}

	~h()
	{
		base.Finalize();
	}

	[SpecialName]
	public List<a> a2()
	{
		return s;
	}

	[SpecialName]
	public List<a> b(string A_0)
	{
		List<a> list = new List<a>();
		foreach (a item in s)
		{
			if (Operators.CompareString(item.b, A_0, TextCompare: false) == 0)
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void a(List<c> A_0, ref bool A_1)
	{
		List<a> list = new List<a>();
		new List<a>();
		A_1 = false;
		foreach (c item in A_0)
		{
			List<a> list2 = b(item.a);
			while (list2.Count > item.c)
			{
				A_1 = true;
				list2.RemoveAt(checked(list2.Count - 1));
			}
			while (list2.Count < item.c)
			{
				A_1 = true;
				list2.Add(new a(item.b[list2.Count], item.a, A_2: true, item.d[list2.Count]));
			}
			list.AddRange(list2);
		}
		s = list;
	}
}
