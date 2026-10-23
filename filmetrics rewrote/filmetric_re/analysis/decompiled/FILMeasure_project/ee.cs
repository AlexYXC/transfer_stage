using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class ee : d3
{
	private new class a : d3.a
	{
		private new const short m_e = 8;

		private const short m_f = 15;

		private const short m_g = 1032;

		private const short m_h = 1296;

		private new const int m_i = 1;

		public a()
		{
			c = 15;
			d = 8;
		}

		public static int j(int A_0)
		{
			return checked(A_0 - 1 - 1 - 1) / 2;
		}

		public int e()
		{
			return j(a);
		}

		public static int i(int A_0)
		{
			return checked(A_0 - 1 - 1) / 2;
		}

		public int f()
		{
			return i(b);
		}

		public static int h(int A_0)
		{
			return checked(A_0 * 2 + 1 + 1 + 1);
		}

		public int g()
		{
			return h(a);
		}

		public static int g(int A_0)
		{
			return checked(A_0 * 2 + 1 + 1);
		}

		public int h()
		{
			return h(b);
		}

		protected override void s(int A_0, int A_1, int A_2, int A_3)
		{
			if (A_2 > a)
			{
				w(A_0);
				u(A_2);
			}
			else
			{
				u(A_2);
				w(A_0);
			}
			if (A_3 > b)
			{
				v(A_1);
				t(A_3);
			}
			else
			{
				t(A_3);
				v(A_1);
			}
		}

		protected override void t(int A_0)
		{
			int num = g(A_0);
			if (num > 1024)
			{
				throw new ApplicationException("RawHeight must be <=" + 1024);
			}
			base.t(num);
		}

		protected override void u(int A_0)
		{
			int num = h(A_0);
			if (num > 1281)
			{
				throw new ApplicationException("RawWidth must be <=" + 1281);
			}
			base.u(num);
		}

		protected override void v(int A_0)
		{
			if (A_0 < 0)
			{
				throw new ApplicationException("StartRow must be >0");
			}
			int num = 1024;
			checked
			{
				if (A_0 * 2 + b > num)
				{
					throw new ApplicationException("StartRow*2 + height must be <=" + num);
				}
				base.v(A_0 * 2 + 8);
			}
		}

		protected override void w(int A_0)
		{
			if (A_0 < 0)
			{
				throw new ApplicationException("StartCol must be >0");
			}
			int num = 1281;
			checked
			{
				if (A_0 * 2 + a > num)
				{
					throw new ApplicationException("StartCol*2 + width must be <=" + num);
				}
				base.w(A_0 * 2 + 15);
			}
		}

		private bool f(int A_0)
		{
			return (A_0 & 1) == 1;
		}

		private bool e(int A_0)
		{
			return (A_0 & 1) == 0;
		}
	}

	private new const int fq = 1281;

	private new const int fr = 1024;

	private new const int fs = 2;

	private new const int ft = 1;

	private const float fu = 100f;

	private const float fv = 200000f;

	private const int fw = 32;

	private const short fx = 250;

	private const short fy = 200;

	private const short fz = 240;

	private byte[] f0;

	private byte[] f1;

	private byte[] f2;

	private Bitmap f3;

	private IntPtr f4;

	private float f5;

	private float f6;

	private float f7;

	private int f8;

	private int f9;

	private int ga;

	private const int gb = 6;

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ICBayerConversion(ref byte A_0, ref byte A_1, int A_2, int A_3, int A_4);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ICColorSpaceConversion(ref byte A_0, ref byte A_1, int A_2, int A_3, int A_4);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ICWhiteBalanceCalcRatio(ref byte A_0, ref float A_1, ref float A_2, ref float A_3, int A_4, int A_5);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ICWhiteBalanceCorrectImage(ref byte A_0, float A_1, float A_2, float A_3, int A_4, int A_5);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ICGetBrightestPixels(ref byte A_0, ref byte A_1, ref byte A_2, ref byte A_3, int A_4, int A_5);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ICShrinkImage(ref byte A_0, ref byte A_1, int A_2, int A_3);

	public ee(fz A_0)
		: base(A_0, "ColorCam")
	{
		f0 = new byte[1311745];
		f1 = new byte[5246977];
		f2 = new byte[1311745];
		f5 = global::e.a().WhiteR;
		f6 = global::e.a().WhiteG;
		f7 = global::e.a().WhiteB;
	}

	protected override void n()
	{
		base.fr = new a();
		base.fs = new a();
	}

	public override int o()
	{
		int num = ae.SetHWNumCameras(1);
		if (num != 0)
		{
			return num;
		}
		string A_ = Application.StartupPath + "\\SensorConfig.txt";
		num = d3.InitCam(0, ref A_, 0);
		if (num != 0)
		{
			return num;
		}
		num = d3.SSSetCamGainParam(0, 12);
		if (num != 0)
		{
			return num;
		}
		d3.a a10 = base.fs;
		num = checked(m2((short)a10.l(), (short)a10.k(), (short)a10.j(), (short)a10.i()));
		a10 = null;
		if (num != 0)
		{
			return num;
		}
		return m2(base.ft);
	}

	private int m2(short A_0, short A_1, short A_2, short A_3)
	{
		int num = d3.FMImageSetFrameSize(0, A_2);
		if (num == 0)
		{
			num = d3.SSSetROIStart(0, A_1, A_0, A_3);
		}
		return num;
	}

	public int m2(double A_0)
	{
		if (A_0 > 200000.0)
		{
			A_0 = 200000.0;
		}
		else if (A_0 < 100.0)
		{
			A_0 = 100.0;
		}
		double A_1 = default(double);
		double A_2 = default(double);
		d3.FMImageCalcMinFrameTime(0, A_0, ref A_1, ref A_2);
		int result = d3.FMImageSetIntTime(0, A_1, A_2);
		base.ft = A_0;
		return result;
	}

	protected override void f(m A_0)
	{
		switch (A_0.a)
		{
		case m.a.m:
			qh(A_0);
			break;
		case m.a.n:
			p9(A_0);
			break;
		}
	}

	protected override void g(m A_0)
	{
	}

	protected override void h(m A_0)
	{
	}

	public override global::r.a p(string A_0, string A_1, global::r.d A_2, l A_3, global::r.d.a.b A_4)
	{
		m m2 = new m(A_4);
		m2.d = m.TaskExecutionType.Camera;
		m2.a = m.a.m;
		m2.f = A_0;
		m2.g = A_2;
		m2.l = A_3;
		this.m2();
		_ = null;
		if (sj(m2) != global::r.a.a)
		{
			return global::r.a.b;
		}
		global::r.a result = default(global::r.a);
		return result;
	}

	public global::r.a m2(string A_0, string A_1, global::r.d A_2, global::r.d A_3, global::r.d.a.b A_4)
	{
		e e10 = new e(A_4);
		e10.d = m.TaskExecutionType.Camera;
		((m)e10).a = m.a.n;
		e10.dz = A_3;
		e10.f = A_0;
		e10.g = A_2;
		_ = null;
		if (sj(e10) != global::r.a.a)
		{
			return global::r.a.b;
		}
		global::r.a result = default(global::r.a);
		return result;
	}

	[SpecialName]
	public override int q()
	{
		return a.j(1281);
	}

	[SpecialName]
	public override int r()
	{
		return a.i(1024);
	}

	private void qh(m A_0)
	{
		d d10 = new d(A_0.d3());
		a a10 = (a)base.fr;
		bool flag = false;
		a a11 = a10;
		if (a11.i() <= 0 || a11.j() <= 0)
		{
			return;
		}
		if (a11.i() != base.fs.i() || a11.j() != base.fs.j() || f3 == null)
		{
			flag = true;
			if (f3 != null)
			{
				d3.DeleteObject(f4);
				f3.Dispose();
			}
			f3 = new Bitmap(a11.e(), a11.f());
			f4 = f3.GetHbitmap();
			m2();
		}
		if (a11.k() != base.fs.k() || a11.l() != base.fs.l())
		{
			flag = true;
		}
		checked
		{
			if (flag)
			{
				m2((short)a11.l(), (short)a11.k(), (short)a11.j(), (short)a11.i());
				base.fs = a10;
				m2(base.ft);
			}
			a11 = null;
			int imageData = d3.GetImageData(0, ref f0[0]);
			if (f8 <= 6)
			{
				f8++;
			}
			if (imageData == 0)
			{
				d3.a a12 = base.fs;
				byte A_1 = default(byte);
				byte A_2 = default(byte);
				byte A_3 = default(byte);
				int num = ICGetBrightestPixels(ref f0[0], ref A_1, ref A_2, ref A_3, a12.i(), a12.j());
				if (num != 0)
				{
					ab8().c(global::fz.b.a, "Error attempting ICCheckBrightestPixel", Environment.StackTrace.ToString());
				}
				byte a_ = A_1;
				byte a_2 = A_2;
				byte a_3 = A_3;
				bool A_4 = false;
				m2(a_, a_2, a_3, ref A_4);
				int num2 = ICWhiteBalanceCorrectImage(ref f0[0], f7, f5, f6, a12.i(), a12.j());
				if (num2 != 0)
				{
					ab8().c(global::fz.b.a, "Error attempting ICWhiteBalanceImage", Environment.StackTrace.ToString());
				}
				a12 = null;
				if (f8 <= 6)
				{
					f9++;
				}
				else if (ga > 0)
				{
					f9++;
					ga--;
				}
				if (num2 != 0 || num != 0)
				{
					((global::r.d.a)d10).a = global::r.d.a.a.b;
					A_0.g.d(default(Guid), d10);
					string a_4 = ((num2 == 0) ? ("Error in ICGetBrightestPixels. Error code=" + num.ToString(CultureInfo.InvariantCulture)) : ("Error in ICWhiteBalanceCorrectImage. Error code=" + num2.ToString(CultureInfo.InvariantCulture)));
					A_0.l.q(0, global::r.d.a.a.b, a_4, 0f, 0f, A_5: true);
				}
				else
				{
					m2(A_0);
				}
			}
			else
			{
				if (f8 <= 6)
				{
					ga++;
				}
				else if (f9 > 0)
				{
					f9--;
					ga++;
				}
				((global::r.d.a)d10).a = global::r.d.a.a.b;
				((global::r.d.a)d10).b = "Dropped frame";
				m2(d10);
				A_0.g.d(default(Guid), d10);
			}
		}
	}

	private void p9(m A_0)
	{
		bool A_1 = true;
		byte A_2 = 0;
		byte A_3 = 0;
		byte A_4 = 0;
		d d10 = new d(A_0.d3());
		e e10 = new e(A_0.d3());
		((m)e10).a = m.a.m;
		e10.g = ((e)A_0).dz;
		qh(e10);
		d3.a a10 = base.fs;
		int num;
		do
		{
			d3.GetImageData(0, ref f0[0]);
			num = ICGetBrightestPixels(ref f0[0], ref A_2, ref A_3, ref A_4, a10.i(), a10.j());
			m2(A_2, A_3, A_4, ref A_1);
			m2(e10);
		}
		while (A_1);
		int num2 = ICWhiteBalanceCalcRatio(ref f0[0], ref f7, ref f5, ref f6, a10.i(), a10.j());
		if (num2 != 0)
		{
			ab8().c(global::fz.b.a, "Error attempting ICWhiteBalanceCalcRatio", Environment.StackTrace.ToString());
		}
		int num3 = ICWhiteBalanceCorrectImage(ref f0[0], f7, f5, f6, a10.i(), a10.j());
		if (num3 != 0)
		{
			ab8().c(global::fz.b.a, "Error attempting ICWhiteBalanceImage", Environment.StackTrace.ToString());
		}
		global::e.a().WhiteB = f7;
		global::e.a().WhiteG = f6;
		global::e.a().WhiteR = f5;
		ICWhiteBalanceCorrectImage(ref f0[0], f7, f5, f6, a10.i(), a10.j());
		a10 = null;
		qh(e10);
		if (num != 0 || num2 != 0 || num3 != 0)
		{
			((global::r.d.a)d10).a = global::r.d.a.a.b;
			A_0.g.d(default(Guid), d10);
		}
		else
		{
			((global::r.d.a)d10).a = global::r.d.a.a.a;
			A_0.g.d(default(Guid), d10);
		}
	}

	private void m2(byte A_0, byte A_1, byte A_2, [Optional][DefaultParameterValue(false)] ref bool A_3)
	{
		if (A_0 >= 250 || A_2 >= 250 || A_1 >= 250 || (float)(int)A_1 * f6 > 255f || (float)(int)A_0 * f5 > 255f || (float)(int)A_2 * f7 > 255f)
		{
			base.ft /= 1.5;
			A_3 = true;
		}
		else if ((float)(int)A_0 * f5 < 200f && (float)(int)A_1 * f6 < 200f && (float)(int)A_2 * f7 < 200f)
		{
			byte b11;
			checked
			{
				byte b10 = (byte)Math.Round(unchecked(Math.Max((float)(int)A_0 * f5, (float)(int)A_1 * f6)));
				b11 = (byte)Math.Round(unchecked(Math.Max((float)(int)A_2 * f7, (int)b10)));
			}
			if (b11 < 10)
			{
				base.ft *= 10.0;
			}
			else
			{
				base.ft = 240.0 / (double)(int)b11 * base.ft;
			}
			A_3 = true;
		}
		else
		{
			A_3 = false;
		}
		if (A_3)
		{
			m2(base.ft);
			d3.GetImageData(0, ref f0[0]);
		}
	}

	private void m2(m A_0)
	{
		d d10 = new d(A_0.d3());
		a a10 = (a)base.fs;
		checked
		{
			int num = ICBayerConversion(ref f0[0], ref f1[0], a10.i() - 1, a10.j(), a10.i());
			if (num != 0)
			{
				ab8().c(global::fz.b.a, "Error attempting ICBayerConversion", Environment.StackTrace.ToString());
			}
			int num2 = ICShrinkImage(ref f1[0], ref f2[0], a10.i() - 1, a10.j());
			if (num2 != 0)
			{
				ab8().c(global::fz.b.a, "Error attempting ICShrinkImage", Environment.StackTrace.ToString());
			}
			int num3 = a10.e();
			int num4 = a10.f();
			int num5 = d3.SetBitmapBits(f4, num3 * num4 * 4, ref f2[0]);
			if (num5 == 0)
			{
				ab8().c(global::fz.b.a, "Error attempting SetBitmapBits", Environment.StackTrace.ToString());
			}
			d10.a2 = f4;
			if (num != 0 || num2 != 0 || num5 == 0)
			{
				((global::r.d.a)d10).a = global::r.d.a.a.b;
				A_0.g.d(default(Guid), d10);
				if (A_0.l != null)
				{
					string a_ = ((num != 0) ? ("Error in ICBayerConversion. Error code=" + num.ToString(CultureInfo.InvariantCulture)) : ((num2 == 0) ? ("Error in SetBitmapBits. Error code=" + num5.ToString(CultureInfo.InvariantCulture)) : ("Error in ICShrinkImage. Error code=" + num2.ToString(CultureInfo.InvariantCulture))));
					A_0.l.q(0, global::r.d.a.a.b, a_, 0f, 0f, A_5: true);
				}
			}
			else
			{
				((global::r.d.a)d10).a = global::r.d.a.a.a;
				d10.a4 = num3;
				d10.a5 = num4;
				m2(d10);
				A_0.g.d(default(Guid), d10);
			}
			a10 = null;
		}
	}

	private void m2(d A_0)
	{
		if (f8 < 6)
		{
			A_0.a3 = 0.375f;
		}
		else
		{
			A_0.a3 = (float)((double)ga / (double)f8);
		}
	}

	private void m2()
	{
		f8 = 0;
		f9 = 0;
		ga = 0;
	}
}
