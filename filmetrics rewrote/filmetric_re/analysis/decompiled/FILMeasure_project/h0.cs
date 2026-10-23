using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FISerBuffMultPrj;
using Filmetrics.TmcmControllerEnums;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class h0
{
	public enum a
	{
		a,
		b,
		c,
		d,
		e
	}

	public enum b
	{
		a = 0,
		b = 1,
		c = 341,
		d = 1021
	}

	public enum c : byte
	{
		a,
		b,
		c,
		d,
		e,
		f
	}

	public enum d : byte
	{
		a,
		b,
		c
	}

	public enum e : short
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g
	}

	public enum f : byte
	{
		a,
		b,
		c,
		d
	}

	public enum g : short
	{
		a,
		b,
		c
	}

	public enum h
	{
		a,
		b,
		c
	}

	private FISerBuffMult m_a;

	private hz m_b;

	private short m_c;

	private byte m_d;

	private float m_e;

	private b m_f;

	public object g;

	private List<object> m_h;

	private int i;

	private int j;

	private const int k = 1000000;

	private const int m_l = 900000;

	private bool m_m;

	private InterlockInput m_n;

	private DIN6Version m_o;

	private bool m_p;

	private const bool m_q = false;

	private bool m_r;

	private string m_s;

	private string m_t;

	private Collection<string> m_u;

	private object m_v;

	private const float m_w = 1.2f;

	private const float m_x = 3f;

	public const byte y = 1;

	public const byte z = 2;

	public const byte aa = 3;

	public const byte ab = 4;

	public const byte ac = 0;

	public const byte ad = 1;

	public const byte ae = 2;

	public const byte af = 19;

	public const byte ag = 0;

	public const byte ah = 1;

	public const byte ai = 2;

	public const byte aj = 3;

	public const byte ak = 4;

	public const byte al = 5;

	public const byte am = 6;

	public const byte an = 7;

	public const byte ao = 8;

	public const byte ap = 9;

	public const byte aq = 33;

	public const byte ar = 9;

	public const byte @as = 10;

	public const byte at = 20;

	public const byte au = 21;

	public const byte av = 2;

	public const byte aw = 3;

	public const byte ax = 4;

	public const byte ay = 6;

	public const byte az = 22;

	public const byte a0 = 23;

	public const byte a1 = 24;

	public const byte a2 = 28;

	public const byte a3 = 128;

	public const byte a4 = 129;

	public const byte a5 = 1;

	public const byte a6 = 131;

	public const byte a7 = 132;

	public const byte a8 = 133;

	public const byte a9 = 13;

	public const byte ba = 0;

	public const byte bb = 1;

	public const byte bc = 2;

	public const byte bd = 5;

	public const byte be = 6;

	public const byte bf = 7;

	public const byte bg = 0;

	public const byte bh = 1;

	public const byte bi = 2;

	public const byte bj = 3;

	public const byte bk = 4;

	public const byte bl = 5;

	public const byte bm = 6;

	public const byte bn = 7;

	public const byte bo = 8;

	public const byte bp = 9;

	public const byte bq = 10;

	public const byte br = 11;

	public const byte bs = 12;

	public const byte bt = 13;

	public const byte bu = 136;

	public const byte bv = 143;

	public const byte bw = 144;

	public const byte bx = 145;

	public const byte by = 153;

	public const byte bz = 154;

	public const byte b0 = 203;

	public const byte b1 = 146;

	public const byte b2 = 149;

	public const byte b3 = 181;

	public const byte b4 = 174;

	public const byte b5 = 177;

	public const byte b6 = 206;

	public const byte b7 = 15;

	public const byte b8 = 138;

	public const int b9 = 0;

	public const int ca = 2;

	public const byte cb = 140;

	public const byte cc = 179;

	public const byte cd = 17;

	public const byte ce = 21;

	public const byte cf = 22;

	public const byte cg = 2;

	public const byte ch = 23;

	public const byte ci = 34;

	public const byte cj = 35;

	public const byte ck = 9;

	public const byte cl = 10;

	public const byte cm = 11;

	public const byte cn = 136;

	public const byte co = 1;

	public const byte cp = 65;

	public const byte cq = 66;

	public const byte cr = 76;

	public const byte cs = 80;

	public const byte ct = 14;

	public const byte cu = 0;

	public const byte cv = 1;

	public const byte cw = 2;

	public const byte cx = 3;

	public const byte cy = 4;

	public const byte cz = 5;

	public const byte c0 = 6;

	public const byte c1 = 10;

	public const byte c2 = 2;

	public const byte c3 = 0;

	private const byte c4 = 1;

	private const byte c5 = 8;

	private const byte c6 = 7;

	private const byte c7 = 1;

	private const byte c8 = 4;

	private const byte c9 = 3;

	private const byte da = 5;

	private const byte db = 6;

	private const byte dc = 7;

	private const byte dd = 8;

	private const byte de = 9;

	private const byte df = 12;

	private const byte dg = 13;

	private const byte dh = 14;

	private const byte di = 15;

	private const int dj = 255;

	private const int dk = 65535;

	private const int dl = 8;

	private const int dm = 16;

	private const int dn = 24;

	private const byte @do = 1;

	private const byte dp = 2;

	private const byte dq = 4;

	private const byte dr = 8;

	private const byte ds = 16;

	private const byte dt = 32;

	private const byte du = 64;

	private const byte dv = 128;

	private const byte dw = 128;

	private const byte dx = 64;

	private const byte dy = 32;

	private const byte dz = 16;

	private const byte d0 = 8;

	private const byte d1 = 4;

	private const byte d2 = 2;

	private const byte d3 = 1;

	public const byte d4 = 15;

	public const byte d5 = 0;

	public const byte d6 = 1;

	public const byte d7 = 2;

	public const byte d8 = 3;

	public const byte d9 = 4;

	public const byte ea = 5;

	public const byte eb = 6;

	public const byte ec = 0;

	public const byte ed = 27;

	public const byte ee = 0;

	public const byte ef = 1;

	public const byte eg = 3;

	public const byte eh = 30;

	public const byte ei = 31;

	public const byte ej = 32;

	public const byte ek = 0;

	public const byte el = 1;

	public const byte em = 135;

	public const byte en = 0;

	public const byte eo = 1;

	public const byte ep = 2;

	public const byte eq = 3;

	private const int er = 800;

	private const int es = 800;

	private const short et = 10;

	private const int eu = 16000000;

	private const short ev = 13;

	private const short ew = 13;

	private const short ex = 6;

	private const short ey = 2047;

	private const short ez = 1023;

	private const short e0 = 2047;

	public const byte e1 = 1;

	public const byte e2 = 2;

	public const byte e3 = 3;

	public const byte e4 = 4;

	public const byte e5 = 5;

	public const byte e6 = 6;

	public const byte e7 = 7;

	public const short e8 = 0;

	public const short e9 = 255;

	public const short fa = 5;

	public const short fb = 1;

	public const short fc = 5;

	private bool fd;

	public static string m(f A_0)
	{
		return A_0 switch
		{
			h0.f.a => "Type 1", 
			h0.f.b => "Type 2", 
			h0.f.c => "Type 3", 
			h0.f.d => "Type 4", 
			_ => "Type unknown", 
		};
	}

	public static bool l(f A_0)
	{
		if (A_0 >= h0.f.b)
		{
			return true;
		}
		return false;
	}

	public static string l(c A_0)
	{
		return A_0 switch
		{
			h0.c.c => "Micropositioner", 
			h0.c.b => "SS-XY8", 
			h0.c.e => "SS-XY10", 
			h0.c.f => "Optical Profiler XY", 
			_ => "Unknown", 
		};
	}

	public a l(short A_0, ref bool A_1, string A_2, bool A_3, h A_4, InterlockInput A_5, DIN6Version A_6, g A_7, bool A_8, bool A_9, c A_10, ref string A_11)
	{
		a a10 = h0.a.c;
		a10 = ((!A_8) ? l(A_0: false, A_1: false, ref A_1, A_2, A_3, ref A_11, A_6: true, 1, 1, h0.c.a, SerialPort.GetPortNames()) : ((A_0 >= 0) ? checked(l(A_0: true, A_9, ref A_1, A_2, A_3, ref A_11, A_6: false, (byte)A_0, (byte)A_0, A_10, SerialPort.GetPortNames())) : l(A_0: true, A_9, ref A_1, A_2, A_3, ref A_11, A_6: false, 0, 7, A_10, SerialPort.GetPortNames())));
		if (a10 == h0.a.a && !A_1)
		{
			switch (A_4)
			{
			case h0.h.b:
				if (p() != 100)
				{
					return h0.a.d;
				}
				this.m_n = A_5;
				break;
			case h0.h.c:
				this.m_m = true;
				this.m_n = InterlockInput.DIN6;
				this.m_o = A_6;
				break;
			case h0.h.a:
				this.m_m = false;
				break;
			}
			switch (A_7)
			{
			case h0.g.a:
				if (l(ref this.m_p) != 100)
				{
					return h0.a.d;
				}
				break;
			case h0.g.b:
				this.m_p = true;
				break;
			case h0.g.c:
				this.m_p = false;
				break;
			}
			if (A_8)
			{
				this.m_c = 1;
			}
			else
			{
				int A_12 = default(int);
				if (l(15, 4, 0, A_3: false, 0, A_5: true, ref A_12, A_7: false, 0, 0.2f, 0) != 100)
				{
					return h0.a.d;
				}
				if (A_12 == 0)
				{
					this.m_c = 2;
				}
				else
				{
					this.m_c = 1;
				}
			}
			if (this.m_m && q() != 100)
			{
				a10 = h0.a.d;
			}
			return a10;
		}
		return a10;
	}

	public FISerBuffMult l(h0 A_0, ref hz A_1)
	{
		this.m_b.b(A_0);
		A_1 = this.m_b;
		return this.m_a;
	}

	public a l(h0 A_0, byte A_1)
	{
		if (A_0 == null)
		{
			return h0.a.b;
		}
		this.m_a = A_0.l(this, ref this.m_b);
		this.m_d = A_1;
		this.m_f = h0.b.d;
		return h0.a.a;
	}

	[SpecialName]
	public bool l(string A_0 = "")
	{
		return this.m_r;
	}

	[SpecialName]
	public void l([Optional][DefaultParameterValue("")] string A_0, bool A_1)
	{
		this.m_s = A_0;
		this.m_r = A_1;
	}

	[SpecialName]
	public void m(string A_0)
	{
		this.m_t = this.m_s + "." + A_0;
	}

	[SpecialName]
	public bool r()
	{
		return this.m_f == h0.b.b;
	}

	[SpecialName]
	public short s()
	{
		return this.m_c;
	}

	[SpecialName]
	public bool t()
	{
		return this.m_m;
	}

	[SpecialName]
	public InterlockInput u()
	{
		return this.m_n;
	}

	[SpecialName]
	public DIN6Version v()
	{
		return this.m_o;
	}

	[SpecialName]
	public bool w()
	{
		return this.m_p;
	}

	[SpecialName]
	public bool x()
	{
		return this.m_f == h0.b.d;
	}

	[SpecialName]
	public bool y()
	{
		return this.m_f == h0.b.c;
	}

	public a l(short A_0, short A_1)
	{
		byte b10;
		switch (A_0)
		{
		case 1:
			b10 = 0;
			break;
		case 2:
			b10 = 1;
			break;
		case 4:
			b10 = 2;
			break;
		case 8:
			b10 = 3;
			break;
		case 16:
			b10 = 4;
			break;
		default:
			return h0.a.e;
		}
		byte a_ = b10;
		int A_2 = 0;
		if (l(5, 140, a_, A_3: true, A_1, A_5: false, ref A_2, A_7: false, 0, 0f, checked((byte)A_1)) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a l(bool A_0, short A_1)
	{
		checked
		{
			byte a_ = (byte)((!A_0) ? 1 : 0);
			int A_2 = 0;
			if (l(5, 179, a_, A_3: true, A_1, A_5: false, ref A_2, A_7: false, 0, 0f, (byte)A_1) != 100)
			{
				return h0.a.d;
			}
			return h0.a.a;
		}
	}

	public a l(short A_0)
	{
		int a_ = ((this.m_f == h0.b.c) ? 1 : (-1));
		int A_1 = 0;
		if (l(5, 203, a_, A_3: true, A_0, A_5: false, ref A_1, A_7: false, 0, 0f, checked((byte)A_0)) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public byte l(byte A_0, ref int A_1, bool A_2, short A_3 = 0, byte A_4 = 2)
	{
		A_1 = 0;
		return l(10, A_0, 0, A_3: true, A_3, A_2, ref A_1, A_7: false, 0, 0f, A_4);
	}

	public byte l(byte A_0, int A_1, bool A_2, short A_3 = 0, byte A_4 = 2)
	{
		int A_5 = 0;
		return l(9, A_0, A_1, A_3: true, A_3, A_2, ref A_5, A_7: false, 0, 0f, A_4);
	}

	public void l(float A_0, float A_1, bool A_2, ref short A_3, ref short A_4, ref short A_5, ref short A_6)
	{
		short num = 2047;
		if (A_2)
		{
			num = 1023;
		}
		short num2 = (short)((this.m_f != h0.b.c) ? 13 : 6);
		A_4 = 0;
		checked
		{
			double num3;
			do
			{
				A_4++;
				num3 = Math.Pow(2.0, A_4) * 65536.0;
				A_3 = (short)Math.Round((double)A_0 * num3 / 16000000.0);
			}
			while (A_3 < num && A_4 <= num2);
			A_4--;
			num3 = Math.Pow(2.0, A_4) * 65536.0;
			A_3 = (short)Math.Round((double)A_0 * num3 / 16000000.0);
			if (A_3 < 1)
			{
				A_3 = 1;
			}
			if (A_3 > num)
			{
				A_3 = num;
			}
			A_6 = 0;
			do
			{
				A_6++;
				num3 = Math.Pow(2.0, (short)unchecked(A_4 + A_6) + 29);
				A_5 = (short)Math.Round((double)A_1 * num3 / 256000000000000.0);
			}
			while (A_5 < 2047 && A_6 <= 13);
			A_6--;
			num3 = Math.Pow(2.0, (short)unchecked(A_4 + A_6) + 29);
			A_5 = (short)Math.Round((double)A_1 * num3 / 256000000000000.0);
			if (A_5 < 1)
			{
				A_5 = 1;
			}
			if (A_5 > 2047)
			{
				A_5 = 2047;
			}
		}
	}

	public short l(float A_0, short A_1)
	{
		checked
		{
			if (x())
			{
				return (short)Math.Round(A_0);
			}
			return (short)Math.Round((double)A_0 * (Math.Pow(2.0, A_1) * 2048.0 * 32.0) / 16000000.0);
		}
	}

	public float l(int A_0, short A_1)
	{
		if (x())
		{
			return A_0;
		}
		return (float)A_0 * (float)(16000000.0 / (Math.Pow(2.0, A_1) * 2048.0 * 32.0));
	}

	public float l(int A_0, short A_1, short A_2)
	{
		if (x())
		{
			return A_0;
		}
		checked
		{
			return (float)((double)A_0 * 256000000000000.0 / Math.Pow(2.0, (short)unchecked(A_1 + A_2) + 29));
		}
	}

	public a l(bool A_0)
	{
		checked
		{
			if (l((byte)0, (byte)(short)unchecked(-(short)(0 - (A_0 ? 1 : 0)))) != 100)
			{
				return h0.a.d;
			}
			return h0.a.a;
		}
	}

	public byte m(bool A_0)
	{
		return l((byte)3, (!A_0) ? ((byte)1) : ((byte)0));
	}

	public byte n(bool A_0)
	{
		return l((byte)4, (byte)(A_0 ? 1 : 0));
	}

	public byte l(byte A_0, byte A_1)
	{
		byte[] A_2 = null;
		h3.a(this.m_d, 14, A_0, A_1, ref A_2, 2);
		int A_3 = 0;
		return l(ref A_2, A_1: false, 0, ref A_3, A_4: true);
	}

	public byte l(byte A_0, ref int A_1)
	{
		byte[] A_2 = null;
		h3.a(this.m_d, 15, A_0, 0, ref A_2, 0);
		return l(ref A_2, A_1: false, 0, ref A_1, A_4: true);
	}

	public a l(byte A_0, byte A_1, ref bool A_2)
	{
		int num = 1;
		int A_3 = default(int);
		do
		{
			A_2 = false;
			if (l(A_0, 0) != 100)
			{
				return h0.a.d;
			}
			if (l(A_1, ref A_3) != 100)
			{
				return h0.a.d;
			}
			if (A_3 == 0)
			{
				if (l(A_0, 1) != 100)
				{
					return h0.a.d;
				}
				if (l(A_1, ref A_3) != 100)
				{
					return h0.a.d;
				}
				A_2 = A_3 == 1;
			}
			if (!A_2)
			{
				return h0.a.a;
			}
			num = checked(num + 1);
		}
		while (num <= 10);
		return h0.a.a;
	}

	public a m(int A_0, short A_1)
	{
		int A_2 = 0;
		checked
		{
			if (l(3, 0, 0, A_3: true, A_1, A_5: false, ref A_2, A_7: false, 0, 0f, (byte)A_1) != 100)
			{
				return h0.a.d;
			}
			a a10 = h0.a.a;
			A_2 = 0;
			if (l(5, 1, A_0, A_3: true, A_1, A_5: false, ref A_2, A_7: false, 0, 0f, (byte)A_1) != 100)
			{
				return h0.a.d;
			}
			return h0.a.a;
		}
	}

	public a l(ref int A_0, short A_1)
	{
		if (l(6, 1, 0, A_3: true, A_1, A_5: true, ref A_0, A_7: false, 0, 0f, checked((byte)A_1)) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a m(ref int A_0, short A_1)
	{
		if (l(6, 206, 0, A_3: true, A_1, A_5: true, ref A_0, A_7: false, 0, 0f, checked((byte)A_1)) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a n(int A_0, short A_1)
	{
		int A_2 = 0;
		if (l(5, 4, A_0, A_3: true, A_1, A_5: false, ref A_2, A_7: false, 0, 0f, checked((byte)A_1)) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a o(int A_0, short A_1)
	{
		int A_2 = 0;
		if (l(5, 5, A_0, A_3: true, A_1, A_5: false, ref A_2, A_7: false, 0, 0f, checked((byte)A_1)) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a m(short A_0, short A_1)
	{
		int A_2 = 0;
		if (l(5, 154, A_0, A_3: true, A_1, A_5: false, ref A_2, A_7: false, 0, 0f, checked((byte)A_1)) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a n(short A_0, short A_1)
	{
		int A_2 = 0;
		if (l(5, 153, A_0, A_3: true, A_1, A_5: false, ref A_2, A_7: false, 0, 0f, checked((byte)A_1)) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public h1.PublicErrors l(ref int A_0, short A_1, ref bool A_2)
	{
		A_2 = false;
		int num = l(6, 146, 0, A_3: true, A_1, A_5: true, ref A_0, A_7: false, 0, 0f, checked((byte)A_1));
		if (num != 100 && num != 3)
		{
			return h1.PublicErrors.RightLimitNonAvailable;
		}
		A_2 = num == 3;
		return h1.PublicErrors.None;
	}

	public h1.PublicErrors o(short A_0, short A_1)
	{
		int A_2 = 0;
		if (l(5, 146, A_0, A_3: true, A_1, A_5: false, ref A_2, A_7: false, 0, 0f, checked((byte)A_1)) != 100)
		{
			return h1.PublicErrors.RightLimitNonAvailable;
		}
		return h1.PublicErrors.None;
	}

	public a m(bool A_0, short A_1)
	{
		checked
		{
			int a_ = (short)unchecked(-(short)(0 - (A_0 ? 1 : 0)));
			int A_2 = 0;
			if (l(5, 149, a_, A_3: true, A_1, A_5: false, ref A_2, A_7: false, 0, 0f, (byte)A_1) != 100)
			{
				return h0.a.d;
			}
			return h0.a.a;
		}
	}

	public a n(bool A_0, short A_1)
	{
		int a_ = ((!A_0) ? 268435454 : 0);
		int A_2 = 0;
		if (l(5, 181, a_, A_3: true, A_1, A_5: false, ref A_2, A_7: false, 0, 0f, checked((byte)A_1)) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a p(int A_0, short A_1)
	{
		int A_2 = 0;
		if (l(5, 6, A_0, A_3: true, A_1, A_5: false, ref A_2, A_7: false, 0, 0f, checked((byte)A_1)) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a m(short A_0)
	{
		int A_1 = 0;
		if (l(7, 6, 0, A_3: true, A_0, A_5: false, ref A_1, A_7: false, 0, 0f, checked((byte)A_0)) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	internal a l(h3.f A_0, short A_1)
	{
		int A_2 = 0;
		if (l(5, 143, (int)A_0, A_3: true, A_1, A_5: false, ref A_2, A_7: false, 0, 0f, checked((byte)A_1)) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a q(int A_0, short A_1)
	{
		int A_2 = 0;
		if (l(5, 7, A_0, A_3: true, A_1, A_5: false, ref A_2, A_7: false, 0, 0f, checked((byte)A_1)) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a o(bool A_0, short A_1)
	{
		checked
		{
			int a_ = (short)unchecked(-(short)(0 - (A_0 ? 1 : 0)));
			int A_2 = 0;
			if (l(5, 13, a_, A_3: true, A_1, A_5: false, ref A_2, A_7: false, 0, 0f, (byte)A_1) != 100)
			{
				return h0.a.d;
			}
			return h0.a.a;
		}
	}

	public a p(bool A_0, short A_1)
	{
		checked
		{
			int a_ = (short)unchecked(-(short)(0 - (A_0 ? 1 : 0)));
			int A_2 = 0;
			if (l(5, 12, a_, A_3: true, A_1, A_5: false, ref A_2, A_7: false, 0, 0f, (byte)A_1) != 100)
			{
				return h0.a.d;
			}
			return h0.a.a;
		}
	}

	public a l(short A_0, ref bool A_1)
	{
		int A_2 = default(int);
		a result;
		if (l(6, 11, 0, A_3: true, A_0, A_5: true, ref A_2, A_7: false, 0, 0f, checked((byte)A_0)) != 100)
		{
			result = h0.a.d;
		}
		else
		{
			result = h0.a.a;
			A_1 = A_2 != 0;
		}
		return result;
	}

	public a m(short A_0, ref bool A_1)
	{
		int A_2 = default(int);
		a result;
		if (l(6, 10, 0, A_3: true, A_0, A_5: true, ref A_2, A_7: false, 0, 0f, checked((byte)A_0)) != 100)
		{
			result = h0.a.d;
		}
		else
		{
			result = h0.a.a;
			A_1 = A_2 != 0;
		}
		return result;
	}

	public a r(int A_0, short A_1)
	{
		a a10 = z();
		if (a10 != h0.a.a)
		{
			return a10;
		}
		int A_2 = 0;
		return (l(4, 0, A_0, A_3: true, A_1, A_5: false, ref A_2, A_7: false, 0, 0f, checked((byte)A_1)) != 100) ? h0.a.d : h0.a.a;
	}

	public a l(short A_0, float A_1)
	{
		int A_2 = 0;
		if (l(6, 8, 0, A_3: true, A_0, A_5: true, ref A_2, A_7: true, 1, A_1, checked((byte)A_0)) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a n(short A_0, ref bool A_1)
	{
		int A_2 = default(int);
		if (l(6, 8, 0, A_3: true, A_0, A_5: true, ref A_2, A_7: false, 0, 0f, checked((byte)A_0)) != 100)
		{
			return h0.a.d;
		}
		A_1 = A_2 == 1;
		return h0.a.a;
	}

	private a l(bool A_0, bool A_1, ref bool A_2, string A_3, bool A_4, ref string A_5, bool A_6, byte A_7, byte A_8, c A_9, string[] A_10)
	{
		short num = 3;
		int num2 = 0;
		checked
		{
			a result;
			try
			{
				string[] array;
				if (A_0)
				{
					if (A_1)
					{
						num = 3;
						array = new string[num - 1 + 1];
						array[0] = "57600,N,8,1";
						array[1] = "14400,N,8,1";
						array[2] = "9600,N,8,1";
					}
					else
					{
						num = 2;
						array = new string[num - 1 + 1];
						array[0] = "14400,N,8,1";
						array[1] = "9600,N,8,1";
					}
				}
				else
				{
					num = 3;
					array = new string[num - 1 + 1];
					array[0] = "57600,N,8,1";
					array[1] = "38400,N,8,1";
					array[2] = "9600,N,8,1";
				}
				List<short> list = new List<short>();
				foreach (string text in A_10)
				{
					list.Add(Conversions.ToShort(text.Substring(3)));
				}
				A_5 = A_5 + "\r\nTotal ports found = " + A_10.Length;
				short num4;
				bool flag = default(bool);
				byte A_14 = default(byte);
				do
				{
					num4 = 0;
					do
					{
						int num5 = -1;
						do
						{
							num5++;
							short num6 = list[num5];
							this.m_a = (FISerBuffMult)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("47B04A5E-A94A-42EB-86F2-E5906A9CDC90")));
							this.g = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("scripting.filesystemobject"));
							int num7 = this.m_a.Init2(num6, ref array[num4], blnBinary: true, ref this.g);
							unchecked
							{
								if (num7 == 0)
								{
									byte b10 = A_7;
									int num9;
									do
									{
										this.m_d = b10;
										short num8 = 0;
										checked
										{
											do
											{
												int A_11 = 0;
												num9 = l(15, 3, 0, A_3: false, 0, A_5: true, ref A_11, A_7: false, 0, 0.2f, 0);
												if (num9 == 101)
												{
													A_11 = 0;
													l(133, 0, 0, A_3: false, 0, A_5: false, ref A_11, A_7: false, 0, 0f, 0);
												}
												else
												{
													num8++;
												}
											}
											while (num4 != 0 && num9 != 100 && num8 < 2);
											b10 = (byte)unchecked((uint)(this.m_d + 1));
										}
									}
									while ((uint)this.m_d <= (uint)A_8 && num9 != 100);
									if (num9 == 100 && l(ref this.m_f) == h0.a.a && ((!A_0) ? (this.m_f == h0.b.b || this.m_f == h0.b.c) : (this.m_f == h0.b.d)))
									{
										if (A_0)
										{
											c A_12 = h0.c.a;
											byte A_13 = 0;
											int A_11 = 0;
											if (l(ref A_12, ref A_13, ref A_11) != h0.a.a)
											{
												flag = false;
											}
											else
											{
												flag = A_9 == h0.c.a || A_12 == A_9;
												if (flag)
												{
													flag = l(ref A_14) == h0.a.a && (uint)A_14 >= (uint)A_7 && (uint)A_14 <= (uint)A_8;
												}
											}
										}
										else
										{
											flag = true;
										}
									}
									else
									{
										flag = false;
									}
									if (flag)
									{
										this.m_b = new hz();
										this.m_b.b(this);
									}
									else
									{
										if (num4 == 0)
										{
											A_5 = A_5 + "\r\n  - Error on COM" + Conversions.ToString((int)num6) + ": Port opened successfully; motor controller not found";
										}
										this.m_a.ShutDown();
										this.m_a = null;
										GC.Collect();
										GC.WaitForPendingFinalizers();
									}
								}
								else if (num4 == 0)
								{
									switch (num7)
									{
									case 8002:
										A_5 = A_5 + "\r\nInvalid Port Number" + num6;
										break;
									case 8005:
										A_5 = A_5 + "\r\n  - Error on COM" + Conversions.ToString((int)num6) + ": Port open failure; port in use by another process";
										break;
									case 8007:
										A_5 = A_5 + "\r\n  - Error on COM" + Conversions.ToString((int)num6) + ": The Device's baud rate is unsupported";
										break;
									case 8010:
										A_5 = A_5 + "\r\n  - Error on COM" + Conversions.ToString((int)num6) + ": The hardware is not available (locked by another device)";
										break;
									case 8013:
										A_5 = A_5 + "\r\n  - Error on COM" + Conversions.ToString((int)num6) + ": The device is already open";
										break;
									case 8019:
										A_5 = A_5 + "\r\n\t- Error on COM" + Conversions.ToString((int)num6) + ": Device busy";
										break;
									default:
										A_5 = A_5 + "\r\n  - Error on COM" + Conversions.ToString((int)num6) + ": Unkown error (" + Conversions.ToString(num7) + ")";
										break;
									case 380:
									case 383:
									case 394:
									case 8000:
									case 8001:
									case 8003:
									case 8004:
									case 8006:
									case 8008:
									case 8009:
									case 8011:
									case 8012:
									case 8014:
									case 8015:
									case 8016:
									case 8018:
										break;
									}
								}
								A_5 = A_5 + "\r\nPort " + A_10[num5].ToString() + " result code = " + num7;
							}
						}
						while (num5 < list.Count - 1 && !flag);
						if (num5 >= list.Count - 1 && !flag)
						{
							num4++;
						}
					}
					while (num4 < num && !flag);
					num2++;
					if (!flag && num2 == 1 && A_6)
					{
						Thread.Sleep(20000);
					}
				}
				while (num2 < 2 && A_6 && !flag);
				a a10;
				if (flag && num4 != 0)
				{
					l(A_0, A_1);
					A_2 = true;
					a10 = h0.a.a;
					A_5 += "\r\nPort initializaion result = 1";
				}
				else if (flag)
				{
					a10 = h0.a.a;
					A_2 = false;
					A_5 += "\r\nPort initializaion result = 2";
				}
				else
				{
					a10 = h0.a.b;
					A_2 = false;
					this.m_a = null;
					if (A_4)
					{
						A_5 = A_3 + " motor controller not detected!\r\n\r\nCorrrective actions: \r\n  1. Verify USB cable connection between computer and controller.\r\n  2. Unplug all USB cables; shutdown computer; wait for shutdown; connect cables; power-up computer.;\r\n\r\nPort search details: " + A_5;
					}
					A_5 += "\r\nPort initializaion result = 3";
				}
				result = a10;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				a a10 = h0.a.c;
				A_5 = A_5 + "\r\n" + ex3.ToString();
				this.m_a = null;
				result = a10;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public void l(object A_0)
	{
		this.m_h.Add(RuntimeHelpers.GetObjectValue(A_0));
	}

	public void m(object A_0)
	{
		this.m_h.Remove(RuntimeHelpers.GetObjectValue(A_0));
		if (this.m_h.Count != 0 || this.m_a == null)
		{
			return;
		}
		this.m_b.c(this);
		if (this.m_b.b())
		{
			try
			{
				this.m_a.ShutDown();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			this.m_a = null;
		}
	}

	private byte l(bool A_0, bool A_1)
	{
		int A_2 = default(int);
		byte result = l(9, 65, (!A_0) ? 5 : ((!A_1) ? 1 : 5), A_3: false, 0, A_5: true, ref A_2, A_7: false, 0, 0f, 0);
		_ = 100;
		return result;
	}

	private byte q()
	{
		int A_ = default(int);
		return l(9, 80, 1, A_3: false, 0, A_5: true, ref A_, A_7: false, 0, 0f, 0);
	}

	private byte p()
	{
		int A_ = default(int);
		byte result = l(15, 5, 0, A_3: true, 0, A_5: true, ref A_, A_7: false, 0, 0f, 0);
		this.m_m = A_ == 0;
		return result;
	}

	private byte l(ref bool A_0)
	{
		int A_1 = default(int);
		byte result = l(15, 3, 0, A_3: true, 0, A_5: true, ref A_1, A_7: false, 0, 0f, 0);
		A_0 = A_1 == 0;
		return result;
	}

	public byte m(ref bool A_0)
	{
		if (t() && this.m_n == InterlockInput.DIN6)
		{
			int A_1 = default(int);
			byte b10 = l(10, 0, 0, A_3: true, 0, A_5: true, ref A_1, A_7: false, 0, 0f, 2);
			if (b10 != 100)
			{
				return b10;
			}
			A_0 = A_1 != 0;
			fd = A_0;
		}
		return 100;
	}

	public a z()
	{
		if (t() && u() == InterlockInput.DIN6 && fd)
		{
			int A_ = 0;
			l(9, 0, 0, A_3: true, 0, A_5: true, ref A_, A_7: false, 0, 0f, 2);
			_ = 100;
			fd = false;
		}
		a result = default(a);
		return result;
	}

	public byte l(ref bool A_0, ref bool A_1)
	{
		if (this.m_m)
		{
			byte b10;
			int A_2 = default(int);
			if (this.m_n == InterlockInput.DIN6)
			{
				b10 = m(ref A_0);
				if (b10 != 100)
				{
					return b10;
				}
				if (A_0)
				{
					b10 = l(15, 6, 0, A_3: true, 0, A_5: true, ref A_2, A_7: false, 0, 0f, 0);
					A_1 = A_2 != 0;
				}
				else
				{
					A_1 = false;
				}
			}
			else
			{
				A_0 = false;
				b10 = l(15, 10, 0, A_3: true, 0, A_5: true, ref A_2, A_7: false, 0, 0f, 0);
				A_1 = A_2 != 0;
			}
			return b10;
		}
		A_0 = false;
		A_1 = false;
		return 100;
	}

	private void l(StreamWriter A_0, byte[] A_1, byte[] A_2)
	{
		A_0.Write("Send: ");
		foreach (byte b10 in A_1)
		{
			A_0.Write(b10 + ", ");
		}
		A_0.WriteLine();
		if (A_2 != null)
		{
			A_0.Write("Receive: ");
			foreach (byte b11 in A_2)
			{
				A_0.Write(b11 + ", ");
			}
		}
	}

	public byte l(ref byte[] A_0, bool A_1, [Optional][DefaultParameterValue(0)] short A_2, [Optional][DefaultParameterValue(0)] ref int A_3, bool A_4 = false, bool A_5 = false, int A_6 = 0, float A_7 = 1.2f)
	{
		object RespData = null;
		this.m_a.AddToQueue(A_0, A_7, m(), A_5, A_6, blnInstrTypeFilm: false, A_1, A_2);
		if (A_4)
		{
			if (l(A_7, A_1, ref A_2) != 0)
			{
				return 10;
			}
			int RespCode = default(int);
			if (this.m_a.GetFromQueue(A_1, A_2, l(), ref RespCode, ref RespData) == 0 && RespCode == 0)
			{
				return h3.a(RuntimeHelpers.GetObjectValue(RespData), ref A_3);
			}
			return 8;
		}
		return 0;
	}

	private string o()
	{
		return Strings.Format(DateAndTime.Now, "HH:mm:ss:fff");
	}

	private void n()
	{
	}

	public byte l(byte A_0, byte A_1, int A_2, bool A_3, [Optional][DefaultParameterValue(0)] short A_4, [Optional][DefaultParameterValue(false)] bool A_5, [Optional][DefaultParameterValue(0)] ref int A_6, bool A_7 = false, int A_8 = 0, float A_9 = 0f, byte A_10 = 0)
	{
		byte[] A_11 = null;
		if (A_9 <= 0f)
		{
			A_9 = 1.2f;
		}
		Stopwatch stopwatch = new Stopwatch();
		h3.a(this.m_d, A_0, A_1, A_2, ref A_11, A_10);
		byte result = l(ref A_11, A_3, A_4, ref A_6, A_5, A_7, A_8, A_9);
		if (A_5)
		{
			return result;
		}
		return 100;
	}

	public byte l(byte A_0, byte A_1, byte A_2, bool A_3 = true)
	{
		byte[] A_4 = null;
		if (this.m_a == null)
		{
			return 2;
		}
		n(0);
		byte result;
		if (A_3)
		{
			byte[] varTheData = new byte[4] { 4, A_0, A_1, A_2 };
			this.m_a.AddToQueue(varTheData, 1.2f, m(), blnAwaitCorrectResponse: false, 0, blnInstrTypeFilm: false, blnInstrTypeMotor: true, 0);
			result = 100;
		}
		else
		{
			h3.a(this.m_d, 129, 1, A_0, ref A_4, 0);
			int A_5 = 0;
			result = l(ref A_4, A_1: true, 0, ref A_5, A_4: true, A_5: false, 0, 60f);
		}
		return result;
	}

	public int l(float A_0, bool A_1, [Optional][DefaultParameterValue(0)] ref short A_2)
	{
		Stopwatch stopwatch = new Stopwatch();
		if (!((_FISerBuffMult)this.m_a).get_SendQueueEmpty(A_1, A_2))
		{
			stopwatch.Start();
			double totalSeconds;
			do
			{
				Thread.Sleep(2);
				Application.DoEvents();
				totalSeconds = stopwatch.Elapsed.TotalSeconds;
			}
			while ((totalSeconds < (double)A_0) & !((_FISerBuffMult)this.m_a).get_SendQueueEmpty(A_1, A_2));
			if (totalSeconds >= (double)A_0)
			{
				return -1;
			}
		}
		return 0;
	}

	private int m()
	{
		int result = i;
		checked
		{
			if (i < 1000000)
			{
				i++;
			}
			else
			{
				i = 1;
			}
			return result;
		}
	}

	private int l()
	{
		if (i == 1)
		{
			return 1000000;
		}
		return checked(i - 1);
	}

	public a o(short A_0, ref bool A_1)
	{
		A_1 = false;
		checked
		{
			int A_2 = default(int);
			if (l(135, 0, 0, A_3: true, A_0, A_5: true, ref A_2, A_7: false, 0, 0f, (byte)A_0) != 100)
			{
				return h0.a.d;
			}
			byte[] array = new byte[4];
			h3.a(A_2, array, 3, 0);
			if (array[0] != 0)
			{
				int A_3 = 0;
				if (l(128, 0, 0, A_3: true, A_0, A_5: false, ref A_3, A_7: false, 0, 0f, (byte)A_0) != 100)
				{
					return h0.a.d;
				}
				A_1 = true;
			}
			return h0.a.a;
		}
	}

	public a n(short A_0)
	{
		int A_1 = 0;
		if (l(131, 0, 0, A_3: true, A_0, A_5: false, ref A_1, A_7: false, 0, 0f, checked((byte)A_0)) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public h1.PublicErrors l(short A_0, bool A_1 = false)
	{
		if (A_1)
		{
			this.m_a.StopFirmwareApp();
			return h1.PublicErrors.None;
		}
		int A_2 = 0;
		if (l(3, 0, 0, A_3: true, A_0, A_5: false, ref A_2, A_7: false, 0, 0f, checked((byte)A_0)) != 100)
		{
			return h1.PublicErrors.RightLimitNonAvailable;
		}
		return h1.PublicErrors.None;
	}

	public a l(string A_0, fz A_1, ref bool A_2)
	{
		int[] A_3 = new int[4];
		string A_4 = null;
		a a10 = l(A_0, ref A_3, ref A_2, ref A_4);
		if (a10 != h0.a.a)
		{
			return a10;
		}
		if (!A_2)
		{
			A_1.c(fz.b.a, "Motor controller Guid mismatch. Existing Guid=" + A_4 + ", target Guid=" + A_0);
			return l(1, 4, A_3);
		}
		return h0.a.a;
	}

	public a l(string A_0, ref int[] A_1, ref bool A_2, ref string A_3)
	{
		return l(1, 4, A_0, ref A_1, ref A_2, ref A_3);
	}

	public a l(ref string A_0)
	{
		return l(1, 4, ref A_0);
	}

	public a m(string A_0, fz A_1, ref bool A_2)
	{
		int[] A_3 = new int[4];
		string A_4 = null;
		a a10 = m(A_0, ref A_3, ref A_2, ref A_4);
		if (a10 != h0.a.a)
		{
			return a10;
		}
		if (!A_2)
		{
			A_1.c(fz.b.a, "Stage unique Guid mismatch. Existing Guid=" + A_4 + ", target Guid=" + A_0);
			return l(9, 12, A_3);
		}
		return h0.a.a;
	}

	private a l(byte A_0, byte A_1, int[] A_2)
	{
		byte b10 = A_1;
		byte b11 = A_0;
		while ((uint)b11 <= (uint)b10)
		{
			checked
			{
				byte b12 = (byte)unchecked((uint)(b11 - A_0));
				byte a_ = b11;
				int a_2 = A_2[b12];
				int A_3 = 0;
				if (l(9, a_, a_2, A_3: true, 0, A_5: false, ref A_3, A_7: false, 0, 0f, 2) != 100)
				{
					return h0.a.d;
				}
				byte a_3 = b11;
				A_3 = 0;
				if (l(11, a_3, 0, A_3: true, 0, A_5: false, ref A_3, A_7: false, 0, 0f, 2) != 100)
				{
					return h0.a.d;
				}
				b11 = (byte)unchecked((uint)(b11 + 1));
			}
		}
		return h0.a.a;
	}

	public a m(string A_0, ref int[] A_1, ref bool A_2, ref string A_3)
	{
		return l(9, 12, A_0, ref A_1, ref A_2, ref A_3);
	}

	private a l(byte A_0, byte A_1, string A_2, ref int[] A_3, ref bool A_4, ref string A_5)
	{
		int[] array = new int[4];
		string[] array2 = new string[4];
		A_3 = new int[4];
		A_4 = true;
		A_5 = null;
		byte b10 = A_1;
		byte b11 = A_0;
		while ((uint)b11 <= (uint)b10)
		{
			checked
			{
				byte b12 = (byte)unchecked((uint)(b11 - A_0));
				array2[b12] = A_2.Substring(b12 * 8, 8);
				A_3[b12] = int.Parse(array2[b12], NumberStyles.HexNumber);
				b11 = (byte)unchecked((uint)(b11 + 1));
			}
		}
		byte b13 = A_1;
		b11 = A_0;
		while ((uint)b11 <= (uint)b13)
		{
			checked
			{
				byte b12 = (byte)unchecked((uint)(b11 - A_0));
				if (l(10, b11, 0, A_3: true, 0, A_5: true, ref array[b12], A_7: false, 0, 0f, 2) != 100)
				{
					A_4 = false;
					return h0.a.d;
				}
				A_5 += Convert.ToString(array[b12], 16);
				if (array[b12] != A_3[b12])
				{
					A_4 = false;
				}
				b11 = (byte)unchecked((uint)(b11 + 1));
			}
		}
		return h0.a.a;
	}

	public a m(ref string A_0)
	{
		return l(9, 12, ref A_0);
	}

	private a l(byte A_0, byte A_1, ref string A_2)
	{
		int[] array = new int[4];
		A_2 = null;
		byte b10 = A_1;
		byte b11 = A_0;
		while ((uint)b11 <= (uint)b10)
		{
			checked
			{
				byte b12 = (byte)unchecked((uint)(b11 - A_0));
				if (l(10, b11, 0, A_3: true, 0, A_5: true, ref array[b12], A_7: false, 0, 0f, 2) != 100)
				{
					return h0.a.d;
				}
				string text = Convert.ToString(array[b12], 16);
				int num = 8 - text.Length;
				for (int num2 = 1; num2 <= num; num2++)
				{
					text = text.Insert(0, "0");
				}
				A_2 += text;
				b11 = (byte)unchecked((uint)(b11 + 1));
			}
		}
		return h0.a.a;
	}

	public a l(ref float A_0)
	{
		int A_1 = default(int);
		if (l(10, 15, 0, A_3: true, 0, A_5: true, ref A_1, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		A_0 = (float)((double)A_1 / 10000.0);
		return h0.a.a;
	}

	public a l(float A_0)
	{
		if (A_0 > 360f)
		{
			A_0 %= 360f;
		}
		else if (A_0 < 0f)
		{
			A_0 = 360f + A_0 % 360f;
		}
		int a_ = checked((int)Math.Round(A_0 * 10000f));
		int A_1 = 0;
		if (l(9, 15, a_, A_3: true, 0, A_5: false, ref A_1, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		A_1 = 0;
		if (l(11, 15, 0, A_3: true, 0, A_5: false, ref A_1, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a l(ref d A_0, ref int A_1)
	{
		if (l(10, 14, 0, A_3: true, 0, A_5: true, ref A_1, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		byte b10 = checked((byte)(A_1 & 0xFF));
		if ((uint)b10 < 1u || (uint)b10 > 2u)
		{
			A_0 = h0.d.a;
		}
		else
		{
			A_0 = (d)b10;
		}
		return h0.a.a;
	}

	public a l(d A_0, ref d A_1, ref bool A_2)
	{
		int A_3 = default(int);
		a a10 = l(ref A_1, ref A_3);
		if (a10 != h0.a.a)
		{
			return a10;
		}
		if (A_1 == A_0)
		{
			A_2 = false;
			return h0.a.a;
		}
		A_2 = true;
		checked
		{
			A_3 = A_3 - unchecked((int)A_1) + unchecked((int)A_0);
			int a_ = A_3;
			int A_4 = 0;
			if (l(9, 14, a_, A_3: true, 0, A_5: false, ref A_4, A_7: false, 0, 0f, 2) != 100)
			{
				return h0.a.d;
			}
			A_4 = 0;
			if (l(11, 14, 0, A_3: true, 0, A_5: false, ref A_4, A_7: false, 0, 0f, 2) != 100)
			{
				return h0.a.d;
			}
			return h0.a.a;
		}
	}

	public a l(ref float A_0, ref int A_1)
	{
		if (l(10, 14, 0, A_3: true, 0, A_5: true, ref A_1, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		A_0 = (float)((double)((A_1 >> 8) & 0xFFFF) / 1000.0);
		return h0.a.a;
	}

	public a m(float A_0)
	{
		checked
		{
			int num = (short)Math.Round(A_0 * 1000f);
			float A_1 = 0f;
			int A_2 = default(int);
			a a10 = l(ref A_1, ref A_2);
			if (a10 != h0.a.a)
			{
				return a10;
			}
			uint num2 = (uint)(A_2 & 0xFF);
			uint num3 = (uint)A_2 >> 24;
			int a_ = (int)(num2 + (uint)(num << 16) + (num3 << 24));
			int A_3 = 0;
			if (l(9, 14, a_, A_3: true, 0, A_5: false, ref A_3, A_7: false, 0, 0f, 2) != 100)
			{
				return h0.a.d;
			}
			A_3 = 0;
			if (l(11, 14, 0, A_3: true, 0, A_5: false, ref A_3, A_7: false, 0, 0f, 2) != 100)
			{
				return h0.a.d;
			}
			return h0.a.a;
		}
	}

	public a l(ref c A_0, ref byte A_1, ref int A_2)
	{
		if (l(10, 7, 0, A_3: true, 0, A_5: true, ref A_2, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		A_1 = checked((byte)(A_2 & 0xFF));
		if (!new List<c>((c[])Enum.GetValues(typeof(c))).Contains((c)A_1))
		{
			A_0 = h0.c.a;
		}
		else
		{
			A_0 = (c)A_1;
		}
		return h0.a.a;
	}

	public a l(c A_0, ref c A_1, ref bool A_2)
	{
		byte A_3 = default(byte);
		int A_4 = default(int);
		a a10 = l(ref A_1, ref A_3, ref A_4);
		if (a10 != h0.a.a)
		{
			return a10;
		}
		if (A_1 == A_0)
		{
			A_2 = false;
			return h0.a.a;
		}
		A_2 = true;
		checked
		{
			A_4 = A_4 - A_3 + unchecked((int)A_0);
			int a_ = A_4;
			int A_5 = 0;
			if (l(9, 7, a_, A_3: true, 0, A_5: false, ref A_5, A_7: false, 0, 0f, 2) != 100)
			{
				return h0.a.d;
			}
			A_5 = 0;
			if (l(11, 7, 0, A_3: true, 0, A_5: false, ref A_5, A_7: false, 0, 0f, 2) != 100)
			{
				return h0.a.d;
			}
			return h0.a.a;
		}
	}

	public a l(ref hg.b A_0, ref int A_1)
	{
		if (l(10, 7, 0, A_3: true, 0, A_5: true, ref A_1, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		byte b10 = checked((byte)(A_1 >> 24));
		if ((uint)b10 > 2u || (uint)b10 < 1u)
		{
			A_0 = hg.b.a;
		}
		else
		{
			A_0 = (hg.b)b10;
		}
		return h0.a.a;
	}

	public a l(hg.b A_0, ref hg.b A_1, ref bool A_2)
	{
		int A_3 = default(int);
		a a10 = l(ref A_1, ref A_3);
		if (a10 != h0.a.a)
		{
			return a10;
		}
		if (A_1 == A_0)
		{
			A_2 = false;
			return h0.a.a;
		}
		A_2 = true;
		checked
		{
			A_3 = (int)(((uint)A_3 << 8 >> 8) + unchecked((int)((uint)A_0 << 24)));
			int a_ = A_3;
			int A_4 = 0;
			if (l(9, 7, a_, A_3: true, 0, A_5: false, ref A_4, A_7: false, 0, 0f, 2) != 100)
			{
				return h0.a.d;
			}
			A_4 = 0;
			if (l(11, 7, 0, A_3: true, 0, A_5: false, ref A_4, A_7: false, 0, 0f, 2) != 100)
			{
				return h0.a.d;
			}
			return h0.a.a;
		}
	}

	public a l(ref bool A_0, ref int A_1)
	{
		if (l(10, 7, 0, A_3: true, 0, A_5: true, ref A_1, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		byte b10 = checked((byte)((A_1 >> 8) & 0xFF));
		A_0 = (2 & b10) == 2;
		return h0.a.a;
	}

	public a l(bool A_0, ref bool A_1, ref bool A_2)
	{
		int A_3 = default(int);
		a a10 = l(ref A_1, ref A_3);
		if (a10 != h0.a.a)
		{
			return a10;
		}
		if (A_1 == A_0)
		{
			A_2 = false;
			return h0.a.a;
		}
		A_2 = true;
		int num = 512;
		int a_ = checked(A_0 ? (A_3 + num) : (A_3 - num));
		int A_4 = 0;
		if (l(9, 7, a_, A_3: true, 0, A_5: false, ref A_4, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		A_4 = 0;
		if (l(11, 7, 0, A_3: true, 0, A_5: false, ref A_4, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a m(ref bool A_0, ref int A_1)
	{
		if (l(10, 7, 0, A_3: true, 0, A_5: true, ref A_1, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		byte b10 = checked((byte)((A_1 >> 8) & 0xFF));
		A_0 = (1 & b10) == 1;
		return h0.a.a;
	}

	public a m(bool A_0, ref bool A_1, ref bool A_2)
	{
		int A_3 = default(int);
		a a10 = m(ref A_1, ref A_3);
		if (a10 != h0.a.a)
		{
			return a10;
		}
		if (A_1 == A_0)
		{
			A_2 = false;
			return h0.a.a;
		}
		A_2 = true;
		int num = 256;
		int a_ = checked(A_0 ? (A_3 + num) : (A_3 - num));
		int A_4 = 0;
		if (l(9, 7, a_, A_3: true, 0, A_5: false, ref A_4, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		A_4 = 0;
		if (l(11, 7, 0, A_3: true, 0, A_5: false, ref A_4, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a n(ref bool A_0, ref int A_1)
	{
		if (l(10, 7, 0, A_3: true, 0, A_5: true, ref A_1, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		byte b10 = checked((byte)((A_1 >> 8) & 0xFF));
		A_0 = (4 & b10) == 4;
		return h0.a.a;
	}

	public a n(bool A_0, ref bool A_1, ref bool A_2)
	{
		int A_3 = default(int);
		a a10 = n(ref A_1, ref A_3);
		if (a10 != h0.a.a)
		{
			return a10;
		}
		if (A_1 == A_0)
		{
			A_2 = false;
			return h0.a.a;
		}
		A_2 = true;
		int num = 1024;
		int a_ = checked(A_0 ? (A_3 + num) : (A_3 - num));
		int A_4 = 0;
		if (l(9, 7, a_, A_3: true, 0, A_5: false, ref A_4, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		A_4 = 0;
		if (l(11, 7, 0, A_3: true, 0, A_5: false, ref A_4, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a l(ref f A_0, ref int A_1)
	{
		if (l(10, 7, 0, A_3: true, 0, A_5: true, ref A_1, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		byte b10 = checked((byte)((A_1 >> 8) & 0xFF));
		bool flag = (0x20 & b10) == 32;
		bool num = (0x80 & b10) == 128;
		A_0 = h0.f.a;
		if (flag)
		{
			A_0 = (f)checked((byte)(unchecked((int)A_0) + 1));
		}
		if (num)
		{
			A_0 = (f)checked((byte)(unchecked((int)A_0) + 2));
		}
		return h0.a.a;
	}

	public a l(f A_0, ref f A_1, ref bool A_2)
	{
		int A_3 = default(int);
		a a10 = l(ref A_1, ref A_3);
		if (a10 != h0.a.a)
		{
			return a10;
		}
		if (A_1 == A_0)
		{
			A_2 = false;
			return h0.a.a;
		}
		A_2 = true;
		bool flag;
		bool flag2;
		byte b11;
		int num2;
		checked
		{
			byte b10 = (byte)((A_3 >> 8) & 0xFF);
			int num = b10 << 8;
			num2 = A_3 - num;
			flag = false;
			flag2 = false;
			switch (A_0)
			{
			case h0.f.b:
				flag = true;
				break;
			case h0.f.c:
				flag2 = true;
				break;
			case h0.f.d:
				flag = true;
				flag2 = true;
				break;
			}
			b11 = b10;
		}
		b11 = (byte)((!flag) ? (b11 & 0xDF) : (b11 | 0x20));
		b11 = (byte)((!flag2) ? (b11 & 0x7F) : (b11 | 0x80));
		num2 = checked(num2 + (b11 << 8));
		int a_ = num2;
		int A_4 = 0;
		if (l(9, 7, a_, A_3: true, 0, A_5: false, ref A_4, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		A_4 = 0;
		if (l(11, 7, 0, A_3: true, 0, A_5: false, ref A_4, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a o(ref bool A_0, ref int A_1)
	{
		if (l(10, 7, 0, A_3: true, 0, A_5: true, ref A_1, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		byte b10 = checked((byte)((A_1 >> 8) & 0xFF));
		A_0 = (0x40 & b10) == 64;
		return h0.a.a;
	}

	public a o(bool A_0, ref bool A_1, ref bool A_2)
	{
		int A_3 = default(int);
		a a10 = o(ref A_1, ref A_3);
		if (a10 != h0.a.a)
		{
			return a10;
		}
		if (A_1 == A_0)
		{
			A_2 = false;
			return h0.a.a;
		}
		A_2 = true;
		int num = 16384;
		int a_ = checked(A_0 ? (A_3 + num) : (A_3 - num));
		int A_4 = 0;
		if (l(9, 7, a_, A_3: true, 0, A_5: false, ref A_4, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		A_4 = 0;
		if (l(11, 7, 0, A_3: true, 0, A_5: false, ref A_4, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a p(ref bool A_0, ref int A_1)
	{
		if (l(10, 7, 0, A_3: true, 0, A_5: true, ref A_1, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		byte b10 = checked((byte)((A_1 >> 8) & 0xFF));
		A_0 = (0x10 & b10) == 16;
		return h0.a.a;
	}

	public a p(bool A_0, ref bool A_1, ref bool A_2)
	{
		int A_3 = default(int);
		a a10 = p(ref A_1, ref A_3);
		if (a10 != h0.a.a)
		{
			return a10;
		}
		if (A_1 == A_0)
		{
			A_2 = false;
			return h0.a.a;
		}
		A_2 = true;
		int num = 4096;
		int a_ = checked(A_0 ? (A_3 + num) : (A_3 - num));
		int A_4 = 0;
		if (l(9, 7, a_, A_3: true, 0, A_5: false, ref A_4, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		A_4 = 0;
		if (l(11, 7, 0, A_3: true, 0, A_5: false, ref A_4, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a q(ref bool A_0, ref int A_1)
	{
		if (l(10, 7, 0, A_3: true, 0, A_5: true, ref A_1, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		byte b10 = checked((byte)((A_1 >> 8) & 0xFF));
		A_0 = (8 & b10) == 8;
		return h0.a.a;
	}

	public a q(bool A_0, ref bool A_1, ref bool A_2)
	{
		int A_3 = default(int);
		a a10 = q(ref A_1, ref A_3);
		if (a10 != h0.a.a)
		{
			return a10;
		}
		if (A_1 == A_0)
		{
			A_2 = false;
			return h0.a.a;
		}
		A_2 = true;
		int num = 2048;
		int a_ = checked(A_0 ? (A_3 + num) : (A_3 - num));
		int A_4 = 0;
		if (l(9, 7, a_, A_3: true, 0, A_5: false, ref A_4, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		A_4 = 0;
		if (l(11, 7, 0, A_3: true, 0, A_5: false, ref A_4, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a l(ref float A_0, ref float A_1)
	{
		int A_2 = default(int);
		if (l(10, 8, 0, A_3: true, 0, A_5: true, ref A_2, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		int num = A_2 >> 16;
		int num2 = A_2 << 16 >> 16;
		A_0 = (float)((double)num / 10.0);
		A_1 = (float)((double)num2 / 10.0);
		return h0.a.a;
	}

	public a l(float A_0, float A_1)
	{
		checked
		{
			short num = (short)Math.Round(A_0 * 10f);
			int num2 = (short)Math.Round(A_1 * 10f);
			int a_ = (num << 16) + num2;
			int A_2 = 0;
			if (l(9, 8, a_, A_3: true, 0, A_5: false, ref A_2, A_7: false, 0, 0f, 2) != 100)
			{
				return h0.a.d;
			}
			A_2 = 0;
			if (l(11, 8, 0, A_3: true, 0, A_5: false, ref A_2, A_7: false, 0, 0f, 2) != 100)
			{
				return h0.a.d;
			}
			return h0.a.a;
		}
	}

	public a m(ref float A_0, ref float A_1)
	{
		int A_2 = default(int);
		if (l(10, 13, 0, A_3: true, 0, A_5: true, ref A_2, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		int num = A_2 >> 16;
		int num2 = A_2 << 16 >> 16;
		A_0 = (float)((double)num / 1000.0);
		A_1 = (float)((double)num2 / 1000.0);
		return h0.a.a;
	}

	public a m(float A_0, float A_1)
	{
		checked
		{
			short num = (short)Math.Round(A_0 * 1000f);
			int num2 = (short)Math.Round(A_1 * 1000f);
			int a_ = (num << 16) + num2;
			int A_2 = 0;
			if (l(9, 13, a_, A_3: true, 0, A_5: false, ref A_2, A_7: false, 0, 0f, 2) != 100)
			{
				return h0.a.d;
			}
			A_2 = 0;
			if (l(11, 13, 0, A_3: true, 0, A_5: false, ref A_2, A_7: false, 0, 0f, 2) != 100)
			{
				return h0.a.d;
			}
			return h0.a.a;
		}
	}

	public a n(ref string A_0)
	{
		int[] array = new int[2];
		char[] array2 = new char[8];
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		byte[] array3 = new byte[1];
		byte b10 = 5;
		do
		{
			checked
			{
				byte b11 = (byte)unchecked((uint)(b10 - 5));
				if (l(10, b10, 0, A_3: true, 0, A_5: true, ref array[b11], A_7: false, 0, 0f, 2) != 100)
				{
					return h0.a.d;
				}
				b10 = (byte)unchecked((uint)(b10 + 1));
			}
		}
		while ((uint)b10 <= 6u);
		b10 = 0;
		do
		{
			byte b11 = 0;
			checked
			{
				do
				{
					array3[0] = (byte)(array[b10] & 0xFF);
					array2[b10 * 4 + 3 - b11] = aSCIIEncoding.GetChars(array3)[0];
					array[b10] >>= 8;
					b11 = (byte)unchecked((uint)(b11 + 1));
				}
				while (unchecked((uint)b11) <= 3u);
				b10 = (byte)unchecked((uint)(b10 + 1));
			}
		}
		while ((uint)b10 <= 1u);
		A_0 = new string(array2, 0, 8);
		A_0 = A_0.TrimEnd(' ');
		return h0.a.a;
	}

	public a l(string A_0, ref string A_1, ref bool A_2)
	{
		int[] array = new int[2];
		char[] array2 = new char[8];
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		if (A_0 == null || A_0.Length > 8)
		{
			throw new Exception("Invalid serial number. Maximum SN length is " + (byte)8);
		}
		a a10 = n(ref A_1);
		if (a10 != h0.a.a)
		{
			return a10;
		}
		if (Operators.CompareString(A_1, A_0, TextCompare: false) == 0)
		{
			A_2 = false;
			return h0.a.a;
		}
		A_2 = true;
		checked
		{
			if (A_0.Length < 8)
			{
				A_0 += Strings.Space(8 - A_0.Length);
			}
			byte b10 = 0;
			do
			{
				array2[b10] = A_0[b10];
				b10 = (byte)unchecked((uint)(b10 + 1));
			}
			while (unchecked((uint)b10) <= 7u);
			b10 = 0;
			int num = default(int);
			do
			{
				byte b11 = 0;
				do
				{
					num <<= 8;
					num += aSCIIEncoding.GetBytes(array2, b10 * 4 + b11, 1)[0];
					b11 = (byte)unchecked((uint)(b11 + 1));
				}
				while (unchecked((uint)b11) <= 3u);
				array[b10] = num;
				b10 = (byte)unchecked((uint)(b10 + 1));
			}
			while (unchecked((uint)b10) <= 1u);
			b10 = 5;
			do
			{
				byte b11 = (byte)unchecked((uint)(b10 - 5));
				byte a_ = b10;
				int a_2 = array[b11];
				int A_3 = 0;
				if (l(9, a_, a_2, A_3: true, 0, A_5: false, ref A_3, A_7: false, 0, 0f, 2) != 100)
				{
					return h0.a.d;
				}
				byte a_3 = b10;
				A_3 = 0;
				if (l(11, a_3, 0, A_3: true, 0, A_5: false, ref A_3, A_7: false, 0, 0f, 2) != 100)
				{
					return h0.a.d;
				}
				b10 = (byte)unchecked((uint)(b10 + 1));
			}
			while (unchecked((uint)b10) <= 6u);
			return h0.a.a;
		}
	}

	public a l(ref b A_0)
	{
		int A_1 = default(int);
		if (l(136, 1, 0, A_3: true, 1, A_5: true, ref A_1, A_7: false, 0, 0f, 2) != 100)
		{
			return h0.a.d;
		}
		switch (A_1 >> 16)
		{
		case 1:
			A_0 = h0.b.b;
			break;
		case 341:
			A_0 = h0.b.c;
			break;
		case 1021:
			A_0 = h0.b.d;
			break;
		default:
			A_0 = h0.b.a;
			break;
		}
		return h0.a.a;
	}

	public a l(byte A_0)
	{
		int A_1 = 0;
		if (l(9, 66, A_0, A_3: true, 0, A_5: true, ref A_1, A_7: false, 0, 0f, 0) != 100)
		{
			return h0.a.d;
		}
		this.m_d = A_0;
		return h0.a.a;
	}

	public a l(ref byte A_0)
	{
		int A_1 = default(int);
		if (l(10, 66, 0, A_3: true, 1, A_5: true, ref A_1, A_7: false, 0, 0f, 0) != 100)
		{
			return h0.a.d;
		}
		A_0 = checked((byte)A_1);
		return h0.a.a;
	}

	public a o(short A_0)
	{
		int A_1 = 0;
		if (l(9, 76, A_0, A_3: true, 1, A_5: true, ref A_1, A_7: false, 0, 0f, 0) != 100)
		{
			return h0.a.d;
		}
		return h0.a.a;
	}

	public a l(ref short A_0)
	{
		int A_1 = default(int);
		if (l(10, 76, 0, A_3: true, 1, A_5: true, ref A_1, A_7: false, 0, 0f, 0) != 100)
		{
			return h0.a.d;
		}
		A_0 = checked((short)A_1);
		return h0.a.a;
	}

	public a m(ref short A_0)
	{
		int A_1 = default(int);
		if (l(10, 65, 0, A_3: true, 1, A_5: true, ref A_1, A_7: false, 0, 0f, 0) != 100)
		{
			return h0.a.d;
		}
		A_0 = checked((short)A_1);
		return h0.a.a;
	}

	public h0()
	{
		this.m_h = new List<object>();
		this.m_r = false;
		this.m_s = string.Empty;
		this.m_t = string.Empty;
		this.m_u = new Collection<string>();
		this.m_v = RuntimeHelpers.GetObjectValue(new object());
		this.m_e = 3f;
		i = 1;
	}

	~h0()
	{
		this.m_a = null;
		base.Finalize();
		GC.Collect();
	}
}
