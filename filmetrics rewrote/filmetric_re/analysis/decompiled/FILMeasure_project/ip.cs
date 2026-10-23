using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FIUsbIntLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class ip : io, IDisposable
{
	internal new class a
	{
		private FMLegacyAllSystemTypes m_a;

		private string b;

		private string c;

		private string d;

		private string e;

		private float f;

		private float g;

		private int h;

		private FMUSBDeviceType i;

		private bool j;

		public const string k = "-UV";

		public const string l = "-UVX";

		public const string m = "-EXR";

		public a(ip A_0)
			: this(A_0.b(), A_0.yq(), A_0.uq(), A_0.abo(), A_0.abk().SerialNumber, A_0.vu(), A_0.vv(), A_0.us(), A_0.xs(), A_0.yb())
		{
		}

		public a(FMLegacyAllSystemTypes A_0, string A_1, string A_2, string A_3, string A_4, float A_5, float A_6, int A_7, FMUSBDeviceType A_8, bool A_9)
		{
			m_a = A_0;
			c = A_2;
			b = A_1;
			d = A_3;
			e = A_4;
			f = A_5;
			g = A_6;
			h = A_7;
			i = A_8;
			j = A_9;
		}

		[SpecialName]
		public FMLegacyAllSystemTypes l()
		{
			return m_a;
		}

		[SpecialName]
		public string m()
		{
			return c;
		}

		[SpecialName]
		public string n()
		{
			return b;
		}

		[SpecialName]
		public string o()
		{
			return d;
		}

		[SpecialName]
		public string p()
		{
			return e;
		}

		[SpecialName]
		public float q()
		{
			return f;
		}

		[SpecialName]
		public float r()
		{
			return g;
		}

		[SpecialName]
		public int s()
		{
			return h;
		}

		[SpecialName]
		public FMUSBDeviceType t()
		{
			return i;
		}

		[SpecialName]
		public bool u()
		{
			if (m_a != FMLegacyAllSystemTypes.kTypeF10 && m_a != FMLegacyAllSystemTypes.kTypeF2)
			{
				return m_a == FMLegacyAllSystemTypes.kTypePARTS;
			}
			return true;
		}

		[SpecialName]
		public bool v()
		{
			return j;
		}

		public string w()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(h6.p9(m_a));
			stringBuilder.Append(" - ");
			stringBuilder.Append(d);
			stringBuilder.Append(", Spec #");
			stringBuilder.Append(checked(h + 1));
			stringBuilder.Append(" (");
			stringBuilder.Append(Math.Ceiling(f));
			stringBuilder.Append("-");
			stringBuilder.Append(Math.Floor(g));
			stringBuilder.Append(" nm)");
			return stringBuilder.ToString();
		}

		public void l(a A_0)
		{
			A_0.m_a = m_a;
			A_0.c = c;
			A_0.b = b;
			A_0.d = d;
			A_0.e = e;
			A_0.f = f;
			A_0.g = g;
			A_0.h = h;
			A_0.i = i;
			A_0.j = j;
		}
	}

	private new class b
	{
		private bool[] a;

		private bool[] m_b;

		private g2.OpticsConfigSubmoduleTypes c;

		private double d;

		private global::h.MeasurementTimingType e;

		private double f;

		private int g;

		public b()
		{
			a = new bool[11];
			m_b = new bool[11];
			int num = 0;
			do
			{
				a[num] = false;
				m_b[num] = false;
				num = checked(num + 1);
			}
			while (num <= 10);
		}

		private b j()
		{
			return (b)MemberwiseClone();
		}

		public b j(g2.OpticsConfigSubmoduleTypes A_0)
		{
			b obj = j();
			obj.k(A_0);
			return obj;
		}

		[SpecialName]
		public g2.OpticsConfigSubmoduleTypes k()
		{
			return c;
		}

		protected void k(g2.OpticsConfigSubmoduleTypes A_0)
		{
			c = A_0;
		}

		public b j(ref bool A_0, ref bool A_1)
		{
			b obj = j();
			obj.k(ref A_0, ref A_1);
			return obj;
		}

		public b j(ref bool A_0)
		{
			b obj = j();
			obj.k(ref A_0);
			return obj;
		}

		[SpecialName]
		public bool l()
		{
			return m_b[(int)c];
		}

		[SpecialName]
		public bool m()
		{
			return a[(int)c];
		}

		protected void k(ref bool A_0, ref bool A_1)
		{
			m_b[(int)c] = A_0;
			a[(int)c] = A_1;
		}

		protected void k(ref bool A_0)
		{
			m_b[9] = A_0;
		}

		public b j(ref bool[] A_0, ref bool[] A_1)
		{
			b obj = j();
			obj.k(ref A_0, ref A_1);
			return obj;
		}

		[SpecialName]
		public bool[] n()
		{
			return m_b;
		}

		[SpecialName]
		public bool[] o()
		{
			return a;
		}

		protected void k(ref bool[] A_0, ref bool[] A_1)
		{
			m_b = A_0;
			a = A_1;
		}

		public b j(ref double A_0, ref short A_1, double A_2, global::h.MeasurementTimingType A_3)
		{
			b obj = j();
			obj.k(ref A_0, ref A_1, A_2, A_3);
			return obj;
		}

		[SpecialName]
		public double p()
		{
			return f;
		}

		[SpecialName]
		public int q()
		{
			return g;
		}

		[SpecialName]
		public double r()
		{
			return d;
		}

		[SpecialName]
		public global::h.MeasurementTimingType s()
		{
			return e;
		}

		protected void k(ref double A_0, ref short A_1, double A_2, global::h.MeasurementTimingType A_3)
		{
			f = A_0;
			g = A_1;
			d = A_2;
			e = A_3;
		}
	}

	private new class c
	{
		private float[] a;

		private float[] b;

		private float[] c;

		private float[] d;

		private float[] e;

		private float[] f;

		private float[] g;

		private float[] h;

		public bool i;

		public double j;

		public double k;

		public int l;

		public int m;

		public DateTime n;

		public string o;

		public bool p;

		public ej q;

		public bool r;

		public bool s;

		private const int t = 4;

		[SpecialName]
		public bool u()
		{
			return a != null;
		}

		[SpecialName]
		public float[] v()
		{
			return a;
		}

		[SpecialName]
		public void u(float[] A_0)
		{
			a = A_0;
		}

		[SpecialName]
		public float[] w()
		{
			return b;
		}

		[SpecialName]
		public void v(float[] A_0)
		{
			b = A_0;
		}

		[SpecialName]
		public float[] x()
		{
			return c;
		}

		[SpecialName]
		public void w(float[] A_0)
		{
			c = A_0;
		}

		[SpecialName]
		public float[] y()
		{
			return d;
		}

		[SpecialName]
		public void x(float[] A_0)
		{
			d = A_0;
		}

		[SpecialName]
		public float[] z()
		{
			return e;
		}

		[SpecialName]
		public void y(float[] A_0)
		{
			e = A_0;
		}

		[SpecialName]
		public float[] aa()
		{
			return f;
		}

		[SpecialName]
		public void z(float[] A_0)
		{
			f = A_0;
		}

		[SpecialName]
		public float[] ab()
		{
			return g;
		}

		[SpecialName]
		public void aa(float[] A_0)
		{
			g = A_0;
		}

		[SpecialName]
		public float[] ac()
		{
			return h;
		}

		[SpecialName]
		public void ab(float[] A_0)
		{
			h = A_0;
		}

		public void ad()
		{
			a = null;
			b = null;
			c = null;
			j = 0.0;
			k = 0.0;
		}

		public void ae()
		{
			d = null;
			e = null;
			f = null;
			s = false;
			r = false;
		}

		public static void u(c A_0, bool A_1, BinaryWriter A_2)
		{
			if (A_0 == null)
			{
				A_2.Write(value: false);
				return;
			}
			A_2.Write(value: true);
			A_0.u(A_2, A_1);
		}

		public void u(BinaryWriter A_0, bool A_1)
		{
			long position = A_0.BaseStream.Position;
			A_0.Write(position);
			A_0.Write(4);
			A_0.Write(1);
			i3.a(a, A_0);
			i3.a(b, A_0);
			i3.a(c, A_0);
			A_0.Write(n.Ticks);
			A_0.Write(A_1);
			if (!A_1)
			{
				i3.a(g, A_0);
				i3.a(h, A_0);
				A_0.Write(i);
				A_0.Write(j);
				if (string.IsNullOrEmpty(o))
				{
					o = string.Empty;
				}
				A_0.Write(o);
				A_0.Write(p);
				if (q != null)
				{
					A_0.Write(value: true);
					q.a(A_0);
				}
				else
				{
					A_0.Write(value: false);
				}
				A_0.Write(l);
				A_0.Write(k);
				A_0.Write(m);
			}
			i3.a(d, A_0);
			i3.a(e, A_0);
			i3.a(f, A_0);
			A_0.Write(r);
			A_0.Write(s);
			long position2 = A_0.BaseStream.Position;
			A_0.BaseStream.Seek(position, SeekOrigin.Begin);
			A_0.Write(position2);
			A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
		}

		public static c u(BinaryReader A_0)
		{
			if (A_0.ReadBoolean())
			{
				c obj = new c();
				obj.v(A_0);
				return obj;
			}
			return null;
		}

		public void v(BinaryReader A_0)
		{
			int num = 0;
			int num2 = 0;
			long offset = A_0.ReadInt64();
			num2 = A_0.ReadInt32();
			num = A_0.ReadInt32();
			if (num <= 4)
			{
				i3.a(ref a, A_0);
				i3.a(ref b, A_0);
				i3.a(ref c, A_0);
				long ticks = A_0.ReadInt64();
				n = new DateTime(ticks);
				if (!A_0.ReadBoolean())
				{
					i3.a(ref g, A_0);
					i3.a(ref h, A_0);
					i = A_0.ReadBoolean();
					j = A_0.ReadDouble();
					o = A_0.ReadString();
					p = A_0.ReadBoolean();
					if (A_0.ReadBoolean())
					{
						if (q == null)
						{
							q = new ej();
						}
						q.b(A_0);
					}
					else
					{
						q = null;
					}
					if (num2 > 1)
					{
						l = A_0.ReadInt32();
					}
					else
					{
						l = -1;
					}
					if (num2 > 2)
					{
						k = A_0.ReadDouble();
						m = A_0.ReadInt32();
					}
					else
					{
						k = j;
						m = l;
					}
				}
				if (num2 > 3)
				{
					i3.a(ref d, A_0);
					i3.a(ref e, A_0);
					i3.a(ref f, A_0);
					r = A_0.ReadBoolean();
					s = A_0.ReadBoolean();
				}
				else
				{
					ae();
				}
				A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
				return;
			}
			throw new au("ReferenceData maximum compatible block file version is " + 4 + " compatible version in file we are attempting to read is " + num);
		}
	}

	public new class d : h6.a
	{
		public float cb;

		public float cc;

		public float cd;

		public float ce;

		public float cf;

		public float cg;

		public float ch;

		public float ci;

		public float cj;

		public float ck;

		public float cl;

		public float cm;

		public float cn;

		public float co;

		public int cp;

		public bool cq;

		public bool cr;

		public bool cs;

		public bool ct;

		public f cu;

		public int cv;

		public float cw;

		public float cx;

		public l cy;

		public short cz;

		public short c0;

		public short c1;

		public short c2;

		public float c3;

		public float c4;

		public float c5;

		public n c6;

		public g c7;

		public bool c8;

		public bool c9;

		public float da;

		public float db;

		public float dc;

		public float dd;

		public float de;

		public float df;

		public d()
		{
			cu = new f();
			cy = new l();
			c6 = new n();
		}
	}

	public new class e
	{
		public string a;

		public string b;

		public bool c;

		public bool d;

		public bool e;

		public bool f;

		public float g;

		public FMUSBDeviceType h;

		public bool i;

		public bool j;

		public bool k;

		public bool l;

		public bool m;

		public bool n;

		public bool o;

		public bool p;

		public bool q;

		public bool r;

		public bool s;

		public string t;

		public int u;
	}

	public class f
	{
		public const int a = 5;

		public float b;

		public float c;

		public float d;

		public float e;

		public float f;

		public float g;

		public int h;

		public float i;

		public int j;

		public float[] k;

		public float[] l;

		public short m;

		public float n;

		public f()
		{
			k = new float[6];
		}

		[SpecialName]
		public static bool o(f A_0, f A_1)
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
					if (A_0.b != A_1.b)
					{
						return true;
					}
					if (A_0.c != A_1.c)
					{
						return true;
					}
					if (A_0.d != A_1.d)
					{
						return true;
					}
					if (A_0.e != A_1.e)
					{
						return true;
					}
					if (A_0.f != A_1.f)
					{
						return true;
					}
					if (A_0.g != A_1.g)
					{
						return true;
					}
					if (A_0.h != A_1.h)
					{
						return true;
					}
					if (A_0.i != A_1.i)
					{
						return true;
					}
					if (A_0.j != A_1.j)
					{
						return true;
					}
					int num = 0;
					do
					{
						if (A_0.k[num] != A_1.k[num])
						{
							return true;
						}
						num++;
					}
					while (num <= 5);
					if (A_0.l != null && A_1.l != null)
					{
						if (A_0.l.Length != A_1.l.Length)
						{
							return true;
						}
						int num2 = A_0.l.Length - 1;
						for (num = 0; num <= num2; num++)
						{
							if (A_0.l[num] != A_1.l[num])
							{
								return true;
							}
						}
					}
					if (A_0.m != A_1.m)
					{
						return true;
					}
					if (A_0.n != A_1.n)
					{
						return true;
					}
					return false;
				}
				}
			}
		}

		[SpecialName]
		public static bool a(f A_0, f A_1)
		{
			return !o(A_0, A_1);
		}
	}

	public class g
	{
		public short a;

		public short b;

		public short c;

		public short d;

		public double e;

		public short f;

		public double g;

		public double h;

		public float i;

		public const double j = 1.0;

		private short k;

		private float[] l;

		private float[] m;

		private ushort[] m_n;

		public float o;

		[SpecialName]
		public static bool p(g A_0, g A_1)
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
					if (A_0.a != A_1.a)
					{
						return true;
					}
					if (A_0.b != A_1.b)
					{
						return true;
					}
					if (A_0.c != A_1.c)
					{
						return true;
					}
					if (A_0.d != A_1.d)
					{
						return true;
					}
					if (A_0.e != A_1.e)
					{
						return true;
					}
					if (A_0.f != A_1.f)
					{
						return true;
					}
					if (A_0.g != A_1.g)
					{
						return true;
					}
					if (A_0.h != A_1.h)
					{
						return true;
					}
					if (A_0.n() != A_1.n())
					{
						return true;
					}
					if (A_0.p().Length != A_1.p().Length)
					{
						return true;
					}
					int num = A_0.p().Length - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						if (A_0.p()[num2] != A_1.p()[num2])
						{
							return true;
						}
					}
					if (A_0.m.Length != A_1.m.Length)
					{
						return true;
					}
					int num3 = A_0.m.Length - 1;
					for (int num2 = 0; num2 <= num3; num2++)
					{
						if (A_0.m[num2] != A_1.m[num2])
						{
							return true;
						}
					}
					if (A_0.m_n.Length != A_1.m_n.Length)
					{
						return true;
					}
					int num4 = A_0.m_n.Length - 1;
					for (int num2 = 0; num2 <= num4; num2++)
					{
						if (A_0.m_n[num2] != A_1.m_n[num2])
						{
							return true;
						}
					}
					if (A_0.i != A_1.i)
					{
						return true;
					}
					if (A_0.o != A_1.o)
					{
						return true;
					}
					return false;
				}
				}
			}
		}

		[SpecialName]
		public static bool n(g A_0, g A_1)
		{
			return !p(A_0, A_1);
		}

		[SpecialName]
		public short n()
		{
			return k;
		}

		[SpecialName]
		public void n(short A_0)
		{
			k = A_0;
			checked
			{
				l = new float[A_0 - 1 + 1];
				m = new float[A_0 - 1 + 1];
				this.m_n = new ushort[(short)unchecked(A_0 * b) - 1 + 1];
			}
		}

		[SpecialName]
		public float[] p()
		{
			return l;
		}

		[SpecialName]
		public void n(float[] A_0)
		{
			l = A_0;
		}

		[SpecialName]
		public float[] q()
		{
			return m;
		}

		[SpecialName]
		public void p(float[] A_0)
		{
			m = A_0;
		}

		[SpecialName]
		public ushort[] r()
		{
			return this.m_n;
		}

		[SpecialName]
		public void n(ushort[] A_0)
		{
			this.m_n = A_0;
		}

		public g()
		{
			h = 1.0;
		}
	}

	public class h
	{
		public int a;

		public int b;

		public h6.b c;
	}

	public class i : h
	{
		public f d;

		public g e;

		public bool f;

		public i()
		{
			d = new f();
			e = new g();
		}
	}

	public class j : h
	{
		public string g;

		public bool h;

		public hr i;

		public hr j;

		public float k;

		public float l;

		public float m;

		public float n;

		public float o;

		public float p;

		public float q;

		public float r;

		public bool s;

		public bool t;

		public float u;

		public float v;

		public float w;

		public static string ah()
		{
			return i3.i() + "\\WCal";
		}

		public static bool ai(FMUSBDeviceType A_0, string A_1)
		{
			if (A_0 == FMUSBDeviceType.FIUSB2DeviceSpecUvVis2)
			{
				return Operators.CompareString(A_1, "UvVis2Spd_200-1100_10um", TextCompare: false) == 0;
			}
			return false;
		}

		public static bool ah(FMUSBDeviceType A_0, string A_1)
		{
			return A_0 switch
			{
				FMUSBDeviceType.FIUSB2DeviceSpecLC => Operators.CompareString(A_1, "LCSpc_380-1050_25um", TextCompare: false) == 0, 
				FMUSBDeviceType.FIUSB2DeviceSpecUvVis2 => true, 
				_ => false, 
			};
		}

		public static bool ah(string A_0)
		{
			return !A_0.Contains("_100um");
		}
	}

	public class k
	{
		public const int a = 4;

		public float[] b;

		public float c;

		[SpecialName]
		public static bool d(k A_0, k A_1)
		{
			switch (ix.a(A_0, A_1))
			{
			case ix.a.a:
				return false;
			case ix.a.b:
				return true;
			default:
			{
				int num = 0;
				do
				{
					if (A_0.b[num] != A_1.b[num])
					{
						return true;
					}
					num = checked(num + 1);
				}
				while (num <= 4);
				if (A_0.c != A_1.c)
				{
					return true;
				}
				return false;
			}
			}
		}

		[SpecialName]
		public static bool a(k A_0, k A_1)
		{
			return !d(A_0, A_1);
		}

		public k()
		{
			b = new float[5];
			b[0] = 1f;
			int num = 1;
			do
			{
				b[num] = 0f;
				num = checked(num + 1);
			}
			while (num <= 4);
			c = 0f;
		}
	}

	public class l
	{
		public k a;

		public k b;

		public l()
		{
			a = new k();
			b = new k();
		}
	}

	public class m : h
	{
		public new enum a
		{
			a,
			b
		}

		public a x;

		public k y;

		public m()
		{
			y = new k();
		}
	}

	public class n : h
	{
		public float z;

		public float aa;

		public float ab;

		public float ac;
	}

	public class o
	{
		public float a;

		public float b;
	}

	public class p : h
	{
		public short ad;
	}

	public class q : h
	{
		public short ae;

		public short af;

		public short ag;
	}

	public enum r
	{
		a,
		b,
		c
	}

	private new FIUsbSpectrometer m_m2;

	private int p8;

	private new int m_p9;

	private string qa;

	private float qb;

	private float qc;

	private byte qd;

	private float qe;

	private double[] qf;

	private float qg;

	private new DateTime m_qh;

	private double[] qi;

	private float qj;

	private double qk;

	private const float ql = 11f;

	private double[] qm;

	private ew.a qn;

	private List<float> qo;

	private List<DateTime> qp;

	private Collection<c[]> qq;

	private bool[] qr;

	private Collection<float[]> qs;

	private Collection<short[]> qt;

	private Collection<float[]> qu;

	private Collection<float[]> qv;

	private Collection<float[]> qw;

	private Collection<ej> qx;

	private DateTime[] qy;

	private global::h.MeasurementTimingType[] qz;

	private bool q0;

	private bool q1;

	private double[] q2;

	private Guid[] q3;

	private short[] q4;

	private float[] q5;

	private string[] q6;

	private DateTime[] q7;

	private DateTime[] q8;

	private double[] q9;

	private double[] ra;

	private DateTime[] rb;

	private Collection<float[]> rc;

	private Collection<float[]> rd;

	private double[] re;

	private Collection<float[]> rf;

	private float[] rg;

	private bool rh;

	private float ri;

	private float rj;

	private const float rk = 4000f;

	private Collection<ej> rl;

	private hp rm;

	private Collection<float[]> rn;

	private Collection<float[]> ro;

	private Collection<double> rp;

	private bool rq;

	private double[] rr;

	private float rs;

	private double rt;

	private ej ru;

	private double[] rv;

	private float rw;

	private double rx;

	private c[] ry;

	private float[] rz;

	private float[] r0;

	private float[] r1;

	private float[] r2;

	private float[] r3;

	private float[] r4;

	private double r5;

	private DateTime r6;

	private float r7;

	private bool r8;

	private bool r9;

	private DateTime sa;

	private string sb;

	private DateTime sc;

	private DateTime sd;

	private double se;

	private double sf;

	private global::h.MeasurementTimingType sg;

	private bool sh;

	private float si;

	private new float m_sj;

	private int sk;

	private int sl;

	private new int m_sm;

	private new float[] m_sn;

	private g2.OpticsConfigSubmoduleTypes m_so;

	private bool sp;

	private double sq;

	private int sr;

	private double ss;

	private ej m_st;

	private ej su;

	private Collection<float[]> sv;

	private Collection<float[]> sw;

	private Collection<double> sx;

	private string sy;

	private int sz;

	private int s0;

	private int[] s1;

	private int[] s2;

	private int[] m_s3;

	private int[] m_s4;

	private bool s5;

	private bool m_s6;

	private bool s7;

	private bool m_s8;

	private float s9;

	private float ta;

	private float m_tb;

	private float m_tc;

	private float m_td;

	private float m_te;

	private int m_tf;

	private int m_tg;

	private float m_th;

	private new b m_ti;

	private new b m_tj;

	private hm tk;

	private new hm m_tl;

	private const int tm = 10;

	private const int tn = 9;

	private const double to = 2000.0;

	private const int tp = 21;

	private const int tq = 2;

	private const int tr = 200;

	private const int ts = 1750;

	private const float tt = 370f;

	private bool tu;

	private int tv;

	private int tw;

	private int tx;

	private int ty;

	private const double tz = 1.0;

	private new const double m_t0 = 0.1;

	private bool t1;

	private double[] t2;

	private double[] t3;

	private bool t4;

	private new double m_t5;

	private int m_t6;

	private string m_t7;

	private int m_t8;

	private float m_t9;

	private float m_ua;

	private float m_ub;

	private float m_uc;

	private int m_ud;

	private int m_ue;

	private int m_uf;

	private float[] m_ug;

	private g2.OpticsConfigSubmoduleTypes m_uh;

	private float m_ui;

	private float m_uj;

	private double m_uk;

	private float m_ul;

	private Collection<float[]> m_um;

	private float m_un;

	private double m_uo;

	private bool m_up;

	private const int m_uq = 5;

	private const int m_ur = 10;

	private float m_us;

	private float m_ut;

	private int m_uu;

	private int m_uv;

	private double[,] m_uw;

	private int m_ux;

	private int m_uy;

	private int m_uz;

	private double[] m_u0;

	private DateTime m_u1;

	private double[] m_u2;

	private bool[] m_u3;

	private float[] m_u4;

	private float[] m_u5;

	private const int m_u6 = 2000;

	private int m_u7;

	private int m_u8;

	private DateTime m_u9;

	private DateTime m_va;

	private bool m_vb;

	private bool m_vc;

	private bool m_vd;

	private bool m_ve;

	private DateTime m_vf;

	private DateTime m_vg;

	private const double m_vh = 1200.0;

	private const double m_vi = 750.0;

	private const double m_vj = 750.0;

	private object m_vk;

	private double m_vl;

	private double m_vm;

	private bool m_vn;

	private double m_vo;

	private int m_vp;

	private bool m_vq;

	private const int m_vr = 60000;

	private const int m_vs = 600000;

	private const int m_vt = 16;

	private const int m_vu = 4;

	private const float m_vv = 5000f;

	private const int m_vw = 10000;

	private const byte m_vx = 4;

	private const byte m_vy = 2;

	private const byte m_vz = 1;

	private bool m_v0;

	private int m_v1;

	private string m_v2;

	private bool m_v3;

	private bool m_v4;

	private bool m_v5;

	private double[] m_v6;

	public DateTime v7;

	private bool m_v8;

	private bool m_v9;

	private long m_wa;

	private long m_wb;

	private float[] m_wc;

	private double m_wd;

	private double m_we;

	private bool m_wf;

	private bool m_wg;

	private float m_wh;

	private int m_wi;

	private double m_wj;

	private Collection<float[]> m_wk;

	private Collection<float[]> m_wl;

	private Collection<float[]> m_wm;

	private Collection<DateTime> m_wn;

	private Collection<float[]> m_wo;

	private Collection<float[]> m_wp;

	private bool m_wq;

	private int m_wr;

	private ip m_ws;

	private const int m_wt = 2000;

	private const int m_wu = 10000;

	private const float m_wv = 0.1f;

	private int m_ww;

	public const string wx = "_KeyPeaksCheck";

	private const int m_wy = 2;

	private const int m_wz = 1;

	public const float w0 = 500f;

	private int[] m_w1;

	[SpecialName]
	private float[] m_w2;

	[SpecialName]
	private float[] m_w3;

	[SpecialName]
	private double m_w4;

	[SpecialName]
	private float[] m_w5;

	[SpecialName]
	private bool m_w6;

	[SpecialName]
	private bool m_w7;

	[SpecialName]
	private g2.OpticsConfigSubmoduleTypes m_w8;

	[SpecialName]
	private double[] m_w9;

	[SpecialName]
	private float[] m_xa;

	[SpecialName]
	private float[] m_xb;

	[SpecialName]
	private double m_xc;

	[SpecialName]
	private g2.OpticsConfigSubmoduleTypes m_xd;

	[SpecialName]
	private float[] m_xe;

	[SpecialName]
	private float[] m_xf;

	[SpecialName]
	private float m_xg;

	[SpecialName]
	private float m_xh;

	[SpecialName]
	private Guid m_xi;

	[SpecialName]
	private float[] m_xj;

	public ip(FIUsbController A_0, int A_1, fz A_2)
		: base(f0.a.c, A_0, A_2)
	{
		qo = new List<float>();
		qp = new List<DateTime>();
		qq = new Collection<c[]>();
		qr = new bool[11];
		qs = new Collection<float[]>();
		qt = new Collection<short[]>();
		qu = new Collection<float[]>();
		qv = new Collection<float[]>();
		qw = new Collection<float[]>();
		qx = new Collection<ej>();
		qy = new DateTime[11];
		qz = new global::h.MeasurementTimingType[11];
		q3 = new Guid[11];
		q6 = new string[11];
		q7 = new DateTime[11];
		q8 = new DateTime[11];
		q9 = new double[11];
		ra = new double[11];
		rb = new DateTime[11];
		rc = new Collection<float[]>();
		rd = new Collection<float[]>();
		re = new double[11];
		rf = new Collection<float[]>();
		rg = new float[11];
		rl = new Collection<ej>();
		rn = new Collection<float[]>();
		ro = new Collection<float[]>();
		rp = new Collection<double>();
		sv = new Collection<float[]>();
		sw = new Collection<float[]>();
		sx = new Collection<double>();
		this.m_s3 = new int[11];
		this.m_s4 = new int[11];
		this.m_um = new Collection<float[]>();
		this.m_wc = null;
		this.m_wk = new Collection<float[]>();
		this.m_wl = new Collection<float[]>();
		this.m_wm = new Collection<float[]>();
		this.m_wn = new Collection<DateTime>();
		this.m_wo = new Collection<float[]>();
		this.m_wp = new Collection<float[]>();
		this.m_ww = 0;
		p8 = A_1;
		uj();
	}

	public ip(string A_0, int A_1, fz A_2)
		: base(f0.a.c, A_0, A_2)
	{
		qo = new List<float>();
		qp = new List<DateTime>();
		qq = new Collection<c[]>();
		qr = new bool[11];
		qs = new Collection<float[]>();
		qt = new Collection<short[]>();
		qu = new Collection<float[]>();
		qv = new Collection<float[]>();
		qw = new Collection<float[]>();
		qx = new Collection<ej>();
		qy = new DateTime[11];
		qz = new global::h.MeasurementTimingType[11];
		q3 = new Guid[11];
		q6 = new string[11];
		q7 = new DateTime[11];
		q8 = new DateTime[11];
		q9 = new double[11];
		ra = new double[11];
		rb = new DateTime[11];
		rc = new Collection<float[]>();
		rd = new Collection<float[]>();
		re = new double[11];
		rf = new Collection<float[]>();
		rg = new float[11];
		rl = new Collection<ej>();
		rn = new Collection<float[]>();
		ro = new Collection<float[]>();
		rp = new Collection<double>();
		sv = new Collection<float[]>();
		sw = new Collection<float[]>();
		sx = new Collection<double>();
		this.m_s3 = new int[11];
		this.m_s4 = new int[11];
		this.m_um = new Collection<float[]>();
		this.m_wc = null;
		this.m_wk = new Collection<float[]>();
		this.m_wl = new Collection<float[]>();
		this.m_wm = new Collection<float[]>();
		this.m_wn = new Collection<DateTime>();
		this.m_wo = new Collection<float[]>();
		this.m_wp = new Collection<float[]>();
		this.m_ww = 0;
		p8 = A_1;
		uj();
	}

	protected override int a6(string A_0)
	{
		int plErrCode = default(int);
		this.m_m2.Connect(0, A_0, 0, ref plErrCode);
		return plErrCode;
	}

	public new void m2(ip A_0)
	{
		this.m_ws = A_0;
	}

	public void sn(bool A_0)
	{
		this.m_v5 = !A_0;
	}

	public new static void m2(double[] A_0, int A_1, ref float A_2, ref float A_3)
	{
		A_2 = 0f;
		checked
		{
			int num = A_1 - 1;
			int num3 = default(int);
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (A_0[num2] > (double)A_2)
				{
					A_2 = (float)A_0[num2];
					num3 = num2;
				}
			}
			int num4 = num3 - 5;
			if (num4 < 0)
			{
				num4 = 0;
			}
			int num5 = num4 + 10;
			if (num5 > A_1 - 1)
			{
				num5 = A_1 - 1;
				num4 = num5 - 10;
			}
			A_3 = 0f;
			int num6 = num4;
			int num7 = num5;
			for (int num2 = num6; num2 <= num7; num2++)
			{
				A_3 += (float)A_0[num2];
			}
			A_3 /= 11f;
		}
	}

	public bool uh()
	{
		return hr.r(q2[0], q2[1] - q2[0]);
	}

	public bool ui()
	{
		if (xs() != FMUSBDeviceType.FIUSB2DeviceSpecTCNIR || !uh())
		{
			if (xs() == FMUSBDeviceType.FIUSB2DeviceSpecLC && q2[0] > 800.0)
			{
				return hr.r(q2[1] - q2[0]);
			}
			return false;
		}
		return true;
	}

	public new void m2(bool A_0, float A_1, float A_2, ref bool A_3, ref double A_4, ref float A_5, ref float A_6, ref float A_7, ref bool A_8)
	{
		if (A_0)
		{
			if (A_3)
			{
				if (u9() < A_4)
				{
					A_4 = u9();
					A_5 = A_1;
				}
			}
			else
			{
				A_3 = true;
				A_4 = u9();
				A_5 = A_1;
			}
		}
		A_8 = false;
		if (A_3 && A_7 > A_5)
		{
			float num = A_7 - A_5;
			A_7 -= num;
			A_6 -= num;
			if (A_6 < A_2)
			{
				ab8().c(fz.b.a, "LowSaturationIntensity error. sngPeakReading=" + A_1.ToString(CultureInfo.InvariantCulture) + ", satPeakReading=" + A_5.ToString(CultureInfo.InvariantCulture) + ", .SpectrometerIntTime=" + u9().ToString(CultureInfo.InvariantCulture));
				A_8 = true;
			}
		}
	}

	public new void m2(double A_0, float A_1, float A_2, float A_3, bool A_4, float A_5, bool A_6, bool A_7, ref float A_8, ref float A_9, ref float A_10, ref double A_11, ref bool A_12)
	{
		float num = ((this.m_ti.k() != g2.OpticsConfigSubmoduleTypes.CTMProbe || !tk.q().t()) ? 2000f : 200f);
		checked
		{
			if (A_0 > 2000.0)
			{
				A_8 = (int)Math.Round((double)A_1 * (1.0 - (A_0 - 2000.0) / 8000.0));
				if (A_8 < 0f)
				{
					A_8 = 0f;
				}
			}
			else
			{
				A_8 = A_1;
			}
			if (A_6)
			{
				if (xq() > 0)
				{
					if (A_2 > (float)(xq() + 100))
					{
						A_9 = xq();
					}
					else
					{
						A_9 = A_2 * 2f / 3f;
					}
				}
				else
				{
					A_9 = xq();
				}
			}
			else
			{
				A_9 = (float)((double)A_5 - vm() * (double)(A_3 - A_5) / (A_0 - vm()));
			}
			A_12 = false;
			if (A_10 == 0f)
			{
				if (!A_4 && A_2 > num)
				{
					A_10 = A_2;
					A_11 = u9();
				}
			}
			else
			{
				if (A_4 || A_7 || !(A_2 > num))
				{
					return;
				}
				double num2 = u9() - A_11;
				float num3 = A_2 - A_10;
				float num4 = 100f;
				if (Math.Abs(num3) > num4 && jf.a(num2, vo()))
				{
					double num5 = Math.Abs(1.0 - (double)(num3 / A_10) / (num2 / A_11));
					if (num5 > 0.550000011920929)
					{
						ab8().c(fz.b.a, "SignalNotProportionalToIntTime error. sngPeakReading=" + A_2.ToString(CultureInfo.InvariantCulture) + ", firstIntenGtThreshold=" + A_10.ToString(CultureInfo.InvariantCulture) + ", firstIntenGtThresholdIntTime=" + A_11.ToString(CultureInfo.InvariantCulture) + ", SpectrometerIntTime=" + u9().ToString(CultureInfo.InvariantCulture) + ",  SignalToIntTimeProportionalityThreshold=" + 0.55f.ToString(CultureInfo.InvariantCulture) + ", RatioError=" + num5.ToString(CultureInfo.InvariantCulture));
						A_12 = true;
					}
				}
			}
		}
	}

	private bool ug()
	{
		bool flag = true;
		string text = abo();
		int length = text.Length;
		int result = default(int);
		int result2 = default(int);
		if (length == 6)
		{
			if (int.TryParse(text.Substring(0, 2), out result))
			{
				if (int.TryParse(text.Substring(checked(length - 3), 3), out result2))
				{
					char c10 = Conversions.ToChar(text.Substring(2, 1));
					if (Operators.CompareString(Conversions.ToString(c10), "A", TextCompare: false) < 0 || Operators.CompareString(Conversions.ToString(c10), "Z", TextCompare: false) > 0)
					{
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			else
			{
				flag = false;
			}
		}
		else
		{
			flag = false;
		}
		if (flag)
		{
			if (result >= 14)
			{
				return false;
			}
			if (result < 13)
			{
				return true;
			}
			if (result2 >= 44)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	public new void m2(bool A_0, float A_1, float A_2, float A_3, float A_4, float A_5, float A_6, double A_7, bool A_8, double A_9, float A_10, bool A_11, float A_12, ref double A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
	{
		float num = (ab0() ? ((!vf() || ug()) ? 300f : 550f) : ((vz() != g2.OpticsConfigSubmoduleTypes.ContactStageAutoRef) ? 100f : 300f));
		if (!A_0 && (A_1 - A_2) * A_3 + A_2 < A_4 && ((A_1 - A_2) * A_3 + A_2 > A_6 || m2(A_13, A_7)))
		{
			A_14 = false;
		}
		else if (A_1 > 0f)
		{
			float num2;
			if (A_0)
			{
				num2 = (float)sm(A_13 / 2.0);
				if ((double)num2 < vm())
				{
					num2 = (float)vm();
				}
				if (m2(A_13, num2))
				{
					A_15 = true;
					return;
				}
			}
			else
			{
				num2 = (float)sm(A_13 * 0.5 * (double)(A_6 + A_4 - 2f * A_2) / (double)((A_1 - A_2) * A_3));
				if ((double)num2 / A_13 > 50.0)
				{
					num2 = (float)sm(50.0 * A_13);
				}
				if (A_8 && (double)num2 / A_9 > (double)A_10)
				{
					num2 = (float)sm(A_9 * (double)A_10);
				}
				if (A_11 && num2 > num)
				{
					ab8().c(fz.b.a, "sngNewIntegrationTime = " + num2.ToString("0.000"));
					A_16 = true;
					return;
				}
				if (num2 > 2000f)
				{
					double num3 = -0.5 * (double)(A_5 + A_4) / 8000.0;
					double num4 = (0.0 - num3) * 10000.0;
					double num5 = (double)((A_1 - A_2) * A_3) / A_13;
					double num6 = A_2;
					num2 = (float)sm(Conversion.Int(num4 - num6) / (num5 - num3));
				}
			}
			if ((double)num2 < vm())
			{
				num2 = (float)vm();
				A_14 = false;
				A_17 = true;
			}
			else if (m2(num2, A_13) && m2(A_13, vm()))
			{
				if (A_1 > A_12)
				{
					A_15 = true;
					return;
				}
				A_14 = false;
			}
			if ((double)num2 > A_7)
			{
				num2 = (float)sm(A_7);
				A_18 = true;
			}
			A_13 = num2;
		}
		else if (u1())
		{
			if (A_0)
			{
				A_13 = (float)vm();
			}
			else
			{
				A_13 *= 2.0;
			}
		}
		else if (A_13 < 198.0)
		{
			A_13 = 200.0;
		}
		else
		{
			A_14 = false;
		}
	}

	[SpecialName]
	protected override @is.a a8()
	{
		return @is.a.a;
	}

	protected override double a9(global::r.c A_0, global::r.d.a.b A_1, bool A_2)
	{
		bool flag = true;
		bool A_3 = true;
		float A_4 = default(float);
		float A_5 = default(float);
		float A_6 = default(float);
		float A_7 = default(float);
		float A_8 = default(float);
		m2(A_0: false, A_1: false, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8);
		double A_9 = this.m_m2.MinIntegrationTime;
		bool A_10;
		bool A_11 = default(bool);
		bool A_12 = default(bool);
		float A_13 = default(float);
		float A_14 = default(float);
		float a_ = default(float);
		bool A_15 = default(bool);
		double A_16 = default(double);
		float A_17 = default(float);
		bool A_18 = default(bool);
		float A_19 = default(float);
		float A_20 = default(float);
		float A_21 = default(float);
		double A_22 = default(double);
		bool A_23 = default(bool);
		bool A_25 = default(bool);
		bool A_26 = default(bool);
		do
		{
			if (so(A_9) != FIDeviceErr.None)
			{
				throw new ai("Error attempting to set Integration time");
			}
			A_10 = false;
			if (m2(ref A_11, ref A_12, 0, A_9, 1, ew.a.a, A_0, A_1) != FIDeviceErr.None)
			{
				throw new ai("Error attempting to acquire spectrum");
			}
			m2(qf, vw(), ref A_13, ref A_14);
			if (flag)
			{
				a_ = A_14;
			}
			m2(A_12, A_13, A_7, ref A_15, ref A_16, ref A_17, ref A_4, ref A_5, ref A_18);
			if (A_18)
			{
				throw new ai("Low saturation intensity.");
			}
			if (A_13 >= A_4 && A_13 <= A_5)
			{
				return A_9;
			}
			m2(A_9, A_4, A_13, A_14, A_12, a_, flag, A_7: false, ref A_19, ref A_20, ref A_21, ref A_22, ref A_23);
			if (A_23)
			{
				throw new ai("Signal not proportional to int time in DetermineOptimalGain");
			}
			bool a_2 = A_12;
			float a_3 = A_13;
			float a_4 = A_20;
			float a_5 = A_5;
			float a_6 = A_4;
			float a_7 = A_19;
			double a_8 = vl();
			bool a_9 = A_15;
			double a_10 = A_16;
			float a_11 = A_6;
			float a_12 = A_8;
			bool A_24 = false;
			m2(a_2, a_3, a_4, 1f, a_5, a_6, a_7, a_8, a_9, a_10, a_11, A_11: false, a_12, ref A_9, ref A_3, ref A_25, ref A_26, ref A_10, ref A_24);
			if (A_25)
			{
				if (!A_2)
				{
					throw new ai("Light is too bright even at min integration time in DetermineOptimalGain.");
				}
				A_3 = false;
				A_10 = false;
			}
			if (A_26)
			{
				throw new ai("No light detected while attempting to DetermineOptimalGain.");
			}
		}
		while (A_3 || A_10);
		return A_9;
	}

	protected override float ba(double A_0, global::r.c A_1, global::r.d.a.b A_2, ref bool A_3)
	{
		bool A_4 = default(bool);
		if (m2(ref A_4, ref A_3, 1, A_0, 1, ew.a.a, A_1, A_2) != FIDeviceErr.None)
		{
			throw new ai("Error attempting to acquire spectrum in GetPeakReading");
		}
		double num = qf[0];
		int num2 = 0;
		checked
		{
			int num3 = vw() - 1;
			for (int num4 = 1; num4 <= num3; num4++)
			{
				if (qf[num4] > num)
				{
					num = qf[num4];
					num2 = num4;
				}
			}
			int num5 = num2 - 4;
			if (num5 < 0)
			{
				num5 = 0;
			}
			int num6 = num5 + 8;
			if (num6 >= vw())
			{
				num6 = vw() - 1;
			}
			double num7 = 0.0;
			int num8 = num5;
			int num9 = num6;
			for (int num10 = num8; num10 <= num9; num10++)
			{
				num7 += qf[num10];
			}
			return (float)(num7 / (double)(num6 - num5 + 1));
		}
	}

	protected FIDeviceErr uj()
	{
		FIDeviceErr result = FIDeviceErr.None;
		checked
		{
			try
			{
				this.m_m2 = (FIUsbSpectrometer)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("7F0418FC-800D-422D-8D35-D40D515031E2")));
				int plErrCode = default(int);
				this.m_m2.Connect(0, abn(), (byte)(p8 + 1), ref plErrCode);
				mb = plErrCode;
				if (plErrCode == 0 || plErrCode == -108)
				{
					this.m_wr = abk().HardwareRefreshID;
					if (this.m_m2.FWCorrupt != 0)
					{
						ab8().c(fz.b.a, "Failure in InitializeDevice(). USB Spectrometer Firmware corrupt");
					}
					if (abk().HasLowPowerLightSource != 0)
					{
						if (z8())
						{
							plErrCode = this.m_m2.SetLightSourceCalibLampPowerOnState(0);
							if (plErrCode != 0)
							{
								ab8().c(fz.b.a, "Error attempting to deactivate gas discharge lamp. Error code=" + plErrCode);
							}
							if (this.m_m2.HasHighVoltageGenerator != 0)
							{
								plErrCode = this.m_m2.EnableDisableHighVoltage(-1);
								if (plErrCode != 0)
								{
									ab8().c(fz.b.a, "Error attempting to activate high voltage in spectrometer. Error code=" + plErrCode);
								}
							}
						}
						else if (this.m_m2.HasHighVoltageGenerator != 0)
						{
							plErrCode = this.m_m2.EnableDisableHighVoltage(0);
							if (plErrCode != 0)
							{
								ab8().c(fz.b.a, "Error attempting to deactivate high voltage in spectrometer. Error code=" + plErrCode);
							}
						}
					}
					qa = this.m_m2.FriendlySN;
					g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = g2.OpticsConfigSubmoduleTypes.ReflectanceProbe;
					do
					{
						qq.Add(null);
						qs.Add(null);
						qt.Add(null);
						qu.Add(null);
						qv.Add(null);
						qw.Add(null);
						rc.Add(null);
						rd.Add(null);
						rf.Add(null);
						this.m_um.Add(null);
						qx.Add(null);
						rl.Add(null);
						this.m_wk.Add(null);
						this.m_wl.Add(null);
						this.m_wn.Add(DateTime.MinValue);
						this.m_wm.Add(null);
						this.m_wo.Add(null);
						this.m_wp.Add(null);
						opticsConfigSubmoduleTypes = unchecked(opticsConfigSubmoduleTypes + 1);
					}
					while (opticsConfigSubmoduleTypes <= g2.OpticsConfigSubmoduleTypes.TransCurved);
					if (this.m_m2.FWCorrupt != 0)
					{
						ma = Guid.NewGuid().ToString("N");
					}
					else
					{
						ma = this.m_m2.SerialNumber;
					}
					qb = 1f + this.m_m2.FWLinInt;
					qc = 0f - this.m_m2.FWLinSlope;
					qd = this.m_m2.FWLinVer;
					qe = this.m_m2.FWDCScatter;
					q0 = true;
					q1 = true;
					rh = true;
					ri = 0f;
					if (this.m_m2.eSpectromType == FMUSBDeviceType.FIUSB2DeviceSpecLC)
					{
						rj = 110f;
					}
					else
					{
						rj = 0f;
					}
					sz = 10;
					s0 = 0;
					sr = 1;
					s1 = new int[sz - 1 + 1];
					s2 = new int[sz - 1 + 1];
					tk = new hm();
					float fWMeasurementAngle = abk().FWMeasurementAngle;
					if (!jf.e(fWMeasurementAngle, tk.m()))
					{
						tk = tk.l(fWMeasurementAngle);
					}
					if (abf())
					{
						if (abg())
						{
							tk = tk.i(hl.a);
						}
					}
					else if (!jf.e(fWMeasurementAngle, 0.0))
					{
						tk.i(hl.c);
					}
					this.m_ti = new b();
					this.m_ti = this.m_ti.j(g2.OpticsConfigSubmoduleTypes.ReflectanceProbe);
					FIUsbSpectrometer fIUsbSpectrometer = this.m_m2;
					m2(fIUsbSpectrometer.FWCalOffset, fIUsbSpectrometer.FWCalSlope, fIUsbSpectrometer.FWCalCurv, fIUsbSpectrometer.FWCalThird, fIUsbSpectrometer.FWCalFourth, fIUsbSpectrometer.FWCalTemp1, fIUsbSpectrometer.FWCalOffset2, fIUsbSpectrometer.FWCalSlope2, fIUsbSpectrometer.FWCalCurv2, fIUsbSpectrometer.FWCalThird2, fIUsbSpectrometer.FWCalFourth2, fIUsbSpectrometer.FWCalTemp2, a7(), fIUsbSpectrometer.NumPixels, ref this.m_th);
					fIUsbSpectrometer = null;
					s4(A_0: true);
					if (this.m_m2.HWTrueDark == 0)
					{
						t1 = true;
					}
					else
					{
						t1 = false;
					}
					if (xs() == FMUSBDeviceType.FMUSBDeviceVisHama)
					{
						if (q2[0] > 370.0)
						{
							this.m_ut = 0f;
							while ((q2[(int)Math.Round(this.m_ut)] < 410.0) & (this.m_ut < (float)(this.m_p9 - 1)))
							{
								if (this.m_ut < (float)(this.m_p9 - 1))
								{
									this.m_ut++;
								}
							}
							this.m_ut--;
							if (this.m_ut < 0f)
							{
								this.m_ut = 0f;
							}
							this.m_us = this.m_ut;
							while ((q2[(int)Math.Round(this.m_us)] < 430.0) & (this.m_us < (float)(this.m_p9 - 1)))
							{
								if (this.m_us < (float)(this.m_p9 - 1))
								{
									this.m_us++;
								}
							}
						}
						else
						{
							this.m_ut = 7f;
							this.m_us = this.m_ut;
							while ((q2[(int)Math.Round(this.m_us)] < 370.0) & (this.m_us < (float)(this.m_p9 - 1)))
							{
								if (this.m_us < (float)(this.m_p9 - 1))
								{
									this.m_us++;
								}
							}
						}
					}
					s4();
					yi();
					so();
					bool A_ = false;
					bool A_2 = false;
					m2(null, null, ref A_, A_3: false, ref A_2);
					DateTime A_3 = default(DateTime);
					m2(ref A_3);
					st(A_3);
					ti();
					ub();
					uc();
					string A_4 = null;
					if (!m2(ref A_4) && this.m_we == 0.0)
					{
						ua();
					}
					string text = uk();
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					string startupPath = Application.StartupPath;
					if (this.m_m2.SetCalibrateDataFilePath(startupPath + "\\Cal\\10.dat", text) != 0)
					{
						ab8().c(fz.b.a, "Missing calib peaks data file");
						this.m_v3 = true;
					}
					sm();
					un();
					if (this.m_m2.eSpectromType == FMUSBDeviceType.FIUSB2DeviceSpecTCNIR && abk().HasLowPowerLightSource == 0 && this.m_m2.DeviceRevLevel <= 1)
					{
						abk().SetLampSetpoint(255);
					}
					double num = 0.001;
					this.m_wi = 3;
					bool flag;
					bool flag2 = default(bool);
					double num5 = default(double);
					do
					{
						flag = false;
						int num2 = 1;
						do
						{
							double num3 = vm() + (num - 1.0) * (double)num2;
							double num4 = vm() + num * (double)num2;
							if (!flag && this.m_m2.IntTimesEqual(num3, num4) != 0)
							{
								flag = true;
								this.m_wi--;
								num *= 10.0;
								if (flag2)
								{
									break;
								}
							}
							if (!flag2)
							{
								num5 = ((IFIUsbSpectrometer)this.m_m2).get_QuantizedIntegrationTime_ms(num3);
								double num6 = ((IFIUsbSpectrometer)this.m_m2).get_QuantizedIntegrationTime_ms(num4) - num5;
								if (num6 != 0.0)
								{
									this.m_wj = num6;
									flag2 = true;
									if (flag)
									{
										break;
									}
								}
							}
							num2++;
						}
						while (num2 <= 10);
					}
					while (flag);
					double num7 = Math.Pow(10.0, this.m_wi);
					if (Math.Round(this.m_wj * 10.0 * num7, 0, MidpointRounding.AwayFromZero) != Conversion.Int(Math.Round(this.m_wj * num7, 0, MidpointRounding.AwayFromZero) * 10.0) || Math.Round(num5 * 10.0 * num7, 0, MidpointRounding.AwayFromZero) != Conversion.Int(Math.Round(num5 * num7, 0, MidpointRounding.AwayFromZero) * 10.0))
					{
						this.m_wi++;
					}
					ft = true;
				}
				else
				{
					bd();
					if (plErrCode != -105)
					{
						if (mc != 0)
						{
							ab8().c(fz.b.a, "Hardware failure in connected device. Failure is:" + be());
						}
						else
						{
							ab8().c(fz.b.a, "Failure in USBSpectrometerDevice.InitializeDevice(). Failure to connect to USB Spectrometer. Error is: " + Conversions.ToString(plErrCode), Environment.StackTrace);
						}
						result = FIDeviceErr.USBInitError;
					}
				}
				long a_ = default(long);
				float num8 = default(float);
				float a_2 = default(float);
				float a_3 = default(float);
				switch (xs())
				{
				case FMUSBDeviceType.FMUSBDeviceVisHama:
					a_ = Convert.ToInt64(this.m_m2.FullWellNumElectrons);
					num8 = 6f * this.m_m2.ReadoutNoiseRms;
					a_2 = num8 / 4f;
					a_3 = 1f;
					break;
				case FMUSBDeviceType.FMUSBDeviceIRHama:
					a_ = Convert.ToInt64(this.m_m2.FullWellNumElectrons);
					num8 = 6f * this.m_m2.ReadoutNoiseRms;
					a_2 = num8 / 4f;
					a_3 = 1f;
					break;
				case FMUSBDeviceType.FMUSBDeviceSony:
					a_ = Convert.ToInt64(this.m_m2.FullWellNumElectrons);
					num8 = 6f * this.m_m2.ReadoutNoiseRms;
					a_2 = num8 / 4f;
					a_3 = 1f;
					break;
				case FMUSBDeviceType.FIUSB2DeviceSpecUvVis:
					a_ = 190000L;
					num8 = 16f;
					a_2 = 2.4f;
					a_3 = 1f;
					break;
				case FMUSBDeviceType.FIUSB2DeviceSpecNIR2:
					a_ = 10000000L;
					num8 = 3.5f;
					a_2 = 0.5f;
					a_3 = 1f;
					break;
				case FMUSBDeviceType.FIUSB2DeviceSpecLC:
					a_ = 125000L;
					num8 = 35f;
					a_2 = 9f;
					a_3 = 1f;
					break;
				case FMUSBDeviceType.FIUSB2DeviceSpecUvVis2:
					a_ = 200000L;
					num8 = 9f;
					a_2 = 1.2f;
					a_3 = 1f;
					break;
				case FMUSBDeviceType.FIUSB2DeviceSpecTCNIR:
					a_ = 5000000L;
					num8 = 5f;
					a_2 = 2.3f;
					a_3 = 1f;
					break;
				}
				rm = new hp(30, 4096, a_, num8, a_2, a_3, uq(), xs());
				i7 obj = a2.a;
				string a_4 = abn();
				string a_5 = abo();
				ref int a_6 = ref this.m_v1;
				ref string a_7 = ref this.m_v2;
				string[] A_5 = null;
				this.m_v0 = obj.c(a_4, a_5, i7.e.y, ref a_6, ref a_7, ref A_5);
				this.m_vk = RuntimeHelpers.GetObjectValue(new object());
				this.m_v8 = true;
				this.m_v9 = true;
				this.m_vq = false;
				this.m_wq = false;
				m2(A_0: false, 0);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				result = FIDeviceErr.Generic;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	[SpecialName]
	public string uk()
	{
		return i3.o() + "\\Logs\\CalData " + i3.g(this.m_m2.FriendlySN) + " (" + this.m_m2.SerialNumber + ")\\";
	}

	[SpecialName]
	protected override bool a7()
	{
		return this.m_m2.FWCorrupt != 0;
	}

	public void so(bool A_0)
	{
		ab8().c(fz.b.b, "ResetTheController");
		int num = abk().ResetMicro();
		if (num != 0)
		{
			ab8().c(fz.b.b, "Error in USBController.ResetMicro, Error is " + num);
		}
		int lErrCode = default(int);
		abk().Connect(0, abk().SerialNumber, ref lErrCode);
		if (lErrCode != 0)
		{
			ab8().c(fz.b.b, "Error in USBController.Connect, Error is " + lErrCode);
		}
		if (A_0 && abk().RefreshHardwareSettings() != 0)
		{
			ab8().c(fz.b.b, "Error in USBController.RefreshHardwareSettings, Error is " + lErrCode);
		}
	}

	public int st(bool A_0)
	{
		ab8().c(fz.b.b, "ReInstantiateAndConnectToUsbSpectrometer, justRequestedReset = " + A_0 + ", opticsConfig = " + g2.o(vz()));
		double integrationTime = this.m_m2.IntegrationTime;
		this.m_m2 = (FIUsbSpectrometer)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("7F0418FC-800D-422D-8D35-D40D515031E2")));
		int plErrCode = default(int);
		this.m_m2.Connect(0, abn(), checked((byte)(p8 + 1)), ref plErrCode);
		w8();
		if (plErrCode != 0)
		{
			ab8().c(fz.b.b, "Error in mUSBSpectrometer.Connect, Error is " + plErrCode);
		}
		if (plErrCode == 0 && x9())
		{
			this.m_m2.SetFirstLastValidPixelIdx(this.m_tf, this.m_tg);
		}
		if (A_0 && this.m_m2.SetIntegrationTime(integrationTime) != 0)
		{
			ab8().c(fz.b.b, "Error in mUSBSpectrometer.SetIntegrationTime, Error is " + plErrCode);
		}
		return plErrCode;
	}

	public void qh(ref int A_0)
	{
		A_0 = 0;
		if (x9())
		{
			int A_1 = default(int);
			int A_2 = default(int);
			m2(ref A_1, ref A_2);
			FIUsbSpectrometer fIUsbSpectrometer = this.m_m2;
			int lastIdx = 0;
			fIUsbSpectrometer.GetFirstLastValidPixelDueToHW(out var firstIdx, out lastIdx);
			A_0 = checked(A_1 - firstIdx);
			this.m_m2.SetFirstLastValidPixelIdx(firstIdx, this.m_tg);
			m2(A_0: false, A_1: true);
		}
	}

	public void ul()
	{
		if (x9())
		{
			this.m_m2.SetFirstLastValidPixelIdx(this.m_tf, this.m_tg);
			m2(A_0: false, A_1: true);
		}
	}

	private new void m2(ref int A_0, ref int A_1)
	{
		float a_;
		float a_2;
		if (this.m_th != 0f && ya())
		{
			a_ = this.m_m2.FWWaveRangeStart - 20f * Math.Abs(this.m_th);
			a_2 = this.m_m2.FWWaveRangeEnd + 10f * Math.Abs(this.m_th);
		}
		else if (this.m_m2.eSpectromType == FMUSBDeviceType.FIUSB2DeviceSpecUvVis2 && ya())
		{
			a_ = this.m_m2.FWWaveRangeStart - 2.5f * this.m_m2.FWCalSlope;
			a_2 = this.m_m2.FWWaveRangeEnd + 1.25f * this.m_m2.FWCalSlope;
		}
		else
		{
			a_ = this.m_m2.FWWaveRangeStart;
			a_2 = this.m_m2.FWWaveRangeEnd;
		}
		m2(a_, a_2, ref A_0, ref A_1);
	}

	private new void m2(float A_0, float A_1, ref int A_2, ref int A_3)
	{
		FIUsbSpectrometer fIUsbSpectrometer = this.m_m2;
		checked
		{
			double num5 = default(double);
			if (fIUsbSpectrometer.FWCalCurv != 0f)
			{
				double num = fIUsbSpectrometer.FWCalSlope * fIUsbSpectrometer.FWCalSlope;
				double num2 = num - (double)(4f * fIUsbSpectrometer.FWCalCurv * (fIUsbSpectrometer.FixedCalOffset - A_0));
				double num3 = num - (double)(4f * fIUsbSpectrometer.FWCalCurv * (fIUsbSpectrometer.FixedCalOffset - A_1));
				if ((num2 >= 0.0) & (num3 >= 0.0))
				{
					double num4 = Conversion.Int(((double)(0f - fIUsbSpectrometer.FWCalSlope) + Math.Sqrt(num2)) / (double)(2f * fIUsbSpectrometer.FWCalCurv));
					if (num4 > 2147483647.0)
					{
						num4 = 2147483647.0;
					}
					A_2 = (int)Math.Round(num4);
					num5 = ((double)(0f - fIUsbSpectrometer.FWCalSlope) + Math.Sqrt(num3)) / (double)(2f * fIUsbSpectrometer.FWCalCurv);
				}
			}
			else if (fIUsbSpectrometer.FWCalSlope != 0f)
			{
				double num6 = Conversion.Int((A_0 - fIUsbSpectrometer.FixedCalOffset) / fIUsbSpectrometer.FWCalSlope);
				if (num6 > 2147483647.0)
				{
					num6 = 2147483647.0;
				}
				A_2 = (int)Math.Round(num6);
				num5 = (A_1 - fIUsbSpectrometer.FixedCalOffset) / fIUsbSpectrometer.FWCalSlope;
			}
			if (fIUsbSpectrometer.FWCalThird != 0f || fIUsbSpectrometer.FWCalFourth != 0f)
			{
				double[] a_ = new double[5] { fIUsbSpectrometer.FixedCalOffset, fIUsbSpectrometer.FWCalSlope, fIUsbSpectrometer.FWCalCurv, fIUsbSpectrometer.FWCalThird, fIUsbSpectrometer.FWCalFourth };
				double num7 = Conversion.Int(jf.a(4, a_, A_0, A_2, 1.0, 0.1));
				if (num7 > 2147483647.0)
				{
					num7 = 2147483647.0;
				}
				A_2 = (int)Math.Round(num7);
				int num8 = 0;
				double num9;
				do
				{
					num9 = (double)fIUsbSpectrometer.FWCalOffset + ((double)fIUsbSpectrometer.FWCalSlope + ((double)fIUsbSpectrometer.FWCalCurv + ((double)fIUsbSpectrometer.FWCalThird + (double)fIUsbSpectrometer.FWCalFourth * num5) * num5) * num5) * num5 - (double)A_1;
					num5 -= num9 / (double)fIUsbSpectrometer.FWCalSlope;
					num8++;
				}
				while (num9 > 20.0 && num8 < 25);
				if (num9 > 20.0)
				{
					ab8().c(fz.b.b, "Convergence error when attempting to compute wavelength limit last pixel. Offset=" + fIUsbSpectrometer.FWCalOffset.ToString(CultureInfo.InvariantCulture) + ", Slope=" + fIUsbSpectrometer.FWCalSlope.ToString(CultureInfo.InvariantCulture) + ", Curv=" + fIUsbSpectrometer.FWCalCurv.ToString(CultureInfo.InvariantCulture) + ", 3rd=" + fIUsbSpectrometer.FWCalThird.ToString(CultureInfo.InvariantCulture) + ", 4th=" + fIUsbSpectrometer.FWCalFourth.ToString(CultureInfo.InvariantCulture));
				}
				num5 = jf.a(4, a_, A_1, num5, 1.0, 0.1);
			}
			FIUsbSpectrometer fIUsbSpectrometer2 = fIUsbSpectrometer;
			int lastIdx = 0;
			fIUsbSpectrometer2.GetFirstLastValidPixelDueToHW(out var firstIdx, out lastIdx);
			if (num5 + (double)firstIdx + 1.0 > 2147483647.0)
			{
				num5 = int.MaxValue - (firstIdx + 1);
			}
			if (num5 != Conversion.Int(num5))
			{
				A_3 = (int)Math.Round(Conversion.Int(num5) + 1.0);
			}
			else
			{
				A_3 = (int)Math.Round(num5);
			}
			A_2 += firstIdx;
			A_3 += firstIdx;
			if (A_2 < 0)
			{
				A_2 = 0;
			}
			if (A_2 >= fIUsbSpectrometer.NumHWPixels)
			{
				A_2 = fIUsbSpectrometer.NumHWPixels - 1;
			}
			if (A_3 < 0)
			{
				A_3 = 0;
			}
			if (A_3 >= fIUsbSpectrometer.NumHWPixels)
			{
				A_3 = fIUsbSpectrometer.NumHWPixels - 1;
			}
			fIUsbSpectrometer = null;
		}
	}

	[SpecialName]
	public bool um()
	{
		return this.m_m2.EnableActiveCalParams != 0;
	}

	[SpecialName]
	public void s3(bool A_0)
	{
		if (A_0 != um())
		{
			this.m_m2.EnableActiveCalParams = 0 - (A_0 ? 1 : 0);
			if (A_0)
			{
				s4(A_0: false);
			}
			else
			{
				s4(!x1());
			}
		}
	}

	public void s4(bool A_0)
	{
		m2(A_0, A_1: false);
	}

	public new void m2(bool A_0, bool A_1)
	{
		float num = ((!s8()) ? this.m_te : 0f);
		FIUsbSpectrometer fIUsbSpectrometer = this.m_m2;
		checked
		{
			if (x9())
			{
				FIUsbSpectrometer fIUsbSpectrometer2 = fIUsbSpectrometer;
				int lastIdx = 0;
				fIUsbSpectrometer2.GetFirstLastValidPixelDueToHW(out var firstIdx, out lastIdx);
				int firstIdx2 = default(int);
				int lastIdx2 = default(int);
				if (A_0)
				{
					m2(ref firstIdx2, ref lastIdx2);
					if (firstIdx2 < lastIdx2)
					{
						fIUsbSpectrometer.SetFirstLastValidPixelIdx(firstIdx2, lastIdx2);
						this.m_tf = firstIdx2;
						this.m_tg = lastIdx2;
					}
				}
				else
				{
					fIUsbSpectrometer.GetFirstLastValidPixelIdx(out firstIdx2, out lastIdx2);
				}
				firstIdx2 -= firstIdx;
				lastIdx2 -= firstIdx;
				if (fIUsbSpectrometer.FWCalThird == 0f && fIUsbSpectrometer.FWCalFourth == 0f)
				{
					s9 = 0f;
					ta = 0f;
					this.m_tb = fIUsbSpectrometer.FWCalCurv;
					this.m_tc = fIUsbSpectrometer.FWCalSlope + 2f * fIUsbSpectrometer.FWCalCurv * (float)firstIdx2;
					this.m_td = fIUsbSpectrometer.EffectiveCalOffset + num + (fIUsbSpectrometer.FWCalSlope + fIUsbSpectrometer.FWCalCurv * (float)firstIdx2) * (float)firstIdx2;
				}
				else
				{
					s9 = fIUsbSpectrometer.FWCalFourth;
					ta = (float)((double)fIUsbSpectrometer.FWCalThird + 4.0 * (double)fIUsbSpectrometer.FWCalFourth * (double)firstIdx2);
					this.m_tb = (float)((double)fIUsbSpectrometer.FWCalCurv + ((double)(3f * fIUsbSpectrometer.FWCalThird) + 6.0 * (double)fIUsbSpectrometer.FWCalFourth * (double)firstIdx2) * (double)firstIdx2);
					this.m_tc = (float)((double)fIUsbSpectrometer.FWCalSlope + ((double)(2f * fIUsbSpectrometer.FWCalCurv) + ((double)(3f * fIUsbSpectrometer.FWCalThird) + 4.0 * (double)fIUsbSpectrometer.FWCalFourth * (double)firstIdx2) * (double)firstIdx2) * (double)firstIdx2);
					this.m_td = (float)((double)(fIUsbSpectrometer.EffectiveCalOffset + num) + ((double)fIUsbSpectrometer.FWCalSlope + ((double)fIUsbSpectrometer.FWCalCurv + ((double)fIUsbSpectrometer.FWCalThird + (double)fIUsbSpectrometer.FWCalFourth * (double)firstIdx2) * (double)firstIdx2) * (double)firstIdx2) * (double)firstIdx2);
				}
			}
			else
			{
				s9 = fIUsbSpectrometer.FWCalFourth;
				ta = fIUsbSpectrometer.FWCalThird;
				this.m_tb = fIUsbSpectrometer.FWCalCurv;
				this.m_tc = fIUsbSpectrometer.FWCalSlope;
				this.m_td = fIUsbSpectrometer.EffectiveCalOffset + num;
			}
			fIUsbSpectrometer = null;
		}
		if (A_0 || A_1)
		{
			uf();
			g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = g2.OpticsConfigSubmoduleTypes.ReflectanceProbe;
			do
			{
				this.m_s3[(int)opticsConfigSubmoduleTypes] = 0;
				this.m_s4[(int)opticsConfigSubmoduleTypes] = checked(this.m_p9 - 1);
				opticsConfigSubmoduleTypes++;
			}
			while (opticsConfigSubmoduleTypes <= g2.OpticsConfigSubmoduleTypes.TransCurved);
		}
		yd();
		hr.r(q2, this.m_p9, ref tu, ref tv, ref tw);
	}

	private void uf()
	{
		this.m_p9 = this.m_m2.NumPixels;
		checked
		{
			qf = new double[this.m_p9 - 1 + 1];
			qm = new double[this.m_p9 - 1 + 1];
		}
	}

	public void un()
	{
		if (this.m_m2.eSpectromType != FMUSBDeviceType.FIUSB2DeviceSpecTCNIR)
		{
			return;
		}
		bool flag = abk().HasUSBChargingPort != 0;
		float newTemperature;
		float newTemperature2;
		bool flag2;
		bool flag3;
		if (this.m_m2.HasTwoStageTEC != 0)
		{
			newTemperature = 15f;
			if (abk().USBSelfPowered == 0 && !flag)
			{
				newTemperature2 = 15f;
				flag2 = true;
				flag3 = true;
			}
			else
			{
				newTemperature2 = ((!uh()) ? (-5f) : 20f);
				flag2 = false;
				flag3 = false;
			}
		}
		else
		{
			newTemperature = 15f;
			if (abk().USBSelfPowered == 0 && !flag)
			{
				newTemperature2 = 15f;
				flag2 = true;
				flag3 = true;
			}
			else
			{
				newTemperature2 = ((!uh()) ? 5f : 20f);
				flag2 = false;
				flag3 = false;
			}
		}
		if (this.m_wg)
		{
			newTemperature2 = this.m_wh;
		}
		this.m_m2.SetTECSupplyNVSetpoint2(newTemperature, -1, 0);
		this.m_m2.SetTECSetpoint2(newTemperature2, 0 - (flag2 ? 1 : 0), 0 - (flag3 ? 1 : 0), 0 - (flag ? 1 : 0));
	}

	[SpecialName]
	public float uo()
	{
		return this.m_m2.TECTemperatureSetpoint;
	}

	public new int m2(float A_0)
	{
		bool flag = abk().HasUSBChargingPort != 0;
		int num = this.m_m2.SetTECSetpoint2(A_0, 0, 0 - ((abk().USBSelfPowered == 0 && !flag) ? 1 : 0), 0 - (flag ? 1 : 0));
		if (num == 0)
		{
			this.m_wg = true;
			this.m_wh = A_0;
			yh();
		}
		return num;
	}

	public void up()
	{
		this.m_m2.RequestCancelProcess();
	}

	public static void ue()
	{
		FileInfo[] files = new DirectoryInfo(i3.o()).GetFiles(@is.b(@is.a.a));
		string text = @is.b();
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		FileInfo[] array = files;
		foreach (FileInfo fileInfo in array)
		{
			fileInfo.MoveTo(text + fileInfo.Name);
		}
	}

	public new static bool m2(float A_0, float A_1, float A_2, float A_3, bool A_4)
	{
		bool flag = false;
		try
		{
			if (A_4)
			{
				return true;
			}
			float num = A_1 - A_0;
			float num2 = A_3 - A_2;
			float num3 = ((!(num < num2)) ? num2 : num);
			flag = (((((double)((A_2 - A_0) / num3) < -0.25) & (A_3 - A_1 < 0f)) | (((double)((A_3 - A_1) / num3) > 0.25) & (A_2 - A_0 > 0f))) ? true : false);
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

	[SpecialName]
	public string uq()
	{
		return qa;
	}

	[SpecialName]
	public string ur()
	{
		return this.m_m2.SerialNumber;
	}

	[SpecialName]
	public int us()
	{
		return p8;
	}

	[SpecialName]
	public int ut()
	{
		if (this.m_v0)
		{
			return checked(this.m_v1 - 1);
		}
		if (abk().FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF2 && abk().FWSubsystemIdx == 0 && this.m_m2.eSpectromType != FMUSBDeviceType.FIUSB2DeviceSpecNIR2)
		{
			return p8;
		}
		return abk().FWSubsystemIdx;
	}

	[SpecialName]
	public bool uu()
	{
		if (!xu())
		{
			return xw();
		}
		return true;
	}

	[SpecialName]
	private bool ud()
	{
		if (abk().FWInstTypeCode == 26 || abk().FWInstTypeCode == 24)
		{
			return !this.m_v0;
		}
		return false;
	}

	[SpecialName]
	public bool uv()
	{
		return this.m_v0;
	}

	[SpecialName]
	public int uw()
	{
		return this.m_v1;
	}

	[SpecialName]
	public string ux()
	{
		return this.m_v2;
	}

	[SpecialName]
	public int uy()
	{
		if (uv())
		{
			return checked(this.m_v1 - 1);
		}
		return abk().FWSubsystemIdx;
	}

	[SpecialName]
	public int uz()
	{
		return abk().FWSubsystemIdx;
	}

	[SpecialName]
	public bool u0()
	{
		if (!ud())
		{
			return this.m_v0;
		}
		return true;
	}

	[SpecialName]
	public bool u1()
	{
		FIUsbSpectrometer fIUsbSpectrometer = this.m_m2;
		if (fIUsbSpectrometer.eSpectromType != FMUSBDeviceType.FIUSB2DeviceSpecUvVis && fIUsbSpectrometer.eSpectromType != FMUSBDeviceType.FIUSB2DeviceSpecLC && fIUsbSpectrometer.eSpectromType != FMUSBDeviceType.FIUSB2DeviceSpecUvVis2 && (fIUsbSpectrometer.eSpectromType != FMUSBDeviceType.FIUSB2DeviceSpecNIR2 || fIUsbSpectrometer.DeviceRevLevel < 4) && fIUsbSpectrometer.eSpectromType != FMUSBDeviceType.FMUSBDeviceIRHama)
		{
			return fIUsbSpectrometer.eSpectromType == FMUSBDeviceType.FIUSB2DeviceSpecTCNIR;
		}
		return true;
	}

	[SpecialName]
	public bool u2()
	{
		if (u1())
		{
			return this.m_m2.eSpectromType != FMUSBDeviceType.FMUSBDeviceIRHama;
		}
		return false;
	}

	[SpecialName]
	public short p9(double A_0)
	{
		double num = A_0 + (double)t9();
		if (u1())
		{
			short num2 = 25;
			if ((double)num2 * num > 200.0)
			{
				num2 = checked((short)Math.Round(200.0 / num));
				if (num2 < 1)
				{
					num2 = 1;
				}
			}
			return num2;
		}
		return 1;
	}

	[SpecialName]
	public short qh(double A_0, bool A_1)
	{
		double num = A_0 + (double)t9();
		checked
		{
			if (u1())
			{
				short num2 = 500;
				double num3 = (double)m2(A_0, A_1) * num;
				if ((double)num2 * num < num3)
				{
					num2 = (short)Math.Round(num3 / num);
				}
				else
				{
					g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
					float num4 = ((!A_1 || opticsConfigSubmoduleTypes != g2.OpticsConfigSubmoduleTypes.ReflectanceProbe) ? 5000f : 10000f);
					if ((double)num2 * num > (double)num4)
					{
						num2 = (short)Math.Round((double)num4 / num);
						if (num2 < 3)
						{
							num2 = 3;
						}
					}
				}
				return num2;
			}
			return 4;
		}
	}

	[SpecialName]
	public global::h.MeasurementTimingType u3()
	{
		return this.m_ti.s();
	}

	[SpecialName]
	public double u4()
	{
		return this.m_ti.p();
	}

	[SpecialName]
	public new int m2(DateTime A_0, bool A_1)
	{
		iq a_ = null;
		double a_2 = qh(a_, A_1);
		return m2(a_2, A_1);
	}

	public new void m2(int A_0, DateTime A_1, ref float A_2, ref float A_3)
	{
		float[] array = ((this.m_ti.k() != g2.OpticsConfigSubmoduleTypes.CTMProbe) ? qh(A_0, A_1) : ((!rq) ? p9(A_0, A_1) : m2(A_0, A_1)));
		if (array != null)
		{
			A_2 = m2(array, ref A_3);
		}
		else
		{
			A_2 = 0f;
		}
	}

	[SpecialName]
	public int sj(int A_0, DateTime A_1)
	{
		float[] array = ((this.m_ti.k() != g2.OpticsConfigSubmoduleTypes.CTMProbe) ? qh(A_0, A_1) : ((!rq) ? p9(A_0, A_1) : m2(A_0, A_1)));
		if (array != null)
		{
			int A_2 = default(int);
			m2(array, 1, A_2: true, ref A_2);
			return A_2;
		}
		return 0;
	}

	[SpecialName]
	public int p9(int A_0, bool A_1, bool A_2)
	{
		float[] array = m2(A_0, A_1, A_2);
		if (array != null)
		{
			int A_3 = default(int);
			m2(array, 1, A_2: true, ab0(), this.m_p9, q2, ref A_3);
			return A_3;
		}
		return 0;
	}

	public new void m2(ref float A_0, ref float A_1)
	{
		g2.OpticsConfigSubmoduleTypes index = this.m_ti.k();
		float[] array = rc[(int)index];
		if (array != null)
		{
			A_0 = m2(array, ref A_1);
			return;
		}
		A_0 = 0f;
		A_1 = 0f;
	}

	[SpecialName]
	public double u5()
	{
		return re[(int)this.m_ti.k()];
	}

	public void p9(ref float A_0, ref float A_1)
	{
		if (qq == null || checked(qq.Count - 1) < (int)this.m_ti.k() || qq[(int)this.m_ti.k()] == null || qq[(int)this.m_ti.k()].Length == 0 || qq[(int)this.m_ti.k()][0].y() == null)
		{
			A_0 = 0f;
			A_1 = 0f;
		}
		else
		{
			A_0 = m2(qq[(int)this.m_ti.k()][0].y(), ref A_1);
		}
	}

	public void qh(ref float A_0, ref float A_1)
	{
		g2.OpticsConfigSubmoduleTypes index = this.m_ti.k();
		float[] array = qs[(int)index];
		if (array != null)
		{
			A_0 = m2(array, ref A_1);
			return;
		}
		A_0 = 0f;
		A_1 = 0f;
	}

	[SpecialName]
	public float u6()
	{
		g2.OpticsConfigSubmoduleTypes index = this.m_ti.k();
		float[] array = qv[(int)index];
		if (array != null)
		{
			return sj(array);
		}
		return 0f;
	}

	[SpecialName]
	public double s6(bool A_0)
	{
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
		if ((A_0 && opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.ReflectanceProbe) || vh())
		{
			return 1500.0;
		}
		if (opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.TransCurved)
		{
			return 5000.0;
		}
		return 250.0;
	}

	[SpecialName]
	public float u7()
	{
		return this.m_m2.GainProgress;
	}

	private new float[] m2(int A_0, bool A_1, bool A_2)
	{
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
		float[] array = null;
		checked
		{
			if (g2.c(opticsConfigSubmoduleTypes) || (A_1 && opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.ReflectanceProbe))
			{
				if (t3 == null)
				{
					array = null;
				}
				else
				{
					array = new float[this.m_p9 - 1 + 1];
					if (A_1 && opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.ReflectanceProbe && A_2)
					{
						int num = unchecked((int)opticsConfigSubmoduleTypes);
						if (r1 != null)
						{
							double num2 = this.m_t5 / sf;
							int num3 = this.m_p9 - 1;
							for (int num4 = 0; num4 <= num3; num4++)
							{
								array[num4] = (float)(t3[num4] - num2 * (double)r1[num4]);
							}
						}
						else if (qv[num] != null)
						{
							double num2 = this.m_t5 / ra[num];
							int num5 = this.m_p9 - 1;
							for (int num6 = 0; num6 <= num5; num6++)
							{
								array[num6] = (float)(t3[num6] - num2 * (double)qv[num][num6]);
							}
						}
					}
					else if (p9(A_1) && A_2)
					{
						int num7 = this.m_p9 - 1;
						for (int num8 = 0; num8 <= num7; num8++)
						{
							array[num8] = (float)(t3[num8] - (double)ry[A_0].v()[num8]);
						}
					}
					else
					{
						int num9 = this.m_p9 - 1;
						for (int num10 = 0; num10 <= num9; num10++)
						{
							array[num10] = (float)t3[num10];
						}
					}
				}
			}
			else
			{
				array = ry[A_0].v();
			}
			return array;
		}
	}

	public new float m2(int A_0, int A_1, ref int A_2, bool A_3, bool A_4)
	{
		this.m_ti.k();
		float[] array = m2(A_1, A_3, A_4);
		if (array != null)
		{
			return m2(array, A_0, A_2: true, ab0(), this.m_p9, q2, ref A_2);
		}
		return 0f;
	}

	public new float m2(int A_0, bool A_1, ref int A_2)
	{
		float[] array = ((!g2.c(this.m_ti.k())) ? rz : ry[0].v());
		if (array != null)
		{
			return m2(array, A_0, A_1, ref A_2);
		}
		return 0f;
	}

	private float sj(float[] A_0)
	{
		int A_1 = 0;
		return m2(A_0, 1, A_2: true, ref A_1);
	}

	private new float m2(float[] A_0, ref float A_1)
	{
		int A_2 = default(int);
		float result = m2(A_0, 1, A_2: true, ref A_2);
		A_1 = (float)q2[A_2];
		return result;
	}

	private new float m2(float[] A_0, int A_1, bool A_2, ref int A_3)
	{
		return m2(A_0, A_1, A_2, A_3: false, this.m_p9, null, ref A_3);
	}

	private new static float m2(float[] A_0, int A_1, bool A_2, int A_3, ref int A_4)
	{
		return m2(A_0, A_1, A_2, A_3: false, A_3, null, ref A_4);
	}

	private new static float m2(float[] A_0, int A_1, bool A_2, bool A_3, int A_4, double[] A_5, ref int A_6)
	{
		float num = float.MinValue;
		int num2 = checked(A_4 - 1);
		int num3 = checked(A_1 - 1) / 2;
		if (num3 < 0)
		{
			num3 = 0;
		}
		if (checked(2 * num3) > num2)
		{
			num3 = num2 / 2;
		}
		int num10 = default(int);
		int num12 = default(int);
		checked
		{
			if (A_2)
			{
				if (A_3)
				{
					double num4 = (A_5[0] + A_5[num2]) / 2.0;
					double num5 = 0.25 * (A_5[num2] - A_5[0]);
					double num6 = num4 - num5;
					double num7 = num4 + num5;
					int num8 = num2;
					for (int num9 = 0; num9 <= num8; num9++)
					{
						if (A_5[num9] >= num6)
						{
							num10 = num9;
							break;
						}
					}
					for (int num11 = num2; num11 >= 0; num11 += -1)
					{
						if (A_5[num11] <= num7)
						{
							num12 = num11;
							break;
						}
					}
				}
				else
				{
					num10 = 0;
					num12 = num2;
				}
				int num13 = num10;
				int num14 = num12;
				for (int num15 = num13; num15 <= num14; num15++)
				{
					if (num < A_0[num15])
					{
						num = A_0[num15];
						A_6 = num15;
					}
				}
			}
			num10 = A_6 - num3;
			if (num10 < 0)
			{
				num10 = 0;
			}
			num12 = num10 + 2 * num3;
			if (num12 > num2)
			{
				num12 = num2;
				num10 = num12 - 2 * num3;
			}
		}
		A_6 = checked(num12 + num10) / 2;
		double num16 = 0.0;
		int num17 = num10;
		int num18 = num12;
		checked
		{
			for (int num19 = num17; num19 <= num18; num19++)
			{
				num16 += (double)A_0[num19];
			}
			return (float)(num16 / (double)(num12 - num10 + 1));
		}
	}

	public new static float m2(double[] A_0, int A_1, bool A_2, int A_3, ref int A_4)
	{
		checked
		{
			float[] array = new float[A_0.Length - 1 + 1];
			int num = A_0.Length - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				array[num2] = (float)A_0[num2];
			}
			return m2(array, A_1, A_2, A_3, ref A_4);
		}
	}

	[SpecialName]
	public double u8()
	{
		return this.m_we;
	}

	public void qh(double A_0)
	{
		this.m_we = A_0;
	}

	public void sj(double A_0)
	{
		this.m_wd = A_0;
	}

	[SpecialName]
	public double u9()
	{
		return this.m_m2.IntegrationTime;
	}

	[SpecialName]
	public double va()
	{
		return this.m_m2.PostIntegrationReadoutTime;
	}

	[SpecialName]
	public float vb()
	{
		return this.m_m2.NotchSharpenAmplitude;
	}

	[SpecialName]
	public float vc()
	{
		return this.m_m2.NotchSharpenInterval;
	}

	[SpecialName]
	public float vd()
	{
		return this.m_m2.FWBaselineLinearityAmplitude;
	}

	[SpecialName]
	public float ve()
	{
		return this.m_m2.FWBaselineLinearityAmplitudeT;
	}

	[SpecialName]
	public bool vf()
	{
		if (b() == FMLegacyAllSystemTypes.kTypeF2)
		{
			return !this.m_s6;
		}
		return false;
	}

	public override string bc()
	{
		if (vf())
		{
			return ex.j(base.bc());
		}
		return base.bc();
	}

	[SpecialName]
	public bool vg()
	{
		FMLegacyAllSystemTypes num = b();
		FMF10Subtypes fMF10Subtypes = default(FMF10Subtypes);
		if (num == FMLegacyAllSystemTypes.kTypeF10)
		{
			fMF10Subtypes = (FMF10Subtypes)c();
		}
		if (num == FMLegacyAllSystemTypes.kTypeF10)
		{
			if (fMF10Subtypes != FMF10Subtypes.kFMF10SubtypeAR)
			{
				return fMF10Subtypes == FMF10Subtypes.kFMF10SubtypeARc;
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	public bool vh()
	{
		if (abb() > 0)
		{
			return true;
		}
		FMLegacyAllSystemTypes fMLegacyAllSystemTypes = b();
		FMF10Subtypes fMF10Subtypes = default(FMF10Subtypes);
		if (fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeF10)
		{
			fMF10Subtypes = (FMF10Subtypes)c();
		}
		return (fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeF10 && (fMF10Subtypes == FMF10Subtypes.kFMF10SubtypeVC || fMF10Subtypes == FMF10Subtypes.kFMF10SubtypeRT || fMF10Subtypes == FMF10Subtypes.kFMF10SubtypeRTA)) || fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypePARTS;
	}

	[SpecialName]
	public bool vi()
	{
		return abk().FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF60;
	}

	[SpecialName]
	public double vj()
	{
		return this.m_ti.r();
	}

	[SpecialName]
	public double vk()
	{
		if (rp != null && rp.Count > 0)
		{
			return rp[checked(rp.Count - 1)];
		}
		if (u2())
		{
			return vl();
		}
		return 2000.0;
	}

	[SpecialName]
	public double vl()
	{
		return this.m_m2.MaxIntegrationTime;
	}

	[SpecialName]
	public double vm()
	{
		return this.m_m2.MinIntegrationTime;
	}

	[SpecialName]
	public int vn()
	{
		return this.m_wi;
	}

	[SpecialName]
	public double vo()
	{
		return this.m_wj;
	}

	[SpecialName]
	public double sm(double A_0)
	{
		int num = vn();
		if (A_0 < vm())
		{
			A_0 = vm();
		}
		else if (A_0 > vl())
		{
			A_0 = vl();
		}
		A_0 = sn(A_0);
		checked
		{
			if (A_0 >= 100.0 * vo())
			{
				num--;
			}
			if (num >= 0)
			{
				return Math.Round(A_0, num, MidpointRounding.AwayFromZero);
			}
			double num2 = Math.Pow(10.0, -num);
			return Conversion.Int(Conversion.Int(A_0 / num2) * num2);
		}
	}

	[SpecialName]
	public double sn(double A_0)
	{
		return ((IFIUsbSpectrometer)this.m_m2).get_QuantizedIntegrationTime_ms(A_0);
	}

	[SpecialName]
	public double sm(int A_0, DateTime A_1)
	{
		c[] array = so(A_1);
		if (array == null)
		{
			return 0.0;
		}
		return array[A_0].j;
	}

	[SpecialName]
	public string vp()
	{
		return q6[(int)this.m_ti.k()];
	}

	private new void m2(string A_0, ex.a A_1, ref c[] A_2, ref bool A_3)
	{
		checked
		{
			int num = this.m_p9 - 1;
			string text = jb.u(A_0);
			if (!string.IsNullOrEmpty(text) && text.ToLower().EndsWith(".fitdr"))
			{
				if (A_2 == null || A_2.GetUpperBound(0) != 1)
				{
					A_2 = new c[2];
				}
				if (A_2[0] == null)
				{
					A_2[0] = new c();
				}
				if (A_2[1] == null)
				{
					A_2[1] = new c();
				}
				string[] A_4 = null;
				float A_5 = default(float);
				float A_6 = default(float);
				bool A_7 = default(bool);
				ex.e(text, ref A_4, ref A_5, ref A_6, ref A_7);
				A_2[0].o = A_4[0];
				A_2[1].o = A_4[1];
				if (A_7)
				{
					A_2[1].i = true;
				}
				else
				{
					A_2[0].i = true;
				}
				m2(A_1, A_2[0], ref A_3);
				bool A_8 = default(bool);
				m2(A_1, A_2[1], ref A_8);
				if (A_8)
				{
					A_3 = true;
				}
				float num2 = A_5 - 0.5f * A_6;
				float num3 = num2 + A_6;
				float[] array = new float[num + 1];
				float[] array2 = new float[num + 1];
				int num4 = num;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					float num6 = (float)q2[num5];
					if (num6 >= num2)
					{
						if (num6 < num3)
						{
							array2[num5] = (num6 - num2) / A_6;
						}
						else
						{
							array2[num5] = 1f;
						}
					}
					array[num5] = 1f - array2[num5];
				}
				A_2[0].ab(array);
				A_2[1].ab(array2);
			}
			else
			{
				if (A_2 == null || A_2.GetUpperBound(0) != 0)
				{
					A_2 = new c[1];
				}
				if (A_2[0] == null)
				{
					A_2[0] = new c();
				}
				A_2[0].o = A_0;
				m2(A_1, A_2[0], ref A_3);
			}
		}
	}

	private new void m2(ex.a A_0, c A_1, ref bool A_2)
	{
		ex ex2 = new ex();
		checked
		{
			int num = this.m_p9 - 1;
			double[] A_3 = null;
			float[] array = new float[num + 1];
			string text = A_1.o;
			string a_ = string.Empty;
			bool flag = Operators.CompareString(text, "FiberTip", TextCompare: false) == 0 || Operators.CompareString(text, "FiberTipPending", TextCompare: false) == 0;
			bool flag2 = default(bool);
			if (text != null && (text.StartsWith(ex.e()) || text.StartsWith(ex.f()) || flag))
			{
				flag2 = true;
				a_ = ((Operators.CompareString(text, "FiberTip", TextCompare: false) != 0 && !text.StartsWith(ex.e())) ? ex.f(text, ma) : ex.e(text, ma));
			}
			A_1.aa(array);
			if ((flag2 && ex2.e(a_, A_0, abh(), abf(), abg())) || ex2.e(text, A_0, abh(), abf(), abg()))
			{
				A_2 = false;
				if ((flag2 && ex2.e(ref A_3)) || (!flag2 && ex2.e(q2, this.m_p9, ref A_3)))
				{
					int num2 = num;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						array[num3] = (float)A_3[num3];
					}
				}
				else
				{
					int num4 = num;
					for (int num3 = 0; num3 <= num4; num3++)
					{
						array[num3] = 1f;
					}
				}
				return;
			}
			float A_4 = default(float);
			if (flag2)
			{
				m2(a_, ref A_4);
			}
			m2(text, ref A_4);
			if (A_4 <= 0f)
			{
				A_4 = 1f;
			}
			int num5 = num;
			for (int num3 = 0; num3 <= num5; num3++)
			{
				array[num3] = A_4;
			}
		}
	}

	private new void m2(string A_0, ref float A_1)
	{
		if (!float.TryParse(A_0, NumberStyles.Any, CultureInfo.InvariantCulture, out A_1) && !string.IsNullOrEmpty(A_0))
		{
			ab8().c(fz.b.a, "Error attempting to read reference material file " + A_0 + ". File may be missing or corrupted.");
		}
	}

	private new void m2(string A_0, ex.a A_1, ref float[] A_2, ref bool A_3)
	{
		c c10 = new c();
		c10.o = A_0;
		m2(A_1, c10, ref A_3);
		A_2 = c10.ab();
	}

	public new void m2(string A_0, ref bool A_1, ref float[] A_2)
	{
		checked
		{
			int num = this.m_p9 - 1;
			A_2 = new float[num + 1];
			float[] A_3 = new float[num + 1];
			float[] A_4 = new float[num + 1];
			m2(A_0, ex.a.a, ref A_3, ref A_1);
			if (A_1)
			{
				return;
			}
			m2("Si", ex.a.a, ref A_4, ref A_1);
			if (!A_1)
			{
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					A_2[num3] = A_3[num3] / A_4[num3];
				}
			}
		}
	}

	private new void m2(string A_0, g2.OpticsConfigSubmoduleTypes A_1)
	{
		bool A_3;
		if (Operators.CompareString(q6[(int)A_1], A_0, TextCompare: false) != 0)
		{
			qq[(int)A_1] = null;
			qs[(int)A_1] = null;
			qt[(int)A_1] = null;
			qu[(int)A_1] = null;
			qv[(int)A_1] = null;
			qw[(int)A_1] = null;
			b obj = this.m_ti;
			bool A_2 = false;
			A_3 = false;
			this.m_ti = obj.j(ref A_2, ref A_3);
			q6[(int)A_1] = A_0;
		}
		c[] A_4 = qq[(int)A_1];
		ex.a a_ = g2.j(A_1);
		A_3 = false;
		m2(A_0, a_, ref A_4, ref A_3);
		qq[(int)A_1] = A_4;
	}

	[SpecialName]
	public string vq()
	{
		return sb;
	}

	public new void m2(string A_0, ref bool A_1)
	{
		if (Operators.CompareString(sb, A_0, TextCompare: false) != 0)
		{
			r9 = false;
			ry = null;
			sb = A_0;
		}
		m2(A_0, g2.j(this.m_ti.k()), ref ry, ref A_1);
	}

	public bool vr()
	{
		return this.m_m2.FWWriteEnabled != 0;
	}

	public new int m2(ref Collection<ia> A_0)
	{
		byte b10 = 0;
		bool flag = false;
		A_0 = new Collection<ia>();
		int num;
		byte A_1 = default(byte);
		double A_2 = default(double);
		do
		{
			ia ia2 = new ia();
			ia ia3 = ia2;
			num = m2(b10, ref A_1, ref ia3.b, ref A_2, ref ia3.d, ref ia3.e, ref ia3.f, ref ia3.g);
			if (num == 0)
			{
				flag = ia3.d == 0 && ia3.e == 0 && ia3.f == 0;
				if (!flag)
				{
					ia3.a = (h8)A_1;
					ia3.c = DateTime.FromOADate(A_2);
					A_0.Add(ia2);
					b10 = checked((byte)(b10 + 1));
				}
			}
			ia3 = null;
		}
		while (num == 0 && !flag);
		return num;
	}

	private new int m2(byte A_0, ref byte A_1, ref string A_2, ref double A_3, ref ushort A_4, ref ushort A_5, ref ushort A_6, ref ushort A_7)
	{
		int lErrCode = default(int);
		this.m_m2.ReadMemBlockID(A_0, ref A_1, ref A_2, ref A_3, ref A_4, ref A_5, ref A_6, ref A_7, ref lErrCode);
		return lErrCode;
	}

	private new bool m2(ref DateTime A_0, ref double A_1, ref float[] A_2)
	{
		if (qq != null && qq[9] != null && qq[9].Length > 0)
		{
			c c10 = qq[9][0];
			A_0 = c10.n;
			A_1 = c10.j;
			A_2 = c10.w();
			c10 = null;
			return true;
		}
		return false;
	}

	public int vs()
	{
		checked
		{
			return m2(2, (short)unchecked(this.m_m2.BuiltInMemorySize - 2), new byte[2] { 255, 255 });
		}
	}

	public new int m2(ref ushort A_0, ia A_1, byte[] A_2)
	{
		ih ih2 = new ih(A_0, A_1.a, A_1.c, A_1.b, A_2);
		byte[] a_ = ih2.e();
		int result = checked(m2((short)ih2.f(), (short)ih2.h(), a_));
		A_0 = ih2.i();
		ih2 = null;
		return result;
	}

	public new int m2(short A_0, short A_1, byte[] A_2)
	{
		int lErrCode = default(int);
		this.m_m2.WriteBuiltInMemory(A_0, A_1, A_2, ref lErrCode);
		return lErrCode;
	}

	public int p9(short A_0, short A_1, byte[] A_2)
	{
		int lErrCode = default(int);
		this.m_m2.ReadBuiltInMemory(A_0, A_1, A_2, ref lErrCode);
		return lErrCode;
	}

	private new int m2(Collection<ia> A_0, h8 A_1)
	{
		if (A_0.Count == 0)
		{
			return -1;
		}
		checked
		{
			int num = A_0.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (A_0[num2].a == A_1)
				{
					return num2;
				}
			}
			return -1;
		}
	}

	private new int m2(Collection<ia> A_0, h8 A_1, string A_2)
	{
		if (A_0.Count == 0)
		{
			return -1;
		}
		checked
		{
			int num = A_0.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (A_0[num2].a == A_1 && Operators.CompareString(A_0[num2].b, A_2, TextCompare: false) == 0)
				{
					return num2;
				}
			}
			return -1;
		}
	}

	private new int m2(Collection<ia> A_0)
	{
		if (A_0.Count == 0)
		{
			return -1;
		}
		checked
		{
			if (A_0[A_0.Count - 1].a == h8.b)
			{
				return A_0.Count - 1;
			}
			return -1;
		}
	}

	private new int m2(DateTime A_0, double A_1, string A_2, bool A_3, bool A_4, float[] A_5)
	{
		Collection<ia> A_6 = null;
		int num = m2(ref A_6);
		if (num != 0)
		{
			return num;
		}
		int num2 = m2(A_6);
		checked
		{
			ushort a_ = ((A_6.Count == 0 || num2 == 0) ? ((ushort)this.m_m2.BuiltInMemorySize) : ((num2 >= 0) ? A_6[num2 - 1].g : A_6[A_6.Count - 1].g));
			ii ii2 = null;
			ii2 = ((!A_3) ? new ii(a_, A_0, A_1, A_2, A_4, A_5) : new ii(a_, A_0, A_1, A_2, 0, A_4, A_5));
			byte[] a_2 = ii2.e();
			return m2((short)ii2.f(), (short)ii2.h(), a_2);
		}
	}

	private int uc()
	{
		Collection<ia> A_ = null;
		int num = m2(ref A_);
		if (num != 0)
		{
			return num;
		}
		float[] A_2 = null;
		int num2 = m2(A_);
		checked
		{
			DateTime A_3 = default(DateTime);
			double A_4 = default(double);
			if (num2 >= 0 && m2(ref A_3, ref A_4, ref A_2) && DateTime.Compare(A_[num2].c, A_3) > 0)
			{
				short a_ = (short)A_[num2].e;
				short num3 = (short)A_[num2].d;
				byte[] array = new byte[num3 - 1 + 1];
				num = p9(num3, a_, array);
				if (num != 0)
				{
					return num;
				}
				ib ib2 = new ib();
				ib2.d(array);
				rq = ib2.e();
				c c10 = new c();
				A_2 = new float[this.m_p9 - 1 + 1];
				c c11 = c10;
				c10.o = "0";
				if (rq)
				{
					c11.w(ib2.d(A_2.Length));
					c11.u(c11.x());
					c11.v(c11.x());
				}
				else
				{
					c11.v(ib2.d(A_2.Length));
					c11.u(c11.w());
				}
				c11.n = A_[num2].c;
				c11.j = ib2.d();
				c11.o = "0";
				c11 = null;
				bool A_5 = false;
				m2(ex.a.a, c10, ref A_5);
				q6[9] = "0";
				qq[9][0] = c10;
				b obj = this.m_ti;
				A_5 = true;
				this.m_ti = obj.j(ref A_5);
				this.m_ti.l();
				yg();
				A_5 = false;
				bool A_6 = false;
				m2(null, null, ref A_5, A_3: false, ref A_6);
				ab8().c(fz.b.a, "The CTM Reference was missing and has been updated with the reference from memory dated " + c10.n.ToString() + ".");
			}
			return 0;
		}
	}

	public new int m2(Collection<cf> A_0, bool A_1)
	{
		bool flag = false;
		Collection<ia> collection = new Collection<ia>();
		Collection<byte[]> collection2 = new Collection<byte[]>();
		Collection<ia> collection3 = new Collection<ia>();
		Collection<byte[]> collection4 = new Collection<byte[]>();
		Collection<ia> A_2 = null;
		checked
		{
			ushort a_ = default(ushort);
			int num = default(int);
			if (A_1)
			{
				a_ = (ushort)this.m_m2.BuiltInMemorySize;
			}
			else
			{
				num = m2(ref A_2);
				if (num != 0)
				{
					return num;
				}
				if (A_2.Count > 0)
				{
					int num2 = A_2.Count - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						ia ia2 = A_2[num3];
						if (!flag && (ia2.a == h8.c || ia2.a == h8.b))
						{
							flag = true;
							a_ = ((num3 != 0) ? A_2[num3 - 1].g : ((ushort)this.m_m2.BuiltInMemorySize));
						}
						if (flag && ia2.a != h8.c)
						{
							byte[] array = new byte[ia2.d - 1 + 1];
							num = p9((short)ia2.d, (short)ia2.e, array);
							if (num != 0)
							{
								return num;
							}
							if (ia2.a == h8.b)
							{
								collection3.Add(A_2[num3]);
								collection4.Add(array);
							}
							else
							{
								collection.Add(A_2[num3]);
								collection2.Add(array);
							}
						}
						ia2 = null;
					}
					int num4 = collection2.Count - 1;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						if (collection[num5].a == h8.a)
						{
							ig ig2 = new ig(a_, collection[num5].c, new string(Encoding.Unicode.GetChars(collection2[num5])));
							byte[] a_2 = ig2.e();
							num = m2((short)ig2.f(), (short)ig2.h(), a_2);
							a_ = ig2.i();
							ig2 = null;
						}
						if (num != 0)
						{
							return num;
						}
					}
					if (!flag)
					{
						a_ = A_2[A_2.Count - 1].g;
					}
				}
				else
				{
					a_ = (ushort)this.m_m2.BuiltInMemorySize;
				}
			}
			foreach (cf item in A_0)
			{
				ij ij2 = new ij(a_, item);
				byte[] a_3 = ij2.e();
				num = m2((short)ij2.f(), (short)ij2.h(), a_3);
				a_ = ij2.i();
				ij2 = null;
			}
			int num6 = collection4.Count - 1;
			for (int num7 = 0; num7 <= num6; num7++)
			{
				ia ia3 = collection3[num7];
				ii obj = new ii(a_, ia3.c, ia3.b, collection4[num7]);
				ia3 = null;
				ii ii2 = obj;
				byte[] a_4 = ii2.e();
				num = m2((short)ii2.f(), (short)ii2.h(), a_4);
				a_ = ii2.i();
				ii2 = null;
				if (num != 0)
				{
					return num;
				}
			}
			return num;
		}
	}

	private int ub()
	{
		Collection<ia> A_ = null;
		checked
		{
			int num = this.m_p9 - 1;
			Collection<int> collection = new Collection<int>();
			int num2 = m2(ref A_);
			if (num2 != 0)
			{
				return num2;
			}
			if (A_.Count > 0)
			{
				int num3 = A_.Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					ia ia2 = A_[num4];
					if (ia2.a == h8.e)
					{
						int num5 = Conversions.ToInteger(ia2.b);
						if (DateTime.Compare(this.m_wn[num5], DateTime.MinValue) == 0 || DateTime.Compare(ia2.c, this.m_wn[num5]) > 0)
						{
							byte[] array = new byte[ia2.d - 1 + 1];
							num2 = p9((short)ia2.d, (short)ia2.e, array);
							ie obj = new ie(h9.b, this.m_p9);
							obj.d(array);
							double[] array2 = obj.i();
							double[] array3 = obj.h();
							string A_2 = obj.g();
							double[] A_3 = null;
							m2(ref A_2, ref A_3);
							float[] array4 = new float[num + 1];
							float[] array5 = new float[num + 1];
							float[] array6 = new float[num + 1];
							int num6 = num;
							for (int num7 = 0; num7 <= num6; num7++)
							{
								array4[num7] = (float)array3[num7];
								array5[num7] = (float)array2[num7];
								array6[num7] = (float)A_3[num7];
							}
							this.m_wk[num5] = array4;
							this.m_wl[num5] = array5;
							this.m_wn[num5] = ia2.c;
							tj();
							collection.Add(num5);
							ab8().c(fz.b.a, "The LinSpec file was missing and has been updated with the linear spec data from memory dated " + ia2.c.ToString() + ".");
						}
					}
					ia2 = null;
				}
				if (collection.Count > 0)
				{
					foreach (int item in collection)
					{
						if (!string.IsNullOrEmpty(vp()))
						{
							sm(unchecked((g2.OpticsConfigSubmoduleTypes)item));
						}
					}
				}
			}
			return 0;
		}
	}

	private int st(DateTime A_0)
	{
		checked
		{
			try
			{
				Collection<ia> A_1 = null;
				int num = this.m_p9 - 1;
				int num2 = m2(ref A_1);
				if (num2 != 0)
				{
					return num2;
				}
				if (A_1.Count > 0)
				{
					int num3 = m2(A_1, h8.d);
					if (num3 >= 0 && (DateTime.Compare(A_0, DateTime.MinValue) == 0 || DateTime.Compare(A_1[num3].c, A_0) > 0))
					{
						ia ia2 = A_1[num3];
						ie obj = new ie(h9.a, this.m_p9);
						byte[] array = new byte[ia2.d - 1 + 1];
						num2 = p9((short)ia2.d, (short)ia2.e, array);
						obj.d(array);
						double[] array2 = new double[num + 1];
						array2 = obj.h();
						this.m_wc = new float[num + 1];
						int num4 = num;
						for (int num5 = 0; num5 <= num4; num5++)
						{
							this.m_wc[num5] = (float)array2[num5];
						}
						sn(ia2.c);
						ab8().c(fz.b.a, "The PersistSpec file was missing and has been updated with the persistent data from memory dated " + ia2.c.ToString() + ".");
						ia2 = null;
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				ab8().c(fz.b.b, "Error in USBSpectrometerDevice.UpdatePersistenSpecFromMemoryIfNecessary", a_);
				ProjectData.ClearProjectError();
			}
			return 0;
		}
	}

	private int ua()
	{
		Collection<ia> A_ = null;
		checked
		{
			_ = this.m_p9 - 1;
			int num = m2(ref A_);
			if (num != 0)
			{
				return num;
			}
			if (A_.Count > 0)
			{
				int num2 = m2(A_, h8.f);
				if (num2 >= 0)
				{
					ia ia2 = A_[num2];
					id id2 = new id();
					byte[] array = new byte[ia2.d - 1 + 1];
					num = p9((short)ia2.d, (short)ia2.e, array);
					id2.b(array);
					this.m_we = id2.b();
					ia2 = null;
				}
			}
			return 0;
		}
	}

	private new int m2(ie A_0, DateTime A_1)
	{
		Collection<ia> A_2 = null;
		new Collection<byte[]>();
		Collection<ia> collection = new Collection<ia>();
		Collection<byte[]> collection2 = new Collection<byte[]>();
		h8 h10 = default(h8);
		switch (A_0.f())
		{
		case h9.b:
			h10 = h8.e;
			break;
		case h9.a:
			h10 = h8.d;
			break;
		}
		int num = m2(ref A_2);
		if (num != 0)
		{
			return num;
		}
		int num2 = m2(A_2, h8.c);
		if (num2 < 0)
		{
			num2 = m2(A_2, h8.b);
		}
		if (num2 >= 0)
		{
			throw new ApplicationException("Attempting to write LinSpec or F2Persistent Memory Block when CTM memory blocks already exist. CTM memory blocks must be erased first.");
		}
		checked
		{
			ushort a_;
			if (A_2.Count > 0)
			{
				int num3 = default(int);
				switch (A_0.f())
				{
				case h9.b:
					num3 = m2(A_2, h10, A_0.e());
					break;
				case h9.a:
					num3 = m2(A_2, h10);
					break;
				}
				if (num3 < 0)
				{
					a_ = A_2[A_2.Count - 1].g;
				}
				else
				{
					a_ = ((num3 != 0) ? A_2[num3 - 1].g : ((ushort)this.m_m2.BuiltInMemorySize));
					int num4 = num3 + 1;
					int num5 = A_2.Count - 1;
					for (int num6 = num4; num6 <= num5; num6++)
					{
						ia ia2 = A_2[num6];
						byte[] array = new byte[ia2.d - 1 + 1];
						num = p9((short)ia2.d, (short)ia2.e, array);
						if (num != 0)
						{
							return num;
						}
						collection.Add(A_2[num6]);
						collection2.Add(array);
						ia2 = null;
					}
				}
			}
			else
			{
				a_ = (ushort)this.m_m2.BuiltInMemorySize;
			}
			il il2 = new il(a_, A_0, h10, A_1);
			byte[] a_2 = il2.e();
			num = m2((short)il2.f(), (short)il2.h(), a_2);
			a_ = il2.i();
			il2 = null;
			int num7 = collection2.Count - 1;
			for (int num8 = 0; num8 <= num7; num8++)
			{
				num = m2(ref a_, collection[num8], collection2[num8]);
				if (num != 0)
				{
					return num;
				}
			}
			return num;
		}
	}

	private new int m2(id A_0)
	{
		Collection<ia> A_1 = null;
		new Collection<byte[]>();
		Collection<ia> collection = new Collection<ia>();
		Collection<byte[]> collection2 = new Collection<byte[]>();
		int num = m2(ref A_1);
		if (num != 0)
		{
			return num;
		}
		int num2 = m2(A_1, h8.c);
		if (num2 < 0)
		{
			num2 = m2(A_1, h8.b);
		}
		if (num2 >= 0)
		{
			throw new ApplicationException("Attempting to write LinSpec or F2Persistent Memory Block when CTM memory blocks already exist. CTM memory blocks must be erased first.");
		}
		checked
		{
			ushort a_;
			if (A_1.Count > 0)
			{
				int num3 = m2(A_1, h8.f);
				if (num3 < 0)
				{
					a_ = A_1[A_1.Count - 1].g;
				}
				else
				{
					a_ = ((num3 != 0) ? A_1[num3 - 1].g : ((ushort)this.m_m2.BuiltInMemorySize));
					int num4 = num3 + 1;
					int num5 = A_1.Count - 1;
					for (int num6 = num4; num6 <= num5; num6++)
					{
						ia ia2 = A_1[num6];
						byte[] array = new byte[ia2.d - 1 + 1];
						num = p9((short)ia2.d, (short)ia2.e, array);
						if (num != 0)
						{
							return num;
						}
						collection.Add(A_1[num6]);
						collection2.Add(array);
						ia2 = null;
					}
				}
			}
			else
			{
				a_ = (ushort)this.m_m2.BuiltInMemorySize;
			}
			ik ik2 = new ik(a_, A_0);
			byte[] a_2 = ik2.e();
			num = m2((short)ik2.f(), (short)ik2.h(), a_2);
			a_ = ik2.i();
			ik2 = null;
			int num7 = collection2.Count - 1;
			for (int num8 = 0; num8 <= num7; num8++)
			{
				num = m2(ref a_, collection[num8], collection2[num8]);
				if (num != 0)
				{
					return num;
				}
			}
			return num;
		}
	}

	public new int m2(SpectromTempSensorLoc A_0, ref float A_1)
	{
		w8();
		return this.m_m2.ReadTemperature(A_0, out A_1);
	}

	[SpecialName]
	public new bool m2(SpectromTempSensorLoc A_0)
	{
		return ((IFIUsbSpectrometer)this.m_m2).get_TemperatureSensorExists(A_0) != 0;
	}

	[SpecialName]
	public bool vt()
	{
		return this.m_m2.LightSourceIsStrobe != 0;
	}

	[SpecialName]
	public float vu()
	{
		return (float)q2[0];
	}

	[SpecialName]
	public float vv()
	{
		return (float)q2[checked(this.m_p9 - 1)];
	}

	[SpecialName]
	public int vw()
	{
		checked
		{
			int num = this.m_s4[unchecked((int)this.m_ti.k())] - this.m_s3[unchecked((int)this.m_ti.k())] + 1;
			if (num < 0)
			{
				num = 0;
			}
			return num;
		}
	}

	[SpecialName]
	public int vx()
	{
		c[] array = qq[(int)this.m_ti.k()];
		if (array == null)
		{
			return 0;
		}
		return checked(array.GetUpperBound(0) + 1);
	}

	[SpecialName]
	public int vy()
	{
		if (ry == null)
		{
			return 0;
		}
		return checked(ry.GetUpperBound(0) + 1);
	}

	[SpecialName]
	public g2.OpticsConfigSubmoduleTypes vz()
	{
		return this.m_ti.k();
	}

	[SpecialName]
	public void sj(g2.OpticsConfigSubmoduleTypes A_0)
	{
		if (this.m_ti.k() != A_0)
		{
			p9(A_0: false, 0);
		}
		this.m_ti = this.m_ti.j(A_0);
	}

	[SpecialName]
	public bool v0()
	{
		FIUsbController fIUsbController = abk();
		if (fIUsbController.FWInstTypeCodeAsEnum != FMLegacyAllSystemTypes.kTypeF40 && fIUsbController.FWInstTypeCodeAsEnum != FMLegacyAllSystemTypes.kTypeF20_F40 && fIUsbController.FWInstTypeCodeAsEnum != FMLegacyAllSystemTypes.kTypeF40NSR && (fIUsbController.FWInstTypeCodeAsEnum != FMLegacyAllSystemTypes.kTypeF50_300B || fIUsbController.FWSystemSubtype != 1) && (fIUsbController.FWInstTypeCodeAsEnum != FMLegacyAllSystemTypes.kTypeF60 || (fIUsbController.FWSystemSubtype != 2 && fIUsbController.FWSystemSubtype != 1)))
		{
			return yc();
		}
		return true;
	}

	[SpecialName]
	public bool v1()
	{
		FIUsbController fIUsbController = abk();
		if (fIUsbController.FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF40 || fIUsbController.FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF40NSR || (fIUsbController.FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF50_300B && fIUsbController.FWSystemSubtype == 1) || (fIUsbController.FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF60 && (fIUsbController.FWSystemSubtype == 2 || fIUsbController.FWSystemSubtype == 1)))
		{
			return zd();
		}
		return true;
	}

	[SpecialName]
	public bool v2()
	{
		FIUsbController fIUsbController = abk();
		if (fIUsbController.FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF10)
		{
			if (fIUsbController.FWSystemSubtype != 6)
			{
				return fIUsbController.FWSystemSubtype == 8;
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	public new void m2(et A_0)
	{
		tk = tk.i(A_0);
	}

	[SpecialName]
	public new void m2(cf A_0)
	{
		tk = tk.i(A_0);
		checked
		{
			if (A_0 != null)
			{
				m2(g2.OpticsConfigSubmoduleTypes.CTMProbe, (float)A_0.q());
				p9(g2.OpticsConfigSubmoduleTypes.CTMProbe, (float)A_0.r());
				this.m_v4 = A_0.w().a0();
				if (A_0.w().bb() > 0)
				{
					int num = A_0.w().bb() - 1;
					double[] array = new double[num + 1];
					double[] array2 = new double[num + 1];
					this.m_v6 = new double[this.m_p9 - 1 + 1];
					int num2 = num;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						array[num3] = A_0.w().ax(num3);
						array2[num3] = A_0.w().ay(num3);
					}
					m2(array, array2, this.m_p9, q2, ref this.m_v6);
				}
				else
				{
					this.m_v6 = null;
					this.m_v4 = false;
				}
			}
			else
			{
				this.m_v4 = false;
			}
		}
	}

	[SpecialName]
	public bool v3()
	{
		return rf[(int)this.m_ti.k()] != null;
	}

	[SpecialName]
	public float v4()
	{
		return rg[(int)this.m_ti.k()];
	}

	[SpecialName]
	public bool v5()
	{
		return rf[(int)this.m_ti.k()] != null;
	}

	[SpecialName]
	public bool v6()
	{
		c[] array = qq[(int)this.m_ti.k()];
		if (array != null && array[0] != null)
		{
			return array[0].y() != null;
		}
		return false;
	}

	[SpecialName]
	public new bool m2(iq A_0)
	{
		c[] array = qq[(int)this.m_ti.k()];
		if (array == null)
		{
			return false;
		}
		int upperBound = array.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (array[num] == null || !array[num].u())
			{
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	public bool p9(iq A_0)
	{
		return qs[(int)this.m_ti.k()] != null;
	}

	[SpecialName]
	public bool v8()
	{
		return qv[(int)this.m_ti.k()] != null;
	}

	[SpecialName]
	public string v9()
	{
		return sb;
	}

	[SpecialName]
	public bool wa()
	{
		return sp;
	}

	[SpecialName]
	public void s8(bool A_0)
	{
		sp = A_0;
	}

	public new bool m2(float A_0, int A_1, bool A_2, ref double A_3, ref DateTime A_4, ref double A_5)
	{
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
		bool num = g2.c(opticsConfigSubmoduleTypes);
		c c10 = ry[A_1];
		float a_;
		if (num || (A_2 && opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.ReflectanceProbe))
		{
			this.m_t8 = p9(A_1, A_2, A_2: true);
			this.m_ua = c10.ab()[this.m_t8];
			int A_6 = 0;
			this.m_t9 = m2(1, A_1, ref A_6, A_2, A_4: true);
			a_ = ((!(this.m_t5 > 0.0) || !(this.m_t9 > 0f)) ? 0f : ((float)((double)this.m_t9 / ((double)(100f * this.m_ua) * this.m_t5))));
		}
		else if (c10.j > 0.0)
		{
			int A_6 = 0;
			a_ = (float)((double)m2(1, A_1, ref A_6, A_2, A_4: false) / ((double)(100f * c10.ab()[p9(A_1, A_2, A_2: false)]) * c10.j));
		}
		else
		{
			if (opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.TransCurved && c10.y() == null)
			{
				return true;
			}
			a_ = 0f;
		}
		c10 = null;
		if (A_2 && opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.ReflectanceProbe && this.m_t9 == 0f)
		{
			return true;
		}
		return m2(A_0, a_, this.m_ti.k(), ref A_3, ref A_4, ref A_5);
	}

	[SpecialName]
	public new bool m2(string A_0)
	{
		if (Operators.CompareString(this.m_t7, A_0, TextCompare: false) != 0)
		{
			return false;
		}
		return t4;
	}

	[SpecialName]
	public new bool m2(int A_0, string A_1)
	{
		if (Operators.CompareString(sb, A_1, TextCompare: false) != 0)
		{
			return false;
		}
		if (ry == null || A_0 > ry.GetUpperBound(0) || ry[A_0] == null)
		{
			return false;
		}
		return ry[A_0].u();
	}

	[SpecialName]
	public int wb()
	{
		if (ry == null)
		{
			return 0;
		}
		if (ry.GetUpperBound(0) == 0)
		{
			return 0;
		}
		int upperBound = ry.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (ry[num].i)
			{
				return num;
			}
		}
		throw new ApplicationException("None of the pending references have their highest peak raw reflectance flag set");
	}

	[SpecialName]
	public double sm(int A_0)
	{
		return ry[A_0].j;
	}

	[SpecialName]
	public double wc()
	{
		return this.m_t5;
	}

	[SpecialName]
	public bool wd()
	{
		return rz != null;
	}

	[SpecialName]
	public bool we()
	{
		return r1 != null;
	}

	[SpecialName]
	public bool s3(DateTime A_0)
	{
		if (DateTime.Compare(qy[(int)this.m_ti.k()], A_0) == 0)
		{
			return rf[(int)this.m_ti.k()] != null;
		}
		return false;
	}

	[SpecialName]
	public global::h.MeasurementTimingType s4(DateTime A_0)
	{
		return qz[(int)this.m_ti.k()];
	}

	[SpecialName]
	public bool sn(int A_0)
	{
		return ry[A_0].p;
	}

	[SpecialName]
	public void qh(int A_0, bool A_1)
	{
		ry[A_0].p = A_1;
	}

	[SpecialName]
	private new bool m2(c A_0)
	{
		return A_0.p;
	}

	public new bool m2(iq A_0, bool A_1)
	{
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
		if (p9(A_1) || (m2(A_0) && opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.CTMProbe))
		{
			return true;
		}
		c[] array = qq[(int)this.m_ti.k()];
		int upperBound = array.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			switch (this.m_ti.s())
			{
			case global::h.MeasurementTimingType.Manual:
			{
				iq a_ = null;
				if (!m2(qh(a_, A_1), array[num].j))
				{
					return false;
				}
				break;
			}
			case global::h.MeasurementTimingType.Maximum:
				switch (qz[(int)opticsConfigSubmoduleTypes])
				{
				case global::h.MeasurementTimingType.Recommended:
					if (array[num].j > vj())
					{
						return false;
					}
					break;
				case global::h.MeasurementTimingType.Maximum:
					if (m2(array[num]))
					{
						if (!m2(vj(), array[num].j))
						{
							return false;
						}
					}
					else if (jf.b((float)array[num].j, (float)vj()) && !m2(array[num].j, vj()))
					{
						return false;
					}
					break;
				case global::h.MeasurementTimingType.Manual:
					return false;
				}
				break;
			case global::h.MeasurementTimingType.Recommended:
				switch (qz[(int)opticsConfigSubmoduleTypes])
				{
				case global::h.MeasurementTimingType.Maximum:
					if (m2(array[num]))
					{
						return false;
					}
					break;
				case global::h.MeasurementTimingType.Manual:
					return false;
				}
				break;
			}
		}
		return true;
	}

	public bool p9(iq A_0, bool A_1)
	{
		if (p9(A_1))
		{
			return true;
		}
		double a_ = q9[(int)this.m_ti.k()];
		if (m2(qh(A_0, A_1), a_) || w2())
		{
			return true;
		}
		return false;
	}

	public new void m2(double A_0, short A_1, double A_2, global::h.MeasurementTimingType A_3, bool A_4)
	{
		if (A_3 != this.m_ti.s() && A_4)
		{
			p9(A_0: false, 0);
		}
		this.m_ti = this.m_ti.j(ref A_0, ref A_1, A_2, A_3);
	}

	public void p9(bool A_0, bool A_1)
	{
		this.m_ti = this.m_ti.j(ref A_0, ref A_1);
	}

	[SpecialName]
	public bool wf()
	{
		return this.m_ti.l();
	}

	[SpecialName]
	public bool wg()
	{
		return this.m_ti.m();
	}

	[SpecialName]
	private float t9()
	{
		bool flag = abk().USBHighSpeedActive != 0;
		switch (this.m_m2.eSpectromType)
		{
		case FMUSBDeviceType.FMUSBDeviceVisHama:
		case FMUSBDeviceType.FMUSBDeviceIRHama:
			return 25f;
		case FMUSBDeviceType.FMUSBDeviceSony:
			return 100f;
		default:
			if (flag)
			{
				return 0f;
			}
			return 25f;
		}
	}

	[SpecialName]
	private int qh(g2.OpticsConfigSubmoduleTypes A_0)
	{
		return this.m_s3[(int)A_0];
	}

	[SpecialName]
	private void p9(g2.OpticsConfigSubmoduleTypes A_0, int A_1)
	{
		if (A_1 != this.m_s3[(int)A_0])
		{
			this.m_s3[(int)A_0] = A_1;
			q3[(int)A_0] = Guid.NewGuid();
		}
	}

	[SpecialName]
	private int p9(g2.OpticsConfigSubmoduleTypes A_0)
	{
		return this.m_s4[(int)A_0];
	}

	[SpecialName]
	private new void m2(g2.OpticsConfigSubmoduleTypes A_0, int A_1)
	{
		if (A_1 != this.m_s4[(int)A_0])
		{
			this.m_s4[(int)A_0] = A_1;
			q3[(int)A_0] = Guid.NewGuid();
		}
	}

	[SpecialName]
	public new void m2(g2.OpticsConfigSubmoduleTypes A_0, float A_1)
	{
		checked
		{
			if (jf.d((float)q2[0], A_1))
			{
				if (this.m_p9 == 1)
				{
					p9(A_0, 1);
					return;
				}
				int num = default(int);
				bool flag = default(bool);
				do
				{
					num++;
					if (q2[num] >= (double)A_1)
					{
						flag = true;
					}
				}
				while (num < this.m_p9 - 1 && !flag);
				if (flag)
				{
					p9(A_0, num);
				}
				else
				{
					p9(A_0, this.m_p9);
				}
			}
			else if (this.m_p9 == 1)
			{
				p9(A_0, 1);
			}
			else
			{
				p9(A_0, 0);
			}
		}
	}

	[SpecialName]
	public void p9(g2.OpticsConfigSubmoduleTypes A_0, float A_1)
	{
		checked
		{
			if (jf.b((float)q2[this.m_p9 - 1], A_1))
			{
				if (this.m_p9 == 1)
				{
					m2(A_0, -1);
					return;
				}
				int num = this.m_p9;
				bool flag = default(bool);
				do
				{
					num--;
					if (q2[num] <= (double)A_1)
					{
						flag = true;
					}
				}
				while (num > 0 && !flag);
				if (flag)
				{
					m2(A_0, num);
				}
				else
				{
					m2(A_0, -1);
				}
			}
			else if (this.m_p9 == 1)
			{
				m2(A_0, -1);
			}
			else
			{
				m2(A_0, this.m_p9 - 1);
			}
		}
	}

	[SpecialName]
	public DateTime sj(int A_0, bool A_1)
	{
		return qq[(int)this.m_ti.k()][A_0].n;
	}

	[SpecialName]
	public int wh()
	{
		object obj = this.m_vk;
		ObjectFlowControl.CheckForSyncLockOnValueType(obj);
		bool lockTaken = false;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			return this.m_vp;
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	[SpecialName]
	private int t8()
	{
		g2.OpticsConfigSubmoduleTypes index = this.m_ti.k();
		if (qq[(int)index][0].l >= 1)
		{
			return Math.Max(checked((int)Math.Round(unchecked(qq[(int)index][0].j * (double)qq[(int)index][0].l))), 10000);
		}
		return 60000;
	}

	[SpecialName]
	public bool wi()
	{
		return this.m_vc;
	}

	[SpecialName]
	public float wj()
	{
		object obj = this.m_vk;
		ObjectFlowControl.CheckForSyncLockOnValueType(obj);
		bool lockTaken = false;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			float val = ((!this.m_vq) ? ((float)(0.0 * Math.Min(this.m_vl / 5000.0, 1.0))) : ((float)(50.0 * this.m_vo)));
			float val2 = (float)(100.0 * Math.Min(this.m_vm / (double)t8(), 1.0));
			float num = Math.Max(val, val2);
			if (num > 60f || jf.e(this.m_vo, 0.0))
			{
				this.m_vq = false;
			}
			return num * (float)Math.Min(this.m_vo, 1.0);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	[SpecialName]
	public DateTime wk()
	{
		return q7[(int)this.m_ti.k()];
	}

	[SpecialName]
	public void s6(DateTime A_0)
	{
		q7[(int)this.m_ti.k()] = A_0;
	}

	public void p9(DateTime A_0, bool A_1)
	{
		s8(A_0);
		p9(A_0: true, A_1: true);
		if (!A_1)
		{
			yg();
		}
	}

	[SpecialName]
	public void s8(DateTime A_0)
	{
		qy[(int)this.m_ti.k()] = A_0;
	}

	[SpecialName]
	public new bool m2(DateTime A_0, iq A_1)
	{
		return DateTime.Compare(qy[(int)this.m_ti.k()], A_0) == 0;
	}

	[SpecialName]
	public int wl()
	{
		return sr;
	}

	[SpecialName]
	public float wm()
	{
		return qg;
	}

	[SpecialName]
	public bool wn()
	{
		return r4 != null;
	}

	[SpecialName]
	public double wo()
	{
		return r5;
	}

	public float[] wp()
	{
		return rf[(int)this.m_ti.k()];
	}

	[SpecialName]
	private bool t7()
	{
		return this.m_m2.eSpectromType == FMUSBDeviceType.FIUSB2DeviceSpecUvVis || this.m_m2.eSpectromType == FMUSBDeviceType.FIUSB2DeviceSpecLC || this.m_m2.eSpectromType == FMUSBDeviceType.FIUSB2DeviceSpecUvVis2 || this.m_m2.eSpectromType == FMUSBDeviceType.FMUSBDeviceSony;
	}

	[SpecialName]
	private bool p9(double A_0, bool A_1)
	{
		c[] array = qq[(int)this.m_ti.k()];
		if (array == null)
		{
			return false;
		}
		int upperBound = array.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (array[num] == null)
			{
				return false;
			}
			if (!m2(array[num].j, A_0))
			{
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	public bool wq()
	{
		return qh(this.m_m2.eSpectromType);
	}

	[SpecialName]
	public static bool qh(FMUSBDeviceType A_0)
	{
		if (A_0 != FMUSBDeviceType.FMUSBDeviceVisHama && A_0 != FMUSBDeviceType.FIUSB2DeviceSpecUvVis)
		{
			return A_0 == FMUSBDeviceType.FIUSB2DeviceSpecUvVis2;
		}
		return true;
	}

	public static bool p9(FMUSBDeviceType A_0)
	{
		if (A_0 != FMUSBDeviceType.FMUSBDeviceSony && A_0 != FMUSBDeviceType.FIUSB2DeviceSpecUvVis && A_0 != FMUSBDeviceType.FIUSB2DeviceSpecLC)
		{
			return A_0 == FMUSBDeviceType.FIUSB2DeviceSpecUvVis2;
		}
		return true;
	}

	[SpecialName]
	public e wr()
	{
		e e10 = new e();
		e e11 = e10;
		e11.h = this.m_m2.eSpectromType;
		e11.n = abk().eControllerType == FMUSBDeviceType.FIUSB2DeviceController;
		e11.o = abk().USBSelfPowered == 0;
		e11.t = abk().SerialNumber;
		e11.p = m2(SpectromTempSensorLoc.kFMTSLocSpectrometer);
		e11.q = e11.p && this.m_m2.eSpectromType == FMUSBDeviceType.FIUSB2DeviceSpecLC;
		e11.r = abk().HasLowPowerLightSource != 0;
		e11.a = m2(e11.h);
		e11.m = p9(e11.h);
		switch (e11.h)
		{
		case FMUSBDeviceType.FMUSBDeviceVisHama:
			e11.j = true;
			break;
		case FMUSBDeviceType.FMUSBDeviceIRHama:
			e11.l = true;
			break;
		case FMUSBDeviceType.FMUSBDeviceSony:
			e11.j = true;
			break;
		case FMUSBDeviceType.FIUSB2DeviceSpecUvVis:
			e11.f = true;
			e11.j = true;
			e11.k = true;
			break;
		case FMUSBDeviceType.FIUSB2DeviceSpecNIR2:
			e11.c = true;
			e11.d = true;
			e11.f = true;
			e11.l = true;
			e11.g = this.m_m2.PGAGainSetting;
			break;
		case FMUSBDeviceType.FIUSB2DeviceSpecLC:
			e11.d = true;
			e11.f = true;
			e11.j = true;
			e11.g = this.m_m2.PGAGainSetting;
			break;
		case FMUSBDeviceType.FIUSB2DeviceSpecUvVis2:
			e11.f = true;
			e11.j = true;
			e11.k = true;
			e11.e = true;
			break;
		case FMUSBDeviceType.FIUSB2DeviceSpecTCNIR:
			e11.c = true;
			e11.d = true;
			e11.f = true;
			e11.l = true;
			e11.g = this.m_m2.PGAGainSetting;
			e11.s = this.m_m2.HasTwoStageTEC != 0;
			break;
		default:
			throw new ax("Unknown spectrometer type");
		}
		e11.u = this.m_m2.NumPixels;
		e11.i = qh(e11.h);
		e11.b = this.m_m2.DeviceRevLevel.ToString().Trim() + "@" + checked(p8 + 1).ToString().Trim();
		e11 = null;
		return e10;
	}

	[SpecialName]
	public new static string m2(FMUSBDeviceType A_0)
	{
		return A_0 switch
		{
			FMUSBDeviceType.FMUSBDeviceVisHama => "VisHamSpc", 
			FMUSBDeviceType.FMUSBDeviceIRHama => "IRHamSpc", 
			FMUSBDeviceType.FMUSBDeviceSony => "SonySpc", 
			FMUSBDeviceType.FIUSB2DeviceSpecUvVis => "UvVisSpc", 
			FMUSBDeviceType.FIUSB2DeviceSpecNIR2 => "NIR2Spc", 
			FMUSBDeviceType.FIUSB2DeviceSpecLC => "LCSpc", 
			FMUSBDeviceType.FIUSB2DeviceSpecUvVis2 => "UvVis2Spc", 
			FMUSBDeviceType.FIUSB2DeviceSpecTCNIR => "TCNIRSpc", 
			_ => throw new ax("Unknown spectrometer type"), 
		};
	}

	[SpecialName]
	public bool ws()
	{
		return qq[(int)this.m_ti.k()][0].r;
	}

	[SpecialName]
	public bool wt()
	{
		int index = 10;
		if (qq[index] == null || qq[index].Length == 0 || qq[index][0] == null)
		{
			return false;
		}
		return qq[index][0].s;
	}

	[SpecialName]
	private c[] so(DateTime A_0)
	{
		if (qq == null)
		{
			return null;
		}
		return qq[(int)this.m_ti.k()];
	}

	[SpecialName]
	private float[] qh(int A_0, DateTime A_1)
	{
		c[] array = so(A_1);
		if (array == null || A_0 < 0 || A_0 > array.GetUpperBound(0))
		{
			return null;
		}
		return array[A_0].v();
	}

	[SpecialName]
	private float[] p9(int A_0, DateTime A_1)
	{
		c[] array = so(A_1);
		if (array == null || A_0 < 0 || A_0 > array.GetUpperBound(0))
		{
			return null;
		}
		return array[A_0].w();
	}

	[SpecialName]
	private new float[] m2(int A_0, DateTime A_1)
	{
		c[] array = so(A_1);
		if (array == null || A_0 < 0 || A_0 > array.GetUpperBound(0))
		{
			return null;
		}
		return array[A_0].x();
	}

	[SpecialName]
	private float[] sm(bool A_0)
	{
		return qs[(int)this.m_ti.k()];
	}

	[SpecialName]
	private void p9(bool A_0, float[] A_1)
	{
		qs[(int)this.m_ti.k()] = A_1;
	}

	[SpecialName]
	private short[] sj(bool A_0)
	{
		return qt[(int)this.m_ti.k()];
	}

	[SpecialName]
	private new void m2(bool A_0, short[] A_1)
	{
		qt[(int)this.m_ti.k()] = A_1;
	}

	[SpecialName]
	private float[] qh(bool A_0)
	{
		return qu[(int)this.m_ti.k()];
	}

	[SpecialName]
	private new void m2(bool A_0, float[] A_1)
	{
		qu[(int)this.m_ti.k()] = A_1;
	}

	[SpecialName]
	private float[] t6()
	{
		return qw[(int)this.m_ti.k()];
	}

	[SpecialName]
	private void qh(float[] A_0)
	{
		qw[(int)this.m_ti.k()] = A_0;
	}

	[SpecialName]
	private float[] t5()
	{
		return this.m_wm[(int)this.m_ti.k()];
	}

	[SpecialName]
	private void p9(float[] A_0)
	{
		this.m_wm[(int)this.m_ti.k()] = A_0;
	}

	public new void m2(string A_0, string A_1, ref bool A_2, bool A_3, ref bool A_4)
	{
		if (A_3 && !this.m_v8)
		{
			yg();
		}
		m2(A_0, A_1, ref A_2, ref A_4);
		if (A_2)
		{
			return;
		}
		if (A_4)
		{
			if (A_3)
			{
				xo();
			}
		}
		else
		{
			te(A_3);
			xo();
		}
		wu();
		t0();
	}

	public void wu()
	{
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = g2.OpticsConfigSubmoduleTypes.ReflectanceProbe;
		do
		{
			int num = (int)opticsConfigSubmoduleTypes;
			m2(q6[num], opticsConfigSubmoduleTypes);
			opticsConfigSubmoduleTypes++;
		}
		while (opticsConfigSubmoduleTypes <= g2.OpticsConfigSubmoduleTypes.TransCurved);
	}

	public void so(int A_0)
	{
		ry[A_0].ad();
	}

	private void t0()
	{
		rr = null;
		rv = null;
		ru = null;
	}

	public void wv()
	{
		rz = null;
		r0 = null;
	}

	public int tb(bool A_0)
	{
		return this.m_m2.SetAcqStatusLEDEnableState(0 - (A_0 ? 1 : 0));
	}

	public void ww()
	{
		sq = 0.0;
	}

	[SpecialName]
	public double wx()
	{
		return sq;
	}

	public new void m2(string A_0, float A_1)
	{
		StreamWriter streamWriter = null;
		checked
		{
			try
			{
				int num = this.m_p9 - 1;
				double[] array = (double[])qf.Clone();
				p9(array, qg);
				streamWriter = global::c.e().FileSystem.OpenTextFileWriter(A_0, append: false);
				streamWriter.WriteLine("Integration Time, " + sq);
				streamWriter.WriteLine("Spectrometer Temperature, " + qg);
				streamWriter.WriteLine("Number Of Spectrum Points, " + this.m_p9);
				streamWriter.WriteLine("Wavelength (nm), Intensity (" + sq.ToString("0.00") + ": " + A_1.ToString("0.0") + "), Corrected (" + qg.ToString("0.0") + ")");
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					streamWriter.WriteLine(q2[num3] + ", " + qf[num3] + ", " + array[num3]);
				}
			}
			finally
			{
				streamWriter?.Close();
			}
		}
	}

	public new void m2(string A_0, ref double A_1, ref float A_2, ref int A_3, ref double[] A_4, ref double[] A_5, ref double[] A_6)
	{
		StreamReader streamReader = null;
		checked
		{
			try
			{
				A_4 = null;
				A_5 = null;
				A_6 = null;
				streamReader = global::c.e().FileSystem.OpenTextFileReader(A_0);
				string text = streamReader.ReadLine();
				string[] array = null;
				array = text.Split(Conversions.ToCharArrayRankOne(","));
				A_1 = Conversions.ToDouble(array[1]);
				string text2 = streamReader.ReadLine();
				string[] array2 = null;
				array2 = text2.Split(Conversions.ToCharArrayRankOne(","));
				A_2 = Conversions.ToSingle(array2[1]);
				string text3 = streamReader.ReadLine();
				string[] array3 = null;
				array3 = text3.Split(Conversions.ToCharArrayRankOne(","));
				streamReader.ReadLine();
				A_3 = Conversions.ToInteger(array3[1]);
				if (A_3 >= 1)
				{
					int num = A_3 - 1;
					A_4 = new double[num + 1];
					A_5 = new double[num + 1];
					A_6 = new double[num + 1];
					string[] array4 = null;
					int num2 = num;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						array4 = streamReader.ReadLine().Split(Conversions.ToCharArrayRankOne(","));
						A_4[num3] = Conversions.ToDouble(array4[0]);
						A_5[num3] = Conversions.ToDouble(array4[1]);
						A_6[num3] = Conversions.ToDouble(array4[2]);
					}
				}
			}
			finally
			{
				streamReader?.Close();
			}
		}
	}

	public FIDeviceErr wy()
	{
		FIDeviceErr result = FIDeviceErr.None;
		if (this.m_m2.RefreshWriteEnabledState() != 0)
		{
			ab8().c(fz.b.b, "Error attempting to Refresh Write Enabled State for spectrometer " + this.m_m2.FriendlySN);
			result = FIDeviceErr.Generic;
		}
		return result;
	}

	public void wz()
	{
		checked
		{
			this.m_ww++;
		}
	}

	public void w0()
	{
		checked
		{
			this.m_ww--;
		}
	}

	[SpecialName]
	private bool tl()
	{
		return this.m_ww > 0;
	}

	[SpecialName]
	public double w1()
	{
		if (tl())
		{
			return 0.0;
		}
		return ri;
	}

	public FIDeviceErr so(double A_0)
	{
		FIDeviceErr result = FIDeviceErr.None;
		int num = 0;
		double integrationTime = this.m_m2.IntegrationTime;
		if (integrationTime == 0.0 || !m2(A_0, integrationTime))
		{
			num = w8();
			if (num == 0)
			{
				num = this.m_m2.SetIntegrationTime(A_0);
			}
			rh = true;
			if (integrationTime > 0.0)
			{
				ri = (float)Math.Min(Math.Max(ri, (double)rj * (A_0 - integrationTime) / integrationTime), 4000.0);
			}
			if (num != 0)
			{
				ab8().c(fz.b.b, "Error Attempting to Set Integration Time to " + A_0 + ". Was " + integrationTime);
				if (st(A_0: false) == 0)
				{
					num = this.m_m2.SetIntegrationTime(A_0);
				}
				if (num != 0)
				{
					so(A_0: true);
					if (st(A_0: true) == 0)
					{
						num = this.m_m2.SetIntegrationTime(A_0);
					}
				}
				result = ((num != 0) ? FIDeviceErr.Generic : FIDeviceErr.None);
			}
		}
		else
		{
			result = FIDeviceErr.None;
		}
		return result;
	}

	public bool w2()
	{
		if (rp.Count > 0)
		{
			return u3() != global::h.MeasurementTimingType.Manual;
		}
		return false;
	}

	public new bool m2(double A_0, double A_1)
	{
		return this.m_m2.IntTimesEqual(A_0, A_1) != 0;
	}

	public float w3()
	{
		return this.m_m2.PGAGainSetting;
	}

	public short w4()
	{
		return this.m_m2.FirstFirmwareRevThatSupportsScatterLED;
	}

	public short w5()
	{
		return this.m_m2.FirstFirmwareRevThatSupportsScatterLEDOffset;
	}

	public double w6()
	{
		g2.OpticsConfigSubmoduleTypes index = this.m_ti.k();
		return qq[(int)index][0].k;
	}

	public double qh(iq A_0, bool A_1)
	{
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
		if (p9(A_1) || (opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.CTMProbe && w2()))
		{
			if (this.m_ti.s() == global::h.MeasurementTimingType.Manual)
			{
				return this.m_ti.p();
			}
			if (sq != 0.0)
			{
				return this.m_m2.IntegrationTime;
			}
			return qq[(int)opticsConfigSubmoduleTypes][0].j;
		}
		bool flag = true;
		c[] array = null;
		if (this.m_ti.s() != global::h.MeasurementTimingType.Manual)
		{
			array = qq[(int)opticsConfigSubmoduleTypes];
			int upperBound = array.GetUpperBound(0);
			for (int num = 0; num <= upperBound; num = checked(num + 1))
			{
				if (!array[num].u())
				{
					flag = false;
					break;
				}
			}
		}
		switch (this.m_ti.s())
		{
		case global::h.MeasurementTimingType.Recommended:
			if (flag && m2(A_0, A_1))
			{
				return array[0].j;
			}
			return 0.0;
		case global::h.MeasurementTimingType.Maximum:
			if (flag && m2(A_0, A_1))
			{
				return array[0].j;
			}
			return vj();
		case global::h.MeasurementTimingType.Manual:
			return this.m_ti.p();
		default:
		{
			double result = default(double);
			return result;
		}
		}
	}

	private new short m2(double A_0, bool A_1)
	{
		double num = A_0 + (double)t9();
		checked
		{
			short num2 = default(short);
			switch (this.m_ti.s())
			{
			case global::h.MeasurementTimingType.Recommended:
			{
				float num3 = ((!(A_0 > 0.0)) ? 0f : ((float)(s6(A_1) / num)));
				num2 = (short)Math.Round(Math.Round(num3));
				if (num2 <= 0)
				{
					num2 = 1;
				}
				break;
			}
			case global::h.MeasurementTimingType.Maximum:
			{
				float num3 = ((!(A_0 > 0.0)) ? 0f : ((float)(this.m_ti.r() / num)));
				num2 = (short)Math.Round(Math.Floor(num3));
				if (num2 <= 0)
				{
					num2 = 1;
				}
				break;
			}
			case global::h.MeasurementTimingType.Manual:
				num2 = (short)this.m_ti.q();
				break;
			}
			return num2;
		}
	}

	public void w7()
	{
		this.m_tj = this.m_ti;
	}

	public void tc(bool A_0)
	{
		this.m_m2.EnableDisableHighVoltage(0 - (A_0 ? 1 : 0));
	}

	public new FIDeviceErr m2(ref bool A_0, ref bool A_1, ew.a A_2, int A_3, ref global::r.c A_4, global::r.d.a.b A_5, DateTime A_6, bool A_7, double A_8, bool A_9, bool A_10, int A_11, bool A_12, double A_13, short A_14)
	{
		iq a_ = null;
		double num;
		short num2;
		if (A_12)
		{
			num = A_13;
			num2 = A_14;
		}
		else
		{
			num = qh(a_, A_9);
			if (!A_10)
			{
				num2 = ((!A_7) ? m2(num, A_9) : ((this.m_ti.s() != global::h.MeasurementTimingType.Manual) ? m2(A_8, A_9) : ((!(num * (double)m2(num, A_9) > A_8)) ? m2(num, A_9) : checked((short)Math.Round(Math.Max(Math.Floor(A_8 / num), 1.0))))));
			}
			else if (num == 0.0)
			{
				num2 = 1;
			}
			else if (A_9)
			{
				num2 = (short)((A_11 < 2) ? 1 : checked((short)A_11));
			}
			else
			{
				num2 = checked((short)Math.Round(10.0 / num));
				if (num2 < 1)
				{
					num2 = 1;
				}
			}
		}
		return m2(ref A_0, ref A_1, A_3, num, num2, A_2, A_4, A_5);
	}

	public new FIDeviceErr m2(ref bool A_0, ref bool A_1, ew.a A_2, int A_3, double A_4, short A_5, global::r.c A_6, global::r.d.a.b A_7)
	{
		return m2(ref A_0, ref A_1, A_3, A_2, A_4, A_5, A_6, A_7);
	}

	private new FIDeviceErr m2(ref bool A_0, ref bool A_1, int A_2, ew.a A_3, double A_4, short A_5, global::r.c A_6, global::r.d.a.b A_7)
	{
		return m2(ref A_0, ref A_1, A_2, A_4, A_5, A_3, A_6, A_7);
	}

	private new FIDeviceErr m2(ref bool A_0, ref bool A_1, int A_2, double A_3, short A_4, ew.a A_5, global::r.c A_6, global::r.d.a.b A_7)
	{
		FIDeviceErr result = FIDeviceErr.None;
		FIDeviceErr fIDeviceErr = FIDeviceErr.None;
		checked
		{
			try
			{
				w7();
				fIDeviceErr = so(A_3);
				if (fIDeviceErr != FIDeviceErr.None)
				{
					ab8().c(fz.b.b, "Error setting integration time in AcquireSpectrum. Error is: " + fIDeviceErr.ToString() + ", Tint=" + A_3.ToString(CultureInfo.InvariantCulture), Environment.StackTrace);
				}
				if (A_2 > 0 || rh)
				{
					int num;
					if (tl())
					{
						num = 0;
					}
					else
					{
						num = (int)Math.Round(Math.Ceiling((double)ri / A_3));
						if (rh && num <= 1 && rj > 0f)
						{
							num = 2;
						}
						ri = 0f;
					}
					if (A_2 < num)
					{
						A_2 = num;
					}
					if (rh && A_2 < 1)
					{
						A_2 = 1;
					}
					int num2 = A_2;
					for (int num3 = 1; num3 <= num2; num3++)
					{
						if (m2(1, A_5, ref A_0, ref A_1, A_6, A_7) != FIDeviceErr.None)
						{
							ab8().c(fz.b.b, "Error acquiring throw-away spectrum.");
						}
					}
					rh = false;
				}
				if (m2(A_4, A_5, ref A_0, ref A_1, A_6, A_7) != FIDeviceErr.None)
				{
					result = FIDeviceErr.USBSpecAcquisitionError;
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
				result = FIDeviceErr.Generic;
				ab8().c(fz.b.b, "Exception caught in AcquireSpectrum(). ", a_);
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public new FIDeviceErr m2(short A_0, ew.a A_1, ref bool A_2, ref bool A_3, ref global::r.c A_4, global::r.d.a.b A_5)
	{
		return m2(A_0, A_1, ref A_2, ref A_3, A_4, A_5);
	}

	public int w8()
	{
		int result = default(int);
		if (this.m_wr != abk().HardwareRefreshID)
		{
			result = ((this.m_m2 == null) ? (-1) : this.m_m2.RefreshHardwareSettings());
			this.m_wr = abk().HardwareRefreshID;
		}
		return result;
	}

	public int w9()
	{
		if (jf.e(this.m_m2.IntegrationTime, 0.0))
		{
			this.m_m2.SetIntegrationTime(40.0);
		}
		FIUsbSpectrometer fIUsbSpectrometer = this.m_m2;
		int bZeroError = 0;
		int bSatError = 0;
		checked
		{
			int spectraSmoothedAndUnsmoothedSafe = fIUsbSpectrometer.GetSpectraSmoothedAndUnsmoothedSafe(1, 1, 1, ref bZeroError, ref bSatError, Information.UBound(qf) + 1, qf, qm);
			if (spectraSmoothedAndUnsmoothedSafe == -127)
			{
				FIUsbSpectrometer fIUsbSpectrometer2 = this.m_m2;
				bSatError = 0;
				bZeroError = 0;
				spectraSmoothedAndUnsmoothedSafe = fIUsbSpectrometer2.GetSpectraSmoothedAndUnsmoothedSafe(1, 1, 1, ref bSatError, ref bZeroError, Information.UBound(qf) + 1, qf, qm);
			}
			if (spectraSmoothedAndUnsmoothedSafe != 0)
			{
				ab8().c(fz.b.b, "TestTakeSpectrum Error is " + spectraSmoothedAndUnsmoothedSafe);
			}
			return spectraSmoothedAndUnsmoothedSafe;
		}
	}

	public new FIDeviceErr m2(short A_0, short A_1, ref bool A_2, ref bool A_3, ref int A_4, ref double[] A_5)
	{
		checked
		{
			int num = A_0 * this.m_p9;
			if (A_5 == null || A_5.Length != num)
			{
				A_5 = new double[num - 1 + 1];
			}
			A_4 = this.m_p9;
			int bZeroError = default(int);
			int bSatError = default(int);
			int spectraSafe = this.m_m2.GetSpectraSafe(A_0, A_1, 1, ref bZeroError, ref bSatError, num, A_5);
			A_2 = bZeroError != 0;
			A_3 = bSatError != 0;
			if (spectraSafe != 0)
			{
				ab8().c(fz.b.a, "Error in call to USBSpectrometerDevice.GetSpectra. Error code = " + spectraSafe);
				return FIDeviceErr.USBSpecAcquisitionError;
			}
			return FIDeviceErr.None;
		}
	}

	public new FIDeviceErr m2(short A_0, ew.a A_1, ref bool A_2, ref bool A_3, global::r.c A_4, global::r.d.a.b A_5)
	{
		FIDeviceErr result = FIDeviceErr.None;
		bool flag = false;
		checked
		{
			int num = this.m_p9 - 1;
			try
			{
				int num2 = w8();
				sr = A_0;
				if (qf == null || Information.UBound(qf) != num)
				{
					qf = new double[num + 1];
				}
				double integrationTime = this.m_m2.IntegrationTime;
				int bZeroError = default(int);
				int bSatError = default(int);
				if (num2 == 0)
				{
					num2 = this.m_m2.GetSpectraSmoothedAndUnsmoothedSafe(1, A_0, 1, ref bZeroError, ref bSatError, Information.UBound(qf) + 1, qf, qm);
					if (false)
					{
						double[] array = new double[num + 1];
						double[] array2 = new double[num + 1];
						double[] array3 = new double[num + 1];
						double[] array4 = new double[num + 1];
						double[] array5 = new double[11];
						double[] array6 = new double[11];
						int num3 = 0;
						do
						{
							int num4 = num;
							for (int num5 = 0; num5 <= num4; num5++)
							{
								array[num5] = 0.0;
							}
							int num6 = 0;
							do
							{
								num2 = this.m_m2.GetSpectraSmoothedAndUnsmoothedSafe(1, 3, 1, ref bZeroError, ref bSatError, Information.UBound(qf) + 1, qf, qm);
								int num7 = num;
								for (int num8 = 0; num8 <= num7; num8++)
								{
									array[num8] += qf[num8];
								}
								Thread.Sleep(250);
								num6++;
							}
							while (num6 <= 99);
							int num9 = num;
							for (int num10 = 0; num10 <= num9; num10++)
							{
								array[num10] /= 100.0;
							}
							num2 = this.m_m2.GetSpectraSmoothedAndUnsmoothedSafe(1, 500, 1, ref bZeroError, ref bSatError, Information.UBound(qf) + 1, qf, qm);
							array2 = qf;
							int num11 = num;
							for (int num12 = 0; num12 <= num11; num12++)
							{
								array3[num12] += array[num12];
								array4[num12] += array2[num12];
								array5[num3] += array[num12];
								array6[num3] += array2[num12];
							}
							array5[num3] /= this.m_p9;
							array6[num3] /= this.m_p9;
							num3++;
						}
						while (num3 <= 10);
						int num13 = num;
						for (int num14 = 0; num14 <= num13; num14++)
						{
							array3[num14] /= 11.0;
							array4[num14] /= 11.0;
						}
						StreamWriter streamWriter = null;
						try
						{
							streamWriter = new StreamWriter(i3.o() + "\\Logs\\3vs500averages.csv", append: false, Encoding.ASCII);
							streamWriter.WriteLine("i, mean 3avg, mean 500avg");
							int num15 = 0;
							do
							{
								streamWriter.WriteLine(num15 + ", " + array5[num15] + ", " + array6[num15]);
								num15++;
							}
							while (num15 <= 10);
							streamWriter.WriteLine();
							streamWriter.WriteLine("wavelength, 3avg, 500avg");
							int num16 = this.m_p9 - 1;
							for (int num17 = 0; num17 <= num16; num17++)
							{
								streamWriter.WriteLine(q2[num17] + ", " + array3[num17] + ", " + array4[num17]);
							}
						}
						finally
						{
							streamWriter?.Close();
						}
					}
				}
				if (xs() == FMUSBDeviceType.FIUSB2DeviceSpecTCNIR && bSatError != 0)
				{
					bool flag2 = true;
					double a_ = qf[0];
					int num18 = 5;
					int num19 = this.m_p9 - 1;
					int num20 = 5;
					for (int num21 = num18; ((num20 >> 31) ^ num21) <= ((num20 >> 31) ^ num19); num21 += num20)
					{
						if (!jf.e(a_, qf[num21]))
						{
							flag2 = false;
							break;
						}
					}
					if (flag2)
					{
						string A_6 = null;
						int A_7 = default(int);
						m2(ref A_7, ref A_6);
						if (A_7 != 0)
						{
							string text = A_6 + " in Spectrometer with S/N " + uq() + " connected to Controller S/N " + abo();
							ab8().c(fz.b.a, text);
							throw new ai(text);
						}
					}
				}
				if (num2 != 0)
				{
					ab8().c(fz.b.a, "Error in TakeSpectrumSmoothed initial spectrum acquisition. Error is " + num2);
					if (num2 == -127)
					{
						ab8().c(fz.b.a, "Error code -127 (IntegrationTimeChanged), probably means that there is a hardware failure in the spectrometer circuitry");
					}
					int num22 = st(A_0: false);
					unchecked
					{
						switch (num22)
						{
						case 0:
							num2 = (int)so(integrationTime);
							break;
						case 31:
						{
							ab8().c(fz.b.b, "USBCommunicationsFailureError in TakeSpectrumSmoothed first call to ReInstantiateAndConnectToUsbSpectrometer(False)");
							fz a_2 = new fz();
							flag = true;
							A_4.t(9f, A_5);
							byte A_8 = default(byte);
							num2 = (int)h6.m2(ref A_8, a_2);
							if (num2 != 0)
							{
								ab8().c(fz.b.b, "Error in TakeSpectrumSmoothed USBDevice.EnumerateDevices, Error is " + num2);
								so(A_0: true);
								if (st(A_0: true) == 0)
								{
									num2 = (int)so(integrationTime);
								}
							}
							else if (num22 == 0)
							{
								num2 = (int)so(integrationTime);
							}
							break;
						}
						}
					}
					if (num2 == 0)
					{
						try
						{
							num2 = this.m_m2.GetSpectraSmoothedAndUnsmoothedSafe(1, 1, 1, ref bZeroError, ref bSatError, Information.UBound(qf) + 1, qf, qm);
						}
						catch (Exception ex2)
						{
							ProjectData.SetProjectError(ex2);
							Exception ex3 = ex2;
							ab8().c(fz.b.b, "Uncaught error in TakeSpectrumSmoothed GetSpectraSmoothedAndUnsmoothedSafe first throw-away, Error is " + num2);
							so(A_0: true);
							num22 = st(A_0: true);
							num2 = this.m_m2.GetSpectraSmoothedAndUnsmoothedSafe(1, 1, 1, ref bZeroError, ref bSatError, Information.UBound(qf) + 1, qf, qm);
							ProjectData.ClearProjectError();
						}
						if (num2 != 0)
						{
							if (!flag)
							{
								so(A_0: true);
							}
							if (st(A_0: true) == 0)
							{
								num2 = unchecked((int)so(integrationTime));
								if (num2 == 0)
								{
									num2 = this.m_m2.GetSpectraSmoothedAndUnsmoothedSafe(1, 1, 1, ref bZeroError, ref bSatError, Information.UBound(qf) + 1, qf, qm);
								}
							}
						}
						if (num2 == 0)
						{
							num2 = this.m_m2.GetSpectraSmoothedAndUnsmoothedSafe(1, A_0, 1, ref bZeroError, ref bSatError, Information.UBound(qf) + 1, qf, qm);
						}
					}
				}
				A_2 = bZeroError != 0;
				A_3 = bSatError != 0;
				sq = this.m_m2.IntegrationTime;
				qn = A_1;
				this.m_tl = tk;
				if (num2 != 0)
				{
					result = FIDeviceErr.USBSpecAcquisitionError;
				}
				else if (((IFIUsbSpectrometer)this.m_m2).get_TemperatureSensorExists(SpectromTempSensorLoc.kFMTSLocSpectrometer) != 0)
				{
					DateTime now = DateTime.Now;
					if (now.Subtract(this.m_qh).TotalSeconds > 11.0)
					{
						int num23 = 0;
						float fTemperatureDegC;
						do
						{
							num2 = this.m_m2.ReadTemperature(SpectromTempSensorLoc.kFMTSLocSpectrometer, out fTemperatureDegC);
							num23++;
						}
						while ((num2 != 0) & (num23 < 3));
						if (num2 != 0)
						{
							ab8().c(fz.b.a, "Error attempting to read temperature. Return code=" + num2);
							return FIDeviceErr.USBSpecAcquisitionError;
						}
						this.m_qh = now;
						qg = fTemperatureDegC;
						s6();
					}
				}
			}
			catch (ai ai2)
			{
				ProjectData.SetProjectError(ai2);
				ai ai3 = ai2;
				throw ai3;
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex5 = ex4;
				result = FIDeviceErr.Generic;
				ProjectData.ClearProjectError();
			}
			finally
			{
				if (flag)
				{
					A_4.z();
				}
			}
			return result;
		}
	}

	public new int m2(short A_0, short A_1)
	{
		sr = A_1;
		int plGroupID = default(int);
		int spectraStart = this.m_m2.GetSpectraStart(A_0, A_1, ref plGroupID);
		checked
		{
			if (spectraStart == 0)
			{
				if (s0 >= sz)
				{
					sz += 10;
					s1 = new int[sz - 1 + 1];
					s2 = new int[sz - 1 + 1];
				}
				s1[s0] = plGroupID;
				s2[s0] = A_0;
				s0++;
			}
			return spectraStart;
		}
	}

	public new int m2(ref short A_0, ref bool A_1, ref float A_2, ref float A_3)
	{
		int num;
		if (s0 == 0)
		{
			num = -1;
		}
		else
		{
			short allDone = default(short);
			num = this.m_m2.GetSpectraStatus(s1[0], ref A_0, ref allDone, ref A_2, ref A_3);
			if (num != 0)
			{
				p9();
			}
			if (allDone != 0)
			{
				A_1 = true;
			}
			else
			{
				A_1 = false;
			}
		}
		return num;
	}

	public int xa()
	{
		if (s0 == 0)
		{
			return -1;
		}
		return this.m_m2.GetSpectraAbort(s1[0]);
	}

	public new int m2(float A_0, ref int A_1, ref int A_2, ref int A_3)
	{
		checked
		{
			int result;
			if (s0 == 0)
			{
				result = -1;
			}
			else
			{
				double[] array = new double[this.m_p9 - 1 + 1];
				result = this.m_m2.GetSpectraFinish(s1[0], 1, 1, ref A_1, ref A_2, ref A_3, ref sq, Information.UBound(array) + 1, ref array[0], ref ss);
				s2[0] = s2[0] - 1;
				if (s2[0] == 0)
				{
					p9();
				}
				if (qf == null || Information.UBound(qf) != this.m_p9 - 1)
				{
					qf = new double[this.m_p9 - 1 + 1];
				}
				f6.SmoothSpectrumGivenThickness(A_0, ref q2[0], ref array[0], this.m_p9, ref qf[0]);
			}
			return result;
		}
	}

	public new void m2(DateTime A_0, int A_1, ej A_2, bool A_3, bool A_4, int A_5)
	{
		if (!sp)
		{
			m2(A_0);
			qh(A_0);
			p9(A_0);
			sj(A_0);
		}
		float[] A_6 = null;
		float[] A_7 = null;
		float[] A_8 = null;
		m2(ref A_6, ref A_7, ref A_8);
		sa = A_0;
		c obj = ry[A_1];
		obj.u(A_6);
		obj.v(A_7);
		obj.w(A_8);
		obj.n = DateTime.Now;
		obj.j = sq;
		obj.l = sr;
		obj.q = A_2;
		_ = null;
		sg = this.m_tj.s();
		sh = p9(qf);
		if (sp)
		{
			m2(A_1);
			p9(A_1, A_1: false);
			m2(A_1, A_1: false);
		}
		if (A_3)
		{
			r9 = true;
		}
		nf = true;
		if (A_4)
		{
			s3(A_5);
		}
	}

	[SpecialName]
	public bool xb()
	{
		if (rr != null)
		{
			return rv != null;
		}
		return false;
	}

	public void td(bool A_0)
	{
		if (A_0)
		{
			qf = rr;
			sq = rt;
			qg = rs;
		}
		else
		{
			qf = rv;
			sq = rx;
			qg = rw;
		}
	}

	public new void m2(bool A_0, bool A_1, int A_2)
	{
		td(A_0);
		c c10 = ry[0];
		c c11;
		float[] A_3 = (c11 = c10).y();
		c c12;
		float[] A_4 = (c12 = c10).z();
		c c13;
		float[] A_5 = (c13 = c10).aa();
		m2(ref A_3, ref A_4, ref A_5);
		c13.z(A_5);
		c12.y(A_4);
		c11.x(A_3);
		c10.r = A_0;
		c10.s = true;
		c10 = null;
	}

	private new void m2(ref float[] A_0, ref float[] A_1, ref float[] A_2)
	{
		checked
		{
			int num = this.m_p9 - 1;
			double[] array = (double[])qf.Clone();
			p9(array, qg);
			A_0 = new float[num + 1];
			A_1 = new float[num + 1];
			A_2 = null;
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				A_0[num3] = (float)qf[num3];
				A_1[num3] = (float)array[num3];
			}
			if (r0 != null)
			{
				A_2 = new float[num + 1];
				int num4 = num;
				for (int num3 = 0; num3 <= num4; num3++)
				{
					A_2[num3] = A_1[num3] - r0[num3];
				}
			}
		}
	}

	private new void m2(double[] A_0, double[] A_1, int A_2, int A_3, int A_4, int A_5, int A_6, ref double[] A_7, ref double A_8, ref double A_9)
	{
		checked
		{
			double[] array = new double[A_4 - 1 + 1];
			double[] array2 = new double[A_4 - 1 + 1];
			double[] array3 = new double[A_6 - 1 + 1];
			double[] array4 = new double[A_6 - 1 + 1];
			int num = A_2 - 1;
			int num2 = A_4 - 1;
			A_7 = new double[num + 1];
			int num3 = num2;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				array[num4] = A_0[A_3 + num4];
				array2[num4] = A_1[A_3 + num4];
			}
			double A_10 = default(double);
			jf.a(array, array2, A_4, ref A_10, ref A_8);
			int num5 = A_3 + unchecked(A_4 / 2);
			int num6 = num5 - 1;
			double num7 = (A_1[num5 - 1] + 2.0 * A_1[num5] + A_1[num5 + 1]) / 4.0;
			int num8 = num6;
			for (int num9 = 0; num9 <= num8; num9++)
			{
				A_7[num9] = num7 + A_8 * (A_0[num9] - A_0[num5]);
			}
			int num10 = this.m_p9 - A_5 - A_6;
			int num11 = A_6 - 1;
			for (int num12 = 0; num12 <= num11; num12++)
			{
				array3[num12] = A_0[num10 + num12];
				array4[num12] = A_1[num10 + num12];
			}
			jf.a(array3, array4, A_6, ref A_10, ref A_9);
			int num13 = this.m_p9 - A_5 - unchecked(A_6 / 2);
			_ = this.m_p9 - num13;
			num7 = (A_1[num13 - 1] + 2.0 * A_1[num13] + A_1[num13 + 1]) / 4.0;
			int num14 = num;
			for (int num15 = num13; num15 <= num14; num15++)
			{
				A_7[num15] = num7 + A_9 * (A_0[num15] - A_0[num13]);
			}
			int num16 = num13 - 1;
			for (int num17 = num5; num17 <= num16; num17++)
			{
				A_7[num17] = A_1[num17];
			}
		}
	}

	private new void m2(ref string A_0, ref double[] A_1)
	{
		ex obj = new ex();
		if (A_0.StartsWith(ex.e()))
		{
			A_0 = A_0.Substring(ex.e().Length);
		}
		obj.e(A_0, ex.a.a, 0f, A_3: false, A_4: false);
		if (!obj.e(q2, this.m_p9, ref A_1))
		{
			ab8().c(fz.b.a, "Error attempting to interpolate reference material file " + A_0 + ". File may be missing or corrupted.");
		}
	}

	private new bool m2(string A_0, ref double[] A_1, ref float[] A_2, ref string A_3)
	{
		char[] separator = new char[1] { ',' };
		using StreamReader streamReader = new StreamReader(A_0);
		string text = streamReader.ReadLine();
		iz.c(text.Split(separator)[1]);
		text = streamReader.ReadLine();
		int num = iz.c(text.Split(separator)[1]);
		if (num <= 1)
		{
			text = streamReader.ReadLine();
			List<double> list = new List<double>();
			List<float> list2 = new List<float>();
			bool flag = default(bool);
			do
			{
				if (streamReader.EndOfStream)
				{
					flag = true;
					continue;
				}
				text = streamReader.ReadLine();
				if (!string.IsNullOrEmpty(text.Trim()))
				{
					string[] array = text.Split(separator);
					list.Add(iz.e(array[0]));
					list2.Add(iz.d(array[1]));
				}
				else
				{
					flag = true;
				}
			}
			while (!flag);
			A_1 = list.ToArray();
			A_2 = list2.ToArray();
			return true;
		}
		A_3 = "Calibration file maximum compatible file version is " + 1 + ". Compatible version in file we are attempting to read is " + num;
		return false;
	}

	private new static bool m2(string A_0, ref int A_1, ref int A_2, ref float A_3, ref float A_4, ref float A_5, ref int A_6, ref int A_7, ref int A_8, ref string A_9)
	{
		char[] separator = new char[1] { ',' };
		using (StreamReader streamReader = new StreamReader(A_0))
		{
			iz.c(streamReader.ReadLine().Split(separator)[1]);
			int num = iz.c(streamReader.ReadLine().Split(separator)[1]);
			if (num > 1)
			{
				A_9 = "Key peaks check file maximum compatible file version is " + 1 + ". Compatible version in file we are attempting to read is " + num;
				return false;
			}
			string[] array = streamReader.ReadLine().Split(separator);
			A_1 = iz.c(array[1]);
			array = streamReader.ReadLine().Split(separator);
			A_2 = iz.c(array[1]);
			array = streamReader.ReadLine().Split(separator);
			A_3 = iz.d(array[1]);
			array = streamReader.ReadLine().Split(separator);
			A_4 = iz.d(array[1]);
			array = streamReader.ReadLine().Split(separator);
			A_5 = iz.d(array[1]);
			array = streamReader.ReadLine().Split(separator);
			A_6 = iz.c(array[1]);
			array = streamReader.ReadLine().Split(separator);
			A_7 = iz.c(array[1]);
			array = streamReader.ReadLine().Split(separator);
			A_8 = iz.c(array[1]);
		}
		return true;
	}

	public new static float m2(int A_0, float A_1, float A_2, float A_3, float A_4, float A_5, float A_6, float A_7, float A_8, float A_9, float A_10)
	{
		return A_1 + (A_2 + (A_3 + (A_4 + A_5 * (float)A_0) * (float)A_0) * (float)A_0) * (float)A_0 - (A_6 + (A_7 + (A_8 + (A_9 + A_10 * (float)A_0) * (float)A_0) * (float)A_0) * (float)A_0);
	}

	public new static int m2(float A_0, float A_1, float A_2, float A_3, float A_4, int A_5)
	{
		return m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6: false, 0f, 0f);
	}

	public new static int m2(float A_0, float A_1, float A_2, float A_3, float A_4, int A_5, float A_6, float A_7)
	{
		return m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6: true, A_6, A_7);
	}

	private new static bool m2(float A_0, float A_1, float A_2, float A_3, float A_4, float A_5, float A_6, float A_7, float A_8, float A_9, float A_10, float A_11, bool A_12, int A_13, ref float A_14)
	{
		if (A_5 != 0f && A_6 != 0f && A_7 != 0f && A_8 != 0f && A_11 != 0f)
		{
			int num = m2(A_0, A_1, A_2, A_3, A_4, A_13);
			if (!A_12 && A_11 != 0f && A_5 != 0f && !jf.e(A_5, A_11))
			{
				float num2 = (float)((double)A_0 + ((double)A_1 + ((double)A_2 + ((double)A_3 + (double)A_4 * (double)num) * (double)num) * (double)num) * (double)num);
				float num3 = (float)((double)A_6 + ((double)A_7 + ((double)A_8 + ((double)A_9 + (double)A_10 * (double)num) * (double)num) * (double)num) * (double)num);
				A_14 = (num3 - num2) / (A_11 - A_5);
				return true;
			}
		}
		return false;
	}

	public new static void m2(float A_0, float A_1, float A_2, float A_3, float A_4, float A_5, float A_6, float A_7, float A_8, float A_9, float A_10, float A_11, bool A_12, int A_13, string A_14, string A_15, string A_16, string A_17, ref float A_18)
	{
		string path = i3.o() + "\\Logs\\TempCompensatedWaveCal.txt";
		string text = null;
		if (!File.Exists(path))
		{
			File.AppendAllText(path, "DateTime, operation, specSN, specType, IsT1Cal, T1, offset, slope, curve, third, fourth, T2, offset2, slope2, curve2, third2, fourth2, calOffsetPerDegC\r\n");
		}
		if (m2(A_1, A_2, A_3, A_4, A_5, A_0, A_7, A_8, A_9, A_10, A_11, A_6, A_12, A_13, ref A_18))
		{
			text = A_18.ToString();
		}
		File.AppendAllText(path, DateTime.Now.ToString() + ", " + A_14 + ", " + A_15 + ", " + A_16 + ", " + A_17 + ", " + A_0 + ", " + A_1 + ", " + A_2 + ", " + A_3 + ", , " + A_4 + ", , " + A_5 + ", " + A_6 + ", " + A_7 + ", " + A_8 + ", " + A_9 + ", , " + A_10 + ", , " + A_11 + ", " + text + "\r\n");
	}

	private new static int m2(float A_0, float A_1, float A_2, float A_3, float A_4, int A_5, bool A_6, float A_7, float A_8)
	{
		checked
		{
			if (A_6 && A_0 != 0f && A_1 != 0f && A_2 != 0f)
			{
				float num = (A_7 + A_8) / 2f;
				double num2 = A_0 - num;
				double num3 = (double)(A_1 * A_1) - (double)(4f * A_2) * num2;
				double a_ = default(double);
				if (num3 >= 0.0)
				{
					a_ = ((double)(0f - A_1) + Math.Sqrt(num3)) / (double)(2f * A_2);
				}
				if (A_3 == 0f && A_4 == 0f)
				{
					if (num3 < 0.0)
					{
						throw new ax("Negative Delta in CenterPixelOfWavelengthRange.");
					}
					return (int)Math.Round(a_);
				}
				if (num3 < 0.0)
				{
					a_ = (0.0 - num2) / (double)A_1;
				}
				double[] a_2 = new double[5] { A_0, A_1, A_2, A_3, A_4 };
				return (int)Math.Round(jf.a(4, a_2, num, a_, 1.0, 0.1));
			}
		}
		return A_5 / 2;
	}

	private new bool m2(string A_0, ref float A_1, ref float A_2)
	{
		checked
		{
			bool result;
			try
			{
				int num = A_0.IndexOf("_");
				int num2 = A_0.IndexOf("-");
				int num3 = A_0.Length - 1;
				if (num >= 0 && num2 > num && num2 < num3)
				{
					A_1 = float.Parse(A_0.Substring(num + 1, num2 - num - 1));
					string text = A_0.Substring(num2 + 1, num3 - num2);
					int num4 = text.IndexOf("_");
					if (num4 >= 0)
					{
						text = text.Substring(0, num4);
					}
					A_2 = float.Parse(text);
					result = true;
				}
				else
				{
					result = false;
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
	}

	public new void m2(j A_0, global::r.c A_1, global::r.d.a.b A_2, ref string A_3, ref string A_4)
	{
		float[] array = null;
		float[] array2 = null;
		float[] array3 = null;
		float[] array4 = null;
		float[] array5 = null;
		float[] array6 = null;
		float[] array7 = null;
		hr A_5 = null;
		hr A_6 = null;
		j j2 = A_0;
		checked
		{
			try
			{
				FMUSBDeviceType fMUSBDeviceType = xs();
				bool flag = j.ai(fMUSBDeviceType, j2.g);
				bool flag2 = j.ah(fMUSBDeviceType, j2.g);
				bool flag3 = j.ah(j2.g);
				if (x9())
				{
					this.m_m2.GetFirstLastValidPixelDueToHW(out var firstIdx, out var lastIdx);
					this.m_m2.SetFirstLastValidPixelIdx(firstIdx, lastIdx);
					uf();
					int a_ = this.m_p9;
					ref double[] a_2 = ref q2;
					double[] A_7 = null;
					m2(a_, 0f, 1f, 0f, 0f, 0f, ref a_2, ref A_7);
				}
				bool flag4 = default(bool);
				float[] array8;
				if (A_0.i == null)
				{
					unchecked
					{
						bool A_9 = default(bool);
						bool A_8;
						if (fMUSBDeviceType == FMUSBDeviceType.FIUSB2DeviceSpecNIR2 || fMUSBDeviceType == FMUSBDeviceType.FIUSB2DeviceSpecTCNIR)
						{
							fe.b(ab8(), "Turn OFF Calib. Light Source, then click OK.", "Information", new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2), A_4: true);
							A_8 = false;
							if (m2(ref A_8, ref A_9, (ew.a)abk().FWOemCode, 1, u9(), 50, A_1, A_2) != FIDeviceErr.None)
							{
								A_3 = "Error attempting to collect spectrum Y data. Procedure aborted.";
								return;
							}
							checked
							{
								array7 = new float[qf.Length - 1 + 1];
								int num = array7.Length - 1;
								for (int num2 = 0; num2 <= num; num2++)
								{
									array7[num2] = (float)qf[num2];
								}
								flag4 = true;
							}
							fe.b(ab8(), "Turn ON Calib. Light Source, then click OK.", "Information", new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2), A_4: true);
						}
						A_8 = false;
						if (m2(ref A_8, ref A_9, (ew.a)abk().FWOemCode, 1, u9(), 50, A_1, A_2) != FIDeviceErr.None)
						{
							A_3 = "Error attempting to collect spectrum Y data. Procedure aborted.";
							return;
						}
						if (A_9)
						{
							A_3 = "Light is too bright. Software error - please notify software group.";
							return;
						}
					}
					array8 = new float[qf.Length - 1 + 1];
					int num3 = array8.Length - 1;
					for (int num2 = 0; num2 <= num3; num2++)
					{
						array8[num2] = (float)qf[num2];
					}
					if (flag4)
					{
						int num4 = array8.Length - 1;
						for (int num2 = 0; num2 <= num4; num2++)
						{
							array8[num2] -= array7[num2];
						}
					}
					A_5 = new hr(null);
					int A_10 = 0;
					float A_11 = 0f;
					m2(ref A_5, ref A_10, ref A_11, A_3: false, A_4: false, DateTime.Now, A_6: false, A_7: false, null, null, 0f, 0f, A_12: true, default(Guid));
					if (flag)
					{
						bool A_8 = false;
						bool A_12 = false;
						if (m2(ref A_8, ref A_12, unchecked((ew.a)abk().FWOemCode), 1, u9() * 30.0, 50, A_1, A_2) != FIDeviceErr.None)
						{
							A_3 = "Error attempting to collect spectrum Y data (long time integration). Procedure aborted.";
							return;
						}
						array6 = new float[qf.Length - 1 + 1];
						A_10 = array6.Length - 1;
						for (int num2 = 0; num2 <= A_10; num2++)
						{
							array6[num2] = (float)qf[num2];
						}
						A_6 = new hr(null);
						int A_13 = 0;
						A_11 = 0f;
						m2(ref A_6, ref A_13, ref A_11, A_3: false, A_4: false, DateTime.Now, A_6: false, A_7: false, null, null, 0f, 0f, A_12: true, default(Guid));
					}
				}
				else
				{
					if (A_0.i.cz()[0] != 0.0)
					{
						A_3 = "Cannot analyze spectrum - starting pixel in the spectrum is not zero.\r\nOnly spectra aquired with Restricted Wavelength unchecked can be analyzed.";
						return;
					}
					double[] array9 = A_0.i.c0();
					array8 = new float[array9.Length - 1 + 1];
					int A_13 = array8.Length - 1;
					for (int num2 = 0; num2 <= A_13; num2++)
					{
						array8[num2] = (float)array9[num2];
					}
					if (flag)
					{
						if (A_0.j.cz()[0] != 0.0)
						{
							A_3 = "Cannot analyze spectrum - starting pixel in the spectrum is not zero.\r\nOnly spectra aquired with Restricted Wavelength unchecked can be analyzed.";
							return;
						}
						array9 = A_0.j.c0();
						array6 = new float[array9.Length - 1 + 1];
						int num5 = array8.Length - 1;
						for (int num2 = 0; num2 <= num5; num2++)
						{
							array6[num2] = (float)array9[num2];
						}
					}
				}
				double[] A_14 = null;
				float[] array10 = null;
				float[] A_15 = null;
				float[] array11 = null;
				if (!m2(j.ah() + "\\" + j2.g + ".csv", ref A_14, ref A_15, ref A_3))
				{
					return;
				}
				int num6 = A_15.Length;
				int num7 = num6 - 1;
				array10 = new float[A_14.Length - 1 + 1];
				int num8 = num7;
				for (int num2 = 0; num2 <= num8; num2++)
				{
					array10[num2] = (float)A_14[num2];
				}
				int num9 = (flag ? num7 : num6);
				int num10 = num9 - 1;
				float[] array12 = new float[num10 + 1];
				float[] array13 = new float[num10 + 1];
				float[] array14 = new float[num10 + 1];
				float[] array15 = new float[num10 + 1];
				float[] array16 = new float[num10 + 1];
				string a_3 = j.ah() + "\\" + j2.g + ".txt";
				if (flag)
				{
					int num11 = num10;
					for (int num2 = 0; num2 <= num11; num2++)
					{
						array10[num2] = array10[num2 + 1];
					}
					array10 = (float[])Utils.CopyArray(array10, new float[num10 + 1]);
				}
				int num12 = m2(array8, num9, array10, A_3: false, a_3, array12, ref j2.v, ref j2.w, array13, array14, array15, array16);
				if (num12 != 0)
				{
					A_3 = sj(num12);
					return;
				}
				double[] array17;
				if (flag)
				{
					array = new float[1];
					array11 = new float[1];
					array2 = new float[1];
					array3 = new float[1];
					array4 = new float[1];
					array5 = new float[1];
					array17 = new double[num10 + 1];
					int num13 = array17.Length - 1;
					for (int num2 = 0; num2 <= num13; num2++)
					{
						array17[num2] = array12[num2];
					}
					double[] array18 = new double[num10 + 1];
					int num14 = num10;
					for (int num2 = 0; num2 <= num14; num2++)
					{
						array18[num2] = A_14[num2 + 1];
					}
					double[] array19 = new double[3];
					num12 = jf.a(array17, array18, num9, (short)2, array19);
					if (num12 != 0)
					{
						A_3 = "Polynomial fit failed in pre-fit." + num12;
						return;
					}
					double num15 = array19[2];
					double num16 = array19[1];
					double num17 = array19[0] - A_14[0];
					array11[0] = (float)((0.0 - num16 + Math.Sqrt(num16 * num16 - 4.0 * num15 * num17)) * 0.5 / num15);
					float[] a_4 = array6;
					float[] a_5 = array11;
					float[] a_6 = array;
					float A_11 = 0f;
					float A_16 = 0f;
					num12 = m2(a_4, 1, a_5, A_3: true, a_3, a_6, ref A_11, ref A_16, array2, array3, array4, array5);
					if (num12 != 0)
					{
						A_3 = sj(num12);
						return;
					}
				}
				array17 = new double[num7 + 1];
				if (flag)
				{
					array17[0] = array[0];
					int num18 = num10;
					for (int num2 = 0; num2 <= num18; num2++)
					{
						array17[num2 + 1] = array12[num2];
					}
					array13 = (float[])Utils.CopyArray(array13, new float[num7 + 1]);
					array14 = (float[])Utils.CopyArray(array14, new float[num7 + 1]);
					array15 = (float[])Utils.CopyArray(array15, new float[num7 + 1]);
					array16 = (float[])Utils.CopyArray(array16, new float[num7 + 1]);
					for (int num2 = num10; num2 >= 0; num2 += -1)
					{
						array13[num2 + 1] = array13[num2];
						array14[num2 + 1] = array14[num2];
						array15[num2 + 1] = array15[num2];
						array16[num2 + 1] = array16[num2];
					}
					array13[0] = array2[0];
					array14[0] = array3[0];
					array15[0] = array4[0];
					array16[0] = array5[0];
				}
				else
				{
					int num19 = num7;
					for (int num2 = 0; num2 <= num19; num2++)
					{
						array17[num2] = array12[num2];
					}
				}
				short num20 = unchecked((short)(flag2 ? 4 : 2));
				double[] array20 = new double[num20 + 1];
				num12 = jf.a(array17, A_14, num6, num20, array20);
				if (num12 != 0)
				{
					A_3 = "Polynomial fit failed." + num12;
					return;
				}
				if (fMUSBDeviceType == FMUSBDeviceType.FIUSB2DeviceSpecLC)
				{
					double[] array21 = new double[3];
					if (flag2)
					{
						num12 = jf.a(array17, A_14, num6, (short)2, array21);
						if (num12 != 0)
						{
							A_3 = "Polynomial fit for key peaks check failed." + num12;
							return;
						}
					}
					else
					{
						array21 = array20;
					}
					if (!m2(j.ah() + "\\" + j2.g + "_KeyPeaksCheck.txt", array8, array21, ref A_3))
					{
						return;
					}
				}
				j2.k = (float)array20[0];
				j2.l = (float)array20[1];
				j2.m = (float)array20[2];
				if (flag2)
				{
					j2.n = (float)array20[3];
					j2.o = (float)array20[4];
				}
				if (((IFIUsbSpectrometer)this.m_m2).get_TemperatureSensorExists(SpectromTempSensorLoc.kFMTSLocSpectrometer) != 0)
				{
					j2.p = qg;
				}
				float A_17 = default(float);
				float A_18 = default(float);
				if (!m2(j2.g, ref A_17, ref A_18))
				{
					A_3 = "Failed ExtractWavelengthRangeFromSettingsFileName";
					return;
				}
				int num21 = m2(j2.k, j2.l, j2.m, j2.n, j2.o, this.m_m2.NumPixels, A_17, A_18);
				float num22;
				float num23;
				float a_7;
				float a_8;
				float a_9;
				float num24;
				if (j2.h)
				{
					num22 = this.m_m2.FWCalOffset2;
					num23 = this.m_m2.FWCalSlope2;
					a_7 = this.m_m2.FWCalCurv2;
					a_8 = this.m_m2.FWCalThird2;
					a_9 = this.m_m2.FWCalFourth2;
					num24 = this.m_m2.FWCalTemp2;
				}
				else
				{
					num22 = this.m_m2.FWCalOffset;
					num23 = this.m_m2.FWCalSlope;
					a_7 = this.m_m2.FWCalCurv;
					a_8 = this.m_m2.FWCalThird;
					a_9 = this.m_m2.FWCalFourth;
					num24 = this.m_m2.FWCalTemp1;
				}
				j2.s = num22 != 0f && num23 != 0f;
				if (j2.s)
				{
					j2.q = m2(num21, j2.k, j2.l, j2.m, j2.n, j2.o, num22, num23, a_7, a_8, a_9);
				}
				j2.t = num24 != 0f;
				if (j2.t)
				{
					j2.u = j2.p - num24;
				}
				if (j2.s && j2.t)
				{
					j2.r = j2.q - this.m_th * j2.u;
				}
				try
				{
					if (this.m_th != 0f)
					{
						FIUsbSpectrometer fIUsbSpectrometer = this.m_m2;
						float num25;
						float num26;
						if (fIUsbSpectrometer.FWCalThird == 0f && fIUsbSpectrometer.FWCalFourth == 0f)
						{
							num25 = fIUsbSpectrometer.FWCalOffset + (fIUsbSpectrometer.FWCalSlope + fIUsbSpectrometer.FWCalCurv * (float)num21) * (float)num21;
							num26 = fIUsbSpectrometer.FWCalOffset2 + (fIUsbSpectrometer.FWCalSlope2 + fIUsbSpectrometer.FWCalCurv2 * (float)num21) * (float)num21;
						}
						else
						{
							num25 = (float)((double)fIUsbSpectrometer.FWCalOffset + ((double)fIUsbSpectrometer.FWCalSlope + ((double)fIUsbSpectrometer.FWCalCurv + ((double)fIUsbSpectrometer.FWCalThird + (double)fIUsbSpectrometer.FWCalFourth * (double)num21) * (double)num21) * (double)num21) * (double)num21);
							num26 = (float)((double)fIUsbSpectrometer.FWCalOffset2 + ((double)fIUsbSpectrometer.FWCalSlope2 + ((double)fIUsbSpectrometer.FWCalCurv2 + ((double)fIUsbSpectrometer.FWCalThird2 + (double)fIUsbSpectrometer.FWCalFourth2 * (double)num21) * (double)num21) * (double)num21) * (double)num21);
						}
						fIUsbSpectrometer = null;
						float num27 = (float)((double)j2.k + ((double)j2.l + ((double)j2.m + ((double)j2.n + (double)j2.o * (double)num21) * (double)num21) * (double)num21) * (double)num21);
						float num28 = num27 - num26 - this.m_th * (qg - this.m_m2.FWCalTemp2);
						string text = DateTime.Now.ToString() + "," + qg + "," + num28 + "," + (num27 - num25);
						int num29 = array17.Length - 1;
						for (int num2 = 0; num2 <= num29; num2++)
						{
							text = text + "," + array17[num2];
						}
						text += "\r\n";
						if (!File.Exists(uk() + "wavelenStability.csv"))
						{
							string text2 = "DateTime,Temperature,CalibShift,Shift(no Temp. Comp)";
							int num30 = array17.Length - 1;
							for (int num2 = 0; num2 <= num30; num2++)
							{
								text2 = text2 + "," + A_14[num2] + " nm";
							}
							text = text2 + "\r\n" + text;
						}
						File.AppendAllText(uk() + "wavelenStability.csv", text);
					}
					FIUsbSpectrometer fIUsbSpectrometer2 = this.m_m2;
					float A_19 = default(float);
					if (A_0.h)
					{
						m2(fIUsbSpectrometer2.FWCalTemp1, fIUsbSpectrometer2.FWCalOffset, fIUsbSpectrometer2.FWCalSlope, fIUsbSpectrometer2.FWCalCurv, fIUsbSpectrometer2.FWCalThird, fIUsbSpectrometer2.FWCalFourth, A_0.p, A_0.k, A_0.l, A_0.m, A_0.n, A_0.o, x4(), fIUsbSpectrometer2.NumPixels, "WLCal", fIUsbSpectrometer2.FriendlySN.ToString(), fIUsbSpectrometer2.eSpectromType.ToString(), "False", ref A_19);
					}
					else
					{
						m2(A_0.p, A_0.k, A_0.l, A_0.m, A_0.n, A_0.o, fIUsbSpectrometer2.FWCalTemp2, fIUsbSpectrometer2.FWCalOffset2, fIUsbSpectrometer2.FWCalSlope2, fIUsbSpectrometer2.FWCalCurv2, fIUsbSpectrometer2.FWCalThird2, fIUsbSpectrometer2.FWCalFourth2, x4(), fIUsbSpectrometer2.NumPixels, "WLCal", fIUsbSpectrometer2.FriendlySN.ToString(), fIUsbSpectrometer2.eSpectromType.ToString(), "True", ref A_19);
					}
					fIUsbSpectrometer2 = null;
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex3 = ex2;
					ProjectData.ClearProjectError();
				}
				string path = j.ah() + "\\AutoCalib Peaks.txt";
				if (File.Exists(path))
				{
					File.Delete(path);
				}
				StreamWriter streamWriter = new StreamWriter(path, append: false);
				streamWriter.WriteLine("Peak Location,Peak Center(10% from top),Peak Center(50% from top),Peak Width(10% from top),Peak Width(50% from top)");
				int num31 = num7;
				for (int num2 = 0; num2 <= num31; num2++)
				{
					streamWriter.WriteLine(array17[num2] + "," + array13[num2] + "," + array15[num2] + "," + array14[num2] + "," + array16[num2]);
				}
				streamWriter.Close();
				if (A_0.i == null)
				{
					string A_20 = j.ah() + "\\AutoCalib Spectrum.fmspe";
					if (File.Exists(A_20))
					{
						File.Delete(A_20);
					}
					if (flag4)
					{
						double[] array22 = new double[A_5.c0().Length - 1 + 1];
						int num32 = A_5.c0().Length - 1;
						for (int num2 = 0; num2 <= num32; num2++)
						{
							array22[num2] = array8[num2];
						}
						A_5.r(array22);
						A_5.af(array22);
					}
					A_5.k(ref A_20, null, null);
					if (flag)
					{
						string A_21 = j.ah() + "\\AutoCalib Spectrum Long Integration.fmspe";
						if (File.Exists(A_21))
						{
							File.Delete(A_21);
						}
						A_6.k(ref A_21, null, null);
					}
				}
				if (flag3)
				{
					List<int> list = new List<int>();
					int num33 = (flag ? 1 : 0);
					int num34 = num7;
					for (int num2 = num33; num2 <= num34; num2++)
					{
						if ((double)Math.Abs(array13[num2] - array15[num2]) > 0.5)
						{
							list.Add(num2);
						}
					}
					if (list.Count > 0)
					{
						StringBuilder stringBuilder = new StringBuilder();
						stringBuilder.Append("The following peak(s) are asymmetrical:");
						int num35 = list.Count - 1;
						for (int num2 = 0; num2 <= num35; num2++)
						{
							stringBuilder.Append("\r\n");
							stringBuilder.Append(array17[list[num2]].ToString());
						}
						A_4 = stringBuilder.ToString();
					}
				}
			}
			finally
			{
				if (x9() && this.m_tg > this.m_tf)
				{
					this.m_m2.SetFirstLastValidPixelIdx(this.m_tf, this.m_tg);
					uf();
					int a_10 = this.m_p9;
					float a_11 = this.m_td;
					float a_12 = this.m_tc;
					float a_13 = this.m_tb;
					float a_14 = ta;
					float a_15 = s9;
					ref double[] a_16 = ref q2;
					double[] A_7 = null;
					m2(a_10, a_11, a_12, a_13, a_14, a_15, ref a_16, ref A_7);
				}
			}
			j2 = null;
		}
	}

	private string sj(int A_0)
	{
		return A_0 switch
		{
			-1 => "Error: The spectrum array is shorter than the upper searching limit specified by the configuration file.\r\nIf this happened during analying an existing spectrum, make sure the spectrum is compatible with the configuration file.\r\nIf this happened during measuring, contact SW group. Error code = " + A_0, 
			-2 => "Error: Total amount of peaks in the spectrum is less than the amount we are looking for.\r\nPossible cause is weak signal or the light source has been on for too long - make sure the Ar peaks are not too short.\r\nContact SW group if this problem persists. Error code = " + A_0, 
			-3 => "Error: Too many peaks are found (>100), check if the spectrum is too noisy.", 
			-4 => "Error: Failed to match all peaks in the given range of curvature, slope and offset.\r\nCheck if the signal is too weak (so we missed at least one valid peak) or need to widen the searching range.\r\nContact SW group if the spectrum looks normal. Error code = " + A_0, 
			-11 => "Error: Failed to open configuration file (i.e. LCSpc_380-1050).\r\nMake sure the file exists and is not opened. Error code = " + A_0, 
			-12 => "Error: Configuration file corrupted. Make sure the format is correct if it was editted manually.\r\n Error code = " + A_0, 
			-13 => "Error: Software version too old. Check SW update or contact SW group.\r\n Error code = " + A_0, 
			-14 => "Error: Configuration file version too old. Check SW update or contact SW group.\r\n Error code = " + A_0, 
			_ => "Unknow error. Please contact SW group. Error code = " + A_0, 
		};
	}

	private new static bool m2(string A_0, float[] A_1, double[] A_2, ref string A_3)
	{
		int A_4 = default(int);
		int A_5 = default(int);
		float A_6 = default(float);
		float A_7 = default(float);
		float A_8 = default(float);
		int A_9 = default(int);
		int A_10 = default(int);
		int A_11 = default(int);
		if (!m2(A_0, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8, ref A_9, ref A_10, ref A_11, ref A_3))
		{
			return false;
		}
		checked
		{
			int A_12 = (int)Math.Round(m2(A_2[0], A_2[1], A_2[2], A_5));
			if (!m2(A_1, A_12 - A_11, A_11 * 2, 100, ref A_12))
			{
				A_3 = "Failed to relocate 404nm peak. Contact SW group.";
				return false;
			}
			float num = A_1[A_12];
			A_12 = (int)Math.Round(m2(A_2[0], A_2[1], A_2[2], A_4));
			if (!m2(A_1, A_12 - A_11, A_11 * 2, (int)Math.Round(num * A_8), ref A_12))
			{
				A_3 = "Error: 365nm peak is missing or less than 50% height of 404nm peak.\r\npixel = " + A_12 + ", height = " + A_1[A_12];
				return false;
			}
			A_12 = (int)Math.Round(m2(A_2[0], A_2[1], A_2[2], A_6));
			if (m2(A_1, A_12 - A_11, A_11 * 2, A_9, ref A_12))
			{
				A_3 = "Error: 2nd order peak detected. 546nm.\r\npixel = " + A_12 + ", height = " + A_1[A_12];
				return false;
			}
			A_12 = (int)Math.Round(m2(A_2[0], A_2[1], A_2[2], A_7));
			if (m2(A_1, A_12 - A_11, A_11 * 2, A_10, ref A_12))
			{
				A_3 = "Error: 2nd order peak detected. 579nm.\r\npixel = " + A_12 + ", height = " + A_1[A_12];
				return false;
			}
			return true;
		}
	}

	private new static float m2(double A_0, double A_1, double A_2, double A_3)
	{
		return (float)(0.5 * (0.0 - A_1 + Math.Sqrt(A_1 * A_1 - 4.0 * A_2 * (A_0 - A_3))) / A_2);
	}

	private new static bool m2(float[] A_0, int A_1, int A_2, int A_3, ref int A_4)
	{
		float num = 0f;
		A_4 = A_1;
		checked
		{
			int num2 = A_1 + 1;
			int num3 = A_1 + A_2 - 1;
			for (int num4 = num2; num4 <= num3; num4++)
			{
				if (A_0[num4] > A_0[A_4])
				{
					A_4 = num4;
				}
			}
			if (A_0[A_4] < (float)A_3)
			{
				return false;
			}
			int num5 = A_4 - 2;
			int num6 = A_4 + 2;
			if (num5 >= 0 && num6 < A_0.Length)
			{
				int num7 = A_4 - 2;
				int num8 = A_4 + 2;
				for (int num4 = num7; num4 <= num8; num4++)
				{
					num += A_0[num4];
				}
				if (num < (float)(A_3 * 2))
				{
					return false;
				}
			}
			return true;
		}
	}

	public new void m2(string A_0, DateTime A_1, bool A_2)
	{
		double[] A_3 = null;
		int num;
		float[] a_;
		int[] a_2;
		int[] a_3;
		double[] a_4;
		double[] a_5;
		double[] array;
		double[] A_4;
		float[] array3;
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes;
		checked
		{
			num = this.m_p9 - 1;
			a_ = new float[num + 1];
			a_2 = new int[num + 1];
			a_3 = new int[num + 1];
			a_4 = new double[num + 1];
			a_5 = new double[num + 1];
			array = new double[num + 1];
			A_4 = null;
			double[] array2 = new double[num + 1];
			array3 = new float[num + 1];
			opticsConfigSubmoduleTypes = this.m_tj.k();
		}
		this.m_wk[(int)opticsConfigSubmoduleTypes] = null;
		this.m_wl[(int)opticsConfigSubmoduleTypes] = null;
		this.m_wn[(int)opticsConfigSubmoduleTypes] = DateTime.MinValue;
		this.m_wm[(int)opticsConfigSubmoduleTypes] = null;
		this.m_wo[(int)opticsConfigSubmoduleTypes] = null;
		this.m_wp[(int)opticsConfigSubmoduleTypes] = null;
		q0 = true;
		float[] array5;
		ie ie2;
		checked
		{
			double[] array4 = new double[qf.Length - 1 + 1];
			qf.CopyTo(array4, 0);
			float A_5 = 0f;
			bool A_6 = false;
			int A_7 = 0;
			int A_8 = 0;
			m2(ref A_3, ref A_5, A_2: false, A_3: false, A_2, a_, a_2, a_3, a_4, a_5, ref A_6, ref A_7, ref A_8, A_1, A_14: true, A_15: true, null, null, 0f, 0f, default(Guid));
			ex ex2 = new ex();
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(A_0);
			string text = null;
			string value = jb.u(fileNameWithoutExtension);
			try
			{
				if (string.IsNullOrEmpty(value))
				{
					text = Path.Combine(jb.d(), Path.GetFileName(A_0));
					global::c.e().FileSystem.CopyFile(A_0, text);
				}
				if (!ex2.e(fileNameWithoutExtension, ex.a.a, 0f, A_3: false, A_4: false))
				{
					ab8().c(fz.b.a, "Error attempting to read reference material file " + fileNameWithoutExtension + ". File may be missing or corrupted.");
					return;
				}
			}
			finally
			{
				if (!string.IsNullOrEmpty(text))
				{
					global::c.e().FileSystem.DeleteFile(text);
				}
			}
			double[] A_9 = null;
			if (!ex2.e(q2, this.m_p9, ref A_9))
			{
				ab8().c(fz.b.a, "Error attempting to interpolate reference material file " + fileNameWithoutExtension + ". File may be missing or corrupted.");
				return;
			}
			double[] A_10 = null;
			string A_11 = vp();
			m2(ref A_11, ref A_10);
			double[] A_12 = null;
			double[] A_13 = null;
			jf.a(q2, A_3, this.m_p9, 40, ref A_12);
			int num2 = 0;
			int a_6 = 0;
			if (xs() == FMUSBDeviceType.FIUSB2DeviceSpecUvVis2)
			{
				jf.a(q2, A_3, this.m_p9, 5, ref A_13);
				A_8 = num;
				for (int num3 = 0; num3 <= A_8; num3++)
				{
					double num4;
					if (q2[num3] < 420.0)
					{
						num4 = 1.0;
					}
					else if (q2[num3] < 450.0)
					{
						num4 = (450.0 - q2[num3]) / 30.0;
					}
					else
					{
						num4 = 0.0;
						if (num2 == 0)
						{
							num2 = num3;
						}
					}
					A_12[num3] = num4 * A_13[num3] + (1.0 - num4) * A_12[num3];
				}
				a_6 = 2;
			}
			array5 = new float[num + 1];
			float[] array6 = new float[num + 1];
			A_7 = num;
			for (int num5 = 0; num5 <= A_7; num5++)
			{
				double num6 = A_9[num5] * A_9[num5] - A_10[num5] * A_12[num5];
				double num7 = A_12[num5] - A_9[num5];
				if (num6 > 0.0 && num7 > 0.0)
				{
					array[num5] = num7 / num6;
				}
				if (array[num5] < 3.000000106112566E-07)
				{
					array[num5] = 3.000000106112566E-07;
				}
				array5[num5] = (float)q2[num5];
				array6[num5] = (float)A_10[num5];
			}
			double A_14 = default(double);
			double A_15 = default(double);
			m2(q2, array, this.m_p9, 5, 10, 10, 20, ref A_4, ref A_14, ref A_15);
			ie2 = new ie(h9.b, opticsConfigSubmoduleTypes, A_11, this.m_td, this.m_tc, this.m_tb, ta, s9, A_4, this.m_p9, 40, A_14, A_15, num2, a_6);
			double[] array2 = ie2.h();
			int num8 = num;
			for (int num9 = 0; num9 <= num8; num9++)
			{
				array3[num9] = (float)((double)vd() * array2[num9]);
			}
		}
		this.m_wk[(int)opticsConfigSubmoduleTypes] = array3;
		this.m_wl[(int)opticsConfigSubmoduleTypes] = array5;
		this.m_wn[(int)opticsConfigSubmoduleTypes] = DateTime.Now;
		m2(ie2, this.m_wn[(int)opticsConfigSubmoduleTypes]);
		tj();
		sm(opticsConfigSubmoduleTypes);
	}

	public void sm(g2.OpticsConfigSubmoduleTypes A_0)
	{
		float[] A_1 = this.m_wk[(int)A_0];
		if (A_1 == null)
		{
			return;
		}
		double[] A_2 = null;
		string A_3 = vp();
		m2(ref A_3, ref A_2);
		float[] A_4;
		float[] A_5;
		float[] A_6;
		Collection<float[]> collection;
		checked
		{
			A_4 = new float[this.m_p9 - 1 + 1];
			A_5 = new float[this.m_p9 - 1 + 1];
			A_6 = new float[this.m_p9 - 1 + 1];
			int num = this.m_p9 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				A_5[num2] = (float)q2[num2];
				A_6[num2] = (float)A_2[num2];
			}
			collection = this.m_wl;
		}
		int index;
		float[] A_7 = collection[index = (int)A_0];
		jf.a(ref A_7, ref A_1, A_1.Length, ref A_5, ref A_4, this.m_p9);
		collection[index] = A_7;
		this.m_wm[(int)A_0] = A_4;
		float[] A_8 = new float[checked(this.m_p9 - 1 + 1)];
		Collection<float[]> collection2 = this.m_wl;
		A_7 = collection2[index = (int)A_0];
		jf.a(ref A_7, ref A_6, A_1.Length, ref A_5, ref A_8, this.m_p9);
		collection2[index] = A_7;
		float[] array;
		float[] array2;
		checked
		{
			array = new float[this.m_p9 - 1 + 1];
			array2 = new float[this.m_p9 - 1 + 1];
			index = this.m_p9 - 1;
			for (int num3 = 0; num3 <= index; num3++)
			{
				array[num3] = 1f + A_4[num3] * A_8[num3];
				array2[num3] = 1f / (2f * A_4[num3]);
			}
		}
		this.m_wp[(int)A_0] = array;
		this.m_wo[(int)A_0] = array2;
		q0 = true;
		checked
		{
			if (this.m_ws != null && !jf.e(this.m_ws.ve(), 0f))
			{
				int num4 = this.m_ws.m_p9;
				float[] A_9 = new float[num4 - 1 + 1];
				float[] A_10 = new float[num4 - 1 + 1];
				float num5 = this.m_ws.ve() / vd();
				int num6 = num4 - 1;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					A_9[num7] = (float)this.m_ws.q2[num7];
				}
				Collection<float[]> collection3 = this.m_wl;
				int index2;
				A_7 = collection3[index2 = unchecked((int)A_0)];
				jf.a(ref A_7, ref A_1, A_1.Length, ref A_9, ref A_10, num4);
				collection3[index2] = A_7;
				index2 = num4 - 1;
				for (int num8 = 0; num8 <= index2; num8++)
				{
					A_10[num8] *= num5;
				}
				this.m_ws.p9(A_10);
			}
		}
	}

	private void tj()
	{
		BinaryWriter binaryWriter = null;
		checked
		{
			try
			{
				string path = yo();
				binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create));
				binaryWriter.Write(2);
				binaryWriter.Write(1);
				int num = 11;
				binaryWriter.Write(num);
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					i3.a(this.m_wl[num3], binaryWriter);
					i3.a(this.m_wk[num3], binaryWriter);
					i3.a((float[])null, binaryWriter);
				}
				int num4 = num - 1;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					binaryWriter.Write(this.m_wn[num5].ToOADate());
				}
			}
			finally
			{
				binaryWriter?.Close();
			}
		}
	}

	private void ti()
	{
		BinaryReader binaryReader = null;
		string text = yo();
		checked
		{
			try
			{
				if (!File.Exists(text))
				{
					return;
				}
				binaryReader = new BinaryReader(File.Open(text, FileMode.Open, FileAccess.Read, FileShare.Read));
				int num = binaryReader.ReadInt32();
				int num2 = binaryReader.ReadInt32();
				if (num2 > 2)
				{
					ab8().c(fz.b.b, "Newer software version is required. File " + text + " is a compatible with v" + num2 + ", but this software only understands file versions up to v" + 2 + ".");
					return;
				}
				int num3 = binaryReader.ReadInt32();
				float[] A_ = null;
				float[] A_2 = null;
				float[] A_3 = null;
				int num4 = num3 - 1;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					i3.a(ref A_, binaryReader);
					this.m_wl[num5] = A_;
					i3.a(ref A_2, binaryReader);
					this.m_wk[num5] = A_2;
					i3.a(ref A_3, binaryReader);
					if (!string.IsNullOrEmpty(vp()))
					{
						sm(unchecked((g2.OpticsConfigSubmoduleTypes)num5));
					}
				}
				if (num <= 1)
				{
					return;
				}
				int num6 = num3 - 1;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					double num8 = binaryReader.ReadDouble();
					if (num8 == 0.0)
					{
						this.m_wn[num7] = DateTime.MinValue;
					}
					else
					{
						this.m_wn[num7] = DateTime.FromOADate(num8);
					}
				}
			}
			finally
			{
				binaryReader?.Close();
			}
		}
	}

	private new void m2<a>(a[] A_0, ref float[] A_1)
	{
		int num = A_0.Length;
		int num2 = checked(num - 1);
		int num3 = num / 20;
		checked
		{
			num3 = ((num3 * 20 >= num) ? (num3 + 1) : (num3 + 2));
			int num4 = num3 - 1;
			A_1 = new float[num4 + 1];
			int num5 = 0;
			int num6 = num2;
			for (int num7 = 0; num7 <= num6; num7 += 20)
			{
				A_1[num5] = Convert.ToSingle(A_0[num7]);
				num5++;
			}
			if (num5 == num4)
			{
				A_1[num5] = Convert.ToSingle(A_0[num2]);
			}
		}
	}

	private new void m2<a>(a[] A_0, ref short[] A_1)
	{
		if (A_0 == null)
		{
			A_1 = null;
			return;
		}
		int num = A_0.Length;
		int num2 = checked(num - 1);
		int num3 = num / 20;
		checked
		{
			num3 = ((num3 * 20 >= num) ? (num3 + 1) : (num3 + 2));
			int num4 = num3 - 1;
			A_1 = new short[num4 + 1];
			int num5 = 0;
			int num6 = num2;
			for (int num7 = 0; num7 <= num6; num7 += 20)
			{
				double num8 = Math.Round(Convert.ToDouble(A_0[num7]));
				if (num8 > 32767.0)
				{
					A_1[num5] = short.MaxValue;
				}
				else if (num8 < -32768.0)
				{
					A_1[num5] = short.MinValue;
				}
				else
				{
					A_1[num5] = Convert.ToInt16(num8);
				}
				num5++;
			}
			if (num5 == num4)
			{
				double num8 = Math.Round(Convert.ToDouble(A_0[num2]));
				if (num8 > 32767.0)
				{
					A_1[num4] = short.MaxValue;
				}
				else if (num8 < -32768.0)
				{
					A_1[num4] = short.MinValue;
				}
				else
				{
					A_1[num4] = Convert.ToInt16(num8);
				}
			}
		}
	}

	private bool p9(double[] A_0)
	{
		this.m_ti.k();
		checked
		{
			if (tu)
			{
				int num = tv - 1;
				int num2 = tw + 1;
				int num3 = num2 - num;
				int num4 = this.m_p9 - 1;
				if (num < 0)
				{
					num = 0;
				}
				if (num2 > this.m_p9 - 1)
				{
					num2 = num4;
				}
				double num5 = A_0[num];
				int num6 = num;
				int num7 = num2;
				int num9 = default(int);
				for (int num8 = num6; num8 <= num7; num8++)
				{
					if (A_0[num8] > num5)
					{
						num5 = A_0[num8];
						num9 = num8;
					}
				}
				bool flag = true;
				if (num9 == num && num9 > 0)
				{
					flag = false;
					int num10 = Math.Max(0, num - num3);
					int num11 = num9 - 1;
					int num12 = num10;
					for (int num8 = num11; num8 >= num12; num8 += -1)
					{
						if (A_0[num8] < A_0[num8 + 1])
						{
							num9 = num8 + 1;
							flag = true;
							break;
						}
					}
				}
				else if (num9 == num2 && num9 < num4)
				{
					flag = false;
					int num13 = Math.Min(num2 + num3, num4);
					int num14 = num9 + 1;
					int num15 = num13;
					for (int num8 = num14; num8 <= num15; num8++)
					{
						if (A_0[num8] < A_0[num8 - 1])
						{
							num9 = num8 - 1;
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					return false;
				}
				int num16 = num;
				int num17 = num2;
				double num18 = double.MinValue;
				double num19 = double.MinValue;
				for (int num8 = num9 - 1; num8 >= 0; num8 += -1)
				{
					double num20 = A_0[num8 + 1] - A_0[num8];
					if (num20 > num18)
					{
						num18 = num20;
					}
					else if (num20 < num18 && num20 < num18 * 0.4000000059604645)
					{
						num16 = num8;
						break;
					}
				}
				int num21 = num9 + 1;
				int num22 = num4;
				for (int num8 = num21; num8 <= num22; num8++)
				{
					double num20 = A_0[num8 - 1] - A_0[num8];
					if (num20 > num19)
					{
						num19 = num20;
					}
					else if (num20 < num19 && num20 < num19 * 0.4000000059604645)
					{
						num17 = num8;
						break;
					}
				}
				double num23 = double.MaxValue;
				num5 = double.MinValue;
				int num24 = num16;
				int num25 = num17;
				for (int num8 = num24; num8 <= num25; num8++)
				{
					if (A_0[num8] > num5)
					{
						num5 = A_0[num8];
					}
					if (A_0[num8] < num23)
					{
						num23 = A_0[num8];
					}
				}
				flag = num5 / num23 > 1.2000000476837158;
				tx = Math.Max(0, num16);
				ty = Math.Min(num17, num4);
				int num26 = ty - tx;
				if (num26 < num3)
				{
					double num27 = (double)num3 / 2.0;
					double num28 = (double)(ty + tx) / 2.0;
					tx = Math.Max(0, (int)Math.Round(num28 - num27));
					ty = Math.Min(num4, (int)Math.Round(num28 + num27));
				}
				else if (num26 > num3 * 3 && flag)
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append("Error removing DAlpha peak - peak is too wide.\r\nest1 = " + tv + ", est2 = " + tw + ", fine1 = " + tx + ", fine2 = " + ty + "\r\n");
					stringBuilder.Append(((int)Math.Round(A_0[0])).ToString());
					int num29 = num4;
					for (int num8 = 1; num8 <= num29; num8++)
					{
						stringBuilder.Append(",");
						stringBuilder.Append(((int)Math.Round(A_0[num8])).ToString());
					}
					string a_ = stringBuilder.ToString();
					ab8().c(fz.b.b, a_);
					tx = tv;
					ty = tw;
					return false;
				}
				return flag;
			}
			tx = tv;
			ty = tw;
			return false;
		}
	}

	public void xc()
	{
		rp.Clear();
		rn.Clear();
		ro.Clear();
	}

	public void xd()
	{
		sx.Clear();
		sv.Clear();
		sw.Clear();
	}

	public void xe()
	{
		sx = new Collection<double>();
		sv = new Collection<float[]>();
		sw = new Collection<float[]>();
	}

	public void xf()
	{
		checked
		{
			int num = this.m_p9 - 1;
			double[] array = (double[])qf.Clone();
			p9(array, qg);
			float[] array2 = new float[num + 1];
			float[] array3 = new float[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				array2[num3] = (float)qf[num3];
				array3[num3] = (float)array[num3];
			}
			sx.Add(sq);
			sv.Add(array2);
			sw.Add(array3);
		}
	}

	public new bool m2(bool A_0, bool A_1, bool A_2, bool A_3)
	{
		c[] array = ry;
		checked
		{
			int num = this.m_p9 - 1;
			bool result = true;
			if (array != null)
			{
				int upperBound = array.GetUpperBound(0);
				for (int num2 = 0; num2 <= upperBound; num2++)
				{
					if (A_0 || array[num2].x() == null)
					{
						if (!m2(se, array[num2].j) && !A_2)
						{
							result = false;
							rz = null;
							r0 = null;
							if (A_3)
							{
								ab8().c(fz.b.a, "Error: background integration time is: " + Conversions.ToString(sq) + "; reference " + num2 + " integration time is: " + Conversions.ToString(array[num2].j));
							}
						}
						else if (!A_2 && r0 != null)
						{
							float[] array2 = new float[num + 1];
							float[] array3 = array[num2].w();
							int num3 = num;
							for (int num4 = 0; num4 <= num3; num4++)
							{
								array2[num4] = array3[num4] - r0[num4];
							}
							array[num2].w(array2);
						}
					}
					if ((!A_0 && array[num2].aa() != null) || array[num2].z() == null)
					{
						continue;
					}
					if (!m2(se, array[num2].j))
					{
						result = false;
						rz = null;
						r0 = null;
						if (A_3)
						{
							ab8().c(fz.b.a, "Error: background integration time is: " + Conversions.ToString(sq) + "; reference " + num2 + " integration time is: " + Conversions.ToString(array[num2].j));
						}
					}
					else
					{
						float[] array4 = new float[num + 1];
						float[] array5 = array[num2].z();
						int num5 = num;
						for (int num4 = 0; num4 <= num5; num4++)
						{
							array4[num4] = array5[num4] - r0[num4];
						}
						array[num2].z(array4);
					}
				}
			}
			if (A_1)
			{
				r9 = true;
				r8 = true;
			}
			return result;
		}
	}

	private double[] th()
	{
		double num = 0.0;
		double num2 = double.MinValue;
		int num3 = 0;
		checked
		{
			int num4 = this.m_p9 - 1;
			double[] array = new double[num4 + 1];
			if (xs() == FMUSBDeviceType.FIUSB2DeviceSpecLC || xs() == FMUSBDeviceType.FIUSB2DeviceSpecUvVis2)
			{
				int num5 = num4;
				int num7 = default(int);
				for (int num6 = 0; num6 <= num5; num6++)
				{
					if (q2[num6] < 830.0)
					{
						if (qf[num6] > num2)
						{
							num2 = qf[num6];
						}
						array[num6] = qf[num6];
						num += array[num6];
						num3++;
						continue;
					}
					num7 = num6;
					break;
				}
				if (qf[num4] > num2)
				{
					num /= (double)num3;
					double num8 = 0.0;
					int num9 = num7;
					int num10 = num4;
					for (int num11 = num9; num11 <= num10; num11++)
					{
						if (num8 < 1.0)
						{
							num8 = (q2[num11] - q2[num7]) / 100.0;
							if (num8 < 1.0)
							{
								array[num11] = (1.0 - num8) * qf[num11] + num8 * num;
							}
							else
							{
								array[num11] = num;
							}
						}
						else
						{
							array[num11] = num;
						}
					}
				}
				else
				{
					array = qf;
				}
				return array;
			}
			ab8().c(fz.b.b, "Need to implement code in MakeLastSpectrumBac for this spectrometer. Type is " + xs().ToString() + ".");
			throw new ApplicationException("Need to implement code in MakeLastSpectrumBac for this spectrometer");
		}
	}

	public new bool m2(DateTime A_0, bool A_1, ej A_2, bool A_3, bool A_4, bool A_5, bool A_6, int A_7)
	{
		checked
		{
			int num = this.m_p9 - 1;
			double[] array = null;
			if (!sp)
			{
				m2(A_0);
				sm(A_0);
				p9(A_0);
			}
			array = ((!A_5 || this.m_ti.k() != g2.OpticsConfigSubmoduleTypes.Transmittance) ? qf : th());
			double[] array2 = (double[])array.Clone();
			p9(array2, qg);
			rz = new float[num + 1];
			r0 = new float[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				rz[num3] = (float)array[num3];
				r0[num3] = (float)array2[num3];
			}
			sa = A_0;
			sc = DateTime.Now;
			se = sq;
			su = A_2;
			ng = true;
			bool result = A_5 || m2(A_1, A_3, A_4, A_3: true);
			if (A_6)
			{
				s3(A_7);
			}
			return result;
		}
	}

	public new bool m2(DateTime A_0, bool A_1, bool A_2, int A_3)
	{
		bool result = true;
		checked
		{
			int num = this.m_p9 - 1;
			if (!sp)
			{
				sm(A_0);
				qh(A_0);
			}
			double[] array = (double[])qf.Clone();
			p9(array, qg);
			r1 = new float[num + 1];
			r2 = new float[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				r1[num3] = (float)qf[num3];
				r2[num3] = (float)array[num3];
			}
			sa = A_0;
			sd = DateTime.Now;
			sf = sq;
			if (A_1 && this.m_ti.k() == g2.OpticsConfigSubmoduleTypes.ReflectanceProbe)
			{
				rz = r1;
				r0 = new float[num + 1];
				int num4 = num;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					r0[num5] = r2[num5] - this.m_wc[num5] * r2[num5];
				}
				sc = DateTime.Now;
			}
			if (A_2)
			{
				s3(A_3);
			}
			return result;
		}
	}

	public new bool m2(ej A_0, bool A_1, int A_2)
	{
		bool result = true;
		checked
		{
			int num = this.m_p9 - 1;
			double[] array = (double[])qf.Clone();
			p9(array, qg);
			r3 = new float[num + 1];
			r4 = new float[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				r3[num3] = (float)qf[num3];
				r4[num3] = (float)array[num3];
			}
			r6 = DateTime.Now;
			r5 = sq;
			this.m_st = A_0;
			m2();
			if (A_1)
			{
				s3(A_2);
			}
			return result;
		}
	}

	public void xg()
	{
		qi = (double[])qf.Clone();
		qj = qg;
		qk = sq;
	}

	public new void m2(ej A_0)
	{
		rr = (double[])qf.Clone();
		rs = qg;
		rt = sq;
		ru = A_0;
	}

	public void xh()
	{
		rv = (double[])qf.Clone();
		rw = qg;
		rx = sq;
	}

	private new void m2(g2.OpticsConfigSubmoduleTypes A_0, ref ie A_1)
	{
		checked
		{
			int num = this.m_p9 - 1;
			double[] array = new double[num + 1];
			double[] A_2 = null;
			double[] A_3 = new double[num + 1];
			double[] array2 = new double[num + 1];
			this.m_wc = new float[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				array[num3] = (r2[num3] - r0[num3]) / r2[num3];
			}
			jf.a(q2, array, this.m_p9, 40, ref A_2);
			double A_4 = default(double);
			double A_5 = default(double);
			m2(q2, A_2, this.m_p9, 15, 100, 15, 100, ref A_3, ref A_4, ref A_5);
			A_1 = new ie(h9.a, A_0, null, this.m_td, this.m_tc, this.m_tb, ta, s9, A_3, this.m_p9, 40, A_4, A_5, 0, 0);
			array2 = A_1.h();
			int num4 = num;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				this.m_wc[num5] = (float)array2[num5];
			}
		}
	}

	public new void m2(string A_0, bool A_1, bool A_2, bool A_3, bool A_4, int A_5)
	{
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
		StreamWriter streamWriter = null;
		try
		{
			if (A_1 && A_3 && xs() != FMUSBDeviceType.FIUSB2DeviceSpecNIR2)
			{
				if (!A_2)
				{
					switch (opticsConfigSubmoduleTypes)
					{
					case g2.OpticsConfigSubmoduleTypes.ReflectanceProbe:
					{
						ie A_6 = null;
						m2(opticsConfigSubmoduleTypes, ref A_6);
						m2(A_6, sc);
						sn(sc);
						break;
					}
					case g2.OpticsConfigSubmoduleTypes.Transmittance:
					{
						id a_ = new id(this.m_wd);
						m2(a_);
						break;
					}
					}
					this.m_wf = true;
				}
				if (opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.Transmittance)
				{
					this.m_we = this.m_wd;
				}
			}
			bool flag = false;
			if (ry != null && ry[0] != null)
			{
				flag = opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.CTMProbe && DateTime.Compare(ry[0].n, qq[9][0].n) != 0;
				double a_2 = ry[0].j;
				int upperBound = ry.GetUpperBound(0);
				for (int num = 1; num <= upperBound; num = checked(num + 1))
				{
					if (!m2(a_2, ry[num].j))
					{
						throw new ApplicationException("Integration times for Ref 0 and Ref " + num + " are not equal. Cannot commit pending data");
					}
				}
			}
			if (ry == null)
			{
				qh((int)opticsConfigSubmoduleTypes);
				sb = q6[(int)opticsConfigSubmoduleTypes];
			}
			else
			{
				qq[(int)opticsConfigSubmoduleTypes] = ry;
			}
			if (flag)
			{
				rq = ry[0].x() != null;
			}
			qs[(int)opticsConfigSubmoduleTypes] = rz;
			float[] a_3 = rz;
			Collection<short[]> collection;
			int index;
			short[] A_7 = (collection = qt)[index = (int)opticsConfigSubmoduleTypes];
			m2(a_3, ref A_7);
			collection[index] = A_7;
			qu[(int)opticsConfigSubmoduleTypes] = r0;
			rn = sv;
			ro = sw;
			rp = sx;
			qv[(int)opticsConfigSubmoduleTypes] = r1;
			qw[(int)opticsConfigSubmoduleTypes] = r2;
			qx[(int)opticsConfigSubmoduleTypes] = su;
			qy[(int)opticsConfigSubmoduleTypes] = sa;
			q0 = true;
			if (g2.c(opticsConfigSubmoduleTypes))
			{
				string text = "FiberTip";
				q6[(int)opticsConfigSubmoduleTypes] = text;
				qq[(int)opticsConfigSubmoduleTypes][0].o = text;
			}
			else if (A_1 && opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.ReflectanceProbe)
			{
				string text2 = ex.j(this.m_t7);
				q6[(int)opticsConfigSubmoduleTypes] = text2;
				qq[(int)opticsConfigSubmoduleTypes][0].o = text2;
				qq[(int)opticsConfigSubmoduleTypes][0].k = this.m_t5;
				qq[(int)opticsConfigSubmoduleTypes][0].m = this.m_t6;
			}
			else
			{
				q6[(int)opticsConfigSubmoduleTypes] = sb;
			}
			if (q6[(int)opticsConfigSubmoduleTypes] == null)
			{
				q6[(int)opticsConfigSubmoduleTypes] = bc();
			}
			qr[(int)opticsConfigSubmoduleTypes] = sh;
			this.m_ti = this.m_ti.j(ref r9, ref r8);
			q1 = true;
			q7[(int)opticsConfigSubmoduleTypes] = sc;
			q9[(int)opticsConfigSubmoduleTypes] = se;
			q8[(int)opticsConfigSubmoduleTypes] = sd;
			ra[(int)opticsConfigSubmoduleTypes] = sf;
			qz[(int)opticsConfigSubmoduleTypes] = sg;
			p5 = false;
			rc[(int)opticsConfigSubmoduleTypes] = r3;
			rd[(int)opticsConfigSubmoduleTypes] = r4;
			rb[(int)opticsConfigSubmoduleTypes] = r6;
			re[(int)opticsConfigSubmoduleTypes] = r5;
			rl[(int)opticsConfigSubmoduleTypes] = this.m_st;
			if (ry != null)
			{
				tc();
			}
			if (p9(A_1))
			{
				this.m_ud = sk;
				this.m_ue = sl;
				this.m_ub = si;
				this.m_uc = this.m_sj;
				this.m_uf = this.m_sm;
				this.m_ug = this.m_sn;
				this.m_uh = this.m_so;
			}
			if (p9(A_1))
			{
				te(A_1);
				this.m_vq = true;
			}
			ou = sy;
			if (!yg())
			{
				yg();
			}
			if (flag)
			{
				wy();
				if (vr())
				{
					c c10 = ry[0];
					m2(c10.n, c10.j, A_0, tk.q().t(), A_4: true, c10.x());
					c10 = null;
				}
			}
			sm(opticsConfigSubmoduleTypes);
			if (qq != null && qq[(int)opticsConfigSubmoduleTypes] != null && qq[(int)opticsConfigSubmoduleTypes][0].v() != null)
			{
				string path = yp();
				string directoryName = Path.GetDirectoryName(path);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				bool num2 = !File.Exists(path);
				c[] array = qq[(int)opticsConfigSubmoduleTypes];
				int upperBound2 = array.GetUpperBound(0);
				int[] array2;
				int upperBound3;
				checked
				{
					array2 = new int[upperBound2 + 1];
					streamWriter = new StreamWriter(path, append: true, Encoding.ASCII);
					if (num2)
					{
						io.m2(streamWriter);
					}
					index = upperBound2;
					for (int num3 = 0; num3 <= index; num3++)
					{
						array2[num3] = num3;
					}
					int num4 = upperBound2 - 1;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						int num6 = num5 + 1;
						int num7 = upperBound2;
						for (int num8 = num6; num8 <= num7; num8++)
						{
							if (DateTime.Compare(array[array2[num5]].n, array[array2[num8]].n) > 0)
							{
								int num9 = array2[num5];
								array2[num5] = array2[num8];
								array2[num8] = num9;
							}
						}
					}
					upperBound3 = array.GetUpperBound(0);
				}
				float A_10 = default(float);
				for (int num10 = 0; num10 <= upperBound3; num10 = checked(num10 + 1))
				{
					int num11 = array2[num10];
					int num12 = sj(num11, qy[(int)opticsConfigSubmoduleTypes]);
					c c11 = array[num11];
					if (t4)
					{
						int A_8 = 0;
						this.m_t9 = m2(1, num11, ref A_8, A_1, p9(A_1));
						io.m2(streamWriter, c11.n, opticsConfigSubmoduleTypes, jg.f(vp()), this.m_t9, q2[this.m_t8], 100f * this.m_ua, this.m_t5, base.m2);
					}
					else
					{
						DateTime a_4 = qy[(int)opticsConfigSubmoduleTypes];
						float A_9 = 0f;
						m2(num11, a_4, ref A_10, ref A_9);
						io.m2(streamWriter, c11.n, opticsConfigSubmoduleTypes, jg.f(vp()), A_10, q2[num12], 100f * c11.ab()[num12], c11.j, base.m2);
					}
					c11 = null;
				}
			}
			p9(A_4, A_5);
			string text3 = null;
			string text4 = null;
			if (g2.c(opticsConfigSubmoduleTypes))
			{
				text3 = jb.d() + "\\" + ex.i(ma) + ".fmrrr";
				text4 = jb.d() + "\\" + ex.k(ma) + ".fmrrr";
				if (global::c.e().FileSystem.FileExists(text3))
				{
					global::c.e().FileSystem.DeleteFile(text3);
				}
				global::c.e().FileSystem.RenameFile(text4, Path.GetFileName(text3));
			}
		}
		finally
		{
			streamWriter?.Close();
		}
	}

	public void p9(bool A_0, int A_1)
	{
		ry = null;
		r9 = false;
		sa = DateTime.MinValue;
		sb = null;
		sg = global::h.MeasurementTimingType.Manual;
		sh = false;
		rz = null;
		r0 = null;
		sc = DateTime.MinValue;
		se = 0.0;
		r8 = false;
		r1 = null;
		r2 = null;
		sd = DateTime.MinValue;
		sf = 0.0;
		su = null;
		xe();
		r3 = null;
		r4 = null;
		r5 = 0.0;
		this.m_st = null;
		sp = false;
		base.m2 = false;
		nf = false;
		ng = false;
		t4 = false;
		this.m_wd = 0.0;
		t0();
		sy = null;
		m2(A_0, A_1);
	}

	private new void m2(bool A_0, int A_1)
	{
		string[] array = ((!A_0) ? Directory.GetFiles(@is.b(), ys() + "*" + @is.e(a8())) : Directory.GetFiles(@is.b(), ys() + A_1 + @is.e(a8())));
		string[] array2 = array;
		for (int num = 0; num < array2.Length; num = checked(num + 1))
		{
			File.Delete(array2[num]);
		}
	}

	public new void m2(string A_0, bool A_1)
	{
		if (p9(A_1))
		{
			sy = null;
		}
		else
		{
			sy = A_0;
		}
	}

	public void st(int A_0)
	{
		BinaryReader binaryReader = null;
		try
		{
			string path = tj(A_0);
			if (File.Exists(path))
			{
				binaryReader = new BinaryReader(File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read));
				i3.a(binaryReader, m2, "PendingSpecData", 1);
			}
		}
		finally
		{
			binaryReader?.Close();
		}
	}

	public void s3(int A_0)
	{
		BinaryWriter binaryWriter = null;
		try
		{
			string path = tj(A_0);
			binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create));
			i3.a(binaryWriter, m2, 1, 1);
		}
		finally
		{
			binaryWriter?.Close();
		}
	}

	public new void m2(hr A_0, hr A_1)
	{
		if (this.m_ws == null || jf.e(this.m_ws.ve(), 0f) || this.m_ws.t5() == null || A_1 == null)
		{
			return;
		}
		int num = A_0.c2();
		checked
		{
			_ = num - 1;
			int num2 = A_1.c2();
			int num3 = num2 - 1;
			double[] A_2 = new double[num3 + 1];
			double[] array = new double[num3 + 1];
			double[] A_3 = A_0.cz();
			hr hr2;
			double[] A_4 = (hr2 = A_0).cv();
			hr hr3;
			double[] A_5 = (hr3 = A_1).cz();
			jf.a(ref A_3, ref A_4, num, ref A_5, ref A_2, num2);
			hr3.t(A_5);
			hr2.r(A_4);
			A_0.t(A_3);
			int num4 = num3;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				array[num5] = 1.0 + (double)this.m_ws.t5()[num5] * A_2[num5];
				if (array[num5] < 1.0)
				{
					array[num5] = 1.0;
				}
				A_1.cv()[num5] /= array[num5];
			}
		}
	}

	public new FIDeviceErr m2(ref hr A_0, ref int A_1, ref float A_2, bool A_3, bool A_4, DateTime A_5, bool A_6, bool A_7, float[] A_8, float[] A_9, float A_10, float A_11, bool A_12, Guid A_13)
	{
		return m2(ref A_0, ref A_1, ref A_2, A_3, A_4, null, null, null, null, null, A_5, A_11: false, A_6, A_7, A_8, A_9, A_10, A_11, A_12, A_13);
	}

	public new FIDeviceErr m2(ref hr A_0, ref int A_1, ref float A_2, bool A_3, bool A_4, float[] A_5, int[] A_6, int[] A_7, double[] A_8, double[] A_9, DateTime A_10, bool A_11, bool A_12, bool A_13, float[] A_14, float[] A_15, float A_16, float A_17, bool A_18, Guid A_19)
	{
		FIDeviceErr result = FIDeviceErr.None;
		short[] A_20 = null;
		try
		{
			hr hr2 = A_0;
			hr hr3;
			double[] A_21 = (hr3 = hr2).cv();
			hr hr4;
			double[] A_22 = (hr4 = A_0).cz();
			bool A_23 = false;
			double A_24 = 0.0;
			hr hr5;
			bool A_25 = (hr5 = hr2).cc();
			hr hr6;
			int A_26 = (hr6 = hr2).cd();
			hr hr7;
			int A_27 = (hr7 = hr2).ce();
			m2(ref A_21, ref A_22, ref A_2, A_3, ref A_23, ref A_24, A_4, A_5, A_6, A_7, A_8, A_9, ref A_25, ref A_26, ref A_27, A_10, A_12, A_13, A_14, A_15, A_16, A_17, A_18, A_19);
			hr7.af(A_27);
			hr6.t(A_26);
			hr5.aj(A_25);
			hr4.t(A_22);
			hr3.r(A_21);
			hr2 = null;
			rm = rm.ag();
			hp obj = rm;
			obj.q(sr);
			obj.q(sq);
			obj.q(qg);
			obj.q(A_0: true);
			obj.r(A_0: false);
			obj.s(A_0: false);
			obj.r(abh());
			obj.q(new hq());
			_ = null;
			hq obj2 = rm.q();
			obj2.h(q4);
			m2(qf, ref A_20);
			obj2.f(A_20);
			obj2.f(vp());
			obj2.f(q5);
			bool a_ = default(bool);
			obj2.g(sj(a_));
			_ = null;
			A_0.r(rm);
			A_0.r(g2.n(this.m_ti.k()));
			A_0.af(A_0.cv());
			iq a_2 = null;
			if (this.m_tj.l() && !A_11 && m2(a_2, A_4))
			{
				if (g2.m(this.m_ti.k()))
				{
					A_0.aj(hr.b.c);
				}
				else if (g2.l(this.m_ti.k()))
				{
					A_0.aj(hr.b.j);
				}
				else
				{
					if (!g2.k(this.m_ti.k()))
					{
						throw new ArgumentOutOfRangeException("Unknown optics configuration");
					}
					A_0.aj(hr.b.n);
				}
			}
			else if (g2.m(this.m_ti.k()))
			{
				if (zy())
				{
					if (this.m_tj.m())
					{
						A_0.aj(hr.b.r);
					}
					else
					{
						A_0.aj(hr.b.q);
					}
				}
				else
				{
					A_0.aj(hr.b.b);
				}
			}
			else if (g2.l(this.m_ti.k()))
			{
				A_0.aj(hr.b.k);
			}
			else
			{
				if (!g2.k(this.m_ti.k()))
				{
					throw new ArgumentOutOfRangeException("Unknown optics configuration");
				}
				A_0.aj(hr.b.o);
			}
			A_0.r(DateAndTime.Now);
			m2(A_0);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			result = FIDeviceErr.Generic;
			ab8().c(fz.b.b, "Error retrieving spectrum in USBSpectrometerDevice.RetrieveSpectrum().", a_3);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private new void m2(hr A_0)
	{
		hr hr2 = A_0;
		hr2.r(b());
		hr2.ao(abo() + ", " + uq());
		hr2.r(qn);
		hr2.r(this.m_tl);
		hr2.r(hr.a.a);
		hr2.t(0f);
		if (x9())
		{
			hr2.t((double)this.m_m2.FWWaveRangeStart);
			hr2.af(this.m_m2.FWWaveRangeEnd);
		}
		hr2 = null;
	}

	private new hr.b m2(g2.OpticsConfigSubmoduleTypes A_0)
	{
		if (g2.l(A_0))
		{
			return hr.b.k;
		}
		return hr.b.b;
	}

	public new hr m2(ew.a A_0, int A_1, DateTime A_2, eo.a A_3)
	{
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
		double[] array;
		string text;
		c c10;
		double[] a_;
		checked
		{
			array = new double[this.m_p9 - 1 + 1];
			text = string.Empty;
			c[] array2 = so(A_2);
			c10 = array2[A_1];
			float[] array3 = ((opticsConfigSubmoduleTypes != g2.OpticsConfigSubmoduleTypes.CTMProbe) ? c10.v() : ((!rq) ? c10.w() : c10.x()));
			int num = this.m_p9 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				array[num2] = array3[num2];
			}
			if (array2.Length > 1)
			{
				text = "-" + A_1;
			}
			a_ = q2;
		}
		Guid a_2 = q3[(int)opticsConfigSubmoduleTypes];
		hr.b a_3 = m2(opticsConfigSubmoduleTypes);
		FMLegacyAllSystemTypes a_4 = b();
		string a_5 = abo() + ", " + uq();
		DateTime a_6 = c10.n;
		string[] array4 = new string[6];
		string A_4 = "StandardLabel";
		array4[0] = hu.a(ref A_4);
		array4[1] = "-";
		array4[2] = g2.o(opticsConfigSubmoduleTypes);
		array4[3] = "-";
		array4[4] = global::h.a(qz[(int)opticsConfigSubmoduleTypes]);
		array4[5] = text;
		return new hr(a_, a_2, array, a_3, 0f, 1, a_4, A_0, a_5, a_6, "", string.Concat(array4), hr.a.a, 0, 0f, 0f, null, null, "", A_19: false, A_20: false, A_21: false, 0, 0, c10.q, 0, string.Empty, A_3);
	}

	public new hr m2(ew.a A_0, DateTime A_1, eo.a A_2)
	{
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
		double[] array;
		c c10;
		double[] a_;
		checked
		{
			array = new double[this.m_p9 - 1 + 1];
			c10 = so(A_1)[0];
			float[] array2 = c10.y();
			int num = this.m_p9 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				array[num2] = array2[num2];
			}
			a_ = q2;
		}
		Guid a_2 = q3[(int)opticsConfigSubmoduleTypes];
		hr.b a_3 = m2(opticsConfigSubmoduleTypes);
		FMLegacyAllSystemTypes a_4 = b();
		string a_5 = abo() + ", " + uq();
		DateTime a_6 = c10.n;
		string[] array3 = new string[5];
		string A_3 = "TransCurvedRLabel";
		array3[0] = hu.a(ref A_3);
		array3[1] = "-";
		array3[2] = g2.o(opticsConfigSubmoduleTypes);
		array3[3] = "-";
		array3[4] = global::h.a(qz[(int)opticsConfigSubmoduleTypes]);
		return new hr(a_, a_2, array, a_3, 0f, 1, a_4, A_0, a_5, a_6, "", string.Concat(array3), hr.a.a, 0, 0f, 0f, null, null, "", A_19: false, A_20: false, A_21: false, 0, 0, null, 0, string.Empty, A_2);
	}

	[SpecialName]
	public string s4(int A_0)
	{
		return @is.b() + ma + "_PendingRef" + A_0 + ".fmspe";
	}

	public new void m2(ew.a A_0, int A_1, eo.a A_2)
	{
		g2.OpticsConfigSubmoduleTypes a_ = this.m_ti.k();
		c c10 = ry[A_1];
		string a_2 = s4(A_1);
		float[] a_3 = c10.v();
		string[] array = new string[5];
		string A_3 = "StandardLabel";
		array[0] = hu.a(ref A_3);
		array[1] = "-";
		array[2] = g2.o(a_);
		array[3] = "-";
		int num = (int)sg;
		array[4] = num.ToString();
		m2(A_0, a_2, a_3, string.Concat(array), c10.n, c10.q, A_2);
		c10 = null;
	}

	public float[] s6(int A_0)
	{
		return ry[A_0].v();
	}

	public float[] xi()
	{
		return rz;
	}

	private new void m2(ew.a A_0, string A_1, float[] A_2, string A_3, DateTime A_4, ej A_5, eo.a A_6)
	{
		if (A_2 == null)
		{
			if (File.Exists(A_1))
			{
				File.Delete(A_1);
			}
			return;
		}
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
		double[] array;
		checked
		{
			int num = this.m_p9 - 1;
			array = new double[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				array[num3] = A_2[num3];
			}
		}
		hr hr2 = new hr(q2, q3[(int)opticsConfigSubmoduleTypes], array, m2(opticsConfigSubmoduleTypes), 0f, 1, b(), A_0, abo() + ", " + uq(), A_4, "", A_3, hr.a.a, 0, 0f, 0f, null, null, "", A_19: false, A_20: false, A_21: false, 0, 0, A_5, 0, string.Empty, A_6);
		hr2.k(ref A_1, hr2.bz(), hr2.by());
	}

	public new hr m2(ew.a A_0, eo.a A_1)
	{
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
		double[] array;
		double[] a_;
		checked
		{
			int num = this.m_p9 - 1;
			array = new double[num + 1];
			float[] array2 = rc[unchecked((int)opticsConfigSubmoduleTypes)];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				array[num3] = array2[num3];
			}
			a_ = q2;
		}
		Guid a_2 = q3[(int)opticsConfigSubmoduleTypes];
		hr.b a_3 = m2(opticsConfigSubmoduleTypes);
		FMLegacyAllSystemTypes a_4 = b();
		string a_5 = abo() + ", " + uq();
		DateTime a_6 = rb[(int)opticsConfigSubmoduleTypes];
		string[] array3 = new string[5];
		string A_2 = "SampleIdAbbrev";
		array3[0] = hu.a(ref A_2);
		array3[1] = "-";
		array3[2] = g2.o(opticsConfigSubmoduleTypes);
		array3[3] = "-";
		array3[4] = global::h.a(qz[(int)opticsConfigSubmoduleTypes]);
		return new hr(a_, a_2, array, a_3, 0f, 1, a_4, A_0, a_5, a_6, "", string.Concat(array3), hr.a.a, 0, 0f, 0f, null, null, "", A_19: false, A_20: false, A_21: false, 0, 0, rl[(int)opticsConfigSubmoduleTypes], 0, string.Empty, A_1);
	}

	public void p9(ew.a A_0, eo.a A_1)
	{
		g2.OpticsConfigSubmoduleTypes a_ = this.m_ti.k();
		string a_2 = xj();
		float[] a_3 = r3;
		string A_2 = "SampleIdAbbrev";
		m2(A_0, a_2, a_3, hu.a(ref A_2) + "-" + g2.o(a_), r6, this.m_st, A_1);
	}

	[SpecialName]
	public string xj()
	{
		return @is.b() + ma + "_PendingSample.fmspe";
	}

	public new void m2(ref Collection<double[]> A_0, ref Collection<DateTime[]> A_1, ref int[] A_2)
	{
		string a_ = yp();
		Collection<bool[]> A_3 = null;
		io.m2(a_, ref A_0, ref A_1, ref A_2, ref A_3);
	}

	public hr qh(ew.a A_0, eo.a A_1)
	{
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
		double[] array = new double[checked(this.m_p9 - 1 + 1)];
		float[] array2 = qs[(int)opticsConfigSubmoduleTypes];
		double[] a_;
		checked
		{
			int num = this.m_p9 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				array[num2] = array2[num2];
			}
			a_ = q2;
		}
		Guid a_2 = q3[(int)opticsConfigSubmoduleTypes];
		hr.b a_3 = m2(opticsConfigSubmoduleTypes);
		FMLegacyAllSystemTypes a_4 = b();
		string a_5 = abo() + ", " + uq();
		DateTime a_6 = q7[(int)opticsConfigSubmoduleTypes];
		string A_2 = "Background";
		return new hr(a_, a_2, array, a_3, 0f, 1, a_4, A_0, a_5, a_6, "", hu.a(ref A_2) + "-" + g2.o(opticsConfigSubmoduleTypes), hr.a.a, 0, 0f, 0f, null, null, "", A_19: false, A_20: false, A_21: false, 0, 0, qx[(int)opticsConfigSubmoduleTypes], 0, string.Empty, A_1);
	}

	public void sj(ew.a A_0, eo.a A_1)
	{
		g2.OpticsConfigSubmoduleTypes a_ = this.m_ti.k();
		string a_2 = xk();
		float[] a_3 = rz;
		string A_2 = "Background";
		m2(A_0, a_2, a_3, hu.a(ref A_2) + "-" + g2.o(a_), sc, su, A_1);
	}

	[SpecialName]
	public string xk()
	{
		return @is.b() + ma + "_PendingBac.fmspe";
	}

	public new bool m2(bool A_0, int A_1, DateTime A_2)
	{
		bool A_3 = this.m_tj.m();
		bool A_4 = this.m_tj.l();
		b obj = this.m_tj;
		bool A_5 = false;
		bool A_6 = false;
		this.m_tj = obj.j(ref A_5, ref A_6);
		t2 = new double[checked(this.m_p9 - 1 + 1)];
		t3 = (double[])qf.Clone();
		float A_7 = default(float);
		m2(ref t2, ref A_7, A_0);
		this.m_t5 = sq;
		this.m_t7 = ry[0].o;
		t4 = true;
		this.m_tj = this.m_tj.j(ref A_4, ref A_3);
		if (sp)
		{
			m2(A_1);
			p9(A_1, A_0);
			m2(A_1, A_0);
		}
		return true;
	}

	public new bool m2(DateTime A_0, bool A_1, bool A_2, bool A_3, bool A_4, bool A_5)
	{
		bool result = true;
		double[] A_6 = null;
		checked
		{
			try
			{
				bool A_7 = this.m_tj.m();
				bool A_8 = this.m_tj.l();
				string a_ = ry[0].o;
				string text = null;
				b obj = this.m_tj;
				bool A_9 = false;
				bool A_10 = false;
				this.m_tj = obj.j(ref A_9, ref A_10);
				double[] array = new double[this.m_p9 - 1 + 1];
				if (A_1 && A_3)
				{
					A_6 = new double[this.m_p9 - 1 + 1];
					int num = this.m_p9 - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						A_6[num2] = r0[num2];
					}
				}
				else
				{
					float A_11 = 0f;
					m2(ref A_6, ref A_11, A_1);
				}
				this.m_tj = this.m_tj.j(ref A_8, ref A_7);
				if (A_3)
				{
					double[] array2;
					if (A_1)
					{
						bool A_12 = default(bool);
						m2(a_, g2.j(this.m_ti.k()), ref ry, ref A_12);
						array2 = new double[this.m_p9 - 1 + 1];
						int num3 = this.m_p9 - 1;
						for (int num2 = 0; num2 <= num3; num2++)
						{
							array2[num2] = t2[num2] * sf / this.m_t5;
						}
					}
					else
					{
						A_10 = false;
						m2("BK7", ref A_10);
						this.m_t7 = "BK7";
						array2 = t2;
					}
					float[] array3 = ry[0].ab();
					int num4 = this.m_p9 - 1;
					for (int num2 = 0; num2 <= num4; num2++)
					{
						if (array2[num2] - A_6[num2] > 0.0)
						{
							array[num2] = (double)array3[num2] * (A_6[num2] / (array2[num2] - A_6[num2]));
						}
						else
						{
							array[num2] = array3[num2];
						}
					}
					text = ((!A_1) ? "FiberTipPending" : ex.j(this.m_t7));
					string a_2 = ex.f(text, ma);
					new ex(a_2, A_1: false, A_2: false, 0.0, this.m_p9, q2, array);
					if (A_1)
					{
						sb = text;
						bool A_13 = default(bool);
						m2(text, g2.j(this.m_ti.k()), ref ry, ref A_13);
					}
				}
				if (A_4)
				{
					if (!A_2 && !A_1)
					{
						A_10 = false;
						m2("FiberTipPending", ref A_10);
						text = "FiberTipPending";
					}
					r7 = 0f;
					int num5 = this.m_p9 - 1;
					for (int num2 = 0; num2 <= num5; num2++)
					{
						if ((double)r7 < A_6[num2])
						{
							r7 = (float)A_6[num2];
						}
					}
					if (A_2)
					{
						sh = p9(qf);
					}
					else
					{
						sh = p9(t2);
					}
					m2(qf, A_0, sq, qg, A_1, ref rz, ref r0, ry[0], ref sc, ref sa, ref se, ref si, ref this.m_sj, ref sk, ref sl, ref this.m_sm, ref this.m_sn, ref this.m_so);
					ry[0].l = sr;
					nf = true;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				ab8().c(fz.b.b, "Error creating Auto Reference Reference file in USBSpectrometerDevice.UseLastSpectrumToMakeAutoRefReferenceFileAndRefAndBacAndNoDark().", a_3);
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public FIDeviceErr xl()
	{
		return so(qq[(int)this.m_ti.k()][0].j);
	}

	public FIDeviceErr xm()
	{
		if (this.m_ti.s() != global::h.MeasurementTimingType.Manual)
		{
			return so(r5);
		}
		so(this.m_ti.p());
		return FIDeviceErr.None;
	}

	public FIDeviceErr qh(DateTime A_0, bool A_1)
	{
		if (this.m_ti.k() == g2.OpticsConfigSubmoduleTypes.TransCurved && rr != null)
		{
			return so(rt);
		}
		if (p9(A_0: false) && t4)
		{
			return so(this.m_t5);
		}
		if (A_1 && this.m_ti.k() == g2.OpticsConfigSubmoduleTypes.ReflectanceProbe)
		{
			return FIDeviceErr.None;
		}
		if (ry == null)
		{
			if (this.m_ti.s() != global::h.MeasurementTimingType.Manual)
			{
				c c10 = so(A_0)[0];
				iq a_ = null;
				if (!c10.u() || !m2(A_0, a_))
				{
					throw new ApplicationException("Attempt to set integration time from RefSpec when it doesn't exist");
				}
				so(c10.j);
				c10 = null;
			}
			else
			{
				so(this.m_ti.p());
			}
			return FIDeviceErr.None;
		}
		int upperBound = ry.GetUpperBound(0);
		checked
		{
			for (int num = 0; num <= upperBound; num++)
			{
				if (ry[num].u())
				{
					return so(ry[num].j);
				}
			}
			c[] array = so(A_0);
			int upperBound2 = array.GetUpperBound(0);
			for (int num2 = 0; num2 <= upperBound2; num2++)
			{
				if (array[num2].u())
				{
					return so(array[num2].j);
				}
			}
			return FIDeviceErr.None;
		}
	}

	public void xn()
	{
		this.m_vm = 0.0;
		this.m_vl = 0.0;
	}

	public void xo()
	{
		this.m_vn = false;
		this.m_wa = 0L;
	}

	public void te(bool A_0)
	{
		this.m_u7 = 0;
		this.m_uz = 0;
		if (A_0)
		{
			this.m_v8 = true;
			this.m_wa = 0L;
			this.m_wb = 0L;
			this.m_up = false;
		}
	}

	private void p9(ref int A_0)
	{
		checked
		{
			A_0++;
			if (A_0 == 2000)
			{
				A_0 = 0;
			}
		}
	}

	private new void m2(ref int A_0)
	{
		checked
		{
			A_0--;
			if (A_0 < 0)
			{
				A_0 = 1999;
			}
		}
	}

	private new void m2(double A_0)
	{
		bool flag = false;
		int num = 0;
		do
		{
			int A_1 = this.m_u8;
			m2(ref A_1);
			if (this.m_u2[A_1] > A_0)
			{
				tg();
				num = checked(num + 1);
			}
			else
			{
				flag = true;
			}
		}
		while (!flag && this.m_u7 != 0);
	}

	private void tg()
	{
		checked
		{
			if (this.m_u7 > 0)
			{
				tf();
				m2(ref this.m_u8);
				this.m_u7--;
			}
		}
	}

	private void tf()
	{
		checked
		{
			int num = this.m_p9 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				this.m_u0[num2] -= this.m_uw[num2, this.m_uy];
			}
			m2(ref this.m_uy);
			this.m_uz--;
		}
	}

	private void te()
	{
		checked
		{
			int num = this.m_p9 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				this.m_u0[num2] -= this.m_uw[num2, this.m_ux];
			}
			p9(ref this.m_ux);
			this.m_uz--;
		}
	}

	private new void m2(int A_0, int A_1, DateTime A_2, ref double[] A_3)
	{
		checked
		{
			int num = this.m_p9 - 1;
			int A_4 = A_0;
			double num2 = 0.0;
			A_3 = new double[num + 1];
			for (int num3 = 1; num3 <= A_1; num3++)
			{
				double num4 = 1.0 - Math.Min(A_2.Subtract(this.m_u1.AddMilliseconds(this.m_u2[A_4])).TotalMilliseconds / 600000.0, 1.0);
				num2 += num4;
				int num5 = num;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					A_3[num6] += num4 * this.m_uw[num6, A_4];
				}
				p9(ref A_4);
			}
			int num7 = num;
			for (int num8 = 0; num8 <= num7; num8++)
			{
				A_3[num8] /= num2;
			}
		}
	}

	private new void m2(int A_0, int A_1, ref double[] A_2)
	{
		checked
		{
			int num = this.m_p9 - 1;
			int num2 = A_1;
			double num3 = this.m_u2[A_1] - 200.0;
			while (this.m_u2[num2] > num3)
			{
				num2--;
				if (num2 < 0)
				{
					num2 += 2000;
				}
			}
			int num4 = A_1 - num2;
			if (num4 < 0)
			{
				num4 += 2000;
			}
			double num5 = this.m_u2[num2] - 500.0;
			int A_3 = num2 - 1;
			if (A_3 < 0)
			{
				A_3 += 2000;
			}
			while (this.m_u2[A_3] >= num5 && A_3 != A_0)
			{
				A_3--;
				if (A_3 < 0)
				{
					A_3 += 2000;
				}
			}
			if (A_3 == A_0)
			{
				if (this.m_u2[num2] - this.m_u2[A_3] < 500.0)
				{
					ab8().c(fz.b.b, "Software bug in AutoRefUpdateNewNotMeasSpec: insufficient spectra in buffer");
					return;
				}
			}
			else
			{
				p9(ref A_3);
			}
			int num6 = num2 - A_3;
			if (num6 < 0)
			{
				num6 += 2000;
			}
			num6++;
			A_2 = new double[num + 1];
			if (this.m_uz > 0)
			{
				if (A_3 <= num2)
				{
					if ((this.m_ux > A_3 && this.m_ux <= num2) || this.m_uy > num2 || this.m_uy < A_3)
					{
						this.m_uz = 0;
					}
					else
					{
						int num7 = ((this.m_ux <= this.m_uy) ? (A_3 - this.m_ux) : (2000 - this.m_ux + A_3));
						if (num7 + num2 - this.m_uy > num2 - A_3)
						{
							this.m_uz = 0;
						}
					}
				}
				else if (this.m_ux > A_3 || (this.m_uy > num2 && this.m_uy < A_3) || (this.m_ux > num2 && this.m_uy < A_3))
				{
					this.m_uz = 0;
				}
				else
				{
					int num8 = ((this.m_uy >= this.m_ux) ? (num2 - this.m_uy) : (2000 - this.m_uy + num2));
					if (A_3 - this.m_ux + num8 > 2000 - A_3 + num2 + 1)
					{
						this.m_uz = 0;
					}
				}
			}
			while (this.m_uz > 0 && this.m_ux != A_3)
			{
				te();
			}
			while (this.m_uz == 0 || this.m_uy != num2)
			{
				if (this.m_uz == 0)
				{
					this.m_ux = A_3;
					this.m_uy = A_3;
					int num9 = num;
					for (int num10 = 0; num10 <= num9; num10++)
					{
						this.m_u0[num10] = this.m_uw[num10, this.m_uy];
					}
				}
				else
				{
					p9(ref this.m_uy);
					int num11 = num;
					for (int num10 = 0; num10 <= num11; num10++)
					{
						this.m_u0[num10] += this.m_uw[num10, this.m_uy];
					}
				}
				this.m_uz++;
			}
			float num12 = (float)(1.0 / (double)this.m_uz);
			int num13 = num;
			for (int num10 = 0; num10 <= num13; num10++)
			{
				A_2[num10] = this.m_u0[num10] * (double)num12;
			}
		}
	}

	private new bool m2(int A_0, int A_1, ref float A_2, ref float A_3, ref bool A_4)
	{
		bool flag = false;
		int A_5 = A_0;
		double num = 0.0;
		checked
		{
			for (int num2 = 1; num2 <= A_1; num2++)
			{
				num += (double)this.m_u4[A_5];
				if (!this.m_u3[A_5])
				{
					flag = true;
				}
				p9(ref A_5);
			}
			A_2 = (float)(num / (double)A_1);
			A_3 = 0f;
			A_5 = A_0;
			for (int num2 = 1; num2 <= A_1; num2++)
			{
				float num3 = Math.Abs(this.m_u4[A_5] - A_2);
				if (A_3 < num3)
				{
					A_3 = num3;
					if (A_3 >= 0.02f)
					{
						break;
					}
				}
				p9(ref A_5);
			}
			A_4 = A_3 < 0.02f;
			if (A_4)
			{
				return !flag;
			}
			return false;
		}
	}

	private new void m2(int A_0, int A_1, float[] A_2, float A_3)
	{
		g2.OpticsConfigSubmoduleTypes a_ = this.m_ti.k();
		int A_4 = A_0;
		checked
		{
			float num5 = default(float);
			float A_7 = default(float);
			float A_8 = default(float);
			bool A_9 = default(bool);
			double A_10 = default(double);
			float A_11 = default(float);
			for (int num = 1; num <= A_1; num++)
			{
				int num2 = this.m_p9 - 1;
				double[] A_5 = new double[num2 + 1];
				double[] array = new double[num2 + 1];
				_ = new double[num2 + 1];
				if (t1)
				{
					int num3 = num2;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						A_5[num4] = this.m_uw[num4, A_4];
					}
					num5 = (float)m2(ref A_5);
					int num6 = num2;
					for (int num7 = 0; num7 <= num6; num7++)
					{
						array[num7] = A_5[num7] - (double)num5;
					}
				}
				else
				{
					int num8 = num2;
					for (int num9 = 0; num9 <= num8; num9++)
					{
						A_5[num9] = this.m_uw[num9, A_4];
						array[num9] = A_5[num9];
					}
				}
				float a_2 = A_3 / m2(array);
				double[] a_3 = A_5;
				float a_4 = num5;
				bool A_6 = false;
				m2(a_, a_3, A_2, a_4, a_2, 1f, A_6: true, ref A_7, ref A_8, ref A_6, ref A_9, ref A_10, ref A_11);
				this.m_u4[A_4] = A_11;
				p9(ref A_4);
			}
		}
	}

	private new void m2(DateTime A_0, double A_1, int A_2, int A_3, bool A_4, bool A_5, float A_6, ref int A_7, ref int A_8, ref bool A_9, ref bool A_10)
	{
		double num = 0.0;
		double num2 = 0.0;
		int num3 = 0;
		int num4 = t8();
		bool flag = false;
		bool flag2 = false;
		A_9 = false;
		A_7 = A_3;
		checked
		{
			int num5 = default(int);
			double a_ = default(double);
			double num7 = default(double);
			if (A_2 == A_3)
			{
				if (jf.d(a_, num4))
				{
					num2 += 1.0 - Math.Min(A_0.Subtract(this.m_u1.AddMilliseconds(this.m_u2[A_7])).TotalMilliseconds / 600000.0, 1.0);
					num3++;
					num5 = A_7;
				}
			}
			else
			{
				do
				{
					int num6 = A_7;
					m2(ref A_7);
					if (num6 >= 0 && num6 <= 1999 && A_7 >= 0)
					{
						_ = A_7;
						_ = 1999;
					}
					num7 = this.m_u2[num6] - this.m_u2[A_7];
					if (num7 > 1000.0)
					{
						num += num7;
					}
					a_ = this.m_u2[A_3] - this.m_u2[A_7] - num;
					if (jf.d(a_, num4))
					{
						num2 += 1.0 - Math.Min(A_0.Subtract(this.m_u1.AddMilliseconds(this.m_u2[A_7])).TotalMilliseconds / 600000.0, 1.0);
						num3++;
						num5 = A_7;
					}
					if (Math.Abs(this.m_u5[A_7] - A_6) > 1f)
					{
						flag2 = true;
					}
				}
				while (DateTime.Compare(this.m_u1.AddMilliseconds(this.m_u2[A_7]), A_0.AddMilliseconds(-600000.0)) > 0 && a_ <= 60000.0 && A_7 != A_2 && !flag2);
			}
			if (A_7 != A_2)
			{
				bool num8 = num5 == A_7;
				p9(ref A_7);
				if (num7 > 1000.0)
				{
					num -= num7;
				}
				if (num8)
				{
					num2 -= 1.0 - Math.Min(A_0.Subtract(this.m_u1.AddMilliseconds(this.m_u2[num5])).TotalMilliseconds / 600000.0, 1.0);
					num3--;
				}
			}
			A_8 = A_3 - A_7 + 1;
			if (A_8 <= 0)
			{
				A_8 += 2000;
			}
			this.m_u7 = A_8;
			int num9 = Math.Max((int)Math.Round(5000.0 / A_1), 16);
			a_ = this.m_u2[A_3] - this.m_u2[A_7] - num;
			if (A_4)
			{
				flag = true;
				A_9 = true;
			}
			else
			{
				int num10 = 4;
				int num11;
				int num12;
				int num13;
				unchecked
				{
					num11 = checked(A_8 - 16) / num10;
					num12 = 0;
					num13 = 0;
				}
				float A_11 = default(float);
				float A_12 = default(float);
				if (num11 > 0)
				{
					do
					{
						flag = m2(A_7, A_8, ref A_11, ref A_12, ref A_10);
						if (!flag && num13 < num11)
						{
							int num14 = num10;
							for (int num15 = 1; num15 <= num14; num15++)
							{
								int num6 = A_7;
								p9(ref A_7);
								num7 = this.m_u2[A_7] - this.m_u2[num6];
								if (num7 > 1000.0)
								{
									num -= num7;
								}
							}
							A_8 -= num10;
							this.m_u7 = A_8;
							num12 += num10;
						}
						num13++;
					}
					while (!flag && num13 <= num11);
				}
				else if (A_8 >= 16)
				{
					flag = m2(A_7, A_8, ref A_11, ref A_12, ref A_10);
				}
				if (flag)
				{
					A_9 = true;
				}
			}
			object obj = this.m_vk;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				this.m_vl = a_;
				this.m_vp = num9;
				if (flag)
				{
					this.m_vm = this.m_u2[A_3] - this.m_u2[A_7] - num;
					this.m_vn = true;
				}
				else
				{
					if (!this.m_vn)
					{
						this.m_vm = 0.0;
					}
					this.m_vn = false;
				}
				if (num3 > 0)
				{
					this.m_vo = Math.Min(num2 / (double)num3 * (600000.0 / (600000.0 - 0.5 * (double)num4)), 1.0);
				}
				else
				{
					this.m_vo = 0.0;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
				}
			}
		}
	}

	public new void m2(DateTime A_0, bool A_1, bool A_2, double A_3, bool A_4, float A_5, ref bool A_6, ref bool A_7)
	{
		int num = checked(this.m_p9 - 1);
		double[] A_8 = null;
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
		A_7 = false;
		DateTime now = DateAndTime.Now;
		if ((A_2 && now.Subtract(this.m_va).TotalMilliseconds < 750.0) || !m2(sq, qq[(int)opticsConfigSubmoduleTypes][0].j))
		{
			return;
		}
		this.m_v8 = false;
		this.m_v9 = !A_2;
		if (this.m_u7 == 2000 && this.m_uz > 0 && this.m_ux == this.m_u8)
		{
			te();
		}
		if (this.m_u7 == 0)
		{
			this.m_u1 = now;
		}
		int num2 = this.m_u8;
		int num3 = num;
		checked
		{
			for (int num4 = 0; num4 <= num3; num4++)
			{
				this.m_uw[num4, this.m_u8] = qm[num4];
			}
			this.m_u2[this.m_u8] = now.Subtract(this.m_u1).TotalMilliseconds;
			this.m_u4[this.m_u8] = this.m_ul;
			if (A_2)
			{
				this.m_u5[this.m_u8] = A_5;
			}
			this.m_u3[this.m_u8] = A_1;
			p9(ref this.m_u8);
			if (this.m_u7 < 2000)
			{
				this.m_u7++;
			}
			int num5 = this.m_u8 - this.m_u7;
			if (num5 < 0)
			{
				num5 += 2000;
			}
			A_6 = false;
			int A_9 = default(int);
			int A_10 = default(int);
			bool A_11 = default(bool);
			bool A_12 = default(bool);
			double num6 = default(double);
			if (A_2)
			{
				m2(now, A_3, num5, num2, A_4, A_5: true, A_5, ref A_9, ref A_10, ref A_11, ref A_12);
			}
			else
			{
				num6 = this.m_u2[num2] - this.m_u2[num5];
			}
			if ((!A_2 && num6 > 1000.0) || (A_2 && A_11))
			{
				float A_13 = default(float);
				float A_14 = default(float);
				if (!A_2)
				{
					double num7 = this.m_u2[num2] - 1000.0;
					A_9 = num5;
					while (this.m_u2[A_9] < num7)
					{
						p9(ref A_9);
					}
					A_10 = num2 - A_9 + 1;
					if (A_10 <= 0)
					{
						A_10 += 2000;
					}
					A_11 = m2(A_9, A_10, ref A_13, ref A_14, ref A_12);
				}
				if (A_11)
				{
					if (A_2)
					{
						m2(A_9, A_10, now, ref A_8);
					}
					else
					{
						m2(num5, num2, ref A_8);
					}
					double[] a_ = A_8;
					double a_2 = sq;
					float a_3 = qg;
					float[] A_15 = sm(A_0: false);
					float[] A_16 = qh(A_0: false);
					unchecked
					{
						c a_4 = qq[(int)opticsConfigSubmoduleTypes][0];
						DateTime A_17 = wk();
						m2(a_, A_0, a_2, a_3, A_2, ref A_15, ref A_16, a_4, ref A_17, ref qy[(int)opticsConfigSubmoduleTypes], ref q9[(int)opticsConfigSubmoduleTypes], ref this.m_ub, ref this.m_uc, ref this.m_ud, ref this.m_ue, ref this.m_uf, ref this.m_ug, ref this.m_uh);
						s6(A_17);
						m2(A_0: false, A_16);
						p9(A_0: false, A_15);
					}
					this.m_wa++;
					A_7 = true;
					if (A_2 && !A_4)
					{
						float[] array = null;
						array = qq[unchecked((int)opticsConfigSubmoduleTypes)][0].v();
						float a_5 = 1f;
						g2.OpticsConfigSubmoduleTypes a_6 = opticsConfigSubmoduleTypes;
						double[] a_7 = qf;
						float[] a_8 = array;
						bool A_18 = false;
						float a_9 = default(float);
						float A_19 = default(float);
						float A_20 = default(float);
						bool A_21 = default(bool);
						double A_22 = default(double);
						float A_23 = default(float);
						m2(a_6, a_7, a_8, a_9, a_5, 1f, A_6: true, ref A_19, ref A_20, ref A_18, ref A_21, ref A_22, ref A_23);
						this.m_u4[this.m_u8] = A_23;
						this.m_u3[this.m_u8] = true;
						float A_24 = default(float);
						bool flag = m2(A_9, A_10, ref A_13, ref A_24, ref A_12);
						flag = m2(A_9, A_10 + 1, ref A_13, ref A_14, ref A_12);
						if (!flag || Math.Abs(A_14 - A_24) > 0.006f)
						{
							ab8().c(fz.b.a, "Before UpdateBufferRmsIfAutoRefChanged: currConfig = " + opticsConfigSubmoduleTypes.ToString() + ", sngMaxRmsDelta = " + A_14 + ", currentSpecRmsDev = " + A_24 + ", maxDevLessThanThreshold = " + A_12 + ", haveStableSpectra = " + flag);
							m2(A_9, A_10, array, this.m_ub);
							flag = m2(A_9, A_10, ref A_13, ref A_14, ref A_12);
							ab8().c(fz.b.a, "After UpdateBufferRmsIfAutoRefChanged: currConfig = " + opticsConfigSubmoduleTypes.ToString() + ", sngMaxRmsDelta = " + A_14 + ", currentSpecRmsDev = " + A_24 + ", maxDevLessThanThreshold = " + A_12 + ", haveStableSpectra = " + flag);
						}
					}
				}
				else if (A_12)
				{
					A_6 = true;
				}
			}
			else if (!A_2 && this.m_u7 == 2000)
			{
				throw new an("AutoBaseline Buffer is full, but timespan is less than that required for stable reference spectrum");
			}
		}
	}

	public new void m2(ref float A_0)
	{
		checked
		{
			int num = this.m_p9 - 1;
			double num2 = 0.0;
			double[] array;
			if (t1)
			{
				double num3 = m2(ref qf);
				array = new double[num + 1];
				int num4 = num;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					array[num5] = qf[num5] - num3;
					if (array[num5] > num2)
					{
						num2 = array[num5];
					}
				}
			}
			else
			{
				array = qf;
				int num6 = num;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					if (array[num7] > num2)
					{
						num2 = array[num7];
					}
				}
			}
			this.m_ui = m2(array);
			A_0 = (float)num2;
		}
	}

	private new float m2(float[] A_0)
	{
		float num = 0f;
		checked
		{
			if (this.m_uf > 5)
			{
				int num2 = this.m_uf + 5;
				int num3 = this.m_uf - 5;
				int num4 = num2;
				for (int num5 = num3; num5 <= num4; num5++)
				{
					num += A_0[num5];
				}
				return num / 11f;
			}
			return 0f;
		}
	}

	private new float m2(double[] A_0)
	{
		double num = 0.0;
		checked
		{
			if (this.m_uf > 5)
			{
				int num2 = this.m_uf + 5;
				int num3 = this.m_uf - 5;
				int num4 = num2;
				for (int num5 = num3; num5 <= num4; num5++)
				{
					num += A_0[num5];
				}
				return (float)(num / 11.0);
			}
			return 0f;
		}
	}

	private new bool m2(double[] A_0, DateTime A_1, double A_2, float A_3, bool A_4, ref float[] A_5, ref float[] A_6, c A_7, ref DateTime A_8, ref DateTime A_9, ref double A_10, ref float A_11, ref float A_12, ref int A_13, ref int A_14, ref int A_15, ref float[] A_16, ref g2.OpticsConfigSubmoduleTypes A_17)
	{
		bool result = true;
		int num = checked(this.m_p9 - 1);
		float num2 = ((!t1) ? 0f : ((float)m2(ref A_0)));
		if (A_7 == qq[(int)this.m_ti.k()][0])
		{
			q0 = true;
			if (num2 != 0f && !A_4)
			{
				q1 = true;
			}
		}
		double[] array = (double[])A_0.Clone();
		p9(array, A_3);
		checked
		{
			double[] array2 = new double[num + 1];
			float num5 = default(float);
			if (num2 != 0f)
			{
				int num3 = num;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					array2[num4] = num2;
				}
				p9(array2, A_3);
				num5 = (float)array2[unchecked(num / 2)];
			}
			float num6 = 0f;
			float readoutNoiseRms = this.m_m2.ReadoutNoiseRms;
			readoutNoiseRms *= readoutNoiseRms;
			float num7 = 4095f / this.m_m2.FullWellNumElectrons;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			float[] array3 = new float[num + 1];
			float[] array4 = A_7.v();
			float[] array5 = A_7.w();
			float[] array6 = A_7.x();
			if (!A_4)
			{
				if (A_5 == null || A_5.GetUpperBound(0) != num)
				{
					A_5 = new float[num + 1];
				}
				if (A_6 == null || A_6.GetUpperBound(0) != num)
				{
					A_6 = new float[num + 1];
				}
			}
			if (array4 == null || array4.GetUpperBound(0) != num)
			{
				array4 = new float[num + 1];
			}
			if (array5 == null || array5.GetUpperBound(0) != num)
			{
				array5 = new float[num + 1];
			}
			if (array6 == null || array6.GetUpperBound(0) != num)
			{
				array6 = new float[num + 1];
			}
			A_7.u(array4);
			A_7.v(array5);
			A_7.w(array6);
			if (!A_4)
			{
				int num8 = num;
				for (int num4 = 0; num4 <= num8; num4++)
				{
					A_5[num4] = num2;
					A_6[num4] = (float)array2[num4];
				}
			}
			float[] array7 = new float[num + 1];
			int num10 = default(int);
			int num12 = default(int);
			for (int num4 = num; num4 >= 0; num4 += -1)
			{
				array4[num4] = (float)A_0[num4];
				array5[num4] = (float)array[num4];
				float num9 = (array6[num4] = (float)array[num4] - num5);
				array7[num4] = (float)A_0[num4] - num2;
				if (num6 < num9)
				{
					num6 = num9;
					num10 = num4;
				}
				if (num9 <= 0f)
				{
					num9 = 0.1f;
				}
				float num11 = (array3[num4] = (readoutNoiseRms + num9 * num7) / (num9 * num9));
				if (!flag2)
				{
					if (num11 < 0.0004f)
					{
						A_14 = num4;
						flag2 = true;
					}
					continue;
				}
				if (!flag)
				{
					if (num11 < 0.0002f)
					{
						flag = true;
					}
				}
				else if (!flag3 && num11 > 0.0004f)
				{
					A_13 = num4;
					flag3 = true;
				}
				if (num11 < 0.0004f)
				{
					num12 = num4;
				}
			}
			if (flag2)
			{
				if (!flag3)
				{
					A_13 = num12;
				}
			}
			else
			{
				A_13 = num10 - 24;
				if (A_13 < 0)
				{
					A_13 = 0;
				}
				A_14 = A_13 + 49;
				if (A_14 > num)
				{
					A_14 = num;
					A_13 = A_14 - 49;
				}
			}
			double num13 = 0.0;
			int num14 = A_13;
			int num15 = A_14;
			for (int num4 = num14; num4 <= num15; num4++)
			{
				num13 += (double)array3[num4];
			}
			num13 /= (double)(A_14 - A_13 + 1);
			A_12 = (float)Math.Sqrt(num13);
			double num16 = 0.0;
			double num17 = 0.0;
			int num18 = num - A_14 + A_13 - 1;
			if (A_13 > 0)
			{
				int num19 = A_13 - 1;
				for (int num20 = 0; num20 <= num19; num20++)
				{
					num16 += (double)array3[num20];
				}
				num16 /= (double)A_13;
			}
			if (A_14 < num)
			{
				int num21 = A_14 + 1;
				int num22 = num;
				for (int num23 = num21; num23 <= num22; num23++)
				{
					num17 += (double)array3[num23];
				}
				num17 /= (double)(num - A_14);
			}
			double num24 = ((A_13 <= 0 && A_14 >= num) ? ((num16 + num17) / 2.0) : num13);
			double num25 = default(double);
			double num26 = default(double);
			if (A_4)
			{
				if (A_13 > 0)
				{
					num25 = 0.00039999998989515007 * num24 / num16;
				}
				if (A_14 < num)
				{
					num26 = 0.00039999998989515007 * num24 / num17;
				}
			}
			else
			{
				num25 = 0.00039999998989515007;
				num26 = 0.00039999998989515007;
			}
			A_16 = new float[num18 + 1];
			int num27 = A_13 - 1;
			for (int num28 = 0; num28 <= num27; num28++)
			{
				A_16[num28] = (float)Math.Sqrt(num25 / (double)array3[num28]);
			}
			int num29 = A_13;
			int num30 = num18;
			for (int num31 = num29; num31 <= num30; num31++)
			{
				A_16[num31] = (float)Math.Sqrt(num26 / (double)array3[A_14 + 1 + num31 - A_13]);
			}
			A_17 = this.m_ti.k();
			if (num10 < 5)
			{
				num10 = 5;
			}
			else if (num10 > num - 5)
			{
				num10 = num - 5;
			}
			A_15 = num10;
			A_11 = m2(array7);
			A_7.n = DateTime.Now;
			A_9 = A_1;
			A_7.j = A_2;
			if (!A_4)
			{
				A_8 = A_7.n;
				A_10 = A_2;
			}
			this.m_up = false;
			return result;
		}
	}

	private bool p9(bool A_0)
	{
		if (this.m_ti.k() != g2.OpticsConfigSubmoduleTypes.ContactProbeHandHeldAutoRef && this.m_ti.k() != g2.OpticsConfigSubmoduleTypes.ContactStageAutoRef)
		{
			return A_0;
		}
		return true;
	}

	private double td()
	{
		return qq[(int)this.m_ti.k()][0].j / sq;
	}

	private new double m2(ref double[] A_0)
	{
		int num = 0;
		double num2 = 0.0;
		for (; (float)num <= this.m_ut; num = checked(num + 1))
		{
			num2 += A_0[num];
		}
		if (num > 0)
		{
			return num2 / (double)num;
		}
		return A_0[num];
	}

	private new void m2(float A_0, g2.OpticsConfigSubmoduleTypes A_1, ref float[] A_2, ref float A_3)
	{
		int num = checked(this.m_p9 - 1);
		if (A_0 == 0f)
		{
			A_2 = qq[(int)A_1][0].v();
		}
		else
		{
			float[] array = qq[(int)A_1][0].v();
			checked
			{
				A_2 = new float[num + 1];
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					A_2[num3] = array[num3] - A_0;
				}
			}
		}
		A_3 = this.m_ub;
	}

	private new void m2(g2.OpticsConfigSubmoduleTypes A_0, double[] A_1, float[] A_2, float A_3, float A_4, float A_5, bool A_6, ref float A_7, ref float A_8, ref bool A_9, ref bool A_10, ref double A_11, ref float A_12)
	{
		int A_13 = 0;
		checked
		{
			int num = this.m_ue - this.m_ud + 1;
			int num2 = this.m_p9 - 1;
			bool flag = A_0 == g2.OpticsConfigSubmoduleTypes.Transmittance;
			if (A_6)
			{
				if (flag)
				{
					A_7 = 0.048f;
					A_8 = 0.024f;
				}
				else
				{
					A_7 = 0.1f;
					A_8 = 0.05f;
				}
			}
			else if (g2.d(A_0))
			{
				A_7 = 0.4f;
				A_8 = 0.2f;
			}
			else
			{
				A_7 = 0.11f;
				A_8 = 0.055f;
			}
			double A_14 = default(double);
			double A_15 = default(double);
			float A_16 = default(float);
			A_10 = m2(!flag, this.m_ud, this.m_ue, A_1, A_2, A_3, A_4, A_5, ref A_13, ref A_14, ref A_15, null, 0, ref A_16);
			A_12 = (float)Math.Sqrt(A_15 / (double)num);
			A_11 = Math.Sqrt(A_14 / (double)num);
			A_9 = (double)A_13 / (double)num > 0.8999999761581421;
			if (A_9 || !A_10 || !(A_12 <= A_7))
			{
				return;
			}
			int num3 = this.m_ud;
			int num4 = num2 - this.m_ue;
			if (num3 > 30)
			{
				double A_17 = default(double);
				double A_18 = default(double);
				m2(!flag, 0, this.m_ud - 1, qf, A_2, A_3, A_4, A_5, ref A_13, ref A_17, ref A_18, this.m_ug, 0, ref A_16);
				float num5 = (float)Math.Sqrt(A_18 / (double)num3);
				if (num5 > A_12)
				{
					A_12 = num5;
				}
			}
			if (num4 > 30)
			{
				double A_19 = default(double);
				double A_20 = default(double);
				m2(!flag, this.m_ue + 1, num2, qf, A_2, A_3, A_4, A_5, ref A_13, ref A_19, ref A_20, this.m_ug, this.m_ud, ref A_16);
				float num6 = (float)Math.Sqrt(A_20 / (double)num4);
				if (num6 > A_12)
				{
					A_12 = num6;
				}
			}
		}
	}

	private new bool m2(bool A_0, float A_1, float A_2)
	{
		if (A_0)
		{
			return A_2 > A_1;
		}
		return false;
	}

	private new bool m2(bool A_0, float A_1, double A_2, float A_3)
	{
		if (A_0)
		{
			if (A_3 < A_1)
			{
				return A_2 / (double)this.m_uc < 3.0;
			}
			return false;
		}
		return true;
	}

	public new void m2(bool A_0, double A_1, bool A_2, bool A_3, bool A_4, bool A_5, float A_6, bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref float A_11, ref bool A_12)
	{
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
		float[] A_13 = null;
		checked
		{
			_ = this.m_p9 - 1;
			bool flag = false;
			A_12 = false;
			float num = ((!t1) ? 0f : ((float)m2(ref qf)));
			float A_14 = default(float);
			float num2;
			if (this.m_up)
			{
				A_13 = this.m_um[unchecked((int)opticsConfigSubmoduleTypes)];
				A_14 = this.m_un;
				num2 = (float)(sq / this.m_uo);
			}
			else
			{
				m2(num, opticsConfigSubmoduleTypes, ref A_13, ref A_14);
				num2 = (float)(1.0 / td());
			}
			float num3 = A_14 * num2 / this.m_ui;
			if (this.m_uk > 0.0)
			{
				float num4 = (float)(sq / this.m_uk) * this.m_uj;
				if (!jf.e(this.m_uj, 0.0) && Math.Abs(this.m_ui - num4) / Math.Max(this.m_ui, num4) > 0.05f)
				{
					A_12 = true;
				}
			}
			this.m_uj = this.m_ui;
			this.m_uk = sq;
			A_11 = Math.Abs(1f / num3);
			float A_15 = default(float);
			float A_16 = default(float);
			bool A_17 = default(bool);
			bool A_18 = default(bool);
			double A_19 = default(double);
			m2(opticsConfigSubmoduleTypes, qf, A_13, num, num3, num2, A_0, ref A_15, ref A_16, ref A_17, ref A_18, ref A_19, ref this.m_ul);
			if (A_17)
			{
				if (A_0 && opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.Transmittance)
				{
					A_10 = false;
					A_8 = false;
					A_9 = true;
				}
				else
				{
					A_10 = true;
					A_8 = false;
					A_9 = false;
				}
			}
			else
			{
				A_10 = false;
				DateTime now = default(DateTime);
				if (g2.d(opticsConfigSubmoduleTypes))
				{
					if (this.m_ul < 0.3f)
					{
						qo.Clear();
						qp.Clear();
					}
					else
					{
						now = DateTime.Now;
						qp.Add(now);
						qo.Add(this.m_ul);
						List<DateTime> list = qp;
						if (list.Count > 1)
						{
							while (list.Count > 2 && list[0].Subtract(now).TotalSeconds > 2.0)
							{
								list.RemoveAt(0);
							}
						}
						list = null;
					}
				}
				if (m2(A_18, A_15, this.m_ul))
				{
					A_9 = true;
					this.m_up = false;
					A_8 = false;
				}
				else if (m2(A_18, A_16, A_19, this.m_ul))
				{
					A_8 = true;
					A_9 = false;
					unchecked
					{
						if (!this.m_up)
						{
							this.m_um[(int)opticsConfigSubmoduleTypes] = A_13;
							this.m_un = this.m_ub;
							this.m_uo = qq[(int)opticsConfigSubmoduleTypes][0].j;
							this.m_up = true;
						}
					}
				}
				else
				{
					bool flag2 = default(bool);
					if (g2.d(opticsConfigSubmoduleTypes))
					{
						List<DateTime> list2 = qp;
						if (list2.Count > 1)
						{
							float num5 = default(float);
							foreach (float item in qo)
							{
								num5 += item;
							}
							float num6 = num5 / (float)list2.Count;
							if (list2[list2.Count - 1].Subtract(list2[0]).TotalSeconds > 1.0)
							{
								flag2 = true;
								for (int num7 = list2.Count - 1; num7 >= 0; num7 += -1)
								{
									if (Math.Abs(qo[num7] - num6) > 0.025f)
									{
										flag2 = false;
										break;
									}
									if (now.Subtract(list2[num7]).TotalSeconds > 1.0)
									{
										break;
									}
								}
							}
						}
						list2 = null;
					}
					A_8 = false;
					A_9 = flag2;
				}
			}
			if (A_0 && !A_7)
			{
				if (A_3 && (!A_8 || A_9) && !A_12)
				{
					if (this.m_vd && DateAndTime.Now.Subtract(this.m_vf).TotalMilliseconds > 1200.0)
					{
						A_8 = true;
						A_9 = false;
					}
					else if (!this.m_vd)
					{
						this.m_vf = DateTime.Now;
					}
					this.m_vd = true;
					this.m_ve = false;
				}
				else if ((A_4 || this.m_ve) && A_8)
				{
					DateTime now2 = DateTime.Now;
					if (A_4 || now2.Subtract(this.m_vg).TotalMilliseconds < 1200.0)
					{
						A_8 = false;
						if (!this.m_ve)
						{
							this.m_vg = DateTime.Now;
						}
						this.m_ve = true;
					}
					else
					{
						if (this.m_ve)
						{
							flag = true;
						}
						this.m_ve = false;
					}
					this.m_vd = false;
				}
				else
				{
					this.m_vd = false;
					this.m_ve = false;
				}
			}
			if (A_0)
			{
				if (this.m_vb && A_9 && !A_8)
				{
					this.m_u9 = DateAndTime.Now;
					A_12 = true;
					m2(this.m_u9.Subtract(this.m_u1).TotalMilliseconds - 750.0);
				}
				if ((this.m_vc || flag) && !A_9 && A_8)
				{
					this.m_va = DateAndTime.Now;
					A_12 = true;
				}
				this.m_vb = A_8;
				this.m_vc = A_9;
			}
			if (!A_0 || (A_8 && !A_5))
			{
				return;
			}
			if (this.m_u7 > 0)
			{
				int num8 = this.m_u8 - this.m_u7;
				if (num8 < 0)
				{
					num8 += 2000;
				}
				int A_20;
				if (this.m_u7 > 0)
				{
					A_20 = this.m_u8;
					m2(ref A_20);
				}
				else
				{
					A_20 = num8;
				}
				DateTime now3 = DateTime.Now;
				int a_ = num8;
				int a_2 = A_20;
				bool A_21 = false;
				int A_22 = default(int);
				int A_23 = default(int);
				bool A_24 = default(bool);
				m2(now3, A_1, a_, a_2, A_4: false, A_5: false, A_6, ref A_22, ref A_23, ref A_24, ref A_21);
			}
			else if (this.m_vq)
			{
				this.m_vo = Math.Max((600000.0 - DateTime.Now.Subtract(wk()).TotalMilliseconds) / 600000.0, 0.0);
			}
		}
	}

	private new bool m2(bool A_0, int A_1, int A_2, double[] A_3, float[] A_4, float A_5, float A_6, float A_7, ref int A_8, ref double A_9, ref double A_10, float[] A_11, int A_12, ref float A_13)
	{
		A_9 = 0.0;
		A_10 = 0.0;
		A_13 = 0f;
		checked
		{
			for (int num = A_1; num <= A_2; num++)
			{
				float num2 = A_4[num] * A_7;
				float num3 = (float)(A_3[num] - (double)A_5);
				float num4 = (num3 * A_6 - num2) / num2;
				A_9 += num4 * num4;
				float num5 = (num3 - num2) / num2;
				if (A_11 != null)
				{
					num5 *= A_11[A_12 + num - A_1];
				}
				A_10 += num5 * num5;
				A_13 += num5;
				if (num5 < -0.5f)
				{
					A_8++;
				}
			}
			if (A_0)
			{
				return A_13 > 0f;
			}
			return A_13 < 0f;
		}
	}

	private new void m2(ref double[] A_0, ref double[] A_1, ref float A_2, bool A_3, ref bool A_4, ref double A_5, bool A_6, float[] A_7, int[] A_8, int[] A_9, double[] A_10, double[] A_11, ref bool A_12, ref int A_13, ref int A_14, DateTime A_15, bool A_16, bool A_17, float[] A_18, float[] A_19, float A_20, float A_21, bool A_22, Guid A_23)
	{
		if (!A_22 && (this.m_s3[(int)this.m_ti.k()] != 0 || this.m_s4[(int)this.m_ti.k()] != checked(this.m_p9 - 1)))
		{
			int num = this.m_s3[(int)this.m_ti.k()];
			checked
			{
				int num2 = this.m_s4[unchecked((int)this.m_ti.k())] - num;
				if (num2 >= 0)
				{
					if (A_4)
					{
						A_1 = new double[num2 + 1];
						int num3 = num2;
						for (int num4 = 0; num4 <= num3; num4++)
						{
							A_1[num4] = (float)q2[num4 + num];
						}
					}
					else
					{
						double[] A_24 = new double[1];
						p9(ref A_24, ref A_2, A_3, A_3: false, A_6, A_7, A_8, A_9, A_10, A_11, ref A_12, ref A_13, ref A_14, A_15, A_16, A_17, A_18, A_19, A_20, A_21, A_23);
						A_0 = new double[num2 + 1];
						A_1 = new double[num2 + 1];
						int num5 = num2;
						for (int num4 = 0; num4 <= num5; num4++)
						{
							A_0[num4] = (float)A_24[num4 + num];
							A_1[num4] = (float)q2[num4 + num];
						}
					}
				}
			}
		}
		else
		{
			checked
			{
				if (!A_4)
				{
					A_0 = new double[this.m_p9 - 1 + 1];
					p9(ref A_0, ref A_2, A_3, A_3: false, A_6, A_7, A_8, A_9, A_10, A_11, ref A_12, ref A_13, ref A_14, A_15, A_16, A_17, A_18, A_19, A_20, A_21, A_23);
				}
				A_1 = new double[this.m_p9 - 1 + 1];
				int num6 = this.m_p9 - 1;
				for (int num4 = 0; num4 <= num6; num4++)
				{
					A_1[num4] = (float)q2[num4];
					A_0[num4] = (float)A_0[num4];
				}
			}
		}
		A_5 = ss;
	}

	public new FIDeviceErr m2(ref hr A_0)
	{
		FIDeviceErr result = FIDeviceErr.None;
		try
		{
			hr hr2;
			double[] A_1 = (hr2 = A_0).cv();
			hr hr3;
			double[] A_2 = (hr3 = A_0).cz();
			m2(ref A_1, ref A_2);
			hr3.t(A_2);
			hr2.r(A_1);
			A_0.af(A_0.cv());
			A_0.aj(hr.b.b);
			A_0.r(DateAndTime.Now);
			m2(A_0);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = FIDeviceErr.Generic;
			ab8().c(fz.b.b, "Error retrieving raw spectrum in USBSpectrometerDevice.RetrieveRawSpectrum().", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public new void m2(ref double[] A_0, ref double[] A_1)
	{
		checked
		{
			A_0 = new double[this.m_p9 - 1 + 1];
			A_1 = new double[this.m_p9 - 1 + 1];
			int num = this.m_p9 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				A_0[num2] = qf[num2];
				A_1[num2] = q2[num2];
			}
		}
	}

	[SpecialName]
	public Guid xp()
	{
		return q3[(int)this.m_ti.k()];
	}

	public new void m2(bool A_0, ref double[] A_1, ref int A_2, ref Guid A_3)
	{
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
		if (A_0 && (this.m_s3[(int)opticsConfigSubmoduleTypes] != 0 || this.m_s4[(int)opticsConfigSubmoduleTypes] != checked(this.m_p9 - 1)))
		{
			int num = this.m_s3[(int)opticsConfigSubmoduleTypes];
			checked
			{
				int num2 = this.m_s4[unchecked((int)opticsConfigSubmoduleTypes)] - num;
				A_2 = num2 + 1;
				if (A_2 < 0)
				{
					A_2 = 0;
				}
				else
				{
					A_1 = new double[A_2 - 1 + 1];
					int num3 = num2;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						A_1[num4] = q2[num4 + num];
					}
				}
			}
		}
		else
		{
			A_1 = q2;
			A_2 = this.m_p9;
		}
		A_3 = q3[(int)opticsConfigSubmoduleTypes];
	}

	private void tc()
	{
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
		float[] array = qu[(int)opticsConfigSubmoduleTypes];
		float[] array2 = rd[(int)opticsConfigSubmoduleTypes];
		if (qq == null || qq[(int)opticsConfigSubmoduleTypes] == null || qq[(int)opticsConfigSubmoduleTypes][0] == null)
		{
			return;
		}
		float[] array3 = qq[(int)opticsConfigSubmoduleTypes][0].ab();
		float[] array4 = qq[(int)opticsConfigSubmoduleTypes][0].x();
		int num;
		float[] array5;
		checked
		{
			num = this.m_p9 - 1;
			array5 = new float[num + 1];
		}
		if (array2 == null || array == null)
		{
			rf[(int)opticsConfigSubmoduleTypes] = null;
			rg[(int)opticsConfigSubmoduleTypes] = 0f;
			return;
		}
		int num2 = xq();
		double num3 = re[(int)opticsConfigSubmoduleTypes] / qq[(int)opticsConfigSubmoduleTypes][0].j;
		int num4 = num;
		float num6 = default(float);
		int num7 = default(int);
		for (int num5 = 0; num5 <= num4; num5 = checked(num5 + 1))
		{
			if (num6 < array2[num5])
			{
				num6 = array2[num5];
				num7 = num5;
			}
			double num8 = (double)(array[num5] - (float)num2) * num3;
			double num9 = array3[num5];
			if (num9 <= 0.0)
			{
				num9 = 1.0;
			}
			array5[num5] = (float)(((double)(r4[num5] - (float)num2) - num8) / (double)array4[num5] / num3 * num9);
		}
		rf[(int)opticsConfigSubmoduleTypes] = array5;
		rg[(int)opticsConfigSubmoduleTypes] = array5[num7];
	}

	public new float m2(double[] A_0, float[] A_1, int A_2, float A_3, int A_4)
	{
		g2.OpticsConfigSubmoduleTypes a_ = this.m_tj.k();
		float num = 1f + A_3 / 100f;
		double num2 = 0.0;
		checked
		{
			int num3 = A_2 - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				if (num2 < A_0[num4])
				{
					num2 = (float)A_0[num4];
				}
			}
			if (g2.l(a_))
			{
				return (float)num2;
			}
			int num5 = xq();
			double num6 = num2 * 0.009999999776482582;
			if (num6 < 10.0)
			{
				num6 = 10.0;
			}
			float[] array = ry[A_4].ab();
			double[] array2 = new double[A_2 - 1 + 1];
			double num7 = 0.0;
			if (A_1 != null)
			{
				int num8 = A_2 - 1;
				for (int num4 = 0; num4 <= num8; num4++)
				{
					double num9 = A_0[num4] - (double)num5;
					if (num9 > num6)
					{
						array2[num4] = num9 * (double)A_1[num4] / (double)array[num4] * (double)num + (double)num5;
						if (num7 < array2[num4])
						{
							num7 = array2[num4];
						}
					}
				}
			}
			return (float)Math.Max(num7, num2);
		}
	}

	public new void m2(bool A_0, bool A_1, ref float A_2, ref float A_3, ref float A_4, ref float A_5, ref float A_6)
	{
		A_6 = tf(A_1);
		if (A_0)
		{
			A_4 = 1f - 100f / A_6;
			A_3 = A_6 - 100f;
			A_2 = A_3 - 300f;
		}
		else
		{
			A_4 = 1f - 500f / A_6;
			A_3 = A_6 - 500f;
			A_2 = A_3 - 500f;
			if (this.m_ti.k() == g2.OpticsConfigSubmoduleTypes.CTMProbe && tk.q().t())
			{
				A_4 *= 0.1f;
				A_3 *= 0.1f;
				A_2 *= 0.1f;
			}
		}
		A_5 = A_2 - 1500f;
		if (A_5 < 1200f)
		{
			A_5 = A_2;
		}
	}

	public float st(double A_0)
	{
		if (xs() == FMUSBDeviceType.FIUSB2DeviceSpecNIR2)
		{
			return (float)(A_0 * 8.0);
		}
		return xq();
	}

	public int xq()
	{
		if (this.m_m2.HWTrueDark != 0)
		{
			return 0;
		}
		return 200;
	}

	public float tf(bool A_0)
	{
		if (A_0 && xs() == FMUSBDeviceType.FIUSB2DeviceSpecNIR2)
		{
			return 1500f;
		}
		if (this.m_m2.HWTrueDark != 0)
		{
			return 4000f;
		}
		return 4095.75f;
	}

	[SpecialName]
	public bool xr()
	{
		return abk().eControllerType == FMUSBDeviceType.FIUSB2DeviceController;
	}

	public FMUSBDeviceType xs()
	{
		return this.m_m2.eSpectromType;
	}

	public int xt()
	{
		return this.m_m2.DeviceRevLevel;
	}

	[SpecialName]
	public bool xu()
	{
		return this.m_m2.HWTrueDark != 0;
	}

	[SpecialName]
	public bool xv()
	{
		return this.m_m2.HasGPIOBits != 0;
	}

	public int tg(bool A_0)
	{
		return this.m_m2.SetGPIOBit(0 - (A_0 ? 1 : 0));
	}

	public new int m2(ref bool A_0)
	{
		int value = default(int);
		int gPIOBit = this.m_m2.GetGPIOBit(ref value);
		A_0 = value != 0;
		return gPIOBit;
	}

	public int th(bool A_0)
	{
		return this.m_m2.SetStrobeModeEnable(0 - (A_0 ? 1 : 0));
	}

	public int ti(bool A_0)
	{
		return this.m_m2.SetExtTrigEnable(0 - (A_0 ? 1 : 0));
	}

	[SpecialName]
	public bool xw()
	{
		return q2[0] < 370.0;
	}

	public void tj(bool A_0)
	{
		this.m_s6 = A_0;
	}

	public void qh(bool A_0, bool A_1)
	{
		s5 = A_0;
		s7 = A_1;
		s4();
	}

	public new int m2(ref short A_0)
	{
		return this.m_m2.CalibrateAtoDGain2(out A_0);
	}

	public int p9(ref short A_0)
	{
		return this.m_m2.CalibrateVGAGain(out A_0);
	}

	public new int m2(ref short A_0, ref short A_1, ref short A_2)
	{
		return this.m_m2.CalibrateAtoDOffset2(out A_0, out A_1, out A_2);
	}

	public int p9(ref float A_0)
	{
		return this.m_m2.CalibrateTECCircuit(out A_0);
	}

	public new void m2(ref bool A_0, ref float A_1, ref float A_2, ref bool A_3, ref float A_4)
	{
		this.m_m2.GetTECCirCalStatusInfo(out var started, out A_1, out A_2, out var detTSlopeKnown, out A_4);
		A_0 = started != 0;
		A_3 = detTSlopeKnown != 0;
	}

	[SpecialName]
	public float xx()
	{
		return this.m_m2.MaxTECSetpoint;
	}

	[SpecialName]
	public float xy()
	{
		return -40f;
	}

	public new bool m2(d A_0)
	{
		FIUsbSpectrometer fIUsbSpectrometer = this.m_m2;
		if (fIUsbSpectrometer.FWCalOffset == A_0.cb && fIUsbSpectrometer.FWCalSlope == A_0.cc && fIUsbSpectrometer.FWCalCurv == A_0.cd && fIUsbSpectrometer.FWCalThird == A_0.ce && fIUsbSpectrometer.FWCalFourth == A_0.cf && fIUsbSpectrometer.FWWaveRangeStart == A_0.cn)
		{
			return fIUsbSpectrometer.FWWaveRangeEnd != A_0.co;
		}
		return true;
	}

	public void p9(float A_0)
	{
		this.m_m2.FWScatterEfficiency = A_0;
	}

	public void qh(float A_0)
	{
		this.m_m2.FWLEDScatterLongOffset = A_0;
	}

	public new void m2(g A_0, bool A_1)
	{
		FIUsbSpectrometer fIUsbSpectrometer = this.m_m2;
		fIUsbSpectrometer.FWScatterUseLEDCalibIfAvailable = (byte)(0u - (A_1 ? 1u : 0u));
		if (jf.b(A_0.g, 0.0))
		{
			fIUsbSpectrometer.FWScatterNumberOfLEDSources = checked((byte)A_0.n());
			fIUsbSpectrometer.FWScatterNumberOfDetectedRegions = A_0.a;
			fIUsbSpectrometer.FWScatterNumberOfExtendedDetectedRegions = A_0.b;
			fIUsbSpectrometer.FWScatterNumberOfReducedWavePts = A_0.c;
			fIUsbSpectrometer.FWScatterNumberOfInterpSourcePts = A_0.d;
			fIUsbSpectrometer.FWScatterMaxCoeff = A_0.g;
			fIUsbSpectrometer.FWScatterEfficiency = A_0.h;
			fIUsbSpectrometer.FWScatterExtendedPointSpacing = A_0.e;
			fIUsbSpectrometer.FWScatterExtendedPointOffset = A_0.f;
			fIUsbSpectrometer.SetFWScatterLEDArrays(A_0.n(), A_0.b, A_0.p(), A_0.q(), A_0.r());
			fIUsbSpectrometer.FWLEDScatterLongOffset = A_0.i;
			fIUsbSpectrometer.FWWaveLengthOf2ndOrderFilterEdge = A_0.o;
		}
		fIUsbSpectrometer = null;
	}

	private new void m2(d A_0, ref string A_1, ref string A_2)
	{
		FIUsbSpectrometer fIUsbSpectrometer = this.m_m2;
		fIUsbSpectrometer.FWLastUpdate = DateTime.Now;
		fIUsbSpectrometer.FWCalOffset = A_0.cb;
		fIUsbSpectrometer.FWCalSlope = A_0.cc;
		fIUsbSpectrometer.FWCalCurv = A_0.cd;
		fIUsbSpectrometer.FWCalThird = A_0.ce;
		fIUsbSpectrometer.FWCalFourth = A_0.cf;
		fIUsbSpectrometer.FWCalTemp1 = A_0.cg;
		fIUsbSpectrometer.FWCalOffset2 = A_0.ch;
		fIUsbSpectrometer.FWCalSlope2 = A_0.ci;
		fIUsbSpectrometer.FWCalCurv2 = A_0.cj;
		fIUsbSpectrometer.FWCalThird2 = A_0.ck;
		fIUsbSpectrometer.FWCalFourth2 = A_0.cl;
		fIUsbSpectrometer.FWCalTemp2 = A_0.cm;
		fIUsbSpectrometer.FWWaveRangeStart = A_0.cn;
		fIUsbSpectrometer.FWWaveRangeEnd = A_0.co;
		fIUsbSpectrometer.FWResolution = A_0.c3;
		fIUsbSpectrometer.FWResolutionSlope = A_0.c4;
		fIUsbSpectrometer.FWResolutionRefWavelength = A_0.c5;
		fIUsbSpectrometer.FWDevSpecificRevNum = A_0.f;
		A_1 = fIUsbSpectrometer.SerialNumber;
		fIUsbSpectrometer.SerialNumber = Guid.NewGuid().ToString("N");
		fIUsbSpectrometer.FWSpectromBitPat = (byte)((1 & (byte)(0 - (A_0.cq ? 1 : 0))) | (2 & (byte)(0 - (A_0.cr ? 1 : 0))) | (4 & (byte)(0 - (A_0.cs ? 1 : 0))));
		A_2 = fIUsbSpectrometer.FriendlySN;
		if (A_0.ct)
		{
			fIUsbSpectrometer.FriendlySN = A_0.a;
			fIUsbSpectrometer.FWDCScatterShort = A_0.cu.b;
			fIUsbSpectrometer.FWDCScatterTransWaveStart = A_0.cu.d;
			fIUsbSpectrometer.FWDCScatterTransWaveEnd = A_0.cu.e;
			fIUsbSpectrometer.FWDCScatterLong = A_0.cu.c;
			checked
			{
				fIUsbSpectrometer.FWShortScatterBroadNumPts = (short)A_0.cu.h;
				fIUsbSpectrometer.FWShortScatterBroadSlopeCoeff = A_0.cu.f;
				fIUsbSpectrometer.FWShortScatterBroadInterceptCoeff = A_0.cu.g;
				fIUsbSpectrometer.FWShortScatterNarrowNumPts = (short)A_0.cu.j;
				fIUsbSpectrometer.FWShortScatterNarrowCoeff = A_0.cu.i;
				byte b10 = 0;
				do
				{
					((IFIUsbSpectrometer)fIUsbSpectrometer).set_FWSecondOrderCoeffs(b10, A_0.cu.k[b10]);
					b10 = (byte)unchecked((uint)(b10 + 1));
				}
				while (unchecked((uint)b10) <= 5u);
				if (A_0.cu.l != null || (fIUsbSpectrometer.FWSecondOrderNumPts != A_0.cu.m && A_0.cu.m == 0))
				{
					short bufferSize = 0;
					if (A_0.cu.l != null)
					{
						bufferSize = (short)A_0.cu.l.Length;
					}
					fIUsbSpectrometer.SetSecondOrderTable(A_0.cu.l, bufferSize);
				}
				fIUsbSpectrometer.FWRevNum = A_0.f;
				fIUsbSpectrometer.FWUpdateRevLevel = -unchecked(0 - (A_0.h ? 1 : 0));
				fIUsbSpectrometer.FWLinInt = A_0.cx;
				fIUsbSpectrometer.FWLinSlope = A_0.cw;
				fIUsbSpectrometer.FWLinVer = (byte)A_0.cv;
				byte b11 = 0;
				do
				{
					((IFIUsbSpectrometer)fIUsbSpectrometer).set_FWLinV2Coeff(b11, A_0.cy.a.b[b11]);
					b11 = (byte)unchecked((uint)(b11 + 1));
				}
				while (unchecked((uint)b11) <= 4u);
				((IFIUsbSpectrometer)fIUsbSpectrometer).set_FWLinCoeffTemperature((short)1, A_0.cy.a.c);
				byte b12 = 0;
				do
				{
					((IFIUsbSpectrometer)fIUsbSpectrometer).set_FWLinV2CoeffT2(b12, A_0.cy.b.b[b12]);
					b12 = (byte)unchecked((uint)(b12 + 1));
				}
				while (unchecked((uint)b12) <= 4u);
				((IFIUsbSpectrometer)fIUsbSpectrometer).set_FWLinCoeffTemperature((short)2, A_0.cy.b.c);
				fIUsbSpectrometer.SetFWAtoDGainRegisterSetting(A_0.cz);
				fIUsbSpectrometer.FWChannel0SoftwareOffset = A_0.c1;
				fIUsbSpectrometer.FWChannel1SoftwareOffset = A_0.c2;
				fIUsbSpectrometer.FWAtoDOffsetRegisterSetting = A_0.c0;
				m2(A_0.c7, A_0.c8);
			}
			fIUsbSpectrometer.TECCircuitIsCalibrated = 0 - (A_0.c9 ? 1 : 0);
			fIUsbSpectrometer.TECCircuitSupplyPotRMax = A_0.da;
			fIUsbSpectrometer.FWCalOffsetDeltaOffset = A_0.c6.z;
			fIUsbSpectrometer.NotchSharpenAmplitude = A_0.db;
			fIUsbSpectrometer.NotchSharpenInterval = A_0.dc;
			fIUsbSpectrometer.FWBaselineLinearityAmplitude = A_0.dd;
			fIUsbSpectrometer.FWBaselineLinearityAmplitudeT = A_0.de;
			fIUsbSpectrometer.FWTransCurvedCorrection = A_0.df;
		}
		fIUsbSpectrometer = null;
	}

	public void xz()
	{
		this.m_m2.SetPendingFWCalDelete();
	}

	public int p9(d A_0)
	{
		string A_1 = null;
		string A_2 = null;
		m2(A_0, ref A_1, ref A_2);
		if (!string.IsNullOrEmpty(A_0.c))
		{
			m2(null, A_0, ab8(), A_0.c, A_4: true);
		}
		int lErrCode = default(int);
		this.m_m2.WriteFirmware(ref lErrCode);
		File.WriteAllText(@is.b() + this.m_m2.SerialNumber + " Old SN.txt", "Previous Guid: " + A_1 + "\r\nPrevious SN: " + A_2, Encoding.UTF8);
		return lErrCode;
	}

	[SpecialName]
	public bool x0()
	{
		return this.m_m2.FWCalOffsetDelta != 0f;
	}

	[SpecialName]
	public bool x1()
	{
		if (ab0() && z8() && this.m_m2.FWNextCalPeakLeftWidth != 0f)
		{
			return this.m_m2.FWNextCalPeakRightWidth != 0f;
		}
		return false;
	}

	public new int m2(double[] A_0, float A_1)
	{
		if (this.m_v3)
		{
			ab8().c(fz.b.a, "Wavelength calibration update skipped due to missing file");
			return -1;
		}
		return this.m_m2.UpdateWavelenCal2(A_0, this.m_te + A_1);
	}

	public new int m2(double[] A_0, ref o A_1)
	{
		if (this.m_v3)
		{
			ab8().c(fz.b.a, "Wavelength Offset Update skipped due to missing file");
			return -1;
		}
		float calOffsetDeltaDelta = this.m_m2.CalOffsetDeltaDelta;
		int num = this.m_m2.UpdateWavelengthOffset(A_0);
		if (num == 0)
		{
			A_1 = new o();
			o obj = A_1;
			obj.a = calOffsetDeltaDelta;
			obj.b = this.m_m2.CalOffsetDeltaDelta;
			_ = null;
			if (!jf.e(this.m_m2.CalOffsetDeltaDelta, calOffsetDeltaDelta))
			{
				s4(A_0: false);
			}
			v7 = DateTime.UtcNow;
			string path = x7();
			bool flag = !File.Exists(path);
			StreamWriter streamWriter = null;
			try
			{
				streamWriter = new StreamWriter(path, append: true, Encoding.UTF8);
				if (flag)
				{
					streamWriter.WriteLine("DateTimeCode,Offset (nm),Temperature (Deg. C), DateStr");
				}
				streamWriter.WriteLine(Conversions.ToString(v7.ToLocalTime().ToOADate()) + "," + Conversions.ToString(A_1.b) + "," + qg + "," + v7.ToLocalTime().ToString("yyyy/MM/dd HH:mm:ss tt", CultureInfo.InvariantCulture));
			}
			finally
			{
				streamWriter.Close();
			}
		}
		return num;
	}

	private void tb()
	{
		this.m_te = this.m_th * (qg - this.m_m2.FWCalTemp1);
	}

	[SpecialName]
	private bool s8()
	{
		if (x1())
		{
			return this.m_m2.EnableActiveCalParams != 0;
		}
		return false;
	}

	private void s6()
	{
		tb();
		if (this.m_th != 0f && !s8())
		{
			s4(A_0: false);
		}
	}

	public void x2()
	{
		this.m_m2.DeletePendingFW();
	}

	public void p9(string A_0)
	{
		qh(A_0);
	}

	public n x3()
	{
		n obj = new n();
		obj.z = this.m_m2.FWNextCalOffsetDeltaOffset;
		obj.aa = this.m_m2.FWNextCalOffsetDelta;
		obj.ab = this.m_m2.FWNextCalPeakLeftWidth;
		obj.ac = this.m_m2.FWNextCalPeakRightWidth;
		_ = null;
		return obj;
	}

	[SpecialName]
	public bool x4()
	{
		return this.m_m2.FWCorrupt != 0;
	}

	public d x5()
	{
		d d10 = new d();
		FIUsbSpectrometer fIUsbSpectrometer = this.m_m2;
		d10.g = fIUsbSpectrometer.FWDevSpecificHighestCompatRevLev;
		d10.i = fIUsbSpectrometer.FWCorrupt != 0;
		d10.e = fIUsbSpectrometer.FWWriteEnabled != 0;
		if (d10.i)
		{
			d10.f = fIUsbSpectrometer.FWDevSpecificHighestCompatRevLev;
		}
		else
		{
			d10.f = fIUsbSpectrometer.FWDevSpecificRevNum;
		}
		d10.h = d10.i;
		d10.db = fIUsbSpectrometer.NotchSharpenAmplitude;
		d10.dc = fIUsbSpectrometer.NotchSharpenInterval;
		d10.cp = fIUsbSpectrometer.NumPixels;
		d10.dd = fIUsbSpectrometer.FWBaselineLinearityAmplitude;
		d10.de = fIUsbSpectrometer.FWBaselineLinearityAmplitudeT;
		d10.df = fIUsbSpectrometer.FWTransCurvedCorrection;
		if (d10.i)
		{
			d10.a = "None";
			d10.cc = 1f;
			d10.cy.a.b[0] = 1f;
			d10.c7 = new g();
			return d10;
		}
		d10.b = fIUsbSpectrometer.SerialNumber;
		d10.a = fIUsbSpectrometer.FriendlySN;
		d10.cb = fIUsbSpectrometer.FWCalOffset;
		d10.cc = fIUsbSpectrometer.FWCalSlope;
		d10.cd = fIUsbSpectrometer.FWCalCurv;
		d10.ce = fIUsbSpectrometer.FWCalThird;
		d10.cf = fIUsbSpectrometer.FWCalFourth;
		d10.cg = fIUsbSpectrometer.FWCalTemp1;
		d10.ch = fIUsbSpectrometer.FWCalOffset2;
		d10.ci = fIUsbSpectrometer.FWCalSlope2;
		d10.cj = fIUsbSpectrometer.FWCalCurv2;
		d10.ck = fIUsbSpectrometer.FWCalThird2;
		d10.cl = fIUsbSpectrometer.FWCalFourth2;
		d10.cm = fIUsbSpectrometer.FWCalTemp2;
		d10.cn = fIUsbSpectrometer.FWWaveRangeStart;
		d10.co = fIUsbSpectrometer.FWWaveRangeEnd;
		d10.d = fIUsbSpectrometer.FWLastUpdate;
		d10.c3 = fIUsbSpectrometer.FWResolution;
		d10.c4 = fIUsbSpectrometer.FWResolutionSlope;
		d10.c5 = fIUsbSpectrometer.FWResolutionRefWavelength;
		d10.cq = x9();
		d10.cs = yb();
		d10.cr = ya();
		d10.c8 = fIUsbSpectrometer.FWScatterUseLEDCalibIfAvailable != 0;
		d10.cu.b = fIUsbSpectrometer.FWDCScatterShort;
		d10.cu.d = fIUsbSpectrometer.FWDCScatterTransWaveStart;
		d10.cu.e = fIUsbSpectrometer.FWDCScatterTransWaveEnd;
		d10.cu.c = fIUsbSpectrometer.FWDCScatterLong;
		d10.cu.h = fIUsbSpectrometer.FWShortScatterBroadNumPts;
		d10.cu.g = fIUsbSpectrometer.FWShortScatterBroadInterceptCoeff;
		d10.cu.f = fIUsbSpectrometer.FWShortScatterBroadSlopeCoeff;
		d10.cu.j = fIUsbSpectrometer.FWShortScatterNarrowNumPts;
		d10.cu.i = fIUsbSpectrometer.FWShortScatterNarrowCoeff;
		byte b10 = 0;
		checked
		{
			do
			{
				d10.cu.k[b10] = ((IFIUsbSpectrometer)fIUsbSpectrometer).get_FWSecondOrderCoeffs(b10);
				b10 = (byte)unchecked((uint)(b10 + 1));
			}
			while (unchecked((uint)b10) <= 5u);
			d10.cu.m = fIUsbSpectrometer.FWSecondOrderNumPts;
			d10.cu.n = fIUsbSpectrometer.FWSecondOrderAvgRatio;
			d10.cv = fIUsbSpectrometer.FWLinVer;
			if (d10.cv < 1 || d10.cv > 2)
			{
				if (wr().f)
				{
					d10.cv = 2;
				}
				else
				{
					d10.cv = 1;
				}
			}
			d10.cw = fIUsbSpectrometer.FWLinSlope;
			d10.cx = fIUsbSpectrometer.FWLinInt;
			byte b11 = 0;
			do
			{
				d10.cy.a.b[b11] = ((IFIUsbSpectrometer)fIUsbSpectrometer).get_FWLinV2Coeff(b11);
				b11 = (byte)unchecked((uint)(b11 + 1));
			}
			while (unchecked((uint)b11) <= 4u);
			d10.cy.a.c = ((IFIUsbSpectrometer)fIUsbSpectrometer).get_FWLinCoeffTemperature((short)1);
			byte b12 = 0;
			do
			{
				d10.cy.b.b[b12] = ((IFIUsbSpectrometer)fIUsbSpectrometer).get_FWLinV2CoeffT2(b12);
				b12 = (byte)unchecked((uint)(b12 + 1));
			}
			while (unchecked((uint)b12) <= 4u);
			d10.cy.b.c = ((IFIUsbSpectrometer)fIUsbSpectrometer).get_FWLinCoeffTemperature((short)2);
			d10.cz = fIUsbSpectrometer.FWAtoDGainRegisterSetting;
			d10.c0 = fIUsbSpectrometer.FWAtoDOffsetRegisterSetting;
			d10.c1 = fIUsbSpectrometer.FWChannel0SoftwareOffset;
			d10.c2 = fIUsbSpectrometer.FWChannel1SoftwareOffset;
			d10.c6 = x3();
			d10.c7 = new g();
			if (jf.b(fIUsbSpectrometer.FWScatterMaxCoeff, 0.0))
			{
				d10.c7.n(fIUsbSpectrometer.FWScatterNumberOfLEDSources);
				d10.c7.a = fIUsbSpectrometer.FWScatterNumberOfDetectedRegions;
				d10.c7.b = fIUsbSpectrometer.FWScatterNumberOfExtendedDetectedRegions;
				d10.c7.c = fIUsbSpectrometer.FWScatterNumberOfReducedWavePts;
				d10.c7.d = fIUsbSpectrometer.FWScatterNumberOfInterpSourcePts;
				d10.c7.g = fIUsbSpectrometer.FWScatterMaxCoeff;
				d10.c7.h = fIUsbSpectrometer.FWScatterEfficiency;
				d10.c7.e = fIUsbSpectrometer.FWScatterExtendedPointSpacing;
				d10.c7.f = fIUsbSpectrometer.FWScatterExtendedPointOffset;
				float[] array = new float[d10.c7.n() - 1 + 1];
				float[] array2 = new float[d10.c7.n() - 1 + 1];
				ushort[] array3 = new ushort[(short)unchecked(d10.c7.n() * d10.c7.b) - 1 + 1];
				fIUsbSpectrometer.GetFWScatterLEDArrays(array, array2, array3);
				d10.c7.n(array);
				d10.c7.p(array2);
				d10.c7.n(array3);
				d10.c7.i = fIUsbSpectrometer.FWLEDScatterLongOffset;
				d10.c7.o = fIUsbSpectrometer.FWWaveLengthOf2ndOrderFilterEdge;
			}
			d10.c9 = fIUsbSpectrometer.TECCircuitIsCalibrated != 0;
			d10.da = fIUsbSpectrometer.TECCircuitSupplyPotRMax;
			fIUsbSpectrometer = null;
			return d10;
		}
	}

	public new int m2(float[] A_0, int A_1, float[] A_2, bool A_3, string A_4, float[] A_5, ref float A_6, ref float A_7, float[] A_8, float[] A_9, float[] A_10, float[] A_11)
	{
		return this.m_m2.FindPeaks3(A_0, A_1, A_2, A_3 ? 1 : 0, A_4, A_5, out A_6, out A_7, A_8, A_9, A_10, A_11);
	}

	public void qh(ref float A_0)
	{
		double num = double.MinValue;
		float num2 = float.MinValue;
		float[] array = qq[(int)this.m_ti.k()][0].v();
		checked
		{
			int num3 = this.m_p9 - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				if (qf[num4] > num)
				{
					num = qf[num4];
				}
				if (array[num4] > num2)
				{
					num2 = array[num4];
				}
			}
			A_0 = (float)num / num2;
		}
	}

	public void tl(bool A_0)
	{
		int num = w8();
		if (num == 0)
		{
			num = this.m_m2.SetLightSourceCalibLampPowerOnState(0 - (A_0 ? 1 : 0));
			if (num != 0)
			{
				throw new ai("Error attempting to set power state of gas discharge lamp. Error code=" + num);
			}
			return;
		}
		throw new ai("Error attempting to set power state of gas discharge lamp in call to CheckAndRefreshHardwareIfNeeded. Error code=" + num);
	}

	[SpecialName]
	public bool x6()
	{
		if (z8())
		{
			int lightSourceCalibLampPowerOnState = this.m_m2.GetLightSourceCalibLampPowerOnState(out var powerOn);
			if (lightSourceCalibLampPowerOnState != 0)
			{
				throw new ai("Error attempting to get power state of gas discharge lamp. Error code=" + lightSourceCalibLampPowerOnState);
			}
			return powerOn != 0;
		}
		return false;
	}

	[SpecialName]
	public string x7()
	{
		return uk() + "DeltaDeltaLog.csv";
	}

	[SpecialName]
	public bool x8()
	{
		if (abb() > 0)
		{
			return ut() == 0;
		}
		return false;
	}

	public bool x9()
	{
		if (this.m_m2.FWCorrupt == 0)
		{
			return (this.m_m2.FWSpectromBitPat & 1) != 0;
		}
		return false;
	}

	public bool ya()
	{
		if (this.m_m2.FWCorrupt == 0)
		{
			return (this.m_m2.FWSpectromBitPat & 2) != 0;
		}
		return false;
	}

	public bool yb()
	{
		if (this.m_m2.FWCorrupt == 0)
		{
			return (this.m_m2.FWSpectromBitPat & 4) != 0;
		}
		return false;
	}

	private void s4()
	{
		bool flag = false;
		if ((abk().FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF40 || abk().FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF40NSR || yc() || abk().FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF20_F40) && !s5)
		{
			if (p9(this.m_m2.eSpectromType))
			{
				flag = true;
				if (s3())
				{
					m2(g2.OpticsConfigSubmoduleTypes.MSReflectance, vu());
					m2(g2.OpticsConfigSubmoduleTypes.MSTransmittance, vu());
				}
				else
				{
					m2(g2.OpticsConfigSubmoduleTypes.MSReflectance, 400f);
					m2(g2.OpticsConfigSubmoduleTypes.MSTransmittance, 400f);
				}
				if (st())
				{
					p9(g2.OpticsConfigSubmoduleTypes.MSReflectance, vv());
					p9(g2.OpticsConfigSubmoduleTypes.MSTransmittance, vv());
				}
				else
				{
					p9(g2.OpticsConfigSubmoduleTypes.MSReflectance, 850f);
					p9(g2.OpticsConfigSubmoduleTypes.MSTransmittance, 850f);
				}
			}
			else if (s7 && vu() < 700f)
			{
				flag = true;
				m2(g2.OpticsConfigSubmoduleTypes.MSReflectance, 400f);
				m2(g2.OpticsConfigSubmoduleTypes.MSTransmittance, 400f);
				if (y4())
				{
					p9(g2.OpticsConfigSubmoduleTypes.MSReflectance, 1050f);
					p9(g2.OpticsConfigSubmoduleTypes.MSTransmittance, 1050f);
				}
				else
				{
					p9(g2.OpticsConfigSubmoduleTypes.MSReflectance, 850f);
					p9(g2.OpticsConfigSubmoduleTypes.MSTransmittance, 850f);
				}
			}
		}
		if (!flag & this.m_s8)
		{
			m2(g2.OpticsConfigSubmoduleTypes.MSReflectance, vu());
			m2(g2.OpticsConfigSubmoduleTypes.MSTransmittance, vu());
			p9(g2.OpticsConfigSubmoduleTypes.MSReflectance, vv());
			p9(g2.OpticsConfigSubmoduleTypes.MSTransmittance, vv());
		}
		this.m_s8 = flag;
		m2(g2.OpticsConfigSubmoduleTypes.TransCurved, 250f);
	}

	public bool yc()
	{
		if (abk().FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF20_F40 && t7())
		{
			return true;
		}
		if (abe())
		{
			return true;
		}
		if (a2.a.c(abk().SerialNumber, abk().FriendlySN, i7.e.i))
		{
			return true;
		}
		return false;
	}

	private bool s3()
	{
		if (y5())
		{
			return true;
		}
		return a2.a.c(abk().SerialNumber, abk().FriendlySN, i7.e.w);
	}

	private bool st()
	{
		if (y4())
		{
			return true;
		}
		return a2.a.c(abk().SerialNumber, abk().FriendlySN, i7.e.ah);
	}

	public void yd()
	{
		int num = 0;
		do
		{
			q3[num] = Guid.NewGuid();
			num = checked(num + 1);
		}
		while (num <= 10);
		double[] A_ = null;
		m2(this.m_p9, this.m_td, this.m_tc, this.m_tb, ta, s9, ref q2, ref A_);
		m2(q2, ref q4);
		m2(A_, ref q5);
	}

	public new static void m2(int A_0, float A_1, float A_2, float A_3, float A_4, float A_5, ref double[] A_6, ref double[] A_7)
	{
		checked
		{
			A_7 = new double[A_0 - 1 + 1];
			A_6 = new double[A_0 - 1 + 1];
			A_6[0] = A_1;
			if (A_4 == 0f && A_5 == 0f)
			{
				int num = A_0 - 1;
				for (int num2 = 1; num2 <= num; num2++)
				{
					A_6[num2] = A_1 + (A_2 + A_3 * (float)num2) * (float)num2;
					A_7[num2] = A_6[num2] - A_6[num2 - 1];
				}
			}
			else
			{
				int num3 = A_0 - 1;
				for (int num4 = 1; num4 <= num3; num4++)
				{
					A_6[num4] = (double)A_1 + ((double)A_2 + ((double)A_3 + ((double)A_4 + (double)A_5 * (double)num4) * (double)num4) * (double)num4) * (double)num4;
					A_7[num4] = A_6[num4] - A_6[num4 - 1];
				}
			}
			if (A_0 > 1)
			{
				A_7[0] = A_7[1];
			}
			else
			{
				A_7[0] = 0.0;
			}
		}
	}

	public void sj(ref int A_0)
	{
		checked
		{
			this.m_w1 = new int[this.m_p9 - 1 + 1];
			_ = (float)q2[this.m_p9 - 1];
			int num = this.m_p9 - 1;
			int num4 = default(int);
			for (int num2 = 0; num2 <= num; num2++)
			{
				double num3 = q2[num2] / 2.0;
				if (q2[0] > num3)
				{
					this.m_w1[num2] = -1;
					num4 = num2 + 1;
					continue;
				}
				int num5 = this.m_p9 - 1;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					if (q2[num6] > num3)
					{
						if (Math.Abs(q2[num6] - num3) > Math.Abs(q2[num6 - 1] - num3))
						{
							this.m_w1[num2] = num6 - 1;
						}
						else
						{
							this.m_w1[num2] = num6;
						}
						break;
					}
				}
			}
			if (num4 > A_0)
			{
				A_0 = num4;
			}
		}
	}

	public new void m2(double[] A_0, ref double[] A_1, ref float[] A_2, ref bool A_3)
	{
		checked
		{
			double[] array = new double[A_0.Length - 1 + 1];
			int num = A_0.Length - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				array[num2] = A_0[num2];
			}
			double num3 = q2[0] * 2.0;
			if (750.0 > num3)
			{
				num3 = 750.0;
			}
			int num4 = q2.Length - 1;
			bool flag = default(bool);
			int A_4 = default(int);
			for (int num5 = 0; num5 <= num4; num5++)
			{
				if (q2[num5] > 700.0 && !flag)
				{
					flag = true;
				}
				if (q2[num5] > num3 && array[num5] > 2.0)
				{
					A_4 = num5;
					break;
				}
			}
			sj(ref A_4);
			int num6 = q2.Length - A_4 - 1;
			double[] array2 = new double[num6 + 1];
			A_2 = new float[num6 + 1];
			double[] array3 = new double[num6 + 1];
			int num7 = A_4;
			int num8 = q2.Length - 1;
			for (int num9 = num7; num9 <= num8; num9++)
			{
				array2[num9 - A_4] = q2[num9];
				double num10 = ((!(array[num9] < 2.0)) ? array[num9] : 2.0);
				A_2[num9 - A_4] = (float)(array[this.m_w1[num9]] / num10);
				array3[num9 - A_4] = array[this.m_w1[num9]] / num10;
			}
			short a_ = 2;
			jf.a(array2, array3, num6 + 1, a_, A_1);
			if (A_1[0] + array2[num6] * (A_1[1] + array2[num6] * A_1[2]) > 200.0)
			{
				A_3 = true;
				A_1[0] = 0.0;
				A_1[1] = 0.0;
				A_1[2] = 0.0;
			}
		}
	}

	public new void m2(double[] A_0, double[] A_1, float[] A_2)
	{
		float[] array = null;
		double A_3 = 10000.0;
		checked
		{
			int num = A_0.Length - 1;
			float num2 = 900f;
			float num3 = 0.02f;
			float num4 = (0.12f - num3) / 100f;
			float num5 = 0f;
			float num6 = ((float)Math.PI * 2f - num5) / 100f;
			float num7 = 50000f;
			float num8 = (100000f - num7) / 100f;
			int num9 = num;
			int num11 = default(int);
			for (int num10 = 0; num10 <= num9; num10++)
			{
				if (q2[num10] > (double)num2)
				{
					num11 = num10;
					break;
				}
			}
			float[] array2 = new float[num - num11 + 1];
			array = new float[num - num11 + 1];
			float[] array3 = new float[num - num11 + 1];
			int num12 = num11;
			int num13 = num;
			for (int num14 = num12; num14 <= num13; num14++)
			{
				array3[num14 - num11] = (float)(A_1[0] + (A_1[1] + A_1[2] * q2[num14]) * q2[num14]);
			}
			int num15 = 0;
			do
			{
				float num16 = num5 + (float)num15 * num6;
				int num17 = 0;
				do
				{
					float num18 = num7 + (float)num17 * num8;
					int num19 = num11;
					int num20 = num;
					for (int num21 = num19; num21 <= num20; num21++)
					{
						array[num21 - num11] = (float)Math.Sin((double)num16 + (double)num18 / q2[num21]);
					}
					int num22 = 0;
					do
					{
						float num23 = num3 + (float)num22 * num4;
						int num24 = num11;
						int num25 = num;
						for (int num26 = num24; num26 <= num25; num26++)
						{
							array2[num26 - num11] = (float)A_0[num26];
						}
						int num27 = num11;
						int num28 = num;
						for (int num29 = num27; num29 <= num28; num29++)
						{
							int num30 = num29 - num11;
							array2[num30] -= (float)(A_0[this.m_w1[num29]] / (double)(array3[num30] * (1f + num23 * array[num30])));
						}
						m2(array2, num23, num16, num18, ref A_3, A_2);
						num22++;
					}
					while (num22 <= 100);
					num17++;
				}
				while (num17 <= 100);
				num15++;
			}
			while (num15 <= 100);
		}
	}

	public new void m2(float[] A_0, float A_1, float A_2, float A_3, ref double A_4, float[] A_5)
	{
		checked
		{
			int num = A_0.Length - 1;
			double num3 = default(double);
			for (int num2 = 0; num2 <= num; num2++)
			{
				num3 += (double)(A_0[num2] * A_0[num2]);
			}
			if (A_4 > num3)
			{
				A_4 = num3;
				A_5[0] = A_1;
				A_5[1] = A_2;
				A_5[2] = A_3;
			}
		}
	}

	private void so()
	{
		if (this.m_m2.FWScatterUseLEDCalibIfAvailable != 0 && jf.a(this.m_m2.FWScatterMaxCoeff, 0f))
		{
			this.m_uu = jf.a(ref q2, this.m_p9, this.m_m2.ScatterLEDTransWaveStart);
			this.m_uv = jf.a(ref q2, this.m_p9, this.m_m2.ScatterLEDTransWaveEnd, this.m_uu);
		}
		else
		{
			this.m_uu = jf.a(ref q2, this.m_p9, this.m_m2.FWDCScatterTransWaveStart);
			this.m_uv = jf.a(ref q2, this.m_p9, this.m_m2.FWDCScatterTransWaveEnd, this.m_uu);
		}
		checked
		{
			if (this.m_uv == this.m_uu)
			{
				this.m_uv++;
			}
		}
	}

	public override io.a bb()
	{
		return m2;
	}

	public new static string m2(fz A_0, string A_1, g2.OpticsConfigSubmoduleTypes A_2)
	{
		BinaryReader binaryReader = null;
		string result = "";
		try
		{
			binaryReader = new BinaryReader(File.Open(A_1, FileMode.Open, FileAccess.Read, FileShare.Read));
			int num = binaryReader.ReadInt32();
			int num2 = binaryReader.ReadInt32();
			if (num2 >= 6 && num2 <= 21)
			{
				int num3 = ((num <= 10) ? 8 : binaryReader.ReadInt32());
				binaryReader.ReadInt32();
				int num4 = num3;
				for (int num5 = 0; num5 <= num4; num5 = checked(num5 + 1))
				{
					result = binaryReader.ReadString();
					if (num5 == (int)A_2)
					{
						break;
					}
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			A_0.c(fz.b.b, "Exception caught in USBSpectrometerDevice.ReadRefMatFromSettingsFile(). Exception is: ", a_);
			ProjectData.ClearProjectError();
		}
		finally
		{
			binaryReader?.Close();
		}
		return result;
	}

	private new void m2(string A_0, string A_1, ref bool A_2, ref bool A_3)
	{
		BinaryReader binaryReader = null;
		bool flag = default(bool);
		try
		{
			A_3 = false;
			if (this.m_m2 == null)
			{
				return;
			}
			bool A_4 = false;
			bool A_5 = false;
			string text = m2(A_0, A_1, this.m_ti.k(), bb(), ref A_4, ref A_5);
			if (A_4 || A_5)
			{
				if (Operators.CompareString(p4, text, TextCompare: false) == 0)
				{
					A_2 = true;
					return;
				}
				A_2 = false;
				binaryReader = new BinaryReader(File.Open(text, FileMode.Open, FileAccess.Read, FileShare.Read));
				int num = binaryReader.ReadInt32();
				if (binaryReader.ReadInt32() > 21)
				{
					qh();
					return;
				}
				checked
				{
					int num2 = ((num <= 10) ? 8 : (binaryReader.ReadInt32() - 1));
					int num3 = binaryReader.ReadInt32();
					if (num >= 6)
					{
						int num4 = num2;
						for (int num5 = 0; num5 <= num4; num5++)
						{
							q6[num5] = binaryReader.ReadString();
						}
					}
					int[] array = new int[qq.Count - 1 + 1];
					if (num >= 7)
					{
						int num6 = num2;
						for (int num7 = 0; num7 <= num6; num7++)
						{
							array[num7] = binaryReader.ReadInt32();
						}
					}
					bool[] array2 = new bool[qq.Count - 1 + 1];
					int num8 = num2;
					for (int num9 = 0; num9 <= num8; num9++)
					{
						array2[num9] = binaryReader.ReadBoolean();
					}
					bool[] A_6 = new bool[this.m_ti.n().Length - 1 + 1];
					int num10 = num2;
					for (int num11 = 0; num11 <= num10; num11++)
					{
						A_6[num11] = binaryReader.ReadBoolean();
					}
					int num12 = num2;
					for (int num13 = 0; num13 <= num12; num13++)
					{
						c[] array3 = new c[array[num13] + 1];
						int num14 = array[num13];
						for (int num15 = 0; num15 <= num14; num15++)
						{
							array3[num15] = new c();
						}
						long ticks = binaryReader.ReadInt64();
						array3[0].n = new DateTime(ticks);
						qq[num13] = array3;
					}
					int num16 = num2;
					for (int num17 = 0; num17 <= num16; num17++)
					{
						float[] array4 = null;
						if (num < 7 || array2[num17])
						{
							array4 = new float[this.m_p9 - 1 + 1];
							int num18 = this.m_p9 - 1;
							for (int num19 = 0; num19 <= num18; num19++)
							{
								array4[num19] = binaryReader.ReadSingle();
							}
						}
						qq[num17][0].u(array4);
					}
					int num20 = num2;
					for (int num21 = 0; num21 <= num20; num21++)
					{
						float[] array4 = null;
						if (num < 7 || array2[num21])
						{
							array4 = new float[this.m_p9 - 1 + 1];
							int num22 = this.m_p9 - 1;
							for (int num23 = 0; num23 <= num22; num23++)
							{
								array4[num23] = binaryReader.ReadSingle();
							}
						}
						qq[num21][0].v(array4);
					}
					if (num >= 13)
					{
						array2 = new bool[qs.Count - 1 + 1];
						int num24 = num2;
						for (int num25 = 0; num25 <= num24; num25++)
						{
							array2[num25] = binaryReader.ReadBoolean();
						}
					}
					int num26 = num2;
					for (int num27 = 0; num27 <= num26; num27++)
					{
						float[] array4 = null;
						if (num < 7 || array2[num27])
						{
							array4 = new float[this.m_p9 - 1 + 1];
							int num28 = this.m_p9 - 1;
							for (int num29 = 0; num29 <= num28; num29++)
							{
								array4[num29] = binaryReader.ReadSingle();
							}
						}
						qq[num27][0].w(array4);
					}
					int num30 = num2;
					for (int num31 = 0; num31 <= num30; num31++)
					{
						qq[num31][0].j = binaryReader.ReadDouble();
					}
					if (num <= 5)
					{
						int num32 = num2;
						for (int num33 = 0; num33 <= num32; num33++)
						{
							q6[num33] = binaryReader.ReadString();
						}
						flag = true;
					}
					array2 = new bool[qs.Count - 1 + 1];
					int num34 = num2;
					for (int num35 = 0; num35 <= num34; num35++)
					{
						array2[num35] = binaryReader.ReadBoolean();
					}
					bool[] A_7 = new bool[this.m_ti.o().Length - 1 + 1];
					int num36 = num2;
					for (int num37 = 0; num37 <= num36; num37++)
					{
						A_7[num37] = binaryReader.ReadBoolean();
					}
					this.m_ti = this.m_ti.j(ref A_6, ref A_7);
					int num38 = num2;
					for (int num39 = 0; num39 <= num38; num39++)
					{
						q7[num39] = new DateTime(binaryReader.ReadInt64());
					}
					int num40 = num2;
					int index;
					for (int num41 = 0; num41 <= num40; num41++)
					{
						float[] array4 = null;
						if (num < 7 || array2[num41])
						{
							array4 = new float[this.m_p9 - 1 + 1];
							int num42 = this.m_p9 - 1;
							for (int num43 = 0; num43 <= num42; num43++)
							{
								array4[num43] = binaryReader.ReadSingle();
							}
						}
						qs[num41] = array4;
						if (array4 != null)
						{
							float[] a_ = array4;
							Collection<short[]> collection;
							short[] A_8 = (collection = qt)[index = num41];
							m2(a_, ref A_8);
							collection[index] = A_8;
						}
						else
						{
							qt[num41] = null;
						}
					}
					index = num2;
					for (int num44 = 0; num44 <= index; num44++)
					{
						float[] array4 = null;
						if (num < 7 || array2[num44])
						{
							array4 = new float[this.m_p9 - 1 + 1];
							int num45 = this.m_p9 - 1;
							for (int num46 = 0; num46 <= num45; num46++)
							{
								array4[num46] = binaryReader.ReadSingle();
							}
						}
						qu[num44] = array4;
					}
					int num47 = num2;
					for (int num48 = 0; num48 <= num47; num48++)
					{
						q9[num48] = binaryReader.ReadDouble();
					}
					if (num > 7)
					{
						int num49 = num2;
						for (int num50 = 0; num50 <= num49; num50++)
						{
							if (binaryReader.ReadBoolean())
							{
								if (qx[num50] == null)
								{
									qx[num50] = new ej();
								}
								qx[num50].b(binaryReader);
							}
							else
							{
								qx[num50] = null;
							}
						}
					}
					int num51 = num2;
					for (int num52 = 0; num52 <= num51; num52++)
					{
						qy[num52] = new DateTime(binaryReader.ReadInt64());
					}
					array2 = new bool[rf.Count - 1 + 1];
					int num53 = num2;
					for (int num54 = 0; num54 <= num53; num54++)
					{
						array2[num54] = binaryReader.ReadBoolean();
					}
					int num55 = num2;
					for (int num56 = 0; num56 <= num55; num56++)
					{
						float[] array4 = null;
						if (num < 7 || array2[num56])
						{
							array4 = new float[this.m_p9 - 1 + 1];
							int num57 = this.m_p9 - 1;
							for (int num58 = 0; num58 <= num57; num58++)
							{
								array4[num58] = binaryReader.ReadSingle();
							}
						}
						rf[num56] = array4;
					}
					int num59 = num2;
					for (int num60 = 0; num60 <= num59; num60++)
					{
						rg[num60] = binaryReader.ReadSingle();
					}
					if (num > 7)
					{
						int num61 = num2;
						for (int num62 = 0; num62 <= num61; num62++)
						{
							if (binaryReader.ReadBoolean())
							{
								if (rl[num62] == null)
								{
									rl[num62] = new ej();
								}
								rl[num62].b(binaryReader);
							}
							else
							{
								rl[num62] = null;
							}
						}
					}
					int num63 = num2;
					for (int num64 = 0; num64 <= num63; num64++)
					{
						qz[num64] = unchecked((global::h.MeasurementTimingType)binaryReader.ReadInt32());
					}
					int num65 = num2;
					for (int num66 = 0; num66 <= num65; num66++)
					{
						qq[num66][0].p = binaryReader.ReadBoolean();
					}
					if (num >= 2)
					{
						this.m_ub = binaryReader.ReadSingle();
						this.m_uc = binaryReader.ReadSingle();
						this.m_ud = binaryReader.ReadInt32();
						this.m_ue = binaryReader.ReadInt32();
						this.m_uf = binaryReader.ReadInt32();
					}
					if (num >= 5)
					{
						int num67 = num2;
						for (int num68 = 0; num68 <= num67; num68++)
						{
							qr[num68] = binaryReader.ReadBoolean();
						}
					}
					else
					{
						qr = new bool[11];
					}
					if (num >= 7)
					{
						int num69 = num2;
						for (int num70 = 0; num70 <= num69; num70++)
						{
							long ticks = binaryReader.ReadInt64();
							q8[num70] = new DateTime(ticks);
							bool flag2 = binaryReader.ReadBoolean();
							float[] array4 = null;
							if (flag2)
							{
								array4 = new float[this.m_p9 - 1 + 1];
								int num71 = this.m_p9 - 1;
								for (int num72 = 0; num72 <= num71; num72++)
								{
									array4[num72] = binaryReader.ReadSingle();
								}
							}
							qv[num70] = array4;
							array4 = null;
							if (flag2)
							{
								array4 = new float[this.m_p9 - 1 + 1];
								int num73 = this.m_p9 - 1;
								for (int num74 = 0; num74 <= num73; num74++)
								{
									array4[num74] = binaryReader.ReadSingle();
								}
							}
							qw[num70] = array4;
							if (flag2)
							{
								ra[num70] = binaryReader.ReadDouble();
							}
							else
							{
								ra[num70] = 0.0;
							}
							int num75 = array[num70];
							for (int num76 = 1; num76 <= num75; num76++)
							{
								c c10 = qq[num70][num76];
								flag2 = binaryReader.ReadBoolean();
								ticks = binaryReader.ReadInt64();
								c10.n = new DateTime(ticks);
								array4 = null;
								if (flag2)
								{
									array4 = new float[this.m_p9 - 1 + 1];
									int num77 = this.m_p9 - 1;
									for (int num78 = 0; num78 <= num77; num78++)
									{
										array4[num78] = binaryReader.ReadSingle();
									}
								}
								c10.u(array4);
								array4 = null;
								if (flag2)
								{
									array4 = new float[this.m_p9 - 1 + 1];
									int num79 = this.m_p9 - 1;
									for (int num80 = 0; num80 <= num79; num80++)
									{
										array4[num80] = binaryReader.ReadSingle();
									}
								}
								c10.v(array4);
								array4 = null;
								if (flag2)
								{
									array4 = new float[this.m_p9 - 1 + 1];
									int num81 = this.m_p9 - 1;
									for (int num82 = 0; num82 <= num81; num82++)
									{
										array4[num82] = binaryReader.ReadSingle();
									}
								}
								c10.w(array4);
								if (flag2)
								{
									c10.j = binaryReader.ReadDouble();
									c10.p = binaryReader.ReadBoolean();
								}
								else
								{
									c10.j = 0.0;
									c10.p = false;
								}
							}
							if (num >= 8)
							{
								int num83 = array[num70];
								for (int num84 = 0; num84 <= num83; num84++)
								{
									if (binaryReader.ReadBoolean())
									{
										c c11 = qq[num70][num84];
										if (c11.q == null)
										{
											c11.q = new ej();
										}
										c11.q.b(binaryReader);
										c11 = null;
									}
									else
									{
										qq[num70][num84].q = null;
									}
								}
							}
							if (num < 9)
							{
								continue;
							}
							ticks = binaryReader.ReadInt64();
							rb[num70] = new DateTime(ticks);
							flag2 = binaryReader.ReadBoolean();
							array4 = null;
							if (flag2)
							{
								array4 = new float[this.m_p9 - 1 + 1];
								int num85 = this.m_p9 - 1;
								for (int num86 = 0; num86 <= num85; num86++)
								{
									array4[num86] = binaryReader.ReadSingle();
								}
							}
							rc[num70] = array4;
							array4 = null;
							if (flag2)
							{
								array4 = new float[this.m_p9 - 1 + 1];
								int num87 = this.m_p9 - 1;
								for (int num88 = 0; num88 <= num87; num88++)
								{
									array4[num88] = binaryReader.ReadSingle();
								}
								re[num70] = binaryReader.ReadDouble();
							}
							rd[num70] = array4;
						}
					}
					if (num >= 12)
					{
						xc();
						if (binaryReader.ReadBoolean())
						{
							int num89 = binaryReader.ReadInt32() - 1;
							int num90 = num89;
							for (int num91 = 0; num91 <= num90; num91++)
							{
								rp.Add(binaryReader.ReadDouble());
							}
							int num92 = num89;
							for (int num91 = 0; num91 <= num92; num91++)
							{
								float[] array4 = null;
								array4 = new float[this.m_p9 - 1 + 1];
								int num93 = this.m_p9 - 1;
								for (int num94 = 0; num94 <= num93; num94++)
								{
									array4[num94] = binaryReader.ReadSingle();
								}
								rn.Add(array4);
							}
							int num95 = num89;
							for (int num91 = 0; num91 <= num95; num91++)
							{
								float[] array4 = null;
								array4 = new float[this.m_p9 - 1 + 1];
								int num96 = this.m_p9 - 1;
								for (int num97 = 0; num97 <= num96; num97++)
								{
									array4[num97] = binaryReader.ReadSingle();
								}
								ro.Add(array4);
							}
						}
					}
					if (num >= 14)
					{
						rq = binaryReader.ReadBoolean();
					}
					if (num >= 15)
					{
						num3 = binaryReader.ReadInt32();
						this.m_uh = unchecked((g2.OpticsConfigSubmoduleTypes)num3);
						int num98 = binaryReader.ReadInt32();
						if (num98 >= 0)
						{
							this.m_ug = new float[num98 + 1];
							int num99 = num98;
							for (int num100 = 0; num100 <= num99; num100++)
							{
								this.m_ug[num100] = binaryReader.ReadSingle();
							}
						}
						else
						{
							this.m_ug = null;
						}
					}
					else
					{
						this.m_ug = null;
					}
					if (num >= 16)
					{
						int num101 = num2;
						for (int num102 = 0; num102 <= num101; num102++)
						{
							int num103 = array[num102];
							for (int num104 = 0; num104 <= num103; num104++)
							{
								qq[num102][num104].l = binaryReader.ReadInt32();
							}
						}
					}
					else
					{
						int num105 = num2;
						for (int num106 = 0; num106 <= num105; num106++)
						{
							int num107 = array[num106];
							for (int num108 = 0; num108 <= num107; num108++)
							{
								qq[num106][num108].l = -1;
							}
						}
					}
					if (num >= 17 && binaryReader.ReadBoolean())
					{
						A_3 = true;
						this.m_u1 = DateTime.FromOADate(binaryReader.ReadDouble());
						this.m_u8 = binaryReader.ReadInt32();
						this.m_u7 = binaryReader.ReadInt32();
						int A_9 = this.m_u8;
						int num109 = this.m_u7;
						for (int num110 = 1; num110 <= num109; num110++)
						{
							m2(ref A_9);
							this.m_u2[A_9] = binaryReader.ReadDouble();
							this.m_u4[A_9] = binaryReader.ReadSingle();
							this.m_u3[A_9] = binaryReader.ReadBoolean();
							int num111 = this.m_p9 - 1;
							for (int num112 = 0; num112 <= num111; num112++)
							{
								this.m_uw[num112, A_9] = binaryReader.ReadDouble();
							}
						}
						this.m_v8 = true;
					}
					if (num >= 18 && A_3)
					{
						int A_10 = this.m_u8;
						int num113 = this.m_u7;
						for (int num114 = 1; num114 <= num113; num114++)
						{
							m2(ref A_10);
							this.m_u5[A_10] = binaryReader.ReadSingle();
						}
					}
					if (num >= 19)
					{
						this.m_we = binaryReader.ReadDouble();
					}
					else
					{
						this.m_we = 0.0;
					}
					if (num >= 20)
					{
						int num115 = num2;
						for (int num116 = 0; num116 <= num115; num116++)
						{
							int num117 = array[num116];
							for (int num118 = 0; num118 <= num117; num118++)
							{
								qq[num116][num118].k = binaryReader.ReadDouble();
								qq[num116][num118].m = binaryReader.ReadInt32();
							}
						}
					}
					else
					{
						int num119 = num2;
						for (int num120 = 0; num120 <= num119; num120++)
						{
							int num121 = array[num120];
							for (int num122 = 0; num122 <= num121; num122++)
							{
								qq[num120][num122].k = qq[num120][num122].j;
								qq[num120][num122].m = qq[num120][num122].l;
							}
						}
					}
					for (int num123 = num2 + 1; num123 <= 10; num123++)
					{
						p9(num123);
					}
					c c12 = qq[10][0];
					if (num >= 21)
					{
						c12.s = binaryReader.ReadBoolean();
						if (c12.s)
						{
							c12.r = binaryReader.ReadBoolean();
							c obj = c12;
							float[] A_11 = obj.y();
							i3.a(ref A_11, binaryReader);
							obj.x(A_11);
							c obj2 = c12;
							A_11 = obj2.z();
							i3.a(ref A_11, binaryReader);
							obj2.y(A_11);
							c obj3 = c12;
							A_11 = obj3.aa();
							i3.a(ref A_11, binaryReader);
							obj3.z(A_11);
						}
						else
						{
							sj();
						}
					}
					else
					{
						sj();
					}
					c12 = null;
					p4 = text;
					ou = A_0;
				}
			}
			else
			{
				A_2 = false;
				p4 = text;
				ou = A_0;
				qh();
				q6[(int)this.m_ti.k()] = A_1;
				flag = true;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			ab8().c(fz.b.b, "Exception caught in USBSpectrometerDevice.ReadSettingsFile(). Exception is: ", a_2);
			qh();
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (binaryReader != null)
			{
				binaryReader.Close();
				q1 = true;
				q0 = true;
				p5 = false;
			}
			if (flag)
			{
				yg();
			}
		}
	}

	[SpecialName]
	private string sn()
	{
		return @is.b() + "SpecAll_" + ma + ".fisda";
	}

	private void sm()
	{
		BinaryReader binaryReader = null;
		try
		{
			string path = sn();
			if (File.Exists(path))
			{
				binaryReader = new BinaryReader(File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read));
				binaryReader.ReadInt32();
				if (binaryReader.ReadInt32() <= 21)
				{
					this.m_wg = binaryReader.ReadBoolean();
					this.m_wh = binaryReader.ReadSingle();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ab8().c(fz.b.b, "Error in USBSpectrometerDevice.ReadAllRefMatsSettingsFile", a_);
			ProjectData.ClearProjectError();
		}
		finally
		{
			binaryReader?.Close();
		}
	}

	public bool ye()
	{
		return this.m_wf;
	}

	public void yf()
	{
		string A_ = null;
		if (m2(ref A_))
		{
			File.Delete(A_);
		}
		this.m_wc = null;
		this.m_wf = false;
		this.m_we = 0.0;
	}

	private new bool m2(ref string A_0)
	{
		A_0 = yr();
		return File.Exists(A_0);
	}

	private new void m2(BinaryReader A_0, int A_1)
	{
		BinaryReader binaryReader = A_0;
		i3.a(ref r3, A_0);
		i3.a(ref r4, A_0);
		r5 = binaryReader.ReadDouble();
		r6 = new DateTime(binaryReader.ReadInt64());
		this.m_st = ej.a(A_0);
		checked
		{
			if (binaryReader.ReadBoolean())
			{
				ry = new c[binaryReader.ReadInt32() - 1 + 1];
				int num = ry.Length - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					ry[num2] = c.u(A_0);
				}
			}
			else
			{
				ry = null;
			}
		}
		sg = (global::h.MeasurementTimingType)binaryReader.ReadInt32();
		sh = binaryReader.ReadBoolean();
		sa = new DateTime(binaryReader.ReadInt64());
		sb = binaryReader.ReadString();
		r9 = binaryReader.ReadBoolean();
		sp = binaryReader.ReadBoolean();
		r7 = binaryReader.ReadSingle();
		si = binaryReader.ReadSingle();
		this.m_sj = binaryReader.ReadSingle();
		sk = binaryReader.ReadInt32();
		sl = binaryReader.ReadInt32();
		this.m_sm = binaryReader.ReadInt32();
		i3.a(ref this.m_sn, A_0);
		this.m_so = (g2.OpticsConfigSubmoduleTypes)binaryReader.ReadInt32();
		i3.a(ref rz, A_0);
		i3.a(ref r0, A_0);
		se = binaryReader.ReadDouble();
		sc = new DateTime(binaryReader.ReadInt64());
		r8 = binaryReader.ReadBoolean();
		su = ej.a(A_0);
		i3.a(ref r1, A_0);
		i3.a(ref r2, A_0);
		sf = binaryReader.ReadDouble();
		sd = new DateTime(binaryReader.ReadInt64());
		i3.a(ref rr, A_0);
		rs = binaryReader.ReadSingle();
		rt = binaryReader.ReadDouble();
		ru = ej.a(A_0);
		i3.a(ref rv, A_0);
		rw = binaryReader.ReadSingle();
		rx = binaryReader.ReadDouble();
		i3.a(ref sv, A_0);
		i3.a(ref sw, A_0);
		i3.a(ref sx, A_0);
		if (binaryReader.ReadBoolean())
		{
			sy = binaryReader.ReadString();
		}
		else
		{
			sy = null;
		}
		binaryReader = null;
	}

	private new void m2(BinaryWriter A_0)
	{
		BinaryWriter binaryWriter = A_0;
		i3.a(r3, A_0);
		i3.a(r4, A_0);
		binaryWriter.Write(r5);
		binaryWriter.Write(r6.Ticks);
		ej.a(this.m_st, A_0);
		checked
		{
			if (ry != null)
			{
				binaryWriter.Write(value: true);
				binaryWriter.Write(ry.Length);
				int num = ry.Length - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					c.u(ry[num2], A_1: false, A_0);
				}
			}
			else
			{
				binaryWriter.Write(value: false);
			}
		}
		binaryWriter.Write((int)sg);
		binaryWriter.Write(sh);
		binaryWriter.Write(sa.Ticks);
		if (sb == null)
		{
			binaryWriter.Write(string.Empty);
		}
		else
		{
			binaryWriter.Write(sb);
		}
		binaryWriter.Write(r9);
		binaryWriter.Write(sp);
		binaryWriter.Write(r7);
		binaryWriter.Write(si);
		binaryWriter.Write(this.m_sj);
		binaryWriter.Write(sk);
		binaryWriter.Write(sl);
		binaryWriter.Write(this.m_sm);
		i3.a(this.m_sn, A_0);
		binaryWriter.Write((int)this.m_so);
		i3.a(rz, A_0);
		i3.a(r0, A_0);
		binaryWriter.Write(se);
		binaryWriter.Write(sc.Ticks);
		binaryWriter.Write(r8);
		ej.a(su, A_0);
		i3.a(r1, A_0);
		i3.a(r2, A_0);
		binaryWriter.Write(sf);
		binaryWriter.Write(sd.Ticks);
		i3.a(rr, A_0);
		binaryWriter.Write(rs);
		binaryWriter.Write(rt);
		ej.a(ru, A_0);
		i3.a(rv, A_0);
		binaryWriter.Write(rw);
		binaryWriter.Write(rx);
		i3.a(sv, A_0);
		i3.a(sw, A_0);
		i3.a(sx, A_0);
		if (sy == null)
		{
			binaryWriter.Write(value: false);
		}
		else
		{
			binaryWriter.Write(value: true);
			binaryWriter.Write(sy);
		}
		binaryWriter = null;
	}

	private new void m2(ref DateTime A_0)
	{
		string A_1 = null;
		A_0 = DateTime.MinValue;
		checked
		{
			if (m2(ref A_1))
			{
				BinaryReader binaryReader = null;
				try
				{
					binaryReader = new BinaryReader(File.Open(A_1, FileMode.Open, FileAccess.Read, FileShare.Read));
					int num = binaryReader.ReadInt32();
					if (binaryReader.ReadInt32() > 2)
					{
						this.m_wc = null;
						this.m_wf = false;
						return;
					}
					if (binaryReader.ReadBoolean())
					{
						int num2 = binaryReader.ReadInt32();
						if (num2 == this.m_p9)
						{
							int num3 = num2 - 1;
							this.m_wc = new float[num3 + 1];
							int num4 = num3;
							for (int num5 = 0; num5 <= num4; num5++)
							{
								this.m_wc[num5] = binaryReader.ReadSingle();
							}
							this.m_wf = true;
						}
						else
						{
							this.m_wc = null;
							this.m_wf = false;
						}
					}
					else
					{
						this.m_wc = null;
						this.m_wf = true;
					}
					if (num > 1)
					{
						double num6 = binaryReader.ReadDouble();
						if (num6 == 0.0)
						{
							A_0 = DateTime.MinValue;
						}
						else
						{
							A_0 = DateTime.FromOADate(num6);
						}
					}
					return;
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex3 = ex2;
					this.m_wc = null;
					this.m_wf = false;
					ProjectData.ClearProjectError();
					return;
				}
				finally
				{
					binaryReader?.Close();
				}
			}
			this.m_wc = null;
			this.m_wf = false;
		}
	}

	private void sn(DateTime A_0)
	{
		BinaryWriter binaryWriter = null;
		checked
		{
			int num = this.m_p9 - 1;
			g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
			string path = yr();
			string directoryName = Path.GetDirectoryName(path);
			bool flag = default(bool);
			try
			{
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create));
				binaryWriter.Write(2);
				binaryWriter.Write(1);
				if (opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.ReflectanceProbe)
				{
					binaryWriter.Write(value: true);
					binaryWriter.Write(this.m_p9);
					int num2 = num;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						binaryWriter.Write(this.m_wc[num3]);
					}
				}
				else
				{
					binaryWriter.Write(value: false);
				}
				binaryWriter.Write(A_0.ToOADate());
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				ab8().c(fz.b.b, "Error in USBSpectrometerDevice.WritePersistentSettingsFile", a_);
				flag = true;
				ProjectData.ClearProjectError();
			}
			finally
			{
				binaryWriter?.Close();
				if (flag && File.Exists(path))
				{
					File.Delete(path);
				}
			}
		}
	}

	public bool yg()
	{
		BinaryWriter binaryWriter = null;
		int num = 10;
		string text = "";
		int num2 = checked(this.m_p9 - 1);
		bool result;
		try
		{
			if (this.m_m2 == null)
			{
				result = false;
			}
			else
			{
				string a_ = yk();
				string a_2 = q6[(int)this.m_ti.k()];
				g2.OpticsConfigSubmoduleTypes a_3 = this.m_ti.k();
				io.a a_4 = bb();
				bool A_ = false;
				bool A_2 = false;
				text = m2(a_, a_2, a_3, a_4, ref A_, ref A_2);
				string directoryName = Path.GetDirectoryName(text);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				binaryWriter = new BinaryWriter(File.Open(text, FileMode.Create));
				binaryWriter.Write(21);
				binaryWriter.Write(13);
				binaryWriter.Write(11);
				binaryWriter.Write((int)this.m_ti.k());
				int num3 = num;
				checked
				{
					for (int num4 = 0; num4 <= num3; num4++)
					{
						if (q6[num4] == null)
						{
							binaryWriter.Write(string.Empty);
						}
						else
						{
							binaryWriter.Write(q6[num4]);
						}
					}
					int num5 = num;
					for (int num4 = 0; num4 <= num5; num4++)
					{
						binaryWriter.Write(qq[num4].GetUpperBound(0));
					}
					int num6 = num;
					for (int num4 = 0; num4 <= num6; num4++)
					{
						binaryWriter.Write(qq[num4][0].v() != null);
					}
					bool[] array = new bool[num + 1];
					array = this.m_ti.n();
					int num7 = num;
					for (int num4 = 0; num4 <= num7; num4++)
					{
						binaryWriter.Write(array[num4]);
					}
					int num8 = num;
					for (int num4 = 0; num4 <= num8; num4++)
					{
						long ticks = qq[num4][0].n.Ticks;
						binaryWriter.Write(ticks);
					}
					int num9 = num;
					for (int num4 = 0; num4 <= num9; num4++)
					{
						if (qq[num4][0].v() != null)
						{
							float[] array2 = qq[num4][0].v();
							int num10 = num2;
							for (int num11 = 0; num11 <= num10; num11++)
							{
								binaryWriter.Write(array2[num11]);
							}
						}
					}
					int num12 = num;
					for (int num4 = 0; num4 <= num12; num4++)
					{
						if (qq[num4][0].v() != null)
						{
							float[] array2 = qq[num4][0].w();
							int num13 = num2;
							for (int num14 = 0; num14 <= num13; num14++)
							{
								binaryWriter.Write(array2[num14]);
							}
						}
					}
					int num15 = num;
					for (int num4 = 0; num4 <= num15; num4++)
					{
						binaryWriter.Write(qq[num4][0].x() != null);
					}
					int num16 = num;
					for (int num4 = 0; num4 <= num16; num4++)
					{
						if (qq[num4][0].x() != null)
						{
							float[] array2 = qq[num4][0].x();
							int num17 = num2;
							for (int num18 = 0; num18 <= num17; num18++)
							{
								binaryWriter.Write(array2[num18]);
							}
						}
					}
					int num19 = num;
					for (int num4 = 0; num4 <= num19; num4++)
					{
						binaryWriter.Write(qq[num4][0].j);
					}
					int num20 = num;
					for (int num4 = 0; num4 <= num20; num4++)
					{
						binaryWriter.Write(qs[num4] != null);
					}
					array = new bool[num + 1];
					array = this.m_ti.o();
					int num21 = num;
					for (int num4 = 0; num4 <= num21; num4++)
					{
						binaryWriter.Write(array[num4]);
					}
					int num22 = num;
					for (int num4 = 0; num4 <= num22; num4++)
					{
						binaryWriter.Write(q7[num4].Ticks);
					}
					int num23 = num;
					for (int num4 = 0; num4 <= num23; num4++)
					{
						if (qs[num4] != null)
						{
							float[] array2 = qs[num4];
							int num24 = num2;
							for (int num25 = 0; num25 <= num24; num25++)
							{
								binaryWriter.Write(array2[num25]);
							}
						}
					}
					int num26 = num;
					for (int num4 = 0; num4 <= num26; num4++)
					{
						if (qs[num4] != null)
						{
							float[] array2 = qu[num4];
							int num27 = num2;
							for (int num28 = 0; num28 <= num27; num28++)
							{
								binaryWriter.Write(array2[num28]);
							}
						}
					}
					int num29 = num;
					for (int num4 = 0; num4 <= num29; num4++)
					{
						binaryWriter.Write(q9[num4]);
					}
					m2(binaryWriter, qx);
					int num30 = num;
					for (int num4 = 0; num4 <= num30; num4++)
					{
						binaryWriter.Write(qy[num4].Ticks);
					}
					int num31 = num;
					for (int num4 = 0; num4 <= num31; num4++)
					{
						binaryWriter.Write(rf[num4] != null);
					}
					int num32 = num;
					for (int num4 = 0; num4 <= num32; num4++)
					{
						if (rf[num4] != null)
						{
							float[] array2 = rf[num4];
							int num33 = num2;
							for (int num34 = 0; num34 <= num33; num34++)
							{
								binaryWriter.Write(array2[num34]);
							}
						}
					}
					int num35 = num;
					for (int num4 = 0; num4 <= num35; num4++)
					{
						binaryWriter.Write(rg[num4]);
					}
					m2(binaryWriter, rl);
					int num36 = num;
					for (int num4 = 0; num4 <= num36; num4++)
					{
						binaryWriter.Write(unchecked((int)qz[num4]));
					}
					int num37 = num;
					for (int num4 = 0; num4 <= num37; num4++)
					{
						binaryWriter.Write(qq[num4][0].p);
					}
					binaryWriter.Write(this.m_ub);
					binaryWriter.Write(this.m_uc);
					binaryWriter.Write(this.m_ud);
					binaryWriter.Write(this.m_ue);
					binaryWriter.Write(this.m_uf);
					int num38 = num;
					for (int num4 = 0; num4 <= num38; num4++)
					{
						binaryWriter.Write(qr[num4]);
					}
					int num39 = num;
					for (int num4 = 0; num4 <= num39; num4++)
					{
						long ticks = q8[num4].Ticks;
						binaryWriter.Write(ticks);
						binaryWriter.Write(qv[num4] != null);
						if (qv[num4] != null)
						{
							float[] array2 = qv[num4];
							int num40 = num2;
							for (int num41 = 0; num41 <= num40; num41++)
							{
								binaryWriter.Write(array2[num41]);
							}
							array2 = qw[num4];
							int num42 = num2;
							for (int num43 = 0; num43 <= num42; num43++)
							{
								binaryWriter.Write(array2[num43]);
							}
							binaryWriter.Write(ra[num4]);
						}
						int upperBound = qq[num4].GetUpperBound(0);
						for (int num44 = 1; num44 <= upperBound; num44++)
						{
							c c10 = qq[num4][num44];
							binaryWriter.Write(c10.v() != null);
							ticks = c10.n.Ticks;
							binaryWriter.Write(ticks);
							if (c10.v() != null)
							{
								float[] array2 = c10.v();
								int num45 = num2;
								for (int num46 = 0; num46 <= num45; num46++)
								{
									binaryWriter.Write(array2[num46]);
								}
								array2 = c10.w();
								int num47 = num2;
								for (int num48 = 0; num48 <= num47; num48++)
								{
									binaryWriter.Write(array2[num48]);
								}
								array2 = c10.x();
								int num49 = num2;
								for (int num50 = 0; num50 <= num49; num50++)
								{
									binaryWriter.Write(array2[num50]);
								}
								binaryWriter.Write(c10.j);
								binaryWriter.Write(c10.p);
							}
							c10 = null;
						}
						int upperBound2 = qq[num4].GetUpperBound(0);
						for (int num51 = 0; num51 <= upperBound2; num51++)
						{
							if (qq[num4][num51].q == null)
							{
								binaryWriter.Write(value: false);
							}
							else
							{
								binaryWriter.Write(value: true);
								qq[num4][num51].q.a(binaryWriter);
							}
							_ = null;
						}
						binaryWriter.Write(rb[num4].Ticks);
						binaryWriter.Write(rc[num4] != null);
						if (rc[num4] != null)
						{
							float[] array2 = rc[num4];
							int num52 = num2;
							for (int num53 = 0; num53 <= num52; num53++)
							{
								binaryWriter.Write(array2[num53]);
							}
							array2 = rd[num4];
							int num54 = num2;
							for (int num55 = 0; num55 <= num54; num55++)
							{
								binaryWriter.Write(array2[num55]);
							}
							binaryWriter.Write(re[num4]);
						}
					}
					int count = rp.Count;
					bool flag = count > 0;
					binaryWriter.Write(flag);
					if (flag)
					{
						binaryWriter.Write(count);
						int num56 = count - 1;
						int num57 = num56;
						for (int num58 = 0; num58 <= num57; num58++)
						{
							binaryWriter.Write(rp[num58]);
						}
						int num59 = num56;
						for (int num58 = 0; num58 <= num59; num58++)
						{
							float[] array2 = rn[num58];
							int num60 = num2;
							for (int num61 = 0; num61 <= num60; num61++)
							{
								binaryWriter.Write(array2[num61]);
							}
						}
						int num62 = num56;
						for (int num58 = 0; num58 <= num62; num58++)
						{
							float[] array2 = ro[num58];
							int num63 = num2;
							for (int num64 = 0; num64 <= num63; num64++)
							{
								binaryWriter.Write(array2[num64]);
							}
						}
					}
					binaryWriter.Write(rq);
					binaryWriter.Write(unchecked((int)this.m_ti.k()));
					if (this.m_ug != null)
					{
						int upperBound3 = this.m_ug.GetUpperBound(0);
						binaryWriter.Write(upperBound3);
						int num65 = upperBound3;
						for (int num66 = 0; num66 <= num65; num66++)
						{
							binaryWriter.Write(this.m_ug[num66]);
						}
					}
					else
					{
						binaryWriter.Write(-1);
					}
					int num67 = num;
					for (int num4 = 0; num4 <= num67; num4++)
					{
						int upperBound4 = qq[num4].GetUpperBound(0);
						for (int num68 = 0; num68 <= upperBound4; num68++)
						{
							c c11 = qq[num4][num68];
							binaryWriter.Write(c11.l);
							c11 = null;
						}
					}
					if (this.m_v9)
					{
						binaryWriter.Write(value: false);
					}
					else
					{
						binaryWriter.Write(value: true);
						binaryWriter.Write(this.m_u1.ToOADate());
						binaryWriter.Write(this.m_u8);
						binaryWriter.Write(this.m_u7);
						int A_3 = this.m_u8;
						int num69 = this.m_u7;
						for (int num70 = 1; num70 <= num69; num70++)
						{
							m2(ref A_3);
							binaryWriter.Write(this.m_u2[A_3]);
							binaryWriter.Write(this.m_u4[A_3]);
							binaryWriter.Write(this.m_u3[A_3]);
							int num71 = num2;
							for (int num72 = 0; num72 <= num71; num72++)
							{
								binaryWriter.Write(this.m_uw[num72, A_3]);
							}
						}
						A_3 = this.m_u8;
						int num73 = this.m_u7;
						for (int num74 = 1; num74 <= num73; num74++)
						{
							m2(ref A_3);
							binaryWriter.Write(this.m_u5[A_3]);
						}
					}
					binaryWriter.Write(this.m_we);
					int num75 = num;
					for (int num4 = 0; num4 <= num75; num4++)
					{
						int upperBound5 = qq[num4].GetUpperBound(0);
						for (int num76 = 0; num76 <= upperBound5; num76++)
						{
							c c12 = qq[num4][num76];
							binaryWriter.Write(c12.k);
							binaryWriter.Write(c12.m);
							c12 = null;
						}
					}
					if (qq[10] != null)
					{
						c c13 = qq[10][0];
						binaryWriter.Write(c13.s);
						if (c13.s)
						{
							binaryWriter.Write(c13.r);
							i3.a(c13.y(), binaryWriter);
							i3.a(c13.z(), binaryWriter);
							i3.a(c13.aa(), binaryWriter);
						}
						c13 = null;
					}
					p4 = text;
					result = true;
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_5 = ex2;
			ab8().c(fz.b.b, "Error in USBSpectrometerDevice.WriteSettingsFile", a_5);
			result = false;
			ProjectData.ClearProjectError();
		}
		finally
		{
			binaryWriter?.Close();
		}
		return result;
	}

	public new static void m2(string A_0, d A_1, fz A_2, string A_3, bool A_4)
	{
		string text = ((!string.IsNullOrEmpty(A_3)) ? "\r\n" : ", ");
		d d10 = A_1;
		string text2 = A_0 + "(Spec S/N:" + d10.a + "): ";
		if (!string.IsNullOrEmpty(A_3))
		{
			text2 += text;
		}
		text2 = text2 + "Offset=" + d10.cb.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "Slope=" + d10.cc.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "Curvature=" + d10.cd.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "Third=" + d10.ce.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "Fourth=" + d10.cf.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "Temperature=" + d10.cg.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "Offset2=" + d10.ch.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "Slope2=" + d10.ci.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "Curvature2=" + d10.cj.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "Third2=" + d10.ck.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "Fourth2=" + d10.cl.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "Temperature2=" + d10.cm.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "Wavelength range restricted=" + d10.cq.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "Wavelength Start=" + d10.cn.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "Wavelength End=" + d10.co.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "Extra range for temperature compensation=" + d10.cr.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "Notch/flat find only=" + d10.cs.ToString(CultureInfo.InvariantCulture);
		if (string.IsNullOrEmpty(A_3))
		{
			A_2.c(fz.b.a, text2);
			text2 = null;
		}
		else
		{
			text2 += text;
		}
		if (A_4)
		{
			text2 += "Additional Internal-Only settings: ";
			if (!string.IsNullOrEmpty(A_3))
			{
				text2 += text;
			}
			f f10 = d10.cu;
			text2 = text2 + "ShortScatter=" + f10.b.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "LongScatter=" + f10.c.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "ShortScatterBroadNumPts=" + f10.h.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "ShortScatterBroadSlopeCoeff=" + f10.f.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "ShortScatterBroadInterceptCoeff=" + f10.g.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "ShortScatterNarrowNumPts=" + f10.j.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "ShortScatterNarrowCoeff=" + f10.i.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "SecondOrderCoeff0=" + f10.k[0].ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "SecondOrderCoeff1=" + f10.k[1].ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "SecondOrderCoeff2=" + f10.k[2].ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "SecondOrderCoeff3=" + f10.k[3].ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "SecondOrderCoeff4=" + f10.k[4].ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "SecondOrderCoeff5=" + f10.k[5].ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "SecondOrderNumOfPoints=" + f10.m.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "SecondOrderPointsAverage=" + f10.n.ToString(CultureInfo.InvariantCulture);
			f10 = null;
			g g10 = d10.c7;
			text2 = text2 + "ScatterEfficiency=" + g10.h.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "ExtendedPtOffset=" + g10.f.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "ExtendedPtSpacing=" + g10.e.ToString(CultureInfo.InvariantCulture) + text;
			if (g10.p() != null)
			{
				text2 += "ScattLEDIndices=";
				float[] array = g10.p();
				foreach (float num2 in array)
				{
					text2 = text2 + "," + num2.ToString(CultureInfo.InvariantCulture);
				}
				text2 += text;
			}
			if (g10.q() != null)
			{
				text2 += "ScatterLEDWidths=";
				float[] array2 = g10.q();
				foreach (float num4 in array2)
				{
					text2 = text2 + "," + num4.ToString(CultureInfo.InvariantCulture);
				}
				text2 += text;
			}
			text2 = text2 + "MaxScattCoeff=" + g10.g.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "LongWLScatterOffsetCoeff" + g10.i.ToString(CultureInfo.InvariantCulture) + text;
			g10 = null;
			text2 = text2 + "UseScatterLEDInfoIfAvailable=" + d10.c8.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "Linearity Version=" + Conversions.ToString(d10.cv) + text;
			text2 = text2 + "Linearity Slope=" + Conversions.ToString(d10.cw) + text;
			text2 = text2 + "Linearity Intercept=" + Conversions.ToString(d10.cx) + text;
			k k2 = null;
			do
			{
				string text3;
				if (k2 == d10.cy.a)
				{
					k2 = d10.cy.b;
					text3 = "2";
				}
				else
				{
					k2 = d10.cy.a;
					text3 = "1";
				}
				k k3 = d10.cy.a;
				int num5 = 0;
				do
				{
					text2 = text2 + "LinV2C" + num5.ToString().Trim() + "T" + text3 + "=" + k3.b[num5] + text;
					num5 = checked(num5 + 1);
				}
				while (num5 <= 4);
				text2 = text2 + "LinV2T" + text3 + "=" + k3.c + text;
				k3 = null;
			}
			while (k2 != d10.cy.b);
			text2 = text2 + "Update Firmware to latest rev=" + d10.h + text;
			text2 = text2 + "Firmware Rev=" + d10.f + text;
			text2 = text2 + "AtoDGain=" + d10.cz + text;
			text2 = text2 + "AtoDHWOffset=" + d10.c0 + text;
			text2 = text2 + "AtoDSWOffsetEven=" + d10.c1 + text;
			text2 = text2 + "AtoDSWOffsetOdd=" + d10.c2 + text;
			text2 = text2 + "WaveLength Resolution=" + d10.c3.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "WaveLength ResolutionSlope=" + d10.c4.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "WaveLength ResolutionRefWavelength=" + d10.c5.ToString(CultureInfo.InvariantCulture) + text;
			n n2 = d10.c6;
			text2 = text2 + "Wavelength Cal Offset Delta Offset=" + n2.z.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "Active Wavelength Cal Offset Delta=" + n2.aa.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "Left width=" + n2.ab.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "Right width=" + n2.ab.ToString(CultureInfo.InvariantCulture) + text;
			n2 = null;
			text2 = text2 + "NotchSharpenAmplitude=" + d10.db.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "NotchSharpenInterval=" + d10.dc.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "TECSupplyIsCalibrated=" + d10.c9.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "TECSupplyMaxR=" + d10.da.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "BaselineLinearityAmplitude=" + d10.dd.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "BaselineLinearityAmplitudeT=" + d10.de.ToString(CultureInfo.InvariantCulture) + text;
			text2 = text2 + "TransCurvedCorrection=" + d10.df.ToString(CultureInfo.InvariantCulture);
		}
		if (string.IsNullOrEmpty(A_3))
		{
			A_2.c(fz.b.a, text2);
		}
		else
		{
			File.WriteAllText(Path.Combine(A_3, "Spec FW-" + A_1.a + " (" + A_1.b + ").txt"), text2);
		}
		d10 = null;
	}

	public void yh()
	{
		BinaryWriter binaryWriter = null;
		try
		{
			if (this.m_m2 != null)
			{
				binaryWriter = new BinaryWriter(File.Open(sn(), FileMode.Create));
				binaryWriter.Write(21);
				binaryWriter.Write(1);
				binaryWriter.Write(this.m_wg);
				binaryWriter.Write(this.m_wh);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ab8().c(fz.b.b, "Error in USBSpectrometerDevice.WriteAllRefMatsSettings", a_);
			ProjectData.ClearProjectError();
		}
		finally
		{
			binaryWriter?.Close();
		}
	}

	private new void m2(BinaryWriter A_0, Collection<ej> A_1)
	{
		int num = 10;
		for (int num2 = 0; num2 <= num; num2 = checked(num2 + 1))
		{
			if (A_1[num2] == null)
			{
				A_0.Write(value: false);
				continue;
			}
			A_0.Write(value: true);
			A_1[num2].a(A_0);
		}
	}

	private void qh(int A_0)
	{
		int num = ex.e(q6[A_0]);
		checked
		{
			c[] array = new c[num - 1 + 1];
			int num2 = num - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				array[num3] = new c();
			}
			qq[A_0] = array;
		}
	}

	private void p9(int A_0)
	{
		q6[A_0] = string.Empty;
		qh(A_0);
		q7[A_0] = new DateTime(0L);
		q8[A_0] = new DateTime(0L);
		q9[A_0] = 0.0;
		ra[A_0] = 0.0;
		qy[A_0] = new DateTime(0L);
		rg[A_0] = 0f;
		qs[A_0] = null;
		qt[A_0] = null;
		qu[A_0] = null;
		qv[A_0] = null;
		qw[A_0] = null;
		rf[A_0] = null;
	}

	private void sj()
	{
		qq[10][0].ae();
	}

	private void qh()
	{
		bool[] A_ = new bool[11];
		bool[] A_2 = new bool[11];
		int num = 0;
		do
		{
			A_[num] = false;
			A_2[num] = false;
			p9(num);
			num = checked(num + 1);
		}
		while (num <= 10);
		rq = false;
		this.m_ug = null;
		te(A_0: true);
		xc();
		this.m_ti = this.m_ti.j(ref A_, ref A_2);
		p5 = true;
	}

	private void p9()
	{
		checked
		{
			int num = s0 - 1;
			for (int num2 = 1; num2 <= num; num2++)
			{
				s1[num2 - 1] = s1[num2];
				s2[num2 - 1] = s2[num2];
			}
			s0--;
		}
	}

	private new void m2(ref double[] A_0, ref float A_1, bool A_2)
	{
		bool A_3 = false;
		int A_4 = 0;
		int A_5 = 0;
		p9(ref A_0, ref A_1, A_2: false, A_3: true, A_2, null, null, null, null, null, ref A_3, ref A_4, ref A_5, DateTime.MinValue, A_14: false, A_15: false, null, null, 0f, 0f, default(Guid));
	}

	private void p9(ref double[] A_0, ref float A_1, bool A_2, bool A_3, bool A_4, float[] A_5, int[] A_6, int[] A_7, double[] A_8, double[] A_9, ref bool A_10, ref int A_11, ref int A_12, DateTime A_13, bool A_14, bool A_15, float[] A_16, float[] A_17, float A_18, float A_19, Guid A_20)
	{
		m2(ref A_0, ref A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, ref A_10, ref A_11, ref A_12, A_13, A_14, A_15, A_16, A_17, A_18, A_19, A_20);
	}

	public new void m2(double[] A_0, int A_1, float A_2)
	{
		if (qd == 1)
		{
			f6.CorrectForLinearity(ref A_0[0], A_1, qb, qc);
		}
		else
		{
			this.m_m2.CorrectForLinearitySafe2(A_0, A_1, A_2);
		}
	}

	public void p9(double[] A_0, int A_1, float A_2)
	{
		this.m_m2.CorrectForScatterSafe(A_0, A_1, this.m_uu, this.m_uv);
	}

	public void p9(double[] A_0, float A_1)
	{
		m2(A_0, this.m_p9, A_1);
		this.m_m2.CorrectForScatterSafe(A_0, this.m_p9, this.m_uu, this.m_uv);
	}

	private new void m2(ref int A_0, ref float A_1)
	{
		checked
		{
			int num = rp.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (m2(sq, rp[num2]))
				{
					A_0 = num2;
					A_1 = 1f;
					break;
				}
				if (rp[num2] > sq)
				{
					A_0 = num2;
					if (A_0 == 0)
					{
						A_1 = Convert.ToSingle(sq / rp[A_0]);
					}
					else
					{
						A_1 = Convert.ToSingle((sq - rp[A_0 - 1]) / (rp[A_0] - rp[A_0 - 1]));
					}
					break;
				}
			}
		}
	}

	public new static void m2(double[] A_0, double[] A_1, int A_2, double[] A_3, ref double[] A_4)
	{
		if (A_0 != null)
		{
			A_4 = new double[checked(A_2 - 1 + 1)];
			jf.a(ref A_0, ref A_1, A_0.Length, ref A_3, ref A_4, A_2);
		}
		else
		{
			A_4 = null;
		}
	}

	private new float[] m2(float[] A_0, float[] A_1)
	{
		checked
		{
			int num = this.m_p9 - 1;
			float[] array = new float[num + 1];
			double[] array2 = new double[num + 1];
			double[] array3 = new double[num + 1];
			int num2 = 8;
			int num3 = 2;
			double num4 = 25.0;
			int num5 = 5;
			int num6 = -1;
			int num7 = -1;
			int num8 = num;
			for (int num9 = 0; num9 <= num8; num9++)
			{
				array2[num9] = A_0[num9] / A_1[num9];
			}
			int a_ = ((!ab0()) ? (num2 * 2 + 1) : (num3 * 2 + 1));
			f6.BoxSmoothSpectrum(a_, ref array2[0], this.m_p9, ref array3[0]);
			int num10 = num;
			for (int num9 = 0; num9 <= num10; num9++)
			{
				if ((double)A_0[num9] > num4)
				{
					num6 = num9;
					break;
				}
			}
			if (num6 == -1)
			{
				int num11 = num;
				for (int num9 = 0; num9 <= num11; num9++)
				{
					array[num9] = 1f;
				}
			}
			else
			{
				for (int num9 = num; num9 >= 0; num9 += -1)
				{
					if ((double)A_0[num9] > num4)
					{
						num7 = num9;
						break;
					}
				}
				double num12 = 0.0;
				int num13 = num6;
				int num14 = num6 + num5 - 1;
				for (int num9 = num13; num9 <= num14; num9++)
				{
					num12 += array3[num9];
				}
				num12 /= (double)num5;
				float num15 = (float)num12;
				double num16 = 0.0;
				int num17 = num7;
				int num18 = num7 - num5 + 1;
				for (int num9 = num17; num9 >= num18; num9 += -1)
				{
					num16 += array3[num9];
				}
				num16 /= (double)num5;
				float num19 = (float)num16;
				int num20 = num6 - 1;
				for (int num9 = 0; num9 <= num20; num9++)
				{
					array[num9] = num15;
				}
				int num21 = num6;
				int num22 = num7;
				for (int num9 = num21; num9 <= num22; num9++)
				{
					array[num9] = (float)array3[num9];
				}
				int num23 = num7 + 1;
				int num24 = num;
				for (int num9 = num23; num9 <= num24; num9++)
				{
					array[num9] = num19;
				}
			}
			return array;
		}
	}

	private new void m2(ref double[] A_0, ref float A_1, bool A_2, bool A_3, bool A_4, float[] A_5, int[] A_6, int[] A_7, double[] A_8, double[] A_9, ref bool A_10, ref int A_11, ref int A_12, DateTime A_13, bool A_14, bool A_15, float[] A_16, float[] A_17, float A_18, float A_19, Guid A_20)
	{
		bool flag = p9(A_4);
		double[] array = null;
		double[] array2 = null;
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
		int num = checked(this.m_p9 - 1);
		bool flag2 = opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.CTMProbe;
		bool flag3 = flag2 && w2();
		bool flag4 = (!flag2 || rq) && !A_4;
		bool flag5 = q0;
		bool flag6 = q1;
		float[] array3 = this.m_wm[(int)opticsConfigSubmoduleTypes];
		float[] array4 = this.m_wp[(int)opticsConfigSubmoduleTypes];
		bool flag7 = this.m_tj.m() && A_15;
		bool flag8 = this.m_tj.l() && A_14;
		bool flag9 = flag7 && flag4;
		checked
		{
			try
			{
				int num2;
				try
				{
					num2 = Information.UBound(A_0);
				}
				catch (ArgumentNullException ex2)
				{
					ProjectData.SetProjectError(ex2);
					ArgumentNullException ex3 = ex2;
					num2 = -1;
					ProjectData.ClearProjectError();
				}
				if ((num2 != num) | (Information.Err().Number != 0))
				{
					A_0 = new double[num + 1];
				}
				double num3 = default(double);
				double num4 = default(double);
				if (t1 && flag)
				{
					num3 = m2(ref qf);
					double[] array5 = new double[1] { num3 };
					p9(array5, qg);
					num4 = array5[0];
				}
				bool flag10 = default(bool);
				if (flag8 && (!this.m_w6 || this.m_w7 != flag9 || q0 || q1 || this.m_w8 != opticsConfigSubmoduleTypes))
				{
					m2(m2(0, A_13), p9(0, A_13), flag9, ref this.m_w2, ref this.m_w3);
					unchecked
					{
						this.m_w5 = qq[(int)opticsConfigSubmoduleTypes][0].ab();
						this.m_w4 = sm(0, A_13);
						if (qq[(int)opticsConfigSubmoduleTypes].GetUpperBound(0) > 0)
						{
							float[] array6 = qq[(int)opticsConfigSubmoduleTypes][0].ac();
							int num5 = num;
							for (int num6 = 0; num6 <= num5; num6 = checked(num6 + 1))
							{
								this.m_w2[num6] *= array6[num6];
								this.m_w5[num6] *= array6[num6];
							}
							float[] A_21 = null;
							float[] A_22 = null;
							int upperBound = qq[(int)opticsConfigSubmoduleTypes].GetUpperBound(0);
							for (int num7 = 1; num7 <= upperBound; num7 = checked(num7 + 1))
							{
								m2(m2(num7, A_13), p9(num7, A_13), flag9, ref A_21, ref A_22);
								array6 = qq[(int)opticsConfigSubmoduleTypes][num7].ac();
								float[] array7 = qq[(int)opticsConfigSubmoduleTypes][num7].ab();
								int num8 = num;
								for (int num6 = 0; num6 <= num8; num6 = checked(num6 + 1))
								{
									this.m_w2[num6] += A_21[num6] * array6[num6];
									this.m_w3[num6] += A_22[num6] * array6[num6];
									this.m_w5[num6] += array7[num6] * array6[num6];
								}
							}
						}
					}
					if (flag)
					{
						if (this.m_w9 == null || Information.UBound(this.m_w9) != num)
						{
							this.m_w9 = new double[num + 1];
						}
						float[] array8 = qq[unchecked((int)opticsConfigSubmoduleTypes)][0].ab();
						int num9 = num;
						for (int num6 = 0; num6 <= num9; num6++)
						{
							this.m_w9[num6] = array8[num6];
						}
						if (opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.ReflectanceProbe && array3 != null)
						{
							int num10 = num;
							for (int num6 = 0; num6 <= num10; num6++)
							{
								this.m_w9[num6] *= array4[num6];
							}
						}
					}
					else if (opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.ReflectanceProbe && array3 != null)
					{
						int num11 = num;
						for (int num6 = 0; num6 <= num11; num6++)
						{
							this.m_w5[num6] *= array4[num6];
						}
					}
					this.m_w6 = true;
					this.m_w7 = flag9;
					this.m_w8 = opticsConfigSubmoduleTypes;
					q0 = false;
					flag10 = true;
				}
				bool flag11 = default(bool);
				if (flag7 && (q1 || this.m_xd != opticsConfigSubmoduleTypes || (flag2 && !m2(sq, this.m_xc))))
				{
					if (this.m_xa == null || this.m_xa.GetUpperBound(0) != num)
					{
						this.m_xa = new float[num + 1];
						this.m_xb = new float[num + 1];
					}
					if (flag3)
					{
						int A_23 = default(int);
						float A_24 = default(float);
						m2(ref A_23, ref A_24);
						if (jf.e(A_24, 1.0))
						{
							int num12 = num;
							for (int num6 = 0; num6 <= num12; num6++)
							{
								this.m_xa[num6] = ro[A_23][num6];
								this.m_xb[num6] = rn[A_23][num6];
							}
						}
						else if (A_23 == 0)
						{
							int num13 = num;
							for (int num6 = 0; num6 <= num13; num6++)
							{
								this.m_xa[num6] = ro[A_23][num6] * A_24;
								this.m_xb[num6] = rn[A_23][num6] * A_24;
							}
						}
						else
						{
							int num14 = num;
							for (int num6 = 0; num6 <= num14; num6++)
							{
								this.m_xa[num6] = ro[A_23 - 1][num6] * (1f - A_24) + ro[A_23][num6] * A_24;
								this.m_xb[num6] = rn[A_23 - 1][num6] * (1f - A_24) + rn[A_23][num6] * A_24;
							}
						}
						float[] a_ = this.m_xb;
						Collection<short[]> collection;
						int index;
						short[] A_25 = (collection = qt)[index = unchecked((int)opticsConfigSubmoduleTypes)];
						m2(a_, ref A_25);
						collection[index] = A_25;
					}
					else
					{
						this.m_xa = qh(flag11);
						this.m_xb = sm(flag11);
					}
					this.m_xc = sq;
					this.m_xd = opticsConfigSubmoduleTypes;
					q1 = false;
				}
				if (flag7 && x8())
				{
					float[] array9 = qh(A_0: false);
					float[] array10 = qw[unchecked((int)opticsConfigSubmoduleTypes)];
					array = new double[num + 1];
					double[] array11 = new double[num + 1];
					int index = num;
					for (int num6 = 0; num6 <= index; num6++)
					{
						array11[num6] = (double)A_5[A_6[num6]] * A_8[num6] + (double)A_5[A_7[num6]] * A_9[num6];
					}
					if (A_4)
					{
						if (flag6)
						{
							if (this.m_wc != null)
							{
								this.m_xe = this.m_wc;
							}
							else
							{
								this.m_xe = new float[num + 1];
								int num15 = num;
								for (int num6 = 0; num6 <= num15; num6++)
								{
									this.m_xe[num6] = (array10[num6] - array9[num6]) / array10[num6];
								}
							}
						}
						if (flag5)
						{
							this.m_xf = m2(this.m_w3, array10);
						}
						array2 = new double[num + 1];
						int num16 = num;
						for (int num6 = 0; num6 <= num16; num6++)
						{
							array2[num6] = (double)this.m_w3[num6] * (array11[num6] - 1.0) * (double)this.m_xe[num6] + (double)this.m_w3[num6];
						}
					}
					else
					{
						int num17 = num;
						for (int num6 = 0; num6 <= num17; num6++)
						{
							array[num6] = array11[num6] * (double)(array10[num6] - array9[num6]);
						}
					}
				}
				if ((flag7 && (this.m_m2.IntTimesEqual(q9[unchecked((int)opticsConfigSubmoduleTypes)], sq) != 0 || flag || flag3)) || A_3)
				{
					int num18 = num;
					for (int num6 = 0; num6 <= num18; num6++)
					{
						A_0[num6] = qf[num6];
					}
					p9(A_0, qg);
					if (A_2)
					{
						if (flag)
						{
							if (t1)
							{
								int num19 = num;
								for (int num6 = 0; num6 <= num19; num6++)
								{
									float num20 = (float)(qf[num6] - num3);
									A_0[num6] -= num4;
									if (num20 > A_1)
									{
										A_1 = num20;
									}
								}
							}
							else
							{
								int num21 = num;
								for (int num6 = 0; num6 <= num21; num6++)
								{
									float num20 = (float)qf[num6];
									if (num20 > A_1)
									{
										A_1 = num20;
									}
								}
							}
							double[] array12;
							if (t1)
							{
								array12 = new double[num + 1];
								int num22 = num;
								for (int num6 = 0; num6 <= num22; num6++)
								{
									array12[num6] = qf[num6] - num3;
								}
							}
							else
							{
								array12 = qf;
							}
							this.m_ui = m2(array12);
						}
						else if (x8())
						{
							int num23 = num;
							for (int num6 = 0; num6 <= num23; num6++)
							{
								float num20 = (float)(qf[num6] - (double)this.m_xb[num6]);
								A_0[num6] = A_0[num6] - (double)this.m_xa[num6] - array[num6];
								if (num20 > A_1)
								{
									A_1 = num20;
								}
							}
						}
						else
						{
							int num24 = num;
							for (int num6 = 0; num6 <= num24; num6++)
							{
								float num20 = (float)(qf[num6] - (double)this.m_xb[num6]);
								A_0[num6] -= (double)this.m_xa[num6];
								if (num20 > A_1)
								{
									A_1 = num20;
								}
							}
						}
					}
					else if (flag)
					{
						if (t1)
						{
							int num25 = num;
							for (int num6 = 0; num6 <= num25; num6++)
							{
								A_0[num6] -= num4;
							}
						}
					}
					else if (x8())
					{
						int num26 = num;
						for (int num6 = 0; num6 <= num26; num6++)
						{
							A_0[num6] = A_0[num6] - (double)this.m_xa[num6] - array[num6];
						}
					}
					else if (A_17 != null)
					{
						int num27 = num;
						for (int num6 = 0; num6 <= num27; num6++)
						{
							A_0[num6] -= (double)(this.m_xa[num6] * A_17[num6]);
						}
					}
					else
					{
						int num28 = num;
						for (int num6 = 0; num6 <= num28; num6++)
						{
							A_0[num6] -= (double)this.m_xa[num6];
						}
					}
				}
				else
				{
					int num29 = num;
					for (int num6 = 0; num6 <= num29; num6++)
					{
						A_0[num6] = qf[num6];
					}
					if (flag8 && !flag2)
					{
						p9(A_0, qg);
					}
				}
				if (flag8 && (p9(sq, flag11) || flag2 || flag) && !A_3)
				{
					if (flag)
					{
						double num30 = td();
						if (A_4)
						{
							if (opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.Transmittance)
							{
								int num31 = num;
								for (int num6 = 0; num6 <= num31; num6++)
								{
									A_0[num6] = this.m_w9[num6] * (num30 * A_0[num6] - (double)this.m_xa[num6]) / (double)(this.m_w3[num6] - this.m_xa[num6]);
								}
							}
							else if (x8())
							{
								int num32 = num;
								for (int num6 = 0; num6 <= num32; num6++)
								{
									A_0[num6] = this.m_w9[num6] * (num30 * A_0[num6] - array2[num6]);
									A_0[num6] /= this.m_xf[num6] * this.m_xa[num6];
								}
							}
							else
							{
								int num33 = num;
								for (int num6 = 0; num6 <= num33; num6++)
								{
									A_0[num6] = this.m_w9[num6] * (num30 * A_0[num6] - (double)this.m_w2[num6]) / (double)this.m_w2[num6];
								}
							}
						}
						else
						{
							int num34 = num;
							for (int num6 = 0; num6 <= num34; num6++)
							{
								A_0[num6] = this.m_w9[num6] * (num30 * A_0[num6] - (double)this.m_w2[num6]) / (double)this.m_w2[num6];
							}
						}
					}
					else if (flag2)
					{
						if (!this.m_v5 && this.m_v4)
						{
							int num35 = num;
							for (int num6 = 0; num6 <= num35; num6++)
							{
								A_0[num6] *= this.m_w4 / ((double)this.m_w2[num6] * sq);
								A_0[num6] /= this.m_v6[num6];
							}
						}
						else
						{
							int num36 = num;
							for (int num6 = 0; num6 <= num36; num6++)
							{
								A_0[num6] *= this.m_w4 / ((double)this.m_w2[num6] * sq);
							}
						}
					}
					else
					{
						if (A_16 != null)
						{
							if (flag10 || this.m_xg != A_18 || this.m_xh != A_19 || this.m_xi != A_20)
							{
								this.m_xj = new float[num + 1];
								int num37 = num;
								for (int num6 = 0; num6 <= num37; num6++)
								{
									this.m_xj[num6] = this.m_w5[num6] / (A_16[num6] * this.m_w2[num6]);
								}
								this.m_xg = A_18;
								this.m_xh = A_19;
								this.m_xi = A_20;
							}
						}
						else if (flag10 || this.m_xi != A_20)
						{
							this.m_xj = new float[num + 1];
							int num38 = num;
							for (int num6 = 0; num6 <= num38; num6++)
							{
								this.m_xj[num6] = this.m_w5[num6] / this.m_w2[num6];
							}
							this.m_xi = A_20;
						}
						int num39 = num;
						for (int num6 = 0; num6 <= num39; num6++)
						{
							A_0[num6] *= (double)this.m_xj[num6];
						}
						if (opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.TransCurved)
						{
							p9(qi, qj);
							float[] array13;
							float[] array14;
							float fWTransCurvedCorrection;
							int num40;
							unchecked
							{
								array13 = qq[(int)opticsConfigSubmoduleTypes][0].z();
								array14 = ((!flag7) ? qq[(int)opticsConfigSubmoduleTypes][0].z() : qq[(int)opticsConfigSubmoduleTypes][0].aa());
								fWTransCurvedCorrection = this.m_m2.FWTransCurvedCorrection;
								num40 = num;
							}
							for (int num6 = 0; num6 <= num40; num6++)
							{
								A_0[num6] *= 1.0 - (double)fWTransCurvedCorrection * (qi[num6] - (double)array13[num6]) / (double)array14[num6];
							}
						}
					}
					float[] array15;
					int num41;
					unchecked
					{
						if (qr[(int)opticsConfigSubmoduleTypes])
						{
							hr.r(tx, ty, q2, A_0, this.m_p9, A_5: false);
							A_10 = true;
							A_11 = tx;
							A_12 = ty;
						}
						else
						{
							A_10 = false;
						}
						if (opticsConfigSubmoduleTypes != g2.OpticsConfigSubmoduleTypes.ReflectanceProbe || array3 == null)
						{
							return;
						}
						array15 = this.m_wo[(int)opticsConfigSubmoduleTypes];
						num41 = num;
					}
					for (int num6 = 0; num6 <= num41; num6++)
					{
						if (A_0[num6] > 0.0 && A_0[num6] < 2.0)
						{
							A_0[num6] = (double)array15[num6] * (-1.0 + Math.Sqrt(1.0 + (double)(4f * array3[num6]) * A_0[num6]));
						}
					}
				}
				else
				{
					A_10 = false;
				}
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception a_2 = ex4;
				ab8().c(fz.b.b, "Exception caught in USBSpectrometerDevice.TransformData(). ", a_2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private new void m2(float[] A_0, ref float[] A_1, ref float[] A_2)
	{
		checked
		{
			int num = this.m_p9 - 1;
			bool flag = true;
			int num2 = num;
			int num4 = default(int);
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (A_0[num3] <= 0f)
				{
					flag = false;
					num4 = num3;
					break;
				}
			}
			if (flag)
			{
				A_1 = A_0;
				A_2 = A_0;
				return;
			}
			if (A_1 == null || A_1.GetUpperBound(0) != num)
			{
				A_1 = new float[num + 1];
			}
			if (A_2 == null || A_2.GetUpperBound(0) != num)
			{
				A_2 = new float[num + 1];
			}
			int num5 = num4 - 1;
			for (int num6 = 0; num6 <= num5; num6++)
			{
				float num7 = A_0[num6];
				A_2[num6] = num7;
				A_1[num6] = num7;
			}
			int num8 = num4;
			int num9 = num;
			for (int num10 = num8; num10 <= num9; num10++)
			{
				float num7 = A_0[num10];
				A_2[num10] = num7;
				if (num7 <= 0f)
				{
					A_1[num10] = 1f;
				}
				else
				{
					A_1[num10] = num7;
				}
			}
		}
	}

	private new void m2(float[] A_0, float[] A_1, bool A_2, ref float[] A_3, ref float[] A_4)
	{
		if (A_2)
		{
			m2(A_0, ref A_3, ref A_4);
		}
		else
		{
			m2(A_1, ref A_3, ref A_4);
		}
	}

	private new void m2()
	{
		b b10 = this.m_ti;
		if (ry == null)
		{
			return;
		}
		int upperBound = ry.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (!m2(r5, ry[num].j) && (b10.s() == global::h.MeasurementTimingType.Manual || r5 < ry[num].j || ry[num].p))
			{
				ry[num].ad();
			}
		}
		b10 = null;
	}

	private new void m2(int A_0)
	{
		_ = this.m_ti;
		int upperBound = ry.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (num != A_0 && !m2(sq, ry[num].j))
			{
				ry[num].ad();
			}
		}
		_ = null;
	}

	private void sm(DateTime A_0)
	{
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
		if (ry != null || qq[(int)opticsConfigSubmoduleTypes] == null)
		{
			return;
		}
		bool flag = true;
		int upperBound = qq[(int)opticsConfigSubmoduleTypes].GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			iq a_ = null;
			if (!qq[(int)opticsConfigSubmoduleTypes][num].u() || (!m2(sq, qq[(int)opticsConfigSubmoduleTypes][num].j) && opticsConfigSubmoduleTypes != g2.OpticsConfigSubmoduleTypes.CTMProbe) || (!m2(A_0, a_) && opticsConfigSubmoduleTypes != g2.OpticsConfigSubmoduleTypes.CTMProbe))
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			ry = qq[(int)opticsConfigSubmoduleTypes];
			r9 = this.m_tj.l();
			sa = qy[(int)opticsConfigSubmoduleTypes];
			sb = q6[(int)opticsConfigSubmoduleTypes];
			sg = qz[(int)opticsConfigSubmoduleTypes];
			sh = qr[(int)opticsConfigSubmoduleTypes];
		}
	}

	private void sj(DateTime A_0)
	{
		if (this.m_ti.k() != g2.OpticsConfigSubmoduleTypes.CTMProbe || sv.Count != 0 || !m2(A_0, null))
		{
			return;
		}
		foreach (float[] item in rn)
		{
			sv.Add(item);
		}
		foreach (float[] item2 in ro)
		{
			sw.Add(item2);
		}
		foreach (double item3 in rp)
		{
			sx.Add(item3);
		}
	}

	private void p9(int A_0, bool A_1)
	{
		_ = this.m_ti;
		if (rz != null)
		{
			if (A_1)
			{
				if (!m2(se, this.m_t5))
				{
					rz = null;
					r0 = null;
				}
			}
			else if (!m2(se, ry[A_0].j))
			{
				rz = null;
				r0 = null;
			}
		}
		_ = null;
	}

	private void qh(DateTime A_0)
	{
		if (rz == null)
		{
			g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
			iq a_ = null;
			if ((m2(sq, q9[(int)opticsConfigSubmoduleTypes]) && m2(A_0, a_)) || opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.CTMProbe)
			{
				rz = qs[(int)opticsConfigSubmoduleTypes];
				r0 = qu[(int)opticsConfigSubmoduleTypes];
				r8 = this.m_tj.m();
				sc = q7[(int)opticsConfigSubmoduleTypes];
				se = q9[(int)opticsConfigSubmoduleTypes];
			}
		}
	}

	private new void m2(int A_0, bool A_1)
	{
		_ = this.m_ti;
		if (r1 != null)
		{
			if (A_1)
			{
				if (!m2(sf, this.m_t5))
				{
					r1 = null;
					r2 = null;
				}
			}
			else if (!m2(sf, ry[A_0].j))
			{
				r1 = null;
				r2 = null;
			}
		}
		_ = null;
	}

	private void p9(DateTime A_0)
	{
		if (r1 == null)
		{
			g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
			iq a_ = null;
			if (this.m_m2.IntTimesEqual(sq, ra[(int)opticsConfigSubmoduleTypes]) != 0 && m2(A_0, a_))
			{
				r1 = qv[(int)opticsConfigSubmoduleTypes];
				r2 = qw[(int)opticsConfigSubmoduleTypes];
				sd = q8[(int)opticsConfigSubmoduleTypes];
				sf = ra[(int)opticsConfigSubmoduleTypes];
			}
		}
	}

	private new void m2(DateTime A_0)
	{
		iq a_ = null;
		g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_ti.k();
		if (r3 == null && (m2(A_0, a_) || opticsConfigSubmoduleTypes == g2.OpticsConfigSubmoduleTypes.CTMProbe))
		{
			r3 = rc[(int)opticsConfigSubmoduleTypes];
			r4 = rd[(int)opticsConfigSubmoduleTypes];
			r6 = rb[(int)opticsConfigSubmoduleTypes];
			r5 = re[(int)opticsConfigSubmoduleTypes];
			this.m_st = rl[(int)opticsConfigSubmoduleTypes];
		}
	}

	public void yi()
	{
		checked
		{
			int num;
			if (t1 && p9(A_0: false))
			{
				num = 0;
				do
				{
					if (num != 2 && num != 3 && num != 9)
					{
						p9(unchecked((g2.OpticsConfigSubmoduleTypes)num), (int)Math.Round(this.m_us));
					}
					num++;
				}
				while (num <= 10);
			}
			else
			{
				num = 0;
				do
				{
					if (num != 2 && num != 3 && num != 9)
					{
						p9(unchecked((g2.OpticsConfigSubmoduleTypes)num), 0);
					}
					num++;
				}
				while (num <= 10);
			}
			if (this.m_uw == null)
			{
				this.m_uw = new double[this.m_p9 - 1 + 1, 2000];
				this.m_u0 = new double[this.m_p9 - 1 + 1];
				this.m_u3 = new bool[2000];
				this.m_u4 = new float[2000];
				this.m_u2 = new double[2000];
				this.m_u5 = new float[2000];
			}
			num = 0;
			do
			{
				this.m_um[num] = null;
				num++;
			}
			while (num <= 10);
			this.m_up = false;
		}
	}

	protected override void bd()
	{
		base.bd();
		m2(ref mc, ref md);
	}

	protected new void m2(ref int A_0, ref string A_1)
	{
		if (this.m_m2.eSpectromType == FMUSBDeviceType.FIUSB2DeviceSpecTCNIR)
		{
			if (abk().CheckFan2Status(out var fanIsTurning) != 0)
			{
				A_0 = 1;
				A_1 = s8(A_0);
			}
			if (fanIsTurning == 0)
			{
				A_0 = 2;
				A_1 = s8(A_0);
			}
		}
	}

	protected override string be()
	{
		return s8(mc);
	}

	protected string s8(int A_0)
	{
		if (A_0 == 2)
		{
			return "Heat sink cooling fan failure";
		}
		return "Unknown hardware failure";
	}

	private void yj()
	{
		m2(A_0: true);
		GC.SuppressFinalize(this);
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in yj
		this.yj();
	}

	private new void m2(bool A_0)
	{
		if (!this.m_wq)
		{
			if (!this.m_v8 && !s.a)
			{
				yg();
			}
			this.m_wq = true;
		}
	}

	~ip()
	{
		m2(A_0: false);
		base.Finalize();
	}
}
