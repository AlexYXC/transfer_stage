using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using FIUsbIntLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class hr : fy
{
	public enum FileType
	{
		Fmspe,
		Spe,
		Csv,
		Txt
	}

	public new enum a
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
		j
	}

	public enum b
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
		r
	}

	public enum c
	{
		a = 1,
		b,
		c,
		d,
		e
	}

	public enum d
	{
		a = 1
	}

	private new const string m_r = "Filmetrics Spectrum (.fmspe;.fmdmo;.spe)|*.fmspe;*.fmdmo;*.spe|Filmetrics Calculated Spectrum (.fmcsp;.csp)|*.fmcsp;*.csp";

	private const string s = "Filmetrics Spectrum (Text) (.fmspe;.spe)|*.fmspe;*.spe";

	private new const string m_t = "Filmetrics Demo Spectrum (.fmdmo)|*.fmdmo";

	private new const string u = "Filmetrics Spectrum (.fmspe;.fmdmo;.spe)|*.fmspe;*.fmdmo;*.spe|Filmetrics Calculated Spectrum (.fmcsp;.csp)|*.fmcsp;*.csp|Spectrum (Text) (.csv; .txt)|*.csv;*.txt|Reference Reflectance (.rrr)|*.rrr";

	private new const string v = "Filmetrics Spectrum (.fmspe;.fmdmo;.spe)|*.fmspe;*.fmdmo;*.spe|Filmetrics Calculated Spectrum (.fmcsp;.csp)|*.fmcsp;*.csp|Spectrum (Text) (.csv; .txt)|*.csv;*.txt|Reference Reflectance (.rrr)|*.rrr|Woollam Spectrum (Text) (.dat)|*.dat";

	public new const string w = ".csv";

	public new const string x = ".txt";

	public new const string y = ".fmbsa";

	public new const string z = ".fmspe";

	public new const string aa = ".fmdmo";

	public new const string ab = ".rrr";

	public new const string ac = ".spe";

	public new const string ad = ".csp";

	public new const string ae = ".spc";

	public new const string af = ".fmcsp";

	public new const string ag = ".dat";

	public new const string ah = "Unknown";

	public new const string ai = "Generated";

	public new const string al = "Wavelength (nm)";

	private new const string m_am = "Reading";

	public new const string ao = "Reflectance";

	public new const string ap = "Refl.";

	public new const string aq = "Raw Reflectance (counts)";

	public new const string ar = "Raw Reflectance";

	public new const string @as = "Raw Refl.";

	public new const string at = "FFT Intensity";

	public new const string au = "FFT";

	public new const string av = "Layer Thickness";

	public new const string aw = "r";

	public new const string ax = "Transmittance";

	public new const string az = "Trans.";

	public new const string a0 = "Raw Transmittance (counts)";

	public new const string a2 = "Raw Transmittance";

	public new const string a3 = "Raw Trans.";

	public new const string a4 = "CTM Signal";

	public const string a5 = "CTM";

	public const string a6 = "Raw CTM Signal (counts)";

	public const string a7 = "Raw CTM";

	public const string a8 = "Refl. + Trans.";

	public const string a9 = "R+T";

	public const string ba = "Absorptance";

	public const string bb = "Absorp.";

	public const string bc = "Raw Signal (counts)";

	public const string bd = "Signal (counts)";

	public const string be = "Thickness";

	private const string bf = "dEmOsPecTrUm";

	private const double bg = 100.0;

	private const double bh = 100000.0;

	public const string bi = "R";

	public const string bj = "T";

	public const string bk = "R1";

	public const string bl = "A";

	public const string bm = "-";

	public const string bn = "-(";

	public const string bo = ")";

	public const string bp = ", ";

	private b m_bq;

	private float m_br;

	private int m_bs;

	private FMLegacyAllSystemTypes m_bt;

	private ew.a m_bu;

	private string m_bv;

	private eo.a m_bw;

	private DateTime m_bx;

	private string m_by;

	private string m_bz;

	private a m_b0;

	private int m_b1;

	private float m_b2;

	private float m_b3;

	private List<Guid> m_b4;

	private string m_b5;

	private long m_b6;

	private long m_b7;

	private double[] m_b8;

	private double[] m_b9;

	private bool m_ca;

	private bool m_cb;

	private hm m_cc;

	private double[] m_cd;

	private double[] m_ce;

	public double cf;

	public int cg;

	public bool ch;

	public string ci;

	private bool m_cj;

	private bool m_ck;

	private int m_cl;

	private int m_cm;

	private string m_cn;

	protected int co;

	private const short m_cp = 13;

	private const short m_cq = 1;

	private bool m_cr;

	private string m_cs;

	private string m_ct;

	private ej m_cu;

	private Collection<hp> m_cv;

	private float m_cw;

	private new Collection<hn> cx;

	private new int cy;

	private new string cz;

	private new const int c0 = 2;

	private new const int c1 = 3;

	private new const int c2 = 4;

	private new const int c3 = 5;

	private new const int c4 = 6;

	private const int c5 = 7;

	private const int c6 = 6;

	private const string c7 = "Spectrum (*.fmspe)";

	private const string c8 = "*.fmspe";

	private const string c9 = "Spectrum (Text) (*.spe)";

	private const string da = "*.spe";

	private const string db = "Calculated Spectrum (Text) (*.csp)";

	private const string dc = "*.csp";

	private const string dd = "Binary Calculated Spectrum (*.fmcsp)";

	private const string de = "*.fmcsp";

	private const string df = "Demo Spectrum (*.fmdmo)";

	private const string dg = "*.fmdmo";

	private const string dh = "Woollam Spectrum (*.dat)";

	private const string di = "*.dat";

	[SpecialName]
	private static string[] dj;

	[SpecialName]
	private static string[] dk;

	public static string r(FileType A_0)
	{
		return A_0 switch
		{
			FileType.Fmspe => ".fmspe", 
			FileType.Spe => ".spe", 
			FileType.Csv => ".csv", 
			FileType.Txt => ".txt", 
			_ => throw new ax("Invalid file type in Spectrum.ExtFromFileType. Type value is " + A_0), 
		};
	}

	public new bool af()
	{
		return ah(this.m_bq);
	}

	public new static bool ah(b A_0)
	{
		return A_0 == b.n;
	}

	public new bool ag()
	{
		return r(this.m_bq, this.m_cc.q() != null);
	}

	public static bool r(b A_0, bool A_1)
	{
		if (A_0 != b.c && A_0 != b.j && (A_0 != b.n || !A_1))
		{
			return A_0 == b.r;
		}
		return true;
	}

	public new bool ah()
	{
		return ag(this.m_bq);
	}

	public new static bool ag(b A_0)
	{
		if (A_0 != b.c && A_0 != b.j)
		{
			return A_0 == b.n;
		}
		return true;
	}

	public new bool am()
	{
		return af(this.m_bq);
	}

	public new static bool af(b A_0)
	{
		if ((!ag(A_0) || ah(A_0)) && A_0 != b.e && A_0 != b.l && A_0 != b.m)
		{
			return A_0 == b.p;
		}
		return true;
	}

	[SpecialName]
	public new static bool t(b A_0)
	{
		if (A_0 != b.c && A_0 != b.e && A_0 != b.b && A_0 != b.n && A_0 != b.o)
		{
			return A_0 == b.a;
		}
		return true;
	}

	[SpecialName]
	public new bool ao()
	{
		return t(this.m_bq);
	}

	[SpecialName]
	public static bool r(b A_0)
	{
		if (A_0 != b.j)
		{
			return A_0 == b.l;
		}
		return true;
	}

	[SpecialName]
	public new bool ap()
	{
		return r(this.m_bq);
	}

	[SpecialName]
	public new bool aq()
	{
		string A_ = this.m_cn + "dEmOsPecTrUm";
		return Operators.CompareString(hh.b(ref A_), this.m_bv, TextCompare: false) == 0;
	}

	[SpecialName]
	public string bk()
	{
		string A_ = r(ref j, c0(), c2(), 6) + "dEmOsPecTrUm";
		return hh.b(ref A_);
	}

	[SpecialName]
	public hr bl()
	{
		if (base.t == null)
		{
			return null;
		}
		return (hr)base.t;
	}

	[SpecialName]
	public void r(hr A_0)
	{
		base.t = A_0;
	}

	[SpecialName]
	public Collection<hr> bm()
	{
		if (base.u == null)
		{
			return null;
		}
		Collection<hr> collection = new Collection<hr>();
		foreach (fy item in base.u)
		{
			collection.Add((hr)item);
		}
		return collection;
	}

	[SpecialName]
	public bool bn()
	{
		return this.m_cr;
	}

	[SpecialName]
	public new void ag(bool A_0)
	{
		this.m_cr = A_0;
	}

	[SpecialName]
	public ej bp()
	{
		return this.m_cu;
	}

	[SpecialName]
	public eo.a bq()
	{
		return this.m_bw;
	}

	[SpecialName]
	public Collection<hp> br()
	{
		return this.m_cv;
	}

	[SpecialName]
	public void r(Collection<hp> A_0)
	{
		this.m_cv = A_0;
	}

	[SpecialName]
	public Collection<hn> bs()
	{
		return cx;
	}

	[SpecialName]
	public void r(Collection<hn> A_0)
	{
		cx = A_0;
	}

	[SpecialName]
	public float bt()
	{
		return this.m_cw;
	}

	[SpecialName]
	public void r(float A_0)
	{
		this.m_cw = A_0;
	}

	public static string r(b A_0, hm A_1)
	{
		string text;
		switch (A_0)
		{
		case b.b:
			text = "Raw Reflectance (counts)";
			break;
		case b.c:
		case b.e:
			text = "Reflectance";
			break;
		case b.d:
			text = "r";
			break;
		case b.k:
			text = "Raw Transmittance (counts)";
			break;
		case b.j:
		case b.l:
			text = "Transmittance";
			break;
		case b.m:
			text = "Refl. + Trans.";
			break;
		case b.n:
			text = "CTM Signal";
			break;
		case b.o:
			text = "Raw CTM Signal (counts)";
			break;
		case b.p:
			text = "Absorptance";
			break;
		case b.q:
			text = "Raw Signal (counts)";
			break;
		case b.r:
			text = "Signal (counts)";
			break;
		default:
			text = "Reflectance";
			break;
		}
		if (jf.e(A_1.m(), 0.0))
		{
			return text;
		}
		return text + " @" + A_1.m() + " deg " + A_1.o() + " polarized";
	}

	public new static string t(b A_0, float A_1)
	{
		string empty = string.Empty;
		if (dj == null)
		{
			dj = new string[checked(Enum.GetValues(typeof(b)).GetUpperBound(0) + 1)];
		}
		switch (A_0)
		{
		case b.b:
			if (string.IsNullOrEmpty(dj[(int)A_0]))
			{
				string[] array6 = dj;
				string A_2 = "RawTitle";
				array6[(int)A_0] = hu.a(ref A_2);
			}
			break;
		case b.c:
		case b.e:
			if (string.IsNullOrEmpty(dj[(int)A_0]))
			{
				string[] array10 = dj;
				string A_2 = "ReflectanceTitle";
				array10[(int)A_0] = hu.a(ref A_2);
			}
			break;
		case b.d:
			if (string.IsNullOrEmpty(dj[(int)A_0]))
			{
				string[] array2 = dj;
				string A_2 = "ReferenceTitle";
				array2[(int)A_0] = hu.a(ref A_2);
			}
			break;
		case b.k:
			if (string.IsNullOrEmpty(dj[(int)A_0]))
			{
				string[] array8 = dj;
				string A_2 = "TransmittanceRawTitle";
				array8[(int)A_0] = hu.a(ref A_2);
			}
			break;
		case b.j:
		case b.l:
			if (string.IsNullOrEmpty(dj[(int)A_0]))
			{
				string[] array4 = dj;
				string A_2 = "TransmittanceTitle";
				array4[(int)A_0] = hu.a(ref A_2);
			}
			break;
		case b.m:
			if (string.IsNullOrEmpty(dj[(int)A_0]))
			{
				string[] array11 = dj;
				string A_2 = "RPlusTTitle";
				array11[(int)A_0] = hu.a(ref A_2);
			}
			break;
		case b.p:
			if (string.IsNullOrEmpty(dj[(int)A_0]))
			{
				string[] array9 = dj;
				string A_2 = "Absorptance";
				array9[(int)A_0] = hu.a(ref A_2);
			}
			break;
		case b.o:
			if (string.IsNullOrEmpty(dj[(int)A_0]))
			{
				string[] array7 = dj;
				string A_2 = "CTMSignalRawTitle";
				array7[(int)A_0] = hu.a(ref A_2);
			}
			break;
		case b.n:
			if (string.IsNullOrEmpty(dj[(int)A_0]))
			{
				string[] array5 = dj;
				string A_2 = "CTMSignalTitle";
				array5[(int)A_0] = hu.a(ref A_2);
			}
			break;
		case b.q:
			if (string.IsNullOrEmpty(dj[(int)A_0]))
			{
				string[] array3 = dj;
				string A_2 = "SignalTitle";
				array3[(int)A_0] = hu.a(ref A_2);
			}
			break;
		case b.r:
			if (string.IsNullOrEmpty(dj[(int)A_0]))
			{
				string[] array = dj;
				string A_2 = "SignalMinusBackgroundTitle";
				array[(int)A_0] = hu.a(ref A_2);
			}
			break;
		default:
			dj[(int)A_0] = string.Empty;
			break;
		}
		if (jf.e(A_1, 0.0))
		{
			return dj[(int)A_0];
		}
		return dj[(int)A_0] + " @" + A_1.ToString("0.####", CultureInfo.CurrentCulture).TrimEnd(Conversions.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)) + " deg ";
	}

	public static string r(b A_0, float A_1)
	{
		string empty = string.Empty;
		if (dk == null)
		{
			dk = new string[checked(Enum.GetValues(typeof(b)).GetUpperBound(0) + 1)];
		}
		switch (A_0)
		{
		case b.b:
			if (string.IsNullOrEmpty(dk[(int)A_0]))
			{
				string[] array2 = dk;
				string A_2 = "RawTitleAbbrev";
				array2[(int)A_0] = hu.a(ref A_2);
			}
			break;
		case b.c:
			if (string.IsNullOrEmpty(dk[(int)A_0]))
			{
				string[] array6 = dk;
				string A_2 = "ReflectanceAbbrevTitle";
				array6[(int)A_0] = hu.a(ref A_2);
			}
			break;
		case b.d:
			if (string.IsNullOrEmpty(dk[(int)A_0]))
			{
				string[] array8 = dk;
				string A_2 = "ReferenceTitle";
				array8[(int)A_0] = hu.a(ref A_2);
			}
			break;
		case b.j:
			if (string.IsNullOrEmpty(dk[(int)A_0]))
			{
				string[] array4 = dk;
				string A_2 = "TransmittanceAbbrevTitle";
				array4[(int)A_0] = hu.a(ref A_2);
			}
			break;
		case b.k:
			if (string.IsNullOrEmpty(dk[(int)A_0]))
			{
				string[] array9 = dk;
				string A_2 = "TransmittanceRawAbbrevTitle";
				array9[(int)A_0] = hu.a(ref A_2);
			}
			break;
		case b.m:
			if (string.IsNullOrEmpty(dk[(int)A_0]))
			{
				string[] array7 = dk;
				string A_2 = "RPlusTTitleAbbrev";
				array7[(int)A_0] = hu.a(ref A_2);
			}
			break;
		case b.o:
			if (string.IsNullOrEmpty(dk[(int)A_0]))
			{
				string[] array5 = dk;
				string A_2 = "CTMSignalRawAbbrevTitle";
				array5[(int)A_0] = hu.a(ref A_2);
			}
			break;
		case b.n:
			if (string.IsNullOrEmpty(dk[(int)A_0]))
			{
				string[] array3 = dk;
				string A_2 = "CTMSignalAbbrevTitle";
				array3[(int)A_0] = hu.a(ref A_2);
			}
			break;
		case b.p:
			if (string.IsNullOrEmpty(dk[(int)A_0]))
			{
				string[] array = dk;
				string A_2 = "AbsorptanceTitleAbbrev";
				array[(int)A_0] = hu.a(ref A_2);
			}
			break;
		default:
			dk[(int)A_0] = string.Empty;
			break;
		}
		if (jf.e(A_1, 0.0))
		{
			return dk[(int)A_0];
		}
		return dk[(int)A_0] + " @" + A_1.ToString("f0");
	}

	public hr(eo.a A_0)
	{
		this.m_b4 = new List<Guid>();
		this.m_bw = A_0;
		this.m_b0 = a.a;
		this.m_ca = false;
		this.m_cb = false;
		this.m_cc = new hm();
		cf = 100000000.0;
		cg = 1;
		this.m_cv = null;
		r(c0());
		this.m_b4.Add(Guid.NewGuid());
	}

	public hr(string A_0, DateTime A_1, string A_2, eo.a A_3)
		: this(A_3)
	{
		this.m_bv = A_0;
		this.m_bx = new DateTime(A_1.Ticks);
		this.m_by = A_2;
		this.m_bz = "";
	}

	public hr(double[] A_0, Guid A_1, double[] A_2, b A_3, float A_4, int A_5, FMLegacyAllSystemTypes A_6, ew.a A_7, string A_8, DateTime A_9, string A_10, string A_11, a A_12, int A_13, float A_14, float A_15, double[] A_16, double[] A_17, string A_18, bool A_19, bool A_20, bool A_21, int A_22, int A_23, ej A_24, int A_25, string A_26, eo.a A_27)
		: this(A_0, new Guid[1] { A_1 }, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10, A_11, A_12, A_13, A_14, A_15, A_16, A_17, A_18, A_19, A_20, A_21, A_22, A_23, A_24, A_25, A_26, A_27)
	{
	}

	public hr(double[] A_0, Guid[] A_1, double[] A_2, b A_3, float A_4, int A_5, FMLegacyAllSystemTypes A_6, ew.a A_7, string A_8, DateTime A_9, string A_10, string A_11, a A_12, int A_13, float A_14, float A_15, double[] A_16, double[] A_17, string A_18, bool A_19, bool A_20, bool A_21, int A_22, int A_23, ej A_24, int A_25, string A_26, eo.a A_27)
		: base(A_0, A_2)
	{
		this.m_b4 = new List<Guid>();
		this.m_bw = A_27;
		r(A_2);
		this.m_bq = A_3;
		this.m_br = A_4;
		this.m_bs = A_5;
		this.m_bt = A_6;
		this.m_bu = A_7;
		this.m_bv = A_8;
		this.m_bx = new DateTime(A_9.Ticks);
		this.m_by = A_10;
		this.m_bz = A_11;
		this.m_b0 = A_12;
		this.m_b1 = A_13;
		this.m_b2 = A_14;
		this.m_b3 = A_15;
		foreach (Guid item in A_1)
		{
			this.m_b4.Add(item);
		}
		this.m_ca = A_19;
		this.m_cb = A_20;
		if ((A_16 != null) & (A_17 != null))
		{
			this.m_b8 = (double[])A_16.Clone();
			this.m_b9 = (double[])A_17.Clone();
		}
		this.m_cn = A_18;
		this.m_cc = new hm();
		this.m_ck = A_21;
		this.m_cl = A_22;
		this.m_cm = A_23;
		this.m_cu = A_24;
		this.m_cv = null;
		cy = A_25;
		cz = A_26;
	}

	[SpecialName]
	public new static string t()
	{
		return "Filmetrics Spectrum (.fmspe;.fmdmo;.spe)|*.fmspe;*.fmdmo;*.spe|Filmetrics Calculated Spectrum (.fmcsp;.csp)|*.fmcsp;*.csp|Spectrum (Text) (.csv; .txt)|*.csv;*.txt|Reference Reflectance (.rrr)|*.rrr";
	}

	private new static void af(b2 A_0)
	{
		A_0.a("Spectrum (*.fmspe)", "*.fmspe", 1);
	}

	private new static void t(b2 A_0)
	{
		A_0.a("Binary Calculated Spectrum (*.fmcsp)", "*.fmcsp", 1);
	}

	private static void r(bool A_0, b2 A_1)
	{
		if (A_0)
		{
			A_1.a("Spectrum (Text) (*.spe)", "*.spe", 2);
		}
		A_1.a("Comma Separated Values (*.csv)", "*.csv", 3);
		A_1.a("Text Files (*.txt)", "*.txt", 4);
	}

	private static void r(b2 A_0)
	{
		A_0.a("Calculated Spectrum (Text) (*.csp)", "*.csp", 2);
		A_0.a("Comma Separated Values (*.csv)", "*.csv", 3);
		A_0.a("Text Files (*.txt)", "*.txt", 4);
	}

	[SpecialName]
	public new static List<string> ag(bool A_0, bool A_1, bool A_2)
	{
		b2 b10 = af(A_0, A_1, A_2);
		List<string> list = new List<string>();
		int num = b10.c().Length;
		for (int num2 = 1; num2 <= num; num2 = checked(num2 + 1))
		{
			list.Add(b10.b(num2));
		}
		return list;
	}

	[SpecialName]
	public new static b2 af(bool A_0, bool A_1, bool A_2)
	{
		b2 b10 = new b2();
		af(b10);
		if (A_0)
		{
			b10.a("Demo Spectrum (*.fmdmo)", "*.fmdmo", 1);
		}
		r(A_2, b10);
		if (A_2 && (A_0 || A_1))
		{
			b10.a("Woollam Spectrum (*.dat)", "*.dat", 5);
		}
		return b10;
	}

	[SpecialName]
	public new int ah(bool A_0)
	{
		if (A_0)
		{
			return 2;
		}
		return -1;
	}

	[SpecialName]
	public b2 bu()
	{
		b2 obj = new b2();
		t(obj);
		r(obj);
		return obj;
	}

	[SpecialName]
	public new static string af(bool A_0)
	{
		if (A_0)
		{
			return "Filmetrics Spectrum (.fmspe;.fmdmo;.spe)|*.fmspe;*.fmdmo;*.spe|Filmetrics Calculated Spectrum (.fmcsp;.csp)|*.fmcsp;*.csp|Spectrum (Text) (.csv; .txt)|*.csv;*.txt|Reference Reflectance (.rrr)|*.rrr|Woollam Spectrum (Text) (.dat)|*.dat";
		}
		return "Filmetrics Spectrum (.fmspe;.fmdmo;.spe)|*.fmspe;*.fmdmo;*.spe|Filmetrics Calculated Spectrum (.fmcsp;.csp)|*.fmcsp;*.csp|Spectrum (Text) (.csv; .txt)|*.csv;*.txt|Reference Reflectance (.rrr)|*.rrr";
	}

	[SpecialName]
	public new static string[] t(bool A_0)
	{
		if (A_0)
		{
			return new string[8] { "*.fmspe", "*.fmdmo", "*.spe", "*.fmcsp", "*.csp", "*.csv", "*.txt", "*.dat" };
		}
		return new string[7] { "*.fmspe", "*.fmdmo", "*.spe", "*.fmcsp", "*.csp", "*.csv", "*.txt" };
	}

	[SpecialName]
	public new static string t(bool A_0, bool A_1, bool A_2)
	{
		if (!A_0)
		{
			return "Filmetrics Demo Spectrum (.fmdmo)|*.fmdmo";
		}
		if (!A_1)
		{
			return "Filmetrics Spectrum (Text) (.fmspe;.spe)|*.fmspe;*.spe";
		}
		if (A_2)
		{
			return "Filmetrics Spectrum (.fmspe;.fmdmo;.spe)|*.fmspe;*.fmdmo;*.spe|Filmetrics Calculated Spectrum (.fmcsp;.csp)|*.fmcsp;*.csp|Spectrum (Text) (.csv; .txt)|*.csv;*.txt|Reference Reflectance (.rrr)|*.rrr|Woollam Spectrum (Text) (.dat)|*.dat";
		}
		return "Filmetrics Spectrum (.fmspe;.fmdmo;.spe)|*.fmspe;*.fmdmo;*.spe|Filmetrics Calculated Spectrum (.fmcsp;.csp)|*.fmcsp;*.csp";
	}

	[SpecialName]
	public static string[] r(bool A_0, bool A_1, bool A_2)
	{
		if (!A_0)
		{
			return new string[1] { "*.fmdmo" };
		}
		if (!A_1)
		{
			return new string[2] { "*.fmspe", "*.spe" };
		}
		if (A_2)
		{
			return new string[8] { "*.fmspe", "*.fmdmo", "*.spe", "*.fmcsp", "*.csp", "*.csv", "*.txt", "*.dat" };
		}
		return new string[5] { "*.fmspe", "*.fmdmo", "*.spe", "*.fmcsp", "*.csp" };
	}

	public void r(string A_0, string A_1, long A_2, long A_3, int A_4, string A_5)
	{
		this.m_by = A_0;
		this.m_bz = A_1;
		this.m_b6 = A_2;
		this.m_b7 = A_3;
		cy = A_4;
		cz = A_5;
	}

	public void r(ref string A_0, ref string A_1)
	{
		A_0 = null;
		A_1 = null;
		int num = this.m_bz.LastIndexOf("-(");
		int num2 = this.m_bz.LastIndexOf(")");
		checked
		{
			if (num < 0 || num2 < 0 || num2 <= num + "-(".Length + ")".Length - 1)
			{
				return;
			}
			int num3 = num + "-(".Length;
			int num4 = num2 - ")".Length - num3 + 1;
			string text = this.m_bz.Substring(num3, num4);
			int num5 = text.IndexOf(", ");
			if (num5 > 0 && num5 < num4 - ", ".Length)
			{
				A_0 = text.Substring(0, num5);
				int num6 = text.LastIndexOf(", ");
				if (num6 < num4 - ", ".Length)
				{
					A_1 = text.Substring(num6 + ", ".Length, num4 - (num6 + ", ".Length));
				}
			}
		}
	}

	public void r(Image A_0, Rectangle A_1, int A_2, float A_3, float A_4, ej.b A_5, fz A_6)
	{
		this.m_cu = new ej();
		this.m_cu.a(A_0, A_1, A_2, A_3, A_4, A_5, A_6);
	}

	public void r(hp A_0)
	{
		if (this.m_cv == null)
		{
			this.m_cv = new Collection<hp>();
		}
		this.m_cv.Add(A_0);
	}

	public void r(hn A_0)
	{
		if (cx == null)
		{
			cx = new Collection<hn>();
		}
		cx.Add(A_0);
	}

	public void bv()
	{
		if (cx != null)
		{
			cx.Clear();
		}
	}

	public string bw()
	{
		return t(this.m_bq, this.m_cc.m());
	}

	public string bx()
	{
		return r(this.m_bq, this.m_cc.m());
	}

	public string by()
	{
		return r(this.m_bq, this.m_cc);
	}

	public string bz()
	{
		switch (this.m_bq)
		{
		case b.b:
		case b.c:
		case b.d:
		case b.j:
		case b.k:
		case b.n:
		case b.o:
			return "Wavelength (nm)";
		case b.f:
			return "Thickness";
		default:
			return "Wavelength (nm)";
		}
	}

	protected void b0()
	{
		short a_ = checked((short)c2());
		r(a_);
	}

	protected void r(short A_0)
	{
		hm obj = new hm();
		float a_ = 30f;
		float a_2 = 0f;
		float a_3 = 400f;
		float a_4 = 4.5f;
		obj.i(a_).k(a_3).j(a_2)
			.l(a_4);
	}

	[SpecialName]
	public int b1()
	{
		return this.m_b1;
	}

	[SpecialName]
	public float b2()
	{
		return this.m_b2;
	}

	[SpecialName]
	public float b3()
	{
		return this.m_b3;
	}

	[SpecialName]
	public string b4()
	{
		return this.m_by;
	}

	[SpecialName]
	public string b5()
	{
		return this.m_bz;
	}

	[SpecialName]
	public void ak(string A_0)
	{
		this.m_bz = A_0;
	}

	[SpecialName]
	public int b6()
	{
		return cy;
	}

	[SpecialName]
	public void r(int A_0)
	{
		cy = A_0;
	}

	[SpecialName]
	public string b7()
	{
		return cz;
	}

	[SpecialName]
	public void an(string A_0)
	{
		cz = A_0;
	}

	public void r(List<Guid> A_0)
	{
		this.m_b4 = A_0;
	}

	[SpecialName]
	public ReadOnlyCollection<Guid> b8()
	{
		return this.m_b4.AsReadOnly();
	}

	[SpecialName]
	public long b9()
	{
		return this.m_b6;
	}

	[SpecialName]
	public void r(long A_0)
	{
		this.m_b6 = A_0;
	}

	[SpecialName]
	public long ca()
	{
		return this.m_b7;
	}

	[SpecialName]
	public new void t(long A_0)
	{
		this.m_b7 = A_0;
	}

	[SpecialName]
	public DateTime cb()
	{
		return this.m_bx;
	}

	[SpecialName]
	public void r(DateTime A_0)
	{
		this.m_bx = A_0;
	}

	[SpecialName]
	public bool cc()
	{
		return this.m_ck;
	}

	[SpecialName]
	public void aj(bool A_0)
	{
		this.m_ck = A_0;
	}

	[SpecialName]
	public int cd()
	{
		return this.m_cl;
	}

	[SpecialName]
	public new void t(int A_0)
	{
		this.m_cl = A_0;
	}

	[SpecialName]
	public int ce()
	{
		return this.m_cm;
	}

	[SpecialName]
	public new void af(int A_0)
	{
		this.m_cm = A_0;
	}

	[SpecialName]
	public b cj()
	{
		return this.m_bq;
	}

	[SpecialName]
	public void aj(b A_0)
	{
		this.m_bq = A_0;
	}

	[SpecialName]
	public int ck()
	{
		return this.m_bs;
	}

	[SpecialName]
	public new void ag(int A_0)
	{
		this.m_bs = A_0;
	}

	[SpecialName]
	public FMLegacyAllSystemTypes cl()
	{
		return this.m_bt;
	}

	[SpecialName]
	public void r(FMLegacyAllSystemTypes A_0)
	{
		this.m_bt = A_0;
	}

	[SpecialName]
	public ew.a cm()
	{
		return this.m_bu;
	}

	[SpecialName]
	public void r(ew.a A_0)
	{
		this.m_bu = A_0;
	}

	[SpecialName]
	public string cn()
	{
		return this.m_bv;
	}

	[SpecialName]
	public new void ao(string A_0)
	{
		this.m_bv = A_0;
	}

	[SpecialName]
	public a co()
	{
		return this.m_b0;
	}

	[SpecialName]
	public void r(a A_0)
	{
		this.m_b0 = A_0;
	}

	[SpecialName]
	public float cp()
	{
		return this.m_br;
	}

	[SpecialName]
	public new void t(float A_0)
	{
		this.m_br = A_0;
	}

	[SpecialName]
	public bool cq()
	{
		return this.m_ca;
	}

	[SpecialName]
	public void ak(bool A_0)
	{
		this.m_ca = A_0;
	}

	[SpecialName]
	public bool cr()
	{
		return this.m_cb;
	}

	[SpecialName]
	public new void am(bool A_0)
	{
		this.m_cb = A_0;
	}

	public static bool r(double A_0, double A_1)
	{
		if (A_0 > 1100.0)
		{
			return r(A_1);
		}
		return false;
	}

	public static bool r(double A_0)
	{
		return A_0 < 0.5;
	}

	[SpecialName]
	public double cs()
	{
		return base.au;
	}

	[SpecialName]
	public new void t(double A_0)
	{
		base.au = A_0;
	}

	[SpecialName]
	public double ct()
	{
		return base.av;
	}

	[SpecialName]
	public new void af(double A_0)
	{
		base.av = A_0;
	}

	[SpecialName]
	public hm cu()
	{
		return this.m_cc;
	}

	[SpecialName]
	public void r(hm A_0)
	{
		this.m_cc = A_0;
	}

	[SpecialName]
	public double[] cv()
	{
		if (this.m_ce == null)
		{
			this.m_ce = n.b5(this.m_cd);
		}
		return this.m_ce;
	}

	[SpecialName]
	public void r(double[] A_0)
	{
		this.m_cd = n.b4(A_0);
		this.m_ce = null;
	}

	protected override int ai(int A_0)
	{
		switch (A_0)
		{
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
			return 5;
		case 6:
			return 6;
		default:
			return 0;
		}
	}

	[SpecialName]
	protected override int aj()
	{
		return 6;
	}

	[SpecialName]
	protected override int ak()
	{
		return 2;
	}

	[SpecialName]
	private static int r()
	{
		return 1;
	}

	protected override void al(string A_0)
	{
		string left;
		if (string.IsNullOrEmpty(A_0))
		{
			left = "";
			base.am = false;
		}
		else
		{
			left = Path.GetExtension(A_0).ToLower();
			base.am = aj(A_0);
		}
		if (base.am)
		{
			if (base.t != null || (base.u != null && base.u.Count > 0))
			{
				base.ap = ah(A_0);
				base.ao = ay(A_0);
				this.m_cs = ag(A_0);
				this.m_ct = af(A_0);
			}
			else
			{
				base.ap = string.Empty;
				base.ao = A_0;
				this.m_cs = string.Empty;
				this.m_ct = string.Empty;
			}
			base.v = Conversions.ToString(i3.h(A_0));
			if (Operators.CompareString(left, ".txt", TextCompare: false) != 0)
			{
				base.v += " ";
			}
			base.aq = Operators.CompareString(left, ".spe", TextCompare: false) != 0 && Operators.CompareString(left, ".csp", TextCompare: false) != 0;
			if (Operators.CompareString(left, ".spe", TextCompare: false) == 0)
			{
				base.@as = 100.0;
				base.at = 100000.0;
			}
			else
			{
				cy();
			}
		}
		else
		{
			base.ap = "";
			base.ao = A_0;
		}
	}

	[SpecialName]
	public static bool aj(string A_0)
	{
		switch (Path.GetExtension(A_0))
		{
		case ".csv":
		case ".txt":
		case ".spe":
		case ".csp":
		case ".dat":
			return true;
		default:
			return false;
		}
	}

	[SpecialName]
	public string ay(string A_0)
	{
		if (aj(A_0))
		{
			string text = Path.GetDirectoryName(A_0) + "\\" + Path.GetFileNameWithoutExtension(A_0);
			string text2 = ((!ao()) ? "T" : "R");
			return text + "-" + text2 + Path.GetExtension(A_0).ToLower();
		}
		return A_0;
	}

	[SpecialName]
	public new static string ah(string A_0)
	{
		if (aj(A_0))
		{
			return string.Concat(Path.GetDirectoryName(A_0) + "\\" + Path.GetFileNameWithoutExtension(A_0), "-T", Path.GetExtension(A_0).ToLower());
		}
		return "";
	}

	[SpecialName]
	public new static string ag(string A_0)
	{
		if (aj(A_0))
		{
			return string.Concat(Path.GetDirectoryName(A_0) + "\\" + Path.GetFileNameWithoutExtension(A_0), "-R+T", Path.GetExtension(A_0).ToLower());
		}
		return null;
	}

	[SpecialName]
	public new static string af(string A_0)
	{
		if (aj(A_0))
		{
			return string.Concat(Path.GetDirectoryName(A_0) + "\\" + Path.GetFileNameWithoutExtension(A_0), "-A", Path.GetExtension(A_0).ToLower());
		}
		return null;
	}

	[SpecialName]
	public new static string t(string A_0)
	{
		if (aj(A_0))
		{
			return string.Concat(Path.GetDirectoryName(A_0) + "\\" + Path.GetFileNameWithoutExtension(A_0), "-R1", Path.GetExtension(A_0).ToLower());
		}
		return string.Empty;
	}

	protected override void am(string A_0)
	{
		base.w = Conversions.ToString(i3.h(A_0));
	}

	protected override fy an()
	{
		return cw();
	}

	public void r(ref string A_0, ref Collection<string> A_1, ref Collection<string> A_2)
	{
		if (bl() != null)
		{
			A_0 = bl().by();
		}
		else if (Operators.CompareString(A_0, string.Empty, TextCompare: false) != 0)
		{
			A_0 = string.Empty;
		}
		if (bm() != null && bm().Count > 0)
		{
			A_1 = new Collection<string>();
			A_2 = new Collection<string>();
			{
				foreach (hr item in bm())
				{
					A_1.Add(item.by());
					if (item.bl() != null)
					{
						A_2.Add(item.bl().by());
					}
					else
					{
						A_2.Add(string.Empty);
					}
				}
				return;
			}
		}
		if (A_1 != null)
		{
			A_1 = null;
		}
		if (A_2 != null)
		{
			A_2 = null;
		}
	}

	protected override void ao(string A_0, string A_1, string A_2, Collection<string> A_3, Collection<string> A_4, bool A_5, bool A_6, bool A_7)
	{
		if (!base.am)
		{
			c0();
			af(cv());
		}
		base.ao(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7);
		if (!base.am || base.t == null)
		{
			return;
		}
		double[] array = base.t.cz();
		if (checked(j[0] > array[base.t.c2() - 1] || j[c2() - 1] < array[0]))
		{
			if (File.Exists(this.m_cs))
			{
				File.Delete(this.m_cs);
			}
			if (File.Exists(this.m_ct))
			{
				File.Delete(this.m_ct);
			}
			return;
		}
		int A_8 = default(int);
		int A_9 = default(int);
		r(cz(), c0(), c2(), base.t.cz(), base.t.c0(), base.t.c2(), ref A_8, ref A_9);
		double[] A_10 = null;
		double[] A_11 = null;
		int A_12 = default(int);
		r(A_8, A_9, cz(), c0(), base.t.cz(), base.t.c0(), base.t.c2(), ref A_10, ref A_11, ref A_12);
		StreamWriter streamWriter = null;
		try
		{
			streamWriter = new StreamWriter(File.Open(this.m_cs, FileMode.Create));
			r(streamWriter, A_10, A_11, A_12, A_0, "Refl. + Trans.", Path.GetExtension(base.ao).ToLower(), A_5, A_6, A_7);
		}
		finally
		{
			streamWriter.Close();
		}
		streamWriter = null;
		try
		{
			streamWriter = new StreamWriter(File.Open(this.m_ct, FileMode.Create));
			r(streamWriter, A_10, r(A_10, A_11, A_12), A_12, A_0, "Absorptance", Path.GetExtension(base.ao).ToLower(), A_5, A_6, A_7);
		}
		finally
		{
			streamWriter.Close();
		}
	}

	protected override bool ap(string A_0)
	{
		return Operators.CompareString(A_0, ".spe", TextCompare: false) != 0;
	}

	protected override CultureInfo aq(string A_0)
	{
		if (Operators.CompareString(A_0, ".dat", TextCompare: false) == 0)
		{
			return CultureInfo.InvariantCulture;
		}
		return CultureInfo.CurrentCulture;
	}

	protected override void ar(ref StreamWriter A_0, double[] A_1, double[] A_2, int A_3, string A_4, ref string A_5, string A_6, bool A_7, ref CultureInfo A_8)
	{
		switch (A_6)
		{
		case ".spe":
		case ".csp":
			A_0.WriteLine("\"Version\"" + base.v + Conversions.ToString(r()));
			aw(ref A_0, A_1, A_2, A_3);
			break;
		case ".dat":
			A_0.WriteLine();
			A_0.WriteLine("nm");
			break;
		default:
			if (A_7)
			{
				A_5 += " (%)";
			}
			break;
		}
		if (Operators.CompareString(A_6, ".txt", TextCompare: false) == 0 || Operators.CompareString(A_6, ".csv", TextCompare: false) == 0)
		{
			A_8 = CultureInfo.CurrentCulture;
		}
		else
		{
			A_8 = CultureInfo.InvariantCulture;
		}
		if (Operators.CompareString(A_6, ".spe", TextCompare: false) == 0)
		{
			if (Operators.CompareString(A_5, "Raw Reflectance (counts)", TextCompare: false) == 0)
			{
				A_5 = "Raw Reflectance";
			}
			else if (Operators.CompareString(A_5, "Raw Transmittance (counts)", TextCompare: false) == 0)
			{
				A_5 = "Raw Transmittance";
			}
		}
	}

	protected override void @as(StreamWriter A_0, string A_1, double[] A_2, double[] A_3, int A_4, string A_5, string A_6, bool A_7, CultureInfo A_8)
	{
		double num = 1.0 / base.@as;
		double num2 = 1.0 / base.at;
		if (Operators.CompareString(A_1, ".dat", TextCompare: false) != 0)
		{
			base.@as(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8);
			return;
		}
		string A_9 = string.Empty;
		string A_10 = string.Empty;
		string text = "0";
		r(A_6, ref A_9, ref A_10);
		string text2;
		switch (A_6)
		{
		case "Transmittance":
			text2 = "uT";
			break;
		case "Reflectance":
		case "Refl. + Trans.":
		case "Absorptance":
			text2 = "uR";
			break;
		default:
			if (Operators.CompareString(A_10, "te", TextCompare: false) != 0)
			{
				if (Operators.CompareString(A_10, "tm", TextCompare: false) == 0)
				{
					text2 = "pR";
				}
				else
				{
					text2 = "uR";
				}
			}
			else
			{
				text2 = "sR";
			}
			text2 = "pR";
			text = A_9;
			break;
		}
		checked
		{
			int num3 = A_4 - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				A_0.WriteLine(text2 + "\t" + (Conversion.Int(A_2[num4] * base.@as + 0.5) * num).ToString("###0.00", A_8) + "\t" + text + "\t" + (Conversion.Int(A_3[num4] * base.at + 0.5) * num2).ToString("###0.00000", A_8));
			}
		}
	}

	protected override void at(ref BinaryWriter A_0, int A_1)
	{
		long position = A_0.BaseStream.Position;
		bool value = this.m_cc.p() != null;
		bool flag = this.m_cc.q() != null;
		bool flag2 = this.m_cc.p() != null && this.m_cc.p() is et;
		A_0.Write(position);
		A_0.Write((short)13);
		A_0.Write((short)1);
		A_0.Write(r(ref j, c0(), c2(), 6));
		int value2 = (int)this.m_bq;
		A_0.Write(value2);
		A_0.Write(this.m_br);
		A_0.Write(this.m_bs);
		int value3 = (int)this.m_bt;
		A_0.Write(value3);
		if (this.m_bv == null)
		{
			this.m_bv = string.Empty;
		}
		A_0.Write(this.m_bv);
		A_0.Write(this.m_bx.ToBinary());
		if (this.m_by == null)
		{
			this.m_by = string.Empty;
		}
		A_0.Write(this.m_by);
		if (this.m_bz == null)
		{
			this.m_bz = string.Empty;
		}
		A_0.Write(this.m_bz);
		A_0.Write(value);
		A_0.Write(flag2);
		if (flag2)
		{
			et et2 = (et)this.m_cc.p();
			A_0.Write(et2.al());
			A_0.Write(et2.t());
			A_0.Write(et2.u());
			A_0.Write(et2.v());
			A_0.Write(et2.x());
			A_0.Write(et2.y());
			A_0.Write(et2.ab());
			A_0.Write(et2.z());
			A_0.Write(et2.w());
			A_0.Write(et2.aa());
			et2 = null;
		}
		A_0.Write(this.m_cb);
		A_0.Write(this.m_ca);
		r(cv(), c2(), A_0, A_3: true);
		A_0.Write(this.m_ck);
		A_0.Write(this.m_cl);
		A_0.Write(this.m_cm);
		A_0.Write(this.m_cu != null);
		if (this.m_cu != null)
		{
			this.m_cu.a(A_0);
		}
		A_0.Write(this.m_cw);
		if (this.m_cv == null)
		{
			A_0.Write(Convert.ToInt32(0));
		}
		else
		{
			A_0.Write(this.m_cv.Count);
			foreach (hp item in this.m_cv)
			{
				item.q(A_0);
			}
		}
		if (cx == null)
		{
			A_0.Write(Convert.ToInt32(0));
		}
		else
		{
			A_0.Write(cx.Count);
			foreach (hn item2 in cx)
			{
				item2.f(A_0);
			}
		}
		A_0.Write(this.m_cc.m());
		int value4 = (int)this.m_cc.n();
		A_0.Write(value4);
		A_0.Write(flag);
		if (flag)
		{
			this.m_cc.q().l(A_0);
		}
		A_0.Write(ch);
		if (string.IsNullOrEmpty(ci))
		{
			A_0.Write(string.Empty);
		}
		else
		{
			A_0.Write(ci);
		}
		if (this.m_bw != null)
		{
			A_0.Write(value: true);
			this.m_bw.ao(A_0, cz(), cv(), c2());
		}
		else
		{
			A_0.Write(value: false);
		}
		A_0.Write(base.au);
		A_0.Write(base.av);
		A_0.Write(cy);
		if (cz == null)
		{
			cz = string.Empty;
		}
		A_0.Write(cz);
		long position2 = A_0.BaseStream.Position;
		A_0.BaseStream.Seek(position, SeekOrigin.Begin);
		A_0.Write(position2);
		A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
	}

	public override void m(ref BinaryWriter A_0)
	{
		A_0.Write(7);
		A_0.Write(6);
		long position = A_0.BaseStream.Position;
		A_0.Write(position);
		A_0.Write(aj());
		A_0.Write(ai(aj()));
		r(A_0, A_1: true);
		A_0.Write(base.t != null);
		if (base.t != null)
		{
			((hr)base.t).av(ref A_0, aj(), A_2: true);
		}
		int num = ((base.u != null) ? base.u.Count : 0);
		A_0.Write(num);
		checked
		{
			int num2 = num - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				hr hr2 = (hr)base.u[num3];
				hr2.av(ref A_0, aj(), A_2: true);
				A_0.Write(((fy)hr2).t != null);
				if (((fy)hr2).t != null)
				{
					((hr)((fy)hr2).t).av(ref A_0, aj(), A_2: true);
				}
			}
			long position2 = A_0.BaseStream.Position;
			A_0.BaseStream.Seek(position, SeekOrigin.Begin);
			A_0.Write(position2);
			A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
		}
	}

	private void r(BinaryWriter A_0, bool A_1)
	{
		at(ref A_0, aj());
		t(A_0, A_1);
	}

	public override void l(ref BinaryReader A_0)
	{
		int num = A_0.ReadInt32();
		int num2 = A_0.ReadInt32();
		if (num2 > 7)
		{
			throw new au("Spectrum binary file block compatible version is " + num2 + ", this software version only understands file block versions <=" + 7);
		}
		long offset = default(long);
		int a_;
		if (num >= 6)
		{
			offset = A_0.ReadInt64();
			a_ = A_0.ReadInt32();
			int num3 = A_0.ReadInt32();
			if (num3 > aj())
			{
				throw new au("Spectrum binary file core compatible version is " + num3 + ", this software version only understands file core versions <=" + aj());
			}
		}
		else
		{
			a_ = num;
			int num3 = num2;
		}
		r(A_0, a_, A_2: true);
		if (num < 6)
		{
			return;
		}
		if (A_0.ReadBoolean())
		{
			base.t = new hr(null);
			((hr)base.t).a4(ref A_0, a_, A_2: true);
		}
		checked
		{
			if (num >= 7)
			{
				int num4 = A_0.ReadInt32();
				if (num4 == 0)
				{
					base.u = null;
				}
				else
				{
					cx();
					int num5 = num4 - 1;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						hr hr2 = new hr(null);
						hr2.a4(ref A_0, a_, A_2: true);
						r((fy)hr2);
						if (A_0.ReadBoolean())
						{
							((fy)hr2).t = new hr(null);
							((hr)((fy)hr2).t).a4(ref A_0, a_, A_2: true);
						}
					}
				}
			}
			A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
		}
	}

	private void r(BinaryReader A_0, int A_1, bool A_2)
	{
		r((double[])null);
		ax(ref A_0, A_1);
		BinaryReader a_ = A_0;
		double[] A_3 = null;
		r(a_, A_2, A_2: false, ref A_3);
		if (cv() == null)
		{
			r(c0());
		}
		r(A_0: true);
	}

	private void r(bool A_0)
	{
		if (this.m_bw != null && !this.m_bw.ap(cz(), cv(), c2()))
		{
			this.m_bw = null;
		}
		if (A_0)
		{
			if ((!this.m_cj && this.m_bq == b.c) || this.m_bq == b.j || this.m_bq == b.n)
			{
				r(j, c2(), ref this.m_ck, ref this.m_cl, ref this.m_cm);
				if (this.m_ck)
				{
					r(this.m_cl, this.m_cm, j, cv(), c2(), A_5: true);
				}
			}
		}
		else
		{
			this.m_ck = false;
		}
	}

	protected override void au(ref StreamWriter A_0, int A_1)
	{
		A_0.WriteLine(r(ref j, c0(), c2(), 6));
		A_0.Write("Numerical Aperature, ");
		A_0.WriteLine(this.m_br);
		A_0.Write("Smoothing Points, ");
		A_0.WriteLine(this.m_bs);
		int value = (int)this.m_bt;
		A_0.Write("System Type, ");
		A_0.WriteLine(value);
		A_0.Write("System Serial Number, ");
		A_0.WriteLine(this.m_bv);
		A_0.Write("Acqisition Date, ");
		A_0.WriteLine(this.m_bx.ToString());
		A_0.Write("User, ");
		A_0.WriteLine(this.m_by);
		A_0.Write("Sample ID, ");
		A_0.WriteLine(this.m_bz);
	}

	protected override void av(ref BinaryWriter A_0, int A_1, bool A_2)
	{
		r(A_0, A_2);
	}

	private new static string t(double[] A_0, double[] A_1, int A_2)
	{
		string text = "";
		string text2 = "";
		string text3 = "";
		double num = 0.01;
		double num2 = 1E-05;
		checked
		{
			int num3 = ((r() <= A_2 - 1) ? r() : (A_2 - 1));
			string text4 = Strings.Trim(jg.a(Conversion.Int(A_0[num3] * 100.0 + 0.5) * num));
			text = Strings.Trim(jg.a(Conversion.Int(A_1[num3] * 100000.0 + 0.5) * num2));
			string str = string.Concat(string.Concat(text4 + text, Strings.Trim(jg.a(Conversion.Int(A_0[A_2 - 1] * 100.0 + 0.5) * num))), Strings.Trim(jg.a(Conversion.Int(A_1[A_2 - 1] * 100000.0 + 0.5) * num2)));
			int start = unchecked(r() % 4) + 1;
			text2 = Strings.Mid(str, start);
			double num4 = 0.0;
			int num5 = A_2 - 1;
			for (int num6 = 0; num6 <= num5; num6++)
			{
				num4 = num4 + Conversion.Int(A_0[num6] * 100.0 + 0.5) * num + Conversion.Int(A_1[num6] * 100000.0 + 0.5) * num2;
			}
			text3 = text2 + Strings.Trim(jg.a(num4));
			if (text3.Length > 31)
			{
				text3 = text3.Substring(0, 31);
			}
			return hh.b(ref text3);
		}
	}

	protected override void aw(ref StreamWriter A_0, double[] A_1, double[] A_2, int A_3)
	{
		A_0.WriteLine("\"" + t(A_1, A_2, A_3) + "\"");
	}

	protected override void ax(ref BinaryReader A_0, int A_1)
	{
		short num = 0;
		long offset = default(long);
		if (A_1 > 4)
		{
			offset = A_0.ReadInt64();
			num = A_0.ReadInt16();
			if (A_0.ReadInt16() > 13)
			{
				throw new ApplicationException("Incompatible File Format. Newer software version is required to read this file");
			}
		}
		this.co = A_1;
		this.m_cn = A_0.ReadString();
		int num2 = A_0.ReadInt32();
		this.m_bq = (b)num2;
		this.m_br = A_0.ReadSingle();
		this.m_bs = A_0.ReadInt32();
		int num3 = A_0.ReadInt32();
		this.m_bt = (FMLegacyAllSystemTypes)num3;
		this.m_bv = A_0.ReadString();
		this.m_bx = DateTime.FromBinary(A_0.ReadInt64());
		this.m_by = A_0.ReadString();
		this.m_bz = A_0.ReadString();
		if (num < 1)
		{
			return;
		}
		A_0.ReadBoolean();
		if (A_0.ReadBoolean())
		{
			this.m_cc = this.m_cc.i(new et());
			et obj = (et)this.m_cc.p();
			obj.t(A_0.ReadString());
			obj.t(A_0.ReadSingle());
			obj.u(A_0.ReadSingle());
			obj.v(A_0.ReadSingle());
			obj.x(A_0.ReadSingle());
			obj.y(A_0.ReadSingle());
			obj.u(A_0.ReadBoolean());
			obj.z(A_0.ReadSingle());
			obj.w(A_0.ReadSingle());
			obj.t(A_0.ReadBoolean());
			_ = null;
		}
		if (num >= 2)
		{
			this.m_cb = A_0.ReadBoolean();
			this.m_ca = A_0.ReadBoolean();
		}
		if (num >= 3)
		{
			double[] A_2 = cv();
			int A_3 = 0;
			r(ref A_2, ref A_3, A_0, A_3: true);
			r(A_2);
		}
		if (num >= 4)
		{
			this.m_ck = A_0.ReadBoolean();
			this.m_cl = A_0.ReadInt32();
			this.m_cm = A_0.ReadInt32();
			this.m_cj = true;
		}
		if (num >= 5 && A_0.ReadBoolean())
		{
			this.m_cu = new ej();
			this.m_cu.b(A_0);
		}
		checked
		{
			if (num >= 6)
			{
				this.m_cw = A_0.ReadSingle();
				int num4 = A_0.ReadInt32();
				this.m_cv = new Collection<hp>();
				int A_3 = num4 - 1;
				for (int num5 = 0; num5 <= A_3; num5++)
				{
					hp hp2 = new hp();
					hp2.q(A_0);
					r(hp2);
				}
			}
			if (num >= 7)
			{
				int num6 = A_0.ReadInt32();
				if (num6 == 0)
				{
					cx = null;
				}
				else
				{
					cx = new Collection<hn>();
					int num7 = num6 - 1;
					for (int num8 = 0; num8 <= num7; num8++)
					{
						hn hn2 = new hn(0, 0f, null, null, null);
						hn2.f(A_0);
						cx.Add(hn2);
					}
				}
			}
		}
		if (num >= 8)
		{
			this.m_cc = this.m_cc.l(A_0.ReadSingle());
			this.m_cc = this.m_cc.i((hl)checked((short)A_0.ReadInt32()));
		}
		if (num >= 9)
		{
			string A_4 = string.Empty;
			if (A_0.ReadBoolean())
			{
				this.m_cc = this.m_cc.i(new cf());
				if (this.m_cc.q().l(A_0, ref A_4) != global::cf.b.a)
				{
					throw new ApplicationException(A_4);
				}
			}
		}
		if (num >= 10)
		{
			ch = A_0.ReadBoolean();
			ci = A_0.ReadString();
			if (string.IsNullOrEmpty(ci))
			{
				ci = null;
			}
		}
		if (num >= 11)
		{
			if (A_0.ReadBoolean())
			{
				this.m_bw = eo.a.ao(A_0);
			}
			else
			{
				this.m_bw = null;
			}
		}
		if (num >= 12)
		{
			base.au = A_0.ReadDouble();
			base.av = A_0.ReadDouble();
		}
		if (num >= 13)
		{
			cy = A_0.ReadInt32();
			cz = A_0.ReadString();
		}
		if (A_1 > 4)
		{
			A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
		}
	}

	protected override void ay()
	{
		if (Operators.CompareString(this.m_cn, r(ref j, base.m, c2(), this.co), TextCompare: false) != 0)
		{
			throw new av("Invalid file format");
		}
	}

	public static void r(string A_0, ref hr A_1, ref bool A_2)
	{
		if (Operators.CompareString(A_0, "", TextCompare: false) != 0 && File.Exists(A_0))
		{
			A_1 = new hr(null);
			A_1.ag(ref A_0, null);
			A_2 = A_1.br() != null && A_1.br().Count > 0;
		}
		else
		{
			A_1 = null;
			A_2 = false;
		}
	}

	protected override bool az(int A_0)
	{
		return A_0 > 3;
	}

	protected override bool a0(int A_0)
	{
		return A_0 > 5;
	}

	public static bool r(string A_0)
	{
		return A_0.ToLower() switch
		{
			".spe" => true, 
			".fmspe" => true, 
			".csp" => true, 
			".fmcsp" => true, 
			".fmdmo" => true, 
			_ => false, 
		};
	}

	protected override fy a1()
	{
		return new hr(null);
	}

	public static hr r(string A_0, bool A_1, bool A_2, bool A_3, string A_4)
	{
		string text = Path.GetExtension(A_0).ToLower();
		hr hr2;
		switch (text)
		{
		case ".fmspe":
		case ".fmcsp":
		case ".fmdmo":
			if (A_1 && !A_3 && Operators.CompareString(text, ".fmdmo", TextCompare: false) != 0)
			{
				throw new aw("Unallowed file type");
			}
			hr2 = new hr(null);
			if (Operators.CompareString(text, ".fmcsp", TextCompare: false) == 0)
			{
				hr2.ak(A_0: true);
			}
			break;
		default:
			if (A_1 && !A_2 && Operators.CompareString(text, ".spe", TextCompare: false) != 0 && Operators.CompareString(text, ".csp", TextCompare: false) != 0)
			{
				throw new aw("Unallowed file type");
			}
			hr2 = new hr("Unknown", DateTime.Now, A_4, null);
			if (Operators.CompareString(text, ".csp", TextCompare: false) == 0)
			{
				hr2.ak(A_0: true);
			}
			break;
		}
		return hr2;
	}

	public override void ag(ref string A_0, string A_1)
	{
		r(ref A_0, null, 0);
	}

	public void r(ref string A_0, string A_1, int A_2)
	{
		string text = Path.GetExtension(A_0).ToLower();
		this.m_cj = false;
		base.am = Operators.CompareString(text, ".txt", TextCompare: false) == 0;
		r((double[])null);
		uint num = jo.a(text);
		if (num <= 2651941483u)
		{
			if (num <= 463227234)
			{
				if (num != 71852739)
				{
					if (num == 463227234 && Operators.CompareString(text, ".fmcsp", TextCompare: false) == 0)
					{
						this.m_b0 = a.i;
						base.ag(ref A_0, A_1);
						b0();
						goto IL_0296;
					}
				}
				else if (Operators.CompareString(text, ".txt", TextCompare: false) == 0)
				{
					goto IL_01a7;
				}
			}
			else if (num != 691233753)
			{
				if (num != 2106577580)
				{
					if (num == 2651941483u && Operators.CompareString(text, ".csv", TextCompare: false) == 0)
					{
						goto IL_01a7;
					}
				}
				else if (Operators.CompareString(text, ".fmdmo", TextCompare: false) == 0)
				{
					goto IL_01c7;
				}
			}
			else if (Operators.CompareString(text, ".rrr", TextCompare: false) == 0)
			{
				this.m_b0 = a.g;
				r(ref A_0, CultureInfo.InvariantCulture);
				b0();
				goto IL_0296;
			}
		}
		else
		{
			if (num <= 2878730003u)
			{
				if (num != 2752607197u)
				{
					if (num != 2878730003u || Operators.CompareString(text, ".spc", TextCompare: false) != 0)
					{
						goto IL_0280;
					}
					this.m_b0 = a.c;
					r(ref A_0, CultureInfo.InvariantCulture);
					b0();
				}
				else
				{
					if (Operators.CompareString(text, ".csp", TextCompare: false) != 0)
					{
						goto IL_0280;
					}
					this.m_b0 = a.h;
					r(ref A_0, CultureInfo.InvariantCulture);
					b0();
				}
				goto IL_0296;
			}
			if (num != 2979395717u)
			{
				if (num != 3633436050u)
				{
					if (num == 3861553530u && Operators.CompareString(text, ".dat", TextCompare: false) == 0)
					{
						this.m_b0 = a.j;
						r(ref A_0);
						b0();
						goto IL_0296;
					}
				}
				else if (Operators.CompareString(text, ".fmspe", TextCompare: false) == 0)
				{
					goto IL_01c7;
				}
			}
			else if (Operators.CompareString(text, ".spe", TextCompare: false) == 0)
			{
				this.m_b0 = a.b;
				r(ref A_0, CultureInfo.InvariantCulture);
				b0();
				goto IL_0296;
			}
		}
		goto IL_0280;
		IL_01c7:
		this.m_b0 = a.e;
		base.ag(ref A_0, A_1);
		b0();
		bool a_ = true;
		goto IL_0296;
		IL_0296:
		if (cv() == null)
		{
			r(c0());
		}
		if (!string.IsNullOrEmpty(A_1))
		{
			this.m_bz = A_1;
		}
		else
		{
			this.m_bz = Path.GetFileNameWithoutExtension(A_0);
		}
		if (base.t != null)
		{
			bl().ak(this.m_bz);
		}
		if (base.u != null)
		{
			foreach (hr item in bm())
			{
				item.ak(this.m_bz);
			}
		}
		r(a_);
		return;
		IL_01a7:
		this.m_b0 = a.d;
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		r(ref A_0, currentCulture);
		b0();
		goto IL_0296;
		IL_0280:
		throw new aw("File of type *." + text + " is not a valid spectrum file type.");
	}

	protected override void a2(ref StreamReader A_0, bool A_1, ref bool A_2, CultureInfo A_3)
	{
		string A_4 = string.Empty;
		string A_5 = string.Empty;
		int num;
		string text;
		bool flag;
		switch (this.m_b0)
		{
		case a.c:
		case a.d:
		case a.g:
			text = A_0.ReadLine();
			num = text.IndexOf(base.w);
			r(text, ref A_4, ref A_5);
			if (!string.IsNullOrEmpty(A_4))
			{
				this.m_cc = this.m_cc.l(Convert.ToSingle(A_4, A_3));
			}
			if (!string.IsNullOrEmpty(A_5))
			{
				this.m_cc = this.m_cc.i(this.m_cc.i(A_5));
			}
			goto IL_0207;
		case a.b:
		case a.h:
			text = A_0.ReadLine();
			text = A_0.ReadLine();
			this.m_b5 = text.ToString().Substring(1, checked(text.Length - 2));
			text = A_0.ReadLine();
			num = text.IndexOf(",");
			goto IL_0207;
		case a.j:
			text = A_0.ReadLine();
			text = A_0.ReadLine();
			if (!A_0.EndOfStream)
			{
				text = A_0.ReadLine();
				string[] array = Strings.Split(text, "\t");
				string text2 = array[0];
				A_4 = array[2];
				switch (text2)
				{
				case "uT":
					this.m_bq = b.j;
					break;
				case "uR":
					this.m_bq = b.c;
					break;
				case "pR":
					this.m_bq = b.c;
					A_5 = "tm";
					break;
				case "sR":
					this.m_bq = b.c;
					A_5 = "te";
					break;
				}
				if (!string.IsNullOrEmpty(A_4))
				{
					this.m_cc = this.m_cc.l(Convert.ToSingle(A_4, A_3));
				}
				if (!string.IsNullOrEmpty(A_5))
				{
					this.m_cc = this.m_cc.i(this.m_cc.i(A_5));
				}
				A_0.DiscardBufferedData();
				A_0.BaseStream.Seek(0L, SeekOrigin.Begin);
				text = A_0.ReadLine();
				text = A_0.ReadLine();
			}
			break;
		case a.e:
		case a.f:
		case a.i:
			break;
			IL_0207:
			if (num <= 0)
			{
				break;
			}
			flag = true;
			if (flag == (text.Contains("Raw Reflectance (counts)") || text.Contains("Raw Reflectance")))
			{
				this.m_bq = b.b;
			}
			else if (flag == text.Contains("Refl. + Trans."))
			{
				this.m_bq = b.m;
				if (text.Contains("%"))
				{
					A_2 = true;
				}
			}
			else if (flag == text.Contains("Reflectance"))
			{
				this.m_bq = b.c;
				if (text.Contains("%"))
				{
					A_2 = true;
				}
			}
			else if (flag == (text.Contains("Raw Transmittance (counts)") || text.Contains("Raw Transmittance")))
			{
				this.m_bq = b.k;
			}
			else if (flag == text.Contains("Transmittance"))
			{
				this.m_bq = b.j;
				if (text.Contains("%"))
				{
					A_2 = true;
				}
			}
			else if (flag == text.Contains("Raw CTM Signal (counts)"))
			{
				this.m_bq = b.o;
			}
			else if (flag == text.Contains("CTM Signal"))
			{
				this.m_bq = b.n;
			}
			else if (flag == text.Contains("Reading"))
			{
				this.m_bq = b.c;
			}
			else if (flag == text.Contains("Absorptance"))
			{
				this.m_bq = b.p;
				if (text.Contains("%"))
				{
					A_2 = true;
				}
			}
			else if (flag == text.Contains("Raw Signal (counts)"))
			{
				this.m_bq = b.q;
			}
			else if (flag == text.Contains("Signal (counts)"))
			{
				this.m_bq = b.r;
			}
			else if (this.m_b0 == a.g)
			{
				this.m_bq = b.c;
			}
			else
			{
				this.m_bq = b.a;
			}
			break;
		}
	}

	protected override void a3(double[] A_0)
	{
		if ((this.m_b0 == a.b || this.m_b0 == a.h) && Operators.CompareString(this.m_b5, t(j, A_0, c2()), TextCompare: false) != 0)
		{
			throw new av("Invalid file format");
		}
	}

	protected override void a4(ref BinaryReader A_0, int A_1, bool A_2)
	{
		r(A_0, A_1, A_2);
	}

	protected string r(ref double[] A_0, double[] A_1, int A_2, int A_3)
	{
		checked
		{
			if ((A_2 - 1 < 1) | (A_2 == 0))
			{
				string A_4 = "";
				return hh.b(ref A_4);
			}
			double num = 0.0;
			string A_5 = "";
			int num2 = A_2 - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				num += A_0[num3] + A_1[num3];
			}
			string text = ((float)(A_0[1] + A_1[1])).ToString(CultureInfo.InvariantCulture);
			string text2 = ((float)(A_0[A_2 - 1] + A_1[A_2 - 1])).ToString(CultureInfo.InvariantCulture);
			string text3 = Strings.Mid(text + text2, 2);
			string text4;
			if (A_3 == ak())
			{
				string A_4 = num.ToString(CultureInfo.InvariantCulture);
				text4 = hh.a(ref A_4);
			}
			else
			{
				string A_4 = num.ToString(CultureInfo.InvariantCulture);
				text4 = hh.b(ref A_4);
			}
			int num4 = Strings.Len(text4);
			if (Strings.Len(text3) < Strings.Len(text4))
			{
				num4 = Strings.Len(text3);
			}
			int num5 = num4;
			for (int num6 = 1; num6 <= num5; num6++)
			{
				A_5 += Conversions.ToString(Strings.Chr(Strings.Asc(Strings.Mid(text3, num6, 1)) + Strings.Asc(Strings.Mid(text4, num6, 1))));
			}
			if (A_3 == ak())
			{
				return hh.a(ref A_5);
			}
			return hh.b(ref A_5);
		}
	}

	public static void r(double[] A_0, long A_1, ref bool A_2, ref int A_3, ref int A_4)
	{
		double num = 653.289;
		double num2 = 659.289;
		checked
		{
			if (A_0[0] < 300.0)
			{
				A_2 = true;
				A_3 = 0;
				do
				{
					A_3++;
					if (A_3 + 1 >= A_1)
					{
						A_2 = false;
						return;
					}
				}
				while (A_0[A_3] < num);
				A_4 = A_3;
				do
				{
					A_4++;
					if (A_4 + 1 >= A_1)
					{
						A_2 = false;
						return;
					}
				}
				while (A_0[A_4] < num2);
				if (A_0[A_4] > num2)
				{
					A_4--;
				}
			}
			else
			{
				A_2 = false;
			}
		}
	}

	public static void r(int A_0, int A_1, double[] A_2, double[] A_3, int A_4, bool A_5)
	{
		if (A_0 < 1)
		{
			A_0 = 1;
		}
		checked
		{
			if (A_1 > A_4 - 2)
			{
				A_1 = A_4 - 2;
			}
			if (A_5)
			{
				int num = A_0;
				int num2 = A_1;
				for (int num3 = num; num3 <= num2; num3++)
				{
					double num4 = (A_2[num3] - A_2[A_0 - 1]) / (A_2[A_1 + 1] - A_2[A_0 - 1]);
					A_3[num3] = (float)(A_3[A_1 + 1] * num4 + A_3[A_0 - 1] * (1.0 - num4));
				}
			}
			else
			{
				int num5 = A_0;
				int num6 = A_1;
				for (int num3 = num5; num3 <= num6; num3++)
				{
					double num4 = (A_2[num3] - A_2[A_0 - 1]) / (A_2[A_1 + 1] - A_2[A_0 - 1]);
					A_3[num3] = A_3[A_1 + 1] * num4 + A_3[A_0 - 1] * (1.0 - num4);
				}
			}
		}
	}

	public static void r(double[] A_0, double[] A_1, int A_2, double[] A_3, double[] A_4, int A_5, ref int A_6, ref int A_7)
	{
		int num = 0;
		checked
		{
			int num2 = A_2 - 1;
			int num3 = A_5 - 1;
			for (; num < num2 && A_0[num] < A_3[0]; num++)
			{
			}
			A_6 = num;
			for (; num < num2 && A_0[num] < A_3[num3]; num++)
			{
			}
			if (num > 0 && A_0[num] > A_3[num3])
			{
				num--;
			}
			A_7 = num;
		}
	}

	public static double[] r(double[] A_0, double[] A_1, int A_2)
	{
		checked
		{
			double[] array = new double[A_2 - 1 + 1];
			int num = A_2 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				array[num2] = 1.0 - A_1[num2];
			}
			return array;
		}
	}

	public static void r(int A_0, int A_1, double[] A_2, double[] A_3, double[] A_4, double[] A_5, int A_6, ref double[] A_7, ref double[] A_8, ref int A_9)
	{
		checked
		{
			int num = A_1 - A_0;
			int num2 = A_6 - 1;
			A_9 = num + 1;
			A_8 = new double[num + 1];
			A_7 = new double[num + 1];
			int num3 = 0;
			for (int num4 = A_0; num4 <= A_1; num4++)
			{
				int num5 = num4 - A_0;
				A_7[num5] = A_2[num4];
				for (; num3 < num2 && A_4[num3] < A_2[num4]; num3++)
				{
				}
				if (jf.e(A_2[num4], A_4[num3]) || num3 == 0)
				{
					A_8[num5] = A_5[num3] + A_3[num4];
					continue;
				}
				double num6 = (A_2[num4] - A_4[num3 - 1]) / (A_4[num3] - A_4[num3 - 1]);
				A_8[num5] = (1.0 - num6) * A_5[num3 - 1] + num6 * A_5[num3] + A_3[num4];
			}
		}
	}

	public hr cw()
	{
		hr hr2 = new hr(j, this.m_b4.ToArray(), c0(), this.m_bq, this.m_br, this.m_bs, this.m_bt, this.m_bu, this.m_bv, this.m_bx, this.m_by, this.m_bz, this.m_b0, this.m_b1, this.m_b2, this.m_b3, this.m_b8, this.m_b9, this.m_cn, this.m_ca, this.m_cb, this.m_ck, this.m_cl, this.m_cm, this.m_cu, cy, cz, this.m_bw);
		hr2.r(this.m_b6);
		hr2.t(this.m_b7);
		hr2.r(this.m_cc);
		hr2.m_bw = this.m_bw;
		hr2.r(this.m_cv);
		hr2.r(cv());
		hr2.cf = cf;
		hr2.cg = cg;
		hr2.ch = ch;
		hr2.ci = ci;
		if (cx != null)
		{
			hr2.r(new Collection<hn>());
			foreach (hn item in cx)
			{
				hr2.bs().Add(item.f());
			}
		}
		((fy)hr2).au = base.au;
		((fy)hr2).av = base.av;
		if (bl() != null)
		{
			hr2.r(bl().cw());
		}
		hr2.cx();
		if (c4() != null)
		{
			foreach (hr item2 in bm())
			{
				hr2.r((fy)item2.cw());
			}
		}
		return hr2;
	}
}
