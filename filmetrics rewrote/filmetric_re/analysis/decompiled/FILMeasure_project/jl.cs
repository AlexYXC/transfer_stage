using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

internal class jl
{
	public enum a
	{
		a = 1,
		b,
		c,
		d
	}

	public enum b
	{
		a = 1,
		b
	}

	public class c
	{
		public ReadOnlyCollection<float> a;

		public ReadOnlyCollection<ReadOnlyCollection<float>> b;

		public ReadOnlyCollection<long> c;

		public string d;

		public ReadOnlyCollection<long> e;

		public ReadOnlyCollection<float> f;

		public b g;

		public r.d.a.b h;

		public c(r.d.a.b A_0)
		{
			h = A_0;
		}

		public c(ReadOnlyCollection<float> A_0, ReadOnlyCollection<ReadOnlyCollection<float>> A_1, ReadOnlyCollection<long> A_2, ReadOnlyCollection<long> A_3, ReadOnlyCollection<float> A_4, b A_5, r.d.a.b A_6, string A_7)
		{
			a = A_0;
			b = A_1;
			c = A_2;
			e = A_3;
			f = A_4;
			g = A_5;
			h = A_6;
			d = A_7;
		}
	}

	public delegate void d(c A_0);

	public delegate void e(d A_0);

	public delegate void f(int A_0, ReadOnlyCollection<float> A_1, ReadOnlyCollection<float> A_2, r.d.a.b A_3);

	public delegate void g(f A_0);

	public delegate void h(ReadOnlyCollection<float> A_0, ReadOnlyCollection<float> A_1, long A_2, long A_3, float A_4, jm A_5, string A_6, hg A_7, bool A_8, r.d.a.b A_9);

	public delegate void i(h A_0);

	public enum j
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

	private const int m_a = 2;

	private const int m_b = 32766;

	private const int m_c = 1;

	private int[] m_d;

	private double[,] m_e;

	private double[,] m_f;

	private float[] m_g;

	private float[] m_h;

	private int m_i;

	private const int m_j = 1;

	private short k;

	private short m_l;

	private fz m_m;

	private string m_n;

	private jm m_o;

	private jn m_p;

	private static int m_q;

	private static object m_r;

	public const string s = ".erf";

	public const string t = ".vst";

	public const string u = ".csv";

	public const string v = ".fivst";

	public const string w = ".txt";

	[CompilerGenerated]
	private d x;

	[CompilerGenerated]
	private f y;

	[CompilerGenerated]
	private h z;

	[CompilerGenerated]
	private string aa;

	[CompilerGenerated]
	private string ab;

	[CompilerGenerated]
	private b ac;

	[SpecialName]
	private static string[] ad;

	[SpecialName]
	private static string[] ae;

	static jl()
	{
		jl.m_r = RuntimeHelpers.GetObjectValue(new object());
	}

	[DllImport("FIParErf.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ErfParseFileToTemp([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_1, ref double A_2);

	[DllImport("FIParErf.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void ErfParseTempFile([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0, [Out][MarshalAs(UnmanagedType.SafeArray)] float[] A_1, [Out][MarshalAs(UnmanagedType.SafeArray)] float[] A_2, int A_3);

	[DllImport("fm_via.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short AAdvisor(ref float A_0, ref float A_1, short A_2, ref short A_3, ref float A_4, ref float A_5, ref float A_6, ref float A_7, ref short A_8, ref float A_9);

	[DllImport("fm_via.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short AGetRSubstrate(ref float A_0, float A_1, float A_2, float A_3);

	[SpecialName]
	[CompilerGenerated]
	public void l(d A_0)
	{
		d d10 = x;
		d d11;
		do
		{
			d11 = d10;
			d value = (d)Delegate.Combine(d11, A_0);
			d10 = Interlocked.CompareExchange(ref x, value, d11);
		}
		while ((object)d10 != d11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void m(d A_0)
	{
		d d10 = x;
		d d11;
		do
		{
			d11 = d10;
			d value = (d)Delegate.Remove(d11, A_0);
			d10 = Interlocked.CompareExchange(ref x, value, d11);
		}
		while ((object)d10 != d11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void l(f A_0)
	{
		f f10 = y;
		f f11;
		do
		{
			f11 = f10;
			f value = (f)Delegate.Combine(f11, A_0);
			f10 = Interlocked.CompareExchange(ref y, value, f11);
		}
		while ((object)f10 != f11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void m(f A_0)
	{
		f f10 = y;
		f f11;
		do
		{
			f11 = f10;
			f value = (f)Delegate.Remove(f11, A_0);
			f10 = Interlocked.CompareExchange(ref y, value, f11);
		}
		while ((object)f10 != f11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void l(h A_0)
	{
		h h10 = z;
		h h11;
		do
		{
			h11 = h10;
			h value = (h)Delegate.Combine(h11, A_0);
			h10 = Interlocked.CompareExchange(ref z, value, h11);
		}
		while ((object)h10 != h11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void m(h A_0)
	{
		h h10 = z;
		h h11;
		do
		{
			h11 = h10;
			h value = (h)Delegate.Remove(h11, A_0);
			h10 = Interlocked.CompareExchange(ref z, value, h11);
		}
		while ((object)h10 != h11);
	}

	private float l(float A_0)
	{
		return (float)(3.39108 + 5.7972 * (double)A_0 - 34.6946 * (double)A_0 * (double)A_0 + 124.693 * (double)A_0 * (double)A_0 * (double)A_0 - 154.634 * (double)A_0 * (double)A_0 * (double)A_0 * (double)A_0);
	}

	private static int p()
	{
		object obj = jl.m_r;
		ObjectFlowControl.CheckForSyncLockOnValueType(obj);
		bool lockTaken = false;
		checked
		{
			int result;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				result = jl.m_q;
				if (jl.m_q < int.MaxValue)
				{
					jl.m_q++;
				}
				else
				{
					jl.m_q = 0;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
				}
			}
			return result;
		}
	}

	[SpecialName]
	public int m(long A_0)
	{
		checked
		{
			int num = this.m_p.d.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (this.m_p.d[num2] == A_0)
				{
					return num2;
				}
			}
			return -1;
		}
	}

	[SpecialName]
	public jm q()
	{
		return this.m_o;
	}

	public static bool o(b A_0)
	{
		return n(A_0);
	}

	public static bool n(b A_0)
	{
		if (A_0 < jl.b.a || A_0 > jl.b.b)
		{
			A_0 = jl.b.b;
		}
		return A_0 == jl.b.b;
	}

	[SpecialName]
	public float n(long A_0)
	{
		int num = l(A_0);
		if (num >= 0)
		{
			return this.m_p.f[num];
		}
		return 0f;
	}

	[SpecialName]
	public List<float> r()
	{
		return this.m_p.f;
	}

	[SpecialName]
	private ReadOnlyCollection<float> o()
	{
		return this.m_p.b.AsReadOnly();
	}

	[SpecialName]
	private int n()
	{
		if (this.m_p == null || this.m_p.b == null)
		{
			return 0;
		}
		return this.m_p.b.Count;
	}

	[SpecialName]
	private int m()
	{
		return checked(n() - 1);
	}

	[SpecialName]
	public jn s()
	{
		return this.m_p;
	}

	[SpecialName]
	[CompilerGenerated]
	public string t()
	{
		return aa;
	}

	[SpecialName]
	[CompilerGenerated]
	public void l(string A_0)
	{
		aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public string u()
	{
		return ab;
	}

	[SpecialName]
	[CompilerGenerated]
	public void m(string A_0)
	{
		ab = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public b v()
	{
		return ac;
	}

	[SpecialName]
	[CompilerGenerated]
	public void p(b A_0)
	{
		ac = A_0;
	}

	[SpecialName]
	private bool l()
	{
		return l(this.m_p.f.AsReadOnly());
	}

	[SpecialName]
	public static bool l(ReadOnlyCollection<float> A_0)
	{
		foreach (float item in A_0)
		{
			if (item != A_0[0])
			{
				return false;
			}
		}
		return true;
	}

	public jl(fz A_0)
	{
		this.m_m = A_0;
	}

	public void l(DateTime A_0, List<float> A_1, r.d.a.b A_2)
	{
		checked
		{
			if (this.m_p.b == null || this.m_p.c == null || this.m_p.c.Count != A_1.Count)
			{
				this.m_p.b = new List<float>();
				this.m_p.c = new Collection<List<float>>();
				int num = A_1.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					this.m_p.c.Add(new List<float>());
				}
				this.m_p.a = A_0;
			}
			this.m_p.b.Add((float)A_0.Subtract(this.m_p.a).TotalSeconds);
			this.m_p.g = t();
			int num3 = A_1.Count - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				this.m_p.c[num4].Add(A_1[num4]);
			}
			l(A_2);
		}
	}

	public void l(r.d.a.b A_0)
	{
		List<ReadOnlyCollection<float>> list = new List<ReadOnlyCollection<float>>();
		foreach (List<float> item in this.m_p.c)
		{
			list.Add(item.AsReadOnly());
		}
		x?.Invoke(new c(this.m_p.b.AsReadOnly(), list.AsReadOnly(), this.m_p.d.AsReadOnly(), this.m_p.e.AsReadOnly(), this.m_p.f.AsReadOnly(), v(), A_0, this.m_p.g));
	}

	private void l(List<float> A_0, List<float> A_1, jf.a A_2, float A_3, ref List<float> A_4, ref List<float> A_5, ref string A_6)
	{
		A_4 = new List<float>();
		A_5 = new List<float>();
		List<float> list = A_1;
		int num = m();
		for (int num2 = 0; num2 <= num; num2 = checked(num2 + 1))
		{
			if (this.m_p.b[num2] >= A_2.e() && this.m_p.b[num2] <= A_2.f() && list[num2] >= A_2.g() && list[num2] <= A_2.h())
			{
				A_4.Add(this.m_p.b[num2]);
				float num3 = list[num2] * A_3;
				A_5.Add(num3);
				if (((double)num3 < -0.1) | ((double)num3 > 1.2))
				{
					A_6 = "Invalid refractive index.";
					return;
				}
			}
		}
		list = null;
		if (A_4.Count == 0)
		{
			A_6 = "No analysis performed. Selected analysis area has no data.";
		}
	}

	private void l(int A_0, jf.a A_1, ref float A_2, ref float A_3)
	{
		A_2 = float.MaxValue;
		A_3 = float.MinValue;
		List<float> list = this.m_p.c[A_0];
		int num = m();
		for (int num2 = 0; num2 <= num; num2 = checked(num2 + 1))
		{
			if (this.m_p.b[num2] >= A_1.e() && this.m_p.b[num2] <= A_1.f() && list[num2] >= A_1.g() && list[num2] <= A_1.h())
			{
				if (list[num2] < A_2)
				{
					A_2 = list[num2];
				}
				if (list[num2] > A_3)
				{
					A_3 = list[num2];
				}
			}
		}
		list = null;
	}

	private int l(long A_0)
	{
		return this.m_p.d.IndexOf(A_0);
	}

	public void l(jf.a A_0, hg A_1, long A_2, r.d.a.b A_3, ref string A_4)
	{
		short[] array = new short[9];
		float[] array2 = new float[9];
		jm jm2 = new jm();
		jk jk2 = A_1.b9();
		this.m_o = null;
		if (jk2.b == 1f)
		{
			A_4 = "Refractive index of material can not be exactly 1.";
			return;
		}
		if (jk2.b == 0f)
		{
			A_4 = "Refractive index of material can not be 0.";
			return;
		}
		int num = l(A_2);
		if (num < 0)
		{
			A_4 = "Selected data does not exist in module";
			return;
		}
		if (this.m_p.f[num] <= 0f)
		{
			A_4 = "Wavelength must be greater than 0.";
			return;
		}
		int num2 = 0;
		checked
		{
			do
			{
				array[num2] = 1;
				array2[num2] = 0f;
				num2++;
			}
			while (num2 <= 7);
			array[2] = 0;
			array2[2] = jk2.b;
			array[5] = 0;
			array2[5] = this.m_p.f[num];
			array[7] = 0;
			float num3 = 1f;
			float A_5 = default(float);
			float A_6 = default(float);
			l(num, A_0, ref A_5, ref A_6);
			num3 = (jk2.b - 1f) / (jk2.b + 1f);
			num3 *= num3;
			num3 /= 0.5f * (A_6 + A_5);
			List<float> A_7 = new List<float>();
			List<float> A_8 = new List<float>();
			l(this.m_p.b, this.m_p.c[num], A_0, num3, ref A_7, ref A_8, ref A_4);
			if (!string.IsNullOrEmpty(A_4))
			{
				return;
			}
			float[] array3 = new float[A_7.Count - 1 + 1];
			float[] array4 = new float[A_7.Count - 1 + 1];
			float[] array5 = new float[9];
			short A_9 = default(short);
			int num4 = AAdvisor(ref A_7.ToArray()[0], ref A_8.ToArray()[0], (short)A_7.Count, ref array[0], ref array2[0], ref array3[0], ref jm2.a[0], ref array5[0], ref A_9, ref array4[0]);
			num2 = (int)Math.Round((double)num2 / 0.5);
			num2++;
			if (num4 == 0)
			{
				num3 = ((jk2.b - 1f) * (jk2.b - 1f) + jm2.a[3] * jm2.a[3]) / ((jk2.b + 1f) * (jk2.b + 1f) + jm2.a[3] * jm2.a[3]);
				num3 /= 0.5f * (A_6 + A_5);
				A_7 = new List<float>();
				A_8 = new List<float>();
				l(this.m_p.b, this.m_p.c[num], A_0, num3, ref A_7, ref A_8, ref A_4);
				if (!string.IsNullOrEmpty(A_4))
				{
					return;
				}
				num4 = AAdvisor(ref A_7.ToArray()[0], ref A_8.ToArray()[0], (short)A_7.Count, ref array[0], ref array2[0], ref array3[0], ref jm2.a[0], ref array5[0], ref A_9, ref array4[0]);
			}
			if (num4 == 0 || num4 == 4)
			{
				A_4 = null;
				jm2.f(A_7.Count);
				this.m_o = jm2;
				l(A_7, array4, num3, num, A_1, A_5: false, A_3);
				if (num4 == 4)
				{
					A_4 = "Least-squares routine convergence poor.";
				}
				else
				{
					A_4 = null;
				}
				return;
			}
			n(A_3);
			switch (num4)
			{
			case 1:
				A_4 = "Less than seven data points in segment.";
				break;
			case 2:
				A_4 = "R'(t(0)) estimating routine failed.";
				break;
			case 3:
				A_4 = "Two inflection points in data required.";
				break;
			}
		}
	}

	private void l(List<float> A_0, float[] A_1, float A_2, int A_3, hg A_4, bool A_5, r.d.a.b A_6)
	{
		string text = ((this.m_n == null) ? t() : this.m_n);
		List<float> list = new List<float>();
		checked
		{
			int num = A_0.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				list.Add(A_1[num2] / A_2);
			}
			string a_ = (l() ? (text + "-" + (A_3 + 1) + " Calculated") : (text + "-" + this.m_p.f[A_3] + " Calculated"));
			jn jn2 = this.m_p;
			z?.Invoke(A_0.AsReadOnly(), list.AsReadOnly(), jn2.d[A_3], jn2.e[A_3], jn2.f[A_3], this.m_o, a_, A_4, A_5, A_6);
			jn2 = null;
		}
	}

	public void l(jf.a A_0, hg A_1, long A_2, bool A_3, r.d.a.b A_4, ref string A_5)
	{
		int try0000_dispatch = -1;
		checked
		{
			int num2 = default(int);
			short[] array = default(short[]);
			int num = default(int);
			int num3 = default(int);
			float[] array2 = default(float[]);
			short num5 = default(short);
			jm jm2 = default(jm);
			jk jk2 = default(jk);
			float[] array3 = default(float[]);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			List<float> A_6 = default(List<float>);
			List<float> A_7 = default(List<float>);
			float num9 = default(float);
			float[] array4 = default(float[]);
			float A_8 = default(float);
			float A_9 = default(float);
			float A_10 = default(float);
			float num10 = default(float);
			float num11 = default(float);
			float a_ = default(float);
			float[] array5 = default(float[]);
			short A_11 = default(short);
			short num12 = default(short);
			float num13 = default(float);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						num2 = 1;
						array = new short[9];
						goto IL_000a;
					case 2265:
						{
							num = num2;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num + 1);
							num = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000a;
							case 3:
								goto IL_0015;
							case 4:
								goto IL_001a;
							case 5:
								goto IL_0023;
							case 6:
								goto IL_002d;
							case 7:
								goto IL_0038;
							case 8:
								goto IL_0041;
							case 9:
								goto IL_0047;
							case 10:
								goto IL_0053;
							case 11:
								goto IL_005f;
							case 12:
								goto IL_0070;
							case 14:
								goto IL_0080;
							case 15:
								goto IL_00b5;
							case 16:
								goto IL_00bc;
							case 18:
								goto IL_00c9;
							case 21:
								goto IL_00d9;
							case 22:
								goto IL_00f5;
							case 17:
							case 20:
							case 24:
								goto IL_0105;
							case 25:
								goto IL_010b;
							case 26:
								goto IL_0113;
							case 27:
								goto IL_0120;
							case 28:
								goto IL_012e;
							case 29:
								goto IL_013d;
							case 30:
								goto IL_0157;
							case 32:
								goto IL_0167;
							case 33:
								goto IL_016e;
							case 35:
								goto IL_0193;
							case 37:
								goto IL_01a3;
							case 39:
								goto IL_01ca;
							case 41:
								goto IL_01d8;
							case 34:
							case 36:
							case 38:
							case 40:
							case 42:
							case 43:
								goto IL_01fd;
							case 44:
								goto IL_0209;
							case 45:
								goto IL_0210;
							case 46:
								goto IL_021e;
							case 47:
								goto IL_022a;
							case 48:
								goto IL_0231;
							case 49:
								goto IL_023f;
							case 50:
								goto IL_0246;
							case 51:
								goto IL_025f;
							case 52:
								goto IL_026b;
							case 53:
								goto IL_0272;
							case 54:
								goto IL_0280;
							case 55:
								goto IL_0287;
							case 56:
								goto IL_029a;
							case 57:
								goto IL_02b1;
							case 58:
								goto IL_02bd;
							case 59:
								goto IL_02c7;
							case 60:
								goto IL_02d1;
							case 61:
								goto IL_02db;
							case 62:
								goto IL_02f1;
							case 63:
								goto IL_0306;
							case 64:
								goto IL_0316;
							case 65:
								goto IL_0320;
							case 66:
								goto IL_0329;
							case 67:
								goto IL_0333;
							case 68:
								goto IL_033c;
							case 69:
								goto IL_034e;
							case 70:
								goto IL_0355;
							case 72:
								goto IL_0365;
							case 73:
								goto IL_0378;
							case 74:
								goto IL_03a7;
							case 76:
								goto IL_03b7;
							case 77:
								goto IL_03b9;
							case 78:
								goto IL_03ce;
							case 79:
								goto IL_03e3;
							case 80:
								goto IL_0445;
							case 81:
								goto IL_044c;
							case 82:
								goto IL_0456;
							case 83:
								goto IL_0468;
							case 84:
								goto IL_046f;
							case 85:
								goto IL_047b;
							case 87:
								goto IL_048b;
							case 88:
							case 89:
								goto IL_04a5;
							case 90:
								goto IL_04b3;
							case 91:
								goto IL_04ba;
							case 92:
								goto IL_04c7;
							case 93:
								goto IL_04d4;
							case 94:
								goto IL_04dd;
							case 95:
								goto IL_04ef;
							case 96:
								goto IL_0502;
							case 97:
								goto IL_050c;
							case 98:
								goto IL_0516;
							case 99:
								goto IL_0545;
							case 101:
								goto IL_0555;
							case 102:
								goto IL_05b7;
							case 103:
								goto IL_05be;
							case 104:
								goto IL_05c8;
							case 105:
								goto IL_05da;
							case 106:
								goto IL_05e1;
							case 107:
								goto IL_05ed;
							case 109:
								goto IL_05fd;
							case 110:
								goto IL_0607;
							case 111:
								goto IL_062c;
							case 112:
								goto IL_0638;
							case 113:
								goto IL_0649;
							case 114:
								goto IL_0654;
							case 115:
								goto IL_0669;
							case 116:
								goto IL_0671;
							case 118:
								goto IL_067e;
							case 120:
								goto IL_0687;
							case 121:
								goto IL_068f;
							case 123:
								goto IL_069c;
							case 124:
								goto IL_06a4;
							case 126:
								goto IL_06b1;
							case 127:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 13:
							case 19:
							case 23:
							case 31:
							case 71:
							case 75:
							case 86:
							case 100:
							case 108:
							case 117:
							case 119:
							case 122:
							case 125:
							case 128:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_06a4:
						num2 = 124;
						A_5 = "R'(t(0)) estimating routine failed.";
						goto end_IL_0000_3;
						IL_000a:
						num2 = 2;
						array2 = new float[9];
						goto IL_0015;
						IL_0015:
						num2 = 3;
						num5 = 1;
						goto IL_001a;
						IL_001a:
						num2 = 4;
						jm2 = new jm();
						goto IL_0023;
						IL_0023:
						num2 = 5;
						jk2 = A_1.b9();
						goto IL_002d;
						IL_002d:
						num2 = 6;
						array3 = new float[9];
						goto IL_0038;
						IL_0038:
						num2 = 7;
						this.m_o = null;
						goto IL_0041;
						IL_0041:
						num2 = 8;
						A_5 = null;
						goto IL_0047;
						IL_0047:
						num2 = 9;
						num6 = l(A_2);
						goto IL_0053;
						IL_0053:
						num2 = 10;
						if (jk2.d != 0)
						{
							goto IL_005f;
						}
						goto IL_00d9;
						IL_005f:
						num2 = 11;
						if (jk2.c < 400f)
						{
							goto IL_0070;
						}
						goto IL_0080;
						IL_0070:
						num2 = 12;
						A_5 = "Temperature must be greater than 400C when material is specified.";
						goto end_IL_0000_3;
						IL_0080:
						num2 = 14;
						if (this.m_p.f[num6] < 550f || this.m_p.f[num6] > 670f)
						{
							goto IL_00b5;
						}
						goto IL_0105;
						IL_06b1:
						num2 = 126;
						if (num7 != 3)
						{
							goto end_IL_0000_3;
						}
						break;
						IL_00b5:
						num2 = 15;
						if (A_3)
						{
							goto IL_00bc;
						}
						goto IL_00c9;
						IL_00bc:
						num2 = 16;
						A_5 = "I'll let you use a wavelength outside 550-670, but I don't like it";
						goto IL_0105;
						IL_00c9:
						num2 = 18;
						A_5 = "Wavelength must be between 550 nm and 670 nm.";
						goto end_IL_0000_3;
						IL_00d9:
						num2 = 21;
						if (this.m_p.f[num6] <= 0f)
						{
							goto IL_00f5;
						}
						goto IL_0105;
						IL_00f5:
						num2 = 22;
						A_5 = "Wavelength must be greater than 0 nm.";
						goto end_IL_0000_3;
						IL_0105:
						num2 = 24;
						num8 = 0;
						goto IL_010b;
						IL_010b:
						num2 = 25;
						array[num8] = 1;
						goto IL_0113;
						IL_0113:
						num2 = 26;
						array2[num8] = 0f;
						goto IL_0120;
						IL_0120:
						num2 = 27;
						num8++;
						if (num8 <= 7)
						{
							goto IL_010b;
						}
						goto IL_012e;
						IL_012e:
						num2 = 28;
						if (jk2.n)
						{
							goto IL_013d;
						}
						goto IL_01fd;
						IL_013d:
						num2 = 29;
						if (jk2.m == 0f && jk2.d == 0)
						{
							goto IL_0157;
						}
						goto IL_0167;
						IL_0638:
						num2 = 112;
						jm2.f(A_6.Count);
						goto IL_0649;
						IL_0157:
						num2 = 30;
						A_5 = "Value for n required.";
						goto end_IL_0000_3;
						IL_0167:
						num2 = 32;
						array[2] = 0;
						goto IL_016e;
						IL_016e:
						num2 = 33;
						switch (jk2.d)
						{
						case 0:
							break;
						case 1:
							goto IL_01a3;
						case 2:
							goto IL_01ca;
						case 3:
							goto IL_01d8;
						default:
							goto IL_01fd;
						}
						goto IL_0193;
						IL_01d8:
						num2 = 41;
						array2[2] = jk.r(jk2.c, this.m_p.f[num6]);
						goto IL_01fd;
						IL_01ca:
						num2 = 39;
						array2[2] = 3.8f;
						goto IL_01fd;
						IL_01a3:
						num2 = 37;
						array2[2] = jk.s(jk2.c, this.m_p.f[num6]);
						goto IL_01fd;
						IL_0193:
						num2 = 35;
						array2[2] = jk2.m;
						goto IL_01fd;
						IL_01fd:
						num2 = 43;
						if (jk2.p)
						{
							goto IL_0209;
						}
						goto IL_021e;
						IL_0209:
						num2 = 44;
						array[3] = 0;
						goto IL_0210;
						IL_0210:
						num2 = 45;
						array2[3] = jk2.o;
						goto IL_021e;
						IL_021e:
						num2 = 46;
						if (jk2.l)
						{
							goto IL_022a;
						}
						goto IL_023f;
						IL_022a:
						num2 = 47;
						array[4] = 0;
						goto IL_0231;
						IL_0231:
						num2 = 48;
						array2[4] = jk2.k;
						goto IL_023f;
						IL_023f:
						num2 = 49;
						array[5] = 0;
						goto IL_0246;
						IL_0246:
						num2 = 50;
						array2[5] = this.m_p.f[num6];
						goto IL_025f;
						IL_025f:
						num2 = 51;
						if (jk2.j)
						{
							goto IL_026b;
						}
						goto IL_0280;
						IL_026b:
						num2 = 52;
						array[6] = 0;
						goto IL_0272;
						IL_0272:
						num2 = 53;
						array2[6] = jk2.i;
						goto IL_0280;
						IL_0280:
						num2 = 54;
						array[7] = 0;
						goto IL_0287;
						IL_0287:
						num2 = 55;
						array2[7] = Math.Abs(jk2.e);
						goto IL_029a;
						IL_029a:
						num2 = 56;
						if (array2[7] != 0f && jk2.g)
						{
							goto IL_02b1;
						}
						goto IL_02bd;
						IL_0649:
						num2 = 113;
						this.m_o = jm2;
						goto IL_0654;
						IL_02b1:
						num2 = 57;
						array2[7] = 0f - array2[7];
						goto IL_02bd;
						IL_02bd:
						num2 = 58;
						A_6 = new List<float>();
						goto IL_02c7;
						IL_02c7:
						num2 = 59;
						A_7 = new List<float>();
						goto IL_02d1;
						IL_02d1:
						num2 = 60;
						num9 = 1f;
						goto IL_02db;
						IL_02db:
						num2 = 61;
						_ = this.m_p.c[num6];
						goto IL_02f1;
						IL_02f1:
						num2 = 62;
						if (jk2.h || jk2.d != 0)
						{
							goto IL_0306;
						}
						goto IL_0378;
						IL_0654:
						num2 = 114;
						l(A_6, array4, num9, num6, A_1, A_5: true, A_4);
						goto IL_0669;
						IL_0306:
						num2 = 63;
						l(num6, A_0, ref A_8, ref A_9);
						goto IL_0316;
						IL_0316:
						num2 = 64;
						A_10 = 0f;
						goto IL_0320;
						IL_0320:
						num2 = 65;
						num10 = array2[2];
						goto IL_0329;
						IL_0329:
						num2 = 66;
						num11 = 0f;
						goto IL_0333;
						IL_0333:
						num2 = 67;
						a_ = array2[7];
						goto IL_033c;
						IL_033c:
						num2 = 68;
						num7 = AGetRSubstrate(ref A_10, num10, num11, a_);
						goto IL_034e;
						IL_034e:
						num2 = 69;
						if (num7 != 0)
						{
							goto IL_0355;
						}
						goto IL_0365;
						IL_0355:
						num2 = 70;
						A_5 = "Error computing substrate reflectance";
						goto end_IL_0000_3;
						IL_0365:
						num2 = 72;
						num9 = A_10 / (0.5f * (A_8 + A_9));
						goto IL_0378;
						IL_0378:
						num2 = 73;
						l(this.m_p.b, this.m_p.c[num6], A_0, num9, ref A_6, ref A_7, ref A_5);
						goto IL_03a7;
						IL_03a7:
						num2 = 74;
						if (!string.IsNullOrEmpty(A_5))
						{
							goto end_IL_0000_3;
						}
						goto IL_03b7;
						IL_03b7:
						_ = null;
						goto IL_03b9;
						IL_03b9:
						num2 = 77;
						array5 = new float[A_6.Count - 1 + 1];
						goto IL_03ce;
						IL_03ce:
						num2 = 78;
						array4 = new float[A_6.Count - 1 + 1];
						goto IL_03e3;
						IL_03e3:
						num2 = 79;
						num7 = AAdvisor(ref A_6.ToArray()[0], ref A_7.ToArray()[0], (short)A_6.Count, ref array[0], ref array2[0], ref array5[0], ref jm2.a[0], ref array3[0], ref A_11, ref array4[0]);
						goto IL_0445;
						IL_0445:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_044c;
						IL_044c:
						num2 = 81;
						num12++;
						goto IL_0456;
						IL_0456:
						num2 = 82;
						_ = (float)((double)num12 * 300.1);
						goto IL_0468;
						IL_0468:
						ProjectData.ClearProjectError();
						num3 = 0;
						goto IL_046f;
						IL_046f:
						num2 = 84;
						if (num7 != 0 && num7 != 4)
						{
							goto IL_047b;
						}
						goto IL_048b;
						IL_0669:
						num2 = 115;
						if (num7 == 4)
						{
							goto IL_0671;
						}
						goto IL_067e;
						IL_047b:
						num2 = 85;
						A_5 = "Error in Data Analysis. Please select new data.";
						goto end_IL_0000_3;
						IL_048b:
						num2 = 87;
						if (jk2.h | (jk2.d != 0))
						{
							goto IL_04a5;
						}
						goto IL_062c;
						IL_04a5:
						num2 = 89;
						num11 = jm2.a[3];
						goto IL_04b3;
						IL_04b3:
						num2 = 90;
						num13 = num10;
						goto IL_04ba;
						IL_04ba:
						num2 = 91;
						if (jk2.d == 2)
						{
							goto IL_04c7;
						}
						goto IL_04dd;
						IL_04c7:
						num2 = 92;
						num10 = l(num11);
						goto IL_04d4;
						IL_04d4:
						num2 = 93;
						array2[2] = num10;
						goto IL_04dd;
						IL_04dd:
						num2 = 94;
						num7 = AGetRSubstrate(ref A_10, num10, num11, a_);
						goto IL_04ef;
						IL_04ef:
						num2 = 95;
						num9 = A_10 / (0.5f * (A_8 + A_9));
						goto IL_0502;
						IL_0502:
						num2 = 96;
						A_6 = new List<float>();
						goto IL_050c;
						IL_050c:
						num2 = 97;
						A_7 = new List<float>();
						goto IL_0516;
						IL_0516:
						num2 = 98;
						l(this.m_p.b, this.m_p.c[num6], A_0, num9, ref A_6, ref A_7, ref A_5);
						goto IL_0545;
						IL_0545:
						num2 = 99;
						if (!string.IsNullOrEmpty(A_5))
						{
							goto end_IL_0000_3;
						}
						goto IL_0555;
						IL_0555:
						num2 = 101;
						num7 = AAdvisor(ref A_6.ToArray()[0], ref A_7.ToArray()[0], (short)A_6.Count, ref array[0], ref array2[0], ref array5[0], ref jm2.a[0], ref array3[0], ref A_11, ref array4[0]);
						goto IL_05b7;
						IL_05b7:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_05be;
						IL_05be:
						num2 = 103;
						num12 = (short)(num8 + 1);
						goto IL_05c8;
						IL_05c8:
						num2 = 104;
						_ = (float)((double)num8 * 300.1);
						goto IL_05da;
						IL_05da:
						ProjectData.ClearProjectError();
						num3 = 0;
						goto IL_05e1;
						IL_05e1:
						num2 = 106;
						if (num7 != 0 && num7 != 4)
						{
							goto IL_05ed;
						}
						goto IL_05fd;
						IL_0671:
						num2 = 116;
						A_5 = "Least-squares routine convergence poor.";
						goto end_IL_0000_3;
						IL_05ed:
						num2 = 107;
						A_5 = "Error in Data Analysis. Please select new data.";
						goto end_IL_0000_3;
						IL_05fd:
						num2 = 109;
						num5++;
						goto IL_0607;
						IL_0607:
						num2 = 110;
						if (!(((double)Math.Abs(num13 - num10) < 1E-05) | (num5 > 20)))
						{
							goto IL_04a5;
						}
						goto IL_062c;
						IL_062c:
						num2 = 111;
						if (num7 == 0 || num7 == 4)
						{
							goto IL_0638;
						}
						goto IL_0687;
						IL_067e:
						num2 = 118;
						A_5 = null;
						goto end_IL_0000_3;
						IL_0687:
						num2 = 120;
						if (num7 == 1)
						{
							goto IL_068f;
						}
						goto IL_069c;
						IL_068f:
						num2 = 121;
						A_5 = "Less than seven data points in segment.";
						goto end_IL_0000_3;
						IL_069c:
						num2 = 123;
						if (num7 == 2)
						{
							goto IL_06a4;
						}
						goto IL_06b1;
						end_IL_0000_2:
						break;
					}
					num2 = 127;
					A_5 = "Two inflection points in data required.";
					break;
					end_IL_0000:;
				}
				catch (object obj) when ((obj is Exception) & (num3 != 0) & (num == 0))
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 2265;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0000_3:
				break;
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	public void m(r.d.a.b A_0)
	{
		this.m_n = null;
		this.m_o = null;
		if (this.m_d != null)
		{
			Array.Clear(this.m_d, 0, this.m_d.Length);
		}
		this.m_p = null;
		if (this.m_e != null)
		{
			Array.Clear(this.m_e, 0, this.m_e.Length);
		}
		if (this.m_f != null)
		{
			Array.Clear(this.m_f, 0, this.m_f.Length);
		}
		k = 0;
		this.m_l = 0;
		x?.Invoke(new c(A_0));
	}

	public void n(r.d.a.b A_0)
	{
		this.m_o = null;
		z?.Invoke(null, null, 0L, 0L, 0f, null, null, null, A_8: false, A_0);
	}

	public float l(float A_0, float A_1, long A_2)
	{
		int index = l(A_2);
		float num = float.MaxValue;
		List<float> list = this.m_p.b;
		checked
		{
			int num2 = n() - 1;
			int num5 = default(int);
			for (int num3 = 0; num3 <= num2; num3++)
			{
				float num4 = A_0 - list[num3];
				if (Math.Abs(num4) < num)
				{
					num5 = num3;
					num = Math.Abs(num4);
				}
				if (num4 < 0f)
				{
					break;
				}
			}
			List<float> list2 = this.m_p.c[index];
			int num6 = num5;
			int num7 = num5;
			int num8 = num5;
			int index2 = default(int);
			bool flag2 = default(bool);
			float num12 = default(float);
			float num11 = default(float);
			if (list2[num5] > A_1)
			{
				float num9;
				if (n() < 10)
				{
					num9 = float.MinValue;
					int num10 = n() - 1;
					for (int num3 = 0; num3 <= num10; num3++)
					{
						if (list2[num3] > num9)
						{
							num9 = list2[num3];
							index2 = num3;
						}
					}
					return list[index2];
				}
				bool flag;
				if (num5 < 5)
				{
					flag = false;
					num7 = 0;
				}
				else if (num5 > n() - 5)
				{
					flag = true;
					num8 = n() - 1;
				}
				else
				{
					num11 = 0f;
					int num3 = 1;
					do
					{
						num11 += list2[num5 - num3];
						num3++;
					}
					while (num3 <= 4);
					num12 = 0f;
					num3 = 1;
					do
					{
						num12 += list2[num5 + num3];
						num3++;
					}
					while (num3 <= 4);
					flag = num12 <= num11;
				}
				if (flag)
				{
					do
					{
						num6 -= 5;
						if (num6 < 5)
						{
							num7 = 0;
							flag2 = true;
							continue;
						}
						num12 = num11;
						num11 = 0f;
						int num3 = 1;
						do
						{
							num11 += list2[num6 - num3];
							num3++;
						}
						while (num3 <= 4);
						if (num11 < num12)
						{
							num7 = num6 - 4;
							flag2 = true;
						}
					}
					while (!flag2);
				}
				else
				{
					do
					{
						num6 += 5;
						if (num6 > n() - 5)
						{
							flag2 = true;
							num8 = n() - 1;
							continue;
						}
						num11 = num12;
						num12 = 0f;
						int num3 = 1;
						do
						{
							num12 += list2[num6 + num3];
							num3++;
						}
						while (num3 <= 4);
						if (num12 < num11)
						{
							flag2 = true;
							num8 = num6 + 4;
						}
					}
					while (!flag2);
				}
				num9 = float.MinValue;
				int num13 = num7;
				int num14 = num8;
				for (int num3 = num13; num3 <= num14; num3++)
				{
					if (list2[num3] > num9)
					{
						num9 = list2[num3];
						index2 = num3;
					}
				}
			}
			else
			{
				float num9;
				if (n() < 10)
				{
					num9 = float.MaxValue;
					int num15 = n() - 1;
					for (int num3 = 0; num3 <= num15; num3++)
					{
						if (list2[num3] < num9)
						{
							num9 = list2[num3];
							index2 = num3;
						}
					}
					return list[index2];
				}
				bool flag;
				if (num5 < 5)
				{
					flag = false;
					num7 = 0;
				}
				else if (num5 > n() - 5)
				{
					flag = true;
					num7 = (short)(n() - 1);
				}
				else
				{
					num11 = 0f;
					int num3 = 1;
					do
					{
						num11 += list2[num5 - num3];
						num3++;
					}
					while (num3 <= 4);
					num12 = 0f;
					num3 = 1;
					do
					{
						num12 += list2[num5 + num3];
						num3++;
					}
					while (num3 <= 4);
					flag = num12 > num11;
				}
				if (flag)
				{
					do
					{
						num6 -= 5;
						if (num6 < 5)
						{
							num7 = 0;
							flag2 = true;
							continue;
						}
						num12 = num11;
						num11 = 0f;
						int num3 = 1;
						do
						{
							num11 += list2[num6 - num3];
							num3++;
						}
						while (num3 <= 4);
						if (num11 > num12)
						{
							num7 = num6 - 4;
							flag2 = true;
						}
					}
					while (!flag2);
				}
				else
				{
					do
					{
						num6 += 5;
						if (num6 > n() - 5)
						{
							num8 = n() - 1;
							flag2 = true;
							continue;
						}
						num11 = num12;
						num12 = 0f;
						int num3 = 1;
						do
						{
							num12 += list2[num6 + num3];
							num3++;
						}
						while (num3 <= 4);
						if (num12 > num11)
						{
							num8 = num6 + 4;
							flag2 = true;
						}
					}
					while (!flag2);
				}
				num9 = float.MaxValue;
				int num16 = num7;
				int num17 = num8;
				for (int num3 = num16; num3 <= num17; num3++)
				{
					if (list2[num3] < num9)
					{
						num9 = list2[num3];
						index2 = num3;
					}
				}
			}
			return list[index2];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public void l(string A_0, r.d.a.b A_1, g3 A_2, ref string A_3)
	{
		Conversions.ToString(i3.h(A_0));
		m(A_1);
		this.m_n = Path.GetFileNameWithoutExtension(A_0);
		string text = Path.GetExtension(A_0).ToLower();
		checked
		{
			if (Operators.CompareString(text, ".erf", TextCompare: false) == 0)
			{
				if (!Directory.Exists(i3.g()))
				{
					Directory.CreateDirectory(i3.g());
				}
				string A_4 = i3.g() + "\\TmpErf" + p() + ".tmp";
				double A_5 = 0.0;
				this.m_i = ErfParseFileToTemp(ref A_0, ref A_4, ref A_5);
				this.m_g = new float[this.m_i - 1 + 1];
				this.m_h = new float[this.m_i - 1 + 1];
				ErfParseTempFile(ref A_4, this.m_g, this.m_h, this.m_i);
				for (int num = this.m_i - 1; num >= 1; num += -1)
				{
					int num2 = num - 1;
					for (int num3 = 1; num3 <= num2; num3++)
					{
						this.m_g[num] += this.m_g[num3];
					}
				}
				A_3 = "";
				List<float> list = new List<float>();
				List<float> list2 = new List<float>();
				float[] array = this.m_h;
				foreach (float item in array)
				{
					list.Add(item);
				}
				float[] array2 = this.m_g;
				foreach (float item2 in array2)
				{
					list2.Add(item2);
				}
				y?.Invoke(this.m_i, list2.AsReadOnly(), list.AsReadOnly(), A_1);
			}
			this.m_p = new jn();
			this.m_p.g = this.m_n;
			switch (text)
			{
			case ".vst":
			{
				string Value = null;
				this.m_p.f.Add(0f);
				this.m_p.c.Add(new List<float>());
				k = 1;
				try
				{
					Microsoft.VisualBasic.FileSystem.FileOpen(1, A_0, OpenMode.Input);
					Microsoft.VisualBasic.FileSystem.Input(1, ref Value);
					if (Operators.CompareString(Value, "Version", TextCompare: false) == 0)
					{
						short Value2 = default(short);
						Microsoft.VisualBasic.FileSystem.Input(1, ref Value2);
						if (Value2 >= 1)
						{
							Microsoft.VisualBasic.FileSystem.Input(1, ref k);
							if (k == 2)
							{
								Microsoft.VisualBasic.FileSystem.Input(1, ref this.m_l);
								int num10 = 0;
								this.m_d = new int[this.m_l + 1];
								int num11 = this.m_l - 1;
								for (int num = 0; num <= num11; num++)
								{
									Microsoft.VisualBasic.FileSystem.Input(1, ref this.m_d[num]);
									if (this.m_d[num] > num10)
									{
										num10 = this.m_d[num];
									}
								}
								this.m_e = new double[this.m_l + 1, num10 + 1];
								this.m_f = new double[this.m_l + 1, num10 + 1];
							}
						}
					}
					List<float> list3;
					float Value3 = (list3 = this.m_p.f)[0];
					Microsoft.VisualBasic.FileSystem.Input(1, ref Value3);
					list3[0] = Value3;
					float num12 = 0f;
					float num14 = default(float);
					float num15 = default(float);
					while (!Microsoft.VisualBasic.FileSystem.EOF(1))
					{
						Microsoft.VisualBasic.FileSystem.Input(1, ref Value);
						float num13 = (float)Conversion.Val(Value);
						if (num13 >= 0f)
						{
							num14 = num15;
							num15 = num13;
						}
						else
						{
							if (num12 == 0f)
							{
								num12 = num13 - (num15 - num14);
							}
							num13 = num13 - num12 + num15;
						}
						this.m_p.b.Add(num13);
						if (Microsoft.VisualBasic.FileSystem.EOF(1))
						{
							continue;
						}
						Microsoft.VisualBasic.FileSystem.Input(1, ref Value);
						float num16 = (float)Conversion.Val(Value);
						this.m_p.c[0].Add(num16);
						if (k != 2)
						{
							continue;
						}
						this.m_e[0, m()] = this.m_p.b[m()];
						this.m_f[0, m()] = num16;
						int num17 = this.m_l - 1;
						for (int num = 1; num <= num17; num++)
						{
							Microsoft.VisualBasic.FileSystem.Input(1, ref this.m_e[num, m()]);
							if (!Microsoft.VisualBasic.FileSystem.EOF(1))
							{
								Microsoft.VisualBasic.FileSystem.Input(1, ref this.m_f[num, m()]);
							}
						}
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception a_2 = ex3;
					A_3 = "Open file failed.";
					this.m_m.c(fz.b.b, "Exception caught in VsTimeData.OpenFile ", a_2);
					ProjectData.ClearProjectError();
				}
				finally
				{
					Microsoft.VisualBasic.FileSystem.FileClose(1);
				}
				A_3 = "";
				this.m_p.d = new List<long>();
				this.m_p.d.Add(A_2.a());
				this.m_p.e = new List<long>();
				this.m_p.e.Add(0L);
				p(jl.b.b);
				l(A_1);
				break;
			}
			case ".csv":
			case ".txt":
				try
				{
					string text2 = ((Operators.CompareString(text, ".csv", TextCompare: false) == 0) ? Thread.CurrentThread.CurrentCulture.TextInfo.ListSeparator : "\t");
					TextFieldParser textFieldParser = new TextFieldParser(A_0);
					textFieldParser.TextFieldType = FieldType.Delimited;
					textFieldParser.SetDelimiters(text2);
					string[] array3 = textFieldParser.ReadFields();
					int num6 = (short)(array3.Length - 1);
					int num7 = num6;
					for (int num = 1; num <= num7; num++)
					{
						this.m_p.f.Add(Conversions.ToSingle(array3[num]));
						this.m_p.c.Add(new List<float>());
					}
					while (!textFieldParser.EndOfData)
					{
						array3 = textFieldParser.ReadFields();
						this.m_p.b.Add(Conversions.ToSingle(array3[0]));
						int num8 = num6;
						for (int num3 = 1; num3 <= num8; num3++)
						{
							this.m_p.c[num3 - 1].Add(Conversions.ToSingle(array3[num3]));
						}
					}
					textFieldParser.Dispose();
					this.m_p.d = new List<long>();
					this.m_p.e = new List<long>();
					int num9 = num6;
					for (int num3 = 1; num3 <= num9; num3++)
					{
						this.m_p.d.Add(A_2.a());
						this.m_p.e.Add(0L);
					}
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception a_ = ex2;
					A_3 = "Open file failed.";
					this.m_m.c(fz.b.b, "Exception caught in VsTimeData.OpenFile ", a_);
					ProjectData.ClearProjectError();
				}
				A_3 = "";
				l(A_1);
				break;
			case ".fivst":
				l(A_0, A_2, A_1);
				break;
			}
		}
	}

	public void n(string A_0)
	{
		StreamWriter streamWriter = null;
		checked
		{
			try
			{
				this.m_n = Path.GetFileNameWithoutExtension(A_0);
				int num = this.m_p.f.Count - 1;
				int num2 = m();
				string text = "Wavelength(nm)";
				string text2 = ((Operators.CompareString(Path.GetExtension(A_0).ToLower(), ".csv", TextCompare: false) == 0) ? Thread.CurrentThread.CurrentCulture.TextInfo.ListSeparator : "\t");
				streamWriter = new StreamWriter(A_0);
				int num3 = num;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					text = text + text2 + this.m_p.f[num4];
				}
				streamWriter.WriteLine(text);
				int num5 = num2;
				for (int num4 = 0; num4 <= num5; num4++)
				{
					text = this.m_p.b[num4].ToString();
					int num6 = num;
					for (int num7 = 0; num7 <= num6; num7++)
					{
						text = text + text2 + this.m_p.c[num7][num4];
					}
					streamWriter.WriteLine(text);
				}
			}
			finally
			{
				streamWriter?.Dispose();
			}
		}
	}

	public void o(string A_0)
	{
		BinaryWriter binaryWriter = null;
		try
		{
			binaryWriter = new BinaryWriter(new FileStream(A_0, FileMode.OpenOrCreate));
			this.m_n = Path.GetFileNameWithoutExtension(A_0);
			BinaryWriter binaryWriter2 = binaryWriter;
			binaryWriter2.Write(1);
			binaryWriter2.Write(1);
			binaryWriter2.Write((int)v());
			i3.a(this.m_p.f, binaryWriter);
			i3.a(this.m_p.b, binaryWriter);
			foreach (List<float> item in this.m_p.c)
			{
				i3.a(item, binaryWriter);
			}
			_ = null;
		}
		finally
		{
			binaryWriter?.Close();
		}
	}

	public void l(string A_0, g3 A_1, r.d.a.b A_2)
	{
		BinaryReader binaryReader = null;
		try
		{
			binaryReader = new BinaryReader(new FileStream(A_0, FileMode.Open, FileAccess.Read, FileShare.Read));
			this.m_n = Path.GetFileNameWithoutExtension(A_0);
			BinaryReader binaryReader2 = binaryReader;
			binaryReader2.ReadInt32();
			int num = binaryReader2.ReadInt32();
			if (num > 1)
			{
				throw new au("File " + A_0 + " requires software capable of reading version " + num + "files. This software only understands up to version " + 1);
			}
			p((b)binaryReader2.ReadInt32());
			i3.a(ref this.m_p.f, binaryReader);
			i3.a(ref this.m_p.b, binaryReader);
			this.m_p.c.Clear();
			this.m_p.d = new List<long>();
			this.m_p.e = new List<long>();
			int count = this.m_p.f.Count;
			for (int num2 = 1; num2 <= count; num2 = checked(num2 + 1))
			{
				List<float> A_3 = null;
				i3.a(ref A_3, binaryReader);
				this.m_p.c.Add(A_3);
				this.m_p.d.Add(A_1.a());
				this.m_p.e.Add(0L);
			}
			binaryReader2 = null;
		}
		finally
		{
			binaryReader?.Close();
		}
		l(A_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public void l(string A_0, int A_1)
	{
		checked
		{
			switch (Path.GetExtension(A_0).ToLower())
			{
			case ".csv":
			case ".txt":
				n(A_0);
				break;
			case ".fivst":
				o(A_0);
				break;
			case ".vst":
			{
				int num = default(int);
				try
				{
					this.m_n = Path.GetFileNameWithoutExtension(A_0);
					num = Microsoft.VisualBasic.FileSystem.FreeFile();
					Microsoft.VisualBasic.FileSystem.FileOpen(num, A_0, OpenMode.Output);
					if (k == 2)
					{
						Microsoft.VisualBasic.FileSystem.Write(num, "Version", (short)1, k, this.m_l);
						int num2 = this.m_l - 1;
						for (int num3 = 0; num3 <= num2; num3++)
						{
							Microsoft.VisualBasic.FileSystem.Write(num, this.m_d[num3]);
						}
						Microsoft.VisualBasic.FileSystem.WriteLine(num, Conversion.Int(((double)(this.m_p.f[0] * 100f) + 0.5) * 0.01));
						int num4 = 0;
						int num5 = this.m_l - 1;
						for (int num3 = 0; num3 <= num5; num3++)
						{
							if (num4 < this.m_d[num3])
							{
								num4 = this.m_d[num3];
							}
						}
						int num6 = num4 - 1;
						for (int num3 = 0; num3 <= num6; num3++)
						{
							int num7 = this.m_l - 2;
							for (int num8 = 0; num8 <= num7; num8++)
							{
								Microsoft.VisualBasic.FileSystem.Write(num, Conversion.Int((this.m_e[num8, num3] * 10000.0 + 0.5) * 0.0001), Conversion.Int(this.m_f[num8, num3] * 10000.0 + 0.5) * 0.0001);
							}
							Microsoft.VisualBasic.FileSystem.WriteLine(num, Conversion.Int(this.m_e[this.m_l - 1, num3] * 10000.0 + 0.5) * 0.0001, Conversion.Int(this.m_f[this.m_l - 1, num3] * 10000.0 + 0.5) * 0.0001);
						}
					}
					else
					{
						Microsoft.VisualBasic.FileSystem.WriteLine(num, "Time(sec.)", Conversion.Int((double)(this.m_p.f[A_1] * 100f) + 0.5) * 0.01);
						List<float> list = this.m_p.c[A_1];
						int num9 = m();
						for (int num3 = 0; num3 <= num9; num3++)
						{
							Microsoft.VisualBasic.FileSystem.WriteLine(num, Conversion.Int((double)(this.m_p.b[num3] * 10000f) + 0.5) * 0.0001, Conversion.Int((double)(list[num3] * 10000f) + 0.5) * 0.0001);
						}
						list = null;
					}
					break;
				}
				finally
				{
					Microsoft.VisualBasic.FileSystem.FileClose(num);
				}
			}
			}
		}
	}

	public void l(List<long> A_0)
	{
		this.m_p = new jn();
		this.m_p.e = new List<long>();
		foreach (long item in A_0)
		{
			_ = item;
			this.m_p.e.Add(0L);
		}
		this.m_p.d = A_0;
	}

	public void l(List<float> A_0)
	{
		this.m_p.f = A_0;
	}

	public static string m(b A_0)
	{
		if (ad == null)
		{
			ad = new string[checked(Enum.GetValues(typeof(b)).GetUpperBound(0) + 1)];
		}
		if (A_0 < jl.b.a || A_0 > jl.b.b)
		{
			A_0 = jl.b.b;
		}
		switch (A_0)
		{
		case jl.b.a:
			if (string.IsNullOrEmpty(ad[(int)checked(A_0 - 1)]))
			{
				string[] array2 = ad;
				b num2 = checked(A_0 - 1);
				string A_1 = "RawTitle";
				array2[(int)num2] = hu.a(ref A_1);
			}
			break;
		case jl.b.b:
			if (string.IsNullOrEmpty(ad[(int)checked(A_0 - 1)]))
			{
				string[] array = ad;
				b num = checked(A_0 - 1);
				string A_1 = "ReflectanceTitle";
				array[(int)num] = hu.a(ref A_1);
			}
			break;
		}
		return ad[(int)checked(A_0 - 1)];
	}

	public static string l(b A_0)
	{
		if (ae == null)
		{
			ae = new string[checked(Enum.GetValues(typeof(b)).GetUpperBound(0) + 1)];
		}
		if (A_0 < jl.b.a || A_0 > jl.b.b)
		{
			A_0 = jl.b.b;
		}
		switch (A_0)
		{
		case jl.b.a:
			if (string.IsNullOrEmpty(ae[(int)checked(A_0 - 1)]))
			{
				string[] array2 = ae;
				b num2 = checked(A_0 - 1);
				string A_1 = "RawTitleAbbrev";
				array2[(int)num2] = hu.a(ref A_1);
			}
			break;
		case jl.b.b:
			if (string.IsNullOrEmpty(ae[(int)checked(A_0 - 1)]))
			{
				string[] array = ae;
				b num = checked(A_0 - 1);
				string A_1 = "ReflectanceAbbrevTitle";
				array[(int)num] = hu.a(ref A_1);
			}
			break;
		}
		return ae[(int)checked(A_0 - 1)];
	}
}
