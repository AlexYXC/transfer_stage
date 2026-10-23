using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

internal abstract class d3 : r
{
	public new class a
	{
		protected int a;

		protected int b;

		protected int c;

		protected int d;

		public a e(int A_0, int A_1, int A_2, int A_3)
		{
			a obj = m();
			obj.s(A_0, A_1, A_2, A_3);
			return obj;
		}

		public a e(int A_0, int A_1)
		{
			a obj = m();
			obj.u(A_0);
			obj.t(A_1);
			return obj;
		}

		public a k(int A_0)
		{
			a obj = m();
			obj.v(A_0);
			return obj;
		}

		public a l(int A_0)
		{
			a obj = m();
			obj.w(A_0);
			return obj;
		}

		[SpecialName]
		public int i()
		{
			return a;
		}

		[SpecialName]
		public int j()
		{
			return b;
		}

		[SpecialName]
		public int k()
		{
			return c;
		}

		[SpecialName]
		public int l()
		{
			return d;
		}

		protected virtual void s(int A_0, int A_1, int A_2, int A_3)
		{
			c = A_0;
			d = A_1;
			a = A_2;
			b = A_3;
		}

		protected virtual void t(int A_0)
		{
			b = A_0;
		}

		protected virtual void u(int A_0)
		{
			a = A_0;
		}

		protected virtual void v(int A_0)
		{
			d = A_0;
		}

		protected virtual void w(int A_0)
		{
			c = A_0;
		}

		public a m()
		{
			return (a)MemberwiseClone();
		}
	}

	public enum b
	{
		a,
		b
	}

	public new enum c
	{
		a,
		b
	}

	internal new class d : global::r.d.a
	{
		public int a1;

		public IntPtr a2;

		public float a3;

		public int a4;

		public int a5;

		public d(b A_0)
			: base(A_0, 0L)
		{
		}
	}

	protected new class e : m
	{
		public global::r.d dz;

		public e(global::r.d.a.b A_0)
			: base(A_0)
		{
		}
	}

	public new const string t = "Dropped frame";

	public const float fp = 0.5f;

	public const float fq = 0.25f;

	protected a fr;

	protected a fs;

	protected double ft;

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	protected static extern int InitCam(short A_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_1, short A_2);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	protected static extern int FMImageSetFrameSize(short A_0, short A_1);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	protected static extern int SSSetROIStart(short A_0, short A_1, short A_2, short A_3);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	protected static extern int FMImageCalcMinFrameTime(short A_0, double A_1, ref double A_2, ref double A_3);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	protected static extern int FMImageSetIntTime(short A_0, double A_1, double A_2);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	protected static extern int GetImageData(short A_0, ref byte A_1);

	[DllImport("gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	protected static extern bool DeleteObject(IntPtr A_0);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	protected static extern int SSSetCamGainParam(short A_0, short A_1);

	[DllImport("gdi32.dll")]
	protected static extern int SetBitmapBits(IntPtr A_0, int A_1, ref byte A_2);

	public abstract global::r.a p(string A_0, string A_1, global::r.d A_2, l A_3, global::r.d.a.b A_4);

	public d3(fz A_0, string A_1)
		: base(A_0, A_1)
	{
		ft = 1000.0;
		n();
	}

	protected virtual void n()
	{
		fr = new a();
		fs = new a();
	}

	public abstract int o();

	public global::r.a p9()
	{
		global::r.a result;
		try
		{
			result = z0();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			result = global::r.a.c;
			ab8().c(fz.b.b, "Exception caught in Camera.InitThread(). Exception is: " + ex3.Message);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void m2(int A_0, int A_1, int A_2, int A_3)
	{
		fr = fr.e(A_0, A_1, A_2, A_3);
	}

	[SpecialName]
	public abstract int q();

	[SpecialName]
	public abstract int r();
}
