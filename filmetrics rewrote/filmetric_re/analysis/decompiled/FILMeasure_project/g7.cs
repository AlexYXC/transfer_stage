using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using FIUVSourceLib;
using FIUsbIntLib;
using Filmetrics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class g7 : gu, IDisposable
{
	public new delegate void a(Guid A_0, string A_1);

	private new enum b
	{
		a,
		b,
		c,
		d
	}

	private new enum c
	{
		a,
		b,
		c
	}

	public new class d
	{
		public int a;

		public float b;

		public d(int A_0, float A_1)
		{
			a = A_0;
			b = A_1;
		}
	}

	public const float hn = 1000f;

	public const float ho = -30f;

	public const float ib = 30f;

	public const float ic = 1f;

	public const float id = 0.08f;

	public const int ie = 200;

	public const int @if = 10;

	private bool ig;

	private ep ih;

	private cg ii;

	private UVSource ij;

	private bw ik;

	private ad il;

	private h5 im;

	private bool @in;

	private bool io;

	private h5 ip;

	private Collection<ip>[] iq;

	private List<string> ir;

	private Collection<@in> @is;

	private @in.d it;

	private int[] iu;

	private bool[] iv;

	private float[] iw;

	private global::h.f[] ix;

	private bool[] iy;

	private bool[] iz;

	private h5 i0;

	private Collection<int[]> i1;

	private Collection<int[]> i2;

	private Collection<double[]> i3;

	private Collection<double[]> i4;

	private Collection<Guid> i5;

	private Collection<Guid> i6;

	private Collection<int> i7;

	private Collection<hc> i8;

	private h i9;

	private global::r.c ja;

	private i jb;

	private i jc;

	private i jd;

	private i je;

	private global::r.d jf;

	private global::r.d jg;

	private global::r.d jh;

	private global::r.c ji;

	private global::r.c jj;

	private DateTime jk;

	private string jl;

	private string jm;

	private int jn;

	private bool jo;

	private int[] jp;

	private int[] jq;

	private float[] jr;

	private int[] js;

	private int[] jt;

	private int[] ju;

	private int[][] jv;

	private int[][] jw;

	private int[][] jx;

	private int[][] jy;

	private float[][] jz;

	private int[] j0;

	private int[] j1;

	private double[][] j2;

	private Guid[] j3;

	private Guid[] j4;

	private g3 j5;

	private object j6;

	private bool j7;

	private global::r.d.a.b j8;

	private string j9;

	private bool ka;

	private double[] kb;

	private bool kc;

	private bool kd;

	private Collection<float[]> ke;

	private Collection<float[]> kf;

	private Collection<float[]> kg;

	private Collection<float[]> kh;

	private Collection<float[]> ki;

	private Collection<float[]> kj;

	private Collection<float[]> kk;

	private Collection<float[]> kl;

	private Collection<float> km;

	private Collection<float[]> kn;

	private Collection<float[]> ko;

	private Collection<float[]> kp;

	private Collection<float[]> kq;

	private Collection<float[]> kr;

	private Collection<float[]> ks;

	private Collection<float[]> kt;

	private Collection<float[]> ku;

	private Collection<float> kv;

	private float kw;

	private const float kx = 200f;

	private const long ky = 1500L;

	private bool kz;

	private bool k0;

	private bool k1;

	private l k2;

	private j k3;

	private bool k4;

	private string k5;

	private float k6;

	private bool k7;

	private bool k8;

	private const int k9 = 500;

	private cd la;

	private bool lb;

	private byte lc;

	private string ld;

	private int le;

	private bool lf;

	private bool lg;

	private float lh;

	private bool[] li;

	private bool lj;

	private DateTime lk;

	private float ll;

	private const int lm = 10;

	private float[] ln;

	private DateTime[] lo;

	private int lp;

	private const float lq = 1f;

	private const float lr = 5f;

	private const float ls = 0.1f;

	private float lt;

	private bool lu;

	private bool lv;

	private const float lw = 3f;

	private DateTime lx;

	private bool ly;

	public bool lz;

	private bool l0;

	private bool l1;

	private d4 l2;

	[CompilerGenerated]
	private a l3;

	private const float l4 = 70f;

	private global::r.d l5;

	private jl l6;

	private g6 l7;

	private g6 l8;

	[CompilerGenerated]
	private System.Timers.Timer l9;

	private e0 ma;

	private Collection<string> mb;

	private int mc;

	private int md;

	private double me;

	private Collection<double> mf;

	private Collection<double[]> mg;

	private Collection<string> mh;

	private const float mi = 185f;

	private const float mj = 2200f;

	private const int mk = 50;

	private int ml;

	private bool mm;

	private bool mn;

	private bool mo;

	private bool mp;

	private bool mq;

	private const string mr = "\\signalValues.csv";

	private bool ms;

	[SpecialName]
	private string mt;

	[SpecialName]
	private Collection<h.a> mu;

	[SpecialName]
	private StaticLocalInitFlag mv;

	[SpecialName]
	private DateTime mw;

	[SpecialName]
	private StaticLocalInitFlag mx;

	[SpecialName]
	private int my;

	[SpecialName]
	private List<bool[]> mz;

	[SpecialName]
	[CompilerGenerated]
	public void m2(a A_0)
	{
		a a10 = l3;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Combine(a11, A_0);
			a10 = Interlocked.CompareExchange(ref l3, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void p9(a A_0)
	{
		a a10 = l3;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Remove(a11, A_0);
			a10 = Interlocked.CompareExchange(ref l3, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer ux()
	{
		return l9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void m2(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = m2;
		System.Timers.Timer timer = l9;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		l9 = A_0;
		timer = l9;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	public g7(fz A_0, Guid A_1, gt A_2, hg A_3, hd A_4, b5 A_5, g2 A_6, he A_7, bool A_8)
		: base(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8)
	{
		ir = new List<string>();
		it = new @in.d();
		jj = new global::r.c();
		jl = string.Empty;
		jm = string.Empty;
		jn = -1;
		jo = false;
		j5 = new g3();
		ld = string.Empty;
		li = new bool[checked(global::h.a() + 1)];
		lj = false;
		ln = new float[10];
		lo = new DateTime[10];
		lt = 1f;
		lu = false;
		lv = false;
		lz = false;
		l0 = false;
		l1 = false;
		m2(new System.Timers.Timer());
		mb = new Collection<string>();
		mf = new Collection<double>();
		mg = new Collection<double[]>();
		mh = new Collection<string>();
		mm = true;
		mn = true;
		mo = true;
		mp = true;
		mq = true;
		uw();
		l6 = new jl(A_0);
	}

	public g7(fz A_0, Guid A_1, string A_2, hg A_3, hd A_4, b5 A_5, g2 A_6, he A_7, bool A_8, ep A_9, cg A_10, a A_11, global::r.d A_12)
		: base(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8)
	{
		ir = new List<string>();
		it = new @in.d();
		jj = new global::r.c();
		jl = string.Empty;
		jm = string.Empty;
		jn = -1;
		jo = false;
		j5 = new g3();
		ld = string.Empty;
		li = new bool[checked(global::h.a() + 1)];
		lj = false;
		ln = new float[10];
		lo = new DateTime[10];
		lt = 1f;
		lu = false;
		lv = false;
		lz = false;
		l0 = false;
		l1 = false;
		m2(new System.Timers.Timer());
		mb = new Collection<string>();
		mf = new Collection<double>();
		mg = new Collection<double[]>();
		mh = new Collection<string>();
		mm = true;
		mn = true;
		mo = true;
		mp = true;
		mq = true;
		m2(A_11);
		m2(A_9, A_10);
		l5 = A_12;
	}

	private void m2(ep A_0, cg A_1)
	{
		ih = A_0;
		ii = A_1;
		uw();
	}

	private void uw()
	{
		j6 = RuntimeHelpers.GetObjectValue(new object());
		i8 = new Collection<hc>();
		i9 = new h();
		ja = new global::r.c();
		jb = new i();
		jc = new i();
		jd = new i();
		je = new i();
		jf = new global::r.d();
		jg = new global::r.d();
		jh = new global::r.d();
		ji = new global::r.c();
		jk = DateAndTime.Now;
		p9(hb, A_1: false);
		hg A_ = new hg(hb.dh(), hb.cd());
		hb.bu(ref A_);
		qh(A_);
		hb.bu(m2, sj);
		k3 = new j();
	}

	[SpecialName]
	public g6 uy()
	{
		return l7;
	}

	public void m2(g6 A_0, global::r.d.a.b A_1)
	{
		q q2 = new q(A_1);
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q2).a = m.a.a4;
		q2.g = new global::r.d();
		q2.j = A_0;
		_ = null;
		string A_2 = null;
		string A_3 = null;
		m2(ref A_2, ref A_3, q2);
	}

	[SpecialName]
	public bool uz()
	{
		if (iq == null || iq.Length < 1)
		{
			return false;
		}
		int lowerBound = iq.GetLowerBound(0);
		for (int num = 0; num <= lowerBound; num = checked(num + 1))
		{
			foreach (ip item in iq[num])
			{
				if (item != null && item.yb())
				{
					return true;
				}
			}
		}
		return false;
	}

	[SpecialName]
	public bool u0()
	{
		if (iq == null)
		{
			return false;
		}
		int lowerBound = iq.GetLowerBound(0);
		for (int num = 0; num <= lowerBound; num = checked(num + 1))
		{
			foreach (ip item in iq[num])
			{
				if (item != null && item.v2())
				{
					return true;
				}
			}
		}
		return false;
	}

	public long u1()
	{
		bool flag = false;
		try
		{
			if (Monitor.TryEnter(RuntimeHelpers.GetObjectValue(j6), 300))
			{
				flag = true;
				return j5.a();
			}
			throw new ao("Timeout attempting to lock mStepIDLocker in AcquireStepID");
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(RuntimeHelpers.GetObjectValue(j6));
			}
		}
	}

	private bool s4(int A_0)
	{
		bool flag = true;
		string left = null;
		string right = null;
		checked
		{
			try
			{
				if (iq[A_0].Count > 1)
				{
					foreach (ip item in iq[A_0])
					{
						if (item.xr())
						{
							return true;
						}
					}
					int num = iq[A_0].Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						if (num2 == 0)
						{
							left = iq[A_0][num2].abn();
						}
						else
						{
							right = iq[A_0][num2].abn();
						}
					}
					if (Operators.CompareString(left, right, TextCompare: false) == 0)
					{
						return false;
					}
					return true;
				}
				return false;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}
	}

	public bool u2()
	{
		Collection<m> collection = new Collection<m>();
		Collection<m> collection2 = new Collection<m>();
		bool flag = false;
		bool flag2 = false;
		try
		{
			if (vj() || wt() || zp() == g2.a.b || iq == null)
			{
				return false;
			}
			if (u9() && !yl() && !ym())
			{
				return false;
			}
			if (hb.dh().bq() || xs())
			{
				return false;
			}
			flag = Monitor.TryEnter(zy(), 300);
			if (flag)
			{
				collection = zy();
			}
			flag2 = Monitor.TryEnter(zz(), 300);
			if (flag2)
			{
				collection2 = zz();
			}
			if ((collection.Count == 0) & (collection2.Count == 0))
			{
				return true;
			}
			foreach (m item in collection)
			{
				m.TaskExecutionType taskExecutionType = item.d;
				if (taskExecutionType != m.TaskExecutionType.Spectrometer)
				{
					continue;
				}
				if (item.a == m.a.f)
				{
					if (!item.l.q())
					{
						return false;
					}
				}
				else if (item.a == m.a.c && item.l != null && !item.l.q())
				{
					return false;
				}
			}
			foreach (m item2 in collection2)
			{
				m.TaskExecutionType taskExecutionType2 = item2.d;
				if (taskExecutionType2 != m.TaskExecutionType.Spectrometer)
				{
					continue;
				}
				if (item2.a == m.a.f)
				{
					if (!item2.l.q())
					{
						return false;
					}
				}
				else if (item2.a == m.a.c && item2.l != null && !item2.l.q())
				{
					return false;
				}
			}
			return true;
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(zy());
			}
			if (flag2)
			{
				Monitor.Exit(zz());
			}
		}
	}

	[SpecialName]
	public bool u3()
	{
		if (ma != null)
		{
			return ma.f();
		}
		return false;
	}

	[SpecialName]
	public bool u4()
	{
		if (iq == null || iq[0] == null || iq[0].Count == 0)
		{
			return false;
		}
		return iq[0][0].v1();
	}

	[SpecialName]
	public bool u5()
	{
		if (iq == null || iq[0] == null || iq[0].Count == 0)
		{
			return false;
		}
		return k7;
	}

	[SpecialName]
	public bool u6()
	{
		if (iq == null || iq[0] == null || iq[0].Count == 0)
		{
			return false;
		}
		return ii != null && ii.f() > 0;
	}

	[SpecialName]
	public bool u7()
	{
		return ik != null;
	}

	[SpecialName]
	public bool u8()
	{
		return false;
	}

	[SpecialName]
	private bool uv()
	{
		if (iq == null || iq[0] == null || iq[0].Count == 0)
		{
			return false;
		}
		return iq[0][0].vf();
	}

	[SpecialName]
	public bool u9()
	{
		if (iq == null || iq[0] == null || iq[0].Count == 0)
		{
			return false;
		}
		return k8;
	}

	public bool m2(hc A_0)
	{
		hr hr2 = b9.m2(A_0.cn(), hb);
		bool result;
		try
		{
			int A_1 = default(int);
			int A_2 = default(int);
			m2(hb, hr2.cz(), hr2.cu().q() != null, ref A_1, ref A_2);
			result = A_1 != A_0.cq() || A_2 != A_0.cr();
		}
		catch (ag ag2)
		{
			ProjectData.SetProjectError(ag2);
			ag ag3 = ag2;
			result = true;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[SpecialName]
	public bool va()
	{
		return ly;
	}

	[SpecialName]
	public void st(bool A_0)
	{
		ly = A_0;
	}

	private void m2(bool A_0, bool A_1, bool A_2, bool A_3)
	{
		if (A_2 && hc.b8().a(v4(), uq()))
		{
			m2(A_0, A_1);
		}
		else
		{
			m2(A_0, A_1, A_3);
		}
	}

	private void m2(bool A_0, bool A_1, bool A_2)
	{
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			m2(A_0, A_1, num, A_2);
		}
	}

	private void m2(bool A_0, bool A_1, int A_2, bool A_3)
	{
		checked
		{
			int num = iq[A_2].Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (p9(hc.b8(), num2, A_2) || A_3)
				{
					iq[A_2][num2].p9(A_0, A_1);
				}
			}
		}
	}

	public bool s3(bool A_0)
	{
		if (A_0 && hb.b8().a(v4(), uq()))
		{
			return sn();
		}
		return uu();
	}

	private bool uu()
	{
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (!s3(num))
			{
				return false;
			}
		}
		return true;
	}

	private bool s3(int A_0)
	{
		checked
		{
			int num = iq[A_0].Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (p9(hc.b8(), num2, A_0) && !iq[A_0][num2].wf())
				{
					return false;
				}
			}
			return true;
		}
	}

	public bool s4(bool A_0)
	{
		if (A_0 && hb.b8().a(v4(), uq()))
		{
			return so();
		}
		return ut();
	}

	private bool ut()
	{
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (!st(num))
			{
				return false;
			}
		}
		return true;
	}

	private bool st(int A_0)
	{
		checked
		{
			int num = iq[A_0].Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (p9(hc.b8(), num2, A_0) && !iq[A_0][num2].wg())
				{
					return false;
				}
			}
			return true;
		}
	}

	[SpecialName]
	public string qh(int A_0, int A_1)
	{
		ip ip2 = iq[A_0][A_1];
		if (ip2.abc() > 0)
		{
			return ip2.abo() + "-" + checked(ip2.ut() + 1);
		}
		return ip2.abo();
	}

	[SpecialName]
	public int vb()
	{
		if (iq == null || iq.Length == 0)
		{
			return 0;
		}
		Collection<ip>[] array = iq;
		foreach (Collection<ip> collection in array)
		{
			if (collection == null)
			{
				continue;
			}
			foreach (ip item in collection)
			{
				if (item != null)
				{
					return checked(item.ut() + 1);
				}
			}
		}
		return 0;
	}

	[SpecialName]
	public string s6(int A_0)
	{
		if (iq == null || iq.Length < 1 || A_0 > iq.GetUpperBound(0) || iq[A_0] == null || iq[A_0].Count == 0)
		{
			return string.Empty;
		}
		return iq[A_0][0].abd();
	}

	public void m2(string A_0)
	{
		if (iq == null || iq.Length <= 0)
		{
			return;
		}
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (iq[num] == null)
			{
				continue;
			}
			foreach (ip item in iq[num])
			{
				item.p9(A_0);
			}
		}
		he.d(A_0);
	}

	[SpecialName]
	public string vc()
	{
		if (iq != null && iq[0] != null && iq[0].Count > 0 && iq[0][0] != null)
		{
			ip ip2 = iq[0][0];
			string text = h6.m2(ip2.b(), ip2.c(), null, ip2.zi());
			string text2 = null;
			if (ip2.abc() > ip2.abb())
			{
				text2 = " - " + checked(ip2.uz() + 1);
			}
			return text + ":" + ip2.abo() + text2;
		}
		return ww();
	}

	private bool s4(global::h A_0)
	{
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (p9(A_0, num, A_2: true))
			{
				return false;
			}
		}
		return true;
	}

	private bool qh(global::h A_0, int A_1, bool A_2)
	{
		if (s4(A_0))
		{
			return A_1 == 0;
		}
		if (A_2)
		{
			return p9(A_0, A_1, A_2: false);
		}
		return p9(A_0, A_1, A_2: true);
	}

	private bool sn(global::h A_0, int A_1)
	{
		if (s4(A_0))
		{
			return A_1 == 0;
		}
		return p9(A_0, A_1, A_2: true);
	}

	private bool sm(global::h A_0, int A_1)
	{
		if (s4(A_0))
		{
			return A_1 == 0;
		}
		return p9(A_0, A_1, A_2: false);
	}

	private bool p9(global::h A_0, int A_1, bool A_2)
	{
		if (A_1 < 0)
		{
			return false;
		}
		if (ix.GetUpperBound(0) == 0)
		{
			return true;
		}
		global::h.f f10 = ix[A_1];
		global::h.e e10 = A_0.a(iv);
		if (A_2 && vk() && global::h.p(e10) && f10 == global::h.f.b)
		{
			return true;
		}
		switch (e10)
		{
		case global::h.e.a:
			return true;
		case global::h.e.f:
			if (f10 == global::h.f.a || f10 == global::h.f.c)
			{
				return true;
			}
			break;
		case global::h.e.e:
			switch (f10)
			{
			case global::h.f.a:
				return true;
			case global::h.f.b:
				return true;
			}
			break;
		case global::h.e.g:
			switch (f10)
			{
			case global::h.f.b:
				return true;
			case global::h.f.c:
				return true;
			}
			break;
		case global::h.e.b:
			if (f10 == global::h.f.a)
			{
				return true;
			}
			break;
		case global::h.e.c:
			if (f10 == global::h.f.b)
			{
				return true;
			}
			break;
		case global::h.e.d:
			if (f10 == global::h.f.c)
			{
				return true;
			}
			break;
		}
		return false;
	}

	private bool p9(global::h A_0, int A_1, int A_2)
	{
		return p9(A_0, A_1, A_2, A_3: true);
	}

	private bool m2(global::h A_0, int A_1, int A_2)
	{
		return p9(A_0, A_1, A_2, A_3: false);
	}

	private bool p9(global::h A_0, int A_1, int A_2, bool A_3)
	{
		if (!p9(A_0, A_2, A_3))
		{
			return false;
		}
		global::h.f a_ = ((!A_0.t()) ? ix[A_2] : global::h.f.a);
		global::f f10 = A_0.a((int)a_);
		if (iq[A_2].Count > 1)
		{
			bool a_2 = so(A_2);
			return f10.b(a_2) == global::f.a.a || f10.b(a_2) == global::f.a.d || (f10.b(a_2) == global::f.a.b && sj(A_2) == A_1) || (f10.b(a_2) == global::f.a.c && qh(A_2) == A_1);
		}
		return iq[A_2].Count > 0;
	}

	private int p9(p A_0, global::h A_1)
	{
		int num = 0;
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			for (int num2 = 0; num2 <= upperBound; num2++)
			{
				if (!sn(A_1, num2))
				{
					continue;
				}
				int num3 = iq[num2].Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (p9(A_1, num4, num2))
					{
						num++;
					}
				}
			}
			return num;
		}
	}

	private int m2(p A_0, global::h A_1)
	{
		int num = 0;
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			for (int num2 = 0; num2 <= upperBound; num2++)
			{
				if (!sn(A_1, num2))
				{
					continue;
				}
				int num3 = iq[num2].Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (!p9(A_1, num4, num2) || !p9(A_1, num2, A_0.n[num2], A_0.aj, A_0.ak))
					{
						continue;
					}
					switch (A_0.n[num2])
					{
					case n.f:
						if (ix[num2] != global::h.f.b)
						{
							num += 2;
						}
						break;
					case n.c:
					case n.g:
						num = ((iq[num2][num4].u3() == global::h.MeasurementTimingType.Manual) ? (num + 1) : (num + 2));
						break;
					case n.h:
						num = ((!hc.d0().n()) ? ((iq[num2][num4].u3() == global::h.MeasurementTimingType.Manual) ? (num + 1) : (num + 2)) : (num + 1));
						break;
					case n.d:
					case n.e:
						num = ((!A_0.z[num2]) ? (num + 1) : (num + 2));
						break;
					}
				}
			}
			if (l2 != null)
			{
				num++;
			}
			return num;
		}
	}

	public void vd()
	{
		if (iq == null || iq.Length <= 0)
		{
			return;
		}
		int upperBound = iq.GetUpperBound(0);
		List<string> list = new List<string>();
		int num = upperBound;
		checked
		{
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (iq[num2] == null)
				{
					continue;
				}
				string item = iq[num2][0].abn();
				if (list.IndexOf(item) < 0)
				{
					iq[num2][0].so(A_0: true);
					list.Add(item);
				}
				int num3 = iq[num2].Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (iq[num2][num4].w8() != 0)
					{
						ab8().c(fz.b.b, "Error in call to CheckAndRefreshHardwareIfNeeded for submoduleIdx = " + num2 + ", specIdx = " + num4);
					}
				}
			}
		}
	}

	[SpecialName]
	public int[] ve()
	{
		if (iq == null)
		{
			return null;
		}
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			int[] array = new int[upperBound + 1];
			int num = upperBound;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (iq[num2] != null)
				{
					array[num2] = iq[num2].Count;
				}
			}
			return array;
		}
	}

	public bool[] vf()
	{
		if (iq == null)
		{
			return null;
		}
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			bool[] array = new bool[upperBound + 1];
			int num = upperBound;
			for (int num2 = 0; num2 <= num; num2++)
			{
				array[num2] = so(num2);
			}
			return array;
		}
	}

	public bool sn(hg A_0)
	{
		if (iq == null)
		{
			return false;
		}
		int upperBound = iq.GetUpperBound(0);
		bool flag = false;
		checked
		{
			bool[] array = new bool[upperBound + 1];
			int num = upperBound;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (sm(num2))
				{
					array[num2] = true;
					if (!m2(A_0, num2))
					{
						flag = true;
					}
				}
			}
			if (flag)
			{
				List<global::h> A_1 = null;
				List<bool> A_2 = null;
				if (m2(A_0, ref A_1, ref A_2))
				{
					bool flag2 = A_0.ed().ft();
					bool flag3 = false;
					bool result = true;
					int num3 = upperBound;
					global::f.a a11 = default(global::f.a);
					for (int num4 = 0; num4 <= num3; num4++)
					{
						if (qh(A_0.b8(), num4, A_2: true))
						{
							global::f.a a10 = A_0.b8().a(num4).b(!array[num4]);
							if (a10 == global::f.a.a || a10 == global::f.a.d || (flag3 && a10 != a11))
							{
								return false;
							}
							if (flag2 && !m2(num4, !array[num4], a10, A_1, A_2))
							{
								result = false;
							}
							a11 = a10;
							flag3 = true;
						}
					}
					return result;
				}
				return false;
			}
			return false;
		}
	}

	[SpecialName]
	public int s8(int A_0)
	{
		if (iq == null)
		{
			return 0;
		}
		if (iq.GetUpperBound(0) < A_0)
		{
			return 0;
		}
		if (iq[A_0] == null)
		{
			return 0;
		}
		return iq[A_0].Count;
	}

	[SpecialName]
	public bool vg()
	{
		if (iq == null)
		{
			return false;
		}
		if (iq.Length != 1)
		{
			return false;
		}
		Collection<ip> collection = iq[0];
		if (collection.Count != 2)
		{
			return false;
		}
		return collection[0].aby() != collection[1].aby();
	}

	private bool so(int A_0)
	{
		if (iq == null)
		{
			return true;
		}
		if (A_0 < 0)
		{
			return true;
		}
		if (iq.GetUpperBound(0) < A_0)
		{
			return true;
		}
		return iq[A_0].Count != 2 || sn(A_0);
	}

	private bool sn(int A_0)
	{
		Collection<ip> collection = iq[A_0];
		if (collection.Count < 2)
		{
			return false;
		}
		int index = sj(A_0);
		int index2 = qh(A_0);
		return collection[index].vv() >= collection[index2].vu();
	}

	private bool sm(int A_0)
	{
		if (iq == null)
		{
			return false;
		}
		if (A_0 < 0)
		{
			return false;
		}
		if (iq.GetUpperBound(0) < A_0)
		{
			return false;
		}
		return iq[A_0].Count == 2 && !sn(A_0);
	}

	private bool m2(hg A_0, int A_1)
	{
		float A_2 = default(float);
		float A_3 = default(float);
		A_0.bu(ref A_2, ref A_3);
		if (s8(A_1) > 1)
		{
			int index = sj(A_1);
			int index2 = qh(A_1);
			Collection<ip> collection = iq[A_1];
			return A_2 < collection[index].vv() && A_3 > collection[index2].vu();
		}
		Collection<ip> collection2 = iq[A_1];
		return A_2 < collection2[0].vv() && A_3 > collection2[0].vu();
	}

	private bool m2(hg A_0, ref List<global::h> A_1, ref List<bool> A_2)
	{
		hi hi2 = A_0.ed();
		bool result = false;
		if (hi2.et())
		{
			A_1 = new List<global::h>();
			A_2 = new List<bool>();
			hg.j a_ = (hg.j)A_0.cc();
			hg hg2 = new hg(A_0.dh(), a_);
			if (hi2.fu())
			{
				result = true;
			}
			foreach (hj item in hi2.es())
			{
				hg2.bu(Path.Combine(global::i3.m(), "Recipes", item.e()), a_, null, global::r.d.a.b.a, A_4: true, A_5: false, default(Point), null, g2.b.a, A_9: true, null, null, A_12: false, A_13: false, null, A_15: false);
				if (hg2.ed().fu())
				{
					result = true;
				}
				if (item.g())
				{
					A_1.Add(hg2.b8());
					A_2.Add(hg2.ed().ft());
				}
			}
			return result;
		}
		return false;
	}

	private bool m2(int A_0, bool A_1, global::f.a A_2, List<global::h> A_3, List<bool> A_4)
	{
		checked
		{
			int num = A_3.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				global::f.a a10 = A_3[num2].a(A_0).b(A_1);
				if ((a10 == global::f.a.b || a10 == global::f.a.c) && a10 != A_2 && !A_4[num2])
				{
					return true;
				}
			}
			bool result = default(bool);
			return result;
		}
	}

	public void m2(int A_0, ref double A_1, ref double A_2)
	{
		A_1 = double.MaxValue;
		A_2 = double.MinValue;
		checked
		{
			int num = iq[A_0].Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (p9(hb.b8(), num2, A_0))
				{
					double num3 = iq[A_0][num2].vu();
					double num4 = iq[A_0][num2].vv();
					if (num3 < A_1)
					{
						A_1 = num3;
					}
					if (num4 > A_2)
					{
						A_2 = num4;
					}
				}
			}
		}
	}

	public List<it> m2(bool A_0, global::h A_1)
	{
		if (A_0 && A_1.a(v4(), uq()))
		{
			return yy();
		}
		return vh();
	}

	public List<it> vh()
	{
		if (iq == null)
		{
			return null;
		}
		List<it> list = new List<it>();
		int upperBound = iq.GetUpperBound(0);
		int num = 0;
		int num2 = upperBound;
		checked
		{
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (iq[num3] != null)
				{
					int num4 = iq[num3].Count - 1;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						num = ((num5 != 0) ? qh(num3) : sj(num3));
						list.Add(new it(iq[num3][num].yq(), num3, num));
					}
				}
			}
			return list;
		}
	}

	public List<it> m2(hg A_0, bool A_1)
	{
		bool A_2 = false;
		int A_3 = 0;
		return m2(A_0, A_1, ref A_2, ref A_3);
	}

	public List<it> m2(hg A_0, bool A_1, ref bool A_2, ref int A_3)
	{
		if (iv == null)
		{
			return null;
		}
		bool flag = A_0.d0().c() == g2.a.c || A_0.d0().c() == g2.a.b;
		List<it> list = new List<it>();
		A_3 = p9(global::h.f.b);
		if (A_3 < 0)
		{
			A_3 = -2;
		}
		global::h h10 = A_0.b8();
		global::h.f[] array = null;
		global::h.e e10 = default(global::h.e);
		if (flag)
		{
			e10 = h10.a(vo());
			array = vp();
		}
		List<it> list2 = m2(A_1, A_0.b8());
		foreach (it item in list2)
		{
			bool flag2 = false;
			bool flag3 = false;
			if (flag)
			{
				if (array[item.g()] == global::h.f.b)
				{
					if (global::h.p(e10) || global::h.n(e10))
					{
						A_2 = e10 == global::h.e.c;
						flag3 = true;
					}
				}
				else if (array[item.g()] == global::h.f.a)
				{
					if (global::h.p(e10))
					{
						if (list2.Count > 2)
						{
							flag3 = true;
						}
						else
						{
							flag2 = true;
						}
					}
				}
				else if (array[item.g()] == global::h.f.c && global::h.d(e10))
				{
					if (list2.Count > 2)
					{
						flag3 = true;
					}
					else
					{
						flag2 = true;
					}
				}
			}
			else
			{
				flag3 = true;
			}
			if (flag3)
			{
				global::f.a a10;
				if (!flag || h10.t())
				{
					a10 = h10.a(0).b(so(iu[0]));
				}
				else
				{
					global::h.f f10 = array[item.g()];
					a10 = h10.a((int)f10).b(so(iu[(int)f10]));
				}
				flag2 = ((so(item.g(), item.f()) != global::f.b.b) ? (a10 == global::f.a.a || a10 == global::f.a.d || a10 == global::f.a.c || iq[item.g()].Count == 1) : (a10 == global::f.a.a || a10 == global::f.a.d || a10 == global::f.a.b || iq[item.g()].Count == 1));
			}
			if (flag2)
			{
				list.Add(item);
			}
		}
		h10 = null;
		return list;
	}

	public List<iv> vi()
	{
		if (iq == null)
		{
			return null;
		}
		List<iv> list = new List<iv>();
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			for (int num = 0; num <= upperBound; num++)
			{
				g2.OpticsConfigSubmoduleTypes a_ = g2.a(zp(), ix[num]);
				int num2 = s8(num) - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					list.Add(iq[num][num3].sn(a_));
				}
			}
			return list;
		}
	}

	public List<iu> m2(List<it> A_0, List<iv> A_1)
	{
		if (A_0 == null || A_1 == null)
		{
			return null;
		}
		List<iu> list = new List<iu>();
		foreach (it item in A_0)
		{
			if (A_1.IndexOf(new iv(item.e(), global::iv.a.a)) < 0)
			{
				continue;
			}
			iv iv2 = A_1[A_1.IndexOf(new iv(item.e(), global::iv.a.a))];
			foreach (iu item2 in iv2.b)
			{
				bool flag = true;
				foreach (it item3 in A_0)
				{
					if (Operators.CompareString(item3.e(), item.e(), TextCompare: false) != 0)
					{
						if (!A_1[A_1.IndexOf(new iv(item.e(), global::iv.a.a))].b.Contains(item2))
						{
							flag = false;
							break;
						}
						_ = null;
					}
				}
				if (flag && !list.Contains(item2))
				{
					list.Add(new iu(item2.c()));
				}
			}
		}
		if (list.Count > 0)
		{
			return list;
		}
		return null;
	}

	[SpecialName]
	public Collection tb(int A_0)
	{
		if (iq == null)
		{
			return null;
		}
		Collection collection = new Collection();
		checked
		{
			int num = iq[A_0].Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				ip ip2 = iq[A_0][num2];
				collection.Add(ip2.yq());
			}
			return collection;
		}
	}

	[SpecialName]
	public bool vj()
	{
		if (hj != null)
		{
			if (hj.ao() == FMLegacyAllSystemTypes.kTypeF10)
			{
				FMF10Subtypes fMF10Subtypes = (FMF10Subtypes)hj.an();
				return fMF10Subtypes == FMF10Subtypes.kFMF10SubtypeVC || fMF10Subtypes == FMF10Subtypes.kFMF10SubtypeRT || fMF10Subtypes == FMF10Subtypes.kFMF10SubtypeRTA;
			}
			if (hj.ao() == FMLegacyAllSystemTypes.kTypePARTS)
			{
				return true;
			}
			return false;
		}
		if (iq == null)
		{
			return false;
		}
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (iq[num] != null)
			{
				return iq[num][0].abb() > 0;
			}
		}
		return false;
	}

	[SpecialName]
	public bool vk()
	{
		if (hj != null)
		{
			if (hj.ao() == FMLegacyAllSystemTypes.kTypeF10)
			{
				FMF10Subtypes fMF10Subtypes = (FMF10Subtypes)hj.an();
				return fMF10Subtypes == FMF10Subtypes.kFMF10SubtypeVC || fMF10Subtypes == FMF10Subtypes.kFMF10SubtypeRT || fMF10Subtypes == FMF10Subtypes.kFMF10SubtypeRTA;
			}
			if (hj.ao() == FMLegacyAllSystemTypes.kTypePARTS)
			{
				return true;
			}
			if (hj.ao() == FMLegacyAllSystemTypes.kTypeF2)
			{
				return true;
			}
			return false;
		}
		bool flag = false;
		bool flag2 = false;
		if (iq == null)
		{
			return false;
		}
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (iq[num] != null)
			{
				if (ix[num] == global::h.f.a)
				{
					flag = true;
				}
				if (ix[num] == global::h.f.b)
				{
					flag2 = true;
				}
				if (flag && flag2)
				{
					return true;
				}
			}
		}
		return false;
	}

	[SpecialName]
	public List<string> vl()
	{
		List<string> list = new List<string>();
		checked
		{
			if (iq != null)
			{
				int num = iq.Length - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (iq[num2] == null)
					{
						continue;
					}
					int num3 = iq[num2].Count - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						string item = iq[num2][num4].abo();
						if (!list.Contains(item))
						{
							list.Add(item);
						}
					}
				}
			}
			return list;
		}
	}

	private ip p9(h6.b A_0, int A_1, int A_2)
	{
		switch (A_0)
		{
		case h6.b.b:
			if (iq == null || iq.GetUpperBound(0) < A_1 || iq[A_1] == null)
			{
				return null;
			}
			return iq[A_1][A_2];
		case h6.b.c:
			return null;
		default:
			return null;
		}
	}

	private ip m2(h6.b A_0, int A_1, global::f.b A_2)
	{
		switch (A_0)
		{
		case h6.b.b:
		{
			if (iq == null || iq.GetUpperBound(0) < A_1 || iq[A_1] == null)
			{
				return null;
			}
			int index = p9(A_1, A_2);
			return iq[A_1][index];
		}
		case h6.b.c:
			return null;
		default:
			return null;
		}
	}

	[SpecialName]
	public string p9(h6.b A_0, int A_1, global::f.b A_2)
	{
		ip ip2 = m2(A_0, A_1, A_2);
		if (ip2 == null)
		{
			return string.Empty;
		}
		return ip2.uq();
	}

	[SpecialName]
	public int qh(h6.b A_0, int A_1, int A_2)
	{
		return p9(A_0, A_1, A_2)?.us() ?? 0;
	}

	[SpecialName]
	public bool m2(h6.b A_0, int A_1, int A_2, SpectromTempSensorLoc A_3)
	{
		return p9(A_0, A_1, A_2)?.m2(A_3) ?? false;
	}

	[SpecialName]
	public bool m2(h6.b A_0, int A_1, global::f.b A_2, SpectromTempSensorLoc A_3)
	{
		return m2(A_0, A_1, p9(A_1, A_2), A_3);
	}

	[SpecialName]
	public bool vm()
	{
		if (iq == null)
		{
			return false;
		}
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			for (int num = 0; num <= upperBound; num++)
			{
				int num2 = iq[num].Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (p9(hb.b8(), num3, num) && !iq[num][num3].vt())
					{
						return false;
					}
				}
			}
			return true;
		}
	}

	[SpecialName]
	public bool qh(h6.b A_0, int A_1, global::f.b A_2)
	{
		return m2(A_0, A_1, A_2)?.vt() ?? false;
	}

	[SpecialName]
	private int us()
	{
		if (vj())
		{
			switch (hb.b8().a(iv))
			{
			case global::h.e.a:
				return checked(iq.GetUpperBound(0) + 1);
			case global::h.e.b:
			case global::h.e.c:
			case global::h.e.d:
				return 1;
			case global::h.e.e:
			case global::h.e.f:
			case global::h.e.g:
				return 2;
			default:
				return 0;
			}
		}
		return 1;
	}

	[SpecialName]
	public float vn()
	{
		return k6;
	}

	[SpecialName]
	public void p9(float A_0)
	{
		k6 = A_0;
	}

	[SpecialName]
	public bool[] vo()
	{
		return iv;
	}

	[SpecialName]
	public int p9(global::h.f A_0)
	{
		if (iu == null)
		{
			return -1;
		}
		return iu[(int)A_0];
	}

	[SpecialName]
	public global::h.f[] vp()
	{
		return ix;
	}

	[SpecialName]
	public float[] vq()
	{
		return iw;
	}

	[SpecialName]
	public bool[] vr()
	{
		return iy;
	}

	[SpecialName]
	public bool[] vs()
	{
		return iz;
	}

	[SpecialName]
	public a9.a vt()
	{
		if (ij != null)
		{
			switch (ij.SystemTypeUV)
			{
			case FISystemTypesUV.kSysTypeUVSource:
				if (ij.SystemSubtype == FMUVSourceSubTypes.kFMUVSourceSubtypeDT2)
				{
					return a9.a.f;
				}
				return a9.a.e;
			case FISystemTypesUV.kSysTypeHnl:
				return a9.a.g;
			default:
				throw new ai("Unknown light source type");
			}
		}
		if (im == null)
		{
			if (iq != null && iq[0] != null && iq[0].Count > 0 && iq[0][0] != null)
			{
				FIUsbController fIUsbController = iq[0][0].abk();
				if (fIUsbController.HasLightSourceOnTimer != 0 && fIUsbController.HasHighPowerLightSource != 0)
				{
					return a9.a.b;
				}
				return a9.a.a;
			}
			return a9.a.a;
		}
		if (im.abz())
		{
			return a9.a.a;
		}
		return a9.a.c;
	}

	[SpecialName]
	public a9.b vu()
	{
		FIUsbController fIUsbController;
		if (im == null)
		{
			if (iq == null || iq[0] == null || iq[0].Count <= 0 || iq[0][0] == null)
			{
				return a9.b.a;
			}
			fIUsbController = iq[0][0].abk();
		}
		else
		{
			fIUsbController = im.abk();
		}
		if (fIUsbController.USBSelfPowered == 0)
		{
			if (fIUsbController.HasUSBChargingPort != 0)
			{
				return a9.b.d;
			}
			return a9.b.c;
		}
		return a9.b.b;
	}

	[SpecialName]
	public bool vv()
	{
		FIUsbController fIUsbController = null;
		if (im == null)
		{
			if (ij == null)
			{
				if (iq != null && iq.Length > 0 && iq[0] != null && iq[0].Count > 0 && iq[0][0] != null)
				{
					fIUsbController = iq[0][0].abk();
				}
				else if (i0 != null)
				{
					fIUsbController = i0.abk();
				}
			}
		}
		else
		{
			fIUsbController = im.abk();
		}
		if (fIUsbController == null)
		{
			if (ij == null)
			{
				return false;
			}
			return ((IUVSource)ij).get_HasLampOnTimer(0) != 0;
		}
		bool result = fIUsbController.HasLightSourceOnTimer != 0;
		if (fIUsbController.HasHighPowerLightSource != 0)
		{
			return result;
		}
		if (fIUsbController.HasLowPowerLightSource == 0)
		{
			return false;
		}
		if (iq == null)
		{
			return result;
		}
		ip ip2 = null;
		Collection<ip>[] array = iq;
		foreach (Collection<ip> collection in array)
		{
			if (collection == null)
			{
				continue;
			}
			foreach (ip item in collection)
			{
				if (Operators.CompareString(item.abk().SerialNumber, fIUsbController.SerialNumber, TextCompare: false) == 0)
				{
					ip2 = item;
					break;
				}
			}
		}
		if (ip2 != null && ip2.xs() == FMUSBDeviceType.FIUSB2DeviceSpecTCNIR && ip2.xt() <= 1)
		{
			return false;
		}
		return result;
	}

	[SpecialName]
	public string vw()
	{
		if (iq == null || iq[0] == null || iq[0].Count == 0)
		{
			return "Si";
		}
		return iq[0][0].bc();
	}

	[SpecialName]
	public int vx()
	{
		return mc;
	}

	[SpecialName]
	public int vy()
	{
		return md;
	}

	public hr.b[] vz()
	{
		int upperBound = iq.GetUpperBound(0);
		bool flag = ut() && st(hb.b8());
		bool flag2 = uu() && s3(hb.b8()) && flag;
		checked
		{
			hr.b[] array = new hr.b[us() - 1 + 1];
			int num = 0;
			int num2 = upperBound;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (!sm(hb.b8(), num3))
				{
					continue;
				}
				if (hb.d0().c(ix[num3]))
				{
					if (flag2)
					{
						array[num] = hr.b.n;
					}
					else
					{
						array[num] = hr.b.o;
					}
				}
				else
				{
					bool flag3 = hb.d0().a(ix[num3]);
					if (flag2)
					{
						if (flag3)
						{
							array[num] = hr.b.j;
						}
						else
						{
							array[num] = hr.b.c;
						}
					}
					else if (flag3)
					{
						array[num] = hr.b.k;
					}
					else if (v6())
					{
						if (flag)
						{
							array[num] = hr.b.r;
						}
						else
						{
							array[num] = hr.b.q;
						}
					}
					else
					{
						array[num] = hr.b.b;
					}
				}
				num++;
			}
			return array;
		}
	}

	public hr.b[] v0()
	{
		return sm(hb);
	}

	private hr.b[] sm(hg A_0)
	{
		if (iq == null)
		{
			switch (A_0.d0().c())
			{
			case g2.a.b:
			case g2.a.c:
				return new hr.b[2]
				{
					hr.b.c,
					hr.b.j
				};
			case g2.a.m:
				return new hr.b[1] { hr.b.n };
			default:
				if (hj != null)
				{
					gt gt2 = hj;
					if (gt2.az() || gt2.a3())
					{
						return new hr.b[1] { hr.b.r };
					}
					return new hr.b[1] { hr.b.c };
				}
				return new hr.b[1] { hr.b.c };
			}
		}
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			hr.b[] array = new hr.b[upperBound + 1];
			int num = 0;
			int num2 = upperBound;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (sm(A_0.b8(), num3))
				{
					g2 g10 = A_0.d0();
					if (g2.d(g10.c(), ix[num3]))
					{
						array[num] = hr.b.j;
					}
					else if (g10.c() == g2.a.m)
					{
						array[num] = hr.b.n;
					}
					else if (v6())
					{
						array[num] = hr.b.r;
					}
					else
					{
						array[num] = hr.b.c;
					}
					g10 = null;
					num++;
				}
			}
			return array;
		}
	}

	public bool v1()
	{
		hr.b[] array = v0();
		bool flag = default(bool);
		bool result = default(bool);
		foreach (hr.b a_ in array)
		{
			if (hr.r(a_))
			{
				flag = true;
			}
			if (hr.t(a_))
			{
				result = true;
			}
		}
		if (flag)
		{
			return result;
		}
		return false;
	}

	public bool m2(hr.b[] A_0)
	{
		hr.b[] array = vz();
		int upperBound = array.GetUpperBound(0);
		if (upperBound != A_0.GetUpperBound(0))
		{
			return false;
		}
		int num = upperBound;
		for (int num2 = 0; num2 <= num; num2 = checked(num2 + 1))
		{
			if (array[num2] != A_0[num2])
			{
				return false;
			}
		}
		return true;
	}

	public float[] v2()
	{
		if (@is == null)
		{
			return null;
		}
		int num = 0;
		checked
		{
			int num2 = @is.Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				num += @is[num3].tg();
			}
			float[] array = new float[num - 1 + 1];
			int num4 = 0;
			int num5 = @is.Count - 1;
			for (int num6 = 0; num6 <= num5; num6++)
			{
				@in obj = @is[num6];
				List<float> list = obj.te();
				int num7 = obj.tg() - 1;
				for (int num8 = 0; num8 <= num7; num8++)
				{
					array[num4 + num8] = list[num8];
				}
				list = null;
				num4 += obj.tg();
			}
			return array;
		}
	}

	public float[] v3()
	{
		if (@is == null)
		{
			return null;
		}
		int num = 0;
		checked
		{
			int num2 = @is.Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				num += @is[num3].tg();
			}
			float[] array = new float[num - 1 + 1];
			int num4 = 0;
			int num5 = @is.Count - 1;
			for (int num6 = 0; num6 <= num5; num6++)
			{
				@in obj = @is[num6];
				List<float> list = obj.tf();
				int num7 = obj.tg() - 1;
				for (int num8 = 0; num8 <= num7; num8++)
				{
					array[num4 + num8] = list[num8];
				}
				list = null;
				num4 += obj.tg();
			}
			return array;
		}
	}

	[SpecialName]
	public bool v4()
	{
		return !ur();
	}

	[SpecialName]
	private bool ur()
	{
		if (@is != null)
		{
			return @is.Count == 0;
		}
		return true;
	}

	[SpecialName]
	public bool v5()
	{
		return !uq();
	}

	[SpecialName]
	private bool uq()
	{
		if (iq == null || iq.Length == 0)
		{
			return true;
		}
		Collection<ip>[] array = iq;
		foreach (Collection<ip> collection in array)
		{
			if (collection != null && collection.Count > 0)
			{
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	public bool v6()
	{
		if (iq != null && iq[0] != null && iq[0].Count > 0 && iq[0][0] != null)
		{
			return iq[0][0].zy();
		}
		return false;
	}

	public hg v8()
	{
		if (la == null)
		{
			return null;
		}
		return la.f();
	}

	[SpecialName]
	public bool v9()
	{
		if (la != null)
		{
			return la.g();
		}
		return false;
	}

	[SpecialName]
	public a4.a wa()
	{
		return la.i();
	}

	[SpecialName]
	public bool wb()
	{
		return la.j();
	}

	public int m2(ref long A_0)
	{
		if (la == null)
		{
			return 0;
		}
		bool flag = default(bool);
		try
		{
			flag = Monitor.TryEnter(la, 300);
			if (flag)
			{
				A_0 = la.h;
				return la.k();
			}
			ab8().c(fz.b.a, "Unable to obtain lock in MeasModuleSpec.MeasDataAccumNumPoints");
			A_0 = 0L;
			return 0;
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(la);
			}
		}
	}

	public Collection<int> wc()
	{
		return la.l();
	}

	public Collection<float[]> tc(int A_0)
	{
		if (la == null)
		{
			return null;
		}
		return la.f(A_0);
	}

	public cd.b[] wd()
	{
		if (la == null)
		{
			return null;
		}
		return la.m();
	}

	public g.a[] we()
	{
		if (la == null)
		{
			return null;
		}
		return la.n();
	}

	public double[] m2(int A_0, int A_1, int A_2)
	{
		if (la == null)
		{
			return null;
		}
		return la.f(A_0, A_1, A_2);
	}

	public Collection<float[]> td(int A_0)
	{
		if (la == null)
		{
			return null;
		}
		return la.g(A_0);
	}

	public bool te(int A_0)
	{
		if (la != null)
		{
			return la.k() <= A_0;
		}
		return true;
	}

	public void m2(int A_0, g.a A_1)
	{
		if (la == null)
		{
			la = new cd(ab8(), hc, -1L, m2(he.c() != g2.a.m, (eo.a)null), hk.h(), hk.i(), v1(), so(hc));
		}
		for (int num = la.k(); num <= A_0; num = checked(num + 1))
		{
			hc hc2 = new hc();
			hc2.cf(0.0, 0f, null, 0, 0, null, null, null, null, 0f, A_10: false, null, hc, zj(), null, null, null, null, null, 0, null, null, null, null, null, null, null, null, null, null, null, null, null, A_33: true, A_34: false, 0, string.Empty, null);
			la.f(hc2, A_1);
		}
	}

	public bool sj(int A_0, int A_1)
	{
		if (la == null)
		{
			return false;
		}
		return la.f(A_0, A_1) || la.g(A_0, A_1);
	}

	public g.a tf(int A_0)
	{
		if (la == null)
		{
			return null;
		}
		return la.i(A_0);
	}

	public void m2(int A_0, ref g.a A_1, ref int A_2)
	{
		la.f(A_0, ref A_1, ref A_2);
	}

	public void wf()
	{
		la = null;
	}

	public bool qh(ip A_0)
	{
		if (iq == null)
		{
			return true;
		}
		int num = A_0.ut();
		if (num > iq.GetUpperBound(0))
		{
			return true;
		}
		if (iq[num] == null)
		{
			return true;
		}
		foreach (ip item in iq[num])
		{
			if (!global::ip.m2(item.vu(), item.vv(), A_0.vu(), A_0.vv(), Operators.CompareString(A_0.abn(), item.abn(), TextCompare: false) == 0))
			{
				return false;
			}
			ip current = null;
		}
		return true;
	}

	public float wg()
	{
		bool flag = false;
		float num = float.MaxValue;
		checked
		{
			if (iq != null)
			{
				int num2 = iq.Length - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (iq[num3] == null)
					{
						continue;
					}
					int num4 = iq[num3].Count - 1;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						if (iq[num3][num5] != null && m2(hb.b8(), num5, num3))
						{
							flag = true;
							ip ip2 = iq[num3][num5];
							if (ip2.vu() < num)
							{
								num = ip2.vu();
							}
							ip2 = null;
						}
					}
				}
			}
			if (flag)
			{
				return num;
			}
			return 185f;
		}
	}

	public float tg(int A_0)
	{
		if (iq == null || iq.Length == 0)
		{
			return 0f;
		}
		float num = float.MaxValue;
		foreach (ip item in iq[A_0])
		{
			if (item.vu() < num)
			{
				num = item.vu();
			}
			ip current = null;
		}
		return num;
	}

	public float sm(int A_0, int A_1)
	{
		if (iq == null || iq.Length == 0 || iq.GetUpperBound(0) < A_0 || iq[A_0] == null || checked(iq[A_0].Count - 1) < A_1)
		{
			return 0f;
		}
		return iq[A_0][A_1].vu();
	}

	public float wh()
	{
		bool flag = false;
		float num = float.MinValue;
		checked
		{
			if (iq != null)
			{
				int num2 = iq.Length - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (iq[num3] == null)
					{
						continue;
					}
					int num4 = iq[num3].Count - 1;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						if (iq[num3][num5] != null && m2(hb.b8(), num5, num3))
						{
							flag = true;
							ip ip2 = iq[num3][num5];
							if (ip2.vv() > num)
							{
								num = ip2.vv();
							}
							ip2 = null;
						}
					}
				}
			}
			if (flag)
			{
				return num;
			}
			return 2200f;
		}
	}

	public float th(int A_0)
	{
		if (iq == null || iq.Length == 0)
		{
			return 10000f;
		}
		float num = float.MinValue;
		foreach (ip item in iq[A_0])
		{
			if (item.vv() > num)
			{
				num = item.vv();
			}
			ip current = null;
		}
		return num;
	}

	public float sn(int A_0, int A_1)
	{
		if (iq == null || iq.Length == 0 || iq.GetUpperBound(0) < A_0 || iq[A_0] == null || checked(iq[A_0].Count - 1) < A_1)
		{
			return 0f;
		}
		return iq[A_0][A_1].vv();
	}

	public bool sj(ip A_0)
	{
		if (iq == null)
		{
			return false;
		}
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (iq[num] == null)
			{
				continue;
			}
			foreach (ip item in iq[num])
			{
				if (string.Compare(item.yq(), A_0.yq()) == 0)
				{
					return true;
				}
			}
		}
		return false;
	}

	public void m2(string A_0, string A_1 = "")
	{
		try
		{
			h6 h10 = null;
			if (iq != null && iq[0] != null && iq[0].Count > 0)
			{
				h10 = iq[0][0];
			}
			else if (@is != null && @is[0] != null)
			{
				h10 = @is[0];
			}
			if (h10 != null)
			{
				short A_2 = default(short);
				short A_3 = default(short);
				short A_4 = default(short);
				short A_5 = default(short);
				h10.m2(ref A_2, ref A_3, ref A_4, ref A_5);
				global::i7.c(A_2, A_3, A_4, A_5, global::jg.a(f6.FMSolveVer(1)), uo(), wk(), A_0, A_1);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ab8().c(fz.b.b, "Error writing system information file for meas module: " + zl(), a_);
			ProjectData.ClearProjectError();
		}
	}

	public bool wi()
	{
		bool flag = zp() == g2.a.b;
		m2(hb, flag, A_2: true);
		checked
		{
			if (flag)
			{
				int upperBound = iq.GetUpperBound(0);
				for (int num = 0; num <= upperBound; num++)
				{
					int num2 = iq[num].Count - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						if (iq[num][num3].ye())
						{
							return true;
						}
					}
				}
			}
			return false;
		}
	}

	public bool wj()
	{
		bool flag = zp() == g2.a.b;
		global::h a_ = m2(hb, flag, A_2: true);
		checked
		{
			if (flag && iv[0])
			{
				int upperBound = iq.GetUpperBound(0);
				for (int num = 0; num <= upperBound; num++)
				{
					if (!sn(a_, num))
					{
						continue;
					}
					int num2 = iq[num].Count - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						if (p9(a_, num3, num) && iq[num][num3].vz() == g2.OpticsConfigSubmoduleTypes.ReflectanceProbe && (!iq[num][num3].ye() || iq[num][num3].xs() == FMUSBDeviceType.FIUSB2DeviceSpecNIR2))
						{
							return false;
						}
					}
				}
				return true;
			}
			return false;
		}
	}

	public bool so(hg A_0)
	{
		global::h a_ = A_0.b8();
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			bool flag = default(bool);
			for (int num = 0; num <= upperBound; num++)
			{
				if (!m2(a_, num, n.b, A_3: false, A_4: false))
				{
					continue;
				}
				switch (ix[num])
				{
				case global::h.f.a:
					flag = A_0.ed().eq(0);
					break;
				case global::h.f.b:
					flag = A_0.ed().ep(0);
					break;
				case global::h.f.c:
					flag = A_0.ed().eq(1);
					break;
				}
				if (!flag)
				{
					continue;
				}
				double num2 = double.MaxValue;
				double num3 = double.MinValue;
				int num4 = iq[num].Count - 1;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					if (p9(A_0.b8(), num5, num))
					{
						double num6 = iq[num][num5].vu();
						double num7 = iq[num][num5].vv();
						if (num6 < num2)
						{
							num2 = num6;
						}
						if (num7 > num3)
						{
							num3 = num7;
						}
					}
				}
				if (b7.c(num2, num3))
				{
					return true;
				}
			}
			return false;
		}
	}

	public void m2(global::r.d A_0, global::r.d.a.b A_1)
	{
		s s2 = new s(A_1);
		((m)s2).a = m.a.a9;
		s2.d = m.TaskExecutionType.Setup;
		s2.g = A_0;
		_ = null;
		string A_2 = "";
		string A_3 = "";
		m2(ref A_2, ref A_3, s2);
	}

	private void up()
	{
		if (hb.d0().c() != g2.a.b || iq == null)
		{
			return;
		}
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			for (int num = 0; num <= upperBound; num++)
			{
				int num2 = iq[num].Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					iq[num][num3].yf();
				}
			}
		}
	}

	[SpecialName]
	private Collection<string> uo()
	{
		Collection<string> collection = null;
		if (iq != null && iq[0] != null)
		{
			collection = new Collection<string>();
			foreach (ip item in iq[0])
			{
				collection.Add(item.abk().SerialNumber);
			}
		}
		if (@is != null && @is[0] != null)
		{
			if (collection == null)
			{
				collection = new Collection<string>();
			}
			foreach (@in item2 in @is)
			{
				collection.Add(item2.abk().SerialNumber);
			}
		}
		return collection;
	}

	[SpecialName]
	public Collection<string> wk()
	{
		Collection<string> collection = null;
		if (iq != null && iq[0] != null)
		{
			collection = new Collection<string>();
			foreach (ip item in iq[0])
			{
				collection.Add(item.abk().FriendlySN);
			}
		}
		if (@is != null && @is[0] != null)
		{
			if (collection == null)
			{
				collection = new Collection<string>();
			}
			foreach (@in item2 in @is)
			{
				collection.Add(item2.abk().FriendlySN);
			}
		}
		return collection;
	}

	private void un()
	{
		p9(hb, A_1: false);
		hg A_ = new hg(hb.dh(), hb.cd());
		hb.bu(ref A_);
		qh(A_);
	}

	public void m2(Collection<h5> A_0, string A_1, b0 A_2)
	{
		string A_3 = null;
		c1 obj = new c1();
		obj.d("Initializing Scatter Calibration Box");
		ma = new e0(A_0, A_1, A_2, ref A_3);
		if (A_3 != null)
		{
			ab8().c(fz.b.b, A_3);
		}
		obj.i();
	}

	private void um()
	{
		if (he.c() == g2.a.i)
		{
			he.o(g2.a.h);
		}
		else if (he.c() == g2.a.k)
		{
			he.o(g2.a.j);
		}
		else
		{
			ab8().c(fz.b.a, "Software bug - unable to determine appropriate replacement optics configuration.");
		}
	}

	public ErrPublic m2(f0 A_0, cf A_1)
	{
		ErrPublic result = ErrPublic.None;
		h6 h10 = A_0 as h6;
		try
		{
			if (h10 != null && h10.abk() != null && !ir.Contains(h10.abk().SerialNumber))
			{
				FIUsbController fIUsbController = h10.abk();
				int num = fIUsbController.SetStatusLEDsEnableState(0 - (hc.dh().a8() ? 1 : 0));
				if (num != 0)
				{
					ab8().c(fz.b.b, "Exception caught in MeasModuleSpec.AddDevice() when SetStatusLEDsEnableState. Error code is " + num + ".");
				}
				if (fIUsbController.HasLowPowerLightSource != 0)
				{
					num = ((!h10.abz()) ? fIUsbController.SetLightSourcePowerOnState(-1) : fIUsbController.SetLightSourcePowerOnState(0));
					if (num != 0)
					{
						ab8().c(fz.b.a, "Failure in MeasModuleSpec.AddDevice(). Error attempting to turn low power light source on. Error code=" + num);
					}
					ir.Add(fIUsbController.SerialNumber);
				}
				fIUsbController = null;
			}
			checked
			{
				if (A_0 is ip)
				{
					ip ip2 = (ip)A_0;
					mc = ip2.w4();
					md = ip2.w5();
					if (qh(ip2))
					{
						bool flag = false;
						bool flag2 = ip2.wr().l;
						if (!flag2 && iq != null)
						{
							int num2 = iq.Length - 1;
							for (int num3 = 0; num3 <= num2; num3++)
							{
								if (iq[num3] == null)
								{
									continue;
								}
								int num4 = iq[num3].Count - 1;
								for (int num5 = 0; num5 <= num4; num5++)
								{
									if (iq[num3][num5].wr().l)
									{
										flag2 = true;
									}
								}
							}
						}
						int num6;
						unchecked
						{
							if (ip2.abk() != null)
							{
								bool flag3 = ip2.vf() && !flag2;
								bool flag4 = ip2.abb() > 0;
								bool flag5 = ip2.abi() && ip2.abb() == 0 && ip2.abj();
								k7 = ip2.v0() && !xs() && !hb.dh().bq();
								if (!he.q() && (xs() || hb.dh().bq() || ip2.ze()))
								{
									ab8().c(fz.b.a, "Invalid optics configuration detected in MeasModuleSpec.AddDevice. Initial settings had AutoBaseline active. Settings have been changed to CTMProbe.");
									he.o(g2.a.m);
									he.a(A_1);
									flag = true;
								}
								else
								{
									if (he.p())
									{
										if (!k7 || k8)
										{
											ab8().c(fz.b.a, "Invalid optics configuration detected in MeasModuleSpec.AddDevice. mIsOpticsConfigMicroscopeObjectivePermitted=" + k7.ToString(CultureInfo.InvariantCulture) + ", initial optics config=" + Conversions.ToString((int)he.c()));
											he.o(g2.a.d);
											flag = true;
										}
									}
									else if (!ip2.v1() && !hb.dh().bq() && !k8)
									{
										ab8().c(fz.b.a, "Invalid optics configuration detected in MeasModuleSpec.AddDevice. mIsOpticsConfigMicroscopeObjectivePermitted=" + k7.ToString(CultureInfo.InvariantCulture) + ", initial optics config=" + Conversions.ToString((int)he.c()));
										he.o(g2.a.f);
										flag = true;
									}
									if (flag4 || flag5)
									{
										if (flag3 && he.c() != g2.a.b)
										{
											ab8().c(fz.b.a, "Invalid optics configuration detected in MeasModuleSpec.AddDevice. isRandTAutoRefRequired=" + flag3.ToString(CultureInfo.InvariantCulture) + ", initial optics config=" + Conversions.ToString((int)he.c()));
											he.o(g2.a.b);
											flag = true;
										}
										else if (!flag3 && he.c() != g2.a.c)
										{
											ab8().c(fz.b.a, "Invalid optics configuration detected in MeasModuleSpec.AddDevice. isRandTAutoRefRequired=" + flag3.ToString(CultureInfo.InvariantCulture) + ", initial optics config=" + Conversions.ToString((int)he.c()));
											he.o(g2.a.c);
											flag = true;
										}
									}
									else if (he.c() == g2.a.c || he.c() == g2.a.b)
									{
										ab8().c(fz.b.a, "Invalid optics configuration detected in MeasModuleSpec.AddDevice. isMultiMeasCapable=" + flag4.ToString(CultureInfo.InvariantCulture) + ", initial optics config=" + Conversions.ToString((int)he.c()));
										he.d(ip2.abk().FWDefOpticConfig);
										flag = true;
									}
								}
							}
							string text = ip2.abd();
							if (string.IsNullOrEmpty(he.k()) || Operators.CompareString(he.k(), text, TextCompare: false) != 0)
							{
								he.d(text);
								flag = true;
							}
							if (flag)
							{
								un();
							}
							ip2.m2((et)he.r());
							ip2.m2(he.s());
							uk();
							uj();
							num6 = 0;
							if (ip2.abb() > 0)
							{
								num6 = ip2.ut();
							}
						}
						if (iq == null)
						{
							iq = new Collection<ip>[ip2.abb() + 1];
							kb = new double[ip2.abb() + 1];
							ix = new global::h.f[ip2.abb() + 1];
							iw = new float[ip2.abb() + 1];
							iy = new bool[ip2.abb() + 1];
							iz = new bool[ip2.abb() + 1];
							iu = new int[global::h.a() + 1];
							iv = new bool[global::h.a() + 1];
							int num7 = global::h.a();
							for (int num8 = 0; num8 <= num7; num8++)
							{
								iu[num8] = -1;
							}
						}
						else if (num6 > iq.GetUpperBound(0))
						{
							ab8().c(fz.b.a, "Probable firmware error. Number of subsystems is " + (num6 + 1) + "; expected number of subsystems is " + (iq.GetUpperBound(0) + 1) + ".");
							ref Collection<ip>[] reference = ref iq;
							reference = (Collection<ip>[])Utils.CopyArray(reference, new Collection<ip>[ip2.abb() + 1]);
							ref double[] reference2 = ref kb;
							reference2 = (double[])Utils.CopyArray(reference2, new double[ip2.abb() + 1]);
							ref global::h.f[] reference3 = ref ix;
							reference3 = (global::h.f[])Utils.CopyArray(reference3, new global::h.f[ip2.abb() + 1]);
							ref float[] reference4 = ref iw;
							reference4 = (float[])Utils.CopyArray(reference4, new float[ip2.abb() + 1]);
							ref bool[] reference5 = ref iy;
							reference5 = (bool[])Utils.CopyArray(reference5, new bool[ip2.abb() + 1]);
							ref bool[] reference6 = ref iz;
							reference6 = (bool[])Utils.CopyArray(reference6, new bool[ip2.abb() + 1]);
						}
						Collection<ip> collection;
						unchecked
						{
							if (iq[num6] == null)
							{
								iq[num6] = new Collection<ip>();
								if (ip2.abi())
								{
									if (ip2.abj())
									{
										ix[num6] = global::h.f.b;
										iu[1] = num6;
									}
									else if (global::jf.e(ip2.abh(), 0.0))
									{
										ix[num6] = global::h.f.a;
										iu[0] = num6;
									}
									else
									{
										ix[num6] = global::h.f.c;
										iu[2] = num6;
									}
								}
								else
								{
									ix[num6] = (global::h.f)num6;
									iu[num6] = num6;
								}
								iv[(int)ix[num6]] = true;
								iw[num6] = ip2.abh();
								iy[num6] = ip2.abf();
								iz[num6] = ip2.abg();
							}
							ip2.sj(he.d(ix[num6]));
							collection = iq[num6];
							collection.Add(ip2);
						}
						if (collection.Count == 2)
						{
							if (jp == null)
							{
								jp = new int[ip2.abb() + 1];
								jq = new int[ip2.abb() + 1];
								jr = new float[ip2.abb() + 1];
								js = new int[ip2.abb() + 1];
								jt = new int[ip2.abb() + 1];
								ju = new int[ip2.abb() + 1];
								j1 = new int[ip2.abb() + 1];
								j2 = new double[ip2.abb() + 1][];
								j3 = new Guid[ip2.abb() + 1];
								j4 = new Guid[ip2.abb() + 1];
								jv = new int[ip2.abb() + 1][];
								jw = new int[ip2.abb() + 1][];
								jx = new int[ip2.abb() + 1][];
								jy = new int[ip2.abb() + 1][];
								jz = new float[ip2.abb() + 1][];
								j0 = new int[ip2.abb() + 1];
							}
						}
						else if (collection.Count >= 3)
						{
							throw new ArgumentOutOfRangeException("Maximum of 2 spectrometers per subsystem has been exceeded");
						}
						collection = null;
						if (flag2)
						{
							int num9 = iq.Length - 1;
							for (int num10 = 0; num10 <= num9; num10++)
							{
								if (iq[num10] != null)
								{
									int num11 = iq[num10].Count - 1;
									for (int num12 = 0; num12 <= num11; num12++)
									{
										iq[num10][num12].tj(A_0: true);
									}
								}
							}
						}
						if (num6 == 0 && ip2.abk().HasLowPowerLightSource != 0 && !ip2.abz() && (im == null || im.aby()))
						{
							im = new h5(ip2.abk(), ab8());
						}
						int num13 = ip2.tb(hc.dh().a8() || ip2.abk().FWCorrupt != 0 || ip2.x4());
						if (num13 != 0)
						{
							ab8().c(fz.b.b, "Exception caught in MeasModuleSpec.AddDevice() when SetAcqLedEnableState. Error code is " + num13 + ".");
						}
						if (he.n() && (!ip2.uu() || m2(hc)))
						{
							string text2 = g2.n(he.c());
							um();
							string text3 = g2.n(he.c());
							ab8().c(fz.b.a, "Invalid AutoBaseline optics configuration detected in MeasModuleSpec.AddDevice at second stage. OpticsConfig has been changed from " + text2 + " to " + text3 + ".");
							un();
						}
						qh(A_0: false, A_1: false);
						t9();
						if (hc.d0().n())
						{
							iq a_ = null;
							if (ip2.m2(a_) && ip2.p9(a_))
							{
								ip2.p9(jk, A_1: true);
							}
						}
					}
				}
				else if (A_0 is @in)
				{
					if (@is == null)
					{
						@is = new Collection<@in>();
					}
					@in obj = (@in)A_0;
					if (@is.Count == 0)
					{
						obj.s3(0);
					}
					else
					{
						@in obj2 = @is[@is.Count - 1];
						obj.s3(obj2.tc() + obj2.tg());
						obj2 = null;
					}
					@is.Add(obj);
					qh();
				}
				else if (A_0 is h5)
				{
					switch (A_0.b())
					{
					case FMLegacyAllSystemTypes.kTypeUVSource:
					case FMLegacyAllSystemTypes.kTypeHnl:
					{
						ip = (h5)A_0;
						ij = (UVSource)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("54FF06F4-C70A-410A-97A4-843237DB684B")));
						int num14 = ij.Connect(0, ip.abn());
						if (num14 != 0)
						{
							ab8().c(fz.b.a, "Error #" + num14 + " attempting to connect to UVLight Source");
						}
						if (false)
						{
							il = new ad();
							num14 = ij.SetFrontPanelDisable(1);
							if (num14 != 0)
							{
								ab8().c(fz.b.a, "Error #" + num14 + " attempting to disable light source front panel controls.");
							}
							num14 = ij.SetD2LampState(1);
							if (num14 != 0)
							{
								ab8().c(fz.b.a, "Error #" + num14 + " attempting to turn on D2 lamp.");
							}
							num14 = ij.SetTHLampState(1);
							if (num14 != 0)
							{
								ab8().c(fz.b.a, "Error #" + num14 + " attempting to turn on TH lamp.");
							}
							num14 = ij.SetShutterState(0);
							if (num14 != 0)
							{
								ab8().c(fz.b.a, "Error #" + num14 + " attempting to open shutter.");
							}
						}
						break;
					}
					case FMLegacyAllSystemTypes.kTypeOpticalAcc:
					{
						FMOpticalAccSubTypes fMOpticalAccSubTypes = unchecked((FMOpticalAccSubTypes)A_0.c());
						if (fMOpticalAccSubTypes == FMOpticalAccSubTypes.kFMOpticalAccSubtypeFiberSwitchDual)
						{
							ik = new bw((h5)A_0);
						}
						else
						{
							i0 = (h5)A_0;
						}
						break;
					}
					default:
						i0 = (h5)A_0;
						if (i0.abk().HasLowPowerLightSource != 0)
						{
							im = new h5(i0.abk(), ab8());
						}
						break;
					}
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			result = ErrPublic.Generic;
			ab8().c(fz.b.b, "Exception caught in MeasModuleSpec.AddDevice(). ", a_2);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void wl()
	{
		t8();
		ms = true;
		if (!p9(hc))
		{
			un();
		}
	}

	private void m2(short[] A_0, short[] A_1, int A_2, ref double[] A_3, ref double[] A_4, int A_5)
	{
		checked
		{
			int num = A_2 - 1;
			double[] A_6 = new double[num + 1];
			double[] A_7 = new double[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				A_6[num3] = A_0[num3];
				A_7[num3] = A_1[num3];
			}
			global::jf.a(ref A_6, ref A_7, A_2, ref A_3, ref A_4, A_5);
		}
	}

	private double[] m2(hr A_0)
	{
		float[] A_1 = null;
		double[] A_2 = null;
		double[] A_3 = null;
		double[] A_4 = null;
		double[] A_5 = null;
		double[] array = null;
		int num = A_0.c2();
		checked
		{
			int num2 = num - 1;
			if (A_0.br() != null)
			{
				Collection<hp> collection = A_0.br();
				if (collection.Count > 1)
				{
					array = new double[num2 + 1];
					short a_ = collection[0].q().h()[0];
					short a_2 = collection[0].q().h()[collection[0].q().h().Length - 1];
					short a_3 = collection[1].q().h()[0];
					short a_4 = collection[1].q().h()[collection[1].q().h().Length - 1];
					m2(A_0: true, a_, a_2, a_3, a_4, A_0.cz(), ref A_1);
					short[] a_5 = collection[0].q().h();
					short[] a_6 = collection[0].q().f();
					int a_7 = collection[0].q().h().Length;
					hr hr2;
					double[] A_6 = (hr2 = A_0).cz();
					m2(a_5, a_6, a_7, ref A_6, ref A_2, num);
					hr2.t(A_6);
					short[] a_8 = collection[1].q().h();
					short[] a_9 = collection[1].q().f();
					int a_10 = collection[1].q().h().Length;
					A_6 = (hr2 = A_0).cz();
					m2(a_8, a_9, a_10, ref A_6, ref A_3, num);
					hr2.t(A_6);
					if (collection[0].q().g() == null)
					{
						int num3 = num2;
						for (int num4 = 0; num4 <= num3; num4++)
						{
							array[num4] = A_2[num4] * (double)A_1[num4] + A_3[num4] * (double)(1f - A_1[num4]);
						}
					}
					else
					{
						short[] a_11 = collection[0].q().h();
						short[] a_12 = collection[0].q().g();
						int a_13 = collection[0].q().h().Length;
						A_6 = (hr2 = A_0).cz();
						m2(a_11, a_12, a_13, ref A_6, ref A_4, num);
						hr2.t(A_6);
						short[] a_14 = collection[1].q().h();
						short[] a_15 = collection[1].q().g();
						int a_16 = collection[1].q().h().Length;
						A_6 = (hr2 = A_0).cz();
						m2(a_14, a_15, a_16, ref A_6, ref A_5, num);
						hr2.t(A_6);
						int num5 = num2;
						for (int num6 = 0; num6 <= num5; num6++)
						{
							array[num6] = (A_2[num6] - A_4[num6]) * (double)A_1[num6] + (A_3[num6] - A_5[num6]) * (double)(1f - A_1[num6]);
						}
					}
					return array;
				}
				if (collection.Count > 0)
				{
					array = new double[num2 + 1];
					short[] a_17 = collection[0].q().h();
					short[] a_18 = collection[0].q().f();
					int a_19 = collection[0].q().h().Length;
					hr hr2;
					double[] A_6 = (hr2 = A_0).cz();
					m2(a_17, a_18, a_19, ref A_6, ref A_2, A_0.c2());
					hr2.t(A_6);
					if (collection[0].q().g() == null)
					{
						int num7 = num2;
						for (int num8 = 0; num8 <= num7; num8++)
						{
							array[num8] = A_2[num8];
						}
					}
					else
					{
						short[] a_20 = collection[0].q().h();
						short[] a_21 = collection[0].q().g();
						int a_22 = collection[0].q().h().Length;
						A_6 = (hr2 = A_0).cz();
						m2(a_20, a_21, a_22, ref A_6, ref A_4, A_0.c2());
						hr2.t(A_6);
						int num9 = num2;
						for (int num10 = 0; num10 <= num9; num10++)
						{
							array[num10] = A_2[num10] - A_4[num10];
						}
					}
					return array;
				}
				return null;
			}
			return null;
		}
	}

	private void m2(bool A_0, short A_1, short A_2, short A_3, short A_4, double[] A_5, ref float[] A_6)
	{
		checked
		{
			int num = A_5.Length - 1;
			A_6 = new float[num + 1];
			if (A_3 > A_2 || !A_0)
			{
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (A_5[num3] <= (double)A_2 || !A_0)
					{
						A_6[num3] = 1f;
					}
					else
					{
						A_6[num3] = 0f;
					}
				}
				return;
			}
			double num4;
			double num5;
			if (A_4 <= A_2)
			{
				num4 = (double)(short)unchecked(A_4 + A_3) / 2.0;
				num5 = (double)(short)unchecked(A_4 - A_3) / 2.0;
				int num6 = num;
				for (int num3 = 0; num3 <= num6; num3++)
				{
					if (A_5[num3] < (double)A_3 || A_5[num3] > (double)A_4)
					{
						A_6[num3] = 1f;
					}
					else
					{
						A_6[num3] = 0.5f + 0.5f * (float)Math.Abs((num4 - A_5[num3]) / num5);
					}
				}
				return;
			}
			num4 = 0.0;
			num5 = (short)unchecked(A_2 - A_3);
			int num7 = num;
			for (int num3 = 0; num3 <= num7; num3++)
			{
				if (A_5[num3] < (double)A_3)
				{
					A_6[num3] = 1f;
				}
				else if (A_5[num3] > (double)A_2)
				{
					A_6[num3] = 0f;
				}
				else
				{
					A_6[num3] = (float)(((double)A_2 - A_5[num3]) / num5);
				}
			}
		}
	}

	private void m2(ref float A_0, ref int A_1, int A_2, int A_3, int A_4, double[] A_5, ref int A_6, int A_7, double[] A_8, int A_9, int[] A_10, int[] A_11)
	{
		checked
		{
			double num = ((A_2 > 1) ? 0.0 : ((A_3 >= A_4) ? A_5[A_3] : ((A_5[A_3] + A_5[A_3 + 1]) / 2.0)));
			int num2 = -1;
			A_0 = 0f;
			A_1 = 0;
			while (A_6 < A_7 && (num2 < 0 || A_8[A_6] <= num))
			{
				if (num2 < 0)
				{
					num2 = A_6;
				}
				A_0 += (float)A_8[A_6];
				A_1++;
				A_6++;
			}
			if (num2 >= 0)
			{
				A_10[A_9] = num2;
				A_11[A_9] = A_6 - 1;
			}
			else
			{
				A_10[A_9] = 0;
				A_11[A_9] = -1;
			}
		}
	}

	private void ul()
	{
		double[] A_ = new double[0];
		double[] A_2 = new double[0];
		if (iq == null)
		{
			return;
		}
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			int A_3 = default(int);
			Guid A_4 = default(Guid);
			int A_5 = default(int);
			Guid A_6 = default(Guid);
			float A_7 = default(float);
			int A_8 = default(int);
			float A_9 = default(float);
			int A_10 = default(int);
			for (int num = 0; num <= upperBound; num++)
			{
				if (iq[num] == null)
				{
					continue;
				}
				Collection<ip> collection = iq[num];
				if (collection.Count == 2)
				{
					if (j2[num] != null && collection[jp[num]].xp() == j3[num] && collection[jq[num]].xp() == j4[num])
					{
						continue;
					}
					ip ip2 = collection[0];
					ip ip3 = collection[1];
					bool flag;
					if (ip3.vu() != ip2.vu())
					{
						if (ip3.vu() < ip2.vu())
						{
							jp[num] = 1;
							jq[num] = 0;
						}
						else
						{
							jp[num] = 0;
							jq[num] = 1;
						}
						flag = true;
					}
					else
					{
						jp[num] = 0;
						jq[num] = 1;
						flag = false;
					}
					collection[jp[num]].m2(A_0: false, ref A_, ref A_3, ref A_4);
					int num2 = A_3 - 1;
					collection[jq[num]].m2(A_0: false, ref A_2, ref A_5, ref A_6);
					int num3 = A_5 - 1;
					double[] array = new double[A_3 + A_5 + 1];
					int num6;
					int num4;
					if (flag)
					{
						num4 = -1;
						double num5 = collection[jq[num]].vu();
						do
						{
							num4++;
							array[num4] = A_[num4];
						}
						while (A_[num4] < num5 && num4 < num2);
						if (A_[num4] > num5)
						{
							num4--;
						}
						ju[num] = num4;
						num6 = num4 + 1;
					}
					else
					{
						num4 = 0;
						num6 = 0;
						ju[num] = 0;
					}
					if (num4 < num2 && A_2[0] - A_[num4] > A_[num4 + 1] - A_2[0])
					{
						num4++;
					}
					int num7 = num4;
					for (; num4 < num2 && A_[num4] < A_2[num3]; num4++)
					{
					}
					int num8 = num4 - num7 + 1;
					int num9;
					for (num9 = 0; num9 < num3 && A_2[num9] < A_[num4]; num9++)
					{
					}
					int num10 = num9 + 1;
					int num11 = ((num8 >= num10) ? num10 : num8);
					int[] array2 = new int[num11 + 1];
					int[] array3 = new int[num11 + 1];
					int[] array4 = new int[num11 + 1];
					int[] array5 = new int[num11 + 1];
					float[] array6 = new float[num11 + 1];
					float num12 = ((num6 <= 0) ? ((float)A_[num6]) : ((float)array[num6 - 1]));
					double num13;
					float num14;
					float num15;
					if (num4 < num2)
					{
						num13 = A_[num4];
						num14 = (float)(0.5 * (num13 + (double)num12));
						num15 = (float)(0.5 * (num13 - (double)num12));
					}
					else
					{
						num14 = 0f;
						num13 = ((num9 >= num3) ? A_[num2] : A_2[num9]);
						num15 = (float)(num13 - (double)num12);
					}
					num9 = 0;
					int num16 = 0;
					num4 = num7;
					while (num4 < A_3 && num9 < A_5)
					{
						m2(ref A_7, ref A_8, 0, num9, num3, A_2, ref num4, A_3, A_, num16, array2, array3);
						m2(ref A_9, ref A_10, A_8, num4 - 1, num2, A_, ref num9, A_5, A_2, num16, array4, array5);
						float num17 = A_9 / (float)A_10;
						float num18 = A_7 / (float)A_8;
						if (num14 == 0f)
						{
							array6[num16] = (float)((num13 - (double)num17) / (double)(num18 - num17 + num15));
						}
						else
						{
							if (num17 > num14)
							{
								array6[num16] = Math.Abs((num14 - num17) / (num18 - num17 - num15));
							}
							else
							{
								array6[num16] = Math.Abs((num14 - num17) / (num18 - num17 + num15));
							}
							array6[num16] = 0.5f + 0.5f * array6[num16];
						}
						array[num6] = array6[num16] * num18 + (1f - array6[num16]) * num17;
						num6++;
						num16++;
					}
					jr[num] = num14;
					j0[num] = num16;
					jt[num] = num9;
					js[num] = num4;
					jv[num] = array2;
					jw[num] = array3;
					jx[num] = array4;
					jy[num] = array5;
					jz[num] = array6;
					if (num4 < num2)
					{
						int num19 = num4;
						int num20 = num2;
						for (num4 = num19; num4 <= num20; num4++)
						{
							array[num6] = A_[num4];
							num6++;
						}
					}
					else if (num9 < num3)
					{
						int num21 = num9;
						int num22 = num3;
						for (num9 = num21; num9 <= num22; num9++)
						{
							array[num6] = A_2[num9];
							num6++;
						}
					}
					array = (double[])Utils.CopyArray(array, new double[num6 - 1 + 1]);
					j2[num] = array;
					j1[num] = num6;
					j3[num] = A_4;
					j4[num] = A_6;
				}
				collection = null;
			}
		}
	}

	private void m2(g2.a A_0)
	{
		if (iq == null)
		{
			return;
		}
		int upperBound = iq.GetUpperBound(0);
		he.o(A_0);
		int num = upperBound;
		for (int num2 = 0; num2 <= num; num2 = checked(num2 + 1))
		{
			if (iq[num2] == null)
			{
				continue;
			}
			foreach (ip item in iq[num2])
			{
				item.sj(he.d(ix[num2]));
			}
		}
	}

	private void uk()
	{
		if (iq == null)
		{
			return;
		}
		int upperBound = iq.GetUpperBound(0);
		et a_ = (et)hc.d0().r();
		int num = upperBound;
		for (int num2 = 0; num2 <= num; num2 = checked(num2 + 1))
		{
			if (iq[num2] == null)
			{
				continue;
			}
			foreach (ip item in iq[num2])
			{
				item.m2(a_);
			}
		}
	}

	private void uj()
	{
		if (iq == null)
		{
			return;
		}
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (iq[num] == null)
			{
				continue;
			}
			foreach (ip item in iq[num])
			{
				item.m2(hc.d0().s());
			}
		}
	}

	public void p9(hg A_0, bool A_1)
	{
		bool A_2 = false;
		bool A_3 = false;
		hg hg2 = A_0;
		if (hg2.d0() == null || !p9(A_0))
		{
			g2 obj = he;
			hg hg3;
			g2 A_4 = (hg3 = hg2).d0();
			obj.a(ref A_4);
			hg3.bu(A_4);
			if (iq != null && !p9(A_0))
			{
				if (u4())
				{
					if (st(A_0) || A_0.dh().bq())
					{
						he.o(g2.a.m);
					}
					else if (uv())
					{
						he.o(g2.a.b);
					}
					else if (iq[0] != null && iq[0].Count > 0)
					{
						g2.a a_ = g2.a(iq[0][0].abk().FWDefOpticConfig);
						if (g2.j(a_) && m2(A_0))
						{
							um();
						}
						else
						{
							he.o(a_);
						}
					}
					else
					{
						he.o(g2.a.d);
					}
				}
				else
				{
					he.o(g2.a.f);
				}
				g2 obj2 = he;
				A_4 = (hg3 = hg2).d0();
				obj2.a(ref A_4);
				hg3.bu(A_4);
			}
			hg2.bv(global::e.a().OperatorID, DateTime.Now);
		}
		else if (iq != null && iq[0] != null && iq[0].Count > 0)
		{
			string a_2 = iq[0][0].abd();
			if (!m2(hg2.d0()))
			{
				g2 obj3 = he;
				hg hg3;
				g2 A_4 = (hg3 = hg2).d0();
				obj3.a(ref A_4);
				hg3.bu(A_4);
				hg2.bu(global::e.a().OperatorID, DateTime.Now);
			}
			hg2.d0().d(a_2);
		}
		if (vj() && hg2.d0().c() != g2.a.c && hg2.d0().c() != g2.a.b)
		{
			if (uv())
			{
				hg2.d0().o(g2.a.b);
			}
			else
			{
				hg2.d0().o(g2.a.c);
			}
			hg2.bv(global::e.a().OperatorID, DateTime.Now);
		}
		ih.e(hg2.d0(), ref A_2);
		m2(ii, hg2.d0(), ref A_3);
		if (A_2 || A_3)
		{
			hg2.bv(global::e.a().OperatorID, DateTime.Now);
		}
		checked
		{
			if (!vj() || A_0.b8().a(iv) != global::h.e.c)
			{
				if (A_0.b8().p())
				{
					A_0.d0().c(uh());
				}
				else
				{
					List<it> list = null;
					bool A_5 = false;
					List<iu> list2 = new List<iu>();
					List<iv> a_3 = vi();
					int A_6 = default(int);
					list = m2(A_0, A_1, ref A_5, ref A_6);
					list2 = m2(list, a_3);
					if (list2 != null)
					{
						int num = list2.IndexOf(new iu(A_0.b8().@as()));
						int num2 = default(int);
						if (num >= 0)
						{
							List<string> list3 = list2[num].b;
							global::h.g A_7 = global::h.g.a;
							global::h.e A_8 = global::h.e.a;
							bool A_9 = false;
							num2 = list3.IndexOf(m2(A_0: false, A_0, A_2: false, ref A_7, ref A_8, ref A_9));
						}
						if (num >= 0 && num2 >= 0)
						{
							A_0.d0().c(list2[num].b[num2]);
						}
						else
						{
							string A_10 = null;
							int upperBound = iq.GetUpperBound(0);
							for (int num3 = 0; num3 <= upperBound; num3++)
							{
								if (!sn(A_0.b8(), num3) || iq[num3] == null)
								{
									continue;
								}
								int num4 = iq[num3].Count - 1;
								for (int num5 = 0; num5 <= num4; num5++)
								{
									if (p9(A_0.b8(), num5, num3))
									{
										int a_4 = num3;
										int a_5 = num5;
										string A_11 = null;
										bool A_9 = false;
										bool A_12 = false;
										m2(a_4, a_5, ref A_11, ref A_10, ref A_9, ref A_12);
										break;
									}
								}
								if (!string.IsNullOrEmpty(A_10))
								{
									break;
								}
							}
							A_0.d0().c(A_10);
						}
					}
				}
			}
			hg2 = null;
		}
	}

	private void m2(global::r.d A_0, bool A_1, global::r.d.a.b A_2)
	{
		s s2 = new s(A_2);
		p9(hb, A_1: false);
		this.s3(hb);
		s s3 = s2;
		((m)s3).a = m.a.j;
		s3.d = m.TaskExecutionType.Setup;
		s3.g = A_0;
		s3.bv = new hg(hb.dh(), hb.cd());
		hb.bu(ref s3.bv);
		s3 = null;
		string A_3 = "";
		string A_4 = "";
		m2(ref A_3, ref A_4, s2);
	}

	public void m2(hg A_0, global::r.d A_1, bool A_2)
	{
		hb.bv(A_0);
		hb = A_0;
		hb.bv(A_1, A_2);
	}

	private void sj(hg A_0)
	{
		hb.bv(m2, sj);
		hb = A_0;
		hb.bu(m2, sj);
	}

	private string m2(bool A_0, hg A_1, bool A_2, ref global::h.g A_3, ref global::h.e A_4, ref bool A_5)
	{
		bool flag = hc.d0().c() == g2.a.b;
		global::h h10 = m2(A_1, flag, A_2: true);
		string result;
		if (A_0 && h10.a(v4(), uq()))
		{
			A_3 = global::h.g.a;
			A_4 = global::h.e.b;
			result = A_1.b8().a(global::h.g.a).c();
		}
		else
		{
			if (flag)
			{
				A_4 = global::h.e.a;
			}
			else
			{
				A_4 = A_1.b8().a(iv);
			}
			A_3 = global::h.a(vk(), A_4);
			global::h h11 = A_1.b8();
			result = h11.a(A_3).c();
			if (vk() && A_4 != global::h.e.c && Operators.CompareString(h11.a(global::h.g.b).c(), "1", TextCompare: false) != 0)
			{
				if (A_2)
				{
					h11.a(global::h.g.b).c("1");
					A_5 = true;
				}
				if (A_3 == global::h.g.b)
				{
					result = "1";
				}
			}
			h11 = null;
		}
		return result;
	}

	public void m2(bool A_0, bool A_1, global::r.d A_2, bool A_3, global::r.d.a.b A_4)
	{
		hg hg2 = hb;
		bool A_5 = false;
		bool flag = hc.d0().c() == g2.a.b;
		global::h h10 = m2(hc, flag, A_2: true);
		checked
		{
			bool flag2 = default(bool);
			if (A_3 && h10.a(v4(), uq()))
			{
				int num = @is.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (@is[num2].yn())
					{
						flag2 = true;
						break;
					}
				}
			}
			else
			{
				int num3 = global::h.a();
				for (int num4 = 0; num4 <= num3; num4++)
				{
					int num5 = iu[num4];
					if (num5 < 0)
					{
						continue;
					}
					int num6 = iq[num5].Count - 1;
					for (int num7 = 0; num7 <= num6; num7++)
					{
						if (p9(h10, num7, num5) && iq[num5][num7].yn())
						{
							flag2 = true;
							break;
						}
					}
				}
			}
			if (flag2)
			{
				global::h obj = hg2.b8();
				global::h.g A_6 = default(global::h.g);
				global::h.e A_7 = default(global::h.e);
				m2(A_3, hb, A_2: true, ref A_6, ref A_7, ref A_5);
				string text = m2(global::h.a(A_7), A_3);
				if (flag && !text.StartsWith(ex.e()))
				{
					text = ex.j(text);
				}
				global::g g10 = obj.a(A_6);
				if ((Operators.CompareString(g10.c(), text, TextCompare: false) != 0 || !g10.d()) && !hg2.b8().p() && (!zn() || x3() || flag) && !string.IsNullOrEmpty(text))
				{
					g10.c(text);
					g10.c(A_0: true);
					A_5 = true;
				}
				g10 = null;
				_ = null;
				if (A_5)
				{
					hg2.cj(hg2.cm());
				}
			}
			s s2 = new s(A_4);
			s s3 = s2;
			((m)s3).a = m.a.k;
			s3.d = m.TaskExecutionType.Setup;
			s3.g = A_2;
			s3.by = A_0;
			s3.bz = A_1;
			s3.bv = new hg(hb.dh(), hb.cd());
			s3.b6 = A_3;
			s3.cc = wj();
			hb.bu(ref s3.bv);
			s3 = null;
			string A_8 = "";
			string A_9 = "";
			m2(ref A_8, ref A_9, s2);
		}
	}

	public void m2(bool A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		s s2 = new s(A_2);
		((m)s2).a = m.a.af;
		s2.d = m.TaskExecutionType.Setup;
		s2.b6 = A_0;
		s2.g = A_1;
		_ = null;
		string A_3 = "";
		string A_4 = "";
		m2(ref A_3, ref A_4, s2);
	}

	[SpecialName]
	public bool wm()
	{
		return @in;
	}

	[SpecialName]
	public void s6(bool A_0)
	{
		@in = A_0;
	}

	[SpecialName]
	public bool wn()
	{
		return io;
	}

	[SpecialName]
	public void s8(bool A_0)
	{
		io = A_0;
	}

	public void m2(ref bool A_0, ref bool A_1, ref bool A_2, ref float A_3, ref float A_4)
	{
		A_0 = yz() && im.tc();
		A_1 = A_0 && im.s4();
		A_2 = A_0 && im.s6();
		if (A_0)
		{
			A_3 = im.s8();
			A_4 = im.tb();
		}
		else
		{
			A_3 = float.MaxValue;
			A_4 = float.MaxValue;
		}
	}

	private void qh(hg A_0)
	{
		try
		{
			bool a_ = false;
			hd = true;
			if (hc != null && hc.b8().at() != A_0.b8().at())
			{
				foreach (m item in zz())
				{
					if (item is t)
					{
						((t)item).cf = A_0.b8().at();
					}
				}
				foreach (m item2 in zy())
				{
					if (item2 is t)
					{
						((t)item2).cf = A_0.b8().at();
					}
				}
			}
			hc = A_0;
			hg hg2 = hc;
			et a_2 = (et)hg2.d0().r();
			if (g2.c(he, hg2.d0()))
			{
				if (iq == null)
				{
					return;
				}
				int upperBound = iq.GetUpperBound(0);
				a_ = true;
				he = hg2.d0();
				int num = upperBound;
				for (int num2 = 0; num2 <= num; num2 = checked(num2 + 1))
				{
					if (iq[num2] == null)
					{
						continue;
					}
					foreach (ip item3 in iq[num2])
					{
						g2 g10 = hc.d0();
						item3.sj(g10.d(ix[num2]));
						item3.m2(a_2);
						if (g10.q())
						{
							item3.m2(g10.s());
						}
						else
						{
							item3.m2((cf)null);
						}
						g10 = null;
					}
				}
			}
			hg2 = null;
			qh(a_, A_1: true);
			qh();
		}
		finally
		{
			hd = false;
		}
	}

	private bool m2(g2 A_0)
	{
		if (A_0.l())
		{
			return true;
		}
		if (iq == null || iq.GetUpperBound(0) < 0 || iq[0] == null || iq[0].Count == 0)
		{
			return false;
		}
		return Operators.CompareString(A_0.k(), iq[0][0].abd(), TextCompare: false) == 0;
	}

	private bool p9(hg A_0)
	{
		g2 g10 = A_0.d0();
		if (g10.d())
		{
			return false;
		}
		if (!g10.q() && (xs() || A_0.dh().bq()))
		{
			return false;
		}
		if (g10.c() == g2.a.b != uv())
		{
			return false;
		}
		if ((g10.c() == g2.a.c || g10.c() == g2.a.b) && !vj())
		{
			return false;
		}
		if (v6() && g10.c() != g2.a.d)
		{
			return false;
		}
		if (g10.n() && m2(A_0))
		{
			return false;
		}
		if (ms && g10.c() == g2.a.n && !u7())
		{
			return false;
		}
		if (g10.p())
		{
			return u5();
		}
		if (g10.q() && !u6())
		{
			return false;
		}
		return u4() || A_0.dh().bq();
	}

	private void qh(bool A_0, bool A_1)
	{
		global::h h10 = hc.b8();
		if (iq == null)
		{
			return;
		}
		int upperBound = iq.GetUpperBound(0);
		int num = 0;
		checked
		{
			while (true)
			{
				if (num <= upperBound)
				{
					if (iq[num] != null)
					{
						g2.a(zp(), ix[num]);
						global::f obj = h10.a(num);
						double a_ = obj.b(global::f.b.b);
						int num2 = obj.h(global::f.b.b);
						double a_2 = obj.b(global::f.b.c);
						int num3 = obj.h(global::f.b.c);
						double a_3 = h10.a(s4(num), qh(h10, num));
						m2(a_, (short)num2, a_2, (short)num3, a_3, h10.n(v6()), num, A_1);
						_ = null;
						num++;
						continue;
					}
					break;
				}
				so(A_0);
				if (l2 != null && vg())
				{
					ej.b a_4 = ui();
					l2.b(a_4, global::e.a().VideoShowSpot);
				}
				break;
			}
		}
	}

	private ej.b ui()
	{
		ip ip2 = null;
		global::h a_ = hc.b8();
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			for (int num = 0; num <= upperBound; num++)
			{
				int num2 = iq[num].Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (p9(a_, num3, num, A_3: false))
					{
						ip2 = iq[num][num3];
						break;
					}
				}
			}
			if (ip2.aby())
			{
				return ej.b.a;
			}
			return ej.b.b;
		}
	}

	private void m2(int A_0, int A_1, ref string A_2, ref string A_3, ref bool A_4, ref bool A_5)
	{
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = g2.a(zp(), ix[A_0]);
		ip ip2 = iq[A_0][A_1];
		if (m2(A_0, zp(), iq[A_0][A_1], ref A_2, ref A_3))
		{
			A_4 = true;
			if (zp() == g2.a.b && opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.ReflectanceProbe)
			{
				A_5 = true;
			}
		}
		else
		{
			ip obj = ip2;
			string a_ = A_2;
			string a_2 = A_3;
			io.a a_3 = ip2.bb();
			bool A_6 = false;
			bool A_7 = default(bool);
			obj.m2(a_, a_2, opticsConfigSubmoduleTypes, a_3, ref A_7, ref A_6);
			A_4 = !A_7;
		}
		ip2 = null;
	}

	private void so(bool A_0)
	{
		if (iq == null)
		{
			return;
		}
		bool flag = false;
		global::h h10 = hc.b8();
		global::f f10 = null;
		string A_1 = "";
		string A_2 = "";
		int upperBound = iq.GetUpperBound(0);
		int num = upperBound;
		int num2 = 0;
		checked
		{
			bool A_4 = default(bool);
			bool A_5 = default(bool);
			bool A_6 = default(bool);
			while (true)
			{
				if (num2 <= num)
				{
					if (iq[num2] == null)
					{
						break;
					}
					g2.OpticsConfigSubmoduleTypes a_ = g2.a(zp(), ix[num2]);
					f10 = ((!h10.t()) ? h10.a(num2) : h10.a(0));
					if (p9(h10, num2, A_2: true))
					{
						bool A_3 = false;
						bool a_2 = so(num2);
						int num3 = sj(num2);
						int num4 = iq[num2].Count - 1;
						for (int num5 = 0; num5 <= num4; num5++)
						{
							if (iq[num2].Count != 1 && !((num3 != num5) ? (f10.b(a_2) == global::f.a.a || f10.b(a_2) == global::f.a.d || f10.b(a_2) == global::f.a.c) : (f10.b(a_2) == global::f.a.a || f10.b(a_2) == global::f.a.d || f10.b(a_2) == global::f.a.b)))
							{
								continue;
							}
							ip ip2 = iq[num2][num5];
							m2(num2, num5, ref A_1, ref A_2, ref A_3, ref A_4);
							if (A_3)
							{
								ip2.m2(A_1, A_2, ref A_5, A_4, ref A_6);
								if (!string.IsNullOrEmpty(ip2.vp()))
								{
									ip2.sm(a_);
								}
							}
							iq iq2 = null;
							if (hc.d0().n() && (zp() != g2.a.b || A_3) && ip2.m2(iq2) && ip2.p9(iq2))
							{
								ip2.p9(jk, A_1: true);
							}
							if ((A_0 || (A_3 && !A_5)) && ip2.m2(jk, iq2) && (!ip2.wf() || !ip2.wg()))
							{
								ip2.p9(A_0: true, A_1: true);
							}
							ip2 = null;
						}
					}
					num2++;
					continue;
				}
				if (A_4)
				{
					if (!A_6)
					{
						int num6 = upperBound;
						for (int num7 = 0; num7 <= num6; num7++)
						{
							if (g2.a(zp(), ix[num7]) != g2.OpticsConfigSubmoduleTypes.ReflectanceProbe)
							{
								int num8 = iq[num7].Count - 1;
								for (int num9 = 0; num9 <= num8; num9++)
								{
									iq[num7][num9].te(A_0: true);
								}
							}
						}
					}
					if (!xl())
					{
						sn(hc.b8());
					}
				}
				ue();
				break;
			}
		}
	}

	private string sj(global::h A_0, int A_1)
	{
		global::h.f f10 = ((ix != null) ? ix[A_1] : global::h.f.a);
		global::g g10 = ((f10 != global::h.f.b) ? A_0.a(global::h.g.a) : A_0.a(global::h.g.b));
		if (g10.d())
		{
			switch (g2.a(zp(), f10))
			{
			case g2.OpticsConfigSubmoduleTypes.ContactProbeHandHeldAutoRef:
			case g2.OpticsConfigSubmoduleTypes.ContactStageAutoRef:
				return "FiberTip";
			case g2.OpticsConfigSubmoduleTypes.Transmittance:
				if (vk())
				{
					return "1";
				}
				return g10.c();
			case g2.OpticsConfigSubmoduleTypes.CTMProbe:
				return "0";
			case g2.OpticsConfigSubmoduleTypes.ReflectanceProbe:
				if (zp() == g2.a.b)
				{
					if (g10.c().StartsWith(ex.e()))
					{
						return g10.c();
					}
					return ex.e() + g10.c();
				}
				return g10.c();
			default:
				return g10.c();
			}
		}
		if (g2.a(zp(), f10) == g2.OpticsConfigSubmoduleTypes.Transmittance && (vk() || !iv[0]))
		{
			return "1";
		}
		return vw();
	}

	private bool m2(int A_0, g2.a A_1, ip A_2, ref string A_3, ref string A_4)
	{
		global::h h10 = hc.b8();
		ip ip2 = A_2;
		if (h10.p())
		{
			A_4 = ip2.vp();
			A_3 = ip2.yk();
		}
		else
		{
			if (g2.j(A_1))
			{
				if (A_1 == g2.a.b)
				{
					A_3 = h10.@as();
					A_4 = sj(hc.b8(), A_0);
				}
				else
				{
					A_3 = string.Empty;
					A_4 = "FiberTip";
				}
			}
			else if (A_1 == g2.a.m)
			{
				A_3 = string.Empty;
				A_4 = "0";
			}
			else
			{
				A_3 = h10.@as();
				A_4 = sj(hc.b8(), A_0);
			}
			if (ip2.yl())
			{
				return true;
			}
			if (Operators.CompareString(ip2.yk(), A_3, TextCompare: false) != 0)
			{
				return true;
			}
			if (Operators.CompareString(ip2.vp(), A_4, TextCompare: false) != 0)
			{
				return true;
			}
		}
		ip2 = null;
		return false;
	}

	public void m2(global::h.f A_0, global::f.b A_1, ref double A_2)
	{
		int num = iu[(int)A_0];
		if (iq != null && iq[num] != null)
		{
			ip ip2 = null;
			int index = ((A_1 != global::f.b.c) ? sj(num) : qh(num));
			ip2 = iq[num][index];
			A_2 = ip2.w6();
		}
	}

	public void m2(int A_0, ref double A_1, ref int A_2, ref double A_3, ref int A_4)
	{
		if (iq == null || iq[A_0] == null)
		{
			return;
		}
		ip ip2 = null;
		int num = sj(A_0);
		iq a_ = null;
		bool a_2 = zp() == g2.a.b;
		checked
		{
			int num2 = iq[A_0].Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				ip2 = iq[A_0][num3];
				if (num3 == num)
				{
					A_1 = ip2.qh(a_, a_2);
					A_2 = ip2.m2(jk, a_2);
				}
				else
				{
					A_3 = ip2.qh(a_, a_2);
					A_4 = ip2.m2(jk, a_2);
				}
			}
		}
	}

	public void m2(int A_0, ref float[] A_1, ref float[] A_2, ref float[] A_3, ref float[] A_4, ref float A_5, ref float A_6, ref float A_7, ref float A_8, ref float A_9, ref float A_10, ref float A_11, ref float A_12, ref float A_13, ref float A_14, ref float A_15, ref float A_16, ref double A_17, ref double A_18)
	{
		if (iq == null || iq[A_0] == null)
		{
			return;
		}
		int num = sj(A_0);
		checked
		{
			int num2 = iq[A_0].Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				ip ip2 = iq[A_0][num3];
				int num4 = ip2.vx() - 1;
				if (num3 == num)
				{
					A_1 = new float[num4 + 1];
					A_2 = new float[num4 + 1];
					int num5 = num4;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						ip2.m2(num6, jk, ref A_1[num6], ref A_2[num6]);
					}
					ip2.p9(ref A_5, ref A_6);
					ip2.qh(ref A_9, ref A_10);
					ip2.m2(ref A_13, ref A_14);
					A_17 = ip2.u5();
				}
				else
				{
					A_3 = new float[num4 + 1];
					A_4 = new float[num4 + 1];
					int num7 = num4;
					for (int num8 = 0; num8 <= num7; num8++)
					{
						ip2.m2(num8, jk, ref A_3[num8], ref A_4[num8]);
					}
					ip2.p9(ref A_7, ref A_8);
					ip2.qh(ref A_11, ref A_12);
					ip2.m2(ref A_15, ref A_16);
					A_18 = ip2.u5();
				}
				ip2 = null;
			}
		}
	}

	public void m2(int A_0, int A_1, ref float A_2, ref float A_3)
	{
		int num = sj(A_0);
		checked
		{
			int num2 = iq[A_0].Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				ip ip2 = iq[A_0][num3];
				if (num3 == num)
				{
					A_2 = ip2.st(ip2.sm(A_1));
				}
				else
				{
					A_3 = ip2.st(ip2.sm(A_1));
				}
				ip2 = null;
			}
		}
	}

	public void m2(int A_0, int A_1, int A_2, ref float A_3, ref float A_4, ref int A_5, ref int A_6)
	{
		int num = sj(A_0);
		bool a_ = zp() == g2.a.b;
		checked
		{
			int num2 = iq[A_0].Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				ip ip2 = iq[A_0][num3];
				if (num3 == num)
				{
					A_3 = ip2.m2(A_2, A_1, ref A_5, a_, A_4: false);
				}
				else
				{
					A_4 = ip2.m2(A_2, A_1, ref A_6, a_, A_4: false);
				}
				ip2 = null;
			}
		}
	}

	public void m2(int A_0, int A_1, int A_2, int A_3, ref float A_4, ref float A_5, ref float A_6, ref float A_7)
	{
		ip ip2 = null;
		int num = sj(A_0);
		checked
		{
			int num2 = iq[A_0].Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				ip2 = iq[A_0][num3];
				ip ip3 = ip2;
				double num4 = ip2.wc() / ip2.sm(0);
				if (num3 == num)
				{
					A_4 = ip3.m2(A_1, A_1: false, ref A_2);
					A_6 = A_4 * (float)num4;
				}
				else
				{
					A_5 = ip3.m2(A_1, A_1: false, ref A_3);
					A_7 = A_5 * (float)num4;
				}
				ip3 = null;
			}
		}
	}

	private void m2(double A_0, short A_1, double A_2, short A_3, double A_4, global::h.MeasurementTimingType A_5, int A_6, bool A_7)
	{
		ip ip2 = null;
		if (iq[A_6] == null)
		{
			return;
		}
		int num = sj(A_6);
		checked
		{
			int num2 = iq[A_6].Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				ip2 = iq[A_6][num3];
				if (num3 == num)
				{
					ip2.m2(A_0, A_1, A_4, A_5, A_7);
				}
				else
				{
					ip2.m2(A_2, A_3, A_4, A_5, A_7);
				}
			}
		}
	}

	private void m2(hg A_0, double[] A_1, bool A_2, ref int A_3, ref int A_4)
	{
		if (A_2)
		{
			A_3 = 0;
			A_4 = 0;
			return;
		}
		hi hi2 = A_0.b3(A_0.c2());
		if (hi2.ft())
		{
			m2(hi2, A_1, A_0, ref A_3, ref A_4);
			return;
		}
		float A_5 = default(float);
		float A_6 = default(float);
		A_0.bu(ref A_5, ref A_6);
		A_3 = 0;
		checked
		{
			while ((A_1[A_3] < (double)A_5) & (A_3 < A_1.Length - 1))
			{
				A_3++;
			}
			if (A_1[A_1.Length - 1] < (double)A_6)
			{
				A_4 = A_1.Length - 1;
			}
			else
			{
				A_4 = A_3;
				while ((A_1[A_4] <= (double)A_6) & (A_4 < A_1.Length - 1))
				{
					A_4++;
				}
				if (A_4 > 0 && A_1[A_4] > (double)A_6)
				{
					A_4--;
				}
			}
			if (A_4 > A_3)
			{
				return;
			}
			string A_7 = "NoDataWithinRange";
			string text = string.Format(hu.a(ref A_7), A_5.ToString("#.##"), A_6.ToString("#.##"), A_0.ci());
			if (!A_0.ed().ft())
			{
				string text2 = text;
				A_7 = "GraphWavelengthRangeWillBeUpdated";
				text = text2 + "\r\n" + hu.a(ref A_7);
			}
			throw new ag(text);
		}
	}

	private void m2(hi A_0, double[] A_1, ref int A_2, ref int A_3)
	{
		m2(A_0, A_1, hc, ref A_2, ref A_3);
	}

	private void m2(hi A_0, double[] A_1, hg A_2, ref int A_3, ref int A_4)
	{
		float num = (float)A_0.fs();
		float num2 = (float)A_0.fr();
		m2(A_1, num, num2, A_2, ref A_3, ref A_4);
	}

	private void m2(double[] A_0, double A_1, double A_2, ref int A_3, ref int A_4)
	{
		m2(A_0, A_1, A_2, hc, ref A_3, ref A_4);
	}

	private void m2(double[] A_0, double A_1, double A_2, hg A_3, ref int A_4, ref int A_5)
	{
		A_4 = 0;
		checked
		{
			while ((A_0[A_4] < A_1) & (A_4 < A_0.Length - 1))
			{
				A_4++;
			}
			A_5 = A_0.Length - 1;
			while ((A_0[A_5] > A_2) & (A_5 > 0))
			{
				A_5--;
			}
			if (A_5 == A_4)
			{
				string A_6 = "NoDataWithinRange";
				throw new ag(string.Format(hu.a(ref A_6), A_1.ToString("#.##"), A_2.ToString("#.##"), A_3.ci()));
			}
		}
	}

	private int sj(int A_0)
	{
		if (jp != null)
		{
			return jp[A_0];
		}
		return 0;
	}

	private int qh(int A_0)
	{
		if (iq[A_0].Count < 2)
		{
			throw new af("Attempt to access long wavelength spectrometer when it doesn't exist in GetLongSpecIdx");
		}
		if (jq != null)
		{
			return jq[A_0];
		}
		return 0;
	}

	private int p9(int A_0, global::f.b A_1)
	{
		return A_1 switch
		{
			global::f.b.b => sj(A_0), 
			global::f.b.c => qh(A_0), 
			_ => 0, 
		};
	}

	public global::f.b so(int A_0, int A_1)
	{
		if (sj(A_0) == A_1)
		{
			return global::f.b.b;
		}
		if (qh(A_0) == A_1)
		{
			return global::f.b.c;
		}
		return global::f.b.a;
	}

	public void m2(global::h A_0, bool A_1, bool A_2, ref bool[] A_3)
	{
		checked
		{
			A_3 = new bool[global::h.a() + 1];
			int num = global::h.a();
			for (int num2 = 0; num2 <= num; num2++)
			{
				A_3[num2] = false;
			}
			global::h.e e10 = A_0.a(iv);
			if ((hc.d0().c() == g2.a.c || hc.d0().c() == g2.a.b) && e10 == global::h.e.c)
			{
				A_3[1] = true;
			}
			else if (A_1)
			{
				if (e10 == global::h.e.a || e10 == global::h.e.f || e10 == global::h.e.e || e10 == global::h.e.b)
				{
					A_3[0] = true;
					if (iv[1] && A_2 && iq.GetUpperBound(0) > 0)
					{
						A_3[1] = true;
					}
				}
				if (iv[2] && (e10 == global::h.e.a || e10 == global::h.e.d || e10 == global::h.e.f || e10 == global::h.e.g))
				{
					A_3[2] = true;
				}
			}
			else if (iv[1] && e10 != global::h.e.d)
			{
				A_3[1] = true;
			}
		}
	}

	public void wo()
	{
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			for (int num = 0; num <= upperBound; num++)
			{
				int num2 = iq[num].Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (p9(hc.b8(), num3, num))
					{
						iq[num][num3].ym();
					}
				}
			}
		}
	}

	public void m2(float A_0, float A_1, bool A_2, bool A_3, int A_4, bool A_5, ref bool A_6, ref string A_7, ref string A_8)
	{
		if (A_5 && hc.b8().a(v4(), uq()))
		{
			m2(A_0, A_1, ref A_6, ref A_7, ref A_8);
			return;
		}
		bool[] A_9 = null;
		bool flag = zp() == g2.a.b;
		A_6 = true;
		A_7 = "";
		A_8 = "";
		global::h a_ = m2(hc, flag, A_2: true);
		m2(a_, A_2, A_3, ref A_9);
		double A_10 = default(double);
		DateTime A_11 = default(DateTime);
		double A_12 = default(double);
		foreach (object value in Enum.GetValues(typeof(global::h.f)))
		{
			global::h.f f10 = (global::h.f)Conversions.ToInteger(value);
			if (!A_9[(int)f10])
			{
				continue;
			}
			int num = iu[(int)f10];
			checked
			{
				int num2 = iq[num].Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (!p9(a_, num3, num))
					{
						continue;
					}
					if (!iq[num][num3].m2(A_0, A_4, flag, ref A_10, ref A_11, ref A_12))
					{
						A_6 = false;
						string arg = global::r.g.a.a6(sj(num) == num3, iq[num].Count > 1, f10, vj());
						if (!string.IsNullOrEmpty(A_7))
						{
							A_7 += ", \r\n";
						}
						string obj = A_7;
						string A_13 = "ReferenceInvalidIntensityLowWRTHistoryFmt3";
						A_7 = obj + string.Format(hu.a(ref A_13), arg, (A_10 * 100.0).ToString("0"), A_11.ToLocalTime().ToString());
					}
					else if (A_12 > (double)A_1)
					{
						string arg2 = global::r.g.a.a6(sj(num) == num3, iq[num].Count > 1, f10, vj());
						if (!string.IsNullOrEmpty(A_8))
						{
							A_8 += ", \r\n";
						}
						string obj2 = A_8;
						string A_13 = "ReferenceIntensityHighWRTPrevFmt2";
						A_8 = obj2 + string.Format(hu.a(ref A_13), arg2, (A_12 * 100.0).ToString("0"));
					}
					_ = null;
				}
			}
		}
	}

	private bool m2(bool[] A_0)
	{
		int num = 0;
		checked
		{
			for (int num2 = 0; num2 < A_0.Length; num2++)
			{
				if (A_0[num2])
				{
					num++;
				}
				if (num > 1)
				{
					return true;
				}
			}
			return false;
		}
	}

	public void m2(ref bool A_0, bool A_1, bool A_2, ref string A_3)
	{
		global::f.a a10 = default(global::f.a);
		bool flag = a10 == global::f.a.a || a10 == global::f.a.d || a10 == global::f.a.b;
		bool[] A_4 = null;
		A_0 = false;
		m2(hc.b8(), A_1, A_2, ref A_4);
		float A_5 = default(float);
		float A_6 = default(float);
		float A_7 = default(float);
		float A_8 = default(float);
		int A_9 = default(int);
		int A_10 = default(int);
		float A_11 = default(float);
		float A_12 = default(float);
		float A_13 = default(float);
		float A_14 = default(float);
		float num5 = default(float);
		float num6 = default(float);
		foreach (object value in Enum.GetValues(typeof(global::h.f)))
		{
			global::h.f f10 = (global::h.f)Conversions.ToInteger(value);
			if (!A_4[(int)f10])
			{
				continue;
			}
			int num = iu[(int)f10];
			global::h.f f11 = ((!hc.b8().t()) ? f10 : global::h.f.a);
			a10 = hc.b8().a((int)f11).b(so(iu[(int)f11]));
			bool flag2 = iq[num].Count > 1;
			flag = !flag2 || a10 == global::f.a.a || a10 == global::f.a.d || a10 == global::f.a.b;
			bool flag3 = flag2 && (a10 == global::f.a.a || a10 == global::f.a.d || a10 == global::f.a.c);
			checked
			{
				int num2 = iq[num][0].vy() - 1;
				if ((flag && !iq[num][p9(num, global::f.b.b)].wd()) || (flag3 && !iq[num][p9(num, global::f.b.c)].wd()))
				{
					continue;
				}
				int num3 = num2;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					m2(num, num4, ref A_5, ref A_6);
					m2(num, num4, 60, ref A_7, ref A_8, ref A_9, ref A_10);
					m2(num, 60, A_9, A_10, ref A_11, ref A_12, ref A_13, ref A_14);
					if (flag)
					{
						if (A_5 > A_11)
						{
							A_7 -= A_11;
							A_11 = 0f;
						}
						else if (A_5 > 0f)
						{
							A_7 -= A_5;
							A_11 -= A_5;
						}
						num5 = ((A_11 <= 0f) ? float.MaxValue : ((zp() != g2.a.b) ? (A_7 / A_11) : (A_7 / A_13)));
					}
					if (flag3)
					{
						if (A_6 > A_12)
						{
							A_8 -= A_12;
							A_12 = 0f;
						}
						else if (A_6 > 0f)
						{
							A_8 -= A_6;
							A_12 -= A_6;
						}
						num6 = ((A_12 <= 0f) ? float.MaxValue : ((zp() != g2.a.b) ? (A_8 / A_12) : (A_8 / A_14)));
					}
					bool flag4 = flag && (A_7 <= 0f || num5 < 1.05f);
					bool flag5 = flag3 && (A_8 <= 0f || num6 < 1.05f);
					if (flag4 || flag5)
					{
						A_0 = true;
						if (m2(A_4) || flag2)
						{
							A_3 = global::r.g.a.a6(flag4, flag2, f10, m2(A_4));
						}
						else
						{
							A_3 = string.Empty;
						}
						ub();
						xn();
						xm();
						return;
					}
				}
			}
		}
	}

	public double sj(h6.b A_0, int A_1, global::f.b A_2)
	{
		return m2(A_0, A_1, A_2)?.vm() ?? 0.0;
	}

	public double sm(h6.b A_0, int A_1, global::f.b A_2)
	{
		return m2(A_0, A_1, A_2)?.vl() ?? 0.0;
	}

	public double m2(h6.b A_0, int A_1, global::f.b A_2, double A_3)
	{
		return m2(A_0, A_1, A_2)?.sm(A_3) ?? A_3;
	}

	private int qh(global::h A_0, int A_1)
	{
		if (iq[A_1] == null)
		{
			return 0;
		}
		if (iq[A_1].Count > 1)
		{
			bool a_ = so(A_1);
			if (A_0.a(A_1).b(a_) == global::f.a.a || A_0.a(A_1).b(a_) == global::f.a.d)
			{
				return 2;
			}
			return 1;
		}
		return 1;
	}

	[SpecialName]
	public int sn(h6.b A_0, int A_1, global::f.b A_2)
	{
		return m2(A_0, A_1, A_2)?.vx() ?? 0;
	}

	[SpecialName]
	public string m2(global::f.b A_0, int A_1)
	{
		if (iq == null || iq.GetUpperBound(0) < A_1 || iq[A_1] == null)
		{
			return string.Empty;
		}
		switch (A_0)
		{
		case global::f.b.b:
			if (iq[A_1].Count > 0)
			{
				return iq[A_1][sj(A_1)].vp();
			}
			return "";
		case global::f.b.c:
			if (iq[A_1].Count > 1)
			{
				return iq[A_1][qh(A_1)].vp();
			}
			throw new ArgumentOutOfRangeException("Attempt to get LongSpec reference material when it doesn't exist");
		default:
			throw new ArgumentOutOfRangeException("Attempt to get reference material for invalid waveRange spectrometer");
		}
	}

	private string uh()
	{
		checked
		{
			int num = iq.Length - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				int num3 = iq[num2].Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (p9(hc.b8(), num4, num2))
					{
						return iq[num2][num4].vp();
					}
				}
			}
			return null;
		}
	}

	public void m2(ref string A_0, ref bool A_1, ref string A_2)
	{
		global::h h10 = hb.b8();
		checked
		{
			if (hj == null && h10.p())
			{
				int num = iq.Length - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					int num3 = iq[num2].Count - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						if (p9(hb.b8(), num4, num2))
						{
							A_0 = iq[num2][num4].vq();
							break;
						}
					}
				}
				if (string.IsNullOrEmpty(A_0))
				{
					A_0 = uh();
				}
				A_1 = true;
			}
			else
			{
				global::g g10 = h10.a(h10.d(vk()));
				A_1 = g10.d();
				A_0 = g10.c();
				g10 = null;
				A_2 = h10.@as();
			}
			h10 = null;
		}
	}

	private void m2(b A_0)
	{
		Collection<string> collection = new Collection<string>();
		bool flag = A_0 == b.c || A_0 == b.d;
		bool flag2 = A_0 == b.b || A_0 == b.d;
		checked
		{
			if (vo() != null && vo().Length > global::h.a())
			{
				int num = global::h.a();
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (!vo()[num2])
					{
						continue;
					}
					int num3 = iu[num2];
					int num4 = iq[num3].Count - 1;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						if (flag2)
						{
							iq[num3][num5].wy();
						}
						if (flag)
						{
							string item = iq[num3][num5].abn();
							if (!collection.Contains(item))
							{
								iq[num3][num5].abk().RefreshWriteEnabledState();
								collection.Add(item);
							}
						}
					}
				}
			}
			else if (flag && i0 != null)
			{
				i0.abk().RefreshWriteEnabledState();
			}
			if (flag)
			{
				if (ij != null)
				{
					ip.abk().RefreshWriteEnabledState();
				}
				if (ik != null)
				{
					ik.d().abk().RefreshWriteEnabledState();
				}
			}
		}
	}

	public bool wp()
	{
		if (l2 != null)
		{
			return l2.al();
		}
		return false;
	}

	public bool wq()
	{
		if (l2 != null)
		{
			return l2.ak();
		}
		return false;
	}

	public void m2(string A_0, int A_1, bool A_2, global::r.d.a.b A_3, ref bool A_4)
	{
		if (A_2 && hc.b8().a(v4(), uq()))
		{
			m2(A_0, ref A_4);
		}
		else
		{
			m2(A_0, A_1, A_3, ref A_4);
		}
	}

	private void m2(string A_0, int A_1, global::r.d.a.b A_2, ref bool A_3)
	{
		ip ip2 = null;
		hg obj = hc;
		int A_4 = 0;
		bool flag = obj.bu(A_0: false, null, ref A_4) != null;
		hj hj2 = null;
		int A_5 = 0;
		bool flag2 = false;
		do
		{
			if (!flag2)
			{
				foreach (ip item in iq[iu[A_1]])
				{
					if (flag)
					{
						item.st(A_5);
					}
					item.m2(A_0, ref A_3);
					if (flag)
					{
						item.s3(A_5);
					}
				}
			}
			hj2 = hc.bu(A_0: false, null, ref A_5);
			if (hj2 != null)
			{
				flag2 = !hj2.g();
			}
		}
		while (hj2 != null);
	}

	[SpecialName]
	public float[] wr()
	{
		float[] array = new float[2];
		int num = iu[0];
		if (num >= 0)
		{
			array[0] = iq[num][0].v4();
		}
		else
		{
			array[0] = 0f;
		}
		num = iu[2];
		if (num >= 0)
		{
			array[1] = iq[num][0].v4();
		}
		else
		{
			array[1] = 0f;
		}
		return array;
	}

	private void sn(bool A_0)
	{
		if (A_0 && hc.b8().a(v4(), uq()))
		{
			s8();
		}
		else
		{
			ug();
		}
	}

	private void ug()
	{
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			foreach (ip item in iq[num])
			{
				item.p9(A_0: false, 0);
			}
		}
	}

	public void m2(ref string A_0, ref string A_1, ref short A_2)
	{
		Collection<h6> collection = ua();
		A_1 = "";
		A_0 = "";
		A_2 = 0;
		if (collection.Count == 0)
		{
			return;
		}
		foreach (h6 item in collection)
		{
			if (Operators.CompareString(collection[0].abd(), item.abn(), TextCompare: false) == 0)
			{
				A_1 = item.abo();
				A_0 = item.abn();
				A_2 = item.abk().FWInstTypeCode;
				break;
			}
		}
	}

	public bool ws()
	{
		if (hj != null)
		{
			return hj.ao() == FMLegacyAllSystemTypes.kTypeF10 && (hj.an() == 1 || hj.an() == 7);
		}
		if (iq == null || iq[0] == null || iq[0][0] == null)
		{
			return false;
		}
		return iq[0][0].vg();
	}

	public bool wt()
	{
		if (hj != null)
		{
			return (hj.ao() == FMLegacyAllSystemTypes.kTypeF10 && (hj.an() == 3 || hj.an() == 6 || hj.an() == 8)) || hj.ao() == FMLegacyAllSystemTypes.kTypePARTS || hj.ao() == FMLegacyAllSystemTypes.kTypeF2;
		}
		if (iq == null || iq[0] == null || iq[0][0] == null)
		{
			return false;
		}
		return iq[0][0].vh();
	}

	public bool wu()
	{
		if (iq == null || iq[0] == null || iq[0][0] == null)
		{
			return false;
		}
		return iq[0][0].vi();
	}

	public void m2(ref FMLegacyAllSystemTypes A_0, ref int A_1)
	{
		if (hj != null)
		{
			A_0 = hj.ao();
			A_1 = hj.an();
			return;
		}
		h6 h10 = null;
		if (iq != null && iq[0] != null)
		{
			h10 = iq[0][0];
		}
		else if (@is != null)
		{
			h10 = @is[0];
		}
		if (h10 != null)
		{
			h6 h11 = h10;
			A_0 = h11.b();
			A_1 = h11.c();
			h11 = null;
		}
	}

	[SpecialName]
	public string wv()
	{
		FIUsbController fIUsbController = null;
		string text = null;
		if (iq != null && iq[0] != null)
		{
			ip ip2 = iq[0][0];
			fIUsbController = ip2.abk();
			text = ip2.abr().ToString().Trim() + "." + ip2.abs().ToString().Trim();
			ip2 = null;
		}
		else if (@is != null && @is.Count > 0)
		{
			fIUsbController = @is[0].abk();
			text = @is[0].abr().ToString().Trim() + "." + @is[0].abs().ToString().Trim();
		}
		if (fIUsbController == null)
		{
			return string.Empty;
		}
		string text2 = ((fIUsbController.USBHighSpeedActive == 0) ? "Full Speed USB1.0\r\n" : "High Speed USB2.0\r\n");
		return text2 + "FWRev. " + text;
	}

	[SpecialName]
	public string ww()
	{
		Collection<h6> collection = ua();
		if (collection.Count == 0)
		{
			return "No Spectrometers";
		}
		string text = h6.m2(collection[0].b(), collection[0].c(), null, collection[0].zi());
		int index = sj(0);
		if (iq != null && iq[0] != null)
		{
			if (iq[0][index].vu() < 270f)
			{
				text = ((iq[0].Count != 2) ? (text + "-UV") : (text + "-UVX"));
			}
			else if (iq[0].Count == 2)
			{
				text += "-EXR";
			}
		}
		return text;
	}

	[SpecialName]
	public bool wx()
	{
		h6 h10 = m2(0, A_1: false, A_2: false)[0];
		if (h10.b() != FMLegacyAllSystemTypes.kTypeF30)
		{
			return false;
		}
		if (global::iz.c(h10.abo().Substring(0, 2)) < 12)
		{
			return false;
		}
		return global::iz.c(h10.abo().Substring(3)) >= 185;
	}

	[SpecialName]
	public bool wy()
	{
		Collection<h6> collection = ua();
		if (collection.Count == 0)
		{
			return hj.af();
		}
		foreach (h6 item in collection)
		{
			if (item.zi())
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public bool wz()
	{
		Collection<h6> collection = ua();
		if (collection.Count == 0)
		{
			return hj.ai();
		}
		foreach (h6 item in collection)
		{
			if (item.zg())
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public bool w0()
	{
		Collection<h6> collection = ua();
		if (collection.Count == 0)
		{
			return hj.at();
		}
		foreach (h6 item in collection)
		{
			if (item.yv())
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public bool w1()
	{
		Collection<h6> collection = ua();
		if (collection.Count == 0)
		{
			return hj.ag();
		}
		foreach (h6 item in collection)
		{
			if (item.aaz())
			{
				return true;
			}
		}
		return false;
	}

	public bool m2(bool A_0, ref bool A_1)
	{
		if (A_0 && hb.b8().a(v4(), uq()))
		{
			return m2(ref A_1);
		}
		return m2(ref A_1, hb.b8());
	}

	private bool m2(ref bool A_0, global::h A_1)
	{
		bool result = true;
		int upperBound = iq.GetUpperBound(0);
		A_0 = true;
		int num = upperBound;
		checked
		{
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (iq[num2] != null)
				{
					int num3 = iq[num2].Count - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						if (!p9(A_1, num4, num2))
						{
							continue;
						}
						if (iq[num2][num4] == null)
						{
							A_0 = false;
							result = false;
							continue;
						}
						ip ip2 = iq[num2][num4];
						iq iq2 = null;
						if (ip2.zy())
						{
							if (ip2.p9(iq2) && !ip2.m2(jk, iq2))
							{
								if (!ip2.p9(iq2, A_1: false))
								{
									A_0 = false;
								}
								result = false;
							}
						}
						else if (ip2.m2(iq2) && ip2.p9(iq2))
						{
							if (!ip2.m2(jk, iq2))
							{
								if (!ip2.m2(iq2, zp() == g2.a.b) || !ip2.p9(iq2, zp() == g2.a.b))
								{
									A_0 = false;
								}
								result = false;
							}
						}
						else
						{
							A_0 = false;
						}
						ip2 = null;
					}
				}
				else
				{
					A_0 = false;
					result = false;
				}
			}
			if (!A_0)
			{
				result = false;
			}
			return result;
		}
	}

	public DateTime tb(bool A_0)
	{
		if (A_0 && hb.b8().a(v4(), uq()))
		{
			return td();
		}
		DateTime dateTime = DateTime.Now;
		checked
		{
			if (iq != null)
			{
				int upperBound = iq.GetUpperBound(0);
				bool a_2 = default(bool);
				for (int num = 0; num <= upperBound; num++)
				{
					if (iq[num] == null)
					{
						continue;
					}
					int num2 = iq[num].Count - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						if (!p9(hb.b8(), num3, num))
						{
							continue;
						}
						ip ip2 = iq[num][num3];
						if (ip2 == null)
						{
							continue;
						}
						iq a_ = p9(ip2);
						if (ip2.m2(a_) && !hb.d0().q())
						{
							int num4 = ip2.vx() - 1;
							for (int num5 = 0; num5 <= num4; num5++)
							{
								if (DateTime.Compare(ip2.sj(num5, a_2), dateTime) < 0)
								{
									dateTime = ip2.sj(num5, a_2);
								}
							}
						}
						if (ip2.p9(a_) && DateTime.Compare(ip2.wk(), dateTime) < 0)
						{
							dateTime = ip2.wk();
						}
					}
				}
			}
			return dateTime;
		}
	}

	public void m2(global::r.d.a.b A_0, long A_1, bool A_2)
	{
		global::r.d.a a_ = new global::r.d.a(A_0, A_1);
		sm(A_2);
		jg.d(gt, a_);
	}

	private void sm(bool A_0)
	{
		if (A_0 && hc.b8().a(v4(), uq()))
		{
			tf();
			return;
		}
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			foreach (ip item in iq[num])
			{
				item.p9(jk, A_1: false);
			}
		}
	}

	public bool w2()
	{
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			for (int num = 0; num <= upperBound; num++)
			{
				if (iq[num].Count > 0)
				{
					int num2 = iq[num].Count - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						ip ip2 = iq[num][num3];
						if (p9(hb.b8(), num3, num) && !ip2.p9(p9(ip2)))
						{
							return false;
						}
					}
					continue;
				}
				return false;
			}
			return true;
		}
	}

	public bool p9(global::f.b A_0, int A_1)
	{
		ip ip2 = m2(A_1, A_0);
		return ip2?.p9(p9(ip2)) ?? false;
	}

	private bool m2(ip A_0, bool A_1)
	{
		return A_0.m2(p9(A_0), zp() == g2.a.b);
	}

	public bool tc(bool A_0)
	{
		if (A_0 && hb.b8().a(v4(), uq()))
		{
			return tc();
		}
		return s3(hb.b8());
	}

	private bool s3(global::h A_0)
	{
		int upperBound = iq.GetUpperBound(0);
		bool flag = zp() == g2.a.b;
		int num = upperBound;
		checked
		{
			bool a_2 = default(bool);
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (iq[num2].Count > 0)
				{
					int num3 = iq[num2].Count - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						ip a_ = iq[num2][num4];
						if (p9(A_0, num4, num2) && (!m2(a_, a_2) || (lu && flag)))
						{
							return false;
						}
					}
					continue;
				}
				return false;
			}
			return true;
		}
	}

	public bool qh(global::f.b A_0, int A_1)
	{
		bool a_2 = default(bool);
		if (A_0 == global::f.b.b)
		{
			ip a_ = iq[A_1][sj(A_1)];
			_ = iq[A_1];
			return m2(a_, a_2);
		}
		if (iq[A_1].Count > 1)
		{
			ip a_3 = iq[A_1][qh(A_1)];
			return m2(a_3, a_2);
		}
		return false;
	}

	public bool td(bool A_0)
	{
		if (A_0 && hb.b8().a(v4(), uq()))
		{
			return te();
		}
		return st(hb.b8());
	}

	private bool st(global::h A_0)
	{
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			for (int num = 0; num <= upperBound; num++)
			{
				if (iq[num].Count > 0)
				{
					int num2 = iq[num].Count - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						ip ip2 = iq[num][num3];
						if (p9(A_0, num3, num) && !ip2.p9(p9(ip2), zp() == g2.a.b))
						{
							return false;
						}
					}
					continue;
				}
				return false;
			}
			return true;
		}
	}

	public bool sj(global::f.b A_0, int A_1)
	{
		if (A_0 == global::f.b.b)
		{
			ip ip2 = iq[A_1][sj(A_1)];
			return ip2.p9(p9(ip2), zp() == g2.a.b);
		}
		if (iq[A_1].Count > 1)
		{
			ip ip2 = iq[A_1][qh(A_1)];
			return ip2.p9(p9(ip2), zp() == g2.a.b);
		}
		return false;
	}

	public bool te(bool A_0)
	{
		if (A_0 && hb.b8().a(v4(), uq()))
		{
			return sm(hb.b8());
		}
		return so(hb.b8());
	}

	private bool so(global::h A_0)
	{
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (!p9(A_0, num))
			{
				return false;
			}
		}
		return true;
	}

	private bool p9(global::h A_0, int A_1)
	{
		checked
		{
			if (iq[A_1].Count > 0)
			{
				int num = iq[A_1].Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					ip ip2 = iq[A_1][num2];
					if (p9(A_0, num2, A_1) && (!ip2.p9(p9(ip2)) || !ip2.m2(jk, p9(ip2))))
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}
	}

	public bool sm(global::f.b A_0, int A_1)
	{
		if (A_0 == global::f.b.b)
		{
			ip ip2 = iq[A_1][sj(A_1)];
			ip ip3 = ip2;
			if (!ip3.p9(p9(ip2)) || !ip3.m2(jk, p9(ip2)))
			{
				return false;
			}
			return true;
		}
		if (iq[A_1].Count > 1)
		{
			ip ip2 = iq[A_1][qh(A_1)];
			ip ip4 = ip2;
			if (!ip4.p9(p9(ip2)) || !ip4.m2(jk, p9(ip2)))
			{
				return false;
			}
			return true;
		}
		return false;
	}

	private ip m2(int A_0, global::f.b A_1)
	{
		if (iq == null || iq.GetUpperBound(0) < A_0 || iq[A_0] == null)
		{
			return null;
		}
		ip result = null;
		if (A_1 == global::f.b.b)
		{
			if (iq[A_0].Count > 0)
			{
				int num = sj(A_0);
				if (iq[A_0].Count > num)
				{
					result = iq[A_0][num];
				}
			}
		}
		else if (iq[A_0].Count > 1)
		{
			int num = qh(A_0);
			if (iq[A_0].Count > num)
			{
				result = iq[A_0][num];
			}
		}
		return result;
	}

	public bool sn(global::f.b A_0, int A_1)
	{
		return m2(A_1, A_0)?.v5() ?? false;
	}

	public bool so(global::f.b A_0, int A_1)
	{
		return m2(A_1, A_0)?.v6() ?? false;
	}

	public bool w3()
	{
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			for (int num = 0; num <= upperBound; num++)
			{
				if (iq[num].Count > 0)
				{
					int num2 = iq[num].Count - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						ip ip2 = iq[num][num3];
						if (p9(hb.b8(), num3, num) && !ip2.m2(p9(ip2)))
						{
							return false;
						}
					}
					continue;
				}
				return false;
			}
			return true;
		}
	}

	public bool st(global::f.b A_0, int A_1)
	{
		ip ip2 = m2(A_1, A_0);
		if (ip2 == null)
		{
			return false;
		}
		iq a_ = null;
		return ip2.m2(a_);
	}

	public bool tf(bool A_0)
	{
		if (A_0 && hb.b8().a(v4(), uq()))
		{
			return sj(hb.b8());
		}
		return s6(hb.b8());
	}

	public bool s6(global::h A_0)
	{
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (!m2(A_0, num, hb.d0().q()))
			{
				return false;
			}
		}
		return true;
	}

	private bool m2(global::h A_0, int A_1, bool A_2)
	{
		checked
		{
			if (iq[A_1].Count > 0)
			{
				int num = iq[A_1].Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					ip ip2 = iq[A_1][num2];
					if (p9(A_0, num2, A_1))
					{
						iq iq2 = p9(ip2);
						if (!ip2.m2(iq2) || (!ip2.m2(jk, iq2) && !A_2))
						{
							return false;
						}
					}
				}
				return true;
			}
			return false;
		}
	}

	public bool w4()
	{
		if (!w5())
		{
			return w6();
		}
		return true;
	}

	public bool w5()
	{
		if (iq == null || iq[0] == null)
		{
			return false;
		}
		global::h a_ = hb.b8();
		bool result = false;
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			for (int num = 0; num <= upperBound; num++)
			{
				if (iq[num].Count <= 0)
				{
					continue;
				}
				int num2 = iq[num].Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					ip ip2 = iq[num][num3];
					if (p9(a_, num3, num))
					{
						if (!ip2.wt())
						{
							return false;
						}
						result = true;
					}
				}
			}
			return result;
		}
	}

	public bool w6()
	{
		if (iq == null || iq[0] == null)
		{
			return false;
		}
		global::h a_ = hb.b8();
		bool result = false;
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			for (int num = 0; num <= upperBound; num++)
			{
				if (iq[num].Count <= 0)
				{
					continue;
				}
				int num2 = iq[num].Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					ip ip2 = iq[num][num3];
					if (p9(a_, num3, num))
					{
						if (!ip2.xb())
						{
							return false;
						}
						result = true;
					}
				}
			}
			return result;
		}
	}

	private iq p9(ip A_0)
	{
		return null;
	}

	public bool s3(global::f.b A_0, int A_1)
	{
		if (A_0 == global::f.b.b)
		{
			ip ip2 = iq[A_1][sj(A_1)];
			iq iq2 = p9(ip2);
			ip ip3 = ip2;
			if (!ip3.m2(iq2) || (!ip3.m2(jk, iq2) && !hb.d0().q()))
			{
				return false;
			}
			return true;
		}
		if (iq[A_1].Count > 1)
		{
			ip ip2 = iq[A_1][qh(A_1)];
			iq iq3 = p9(ip2);
			ip ip4 = ip2;
			if (!ip4.m2(iq3) || (!ip4.m2(jk, iq3) && !hb.d0().q()))
			{
				return false;
			}
			return true;
		}
		return false;
	}

	public void ti(int A_0)
	{
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			foreach (ip item in iq[num])
			{
				item.so(A_0);
			}
		}
	}

	private bool m2(global::h.f A_0)
	{
		if (vj())
		{
			global::h h10 = hb.b8();
			return A_0 switch
			{
				global::h.f.a => global::h.p(h10.a(iv)), 
				global::h.f.b => h10.a(iv) == global::h.e.c, 
				global::h.f.c => global::h.d(h10.a(iv)), 
				_ => false, 
			};
		}
		return true;
	}

	[SpecialName]
	public string m2(global::h.f A_0, bool A_1)
	{
		if (A_1 && hc.b8().a(v4(), uq()))
		{
			return @is[0].tj();
		}
		int num = iu[(int)A_0];
		checked
		{
			if (num >= 0)
			{
				int num2 = iq[num].Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (p9(hc.b8(), num3, num))
					{
						return iq[num][num3].v9();
					}
				}
			}
			return string.Empty;
		}
	}

	[SpecialName]
	public bool tg(bool A_0)
	{
		checked
		{
			if (A_0 && hc.b8().a(v4(), uq()))
			{
				int num = @is.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (!@is[num2].ti())
					{
						return false;
					}
				}
			}
			else
			{
				int upperBound = iq.GetUpperBound(0);
				for (int num3 = 0; num3 <= upperBound; num3++)
				{
					int num4 = iq[num3].Count - 1;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						if (p9(hc.b8(), num5, num3) && !iq[num3][num5].wa())
						{
							return false;
						}
					}
				}
			}
			return true;
		}
	}

	[SpecialName]
	public void sj(bool A_0, bool A_1)
	{
		if (A_0 && hc.b8().a(v4(), uq()))
		{
			p9(A_1);
			return;
		}
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			for (int num = 0; num <= upperBound; num++)
			{
				int num2 = iq[num].Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (p9(hc.b8(), num3, num))
					{
						iq[num][num3].s8(A_1);
					}
				}
			}
		}
	}

	[SpecialName]
	public bool p9(string A_0)
	{
		return iq[iu[0]][0].m2(A_0);
	}

	public bool m2(int A_0, string A_1, bool A_2)
	{
		if (A_2 && hc.b8().a(v4(), uq()))
		{
			return s4();
		}
		int num = global::h.a();
		checked
		{
			for (int num2 = 0; num2 <= num; num2++)
			{
				int num3 = iu[num2];
				if (num3 < 0 || !m2(ix[num3]) || iq[num3].Count <= 0)
				{
					continue;
				}
				int num4 = iq[num3].Count - 1;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					if (p9(hc.b8(), num5, num3) && !iq[num3][num5].m2(A_0, A_1))
					{
						return false;
					}
				}
			}
			return true;
		}
	}

	public bool qh(string A_0)
	{
		int num = global::h.a();
		checked
		{
			for (int num2 = 0; num2 <= num; num2++)
			{
				int num3 = iu[num2];
				if (num3 < 0 || m2(ix[num3]) || iq[num3].Count <= 0)
				{
					continue;
				}
				int num4 = iq[num3].Count - 1;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					if (p9(hc.b8(), num5, num3) && !iq[num3][num5].m2(0, A_0))
					{
						return false;
					}
				}
			}
			return true;
		}
	}

	[SpecialName]
	public int th(bool A_0)
	{
		if (A_0 && hb.b8().a(v4(), uq()))
		{
			return 0;
		}
		return iq[0][0].wb();
	}

	public void w7()
	{
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			foreach (ip item in iq[num])
			{
				item.wv();
			}
		}
	}

	public bool ti(bool A_0)
	{
		if (A_0 && hc.b8().a(v4(), uq()))
		{
			return s6();
		}
		int num = global::h.a();
		checked
		{
			for (int num2 = 0; num2 <= num; num2++)
			{
				int num3 = iu[num2];
				if (num3 < 0 || !m2(ix[num3]) || iq[num3].Count <= 0)
				{
					continue;
				}
				int num4 = iq[num3].Count - 1;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					if (p9(hc.b8(), num5, num3) && !iq[num3][num5].wd())
					{
						return false;
					}
				}
			}
			return true;
		}
	}

	public bool w8()
	{
		int num = global::h.a();
		checked
		{
			for (int num2 = 0; num2 <= num; num2++)
			{
				int num3 = iu[num2];
				if (num3 < 0 || iq[num3].Count <= 0)
				{
					continue;
				}
				int num4 = iq[num3].Count - 1;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					if (p9(hc.b8(), num5, num3) && iq[num3][num5].x8() && !iq[num3][num5].we())
					{
						return false;
					}
				}
			}
			return true;
		}
	}

	public bool w9()
	{
		int num = iu[1];
		checked
		{
			if (num >= 0)
			{
				int num2 = iq[num].Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (p9(hc.b8(), num3, num) && !iq[num][num3].wd())
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}
	}

	public bool tj(bool A_0)
	{
		if (A_0 && hc.b8().a(v4(), uq()))
		{
			return s3();
		}
		return xa();
	}

	public bool xa()
	{
		int num = global::h.a();
		checked
		{
			for (int num2 = 0; num2 <= num; num2++)
			{
				int num3 = iu[num2];
				if (num3 < 0 || ix[num3] == global::h.f.b || iq[num3].Count <= 0)
				{
					continue;
				}
				int num4 = iq[num3].Count - 1;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					if (p9(hb.b8(), num5, num3) && !iq[num3][num5].wn())
					{
						return false;
					}
				}
			}
			return true;
		}
	}

	public bool xb()
	{
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (ix[num] != global::h.f.b && !m2(hb.b8(), num))
			{
				return false;
			}
		}
		return true;
	}

	private bool m2(global::h A_0, int A_1)
	{
		checked
		{
			if (iq[A_1].Count > 0)
			{
				int num = iq[A_1].Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (p9(A_0, num2, A_1) && !iq[A_1][num2].s3(jk))
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}
	}

	public bool xc()
	{
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			for (int num = 0; num <= upperBound; num++)
			{
				if (ix[num] == global::h.f.b)
				{
					continue;
				}
				int num2 = iq[num].Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (p9(hc.b8(), num3, num) && !iq[num][num3].s3(jk))
					{
						return false;
					}
				}
			}
			return true;
		}
	}

	public bool s4(global::f.b A_0, int A_1)
	{
		if (A_0 == global::f.b.b)
		{
			if (!iq[A_1][sj(A_1)].s3(jk))
			{
				return false;
			}
		}
		else
		{
			if (iq[A_1].Count <= 1)
			{
				return false;
			}
			if (!iq[A_1][qh(A_1)].s3(jk))
			{
				return false;
			}
		}
		return true;
	}

	public double tl(bool A_0)
	{
		if (A_0 && hb.b8().a(v4(), uq()))
		{
			return 1000.0;
		}
		if (iq == null)
		{
			return 0.0;
		}
		double result = 0.0;
		int upperBound = iq.GetUpperBound(0);
		bool a_ = zp() == g2.a.b;
		bool A_1 = default(bool);
		bool flag = m2(A_0, ref A_1);
		int num = upperBound;
		checked
		{
			double num7 = default(double);
			for (int num2 = 0; num2 <= num; num2++)
			{
				int num3 = iq[num2].Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (p9(hb.b8(), num4, num2))
					{
						if (flag && !iq[num2][num4].zy())
						{
							double num5 = iq[num2][num4].sm(0, jk);
							int num6 = (int)Math.Round(Math.Round(iq[num2][num4].s6(a_) / num5));
							if (num6 <= 0)
							{
								num6 = 1;
							}
							if (num7 < (double)num6 * num5)
							{
								num7 = (double)num6 * num5;
							}
							return num7;
						}
						return 0.0;
					}
				}
			}
			return result;
		}
	}

	public void m2(string A_0, bool A_1)
	{
		if (A_1)
		{
			jl = A_0;
			jn = -1;
		}
		else
		{
			jm = A_0;
		}
	}

	private bool uf()
	{
		bool flag = true;
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			for (int num = 0; num <= upperBound; num++)
			{
				int num2 = iq[num].Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (!iq[num][num3].wg())
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					break;
				}
			}
			return !flag;
		}
	}

	private n[] m2(n A_0, n A_1)
	{
		return m2(A_0, A_1, A_2: false, hb.b8());
	}

	private n[] m2(n A_0, n A_1, bool A_2)
	{
		return m2(A_0, A_1, A_2, hb.b8());
	}

	private n[] m2(n A_0, n A_1, bool A_2, global::h A_3)
	{
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			n[] array = new n[upperBound + 1];
			bool flag = false;
			int num = upperBound;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (ix[num2] == global::h.f.a || ix[num2] == global::h.f.c)
				{
					if (qh(A_3, num2, A_2))
					{
						array[num2] = A_0;
						flag = true;
					}
					else
					{
						array[num2] = n.a;
					}
				}
			}
			int num3 = upperBound;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				if (ix[num4] != global::h.f.b)
				{
					continue;
				}
				if (qh(A_3, num4, A_2))
				{
					if (flag)
					{
						array[num4] = A_1;
					}
					else
					{
						array[num4] = A_0;
					}
				}
				else
				{
					array[num4] = n.a;
				}
			}
			return array;
		}
	}

	private bool[] p9(bool A_0, bool A_1)
	{
		return m2(A_0, A_1, hb.b8());
	}

	private bool[] m2(bool A_0, bool A_1, global::h A_2)
	{
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			bool[] array = new bool[upperBound + 1];
			bool flag = false;
			if (upperBound < 1)
			{
				array[0] = A_0;
			}
			else
			{
				int num = upperBound;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (ix[num2] == global::h.f.a || ix[num2] == global::h.f.c)
					{
						array[num2] = A_0;
						if (sn(A_2, num2))
						{
							flag = true;
						}
					}
				}
				int num3 = upperBound;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (ix[num4] == global::h.f.b)
					{
						if (flag)
						{
							array[num4] = A_1;
						}
						else
						{
							array[num4] = A_0;
						}
					}
				}
			}
			return array;
		}
	}

	private void m2(ref float A_0, ref float A_1)
	{
		m2(ref A_0, ref A_1, hc);
	}

	private void m2(ref float A_0, ref float A_1, hg A_2)
	{
		hi hi2 = A_2.ed();
		if (hi2.ft())
		{
			A_0 = (float)hi2.fs();
			A_1 = (float)hi2.fr();
		}
		else
		{
			A_2.bu(ref A_0, ref A_1);
		}
		hi2 = null;
	}

	private void m2(double[] A_0, ref float A_1, ref float A_2)
	{
		m2(ref A_1, ref A_2);
		A_1 = Math.Max(A_1, (float)A_0[0]);
		A_2 = Math.Min(A_2, (float)A_0[A_0.GetUpperBound(0)]);
	}

	public void m2(string A_0, string A_1, global::r.d A_2, l A_3, int A_4, global::r.d.a.b A_5)
	{
		if (!hb.b8().a(v4(), uq()) && !hb.b8().av())
		{
			return;
		}
		t t2 = null;
		float num = hc.b8().at();
		if (A_3 != null)
		{
			t2 = new t(A_5);
			t obj = t2;
			((m)obj).a = m.a.q;
			obj.d = m.TaskExecutionType.Execution;
			obj.cf = num;
			obj.g = new global::r.d();
			obj.h = ji;
			obj.l = A_3;
			_ = null;
		}
		s s2 = new s(A_5);
		((m)s2).a = m.a.ao;
		s2.d = m.TaskExecutionType.Setup;
		s2.g = new global::r.d();
		s2.b3 = A_0;
		s2.b4 = A_1;
		_ = null;
		string A_6 = null;
		string A_7 = null;
		ErrPublic errPublic = m2(ref A_6, ref A_7, s2);
		if (errPublic != ErrPublic.None)
		{
			int num2 = (int)errPublic;
			throw new ApplicationException("Error in MeasModuleSpec.AttemptAcquireVsTimeData setupTask. Error code=" + num2);
		}
		if (hb.b8().av())
		{
			A_7 = null;
			m2(A_0, A_1, "", ref A_7, A_2, A_3, A_6: true, A_4, A_5, null, A_10: false, A_11: true, h6.b.b);
		}
		else
		{
			w w2 = new w(A_5);
			((m)w2).a = m.a.ap;
			w2.d = m.TaskExecutionType.Photodiode;
			w2.cw = v.e;
			w2.g = A_2;
			w2.l = A_3;
			w2.c1 = A_0;
			w2.c2 = A_1;
			_ = null;
			A_7 = null;
			A_6 = null;
			errPublic = m2(ref A_7, ref A_6, w2);
			if (errPublic != ErrPublic.None)
			{
				int num2 = (int)errPublic;
				throw new ApplicationException("Error in MeasModuleSpec.AttemptAcquireVsTimeData. Error code=" + num2);
			}
		}
		if (t2 != null)
		{
			A_6 = null;
			A_7 = null;
			errPublic = m2(ref A_6, ref A_7, t2);
			if (errPublic != ErrPublic.None)
			{
				int num2 = (int)errPublic;
				throw new ApplicationException("Error in Delaytask MeasModuleSpec.AttemptAcquireVsTimeData delay task. Error code=" + num2);
			}
		}
	}

	public void p9(global::r.d A_0, global::r.d.a.b A_1)
	{
		s s2 = new s(A_1);
		((m)s2).a = m.a.al;
		s2.d = m.TaskExecutionType.Setup;
		s2.g = A_0;
		_ = null;
		string A_2 = null;
		string A_3 = null;
		ErrPublic errPublic = m2(ref A_2, ref A_3, s2);
		if (errPublic != ErrPublic.None)
		{
			int num = (int)errPublic;
			throw new ApplicationException("Error in MeasModuleSpec.AttemptClearVsTimeData. Error code=" + num);
		}
	}

	public void qh(global::r.d A_0, global::r.d.a.b A_1)
	{
		s s2 = new s(A_1);
		((m)s2).a = m.a.am;
		s2.d = m.TaskExecutionType.Setup;
		s2.g = A_0;
		_ = null;
		string A_2 = null;
		string A_3 = null;
		ErrPublic errPublic = m2(ref A_2, ref A_3, s2);
		if (errPublic != ErrPublic.None)
		{
			int num = (int)errPublic;
			throw new ApplicationException("Error in MeasModuleSpec.AttemptClearVsTimeData. Error code=" + num);
		}
	}

	public void m2(string A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		s s2 = new s(A_2);
		((m)s2).a = m.a.an;
		s2.b7 = A_0;
		s2.d = m.TaskExecutionType.Setup;
		s2.g = A_1;
		_ = null;
		string A_3 = null;
		string A_4 = null;
		ErrPublic errPublic = m2(ref A_3, ref A_4, s2);
		if (errPublic != ErrPublic.None)
		{
			int num = (int)errPublic;
			throw new ApplicationException("Error in MeasModuleSpec.AttemptClearVsTimeData. Error code=" + num);
		}
	}

	public void m2(jf.a A_0, long A_1, global::r.d A_2, global::r.d.a.b A_3)
	{
		s s2 = new s(A_3);
		((m)s2).a = m.a.aq;
		s2.d = m.TaskExecutionType.Setup;
		s2.b8 = A_0;
		s2.b9 = A_1;
		s2.g = A_2;
		_ = null;
		string A_4 = null;
		string A_5 = null;
		ErrPublic errPublic = m2(ref A_4, ref A_5, s2);
		if (errPublic != ErrPublic.None)
		{
			int num = (int)errPublic;
			throw new ApplicationException("Error in MeasModuleSpec.AttemptAnalyzeVsTimeData. Error code=" + num);
		}
	}

	public void m2(jf.a A_0, long A_1, bool A_2, global::r.d A_3, global::r.d.a.b A_4)
	{
		s s2 = new s(A_4);
		((m)s2).a = m.a.ar;
		s2.d = m.TaskExecutionType.Setup;
		s2.b8 = A_0;
		s2.b9 = A_1;
		s2.ca = A_2;
		s2.g = A_3;
		_ = null;
		string A_5 = null;
		string A_6 = null;
		ErrPublic errPublic = m2(ref A_5, ref A_6, s2);
		if (errPublic != ErrPublic.None)
		{
			int num = (int)errPublic;
			throw new ApplicationException("Error in MeasModuleSpec.AttemptAnalyzeVirtInterface. Error code=" + num);
		}
	}

	public void m2(string A_0, string A_1, global::r.d A_2, l A_3, bool A_4, int A_5, short A_6, global::r.d.a.b A_7, bool A_8, bool A_9, bool A_10)
	{
		if (g2.d(zp()))
		{
			hf.Clear();
			i8.Clear();
		}
		t t2 = null;
		float num = hc.b8().at();
		if (A_3 != null)
		{
			t2 = new t(A_7);
			t obj = t2;
			((m)obj).a = m.a.q;
			obj.d = m.TaskExecutionType.Execution;
			obj.cf = num;
			obj.g = new global::r.d();
			obj.h = ji;
			obj.l = A_3;
			_ = null;
		}
		p p2 = new p(u1(), A_7);
		((m)p2).a = m.a.c;
		p2.d = m.TaskExecutionType.Spectrometer;
		p2.n = m2(n.b, n.b);
		p2.g = A_2;
		p2.l = A_3;
		p2.v = A_0;
		p2.w = A_1;
		p2.ac = A_4;
		p2.af = A_9;
		p2.ag = A_10;
		p2.ah = A_5;
		p2.ai = A_6;
		p2.h = ja;
		p2.am = t2;
		p2.s = A_8;
		_ = null;
		jl = string.Empty;
		string A_11 = null;
		string A_12 = null;
		ErrPublic errPublic = m2(ref A_11, ref A_12, p2);
		if (errPublic != ErrPublic.None)
		{
			int num2 = (int)errPublic;
			throw new ApplicationException("Error in MeasModuleSpec.AttemptAcquireAndMeasureSpectrum. Error code=" + num2);
		}
		if (t2 != null)
		{
			A_12 = null;
			A_11 = null;
			errPublic = m2(ref A_12, ref A_11, t2);
			if (errPublic != ErrPublic.None)
			{
				int num2 = (int)errPublic;
				throw new ApplicationException("Error in Delaytask MeasModuleSpec.AttemptAcquireAndMeasureSpectrum. Error code=" + num2);
			}
		}
	}

	public void m2(string A_0, string A_1, global::r.d A_2, int A_3, int A_4, string A_5, bool A_6, bool A_7, bool A_8, int A_9, l A_10, global::r.d.a.b A_11)
	{
		m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, m.a.d, 0, A_9, A_10, A_11);
	}

	public void m2(string A_0, string A_1, global::r.d A_2, int A_3, int A_4, string A_5, bool A_6, bool A_7, bool A_8, short A_9, int A_10, l A_11, global::r.d.a.b A_12)
	{
		l a_ = null;
		if (hb.b8().at() > 0f)
		{
			a_ = A_11;
		}
		if (g2.d(zp()))
		{
			throw new ApplicationException("AutoMeasure is incompatible with batch measure");
		}
		m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, m.a.e, A_9, A_10, a_, A_12);
	}

	public void m2(string[] A_0, global::r.d A_1, short A_2, a6 A_3, string A_4, global::r.d.a.b A_5)
	{
		string A_6 = null;
		string A_7 = null;
		ErrPublic errPublic = default(ErrPublic);
		if (m2(ref A_6, ref A_7, A_2: false, null) != ErrPublic.None)
		{
			int num = (int)errPublic;
			throw new ApplicationException("Error in MeasModuleSpec.AttemptBatchAnalyze abort attempt. Error code=" + num);
		}
		r r2 = new r(A_5);
		((m)r2).a = m.a.i;
		r2.d = m.TaskExecutionType.MeasEngine;
		r2.g = A_1;
		r2.bo = A_0;
		r2.bp = A_4;
		r2.br = A_2;
		r2.bj = true;
		r2.bt = A_3;
		_ = null;
		jj.m = A_0.Length;
		jj.t(1);
		jj.a = false;
		A_7 = null;
		A_6 = null;
		errPublic = m2(ref A_7, ref A_6, r2);
		if (errPublic != ErrPublic.None)
		{
			int num = (int)errPublic;
			throw new ApplicationException("Error in MeasModuleSpec.AttemptBatchAnalyze. Error code=" + num);
		}
	}

	private void m2(string A_0, string A_1, global::r.d A_2, int A_3, int A_4, string A_5, bool A_6, bool A_7, bool A_8, m.a A_9, short A_10, int A_11, l A_12, global::r.d.a.b A_13)
	{
		t A_14 = null;
		p A_15 = new p(u1(), A_13);
		m2(ref A_15, ref A_14, A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10, A_11, A_12, A_13);
		string A_16 = null;
		string A_17 = null;
		ErrPublic errPublic = m2(ref A_16, ref A_17, A_15);
		if (errPublic != ErrPublic.None)
		{
			int num = (int)errPublic;
			throw new ApplicationException("Error in MeasModuleSpec.AttemptBatchProcess. Error code=" + num);
		}
		if (A_14 != null)
		{
			A_17 = null;
			A_16 = null;
			errPublic = m2(ref A_17, ref A_16, A_14);
			if (errPublic != ErrPublic.None)
			{
				int num = (int)errPublic;
				throw new ApplicationException("Error in Delaytask MeasModuleSpec.AttemptBatchProcess. Error code=" + num);
			}
		}
	}

	private void m2(ref p A_0, ref t A_1, string A_2, string A_3, global::r.d A_4, int A_5, int A_6, string A_7, bool A_8, bool A_9, bool A_10, m.a A_11, short A_12, int A_13, l A_14, global::r.d.a.b A_15)
	{
		p p2 = A_0;
		((m)p2).a = A_11;
		p2.d = m.TaskExecutionType.Spectrometer;
		p2.ac = true;
		p2.u = A_13;
		switch (A_11)
		{
		case m.a.d:
			p2.n = m2(n.i, n.i, uf());
			break;
		case m.a.e:
			p2.n = m2(n.b, n.b);
			break;
		}
		float num = hb.b8().at();
		if (num > 0f)
		{
			A_1 = new t(A_15);
			t obj = A_1;
			((m)obj).a = m.a.q;
			obj.d = m.TaskExecutionType.Execution;
			obj.cf = num;
			obj.g = new global::r.d();
			obj.h = ji;
			obj.l = A_14;
			_ = null;
			p2.l = A_14;
		}
		p2.am = A_1;
		p2.s = true;
		p2.g = A_4;
		p2.v = A_2;
		p2.w = A_3;
		p2.ah = A_5;
		p2.ai = A_12;
		p2.h = ja;
		p2.ap = checked(A_6 - 1);
		p2.t = A_6;
		p2.aq = A_7;
		p2.ar = A_8;
		p2.@as = A_9;
		p2.at = A_10;
		p2 = null;
		jj.a = false;
		jj.m = A_6;
		jj.t(1);
		jl = string.Empty;
	}

	public void m2(d4.c A_0)
	{
		if (l2 != null)
		{
			l2.r(A_0);
		}
	}

	public d4.a xd()
	{
		if (l2 != null)
		{
			return l2.ab();
		}
		return null;
	}

	public void tj(int A_0)
	{
		u u2 = new u(global::r.d.a.b.a);
		u2.cg = u.CameraVideoTaskType.SetFocus;
		u2.d = m.TaskExecutionType.VideoCamera;
		u2.ch = A_0;
		string A_1 = null;
		string A_2 = null;
		m2(ref A_1, ref A_2, u2);
	}

	public void m2(int A_0, float A_1, float A_2)
	{
		u u2 = new u(global::r.d.a.b.a);
		u2.cg = u.CameraVideoTaskType.SetZoom;
		u2.d = m.TaskExecutionType.VideoCamera;
		u2.ci = A_0;
		u2.cj = A_1;
		u2.ck = A_2;
		string A_3 = null;
		string A_4 = null;
		m2(ref A_3, ref A_4, u2);
	}

	public void m2(float A_0, float A_1, ScrollOrientation A_2)
	{
		u u2 = new u(global::r.d.a.b.a);
		u2.cg = u.CameraVideoTaskType.SetScroll;
		u2.d = m.TaskExecutionType.VideoCamera;
		u2.cj = A_0;
		u2.ck = A_1;
		u2.cn = A_2;
		string A_3 = null;
		string A_4 = null;
		m2(ref A_3, ref A_4, u2);
	}

	public void m2(IntPtr A_0, global::r.d A_1, global::r.d.a.b A_2, string A_3)
	{
		u u2 = new u(A_2);
		u2.cg = u.CameraVideoTaskType.InitCamera;
		u2.d = m.TaskExecutionType.VideoCamera;
		u2.cl = A_0;
		u2.g = A_1;
		u2.cr = A_3;
		string A_4 = null;
		string A_5 = null;
		m2(ref A_4, ref A_5, u2);
	}

	public void sj(global::r.d A_0, global::r.d.a.b A_1)
	{
		u u2 = new u(A_1);
		u2.cg = u.CameraVideoTaskType.ReinitCamera;
		u2.d = m.TaskExecutionType.VideoCamera;
		u2.g = A_0;
		string A_2 = null;
		string A_3 = null;
		m2(ref A_2, ref A_3, u2);
	}

	public void sm(global::r.d A_0, global::r.d.a.b A_1)
	{
		u u2 = new u(A_1);
		u2.cg = u.CameraVideoTaskType.TestCanRunVideo;
		u2.d = m.TaskExecutionType.VideoCamera;
		u2.g = A_0;
		string A_2 = null;
		string A_3 = null;
		m2(ref A_2, ref A_3, u2);
	}

	public void m2(bool A_0, l A_1, global::r.d.a.b A_2)
	{
		u u2 = new u(A_2);
		u2.d = m.TaskExecutionType.VideoCamera;
		u2.cg = u.CameraVideoTaskType.ContinuousImage;
		u2.l = A_1;
		u2.j = A_0;
		_ = null;
		string A_3 = null;
		string A_4 = null;
		m2(ref A_3, ref A_4, u2);
	}

	public void m2(global::r.d.a.b A_0, global::r.d A_1, AutoResetEvent A_2 = null)
	{
		u u2 = new u(A_0);
		u2.cg = u.CameraVideoTaskType.DeAllocation;
		u2.d = m.TaskExecutionType.VideoCamera;
		u2.j = A_2;
		u2.g = A_1;
		string A_3 = null;
		string A_4 = null;
		m2(ref A_3, ref A_4, u2);
	}

	public void p9(bool A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		u u2 = new u(A_2);
		u2.cg = u.CameraVideoTaskType.StartVideo;
		u2.d = m.TaskExecutionType.VideoCamera;
		u2.cm = A_0;
		u2.g = A_1;
		string A_3 = null;
		string A_4 = null;
		m2(ref A_3, ref A_4, u2);
	}

	public void sn(global::r.d A_0, global::r.d.a.b A_1)
	{
		u u2 = new u(A_1);
		u2.cg = u.CameraVideoTaskType.StopVideo;
		u2.d = m.TaskExecutionType.VideoCamera;
		u2.g = A_0;
		string A_2 = null;
		string A_3 = null;
		m2(ref A_2, ref A_3, u2);
	}

	public void m2(bool A_0, int A_1, ej.b A_2)
	{
		u u2 = new u(global::r.d.a.b.a);
		u2.cg = u.CameraVideoTaskType.SettingsFromDialog;
		u2.d = m.TaskExecutionType.VideoCamera;
		u2.cm = A_0;
		u2.co = A_2;
		u2.ch = A_1;
		string A_3 = null;
		string A_4 = null;
		m2(ref A_3, ref A_4, u2);
	}

	public void m2(global::r.d A_0)
	{
		u u2 = new u(global::r.d.a.b.a);
		u2.cg = u.CameraVideoTaskType.CalibrateSpot;
		u2.d = m.TaskExecutionType.VideoCamera;
		u2.g = A_0;
		string A_1 = null;
		string A_2 = null;
		m2(ref A_1, ref A_2, u2);
	}

	public void p9(int A_0, int A_1, int A_2)
	{
		u u2 = new u(global::r.d.a.b.a);
		u2.cg = u.CameraVideoTaskType.ConfigVideoSettingFromUI;
		u2.d = m.TaskExecutionType.VideoCamera;
		u2.cp = A_0;
		u2.cq = A_1;
		u2.ci = A_2;
		string A_3 = null;
		string A_4 = null;
		m2(ref A_3, ref A_4, u2);
	}

	public void m2(double A_0, global::r.d.a.b A_1, global::r.d A_2)
	{
		y y2 = new y(A_1);
		y2.d = m.TaskExecutionType.ScatterBox;
		((m)y2).a = m.a.bn;
		y2.g = A_2;
		y2.c3 = A_0;
		_ = null;
		string A_3 = null;
		string A_4 = null;
		m2(ref A_3, ref A_4, y2);
	}

	public void m2(FiberMuxChannel A_0, global::r.d.a.b A_1, global::r.d A_2)
	{
		y y2 = new y(A_1);
		y2.d = m.TaskExecutionType.ScatterBox;
		((m)y2).a = m.a.bo;
		y2.g = A_2;
		y2.c4 = A_0;
		_ = null;
		string A_3 = null;
		string A_4 = null;
		m2(ref A_3, ref A_4, y2);
	}

	public void m2(global::r.d.a.b A_0, global::r.d A_1)
	{
		y y2 = new y(A_0);
		y2.d = m.TaskExecutionType.ScatterBox;
		((m)y2).a = m.a.bp;
		y2.g = A_1;
		_ = null;
		string A_2 = null;
		string A_3 = null;
		m2(ref A_2, ref A_3, y2);
	}

	public void p9(global::r.d.a.b A_0, global::r.d A_1)
	{
		y y2 = new y(A_0);
		y2.d = m.TaskExecutionType.ScatterBox;
		((m)y2).a = m.a.bq;
		y2.g = A_1;
		_ = null;
		string A_2 = null;
		string A_3 = null;
		m2(ref A_2, ref A_3, y2);
	}

	public void m2(ip.m A_0, global::r.d.a.b A_1, global::r.d A_2)
	{
		m m2 = new m(A_1);
		m2.d = m.TaskExecutionType.SpectrometerTestAndCal;
		m2.a = m.a.ab;
		m2.g = A_2;
		m2.j = A_0;
		_ = null;
		string A_3 = null;
		string A_4 = null;
		this.m2(ref A_3, ref A_4, m2);
	}

	public void m2(ip.i A_0, bool A_1, bool A_2, global::r.d.a.b A_3, global::r.d A_4, global::r.c A_5)
	{
		m m2 = new m(A_3);
		m m3 = m2;
		m3.d = m.TaskExecutionType.SpectrometerTestAndCal;
		if (A_1)
		{
			m3.h = A_5;
			if (A_2)
			{
				m3.a = m.a.bm;
			}
			else
			{
				m3.a = m.a.bh;
			}
		}
		else
		{
			m3.a = m.a.y;
		}
		m3.g = A_4;
		m3.j = A_0;
		m3 = null;
		string A_6 = null;
		string A_7 = null;
		this.m2(ref A_6, ref A_7, m2);
	}

	public void m2(ip.j A_0, global::r.d.a.b A_1, global::r.d A_2)
	{
		m m2 = new m(A_1);
		m2.d = m.TaskExecutionType.SpectrometerTestAndCal;
		m2.a = m.a.z;
		m2.g = A_2;
		m2.j = A_0;
		_ = null;
		string A_3 = null;
		string A_4 = null;
		this.m2(ref A_3, ref A_4, m2);
	}

	public void m2(ip.h A_0, global::r.d.a.b A_1, global::r.d A_2)
	{
		m m2 = new m(A_1);
		m2.d = m.TaskExecutionType.SpectrometerTestAndCal;
		m2.a = m.a.@as;
		m2.g = A_2;
		m2.j = A_0;
		_ = null;
		string A_3 = null;
		string A_4 = null;
		this.m2(ref A_3, ref A_4, m2);
	}

	public void p9(ip.h A_0, global::r.d.a.b A_1, global::r.d A_2)
	{
		m m2 = new m(A_1);
		m2.d = m.TaskExecutionType.SpectrometerTestAndCal;
		m2.a = m.a.ac;
		m2.g = A_2;
		m2.j = A_0;
		_ = null;
		string A_3 = null;
		string A_4 = null;
		this.m2(ref A_3, ref A_4, m2);
	}

	public void qh(ip.h A_0, global::r.d.a.b A_1, global::r.d A_2)
	{
		m m2 = new m(A_1);
		m2.d = m.TaskExecutionType.SpectrometerTestAndCal;
		m2.a = m.a.be;
		m2.g = A_2;
		m2.j = A_0;
		_ = null;
		string A_3 = null;
		string A_4 = null;
		this.m2(ref A_3, ref A_4, m2);
	}

	public void m2(@in.b A_0, int A_1, global::r.d A_2)
	{
		z2();
		w w2 = new w(global::r.d.a.b.a);
		w2.d = m.TaskExecutionType.Photodiode;
		((m)w2).a = m.a.ag;
		w2.g = A_2;
		w2.cz = A_0;
		w2.c0 = A_1;
		_ = null;
		string A_3 = null;
		string A_4 = null;
		m2(ref A_3, ref A_4, w2);
	}

	public void m2(ip.d A_0, h6.b A_1, int A_2, int A_3, global::r.d A_4)
	{
		z2();
		q q2 = new q(global::r.d.a.b.a);
		q q3 = q2;
		q3.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q3).a = m.a.s;
		q3.g = A_4;
		q3.a8 = A_0;
		q3.bi = A_1;
		if (A_1 == h6.b.b)
		{
			q3.a6 = A_2;
			q3.a7 = so(A_2, A_3);
		}
		q3 = null;
		string A_5 = null;
		string A_6 = null;
		m2(ref A_5, ref A_6, q2);
	}

	public void m2(h6.b A_0, int A_1, int A_2, float A_3, global::r.d A_4)
	{
		q q2 = new q(global::r.d.a.b.a);
		q q3 = q2;
		q3.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q3).a = m.a.au;
		q3.g = A_4;
		q3.j = A_3;
		q3.bi = A_0;
		if (A_0 == h6.b.b)
		{
			q3.a6 = A_1;
			q3.a7 = so(A_1, A_2);
		}
		q3 = null;
		string A_5 = null;
		string A_6 = null;
		m2(ref A_5, ref A_6, q2);
	}

	public void m2(h6.b A_0, int A_1, int A_2, global::r.d A_3)
	{
		q q2 = new q(global::r.d.a.b.a);
		q q3 = q2;
		q3.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q3).a = m.a.av;
		q3.g = A_3;
		q3.bi = A_0;
		if (A_0 == h6.b.b)
		{
			q3.a6 = A_1;
			q3.a7 = so(A_1, A_2);
		}
		q3 = null;
		string A_4 = null;
		string A_5 = null;
		m2(ref A_4, ref A_5, q2);
	}

	public void p9(h6.b A_0, int A_1, int A_2, global::r.d A_3)
	{
		q q2 = new q(global::r.d.a.b.a);
		q q3 = q2;
		q3.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q3).a = m.a.bi;
		q3.g = A_3;
		q3.bi = A_0;
		if (A_0 == h6.b.b)
		{
			q3.a6 = A_1;
			q3.a7 = so(A_1, A_2);
		}
		q3 = null;
		string A_4 = null;
		string A_5 = null;
		m2(ref A_4, ref A_5, q2);
	}

	public void sj(h6.b A_0, int A_1, int A_2)
	{
		p9(A_0, A_1, A_2)?.up();
	}

	[SpecialName]
	public float so(h6.b A_0, int A_1, global::f.b A_2)
	{
		return m2(A_0, A_1, A_2)?.uo() ?? 0f;
	}

	public void m2(h6.b A_0, int A_1, global::f.b A_2, float A_3, global::r.d A_4)
	{
		q q2 = new q(global::r.d.a.b.a);
		q q3 = q2;
		q3.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q3).a = m.a.bj;
		q3.g = A_4;
		q3.bi = A_0;
		if (A_0 == h6.b.b)
		{
			q3.a6 = A_1;
			q3.a7 = A_2;
		}
		q3.j = A_3;
		q3 = null;
		string A_5 = null;
		string A_6 = null;
		m2(ref A_5, ref A_6, q2);
	}

	public void m2(h6.b A_0, int A_1, global::f.b A_2, global::r.d A_3)
	{
		q q2 = new q(global::r.d.a.b.a);
		q q3 = q2;
		q3.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q3).a = m.a.aw;
		q3.g = A_3;
		q3.bi = A_0;
		if (A_0 == h6.b.b)
		{
			q3.a6 = A_1;
			q3.a7 = A_2;
		}
		q3 = null;
		string A_4 = null;
		string A_5 = null;
		m2(ref A_4, ref A_5, q2);
	}

	public void m2(Collection<ip.d>[] A_0, global::r.d A_1)
	{
		if (iq == null)
		{
			return;
		}
		q q2 = new q(global::r.d.a.b.a);
		checked
		{
			Collection<ip.d>[] array = new Collection<ip.d>[A_0.Length - 1 + 1];
			int num = A_0.Length - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				Collection<ip.d> collection = new Collection<ip.d>();
				foreach (ip.d item in A_0[num2])
				{
					collection.Add(item);
				}
				array[num2] = collection;
			}
			q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
			((m)q2).a = m.a.bl;
			q2.g = A_1;
			q2.j = array;
			_ = null;
			string A_2 = null;
			string A_3 = null;
			m2(ref A_2, ref A_3, q2);
		}
	}

	public void p9(global::r.d A_0)
	{
		q q2 = new q(global::r.d.a.b.a);
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q2).a = m.a.a3;
		q2.g = A_0;
		_ = null;
		string A_1 = null;
		string A_2 = null;
		m2(ref A_1, ref A_2, q2);
	}

	public void qh(h6.b A_0, int A_1, int A_2, global::r.d A_3)
	{
		q q2 = new q(global::r.d.a.b.a);
		q q3 = q2;
		q3.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q3).a = m.a.ah;
		q3.g = A_3;
		q3.bi = A_0;
		if (A_0 == h6.b.b)
		{
			q3.a6 = A_1;
			q3.a7 = so(A_1, A_2);
		}
		q3 = null;
		string A_4 = null;
		string A_5 = null;
		m2(ref A_4, ref A_5, q2);
	}

	public void sj(h6.b A_0, int A_1, int A_2, global::r.d A_3)
	{
		q q2 = new q(global::r.d.a.b.a);
		q q3 = q2;
		q3.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q3).a = m.a.ai;
		q3.g = A_3;
		q3.bi = A_0;
		if (A_0 == h6.b.b)
		{
			q3.a6 = A_1;
			q3.a7 = so(A_1, A_2);
		}
		q3 = null;
		string A_4 = null;
		string A_5 = null;
		m2(ref A_4, ref A_5, q2);
	}

	public void m2(h6.b A_0, int A_1, int A_2, Collection<cf> A_3, bool A_4, global::r.d A_5)
	{
		q q2 = new q(global::r.d.a.b.a);
		q q3 = q2;
		q3.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q3).a = m.a.aj;
		q3.g = A_5;
		q3.bi = A_0;
		if (A_0 == h6.b.b)
		{
			q3.a6 = A_1;
			q3.a7 = so(A_1, A_2);
		}
		q3.bc = A_3;
		q3.bd = A_4;
		q3 = null;
		string A_6 = null;
		string A_7 = null;
		m2(ref A_6, ref A_7, q2);
	}

	public void m2(bool A_0, bool A_1, global::r.d A_2)
	{
		b b10 = ((A_0 && A_1) ? b.d : (A_0 ? b.b : (A_1 ? b.c : b.a)));
		if (b10 != b.a)
		{
			q q2 = new q(global::r.d.a.b.a);
			q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
			((m)q2).a = m.a.bk;
			q2.g = A_2;
			q2.j = b10;
			_ = null;
			string A_3 = null;
			string A_4 = null;
			m2(ref A_3, ref A_4, q2);
		}
	}

	public void m2(h6.c A_0, h6.b A_1, int A_2, global::r.d A_3)
	{
		z2();
		q q2 = new q(global::r.d.a.b.a);
		q q3 = q2;
		q3.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q3).a = m.a.ae;
		q3.g = A_3;
		q3.a8 = A_0;
		q3.bi = A_1;
		if (A_1 == h6.b.b)
		{
			q3.a6 = A_2;
		}
		q3 = null;
		string A_4 = null;
		string A_5 = null;
		m2(ref A_4, ref A_5, q2);
	}

	public void m2(int A_0, global::f.b A_1, global::r.d.a.b A_2, global::r.d A_3)
	{
		m m2 = new m(A_2);
		m2.d = m.TaskExecutionType.SpectrometerTestAndCal;
		m2.a = m.a.ad;
		m2.g = A_3;
		m2.j = new ip.h
		{
			a = A_0,
			b = p9(A_0, A_1)
		};
		_ = null;
		string A_4 = null;
		string A_5 = null;
		this.m2(ref A_4, ref A_5, m2);
	}

	public void m2(int A_0, float A_1, global::r.c A_2, global::r.d A_3, global::r.d.a.b A_4)
	{
		q q2 = new q(A_4);
		((m)q2).a = m.a.bu;
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		q2.h = A_2;
		q2.g = A_3;
		q2.j = new d(A_0, A_1);
		_ = null;
		string A_5 = null;
		string A_6 = null;
		m2(ref A_5, ref A_6, q2);
	}

	public void so(global::r.d A_0, global::r.d.a.b A_1)
	{
		q q2 = new q(A_1);
		((m)q2).a = m.a.bv;
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		q2.g = A_0;
		_ = null;
		string A_2 = null;
		string A_3 = null;
		m2(ref A_2, ref A_3, q2);
	}

	public void m2(global::r.d A_0, d4.e A_1, global::r.d.a.b A_2)
	{
		u u2 = new u(A_2);
		u2.cg = u.CameraVideoTaskType.ChangeVideoImageRotation;
		u2.d = m.TaskExecutionType.VideoCamera;
		u2.cs = A_1;
		u2.g = A_0;
		string A_3 = null;
		string A_4 = null;
		m2(ref A_3, ref A_4, u2);
	}

	private void m2(p A_0, global::r.d.a A_1, bool A_2, h.a A_3, bool A_4, hg A_5, ref hc A_6, ref ErrPublic A_7, ref string A_8, ref bool A_9)
	{
		i.b b10 = null;
		long a_ = default(long);
		if (A_0.g != null)
		{
			a_ = A_0.g.d();
		}
		string A_10 = "";
		try
		{
			A_1.a = global::r.d.a.a.b;
			A_9 = false;
			p p2 = A_0;
			b10 = new i.b(A_0.d3(), a_);
			b10.h = gt;
			if (A_3.z != null)
			{
				b10.ab = A_3.z;
				b10.af = A_4;
				b10.ad = global::r.i.a.a;
				if (A_2)
				{
					A_0.i = true;
					j7 = false;
				}
				jb.d(gt, b10);
				A_9 = true;
			}
			else
			{
				ErrPublic errPublic = m2(A_3.w, zj(), ref hg, A_3.aa, p2.d3(), A_5: true, p2.ai, ref A_10);
				m2(A_5, errPublic, A_10, ref A_6, ref A_7, ref A_8);
				if (errPublic == ErrPublic.None && g2.d(he.c()))
				{
					if (i8.Count > 500)
					{
						i8.RemoveAt(0);
					}
					i8.Add(hg);
				}
				if (A_2)
				{
					A_0.i = true;
					j7 = false;
				}
				m2(errPublic, A_0.d3(), A_2: false, A_4, A_1, A_10, ref A_9, A_7: false);
			}
			p2 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			ab8().c(fz.b.b, "Exception Thrown in MeasModuleSpec.MeasureAcquiredSpectrum()", a_2);
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	public bool xe()
	{
		if (j7 && !hd)
		{
			return Operators.CompareString(j9, hb.cl(), TextCompare: false) == 0;
		}
		return false;
	}

	public ErrPublic m2(ref string A_0, ref string A_1, bool A_2, string A_3)
	{
		try
		{
			if (kc)
			{
				kd = true;
			}
			if (hi.so())
			{
				k4 = A_2;
				k5 = A_3;
				hi.st();
				if (!Monitor.TryEnter(hi, 1000))
				{
					ab8().c(fz.b.b, "Unable to obtain lock on MeasEngine in AbortSolving");
					return ErrPublic.SolvingAbortFailure;
				}
				Monitor.Exit(hi);
			}
		}
		finally
		{
			hi.s4();
		}
		return ErrPublic.None;
	}

	public void xf()
	{
		jj.a = true;
	}

	public ErrPublic xg()
	{
		if (hi.so())
		{
			hi.s3();
		}
		return ErrPublic.None;
	}

	private void m2(hr A_0, float A_1)
	{
		A_0.r(A_0.cu().l(A_1));
		A_0.r(A_0.cu().i(global::hl.a));
	}

	private ErrPublic m2(r A_0, double[] A_1, int A_2, bool A_3, bool A_4, bool A_5, float A_6, double[] A_7)
	{
		string A_8 = "";
		checked
		{
			double[] array = new double[A_1.GetUpperBound(0) + 1];
			double[] array2 = null;
			ErrPublic errPublic = ErrPublic.None;
			bool flag = false;
			bool flag2 = false;
			try
			{
				r r2 = A_0;
				if (A_7 != null)
				{
					array2 = new double[A_7.GetUpperBound(0) + 1];
				}
				global::h.f f10;
				hr.b a_;
				double[] a_2;
				double[] a_3;
				if (A_3)
				{
					f10 = global::h.f.a;
					flag = A_4;
					flag2 = A_5;
					a_ = hr.b.c;
					a_2 = A_1;
					a_3 = array;
				}
				else if (A_5)
				{
					f10 = global::h.f.c;
					flag = A_4;
					a_ = hr.b.c;
					if (flag)
					{
						a_2 = A_7;
						a_3 = array2;
					}
					else
					{
						a_2 = A_1;
						a_3 = array;
					}
				}
				else
				{
					f10 = global::h.f.b;
					a_ = hr.b.j;
					a_2 = A_1;
					a_3 = array;
				}
				DateTime now = DateTime.Now;
				r2.bm = new hr(a_2, Guid.NewGuid(), a_3, a_, 0f, 1, FMLegacyAllSystemTypes.kTypeF20, ew.a.a, "Generated", now, "", "Simulation", hr.a.e, 0, 0f, 0f, null, null, "", A_19: false, A_20: false, A_21: false, 0, 0, null, 0, string.Empty, null);
				r2.bm.r(A_0.bt);
				if (f10 == global::h.f.c)
				{
					m2(r2.bm, A_6);
				}
				if (flag)
				{
					r2.bm.r(new hr(A_1, Guid.NewGuid(), array, hr.b.j, 0f, 1, FMLegacyAllSystemTypes.kTypeF20, ew.a.a, "Generated", now, "", "Simulation", hr.a.e, 0, 0f, 0f, null, null, "", A_19: false, A_20: false, A_21: false, 0, 0, null, 0, string.Empty, null));
					r2.bm.bl().r(A_0.bt);
				}
				if (flag2)
				{
					hr a_4 = new hr(A_7, Guid.NewGuid(), array2, hr.b.c, 0f, 1, FMLegacyAllSystemTypes.kTypeF20, ew.a.a, "Generated", now, "", "Simulation", hr.a.e, 0, 0f, 0f, null, null, "", A_19: false, A_20: false, A_21: false, 0, 0, null, 0, string.Empty, null);
					r2.bm.r((fy)a_4);
					r2.bm.bm()[0].r(A_0.bt);
					m2(r2.bm.bm()[0], A_6);
				}
				ErrPublic num = m2(r2.bm, zj(), A_2, ref hg, A_4: false, r2.d3(), r2.br, ref A_8);
				if (num == ErrPublic.None)
				{
					r2.bm.t(hg.cs().cz());
					r2.bm.af(hg.cs().c0());
					r2.bm.r(hg.cs().c0());
					if (flag)
					{
						r2.bm.bl().t(hg.cs().c3().cz());
						r2.bm.bl().af(hg.cs().c3().c0());
						r2.bm.bl().r(hg.cs().c3().c0());
					}
					if (flag2)
					{
						r2.bm.bm()[0].t(hg.cs().c4()[0].cz());
						r2.bm.bm()[0].af(hg.cs().c4()[0].c0());
						r2.bm.bm()[0].r(hg.cs().c4()[0].c0());
					}
				}
				r2 = null;
				errPublic = num;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_5 = ex2;
				errPublic = ErrPublic.Generic;
				ab8().c(fz.b.b, "Exception caught in CreateTheoreticalSpectrum(). ", a_5);
				ProjectData.ClearProjectError();
			}
			return errPublic;
		}
	}

	private ErrPublic m2(Collection<hr> A_0, string A_1, bool A_2, global::r.d.a.b A_3, bool A_4, short A_5, ref string A_6, ref cb A_7)
	{
		hg a_ = hc;
		A_7 = new cb();
		if (A_0.Count == zh().ab() && zh().ad() != null && A_0.Count == zh().ad().Count)
		{
			Collection<hc> A_8 = new Collection<hc>();
			return m2(A_0, A_1, ref A_8, A_2, A_3, a_, A_5, A_4, A_8: false, ref A_6, A_7, A_11: false);
		}
		string A_9 = "IncorrectNumberOfMultipleSpectra";
		A_6 = hu.a(ref A_9);
		return ErrPublic.CompositeRecipeInconsistantWithNumSpectra;
	}

	private ErrPublic m2(hr A_0, string A_1, ref hc A_2, bool A_3, global::r.d.a.b A_4, bool A_5, short A_6, ref string A_7)
	{
		Collection<hr> collection = new Collection<hr>();
		hg a_ = hc;
		Collection<hc> A_8 = new Collection<hc>();
		collection.Add(A_0);
		A_8.Add(A_2);
		ErrPublic result = m2(collection, A_1, ref A_8, A_3, A_4, a_, A_6, A_5, A_8: false, ref A_7, null, A_11: false);
		A_2 = A_8[0];
		return result;
	}

	private ErrPublic m2(hr A_0, string A_1, ref hc A_2, bool A_3, global::r.d.a.b A_4, float A_5, float A_6, bool A_7, short A_8, ref string A_9)
	{
		Collection<hr> collection = new Collection<hr>();
		hg A_10 = null;
		Collection<hc> A_11 = new Collection<hc>();
		collection.Add(A_0);
		A_11.Add(A_2);
		hc.bu(ref A_10);
		A_10.ed().d7((double)A_5);
		A_10.ed().d6((double)A_6);
		A_10.ed().el(A_0: true);
		ErrPublic result = m2(collection, A_1, ref A_11, A_3, A_4, A_10, A_8, A_7, A_8: false, ref A_9, null, A_11: false);
		A_2 = A_11[0];
		return result;
	}

	private ErrPublic m2(hr A_0, string A_1, ref hc A_2, bool A_3, global::r.d.a.b A_4, short A_5, ref string A_6)
	{
		Collection<hr> collection = new Collection<hr>();
		hg a_ = hc;
		Collection<hc> A_7 = new Collection<hc>();
		collection.Add(A_0);
		A_7.Add(A_2);
		ErrPublic result = m2(collection, A_1, ref A_7, A_3, A_4, a_, A_5, A_7: true, A_8: true, ref A_6, null, A_11: false);
		A_2 = A_7[0];
		return result;
	}

	private ErrPublic m2(hr A_0, string A_1, int A_2, ref hc A_3, bool A_4, global::r.d.a.b A_5, short A_6, ref string A_7)
	{
		Collection<hr> collection = new Collection<hr>();
		Collection<hc> A_8 = new Collection<hc>();
		hg A_9 = null;
		ErrPublic result;
		try
		{
			collection.Add(A_0);
			A_8.Add(A_3);
			hc.bu(ref A_9);
			A_9.bx(A_2);
			A_9.eh();
			A_9.ed().d7(185.0);
			A_9.ed().d6(2200.0);
			A_9.ed().el(A_0: true);
			ErrPublic num = m2(collection, A_1, ref A_8, A_4, A_5, A_9, A_6, A_7: true, A_8: false, ref A_7, null, A_11: true);
			A_3 = A_8[0];
			result = num;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			result = ErrPublic.Generic;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private bool m2(hr A_0, hi A_1)
	{
		if (!A_1.d6(0, A_0) && !A_1.d5(0, A_0))
		{
			if (A_1.gm() > 1 && A_1.d6(1, A_0))
			{
				return !global::jf.e(A_0.cu().m(), 0.0);
			}
			return false;
		}
		return true;
	}

	private bool m2(hr A_0, hi A_1, ref Collection<int> A_2, eo.a A_3)
	{
		bool result = false;
		A_2 = new Collection<int>();
		if ((A_1.d8(A_3) && A_1.d6(A_3)) || A_0.bm() == null)
		{
			return false;
		}
		checked
		{
			int num = A_0.bm().Count - 1;
			int num2 = 0;
			if (num2 <= num)
			{
				if (A_1.d6(num2 + 1, A_0) && (A_1.d6(0, A_0) || A_1.d5(0, A_0)))
				{
					result = true;
					A_2.Add(num2);
				}
				return result;
			}
			return false;
		}
	}

	private hg m2(hg A_0, hr A_1, bool A_2)
	{
		hg A_3 = null;
		bool flag = A_1.ao();
		gc A_4 = null;
		bool flag2 = false;
		float num = A_1.cu().m();
		bool a_ = A_1.cu().n() != global::hl.a;
		A_0.bu(ref A_3);
		hi hi2 = A_0.ed();
		hi hi3 = A_3.ed();
		hi3.hk();
		foreach (gc item in hi2.cp)
		{
			item.af(ref A_4);
			hi3.au(ref A_4);
			flag2 = flag && item.ai() > 1000000.0;
			if (flag2)
			{
				break;
			}
		}
		hi3.er(a_);
		hi3.eb((double)num);
		if (!flag2 && !A_2)
		{
			hi3.ew(A_0: true);
		}
		hi3.d9(0, flag);
		hi3.d8(0, !flag);
		return A_3;
	}

	private void m2(he A_0, hg A_1, int A_2, bool A_3)
	{
		A_0.ad().Add(A_1);
		A_0.y(string.Empty);
		checked
		{
			if (A_3)
			{
				int num = A_1.ed().g7() + 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					A_1.ed().eu(num2);
					A_0.ah();
					int a_ = A_0.ac() - 1;
					A_0.s(a_, A_2);
					A_0.t(a_, A_0.ab() - 1);
					A_0.s(a_, num2.ToString());
					A_0.t(a_, num2.ToString());
					A_0.s(a_, global::he.a.g);
					A_0.s(a_, 1.0);
				}
			}
		}
	}

	private void m2(he A_0, cb A_1, bool A_2)
	{
		checked
		{
			if (A_2)
			{
				hi hi2 = A_0.ad()[A_0.ad().Count - 1].ed();
				int num = hi2.g7() + 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					hi2.eu(num2);
					A_0.z(A_0.ac() - 1);
				}
				hi2 = null;
			}
			A_0.s(A_0.ad().Count - 1);
			A_0.ad().RemoveAt(A_0.ad().Count - 1);
			if (A_1.h().Count > 0)
			{
				A_1.i().RemoveAt(A_1.h().Count - 1);
				A_1.j().RemoveAt(A_1.h().Count - 1);
				A_1.h().RemoveAt(A_1.h().Count - 1);
			}
		}
	}

	[SpecialName]
	public bool m2(bool A_0, eo.a A_1)
	{
		if (hk.g().Count > 0 && hc.dh().a1(A_1))
		{
			return A_0;
		}
		return false;
	}

	private void m2(Collection<hc> A_0, int A_1, hg A_2, Collection<hg> A_3)
	{
		if (A_1 == 0)
		{
			A_0[A_1].ca = A_2.cl();
		}
		else
		{
			A_0[A_1].ca = A_3[A_1].cl();
		}
	}

	private ErrPublic m2(Collection<hr> A_0, string A_1, ref Collection<hc> A_2, bool A_3, global::r.d.a.b A_4, hg A_5, short A_6, bool A_7, bool A_8, ref string A_9, cb A_10, bool A_11)
	{
		ErrPublic errPublic = ErrPublic.None;
		int[] array = null;
		int[] array2 = null;
		bool flag = false;
		bool flag2 = false;
		Collection<hr> collection = new Collection<hr>();
		Collection<hg> collection2 = new Collection<hg>();
		Collection<double[]> collection3 = new Collection<double[]>();
		int count = A_0.Count;
		checked
		{
			int num = count - 1;
			hc hc2 = null;
			Collection<int>[] array3 = new Collection<int>[num + 1];
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = false;
			Collection<int> A_12 = null;
			bool[] array4 = new bool[num + 1];
			bool[] array5 = new bool[num + 1];
			bool[] array6 = new bool[num + 1];
			bool[] array7 = new bool[num + 1];
			he A_13 = null;
			Collection<hr> collection4 = new Collection<hr>();
			cb cb2 = null;
			Collection<hc> collection5 = new Collection<hc>();
			hg hg2 = null;
			int num2 = 0;
			bool flag10 = default(bool);
			try
			{
				eo.a a10 = null;
				int A_14;
				if (A_0.Count > 1)
				{
					int num3 = A_0.Count - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						hg hg3 = ((num4 != 0) ? hl.ad()[num4] : A_5);
						A_14 = 0;
						if (hg3.bu(A_0: false, a10, ref A_14) != null)
						{
							throw new ax("Additional recipes not permitted in recipes used in a Composite Recipe");
						}
					}
				}
				A_14 = A_0.Count - 1;
				for (int num4 = 0; num4 <= A_14; num4++)
				{
					hi hi2 = ((num4 != 0) ? hl.ad()[num4].ed() : A_5.ed());
					if (m2(A_0[num4], hi2))
					{
						array4[num4] = true;
					}
					bool flag8 = !global::jf.e(A_0[num4].cu().m(), 0.0);
					array5[num4] = hi2.d5(0, A_0[num4]) && !hi2.d6(0, A_0[num4]) && !flag8;
					if (flag8 && A_0[num4].bl() != null && hi2.d5(0, A_0[num4]))
					{
						if (hi2.gm() > 1 && hi2.d6(1, A_0[num4]))
						{
							hr hr2 = A_0[num4].cw();
							hr2.r((hr)null);
							flag4 = true;
							array6[num4] = true;
							collection4.Add(hr2);
						}
						else
						{
							flag7 = true;
							array7[num4] = true;
							collection4.Add(A_0[num4].bl());
						}
					}
					else
					{
						collection4.Add(A_0[num4]);
					}
					num2++;
					if (m2(A_0[num4], hi2, ref A_12, a10))
					{
						if (array4[num4])
						{
							flag5 = true;
							flag3 = true;
						}
						else
						{
							A_12.RemoveAt(0);
							if (A_12.Count > 0)
							{
								flag3 = true;
							}
							collection4.Add(A_0[num4].bm()[0]);
							num2++;
						}
					}
					array3[num4] = A_12;
				}
				count = ((!A_5.ei()) ? 1 : A_0.Count);
				num = count - 1;
				flag6 = (flag3 && flag5) || flag4;
				if (flag4 || flag3)
				{
					if (A_5.ei())
					{
						hl.s(ref A_13);
						foreach (hg item in hl.ad())
						{
							hg A_15 = new hg(item.dh(), item.cd());
							item.bu(ref A_15);
							A_13.ad().Add(A_15);
						}
						cb2 = A_10;
					}
					else if (flag6)
					{
						A_13 = new he(string.Empty, string.Empty, string.Empty);
						A_13.ag();
						A_13.ad().Add(A_5);
						A_13.y(A_5.c1());
						cb2 = new cb();
					}
					else
					{
						A_13 = null;
					}
					int num5 = A_0.Count - 1;
					for (int num4 = 0; num4 <= num5; num4++)
					{
						hg2 = ((num4 != 0) ? hl.ad()[num4] : A_5);
						int num6 = 0;
						if (array4[num4])
						{
							num6 = 1;
						}
						if (array6[num4])
						{
							collection4.Add(A_0[num4].bl());
							m2(A_13, hg2, num4, A_3: true);
						}
						else
						{
							if (!flag3)
							{
								continue;
							}
							foreach (int item2 in array3[num4])
							{
								collection4.Add(A_0[num4].bm()[item2]);
								if (flag6)
								{
									hg2 = m2(hg2, collection4[item2 + num6], A_11);
									m2(A_13, hg2, num4, array4[num4] || item2 > 0);
								}
							}
						}
					}
				}
				else if (A_5.ei())
				{
					A_13 = hl;
					cb2 = A_10;
				}
				A_2.Clear();
				int num7 = num;
				for (int num4 = 0; num4 <= num7; num4++)
				{
					hc2 = new hc();
					hc2.cf(g6, vc());
					A_2.Add(hc2);
					collection5.Add(hc2);
				}
				int num8;
				if (flag6)
				{
					num8 = collection4.Count - 1;
					int num9 = count;
					int num10 = num8;
					for (int num4 = num9; num4 <= num10; num4++)
					{
						hc2 = new hc();
						hc2.cf(g6, vc());
						collection5.Add(hc2);
					}
				}
				else
				{
					num8 = num;
				}
				bool flag9 = A_5.bz(a10) && (A_5.ed().fw() || A_5.ed().fv()) && !collection4[0].af();
				string A_16 = "";
				gs obj = hi;
				string A_17 = "AnalyzeSpectrumCore";
				if (obj.m2(this, ref A_17, ref A_16) != global::p.a.a)
				{
					ab8().c(fz.b.b, "Failure to lock measEngine. Message is:" + A_16, Environment.StackTrace);
					return ErrPublic.None;
				}
				flag10 = true;
				eo obj2 = A_5.dh();
				bool flag11 = obj2.az(a10);
				bool flag12 = obj2.aw(a10);
				bool flag13 = obj2.a0(a10);
				_ = null;
				hr hr3 = collection4[0];
				hg2 = ((!global::jf.e(hr3.cu().m(), 0.0)) ? m2(A_5, hr3, A_11) : A_5);
				hr hr4 = b9.m2(collection4[0], hg2);
				collection.Add(hr4);
				int num11 = num8;
				for (int num4 = 1; num4 <= num11; num4++)
				{
					collection.Add(b9.m2(collection4[num4], A_13.ad()[num4]));
				}
				array = new int[num8 + 1];
				array2 = new int[num8 + 1];
				bool flag14 = hr4.cu().q() != null;
				hi hi3 = A_5.ed();
				bool flag15 = flag13 && A_5.b5();
				if (hr.r(hr4.cj(), flag14) && hr4.ah() && (flag15 || flag11 || flag12 || flag14))
				{
					flag2 = flag15 && hi3.ff() && hi3.fg();
					if (flag2)
					{
						hi3.hk();
						hi3.d7(700.0);
						hi3.d6(1100.0);
						gc A_18 = new gc();
						A_18.af("Air");
						A_18.al(0.5);
						hi3.au(ref A_18);
						A_18 = new gc();
						A_18.af(A_0: false, A_1: true, 6000.0);
						A_18.ak(67.0);
						A_18.af("HC standard");
						A_18.ag(A_0: true);
						hi3.au(ref A_18);
						A_18 = new gc();
						A_18.af("Polycarbonate");
						A_18.aj(0.0);
						A_18.al(0.5);
						A_18.am(0.1);
						A_18.ag("Bridge Lorentzian-3Term");
						hi3.au(ref A_18);
					}
					int A_19 = default(int);
					int A_20 = default(int);
					if ((!flag15 && (flag11 || flag12 || flag14)) || (flag2 && flag13))
					{
						try
						{
							collection2.Add(A_5);
							collection3.Add(m2(hr4));
							m2(A_5, hr4.cz(), flag14, ref A_19, ref A_20);
							array[0] = A_19;
							array2[0] = A_20;
							int num12 = num8;
							for (int num4 = 1; num4 <= num12; num4++)
							{
								collection2.Add(A_13.ad()[num4]);
								collection3.Add(m2(collection[num4]));
								m2(A_13.ad()[num4], collection[num4].cz(), flag14, ref array[num4], ref array2[num4]);
							}
						}
						catch (ag ag2)
						{
							ProjectData.SetProjectError(ag2);
							ag ag3 = ag2;
							ld = ag3.Message;
							errPublic = ErrPublic.NoDataWithinRange;
							ProjectData.ClearProjectError();
						}
						if (errPublic == ErrPublic.None)
						{
							if (hi.m2(collection2, ha, collection, ref A_9, A_7, a10) == b9.ErrPublic.None)
							{
								flag = true;
							}
							else
							{
								errPublic = ErrPublic.SpecAnalysisSetup;
							}
						}
						if (errPublic != ErrPublic.None)
						{
							int num13 = num;
							for (int num4 = 0; num4 <= num13; num4++)
							{
								A_2[num4].cf(0.0, 0f, A_0[num4], array[num4], array2[num4], null, null, null, null, 0f, A_10: false, A_0[num4].b4(), collection2[num4], A_1, null, null, null, null, null, -1, null, null, null, null, null, null, null, null, null, null, null, null, null, A_3, A_34: false, A_0[num4].b6(), A_0[num4].b7(), a10);
								m2(A_2, num4, A_5, collection2);
							}
						}
					}
					else
					{
						flag = true;
					}
					if (flag)
					{
						int num14 = num8;
						for (int num4 = 0; num4 <= num14; num4++)
						{
							m2(collection5, num4, A_5, collection2);
							if (A_8)
							{
								collection5[num4].cg(A_0: true);
								collection5[num4].cf(km, ke, kf, kg, kh, ki, kj, kk, kl, kv, kn, ko, kp, kq, kr, ks, kt, ku, kw);
							}
						}
						if (flag15)
						{
							switch (hi.m2(hr3.b4(), A_1, A_5, ha, hr3, hc2, A_3, A_5.d0().c(), m2(hr4), hk))
							{
							case b9.ErrPublic.InvalidSolarData:
								errPublic = ErrPublic.InvalidSolarData;
								break;
							case b9.ErrPublic.InvalidIlluminanceData:
								errPublic = ErrPublic.InvalidIlluminanceData;
								break;
							default:
								errPublic = ErrPublic.SpecAnalysis;
								break;
							case b9.ErrPublic.None:
								break;
							}
						}
						else
						{
							double[] A_21 = new double[1];
							double num32 = default(double);
							double num33 = default(double);
							bool A_26;
							b9.ErrPublic errPublic2;
							if (flag9)
							{
								double num15 = -1.0;
								if (A_4 == global::r.d.a.b.a && A_5.dh().a8())
								{
									ab8().c(fz.b.b, "Start Wavelength,Stop Wavelength,GOF,measErr");
								}
								float A_22 = default(float);
								float A_23 = default(float);
								m2(hr4.cz(), ref A_22, ref A_23);
								double num16 = Convert.ToDouble(A_23 - A_22);
								int num17;
								double num18;
								double num19 = default(double);
								if (!A_5.ed().fw())
								{
									num17 = 0;
									num18 = Math.Min(A_5.ed().fy(), num16);
								}
								else
								{
									num18 = A_5.ed().fx();
									num19 = (num16 - num18) / 5.0;
									num17 = 5;
									if (num19 < 10.0)
									{
										num17 = Convert.ToInt32(Math.Floor((num16 - num18) / 10.0));
										if (num17 > 1)
										{
											num19 = (num16 - num18) / (double)num17;
										}
										else if (num17 == 1)
										{
											num19 = num16 - num18;
										}
									}
								}
								if (num17 >= 1 || !A_5.ed().fw())
								{
									int num20 = num17;
									int num23 = default(int);
									double num26 = default(double);
									double num30 = default(double);
									double num31 = default(double);
									int A_24 = default(int);
									int A_25 = default(int);
									for (int num21 = 0; num21 <= num20; num21++)
									{
										double num22 = num18 + (double)num21 * num19;
										double num24;
										if (!A_5.ed().fv())
										{
											num23 = 0;
											num24 = (A_23 + A_22) / 2f;
										}
										else
										{
											num24 = (double)A_22 + num22 / 2.0;
											double num25 = (double)A_23 - num22 / 2.0;
											num26 = (num25 - num24) / 5.0;
											num23 = 5;
											if (num26 < 10.0)
											{
												num23 = Convert.ToInt32(Math.Floor((num25 - num24) / 10.0));
												if (num23 > 1)
												{
													num26 = (num25 - num24) / (double)num23;
												}
												else if (num23 == 1)
												{
													num26 = num25 - num24;
												}
											}
										}
										if (num23 >= 0 && (num23 > 0 || num17 > 0))
										{
											int num27 = num23;
											for (int num28 = 0; num28 <= num27; num28++)
											{
												double num29 = num24 + (double)num28 * num26;
												num30 = num29 - num22 / 2.0;
												num31 = num29 + num22 / 2.0;
												m2(hr4.cz(), num30, num31, ref A_24, ref A_25);
												gs obj3 = hi;
												hd a_ = ha;
												int a_2 = A_24;
												int a_3 = A_25;
												hc a_4 = hc2;
												A_26 = false;
												errPublic2 = obj3.m2(A_1, A_5, a_, a_2, a_3, hr3, a_4, ref A_21, ref A_26, A_9: false, flag12, A_6, m2(hr4), ref A_9, a10);
												if (A_4 == global::r.d.a.b.a && A_5.dh().a8())
												{
													string text = num30.ToString("0.0", CultureInfo.InvariantCulture) + ",";
													text = text + num31.ToString("0.0", CultureInfo.InvariantCulture) + ",";
													text = text + hc2.c2().ToString("0.000000", CultureInfo.InvariantCulture) + ",";
													text += Convert.ToInt32(unchecked((int)errPublic2)).ToString("0", CultureInfo.InvariantCulture);
													ab8().c(fz.b.b, text);
												}
												if (errPublic2 == b9.ErrPublic.None && (double)hc2.c2() > num15 && hc2.c3() >= A_5.ed().gr())
												{
													num15 = hc2.c2();
													A_19 = A_24;
													A_20 = A_25;
													num32 = num30;
													num33 = num31;
												}
											}
										}
										else
										{
											num32 = A_22;
											num33 = A_23;
										}
									}
									if (num15 < 0.0 && (num23 >= 1 || !A_5.ed().fv()))
									{
										array[0] = A_24;
										array2[0] = A_25;
										num32 = num30;
										num33 = num31;
									}
									else
									{
										array[0] = A_19;
										array2[0] = A_20;
									}
								}
								else
								{
									num32 = A_22;
									num33 = A_23;
								}
							}
							gs obj4 = hi;
							hg a_5 = hg2;
							hd a_6 = ha;
							int[] a_7 = array;
							int[] a_8 = array2;
							A_26 = false;
							errPublic2 = obj4.m2(A_1, a_5, a_6, a_7, a_8, collection4, collection5, ref A_21, ref A_26, A_3, flag12, A_6, collection3, A_13, cb2, ref A_9, a10);
							if (flag4 || flag3 || flag7)
							{
								int num34 = num2;
								int num35 = num;
								for (int num4 = 0; num4 <= num35; num4++)
								{
									int count2 = array3[num4].Count;
									int num36 = 0;
									float num37 = 0f;
									if (array4[num4])
									{
										num36 = 1;
										num37 = A_2[num4].c2();
									}
									else
									{
										A_2[num4].cn().r(A_0[num4].b9());
									}
									if (A_2[num4].cs() == null)
									{
										continue;
									}
									if (array7[num4])
									{
										A_2[num4].cf(A_0[num4]);
									}
									else if (array6[num4])
									{
										A_2[num4].cf(A_0[num4]);
										A_2[num4].cs().t(collection5[num34].cs());
										num37 += collection5[num34].c2();
										num34++;
										num37 /= 2f;
										A_2[num4].cf(num37);
									}
									else
									{
										if (count2 <= 0)
										{
											continue;
										}
										if (!array4[num4])
										{
											A_2[num4].cf(A_0[num4]);
										}
										int num38 = array3[num4].Count - 1;
										for (int num39 = 0; num39 <= num38; num39++)
										{
											if (num34 > num4)
											{
												if (array5[num4] && num39 == 0)
												{
													A_2[num4].cs().t(new fy(collection5[num4].cs().cz(), collection5[num4].cs().c0()));
													A_2[num4].cs().t(collection5[num34].cs().cz());
													A_2[num4].cs().af(collection5[num34].cs().c0());
												}
												else if (A_2[num4].cy().b3(A_2[num4].cf()).d6(1, A_2[num4].cn()))
												{
													A_2[num4].cs().r(collection5[num34].cs());
												}
											}
											num37 += collection5[num34].c2();
											num34++;
										}
										num37 /= (float)(num36 + count2);
										A_2[num4].cf(num37);
									}
								}
							}
							int num40 = num;
							for (int num4 = 0; num4 <= num40; num4++)
							{
								if (A_2[num4] != null && A_2[num4].cs() != null && A_2[num4].cs().c0() != null)
								{
									double[] a_9 = A_2[num4].cs().c0();
									A_2[num4].cs().af(A_0[num4].c1().b5(A_0[num4].c1().b4(a_9)));
								}
								if (flag9)
								{
									A_2[num4].cf(num32.ToString("0", CultureInfo.InvariantCulture) + "-" + num33.ToString("0", CultureInfo.InvariantCulture));
								}
							}
							int num41 = A_0.Count - 1;
							for (int num4 = 0; num4 <= num41; num4++)
							{
								if (array6[num4])
								{
									m2(A_13, cb2, A_2: true);
									continue;
								}
								foreach (int item3 in array3[num4])
								{
									if (flag6)
									{
										m2(A_13, cb2, array4[num4] || item3 > 0);
									}
								}
							}
							if (errPublic2 != b9.ErrPublic.None)
							{
								int num42 = num;
								for (int num4 = 0; num4 <= num42; num4++)
								{
									m2(collection2[num4], collection[num4].cz(), flag14, ref array[num4], ref array2[num4]);
									A_2[num4].cf(0.0, 0f, A_0[num4], array[num4], array2[num4], null, null, null, null, 0f, A_10: false, A_0[num4].b4(), collection2[num4], A_1, null, null, null, null, null, -1, null, null, null, null, null, null, null, null, null, null, null, null, null, A_3, A_34: false, A_0[num4].b6(), A_0[num4].b7(), a10);
									m2(A_2, num4, A_5, collection2);
								}
								errPublic = errPublic2 switch
								{
									b9.ErrPublic.NoLayersSelectedForMeasurement => ErrPublic.SpecAnalysisFFTNoLayersSelectedForMeasure, 
									b9.ErrPublic.SolvingAborted => ErrPublic.SolvingAbortSuccess, 
									b9.ErrPublic.InitNKCoeffsInvalid => ErrPublic.InitNKCoeffsInvalid, 
									b9.ErrPublic.InvalidDConstraints => ErrPublic.InvalidDConstraints, 
									b9.ErrPublic.InvalidNConstraints => ErrPublic.InvalidNConstraints, 
									b9.ErrPublic.InvalidKConstraints => ErrPublic.InvalidKConstraints, 
									b9.ErrPublic.InsufficientData => ErrPublic.InsufficientData, 
									b9.ErrPublic.OutOfCorrelativeRange => ErrPublic.OutOfCorrelativeRange, 
									b9.ErrPublic.ModelCoeffIncompatWithInitialN => ErrPublic.ModelCoeffIncompatibleWithInitialN, 
									b9.ErrPublic.ModelCoeffIncompatWithInitialK => ErrPublic.ModelCoeffIncompatibleWithInitialK, 
									b9.ErrPublic.OnlyExactSpectrumAnalysisPermittedForRAtAngle => ErrPublic.OnlyExactSpectrumAnalysisPermittedForRAtAngle, 
									b9.ErrPublic.ZAREModelUsedInMultipleLayersWithinSingleStack => ErrPublic.ZAREModelUsedInMultipleLayersWithinSingleStack, 
									b9.ErrPublic.ZAREAttemptToSolveForKWithoutTrans => ErrPublic.ZAREAttemptToSolveForKWithoutTrans, 
									b9.ErrPublic.ZAREAttemptToSolveForXKWithoutReflTrans => ErrPublic.ZAREAttemptToSolveForXKWithoutReflTrans, 
									b9.ErrPublic.ZAREAttemptToSolveForNWithoutRAngle => ErrPublic.ZAREAttemptToSolveForNWithoutRAngle, 
									b9.ErrPublic.ZAREAttemptToSolveForDNWithoutRAngle => ErrPublic.ZAREAttemptToSolveForDNWithoutRAngle, 
									b9.ErrPublic.ZAREAttemptToSolveForDNWithoutR0OrT => ErrPublic.ZAREAttemptToSolveForDNWithoutR0OrT, 
									b9.ErrPublic.ZAREAttemptToSolveForDNKWithoutDoubleRefl => ErrPublic.ZAREAttemptToSolveForDNKWithoutDoubleRefl, 
									b9.ErrPublic.ZAREInsufficientWavelengthOverlapBetweenSpectrumTypes => ErrPublic.ZAREInsufficientWavelengthOverlapBetweenSpectrumTypes, 
									b9.ErrPublic.ZAREMismatchedSolveForDInSameLayers => ErrPublic.ZAREMismatchedSolveForDInSameLayers, 
									b9.ErrPublic.ZAREIndependentDForSameNorK => ErrPublic.ZAREIndependentDForSameNorK, 
									b9.ErrPublic.ZAREDesignError => ErrPublic.ZAREDesignError, 
									_ => ErrPublic.SpecAnalysis, 
								};
							}
						}
					}
				}
				else
				{
					collection2.Add(A_5);
					int num43 = num8;
					for (int num4 = 1; num4 <= num43; num4++)
					{
						collection2.Add(A_13.ad()[num4]);
					}
					int num44 = num;
					for (int num4 = 0; num4 <= num44; num4++)
					{
						if (num4 == 0)
						{
							m2(A_5, collection[num4].cz(), flag14, ref array[num4], ref array2[num4]);
						}
						else
						{
							m2(hl.ad()[num4], collection[num4].cz(), flag14, ref array[num4], ref array2[num4]);
						}
						A_2[num4].cf(0.0, 0f, A_0[num4], array[num4], array2[num4], null, null, null, null, 0f, A_10: false, A_0[num4].b4(), collection2[num4], A_1, null, null, null, null, null, -1, null, null, null, null, null, null, null, null, null, null, null, null, null, A_3, A_34: false, A_0[num4].b6(), A_0[num4].b7(), a10);
						m2(A_2, num4, A_5, collection2);
					}
				}
				if (errPublic == ErrPublic.None && m2(A_0[0].cu().q() == null, a10))
				{
					a4.a a_10 = hk.h();
					int num45 = num;
					for (int num4 = 0; num4 <= num45; num4++)
					{
						gs obj5 = hi;
						hr a_11 = A_0[num4];
						hc hc3;
						cc.f A_27 = (hc3 = A_2[num4]).co();
						obj5.m2(a_11, ref A_27, hk);
						hc3.cf(A_27);
						A_2[num4].cf(A_0: true, a_10);
						if (A_0[num4].bl() != null)
						{
							gs obj6 = hi;
							hr a_12 = A_0[num4].bl();
							A_27 = (hc3 = A_2[num4]).cp();
							obj6.m2(a_12, ref A_27, hk);
							hc3.cg(A_27);
							A_2[num4].cf(A_0: false, a_10);
						}
					}
				}
				if (hi3.au(A_5.dh(), a10))
				{
					int num46 = num;
					for (int num4 = 0; num4 <= num46; num4++)
					{
						hi.m2(A_2[num4], hi3.c9);
					}
					if (errPublic == ErrPublic.NoDataWithinRange)
					{
						errPublic = ErrPublic.None;
					}
				}
				if (hi3.d5(A_5.dh(), a10))
				{
					int num47 = num;
					for (int num4 = 0; num4 <= num47; num4++)
					{
						hi.p9(A_2[num4], hi3.c9);
					}
					if (errPublic == ErrPublic.NoDataWithinRange)
					{
						errPublic = ErrPublic.None;
					}
				}
			}
			catch (ag ag4)
			{
				ProjectData.SetProjectError(ag4);
				ag ag5 = ag4;
				ld = ag5.Message;
				errPublic = ErrPublic.NoDataWithinRange;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_13 = ex2;
				ab8().c(fz.b.b, "Exception caught in AnalyzeSpectrumCore(). ", a_13);
				errPublic = ErrPublic.Generic;
				ProjectData.ClearProjectError();
			}
			finally
			{
				if (flag10)
				{
					string A_28 = "";
					if (hi.m2(this, ref A_28) != global::p.b.a)
					{
						ab8().c(fz.b.b, "Failure to unlock measEngine. Message is:" + A_28, Environment.StackTrace);
					}
				}
			}
			return errPublic;
		}
	}

	public void qh(bool A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		s s2 = new s(A_2);
		((m)s2).a = m.a.at;
		s2.d = m.TaskExecutionType.Setup;
		s2.cb = A_0;
		s2.g = A_1;
		_ = null;
		string A_3 = "";
		string A_4 = "";
		m2(ref A_3, ref A_4, s2);
	}

	public void m2(bool A_0, bool A_1, bool A_2, bool A_3, global::r.d A_4, global::r.d.a.b A_5)
	{
		s s2 = new s(A_5);
		((m)s2).a = m.a.l;
		s2.d = m.TaskExecutionType.Setup;
		s2.g = A_4;
		s2.b0 = A_0;
		s2.b1 = A_1;
		s2.b6 = A_2;
		s2.cd = A_3;
		_ = null;
		string A_6 = "";
		string A_7 = "";
		m2(ref A_6, ref A_7, s2);
	}

	public ErrPublic m2(ref string A_0, hr A_1, bool A_2, global::r.c A_3, global::r.d A_4, global::r.d.a.b A_5)
	{
		r r2 = new r(A_5);
		((m)r2).a = m.a.o;
		r2.d = m.TaskExecutionType.MeasEngine;
		r2.h = A_3;
		r2.g = A_4;
		r2.bm = A_1;
		r2.bs = A_2;
		r2.bj = false;
		_ = null;
		string A_6 = "Calibrating Objective";
		m2(ref A_6, ref A_0, r2);
		return ErrPublic.None;
	}

	public ErrPublic m2(string A_0, ref string A_1, global::r.d A_2, l A_3, Collection<hr> A_4, short A_5, a6 A_6, global::r.d.a.b A_7, bool A_8, bool A_9)
	{
		ErrPublic errPublic = m2(ref A_0, ref A_1, A_2: true, "");
		if (errPublic != ErrPublic.None)
		{
			return errPublic;
		}
		r r2 = new r(A_7);
		((m)r2).a = m.a.aa;
		r2.d = m.TaskExecutionType.MeasEngine;
		r2.f = A_0;
		r2.g = A_2;
		r2.l = A_3;
		r2.bn = A_4;
		r2.br = A_5;
		r2.bj = A_8;
		r2.bt = A_6;
		r2.bu = A_9;
		_ = null;
		return m2(ref A_0, ref A_1, r2);
	}

	public ErrPublic m2(string A_0, ref string A_1, global::r.d A_2, l A_3, hr A_4, short A_5, a6 A_6, global::r.d.a.b A_7, bool A_8, bool A_9)
	{
		ErrPublic errPublic = m2(ref A_0, ref A_1, A_2: true, "");
		if (errPublic != ErrPublic.None)
		{
			return errPublic;
		}
		r r2 = new r(A_7);
		((m)r2).a = m.a.h;
		r2.d = m.TaskExecutionType.MeasEngine;
		r2.f = A_0;
		r2.g = A_2;
		r2.l = A_3;
		r2.bm = A_4;
		r2.br = A_5;
		r2.bj = A_8;
		r2.bt = A_6;
		r2.bu = A_9;
		_ = null;
		return m2(ref A_0, ref A_1, r2);
	}

	public void st(global::r.d A_0, global::r.d.a.b A_1)
	{
		if (iq == null || iq[0] == null || iq[0][0] == null)
		{
			return;
		}
		bool flag = false;
		Collection<m> collection = zy();
		Collection<m> collection2 = zz();
		lock (collection)
		{
			lock (collection2)
			{
				foreach (m item in collection)
				{
					if (item.a == m.a.u)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					foreach (m item2 in collection2)
					{
						if (item2.a == m.a.u)
						{
							flag = true;
							break;
						}
					}
				}
			}
		}
		if (!flag)
		{
			q q2 = new q(A_1);
			q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
			((m)q2).a = m.a.u;
			q2.g = A_0;
			q2.e = gt;
			_ = null;
			if (sj(q2) != global::r.a.a)
			{
				throw new ah("Failed to attempt to read input signals");
			}
		}
	}

	public void m2(byte A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		q q2 = new q(A_2);
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q2).a = m.a.v;
		q2.g = A_1;
		q2.a9 = A_0;
		q2.e = gt;
		_ = null;
		if (sj(q2) != global::r.a.a)
		{
			throw new ah("Failed to set output signals");
		}
	}

	[SpecialName]
	public byte xh()
	{
		if (!lb)
		{
			throw new ah("Attempt to query output bits before setting them");
		}
		return lc;
	}

	public ErrPublic m2(string A_0, ref string A_1, global::r.d A_2, l A_3, hr A_4, ho A_5, short A_6, global::r.d.a.b A_7)
	{
		ErrPublic errPublic = m2(ref A_0, ref A_1, A_2: true, "");
		if (errPublic != ErrPublic.None)
		{
			return errPublic;
		}
		r r2 = new r(A_7);
		((m)r2).a = m.a.r;
		r2.d = m.TaskExecutionType.MeasEngine;
		r2.f = A_0;
		r2.g = A_2;
		r2.l = A_3;
		r2.bm = A_4;
		r2.bq = A_5;
		r2.br = A_6;
		r2.bt = new a6();
		_ = null;
		return m2(ref A_0, ref A_1, r2);
	}

	public void m2(string A_0, string A_1, string A_2, ref string A_3, global::r.d A_4, l A_5, bool A_6, int A_7, global::r.d.a.b A_8, hr A_9, bool A_10, bool A_11, h6.b A_12)
	{
		ErrPublic errPublic;
		if (A_9 == null)
		{
			p p2 = new p(u1(), A_8);
			((m)p2).a = m.a.c;
			p2.d = m.TaskExecutionType.Spectrometer;
			p2.n = m2(n.i, n.i, uf());
			p2.f = A_2;
			p2.g = A_4;
			p2.l = A_5;
			p2.v = A_0;
			p2.w = A_1;
			p2.ac = A_6;
			p2.ah = A_7;
			p2.h = ja;
			p2.ax = A_10;
			p2.a0 = A_12;
			p2.az = A_11;
			p2.ay = 5.0;
			_ = null;
			jl = string.Empty;
			errPublic = m2(ref A_2, ref A_3, p2);
		}
		else
		{
			r r2 = new r(A_8);
			((m)r2).a = m.a.w;
			r2.d = m.TaskExecutionType.MeasEngine;
			r2.f = A_2;
			r2.g = A_4;
			r2.l = A_5;
			r2.bm = A_9;
			_ = null;
			errPublic = m2(ref A_2, ref A_3, r2);
		}
		if (errPublic != ErrPublic.None)
		{
			int num = (int)errPublic;
			throw new ApplicationException("Error MeasModuleSpec.AttemptAcquireSpectrum. Error code=" + num);
		}
	}

	public ErrPublic m2(int A_0, global::f.b A_1, SpectromTempSensorLoc A_2, string A_3, ref string A_4, global::r.d A_5, global::r.d.a.b A_6)
	{
		q q2 = new q(A_6);
		((m)q2).a = m.a.p;
		q2.g = A_5;
		q2.a6 = A_0;
		q2.a7 = A_1;
		q2.j = A_2;
		_ = null;
		return m2(ref A_3, ref A_4, q2);
	}

	public void s3(global::r.d A_0, global::r.d.a.b A_1)
	{
		q q2 = new q(A_1);
		((m)q2).a = m.a.bf;
		q2.g = A_0;
		_ = null;
		string A_2 = null;
		string A_3 = null;
		m2(ref A_2, ref A_3, q2);
	}

	public void s4(global::r.d A_0, global::r.d.a.b A_1)
	{
		q q2 = new q(A_1);
		((m)q2).a = m.a.bg;
		q2.g = A_0;
		_ = null;
		string A_2 = null;
		string A_3 = null;
		m2(ref A_2, ref A_3, q2);
	}

	public ErrPublic xi()
	{
		if (zp() == g2.a.b && !xl())
		{
			return sn(m2(hb, A_1: true, A_2: false));
		}
		return ErrPublic.None;
	}

	public void xj()
	{
		if (vk() && zp() == g2.a.b && vo()[0] && vo()[1])
		{
			ip obj = iq[iu[0]][0];
			ip a_ = iq[iu[1]][0];
			g2.OpticsConfigSubmoduleTypes a_2 = g2.a(zp(), ix[iu[0]]);
			obj.m2(a_);
			obj.sm(a_2);
		}
	}

	private ErrPublic sn(global::h A_0)
	{
		bool A_1 = false;
		bool flag = m2(ref A_1, A_0);
		float[] a_ = new float[checked(Enum.GetValues(typeof(global::h.h)).GetUpperBound(0) + 1)];
		if (A_1)
		{
			if (!flag)
			{
				m2(global::r.d.a.b.b, 0L, A_2: false);
			}
			string A_2 = string.Empty;
			if (k2 != null)
			{
				if (!k2.q())
				{
					ab8().c(fz.b.b, "AttempStartAutoBaselineAcqRandT was called when previous task was not yet slated for termination.");
				}
				k2.q(A_0: true);
			}
			k2 = new l();
			k2.m = new global::r.d();
			k2.j = true;
			return m2(string.Empty, string.Empty, "R and T Auto Measuring...", ref A_2, new global::r.d(), o.b, k2, A_7: false, a_, A_9: true, A_10: false, 0, 0f, 0f, global::r.d.a.b.b, 0, null, A_17: false, A_18: false, A_19: false, 0);
		}
		return ErrPublic.None;
	}

	public void xk()
	{
		if (k2 != null && k2.l)
		{
			k2.q(A_0: true);
		}
	}

	public bool xl()
	{
		p A_ = null;
		return m2(ref A_);
	}

	private bool m2(ref p A_0)
	{
		bool num = hc.d0().c() == g2.a.b;
		Collection<m> collection = null;
		Collection<m> collection2 = null;
		A_0 = null;
		if (num)
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			try
			{
				flag = Monitor.TryEnter(zz(), 300);
				if (!flag)
				{
					throw new ao("Timeout2 in AutoBaselineAcqRandTIsRunning.");
				}
				collection = zz();
				foreach (m item in collection)
				{
					if (item is p)
					{
						A_0 = (p)item;
						if (((m)A_0).a == m.a.f)
						{
							return true;
						}
					}
				}
				flag2 = Monitor.TryEnter(zy(), 300);
				if (!flag2)
				{
					throw new ao("Timeout1 in AutoBaselineAcqRandTIsRunning.");
				}
				collection2 = zy();
				foreach (m item2 in collection2)
				{
					if (item2 is p)
					{
						A_0 = (p)item2;
						if (((m)A_0).a == m.a.f)
						{
							return true;
						}
					}
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(collection);
				}
				if (flag2)
				{
					Monitor.Exit(collection2);
				}
			}
		}
		return false;
	}

	public ErrPublic m2(string A_0, string A_1, string A_2, ref string A_3, global::r.d A_4, o A_5, l A_6, bool A_7, float[] A_8, bool A_9, bool A_10, int A_11, float A_12, float A_13, global::r.d.a.b A_14, int A_15, string A_16, bool A_17, bool A_18, bool A_19, short A_20)
	{
		checked
		{
			if (lz)
			{
				p p2 = null;
				bool flag = false;
				bool flag2 = hc.d0().c() == g2.a.b;
				bool flag3 = A_5 == o.b;
				p A_21 = null;
				bool flag4 = false;
				if (flag2)
				{
					flag = m2(ref A_21);
					if (!flag3)
					{
						if (flag)
						{
							lock (A_21)
							{
								p p3 = A_21;
								switch (A_5)
								{
								case o.c:
								{
									p3.d0(o.c);
									le = 0;
									lg = false;
									lf = false;
									lh = 0f;
									if (!flag2)
									{
										break;
									}
									int upperBound = iq.GetUpperBound(0);
									for (int num = 0; num <= upperBound; num++)
									{
										int num2 = iq[num].Count - 1;
										for (int num3 = 0; num3 <= num2; num3++)
										{
											li[num] = false;
											iq[num][0].te(A_0: true);
										}
									}
									break;
								}
								case o.d:
									p3.v = A_0;
									p3.w = A_1;
									p3.d0(o.d);
									p3.s = A_10;
									break;
								case o.e:
									p3.v = A_0;
									p3.w = A_1;
									p3.d0(o.e);
									p3.s = A_10;
									break;
								case o.f:
									p3.d0(o.f);
									p3.s = A_10;
									break;
								case o.g:
									p3.v = A_0;
									p3.w = A_1;
									p3.d0(o.g);
									p3.s = false;
									break;
								case o.h:
									p3.v = A_0;
									p3.w = A_1;
									p3.d0(o.h);
									p3.s = false;
									break;
								case o.i:
									p3.d0(o.i);
									p3.s = false;
									break;
								case o.j:
								case o.k:
								{
									p3.d0(A_5);
									t A_22 = null;
									m2(ref A_21, ref A_22, A_0, A_1, A_4, 0, A_15, A_16, A_17, A_18, A_19, m.a.f, A_20, 0, A_6, A_14);
									break;
								}
								}
								p3 = null;
							}
						}
						else
						{
							flag4 = true;
						}
					}
				}
				if (!flag)
				{
					global::h a_ = m2(hc, flag2, A_2: true);
					kz = false;
					k0 = false;
					k1 = false;
					p2 = new p(u1(), A_14);
					p obj = p2;
					((m)obj).a = m.a.f;
					obj.d = m.TaskExecutionType.Spectrometer;
					obj.n = m2(n.b, n.b, A_2: false, a_);
					obj.f = A_2;
					obj.g = A_4;
					obj.l = A_6;
					obj.v = A_0;
					obj.w = A_1;
					obj.aa = A_7;
					obj.ab = A_8;
					obj.ac = A_9;
					obj.ah = A_11;
					obj.h = ja;
					obj.d0(A_5);
					_ = null;
					if (jo)
					{
						jn++;
						jo = false;
					}
					jl = string.Empty;
				}
				if (flag2 && flag3 && flag)
				{
					ab8().c(fz.b.b, "Restarting auto reference acquisition task but it was already running.");
					return ErrPublic.Generic;
				}
				if (flag2 && flag4 && !flag)
				{
					if (m2(ref A_2, ref A_3, p2) == ErrPublic.None)
					{
						ab8().c(fz.b.b, "Acquisition task stopped running. Task restarted");
					}
					else
					{
						ab8().c(fz.b.b, "Acquisition task stopped running. Attempt to restart it reulted in failure: " + A_3);
					}
					return ErrPublic.SpecAcquisition;
				}
				if (flag2 && !flag3)
				{
					return ErrPublic.None;
				}
				return m2(ref A_2, ref A_3, p2);
			}
			k2 = null;
			return ErrPublic.None;
		}
	}

	private p m2(string A_0, string A_1, n[] A_2, bool[] A_3, string A_4, ref string A_5, global::r.d A_6, l A_7, bool A_8, float[] A_9, bool A_10, int A_11, bool A_12, bool A_13, bool A_14, global::r.d.a.b A_15, int A_16, global::r.c A_17, bool A_18)
	{
		p p2;
		p result = (p2 = new p(u1(), A_15));
		((m)p2).a = m.a.g;
		p2.d = m.TaskExecutionType.Spectrometer;
		p2.n = A_2;
		p2.f = A_4;
		p2.g = A_6;
		p2.l = A_7;
		p2.v = A_0;
		p2.w = A_1;
		p2.z = A_3;
		p2.aa = A_8;
		p2.ab = A_9;
		p2.ac = A_10;
		p2.ah = A_11;
		p2.aj = A_12;
		p2.ak = A_13;
		p2.al = A_14;
		p2.an = A_16;
		if (A_17 == null)
		{
			p2.h = ja;
		}
		else
		{
			p2.h = A_17;
		}
		p2.aw = A_18;
		p2 = null;
		jl = string.Empty;
		return result;
	}

	public ErrPublic p9(string A_0, string A_1, n[] A_2, bool[] A_3, string A_4, ref string A_5, global::r.d A_6, l A_7, bool A_8, float[] A_9, bool A_10, int A_11, bool A_12, bool A_13, bool A_14, global::r.d.a.b A_15, int A_16, global::r.c A_17, bool A_18)
	{
		p a_ = m2(A_0, A_1, A_2, A_3, A_4, ref A_5, A_6, A_7, A_8, A_9, A_10, A_11, A_12, A_13, A_14, A_15, A_16, A_17, A_18);
		return m2(ref A_4, ref A_5, a_);
	}

	private void ue()
	{
		if (lz && hb.d0().c() == g2.a.n)
		{
			q q2 = new q(global::r.d.a.b.b);
			q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
			((m)q2).a = m.a.bx;
			q2.g = jh;
			_ = null;
			string A_ = null;
			string A_2 = null;
			m2(ref A_, ref A_2, q2);
		}
	}

	public void m2(bool A_0, bool A_1, global::r.d A_2, global::r.d.a.b A_3)
	{
		z2();
		q q2 = new q(A_3);
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q2).a = m.a.by;
		q2.j = new g4(A_0, A_1);
		q2.g = A_2;
		_ = null;
		string A_4 = null;
		string A_5 = null;
		m2(ref A_4, ref A_5, q2);
	}

	private ErrPublic m2(ip A_0, ref bool A_1, ref bool A_2, double A_3, bool A_4, ref int A_5, ref int A_6, ref float A_7, ref global::r.c A_8, global::r.d.a.b A_9)
	{
		checked
		{
			short num = (short)Math.Round(100.0 / A_3);
			hr A_10 = new hr(hc.dh().aw());
			int a_ = 0;
			if (A_4)
			{
				a_ = 1;
			}
			if (num < 1)
			{
				num = 1;
			}
			if (A_0.m2(ref A_1, ref A_2, xo(), a_, A_3, num, A_8, A_9) != f0.FIDeviceErr.None)
			{
				return ErrPublic.SpecAcquisition;
			}
			if (A_0.m2(ref A_10) != f0.FIDeviceErr.None)
			{
				return ErrPublic.SpecAcquisition;
			}
			double[] array = A_10.c0();
			if (A_4)
			{
				int num2 = A_10.c2() - 1;
				A_7 = float.MinValue;
				int num3 = num2;
				for (int num4 = 0; num4 <= num3; num4 += 50)
				{
					int num5 = num4 + 50 - 1;
					if (num5 > num2)
					{
						num5 = num2;
					}
					int num6 = num5 - 50 + 1;
					float num7 = m2(num6, num5, array, 50);
					if (num7 > A_7)
					{
						A_7 = num7;
						A_5 = num6;
						A_6 = num5;
					}
				}
				float num8 = float.MinValue;
				int num9 = A_5;
				int num10 = A_6;
				int num12 = default(int);
				for (int num11 = num9; num11 <= num10; num11++)
				{
					if (array[num11] > (double)num8)
					{
						num12 = num11;
						num8 = (float)array[num11];
					}
				}
				A_5 = num12 - 25;
				if (A_5 < 0)
				{
					A_5 = 0;
				}
				A_6 = A_5 + 50 - 1;
				if (A_6 > num2)
				{
					A_6 = num2;
					A_5 = A_6 - 50 + 1;
				}
			}
			A_7 = m2(A_5, A_6, array, 50);
			return ErrPublic.None;
		}
	}

	private float m2(int A_0, int A_1, double[] A_2, int A_3)
	{
		float num = 0f;
		for (int num2 = A_0; num2 <= A_1; num2 = checked(num2 + 1))
		{
			num += (float)A_2[num2];
		}
		return num / (float)A_3;
	}

	private ErrPublic m2(ip A_0, ref bool A_1, ref bool A_2, ref hr A_3, ref float A_4, ref bool A_5, int A_6, ref global::r.c A_7, global::r.d.a.b A_8, bool A_9, double A_10, bool A_11, bool A_12, int A_13, bool A_14, double A_15, float[] A_16, float[] A_17, float A_18, float A_19, Guid A_20)
	{
		return m2(A_0, ref A_1, ref A_2, ref A_3, ref A_4, ref A_5, A_6, ref A_7, A_8, A_9, A_10, A_11, A_12, A_13, null, null, null, null, null, A_14, A_15, A_16, A_17, A_18, A_19, A_20);
	}

	private ErrPublic m2(ip A_0, ref bool A_1, ref bool A_2, ref hr A_3, ref float A_4, ref bool A_5, int A_6, ref global::r.c A_7, global::r.d.a.b A_8, bool A_9, double A_10, bool A_11, bool A_12, int A_13, float[] A_14, int[] A_15, int[] A_16, double[] A_17, double[] A_18, bool A_19, double A_20, float[] A_21, float[] A_22, float A_23, float A_24, Guid A_25)
	{
		ErrPublic result = default(ErrPublic);
		try
		{
			double a_ = default(double);
			short a_2 = default(short);
			if (A_19)
			{
				a_ = A_20;
				a_2 = 1;
			}
			if (A_0.m2(ref A_1, ref A_2, xo(), A_6, ref A_7, A_8, jk, A_9, A_10, A_11, A_12, A_13, A_19, a_, a_2) == f0.FIDeviceErr.None)
			{
				if (A_2)
				{
					A_3.am(A_0: true);
				}
				if (!A_11 || !A_12)
				{
					int A_26 = 0;
					result = ((A_0.m2(ref A_3, ref A_26, ref A_4, A_5, A_11, A_14, A_15, A_16, A_17, A_18, jk, A_19, s3(hc.b8()) && !A_19, st(hc.b8()) && !A_19, A_21, A_22, A_23, A_24, A_18: false, A_25) != f0.FIDeviceErr.None) ? ErrPublic.SpecAcquisition : ErrPublic.None);
				}
				else
				{
					A_0.m2(ref A_4);
				}
			}
			else
			{
				result = ErrPublic.SpecAcquisition;
			}
		}
		catch (ai ai2)
		{
			ProjectData.SetProjectError(ai2);
			ai ai3 = ai2;
			throw ai3;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			result = ErrPublic.Generic;
			ab8().c(fz.b.b, "Exception caught in AcquireAndRetrieveSpectrum(). ", a_3);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private ErrPublic m2(ip A_0, ref bool A_1, ref bool A_2, ref hr A_3, int A_4, double A_5, short A_6, ref global::r.c A_7, global::r.d.a.b A_8)
	{
		ErrPublic result;
		try
		{
			if (A_0.m2(ref A_1, ref A_2, xo(), A_4, A_5, A_6, A_7, A_8) == f0.FIDeviceErr.None)
			{
				if (A_2)
				{
					A_3.am(A_0: true);
				}
				result = ((A_0.m2(ref A_3) != f0.FIDeviceErr.None) ? ErrPublic.SpecAcquisition : ErrPublic.None);
			}
			else
			{
				result = ErrPublic.SpecAcquisition;
			}
		}
		catch (ai ai2)
		{
			ProjectData.SetProjectError(ai2);
			ai ai3 = ai2;
			throw ai3;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = ErrPublic.Generic;
			ab8().c(fz.b.b, "Exception caught in AcquireAndRetrieveRawSpectra(). ", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void m2(ip A_0, bool A_1, ref float A_2, ref float A_3, ref float A_4, ref float A_5, ref float A_6)
	{
		int num = iu[0];
		bool a_ = iu[1] >= 0 && num >= 0 && (A_0 == iq[num][sj(num)] || (iq[num].Count > 1 && A_0 == iq[num][qh(num)]));
		A_0.m2(A_1, a_, ref A_2, ref A_3, ref A_4, ref A_5, ref A_6);
	}

	private void m2(ip A_0, bool A_1, int A_2, bool A_3, ref double A_4, ref double A_5)
	{
		if (g2.m(A_0.vz()) && A_0.wo() != 0.0)
		{
			A_4 = A_0.wo();
		}
		else
		{
			A_4 = A_0.vl();
		}
		A_5 = double.MaxValue;
		checked
		{
			int num = A_0.vy() - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (num2 != A_2 && A_0.m2(num2, A_0.vq()) && A_5 > A_0.sm(num2))
				{
					A_5 = A_0.sm(num2);
				}
			}
			if (A_4 > A_5)
			{
				A_4 = A_5;
			}
			if (A_1 && A_0.m2(A_2, A_0.vq()))
			{
				A_0.qh(A_2, A_1: false);
			}
			if (hc.b8().n(v6()) == global::h.MeasurementTimingType.Maximum && A_4 > A_0.vj())
			{
				A_4 = A_0.vj();
				while (A_0.sn(A_4) > A_0.vj())
				{
					A_4 -= 0.025;
				}
			}
			if (A_3 && A_4 > A_0.vk())
			{
				A_4 = A_0.vk();
			}
		}
	}

	private ErrPublic m2(ip A_0, float A_1, ref bool A_2, ref bool A_3, bool A_4, float A_5, double[] A_6, n A_7, global::r.c A_8, global::r.d.a.b A_9, int A_10, bool A_11, bool A_12)
	{
		return m2(A_0, A_1, ref A_2, ref A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10, A_11, A_12, 0.0);
	}

	private ErrPublic m2(ip A_0, float A_1, ref bool A_2, ref bool A_3, bool A_4, float A_5, double[] A_6, n A_7, global::r.c A_8, global::r.d.a.b A_9, int A_10, bool A_11, bool A_12, double A_13)
	{
		bool flag = true;
		float[] array = new float[1];
		hr A_14 = new hr(null);
		List<double> list = new List<double>();
		List<double> list2 = new List<double>();
		double num = A_0.u9();
		bool flag2 = p9(A_7);
		bool flag3 = m2(A_7);
		double[] array2 = new double[1];
		_ = new double[1];
		checked
		{
			ErrPublic result = default(ErrPublic);
			try
			{
				A_0.wz();
				if (A_0.vt())
				{
					if (A_0.so(A_0.vm()) == f0.FIDeviceErr.None)
					{
						return ErrPublic.None;
					}
					ab8().c(fz.b.a, "Error in DoAutoScaleIntegrationTime, attempting to set minimum integration time for strobe", Environment.StackTrace);
					return ErrPublic.Generic;
				}
				bool A_15 = true;
				bool flag4 = false;
				ip ip2 = A_0;
				double A_16 = ip2.vm();
				float A_17 = default(float);
				float A_18 = default(float);
				float A_19 = default(float);
				float A_20 = default(float);
				float A_21 = default(float);
				m2(A_0, flag2, ref A_17, ref A_18, ref A_19, ref A_20, ref A_21);
				double A_22 = default(double);
				double A_23 = default(double);
				if (global::jf.c(A_13, 0f))
				{
					m2(A_0, A_4, A_10, A_12, ref A_22, ref A_23);
				}
				else
				{
					A_22 = Math.Min(A_13, A_0.vl());
					A_23 = A_22;
				}
				if (A_12 && !A_0.u2())
				{
					if (A_0.so(A_22) == f0.FIDeviceErr.None)
					{
						return ErrPublic.None;
					}
					ab8().c(fz.b.a, "Error in DoAutoScaleIntegrationTime, attempting to set max integration time for USB1 Spectrometer", Environment.StackTrace);
					return ErrPublic.Generic;
				}
				if (flag3 && !A_12 && ip2.wo() == 0.0 && A_4)
				{
					if (A_5 > 0f)
					{
						double[] A_24 = null;
						Guid A_25 = default(Guid);
						int A_26 = default(int);
						A_0.m2(A_0: false, ref A_24, ref A_26, ref A_25);
						int num2 = A_26 - 1;
						array = new float[num2 + 1];
						int num3 = num2;
						for (int num4 = 0; num4 <= num3; num4++)
						{
							array[num4] = A_5;
						}
					}
					else
					{
						array = ip2.wp();
					}
				}
				float A_27 = 0f;
				float A_28 = default(float);
				bool A_29 = default(bool);
				float A_30 = default(float);
				float a_ = default(float);
				bool A_31 = default(bool);
				double A_32 = default(double);
				float A_33 = default(float);
				bool A_34 = default(bool);
				float A_35 = default(float);
				float A_36 = default(float);
				double A_37 = default(double);
				bool A_38 = default(bool);
				bool A_39 = default(bool);
				bool A_40 = default(bool);
				do
				{
					if (A_12 && A_28 > A_17 * 0.9f && Math.Abs((A_16 - num) / A_16) < 0.10000000149011612 && ip2.so(num) == f0.FIDeviceErr.None)
					{
						return ErrPublic.None;
					}
					if (ip2.so(A_16) == f0.FIDeviceErr.None)
					{
						result = ErrPublic.None;
					}
					flag4 = false;
					if (m2(A_0, ref A_3, ref A_2, ref A_14, 1, A_16, 1, ref A_8, A_9) == ErrPublic.None)
					{
						if (A_29)
						{
							if (!A_2)
							{
								if (A_4 && hc.b8().n(v6()) == global::h.MeasurementTimingType.Maximum && !ip2.m2(A_16, ip2.wo()) && A_16 < ip2.wo() && !ip2.m2(A_16, A_23) && A_16 < A_23)
								{
									ip2.qh(A_10, A_1: true);
								}
								return ErrPublic.None;
							}
							A_29 = false;
						}
						array2 = A_14.c0();
						A_14.cz();
						int num5 = A_14.c2();
						global::ip.m2(array2, num5, ref A_28, ref A_30);
						if (flag)
						{
							a_ = A_30;
						}
						ip2.m2(A_2, A_28, A_20, ref A_31, ref A_32, ref A_33, ref A_17, ref A_18, ref A_34);
						if (A_34)
						{
							return ErrPublic.LowSaturationIntensity;
						}
						if (flag3 && !A_12)
						{
							if (!A_2 && A_0.wo() == 0.0 && A_4)
							{
								A_28 = A_0.m2(array2, array, num5, k6, A_10);
								if (A_28 >= A_17 && A_28 <= A_18)
								{
									return ErrPublic.None;
								}
							}
							list.Add(A_16);
							list2.Add(A_28);
						}
						if (A_15)
						{
							ip2.m2(A_16, A_17, A_28, A_30, A_2, a_, flag, A_11, ref A_35, ref A_36, ref A_27, ref A_37, ref A_38);
							if (A_38)
							{
								return ErrPublic.SignalNotProportionalToIntTime;
							}
							ip2.m2(A_2, A_28, A_36, A_1, A_18, A_17, A_35, A_22, A_31, A_32, A_19, flag2, A_21, ref A_16, ref A_15, ref A_39, ref A_40, ref flag4, ref A_29);
							if (A_39)
							{
								int num6 = list.Count - 1;
								for (int num7 = 0; num7 <= num6; num7++)
								{
									ab8().c(fz.b.a, "Acquired spec with Tint=" + list[num7] + ", peak val=" + list2[num7]);
								}
								return ErrPublic.LightTooBright;
							}
							if (A_40)
							{
								return ErrPublic.NoLight;
							}
						}
						else
						{
							A_15 = false;
						}
						flag = false;
						continue;
					}
					return ErrPublic.SpecAcquisition;
				}
				while (A_15 || flag4);
				ip2 = null;
			}
			catch (ai ai2)
			{
				ProjectData.SetProjectError(ai2);
				ai ai3 = ai2;
				throw ai3;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				result = ErrPublic.Generic;
				ab8().c(fz.b.b, "Exception caught in DoAutoScaleIntegrationTime(). ", a_2);
				ProjectData.ClearProjectError();
			}
			finally
			{
				A_0.w0();
			}
			return result;
		}
	}

	public void m2(global::r.d A_0, double A_1, bool A_2, global::r.d.a.b A_3, int A_4)
	{
		float[] a_ = new float[checked(Enum.GetValues(typeof(global::h.h)).GetUpperBound(0) + 1)];
		string A_5 = "Reference";
		string a_2 = hu.a(ref A_5);
		n[] a_3 = m2(n.k, n.a);
		bool[] a_4 = p9(A_2, A_1: false);
		string A_6 = null;
		if (p9(a_2, "", a_3, a_4, null, ref A_6, A_0, null, A_8: false, a_, A_10: false, 1, A_12: true, A_13: false, A_14: false, A_3, A_4, null, A_18: false) != ErrPublic.None)
		{
			throw new ApplicationException("Error in AttemptTakeCTMRef");
		}
	}

	public void qh(global::r.d.a.b A_0, global::r.d A_1)
	{
		q q2 = new q(A_0);
		((m)q2).a = m.a.b4;
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		q2.g = A_1;
		string A_2 = null;
		string A_3 = null;
		m2(ref A_2, ref A_3, q2);
	}

	private void m2(q A_0)
	{
		ip a_ = uc();
		short A_1 = default(short);
		double A_2 = default(double);
		m2(a_, 0.0, ref A_1, ref A_2, A_0.d3());
		m2(A_2);
	}

	private bool ud()
	{
		int num = 0;
		checked
		{
			int num2 = iq[0].Count - 1;
			int index = default(int);
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (p9(hc.b8(), num3, 0))
				{
					index = num3;
					num++;
					if (num == 2)
					{
						return false;
					}
				}
			}
			if (num == 1)
			{
				return iq[0][index].ui();
			}
			return false;
		}
	}

	private ip uc()
	{
		int num = 0;
		checked
		{
			int num2 = iq[0].Count - 1;
			int index = default(int);
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (p9(hc.b8(), num3, 0))
				{
					index = num3;
					num++;
					if (num == 2)
					{
						break;
					}
				}
			}
			if (num == 1)
			{
				return iq[0][index];
			}
			if (num > 1)
			{
				return iq[0][jp[0]];
			}
			return null;
		}
	}

	private void m2(ip A_0, double A_1, ref short A_2, ref double A_3, global::r.d.a.b A_4)
	{
		hr A_5 = new hr(null);
		int num = 0;
		double num2 = A_0.vm();
		if (A_1 == 0.0)
		{
			A_1 = A_0.vl();
		}
		A_2 = 1;
		A_3 = num2 / 2.0;
		checked
		{
			double num3;
			bool A_7 = default(bool);
			bool A_8 = default(bool);
			do
			{
				num3 = double.MinValue;
				A_3 *= 2.0;
				double a_ = A_3;
				short a_2 = A_2;
				global::r.c A_6 = null;
				if (m2(A_0, ref A_7, ref A_8, ref A_5, 1, a_, a_2, ref A_6, A_4) != ErrPublic.None)
				{
					throw new Exception("Failed to AcquireAndRetrieveRawSpectraUnsmoothed in FindIntTimeAndNumAvgInBaseline.");
				}
				hr hr2 = A_5;
				int num4 = hr2.c0().Length - 1;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					if (hr2.c0()[num5] > num3)
					{
						num3 = hr2.c0()[num5];
					}
				}
				hr2 = null;
				num++;
			}
			while (num3 < 1000.0 && num < 10 && A_3 * 2.0 <= A_1);
			A_2 = (short)Math.Min((int)Math.Round(50.0 / A_3), 20);
			if (A_2 < 1)
			{
				A_2 = 1;
			}
		}
	}

	private void m2(double A_0)
	{
		Collection<m> collection = null;
		Collection<m> collection2 = null;
		p p2 = null;
		bool flag = default(bool);
		bool flag2 = default(bool);
		try
		{
			flag = Monitor.TryEnter(zz(), 300);
			if (!flag)
			{
				throw new ao("Timeout2 in UpdateOverrideTasksWithNewIntegrationTime.");
			}
			collection = zz();
			foreach (m item in collection)
			{
				if (item is p)
				{
					p2 = (p)item;
					if (p2.d == m.TaskExecutionType.Spectrometer && ((m)p2).a == m.a.c && p2.ax)
					{
						p2.ay = A_0;
					}
				}
			}
			flag2 = Monitor.TryEnter(zy(), 300);
			if (!flag2)
			{
				throw new ao("Timeout1 in UpdateOverrideTasksWithNewIntegrationTime.");
			}
			collection2 = zy();
			foreach (m item2 in collection2)
			{
				if (item2 is p)
				{
					p2 = (p)item2;
					if (p2.d == m.TaskExecutionType.Spectrometer && ((m)p2).a == m.a.c && p2.ax)
					{
						p2.ay = A_0;
					}
				}
			}
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(collection);
			}
			if (flag2)
			{
				Monitor.Exit(collection2);
			}
		}
	}

	public void m2(global::r.d A_0, global::r.c A_1, global::r.d.a.b A_2)
	{
	}

	public void m2(global::r.d A_0, float[] A_1, bool A_2, global::r.d.a.b A_3, int A_4, bool A_5, global::r.c A_6, Point A_7, bool A_8)
	{
		bool flag = wj();
		if (A_5 && hb.b8().a(v4(), uq()))
		{
			p9(v.b, A_0, A_2: true, A_1, A_4: false, A_3);
			return;
		}
		n n2 = n.a;
		if (flag && iv[1])
		{
			n2 = n.d;
		}
		hg a_ = hb;
		bool a_2 = zp() == g2.a.b;
		n a_3 = n2;
		bool A_9 = false;
		global::h h10 = m2(a_, a_2, n.c, a_3, ref A_9);
		string A_10 = "Reference";
		string a_4 = hu.a(ref A_10);
		n[] a_5 = m2(n.c, n2, A_2: false, h10);
		bool[] a_6 = m2(A_2, A_1: false, h10);
		string A_11 = null;
		if (p9(a_4, "", a_5, a_6, null, ref A_11, A_0, null, A_8: false, A_1, A_10: false, 1, A_12: true, A_13: false, A_14: false, A_3, A_4, A_6, flag) != ErrPublic.None)
		{
			throw new ApplicationException("Error in AttemptTakeRefPrim");
		}
	}

	public void m2(global::r.d A_0, bool A_1, bool A_2, global::r.d.a.b A_3, global::r.c A_4)
	{
		if (wj())
		{
			throw new ApplicationException("AttemptTakeBacPrimBacSec should not be called when persistent auto-baseline settings active");
		}
		if (A_2 && hb.b8().a(v4(), uq()))
		{
			p9(v.c, A_0, A_2: false, null, A_1, A_3);
			return;
		}
		hg a_ = hb;
		bool a_2 = zp() == g2.a.b;
		bool A_5 = false;
		global::h h10 = m2(a_, a_2, n.d, n.d, ref A_5);
		float[] a_3 = new float[checked(Enum.GetValues(typeof(global::h.h)).GetUpperBound(0) + 1)];
		string A_6 = "Background";
		string a_4 = hu.a(ref A_6);
		n[] a_5 = m2(n.d, n.d, A_2: false, h10);
		bool[] a_6 = m2(A_0: false, A_1: false, h10);
		string A_7 = null;
		if (p9(a_4, "", a_5, a_6, null, ref A_7, A_0, null, A_8: false, a_3, A_10: false, 1, A_12: true, A_13: true, A_1, A_3, 0, A_4, A_18: false) != ErrPublic.None)
		{
			throw new ApplicationException("Error in AttemptTakeBacPrimBacSec");
		}
	}

	public void p9(global::r.d A_0, bool A_1, bool A_2, global::r.d.a.b A_3, global::r.c A_4)
	{
		bool a_ = wj();
		bool flag = zp() == g2.a.b;
		hg a_2 = hb;
		bool A_5 = false;
		global::h h10 = m2(a_2, flag, n.e, n.c, ref A_5);
		float[] a_3 = new float[checked(Enum.GetValues(typeof(global::h.h)).GetUpperBound(0) + 1)];
		string A_6 = "Background";
		string a_4 = hu.a(ref A_6);
		n[] a_5 = m2(n.e, n.c, A_2: false, h10);
		bool[] a_6 = m2(flag && A_2, A_2, h10);
		string A_7 = null;
		if (p9(a_4, "", a_5, a_6, null, ref A_7, A_0, null, A_8: false, a_3, A_10: false, 1, A_12: true, A_13: true, A_1, A_3, 0, A_4, a_) != ErrPublic.None)
		{
			throw new ApplicationException("Error in AttemptTakeBac2PrimRefSec");
		}
	}

	public void m2(global::r.d A_0, bool A_1, global::r.d.a.b A_2, bool A_3, global::r.c A_4)
	{
		float[] a_ = new float[checked(Enum.GetValues(typeof(global::h.h)).GetUpperBound(0) + 1)];
		if (A_3)
		{
			string A_5 = "CTMMultiBackground";
			string a_2 = hu.a(ref A_5);
			n[] a_3 = m2(n.n, n.n);
			bool[] a_4 = p9(A_0: true, A_1: true);
			string A_6 = null;
			if (p9(a_2, "", a_3, a_4, null, ref A_6, A_0, null, A_8: false, a_, A_10: false, 1, A_12: true, A_13: true, A_1, A_2, 0, A_4, A_18: false) != ErrPublic.None)
			{
				throw new ApplicationException("Error in AttemptTakeCTMBac: CTMMultiBackground");
			}
		}
		else
		{
			string A_5 = "CTMSingleBackground";
			string a_5 = hu.a(ref A_5);
			n[] a_6 = m2(n.m, n.m);
			bool[] a_7 = p9(A_0: false, A_1: false);
			string A_6 = null;
			if (p9(a_5, "", a_6, a_7, null, ref A_6, A_0, null, A_8: false, a_, A_10: false, 1, A_12: true, A_13: true, A_1, A_2, 0, A_4, A_18: false) != ErrPublic.None)
			{
				throw new ApplicationException("Error in AttemptTakeCTMBac: CTMSingleBackground");
			}
		}
	}

	public void m2(global::r.d A_0, bool A_1, global::r.d.a.b A_2, global::r.c A_3, Point A_4)
	{
		if (A_1 && hb.b8().a(v4(), uq()))
		{
			p9(v.d, A_0, A_2: true, null, A_4: false, A_2);
			return;
		}
		float[] a_ = new float[checked(Enum.GetValues(typeof(global::h.h)).GetUpperBound(0) + 1)];
		string A_5 = "Sample";
		string a_2 = hu.a(ref A_5);
		n[] a_3 = m2(n.f, n.f);
		bool[] a_4 = p9(A_0: true, A_1: false);
		string A_6 = null;
		if (p9(a_2, "", a_3, a_4, null, ref A_6, A_0, null, A_8: true, a_, A_10: false, 1, A_12: true, A_13: false, A_14: false, A_2, 0, A_3, A_18: false) != ErrPublic.None)
		{
			throw new ApplicationException("Error in AttemptTakeSampleSensitivity");
		}
	}

	public void m2(global::r.d A_0, global::r.d.a.b A_1, global::r.c A_2)
	{
		float[] a_ = new float[checked(Enum.GetValues(typeof(global::h.h)).GetUpperBound(0) + 1)];
		string A_3 = "BaselineAutoRefRefSpectrum";
		string a_2 = hu.a(ref A_3);
		n[] a_3 = m2(n.g, n.g);
		bool[] a_4 = p9(A_0: true, A_1: false);
		string A_4 = null;
		if (p9(a_2, "", a_3, a_4, null, ref A_4, A_0, null, A_8: false, a_, A_10: false, 1, A_12: true, A_13: false, A_14: false, A_1, 0, A_2, A_18: false) != ErrPublic.None)
		{
			throw new ApplicationException("Error in AttemptTakeAutoRefBK7Spec");
		}
	}

	public ErrPublic p9(global::r.d A_0, global::r.d.a.b A_1, global::r.c A_2)
	{
		float[] a_ = new float[checked(Enum.GetValues(typeof(global::h.h)).GetUpperBound(0) + 1)];
		string A_3 = "FiberTipSpectrum";
		string a_2 = hu.a(ref A_3);
		n[] a_3 = m2(n.h, n.h);
		bool[] a_4 = p9(A_0: false, A_1: false);
		string A_4 = null;
		return p9(a_2, "", a_3, a_4, null, ref A_4, A_0, null, A_8: false, a_, A_10: false, 1, A_12: true, A_13: false, A_14: true, A_1, 0, A_2, A_18: false);
	}

	public void m2(int A_0, bool A_1, int A_2, global::r.d.a.b A_3)
	{
		h.a a10 = new h.a(A_3, 0L, hc.dh().aw());
		h.a a11 = a10;
		a11.x = true;
		a11.h = gt;
		((global::r.d.a)a11).a = global::r.d.a.a.a;
		if (A_1)
		{
			a11.w = iq[A_0][sj(A_0)].m2(xo(), A_2, jk, hc.dh().aw());
		}
		else
		{
			a11.w = iq[A_0][qh(A_0)].m2(xo(), A_2, jk, hc.dh().aw());
		}
		a11.w.r(u1());
		a11 = null;
		i9.d(gt, a10);
		jg.d(gt, new global::r.d.a(A_3, 0L));
	}

	public hr m2(int A_0, bool A_1, int A_2)
	{
		if (A_1)
		{
			return iq[A_0][sj(A_0)].m2(xo(), A_2, jk, hc.dh().aw());
		}
		return iq[A_0][qh(A_0)].m2(xo(), A_2, jk, hc.dh().aw());
	}

	public void m2(int A_0, bool A_1, global::r.d.a.b A_2)
	{
		h.a a10 = new h.a(A_2, 0L, hc.dh().aw());
		h.a a11 = a10;
		a11.x = true;
		a11.h = gt;
		((global::r.d.a)a11).a = global::r.d.a.a.a;
		if (A_1)
		{
			a11.w = iq[A_0][sj(A_0)].m2(xo(), jk, hc.dh().aw());
		}
		else
		{
			a11.w = iq[A_0][qh(A_0)].m2(xo(), jk, hc.dh().aw());
		}
		a11.w.r(u1());
		a11 = null;
		i9.d(gt, a10);
		jg.d(gt, new global::r.d.a(A_2, 0L));
	}

	public hr m2(int A_0, bool A_1)
	{
		if (A_1)
		{
			return iq[A_0][sj(A_0)].m2(xo(), jk, hc.dh().aw());
		}
		return iq[A_0][qh(A_0)].m2(xo(), jk, hc.dh().aw());
	}

	private void ub()
	{
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			for (int num = 0; num <= upperBound; num++)
			{
				int num2 = iq[num].Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (p9(hc.b8(), num3, num))
					{
						ip ip2 = iq[num][num3];
						int num4 = ip2.vx() - 1;
						for (int num5 = 0; num5 <= num4; num5++)
						{
							ip2.m2(xo(), num5, hc.dh().aw());
						}
						ip2 = null;
					}
				}
			}
		}
	}

	[SpecialName]
	public string m2(int A_0, global::f.b A_1, int A_2)
	{
		return iq[A_0][p9(A_0, A_1)].s4(A_2);
	}

	public void p9(int A_0, bool A_1, global::r.d.a.b A_2)
	{
		h.a a10 = new h.a(global::r.d.a.b.a, 0L, hc.dh().aw());
		h.a a11 = a10;
		a11.x = true;
		a11.h = gt;
		((global::r.d.a)a11).a = global::r.d.a.a.a;
		if (A_1)
		{
			a11.w = iq[A_0][sj(A_0)].m2(xo(), hc.dh().aw());
		}
		else
		{
			a11.w = iq[A_0][qh(A_0)].m2(xo(), hc.dh().aw());
		}
		a11.w.r(u1());
		a11 = null;
		i9.d(gt, a10);
		jg.d(gt, new global::r.d.a(A_2, 0L));
	}

	public hr p9(int A_0, bool A_1)
	{
		if (A_1)
		{
			return iq[A_0][sj(A_0)].m2(xo(), hc.dh().aw());
		}
		return iq[A_0][qh(A_0)].m2(xo(), hc.dh().aw());
	}

	public void xm()
	{
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			for (int num = 0; num <= upperBound; num++)
			{
				int num2 = iq[num].Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (p9(hc.b8(), num3, num))
					{
						iq[num][num3].p9(xo(), hc.dh().aw());
						_ = null;
					}
				}
			}
		}
	}

	[SpecialName]
	public string qh(int A_0, global::f.b A_1)
	{
		return iq[A_0][p9(A_0, A_1)].xj();
	}

	public void m2(int A_0, bool A_1, ref Collection<double[]> A_2, ref Collection<DateTime[]> A_3, ref int[] A_4)
	{
		if (iq != null && iq.GetUpperBound(0) >= A_0 && iq[A_0] != null)
		{
			int num = ((!A_1) ? qh(A_0) : sj(A_0));
			if (iq[A_0].Count > num)
			{
				iq[A_0][num].m2(ref A_2, ref A_3, ref A_4);
			}
		}
	}

	[SpecialName]
	public string qh(int A_0, bool A_1)
	{
		if (A_1)
		{
			return iq[A_0][sj(A_0)].yp();
		}
		return iq[A_0][qh(A_0)].yp();
	}

	public void qh(int A_0, bool A_1, global::r.d.a.b A_2)
	{
		h.a a10 = new h.a(A_2, 0L, hc.dh().aw());
		h.a a11 = a10;
		a11.x = true;
		a11.h = gt;
		((global::r.d.a)a11).a = global::r.d.a.a.a;
		if (A_1)
		{
			a11.w = iq[A_0][sj(A_0)].qh(xo(), hc.dh().aw());
		}
		else
		{
			a11.w = iq[A_0][qh(A_0)].qh(xo(), hc.dh().aw());
		}
		a11.w.r(u1());
		a11 = null;
		i9.d(gt, a10);
		jg.d(gt, new global::r.d.a(A_2, 0L));
	}

	public hr sj(int A_0, bool A_1)
	{
		if (A_1)
		{
			return iq[A_0][sj(A_0)].qh(xo(), hc.dh().aw());
		}
		return iq[A_0][qh(A_0)].qh(xo(), hc.dh().aw());
	}

	public void xn()
	{
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			for (int num = 0; num <= upperBound; num++)
			{
				int num2 = iq[num].Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (p9(hc.b8(), num3, num))
					{
						iq[num][num3].sj(xo(), hc.dh().aw());
						_ = null;
					}
				}
			}
		}
	}

	[SpecialName]
	public string sj(int A_0, global::f.b A_1)
	{
		return iq[A_0][p9(A_0, A_1)].xk();
	}

	public ew.a xo()
	{
		ew.a a10 = ew.a.e;
		if (iq == null && hj != null)
		{
			return hj.aj();
		}
		if (iq == null)
		{
			return ew.a.a;
		}
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (iq[num] == null || iq[num].Count <= 0)
			{
				continue;
			}
			foreach (ip item in iq[num])
			{
				if ((uint)item.abk().FWOemCode < (uint)a10)
				{
					a10 = (ew.a)item.abk().FWOemCode;
				}
			}
		}
		return a10;
	}

	private Collection<h6> ua()
	{
		int a_ = ((iq != null) ? iq.GetUpperBound(0) : (-1));
		return m2(0, a_, A_2: false, A_3: false);
	}

	private Collection<h6> m2(int A_0, bool A_1, bool A_2)
	{
		return m2(A_0, A_0, A_1, A_2);
	}

	private static void m2(Collection<h6> A_0, h6 A_1)
	{
		bool flag = true;
		foreach (h6 item in A_0)
		{
			if (Operators.CompareString(A_1.abn(), item.abn(), TextCompare: false) == 0)
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			A_0.Add(A_1);
		}
	}

	private void m2(Collection<h6> A_0, int A_1, int A_2, List<int> A_3, List<global::f.b> A_4, bool A_5)
	{
		if (iq == null)
		{
			return;
		}
		if ((A_3 != null || A_4 != null) && A_0.Count > 0)
		{
			throw new ax("usbDevices collection must be empty if submoduleIdxList or specIdxList is supplied");
		}
		checked
		{
			for (int num = A_1; num <= A_2; num++)
			{
				if (iq[num] == null)
				{
					continue;
				}
				int num2 = iq[num].Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					h6 a_ = iq[num][num3];
					int count = A_0.Count;
					m2(A_0, a_);
					if (A_0.Count != count)
					{
						A_3?.Add(num);
						A_4?.Add(so(num, num3));
					}
				}
			}
		}
	}

	private Collection<h6> m2(int A_0, int A_1, bool A_2, bool A_3)
	{
		Collection<h6> collection = new Collection<h6>();
		if (i0 != null)
		{
			collection.Add(i0);
		}
		if (@is != null)
		{
			foreach (@in item in @is)
			{
				m2(collection, item);
			}
		}
		m2(collection, A_0, A_1, null, null, A_3);
		if (A_2)
		{
			if (ip != null)
			{
				collection.Add(ip);
			}
			if (ik != null)
			{
				collection.Add(ik.d());
			}
		}
		return collection;
	}

	public Collection<h6.c> m2(int A_0, bool A_1, bool A_2, bool A_3)
	{
		Collection<h6.c> collection = new Collection<h6.c>();
		checked
		{
			foreach (h6 item in m2(A_0, A_1, A_3))
			{
				h6.c c10 = item.abl();
				bool flag = false;
				if (!A_2)
				{
					c10.b7 = a2.a.c(null, c10.a, global::i7.e.a6);
				}
				if (iq != null)
				{
					int num = iq[A_0].Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						if (iq[A_0][num2] == item)
						{
							c10.b2 = true;
							c10.b3 = num2;
							c10.b8 = h6.b.b;
							flag = true;
							break;
						}
					}
				}
				if (!flag && @is != null)
				{
					int num3 = @is.Count - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						if (@is[num4] == item)
						{
							c10.b4 = true;
							c10.b5 = num4;
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					if (ip != null && ip == item)
					{
						c10.b6 = true;
					}
					else if (ik != null && ik.d() == item)
					{
						c10.b6 = true;
					}
				}
				collection.Add(c10);
			}
			return collection;
		}
	}

	public Collection<string> xp()
	{
		Collection<string> collection = new Collection<string>();
		foreach (h6 item in ua())
		{
			collection.Add(item.abn());
		}
		return collection;
	}

	public Collection<h6.d> tl(int A_0)
	{
		Collection<h6.d> collection = new Collection<h6.d>();
		foreach (h6 item in m2(A_0, A_1: true, A_2: true))
		{
			collection.Add(item.abm());
		}
		return collection;
	}

	public Collection<@in.b> xq()
	{
		Collection<@in.b> collection = new Collection<@in.b>();
		if (@is != null)
		{
			foreach (@in item in @is)
			{
				collection.Add(item.t6());
			}
		}
		return collection;
	}

	public Collection<@in.c> xr()
	{
		Collection<@in.c> collection = new Collection<@in.c>();
		if (@is != null)
		{
			foreach (@in item in @is)
			{
				collection.Add(item.t7());
			}
		}
		return collection;
	}

	[SpecialName]
	public bool xs()
	{
		return st(hb);
	}

	[SpecialName]
	public bool st(hg A_0)
	{
		if (A_0.b5() || A_0.dh().av(null) || A_0.dh().az(null) || ii.f() <= 0 || !A_0.dh().a0(null))
		{
			if (iq != null && iq[0] != null && iq[0][0] != null)
			{
				return iq[0][0].ze();
			}
			return false;
		}
		return true;
	}

	[SpecialName]
	public float st(int A_0, int A_1)
	{
		return iq[A_0][A_1].u7();
	}

	public void m2(h6.b A_0, int A_1, int A_2, ref bool A_3, ref float A_4, ref float A_5, ref bool A_6, ref float A_7)
	{
		p9(A_0, A_1, A_2).m2(ref A_3, ref A_4, ref A_5, ref A_6, ref A_7);
	}

	[SpecialName]
	public float sm(int A_0, global::f.b A_1)
	{
		return iq[A_0][p9(A_0, A_1)].xx();
	}

	[SpecialName]
	public float sn(int A_0, global::f.b A_1)
	{
		return iq[A_0][p9(A_0, A_1)].xy();
	}

	private bool m2(ip A_0, p A_1, bool A_2, bool A_3, int A_4, global::r.c A_5, global::r.d.a.b A_6)
	{
		if (A_2 || A_3)
		{
			if (A_1.r & (hc.b8().n(v6()) != global::h.MeasurementTimingType.Manual))
			{
				global::h.h h10 = global::h.h.a;
				if (ix[A_4] == global::h.f.c)
				{
					h10 = global::h.h.b;
				}
				if (m2(A_0, 1f, ref A_1.q, ref A_1.r, A_4: false, A_1.ab[(int)h10], null, A_1.n[A_4], A_5, A_6, 0, A_3, A_3) != ErrPublic.None)
				{
					bool flag = A_1.l != null && A_1.l == k2;
					if (!flag)
					{
						ab8().c(fz.a.b, "USBSpecAcquireAutoIntErrorFmt3", A_1.q, A_1.r, A_0.yq());
					}
					return A_3 || flag;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	private bool m2(bool A_0, ref g.a A_1, ref p A_2)
	{
		if (A_0)
		{
			A_1.j = global::r.g.a.a.l;
			((global::r.d.a)A_1).a = global::r.d.a.a.b;
			if (A_2.l != null)
			{
				A_2.l.q((int)A_1.j, global::r.d.a.a.b, A_2: true);
			}
			return true;
		}
		return false;
	}

	public ErrPublic m2(string A_0, string A_1, hr.b A_2, int A_3)
	{
		ErrPublic result;
		try
		{
			if (A_2 == hr.b.h || A_2 == hr.b.i)
			{
				hg.cf(A_0, A_3).j(A_1);
			}
			result = ErrPublic.None;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			result = ErrPublic.Generic;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[SpecialName]
	public global::r.d xt()
	{
		return i9;
	}

	[SpecialName]
	public global::r.c xu()
	{
		return ja;
	}

	[SpecialName]
	public global::r.c xv()
	{
		return jj;
	}

	[SpecialName]
	public global::r.c xw()
	{
		return ji;
	}

	[SpecialName]
	public global::r.d xx()
	{
		return jb;
	}

	[SpecialName]
	public global::r.d xy()
	{
		return je;
	}

	[SpecialName]
	public global::r.d xz()
	{
		return jf;
	}

	[SpecialName]
	public global::r.d x0()
	{
		return k3;
	}

	[SpecialName]
	public global::r.d x1()
	{
		return jg;
	}

	[SpecialName]
	public global::r.d x2()
	{
		return jh;
	}

	private void t9()
	{
		if (iq == null)
		{
			return;
		}
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (iq[num] == null || iq[num].Count <= 0)
			{
				continue;
			}
			foreach (ip item in iq[num])
			{
				item.yi();
			}
		}
		ul();
		so(A_0: true);
	}

	private void t8()
	{
		if (!vk())
		{
			return;
		}
		int num = p9(global::h.f.a);
		int num2 = p9(global::h.f.b);
		if (iq == null || iq[num] == null || iq[num].Count <= 0 || iq[num2] == null || iq[num2].Count <= 0 || iq[num].Count != iq[num2].Count)
		{
			return;
		}
		global::f.b b10 = ((iq[num].Count == 2) ? global::f.b.c : global::f.b.b);
		global::f.b b11 = b10;
		int A_3 = default(int);
		int A_5 = default(int);
		int A_7 = default(int);
		int A_10 = default(int);
		Guid A_11 = default(Guid);
		int A_12 = default(int);
		Guid A_13 = default(Guid);
		for (global::f.b b12 = global::f.b.b; b12 <= b11; b12++)
		{
			int index = p9(num, b12);
			int num3;
			if (iq[num2].Count > 1)
			{
				if (iq[num].Count > 1)
				{
					num3 = p9(num2, b12);
				}
				else
				{
					double[] A_ = null;
					int num4 = p9(num2, global::f.b.b);
					ip obj = iq[num2][num4];
					Guid A_2 = default(Guid);
					obj.m2(A_0: false, ref A_, ref A_3, ref A_2);
					double[] A_4 = null;
					int num5 = p9(num2, global::f.b.c);
					ip obj2 = iq[num2][num5];
					A_2 = default(Guid);
					obj2.m2(A_0: false, ref A_4, ref A_5, ref A_2);
					double[] A_6 = null;
					ip obj3 = iq[num][0];
					A_2 = default(Guid);
					obj3.m2(A_0: false, ref A_6, ref A_7, ref A_2);
					num3 = ((!(global::jf.a(A_6, A_7, A_, A_3) > global::jf.a(A_6, A_7, A_4, A_5))) ? num5 : num4);
				}
			}
			else
			{
				num3 = 0;
			}
			if (iq[num][index] != null && iq[num2][num3] != null && (i1 == null || i1.Count <= (int)b12 || i1[(int)b12] == null || i5[(int)b12] != iq[num][index].xp() || i6[(int)b12] != iq[num2][num3].xp()))
			{
				double[] A_8 = null;
				double[] A_9 = null;
				iq[num][index].m2(A_0: false, ref A_8, ref A_10, ref A_11);
				int num6 = checked(A_10 - 1);
				iq[num2][num3].m2(A_0: false, ref A_9, ref A_12, ref A_13);
				if (i1 == null)
				{
					i1 = new Collection<int[]>();
					i2 = new Collection<int[]>();
					i3 = new Collection<double[]>();
					i4 = new Collection<double[]>();
					i5 = new Collection<Guid>();
					i6 = new Collection<Guid>();
					i7 = new Collection<int>();
				}
				while (i1.Count <= (int)b12)
				{
					i1.Add(null);
					i2.Add(null);
					i3.Add(null);
					i4.Add(null);
					i5.Add(default(Guid));
					i6.Add(default(Guid));
					i7.Add(0);
				}
				if (i1[(int)b12] == null || i1[(int)b12].GetUpperBound(0) != num6)
				{
					i1[(int)b12] = new int[checked(num6 + 1)];
					i2[(int)b12] = new int[checked(num6 + 1)];
					i3[(int)b12] = new double[checked(num6 + 1)];
					i4[(int)b12] = new double[checked(num6 + 1)];
				}
				b1.FIInterpolatePrepare(ref A_9[0], A_12, ref A_8[0], A_10, ref i1[(int)b12][0], ref i2[(int)b12][0], ref i3[(int)b12][0], ref i4[(int)b12][0]);
				i5[(int)b12] = A_11;
				i6[(int)b12] = A_13;
				i7[(int)b12] = num3;
			}
		}
	}

	public hr m2(hr A_0, int A_1, bool A_2, global::r.d.a.b A_3, bool A_4)
	{
		hg hg2 = null;
		hg2 = ((!zi()) ? hb : hl.ad()[A_1]);
		return m2(A_0, hg2, A_2, A_3, A_4);
	}

	private hr m2(hr A_0, hg A_1, bool A_2, global::r.d.a.b A_3, bool A_4)
	{
		return m2(A_0, A_1, A_2, 0, A_3, A_4);
	}

	private hr m2(hr A_0, hg A_1, bool A_2, int A_3, global::r.d.a.b A_4, bool A_5)
	{
		hr hr2 = null;
		checked
		{
			if (A_0.cu().q() == null && A_0.cv() != null)
			{
				if (A_1 == hc && A_1.d3() && (!A_0.ch || Operators.CompareString(A_0.ci, A_1.d4(), TextCompare: false) != 0) && hr.r(A_0.cj(), A_1: false) && (A_0.cj() == hr.b.c || A_0.cj() == hr.b.e) && A_0.cu().m() == 0f)
				{
					eo eo2 = new eo();
					eo2.at(eo.at());
					hg hg2 = new hg(eo2, global::hg.b4());
					hi hi2 = new hi(eo2);
					hi2.ew(2);
					gc A_6 = new gc();
					A_6.af("Air");
					hi2.au(ref A_6);
					A_6 = new gc();
					A_6.af(A_1.d4());
					hi2.au(ref A_6);
					hi2.d7(A_0.cz()[0]);
					hi2.d6(A_0.cz()[A_0.c2() - 1]);
					hi2.d9(0, A_1: true);
					hi2.el(A_0: true);
					hg2.bu(hi2);
					hg2.bx(1);
					Collection<hr> collection = new Collection<hr>();
					Collection<hc> A_7 = new Collection<hc>();
					string A_8 = null;
					hr2 = ((!A_2) ? A_0.cw() : A_0);
					collection.Add(hr2);
					A_7.Add(new hc());
					if (m2(collection, zj(), ref A_7, A_3: false, A_4, hg2, 5, A_7: true, A_8: false, ref A_8, null, A_11: true) != ErrPublic.None)
					{
						throw new Exception("Error attempting to compute theoretical backside reflectance. User message is: " + A_8);
					}
					double[] array = new double[hr2.c2() - 1 + 1];
					f6.BRElimination(1E-06f, hr2.c2(), ref hr2.cv()[0], ref A_7[0].cs().c0()[0], ref array[0]);
					hr2.cf = 100000000.0;
					hr2.af(array);
					hr2.ch = true;
					hr2.ci = A_1.d4();
				}
				eo.a a_ = null;
				bool flag = false;
				if (global::hg.bu(A_0, A_1, v6(), flag, A_5))
				{
					if (hr2 == null)
					{
						hr2 = ((!A_2) ? A_0.cw() : A_0);
						hr2.ch = false;
					}
					hr hr3 = hr2;
					double[] array2 = new double[hr3.c2() - 1 + 1];
					double[] array3 = ((!hr2.ch) ? hr3.cv() : hr3.c0());
					if (eo.at(v6(), flag, a_) || A_5)
					{
						hr3.af(new double[hr3.c2() - 1 + 1]);
						double[] array4 = new double[hr3.c2() - 1 + 1];
						int num = hr3.c2() - 1;
						for (int num2 = 0; num2 <= num; num2++)
						{
							array4[num2] = (float)hr3.cv()[num2];
						}
						if (A_1.dy() > hr3.c2() - 1)
						{
							A_1.b1(hr3.c2() - 1);
						}
						f6.BoxSmoothSpectrum(A_1.dy(), ref array4[0], hr3.c2(), ref hr3.c0()[0]);
						hr3.cg = A_1.dy();
					}
					else
					{
						f6.SmoothSpectrumGivenThickness(A_1.dx(), ref hr3.cz()[0], ref array3[0], hr3.c2(), ref array2[0]);
						hr3.af(array2);
						hr3.cf = A_1.dx();
						if (hr3.bl() != null)
						{
							hr3.r(m2(hr3.bl(), A_1, A_2, A_4, A_4: false));
						}
						if (hr3.bm() != null && hr3.bm().Count > 0)
						{
							int num3 = hr3.bm().Count - 1;
							for (int num4 = 0; num4 <= num3; num4++)
							{
								hr3.r(m2(hr3.bm()[num4], A_1, A_2, A_4, A_4: false), num4);
							}
						}
					}
					hr3 = null;
				}
				else if (hr2 == null)
				{
					hr2 = A_0;
				}
			}
			else if (((A_3 == 0 && A_0.cg != A_1.dy()) || (A_3 > 0 && A_0.cg != A_3)) && A_0.cv() != null && A_0.cu().q() != null)
			{
				hr2 = ((!A_2) ? A_0.cw() : A_0);
				hr hr4 = hr2;
				int a_2 = ((A_3 <= 0) ? A_1.dy() : A_3);
				hr4.af(new double[hr4.c2() - 1 + 1]);
				double[] array5 = new double[hr4.c2() - 1 + 1];
				int num5 = hr4.c2() - 1;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					array5[num6] = (float)hr4.cv()[num6];
				}
				f6.BoxSmoothSpectrum(a_2, ref array5[0], hr4.c2(), ref hr4.c0()[0]);
				hr4.cg = a_2;
				hr4 = null;
			}
			else
			{
				hr2 = A_0;
			}
			return hr2;
		}
	}

	public bool x3()
	{
		return m2(hb);
	}

	private bool m2(hg A_0)
	{
		if (iq == null)
		{
			return false;
		}
		int upperBound = iq.GetUpperBound(0);
		if (x4())
		{
			return true;
		}
		if (A_0.d0().c() == g2.a.b)
		{
			return false;
		}
		int num = upperBound;
		for (int num2 = 0; num2 <= num; num2 = checked(num2 + 1))
		{
			if (iq[num2] != null)
			{
				bool a_ = so(num2);
				Collection<ip> collection = iq[num2];
				if (collection.Count <= 0 || A_0.d0().a(ix[num2]))
				{
					return true;
				}
				if (collection.Count > 1 && A_0.b8().a(num2).b(a_) != global::f.a.b && A_0.b8().a(num2).b(a_) != global::f.a.c)
				{
					return true;
				}
				collection = null;
			}
		}
		return false;
	}

	public bool x4()
	{
		if (iq == null)
		{
			return false;
		}
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (p9(num))
			{
				return true;
			}
		}
		return false;
	}

	private bool p9(int A_0)
	{
		if (iq[A_0] == null)
		{
			return false;
		}
		Collection<ip> collection = iq[A_0];
		return collection.Count <= 0 || collection[0].xs() == FMUSBDeviceType.FMUSBDeviceIRHama || (collection[0].xs() == FMUSBDeviceType.FIUSB2DeviceSpecNIR2 && !collection[0].u2()) || collection[0].zy();
	}

	public bool m2(ref string A_0)
	{
		int num = 0;
		A_0 = null;
		checked
		{
			if (hc.d0().c(global::h.f.a))
			{
				if (iq == null || iq[0] == null)
				{
					return false;
				}
				Collection<ip> collection = iq[0];
				float num4 = default(float);
				float num5 = default(float);
				if (collection.Count > 0)
				{
					int num2 = collection.Count - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						ip ip2 = collection[num3];
						if (p9(hc.b8(), num3, 0))
						{
							num++;
							num4 = ip2.vu();
							num5 = ip2.vv();
						}
					}
				}
				collection = null;
				switch (num)
				{
				case 0:
				{
					string A_1 = "CTMActiveNoSpecWarning";
					A_0 = hu.a(ref A_1);
					return false;
				}
				case 1:
				{
					if (hc.d0().s() == null)
					{
						string A_1 = "CTMActiveNoOpticWarning";
						A_0 = hu.a(ref A_1);
						return false;
					}
					cf cf2 = hc.d0().s();
					double num6 = ((!(cf2.q() < (double)num4)) ? ((double)num5 - cf2.q()) : (cf2.r() - (double)num4));
					if (iq[0].Count > 1 && (num6 < 0.0 || num6 / (double)(num5 - num4) < 0.5))
					{
						string A_1 = "CTMActiveRangeWarningFmt";
						string format = hu.a(ref A_1);
						object[] obj = new object[5]
						{
							cf2.q().ToString("0"),
							cf2.r().ToString("0"),
							num4.ToString("0"),
							num5.ToString("0"),
							null
						};
						A_1 = "CTMIncorrectSpectrometerSelected";
						obj[4] = hu.a(ref A_1);
						A_0 = string.Format(format, obj);
						return false;
					}
					if (iq[0].Count == 1 && num6 < 200.0)
					{
						string A_1 = "CTMActiveRangeWarningFmt";
						string format2 = hu.a(ref A_1);
						object[] obj2 = new object[5]
						{
							cf2.q().ToString("0"),
							cf2.r().ToString("0"),
							num4.ToString("0"),
							num5.ToString("0"),
							null
						};
						A_1 = "CTMSpectrometerInvalid";
						obj2[4] = hu.a(ref A_1);
						A_0 = string.Format(format2, obj2);
						return false;
					}
					return true;
				}
				default:
				{
					string A_1 = "CTMActiveBothSpecWarning";
					A_0 = hu.a(ref A_1);
					return false;
				}
				}
			}
			return true;
		}
	}

	public bool t0(bool A_0)
	{
		bool flag = A_0 && hb.b8().a(v4(), uq());
		if (!t5(flag))
		{
			return false;
		}
		if (flag)
		{
			return m2(hb.b8());
		}
		if (iq == null)
		{
			return false;
		}
		g2 g10 = hb.d0();
		if ((g10.c() == g2.a.f || g10.c() == g2.a.g) && g10.r() == null)
		{
			return false;
		}
		if (g10.n() && hb.d0().c() != g2.a.b)
		{
			return false;
		}
		g10 = null;
		int upperBound = iq.GetUpperBound(0);
		bool flag2 = hb.d0().c() == g2.a.n;
		int num = upperBound;
		checked
		{
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (iq[num2] == null || iq[num2].Count == 0)
				{
					return false;
				}
				global::h h10 = hb.b8();
				bool flag3 = h10.n(v6()) == global::h.MeasurementTimingType.Maximum || h10.n(v6()) == global::h.MeasurementTimingType.Recommended;
				if (flag3 || flag2)
				{
					int num3 = iq[num2].Count - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						if (p9(hb.b8(), num4, num2))
						{
							if (flag3 && !m2(num2, num4, hb.d0().q()))
							{
								return false;
							}
							if (flag2 && !iq[num2][num4].wt())
							{
								return false;
							}
						}
					}
				}
				h10 = null;
			}
			return true;
		}
	}

	private bool m2(int A_0, int A_1, bool A_2)
	{
		ip ip2 = iq[A_0][A_1];
		iq iq2 = p9(iq[A_0][A_1]);
		if (!ip2.m2(iq2) || (!ip2.m2(jk, iq2) && !A_2))
		{
			return false;
		}
		return true;
	}

	private bool m2(global::h A_0, int A_1, int A_2, bool A_3)
	{
		if (iq[A_1].Count == 0)
		{
			return false;
		}
		global::h h10 = A_0;
		if ((h10.n(v6()) == global::h.MeasurementTimingType.Maximum || h10.n(v6()) == global::h.MeasurementTimingType.Recommended) && !m2(A_1, A_2, A_3))
		{
			return false;
		}
		h10 = null;
		return true;
	}

	[SpecialName]
	public bool x5()
	{
		if (j7 | ka)
		{
			return false;
		}
		if (m2(new m.a[4]
		{
			m.a.c,
			m.a.d,
			m.a.e,
			m.a.f
		}))
		{
			return true;
		}
		return false;
	}

	[SpecialName]
	public bool x6()
	{
		if (m2(new m.a[1] { m.a.e }))
		{
			return true;
		}
		return false;
	}

	private bool m2(m.a[] A_0)
	{
		Collection<m> collection = zy();
		lock (collection)
		{
			foreach (m item in collection)
			{
				foreach (m.a a10 in A_0)
				{
					if (item.a != a10)
					{
						continue;
					}
					if (item.a == m.a.f)
					{
						p p2 = (p)item;
						if (zp() == g2.a.b && (p2.d2() != o.a || kz) && p2.d2() != o.c && p2.d2() != o.b)
						{
							return true;
						}
					}
					else if (!item.i || (item.l != null && !item.l.q()))
					{
						return true;
					}
				}
			}
		}
		collection = zz();
		lock (collection)
		{
			foreach (m item2 in collection)
			{
				foreach (m.a a11 in A_0)
				{
					if (item2.a != a11)
					{
						continue;
					}
					if (item2.a == m.a.f)
					{
						p p3 = (p)item2;
						if (zp() == g2.a.b && (p3.d2() != o.a || kz) && p3.d2() != o.c && p3.d2() != o.b)
						{
							return true;
						}
					}
					else if (!item2.i || (item2.l != null && !item2.l.q()))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	[SpecialName]
	public bool x7()
	{
		return kc;
	}

	[SpecialName]
	public bool x8()
	{
		if (j7)
		{
			return !ka;
		}
		return false;
	}

	[SpecialName]
	public global::r.d.a.b x9()
	{
		return j8;
	}

	[SpecialName]
	public bool ya()
	{
		if (m2(new m.a[3]
		{
			m.a.d,
			m.a.e,
			m.a.i
		}))
		{
			return true;
		}
		Collection<m> obj = null;
		bool flag = default(bool);
		try
		{
			obj = zz();
			flag = Monitor.TryEnter(obj, 300);
			if (flag)
			{
				Collection<m> collection = zz();
				foreach (m item in collection)
				{
					if (item.a == m.a.f)
					{
						p p2 = (p)item;
						if (p2.d2() == o.k || p2.d2() == o.j)
						{
							return true;
						}
					}
				}
			}
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(obj);
			}
		}
		return false;
	}

	public void m2(ref int A_0, ref int A_1)
	{
		A_0 = jj.ac();
		A_1 = jj.m;
	}

	public bool yb()
	{
		if (t7())
		{
			return true;
		}
		return zw();
	}

	public bool yc()
	{
		if (t7())
		{
			return false;
		}
		return zx();
	}

	private bool t7()
	{
		if (iq == null)
		{
			return true;
		}
		if ((hb.d0().c() == g2.a.f || hb.d0().c() == g2.a.g) && hb.d0().r() == null)
		{
			return true;
		}
		return false;
	}

	[SpecialName]
	public bool yd()
	{
		if (iq == null)
		{
			return true;
		}
		int upperBound = iq.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (iq[num].Count > 0)
			{
				bool a_ = so(num);
				if (!iq[num][0].uu())
				{
					return false;
				}
				if (iq[num].Count > 1 && hb.b8().a(num).b(a_) != global::f.a.b && hb.b8().a(num).b(a_) != global::f.a.c)
				{
					return false;
				}
				_ = null;
			}
		}
		return true;
	}

	private double m2(int A_0)
	{
		bool a_ = he.c() == g2.a.b;
		double num = 0.0;
		foreach (ip item in iq[A_0])
		{
			num += item.qh(p9(item), a_);
		}
		return num;
	}

	public float ye()
	{
		float num = 0f;
		int upperBound = iq.GetUpperBound(0);
		bool a_ = zp() == g2.a.b;
		int num2 = upperBound;
		for (int num3 = 0; num3 <= num2; num3 = checked(num3 + 1))
		{
			foreach (ip item in iq[num3])
			{
				num += (float)(item.qh(p9(item), a_) * (double)item.m2(jk, a_));
			}
		}
		return num;
	}

	public gv yf()
	{
		h6 h10 = null;
		if (iq != null && iq.Length > 0 && iq[0] != null && iq[0].Count > 0)
		{
			h10 = iq[0][0];
		}
		else if (@is != null && @is.Count > 0)
		{
			h10 = @is[0];
		}
		if (h10 != null)
		{
			h6 h11 = h10;
			hm.c(h11.yw(), h11.yy());
			h11 = null;
		}
		return hm;
	}

	public void yg()
	{
		hb.bv(m2, sj);
	}

	public b9.k yh()
	{
		return hi.sm();
	}

	public b9.l[] yi()
	{
		return hi.sn();
	}

	public void m2(hr A_0, bool A_1, global::r.c A_2, ref string A_3)
	{
		hc hc2 = new hc();
		eo.a a10 = eo.at();
		et et2 = (et)A_0.cu().p();
		checked
		{
			bool A_6 = default(bool);
			if (!A_1)
			{
				float A_4 = default(float);
				float A_5 = default(float);
				et2.t(A_0.cz()[0], A_0.cz()[A_0.c2() - 1], ref A_4, ref A_5, ref A_6);
				if (et2.x() != A_4 || et2.y() != A_5)
				{
					et2.x(A_4);
					et2.y(A_5);
				}
			}
			float num = 0f;
			eo eo2 = new eo();
			eo2.at(a10);
			int num2 = 0;
			bool flag = default(bool);
			int A_8 = default(int);
			int A_9 = default(int);
			int A_11 = default(int);
			int A_12 = default(int);
			float A_13 = default(float);
			float A_14 = default(float);
			bool A_15 = default(bool);
			float num4 = default(float);
			while (true)
			{
				hg hg2 = new hg(eo2, global::hg.b4());
				hi hi2 = new hi(eo2);
				hi2.ew(2);
				gc A_7 = new gc();
				A_7.af("Air");
				hi2.au(ref A_7);
				A_7 = new gc();
				if (A_6)
				{
					A_7.af("Parylene");
					hg2.ca().e(h4.a.c);
				}
				else
				{
					A_7.af("SiO2");
					hg2.ca().e(h4.a.a);
				}
				A_7.ag(A_0: true);
				A_7.af(hg2.co(), hg2.cp(), et2.z());
				A_7.ak(20.0);
				A_7.am(0.0);
				hi2.au(ref A_7);
				A_7 = new gc();
				A_7.af("Si");
				hi2.au(ref A_7);
				hg2.bu(hi2);
				hg2.bx(1);
				hi2.ei(400.0);
				hi2.d7((double)et2.x());
				hi2.d6((double)et2.y());
				hi2.d9(0, A_1: true);
				hi2.el(A_0: true);
				if (et2.x() > 1000f)
				{
					hi2.ez(A_0: true);
					hi2.ew(A_0: true);
				}
				else
				{
					hi2.ez(A_0: false);
					hi2.ew(A_0: false);
				}
				hi2.el(0.999);
				hi2.ey(A_0: false);
				if (flag)
				{
					hi2.e1(A_0: true);
				}
				else
				{
					hi2.e1(A_0: false);
				}
				if (hi.m2(hg2, ha, A_0, ref A_3, A_4: true, a10) != b9.ErrPublic.None)
				{
					throw new ApplicationException("Error in CalcSetUpLayers!");
				}
				m2(hi2, A_0.cz(), ref A_8, ref A_9);
				if (!flag)
				{
					et2.w(0f);
				}
				float A_10 = 10000f;
				int num3 = 0;
				do
				{
					bool a_ = ((num3 < 2) & (et2.x() < 1000f)) | (num3 < 1);
					bool flag2 = hi.m2(ref A_11, ref A_12, num3, 3, num, 40f, a_, flag, ref A_10, ref A_13, ref A_14, ref A_15, A_0, hi2, zj(), hg2, ha, hc2, A_8, A_9, A_2, m2(A_0));
					if (!flag2 | A_15)
					{
						if (!flag2)
						{
							throw new ApplicationException("Calibration failure!");
						}
						return;
					}
					if (flag)
					{
						et2.v(A_13);
					}
					else
					{
						et2.u(A_13);
						et2.w(A_14);
					}
					if (((A_13 != num4 && num3 < 1) & (et2.x() < 1000f)) && !flag)
					{
						num4 = A_13;
						flag2 = hi.m2(ref A_11, ref A_12, num3, 3, num, num3 < 1, ref A_10, ref A_14, ref A_15, A_0, hi2, zj(), hg2, ha, hc2, A_8, A_9, A_2, m2(A_0));
						if (!flag2 | A_15)
						{
							if (!flag2)
							{
								throw new ApplicationException("Calibration failure!");
							}
							return;
						}
						et2.w(A_14);
					}
					num3++;
					A_2.t(num + (float)((double)num3 / 3.0 * 50.0));
				}
				while (A_10 > 0.05f && num3 < 3);
				if (num3 == 3)
				{
					ab8().c(fz.b.a, "CalibrateObjective: Max number of loops reached. minCurrThicknessError = " + A_10 + ", calibRobustThickness = " + flag);
				}
				if (A_10 <= 40f)
				{
					if (flag)
					{
						et2.v(A_13);
					}
					else
					{
						et2.u(A_13);
						et2.w(A_14);
					}
					num = 50 + 50 * num2;
					A_2.t(num);
					flag = true;
					num2++;
					if (num2 > 1)
					{
						et2.u(A_0: true);
						et2.t(A_0: false);
						break;
					}
					continue;
				}
				A_2.a = true;
				throw new ApplicationException("Calibration failure!");
			}
		}
	}

	private ErrPublic m2(ref string A_0, ref string A_1, m A_2)
	{
		if (sj(A_2) != global::r.a.a)
		{
			return ErrPublic.Generic;
		}
		return ErrPublic.None;
	}

	protected override void f(m A_0)
	{
		try
		{
			switch (A_0.d)
			{
			case m.TaskExecutionType.Spectrometer:
				m2((p)A_0);
				break;
			case m.TaskExecutionType.SpectrometerNonSpectrum:
				p9((q)A_0);
				break;
			case m.TaskExecutionType.MeasEngine:
				m2((r)A_0);
				break;
			case m.TaskExecutionType.Setup:
				m2((s)A_0);
				break;
			case m.TaskExecutionType.Execution:
				m2((t)A_0);
				break;
			case m.TaskExecutionType.VideoCamera:
				m2((u)A_0);
				break;
			case m.TaskExecutionType.SpectrometerTestAndCal:
				qh(A_0);
				break;
			case m.TaskExecutionType.ScatterBox:
				p9(A_0);
				break;
			case m.TaskExecutionType.Photodiode:
				m2((w)A_0);
				break;
			default:
				ab8().c(fz.b.b, "Trying to execute a task of type " + A_0.d.ToString() + " in a MeasModuleSpec object. ", Environment.StackTrace);
				break;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ab8().c(fz.b.b, "Exception caught in MeasModuleSpec.ExecuteATask(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	protected override bool ah(m A_0)
	{
		if (A_0.d != m.TaskExecutionType.VideoCamera && mb.Count > 0)
		{
			if (A_0.a == m.a.ae)
			{
				h6.c c10 = (h6.c)((q)A_0).a8;
				return !mb.Contains(c10.b);
			}
			return false;
		}
		return true;
	}

	protected override void g(m A_0)
	{
		if (!(A_0 is p))
		{
			return;
		}
		p p2 = (p)A_0;
		if (((m)p2).a == m.a.f && g2.d(zp()))
		{
			if (hf.Count > 0)
			{
				long a_ = default(long);
				if (A_0.g != null)
				{
					a_ = A_0.g.d();
				}
				h.a a_2 = new h.a(A_0.d3(), a_, hc.dh().aw());
				m2(a_2, p2, hg);
				global::r.d.a.b a_3 = A_0.d3();
				global::r.d.a a_4 = new global::r.d.a(A_0.d3(), a_);
				bool A_1 = false;
				m2(ErrPublic.None, a_3, A_2: false, A_3: false, a_4, null, ref A_1, A_7: false);
			}
		}
		else if (!p2.s && p2.d1(n.b) && ((m)p2).a != m.a.f && hg.cn() != null)
		{
			long a_5 = default(long);
			if (A_0.g != null)
			{
				a_5 = A_0.g.d();
			}
			hg.cf(A_0: true);
			global::r.d.a.b a_6 = A_0.d3();
			global::r.d.a a_7 = new global::r.d.a(A_0.d3(), a_5);
			bool A_1 = false;
			m2(ErrPublic.None, a_6, A_2: false, A_3: false, a_7, null, ref A_1, A_7: false);
		}
		if (l2 != null && l2.ak())
		{
			l2.at();
		}
	}

	protected override void h(m A_0)
	{
		if (il != null)
		{
			sj(A_0: false);
		}
		long a_ = default(long);
		if (A_0.g != null)
		{
			a_ = A_0.g.d();
		}
		global::r.d.a a_2 = new global::r.d.a(A_0.d3(), a_);
		jg.d(gt, a_2);
	}

	private int m2(Collection A_0)
	{
		int count = A_0.Count;
		DateTime dateTime = ((hr)A_0[count]).cb();
		int num = 1;
		checked
		{
			for (int num2 = count - 1; num2 >= 1; num2 += -1)
			{
				DateTime value = ((hr)A_0[num2]).cb();
				if (dateTime.Subtract(value).TotalSeconds > 0.5)
				{
					break;
				}
				num++;
			}
			int num3 = ((num > 2) ? num : 2);
			if (count - 1 - num3 > 0)
			{
				return count - 1 - num3;
			}
			if (count - num3 > 0)
			{
				return count - 1 - num3;
			}
			return 0;
		}
	}

	private void m2(global::h A_0, int A_1, p A_2, Collection<hr> A_3, ref hr A_4, ref hr A_5, ref hr A_6, ref hr A_7)
	{
		switch ((ix[A_1] != global::h.f.b || iv[0]) ? ix[A_1] : global::h.f.a)
		{
		case global::h.f.a:
			m2(A_3, ref A_4, A_1);
			A_7 = A_4;
			break;
		case global::h.f.b:
			m2(A_3, ref A_5, A_1);
			A_7 = A_5;
			break;
		case global::h.f.c:
			m2(A_3, ref A_6, A_1);
			A_7 = A_6;
			break;
		default:
			throw new ArgumentOutOfRangeException("Measurement type out of range in MeasModuleSpec.TaskCoreSpectrometer");
		}
	}

	private void m2(Collection<hr> A_0, ref hr A_1, int A_2)
	{
		checked
		{
			if (A_0.Count > 1)
			{
				ul();
				double[] array = j2[A_2];
				double[] array2 = new double[j1[A_2] - 1 + 1];
				double[] array3 = new double[j1[A_2] - 1 + 1];
				A_0[jp[A_2]].cz();
				double[] array4 = A_0[jp[A_2]].c0();
				int num = A_0[jp[A_2]].c2();
				A_0[jq[A_2]].cz();
				double[] array5 = A_0[jq[A_2]].c0();
				int num2 = A_0[jq[A_2]].c2();
				int num3 = ju[A_2];
				int num4;
				for (num4 = 0; num4 <= num3; num4++)
				{
					array2[num4] = array4[num4];
					array3[num4] = array[num4];
				}
				int[] array6 = jv[A_2];
				int[] array7 = jw[A_2];
				int[] array8 = jx[A_2];
				int[] array9 = jy[A_2];
				float[] array10 = jz[A_2];
				int num5 = j0[A_2] - 1;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					double num7 = 0.0;
					int num8 = 0;
					int num9 = array6[num6];
					int num10 = array7[num6];
					for (int num11 = num9; num11 <= num10; num11++)
					{
						num7 += array4[num11];
						num8++;
					}
					double num12 = 0.0;
					int num13 = 0;
					int num14 = array8[num6];
					int num15 = array9[num6];
					for (int num16 = num14; num16 <= num15; num16++)
					{
						num12 += array5[num16];
						num13++;
					}
					double num17 = array10[num6];
					array2[num4] = num7 * num17 / (double)num8 + (1.0 - num17) * num12 / (double)num13;
					array3[num4] = array[num4];
					num4++;
				}
				int num19;
				if (jr[A_2] != 0f)
				{
					int num18 = js[A_2];
					num19 = num4 - num18;
					int num20 = num18;
					int num21 = num - 1;
					for (int num11 = num20; num11 <= num21; num11++)
					{
						array2[num4] = array4[num11];
						array3[num4] = array[num4];
						num4++;
					}
				}
				else
				{
					int num18 = jt[A_2];
					num19 = num4 - num18;
					int num22 = num18;
					int num23 = num2 - 1;
					for (int num16 = num22; num16 <= num23; num16++)
					{
						array2[num4] = array5[num16];
						array3[num4] = array[num4];
						num4++;
					}
				}
				array3 = (double[])Utils.CopyArray(array3, new double[num4 - 1 + 1]);
				array2 = (double[])Utils.CopyArray(array2, new double[num4 - 1 + 1]);
				A_1.t(array3);
				A_1.r(array2);
				A_1.af(array2);
				hr hr2 = A_0[0];
				A_1.r(hr2.cb());
				A_1.t(hr2.cp());
				A_1.ak(hr2.b5());
				A_1.ag(hr2.ck());
				A_1.aj(hr2.cj());
				A_1.am(hr2.cr() || A_0[1].cr());
				A_1.r(hr2.co());
				A_1.ao(hr2.cn());
				A_1.r(hr2.cl());
				A_1.r(hr2.b4(), hr2.b5(), hr2.b9(), hr2.ca(), hr2.b6(), hr2.b7());
				A_1.r(hr2.cu());
				A_1.r(hr2.bt());
				hr2 = null;
				List<Guid> list = new List<Guid>();
				list.Add(A_0[jp[A_2]].b8()[0]);
				list.Add(A_0[jq[A_2]].b8()[0]);
				A_1.r(list);
				if (A_0[jp[A_2]].cc())
				{
					hr hr3 = A_0[jp[A_2]];
					A_1.aj(hr3.cc());
					A_1.t(hr3.cd());
					A_1.af(hr3.ce());
					hr3 = null;
				}
				else
				{
					hr hr4 = A_0[jq[A_2]];
					A_1.aj(hr4.cc());
					A_1.t(hr4.cd() - num19);
					A_1.af(hr4.ce() - num19);
					hr4 = null;
				}
				hp hp2 = A_0[jp[A_2]].br()[0];
				hp hp3 = A_0[jq[A_2]].br()[0];
				hp2.r(A_0: true);
				hp2.s(A_0: true);
				hp3.r(A_0: true);
				hp3.s(A_0: false);
				A_1.r(hp2);
				A_1.r(hp3);
				A_1.t(A_0[jp[A_2]].cs());
				A_1.af(A_0[jq[A_2]].ct());
			}
			else if (A_0.Count > 0)
			{
				A_1 = A_0[0];
			}
		}
	}

	private bool p9(global::h A_0, int A_1, n A_2, bool A_3, bool A_4)
	{
		return m2(A_0, A_1, A_2, A_3, A_4, A_5: true);
	}

	private bool m2(global::h A_0, int A_1, n A_2, bool A_3, bool A_4)
	{
		if (A_1 < 0)
		{
			return false;
		}
		return m2(A_0, A_1, A_2, A_3, A_4, A_5: false);
	}

	private bool m2(global::h A_0, int A_1, n A_2, bool A_3, bool A_4, bool A_5)
	{
		if (!p9(A_0, A_1, A_5))
		{
			return false;
		}
		switch (A_2)
		{
		case n.b:
		case n.g:
		case n.h:
		case n.i:
		case n.k:
		case n.m:
		case n.n:
			return true;
		case n.f:
			return A_1 == iu[0] || A_1 == iu[2];
		case n.e:
			if (ix[A_1] == global::h.f.c)
			{
				return false;
			}
			goto case n.c;
		case n.c:
		case n.d:
		case n.o:
			if (p9(A_0, iu[0], A_5) || p9(A_0, iu[2], A_5) || A_0.a(iv) == global::h.e.c)
			{
				return A_3;
			}
			return A_4;
		case n.a:
			return false;
		default:
			throw new ArgumentOutOfRangeException("Unhandled type in MeasModuleSpec.SpectrometerActiveForPurpose");
		}
	}

	private void qh(m A_0)
	{
		long a_ = default(long);
		if (A_0.g != null)
		{
			a_ = A_0.g.d();
		}
		global::r.d.a A_1 = new global::r.d.a(A_0.d3(), a_);
		global::r.d.a a10 = new global::r.d.a(A_0.d3(), a_);
		A_1.a = global::r.d.a.a.b;
		try
		{
			a10.a = global::r.d.a.a.a;
			A_0.g.e(gt, a10);
			switch (A_0.a)
			{
			case m.a.ab:
			{
				ip.m a_4 = (ip.m)A_0.j;
				m2(a_4, A_0, ref A_1);
				A_1.d = a_4;
				break;
			}
			case m.a.y:
			{
				ip.i a_2 = (ip.i)A_0.j;
				m2(a_2, A_1: false, A_2: false, A_3: false, A_0, A_1);
				A_1.d = a_2;
				break;
			}
			case m.a.bh:
			case m.a.bm:
			{
				ip.i a_3 = (ip.i)A_0.j;
				m2(a_3, A_1: true, A_0.a == m.a.bm, A_3: true, A_0, A_1);
				A_1.d = a_3;
				break;
			}
			case m.a.z:
			{
				ip.j j2 = (ip.j)A_0.j;
				ip ip2 = p9(j2.c, j2.a, j2.b);
				if (j2.i == null)
				{
					bool A_2 = false;
					bool A_3 = false;
					if (m2(ip2, 1f, ref A_2, ref A_3, A_4: false, 0f, null, n.f, A_0.h, A_0.d3(), 0, A_11: false, A_12: false) != ErrPublic.None)
					{
						A_1.b = "Unknown error attempting to autoscale integration time for Wavelength Coeff Calib. Aborting";
					}
				}
				string A_4 = string.Empty;
				if (string.IsNullOrEmpty(A_1.b))
				{
					ip2.m2(j2, A_0.h, A_0.d3(), ref A_1.b, ref A_4);
				}
				if (string.IsNullOrEmpty(A_1.b))
				{
					A_1.d = j2;
					A_1.a = global::r.d.a.a.a;
					if (!string.IsNullOrEmpty(A_4))
					{
						A_1.b = A_4;
					}
				}
				break;
			}
			case m.a.ac:
			{
				ip.p p2 = (ip.p)A_0.j;
				if (p9(p2.c, p2.a, p2.b).p9(ref p2.ad) == 0)
				{
					A_1.a = global::r.d.a.a.a;
				}
				else
				{
					A_1.a = global::r.d.a.a.b;
				}
				A_1.d = p2;
				break;
			}
			case m.a.@as:
			{
				ip.p p3 = (ip.p)A_0.j;
				if (p9(p3.c, p3.a, p3.b).m2(ref p3.ad) == 0)
				{
					A_1.a = global::r.d.a.a.a;
				}
				else
				{
					A_1.a = global::r.d.a.a.b;
				}
				A_1.d = p3;
				break;
			}
			case m.a.be:
			{
				ip.q q2 = (ip.q)A_0.j;
				if (p9(q2.c, q2.a, q2.b).m2(ref q2.ae, ref q2.af, ref q2.ag) == 0)
				{
					A_1.a = global::r.d.a.a.a;
				}
				else
				{
					A_1.a = global::r.d.a.a.b;
				}
				A_1.d = q2;
				break;
			}
			case m.a.ad:
				m2(A_0);
				A_1.a = global::r.d.a.a.a;
				break;
			default:
			{
				int num = (int)A_0.a;
				throw new ArgumentOutOfRangeException("Unknown Task.ID in TaskCoreSpectrometerTestAndCal. Task.Id=" + num);
			}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_5 = ex2;
			ab8().c(fz.b.b, "Error in TaskCoreSpectrometerTestAndCal. Task ID=" + A_0.a, a_5);
			ProjectData.ClearProjectError();
		}
		finally
		{
			A_0.g.d(gt, A_1);
		}
	}

	private void p9(m A_0)
	{
		long a_ = default(long);
		if (A_0.g != null)
		{
			a_ = A_0.g.d();
		}
		global::r.d.a a10 = new global::r.d.a(A_0.d3(), a_);
		global::r.d.a a11 = new global::r.d.a(A_0.d3(), a_);
		string A_1 = null;
		a10.a = global::r.d.a.a.b;
		try
		{
			a11.a = global::r.d.a.a.a;
			A_0.g.e(gt, a11);
			switch (A_0.a)
			{
			case m.a.bp:
				if (m2(A_0, ref A_1) != ErrPublic.None)
				{
					a10.a = global::r.d.a.a.b;
					a10.b = A_1;
				}
				else
				{
					a10.a = global::r.d.a.a.a;
				}
				break;
			case m.a.bn:
				if (m2(((y)A_0).c3, ref A_1) != 0)
				{
					a10.a = global::r.d.a.a.b;
					a10.b = A_1;
				}
				else
				{
					a10.a = global::r.d.a.a.a;
				}
				break;
			case m.a.bo:
				if (m2(((y)A_0).c4, ref A_1) != 0)
				{
					a10.a = global::r.d.a.a.b;
					a10.b = A_1;
				}
				else
				{
					a10.a = global::r.d.a.a.a;
				}
				break;
			case m.a.bq:
				ma.j();
				a10.a = global::r.d.a.a.a;
				break;
			default:
			{
				int num = (int)A_0.a;
				throw new ArgumentOutOfRangeException("Unknown Task.ID in TaskCoreSpectrometerScatterBox. Task ID=" + num);
			}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			ab8().c(fz.b.b, "Error in TaskCoreSpectrometerScatterBox. Task ID=" + A_0.a, a_2);
			ProjectData.ClearProjectError();
		}
		finally
		{
			A_0.g.d(gt, a10);
		}
	}

	private double m2(int A_0, double[] A_1, double A_2)
	{
		checked
		{
			int num = A_0 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (A_1[num2] > A_2)
				{
					if (num2 > 0)
					{
						double num3 = A_1[num2] - A_1[num2 - 1];
						return (double)num2 + (A_2 - A_1[num2]) / num3;
					}
					return 0.0;
				}
			}
			return A_0 - 1;
		}
	}

	private void m2(int A_0, double[] A_1, ref double A_2, ref double A_3, ref double A_4, ref double A_5, ref int A_6, ref int A_7)
	{
		A_2 = double.MinValue;
		int a_ = 0;
		checked
		{
			double[] array = new double[A_0 - 1 + 1];
			int num = A_0 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				array[num2] = num2;
				if (A_1[num2] > A_2)
				{
					A_2 = A_1[num2];
					a_ = num2;
				}
			}
			double a_2 = 0.5 * A_2;
			double A_8 = default(double);
			double A_9 = default(double);
			cf.l(array, A_1, a_, a_2, A_4: true, ref A_8, ref A_9, ref A_3, ref A_4);
			A_5 = A_8;
			A_6 = (int)Math.Round(Math.Max(0.0, A_3 - 0.25 * (A_8 - A_3)));
			A_7 = (int)Math.Round(Math.Max(0.0, A_4 + 0.25 * (A_4 - A_8)));
		}
	}

	private ErrPublic m2(ip A_0, m A_1, global::r.d.a A_2, double A_3)
	{
		while (true)
		{
			bool A_4 = false;
			bool A_5 = false;
			ErrPublic errPublic = m2(A_0, 1f, ref A_4, ref A_5, A_4: false, 0f, null, n.f, A_1.h, A_1.d3(), 0, A_11: false, A_12: false, A_3);
			switch (errPublic)
			{
			case ErrPublic.LightTooBright:
				return errPublic;
			default:
				A_2.a = global::r.d.a.a.b;
				A_2.b = "Unknown error attempting to autoscale integration time. Aborting";
				return ErrPublic.Generic;
			case ErrPublic.None:
				if (A_0.m2(A_0.u9(), A_3))
				{
					string text = "The targeted peak signal can not be reached using the recommended\r\nmax integration time (" + A_3.ToString("0.0") + " msec).\r\n\r\nPlease ensure that the light source is turned on and that the\r\n reference and cutoff filter are positioned correctly.";
					if (A_1.h != null)
					{
						if (!A_1.h.t(text, "Information", "OKString", "CancelString"))
						{
							A_2.a = global::r.d.a.a.b;
							A_2.b = "Operation canceled";
							return ErrPublic.Generic;
						}
					}
					else if (Interaction.MsgBox(text, MsgBoxStyle.OkCancel) == MsgBoxResult.Cancel)
					{
						A_2.a = global::r.d.a.a.b;
						A_2.b = "Operation canceled";
						return ErrPublic.Generic;
					}
				}
				if (!A_0.m2(A_0.u9(), A_3))
				{
					return ErrPublic.None;
				}
				break;
			}
		}
	}

	private void m2(int A_0, double[] A_1, ref int A_2, ref int A_3)
	{
		checked
		{
			double[] array = new double[A_0 - 1 + 1];
			double[] array2 = new double[A_0 - 1 + 1];
			double[] array3 = new double[A_0 - 1 + 1];
			int num = A_0 - 2;
			for (int num2 = 1; num2 <= num; num2++)
			{
				array[num2] = (A_1[num2 + 1] - A_1[num2 - 1]) / 2.0;
				array2[num2] = 0.0 - array[num2];
				array3[num2] = num2;
			}
			double[] A_4 = null;
			double[] A_5 = null;
			double[] A_6 = null;
			double[] A_7 = null;
			double A_8 = 0.0;
			double A_9 = 0.0;
			bool A_10 = default(bool);
			cf.l(array3, array2, 6, null, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8, ref A_9, ref A_10);
			double num3 = double.MinValue;
			int num4 = A_5.Length - 1;
			int num6 = default(int);
			for (int num5 = 0; num5 <= num4; num5++)
			{
				if (A_5[num5] > num3)
				{
					num3 = A_5[num5];
					num6 = num5;
				}
			}
			A_2 = (int)Math.Round(A_4[num6]) + 1;
			int num7 = -1;
			double num8 = double.MinValue;
			int num9 = num6 + 1;
			int num10 = A_5.Length - 1;
			for (int num11 = num9; num11 <= num10; num11++)
			{
				if (A_5[num11] > num8)
				{
					num8 = A_5[num11];
					num7 = num11;
				}
			}
			if (num7 > 0)
			{
				int num12 = (int)Math.Round(A_4[num7]);
				double num13 = array[num12];
				double num14 = double.MinValue;
				int num15 = A_2;
				int num16 = num12;
				int num18 = default(int);
				for (int num17 = num15; num17 <= num16; num17++)
				{
					if (array[num17] > num14)
					{
						num14 = array[num17];
						num18 = num17;
					}
				}
				double num19 = (num13 + num14) / 2.0;
				A_3 = A_0 - 1;
				int num20 = num18;
				int num21 = num12;
				for (int num22 = num20; num22 <= num21; num22++)
				{
					if (array[num22] - num19 < 0.0)
					{
						A_3 = Math.Max(num22 - 1 - 2, num18);
						break;
					}
				}
			}
			else
			{
				A_3 = A_0 - 1;
			}
		}
	}

	private void m2(int A_0, int A_1, double A_2, double A_3, double[] A_4, double[] A_5)
	{
		checked
		{
			double[] A_6 = new double[A_0 - 1 + 1];
			double[] A_7 = new double[A_0 - 1 + 1];
			double[] A_8 = new double[A_1 - 1 + 1];
			int num = A_1 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				A_8[num2] = (double)num2 - A_2;
			}
			int num3 = A_0 - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				A_7[num4] = num4;
			}
			global::jf.a(ref A_8, ref A_5, A_1, ref A_7, ref A_6, A_0);
			int num5 = A_0 - 1;
			int num6 = (int)Math.Round(A_3 + 1.0);
			for (int num7 = num5; num7 >= num6 && A_6[num7] > A_4[num7]; num7 += -1)
			{
				A_4[num7] = A_6[num7];
			}
		}
	}

	private int m2(double[] A_0, int A_1, double A_2)
	{
		checked
		{
			int num = A_1 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (A_0[num2] > A_2)
				{
					return num2;
				}
			}
			return 0;
		}
	}

	private double m2(double[] A_0, int A_1, int A_2)
	{
		double num = double.MaxValue;
		for (int num2 = A_1; num2 <= A_2; num2 = checked(num2 + 1))
		{
			if (A_0[num2] < num)
			{
				num = A_0[num2];
			}
		}
		return num;
	}

	private bool m2(double A_0, double[] A_1, int A_2, int A_3, double A_4, ref double A_5)
	{
		A_5 = m2(A_1, A_2, A_3);
		return A_5 < A_4;
	}

	private double m2(double A_0, double A_1, double A_2, double[] A_3, double[] A_4)
	{
		checked
		{
			int num2 = default(int);
			for (int num = A_3.Length - 1; num >= 1; num += -1)
			{
				if ((A_4[num] - A_2) * (A_4[num - 1] - A_2) < 0.0)
				{
					num2 = num - 1;
					break;
				}
			}
			if (A_0 > A_3[num2] && A_0 < A_3[num2 + 1])
			{
				return A_3[num2] + (A_2 - A_4[num2]) * (A_0 - A_3[num2]) / (A_1 - A_4[num2]);
			}
			return A_3[num2] + (A_2 - A_4[num2]) * (A_3[num2 + 1] - A_3[num2]) / (A_4[num2 + 1] - A_4[num2]);
		}
	}

	private double m2(int A_0, double A_1, double[] A_2, double A_3, double[] A_4, double[] A_5, double[] A_6, double A_7, double A_8, double A_9)
	{
		checked
		{
			double[] A_10 = new double[A_0 - 1 + 1];
			double[] A_11 = new double[A_0 - 1 + 1];
			double[] A_12 = new double[A_0 - 1 + 1];
			int num = 0;
			int num2 = 0;
			for (int num3 = A_0 - 1; num3 >= 0; num3 += -1)
			{
				num2 = (int)Math.Round(A_1 / 2.0 + (double)num3 * A_1);
				if (A_2[num2] < 500.0)
				{
					num = num3 + 1;
					num2++;
					break;
				}
			}
			int num4 = A_0 - 1;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				A_11[num5] = num5;
				A_12[num5] = (double)num5 - A_3;
			}
			global::jf.a(ref A_12, ref A_5, A_0, ref A_11, ref A_10, A_0);
			if (A_4[num] < A_10[num])
			{
				for (int num6 = num - 1; num6 >= 0; num6 += -1)
				{
					if (!(A_4[num6] > A_10[num6]))
					{
						continue;
					}
					double num7 = A_4[num6 + 1] - A_4[num6];
					double num8 = A_10[num6 + 1] - A_10[num6];
					double num9 = (num8 * A_4[num6 + 1] - num7 * A_10[num6 + 1]) / (num8 - num7);
					for (int num10 = num2; num10 >= 0; num10 += -1)
					{
						if (A_6[num10] > num9)
						{
							double num11 = (A_6[num10 + 1] - A_6[num10]) / (A_2[num10 + 1] - A_2[num10]);
							double num12 = A_2[num10] + (num9 - A_6[num10]) / num11;
							if (num12 < A_7 || num12 > A_8)
							{
								ab8().c(fz.b.a, "startEdgeOfFilterWL = " + num12 + " is not in the expected range. Will use the default value of " + A_9 + ".");
								num12 = A_9;
							}
							return num12;
						}
					}
					ab8().c(fz.b.a, "Found crossover of shifted green LED and uv LED in reduced spec but not threshold crossover of smoothed uv LED.");
					break;
				}
			}
			else
			{
				ab8().c(fz.b.a, "Crossover of shifted green LED and uv LED was not found.");
			}
			return A_9;
		}
	}

	private ErrPublic m2(m A_0, ref string A_1)
	{
		string text = global::i3.o() + "\\Logs\\";
		double[] array = yj();
		bool A_2 = default(bool);
		bool A_3 = default(bool);
		float A_4 = default(float);
		float A_6 = default(float);
		double A_7 = default(double);
		double A_8 = default(double);
		foreach (object value in Enum.GetValues(typeof(FiberMuxChannel)))
		{
			FiberMuxChannel fiberMuxChannel = (FiberMuxChannel)Conversions.ToInteger(value);
			ip ip2 = null;
			checked
			{
				int num = iq[0].Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					ip2 = iq[0][num2];
					if (ip2.xs() == FMUSBDeviceType.FIUSB2DeviceSpecUvVis2)
					{
						if ((fiberMuxChannel >= FiberMuxChannel.UV && fiberMuxChannel <= FiberMuxChannel.NIR2) || (fiberMuxChannel >= FiberMuxChannel.FilterHP550 && fiberMuxChannel <= FiberMuxChannel.FilterLP700))
						{
							break;
						}
					}
					else if (ip2.xs() == FMUSBDeviceType.FIUSB2DeviceSpecLC)
					{
						if ((fiberMuxChannel >= FiberMuxChannel.Violet && fiberMuxChannel <= FiberMuxChannel.NIR2) || (fiberMuxChannel >= FiberMuxChannel.FilterHP550 && fiberMuxChannel <= FiberMuxChannel.FilterLP700))
						{
							break;
						}
					}
					else if ((ip2.xs() == FMUSBDeviceType.FIUSB2DeviceSpecNIR2 || ip2.xs() == FMUSBDeviceType.FIUSB2DeviceSpecTCNIR) && ((fiberMuxChannel >= FiberMuxChannel.SWIR1 && fiberMuxChannel <= FiberMuxChannel.SWIR3) || fiberMuxChannel == FiberMuxChannel.FilterHP1200))
					{
						break;
					}
					ip2 = null;
				}
				if (ip2 == null)
				{
					continue;
				}
				try
				{
					m2(fiberMuxChannel, LightState.LightOn);
					p9(fiberMuxChannel, ref A_1);
					Collection<double> collection = new Collection<double>();
					Collection<double> collection2 = new Collection<double>();
					if (m2(ip2, 1f, ref A_2, ref A_3, A_4: false, 0f, null, n.f, A_0.h, A_0.d3(), 0, A_11: false, A_12: false) != ErrPublic.None)
					{
						A_1 = "Error attempting to autoscale integration time on the " + fiberMuxChannel.ToString() + " mux channel";
						return ErrPublic.Generic;
					}
					ip ip3 = ip2;
					if (ip3.m2(ip3.u9(), ip3.vm()) && m2(fiberMuxChannel, ip2, A_0, null) != ErrPublic.None)
					{
						A_1 = "Error attempting to adjust illumination gain on the " + fiberMuxChannel.ToString() + " mux channel";
						return ErrPublic.Generic;
					}
					ip3 = null;
					ip2.so(Math.Max(ip2.u9() * 0.4, ip2.vm()));
					if (m2(ref A_4) != 0)
					{
						A_1 = "Error attempting to return nominal angle on the " + fiberMuxChannel.ToString() + " mux channel";
						return ErrPublic.Generic;
					}
					double num3 = (double)A_4 - 0.07;
					double num4 = (double)A_4 + 0.07;
					double num7;
					for (double num5 = num3; num5 <= num4; num5 += 0.003)
					{
						if (m2(num5, ref A_1) != 0)
						{
							A_1 = "Error attempting to step the angle on the " + fiberMuxChannel.ToString() + " mux channel";
							return ErrPublic.Generic;
						}
						short num6 = (short)Math.Round(250.0 / ip2.u9());
						hr A_5 = new hr(hc.dh().aw());
						if (num6 < 1)
						{
							num6 = 1;
						}
						if (ip2.m2(ref A_3, ref A_2, xo(), 1, ip2.u9(), num6, A_0.h, A_0.d3()) != f0.FIDeviceErr.None)
						{
							A_1 = "Error acquiring spectrum on the " + fiberMuxChannel.ToString() + " mux channel";
							return ErrPublic.SpecAcquisition;
						}
						if (ip2.m2(ref A_5) != f0.FIDeviceErr.None)
						{
							A_1 = "Error retrieving spectrum on the " + fiberMuxChannel.ToString() + " mux channel";
							return ErrPublic.SpecAcquisition;
						}
						double[] array2 = A_5.c0();
						num7 = double.MinValue;
						int num8 = A_5.c2() - 1;
						for (int num9 = 0; num9 <= num8; num9++)
						{
							if (array2[num9] > num7)
							{
								num7 = array2[num9];
							}
						}
						m2(ref A_6);
						collection.Add(A_6);
						collection2.Add(num7);
					}
					num7 = double.MinValue;
					int num10 = -1;
					int num11 = collection.Count - 1;
					for (int num12 = 0; num12 <= num11; num12++)
					{
						if (collection2[num12] > num7)
						{
							num7 = collection2[num12];
							num10 = num12;
						}
					}
					if (num10 >= 0 && num10 < collection.Count && collection2[num10] > collection2[num10 - 1] && collection2[num10] > collection2[num10 + 1])
					{
						global::jf.a(collection[num10 - 1], collection2[num10 - 1], collection[num10], collection2[num10], collection[num10 + 1], collection2[num10 + 1], ref A_7, ref A_8);
						array[unchecked((int)fiberMuxChannel)] = A_7;
					}
					else
					{
						array[unchecked((int)fiberMuxChannel)] = collection[num10];
					}
					StreamWriter streamWriter = null;
					try
					{
						streamWriter = new StreamWriter(text + "int vs angle " + fiberMuxChannel.ToString() + ".csv", append: false, Encoding.ASCII);
						streamWriter.WriteLine("Center");
						streamWriter.WriteLine(array[unchecked((int)fiberMuxChannel)].ToString("0.000"));
						streamWriter.WriteLine();
						streamWriter.WriteLine("angle (rad), intensity");
						int num13 = collection.Count - 1;
						for (int num14 = 0; num14 <= num13; num14++)
						{
							streamWriter.WriteLine(collection[num14].ToString("0.000") + ", " + collection2[num14].ToString("0.000"));
						}
					}
					finally
					{
						streamWriter?.Close();
					}
				}
				finally
				{
					m2(fiberMuxChannel, LightState.LightOff);
				}
			}
		}
		m2(array);
		return ErrPublic.None;
	}

	private void m2(FiberMuxChannel A_0, LightState A_1)
	{
		if (A_1 == LightState.LightOn)
		{
			if (A_0 == FiberMuxChannel.FilterHP1200 || A_0 == FiberMuxChannel.FilterLP700 || A_0 == FiberMuxChannel.FilterHP550)
			{
				LampChannel lampChannel = (LampChannel)checked(A_0 - 9);
				foreach (object value in Enum.GetValues(typeof(LampChannel)))
				{
					LampChannel lampChannel2 = (LampChannel)Conversions.ToInteger(value);
					if (lampChannel2 != lampChannel)
					{
						FiberMuxChannel A_2 = FiberMuxChannel.UV;
						m2(lampChannel2, LightState.LightOff, ref A_2);
					}
				}
				foreach (object value2 in Enum.GetValues(typeof(LEDChannel)))
				{
					LEDChannel a_ = (LEDChannel)Conversions.ToInteger(value2);
					FiberMuxChannel A_2 = FiberMuxChannel.UV;
					m2(a_, LightState.LightOff, ref A_2);
				}
			}
			else
			{
				foreach (object value3 in Enum.GetValues(typeof(LEDChannel)))
				{
					LEDChannel lEDChannel = (LEDChannel)Conversions.ToInteger(value3);
					if (lEDChannel != (LEDChannel)A_0)
					{
						FiberMuxChannel A_2 = FiberMuxChannel.UV;
						m2(lEDChannel, LightState.LightOff, ref A_2);
					}
				}
				foreach (object value4 in Enum.GetValues(typeof(LampChannel)))
				{
					LampChannel a_2 = (LampChannel)Conversions.ToInteger(value4);
					FiberMuxChannel A_2 = FiberMuxChannel.UV;
					m2(a_2, LightState.LightOff, ref A_2);
				}
			}
		}
		switch (A_0)
		{
		case FiberMuxChannel.UV:
		{
			FiberMuxChannel A_3 = FiberMuxChannel.UV;
			m2(LEDChannel.UV, A_1, ref A_3);
			break;
		}
		case FiberMuxChannel.Violet:
		{
			FiberMuxChannel A_3 = FiberMuxChannel.UV;
			m2(LEDChannel.Violet, A_1, ref A_3);
			break;
		}
		case FiberMuxChannel.Green:
		{
			FiberMuxChannel A_3 = FiberMuxChannel.UV;
			m2(LEDChannel.Green, A_1, ref A_3);
			break;
		}
		case FiberMuxChannel.Red:
		{
			FiberMuxChannel A_3 = FiberMuxChannel.UV;
			m2(LEDChannel.Red, A_1, ref A_3);
			break;
		}
		case FiberMuxChannel.NIR1:
		{
			FiberMuxChannel A_3 = FiberMuxChannel.UV;
			m2(LEDChannel.NIR1, A_1, ref A_3);
			break;
		}
		case FiberMuxChannel.NIR2:
		{
			FiberMuxChannel A_3 = FiberMuxChannel.UV;
			m2(LEDChannel.NIR2, A_1, ref A_3);
			break;
		}
		case FiberMuxChannel.SWIR1:
		{
			FiberMuxChannel A_3 = FiberMuxChannel.UV;
			m2(LEDChannel.SWIR1, A_1, ref A_3);
			break;
		}
		case FiberMuxChannel.SWIR2:
		{
			FiberMuxChannel A_3 = FiberMuxChannel.UV;
			m2(LEDChannel.SWIR2, A_1, ref A_3);
			break;
		}
		case FiberMuxChannel.SWIR3:
		{
			FiberMuxChannel A_3 = FiberMuxChannel.UV;
			m2(LEDChannel.SWIR3, A_1, ref A_3);
			break;
		}
		case FiberMuxChannel.FilterHP550:
		{
			FiberMuxChannel A_3 = FiberMuxChannel.UV;
			m2(LampChannel.HP550, A_1, ref A_3);
			break;
		}
		case FiberMuxChannel.FilterLP700:
		{
			FiberMuxChannel A_3 = FiberMuxChannel.UV;
			m2(LampChannel.LP700, A_1, ref A_3);
			break;
		}
		case FiberMuxChannel.FilterHP1200:
		{
			FiberMuxChannel A_3 = FiberMuxChannel.UV;
			m2(LampChannel.HP1200, A_1, ref A_3);
			break;
		}
		case FiberMuxChannel.Dark:
			break;
		}
	}

	private int m2(FiberMuxChannel A_0, ref string A_1)
	{
		m2(A_0, LightState.LightOn);
		return p9(A_0, ref A_1);
	}

	private ErrPublic m2(LampChannel A_0, ip A_1, m A_2, global::r.d.a A_3)
	{
		return m2(LEDChannel.UV, A_0, A_2: false, A_1, A_2, A_3);
	}

	private ErrPublic m2(LEDChannel A_0, ip A_1, m A_2, global::r.d.a A_3)
	{
		return m2(A_0, LampChannel.HP550, A_2: true, A_1, A_2, A_3);
	}

	private ErrPublic m2(FiberMuxChannel A_0, ip A_1, m A_2, global::r.d.a A_3)
	{
		switch (A_0)
		{
		case FiberMuxChannel.UV:
		case FiberMuxChannel.Violet:
		case FiberMuxChannel.Green:
		case FiberMuxChannel.Red:
		case FiberMuxChannel.NIR1:
		case FiberMuxChannel.NIR2:
		case FiberMuxChannel.SWIR1:
		case FiberMuxChannel.SWIR2:
		case FiberMuxChannel.SWIR3:
			return m2((LEDChannel)A_0, LampChannel.HP550, A_2: true, A_1, A_2, A_3);
		case FiberMuxChannel.FilterHP550:
		case FiberMuxChannel.FilterLP700:
		case FiberMuxChannel.FilterHP1200:
			return m2(LEDChannel.UV, (LampChannel)checked(A_0 - 9), A_2: false, A_1, A_2, A_3);
		default:
			return ErrPublic.NoLight;
		}
	}

	private ErrPublic m2(LEDChannel A_0, LampChannel A_1, bool A_2, ip A_3, m A_4, global::r.d.a A_5)
	{
		hr A_6 = new hr(null);
		double a_ = A_3.u9();
		bool A_7 = false;
		bool A_8 = default(bool);
		if (m2(A_3, ref A_7, ref A_8, ref A_6, 1, a_, 50, ref A_4.h, A_4.d3()) == ErrPublic.None)
		{
			if (A_8)
			{
				double num = ((!A_2) ? ma.f(A_1) : ma.f(A_0));
				double num2 = num;
				double num3 = 0.0;
				double num4 = num / 2.0;
				do
				{
					if (A_2)
					{
						ma.f(A_0, num4);
						ma.f(A_0, LightState.LightOn);
					}
					else
					{
						ma.f(A_1, num4);
						ma.f(A_1, LightState.LightOn);
					}
					Thread.Sleep(500);
					A_7 = false;
					if (m2(A_3, ref A_7, ref A_8, ref A_6, 1, a_, 50, ref A_4.h, A_4.d3()) == ErrPublic.None)
					{
						if (A_8)
						{
							num2 = num4;
						}
						else
						{
							num3 = num4;
						}
						num4 = (num2 + num3) / 2.0;
						continue;
					}
					A_5.a = global::r.d.a.a.b;
					A_5.b = "Error attempting to collect LED maximum non-saturated signal. Procedure aborted.";
					return ErrPublic.Generic;
				}
				while (!(num2 - num3 < num4 * 0.05));
				if (A_2)
				{
					ma.f(A_0, num3 * 0.85);
					ma.f(A_0, LightState.LightOn);
				}
				else
				{
					ma.f(A_1, num3 * 0.85);
					ma.f(A_1, LightState.LightOn);
				}
				Thread.Sleep(500);
				A_7 = false;
				if (m2(A_3, ref A_7, ref A_8, ref A_6, 1, a_, 50, ref A_4.h, A_4.d3()) == ErrPublic.None && A_8)
				{
					A_5.a = global::r.d.a.a.b;
					A_5.b = "Light is too bright even after being reduced to " + num3 + "%. Procedure aborted.";
					return ErrPublic.Generic;
				}
			}
			return ErrPublic.None;
		}
		A_5.a = global::r.d.a.a.b;
		A_5.b = "Error attempting to collect maximum non-saturated signal. Procedure aborted.";
		return ErrPublic.Generic;
	}

	private void t6()
	{
		foreach (object value in Enum.GetValues(typeof(LEDChannel)))
		{
			LEDChannel a_ = (LEDChannel)Conversions.ToInteger(value);
			ma.f(a_, LightState.LightOff);
			ma.f(a_, 100.0);
		}
		foreach (object value2 in Enum.GetValues(typeof(LampChannel)))
		{
			LampChannel a_2 = (LampChannel)Conversions.ToInteger(value2);
			ma.f(a_2, LightState.LightOff);
			ma.f(a_2, 100.0);
		}
	}

	public void m2(LEDChannel A_0, LightState A_1, ref FiberMuxChannel A_2)
	{
		A_2 = FiberMuxChannel.UV;
		if (ma == null || ma.f(A_0, A_1) != 0)
		{
			throw new ApplicationException("Error attempting to turn on/off the specified channel");
		}
		A_2 = ma.g(A_0);
	}

	public void m2(LampChannel A_0, LightState A_1, ref FiberMuxChannel A_2)
	{
		A_2 = FiberMuxChannel.UV;
		if (ma == null || ma.f(A_0, A_1) != 0)
		{
			throw new ApplicationException("Error attempting to turn on/off the specified channel");
		}
		A_2 = ma.g(A_0);
	}

	public int m2(ref float A_0)
	{
		return ma.f(ref A_0);
	}

	[SpecialName]
	public double[] yj()
	{
		return ma.g();
	}

	[SpecialName]
	public double[] yk()
	{
		return ma.h();
	}

	public void m2(double[] A_0)
	{
		ma.f(A_0);
	}

	public int m2(double A_0, ref string A_1)
	{
		return ma.f(A_0, ref A_1);
	}

	public int p9(FiberMuxChannel A_0, ref string A_1)
	{
		return ma.f(A_0, ref A_1);
	}

	private void m2(ip.i A_0, bool A_1, bool A_2, bool A_3, m A_4, global::r.d.a A_5)
	{
		c1 c10 = null;
		checked
		{
			try
			{
				double[] array = null;
				double[] array2 = null;
				double[] array3 = null;
				hr A_6 = new hr(null);
				double[] A_7 = null;
				double[] array4 = null;
				double[] array5 = null;
				double[] array6 = null;
				int num = 10;
				double a_ = 250.0;
				int index = A_0.b;
				int num2 = A_0.a;
				ip ip2 = iq[num2][index];
				FMUSBDeviceType fMUSBDeviceType = ip2.xs();
				double num5;
				float a_3 = default(float);
				double num31 = default(double);
				float a_6 = default(float);
				int num6 = default(int);
				double[] array13;
				if (A_1)
				{
					int num3 = 10000;
					double[] array7 = null;
					double[] array8 = null;
					double[] array9 = null;
					double[] array10 = null;
					double[] array11 = null;
					double[] array12 = null;
					bool flag = fMUSBDeviceType == FMUSBDeviceType.FIUSB2DeviceSpecUvVis || fMUSBDeviceType == FMUSBDeviceType.FIUSB2DeviceSpecUvVis2;
					bool flag2 = fMUSBDeviceType == FMUSBDeviceType.FIUSB2DeviceSpecNIR2 || fMUSBDeviceType == FMUSBDeviceType.FIUSB2DeviceSpecTCNIR;
					string text = global::i3.o() + "\\Logs\\";
					t6();
					if (A_2)
					{
						int num4 = 1;
						FiberMuxChannel fiberMuxChannel = FiberMuxChannel.UV;
						LampChannel lampChannel = LampChannel.HP550;
						string text2 = null;
						float a_2 = 0f;
						if (A_3)
						{
							if (flag2)
							{
								A_4.h.u(3);
							}
							else
							{
								A_4.h.u(5);
							}
						}
						else
						{
							A_4.h.u(5);
						}
						if (flag2)
						{
							fiberMuxChannel = FiberMuxChannel.FilterHP1200;
							lampChannel = LampChannel.HP1200;
							text2 = "1200nm long pass filter";
						}
						else
						{
							fiberMuxChannel = FiberMuxChannel.FilterHP550;
							lampChannel = LampChannel.HP550;
							text2 = "550nm long pass filter";
						}
						ip2.m2(A_0.e, A_1: true);
						ip2.qh(0f);
						if (A_3)
						{
							e0 e10 = ma;
							string A_8 = null;
							if (e10.f(fiberMuxChannel, ref A_8) != 0)
							{
								A_5.a = global::r.d.a.a.b;
								A_5.b = "Error rotating to " + fiberMuxChannel.ToString() + " mux channel. Procedure aborted.";
								return;
							}
							e10.f(lampChannel, LightState.LightOn);
							Thread.Sleep(1000);
							e10 = null;
						}
						else if (!A_3 && !A_4.h.t("Disconnect fiber from scatter calibration unit and connect fiber from a standard SS stage.\r\nPlace BK7 Reference sample on stage, " + text2 + " in beam path using angled holder.", "Information", "OKString", "CancelString"))
						{
							A_5.a = global::r.d.a.a.b;
							A_5.b = "Operation canceled";
							return;
						}
						A_4.h.t("Adjusting the integration time for the " + text2 + " ...");
						ErrPublic errPublic = m2(ip2, A_4, A_5, a_);
						if (errPublic != ErrPublic.None && errPublic != ErrPublic.LightTooBright)
						{
							return;
						}
						num5 = ip2.u9();
						ip ip3 = ip2;
						if (ip3.m2(ip3.u9(), ip3.vm()) && m2(lampChannel, ip2, A_4, A_5) != ErrPublic.None)
						{
							return;
						}
						ip3 = null;
						A_4.h.t("Acquiring low noise spectrum with " + text2 + " ...");
						num = Math.Min(Math.Max((int)Math.Round(20000.0 / num5), 20), 32767);
						A_4.h.t(num4, DateAndTime.Now, (float)((double)num * 0.001 * num5));
						num4++;
						bool A_9 = false;
						bool A_10 = false;
						if (m2(ip2, ref A_9, ref A_10, ref A_6, 1, num5, (short)num, ref A_4.h, A_4.d3()) != ErrPublic.None)
						{
							A_5.a = global::r.d.a.a.b;
							A_5.b = "Error attempting to collect short scatter spectra. Procedure aborted.";
							return;
						}
						array = A_6.c0();
						a_3 = ip2.wm();
						if (A_3)
						{
							e0 obj = ma;
							string A_11 = null;
							ma.f(lampChannel, LightState.LightOff);
							if (obj.f(FiberMuxChannel.Dark, ref A_11) != 0)
							{
								A_5.a = global::r.d.a.a.b;
								A_5.b = "Error rotating to " + FiberMuxChannel.Dark.ToString() + " mux channel. Procedure aborted.";
								return;
							}
							_ = null;
						}
						else if (!A_4.h.t("Remove reference sample and " + text2 + " from stage\r\n and replace with clean, angled mirror", "Information", "OKString", "CancelString"))
						{
							A_5.a = global::r.d.a.a.b;
							A_5.b = "Operation canceled";
							return;
						}
						A_4.h.t("Acquiring low noise short wavelength filter dark spectrum...");
						A_4.h.t(num4, DateAndTime.Now, (float)((double)num * 0.001 * num5));
						num4++;
						A_10 = false;
						A_9 = false;
						if (m2(ip2, ref A_10, ref A_9, ref A_6, 1, num5, (short)num, ref A_4.h, A_4.d3()) != ErrPublic.None)
						{
							A_5.a = global::r.d.a.a.b;
							A_5.b = "Error attempting to collect short dark spectrum. Procedure aborted.";
							return;
						}
						array4 = A_6.c0();
						A_7 = A_6.cz();
						num6 = A_6.c2();
						array13 = new double[num6 - 1 + 1];
						double[] array14 = new double[num6 - 1 + 1];
						int num7 = num6 - 1;
						for (int num8 = 0; num8 <= num7; num8++)
						{
							array13[num8] = array[num8] - array4[num8];
						}
						f6.SmoothSpectrumGivenThickness(20000f, ref A_7[0], ref array13[0], num6, ref array14[0]);
						ip2.m2(array14, num6, a_3);
						double[] array15 = new double[19]
						{
							0.81, 0.84, 0.87, 0.9, 0.93, 0.96, 0.99, 1.02, 1.05, 1.08,
							1.11, 1.14, 1.17, 1.2, 1.23, 1.26, 1.29, 1.32, 1.35
						};
						Collection<double[]> collection = new Collection<double[]>();
						int num9 = array15.Length;
						int num10 = m2(A_7, num6, 480.0);
						int num11 = m2(A_7, num6, 550.0) - 1;
						double[] array16 = new double[num9 - 1 + 1];
						int num12 = num9 - 1;
						for (int num13 = 0; num13 <= num12; num13++)
						{
							double[] array17 = new double[num6 - 1 + 1];
							array14.CopyTo(array17, 0);
							ip2.p9((float)array15[num13]);
							ip2.p9(array17, num6, a_3);
							collection.Add(array17);
							array16[num13] = m2(array17, num10, num11);
						}
						int num14 = 10;
						double[] array18 = new double[num9 - 1 + 1];
						int num15 = num9 - 1;
						for (int num16 = 0; num16 <= num15; num16++)
						{
							int num17 = num14 - 1;
							for (int num8 = 0; num8 <= num17; num8++)
							{
								array18[num16] += collection[num16][num8];
							}
							array18[num16] /= num14;
						}
						double A_12 = default(double);
						double A_13 = default(double);
						global::jf.a(array15, array18, num9, ref A_12, ref A_13);
						double num18 = (0.0 - A_12) / A_13;
						double[] array19 = new double[num6 - 1 + 1];
						array14.CopyTo(array19, 0);
						ip2.p9((float)num18);
						ip2.p9(array19, num6, a_3);
						double A_14 = default(double);
						bool flag3 = m2(num18, array19, num10, num11, -0.5, ref A_14);
						double[] array20 = new double[num6 - 1 + 1];
						double num19 = default(double);
						if (flag3)
						{
							num19 = m2(num18, A_14, -0.5, array15, array16);
							array14.CopyTo(array20, 0);
							ip2.p9((float)num19);
							ip2.p9(array20, num6, a_3);
						}
						double num20 = 490.0;
						double num21 = 1000.0;
						double a_4 = ((!flag2) ? num20 : num21);
						double[] array21 = new double[num9 - 1 + 1];
						int a_5 = m2(A_7, num6, a_4);
						int num22 = num9 - 1;
						for (int num23 = 0; num23 <= num22; num23++)
						{
							global::jf.a(A_7, collection[num23], a_5, ref A_12, ref A_13);
							array21[num23] = A_13 * A_7[0] + A_12;
						}
						global::jf.a(array15, array21, num9, ref A_12, ref A_13);
						double num24 = (0.0 - A_12) / A_13;
						double[] array22 = new double[num6 - 1 + 1];
						array14.CopyTo(array22, 0);
						ip2.p9((float)num24);
						ip2.p9(array22, num6, a_3);
						bool flag4 = m2(num24, array22, num10, num11, -0.5, ref A_14);
						double[] array23 = new double[num6 - 1 + 1];
						double num25 = default(double);
						if (flag4)
						{
							num25 = m2(num24, A_14, -0.5, array15, array16);
							array14.CopyTo(array23, 0);
							ip2.p9((float)num25);
							ip2.p9(array23, num6, a_3);
						}
						if (flag3)
						{
							ip2.p9((float)num19);
						}
						else
						{
							ip2.p9((float)num18);
						}
						StreamWriter streamWriter = null;
						try
						{
							streamWriter = new StreamWriter(text + "scattEfficiency.csv", append: false, Encoding.ASCII);
							streamWriter.Write("WL, " + num18);
							if (flag3)
							{
								streamWriter.Write(", " + num19);
							}
							streamWriter.Write(", " + num24);
							if (flag4)
							{
								streamWriter.Write(", " + num25);
							}
							double[] array24 = array15;
							for (int num26 = 0; num26 < array24.Length; num26++)
							{
								streamWriter.Write(", " + (float)array24[num26]);
							}
							streamWriter.WriteLine();
							int num27 = num6 - 1;
							for (int num8 = 0; num8 <= num27; num8++)
							{
								streamWriter.Write(A_7[num8] + ", " + array19[num8]);
								if (flag3)
								{
									streamWriter.Write(", " + array20[num8]);
								}
								streamWriter.Write(", " + array22[num8]);
								if (flag4)
								{
									streamWriter.Write(", " + array23[num8]);
								}
								int num28 = collection.Count - 1;
								for (int num29 = 0; num29 <= num28; num29++)
								{
									streamWriter.Write(", " + collection[num29][num8]);
								}
								streamWriter.WriteLine();
							}
						}
						finally
						{
							streamWriter?.Close();
						}
						if (!flag2)
						{
							if (A_3)
							{
								e0 e11 = ma;
								string A_15 = null;
								if (e11.f(FiberMuxChannel.FilterLP700, ref A_15) != 0)
								{
									A_5.a = global::r.d.a.a.b;
									A_5.b = "Error rotating to " + FiberMuxChannel.FilterLP700.ToString() + " mux channel. Procedure aborted.";
									return;
								}
								e11.f(LampChannel.LP700, LightState.LightOn);
								Thread.Sleep(1000);
								e11 = null;
							}
							else
							{
								if (!A_4.h.t("Please insert the long wavelength filters into the light source. Typically this consist of two filters in series. \r\nPlace BK7 Reference sample on stage and additional long wavelength filter\r\n in beam path using an angled holder.\r\nEach filter should have the following characteristics:\r\n Transmission (%) >92, 425 - 675nm  :  Reflection (%) >95, 750 - 1150nm\r\n Typically this filter is the following part: Edmund Optics NT43-843", "Information", "OKString", "CancelString"))
								{
									A_5.a = global::r.d.a.a.b;
									A_5.b = "Operation canceled";
									return;
								}
								A_4.h.t("Stabilization Delay...");
								A_4.h.t(num4, DateAndTime.Now, 60f);
								num4++;
								DateTime now = DateTime.Now;
								float num30;
								do
								{
									num30 = (float)DateTime.Now.Subtract(now).TotalSeconds;
									Thread.Sleep(50);
									Application.DoEvents();
								}
								while (num30 < 60f);
							}
							num31 = ip2.u9();
							A_4.h.t("Setting integration time...");
							errPublic = m2(ip2, A_4, A_5, a_);
							if (errPublic != ErrPublic.None && errPublic != ErrPublic.LightTooBright)
							{
								return;
							}
							ip ip4 = ip2;
							if (ip4.m2(ip4.u9(), ip4.vm()) && m2(LampChannel.LP700, ip2, A_4, A_5) != ErrPublic.None)
							{
								return;
							}
							ip4 = null;
							num = Math.Max((int)Math.Round(20000.0 / num31), 20);
							A_4.h.t("Acquring low noise spectrum with long wavelength cutoff filter...");
							A_4.h.t(num4, DateAndTime.Now, (float)((double)num * 0.001 * num31));
							num4++;
							A_9 = false;
							A_10 = false;
							if (m2(ip2, ref A_9, ref A_10, ref A_6, 1, num31, (short)num, ref A_4.h, A_4.d3()) != ErrPublic.None)
							{
								A_5.a = global::r.d.a.a.b;
								A_5.b = "Error attempting to collect long scatter spectra. Procedure aborted.";
								return;
							}
							array2 = A_6.c0();
							a_6 = ip2.wm();
							if (A_3)
							{
								e0 obj2 = ma;
								string A_16 = null;
								ma.f(LampChannel.LP700, LightState.LightOff);
								if (obj2.f(FiberMuxChannel.Dark, ref A_16) != 0)
								{
									A_5.a = global::r.d.a.a.b;
									A_5.b = "Error rotating to " + FiberMuxChannel.Dark.ToString() + " mux channel. Procedure aborted.";
									return;
								}
								_ = null;
							}
							else if (!A_4.h.t("Remove reference sample and additional long wavelength filter from stage\r\n and replace with clean, angled mirror", "Information", "OKString", "CancelString"))
							{
								A_5.a = global::r.d.a.a.b;
								A_5.b = "Operation canceled";
								return;
							}
							A_4.h.t("Acquring low noise long wavelength filter dark spectrum...");
							A_4.h.t(num4, DateAndTime.Now, (float)((double)num * 0.001 * num31));
							num4++;
							A_10 = false;
							A_9 = false;
							if (m2(ip2, ref A_10, ref A_9, ref A_6, 1, num31, (short)num, ref A_4.h, A_4.d3()) != ErrPublic.None)
							{
								A_5.a = global::r.d.a.a.b;
								A_5.b = "Error attempting to collect short dark spectrum. Procedure aborted.";
								return;
							}
							array5 = A_6.c0();
							A_7 = A_6.cz();
							num6 = A_6.c2();
							array13 = new double[num6 - 1 + 1];
							array14 = new double[num6 - 1 + 1];
							int num32 = num6 - 1;
							for (int num8 = 0; num8 <= num32; num8++)
							{
								array13[num8] = array2[num8] - array5[num8];
							}
							f6.SmoothSpectrumGivenThickness(20000f, ref A_7[0], ref array13[0], num6, ref array14[0]);
							ip2.m2(array14, num6, a_6);
							double num33 = 0.0;
							int num34 = num6 - 1;
							for (int num8 = 0; num8 <= num34; num8++)
							{
								num33 += array14[num8];
							}
							double[] array25 = new double[num6 - 1 + 1];
							array14.CopyTo(array25, 0);
							ip2.p9(array25, num6, a_6);
							int num35 = global::jf.a(ref A_7, num6, 900.0);
							int num36 = num6 - 1;
							double num37 = 0.0;
							int num38 = num35;
							int num39 = num36;
							for (int num8 = num38; num8 <= num39; num8++)
							{
								num37 += array25[num8];
							}
							num37 /= (double)(num36 - num35 + 1);
							a_2 = (float)(num37 / num33);
							ip2.qh(a_2);
							double[] array26 = new double[num6 - 1 + 1];
							array14.CopyTo(array26, 0);
							ip2.p9(array26, num6, a_6);
							StreamWriter streamWriter2 = null;
							try
							{
								streamWriter2 = new StreamWriter(text + "scattOffset.csv", append: false, Encoding.ASCII);
								streamWriter2.WriteLine("WL, offset=0, offset=" + a_2);
								int num40 = num6 - 1;
								for (int num8 = 0; num8 <= num40; num8++)
								{
									streamWriter2.WriteLine(A_7[num8] + ", " + array25[num8] + ", " + array26[num8]);
								}
							}
							finally
							{
								streamWriter2?.Close();
							}
						}
						ip.g g10 = A_0.e;
						if (flag3)
						{
							g10.h = num19;
						}
						else
						{
							g10.h = num18;
						}
						g10.i = a_2;
						g10 = null;
					}
					else if (u3())
					{
						List<double[]> list = new List<double[]>();
						List<LEDChannel> list2 = new List<LEDChannel>();
						List<float> list3 = new List<float>();
						List<float> list4 = new List<float>();
						int num41 = ip2.vw();
						double[] A_17 = null;
						int num42 = 0;
						double num43 = 390.0;
						short num44;
						int A_18 = default(int);
						int num48;
						double num49;
						try
						{
							StreamWriter streamWriter3 = null;
							string path = text + "LED Scatter Summary.csv";
							num44 = (short)Math.Round((float)ip2.vw() / 23.5f);
							int num45;
							LEDChannel lEDChannel;
							LEDChannel lEDChannel2;
							if (flag)
							{
								num45 = 6;
								lEDChannel = LEDChannel.UV;
								lEDChannel2 = LEDChannel.NIR2;
							}
							else if (flag2)
							{
								num45 = 4;
								lEDChannel = LEDChannel.NIR2;
								lEDChannel2 = LEDChannel.SWIR3;
							}
							else
							{
								num45 = 5;
								lEDChannel = LEDChannel.Violet;
								lEDChannel2 = LEDChannel.NIR2;
							}
							if (!flag2 && !ip2.x9())
							{
								A_5.a = global::r.d.a.a.b;
								A_5.b = "Cannot calibrate wavelength scatter because 'Restrict wavelength range' is not active. The scatter calibration will be aborted.\r\nPlease check the 'Restrict wavelength range' checkbox and then click 'Write Firmware' prior to reattempting the scatter calibration.";
								return;
							}
							A_4.h.t(1f);
							ip2.qh(ref A_18);
							int num46 = ip2.vw();
							double num47 = (double)(num44 * (num46 - 1)) / (double)(num41 - 1);
							num48 = ((!((double)(int)Math.Round(num47) < num47)) ? ((int)Math.Round(num47)) : ((int)Math.Round(num47) + 1));
							num49 = (double)(num46 - 1) / (double)num48;
							try
							{
								streamWriter3 = new StreamWriter(path, append: false, Encoding.ASCII);
								streamWriter3.WriteLine("extendedPoints, extendedPointSpacing, extendedPointOffset");
								streamWriter3.WriteLine(num48 + ", " + num49 + ", " + A_18 + "\r\n");
								streamWriter3.WriteLine("LED Type, left50PctIdx, centralIdx, right50PctIdx, excludeStartIdx, excludeEndIdx, left50PctWavelength, centerWavelength, right50PctWavelength, peakCounts, LED Gain%, IntTime, numSpectraToAverageForScatter");
							}
							finally
							{
								streamWriter3?.Close();
							}
							foreach (object value in Enum.GetValues(typeof(LEDChannel)))
							{
								LEDChannel a_7 = unchecked((LEDChannel)Conversions.ToInteger(value));
								ma.f(a_7, LightState.LightOff);
							}
							Thread.Sleep(1000);
							LEDChannel num50 = lEDChannel;
							LEDChannel lEDChannel3 = lEDChannel2;
							bool A_20 = default(bool);
							double A_23 = default(double);
							double A_24 = default(double);
							double A_25 = default(double);
							double A_26 = default(double);
							double num94 = default(double);
							double num93 = default(double);
							double num92 = default(double);
							double num91 = default(double);
							double num95 = default(double);
							int num96 = default(int);
							for (LEDChannel a_7 = num50; a_7 <= lEDChannel3; a_7 = unchecked(a_7 + 1))
							{
								string A_19 = null;
								e0 e12 = ma;
								if (e12.f(e12.g(a_7), ref A_19) != 0)
								{
									A_5.a = global::r.d.a.a.b;
									A_5.b = "Error rotating to " + a_7.ToString() + " mux channel. Procedure aborted.";
									return;
								}
								A_4.h.t("Adjusting the integration time for the " + a_7.ToString() + " LED ...");
								e12.f(a_7, LightState.LightOn);
								Thread.Sleep(1000);
								m2(ip2, A_4, A_5, a_);
								e12 = null;
								double a_8 = ip2.u9();
								ip ip5 = ip2;
								if (ip5.m2(ip5.u9(), ip5.vm()) && m2(a_7, ip2, A_4, A_5) != ErrPublic.None)
								{
									return;
								}
								ip5 = null;
								num = ((!((double)num3 * ip2.u9() < 90000.0)) ? ((int)Math.Round(90000.0 / ip2.u9())) : num3);
								double num51 = (double)num * ip2.u9();
								int num52 = (int)Math.Round(Math.Floor((double)num / (num51 / 5000.0)));
								int num53 = (int)Math.Round(num51 / ((double)num52 * ip2.u9()));
								if ((double)(num53 * num52) * ip2.u9() < 90000.0)
								{
									num53++;
								}
								double[] array27 = new double[num53 + 1];
								float[] array28 = new float[num53 + 1];
								float num54 = 0f;
								if (A_4.h.a)
								{
									A_5.a = global::r.d.a.a.b;
									A_5.b = "Operation canceled";
									return;
								}
								A_4.h.t("Acquiring Initial Dark for " + a_7.ToString() + " LED ...");
								bool A_9 = false;
								if (m2(ip2, ref A_9, ref A_20, ref A_6, 1, a_8, (short)num52, ref A_4.h, A_4.d3()) == ErrPublic.None)
								{
									array8 = A_6.c0();
									A_7 = A_6.cz();
									num6 = A_6.c2();
									int num55 = num6 - 1;
									for (index = 0; index <= num55; index++)
									{
										array27[0] += A_6.c0()[index];
									}
									array27[0] /= A_6.c2();
									array28[0] = ip2.wm();
									float num56 = ip2.wm();
									int num57 = num53 - 1;
									for (int num58 = 0; num58 <= num57; num58++)
									{
										if (A_4.h.a)
										{
											A_5.a = global::r.d.a.a.b;
											A_5.b = "Operation canceled";
											return;
										}
										num54 = (float)Math.Max(100.0 * ((double)num42 / (double)num45 + (double)(num58 + 1) / (double)num53 / (double)num45), 1.0);
										A_4.h.t("Acquiring Scatter for " + a_7.ToString() + " LED (" + (num58 + 1) + " of " + num53 + ") ...");
										A_4.h.t(num54);
										if (A_4.h.a)
										{
											A_5.a = global::r.d.a.a.b;
											A_5.b = "Operation canceled";
											return;
										}
										ma.f(a_7, LightState.LightOn);
										Thread.Sleep(1000);
										A_9 = false;
										if (m2(ip2, ref A_9, ref A_20, ref A_6, 1, a_8, (short)num52, ref A_4.h, A_4.d3()) == ErrPublic.None)
										{
											if (num58 == 0)
											{
												array7 = A_6.c0();
											}
											else
											{
												int num59 = num6 - 1;
												for (index = 0; index <= num59; index++)
												{
													array7[index] += A_6.c0()[index];
												}
											}
											ma.f(a_7, LightState.LightOff);
											Thread.Sleep(1000);
											if (A_4.h.a)
											{
												A_5.a = global::r.d.a.a.b;
												A_5.b = "Operation canceled";
												return;
											}
											Thread.Sleep(1000);
											if (A_4.h.a)
											{
												A_5.a = global::r.d.a.a.b;
												A_5.b = "Operation canceled";
												return;
											}
											A_9 = false;
											if (m2(ip2, ref A_9, ref A_20, ref A_6, 1, a_8, (short)num52, ref A_4.h, A_4.d3()) == ErrPublic.None)
											{
												int num60 = num6 - 1;
												for (index = 0; index <= num60; index++)
												{
													array8[index] += A_6.c0()[index];
													array27[num58 + 1] += A_6.c0()[index];
												}
												array27[num58 + 1] /= A_6.c2();
												array28[num58 + 1] = ip2.wm();
												num56 += ip2.wm();
												continue;
											}
											A_5.a = global::r.d.a.a.b;
											A_5.b = "Error attempting to collect spectrum with LED off. Procedure aborted.";
											return;
										}
										A_5.a = global::r.d.a.a.b;
										A_5.b = "Error attempting to collect spectrum with LED on. Procedure aborted.";
										return;
									}
									array9 = new double[num6 - 1 + 1];
									int num61 = num6 - 1;
									for (index = 0; index <= num61; index++)
									{
										array7[index] /= num53;
										array8[index] /= num53 + 1;
										array9[index] = array7[index] - array8[index];
									}
									num56 /= (float)(num53 + 1);
									ip2.m2(array9, num6, num56);
									array10 = new double[num6 - 1 + 1];
									array9.CopyTo(array10, 0);
									double num62 = 0.0;
									int num63 = num6 - 1;
									for (int num8 = 0; num8 <= num63; num8++)
									{
										num62 += array9[num8];
									}
									array11 = new double[num6 - 1 + 1];
									int num64 = num6 - 1;
									for (int num8 = 0; num8 <= num64; num8++)
									{
										array11[num8] = array9[num8] / num62;
									}
									int num65 = 0;
									int num66 = num6 - 1;
									int a_9 = num6;
									double[] a_10 = array9;
									int A_21 = 0;
									int A_22 = 0;
									m2(a_9, a_10, ref A_23, ref A_24, ref A_25, ref A_26, ref A_21, ref A_22);
									double num67 = (A_25 - A_24) / 2.0;
									double num68 = 7.0 * num67;
									array12 = global::jf.a(array11, num6, 2);
									double num69 = double.MinValue;
									int num70 = 0;
									double num71 = double.MaxValue;
									int num72 = num6 - 1;
									double num73 = double.MinValue;
									double num74 = double.MaxValue;
									A_22 = num6 - 3;
									for (int num8 = 2; num8 <= A_22; num8++)
									{
										if (array12[num8] > num69)
										{
											num69 = array12[num8];
											num70 = num8;
										}
										if (array12[num8] < num71)
										{
											num71 = array12[num8];
											num72 = num8;
										}
										if ((double)num8 < A_26 - num68 || (double)num8 > A_26 + num68)
										{
											if (array12[num8] > num73)
											{
												num73 = array12[num8];
											}
											if (array12[num8] < num74)
											{
												num74 = array12[num8];
											}
										}
									}
									if (num73 == double.MinValue)
									{
										num73 = num69 / 100.0;
									}
									if (num74 == double.MaxValue)
									{
										num74 = num71 / 100.0;
									}
									double num75 = 3.0 * num73;
									double num76 = 3.0 * num74;
									A_21 = num70 - 1;
									for (int num8 = 0; num8 <= A_21; num8++)
									{
										if (array12[num8] > num75)
										{
											num65 = Math.Max(num8 - (int)Math.Round(num67), 0);
											break;
										}
									}
									int num77 = num6 - 1;
									int num78 = num72 + 1;
									for (int num8 = num77; num8 >= num78; num8 += -1)
									{
										if (array12[num8] < num76)
										{
											num66 = Math.Min(num8 + (int)Math.Round(num67), num6 - 1);
											break;
										}
									}
									int num79 = unchecked(num46 / num48);
									double[] array29 = new double[num48 - 1 + 1];
									int num80 = num48 - 1;
									for (int num81 = 0; num81 <= num80; num81++)
									{
										double num82 = (double)num81 * num49;
										int num83 = (int)Math.Round(num82 + 0.5);
										int num84 = ((num81 != num48 - 1) ? ((int)Math.Round(num82 + num49 + 0.5)) : (num6 - 1));
										double num85 = num82 + num49 / 2.0;
										double num86 = 0.0;
										int num87 = 0;
										int num88 = num84;
										for (int num8 = num83; num8 <= num88; num8++)
										{
											if (num8 < num65 || num8 > num66)
											{
												num86 += array10[num8];
												num87++;
											}
										}
										if (num87 < num79)
										{
											int num89 = Math.Min(num83 - 1, num65 - 1);
											int num90 = Math.Max(num84 + 1, num66 + 1);
											bool flag5 = num89 <= 0;
											bool flag6 = num90 >= num6;
											while (num87 < num79)
											{
												if (!flag5 && (flag6 || Math.Abs((double)num89 - num85) < Math.Abs((double)num90 - num85)))
												{
													num87++;
													num86 += array10[num89];
													num89--;
													flag5 = num89 < 0;
												}
												else
												{
													num87++;
													num86 += array10[num90];
													num90++;
													flag6 = num90 >= num6;
												}
											}
										}
										array29[num81] = num86 / (double)num87 / num62;
										if (array29[num81] < 0.0)
										{
											array29[num81] = 0.0;
										}
									}
									if (A_24 > 0.0 && A_25 < (double)(num6 - 1))
									{
										list.Add(array29);
										list2.Add(a_7);
										list3.Add((float)A_26);
										list4.Add((float)((A_25 - A_24) / 2.0));
									}
									switch (a_7)
									{
									case LEDChannel.UV:
										num94 = A_26;
										A_17 = new double[num6 - 1 + 1];
										global::jf.a(A_7, array11, num6, 20, ref A_17);
										break;
									case LEDChannel.Violet:
										num93 = A_26;
										break;
									case LEDChannel.Green:
										num92 = A_26;
										break;
									case LEDChannel.Red:
										num91 = A_26;
										break;
									}
									try
									{
										streamWriter3 = new StreamWriter(path, append: true, Encoding.ASCII);
										streamWriter3.WriteLine(a_7.ToString() + ", " + A_24 + ", " + A_26 + ", " + A_25 + ", " + num65 + ", " + num66 + ", " + A_7[(int)Math.Round(Math.Round(A_24))] + ", " + A_7[(int)Math.Round(Math.Round(A_26))] + ", " + A_7[(int)Math.Round(Math.Round(A_25))] + ", " + A_23 + ", " + ma.f(a_7).ToString("0.0") + ", " + a_8 + ", " + num);
									}
									finally
									{
										streamWriter3?.Close();
									}
									StreamWriter streamWriter4 = null;
									try
									{
										streamWriter4 = new StreamWriter(text + "Spec " + a_7.ToString() + " LED.csv", append: false, Encoding.ASCII);
										streamWriter4.WriteLine("LED Type, left50PctIdx, centralIdx, right50PctIdx, excludeStartIdx, excludeEndIdx, left50PctWavelength, centerWavelength, right50PctWavelength, maxNonSatIntTime, numSpectraToAverageForScatter, boostedIntTime, numSpectraToAverageForBoostedScatter");
										streamWriter4.WriteLine(a_7.ToString() + ", " + A_24 + ", " + A_26 + ", " + A_25 + ", " + num65 + ", " + num66 + ", " + A_7[(int)Math.Round(Math.Round(A_24))] + ", " + A_7[(int)Math.Round(Math.Round(A_26))] + ", " + A_7[(int)Math.Round(Math.Round(A_25))] + ", " + a_8 + ", " + num + ", " + num95 + ", " + num96 + "\r\n");
										streamWriter4.WriteLine("extendedPoints, extendedPointSpacing, extendedPointOffset");
										streamWriter4.WriteLine(num48 + ", " + num49 + ", " + A_18 + "\r\n");
										streamWriter4.WriteLine("reducedSpecIdx, scatterCoeff");
										int num97 = num48 - 1;
										for (int num98 = 0; num98 <= num97; num98++)
										{
											streamWriter4.WriteLine(num98 + ", " + array29[num98]);
										}
										streamWriter4.WriteLine("\r\n");
										streamWriter4.WriteLine("WL, TInt=" + a_8.ToString("0.0"));
										int num99 = num6 - 1;
										for (int num8 = 0; num8 <= num99; num8++)
										{
											streamWriter4.WriteLine(A_7[num8] + ", " + array9[num8] + ", " + array12[num8] + ", " + array11[num8]);
										}
									}
									finally
									{
										streamWriter4?.Close();
									}
									num42++;
									continue;
								}
								A_5.a = global::r.d.a.a.b;
								A_5.b = "Error attempting to collect spectrum with LED off. Procedure aborted.";
								return;
							}
							if (!flag2)
							{
								int index2 = list2.IndexOf(LEDChannel.Red);
								int index3 = list2.IndexOf(LEDChannel.Green);
								int index4 = list2.IndexOf(LEDChannel.Violet);
								int num100 = list2.IndexOf(LEDChannel.UV);
								_ = (num91 - num92) / num49;
								double a_11 = (num92 - num93) / num49;
								double num101 = (num92 - num94) / num49;
								num43 = ((num100 < 0) ? 390.0 : m2(num48, num49, A_7, num101, list[num100], list[index3], A_17, 370.0, 425.0, 390.0));
								double[] array30 = new double[num48 - 1 + 1];
								f6.BoxSmoothSpectrum(5, ref list[index3][0], num48, ref array30[0]);
								int A_27 = default(int);
								int A_28 = default(int);
								m2(num48, array30, ref A_27, ref A_28);
								double num102 = double.MaxValue;
								int num103 = A_28;
								int num104 = A_27;
								int num106 = default(int);
								for (int num105 = num103; num105 >= num104; num105 += -1)
								{
									if (list[index3][num105] < num102)
									{
										num102 = list[index3][num105];
										num106 = num105;
									}
								}
								double[] array31 = new double[num106 - A_27 + 1];
								double[] array32 = new double[num106 - A_27 + 1];
								int num107 = num106 - A_27;
								for (int num108 = 0; num108 <= num107; num108++)
								{
									array31[num108] = A_27 + num108;
									array32[num108] = list[index3][A_27 + num108];
								}
								int num109 = array32.Length;
								double[] array33 = new double[num109 - 1 + 1];
								short[] array34 = new short[4] { 0, 1, 1, 1 };
								double[] array35 = new double[4]
								{
									list[index3][A_27],
									-0.5,
									A_27,
									list[index3][num106]
								};
								double[] array36 = new double[4] { 1E-07, 1E-05, 0.001, 1E-07 };
								f6.SolveExponential(1000, 0.999f, 0.001f, (short)num109, ref array31[0], ref array32[0], ref array33[0], ref array35[0], ref array36[0], ref array34[0], f6.UniqueMeasEngineID());
								int num110 = ((num100 >= 0) ? (num48 + (int)Math.Round(num101) + 1) : (num48 + (int)Math.Round(a_11) + 1));
								double[] array37 = new double[num110 - 1 + 1];
								int num111 = A_28 + 1;
								int num112 = num48 - 1;
								for (int num113 = num111; num113 <= num112; num113++)
								{
									list[index3][num113] = array35[0] * Math.Exp(array35[1] * ((double)num113 - array35[2])) + array35[3];
								}
								int num114 = num48 - 1;
								for (int num115 = 0; num115 <= num114; num115++)
								{
									array37[num115] = list[index3][num115];
								}
								int num116 = num48;
								int num117 = num110 - 1;
								for (int num118 = num116; num118 <= num117; num118++)
								{
									array37[num118] = array35[0] * Math.Exp(array35[1] * ((double)num118 - array35[2])) + array35[3];
								}
								m2(num48, num110, a_11, num93 / num49, list[index4], array37);
								if (num100 >= 0)
								{
									m2(num48, num110, num101, num94 / num49, list[num100], array37);
								}
								int num119 = num48 - 1;
								int num120 = A_28 - 5;
								for (int num121 = num119; num121 >= num120 && list[index3][num121] > list[index2][num121]; num121 += -1)
								{
									list[index3][num121] = list[index2][num121];
								}
								int num122 = num48 - 1;
								int num123 = A_28 - 5;
								for (int num124 = num122; num124 >= num123 && list[index4][num124] > list[index2][num124]; num124 += -1)
								{
									list[index4][num124] = list[index2][num124];
								}
								if (num100 >= 0)
								{
									int num125 = num48 - 1;
									int num126 = A_28 - 5;
									for (int num127 = num125; num127 >= num126 && list[num100][num127] > list[index2][num127]; num127 += -1)
									{
										list[num100][num127] = list[index2][num127];
									}
								}
							}
							StreamWriter streamWriter5 = null;
							try
							{
								streamWriter5 = new StreamWriter(text + "LEDScatterCoeffs.csv", append: false, Encoding.ASCII);
								streamWriter5.Write("reducedSpecIdx");
								foreach (LEDChannel item in list2)
								{
									streamWriter5.Write(", " + item);
								}
								streamWriter5.WriteLine();
								int num128 = num48 - 1;
								for (int num129 = 0; num129 <= num128; num129++)
								{
									streamWriter5.Write(num129.ToString());
									int num130 = list.Count - 1;
									for (int num131 = 0; num131 <= num130; num131++)
									{
										streamWriter5.Write(", " + Conversions.ToString(list[num131][num129]));
									}
									streamWriter5.WriteLine();
								}
							}
							finally
							{
								streamWriter5?.Close();
							}
						}
						finally
						{
							ip2.ul();
						}
						ip.g g11 = A_0.e;
						g11.n((short)list.Count);
						g11.a = num44;
						g11.b = (short)num48;
						g11.c = 80;
						g11.d = 80;
						g11.e = num49;
						g11.f = (short)A_18;
						g11.p(list4.ToArray());
						float[] array38 = new float[g11.n() - 1 + 1];
						ushort[] array39 = new ushort[g11.n() * num48 - 1 + 1];
						double num132 = double.MinValue;
						int num133 = g11.n() - 1;
						for (int num134 = 0; num134 <= num133; num134++)
						{
							array38[num134] = list3[num134] - (float)A_18;
							int num135 = num48 - 1;
							for (int num136 = 0; num136 <= num135; num136++)
							{
								if (num132 < list[num134][num136])
								{
									num132 = list[num134][num136];
								}
							}
						}
						g11.n(array38);
						g11.g = num132;
						int num137 = g11.n() - 1;
						for (int num138 = 0; num138 <= num137; num138++)
						{
							int num139 = num48 - 1;
							for (int num140 = 0; num140 <= num139; num140++)
							{
								array39[num138 * num48 + num140] = (ushort)Math.Round(65535.0 * Math.Max(list[num138][num140] / num132, 0.0));
							}
						}
						g11.n(array39);
						g11.o = (float)num43;
						g11 = null;
					}
					A_5.a = global::r.d.a.a.a;
					A_5.b = "LED scatter data was successfully written to file.";
					return;
				}
				ip.f obj3 = A_0.d;
				obj3.b = 0f;
				obj3.d = 640f;
				obj3.e = 660f;
				obj3.c = 0f;
				obj3.h = 0;
				obj3.g = 0f;
				obj3.f = 0f;
				obj3.j = 0;
				obj3.i = 0f;
				_ = null;
				bool flag7 = fMUSBDeviceType == FMUSBDeviceType.FIUSB2DeviceSpecUvVis2;
				bool flag8 = default(bool);
				bool flag9 = default(bool);
				bool flag10 = default(bool);
				if (fMUSBDeviceType == FMUSBDeviceType.FIUSB2DeviceSpecUvVis || fMUSBDeviceType == FMUSBDeviceType.FIUSB2DeviceSpecLC || fMUSBDeviceType == FMUSBDeviceType.FIUSB2DeviceSpecUvVis2)
				{
					a_ = 100.0;
					num = 1000;
					flag8 = true;
					if (ip2.vu() >= 400f || ip2.vv() <= 450f)
					{
						Interaction.MsgBox("Cannot calibrate short wavelength scatter because algorithm uses wavelength range of " + Conversions.ToString(400f) + " nm to " + Conversions.ToString(450f) + " nm and this range is not returned by the spectrometer. Short wave scatter calibration will be skipped.");
						flag9 = true;
					}
					if (ip2.vu() >= 950f || ip2.vv() <= 1050f)
					{
						Interaction.MsgBox("Cannot calibrate long wavelength scatter because algorithm uses wavelength range of " + Conversions.ToString(950f) + " nm to " + Conversions.ToString(1050f) + " nm and this range is not returned by the spectrometer. Long wave scatter calibration will be skipped.");
						flag10 = true;
					}
					if (!ip2.x9())
					{
						A_5.a = global::r.d.a.a.b;
						A_5.b = "Cannot calibrate wavelength scatter because 'Restrict wavelength range' is not active. The scatter calibration will be aborted.\r\nPlease check the 'Restrict wavelength range' checkbox and then click 'Write Firmware' prior to reattempting the scatter calibration.";
						return;
					}
				}
				if (Interaction.MsgBox("If there is no second order light filter in the spectrometer then please set the wavelength from 380 to 1100.\r\nClick OK to continue if wavelength limits are correct, click Cancel to exit", MsgBoxStyle.OkCancel) == MsgBoxResult.Cancel)
				{
					A_5.a = global::r.d.a.a.b;
					A_5.b = "Operation canceled";
					return;
				}
				double a_12 = default(double);
				if (flag8)
				{
					if (Interaction.MsgBox("Place Si Reference sample on stage, 550 nm cutoff filter in beam path using angled holder", MsgBoxStyle.OkCancel) == MsgBoxResult.Cancel)
					{
						A_5.a = global::r.d.a.a.b;
						A_5.b = "Operation canceled";
						return;
					}
					c10 = new c1();
					c10.d("Setting integration time...");
					if (m2(ip2, A_4, A_5, a_) != ErrPublic.None)
					{
						return;
					}
					c10.i();
					c10 = null;
					num5 = ip2.u9();
					ip ip6 = ip2;
					if (ip6.m2(ip6.u9(), ip6.vm()))
					{
						bool A_9 = false;
						bool A_29 = default(bool);
						if (m2(ip2, ref A_9, ref A_29, ref A_6, 1, ip6.u9(), (short)num, ref A_4.h, A_4.d3()) != ErrPublic.None)
						{
							A_5.a = global::r.d.a.a.b;
							A_5.b = "Error attempting to collect short scatter spectra. Procedure aborted.";
							return;
						}
						if (A_29)
						{
							A_5.a = global::r.d.a.a.b;
							A_5.b = "Light is too bright. Please reduce light intensity by using less reflective sample or changing light source.\r\nProcedure aborted.";
							return;
						}
					}
					ip6 = null;
					if (!flag9)
					{
						c10 = new c1();
						c10.d("Acquiring low noise spectrum with 550 nm cutoff filter...");
						bool A_9 = false;
						bool A_10 = false;
						if (m2(ip2, ref A_9, ref A_10, ref A_6, 1, ip2.u9(), (short)num, ref A_4.h, A_4.d3()) != ErrPublic.None)
						{
							A_5.a = global::r.d.a.a.b;
							A_5.b = "Error attempting to collect short scatter spectra. Procedure aborted.";
							return;
						}
						array = A_6.c0();
						a_3 = ip2.wm();
						c10.i();
						c10 = null;
					}
					if (!flag10)
					{
						string text3 = null;
						if (!flag9)
						{
							text3 = "Please remove the 550 nm cutoff filter.\r\n";
						}
						if (Interaction.MsgBox(text3 + "Please insert the long wavelength filters into the light source. Typically this will consist of two filters in series. Each filter should have the following characteristics:\r\nTransmission (%) >92, 425 - 675nm \r\nReflection (%) >95, 750 - 1150nm\r\n\r\nTypically this filter is the following part:\r\nEdmund Optics NT43-843", MsgBoxStyle.OkCancel) == MsgBoxResult.Cancel)
						{
							A_5.a = global::r.d.a.a.b;
							A_5.b = "Operation canceled ";
							return;
						}
						c10 = new c1();
						c10.a(60f, "Stabilization Delay...");
						DateTime now2 = DateTime.Now;
						float num30;
						do
						{
							num30 = (float)DateTime.Now.Subtract(now2).TotalSeconds;
							Thread.Sleep(50);
							Application.DoEvents();
						}
						while (num30 < 60f && c10.DialogResult != DialogResult.Cancel);
						if (c10.DialogResult == DialogResult.Cancel)
						{
							A_5.a = global::r.d.a.a.b;
							A_5.b = "Operation canceled";
							return;
						}
						c10.i();
						c10 = null;
						c10 = new c1();
						c10.d("Setting integration time...");
						if (m2(ip2, A_4, A_5, a_) != ErrPublic.None)
						{
							return;
						}
						c10.i();
						c10 = null;
						num31 = ip2.u9();
						c10 = new c1();
						c10.d("Acquring low noise spectrum with long wavelength cutoff filter...");
						bool A_10 = false;
						bool A_9 = false;
						if (m2(ip2, ref A_10, ref A_9, ref A_6, 1, ip2.u9(), (short)num, ref A_4.h, A_4.d3()) != ErrPublic.None)
						{
							A_5.a = global::r.d.a.a.b;
							A_5.b = "Error attempting to collect long scatter spectra. Procedure aborted.";
							return;
						}
						array2 = A_6.c0();
						a_6 = ip2.wm();
						c10.i();
						c10 = null;
						if (!flag9)
						{
							if (Interaction.MsgBox("Install short (in beam path) and long (in light source) wavelength cutoff filters", MsgBoxStyle.OkCancel) == MsgBoxResult.Cancel)
							{
								A_5.a = global::r.d.a.a.b;
								A_5.b = "Operation canceled ";
								return;
							}
							c10 = new c1();
							c10.d("Setting integration time...");
							if (m2(ip2, A_4, A_5, a_) != ErrPublic.None)
							{
								return;
							}
							c10.i();
							c10 = null;
							a_12 = ip2.u9();
							c10 = new c1();
							c10.d("Acquring low noise spectrum with short and long wavelength cutoff filter...");
							A_9 = false;
							A_10 = false;
							if (m2(ip2, ref A_9, ref A_10, ref A_6, 1, ip2.u9(), (short)num, ref A_4.h, A_4.d3()) != ErrPublic.None)
							{
								A_5.a = global::r.d.a.a.b;
								A_5.b = "Error attempting to collect short and long scatter spectra. Procedure aborted.";
								return;
							}
							array3 = A_6.c0();
							a_6 = ip2.wm();
							c10.i();
							c10 = null;
						}
					}
				}
				else
				{
					Interaction.MsgBox("Make sure light source is turned on and that 515 nm cutoff filter is installed in light source");
					num5 = ip2.u9();
					flag10 = true;
				}
				if (Interaction.MsgBox("Remove reference sample from stage and replace with clean, angled mirror", MsgBoxStyle.OkCancel) == MsgBoxResult.Cancel)
				{
					A_5.a = global::r.d.a.a.b;
					A_5.b = "Operation canceled";
					return;
				}
				if (!flag9)
				{
					c10 = new c1();
					c10.d("Acquring low noise short wavelength filter dark spectrum...");
					bool A_10 = false;
					bool A_9 = false;
					if (m2(ip2, ref A_10, ref A_9, ref A_6, 1, num5, (short)num, ref A_4.h, A_4.d3()) != ErrPublic.None)
					{
						A_5.a = global::r.d.a.a.b;
						A_5.b = "Error attempting to collect short dark spectrum. Procedure aborted.";
						return;
					}
					array4 = A_6.c0();
					A_7 = A_6.cz();
					num6 = A_6.c2();
					c10.i();
					c10 = null;
				}
				if (!flag10)
				{
					c10 = new c1();
					c10.d("Acquring low noise long wavelength filter dark spectrum...");
					bool A_9 = false;
					bool A_10 = false;
					if (m2(ip2, ref A_9, ref A_10, ref A_6, 1, num31, (short)num, ref A_4.h, A_4.d3()) != ErrPublic.None)
					{
						A_5.a = global::r.d.a.a.b;
						A_5.b = "Error attempting to collect long dark spectrum. Procedure aborted.";
						return;
					}
					array5 = A_6.c0();
					A_7 = A_6.cz();
					num6 = A_6.c2();
					c10.i();
					c10 = null;
					if (!flag9)
					{
						c10 = new c1();
						c10.d("Acquring low noise short and long wavelength filter dark spectrum...");
						A_10 = false;
						A_9 = false;
						if (m2(ip2, ref A_10, ref A_9, ref A_6, 1, a_12, (short)num, ref A_4.h, A_4.d3()) != ErrPublic.None)
						{
							A_5.a = global::r.d.a.a.b;
							A_5.b = "Error attempting to collect short and long dark spectrum. Procedure aborted.";
							return;
						}
						array6 = A_6.c0();
						A_7 = A_6.cz();
						num6 = A_6.c2();
						c10.i();
						c10 = null;
					}
				}
				array13 = new double[num6 - 1 + 1];
				if (flag8)
				{
					if (!flag9)
					{
						int num141 = num6 - 1;
						int num8;
						for (num8 = 0; num8 <= num141; num8++)
						{
							array13[num8] = array[num8] - array4[num8];
						}
						ip2.m2(array13, num6, a_3);
						double num142 = 0.0;
						int num143 = num6 - 1;
						for (num8 = 0; num8 <= num143; num8++)
						{
							num142 += array13[num8];
						}
						double[] array40 = new double[40];
						double[] array41 = new double[40];
						num8 = 0;
						do
						{
							array41[num8] = num8;
							array40[num8] = array13[num8];
							num8++;
						}
						while (num8 <= 39);
						double A_30 = default(double);
						double A_31 = default(double);
						global::jf.a(array41, array40, 40, ref A_30, ref A_31);
						A_0.d.b = (float)(A_30 / num142);
						if (flag7)
						{
							double num144 = 0.0;
							int num145 = num6 - 1;
							for (num8 = 0; num8 <= num145; num8++)
							{
								if (array13[num8] > num144)
								{
									num144 = array13[num8];
								}
							}
							double num146 = num144 * 0.1;
							int num147 = num6 - 1;
							int num148 = default(int);
							for (num8 = 0; num8 <= num147; num8++)
							{
								if (array13[num8] > num146)
								{
									num148 = num8;
									break;
								}
							}
							int num149 = num6 - 1;
							double[] array42 = new double[num149 + 1];
							double[] array43 = new double[num149 + 1];
							double num150 = 1.0 / (double)num6;
							int num151 = num149;
							for (num8 = 0; num8 <= num151; num8++)
							{
								int num152 = num8 - 1;
								for (int num153 = 0; num153 <= num152; num153++)
								{
									array43[num8] += array13[num153] * (1.0 - num150 * (double)(num8 - num153));
								}
								int num154 = num8 + 1;
								int num155 = num149;
								for (int num156 = num154; num156 <= num155; num156++)
								{
									array42[num8] += array13[num156] * (1.0 - num150 * (double)(num156 - num8));
								}
							}
							int num157 = global::jf.a(ref A_7, num6, A_7[num148] - 50.0);
							double[] array44 = new double[num149 + 1];
							double[] array45 = new double[num149 + 1];
							double[] array46 = new double[num149 + 1];
							int num158 = num149;
							for (num8 = 0; num8 <= num158; num8++)
							{
								array44[num8] = num8;
							}
							double A_32 = default(double);
							double A_33 = default(double);
							global::jf.a(array44, array13, num157 + 1, ref A_32, ref A_33);
							ip.f f10 = A_0.d;
							A_0.d.f = (float)(A_33 / ((array42[num157] - array42[0]) / (double)(num157 + 1)));
							f10.g = (float)(A_32 / array42[0]);
							f10.h = num6;
							int num159 = num149;
							for (num8 = 0; num8 <= num159; num8++)
							{
								array45[num8] = array13[num8] - array42[0] * (double)f10.g - (array42[num8] - array42[0]) * (double)f10.f;
							}
							double[] array47 = new double[num149 + 1];
							double num160 = 0.01;
							int num161 = num149;
							for (num8 = 0; num8 <= num161; num8++)
							{
								int num162 = num8 + 100;
								if (num162 > num149)
								{
									num162 = num149;
								}
								int num163 = num8 + 1;
								int num164 = num162;
								for (int num165 = num163; num165 <= num164; num165++)
								{
									array47[num8] += array45[num165] * (1.0 - num160 * (double)(num165 - num8));
								}
							}
							int num166 = global::jf.a(ref A_7, num6, A_7[num148] - 10.0);
							double num167 = 0.0005;
							double num168 = 0.0001;
							bool flag11 = false;
							bool flag12 = false;
							Stopwatch stopwatch = new Stopwatch();
							bool flag13 = false;
							stopwatch.Start();
							bool flag14 = default(bool);
							do
							{
								int num169 = num149;
								for (num8 = 0; num8 <= num169; num8++)
								{
									array46[num8] = array45[num8] - array47[num8] * num167;
								}
								double num170 = 0.0;
								int num171 = num166;
								for (num8 = num157; num8 <= num171; num8++)
								{
									num170 += array46[num8];
								}
								if (num168 > 1E-05)
								{
									if (num170 > 0.0)
									{
										if (!flag14 && flag12)
										{
											num168 *= 0.5;
										}
										num167 += num168;
										flag14 = true;
									}
									else
									{
										if (flag14 && flag12)
										{
											num168 *= 0.5;
										}
										num167 -= num168;
										flag14 = false;
									}
								}
								else
								{
									flag11 = true;
								}
								flag12 = true;
								if (!flag11 && stopwatch.ElapsedMilliseconds > 10000)
								{
									flag13 = true;
									flag11 = true;
								}
							}
							while (!flag11);
							stopwatch.Stop();
							if (flag13)
							{
								A_5.a = global::r.d.a.a.b;
								A_5.b = "Timed out while attempting to compute shortNarrowScatterCoeff. Procedure aborted.";
								return;
							}
							f10.j = 100;
							f10.i = (float)num167;
							f10 = null;
							hr obj4 = new hr(null);
							string text4 = global::@is.b() + ip2.ur();
							obj4.t(A_7);
							obj4.af(array45);
							string A_34 = text4 + "_SpecNoBroadScatter.csv";
							obj4.k(ref A_34, "Wavelength (nm)", "Raw BroadScatter Subtracted");
							hr obj5 = new hr(null);
							obj5.t(A_7);
							obj5.af(array13);
							A_34 = text4 + "_SpecWithScatter.csv";
							obj5.k(ref A_34, "Wavelength (nm)", "Raw Data");
							hr obj6 = new hr(null);
							obj6.t(A_7);
							obj6.af(array46);
							A_34 = text4 + "_SpecNoNarrowScatter.csv";
							obj6.k(ref A_34, "Wavelength (nm)", "Raw All Scatter Subtracted");
						}
					}
					if (!flag10)
					{
						int num35 = global::jf.a(ref A_7, num6, ip2.vv() - 100f);
						int num36 = num6 - 1;
						int num172 = num6 - 1;
						for (int num8 = 0; num8 <= num172; num8++)
						{
							array13[num8] = array3[num8] - array6[num8];
						}
						ip2.m2(array13, num6, a_6);
						double num142 = 0.0;
						int num173 = num6 - 1;
						for (int num8 = 0; num8 <= num173; num8++)
						{
							num142 += array13[num8];
						}
						double[] array48 = new double[num36 - num35 + 1];
						double[] array49 = new double[num36 - num35 + 1];
						int num174 = num35;
						int num175 = num36;
						for (int num8 = num174; num8 <= num175; num8++)
						{
							array49[num8 - num35] = num8;
							array48[num8 - num35] = array13[num8];
						}
						double A_35 = default(double);
						double A_36 = default(double);
						global::jf.a(array49, array48, num36 - num35 + 1, ref A_35, ref A_36);
						A_0.d.c = (float)((A_35 + (double)num36 * A_36) / num142);
						int num176 = num6 - 1;
						for (int num8 = 0; num8 <= num176; num8++)
						{
							array13[num8] = array2[num8] - array5[num8];
						}
						ip2.m2(array13, num6, a_6);
						num142 = 0.0;
						int num177 = num6 - 1;
						for (int num8 = 0; num8 <= num177; num8++)
						{
							num142 += array13[num8];
						}
						double num178 = num142 * (double)A_0.d.c;
						int num179 = num6 - 1;
						for (int num8 = 0; num8 <= num179; num8++)
						{
							array13[num8] -= num178;
						}
						float[] A_37 = null;
						bool A_39 = default(bool);
						if (ip2.vu() > 300f)
						{
							double[] A_38 = new double[3];
							_ = new float[3];
							ip2.m2(array13, ref A_38, ref A_37, ref A_39);
							A_0.d.k[0] = 0f;
							A_0.d.k[1] = 0f;
							A_0.d.k[2] = 0f;
							A_0.d.k[3] = 0f;
							A_0.d.k[4] = 0f;
							A_0.d.k[5] = 0f;
						}
						else
						{
							A_39 = true;
						}
						if (!A_39)
						{
							int num180 = A_37.Length - 1;
							float num182 = default(float);
							for (int num181 = 0; num181 <= num180; num181++)
							{
								num182 += A_37[num181];
							}
							float num183 = num182 / (float)A_37.Length;
							A_0.d.l = A_37;
							A_0.d.m = (short)A_37.Length;
							A_0.d.n = num183;
						}
						else
						{
							A_0.d.l = null;
							A_0.d.m = 0;
							A_0.d.n = 0f;
						}
					}
				}
				else
				{
					Interaction.MsgBox("Reconnect Fiber, place Si reference sample on the stage and click OK");
					c10 = new c1();
					c10.d("Acquiring spectrum from Si wafer...");
					bool A_9 = false;
					bool A_10 = false;
					if (m2(ip2, ref A_9, ref A_10, ref A_6, 1, num5, (short)num, ref A_4.h, A_4.d3()) != ErrPublic.None)
					{
						A_5.a = global::r.d.a.a.b;
						A_5.b = "Error attempting to collect spectrum from Si wafer. Procedure aborted.";
						return;
					}
					double[] array50 = A_6.c0();
					c10.i();
					c10 = null;
					float a_13 = ip2.wm();
					array13 = new double[num6 - 1 + 1];
					int num184 = num6 - 1;
					int num8;
					for (num8 = 0; num8 <= num184; num8++)
					{
						array13[num8] = array50[num8] - array4[num8];
					}
					ip2.m2(array13, num6, a_13);
					double num185 = 0.0;
					int num186 = num6 - 1;
					for (num8 = 0; num8 <= num186; num8++)
					{
						num185 += array13[num8];
					}
					double num187 = num185;
					num185 = 0.0;
					num8 = 0;
					do
					{
						num185 += array13[num8];
						num8++;
					}
					while (num8 <= 39);
					float num188 = (float)(num185 / 40.0 / num187);
					A_0.d.b = num188;
					A_0.d.c = num188;
					A_0.d.k[0] = 0f;
					A_0.d.k[1] = 0f;
					A_0.d.k[2] = 0f;
					A_0.d.k[3] = 0f;
					A_0.d.k[4] = 0f;
					A_0.d.k[5] = 0f;
				}
				A_5.a = global::r.d.a.a.a;
			}
			finally
			{
				c10?.i();
			}
		}
	}

	private float m2(ip A_0, m A_1, global::r.d.a A_2, ref bool A_3)
	{
		hr A_4 = new hr(null);
		bool A_5 = false;
		checked
		{
			if (m2(A_0, ref A_5, ref A_3, ref A_4, 1, A_0.u9(), 1, ref A_1.h, A_1.d3()) == ErrPublic.None)
			{
				double[] array = A_4.c0();
				A_2.a = global::r.d.a.a.a;
				double num = 0.0;
				int num2 = A_4.c2() - 1;
				int num4 = default(int);
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (array[num3] > num)
					{
						num = array[num3];
						num4 = num3;
					}
				}
				int num5 = num4 - 20;
				if (num5 < 0)
				{
					num5 = 0;
				}
				int num6 = num5 + 40;
				if (num6 > A_4.c2() - 1)
				{
					num6 = A_4.c2() - 1;
					num5 = num6 - 40;
				}
				num = 0.0;
				int num7 = num5;
				int num8 = num6;
				for (int num3 = num7; num3 <= num8; num3++)
				{
					num += array[num3];
				}
				return (float)(num / 41.0);
			}
			A_2.a = global::r.d.a.a.b;
			A_2.b = "Error attempting to measure maximum intensity. Procedure aborted.";
			return 0f;
		}
	}

	private void m2(ip A_0, m A_1, global::r.d.a A_2, float A_3, float A_4, ref double A_5, ref bool A_6)
	{
		c0 c10 = new c0();
		c10.a(A_0: true, "Continue");
		double num = 0.0;
		int num2 = 0;
		checked
		{
			DateTime now = default(DateTime);
			while (!c10.g())
			{
				A_5 = m2(A_0, A_1, A_2, ref A_6);
				num += A_5;
				num2++;
				if (DateTime.Now.Subtract(now).TotalSeconds > 0.20000000298023224)
				{
					A_5 = num / (double)num2;
					num = 0.0;
					num2 = 0;
					now = DateTime.Now;
					string a_ = "Make adjustments so that peak intensity is >" + (int)Math.Round(A_3 + 1f) + " and <" + (int)Math.Round(A_4 + 1f) + ". Target = " + (int)Math.Round((A_3 + A_4) / 2f) + ", Actual = " + (int)Math.Round(A_5 + 0.5);
					if (c10.h())
					{
						c10.a(a_);
					}
					else
					{
						c10.b(a_);
					}
				}
				Application.DoEvents();
			}
			c10.i();
			c10.a(A_0: false);
		}
	}

	private void m2(ip.m A_0, m A_1, ref global::r.d.a A_2)
	{
		c1 c10 = null;
		checked
		{
			try
			{
				double[] array = new double[501];
				double[] array2 = new double[501];
				double[] array3 = new double[501];
				double[] array4 = new double[501];
				double[] array5 = new double[501];
				double[] array6 = new double[501];
				double[] array7 = new double[501];
				double[] array8 = new double[501];
				double[] array9 = new double[501];
				double[] array10 = new double[501];
				string text = string.Empty;
				string text2 = "Si wafer";
				short a_ = 5;
				ip ip2 = p9(A_0.c, ((ip.h)A_0).a, A_0.b);
				FMUSBDeviceType fMUSBDeviceType = ip2.xs();
				if (fMUSBDeviceType == FMUSBDeviceType.FIUSB2DeviceSpecUvVis || fMUSBDeviceType == FMUSBDeviceType.FIUSB2DeviceSpecLC || fMUSBDeviceType == FMUSBDeviceType.FIUSB2DeviceSpecUvVis2)
				{
					text2 = "BK7 Reference";
					a_ = 20;
				}
				double a_2;
				switch (fMUSBDeviceType)
				{
				case FMUSBDeviceType.FIUSB2DeviceSpecUvVis:
				case FMUSBDeviceType.FIUSB2DeviceSpecUvVis2:
					a_2 = 1.5;
					break;
				case FMUSBDeviceType.FIUSB2DeviceSpecLC:
					a_2 = 3.0;
					break;
				case FMUSBDeviceType.FIUSB2DeviceSpecNIR2:
					a_2 = 1.5;
					break;
				case FMUSBDeviceType.FIUSB2DeviceSpecTCNIR:
					a_2 = 1.5;
					break;
				default:
					a_2 = 10.0;
					break;
				}
				double num = fMUSBDeviceType switch
				{
					FMUSBDeviceType.FIUSB2DeviceSpecNIR2 => 1.5, 
					FMUSBDeviceType.FIUSB2DeviceSpecTCNIR => 0.5, 
					_ => ip2.vm(), 
				};
				float num2;
				if (ip2.xu())
				{
					num2 = 0f;
				}
				else
				{
					num2 = 200f;
					text = "Dark level must be 200+-30 counts. ";
				}
				if (Interaction.MsgBox("Light source must be on and warmed up for at least 15 min. " + text + "Place " + text2 + " on stage using a Reflection Probe.", MsgBoxStyle.OkCancel) == MsgBoxResult.Cancel)
				{
					A_2.b = "Calibration aborted";
					A_2.a = global::r.d.a.a.b;
					return;
				}
				float num3 = 250f;
				float num4 = 350f;
				ip2.so(num);
				double A_3 = default(double);
				bool A_4 = default(bool);
				m2(ip2, A_1, A_2, num3, num4, ref A_3, ref A_4);
				if (A_2.a != global::r.d.a.a.a)
				{
					return;
				}
				if (ip2.xs() == FMUSBDeviceType.FIUSB2DeviceSpecNIR2 && A_3 < (double)num3)
				{
					int num5 = 0;
					do
					{
						if (A_3 > 0.0)
						{
							num = num * 300.0 / A_3;
							ip2.so(num);
							A_3 = m2(ip2, A_1, A_2, ref A_4);
							if (A_2.a != global::r.d.a.a.a)
							{
								return;
							}
						}
						num5++;
					}
					while ((A_3 < (double)num3) | ((A_3 > (double)num4) & (num5 < 2)));
				}
				if ((A_3 < (double)num3) | (A_3 > (double)num4))
				{
					Interaction.MsgBox("Peak intensity outside limits. Calibration aborted.");
					A_2.b = "Calibration aborted";
					A_2.a = global::r.d.a.a.b;
					return;
				}
				c10 = new c1();
				c10.a(A_0: true);
				c10.a(500, "Measuring signal level--please wait...");
				hr A_5 = new hr(null);
				bool A_6 = false;
				bool A_7 = false;
				if (m2(ip2, ref A_6, ref A_7, ref A_5, 1, a_2, a_, ref A_1.h, A_1.d3()) == ErrPublic.None)
				{
					double[] array11 = A_5.c0();
					float num6 = ip2.wm();
					int num7 = A_5.c2();
					double num8 = 0.0;
					int num9 = num7 - 1;
					int num10 = default(int);
					for (int num5 = 0; num5 <= num9; num5++)
					{
						if (array11[num5] > num8)
						{
							num8 = array11[num5];
							num10 = num5;
						}
					}
					double num11 = ip2.u9() * 3500.0 / (num8 - (double)num2);
					if (num11 > 300.0)
					{
						num11 = 100.0;
					}
					if (c10.DialogResult == DialogResult.Cancel)
					{
						A_2.a = global::r.d.a.a.b;
						A_2.b = "Procedure aborted.";
						return;
					}
					A_7 = false;
					A_6 = false;
					if (m2(ip2, ref A_7, ref A_6, ref A_5, 1, num11, a_, ref A_1.h, A_1.d3()) == ErrPublic.None)
					{
						array11 = A_5.c0();
						num8 = 0.0;
						int num12 = num7 - 1;
						int num5;
						for (num5 = 0; num5 <= num12; num5++)
						{
							if (array11[num5] > num8)
							{
								num8 = array11[num5];
								num10 = num5;
							}
						}
						num11 = num11 * 3500.0 / (num8 - 200.0);
						double num13 = num11 / (num8 / 50.0);
						double num14 = ((!(num < num13)) ? num : num13);
						int num15 = (int)Math.Round(num14 / num13);
						num5 = num15;
						do
						{
							if (c10.DialogResult == DialogResult.Cancel)
							{
								A_2.a = global::r.d.a.a.b;
								A_2.b = "Procedure aborted.";
								return;
							}
							double num16 = (double)num5 * num13;
							A_6 = false;
							if (m2(ip2, ref A_6, ref A_4, ref A_5, 1, num16, a_, ref A_1.h, A_1.d3()) != ErrPublic.None)
							{
								A_2.a = global::r.d.a.a.b;
								A_2.b = "Error attempting to collect spectrum for max Int time. Procedure aborted.";
								return;
							}
							Application.DoEvents();
							array7[num5] = A_5.c0()[num10];
							array6[num5] = ip2.sn(num16);
							num5++;
							c10.a("Determining saturation level:\r\nSignal level=" + array7[num5 - 1].ToString("####.0") + ", Tint=" + num16.ToString("###.0") + ", Step #=" + num5);
							c10.b(num5);
						}
						while (!A_4);
						int num17 = num5 - 1;
						int num18 = 500 - num17;
						int num19 = (num17 - num15 - 1) * 2;
						double num20 = (double)num18 / (double)num19;
						string text3 = "Measuring signal level--please wait...";
						int num21 = num17 - 1;
						for (num5 = num15; num5 <= num21; num5++)
						{
							if (c10.DialogResult == DialogResult.Cancel)
							{
								A_2.a = global::r.d.a.a.b;
								A_2.b = "Procedure aborted.";
								return;
							}
							c10.a(text3 + "(" + (num5 - num15).ToString().Trim() + ")");
							c10.b((int)Math.Round((double)num17 + (double)(num5 - num15) * num20));
							double num16 = array6[num5];
							A_6 = false;
							if (m2(ip2, ref A_6, ref A_4, ref A_5, 1, num16, a_, ref A_1.h, A_1.d3()) != ErrPublic.None)
							{
								A_2.a = global::r.d.a.a.b;
								A_2.b = "Error attempting to collect spectrum for single ascending data point. Procedure aborted.";
								return;
							}
							Application.DoEvents();
							array7[num5] = A_5.c0()[num10];
							num16 = array6[num17 - 1];
							A_6 = false;
							if (m2(ip2, ref A_6, ref A_4, ref A_5, 1, num16, a_, ref A_1.h, A_1.d3()) != ErrPublic.None)
							{
								A_2.a = global::r.d.a.a.b;
								A_2.b = "Error attempting to collect spectrum for single ascending ref data point. Procedure aborted.";
								return;
							}
							Application.DoEvents();
							array8[num5] = A_5.c0()[num10];
						}
						int num22 = num17 - 1;
						int num23 = num15;
						for (num5 = num22; num5 >= num23; num5 += -1)
						{
							if (c10.DialogResult == DialogResult.Cancel)
							{
								A_2.a = global::r.d.a.a.b;
								A_2.b = "Procedure aborted.";
								return;
							}
							c10.a(text3 + "(" + (num5 - num15).ToString().Trim() + ")");
							c10.b((int)Math.Round((double)num17 + (double)(num19 - num5 + num15) * num20));
							double num16 = array6[num5];
							A_6 = false;
							if (m2(ip2, ref A_6, ref A_4, ref A_5, 1, num16, a_, ref A_1.h, A_1.d3()) != ErrPublic.None)
							{
								A_2.a = global::r.d.a.a.b;
								A_2.b = "Error attempting to collect spectrum for single descending data point. Procedure aborted.";
								return;
							}
							Application.DoEvents();
							array9[num5] = A_5.c0()[num10];
							num16 = array6[num17 - 1];
							A_6 = false;
							if (m2(ip2, ref A_6, ref A_4, ref A_5, 1, num16, a_, ref A_1.h, A_1.d3()) != ErrPublic.None)
							{
								A_2.a = global::r.d.a.a.b;
								A_2.b = "Error attempting to collect spectrum for single descending ref data point. Procedure aborted.";
								return;
							}
							Application.DoEvents();
							array10[num5] = A_5.c0()[num10];
						}
						c10.i();
						c10 = null;
						if (Interaction.MsgBox("Prepare for dark measurements--Disconnect fiber from spectrometer input and cover spectrometer input with BLACK cover.", MsgBoxStyle.OkCancel) == MsgBoxResult.Cancel)
						{
							A_2.b = "Calibration aborted";
							A_2.a = global::r.d.a.a.b;
							return;
						}
						text3 = "Measuring dark level--please wait...";
						c10 = new c1();
						c10.a(A_0: true);
						c10.a(num19, text3);
						int num24 = num17 - 1;
						for (num5 = num15; num5 <= num24; num5++)
						{
							if (c10.DialogResult == DialogResult.Cancel)
							{
								A_2.a = global::r.d.a.a.b;
								A_2.b = "Procedure aborted.";
								return;
							}
							c10.a(text3 + "(" + (num5 - num15).ToString().Trim() + ")");
							c10.b(num5 - num15);
							double num16 = array6[num5];
							A_6 = false;
							if (m2(ip2, ref A_6, ref A_4, ref A_5, 1, num16, a_, ref A_1.h, A_1.d3()) != ErrPublic.None)
							{
								A_2.a = global::r.d.a.a.b;
								A_2.b = "Error attempting to collect spectrum for single ascending dark data point. Procedure aborted.";
								return;
							}
							Application.DoEvents();
							array[num5] = A_5.c0()[num10];
						}
						int num25 = num17 - 1;
						int num26 = num15;
						for (num5 = num25; num5 >= num26; num5 += -1)
						{
							if (c10.DialogResult == DialogResult.Cancel)
							{
								A_2.a = global::r.d.a.a.b;
								A_2.b = "Procedure aborted.";
								return;
							}
							c10.a(text3 + "(" + (num5 - num15).ToString().Trim() + ")");
							c10.b(num19 - num5 + num15);
							double num16 = array6[num5];
							A_6 = false;
							if (m2(ip2, ref A_6, ref A_4, ref A_5, 1, num16, a_, ref A_1.h, A_1.d3()) != ErrPublic.None)
							{
								A_2.a = global::r.d.a.a.b;
								A_2.b = "Error attempting to collect spectrum for single ascending dark data point. Procedure aborted.";
								return;
							}
							Application.DoEvents();
							array2[num5] = A_5.c0()[num10];
						}
						float num27 = ip2.wm();
						if (array[0] > 300.0)
						{
							Interaction.MsgBox("Error-dark reading is implausibly high. Please check dark level and try again.");
							A_2.a = global::r.d.a.a.b;
							A_2.b = "Procedure failed";
							return;
						}
						if (!(Math.Abs(num27 - num6) > 0.51f))
						{
							int num28 = num17 - 1;
							for (num5 = num15; num5 <= num28; num5++)
							{
								array7[num5] -= array[num5];
								array9[num5] -= array2[num5];
							}
							short num29 = (short)Math.Round((array6[num17 - 1] / (array7[num17 - 1] / 600.0) - array6[0]) / num13);
							if (num29 < 0)
							{
								num29 = 0;
							}
							double[] array12 = new double[num17 - 1 + 1];
							double[] array13 = new double[num17 - 1 + 1];
							double[] array14 = new double[num17 - 1 + 1];
							int num30 = num17 - 1;
							for (num5 = num15; num5 <= num30; num5++)
							{
								array12[num5] = array7[num5] * array8[num15] / array8[num5];
								array13[num5] = array9[num5] * array8[num15] / array10[num5];
								array14[num5] = (array12[num5] + array13[num5]) / 2.0;
							}
							int num31 = num17 - 1;
							for (num5 = num15; num5 <= num31; num5++)
							{
								array3[num5] = array7[num5] / (array7[num29] * array6[num5] / array6[num29]) - 1.0;
								array4[num5] = array9[num5] / (array7[num29] * array6[num5] / array6[num29]) - 1.0;
								array5[num5] = (array3[num5] + array4[num5]) / 2.0;
							}
							double[] array15 = new double[5];
							float[] array16 = new float[5];
							double num32 = 0.0;
							int num33 = 0;
							num5 = num15;
							do
							{
								num32 += array5[num5];
								num33++;
								num5++;
							}
							while (array14[num5] < 450.0);
							double num34 = num32 / (double)num33;
							int num35 = num15 - 1;
							for (num5 = 0; num5 <= num35; num5++)
							{
								array6[num5] = (double)num5 * num13;
								array5[num5] = num34;
								array14[num5] = (num34 + 1.0) * array7[num29] * array6[num5] / array6[num29];
							}
							global::jf.a(array14, array5, num17, (short)4, array15);
							array15[0]++;
							double num36 = array15[0] + (array15[1] + (array15[2] + (array15[3] + array15[4] * 4095.0) * 4095.0) * 4095.0) * 4095.0;
							num5 = 0;
							do
							{
								array16[num5] = (float)(array15[num5] / num36);
								num5++;
							}
							while (num5 <= 4);
							A_0.y.b = array16;
							A_0.y.c = (num6 + num27) / 2f;
							string text4 = global::@is.b() + ip2.ur();
							StreamWriter streamWriter = null;
							try
							{
								streamWriter = new StreamWriter(text4 + "_Linearity.csv", append: false, Encoding.ASCII);
								streamWriter.WriteLine("Int. Time, Max Reading, Ref Reading, Max Reading ND, Fraction, Dark reading, Linearity corrected Data, Max Reading rev, Ref Reading rev, Max Reading rev ND, Fraction Rev, Dark reading Rev, MaxReadingMeanND, Fraction Mean, Lin. Error");
								float num37 = (float)array14[num17 - 1];
								float num38 = (float)((double)num37 / (array15[0] + (array15[1] + (array15[2] + (array15[3] + array15[4] * (double)num37) * (double)num37) * (double)num37) * (double)num37));
								int num39 = num17 - 1;
								for (num5 = 0; num5 <= num39; num5++)
								{
									num37 = (float)array14[num5];
									float num40 = (float)((double)num37 / (array15[0] + (array15[1] + (array15[2] + (array15[3] + array15[4] * (double)num37) * (double)num37) * (double)num37) * (double)num37));
									float num41 = ((num5 != 0) ? ((float)((double)(num40 / num38) * array6[num17 - 1] / array6[num5] - 1.0)) : 0f);
									streamWriter.WriteLine(Conversions.ToString(array6[num5]) + ", " + Conversions.ToString(array7[num5]) + ", " + Conversions.ToString(array8[num5]) + ", " + Conversions.ToString(array12[num5]) + ", " + Conversions.ToString(array3[num5]) + ", " + Conversions.ToString(array[num5]) + ", " + Conversions.ToString(num40) + ", " + Conversions.ToString(array9[num5]) + ", " + Conversions.ToString(array10[num5]) + ", " + Conversions.ToString(array13[num5]) + ", " + Conversions.ToString(array4[num5]) + ", " + Conversions.ToString(array2[num5]) + ", " + Conversions.ToString(array14[num5]) + ", " + Conversions.ToString(array5[num5]) + ", " + Conversions.ToString(num41));
								}
							}
							finally
							{
								streamWriter?.Close();
							}
							try
							{
								streamWriter = new StreamWriter(text4 + "LinearityPolyFitCoeffs.csv", append: false, Encoding.ASCII);
								streamWriter.WriteLine("Poly fit Coeff Idx, Poly fit Coeff");
								num5 = 0;
								do
								{
									streamWriter.WriteLine(num5 + ", " + Conversions.ToString(array15[num5]));
									num5++;
								}
								while (num5 <= 4);
								streamWriter.WriteLine("Board Temperature at Start,  Board Temperature at End");
								streamWriter.WriteLine(num6 + ", " + num27 + ", ");
								return;
							}
							finally
							{
								streamWriter?.Close();
							}
						}
						Interaction.MsgBox("Error - Temperature changed by " + Conversion.Str(Math.Abs(num27 - num6)) + " ºC during calibration.\r\nMaximum allowable change is " + Conversion.Str(0.51f) + ". Calibration process has been aborted. Please repeat the linearity calibration.");
						A_2.a = global::r.d.a.a.b;
						A_2.b = "Procedure failed";
					}
					else
					{
						A_2.a = global::r.d.a.a.b;
						A_2.b = "Error attempting to collect initial spectrum 2. Procedure aborted.";
					}
				}
				else
				{
					A_2.a = global::r.d.a.a.b;
					A_2.b = "Error attempting to collect initial spectrum. Procedure aborted.";
				}
			}
			finally
			{
				c10?.i();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void m2(m A_0)
	{
		short[,] array = new short[4, 3];
		float[,,] array2 = new float[4, 3, 500];
		float[,,] array3 = new float[4, 3, 500];
		float[,] array4 = null;
		float[] array5 = null;
		double[] array6 = null;
		float[] array7 = null;
		float[] array8 = null;
		float[] array9 = null;
		double[,] array10 = new double[4, 3];
		double[,] array11 = new double[4, 3];
		double[,] array12 = new double[4, 3];
		double[,] array13 = new double[4, 3];
		double[] array14 = new double[4];
		double[] array15 = new double[4];
		double[,] array16 = new double[4, 3];
		double[,] array17 = new double[4, 3];
		double[,] array18 = new double[4, 3];
		double[,] array19 = new double[4, 3];
		double[] array20 = new double[4];
		double[] array21 = new double[4];
		double[] array22 = new double[500];
		double[] array23 = new double[500];
		iq a_ = null;
		double[] array24 = new double[500];
		string defaultResponse = null;
		ip.h obj = (ip.h)A_0.j;
		int index = obj.b;
		int num = obj.a;
		_ = null;
		ip ip2 = iq[num][index];
		double[] A_1 = null;
		int num2 = ip2.vw();
		if (Interaction.MsgBox("Required configuration (setup described in a) or b) below must be completed before continuing):\r\n\r\na) SNR Measurement: SS-1 stage, RP-1 fiber, Si wafer on stage, Light source on, Smoothing pts set as desired, Tint set for 3000-3500 cts\r\n        Output files (App.path +): Noise-SNR- (mean signal/rms noise), Noise-PtoP- (peak-peak noise), Noise-rms- (rms noise), Noise-mean- (average of all spectra)\r\n\r\nb) Readout Noise Measurement: Tint set as desired, Spectrometer input covered with black cover\r\n        Output file: appended to App.path\\NoiseStats.txt\r\n\r\n                                                                                                           Click OK to continue", MsgBoxStyle.OkCancel) != MsgBoxResult.Ok)
		{
			return;
		}
		checked
		{
			double[] A_2 = new double[num2 - 1 + 1024 + 1];
			bool A_3 = false;
			bool A_4 = false;
			ip2.m2(ref A_3, ref A_4, xo(), 1, 1.2, 1, A_0.h, A_0.d3());
			ip2.m2(ref A_2, ref A_1);
			int num3 = num2 - 1;
			float num4 = 0f;
			int num5 = num3;
			int num7 = default(int);
			for (int num6 = 0; num6 <= num5; num6++)
			{
				if (A_2[num6] > (double)num4)
				{
					num4 = (float)A_2[num6];
					num7 = num6;
				}
			}
			bool flag;
			double num8;
			int num10;
			short num12 = default(short);
			if (num4 > 400f)
			{
				flag = true;
				defaultResponse = Interaction.InputBox("Enter Desired sampling time in ms", "Sampling Time", defaultResponse);
				if (Operators.CompareString(defaultResponse, "", TextCompare: false) == 0)
				{
					return;
				}
				mt = Interaction.InputBox("Enter string to append to output files (e.g. 'Test 11-26-07, F20'", "File append string", mt);
				if (Operators.CompareString(mt, "", TextCompare: false) == 0)
				{
					return;
				}
				mt = global::i3.g(mt);
				num8 = ip2.qh(a_, zp() == g2.a.b);
				int num9 = unchecked((int)ip2.so(num8));
				if (num9 != 0)
				{
					ab8().c(fz.b.b, "Error attempting to set integration time in MeasureNoise location 1. ErrCode=" + num9);
				}
				array4 = new float[num3 + 1, 500];
				array5 = new float[num3 + 1];
				array6 = new double[num3 + 1];
				array7 = new float[num3 + 1];
				array8 = new float[num3 + 1];
				array9 = new float[num3 + 1];
				if (Interaction.MsgBox("Please disconnect fiber from spectrometer; cover spectrometer input with black cover. Click OK to measure dark signal", MsgBoxStyle.OkCancel) == MsgBoxResult.Cancel)
				{
					return;
				}
				short a_2 = (short)Math.Round(2000.0 / num8);
				num10 = (int)Math.Round(global::iz.e(defaultResponse) / num8);
				if (num10 < 1)
				{
					num10 = 1;
				}
				A_4 = false;
				A_3 = false;
				ip2.m2(ref A_4, ref A_3, xo(), 1, num8, a_2, A_0.h, A_0.d3());
				double[] A_5 = null;
				ip2.m2(ref A_2, ref A_5);
				int num11 = num3;
				for (int num6 = 0; num6 <= num11; num6++)
				{
					array5[num6] = (float)A_2[num6];
				}
				if (Interaction.MsgBox("Please reconnect fiber. Click OK to measure signal-to-noise ratio", MsgBoxStyle.OkCancel) == MsgBoxResult.Cancel)
				{
					return;
				}
			}
			else
			{
				flag = false;
				num12 = 1;
				num10 = 1;
				num8 = ip2.qh(a_, zp() == g2.a.b);
				int num9 = unchecked((int)ip2.so(num8));
				if (num9 != 0)
				{
					ab8().c(fz.b.b, "Error attempting to set integration time in MeasureNoise location 2. ErrCode=" + num9);
				}
				mt = Interaction.InputBox("Enter Description of current configuration", "Configuration Description", mt);
				if (Operators.CompareString(mt, "", TextCompare: false) == 0)
				{
					return;
				}
			}
			if (!flag)
			{
				array[0, 0] = 3;
				array[0, 1] = 5;
				array[0, 2] = 7;
				array[1, 0] = 2;
				array[1, 1] = 4;
				array[1, 2] = 6;
				array[2, 0] = 251;
				array[2, 1] = 253;
				array[2, 2] = 255;
				array[3, 0] = 250;
				array[3, 1] = 252;
				array[3, 2] = 254;
			}
			short num13 = 0;
			short num18;
			do
			{
				A_3 = false;
				A_4 = false;
				ip2.m2(ref A_3, ref A_4, xo(), 1, num8, 1, A_0.h, A_0.d3());
				ip2.m2(ref A_2, ref A_1);
				if (flag)
				{
					int num14 = num3;
					for (int num6 = 0; num6 <= num14; num6++)
					{
						array4[num6, num13] = (float)A_2[num6];
					}
				}
				else
				{
					double num15 = 0.0;
					int num16 = num2 - 1;
					for (int num17 = 0; num17 <= num16; num17++)
					{
						num15 += A_2[num17];
					}
					array24[num13] = num15 / (double)num2;
					num18 = 0;
					do
					{
						short num19 = 0;
						do
						{
							array2[num18, num19, num13] = (float)A_2[array[num18, num19]];
							num19 = (short)unchecked(num19 + 1);
						}
						while (num19 <= 2);
						num18 = (short)unchecked(num18 + 1);
					}
					while (num18 <= 3);
					array22[num13] = num13;
				}
				num13 = (short)unchecked(num13 + 1);
			}
			while (num13 <= 499);
			double num35;
			int num37;
			string fileName;
			if (flag)
			{
				int num20 = num7 - 10;
				if (num20 < 0)
				{
					num20 = 0;
				}
				int num21 = num20 + 20;
				if (num21 > num3)
				{
					num21 = num3;
					num20 = num21 - 20;
				}
				double num22 = 0.0;
				int num23 = num20;
				int num24 = num21;
				for (int num6 = num23; num6 <= num24; num6++)
				{
					num22 = num22 + (double)array4[num6, 0] - (double)array5[num13];
				}
				num22 /= 21.0;
				num13 = 0;
				do
				{
					double num25 = 0.0;
					int num26 = num20;
					int num27 = num21;
					for (int num6 = num26; num6 <= num27; num6++)
					{
						num25 = num25 + (double)array4[num6, num13] - (double)array5[num13];
					}
					num25 /= 21.0;
					float num28 = (float)(num22 / num25);
					int num29 = num3;
					for (int num6 = 0; num6 <= num29; num6++)
					{
						array4[num6, num13] = (array4[num6, num13] - array5[num13]) * num28;
					}
					num13 = (short)unchecked(num13 + 1);
				}
				while (num13 <= 499);
				int num30 = num3;
				for (int num6 = 0; num6 <= num30; num6++)
				{
					array8[num6] = (array7[num6] = array4[num6, 0]);
				}
				num13 = 0;
				do
				{
					int num31 = num3;
					for (int num6 = 0; num6 <= num31; num6++)
					{
						float num32 = array4[num6, num13];
						array6[num6] += num32;
						if (num32 < array7[num6])
						{
							array7[num6] = num32;
						}
						if (num32 > array8[num6])
						{
							array8[num6] = num32;
						}
					}
					num13 = (short)unchecked(num13 + 1);
				}
				while (num13 <= 499);
				int num33 = num3;
				for (int num6 = 0; num6 <= num33; num6++)
				{
					array6[num6] /= 500.0;
				}
				int num34 = num3;
				for (int num6 = 0; num6 <= num34; num6++)
				{
					num35 = 0.0;
					num13 = 0;
					do
					{
						double num36 = (double)array4[num6, num13] - array6[num6];
						num35 += num36 * num36;
						num13 = (short)unchecked(num13 + 1);
					}
					while (num13 <= 499);
					array9[num6] = (float)Math.Sqrt(num35 / 499.0);
				}
				num37 = FileSystem.FreeFile();
				fileName = global::i3.o() + "\\Logs\\Noise-SNR-" + mt + ".csv";
				FileSystem.FileOpen(num37, fileName, OpenMode.Output);
				FileSystem.WriteLine(num37, "Wavelength (nm)", "Signal/Noise Ratio; Smooth=" + Conversion.Str(num12) + ", Tint=" + num8.ToString("0.00") + ", Actual Samp. Time=" + (num8 * (double)num10).ToString("0.00") + ", Peak inten=" + num22.ToString("0.00"));
				int num38 = num3;
				for (int num6 = 0; num6 <= num38; num6++)
				{
					FileSystem.WriteLine(num37, Math.Round(A_1[num6], 2), Math.Round(array6[num6] / (double)array9[num6], 2));
				}
				FileSystem.FileClose(num37);
				fileName = global::c.d().Info.DirectoryPath + "\\Noise-PtoP-" + mt + ".csv";
				FileSystem.FileOpen(num37, fileName, OpenMode.Output);
				FileSystem.WriteLine(num37, "Wavelength (nm)", "Max-Min; Smooth=" + Conversion.Str(num12) + ", Tint=" + num8.ToString("0.00") + ", Actual Samp. Time=" + (num8 * (double)num10).ToString("0.00") + ", Peak inten=" + num22.ToString("0.00"));
				int num39 = num3;
				for (int num6 = 0; num6 <= num39; num6++)
				{
					FileSystem.WriteLine(num37, Math.Round(A_1[num6], 2), Math.Round(array8[num6] - array7[num6], 3));
				}
				FileSystem.FileClose(num37);
				fileName = global::c.d().Info.DirectoryPath + "\\Noise-rms-" + mt + ".csv";
				FileSystem.FileOpen(num37, fileName, OpenMode.Output);
				FileSystem.WriteLine(num37, "Wavelength (nm)", "rms noise; Smooth=" + Conversion.Str(num12) + ", Tint=" + num8.ToString("0.00") + ", Actual Samp. Time=" + (num8 * (double)num10).ToString("0.00") + ", Peak inten=" + num22.ToString("0.00"));
				int num40 = num3;
				for (int num6 = 0; num6 <= num40; num6++)
				{
					FileSystem.WriteLine(num37, Math.Round(A_1[num6], 2), Math.Round(array9[num6], 4));
				}
				FileSystem.FileClose(num37);
				fileName = global::c.d().Info.DirectoryPath + "\\Noise-mean-" + mt + ".csv";
				FileSystem.FileOpen(num37, fileName, OpenMode.Output);
				FileSystem.WriteLine(num37, "Wavelength (nm)", "mean signal; Smooth=" + Conversion.Str(num12) + ", Tint=" + num8.ToString("0.00") + ", Actual Samp. Time=" + (num8 * (double)num10).ToString("0.00") + ", Peak inten=" + num22.ToString("0.00"));
				int num41 = num3;
				for (int num6 = 0; num6 <= num41; num6++)
				{
					FileSystem.WriteLine(num37, Math.Round(A_1[num6], 2), Math.Round(array6[num6], 2));
				}
				FileSystem.FileClose(num37);
				return;
			}
			num18 = 0;
			double A_6 = default(double);
			double A_7 = default(double);
			double num48 = default(double);
			double num44;
			do
			{
				short num19 = 0;
				do
				{
					num13 = 0;
					do
					{
						array23[num13] = array2[num18, num19, num13];
						num13 = (short)unchecked(num13 + 1);
					}
					while (num13 <= 499);
					global::jf.a(array22, array23, 500, ref A_6, ref A_7);
					double num42 = 1E+20;
					double num43 = 0.0;
					num44 = 0.0;
					num13 = 0;
					do
					{
						double num45 = (double)array2[num18, num19, num13] - (A_6 + A_7 * array22[num13]);
						array2[num18, num19, num13] = (float)num45;
						num44 += num45;
						if (num45 > num43)
						{
							num43 = num45;
						}
						if (num45 < num42)
						{
							num42 = num45;
						}
						num13 = (short)unchecked(num13 + 1);
					}
					while (num13 <= 499);
					array11[num18, num19] = num42;
					array12[num18, num19] = num43;
					array10[num18, num19] = num44 / 500.0;
					num35 = 0.0;
					num13 = 0;
					do
					{
						double num36 = (double)array2[num18, num19, num13] - array10[num18, num19];
						num35 += num36 * num36;
						num13 = (short)unchecked(num13 + 1);
					}
					while (num13 <= 499);
					array13[num18, num19] = Math.Sqrt(num35 / 499.0);
					num42 = 1E+20;
					num43 = 0.0;
					num44 = 0.0;
					num13 = 0;
					do
					{
						if ((short)unchecked(num13 + 20) - 1 < 500)
						{
							double num46 = 0.0;
							short num47 = 0;
							do
							{
								num46 += (double)array2[num18, num19, (short)unchecked(num13 + num47)];
								num47 = (short)unchecked(num47 + 1);
							}
							while (num47 <= 19);
							num48 = num46 / 20.0;
						}
						double num45 = (double)array2[num18, num19, num13] - num48;
						array3[num18, num19, num13] = (float)num45;
						num44 += num45;
						if (num45 > num43)
						{
							num43 = num45;
						}
						if (num45 < num42)
						{
							num42 = num45;
						}
						num13 = (short)unchecked(num13 + 1);
					}
					while (num13 <= 499);
					array17[num18, num19] = num42;
					array18[num18, num19] = num43;
					array16[num18, num19] = num44 / 500.0;
					num35 = 0.0;
					num13 = 0;
					do
					{
						double num36 = (double)array3[num18, num19, num13] - array16[num18, num19];
						num35 += num36 * num36;
						num13 = (short)unchecked(num13 + 1);
					}
					while (num13 <= 499);
					array19[num18, num19] = Math.Sqrt(num35 / 499.0);
					num19 = (short)unchecked(num19 + 1);
				}
				while (num19 <= 2);
				num18 = (short)unchecked(num18 + 1);
			}
			while (num18 <= 3);
			double num49 = array24[0];
			double num50 = 0.0;
			num44 = 0.0;
			num13 = 0;
			do
			{
				if (array24[num13] > num50)
				{
					num50 = array24[num13];
				}
				if (array24[num13] < num49)
				{
					num49 = array24[num13];
				}
				num44 += array24[num13];
				num13 = (short)unchecked(num13 + 1);
			}
			while (num13 <= 499);
			double num51 = num44 / 500.0;
			num35 = 0.0;
			num13 = 0;
			do
			{
				double num36 = array24[num13] - num51;
				num35 += num36 * num36;
				num13 = (short)unchecked(num13 + 1);
			}
			while (num13 <= 499);
			double num52 = Math.Sqrt(num35 / 499.0);
			num37 = FileSystem.FreeFile();
			fileName = global::i3.o() + "\\Logs\\NoiseStats.txt";
			FileSystem.FileOpen(num37, fileName, OpenMode.Append);
			FileSystem.WriteLine(num37);
			FileSystem.WriteLine(num37, mt);
			FileSystem.WriteLine(num37, "Integration Time:", ip2.qh(a_, zp() == g2.a.b), " ms");
			FileSystem.WriteLine(num37, "Number of measured spectra:", (short)500);
			FileSystem.WriteLine(num37, "Pixel #", "Std Dev.", "Max-Min", "Std Dev. RA", "Max-Min RA");
			num18 = 0;
			do
			{
				short num19 = 0;
				do
				{
					FileSystem.PrintLine(num37, array[num18, num19], array13[num18, num19].ToString("0.000"), (array12[num18, num19] - array11[num18, num19]).ToString("0.0"), array19[num18, num19].ToString("0.000"), (array18[num18, num19] - array17[num18, num19]).ToString("0.0"));
					num19 = (short)unchecked(num19 + 1);
				}
				while (num19 <= 2);
				num18 = (short)unchecked(num18 + 1);
			}
			while (num18 <= 3);
			FileSystem.WriteLine(num37, "Group Stats:");
			FileSystem.WriteLine(num37, "Group #", "Std Dev.", "Max-Min", "Std Dev. RA", "Max-Min RA");
			num18 = 0;
			do
			{
				double num53 = 0.0;
				array14[num18] = 0.0;
				double num54 = 0.0;
				array20[num18] = 0.0;
				short num19 = 0;
				do
				{
					num53 += array13[num18, num19];
					num54 += array19[num18, num19];
					if (array12[num18, num19] - array11[num18, num19] > array14[num18])
					{
						array14[num18] = array12[num18, num19] - array11[num18, num19];
					}
					if (array18[num18, num19] - array17[num18, num19] > array20[num18])
					{
						array20[num18] = array18[num18, num19] - array17[num18, num19];
					}
					num19 = (short)unchecked(num19 + 1);
				}
				while (num19 <= 2);
				array15[num18] = num53 / 3.0;
				array21[num18] = num54 / 3.0;
				FileSystem.PrintLine(num37, num18 + 1, array15[num18].ToString("0.000"), array14[num18].ToString("0.0"), array21[num18].ToString("0.000"), array20[num18].ToString("0.0"));
				num18 = (short)unchecked(num18 + 1);
			}
			while (num18 <= 3);
			FileSystem.WriteLine(num37, "Summary Stats:");
			FileSystem.WriteLine(num37, "Group ID", "Std Dev.", "Max-Min", "Std Dev. RA", "Max-Min RA");
			double num55 = ((!(array14[0] > array14[2])) ? array14[2] : array14[0]);
			double num56 = ((!(array20[0] > array20[2])) ? array20[2] : array20[0]);
			FileSystem.PrintLine(num37, "Odd", ((array15[0] + array15[2]) / 2.0).ToString("0.000"), num55.ToString("0.0"), ((array21[0] + array21[2]) / 2.0).ToString("0.000"), num56.ToString("0.0"));
			num55 = ((!(array14[1] > array14[3])) ? array14[3] : array14[1]);
			num56 = ((!(array20[1] > array20[3])) ? array20[3] : array20[1]);
			FileSystem.PrintLine(num37, "Even", ((array15[1] + array15[3]) / 2.0).ToString("0.000"), num55.ToString("0.0"), ((array21[1] + array21[3]) / 2.0).ToString("0.000"), num56.ToString("0.0"));
			FileSystem.WriteLine(num37, "DC Level Stats:");
			FileSystem.WriteLine(num37, "Std Dev.", "Max-Min");
			FileSystem.PrintLine(num37, num52.ToString("0.000"), (num50 - num49).ToString("0.0"));
			FileSystem.FileClose(num37);
			Interaction.MsgBox("Noise stats written to " + fileName);
			Interaction.Shell("Notepad.exe " + fileName, AppWinStyle.NormalFocus);
		}
	}

	private new bool p9(n A_0)
	{
		return A_0 switch
		{
			n.c => hc.d0().c() == g2.a.b, 
			n.g => true, 
			_ => false, 
		};
	}

	private new bool m2(n A_0)
	{
		if (A_0 != n.g && A_0 != n.h)
		{
			return hc.d0().c() != g2.a.b;
		}
		return false;
	}

	private void m2(string A_0, ip A_1, p A_2, bool A_3, ref double[] A_4, ref double A_5, ref double A_6)
	{
		double[] A_7 = null;
		A_6 = 1.0;
		A_5 = 0.0;
		Guid A_8 = default(Guid);
		int A_9 = default(int);
		A_1.m2(A_0: false, ref A_7, ref A_9, ref A_8);
		checked
		{
			int num = A_9 - 1;
			double[] a_ = new double[num + 1];
			A_4 = new double[num + 1];
			double[] A_10 = null;
			ex ex2 = new ex();
			if (ex2.e(A_0, ex.a.a, 0f, A_3: false, A_4: false))
			{
				if (!ex2.e(A_7, A_9, ref A_10))
				{
					ab8().c(fz.b.b, "Error in call to MapDataOntoWavelengths for " + A_0 + " in MaximumTheoreticalReflectionRatio.");
					return;
				}
			}
			else
			{
				ab8().c(fz.b.b, "Error attempting to read reference file for " + A_0 + " in MaximumTheoreticalReflectionRatio.");
			}
			if (hc.b5())
			{
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					A_4[num3] = 1.0;
				}
				A_5 = 1.0;
				A_6 = 1.0;
				return;
			}
			int num4 = hc.dz();
			for (int num5 = 1; num5 <= num4; num5++)
			{
				hc.b3(num5).fh();
				_ = 4;
				hr hr2 = new hr(A_7, Guid.NewGuid(), a_, hr.b.c, 0f, 1, FMLegacyAllSystemTypes.kTypeF20, ew.a.a, "Generated", DateTime.Now, "", "Simulation", hr.a.e, 0, 0f, 0f, null, null, "", A_19: false, A_20: false, A_21: false, 0, 0, null, 0, string.Empty, null);
				hc A_11 = new hc();
				string A_12 = null;
				ErrPublic errPublic = m2(hr2, null, num5, ref A_11, A_4: false, A_2.d3(), A_2.ai, ref A_12);
				if (errPublic == ErrPublic.None)
				{
					hr2.af(A_11.cs().c0());
					int num6 = num;
					for (int num7 = 0; num7 <= num6; num7++)
					{
						if (hr2.c0()[num7] > A_4[num7])
						{
							A_4[num7] = hr2.c0()[num7];
						}
						double num8 = hr2.c0()[num7] / A_10[num7];
						if (num8 > A_5)
						{
							A_5 = num8;
						}
					}
					continue;
				}
				string text = "Error analyzing theoretical spectrum for site " + num5 + ". Error is " + errPublic;
				ab8().c(fz.b.b, text);
				throw new ApplicationException(text);
			}
		}
	}

	private void m2(ip A_0, p A_1, bool A_2, int A_3, int A_4, g.a A_5, bool A_6, bool A_7, ref bool A_8, ref bool A_9, ref bool A_10)
	{
		global::h.h h10 = global::h.h.a;
		if (ix[A_3] == global::h.f.c)
		{
			h10 = global::h.h.b;
		}
		double num = 1.0;
		double[] a_ = null;
		ErrPublic errPublic = m2(A_0, (float)num, ref A_9, ref A_10, A_2, A_1.ab[(int)h10], a_, A_1.n[A_3], A_1.h, A_1.d3(), A_1.an, A_6, A_7);
		if (errPublic == ErrPublic.None)
		{
			return;
		}
		A_8 = false;
		((global::r.d.a)A_5).a = global::r.d.a.a.b;
		switch (errPublic)
		{
		case ErrPublic.NoLight:
			A_5.j = global::r.g.a.a.c;
			A_5.s = vk();
			A_5.r = ix[A_3];
			A_5.v = y0();
			if (A_5.v)
			{
				A_5.k = y7();
			}
			break;
		case ErrPublic.LightTooBright:
			ab8().c(fz.b.a, "Saturation error when Autoscaling for Ref or Sample. SubmoduleIdx=" + A_3 + ", specIdx=" + A_4 + ", Int. time=" + A_0.u9());
			A_5.j = global::r.g.a.a.e;
			break;
		case ErrPublic.SignalNotProportionalToIntTime:
			A_5.j = global::r.g.a.a.f;
			break;
		case ErrPublic.LowSaturationIntensity:
			A_5.j = global::r.g.a.a.g;
			break;
		default:
			A_5.j = global::r.g.a.a.u;
			ab8().c(fz.a.b, "USBSpecAcquireAutoIntErrorFmt3", A_10, A_9, A_0.yq());
			break;
		}
	}

	private global::h m2(hg A_0, bool A_1, n A_2, n A_3, ref bool A_4)
	{
		A_4 = global::r.p9(A_2) || global::r.p9(A_3);
		return m2(A_0, A_1, A_4);
	}

	private global::h m2(hg A_0, bool A_1, bool A_2)
	{
		global::h A_3;
		if (A_1)
		{
			if (iv[0] && iv[1])
			{
				if (A_2)
				{
					A_3 = new global::h(A_0.dh());
					A_0.b8().a(ref A_3);
					A_3.r(global::h.e.a);
				}
				else
				{
					A_3 = A_0.b8();
				}
			}
			else
			{
				A_3 = new global::h(A_0.dh());
				A_0.b8().a(ref A_3);
				if (iv[0])
				{
					A_3.r(global::h.e.b);
				}
				else
				{
					A_3.r(global::h.e.c);
				}
			}
		}
		else
		{
			A_3 = A_0.b8();
		}
		return A_3;
	}

	private void m2(float A_0, ip A_1, int A_2, int A_3, bool A_4, bool A_5, float A_6)
	{
		if (A_0 <= 0f)
		{
			if (A_5)
			{
				ab8().c(fz.b.b, "Invalid MeasTime: OverrideIntTime=" + A_5 + ", overrideIntTimeValue=" + A_6);
				return;
			}
			iq a_ = null;
			double num = A_1.qh(a_, A_4);
			double num2 = A_1.m2(jk, A_4);
			ab8().c(fz.b.b, "Invalid MeasTime: submoduleIdx=" + A_2 + ", specIdx=" + A_3 + ", SpectrometerActive()=" + p9(hc.b8(), A_3, A_2, A_3: true) + ", oneSpecIntTime=" + num + ", oneSpecNumAvg=" + num2 + ", measTiming=" + A_1.u3().ToString() + ", RefExists=" + Conversions.ToString(A_1.m2(a_)));
		}
	}

	private void m2(p A_0)
	{
		g.a A_1 = null;
		h.a A_2 = null;
		m2(A_0, ref A_1, ref A_2, A_3: false);
	}

	private void m2(p A_0, ref g.a A_1, ref h.a A_2)
	{
		m2(A_0, ref A_1, ref A_2, A_3: true);
	}

	private void m2(p A_0, ref g.a A_1, ref h.a A_2, bool A_3)
	{
		_ = string.Empty;
		_ = string.Empty;
		long a_ = default(long);
		if (A_0.g != null)
		{
			a_ = A_0.g.d();
		}
		A_1 = new g.a(A_0.d3(), a_);
		global::r.d.a a10 = new global::r.d.a(A_0.d3(), a_);
		global::r.d.a a_2 = new global::r.d.a(A_0.d3(), a_);
		bool flag = false;
		checked
		{
			bool[] array = new bool[global::h.a() + 1];
			string a_3 = string.Empty;
			bool[] array2 = new bool[global::h.a() + 1];
			bool[] array3 = new bool[global::h.a() + 1];
			bool A_4 = false;
			hr A_5 = null;
			hr hr2 = null;
			hr A_6 = null;
			hr A_7 = null;
			int upperBound = iq.GetUpperBound(0);
			bool[] array4 = new bool[upperBound + 1];
			bool[] array5 = new bool[upperBound + 1];
			Collection<float[]> collection = null;
			if (mv == null)
			{
				Interlocked.CompareExchange(ref mv, new StaticLocalInitFlag(), null);
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(mv, ref lockTaken);
				if (mv.State == 0)
				{
					mv.State = 2;
					mu = new Collection<h.a>();
				}
				else if (mv.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				mv.State = 1;
				if (lockTaken)
				{
					Monitor.Exit(mv);
				}
			}
			bool flag2 = false;
			bool flag3 = ((m)A_0).a == m.a.c && A_0.l != null;
			bool flag4 = hc.d0().c() == g2.a.b && !flag3;
			bool flag5 = hc.d0().c() == g2.a.n;
			bool flag6 = flag5 && ik != null && ik.e();
			bool A_8 = true;
			o o2;
			bool A_9;
			lock (A_0)
			{
				o2 = A_0.d2();
				A_9 = A_0.s;
			}
			bool flag7 = o2 == o.d || o2 == o.e || o2 == o.j;
			bool flag8 = flag7 || o2 == o.g || o2 == o.h || o2 == o.k;
			bool flag9 = o2 == o.d || o2 == o.g;
			bool flag10 = o2 == o.e || o2 == o.h;
			bool flag11 = flag4 && kz;
			bool flag12 = o2 == o.c;
			bool flag13 = (o2 == o.k || o2 == o.j) && kz;
			bool flag14 = ((m)A_0).a == m.a.d || ((m)A_0).a == m.a.e || flag13;
			bool flag15 = false;
			ej ej2 = null;
			global::h h10 = null;
			bool flag16 = false;
			bool flag17 = A_0.l == null || A_0.l.j;
			((global::r.d.a)A_1).a = global::r.d.a.a.a;
			A_1.h = gt;
			if (A_0.am != null)
			{
				A_0.am.ce = DateTime.Now;
			}
			p p2;
			(p2 = A_0).d1(p2.d1() + 1);
			hg A_10 = null;
			hc A_11 = null;
			string A_12 = null;
			bool A_16 = default(bool);
			ErrPublic A_45 = default(ErrPublic);
			try
			{
				if (il != null)
				{
					if (A_0.l == null)
					{
						sj(A_0: true);
					}
					else if (!il.d())
					{
						sj(A_0: true);
					}
				}
				hj A_13 = null;
				int A_14 = 0;
				bool A_15 = false;
				bool flag18 = false;
				if (A_0.d0(n.i))
				{
					m2(ref A_10, null, ref A_16, ref A_9);
				}
				bool flag19 = false;
				if (vk())
				{
					if (A_0.n[iu[0]] == n.a && A_0.n.GetUpperBound(0) > 0)
					{
						if (A_0.n[iu[1]] == n.a && A_0.n.GetUpperBound(0) > 1)
						{
							flag19 = A_0.n[iu[2]] == n.i;
							flag15 = global::r.m2(A_0.n[iu[2]]);
						}
						else
						{
							flag19 = A_0.n[iu[1]] == n.i;
							flag15 = global::r.m2(A_0.n[iu[1]]);
						}
					}
					else
					{
						flag19 = A_0.n[iu[0]] == n.i;
						flag15 = global::r.m2(A_0.n[iu[0]]);
					}
				}
				else
				{
					flag19 = A_0.n[0] == n.i;
					flag15 = global::r.m2(A_0.n[0]);
				}
				bool flag20 = default(bool);
				bool flag21 = default(bool);
				int a_7 = default(int);
				int num2 = default(int);
				bool flag23 = default(bool);
				int num6 = default(int);
				double num11 = default(double);
				bool flag29 = default(bool);
				bool A_18 = default(bool);
				bool A_19 = default(bool);
				double a_15 = default(double);
				bool A_20 = default(bool);
				int A_21 = default(int);
				int A_22 = default(int);
				float A_23 = default(float);
				DateTime now = default(DateTime);
				float A_24 = default(float);
				float A_25 = default(float);
				bool flag33 = default(bool);
				float A_26 = default(float);
				float num22 = default(float);
				bool flag34 = default(bool);
				bool flag35 = default(bool);
				bool flag36 = default(bool);
				float A_27 = default(float);
				int a_25 = default(int);
				int a_26 = default(int);
				bool flag37 = default(bool);
				bool flag38 = default(bool);
				bool A_28 = default(bool);
				float A_29 = default(float);
				bool A_30 = default(bool);
				bool flag39 = default(bool);
				bool flag40 = default(bool);
				bool A_32 = default(bool);
				bool A_33 = default(bool);
				bool A_34 = default(bool);
				double a_39 = default(double);
				short a_40 = default(short);
				double a_41 = default(double);
				global::h.MeasurementTimingType a_42 = default(global::h.MeasurementTimingType);
				int a_44 = default(int);
				float num41 = default(float);
				float A_39 = default(float);
				bool flag44 = default(bool);
				DateTime a_48 = default(DateTime);
				int num59 = default(int);
				bool flag45 = default(bool);
				bool a_53 = default(bool);
				do
				{
					try
					{
						flag20 = false;
						if (!A_15)
						{
							j7 = false;
							A_0.i = false;
							if (!flag4 || ((m)A_0).a == m.a.g || flag9 || flag10 || flag11)
							{
								jg.d(gt, a_2);
							}
							if (flag4)
							{
								n n2 = n.b;
								n n3 = n.b;
								if (iv[0])
								{
									n2 = A_0.n[iu[0]];
									if (iv[1])
									{
										n3 = A_0.n[iu[1]];
									}
									else
									{
										flag21 = true;
									}
								}
								else
								{
									n2 = A_0.n[0];
									n3 = A_0.n[0];
								}
								hg a_4 = hc;
								n a_5 = n2;
								n a_6 = n3;
								bool A_17 = false;
								h10 = m2(a_4, flag4, a_5, a_6, ref A_17);
							}
							else
							{
								h10 = m2(hc, A_1: false, A_2: false);
							}
							a10.a = global::r.d.a.a.a;
							if (A_0.g != null)
							{
								A_0.g.e(gt, a10);
							}
							if (flag14 && A_0.ap + 1 == A_0.t)
							{
								jj.m = A_0.ap + 1;
								mu.Clear();
							}
							if (!flag14 && mu.Count > 0)
							{
								mu.Clear();
							}
							int num = 0;
							do
							{
								hr2 = new hr(hc.dh().aw());
								if (upperBound > 0)
								{
									if (iu[1] > 0)
									{
										A_6 = new hr(hc.dh().aw());
									}
									if (iu[2] > 0)
									{
										A_7 = new hr(hc.dh().aw());
									}
								}
								if (flag14)
								{
									num = A_0.ap + 1 - A_0.t;
									if (jj.a)
									{
										break;
									}
									jj.t(num + 1);
								}
								A_2 = new h.a(A_0.d3(), a_, hc.dh().aw());
								((global::r.d.a)A_2).a = global::r.d.a.a.a;
								A_2.h = gt;
								if (!hc.d0().o() || flag3 || flag14)
								{
									A_0.d0(u1());
								}
								bool flag22 = ((m)A_0).a != m.a.g && (!hc.d0().n() || kz);
								if (flag15)
								{
									a_7 = m2(A_0, h10);
									A_0.h.u(a_7);
									num2 = 1;
								}
								if (flag22)
								{
									if (l2 != null && (!l2.ab().p() || (A_0.l == null && (!flag14 || num == A_0.ap))))
									{
										int num3 = iq.Length - 1;
										for (int num4 = 0; num4 <= num3; num4++)
										{
											if (A_0.n[num4] == n.b)
											{
												flag23 = true;
												break;
											}
										}
									}
									else
									{
										flag23 = false;
									}
									int num5 = p9(A_0, h10);
									if (flag23)
									{
										num5++;
									}
									A_0.h.u(num5);
									num6 = 1;
								}
								if (flag4)
								{
									bool flag24 = false;
									int num7 = upperBound;
									for (int num8 = 0; num8 <= num7; num8++)
									{
										if (o2 == o.b)
										{
											int num9 = iq[num8].Count - 1;
											for (int num10 = 0; num10 <= num9; num10++)
											{
												iq[num8][num10].ww();
											}
										}
										num11 += iq[num8][0].sm(0, iq[num8][0].sj(0, A_1: false));
										if (global::r.qh(A_0.n[num8]))
										{
											flag24 = true;
										}
									}
									if (flag24)
									{
										int num12 = upperBound;
										for (int num13 = 0; num13 <= num12; num13++)
										{
											iq[num13][0].xn();
										}
										m2(A_0, 0f, A_2: false, A_3: false);
									}
								}
								bool flag25 = false;
								for (int num14 = upperBound; num14 >= 0; num14 += -1)
								{
									if (global::r.p9(A_0.n[num14]))
									{
										array4[num14] = s3(num14);
										array5[num14] = st(num14);
										m2(A_0: false, A_1: false, num14, A_3: false);
									}
									else
									{
										bool flag26 = false;
										bool flag27 = uu();
										bool flag28 = ut();
										if (flag27 && !m2(h10, num14, hc.d0().q()))
										{
											flag26 = true;
											flag27 = false;
										}
										if (flag28 && !p9(h10, num14))
										{
											flag26 = true;
											flag28 = false;
										}
										flag29 = ut() && p9(h10, num14) && num14 == iu[0] && vk();
										if (flag26)
										{
											m2(flag27, flag28, num14, A_3: false);
										}
									}
									Collection<hr> collection2 = new Collection<hr>();
									bool flag30 = false;
									int num15 = iq[num14].Count - 1;
									for (int num10 = 0; num10 <= num15; num10++)
									{
										if (!p9(h10, num10, num14) || !p9(h10, num14, A_0.n[num14], A_0.aj, A_0.ak))
										{
											continue;
										}
										ip ip2 = null;
										ip2 = iq[num14][num10];
										try
										{
											if (((m)A_0).a == m.a.g)
											{
												if (A_10 != null && A_0.n[num14] != n.a)
												{
													ip2.st(A_14);
												}
												ip2.m2(hc.b8().@as(), flag4);
												if (flag5 && A_0.n[num14] == n.c)
												{
													ik.d(A_0: true, A_1: true);
												}
												if (im != null && A_0.d3() == global::r.d.a.b.b && global::r.qh(A_0.n[num14]) && !ip2.aby() && (!za() || !im.tc() || ip2.m2(im, A_0.h, A_0.d3())))
												{
													if (im.s4() && @in)
													{
														throw new ah("Operation could not be completed because Baseline Hardware Adjustment Procedure is required, but is being inhibited.");
													}
													if (!@in)
													{
														ip obj = ip2;
														h5 a_8 = im;
														global::r.c a_9 = A_0.h;
														bool a_10 = io;
														global::r.d.a.b a_11 = A_0.d3();
														bool A_17 = false;
														obj.m2(a_8, a_9, a_10, a_11, ref A_17);
													}
												}
												if (A_0.z[num14])
												{
													if (ip2.u3() != global::h.MeasurementTimingType.Manual || A_0.n[num14] == n.o)
													{
														bool a_12 = false;
														bool a_13 = !A_0.aa && A_0.n[num14] != n.n && A_0.n[num14] != n.m;
														bool a_14 = A_0.n[num14] == n.n;
														if (flag15)
														{
															float num16 = (float)(0.004 * ip2.vl());
															if (num16 <= 0f)
															{
																ab8().c(fz.b.b, "Invalid segmentTime: specDevice.MaxIntTime=" + ip2.vl());
															}
															A_0.h.t(num2, DateAndTime.Now, num16);
															num2++;
														}
														m2(ip2, A_0, a_13, num14, num10, A_1, a_12, a_14, ref A_8, ref A_18, ref A_19);
														if (A_0.h != null && A_0.h.a)
														{
															return;
														}
														if (A_0.aw && iu[num14] == 1)
														{
															a_15 = ip2.u9();
															ip2.sj(a_15);
															flag16 = true;
														}
													}
													else
													{
														ip2.so(ip2.u4());
													}
													if (A_8)
													{
														A_8 = !m2(A_19, ref A_1, ref A_0);
													}
												}
												else if (A_0.n[num14] == n.c || A_0.n[num14] == n.o)
												{
													global::f.b a_16 = ((iq[num14].Count > 1) ? ((num10 != jp[num14]) ? global::f.b.c : global::f.b.b) : global::f.b.b);
													ip2.so(h10.a(num14).b(a_16));
												}
												else if (A_0.n[num14] == n.d || A_0.n[num14] == n.e || A_0.n[num14] == n.m || A_0.n[num14] == n.h)
												{
													if (A_0.aw && iu[num14] == 1)
													{
														if (ip2.so(ip2.u8()) != f0.FIDeviceErr.None)
														{
															A_1.j = global::r.g.a.a.m;
															((global::r.d.a)A_1).a = global::r.d.a.a.b;
															A_8 = false;
															ab8().c(fz.a.b, "USBSpecSetIntTimeErrorFmt", ip2.u8());
														}
													}
													else if (ip2.qh(jk, flag4) != f0.FIDeviceErr.None)
													{
														A_1.j = global::r.g.a.a.m;
														((global::r.d.a)A_1).a = global::r.d.a.a.b;
														A_8 = false;
														ab8().c(fz.a.b, "USBSpecSetIntTimeErrorFmt", ip2.sm(0, jk));
													}
												}
												if (A_8)
												{
													if (A_0.n[num14] == n.c || A_0.n[num14] == n.o || A_0.n[num14] == n.k || A_0.n[num14] == n.g)
													{
														ErrPublic errPublic = m2(ip2, num14, ref A_20, ref A_0.h, A_0.d3());
														if (flag16)
														{
															ip2.so(ip2.u8());
														}
														if (errPublic == ErrPublic.None)
														{
															if (!A_20)
															{
																A_8 = false;
																A_1.j = global::r.g.a.a.h;
																((global::r.d.a)A_1).a = global::r.d.a.a.b;
																if ((A_0.n[num14] == n.c && !p9(A_0.n[num14])) || A_0.n[num14] == n.k)
																{
																	ip2.so(A_0.an);
																}
															}
														}
														else
														{
															ab8().c(fz.b.a, "Error in TestSatDetectionAfterAcqRef retval=" + errPublic, Environment.StackTrace);
															A_1.j = global::r.g.a.a.u;
															((global::r.d.a)A_1).a = global::r.d.a.a.b;
															A_8 = false;
														}
													}
													if (A_8)
													{
														bool flag31 = false;
														int num17 = 0;
														float num18 = ((!flag5 || iq == null || iq[0] == null || (iq[0].Count <= 1 && iq[0][0].xs() != FMUSBDeviceType.FIUSB2DeviceSpecTCNIR)) ? 0.003f : 0.01f);
														do
														{
															if (flag5 && A_0.n[num14] == n.c)
															{
																ik.d(A_0: true, A_1: false);
															}
															if ((A_0.n[num14] == n.c || A_0.n[num14] == n.o || A_0.n[num14] == n.k || A_0.n[num14] == n.g) && A_0.z[num14] && !ip2.vt())
															{
																A_8 = m2(ip2, ref A_19, ref A_18, ip2.u9(), A_4: true, ref A_21, ref A_22, ref A_23, ref A_0.h, A_0.d3()) == ErrPublic.None;
															}
															if (!A_19 && !(A_18 & flag17) && A_8)
															{
																if (A_0.n[num14] == n.n && ip2.u3() != global::h.MeasurementTimingType.Manual)
																{
																	int num19 = 1;
																	double num20 = ip2.u9();
																	ip2.xd();
																	try
																	{
																		A_0.h.t(0f, global::r.d.a.b.a);
																		do
																		{
																			ip2.so((double)num19 * num20 / 10.0);
																			short a_17 = ip2.qh(ip2.u9(), flag4);
																			if (ip2.m2(ref A_19, ref A_18, xo(), A_0.ah, ip2.u9(), a_17, A_0.h, A_0.d3()) != f0.FIDeviceErr.None)
																			{
																				ab8().c(fz.a.b, "USBSpecAcquireAutoIntErrorFmt3", A_19, A_18, ip2.yq());
																				A_8 = false;
																			}
																			ip2.xf();
																			num19++;
																			A_0.h.t((float)((double)(num19 - 1) / 10.0 * 100.0));
																		}
																		while (num19 <= 10 && A_8 && !A_0.h.a);
																	}
																	finally
																	{
																		A_0.h.z();
																	}
																	if (!A_8 || A_0.h.a)
																	{
																		ip2.xe();
																	}
																}
																else
																{
																	short a_17;
																	if (A_0.n[num14] == n.f)
																	{
																		a_17 = ip2.p9(ip2.u9());
																	}
																	else if (A_0.n[num14] == n.k || A_0.n[num14] == n.m)
																	{
																		a_17 = Math.Min((short)Math.Round(25000.0 / ip2.u9()), (short)2500);
																		now = DateTime.Now;
																	}
																	else
																	{
																		a_17 = ip2.qh(ip2.u9(), flag4);
																	}
																	if (flag15 && num17 == 0)
																	{
																		float num21 = (float)(0.002 * (double)a_17 * ip2.u9());
																		if (num21 <= 0f)
																		{
																			ab8().c(fz.b.b, "Invalid segmentTime: numAveragesForGoodSpectrum=" + a_17 + ", specDevice.SpectrometerIntTime=" + ip2.u9());
																		}
																		A_0.h.t(num2, DateAndTime.Now, num21);
																		num2++;
																	}
																	if (flag5 && A_0.n[num14] == n.d && ip2.xb())
																	{
																		if (!flag30)
																		{
																			bool flag32 = ip2.wt() && ip2.ws();
																			ik.d(flag32, !flag32);
																			A_8 = m2(ip2, ref A_19, ref A_18, ip2.u9(), A_4: true, ref A_21, ref A_22, ref A_24, ref A_0.h, A_0.d3()) == ErrPublic.None;
																			if (A_8)
																			{
																				ik.d(!flag32, flag32);
																				A_8 = m2(ip2, ref A_19, ref A_18, ip2.u9(), A_4: true, ref A_21, ref A_22, ref A_25, ref A_0.h, A_0.d3()) == ErrPublic.None;
																				if (A_8)
																				{
																					flag33 = ((!(A_24 > A_25)) ? (!flag32) : flag32);
																					flag30 = true;
																					ik.d(!flag33, flag33);
																				}
																			}
																		}
																		if (A_8)
																		{
																			ip2.td(!flag33);
																			ip2.m2(jk, 0, null, A_3: true, A_4: false, 0);
																			ip2.m2(flag33, A_10 != null, A_14);
																		}
																	}
																	if (A_8 && ip2.m2(ref A_19, ref A_18, xo(), A_0.ah, ip2.u9(), a_17, A_0.h, A_0.d3()) != f0.FIDeviceErr.None)
																	{
																		ab8().c(fz.a.b, "USBSpecAcquireAutoIntErrorFmt3", A_19, A_18, ip2.yq());
																		A_8 = false;
																	}
																	else
																	{
																		if (A_0.n[num14] == n.k || A_0.n[num14] == n.m)
																		{
																			string empty = string.Empty;
																			empty = ((A_0.n[num14] != n.k) ? "CTM Spectrometer Dark Acq: " : "CTM Ref Acq: ");
																			ab8().c(fz.b.b, empty + a_17 + " " + ip2.u9() + " " + global::jh.a(now));
																		}
																		if (A_0.ac)
																		{
																			A_5 = new hr(hc.dh().aw());
																			if (ip2.m2(ref A_5) != f0.FIDeviceErr.None)
																			{
																				A_8 = false;
																			}
																			collection2.Add(A_5);
																		}
																		switch (A_0.n[num14])
																		{
																		case n.c:
																		case n.k:
																		case n.o:
																		{
																			ip ip4 = ip2;
																			if (p9(A_0.n[num14]))
																			{
																				if (ix[num14] == global::h.f.b)
																				{
																					if (!ip4.m2(jk, A_1: true, A_2: true, A_3: false, A_4: true, A_0.aw))
																					{
																						ab8().c(fz.a.b, "ErrAutoRefFileFmt2", ip4.uq(), ip4.yq());
																						((global::r.d.a)A_2).a = global::r.d.a.a.b;
																					}
																					if (flag4 && !A_0.aw)
																					{
																						ip4.sj(ip4.u9());
																						ip4.m2(A_0.al, A_1: false, A_2: false, A_3: false);
																					}
																				}
																				else if (!ip4.m2(A_0: true, A_0.an, jk))
																				{
																					A_8 = false;
																					A_1.j = global::r.g.a.a.o;
																					((global::r.d.a)A_1).a = global::r.d.a.a.b;
																					ab8().c(fz.a.b, "ErrAutoRefFmt3", ip4.uq(), ip4.yq(), ip4.vp());
																				}
																			}
																			else
																			{
																				if (ej2 == null)
																				{
																					if (flag15 && l2 != null)
																					{
																						A_0.h.t(num2, DateAndTime.Now, 5.5f);
																						num2++;
																					}
																					ej2 = t0();
																				}
																				if (flag5)
																				{
																					ip4.m2(ej2);
																					ik.d(A_0: false, A_1: true);
																					if (A_8 && ip2.m2(ref A_19, ref A_18, xo(), A_0.ah, ip2.u9(), a_17, A_0.h, A_0.d3()) != f0.FIDeviceErr.None)
																					{
																						ab8().c(fz.a.b, "USBSpecAcquireAutoIntErrorFmt3", A_19, A_18, ip2.yq());
																						A_8 = false;
																					}
																					else
																					{
																						ip2.xh();
																					}
																				}
																				else
																				{
																					ip4.m2(jk, A_0.an, ej2, A_0.n[num14] == n.k, A_10 != null, A_14);
																				}
																				m2(A_0: true, array5[num14], num14, A_3: false);
																			}
																			ip4 = null;
																			break;
																		}
																		case n.g:
																		{
																			ip ip3 = ip2;
																			if (!ip3.m2(A_0: false, A_0.an, jk))
																			{
																				A_8 = false;
																				A_1.j = global::r.g.a.a.o;
																				((global::r.d.a)A_1).a = global::r.d.a.a.b;
																				ab8().c(fz.a.b, "ErrAutoRefFmt3", ip3.uq(), ip3.yq(), ip3.vp());
																			}
																			ip3 = null;
																			break;
																		}
																		}
																	}
																}
															}
															if (!A_19 && (!A_18 || !flag17) && A_8 && (A_0.n[num14] == n.c || A_0.n[num14] == n.o || A_0.n[num14] == n.k || A_0.n[num14] == n.g) && A_0.z[num14] && !ip2.vt())
															{
																if (flag5)
																{
																	ik.d(A_0: true, A_1: false);
																}
																A_8 = m2(ip2, ref A_19, ref A_18, ip2.u9(), A_4: false, ref A_21, ref A_22, ref A_26, ref A_0.h, A_0.d3()) == ErrPublic.None;
																if (A_23 > 400f && A_26 > 400f)
																{
																	num22 = 2f * Math.Abs(A_23 - A_26) / (A_23 + A_26);
																	flag31 = ((num22 > num18) ? true : false);
																}
																else
																{
																	flag31 = false;
																}
															}
															if (flag5 && A_0.n[num14] == n.c)
															{
																ik.d(flag6, !flag6);
															}
															num17++;
														}
														while (num17 < 2 && flag31);
														if (flag31)
														{
															A_1.j = global::r.g.a.a.p;
															A_1.k = num22;
															A_1.l = num18;
															if (!string.IsNullOrEmpty(((global::r.d.a)A_1).b))
															{
																((global::r.d.a)A_1).b += "\r\n";
															}
															((global::r.d.a)A_1).b += A_1.a6();
														}
													}
													if (A_8)
													{
														if (A_18 & flag17)
														{
															if (h10.n(v6()) == global::h.MeasurementTimingType.Manual)
															{
																A_1.j = global::r.g.a.a.j;
															}
															else if (flag16)
															{
																ip2.qh(a_15);
																ug();
																A_1.j = global::r.g.a.a.s;
															}
															else
															{
																A_1.j = global::r.g.a.a.e;
																ab8().c(fz.b.a, "Saturation error when acquiring Ref or Sample. SubmoduleIdx=" + num14 + ", specIdx=" + num10 + ", Int. time=" + ip2.u9());
															}
															if (flag15)
															{
																A_0.h.u(a_7);
															}
															bool a_18 = false;
															m2(A_1, A_0.d3(), num10, num14, a_18);
															((global::r.d.a)A_1).a = global::r.d.a.a.b;
															A_8 = false;
														}
														else
														{
															A_8 = !m2(A_19, ref A_1, ref A_0);
														}
													}
												}
											}
											else
											{
												if ((hc.d0().o() || flag4) && ((m)A_0).a == m.a.f)
												{
													flag34 = !flag4;
													flag35 = hc.d0().n();
													if (kz)
													{
														flag36 = false;
													}
													else
													{
														flag36 = hc.d0().n();
														k1 = !flag36;
													}
												}
												else
												{
													flag36 = false;
													flag34 = false;
													flag35 = false;
												}
												if (s8(num14, num10) && l8 != null && l8.e() && l8.d() == global::g6.a.b && !zi() && (((flag34 || flag4) && kz) || (!flag34 && !flag19 && s3(num14))))
												{
													p9(m2());
												}
												if (hc.d0().q() && ip2.w2())
												{
													flag = true;
													if (A_0.au)
													{
														ip2.so(A_0.av / 10.0);
													}
													else
													{
														m2(ip2, A_0, A_2: false, num14, num10, A_1, A_6: true, flag, ref A_8, ref A_18, ref A_19);
														if (A_0.h != null && A_0.h.a)
														{
															return;
														}
													}
												}
												A_5 = new hr(hc.dh().aw());
												if (A_0.ax || m2(h10, num14, num10, hc.d0().q()))
												{
													if (flag22)
													{
														float num23 = ((!A_0.ax) ? p9(num14, num10) : ((float)A_0.ay));
														m2(num23, ip2, num14, num10, flag4, A_0.ax, (float)A_0.ay);
														A_0.h.t(num6, DateTime.Now, num23);
														num6++;
													}
													int num24 = 0;
													if (flag4 && iv[0] && iv[1] && flag36)
													{
														double num25 = m2(iu[0]);
														double num26 = m2(iu[1]);
														if (iu[0] == num14 && global::jf.b(num25, 0f))
														{
															if (num26 / num25 > 2.0)
															{
																num24 = (int)Math.Round(Math.Floor(num26 / num25));
															}
														}
														else if (iu[1] == num14 && global::jf.b(num26, 0f) && num25 / num26 > 2.0)
														{
															num24 = (int)Math.Round(Math.Floor(num25 / num26));
														}
													}
													float[] array6 = null;
													float[] array7 = null;
													float num27 = 0f;
													float num28 = 0f;
													Guid guid = default(Guid);
													if (flag29 && (!flag4 || !flag36) && A_8)
													{
														t8();
														global::f.b index = so(num14, num10);
														ip a_19 = ip2;
														ref bool a_20 = ref A_0.q;
														ref bool a_21 = ref A_0.r;
														bool A_17 = flag34 || flag4;
														A_8 = unchecked(m2(a_19, ref a_20, ref a_21, ref A_5, ref A_27, ref A_17, A_0.ah, ref A_0.h, A_0.d3(), A_0.au, A_0.av, flag4, flag36, 0, collection[i7[(int)index]], i1[(int)index], i2[(int)index], i3[(int)index], i4[(int)index], A_0.ax, A_0.ay, array6, array7, num27, num28, guid)) == ErrPublic.None;
														ip2.m2(A_5, A_6);
													}
													else if (A_8)
													{
														if (flag5 && ip2.wf())
														{
															ik.d(ip2.ws(), !ip2.ws());
															A_8 = ip2.m2(ref A_19, ref A_18, xo(), A_0.ah, ref A_0.h, A_0.d3(), jk, A_0.au, A_0.av, flag4, flag36, num24, A_0.ax, A_0.ay, 1) == f0.FIDeviceErr.None;
															if (A_8)
															{
																ip2.xg();
															}
															ik.d(!ip2.ws(), ip2.ws());
														}
														if (A_8)
														{
															ip a_22 = ip2;
															ref bool a_23 = ref A_0.q;
															ref bool a_24 = ref A_0.r;
															bool A_17 = flag34 || flag4;
															A_8 = m2(a_22, ref a_23, ref a_24, ref A_5, ref A_27, ref A_17, A_0.ah, ref A_0.h, A_0.d3(), A_0.au, A_0.av, flag4, flag36, num24, A_0.ax, A_0.ay, array6, array7, num27, num28, guid) == ErrPublic.None;
														}
													}
												}
												else
												{
													A_8 = false;
													A_1.j = global::r.g.a.a.o;
													((global::r.d.a)A_1).a = global::r.d.a.a.b;
												}
												if (A_8 && A_5.c2() > 0 && global::jf.b(A_5.cz()[A_5.c2() - 1], 0.0))
												{
													collection2.Add(A_5);
												}
												if (A_8)
												{
													if (A_0.r)
													{
														a_25 = num14;
														a_26 = num10;
														if (flag35 && iu[num14] == 1 && !lu)
														{
															lu = true;
															jg.d(gt, a_2);
															ab8().c(fz.b.a, "mAutoRefTSpecSaturatedUsingReferenceIntegrationTime = True, IntTime = " + ip2.u9());
														}
													}
													else if (flag35 && iu[num14] == 1 && lu)
													{
														lu = false;
														jg.d(gt, a_2);
														ab8().c(fz.b.a, "mAutoRefTSpecSaturatedUsingReferenceIntegrationTime = False, IntTime = " + ip2.u9());
													}
													flag37 = false;
													if (A_0.q || (A_0.r && flag35 && h10.n(v6()) != global::h.MeasurementTimingType.Manual))
													{
														A_8 = !m2(A_0.q, ref A_1, ref A_0);
														if (A_8)
														{
															A_8 = m2(ip2, A_0, flag35, flag, num14, A_0.h, A_0.d3());
															if (A_8 && flag35)
															{
																flag37 = true;
																A_5.am(A_0: false);
															}
															else
															{
																if (h10.n(v6()) == global::h.MeasurementTimingType.Manual)
																{
																	A_1.j = global::r.g.a.a.j;
																}
																else if (A_0.z != null && A_0.z[num14])
																{
																	A_1.j = global::r.g.a.a.k;
																}
																else
																{
																	A_1.j = global::r.g.a.a.q;
																}
																bool a_27 = false;
																m2(A_1, A_0.d3(), num10, num14, a_27);
																((global::r.d.a)A_2).a = global::r.d.a.a.b;
																((global::r.d.a)A_1).a = global::r.d.a.a.b;
																if (A_0.l != null && !flag4)
																{
																	A_0.l.q(unchecked((int)A_1.j), global::r.d.a.a.b, "", A_1.k, A_1.l, A_1.p, A_1.q, A_1.r, A_1.s, A_9: true);
																}
																A_2.x = true;
																flag38 = true;
																array[num14] = true;
															}
														}
													}
												}
											}
											unchecked
											{
												if (A_8)
												{
													h.a a11 = A_2;
													hr.b b10 = A_5?.cj() ?? hr.b.a;
													if (flag34 || flag4)
													{
														a11.aa = false;
														if (b10 == hr.b.b || b10 == hr.b.k)
														{
															flag38 = true;
															array[num14] = true;
														}
														else if (flag35)
														{
															if (flag4)
															{
																t5();
															}
															if (flag12)
															{
																array3[num14] = true;
																array2[num14] = false;
															}
															else if (num14 == iu[1])
															{
																ip2.m2(flag4, num11, hc.dh().a8(), A_3: false, A_4: false, flag11, ll, A_7: false, ref array3[num14], ref array2[num14], ref A_28, ref A_29, ref A_30);
																flag39 = A_29 < 0.8f || A_30 || ly;
																flag40 = array3[num14] && !flag39;
															}
															else
															{
																ip obj2 = ip2;
																double a_28 = num11;
																bool a_29 = hc.dh().a8();
																bool a_30 = flag40;
																bool a_31 = flag39;
																float a_32 = ll;
																bool a_33 = flag21;
																ref bool a_34 = ref array3[num14];
																ref bool a_35 = ref array2[num14];
																float A_31 = 0f;
																obj2.m2(flag4, a_28, a_29, a_30, a_31, flag11, a_32, a_33, ref a_34, ref a_35, ref A_28, ref A_31, ref A_32);
																if (flag4 && !flag40 && !flag39 && !A_32 && array3[num14] && !flag21 && !ly)
																{
																	if (!lv)
																	{
																		lv = true;
																		lx = DateTime.Now;
																	}
																	if (DateTime.Now.Subtract(lx).TotalSeconds > 3.0)
																	{
																		ip obj3 = iq[iu[1]][0];
																		DateTime a_36 = jk;
																		double a_37 = num11;
																		float a_38 = ll;
																		bool A_17 = false;
																		obj3.m2(a_36, A_1: true, flag4, a_37, A_4: false, a_38, ref A_17, ref A_33);
																	}
																}
																else
																{
																	lv = false;
																}
															}
															if (A_28 && !flag4)
															{
																A_1.j = global::r.g.a.a.b;
																((global::r.d.a)A_1).a = global::r.d.a.a.b;
																A_8 = false;
																A_0.l.q((int)A_1.j, global::r.d.a.a.b, A_2: true);
															}
															if ((!flag4 && array2[num14]) || (flag4 && (flag8 || kz)))
															{
																if (!flag4)
																{
																	ip2.te(A_0: false);
																}
																if (A_27 < 1500f && h10.n(v6()) != global::h.MeasurementTimingType.Manual && (!flag4 || num14 != iu[1]))
																{
																	global::h.h h11 = global::h.h.a;
																	if (ix[num14] == global::h.f.c)
																	{
																		h11 = global::h.h.b;
																	}
																	if (m2(ip2, 1f, ref A_19, ref A_18, A_4: false, A_0.ab[(int)h11], null, A_0.n[num14], A_0.h, A_0.d3(), 0, A_11: false, A_12: false) != ErrPublic.None)
																	{
																		ab8().c(fz.a.b, "USBSpecAcquireAutoIntErrorFmt3", A_19, A_18, ip2.yq());
																	}
																	else
																	{
																		if (!flag4 || !flag36)
																		{
																			collection2.RemoveAt(checked(collection2.Count - 1));
																			collection2.Add(A_5.cw());
																		}
																		array2[num14] = false;
																	}
																	if (A_8)
																	{
																		A_8 = !m2(A_19, ref A_1, ref A_0);
																	}
																}
																else
																{
																	if (h10.n(v6()) == global::h.MeasurementTimingType.Manual)
																	{
																		global::f.b a_16 = ((iq[num14].Count > 1) ? ((jp[num14] != num10) ? global::f.b.c : global::f.b.b) : global::f.b.b);
																		ip2.so(h10.a((int)ix[num14]).b(a_16));
																	}
																	flag38 = true;
																	array[num14] = true;
																}
															}
															else if (A_8)
															{
																if (ip2.xl() != f0.FIDeviceErr.None)
																{
																	((global::r.d.a)A_2).a = global::r.d.a.a.b;
																	ab8().c(fz.a.b, "USBSpecSetIntTimeErrorFmt", ip2.sm(0, jk));
																}
																if (array3[num14])
																{
																	flag38 = false;
																	array[num14] = false;
																	if (!kz && !flag8)
																	{
																		if (!flag39 && !A_30)
																		{
																			ip2.m2(jk, array3[num14], flag4, num11, flag12, ll, ref A_4, ref A_34);
																		}
																		if (flag12)
																		{
																			li[num14] = A_34;
																		}
																		if (A_4 && !flag4)
																		{
																			A_1.j = global::r.g.a.a.d;
																			((global::r.d.a)A_1).a = global::r.d.a.a.b;
																			A_8 = false;
																			A_0.l.q((int)A_1.j, global::r.d.a.a.b, A_2: true);
																		}
																	}
																}
																else
																{
																	flag38 = false;
																	array[num14] = false;
																}
															}
														}
														else if (A_27 >= 200f)
														{
															flag38 = true;
															array[num14] = true;
															array2[num14] = true;
															if (!kz)
															{
																hf.Clear();
																i8.Clear();
															}
															kz = true;
														}
														else
														{
															flag38 = false;
															array[num14] = false;
														}
													}
													else
													{
														flag38 = true;
														array[num14] = true;
														a11.aa = A_9;
													}
													if (flag38)
													{
														if (flag34)
														{
															a11.x = !flag37;
														}
														else
														{
															a11.x = A_0.ac;
														}
														a11 = null;
														continue;
													}
												}
												else
												{
													if (A_1.j == global::r.g.a.a.a)
													{
														ab8().c(fz.a.b, "USBSpecAcquireErrorFmt", ip2.yq());
														A_1.o = ip2.abk().FriendlySN;
														A_1.j = global::r.g.a.a.n;
														((global::r.d.a)A_1).a = global::r.d.a.a.b;
													}
													if (A_0.l != null && !flag4)
													{
														A_0.l.q((int)A_1.j, global::r.d.a.a.b, ip2.abk().FriendlySN, A_1.k, A_1.l, A_1.p, A_1.q, A_1.r, A_1.s, A_9: true);
													}
												}
											}
										}
										finally
										{
											if (A_0.a0 == h6.b.c)
											{
												ip2.m2(a_39, a_40, a_41, a_42, A_4: false);
											}
										}
										break;
									}
									if ((num14 == upperBound || !sn(h10, upperBound)) && flag38 && ((!flag34 && !flag4) || (jn < 0 && !flag8) || (flag4 && kz)) && ((m)A_0).a != m.a.g && !flag25)
									{
										jn++;
										jo = false;
										flag25 = true;
									}
									h.a a12 = A_2;
									if (A_8)
									{
										if (flag38)
										{
											a_3 = ((jn == 0) ? ((!string.IsNullOrEmpty(jl)) ? jl : A_0.v) : ((!string.IsNullOrEmpty(jl)) ? (jl + "-" + Conversions.ToString(jn)) : (A_0.v + "-" + Conversions.ToString(jn))));
											if (!flag34 || ((m)A_0).a != m.a.f)
											{
												a12.x = A_0.ac;
											}
											if (m2(h10, num14, A_0.n[num14], A_0.aj, A_0.ak) && (a12.x || A_0.ad))
											{
												hr A_35 = null;
												m2(h10, num14, A_0, collection2, ref hr2, ref A_6, ref A_7, ref A_35);
												string a_43 = string.Empty;
												if (collection2.Count > 0)
												{
													a_44 = collection2[0].b6();
													a_43 = collection2[0].b7();
												}
												A_35.r(A_0.w, a_3, A_0.d0(), A_0.d1(), a_44, a_43);
												a12.h = gt;
											}
										}
										else
										{
											a12.x = false;
										}
									}
									else if (flag34)
									{
										hr A_36 = null;
										m2(h10, num14, A_0, collection2, ref hr2, ref A_6, ref A_7, ref A_36);
										A_36.r(A_0.w, a_3, A_0.d0(), A_0.d1(), collection2[0].b6(), collection2[0].b7());
									}
									a12 = null;
									if (!vk() || num14 != iu[1] || !ut() || !p9(h10, iu[0]) || !m2(h10, iu[0], A_0.n[iu[0]], A_0.aj, A_0.ak) || (flag4 && flag36))
									{
										continue;
									}
									collection = new Collection<float[]>();
									hr A_37 = new hr(null);
									int num29 = iq[iu[0]].Count - 1;
									for (int num30 = 0; num30 <= num29; num30++)
									{
										if (p9(h10, num30, num14))
										{
											float num33;
											if (iq[iu[1]].Count > num30)
											{
												ip obj4 = iq[iu[1]][num30];
												int A_38 = 0;
												float A_31 = 0f;
												obj4.m2(ref A_37, ref A_38, ref A_31, A_3: false, flag4, jk, s3(hc.b8()), st(hc.b8()), null, null, 0f, 0f, A_12: false, default(Guid));
												int num31 = A_37.c2() - 1;
												double[] array8 = A_37.c0();
												float[] array9 = new float[num31 + 1];
												A_38 = num31;
												for (int num32 = 0; num32 <= A_38; num32++)
												{
													num33 = (float)array8[num32];
													if (num33 < 0f)
													{
														num33 = 0f;
													}
													else if (num33 > 1f)
													{
														num33 = 1f;
													}
													array9[num32] = num33 * num33;
												}
												collection.Add(array9);
												continue;
											}
											if (i1.Count <= num30)
											{
												int num34 = iq[iu[0]][num30].vw() - 1;
												i1.Add(new int[num34 + 1]);
												i2.Add(new int[num34 + 1]);
												i3.Add(new double[num34 + 1]);
												i4.Add(new double[num34 + 1]);
												double[] array10 = i3[num30];
												int num35 = num34;
												for (int num36 = 0; num36 <= num35; num36++)
												{
													array10[num36] = 1.0;
												}
											}
											num33 = collection[0][collection[0].GetUpperBound(0)];
											collection.Add(new float[1] { num33 * num33 });
										}
										else
										{
											collection.Add(null);
										}
									}
								}
								int num37 = iu[2];
								if (m2(h10, 0, A_0.n[0], A_0.aj, A_0.ak))
								{
									A_2.w = hr2;
									if (upperBound > 0 && vk() && m2(h10, iu[1], A_0.n[iu[1]], A_0.aj, A_0.ak))
									{
										A_2.w.r(A_6);
									}
									if (upperBound > 0 && num37 >= 0 && m2(h10, num37, A_0.n[num37], A_0.aj, A_4: false))
									{
										A_2.w.r((fy)A_7);
									}
								}
								else if (num37 >= 0 && m2(h10, num37, A_0.n[num37], A_0.aj, A_4: false))
								{
									A_2.w = A_7;
									if (upperBound > 0 && vk() && m2(h10, iu[1], A_0.n[iu[1]], A_0.aj, A_0.ak))
									{
										A_2.w.r(A_6);
									}
								}
								else
								{
									A_2.w = A_6;
								}
								bool flag41 = m2(h10, upperBound, array2, A_0) && m2(h10, upperBound, array, A_0);
								h.a a13 = A_2;
								if (flag34 || (flag4 && ((m)A_0).a == m.a.f))
								{
									a13.x = false;
								}
								if ((!flag4 && flag41) || (flag4 && flag8))
								{
									if (!kz)
									{
										hf.Clear();
										i8.Clear();
									}
									kz = true;
								}
								if (flag11)
								{
									a13.x = true;
									a13.aa = A_9;
									if ((!flag10 && !flag13) || (flag13 && mu.Count == jj.m))
									{
										k1 = !flag36;
										kz = false;
									}
									A_0.d0(u1());
								}
								if (!flag4 && flag41 && flag34 && ((m)A_0).a == m.a.f)
								{
									a13.x = A_0.ac && !flag36 && k1;
									k1 = !flag36;
									jo = true;
									if (hf.Count > 500)
									{
										hf.Remove(1);
									}
									hf.Add(A_2.w);
								}
								if (!flag4 && m2(upperBound, array, A_0))
								{
									a13.x = false;
									if (kz && flag34 && hf.Count > 0)
									{
										int index2 = m2(hf);
										m2(A_2, A_0, i8[index2]);
										hr2 = a13.z.cn();
										A_6 = a13.z.cn().bl();
										A_0.d0(u1());
									}
									kz = false;
								}
								a13 = null;
								if (flag4)
								{
									int num38 = iq[0][0].wh();
									if (flag12)
									{
										le++;
										lh = (float)Math.Min((double)(100 * le) / (double)num38, 100.0);
										if (m2(h10, upperBound, li, A_0) && global::jf.a(lh, 100.0))
										{
											lf = true;
											lh = 0f;
											int upperBound2 = iq.GetUpperBound(0);
											for (int num39 = 0; num39 <= upperBound2; num39++)
											{
												int num40 = iq[num39].Count - 1;
												for (int num10 = 0; num10 <= num40; num10++)
												{
													li[num39] = false;
												}
											}
											A_0.d0(o.a);
										}
										else if (le > 3 * num38)
										{
											lg = true;
											A_0.d0(o.a);
										}
									}
									else
									{
										lh = 0f;
										lf = false;
										lg = false;
									}
									m2(A_0, lh, lf, lg);
								}
								if (flag23)
								{
									if (!l2.ab().p())
									{
										num41 += 1200f;
									}
									if (A_0.l == null && (!flag14 || num == A_0.ap))
									{
										num41 += 600f;
									}
									if (num41 <= 0f)
									{
										ab8().c(fz.b.b, "Invalid camera segment time: timeSegmentForCamera=" + num41 + ", VideoIsLive=" + Conversions.ToString(l2.ab().p()) + ", theTask.Terminator Is Nothing=" + (A_0.l == null) + ", taskIsABatchTask=" + Conversions.ToString(flag14) + ", batchAcqSpectrumIdx = theTask.AcquireNumSpectraM1" + (num == A_0.ap));
									}
									A_0.h.t(num6, DateAndTime.Now, num41);
									num6++;
								}
								flag20 = m2(A_2.w, flag19, flag4);
								if ((flag20 || A_0.ae) && l2 != null)
								{
									if ((!A_0.ae && !A_0.ao) || (A_0.ae && !l2.ak()))
									{
										l2.@as();
										A_0.ao = true;
									}
									l2.av();
									d4.a a14 = l2.ab();
									Bitmap bitmap = l2.aw();
									try
									{
										A_2.w.r(bitmap, a14.w(), a14.s(), a14.u(), a14.v(), a14.q(), ab8());
									}
									finally
									{
										bitmap?.Dispose();
									}
									a14 = null;
									if (A_0.l == null && !A_0.ae && (!flag14 || num == A_0.ap))
									{
										l2.at();
									}
								}
								A_2.w.an(string.Empty);
								A_2.w.r(0);
								if (flag14)
								{
									A_0.ah = 0;
									mu.Add(A_2);
									if (A_0.am != null)
									{
										foreach (ip item in iq[0])
										{
											if (item.m2(SpectromTempSensorLoc.kFMTSLocSpectrometer))
											{
												item.m2(SpectromTempSensorLoc.kFMTSLocSpectrometer, ref A_39);
												flag2 = true;
												break;
											}
										}
									}
								}
								else if (A_0.ah > 0 && A_0.l != null && (!flag4 || flag10))
								{
									A_0.ah = 0;
								}
								if (flag14)
								{
									A_0.t--;
								}
							}
							while (!flag13 && flag14 && (!flag14 || num != A_0.ap) && A_0.am == null);
						}
						else if (A_13 != null)
						{
							flag20 = m2(A_2.w, flag19, flag4);
						}
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2);
						Exception ex3 = ex2;
						if (flag4)
						{
							kz = false;
						}
						A_0.d0(o.a);
						ab8().c(fz.b.b, "Exception caught in TaskCoreSpectrometer().", ex3);
						((global::r.d.a)A_1).a = global::r.d.a.a.b;
						((global::r.d.a)A_1).b = ex3.Message;
						if (ex3 is ai)
						{
							A_1.j = global::r.g.a.a.t;
							((global::r.d.a)A_2).a = global::r.d.a.a.b;
							if (A_0.l != null && !flag4)
							{
								A_0.l.q(19, global::r.d.a.a.b, ex3.Message, 0f, 0f, A_5: true);
							}
						}
						ProjectData.ClearProjectError();
					}
					finally
					{
						try
						{
							k0 = flag7;
							if (flag9 || o2 == o.i || o2 == o.f || o2 == o.b)
							{
								A_0.d0(o.a);
							}
							if (((m)A_0).a == m.a.g)
							{
								int num42 = upperBound;
								for (int num43 = 0; num43 <= num42; num43++)
								{
									if (p9(h10, num43, A_0.n[num43], A_0.aj, A_0.ak))
									{
										switch (A_0.n[num43])
										{
										case n.d:
										case n.m:
										case n.n:
										{
											if (((global::r.d.a)A_2).a != global::r.d.a.a.a)
											{
												break;
											}
											bool flag42 = A_0.h != null && A_0.h.a;
											int num46 = iq[num43].Count - 1;
											for (int num47 = 0; num47 <= num46; num47++)
											{
												if (!p9(h10, num47, num43) || flag42)
												{
													continue;
												}
												ip ip6 = iq[num43][num47];
												if (ej2 == null)
												{
													if (flag15 && l2 != null)
													{
														A_0.h.t(num2, DateAndTime.Now, 5.5f);
														num2++;
													}
													ej2 = t0();
												}
												bool a_45 = (v6() && A_0.al && A_0.n[num43] == n.d) || A_0.n[num43] != n.d;
												if (!ip6.m2(jk, A_0.al, ej2, a_45, A_0.n[num43] == n.n, A_0.aw, A_10 != null, A_14))
												{
													ab8().c(fz.a.b, "BackSetSpectrumFmt2", ip6.abo(), ip6.yq());
													((global::r.d.a)A_2).a = global::r.d.a.a.b;
													break;
												}
												ip6 = null;
											}
											break;
										}
										case n.e:
										{
											if (((global::r.d.a)A_2).a != global::r.d.a.a.a)
											{
												break;
											}
											int num48 = iq[num43].Count - 1;
											for (int num49 = 0; num49 <= num48; num49++)
											{
												if (p9(h10, num49, num43))
												{
													ip ip7 = iq[num43][num49];
													if (flag4 && !ip7.m2(jk, A_1: true, A_2: false, A_3: false, A_4: true, A_0.aw))
													{
														ab8().c(fz.a.b, "ErrAutoRefFileFmt2", ip7.uq(), ip7.yq());
														((global::r.d.a)A_2).a = global::r.d.a.a.b;
														break;
													}
													if (!ip7.m2(jk, A_0.aw, A_10 != null, A_14))
													{
														ab8().c(fz.a.b, "BackSetSpectrumFmt2", ip7.abo(), ip7.yq());
														((global::r.d.a)A_2).a = global::r.d.a.a.b;
														break;
													}
													if (flag4 && flag21 && !ip7.m2(jk, A_0.al, ej2, A_3: true, A_0.n[num43] == n.n, A_0.aw, A_10 != null, A_14))
													{
														ab8().c(fz.a.b, "BackSetSpectrumFmt2", ip7.abo(), ip7.yq());
														((global::r.d.a)A_2).a = global::r.d.a.a.b;
														break;
													}
													ip7 = null;
												}
											}
											break;
										}
										case n.f:
										{
											if (((global::r.d.a)A_2).a != global::r.d.a.a.a || A_0.n[num43] != n.f)
											{
												break;
											}
											int num50 = iq[num43].Count - 1;
											for (int num51 = 0; num51 <= num50; num51++)
											{
												if (!p9(h10, num51, num43))
												{
													continue;
												}
												ip ip8 = iq[num43][num51];
												if (ej2 == null)
												{
													if (flag15 && l2 != null)
													{
														A_0.h.t(num2, DateAndTime.Now, 5.5f);
														num2++;
													}
													ej2 = t0();
												}
												if (!ip8.m2(ej2, A_10 != null, A_14))
												{
													ab8().c(fz.a.b, "Sample", ip8.abo(), ip8.yq());
													((global::r.d.a)A_2).a = global::r.d.a.a.b;
													break;
												}
												ip8 = null;
											}
											break;
										}
										case n.h:
										{
											if (((global::r.d.a)A_2).a != global::r.d.a.a.a)
											{
												break;
											}
											int num44 = iq[num43].Count - 1;
											for (int num45 = 0; num45 <= num44; num45++)
											{
												if (p9(h10, num45, num43))
												{
													ip ip5 = iq[num43][num45];
													if (!ip5.m2(jk, A_1: false, A_2: false, A_3: true, A_4: true, A_5: false))
													{
														ab8().c(fz.a.b, "ErrAutoRefFileFmt2", ip5.uq(), ip5.yq());
														((global::r.d.a)A_2).a = global::r.d.a.a.b;
														break;
													}
													ip5 = null;
												}
											}
											break;
										}
										}
									}
									if (global::r.p9(A_0.n[num43]))
									{
										m2(array4[num43], array5[num43], num43, A_3: false);
									}
								}
							}
							if (((global::r.d.a)A_2).a != global::r.d.a.a.a && flag14)
							{
								jj.a = true;
							}
							bool flag43 = !string.IsNullOrEmpty(A_0.aq);
							string text = null;
							string text2 = null;
							string text3 = null;
							int num53;
							int num54;
							unchecked
							{
								if (flag43)
								{
									text = Path.GetDirectoryName(A_0.aq) + "\\" + Path.GetFileNameWithoutExtension(A_0.aq) + "_";
									if (A_0.u > 0)
									{
										text = text + "Ch" + A_0.u + "_";
									}
									text2 = Path.GetExtension(A_0.aq);
									text3 = "0";
									for (int num52 = checked(A_0.ap + 1) / 10; num52 > 0; num52 /= 10)
									{
										text3 += "0";
									}
									if (!flag14 || A_0.am == null || A_0.t == A_0.ap)
									{
										Collection<string> collection3 = global::i3.j(A_0.aq);
										string directoryName = Path.GetDirectoryName(A_0.aq);
										foreach (string item2 in collection3)
										{
											File.Delete(directoryName + "\\" + item2);
										}
										if (File.Exists(text + "Temperature.txt"))
										{
											File.Delete(text + "Temperature.txt");
										}
										if (flag2)
										{
											File.WriteAllText(text + "Temperature.txt", "\"Spectrum #\", \"Temperature (C)\"\r\n");
										}
									}
								}
								num53 = 0;
								num54 = 0;
							}
							do
							{
								if (flag14)
								{
									if ((flag13 && A_0.am == null && mu.Count < jj.m) || jj.a)
									{
										break;
									}
									if (((global::r.d.a)A_2).a == global::r.d.a.a.a)
									{
										num54 = ((!flag14 || A_0.am == null) ? num53 : (A_0.ap - A_0.t));
										jj.t(num54 + 1);
										A_2 = mu[num53];
									}
								}
								if (A_0.au)
								{
									A_2.w = m2(A_2.w, hc, A_2: true, 7, A_0.d3(), A_0.az);
								}
								else
								{
									A_2.w = m2(A_2.w, hc, A_2: true, A_0.d3(), A_0.az);
								}
								if (flag43 && flag14)
								{
									string A_40 = null;
									Collection<string> A_41 = null;
									Collection<string> A_42 = null;
									string A_43 = text + (num54 + 1).ToString(text3) + text2;
									hr hr3 = A_2.w;
									hr3.r(ref A_40, ref A_41, ref A_42);
									hr3.r(ref A_43, hr3.bz(), hr3.by(), A_40, A_41, A_42, A_0.ar, A_0.@as, A_0.at);
									hr3.ak(Path.GetFileNameWithoutExtension(A_43));
									hr3 = null;
									if (flag2)
									{
										File.AppendAllText(text + "Temperature.txt", num54 + 1 + ", " + A_39.ToString("0.00") + "\r\n");
									}
								}
								if (flag20)
								{
									j7 = true;
									j8 = A_0.d3();
									j9 = hc.cl();
								}
								else if (!flag14 || num54 == A_0.ap || ((global::r.d.a)A_2).a != global::r.d.a.a.a)
								{
									A_0.i = true;
									if (A_0.am != null && !flag4 && !A_0.l.q())
									{
										A_0.l.q(A_0: true);
									}
								}
								hr hr4 = A_2.w;
								if ((hr4.cr() || (hr4.bl() != null && hr4.bl().cr()) || (hr4.bm() != null && hr4.bm().Count > 0 && hr4.bm()[0].cr())) && flag17 && ((!flag35 && !flag) || h10.n(v6()) == global::h.MeasurementTimingType.Manual))
								{
									if (h10.n(v6()) == global::h.MeasurementTimingType.Manual)
									{
										A_1.j = global::r.g.a.a.j;
									}
									else if (A_0.z != null && A_0.z[0])
									{
										A_1.j = global::r.g.a.a.k;
									}
									else
									{
										A_1.j = global::r.g.a.a.q;
									}
									bool a_46 = false;
									m2(A_1, A_0.d3(), a_26, a_25, a_46);
									((global::r.d.a)A_2).a = global::r.d.a.a.b;
									((global::r.d.a)A_1).a = global::r.d.a.a.b;
									if (A_0.l != null && !flag4)
									{
										A_0.l.q(unchecked((int)A_1.j), global::r.d.a.a.b, "", A_1.k, A_1.l, A_1.p, A_1.q, A_1.r, A_1.s, A_9: true);
									}
									A_2.x = true;
								}
								else if (A_1.j == global::r.g.a.a.b)
								{
									((global::r.d.a)A_2).a = global::r.d.a.a.b;
									((global::r.d.a)A_1).a = global::r.d.a.a.b;
									flag20 = false;
									j7 = false;
									if (!flag14 || num54 == A_0.ap)
									{
										A_0.i = true;
										if (A_0.am != null && !flag4)
										{
											A_0.l.q(A_0: true);
										}
									}
									A_2.x = false;
								}
								hr4 = null;
								bool A_44 = false;
								if (A_0.l == null || (flag20 && flag4 && !flag10))
								{
									i9.d(gt, A_2);
									A_44 = true;
								}
								if (flag20)
								{
									if (((global::r.d.a)A_1).a == global::r.d.a.a.a || A_0.d3() == global::r.d.a.b.b || A_0.af)
									{
										m2(A_0, A_1, !flag14 && A_10 == null, A_2, A_4: false, A_10, ref A_11, ref A_45, ref A_12, ref A_44);
										flag18 = true;
										if (A_0.af)
										{
											long a_47 = ((la != null) ? la.h : (-1));
											if (la == null || A_0.ag)
											{
												la = new cd(ab8(), hg.cy(), a_47, m2(A_2.w.cu().q() == null, (eo.a)null), hk.h(), hk.i(), v1(), so(hc));
											}
											la.f(hg, A_1);
										}
										if (!flag14 || flag13 || num54 == A_0.ap)
										{
											A_0.i = true;
											j7 = false;
										}
									}
									else
									{
										A_0.i = true;
										j7 = false;
									}
								}
								else if (((global::r.d.a)A_2).a == global::r.d.a.a.a && h10.av() && A_0.az)
								{
									List<float> list = new List<float>();
									int num55 = A_2.w.c2() - 1;
									if (l6.r() != null)
									{
										if (!flag44)
										{
											a_48 = A_2.w.cb();
											flag44 = true;
										}
										int num56 = l6.r().Count - 1;
										for (int num57 = 0; num57 <= num56; num57++)
										{
											float num58 = l6.r()[num57];
											hr hr5;
											for (hr5 = A_2.w; !(hr5.cz()[num59] >= (double)num58) && num59 <= num55; num59++)
											{
											}
											double num60;
											if (num59 - 1 < 0)
											{
												num60 = hr5.c0()[0];
											}
											else if (num59 + 1 > num55)
											{
												num60 = hr5.c0()[num55];
											}
											else if (global::jf.e(hr5.cz()[num59], num58))
											{
												num60 = hr5.c0()[num59];
											}
											else
											{
												float num61 = (float)(((double)num58 - hr5.cz()[num59]) / (hr5.cz()[num59 + 1] - hr5.cz()[num59]));
												num60 = hr5.c0()[num59] * (double)(1f - num61) + hr5.c0()[num59] * (double)num61;
											}
											list.Add((float)num60);
											hr5 = null;
										}
										l6.l(a_48, list, A_0.d3());
										((global::r.d.a)A_1).a = global::r.d.a.a.a;
									}
								}
								if (!A_44 && A_2.w.cz().Length > 1 && A_2.x)
								{
									i9.d(gt, A_2);
								}
								if (!flag4 || ((m)A_0).a == m.a.g || flag9 || flag10 || flag11)
								{
									jg.d(gt, a_2);
								}
								A_0.ah = 0;
								num53++;
							}
							while (flag14 && A_0.am == null && num54 != A_0.ap);
						}
						catch (Exception ex4)
						{
							ProjectData.SetProjectError(ex4);
							Exception a_49 = ex4;
							A_0.i = true;
							j7 = false;
							ab8().c(fz.b.b, "Exception caught in MeasModuleSpec.TaskCoreSpectrometer() Finally Block.", a_49);
							((global::r.d.a)A_1).a = global::r.d.a.a.b;
							ProjectData.ClearProjectError();
						}
						finally
						{
							if (flag14)
							{
								if (A_0.am != null || A_0.t == 0 || jj.a)
								{
									mu.Clear();
									j7 = false;
								}
								if (A_0.l != null && !flag4 && (A_0.t == 0 || jj.a))
								{
									A_0.l.q(A_0: true);
								}
								if (A_0.t == 0 || jj.a)
								{
									flag45 = true;
									A_0.d0(o.a);
									A_0.aq = null;
									kz = false;
									if (jj.a)
									{
										if (wq())
										{
											l2.at();
										}
										jj.a = false;
										A_0.i = true;
										((global::r.d.a)A_1).a = global::r.d.a.a.b;
										if (string.IsNullOrEmpty(((global::r.d.a)A_1).b))
										{
											((global::r.d.a)A_1).b = "Batch Process aborted";
										}
										jg.d(gt, a_2);
									}
									jj.z();
								}
							}
							if (A_0.g != null && (A_10 == null || ((global::r.d.a)A_1).a != global::r.d.a.a.a))
							{
								A_0.g.d(gt, A_1);
							}
							if (flag45)
							{
								lock (A_0)
								{
									A_0.g = new global::r.d();
								}
							}
						}
					}
					hg a_50 = A_10;
					global::r.d.a.b a_51 = A_0.d3();
					bool a_52 = flag18;
					bool A_46 = false;
					m2(a_50, null, a_51, a_53, a_52, ref A_13, ref A_14, ref A_15, ref A_46);
					if (A_13 != null && !A_15)
					{
						qh(A_0: false, A_1: false);
						sm(A_0: false);
					}
				}
				while (A_13 != null);
			}
			finally
			{
				if (il != null && A_0.l == null)
				{
					sj(A_0: false);
				}
				m2(A_10, A_16, A_11, A_45, A_12, A_5: false, A_6: false, A_0.d3(), A_1);
				if (A_10 != null)
				{
					qh(A_0: false, A_1: false);
					sm(A_0: false);
					A_0.g.d(gt, A_1);
				}
			}
		}
	}

	private bool m2(hr A_0, bool A_1, bool A_2)
	{
		if (A_0.cj() != hr.b.b && A_0.cj() != hr.b.o && A_0.cj() != hr.b.k && A_0.cj() != hr.b.a && !A_1 && !zi() && (A_0.cu().q() == null || hc.ed().au(null, A_1: true)))
		{
			if (A_2)
			{
				return k0;
			}
			return true;
		}
		return false;
	}

	private void t5()
	{
		double[] array = new double[10];
		double[] array2 = new double[10];
		DateTime now = DateTime.Now;
		if (!(now.Subtract(lk).TotalSeconds > (double)lt))
		{
			return;
		}
		iq[0][0].abk().LsTemperature(out ll);
		lk = now;
		checked
		{
			if (lp < 10)
			{
				ln[lp] = ll;
				lo[lp] = now;
				lp++;
				return;
			}
			int num = 0;
			do
			{
				ln[num] = ln[num + 1];
				lo[num] = lo[num + 1];
				array2[num] = ln[num];
				array[num] = lo[num].Subtract(lo[0]).TotalSeconds;
				num++;
			}
			while (num <= 8);
			ln[9] = ll;
			lo[9] = now;
			array2[9] = ll;
			array[9] = now.Subtract(lo[0]).TotalSeconds;
			double A_ = default(double);
			double A_2 = default(double);
			global::jf.a(array, array2, 10, ref A_, ref A_2);
			float num2 = (float)Math.Abs(A_2);
			if (global::jf.b(num2, 0f))
			{
				if (num2 < 0.1f)
				{
					lt = Math.Min(0.1f / num2, 5f);
				}
				else
				{
					lt = 1f;
				}
			}
			else
			{
				lt = 5f;
			}
		}
	}

	private ej t0()
	{
		if (l2 == null)
		{
			return null;
		}
		if (!l2.ak())
		{
			l2.@as();
		}
		l2.av();
		d4.a a10 = l2.ab();
		ej ej2 = new ej();
		Bitmap bitmap = l2.aw();
		try
		{
			ej2.a(bitmap, a10.w(), a10.s(), a10.u(), a10.v(), a10.q(), ab8());
		}
		finally
		{
			bitmap?.Dispose();
		}
		l2.at();
		return ej2;
	}

	private void m2(g.a A_0, global::r.d.a.b A_1, int A_2, int A_3, bool A_4)
	{
		A_0.k = A_2;
		A_0.l = A_3;
		A_0.r = ix[A_3];
		A_0.p = A_2 == sj(A_3);
		A_0.q = iq[A_3].Count > 1;
		A_0.s = vk();
		A_0.u = A_4;
		_ = null;
	}

	private void m2(r A_0)
	{
		global::r.d.a A_1 = null;
		m2(A_0, ref A_1);
	}

	private void m2(r A_0, ref global::r.d.a A_1)
	{
		long a_ = default(long);
		if (A_0.g != null)
		{
			a_ = A_0.g.d();
		}
		A_1 = new global::r.d.a(A_0.d3(), a_);
		global::r.d.a a10 = new global::r.d.a(A_0.d3(), a_);
		new global::r.d();
		int num = 0;
		h.a a11 = new h.a(A_0.d3(), a_, null);
		new Collection<hr>();
		string A_2 = "";
		A_1.a = global::r.d.a.a.b;
		checked
		{
			bool flag5 = default(bool);
			try
			{
				kd = false;
				j7 = true;
				j8 = A_0.d3();
				j9 = hc.cl();
				a10.a = global::r.d.a.a.a;
				A_0.g.e(gt, a10);
				if (A_0.d3() == global::r.d.a.b.b)
				{
					jg.d(gt, new global::r.d.a(A_0.d3(), a_));
				}
				switch (((m)A_0).a)
				{
				case m.a.w:
					try
					{
						A_0.bm.r(u1());
						a11.w = m2(A_0.bm, 0, A_2: true, A_0.d3(), A_4: false);
						((global::r.d.a)a11).a = global::r.d.a.a.a;
						a11.h = gt;
						a11.x = true;
						i9.d(gt, a11);
						A_1.a = global::r.d.a.a.a;
						break;
					}
					catch (Exception ex8)
					{
						ProjectData.SetProjectError(ex8);
						Exception a_29 = ex8;
						ab8().c(fz.b.b, "Exception Thrown in TaskCoreMeasEngine around AnalyzeSpectrum()", a_29);
						ProjectData.ClearProjectError();
						break;
					}
				case m.a.h:
				{
					hg A_17 = null;
					hc A_18 = null;
					string A_19 = null;
					bool A_22 = default(bool);
					ErrPublic A_23 = default(ErrPublic);
					try
					{
						hj A_20 = null;
						int A_21 = 0;
						eo.a a_18 = null;
						m2(ref A_17, a_18, ref A_22, ref A_0.bj);
						if (A_0.bm == null)
						{
							double[] array40 = new double[2015 + 1];
							int num58 = 2015;
							for (int num59 = 0; num59 <= num58; num59++)
							{
								array40[num59] = 185f + (float)num59 * 1f;
							}
							double[] array41 = new double[350 + 1];
							int num60 = 350;
							for (int num61 = 0; num61 <= num60; num61++)
							{
								array41[num61] = 450f + (float)num61 * 1f;
							}
							hi hi2 = hc.ed();
							ErrPublic errPublic2 = m2(A_6: (iv != null && iv[2]) ? iw[iu[2]] : 70f, A_0: A_0, A_1: array40, A_2: hc.c2(), A_3: hi2.eq(0), A_4: hi2.ep(0), A_5: hi2.eq(1), A_7: array41);
							A_0.bm.r(u1());
						}
						a11.h = gt;
						a11.w = A_0.bm;
						((global::r.d.a)a11).a = global::r.d.a.a.a;
						a11.aa = A_0.bj;
						bool flag4 = default(bool);
						bool a_28 = default(bool);
						do
						{
							a11.w = m2(a11.w, hc, A_2: false, A_0.d3(), A_4: false);
							r r4 = A_0;
							bool A_16;
							if (hr.r(a11.w.cj(), a11.w.cu().q() != null))
							{
								ErrPublic errPublic2 = m2(a11.w, zj(), ref hg, r4.bj, r4.d3(), A_5: true, r4.br, ref A_2);
								m2(A_17, errPublic2, A_2, ref A_18, ref A_23, ref A_19);
								flag4 = true;
								ErrPublic a_19 = errPublic2;
								global::r.d.a.b a_20 = A_0.d3();
								bool a_21 = A_0.bk;
								bool a_22 = A_0.bl;
								global::r.d.a a_23 = A_1;
								string a_24 = A_2;
								A_16 = false;
								m2(a_19, a_20, a_21, a_22, a_23, a_24, ref A_16, A_7: false);
							}
							else
							{
								A_1.a = global::r.d.a.a.a;
							}
							r4 = null;
							hg a_25 = A_17;
							global::r.d.a.b a_26 = A_0.d3();
							bool a_27 = flag4;
							A_16 = false;
							bool A_24 = false;
							m2(a_25, a_18, a_26, a_28, a_27, ref A_20, ref A_21, ref A_16, ref A_24);
						}
						while (A_20 != null);
						break;
					}
					finally
					{
						r r5 = A_0;
						m2(A_17, A_22, A_18, A_23, A_19, r5.bk, r5.bl, r5.d3(), A_1);
						r5 = null;
					}
				}
				case m.a.aa:
				{
					bool flag9 = true;
					try
					{
						a11.h = gt;
						((global::r.d.a)a11).a = global::r.d.a.a.a;
						a11.aa = A_0.bj;
						jg.d(gt, new global::r.d.a(A_0.d3(), 0L));
						r r8 = A_0;
						int num70 = r8.bn.Count - 1;
						for (int num71 = 0; num71 <= num70; num71++)
						{
							if (!hr.r(r8.bn[num71].cj(), r8.bn[num71].cu().q() != null))
							{
								flag9 = false;
								break;
							}
						}
						if (flag9)
						{
							ErrPublic a_40 = m2(r8.bn, zj(), r8.bj, r8.d3(), A_4: true, r8.br, ref A_2, ref hh);
							global::r.d.a.b a_41 = A_0.d3();
							global::r.d.a a_42 = A_1;
							string a_43 = A_2;
							bool A_24 = false;
							m2(a_40, a_41, a_42, a_43, ref A_24);
						}
						else
						{
							A_1.a = global::r.d.a.a.a;
						}
						r8 = null;
						break;
					}
					catch (Exception ex10)
					{
						ProjectData.SetProjectError(ex10);
						Exception a_44 = ex10;
						ab8().c(fz.b.b, "Exception Thrown in TaskCoreMeasEngine around AnalyzeSpectrum()", a_44);
						ProjectData.ClearProjectError();
						break;
					}
				}
				case m.a.i:
				{
					List<double[]> list = null;
					hg A_25 = null;
					hc A_26 = null;
					string A_27 = null;
					flag5 = true;
					try
					{
						int num62 = A_0.bo.Length - 1;
						jj.m = num62 + 1;
						int num63 = num62;
						bool A_31 = default(bool);
						ErrPublic A_32 = default(ErrPublic);
						bool flag7 = default(bool);
						bool flag8 = default(bool);
						bool a_38 = default(bool);
						for (int num64 = 0; num64 <= num63; num64++)
						{
							try
							{
								hj A_28 = null;
								bool flag6 = false;
								int A_29 = 0;
								eo.a a_30 = null;
								jj.t(num64 + 1);
								string A_30 = A_0.bo[num64];
								a11 = new h.a(A_0.d3(), a_, null);
								((global::r.d.a)a11).a = global::r.d.a.a.a;
								a11.h = gt;
								A_25 = null;
								a11.aa = A_0.bj;
								eo eo2 = hc.dh();
								a11.w = hr.r(A_30, hj != null, eo2.a8(), eo2.bh(), A_0.bp);
								eo2 = null;
								a11.w.r(A_0.bt);
								a11.w.ag(ref A_30, null);
								a11.w.r(u1());
								m2(ref A_25, a_30, ref A_31, ref A_0.bj);
								do
								{
									a11.w = m2(a11.w, hc, A_2: false, A_0.d3(), A_4: false);
									bool A_24;
									if (a11.w.ag())
									{
										r r6 = A_0;
										ErrPublic errPublic3 = m2(a11.w, zj(), ref hg, r6.bj, r6.d3(), A_5: true, r6.br, ref A_2);
										r6 = null;
										flag6 = true;
										m2(A_25, errPublic3, A_2, ref A_26, ref A_32, ref A_27);
										global::r.d.a.b a_31 = A_0.d3();
										bool a_32 = A_0.bk;
										global::r.d.a a_33 = A_1;
										string a_34 = A_2;
										A_24 = false;
										m2(errPublic3, a_31, a_32, A_3: false, a_33, a_34, ref A_24, A_7: false);
										if (errPublic3 != ErrPublic.None)
										{
											ref string reference2 = ref A_1.b;
											reference2 = reference2 + "\r\nFile: " + Path.GetFileName(A_30);
											A_1.a = global::r.d.a.a.b;
											return;
										}
									}
									else
									{
										if (!flag7)
										{
											string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(A_30);
											int num65 = fileNameWithoutExtension2.LastIndexOf("_");
											if (num65 > 0 && num65 < fileNameWithoutExtension2.Length - 1)
											{
												string text = fileNameWithoutExtension2.Substring(num65 + 1);
												int result = 0;
												if (int.TryParse(text, out result))
												{
													fileNameWithoutExtension2 = fileNameWithoutExtension2.Substring(0, num65 + 1);
													flag8 = true;
													result = num62;
													int num66 = 0;
													while (num66 <= result)
													{
														string fileNameWithoutExtension3 = Path.GetFileNameWithoutExtension(A_0.bo[num66]);
														num65 = fileNameWithoutExtension3.LastIndexOf("_");
														if (num65 > 0 && num65 != fileNameWithoutExtension3.Length - 1)
														{
															string text2 = fileNameWithoutExtension3.Substring(num65 + 1);
															int result2 = 0;
															if (int.TryParse(text2, out result2))
															{
																num66++;
																continue;
															}
														}
														flag8 = false;
														break;
													}
												}
											}
											if (flag8)
											{
												list = new List<double[]>();
											}
											flag7 = true;
										}
										if (flag8)
										{
											list.Add(a11.w.c0());
											if (num64 == num62)
											{
												int result2 = a11.w.c2() - 1;
												for (int num67 = 0; num67 <= result2; num67++)
												{
													jj.t(num67 + 1);
													int num65 = A_30.LastIndexOf("_");
													StreamWriter streamWriter = new StreamWriter(A_30.Substring(0, num65 + 1) + a11.w.cz()[num67].ToString("0.0") + ".csv");
													int num68 = num62;
													for (int num69 = 0; num69 <= num68; num69++)
													{
														streamWriter.Write(num69 + 1 + ", " + list[num69][num67].ToString("0.0000") + "\r\n");
													}
													streamWriter.Close();
												}
											}
										}
										h.a obj4 = a11;
										obj4.x = true;
										obj4.h = gt;
										_ = null;
										i9.d(gt, a11);
										jg.d(gt, new global::r.d.a(A_0.d3(), 0L));
										A_1.a = global::r.d.a.a.a;
									}
									if (jj.a)
									{
										return;
									}
									hg a_35 = A_25;
									global::r.d.a.b a_36 = A_0.d3();
									bool a_37 = flag6;
									A_24 = false;
									bool A_16 = false;
									m2(a_35, a_30, a_36, a_38, a_37, ref A_28, ref A_29, ref A_24, ref A_16);
								}
								while (A_28 != null);
							}
							finally
							{
								r r7 = A_0;
								m2(A_25, A_31, A_26, A_32, A_27, r7.bk, r7.bl, r7.d3(), A_1);
								r7 = null;
							}
						}
						break;
					}
					catch (Exception ex9)
					{
						ProjectData.SetProjectError(ex9);
						Exception a_39 = ex9;
						ab8().c(fz.b.b, "Exception Thrown in TaskCoreMeasEngine around AnalyzeSpectrumBatch()", a_39);
						ProjectData.ClearProjectError();
						break;
					}
				}
				case m.a.r:
				{
					eo.a a12 = null;
					hg obj = hc;
					eo.a a_2 = a12;
					int A_3 = 0;
					if (obj.bu(A_0: false, a_2, ref A_3) != null)
					{
						throw new ax("Additional Recipes not allowed during precision computation");
					}
					int num2 = default(int);
					float num24 = default(float);
					bool flag3 = default(bool);
					long a_8 = default(long);
					try
					{
						hr A_4 = null;
						bool flag = false;
						bool flag2 = false;
						float[] A_5 = null;
						kc = true;
						ho ho2 = A_0.bq;
						bool A_7 = default(bool);
						if (ho2.u)
						{
							if (A_0.bm == null || A_0.bm.br() == null)
							{
								string A_6 = "ComputePrecisionNoValidSpectrum";
								throw new ApplicationException(hu.a(ref A_6));
							}
						}
						else
						{
							hr.r(ho2.l, ref A_4, ref A_7);
							if (A_4 == null)
							{
								throw new ApplicationException("Raw Intensity File is missing or is not selected");
							}
							if (A_0.bm == null)
							{
								u1();
								ErrPublic errPublic = m2(A_0, A_4.cz(), hc.c2(), A_3: true, A_4: false, A_5: false, 0f, null);
							}
						}
						ho2 = null;
						num2 = A_0.bm.c2();
						double[] array = (double[])A_0.bm.cv().Clone();
						double[] A_8 = (double[])A_0.bm.cz().Clone();
						hr hr2 = new hr(A_0.bm.bq());
						_ = (double[])A_0.bm.c0().Clone();
						double[] array2 = new double[num2 - 1 + 1];
						double[] array3 = new double[num2 - 1 + 1];
						double[] A_9 = new double[num2 - 1 + 1];
						double[] A_10 = new double[num2 - 1 + 1];
						double[] A_11 = new double[num2 - 1 + 1];
						_ = new double[num2 - 1 + 1];
						double[] array4 = new double[num2 - 1 + 1];
						double[] array5 = new double[num2 - 1 + 1];
						ke = new Collection<float[]>();
						kf = new Collection<float[]>();
						kg = new Collection<float[]>();
						kh = new Collection<float[]>();
						ki = new Collection<float[]>();
						kj = new Collection<float[]>();
						kk = new Collection<float[]>();
						kl = new Collection<float[]>();
						km = new Collection<float>();
						kn = new Collection<float[]>();
						ko = new Collection<float[]>();
						kp = new Collection<float[]>();
						kq = new Collection<float[]>();
						kr = new Collection<float[]>();
						ks = new Collection<float[]>();
						kt = new Collection<float[]>();
						ku = new Collection<float[]>();
						kv = new Collection<float>();
						Collection<hp> collection = A_0.bm.br();
						int num3 = default(int);
						float num4 = default(float);
						int num5;
						int num6;
						float num7;
						if (A_0.bq.u)
						{
							flag = true;
							if (collection.Count > 1)
							{
								flag2 = true;
								short a_3 = collection[0].q().h()[0];
								short a_4 = collection[0].q().h()[collection[0].q().h().Length - 1];
								short a_5 = collection[1].q().h()[0];
								short a_6 = collection[1].q().h()[collection[1].q().h().Length - 1];
								m2(A_0: true, a_3, a_4, a_5, a_6, A_8, ref A_5);
								m2(collection[0].q().h(), collection[0].q().f(), collection[0].q().h().Length, ref A_8, ref A_9, num2);
								m2(collection[1].q().h(), collection[1].q().f(), collection[1].q().h().Length, ref A_8, ref A_10, num2);
								num3 = collection[1].s();
								num4 = collection[1].x();
							}
							else
							{
								if (collection.Count <= 0)
								{
									string A_6 = "ComputePrecisionNoValidSpectrum";
									throw new ApplicationException(hu.a(ref A_6));
								}
								short a_3 = collection[0].q().h()[0];
								short a_4 = collection[0].q().h()[collection[0].q().h().Length - 1];
								short a_5 = short.MaxValue;
								short a_6 = short.MaxValue;
								m2(A_0: false, a_3, a_4, a_5, a_6, A_8, ref A_5);
								m2(collection[0].q().h(), collection[0].q().f(), collection[0].q().h().Length, ref A_8, ref A_9, num2);
							}
							num5 = collection[0].r();
							num6 = collection[0].s();
							num7 = collection[0].x();
						}
						else
						{
							short a_3 = (short)Math.Round(Math.Floor(A_8[0]));
							short a_4 = (short)Math.Round(Math.Ceiling(A_8[num2 - 1]));
							short a_5 = short.MaxValue;
							short a_6 = short.MaxValue;
							m2(A_0: false, a_3, a_4, a_5, a_6, A_8, ref A_5);
							if (Operators.CompareString(A_0.bq.l, "", TextCompare: false) != 0)
							{
								hr obj2 = A_4;
								double[] A_12 = obj2.cz();
								hr hr3;
								double[] A_13 = (hr3 = A_4).c0();
								global::jf.a(ref A_12, ref A_13, A_4.c2(), ref A_8, ref A_9, num2);
								hr3.af(A_13);
								obj2.t(A_12);
							}
							ho ho3 = A_0.bq;
							num5 = ho3.g;
							num6 = ((!ho3.t || !A_7) ? ho3.h : A_4.br()[0].s());
							num7 = ho3.r;
							ho3 = null;
						}
						collection = null;
						ho ho4 = A_0.bq;
						int num8 = hc.ed().hi();
						if (!flag)
						{
							ex obj3 = new ex();
							string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(ho4.l);
							int num9 = fileNameWithoutExtension.IndexOf("_");
							if (num9 <= 0)
							{
								throw new ApplicationException("Raw Intensity File name is missing material name.");
							}
							string a_7 = fileNameWithoutExtension.Substring(0, num9);
							obj3.e(a_7, ex.a.a, 0f, A_3: false, A_4: false);
							obj3.e(A_8, num2, ref A_11);
						}
						double num10;
						double num11;
						double num12;
						double num13;
						double num14 = default(double);
						double num15 = default(double);
						double num16 = default(double);
						if (flag)
						{
							hp hp2 = A_0.bm.br()[0];
							num10 = (double)hp2.t() / (double)hp2.u();
							num11 = 0.5 * (double)hp2.w() / 3.0;
							ho ho5 = A_0.bq;
							num12 = ((!ho5.v) ? (0.5 * (double)(A_0.bm.bt() / 100f) / 3.0) : (0.5 * (double)(ho5.w / 100f) / 3.0));
							ho5 = null;
							num13 = 0.5 * (double)hp2.v() / 3.0;
							hp2 = null;
							if (flag2)
							{
								hp hp3 = A_0.bm.br()[1];
								num14 = (double)hp3.t() / (double)hp3.u();
								num15 = 0.5 * (double)hp3.w() / 3.0;
								num16 = 0.5 * (double)hp3.v() / 3.0;
								hp3 = null;
							}
						}
						else
						{
							num10 = (double)ho4.j / (double)ho4.k;
							num11 = 0.5 * (double)ho4.o / 3.0;
							num12 = 0.5 * (double)(ho4.p / 100f) / 3.0;
							num13 = 0.5 * (double)ho4.n / 3.0;
						}
						if (flag)
						{
							A_3 = num2 - 1;
							for (num = 0; num <= A_3; num++)
							{
								if (A_9[num] > 0.0)
								{
									array2[num] = array[num] / A_9[num];
									array4[num] = A_9[num] * num10;
								}
								else
								{
									array2[num] = array[num];
									array4[num] = 0.0;
								}
							}
							if (flag2)
							{
								int num17 = num2 - 1;
								for (num = 0; num <= num17; num++)
								{
									if (A_10[num] > 0.0)
									{
										array3[num] = array[num] / A_10[num];
										array5[num] = A_10[num] / num14;
									}
									else
									{
										array3[num] = array[num];
										array5[num] = 0.0;
									}
								}
							}
						}
						else if (Operators.CompareString(ho4.l, "", TextCompare: false) != 0)
						{
							double num18 = 0.0;
							int num19 = num2 - 1;
							for (num = 0; num <= num19; num++)
							{
								if (A_9[num] > num18)
								{
									num18 = A_9[num];
								}
							}
							if ((num18 < 5.0) & (num18 != 1.0))
							{
								throw new ApplicationException("Bad Raw Intensity Data");
							}
							double num20 = ho4.m / num18;
							num18 = ho4.m;
							int num21 = num2 - 1;
							for (num = 0; num <= num21; num++)
							{
								A_9[num] *= num20;
								if (A_9[num] > 0.0)
								{
									array2[num] = A_11[num] / A_9[num];
									double num22 = array[num] / array2[num];
									if (num22 < 0.0)
									{
										num22 = 0.0;
									}
									array4[num] = num22 / num10;
								}
								else
								{
									array2[num] = A_11[num];
									array4[num] = 0.0;
								}
							}
						}
						else
						{
							unchecked
							{
								_ = num2 / 2;
							}
							int num23 = num2 - 1;
							for (num = 0; num <= num23; num++)
							{
								array2[num] = 1.0 / (double)ho4.j;
							}
						}
						num24 = ((num2 <= 1) ? 2E-09f : ((float)((A_8[1] - A_8[0]) * 9.999999717180685E-10)));
						if (hi.m2(hc, ha, A_0.bm.cw(), ref A_2, A_4: false, a12) != b9.ErrPublic.None)
						{
							throw new ApplicationException("Error in TaskCoreMeasEngine call to CalcSetUpLayers");
						}
						hi.m2(ho4.i * 1E-09f, num2, 0);
						flag3 = true;
						ho4 = null;
						Random random = new Random();
						double[] array6 = new double[num8 - 1 + 1];
						double[] array7 = new double[num8 - 1 + 1];
						double[] array8 = new double[num8 - 1 + 1];
						double[] array9 = new double[num8 - 1 + 1];
						double[] array10 = new double[num8 - 1 + 1];
						double[] array11 = new double[num8 - 1 + 1];
						double[] array12 = new double[num8 - 1 + 1];
						double[] array13 = new double[num8 - 1 + 1];
						double[] array14 = new double[num8 - 1 + 1];
						double[] array15 = new double[num8 - 1 + 1];
						double[] array16 = new double[num8 - 1 + 1];
						double[] array17 = new double[num8 - 1 + 1];
						double[] array18 = new double[num8 - 1 + 1];
						double[] array19 = new double[num8 - 1 + 1];
						double[] array20 = new double[num8 - 1 + 1];
						double[] array21 = new double[num8 - 1 + 1];
						float item = 0f;
						double num25 = 0.0;
						double num26 = 0.0;
						a_8 = A_0.bm.ca();
						int num27 = 0;
						int num28 = 0;
						float A_14 = default(float);
						float A_15 = default(float);
						double num38 = default(double);
						double num39 = default(double);
						double num53 = default(double);
						double num49 = default(double);
						double num50 = default(double);
						float item2 = default(float);
						do
						{
							num28++;
							m2(ref A_14, ref A_15);
							if (A_0.bq.x && num28 > 1)
							{
								kw = A_0.bq.y;
								float num29 = (A_14 + A_15) / 2f;
								float num30 = A_15 - A_14 - 2f * kw;
								if (num30 < 50f)
								{
									kw -= (50f - num30) / 2f;
									num30 = 50f;
								}
								A_14 = num29 - num30 / 2f;
								A_15 = num29 + num30 / 2f;
							}
							else
							{
								kw = 0f;
							}
							int num31 = num5;
							for (int num32 = 1; num32 <= num31; num32++)
							{
								double[] array22 = (double[])A_0.bm.cv().Clone();
								double[] array23 = (double[])A_0.bm.cz().Clone();
								if (kd)
								{
									return;
								}
								A_1.a = global::r.d.a.a.b;
								hr2 = A_0.bm.cw();
								hr2.cf = 0.0;
								hr hr3;
								(hr3 = A_0.bm).t(hr3.ca() + 1);
								_ = A_0.bq;
								double num33 = global::jf.a(random) * num12;
								double num34 = (double)num7 * (random.NextDouble() - 0.5);
								double num35 = 0.0;
								int num36 = num6;
								for (int num37 = 1; num37 <= num36; num37++)
								{
									num35 += global::jf.a(random);
								}
								num35 *= num11 / (double)num6;
								if (flag2)
								{
									num38 = (double)num4 * (random.NextDouble() - 0.5);
									num39 = 0.0;
									int num40 = num3;
									for (int num41 = 1; num41 <= num40; num41++)
									{
										num39 += global::jf.a(random);
									}
									num39 *= num15 / (double)num3;
								}
								int num42 = num2 - 1;
								for (num = 0; num <= num42; num++)
								{
									double num43 = array[num] * (1.0 - num33);
									double num44 = 0.0;
									double num45 = 0.0;
									int num46 = num6;
									for (int num47 = 1; num47 <= num46; num47++)
									{
										num44 += array2[num] * global::jf.a(random) * num13;
										num45 += array2[num] * global::jf.a(random) * Math.Sqrt(array4[num] * 1.604) * num10;
									}
									double num48 = num35 * array2[num];
									num44 /= (double)num6;
									num45 /= (double)num6;
									if (flag2)
									{
										num49 = 0.0;
										num50 = 0.0;
										int num51 = num3;
										for (int num52 = 1; num52 <= num51; num52++)
										{
											num49 += array3[num] * global::jf.a(random) * num16;
											num50 += array3[num] * global::jf.a(random) * Math.Sqrt(array5[num] * 1.604) * num14;
										}
										num53 = num39 * array3[num];
										num49 /= (double)num3;
										num50 /= (double)num3;
									}
									array22[num] = num43 + (num44 + num48 + num45) * (double)A_5[num];
									if (flag2)
									{
										array22[num] += (num49 + num53 + num50) * (double)(1f - A_5[num]);
									}
									if (num7 != 0f)
									{
										array23[num] = A_8[num] + num34 * (double)A_5[num];
									}
									if (flag2 && num4 != 0f)
									{
										array23[num] += num38 * (double)(1f - A_5[num]);
									}
								}
								hr2.r(array22);
								hr2.af((double[])null);
								if (num7 != 0f || (flag2 && num4 != 0f))
								{
									hr2.t(array23);
									a12 = null;
									if (hi.m2(hc, ha, hr2, ref A_2, A_4: false, a12) != b9.ErrPublic.None)
									{
										throw new ApplicationException("Error in TaskCoreMeasEngine call to CalcSetUpLayers");
									}
								}
								_ = null;
								a11.h = gt;
								a11.w = hr2;
								((global::r.d.a)a11).a = global::r.d.a.a.a;
								a11.aa = true;
								a11.w = m2(a11.w, hc, A_2: true, A_0.d3(), A_4: false);
								r r2 = A_0;
								if (hr.r(hr2.cj(), hr2.cu().q() != null))
								{
									ErrPublic errPublic = m2(hr2, zj(), ref hg, A_3: true, r2.d3(), A_14, A_15, A_7: false, r2.br, ref A_2);
									ErrPublic a_9 = errPublic;
									global::r.d.a.b a_10 = r2.d3();
									bool a_11 = r2.bk;
									global::r.d.a a_12 = A_1;
									string a_13 = A_2;
									bool A_16 = false;
									m2(a_9, a_10, a_11, A_3: false, a_12, a_13, ref A_16, A_7: true);
									if (errPublic != ErrPublic.None)
									{
										kd = true;
									}
								}
								else
								{
									A_1.a = global::r.d.a.a.a;
								}
								r2 = null;
								if (kd)
								{
									return;
								}
								num27++;
								int num54 = num8 - 1;
								for (int num55 = 0; num55 <= num54; num55++)
								{
									if (num55 > 0 && num55 < num8 - 1)
									{
										array6[num55] += hg.di()[num55];
										array7[num55] += hg.di()[num55] * hg.di()[num55];
										array8[num55] += hg.dj()[num55];
										array9[num55] += hg.dj()[num55] * hg.dj()[num55];
										array10[num55] += hg.dl()[num55];
										array11[num55] += hg.dl()[num55] * hg.dl()[num55];
									}
									array12[num55] += hg.dm()[num55];
									array13[num55] += hg.dm()[num55] * hg.dm()[num55];
									array14[num55] += hg.dn()[num55];
									array15[num55] += hg.dn()[num55] * hg.dn()[num55];
									array16[num55] += hg.dp()[num55];
									array17[num55] += hg.dp()[num55] * hg.dp()[num55];
									array18[num55] += hg.dq()[num55];
									array19[num55] += hg.dq()[num55] * hg.dq()[num55];
									array20[num55] += hg.@do()[num55];
									array21[num55] += hg.@do()[num55] * hg.@do()[num55];
								}
								num25 += (double)hg.c2();
								num26 += (double)(hg.c2() * hg.c2());
							}
							float[] array24 = new float[num8 - 1 + 1];
							float[] array25 = new float[num8 - 1 + 1];
							float[] array26 = new float[num8 - 1 + 1];
							float[] array27 = new float[num8 - 1 + 1];
							float[] array28 = new float[num8 - 1 + 1];
							float[] array29 = new float[num8 - 1 + 1];
							float[] array30 = new float[num8 - 1 + 1];
							float[] array31 = new float[num8 - 1 + 1];
							float[] array32 = new float[num8 - 1 + 1];
							float[] array33 = new float[num8 - 1 + 1];
							float[] array34 = new float[num8 - 1 + 1];
							float[] array35 = new float[num8 - 1 + 1];
							float[] array36 = new float[num8 - 1 + 1];
							float[] array37 = new float[num8 - 1 + 1];
							float[] array38 = new float[num8 - 1 + 1];
							float[] array39 = new float[num8 - 1 + 1];
							if (num27 > 1)
							{
								int num56 = num8 - 1;
								for (int num57 = 0; num57 <= num56; num57++)
								{
									if (num57 > 0 && num57 < num8 - 1)
									{
										array24[num57] = Convert.ToSingle(Math.Sqrt(array7[num57] / (double)(num27 - 1) - array6[num57] * array6[num57] / (double)(num27 * (num27 - 1))));
										array25[num57] = Convert.ToSingle(Math.Sqrt(array9[num57] / (double)(num27 - 1) - array8[num57] * array8[num57] / (double)(num27 * (num27 - 1))));
										array26[num57] = (float)Math.Sqrt(array11[num57] / (double)(num27 - 1) - array10[num57] * array10[num57] / (double)(num27 * (num27 - 1)));
										array32[num57] = (float)(array6[num57] / (double)num27);
										array33[num57] = (float)(array8[num57] / (double)num27);
										array34[num57] = (float)(array10[num57] / (double)num27);
									}
									array27[num57] = Convert.ToSingle(Math.Sqrt(array13[num57] / (double)(num27 - 1) - array12[num57] * array12[num57] / (double)(num27 * (num27 - 1))));
									array28[num57] = Convert.ToSingle(Math.Sqrt(array15[num57] / (double)(num27 - 1) - array14[num57] * array14[num57] / (double)(num27 * (num27 - 1))));
									array29[num57] = Convert.ToSingle(Math.Sqrt(array17[num57] / (double)(num27 - 1) - array16[num57] * array16[num57] / (double)(num27 * (num27 - 1))));
									array30[num57] = Convert.ToSingle(Math.Sqrt(array19[num57] / (double)(num27 - 1) - array18[num57] * array18[num57] / (double)(num27 * (num27 - 1))));
									array31[num57] = Convert.ToSingle(Math.Sqrt(array21[num57] / (double)(num27 - 1) - array20[num57] * array20[num57] / (double)(num27 * (num27 - 1))));
									array35[num57] = (float)(array12[num57] / (double)num27);
									array36[num57] = (float)(array14[num57] / (double)num27);
									array37[num57] = (float)(array16[num57] / (double)num27);
									array38[num57] = (float)(array18[num57] / (double)num27);
									array39[num57] = (float)(array20[num57] / (double)num27);
								}
								item = Convert.ToSingle(Math.Sqrt(num26 / (double)(num27 - 1) - num25 * num25 / (double)(num27 * (num27 - 1))));
								item2 = (float)(num25 / (double)num27);
							}
							ke.Add(array24);
							kf.Add(array25);
							kg.Add(array26);
							kh.Add(array27);
							ki.Add(array28);
							kj.Add(array29);
							kk.Add(array30);
							kl.Add(array31);
							km.Add(item);
							kn.Add(array32);
							ko.Add(array33);
							kp.Add(array34);
							kq.Add(array35);
							kr.Add(array36);
							ks.Add(array37);
							kt.Add(array38);
							ku.Add(array39);
							kv.Add(item2);
						}
						while (A_0.bq.x && num28 < 2 && (hc.dh().bj() | hc.dh().a8()));
						break;
					}
					catch (Exception ex4)
					{
						ProjectData.SetProjectError(ex4);
						Exception ex5 = ex4;
						ab8().c(fz.b.b, "Exception Thrown in TaskCoreMeasEngine around ComputePrecision()", ex5);
						A_1.b = ex5.Message;
						A_1.a = global::r.d.a.a.b;
						ProjectData.ClearProjectError();
						break;
					}
					finally
					{
						global::r.d.a a13 = new global::r.d.a(A_0.d3(), a_);
						try
						{
							a13.a = global::r.d.a.a.b;
							A_0.bm.t(a_8);
							a11.h = gt;
							a11.w = A_0.bm;
							((global::r.d.a)a11).a = global::r.d.a.a.a;
							a11.aa = true;
							r r3 = A_0;
							ErrPublic errPublic;
							if (kd)
							{
								errPublic = m2(r3.bm, zj(), ref hg, A_3: true, r3.d3(), A_5: true, r3.br, ref A_2);
								hg.cg(A_0: true);
							}
							else
							{
								errPublic = m2(r3.bm, zj(), ref hg, A_3: true, r3.d3(), r3.br, ref A_2);
							}
							ErrPublic a_14 = errPublic;
							global::r.d.a.b a_15 = A_0.d3();
							bool a_16 = A_0.bk;
							string a_17 = A_2;
							bool A_16 = false;
							m2(a_14, a_15, a_16, A_3: false, a13, a_17, ref A_16, A_7: false);
							if (a13.a != global::r.d.a.a.a)
							{
								ref string reference = ref A_1.b;
								reference = reference + " And in Finally: " + a13.b;
								A_1.a = global::r.d.a.a.b;
							}
							r3 = null;
							if (flag3)
							{
								hi.m2(num24, num2, 0);
							}
							kc = false;
						}
						catch (Exception ex6)
						{
							ProjectData.SetProjectError(ex6);
							Exception ex7 = ex6;
							ab8().c(fz.b.b, "Exception Thrown in TaskCoreMeasEngine in ComputePrecision Finally Block", ex7);
							A_1.b = ex7.Message;
							A_1.a = global::r.d.a.a.b;
							ProjectData.ClearProjectError();
						}
					}
				}
				case m.a.o:
					try
					{
						m2(A_0.bm, A_0.bs, A_0.h, ref A_2);
						A_1.a = global::r.d.a.a.a;
						break;
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2);
						Exception ex3 = ex2;
						et et2 = (et)A_0.bm.cu().p();
						ab8().c(fz.b.a, "Objective Calibration Failure, " + et2.al() + ": Thickness=" + et2.z() + ", IsImmersion=" + et2.ac() + ", MediumIndex=" + et2.ae() + ", FirstWL=" + et2.x() + ", LastWL=" + et2.y() + ", NumericalApertureTarget=" + et2.t());
						et2 = null;
						A_1.b = A_2;
						A_1.a = global::r.d.a.a.b;
						ProjectData.ClearProjectError();
						break;
					}
				}
			}
			catch (Exception ex11)
			{
				ProjectData.SetProjectError(ex11);
				Exception a_45 = ex11;
				ab8().c(fz.b.b, "Exception caught in TaskCoreMeasEngine(). Exception is: ", a_45);
				ProjectData.ClearProjectError();
			}
			finally
			{
				kd = false;
				j7 = false;
				A_0.i = true;
				if (flag5)
				{
					jj.z();
				}
				A_0.g.d(gt, A_1);
				if (A_0.d3() == global::r.d.a.b.b || ((m)A_0).a == m.a.i || A_0.bu || ((m)A_0).a == m.a.w)
				{
					jg.d(gt, new global::r.d.a(A_0.d3(), a_));
				}
			}
		}
	}

	private void m2(ref hg A_0, eo.a A_1, ref bool A_2, ref bool A_3)
	{
		hg obj = hc;
		int A_4 = 0;
		if (obj.bu(A_0: false, A_1, ref A_4) != null)
		{
			A_0 = new hg(hc.dh(), hc.cd());
			hc.bu(ref A_0);
			A_2 = A_3;
			A_3 = false;
		}
	}

	private void m2(hg A_0, ErrPublic A_1, string A_2, ref hc A_3, ref ErrPublic A_4, ref string A_5)
	{
		if (A_0 != null)
		{
			hg.ca = A_0.cl();
			if (Operators.CompareString(hg.cy().cl(), A_0.cl(), TextCompare: false) != 0)
			{
				hg.cb = A_0;
			}
			if (A_3 == null || A_3.c2() < hg.c2())
			{
				A_3 = hg;
				A_4 = A_1;
				A_5 = A_2;
			}
		}
	}

	private void m2(hg A_0, eo.a A_1, global::r.d.a.b A_2, bool A_3, bool A_4, ref hj A_5, ref int A_6, ref bool A_7, ref bool A_8)
	{
		if (A_0 == null)
		{
			return;
		}
		if (!A_3 && A_4)
		{
			A_3 = hg.c4();
		}
		A_5 = A_0.bu(A_3, A_1, ref A_6);
		if (A_5 == null)
		{
			return;
		}
		m2(hc, global::hg.b0() + A_5.e(), he, A_2);
		hc.b8().a(A_0.b8().p());
		checked
		{
			int num = Enum.GetValues(typeof(global::h.f)).Length - 1 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				global::h.g a_ = unchecked((global::h.g)num2);
				global::g obj = A_0.b8().a(a_);
				global::g A_9 = hc.b8().a(a_);
				obj.c(ref A_9);
			}
			A_7 = !A_5.g();
			A_8 = true;
			List<hj> list = A_0.ed().es();
			int num3 = A_6;
			int num4 = list.Count - 1;
			for (int num5 = num3; num5 <= num4; num5++)
			{
				hj hj2 = list[num5];
				if ((hj2.g() && hj2.f() == global::hj.a.b) || (hj2.f() == global::hj.a.c && !A_3))
				{
					A_8 = false;
					return;
				}
				hj2 = null;
			}
			list = null;
		}
	}

	private void m2(hg A_0, string A_1, g2 A_2, global::r.d.a.b A_3)
	{
		hg hg2 = new hg(A_0.dh(), A_0.cd());
		hf a_ = null;
		hg2.bu(A_1, A_0.cd(), null, A_3, A_4: false, A_5: false, default(Point), null, g2.b.a, A_9: false, ab8(), a_, A_12: false, A_13: false, null, A_15: false);
		if (A_2 != null)
		{
			hg hg3;
			g2 A_4 = (hg3 = hg2).d0();
			A_2.a(ref A_4);
			hg3.bu(A_4);
		}
		hg2.bu(ref A_0);
	}

	private void m2(hg A_0, bool A_1, hc A_2, ErrPublic A_3, string A_4, bool A_5, bool A_6, global::r.d.a.b A_7, global::r.d.a A_8)
	{
		if (A_0 != null)
		{
			A_0.bu(ref hc);
			if (A_1 || (A_2 != null && hg != A_2))
			{
				hg = A_2;
				hg.cf(A_1);
				bool A_9 = false;
				m2(A_3, A_7, A_5, A_6, A_8, A_4, ref A_9, A_7: false);
			}
		}
	}

	private void m2(u A_0)
	{
		k.a a10 = null;
		long a_ = default(long);
		try
		{
			if (A_0.g != null)
			{
				a_ = A_0.g.d();
				a10 = new k.a(A_0.d3(), a_);
				((global::r.d.a)a10).a = global::r.d.a.a.b;
			}
			switch (A_0.cg)
			{
			case u.CameraVideoTaskType.InitCamera:
			{
				if (l2 == null)
				{
					l2 = new d4(ab8(), vj(), A_2: false, A_3: false, vg());
				}
				ej.b a_2 = (hb.d0().p() ? ej.b.b : (vg() ? ui() : ej.b.a));
				if (Operators.CompareString(l2.am(), "None", TextCompare: false) != 0)
				{
					bool a_3;
					bool a_4;
					if (vg())
					{
						a_3 = true;
						a_4 = true;
					}
					else
					{
						a_3 = u5();
						a_4 = u4();
					}
					if (!l2.a(A_0.cl, null, a_2, A_0.cr, A_4: false, a_3, a_4, vg(), A_8: false, A_0.d3()))
					{
						l2 = null;
					}
					else
					{
						d4 obj = l2;
						bool lockTaken = false;
						int A_1 = default(int);
						obj.a(ref lockTaken, ref A_1);
						l2.b(A_0: true, A_1);
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					if (l2 != null)
					{
						l2.ac();
					}
					string a_5 = ((l2 == null) ? "None" : l2.am());
					l3?.Invoke(gt, a_5);
				}
				jg.d(gt, new global::r.d.a(A_0.d3(), a_));
				break;
			}
			case u.CameraVideoTaskType.ReinitCamera:
				l2.a(A_0.g, A_0.d3());
				l2.ac();
				if (A_0.g != null)
				{
					((global::r.d.a)a10).a = global::r.d.a.a.a;
				}
				break;
			case u.CameraVideoTaskType.TestCanRunVideo:
				if (l2 != null)
				{
					bool flag = l2.ay();
					if (A_0.g != null)
					{
						a10.d = flag;
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
				}
				break;
			case u.CameraVideoTaskType.StartVideo:
				if (l2 != null)
				{
					l2.s(A_0.cm);
					if (A_0.g != null)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
				}
				break;
			case u.CameraVideoTaskType.StopVideo:
				if (l2 != null)
				{
					l2.ar();
					if (A_0.g != null)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
				}
				break;
			case u.CameraVideoTaskType.SetFocus:
				if (l2 != null)
				{
					l2.b(A_0.ch);
				}
				break;
			case u.CameraVideoTaskType.SetZoom:
				if (l2 != null)
				{
					l2.a(A_0.ci, A_0.cj, A_0.ck);
				}
				break;
			case u.CameraVideoTaskType.SetScroll:
				if (l2 != null)
				{
					l2.a(A_0.cj, A_0.ck, A_0.cn);
				}
				break;
			case u.CameraVideoTaskType.SettingsFromDialog:
				if (l2 != null)
				{
					l2.a(A_0.cm, A_0.ch, A_0.co);
				}
				break;
			case u.CameraVideoTaskType.CalibrateSpot:
				if (l2 != null)
				{
					l2.aq();
				}
				if (A_0.g != null)
				{
					((global::r.d.a)a10).a = global::r.d.a.a.a;
				}
				jg.d(gt, new global::r.d.a(A_0.d3(), a_));
				break;
			case u.CameraVideoTaskType.ConfigVideoSettingFromUI:
				if (l2 != null)
				{
					l2.a(A_0.cp, A_0.cq, A_0.ci);
				}
				break;
			case u.CameraVideoTaskType.DeAllocation:
				if (l2 != null)
				{
					l2.az();
					l2 = null;
					if (A_0.j is AutoResetEvent autoResetEvent)
					{
						autoResetEvent.Set();
					}
					l3?.Invoke(gt, "None");
				}
				jg.d(gt, new global::r.d.a(A_0.d3(), a_));
				break;
			case u.CameraVideoTaskType.ChangeVideoImageRotation:
				if (l2 != null)
				{
					l2.a(A_0.g, A_0.cs, A_0.d3());
				}
				break;
			case u.CameraVideoTaskType.ContinuousImage:
			{
				if (mx == null)
				{
					Interlocked.CompareExchange(ref mx, new StaticLocalInitFlag(), null);
				}
				bool lockTaken = false;
				try
				{
					Monitor.Enter(mx, ref lockTaken);
					if (mx.State == 0)
					{
						mx.State = 2;
						mw = DateTime.MinValue;
					}
					else if (mx.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					mx.State = 1;
					if (lockTaken)
					{
						Monitor.Exit(mx);
					}
				}
				if ((DateAndTime.Now - mw).TotalMilliseconds < 33.0)
				{
					Thread.Sleep(1);
					break;
				}
				mw = DateAndTime.Now;
				l2.au();
				a10 = new k.a(A_0.d3(), a_);
				Bitmap bitmap = l2.aw();
				Conversions.ToBoolean(A_0.j);
				if (bitmap != null)
				{
					a10.d = bitmap;
					A_0.l.m.d(A_0.e, a10);
				}
				break;
			}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_6 = ex2;
			if (A_0.l != null)
			{
				A_0.l.q(-1, global::r.d.a.a.b, A_2: true);
			}
			ab8().c(fz.b.b, "Error in TaskCoreVideo. Task Type=" + A_0.cg, a_6);
			jg.d(gt, new global::r.d.a(A_0.d3(), a_));
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (A_0.g != null)
			{
				A_0.g.d(A_0.e, a10);
			}
		}
	}

	private bool m2(ErrPublic A_0)
	{
		switch (A_0)
		{
		case ErrPublic.None:
		case ErrPublic.Generic:
		case ErrPublic.SpecAnalysis:
		case ErrPublic.OutOfCorrelativeRange:
			return false;
		default:
			return true;
		}
	}

	private void m2(ErrPublic A_0, global::r.d.a.b A_1, global::r.d.a A_2, string A_3, bool A_4, ref i.b A_5)
	{
		eo.a a_ = ((A_5 != null && A_5.ab != null) ? A_5.ab.cz() : null);
		eo eo2 = hc.dh();
		if (eo2.av(a_) || eo2.a0(a_) || eo2.az(a_) || eo2.ax(a_) || A_4)
		{
			switch (A_0)
			{
			case ErrPublic.CompositeRecipeInconsistantWithNumSpectra:
			{
				string A_6 = "IncorrectNumberOfMultipleSpectra";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.SpecAnalysisFFTNoLayersSelectedForMeasure:
			{
				A_5 = new i.b(A_1, A_2.a7());
				A_5.ad = global::r.i.a.c;
				A_5.ab = hg;
				hc obj = A_5.ab;
				string A_6 = "MeasErrorNoLayerSelected";
				obj.b9 = hu.a(ref A_6);
				jb.d(gt, A_5);
				A_2.a = global::r.d.a.a.a;
				break;
			}
			case ErrPublic.SolvingAbortSuccess:
				if (k4)
				{
					A_2.a = global::r.d.a.a.a;
				}
				else
				{
					A_2.b = k5;
				}
				break;
			case ErrPublic.InitNKCoeffsInvalid:
			{
				string A_6 = "InitNKCoeffsInvalid";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.InvalidDConstraints:
			{
				string A_6 = "ConstraintTooSmallD";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.InvalidNConstraints:
			{
				string A_6 = "ConstraintTooSmallN";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.InvalidKConstraints:
			{
				string A_6 = "ConstraintTooSmallK";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.NoDataWithinRange:
				A_2.b = ld;
				break;
			case ErrPublic.SpecAnalysisSetup:
				A_2.b = A_3;
				break;
			case ErrPublic.InsufficientData:
			{
				string A_6 = "MeasErrInsufficientData";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.OutOfCorrelativeRange:
			{
				string A_6 = "ErrCorrelativeRangeFmt";
				A_2.b = string.Format(hu.a(ref A_6), 30.000002f.ToString("0"));
				break;
			}
			case ErrPublic.ModelCoeffIncompatibleWithInitialN:
			{
				string A_6 = "MeasErrModelCoeffIncompatWithInitialN";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.ModelCoeffIncompatibleWithInitialK:
			{
				string A_6 = "MeasErrModelCoeffIncompatWithInitialK";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.OnlyExactSpectrumAnalysisPermittedForRAtAngle:
			{
				string A_6 = "MeasErrOnlyExactPermittedForRAtAngle";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.ZAREModelUsedInMultipleLayersWithinSingleStack:
			{
				string A_6 = "MeasErrZareUsedInMultipleLayersInStack";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.ZAREAttemptToSolveForKWithoutTrans:
			{
				string A_6 = "MeasErrZAREAttemptToSolveForKWithoutTrans";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.ZAREAttemptToSolveForXKWithoutReflTrans:
			{
				string A_6 = "MeasErrZAREAttemptToSolveForXKWithoutReflTrans";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.ZAREAttemptToSolveForNWithoutRAngle:
			{
				string A_6 = "MeasErrZAREAttemptToSolveForNWithoutRAngle";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.ZAREAttemptToSolveForDNWithoutRAngle:
			{
				string A_6 = "MeasErrZAREAttemptToSolveForDNWithoutRAngle";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.ZAREAttemptToSolveForDNWithoutR0OrT:
			{
				string A_6 = "MeasErrZAREAttemptToSolveForDNWithoutR0OrT";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.ZAREAttemptToSolveForDNKWithoutDoubleRefl:
			{
				string A_6 = "MeasErrZAREAttemptToSolveForDNKWithoutDoubleRefl";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.ZAREInsufficientWavelengthOverlapBetweenSpectrumTypes:
			{
				string A_6 = "MeasErrZAREInsufficientWavelengthOverlapBetweenSpectrumTypes";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.ZAREMismatchedSolveForDInSameLayers:
			{
				string A_6 = "MeasErrZAREMismatchedSolveForDInSameLayers";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.ZAREIndependentDForSameNorK:
			{
				string A_6 = "MeasErrZAREIndependentDForSameNorK";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.ZAREDesignError:
			{
				string A_6 = "MeasErrZAREDesignError";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.InvalidSolarData:
			{
				string A_6 = "InvalidSolarDataErrMsg";
				A_2.b = hu.a(ref A_6);
				break;
			}
			case ErrPublic.InvalidIlluminanceData:
			{
				string A_6 = "InvalidIlluminanceErrMsg";
				A_2.b = hu.a(ref A_6);
				break;
			}
			default:
			{
				string A_6 = "ErrSpectrumAnalysis";
				A_2.b = hu.a(ref A_6) + " " + A_3;
				A_2.a = global::r.d.a.a.b;
				break;
			}
			}
		}
		else
		{
			A_2.a = global::r.d.a.a.a;
		}
		eo2 = null;
	}

	private void m2(ErrPublic A_0, global::r.d.a.b A_1, global::r.d.a A_2, string A_3, ref bool A_4)
	{
		i.b A_5 = null;
		A_4 = false;
		if (A_0 == ErrPublic.None)
		{
			A_5 = new i.b(A_1, A_2.a7());
			A_5.ab = null;
			A_5.ac = hh;
			A_5.h = gt;
			A_5.ad = global::r.i.a.a;
			jb.d(gt, A_5);
			A_2.a = global::r.d.a.a.a;
			A_4 = true;
		}
		else
		{
			m2(A_0, A_1, A_2, A_3, A_4: false, ref A_5);
		}
	}

	private void m2(ErrPublic A_0, global::r.d.a.b A_1, bool A_2, bool A_3, global::r.d.a A_4, string A_5, ref bool A_6, bool A_7)
	{
		i.b A_8 = null;
		A_6 = false;
		if (A_0 == ErrPublic.None)
		{
			A_8 = new i.b(A_1, A_4.a7());
			A_8.ab = hg;
			A_8.ac = null;
			A_8.h = gt;
			A_8.ad = global::r.i.a.a;
			A_8.ae = A_2;
			A_8.af = A_3;
			if (A_7)
			{
				je.d(gt, A_8);
				A_8.ab.cf(A_0: false);
			}
			jb.d(gt, A_8);
			if (A_7)
			{
				A_8.ab.cf(A_0: true);
			}
			A_4.a = global::r.d.a.a.a;
			A_6 = true;
		}
		else
		{
			m2(A_0, A_1, A_4, A_5, hg.cn().cu().q() != null, ref A_8);
		}
	}

	protected void m2(s A_0)
	{
		long a_ = default(long);
		if (A_0.g != null)
		{
			a_ = A_0.g.d();
		}
		f.a a10 = new f.a(A_0.d3(), a_);
		((global::r.d.a)a10).a = global::r.d.a.a.b;
		a10.h = gt;
		checked
		{
			try
			{
				global::r.d.a a11 = new global::r.d.a(A_0.d3(), a_);
				a11.a = global::r.d.a.a.a;
				A_0.g.e(gt, a11);
				switch (((m)A_0).a)
				{
				case m.a.j:
					qh(A_0.bv);
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				case m.a.k:
				{
					s s2 = A_0;
					m2(s2.by, s2.bz, s2.bv, s2.b6, s2.cc, A_0.d3());
					s2 = null;
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				}
				case m.a.af:
					sn(A_0.b6);
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				case m.a.l:
					m2(A_0.b0, A_0.b1, A_0.b6, A_0.cd);
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				case m.a.at:
				{
					int num2 = iq[0].Count - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						if (p9(hc.b8(), num3, 0))
						{
							iq[0][num3].sn(A_0.cb);
						}
					}
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				}
				case m.a.a9:
					up();
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				case m.a.al:
					l6.m(A_0.d3());
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				case m.a.am:
					l6.n(A_0.d3());
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				case m.a.ao:
					l6.m(A_0.d3());
					l6.l(A_0.b3);
					l6.m(A_0.b4);
					if (hc.b8().a(v4(), uq()))
					{
						if (it.e() && sj(hc.b8()))
						{
							l6.p(global::jl.b.b);
						}
						else
						{
							l6.p(global::jl.b.a);
						}
						List<long> list = new List<long>();
						List<float> list2 = new List<float>();
						int num4 = @is.Count - 1;
						for (int num5 = 0; num5 <= num4; num5++)
						{
							@in obj = @is[num5];
							int num6 = obj.th() - 1;
							for (int num7 = 0; num7 <= num6; num7++)
							{
								list.Add(u1());
							}
							list2.AddRange(obj.s6());
						}
						l6.l(list);
						l6.l(list2);
					}
					else if (hc.b8().av())
					{
						if (s3(A_0: true) && s6(hc.b8()))
						{
							l6.p(global::jl.b.b);
						}
						else
						{
							l6.p(global::jl.b.a);
						}
						List<long> list3 = new List<long>();
						List<float> list4 = new List<float>();
						List<global::h.b> list5 = hc.b8().au();
						int num8 = list5.Count - 1;
						for (int num9 = 0; num9 <= num8; num9++)
						{
							if (list5[num9].a)
							{
								list3.Add(u1());
								list4.Add(list5[num9].d);
							}
						}
						list5 = null;
						l6.l(list3);
						l6.l(list4);
					}
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				case m.a.an:
				{
					string A_3 = null;
					l6.l(A_0.b7, A_0.d3(), j5, ref A_3);
					l6.l(Path.GetFileNameWithoutExtension(A_0.b7));
					if (!string.IsNullOrEmpty(A_3))
					{
						((global::r.d.a)a10).b = A_3;
						return;
					}
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				}
				case m.a.aq:
				{
					string A_2 = null;
					l6.l(A_0.b8, hc, A_0.b9, A_0.d3(), ref A_2);
					if (string.IsNullOrEmpty(A_2))
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
						break;
					}
					((global::r.d.a)a10).b = A_2;
					((global::r.d.a)a10).a = global::r.d.a.a.b;
					break;
				}
				case m.a.ar:
				{
					string A_1 = null;
					l6.l(A_0.b8, hc, A_0.b9, A_0.ca, A_0.d3(), ref A_1);
					if (string.IsNullOrEmpty(A_1))
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
						break;
					}
					((global::r.d.a)a10).b = A_1;
					((global::r.d.a)a10).a = global::r.d.a.a.b;
					break;
				}
				default:
				{
					int num = unchecked((int)((m)A_0).a);
					throw new ArgumentOutOfRangeException("Unknown Task.ID in TaskCoreSetup. Task.Id=" + num);
				}
				}
				jg.d(gt, new global::r.d.a(A_0.d3(), a_));
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				ab8().c(fz.b.b, "Error in TaskCoreSetup. Task ID=" + ((m)A_0).a, a_2);
				ProjectData.ClearProjectError();
			}
			finally
			{
				A_0.g.d(gt, a10);
			}
		}
	}

	private void m2(bool A_0, bool A_1, hg A_2, bool A_3, bool A_4, global::r.d.a.b A_5)
	{
		int A_6 = 0;
		bool flag = A_2.bu(A_0: false, null, ref A_6) != null;
		hg A_7 = null;
		hj hj2 = null;
		int A_8 = 0;
		bool flag2 = false;
		if (flag)
		{
			A_2.bu(ref A_7);
		}
		else
		{
			A_7 = A_2;
		}
		checked
		{
			do
			{
				if (!flag2)
				{
					if (A_3 && A_7.b8().a(v4(), uq()))
					{
						tb();
					}
					else
					{
						int upperBound = iq.GetUpperBound(0);
						bool num = A_7.dh().a8();
						string A_9 = "Unknown";
						string a_ = hu.a(ref A_9);
						if (num)
						{
							a_ = A_7.dh().a9();
						}
						bool flag3 = A_2.d0().c() == g2.a.b;
						global::h a_2 = m2(A_7, flag3, A_2: true);
						A_6 = upperBound;
						for (int num2 = 0; num2 <= A_6; num2++)
						{
							int num3 = iq[num2].Count - 1;
							for (int num4 = 0; num4 <= num3; num4++)
							{
								if (p9(a_2, num4, num2))
								{
									ip ip2 = iq[num2][num4];
									if (flag)
									{
										ip2.st(A_8);
									}
									if (flag3 && num2 == iu[0] && !ip2.m2(jk, A_1: true, A_2: false, A_3: true, A_4: false, A_4))
									{
										ab8().c(fz.a.b, "ErrAutoRefFileFmt2", ip2.uq(), ip2.yq());
										throw new ApplicationException("Failure writing R and T Autobaseline Reference File");
									}
									ip2.m2(a_, zp() == g2.a.b, A_4, iv[0], flag, A_8);
									ip2 = null;
								}
							}
						}
					}
					lu = false;
					m2(A_0, A_1, A_3, A_3: false);
				}
				hj2 = A_2.bu(A_0: false, null, ref A_8);
				if (hj2 != null)
				{
					flag2 = !hj2.g();
					m2(A_7, global::hg.b0() + hj2.e(), A_2.d0(), A_5);
				}
			}
			while (hj2 != null);
			qh(A_2);
			jf.d(gt, null);
		}
	}

	protected void m2(t A_0)
	{
		long a_ = default(long);
		if (A_0.g != null)
		{
			a_ = A_0.g.d();
		}
		f.a a10 = new f.a(A_0.d3(), a_);
		global::r.d.a a11 = new global::r.d.a(A_0.d3(), a_);
		((global::r.d.a)a10).a = global::r.d.a.a.b;
		a10.h = gt;
		try
		{
			a11.a = global::r.d.a.a.a;
			A_0.g.e(gt, a11);
			m.a a12 = ((m)A_0).a;
			if (a12 == m.a.q)
			{
				if (A_0.cf > 0f)
				{
					DateTime t2 = A_0.ce.AddSeconds(A_0.cf);
					ka = true;
					A_0.h.t(A_0.cf, A_0.d3());
					do
					{
						double totalSeconds = DateTime.Now.Subtract(A_0.ce).TotalSeconds;
						A_0.h.t((float)(100.0 * totalSeconds / (double)A_0.cf));
						double num = (double)A_0.cf - totalSeconds;
						if (num * 1000.0 > 50.0)
						{
							Thread.Sleep(50);
						}
						else if (num > 0.002)
						{
							Thread.Sleep(checked((int)Math.Round(num * 1000.0)));
						}
					}
					while (DateTime.Compare(DateTime.Now, t2) < 0 && !A_0.l.q());
					ka = false;
					A_0.h.z();
				}
				((global::r.d.a)a10).a = global::r.d.a.a.a;
				return;
			}
			int num2 = (int)((m)A_0).a;
			throw new ArgumentOutOfRangeException("Unknown Task.ID in TaskCoreExecution. Task.Id=" + num2);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			ab8().c(fz.b.b, "Error in TaskCoreExecution. Task ID=" + ((m)A_0).a, a_2);
			ProjectData.ClearProjectError();
		}
		finally
		{
			A_0.g.d(gt, a10);
		}
	}

	private FIUsbController tl()
	{
		if (im != null)
		{
			return im.abk();
		}
		if (iq != null && iq.Length > 0 && iq[0] != null && iq[0].Count > 0 && iq[0][0] != null)
		{
			return iq[0][0].abk();
		}
		return null;
	}

	protected void p9(q A_0)
	{
		long a_ = default(long);
		if (A_0.g != null)
		{
			a_ = A_0.g.d();
		}
		g.a a10 = new g.a(A_0.d3(), a_);
		global::r.d.a a11 = new global::r.d.a(A_0.d3(), a_);
		((global::r.d.a)a10).a = global::r.d.a.a.b;
		a10.h = gt;
		checked
		{
			try
			{
				a11.a = global::r.d.a.a.a;
				A_0.g.e(gt, a11);
				switch (((m)A_0).a)
				{
				case m.a.p:
				{
					q q2 = A_0;
					float A_1 = default(float);
					if (iq[q2.a6][p9(q2.a6, q2.a7)].m2((SpectromTempSensorLoc)q2.j, ref A_1) != 0)
					{
						a10.j = global::r.g.a.a.n;
					}
					else
					{
						a10.k = q2.a6;
						a10.l = (float)q2.a7;
						a10.m = Conversions.ToSingle(q2.j);
						a10.n = A_1;
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					q2 = null;
					break;
				}
				case m.a.s:
				{
					int num13 = 0;
					q q5 = A_0;
					ip.d a_5 = (ip.d)q5.a8;
					ip ip5 = m2(q5.bi, q5.a6, q5.a7);
					if (ip5.m2(a_5))
					{
						Collection<ia> A_9 = null;
						num13 = ip5.m2(ref A_9);
						if (num13 == 0)
						{
							if (A_9.Count > 0)
							{
								num13 = ip5.vs();
								if (num13 != 0)
								{
									ab8().c(fz.b.a, "Error attempting to clear USBSpectrometer memory. Error is " + num13);
								}
							}
						}
						else
						{
							ab8().c(fz.b.a, "Error attempting to read USBSpectrometer memory. Error is " + num13);
						}
					}
					if (num13 == 0)
					{
						num13 = ip5.p9(a_5);
						if (num13 == 0)
						{
							((global::r.d.a)a10).a = global::r.d.a.a.a;
						}
						else
						{
							ab8().c(fz.b.a, "Error attempting to write USBSpectrometer firmware. Error is " + num13);
						}
					}
					q5 = null;
					break;
				}
				case m.a.au:
				{
					ip ip4 = m2(A_0.bi, A_0.a6, A_0.a7);
					float a_2 = Conversions.ToSingle(A_0.j);
					bool A_6;
					int num9;
					int num10 = default(int);
					do
					{
						hr A_3 = null;
						hr A_4 = null;
						hr A_5 = null;
						A_6 = false;
						m2(A_0.h, A_0.d3(), ip4, ij, 1500f, ref A_6, ref A_3, ref A_4, ref A_5);
						hr obj2 = A_3;
						string A_7 = global::@is.b() + ip4.ur() + "_NeonPlusBac.fmspe";
						obj2.k(ref A_7, "Wavelength (nm)", "Raw Reflectance (counts)");
						hr obj3 = A_4;
						A_7 = global::@is.b() + ip4.ur() + "_NeonBac.fmspe";
						obj3.k(ref A_7, "Wavelength (nm)", "Raw Reflectance (counts)");
						hr obj4 = A_5;
						A_7 = global::@is.b() + ip4.ur() + "_NeonOnly.fmspe";
						obj4.k(ref A_7, "Wavelength (nm)", "Raw Reflectance (counts)");
						num9 = ip4.m2(A_5.cv(), a_2);
						num10++;
					}
					while (A_6 && num10 < 3);
					if (num9 == 0 && !A_6)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
						ip.n n2 = ip4.x3();
						a10.d = n2;
					}
					else if (A_6)
					{
						ab8().c(fz.b.a, "Repeated saturation errors while attempting Neon lamp calibration.");
					}
					else
					{
						ab8().c(fz.b.a, "Error attempting to calibrate Neon spectrum. Error is " + num9);
					}
					break;
				}
				case m.a.av:
					m2(A_0.bi, A_0.a6, A_0.a7).xz();
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				case m.a.aw:
				{
					ip ip7 = m2(A_0.bi, A_0.a6, A_0.a7);
					ip.o A_12 = null;
					bool A_13 = default(bool);
					bool A_14 = default(bool);
					bool A_15 = default(bool);
					bool A_16 = default(bool);
					bool A_17 = default(bool);
					m2(ab8(), A_0.d3(), 200, ref A_13, ref A_14, ref A_15, ref A_16, ref A_17);
					bool A_19;
					int num24;
					try
					{
						int num25 = default(int);
						do
						{
							hr A_18 = null;
							A_19 = false;
							global::r.c a_7 = A_0.h;
							global::r.d.a.b a_8 = A_0.d3();
							UVSource a_9 = ij;
							hr A_20 = null;
							hr A_21 = null;
							m2(a_7, a_8, ip7, a_9, 1500f, A_5: true, 8, ref A_19, ref A_20, ref A_21, ref A_18);
							num24 = ip7.m2(A_18.cv(), ref A_12);
							num25++;
						}
						while (A_19 && num25 < 3);
					}
					finally
					{
						m2(ab8(), A_13, A_17, 200, A_0.d3(), A_14, A_15, A_16);
					}
					if (num24 == 0 && !A_19)
					{
						ul();
						((global::r.d.a)a10).a = global::r.d.a.a.a;
						a10.d = A_12;
					}
					else if (A_19)
					{
						ab8().c(fz.b.a, "Repeated saturation errors while attempting TaskId.UpdateWavelengthOffset.");
					}
					else
					{
						ab8().c(fz.b.a, "Error attempting TaskId.UpdateWavelengthOffset. Error is " + num24);
					}
					break;
				}
				case m.a.a3:
				{
					int num27 = iq.Length - 1;
					for (int num28 = 0; num28 <= num27; num28++)
					{
						int num29 = iq[num28].Count - 1;
						for (int num30 = 0; num30 <= num29; num30++)
						{
							iq[num28][num30].x2();
						}
					}
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				}
				case m.a.bl:
				{
					Collection<ip.d>[] array2 = (Collection<ip.d>[])A_0.j;
					int num31 = iq.Length - 1;
					for (int num32 = 0; num32 <= num31; num32++)
					{
						int num33 = iq[num32].Count - 1;
						for (int num34 = 0; num34 <= num33; num34++)
						{
							Collection<ip.d> collection3 = array2[num32];
							iq[num32][num34].m2(collection3[num34].c7, collection3[num34].c8);
							collection3 = null;
						}
					}
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				}
				case m.a.ah:
				{
					ip obj5 = m2(A_0.bi, A_0.a6, A_0.a7);
					Collection<ia> A_8 = null;
					int num11 = obj5.m2(ref A_8);
					if (num11 == 0)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
						a10.d = A_8;
					}
					else
					{
						ab8().c(fz.b.a, "Error attempting to read USBSpectrometer memory headers. Error is " + num11);
					}
					_ = null;
					break;
				}
				case m.a.aj:
				{
					q q10 = A_0;
					int num47 = m2(A_0.bi, A_0.a6, A_0.a7).m2(q10.bc, q10.bd);
					if (num47 == 0)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					else
					{
						ab8().c(fz.b.a, "Error attempting to update USBSpectrometer memory with new CTMCal blocks. Error is " + num47);
					}
					q10 = null;
					break;
				}
				case m.a.ai:
				{
					int num8 = m2(A_0.bi, A_0.a6, A_0.a7).vs();
					if (num8 == 0)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					else
					{
						ab8().c(fz.b.a, "Error attempting to update USBSpectrometer memory with new CTMCal blocks. Error is " + num8);
					}
					_ = null;
					break;
				}
				case m.a.bk:
				{
					b a_10 = unchecked((b)Conversions.ToInteger(A_0.j));
					m2(a_10);
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					_ = null;
					break;
				}
				case m.a.ae:
				{
					string empty = string.Empty;
					q q9 = A_0;
					List<h6> list = new List<h6>();
					h6.c c11 = (h6.c)A_0.a8;
					FIUsbController fIUsbController5;
					if (c11.b2)
					{
						foreach (ip item in iq[q9.a6])
						{
							list.Add(item);
						}
						fIUsbController5 = p9(q9.bi, q9.a6, c11.b3).abk();
					}
					else if (c11.b4)
					{
						foreach (@in item2 in @is)
						{
							list.Add(item2);
						}
						fIUsbController5 = list[c11.b5].abk();
					}
					else if (c11.b6)
					{
						if (ip != null && Operators.CompareString(ip.abn(), c11.b, TextCompare: false) == 0)
						{
							list.Add(ip);
							fIUsbController5 = list[0].abk();
						}
						else if (ik != null && Operators.CompareString(ik.d().abn(), c11.b, TextCompare: false) == 0)
						{
							list.Add(ik.d());
							fIUsbController5 = list[0].abk();
						}
						else
						{
							fIUsbController5 = null;
						}
					}
					else
					{
						list.Add(i0);
						fIUsbController5 = list[0].abk();
					}
					FMLegacyAllSystemTypes fWInstTypeCodeAsEnum = fIUsbController5.FWInstTypeCodeAsEnum;
					h6.c c12 = c11;
					int lErrCode = default(int);
					if (c12.ah && c12.al)
					{
						if (fIUsbController5.SetLampSetpoint(0) != 0)
						{
							ab8().c(fz.b.a, "Error attempting to SetLampSetpoint in WriteControllerFirmware");
						}
						if (fIUsbController5.LsUpdatePowerOnLampSetpoint() != 0)
						{
							ab8().c(fz.b.a, "Error attempting to LsUpdatePowerOnLampSetpoint in WriteControllerFirmware");
						}
						byte b10 = 0;
						do
						{
							if (fIUsbController5.LsSetLEDSetpoint(b10, 0) != 0)
							{
								ab8().c(fz.b.a, "Error attempting to LsSetLEDSetpoint(" + b10 + ") in WriteControllerFirmware");
							}
							lErrCode = fIUsbController5.LsUpdatePowerOnLedSetpoint(b10);
							if (lErrCode != 0)
							{
								ab8().c(fz.b.a, "Error attempting to LsUpdatePowerOnLedSetpoint(" + b10 + ") in WriteControllerFirmware");
							}
							b10 = (byte)unchecked((uint)(b10 + 1));
						}
						while (unchecked((uint)b10) <= 2u);
					}
					((IFIUsbController)fIUsbController5).set_FWBitPatt(1, h6.sm(c12.n, c12.m, c12.o, c12.q, c12.r, c12.s, c12.t, c12.u));
					((IFIUsbController)fIUsbController5).set_FWBitPatt(2, h6.m2(c12.v, c12.w, c12.x, c12.ac, c12.y, c12.z));
					((IFIUsbController)fIUsbController5).set_FWBitPatt(3, h6.sj(c12.ab, c12.aa, c12.ad, c12.p, c12.ag, c12.ah, c12.@as, c12.au));
					((IFIUsbController)fIUsbController5).set_FWBitPatt(5, h6.qh(c12.bz, c12.b0, c12.bx, c12.by, c12.ao, c12.aq, c12.aw, c12.ax));
					((IFIUsbController)fIUsbController5).set_FWBitPatt(6, h6.m2(c12.ay, c12.az, c12.a0, c12.ai, c12.bl, c12.aj, c12.av, c12.a1, c12.a2));
					((IFIUsbController)fIUsbController5).set_FWBitPatt(7, h6.p9(c12.a3, c12.ak, c12.bc, c12.bb, c12.a4, c12.ba, c12.at, c12.bf));
					((IFIUsbController)fIUsbController5).set_FWBitPatt(8, h6.m2(c12.a5, c12.a6, c12.a7, c12.a8, c12.a9, c12.bd, c12.be, c12.bg));
					((IFIUsbController)fIUsbController5).set_FWBitPatt(9, h6.m2(c12.bh, c12.bi, c12.bj, c12.bk, c12.al, c12.an, c12.am));
					((IFIUsbController)fIUsbController5).set_FWBitPatt(10, h6.m2(c12.ai));
					fIUsbController5.FWMeasurementAngle = c12.bw;
					fIUsbController5.FWBoxTotalSubsystems = c12.bu;
					fIUsbController5.FWSubsysNumControllers = c12.bv;
					fIUsbController5.FWDefNumCurves = c12.br;
					fIUsbController5.FWDefOpticConfig = c12.bs;
					fIUsbController5.FWDefRefMat = c12.bp;
					fIUsbController5.FWDefRefMatID = c12.bq;
					fIUsbController5.FriendlySN = c12.a;
					fIUsbController5.ParentSerialNumber = c12.j;
					empty = fIUsbController5.SerialNumber;
					fIUsbController5.SerialNumber = Guid.NewGuid().ToString("N");
					c12.b = fIUsbController5.SerialNumber;
					fIUsbController5.FWLastUpdate = DateTime.Now;
					fIUsbController5.FWMfrDate = c12.k;
					fIUsbController5.FWOemCode = c12.bn;
					fIUsbController5.FWSubsystemIdx = c12.bt;
					fIUsbController5.FWSystemSubtype = c12.bo;
					fIUsbController5.FWInstTypeCodeAsEnum = c12.bm;
					fIUsbController5.FWRevNum = c12.f;
					fIUsbController5.FWUpdateRevLevel = -unchecked(0 - (c12.h ? 1 : 0));
					fIUsbController5.FWF50XYDkMirX = c12.ae;
					fIUsbController5.FWF50XYDkMirY = c12.af;
					fIUsbController5.FWLimCenDist = c12.l;
					if (!string.IsNullOrEmpty(c12.c))
					{
						h5.m2(null, c11, ab8(), c12.c);
						FMusbEnum obj7 = (FMusbEnum)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("BB8E1A15-4E65-45FA-9DE6-876792487AF7")));
						Collection<string> collection = new Collection<string>();
						Collection<string> collection2 = new Collection<string>();
						string a_6 = global::i7.e();
						short VerMSH = default(short);
						short VerMSL = default(short);
						short VerLSH = default(short);
						short VerLSL = default(short);
						obj7.GetVersion(ref VerMSH, ref VerMSL, ref VerLSH, ref VerLSL);
						collection.Add(c12.b);
						collection2.Add(c12.a);
						global::i7.c(VerMSH, VerMSL, VerLSH, VerLSL, global::jg.a(f6.FMSolveVer(1)), collection, collection2, a_6, c12.c);
					}
					c12 = null;
					byte[] array = new byte[8];
					if (fIUsbController5.eControllerType == FMUSBDeviceType.FIUSB2DeviceController)
					{
						array[0] = 192;
						array[1] = 109;
						array[2] = 17;
						array[3] = 33;
						array[4] = 0;
						array[5] = 1;
						array[6] = 0;
						array[7] = 1;
						fIUsbController5.WriteToEEPROM(1, 81, 8, 0, ref array[0], ref lErrCode);
					}
					else
					{
						array[0] = 176;
						array[1] = 109;
						array[2] = 17;
						array[3] = 1;
						array[4] = 0;
						array[5] = 1;
						array[6] = 0;
						fIUsbController5.WriteToEEPROM(1, 81, 7, 0, ref array[0], ref lErrCode);
					}
					if (lErrCode == 0)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					else
					{
						ab8().c(fz.b.a, "Error attempting to write USBController firmware preliminary");
					}
					fIUsbController5.Shutdown();
					fIUsbController5.WriteFirmware(ref lErrCode);
					if (lErrCode == 0)
					{
						string text = h5.m2(empty);
						if (File.Exists(text))
						{
							File.Copy(text, h5.m2(fIUsbController5.SerialNumber), overwrite: true);
						}
						if (fIUsbController5.FWInstTypeCodeAsEnum != fWInstTypeCodeAsEnum)
						{
							lErrCode = fIUsbController5.ResetMicro();
							if (lErrCode != 0)
							{
								ab8().c(fz.b.a, "Error attempting to ResetMicro after write USBController firmware. Error code=" + lErrCode);
							}
						}
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					else
					{
						ab8().c(fz.b.a, "Error attempting to write USBController firmware");
					}
					mb.Add(empty);
					q9 = null;
					break;
				}
				case m.a.u:
				{
					int num48 = iq[0][0].abk().ReadGenIO(out a10.t);
					if (num48 == 0 && iq[0][0].xv())
					{
						bool A_34 = default(bool);
						num48 = iq[0][0].m2(ref A_34);
						if (A_34)
						{
							a10.t |= 2;
						}
						else
						{
							a10.t &= 253;
						}
					}
					if (num48 == 0)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					else
					{
						ab8().c(fz.b.a, "Error attempting to read GenIO bits");
					}
					_ = null;
					break;
				}
				case m.a.v:
				{
					q q7 = A_0;
					int num19 = iq[0][0].abk().WriteGenIO(q7.a9);
					if (num19 == 0 && iq[0][0].xv())
					{
						num19 = iq[0][0].tg((q7.a9 & 2) != 0);
					}
					if (num19 == 0)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
						lb = true;
						lc = q7.a9;
					}
					else
					{
						ab8().c(fz.b.a, "Error attempting to write GenIO bits");
					}
					q7 = null;
					break;
				}
				case m.a.a2:
				{
					ha ha2 = new ha();
					ha ha3 = ha2;
					FIUsbController fIUsbController3 = iq[A_0.a6][p9(A_0.a6, A_0.a7)].abk();
					int num20 = fIUsbController3.LsTemperature(out ha3.c);
					int tachEnabled = default(int);
					int fanTurning = default(int);
					if (num20 == 0)
					{
						num20 = fIUsbController3.GetFanStatus(out tachEnabled, out fanTurning, out ha3.f);
					}
					ha3.a = ix[A_0.a6];
					ha3.b = A_0.a7;
					a10.d = ha2;
					if (num20 == 0)
					{
						ha3.d = tachEnabled != 0;
						ha3.e = fanTurning != 0;
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					ha3 = null;
					break;
				}
				case m.a.ay:
				{
					q q4 = A_0;
					int num12 = im.qh(q4.be);
					if (im.aby() && num12 == 0)
					{
						ushort a_4 = unchecked((ushort)(q4.be ? 256 : 0));
						num12 = im.m2(0, a_4);
					}
					if (num12 == 0)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					else
					{
						a10.d = RuntimeHelpers.GetObjectValue(A_0.j);
					}
					q4 = null;
					break;
				}
				case m.a.a0:
				{
					q q6 = A_0;
					a10.d = RuntimeHelpers.GetObjectValue(A_0.j);
					iq[q6.a6][p9(q6.a6, q6.a7)].tl(q6.be);
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					q6 = null;
					break;
				}
				case m.a.az:
					if (im.m2(m2(A_0.bf)) == 0)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					else
					{
						a10.d = RuntimeHelpers.GetObjectValue(A_0.j);
					}
					break;
				case m.a.a1:
					if (im.m2((byte)A_0.bg, m2(A_0.bg, A_0.bf)) == 0)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					else
					{
						a10.d = RuntimeHelpers.GetObjectValue(A_0.j);
					}
					_ = null;
					break;
				case m.a.a4:
					l8 = (g6)A_0.j;
					if (iq != null)
					{
						int num38 = iq.Length - 1;
						for (int num39 = 0; num39 <= num38; num39++)
						{
							if (iq[num39] != null)
							{
								int num40 = iq[num39].Count - 1;
								for (int num41 = 0; num41 <= num40; num41++)
								{
									iq[num39][num41].s3(l8.e());
								}
							}
						}
					}
					tj();
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				case m.a.a5:
				{
					bool flag4 = true;
					Exception ex2 = null;
					List<ip> list2 = new List<ip>();
					bool flag5 = default(bool);
					try
					{
						_ = DateTime.Now;
						hr A_25 = null;
						if (mz == null)
						{
							mz = new List<bool[]>();
						}
						bool A_26 = default(bool);
						bool A_27 = default(bool);
						bool A_28 = default(bool);
						bool A_29 = default(bool);
						bool A_30 = default(bool);
						m2(ab8(), A_0.d3(), 200, ref A_26, ref A_27, ref A_28, ref A_29, ref A_30);
						try
						{
							int num42 = iq.Length - 1;
							bool A_31 = default(bool);
							bool A_32 = default(bool);
							for (int num43 = 0; num43 <= num42; num43++)
							{
								if (mz.Count <= num43)
								{
									mz.Add(new bool[iq[num43].Count - 1 + 1]);
								}
								int num44 = iq[num43].Count - 1;
								for (int num45 = 0; num45 <= num44; num45++)
								{
									ip ip9 = iq[num43][num45];
									if (p9(hc.b8(), num45, num43, A_3: true) && s8(num43, num45) && !mz[num43][num45])
									{
										list2.Add(ip9);
										global::r.c a_11 = A_0.h;
										global::r.d.a.b a_12 = A_0.d3();
										UVSource a_13 = ij;
										hr A_21 = null;
										hr A_20 = null;
										m2(a_11, a_12, ip9, a_13, 1500f, A_5: true, A_6: true, 8, ref A_31, ref A_32, ref A_21, ref A_20, ref A_25);
										if (A_31 || A_32)
										{
											flag4 = false;
											if (A_32)
											{
												flag5 = true;
											}
										}
										else
										{
											double[] a_14 = A_25.cv();
											ip.o A_33 = null;
											int num46 = ip9.m2(a_14, ref A_33);
											if (num46 == 0)
											{
												mz[num43][num45] = true;
												list2.Remove(ip9);
											}
											else
											{
												ab8().c(fz.b.a, "Error attempting TaskId.UpdateWavelengthOffset. Error is " + num46);
											}
										}
									}
									_ = null;
								}
							}
						}
						finally
						{
							m2(ab8(), A_26, A_30, 200, A_0.d3(), A_27, A_28, A_29);
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ab8().c(fz.b.b, "Error in TaskCoreSpectrometerNonAcquire.UpdateWavelenCalAuto. ", ex4);
						flag4 = false;
						ex2 = ex4;
						ProjectData.ClearProjectError();
					}
					if (flag4 || l8.d() == global::g6.a.b || my == 2 || ex2 != null)
					{
						if (flag4)
						{
							ul();
							((global::r.d.a)a10).a = global::r.d.a.a.a;
						}
						else if (ex2 != null)
						{
							ab8().c(fz.b.a, "Automatic wavelength calibration failed due to exception.", ex2);
						}
						else if (l8.d() == global::g6.a.b)
						{
							if (flag5)
							{
								ab8().c(fz.b.a, "Automatic wavelength calibration skipped due to saturation - occasional errors of this type are normal.");
							}
							else
							{
								ab8().c(fz.b.a, "Automatic wavelength calibration skipped due to a failure.");
							}
						}
						else
						{
							ab8().c(fz.b.a, "Automatic wavelength calibration skipped due to " + 3 + " successive failures.");
						}
						if (list2.Count > 0 && l8.d() == global::g6.a.a)
						{
							foreach (ip item3 in list2)
							{
								item3.v7 = DateTime.UtcNow;
							}
						}
						my = 0;
						mz = null;
						if (l8.d() == global::g6.a.a)
						{
							tj();
						}
					}
					else
					{
						my++;
						ab8().c(fz.b.a, "Automatic wavelength calibration aborted due to instability, calibration immediately reattempted");
						p9();
					}
					break;
				}
				case m.a.a6:
				{
					int upperBound3 = iq.GetUpperBound(0);
					bool A_24 = default(bool);
					for (int num35 = 0; num35 <= upperBound3; num35++)
					{
						if (!p9(hc.b8(), num35, n.i, A_3: true, A_4: true))
						{
							continue;
						}
						int num36 = iq[num35].Count - 1;
						for (int num37 = 0; num37 <= num36; num37++)
						{
							if (im != null && !iq[num35][num37].aby())
							{
								iq[num35][num37].m2(im, A_0.h, A_2: false, A_0.d3(), ref A_24);
								break;
							}
						}
						if (A_24 || A_0.h.a)
						{
							break;
						}
					}
					if (A_24)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					break;
				}
				case m.a.bw:
				{
					int upperBound2 = iq.GetUpperBound(0);
					bool flag3 = default(bool);
					for (int num21 = 0; num21 <= upperBound2; num21++)
					{
						if (!p9(hc.b8(), num21, n.i, A_3: true, A_4: true))
						{
							continue;
						}
						int num22 = iq[num21].Count - 1;
						for (int num23 = 0; num23 <= num22; num23++)
						{
							if (im != null)
							{
								a10.d = iq[num21][num23].m2(im, A_0.h, A_0.d3());
								((global::r.d.a)a10).a = global::r.d.a.a.a;
								flag3 = true;
								break;
							}
						}
					}
					if (!flag3)
					{
						ab8().c(fz.b.a, "Attempted CheckLightFromInternalSource, but there is no internal source");
					}
					break;
				}
				case m.a.a7:
				{
					bool a_3 = default(bool);
					if (A_0.bh || !global::e.a().LightSourceAutoStandby)
					{
						a_3 = !im.zm();
					}
					else
					{
						if (im.m2((float)(0.01 * (double)A_0.bf)))
						{
							if (!im.zm())
							{
								a_3 = true;
							}
							im.m2(A_0.bf / 2f, a_3, A_2: false);
						}
						a_3 = false;
					}
					im.m2(A_0.bf, a_3, !A_0.bh);
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				}
				case m.a.a8:
				{
					q q3 = A_0;
					if (iq[q3.a6][p9(q3.a6, q3.a7)].abk().SetFanState(unchecked(0 - (q3.be ? 1 : 0))) == 0)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					else
					{
						a10.d = RuntimeHelpers.GetObjectValue(A_0.j);
					}
					q3 = null;
					break;
				}
				case m.a.ba:
				{
					new hr(hc.dh().aw());
					ip ip8 = m2(A_0.bi, A_0.a6, A_0.a7);
					bool A_22 = default(bool);
					bool A_23 = default(bool);
					if (ip8.m2(ref A_22, ref A_23, xo(), 1, ref A_0.h, A_0.d3(), jk, A_7: false, 0.0, A_9: false, A_10: false, 0, A_12: false, 0.0, 0) != f0.FIDeviceErr.None)
					{
						ab8().c(fz.b.b, "Failure in Case Task.TaskId.UpdateBaselineSpecLin when attempting AcquireAndRetrieveSpectrumSmoothed");
						break;
					}
					if (A_22)
					{
						ab8().c(fz.b.b, "ZeroError in Case Task.TaskId.UpdateBaselineSpecLin when attempting AcquireAndRetrieveSpectrumSmoothed");
						break;
					}
					if (A_23)
					{
						ab8().c(fz.b.b, "satErr in Case Task.TaskId.UpdateBaselineSpecLin when attempting AcquireAndRetrieveSpectrumSmoothed");
						break;
					}
					ip8.m2(ip8.uk() + "lastBaselineLinearitySpecRaw.csv", ll);
					ip8.m2(Conversions.ToString(A_0.j), jk, hc.d0().c() == g2.a.b);
					up();
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				}
				case m.a.bb:
					a10.d = global::im.a(m2(A_0.bi, A_0.a6, unchecked((int)A_0.a7)));
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				case m.a.bc:
					unchecked
					{
						global::im.a(m2(A_0.bi, A_0.a6, (int)A_0.a7), (im.a)Conversions.ToInteger(A_0.j));
						((global::r.d.a)a10).a = global::r.d.a.a.a;
						break;
					}
				case m.a.bd:
				{
					q q8 = A_0;
					h6.c c10 = (h6.c)q8.a8;
					FIUsbController fIUsbController4 = (c10.b2 ? m2(q8.bi, q8.a6, q8.a7).abk() : ((!c10.b4) ? i0.abk() : @is[c10.b5].abk()));
					double rtcTime = DateTime.UtcNow.AddSeconds(75149736.0).ToOADate();
					if (fIUsbController4.SetRtcTime(rtcTime) == 0)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					q8 = null;
					break;
				}
				case m.a.bf:
				{
					float onTimeHrs;
					if (ij != null)
					{
						UVSource uVSource = ij;
						uint eventCount = 0u;
						uint eventCountRemaining = 0u;
						float onTimeRemainingHrs = 0f;
						if (uVSource.GetLampOnTime(0, out onTimeHrs, out eventCount, out eventCountRemaining, out onTimeRemainingHrs) == 0L)
						{
							a10.k = onTimeHrs;
							UVSource uVSource2 = ij;
							eventCountRemaining = 0u;
							eventCount = 0u;
							onTimeRemainingHrs = 0f;
							if (uVSource2.GetLampOnTime(1, out onTimeHrs, out eventCountRemaining, out eventCount, out onTimeRemainingHrs) == 0L)
							{
								a10.l = onTimeHrs;
								((global::r.d.a)a10).a = global::r.d.a.a.a;
							}
						}
						break;
					}
					FIUsbController fIUsbController2 = tl();
					if (fIUsbController2 != null)
					{
						uint eventCount = 0u;
						uint eventCountRemaining = 0u;
						float onTimeRemainingHrs = 0f;
						if (fIUsbController2.ReadLightSourceOnTime(out onTimeHrs, out eventCount, out eventCountRemaining, out onTimeRemainingHrs) == 0L)
						{
							a10.k = onTimeHrs;
							((global::r.d.a)a10).a = global::r.d.a.a.a;
						}
					}
					break;
				}
				case m.a.bg:
				{
					FIUsbController fIUsbController = tl();
					if (fIUsbController != null && fIUsbController.ResetLightSourceOnTime() == 0L)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					break;
				}
				case m.a.bi:
				{
					ip obj = m2(A_0.bi, A_0.a6, A_0.a7);
					float A_2 = default(float);
					int num7 = obj.p9(ref A_2);
					obj.un();
					if (num7 == 0)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
						a10.d = A_2;
					}
					else
					{
						ab8().c(fz.b.a, "Error attempting to calibrate TEC Supply Pot Max R. Error is " + num7);
					}
					break;
				}
				case m.a.bj:
				{
					int num5 = m2(A_0.bi, A_0.a6, A_0.a7).m2(Conversions.ToSingle(A_0.j));
					if (num5 == 0)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					else
					{
						ab8().c(fz.b.a, "Error attempting to set TEC setpoint. Error is " + num5);
					}
					break;
				}
				case m.a.br:
				{
					hb hb2 = new hb();
					hb hb3 = hb2;
					hb3.m = ((IUVSource)ij).get_HasLampOnTimer(0) != 0;
					hb3.n = ((IUVSource)ij).get_HasLampOnTimer(1) != 0;
					hb3.o = ij.SystemSubtype == FMUVSourceSubTypes.kFMUVSourceSubtypeDT2;
					int num26 = ij.GetStatus(ref hb3.a, ref hb3.d, ref hb3.b, ref hb3.e, ref hb3.f, ref hb3.c);
					if (num26 == 0)
					{
						num26 = ij.GetShutterStatus(ref hb3.g);
					}
					if (num26 == 0)
					{
						num26 = ij.GetFPDisableStatus(ref hb3.h);
					}
					uint eventCount2;
					uint eventCountRemaining2;
					float onTimeRemainingHrs2;
					if (num26 == 0 && hb3.m)
					{
						num26 = ij.GetLampOnTime(0, out hb3.k, out eventCount2, out eventCountRemaining2, out onTimeRemainingHrs2);
					}
					if (num26 == 0 && hb3.n)
					{
						num26 = ij.GetLampOnTime(1, out hb3.l, out eventCount2, out eventCountRemaining2, out onTimeRemainingHrs2);
					}
					if (num26 == 0 && hb3.m && hb3.n)
					{
						num26 = ij.GetFanStatus(out hb3.i, out hb3.j);
					}
					hb3 = null;
					if (num26 == 0)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
						a10.d = hb2;
					}
					break;
				}
				case m.a.bs:
					if (ij.ResetLampOnTime(0) == 0)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					break;
				case m.a.bt:
					if (ij.ResetLampOnTime(1) == 0)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					break;
				case m.a.bu:
				{
					if (ip == null)
					{
						((global::r.d.a)a10).b = "No light source is present";
						break;
					}
					if (iq == null || iq[0] == null || iq[0].Count == 0)
					{
						((global::r.d.a)a10).b = "No spectrometer is present";
						break;
					}
					ip ip6 = iq[0][p9(0, global::f.b.b)];
					int shutterIsOpen = default(int);
					int shutterStatus = ij.GetShutterStatus(ref shutterIsOpen);
					if (shutterStatus != 0)
					{
						ab8().c(fz.b.a, "Error attempting to check shutter status in UVLightSourceShutterTest. Error code=" + shutterStatus);
						((global::r.d.a)a10).b = "Error checking shutter status";
						break;
					}
					if (shutterIsOpen == 0)
					{
						m2(A_0: true, 200, a10);
					}
					else
					{
						m2(A_0: true, 0, a10);
					}
					if (!string.IsNullOrEmpty(((global::r.d.a)a10).b))
					{
						break;
					}
					UVSource uVSource3 = ij;
					int upperBound = 0;
					int num3 = 0;
					int num = 0;
					int d2LampIsWarmingUp = 0;
					int d2LampIsOn = default(int);
					int thLampIsOn = default(int);
					shutterStatus = uVSource3.GetStatus(ref d2LampIsOn, ref thLampIsOn, ref upperBound, ref num3, ref num, ref d2LampIsWarmingUp);
					if (d2LampIsOn == 0 && thLampIsOn == 0)
					{
						shutterStatus = ij.SetTHLampState(-1);
						if (shutterStatus != 0)
						{
							ab8().c(fz.b.a, "Error attempting to check lamp status in UVLightSourceShutterTest. Error code=" + shutterStatus);
							((global::r.d.a)a10).b = "Error checking lamp status";
							break;
						}
						Thread.Sleep(5000);
						UVSource uVSource4 = ij;
						d2LampIsWarmingUp = 0;
						num = 0;
						num3 = 0;
						upperBound = 0;
						shutterStatus = uVSource4.GetStatus(ref d2LampIsOn, ref thLampIsOn, ref d2LampIsWarmingUp, ref num, ref num3, ref upperBound);
						if (shutterStatus != 0 || thLampIsOn == 0)
						{
							if (shutterStatus != 0)
							{
								ab8().c(fz.b.a, "Error attempting to check lamp status #2 in UVLightSourceShutterTest. Error code=" + shutterStatus);
								((global::r.d.a)a10).b = "Error checking lamp status #2";
							}
							else
							{
								ab8().c(fz.b.a, "Failure to energize THLamp - possible lamp burnout");
								((global::r.d.a)a10).b = "THLamp Failure";
							}
							break;
						}
					}
					else
					{
						if (d2LampIsOn != 0)
						{
							shutterStatus = ij.SetD2LampState(d2LampIsOn);
							if (shutterStatus != 0)
							{
								ab8().c(fz.b.a, "Error attempting to lock state of d2Lamp On. Error code=" + shutterStatus);
								((global::r.d.a)a10).b = "Error attempting to lock d2 Lamp On";
								break;
							}
						}
						if (thLampIsOn != 0)
						{
							shutterStatus = ij.SetTHLampState(thLampIsOn);
							if (shutterStatus != 0)
							{
								ab8().c(fz.b.a, "Error attempting to lock state of THLamp On. Error code=" + shutterStatus);
								((global::r.d.a)a10).b = "Error attempting to lock TH Lamp On";
								break;
							}
						}
					}
					shutterStatus = ij.SetFrontPanelDisable(-1);
					if (shutterStatus != 0)
					{
						ab8().c(fz.b.a, "Error attempting to disable light source front panel controls. Error code=" + shutterStatus);
						((global::r.d.a)a10).b = "Error attempting to disable front panel controls";
						break;
					}
					double num14 = ip6.vm() / 2.0;
					bool A_10 = default(bool);
					double A_11 = default(double);
					do
					{
						num14 *= 2.0;
						m2(ip6, num14, A_0, a10, ref A_10, ref A_11);
						if (!string.IsNullOrEmpty(((global::r.d.a)a10).b))
						{
							return;
						}
					}
					while (!A_10 && !(A_11 > 1000.0) && !(num14 > 100.0));
					if (!A_10 && A_11 < 1000.0)
					{
						ab8().c(fz.b.a, "Insufficient signal detected in UVLightSourceShutterTest. Target=" + 1000.0 + ", peakInten=" + A_11);
						((global::r.d.a)a10).b = "Insufficient signal detected - please check connections";
						break;
					}
					double num15 = A_11;
					m2(A_0: false, 200, a10);
					if (!string.IsNullOrEmpty(((global::r.d.a)a10).b))
					{
						break;
					}
					m2(ip6, num14, A_0, a10, ref A_10, ref A_11);
					if (!string.IsNullOrEmpty(((global::r.d.a)a10).b))
					{
						break;
					}
					if (A_11 > num15 * 0.5)
					{
						ab8().c(fz.b.a, "Insufficient change when shutter closed. Target=" + num15 * 0.5 + ", peakInten=" + A_11);
						((global::r.d.a)a10).b = "Insufficient change when shutter closed - please check connections and test shutter function";
						break;
					}
					d obj6 = (d)A_0.j;
					int num16 = obj6.a;
					int millisecondsTimeout = (int)Math.Round(obj6.b * 1000f);
					_ = null;
					int num17 = 0;
					do
					{
						A_0.h.t("Testing iteration #" + (num17 + 1));
						m2(A_0: true, 30, a10);
						Thread.Sleep(millisecondsTimeout);
						if (!string.IsNullOrEmpty(((global::r.d.a)a10).b))
						{
							return;
						}
						int num18 = 0;
						do
						{
							m2(ip6, num14, A_0, a10, ref A_10, ref A_11);
							if (!string.IsNullOrEmpty(((global::r.d.a)a10).b))
							{
								return;
							}
							num18++;
						}
						while (num18 < 2 && A_11 < num15 * 0.6000000238418579);
						if (A_11 < num15 * 0.6000000238418579)
						{
							ab8().c(fz.b.a, "Insufficient signal detected in UVLightSourceShutterTest. Target=" + num15 * 0.6000000238418579 + ", peakInten=" + A_11 + ". Failed with shutter closed after " + num17 + " cycles");
							((global::r.d.a)a10).b = "Insufficient signal detected - apparent failure with shutter closed after " + num17 + " cycles";
							return;
						}
						m2(A_0: false, 30, a10);
						Thread.Sleep(millisecondsTimeout);
						if (!string.IsNullOrEmpty(((global::r.d.a)a10).b))
						{
							return;
						}
						num18 = 0;
						do
						{
							m2(ip6, num14, A_0, a10, ref A_10, ref A_11);
							if (!string.IsNullOrEmpty(((global::r.d.a)a10).b))
							{
								return;
							}
							num18++;
						}
						while (num18 < 2 && A_11 > num15 * 0.550000011920929);
						if (A_11 > num15 * 0.550000011920929)
						{
							ab8().c(fz.b.a, "Excess signal detected in UVLightSourceShutterTest. Target=" + num15 * 0.550000011920929 + ", peakInten=" + A_11 + ". Failed with shutter open after " + num17 + " cycles");
							((global::r.d.a)a10).b = "Excess signal detected - apparent failure with shutter open after " + num17 + " cycles";
							return;
						}
						num17++;
						A_0.h.t((float)((double)num17 / (double)num16 * 100.0));
					}
					while (!A_0.h.a && num17 < num16);
					A_0.h.z();
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				}
				case m.a.bv:
				{
					int num6 = ij.SetFrontPanelDisable(0);
					if (num6 != 0)
					{
						ab8().c(fz.b.a, "Error attempting to enable light source front panel controls. Error code=" + num6);
						if (string.IsNullOrEmpty(((global::r.d.a)a10).b))
						{
							((global::r.d.a)a10).b = "Error attempting to enable light source front panel controls";
						}
					}
					num6 = ij.SetTHLampState(0);
					if (num6 != 0)
					{
						ab8().c(fz.b.a, "Error attempting to turn off THLamp. Error code=" + num6);
						if (string.IsNullOrEmpty(((global::r.d.a)a10).b))
						{
							((global::r.d.a)a10).b = "Error attempting to turn off THLamp";
						}
					}
					num6 = ij.SetD2LampState(0);
					if (num6 != 0)
					{
						ab8().c(fz.b.a, "Error attempting to turn off D2Lamp. Error code=" + num6);
						if (string.IsNullOrEmpty(((global::r.d.a)a10).b))
						{
							((global::r.d.a)a10).b = "Error attempting to turn off D2Lamp";
						}
					}
					num6 = ij.SetShutterState(0);
					if (num6 != 0)
					{
						ab8().c(fz.b.a, "Error attempting to close shutter. Error code=" + num6);
						if (string.IsNullOrEmpty(((global::r.d.a)a10).b))
						{
							((global::r.d.a)a10).b = "Error attempting to close shutter";
						}
					}
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				}
				case m.a.bx:
				{
					if (hc.d0().c() != g2.a.n)
					{
						break;
					}
					((global::r.d.a)a10).b = "Failed attempting to update Dual Shutter state";
					int upperBound = iq.GetUpperBound(0);
					for (int num2 = 0; num2 <= upperBound; num2++)
					{
						bool flag = false;
						int num3 = iq[num2].Count - 1;
						for (int num4 = 0; num4 <= num3; num4++)
						{
							if (p9(hc.b8(), num4, num2))
							{
								ip ip2 = iq[num2][num4];
								ip ip3 = ip2;
								if (ip3.m2(p9(ip2)) && ip3.wt())
								{
									bool flag2 = !ip3.ws();
									ik.d(flag2, !flag2);
									flag = true;
									break;
								}
								ip3 = null;
							}
						}
						if (flag)
						{
							break;
						}
					}
					((global::r.d.a)a10).b = null;
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				}
				case m.a.by:
				{
					((global::r.d.a)a10).b = "Failed attempting to set Dual Shutter state";
					g4 g10 = (g4)A_0.j;
					ik.d(g10.a, g10.b);
					g10 = null;
					((global::r.d.a)a10).b = null;
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				}
				case m.a.b4:
					m2(A_0);
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				default:
				{
					int num = unchecked((int)((m)A_0).a);
					throw new ArgumentOutOfRangeException("Unknown Task.ID in TaskCoreSpectrometerNonAcquire. Task.Id=" + num);
				}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ab8().c(fz.b.b, "Error in TaskCoreSpectrometerNonAcquire. Task ID=" + ((m)A_0).a, ex6);
				if (((m)A_0).a == m.a.u && ex6 is NullReferenceException)
				{
					a10.d = ex6;
					ab8().c(fz.b.b, "Null reference in ReadInput -- Will stop ReadInput timer");
				}
				ProjectData.ClearProjectError();
			}
			finally
			{
				A_0.g.d(gt, a10);
			}
		}
	}

	private void m2(fz A_0, global::r.d.a.b A_1, int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7)
	{
		if (ij == null)
		{
			return;
		}
		int shutterIsOpen = default(int);
		ij.GetShutterStatus(ref shutterIsOpen);
		A_3 = shutterIsOpen != 0;
		if (!A_3)
		{
			return;
		}
		shutterIsOpen = ij.ShutterOpenRequestedViaUSB;
		A_4 = shutterIsOpen != 0;
		int frontPanelIsDisabled = default(int);
		int fPDisableStatus = ij.GetFPDisableStatus(ref frontPanelIsDisabled);
		if (fPDisableStatus != 0)
		{
			A_0.c(fz.b.b, "Error getting FP Disable Status in CloseShutterIfPossible(). Error code=" + fPDisableStatus);
			return;
		}
		A_7 = frontPanelIsDisabled != 0;
		if (!A_7)
		{
			int d2LampOnRequestedViaUSB = ij.D2LampOnRequestedViaUSB;
			A_5 = d2LampOnRequestedViaUSB != 0;
			d2LampOnRequestedViaUSB = ij.THLampOnRequestedViaUSB;
			A_6 = d2LampOnRequestedViaUSB != 0;
			UVSource uVSource = ij;
			int d2LampFault = 0;
			int thLampBurnedOut = 0;
			int overTemperature = 0;
			int d2LampIsWarmingUp = 0;
			int thLampIsOn = default(int);
			fPDisableStatus = uVSource.GetStatus(ref d2LampOnRequestedViaUSB, ref thLampIsOn, ref d2LampFault, ref thLampBurnedOut, ref overTemperature, ref d2LampIsWarmingUp);
			if (fPDisableStatus != 0)
			{
				A_0.c(fz.b.b, "Error getting mUVLightSource Status in CloseShutterIfPossible(). Error code=" + fPDisableStatus);
				return;
			}
			if (d2LampOnRequestedViaUSB != 0)
			{
				fPDisableStatus = ij.SetD2LampState(d2LampOnRequestedViaUSB);
				if (fPDisableStatus != 0)
				{
					A_0.c(fz.b.b, "Error setting D2 Lamp State in CloseShutterIfPossible(). Error code=" + fPDisableStatus);
					return;
				}
			}
			if (thLampIsOn != 0)
			{
				fPDisableStatus = ij.SetTHLampState(thLampIsOn);
				if (fPDisableStatus != 0)
				{
					A_0.c(fz.b.b, "Error setting TH Lamp State in CloseShutterIfPossible(). Error code=" + fPDisableStatus);
					return;
				}
			}
			fPDisableStatus = ij.SetFrontPanelDisable(1);
			if (fPDisableStatus != 0)
			{
				A_0.c(fz.b.b, "Error setting TH Lamp State in CloseShutterIfPossible(). Error code=" + fPDisableStatus);
				return;
			}
		}
		if (!A_7 || A_4)
		{
			m2(A_0: false, A_2, new global::r.d.a(A_1, 0L));
		}
	}

	private void m2(fz A_0, bool A_1, bool A_2, int A_3, global::r.d.a.b A_4, bool A_5, bool A_6, bool A_7)
	{
		if (!A_1)
		{
			return;
		}
		if (A_2)
		{
			if (A_5)
			{
				m2(A_0: true, A_3, new global::r.d.a(A_4, 0L));
			}
			return;
		}
		if (A_5)
		{
			m2(A_0: true, 0, new global::r.d.a(A_4, 0L));
		}
		int num = ij.SetFrontPanelDisable(0);
		if (num != 0)
		{
			A_0.c(fz.b.b, "Error clearing FP Disable in RestoreOriginalShutterState(). Error code=" + num);
			return;
		}
		Thread.Sleep(A_3);
		if (!A_6)
		{
			num = ij.SetD2LampState(0);
			if (num != 0)
			{
				A_0.c(fz.b.b, "Error clearing D2 Lamp State in RestoreOriginalShutterState(). Error code=" + num);
				return;
			}
		}
		if (!A_7)
		{
			num = ij.SetTHLampState(0);
			if (num != 0)
			{
				A_0.c(fz.b.b, "Error clearing TH Lamp State in RestoreOriginalShutterState(). Error code=" + num);
			}
		}
	}

	private void m2(ip A_0, double A_1, m A_2, global::r.d.a A_3, ref bool A_4, ref double A_5)
	{
		hr A_6 = new hr(null);
		bool A_7 = default(bool);
		ErrPublic errPublic = m2(A_0, ref A_7, ref A_4, ref A_6, 0, A_1, 1, ref A_2.h, A_2.d3());
		if (errPublic != ErrPublic.None)
		{
			ab8().c(fz.b.a, "Error attempting to acquire spectrum. Error code=" + errPublic);
			A_3.b = "Error attempting to acquire spectrum";
			return;
		}
		double[] array = A_6.c0();
		A_5 = 0.0;
		checked
		{
			int num = array.Length - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (array[num2] > A_5)
				{
					A_5 = array[num2];
				}
			}
		}
	}

	private void m2(bool A_0, int A_1, global::r.d.a A_2)
	{
		int num = ij.SetShutterState(0 - (A_0 ? 1 : 0));
		if (num != 0)
		{
			ab8().c(fz.b.a, "Error attempting to set shutter state. Error code=" + num);
			if (A_2 != null)
			{
				A_2.b = "Error opening or closing shutter";
			}
		}
		else
		{
			Thread.Sleep(A_1);
		}
	}

	private void sj(bool A_0)
	{
		if (A_0)
		{
			bool num = il.d();
			il.b();
			if (!num)
			{
				m2(A_0: true, 200, null);
			}
		}
		else
		{
			il.c();
			if (!il.d())
			{
				m2(A_0: false, 200, null);
			}
		}
	}

	[SpecialName]
	private FIUsbController m2(h6.b A_0, int A_1, int A_2)
	{
		if (i0 != null)
		{
			return i0.abk();
		}
		if (A_0 == h6.b.b && iq != null && iq.Length > A_1 && iq[A_1].Count > A_2)
		{
			return iq[A_1][A_2].abk();
		}
		return null;
	}

	private void tj()
	{
		if (iq == null)
		{
			return;
		}
		g6 g10 = l8;
		checked
		{
			if (g10.e())
			{
				int num = iq.Length - 1;
				double totalMilliseconds = default(double);
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (iq[num2] == null)
					{
						continue;
					}
					int num3 = iq[num2].Count - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						ip ip2 = iq[num2][num4];
						if (p9(hc.b8(), num4, num2, A_3: true) && s8(num2, num4) && (DateTime.Compare(ip2.v7, DateTime.MinValue) == 0 || g10.d() == global::g6.a.a))
						{
							if (g10.d() == global::g6.a.a)
							{
								totalMilliseconds = ip2.v7.AddMinutes(g10.f()).Subtract(DateTime.UtcNow).TotalMilliseconds;
							}
							if (DateTime.Compare(ip2.v7, DateTime.MinValue) == 0 || totalMilliseconds <= 0.0 || totalMilliseconds > (double)(g10.f() * 60f * 1000f))
							{
								p9();
								return;
							}
							if (g10.d() == global::g6.a.a)
							{
								ux().Interval = totalMilliseconds;
								ux().AutoReset = false;
								ux().Start();
								return;
							}
						}
					}
				}
			}
			g10 = null;
		}
	}

	private short m2(float A_0, double A_1, bool A_2, int A_3)
	{
		checked
		{
			short num = (short)Math.Round((double)A_0 / A_1);
			if (A_2 && num > A_3)
			{
				num = (short)A_3;
			}
			if (num < 1)
			{
				num = 1;
			}
			return num;
		}
	}

	private void m2(bool A_0, global::r.c A_1, global::r.d.a.b A_2, ip A_3, float A_4, bool A_5, int A_6, ref hr A_7, ref bool A_8)
	{
		A_8 = false;
		A_3.tl(A_0: true);
		try
		{
			bool A_9 = default(bool);
			bool A_10 = default(bool);
			if (A_0)
			{
				ErrPublic errPublic = m2(A_3, 1f, ref A_9, ref A_10, A_4: false, 0f, null, n.f, A_1, A_2, 0, A_11: true, A_12: false);
				if (errPublic != ErrPublic.None)
				{
					throw new ai("Autoscale Int Time error in AcquireCalibrationSpectrum. Error =" + errPublic);
				}
				if (A_9)
				{
					throw new ai("Sat Error in AcquireCalibrationSpectrum during Autoscale");
				}
				if (A_10)
				{
					throw new ai("Zero Error in AcquireCalibrationSpectrum during Autoscale");
				}
			}
			A_7 = new hr(null);
			short a_ = m2(A_4, A_3.u9(), A_5, A_6);
			if (m2(A_3, ref A_10, ref A_9, ref A_7, 1, A_3.u9(), a_, ref ja, A_2) != ErrPublic.None)
			{
				throw new ai("Error attempting to acquire spectrum for wavelength calibration in AcquireCalibrationSpectrum");
			}
			if (A_9)
			{
				A_8 = true;
			}
			else if (A_10)
			{
				throw new ai("Zero Error in AcquireCalibrationSpectrum");
			}
		}
		finally
		{
			A_3.tl(A_0: false);
		}
	}

	private void m2(global::r.c A_0, global::r.d.a.b A_1, ip A_2, UVSource A_3, float A_4, ref bool A_5, ref hr A_6, ref hr A_7, ref hr A_8)
	{
		bool A_9 = false;
		bool A_10 = false;
		m2(A_0, A_1, A_2, A_3, A_4, A_5: false, A_6: false, 0, ref A_9, ref A_10, ref A_6, ref A_7, ref A_8);
	}

	private void m2(global::r.c A_0, global::r.d.a.b A_1, ip A_2, UVSource A_3, float A_4, bool A_5, int A_6, ref bool A_7, ref hr A_8, ref hr A_9, ref hr A_10)
	{
		bool A_11 = false;
		bool A_12 = false;
		m2(A_0, A_1, A_2, A_3, A_4, A_5: false, A_5, A_6, ref A_11, ref A_12, ref A_8, ref A_9, ref A_10);
	}

	private void m2(global::r.c A_0, global::r.d.a.b A_1, ip A_2, UVSource A_3, float A_4, bool A_5, bool A_6, int A_7, ref bool A_8, ref bool A_9, ref hr A_10, ref hr A_11, ref hr A_12)
	{
		double a_ = A_2.u9();
		checked
		{
			try
			{
				A_2.wz();
				A_8 = false;
				float a_2;
				float a_3;
				if (A_5)
				{
					a_2 = 0f;
					a_3 = A_4 / 2f;
				}
				else
				{
					a_2 = A_4;
					a_3 = A_4;
				}
				bool A_13 = default(bool);
				m2(A_0: true, A_0, A_1, A_2, a_2, A_5: true, 1, ref A_10, ref A_13);
				if (A_13)
				{
					A_9 = true;
					return;
				}
				double num = A_2.u9();
				A_11 = new hr(null);
				bool A_14 = default(bool);
				bool A_15 = default(bool);
				if (m2(A_2, ref A_14, ref A_15, ref A_11, 1, num, 1, ref ja, A_1) != ErrPublic.None)
				{
					throw new ai("Error attempting to acquire spectrum for wavelength calibration");
				}
				if (A_15)
				{
					throw new ai("Sat Error in AcquireCalibrationSpectra during background acquire");
				}
				if (A_14)
				{
					throw new ai("Zero Error in AcquireCalibrationSpectra during background acquire");
				}
				double[] array = A_10.c0();
				double[] array2 = A_11.c0();
				double num2 = double.MinValue;
				int num3 = array2.Length - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					double num5 = array[num4] - array2[num4];
					if (num5 > num2)
					{
						num2 = num5;
					}
				}
				if (num2 < 100.0)
				{
					throw new ai("Calibration light signal too dim. Wavelength calibration aborted. T Int=" + num.ToString("0.00") + ", peak intensity=" + num2.ToString("0.0"));
				}
				if (num2 < 500.0)
				{
					A_7 *= 4 * (int)Math.Round(250000.0 / (num2 * num2));
				}
				short a_4 = m2(a_3, num, A_6, A_7);
				A_11 = new hr(null);
				if (m2(A_2, ref A_14, ref A_15, ref A_11, 1, num, a_4, ref ja, A_1) != ErrPublic.None)
				{
					throw new ai("Error attempting to acquire spectrum for wavelength calibration");
				}
				if (A_15)
				{
					throw new ai("Sat Error in AcquireCalibrationSpectra during background acquire");
				}
				if (A_14)
				{
					throw new ai("Zero Error in AcquireCalibrationSpectra during background acquire");
				}
				A_10 = null;
				m2(A_0: false, A_0, A_1, A_2, A_4, A_6, A_7, ref A_10, ref A_13);
				double num15 = default(double);
				double num16 = default(double);
				if (A_5)
				{
					hr A_16 = new hr(null);
					if (m2(A_2, ref A_14, ref A_15, ref A_16, 1, num, a_4, ref ja, A_1) != ErrPublic.None)
					{
						throw new ai("Error attempting to acquire spectrum for wavelength calibration");
					}
					if (A_15)
					{
						A_9 = true;
						return;
					}
					if (A_14)
					{
						throw new ai("Zero Error in AcquireCalibrationSpectra");
					}
					double num6 = double.MinValue;
					double[] array3 = A_16.c0();
					double[] array4 = A_16.cz();
					int num7 = A_16.c2() - 1;
					int num9 = default(int);
					for (int num8 = 0; num8 <= num7; num8++)
					{
						if (array4[num8] > 500.0 && array4[num8] < 800.0 && array3[num8] > num6)
						{
							num9 = num8;
							num6 = array3[num8];
						}
					}
					double[] array5 = A_16.c0();
					int num10 = num9 - 4;
					if (num10 < 0)
					{
						num10 = 0;
					}
					int num11 = num10 + 9 - 1;
					if (num11 >= A_16.c2())
					{
						num11 = A_16.c2() - 1;
						num10 = num11 - (A_16.c2() - 1);
					}
					int num12 = num10;
					int num13 = num11;
					for (int num14 = num12; num14 <= num13; num14++)
					{
						num15 += array2[num14];
						num16 += array5[num14];
					}
					A_11 = A_11.cw();
					array2 = A_11.c0();
					int num17 = A_11.c2() - 1;
					for (int num18 = 0; num18 <= num17; num18++)
					{
						array2[num18] = 0.5 * (array2[num18] + array5[num18]);
					}
					A_11.af(array2);
					A_11.r(array3);
				}
				double[] array6 = new double[array2.Length - 1 + 1];
				A_2.p9(array, A_2.wm());
				A_2.p9(array2, A_2.wm());
				int num19 = array2.Length - 1;
				for (int num20 = 0; num20 <= num19; num20++)
				{
					array6[num20] = array[num20] - array2[num20];
				}
				A_12 = A_10.cw();
				A_12.r(array6);
				A_12.af(array6);
				double[] array7 = A_12.c0();
				num2 = double.MinValue;
				int num21 = A_12.c2() - 1;
				for (int num22 = 0; num22 <= num21; num22++)
				{
					if (array7[num22] > num2)
					{
						num2 = array7[num22];
					}
				}
				if (A_5 && num15 / (9.0 * num2) > 0.05000000074505806)
				{
					if (num15 <= 0.0)
					{
						num15 = 1.0;
					}
					if (num16 <= 0.0)
					{
						num16 = 1.0;
					}
					if (Math.Abs((num15 - num16) / num15) > 0.05000000074505806)
					{
						A_8 = true;
					}
				}
			}
			finally
			{
				A_2.w0();
				if (A_2.so(a_) != f0.FIDeviceErr.None)
				{
					ab8().c(fz.b.a, "Failed attempting to restore int time in AcquireCalibrationSpectra");
				}
			}
		}
	}

	private void m2(h.a A_0, p A_1, hc A_2)
	{
		A_0.w = A_2.cn();
		A_0.z = A_2;
		A_0.z.cf(A_0: true);
		checked
		{
			jn++;
			jo = false;
			A_0.x = true;
			A_0.aa = true;
			A_0.h = gt;
			_ = null;
			hf.Clear();
			i8.Clear();
		}
	}

	private bool m2(global::h A_0, int A_1, bool[] A_2, p A_3)
	{
		for (int num = 0; num <= A_1; num = checked(num + 1))
		{
			if (m2(A_0, num, A_3.n[num], A_3.aj, A_3.ak) && !A_2[num])
			{
				return false;
			}
		}
		return true;
	}

	private bool m2(int A_0, bool[] A_1, p A_2)
	{
		for (int num = 0; num <= A_0; num = checked(num + 1))
		{
			if (m2(hc.b8(), num, A_2.n[num], A_2.aj, A_2.ak) && A_1[num])
			{
				return false;
			}
		}
		return true;
	}

	private void m2(p A_0, float A_1, bool A_2, bool A_3)
	{
		j.a a10 = new j.a(global::r.d.a.b.a, 0L);
		float num = float.MaxValue;
		int upperBound = iq.GetUpperBound(0);
		checked
		{
			bool A_4 = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			for (int num2 = 0; num2 <= upperBound; num2++)
			{
				bool flag = iu[num2] == 0;
				if (p9(hc.b8(), num2, A_0.n[num2], A_0.aj, A_0.ak))
				{
					float num3;
					if (m2(ref A_4, hc.b8()))
					{
						num3 = Math.Min(iq[num2][0].wj(), 100f);
						int num4 = iq[num2].Count - 1;
						for (int num5 = 0; num5 <= num4; num5++)
						{
							if (p9(hc.b8(), num5, num2) && iq[num2][num5].wi())
							{
								flag2 = true;
								break;
							}
						}
					}
					else
					{
						num3 = 0f;
					}
					if (num3 < num)
					{
						num = num3;
					}
					if (flag)
					{
						flag3 = global::jf.c(num3, 0f);
					}
					else
					{
						flag4 = global::jf.c(num3, 0f);
					}
				}
				else if (flag)
				{
					flag3 = false;
				}
				else
				{
					flag4 = false;
				}
			}
			a10.ag = num;
			a10.aj = flag2;
			a10.ah = flag3;
			a10.ai = flag4;
			a10.ak = A_1;
			a10.al = A_2;
			a10.am = A_3;
			a10.an = lu;
			k3.d(gt, a10);
			_ = null;
		}
	}

	private float p9(int A_0, int A_1)
	{
		if (p9(hc.b8(), A_1, A_0, A_3: true))
		{
			bool a_ = hc.d0().c() == g2.a.b;
			iq a_2 = null;
			ip ip2 = iq[A_0][A_1];
			double num = ip2.qh(a_2, a_);
			int num2 = ip2.m2(jk, a_);
			double num3 = num * (double)num2;
			if (hc.d0().c() == g2.a.n)
			{
				num3 *= 2.0;
			}
			return (float)(num3 + ip2.w1());
		}
		return 0f;
	}

	private ErrPublic m2(ip A_0, int A_1, ref bool A_2, ref global::r.c A_3, global::r.d.a.b A_4)
	{
		ErrPublic result = ErrPublic.None;
		hr A_5 = new hr(null);
		checked
		{
			try
			{
				A_0.wz();
				if (A_0.vt())
				{
					A_2 = true;
					return ErrPublic.None;
				}
				A_2 = false;
				bool A_6 = default(bool);
				bool A_7 = default(bool);
				if (hc.b8().n(v6()) == global::h.MeasurementTimingType.Manual)
				{
					if (A_0.m2(1, xo(), ref A_6, ref A_7, ref A_3, A_4) != f0.FIDeviceErr.None)
					{
						ab8().c(fz.b.b, "Error attempting to acquire spectrum before testing sat error", Environment.StackTrace);
						return ErrPublic.SpecAcquisition;
					}
					if (A_0.m2(1, xo(), ref A_6, ref A_7, ref A_3, A_4) != f0.FIDeviceErr.None)
					{
						ab8().c(fz.b.b, "Error attempting to acquire second spectrum before testing sat error", Environment.StackTrace);
						return ErrPublic.SpecAcquisition;
					}
				}
				double[] array = new double[1] { 1000.0 };
				A_0.m2(array, 1, 25f);
				float num = (float)(6500000.0 / array[0]);
				if (A_0.m2(ref A_5) == f0.FIDeviceErr.None)
				{
					double[] array2 = A_5.c0();
					int num2 = A_5.c2() - 1;
					float num3 = 0f;
					int num4 = num2;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						if (array2[num5] > (double)num3)
						{
							num3 = (float)array2[num5];
						}
					}
					double num6 = A_0.wx();
					double num7 = num6 * (double)num / (double)num3;
					if (num3 < 600f)
					{
						if (m2(A_0, ref A_6, ref A_7, ref A_5, 1, num7, 1, ref A_3, A_4) != ErrPublic.None)
						{
							return ErrPublic.SpecAcquisition;
						}
						if (A_7)
						{
							A_2 = true;
						}
						else
						{
							array2 = A_5.c0();
							int num8 = A_5.c2() - 1;
							num3 = 0f;
							int num9 = num8;
							for (int num10 = 0; num10 <= num9; num10++)
							{
								if (array2[num10] > (double)num3)
								{
									num3 = (float)array2[num10];
								}
							}
							num7 = A_0.u9() * (double)num / (double)num3;
						}
					}
					if (!A_2)
					{
						if (m2(A_0, ref A_6, ref A_7, ref A_5, 1, num7, 1, ref A_3, A_4) == ErrPublic.None)
						{
							if (A_7 || num7 >= A_0.vl())
							{
								A_2 = true;
							}
							else
							{
								num7 *= 2.0;
								if (m2(A_0, ref A_6, ref A_7, ref A_5, 1, num7, 1, ref A_3, A_4) == ErrPublic.None)
								{
									if (A_7 || num7 >= A_0.vl())
									{
										A_2 = true;
									}
									else
									{
										float num11 = 0f;
										array2 = A_5.c0();
										int num12 = A_5.c2() - 1;
										for (int num13 = 0; num13 <= num12; num13++)
										{
											if (array2[num13] > (double)num11)
											{
												num11 = (float)array2[num13];
											}
										}
										ab8().c(fz.b.a, "Unable to detect saturation during reference measurement. Spectrometer Info: S/N=" + A_0.uq() + ", type=" + A_0.xs().ToString() + ", SubmoduleIdx = " + A_1 + ", regularSpectrometerIntTime = " + num6.ToString("0.00", CultureInfo.InvariantCulture) + ", testSatIntTime = " + num7.ToString("0.00", CultureInfo.InvariantCulture) + ", initialPeakReading = " + num3.ToString(CultureInfo.InvariantCulture) + ", failedSpecPeakReading = " + num11.ToString(CultureInfo.InvariantCulture));
										A_2 = false;
									}
								}
								else
								{
									result = ErrPublic.SpecAcquisition;
								}
							}
						}
						else
						{
							result = ErrPublic.SpecAcquisition;
						}
					}
					if (A_0.so(A_0.vm()) == f0.FIDeviceErr.None)
					{
						int num14 = 1;
						do
						{
							if (m2(A_0, ref A_6, ref A_7, ref A_5, 0, A_0.u9(), 1, ref A_3, A_4) != ErrPublic.None)
							{
								result = ErrPublic.SpecAcquisition;
								break;
							}
							if (!A_7)
							{
								break;
							}
							num14++;
						}
						while (num14 <= 5);
						if (A_0.so(num6) != f0.FIDeviceErr.None)
						{
							result = ErrPublic.SpecAcquisition;
						}
					}
					else
					{
						result = ErrPublic.SpecAcquisition;
					}
				}
				else
				{
					result = ErrPublic.SpecAcquisition;
				}
				return result;
			}
			finally
			{
				A_0.w0();
			}
		}
	}

	public FMUSBDeviceType s3(int A_0, int A_1)
	{
		return iq[A_0][A_1].xs();
	}

	public ip.d s4(int A_0, int A_1)
	{
		return iq[A_0][A_1].x5();
	}

	public ip.e s6(int A_0, int A_1)
	{
		return iq[A_0][A_1].wr();
	}

	public FMUSBDeviceType t0(int A_0)
	{
		return iq[A_0][0].abk().eControllerType;
	}

	private void m2(string A_0, float A_1, float A_2)
	{
	}

	public bool p9(g2 A_0)
	{
		return qh(A_0.q());
	}

	private bool qh(bool A_0)
	{
		return false;
	}

	private void m2(bool A_0, string A_1, float A_2, float A_3)
	{
	}

	public void t5(int A_0)
	{
	}

	public void t6(int A_0)
	{
	}

	public void t7(int A_0)
	{
	}

	private iq ti()
	{
		return null;
	}

	private iq m2(ip A_0)
	{
		return null;
	}

	private bool th()
	{
		return false;
	}

	private bool tg()
	{
		return false;
	}

	public bool yl()
	{
		return false;
	}

	public bool ym()
	{
		return false;
	}

	public bool yn()
	{
		if (iq[0][0].zq())
		{
			return !ym();
		}
		return false;
	}

	public void m2(jl.d A_0, ref jl.e A_1)
	{
		if (l6 == null)
		{
			l6 = new jl(ab8());
		}
		l6.l(A_0);
		A_1 = m2;
	}

	private void m2(jl.d A_0)
	{
		l6.m(A_0);
	}

	public void m2(jl.f A_0, ref jl.g A_1)
	{
		if (l6 == null)
		{
			l6 = new jl(ab8());
		}
		l6.l(A_0);
		A_1 = m2;
	}

	private void m2(jl.f A_0)
	{
		l6.m(A_0);
	}

	public void m2(jl.h A_0, ref jl.i A_1)
	{
		if (l6 == null)
		{
			l6 = new jl(ab8());
		}
		l6.l(A_0);
		A_1 = m2;
	}

	private void m2(jl.h A_0)
	{
		l6.m(A_0);
	}

	[SpecialName]
	public int m2(long A_0)
	{
		return l6.m(A_0);
	}

	[SpecialName]
	public jm yo()
	{
		return l6.q();
	}

	[SpecialName]
	public bool yp()
	{
		return l6.q() != null;
	}

	[SpecialName]
	public jn yq()
	{
		return l6.s();
	}

	public float m2(float A_0, float A_1, long A_2)
	{
		return l6.l(A_0, A_1, A_2);
	}

	public void m2(string A_0, int A_1)
	{
		l6.l(A_0, A_1);
	}

	public hr.b yr()
	{
		if (hb.b8().a(v4(), uq()))
		{
			return st();
		}
		hr.b[] array = v0();
		if (array != null && array.Length > 0)
		{
			return array[0];
		}
		return hr.b.a;
	}

	[SpecialName]
	public string ys()
	{
		return l6.t();
	}

	public float p9(long A_0)
	{
		return l6.n(A_0);
	}

	public ReadOnlyCollection<float> yt()
	{
		return l6.r().AsReadOnly();
	}

	[SpecialName]
	public bool yu()
	{
		return hb.b8().a(v4(), uq());
	}

	private void tf()
	{
		checked
		{
			int num = @is.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				@in obj = @is[num2];
				obj.m2(jk);
				obj.s3();
				_ = null;
			}
			m2(tc(), te());
		}
	}

	private bool te()
	{
		return qh(hb.b8());
	}

	private DateTime td()
	{
		List<global::h.a> list = hb.b8().a2();
		checked
		{
			int num = @is.Count - 1;
			int num5 = default(int);
			bool flag = default(bool);
			DateTime dateTime = default(DateTime);
			for (int num2 = 0; num2 <= num; num2++)
			{
				@in obj = @is[num2];
				int num3 = obj.tg() - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (list[num5 + num4].a)
					{
						@in obj2 = obj;
						if (obj2.tg(num4) && (!flag || DateTime.Compare(obj2.tf(num4), dateTime) < 0))
						{
							dateTime = obj2.tf(num4);
							flag = true;
						}
						if (obj2.so(num4) && (!flag || DateTime.Compare(obj2.sn(num4), dateTime) < 0))
						{
							dateTime = obj2.sn(num4);
							flag = true;
						}
						obj2 = null;
					}
				}
				num5 += obj.tg();
			}
			return dateTime;
		}
	}

	private bool tc()
	{
		return p9(hb.b8());
	}

	public void p9(v A_0, global::r.d A_1, bool A_2, float[] A_3, bool A_4, global::r.d.a.b A_5)
	{
		w a_ = m2(A_0, A_1, A_2, A_3, A_4, A_5);
		string A_6 = null;
		string A_7 = null;
		if (m2(ref A_6, ref A_7, a_) != ErrPublic.None)
		{
			throw new ApplicationException("Error in AttemptAcquirePDData");
		}
	}

	private bool sm(global::h A_0)
	{
		List<global::h.a> list = A_0.a2();
		checked
		{
			int num = @is.Count - 1;
			int num5 = default(int);
			for (int num2 = 0; num2 <= num; num2++)
			{
				@in obj = @is[num2];
				int num3 = obj.tg() - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (list[num5 + num4].a && (!obj.so(num4) || !obj.p9(jk)))
					{
						return false;
					}
				}
				num5 += obj.tg();
			}
			return true;
		}
	}

	private bool sj(global::h A_0)
	{
		List<global::h.a> list = A_0.a2();
		checked
		{
			int num = @is.Count - 1;
			int num5 = default(int);
			for (int num2 = 0; num2 <= num; num2++)
			{
				@in obj = @is[num2];
				int num3 = obj.tg() - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (list[num5 + num4].a && (!obj.tg(num4) || !obj.p9(jk)))
					{
						return false;
					}
				}
				num5 += obj.tg();
			}
			return true;
		}
	}

	private bool qh(global::h A_0)
	{
		List<global::h.a> list = A_0.a2();
		checked
		{
			int num = @is.Count - 1;
			int num5 = default(int);
			for (int num2 = 0; num2 <= num; num2++)
			{
				@in obj = @is[num2];
				int num3 = obj.tg() - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (list[num5 + num4].a)
					{
						if (!obj.s4(num4))
						{
							return false;
						}
						_ = null;
					}
				}
				num5 += obj.tg();
			}
			return true;
		}
	}

	private void tb()
	{
		checked
		{
			int num = @is.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				@is[num2].t0();
			}
		}
	}

	private w m2(v A_0, global::r.d A_1, bool A_2, float[] A_3, bool A_4, global::r.d.a.b A_5)
	{
		w obj = new w(A_5);
		((m)obj).a = m.a.ak;
		obj.d = m.TaskExecutionType.Photodiode;
		obj.cw = A_0;
		obj.g = A_1;
		obj.cv = A_2;
		obj.cx = A_3;
		obj.cu = A_4;
		_ = null;
		return obj;
	}

	private void s8()
	{
		checked
		{
			int num = @is.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				@is[num2].t5();
			}
		}
	}

	[SpecialName]
	public int yv()
	{
		if (@is == null)
		{
			return 0;
		}
		return @is.Count;
	}

	[SpecialName]
	public List<iv> yw()
	{
		List<iv> list = new List<iv>();
		checked
		{
			int num = @is.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				list.Add(@is[num2].sn(g2.OpticsConfigSubmoduleTypes.ReflectanceProbe));
			}
			return list;
		}
	}

	private bool s6()
	{
		List<global::h.a> list = hb.b8().a2();
		checked
		{
			int num = @is.Count - 1;
			int num5 = default(int);
			for (int num2 = 0; num2 <= num; num2++)
			{
				@in obj = @is[num2];
				int num3 = obj.tg() - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (list[num5 + num4].a && !obj.tb(num4))
					{
						return false;
					}
				}
				num5 += obj.tg();
			}
			return true;
		}
	}

	private bool s4()
	{
		List<global::h.a> list = hb.b8().a2();
		checked
		{
			int num = @is.Count - 1;
			int num5 = default(int);
			for (int num2 = 0; num2 <= num; num2++)
			{
				@in obj = @is[num2];
				int num3 = obj.tg() - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (list[num5 + num4].a && !obj.tc(num4))
					{
						return false;
					}
				}
				num5 += obj.tg();
			}
			return true;
		}
	}

	private bool s3()
	{
		List<global::h.a> list = hb.b8().a2();
		checked
		{
			int num = @is.Count - 1;
			int num5 = default(int);
			for (int num2 = 0; num2 <= num; num2++)
			{
				@in obj = @is[num2];
				int num3 = obj.tg() - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (list[num5 + num4].a && !obj.te(num4))
					{
						return false;
					}
				}
				num5 += obj.tg();
			}
			return true;
		}
	}

	public bool m2(@in A_0)
	{
		if (@is == null)
		{
			return false;
		}
		foreach (@in item in @is)
		{
			if (string.Compare(item.yq(), A_0.yq()) == 0)
			{
				return true;
			}
		}
		return false;
	}

	private hr.b st()
	{
		if (hb.b8().a0())
		{
			if (it.e() && sj(hc.b8()))
			{
				return hr.b.c;
			}
			return hr.b.b;
		}
		return hr.b.c;
	}

	private bool m2(ref bool A_0)
	{
		List<global::h.a> list = hb.b8().a2();
		bool result = true;
		A_0 = true;
		checked
		{
			int num = @is.Count - 1;
			int num5 = default(int);
			for (int num2 = 0; num2 <= num; num2++)
			{
				@in obj = @is[num2];
				int num3 = obj.tg() - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (!list[num5 + num4].a)
					{
						continue;
					}
					@in obj2 = obj;
					if (obj2.tg(num4) && obj2.so(num4))
					{
						if (!obj2.p9(jk))
						{
							result = false;
						}
					}
					else
					{
						A_0 = false;
					}
					obj2 = null;
				}
				num5 += obj.tg();
			}
			if (!A_0)
			{
				result = false;
			}
			return result;
		}
	}

	private bool p9(global::h A_0)
	{
		List<global::h.a> list = A_0.a2();
		checked
		{
			int num = @is.Count - 1;
			int num5 = default(int);
			for (int num2 = 0; num2 <= num; num2++)
			{
				@in obj = @is[num2];
				int num3 = obj.tg() - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (list[num5 + num4].a)
					{
						@in obj2 = obj;
						if (!obj2.s6(num4) || !global::jf.e(list[num5 + num4].d, obj2.th(num4)))
						{
							return false;
						}
						obj2 = null;
					}
				}
				num5 += obj.tg();
			}
			return true;
		}
	}

	private void p9(bool A_0)
	{
		checked
		{
			int num = @is.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				@is[num2].m2(A_0);
			}
		}
	}

	public void m2(string A_0, ref bool A_1)
	{
		checked
		{
			int num = @is.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				@is[num2].m2(A_0, ref A_1);
			}
		}
	}

	private void m2(bool A_0, bool A_1)
	{
		it = it.c(ref A_0, ref A_1);
	}

	private bool so()
	{
		return it.d();
	}

	private bool sn()
	{
		return it.e();
	}

	private void m2(float A_0, float A_1, ref bool A_2, ref string A_3, ref string A_4)
	{
		A_2 = true;
		A_3 = string.Empty;
		A_4 = string.Empty;
		List<global::h.a> list = hc.b8().a2();
		string text = string.Empty;
		checked
		{
			int num = @is.Count - 1;
			int num5 = default(int);
			double A_5 = default(double);
			DateTime A_6 = default(DateTime);
			double A_7 = default(double);
			for (int num2 = 0; num2 <= num; num2++)
			{
				@in obj = @is[num2];
				int num3 = obj.tg() - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (!list[num5 + num4].a)
					{
						continue;
					}
					if (@is.Count > 1)
					{
						text = "-" + (num2 + 1);
					}
					if (!obj.m2(A_0, ref A_5, ref A_6, ref A_7))
					{
						A_2 = false;
						if (!string.IsNullOrEmpty(A_3))
						{
							A_3 += ", \r\n";
						}
						string obj2 = A_3;
						string A_8 = "ReferenceInvalidIntensityLowWRTHistoryFmt3";
						A_3 = obj2 + string.Format(hu.a(ref A_8), "Photodiode" + text, (A_5 * 100.0).ToString("0"), A_6.ToLocalTime().ToString());
					}
					else if (A_7 > (double)A_1)
					{
						if (!string.IsNullOrEmpty(A_4))
						{
							A_4 += ", \r\n";
						}
						string obj3 = A_4;
						string A_8 = "ReferenceIntensityHighWRTPrevFmt2";
						A_4 = obj3 + string.Format(hu.a(ref A_8), "Photodiode" + text, (A_7 * 100.0).ToString("0"));
					}
					_ = null;
				}
				num5 += obj.tg();
			}
		}
	}

	private void m2(bool A_0, ref List<float>[] A_1)
	{
		hc.b8().a2();
		checked
		{
			A_1 = new List<float>[@is.Count - 1 + 1];
			int num = @is.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				A_1[num2] = new List<float>();
				@in obj = @is[num2];
				int num3 = obj.tg() - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (obj.te(num4) && obj.td(num4) > 0f)
					{
						A_1[num2].Add(obj.td(num4));
					}
					else
					{
						A_1[num2].Add(obj.s8(num4));
					}
				}
			}
		}
	}

	private void m2(bool A_0, float A_1, float A_2, ref x.a.a A_3)
	{
		checked
		{
			bool[] array = new bool[@is.Count - 1 + 1];
			List<float>[] A_4 = null;
			m2(A_0, ref A_4);
			int num = @is.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (@is[num2].ua() != 0)
				{
					A_3 = x.a.a.b;
					return;
				}
			}
			bool A_5 = default(bool);
			bool flag;
			do
			{
				int num3 = @is.Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (!array[num4])
					{
						m2(@is[num4], 0f, ref A_3);
						if (A_3 != x.a.a.a)
						{
							return;
						}
					}
				}
				m2(ref A_3);
				if (A_3 != x.a.a.a)
				{
					break;
				}
				int num5 = @is.Count - 1;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					if (!array[num6])
					{
						if (@is[num6].m2(3000f, 3500f, A_4[num6], A_0, A_1, A_2, ref array[num6], ref A_5) != 0)
						{
							A_3 = x.a.a.b;
							return;
						}
						if (A_5)
						{
							A_3 = x.a.a.c;
							return;
						}
					}
				}
				flag = true;
				int num7 = @is.Count - 1;
				for (int num8 = 0; num8 <= num7; num8++)
				{
					if (!array[num8])
					{
						flag = false;
						break;
					}
				}
			}
			while (!flag);
		}
	}

	[SpecialName]
	private bool sm()
	{
		return hc.b8().a(v4(), uq());
	}

	private bool m2(global::h A_0)
	{
		bool flag = A_0.a0();
		checked
		{
			int num = @is.Count - 1;
			bool flag3 = default(bool);
			for (int num2 = 0; num2 <= num; num2++)
			{
				@in obj = @is[num2];
				bool flag2 = obj.th() > 0;
				flag3 = flag3 || flag2;
				if (!flag && flag2)
				{
					bool A_1 = false;
					if (!m2(ref A_1))
					{
						return false;
					}
					int num3 = obj.tg() - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						if (A_0.a2()[obj.tc() + num4].a && !obj.tg(obj.tc() + num4))
						{
							return false;
						}
					}
				}
				obj = null;
			}
			return flag3;
		}
	}

	private void m2(float A_0, ref x.a.a A_1)
	{
		checked
		{
			int num = @is.Count - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					m2(@is[num2], A_0, ref A_1);
					if (A_1 == x.a.a.a)
					{
						num2++;
						continue;
					}
					break;
				}
				A_1 = x.a.a.a;
				break;
			}
		}
	}

	private void m2(@in A_0, float A_1, ref x.a.a A_2)
	{
		@in obj = A_0;
		double num = obj.t9();
		checked
		{
			int num2 = (int)Math.Round(Math.Ceiling((double)A_1 * num / (double)obj.t8())) - 1;
			if (num2 < 1)
			{
				num2 = 1;
			}
			global::h h10 = hc.b8();
			bool flag = h10.ax();
			int num3 = default(int);
			if (flag)
			{
				num3 = (int)Math.Round(num * 1.0 * 600.0 * 9.0 / (double)(h10.az() * (float)hc.b8().ay()));
				if (num3 < 1)
				{
					num3 = 1;
				}
			}
			h10 = null;
			if (obj.m2(num2, flag, num3) != 0)
			{
				A_2 = x.a.a.b;
				return;
			}
			obj = null;
			A_2 = x.a.a.a;
		}
	}

	private void m2(ref x.a.a A_0)
	{
		checked
		{
			bool flag;
			bool A_1 = default(bool);
			do
			{
				flag = true;
				int num = @is.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					int num3 = @is[num2].m2(ref A_1);
					if (A_1)
					{
						flag = false;
					}
					if (num3 != 0)
					{
						A_0 = x.a.a.b;
						return;
					}
					_ = null;
				}
			}
			while (!flag);
		}
	}

	public void yx()
	{
		bool A_ = default(bool);
		hb.b8().a(sj(), ref A_);
		if (A_)
		{
			hg A_2 = new hg(hb.dh(), hb.cd());
			hb.bu(ref A_2);
			qh(A_2);
		}
		qh();
	}

	public static void m2(cg A_0, g2 A_1, ref bool A_2)
	{
		A_2 = false;
		if (A_1.q())
		{
			cf cf2 = null;
			if (A_1.s() != null)
			{
				cf2 = A_0.f(A_1.s().n());
			}
			if (A_1.s() == null || cf2 == null)
			{
				bool flag = A_1.s() != null;
				A_1.a(A_0.g());
				A_2 = A_1.s() != null || flag;
			}
			else if (cf.n(A_1.s(), cf2))
			{
				A_1.a(cf2);
				if (cf.m(A_1.s(), cf2))
				{
					A_2 = true;
				}
			}
		}
		else
		{
			A_1.a((cf)null);
		}
	}

	public List<it> yy()
	{
		if (@is == null)
		{
			return null;
		}
		List<it> list = new List<it>();
		int num = 0;
		checked
		{
			int num2 = @is.Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				it it2 = new it(@is[num3].yq(), 0, num3);
				it2.d = new List<int>();
				int num4 = @is[num3].tg() - 1;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					it2.d.Add(num);
					num++;
				}
				list.Add(it2);
			}
			return list;
		}
	}

	[SpecialName]
	private List<global::h.c> sj()
	{
		List<global::h.c> list = new List<global::h.c>();
		if (@is != null)
		{
			foreach (@in item in @is)
			{
				list.Add(new global::h.c(item.yq(), item.s8(), item.tg(), item.tf(), item.te()));
			}
		}
		return list;
	}

	private void qh()
	{
		if (@is == null)
		{
			return;
		}
		checked
		{
			int num = @is.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				int num3 = @is[num2].m2(hc.b8().a2(), hc.b8().a0());
				if (num3 != 0)
				{
					throw new ai("Error calling SetActiveChannels. Error code=" + num3);
				}
				_ = null;
			}
			if (@is.Count <= 0)
			{
				return;
			}
			int num4 = @is.Count - 1;
			bool A_2 = default(bool);
			bool A_3 = default(bool);
			for (int num5 = 0; num5 <= num4; num5++)
			{
				bool flag = false;
				global::h h10 = hc.b8();
				@in obj = @is[num5];
				string text;
				string text2;
				if (h10.p())
				{
					text = obj.yk();
					text2 = obj.tl();
				}
				else
				{
					text = h10.@as();
					text2 = sj(h10, 0);
				}
				flag = obj.yl() || Operators.CompareString(obj.yk(), text, TextCompare: false) != 0 || Operators.CompareString(obj.tl(), text2, TextCompare: false) != 0;
				if (!flag)
				{
					@in obj2 = obj;
					string a_ = text;
					string a_2 = text2;
					io.a a_3 = obj.bb();
					bool A_ = false;
					obj2.m2(a_, a_2, g2.OpticsConfigSubmoduleTypes.ReflectanceProbe, a_3, ref A_2, ref A_);
					flag = !A_2;
				}
				if (flag)
				{
					obj.p9(text, text2, ref A_3);
					if (obj.p9(jk) && !A_3)
					{
						m2(A_0: true, A_1: true);
					}
				}
				obj = null;
			}
		}
	}

	public void s3(hg A_0)
	{
		bool A_1 = default(bool);
		A_0.b8().a(sj(), ref A_1);
		if (A_1)
		{
			A_0.bv(global::e.a().OperatorID, DateTime.Now);
		}
	}

	protected void m2(w A_0)
	{
		long a_ = default(long);
		if (A_0.g != null)
		{
			a_ = A_0.g.d();
		}
		x.a a10 = new x.a(A_0.d3(), a_);
		x.a a11 = new x.a(A_0.d3(), a_);
		((global::r.d.a)a10).a = global::r.d.a.a.b;
		checked
		{
			try
			{
				((global::r.d.a)a11).a = global::r.d.a.a.a;
				A_0.g.e(gt, a11);
				switch (((m)A_0).a)
				{
				case m.a.ag:
				{
					w w2 = A_0;
					int num9 = @is[w2.c0].m2(w2.cz);
					if (num9 == 0)
					{
						((global::r.d.a)a10).a = global::r.d.a.a.a;
					}
					else
					{
						ab8().c(fz.b.a, "Error attempting to write USBPhotodiodeLed firmware. Error is " + num9);
					}
					w2 = null;
					break;
				}
				case m.a.ak:
				{
					float num6 = hc.b8().aw() * 1000f;
					if (A_0.cv && !hc.b8().a0())
					{
						float a_3 = default(float);
						if (A_0.cw == v.b)
						{
							a_3 = A_0.cx[0];
						}
						m2(A_0.cw == v.b, a_3, k6, ref a10.aw);
						if (a10.aw != x.a.a.a)
						{
							break;
						}
					}
					m2(10f * num6, ref a10.aw);
					if (a10.aw != x.a.a.a)
					{
						break;
					}
					m2(ref a10.aw);
					if (a10.aw != x.a.a.a)
					{
						break;
					}
					int num7 = @is.Count - 1;
					for (int num8 = 0; num8 <= num7; num8++)
					{
						switch (A_0.cw)
						{
						case v.d:
							@is[num8].sj(jk);
							break;
						case v.b:
							@is[num8].qh(jk);
							break;
						case v.c:
							@is[num8].m2(jk, A_0.cu);
							break;
						}
					}
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					jg.d(gt, new global::r.d.a(A_0.d3(), 0L));
					break;
				}
				case m.a.ap:
				{
					m2(hc.b8().aw() * 1000f, ref a10.aw);
					if (a10.aw != x.a.a.a)
					{
						break;
					}
					m2(ref a10.aw);
					if (a10.aw != x.a.a.a)
					{
						break;
					}
					List<float> list = new List<float>();
					int num2 = @is.Count - 1;
					bool flag = default(bool);
					DateTime a_2 = default(DateTime);
					for (int num3 = 0; num3 <= num2; num3++)
					{
						@in.f f10 = @is[num3].m2(it.e() && sj(hc.b8()), it.d() && sm(hc.b8()));
						if (f10 != null)
						{
							if (!flag)
							{
								a_2 = f10.a;
								flag = true;
							}
							int num4 = f10.b.Length - 1;
							for (int num5 = 0; num5 <= num4; num5++)
							{
								list.Add(f10.b[num5]);
							}
						}
					}
					l6.l(a_2, list, A_0.d3());
					((global::r.d.a)a10).a = global::r.d.a.a.a;
					break;
				}
				default:
				{
					int num = unchecked((int)((m)A_0).a);
					throw new ArgumentOutOfRangeException("Unknown Task.ID in TaskCorePhotodiode. Task.Id=" + num);
				}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_4 = ex2;
				ab8().c(fz.b.b, "Error in TaskCorePhotodiode. Task ID=" + ((m)A_0).a, a_4);
				ProjectData.ClearProjectError();
			}
			finally
			{
				A_0.g.d(gt, a10);
			}
		}
	}

	[SpecialName]
	public bool so(int A_0, global::f.b A_1)
	{
		return s8(A_0, p9(A_0, A_1));
	}

	[SpecialName]
	public bool s8(int A_0, int A_1)
	{
		if (iq == null || iq[A_0] == null || iq[A_0].Count <= A_1)
		{
			return false;
		}
		return iq[A_0][A_1].x1();
	}

	[SpecialName]
	public bool yz()
	{
		return im != null;
	}

	[SpecialName]
	public bool y0()
	{
		if (yz())
		{
			g9[] array = t8(0);
			if (array != null && array.Length > 0)
			{
				return !t8(0)[0].i;
			}
			return false;
		}
		return false;
	}

	[SpecialName]
	public bool y1()
	{
		if (y0())
		{
			return !t8(0)[0].h;
		}
		return false;
	}

	[SpecialName]
	public bool y2()
	{
		if (im != null && im.z7())
		{
			return true;
		}
		if (iq == null)
		{
			return false;
		}
		checked
		{
			int num = iq.Length - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (iq[num2] == null)
				{
					continue;
				}
				int num3 = iq[num2].Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					ip ip2 = iq[num2][num4];
					if (ip2 != null)
					{
						ip ip3 = ip2;
						if (ip3.ab0() && ip3.z7())
						{
							return true;
						}
						ip3 = null;
					}
				}
			}
			return false;
		}
	}

	[SpecialName]
	public bool y3()
	{
		if (iq == null)
		{
			return false;
		}
		checked
		{
			int num = iq.Length - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (iq[num2] == null)
				{
					continue;
				}
				int num3 = iq[num2].Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					ip ip2 = iq[num2][num4];
					if (ip2 != null && ip2.x0())
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	[SpecialName]
	public bool y4()
	{
		if (iq == null)
		{
			return false;
		}
		checked
		{
			int num = iq.Length - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (iq[num2] == null)
				{
					continue;
				}
				int num3 = iq[num2].Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					ip ip2 = iq[num2][num4];
					if (ip2 != null && ip2.x1())
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	[SpecialName]
	public bool m2(global::h.f A_0, global::f.b A_1)
	{
		if (iu == null || iu.Length <= (int)A_0)
		{
			return false;
		}
		int a_ = iu[(int)A_0];
		return m2(a_, p9(a_, A_1));
	}

	[SpecialName]
	private bool m2(int A_0, int A_1)
	{
		if (iq == null || iq.Length <= A_0 || iq[A_0] == null || iq[A_0].Count <= A_1)
		{
			return false;
		}
		return iq[A_0][A_1].z7();
	}

	[SpecialName]
	public bool y5()
	{
		return ik != null;
	}

	public void m2(ref bool A_0, ref bool A_1)
	{
		if (ik != null)
		{
			A_0 = ik.e();
			A_1 = ik.f();
		}
	}

	[SpecialName]
	public bool y6()
	{
		return ip != null;
	}

	public bool m2(float A_0, float A_1)
	{
		return m2(A_0) != m2(A_1);
	}

	private ushort m2(float A_0)
	{
		checked
		{
			return (ushort)Math.Round((double)((float)unchecked((int)im.abk().MaxLampSetpoint) * A_0) * 0.01);
		}
	}

	public bool p9(int A_0, float A_1, float A_2)
	{
		return m2(A_0, A_1) != m2(A_0, A_2);
	}

	private ushort m2(int A_0, float A_1)
	{
		checked
		{
			return (ushort)Math.Round((double)((float)unchecked((int)((IFIUsbController)im.abk()).get_LsMaxLEDSetpoint(checked((byte)A_0))) * A_1) * 0.01);
		}
	}

	[SpecialName]
	public float y7()
	{
		return im.st();
	}

	[SpecialName]
	public bool y8()
	{
		if (im != null)
		{
			return im.s6();
		}
		return false;
	}

	[SpecialName]
	public bool y9()
	{
		if (im != null)
		{
			return im.s4();
		}
		return false;
	}

	public void m2(global::r.c A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		q q2 = new q(A_2);
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q2).a = m.a.a6;
		q2.h = A_0;
		q2.g = A_1;
		q2.e = gt;
		_ = null;
		if (sj(q2) != global::r.a.a)
		{
			throw new ah("Failed to adjust lightsource setpoints");
		}
	}

	public void p9(global::r.c A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		q q2 = new q(A_2);
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q2).a = m.a.bw;
		q2.h = A_0;
		q2.g = A_1;
		q2.e = gt;
		_ = null;
		if (sj(q2) != global::r.a.a)
		{
			throw new ah("Failed to check light from internal source");
		}
	}

	public void m2(global::h.f A_0, global::f.b A_1, global::r.d A_2, global::r.d.a.b A_3)
	{
		q q2 = new q(A_3);
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q2).a = m.a.a2;
		q2.a6 = iu[(int)A_0];
		q2.a7 = A_1;
		q2.g = A_2;
		q2.e = gt;
		_ = null;
		if (sj(q2) != global::r.a.a)
		{
			throw new ah("Failed to read light source temperature");
		}
	}

	public void m2(global::h.f A_0, global::f.b A_1, bool A_2, string A_3, global::r.d A_4, global::r.d.a.b A_5)
	{
		q q2 = new q(A_5);
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q2).a = m.a.a0;
		q2.g = A_4;
		q2.be = A_2;
		q2.e = gt;
		q2.a7 = A_1;
		q2.a6 = iu[(int)A_0];
		q2.j = A_3;
		_ = null;
		if (sj(q2) != global::r.a.a)
		{
			throw new ah("Failed to set Light Source Power On State");
		}
	}

	public void m2(float A_0, string A_1, global::r.d A_2, global::r.d.a.b A_3)
	{
		q q2 = new q(A_3);
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q2).a = m.a.az;
		q2.g = A_2;
		q2.bf = A_0;
		q2.e = gt;
		q2.j = A_1;
		_ = null;
		if (sj(q2) != global::r.a.a)
		{
			throw new ah("Failed to set Light Source Power On State");
		}
	}

	public void m2(int A_0, float A_1, string A_2, global::r.d A_3, global::r.d.a.b A_4)
	{
		q q2 = new q(A_4);
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q2).a = m.a.a1;
		q2.g = A_3;
		q2.bf = A_1;
		q2.bg = A_0;
		q2.e = gt;
		q2.j = A_2;
		_ = null;
		if (sj(q2) != global::r.a.a)
		{
			throw new ah("Failed to set Light Source Power On State");
		}
	}

	public void m2(float A_0, bool A_1, global::r.d A_2, global::r.d.a.b A_3)
	{
		q q2 = new q(A_3);
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q2).a = m.a.a7;
		q2.g = A_2;
		q2.bf = A_0;
		q2.bh = A_1;
		q2.e = gt;
		_ = null;
		if (sj(q2) != global::r.a.a)
		{
			throw new ah("Failed to set Light Source Power On State");
		}
	}

	public void m2(bool A_0, string A_1, global::r.d A_2, global::r.d.a.b A_3)
	{
		q q2 = new q(A_3);
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q2).a = m.a.ay;
		q2.g = A_2;
		q2.be = A_0;
		q2.e = gt;
		q2.j = A_1;
		_ = null;
		if (sj(q2) != global::r.a.a)
		{
			throw new ah("Failed to set Light Source Power On State");
		}
	}

	[SpecialName]
	public bool za()
	{
		if (!yz())
		{
			return true;
		}
		if (im != null && im.abz())
		{
			return true;
		}
		if (iq == null || iq[0] == null || iq[0][0] == null)
		{
			return true;
		}
		return iq[0][0].wq();
	}

	private g9 m2(FIUsbController A_0, global::h.f A_1, global::f.b A_2, g9.a A_3, g9.a A_4, h5 A_5)
	{
		g9 g10 = new g9();
		g9 g11 = g10;
		g11.h = h6.qh(A_0);
		g11.i = h6.p9(A_0);
		g11.d = h6.m2(A_0);
		if (g11.d)
		{
			g11.e = A_0.FanPowerIsOn != 0;
		}
		g11.f = A_1;
		g11.g = A_2;
		g11.a = A_3;
		g11.b = A_4;
		if (A_5 != null)
		{
			g9.b b10 = new g9.b();
			g9.b b11 = b10;
			b11.a = A_0.LightSourcePowerIsOn != 0;
			b11.b = (float)((double)(int)A_0.LampSetpoint / (double)(int)A_0.MaxLampSetpoint) * 100f;
			float[] array;
			byte b12;
			byte b13;
			checked
			{
				byte num = (byte)unchecked((uint)(A_0.LsfwNumLEDs - 1));
				array = new float[num + 1];
				b12 = num;
				b13 = 0;
			}
			while ((uint)b13 <= (uint)b12)
			{
				array[b13] = (float)((double)(int)((IFIUsbController)A_0).get_LsLEDSetpoint(b13) / (double)(int)((IFIUsbController)A_0).get_LsMaxLEDSetpoint(b13) * 100.0);
				checked
				{
					b13 = (byte)unchecked((uint)(b13 + 1));
				}
			}
			b11.c = array;
			b11.e = A_5.so();
			b11.f = A_5.sm();
			b11.g = A_5.sn();
			b11.d = A_5.st();
			b11 = null;
			g11.c = b10;
		}
		g11 = null;
		return g10;
	}

	[SpecialName]
	public g9[] t8(int A_0)
	{
		List<g9> list = new List<g9>();
		Collection<h6> collection = new Collection<h6>();
		List<int> list2 = new List<int>();
		List<global::f.b> list3 = new List<global::f.b>();
		if (iq == null)
		{
			return list.ToArray();
		}
		checked
		{
			m2(collection, 0, iq.Length - 1, list2, list3, A_5: false);
			_ = new bool[collection.Count - 1 + 1];
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				h6 h10 = collection[num2];
				if (!h10.ab0())
				{
					continue;
				}
				g9.a a_ = null;
				g9.a a_2 = null;
				h5 h11 = null;
				int num3 = list2[num2];
				global::f.b b10 = list3[num2];
				if (num3 == 0 && b10 == global::f.b.b)
				{
					h11 = im;
				}
				if (h10.z7())
				{
					g9.a a10 = new g9.a(((ip)h10).x6(), b10, iq[num3].Count > 1, ix[num3]);
					if (iq[num3].Count > 1 && iq[num3][0].abk() == iq[num3][1].abk())
					{
						global::f.b a_3;
						if (b10 == global::f.b.b)
						{
							a_ = a10;
							a_3 = global::f.b.c;
						}
						else
						{
							a_2 = a10;
							a_3 = global::f.b.b;
						}
						a10 = new g9.a(iq[num3][p9(num3, a_3)].x6(), a_3, A_2: true, ix[num3]);
						if (b10 == global::f.b.b)
						{
							a_2 = a10;
						}
						else
						{
							a_ = a10;
						}
					}
					else if (iq.Length == 2 && iq[0][0].abk() == iq[1][0].abk())
					{
						int num4;
						if (a10.c == global::h.f.a)
						{
							a_ = a10;
							num4 = iu[1];
						}
						else
						{
							a_2 = a10;
							num4 = iu[0];
						}
						a10 = new g9.a(iq[num4][0].x6(), global::f.b.b, A_2: false, ix[num4]);
						if (a10.c == global::h.f.a)
						{
							a_ = a10;
						}
						else
						{
							a_2 = a10;
						}
					}
					else
					{
						a_ = a10;
					}
				}
				g9 item = m2(h10.abk(), ix[num3], b10, a_, a_2, h11);
				if (h11 == null)
				{
					list.Add(item);
				}
				else
				{
					list.Insert(0, item);
				}
			}
			if (list.Count > 2)
			{
				for (int num5 = list.Count - 1; num5 >= 0; num5 += -1)
				{
					if (list[num5].a.c != ix[A_0])
					{
						list.RemoveAt(num5);
					}
				}
			}
			return list.ToArray();
		}
	}

	public void s6(global::r.d A_0, global::r.d.a.b A_1)
	{
		q q2 = new q(A_1);
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q2).a = m.a.br;
		q2.g = A_0;
		q2.e = gt;
		_ = null;
		if (sj(q2) != global::r.a.a)
		{
			throw new ah("Failed to read light source temperature");
		}
	}

	public void s8(global::r.d A_0, global::r.d.a.b A_1)
	{
		q q2 = new q(A_1);
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q2).a = m.a.bs;
		q2.g = A_0;
		q2.e = gt;
		_ = null;
		if (sj(q2) != global::r.a.a)
		{
			throw new ah("Failed to reset D2 Lamp On timer");
		}
	}

	public void tb(global::r.d A_0, global::r.d.a.b A_1)
	{
		q q2 = new q(A_1);
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q2).a = m.a.bt;
		q2.g = A_0;
		q2.e = gt;
		_ = null;
		if (sj(q2) != global::r.a.a)
		{
			throw new ah("Failed to reset TH lamp On timer");
		}
	}

	public void p9(global::h.f A_0, global::f.b A_1, bool A_2, string A_3, global::r.d A_4, global::r.d.a.b A_5)
	{
		q q2 = new q(A_5);
		q2.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q2).a = m.a.a8;
		q2.g = A_4;
		q2.be = A_2;
		q2.a6 = iu[(int)A_0];
		q2.a7 = A_1;
		q2.e = gt;
		q2.j = A_3;
		_ = null;
		if (sj(q2) != global::r.a.a)
		{
			throw new ah("Failed to set Light Source Power On State");
		}
	}

	public void m2(string A_0, h6.b A_1, int A_2, global::f.b A_3, global::r.d A_4, global::r.d.a.b A_5)
	{
		q q2 = new q(A_5);
		q q3 = q2;
		q3.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q3).a = m.a.ba;
		q3.g = A_4;
		q3.e = gt;
		q3.bi = A_1;
		if (A_1 == h6.b.b)
		{
			q3.a6 = A_2;
			q3.a7 = A_3;
		}
		q3.j = A_0;
		q3 = null;
		if (sj(q2) != global::r.a.a)
		{
			throw new ah("Failed to update baseline linearity");
		}
	}

	public void m2(h6.b A_0, int A_1, int A_2, global::r.d A_3, global::r.d.a.b A_4)
	{
		q q2 = new q(A_4);
		q q3 = q2;
		q3.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q3).a = m.a.bb;
		q3.g = A_3;
		q3.e = gt;
		q3.bi = A_0;
		if (A_0 == h6.b.b)
		{
			q3.a6 = A_1;
			q3.a7 = so(A_1, A_2);
		}
		q3 = null;
		if (sj(q2) != global::r.a.a)
		{
			throw new ah("Failed to update baseline linearity");
		}
	}

	public void m2(h6.b A_0, int A_1, int A_2, im.a A_3, global::r.d A_4, global::r.d.a.b A_5)
	{
		q q2 = new q(A_5);
		q q3 = q2;
		q3.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q3).a = m.a.bc;
		q3.g = A_4;
		q3.e = gt;
		q3.j = A_3;
		q3.bi = A_0;
		if (A_0 == h6.b.b)
		{
			q3.a6 = A_1;
			q3.a7 = so(A_1, A_2);
		}
		q3 = null;
		if (sj(q2) != global::r.a.a)
		{
			throw new ah("Failed to update baseline linearity");
		}
	}

	public void m2(h6.b A_0, int A_1, int A_2, h6.c A_3, global::r.d A_4, global::r.d.a.b A_5)
	{
		q q2 = new q(A_5);
		q q3 = q2;
		q3.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)q3).a = m.a.bd;
		q3.g = A_4;
		q3.e = gt;
		q3.a8 = A_3;
		q3.j = A_3;
		q3.bi = A_0;
		if (A_0 == h6.b.b)
		{
			q3.a6 = A_1;
			q3.a7 = so(A_1, A_2);
		}
		q3 = null;
		if (sj(q2) != global::r.a.a)
		{
			throw new ah("Failed to update real time clock time");
		}
	}

	private void m2(object A_0, ElapsedEventArgs A_1)
	{
		p9();
	}

	private void p9()
	{
		string A_ = null;
		string A_2 = null;
		m2(ref A_, ref A_2, m2());
	}

	private q m2()
	{
		q obj = new q(global::r.d.a.b.b);
		obj.d = m.TaskExecutionType.SpectrometerNonSpectrum;
		((m)obj).a = m.a.a5;
		obj.g = new global::r.d();
		_ = null;
		return obj;
	}

	[SpecialName]
	public string st(int A_0, global::f.b A_1)
	{
		return iq[A_0][p9(A_0, A_1)].x7();
	}

	private void zb()
	{
		m2(A_0: true);
		GC.SuppressFinalize(this);
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in zb
		this.zb();
	}

	private void m2(bool A_0)
	{
		if (lj)
		{
			return;
		}
		if (l2 != null)
		{
			l2.a0();
		}
		if (il != null)
		{
			int num = ij.SetFrontPanelDisable(0);
			if (num != 0)
			{
				ab8().c(fz.b.a, "Error #" + num + " attempting to enable light source front panel controls.");
			}
			num = ij.SetD2LampState(0);
			if (num != 0)
			{
				ab8().c(fz.b.a, "Error #" + num + " attempting to turn off D2 lamp.");
			}
			num = ij.SetTHLampState(0);
			if (num != 0)
			{
				ab8().c(fz.b.a, "Error #" + num + " attempting to turn off TH lamp.");
			}
			sj(A_0: false);
		}
		lj = true;
	}

	~g7()
	{
		m2(A_0: false);
		base.Finalize();
	}

	public void sj(string A_0)
	{
	}

	public override global::r.a i(bool A_0)
	{
		if (ig)
		{
			return global::r.a.a;
		}
		global::r.a result = global::r.a.a;
		try
		{
			List<string> list = vl();
			if (list != null && list.Count > 0)
			{
				sj("MeasModuleSpec.Shutdown. ControllerSN=" + list[0]);
			}
			if (ux().Enabled)
			{
				ux().Stop();
			}
			if (l2 != null)
			{
				AutoResetEvent autoResetEvent = new AutoResetEvent(initialState: false);
				m2(global::r.d.a.b.b, null, autoResetEvent);
				if (!autoResetEvent.WaitOne(2000))
				{
					ab8().c(fz.b.b, "Timeout waiting for shut down camera in in MeasModuleSpec.Shutdown().");
				}
				autoResetEvent = null;
			}
			result = base.i(A_0);
			sj("MeasModuleSpec.Shutdown after MyBase.Shutdown");
			yg();
			zb();
			sj("MeasModuleSpec.Shutdown after Dispose");
			if ((y1() && global::e.a().LightSourceAutoStandby) || (yz() && im.zm()))
			{
				float a_ = ((!im.zm()) ? (im.st() / 2f) : 0f);
				im.m2(a_, A_1: true, A_2: false);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			ab8().c(fz.b.b, "Exception caught in MeasModuleSpec.Shutdown(). ", a_2);
			result = global::r.a.b;
			ProjectData.ClearProjectError();
		}
		finally
		{
			List<string> list2 = vl();
			if (list2 != null && list2.Count > 0)
			{
				sj("MeasModuleSpec.Shutdown Finally " + vl()[0]);
			}
		}
		ig = true;
		return result;
	}
}
