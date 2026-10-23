using System;
using System.IO;
using System.Runtime.CompilerServices;
using FIUsbIntLib;
using Microsoft.VisualBasic.CompilerServices;

internal class g2
{
	public enum a
	{
		a = -3,
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
		n
	}

	public enum b
	{
		a,
		b
	}

	internal enum OpticsConfigSubmoduleTypes
	{
		Unknown = -1,
		ReflectanceProbe,
		Transmittance,
		MSReflectance,
		MSTransmittance,
		ContactProbeHandHeld,
		ContactProbeHandHeldAutoRef,
		ContactStage,
		ContactStageAutoRef,
		SplitterProbe,
		CTMProbe,
		TransCurved,
		NumConfigurations
	}

	internal enum c
	{
		a,
		b,
		c
	}

	private const string m_a = "ReflectanceProbe";

	private const string m_b = "Transmittance";

	private const string m_c = "MSReflectance";

	private const string m_d = "MSTransmittance";

	private const string e = "ContactProbeHandHeld";

	private const string f = "ContactProbeHandHeld AutoBaseline";

	private const string g = "ContactStage";

	private const string h = "ContactStage AutoBaseline";

	private const string i = "SplitterProbe";

	private const string m_j = "CTMProbe";

	private const string m_k = "TransCurvedStage";

	private const string m_l = "Unknown";

	private const string m_m = "Undefined";

	private const short m_n = 3;

	private const string m_o = "__Version includes a version number__***";

	private a m_p;

	private string m_q;

	private es m_r;

	private cf m_s;

	private bool t;

	private string u;

	private bool v;

	internal string w;

	internal bool x;

	internal bool y;

	internal bool z;

	internal bool aa;

	[SpecialName]
	public static string n(a A_0)
	{
		return A_0 switch
		{
			g2.a.a => "Unknown", 
			g2.a.b => "ReflectanceAndTransmittanceAutoRef", 
			g2.a.c => "ReflectanceAndTransmittance", 
			g2.a.d => "ReflectanceProbe", 
			g2.a.e => "Transmittance", 
			g2.a.f => "MSReflectance", 
			g2.a.g => "MSTransmittance", 
			g2.a.h => "ContactProbe", 
			g2.a.i => "ContactProbe AutoBaseline", 
			g2.a.j => "ContactStage", 
			g2.a.k => "ContactStage AutoBaseline", 
			g2.a.l => "SplitterProbe", 
			g2.a.m => "CTMProbe", 
			g2.a.n => "TransCurved", 
			_ => "Undefined", 
		};
	}

	[SpecialName]
	public string a()
	{
		return m(this.m_p);
	}

	[SpecialName]
	public static string c(FMOpticConfigEnums A_0)
	{
		return m(a(A_0));
	}

	[SpecialName]
	public static string m(a A_0)
	{
		return A_0 switch
		{
			g2.a.a => "Unknown", 
			g2.a.b => "R & T AutoBaseline", 
			g2.a.c => "Refl. & Trans.", 
			g2.a.d => "Refl. Probe", 
			g2.a.e => "Trans.", 
			g2.a.f => "MS Refl.", 
			g2.a.g => "MS Trans.", 
			g2.a.h => "C. Probe", 
			g2.a.i => "C. Probe AutoBaseline", 
			g2.a.j => "C. Stage", 
			g2.a.k => "C. Stage AutoBaseline", 
			g2.a.l => "Splitter Probe", 
			g2.a.m => "CTM Probe", 
			g2.a.n => "TransCurved", 
			_ => "Undefined", 
		};
	}

	public static string o(OpticsConfigSubmoduleTypes A_0)
	{
		return A_0 switch
		{
			OpticsConfigSubmoduleTypes.ReflectanceProbe => "ReflectanceProbe", 
			OpticsConfigSubmoduleTypes.Transmittance => "Transmittance", 
			OpticsConfigSubmoduleTypes.MSReflectance => "MSReflectance", 
			OpticsConfigSubmoduleTypes.MSTransmittance => "MSTransmittance", 
			OpticsConfigSubmoduleTypes.ContactProbeHandHeld => "ContactProbeHandHeld", 
			OpticsConfigSubmoduleTypes.ContactProbeHandHeldAutoRef => "ContactProbeHandHeld AutoBaseline", 
			OpticsConfigSubmoduleTypes.ContactStage => "ContactStage", 
			OpticsConfigSubmoduleTypes.ContactStageAutoRef => "ContactStage AutoBaseline", 
			OpticsConfigSubmoduleTypes.SplitterProbe => "SplitterProbe", 
			OpticsConfigSubmoduleTypes.CTMProbe => "CTMProbe", 
			OpticsConfigSubmoduleTypes.TransCurved => "TransCurvedStage", 
			_ => "Undefined", 
		};
	}

	public static OpticsConfigSubmoduleTypes a(string A_0)
	{
		switch (jo.a(A_0))
		{
		case 3820560873u:
			if (Operators.CompareString(A_0, "ReflectanceProbe", TextCompare: false) != 0)
			{
				break;
			}
			return OpticsConfigSubmoduleTypes.ReflectanceProbe;
		case 177406640u:
			if (Operators.CompareString(A_0, "Transmittance", TextCompare: false) != 0)
			{
				break;
			}
			return OpticsConfigSubmoduleTypes.Transmittance;
		case 68662729u:
			if (Operators.CompareString(A_0, "MSReflectance", TextCompare: false) != 0)
			{
				break;
			}
			return OpticsConfigSubmoduleTypes.MSReflectance;
		case 3924262636u:
			if (Operators.CompareString(A_0, "MSTransmittance", TextCompare: false) != 0)
			{
				break;
			}
			return OpticsConfigSubmoduleTypes.MSTransmittance;
		case 289461597u:
			if (Operators.CompareString(A_0, "ContactProbeHandHeld", TextCompare: false) != 0)
			{
				break;
			}
			return OpticsConfigSubmoduleTypes.ContactProbeHandHeld;
		case 200111275u:
			if (Operators.CompareString(A_0, "ContactProbeHandHeld AutoBaseline", TextCompare: false) != 0)
			{
				break;
			}
			return OpticsConfigSubmoduleTypes.ContactProbeHandHeldAutoRef;
		case 2018794095u:
			if (Operators.CompareString(A_0, "ContactStage", TextCompare: false) != 0)
			{
				break;
			}
			return OpticsConfigSubmoduleTypes.ContactStage;
		case 3765484777u:
			if (Operators.CompareString(A_0, "ContactStage AutoBaseline", TextCompare: false) != 0)
			{
				break;
			}
			return OpticsConfigSubmoduleTypes.ContactProbeHandHeldAutoRef;
		case 698312u:
			if (Operators.CompareString(A_0, "SplitterProbe", TextCompare: false) != 0)
			{
				break;
			}
			return OpticsConfigSubmoduleTypes.SplitterProbe;
		case 2529507321u:
			if (Operators.CompareString(A_0, "CTMProbe", TextCompare: false) != 0)
			{
				break;
			}
			return OpticsConfigSubmoduleTypes.CTMProbe;
		case 1651135466u:
			if (Operators.CompareString(A_0, "TransCurvedStage", TextCompare: false) != 0)
			{
				break;
			}
			return OpticsConfigSubmoduleTypes.TransCurved;
		}
		return OpticsConfigSubmoduleTypes.Unknown;
	}

	public static a a(FMOpticConfigEnums A_0)
	{
		bool A_1 = false;
		bool A_2 = false;
		return a(A_0, ref A_1, ref A_2);
	}

	public static a a(FMOpticConfigEnums A_0, ref bool A_1, ref bool A_2)
	{
		A_1 = true;
		A_2 = true;
		switch (A_0)
		{
		case FMOpticConfigEnums.kFMOpticConfigCP:
			A_1 = false;
			return g2.a.h;
		case FMOpticConfigEnums.kFMOpticConfigCPAutoBase:
			return g2.a.i;
		case FMOpticConfigEnums.kFMOpticConfigCS:
			A_2 = false;
			return g2.a.j;
		case FMOpticConfigEnums.kFMOpticConfigCSAutoBase:
			return g2.a.k;
		case FMOpticConfigEnums.kFMOpticConfigMicroscopeR:
			return g2.a.f;
		case FMOpticConfigEnums.kFMOpticConfigMicroscopeT:
			return g2.a.g;
		case FMOpticConfigEnums.kFMOpticConfigRPStage:
			return g2.a.d;
		case FMOpticConfigEnums.kFMOpticConfigTransStage:
			return g2.a.e;
		case FMOpticConfigEnums.kFMOpticConfigCTMProbe:
			return g2.a.m;
		case FMOpticConfigEnums.kFMOpticConfigTransCurved:
			return g2.a.n;
		default:
			return g2.a.a;
		}
	}

	public void d(FMOpticConfigEnums A_0)
	{
		o(a(A_0, ref y, ref z));
		if (c() == g2.a.a)
		{
			o(g2.a.d);
		}
	}

	public static float n(OpticsConfigSubmoduleTypes A_0)
	{
		switch (A_0)
		{
		case OpticsConfigSubmoduleTypes.Unknown:
			return 0.5f;
		case OpticsConfigSubmoduleTypes.ReflectanceProbe:
		case OpticsConfigSubmoduleTypes.Transmittance:
		case OpticsConfigSubmoduleTypes.MSReflectance:
		case OpticsConfigSubmoduleTypes.MSTransmittance:
			return 0.5f;
		case OpticsConfigSubmoduleTypes.ContactProbeHandHeld:
			return 5f;
		case OpticsConfigSubmoduleTypes.ContactProbeHandHeldAutoRef:
			return 1f;
		case OpticsConfigSubmoduleTypes.ContactStage:
			return 0.5f;
		case OpticsConfigSubmoduleTypes.ContactStageAutoRef:
			return 0.5f;
		case OpticsConfigSubmoduleTypes.SplitterProbe:
			return 0.5f;
		default:
			return 0.5f;
		}
	}

	[SpecialName]
	public a c()
	{
		return this.m_p;
	}

	[SpecialName]
	public void o(a A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	public bool d()
	{
		if (this.m_p == g2.a.a)
		{
			return true;
		}
		foreach (object value in Enum.GetValues(typeof(a)))
		{
			a a10 = (a)Conversions.ToInteger(value);
			if (this.m_p == a10)
			{
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	public string j()
	{
		return this.m_q;
	}

	[SpecialName]
	public void c(string A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	public string k()
	{
		return u;
	}

	[SpecialName]
	public void d(string A_0)
	{
		u = A_0;
	}

	[SpecialName]
	public bool l()
	{
		return v;
	}

	[SpecialName]
	public void a(bool A_0)
	{
		v = A_0;
	}

	internal static c l(a A_0)
	{
		switch (A_0)
		{
		case g2.a.d:
		case g2.a.f:
		case g2.a.h:
		case g2.a.i:
		case g2.a.j:
		case g2.a.k:
		case g2.a.l:
		case g2.a.m:
			return g2.c.a;
		case g2.a.e:
		case g2.a.g:
		case g2.a.n:
			return g2.c.b;
		case g2.a.b:
		case g2.a.c:
			return g2.c.c;
		default:
			throw new ArgumentOutOfRangeException("Invalid system configuration");
		}
	}

	internal static bool j(a A_0, h.f A_1)
	{
		return m(a(A_0, A_1));
	}

	internal static bool m(OpticsConfigSubmoduleTypes A_0)
	{
		if (A_0 != OpticsConfigSubmoduleTypes.ContactProbeHandHeld && A_0 != OpticsConfigSubmoduleTypes.ContactProbeHandHeldAutoRef && A_0 != OpticsConfigSubmoduleTypes.ContactStage && A_0 != OpticsConfigSubmoduleTypes.ContactStageAutoRef && A_0 != OpticsConfigSubmoduleTypes.MSReflectance && A_0 != OpticsConfigSubmoduleTypes.ReflectanceProbe)
		{
			return A_0 == OpticsConfigSubmoduleTypes.SplitterProbe;
		}
		return true;
	}

	internal bool a(h.f A_0)
	{
		return d(this.m_p, A_0);
	}

	internal static bool d(a A_0, h.f A_1)
	{
		return l(a(A_0, A_1));
	}

	internal static bool l(OpticsConfigSubmoduleTypes A_0)
	{
		if (A_0 != OpticsConfigSubmoduleTypes.MSTransmittance && A_0 != OpticsConfigSubmoduleTypes.Transmittance)
		{
			return A_0 == OpticsConfigSubmoduleTypes.TransCurved;
		}
		return true;
	}

	internal bool c(h.f A_0)
	{
		return c(this.m_p, A_0);
	}

	internal static bool c(a A_0, h.f A_1)
	{
		return k(a(A_0, A_1));
	}

	internal static bool k(OpticsConfigSubmoduleTypes A_0)
	{
		return A_0 == OpticsConfigSubmoduleTypes.CTMProbe;
	}

	internal static ex.a j(OpticsConfigSubmoduleTypes A_0)
	{
		if (l(A_0))
		{
			return ex.a.b;
		}
		return ex.a.a;
	}

	internal g2()
	{
		x = true;
		aa = true;
		this.m_p = g2.a.d;
		t = false;
		v = false;
	}

	internal g2(a A_0)
		: this()
	{
		this.m_p = A_0;
	}

	internal g2(a A_0, string A_1)
		: this()
	{
		this.m_p = A_0;
		w = A_1;
	}

	internal bool m()
	{
		return k(this.m_p);
	}

	internal static bool k(a A_0)
	{
		return d(a(A_0, global::h.f.a));
	}

	internal static bool d(OpticsConfigSubmoduleTypes A_0)
	{
		if (A_0 != OpticsConfigSubmoduleTypes.ContactProbeHandHeld)
		{
			return A_0 == OpticsConfigSubmoduleTypes.ContactProbeHandHeldAutoRef;
		}
		return true;
	}

	internal bool n()
	{
		return j(this.m_p);
	}

	internal static bool j(a A_0)
	{
		if (A_0 != g2.a.b)
		{
			return c(a(A_0, global::h.f.a));
		}
		return true;
	}

	internal static bool c(OpticsConfigSubmoduleTypes A_0)
	{
		if (A_0 != OpticsConfigSubmoduleTypes.ContactProbeHandHeldAutoRef)
		{
			return A_0 == OpticsConfigSubmoduleTypes.ContactStageAutoRef;
		}
		return true;
	}

	internal bool o()
	{
		return d(this.m_p);
	}

	internal static bool d(a A_0)
	{
		return a(a(A_0, global::h.f.a));
	}

	internal static bool a(OpticsConfigSubmoduleTypes A_0)
	{
		if (A_0 != OpticsConfigSubmoduleTypes.ContactProbeHandHeldAutoRef && A_0 != OpticsConfigSubmoduleTypes.ContactProbeHandHeld)
		{
			return A_0 == OpticsConfigSubmoduleTypes.ContactStageAutoRef;
		}
		return true;
	}

	internal bool p()
	{
		return c(this.m_p);
	}

	internal static bool c(a A_0)
	{
		if (A_0 != g2.a.f)
		{
			return A_0 == g2.a.g;
		}
		return true;
	}

	internal bool q()
	{
		return a(this.m_p);
	}

	internal static bool a(a A_0)
	{
		return A_0 == g2.a.m;
	}

	[SpecialName]
	internal es r()
	{
		return this.m_r;
	}

	[SpecialName]
	internal void a(es A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	internal cf s()
	{
		return this.m_s;
	}

	[SpecialName]
	internal void a(cf A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	internal OpticsConfigSubmoduleTypes d(h.f A_0)
	{
		return a(this.m_p, A_0);
	}

	[SpecialName]
	internal static OpticsConfigSubmoduleTypes a(a A_0, h.f A_1)
	{
		switch (A_0)
		{
		case g2.a.b:
		case g2.a.c:
			switch (A_1)
			{
			case global::h.f.a:
			case global::h.f.c:
				return OpticsConfigSubmoduleTypes.ReflectanceProbe;
			case global::h.f.b:
				return OpticsConfigSubmoduleTypes.Transmittance;
			default:
				throw new ArgumentOutOfRangeException("Invalid subSysType");
			}
		case g2.a.d:
			return OpticsConfigSubmoduleTypes.ReflectanceProbe;
		case g2.a.e:
			return OpticsConfigSubmoduleTypes.Transmittance;
		case g2.a.f:
			return OpticsConfigSubmoduleTypes.MSReflectance;
		case g2.a.g:
			return OpticsConfigSubmoduleTypes.MSTransmittance;
		case g2.a.h:
			return OpticsConfigSubmoduleTypes.ContactProbeHandHeld;
		case g2.a.i:
			return OpticsConfigSubmoduleTypes.ContactProbeHandHeldAutoRef;
		case g2.a.j:
			return OpticsConfigSubmoduleTypes.ContactStage;
		case g2.a.k:
			return OpticsConfigSubmoduleTypes.ContactStageAutoRef;
		case g2.a.m:
			return OpticsConfigSubmoduleTypes.CTMProbe;
		case g2.a.n:
			return OpticsConfigSubmoduleTypes.TransCurved;
		default:
			throw new ArgumentOutOfRangeException("Invalid systemConfig");
		}
	}

	internal void a(BinaryWriter A_0)
	{
		A_0.Write("__Version includes a version number__***");
		A_0.Write((short)3);
		A_0.Write((short)2);
		long position = A_0.BaseStream.Position;
		A_0.Write(position);
		string value = "Nothing";
		if (w == null)
		{
			A_0.Write(value);
		}
		else
		{
			A_0.Write(w);
		}
		A_0.Write((int)this.m_p);
		A_0.Write(x);
		A_0.Write(y);
		A_0.Write(z);
		A_0.Write(aa);
		if (this.m_r == null)
		{
			A_0.Write(value: false);
		}
		else
		{
			A_0.Write(value: true);
			this.m_r.x(A_0);
		}
		if (this.m_s == null || this.m_p != g2.a.m)
		{
			A_0.Write(value: false);
		}
		else
		{
			A_0.Write(value: true);
			this.m_s.l(A_0, 1, A_2: true);
		}
		if (string.IsNullOrEmpty(j()))
		{
			A_0.Write(value: false);
		}
		else
		{
			A_0.Write(value: true);
			A_0.Write(this.m_q);
		}
		long position2 = A_0.BaseStream.Position;
		A_0.BaseStream.Seek(position, SeekOrigin.Begin);
		A_0.Write(position2);
		A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
	}

	internal int a(BinaryReader A_0)
	{
		short num = 1;
		string left = A_0.ReadString();
		long offset = default(long);
		if (Operators.CompareString(left, "__Version includes a version number__***", TextCompare: false) == 0)
		{
			num = A_0.ReadInt16();
			if (A_0.ReadInt16() > 3)
			{
				return -1;
			}
			if (num > 2)
			{
				offset = A_0.ReadInt64();
			}
			w = A_0.ReadString();
		}
		else
		{
			w = left;
		}
		if (Operators.CompareString(w, "Nothing", TextCompare: false) == 0)
		{
			w = null;
		}
		this.m_p = (a)A_0.ReadInt32();
		x = A_0.ReadBoolean();
		y = A_0.ReadBoolean();
		z = A_0.ReadBoolean();
		aa = A_0.ReadBoolean();
		if (A_0.ReadBoolean())
		{
			this.m_r = new et();
			this.m_r.aa(A_0);
		}
		if (this.m_p != g2.a.f && this.m_p != g2.a.g)
		{
			this.m_r = null;
		}
		if (num > 1 && A_0.ReadBoolean())
		{
			this.m_s = new cf();
			cf obj = this.m_s;
			string A_1 = null;
			if (obj.l(A_0, ref A_1) != cf.b.a)
			{
				this.m_s = null;
			}
			if (this.m_p != g2.a.m)
			{
				this.m_s = null;
			}
		}
		if (num > 2)
		{
			if (A_0.ReadBoolean())
			{
				this.m_q = A_0.ReadString();
			}
			else
			{
				this.m_q = null;
			}
			A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
		}
		return 0;
	}

	internal void a(ref g2 A_0)
	{
		if (this != A_0)
		{
			if (A_0 == null)
			{
				A_0 = new g2();
			}
			if (this.m_r != null)
			{
				A_0.a(new et());
				this.m_r.ad(A_0.r());
			}
			else
			{
				A_0.a((es)null);
			}
			A_0.a(this.m_s);
			A_0.o(this.m_p);
			A_0.c(this.m_q);
			A_0.w = w;
			A_0.x = x;
			A_0.y = y;
			A_0.z = z;
			A_0.aa = aa;
			A_0.d(u);
			A_0.a(v);
		}
	}

	[SpecialName]
	public static bool c(g2 A_0, g2 A_1)
	{
		switch (ix.a(A_0, A_1))
		{
		case ix.a.a:
			return false;
		case ix.a.b:
			return true;
		default:
		{
			g2 g10 = A_0;
			if (g10.c() != A_1.c())
			{
				return true;
			}
			if (Operators.CompareString(g10.j(), A_1.j(), TextCompare: false) != 0)
			{
				return true;
			}
			if (Operators.CompareString(g10.w, A_1.w, TextCompare: false) != 0)
			{
				return true;
			}
			if (g10.x != A_1.x)
			{
				return true;
			}
			if (g10.y != A_1.y)
			{
				return true;
			}
			if (g10.z != A_1.z)
			{
				return true;
			}
			if (g10.aa != A_1.aa)
			{
				return true;
			}
			if (Operators.CompareString(g10.k(), A_1.k(), TextCompare: false) != 0)
			{
				return true;
			}
			if (g10.l() != A_1.l())
			{
				return true;
			}
			if (et.u((et)g10.r(), (et)A_1.r()))
			{
				return true;
			}
			if (cf.n(g10.s(), A_1.s()))
			{
				return true;
			}
			g10 = null;
			return false;
		}
		}
	}

	[SpecialName]
	public static bool a(g2 A_0, g2 A_1)
	{
		return !c(A_0, A_1);
	}

	public bool a(g2 A_0)
	{
		return a(this, A_0);
	}
}
