using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FIUsbIntLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal abstract class cc
{
	public struct a
	{
		public float a;

		public float b;

		[SpecialName]
		public float e()
		{
			return a;
		}

		[SpecialName]
		public float f()
		{
			return b;
		}

		[SpecialName]
		public static bool f(a A_0, a A_1)
		{
			if (A_0.a != A_1.a || A_0.b != A_1.b)
			{
				return true;
			}
			return false;
		}

		[SpecialName]
		public static bool e(a A_0, a A_1)
		{
			if (A_0.a != A_1.a || A_0.b != A_1.b)
			{
				return false;
			}
			return true;
		}
	}

	internal class b
	{
		protected float a;

		protected float b;

		public b(float A_0, float A_1)
		{
			a = A_0;
			b = A_1;
		}

		[SpecialName]
		public float c()
		{
			return a;
		}

		[SpecialName]
		public float d()
		{
			return b;
		}
	}

	internal class c
	{
		protected List<double> a;

		protected List<double> b;

		protected List<double> c;

		protected List<double> d;

		protected List<double> e;

		[SpecialName]
		public int g()
		{
			return a.Count;
		}

		[SpecialName]
		public double g(int A_0)
		{
			return a[A_0];
		}

		[SpecialName]
		public double h(int A_0)
		{
			return b[A_0];
		}

		[SpecialName]
		public double i(int A_0)
		{
			return c[A_0];
		}

		[SpecialName]
		public double j(int A_0)
		{
			return d[A_0];
		}

		[SpecialName]
		public double k(int A_0)
		{
			return e[A_0];
		}

		public c(double[] A_0, double[] A_1, double[] A_2, double[] A_3, double[] A_4)
		{
			a = new List<double>();
			b = new List<double>();
			c = new List<double>();
			d = new List<double>();
			e = new List<double>();
			int upperBound = A_0.GetUpperBound(0);
			for (int num = 0; num <= upperBound; num = checked(num + 1))
			{
				a.Add(A_0[num]);
				b.Add(A_1[num]);
				c.Add(A_2[num]);
				d.Add(A_3[num]);
				e.Add(A_4[num]);
			}
		}
	}

	internal class d
	{
		protected a4.a a;

		protected a4.c b;

		protected a4.b c;

		protected float d;

		protected float e;

		protected float f;

		protected bool g;

		protected int h;

		public d()
		{
			this.h = 2;
		}

		[SpecialName]
		public a4.a h()
		{
			return a;
		}

		[SpecialName]
		public a4.c i()
		{
			return b;
		}

		[SpecialName]
		public a4.b j()
		{
			return c;
		}

		[SpecialName]
		public float k()
		{
			return d;
		}

		[SpecialName]
		public float l()
		{
			return e;
		}

		[SpecialName]
		public float m()
		{
			return f;
		}

		[SpecialName]
		public bool n()
		{
			return g;
		}

		public void h(a4.a A_0, a4.c A_1, a4.b A_2, float A_3, float A_4, float A_5, bool A_6)
		{
			a = A_0;
			b = A_1;
			c = A_2;
			d = A_3;
			e = A_4;
			f = A_5;
			g = A_6;
		}

		public void h(BinaryWriter A_0)
		{
			long position = A_0.BaseStream.Position;
			A_0.Write(position);
			A_0.Write(this.h);
			A_0.Write(1);
			A_0.Write((int)a);
			A_0.Write((short)b);
			A_0.Write((short)c);
			A_0.Write(d);
			A_0.Write(e);
			A_0.Write(f);
			A_0.Write(g);
			long position2 = A_0.BaseStream.Position;
			A_0.BaseStream.Seek(position, SeekOrigin.Begin);
			A_0.Write(position2);
			A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
		}

		public void h(BinaryReader A_0)
		{
			long offset = A_0.ReadInt64();
			int num = A_0.ReadInt32();
			int num2 = A_0.ReadInt32();
			if (num2 <= this.h)
			{
				a = (a4.a)A_0.ReadInt32();
				b = (a4.c)A_0.ReadInt16();
				c = (a4.b)A_0.ReadInt16();
				d = A_0.ReadSingle();
				e = A_0.ReadSingle();
				f = A_0.ReadSingle();
				if (num >= 2)
				{
					g = A_0.ReadBoolean();
				}
				else
				{
					g = false;
				}
				A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
				return;
			}
			throw new au("ColorData maximum compatible block file version is " + this.h + " compatible version in file we are attempting to read is " + num2);
		}
	}

	internal class e
	{
		protected double a;

		protected double b;

		protected double c;

		protected const int d = 1;

		public e(double A_0, double A_1, double A_2)
		{
			b = A_0;
			a = A_1;
			c = A_2;
		}

		[SpecialName]
		public double d()
		{
			return b;
		}

		[SpecialName]
		public double e()
		{
			return a;
		}

		[SpecialName]
		public double f()
		{
			return c;
		}

		public void d(BinaryWriter A_0)
		{
			long position = A_0.BaseStream.Position;
			A_0.Write(position);
			A_0.Write(1);
			A_0.Write(1);
			A_0.Write(a);
			A_0.Write(b);
			A_0.Write(c);
			long position2 = A_0.BaseStream.Position;
			A_0.BaseStream.Seek(position, SeekOrigin.Begin);
			A_0.Write(position2);
			A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
		}

		public void d(BinaryReader A_0)
		{
			int num = 0;
			long offset = A_0.ReadInt64();
			A_0.ReadInt32();
			num = A_0.ReadInt32();
			if (num <= 1)
			{
				a = A_0.ReadDouble();
				b = A_0.ReadDouble();
				c = A_0.ReadDouble();
				A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
				return;
			}
			throw new au("FilterResults maximum compatible block file version is " + 1 + " compatible version in file we are attempting to read is " + num);
		}
	}

	public class f
	{
		protected Collection<d> a;

		protected float[] b;

		public f()
		{
			a = new Collection<d>();
		}

		[SpecialName]
		public float[] c()
		{
			return b;
		}

		[SpecialName]
		public void c(float[] A_0)
		{
			if (A_0 == null)
			{
				b = null;
			}
			else
			{
				b = (float[])A_0.Clone();
			}
		}

		public void c(short A_0, d A_1)
		{
			a.Insert(A_0, A_1);
		}

		public void d()
		{
			a.Clear();
		}

		[SpecialName]
		public Collection<d> e()
		{
			return a;
		}
	}

	internal class g
	{
		private double a;

		private double b;

		private double c;

		protected const int d = 23;

		[SpecialName]
		public double d()
		{
			return a;
		}

		[SpecialName]
		public void d(double A_0)
		{
			a = A_0;
		}

		[SpecialName]
		public double e()
		{
			return b;
		}

		[SpecialName]
		public double f()
		{
			return c;
		}

		public void d(b6 A_0, hi.c A_1)
		{
			double A_2 = default(double);
			double A_3 = default(double);
			global::b6.c(A_1, ref A_2, ref A_3);
			b = A_2;
			c = A_3;
		}

		public void d(BinaryWriter A_0)
		{
			long position = A_0.BaseStream.Position;
			A_0.Write(position);
			A_0.Write(23);
			A_0.Write(1);
			A_0.Write(a);
			long position2 = A_0.BaseStream.Position;
			A_0.BaseStream.Seek(position, SeekOrigin.Begin);
			A_0.Write(position2);
			A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
		}

		public void d(BinaryReader A_0)
		{
			int num = 0;
			long offset = A_0.ReadInt64();
			A_0.ReadInt32();
			num = A_0.ReadInt32();
			if (num <= 23)
			{
				a = A_0.ReadDouble();
				A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
				return;
			}
			throw new au("SolarUVResults maximum compatible block file version is " + 23 + " compatible version in file we are attempting to read is " + num);
		}

		public g()
		{
			b = 0.0;
			c = 0.0;
		}
	}

	internal class h
	{
		public float a;

		public float b;

		public float c;

		public h(float A_0, float A_1, float A_2)
		{
			a = A_0;
			b = A_1;
			c = A_2;
		}

		public static string g()
		{
			return "Dip=";
		}

		public string h()
		{
			return c.ToString("####.##");
		}

		public static string f()
		{
			return "Lower=";
		}

		public string i()
		{
			return a.ToString("####.##");
		}

		public static string e()
		{
			return "Upper=";
		}

		public string j()
		{
			return b.ToString("####.##");
		}

		public static string d()
		{
			return " nm";
		}
	}

	internal class i
	{
		public float a;

		public float b;

		public float c;

		public i(float A_0, float A_1, float A_2)
		{
			b = A_0;
			c = A_1;
			a = A_2;
		}

		public static string g()
		{
			return "Center=";
		}

		public string h()
		{
			return a.ToString("####.##");
		}

		public static string f()
		{
			return "Lower=";
		}

		public string i()
		{
			return b.ToString("####.##");
		}

		public static string e()
		{
			return "Upper=";
		}

		public string j()
		{
			return c.ToString("####.##");
		}

		public static string d()
		{
			return " nm";
		}
	}

	public enum j
	{
		a,
		b,
		c
	}

	public enum k
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g,
		h,
		i,
		j,
		k,
		l
	}

	public enum l
	{
		a = 11,
		b,
		c,
		d,
		e,
		f,
		g,
		h,
		i,
		j,
		k,
		l,
		m,
		n,
		o,
		p,
		q,
		r,
		s,
		t,
		u,
		v,
		w,
		x,
		y,
		z,
		aa,
		ab,
		ac,
		ad,
		ae,
		af,
		ag,
		ah,
		ai,
		aj,
		ak,
		al,
		am,
		an,
		ao,
		ap,
		aq,
		ar,
		@as,
		at,
		au,
		av,
		aw,
		ax,
		ay,
		az,
		a0,
		a1,
		a2,
		a3
	}

	public enum m
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g,
		h,
		i
	}

	public enum n
	{
		a,
		b,
		c
	}

	public enum o
	{
		a,
		b,
		c
	}

	public enum p
	{
		a,
		b
	}

	public enum q
	{
		a,
		b,
		c
	}

	private const string m_a = "1";

	private const string m_b = "0";

	protected hr c;

	protected fy d;

	protected fy e;

	protected fy f;

	protected double g;

	protected float h;

	protected string i;

	protected bool j;

	protected string k;

	protected hg l;

	protected int m;

	protected n n;

	protected n o;

	protected n p;

	protected n q;

	protected string r;

	protected float s;

	protected Collection<float> t;

	protected Collection<float> u;

	protected int v;

	protected float[] w;

	protected float[] x;

	protected float[] y;

	protected float[] z;

	protected float[] aa;

	protected string[] ab;

	protected float[] ac;

	protected float[] ad;

	protected float[] ae;

	protected float[] af;

	protected float[] ag;

	protected b ah;

	protected Collection<float[]> ai;

	protected Collection<float[]> aj;

	protected Collection<float[]> ak;

	protected Collection<float[]> al;

	protected Collection<float[]> am;

	protected Collection<float[]> an;

	protected Collection<float[]> ao;

	protected Collection<float[]> ap;

	protected Collection<float[]> aq;

	protected Collection<float[]> ar;

	protected Collection<float[]> @as;

	protected Collection<float[]> at;

	protected Collection<float[]> au;

	protected Collection<float[]> av;

	protected Collection<float[]> aw;

	protected Collection<float[]> ax;

	protected Collection<ch> ay;

	protected Collection<ch> az;

	protected Collection<ga> a0;

	protected Collection<ga> a1;

	protected int[] a2;

	protected string a3;

	protected string a4;

	protected string a5;

	protected string a6;

	protected int[] a7;

	protected string[] a8;

	protected bool a9;

	protected DateTime ba;

	protected bool bb;

	protected float[] bc;

	protected bool[] bd;

	protected j be;

	protected a[] bf;

	protected bool[] bg;

	protected f bh;

	protected f bi;

	protected bool bj;

	protected bool bk;

	protected bool bl;

	protected int bm;

	protected int bn;

	protected e bo;

	protected bool bp;

	protected bool bq;

	protected float br;

	protected string bs;

	protected string bt;

	protected string bu;

	protected c bv;

	protected float[] bw;

	protected eo.a bx;

	protected g[] by;

	protected ix.c bz;

	protected h b0;

	protected i b1;

	protected ix.c b2;

	protected bool b3;

	protected bool b4;

	protected bool b5;

	protected int b6;

	protected string b7;

	protected int b8;

	public string b9;

	public string ca;

	public hg cb;

	public const int cc = 1000;

	public const int cd = 20;

	public const int ce = 1000;

	public const string cf = ".fibhi";

	public const int cg = 2;

	public const int ch = 1000;

	public const int ci = 30;

	public const int cj = 21000;

	protected const int ck = 31;

	protected int cl;

	[SpecialName]
	public bool cf(hg A_0)
	{
		if (Operators.CompareString(ca, A_0.cl(), TextCompare: false) == 0)
		{
			return this.m == A_0.c2();
		}
		return false;
	}

	[SpecialName]
	public bool cf(hc A_0)
	{
		if (Operators.CompareString(ca, A_0.ca, TextCompare: false) == 0)
		{
			return this.m == ((cc)A_0).m;
		}
		return false;
	}

	[SpecialName]
	public int cf()
	{
		return this.m;
	}

	public cc()
	{
		bh = new f();
		this.cl = 3;
		a3 = Guid.NewGuid().ToString();
		a4 = Guid.NewGuid().ToString();
		a5 = Guid.NewGuid().ToString();
		a6 = Guid.NewGuid().ToString();
	}

	public void cf(Collection<float> A_0, Collection<float[]> A_1, Collection<float[]> A_2, Collection<float[]> A_3, Collection<float[]> A_4, Collection<float[]> A_5, Collection<float[]> A_6, Collection<float[]> A_7, Collection<float[]> A_8, Collection<float> A_9, Collection<float[]> A_10, Collection<float[]> A_11, Collection<float[]> A_12, Collection<float[]> A_13, Collection<float[]> A_14, Collection<float[]> A_15, Collection<float[]> A_16, Collection<float[]> A_17, float A_18)
	{
		t = A_0;
		ai = A_1;
		aj = A_2;
		ak = A_3;
		al = A_4;
		am = A_5;
		ao = A_6;
		ap = A_7;
		an = A_8;
		u = A_9;
		aq = A_10;
		ar = A_11;
		@as = A_12;
		at = A_13;
		au = A_14;
		aw = A_15;
		ax = A_16;
		av = A_17;
		br = A_18;
	}

	public void cf(double A_0, float A_1, hr A_2, int A_3, int A_4, fy A_5, fy A_6, fy A_7, string A_8, float A_9, bool A_10, string A_11, hg A_12, string A_13, Collection<ch> A_14, Collection<ga> A_15, Collection<ch> A_16, int[] A_17, Collection<ga> A_18, int A_19, double[] A_20, double[] A_21, double[] A_22, double[] A_23, double[] A_24, double[] A_25, double[] A_26, double[] A_27, b A_28, c A_29, double[] A_30, double[] A_31, string[] A_32, bool A_33, bool A_34, int A_35, string A_36, eo.a A_37)
	{
		ba = DateAndTime.Now;
		bb = A_33;
		a9 = A_34;
		this.g = A_0;
		s = A_1;
		this.c = A_2;
		bm = A_3;
		bn = A_4;
		this.d = A_5;
		this.e = A_6;
		this.f = A_7;
		this.i = A_8;
		this.j = A_10;
		this.h = A_9;
		if (this.e != null)
		{
			be = global::cc.j.b;
		}
		else
		{
			be = global::cc.j.a;
		}
		r = A_11;
		b6 = A_35;
		b7 = A_36;
		this.l = new hg(A_12.dh(), A_12.cd());
		A_12.bu(ref this.l);
		this.m = this.l.c2();
		bx = global::eo.a.ao(A_12.dh().aw(), A_37);
		this.k = A_13;
		az = A_14;
		ay = A_16;
		a2 = A_17;
		a1 = A_15;
		a0 = A_18;
		checked
		{
			cp(A_19 + 2);
			if (A_20 != null && A_20.Length >= v)
			{
				int num = v - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					w[num2] = (float)A_20[num2];
					x[num2] = (float)A_21[num2];
					y[num2] = (float)(A_22[num2] * 100.0);
					if (y[num2] == -1f)
					{
						y[num2] = -0.9999999f;
					}
					z[num2] = (float)A_23[num2];
					aa[num2] = (float)A_24[num2];
					ac[num2] = (float)A_25[num2];
					ad[num2] = (float)A_26[num2];
					ae[num2] = (float)A_27[num2];
					af[num2] = (float)A_30[num2];
					ag[num2] = (float)(A_31[num2] * 100.0);
					ab[num2] = A_32[num2];
				}
			}
			ah = A_28;
			bv = A_29;
			cg();
		}
	}

	public void cf(hr A_0)
	{
		this.c = A_0;
	}

	public void cf(hr A_0, hg A_1)
	{
		this.c = A_0;
		this.l = A_1;
		this.m = this.l.c2();
		be = global::cc.j.b;
	}

	public void cf(hr A_0, string A_1, hg A_2, string A_3, float[] A_4, a[] A_5, e A_6, bool A_7, bool A_8, float[] A_9, g[] A_10, ix.c A_11, bool A_12, ix.c A_13, eo.a A_14)
	{
		ba = DateTime.Now;
		bb = A_7;
		this.c = A_0;
		be = global::cc.j.c;
		r = A_1;
		this.l = new hg(A_2.dh(), A_2.cd());
		A_2.bu(ref this.l);
		this.m = this.l.c2();
		this.k = A_3;
		bx = global::eo.a.ao(A_2.dh().aw(), A_14);
		if (A_4 != null)
		{
			bc = (float[])A_4.Clone();
		}
		if (A_5 != null)
		{
			bf = (a[])A_5.Clone();
		}
		bo = A_6;
		bp = A_8;
		eo.a a_ = null;
		if (A_2.ed().au(a_) && A_9 != null)
		{
			bw = A_9;
		}
		by = A_10;
		bz = A_11;
		b2 = A_13;
		b3 = A_12;
	}

	public void cf(h A_0)
	{
		b0 = A_0;
	}

	public void cf(i A_0)
	{
		b1 = A_0;
	}

	public static hc cf(hg A_0, bool A_1, bool A_2)
	{
		hc obj = new hc();
		hi hi2 = A_0.ed();
		obj.cp(checked(hi2.g7() + 2));
		((cc)obj).l = A_0;
		((cc)obj).m = ((cc)obj).l.c2();
		obj.bj = true;
		obj.bk = A_1;
		obj.bl = A_2;
		obj.b4 = A_0.b5();
		_ = null;
		return obj;
	}

	public static int cf(int[] A_0)
	{
		if (A_0 == null || A_0.Length == 0)
		{
			return 0;
		}
		int num = 0;
		do
		{
			if (num < A_0.Length)
			{
				if (A_0[num] >= 11)
				{
					return num;
				}
				num = checked(num + 1);
				continue;
			}
			return A_0.Length;
		}
		while (num <= 10);
		return 11;
	}

	protected void cg()
	{
		if (this.l.b3(this.m).g5())
		{
			hg obj = this.l;
			ref float[] a_ = ref w;
			int[] A_ = null;
			if (obj.bu(ref a_, ref A_, bx, this.c.af()))
			{
				this.n = global::cc.n.c;
			}
			else
			{
				this.n = global::cc.n.b;
			}
		}
		else
		{
			this.n = global::cc.n.a;
		}
	}

	public void cf(bool A_0, a4.a A_1)
	{
		d d10 = null;
		if (this.l.b3(this.m).d5(A_1))
		{
			Collection<d> collection = null;
			if (A_0 && co() != null)
			{
				collection = co().e();
			}
			else if (cp() != null)
			{
				collection = cp().e();
			}
			if (collection != null && collection.Count > 0)
			{
				foreach (d item in collection)
				{
					if (item.h() == (a4.a)global::e.a().ShowSpectrumCoordOption)
					{
						d10 = item;
					}
				}
			}
		}
		hi hi2 = this.l.b3(this.m);
		if (hi2.d5(A_1))
		{
			if (d10 == null)
			{
				this.o = global::cc.n.a;
				this.p = global::cc.n.a;
				this.q = global::cc.n.a;
				return;
			}
			if (d10.k() > hi2.en() || d10.k() < hi2.em())
			{
				this.o = global::cc.n.c;
			}
			else
			{
				this.o = global::cc.n.b;
			}
			if (d10.l() > hi2.ep() || d10.l() < hi2.eo())
			{
				this.p = global::cc.n.c;
			}
			else
			{
				this.p = global::cc.n.b;
			}
			if (d10.m() > hi2.er() || d10.m() < hi2.eq())
			{
				this.q = global::cc.n.c;
			}
			else
			{
				this.q = global::cc.n.b;
			}
		}
		else
		{
			this.o = global::cc.n.a;
			this.p = global::cc.n.a;
			this.q = global::cc.n.a;
		}
	}

	protected void cp(int A_0)
	{
		v = A_0;
		checked
		{
			w = new float[v - 1 + 1];
			x = new float[v - 1 + 1];
			y = new float[v - 1 + 1];
			z = new float[v - 1 + 1];
			aa = new float[v - 1 + 1];
			ab = new string[v - 1 + 1];
			ac = new float[v - 1 + 1];
			ad = new float[v - 1 + 1];
			ae = new float[v - 1 + 1];
			af = new float[v - 1 + 1];
			ag = new float[v - 1 + 1];
			int num = v - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				w[num2] = -1f;
				x[num2] = -1f;
				y[num2] = -1f;
				z[num2] = -1f;
				aa[num2] = -1f;
				ac[num2] = -1f;
				ad[num2] = -1f;
				ae[num2] = -1f;
				af[num2] = -1f;
				ag[num2] = -1f;
			}
		}
	}

	protected void cf(f A_0, ref int A_1, int A_2, int A_3, int A_4, int A_5, int A_6, int A_7, int A_8, int A_9, int A_10, int A_11, a4.a A_12, bool A_13)
	{
		d d10 = null;
		int num = A_1;
		bool flag = bj && bk;
		d d11 = null;
		if (A_0 != null && A_0.e().Count > 0)
		{
			Collection<d> collection = A_0.e();
			foreach (d item in collection)
			{
				if (item.h() == A_12)
				{
					d10 = item;
					break;
				}
			}
			if (A_12 == global::a4.a.d)
			{
				d11 = d10;
				d10 = null;
			}
			if (A_13 && d11 == null)
			{
				foreach (d item2 in collection)
				{
					if (item2.h() == global::a4.a.d)
					{
						d11 = item2;
						break;
					}
				}
			}
		}
		checked
		{
			if (d11 != null || d10 != null || flag)
			{
				if ((!bj && d10 != null) || (flag && A_12 != global::a4.a.d))
				{
					a4.a a10 = ((bj || d10 == null) ? A_12 : d10.h());
					a7[A_1] = A_5;
					switch (a10)
					{
					case global::a4.a.a:
						a7[A_1 + 1] = A_6;
						a7[A_1 + 2] = A_7;
						break;
					case global::a4.a.c:
						a7[A_1 + 1] = A_8;
						a7[A_1 + 2] = A_9;
						break;
					case global::a4.a.b:
						a7[A_1 + 1] = A_10;
						a7[A_1 + 2] = A_11;
						break;
					}
					A_1 += 3;
				}
				if ((!bj && d11 != null) || (flag && (A_13 || A_12 == global::a4.a.d)))
				{
					a7[A_1] = A_2;
					a7[A_1 + 1] = A_3;
					a7[A_1 + 2] = A_4;
					A_1 += 3;
				}
			}
			if (d10 != null || d11 != null)
			{
				if (d10 != null)
				{
					a8[num] = Conversions.ToString(d10.k());
					a8[num + 1] = Conversions.ToString(d10.l());
					a8[num + 2] = Conversions.ToString(d10.m());
					num += 3;
				}
				if (d11 != null)
				{
					a8[num] = Conversions.ToString(d11.k());
					a8[num + 1] = Conversions.ToString(d11.l());
					a8[num + 2] = Conversions.ToString(d11.m());
					num += 3;
				}
			}
		}
	}

	public void cf(a4.a A_0, bool A_1)
	{
		cf(A_0: false, A_0, A_1, A_3: false);
	}

	public void cf(bool A_0, a4.a A_1, bool A_2, bool A_3)
	{
		checked
		{
			a7 = new int[66 + v * 8 - 1 + 1];
			a8 = new string[66 + v * 8 - 1 + 1];
			hi hi2 = this.l.b3(this.m);
			int num = 0;
			int num2 = default(int);
			do
			{
				if (b6 > 0 || (num != 8 && num != 9))
				{
					switch (num)
					{
					case 0:
						if (!b4)
						{
							a8[num2] = Conversions.ToString(c2());
						}
						break;
					case 2:
						if (cb != null)
						{
							a8[num2] = cb.ci();
						}
						else
						{
							a8[num2] = cy().ci();
						}
						break;
					case 3:
						if (cn() == null)
						{
							a8[num2] = Conversions.ToString(DateTime.Now);
						}
						else
						{
							a8[num2] = Conversions.ToString(cn().cb());
						}
						break;
					case 4:
					{
						DateTime dateTime = ((cn() != null) ? cn().cb() : DateTime.Now);
						a8[num2] = Conversions.ToString(dateTime.ToOADate());
						break;
					}
					case 5:
						a8[num2] = de();
						break;
					case 6:
						if (cn() == null)
						{
							a8[num2] = string.Empty;
						}
						else
						{
							a8[num2] = cn().b5();
						}
						break;
					case 1:
						if (dd() == global::cc.n.a && this.o == global::cc.n.a && this.p == global::cc.n.a && this.q == global::cc.n.a)
						{
							a8[num2] = " ";
						}
						else if (dd() == global::cc.n.c || this.o == global::cc.n.c || this.p == global::cc.n.c || this.q == global::cc.n.c)
						{
							a8[num2] = "Alarm";
						}
						else
						{
							a8[num2] = "OK";
						}
						break;
					case 7:
					{
						if (be == global::cc.j.a || be == global::cc.j.b)
						{
							if ((double)s >= hi2.gq() && !hi2.au(di()))
							{
								if (be == global::cc.j.b)
								{
									if (this.g >= hi2.gr())
									{
										a8[num2] = "1";
									}
									else
									{
										a8[num2] = "0";
									}
								}
								else
								{
									a8[num2] = "1";
								}
							}
							else
							{
								a8[num2] = "0";
							}
							break;
						}
						float[] array = null;
						float[] array2 = null;
						if (bf != null)
						{
							array = new float[bf.Length + 1];
							array2 = new float[bf.Length + 1];
							int num3 = bf.Length - 1;
							for (int num4 = 0; num4 <= num3; num4++)
							{
								array[num4] = bf[num4].e();
								array2[num4] = bf[num4].f();
							}
						}
						if (!hi2.au(bc, array, array2))
						{
							a8[num2] = "1";
						}
						else
						{
							a8[num2] = "0";
						}
						break;
					}
					case 8:
						a8[num2] = b6.ToString();
						break;
					case 9:
						a8[num2] = b7;
						break;
					case 10:
						a8[num2] = Conversions.ToString(this.g);
						break;
					}
					a7[num2] = num;
					num2++;
				}
				num++;
			}
			while (num <= 10);
			b8 = num2;
			int A_4 = num2;
			if (bc != null || hi2.e3() > 0)
			{
				int num5 = hi2.e3() - 1;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					if (hi2.d9(num6))
					{
						a7[A_4] = num6 + 11;
						if (bc != null)
						{
							a8[A_4] = Conversions.ToString(bc[num6]);
						}
						A_4++;
					}
				}
			}
			if (bf != null || hi2.e9() > 0)
			{
				int num7 = hi2.e9() - 1;
				for (int num6 = 0; num6 <= num7; num6++)
				{
					if (hi2.ei(num6))
					{
						a7[A_4] = 23 + num6 * 2;
						if (bf != null)
						{
							a8[A_4] = Conversions.ToString(bf[num6].e());
						}
						A_4++;
						a7[A_4] = 23 + num6 * 2 + 1;
						if (bf != null)
						{
							a8[A_4] = Conversions.ToString(bf[num6].f());
						}
						A_4++;
					}
				}
			}
			cf(bh, ref A_4, 35, 36, 37, 38, 39, 40, 43, 44, 41, 42, A_1, A_2);
			if (!bj || bl)
			{
				cf(bi, ref A_4, 45, 46, 47, 48, 49, 50, 53, 54, 51, 52, A_1, A_2);
			}
			if (by != null)
			{
				if (hi2.ex() && by[0] != null)
				{
					a7[A_4] = 55;
					a8[A_4] = by[0].d().ToString();
					A_4++;
				}
				if (hi2.ey() && by[1] != null)
				{
					a7[A_4] = 56;
					a8[A_4] = by[1].d().ToString();
					A_4++;
				}
				if (hi2.ez() && by[2] != null)
				{
					a7[A_4] = 57;
					a8[A_4] = by[2].d().ToString();
					A_4++;
				}
				_ = null;
			}
			if (bz != null || hi2.e0())
			{
				a7[A_4] = 58;
				if (bz != null)
				{
					a8[A_4] = bz.a.ToString();
				}
				A_4++;
			}
			if (b0 != null)
			{
				a7[A_4] = 59;
				a8[A_4] = b0.c.ToString();
				A_4++;
				a7[A_4] = 60;
				a8[A_4] = b0.a.ToString();
				A_4++;
				a7[A_4] = 61;
				a8[A_4] = b0.b.ToString();
				A_4++;
			}
			if (b1 != null)
			{
				a7[A_4] = 62;
				a8[A_4] = b1.a.ToString();
				A_4++;
				a7[A_4] = 63;
				a8[A_4] = b1.b.ToString();
				A_4++;
				a7[A_4] = 64;
				a8[A_4] = b1.c.ToString();
				A_4++;
			}
			if (b2 != null || (hi2.e1() && A_3))
			{
				a7[A_4] = 65;
				if (b2 != null)
				{
					a8[A_4] = b2.a.ToString();
				}
				A_4++;
			}
			eo.a a_ = null;
			bool a_2 = this.l.dh().ax(a_);
			bool a_3 = this.l.dh().az(a_);
			eo.b a_4 = ((this.c != null) ? this.l.dh().at(a_, this.c.af()) : this.l.dh().at(a_, cy().d0().q()));
			int num8 = 21000 * (this.m - 1);
			int num9 = 0;
			gc gc2 = hi2.eu(0);
			if (gc2.ah(a_2) || gc2.aj(a_2))
			{
				num9++;
			}
			gc2 = null;
			int num10 = cm() - 1;
			for (int num11 = 1; num11 <= num10; num11++)
			{
				gc gc3 = hi2.eu(num11);
				int num12 = num8 + 1000 + 20 * num11;
				int num13 = num8 + 1000 + 19980;
				if (num11 < cm() - 1 && (w[num11] != -1f || A_0) && gc3.af(a_4))
				{
					a7[A_4] = num12 + 0;
					a8[A_4] = w[num11].ToString();
					A_4++;
				}
				if (ac[num11] != -1f || (A_0 && gc3.ah(a_2)))
				{
					if (num11 < cm() - 1)
					{
						a7[A_4] = num12 + 1;
					}
					else
					{
						a7[A_4] = num13 + 1;
					}
					a8[A_4] = Conversions.ToString(ac[num11]);
					A_4++;
				}
				if (ad[num11] != -1f || (A_0 && gc3.aj(a_2)))
				{
					if (num11 < cm() - 1)
					{
						a7[A_4] = num12 + 2;
					}
					else
					{
						a7[A_4] = num13 + 2;
					}
					a8[A_4] = Conversions.ToString(ad[num11]);
					A_4++;
				}
				if ((ae[num11] != -1f || A_0) && gc3.al(a_2))
				{
					if (num11 < cm() - 1)
					{
						a7[A_4] = num12 + 3;
					}
					else
					{
						a7[A_4] = num13 + 3;
					}
					a8[A_4] = Conversions.ToString(ae[num11]);
					A_4++;
				}
				if (num11 < cm() - 1)
				{
					if ((x[num11] != -1f || A_0) && gc3.ap(a_3))
					{
						a7[A_4] = num12 + 4;
						a8[A_4] = x[num11].ToString();
						A_4++;
					}
					if (y != null && (y[num11] != -1f || A_0) && gc3.an(a_2))
					{
						a7[A_4] = num12 + 5;
						a8[A_4] = y[num11].ToString();
						A_4++;
					}
				}
				if (this.l.dh().a8() && af != null && (af[num11] != -1f || A_0) && gc3.ah(a_2) && ay != null && ay[num9].af() == hd.a.k)
				{
					if (num11 < cm() - 1)
					{
						a7[A_4] = num12 + 6;
					}
					else
					{
						a7[A_4] = num13 + 6;
					}
					a8[A_4] = Conversions.ToString(af[num11]).ToString();
					A_4++;
				}
				if (ag != null && (ag[num11] != -1f || A_0) && gc3.ah(a_2) && ay != null && ay[num9].af() == hd.a.n)
				{
					if (num11 < cm() - 1)
					{
						a7[A_4] = num12 + 7;
					}
					else
					{
						a7[A_4] = num13 + 7;
					}
					a8[A_4] = Conversions.ToString(ag[num11]).ToString();
					A_4++;
				}
			}
			ref string[] reference = ref a8;
			reference = (string[])Utils.CopyArray(reference, new string[A_4 - 1 + 1]);
			ref int[] reference2 = ref a7;
			reference2 = (int[])Utils.CopyArray(reference2, new int[A_4 - 1 + 1]);
		}
	}

	public ga cf(string A_0, int A_1)
	{
		ga result = null;
		try
		{
			if (string.Compare(A_0, a5) == 0)
			{
				result = az[A_1];
			}
			else if (string.Compare(A_0, a3) == 0)
			{
				result = ay[A_1];
			}
			else if (string.Compare(A_0, a6) == 0)
			{
				result = a1[A_1];
			}
			else if (string.Compare(A_0, a4) == 0)
			{
				result = a0[A_1];
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static q co(int A_0)
	{
		int num = A_0 % 21000;
		if (num == 4 || num >= 66)
		{
			return global::cc.q.b;
		}
		if (num == 3)
		{
			return global::cc.q.c;
		}
		return global::cc.q.a;
	}

	public static string cg(int A_0, bool A_1, h4 A_2, bool A_3)
	{
		return cf(A_0, A_1, A_2, A_3, A_4: false);
	}

	public static string cf(int A_0, bool A_1, h4 A_2, bool A_3)
	{
		return cf(A_0, A_1, A_2, A_3, A_4: true);
	}

	protected static string cf(int A_0, bool A_1, h4 A_2, bool A_3, bool A_4)
	{
		string text = "";
		string text2 = (A_1 ? h4.e(A_2, false, false) : null);
		int num = A_0 % 21000;
		checked
		{
			if (num >= 0 && num < 66)
			{
				string text3;
				string text4;
				if (Conversions.ToBoolean(global::e.a().GraphMeasYLabelPercent[0]) && A_3)
				{
					text3 = " (R%)";
					text4 = " (%)";
				}
				else
				{
					text3 = " (R)";
					text4 = "";
				}
				if (A_4)
				{
					int num2 = num;
					if (num2 >= 35 && num2 <= 54)
					{
						string A_5 = "CIEColorTitle";
						text = hu.a(ref A_5) + " ";
					}
				}
				int num3 = num;
				switch (num3)
				{
				case 0:
				{
					string A_5 = "GOF";
					text = hu.a(ref A_5);
					break;
				}
				case 2:
				{
					string A_5 = "Recipe";
					text = hu.a(ref A_5);
					break;
				}
				case 3:
				{
					string A_5 = "DateTime";
					text = hu.a(ref A_5);
					break;
				}
				case 4:
				{
					string A_5 = "ElapsedTime";
					text = hu.a(ref A_5);
					break;
				}
				case 5:
				{
					string A_5 = "UserID";
					text = hu.a(ref A_5);
					break;
				}
				case 6:
				{
					string A_5 = "SampleID";
					text = hu.a(ref A_5);
					break;
				}
				case 1:
				{
					string A_5 = "Result";
					text = hu.a(ref A_5);
					break;
				}
				case 8:
				{
					string A_5 = "SlotNumber";
					text = hu.a(ref A_5);
					break;
				}
				case 9:
				{
					string A_5 = "LotID";
					text = hu.a(ref A_5);
					break;
				}
				case 10:
					if (A_4)
					{
						string A_5 = "NormFFTIntensity";
						text = hu.a(ref A_5);
					}
					else
					{
						string A_5 = "NormFFTIntensityAbbrv";
						text = hu.a(ref A_5);
					}
					break;
				case 11:
				case 12:
				case 13:
				case 14:
				case 15:
				case 16:
				case 17:
				case 18:
				case 19:
				case 20:
				case 21:
				case 22:
					if (A_4)
					{
						string A_5 = "RegionMeanLabel";
						text = string.Format(hu.a(ref A_5), (num - 11 + 1).ToString()) + text4;
					}
					else
					{
						string A_5 = "RegionMeanLabelAbbrev";
						text = string.Format(hu.a(ref A_5), (num - 11 + 1).ToString()) + text4;
					}
					break;
				default:
					if (num3 >= 23 && num3 <= 34)
					{
						if (unchecked(checked(num - 23) % 2) == 0)
						{
							if (A_4)
							{
								string A_5 = "ExtremaLabel";
								text = string.Format(hu.a(ref A_5), (unchecked(checked(num - 23) / 2) + 1).ToString()) + " (nm)";
							}
							else
							{
								string A_5 = "ExtremaLabelAbbrev";
								text = string.Format(hu.a(ref A_5), (unchecked(checked(num - 23) / 2) + 1).ToString()) + " (nm)";
							}
						}
						else if (A_4)
						{
							string A_5 = "ExtremaLabel";
							text = string.Format(hu.a(ref A_5), (unchecked(checked(num - 24) / 2) + 1).ToString()) + text3;
						}
						else
						{
							string A_5 = "ExtremaLabelAbbrev";
							text = string.Format(hu.a(ref A_5), (unchecked(checked(num - 24) / 2) + 1).ToString()) + text3;
						}
						break;
					}
					switch (num3)
					{
					case 39:
					{
						string text5 = text;
						string A_5 = "ColorA";
						text = text5 + hu.a(ref A_5);
						break;
					}
					case 40:
					{
						string text24 = text;
						string A_5 = "ColorB";
						text = text24 + hu.a(ref A_5);
						break;
					}
					case 38:
					{
						string text23 = text;
						string A_5 = "ColorL";
						text = text23 + hu.a(ref A_5);
						break;
					}
					case 43:
					{
						string text22 = text;
						string A_5 = "ColorC";
						text = text22 + hu.a(ref A_5);
						break;
					}
					case 44:
					{
						string text21 = text;
						string A_5 = "ColorH";
						text = text21 + hu.a(ref A_5);
						break;
					}
					case 41:
					{
						string text20 = text;
						string A_5 = "ColorU";
						text = text20 + hu.a(ref A_5);
						break;
					}
					case 42:
					{
						string text19 = text;
						string A_5 = "ColorV";
						text = text19 + hu.a(ref A_5);
						break;
					}
					case 35:
					{
						string text18 = text;
						string A_5 = "ColorX";
						text = text18 + hu.a(ref A_5);
						break;
					}
					case 36:
					{
						string text17 = text;
						string A_5 = "ColorY";
						text = text17 + hu.a(ref A_5);
						break;
					}
					case 37:
					{
						string text16 = text;
						string A_5 = "ColorZ";
						text = text16 + hu.a(ref A_5);
						break;
					}
					case 49:
					{
						string text15 = text;
						string A_5 = "ColorA2";
						text = text15 + hu.a(ref A_5);
						break;
					}
					case 50:
					{
						string text14 = text;
						string A_5 = "ColorB2";
						text = text14 + hu.a(ref A_5);
						break;
					}
					case 48:
					{
						string text13 = text;
						string A_5 = "ColorL2";
						text = text13 + hu.a(ref A_5);
						break;
					}
					case 53:
					{
						string text12 = text;
						string A_5 = "ColorC2";
						text = text12 + hu.a(ref A_5);
						break;
					}
					case 54:
					{
						string text11 = text;
						string A_5 = "ColorH2";
						text = text11 + hu.a(ref A_5);
						break;
					}
					case 51:
					{
						string text10 = text;
						string A_5 = "ColorU2";
						text = text10 + hu.a(ref A_5);
						break;
					}
					case 52:
					{
						string text9 = text;
						string A_5 = "ColorV2";
						text = text9 + hu.a(ref A_5);
						break;
					}
					case 45:
					{
						string text8 = text;
						string A_5 = "ColorX2";
						text = text8 + hu.a(ref A_5);
						break;
					}
					case 46:
					{
						string text7 = text;
						string A_5 = "ColorY2";
						text = text7 + hu.a(ref A_5);
						break;
					}
					case 47:
					{
						string text6 = text;
						string A_5 = "ColorZ2";
						text = text6 + hu.a(ref A_5);
						break;
					}
					case 7:
						text += "Valid";
						break;
					case 55:
						text = ((!A_4) ? (text + "SUVA" + text4) : (text + "Solar-UVA" + text4));
						break;
					case 56:
						text = ((!A_4) ? (text + "SUVB" + text4) : (text + "Solar-UVB" + text4));
						break;
					case 57:
						text = ((!A_4) ? (text + "SUVAB" + text4) : (text + "Solar-UVAB" + text4));
						break;
					case 58:
						text = ((!A_4) ? (text + "LumRefl" + text4) : (text + "Luminous Reflectance" + text4));
						break;
					case 59:
						text = ((!A_4) ? (text + "FPDip (nm)") : (text + "FP Dip Wavelength (nm)"));
						break;
					case 60:
						text = ((!A_4) ? (text + "FPLower (nm)") : (text + "FP Lower Wavelength (nm)"));
						break;
					case 61:
						text = ((!A_4) ? (text + "FPUpper (nm)") : (text + "FP Upper Wavelength (nm)"));
						break;
					case 62:
						text = ((!A_4) ? (text + "DBRCenter (nm)") : (text + "DBR Center Wavelength (nm)"));
						break;
					case 63:
						text = ((!A_4) ? (text + "DBRLower (nm)") : (text + "DBR Lower Wavelength (nm)"));
						break;
					case 64:
						text = ((!A_4) ? (text + "DBRUpper (nm)") : (text + "DBR Upper Wavelength (nm)"));
						break;
					case 65:
						text = ((!A_4) ? (text + "YID1925") : (text + "YI D1925"));
						break;
					}
					break;
				}
			}
			else
			{
				_ = 1 + unchecked(A_0 / 21000);
				text = string.Empty;
				int num4 = num - 1000;
				unchecked
				{
					int num5 = num4 % 20;
					int num6 = num4 / 20;
					if (num6 == 999)
					{
						if (A_4)
						{
							string text25 = text;
							string A_5 = "Substrate";
							text = text25 + hu.a(ref A_5);
						}
						else
						{
							string text26 = text;
							string A_5 = "SubstrateAbbrev";
							text = text26 + hu.a(ref A_5);
						}
					}
					else if (A_4)
					{
						string text27 = text;
						string A_5 = "LayerLeading";
						text = text27 + string.Format(hu.a(ref A_5), num6);
					}
					else
					{
						string text28 = text;
						string A_5 = "LayerLeadingAbbrevFmt";
						text = text28 + string.Format(hu.a(ref A_5), num6);
					}
					switch (num5)
					{
					case 0:
						if (A_4)
						{
							string text43 = text;
							string A_5 = "LayerThickness";
							text = text43 + hu.a(ref A_5);
						}
						else
						{
							string text44 = text;
							string A_5 = "LayerThicknessAbbrv";
							text = text44 + hu.a(ref A_5);
						}
						if (A_1)
						{
							text = text + " (" + text2 + ")";
						}
						break;
					case 1:
						if (A_4)
						{
							string text37 = text;
							string A_5 = "LayerN";
							text = text37 + hu.a(ref A_5);
						}
						else
						{
							string text38 = text;
							string A_5 = "LayerNAbbrv";
							text = text38 + hu.a(ref A_5);
						}
						break;
					case 2:
						if (A_4)
						{
							string text41 = text;
							string A_5 = "LayerK";
							text = text41 + hu.a(ref A_5);
						}
						else
						{
							string text42 = text;
							string A_5 = "LayerKAbbrv";
							text = text42 + hu.a(ref A_5);
						}
						break;
					case 6:
						if (A_4)
						{
							string text35 = text;
							string A_5 = "Crystallinity";
							text = text35 + hu.a(ref A_5);
						}
						else
						{
							string text36 = text;
							string A_5 = "LayerCrystallinityAbbrev";
							text = text36 + hu.a(ref A_5);
						}
						if (A_1)
						{
							text += " (%)";
						}
						break;
					case 7:
						if (A_4)
						{
							string text31 = text;
							string A_5 = "Porosity";
							text = text31 + hu.a(ref A_5);
						}
						else
						{
							string text32 = text;
							string A_5 = "LayerPorosityAbbrev";
							text = text32 + hu.a(ref A_5);
						}
						if (A_1)
						{
							text += " (%)";
						}
						break;
					case 3:
						if (A_4)
						{
							string text33 = text;
							string A_5 = "LayerRoughness";
							text = text33 + hu.a(ref A_5);
						}
						else
						{
							string text34 = text;
							string A_5 = "LayerRoughnessAbbrv";
							text = text34 + hu.a(ref A_5);
						}
						if (A_1)
						{
							text = text + " (" + text2 + ")";
						}
						break;
					case 4:
						if (A_4)
						{
							string text39 = text;
							string A_5 = "LayerThicknessNonuniformity";
							text = text39 + hu.a(ref A_5);
						}
						else
						{
							string text40 = text;
							string A_5 = "LayerThicknessNonuniformityAbbrev";
							text = text40 + hu.a(ref A_5);
						}
						if (A_1)
						{
							text = text + " (" + text2 + ")";
						}
						break;
					case 5:
						if (A_4)
						{
							string text29 = text;
							string A_5 = "LayerGrading";
							text = text29 + hu.a(ref A_5);
						}
						else
						{
							string text30 = text;
							string A_5 = "LayerGradingAbbrev";
							text = text30 + hu.a(ref A_5);
						}
						if (A_1)
						{
							text += " (%)";
						}
						break;
					}
				}
			}
			return text;
		}
	}

	public static bool cf(m A_0)
	{
		switch (A_0)
		{
		case global::cc.m.a:
		case global::cc.m.d:
		case global::cc.m.e:
			return true;
		default:
			return false;
		}
	}

	public static bool cn(int A_0)
	{
		if (A_0 % 21000 < 1000)
		{
			return false;
		}
		return cf(ch(A_0));
	}

	public static bool cm(int A_0)
	{
		if (cn(A_0))
		{
			return false;
		}
		if (A_0 >= 11 && A_0 <= 22)
		{
			return true;
		}
		switch (A_0)
		{
		case 24:
		case 26:
		case 28:
		case 30:
		case 32:
		case 34:
			return true;
		case 55:
		case 56:
		case 57:
		case 58:
			return true;
		default:
			return false;
		}
	}

	public static bool cl(int A_0)
	{
		return A_0 % 21000 < 11;
	}

	public static bool ck(int A_0)
	{
		int num = A_0 % 21000;
		if (num >= 11)
		{
			return num < 66;
		}
		return false;
	}

	public static bool cj(int A_0)
	{
		return A_0 % 21000 >= 1000;
	}

	public static int ci(int A_0)
	{
		return A_0 / 21000;
	}

	public static m ch(int A_0)
	{
		int num = A_0 % 21000;
		if (num < 1000)
		{
			throw new ApplicationException("Invalid ParamID in FIControlPanelHistory.GetLayerParamType");
		}
		return (m)(checked(num - 1000) % 20);
	}

	public static k cg(int A_0)
	{
		int num = A_0 % 21000;
		if (num >= 11)
		{
			throw new ApplicationException("Invalid ParamID in FIControlPanelHistory.GetSiteMeasParamType");
		}
		return (k)num;
	}

	public static int cf(int A_0)
	{
		return checked(unchecked(A_0 % 21000) - 1000) / 20;
	}

	public static string cf(float A_0, int A_1, h4 A_2, short A_3)
	{
		string result = "";
		if ((A_1 >= 11 && A_1 <= 22) || A_1 == 24 || A_1 == 26 || A_1 == 28 || A_1 == 30 || A_1 == 32 || A_1 == 34 || A_1 == 55 || A_1 == 56 || A_1 == 57 || A_1 == 58)
		{
			result = ((!Conversions.ToBoolean(global::e.a().GraphMeasYLabelPercent[0])) ? Strings.Format(A_0, "0.0000") : Strings.Format(A_0 * 100f, "0.0000"));
		}
		else
		{
			switch (A_1)
			{
			case 23:
			case 25:
			case 27:
			case 29:
			case 31:
			case 33:
				result = hg.bu(4, A_0, A_2, A_3);
				break;
			case 35:
			case 36:
			case 37:
			case 38:
			case 39:
			case 40:
			case 41:
			case 42:
			case 43:
			case 44:
			case 45:
			case 46:
			case 47:
			case 48:
			case 49:
			case 50:
			case 51:
			case 52:
			case 53:
			case 54:
				result = Strings.Format(A_0, "0.0000");
				break;
			case 59:
			case 60:
			case 61:
			case 62:
			case 63:
			case 64:
				result = Strings.Format(A_0, "####.##");
				break;
			case 65:
				result = Strings.Format(A_0, "0.##");
				break;
			}
		}
		return result;
	}

	public static int[] cg(int[] A_0, int[] A_1)
	{
		checked
		{
			int[] array = new int[A_0.Length + A_1.Length - 1 + 1];
			int num = A_1.Length - 1;
			int num2;
			for (num2 = 0; num2 <= num; num2++)
			{
				array[num2] = A_1[num2];
			}
			int num3 = num2;
			int num4 = A_0.Length - 1;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				bool flag = false;
				int num6 = num3 - 1;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					if (array[num7] == A_0[num5])
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					array[num2] = A_0[num5];
					num2++;
				}
			}
			array = (int[])Utils.CopyArray(array, new int[num2 - 1 + 1]);
			Array.Sort(array);
			return array;
		}
	}

	public static bool cf(int[] A_0, int[] A_1)
	{
		if (A_0.Length != A_1.Length)
		{
			return false;
		}
		checked
		{
			int num = A_0.Length - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (A_0[num2] != A_1[num2])
				{
					return false;
				}
			}
			return true;
		}
	}

	public static void cf(string A_0, int A_1, Collection<hc> A_2, Collection<cb> A_3, DateTime A_4, bool A_5, int A_6, ref hc A_7)
	{
		BinaryWriter binaryWriter = null;
		checked
		{
			try
			{
				binaryWriter = new BinaryWriter(File.Open(A_0, FileMode.Create));
				long position = binaryWriter.BaseStream.Position;
				int num = 0;
				if (A_6 > A_2.Count)
				{
					A_6 = A_2.Count;
				}
				if (A_5)
				{
					num = A_2.Count - A_6;
				}
				binaryWriter.Write(position);
				binaryWriter.Write(A_1);
				binaryWriter.Write(1);
				binaryWriter.Write(A_5 ? A_6 : A_2.Count);
				binaryWriter.Write(A_4.ToBinary());
				int num2 = num;
				int num3 = A_2.Count - 1;
				for (int num4 = num2; num4 <= num3; num4++)
				{
					A_2[num4].cf(binaryWriter);
				}
				if (A_2.Count >= 1)
				{
					A_7 = A_2[A_2.Count - 1];
				}
				long position2 = binaryWriter.BaseStream.Position;
				binaryWriter.Write(A_3.Count);
				int num5 = 0;
				int num6 = A_3.Count - 1;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					if (A_5)
					{
						bool flag = false;
						int num8 = num - 1;
						for (int num9 = 0; num9 <= num8; num9++)
						{
							foreach (string item in A_3[num7].i())
							{
								if (Operators.CompareString(item, A_2[num9].et(), TextCompare: false) == 0)
								{
									flag = true;
									break;
								}
							}
						}
						if (!flag)
						{
							A_3[num7].g(binaryWriter);
							num5++;
						}
					}
					else
					{
						A_3[num7].g(binaryWriter);
					}
				}
				long position3 = binaryWriter.BaseStream.Position;
				binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);
				binaryWriter.Write(position3);
				if (A_5 && A_3.Count != num5)
				{
					binaryWriter.BaseStream.Seek(position2, SeekOrigin.Begin);
					binaryWriter.Write(num5);
				}
				binaryWriter.BaseStream.Seek(position3, SeekOrigin.Begin);
			}
			finally
			{
				binaryWriter?.Close();
			}
		}
	}

	public static void cf(BinaryReader A_0, ref long A_1, ref int A_2, ref int A_3, ref int A_4, ref DateTime A_5)
	{
		A_1 = A_0.ReadInt64();
		A_2 = A_0.ReadInt32();
		A_3 = A_0.ReadInt32();
		if (2 >= A_3)
		{
			A_4 = checked(A_0.ReadInt32() - 1);
			A_5 = DateTime.FromBinary(A_0.ReadInt64());
		}
	}

	public static void cf(string A_0, eo A_1, int A_2, hc A_3)
	{
		BinaryReader binaryReader = null;
		BinaryWriter binaryWriter = null;
		checked
		{
			string text;
			try
			{
				int A_4 = 0;
				int A_5 = 0;
				binaryReader = new BinaryReader(File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read));
				int A_7 = default(int);
				DateTime A_8 = default(DateTime);
				long A_6 = default(long);
				cf(binaryReader, ref A_6, ref A_5, ref A_4, ref A_7, ref A_8);
				if (2 < A_4 || A_2 > A_7)
				{
					return;
				}
				text = Path.Combine(Path.GetDirectoryName(A_0), i3.a(A_0, DateAndTime.Now));
				binaryWriter = new BinaryWriter(File.Open(text, FileMode.Create));
				long position = binaryWriter.BaseStream.Position;
				binaryWriter.Write(position);
				binaryWriter.Write(A_5);
				binaryWriter.Write(A_4);
				binaryWriter.Write(A_7 + 1);
				binaryWriter.Write(A_8.ToBinary());
				int num = A_7;
				for (int num2 = 0; num2 <= num; num2++)
				{
					hc hc2 = new hc();
					hc2.cf(binaryReader, A_1, hg.b4());
					if (num2 == A_2)
					{
						A_3.cf(binaryWriter);
					}
					else
					{
						hc2.cf(binaryWriter);
					}
				}
				if (A_5 > 1)
				{
					int num3 = binaryReader.ReadInt32();
					binaryWriter.Write(num3);
					int num4 = num3;
					for (int num5 = 1; num5 <= num4; num5++)
					{
						cb obj = new cb();
						obj.g(binaryReader);
						obj.g(binaryWriter);
					}
				}
				A_6 = binaryWriter.BaseStream.Position;
				binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);
				binaryWriter.Write(A_6);
				binaryWriter.BaseStream.Seek(A_6, SeekOrigin.Begin);
			}
			finally
			{
				binaryReader?.Close();
				binaryWriter?.Close();
			}
			File.Delete(A_0);
			File.Copy(text, A_0);
			File.Delete(text);
		}
	}

	public static hc cf(string A_0, long A_1, eo A_2, hg.j A_3, int A_4, ref string A_5)
	{
		BinaryReader binaryReader = null;
		A_5 = null;
		checked
		{
			hc result;
			try
			{
				int A_6 = 0;
				int A_7 = 0;
				try
				{
					binaryReader = new BinaryReader(File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read));
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex3 = ex2;
					A_5 = "The specified history file " + A_0 + " could not be opened for read.";
					result = null;
					ProjectData.ClearProjectError();
					goto end_IL_0006;
				}
				long A_8 = default(long);
				int A_9 = default(int);
				DateTime A_10 = default(DateTime);
				cf(binaryReader, ref A_8, ref A_7, ref A_6, ref A_9, ref A_10);
				if (2 >= A_6)
				{
					if (A_4 > A_9)
					{
						A_5 = "History file does not have specified record index " + Conversions.ToString(A_4) + ".";
						result = null;
					}
					else
					{
						int num = A_4 - 1;
						for (int num2 = 0; num2 <= num; num2++)
						{
							cf(binaryReader);
						}
						hc obj = new hc();
						obj.cf(binaryReader, A_2, A_3);
						obj.cn().r(A_1);
						result = obj;
					}
				}
				else
				{
					A_5 = "The specified history file: " + A_0 + " is version " + Conversions.ToString(A_7) + " and is not compatible with this version of software.";
					result = null;
				}
				end_IL_0006:;
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex5 = ex4;
				A_5 = "The specified history file " + A_0 + " is corrupt.";
				result = null;
				ProjectData.ClearProjectError();
			}
			finally
			{
				binaryReader?.Close();
			}
			return result;
		}
	}

	public static void cf(BinaryReader A_0)
	{
		i3.a(A_0, cg, "MeasResults", 31);
	}

	private static void cg(BinaryReader A_0, int A_1)
	{
	}

	protected void cf(ref int[] A_0, BinaryReader A_1)
	{
		int num = A_1.ReadInt32();
		checked
		{
			if (num > 0)
			{
				if (A_0 == null || A_0.GetUpperBound(0) != num - 1)
				{
					A_0 = new int[num - 1 + 1];
				}
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					A_0[num3] = A_1.ReadInt32();
				}
			}
			else
			{
				A_0 = null;
			}
		}
	}

	protected void cf(ref string[] A_0, BinaryReader A_1)
	{
		int num = A_1.ReadInt32();
		checked
		{
			if (num > 0)
			{
				if (A_0 == null || A_0.GetUpperBound(0) != num - 1)
				{
					A_0 = new string[num - 1 + 1];
				}
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					A_0[num3] = A_1.ReadString();
				}
			}
			else
			{
				A_0 = null;
			}
		}
	}

	protected void cf(ref bool[] A_0, BinaryReader A_1)
	{
		int num = A_1.ReadInt32();
		checked
		{
			if (num > 0)
			{
				if (A_0 == null || A_0.GetUpperBound(0) != num - 1)
				{
					A_0 = new bool[num - 1 + 1];
				}
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					A_0[num3] = A_1.ReadBoolean();
				}
			}
			else
			{
				A_0 = null;
			}
		}
	}

	protected void cf(ref a[] A_0, BinaryReader A_1)
	{
		int num = A_1.ReadInt32();
		checked
		{
			if (num > 0)
			{
				if (A_0 == null || A_0.GetUpperBound(0) != num - 1)
				{
					A_0 = new a[num - 1 + 1];
				}
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					ref a reference = ref A_0[num3];
					reference.a = A_1.ReadSingle();
					reference.b = A_1.ReadSingle();
				}
			}
			else
			{
				A_0 = null;
			}
		}
	}

	protected void cf(ref Collection<d> A_0, BinaryReader A_1)
	{
		int num = A_1.ReadInt32();
		checked
		{
			if (num > 0)
			{
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					d d10 = new d();
					d10.h(A_1);
					A_0.Add(d10);
				}
			}
			else
			{
				A_0 = new Collection<d>();
			}
		}
	}

	protected void cf(ref Collection<ga> A_0, BinaryReader A_1, bool A_2)
	{
		int num = A_1.ReadInt32();
		checked
		{
			if (num > 0)
			{
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (!A_2 || A_1.ReadBoolean())
					{
						ga ga2 = new ga();
						ga2.l(ref A_1);
						A_0.Add(ga2);
					}
					else
					{
						A_0.Add(null);
					}
				}
			}
			else
			{
				A_0 = null;
			}
		}
	}

	protected void cf(ref Collection<ch> A_0, BinaryReader A_1, bool A_2)
	{
		int num = A_1.ReadInt32();
		checked
		{
			if (num > 0)
			{
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (!A_2 || A_1.ReadBoolean())
					{
						ch ch2 = new ch();
						ch2.l(ref A_1);
						A_0.Add(ch2);
					}
					else
					{
						A_0.Add(null);
					}
				}
			}
			else
			{
				A_0 = null;
			}
		}
	}

	protected void cf(ref fy A_0, BinaryReader A_1)
	{
		if (A_1.ReadBoolean())
		{
			A_0.l(ref A_1);
		}
		else
		{
			A_0 = null;
		}
	}

	protected void cf(ref hr A_0, BinaryReader A_1)
	{
		if (A_1.ReadBoolean())
		{
			A_0.l(ref A_1);
		}
		else
		{
			A_0 = null;
		}
	}

	protected void cf(fy A_0, BinaryWriter A_1)
	{
		if (A_0 != null)
		{
			A_1.Write(value: true);
			A_0.m(ref A_1);
		}
		else
		{
			A_1.Write(value: false);
		}
	}

	protected void cf(int[] A_0, BinaryWriter A_1)
	{
		if (A_0 != null)
		{
			A_1.Write(A_0.Length);
			foreach (int value in A_0)
			{
				A_1.Write(value);
			}
		}
		else
		{
			A_1.Write(0);
		}
	}

	protected void cf(string[] A_0, BinaryWriter A_1)
	{
		checked
		{
			if (A_0 != null)
			{
				int num = A_0.Length;
				A_1.Write(num);
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (A_0[num3] == null)
					{
						A_0[num3] = string.Empty;
					}
					A_1.Write(A_0[num3]);
				}
			}
			else
			{
				A_1.Write(0);
			}
		}
	}

	protected void cf(bool[] A_0, BinaryWriter A_1)
	{
		if (A_0 != null)
		{
			A_1.Write(A_0.Length);
			for (int num = 0; num < A_0.Length; num = checked(num + 1))
			{
				int value = 0 - (A_0[num] ? 1 : 0);
				A_1.Write(value);
			}
		}
		else
		{
			A_1.Write(0);
		}
	}

	protected void cf(a[] A_0, BinaryWriter A_1)
	{
		if (A_0 != null)
		{
			A_1.Write(A_0.Length);
			for (int num = 0; num < A_0.Length; num = checked(num + 1))
			{
				a a10 = A_0[num];
				A_1.Write(a10.a);
				A_1.Write(a10.b);
			}
		}
		else
		{
			A_1.Write(0);
		}
	}

	protected void cf(Collection<d> A_0, BinaryWriter A_1)
	{
		if (A_0 != null && A_0.Count > 0)
		{
			A_1.Write(A_0.Count);
			{
				foreach (d item in A_0)
				{
					item.h(A_1);
				}
				return;
			}
		}
		A_1.Write(0);
	}

	protected void cf(Collection<ga> A_0, BinaryWriter A_1)
	{
		if (A_0 != null && A_0.Count > 0)
		{
			A_1.Write(A_0.Count);
			{
				foreach (ga item in A_0)
				{
					if (item == null)
					{
						A_1.Write(value: false);
						continue;
					}
					A_1.Write(value: true);
					item.m(ref A_1);
				}
				return;
			}
		}
		A_1.Write(0);
	}

	protected void cf(Collection<ch> A_0, BinaryWriter A_1)
	{
		if (A_0 != null && A_0.Count > 0)
		{
			A_1.Write(A_0.Count);
			{
				foreach (ch item in A_0)
				{
					if (item == null)
					{
						A_1.Write(value: false);
						continue;
					}
					A_1.Write(value: true);
					item.m(ref A_1);
				}
				return;
			}
		}
		A_1.Write(0);
	}

	protected void cf(ref Collection<float[]> A_0, BinaryReader A_1, int A_2)
	{
		float[] array = null;
		int num = A_1.ReadInt32();
		if (A_0 == null)
		{
			A_0 = new Collection<float[]>();
		}
		else
		{
			A_0.Clear();
		}
		checked
		{
			if (num > 0)
			{
				array = new float[num - 1 + 1];
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					array[num3] = A_1.ReadSingle();
				}
				A_0.Add(array);
			}
			else
			{
				array = null;
				A_0 = null;
			}
			if (A_2 >= 8)
			{
				int num4 = A_1.ReadInt32() - 1;
				for (int num5 = 1; num5 <= num4; num5++)
				{
					array = new float[num - 1 + 1];
					i3.a(ref array, A_1);
					A_0.Add(array);
				}
			}
		}
	}

	protected void cf(ref Collection<float> A_0, BinaryReader A_1, int A_2)
	{
		float item = A_1.ReadSingle();
		int num = default(int);
		if (A_2 >= 8)
		{
			num = A_1.ReadInt32();
		}
		checked
		{
			if (A_2 < 8 || num > 0)
			{
				if (A_0 == null)
				{
					A_0 = new Collection<float>();
				}
				else
				{
					A_0.Clear();
				}
				A_0.Add(item);
				if (A_2 >= 8)
				{
					int num2 = num - 1;
					for (int num3 = 1; num3 <= num2; num3++)
					{
						item = A_1.ReadSingle();
						A_0.Add(item);
					}
				}
			}
			else if (A_0 != null)
			{
				A_0 = null;
			}
		}
	}

	protected void cf(Collection<float> A_0, BinaryWriter A_1)
	{
		checked
		{
			if (A_0 != null && A_0.Count > 0)
			{
				A_1.Write(A_0[0]);
				A_1.Write(A_0.Count);
				int num = A_0.Count - 1;
				for (int num2 = 1; num2 <= num; num2++)
				{
					A_1.Write(A_0[num2]);
				}
			}
			else
			{
				A_1.Write(0f);
				A_1.Write(0);
			}
		}
	}

	protected void cf(Collection<float[]> A_0, BinaryWriter A_1)
	{
		checked
		{
			if (A_0 != null && A_0.Count > 0)
			{
				i3.a(A_0[0], A_1);
				A_1.Write(A_0.Count);
				int num = A_0.Count - 1;
				for (int num2 = 1; num2 <= num; num2++)
				{
					i3.a(A_0[num2], A_1);
				}
			}
			else
			{
				A_1.Write(0);
				A_1.Write(0);
			}
		}
	}

	protected bool cf(hg A_0, int A_1, ref bool A_2)
	{
		A_2 = A_0.ed().eu(A_1).w;
		if (!A_0.dh().a8())
		{
			return !A_0.ed().eu(A_1).w;
		}
		return true;
	}

	[SpecialName]
	public j ch()
	{
		return be;
	}

	[SpecialName]
	public double cq(int A_0)
	{
		return bc[A_0];
	}

	[SpecialName]
	public float[] ci()
	{
		return bc;
	}

	[SpecialName]
	public int cj()
	{
		if (bc == null)
		{
			return 0;
		}
		return bc.Length;
	}

	[SpecialName]
	public a[] ck()
	{
		return bf;
	}

	[SpecialName]
	public int cl()
	{
		if (bf == null)
		{
			return 0;
		}
		return bf.Length;
	}

	[SpecialName]
	public int cm()
	{
		return v;
	}

	[SpecialName]
	public hr cn()
	{
		return this.c;
	}

	[SpecialName]
	public f co()
	{
		return bh;
	}

	[SpecialName]
	public void cf(f A_0)
	{
		bh = A_0;
	}

	[SpecialName]
	public f cp()
	{
		return bi;
	}

	[SpecialName]
	public void cg(f A_0)
	{
		bi = A_0;
	}

	[SpecialName]
	public int cq()
	{
		return bm;
	}

	[SpecialName]
	public int cr()
	{
		return bn;
	}

	[SpecialName]
	public fy cs()
	{
		return this.d;
	}

	[SpecialName]
	public bool ct()
	{
		return bp;
	}

	[SpecialName]
	public fy cu()
	{
		return this.e;
	}

	[SpecialName]
	public fy cv()
	{
		return this.f;
	}

	[SpecialName]
	public string cw()
	{
		return this.i;
	}

	[SpecialName]
	public float cx()
	{
		return this.h;
	}

	[SpecialName]
	public hg cy()
	{
		return this.l;
	}

	[SpecialName]
	public void cg(hg A_0)
	{
		this.l = A_0;
	}

	[SpecialName]
	public eo.a cz()
	{
		return bx;
	}

	[SpecialName]
	public eo.a c0()
	{
		return null;
	}

	[SpecialName]
	public string c1()
	{
		return this.k;
	}

	[SpecialName]
	public float c2()
	{
		return s;
	}

	public void cf(float A_0)
	{
		s = A_0;
	}

	[SpecialName]
	public double c3()
	{
		return this.g;
	}

	[SpecialName]
	public bool c4()
	{
		hi hi2 = this.l.ed();
		if ((double)s >= hi2.gq())
		{
			if (be == global::cc.j.b)
			{
				if (this.g >= hi2.gr())
				{
					return true;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	public float c5()
	{
		return (float)((double)(180f * ah.c()) / Math.PI);
	}

	[SpecialName]
	public float c6()
	{
		if (ah.d() < 0f)
		{
			return (float)(180.0 * ((double)ah.d() + Math.PI * 2.0) / Math.PI);
		}
		return (float)((double)(180f * ah.d()) / Math.PI);
	}

	[SpecialName]
	public int c7()
	{
		if (bv == null)
		{
			return 0;
		}
		return bv.g();
	}

	[SpecialName]
	public double cr(int A_0)
	{
		return bv.g(A_0);
	}

	[SpecialName]
	public double cs(int A_0)
	{
		return bv.h(A_0);
	}

	[SpecialName]
	public double ct(int A_0)
	{
		return bv.i(A_0);
	}

	[SpecialName]
	public double cu(int A_0)
	{
		return bv.i(A_0);
	}

	[SpecialName]
	public double cv(int A_0)
	{
		return bv.k(A_0);
	}

	[SpecialName]
	public Collection<float> c8()
	{
		return t;
	}

	[SpecialName]
	public Collection<float> c9()
	{
		return u;
	}

	[SpecialName]
	public DateTime da()
	{
		return ba;
	}

	[SpecialName]
	public bool db()
	{
		return bb;
	}

	[SpecialName]
	public void cf(bool A_0)
	{
		bb = A_0;
	}

	[SpecialName]
	public bool dc()
	{
		return a9;
	}

	[SpecialName]
	public n dd()
	{
		return this.n;
	}

	[SpecialName]
	public string de()
	{
		return r;
	}

	[SpecialName]
	public int df()
	{
		if (a2 == null)
		{
			return 0;
		}
		return checked(a2.GetUpperBound(0) + 1);
	}

	[SpecialName]
	public int cw(int A_0)
	{
		return a2[A_0];
	}

	[SpecialName]
	public h dg()
	{
		return b0;
	}

	[SpecialName]
	public i dh()
	{
		return b1;
	}

	[SpecialName]
	public float[] di()
	{
		return w;
	}

	[SpecialName]
	public float[] dj()
	{
		return x;
	}

	[SpecialName]
	public string[] dk()
	{
		return ab;
	}

	[SpecialName]
	public float[] dl()
	{
		return y;
	}

	[SpecialName]
	public float[] dm()
	{
		return ac;
	}

	[SpecialName]
	public float[] dn()
	{
		return ad;
	}

	[SpecialName]
	public float[] @do()
	{
		return ae;
	}

	[SpecialName]
	public float[] dp()
	{
		return af;
	}

	[SpecialName]
	public float[] dq()
	{
		return ag;
	}

	[SpecialName]
	public Collection<float[]> dr()
	{
		return ai;
	}

	[SpecialName]
	public Collection<float[]> ds()
	{
		return aj;
	}

	[SpecialName]
	public Collection<float[]> dt()
	{
		return ak;
	}

	[SpecialName]
	public Collection<float[]> du()
	{
		return al;
	}

	[SpecialName]
	public Collection<float[]> dv()
	{
		return am;
	}

	[SpecialName]
	public Collection<float[]> dw()
	{
		return an;
	}

	[SpecialName]
	public Collection<float[]> dx()
	{
		return ao;
	}

	[SpecialName]
	public Collection<float[]> dy()
	{
		return ap;
	}

	[SpecialName]
	public Collection<float[]> dz()
	{
		return aq;
	}

	[SpecialName]
	public Collection<float[]> d0()
	{
		return ar;
	}

	[SpecialName]
	public Collection<float[]> d1()
	{
		return @as;
	}

	[SpecialName]
	public Collection<float[]> d2()
	{
		return at;
	}

	[SpecialName]
	public Collection<float[]> d3()
	{
		return au;
	}

	[SpecialName]
	public Collection<float[]> d4()
	{
		return av;
	}

	[SpecialName]
	public bool d5()
	{
		return bq;
	}

	[SpecialName]
	public void cg(bool A_0)
	{
		bq = A_0;
	}

	[SpecialName]
	public float d6()
	{
		return br;
	}

	[SpecialName]
	public string d7()
	{
		return bs;
	}

	[SpecialName]
	public void cf(string A_0)
	{
		bs = A_0;
	}

	[SpecialName]
	public string d8()
	{
		return bt;
	}

	[SpecialName]
	public string d9()
	{
		return bu;
	}

	[SpecialName]
	public g cf(hi.c A_0)
	{
		if (by == null)
		{
			return null;
		}
		return by[(int)A_0];
	}

	[SpecialName]
	public ix.c ea()
	{
		return bz;
	}

	[SpecialName]
	public ix.c eb()
	{
		return b2;
	}

	[SpecialName]
	public bool ec()
	{
		return b3;
	}

	[SpecialName]
	public void ch(bool A_0)
	{
		b5 = A_0;
	}

	[SpecialName]
	public bool ed()
	{
		return b5;
	}

	[SpecialName]
	public int ee()
	{
		return b6;
	}

	[SpecialName]
	public string ef()
	{
		return b7;
	}

	[SpecialName]
	public int eg()
	{
		return b8;
	}

	[SpecialName]
	public void cx(int A_0)
	{
		b8 = A_0;
	}

	public void cf(string A_0, string A_1)
	{
		bt = A_0;
		bu = A_1;
	}

	public static void cf(ref string A_0, ref string A_1, ref string A_2, ref string A_3, ref string A_4, ref string A_5, ref bool A_6)
	{
		if (A_6)
		{
			A_0 = "{\\rtf1\\ansi\\deff0{\\fonttbl{\\f0\\fswiss MS Sans Serif;}{\\f1\\froman\\fcharset2 Symbol;}{\\f2\\froman Times New Roman;}{\\f3\\farial Arial;}}{\\colortbl ;\\red255\\green0\\blue0; \\red0\\green0\\blue255; \\red192\\green192\\blue192; }";
			A_1 = "\\plain\\f3\\fs20 ";
			A_0 += A_1;
			A_2 = "\\b ";
			A_3 = "\\par ";
			A_4 = "\\cf1 ";
			A_5 = "}";
		}
		else
		{
			A_0 = "";
			A_1 = "";
			A_3 = "\r\n";
			A_2 = "";
			A_4 = "";
			A_5 = "";
		}
	}

	public void cf(string A_0, string A_1, string A_2, ref string A_3)
	{
		if (this.l.b3(this.m).c9.a(this.l.dh(), bx))
		{
			if (!string.IsNullOrEmpty(A_3))
			{
				A_3 += A_0;
			}
			A_3 = A_3 + A_1 + "FP Dip:" + A_0;
			if (b0 == null)
			{
				A_3 = A_3 + "Error (no results)" + A_0;
			}
			else
			{
				A_3 = A_3 + global::cc.h.f() + A_2 + b0.i() + A_1 + global::cc.h.d() + A_0;
				A_3 = A_3 + global::cc.h.e() + A_2 + b0.j() + A_1 + global::cc.h.d() + A_0;
				A_3 = A_3 + global::cc.h.g() + A_2 + b0.h() + A_1 + global::cc.h.d() + A_0;
			}
		}
		if (this.l.b3(this.m).c9.h(this.l.dh(), bx))
		{
			A_3 = A_3 + "DBR Center:" + A_0;
			if (b1 == null)
			{
				A_3 = A_3 + "Error (no results)" + A_0;
				return;
			}
			A_3 = A_3 + global::cc.i.f() + A_2 + b1.i() + A_1 + global::cc.i.d() + A_0;
			A_3 = A_3 + global::cc.i.e() + A_2 + b1.j() + A_1 + global::cc.i.d() + A_0;
			A_3 = A_3 + global::cc.i.g() + A_2 + b1.h() + A_1 + global::cc.i.d() + A_0;
		}
	}

	public static string cf(double A_0)
	{
		return A_0.ToString("###0.0000");
	}

	public string cf(bool A_0, short A_1, bool A_2, cb A_3, ref bool A_4, ref string A_5, ref Color A_6, ref BorderStyle A_7, ref string A_8, ref Color A_9, ref Color A_10, ref Color A_11, ref string A_12, ref string A_13, ref string A_14)
	{
		string A_15 = "";
		bool[] array = new bool[102];
		bool[] array2 = new bool[102];
		bool[] array3 = new bool[102];
		bool[] array4 = new bool[102];
		bool[] array5 = new bool[102];
		bool[] array6 = new bool[102];
		string A_16 = null;
		string A_17 = null;
		string A_18 = null;
		string A_19 = null;
		string A_20 = null;
		string A_21 = null;
		bool flag = this.c.cu().q() != null;
		cf(ref A_21, ref A_19, ref A_16, ref A_17, ref A_18, ref A_20, ref A_0);
		string text;
		string text2;
		string text3;
		if (A_0)
		{
			text = "\\cf3 ";
			text2 = "\\f1 D\\f3 ";
			text3 = "\\f1 l\\f3 ";
		}
		else
		{
			text = "";
			text2 = "Delta";
			text3 = "Wavelength";
		}
		string text4 = A_17 + A_19 + "(" + (d6() * 2f).ToString("0") + " nm " + text3 + " range reduction ->" + text2 + ": ";
		string text5 = A_17 + A_19 + "(Optimal " + text3 + " range: ";
		if (b5)
		{
			A_15 = A_15 + "(Overriden by Interpolation)" + A_17;
		}
		if (this.c.cr() || (this.c.bl() != null && this.c.bl().cr()) || (this.c.bm() != null && this.c.bm().Count > 0 && this.c.bm()[0].cr()))
		{
			A_15 = A_15 + A_16 + A_18 + "Warning: Spectrum Saturated" + A_19 + A_17;
		}
		if (a9)
		{
			A_15 = A_15 + A_16 + A_18 + "Warning: Incomplete Analysis" + A_19 + A_17;
		}
		if (cb == null)
		{
			hg obj = this.l;
			eo.a a_ = bx;
			int A_22 = 0;
			if (obj.bu(A_0: false, a_, ref A_22) == null)
			{
				goto IL_0278;
			}
		}
		A_15 = A_15 + "Best Recipe = " + A_16 + cy().b7().Replace("\\", "\\\\") + A_19 + A_17;
		goto IL_0278;
		IL_1c74:
		A_15 = A_21 + A_15 + A_20;
		if (A_0)
		{
			A_15 = A_15.Replace("Å", "\\u0197?");
			A_15 = A_15.Replace("µ", "\\u0181?");
			A_15 = A_15.Replace("″", "\\u8243?");
		}
		return A_15;
		IL_0278:
		hi hi2 = this.l.b3(this.m);
		checked
		{
			int num = hi2.g7() + 1;
			cf(this.o, ref A_9, ref A_12);
			cf(this.p, ref A_10, ref A_13);
			cf(this.q, ref A_11, ref A_14);
			bool flag2 = this.o == global::cc.n.c || this.p == global::cc.n.c || this.q == global::cc.n.c;
			string text6 = null;
			if (co() != null && co().e() != null && co().e().Count > 0 && hi2.d5(co().e()[0].h()))
			{
				string A_23 = null;
				string A_24 = null;
				string A_25 = null;
				hi hi3 = hi2;
				hg.bu(co().e()[0].h(), ref A_23, ref A_24, ref A_25);
				text6 = A_23 + " Min=" + hi3.em() + ", Max=" + hi3.en() + "; " + A_24 + " Min=" + hi3.eo() + ", Max=" + hi3.ep() + "; " + A_25 + " Min=" + hi3.eq() + ", Max=" + hi3.er();
				hi3 = null;
			}
			if (be == global::cc.j.a || be == global::cc.j.b)
			{
				if (!this.l.dh().az(bx) && !this.l.dh().av(bx) && this.c.cu().q() == null)
				{
					if (string.IsNullOrEmpty(A_15))
					{
						return string.Empty;
					}
					return A_21 + A_15 + A_20;
				}
				if (string.IsNullOrEmpty(b9))
				{
					string text7 = ((!c4() || hi2.au(di())) ? (A_16 + "??") : string.Empty);
					int num2 = 1;
					bool a_2 = this.l.dh().ax(bx);
					bool a_3 = this.l.dh().az(bx);
					eo.b a_4 = this.l.dh().at(bx, this.c.af());
					int A_22 = num;
					int num3;
					for (num3 = 1; num3 <= A_22; num3++)
					{
						gc gc2 = hi2.eu(num3);
						array[num3] = gc2.af(a_4) && num3 < num;
						if (!flag)
						{
							array2[num3] = gc2.ah(a_2);
							array3[num3] = gc2.aj(a_2);
							array4[num3] = gc2.al(a_2);
							array5[num3] = gc2.ap(a_3) && num3 < num;
							array6[num3] = gc2.an(a_2) && num3 < num;
						}
						gc2 = null;
					}
					bool flag3 = default(bool);
					if (num2 == 1)
					{
						if (w != null && w.Length == this.l.b3(this.m).g7() + 2)
						{
							flag3 = true;
							if (hi2.hd())
							{
								A_15 = A_15 + "Correlation Active" + A_17;
							}
							int num4 = 0;
							double num5 = 0.0;
							double num6 = 0.0;
							double num7 = 0.0;
							int num8 = 0;
							int num9 = num;
							bool A_26 = default(bool);
							for (num3 = 1; num3 <= num9; num3++)
							{
								bool flag4 = array[num3] || array2[num3] || array3[num3] || array4[num3] || array5[num3];
								if (flag4)
								{
									if (!string.IsNullOrEmpty(A_15) && !A_15.EndsWith(A_17))
									{
										A_15 += A_17;
									}
									if (!cf(this.l, num3, ref A_26))
									{
										continue;
									}
								}
								if (num3 < num)
								{
									if (flag4)
									{
										if (A_26)
										{
											A_15 += text;
										}
										A_15 += ab[num3];
									}
									if (array[num3])
									{
										A_15 = A_15 + A_16 + hg.bu(hg.o.a, this.l.ca(), w[num3], dr(), dz(), num3, A_1, text4, 0, A_0) + text7 + A_19;
										num4++;
									}
									else if (flag4)
									{
										A_15 = A_15 + hg.bu(hg.o.a, this.l.ca(), w[num3], dr(), dz(), num3, A_1, text4, 0, A_0) + text7 + A_19;
									}
									num5 += (double)w[num3];
									if (dr() != null)
									{
										if (dr().Count > 0)
										{
											num6 += Math.Pow(dr()[0][num3], 2.0);
										}
										if (dr().Count > 1)
										{
											num7 += Math.Pow(dr()[1][num3], 2.0);
										}
									}
								}
								else if (flag4)
								{
									A_15 += hg.bz(hi2.eu(num3).ag());
								}
								if (array2[num3])
								{
									double a_5 = ((at == null || at.Count <= 0) ? ((double)ac[num3]) : ((double)at[0][num3]));
									A_15 += A_17;
									if (A_26)
									{
										A_15 += text;
									}
									A_15 = A_15 + " n(" + i6.a(hi2.f6(), "#.0") + " nm)=";
									A_15 = A_15 + A_16 + cf(a_5) + hg.bu(du(), num3, hg.o.c, new h4(h4.a.b), 4, text4, A_0) + A_19;
								}
								if (array3[num3])
								{
									double a_6 = ((au == null || au.Count <= 0) ? ((double)ad[num3]) : ((double)au[0][num3]));
									A_15 += A_17;
									if (A_26)
									{
										A_15 += text;
									}
									A_15 = A_15 + " k(" + i6.a(hi2.f6(), "#.0") + " nm)=";
									A_15 = A_15 + A_16 + cf(a_6) + hg.bu(dv(), num3, hg.o.c, new h4(h4.a.b), 4, text4, A_0) + A_19;
								}
								if (array2[num3] && ay != null && ay.Count > 0)
								{
									if (this.l.dh().a8() && ay[num8].af() == hd.a.k)
									{
										double num10 = ((aw == null || aw.Count <= 0) ? ((double)af[num3]) : ((double)aw[0][num3]));
										A_15 += A_17;
										if (A_26)
										{
											A_15 += text;
										}
										A_15 += " Crystallinity=";
										A_15 = A_15 + A_16 + num10.ToString("###0.00") + hg.bu(dx(), num3, hg.o.b, new h4(h4.a.b), 4, text4, A_0) + A_19;
									}
									if (ay[num8].af() == hd.a.n)
									{
										double a_7 = ((ax == null || ax.Count <= 0) ? ((double)ag[num3]) : ((double)ax[0][num3]));
										A_15 += A_17;
										if (A_26)
										{
											A_15 += text;
										}
										A_15 += " Porosity=";
										A_15 = A_15 + A_16 + hg.bu(hg.o.b, this.l.ca(), a_7, dy(), ax, num3, A_1, text4, 0, A_0) + A_19;
									}
								}
								if (array2[num3] || array3[num3])
								{
									num8++;
								}
								if (array4[num3])
								{
									A_15 += A_17;
									if (A_26)
									{
										A_15 += text;
									}
									A_15 += " Roughness=";
									A_15 = A_15 + A_16 + hg.bu(hg.o.a, this.l.ca(), ae[num3], dw(), d4(), num3, A_1, text4, 0, A_0) + A_19;
								}
								if (array5[num3])
								{
									A_15 += A_17;
									if (A_26)
									{
										A_15 += text;
									}
									A_15 += " Nonuniformity=+/-";
									A_15 = A_15 + A_16 + hg.bu(hg.o.a, this.l.ca(), x[num3], ds(), d0(), num3, A_1, text4, 0, A_0) + text7 + A_19;
								}
								if (array6[num3])
								{
									A_15 += A_17;
									if (A_26)
									{
										A_15 += text;
									}
									A_15 += " Grading=";
									A_15 = A_15 + A_16 + hg.bu(hg.o.b, this.l.ca(), y[num3], dt(), d1(), num3, A_1, text4, 0, A_0) + text7 + A_19;
									A_15 = A_15 + A_17 + A_16 + "   (" + text2 + "n=" + hg.bu(hg.o.c, new h4(h4.a.b), z[num3], A_1, new h4(h4.a.b), 0);
									if (aa[num3] != 0f)
									{
										A_15 = A_15 + ", " + text2 + "k=" + hg.bu(hg.o.c, new h4(h4.a.b), aa[num3], A_1, new h4(h4.a.b), 0);
									}
									A_15 = A_15 + ")" + A_19;
								}
							}
							if (!flag && hi2.d7(bx) && hi2.d8(bx) && hi2.g7() > 1 && !this.j)
							{
								A_15 = A_15 + A_17 + "Total Thickness = " + hg.bu(hg.o.a, this.l.ca(), num5, (float)Math.Sqrt(num6), (float)Math.Sqrt(num7), A_1, text4, 0, A_8: true, A_0);
							}
							if (ah != null)
							{
								A_15 = unchecked(A_15 + A_17 + "Psi = " + jf.a((double)c5(), (int)A_1) + ", Delta = " + jf.a((double)c6(), (int)A_1));
							}
							A_15 += A_17;
							double num11 = ((u == null || u.Count <= 0) ? ((double)s) : ((double)u[0]));
							A_15 = ((!(num11 >= hi2.gq())) ? (A_15 + "Goodness of fit = " + A_16 + A_18 + jf.a(num11, A_1) + hg.bu(c8(), hg.o.c, new h4(h4.a.b), A_1, text4, A_0) + A_19) : (A_15 + "Goodness of fit = " + jf.a(num11, A_1) + hg.bu(c8(), hg.o.c, new h4(h4.a.b), A_1, text4, A_0)));
							if (!string.IsNullOrEmpty(d7()))
							{
								A_15 = A_15 + text5 + d7() + " nm)";
							}
							if (be == global::cc.j.b)
							{
								A_15 += A_17;
								A_15 = ((!(this.g >= hi2.gr())) ? (A_15 + "Normalized FFT Intensity = " + A_16 + A_18 + jf.a(this.g, A_1) + A_19) : (A_15 + "Normalized FFT Intensity = " + jf.a(this.g, A_1)));
							}
							if (A_3 != null)
							{
								A_15 += A_17;
								num11 = A_3.l();
								A_15 = A_15 + "Composite goodness of fit = " + jf.a(num11, A_1);
							}
						}
					}
					else
					{
						int num12 = num2 - 2;
						if ((num12 < hi2.g7() + 1) & (num12 > 0))
						{
							A_15 += "Thickness=";
							A_15 = ((!array[num12]) ? (A_15 + hg.bu(hg.o.a, this.l.ca(), w[num12], dr(), dz(), num12, A_1, text4, 0, A_0)) : (A_15 + A_16 + hg.bu(hg.o.a, this.l.ca(), w[num12], dr(), dz(), num12, A_1, text4, 0, A_0) + text7 + A_19));
							A_15 += A_17;
						}
						if (num2 != 10)
						{
							A_15 = A_15 + "n(" + i6.a(hi2.f6(), "#.0") + " nm)=";
							A_15 = ((!array2[num12]) ? (A_15 + cf((double)ac[num12]) + hg.bu(du(), num3, hg.o.c, new h4(h4.a.b), 4, text4, A_0)) : (A_15 + A_16 + cf((double)ac[num12]) + hg.bu(du(), num3, hg.o.c, new h4(h4.a.b), 4, text4, A_0) + A_19));
							if (num12 > 0)
							{
								A_15 += A_17;
								A_15 = A_15 + "k(" + i6.a(hi2.f6(), "#.0") + " nm)=";
								A_15 = ((!array3[num12]) ? (A_15 + cf((double)ad[num12]) + hg.bu(dv(), num3, hg.o.c, new h4(h4.a.b), 4, text4, A_0) + A_19) : (A_15 + A_16 + cf((double)ad[num12]) + hg.bu(dv(), num3, hg.o.c, new h4(h4.a.b), 4, text4, A_0) + A_19));
								A_15 += A_17;
								A_15 += "Roughness=";
								A_15 = ((!array4[num12]) ? (A_15 + hg.bu(hg.o.a, this.l.ca(), ae[num12], dw(), d4(), num12, A_1, text4, 0, A_0)) : (A_15 + A_16 + hg.bu(hg.o.a, this.l.ca(), ae[num12], dw(), d4(), num12, A_1, text4, 0, A_0) + A_19));
								A_15 += "Nonuniformity=";
								A_15 = ((!array5[num12]) ? (A_15 + hg.bu(hg.o.a, this.l.ca(), x[num12], ds(), d0(), num12, A_1, text4, 0, A_0)) : (A_15 + A_16 + hg.bu(hg.o.a, this.l.ca(), x[num12], ds(), d0(), num12, A_1, text4, 0, A_0) + text7 + A_19));
								A_15 += "Grading=";
								A_15 = ((!array6[num12]) ? (A_15 + hg.bu(hg.o.b, this.l.ca(), y[num12], dt(), d1(), num12, A_1, text4, 0, A_0)) : (A_15 + A_16 + hg.bu(hg.o.b, this.l.ca(), y[num12], dt(), d1(), num12, A_1, text4, 0, A_0) + text7 + A_19));
							}
						}
					}
					int num13 = 0;
					int num14 = num - 1;
					int num15 = default(int);
					for (num3 = 1; num3 <= num14; num3++)
					{
						if (array[num3])
						{
							num13++;
							num15 = num3;
						}
					}
					if (hi2.g5() || !string.IsNullOrEmpty(text6))
					{
						A_4 = true;
						if (this.n == global::cc.n.c || (num13 != 1 && flag2))
						{
							A_5 = "Alarm";
							A_6 = Color.Red;
							A_7 = BorderStyle.FixedSingle;
							A_8 = "Result is not within Alarm limits.";
						}
						else
						{
							A_5 = "Good";
							A_6 = Color.Lime;
							A_7 = BorderStyle.None;
							A_8 = "Result within Alarm limits.";
						}
						if (!string.IsNullOrEmpty(text6))
						{
							A_8 = A_8 + "\r\n" + text6;
						}
					}
					else
					{
						A_4 = false;
						A_5 = string.Empty;
						A_6 = SystemColors.Control;
						A_7 = BorderStyle.None;
					}
					if (num13 == 1 && flag3)
					{
						A_4 = true;
						A_5 = hg.bu(hg.o.a, this.l.ca(), w[num15], A_1, new h4(h4.a.b), 0);
						if (this.n == global::cc.n.a)
						{
							A_6 = SystemColors.Control;
						}
						if (this.n == global::cc.n.b)
						{
							A_6 = Color.Lime;
						}
						if (!c4())
						{
							A_5 += "??";
						}
					}
					cf(A_17, A_19, A_16, ref A_15);
				}
				else
				{
					A_4 = false;
					A_15 += b9;
				}
			}
			else if (be == global::cc.j.c)
			{
				bool flag5 = false;
				bool flag6 = false;
				double num16;
				string text8;
				string text9;
				if (A_2)
				{
					num16 = 100.0;
					text8 = "%";
					text9 = "0.##";
				}
				else
				{
					num16 = 1.0;
					text8 = "";
					text9 = "0.####";
				}
				if (bc != null && bc.Length > 0)
				{
					string text10 = null;
					int num17 = cj() - 1;
					for (int num3 = 0; num3 <= num17; num3++)
					{
						if (!hi2.d9(num3))
						{
							continue;
						}
						if (string.IsNullOrEmpty(text10))
						{
							text10 = "Mean Values: " + A_17;
						}
						flag6 = true;
						text10 = text10 + "R" + (num3 + 1) + "=";
						string text11 = Strings.Format((double)bc[num3] * num16, text9);
						if (hi2.au(bc[num3], num3))
						{
							flag5 = true;
							text10 = text10 + A_16 + A_18 + text11 + text8 + A_19;
							if (!string.IsNullOrEmpty(A_8))
							{
								A_8 += ", ";
							}
							A_8 = A_8 + "R" + (num3 + 1);
						}
						else
						{
							text10 = text10 + text11 + text8;
						}
						text10 += A_17;
					}
					if (!string.IsNullOrEmpty(text10))
					{
						A_15 = A_15 + text10 + A_17;
					}
				}
				if (bf != null && bf.Length > 0)
				{
					string text12 = null;
					int num18 = cl() - 1;
					bool A_27 = default(bool);
					bool A_28 = default(bool);
					for (int num3 = 0; num3 <= num18; num3++)
					{
						if (hi2.ei(num3))
						{
							if (string.IsNullOrEmpty(text12))
							{
								text12 = "Extrema Min/Max Values: " + A_17;
							}
							flag6 = true;
							text12 = text12 + "M" + (num3 + 1) + "=";
							string text13 = ((double)bf[num3].f() * num16).ToString(text9);
							string text14 = hg.bu(hg.o.d, this.l.ca(), bf[num3].e(), A_1, new h4(h4.a.b), 0);
							flag5 = flag5 || hi2.au(bf[num3].e(), bf[num3].f(), num3, ref A_27, ref A_28);
							text12 += "(";
							if (A_27)
							{
								text12 = text12 + A_16 + A_18;
							}
							text12 += text14;
							if (A_27)
							{
								text12 += A_19;
							}
							text12 += ", ";
							if (A_28)
							{
								text12 = text12 + A_16 + A_18;
							}
							text12 = text12 + text13 + text8;
							if (A_28)
							{
								text12 += A_19;
							}
							text12 += ")";
							if (hi2.au(bx))
							{
								text12 = text12 + A_17 + "M" + (num3 + 1) + " n=" + cf((double)bw[num3]);
							}
							if (!string.IsNullOrEmpty(A_8))
							{
								A_8 += ", ";
							}
							A_8 = A_8 + "M" + (num3 + 1);
							text12 += A_17;
						}
					}
					if (!string.IsNullOrEmpty(text12))
					{
						A_15 = A_15 + text12 + A_17;
					}
				}
				if (!string.IsNullOrEmpty(text6))
				{
					if (!string.IsNullOrEmpty(A_8))
					{
						A_8 += "\r\n";
					}
					A_8 += text6;
				}
				if (flag5 || flag2)
				{
					A_8 = "Reflectance values, Extrema values, and/or color values outside following region limits: \r\n" + A_8;
					A_6 = Color.Red;
					A_7 = BorderStyle.FixedSingle;
					A_5 = "Bad";
				}
				else
				{
					A_8 = "Reflectance values, Extrema values, and color values within specified region limits.";
					A_6 = Color.Lime;
					A_7 = BorderStyle.None;
					A_5 = "Good";
				}
				A_4 = flag6 || !string.IsNullOrEmpty(text6);
				if ((hi2.ex() && by[0] != null) || (hi2.ey() && by[1] != null) || (hi2.ez() && by[2] != null))
				{
					A_15 += "Solar Reflectance Mean Values: ";
					if (hi2.ex() && by[0] != null)
					{
						A_15 = A_15 + A_17 + "SUVA=" + (by[0].d() * num16).ToString(text9) + text8;
					}
					if (hi2.ey() && by[1] != null)
					{
						A_15 = A_15 + A_17 + "SUVB=" + (by[1].d() * num16).ToString(text9) + text8;
					}
					if (hi2.ez() && by[2] != null)
					{
						A_15 = A_15 + A_17 + "SUVAB=" + (by[2].d() * num16).ToString(text9) + text8;
					}
					A_15 += A_17;
				}
				if (hi2.e0() && bz != null)
				{
					A_15 = A_15 + "Luminous Reflectance: " + ((double)bz.a * num16).ToString(text9) + text8 + A_17;
				}
				if (hi2.e1() && b2 != null)
				{
					string text15 = null;
					if (b3)
					{
						text15 += " (Corr On)";
					}
					A_15 = A_15 + "YI D1925" + text15 + ": " + b2.a.ToString("0.##") + A_17;
				}
				cf(A_17, A_19, A_16, ref A_15);
			}
			if (this.c.ch)
			{
				if (!string.IsNullOrEmpty(A_15))
				{
					A_15 += A_17;
				}
				A_15 += string.Format(ey.y(), this.c.ci);
			}
			if (this.i != null)
			{
				string text16 = this.i;
				string A_29 = "ErrorTitle";
				if (!text16.StartsWith(hu.a(ref A_29)))
				{
					string text17 = this.i;
					A_29 = "Warning";
					if (!text17.StartsWith(hu.a(ref A_29)))
					{
						goto IL_1c74;
					}
				}
				A_15 = A_15 + A_17 + this.i;
			}
			goto IL_1c74;
		}
	}

	private void cf(n A_0, ref Color A_1, ref string A_2)
	{
		switch (A_0)
		{
		case global::cc.n.c:
			A_1 = Color.Red;
			A_2 = "Result is not within color alarm limits.";
			break;
		case global::cc.n.a:
			A_1 = SystemColors.Control;
			A_2 = string.Empty;
			break;
		case global::cc.n.b:
			A_1 = Color.Lime;
			A_2 = "Result within color alarm limits.";
			break;
		}
	}

	public void cf(BinaryReader A_0, eo A_1, hg.j A_2)
	{
		this.l = new hg(A_1, A_2);
		i3.a(A_0, cf, "MeasResults", 31);
	}

	private void cf(BinaryReader A_0, int A_1)
	{
		this.c = new hr(null);
		cf(ref this.c, A_0);
		this.d = new fy();
		cf(ref this.d, A_0);
		this.e = new fy();
		cf(ref this.e, A_0);
		this.f = new fy();
		cf(ref this.f, A_0);
		this.h = A_0.ReadSingle();
		this.i = A_0.ReadString();
		this.k = A_0.ReadString();
		string a_ = A_0.ReadString();
		bool a_2 = A_0.ReadBoolean();
		string a_3 = A_0.ReadString() + "\r\n";
		this.l.bu(a_3, a_);
		this.l.b5(a_2);
		this.n = (n)A_0.ReadInt32();
		r = A_0.ReadString();
		s = A_0.ReadSingle();
		A_0.ReadInt32();
		v = A_0.ReadInt32();
		i3.a(ref w, A_0);
		cf(ref ab, A_0);
		i3.a(ref ac, A_0);
		i3.a(ref ad, A_0);
		i3.a(ref ae, A_0);
		ay = new Collection<ch>();
		cf(ref ay, A_0, A_1 > 9);
		az = new Collection<ch>();
		cf(ref az, A_0, A_1 > 9);
		cf(ref a2, A_0);
		a0 = new Collection<ga>();
		cf(ref a0, A_0, A_1 > 9);
		a1 = new Collection<ga>();
		cf(ref a1, A_0, A_1 > 9);
		int[] A_2 = null;
		cf(ref A_2, A_0);
		a3 = A_0.ReadString();
		a4 = A_0.ReadString();
		a5 = A_0.ReadString();
		a6 = A_0.ReadString();
		ba = DateTime.FromBinary(A_0.ReadInt64());
		bb = A_0.ReadBoolean();
		i3.a(ref bc, A_0);
		cf(ref bd, A_0);
		be = (j)A_0.ReadInt32();
		cf(ref bf, A_0);
		cf(ref bg, A_0);
		bh = new f();
		Collection<d> A_3 = bh.e();
		cf(ref A_3, A_0);
		f obj = bh;
		float[] A_4 = obj.c();
		i3.a(ref A_4, A_0);
		obj.c(A_4);
		bm = A_0.ReadInt32();
		bn = A_0.ReadInt32();
		if (A_0.ReadBoolean())
		{
			bo.d(A_0);
		}
		else
		{
			bo = null;
		}
		b9 = A_0.ReadString();
		ca = A_0.ReadString();
		if (A_1 >= 2)
		{
			A_0.ReadString();
		}
		Collection<gd> collection;
		checked
		{
			if (A_1 >= 3)
			{
				i3.a(ref x, A_0);
			}
			else
			{
				x = new float[w.GetUpperBound(0) + 1];
			}
			if (A_1 >= 4)
			{
				bp = A_0.ReadBoolean();
			}
			else
			{
				bp = false;
			}
			if (A_1 >= 5)
			{
				this.j = A_0.ReadBoolean();
			}
			else
			{
				this.j = false;
			}
			if (A_1 >= 6)
			{
				if (A_0.ReadBoolean())
				{
					bi = new f();
					A_3 = bi.e();
					cf(ref A_3, A_0);
					f obj2 = bi;
					A_4 = obj2.c();
					i3.a(ref A_4, A_0);
					obj2.c(A_4);
				}
				else
				{
					bi = null;
				}
			}
			else
			{
				bi = null;
			}
			if (A_1 >= 7)
			{
				cf(ref t, A_0, A_1);
				cf(ref ai, A_0, A_1);
				cf(ref aj, A_0, A_1);
				cf(ref al, A_0, A_1);
				cf(ref am, A_0, A_1);
				cf(ref an, A_0, A_1);
				bq = A_0.ReadBoolean();
			}
			else
			{
				t = null;
				ai = null;
				aj = null;
				al = null;
				am = null;
				an = null;
				bq = false;
			}
			if (A_1 >= 8)
			{
				br = A_0.ReadSingle();
			}
			else
			{
				br = 0f;
			}
			if (A_1 >= 9)
			{
				bs = A_0.ReadString();
			}
			else
			{
				bs = null;
			}
			if (A_1 >= 11)
			{
				cf(ref u, A_0, A_1);
				cf(ref aq, A_0, A_1);
				cf(ref ar, A_0, A_1);
				cf(ref at, A_0, A_1);
				cf(ref au, A_0, A_1);
				cf(ref av, A_0, A_1);
			}
			else
			{
				u = null;
				aq = null;
				ar = null;
				at = null;
				au = null;
				av = null;
			}
			if (A_1 >= 12)
			{
				bt = A_0.ReadString();
				bu = A_0.ReadString();
			}
			else
			{
				bt = string.Empty;
				string A_5 = "Unknown";
				bu = hu.a(ref A_5);
			}
			collection = new Collection<gd>();
			if (A_1 >= 13)
			{
				int num = A_0.ReadInt32();
				if (num > 0)
				{
					int num2 = num - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						gd gd2 = new gd();
						gd2.i(A_0);
						collection.Add(gd2);
					}
				}
			}
			if (A_1 >= 14)
			{
				i3.a(ref y, A_0);
				i3.a(ref z, A_0);
				i3.a(ref aa, A_0);
				i3.a(ref ak, A_0);
				i3.a(ref @as, A_0);
			}
			if (A_1 >= 15)
			{
				i3.a(ref af, A_0);
				i3.a(ref ao, A_0);
				i3.a(ref aw, A_0);
				i3.a(ref ag, A_0);
				i3.a(ref ap, A_0);
				i3.a(ref ax, A_0);
			}
			if (A_1 >= 16)
			{
				a9 = A_0.ReadBoolean();
			}
		}
		if (A_1 >= 17)
		{
			this.o = (n)A_0.ReadInt32();
		}
		if (A_1 >= 18)
		{
			this.p = (n)A_0.ReadInt32();
			this.q = (n)A_0.ReadInt32();
		}
		if (A_1 >= 19)
		{
			i3.a(ref bw, A_0);
		}
		if (A_1 >= 20 && A_0.ReadBoolean())
		{
			bx = global::eo.a.ao(A_0);
			hr hr2 = this.c;
			if (!bx.ap(hr2.cz(), hr2.cv(), hr2.c2()))
			{
				bx = null;
			}
			hr2 = null;
		}
		by = null;
		if (A_1 >= 21)
		{
			if (A_0.ReadBoolean())
			{
				by = new g[3];
				if (by[0] == null)
				{
					by[0] = new g();
				}
				by[0].d(A_0);
			}
			if (A_0.ReadBoolean())
			{
				if (by == null)
				{
					by = new g[3];
				}
				if (by[1] == null)
				{
					by[1] = new g();
				}
				by[1].d(A_0);
			}
			if (A_0.ReadBoolean())
			{
				if (by == null)
				{
					by = new g[3];
				}
				if (by[2] == null)
				{
					by[2] = new g();
				}
				by[2].d(A_0);
			}
		}
		if (A_1 >= 22 && A_0.ReadBoolean())
		{
			new i4().a(A_0);
		}
		if (A_1 >= 23)
		{
			if (A_0.ReadBoolean())
			{
				bz = new ix.c(A_0.ReadSingle());
			}
			else
			{
				bz = null;
			}
		}
		else
		{
			bz = null;
		}
		if (A_1 >= 24 && A_0.ReadBoolean())
		{
			cb = new hg(this.l.dh(), this.l.cd());
			string text = A_0.ReadString();
			bool a_4 = A_0.ReadBoolean();
			string a_5 = A_0.ReadString() + "\r\n";
			cb.bu(a_5, hg.b0() + text + Path.GetExtension(this.l.c1()));
			cb.b5(a_4);
		}
		else
		{
			cb = null;
		}
		if (A_1 >= 25)
		{
			this.m = A_0.ReadInt32();
		}
		else
		{
			this.m = 1;
		}
		if (A_1 >= 26)
		{
			if (A_0.ReadBoolean())
			{
				float a_6 = A_0.ReadSingle();
				float a_7 = A_0.ReadSingle();
				float a_8 = A_0.ReadSingle();
				b0 = new h(a_7, a_8, a_6);
			}
			if (A_0.ReadBoolean())
			{
				float a_9 = A_0.ReadSingle();
				float a_10 = A_0.ReadSingle();
				float a_11 = A_0.ReadSingle();
				b1 = new i(a_10, a_11, a_9);
			}
		}
		else
		{
			b0 = null;
			b1 = null;
		}
		if (A_1 == 27)
		{
			if (this.c.cl() == FMLegacyAllSystemTypes.kTypeF60)
			{
				b6 = A_0.ReadInt32();
				b7 = A_0.ReadString();
				b2 = null;
			}
			else if (A_0.ReadBoolean())
			{
				b2 = new ix.c(A_0.ReadSingle());
			}
			else
			{
				b2 = null;
			}
			b3 = false;
		}
		else if (A_1 > 27)
		{
			if (A_0.ReadBoolean())
			{
				b2 = new ix.c(A_0.ReadSingle());
				b3 = A_0.ReadBoolean();
			}
			else
			{
				A_0.ReadBoolean();
				b2 = null;
				b3 = false;
			}
		}
		else
		{
			b2 = null;
			b3 = false;
		}
		if (A_1 >= 29)
		{
			b5 = A_0.ReadBoolean();
		}
		else
		{
			b5 = false;
		}
		if (A_1 >= 30)
		{
			b6 = A_0.ReadInt32();
			b7 = A_0.ReadString();
		}
		if (A_1 >= 31)
		{
			this.g = A_0.ReadDouble();
		}
		if (collection.Count <= 0)
		{
			return;
		}
		hi hi2 = this.l.b3(this.m);
		hi2.cs.Clear();
		foreach (gd item in collection)
		{
			hi2.cs.Add(item);
		}
		hi2.hp();
		hi2.ho();
	}

	public void cf(BinaryWriter A_0)
	{
		i3.a(A_0, cg, 31, 13);
	}

	public void cg(BinaryWriter A_0)
	{
		cf(this.c, A_0);
		cf(this.d, A_0);
		cf(this.e, A_0);
		cf(this.f, A_0);
		A_0.Write(this.h);
		if (this.i == null)
		{
			this.i = string.Empty;
		}
		A_0.Write(this.i);
		A_0.Write(this.k);
		A_0.Write(this.l.c1());
		A_0.Write(this.l.c9());
		A_0.Write(this.l.ee());
		A_0.Write((int)this.n);
		if (r == null)
		{
			r = string.Empty;
		}
		A_0.Write(r);
		A_0.Write(s);
		A_0.Write(this.l.dz());
		A_0.Write(v);
		i3.a(w, A_0);
		cf(ab, A_0);
		i3.a(ac, A_0);
		i3.a(ad, A_0);
		i3.a(ae, A_0);
		cf(ay, A_0);
		cf(az, A_0);
		cf(a2, A_0);
		cf(a0, A_0);
		cf(a1, A_0);
		int[] a_ = null;
		cf(a_, A_0);
		A_0.Write(a3);
		A_0.Write(a4);
		A_0.Write(a5);
		A_0.Write(a6);
		A_0.Write(ba.ToBinary());
		A_0.Write(bb);
		i3.a(bc, A_0);
		cf(bd, A_0);
		A_0.Write((int)be);
		cf(bf, A_0);
		cf(bg, A_0);
		cf(bh.e(), A_0);
		i3.a(bh.c(), A_0);
		A_0.Write(bm);
		A_0.Write(bn);
		if (bo != null)
		{
			A_0.Write(value: true);
			bo.d(A_0);
		}
		else
		{
			A_0.Write(value: false);
		}
		if (b9 == null)
		{
			b9 = string.Empty;
		}
		A_0.Write(b9);
		if (ca == null)
		{
			ca = string.Empty;
		}
		A_0.Write(ca);
		A_0.Write(Guid.NewGuid().ToString());
		i3.a(x, A_0);
		A_0.Write(bp);
		A_0.Write(this.j);
		A_0.Write(bi != null);
		if (bi != null)
		{
			cf(bi.e(), A_0);
			i3.a(bi.c(), A_0);
		}
		cf(t, A_0);
		cf(ai, A_0);
		cf(aj, A_0);
		cf(al, A_0);
		cf(am, A_0);
		cf(an, A_0);
		A_0.Write(bq);
		A_0.Write(br);
		if (bs != null)
		{
			A_0.Write(bs);
		}
		else
		{
			A_0.Write(string.Empty);
		}
		cf(u, A_0);
		cf(aq, A_0);
		cf(ar, A_0);
		cf(at, A_0);
		cf(au, A_0);
		cf(av, A_0);
		A_0.Write(bt);
		A_0.Write(bu);
		hi hi2 = this.l.b3(this.m);
		A_0.Write(hi2.cs.Count);
		foreach (gd c in hi2.cs)
		{
			c.i(A_0);
		}
		i3.a(y, A_0);
		i3.a(z, A_0);
		i3.a(aa, A_0);
		i3.a(ak, A_0);
		i3.a(@as, A_0);
		i3.a(af, A_0);
		i3.a(ao, A_0);
		i3.a(aw, A_0);
		i3.a(ag, A_0);
		i3.a(ap, A_0);
		i3.a(ax, A_0);
		A_0.Write(a9);
		A_0.Write((int)this.o);
		A_0.Write((int)this.p);
		A_0.Write((int)this.q);
		i3.a(bw, A_0);
		A_0.Write(bx != null);
		if (bx != null && this.c != null)
		{
			hr hr2 = this.c;
			bx.ao(A_0, hr2.cz(), hr2.cv(), hr2.c2());
			hr2 = null;
		}
		int num = 0;
		do
		{
			if (by != null && by[num] != null)
			{
				A_0.Write(value: true);
				by[num].d(A_0);
			}
			else
			{
				A_0.Write(value: false);
			}
			num = checked(num + 1);
		}
		while (num <= 2);
		A_0.Write(value: false);
		if (bz != null)
		{
			A_0.Write(value: true);
			A_0.Write(bz.a);
		}
		else
		{
			A_0.Write(value: false);
		}
		if (cb != null)
		{
			A_0.Write(value: true);
			A_0.Write(cb.b7());
			A_0.Write(cb.c9());
			A_0.Write(cb.ee());
		}
		else
		{
			A_0.Write(value: false);
		}
		A_0.Write(this.m);
		if (b0 != null)
		{
			A_0.Write(value: true);
			h h10 = b0;
			A_0.Write(h10.c);
			A_0.Write(h10.a);
			A_0.Write(h10.b);
			h10 = null;
		}
		else
		{
			A_0.Write(value: false);
		}
		if (b1 != null)
		{
			A_0.Write(value: true);
			i i10 = b1;
			A_0.Write(i10.a);
			A_0.Write(i10.b);
			A_0.Write(i10.c);
			i10 = null;
		}
		else
		{
			A_0.Write(value: false);
		}
		if (b2 != null)
		{
			A_0.Write(value: true);
			A_0.Write(b2.a);
			A_0.Write(b3);
		}
		else
		{
			A_0.Write(value: false);
			A_0.Write(value: false);
		}
		if (b5)
		{
			A_0.Write(value: true);
		}
		else
		{
			A_0.Write(value: false);
		}
		A_0.Write(b6);
		if (b7 == null)
		{
			b7 = string.Empty;
		}
		A_0.Write(b7);
		A_0.Write(this.g);
	}

	[SpecialName]
	public ch cy(int A_0)
	{
		return cf(A_0, a2, az);
	}

	[SpecialName]
	public ch cz(int A_0)
	{
		return cf(A_0, a2, ay);
	}

	protected ch cf(int A_0, int[] A_1, Collection<ch> A_2)
	{
		int upperBound = A_1.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (A_1[num] == A_0)
			{
				return A_2[num];
			}
		}
		return null;
	}

	[SpecialName]
	public Collection<ch> eh()
	{
		return az;
	}

	[SpecialName]
	public ga c0(int A_0)
	{
		return cf(A_0, a2, a1);
	}

	[SpecialName]
	public ga c1(int A_0)
	{
		return cf(A_0, a2, a0);
	}

	protected ga cf(int A_0, int[] A_1, Collection<ga> A_2)
	{
		int upperBound = A_1.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (A_1[num] == A_0)
			{
				return A_2[num];
			}
		}
		return null;
	}

	[SpecialName]
	public Collection<ga> ei()
	{
		return a1;
	}

	[SpecialName]
	public Collection<ch> ej()
	{
		return ay;
	}

	[SpecialName]
	public int ek()
	{
		if (ay != null)
		{
			return ay.Count;
		}
		return 0;
	}

	[SpecialName]
	public Collection<ga> el()
	{
		return a0;
	}

	[SpecialName]
	public int em()
	{
		if (a0 != null)
		{
			return a0.Count;
		}
		return 0;
	}

	[SpecialName]
	public string en()
	{
		return a5;
	}

	[SpecialName]
	public string eo()
	{
		return a6;
	}

	[SpecialName]
	public string ep()
	{
		return a3;
	}

	[SpecialName]
	public string eq()
	{
		return a4;
	}

	[SpecialName]
	public int[] er()
	{
		return a7;
	}

	[SpecialName]
	public string[] es()
	{
		return a8;
	}

	public void cf(cc A_0)
	{
		cc cc2 = A_0;
		cc2.c = this.c;
		cc2.d = this.d;
		cc2.e = this.e;
		cc2.f = this.f;
		cc2.h = this.h;
		cc2.i = this.i;
		cc2.j = this.j;
		cc2.k = this.k;
		this.l.bu(ref cc2.l);
		cc2.m = this.m;
		cc2.n = this.n;
		cc2.r = r;
		cc2.s = s;
		cc2.t = t;
		cc2.u = u;
		cc2.v = v;
		cc2.w = w;
		cc2.x = x;
		cc2.y = y;
		cc2.z = z;
		cc2.aa = aa;
		cc2.ab = ab;
		cc2.ac = ac;
		cc2.ad = ad;
		cc2.af = af;
		cc2.ag = ag;
		cc2.ae = ae;
		cc2.ai = ai;
		cc2.aj = aj;
		cc2.ak = ak;
		cc2.al = al;
		cc2.am = am;
		cc2.ao = ao;
		cc2.ap = ap;
		cc2.an = an;
		cc2.aq = aq;
		cc2.ar = ar;
		cc2.@as = @as;
		cc2.at = at;
		cc2.au = au;
		cc2.aw = aw;
		cc2.ax = ax;
		cc2.av = av;
		cc2.ay = ay;
		cc2.az = az;
		cc2.a0 = a0;
		cc2.a1 = a1;
		cc2.a2 = a2;
		cc2.a3 = a3;
		cc2.a4 = a4;
		cc2.a5 = a5;
		cc2.a6 = a6;
		cc2.a7 = a7;
		cc2.a8 = a8;
		cc2.ba = ba;
		cc2.bb = bb;
		cc2.bc = bc;
		cc2.bd = bd;
		cc2.be = be;
		cc2.bf = bf;
		cc2.bg = bg;
		cc2.bh = bh;
		cc2.bi = bi;
		cc2.bm = bm;
		cc2.bn = bn;
		cc2.bo = bo;
		cc2.bp = bp;
		cc2.bq = bq;
		cc2.br = br;
		cc2.bs = bs;
		cc2.bt = bt;
		cc2.bu = bu;
		cc2.b9 = b9;
		cc2.ca = ca;
		cc2.bx = bx;
		cc2.cb = cb;
		cc2.b5 = b5;
		cc2.b6 = b6;
		cc2.b7 = b7;
		cc2.g = this.g;
		cc2 = null;
	}

	[SpecialName]
	public string et()
	{
		return a3;
	}
}
