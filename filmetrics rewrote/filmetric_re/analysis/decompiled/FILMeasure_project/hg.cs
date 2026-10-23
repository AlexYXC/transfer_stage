using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic.MyServices;

internal class hg
{
	public enum a : short
	{
		a = 1,
		b = 2,
		c = 3,
		d = 4,
		e = 5,
		f = 6,
		g = 7,
		h = 8,
		i = 9,
		j = 10,
		k = 12,
		l = 13,
		m = 14,
		n = 15,
		o = 16,
		p = 17,
		q = 18,
		r = 19,
		s = 20,
		t = 21,
		u = 22,
		v = 23
	}

	public enum b : byte
	{
		a,
		b,
		c
	}

	public enum c
	{
		a,
		b,
		c
	}

	public enum d
	{
		a,
		b,
		c
	}

	private enum e : short
	{
		a = 1,
		b,
		c,
		d,
		e
	}

	private enum f : short
	{
		a = 1
	}

	public enum g
	{
		a,
		b
	}

	public enum h : short
	{
		a,
		b,
		c
	}

	public enum i
	{
		a,
		b,
		c
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
		c
	}

	public enum l
	{
		a,
		b,
		c,
		d
	}

	public enum m
	{
		a,
		b,
		c,
		d
	}

	public enum n
	{
		a,
		b
	}

	public enum o
	{
		a = 1,
		b,
		c,
		d
	}

	public enum p
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
		ag
	}

	public enum q
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
		l,
		m
	}

	public enum r
	{
		a,
		b,
		c
	}

	public delegate void s(global::r.d A_0, bool A_1, global::r.d.a.b A_2);

	public delegate void t(hg A_0);

	private bool m_a;

	public const string b = "Predefined";

	public const string c = "__";

	public const short d = 384;

	public const short e = 418;

	public const short f = 386;

	public const short g = 399;

	public const short h = 396;

	public const short i = 390;

	public const short j = -1;

	public const short k = 260;

	public const int l = 1;

	public const int m = 2;

	public const int n = 10;

	public const int o = 1;

	public const int p = 2;

	public const int q = 3;

	private const double m_r = 100.0;

	public const double s = 604800.0;

	public const float t = 0.3f;

	public Collection u;

	private const short v = 1;

	public const string w = "CTE";

	public const string x = "CTE";

	public const string y = "Uniform.";

	public const string z = "U";

	public const string aa = "Wedge";

	public const string ab = "W";

	public const string ac = "Wedge Ang.";

	public const string ad = "WA";

	public const string ae = "Val./Tot. Pts";

	public const string af = "V/T";

	public const string ag = "\\Patterns\\";

	public const string ah = "\\Patterns\\Custom\\";

	public const string ai = "\\Patterns\\Imported\\";

	public const string aj = ".pat";

	public const string ak = "globalCorr.dat";

	private const int al = 4100;

	private const int am = 14;

	public const string an = "Recipe";

	public const string ao = "Recipes";

	public const string ap = ".rpe";

	public const string aq = ".fitrp";

	public const string ar = ".fitra";

	public const string @as = ".fibra";

	public const string at = ".fibrp";

	public const string au = "LastRecipe.dat";

	public const string av = "DefaultRecipe";

	public const string aw = "Recipe Files (.fitrp)|*.fitrp";

	public const string ax = "Recipe Files (.fitra)|*.fitra";

	private const string ay = "AR Recipes (*.fitra)";

	private const string az = "Recipes (*.fitra)";

	private const string a0 = "Thickness Recipes (*.fitrp)";

	private const string a1 = "Recipes (*.fitrp)";

	private const string a2 = "All Recipes";

	public const string a3 = "Recipe File (.rpe)|*.rpe";

	public const string a4 = "Recipe Files |*.fitrp;*.fitra;*.rpe;*.fibra;*.fibrp";

	public const string a5 = "ImportRecipes\\";

	private static string a6;

	private const short a7 = 32;

	private const short a8 = 9;

	private const short a9 = 5;

	private const short ba = 6;

	private const short bb = 7;

	private const short bc = 8;

	private const short bd = 9;

	private const short be = 10;

	private const short bf = 11;

	private const short bg = 12;

	private const short bh = 12;

	private const string bi = "Flat";

	private const string bj = "Notch";

	private const string bk = "None";

	private const string bl = "Square";

	private bool bm;

	private j bn;

	private bool bo;

	private int bp;

	private Collection bq;

	private string br;

	private string bs;

	private string bt;

	private string m_bu;

	private double m_bv;

	private bool m_bw;

	private bool m_bx;

	private bool m_by;

	private h4 m_bz;

	private short m_b0;

	private string m_b1;

	private int m_b2;

	private short m_b3;

	private short m_b4;

	private short m_b5;

	private short m_b6;

	private short m_b7;

	private short m_b8;

	private double m_b9;

	private double m_ca;

	private bool m_cb;

	private double m_cc;

	private short m_cd;

	private short m_ce;

	private bool m_cf;

	private bool m_cg;

	private bool m_ch;

	private bool m_ci;

	private double m_cj;

	private double m_ck;

	private double m_cl;

	private double m_cm;

	private double m_cn;

	private double m_co;

	private string m_cp;

	private string m_cq;

	private string m_cr;

	private bool m_cs;

	private k m_ct;

	private eo m_cu;

	private float m_cv;

	private int m_cw;

	private double m_cx;

	private double m_cy;

	private bool m_cz;

	private string m_c0;

	private jk m_c1;

	private global::h m_c2;

	private const float m_c3 = 0.01f;

	private const float m_c4 = 0.01f;

	public const string c5 = "0.##";

	private const string m_c6 = " ";

	private const string m_c7 = "±";

	private const string m_c8 = "Sigma";

	private const string m_c9 = "\\f1 s\\f3 ";

	private const float m_da = 1E-06f;

	private g2 m_db;

	private int m_dc;

	private int m_dd;

	private b m_de;

	private Guid m_df;

	private c m_dg;

	private float m_dh;

	private float m_di;

	private bool m_dj;

	private string m_dk;

	private const string m_dl = "[Acquisition2 Settings]";

	private const string m_dm = "[Acquisition3 Settings]";

	private const string m_dn = "Spectrometer Type";

	private const string m_do = "Maximum Integration Time";

	private const string m_dp = "Fixed Integration Time (short wavelengths)";

	private const string m_dq = "Fixed Integration Cycles (short wavelengths)";

	private const string m_dr = "Fixed Integration Time (long wavelengths)";

	private const string m_ds = "Fixed Integration Cycles (long wavelengths)";

	private const string m_dt = "Peak Value (short wavelengths)";

	private const string m_du = "Peak Value (long wavelengths)";

	private const string m_dv = "Graph limits start wavelength";

	private const string m_dw = "Graph limits end wavelength";

	private const string m_dx = "Measure delay";

	private const string m_dy = "Dual Meas Selected Type";

	private const string m_dz = "Dual Meas Trans Spec Same As R";

	private const string m_d0 = "Stored baseline name";

	private const string m_d1 = "<Reference Material1>";

	private const string m_d2 = "<ReferenceMaterialKnown1>";

	private const string m_d3 = "<Reference Material2>";

	private const string m_d4 = "<ReferenceMaterialKnown2>";

	private const string m_d5 = "[AutoFocus Settings]";

	private const string m_d6 = "Auto Focus Max Signal Sample Thickness";

	private const string m_d7 = "[AutoFocus2 Settings]";

	private const string m_d8 = "[FFT Window]";

	private const string m_d9 = "<UseCustomOpticsConfig>";

	private const string m_ea = "<SystemGUID>";

	private const string m_eb = "<UseWithAnySystem>";

	private const string m_ec = "<OpticsConfiguration>";

	private const string m_ed = "[Layer Parameters V2]";

	private const string m_ee = "Use Robust Thickness Only if not FFT";

	private const string m_ef = "Show Thickness range in Thickness units";

	private const string m_eg = "Show nonuniformity in percent";

	private const string m_eh = "N grading fraction in layer #";

	private const string m_ei = "Solve for Grading in layer #";

	private const string m_ej = "Nonuniformity fraction in layer #";

	private const string m_ek = "Solve for Nonuniformity in layer #";

	private const string m_el = "[Site Average Reflectance]";

	private const string m_em = "MaxSolverRestarts";

	private const string en = "[WaferMap]";

	private const string eo = "Wafer Width";

	private const string ep = "Wafer Height";

	private const string eq = "[Wafer Details]";

	private const string er = "[Color Alarm]";

	private const string es = "Color Alarm Active";

	private const string et = "Color Alarm Coordinate System";

	private const string eu = "Color Coordinate 1 Min";

	private const string ev = "Color Coordinate 1 Max";

	private const string ew = "Color Coordinate 2 Min";

	private const string ex = "Color Coordinate 2 Max";

	private const string ey = "Color Coordinate 3 Min";

	private const string ez = "Color Coordinate 3 Max";

	private const string e0 = "Wafer Full Reference Mode";

	private const string e1 = "Number of Smoothing Points";

	private const string e2 = "[Photodiode Acq. Settings]";

	private const string e3 = "[SpectrometervsTime Acq. Settings]";

	private const string e4 = "[Z Optics]";

	private const string e5 = "GuidForDieInfo";

	private const string e6 = "[Layer CorrCoeffs]";

	private const string e7 = "CoefficientA";

	private const string e8 = "CoefficientB";

	private const string e9 = "[Vs Time Analysis Settings]";

	private const string fa = "[Backside Subtraction]";

	private const string fb = "Calc N From Extrema";

	private const string fc = "Calc N From Extrema Substrate";

	private const string fd = "[Spectrum Analysis Min/Max Hard Limits]";

	private const string fe = "[Site Z-Stage]";

	private const string ff = "[LayerReps]";

	private const string fg = "Ignore Baseline Info in Recipe";

	private const string fh = "LuminousReflectance";

	private const string fi = "YID1925";

	private const string fj = "[Additional Recipes]";

	private const string fk = "[OptoValues]";

	private const string fl = "FFT Measure Total Thickness";

	private const string fm = "FFT Total Thickness Threshold";

	private const string fn = "FFTWindowType";

	private const string fo = "FFTScalingFactor";

	private const string fp = "Reflective Objective Focus Range Percent";

	private const string fq = "Reflective Objective Focus Step Size Percent";

	private const string fr = "Map Origin Offset Type";

	private const string fs = "Map Origin Offset Absolute X";

	private const string ft = "Map Origin Offset Absolute Y";

	private const string fu = "Use Recipe Based MapAutosavePath";

	private const string fv = "Map Autosave Path";

	[CompilerGenerated]
	private s fw;

	[CompilerGenerated]
	private t fx;

	public bool fy;

	[CompilerGenerated]
	private float fz;

	[CompilerGenerated]
	private float f0;

	[CompilerGenerated]
	private bool f1;

	[CompilerGenerated]
	private bool f2;

	[CompilerGenerated]
	private float f3;

	[CompilerGenerated]
	private float f4;

	[CompilerGenerated]
	private bool f5;

	[CompilerGenerated]
	private bool f6;

	[CompilerGenerated]
	private n f7;

	[CompilerGenerated]
	private m f8;

	[CompilerGenerated]
	private h f9;

	public static string bu(b A_0)
	{
		switch (A_0)
		{
		case hg.b.a:
			return "Unknown";
		case hg.b.b:
			return "XXT-50 mm";
		case hg.b.c:
			return "XXT-19 mm";
		default:
		{
			int num = (int)A_0;
			throw new Exception("Cannot get Z optics name. " + num + " is not an invalid Z optics type.");
		}
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SendMessageA", ExactSpelling = true, SetLastError = true)]
	public static extern int bu(int A_0, int A_1, int A_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_3);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetLocaleInfoA", ExactSpelling = true, SetLastError = true)]
	private static extern int bu(int A_0, int A_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_2, int A_3);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetUserDefaultLCID();

	public static void bv(b2 A_0, bool A_1)
	{
		if (A_1)
		{
			A_0.a("Recipes (*.fitra)", "*.fitra", 1);
		}
		else
		{
			A_0.a("AR Recipes (*.fitra)", "*.fitra", 1);
		}
	}

	public static void bu(b2 A_0, bool A_1)
	{
		if (A_1)
		{
			A_0.a("Recipes (*.fitrp)", "*.fitrp", 0);
		}
		else
		{
			A_0.a("Thickness Recipes (*.fitrp)", "*.fitrp", 0);
		}
	}

	public static void bu(b2 A_0)
	{
		A_0.a("All Recipes", "*.fitra;*.fitrp", 2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void bu(s A_0)
	{
		s s2 = fw;
		s s3;
		do
		{
			s3 = s2;
			s value = (s)Delegate.Combine(s3, A_0);
			s2 = Interlocked.CompareExchange(ref fw, value, s3);
		}
		while ((object)s2 != s3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void bv(s A_0)
	{
		s s2 = fw;
		s s3;
		do
		{
			s3 = s2;
			s value = (s)Delegate.Remove(s3, A_0);
			s2 = Interlocked.CompareExchange(ref fw, value, s3);
		}
		while ((object)s2 != s3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void bu(t A_0)
	{
		t t2 = fx;
		t t3;
		do
		{
			t3 = t2;
			t value = (t)Delegate.Combine(t3, A_0);
			t2 = Interlocked.CompareExchange(ref fx, value, t3);
		}
		while ((object)t2 != t3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void bv(t A_0)
	{
		t t2 = fx;
		t t3;
		do
		{
			t3 = t2;
			t value = (t)Delegate.Remove(t3, A_0);
			t2 = Interlocked.CompareExchange(ref fx, value, t3);
		}
		while ((object)t2 != t3);
	}

	public void bu(s A_0, t A_1)
	{
		bu(A_0);
		bu(A_1);
	}

	public void bv(s A_0, t A_1)
	{
		bv(A_0);
		bv(A_1);
	}

	public static j b4()
	{
		return hg.j.a;
	}

	[SpecialName]
	public static bool bv(hg A_0, hg A_1)
	{
		switch (ix.a(A_0, A_1))
		{
		case ix.a.a:
			return false;
		case ix.a.b:
			return true;
		default:
		{
			hg hg2 = A_0;
			if (jk.s(hg2.m_c1, A_1.m_c1))
			{
				if (hg2.m_c1 != null && A_1.m_c1 != null)
				{
					return true;
				}
				jk jk2 = new jk();
				jk2.r();
				if (hg2.m_c1 == null)
				{
					if (jk.s(jk2, A_1.m_c1))
					{
						return true;
					}
				}
				else if (jk.s(jk2, hg2.m_c1))
				{
					return true;
				}
			}
			if (hg2.cn() != A_1.cn())
			{
				return true;
			}
			if (global::h.b(hg2.b8(), A_1.b8()))
			{
				return true;
			}
			if (Operators.CompareString(hg2.cm(), A_1.cm(), TextCompare: false) != 0)
			{
				return true;
			}
			if (Operators.CompareString(hg2.c3(), A_1.c3(), TextCompare: false) != 0)
			{
				return true;
			}
			if (Operators.CompareString(hg2.cl(), A_1.cl(), TextCompare: false) != 0)
			{
				return true;
			}
			if (hg2.dj() != A_1.dj())
			{
				return true;
			}
			if (hg2.dx() != A_1.dx())
			{
				return true;
			}
			if (hg2.co() != A_1.co())
			{
				return true;
			}
			if (hg2.cp() != A_1.cp())
			{
				return true;
			}
			if (hg2.dz() != A_1.dz())
			{
				return true;
			}
			if (hg2.dz() > 0)
			{
				int num = hg2.dz();
				for (int num2 = 1; num2 <= num; num2 = checked(num2 + 1))
				{
					if (hi.d5(hg2.b3(num2), A_1.b3(num2)))
					{
						return true;
					}
					if (!hg2.b3(num2).ft())
					{
						if (!jf.e(hg2.cj(), A_1.cj()))
						{
							return true;
						}
						if (!jf.e(hg2.ck(), A_1.ck()))
						{
							return true;
						}
					}
				}
			}
			if (Operators.CompareString(hg2.ci(), A_1.ci(), TextCompare: false) != 0)
			{
				return true;
			}
			if (h4.f(hg2.ca(), A_1.ca()))
			{
				return true;
			}
			if (g2.c(hg2.d0(), A_1.d0()))
			{
				return true;
			}
			if (hg2.m_de != A_1.m_de)
			{
				return true;
			}
			if (hg2.d2() != A_1.d2())
			{
				return true;
			}
			if (hg2.dy() != A_1.dy())
			{
				return true;
			}
			if (hg2.d3() != A_1.d3())
			{
				return true;
			}
			if (Operators.CompareString(hg2.d4(), A_1.d4(), TextCompare: false) != 0)
			{
				return true;
			}
			if (hg2.m_dg != A_1.m_dg)
			{
				return true;
			}
			if (hg2.m_dh != A_1.m_dh)
			{
				return true;
			}
			if (hg2.m_di != A_1.m_di)
			{
				return true;
			}
			if (hg2.m_dj != A_1.m_dj)
			{
				return true;
			}
			if (Operators.CompareString(hg2.m_dk, A_1.m_dk, TextCompare: false) != 0)
			{
				return true;
			}
			hg2 = null;
			return false;
		}
		}
	}

	[SpecialName]
	public static bool bu(hg A_0, hg A_1)
	{
		return !bv(A_0, A_1);
	}

	public bool bu(hg A_0)
	{
		return bu(this, A_0);
	}

	[SpecialName]
	public static string b3()
	{
		string A_ = "Recipe";
		return hu.a(ref A_);
	}

	public void bu(string A_0, DateTime A_1)
	{
		this.m_bu = A_0;
		this.m_bv = A_1.ToOADate();
	}

	public void bv(string A_0, DateTime A_1)
	{
		bu(A_0, A_1);
		bt = Guid.NewGuid().ToString();
	}

	public void bu(global::r.d A_0, bool A_1)
	{
		ed().cq = true;
		bu(A_0, A_1: true, A_1);
	}

	public void bu(global::r.d A_0, bool A_1 = false, bool A_2 = true)
	{
		bv(global::e.a().OperatorID, DateTime.Now);
		if (A_2)
		{
			b5(A_0: false);
		}
		bv(A_0, A_1);
	}

	public void bv(global::r.d A_0, bool A_1)
	{
		fw?.Invoke(A_0, A_1, global::r.d.a.b.a);
	}

	public void bv(hg A_0)
	{
		fx?.Invoke(A_0);
	}

	[SpecialName]
	public bool b5()
	{
		return b5(bs);
	}

	[SpecialName]
	public static bool b5(string A_0)
	{
		return A_0?.ToLower().EndsWith(".fitra") ?? false;
	}

	[SpecialName]
	public string b6()
	{
		return i3.d(bs, bz());
	}

	[SpecialName]
	public string b7()
	{
		string text = i3.d(bs, bz());
		int num = text.LastIndexOf(".");
		if (num >= 0)
		{
			return text.Substring(0, num);
		}
		return text;
	}

	[SpecialName]
	public global::h b8()
	{
		return this.m_c2;
	}

	[SpecialName]
	public jk b9()
	{
		if (this.m_c1 == null)
		{
			this.m_c1 = new jk();
		}
		return this.m_c1;
	}

	[SpecialName]
	public void bu(jk A_0)
	{
		this.m_c1 = A_0;
	}

	[SpecialName]
	public h4 ca()
	{
		return this.m_bz;
	}

	[SpecialName]
	public void bu(h4 A_0)
	{
		this.m_bz = A_0;
	}

	[SpecialName]
	public bool cb()
	{
		if (b5())
		{
			return false;
		}
		int num = dz();
		for (int num2 = 1; num2 <= num; num2 = checked(num2 + 1))
		{
			if (!b3(num2).ft())
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public int cc()
	{
		return (int)bn;
	}

	[SpecialName]
	public void bw(int A_0)
	{
		bn = (j)A_0;
		bo = true;
	}

	[SpecialName]
	public j cd()
	{
		return bn;
	}

	[SpecialName]
	public bool ce()
	{
		int num = dz();
		bool flag = true;
		for (int num2 = 1; (num2 <= num) & flag; num2 = checked(num2 + 1))
		{
			if (num2 <= num && !b3(num2).he())
			{
				flag = false;
			}
		}
		return flag;
	}

	[SpecialName]
	public string cf()
	{
		return this.m_cq;
	}

	[SpecialName]
	public void b6(string A_0)
	{
		this.m_cq = A_0;
	}

	[SpecialName]
	public string cg()
	{
		return this.m_cp;
	}

	[SpecialName]
	public void b7(string A_0)
	{
		this.m_cp = A_0;
	}

	[SpecialName]
	public string ch()
	{
		return this.m_cr;
	}

	[SpecialName]
	public void b8(string A_0)
	{
		this.m_cr = A_0;
	}

	[SpecialName]
	public string ci()
	{
		return br;
	}

	[SpecialName]
	public void b9(string A_0)
	{
		br = A_0;
	}

	[SpecialName]
	public double cj()
	{
		return this.m_cx;
	}

	[SpecialName]
	public void bu(double A_0)
	{
		this.m_cx = A_0;
	}

	[SpecialName]
	public double ck()
	{
		return this.m_cy;
	}

	[SpecialName]
	public void bv(double A_0)
	{
		this.m_cy = A_0;
	}

	public void bu(ref float A_0, ref float A_1)
	{
		A_0 = (float)this.m_cx;
		if (A_0 == 0f && this.m_cy == 0.0)
		{
			A_1 = 50000f;
		}
		else
		{
			A_1 = (float)this.m_cy;
		}
	}

	[SpecialName]
	public string cl()
	{
		return bt;
	}

	[SpecialName]
	public void ca(string A_0)
	{
		bt = A_0;
	}

	[SpecialName]
	public string cm()
	{
		return this.m_bu;
	}

	[SpecialName]
	public void cb(string A_0)
	{
		this.m_bu = A_0;
	}

	[SpecialName]
	public double cn()
	{
		return this.m_bv;
	}

	[SpecialName]
	public void bw(double A_0)
	{
		this.m_bv = A_0;
	}

	[SpecialName]
	public bool co()
	{
		return this.m_bx;
	}

	[SpecialName]
	public void bw(bool A_0)
	{
		this.m_bx = A_0;
	}

	[SpecialName]
	public bool cp()
	{
		return this.m_by;
	}

	[SpecialName]
	public void bx(bool A_0)
	{
		this.m_by = A_0;
	}

	[SpecialName]
	public short cq()
	{
		return this.m_b0;
	}

	[SpecialName]
	public void bu(short A_0)
	{
		this.m_b0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public float cr()
	{
		return fz;
	}

	[SpecialName]
	[CompilerGenerated]
	public void bu(float A_0)
	{
		fz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public float cs()
	{
		return f0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void bv(float A_0)
	{
		f0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool ct()
	{
		return f1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void by(bool A_0)
	{
		f1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool cu()
	{
		return f2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void bz(bool A_0)
	{
		f2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public float cv()
	{
		return f3;
	}

	[SpecialName]
	[CompilerGenerated]
	public void bw(float A_0)
	{
		f3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public float cw()
	{
		return f4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void bx(float A_0)
	{
		f4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool cx()
	{
		return f5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void b0(bool A_0)
	{
		f5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool cy()
	{
		return f6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void b1(bool A_0)
	{
		f6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public n cz()
	{
		return f7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void bu(n A_0)
	{
		f7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public m c0()
	{
		return f8;
	}

	[SpecialName]
	[CompilerGenerated]
	public void bu(m A_0)
	{
		f8 = A_0;
	}

	[SpecialName]
	public string c1()
	{
		return bs;
	}

	[SpecialName]
	public void cc(string A_0)
	{
		bs = A_0;
	}

	[SpecialName]
	public int c2()
	{
		return bp;
	}

	[SpecialName]
	public void bx(int A_0)
	{
		bp = A_0;
	}

	[SpecialName]
	public string c3()
	{
		return this.m_b1;
	}

	[SpecialName]
	public void cd(string A_0)
	{
		this.m_b1 = A_0;
	}

	[SpecialName]
	public int c4()
	{
		return this.m_b2;
	}

	[SpecialName]
	public void by(int A_0)
	{
		if ((A_0 >= 0) & (A_0 <= 3))
		{
			this.m_b2 = A_0;
		}
	}

	[SpecialName]
	public string c5()
	{
		return this.m_b2 switch
		{
			0 => "Flat", 
			1 => "Notch", 
			2 => "None", 
			3 => "Square", 
			_ => "Notch", 
		};
	}

	[SpecialName]
	public void ce(string A_0)
	{
		switch (A_0)
		{
		case "Flat":
			this.m_b2 = 0;
			break;
		case "Notch":
			this.m_b2 = 1;
			break;
		case "None":
			this.m_b2 = 2;
			break;
		case "Square":
			this.m_b2 = 3;
			break;
		default:
			this.m_b2 = 1;
			break;
		}
	}

	[SpecialName]
	public bool c6()
	{
		return this.m_cf;
	}

	[SpecialName]
	public void b2(bool A_0)
	{
		this.m_cf = A_0;
	}

	[SpecialName]
	public bool c7()
	{
		return this.m_cg;
	}

	[SpecialName]
	public void b3(bool A_0)
	{
		this.m_cg = A_0;
	}

	[SpecialName]
	public bool c8()
	{
		return this.m_ch;
	}

	[SpecialName]
	public void b4(bool A_0)
	{
		this.m_ch = A_0;
	}

	[SpecialName]
	public bool c9()
	{
		return bm;
	}

	[SpecialName]
	public void b5(bool A_0)
	{
		bm = A_0;
	}

	[SpecialName]
	public int da()
	{
		return this.m_dc;
	}

	[SpecialName]
	public void bz(int A_0)
	{
		this.m_dc = A_0;
	}

	[SpecialName]
	public int db()
	{
		return this.m_dd;
	}

	[SpecialName]
	public void b0(int A_0)
	{
		this.m_dd = A_0;
	}

	[SpecialName]
	public short dc()
	{
		return this.m_b3;
	}

	[SpecialName]
	public void bv(short A_0)
	{
		checked
		{
			this.m_b3 = (short)unchecked(-(short)(0 - ((A_0 != 0) ? 1 : 0)));
		}
	}

	[SpecialName]
	public short dd()
	{
		return this.m_b4;
	}

	[SpecialName]
	public void bw(short A_0)
	{
		checked
		{
			this.m_b4 = (short)unchecked(-(short)(0 - ((A_0 != 0) ? 1 : 0)));
		}
	}

	[SpecialName]
	public short de()
	{
		return this.m_b5;
	}

	[SpecialName]
	public void bx(short A_0)
	{
		checked
		{
			this.m_b5 = (short)unchecked(-(short)(0 - ((A_0 != 0) ? 1 : 0)));
		}
	}

	[SpecialName]
	public short df()
	{
		return this.m_b6;
	}

	[SpecialName]
	public void by(short A_0)
	{
		checked
		{
			this.m_b6 = (short)unchecked(-(short)(0 - ((A_0 != 0) ? 1 : 0)));
		}
	}

	[SpecialName]
	public short dg()
	{
		return this.m_b7;
	}

	[SpecialName]
	public void bz(short A_0)
	{
		checked
		{
			this.m_b7 = (short)unchecked(-(short)(0 - ((A_0 != 0) ? 1 : 0)));
		}
	}

	[SpecialName]
	public eo dh()
	{
		return this.m_cu;
	}

	[SpecialName]
	public bool di()
	{
		if (dj() != 0)
		{
			return !b5();
		}
		return false;
	}

	[SpecialName]
	public short dj()
	{
		return this.m_b8;
	}

	[SpecialName]
	public void b0(short A_0)
	{
		checked
		{
			this.m_b8 = (short)unchecked(-(short)(0 - ((A_0 != 0) ? 1 : 0)));
		}
	}

	[SpecialName]
	public double dk()
	{
		return this.m_b9;
	}

	[SpecialName]
	public void bx(double A_0)
	{
		this.m_b9 = A_0;
	}

	[SpecialName]
	public double dl()
	{
		return this.m_ca;
	}

	[SpecialName]
	public void by(double A_0)
	{
		this.m_ca = A_0;
	}

	[SpecialName]
	public bool dm()
	{
		return this.m_cb;
	}

	[SpecialName]
	public void b6(bool A_0)
	{
		this.m_cb = A_0;
	}

	[SpecialName]
	public double dn()
	{
		return this.m_cc;
	}

	[SpecialName]
	public void bz(double A_0)
	{
		this.m_cc = A_0;
	}

	[SpecialName]
	public short @do()
	{
		return this.m_cd;
	}

	[SpecialName]
	public void b1(short A_0)
	{
		checked
		{
			this.m_cd = (short)unchecked(-(short)(0 - ((A_0 != 0) ? 1 : 0)));
		}
	}

	[SpecialName]
	public short dp()
	{
		return this.m_ce;
	}

	[SpecialName]
	public void b2(short A_0)
	{
		checked
		{
			this.m_ce = (short)unchecked(-(short)(0 - ((A_0 != 0) ? 1 : 0)));
		}
	}

	[SpecialName]
	public bool dq()
	{
		return this.m_ci;
	}

	[SpecialName]
	public void b7(bool A_0)
	{
		this.m_ci = A_0;
	}

	[SpecialName]
	public double dr()
	{
		return this.m_cj;
	}

	[SpecialName]
	public void b0(double A_0)
	{
		this.m_cj = A_0;
	}

	[SpecialName]
	public double ds()
	{
		return this.m_ck;
	}

	[SpecialName]
	public void b1(double A_0)
	{
		this.m_ck = A_0;
	}

	[SpecialName]
	public double dt()
	{
		return this.m_cl;
	}

	[SpecialName]
	public void b2(double A_0)
	{
		this.m_cl = A_0;
	}

	[SpecialName]
	public double du()
	{
		return this.m_cm;
	}

	[SpecialName]
	public void b3(double A_0)
	{
		this.m_cm = A_0;
	}

	[SpecialName]
	public double dv()
	{
		return this.m_cn;
	}

	[SpecialName]
	public void b4(double A_0)
	{
		this.m_cn = A_0;
	}

	[SpecialName]
	public double dw()
	{
		return this.m_co;
	}

	[SpecialName]
	public void b5(double A_0)
	{
		this.m_co = A_0;
	}

	[SpecialName]
	public float dx()
	{
		if (this.m_cu.az() < this.m_cv)
		{
			return this.m_cu.az();
		}
		return this.m_cv;
	}

	[SpecialName]
	public void by(float A_0)
	{
		this.m_cv = A_0;
	}

	[SpecialName]
	public int dy()
	{
		if (this.m_cw < 1)
		{
			return 1;
		}
		return this.m_cw;
	}

	[SpecialName]
	public void b1(int A_0)
	{
		this.m_cw = A_0;
	}

	public static int bv(int A_0)
	{
		return checked((int)Math.Round((double)(A_0 - 1) * 0.5));
	}

	public static int bu(int A_0)
	{
		return checked(A_0 * 2 + 1);
	}

	[SpecialName]
	public int dz()
	{
		return bq.Count;
	}

	[SpecialName]
	public g2 d0()
	{
		return this.m_db;
	}

	[SpecialName]
	public void bu(g2 A_0)
	{
		this.m_db = A_0;
	}

	[SpecialName]
	public b d1()
	{
		return this.m_de;
	}

	[SpecialName]
	public void bv(b A_0)
	{
		this.m_de = A_0;
	}

	[SpecialName]
	public Guid d2()
	{
		return this.m_df;
	}

	[SpecialName]
	public void bu(Guid A_0)
	{
		this.m_df = A_0;
	}

	[SpecialName]
	public bool d3()
	{
		if (this.m_cz)
		{
			return this.m_cu.br();
		}
		return false;
	}

	[SpecialName]
	public void b8(bool A_0)
	{
		this.m_cz = A_0;
	}

	[SpecialName]
	public string d4()
	{
		return this.m_c0;
	}

	[SpecialName]
	public void cf(string A_0)
	{
		this.m_c0 = A_0;
	}

	[SpecialName]
	public c d5()
	{
		return this.m_dg;
	}

	[SpecialName]
	public void bu(c A_0)
	{
		this.m_dg = A_0;
	}

	[SpecialName]
	public float d6()
	{
		return this.m_dh;
	}

	[SpecialName]
	public void bz(float A_0)
	{
		this.m_dh = A_0;
	}

	[SpecialName]
	public float d7()
	{
		return this.m_di;
	}

	[SpecialName]
	public void b0(float A_0)
	{
		this.m_di = A_0;
	}

	[SpecialName]
	public bool d8()
	{
		return this.m_dj;
	}

	[SpecialName]
	public void b9(bool A_0)
	{
		this.m_dj = A_0;
	}

	[SpecialName]
	public string d9()
	{
		return this.m_dk;
	}

	[SpecialName]
	public void cg(string A_0)
	{
		this.m_dk = A_0;
	}

	public static bool bu(hr A_0, hg A_1, bool A_2, bool A_3, bool A_4)
	{
		eo.a a_ = null;
		if (A_0.cu().q() == null && !global::eo.at(A_2, A_3, a_) && !A_4)
		{
			return !jf.e(A_0.cf, A_1.dx()) || A_0.ch != A_1.d3() || (A_1.d3() && Operators.CompareString(A_0.ci, A_1.d4(), TextCompare: false) != 0);
		}
		return !jf.e(A_0.cg, A_1.dy());
	}

	public static bool bu(double A_0, double A_1, ref string A_2)
	{
		if (A_0 < 100.0 || A_0 > A_1)
		{
			string A_3 = "ValuesBetweenFmt3";
			string format = hu.a(ref A_3);
			A_3 = "SpectrumSmoothingThickness";
			A_2 = string.Format(format, hu.a(ref A_3), bu(hg.o.a, new h4(h4.a.c), 100.0, 2, new h4(h4.a.b), 0), bu(hg.o.a, new h4(h4.a.c), A_1, 2, new h4(h4.a.b), 0));
			return false;
		}
		return true;
	}

	[SpecialName]
	[CompilerGenerated]
	public h ea()
	{
		return f9;
	}

	[SpecialName]
	[CompilerGenerated]
	public void bu(h A_0)
	{
		f9 = A_0;
	}

	public void bu(hi A_0, object A_1 = null, object A_2 = null)
	{
		if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(A_1)))
		{
			bq.Add(A_0, null, Conversions.ToInteger(A_1));
		}
		else if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(A_2)))
		{
			bq.Add(A_0, null, null, Conversions.ToInteger(A_2));
		}
		else
		{
			bq.Add(A_0);
		}
	}

	public void b2(int A_0)
	{
		bq.Remove(A_0);
	}

	public void eb()
	{
		bq = new Collection();
	}

	public void ec()
	{
	}

	public hi b3(int A_0)
	{
		if (A_0 <= 0 || A_0 > bq.Count)
		{
			return null;
		}
		return (hi)bq[A_0];
	}

	public hi ed()
	{
		if (bq.Count == 0)
		{
			return null;
		}
		return (hi)bq[bp];
	}

	public hj bu(bool A_0, eo.a A_1, ref int A_2)
	{
		if (!this.m_cu.a4(A_1))
		{
			return null;
		}
		List<hj> list = ed().es();
		int num = A_2;
		checked
		{
			int num2 = list.Count - 1;
			for (A_2 = num; A_2 <= num2; A_2++)
			{
				hj hj2 = list[A_2];
				switch (hj2.f())
				{
				case hj.a.b:
					A_2++;
					return hj2;
				case hj.a.c:
					if (!A_0)
					{
						A_2++;
						return hj2;
					}
					break;
				}
			}
			return null;
		}
	}

	public int b4(int A_0 = 0)
	{
		if (A_0 == 0)
		{
			A_0 = bp;
		}
		return b3(A_0).g6();
	}

	public int b5(int A_0 = 0)
	{
		if (A_0 == 0)
		{
			A_0 = bp;
		}
		return b3(A_0).g7();
	}

	public bool bu(string A_0, j A_1, global::r.d A_2, global::r.d.a.b A_3, bool A_4, bool A_5, Point A_6, string A_7, g2.b A_8, bool A_9, fz A_10, hf A_11, bool A_12, bool A_13, hd A_14, bool A_15)
	{
		bool result;
		try
		{
			this.m_bw = A_12;
			string A_16;
			bool a_;
			if (!File.Exists(A_0))
			{
				result = false;
			}
			else
			{
				bw((int)A_1);
				if (string.Compare(Path.GetExtension(A_0), ".rpe", ignoreCase: true) != 0)
				{
					A_16 = A_0;
					a_ = false;
					goto IL_005f;
				}
				if (bu(A_0, A_2, A_3, A_10, A_1))
				{
					A_16 = i3.g() + "\\CurrentRecipe.txt";
					a_ = true;
					goto IL_005f;
				}
				result = false;
			}
			goto end_IL_0000;
			IL_005f:
			if (!bw(ref A_16))
			{
				result = false;
			}
			else if (bu(ref A_16, a_))
			{
				bs = A_0;
				result = true;
				ej();
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(A_0);
				if ((Operators.CompareString(br, fileNameWithoutExtension, TextCompare: false) != 0) & (Operators.CompareString(Strings.LCase(Strings.Right(A_0, 3)), "txt", TextCompare: false) != 0))
				{
					br = fileNameWithoutExtension;
				}
				bu(A_8, A_9);
				if (A_3 == global::r.d.a.b.a && A_5)
				{
					bu(A_10, A_6, A_7, A_11, A_4: false, A_5: false, null, A_7: false, null);
				}
				if (ed().hq())
				{
					result = false;
				}
				else
				{
					fw?.Invoke(A_2, A_4, A_3);
				}
			}
			else
			{
				result = false;
			}
			end_IL_0000:;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			A_10.c(global::fz.b.b, "Error in CheckAndLoadRecipe: Error is " + ex3.Message);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void bu(g2.b A_0, bool A_1)
	{
		if (this.m_db == null)
		{
			return;
		}
		switch (A_0)
		{
		case g2.b.b:
			if (!this.m_db.o())
			{
				if (A_1)
				{
					this.m_db.o(g2.a.i);
				}
				else
				{
					this.m_db.o(g2.a.h);
				}
			}
			break;
		default:
			throw new ApplicationException("Invalid requiredOpticsConfigCompat");
		case g2.b.a:
			break;
		}
	}

	public bool bw(ref string A_0)
	{
		string A_1 = null;
		bool result;
		try
		{
			string text = ((Operators.CompareString(Path.GetExtension(A_0).ToLower(), ".txt", TextCompare: false) != 0) ? File.ReadAllText(A_0, Encoding.UTF8) : File.ReadAllText(A_0, Encoding.UTF7));
			if (text.IndexOf("CHECKSUM=") < 0)
			{
				result = false;
			}
			else
			{
				int A_2 = 0;
				i3.a(ref A_2, text, ref A_1);
				i3.a(ref A_2, text, ref A_1);
				int a_ = int.Parse(A_1, CultureInfo.InvariantCulture);
				i3.a(ref A_2, text, ref A_1);
				i3.a(ref A_2, text, ref br);
				int num = text.IndexOf("CHECKSUM=");
				int num2 = bu(text.Substring(0, num), a_);
				int num3 = int.Parse(text.Substring(checked(num + "CHECKSUM=".Length)), CultureInfo.InvariantCulture);
				result = num2 == num3;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private int bu(string A_0, int A_1)
	{
		int num = 0;
		string text = A_0;
		if (A_1 >= 5)
		{
			text = text.Replace(" ", "");
			text = text.Replace("\t", "");
		}
		byte[] bytes = Encoding.Unicode.GetBytes(text);
		foreach (byte b10 in bytes)
		{
			num = checked(num + b10);
		}
		return num;
	}

	public void bu(ref hg A_0)
	{
		if (A_0 == null)
		{
			A_0 = new hg(this.m_cu, bn);
		}
		hg hg2 = A_0;
		global::h obj = this.m_c2;
		global::h A_1 = hg2.b8();
		obj.a(ref A_1);
		hg2.bn = bn;
		hg2.bo = bo;
		hg2.b9(br);
		hg2.ca(bt);
		hg2.cb(this.m_bu);
		hg2.bw(this.m_bv);
		hg2.ca(this.m_bw);
		h4 obj2 = ca();
		hg hg3;
		h4 A_2 = (hg3 = hg2).ca();
		obj2.e(ref A_2);
		hg3.bu(A_2);
		hg2.bu(this.m_b0);
		hg2.bu(cr());
		hg2.bv(cs());
		hg2.cd(this.m_b1);
		hg2.ce(c5());
		hg2.b2(c6());
		hg2.b3(c7());
		hg2.b4(c8());
		hg2.bv(this.m_b3);
		hg2.bw(this.m_b4);
		hg2.bx(this.m_b5);
		hg2.by(this.m_b6);
		hg2.bz(this.m_b7);
		hg2.b0(this.m_b8);
		hg2.bx(this.m_b9);
		hg2.by(this.m_ca);
		hg2.b6(this.m_cb);
		hg2.bz(this.m_cc);
		hg2.b1(this.m_cd);
		hg2.b2(this.m_ce);
		hg2.cc(bs);
		hg2.bx(bp);
		hg2.b7(this.m_ci);
		hg2.b0(this.m_cj);
		hg2.b1(this.m_ck);
		hg2.b2(this.m_cl);
		hg2.b3(this.m_cm);
		hg2.b4(this.m_cn);
		hg2.b5(this.m_co);
		hg2.bw(this.m_bx);
		hg2.bx(this.m_by);
		hg2.by(this.m_cv);
		hg2.b1(this.m_cw);
		hg2.bu(this.m_cx);
		hg2.bv(this.m_cy);
		hg2.b7(this.m_cp);
		hg2.b6(this.m_cq);
		hg2.b8(this.m_cr);
		hg2.eb();
		int num = dz();
		for (int num2 = 1; num2 <= num; num2 = checked(num2 + 1))
		{
			hi obj3 = b3(num2);
			hi A_3 = new hi(this.m_cu);
			obj3.au(ref A_3);
			hg2.bu(A_3);
			A_3 = null;
		}
		hg2.b5(bm);
		hg2.fy = fy;
		if (this.m_db == null)
		{
			hg2.bu((g2)null);
		}
		else
		{
			g2 obj4 = this.m_db;
			g2 A_4 = (hg3 = hg2).d0();
			obj4.a(ref A_4);
			hg3.bu(A_4);
		}
		hg2.m_de = this.m_de;
		hg2.bu(d2());
		hg2.bu(ea());
		hg2.bz(da());
		hg2.b0(db());
		if (this.m_c1 == null)
		{
			hg2.m_c1 = null;
		}
		else
		{
			this.m_c1.r(ref hg2.m_c1);
		}
		hg2.b8(this.m_cz);
		hg2.cf(this.m_c0);
		hg2.m_dg = this.m_dg;
		hg2.m_dh = this.m_dh;
		hg2.m_di = this.m_di;
		hg2.m_dj = this.m_dj;
		hg2.m_dk = this.m_dk;
		hg2 = null;
	}

	private static string b4(string A_0)
	{
		if (Operators.CompareString(A_0, "<Graded Interface>", TextCompare: false) == 0)
		{
			return "<Graded>";
		}
		return A_0;
	}

	private static string b3(string A_0)
	{
		if (Operators.CompareString(A_0, "<Graded>", TextCompare: false) == 0)
		{
			return "<Graded Interface>";
		}
		return A_0;
	}

	public string ee()
	{
		if (!bo)
		{
			throw new am("Software config must be set prior to writing a recipe from file");
		}
		string text = "***Machine Readable Structure Export Version (Copy all lines)," + Conversion.Str((short)12) + "\r\n";
		text = text + "Name, " + bv(jg.f(br), 0, 0, A_3: true) + "\r\n";
		text = text + "GUID, " + bv(bt, 0, 0, false) + "\r\n";
		text = text + "UserID, " + bv(jg.f(this.m_bu), 0, 0, A_3: true) + "\r\n";
		text = text + "Mod. Date(" + DateTime.FromOADate(this.m_bv).ToString(CultureInfo.InvariantCulture) + ")," + Conversion.Str(this.m_bv) + "\r\n";
		text = text + "Num Location, " + Conversion.Str(dz()) + "\r\n";
		this.m_bz.e(ref text);
		int num = dz();
		checked
		{
			for (int num2 = 1; num2 <= num; num2++)
			{
				hi hi2 = b3(num2);
				hi hi3 = hi2;
				text = text + "\r\n===== Measure Site " + Conversion.Str(num2) + " =====\r\n";
				text = text + "Measure Site Location XY (mm)," + Conversion.Str(hi3.fq()) + "," + Conversion.Str(hi3.fp()) + "\r\n";
				text = text + "Enable Robust Thickness," + bv(hi3.g0()) + "\r\n";
				text = text + "Enable FFT Thickness Only, " + bv(hi3.g4()) + "\r\n";
				text = text + "Valid measurement requires GOF," + Conversion.Str(hi3.gq()) + "\r\n";
				text = text + "Solve for GOF," + bv(hi3.ga()) + "\r\n";
				text = text + "Valid FFT measurement requires intensity," + Conversion.Str(hi3.gr()) + "\r\n";
				if (bn == hg.j.c)
				{
					text += "\r\n[Custom Measurement]\r\n";
					text = text + "Custom measure 1," + bu(hi3.fl().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
					text = text + "Custom measure 2," + bu(hi3.fm().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
					text = text + "Custom measure 3," + bu(hi3.fn().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
					text = text + "Custom measure 4," + bu(hi3.fo().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
					text += "\r\n[Difference Site]\r\n";
					text = text + "DifferenceSite," + bu(hi3.fz().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
					text = text + "DifferenceReferenceSite," + Conversions.ToString(hi3.f0()) + "\r\n";
					text += "\r\n[Mixed Site]\r\n";
					text = text + "MixedSite," + bu(hi3.f1().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
					text = text + "MixedReferenceSite," + Conversions.ToString(hi3.f2()) + "\r\n";
					text = text + "MixedRefSiteFraction," + Conversions.ToString(hi3.f3()) + "\r\n";
					text = text + "MixedCurrSiteFraction," + Conversions.ToString(hi3.f4()) + "\r\n";
				}
				else
				{
					text += "[Correlative Coefficients]\r\n";
					text = text + "Coefficients A," + Conversion.Str(hi3.br.a) + "\r\n";
					text = text + "Coefficients B," + Conversion.Str(hi3.br.b) + "\r\n";
					text = text + "Correlative min. thickness(" + ca().l() + ")," + Conversion.Str(h4.e(1, hi3.br.c, ca())) + "\r\n";
					text = text + "Correlative max. thickness(" + ca().l() + ")," + Conversion.Str(h4.e(1, hi3.br.d, ca())) + "\r\n";
					text = text + "Correlative Active," + bu(hi3.hd().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				}
				text += "\r\n[Layers]\r\n";
				text = text + "Number of Layers, " + Conversion.Str(hi3.g6()) + "\r\n";
				text += bv("Layer ID", 10);
				text += bv("Material", 17, 1, A_3: true);
				text += bv("Thick.(" + ca().l() + ")", 10, 1, A_3: true);
				text += bv("Rough.(" + ca().l() + ")", 10, 1, A_3: true);
				text += bv("d", 5, 1);
				text += bv("n", 5, 1);
				text += bv("k", 5, 1);
				text = text + bv("r", 5, 1) + "\r\n";
				int num3 = hi3.g6() + 1;
				int A_2;
				int A_3;
				bool flag;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					gc gc2 = hi3.et(num4);
					string a_ = ((num4 != 0) ? ((num4 != hi3.g6() + 1) ? ("Layer " + Conversion.Str(num4)) : "Substrate") : "Medium");
					text += bv(a_, 10, 1);
					text = text + "," + bv(jg.f(b4(gc2.ag())), 17, 1, A_3: true);
					text = text + "," + bv(Conversion.Str(h4.e(1, gc2.ai(), ca())), 10, 1);
					text = text + "," + bv(Conversion.Str(h4.e(1, gc2.an(), ca())), 10, 1);
					flag = gc2.ao();
					string text2 = text;
					string A_ = flag.ToString(CultureInfo.InvariantCulture);
					A_2 = 5;
					A_3 = 1;
					bool A_4 = false;
					text = text2 + "," + bu(ref A_, ref A_2, ref A_3, ref A_4);
					flag = gc2.ap();
					string text3 = text;
					A_ = flag.ToString(CultureInfo.InvariantCulture);
					A_3 = 5;
					A_2 = 1;
					A_4 = false;
					text = text3 + "," + bu(ref A_, ref A_3, ref A_2, ref A_4);
					flag = gc2.aq();
					string text4 = text;
					A_ = flag.ToString(CultureInfo.InvariantCulture);
					A_2 = 5;
					A_3 = 1;
					A_4 = false;
					text = text4 + "," + bu(ref A_, ref A_2, ref A_3, ref A_4);
					flag = gc2.ar();
					string text5 = text;
					A_ = flag.ToString(CultureInfo.InvariantCulture);
					A_3 = 5;
					A_2 = 1;
					A_4 = false;
					text = text5 + "," + bu(ref A_, ref A_3, ref A_2, ref A_4);
					text += "\r\n";
					gc2 = null;
				}
				text += "\r\n[Constraints]\r\n";
				text += bv("Layer ID", 17);
				text += bv("Thick(%)", 10, 1);
				text += bv("N", 10, 1);
				text = text + bv("K", 10, 1) + "\r\n";
				bool flag2 = true;
				bool flag3 = false;
				A_2 = hi3.g6() + 1;
				for (int num4 = 0; num4 <= A_2; num4++)
				{
					gc gc2 = hi3.et(num4);
					string a_ = ((num4 == 0) ? "Medium" : ((num4 != hi3.g6() + 1) ? ("Layer " + Conversion.Str(num4)) : "Substrate"));
					text += bv(a_, 17, 1, A_3: true);
					text = text + "," + bv(Conversion.Str(gc2.av()), 10, 1);
					text = text + "," + bv(Conversion.Str(gc2.aw()), 10, 1);
					text = text + "," + bv(Conversion.Str(gc2.ax()), 10, 1);
					text += "\r\n";
					if (gc2.ao())
					{
						if (gc2.at())
						{
							flag3 = true;
						}
						else
						{
							flag2 = false;
						}
					}
					gc2 = null;
				}
				text = text + "Account for nonplanarity," + bu(hi3.gv().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "Account for nonuniformity," + bu((flag3 && flag2).ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "Lock identical layers," + bu(hi3.hf().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text += "\r\n[Options]\r\n";
				bool flag4 = hi3.eq(0) && hi3.ep(0);
				text = text + "Reflectance Option?," + bu((hi3.eq(0) && !flag4).ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "Transmittance Option?," + bu((hi3.ep(0) && !flag4).ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				flag = flag4;
				text = text + "Simultaneous Reflectance & Transmittance Option?," + bu(flag.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "Angle," + Conversion.Str(hi3.f8()) + "\r\n";
				text = text + "TE Polarization?," + bu(hi3.f7().ToString(), 0, 0, false) + "\r\n";
				text = text + "Transmittance File Name," + bv(jg.f(hi3.f9()), 0, 0, A_3: true) + "\r\n";
				text = text + "Use Grid Search for Initial Thickness," + bu(hi3.gx().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "Use Fourier Search for Initial Thickness," + bu(hi3.gw().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "Account for Back Reflectance," + bu(hi3.gu().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "SolverGOFTarget setting," + Conversion.Str(hi3.gs()) + "\r\n";
				text = text + "Max Iterations," + Conversion.Str(hi3.go()) + "\r\n";
				A_3 = hi3.g6() + 1;
				for (int num4 = 0; num4 <= A_3; num4++)
				{
					gc gc2 = hi3.et(num4);
					string a_ = ((num4 != 0) ? ((num4 != hi3.g6() + 1) ? ("Layer " + Strings.Trim(Conversion.Str(num4)) + " n & k model,") : "Substrate n & k model,") : "Medium n model,");
					text += a_;
					text = text + bv(jg.f(gc2.au()), 0, 0, A_3: true) + "\r\n";
					gc2 = null;
				}
				text = text + "Wavelength for n and k display," + Conversion.Str(hi3.f6()) + "\r\n";
				text = text + "Displayed Data?," + bu(hi3.fu().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "Fixed Range?," + bu(hi3.ft().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "Range From," + Conversion.Str(hi3.fs()) + "\r\n";
				text = text + "To," + Conversion.Str(hi3.fr()) + "\r\n";
				if ((unchecked(0 - ((bn == hg.j.c) ? 1 : 0)) | 1) != 0)
				{
					text += "[SiteMapParams]\r\n";
					text = text + "CoordSystem Is Wafer," + bu(hi3.he().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
					text = text + "DIF Site ID," + Conversion.Str(hi3.f5()) + "\r\n";
					text = text + "Coordinate System," + bv(hi3.fk(), 0, 0, A_3: true) + "\r\n";
					text = text + "Number of Points or Pat name," + bv(jg.f(hi3.g8()), 0, 0, A_3: true) + "\r\n";
					text = text + "Edge Exclusion," + Conversion.Str(hi3.g9()) + "\r\n";
				}
				if (bn == hg.j.c)
				{
					text += "[F80SiteMapParams]\r\n";
					text = text + "Do Spot Homing," + bu(hi3.ha().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
					text = text + "Homing Pixels," + Conversion.Str(hi3.hb()) + "\r\n";
					text = text + "Target Pad Size," + Conversion.Str(hi3.hc()) + "\r\n";
				}
				text += "[Additional Options]\r\n";
				text = text + "Number Of Potential Spectra For Analysis," + hi3.gm() + "\r\n";
				int num5 = hi3.gm() - 1;
				for (int num6 = 1; num6 <= num5; num6++)
				{
					flag4 = hi3.eq(num6) && hi3.ep(num6);
					flag = hi3.eq(num6) && !flag4;
					text = text + "R" + num6 + " Option?," + bu(flag.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
					flag = hi3.ep(num6) && !flag4;
					text = text + "T" + num6 + " Option?," + bu(flag.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
					flag = flag4;
					text = text + "Simultaneous" + num6 + " Option?," + bu(flag.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				}
				text += "\r\n[Alarms]\r\n";
				text = text + "Activate Alarms," + bu(hi3.g5().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text += bv("Layer ID", 17);
				text += bv("Nom. Thick", 10, 1);
				text += bv("Min", 10, 1);
				text = text + bv("Max", 10, 1) + "\r\n";
				int num7 = hi3.g6() + 1;
				for (int num4 = 0; num4 <= num7; num4++)
				{
					gc gc2 = hi3.et(num4);
					string a_ = ((num4 != 0) ? ((num4 != hi3.g6() + 1) ? ("Layer " + Conversion.Str(num4)) : "Substrate") : "Medium");
					text += bv(a_, 17, 1, A_3: true);
					text = text + "," + bv(Conversion.Str(h4.e(1, gc2.ai(), ca())), 10, 1);
					text = text + "," + bv(Conversion.Str(h4.e(1, gc2.al(), ca())), 10, 1);
					text = text + "," + bv(Conversion.Str(h4.e(1, gc2.am(), ca())), 10, 1);
					text += "\r\n";
					gc2 = null;
				}
				text = text + "Spot Size (microns), " + Strings.Trim(Conversion.Str(hi3.gt())) + "\r\n";
				text = text + "Use Accurate NA Correction, " + bu(hi3.hg().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text += "\r\n[Regional Spectral Analysis]\r\n";
				text = text + "Spectrum Analysis Active," + b5().ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "Control Spectrum FullPath," + hi3.e2() + "\r\n";
				text = text + "Number of Average Reflectance Regions," + hi3.e3() + "\r\n";
				text += bv("Region", 17);
				text += bv("Start Wavelength", 10, 1);
				text += bv("End Wavelength", 10, 1);
				text += bv("Min Reflectance", 10, 1);
				text += bv("Max Reflectance", 10, 1);
				text = text + bv("Active", 10, 1) + "\r\n";
				int num8 = hi3.e3() - 1;
				for (int num4 = 0; num4 <= num8; num4++)
				{
					text += bv(num4.ToString(), 17, 1, A_3: true);
					text = text + "," + bv(((float)hi3.d5(num4)).ToString(CultureInfo.InvariantCulture), 10, 1);
					text = text + "," + bv(((float)hi3.d6(num4)).ToString(CultureInfo.InvariantCulture), 10, 1);
					text = text + "," + bv(((float)hi3.d7(num4)).ToString(CultureInfo.InvariantCulture), 10, 1);
					text = text + "," + bv(((float)hi3.d8(num4)).ToString(CultureInfo.InvariantCulture), 10, 1);
					text = text + "," + bv(hi3.d9(num4).ToString(CultureInfo.InvariantCulture), 10, 1);
					text += "\r\n";
				}
				text = text + "Number of Extrema Regions," + hi3.e9() + "\r\n";
				text += bv("Region", 17);
				text += bv("Start Wavelength", 10, 1);
				text += bv("End Wavelength", 10, 1);
				text += bv("Min Reflectance", 10, 1);
				text += bv("Max Reflectance", 10, 1);
				text += bv("Extrema Type", 10, 1);
				text += bv("HC Correction", 10, 1);
				text = text + bv("Active", 10, 1) + "\r\n";
				int num9 = hi3.e9() - 1;
				for (int num4 = 0; num4 <= num9; num4++)
				{
					text += bv(num4.ToString(), 17, 1, A_3: true);
					text = text + "," + bv(((float)hi3.ec(num4)).ToString(CultureInfo.InvariantCulture), 10, 1);
					text = text + "," + bv(((float)hi3.ed(num4)).ToString(CultureInfo.InvariantCulture), 10, 1);
					text = text + "," + bv(((float)hi3.ee(num4)).ToString(CultureInfo.InvariantCulture), 10, 1);
					text = text + "," + bv(((float)hi3.ef(num4)).ToString(CultureInfo.InvariantCulture), 10, 1);
					text = text + "," + bv(unchecked((int)hi3.eg(num4)).ToString(), 10, 1);
					text = text + "," + bv(hi3.eh(num4).ToString(CultureInfo.InvariantCulture), 10, 1);
					text = text + "," + bv(hi3.ei(num4).ToString(CultureInfo.InvariantCulture), 10, 1);
					text += "\r\n";
				}
				text = text + hi3.fj() + ", " + bu(hi3.fi().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text += "\r\n[SUV Weighting]\r\n";
				text = text + "SUVA Active," + bu(hi3.ex().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "SUVB Active," + bu(hi3.ey().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "SUVAB Active," + bu(hi3.ez().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "LuminousReflectance, " + bu(hi3.e0().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "YID1925, " + bu(hi3.e1().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text += "\r\n[Region Spectral Analysis - Addon]\r\n";
				text += "Average value\r\n";
				text += bv("Region", 17);
				text = text + bv("Trans", 10, 1) + "\r\n";
				int num10 = hi3.e3() - 1;
				for (int num4 = 0; num4 <= num10; num4++)
				{
					text += bv(num4.ToString(CultureInfo.InvariantCulture), 17, 1, A_3: true);
					text = text + "," + bv(unchecked((int)hi3.ea(num4)).ToString(CultureInfo.InvariantCulture), 10, 1);
					text += "\r\n";
				}
				text += "Extrema\r\n";
				text += bv("Region", 17);
				text = text + bv("Trans", 10, 1) + "\r\n";
				int num11 = hi3.e9() - 1;
				for (int num4 = 0; num4 <= num11; num4++)
				{
					text += bv(num4.ToString(CultureInfo.InvariantCulture), 17, 1, A_3: true);
					text = text + "," + bv(unchecked((int)hi3.ej(num4)).ToString(CultureInfo.InvariantCulture), 10, 1);
					text += "\r\n";
				}
				text += "\r\n[FFT Window]\r\n";
				text = text + "Vary FFT Window Position?," + bu(hi3.fv().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "Vary FFT Window Size?," + bu(hi3.fw().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "FFT Window Min Size," + hi3.fx().ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "FFT Window Size," + hi3.fy().ToString(CultureInfo.InvariantCulture) + "\r\n";
				text += "[Layer Parameters V2]\r\n";
				int num12 = hi3.g6() + 1;
				for (int num4 = 0; num4 <= num12; num4++)
				{
					gc gc2 = hi3.et(num4);
					text = text + "N grading fraction in layer #" + num4 + ", " + gc2.ak().ToString(CultureInfo.InvariantCulture) + "\r\n";
					text = text + "Solve for Grading in layer #" + num4 + ", " + bu(gc2.@as().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
					text = text + "Nonuniformity fraction in layer #" + num4 + ", " + gc2.aj().ToString(CultureInfo.InvariantCulture) + "\r\n";
					text = text + "Solve for Nonuniformity in layer #" + num4 + ", " + bu(gc2.at().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
					gc2 = null;
				}
				text = text + "Use Robust Thickness Only if not FFT, " + bu(hi3.gz().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text += "[Site Average Reflectance]\r\n";
				text = text + "Average Reflectance," + bu(hi3.gc().ToString(), 0, 0, false) + "\r\n";
				text = text + "Starting WaveLength," + Conversion.Str(hi3.gd()) + "\r\n";
				text = text + "Ending WaveLength," + Conversion.Str(hi3.ge()) + "\r\n";
				text = text + "Reference WaveLength," + Conversion.Str(hi3.gf()) + "\r\n";
				text = text + "MaxSolverRestarts, " + Conversion.Str(hi3.gp()) + "\r\n";
				text += "[Color Alarm]\r\n";
				text = text + "Color Alarm Active, " + Conversion.Str(hi3.d8()) + "\r\n";
				text = text + "Color Alarm Coordinate System, " + Conversion.Str(hi3.d7()) + "\r\n";
				text = text + "Color Coordinate 1 Min, " + Conversion.Str(hi3.em()) + "\r\n";
				text = text + "Color Coordinate 1 Max, " + Conversion.Str(hi3.en()) + "\r\n";
				text = text + "Color Coordinate 2 Min, " + Conversion.Str(hi3.eo()) + "\r\n";
				text = text + "Color Coordinate 2 Max, " + Conversion.Str(hi3.ep()) + "\r\n";
				text = text + "Color Coordinate 3 Min, " + Conversion.Str(hi3.eq()) + "\r\n";
				text = text + "Color Coordinate 3 Max, " + Conversion.Str(hi3.er()) + "\r\n";
				bool flag5 = false;
				int num13 = hi2.g6();
				for (int num14 = 1; num14 <= num13; num14++)
				{
					gc gc3 = hi2.et(num14);
					if (!gd.l(gc3.ag()) && gc3.x != null)
					{
						flag5 = true;
						break;
					}
					gc3 = null;
				}
				if (flag5)
				{
					text += "[Layer CorrCoeffs]\r\n";
					text += bv("Layer ID", 10);
					text += bv("CoefficientA", 17, 1);
					text += bv("CoefficientB", 17, 1);
					text += bv("Correlative min. thickness(" + ca().l() + ")", 38, 1);
					text = text + bv("Correlative max. thickness(" + ca().l() + ")", 38, 1) + "\r\n";
					int num15 = hi3.g6() + 1;
					for (int num4 = 0; num4 <= num15; num4++)
					{
						gc gc2 = hi3.et(num4);
						string a_ = ((num4 == 0) ? "Medium" : ((num4 != hi3.g6() + 1) ? ("Layer " + Conversion.Str(num4)) : "Substrate"));
						text += bv(a_, 10, 1);
						gc gc4 = gc2;
						double num16;
						double num17;
						double a_2;
						double a_3;
						if (gc4.x == null)
						{
							num16 = 0.0;
							num17 = 0.0;
							a_2 = 0.0;
							a_3 = 0.0;
						}
						else
						{
							num16 = gc4.x.a;
							num17 = gc4.x.b;
							a_2 = gc4.x.c;
							a_3 = gc4.x.d;
						}
						text = text + "," + bv(num16.ToString(CultureInfo.InvariantCulture), 17, 1);
						text = text + "," + bv(num17.ToString(CultureInfo.InvariantCulture), 17, 1);
						text = text + "," + bv(Conversion.Str(h4.e(1, a_2, ca())), 17, 1);
						text = text + "," + bv(Conversion.Str(h4.e(1, a_3, ca())), 17, 1);
						gc4 = null;
						text += "\r\n";
						gc2 = null;
					}
				}
				if (hi3.ev() || !string.IsNullOrEmpty(hi3.ew()))
				{
					text = text + "Calc N From Extrema, " + bu(hi3.eu().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
					text = text + "Calc N From Extrema Substrate, " + bv(jg.f(hi3.ew()), 0, 0, A_3: true) + "\r\n";
				}
				text += "[Spectrum Analysis Min/Max Hard Limits]\r\n";
				int num18 = hi3.e9() - 1;
				for (int num4 = 0; num4 <= num18; num4++)
				{
					text = text + bu(hi3.el(num4).ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				}
				text += "\r\n[Site Z-Stage]\r\n";
				text = text + "Max Wafer Thickness," + Conversion.Str(hi3.gg()) + "\r\n";
				text = text + "Max Wafer Height Variation," + Conversion.Str(hi3.gh()) + "\r\n";
				text = text + "Force Set Z Enabled, " + bu(hi3.gi().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "Set Z At Fixed Wavelength Enabled, " + bu(hi3.gj().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "Set Z Target Wavelength, " + Conversion.Str(hi3.gk()) + "\r\n";
				text = text + "Set Z Peaks Required, " + Conversion.Str(hi3.gl()) + "\r\n";
				text = text + "Report CTM Lens Position, " + Conversion.Str(hi3.gb()) + "\r\n";
				text += "\r\n[LayerReps]\r\n";
				text += bv("Layer ID", 17);
				text = text + bv("Reps", 10, 1) + "\r\n";
				int num19 = hi3.g6() + 1;
				for (int num4 = 0; num4 <= num19; num4++)
				{
					gc gc2 = hi3.et(num4);
					string a_ = ((num4 != 0) ? ((num4 != hi3.g6() + 1) ? ("Layer " + Conversion.Str(num4)) : "Substrate") : "Medium");
					text += bv(a_, 17, 1, A_3: true);
					text = text + "," + bv(Conversion.Str(gc2.ah()), 10, 1);
					text += "\r\n";
					gc2 = null;
				}
				if (hi2.es().Count > 0)
				{
					text += "\r\n[Additional Recipes]\r\n";
					text = text + "Num Additional Recipes, " + hi2.es().Count + "\r\n";
					int num20 = hi2.es().Count - 1;
					for (int num21 = 0; num21 <= num20; num21++)
					{
						hj hj2 = hi2.es()[num21];
						text = text + "Recipe " + (num21 + 1) + " info, " + Convert.ToBase64String(Encoding.UTF8.GetBytes(hj2.e())) + ", " + unchecked((int)hj2.f()) + ", " + bu(hj2.g().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
						hj2 = null;
					}
				}
				if (hi2.c9.w())
				{
					text += "\r\n[OptoValues]\r\n";
					text = text + "MeasureFPDip, " + bu(hi2.c9.x().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
					text = text + "FPWavelenLimited, " + bu(hi2.c9.o().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
					text = text + "FPReflLowThreshold, " + hi2.c9.p().ToString(CultureInfo.InvariantCulture) + "\r\n";
					text = text + "FPReflHighThreshold, " + hi2.c9.q().ToString(CultureInfo.InvariantCulture) + "\r\n";
					text = text + "FPReflThreshIsRelative, " + bu(hi2.c9.r().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
					text = text + "FPWavelenMin, " + hi2.c9.s().ToString(CultureInfo.InvariantCulture) + "\r\n";
					text = text + "FPWavelenMax, " + hi2.c9.t().ToString(CultureInfo.InvariantCulture) + "\r\n";
					text = text + "MeasureDBRCenter, " + bu(hi2.c9.y().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
					text = text + "DBRThreshold, " + hi2.c9.u().ToString(CultureInfo.InvariantCulture) + "\r\n";
					text = text + "DBRThreshIsRelative, " + bu(hi2.c9.v().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				}
				if (hi2.ej())
				{
					text = text + "FFT Measure Total Thickness, " + bu(hi2.c3.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
					text = text + "FFT Total Thickness Threshold, " + hi2.c6.ToString(CultureInfo.InvariantCulture) + "\r\n";
				}
				if (hi2.ek())
				{
					text = text + "FFTWindowType, " + unchecked((int)hi2.g1()).ToString(CultureInfo.InvariantCulture) + "\r\n";
				}
				text = text + "FFTScalingFactor, " + hi2.g2().ToString(CultureInfo.InvariantCulture) + "\r\n";
				hi3 = null;
				hi2 = null;
				text = text + "======End of measure site " + Conversion.Str(num2) + " ======\r\n";
			}
		}
		short num22;
		if ((bn == hg.j.b) | (bn == hg.j.c))
		{
			text += "\r\n[WaferMap]\r\n";
			text = text + "Wafer Diameter," + bv(Conversions.ToString((int)this.m_b0), 0, 0, false) + "\r\n";
			text = text + "DIF File Name," + bv(jg.f(this.m_b1), 0, 0, A_3: true) + "\r\n";
			text = text + "Indexing(" + c5() + ")," + Conversion.Str(this.m_b2) + "\r\n";
			num22 = this.m_b3;
			text = text + "Save Results To Disk," + bu(num22.ToString(), 0, 0, false) + "\r\n";
			num22 = this.m_b4;
			text = text + "Save Intermediate Resuls," + bu(num22.ToString(), 0, 0, false) + "\r\n";
			num22 = this.m_b5;
			text = text + "Save Spectra," + bu(num22.ToString(), 0, 0, false) + "\r\n";
			num22 = this.m_b7;
			text = text + "Pattern Avoidance," + bu(num22.ToString(), 0, 0, false) + "\r\n";
			num22 = this.m_b8;
			text = text + "Invalid Measure Retry," + bu(num22.ToString(), 0, 0, false) + "\r\n";
			text = text + "Spot Size," + Conversion.Str(this.m_b9) + "\r\n";
			text = text + "Pattern Size," + Conversion.Str(this.m_ca) + "\r\n";
			bool flag = this.m_cb;
			text = text + "Rectangular?," + bu(flag.ToString(), 0, 0, false) + "\r\n";
			text = text + "Spacing," + Conversion.Str(this.m_cc) + "\r\n";
			num22 = this.m_cd;
			text = text + "Fabry-Perot Dip," + bu(num22.ToString(), 0, 0, false) + "\r\n";
			num22 = this.m_ce;
			text = text + "Reflectance Band Center," + bu(num22.ToString(), 0, 0, false) + "\r\n";
			hi hi4 = b3(1);
			text = text + "Average Reflectance," + bu(hi4.gc().ToString(), 0, 0, false) + "\r\n";
			text = text + "Starting WaveLength," + Conversion.Str(hi4.gd()) + "\r\n";
			text = text + "Ending WaveLength," + Conversion.Str(hi4.ge()) + "\r\n";
			text = text + "Reference WaveLength," + Conversion.Str(hi4.gf()) + "\r\n";
			hi4 = null;
			text = text + "Wafer Width," + cr().ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Wafer Height," + cs().ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Wafer Full Reference Mode," + ((int)ea()).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text += "\r\n[Wafer Details]\r\n";
			text = text + "Wafer Is Prealigned," + bv(ct()) + "\r\n";
			text = text + "Use Prealigner," + bv(cu()) + "\r\n";
			text = text + "Prealigned Angle (Degrees)," + cv().ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Prealigned Angle End (Degrees)," + cw().ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Minor Flat Present," + bv(cx()) + "\r\n";
			text = text + "Edge Bead Present," + bv(cy()) + "\r\n";
			text = text + "Minor Flat Orientation," + (int)cz() + "\r\n";
			text = text + "Index Mark Orientation," + (int)c0() + "\r\n\r\n";
		}
		text += "[CUSTOM EXPORT]\r\n";
		num22 = this.m_b6;
		text = text + "Auto Export Wafer Map," + bu(num22.ToString(), 0, 0, false) + "\r\n";
		if (this.m_c2 != null)
		{
			text += "\r\n[Acqusition Settings]\r\n";
			text = text + "Number of Smoothing Points, " + this.m_cw + "\r\n";
			text = text + "Measurement Timing," + Conversions.ToString((int)this.m_c2.aq()) + "\r\n";
			text = text + "Spectrometer Type, " + Conversions.ToString((int)this.m_c2.a(0).h()) + "\r\n";
			text = text + "Maximum Integration Time," + this.m_c2.ar().ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Fixed Integration Time (short wavelengths), " + this.m_c2.a(0).b(global::f.b.b).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Fixed Integration Cycles (short wavelengths), " + this.m_c2.a(0).h(global::f.b.b).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Fixed Integration Time (long wavelengths), " + this.m_c2.a(0).b(global::f.b.c).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Fixed Integration Cycles (long wavelengths), " + this.m_c2.a(0).h(global::f.b.c).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Peak Value (short wavelengths), " + this.m_c2.a(0).i(global::f.b.b).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Peak Value (long wavelengths), " + this.m_c2.a(0).i(global::f.b.c).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "<Reference Material1>, " + bv(jg.f(this.m_c2.a(global::h.g.a).c()), 0, 0, A_3: true) + "\r\n";
			text = text + "<ReferenceMaterialKnown1>, " + Conversions.ToString(this.m_c2.a(global::h.g.a).d()) + "\r\n";
			text = text + "Smoothing Thickness " + new h4(h4.a.c).l() + ", " + Conversion.Str(h4.e(1, this.m_cv, new h4(h4.a.c))) + "\r\n";
			text = text + "Graph limits start wavelength, " + Conversion.Str(this.m_cx) + "\r\n";
			text = text + "Graph limits end wavelength, " + Conversion.Str(this.m_cy) + "\r\n";
			text = text + "Measure delay, " + this.m_c2.at().ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Stored baseline name, " + this.m_c2.@as() + "\r\n";
			text += "\r\n[Acquisition2 Settings]\r\n";
			text = text + "Spectrometer Type, " + Conversions.ToString((int)this.m_c2.a(1).h()) + "\r\n";
			text = text + "Fixed Integration Time (short wavelengths), " + this.m_c2.a(1).b(global::f.b.b).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Fixed Integration Cycles (short wavelengths), " + this.m_c2.a(1).h(global::f.b.b).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Fixed Integration Time (long wavelengths), " + this.m_c2.a(1).b(global::f.b.c).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Fixed Integration Cycles (long wavelengths), " + this.m_c2.a(1).h(global::f.b.c).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Peak Value (short wavelengths), " + this.m_c2.a(1).i(global::f.b.b).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Peak Value (long wavelengths), " + this.m_c2.a(1).i(global::f.b.c).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text += "\r\n";
			text += "\r\n[Acquisition3 Settings]\r\n";
			text = text + "Spectrometer Type, " + Conversions.ToString((int)this.m_c2.a(2).h()) + "\r\n";
			text = text + "Fixed Integration Time (short wavelengths), " + this.m_c2.a(2).b(global::f.b.b).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Fixed Integration Cycles (short wavelengths), " + this.m_c2.a(2).h(global::f.b.b).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Fixed Integration Time (long wavelengths), " + this.m_c2.a(2).b(global::f.b.c).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Fixed Integration Cycles (long wavelengths), " + this.m_c2.a(2).h(global::f.b.c).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Peak Value (short wavelengths), " + this.m_c2.a(2).i(global::f.b.b).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Peak Value (long wavelengths), " + this.m_c2.a(2).i(global::f.b.c).ToString(CultureInfo.InvariantCulture) + "\r\n";
			text += "\r\n";
			text = text + "Dual Meas Selected Type, " + (int)this.m_c2.r() + "\r\n";
			text = text + "Dual Meas Trans Spec Same As R, " + bu(this.m_c2.t().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
			text = text + "<Reference Material2>, " + bv(jg.f(this.m_c2.a(global::h.g.b).c()), 0, 0, A_3: true) + "\r\n";
			text = text + "<ReferenceMaterialKnown2>, " + Conversions.ToString(this.m_c2.a(global::h.g.b).d()) + "\r\n";
		}
		if (this.m_db != null)
		{
			text += "\r\n[Optics Configuration]\r\n";
			g2 g10 = this.m_db;
			string a_4 = "Nothing";
			text = ((g10.w != null) ? (text + "Microscope Name, " + bv(jg.f(g10.w), 0, 0, A_3: true) + "\r\n") : (text + "Microscope Name, " + bv(jg.f(a_4), 0, 0, A_3: true) + "\r\n"));
			string text6 = "";
			if (g10.k() != null)
			{
				text6 = g10.k().ToString();
			}
			text = text + "System GUID, " + text6 + "\r\n";
			text = text + "Use With Any System, " + bu(g10.l().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
			text = text + "Optics Configuration, " + Conversions.ToString((int)g10.c()) + "\r\n";
			text = text + "MeasStage LastMeasTypeWasRefl, " + bu(g10.x.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
			text = text + "ContactProbe LastAutoBaselineSelectionWasTrue, " + bu(g10.y.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
			text = text + "ContactStage LastAutoBaselineSelectionWasTrue, " + bu(g10.z.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
			text = text + "Microscope LastMeasTypeWasRefl, " + bu(g10.aa.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
			text = text + "Objective Exists, " + bu((g10.r() != null).ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
			if (g10.r() != null)
			{
				et et2 = (et)g10.r();
				text = text + "Microscope Objective Name, " + bv(jg.f(et2.al()), 0, 0, A_3: true) + "\r\n";
				text = text + "Microscope Numerical Aperture Target, " + et2.t().ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "Microscope Numerical Aperture Actual, " + et2.u().ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "Microscope Numerical Aperture Actual Robust, " + et2.v().ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "Microscope First Wavelength, " + et2.x().ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "Microscope Last Wavelength, " + et2.y().ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "Microscope Cal Sample Thickness, " + et2.z().ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "Microscope Use Target NA, " + bu(et2.aa().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "Microscope Calibrated, " + bu(et2.ab().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				et2 = null;
			}
			g10 = null;
			text += "\r\n[CTM Optics Configuration]\r\n";
			g2 g11 = this.m_db;
			text = text + "CTM Probe Exists, " + bu((g11.s() != null).ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
			if (g11.s() != null)
			{
				text = text + "CTM Probe Serial Number, " + bv(jg.f(g11.s().n()), 0, 0, A_3: true) + "\r\n";
			}
			g11 = null;
			if (this.m_c1 != null)
			{
				text += "\r\n[Vs Time Analysis Settings]\r\n";
				jk jk2 = this.m_c1;
				text = text + "Refractive Index, " + jk2.b.ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "Temperature, " + jk2.c.ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "VsTime Material, " + jk2.d.ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "VsTime Angle, " + jk2.e.ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "Polarized TE, " + bu(jk2.f.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "Deposition Rate Only, " + bu(jk2.h.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "VsTime Scaling, " + jk2.i.ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "VsTime Scaling Fix, " + bu(jk2.j.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "VsTime Rate(nm/s), " + jk2.k.ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "VsTime Rate(nm/s) Fix, " + bu(jk2.l.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "VsTime n, " + jk2.m.ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "VsTime n Fix, " + bu(jk2.n.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "VsTime k, " + jk2.o.ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "VsTime k Fix, " + bu(jk2.p.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				string text7 = text;
				int num23 = (int)jk2.a;
				text = text7 + "Unit of Growth Rate, " + num23.ToString(CultureInfo.InvariantCulture) + "\r\n";
				jk2 = null;
			}
		}
		List<global::h.a> list = this.m_c2.a2();
		string text8;
		checked
		{
			if (list.Count > 0)
			{
				text += "\r\n[Photodiode Acq. Settings]\r\n";
				text = text + "SamplingTime (s), " + this.m_c2.aw().ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "Use MultiWafer/Wobble, " + bu(this.m_c2.ax().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
				text = text + "Num Wafers, " + this.m_c2.ay().ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "Rotation Speed (rpm), " + this.m_c2.az().ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "Manual Gain, " + this.m_c2.a0().ToString(CultureInfo.InvariantCulture) + "\r\n";
				text = text + "NumPhotodiodes, " + list.Count + "\r\n";
				text = text + bv("Photodiode ID", "Photodiode ID".Length) + " ";
				text = text + bv("Wavelength", 10, 1) + " ";
				text = text + bv("Active", 10, 1) + " ";
				text = text + bv("Gain", 8, 1) + " ";
				text = text + bv("SystemGuid", 38, 1) + "\r\n";
				int num23 = list.Count - 1;
				for (int num24 = 0; num24 <= num23; num24++)
				{
					global::h.a a10 = list[num24];
					text += bv((num24 + 1).ToString(CultureInfo.InvariantCulture), "Photodiode ID".Length, 1);
					text = text + "," + bv(a10.d.ToString(CultureInfo.InvariantCulture), 10, 1);
					text = text + "," + bv(a10.a.ToString(CultureInfo.InvariantCulture), 10, 1);
					text = text + "," + bv(a10.c.ToString(CultureInfo.InvariantCulture), 10, 1);
					text = text + "," + bv(a10.b, 38, 1);
					a10 = null;
					text += "\r\n";
				}
			}
			list = null;
			text = text + "Show Thickness range in Thickness units, " + bu(this.m_bx.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
			text = text + "Show nonuniformity in percent, " + bu(this.m_by.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
			text += "\r\n[Backside Subtraction]\r\n";
			text = text + "Backside R Subtraction Enabled, " + bu(this.m_cz.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
			text = text + "Substrate Material, " + bv(jg.f(b4(this.m_c0)), 0, 0, A_3: true) + "\r\n";
			text = text + "Ignore Baseline Info in Recipe, " + bu(this.m_c2.p().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
			text += "\r\n[AutoFocus Settings]\r\n";
			text = text + "AutoFocus On, " + bu(this.m_c2.d().a.ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
			text = text + "AutoFocus type, " + unchecked((int)this.m_c2.d().i()) + "\r\n";
			text = text + "Z offset for max signal, " + this.m_c2.d().c.ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Z offset for image focus, " + this.m_c2.d().d.ToString(CultureInfo.InvariantCulture) + "\r\n";
			text = text + "Auto Focus Max Signal Sample Thickness, " + this.m_c2.d().e.ToString(CultureInfo.InvariantCulture) + "\r\n";
			text += "\r\n[AutoFocus2 Settings]\r\n";
			text = text + "Map Autofocus Center Only," + bv(this.m_cf) + "\r\n";
			text = text + "Auto Edge Find," + bv(this.m_cg) + "\r\n";
			text = text + "Align with Origin Only," + bv(this.m_ch) + "\r\n";
			text += "Map Origin Type, 0\r\n";
			text += "\r\n[SpectrometervsTime Acq. Settings]\r\n";
			text = text + "VsTimeInputModeIsSpectrometer, " + bu(this.m_c2.av().ToString(CultureInfo.InvariantCulture), 0, 0, false) + "\r\n";
			List<global::h.b> list2 = this.m_c2.au();
			if (list2.Count > 0)
			{
				text = text + "NumWavelengths, " + list2.Count + "\r\n";
				text = text + bv("Wavelength ID", "Wavelength ID".Length) + " ";
				text = text + bv("Wavelength", 10, 1) + " ";
				text = text + bv("Active", 10, 1) + " \r\n";
				int num25 = list2.Count - 1;
				for (int num26 = 0; num26 <= num25; num26++)
				{
					global::h.b b10 = list2[num26];
					text += bv((num26 + 1).ToString(CultureInfo.InvariantCulture), "Wavelength ID".Length, 1);
					text = text + "," + bv(b10.d.ToString(CultureInfo.InvariantCulture), 10, 1);
					text = text + "," + bv(b10.a.ToString(CultureInfo.InvariantCulture), 10, 1);
					b10 = null;
					text += "\r\n";
				}
			}
			list2 = null;
			text += "\r\n[Z Optics]\r\n";
			text8 = text;
		}
		int num27 = (int)this.m_de;
		text = text8 + "ZOpticsType, " + num27.ToString(CultureInfo.InvariantCulture) + "\r\n";
		text = text + "GuidForZOptics, " + d2().ToString() + "\r\n";
		text = text + "\r\nReflective Objective Focus Range Percent, " + this.m_c2.d().f.ToString(CultureInfo.InvariantCulture) + "\r\n";
		text = text + "Reflective Objective Focus Step Size Percent, " + this.m_c2.d().g.ToString(CultureInfo.InvariantCulture) + "\r\n";
		string text9 = text;
		num27 = (int)this.m_dg;
		text = text9 + "Map Origin Offset Type," + num27 + "\r\n";
		text = text + "Map Origin Offset Absolute X," + this.m_dh.ToString(CultureInfo.InvariantCulture) + "\r\n";
		text = text + "Map Origin Offset Absolute Y," + this.m_di.ToString(CultureInfo.InvariantCulture) + "\r\n";
		text = text + "Use Recipe Based MapAutosavePath," + this.m_dj.ToString(CultureInfo.InvariantCulture) + "\r\n";
		if (!string.IsNullOrEmpty(this.m_dk))
		{
			text = text + "Map Autosave Path," + this.m_dk + "\r\n";
		}
		text += "***End Machine Readable Structure***\r\n";
		return text + "CHECKSUM=" + Conversion.Str(bu(text, 12));
	}

	public int ch(string A_0)
	{
		int result;
		try
		{
			br = Path.GetFileNameWithoutExtension(A_0);
			File.WriteAllText(A_0, ee() + "\r\n");
			result = 0;
			bm = true;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			result = Information.Err().Number;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void ef()
	{
		bq = new Collection();
		this.m_b1 = "";
		this.m_cv = 100000000f;
		hi hi2 = new hi(this.m_cu);
		hi2.au(bn);
		bu(hi2);
		if (bn != hg.j.a)
		{
			b2();
			if (bn == hg.j.c)
			{
				this.m_ci = false;
				this.m_cj = 100.0;
				this.m_ck = 100.0;
				this.m_cl = 0.0;
				this.m_cm = 100.0;
				this.m_cn = 100.0;
				this.m_co = 200.0;
			}
		}
		this.m_c2.a1();
		bp = 1;
		bm = true;
		ca().e(h4.a.b);
		this.m_db = null;
		this.m_de = hg.b.b;
		this.m_df = Guid.Empty;
		this.m_bx = false;
		this.m_by = false;
		this.m_cz = false;
		if (b5())
		{
			this.m_c0 = null;
		}
		else
		{
			eg();
		}
		if (this.m_c1 != null)
		{
			this.m_c1.r();
		}
	}

	public void eg()
	{
		hi obj = ed();
		string text = obj.et(checked(obj.g6() + 1)).ag();
		if (Operators.CompareString(text, "<Graded Interface>", TextCompare: false) == 0 || Operators.CompareString(text, "<Roughness>", TextCompare: false) == 0 || gd.l(text))
		{
			this.m_c0 = "Invalid";
		}
		else
		{
			this.m_c0 = text;
		}
		_ = null;
	}

	private void b2()
	{
		this.m_b0 = 200;
		bu((float)this.m_b0);
		bv((float)this.m_b0);
		this.m_b2 = 1;
		this.m_cf = false;
		this.m_cg = false;
		this.m_ch = false;
		this.m_b3 = 0;
		this.m_b4 = 0;
		this.m_b5 = 0;
		this.m_b7 = 0;
		this.m_b8 = 0;
		this.m_b9 = 0.5;
		this.m_ca = 0.05;
		this.m_cb = false;
		this.m_cc = 1.0;
		this.m_dg = hg.c.a;
		this.m_dh = 0f;
		this.m_di = 0f;
		this.m_cd = 0;
		this.m_ce = 0;
		this.m_dj = false;
		this.m_dk = null;
	}

	public gc bu(int A_0, int A_1 = 0)
	{
		int a_ = ((A_1 != 0) ? A_1 : bp);
		return b3(a_).et(A_0);
	}

	public gc bv(int A_0, int A_1 = 0)
	{
		int a_ = ((A_1 != 0) ? A_1 : bp);
		return b3(a_).eu(A_0);
	}

	private bool bu(ref string A_0, bool A_1)
	{
		if (!File.Exists(A_0))
		{
			return false;
		}
		StreamReader streamReader = null;
		try
		{
			streamReader = new StreamReader(A_0);
			string a_ = streamReader.ReadToEnd();
			if (!bu(a_, A_1, A_0))
			{
				return false;
			}
			return true;
		}
		finally
		{
			streamReader?.Close();
		}
	}

	public bool bu(string A_0, string A_1)
	{
		return bu(A_0, A_1: false, A_1);
	}

	public bool bu(string A_0, bool A_1, string A_2)
	{
		string A_3 = "";
		string A_4 = "";
		string A_5 = "";
		string A_6 = "";
		if (!bo)
		{
			throw new am("Software config must be set prior to reading a recipe from file");
		}
		fy = false;
		bs = A_2;
		this.m_cv = 100000000f;
		this.m_cx = 0.0;
		this.m_cy = 0.0;
		this.m_c2.a1();
		this.m_db = null;
		this.m_de = hg.b.b;
		this.m_df = Guid.Empty;
		this.m_bx = false;
		this.m_by = false;
		bu(hg.h.a);
		this.m_cf = false;
		this.m_cg = false;
		this.m_ch = false;
		this.m_c1 = null;
		bq = new Collection();
		hi hi2 = new hi(this.m_cu);
		bp = 1;
		int num = 1;
		checked
		{
			bool result2;
			try
			{
				int A_7 = default(int);
				i3.a(ref A_7, A_0, ref A_3);
				i3.a(ref A_7, A_0, ref A_3);
				short num2 = (short)Math.Round(Conversion.Val(A_3));
				i3.a(ref A_7, A_0, ref A_3);
				i3.a(ref A_7, A_0, ref A_3);
				br = jg.e(A_3);
				br = Path.GetFileNameWithoutExtension(bs);
				if (num2 >= 5)
				{
					i3.a(ref A_7, A_0, ref A_3);
					i3.a(ref A_7, A_0, ref bt);
					i3.a(ref A_7, A_0, ref A_3);
					i3.a(ref A_7, A_0, ref A_3);
					this.m_bu = jg.e(A_3);
					i3.a(ref A_7, A_0, ref A_3);
					i3.a(ref A_7, A_0, ref A_3);
					this.m_bv = Conversion.Val(A_3);
				}
				if (num2 >= 6)
				{
					i3.a(ref A_7, A_0, ref A_4);
					i3.a(ref A_7, A_0, ref A_3);
					num = (int)Math.Round(Conversion.Val(A_3));
				}
				else
				{
					num = 1;
				}
				bool flag = false;
				hi2 = new hi(this.m_cu);
				hi2.d5(-1.0);
				hi2.au(-1.0);
				int num3 = 0;
				bool flag4 = default(bool);
				bool flag8 = default(bool);
				bool flag9 = default(bool);
				while (A_7 < A_0.Length)
				{
					do
					{
						i3.a(ref A_7, A_0, ref A_3);
					}
					while ((string.IsNullOrEmpty(A_3) || string.IsNullOrEmpty(A_3.Trim())) && A_7 < A_0.Length);
					bool flag2 = false;
					if (Strings.InStr(1, A_3, "UnitsMode", CompareMethod.Text) != 0)
					{
						if (num2 >= 11)
						{
							bu(h4.e(ref A_7, A_0));
						}
						else
						{
							i3.a(ref A_7, A_0, ref A_3);
							h4.a a_ = ((!Versioned.IsNumeric(A_3)) ? h4.e(Strings.Trim(A_3)) : unchecked((h4.a)Conversions.ToInteger(A_3)));
							bu(new h4(a_));
						}
					}
					bool flag3 = false;
					bool a_2 = false;
					while (true)
					{
						if (!flag4 && A_7 < A_0.Length)
						{
							if (Strings.InStr(1, A_3, "Measure Site Location XY (mm)") != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_4);
								hi2.d5(Conversion.Val(A_3));
								hi2.au(Conversion.Val(A_4));
							}
							if (Strings.InStr(1, A_3, "Enable Robust Thickness", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								a_2 = b0(Strings.Trim(A_3));
							}
							if (Strings.InStr(1, A_3, "Enable FFT Thickness Only", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								hi2.e2(b0(Strings.Trim(A_3)));
							}
							if (Strings.InStr(1, A_3, "Valid measurement requires GOF", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ej(Conversion.Val(A_3));
							}
							if (Strings.InStr(1, A_3, "Solve for GOF", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								hi2.es(b0(Strings.Trim(A_3)));
							}
							if (Strings.InStr(1, A_3, "Valid FFT measurement requires intensity", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ek(Conversion.Val(A_3));
							}
							if (Strings.InStr(1, A_3, "[Custom Measurement]", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.eh(b0(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ei(b0(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ej(b0(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ek(b0(A_3));
							}
							if (Strings.InStr(1, A_3, "[Correlative Coefficients]", CompareMethod.Text) != 0)
							{
								flag2 = true;
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.br.a = Conversion.Val(A_3);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.br.b = Conversion.Val(A_3);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.br.c = Conversion.Val(A_3);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.br.d = Conversion.Val(A_3);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.e5(b0(A_3));
							}
							if (Strings.InStr(1, A_3, "[Difference Site]", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ep(b0(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.em(Conversions.ToInteger(A_3));
							}
							if (Strings.InStr(1, A_3, "[Mixed Site]", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.eq(b0(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.en(Conversions.ToInteger(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ef((float)Conversion.Val(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.eg((float)Conversion.Val(A_3));
							}
							if (Strings.InStr(1, A_3, "[Layers]", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								short num4 = (short)Math.Round(Conversion.Val(A_3) + 2.0);
								A_3 = i3.a(ref A_7, A_0);
								int num5 = num4;
								for (int num6 = 1; num6 <= num5; num6++)
								{
									gc A_8 = new gc();
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									A_8.af(b3(jg.e(A_3)));
									i3.a(ref A_7, A_0, ref A_3);
									A_8.af(A_0: false, A_1: true, Conversion.Val(A_3));
									i3.a(ref A_7, A_0, ref A_3);
									A_8.aj(Conversion.Val(A_3));
									i3.a(ref A_7, A_0, ref A_3);
									A_8.ag(b0(Strings.Trim(A_3)));
									i3.a(ref A_7, A_0, ref A_3);
									A_8.ai(b0(Strings.Trim(A_3)));
									i3.a(ref A_7, A_0, ref A_3);
									A_8.ak(b0(Strings.Trim(A_3)));
									i3.a(ref A_7, A_0, ref A_3);
									A_8.am(b0(Strings.Trim(A_3)));
									hi2.au(ref A_8);
									A_8 = null;
								}
							}
							if (Strings.InStr(1, A_3, "[Constraints]", CompareMethod.Text) != 0)
							{
								A_3 = i3.a(ref A_7, A_0);
								int num7 = hi2.g6() + 1;
								for (int num8 = 0; num8 <= num7; num8++)
								{
									gc A_8 = hi2.et(num8);
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									A_8.ak(Conversion.Val(A_3));
									i3.a(ref A_7, A_0, ref A_3);
									A_8.al(Conversion.Val(A_3));
									i3.a(ref A_7, A_0, ref A_3);
									A_8.am(Conversion.Val(A_3));
								}
							}
							if (Strings.InStr(1, A_3, "Account for nonplanarity", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ex(b0(Strings.Trim(A_3)));
							}
							if (Strings.InStr(1, A_3, "Account for nonuniformity", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								flag3 = b0(Strings.Trim(A_3));
							}
							if (Strings.InStr(1, A_3, "Lock identical layers", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								hi2.e7(b0(Strings.Trim(A_3)));
							}
							int num10;
							if (Strings.InStr(1, A_3, "[Options]", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								bool flag5 = b0(Strings.Trim(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								bool flag6 = b0(Strings.Trim(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								bool flag7 = b0(Strings.Trim(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.eb(Conversion.Val(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.er(b0(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.d9(jg.e(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ez(b0(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ey(b0(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ew(b0(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								if (num2 <= 9)
								{
									hi2.el(1.0 - Conversion.Val(A_3));
								}
								else
								{
									hi2.el(Conversion.Val(A_3));
								}
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ei(Conversion.Val(A_3));
								int num9 = hi2.g6() + 1;
								for (int num8 = 0; num8 <= num9; num8++)
								{
									gc A_8 = hi2.et(num8);
									i3.a(ref A_7, A_0, ref A_4);
									i3.a(ref A_7, A_0, ref A_3);
									A_8.ag(jg.e(A_3));
									A_8 = null;
								}
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ea(Conversion.Val(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.em(b0(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.el(b0(Strings.Trim(A_3)));
								if (bn == hg.j.c)
								{
									hi2.el(A_0: true);
								}
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.d7(Conversion.Val(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.d6(Conversion.Val(A_3));
								num10 = A_7;
								i3.a(ref A_7, A_0, ref A_3);
								if (Operators.CompareString(A_3, "[SiteMapParams]", TextCompare: false) == 0)
								{
									i3.a(ref A_7, A_0, ref A_4);
									i3.a(ref A_7, A_0, ref A_3);
									hi2.e6(b0(Strings.Trim(A_3)));
									i3.a(ref A_7, A_0, ref A_4);
									i3.a(ref A_7, A_0, ref A_3);
									hi2.eo((int)Math.Round(Conversion.Val(A_3)));
									i3.a(ref A_7, A_0, ref A_4);
									i3.a(ref A_7, A_0, ref A_3);
									hi2.d8(Strings.Trim(A_3));
									i3.a(ref A_7, A_0, ref A_4);
									i3.a(ref A_7, A_0, ref A_3);
									hi2.ea(jg.e(A_3));
									i3.a(ref A_7, A_0, ref A_4);
									i3.a(ref A_7, A_0, ref A_3);
									hi2.ej((float)Conversion.Val(A_3));
								}
								else
								{
									A_7 = num10;
								}
								num10 = A_7;
								i3.a(ref A_7, A_0, ref A_3);
								if (Operators.CompareString(A_3, "[F80SiteMapParams]", TextCompare: false) == 0)
								{
									i3.a(ref A_7, A_0, ref A_4);
									i3.a(ref A_7, A_0, ref A_3);
									hi2.e4(b0(Strings.Trim(A_3)));
									i3.a(ref A_7, A_0, ref A_4);
									i3.a(ref A_7, A_0, ref A_3);
									hi2.em(Conversion.Val(A_3));
									i3.a(ref A_7, A_0, ref A_4);
									i3.a(ref A_7, A_0, ref A_3);
									hi2.ek((float)Conversion.Val(A_3));
									i3.a(ref A_7, A_0, ref A_3);
								}
								else
								{
									A_7 = num10;
								}
								if (!flag2)
								{
									hi2.br.a = 1.0;
									hi2.br.b = 0.0;
									hi2.br.c = 0.0;
									hi2.br.d = 99999999.0;
									hi2.e5(A_0: false);
								}
								num10 = A_7;
								i3.a(ref A_7, A_0, ref A_3);
								if (Strings.InStr(1, A_3, "[Additional Options]", CompareMethod.Text) != 0)
								{
									i3.a(ref A_7, A_0, ref A_4);
									i3.a(ref A_7, A_0, ref A_3);
									int num11 = Convert.ToInt32(A_3);
									if (2 > num11)
									{
										num11 = 2;
									}
									hi2.ew(num11);
									int num12 = num11 - 1;
									for (int num13 = 1; num13 <= num12; num13++)
									{
										i3.a(ref A_7, A_0, ref A_4);
										i3.a(ref A_7, A_0, ref A_3);
										hi2.d9(num13, b0(Strings.Trim(A_3)));
										i3.a(ref A_7, A_0, ref A_4);
										i3.a(ref A_7, A_0, ref A_3);
										hi2.d8(num13, b0(Strings.Trim(A_3)));
										i3.a(ref A_7, A_0, ref A_4);
										i3.a(ref A_7, A_0, ref A_3);
										if (b0(Strings.Trim(A_3)))
										{
											hi2.d9(num13, A_1: true);
											hi2.d8(num13, A_1: true);
										}
									}
									i3.a(ref A_7, A_0, ref A_3);
								}
								else
								{
									hi2.ew(2);
								}
								hi2.d9(0, flag5 || flag7);
								hi2.d8(0, flag6 || flag7);
							}
							num10 = A_7;
							if (Strings.InStr(1, A_3, "[Alarms]", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.e3(b0(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								int num14 = hi2.g6() + 1;
								for (int num8 = 0; num8 <= num14; num8++)
								{
									gc A_8 = hi2.et(num8);
									i3.a(ref A_7, A_0, ref A_4);
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_4);
									i3.a(ref A_7, A_0, ref A_3);
									A_8.ah(Conversion.Val(A_4));
									A_8.ai(Conversion.Val(A_3));
									if (A_8.al() == 0.0 && A_8.am() == 0.0)
									{
										A_8.ai(A_8.ai() + A_8.ai() * (A_8.av() / 100.0));
									}
									A_8 = null;
								}
							}
							else
							{
								A_7 = num10;
							}
							if (Strings.InStr(1, A_3, "Spot Size (microns)", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								hi2.eh((float)Conversion.Val(A_3));
							}
							if (Strings.InStr(1, A_3, "Use Accurate NA Correction", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								hi2.e8(b0(Strings.Trim(A_3)));
							}
							num10 = A_7;
							if (Strings.InStr(1, A_3, "[Regional Spectral Analysis]", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.d7(Strings.Trim(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.au(Conversions.ToInteger(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								int num15 = hi2.e3() - 1;
								for (int num16 = 0; num16 <= num15; num16++)
								{
									i3.a(ref A_7, A_0, ref A_4);
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_4);
									hi2.au(num16, Conversion.Val(A_3));
									hi2.d5(num16, Conversion.Val(A_4));
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_4);
									hi2.d6(num16, Conversion.Val(A_3));
									hi2.d7(num16, Conversion.Val(A_4));
									i3.a(ref A_7, A_0, ref A_3);
									hi2.au(num16, b0(A_3));
									hi2.au(num16, hi.e.a);
								}
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.eb(Conversions.ToInteger(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								int num17 = hi2.e9() - 1;
								for (int num18 = 0; num18 <= num17; num18++)
								{
									i3.a(ref A_7, A_0, ref A_4);
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_4);
									hi2.d8(num18, Conversion.Val(A_3));
									hi2.d9(num18, Conversion.Val(A_4));
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_4);
									hi2.ea(num18, Conversion.Val(A_3));
									hi2.eb(num18, Conversion.Val(A_4));
									i3.a(ref A_7, A_0, ref A_3);
									unchecked
									{
										hi2.au(num18, (hi.b)checked((int)Math.Round(Conversion.Val(A_3))));
										i3.a(ref A_7, A_0, ref A_3);
										hi2.d5(num18, b0(A_3));
										i3.a(ref A_7, A_0, ref A_3);
										hi2.d6(num18, b0(A_3));
										hi2.d5(num18, hi.e.a);
									}
								}
							}
							else
							{
								A_7 = num10;
							}
							num10 = A_7;
							if (Strings.InStr(1, A_3, hi2.fj(), CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								hi2.eg(b0(A_3));
							}
							else
							{
								A_7 = num10;
							}
							if (Strings.InStr(1, A_3, "[SUV Weighting]", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.eb(b0(A_3));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ec(b0(A_3));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ed(b0(A_3));
							}
							if (Strings.InStr(1, A_3, "LuminousReflectance", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ee(b0(A_3));
							}
							if (Strings.InStr(1, A_3, "YID1925", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ef(b0(A_3));
							}
							if (Strings.InStr(1, A_3, "[Region Spectral Analysis - Addon]", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_4);
								hi hi3 = hi2;
								int num19 = hi3.e3() - 1;
								int result;
								for (int num20 = 0; num20 <= num19; num20++)
								{
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									if (int.TryParse(A_3, out result))
									{
										hi3.au(num20, unchecked((hi.e)result));
									}
									else
									{
										hi3.au(num20, b0(A_3) ? hi.e.b : hi.e.a);
									}
								}
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_4);
								int num21 = hi3.e9() - 1;
								for (int num22 = 0; num22 <= num21; num22++)
								{
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									if (int.TryParse(A_3, out result))
									{
										hi3.d5(num22, unchecked((hi.e)result));
									}
									else
									{
										hi3.d5(num22, b0(A_3) ? hi.e.b : hi.e.a);
									}
								}
								hi3 = null;
							}
							if (Strings.InStr(1, A_3, "[FFT Window]", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.en(b0(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.eo(b0(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.d8(Conversion.Val(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.d9(Conversion.Val(A_3));
							}
							if (Strings.InStr(A_3, "[Layer Parameters V2]", CompareMethod.Text) != 0)
							{
								int num23 = hi2.g6() + 1;
								for (int num24 = 0; num24 <= num23; num24++)
								{
									gc A_8 = hi2.et(num24);
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									A_8.ag(Conversion.Val(A_3));
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									A_8.ao(b0(Strings.Trim(A_3)));
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									A_8.af(Conversion.Val(A_3));
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									A_8.aq(b0(Strings.Trim(A_3)));
								}
							}
							if (Strings.InStr(1, A_3, "Use Robust Thickness Only if not FFT", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								hi2.e1(b0(Strings.Trim(A_3)));
								flag = true;
							}
							if (Strings.InStr(1, A_3, "[Site Average Reflectance]", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.au(b1(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ec(double.Parse(A_3, CultureInfo.InvariantCulture));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ed(double.Parse(A_3, CultureInfo.InvariantCulture));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ee(double.Parse(A_3, CultureInfo.InvariantCulture));
							}
							if (Strings.InStr(1, A_3, "MaxSolverRestarts", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								hi2.er(Conversions.ToInteger(Strings.Trim(A_3)));
							}
							if (Strings.InStr(1, A_3, "[Color Alarm]", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.au(b0(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.au(unchecked((a4.a)Conversions.ToShort(Strings.Trim(A_3))));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.d9((float)Conversion.Val(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ea((float)Conversion.Val(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.eb((float)Conversion.Val(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ec((float)Conversion.Val(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ed((float)Conversion.Val(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ee((float)Conversion.Val(Strings.Trim(A_3)));
								flag8 = true;
							}
							if (Strings.InStr(1, A_3, "[Layer CorrCoeffs]", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_4);
								int count = hi2.el().Count;
								for (int num25 = 1; num25 <= count; num25++)
								{
									gc A_8 = (gc)hi2.el()[num25];
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									double num26 = double.Parse(A_3, CultureInfo.InvariantCulture);
									i3.a(ref A_7, A_0, ref A_3);
									double num27 = double.Parse(A_3, CultureInfo.InvariantCulture);
									i3.a(ref A_7, A_0, ref A_3);
									double num28 = ca().e(double.Parse(A_3, CultureInfo.InvariantCulture));
									i3.a(ref A_7, A_0, ref A_3);
									double num29 = ca().e(double.Parse(Strings.Trim(A_3), CultureInfo.InvariantCulture));
									if (num26 != 0.0 || num27 != 0.0 || num28 != 0.0 || num29 != 0.0)
									{
										A_8.x = new gb(num26, num27, num28, num29);
									}
								}
							}
							if (Strings.InStr(1, A_3, "Calc N From Extrema", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ea(b0(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.d6(jg.e(A_3));
							}
							if (Strings.InStr(1, A_3, "[Spectrum Analysis Min/Max Hard Limits]", CompareMethod.Text) != 0)
							{
								int num30 = hi2.e9() - 1;
								for (int num31 = 0; num31 <= num30; num31++)
								{
									i3.a(ref A_7, A_0, ref A_3);
									hi2.d7(num31, b0(A_3));
								}
							}
							if (Strings.InStr(A_3, "[Site Z-Stage]", CompareMethod.Text) != 0)
							{
								hi obj = hi2;
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj.ef(double.Parse(A_3, CultureInfo.InvariantCulture));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj.eg(double.Parse(A_3, CultureInfo.InvariantCulture));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj.eu(b0(A_3));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj.ev(b0(A_3));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj.eh(double.Parse(A_3, CultureInfo.InvariantCulture));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj.d5(short.Parse(A_3, CultureInfo.InvariantCulture));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj.et(b0(A_3));
								_ = null;
							}
							if (Strings.InStr(A_3, "[LayerReps]", CompareMethod.Text) != 0)
							{
								A_3 = i3.a(ref A_7, A_0);
								int num32 = hi2.g6() + 1;
								for (int num8 = 0; num8 <= num32; num8++)
								{
									gc A_8 = hi2.et(num8);
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									A_8.af(short.Parse(A_3, CultureInfo.InvariantCulture));
								}
								break;
							}
							if (Strings.InStr(A_3, "[Additional Recipes]", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								int num33 = int.Parse(A_3) - 1;
								for (int num34 = 0; num34 <= num33; num34++)
								{
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									string a_3 = Encoding.UTF8.GetString(Convert.FromBase64String(A_3));
									i3.a(ref A_7, A_0, ref A_3);
									hj.a a_4 = unchecked((hj.a)int.Parse(A_3));
									i3.a(ref A_7, A_0, ref A_3);
									bool a_5 = b0(A_3);
									hi2.es().Add(new hj(a_3, a_4, a_5));
								}
								break;
							}
							if (Strings.InStr(A_3, "[OptoValues]", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								hi.f obj2 = hi2.c9;
								obj2.r(b0(A_3));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj2.o(b0(A_3));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj2.a(float.Parse(A_3, CultureInfo.InvariantCulture));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj2.h(float.Parse(A_3, CultureInfo.InvariantCulture));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj2.p(b0(A_3));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj2.o(float.Parse(A_3, CultureInfo.InvariantCulture));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj2.p(float.Parse(A_3, CultureInfo.InvariantCulture));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj2.s(b0(A_3));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj2.q(float.Parse(A_3, CultureInfo.InvariantCulture));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj2.q(b0(A_3));
								_ = null;
								break;
							}
							if (Strings.InStr(A_3, "FFT Measure Total Thickness", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								hi2.c3 = b0(A_3);
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								hi2.c6 = float.Parse(A_3, CultureInfo.InvariantCulture);
								break;
							}
							if (Strings.InStr(A_3, "FFTWindowType", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								hi2.au(unchecked((hi.d)int.Parse(A_3, CultureInfo.InvariantCulture)));
								break;
							}
							if (Strings.InStr(A_3, "FFTScalingFactor", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								hi2.ei(float.Parse(A_3, CultureInfo.InvariantCulture));
								break;
							}
							string @string = "======End of measure site  " + Conversions.ToString(num3 + 1) + " ======";
							if (Strings.InStr(1, A_3, @string, CompareMethod.Text) != 0)
							{
								if (!flag)
								{
									hi2.e1(a_2);
								}
								if (flag3)
								{
									int num35 = hi2.g7() + 1;
									for (int num36 = 0; num36 <= num35; num36++)
									{
										gc gc2 = hi2.eu(num36);
										if (gc2.ao())
										{
											gc2.aq(A_0: true);
										}
										gc2 = null;
									}
								}
								bu(hi2);
								hi2 = null;
								hi2 = new hi(this.m_cu);
								hi2.d5(-1.0);
								hi2.au(-1.0);
								num3++;
								if (num3 == num)
								{
									flag4 = true;
								}
							}
							if (!flag4)
							{
								i3.a(ref A_7, A_0, ref A_3);
							}
							continue;
						}
						if (Strings.InStr(1, A_3, "[WaferMap]", CompareMethod.Text) != 0)
						{
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_b0 = (short)Math.Round(double.Parse(bv(ref A_3), CultureInfo.InvariantCulture));
							if (num2 < 6)
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_5);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_6);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								_ = (float)double.Parse(A_3, CultureInfo.InvariantCulture);
							}
							else
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								this.m_b1 = jg.e(A_3);
								if (bn != hg.j.c)
								{
									this.m_b1 = "";
								}
							}
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_b2 = (int)Math.Round(double.Parse(A_3, CultureInfo.InvariantCulture));
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_b3 = b1(Strings.Trim(A_3));
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_b4 = b1(Strings.Trim(A_3));
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_b5 = b1(Strings.Trim(A_3));
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_b7 = b1(Strings.Trim(A_3));
							if (num2 >= 4)
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								this.m_b8 = b1(Strings.Trim(A_3));
							}
							else
							{
								this.m_b8 = 0;
							}
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_b9 = double.Parse(A_3, CultureInfo.InvariantCulture);
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_ca = double.Parse(A_3, CultureInfo.InvariantCulture);
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							if (b1(Strings.Trim(A_3)) == 0)
							{
								this.m_cb = false;
							}
							else
							{
								this.m_cb = true;
							}
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_cc = double.Parse(A_3, CultureInfo.InvariantCulture);
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_cd = b1(Strings.Trim(A_3));
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_ce = b1(Strings.Trim(A_3));
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							b1(Strings.Trim(A_3));
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							double.Parse(A_3, CultureInfo.InvariantCulture);
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							double.Parse(A_3, CultureInfo.InvariantCulture);
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							double.Parse(A_3, CultureInfo.InvariantCulture);
						}
						if (Strings.InStr(1, A_3, "Wafer Width", CompareMethod.Text) != 0)
						{
							i3.a(ref A_7, A_0, ref A_3);
							bu(float.Parse(A_3, CultureInfo.InvariantCulture));
						}
						if (Strings.InStr(1, A_3, "Wafer Height", CompareMethod.Text) != 0)
						{
							i3.a(ref A_7, A_0, ref A_3);
							bv(float.Parse(A_3, CultureInfo.InvariantCulture));
						}
						unchecked
						{
							if (Strings.InStr(1, A_3, "Wafer Full Reference Mode", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								bu((h)short.Parse(A_3, CultureInfo.InvariantCulture));
							}
							if (Strings.InStr(1, A_3, "[Wafer Details]", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								by(b0(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								bz(b0(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								bw(float.Parse(A_3, CultureInfo.InvariantCulture));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								bx(float.Parse(A_3, CultureInfo.InvariantCulture));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								b0(b0(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								b1(b0(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								bu((n)Conversions.ToInteger(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								bu((m)Conversions.ToInteger(Strings.Trim(A_3)));
							}
							if (Strings.InStr(1, A_3, "[CUSTOM EXPORT]") != 0)
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								this.m_b6 = b1(Strings.Trim(A_3));
							}
							if (Strings.InStr(1, A_3, "[Acqusition Settings]") != 0)
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								if (Operators.CompareString(A_4, "Number of Smoothing Points", TextCompare: false) == 0)
								{
									this.m_cw = checked((int)Math.Round(Conversion.Val(A_3)));
								}
								else
								{
									this.m_cw = 1;
								}
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.b((global::h.MeasurementTimingType)Conversions.ToInteger(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.a(0).h((global::f.a)Conversions.ToInteger(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.a(Conversion.Val(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								double a_6 = Conversion.Val(A_3);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								int a_7 = Conversions.ToInteger(Strings.Trim(A_3));
								this.m_c2.a(0).b(global::f.b.b, a_6, a_7);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								a_6 = Conversion.Val(A_3);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								a_7 = Conversions.ToInteger(Strings.Trim(A_3));
								this.m_c2.a(0).b(global::f.b.c, a_6, a_7);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.a(0).h(global::f.b.b, Conversion.Val(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.a(0).h(global::f.b.c, Conversion.Val(A_3));
							}
							if (Strings.InStr(1, A_3, "<Reference Material1>") != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.a(global::h.g.a).c(jg.e(A_3));
							}
							if (Strings.InStr(1, A_3, "<ReferenceMaterialKnown1>") != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.a(global::h.g.a).c(b0(A_3));
							}
							if (Strings.InStr(1, A_3, "[Acquisition2 Settings]") != 0)
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.a(1).h((global::f.a)Conversions.ToInteger(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								double a_8 = Conversion.Val(A_3);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								int a_9 = Conversions.ToInteger(Strings.Trim(A_3));
								this.m_c2.a(1).b(global::f.b.b, a_8, a_9);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								a_8 = Conversion.Val(A_3);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								a_9 = Conversions.ToInteger(Strings.Trim(A_3));
								this.m_c2.a(1).b(global::f.b.c, a_8, a_9);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.a(1).h(global::f.b.b, Conversion.Val(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.a(1).h(global::f.b.c, Conversion.Val(A_3));
							}
							if (Strings.InStr(1, A_3, "[Acquisition3 Settings]") != 0)
							{
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.a(2).h((global::f.a)Conversions.ToInteger(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								double a_10 = Conversion.Val(A_3);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								int a_11 = Conversions.ToInteger(Strings.Trim(A_3));
								this.m_c2.a(2).b(global::f.b.b, a_10, a_11);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								a_10 = Conversion.Val(A_3);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								a_11 = Conversions.ToInteger(Strings.Trim(A_3));
								this.m_c2.a(2).b(global::f.b.c, a_10, a_11);
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.a(2).h(global::f.b.b, Conversion.Val(A_3));
								i3.a(ref A_7, A_0, ref A_4);
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.a(2).h(global::f.b.c, Conversion.Val(A_3));
							}
							if (Strings.InStr(1, A_3, "<Reference Material2>") != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.a(global::h.g.b).c(jg.e(A_3));
							}
							if (Strings.InStr(1, A_3, "<ReferenceMaterialKnown2>") != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.a(global::h.g.b).c(b0(A_3));
							}
							if (Strings.InStr(1, A_3, "Smoothing Thickness") != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								this.m_cv = (float)new h4(h4.a.c).e(Conversion.Val(A_3));
							}
							if (Strings.InStr(1, A_3, "Graph limits start wavelength") != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								this.m_cx = (float)Conversion.Val(A_3);
							}
							if (Strings.InStr(1, A_3, "Graph limits end wavelength") != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								this.m_cy = (float)Conversion.Val(A_3);
							}
							if (Strings.InStr(1, A_3, "Measure delay") != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.a((float)Conversion.Val(A_3));
							}
							if (Strings.InStr(1, A_3, "Stored baseline name") != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.a(A_3);
							}
							if (Strings.InStr(1, A_3, "Dual Meas Selected Type") != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.r((global::h.e)checked((int)Math.Round(Conversion.Val(A_3))));
							}
							if (Strings.InStr(1, A_3, "Dual Meas Trans Spec Same As R") != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								this.m_c2.b(b0(Strings.Trim(A_3)));
							}
							if (Strings.InStr(1, A_3, "[Optics Configuration]") != 0)
							{
								this.m_db = new g2();
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								A_3 = jg.e(A_3);
								g2 g10 = this.m_db;
								if (Strings.InStr(1, A_3, "Nothing") != 0)
								{
									g10.w = null;
								}
								else
								{
									g10.w = A_3;
								}
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								g10.d(A_3);
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								g10.a(b0(Strings.Trim(A_3)));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								g10.o((g2.a)checked((int)Math.Round(Conversion.Val(A_3))));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								g10.x = b0(Strings.Trim(A_3));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								g10.y = b0(Strings.Trim(A_3));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								g10.z = b0(Strings.Trim(A_3));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								g10.aa = b0(Strings.Trim(A_3));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								g10.a((es)null);
								if (b0(Strings.Trim(A_3)))
								{
									g10.a(new et());
									et obj3 = (et)g10.r();
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									obj3.t(jg.e(A_3));
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									obj3.t(float.Parse(A_3, CultureInfo.InvariantCulture));
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									obj3.u(float.Parse(A_3, CultureInfo.InvariantCulture));
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									obj3.v(float.Parse(A_3, CultureInfo.InvariantCulture));
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									obj3.x(float.Parse(A_3, CultureInfo.InvariantCulture));
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									obj3.y(float.Parse(A_3, CultureInfo.InvariantCulture));
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									obj3.z(float.Parse(A_3, CultureInfo.InvariantCulture));
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									obj3.t(b0(Strings.Trim(A_3)));
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									obj3.u(b0(Strings.Trim(A_3)));
									_ = null;
								}
								g10 = null;
							}
							if (Strings.InStr(1, A_3, "[CTM Optics Configuration]") != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								g2 g11 = this.m_db;
								g11.a((cf)null);
								if (b0(Strings.Trim(A_3)))
								{
									g11.a(new cf());
									i3.a(ref A_7, A_0, ref A_3);
									i3.a(ref A_7, A_0, ref A_3);
									g11.s().m(jg.e(A_3));
								}
								g11 = null;
							}
							if (Strings.InStr(1, A_3, "[Z Optics]") != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								this.m_de = (b)checked((byte)Conversions.ToInteger(A_3));
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								bu(new Guid(A_3));
							}
							if (Strings.InStr(1, A_3, "[Vs Time Analysis Settings]") != 0)
							{
								jk obj4 = b9();
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj4.b = float.Parse(A_3, CultureInfo.InvariantCulture);
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj4.c = float.Parse(A_3, CultureInfo.InvariantCulture);
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj4.d = int.Parse(A_3, CultureInfo.InvariantCulture);
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj4.e = float.Parse(A_3, CultureInfo.InvariantCulture);
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj4.f = b0(A_3);
								obj4.g = !obj4.f;
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj4.h = b0(A_3);
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj4.i = float.Parse(A_3, CultureInfo.InvariantCulture);
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj4.j = b0(A_3);
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj4.k = float.Parse(A_3, CultureInfo.InvariantCulture);
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj4.l = b0(A_3);
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj4.m = float.Parse(A_3, CultureInfo.InvariantCulture);
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj4.n = b0(A_3);
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj4.o = float.Parse(A_3, CultureInfo.InvariantCulture);
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj4.p = b0(A_3);
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								obj4.a = (jk.a)short.Parse(A_3);
								_ = null;
							}
							if (Strings.InStr(A_3, "Show Thickness range in Thickness units", CompareMethod.Text) != 0)
							{
								i3.a(ref A_7, A_0, ref A_3);
								this.m_bx = b0(A_3);
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								this.m_by = b0(A_3);
								break;
							}
						}
						if (Strings.InStr(A_3, "[Photodiode Acq. Settings]", CompareMethod.Text) != 0)
						{
							List<global::h.a> list = this.m_c2.a2();
							list.Clear();
							i3.a(ref A_7, A_0, ref A_3);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_c2.b(float.Parse(A_3.Trim(), CultureInfo.InvariantCulture));
							i3.a(ref A_7, A_0, ref A_3);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_c2.p(b0(A_3));
							i3.a(ref A_7, A_0, ref A_3);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_c2.b(Conversions.ToInteger(Strings.Trim(A_3)));
							i3.a(ref A_7, A_0, ref A_3);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_c2.d(float.Parse(A_3.Trim(), CultureInfo.InvariantCulture));
							i3.a(ref A_7, A_0, ref A_3);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_c2.r(b0(A_3));
							i3.a(ref A_7, A_0, ref A_3);
							i3.a(ref A_7, A_0, ref A_3);
							int num37 = Conversions.ToInteger(Strings.Trim(A_3));
							i3.a(ref A_7, A_0);
							int num38 = num37 - 1;
							for (int num39 = 0; num39 <= num38; num39++)
							{
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								float a_12 = float.Parse(A_3.Trim(), CultureInfo.InvariantCulture);
								i3.a(ref A_7, A_0, ref A_3);
								bool a_13 = b0(A_3.Trim());
								i3.a(ref A_7, A_0, ref A_3);
								float a_14 = float.Parse(A_3.Trim(), CultureInfo.InvariantCulture);
								i3.a(ref A_7, A_0, ref A_3);
								string a_15 = A_3.Trim();
								list.Add(new global::h.a(a_12, a_15, a_13, a_14));
							}
							list = null;
							break;
						}
						if (Strings.InStr(A_3, "[Backside Subtraction]", CompareMethod.Text) != 0)
						{
							flag9 = true;
							i3.a(ref A_7, A_0, ref A_3);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_cz = b0(A_3);
							i3.a(ref A_7, A_0, ref A_3);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_c0 = b3(jg.e(A_3));
							break;
						}
						if (Strings.InStr(A_3, "Ignore Baseline Info in Recipe", CompareMethod.Text) != 0)
						{
							i3.a(ref A_7, A_0, ref A_3);
							this.m_c2.a(b0(A_3));
							break;
						}
						if (Strings.InStr(A_3, "[AutoFocus Settings]", CompareMethod.Text) != 0)
						{
							i3.a(ref A_7, A_0, ref A_3);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_c2.d().a = b0(A_3);
							i3.a(ref A_7, A_0, ref A_3);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_c2.d().i(unchecked((global::h.d.a)Conversions.ToInteger(A_3)));
							i3.a(ref A_7, A_0, ref A_3);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_c2.d().c = (float)Conversion.Val(A_3);
							i3.a(ref A_7, A_0, ref A_3);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_c2.d().d = (float)Conversion.Val(A_3);
							break;
						}
						if (Strings.InStr(A_3, "Auto Focus Max Signal Sample Thickness", CompareMethod.Text) != 0)
						{
							i3.a(ref A_7, A_0, ref A_3);
							this.m_c2.d().e = (float)Conversion.Val(A_3);
							break;
						}
						if (Strings.InStr(1, A_3, "Reflective Objective Focus Range Percent") != 0)
						{
							i3.a(ref A_7, A_0, ref A_3);
							this.m_c2.d().f = (float)Conversion.Val(A_3);
						}
						if (Strings.InStr(1, A_3, "Reflective Objective Focus Step Size Percent") != 0)
						{
							i3.a(ref A_7, A_0, ref A_3);
							this.m_c2.d().g = (float)Conversion.Val(A_3);
						}
						if (Strings.InStr(A_3, "[AutoFocus2 Settings]", CompareMethod.Text) != 0)
						{
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_cf = b0(A_3);
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_cg = b0(A_3);
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_ch = b0(A_3);
							i3.a(ref A_7, A_0, ref A_4);
							i3.a(ref A_7, A_0, ref A_3);
						}
						else if (Strings.InStr(A_3, "[SpectrometervsTime Acq. Settings]", CompareMethod.Text) != 0)
						{
							i3.a(ref A_7, A_0, ref A_3);
							i3.a(ref A_7, A_0, ref A_3);
							this.m_c2.a(A_0: false, A_1: false, !b0(A_3.Trim()));
							List<global::h.b> list2 = this.m_c2.au();
							list2.Clear();
							i3.a(ref A_7, A_0, ref A_3);
							i3.a(ref A_7, A_0, ref A_3);
							int num40 = Conversions.ToInteger(Strings.Trim(A_3));
							i3.a(ref A_7, A_0);
							int num41 = num40 - 1;
							for (int num42 = 0; num42 <= num41; num42++)
							{
								i3.a(ref A_7, A_0, ref A_3);
								i3.a(ref A_7, A_0, ref A_3);
								float a_16 = float.Parse(A_3.Trim(), CultureInfo.InvariantCulture);
								i3.a(ref A_7, A_0, ref A_3);
								bool a_17 = b0(A_3.Trim());
								list2.Add(new global::h.b(a_16, a_17));
							}
							list2 = null;
						}
						else if (Strings.InStr(1, A_3, "Map Origin Offset Type") != 0)
						{
							i3.a(ref A_7, A_0, ref A_3);
							this.m_dg = unchecked((c)int.Parse(A_3));
						}
						else if (Strings.InStr(1, A_3, "Map Origin Offset Absolute X") != 0)
						{
							i3.a(ref A_7, A_0, ref A_3);
							this.m_dh = float.Parse(A_3, CultureInfo.InvariantCulture);
						}
						else if (Strings.InStr(1, A_3, "Map Origin Offset Absolute Y") != 0)
						{
							i3.a(ref A_7, A_0, ref A_3);
							this.m_di = float.Parse(A_3, CultureInfo.InvariantCulture);
						}
						else if (Strings.InStr(1, A_3, "Use Recipe Based MapAutosavePath") != 0)
						{
							i3.a(ref A_7, A_0, ref A_3);
							this.m_dj = b0(A_3);
						}
						else if (Strings.InStr(1, A_3, "Map Autosave Path") != 0)
						{
							i3.a(ref A_7, A_0, ref A_3);
							this.m_dk = A_3;
						}
						break;
					}
				}
				if (b5(A_2))
				{
					while (bq.Count > 1)
					{
						bq.Remove(bq.Count);
					}
				}
				int num43 = dz();
				for (int num44 = 1; num44 <= num43; num44++)
				{
					hi2 = b3(num44);
					hi2.br.c = ca().e(hi2.br.c);
					hi2.br.d = ca().e(hi2.br.d);
					int num45 = hi2.g6() + 1;
					for (int num8 = 0; num8 <= num45; num8++)
					{
						gc A_8 = hi2.et(num8);
						A_8.af(A_0: false, A_1: true, ca().e(A_8.ai()));
						A_8.aj(ca().e(A_8.an()));
						if (!A_1)
						{
							A_8.ah(ca().e(A_8.al()));
							A_8.ai(ca().e(A_8.am()));
						}
					}
					if (hi2.g9() * 2f >= (float)this.m_b0)
					{
						hi2.ej((float)(0.5 * (double)this.m_b0 - 0.1));
					}
					if (hi2.g9() < 0f)
					{
						hi2.ej(0f);
					}
					if (hi2.hf() && hi2.au(this.m_cu.aw(null), null))
					{
						hi2.hm();
					}
					if (!flag8)
					{
						hi2.hl();
					}
				}
				if (!flag9)
				{
					this.m_cz = false;
					if (b5())
					{
						this.m_c0 = null;
					}
					else
					{
						eg();
					}
				}
				hg A_9 = this;
				bv(ref A_9);
				bm = true;
				result2 = true;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				result2 = false;
				ProjectData.ClearProjectError();
			}
			return result2;
		}
	}

	public int bu(ref double A_0, ref double A_1, int A_2 = 0, int A_3 = 0)
	{
		hi hi2 = ((A_2 != 0) ? b3(A_2) : b3(bp));
		int result = 0;
		if (hi2.g7() >= 1)
		{
			if (A_3 != 0)
			{
				gc gc2 = hi2.eu(A_3);
				if (gc2.ao())
				{
					A_0 = gc2.ai();
					A_1 = gc2.av();
					result = A_3;
				}
			}
			else
			{
				int num = default(int);
				do
				{
					gc gc2 = hi2.eu(num);
					if (gc2.ao())
					{
						A_0 = gc2.ai();
						A_1 = gc2.av();
						result = num;
						break;
					}
					num = checked(num + 1);
				}
				while (num <= hi2.g7());
			}
		}
		return result;
	}

	public bool bu(eo.a A_0)
	{
		int num = 1;
		bool flag = this.m_cu.a0(A_0);
		if (dz() == 0)
		{
			return false;
		}
		checked
		{
			do
			{
				hi hi2 = b3(num);
				if (hi2.gc() != 0)
				{
					return true;
				}
				if (b5())
				{
					if (!flag)
					{
						return false;
					}
					int num2 = hi2.e9() - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						if (hi2.ei(num3) && hi2.ej(num3) == hi.e.a)
						{
							return true;
						}
					}
					int num4 = hi2.e3() - 1;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						if (hi2.d9(num5) && hi2.ea(num5) == hi.e.a)
						{
							return true;
						}
					}
				}
				num++;
			}
			while (num <= dz());
			return false;
		}
	}

	public bool bv(eo.a A_0)
	{
		int num = 1;
		bool flag = this.m_cu.a0(A_0);
		if (dz() == 0)
		{
			return false;
		}
		checked
		{
			do
			{
				hi hi2 = b3(num);
				if (b5())
				{
					if (!flag)
					{
						return false;
					}
					int num2 = hi2.e9() - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						if (hi2.ei(num3) && hi2.ej(num3) == hi.e.b)
						{
							return true;
						}
					}
					int num4 = hi2.e3() - 1;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						if (hi2.d9(num5) && hi2.ea(num5) == hi.e.b)
						{
							return true;
						}
					}
				}
				num++;
			}
			while (num <= dz());
			return false;
		}
	}

	public bool bw(eo.a A_0)
	{
		int num = 1;
		bool flag = this.m_cu.a0(A_0);
		if (dz() == 0)
		{
			return false;
		}
		checked
		{
			do
			{
				hi hi2 = b3(num);
				if (b5())
				{
					if (!flag)
					{
						return false;
					}
					int num2 = hi2.e9() - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						if (hi2.ei(num3) && hi2.ej(num3) == hi.e.c)
						{
							return true;
						}
					}
					int num4 = hi2.e3() - 1;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						if (hi2.d9(num5) && hi2.ea(num5) == hi.e.c)
						{
							return true;
						}
					}
				}
				num++;
			}
			while (num <= dz());
			return false;
		}
	}

	public bool bx(eo.a A_0)
	{
		if (dz() == 0)
		{
			return false;
		}
		int num = 1;
		do
		{
			hi hi2 = b3(num);
			if (hi2.c9.a(this.m_cu, A_0))
			{
				return true;
			}
			if (hi2.c9.h(this.m_cu, A_0))
			{
				return true;
			}
			num = checked(num + 1);
		}
		while (num <= dz());
		return false;
	}

	public bool bu(eo.a A_0, bool A_1)
	{
		bool a_ = this.m_cu.ax(A_0);
		bool a_2 = this.m_cu.az(A_0);
		eo.b a_3 = this.m_cu.at(A_0, A_1);
		if (b5() || dz() == 0)
		{
			return false;
		}
		int num = 1;
		checked
		{
			do
			{
				hi hi2 = b3(num);
				if (hi2.g7() >= 1)
				{
					int num2 = 1;
					do
					{
						gc gc2 = hi2.eu(num2);
						if (gc2.af(a_3))
						{
							return true;
						}
						if (gc2.aj(a_))
						{
							return true;
						}
						if (gc2.ah(a_))
						{
							return true;
						}
						if (gc2.al(a_))
						{
							return true;
						}
						if (num2 < hi2.g7() - 1)
						{
							if (gc2.an(a_))
							{
								return true;
							}
							if (gc2.ap(a_2))
							{
								return true;
							}
						}
						num2++;
					}
					while (num2 <= hi2.g7());
				}
				num++;
			}
			while (num <= dz());
			return false;
		}
	}

	public void eh()
	{
		if (dz() == 0)
		{
			return;
		}
		int num = 1;
		checked
		{
			do
			{
				hi hi2 = b3(num);
				if (hi2.g7() >= 1)
				{
					int num2 = 1;
					do
					{
						gc obj = hi2.eu(num2);
						obj.ag(A_0: false);
						obj.ak(A_0: false);
						obj.ai(A_0: false);
						obj.am(A_0: false);
						obj.aq(A_0: false);
						obj.ao(A_0: false);
						_ = null;
						num2++;
					}
					while (num2 <= hi2.g7());
				}
				num++;
				hi2.ew(A_0: false);
				hi2.ex(A_0: false);
				hi2.ez(A_0: false);
				hi2.ey(A_0: false);
				hi2.e1(A_0: false);
				hi2.e2(A_0: false);
				hi2 = null;
			}
			while (num <= dz());
		}
	}

	public static bool b2(string A_0)
	{
		if (Operators.CompareString(A_0, "<Roughness>", TextCompare: false) != 0 && Operators.CompareString(A_0, "<Graded Interface>", TextCompare: false) != 0)
		{
			return Operators.CompareString(A_0, "<Graded>", TextCompare: false) == 0;
		}
		return true;
	}

	public bool by(eo.a A_0)
	{
		bool a_ = this.m_cu.ax(A_0);
		if (dz() == 0)
		{
			return false;
		}
		if (b5())
		{
			return false;
		}
		int num = dz();
		checked
		{
			for (int num2 = 1; num2 <= num; num2++)
			{
				hi hi2 = b3(num2);
				int num3 = hi2.g7() + 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					gc gc2 = hi2.eu(num4);
					if (gc2.ah(a_) || gc2.aj(a_))
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	[SpecialName]
	public bool ei()
	{
		return this.m_bw;
	}

	[SpecialName]
	public void ca(bool A_0)
	{
		this.m_bw = A_0;
	}

	public static string bv(string A_0, int A_1 = 0, int A_2 = 0, bool A_3 = false)
	{
		string text = ((!A_3) ? A_0 : ("\"" + A_0 + "\""));
		int num = ((A_1 != 0) ? A_1 : Strings.Len(text));
		if (Strings.Len(text) > num)
		{
			return text;
		}
		checked
		{
			int num3 = default(int);
			int num2 = default(int);
			switch (A_2)
			{
			case 0:
				num3 = 0;
				num2 = num - Strings.Len(Strings.Trim(text));
				if (num2 < 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				num3 = (int)Math.Round((double)(num - Strings.Len(Strings.Trim(text))) / 2.0);
				if (num3 < 0)
				{
					num3 = 0;
				}
				num2 = num - Strings.Len(Strings.Trim(text)) - num3;
				if (num2 < 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				num2 = 0;
				num3 = num - Strings.Len(Strings.Trim(text));
				if (num3 < 0)
				{
					num3 = 0;
				}
				break;
			}
			return new string(' ', num3) + Strings.Trim(text) + new string(' ', num2);
		}
	}

	public void bv(ref hg A_0)
	{
	}

	public static void bu(a4.a A_0, ref string A_1, ref string A_2, ref string A_3)
	{
		switch (A_0)
		{
		case global::a4.a.a:
			A_1 = "L*";
			A_2 = "a*";
			A_3 = "b*";
			break;
		case global::a4.a.b:
			A_1 = "L*";
			A_2 = "u*";
			A_3 = "v*";
			break;
		case global::a4.a.c:
			A_1 = "L*";
			A_2 = "C*";
			A_3 = "h";
			break;
		case global::a4.a.d:
			A_1 = "X";
			A_2 = "Y";
			A_3 = "Z";
			break;
		}
	}

	public static void bu(a4.a A_0, Label A_1, Label A_2, Label A_3)
	{
		string A_4 = null;
		string A_5 = null;
		string A_6 = null;
		bu(A_0, ref A_4, ref A_5, ref A_6);
		A_1.Text = A_4 + ":";
		A_2.Text = A_5 + ":";
		A_3.Text = A_6 + ":";
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public bool bu(string A_0, global::r.d A_1, global::r.d.a.b A_2, fz A_3, j A_4)
	{
		checked
		{
			bool result;
			int num = default(int);
			try
			{
				result = true;
				FileSystemProxy fileSystem = global::c.e().FileSystem;
				if (fileSystem.DirectoryExists(i3.g()))
				{
					fileSystem.DeleteDirectory(i3.g(), DeleteDirectoryOption.DeleteAllContents);
				}
				fileSystem.CreateDirectory(i3.g());
				fileSystem = null;
				num = Microsoft.VisualBasic.FileSystem.FreeFile();
				Microsoft.VisualBasic.FileSystem.FileOpen(num, A_0, OpenMode.Binary, OpenAccess.Read);
				short Value = default(short);
				Microsoft.VisualBasic.FileSystem.FileGet(num, ref Value, -1L);
				short Value2 = default(short);
				Microsoft.VisualBasic.FileSystem.FileGet(num, ref Value2, -1L);
				int Value3 = default(int);
				Microsoft.VisualBasic.FileSystem.FileGet(num, ref Value3, -1L);
				int Value4 = default(int);
				Microsoft.VisualBasic.FileSystem.FileGet(num, ref Value4, -1L);
				short Value5 = default(short);
				Microsoft.VisualBasic.FileSystem.FileGet(num, ref Value5, -1L);
				short num2 = (short)(Value5 - 1);
				short num3 = 0;
				int Value6 = default(int);
				short Value7 = default(short);
				int Value8 = default(int);
				short Value11 = default(short);
				short Value12 = default(short);
				while (true)
				{
					if (num3 <= num2)
					{
						Microsoft.VisualBasic.FileSystem.FileGet(num, ref Value6, -1L);
						Microsoft.VisualBasic.FileSystem.FileGet(num, ref Value7, -1L);
						Microsoft.VisualBasic.FileSystem.FileGet(num, ref Value8, -1L);
						string Value9 = new string(' ', Value8);
						Microsoft.VisualBasic.FileSystem.FileGet(num, ref Value9, -1L);
						Microsoft.VisualBasic.FileSystem.FileGet(num, ref Value8, -1L);
						string Value10 = new string(' ', Value8);
						Microsoft.VisualBasic.FileSystem.FileGet(num, ref Value10, -1L);
						int num4 = Microsoft.VisualBasic.FileSystem.FreeFile();
						Microsoft.VisualBasic.FileSystem.FileOpen(num4, i3.g() + "\\StringData.txt", OpenMode.Output);
						Microsoft.VisualBasic.FileSystem.PrintLine(num4, Value10);
						Microsoft.VisualBasic.FileSystem.FileClose(num4);
						e e10 = unchecked((e)Value7);
						if (e10 == hg.e.a)
						{
							Microsoft.VisualBasic.FileSystem.Rename(i3.g() + "\\StringData.txt", i3.g() + "\\CurrentRecipe.txt");
							if (A_4 == hg.j.a)
							{
								Microsoft.VisualBasic.FileSystem.FileClose(num);
								break;
							}
						}
						num3 = (short)unchecked(num3 + 1);
						continue;
					}
					Value4 = (int)Microsoft.VisualBasic.FileSystem.Seek(num);
					Microsoft.VisualBasic.FileSystem.FileGet(num, ref Value11, -1L);
					short num5 = (short)(Value11 - 1);
					for (num3 = 0; num3 <= num5; num3 = (short)unchecked(num3 + 1))
					{
						Microsoft.VisualBasic.FileSystem.FileGet(num, ref Value8, -1L);
						Microsoft.VisualBasic.FileSystem.FileGet(num, ref Value12, -1L);
						Microsoft.VisualBasic.FileSystem.FileGet(num, ref Value8, -1L);
						byte[] A_5 = new byte[Value8 - 1 + 1];
						int num6 = Value8 - 1;
						for (int num7 = 0; num7 <= num6; num7++)
						{
							Microsoft.VisualBasic.FileSystem.FileGet(num, ref A_5[num7], -1L);
						}
						string A_6 = i3.g() + "\\ByteData.bin";
						i3.a(ref A_6, ref A_5);
						_ = 1;
					}
					break;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				result = false;
				ProjectData.ClearProjectError();
			}
			finally
			{
				Microsoft.VisualBasic.FileSystem.FileClose(num);
			}
			return result;
		}
	}

	public int bu(ref ListBox A_0, ref int A_1, ref string A_2)
	{
		return bu(A_0.Handle.ToInt32(), A_1, -1, ref A_2);
	}

	public static bool bu(ref hg A_0, ref string A_1, j A_2, bool A_3, global::r.d A_4, global::r.d.a.b A_5, fz A_6, bool A_7, Point A_8, string A_9, g2.b A_10, bool A_11, hf A_12, bool A_13)
	{
		return bu(A_0, ref A_1, A_2, A_3: false, A_3, A_5: true, A_4, A_5, A_6, A_7, A_8, A_9, A_10, A_11, A_12, A_13);
	}

	public static bool bu(hg A_0, j A_1, bool A_2, global::r.d A_3, global::r.d.a.b A_4, fz A_5, g2.b A_6, bool A_7, bool A_8)
	{
		string A_9 = "";
		return bu(A_0, ref A_9, A_1, A_3: true, A_2, A_5: true, A_3, A_4, A_5, A_9: false, default(Point), null, A_6, A_7, null, A_8);
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private static bool bu(hg A_0, ref string A_1, j A_2, bool A_3, bool A_4, bool A_5, global::r.d A_6, global::r.d.a.b A_7, fz A_8, bool A_9, Point A_10, string A_11, g2.b A_12, bool A_13, hf A_14, bool A_15)
	{
		bool flag = false;
		bool flag2;
		if (!A_3)
		{
			try
			{
				Path.GetExtension(A_1);
				flag2 = true;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				flag2 = false;
				A_8.c(global::fz.b.a, "Attempt to load invalid recipe file \"" + A_1 + "\"");
				ProjectData.ClearProjectError();
			}
		}
		else
		{
			flag2 = true;
		}
		checked
		{
			if (flag2 && !A_3 && ((Operators.CompareString(Path.GetExtension(A_1), ".fitra", TextCompare: false) == 0 && A_4) || (Operators.CompareString(Path.GetExtension(A_1), ".fitra", TextCompare: false) != 0 && !A_4)))
			{
				if (A_0.bu(A_1, A_2, A_6, A_7, A_4: true, A_9, A_10, A_11, A_12, A_13, A_8, A_14, A_15, A_13: false, null, A_15: false))
				{
					flag = true;
					goto IL_028b;
				}
				if (!global::c.e().FileSystem.FileExists(A_1))
				{
					if (!A_5 & (Operators.CompareString(Path.GetFileNameWithoutExtension(A_1), "DefaultRecipe", TextCompare: false) != 0))
					{
						Interaction.MsgBox("Recipe file:" + A_1 + " does not exist\r\nThe default recipe will be loaded");
					}
					else
					{
						A_8.c(global::fz.b.a, "Recipe file:" + A_1 + " does not exist\r\nThe default recipe will be loaded");
					}
				}
				else if (!A_5)
				{
					if (A_7 == global::r.d.a.b.a && Interaction.MsgBox(A_1 + " recipe is corrupted \r\nRemove it from the list? ", MsgBoxStyle.OkCancel) == MsgBoxResult.Ok)
					{
						try
						{
							if (global::c.e().FileSystem.FileExists(Strings.Mid(A_1, 1, Strings.Len(A_1) - 4)))
							{
								if (Microsoft.VisualBasic.FileSystem.GetAttr(Strings.Mid(A_1, 1, Strings.Len(A_1) - 4)) > FileAttribute.Normal)
								{
									Microsoft.VisualBasic.FileSystem.SetAttr(Strings.Mid(A_1, 1, Strings.Len(A_1) - 4), FileAttribute.Normal);
								}
								Microsoft.VisualBasic.FileSystem.Kill(Strings.Mid(A_1, 1, Strings.Len(A_1) - 4));
							}
							Microsoft.VisualBasic.FileSystem.Rename(A_1, Strings.Mid(A_1, 1, Strings.Len(A_1) - 4));
						}
						catch (Exception ex4)
						{
							ProjectData.SetProjectError(ex4);
							Exception a_ = ex4;
							A_8.c(global::fz.b.a, "Failed to rename corrupted recipe in Recipe.LoadRecipeObject", a_);
							ProjectData.ClearProjectError();
						}
					}
				}
				else
				{
					A_8.c(global::fz.b.a, A_1 + " recipe is corrupted.");
				}
			}
		}
		A_0.bw((int)A_2);
		if (A_4)
		{
			A_0.cc(b0() + "DefaultRecipe.fitra");
		}
		else
		{
			A_0.cc(b0() + "DefaultRecipe.fitrp");
		}
		A_1 = A_0.c1();
		A_0.ef();
		A_0.bw(DateTime.Now.ToOADate());
		A_0.b9("DefaultRecipe");
		A_0.ca(Guid.NewGuid().ToString());
		A_0.cb("Unknown User");
		A_0.bu(A_12, A_13);
		flag = true;
		A_0.bv(A_6, A_1: false);
		goto IL_028b;
		IL_028b:
		return flag;
	}

	public bool bu(fz A_0, hi A_1, ref string A_2, ref int A_3, Point A_4, ref bool A_5, eo.a A_6, bool A_7)
	{
		checked
		{
			int num = b5(0) + 1;
			eo.b a_ = this.m_cu.at(A_6, A_7);
			A_5 = false;
			if (!dh().a1())
			{
				return true;
			}
			hi hi2 = A_1;
			int num2 = num;
			double A_10 = default(double);
			double A_11 = default(double);
			for (A_3 = 0; A_3 <= num2; A_3++)
			{
				if (A_3 >= 1 && A_3 <= hi2.g7() && hi2.hd())
				{
					if (hi2.fi())
					{
						string a_2 = i3.o() + "\\globalCorr.dat";
						double A_8 = 0.0;
						double A_9 = 0.0;
						bu(a_2, ref A_10, ref A_11, ref A_8, ref A_9);
					}
					else
					{
						gb gb2 = hi2.eu(A_3).x;
						if (gb2 == null)
						{
							gb2 = A_1.br;
						}
						A_10 = gb2.c;
						A_11 = gb2.d;
					}
					double num3 = A_10 * 0.699999988079071;
					double num4 = A_11 * 1.2999999523162842;
					gc gc2 = hi2.eu(A_3);
					if (gc2.af(a_))
					{
						double num5 = gc2.ai() * (1.0 - gc2.av() / 100.0);
						double num6 = gc2.ai() * (1.0 + gc2.av() / 100.0);
						if (jf.d(num5, num3) || jf.b(num6, num4))
						{
							SystemSounds.Exclamation.Play();
							string A_12 = "RecipeDvsCorrelationErrorFmt3";
							if (!global::fe.b(ref A_0, string.Format(hu.a(ref A_12), A_3, bu(hg.o.a, ca(), num3, global::e.a().DisplaySignificantDigits, new h4(h4.a.b), 0), bu(hg.o.a, ca(), num4, global::e.a().DisplaySignificantDigits, new h4(h4.a.b), 0)), "ErrorTitle", "Yes", "No", A_4))
							{
								A_12 = "FilmstackDVsCorrelationErrorFmt1";
								A_2 = string.Format(hu.a(ref A_12), A_3.ToString());
								return false;
							}
							double num7 = ((!jf.b(num3, num5)) ? num5 : num3);
							double num8 = ((!jf.d(num4, num6)) ? num6 : num4);
							double num9 = (num8 + num7) / 2.0;
							gc2.af(this.m_bx, this.m_by, num9);
							gc2.ak((1.0 - num7 / num9) * 100.0 - 0.009999999776482582 - 1.0 / num9);
							b5(A_0: false);
							A_5 = true;
						}
					}
					gc2 = null;
				}
			}
			hi2 = null;
			return true;
		}
	}

	public void bu(fz A_0, Point A_1, ref bool A_2)
	{
		if (!c9() && Operators.CompareString(ci(), "DefaultRecipe", TextCompare: false) != 0)
		{
			string A_3 = "RecipeUnsavedPromptFmt3";
			if (!global::fe.b(ref A_0, string.Format(hu.a(ref A_3), Strings.LCase("Recipe"), "\r\n", Strings.LCase("Recipe")), "RecipeLoadTitle", "OKString", "CancelString", A_1))
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

	public void bu(fz A_0, Point A_1, string A_2, hf A_3, bool A_4, bool A_5, global::r.d A_6, bool A_7, eo.a A_8)
	{
		string A_9 = "";
		bool A_10 = default(bool);
		int A_11 = default(int);
		bool A_12 = default(bool);
		bu(A_0, A_1, A_2, A_3: true, ref A_10, ref A_9, ref A_11, ref A_12, A_3, A_4, A_5, A_8);
		if (!A_12)
		{
			global::fe.b(A_0, A_9, A_1);
		}
		if (A_10)
		{
			this.m_bv = DateTime.Now.ToOADate();
			this.m_bu = A_2;
			if (A_6 != null)
			{
				bv(A_6, A_7);
			}
		}
	}

	public void ej()
	{
		this.m_dc = -1;
		this.m_dd = -1;
	}

	public void bu(fz A_0, Point A_1, bool A_2)
	{
		checked
		{
			foreach (hi item in bq)
			{
				double num = item.go();
				if (A_2 && !jf.e(num, this.m_dc) && num < 50.0)
				{
					this.m_dc = (int)Math.Round(num);
					string A_3 = "RecipeIterationsWarningFmt3";
					global::fe.b(ref A_0, string.Format(hu.a(ref A_3), br, num.ToString(), 50), ref A_1);
				}
				else if (!A_2 && !jf.e(num, this.m_dd) && num < 50.0)
				{
					this.m_dd = (int)Math.Round(num);
					string A_3 = "RecipeIterationsWarningFmt3";
					global::fe.b(ref A_0, string.Format(hu.a(ref A_3), br, num.ToString(), 50.ToString()), ref A_1);
				}
				_ = null;
			}
		}
	}

	public void bu(fz A_0, Point A_1, string A_2, bool A_3, ref bool A_4, ref string A_5, ref int A_6, ref bool A_7, hf A_8, bool A_9, bool A_10, eo.a A_11)
	{
		bool a_ = this.m_cu.ax(A_11);
		eo.b a_2 = this.m_cu.at(A_11, A_10);
		checked
		{
			int A_14 = default(int);
			foreach (hi item in bq)
			{
				hi hi3 = item;
				if (!b5())
				{
					if ((!hi3.d6(A_11) && !hi3.d7(A_11)) || !hi3.d8(A_11) || (A_9 && A_10))
					{
						double num = hi3.gs();
						if (num < 0.949999988079071)
						{
							string A_12 = "RecipeInvalidGOFTargetFmt3";
							global::fe.b(ref A_0, string.Format(hu.a(ref A_12), br, num.ToString(), 0.95f.ToString()), ref A_1);
						}
						if (A_9)
						{
							bu(A_0, A_1, A_10);
						}
					}
					if (hi3.hd() && (hi3.fi() || !A_3))
					{
						A_7 = bu(A_0, item, ref A_5, ref A_6, A_1, ref A_4, A_11, A_10);
					}
					else
					{
						A_7 = true;
					}
					int A_13 = 0;
					if (bu(A_11, A_10, ref A_13))
					{
						string A_12 = "RecipeInvalidDNUDConstraint";
						global::fe.b(ref A_0, hu.a(ref A_12), ref A_1);
					}
					if (item.hq())
					{
						global::fe.b(ref A_0, "Error reading one of the layer stack files", ref A_1);
					}
					else if (item.d5(ref A_14))
					{
						string A_12 = "RecipeInvalidNumLayersExceededFmt2";
						global::fe.b(ref A_0, string.Format(hu.a(ref A_12), A_14.ToString(), 100.ToString()), ref A_1);
					}
					if (A_9 && !A_10)
					{
						A_13 = hi3.g7();
						for (int num2 = 1; num2 <= A_13; num2++)
						{
							gc gc2 = hi3.eu(num2);
							if ((gc2.ah(a_) || gc2.aj(a_)) && !gc2.af(a_2) && gc2.ai() < (double)jf.a(2000000f) && gc2.ai() != 0.0)
							{
								string A_12 = "RecipeNKWithoutDWarningFmt";
								global::fe.b(ref A_0, string.Format(hu.a(ref A_12), br), ref A_1);
							}
							gc2 = null;
						}
						int num3 = hi3.g7();
						for (int num4 = 1; num4 <= num3; num4++)
						{
							gc gc3 = hi3.eu(num4);
							double num5 = gc3.ai() * (1.0 + 0.01 * gc3.av());
							if (gc3.af(a_2) && num5 >= (double)dx() && this.m_cu.az() > dx())
							{
								string text = string.Empty;
								string text2 = string.Empty;
								if (ca().e() != h4.a.c)
								{
									text = " (" + bu(1, dx(), new h4(h4.a.c), 5) + " µm)";
									text2 = " (" + bu(1, num5, new h4(h4.a.c), 5) + " µm)";
								}
								string A_12 = "RecipeSmoothingWarningFmt3";
								global::fe.b(ref A_0, string.Format(hu.a(ref A_12), br, bu(hg.o.a, ca(), dx(), 5, new h4(h4.a.b), 0) + text, bu(hg.o.a, ca(), num5, 5, new h4(h4.a.b), 0) + text2), ref A_1);
								break;
							}
							gc3 = null;
						}
					}
				}
				else
				{
					A_7 = true;
				}
				hi3 = null;
			}
		}
	}

	private bool b1()
	{
		return false;
	}

	public void bu(ref string A_0, ref string A_1, ref string A_2)
	{
		A_1 = "";
		A_2 = "";
		int num = 1;
		string text = Strings.Trim(A_0);
		checked
		{
			int num2;
			int num3 = default(int);
			do
			{
				num2 = Strings.InStr(num, text, "\\");
				if (num2 != 0)
				{
					num++;
					num3 = num2;
				}
			}
			while (num2 != 0);
			if (num3 > 0)
			{
				A_1 = Strings.Left(A_0, num3);
			}
			int num4 = ((Strings.InStr(num, text, ".") == 0) ? (Strings.Len(text) - (num - 1)) : (Strings.InStrRev(text, ".") - (num - 1) - 1));
			if (num4 >= 1)
			{
				A_2 = Strings.Mid(A_0, num, num4);
			}
		}
	}

	public static string bv(ref string A_0)
	{
		string result = A_0;
		int num = Strings.InStr(1, A_0, "(");
		checked
		{
			if (num != 0)
			{
				num++;
				int num2 = Strings.InStr(num, A_0, "mm", CompareMethod.Text);
				if (num2 != 0)
				{
					result = Strings.Mid(A_0, num, num2 - num);
				}
			}
			return result;
		}
	}

	public static string bu(string A_0, int A_1 = 0, int A_2 = 0, bool A_3 = false)
	{
		switch (Strings.UCase(A_0))
		{
		case "0":
		case null:
		case "":
		case "FALSE":
		case "NO":
			return bv("FALSE", A_1, A_2, A_3);
		default:
			return bv("TRUE", A_1, A_2, A_3);
		}
	}

	public static short b1(string A_0)
	{
		string text = Strings.UCase(A_0);
		uint num = jo.a(text);
		if (num <= 1105628090)
		{
			if (num <= 873244444)
			{
				if (num != 348981803)
				{
					if (num == 873244444 && Operators.CompareString(text, "1", TextCompare: false) == 0)
					{
						goto IL_0124;
					}
				}
				else if (Operators.CompareString(text, "-1", TextCompare: false) == 0)
				{
					goto IL_0124;
				}
			}
			else if (num != 890022063)
			{
				if (num == 1105628090 && Operators.CompareString(text, "NO", TextCompare: false) == 0)
				{
					goto IL_0128;
				}
			}
			else if (Operators.CompareString(text, "0", TextCompare: false) == 0)
			{
				goto IL_0128;
			}
		}
		else if (num <= 2166136261u)
		{
			if (num != 1343949093)
			{
				if (num == 2166136261u && Operators.CompareString(text, "", TextCompare: false) == 0)
				{
					goto IL_0128;
				}
			}
			else if (Operators.CompareString(text, "TRUE", TextCompare: false) == 0)
			{
				goto IL_0124;
			}
		}
		else if (num != 2471879920u)
		{
			if (num != 3708558887u)
			{
				if (num == 3998840952u && Operators.CompareString(text, "FALSE", TextCompare: false) == 0)
				{
					goto IL_0128;
				}
			}
			else if (Operators.CompareString(text, "X", TextCompare: false) == 0)
			{
				goto IL_0124;
			}
		}
		else if (Operators.CompareString(text, "YES", TextCompare: false) == 0)
		{
			goto IL_0124;
		}
		return 0;
		IL_0124:
		return 1;
		IL_0128:
		return 0;
	}

	public static bool b0(string A_0)
	{
		string text = Strings.UCase(A_0);
		uint num = jo.a(text);
		if (num <= 1105628090)
		{
			if (num <= 873244444)
			{
				if (num != 348981803)
				{
					if (num == 873244444 && Operators.CompareString(text, "1", TextCompare: false) == 0)
					{
						goto IL_0124;
					}
				}
				else if (Operators.CompareString(text, "-1", TextCompare: false) == 0)
				{
					goto IL_0124;
				}
			}
			else if (num != 890022063)
			{
				if (num == 1105628090 && Operators.CompareString(text, "NO", TextCompare: false) == 0)
				{
					goto IL_0128;
				}
			}
			else if (Operators.CompareString(text, "0", TextCompare: false) == 0)
			{
				goto IL_0128;
			}
		}
		else if (num <= 2166136261u)
		{
			if (num != 1343949093)
			{
				if (num == 2166136261u && Operators.CompareString(text, "", TextCompare: false) == 0)
				{
					goto IL_0128;
				}
			}
			else if (Operators.CompareString(text, "TRUE", TextCompare: false) == 0)
			{
				goto IL_0124;
			}
		}
		else if (num != 2471879920u)
		{
			if (num != 3708558887u)
			{
				if (num == 3998840952u && Operators.CompareString(text, "FALSE", TextCompare: false) == 0)
				{
					goto IL_0128;
				}
			}
			else if (Operators.CompareString(text, "X", TextCompare: false) == 0)
			{
				goto IL_0124;
			}
		}
		else if (Operators.CompareString(text, "YES", TextCompare: false) == 0)
		{
			goto IL_0124;
		}
		return false;
		IL_0124:
		return true;
		IL_0128:
		return false;
	}

	public static string bv(bool A_0)
	{
		if (A_0)
		{
			return " 1";
		}
		return " 0";
	}

	public void bu(ref bool A_0)
	{
		this.m_a = A_0;
	}

	public bool bz(eo.a A_0)
	{
		bool result = false;
		hi hi2 = ed();
		bool num = hi2.d7(A_0) && hi2.d8(A_0);
		hi2 = null;
		eo eo2 = this.m_cu;
		if (((num && eo2.av(A_0)) || eo2.aw(A_0)) && !b5())
		{
			result = true;
		}
		eo2 = null;
		return result;
	}

	public string bu(ref string A_0, [Optional][DefaultParameterValue(0)] ref int A_1, [Optional][DefaultParameterValue(0)] ref int A_2, [Optional][DefaultParameterValue(false)] ref bool A_3)
	{
		switch (A_0)
		{
		case "0":
		case "FALSE":
		case "False":
			return bv(" ", A_1, A_2);
		default:
			return bv("X", A_1, A_2, A_3);
		}
	}

	public static string bz(string A_0)
	{
		string result = string.Empty;
		if (!string.IsNullOrEmpty(A_0) && A_0.Contains("Generic, n="))
		{
			if (float.TryParse(A_0.Substring(Strings.Len("Generic, n=")), NumberStyles.Float, CultureInfo.InvariantCulture, out var result2))
			{
				result = A_0.Substring(0, Strings.Len("Generic, n=")) + result2;
			}
		}
		else
		{
			result = A_0;
		}
		return result;
	}

	public static string by(string A_0)
	{
		string result = string.Empty;
		if (!string.IsNullOrEmpty(A_0) && A_0.Contains("Generic, n="))
		{
			if (float.TryParse(A_0.Substring(Strings.Len("Generic, n=")), out var result2))
			{
				result = A_0.Substring(0, Strings.Len("Generic, n=")) + result2.ToString(CultureInfo.InvariantCulture);
			}
		}
		else
		{
			result = A_0;
		}
		return result;
	}

	public static string b0()
	{
		return bv() + "\\";
	}

	public static string bz()
	{
		string text = b0();
		return text.Substring(0, checked(text.Length - 1));
	}

	public static bool by()
	{
		string A_ = new string(' ', 16);
		bu(GetUserDefaultLCID(), 4100, ref A_, Strings.Len(A_));
		A_ = bu(ref A_);
		if (Conversions.ToDouble(A_) != 1252.0)
		{
			return false;
		}
		return true;
	}

	public static string bu(ref string A_0)
	{
		int num = Strings.InStr(A_0, "\0");
		return Strings.Left(A_0, checked(num - 1));
	}

	public void ci(string A_0)
	{
		bv(A_0, "\\");
		bv(A_0, "/");
		bv(A_0, ":");
		bv(A_0, "*");
		bv(A_0, "?");
		bv(A_0, "\"");
		bv(A_0, ">");
		bv(A_0, "<");
		bv(A_0, "|");
	}

	public void bv(string A_0, string A_1)
	{
		int num;
		do
		{
			num = Strings.InStr(A_0, A_1);
			if (num != 0)
			{
				A_0 = checked(Strings.Left(A_0, num - 1) + "~" + Strings.Mid(A_0, num + 1));
			}
		}
		while (num != 0);
	}

	public static string bu(int A_0, double A_1, h4 A_2, short A_3)
	{
		return bu(A_0, A_1, A_2, A_3, A_4: false);
	}

	public static string bu(int A_0, double A_1, h4 A_2)
	{
		return bu(A_0, A_1, A_2, 0, A_4: true);
	}

	public static string bu(int A_0, double A_1, h4 A_2, short A_3, bool A_4)
	{
		double num = h4.e(A_0, A_1, A_2, A_3, new h4(h4.a.b), A_4, 0);
		string text = ((!A_4) ? "0.#########" : "0.#####");
		return num.ToString(text).TrimEnd(Conversions.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator));
	}

	public static string bu(bool A_0)
	{
		if (A_0)
		{
			return "\\f1 s\\f3 ";
		}
		return "Sigma";
	}

	public static string bu(Collection<float[]> A_0, int A_1, o A_2, h4 A_3, short A_4, string A_5, bool A_6)
	{
		if (A_0 != null && A_0.Count > 0 && A_1 <= A_0[0].GetUpperBound(0))
		{
			float a_ = A_0[0][A_1];
			float a_2 = ((A_0.Count <= 1) ? 0f : A_0[1][A_1]);
			return bu(a_, a_2, A_2, A_3, A_4, A_5, A_6);
		}
		return string.Empty;
	}

	public static string bu(Collection<float> A_0, o A_1, h4 A_2, short A_3, string A_4, bool A_5)
	{
		if (A_0 != null && A_0.Count > 0)
		{
			float a_ = A_0[0];
			float a_2 = ((A_0.Count <= 1) ? 0f : A_0[1]);
			return bu(a_, a_2, A_1, A_2, A_3, A_4, A_5);
		}
		return string.Empty;
	}

	public static string bu(float A_0, float A_1, o A_2, h4 A_3, short A_4, string A_5, bool A_6)
	{
		string text = string.Empty;
		string text2 = string.Empty;
		string text3 = string.Empty;
		if (A_2 != hg.o.a)
		{
			text3 = "###0.";
			for (int num = 1; num <= A_4; num = checked(num + 1))
			{
				text3 += "0";
			}
		}
		if (A_0 > 1E-06f)
		{
			text += " ± ";
			text = ((A_2 != hg.o.a) ? (text + (3f * A_0).ToString(text3)) : (text + bu(A_2, A_3, 3f * A_0, A_4, new h4(h4.a.b), 0)));
			text = text + " (±3" + bu(A_6) + ")";
		}
		if (A_1 > 1E-06f)
		{
			text2 = text2 + A_5 + "± ";
			text2 = ((A_2 != hg.o.a) ? (text2 + (3f * A_1).ToString(text3)) : (text2 + bu(A_2, A_3, 3f * A_1, A_4, new h4(h4.a.b), 0)));
			text2 = text2 + " (±3" + bu(A_6) + ") )";
		}
		return text + text2;
	}

	public static string bu(o A_0, h4 A_1, double A_2, short A_3, h4 A_4, short A_5 = 0, bool A_6 = true)
	{
		string text = "0.";
		if (A_0 <= (o)0)
		{
			return "Error";
		}
		double num = ((A_0 != hg.o.a) ? A_2 : h4.e((int)A_0, A_2, A_1, A_3, A_4, A_5: false, A_5));
		checked
		{
			if (num != 0.0)
			{
				int num2 = (int)Math.Round((double)A_3 - Conversion.Int(Math.Log10(Math.Abs(num))) - 1.0);
				for (int num3 = 1; num3 <= num2; num3++)
				{
					text += "0";
				}
			}
			else
			{
				text = "0.000";
			}
			switch (A_0)
			{
			case hg.o.a:
			{
				string text3 = h4.e(A_1) + h4.e(A_1, A_1: false, A_2: true);
				int num4 = h4.i(A_1);
				num4 += A_5;
				if (Operators.CompareString(Strings.Mid(text, Strings.Len(text), 1), ".", TextCompare: false) == 0)
				{
					text = Strings.Mid(text, 1, Strings.Len(text) - 1);
				}
				text = Strings.Mid(text, 1, 2 + num4);
				if (A_6)
				{
					text3 = h4.e(A_1) + h4.e(A_1, A_1: false, A_2: true);
					num4 = h4.i(A_1);
					return num.ToString(text) + text3;
				}
				return num.ToString(text);
			}
			case hg.o.d:
			{
				string text2 = num.ToString("0.#");
				if (Operators.CompareString(Strings.Mid(text2, Strings.Len(text2), 1), ".", TextCompare: false) == 0)
				{
					text2 = Strings.Mid(text2, 1, Strings.Len(text2) - 1);
				}
				return text2 + " nm";
			}
			case hg.o.b:
				return num.ToString(text) + " %";
			default:
				return num.ToString(text);
			}
		}
	}

	public static string bu(o A_0, h4 A_1, double A_2, Collection<float[]> A_3, Collection<float[]> A_4, int A_5, short A_6, string A_7, short A_8 = 0, bool A_9 = false)
	{
		if (A_3 != null && A_3.Count > 0 && A_5 <= A_3[0].GetUpperBound(0))
		{
			double num = A_2;
			float a_ = A_3[0][A_5];
			float a_2 = ((A_3.Count <= 1 || A_3[1] == null) ? 0f : A_3[1][A_5]);
			num = A_4[0][A_5];
			return bu(A_0, A_1, num, a_, a_2, A_6, A_7, A_8, A_8: true, A_9);
		}
		return bu(A_0, A_1, A_2, A_6, new h4(h4.a.b), A_8);
	}

	private static string bu(double A_0, int A_1, ref int A_2)
	{
		checked
		{
			string text;
			if (A_0 != 0.0)
			{
				text = "0.";
				A_2 = (int)Math.Round((double)A_1 - Conversion.Int(Math.Log10(Math.Abs(A_0))) - 1.0);
				int num = A_2;
				for (int num2 = 1; num2 <= num; num2++)
				{
					text += "0";
				}
			}
			else
			{
				A_2 = 3;
				text = "0.000";
			}
			if (text.EndsWith("."))
			{
				text = text.TrimEnd('.');
			}
			return text;
		}
	}

	public static string bu(o A_0, h4 A_1, double A_2, float A_3, float A_4, short A_5, string A_6, short A_7 = 0, bool A_8 = true, bool A_9 = false)
	{
		string text = string.Empty;
		string text2 = null;
		if (A_0 <= (o)0)
		{
			return "Error";
		}
		checked
		{
			double a_;
			double num;
			double num2;
			if (A_0 == hg.o.a)
			{
				a_ = h4.e(unchecked((int)A_0), A_2, A_1, A_5, new h4(h4.a.b), A_5: false, A_7);
				num = h4.e(unchecked((int)A_0), 3f * A_3, A_1, 2, new h4(h4.a.b), A_5: true, (short)unchecked(A_7 + 1));
				num2 = h4.e(unchecked((int)A_0), 3f * A_4, A_1, 2, new h4(h4.a.b), A_5: true, (short)unchecked(A_7 + 1));
			}
			else
			{
				a_ = A_2;
				num = 3f * A_3;
				num2 = 3f * A_4;
			}
			int A_10 = default(int);
			string text3 = bu(a_, A_5, ref A_10);
			switch (A_0)
			{
			case hg.o.a:
			{
				text = text + " " + h4.e(A_1, false, false);
				int num3 = h4.i(A_1);
				num3 += A_7;
				text3 = Strings.Mid(text3, 1, 2 + num3);
				string text4;
				if (num > 9.999999974752427E-07)
				{
					int num4 = num3 + 1;
					text2 = bu(num, 3, ref A_10);
					if (text2.Length > 2 + num4)
					{
						text2 = text2.Substring(0, 2 + num4);
					}
					text4 = " ± " + num.ToString(text2);
				}
				else
				{
					text4 = string.Empty;
				}
				string text5;
				if (num2 > 9.999999974752427E-07)
				{
					int num4 = num3 + 1;
					text2 = bu(num2, 3, ref A_10);
					if (text2.Length > 2 + num4)
					{
						text2 = text2.Substring(0, 2 + num4);
					}
					text5 = A_6 + "± " + num2.ToString(text2);
				}
				else
				{
					text5 = string.Empty;
				}
				if (A_8)
				{
					text = " " + h4.e(A_1, false, false);
					if (string.IsNullOrEmpty(text4) && string.IsNullOrEmpty(text5))
					{
						return a_.ToString(text3) + text4 + text;
					}
					if (string.IsNullOrEmpty(text5))
					{
						return a_.ToString(text3) + text4 + text + " (±3" + bu(A_9) + ")";
					}
					return a_.ToString(text3) + text4 + text + " (±3" + bu(A_9) + ")" + text5 + text + " (±3" + bu(A_9) + "))";
				}
				return a_.ToString(text3) + text4 + text5;
			}
			case hg.o.d:
			{
				string text6 = a_.ToString("0.#");
				string text7 = num.ToString("0.#");
				if (Operators.CompareString(Strings.Mid(text6, Strings.Len(text6), 1), ".", TextCompare: false) == 0)
				{
					text6 = Strings.Mid(text6, 1, Strings.Len(text6) - 1);
				}
				return text6 + " ± " + text7 + " nm";
			}
			default:
			{
				if (A_8 && A_0 == hg.o.b)
				{
					text = " %";
				}
				string text4;
				if (num > 9.999999974752427E-07)
				{
					text2 = bu(num, (short)unchecked(A_5 + 1), ref A_10);
					text4 = " ± " + num.ToString(text2);
				}
				else
				{
					text4 = string.Empty;
				}
				string text5;
				if (num2 > 9.999999974752427E-07)
				{
					text2 = bu(num2, (short)unchecked(A_5 + 1), ref A_10);
					text5 = A_6 + "± " + num2.ToString(text3);
				}
				else
				{
					text5 = string.Empty;
				}
				if (Operators.CompareString(text5, string.Empty, TextCompare: false) == 0)
				{
					return a_.ToString(text3) + text4 + text + " (±3" + bu(A_9) + ")";
				}
				return a_.ToString(text3) + text4 + text + text5 + text + " (±3" + bu(A_9) + "))";
			}
			}
		}
	}

	public bool bu(ref float[] A_0, ref int[] A_1, eo.a A_2, bool A_3)
	{
		bool result = false;
		eo.b a_ = this.m_cu.at(A_2, A_3);
		int num = dz();
		checked
		{
			for (int num2 = 1; num2 <= num; num2++)
			{
				hi hi2 = b3(num2);
				A_1 = new int[hi2.g7() + 1 + 1];
				int num3 = hi2.g7();
				for (int num4 = 1; num4 <= num3; num4++)
				{
					gc gc2 = hi2.eu(num4);
					if (gc2.af(a_))
					{
						if ((double)A_0[num4] < gc2.al())
						{
							A_1[num4] = -2;
							result = true;
						}
						else if ((double)A_0[num4] > gc2.am())
						{
							A_1[num4] = 1;
							result = true;
						}
					}
				}
			}
			return result;
		}
	}

	public bool bu(eo.a A_0, bool A_1, ref int A_2)
	{
		hi hi2 = ed();
		int num = hi2.g6();
		checked
		{
			for (A_2 = 1; A_2 <= num; A_2++)
			{
				if (gd.l(hi2.et(A_2).ag()))
				{
					continue;
				}
				int a_ = A_2;
				string A_3 = null;
				string A_4 = null;
				if (bv(a_, A_0, A_1, ref A_3, ref A_4))
				{
					int a_2 = A_2;
					A_4 = null;
					A_3 = null;
					if (bw(a_2, A_0, A_1, ref A_4, ref A_3))
					{
						int a_3 = A_2;
						A_3 = null;
						A_4 = null;
						if (bu(a_3, A_0, A_1, ref A_3, ref A_4))
						{
							continue;
						}
					}
				}
				return true;
			}
			hi2 = null;
			return false;
		}
	}

	public bool bu(int A_0, eo.a A_1, bool A_2, ref string A_3, ref string A_4)
	{
		bool a_ = dh().az(A_1);
		eo.b a_2 = dh().at(A_1, A_2);
		gc gc2 = bu(A_0, 0);
		double num;
		double a_3;
		if (cp())
		{
			num = 100.0;
			if (gc2.af(a_2) && !gc2.ap(a_))
			{
				num = ((!jf.a(gc2.av(), 100f)) ? (num * (1.0 - 0.01 * gc2.av())) : 0.0);
			}
			a_3 = gc2.aj() * 100.0;
			A_4 = "%";
			A_3 = num.ToString("0.00");
			if (Conversions.ToDouble(A_3) > num)
			{
				A_3 = (num - 0.01).ToString("0.00");
			}
		}
		else
		{
			double num2 = ca().e(1, gc2.ai());
			num = num2;
			if (gc2.af(a_2) && !gc2.ap(a_))
			{
				num = ((!jf.a(gc2.av(), 100f)) ? (num * (1.0 - 0.01 * gc2.av())) : 0.0);
			}
			a_3 = gc2.aj() * num2;
			A_4 = ca().l();
			A_3 = ca().e(1, num).ToString();
			if (Conversions.ToDouble(A_3) > num)
			{
				A_3 = ca().e(1, num - Math.Pow(10.0, checked(-ca().k()))).ToString();
			}
		}
		gc2 = null;
		return jf.c(a_3, num);
	}

	public bool bv(int A_0, eo.a A_1, bool A_2, ref string A_3, ref string A_4)
	{
		bool a_ = dh().az(A_1);
		eo.b a_2 = dh().at(A_1, A_2);
		gc gc2 = bu(A_0, 0);
		ca().e(1, gc2.ai());
		if (gc2.aj() == 0.0 || dh().aw(A_1) || gc2.ai() == 0.0)
		{
			return true;
		}
		if (gc2.af(a_2) && !gc2.ap(a_) && ((!co() && jf.a(gc2.av(), 100f)) || (!co() && cp() && jf.a(gc2.av() + gc2.aj() * 100.0, 100f))))
		{
			return true;
		}
		double num;
		if (gc2.af(a_2))
		{
			if (gc2.ap(a_))
			{
				num = gc2.ai() * gc2.aj();
			}
			else
			{
				double A_5 = gc2.av();
				double A_6 = gc2.aj();
				gc2.ag(co(), gc2.ai(), ref A_5);
				gc2.af(cp(), gc2.ai(), ref A_6);
				num = ((!cp()) ? (gc2.ai() * A_6 / (1.0 - A_5 * 0.01)) : (gc2.ai() * (A_6 + A_5 * 0.01)));
			}
		}
		else
		{
			num = gc2.ai() * gc2.aj();
		}
		A_4 = ca().l();
		A_3 = ca().e(1, num).ToString();
		if (Conversions.ToDouble(A_3) < num)
		{
			A_3 = ca().e(1, num + Math.Pow(10.0, checked(-ca().k()))).ToString();
		}
		return jf.a(gc2.ai(), num);
	}

	public bool bw(int A_0, eo.a A_1, bool A_2, ref string A_3, ref string A_4)
	{
		gc gc2 = bu(A_0, 0);
		if (!gc2.af(dh().at(A_1, A_2)) || gc2.ap(dh().az(A_1)) || gc2.aj() == 0.0 || dh().aw(A_1))
		{
			return true;
		}
		double a_;
		double num;
		if (co())
		{
			a_ = ((gc2.ai() != 0.0) ? ca().e(1, gc2.av() * gc2.ai() * 0.01) : ca().e(1, gc2.av()));
			num = (1.0 - gc2.aj()) * gc2.ai();
			A_4 = ca().l();
			A_3 = ca().e(1, num).ToString();
			if (Conversions.ToDouble(A_3) > num)
			{
				A_3 = ca().e(1, num - Math.Pow(10.0, checked(-ca().k()))).ToString();
			}
		}
		else
		{
			a_ = gc2.av();
			num = (1.0 - gc2.aj()) * 100.0;
			A_4 = "%";
			A_3 = num.ToString("0.00");
			if (Conversions.ToDouble(A_3) > num)
			{
				A_3 = (num - 0.01).ToString("0.00");
			}
		}
		gc2 = null;
		return jf.c(a_, num);
	}

	~hg()
	{
		bq = null;
		base.Finalize();
	}

	public hg(eo A_0, j A_1)
	{
		bu(hg.h.a);
		bw((int)A_1);
		bu(A_0);
	}

	private void bu(eo A_0)
	{
		bq = new Collection();
		bm = true;
		bu(new h4(h4.a.b));
		this.m_cv = 100000000f;
		this.m_cs = by();
		this.m_c2 = new global::h(A_0);
		this.m_cu = A_0;
		this.m_db = null;
		this.m_de = hg.b.c;
		this.m_df = Guid.Empty;
		ej();
	}

	public ArrayList ek()
	{
		ArrayList arrayList = new ArrayList();
		int num = dz();
		checked
		{
			for (int num2 = 1; num2 <= num; num2++)
			{
				hi hi2 = (hi)bq[num2];
				int num3 = hi2.hh() - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					string text = hi2.et(num4).ag();
					if (!gd.l(text) && jb.y(text) && arrayList.BinarySearch(text, new CaseInsensitiveComparer()) < 0)
					{
						arrayList.Add(text);
					}
				}
			}
			return arrayList;
		}
	}

	public Collection<string> el()
	{
		return null;
	}

	public ArrayList em()
	{
		ArrayList arrayList = new ArrayList();
		int num = dz();
		checked
		{
			for (int num2 = 1; num2 <= num; num2++)
			{
				hi hi2 = (hi)bq[num2];
				int num3 = hi2.hh() - 1;
				for (int num4 = 1; num4 <= num3; num4++)
				{
					string text = hi2.et(num4).ag();
					if (gd.l(text))
					{
						text = text.Substring("Stack: ".Length);
						text = ((num4 == hi2.hh() - 1) ? ((!File.Exists(gd.i() + text + ".fitss")) ? (text + ".fibss") : (text + ".fitss")) : ((!File.Exists(gd.i() + text + ".fitls")) ? (text + ".fibls") : (text + ".fitls")));
						arrayList.Add(text);
					}
				}
			}
			return arrayList;
		}
	}

	private void bu(Collection<string> A_0, ArrayList A_1, Collection<a5> A_2)
	{
		checked
		{
			foreach (string item in A_0)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(item);
				int num = A_1.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (Operators.CompareString(A_1[num2].ToString(), "<Graded Interface>", TextCompare: false) == 0)
					{
						continue;
					}
					FileInfo[] files = directoryInfo.GetFiles(jb.x(A_1[num2].ToString()) + ".*");
					foreach (FileInfo fileInfo in files)
					{
						if (jb.d(Path.GetExtension(fileInfo.Name)))
						{
							global::a5.d(fileInfo, A_2);
						}
						if (jb.m(fileInfo.Name))
						{
							jc A_3 = null;
							ArrayList arrayList = new ArrayList();
							string fullName = fileInfo.FullName;
							short A_4 = 0;
							string A_5 = null;
							string A_6 = null;
							int A_7 = 0;
							string A_8 = null;
							int A_9 = 0;
							jb.d[] A_10 = null;
							string[] A_11 = null;
							jb.b(fullName, A_1: false, ref A_3, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8, ref A_9, ref A_10, ref A_11);
							A_11 = A_3.b;
							foreach (string value in A_11)
							{
								arrayList.Add(value);
							}
							bu(A_0, arrayList, A_2);
						}
					}
				}
			}
		}
	}

	public void bu(fz A_0, string A_1, string A_2, ArrayList A_3, ArrayList A_4, Collection<string> A_5, string A_6)
	{
		Collection<a5> collection = new Collection<a5>();
		Collection<string> a_ = jb.k();
		global::a5.f(A_1, collection);
		bu(a_, A_3, collection);
		checked
		{
			if (A_4.Count > 0)
			{
				string text = string.Empty;
				int num = A_4.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					string text2 = A_4[num2].ToString();
					switch (Path.GetExtension(text2).ToLower())
					{
					case ".fibls":
						text = ".fibbl";
						break;
					case ".fitls":
						text = ".fibtl";
						break;
					case ".fibss":
						text = ".fibbs";
						break;
					case ".fitss":
						text = ".fibts";
						break;
					}
					string text3 = global::c.e().FileSystem.SpecialDirectories.Temp + "\\" + Path.GetFileNameWithoutExtension(text2) + text;
					gf.a(gd.i() + text2, text3);
					global::a5.d(new FileInfo(text3), collection);
					global::c.e().FileSystem.DeleteFile(text3);
				}
			}
			if (A_5 != null && A_5.Count > 0)
			{
				int num3 = A_5.Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					global::a5.d(new FileInfo(A_5[num4]), collection);
				}
			}
			if (A_6 != null)
			{
				global::a5.d(new FileInfo(A_6), collection);
			}
			global::a5.d(A_2, collection);
		}
	}

	public static void bu(fz A_0, string A_1, string A_2, bool A_3, ref bool A_4, bool A_5)
	{
		Collection<a5> collection = global::a5.d(A_1);
		string text = collection[0].d().ToLower();
		if (!A_3 && !text.EndsWith(".fitrp") && !text.EndsWith(".fitra"))
		{
			throw new Exception("First file in the collection must be a recipe file");
		}
		text = null;
		global::a5.d(collection, 0, 0, A_2);
		jb.a(collection, 1, checked(collection.Count - 1));
		bu(A_0, collection, jb.h(), A_3, ref A_4, A_5);
	}

	public static string bx(string A_0)
	{
		string left = Path.GetExtension(A_0).ToLower();
		if (Operators.CompareString(left, ".fibrp", TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, ".fibra", TextCompare: false) == 0)
			{
				return ".fitra";
			}
			throw new ax("Invalid argument in Recipe.UncombinedFileExt");
		}
		return ".fitrp";
	}

	private static void bu(fz A_0, Collection<a5> A_1, string A_2, bool A_3, ref bool A_4, bool A_5)
	{
		checked
		{
			int num = A_1.Count - 1;
			bool A_7 = default(bool);
			for (int num2 = 0; num2 <= num; num2++)
			{
				a5 a10 = A_1[num2];
				if (num2 > 0)
				{
					if (!gf.a(Path.GetExtension(a10.d())) && Operators.CompareString(Path.GetExtension(a10.d()), ".pat", TextCompare: false) != 0 && Operators.CompareString(Path.GetExtension(a10.d()), ".fibdi", TextCompare: false) != 0)
					{
						eb.b a_ = jb.ab(a10.d());
						string a_2 = A_2 + "\\" + Path.GetFileName(a10.d());
						string[] a_3 = jb.b(a_);
						Collection<string> A_6 = null;
						if (i3.a(a_2, a_3, ref A_6))
						{
							A_0.c(global::fz.b.a, "File '" + Path.GetFileName(a10.d()) + "' was not extracted when importing recipe '" + Path.GetFileName(A_1[0].d()) + "' because a file with the same name already exists in the duplicate path.");
							continue;
						}
					}
					else if (Operators.CompareString(Path.GetExtension(a10.d()), ".fibdi", TextCompare: false) == 0)
					{
						continue;
					}
				}
				if (!gf.a(Path.GetExtension(a10.d())))
				{
					if (Operators.CompareString(Path.GetExtension(a10.d()), ".fitrp", TextCompare: false) == 0)
					{
						a10.d();
					}
					if (File.Exists(a10.d()))
					{
						if (i3.a(a10.d(), A_1[num2]) && !A_5)
						{
							continue;
						}
						if (A_3)
						{
							File.Delete(a10.d());
							global::a5.d(A_1[num2]);
						}
						else
						{
							gf.a(A_1[num2], "ImportRecipeFileTitle", A_0, ref A_7);
							if (A_7)
							{
								continue;
							}
						}
					}
					else
					{
						global::a5.d(A_1[num2]);
					}
				}
				else
				{
					global::a5.d(A_1[num2]);
					string text = A_1[num2].d();
					gf.a(A_0, text, gd.i(), A_3: false, ref A_4);
					global::c.e().FileSystem.DeleteFile(text);
				}
				a10 = null;
			}
		}
	}

	public static void bu(fz A_0, g A_1, string A_2, string[] A_3, Point A_4, global::r.d.a.b A_5, j A_6)
	{
		string[] A_7 = null;
		bu(A_0, A_1, A_2, A_3, A_4: true, A_4, ref A_7, A_5, A_6);
	}

	public static void bu(fz A_0, g A_1, string A_2, string[] A_3, ref string[] A_4, global::r.d.a.b A_5, j A_6)
	{
		bu(A_0, A_1, A_2, A_3, A_4: false, default(Point), ref A_4, A_5, A_6);
	}

	private static void bu(fz A_0, g A_1, string A_2, string[] A_3, bool A_4, Point A_5, ref string[] A_6, global::r.d.a.b A_7, j A_8)
	{
		string empty = string.Empty;
		int num = 0;
		int upperBound = A_3.GetUpperBound(0);
		eo eo2 = new eo();
		eo2.at(global::eo.at());
		checked
		{
			A_6 = new string[upperBound + 1];
			int num2 = upperBound;
			for (num = 0; num <= num2; num++)
			{
				string A_9 = A_3[num];
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(A_9);
				string left = Path.GetExtension(A_9).ToLower();
				bool a_;
				if (A_1 == hg.g.b)
				{
					empty = A_2 + "\\" + fileNameWithoutExtension + ".rpe";
					a_ = false;
				}
				else if (Operators.CompareString(left, ".fitrp", TextCompare: false) == 0)
				{
					empty = A_2 + "\\" + fileNameWithoutExtension + ".fibrp";
					a_ = false;
				}
				else
				{
					if (Operators.CompareString(left, ".fitra", TextCompare: false) != 0)
					{
						throw new @as("Invalid recipe file name extension in Recipe.ExportRecipes");
					}
					empty = A_2 + "\\" + fileNameWithoutExtension + ".fibra";
					a_ = true;
				}
				if (File.Exists(empty))
				{
					string A_10 = "FileExportWarningMsgFmt";
					if (!global::fe.b(ref A_0, string.Format(hu.a(ref A_10), Path.GetFileName(empty)), "ExportRecipeFileTitle", "Yes", "No", A_5))
					{
						continue;
					}
					File.Delete(empty);
				}
				hg A_11 = new hg(eo2, A_8);
				if (bu(ref A_11, ref A_9, A_8, a_, null, A_7, A_0, A_7: false, default(Point), null, g2.b.a, A_11: true, null, A_13: false))
				{
					if (A_1 == hg.g.a)
					{
						string a_2 = null;
						A_11.bu(A_0, A_9, empty, A_11.ek(), A_11.em(), A_11.el(), a_2);
					}
					else
					{
						bu(A_11, empty);
					}
					A_6[num] = empty;
				}
			}
		}
	}

	public static void bu(string A_0, double A_1, double A_2, double A_3, double A_4)
	{
		using FileStream stream = new FileStream(A_0, FileMode.OpenOrCreate);
		using StreamWriter streamWriter = new StreamWriter(stream);
		streamWriter.WriteLine("GlobalCorrThickMin: " + A_1.ToString(CultureInfo.InvariantCulture));
		streamWriter.WriteLine("GlobalCorrThickMax: " + A_2.ToString(CultureInfo.InvariantCulture));
		streamWriter.WriteLine("GlobalCorrCoefA: " + A_3.ToString(CultureInfo.InvariantCulture));
		streamWriter.WriteLine("GlobalCorrCoefB: " + A_4.ToString(CultureInfo.InvariantCulture));
	}

	public static void bu(string A_0, ref double A_1, ref double A_2, ref double A_3, ref double A_4)
	{
		if (File.Exists(A_0))
		{
			using (FileStream stream = new FileStream(A_0, FileMode.Open))
			{
				using StreamReader streamReader = new StreamReader(stream);
				A_1 = Conversion.Val(Strings.Split(streamReader.ReadLine(), ":")[1]);
				A_2 = Conversion.Val(Strings.Split(streamReader.ReadLine(), ":")[1]);
				A_3 = Conversion.Val(Strings.Split(streamReader.ReadLine(), ":")[1]);
				A_4 = Conversion.Val(Strings.Split(streamReader.ReadLine(), ":")[1]);
				return;
			}
		}
		A_1 = 0.0;
		A_2 = 100000000.0;
		A_3 = 1.0;
		A_4 = 0.0;
	}

	[SpecialName]
	public static string bx()
	{
		return a6;
	}

	[SpecialName]
	public static void bw(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0) && A_0.Length > 0 && A_0.EndsWith("\\"))
		{
			A_0 = A_0.Substring(0, checked(A_0.Length - 1));
		}
		a6 = A_0;
	}

	public static string bw()
	{
		return i3.o() + "\\Recipes";
	}

	public static string bv()
	{
		return bv(a6);
	}

	public static string bu()
	{
		return bv((string)null) + "\\";
	}

	public static string bv(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0) && Directory.Exists(A_0))
		{
			return A_0;
		}
		return i3.m() + "\\Recipes";
	}

	public static void bu(eo A_0, ref string A_1, ref string A_2, ref string A_3, ref bool A_4)
	{
		StreamReader streamReader = null;
		string text = bu() + "StartupRecipeAR.txt";
		if (global::c.e().FileSystem.FileExists(text))
		{
			try
			{
				streamReader = new StreamReader(File.Open(text, FileMode.Open, FileAccess.Read, FileShare.Read));
				A_1 = bu() + streamReader.ReadLine();
				A_1 += ".fitra";
			}
			finally
			{
				streamReader.Close();
			}
		}
		text = bu() + "StartupRecipe.txt";
		if (global::c.e().FileSystem.FileExists(text))
		{
			try
			{
				streamReader = new StreamReader(File.Open(text, FileMode.Open, FileAccess.Read, FileShare.Read));
				A_2 = bu() + streamReader.ReadLine();
				A_2 += ".fitrp";
			}
			finally
			{
				streamReader.Close();
			}
		}
		if (A_0.a0(null))
		{
			A_4 = true;
			A_3 = A_1;
		}
		else
		{
			A_4 = false;
			A_3 = A_2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public static void bu(hg A_0, string A_1)
	{
		short[] array = null;
		string[] array2 = null;
		byte[] A_2 = null;
		short value = 1;
		short value2 = 1;
		short num = 1;
		short num2 = 0;
		checked
		{
			string[] array3 = new string[num - 1 + 1];
			string[] array4 = new string[num - 1 + 1];
			short[] array5 = new short[num - 1 + 1];
			if (num2 > 0)
			{
				array2 = new string[num2 - 1 + 1];
				array = new short[num2 - 1 + 1];
			}
			array3[0] = A_0.ee();
			array5[0] = 1;
			array4[0] = "Recipe";
			int num3 = Microsoft.VisualBasic.FileSystem.FreeFile();
			Microsoft.VisualBasic.FileSystem.FileOpen(num3, A_1, OpenMode.Binary);
			Microsoft.VisualBasic.FileSystem.FilePut(num3, value, -1L);
			Microsoft.VisualBasic.FileSystem.FilePut(num3, value2, -1L);
			int num4 = (int)Microsoft.VisualBasic.FileSystem.Seek(num3);
			int value3 = default(int);
			Microsoft.VisualBasic.FileSystem.FilePut(num3, value3, -1L);
			int num5 = (int)Microsoft.VisualBasic.FileSystem.Seek(num3);
			Microsoft.VisualBasic.FileSystem.FilePut(num3, value3, -1L);
			int value4 = (int)Microsoft.VisualBasic.FileSystem.Seek(num3);
			Microsoft.VisualBasic.FileSystem.FilePut(num3, num, -1L);
			short num6 = (short)(num - 1);
			for (short num7 = 0; num7 <= num6; num7 = (short)unchecked(num7 + 1))
			{
				int num8 = (int)Microsoft.VisualBasic.FileSystem.Seek(num3);
				value3 = 0;
				Microsoft.VisualBasic.FileSystem.FilePut(num3, value3, -1L);
				Microsoft.VisualBasic.FileSystem.FilePut(num3, array5[num7], -1L);
				value3 = Strings.Len(array4[num7]);
				Microsoft.VisualBasic.FileSystem.FilePut(num3, value3, -1L);
				Microsoft.VisualBasic.FileSystem.FilePut(num3, array4[num7], -1L);
				value3 = Strings.Len(array3[num7]);
				Microsoft.VisualBasic.FileSystem.FilePut(num3, value3, -1L);
				Microsoft.VisualBasic.FileSystem.FilePut(num3, array3[num7], -1L);
				value3 = (int)Microsoft.VisualBasic.FileSystem.Seek(num3);
				Microsoft.VisualBasic.FileSystem.FilePut(num3, value3, num8);
				Microsoft.VisualBasic.FileSystem.Seek(num3, value3);
			}
			int value5 = (int)Microsoft.VisualBasic.FileSystem.Seek(num3);
			Microsoft.VisualBasic.FileSystem.FilePut(num3, num2, -1L);
			short num9 = (short)(num2 - 1);
			for (short num7 = 0; num7 <= num9; num7 = (short)unchecked(num7 + 1))
			{
				int num8 = (int)Microsoft.VisualBasic.FileSystem.Seek(num3);
				value3 = 0;
				Microsoft.VisualBasic.FileSystem.FilePut(num3, value3, -1L);
				Microsoft.VisualBasic.FileSystem.FilePut(num3, array[num7], -1L);
				i3.a(array2[num7], ref A_2);
				value3 = Information.UBound(A_2) + 1;
				Microsoft.VisualBasic.FileSystem.FilePut(num3, value3, -1L);
				Microsoft.VisualBasic.FileSystem.FilePut(num3, A_2, -1L);
				value3 = (int)Microsoft.VisualBasic.FileSystem.Seek(num3);
				Microsoft.VisualBasic.FileSystem.FilePut(num3, value3, num8);
				Microsoft.VisualBasic.FileSystem.Seek(num3, value3);
			}
			Microsoft.VisualBasic.FileSystem.FilePut(num3, value4, num4);
			Microsoft.VisualBasic.FileSystem.FilePut(num3, value5, num5);
			Microsoft.VisualBasic.FileSystem.FileClose(num3);
		}
	}

	public void cj(string A_0)
	{
		this.m_bu = A_0;
		this.m_bv = DateTime.Now.ToOADate();
		bt = Guid.NewGuid().ToString();
		bm = false;
	}

	public static void bu(string A_0, string A_1, fz A_2, StreamWriter A_3, j A_4)
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(A_0);
		eo eo2 = new eo();
		eo2.at(global::eo.at());
		string text = A_1 + fileNameWithoutExtension + ".fitrp";
		FileInfo fileInfo = new FileInfo(A_0);
		bool flag = default(bool);
		if (File.Exists(text))
		{
			FileInfo fileInfo2 = new FileInfo(text);
			if (i3.a(fileInfo2.LastWriteTimeUtc, fileInfo.LastWriteTimeUtc))
			{
				flag = DateTime.Compare(fileInfo2.LastWriteTimeUtc, fileInfo.LastWriteTimeUtc) < 0;
			}
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			hg A_5 = new hg(eo2, A_4);
			if (bu(ref A_5, ref A_0, A_4, A_3: false, null, global::r.d.a.b.a, A_2, A_7: false, default(Point), null, g2.b.a, A_11: true, null, A_13: false))
			{
				A_5.ch(text);
				File.SetLastWriteTime(text, fileInfo.LastWriteTime);
				A_3.WriteLine(text);
			}
		}
	}

	public static void bu(string A_0, string A_1, bool A_2, fz A_3, Point A_4, ref int A_5, ref int A_6, ref int A_7, ref bool A_8, bool A_9)
	{
		string empty = string.Empty;
		string fileName = Path.GetFileName(A_0);
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(A_0);
		string extension = Path.GetExtension(A_0);
		eo eo2 = new eo();
		eo2.at(global::eo.at());
		string text = Path.Combine(A_1, fileName);
		checked
		{
			bool flag;
			if (!A_2 && Operators.CompareString(extension.ToLower(), ".rpe", TextCompare: false) != 0 && Operators.CompareString(extension.ToLower(), ".fibrp", TextCompare: false) != 0 && Operators.CompareString(extension.ToLower(), ".fibra", TextCompare: false) != 0 && File.Exists(text))
			{
				if (string.Compare(A_0, text, ignoreCase: true) == 0)
				{
					flag = false;
				}
				else
				{
					string empty2 = string.Empty;
					string A_10 = "RecipeFileReplaceWarningMsgFmt2";
					empty2 = string.Format(hu.a(ref A_10), fileNameWithoutExtension, Path.GetDirectoryName(A_1));
					flag = global::fe.b(ref A_3, empty2, "ImportRecipeFileTitle", "Yes", "No", A_4);
					if (!flag)
					{
						A_5++;
					}
				}
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				return;
			}
			_ = string.Empty;
			if (Operators.CompareString(extension.ToLower(), ".rpe", TextCompare: false) == 0)
			{
				string text2 = Path.Combine(A_1, fileNameWithoutExtension + ".fitrp");
				if (!A_2 && File.Exists(text2))
				{
					string A_10 = "RecipeFileReplaceWarningMsgFmt2";
					empty = string.Format(hu.a(ref A_10), fileNameWithoutExtension, Path.GetDirectoryName(A_1));
					if (!global::fe.b(ref A_3, empty, "ImportRecipeFileTitle", "Yes", "No", A_4))
					{
						A_5++;
						return;
					}
					File.Delete(text2);
				}
				hg A_11 = new hg(eo2, b4());
				if (bu(ref A_11, ref A_0, b4(), A_3: false, null, global::r.d.a.b.a, A_3, A_7: false, default(Point), null, g2.b.a, A_11: true, null, A_13: false))
				{
					A_11.ch(text2);
					A_6++;
				}
			}
			else if (Operators.CompareString(extension.ToLower(), ".fibrp", TextCompare: false) == 0 || Operators.CompareString(extension.ToLower(), ".fibra", TextCompare: false) == 0)
			{
				string text2 = Path.Combine(A_1, fileNameWithoutExtension + bx(extension));
				if (!A_2 && File.Exists(text2))
				{
					string A_10 = "RecipeFileReplaceWarningMsgFmt2";
					empty = string.Format(hu.a(ref A_10), fileNameWithoutExtension, Path.GetDirectoryName(A_1));
					if (!global::fe.b(ref A_3, empty, "ImportRecipeFileTitle", "Yes", "No", A_4))
					{
						A_5++;
						return;
					}
					File.Delete(text2);
				}
				bu(A_3, A_0, A_1, A_2, ref A_8, A_9);
				if (Operators.CompareString(extension.ToLower(), ".fibra", TextCompare: false) == 0)
				{
					A_7++;
				}
				else
				{
					A_6++;
				}
			}
			else
			{
				File.Copy(A_0, text, overwrite: true);
				if (Operators.CompareString(extension.ToLower(), ".fitra", TextCompare: false) == 0)
				{
					A_7++;
				}
				else
				{
					A_6++;
				}
			}
		}
	}

	public static string bu(string A_0)
	{
		if (Operators.CompareString(A_0, ".fibrp", TextCompare: false) != 0)
		{
			if (Operators.CompareString(A_0, ".fibra", TextCompare: false) == 0)
			{
				return ".fitra";
			}
			return A_0;
		}
		return ".fitrp";
	}

	public static void bu(ComboBox A_0, hg A_1, int A_2, eo.a A_3)
	{
		bool a_ = A_1.dh().ax(A_3);
		int selectedIndex = A_0.SelectedIndex;
		int a_2 = default(int);
		if (selectedIndex >= 0)
		{
			a_2 = ((iz.a)A_0.Items[selectedIndex]).b;
		}
		A_0.Items.Clear();
		hi hi2 = A_1.b3(A_2);
		checked
		{
			int num = hi2.g7() + 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				gc gc2 = A_1.bv(num2, 0);
				if (gc2.ah(a_) || gc2.aj(a_))
				{
					string text = bz(gc2.ag());
					string text2 = ((num2 == 0) ? "Medium" : ((num2 != hi2.g7() + 1) ? ("Layer " + Strings.Trim(Conversion.Str(num2))) : "Substrate"));
					if (Operators.CompareString(Strings.Left(text, 11), "Generic, n=", TextCompare: false) != 0)
					{
						text2 = text2 + ": " + text;
					}
					bu(A_0, text2, num2, A_1, A_3);
				}
			}
			iz.b(A_0, a_2);
			if ((A_0.SelectedIndex == -1) & (A_0.Items.Count > 0))
			{
				A_0.Enabled = true;
				A_0.SelectedIndex = 0;
			}
			else if (A_0.Items.Count <= 0)
			{
				A_0.Enabled = false;
				A_0.Items.Add(new iz.a("Results Selection", 10));
				A_0.SelectedIndex = 0;
			}
			A_0.Visible = A_0.Items.Count > 1;
			if (A_0.Items.Count > 1)
			{
				iz.b(A_0);
			}
		}
	}

	public static void bu(ComboBox A_0, string A_1, int A_2, hg A_3, eo.a A_4)
	{
		iz.a item = null;
		bool a_ = A_3.dh().ax(A_4);
		gc obj = A_3.bu(A_2, 0);
		bool flag = obj.ah(a_);
		bool flag2 = obj.aj(a_);
		checked
		{
			if (!flag & !flag2)
			{
				item = new iz.a(A_1 + " Details", 10 * (2 + A_2));
			}
			else
			{
				if (flag)
				{
					item = new iz.a(A_1 + " n", 10 * (2 + A_2) + 1);
				}
				if (flag2)
				{
					item = new iz.a(A_1 + " k", 10 * (2 + A_2) + 2);
				}
				if (flag & flag2)
				{
					item = new iz.a(A_1 + " n & k", 10 * (2 + A_2) + 3);
				}
			}
			A_0.Items.Add(item);
		}
	}

	public static int bu(ref ComboBox A_0)
	{
		checked
		{
			int num = (int)Math.Round(Conversion.Int(0.1 * (double)((iz.a)A_0.Items[A_0.SelectedIndex]).b));
			if (num != 1)
			{
				return num - 2;
			}
			return -1;
		}
	}

	public static bool bu(Collection<Guid> A_0, Collection<Guid> A_1)
	{
		return hi.au(A_0, A_1);
	}
}
