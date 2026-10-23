using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class hi
{
	public enum a
	{
		a = 1,
		b,
		c,
		d,
		e,
		f
	}

	public enum b
	{
		a,
		b
	}

	public enum c
	{
		a,
		b,
		c,
		d
	}

	public enum d
	{
		a,
		b,
		c,
		d,
		e
	}

	public enum e
	{
		a,
		b,
		c
	}

	public class f
	{
		[CompilerGenerated]
		private bool m_a;

		[CompilerGenerated]
		private bool b;

		[CompilerGenerated]
		private float c;

		[CompilerGenerated]
		private float d;

		[CompilerGenerated]
		private bool e;

		[CompilerGenerated]
		private float m_f;

		[CompilerGenerated]
		private float g;

		[CompilerGenerated]
		private bool m_h;

		[CompilerGenerated]
		private float i;

		[CompilerGenerated]
		private bool j;

		public f()
		{
			h(A_0: false);
			o(A_0: false);
			a(90f);
			h(90f);
			p(A_0: false);
			o(200f);
			p(1600f);
			a(A_0: false);
			q(50f);
			q(A_0: false);
		}

		[SpecialName]
		[CompilerGenerated]
		private bool h()
		{
			return this.m_a;
		}

		[SpecialName]
		[CompilerGenerated]
		private void h(bool A_0)
		{
			this.m_a = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public bool o()
		{
			return b;
		}

		[SpecialName]
		[CompilerGenerated]
		public void o(bool A_0)
		{
			b = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public float p()
		{
			return c;
		}

		[SpecialName]
		[CompilerGenerated]
		public void a(float A_0)
		{
			c = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public float q()
		{
			return d;
		}

		[SpecialName]
		[CompilerGenerated]
		public void h(float A_0)
		{
			d = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public bool r()
		{
			return e;
		}

		[SpecialName]
		[CompilerGenerated]
		public void p(bool A_0)
		{
			e = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public float s()
		{
			return m_f;
		}

		[SpecialName]
		[CompilerGenerated]
		public void o(float A_0)
		{
			m_f = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public float t()
		{
			return g;
		}

		[SpecialName]
		[CompilerGenerated]
		public void p(float A_0)
		{
			g = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		private bool a()
		{
			return this.m_h;
		}

		[SpecialName]
		[CompilerGenerated]
		private void a(bool A_0)
		{
			this.m_h = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public float u()
		{
			return i;
		}

		[SpecialName]
		[CompilerGenerated]
		public void q(float A_0)
		{
			i = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public bool v()
		{
			return j;
		}

		[SpecialName]
		[CompilerGenerated]
		public void q(bool A_0)
		{
			j = A_0;
		}

		public bool w()
		{
			return h(this, new f());
		}

		[SpecialName]
		public bool x()
		{
			return h();
		}

		[SpecialName]
		public void r(bool A_0)
		{
			h(A_0);
		}

		[SpecialName]
		public bool a(eo A_0, eo.a A_1)
		{
			if (h())
			{
				return A_0.a5(A_1);
			}
			return false;
		}

		[SpecialName]
		public bool y()
		{
			return a();
		}

		[SpecialName]
		public void s(bool A_0)
		{
			a(A_0);
		}

		[SpecialName]
		public bool h(eo A_0, eo.a A_1)
		{
			if (a())
			{
				return A_0.a5(A_1);
			}
			return false;
		}

		public void a(ref f A_0)
		{
			if (A_0 == null)
			{
				A_0 = new f();
			}
			f obj = A_0;
			obj.r(x());
			obj.h(q());
			obj.a(p());
			obj.p(r());
			obj.o(o());
			obj.o(s());
			obj.p(t());
			obj.s(y());
			obj.q(u());
			obj.q(v());
			_ = null;
		}

		[SpecialName]
		public static bool h(f A_0, f A_1)
		{
			switch (ix.a(A_0, A_1))
			{
			case ix.a.a:
				return false;
			case ix.a.b:
				return true;
			default:
			{
				f f10 = A_0;
				if (f10.x() != A_1.x())
				{
					return true;
				}
				if (f10.o() != A_1.o())
				{
					return true;
				}
				if (f10.p() != A_1.p())
				{
					return true;
				}
				if (f10.q() != A_1.q())
				{
					return true;
				}
				if (f10.r() != A_1.r())
				{
					return true;
				}
				if (f10.s() != A_1.s())
				{
					return true;
				}
				if (f10.t() != A_1.t())
				{
					return true;
				}
				if (f10.y() != A_1.y())
				{
					return true;
				}
				if (f10.u() != A_1.u())
				{
					return true;
				}
				if (f10.v() != A_1.v())
				{
					return true;
				}
				f10 = null;
				return false;
			}
			}
		}

		[SpecialName]
		public static bool a(f A_0, f A_1)
		{
			return h(A_0, A_1);
		}
	}

	public const string a = "Medium";

	public const string b = "Substrate";

	public const string c = "Rectangular";

	public const string d = "Polar";

	public const string e = "Linear";

	public const string f = "Die";

	public const string g = "Custom";

	private const float h = -100f;

	private const float i = 100f;

	public const int j = 102;

	public const int k = 100;

	public const int l = 3;

	public const int m = 2;

	private fz n;

	private Collection o;

	private eo p;

	private double q;

	private double r;

	private bool s;

	private bool t;

	private double u;

	private bool v;

	private bool w;

	private double x;

	private Collection<bool> y;

	private Collection<bool> z;

	private double aa;

	private bool ab;

	private string ac;

	private bool ad;

	private bool ae;

	private bool af;

	private bool ag;

	private bool ah;

	private double ai;

	private double aj;

	private int ak;

	private double al;

	private bool am;

	private bool an;

	private double ao;

	private double ap;

	private float aq;

	private bool ar;

	private bool @as;

	private double at;

	private double m_au;

	private const float av = 2000f;

	private float aw;

	private const float ax = 1f;

	private short ay;

	private double az;

	private double a0;

	private double a1;

	private bool a2;

	private int a3;

	private bool a4;

	private int a5;

	private float a6;

	private float a7;

	private bool a8;

	private bool a9;

	private double ba;

	private float bb;

	private string bc;

	private int bd;

	private float be;

	private int bf;

	private double bg;

	private double bh;

	private bool bi;

	private bool bj;

	private double bk;

	private short bl;

	private bool bm;

	private bool bn;

	private bool bo;

	private bool bp;

	private bool bq;

	public gb br;

	private bool bs;

	private bool bt;

	private short[] bu;

	private short[] bv;

	private bool bw;

	private bool bx;

	public const int by = 12;

	private string bz;

	private int b0;

	private double[] b1;

	private double[] b2;

	private double[] b3;

	private double[] b4;

	private bool[] b5;

	private e[] b6;

	private bool b7;

	private bool b8;

	private bool b9;

	private bool ca;

	private bool cb;

	public const int cc = 6;

	private bool cd;

	private string ce;

	private int cf;

	private double[] cg;

	private double[] ch;

	private double[] ci;

	private double[] cj;

	private b[] ck;

	private bool[] cl;

	private bool[] cm;

	private e[] cn;

	private bool[] co;

	public Collection cp;

	public bool cq;

	public Collection<Guid> cr;

	public Collection<gd> cs;

	public const float ct = 632.8f;

	[CompilerGenerated]
	private a4.a cu;

	[CompilerGenerated]
	private bool cv;

	private float cw;

	private float cx;

	private float cy;

	private float cz;

	private float c0;

	private float c1;

	private List<hj> c2;

	public bool c3;

	private const bool c4 = false;

	private const d c5 = global::hi.d.a;

	public float c6;

	private const float c7 = 50f;

	private d c8;

	public f c9;

	[SpecialName]
	[CompilerGenerated]
	public a4.a d7()
	{
		return cu;
	}

	[SpecialName]
	[CompilerGenerated]
	public void au(a4.a A_0)
	{
		cu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool d8()
	{
		return cv;
	}

	[SpecialName]
	[CompilerGenerated]
	public void au(bool A_0)
	{
		cv = A_0;
	}

	[SpecialName]
	public bool d9()
	{
		return c9.x();
	}

	[SpecialName]
	public void d5(bool A_0)
	{
		c9.r(A_0);
	}

	[SpecialName]
	public bool au(eo A_0, eo.a A_1)
	{
		return c9.a(A_0, A_1);
	}

	[SpecialName]
	public bool ea()
	{
		return c9.o();
	}

	[SpecialName]
	public void d6(bool A_0)
	{
		c9.o(A_0);
	}

	[SpecialName]
	public float eb()
	{
		return c9.p();
	}

	[SpecialName]
	public void au(float A_0)
	{
		c9.a(A_0);
	}

	[SpecialName]
	public float ec()
	{
		return c9.q();
	}

	[SpecialName]
	public void d5(float A_0)
	{
		c9.h(A_0);
	}

	[SpecialName]
	public bool ed()
	{
		return c9.r();
	}

	[SpecialName]
	public void d7(bool A_0)
	{
		c9.p(A_0);
	}

	[SpecialName]
	public float ee()
	{
		return c9.s();
	}

	[SpecialName]
	public void d6(float A_0)
	{
		c9.o(A_0);
	}

	[SpecialName]
	public float ef()
	{
		return c9.t();
	}

	[SpecialName]
	public void d7(float A_0)
	{
		c9.p(A_0);
	}

	[SpecialName]
	public bool eg()
	{
		return c9.y();
	}

	[SpecialName]
	public void d8(bool A_0)
	{
		c9.s(A_0);
	}

	[SpecialName]
	public bool d5(eo A_0, eo.a A_1)
	{
		return c9.h(A_0, A_1);
	}

	[SpecialName]
	public float eh()
	{
		return c9.u();
	}

	[SpecialName]
	public void d8(float A_0)
	{
		c9.q(A_0);
	}

	[SpecialName]
	public bool ei()
	{
		return c9.v();
	}

	[SpecialName]
	public void d9(bool A_0)
	{
		c9.q(A_0);
	}

	[SpecialName]
	public bool ej()
	{
		if (!c3)
		{
			return !jf.e(c6, 50f);
		}
		return true;
	}

	[SpecialName]
	public bool ek()
	{
		return g1() != global::hi.d.a;
	}

	public bool d5(a4.a A_0)
	{
		if (A_0 == d7())
		{
			return d8();
		}
		return false;
	}

	[SpecialName]
	public static bool d5(hi A_0, hi A_1)
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
				hi hi2 = A_0;
				if (hi2.gu() != A_1.gu())
				{
					return true;
				}
				if (hi2.gv() != A_1.gv())
				{
					return true;
				}
				if (hi2.g5() != A_1.g5())
				{
					return true;
				}
				if (hi2.f8() != A_1.f8())
				{
					return true;
				}
				if (hi2.fh() != A_1.fh())
				{
					return true;
				}
				if (hi2.hd() != A_1.hd())
				{
					return true;
				}
				if (hi2.fi() != A_1.fi())
				{
					return true;
				}
				if (global::gb.f(hi2.br, A_1.br))
				{
					return true;
				}
				if (hi2.fl() != A_1.fl())
				{
					return true;
				}
				if (hi2.fm() != A_1.fm())
				{
					return true;
				}
				if (hi2.fn() != A_1.fn())
				{
					return true;
				}
				if (hi2.fo() != A_1.fo())
				{
					return true;
				}
				if (hi2.f0() != A_1.f0())
				{
					return true;
				}
				if (hi2.fz() != A_1.fz())
				{
					return true;
				}
				if (hi2.f5() != A_1.f5())
				{
					return true;
				}
				if (hi2.fu() != A_1.fu())
				{
					return true;
				}
				if (hi2.ha() != A_1.ha())
				{
					return true;
				}
				if (hi2.g9() != A_1.g9())
				{
					return true;
				}
				if (hi2.fr() != A_1.fr())
				{
					return true;
				}
				if (hi2.g4() != A_1.g4())
				{
					return true;
				}
				if (hi2.gq() != A_1.gq())
				{
					return true;
				}
				if (hi2.gr() != A_1.gr())
				{
					return true;
				}
				if (hi2.hb() != A_1.hb())
				{
					return true;
				}
				if (hi2.he() != A_1.he())
				{
					return true;
				}
				if (hi2.hf() != A_1.hf())
				{
					return true;
				}
				if (hi2.fq() != A_1.fq())
				{
					return true;
				}
				if (hi2.fp() != A_1.fp())
				{
					return true;
				}
				if (Operators.CompareString(hi2.g8(), A_1.g8(), TextCompare: false) != 0)
				{
					return true;
				}
				if (hi2.go() != A_1.go())
				{
					return true;
				}
				if (hi2.gp() != A_1.gp())
				{
					return true;
				}
				if (hi2.f4() != A_1.f4())
				{
					return true;
				}
				if (hi2.f2() != A_1.f2())
				{
					return true;
				}
				if (hi2.f3() != A_1.f3())
				{
					return true;
				}
				if (hi2.f1() != A_1.f1())
				{
					return true;
				}
				if (hi2.f6() != A_1.f6())
				{
					return true;
				}
				if (hi2.g6() != A_1.g6())
				{
					return true;
				}
				int num = hi2.g6() + 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (global::gc.ag(hi2.et(num2), A_1.et(num2)))
					{
						return true;
					}
				}
				int num3 = hi2.gm() - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (hi2.eq(num4) != A_1.eq(num4))
					{
						return true;
					}
					if (hi2.ep(num4) != A_1.ep(num4))
					{
						return true;
					}
				}
				if (Operators.CompareString(hi2.f9(), A_1.f9(), TextCompare: false) != 0)
				{
					return true;
				}
				if (hi2.ft() != A_1.ft())
				{
					return true;
				}
				if (hi2.ga() != A_1.ga())
				{
					return true;
				}
				if (hi2.gs() != A_1.gs())
				{
					return true;
				}
				if (hi2.cd != A_1.cd)
				{
					return true;
				}
				if (Operators.CompareString(hi2.ew(), A_1.ew(), TextCompare: false) != 0)
				{
					return true;
				}
				if (hi2.ex() != A_1.ex())
				{
					return true;
				}
				if (hi2.ey() != A_1.ey())
				{
					return true;
				}
				if (hi2.ez() != A_1.ez())
				{
					return true;
				}
				if (hi2.e0() != A_1.e0())
				{
					return true;
				}
				if (hi2.e1() != A_1.e1())
				{
					return true;
				}
				if (Operators.CompareString(hi2.e2(), A_1.e2(), TextCompare: false) != 0)
				{
					return true;
				}
				if (hi2.e3() != A_1.e3())
				{
					return true;
				}
				if (hi2.e3() > 0)
				{
					int num5 = hi2.e3() - 1;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						if (hi2.d9(num6) != A_1.d9(num6))
						{
							return true;
						}
						if (hi2.d5(num6) != A_1.d5(num6))
						{
							return true;
						}
						if (hi2.d6(num6) != A_1.d6(num6))
						{
							return true;
						}
						if (hi2.d7(num6) != A_1.d7(num6))
						{
							return true;
						}
						if (hi2.d8(num6) != A_1.d8(num6))
						{
							return true;
						}
						if (hi2.ea(num6) != A_1.ea(num6))
						{
							return true;
						}
					}
				}
				if (hi2.e9() != A_1.e9())
				{
					return true;
				}
				if (hi2.e9() > 0)
				{
					int num7 = hi2.e9() - 1;
					for (int num8 = 0; num8 <= num7; num8++)
					{
						if (hi2.ec(num8) != A_1.ec(num8))
						{
							return true;
						}
						if (hi2.ed(num8) != A_1.ed(num8))
						{
							return true;
						}
						if (hi2.ee(num8) != A_1.ee(num8))
						{
							return true;
						}
						if (hi2.ef(num8) != A_1.ef(num8))
						{
							return true;
						}
						if (hi2.eg(num8) != A_1.eg(num8))
						{
							return true;
						}
						if (hi2.eh(num8) != A_1.eh(num8))
						{
							return true;
						}
						if (hi2.ei(num8) != A_1.ei(num8))
						{
							return true;
						}
						if (hi2.ej(num8) != A_1.ej(num8))
						{
							return true;
						}
						if (hi2.el(num8) != A_1.el(num8))
						{
							return true;
						}
					}
				}
				if (hi2.gt() != A_1.gt())
				{
					return true;
				}
				if (hi2.fs() != A_1.fs())
				{
					return true;
				}
				if (hi2.hc() != A_1.hc())
				{
					return true;
				}
				if (hi2.f7() != A_1.f7())
				{
					return true;
				}
				if (hi2.hg() != A_1.hg())
				{
					return true;
				}
				if (hi2.gy() != A_1.gy())
				{
					return true;
				}
				if (hi2.gw() != A_1.gw())
				{
					return true;
				}
				if (hi2.gx() != A_1.gx())
				{
					return true;
				}
				if (hi2.gz() != A_1.gz())
				{
					return true;
				}
				if (hi2.fv() != A_1.fv())
				{
					return true;
				}
				if (hi2.fw() != A_1.fw())
				{
					return true;
				}
				if (hi2.fx() != A_1.fx())
				{
					return true;
				}
				if (hi2.fy() != A_1.fy())
				{
					return true;
				}
				if (hi2.g2() != A_1.g2())
				{
					return true;
				}
				if (hi2.ay != A_1.ay)
				{
					return true;
				}
				if (hi2.az != A_1.az)
				{
					return true;
				}
				if (hi2.a0 != A_1.a0)
				{
					return true;
				}
				if (hi2.a1 != A_1.a1)
				{
					return true;
				}
				if (hi2.d7() != A_1.d7())
				{
					return true;
				}
				if (hi2.d8() != A_1.d8())
				{
					return true;
				}
				if (hi2.cw != A_1.cw)
				{
					return true;
				}
				if (hi2.cx != A_1.cx)
				{
					return true;
				}
				if (hi2.cy != A_1.cy)
				{
					return true;
				}
				if (hi2.cz != A_1.cz)
				{
					return true;
				}
				if (hi2.c0 != A_1.c0)
				{
					return true;
				}
				if (hi2.c1 != A_1.c1)
				{
					return true;
				}
				if (hi2.bg != A_1.bg)
				{
					return true;
				}
				if (hi2.bh != A_1.bh)
				{
					return true;
				}
				if (hi2.bi != A_1.bi)
				{
					return true;
				}
				if (hi2.bj != A_1.bj)
				{
					return true;
				}
				if (hi2.bk != A_1.bk)
				{
					return true;
				}
				if (hi2.bl != A_1.bl)
				{
					return true;
				}
				if (hi2.bm != A_1.bm)
				{
					return true;
				}
				if (hi2.es().Count != A_1.es().Count)
				{
					return true;
				}
				int num9 = hi2.es().Count - 1;
				for (int num10 = 0; num10 <= num9; num10++)
				{
					if (global::hj.e(hi2.es()[num10], A_1.es()[num10]))
					{
						return true;
					}
				}
				if (global::hi.f.h(hi2.c9, A_1.c9))
				{
					return true;
				}
				if (hi2.c3 != A_1.c3)
				{
					return true;
				}
				if (hi2.c6 != A_1.c6)
				{
					return true;
				}
				if (hi2.g1() != A_1.g1())
				{
					return true;
				}
				hi2 = null;
				return false;
			}
			}
		}
	}

	[SpecialName]
	public static bool au(hi A_0, hi A_1)
	{
		return !d5(A_0, A_1);
	}

	public bool au(hi A_0)
	{
		return au(this, A_0);
	}

	[SpecialName]
	public Collection el()
	{
		return o;
	}

	[SpecialName]
	public float em()
	{
		return cw;
	}

	[SpecialName]
	public void d9(float A_0)
	{
		cw = A_0;
	}

	[SpecialName]
	public float en()
	{
		return cx;
	}

	[SpecialName]
	public void ea(float A_0)
	{
		cx = A_0;
	}

	[SpecialName]
	public float eo()
	{
		return cy;
	}

	[SpecialName]
	public void eb(float A_0)
	{
		cy = A_0;
	}

	[SpecialName]
	public float ep()
	{
		return cz;
	}

	[SpecialName]
	public void ec(float A_0)
	{
		cz = A_0;
	}

	[SpecialName]
	public float eq()
	{
		return c0;
	}

	[SpecialName]
	public void ed(float A_0)
	{
		c0 = A_0;
	}

	[SpecialName]
	public float er()
	{
		return c1;
	}

	[SpecialName]
	public void ee(float A_0)
	{
		c1 = A_0;
	}

	[SpecialName]
	public List<hj> es()
	{
		return c2;
	}

	[SpecialName]
	public bool et()
	{
		checked
		{
			if (c2 != null && c2.Count > 0)
			{
				int num = c2.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (c2[num2].f() != global::hj.a.a && c2[num2].g())
					{
						return true;
					}
				}
				return false;
			}
			return false;
		}
	}

	[SpecialName]
	public bool eu()
	{
		return cd;
	}

	[SpecialName]
	public bool au(eo.a A_0)
	{
		if (cd)
		{
			return p.a2(A_0);
		}
		return false;
	}

	[SpecialName]
	public bool ev()
	{
		return cd;
	}

	[SpecialName]
	public void ea(bool A_0)
	{
		cd = A_0;
	}

	[SpecialName]
	public string ew()
	{
		return ce;
	}

	[SpecialName]
	public void d6(string A_0)
	{
		ce = A_0;
	}

	[SpecialName]
	public bool ex()
	{
		return b7;
	}

	[SpecialName]
	public void eb(bool A_0)
	{
		b7 = A_0;
	}

	[SpecialName]
	public bool ey()
	{
		return b8;
	}

	[SpecialName]
	public void ec(bool A_0)
	{
		b8 = A_0;
	}

	[SpecialName]
	public bool ez()
	{
		return b9;
	}

	[SpecialName]
	public void ed(bool A_0)
	{
		b9 = A_0;
	}

	[SpecialName]
	public bool e0()
	{
		return ca;
	}

	[SpecialName]
	public void ee(bool A_0)
	{
		ca = A_0;
	}

	[SpecialName]
	public bool e1()
	{
		return cb;
	}

	[SpecialName]
	public void ef(bool A_0)
	{
		cb = A_0;
	}

	[SpecialName]
	public string e2()
	{
		return bz;
	}

	[SpecialName]
	public void d7(string A_0)
	{
		bz = A_0;
	}

	[SpecialName]
	public int e3()
	{
		return b0;
	}

	[SpecialName]
	public void au(int A_0)
	{
		b0 = A_0;
	}

	[SpecialName]
	public double d5(int A_0)
	{
		return b1[A_0];
	}

	[SpecialName]
	public void au(int A_0, double A_1)
	{
		b1[A_0] = A_1;
	}

	[SpecialName]
	public double[] e4()
	{
		return b1;
	}

	[SpecialName]
	public double d6(int A_0)
	{
		return b2[A_0];
	}

	[SpecialName]
	public void d5(int A_0, double A_1)
	{
		b2[A_0] = A_1;
	}

	[SpecialName]
	public double[] e5()
	{
		return b2;
	}

	[SpecialName]
	public double d7(int A_0)
	{
		return b3[A_0];
	}

	[SpecialName]
	public void d6(int A_0, double A_1)
	{
		b3[A_0] = A_1;
	}

	[SpecialName]
	public double[] e6()
	{
		return b3;
	}

	[SpecialName]
	public double d8(int A_0)
	{
		return b4[A_0];
	}

	[SpecialName]
	public void d7(int A_0, double A_1)
	{
		b4[A_0] = A_1;
	}

	[SpecialName]
	public double[] e7()
	{
		return b4;
	}

	[SpecialName]
	public bool d9(int A_0)
	{
		return b5[A_0];
	}

	[SpecialName]
	public void au(int A_0, bool A_1)
	{
		b5[A_0] = A_1;
	}

	[SpecialName]
	public e ea(int A_0)
	{
		return b6[A_0];
	}

	[SpecialName]
	public void au(int A_0, e A_1)
	{
		b6[A_0] = A_1;
	}

	[SpecialName]
	private static bool au(bool[] A_0, e[] A_1, int A_2, g2.a A_3, bool A_4, bool A_5, bool A_6)
	{
		if (A_0[A_2])
		{
			if ((A_3 == global::g2.a.c || A_3 == global::g2.a.b || !A_6) && (!A_6 || ((!A_4 || A_1[A_2] != global::hi.e.a) && (A_4 || A_1[A_2] != global::hi.e.b) && (A_1[A_2] != global::hi.e.c || !A_5))))
			{
				if (A_5 && !A_6)
				{
					return A_1[A_2] == global::hi.e.b;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	public bool au(int A_0, g2.a A_1, bool A_2, bool A_3)
	{
		if (!au(A_0, A_1, A_2, A_3, A_4: false))
		{
			return au(A_0, A_1, A_2, A_3, A_4: true);
		}
		return true;
	}

	[SpecialName]
	public bool au(int A_0, g2.a A_1, bool A_2, bool A_3, bool A_4)
	{
		return au(b5, b6, A_0, A_1, A_2, A_3, A_4);
	}

	[SpecialName]
	public bool[] au(g2.a A_0, bool A_1, bool A_2, bool A_3)
	{
		bool[] array = new bool[12];
		int num = 0;
		do
		{
			array[num] = au(num, A_0, A_1, A_2, A_3);
			num = checked(num + 1);
		}
		while (num <= 11);
		return array;
	}

	[SpecialName]
	public e[] e8()
	{
		return b6;
	}

	[SpecialName]
	public int e9()
	{
		return cf;
	}

	[SpecialName]
	public void eb(int A_0)
	{
		cf = A_0;
	}

	[SpecialName]
	public double ec(int A_0)
	{
		return cg[A_0];
	}

	[SpecialName]
	public void d8(int A_0, double A_1)
	{
		cg[A_0] = A_1;
	}

	[SpecialName]
	public double[] fa()
	{
		return cg;
	}

	[SpecialName]
	public double ed(int A_0)
	{
		return ch[A_0];
	}

	[SpecialName]
	public void d9(int A_0, double A_1)
	{
		ch[A_0] = A_1;
	}

	[SpecialName]
	public double[] fb()
	{
		return ch;
	}

	[SpecialName]
	public double ee(int A_0)
	{
		return ci[A_0];
	}

	[SpecialName]
	public void ea(int A_0, double A_1)
	{
		ci[A_0] = A_1;
	}

	[SpecialName]
	public double[] fc()
	{
		return ci;
	}

	[SpecialName]
	public double ef(int A_0)
	{
		return cj[A_0];
	}

	[SpecialName]
	public void eb(int A_0, double A_1)
	{
		cj[A_0] = A_1;
	}

	[SpecialName]
	public double[] fd()
	{
		return cj;
	}

	[SpecialName]
	public b eg(int A_0)
	{
		return ck[A_0];
	}

	[SpecialName]
	public void au(int A_0, b A_1)
	{
		ck[A_0] = A_1;
	}

	[SpecialName]
	public bool au(int A_0, g2.a A_1)
	{
		if (cl[A_0])
		{
			if (A_1 != global::g2.a.c)
			{
				return A_1 != global::g2.a.b;
			}
			return false;
		}
		return false;
	}

	[SpecialName]
	public bool eh(int A_0)
	{
		return cl[A_0];
	}

	[SpecialName]
	public void d5(int A_0, bool A_1)
	{
		cl[A_0] = A_1;
	}

	[SpecialName]
	public bool ei(int A_0)
	{
		return cm[A_0];
	}

	[SpecialName]
	public void d6(int A_0, bool A_1)
	{
		cm[A_0] = A_1;
	}

	[SpecialName]
	public e ej(int A_0)
	{
		return cn[A_0];
	}

	[SpecialName]
	public void d5(int A_0, e A_1)
	{
		cn[A_0] = A_1;
	}

	[SpecialName]
	public bool d5(int A_0, g2.a A_1, bool A_2, bool A_3)
	{
		if (!d5(A_0, A_1, A_2, A_3, A_4: false))
		{
			return d5(A_0, A_1, A_2, A_3, A_4: true);
		}
		return true;
	}

	[SpecialName]
	public bool d5(int A_0, g2.a A_1, bool A_2, bool A_3, bool A_4)
	{
		return au(cm, cn, A_0, A_1, A_2, A_3, A_4);
	}

	[SpecialName]
	public bool[] d5(g2.a A_0, bool A_1, bool A_2, bool A_3)
	{
		bool[] array = new bool[6];
		int num = 0;
		do
		{
			array[num] = d5(num, A_0, A_1, A_2, A_3);
			num = checked(num + 1);
		}
		while (num <= 5);
		return array;
	}

	[SpecialName]
	public e[] fe()
	{
		return cn;
	}

	[SpecialName]
	public bool ff()
	{
		bool result = false;
		checked
		{
			int num = cf - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (cm[num2])
				{
					result = true;
					break;
				}
			}
			return result;
		}
	}

	[SpecialName]
	public bool fg()
	{
		bool result = false;
		checked
		{
			int num = cf - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (cm[num2] & cl[num2])
				{
					result = true;
					break;
				}
			}
			return result;
		}
	}

	[SpecialName]
	public int fh()
	{
		return bd;
	}

	[SpecialName]
	public void ek(int A_0)
	{
		if ((A_0 >= 0) & (A_0 <= 5))
		{
			bd = A_0;
		}
	}

	[SpecialName]
	public bool fi()
	{
		return bt;
	}

	[SpecialName]
	public void eg(bool A_0)
	{
		bt = A_0;
	}

	[SpecialName]
	public string fj()
	{
		return "Use Global Corr";
	}

	[SpecialName]
	public string fk()
	{
		string result = "";
		switch (bd)
		{
		case 3:
			result = "Linear";
			break;
		case 1:
			result = "Rectangular";
			break;
		case 2:
			result = "Polar";
			break;
		case 4:
			result = "Die";
			break;
		case 5:
			result = "Custom";
			break;
		}
		return result;
	}

	[SpecialName]
	public void d8(string A_0)
	{
		switch (A_0)
		{
		case "Linear":
			bd = 3;
			break;
		case "Rectangular":
			bd = 1;
			break;
		case "Polar":
			bd = 2;
			break;
		case "Die":
			bd = 4;
			break;
		case "Custom":
			bd = 5;
			break;
		default:
			bd = 5;
			break;
		}
	}

	[SpecialName]
	public bool fl()
	{
		return bn;
	}

	[SpecialName]
	public void eh(bool A_0)
	{
		bn = A_0;
	}

	[SpecialName]
	public bool fm()
	{
		return bo;
	}

	[SpecialName]
	public void ei(bool A_0)
	{
		bo = A_0;
	}

	[SpecialName]
	public bool fn()
	{
		return bp;
	}

	[SpecialName]
	public void ej(bool A_0)
	{
		bp = A_0;
	}

	[SpecialName]
	public bool fo()
	{
		return bq;
	}

	[SpecialName]
	public void ek(bool A_0)
	{
		bq = A_0;
	}

	[SpecialName]
	public double fp()
	{
		return r;
	}

	[SpecialName]
	public void au(double A_0)
	{
		r = A_0;
	}

	[SpecialName]
	public double fq()
	{
		return q;
	}

	[SpecialName]
	public void d5(double A_0)
	{
		q = A_0;
	}

	[SpecialName]
	public double fr()
	{
		return ap;
	}

	[SpecialName]
	public void d6(double A_0)
	{
		ap = A_0;
	}

	[SpecialName]
	public double fs()
	{
		return ao;
	}

	[SpecialName]
	public void d7(double A_0)
	{
		ao = A_0;
	}

	[SpecialName]
	public bool ft()
	{
		return an;
	}

	[SpecialName]
	public void el(bool A_0)
	{
		an = A_0;
		am = !an;
	}

	[SpecialName]
	public bool fu()
	{
		return am;
	}

	[SpecialName]
	public void em(bool A_0)
	{
		am = A_0;
		an = !am;
	}

	[SpecialName]
	public bool fv()
	{
		return ar;
	}

	[SpecialName]
	public void en(bool A_0)
	{
		ar = A_0;
	}

	[SpecialName]
	public bool fw()
	{
		return @as;
	}

	[SpecialName]
	public void eo(bool A_0)
	{
		@as = A_0;
	}

	[SpecialName]
	public double fx()
	{
		return at;
	}

	[SpecialName]
	public void d8(double A_0)
	{
		at = A_0;
	}

	[SpecialName]
	public double fy()
	{
		return this.m_au;
	}

	[SpecialName]
	public void d9(double A_0)
	{
		this.m_au = A_0;
	}

	[SpecialName]
	public bool el(int A_0)
	{
		return co[A_0];
	}

	[SpecialName]
	public void d7(int A_0, bool A_1)
	{
		co[A_0] = A_1;
	}

	[SpecialName]
	public bool fz()
	{
		return a2;
	}

	[SpecialName]
	public void ep(bool A_0)
	{
		a2 = A_0;
	}

	[SpecialName]
	public int f0()
	{
		return a3;
	}

	[SpecialName]
	public void em(int A_0)
	{
		a3 = A_0;
	}

	[SpecialName]
	public bool f1()
	{
		return a4;
	}

	[SpecialName]
	public void eq(bool A_0)
	{
		a4 = A_0;
	}

	[SpecialName]
	public int f2()
	{
		return a5;
	}

	[SpecialName]
	public void en(int A_0)
	{
		a5 = A_0;
	}

	[SpecialName]
	public float f3()
	{
		return a6;
	}

	[SpecialName]
	public void ef(float A_0)
	{
		if (A_0 < 0f)
		{
			A_0 = 0f;
		}
		if ((double)A_0 > 0.99)
		{
			A_0 = 0.99f;
		}
		a6 = A_0;
	}

	[SpecialName]
	public float f4()
	{
		return a7;
	}

	[SpecialName]
	public void eg(float A_0)
	{
		if ((double)A_0 < 0.01)
		{
			A_0 = 0.01f;
		}
		if (A_0 > 1f)
		{
			A_0 = 1f;
		}
		a7 = A_0;
	}

	[SpecialName]
	public int f5()
	{
		return bf;
	}

	[SpecialName]
	public void eo(int A_0)
	{
		bf = A_0;
	}

	[SpecialName]
	public double f6()
	{
		return al;
	}

	[SpecialName]
	public void ea(double A_0)
	{
		al = A_0;
	}

	[SpecialName]
	public bool f7()
	{
		return ab;
	}

	[SpecialName]
	public void er(bool A_0)
	{
		ab = A_0;
	}

	[SpecialName]
	public double f8()
	{
		return aa;
	}

	[SpecialName]
	public void eb(double A_0)
	{
		aa = A_0;
	}

	[SpecialName]
	public string f9()
	{
		return ac;
	}

	[SpecialName]
	public void d9(string A_0)
	{
		ac = A_0;
	}

	[SpecialName]
	public bool au(int A_0, hr A_1)
	{
		if (d6(A_0, A_1))
		{
			return d5(A_0, A_1);
		}
		return false;
	}

	[SpecialName]
	public bool ga()
	{
		return v;
	}

	[SpecialName]
	public void es(bool A_0)
	{
		v = A_0;
	}

	[SpecialName]
	public bool gb()
	{
		return bm;
	}

	[SpecialName]
	public void et(bool A_0)
	{
		bm = A_0;
	}

	[SpecialName]
	public short gc()
	{
		return ay;
	}

	[SpecialName]
	public void au(short A_0)
	{
		checked
		{
			ay = (short)unchecked(-(short)(0 - ((A_0 != 0) ? 1 : 0)));
		}
	}

	[SpecialName]
	public double gd()
	{
		return az;
	}

	[SpecialName]
	public void ec(double A_0)
	{
		az = A_0;
	}

	[SpecialName]
	public double ge()
	{
		return a0;
	}

	[SpecialName]
	public void ed(double A_0)
	{
		a0 = A_0;
	}

	[SpecialName]
	public double gf()
	{
		return a1;
	}

	[SpecialName]
	public void ee(double A_0)
	{
		a1 = A_0;
	}

	[SpecialName]
	public double gg()
	{
		return bg;
	}

	[SpecialName]
	public void ef(double A_0)
	{
		bg = A_0;
	}

	[SpecialName]
	public double gh()
	{
		return bh;
	}

	[SpecialName]
	public void eg(double A_0)
	{
		bh = A_0;
	}

	[SpecialName]
	public bool gi()
	{
		return bi;
	}

	[SpecialName]
	public void eu(bool A_0)
	{
		bi = A_0;
	}

	[SpecialName]
	public bool gj()
	{
		return bj;
	}

	[SpecialName]
	public void ev(bool A_0)
	{
		bj = A_0;
	}

	[SpecialName]
	public double gk()
	{
		return bk;
	}

	[SpecialName]
	public void eh(double A_0)
	{
		bk = A_0;
	}

	[SpecialName]
	public short gl()
	{
		checked
		{
			if (bl > g7() + 1)
			{
				return (short)(g7() + 1);
			}
			return bl;
		}
	}

	[SpecialName]
	public void d5(short A_0)
	{
		bl = A_0;
	}

	[SpecialName]
	public bool ep(int A_0)
	{
		return z[A_0];
	}

	[SpecialName]
	public void d8(int A_0, bool A_1)
	{
		z[A_0] = A_1;
	}

	[SpecialName]
	public bool d5(int A_0, hr A_1)
	{
		if (gm() == 1 || A_0 == 1)
		{
			return z[0] && A_0 == 0;
		}
		if (A_1.cj() == global::hr.b.c)
		{
			eo.a a_ = null;
			return A_1.bl() != null && z[A_0] && (!d5(a_) || !y[A_0]);
		}
		if (A_1.cj() == global::hr.b.j)
		{
			return true;
		}
		return false;
	}

	[SpecialName]
	public bool eq(int A_0)
	{
		return y[A_0];
	}

	[SpecialName]
	public void d9(int A_0, bool A_1)
	{
		y[A_0] = A_1;
	}

	[SpecialName]
	public bool d6(int A_0, hr A_1)
	{
		int num = gn();
		if (gm() == 1)
		{
			return y[0] && A_0 == 0;
		}
		if (A_1.cj() == global::hr.b.c)
		{
			float a_ = A_1.cu().m();
			if (jf.e(a_, 0.0) || (A_1.bl() != null && jf.e(a_, A_1.bl().cu().m())))
			{
				if (A_1.bl() != null)
				{
					if (A_1.bm() != null)
					{
						return y[A_0];
					}
					return A_0 == 0 && (y[0] || (num == 1 && y[1]));
				}
				if (A_1.bm() != null)
				{
					if (num == 1 && z[0])
					{
						return A_0 == 0;
					}
					return y[A_0];
				}
				return A_0 == 0;
			}
			if (A_1.bl() != null)
			{
				return A_0 == 1 && (y[1] || (num == 1 && y[0]));
			}
			return A_0 == 1;
		}
		A_1.cj();
		_ = 9;
		return false;
	}

	[SpecialName]
	public int gm()
	{
		return y.Count;
	}

	[SpecialName]
	public int gn()
	{
		int num = 0;
		checked
		{
			int num2 = gm() - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (z[num3] && num3 == 0)
				{
					num++;
				}
				if (y[num3])
				{
					num++;
				}
			}
			return num;
		}
	}

	[SpecialName]
	public double go()
	{
		return aj;
	}

	[SpecialName]
	public void ei(double A_0)
	{
		aj = A_0;
	}

	[SpecialName]
	public int gp()
	{
		return ak;
	}

	[SpecialName]
	public void er(int A_0)
	{
		ak = A_0;
	}

	[SpecialName]
	public double gq()
	{
		return u;
	}

	[SpecialName]
	public void ej(double A_0)
	{
		u = A_0;
	}

	[SpecialName]
	public double gr()
	{
		return x;
	}

	[SpecialName]
	public void ek(double A_0)
	{
		x = A_0;
	}

	[SpecialName]
	public double gs()
	{
		return ai;
	}

	[SpecialName]
	public void el(double A_0)
	{
		ai = A_0;
	}

	[SpecialName]
	public float gt()
	{
		return aq;
	}

	[SpecialName]
	public void eh(float A_0)
	{
		aq = A_0;
	}

	[SpecialName]
	public bool gu()
	{
		return ag;
	}

	[SpecialName]
	public void ew(bool A_0)
	{
		ag = A_0;
		if (A_0)
		{
			ah = false;
		}
	}

	[SpecialName]
	public bool gv()
	{
		return ah;
	}

	[SpecialName]
	public void ex(bool A_0)
	{
		ah = A_0;
		if (A_0)
		{
			ag = false;
		}
	}

	[SpecialName]
	public bool gw()
	{
		return ad;
	}

	[SpecialName]
	public void ey(bool A_0)
	{
		ad = A_0;
	}

	[SpecialName]
	public bool gx()
	{
		return ae;
	}

	[SpecialName]
	public void ez(bool A_0)
	{
		ae = A_0;
	}

	[SpecialName]
	public bool gy()
	{
		return af;
	}

	[SpecialName]
	public void e0(bool A_0)
	{
		af = A_0;
	}

	[SpecialName]
	public bool d5(eo.a A_0)
	{
		if (d8(A_0))
		{
			if (!gz())
			{
				return d7(A_0);
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	public bool d6(eo.a A_0)
	{
		if (s)
		{
			return !d7(A_0);
		}
		return false;
	}

	[SpecialName]
	public bool gz()
	{
		return s;
	}

	[SpecialName]
	public void e1(bool A_0)
	{
		s = A_0;
	}

	[SpecialName]
	public bool g0()
	{
		if (s)
		{
			return !t;
		}
		return false;
	}

	[SpecialName]
	public bool d7(eo.a A_0)
	{
		if (!t || !p.av(A_0))
		{
			return p.aw(A_0);
		}
		return true;
	}

	[SpecialName]
	public d g1()
	{
		return c8;
	}

	[SpecialName]
	public void au(d A_0)
	{
		c8 = A_0;
	}

	[SpecialName]
	public float g2()
	{
		return aw;
	}

	[SpecialName]
	public void ei(float A_0)
	{
		aw = A_0;
	}

	[SpecialName]
	public bool g3()
	{
		return t;
	}

	[SpecialName]
	public void e2(bool A_0)
	{
		t = A_0;
	}

	[SpecialName]
	public bool g4()
	{
		return t;
	}

	[SpecialName]
	public bool g5()
	{
		return bx;
	}

	[SpecialName]
	public void e3(bool A_0)
	{
		bx = A_0;
	}

	[SpecialName]
	public int g6()
	{
		if (o == null)
		{
			return -2;
		}
		return checked(o.Count - 2);
	}

	[SpecialName]
	public int g7()
	{
		if (cq && hq())
		{
			return -1;
		}
		if (cp != null && cp.Count > 2)
		{
			return checked(cp.Count - 2);
		}
		return 0;
	}

	[SpecialName]
	public string g8()
	{
		return bc;
	}

	[SpecialName]
	public void ea(string A_0)
	{
		bc = A_0;
	}

	[SpecialName]
	public float g9()
	{
		return be;
	}

	[SpecialName]
	public void ej(float A_0)
	{
		be = A_0;
	}

	[SpecialName]
	public bool ha()
	{
		return a9;
	}

	[SpecialName]
	public void e4(bool A_0)
	{
		a9 = A_0;
	}

	[SpecialName]
	public double hb()
	{
		return ba;
	}

	[SpecialName]
	public void em(double A_0)
	{
		ba = A_0;
	}

	[SpecialName]
	public float hc()
	{
		return bb;
	}

	[SpecialName]
	public void ek(float A_0)
	{
		bb = A_0;
	}

	[SpecialName]
	public bool hd()
	{
		if (bs)
		{
			return p.a1();
		}
		return false;
	}

	[SpecialName]
	public void e5(bool A_0)
	{
		bs = A_0;
	}

	[SpecialName]
	public bool he()
	{
		return a8;
	}

	[SpecialName]
	public void e6(bool A_0)
	{
		a8 = A_0;
	}

	[SpecialName]
	public bool hf()
	{
		return bw;
	}

	[SpecialName]
	public void e7(bool A_0)
	{
		bw = A_0;
	}

	[SpecialName]
	public bool au(bool A_0, eo.a A_1)
	{
		if ((d8(A_1) && (s || t)) || A_0)
		{
			return false;
		}
		return true;
	}

	[SpecialName]
	public bool d5(bool A_0, eo.a A_1)
	{
		if (hf())
		{
			return au(A_0, A_1);
		}
		return false;
	}

	[SpecialName]
	public bool hg()
	{
		return w;
	}

	[SpecialName]
	public void e8(bool A_0)
	{
		w = A_0;
	}

	public bool d8(eo.a A_0)
	{
		bool a_ = p.ax(A_0);
		bool a_2 = p.az(A_0);
		eo.b a_3 = p.at(A_0, A_1: false);
		if (cq && hq())
		{
			return false;
		}
		checked
		{
			int num = g7() + 1;
			if (eu(0).ah(a_))
			{
				return true;
			}
			int num2 = num;
			for (int num3 = 1; num3 <= num2; num3++)
			{
				gc gc2 = eu(num3);
				if (gc2.ah(a_) || gc2.aj(a_) || gc2.al(a_) || (num3 < num && (gc2.ap(a_2) || gc2.an(a_) || (Operators.CompareString(gc2.ag(), "<Roughness>", TextCompare: false) == 0 && gc2.af(a_3)) || Operators.CompareString(gc2.ag(), "<Graded Interface>", TextCompare: false) == 0)))
				{
					return false;
				}
				gc2 = null;
			}
			return true;
		}
	}

	[SpecialName]
	public int hh()
	{
		return o.Count;
	}

	[SpecialName]
	public int hi()
	{
		if (cq && hq())
		{
			return -1;
		}
		return cp.Count;
	}

	[SpecialName]
	public bool au(eo.a A_0, bool A_1)
	{
		return d5(A_0, A_1) >= 0;
	}

	public int d5(eo.a A_0, bool A_1)
	{
		eo.b a_ = p.at(A_0, A_1);
		checked
		{
			int num = g7() + 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (eu(num2).af(a_))
				{
					return num2;
				}
			}
			return -1;
		}
	}

	public static bool au(float A_0, gc A_1)
	{
		if (!A_1.ao())
		{
			return false;
		}
		double num = A_1.av() * 0.01;
		double num2 = A_1.ai() * (1.0 - num);
		double num3 = A_1.ai() * (1.0 + num);
		_ = null;
		return (!jf.e(A_0, 0f) || !jf.e((float)num2, 0f)) && (jf.c(A_0, (float)num2) || jf.a(A_0, (float)num3));
	}

	public bool au(float A_0, int A_1)
	{
		if (!((double)A_0 > d8(A_1)))
		{
			if ((double)A_0 < d7(A_1))
			{
				return d7(A_1) != 0.0;
			}
			return false;
		}
		return true;
	}

	public bool au(float A_0, float A_1, int A_2, ref bool A_3, ref bool A_4)
	{
		A_3 = (double)A_0 > ed(A_2) || (double)A_0 < ec(A_2);
		A_4 = (double)A_1 > ef(A_2) || ((double)A_1 < ee(A_2) && ee(A_2) > 0.0);
		if (A_3 || A_4)
		{
			return true;
		}
		bool result = default(bool);
		return result;
	}

	public bool au(float[] A_0)
	{
		int num = g7();
		if (A_0 != null && A_0.Length > num)
		{
			int num2 = num;
			for (int num3 = 1; num3 <= num2; num3 = checked(num3 + 1))
			{
				if (au(A_0[num3], eu(num3)))
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool au(float[] A_0, float[] A_1, float[] A_2)
	{
		checked
		{
			if (A_0 != null && A_0.Length > 0)
			{
				int num = e3() - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (d9(num2) && au(A_0[num2], num2))
					{
						return true;
					}
				}
			}
			if (A_1 != null && A_1.Length > 0)
			{
				int num3 = e9() - 1;
				bool A_3 = default(bool);
				bool A_4 = default(bool);
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (ei(num4) && au(A_1[num4], A_2[num4], num4, ref A_3, ref A_4))
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	public void au(gc A_0, int A_1)
	{
		if (A_1 == o.Count)
		{
			o.Add(A_0, null, null, A_1);
		}
		else
		{
			o.Add(A_0, null, checked(A_1 + 1));
		}
		A_0.ah(hj);
		cq = true;
	}

	public void au(ref gc A_0, int A_1 = -1, int A_2 = -1)
	{
		if (A_1 != -1)
		{
			o.Add(A_0, null, A_1);
		}
		else if (A_2 != -1)
		{
			o.Add(A_0, null, null, A_2);
		}
		else
		{
			o.Add(A_0);
		}
		A_0.ah(hj);
		cq = true;
	}

	public void hj()
	{
		cq = true;
	}

	public void es(int A_0)
	{
		o.Remove(A_0);
		cq = true;
	}

	public static string au(ref a A_0)
	{
		string result = "";
		switch (A_0)
		{
		case global::hi.a.c:
			result = "Linear";
			break;
		case global::hi.a.a:
			result = "Rectangular";
			break;
		case global::hi.a.b:
			result = "Polar";
			break;
		case global::hi.a.d:
			result = "Die";
			break;
		case global::hi.a.e:
			result = "Custom";
			break;
		}
		return result;
	}

	public static a d5(string A_0)
	{
		return A_0 switch
		{
			"Linear" => global::hi.a.c, 
			"Rectangular" => global::hi.a.a, 
			"Polar" => global::hi.a.b, 
			"Die" => global::hi.a.d, 
			"Custom" => global::hi.a.e, 
			_ => (a)0, 
		};
	}

	public static string au(a A_0)
	{
		return A_0 switch
		{
			global::hi.a.c => "L", 
			global::hi.a.b => "P", 
			global::hi.a.a => "R", 
			global::hi.a.e => "c", 
			_ => throw new ax("Invalid coordinate system type"), 
		};
	}

	public gc et(int A_0)
	{
		checked
		{
			if (A_0 + 1 > o.Count)
			{
				return null;
			}
			return (gc)o[A_0 + 1];
		}
	}

	public gc eu(int A_0)
	{
		if (cq && hq())
		{
			return null;
		}
		checked
		{
			if (A_0 + 1 > cp.Count)
			{
				return null;
			}
			return (gc)cp[A_0 + 1];
		}
	}

	public void au(ref hi A_0)
	{
		A_0 = null;
		A_0 = new hi(p);
		hi hi2 = A_0;
		hi2.ew(gm());
		hi2.e1(s);
		hi2.e2(t);
		hi2.e0(af);
		hi2.ez(ae);
		hi2.ey(ad);
		hi2.ew(ag);
		hi2.ex(ah);
		hi2.e7(bw);
		hi2.el(ai);
		hi2.ej(u);
		hi2.ek(x);
		hi2.ei(aj);
		hi2.er(ak);
		checked
		{
			int num = gm() - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				hi2.d9(num2, y[num2]);
				hi2.d8(num2, z[num2]);
			}
			hi2.d9(ac);
			hi2.eb(aa);
			hi2.er(ab);
			hi2.ea(al);
			hi2.em(am);
			hi2.el(an);
			hi2.d7(ao);
			hi2.d6(ap);
			hi2.en(ar);
			hi2.eo(@as);
			hi2.d8(at);
			hi2.d9(this.m_au);
			hi2.e4(a9);
			hi2.em(ba);
			hi2.e6(a8);
			hi2.ek(fh());
			hi2.ea(bc);
			hi2.ej(be);
			hi2.es(v);
			hi2.eo(bf);
			hi2.eh(bn);
			hi2.ei(bo);
			hi2.ej(bp);
			hi2.ek(bq);
			hi2.eh(aq);
			hi2.au(ay);
			hi2.ec(az);
			hi2.ed(a0);
			hi2.ee(a1);
			hi2.d5(q);
			hi2.au(r);
			br.e(ref A_0.br);
			hi2.e5(bs);
			hi2.eg(bt);
			hi2.em(a3);
			hi2.ep(a2);
			hi2.eq(a4);
			hi2.en(a5);
			hi2.ef(a6);
			hi2.eg(a7);
			hi2.e3(bx);
			hi2.d7(bz);
			hi2.eb(b7);
			hi2.ec(b8);
			hi2.ed(b9);
			hi2.ee(ca);
			hi2.ef(cb);
			hi2.au(b0);
			int num3 = b0 - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				hi2.au(num4, b1[num4]);
				hi2.d5(num4, b2[num4]);
				hi2.d6(num4, b3[num4]);
				hi2.d7(num4, b4[num4]);
				hi2.au(num4, b5[num4]);
				hi2.au(num4, b6[num4]);
			}
			hi2.cd = cd;
			hi2.d6(ce);
			hi2.eb(cf);
			int num5 = cf - 1;
			for (int num6 = 0; num6 <= num5; num6++)
			{
				hi2.d8(num6, cg[num6]);
				hi2.d9(num6, ch[num6]);
				hi2.ea(num6, ci[num6]);
				hi2.eb(num6, cj[num6]);
				hi2.au(num6, ck[num6]);
				hi2.d5(num6, cl[num6]);
				hi2.d6(num6, cm[num6]);
				hi2.d5(num6, cn[num6]);
				hi2.d7(num6, co[num6]);
			}
			int num7 = hh() - 1;
			for (int num8 = 0; num8 <= num7; num8++)
			{
				new gc();
				gc obj = et(num8);
				gc A_1 = new gc();
				obj.af(ref A_1);
				hi2.au(ref A_1);
				A_1 = null;
			}
			hi2.cp.Clear();
			int num9 = hi();
			for (int num8 = 1; num8 <= num9; num8++)
			{
				gc A_2 = new gc();
				((gc)cp[num8]).af(ref A_2);
				hi2.cp.Add(A_2);
			}
			if (bw)
			{
				hi2.hm();
			}
			hi2.cr.Clear();
			int num10 = cr.Count - 1;
			for (int num11 = 0; num11 <= num10; num11++)
			{
				hi2.cr.Add(cr[num11]);
			}
			hi2.cs.Clear();
			int num12 = cs.Count - 1;
			for (int num13 = 0; num13 <= num12; num13++)
			{
				hi2.cs.Add(cs[num13]);
			}
			hi2.cq = cq;
			hi2.au(d7());
			hi2.au(d8());
			hi2.cw = cw;
			hi2.cx = cx;
			hi2.cy = cy;
			hi2.cz = cz;
			hi2.c0 = c0;
			hi2.c1 = c1;
			hi2.ef(bg);
			hi2.eg(bh);
			hi2.eu(bi);
			hi2.ev(bj);
			hi2.eh(bk);
			hi2.d5(bl);
			hi2.et(bm);
			List<hj> list = hi2.es();
			list.Clear();
			int num14 = c2.Count - 1;
			for (int num15 = 0; num15 <= num14; num15++)
			{
				list.Add(c2[num15].d());
			}
			list = null;
			c9.a(ref hi2.c9);
			hi2.c3 = c3;
			hi2.c6 = c6;
			hi2.au(c8);
			hi2.ei(aw);
			hi2 = null;
		}
	}

	public void hk()
	{
		o.Clear();
		cp.Clear();
	}

	public void ev(int A_0)
	{
		int index = checked(A_0 + 1);
		o.Remove(index);
		cq = true;
	}

	public void ew(int A_0)
	{
		y = new Collection<bool>();
		z = new Collection<bool>();
		checked
		{
			int num = A_0 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (num2 == 0)
				{
					y.Add(item: true);
				}
				else
				{
					y.Add(item: false);
				}
				z.Add(item: false);
			}
		}
	}

	public void au(hg.j A_0, bool A_1 = false)
	{
		o = new Collection();
		q = 0.0;
		r = 0.0;
		s = true;
		t = false;
		v = false;
		ew(2);
		aa = 0.0;
		ab = true;
		ac = "";
		ae = true;
		ad = false;
		if (A_0 == global::hg.j.a)
		{
			ag = false;
		}
		else
		{
			ag = true;
		}
		ai = 0.999;
		aj = 400.0;
		ak = 0;
		al = 632.7999877929688;
		if (A_0 == global::hg.j.c)
		{
			u = 0.8;
			am = false;
			an = true;
		}
		else
		{
			u = 0.0;
			am = true;
			an = false;
		}
		x = 0.0;
		ao = 470.0;
		ap = 750.0;
		ar = false;
		@as = false;
		at = 2000.0;
		this.m_au = 2000.0;
		aw = 1f;
		a9 = true;
		ba = 4.0;
		bn = false;
		bo = false;
		bp = false;
		bq = false;
		br.a = 1.0;
		br.b = 0.0;
		br.d = 99999999.0;
		br.c = 0.0;
		bs = false;
		bt = false;
		if (!A_1)
		{
			gc A_2 = new gc();
			A_2.af("Air");
			A_2.al(0.5);
			au(ref A_2);
			A_2 = new gc();
			gc obj = A_2;
			string A_3 = "SiO2";
			obj.af(ref A_3);
			A_2.af(A_0: false, A_1: true, 1000.0);
			A_2.ag(A_0: true);
			A_2.ag("Cauchy");
			A_2.ah(800.0);
			A_2.ah(1200.0);
			au(ref A_2);
			A_2 = new gc();
			A_2.af("Si");
			A_2.aj(0.0);
			A_2.al(0.5);
			A_2.am(0.1);
			A_2.ag("Bridge Lorentzian-3Term");
			au(ref A_2);
		}
		bd = 5;
		bc = "Custom1";
		be = 5f;
		a8 = true;
		a2 = false;
		a3 = 0;
		a4 = false;
		a5 = 0;
		a6 = 0.5f;
		a7 = 0.5f;
		bx = false;
		bz = "";
		b0 = 0;
		cf = 0;
		b7 = false;
		b8 = false;
		b9 = false;
		ca = false;
		cb = false;
		cd = false;
		ce = "";
		ay = 0;
		az = 650.0;
		a0 = 720.0;
		a1 = 800.0;
		ak = -1;
		hl();
		au();
		d6();
		d5();
	}

	private void d6()
	{
		c3 = false;
		c6 = 50f;
	}

	private void d5()
	{
		au(global::hi.d.a);
	}

	public void hl()
	{
		au(A_0: false);
		au(global::a4.a.d);
		cw = -100f;
		cx = 100f;
		cy = -100f;
		cz = 100f;
		c0 = -100f;
		c1 = 100f;
	}

	private void au()
	{
		bg = 1.0;
		bh = 0.5;
		bi = true;
		bj = true;
		bk = 1200.0;
		bl = 1;
	}

	public hi(eo A_0)
	{
		br = new gb();
		b1 = new double[12];
		b2 = new double[12];
		b3 = new double[12];
		b4 = new double[12];
		b5 = new bool[12];
		b6 = new e[12];
		cg = new double[6];
		ch = new double[6];
		ci = new double[6];
		cj = new double[6];
		ck = new b[6];
		cl = new bool[6];
		cm = new bool[6];
		cn = new e[6];
		co = new bool[6];
		cp = new Collection();
		cq = false;
		cr = new Collection<Guid>();
		cs = new Collection<gd>();
		c2 = new List<hj>();
		c9 = new f();
		o = new Collection();
		a7 = 0.5f;
		a6 = 0.5f;
		p = A_0;
		at = 2000.0;
		this.m_au = 2000.0;
		aw = 1f;
		ak = -1;
		hl();
		au();
		d6();
		d5();
	}

	~hi()
	{
		o = null;
		base.Finalize();
	}

	private bool au(gc A_0)
	{
		foreach (gc item in o)
		{
			if (item == A_0)
			{
				return true;
			}
		}
		return false;
	}

	public void hm()
	{
		if (!hf())
		{
			return;
		}
		bu = new short[102];
		checked
		{
			short num = (short)g6();
			for (short num2 = 2; num2 <= num; num2 = (short)unchecked(num2 + 1))
			{
				gc gc2 = et(num2);
				short num3 = (short)unchecked(num2 - 1);
				for (short num4 = 1; num4 <= num3; num4 = (short)unchecked(num4 + 1))
				{
					gc gc3 = et(num4);
					if (Operators.CompareString(gc3.ag(), gc2.ag(), TextCompare: false) == 0 && !global::hg.b2(gc3.ag()) && gc3.ai() == gc2.ai() && !string.IsNullOrEmpty(gc3.ag()))
					{
						bu[num2] = num4;
						o.Remove(num2 + 1);
						o.Add(gc3, null, num2 + 1);
						break;
					}
				}
			}
			bv = new short[102];
			short num5 = (short)g7();
			for (short num2 = 2; num2 <= num5; num2 = (short)unchecked(num2 + 1))
			{
				gc gc2 = eu(num2);
				short num6 = (short)unchecked(num2 - 1);
				for (short num4 = 1; num4 <= num6; num4 = (short)unchecked(num4 + 1))
				{
					gc gc3 = eu(num4);
					if (Operators.CompareString(gc3.ag(), gc2.ag(), TextCompare: false) == 0 && !global::hg.b2(gc3.ag()) && gc3.ai() == gc2.ai() && !string.IsNullOrEmpty(gc3.ag()) && au(gc2))
					{
						bv[num2] = num4;
						cp.Remove(num2 + 1);
						cp.Add(gc3, null, num2 + 1);
						break;
					}
				}
			}
		}
	}

	public void hn()
	{
		gc A_ = null;
		int num = g6();
		checked
		{
			for (int num2 = 1; num2 <= num; num2++)
			{
				((gc)o[num2 + 1]).af(ref A_);
				o.Remove(num2 + 1);
				o.Add(A_, null, num2 + 1);
			}
			int num3 = g7();
			for (int num2 = 1; num2 <= num3; num2++)
			{
				((gc)cp[num2 + 1]).af(ref A_);
				cp.Remove(num2 + 1);
				cp.Add(A_, null, num2 + 1);
			}
		}
	}

	public int au(ref int A_0)
	{
		return bu[A_0];
	}

	public void au(ref short[] A_0)
	{
		A_0 = bv;
	}

	public void ex(int A_0)
	{
		checked
		{
			if (A_0 < b0)
			{
				for (int num = b0 - 1; num >= A_0; num += -1)
				{
					b1[num + 1] = b1[num];
					b2[num + 1] = b2[num];
					b3[num + 1] = b3[num];
					b4[num + 1] = b4[num];
					b5[num + 1] = b5[num];
					b6[num + 1] = b6[num];
				}
			}
			b0++;
			b5[A_0] = true;
		}
	}

	public void ey(int A_0)
	{
		checked
		{
			if (A_0 < b0 - 1)
			{
				int num = A_0 + 1;
				int num2 = b0 - 1;
				for (int num3 = num; num3 <= num2; num3++)
				{
					b1[num3 - 1] = b1[num3];
					b2[num3 - 1] = b2[num3];
					b3[num3 - 1] = b3[num3];
					b4[num3 - 1] = b4[num3];
					b5[num3 - 1] = b5[num3];
					b6[num3 - 1] = b6[num3];
				}
			}
			b0--;
		}
	}

	public void ez(int A_0)
	{
		checked
		{
			if (A_0 < cf)
			{
				for (int num = cf - 1; num >= A_0; num += -1)
				{
					cg[num + 1] = cg[num];
					ch[num + 1] = ch[num];
					ci[num + 1] = ci[num];
					cj[num + 1] = cj[num];
					ck[num + 1] = ck[num];
					cl[num + 1] = cl[num];
					cm[num + 1] = cm[num];
					cn[num + 1] = cn[num];
				}
			}
			cf++;
			cm[A_0] = true;
		}
	}

	public void e0(int A_0)
	{
		checked
		{
			if (A_0 < cf - 1)
			{
				int num = A_0 + 1;
				int num2 = cf - 1;
				for (int num3 = num; num3 <= num2; num3++)
				{
					cg[num3 - 1] = cg[num3];
					ch[num3 - 1] = ch[num3];
					ci[num3 - 1] = ci[num3];
					cj[num3 - 1] = cj[num3];
					ck[num3 - 1] = ck[num3];
					cl[num3 - 1] = cl[num3];
					cm[num3 - 1] = cm[num3];
					cn[num3 - 1] = cn[num3];
				}
			}
			cf--;
		}
	}

	public gc.a e1(int A_0)
	{
		if (A_0 == 0)
		{
			return global::gc.a.a;
		}
		if (A_0 == checked(g6() + 1))
		{
			return global::gc.a.c;
		}
		return global::gc.a.b;
	}

	public void ho()
	{
		cp.Clear();
		int count = o.Count;
		checked
		{
			for (int num = 1; num <= count; num++)
			{
				gc gc2 = (gc)o[num];
				string text = gc2.ag();
				bool a_ = num == o.Count;
				if (global::gd.l(text))
				{
					int num2 = gc2.ah();
					for (int num3 = 1; num3 <= num2; num3++)
					{
						string a_2 = text.Substring("Stack: ".Length);
						gd A_ = null;
						cs[au(a_2, a_)].i(ref A_);
						Collection<gc> collection = A_.l();
						int num4 = collection.Count - 1;
						for (int num5 = 0; num5 <= num4; num5++)
						{
							collection[num5].v = A_.k();
							cp.Add(collection[num5]);
						}
						collection = null;
					}
				}
				else
				{
					cp.Add(gc2);
				}
			}
			cq = false;
		}
	}

	public void au(ref bool A_0, ref string A_1)
	{
		A_0 = false;
		cs.Clear();
		cr.Clear();
		int count = o.Count;
		for (int num = 1; num <= count; num = checked(num + 1))
		{
			string text = ((gc)o[num]).ag();
			bool a_ = num == o.Count;
			if (global::gd.l(text))
			{
				string text2 = text.Substring("Stack: ".Length);
				string text3 = global::gd.k(text2, a_);
				if (text3 == null)
				{
					A_1 = $"LayerStack '{text2}' is missing";
					return;
				}
				if (au(Path.GetFileNameWithoutExtension(text3), a_) == -1)
				{
					gd gd2 = new gd();
					gd2.n(Path.GetFileName(text3));
					cs.Add(gd2);
				}
			}
		}
		hp();
		A_0 = true;
	}

	public void hp()
	{
		cr.Clear();
		foreach (gd c in cs)
		{
			cr.Add(c.e);
		}
	}

	public int d5(string A_0, bool A_1)
	{
		int num = au(A_0, A_1: false);
		if (num >= 0)
		{
			return cs[num].l().Count;
		}
		return -1;
	}

	public bool hq()
	{
		string A_ = null;
		bool A_2 = default(bool);
		au(ref A_2, ref A_);
		if (!A_2)
		{
			return true;
		}
		ho();
		return false;
	}

	public bool d5(ref int A_0)
	{
		ho();
		A_0 = g7();
		return A_0 > 100;
	}

	public bool hr()
	{
		ho();
		return g7() < 100;
	}

	public string hs()
	{
		string text = null;
		int count = o.Count;
		for (int num = 1; num <= count; num = checked(num + 1))
		{
			string text2 = ((gc)o[num]).ag();
			bool a_ = num == o.Count;
			if (global::gd.l(text2))
			{
				string text3 = text2.Substring("Stack: ".Length);
				if (global::gd.k(text3, a_) == null)
				{
					text += $"LayerStack '{text3}' is missing \r\n";
				}
			}
		}
		return text;
	}

	private int au(string A_0, bool A_1)
	{
		checked
		{
			int num = cs.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (Operators.CompareString(cs[num2].n(), A_0, TextCompare: false) == 0 && cs[num2].m() == A_1)
				{
					return num2;
				}
			}
			return -1;
		}
	}

	public static bool au(Collection<Guid> A_0, Collection<Guid> A_1)
	{
		if (A_0.Count != A_1.Count)
		{
			return false;
		}
		checked
		{
			int num = A_1.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (!(A_0[num2] == A_1[num2]))
				{
					return false;
				}
			}
			return true;
		}
	}

	public hi ht()
	{
		checked
		{
			int num = cs.Count - 1;
			bool A_ = default(bool);
			bool flag = default(bool);
			for (int num2 = 0; num2 <= num; num2++)
			{
				gd gd2 = cs[num2];
				if (!au(Path.GetFileNameWithoutExtension(gd2.c), gd2.e, gd2.m(), ref A_))
				{
					flag = true;
					break;
				}
				gd2 = null;
			}
			if (!flag)
			{
				return null;
			}
			hi A_2 = new hi(p);
			au(ref A_2);
			int num3 = A_2.cs.Count - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				gd gd3 = A_2.cs[num4];
				if (!au(Path.GetFileNameWithoutExtension(gd3.c), gd3.e, gd3.m(), ref A_))
				{
					if (!A_)
					{
						gd3.m(global::gd.i() + gd3.c);
					}
					else
					{
						string extension = Path.GetExtension(gd3.c);
						string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(gd3.c);
						string a_ = "Stack: " + fileNameWithoutExtension;
						int num5 = 1;
						while (true)
						{
							string text = fileNameWithoutExtension + "_" + num5;
							string text2 = "Stack: " + text;
							if (!au(text2))
							{
								string text3 = global::gd.i() + text + extension;
								if (!File.Exists(text3))
								{
									gd3.m(text3);
									au(a_, text2);
									break;
								}
								if (au(Path.GetFileNameWithoutExtension(text3), gd3.e, gd3.m(), ref A_))
								{
									gd3.c = text + extension;
									au(a_, text2);
									break;
								}
							}
							num5++;
						}
					}
				}
				gd3 = null;
			}
			return A_2;
		}
	}

	private bool au(string A_0, Guid A_1, bool A_2, ref bool A_3)
	{
		Guid guid = global::gd.i(Path.GetFileNameWithoutExtension(A_0), A_2, ref A_3);
		if (A_3)
		{
			return guid == A_1;
		}
		return false;
	}

	private bool au(string A_0)
	{
		foreach (gc item in o)
		{
			if (string.Compare(item.ag(), A_0, ignoreCase: true) == 0)
			{
				return true;
			}
		}
		return false;
	}

	private void au(string A_0, string A_1)
	{
		int count = o.Count;
		for (int num = 1; num <= count; num = checked(num + 1))
		{
			if (Operators.CompareString(((gc)o[num]).ag(), A_0, TextCompare: false) == 0)
			{
				((gc)o[num]).af(A_1);
			}
		}
	}

	public void au(List<iz.a> A_0)
	{
		checked
		{
			int num = o.Count - 1;
			for (int num2 = 2; num2 <= num; num2++)
			{
				string text = ((gc)o[num2]).ag();
				if (!text.Contains("<Roughness>") && !text.Contains("<Graded Interface>") && !global::gd.l(text))
				{
					A_0.Add(new iz.a(text, num2));
				}
			}
		}
	}
}
