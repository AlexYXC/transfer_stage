using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal abstract class b9 : p, IDisposable
{
	public enum ErrPublic
	{
		None,
		Generic,
		SolverArgs,
		Solver,
		NoLayersSelectedForMeasurement,
		SolvingAborted,
		InitNKCoeffsInvalid,
		InvalidDConstraints,
		InvalidNConstraints,
		InvalidKConstraints,
		InvalidMixtureData,
		InsufficientData,
		InvalidSolarData,
		InvalidIlluminanceData,
		OutOfCorrelativeRange,
		ModelCoeffIncompatWithInitialN,
		ModelCoeffIncompatWithInitialK,
		OnlyExactSpectrumAnalysisPermittedForRAtAngle,
		ZAREModelUsedInMultipleLayersWithinSingleStack,
		ZAREAttemptToSolveForKWithoutTrans,
		ZAREAttemptToSolveForXKWithoutReflTrans,
		ZAREAttemptToSolveForNWithoutRAngle,
		ZAREAttemptToSolveForDNWithoutRAngle,
		ZAREAttemptToSolveForDNWithoutR0OrT,
		ZAREAttemptToSolveForDNKWithoutDoubleRefl,
		ZAREInsufficientWavelengthOverlapBetweenSpectrumTypes,
		ZAREMismatchedSolveForDInSameLayers,
		ZAREIndependentDForSameNorK,
		ZAREDesignError
	}

	protected new enum a
	{
		a = 0,
		b = a,
		c = 1,
		d = 2,
		e = 3,
		f = 4
	}

	protected new enum b
	{
		a = 0,
		b = a,
		c = 1,
		d = 2,
		e = 3,
		f = 4,
		g = 5
	}

	protected enum c
	{
		a = 6,
		b = 0,
		c = b,
		d = 1,
		e = d,
		f = 2,
		g = 3,
		h = 4,
		i = 5
	}

	protected enum d
	{
		a = 7,
		b = 0,
		c = b,
		d = 1,
		e = d,
		f = 2,
		g = 3,
		h = 4,
		i = 5,
		j = 6
	}

	protected enum e
	{
		a = 9,
		b = 0,
		c = b,
		d = 1,
		e = d,
		f = 2,
		g = 3,
		h = 4,
		i = 5,
		j = 6,
		k = 7,
		l = 8
	}

	protected enum f : short
	{
		a = 3,
		b = 0,
		c = 1,
		d = 2
	}

	protected enum g : short
	{
		a,
		b,
		c,
		d,
		e
	}

	public enum h : short
	{
		a = 1,
		b
	}

	protected enum i : short
	{
		a = 1,
		b,
		c
	}

	public enum j : short
	{
		a,
		b
	}

	public class k
	{
		public bool a;

		public int b;

		public int c;

		public int d;

		public int e;

		public bool f;

		public int g;

		public int h;

		public int i;

		public bool j;

		public float k;

		public int l;

		public int m;

		public bool n;

		public int o;

		public bool p;

		public int q;
	}

	public class l
	{
		public int a;

		public double[] b;

		public double[] c;

		public long d;

		public long e;

		public string f;

		public string g;
	}

	internal class m
	{
		public short a;

		public short b;

		public h c;

		public short[] d;

		public short e;

		public float f;

		public double g;

		public float h;

		public short[] i;

		public short[] j;

		public double[] k;

		public short[] l;

		public short m;

		public List<float> n;

		public List<float> o;

		public short[] p;

		public m(int A_0, int A_1)
		{
			checked
			{
				int num = A_0 - 1;
				d = new short[num + 1];
				n = new List<float>();
				o = new List<float>();
				p = new short[num + 1];
				i = new short[num + 1];
				j = new short[18 * A_1 + 1];
				k = new double[18 * A_1 + 1];
				l = new short[A_1 - 1 + 1];
			}
		}
	}

	internal enum n : short
	{
		a,
		b,
		c
	}

	protected enum o
	{
		a,
		b
	}

	protected new const int b = 16;

	protected const int e = 1836;

	protected const int s = 4096;

	protected const int t = 7;

	protected const int u = 2;

	public const int v = 1;

	protected const string w = "\\par ";

	protected const int x = 100;

	protected const int y = 200;

	protected const int z = 2048;

	protected const short aa = 5;

	protected double[] ab;

	protected short[] ac;

	protected short[] ad;

	protected short[] ae;

	protected int[] af;

	protected bool ag;

	protected double[,] ah;

	protected jc[] ai;

	protected bool[] aj;

	protected string[] ak;

	protected int[] al;

	protected string[] am;

	protected double[,] an;

	protected bool[] ao;

	protected short[] ap;

	protected double[] aq;

	protected double[] ar;

	protected short[] @as;

	protected short[] at;

	protected double[] au;

	protected bool[] av;

	protected float[] aw;

	protected bool[] ax;

	protected double[] ay;

	protected double[] az;

	protected double[] a0;

	protected double[] a1;

	protected double[] a2;

	protected double[] a3;

	protected double[] a4;

	protected int a5;

	protected double[] a6;

	protected double[] a7;

	protected double[] a8;

	protected double[] a9;

	protected double[] ba;

	protected double[] bb;

	protected double[] bc;

	protected double[] bd;

	protected bool be;

	protected gb bf;

	protected double[,] bg;

	protected double[,] bh;

	protected double[,] bi;

	protected double[,] bj;

	protected double[] bk;

	protected double[] bl;

	protected double[] bm;

	protected double[] bn;

	protected double[] bo;

	protected double[] bp;

	protected double[] bq;

	protected double[] br;

	protected double[] bs;

	protected double[] bt;

	protected double[] bu;

	protected double[] bv;

	protected double[] bw;

	protected double[] bx;

	protected double[] by;

	protected double[] bz;

	protected double[] b0;

	protected double[] b1;

	protected double[] b2;

	protected double[] b3;

	protected double[] b4;

	protected double b5;

	protected double[] b6;

	protected double[] b7;

	protected double[] b8;

	protected double[] b9;

	protected string[] ca;

	protected string[] cb;

	protected double[] cc;

	protected double[] cd;

	protected int ce;

	protected double[] cf;

	protected double[] cg;

	protected int ch;

	protected double ci;

	protected string cj;

	protected string ck;

	protected const double cl = 0.05;

	protected bool cm;

	protected const bool cn = false;

	protected const int co = 5;

	protected bool cp;

	protected bool cq;

	protected bool cr;

	protected bool cs;

	protected f6.e ct;

	protected long cu;

	protected int cv;

	protected float cw;

	protected m cx;

	protected double[] cy;

	protected short[] cz;

	protected long c0;

	protected long c1;

	protected string c2;

	protected string c3;

	protected int c4;

	protected short[] c5;

	protected int c6;

	protected int c7;

	protected int c8;

	protected int c9;

	protected int da;

	protected int db;

	protected int dc;

	protected bool[] dd;

	protected int[] de;

	protected int[] df;

	protected int[] dg;

	protected int[] dh;

	protected int[] di;

	protected int[] dj;

	protected int[] dk;

	protected int[] dl;

	protected int[] dm;

	protected int[] dn;

	protected bool[] @do;

	protected const int dp = 0;

	protected const int dq = 1;

	protected const int dr = 2;

	protected const int ds = 0;

	protected const int dt = 1;

	protected const int du = 2;

	protected const double dv = 1E-06;

	protected const double dw = 1E-06;

	protected const double dx = 1E-12;

	protected const double dy = 1E-06;

	private const float dz = 0.25f;

	private const bool d0 = false;

	private bool d1;

	[SpecialName]
	private double d2;

	[SpecialName]
	private bool d3;

	[SpecialName]
	public double[] m2()
	{
		return aq;
	}

	[SpecialName]
	public double[,] p9()
	{
		return ah;
	}

	public b9(fz A_0)
		: base(A_0)
	{
		ab = new double[1837];
		ac = new short[1837];
		ad = new short[102];
		ae = new short[102];
		af = new int[102];
		ai = new jc[102];
		ap = new short[102];
		aq = new double[101];
		ar = new double[102];
		@as = new short[102];
		at = new short[102];
		au = new double[102];
		av = new bool[102];
		aw = new float[102];
		ax = new bool[102];
		ay = new double[102];
		az = new double[102];
		a4 = new double[102];
		b6 = new double[102];
		b7 = new double[102];
		b8 = new double[102];
		b9 = new double[102];
		ca = new string[102];
		cb = new string[102];
		cu = f6.UniqueMeasEngineID();
		qh(4096);
		cs = global::c.e().FileSystem.FileExists(global::a.p() + "\\WriteGridForScott.txt");
		int num = global::b1.ICCreateCObj(cu);
		if (num != 0)
		{
			A_0.c(fz.b.b, "Error attempting ICCreateCObj. Error code=" + Conversions.ToString(num));
		}
	}

	private float m2(double A_0, double A_1, double A_2, double A_3, int A_4)
	{
		double num = 4.0 * A_0 * A_2;
		double num2 = num * num;
		double num3 = A_1 * A_1;
		double num4;
		if (num2 > num3)
		{
			num4 = 2.0 * num * num3 / (num2 - num3) / A_3;
			if (num4 > (double)A_4)
			{
				num4 = A_4;
			}
		}
		else
		{
			num4 = A_4;
		}
		return (float)(num4 / 2.0);
	}

	private static void m2(hi A_0, hr A_1, ref double[] A_2, ref double[] A_3)
	{
		double[] A_4 = null;
		hr hr2 = A_1;
		int A_5 = default(int);
		int A_6 = default(int);
		hr.r(hr2.cz(), hr2.c0(), hr2.c2(), hr2.bl().cz(), hr2.bl().c0(), hr2.bl().c2(), ref A_5, ref A_6);
		int A_7 = default(int);
		hr.r(A_5, A_6, hr2.cz(), hr2.c0(), hr2.bl().cz(), hr2.bl().c0(), hr2.bl().c2(), ref A_2, ref A_4, ref A_7);
		A_3 = hr.r(A_2, A_4, A_7);
		hr2 = null;
	}

	public ErrPublic m2(string A_0, string A_1, hg A_2, hd A_3, hr A_4, hc A_5, bool A_6, g2.a A_7, double[] A_8, b5 A_9)
	{
		ErrPublic errPublic = ErrPublic.None;
		hc hc2 = new hc();
		bool flag = false;
		checked
		{
			try
			{
				double[] A_10 = new double[1];
				double[] A_11 = new double[1];
				hi hi2 = A_2.ed();
				hi hi3 = hi2;
				int num = hi3.e3() - 1;
				int num2 = hi3.e9() - 1;
				bool[] array = null;
				bool[] array2 = null;
				double[] A_12 = null;
				double[] A_13 = null;
				bool a_ = A_4.bl() != null;
				if (num >= 0)
				{
					array = new bool[num + 1];
					int num3 = num;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						array[num4] = hi3.au(num4, A_7, A_4.ao(), a_);
					}
				}
				if (num2 >= 0)
				{
					array2 = new bool[num2 + 1];
					int num5 = num2;
					for (int num4 = 0; num4 <= num5; num4++)
					{
						array2[num4] = hi3.d5(num4, A_7, A_4.ao(), a_);
					}
				}
				float[] array3 = new float[num + 1];
				cc.a[] array4 = new cc.a[num2 + 1];
				float[] array5 = new float[num2 + 1];
				int num6 = num;
				for (int num4 = 0; num4 <= num6; num4++)
				{
					if (!array[num4])
					{
						continue;
					}
					if (hi3.ea(num4) == hi.e.a || A_4.bl() == null)
					{
						array3[num4] = m2(A_4, hi3.d5(num4), hi3.d6(num4));
						continue;
					}
					if (hi3.ea(num4) == hi.e.b)
					{
						array3[num4] = m2(A_4.bl(), hi3.d5(num4), hi3.d6(num4));
						continue;
					}
					if (A_12 == null)
					{
						m2(hi2, A_4, ref A_12, ref A_13);
					}
					array3[num4] = m2(A_12, A_13, hi3.d5(num4), hi3.d6(num4));
				}
				eo.a a10 = null;
				if (hi3.ff())
				{
					if (hi3.fg())
					{
						A_10 = new double[A_4.c2() - 1 + 1];
						double[] array6 = new double[A_4.c2() - 1 + 1];
						int num7 = A_4.c2() - 1;
						for (int num8 = 0; num8 <= num7; num8++)
						{
							array6[num8] = ah[1, num8];
						}
						int A_14 = default(int);
						int A_15 = default(int);
						int num9 = f6.CalculateHCMeasureFirstLastWavelen(ref A_4.cz()[0], ref A_4.c0()[0], A_4.c2(), ref array6[0], ref A_10[0], ref A_14, ref A_15);
						if (num9 == 0)
						{
							int a_2 = A_14;
							int a_3 = A_15;
							bool A_16 = false;
							string A_17 = string.Empty;
							ErrPublic errPublic2 = m2(A_1, A_2, A_3, a_2, a_3, A_4, hc2, ref A_11, ref A_16, A_9: false, A_10: true, A_8, ref A_17, eo.at());
							if (errPublic2 == ErrPublic.None)
							{
								double[] array7 = new double[A_4.c0().GetUpperBound(0) + 1];
								num9 = f6.CorrectSpectrumForHC(hc2.di()[1], ref A_4.cz()[0], ref A_4.c0()[0], A_4.c2(), ref array6[0], ref array7[0]);
								float num10 = hc2.di()[1] * 0.4f;
								double a_4 = (float)(A_4.cz()[1] - A_4.cz()[0]);
								int num11 = A_4.c2();
								int num12 = num11 - 1;
								int num13 = 0;
								double[] array8 = A_4.cz();
								double[] a_5 = array7;
								bool flag2 = default(bool);
								float num14;
								do
								{
									num14 = m2(num10, array8[num13], array6[num13], a_4, (int)Math.Round(Math.Floor((double)num12 / 2.0)));
									if (num14 > (float)num13)
									{
										num13 = (int)Math.Round(Math.Floor(num14)) + 1;
									}
									else
									{
										flag2 = true;
									}
								}
								while (!flag2);
								jf.b(array8, a_5, num11, (int)Math.Round(Math.Floor(num14)), ref A_10);
								num14 = m2(num10, array8[num13], array6[num13], a_4, (int)Math.Round(Math.Floor((double)num12 / 2.0)));
								while ((float)num13 + num14 <= (float)num12)
								{
									jf.a(array8, a_5, num13, num14, A_10);
									num13++;
									float num15 = m2(num10, array8[num13], array6[num13], a_4, (int)Math.Round(Math.Floor((double)num12 / 2.0)));
									if ((float)num13 + num15 <= (float)num12)
									{
										num14 = num15;
									}
								}
								jf.a(array8, a_5, num11, (int)Math.Round(Math.Floor(num14)), A_10);
								if (num9 != 0)
								{
									ab8().c(fz.b.b, "Error attempting to correct for HC. CorrectSpectrumForHC return code=" + num9);
									flag = true;
								}
							}
							else
							{
								ab8().c(fz.b.b, "Error attempting to correct for HC. MeasureLayers return code=" + errPublic2);
								flag = true;
							}
						}
						else
						{
							ab8().c(fz.b.b, "Error attempting to correct for HC. CalculateHCMeasureFirstLastWavelen return code=" + num9);
							flag = true;
						}
					}
					double[] A_18 = new double[1];
					double[] A_19 = new double[1];
					int A_21 = default(int);
					if (hi3.au(a10))
					{
						string a_6 = A_2.ed().ew();
						double[] A_20 = null;
						jb.a(a_6, ref A_18, ref A_19, ref A_20, ref A_21);
					}
					int num16 = num2;
					for (int num4 = 0; num4 <= num16; num4++)
					{
						if (!array2[num4])
						{
							continue;
						}
						if (hi3.au(num4, A_7) && !flag)
						{
							hr hr2 = A_4.cw();
							hr2.af(A_10);
							array4[num4] = m2(hr2, A_2, (float)hi3.ec(num4), (float)hi3.ed(num4), hi3.el(num4), hi3.eg(num4));
						}
						else if (hi3.ej(num4) == hi.e.a || A_4.bl() == null)
						{
							array4[num4] = m2(A_4, A_2, (float)hi3.ec(num4), (float)hi3.ed(num4), hi3.el(num4), hi3.eg(num4));
						}
						else if (hi3.ej(num4) == hi.e.b)
						{
							array4[num4] = m2(A_4.bl(), A_2, (float)hi3.ec(num4), (float)hi3.ed(num4), hi3.el(num4), hi3.eg(num4));
						}
						else
						{
							if (A_12 == null)
							{
								m2(hi2, A_4, ref A_12, ref A_13);
							}
							array4[num4] = m2(A_12, A_13, A_2, (float)hi3.ec(num4), (float)hi3.ed(num4), hi3.el(num4), hi3.eg(num4));
						}
						if (hi2.au(a10))
						{
							array5[num4] = m2(A_18, A_19, A_21, array4[num4]);
						}
					}
				}
				cc.g[] array9 = null;
				if (errPublic == ErrPublic.None && (hi3.ex() || hi3.ey() || hi3.ez()))
				{
					b6 b10 = A_9.m();
					array9 = new cc.g[3];
					if (b10 != null)
					{
						hr hr3 = A_4;
						if (hi2.ex() && global::b6.c(hr3.cz()[0], hr3.cz()[hr3.c2() - 1], hi.c.a))
						{
							cc.g g10 = new cc.g();
							g10.d(b10, hi.c.a);
							cc.g g11 = g10;
							double[] a_7 = b10.c();
							double[] a_8 = b10.d();
							double a_9 = g11.e();
							double a_10 = g11.f();
							cc.g g12;
							double A_22 = (g12 = g11).d();
							m2(A_4, a_7, a_8, a_9, a_10, ref A_22);
							g12.d(A_22);
							g11 = null;
							array9[0] = g10;
						}
						if (hi2.ey() && global::b6.c(hr3.cz()[0], hr3.cz()[hr3.c2() - 1], hi.c.b))
						{
							cc.g g10 = new cc.g();
							g10.d(b10, hi.c.b);
							cc.g g13 = g10;
							double[] a_11 = b10.c();
							double[] a_12 = b10.d();
							double a_13 = g13.e();
							double a_14 = g13.f();
							cc.g g12;
							double A_22 = (g12 = g13).d();
							m2(A_4, a_11, a_12, a_13, a_14, ref A_22);
							g12.d(A_22);
							g13 = null;
							array9[1] = g10;
						}
						if (hi2.ez() && global::b6.c(hr3.cz()[0], hr3.cz()[hr3.c2() - 1], hi.c.c))
						{
							cc.g g10 = new cc.g();
							g10.d(b10, hi.c.c);
							cc.g g14 = g10;
							double[] a_15 = b10.c();
							double[] a_16 = b10.d();
							double a_17 = g14.e();
							double a_18 = g14.f();
							cc.g g12;
							double A_22 = (g12 = g14).d();
							m2(A_4, a_15, a_16, a_17, a_18, ref A_22);
							g12.d(A_22);
							g14 = null;
							array9[2] = g10;
						}
						hr3 = null;
					}
					else
					{
						errPublic = ErrPublic.InvalidSolarData;
					}
				}
				ix.c a_19 = null;
				if (errPublic == ErrPublic.None && hi3.e0())
				{
					b7 b11 = A_9.n();
					if (b11 != null)
					{
						hr hr4 = A_4;
						if (global::b7.c(hr4.cz()[0], hr4.cz()[hr4.c2() - 1]))
						{
							double A_23 = default(double);
							m2(A_4, b11.c(), b11.d(), b11.c()[0], b11.c()[b11.c().Length - 1], ref A_23);
							a_19 = new ix.c((float)A_23);
						}
						hr4 = null;
					}
					else
					{
						errPublic = ErrPublic.InvalidIlluminanceData;
					}
				}
				ix.c A_24 = null;
				bool A_25 = default(bool);
				if (errPublic == ErrPublic.None && hi3.e1())
				{
					m2(A_4, A_9, ref A_24, ref A_25);
				}
				A_5.cf(A_4, A_0, A_2, A_1, array3, array4, null, A_6, A_7 == g2.a.c || A_7 == g2.a.b, array5, array9, a_19, A_25, A_24, a10);
				hi3 = null;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_20 = ex2;
				errPublic = ErrPublic.Generic;
				ab8().c(fz.b.b, "Exception caught in MeasureSpecRegions(). ", a_20);
				ProjectData.ClearProjectError();
			}
			return errPublic;
		}
	}

	protected static float m2(hr A_0, double A_1, double A_2)
	{
		return m2(A_0.cz(), A_0.c0(), A_1, A_2);
	}

	protected static float m2(double[] A_0, double[] A_1, double A_2, double A_3)
	{
		int num = -1;
		int num2 = -1;
		if (!jf.a((float)A_3, (float)A_2))
		{
			throw new ax("MeasEngine.CalculateMeanSpectrumValue lastWavelength must be >= firstWavelength");
		}
		checked
		{
			int num3 = A_0.Length - 1;
			if (jf.b((float)A_2, (float)A_0[num3]))
			{
				return (float)A_1[num3];
			}
			if (jf.d((float)A_3, (float)A_0[0]))
			{
				return (float)A_1[0];
			}
			bool flag = default(bool);
			if (jf.c((float)A_2, (float)A_0[0]))
			{
				num = 0;
				flag = true;
			}
			bool flag2 = default(bool);
			if (jf.a((float)A_3, (float)A_0[num3]))
			{
				num2 = num3;
				flag2 = true;
			}
			if (!flag || !flag2)
			{
				int num4 = num3;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					if (num == -1 && jf.a((float)A_0[num5], (float)A_2))
					{
						flag = jf.e((float)A_0[num5], (float)A_2);
						num = ((!flag) ? (num5 - 1) : num5);
					}
					if (num2 == -1 && jf.a((float)A_0[num5], (float)A_3))
					{
						flag2 = jf.e((float)A_0[num5], (float)A_3);
						num2 = num5;
						break;
					}
				}
			}
			float num6 = ((!flag) ? ((float)((A_1[num] * (A_0[num + 1] - A_2) + A_1[num + 1] * (A_2 - A_0[num])) / (A_0[num + 1] - A_0[num]))) : ((float)A_1[num]));
			float num7 = ((!flag2) ? ((float)((A_1[num2 - 1] * (A_0[num2] - A_3) + A_1[num2] * (A_3 - A_0[num2 - 1])) / (A_0[num2] - A_0[num2 - 1]))) : ((float)A_1[num2]));
			if (flag && flag2 && num == num2)
			{
				return (float)A_1[num];
			}
			if (num2 - num == 1)
			{
				return (float)(0.5 * (double)(num6 + num7));
			}
			double num8 = 0.0;
			num8 = ((double)num6 + A_1[num + 1]) * (A_0[num + 1] - A_2) + ((double)num7 + A_1[num2 - 1]) * (A_3 - A_0[num2 - 1]);
			int num9 = num + 1;
			int num10 = num2 - 2;
			for (int num5 = num9; num5 <= num10; num5++)
			{
				num8 += (A_1[num5] + A_1[num5 + 1]) * (A_0[num5 + 1] - A_0[num5]);
			}
			return (float)(num8 / (2.0 * (A_3 - A_2)));
		}
	}

	protected static cc.a m2(hr A_0, hg A_1, float A_2, float A_3, bool A_4, hi.b A_5)
	{
		return m2(A_0.cz(), A_0.c0(), A_1, A_2, A_3, A_4, A_5);
	}

	protected static cc.a m2(double[] A_0, double[] A_1, hg A_2, float A_3, float A_4, bool A_5, hi.b A_6)
	{
		cc.a result = default(cc.a);
		short a_ = 0;
		if (A_6 == hi.b.b)
		{
			a_ = 1;
		}
		double A_7 = default(double);
		double A_8 = default(double);
		if (f6.CalculateExtrema2(ref A_0[0], ref A_1[0], A_0.Length, A_3, A_4, a_, ref A_7, ref A_8, (short)(0 - (A_5 ? 1 : 0))) == 0)
		{
			result.a = (float)A_7;
			result.b = (float)A_8;
		}
		return result;
	}

	protected float m2(double[] A_0, double[] A_1, int A_2, cc.a A_3)
	{
		double[] A_4 = new double[1];
		double[] A_5 = new double[1];
		A_4[0] = A_3.a;
		jf.a(ref A_0, ref A_1, A_2, ref A_4, ref A_5, 1);
		return (float)Math.Sqrt(A_5[0] * (1.0 + Math.Sqrt(A_3.b)) / (1.0 - Math.Sqrt(A_3.b)));
	}

	protected void m2(int A_0)
	{
		checked
		{
			int num = A_0 - 1;
			if (aq == null || num > aq.GetUpperBound(0))
			{
				aq = new double[num + 1];
				ar = new double[num + 1];
				a4 = new double[num + 1];
				at = new short[num + 1];
				@as = new short[num + 1];
				au = new double[num + 1];
				av = new bool[A_0 + 1];
				aw = new float[num + 1];
				ax = new bool[A_0 + 1];
				ay = new double[num + 1];
				az = new double[num + 1];
				cb = new string[num + 1];
			}
		}
	}

	protected void p9(int A_0)
	{
		checked
		{
			int num = A_0 - 1;
			if (de == null || num > de.GetUpperBound(0))
			{
				de = new int[num + 1];
				df = new int[num + 1];
				dg = new int[num + 1];
				dh = new int[num + 1];
				di = new int[num + 1];
				dd = new bool[num + 1];
			}
		}
	}

	public ErrPublic m2(hg A_0, hd A_1, hr A_2, ref string A_3, bool A_4, eo.a A_5)
	{
		Collection<hg> collection = new Collection<hg>();
		Collection<hr> collection2 = new Collection<hr>();
		collection.Add(A_0);
		collection2.Add(A_2);
		return m2(collection, A_1, collection2, ref A_3, A_4, A_5);
	}

	public ErrPublic m2(Collection<hg> A_0, hd A_1, Collection<hr> A_2, ref string A_3, bool A_4, eo.a A_5)
	{
		ErrPublic result = ErrPublic.None;
		string text = string.Empty;
		string A_6 = null;
		checked
		{
			try
			{
				c4 = A_2.Count;
				int num = c4 - 1;
				p9(c4);
				c7 = 0;
				c9 = 0;
				da = 0;
				c8 = 0;
				int A_7 = 0;
				c6 = 0;
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					hi hi2 = A_0[num3].b3(A_0[num3].c2());
					dd[num3] = A_2[num3].bl() != null && hi2.au(0, A_2[num3]);
					de[num3] = c7;
					df[num3] = c8;
					c7 += hi2.g7() + 2;
					c8 += A_2[num3].c2();
					if (dd[num3])
					{
						c6++;
						dg[num3] = da;
						da += A_2[num3].bl().c2();
						c9 += 2 * A_2[num3].c2();
					}
					else
					{
						c9 += A_2[num3].c2();
					}
				}
				if (ah.GetUpperBound(0) < c7 - 1)
				{
					ah = new double[c7 - 1 + 1, ah.GetUpperBound(1) + 1];
				}
				if (an.GetUpperBound(0) < c7 - 1)
				{
					an = new double[c7 - 1 + 1, an.GetUpperBound(1) + 1];
				}
				m2(c7);
				bool a_ = A_0[0].dh().az(A_5);
				bool a_2 = A_0[0].dh().ax(A_5);
				int num4 = num;
				double A_10 = default(double);
				double A_11 = default(double);
				double A_12 = default(double);
				double A_13 = default(double);
				bool A_20 = default(bool);
				bool A_21 = default(bool);
				for (int num5 = 0; num5 <= num4; num5++)
				{
					double[] A_8 = A_2[num5].cz();
					int A_9 = A_2[num5].c2();
					hi hi2 = A_0[num5].b3(A_0[num5].c2());
					int num6 = de[num5];
					A_7++;
					int num7 = hi2.g7() + 1;
					for (int num8 = 1; num8 <= num7; num8++)
					{
						cb[num6 + num8] = "";
					}
					ag = hi2.hd();
					if (ag && hi2.fi())
					{
						hg.bu(i3.o() + "\\globalCorr.dat", ref A_10, ref A_11, ref A_12, ref A_13);
						bf = new gb(A_12, A_13, A_10, A_11);
					}
					gc gc2 = hi2.eu(0);
					if (gc2 == null)
					{
						A_3 = hi2.hs();
					}
					at[num6] = 0;
					@as[num6] = 0;
					au[num6] = 0.0;
					av[num6] = false;
					aw[num6] = 0f;
					ax[num6] = false;
					string a_3 = gc2.ag();
					ref double[,] a_4 = ref ah;
					ref double[,] a_5 = ref an;
					int a_6 = num6;
					ref short[] a_7 = ref ap;
					ref short[] a_8 = ref ad;
					ref short[] a_9 = ref ae;
					ref int[] a_10 = ref af;
					short[] a_11 = ac;
					double[] a_12 = ab;
					eo a_13 = A_0[num5].dh();
					ref bool a_14 = ref aj[num6];
					ref bool a_15 = ref ao[num6];
					bool A_14 = false;
					string A_15 = null;
					string A_16 = null;
					ref int a_16 = ref al[num6];
					ref string a_17 = ref ak[num6];
					int A_17 = 0;
					jb.d[] A_18 = null;
					string[] A_19 = null;
					if (jb.a(a_3, A_1: false, ref a_4, ref a_5, a_6, A_5: true, A_6: true, ref A_8, ref A_9, ref A_20, ref a_7, A_1, ref a_8, ref a_9, ref a_10, ref A_7, A_16: true, a_11, a_12, a_13, ref A_3, ref A_21, ref a_14, ref a_15, ref A_14, ref A_15, ref A_16, ref a_16, ref a_17, ref A_17, ref A_18, ref A_19, ref A_6, ref ai[num6], A_5) != jb.a.a)
					{
						return ErrPublic.Generic;
					}
					am[num6] = Path.GetFileName(A_6);
					ErrPublic errPublic = ErrPublic.None;
					A_17 = hi2.g7();
					int A_22;
					for (int num8 = 1; num8 <= A_17; num8++)
					{
						num6 = de[num5] + num8;
						gc2 = hi2.eu(num8);
						if (Operators.CompareString(gc2.ag(), "<Graded Interface>", TextCompare: false) != 0)
						{
							at[num6] = 0;
							gc gc3 = gc2;
							@as[num6] = (short)unchecked(-(short)(0 - ((gc3.ak() != 0.0 || gc3.an(a_2)) ? 1 : 0)));
							au[num6] = gc3.aj() * gc3.ai() * 1E-09;
							av[num6] = gc3.ap(a_);
							if (gc3.ap(a_) && au[num6] < 1E-08)
							{
								au[num6] = 1E-08;
							}
							aw[num6] = (float)gc3.ak();
							ax[num6] = gc3.an(a_2);
							if (gc3.an(a_2) && (double)Math.Abs(aw[num6]) < 1E-06)
							{
								aw[num6] = (float)((double)Math.Sign(aw[num6]) * 1E-06);
							}
							gc3 = null;
							aq[num6] = gc2.ai();
							if (ag)
							{
								gb gb2;
								if (hi2.fi())
								{
									gb2 = bf;
								}
								else
								{
									gb2 = gc2.x;
									if (gb2 == null)
									{
										gb2 = hi2.br;
									}
								}
								aq[num6] = (gc2.ai() - gb2.b) / gb2.a;
							}
							ar[num6] = gc2.an();
							string a_18 = gc2.ag();
							bool a_19 = gc2.v;
							ref double[,] a_20 = ref ah;
							ref double[,] a_21 = ref an;
							int a_22 = num6;
							ref short[] a_23 = ref ap;
							ref short[] a_24 = ref ad;
							ref short[] a_25 = ref ae;
							ref int[] a_26 = ref af;
							short[] a_27 = ac;
							double[] a_28 = ab;
							eo a_29 = A_0[num5].dh();
							ref bool a_30 = ref aj[num6];
							ref bool a_31 = ref ao[num6];
							A_14 = false;
							A_16 = null;
							A_15 = null;
							ref int a_32 = ref al[num6];
							ref string a_33 = ref ak[num6];
							A_22 = 0;
							A_18 = null;
							A_19 = null;
							if (jb.a(a_18, a_19, ref a_20, ref a_21, a_22, A_5: true, A_6: true, ref A_8, ref A_9, ref A_20, ref a_23, A_1, ref a_24, ref a_25, ref a_26, ref A_7, A_16: true, a_27, a_28, a_29, ref A_3, ref A_21, ref a_30, ref a_31, ref A_14, ref A_16, ref A_15, ref a_32, ref a_33, ref A_22, ref A_18, ref A_19, ref A_6, ref ai[num6], A_5) != jb.a.a)
							{
								if (!string.IsNullOrEmpty(A_3))
								{
									text = text + A_3 + "\r\n";
								}
								errPublic = ErrPublic.Generic;
							}
							am[num6] = Path.GetFileName(A_6);
							if (A_20)
							{
								cb[num6] = gc2.ag() + " = ";
							}
							else
							{
								cb[num6] = "Layer " + Strings.Trim(Conversion.Str(num8)) + " = ";
							}
							if (A_21)
							{
								continue;
							}
							string a_34 = gc2.ag();
							ref double[,] a_35 = ref an;
							double[,] A_23 = null;
							int a_36 = num6;
							ref short[] a_37 = ref ap;
							ref short[] a_38 = ref ad;
							ref short[] a_39 = ref ae;
							ref int[] a_40 = ref af;
							short[] a_41 = ac;
							double[] a_42 = ab;
							eo a_43 = A_0[num5].dh();
							ref bool a_44 = ref ao[num6];
							A_14 = false;
							jc A_24 = null;
							if (jb.a(a_34, A_1: false, ref a_35, ref A_23, a_36, A_5: false, A_6: false, ref A_8, ref A_9, ref A_20, ref a_37, A_1, ref a_38, ref a_39, ref a_40, ref A_7, A_16: true, a_41, a_42, a_43, ref A_3, ref A_21, ref a_44, ref A_14, ref A_24, A_5) != jb.a.a)
							{
								if (!string.IsNullOrEmpty(A_3))
								{
									text = text + A_3 + "\r\n";
								}
								errPublic = ErrPublic.Generic;
							}
						}
						else
						{
							at[num6] = 1;
							cb[num6] = "Layer " + Strings.Trim(Conversion.Str(num8)) + " (Graded) = ";
						}
					}
					if (errPublic != ErrPublic.None)
					{
						A_3 = text;
						return errPublic;
					}
					num6 = de[num5] + hi2.g7() + 1;
					gc2 = hi2.eu(hi2.g7() + 1);
					at[num6] = 0;
					@as[num6] = 0;
					ar[num6] = gc2.an();
					au[num6] = 0.0;
					av[num6] = false;
					aw[num6] = 0f;
					ax[num6] = false;
					string a_45 = gc2.ag();
					bool a_46 = gc2.v;
					ref double[,] a_47 = ref ah;
					ref double[,] a_48 = ref an;
					int a_49 = num6;
					ref short[] a_50 = ref ap;
					ref short[] a_51 = ref ad;
					ref short[] a_52 = ref ae;
					ref int[] a_53 = ref af;
					short[] a_54 = ac;
					double[] a_55 = ab;
					eo a_56 = A_0[num5].dh();
					ref bool a_57 = ref aj[num6];
					ref bool a_58 = ref ao[num6];
					A_14 = false;
					A_15 = null;
					A_16 = null;
					ref int a_59 = ref al[num6];
					ref string a_60 = ref ak[num6];
					A_22 = 0;
					A_18 = null;
					A_19 = null;
					if (jb.a(a_45, a_46, ref a_47, ref a_48, a_49, A_5: true, A_6: true, ref A_8, ref A_9, ref A_20, ref a_50, A_1, ref a_51, ref a_52, ref a_53, ref A_7, A_16: true, a_54, a_55, a_56, ref A_3, ref A_21, ref a_57, ref a_58, ref A_14, ref A_15, ref A_16, ref a_59, ref a_60, ref A_22, ref A_18, ref A_19, ref A_6, ref ai[num6], A_5) != jb.a.a)
					{
						return ErrPublic.Generic;
					}
					am[num6] = A_6;
					if (!A_21)
					{
						string a_61 = gc2.ag();
						ref double[,] a_62 = ref an;
						double[,] A_23 = null;
						int a_63 = num6;
						ref short[] a_64 = ref ap;
						ref short[] a_65 = ref ad;
						ref short[] a_66 = ref ae;
						ref int[] a_67 = ref af;
						short[] a_68 = ac;
						double[] a_69 = ab;
						eo a_70 = A_0[num5].dh();
						ref bool a_71 = ref ao[num6];
						A_14 = false;
						jc A_24 = null;
						if (jb.a(a_61, A_1: false, ref a_62, ref A_23, a_63, A_5: false, A_6: false, ref A_8, ref A_9, ref A_20, ref a_64, A_1, ref a_65, ref a_66, ref a_67, ref A_7, A_16: true, a_68, a_69, a_70, ref A_3, ref A_21, ref a_71, ref A_14, ref A_24, A_5) != jb.a.a)
						{
							return ErrPublic.Generic;
						}
					}
					int num9 = de[num5] + 1;
					int num10 = de[num5] + hi2.g7();
					A_22 = num10;
					for (int num8 = num9; num8 <= A_22; num8++)
					{
						if (at[num8] == 1)
						{
							int num11 = A_9 - 1;
							for (int num12 = 0; num12 <= num11; num12++)
							{
								ah[num8, num12] = (ah[num8 - 1, num12] + ah[num8 + 1, num12]) / 2.0;
								an[num8, num12] = (an[num8 - 1, num12] + an[num8 + 1, num12]) / 2.0;
							}
						}
					}
					if (A_4)
					{
						double a_72 = ((A_9 <= 1) ? 1.999999943436137E-09 : ((A_8[1] - A_8[0]) * 1E-09));
						m2(a_72, A_9, num5);
					}
				}
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
	}

	public void m2(double A_0, int A_1, int A_2)
	{
		checked
		{
			if (A_2 == 0)
			{
				a6 = new double[c8 - 1 + 1];
			}
			int num = df[A_2];
			int num2 = df[A_2] + A_1 - 1;
			int num3 = num2;
			for (int num4 = num; num4 <= num3; num4++)
			{
				a6[num4] = A_0;
			}
		}
	}

	public static hr m2(hr A_0, hg A_1)
	{
		hi hi2 = A_1.b3(A_1.c2());
		if (A_0.bl() != null && hi2.d5(0, A_0) && !hi2.d6(0, A_0))
		{
			return A_0.bl();
		}
		if (A_0.bm() != null && A_0.bm().Count > 0 && hi2.d6(1, A_0) && !hi2.d5(0, A_0) && !hi2.d6(0, A_0))
		{
			return A_0.bm()[0];
		}
		return A_0;
	}

	public ErrPublic m2(string A_0, hg A_1, hd A_2, int A_3, int A_4, hr A_5, hc A_6, ref double[] A_7, ref bool A_8, bool A_9, bool A_10, double[] A_11, ref string A_12, eo.a A_13)
	{
		return m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6, ref A_7, ref A_8, A_9, A_10, 5, A_11, ref A_12, A_13);
	}

	public ErrPublic m2(string A_0, hg A_1, hd A_2, int A_3, int A_4, hr A_5, hc A_6, ref double[] A_7, ref bool A_8, bool A_9, bool A_10, short A_11, double[] A_12, ref string A_13, eo.a A_14)
	{
		Collection<hr> collection = new Collection<hr>();
		int[] a_ = new int[1] { A_3 };
		int[] a_2 = new int[1] { A_4 };
		Collection<double[]> collection2 = new Collection<double[]>();
		Collection<hc> collection3 = new Collection<hc>();
		collection.Add(A_5);
		collection2.Add(A_12);
		collection3.Add(A_6);
		return m2(A_0, A_1, A_2, a_, a_2, collection, collection3, ref A_7, ref A_8, A_9, A_10, A_11, collection2, null, null, ref A_13, A_14);
	}

	protected ErrPublic m2(f6.e A_0)
	{
		switch (A_0)
		{
		case f6.e.a:
			return ErrPublic.SolvingAborted;
		case f6.e.g:
		case f6.e.h:
		case f6.e.m:
			return ErrPublic.InvalidKConstraints;
		case f6.e.e:
		case f6.e.f:
		case f6.e.l:
			return ErrPublic.InvalidNConstraints;
		case f6.e.i:
		case f6.e.j:
		case f6.e.k:
			return ErrPublic.InvalidDConstraints;
		case f6.e.x:
			return ErrPublic.InitNKCoeffsInvalid;
		case f6.e.y:
			return ErrPublic.InsufficientData;
		case f6.e.ah:
			return ErrPublic.ModelCoeffIncompatWithInitialN;
		case f6.e.ai:
			return ErrPublic.ModelCoeffIncompatWithInitialK;
		case f6.e.al:
			return ErrPublic.ZAREModelUsedInMultipleLayersWithinSingleStack;
		case f6.e.am:
			return ErrPublic.ZAREAttemptToSolveForKWithoutTrans;
		case f6.e.an:
			return ErrPublic.ZAREAttemptToSolveForXKWithoutReflTrans;
		case f6.e.ao:
			return ErrPublic.ZAREAttemptToSolveForNWithoutRAngle;
		case f6.e.ap:
			return ErrPublic.ZAREAttemptToSolveForDNWithoutRAngle;
		case f6.e.aq:
			return ErrPublic.ZAREAttemptToSolveForDNWithoutR0OrT;
		case f6.e.ar:
			return ErrPublic.ZAREAttemptToSolveForDNKWithoutDoubleRefl;
		case f6.e.@as:
			return ErrPublic.ZAREInsufficientWavelengthOverlapBetweenSpectrumTypes;
		case f6.e.at:
			return ErrPublic.ZAREMismatchedSolveForDInSameLayers;
		case f6.e.au:
			return ErrPublic.ZAREIndependentDForSameNorK;
		case f6.e.av:
			return ErrPublic.ZAREDesignError;
		default:
			if (A_0 == (f6.e)0)
			{
				return ErrPublic.None;
			}
			p9(A_0);
			return ErrPublic.Solver;
		}
	}

	protected double m2(double A_0, double A_1)
	{
		return 0.5 * A_0 * (A_0 - A_1) / A_1;
	}

	protected double p9(double A_0, double A_1)
	{
		return m2(A_0, 0.25 * A_1);
	}

	protected double qh(double A_0, double A_1)
	{
		return m2(A_0, 4.0 * A_1);
	}

	protected void m2(short[] A_0, ref short[] A_1, ref double[] A_2)
	{
		checked
		{
			int num = c7 - 1;
			A_1 = new short[c7 * 6 - 1 + 1];
			A_2 = new double[c7 * 6 - 1 + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				int num4 = 0;
				do
				{
					A_1[6 * num3 + num4] = A_0[num3];
					A_2[6 * num3 + num4] = 1.0;
					num4++;
				}
				while (num4 <= 5);
			}
		}
	}

	protected void m2(short[] A_0, he A_1, short[] A_2, ref short[] A_3, ref double[] A_4, ref short[] A_5, ref short[] A_6)
	{
		checked
		{
			int num = c7 - 1;
			int num2 = c4 - 1;
			A_5 = new short[num2 + 1];
			A_6 = new short[num2 + 1];
			m2(A_0, ref A_3, ref A_4);
			if (A_1 == null)
			{
				return;
			}
			he he2 = A_1;
			int num3 = he2.ac() - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				if (Operators.CompareString(he2.u(num4), "All", TextCompare: false) == 0 && Operators.CompareString(he2.w(num4), "All", TextCompare: false) == 0)
				{
					if (he2.t(num4) < he2.v(num4))
					{
						A_5[he2.v(num4)] = 1;
						A_6[he2.v(num4)] = (short)he2.t(num4);
					}
					else
					{
						A_5[he2.t(num4)] = 1;
						A_6[he2.t(num4)] = (short)he2.v(num4);
					}
					continue;
				}
				int num5 = de[he2.t(num4)] + Convert.ToInt32(he2.u(num4));
				int num6 = de[he2.v(num4)] + Convert.ToInt32(he2.w(num4));
				int num7 = 6 * num5;
				int num8 = 6 * num6;
				if (num5 < num6)
				{
					if (he2.x(num4) == he.a.g)
					{
						int num9 = 0;
						do
						{
							int num10 = num7 + num9;
							int num11 = num8 + num9;
							if (A_2[num10] != 0 && A_2[num11] != 0)
							{
								A_3[num8 + num9] = (short)num5;
								A_4[num8 + num9] = he2.y(num4);
							}
							num9++;
						}
						while (num9 <= 5);
					}
					else
					{
						unchecked
						{
							A_3[(int)checked(num8 + he2.x(num4) - 1)] = checked((short)num5);
							A_4[(int)checked(num8 + he2.x(num4) - 1)] = he2.y(num4);
						}
					}
				}
				else if (he2.x(num4) == he.a.g)
				{
					int num12 = 0;
					do
					{
						int num10 = num7 + num12;
						int num11 = num8 + num12;
						if (A_2[num10] != 0 && A_2[num11] != 0)
						{
							A_3[num7 + num12] = (short)num6;
							A_4[num7 + num12] = he2.y(num4);
						}
						num12++;
					}
					while (num12 <= 5);
				}
				else
				{
					unchecked
					{
						A_3[(int)checked(num7 + he2.x(num4) - 1)] = checked((short)num6);
						A_4[(int)checked(num7 + he2.x(num4) - 1)] = he2.y(num4);
					}
				}
			}
			for (int num13 = num2; num13 >= 1; num13 += -1)
			{
				if (A_5[num13] != 0)
				{
					short num14 = A_6[num13];
					while (A_5[num14] != 0)
					{
						num14 = A_6[num14];
						A_6[num13] = num14;
					}
				}
			}
			double num17 = default(double);
			int num18 = default(int);
			for (int num15 = num; num15 >= 1; num15 += -1)
			{
				int num16 = 0;
				do
				{
					bool flag = false;
					int num10 = 6 * num15 + num16;
					if (A_3[num10] != 0)
					{
						num17 = A_4[num10];
						num18 = 6 * A_3[num10] + num16;
						while (A_3[num18] != 0)
						{
							flag = true;
							num17 *= A_4[num18];
							num18 = 6 * A_3[num18] + num16;
						}
					}
					if (flag)
					{
						A_3[num10] = (short)unchecked(num18 / 6);
						A_4[num10] = num17;
					}
					num16++;
				}
				while (num16 <= 5);
			}
			he2 = null;
		}
	}

	protected void m2(int A_0, short[] A_1, double[] A_2, short[] A_3, short[] A_4, double[] A_5, double[] A_6, bool[] A_7, bool[] A_8, ref short[] A_9, ref double[] A_10)
	{
		checked
		{
			A_9 = new short[c7 * 6 - 1 + 1];
			A_10 = new double[c7 * 9 - 1 + 1];
			int num = 0;
			int num2 = A_0 - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				short num4 = A_1[num3];
				short num5 = (short)unchecked(A_3[num3] - 1);
				int num6 = dj[num3];
				int num7 = dh[num3];
				int num8 = num5;
				for (int num9 = 0; num9 <= num8; num9++)
				{
					A_9[num * 6 + 0] = A_4[num * 4 + 0];
					A_9[num * 6 + 1] = A_4[num * 4 + 1];
					A_9[num * 6 + 2] = A_4[num * 4 + 2];
					A_9[num * 6 + 3] = A_4[num * 4 + 3];
					if (num9 > 0 && num9 < num5)
					{
						if (A_7[num])
						{
							A_9[num * 6 + 4] = 1;
						}
						if (A_8[num])
						{
							A_9[num * 6 + 5] = 1;
						}
					}
					A_10[num * 9 + 0] = A_6[num * 6 + 0];
					A_10[num * 9 + 1] = A_6[num * 6 + 1];
					A_10[num * 9 + 2] = A_6[num * 6 + 2];
					A_10[num * 9 + 3] = A_6[num * 6 + 3];
					A_10[num * 9 + 4] = A_6[num * 6 + 4];
					A_10[num * 9 + 5] = A_6[num * 6 + 5];
					if (num9 > 0)
					{
						A_10[num * 9 + 7] = 6E-07 * A_2[num6 + num4 - 1] / (A_5[num7 + num9 * num4 - 1] * 1E-06);
					}
					else
					{
						A_10[num * 9 + 7] = 0.0;
					}
					if (num9 > 0 && num9 < num5 && A_7[num])
					{
						A_10[num * 9 + 6] = A_2[num6 + num4 - 1] / A_5[num7 + (num9 + 1) * num4 - 1];
					}
					else
					{
						A_10[num * 9 + 6] = 0.0;
					}
					A_10[num * 9 + 8] = 1.0;
					num++;
				}
			}
		}
	}

	protected void m2(int A_0, short A_1, double[] A_2, short[] A_3, int A_4, double[] A_5, double[] A_6)
	{
		short num = 0;
		checked
		{
			int num2 = A_4 - 2;
			short num4 = default(short);
			short num3 = num4;
			for (short num5 = 0; num5 <= num3; num5 = (short)unchecked(num5 + 1))
			{
				if (jf.a(A_2[num5], A_5[A_0]))
				{
					num = num5;
					break;
				}
				A_3[num5] = -1;
			}
			int num6 = num2;
			int num7 = 0;
			while (true)
			{
				if (num7 <= num6)
				{
					double num8 = A_5[num7] - A_2[num];
					double num9 = A_5[num7 + 1] - A_2[num];
					if (jf.c(num8 * num9, 0.0))
					{
						double num10 = A_6[num7] + (A_2[num] - A_5[num7]) * (A_6[num7 + 1] - A_6[num7]) / (A_5[num7 + 1] - A_5[num7]);
						int num11 = ((!jf.a(Math.Abs(num8), Math.Abs(num9))) ? num7 : (num7 + 1));
						A_5[num11] = A_2[num];
						A_6[num11] = num10;
						if (num11 - A_0 >= 0)
						{
							A_3[num] = (short)(num11 - A_0);
						}
						else
						{
							A_3[num] = -1;
						}
						num = (short)unchecked(num + 1);
						if (num >= A_1)
						{
							break;
						}
					}
					num7++;
					continue;
				}
				short num12 = num;
				short num13 = num4;
				for (short num5 = num12; num5 <= num13; num5 = (short)unchecked(num5 + 1))
				{
					A_3[num5] = -1;
				}
				break;
			}
		}
	}

	protected double m2(double A_0)
	{
		double num = A_0;
		for (double num2 = ((!(num > 0.0)) ? 1.0 : (-1.0)); num > Math.PI || num < -Math.PI; num += num2 * 2.0 * Math.PI)
		{
		}
		return num;
	}

	protected void m2(bool A_0, short A_1, short[] A_2, short[] A_3, ref short A_4, ref short[] A_5, ref float[] A_6)
	{
		short num = 0;
		short num2 = 0;
		checked
		{
			short[] array = new short[(short)unchecked(A_4 + A_1) - 1 + 1];
			float[] array2 = new float[(short)unchecked(A_4 + A_1) - 1 + 1];
			short num3 = 0;
			if (!A_0)
			{
				return;
			}
			while (num < A_1)
			{
				if (A_5[num2] == A_3[A_2[num]])
				{
					num = (short)unchecked(num + 1);
				}
				else if (A_5[num2] > A_3[A_2[num]])
				{
					array[num3] = A_3[A_2[num]];
					array2[num3] = 1f;
					num3 = (short)unchecked(num3 + 1);
					num = (short)unchecked(num + 1);
				}
				array[num3] = A_5[num2];
				array2[num3] = A_6[num2];
				num2 = (short)unchecked(num2 + 1);
				num3 = (short)unchecked(num3 + 1);
			}
			short num4 = num2;
			int num5 = A_4 - 1;
			for (int num6 = num4; num6 <= num5; num6++)
			{
				array[num3] = A_5[num6];
				array2[num3] = A_6[num6];
				num3 = (short)unchecked(num3 + 1);
			}
			A_4 = num3;
			A_5 = array;
			A_6 = array2;
		}
	}

	protected void m2(int A_0, double A_1, bool A_2, double[] A_3, double[] A_4, double[] A_5, ref double A_6, ref double A_7)
	{
		int num = A_3.Length;
		checked
		{
			int num2 = num - 1;
			if (A_3[0] > A_1)
			{
				throw new ApplicationException("PeakWL is outside of range of measured wavelengths");
			}
			int num3 = num2;
			for (int num4 = 1; num4 <= num3; num4++)
			{
				if (jf.a(A_3[num4], A_1))
				{
					double num5 = A_3[num4 - 1];
					double num6 = A_3[num4];
					double num7 = A_4[A_0 * num + num4 - 1];
					double num8 = A_4[A_0 * num + num4];
					A_6 = num7 + (A_1 - num5) * (num8 - num7) / (num6 - num5);
					if (A_2)
					{
						A_7 = 0.0;
						return;
					}
					double num9 = A_5[A_0 * num + num4 - 1];
					double num10 = A_5[A_0 * num + num4];
					A_7 = num9 + (A_1 - num5) * (num10 - num9) / (num6 - num5);
					return;
				}
			}
			throw new ApplicationException("PeakWL is outside of range of measured wavelengths");
		}
	}

	public static short m2(h A_0, bool A_1, double A_2, double A_3, double[] A_4, j A_5, double[] A_6, double[] A_7, double[] A_8, bool A_9, double[] A_10, cf A_11, short A_12, double[] A_13, double[] A_14, short A_15, float A_16, float A_17, long A_18, short A_19, ref double[] A_20, ref double A_21, ref double A_22, ref double[] A_23, ref double[] A_24, ref double[] A_25, ref double[] A_26)
	{
		double[] a_ = new double[1];
		m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10, A_11, A_12, A_13, A_14, A_15, A_16, A_17, A_18, A_19, A_20: false, null, a_, ref A_20, ref A_21, ref A_22, ref A_23, ref A_24, ref A_25, ref A_26);
		return 0;
	}

	public static short m2(h A_0, bool A_1, double A_2, double A_3, double[] A_4, j A_5, double[] A_6, double[] A_7, double[] A_8, bool A_9, double[] A_10, cf A_11, short A_12, double[] A_13, double[] A_14, short A_15, float A_16, float A_17, long A_18, short A_19, bool A_20, double[] A_21, double[] A_22, ref double[] A_23, ref double A_24, ref double A_25, ref double[] A_26, ref double[] A_27, ref double[] A_28, ref double[] A_29)
	{
		checked
		{
			short num = (short)A_4.Length;
			short num2 = (short)unchecked(num - 1);
			short num3 = (short)unchecked(A_12 - 1);
			double[] array = new double[2 + (short)unchecked(num * 3) - 1 + 1];
			double num4 = double.MinValue;
			short[] array2 = new short[num2 + 1];
			short[] array3 = new short[num2 + 1];
			double[] array4 = new double[num2 + 1];
			int length = Enum.GetValues(typeof(g)).Length;
			double[] array5 = new double[2 + num * length - 1 + 1];
			double[] array6 = new double[2 + num * length - 1 + 1];
			short[] array7 = new short[2 + num * length - 1 + 1];
			bool num5 = A_11.w().ay();
			float[] array8 = new float[num3 + 1];
			i i10 = ((!num5) ? i.a : i.b);
			if (A_9)
			{
				int num6 = num3;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					array8[num7] = 1f;
				}
			}
			if (A_1)
			{
				array7[0] = 1;
				if (i10 == i.c)
				{
					array7[1] = 1;
				}
				array6[0] = 1E-06 * A_7[0];
				array6[1] = 1E-06 * A_7[0];
			}
			array[0] = A_3;
			array[1] = Math.Abs(A_2) * 5.0;
			if (A_2 < array[0])
			{
				A_2 = array[0];
			}
			else if (A_2 > array[1])
			{
				A_2 = array[1];
			}
			array5[0] = A_2;
			array5[1] = A_2;
			short num8 = num2;
			for (short num9 = 0; num9 <= num8; num9 = (short)unchecked(num9 + 1))
			{
				array2[num9] = num9;
				if (A_7[num9] > num4)
				{
					num4 = A_7[num9];
				}
				double num10;
				double num11;
				if (A_5 == j.a && A_11.w().a4())
				{
					num10 = Math.Max(A_13[0], A_4[num9] - 0.5 * A_11.w().a2(1000000000.0 * A_4[num9]) / 1000000000.0);
					num11 = Math.Min(A_13[A_12 - 1], A_4[num9] + 0.5 * A_11.w().a2(1000000000.0 * A_4[num9]) / 1000000000.0);
				}
				else if (A_5 == j.b)
				{
					num10 = Math.Max(A_13[0], A_4[num9] - 0.5 * A_6[num9]);
					num11 = Math.Min(A_13[A_12 - 1], A_4[num9] + 0.5 * A_6[num9]);
				}
				else
				{
					num10 = A_13[0];
					num11 = A_13[A_12 - 1];
				}
				array5[2 + num9 * length + 4] = 0.5;
				array5[2 + num9 * length + 1] = A_4[num9];
				array5[2 + num9 * length + 2] = 0.5 * A_6[num9];
				array5[2 + num9 * length + 3] = 0.5 * A_6[num9];
				if (A_20)
				{
					double num12 = A_7[num9] / A_21[num9];
					array5[2 + num9 * length + 0] = num12;
					array6[2 + num9 * length + 0] = 1E-06 * num12;
					array[2 + (short)unchecked(num9 * 3) + 0] = A_8[num9] / A_21[num9];
					array[2 + (short)unchecked(num9 * 3) + 1] = A_4[num9] - 2.0 * (A_4[num9] - num10);
					array[2 + (short)unchecked(num9 * 3) + 2] = A_4[num9] + 2.0 * (num11 - A_4[num9]);
				}
				else
				{
					array[2 + (short)unchecked(num9 * 3) + 0] = A_8[num9];
					array[2 + (short)unchecked(num9 * 3) + 1] = num10;
					array[2 + (short)unchecked(num9 * 3) + 2] = num11;
					array5[2 + num9 * length + 0] = A_7[num9];
					array6[2 + num9 * length + 0] = 1E-06 * A_7[num9];
				}
				array6[2 + num9 * length + 4] = 1E-06;
				array6[2 + num9 * length + 1] = 1E-12;
				array6[2 + num9 * length + 2] = 1E-12;
				array7[2 + num9 * length + 4] = 1;
				array7[2 + num9 * length + 0] = 1;
				array7[2 + num9 * length + 1] = 1;
				array7[2 + num9 * length + 2] = 1;
				if (i10 == i.b || i10 == i.c)
				{
					array6[2 + num9 * length + 3] = 1E-12;
					array7[2 + num9 * length + 3] = 1;
				}
			}
			if (A_9)
			{
				array2.CopyTo(array3, 0);
				A_10.CopyTo(array4, 0);
				Array.Sort(array4, array3);
				short[] array9 = array3;
				foreach (short num14 in array9)
				{
					float num15 = (float)Math.Sqrt(A_10[num14]);
					int num16 = num3;
					for (int num17 = 0; num17 <= num16 && !(A_13[num17] > A_4[num14] + 1.0 * A_6[num14]); num17++)
					{
						if (A_13[num17] > A_4[num14] - 1.0 * A_6[num14])
						{
							array8[num17] = 2f * num15;
						}
					}
				}
			}
			short result = unchecked(f6.SolveCTM4((short)A_0, A_15, A_16, A_17, A_12, ref A_13[0], ref A_14[0], ref A_23[0], num, ref array5[0], ref array6[0], ref array7[0], ref array[0], A_18, A_19, (short)i10, A_20, ref A_22[0], A_9, ref array8[0]));
			A_24 = array5[0];
			A_25 = array5[1];
			int num18 = num2;
			for (int num19 = 0; num19 <= num18; num19++)
			{
				A_26[num19] = array5[2 + num19 * length + 1];
				A_27[num19] = array5[2 + num19 * length + 2];
				if (i10 == i.b || i10 == i.c)
				{
					A_28[num19] = array5[2 + num19 * length + 3];
				}
				else
				{
					A_28[num19] = A_27[num19];
				}
				A_29[num19] = array5[2 + num19 * length + 0];
			}
			double[] array10 = new double[A_26.Length - 1 + 1];
			double[] array11 = new double[A_26.Length - 1 + 1];
			A_26.CopyTo(array10, 0);
			A_26.CopyTo(array11, 0);
			Array.Sort(A_26, A_29);
			Array.Sort(array10, A_27);
			Array.Sort(array11, A_28);
			return result;
		}
	}

	protected double[] m2(double[] A_0)
	{
		int num = A_0.Length;
		checked
		{
			int num2 = num - 1;
			double[] array = new double[num2 + 1];
			int num3 = num2;
			double A_2 = default(double);
			double A_3 = default(double);
			double A_4 = default(double);
			for (int num4 = 0; num4 <= num3; num4++)
			{
				double num5 = 1.0;
				int num6 = num4 + 1;
				for (int num7 = 1; num7 <= num6; num7++)
				{
					int a_ = num7 - 1;
					double a_2 = A_0[num4];
					double[] a_3 = cy;
					double[] a_4 = a1;
					double[] a_5 = a3;
					double A_1 = 0.0;
					m2(a_, a_2, A_2: true, a_3, a_4, a_5, ref A_2, ref A_1);
					m2(num7, A_0[num4], num7 < num, cy, a1, a3, ref A_3, ref A_4);
					double num8 = (Math.Pow(A_2 - A_3, 2.0) + Math.Pow(A_4, 2.0)) / (Math.Pow(A_2 + A_3, 2.0) + Math.Pow(A_4, 2.0));
					if (num7 == num4 + 1)
					{
						array[num4] = num5 * num5 * num8;
					}
					num5 *= 1.0 - num8;
				}
			}
			return array;
		}
	}

	protected double[] p9(double[] A_0, double[] A_1, cf A_2)
	{
		checked
		{
			int num = A_0.Length - 1;
			double[] array = new double[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				array[num3] = A_1[num3] / A_2.w().a1(1000000000.0 * A_0[num3]);
			}
			return array;
		}
	}

	protected double m2(double A_0, double A_1, cf A_2)
	{
		double[] a_ = cy;
		double[] a_2 = a1;
		double[] a_3 = a3;
		double A_3 = 0.0;
		double A_4 = default(double);
		m2(1, A_1, A_2: true, a_, a_2, a_3, ref A_4, ref A_3);
		double num = A_4 / 1.0002700090408325;
		double a_4 = 1000000000.0 * A_0;
		double a_5 = 1000000000.0 * A_1;
		double num2 = A_2.w().a5(a_4);
		double num3 = A_2.w().a5(a_5) - num2;
		double a_6 = num3 * num;
		double num4 = A_2.w().ap(a_5, A_2.o(), a_6);
		return num3 * Math.Sqrt((num * num - num4) / (1.0 - num4)) / 1000000.0;
	}

	protected bool m2(double A_0, double A_1, bool A_2, cf A_3, ref double A_4)
	{
		bool flag = false;
		int num = 0;
		checked
		{
			double val = cy[cy.Length - 1];
			double val2 = cy[0];
			bool flag2 = false;
			double num2;
			double num3;
			do
			{
				if (A_2)
				{
					num2 = A_1;
					num3 = Math.Min(A_1 * 2.0, val);
					if (m2(A_1, num3, A_3) > A_0)
					{
						flag = true;
					}
					else
					{
						num3 = Math.Min(2.0 * num3, val);
					}
				}
				else
				{
					num2 = Math.Max(A_1 * 0.5, val2);
					num3 = A_1;
					if (m2(num2, A_1, A_3) > A_0)
					{
						flag = true;
					}
					else
					{
						num2 = Math.Max(num2 * 0.5, val2);
					}
				}
				num++;
			}
			while (!flag && num < 5);
			if (!flag)
			{
				if (A_2)
				{
					A_4 = num3;
				}
				else
				{
					A_4 = num2;
				}
				return false;
			}
			num = 0;
			double num4;
			double num5;
			do
			{
				num4 = (num3 + num2) / 2.0;
				if (A_2)
				{
					num5 = m2(A_1, num4, A_3);
					if (num5 > A_0)
					{
						num3 = num4;
					}
					else
					{
						num2 = num4;
					}
				}
				else
				{
					num5 = m2(num4, A_1, A_3);
					if (num5 < A_0)
					{
						num3 = num4;
					}
					else
					{
						num2 = num4;
					}
				}
				num++;
				flag2 = Math.Abs(num5 - A_0) / A_0 <= 0.001;
			}
			while (!flag2 && num < 60);
			if (!flag2)
			{
				ab8().c(fz.b.a, "Failure to converge after " + Conversions.ToString(60) + " tries. targetThickness = " + A_0 + " m, knownPeakWL = " + A_1 + " m, currentWL = " + num4 + " m, currentThick = " + num5 + " m");
				return false;
			}
			A_4 = num4;
			return true;
		}
	}

	protected bool m2(double[] A_0, double[] A_1, cf A_2, double[] A_3, ref List<int> A_4)
	{
		double num;
		double num2;
		if (A_1[1] > A_1[0])
		{
			num = A_0[1];
			num2 = A_0[0];
		}
		else
		{
			num = A_0[0];
			num2 = A_0[1];
		}
		double a_ = A_3[7];
		double a_2 = A_3[6];
		A_4 = new List<int>();
		double A_5 = default(double);
		m2(a_2, num, A_2: true, A_2, ref A_5);
		double A_6 = default(double);
		m2(a_, num, A_2: true, A_2, ref A_6);
		double A_7 = default(double);
		m2(a_2, num, A_2: false, A_2, ref A_7);
		double A_8 = default(double);
		m2(a_, num, A_2: false, A_2, ref A_8);
		double val = num - 0.5 * A_2.w().a2(1000000000.0 * num) / 1000000000.0;
		val = Math.Max(val, A_7);
		double val2 = num + 0.5 * A_2.w().a2(1000000000.0 * num) / 1000000000.0;
		val2 = Math.Min(val2, A_5);
		checked
		{
			int num3 = cy.Length - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				if ((cy[num4] >= A_5 && cy[num4] <= A_6) || (cy[num4] >= A_8 && cy[num4] <= A_7) || (cy[num4] >= val && cy[num4] <= val2))
				{
					A_4.Add(num4);
				}
			}
			if (num > num2)
			{
				return num2 >= A_8 && num2 <= A_7;
			}
			return num2 >= A_5 && num2 <= A_6;
		}
	}

	protected void m2(double[] A_0, short[] A_1, int A_2, cf A_3, bool A_4, ref bool A_5, double[] A_6)
	{
		int num = A_0.Length;
		A_5 = false;
		cf.c c10 = A_3.w();
		double num2 = 0.0;
		double num3 = 1.0002700090408325;
		checked
		{
			double A_8 = default(double);
			for (int num4 = 1; num4 <= A_2; num4++)
			{
				if (num > num4)
				{
					int a_ = num4;
					double a_2 = A_0[num4];
					double[] a_3 = cy;
					double[] a_4 = a1;
					double[] a_5 = a3;
					double A_7 = 0.0;
					m2(a_, a_2, A_2: true, a_3, a_4, a_5, ref A_8, ref A_7);
					double num5 = A_8 / num3;
					double a_6 = 1000000000.0 * A_0[num4 - 1];
					double a_7 = 1000000000.0 * A_0[num4];
					double num6 = c10.a5(a_6);
					double num7 = c10.a5(a_7);
					double num8 = num7 - num6;
					double num9 = num8 * num5;
					num2 += num9;
					double num10 = c10.ap(a_7, A_3.o(), num2);
					double num11 = num8 * Math.Sqrt((num5 * num5 - num10) / (1.0 - num10)) / 1000000.0;
					if (A_1[num4 * 4 + 0] == 1)
					{
						A_6[num4] = num11;
					}
					if (A_4)
					{
						ab8().c(fz.b.a, a_6.ToString("0.0000") + ", " + a_7.ToString("0.0000") + ", " + num6.ToString("0.0000") + ", " + num7.ToString("0.0000") + ", " + num8.ToString("0.00000") + ", " + A_8.ToString("0.000000") + ", " + num3.ToString("0.000000") + ", " + num9.ToString("0.0000") + ", " + num10.ToString("0.000000") + ", " + (1000000.0 * A_6[num4]).ToString("0.0000"));
					}
				}
				else
				{
					A_5 = true;
				}
			}
			c10 = null;
		}
	}

	protected void m2(double[] A_0, int A_1, int A_2, int A_3, double[] A_4, int[] A_5, ref double[] A_6)
	{
		checked
		{
			int num = A_3 - 1;
			double[] array = new double[num + 1];
			double[] array2 = new double[num + 1];
			int num2 = A_0.Length - 1;
			A_6 = new double[A_3 * num2 - 1 + 1];
			int num3 = num2;
			for (int num4 = 1; num4 <= num3; num4++)
			{
				double num5 = double.MaxValue;
				int num6 = num;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					if (Math.Abs(A_4[num7] - A_0[num4]) < num5)
					{
						num5 = Math.Abs(A_4[num7] - A_0[num4]);
						A_5[num4] = num7;
					}
					array2[num7] = a1[num4 * A_1 + A_2 + num7];
					array[num7] = a3[num4 * A_1 + A_2 + num7];
					A_6[(num4 - 1) * A_3 + num7] = Math.PI * 4.0 * array[num7] / A_4[num7];
				}
			}
		}
	}

	public static void m2(int A_0, double[] A_1, double[] A_2, double[] A_3, int A_4, double[] A_5, double[] A_6, ref int A_7, ref int A_8, ref double[] A_9, ref double[] A_10, ref bool A_11, ref double[] A_12)
	{
		checked
		{
			int num = A_0 - 1;
			int num2 = A_4 - 1;
			A_11 = false;
			if (num2 > 0)
			{
				A_12 = new double[num + 1];
				int num3 = 0;
				double num4 = double.MinValue;
				int num5 = num;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					if (A_2[num6] > num4)
					{
						num4 = A_2[num6];
						num3 = num6;
					}
				}
				int num7 = num;
				for (int num8 = 0; num8 <= num7; num8++)
				{
					A_12[num8] = A_2[num3] / A_2[num8];
					if (A_12[num8] > 35.0)
					{
						A_11 = true;
					}
				}
			}
			if (A_11)
			{
				A_7 = 0;
				A_8 = num2;
			}
			else
			{
				double num9 = Math.Max(A_5[0], A_1[0] - 5.0 * A_3[0]);
				double num10 = Math.Min(A_5[num2], A_1[A_0 - 1] + 5.0 * A_3[A_0 - 1]);
				int num11 = num2;
				for (int num12 = 1; num12 <= num11; num12++)
				{
					if (A_5[num12] > num9)
					{
						A_7 = num12 - 1;
						break;
					}
				}
				for (int num13 = A_4 - 2; num13 >= 0; num13 += -1)
				{
					if (A_5[num13] < num10)
					{
						A_8 = num13 + 1;
						break;
					}
				}
			}
			if (A_7 == 0 && A_8 == num2)
			{
				A_9 = A_5;
				A_10 = A_6;
				return;
			}
			A_9 = new double[A_8 - A_7 + 1];
			A_10 = new double[A_8 - A_7 + 1];
			int num14 = A_8 - A_7;
			for (int num15 = 0; num15 <= num14; num15++)
			{
				A_9[num15] = A_5[A_7 + num15];
				A_10[num15] = A_6[A_7 + num15];
			}
		}
	}

	protected double m2(double[] A_0, double[] A_1)
	{
		double num = double.MinValue;
		checked
		{
			int num2 = A_0.Length - 1;
			double num3 = 0.0;
			if (num2 == 0)
			{
				return 1.0;
			}
			int num4 = num2;
			int num6 = default(int);
			for (int num5 = 0; num5 <= num4; num5++)
			{
				if (A_1[num5] > num)
				{
					num = A_1[num5];
					num6 = num5;
				}
			}
			int num7 = num2;
			for (int num8 = 0; num8 <= num7; num8++)
			{
				if (num8 != num6)
				{
					double num9 = A_0[num8] / A_0[num6] / (A_1[num8] / num);
					num3 = ((!(num9 > 1.0)) ? (num3 + num9) : (num3 + 1.0 / ((num9 - 1.0) * 0.25 + 1.0)));
				}
			}
			return num3 / (double)num2;
		}
	}

	private double m2(double[] A_0, double[] A_1, cf A_2)
	{
		checked
		{
			int num = A_0.Length - 1;
			if (num < 0)
			{
				return 0.0;
			}
			double num2 = double.MinValue;
			int num3 = num;
			int num5 = default(int);
			for (int num4 = 0; num4 <= num3; num4++)
			{
				if (A_1[num4] > num2)
				{
					num2 = A_1[num4];
					num5 = num4;
				}
			}
			double a_ = 1000000000.0 * A_0[num5];
			return A_2.w().a5(a_) / 1000000.0;
		}
	}

	public ErrPublic m2(string A_0, hg A_1, hd A_2, int[] A_3, int[] A_4, Collection<hr> A_5, Collection<hc> A_6, ref double[] A_7, ref bool A_8, bool A_9, bool A_10, short A_11, Collection<double[]> A_12, he A_13, cb A_14, ref string A_15, eo.a A_16)
	{
		hi A_17 = null;
		short A_18 = 0;
		short[] array = null;
		float[] array2 = null;
		short[] array3 = null;
		int[] array4 = null;
		List<short> list = new List<short>();
		List<float> list2 = new List<float>();
		bool A_19 = false;
		short[] A_20 = new short[408];
		checked
		{
			double[] array5 = new double[c7 - 1 + 1];
			short[] array6 = new short[c7 - 1 + 1];
			short[] A_21 = new short[c7 * 4 - 1 + 1];
			double[] A_22 = new double[c7 * 6 - 1 + 1];
			bool flag = false;
			ErrPublic errPublic = ErrPublic.None;
			double[] array7 = null;
			double[] array8 = null;
			double[] A_23 = null;
			double[] array9 = null;
			double[] A_24 = null;
			double[] A_25 = null;
			double[] array10 = null;
			double[] array11 = null;
			double[] array12 = null;
			int[] array13 = null;
			fy fy2 = null;
			fy fy3 = null;
			fy a_ = null;
			fy a_2 = null;
			double[] array14 = null;
			double[] array15 = null;
			es es2 = null;
			cc.b b10 = null;
			bool flag2 = false;
			int num = c4 - 1;
			int num2 = c8 - 1;
			int num3 = da - 1;
			short[] array16 = new short[num + 1];
			short[] array17 = new short[num + 1];
			c5 = new short[num + 1];
			short[] array18 = new short[num + 1];
			dk = new int[num + 1];
			dj = new int[num + 1];
			dl = new int[num + 1];
			dm = new int[num + 1];
			dn = new int[num + 1];
			@do = new bool[num + 1];
			Collection<hr> collection = new Collection<hr>();
			short[] array19 = null;
			short[] array20 = null;
			double[] array21 = null;
			double[] array22 = null;
			double[] array23 = null;
			double[] array24 = null;
			short num4 = 1;
			bool flag3 = false;
			cf cf2 = null;
			bool flag4 = true;
			bool a_3 = true;
			double num5 = 0.0;
			cc.c a_4 = null;
			try
			{
				cr = false;
				f6.ClearTerminationRequest2(cu);
				cp = true;
				cj = null;
				double[] array25 = new double[num2 + 1];
				double[] A_26 = new double[num2 + 1];
				if (da > 0)
				{
					array8 = new double[num3 + 1];
				}
				cf2 = A_5[0].cu().q();
				if (cf2 != null)
				{
					flag3 = true;
				}
				bool flag5 = A_1.dh().ax(A_16);
				bool flag6 = A_1.dh().a8();
				eo.b a_5 = A_1.dh().at(A_16, flag3);
				int num6 = 0;
				int num7 = 0;
				db = 0;
				dc = 0;
				int num8 = num;
				bool flag7 = default(bool);
				short num10 = default(short);
				int num13 = default(int);
				for (int num9 = 0; num9 <= num8; num9++)
				{
					dj[num9] = num7;
					dk[num9] = num6;
					dh[num9] = db;
					di[num9] = dc;
					if (A_4[num9] <= A_3[num9] && !flag3)
					{
						ab8().c(fz.b.b, "MeasureLayers Error: Last Plot Point (" + A_4[num9] + ") <= First Plot Point (" + A_3[num9] + ")!");
						return ErrPublic.SolverArgs;
					}
					if (A_2 == null)
					{
						ab8().c(fz.b.b, "MeasureLayers Error: solverModelInfo is Nothing!");
						return ErrPublic.SolverArgs;
					}
					num10 = (array16[num9] = ((!flag3) ? ((short)(A_4[num9] - A_3[num9] + 1)) : ((short)c8)));
					num6 = ((!dd[num9]) ? (num6 + num10) : (num6 + 2 * num10));
					num7 += num10;
					jf.e(A_5[num9].cu().m(), 0.0);
					hg hg2 = ((num9 != 0) ? A_13.ad()[num9] : A_1);
					A_17 = hg2.b3(hg2.c2());
					db += (A_17.g7() + 2) * num10;
					if (!flag5)
					{
						continue;
					}
					short[] A_27 = null;
					int num11 = 0;
					if (A_17.hf() && A_17.au(hg2.dh().aw(A_16), A_16))
					{
						A_17.au(ref A_27);
					}
					int num12 = A_17.g7() + 1;
					for (num13 = 0; num13 <= num12; num13++)
					{
						if (A_27 != null && A_27[num13] != 0)
						{
							continue;
						}
						gc gc2 = A_17.eu(num13);
						if (gc2.ah(flag5) || gc2.aj(flag5))
						{
							if (ai[num13] != null && !ai[num13].k)
							{
								num11 += ai[num13].b.Length;
							}
							if (!flag7)
							{
								hd.a a10 = gc2.ag(A_2, hg2.dh(), A_16);
								if (a10 == hd.a.q || a10 == hd.a.t || a10 == hd.a.u)
								{
									flag7 = true;
								}
							}
						}
						gc2 = null;
					}
					dc += num11 * num10;
				}
				int num14 = num6 - 1;
				int num15 = num7 - 1;
				_ = db - 1;
				int num16 = db + dc - 1;
				if (a0.GetUpperBound(0) < num16)
				{
					a0 = new double[num16 + 1];
					a1 = new double[num16 + 1];
					a2 = new double[num16 + 1];
					a3 = new double[num16 + 1];
				}
				A_7 = new double[num14 + 1];
				cy = new double[num15 + 1];
				a7 = new double[num15 + 1];
				double[] A_28 = new double[num14 + 1];
				c0 = A_5[0].b9();
				c1 = A_5[0].ca();
				c2 = A_5[0].b5();
				c3 = A_1.cl();
				cg = new double[11];
				cf = new double[11];
				int num17 = num;
				int num28 = default(int);
				bool flag8 = default(bool);
				bool flag9 = default(bool);
				short num32 = default(short);
				float a_6 = default(float);
				short num33 = default(short);
				bool a_7 = default(bool);
				int A_34 = default(int);
				short num47 = default(short);
				bool flag10 = default(bool);
				bool flag11 = default(bool);
				bool A_45 = default(bool);
				float A_46 = default(float);
				bool A_47 = default(bool);
				bool A_48 = default(bool);
				short A_51 = default(short);
				short A_52 = default(short);
				int num26 = default(int);
				int num27 = default(int);
				short num18 = default(short);
				int num23 = default(int);
				int num24 = default(int);
				for (int num9 = 0; num9 <= num17; num9++)
				{
					num10 = array16[num9];
					num18 = (short)unchecked(num10 - 1);
					int num19 = de[num9];
					int num20 = dj[num9];
					int num21 = dk[num9];
					int num22 = df[num9];
					if (flag3)
					{
						num23 = 0;
						num24 = num2;
					}
					else
					{
						num23 = A_3[num9];
						num24 = A_4[num9];
					}
					hg hg2 = ((num9 != 0) ? A_13.ad()[num9] : A_1);
					A_17 = hg2.b3(hg2.c2());
					int num25 = (short)(A_17.g7() + 2);
					num26 = num25 - 1;
					num27 = num25 - 2;
					array17[num9] = (short)num25;
					hr hr2 = global::b9.m2(A_5[num9], hg2);
					collection.Add(hr2);
					es2 = hr2.cu().p();
					num28 = (short)hr2.cz().Length;
					int num29 = num28 - 1;
					int num30 = num18;
					for (num13 = 0; num13 <= num30; num13++)
					{
						a7[num20 + num13] = a6[num22 + num23 + num13];
					}
					float num31 = 1.00027f;
					if (num9 == 0)
					{
						if (!flag3)
						{
							hi hi2 = A_17;
							flag8 = hi2.d6(A_16) && hi2.d8(A_16);
							if (A_10)
							{
								flag9 = true;
								flag8 = false;
							}
							else
							{
								flag9 = hi2.d7(A_16) && hi2.d8(A_16);
							}
							hi2 = null;
							if ((flag8 || flag9) && !jf.e(hr2.cu().m(), 0.0) && num == 0)
							{
								return ErrPublic.OnlyExactSpectrumAnalysisPermittedForRAtAngle;
							}
						}
						if (hr2.bs() != null && hr2.bs().Count > 0)
						{
							hn hn2 = hr2.bs()[0];
							num32 = hn2.g();
							num33 = num32;
							short num34 = (short)unchecked(num32 - 1);
							double[] array26 = new double[num34 + 1];
							array19 = new short[num34 + 1];
							array20 = new short[num34 + 1];
							array26 = hn2.i();
							a_6 = hn2.h();
							this.m2(num23, num32, array26, array19, num28, hr2.cz(), hr2.c0());
							short num35 = 0;
							int num36 = num34;
							for (num13 = 0; num13 <= num36; num13++)
							{
								if (array19[num13] >= 0)
								{
									array20[num35] = (short)num13;
									num35 = (short)unchecked(num35 + 1);
								}
							}
							num33 = num35;
							short num37 = (short)unchecked(num33 - 1);
							array21 = new double[num37 + 1];
							array22 = new double[num37 + 1];
							array23 = new double[num37 + 1];
							array24 = new double[num37 + 1];
							array20 = (short[])Utils.CopyArray(array20, new short[num37 + 1]);
							int num38 = num37;
							for (num13 = 0; num13 <= num38; num13++)
							{
								array21[num13] = hn2.j()[array20[num13]];
								array22[num13] = this.m2(hn2.k()[array20[num13]]);
							}
							if (num33 > 0)
							{
								num4 = 2;
							}
							hn2 = null;
						}
						else
						{
							num32 = 0;
							num33 = 0;
							array19 = new short[1];
							array20 = new short[1];
							array21 = new double[1];
							array22 = new double[1];
							array23 = new double[1];
							array24 = new double[1];
						}
					}
					int num39 = num29;
					for (num13 = 0; num13 <= num39; num13++)
					{
						array25[num22 + num13] = hr2.cz()[num13];
						A_26[num22 + num13] = array25[num22 + num13] * (double)num31;
					}
					array7 = hr2.c0();
					if (num28 > 4096)
					{
						ab8().c(fz.a.b, "MeasErrTooManyPts");
						A_8 = true;
						return ErrPublic.SolverArgs;
					}
					A_25 = new double[num14 + 1];
					if (dd[num9])
					{
						int num40 = (short)hr2.bl().c0().Length;
						int num41 = num40 - 1;
						A_23 = new double[1];
						hr obj = hr2.bl();
						double[] A_29 = obj.cz();
						hr hr3;
						double[] A_30 = (hr3 = hr2.bl()).c0();
						hr hr4;
						double[] A_31 = (hr4 = hr2).cz();
						jf.a(ref A_29, ref A_30, num40, ref A_31, ref A_23, num28);
						hr4.t(A_31);
						hr3.af(A_30);
						obj.t(A_29);
						int num42 = num41;
						for (num13 = 0; num13 <= num42; num13++)
						{
							array8[dg[num9] + num13] = hr2.bl().cz()[num13];
						}
					}
					be = flag6 && File.Exists(global::a1.d() + "AnalyzeAllPoints.fmlic");
					a5 = this.m2(num9, 0, 0.0, ah, num23, num24, A_26, hg2, a6);
					int num43 = num26;
					for (num13 = 1; num13 <= num43; num13++)
					{
						gc gc3 = A_17.eu(num13);
						if (!gc3.ah(flag5) && !gc3.aj(flag5))
						{
							continue;
						}
						a_7 = true;
						hd.a num44 = gc3.ag(A_2, hg2.dh(), A_16);
						if ((num44 == hd.a.e) & (gc3.ah(flag5) | gc3.aj(flag5)))
						{
							a5 = (int)Math.Round((double)this.m2(num9, 0, 0.0, ah, num23, num24, A_26, hg2, a6) * 0.1);
						}
						if ((num44 == hd.a.g) & (gc3.ah(flag5) | gc3.aj(flag5)))
						{
							a5 = (int)Math.Round((double)this.m2(num9, 0, 0.0, ah, num23, num24, A_26, hg2, a6) * 0.1);
						}
						if ((num44 == hd.a.m) & (gc3.ah(flag5) | gc3.aj(flag5)))
						{
							double num45 = this.m2(num9, a5, A_26, num28, num23, num24);
							if (num45 > 3.000000106112566E-06)
							{
								a5 = (int)Math.Round((double)((float)a5 * 3E-06f) / num45);
							}
						}
					}
					if (a5 < 1)
					{
						a5 = 1;
					}
					short[] A_32 = new short[num28 + 1];
					float[] A_33 = new float[1];
					if (num9 > 0)
					{
						dn[num9] = A_18 + dn[num9 - 1];
					}
					if (be)
					{
						this.m2(ref A_32, ref A_18, num23, num24, ref array18[num9], ref A_33);
					}
					else
					{
						hr hr5 = hr2;
						this.m2(num9, a5, ref A_32, ref A_18, A_26, num28, num23, num24, hr5.cc(), hr5.cd(), hr5.ce(), A_12[num9], ref array18[num9], ref A_33, flag7, a_7);
						hr5 = null;
					}
					if (num9 == 0)
					{
						flag2 = unchecked(num4 % 2) == 0;
						this.m2(flag2, num33, array20, array19, ref A_18, ref A_32, ref A_33);
					}
					list.AddRange(A_32);
					list2.AddRange(A_33);
					c5[num9] = A_18;
					double num46 = -1.0;
					A_34 = 0;
					num47 = 0;
					double num48 = 0.0;
					int num49 = A_17.g7();
					for (num13 = 1; num13 <= num49; num13++)
					{
						gc gc3 = A_17.eu(num13);
						gc gc4 = gc3;
						if (gc4.af(a_5))
						{
							num47 = (short)unchecked(num47 + 1);
							if (aq[num19 + num13] > num46)
							{
								num46 = aq[num19 + num13];
								A_34 = num13;
							}
							num48 += gc4.ai() * (1.0 + 0.01 * gc4.av()) * ah[num19 + num13, num23];
							if (ai[num19 + num13] != null && (gc4.ah(flag5) || gc4.aj(flag5)))
							{
								flag10 = true;
							}
						}
						else
						{
							num48 += gc4.ai() * ah[num19 + num13, num23];
						}
						if (at[num19 + num13] != 0)
						{
							flag11 = true;
						}
						if (gc4.ak() != 0.0)
						{
							flag11 = true;
						}
						if (gc4.aj() != 0.0)
						{
							flag11 = true;
						}
						gc4 = null;
					}
					if (!flag11 && num48 > qh(A_26[num22 + num23], a7[num20] * 1000000000.0))
					{
						flag11 = true;
					}
					errPublic = this.m2(num9, ref cx, ah, an, (short)num23, (short)num24, hg2, A_2, A_26, array7, cy, A_28, A_21, A_22, hr2, flag8, es2, flag3, num47 > 1, dd[num9], A_23, A_16);
					if (errPublic != ErrPublic.None)
					{
						return errPublic;
					}
					bool flag12 = flag10 && !flag8 && !A_17.gx() && !A_17.hf();
					double[] array27 = new double[array17[num9] - 1 + 1];
					if (flag12)
					{
						int num50 = num25 - 1;
						for (num13 = 0; num13 <= num50; num13++)
						{
							array27[num13] = az[num19 + num13];
						}
					}
					if ((((A_17.gx() || flag10) && !A_17.hf()) || flag8) && !flag9 && !flag3 && (A_34 > 0 || flag8))
					{
						bool flag13 = false;
						int num51 = num26;
						for (num13 = 0; num13 <= num51; num13++)
						{
							gc gc5 = A_17.eu(num13);
							if (ai[num19 + num13] != null && !ai[num19 + num13].t() && (gc5.ah(flag5) || gc5.aj(flag5)))
							{
								flag13 = true;
								break;
							}
							gc5 = null;
						}
						int[][] array28 = null;
						int[][] array29 = null;
						double[] array30 = null;
						int[] array31 = null;
						int[] array32 = null;
						double[,] array33 = null;
						double[,] array34 = null;
						int num52 = hr2.c2() - 1;
						array33 = new double[num26 + 1, num52 + 1];
						array34 = new double[num26 + 1, num52 + 1];
						if (flag13)
						{
							array30 = new double[num26 + 1];
							array28 = new int[num26 + 1][];
							array29 = new int[num26 + 1][];
							array31 = new int[num26 + 1];
							array32 = new int[num26 + 1];
							int num53 = num26;
							for (num13 = 0; num13 <= num53; num13++)
							{
								gc gc6 = A_17.eu(num13);
								int[] array35;
								if (ai[num19 + num13] != null && (gc6.ah(flag5) || gc6.aj(flag5)))
								{
									jc jc2 = ai[num19 + num13];
									int num54 = jc2.b.Length - 2;
									array35 = new int[num54 + 1];
									int num55 = num54;
									for (int num56 = 0; num56 <= num55; num56++)
									{
										array35[num56] = 1;
									}
									array31[num13] = jb.a(num54, jc2.j, jc2.i) - 1;
									array32[num13] = 1;
									jc2 = null;
								}
								else
								{
									array35 = null;
									int num57 = num52;
									for (int num58 = 0; num58 <= num57; num58++)
									{
										array33[num13, num58] = ah[num19 + num13, num58];
										array34[num13, num58] = an[num19 + num13, num58];
									}
								}
								gc6 = null;
								array28[num13] = array35;
							}
						}
						double[] A_35 = null;
						double[] A_36 = null;
						bool flag14 = false;
						float num59 = float.MaxValue;
						do
						{
							if (flag13)
							{
								int num60 = num26;
								for (num13 = 0; num13 <= num60; num13++)
								{
									if (array28[num13] == null)
									{
										continue;
									}
									jc a_8 = ai[num19 + num13];
									int[] a_9 = array28[num13];
									eo a_10 = hg2.dh();
									double[] a_11 = hr2.cz();
									bool A_37 = false;
									bool A_38 = false;
									bool A_39 = false;
									double[] A_31 = null;
									double[] A_30 = null;
									short[] A_40 = null;
									short A_41 = 0;
									short A_42 = 0;
									float[] A_43 = null;
									string A_44 = null;
									jb.a(null, A_1: false, a_8, a_9, A_4: false, null, a_10, A_2, a_11, ref A_45, ref A_37, ref A_38, ref A_39, ref A_31, ref A_35, ref A_36, ref A_30, ref A_40, ref A_41, ref A_42, ref A_43, ref A_44, A_16);
									if (!A_45)
									{
										return ErrPublic.InvalidMixtureData;
									}
									if (A_36 != null)
									{
										int num61 = num52;
										for (int num62 = 0; num62 <= num61; num62++)
										{
											array33[num13, num62] = A_35[num62];
											array34[num13, num62] = A_36[num62];
										}
									}
									else
									{
										int num63 = num52;
										for (int num64 = 0; num64 <= num63; num64++)
										{
											array33[num13, num64] = A_35[num64];
										}
									}
								}
							}
							else
							{
								int num65 = num26;
								for (num13 = 0; num13 <= num65; num13++)
								{
									int num66 = num52;
									for (int num67 = 0; num67 <= num66; num67++)
									{
										array33[num13, num67] = ah[num19 + num13, num67];
										array34[num13, num67] = an[num19 + num13, num67];
									}
								}
							}
							double[] array36 = ji.a(az, num19, num25);
							double[] a_12 = ji.a(A_26, num22, num28);
							double[] a_13 = ji.a(cy, num20, num10);
							double[] a_14 = ji.a(a6, num22, num28);
							double[] array37 = ((!dd[num9]) ? ji.a(A_28, num21, num10) : ji.a(A_28, num21, 2 * num10));
							short[] a_15 = ji.a(A_21, dl[num9], num25 * 4);
							double[] array38 = ji.a(A_22, dm[num9], num25 * 6);
							this.m2(num9, ref A_34, array36, array33, array34, hg2, a_12, a_14, array7, (short)num28, num23, num24, A_7, a_13, array37, hr2.cj(), dd[num9], num47, array38, a_15, flag11, ref A_46, ref A_47, ref A_48);
							int num68 = num26 - 1;
							for (num13 = 1; num13 <= num68; num13++)
							{
								az[num13 + num19] = array36[num13];
								ay[num13 + num19] = array36[num13];
								A_22[6 * (num13 + num19) + 0] = array38[6 * num13 + 0];
								A_22[6 * (num13 + num19) + 1] = array38[6 * num13 + 1];
							}
							if (cq)
							{
								return ErrPublic.SolvingAborted;
							}
							if (ct != 0)
							{
								return this.m2(ct);
							}
							if (!flag13)
							{
								continue;
							}
							float num69 = 0f;
							int num70 = num18;
							int num71 = a5;
							for (num13 = 0; ((num71 >> 31) ^ num13) <= ((num71 >> 31) ^ num70); num13 += num71)
							{
								float num72 = (float)(array37[num13] - A_7[num13]);
								num69 += num72 * num72;
							}
							if (dd[num9])
							{
								int num73 = num18;
								int num74 = a5;
								for (num13 = 0; ((num74 >> 31) ^ num13) <= ((num74 >> 31) ^ num73); num13 += num74)
								{
									float num72 = (float)(array37[num10 + num13] - A_7[num10 + num13]);
									num69 += num72 * num72;
								}
								num69 /= 2f;
							}
							if (num59 > num69)
							{
								int num75 = A_17.g7() + 1;
								for (num13 = 0; num13 <= num75; num13++)
								{
									if (array28[num13] != null)
									{
										array29[num13] = (int[])array28[num13].Clone();
									}
									else
									{
										array29[num13] = null;
									}
								}
								array30 = (double[])array36.Clone();
								num59 = num69;
							}
							flag14 = false;
							int num76 = A_17.g7() + 1;
							for (num13 = 0; num13 <= num76; num13++)
							{
								if (array28[num13] == null)
								{
									continue;
								}
								jc jc3 = ai[num19 + num13];
								if (array32[num13] < array31[num13])
								{
									jb.a(jc3.i, jc3.j, array28[num13]);
									array32[num13]++;
									int num77 = num13 - 1;
									for (int num78 = 0; num78 <= num77; num78++)
									{
										gc gc7 = A_17.eu(num78);
										if (ai[num19 + num78] != null && (gc7.ah(flag5) || gc7.aj(flag5)))
										{
											array32[num78] = 1;
											int num54 = ai[num78].b.Length - 2;
											int num79 = num54;
											for (int num80 = 0; num80 <= num79; num80++)
											{
												array28[num78][num80] = 1;
											}
											_ = null;
										}
										gc7 = null;
									}
									flag14 = true;
									break;
								}
								jc3 = null;
							}
						}
						while (flag14);
						if (flag13)
						{
							double[] A_49 = null;
							short[] A_50 = null;
							int num81 = A_17.g7() + 1;
							for (num13 = 0; num13 <= num81; num13++)
							{
								if (array28[num13] != null)
								{
									jc a_16 = ai[num19 + num13];
									int[] a_17 = array29[num13];
									eo a_18 = hg2.dh();
									double[] a_19 = hr2.cz();
									bool A_39 = false;
									bool A_38 = false;
									bool A_37 = false;
									double[] A_30 = null;
									float[] A_43 = null;
									string A_44 = null;
									jb.a(null, A_1: false, a_16, a_17, A_4: false, null, a_18, A_2, a_19, ref A_45, ref A_39, ref A_38, ref A_37, ref A_30, ref A_35, ref A_36, ref A_49, ref A_50, ref A_51, ref A_52, ref A_43, ref A_44, A_16);
									if (!A_45)
									{
										return ErrPublic.InvalidMixtureData;
									}
									int num82 = num52;
									for (int num83 = 0; num83 <= num82; num83++)
									{
										ah[num13 + num19, num83] = A_35[num83];
										an[num13 + num19, num83] = A_36[num83];
									}
									int num84 = dh[num9] + num10 * num13;
									int num85 = num18;
									for (int num86 = 0; num86 <= num85; num86++)
									{
										a0[num84 + num86] = ah[num13 + num19, num23 + num86];
										a1[num84 + num86] = a0[num84 + num86];
										a2[num84 + num86] = an[num13 + num19, num23 + num86];
										a3[num84 + num86] = a2[num84 + num86];
									}
									int num87 = Math.Abs(cx.l[num13]);
									int num88 = A_51 - 1;
									for (int num89 = 0; num89 <= num88; num89++)
									{
										cx.k[num87 + num89] = A_49[num89];
										cx.j[num87 + num89] = A_50[num89];
									}
								}
							}
							if (flag12)
							{
								int num90 = num25 - 1;
								for (num13 = 0; num13 <= num90; num13++)
								{
									az[num19 + num13] = array27[num13];
								}
							}
							else
							{
								int num91 = num25 - 1;
								for (num13 = 0; num13 <= num91; num13++)
								{
									az[num19 + num13] = array30[num13];
								}
							}
						}
						if (flag8 && A_48)
						{
							cx.e = 200;
							cx.f = 0.999f;
							cx.d[0] = 1;
							cx.g = 0.0;
						}
					}
					if (flag9 || flag3 || flag8)
					{
						continue;
					}
					if (A_17.gw() && num47 > 0)
					{
						double[] array39 = new double[A_22.Length - 1 + 1];
						int num92 = A_22.Length - 1;
						for (int num93 = 0; num93 <= num92; num93++)
						{
							array39[num93] = A_22[num93];
						}
						az[num19] = 1.0;
						unchecked
						{
							f6.e e10 = (f6.e)f6.FFTSolve(num10, ref cy[num20], ref A_28[num21], checked((short)num25), ref az[num19], ref A_21[dl[num9]], ref a1[dh[num9]], ref A_22[dm[num9]]);
							if (e10 == f6.e.aw)
							{
								e10 = (f6.e)0;
							}
							if (e10 != 0)
							{
								return this.m2(e10);
							}
						}
						int num94 = A_22.Length - 1;
						for (int num95 = 0; num95 <= num94; num95++)
						{
							A_22[num95] = array39[num95];
						}
					}
					if (A_17.hf() & A_17.au(A_10, A_16))
					{
						short[] A_53 = new short[1];
						A_17.au(ref A_53);
						int num96 = num26;
						for (num13 = 0; num13 <= num96; num13++)
						{
							array6[num19 + num13] = (short)unchecked(checked((short)num19) + A_53[num13]);
						}
					}
				}
				cz = list.ToArray();
				float[] array40 = list2.ToArray();
				short A_55 = default(short);
				short A_58 = default(short);
				int A_62 = default(int);
				int A_63 = default(int);
				double A_64 = default(double);
				double A_65 = default(double);
				double A_66 = default(double);
				bool flag15 = default(bool);
				double a_47 = default(double);
				int A_88 = default(int);
				int A_89 = default(int);
				bool flag26 = default(bool);
				if (!flag8 || A_48)
				{
					if (flag9)
					{
						if (num47 <= 0)
						{
							A_6[0].cf(A_5[0], A_1);
							return ErrPublic.NoLayersSelectedForMeasurement;
						}
						az[0] = 1.0;
						double A_54 = default(double);
						int A_56 = default(int);
						short A_57 = default(short);
						int A_59 = default(int);
						f6.FFTPrepare2(num10, ref cy[0], (short)(A_17.g7() + 2), ref az[0], ref A_21[0], ref a1[0], ref A_22[0], ref A_54, ref A_55, 2048, ref A_56, ref A_57, ref A_58, ref A_59);
						array14 = new double[A_56 + 1];
						double A_60 = default(double);
						unchecked
						{
							f6.e e10 = (f6.e)checked((short)f6.FFTStreamlined2(num10, ref cy[0], ref A_28[0], ref a1[0], A_56, A_57, A_55, 1, 0.0, unchecked((int)A_17.g1()), ref array14[0], ref A_60));
							if (e10 != 0)
							{
								return this.m2(e10);
							}
						}
						int num97 = ((A_60 > 0.0) ? ((int)Math.Round(2.0 * A_54 / A_60)) : 0);
						double a_20 = a1[(short)unchecked(A_55 * num10)] / cy[0] - a1[(short)unchecked(checked((short)unchecked(A_55 * num10)) + num18)] / cy[num18];
						if (num97 > A_56)
						{
							num97 = A_56;
						}
						array15 = new double[num97 + 1];
						A_60 *= 1000000.0;
						int num98 = num97 - 1;
						for (num13 = 0; num13 <= num98; num13++)
						{
							array15[num13] = A_60 * (double)num13;
						}
						int A_61 = default(int);
						if ((A_58 == 0) | (num47 <= 1))
						{
							if (this.m2(0, ref A_21, ref A_22, ref az, ah, an, ref ci, ref A_61, A_1, A_26, num23, num24, array14, array15, num97, A_11, A_17.c3, A_17.c6))
							{
								ab8().c(fz.a.b, "MeasErrorFFTPeakIdFailure");
								flag = true;
							}
						}
						else if (this.m2(A_21, A_22, ref az, ref ci, ref A_61, A_1, A_26, num23, num24, array14, array15, num97, a_20, A_11))
						{
							ab8().c(fz.a.b, "MeasErrorFFTPeakIdFailure");
							flag = true;
						}
						double num130 = default(double);
						double num131 = default(double);
						if (num97 > 0 && (num47 == 1 || num47 == 2))
						{
							int num99 = (int)Math.Round(0.5 * (double)(num23 + num24));
							int num100 = 1;
							float num101 = 1E+30f;
							int num102 = 0;
							float[] array41 = new float[num47 + 1];
							int num103 = default(int);
							int num104 = default(int);
							int num105 = default(int);
							int num106 = default(int);
							do
							{
								if (A_17.eu(num100).af(a_5))
								{
									array41[num102] = (float)(az[num100] * 1000000000.0);
									if (array41[num102] < num101)
									{
										if (num102 > 0)
										{
											num103 = num104;
											num105 = num106;
										}
										num101 = array41[num102];
										num104 = num100;
										num106 = num102;
									}
									else
									{
										num103 = num100;
										num105 = num102;
									}
									num102++;
								}
								num100++;
							}
							while (num100 <= A_17.g7());
							float num107 = (float)((double)(4f * num101) * ah[num104, num99] * (1.0 / A_26[num23] - 1.0 / A_26[num24]));
							float num108 = (float)((double)num101 * ah[num104, num99] / A_26[num99]);
							if (num107 < 9f && num108 < 5f)
							{
								float[] array42 = null;
								float num109 = (float)((A_26[num23] + A_26[num24]) / 2.0);
								float num110 = this.m2(ref cx, A_18, ref cz, ref A_20, (short)A_61, (short)num104, A_6: true, 0.0, 0.0, A_9: false, 512, ref A_62, ref A_63, ref A_64, ref A_65, ref A_66, A_17, num10, ref A_26, ref A_25, ref A_28, ref cy, ref A_22, ref A_21, num47, A_10, array18[0], array40, ref at, num23, A_16, flag6);
								flag15 = false;
								float num111;
								float num112;
								float num113;
								int num114;
								int num115;
								float num116;
								float num117;
								float num118;
								int num119;
								float num128 = default(float);
								int num129 = default(int);
								if ((num107 < 3.5f) & (num47 == 1))
								{
									num111 = (float)(ah[num104, num99] * (1.0 / A_26[num23] - 1.0 / A_26[num24]) * 13.1362886428833 * (double)num109);
									num112 = (float)(ah[num104, num99] * (1.0 / A_26[num23] - 1.0 / A_26[num24]) * 3.284072160720825 * (double)num109);
									num113 = (float)(A_22[6 * num104] * 1000000000.0);
									num114 = (int)Math.Round(((float)(3.5 / (4.0 * ah[num104, num99] * (1.0 / A_26[num23] - 1.0 / A_26[num24])) + ah[num104, num99] * (1.0 / A_26[num23] - 1.0 / A_26[num24]) * 32.840721130371094 * (double)num109) - num113) / num111 + 1f);
									num115 = 21;
									num116 = 5f;
									double[] array43 = new double[num10 + 1];
									f6.CorrectSpectrumForHC(array41[num106] * 10f / 1E+09f, ref cy[0], ref A_28[0], num10, ref a1[0], ref array43[0]);
									num117 = (float)array43[0];
									num118 = (float)array43[0];
									num119 = num18;
									int num120 = num119;
									for (num13 = 1; num13 <= num120; num13++)
									{
										if ((double)num117 < array43[num13])
										{
											num117 = (float)array43[num13];
										}
										else if ((double)num118 > array43[num13])
										{
											num118 = (float)array43[num13];
										}
									}
									float num121 = (num117 - num118) * 0.05f;
									float num122 = (float)array43[0];
									bool flag16 = false;
									bool flag17 = false;
									bool flag18 = false;
									bool flag19 = false;
									for (num13 = 1; (num13 < num10) & (!flag18 | !flag19); num13++)
									{
										if (flag16)
										{
											if ((double)num117 < array43[num13])
											{
												num117 = (float)array43[num13];
											}
											else if ((double)num117 - array43[num13] > (double)num121)
											{
												flag18 = true;
												flag16 = false;
												flag17 = true;
												if (!flag19)
												{
													num118 = (float)array43[num13];
												}
											}
										}
										else if (flag17)
										{
											if ((double)num118 > array43[num13])
											{
												num118 = (float)array43[num13];
											}
											else if (array43[num13] - (double)num118 > (double)num121)
											{
												flag19 = true;
												flag17 = false;
												flag16 = true;
												if (!flag18)
												{
													num117 = (float)array43[num13];
												}
											}
										}
										else
										{
											float num123 = (float)(array43[num13] - (double)num122);
											if (num123 > num121)
											{
												num117 = (float)array43[num13];
												flag16 = true;
											}
											else if (0f - num123 > num121)
											{
												flag17 = true;
												num118 = (float)array43[num13];
											}
										}
									}
									if (!flag18 | !flag19)
									{
										az[num104] = 1.0 / (ah[num104, num99] * (1.0 / A_26[num23] - 1.0 / A_26[num24])) * 1E-09;
										float num124;
										float num125;
										int num126;
										unchecked
										{
											f6.e e10;
											if (A_17.hf() & A_17.au(A_10, A_16))
											{
												h a_21 = cx.c;
												short a_22 = cx.e;
												float a_23 = cx.f;
												float a_24 = cx.h;
												short a_25 = cx.d[0];
												double a_26 = cx.g;
												short a_27 = cx.i[0];
												short a_28 = num10;
												ref double a_29 = ref cy[0];
												short a_30 = A_18;
												ref short a_31 = ref cz[0];
												ref double a_32 = ref A_28[0];
												ref double a_33 = ref a7[0];
												ref double a_34 = ref A_25[0];
												short a_35 = checked((short)(A_17.g7() + 2));
												ref double a_36 = ref az[0];
												ref double a_37 = ref array5[0];
												ref double a_38 = ref a4[0];
												ref short a_39 = ref A_20[0];
												ref double a_40 = ref a1[0];
												ref double a_41 = ref a3[0];
												ref double a_42 = ref A_22[0];
												ref short a_43 = ref cx.l[0];
												ref double a_44 = ref cx.k[0];
												ref short a_45 = ref cx.j[0];
												short A_42 = array6[0];
												e10 = (f6.e)f6.Solve18((short)a_21, a_22, 0f, a_23, -1, a_24, a_25, a_26, a_27, a_28, ref a_29, a_30, ref a_31, ref a_32, ref a_33, ref a_34, a_35, ref a_36, ref a_37, ref a_38, ref a_39, ref a_40, ref a_41, ref a_42, ref a_43, ref a_44, ref a_45, ref A_42, array18[0], ref array40[0], ref at[0], cu);
											}
											else
											{
												e10 = (f6.e)f6.Solve17((short)cx.c, 0, 0f, 0.001f, cx.d[0], cx.g, cx.i[0], num10, ref cy[0], A_18, ref cz[0], ref A_28[0], ref a7[0], ref A_25[0], checked((short)(A_17.g7() + 2)), ref az[0], ref a4[0], ref A_20[0], ref a1[0], ref a3[0], ref A_22[0], ref cx.l[0], ref cx.k[0], ref cx.j[0], array18[0], ref array40[0], ref at[0], cu);
											}
											if (e10 != 0)
											{
												return this.m2(e10);
											}
											num124 = (float)array7[0];
											num125 = (float)array7[0];
											num119 = num18;
											num126 = num119;
										}
										for (num13 = 1; num13 <= num126; num13++)
										{
											if ((double)num124 < array7[num13])
											{
												num124 = (float)array7[num13];
											}
											else if ((double)num125 > array7[num13])
											{
												num125 = (float)array7[num13];
											}
										}
										if (flag18)
										{
											num118 = num117 - (num124 - num125);
										}
										else if (flag19)
										{
											num117 = num118 + (num124 - num125);
										}
									}
								}
								else
								{
									num117 = (float)A_28[0];
									num118 = (float)A_28[0];
									num119 = num18;
									int num127 = num119;
									for (num13 = 1; num13 <= num127; num13++)
									{
										if ((double)num117 < A_28[num13])
										{
											num117 = (float)A_28[num13];
										}
										else if ((double)num118 > A_28[num13])
										{
											num118 = (float)A_28[num13];
										}
									}
									if (num47 == 2)
									{
										num111 = (float)(ah[num104, num99] * (1.0 / A_26[num23] - 1.0 / A_26[num24]) * 3.284072160720825 * (double)num109);
										num112 = (float)(ah[num104, num99] * (1.0 / A_26[num23] - 1.0 / A_26[num24]) * 6.56814432144165 * (double)num109);
										num114 = 50;
										num128 = (float)(ah[num103, num99] * (1.0 / A_26[num23] - 1.0 / A_26[num24]) * 6.56814432144165 * (double)num109);
										num129 = 7;
									}
									else
									{
										num111 = (float)(ah[A_34, num99] * (1.0 / A_26[num23] - 1.0 / A_26[num24]) * 32.840721130371094 * (double)num109);
										num112 = (float)(ah[A_34, num99] * (1.0 / A_26[num23] - 1.0 / A_26[num24]) * 6.56814432144165 * (double)num109);
										num114 = 5;
									}
									num113 = num101 - num111 * (float)(num114 - 1) / 2f;
									num115 = 5;
									num116 = 2f;
								}
								num130 = (num117 + num118) / 2f;
								this.m2(ref A_17, 512, flag15, num130, num10, A_5[0].cz()[0], A_5[0].cz()[1] - A_5[0].cz()[0], flag6, ref cy, ref A_28, ref A_22, ref A_21);
								num131 = 0.0;
								int num132 = num119;
								for (num13 = 0; num13 <= num132; num13++)
								{
									num131 += A_28[num13];
								}
								if (num119 >= 0)
								{
									num131 /= (double)(num119 + 1);
								}
								bool flag20 = false;
								bool flag21 = false;
								float[] array44;
								float[] array45;
								float num136 = default(float);
								int num137 = default(int);
								float num138;
								int num139;
								bool flag23 = default(bool);
								do
								{
									int num133 = num114 - 1;
									array44 = new float[num133 + 1];
									array45 = new float[num133 + 1];
									int num134 = num133;
									for (int num135 = 0; num135 <= num134; num135++)
									{
										if (cq)
										{
											return ErrPublic.SolvingAborted;
										}
										bool flag22 = false;
										if (flag21 && (float)num135 % num136 == 0f && ((num137 >= 0) & (num137 <= Information.UBound(array42))))
										{
											flag22 = true;
										}
										array45[num135] = num113 + num111 * (float)num135;
										if (flag22)
										{
											array44[num135] = array42[num137];
											num137++;
											continue;
										}
										az[num104] = array45[num135] / 1E+09f;
										if (num47 == 2)
										{
											float a_46 = array41[num105] + array41[num106] - array45[num135] - num128 * (float)(num129 - 1) / 2f;
											array44[num135] = this.m2(ref cx, A_18, ref cz, ref A_20, (short)A_61, (short)num103, flag15, num130, num131, A_9: false, 512, ref A_62, ref A_63, ref A_64, ref A_65, ref A_66, num129, a_46, num128, A_17, num10, ref A_26, ref A_25, ref A_28, ref cy, ref A_22, ref A_21, num47, A_10, 0, array40, at, num23, A_16, flag6);
										}
										else
										{
											array44[num135] = this.m2(ref cx, A_18, ref cz, ref A_20, (short)A_61, (short)num104, flag15, num130, num131, A_9: false, 512, ref A_62, ref A_63, ref A_64, ref A_65, ref A_66, A_17, num10, ref A_26, ref A_25, ref A_28, ref cy, ref A_22, ref A_21, num47, A_10, array18[0], array40, ref at, num23, A_16, flag6);
										}
									}
									num138 = array44[0];
									num139 = 0;
									int num140 = num133;
									for (int num135 = 1; num135 <= num140; num135++)
									{
										if (array44[num135] > num138)
										{
											num138 = array44[num135];
											num139 = num135;
										}
									}
									if (num111 > num112)
									{
										if (!flag15 & (num138 < num110))
										{
											flag15 = true;
											num130 = 0.0;
											this.m2(ref A_17, 512, flag15, num130, num10, A_5[0].cz()[0], A_5[0].cz()[1] - A_5[0].cz()[0], flag6, ref cy, ref A_28, ref A_22, ref A_21);
										}
										else if (!flag23 & ((double)(4f * (num113 + num111 * (float)num139)) * ah[num104, num99] * (1.0 / A_26[num23] - 1.0 / A_26[num24]) < 1.0))
										{
											num111 = (float)(ah[num104, num99] * (1.0 / A_26[num23] - 1.0 / A_26[num24]) * 1.313628911972046 * (double)num109);
											num114 = (int)Math.Round(((float)(1.0 / (4.0 * ah[num104, num99] * (1.0 / A_26[num23] - 1.0 / A_26[num24])) + ah[num104, num99] * (1.0 / A_26[num23] - 1.0 / A_26[num24]) * 32.840721130371094 * (double)num109) - num113) / num111 + 1f);
											num112 = (float)(ah[num104, num99] * (1.0 / A_26[num23] - 1.0 / A_26[num24]) * 0.656814455986023 * (double)num109);
										}
										else
										{
											array42 = new float[Information.UBound(array44) + 1];
											int num141 = num133;
											for (int num135 = 0; num135 <= num141; num135++)
											{
												array42[num135] = array44[num135];
											}
											if (flag21)
											{
												num114 = 5;
												num136 = 2f;
											}
											else
											{
												num114 = num115;
												num136 = num116;
											}
											num137 = (int)Math.Round((float)num139 - (float)(num114 - 1) / (2f * num136));
											num113 += num111 * (float)num137;
											num111 /= num136;
											flag21 = true;
										}
									}
									else
									{
										flag20 = true;
									}
									flag23 = true;
								}
								while (!flag20);
								if (jf.b(num138, num110))
								{
									double[] array46 = new double[3];
									double[] array47 = new double[3];
									double[] array48 = new double[3];
									int num142 = ((num139 != 0) ? ((num139 != Information.UBound(array44)) ? (num139 - 1) : (Information.UBound(array44) - 2)) : 0);
									int num143 = num142 + 2;
									int num144 = num143;
									for (int num135 = num142; num135 <= num144; num135++)
									{
										array46[num135 - num142] = array45[num135];
										array47[num135 - num142] = array44[num135];
									}
									jf.a(array46, array47, 3, (short)2, array48);
									if (array48[2] != 0.0)
									{
										az[num104] = (0.0 - array48[1]) / (2.0 * array48[2]) / 1000000000.0;
									}
									else
									{
										ab8().c(fz.b.a, "Warning: MeasEngine.Measurelayers: Unable to determine precise peak location due to probable mathematical underflow. Reporting center of search range instead.");
										az[num104] = array45[num139];
									}
									if (az[num104] < array46[0] / 1000000000.0)
									{
										az[num104] = array46[0] / 1000000000.0;
									}
									else if (az[num104] > array46[2] / 1000000000.0)
									{
										az[num104] = array46[2] / 1000000000.0;
									}
									if (az[num104] < A_22[num104 * 6 + 0])
									{
										az[num104] = A_22[num104 * 6 + 0];
									}
									else if (az[num104] > A_22[num104 * 6 + 1])
									{
										az[num104] = A_22[num104 * 6 + 1];
									}
									if (num47 == 2)
									{
										float a_46 = (float)((double)(array41[num105] + array41[num106]) - az[num104] * 1000000000.0 - (double)(num128 * (float)(num129 - 1) / 2f));
										this.m2(ref cx, A_18, ref cz, ref A_20, (short)A_61, (short)num103, flag15, num130, num131, A_9: false, 512, ref A_62, ref A_63, ref A_64, ref A_65, ref A_66, num129, a_46, num128, A_17, num10, ref cy, ref A_25, ref A_28, ref cy, ref A_22, ref A_21, num47, A_10, array18[0], array40, at, num23, A_16, flag6);
										if (az[num103] < A_22[num103 * 6 + 0])
										{
											az[num103] = A_22[num103 * 6 + 0];
										}
										else if (az[num103] > A_22[num103 * 6 + 1])
										{
											az[num103] = A_22[num103 * 6 + 1];
										}
									}
								}
								else
								{
									az[num104] = array41[num106] / 1E+09f;
									if (num47 == 2)
									{
										az[num103] = array41[num105] / 1E+09f;
									}
									flag15 = true;
								}
								this.m2(ref A_17, 2048, flag15, num130, num10, A_5[0].cz()[0], A_5[0].cz()[1] - A_5[0].cz()[0], flag6, ref cy, ref A_28, ref A_22, ref A_21);
							}
							else
							{
								flag15 = true;
							}
						}
						else
						{
							flag15 = true;
						}
						double A_67 = default(double);
						this.m2(ref cx, A_18, ref cz, ref A_20, A_61, A_61, flag15, num130, num131, A_9: true, 2048, ref A_62, ref A_63, ref A_64, ref A_65, ref A_66, A_17, num10, ref A_26, ref A_25, ref A_28, ref cy, ref A_22, ref A_21, ref A_67, num47, A_10, array18[0], array40, at, num23, A_16, flag6);
						int num145 = (int)Math.Round((double)A_56 / Math.Pow(2.0, A_57));
						a_47 = A_67 * 20000.0 / (double)(num145 * num145);
					}
					else if (flag3)
					{
						double[] A_68 = null;
						double[] A_69 = null;
						double[] A_70 = null;
						double[] A_71 = null;
						int num146 = num26;
						bool A_72 = false;
						List<int> A_73 = null;
						double A_74 = default(double);
						double A_75 = default(double);
						global::cf.l(cy, A_28, num146, A_73, ref A_68, ref A_69, ref A_71, ref A_70, ref A_74, ref A_75, ref A_72);
						int num147 = A_68.Length;
						if (num146 == 2 && num26 == num147 && !this.m2(A_68, A_69, cf2, A_22, ref A_73))
						{
							double[] A_76 = null;
							double[] A_77 = null;
							double[] A_78 = null;
							double[] A_79 = null;
							global::cf.l(cy, A_28, num146, A_73, ref A_76, ref A_77, ref A_79, ref A_78, ref A_74, ref A_75, ref A_72);
							if (A_76.Length >= num146)
							{
								A_68 = A_76;
								A_69 = A_77;
								A_70 = A_78;
								A_71 = A_79;
								num147 = A_68.Length;
							}
						}
						int num148 = num147 - 1;
						double[] A_80 = new double[num148 + 1];
						double[] A_81 = new double[num148 + 1];
						double[] A_82 = new double[num148 + 1];
						double[] A_83 = new double[num148 + 1];
						bool flag24 = false;
						int[] array49 = new int[num148 + 1];
						bool flag25 = num26 == num147;
						if (flag4)
						{
							double[] A_84 = null;
							double[] A_85 = null;
							double[] A_86 = null;
							bool A_87 = false;
							global::b9.m2(num147, A_68, A_69, A_70, num28, cy, A_28, ref A_88, ref A_89, ref A_84, ref A_85, ref A_87, ref A_86);
							int num149 = A_89 - A_88 + 1;
							int num150 = num149 - 1;
							double[] A_90 = null;
							double[] array50 = new double[Math.Max(0, num149 * num148 - 1) + 1];
							@do[0] = false;
							if (@do[0])
							{
								flag24 = true;
								this.m2(A_68, num28, A_88, num149, A_84, array49, ref A_90);
							}
							double[] array51 = new double[num148 + 1];
							array51[0] = 1.0;
							int num151 = 0;
							double A_91 = default(double);
							double A_92 = default(double);
							do
							{
								if (flag24)
								{
									if (num151 == 0)
									{
										this.m2(A_68, A_21, num27, cf2, flag6, ref A_19, az);
									}
									else
									{
										this.m2(A_80, A_21, num27, cf2, flag6, ref A_19, az);
									}
									int num152 = num148;
									for (int num153 = 1; num153 <= num152; num153++)
									{
										int num154 = num150;
										for (int num155 = 0; num155 <= num154; num155++)
										{
											array50[(num153 - 1) * num149 + num155] = Math.Exp(-2.0 * A_90[(num153 - 1) * num149 + num155] * az[num153]);
										}
										array51[num153] = array50[(num153 - 1) * num149 + array49[num153]];
										int num156 = num150;
										for (int num157 = 0; num157 <= num156; num157++)
										{
											array50[(num153 - 1) * num149 + num157] /= array51[num153];
										}
									}
								}
								m m2 = cx;
								short num158 = global::b9.m2(m2.c, a_3, A_74, A_75, A_68, j.a, A_70, A_69, A_71, A_87, A_86, cf2, (short)num149, A_84, A_85, m2.e, m2.f, m2.h, cu, (short)(A_1.ed().gp() + 1), flag24, array51, array50, ref A_25, ref A_91, ref A_92, ref A_80, ref A_82, ref A_83, ref A_81);
								if (num158 != 0)
								{
									ab8().c(fz.b.b, "Error in Solver: Err #" + num158);
								}
								m2 = null;
								num151++;
							}
							while (num151 < 5 && flag24);
							double num159 = A_84[0];
							double num160 = A_84[num150];
							List<double> list3 = new List<double>(A_80);
							List<double> list4 = new List<double>(A_81);
							List<double> list5 = new List<double>(A_82);
							List<double> list6 = new List<double>(A_83);
							int num161 = num148;
							for (int num162 = 0; num162 <= num161; num162++)
							{
								int num163 = -1;
								if (A_81[num162] < 0.0)
								{
									num163 = list4.IndexOf(A_81[num162]);
								}
								if (A_82[num162] < 0.0)
								{
									num163 = list5.IndexOf(A_82[num162]);
								}
								if (A_83[num162] < 0.0)
								{
									num163 = list6.IndexOf(A_83[num162]);
								}
								if (A_80[num162] > num160 || A_80[num162] < num159)
								{
									num163 = list3.IndexOf(A_80[num162]);
								}
								if (num163 >= 0)
								{
									flag25 = false;
									list3.RemoveAt(num163);
									list4.RemoveAt(num163);
									list5.RemoveAt(num163);
									list6.RemoveAt(num163);
								}
							}
							if (!flag25)
							{
								A_80 = list3.ToArray();
								A_81 = list4.ToArray();
								A_82 = list5.ToArray();
								A_83 = list6.ToArray();
								num147 = A_80.Length;
								num148 = num147 - 1;
								A_25 = new double[num14 + 1];
							}
						}
						else
						{
							A_82 = new double[num148 + 1];
							A_83 = new double[num148 + 1];
							int num164 = num148;
							for (int num165 = 0; num165 <= num164; num165++)
							{
								A_82[num165] = A_70[num165] / 2.0;
								A_83[num165] = A_70[num165] / 2.0;
							}
							A_80 = A_68;
							A_81 = A_69;
						}
						if (flag25)
						{
							double[] array52 = new double[num148 + 1];
							double[] array53 = new double[num148 + 1];
							if (cf2.w().au() > 0)
							{
								array52 = p9(A_80, A_81, cf2);
								array53 = this.m2(A_80);
								num5 = this.m2(array52, array53);
							}
							else
							{
								num5 = 0.0;
							}
						}
						else
						{
							num5 = 0.0;
						}
						double[] array54 = new double[num148 + 1];
						int num166 = num148;
						for (int num167 = 0; num167 <= num166; num167++)
						{
							array54[num167] = cf2.w().a5(1000000000.0 * A_80[num167]);
						}
						a_4 = new cc.c(A_80, A_81, A_82, A_83, array54);
						if (!d3)
						{
							this.m2(A_80, A_21, num27, cf2, flag6, ref A_19, az);
							int num168 = num27;
							for (int num169 = 1; num169 <= num168; num169++)
							{
								if (az[num169] < A_22[num169 * 6 + 0])
								{
									az[num169] = A_22[num169 * 6 + 0];
									num5 = 0.0;
									A_25 = new double[num14 + 1];
								}
								else if (az[num169] > A_22[num169 * 6 + 1])
								{
									az[num169] = A_22[num169 * 6 + 1];
									num5 = 0.0;
									A_25 = new double[num14 + 1];
								}
							}
							if (A_72 && flag25)
							{
								string A_44 = "Warning";
								string text = hu.a(ref A_44);
								A_44 = "MeasErrorCTMExtraPeaksFound";
								cj = text + ": " + hu.a(ref A_44);
							}
							else if (!flag25)
							{
								string A_44 = "Warning";
								string text2 = hu.a(ref A_44);
								A_44 = "MeasErrorCTMPeaksMissing";
								cj = text2 + ": " + hu.a(ref A_44);
							}
						}
						else if (num27 > 0)
						{
							az[1] = d2 - this.m2(A_80, A_81, cf2);
						}
					}
					else
					{
						short[] A_93 = null;
						short[] A_94 = null;
						short[] A_95 = null;
						double[] A_96 = null;
						double[] A_97 = null;
						short[] A_98 = null;
						this.m2(c4, array16, cy, array17, A_21, a1, A_22, av, ax, ref A_95, ref A_96);
						this.m2(array6, A_13, A_95, ref A_98, ref A_97, ref A_93, ref A_94);
						int num170 = num;
						for (int num9 = 0; num9 <= num170; num9++)
						{
							if (A_93[num9] != 0)
							{
								int num171 = array17[num9] - 1;
								for (int num172 = 0; num172 <= num171; num172++)
								{
									int num173 = de[num9] + num172;
									int num174 = de[A_94[num9]] + num172;
									A_96[num173 * 9 + 2] = A_96[num174 * 9 + 2];
									A_96[num173 * 9 + 3] = A_96[num174 * 9 + 3];
									A_96[num173 * 9 + 4] = A_96[num174 * 9 + 4];
									A_96[num173 * 9 + 5] = A_96[num174 * 9 + 5];
								}
								continue;
							}
							int num175 = array17[num9] - 1;
							for (int num176 = 0; num176 <= num175; num176++)
							{
								int num173 = de[num9] + num176;
								int num177 = A_98[6 * num173 + 1];
								if (num177 != 0)
								{
									A_96[num173 * 9 + 2] = A_96[num177 * 9 + 2];
									A_96[num173 * 9 + 3] = A_96[num177 * 9 + 3];
								}
								num177 = A_98[6 * num173 + 2];
								if (num177 != 0)
								{
									A_96[num173 * 9 + 4] = A_96[num177 * 9 + 4];
									A_96[num173 * 9 + 5] = A_96[num177 * 9 + 5];
								}
							}
						}
						m m3 = cx;
						int num178 = num;
						for (int num9 = 0; num9 <= num178; num9++)
						{
							int num179 = array17[num9] - 1;
							for (int num180 = 0; num180 <= num179; num180++)
							{
								int num181 = 6 * (de[num9] + num180);
								if (hd.i(A_95[num181 + 1]) || hd.i(A_95[num181 + 2]))
								{
									flag26 = true;
									break;
								}
							}
							if (flag26)
							{
								break;
							}
						}
						short num182 = 0;
						if (flag26)
						{
							int num183 = 0;
							array3 = new short[num + 1];
							array4 = new int[num + 1];
							int num184 = 0;
							short a_48 = 0;
							int num185 = num;
							for (int num9 = 0; num9 <= num185; num9++)
							{
								array4[num9] = num183;
								array3[num9] = f6.ComputeNumGOFIndices(ref cz[num184], c5[num9]);
								num183 += array3[num9];
								num184 += c5[num9];
								if (array18[num9] != 0)
								{
									a_48 = 1;
								}
							}
							array = new short[num183 - 1 + 1];
							array2 = new float[num183 - 1 + 1];
							int num186 = 0;
							num184 = 0;
							int num187 = num;
							for (int num9 = 0; num9 <= num187; num9++)
							{
								num182 = f6.ComputeGofIndicesAndWeights(ref cz[num184], c5[num9], ref array40[num184], ref array[num186], a_48, ref array2[num186], array3[num9]);
								num184 += c5[num9];
								num186 += array3[num9];
							}
						}
						f6.e e10;
						unchecked
						{
							if (num182 != 0)
							{
								e10 = (f6.e)num182;
							}
							else
							{
								short[] array55 = new short[checked(@as.GetUpperBound(0) + 1)];
								string A_99 = string.Empty;
								if (flag6)
								{
									if (!Directory.Exists(f6.a()))
									{
										Directory.CreateDirectory(f6.a());
									}
									A_99 = f6.a();
								}
								e10 = (f6.e)f6.Solve25((short)m3.c, m3.e, m3.f, m3.h, ref m3.d[0], ref m3.i[0], ref array16[0], ref cy[0], ref c5[0], ref cz[0], ref A_28[0], ref a7[0], ref A_25[0], ref array17[0], ref az[0], ref array5[0], ref a4[0], ref A_95[0], ref a1[0], ref a3[0], ref A_96[0], ref m3.l[0], ref m3.k[0], ref m3.j[0], ref A_98[0], ref m3.n.ToArray()[0], ref m3.o.ToArray()[0], ref m3.p[0], ref au[0], ref array18[0], ref array40[0], ref at[0], ref @as[0], ref aw[0], ref array55[0], cu, checked((short)c4), ref A_93[0], ref A_94[0], ref A_97[0], num4, num32, ref array19[0], num33, ref array20[0], ref array21[0], ref array22[0], a_6, ref array23[0], ref array24[0], checked((short)(A_1.ed().gp() + 1)), ref A_99);
							}
							m3 = null;
							if (flag2)
							{
								b10 = new cc.b((float)array23[0], (float)array24[0]);
							}
						}
						if (e10 == f6.e.t)
						{
							string text3 = string.Empty;
							int num188 = c4 - 1;
							for (int num9 = 0; num9 <= num188; num9++)
							{
								hg hg2 = ((num9 != 0) ? A_13.ad()[num9] : A_1);
								int num189 = array17[num9] - 1;
								for (int num190 = 1; num190 <= num189; num190++)
								{
									int num191 = de[num9] + num190;
									double num192 = A_96[num191 * 9 + 6];
									if (av[num191] && au[num191] > num192)
									{
										string A_44;
										if (c4 > 1)
										{
											A_44 = "NonUniformityErrorMeasID";
											text3 = string.Format(hu.a(ref A_44), num9) + " ";
										}
										A_44 = "NonUniformityErrorInitial";
										string text4 = string.Format(hu.a(ref A_44), num190);
										string text5 = text3;
										A_44 = "NonUniformityErrorMaxConstraint";
										A_15 = text4 + " " + text5 + string.Format(hu.a(ref A_44), hg.bu(1, num192 * 1000000000.0, hg2.ca()), h4.e(hg2.ca(), false, false));
										return this.m2(e10);
									}
								}
							}
						}
						if (e10 != 0)
						{
							return this.m2(e10);
						}
					}
				}
				num13++;
				_ = (float)((double)num13 * 300.1);
				if (A_14 != null)
				{
					cb cb2;
					he A_100 = (cb2 = A_14).k();
					A_13.s(ref A_100);
					cb2.g(A_100);
					A_14.m();
				}
				int num193 = num;
				float num222 = default(float);
				int num234 = default(int);
				int A_101 = default(int);
				int A_102 = default(int);
				short num244 = default(short);
				int num245 = default(int);
				int A_107 = default(int);
				float num283 = default(float);
				for (int num9 = 0; num9 <= num193; num9++)
				{
					int num25 = array17[num9];
					num26 = num25 - 1;
					num27 = num25 - 2;
					double[] array56 = new double[num26 + 1];
					double[] array57 = new double[num26 + 1];
					double[] array58 = new double[num26 + 1];
					double[] array59 = new double[num26 + 1];
					double[] array60 = new double[num26 + 1];
					double[] array61 = new double[num26 + 1];
					b6 = new double[num26 + 1];
					b7 = new double[num26 + 1];
					b8 = new double[num26 + 1];
					b9 = new double[num26 + 1];
					ca = new string[num26 + 1];
					cc.b a_49 = null;
					Collection<ch> collection2 = new Collection<ch>();
					Collection<ga> collection3 = new Collection<ga>();
					Collection<ch> collection4 = new Collection<ch>();
					Collection<ga> collection5 = new Collection<ga>();
					num10 = array16[num9];
					num18 = (short)unchecked(num10 - 1);
					double[] array62 = new double[num18 + 1];
					double[] array63 = ((!dd[num9]) ? new double[num18 + 1] : new double[2 * num10 - 1 + 1]);
					hg hg2;
					if (num9 == 0)
					{
						hg2 = A_1;
						a_49 = b10;
					}
					else
					{
						hg2 = A_13.ad()[num9];
					}
					A_17 = hg2.b3(hg2.c2());
					if (flag3)
					{
						num23 = A_88;
						num24 = A_89;
					}
					else
					{
						num23 = A_3[num9];
						num24 = A_4[num9];
					}
					int num19 = de[num9];
					int num22 = df[num9];
					int num20 = dj[num9];
					int num21 = dk[num9];
					int num194 = dh[num9];
					int num195 = dl[num9];
					int num196 = num26;
					for (int num197 = 0; num197 <= num196; num197++)
					{
						array56[num197] = au[num19 + num197] * 1000000000.0;
						array57[num197] = aw[num19 + num197];
					}
					int num198 = num18;
					for (int num199 = 0; num199 <= num198; num199++)
					{
						array62[num199] = cy[num20 + num199];
						array63[num199] = A_25[num21 + num199];
					}
					if (dd[num9])
					{
						int num200 = num18;
						for (int num201 = 0; num201 <= num200; num201++)
						{
							array63[num201 + num10] = A_25[num21 + num201 + num10];
						}
					}
					hr hr6 = collection[num9];
					if (hr6.cc())
					{
						hr.r(hr6.cd() - num23, hr6.ce() - num23, array62, array63, num10, A_5: true);
					}
					hr6 = null;
					int num202 = num10 * num25 - 1;
					for (num13 = 0; num13 <= num202; num13++)
					{
						a0[num194 + num13] = a1[num194 + num13];
						a2[num194 + num13] = a3[num194 + num13];
					}
					int num203 = num26;
					for (num13 = 0; num13 <= num203; num13++)
					{
						ay[num19 + num13] = az[num19 + num13];
					}
					es2 = collection[num9].cu().p();
					if (es2 != null && (!(es2 is et) || (flag8 && !A_48) || flag9))
					{
						double a_50 = Math.Sin(Math.Atan(this.m2(es2, A_17, A_48, A_16)));
						double a_51 = a0[num194 + unchecked(num10 / 2)];
						double num204 = 1.0;
						int num205 = num27;
						for (num13 = 1; num13 <= num205; num13++)
						{
							double a_52 = a0[num194 + unchecked(num10 / 2) + num10 * num13];
							double num206 = this.m2(a_51, a_52, a_50);
							ay[num19 + num13] = ay[num19 + num13] / num206;
							aq[num19 + num13] = aq[num19 + num13] / num206;
							if (num13 == A_55)
							{
								num204 = num206;
							}
						}
						if (flag9)
						{
							int num207 = ce - 1;
							for (num13 = 0; num13 <= num207; num13++)
							{
								cc[num13] /= num204;
							}
							int num208 = ch - 1;
							for (num13 = 0; num13 <= num208; num13++)
							{
								cg[num13] /= num204;
							}
						}
					}
					int num209 = num26;
					for (num13 = 0; num13 <= num209; num13++)
					{
						b6[num13] = -1.0;
						ca[num13] = "";
						b7[num13] = -1.0;
						b8[num13] = -1.0;
						b9[num13] = -1.0;
					}
					float num210;
					if ((!flag8 && !flag3) || A_48)
					{
						if (flag9)
						{
							num210 = (flag15 ? this.m2(A_64, A_65, A_62, A_63, A_66) : this.m2(A_64, A_65, 0L, A_63, A_66));
						}
						else
						{
							float num211 = 0f;
							float num212 = 0f;
							float num69 = 0f;
							float num213 = 0f;
							float num214 = 0f;
							float num215 = 0f;
							short[] array64;
							int num216;
							short num217;
							float[] array65;
							if (flag26)
							{
								array64 = array;
								num216 = array4[num9];
								num217 = array3[num9];
								array65 = array2;
							}
							else
							{
								array64 = cz;
								num216 = dn[num9];
								num217 = c5[num9];
								array65 = array40;
							}
							short num218 = (short)unchecked(num217 - 1);
							if (array18[num9] == 0)
							{
								int num219 = num218;
								for (num13 = 0; num13 <= num219; num13++)
								{
									num211 += (float)A_28[num21 + array64[num216 + num13]];
									float num72 = (float)(A_28[num21 + array64[num216 + num13]] - array63[array64[num216 + num13]]);
									num69 += num72 * num72;
								}
								float num220 = num211 / (float)num217;
								if (dd[num9])
								{
									int num221 = num218;
									for (num13 = 0; num13 <= num221; num13++)
									{
										num212 += (float)A_28[num21 + num10 + array64[num216 + num13]];
										float num72 = (float)(A_28[num21 + num10 + array64[num216 + num13]] - array63[(short)unchecked(num10 + array64[checked(num216 + num13)])]);
										num213 += num72 * num72;
									}
									num222 = num212 / (float)num217;
								}
								int num223 = num218;
								for (num13 = 0; num13 <= num223; num13++)
								{
									float num72 = (float)(A_28[num21 + array64[num216 + num13]] - (double)num220);
									num214 += num72 * num72;
								}
								if (dd[num9])
								{
									int num224 = num218;
									for (num13 = 0; num13 <= num224; num13++)
									{
										float num72 = (float)(A_28[num21 + array64[num216 + num13] + num10] - (double)num222);
										num215 += num72 * num72;
									}
								}
							}
							else
							{
								float num225 = 0f;
								int num226 = num218;
								for (num13 = 0; num13 <= num226; num13++)
								{
									num211 += (float)((double)array65[num216 + num13] * A_28[num21 + array64[num216 + num13]]);
									float num72 = (float)(A_28[num21 + array64[num216 + num13]] - array63[array64[num216 + num13]]);
									num69 += array65[num216 + num13] * num72 * num72;
									num225 += array65[num216 + num13];
								}
								float num220 = num211 / num225;
								if (dd[num9])
								{
									int num227 = num218;
									for (num13 = 0; num13 <= num227; num13++)
									{
										num212 += (float)((double)array65[num216 + num13] * A_28[num21 + num10 + array64[num216 + num13]]);
										float num72 = (float)(A_28[num21 + num10 + array64[num216 + num13]] - array63[(short)unchecked(num10 + array64[checked(num216 + num13)])]);
										num213 += array65[num216 + num13] * num72 * num72;
									}
									num222 = num212 / num225;
								}
								int num228 = num218;
								for (num13 = 0; num13 <= num228; num13++)
								{
									float num72 = (float)(A_28[num21 + array64[num216 + num13]] - (double)num220);
									num214 += array65[num216 + num13] * num72 * num72;
								}
								if (dd[num9])
								{
									int num229 = num218;
									for (num13 = 0; num13 <= num229; num13++)
									{
										float num72 = (float)(A_28[num21 + array64[num216 + num13] + num10] - (double)num222);
										num215 += array65[num216 + num13] * num72 * num72;
									}
								}
							}
							if (num214 / (float)num218 < 5E-05f)
							{
								num214 = 5E-05f * (float)num218;
							}
							if (dd[num9] && num215 / (float)num218 < 5E-05f)
							{
								num215 = 5E-05f * (float)num218;
							}
							if (num214 == 0f || (dd[num9] && num215 == 0f))
							{
								num210 = 0f;
							}
							else
							{
								num210 = 1f - num69 / num214;
								if (dd[num9])
								{
									num210 = 0.5f * (num210 + 1f - num213 / num215);
								}
							}
						}
						if (num210 < 0f)
						{
							num210 = 0f;
						}
						array9 = new double[num18 + 1];
						int num230 = num18;
						for (num13 = 0; num13 <= num230; num13++)
						{
							array9[num13] = array25[num22 + num23 + num13];
							A_7[num21 + num13] = array63[num13];
						}
						if (dd[num9])
						{
							int num231 = num18;
							for (num13 = 0; num13 <= num231; num13++)
							{
								A_7[num21 + num10 + num13] = array63[num10 + num13];
							}
						}
						if (dd[num9])
						{
							num13 = 0;
							int num232;
							for (num232 = dg[num9]; jf.d(array8[num232 + num13], array25[num22 + num23]); num13++)
							{
							}
							int num233 = num13;
							num13 = ((num9 >= c6 - 1) ? (array8.Length - 1) : (dg[num9 + 1] - 1));
							while (jf.b(array8[num13], array25[num22 + num24]))
							{
								num13--;
							}
							num234 = num13 - dg[num9] - num233;
							A_24 = new double[num234 + 1];
							int num235 = num234;
							for (num13 = 0; num13 <= num235; num13++)
							{
								A_24[num13] = array8[num232 + num233 + num13];
							}
						}
						float num236 = global::b9.m2((float)A_17.f6(), ref A_26, num22 + num23, num22 + num24, ref A_101, ref A_102);
						A_101 -= num22 + num23;
						A_102 -= num22 + num23;
						int num237 = 0;
						int num238 = num26;
						for (int num239 = 0; num239 <= num238; num239++)
						{
							gc gc8 = A_17.eu(num239);
							if (gc8.ah(flag5) || gc8.aj(flag5))
							{
								num237++;
							}
							gc8 = null;
						}
						array13 = new int[num237 - 1 + 1];
						num237 = 0;
						int num240 = num26;
						for (int num241 = 0; num241 <= num240; num241++)
						{
							gc gc3 = A_17.eu(num241);
							if (gc3.ah(flag5) || gc3.aj(flag5))
							{
								double[] array66 = new double[num18 + 1];
								int num242 = num18;
								for (int num243 = 0; num243 <= num242; num243++)
								{
									array66[num243] = ah[num19 + num241, num243 + num23];
								}
								double[] array67 = null;
								short[] array68 = null;
								bool a_53 = false;
								if (gc3.ah(flag5) || gc3.aj(flag5))
								{
									if (af[num19 + num241] != 0)
									{
										a_53 = false;
										num244 = (short)af[num19 + num241];
										num245 = 0;
									}
									else
									{
										a_53 = true;
										num244 = ae[num19 + num241];
										num245 = A_2.j(num244);
										array67 = new double[num245 - 1 + 1];
										array68 = new short[num245 - 1 + 1];
										int num246 = num245 - 1;
										for (int num247 = 0; num247 <= num246; num247++)
										{
											array67[num247] = ab[ad[num19 + num241] + num247];
											array68[num247] = ac[ad[num19 + num241] + num247];
										}
									}
								}
								collection4.Add(new ch(array9, array66, num245, array67, array68, unchecked((hd.a)num244), unchecked((gr.d)ap[checked(num19 + num241)]), aj[num19 + num241], "", "", ak[num19 + num241], al[num19 + num241], am[num19 + num241], a_53));
								if (gc3.ah(flag5))
								{
									a_53 = false;
									b7[num241] = a0[num194 + A_102 + num241 * num10] * (double)(1f - num236) + a0[num194 + A_101 + num241 * num10] * (double)num236;
									array66 = new double[num18 + 1];
									int num248 = num18;
									for (int num249 = 0; num249 <= num248; num249++)
									{
										array66[num249] = a0[num194 + num249 + num10 * num241];
									}
									short num250 = A_21[num195 + num241 * 4 + 1];
									if (cx.l[num19 + num241] != 0)
									{
										num245 = ((num250 != 21) ? A_2.j(num250) : ((int)Math.Round(cx.k[Math.Abs(cx.l[num19 + num241])]) + 1));
										a_53 = true;
										array67 = new double[num245 - 1 + 1];
										array68 = new short[num245 - 1 + 1];
										int num251 = num245 - 1;
										for (int num252 = 0; num252 <= num251; num252++)
										{
											array67[num252] = cx.k[Math.Abs(cx.l[num19 + num241]) + num252];
											array68[num252] = cx.j[Math.Abs(cx.l[num19 + num241]) + num252];
										}
										if (num250 == 10)
										{
											array60[num241] = array67[0] * 100.0;
										}
										if (num250 == 19)
										{
											double[] A_103 = null;
											double[] A_104 = null;
											double[] A_105 = new double[1] { 632.8 };
											double[] A_106 = new double[A_105.Length - 1 + 1];
											double[] A_30 = null;
											jb.a("Si", ref A_103, ref A_104, ref A_30, ref A_107);
											jf.a(ref A_103, ref A_104, A_107, ref A_105, ref A_106, A_106.Length);
											float num253 = (float)A_106[0];
											A_30 = null;
											jb.a("Amorphous Silicon", ref A_103, ref A_104, ref A_30, ref A_107);
											jf.a(ref A_103, ref A_104, A_107, ref A_105, ref A_106, A_106.Length);
											float num254 = (float)A_106[0];
											float num255 = (float)(0.5 * (double)num253 + 0.5 * (double)num254);
											jf.a(ref array9, ref array66, num10, ref A_105, ref A_106, A_106.Length);
											float num256 = (float)A_106[0];
											array61[num241] = (num255 * num255 - num256 * num256) / (num255 * num255 + 2f * num256 * num256) / ((num256 * num256 - 1f) / (1f + 2f * num256 * num256) + (num255 * num255 - num256 * num256) / (num255 * num255 + 2f * num256 * num256));
										}
									}
									else
									{
										num245 = 0;
										array67 = null;
										array68 = null;
										a_53 = false;
									}
									unchecked
									{
										collection2.Add(new ch(array9, array66, num245, array67, array68, (hd.a)num250, (gr.d)ap[checked(num19 + num241)], aj[checked(num19 + num241)] && A_17.go() < 10.0, "", "", "", 0, "", a_53));
									}
								}
								else
								{
									collection2.Add(null);
								}
								double[] array69 = new double[num18 + 1];
								int num257 = num18;
								for (int num258 = 0; num258 <= num257; num258++)
								{
									array69[num258] = an[num19 + num241, num258 + num23];
								}
								collection5.Add(new ga(array9, array69, unchecked((gr.d)ap[checked(num19 + num241)]), ao[num19 + num241]));
								if (gc3.aj(flag5))
								{
									b8[num241] = a2[num194 + A_102 + num241 * num10] * (double)(1f - num236) + a2[num194 + A_101 + num241 * num10] * (double)num236;
									array69 = new double[num18 + 1];
									int num259 = num18;
									for (int num260 = 0; num260 <= num259; num260++)
									{
										array69[num260] = a2[num194 + num260 + num10 * num241];
									}
									collection3.Add(new ga(array9, array69, unchecked((gr.d)ap[checked(num19 + num241)]), ao[num19 + num241] && A_17.go() < 10.0));
								}
								else
								{
									collection3.Add(null);
								}
								array13[num237] = num241;
								num237++;
							}
							if (gc3.an(flag5))
							{
								double num261 = a0[num194 + A_102 + num241 * num10] * (double)(1f - num236) + a0[num194 + A_101 + num241 * num10] * (double)num236;
								double num262 = a2[num194 + A_102 + num241 * num10] * (double)(1f - num236) + a2[num194 + A_101 + num241 * num10] * (double)num236;
								double num263 = (1.0 - array57[num241]) * (num261 * num261 - num262 * num262) + array57[num241];
								double num264 = (1.0 - array57[num241]) * 2.0 * num261 * num262;
								double num265 = Math.Sqrt(num263 * num263 + num264 * num264);
								double num266 = Math.Sqrt(0.5 * (num265 + num263));
								double num267 = Math.Sqrt(0.5 * (num265 - num263));
								num263 = (1.0 + array57[num241]) * (num261 * num261 - num262 * num262) - array57[num241];
								num264 = (1.0 + array57[num241]) * 2.0 * num261 * num262;
								num265 = Math.Sqrt(num263 * num263 + num264 * num264);
								double num268 = Math.Sqrt(0.5 * (num265 + num263));
								double num269 = Math.Sqrt(0.5 * (num265 - num263));
								array58[num241] = num268 - num266;
								array59[num241] = num269 - num267;
							}
						}
					}
					else
					{
						hr hr7 = collection[0];
						if (hr7.cc())
						{
							hr.r(hr7.cd(), hr7.ce(), cy, A_7, num10, A_5: true);
						}
						hr7 = null;
						if (flag3)
						{
							array9 = new double[num24 - num23 + 1];
							A_7 = new double[num24 - num23 + 1];
							array63 = new double[num24 - num23 + 1];
							int num270 = num24 - num23;
							for (num13 = 0; num13 <= num270; num13++)
							{
								array9[num13] = array25[num13 + num23];
								array63[num13] = A_25[num13];
								A_7[num13] = array63[num13];
							}
						}
						else
						{
							array9 = new double[num18 + 1];
							int num271 = num24 - num23;
							for (num13 = 0; num13 <= num271; num13++)
							{
								array9[num13] = array25[num13 + num23];
								array63[num13] = A_7[num13];
							}
						}
						float num211 = 0f;
						float num69 = 0f;
						int num272 = num24 - num23;
						for (num13 = 0; num13 <= num272; num13++)
						{
							num211 = ((!A_47) ? ((float)((double)num211 + array7[num13 + num23])) : ((float)((double)num211 + array7[num13 + num23] - b2[num13 + num23])));
							float num72 = (float)(array7[num13 + num23] - A_7[num13]);
							num69 += num72 * num72;
						}
						float num220 = num211 / (float)(num24 - num23 + 1);
						float num214 = 0f;
						int num273 = num24 - num23;
						for (num13 = 0; num13 <= num273; num13++)
						{
							float num72 = ((!A_47) ? ((float)(array7[num13 + num23] - (double)num220)) : ((float)(array7[num13 + num23] - b2[num13 + num23] - (double)num220)));
							num214 += num72 * num72;
						}
						num210 = ((num214 != 0f) ? (1f - num69 / num214) : 0f);
						if (flag8)
						{
							num210 = ((A_46 > 1f) ? (num210 / A_46) : ((!(A_46 > 0f)) ? 0f : ((float)((double)num210 / ((double)(1f / A_46 - 1f) * 0.5 + 1.0)))));
						}
						if (num210 < 0f)
						{
							num210 = 0f;
						}
					}
					int num274 = hg2.b5(hg2.c2());
					int num275 = num274 + 1;
					for (num13 = 0; num13 <= num275; num13++)
					{
						gc gc3 = hg2.bv(num13, 0);
						b6[num13] = ay[num19 + num13] * 1000000000.0;
						ca[num13] = cb[num19 + num13];
						if (gc3.al(flag5))
						{
							b9[num13] = a4[num19 + num13] * 1000000000.0;
						}
						if (!((num13 > 0) & (num13 <= num274)) || !ag || !gc3.af(a_5))
						{
							continue;
						}
						gb gb2;
						if (A_17.fi())
						{
							gb2 = bf;
						}
						else
						{
							gb2 = gc3.x;
							if (gb2 == null)
							{
								gb2 = A_17.br;
							}
						}
						double num276 = gb2.c - gb2.c * 0.30000001192092896;
						if (num276 < 0.0)
						{
							num276 = 0.0;
						}
						double num277 = gb2.d + gb2.d * 0.30000001192092896;
						if ((b6[num13] < num276) | (b6[num13] > num277))
						{
							A_8 = true;
							return ErrPublic.OutOfCorrelativeRange;
						}
						b6[num13] = b6[num13] * gb2.a + gb2.b;
					}
					if (flag9)
					{
						double[] array70 = new double[ce - 1 + 1];
						int num278 = ce - 1;
						for (int num279 = 0; num279 <= num278; num279++)
						{
							array70[num279] = h4.e(1, cc[num279], A_1.ca());
						}
						a_ = new fy(array70, cd);
						double[] array71 = new double[ch - 1 + 1];
						int num280 = ch - 1;
						for (int num281 = 0; num281 <= num280; num281++)
						{
							array71[num281] = h4.e(1, cg[num281], A_1.ca());
						}
						a_2 = new fy(array71, cf);
					}
					else if (flag3)
					{
						num210 *= (float)num5;
					}
					if (dd[num9])
					{
						array10 = new double[num18 + 1];
						array11 = new double[num18 + 1];
						int num282 = num18;
						for (num13 = 0; num13 <= num282; num13++)
						{
							array10[num13] = array63[num13];
							array11[num13] = array63[num13 + num10];
						}
						array12 = null;
						jf.a(ref array9, ref array11, num10, ref A_24, ref array12, num234 + 1);
						fy2 = new fy(array9, array10);
						fy3 = new fy(A_24, array12);
						fy2.t(fy3);
					}
					else if (!flag3 || flag4)
					{
						fy2 = new fy(array9, array63);
					}
					if (flag)
					{
						string A_44 = "ErrorTitle";
						string text6 = hu.a(ref A_44);
						A_44 = "MeasErrorFFTPeakIdFailure";
						cj = text6 + ": " + hu.a(ref A_44);
					}
					A_6[num9].cf(a_47, num210, A_5[num9], num23, num24, fy2, a_, a_2, cj, (float)ci, A_58 != 0, A_5[num9].b4(), hg2, A_0, collection4, collection5, collection2, array13, collection3, num274, b6, array56, array57, array58, array59, b7, b8, b9, a_49, a_4, array60, array61, ca, A_9, cr, A_5[num9].b6(), A_5[num9].b7(), A_16);
					if (A_14 != null)
					{
						A_14.g(A_6[num9]);
						num283 += num210;
					}
				}
				if (A_14 != null)
				{
					num283 /= (float)c4;
					A_14.g(num283);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_54 = ex2;
				errPublic = ErrPublic.Generic;
				ab8().c(fz.b.b, "Exception caught in MeasureLayers. ", a_54);
				ProjectData.ClearProjectError();
			}
			finally
			{
				cp = false;
			}
			return errPublic;
		}
	}

	protected double m2(int A_0, hg A_1)
	{
		double A_2 = default(double);
		double A_3 = default(double);
		A_1.bu(ref A_2, ref A_3, A_1.c2(), A_0);
		return A_2 * (1.0 + 0.01 * A_3);
	}

	protected int m2(int A_0, int A_1, double A_2, double[,] A_3, int A_4, int A_5, double[] A_6, hg A_7, double[] A_8)
	{
		int num = de[A_0];
		int num2 = df[A_0];
		checked
		{
			double num3 = A_6[num2 + A_4];
			double num4 = A_6[num2 + A_5];
			double num5 = p9(num3, A_8[num2] * 1000000000.0);
			if (be)
			{
				return 1;
			}
			double num6 = 0.0;
			int num7 = A_7.b5(0);
			for (int num8 = 1; num8 <= num7; num8++)
			{
				double num9 = ((num8 != A_1) ? (m2(num8, A_7) * A_3[num + num8, 0]) : A_2);
				if (num9 < num5)
				{
					num6 += num9;
				}
				if (num9 == 0.0 && num8 == A_1)
				{
					num6 = num5;
				}
			}
			long num10 = ((!(Math.Abs(num3) < 1.0)) ? ((long)Math.Round(4.0 * num6 * (1.0 / num3 - 1.0 / num4))) : ((long)Math.Round(4.0 * num6 * (1.0 - 1.0 / num4))));
			if (num10 < 25)
			{
				num10 = 25L;
			}
			int num11 = (int)Math.Round(Conversion.Int((double)(A_5 - A_4) / (double)num10 + 1.0));
			if (num11 < 1)
			{
				num11 = 1;
			}
			return num11;
		}
	}

	protected double m2(int A_0, double[] A_1, int A_2, int A_3, int A_4)
	{
		return m2(0, A_0, A_1, A_2, A_3, A_4);
	}

	protected double m2(int A_0, int A_1, double[] A_2, int A_3, int A_4, int A_5)
	{
		int num = df[A_0];
		checked
		{
			int num2 = (int)Math.Round(0.5 * (double)(A_4 + A_5));
			double num3;
			double num4;
			if (num2 + A_1 > A_3 - 1)
			{
				num3 = A_2[num + A_3 - 1 - A_1];
				num4 = A_2[num + A_3 - 1];
			}
			else
			{
				num3 = A_2[num + num2];
				num4 = A_2[num + num2 + A_1];
			}
			double num5 = 1.0 / num3;
			double num6 = 1.0 / num4;
			return num5 - num6;
		}
	}

	protected void m2(short[] A_0, float[] A_1, short A_2, short[] A_3, ref float[] A_4, short A_5)
	{
		checked
		{
			float[] A_6 = new float[A_2 - 1 + 1];
			float[] A_7 = new float[A_5 - 1 + 1];
			A_4 = new float[A_5 - 1 + 1];
			int num = A_2 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				A_6[num2] = A_0[num2];
			}
			int num3 = A_5 - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				A_7[num4] = A_3[num4];
			}
			jf.a(ref A_6, ref A_1, A_2, ref A_7, ref A_4, A_5);
		}
	}

	protected float[] m2(short[] A_0, int A_1)
	{
		checked
		{
			float[] array = new float[A_1 - 1 + 1];
			array[0] = (short)unchecked(A_0[1] - A_0[0]);
			int num = A_1 - 2;
			for (int num2 = 1; num2 <= num; num2++)
			{
				array[num2] = Convert.ToSingle((double)(short)unchecked(A_0[checked(num2 + 1)] - A_0[checked(num2 - 1)]) / 2.0);
			}
			array[A_1 - 1] = (short)unchecked(A_0[checked(A_1 - 1)] - A_0[checked(A_1 - 2)]);
			return array;
		}
	}

	protected void m2(ref short[] A_0, ref short A_1, int A_2, int A_3, ref short A_4, ref float[] A_5)
	{
		checked
		{
			short num = (short)A_2;
			A_1 = (short)unchecked(checked((short)unchecked(checked((short)A_3) - num)) + 1);
			A_0 = new short[A_1 - 1 + 1];
			A_5 = new float[A_1 - 1 + 1];
			short num2 = (short)unchecked(A_1 - 1);
			for (short num3 = 0; num3 <= num2; num3 = (short)unchecked(num3 + 1))
			{
				A_5[num3] = 1f;
				A_0[num3] = num3;
			}
			A_4 = 0;
		}
	}

	protected void m2(int A_0, int A_1, ref short[] A_2, ref short A_3, double[] A_4, int A_5, int A_6, int A_7, bool A_8, int A_9, int A_10, double[] A_11, ref short A_12, ref float[] A_13, bool A_14, bool A_15)
	{
		float[] A_16 = null;
		bool flag = true;
		int num = df[A_0];
		checked
		{
			int num2 = num + A_6;
			short[] array = new short[A_2.GetUpperBound(0) + 1];
			double num3 = m2(A_0, A_1, A_4, A_5, A_6, A_7);
			array[0] = 0;
			int num4 = A_6;
			short num5 = 1;
			do
			{
				bool flag2 = false;
				double num6 = A_4[num2 + array[num5 - 1]];
				double num7 = ((!(num6 > 0.0)) ? 1.0 : (1.0 / num6));
				do
				{
					num4++;
					if (num4 <= A_5 - 1)
					{
						num6 = A_4[num + num4];
						if (num6 > 0.0 && num7 - 1.0 / num6 >= num3 && (!A_8 || num4 < A_9 || num4 > A_10))
						{
							array[num5] = (short)(num4 - A_6);
							flag2 = true;
							num5 = (short)unchecked(num5 + 1);
						}
					}
				}
				while (num4 < A_7 && !flag2);
			}
			while (num4 < A_7);
			if (A_15 && array[num5 - 1] != A_7 && (!A_8 || A_7 < A_9 || A_7 > A_10))
			{
				double num8 = (double)(A_7 - A_6) / (double)array[num5 - 1] - 1.0;
				int num9 = num5 - 1;
				for (int num10 = 1; num10 <= num9; num10++)
				{
					ref short reference = ref array[num10];
					reference = (short)unchecked(reference + checked((short)Math.Round((double)array[num10] * num8)));
				}
			}
			if (A_11 != null)
			{
				A_2[0] = 0;
				int num11 = 0;
				num4 = A_6;
				A_3 = 1;
				do
				{
					bool flag2 = false;
					double num7 = ((!(A_4[num2 + A_2[A_3 - 1]] > 0.0)) ? 1.0 : (1.0 / A_4[num2 + A_2[A_3 - 1]]));
					do
					{
						num4++;
						if (num4 <= A_5 - 1 && A_4[num4] > 0.0)
						{
							double num12 = ((A_11[num4] >= 75.0) ? num3 : ((!(A_11[num4] > 20.0)) ? 0.0 : (num3 * (A_11[num4] - 20.0) / 55.0)));
							if (num7 - 1.0 / A_4[num + num4] >= num12 && (!A_8 || num4 < A_9 || num4 > A_10) && (!A_14 || num4 > num11 + 1))
							{
								num11 = num4;
								A_2[A_3] = (short)(num11 - A_6);
								flag2 = true;
								A_3 = (short)unchecked(A_3 + 1);
							}
						}
					}
					while ((num4 < A_7) & !flag2);
				}
				while (num4 < A_7);
				if (A_15 && array[num5 - 1] != A_7 && (!A_8 || A_7 < A_9 || A_7 > A_10))
				{
					double num13 = (double)(A_7 - A_6) / (double)(short)unchecked(array[checked(num5 - 1)] - array[0]) - 1.0;
					int num14 = num5 - 1;
					for (int num15 = 1; num15 <= num14; num15++)
					{
						ref short reference2 = ref array[num15];
						reference2 = (short)unchecked(reference2 + checked((short)Math.Round((double)array[num15] * num13)));
					}
				}
				if (A_15 && A_2[A_3 - 1] != A_7 && (!A_8 || A_7 < A_9 || A_7 > A_10))
				{
					double num16 = (double)(A_7 - A_6) / (double)A_2[A_3 - 1] - 1.0;
					int num17 = A_3 - 1;
					for (int num18 = 1; num18 <= num17; num18++)
					{
						ref short reference3 = ref A_2[num18];
						reference3 = (short)unchecked(reference3 + checked((short)Math.Round((double)A_2[num18] * num16)));
					}
				}
				float[] a_ = m2(array, num5);
				float[] array2 = m2(A_2, A_3);
				m2(array, a_, num5, A_2, ref A_16, A_3);
				A_13 = new float[A_3 - 1 + 1];
				int num19 = A_3 - 1;
				for (num4 = 0; num4 <= num19; num4++)
				{
					if (A_11[A_2[num4]] >= 75.0)
					{
						A_13[num4] = 1f;
						continue;
					}
					flag = false;
					A_13[num4] = array2[num4] / A_16[num4];
					if ((double)A_13[num4] > 1.0)
					{
						A_13[num4] = 1f;
					}
				}
			}
			else
			{
				A_2 = array;
				A_3 = num5;
				A_13 = new float[A_3 - 1 + 1];
				int num20 = A_3 - 1;
				for (num4 = 0; num4 <= num20; num4++)
				{
					A_13[num4] = 1f;
				}
			}
			A_2 = (short[])Utils.CopyArray(A_2, new short[A_3 - 1 + 1]);
			if (flag)
			{
				A_12 = 0;
			}
			else
			{
				A_12 = 1;
			}
		}
	}

	protected void m2(hd A_0, hg A_1, m A_2, gc A_3, int A_4, eo.a A_5, ref int A_6)
	{
		int num = (int)A_3.ag(A_0, A_1.dh(), A_5);
		int num2 = ((num != 21) ? A_0.j(num) : ai[A_4].b.Length);
		checked
		{
			if (ae[A_4] == num)
			{
				A_2.l[A_4] = (short)A_6;
				int num3 = num2 - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					A_2.j[A_6 + num4] = ac[ad[A_4] + num4];
					A_2.k[A_6 + num4] = ab[ad[A_4] + num4];
				}
			}
			else
			{
				A_2.l[A_4] = (short)unchecked(-checked((short)A_6));
				int num5 = num2 - 1;
				for (int num4 = 0; num4 <= num5; num4++)
				{
					A_2.j[A_6 + num4] = 1;
				}
			}
			A_6 += num2;
		}
	}

	protected void m2(int A_0, jc A_1, int A_2, int A_3, o A_4, ref int A_5)
	{
		if (A_1 == null || A_1.k)
		{
			return;
		}
		checked
		{
			int num = A_2 - 1;
			int num2 = A_1.b.Length - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				int num4 = db + di[A_0] + A_2 * A_5;
				double[] array = A_1.d[num3];
				if (A_4 == o.a)
				{
					int num5 = num;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						a0[num4 + num6] = array[A_3 + num6];
						a2[num4 + num6] = 0.0;
					}
				}
				else
				{
					double[] array2 = A_1.e[num3];
					int num7 = num;
					for (int num6 = 0; num6 <= num7; num6++)
					{
						a0[num4 + num6] = array[A_3 + num6];
						a2[num4 + num6] = array2[A_3 + num6];
					}
				}
				A_5++;
			}
		}
	}

	protected ErrPublic m2(int A_0, ref m A_1, double[,] A_2, double[,] A_3, short A_4, short A_5, hg A_6, hd A_7, double[] A_8, double[] A_9, double[] A_10, double[] A_11, short[] A_12, double[] A_13, hr A_14, bool A_15, es A_16, bool A_17, bool A_18, bool A_19, double[] A_20, eo.a A_21)
	{
		ErrPublic result = ErrPublic.None;
		checked
		{
			int num = df[A_0] + A_4;
			bool flag = A_6.bu(A_21, A_17);
			bool a_ = A_6.dh().ax(A_21);
			eo.b a_2 = A_6.dh().at(A_21, A_17);
			try
			{
				hi hi2 = A_6.ed();
				if (A_0 == 0)
				{
					A_1 = new m(c4, c7);
					if (A_17)
					{
						A_1.c = h.b;
					}
					else
					{
						A_1.c = h.a;
					}
					A_1.e = (short)Math.Round(hi2.go());
					A_1.f = (float)hi2.gs();
					A_1.h = 0.001f;
				}
				A_1.a = A_4;
				A_1.b = A_5;
				if (A_19)
				{
					A_1.d[A_0] = 2;
				}
				else if (hr.t(A_14.cj()))
				{
					A_1.d[A_0] = 1;
				}
				else if (hr.r(A_14.cj()))
				{
					A_1.d[A_0] = 0;
				}
				else
				{
					A_1.d[A_0] = 1;
				}
				A_1.g = A_14.cu().m();
				switch (A_14.cu().n())
				{
				case hl.a:
					A_1.i[A_0] = 0;
					break;
				case hl.b:
					A_1.i[A_0] = 1;
					break;
				case hl.c:
					A_1.i[A_0] = 2;
					break;
				default:
					A_1.i[A_0] = 1;
					break;
				}
				int num2 = hi2.g7() + 2;
				int num3 = (short)unchecked(A_5 - A_4) + 1;
				int num4 = num3 - 1;
				int num5 = dj[A_0];
				int num6 = dk[A_0];
				int num7 = (short)unchecked(A_5 - A_4);
				for (int num8 = 0; num8 <= num7; num8++)
				{
					A_10[num5 + num8] = (float)(A_8[num + num8] * 1E-09);
					A_11[num6 + num8] = (float)A_9[num8 + A_4];
					a7[num5 + num8] = a6[num + num8];
				}
				if (A_19)
				{
					int num9 = (short)unchecked(A_5 - A_4);
					for (int num8 = 0; num8 <= num9; num8++)
					{
						A_11[num6 + num8 + num3] = (float)A_20[num8 + A_4];
					}
				}
				int num10 = de[A_0];
				int num11 = num10 * 4;
				dl[A_0] = num11;
				int num12 = num10 * 6;
				dm[A_0] = num12;
				A_1.m = 0;
				int num13 = num2 * 4 - 1;
				for (int num8 = 0; num8 <= num13; num8++)
				{
					A_12[num11 + num8] = 0;
				}
				int num14 = num2 * 6 - 1;
				for (int num8 = 0; num8 <= num14; num8++)
				{
					A_13[num12 + num8] = 0.0;
				}
				if (flag && hi2.gv() && !A_15)
				{
					A_12[num11 + 0] = 1;
					A_13[num12 + 0] = 0.0;
					A_13[num12 + 1] = 0.5;
				}
				if ((flag && hi2.gu()) || A_15)
				{
					A_12[num11 + 0] = 1;
					A_13[num12 + 0] = 2.0;
					A_13[num12 + 1] = 0.3;
				}
				int A_22 = 0;
				gc gc2 = hi2.eu(0);
				ay[num10] = 3.8;
				int A_23 = 1;
				if (gc2.ah(a_))
				{
					A_12[num11 + 1] = (short)gc2.ag(A_7, A_6.dh(), A_21);
					if (A_12[num11 + 1] == 0)
					{
						A_12[num11 + 1] = 1;
					}
					if (hi2.gu())
					{
						A_13[num12 + 1] = 0.0;
					}
					m2(A_7, A_6, A_1, gc2, num10, A_21, ref A_23);
					m2(A_0, ai[num10], num3, A_4, o.a, ref A_22);
				}
				int num15 = dh[A_0];
				int num16 = num4;
				for (int num8 = 0; num8 <= num16; num8++)
				{
					a0[num15 + num8] = A_2[num10, A_4 + num8];
					a2[num15 + num8] = 0.0;
				}
				A_13[num12 + 2] = A_2[num10, A_4] - gc2.aw();
				A_13[num12 + 3] = A_2[num10, A_4] + gc2.aw();
				double A_24 = default(double);
				m2(A_0, A_1, A_16, hi2, A_18, A_21, ref A_24);
				double num17 = 0.0;
				int num18 = hi2.g7();
				double a_3 = default(double);
				int num19;
				int num20;
				int num21;
				for (int num8 = 1; num8 <= num18; num8++)
				{
					num19 = num10 + num8;
					num20 = num19 * 4;
					num21 = num19 * 6;
					gc2 = hi2.eu(num8);
					aq[num19] = gc2.ai();
					if (aq[num19] < 100000.0)
					{
						num17 += aq[num19] * A_2[num19, A_4];
					}
					if (gc2.af(a_2) & (aq[num19] == 0.0))
					{
						ay[num19] = 60000.0;
					}
					else
					{
						ay[num19] = aq[num19] * 1E-09;
					}
					a4[num19] = ar[num19] * 1E-09;
					if (gc2.af(a_2))
					{
						A_12[num20 + 0] = 1;
						A_1.m = (short)num8;
					}
					if (gc2.ah(a_))
					{
						A_12[num20 + 1] = (short)gc2.ag(A_7, A_6.dh(), A_21);
						if (A_12[num20 + 1] == 0)
						{
							A_12[num20 + 1] = 2;
						}
						if (hi2.gu())
						{
							A_13[num12 + 1] = 0.0;
						}
					}
					if (gc2.aj(a_))
					{
						A_12[num20 + 2] = (short)gc2.ag(A_7, A_6.dh(), A_21);
						if (A_12[num20 + 2] == 0)
						{
							A_12[num20 + 2] = 2;
						}
						if (hi2.gu())
						{
							A_13[num12 + 1] = 0.0;
						}
					}
					if (gc2.ah(a_) || gc2.aj(a_))
					{
						m2(A_7, A_6, A_1, gc2, num19, A_21, ref A_23);
						m2(A_0, ai[num19], num3, A_4, o.b, ref A_22);
					}
					if (gc2.al(a_))
					{
						A_12[num20 + 3] = 1;
					}
					int num22 = num4;
					for (int num23 = 0; num23 <= num22; num23++)
					{
						a0[num15 + num23 + num3 * num8] = A_2[num19, A_4 + num23];
						a2[num15 + num23 + num3 * num8] = A_3[num19, A_4 + num23];
						if (jf.a(A_3[num19, A_4 + num23], 0.0))
						{
							@do[A_0] = true;
						}
					}
					if (gc2.af(a_2) & (aq[num19] == 0.0))
					{
						A_13[num21 + 0] = 0.0;
						A_13[num21 + 1] = 0.00012;
					}
					else
					{
						A_13[num21 + 0] = aq[num19] * (1.0 - 0.01 * gc2.av()) * 1E-09;
						if (A_13[num21 + 0] < 0.0)
						{
							A_13[num21 + 0] = 0.0;
						}
						A_13[num21 + 1] = aq[num19] * (1.0 + 0.01 * gc2.av()) * 1E-09 + 1E-12;
					}
					A_13[num21 + 2] = A_2[num19, A_4] - gc2.aw();
					A_13[num21 + 3] = A_2[num19, A_4] + gc2.aw();
					A_13[num21 + 4] = A_3[num19, A_4] - gc2.ax();
					A_13[num21 + 5] = A_3[num19, A_4] + gc2.ax();
					if (A_16 != null && (!(A_16 is et) || (hi2.d6(A_21) && hi2.d8(A_21) && !A_18)))
					{
						if (num8 == 1)
						{
							a_3 = a0[num15 + unchecked(num3 / 2)];
						}
						double a_4 = a0[num15 + unchecked(num3 / 2) + num3 * num8];
						double num24 = m2(a_3, a_4, A_24);
						ay[num19] *= num24;
						aq[num19] *= num24;
						A_13[num21 + 0] = A_13[num21 + 0] * num24;
						A_13[num21 + 1] = A_13[num21 + 1] * num24;
					}
				}
				if (num17 < 100.0)
				{
					A_13[num12 + 1] = 0.0;
				}
				int num25 = hi2.g7() + 1;
				gc2 = hi2.eu(num25);
				num19 = num10 + num25;
				num20 = num19 * 4;
				num21 = num19 * 6;
				ay[num19] = 17.0;
				a4[num19] = ar[num19] * 1E-09;
				if (gc2.ah(a_))
				{
					A_12[num20 + 1] = (short)gc2.ag(A_7, A_6.dh(), A_21);
					if (A_12[num20 + 1] == 0)
					{
						A_12[num20 + 1] = 1;
					}
					if (hi2.gu())
					{
						A_13[num12 + 1] = 0.0;
					}
				}
				if (gc2.aj(a_))
				{
					A_12[num20 + 2] = (short)gc2.ag(A_7, A_6.dh(), A_21);
					if (A_12[num20 + 2] == 0)
					{
						A_12[num20 + 2] = 1;
					}
					if (hi2.gu())
					{
						A_13[num12 + 1] = 0.0;
					}
				}
				if (gc2.ah(a_) | gc2.aj(a_))
				{
					m2(A_7, A_6, A_1, gc2, num19, A_21, ref A_23);
					m2(A_0, ai[num19], num3, A_4, o.b, ref A_22);
				}
				if (gc2.al(a_))
				{
					A_12[num20 + 3] = 1;
				}
				int num26 = num4;
				for (int num23 = 0; num23 <= num26; num23++)
				{
					a0[num15 + num23 + num3 * num25] = A_2[num19, A_4 + num23];
					a2[num15 + num23 + num3 * num25] = A_3[num19, A_4 + num23];
				}
				A_13[num21 + 2] = A_2[num19, A_4] - gc2.aw();
				A_13[num21 + 3] = A_2[num19, A_4] + gc2.aw();
				A_13[num21 + 4] = A_3[num19, A_4] - gc2.ax();
				A_13[num21 + 5] = A_3[num19, A_4] + gc2.ax();
				int num27 = num15 + num2 * num3 - 1;
				for (int num23 = num15; num23 <= num27; num23++)
				{
					a1[num23] = a0[num23];
					a3[num23] = a2[num23];
				}
				int num28 = db + di[A_0];
				int num29 = db + di[A_0] + A_22 * num3 - 1;
				for (int num23 = num28; num23 <= num29; num23++)
				{
					a1[num23] = a0[num23];
					a3[num23] = a2[num23];
				}
				int num30 = num10 + num2 - 1;
				for (int num8 = num10; num8 <= num30; num8++)
				{
					az[num8] = ay[num8];
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				result = ErrPublic.SolverArgs;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public bool m2(ref int A_0, ref int A_1, int A_2, short A_3, float A_4, float A_5, bool A_6, bool A_7, ref float A_8, ref float A_9, ref float A_10, ref bool A_11, hr A_12, hi A_13, string A_14, hg A_15, hd A_16, hc A_17, int A_18, int A_19, r.c A_20, double[] A_21)
	{
		double[] array = new double[1];
		_ = new double[1];
		double[] A_22 = new double[0];
		bool flag = true;
		et et2 = (et)A_12.cu().p();
		StreamWriter streamWriter = null;
		if (flag)
		{
			string text = i3.g();
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string text2 = text + "\\ObjCal\\";
			if (!Directory.Exists(text2))
			{
				Directory.CreateDirectory(text2);
			}
			streamWriter = ((!A_7) ? new StreamWriter(text2 + "ObjectiveNACalibration_Iter" + Conversions.ToString(A_2) + ".log") : new StreamWriter(text2 + "ObjectiveNARobustCalibration_Iter" + Conversions.ToString(A_2) + ".log"));
			streamWriter.WriteLine("NA Value, Curvature Value, Thickness Error (A), GOF, Max Curvature Value");
		}
		float num = 0.99f;
		float num2 = et2.t() * 2f;
		if (num2 >= 0.99f)
		{
			num2 = 0.99f;
		}
		if (num2 < 0.02f)
		{
			num2 = 0.02f;
		}
		checked
		{
			A_1 = (short)Math.Round((double)(10f * (num / num2)) * (1.0 + (double)A_2 / (double)(A_3 - 1)));
			double[] array2 = new double[A_1 - 1 + 1];
			double[] array3 = new double[A_1 - 1 + 1];
			double[] array4 = new double[A_1 - 1 + 1];
			eo.a a10 = eo.at();
			float a_ = m2((es)et2, A_13, false, a10);
			float a_2 = m2((es)et2);
			float num3 = num / (float)(A_1 - 1);
			try
			{
				int num4 = A_1 - 1;
				float num5;
				bool A_23;
				string A_24;
				for (A_0 = 0; A_0 <= num4; A_0++)
				{
					Application.DoEvents();
					if (A_20.a)
					{
						A_11 = true;
						if (A_7)
						{
							et2.v(a_);
						}
						else
						{
							et2.u(a_);
						}
						et2.w(a_2);
						return true;
					}
					if (A_0 < 1)
					{
						array2[A_0] = 0.01;
					}
					else
					{
						array2[A_0] = m2((es)et2, A_13, false, a10) + num3;
						_ = array2[A_0];
						_ = (double)num;
						if (array2[A_0] > (double)num)
						{
							array2[A_0] = num;
						}
					}
					if (A_7)
					{
						et2.v((float)array2[A_0]);
					}
					else
					{
						et2.u((float)array2[A_0]);
					}
					num5 = m2(m2((es)et2, A_13, false, a10));
					if (m2((es)et2) > num5)
					{
						et2.w(num5);
					}
					A_23 = false;
					A_24 = string.Empty;
					if (m2(A_14, A_15, A_16, A_18, A_19, A_12, A_17, ref A_22, ref A_23, A_9: false, A_10: false, A_21, ref A_24, a10) != ErrPublic.None)
					{
						throw new Exception("Error in Calibrate NA call to MeasureLayers!");
					}
					array4[A_0] = b6[1] - (double)et2.z();
					array3[A_0] = A_17.c2();
					if (flag)
					{
						streamWriter.WriteLine(array2[A_0] + ", " + et2.w() + ", " + array4[A_0] + ", " + array3[A_0] + ", " + num5);
					}
					if (Math.Abs(array4[A_0]) < (double)A_8)
					{
						A_8 = (float)Math.Abs(array4[A_0]);
						A_9 = m2((es)et2, A_13, false, a10);
						A_10 = m2((es)et2);
					}
					if ((A_2 == 0) & (A_4 == 0f))
					{
						A_20.t(A_4 + (float)((double)A_2 / (double)A_3 * 50.0 + (double)A_0 / (double)(A_1 - 1) / (double)A_3 / 2.0 * 50.0));
					}
					else
					{
						A_20.t(A_4 + (float)((double)A_2 / (double)A_3 * 50.0 + (double)A_0 / (double)(A_1 - 1) / (double)A_3 / 2.0 * 100.0));
					}
				}
				array[0] = 0.0;
				A_9 = m2(array4, array2, array3, A_1);
				num5 = m2(A_9);
				if (A_10 > num5)
				{
					A_10 = num5;
				}
				if (A_7)
				{
					et2.v(A_9);
				}
				else
				{
					et2.u(A_9);
				}
				et2.w(A_10);
				A_23 = false;
				A_24 = string.Empty;
				if (m2(A_14, A_15, A_16, A_18, A_19, A_12, A_17, ref A_22, ref A_23, A_9: false, A_10: false, A_21, ref A_24, a10) != ErrPublic.None)
				{
					throw new Exception("Error in Calibrate NA call to MeasureLayers!");
				}
				A_8 = (float)Math.Abs(b6[1] - (double)et2.z());
				if (flag)
				{
					streamWriter.WriteLine("bestNA = " + Conversions.ToString(A_9) + ", bestCurv = " + Conversions.ToString(A_10) + ", minCurrThicknessError = " + Conversions.ToString(A_8));
				}
			}
			finally
			{
				streamWriter?.Close();
				if (A_7)
				{
					et2.v(a_);
				}
				else
				{
					et2.u(a_);
				}
				et2.w(a_2);
			}
			return A_8 <= A_5;
		}
	}

	protected float m2(double[] A_0, double[] A_1, double[] A_2, int A_3)
	{
		double num = double.MaxValue;
		double num2 = double.MinValue;
		checked
		{
			int num3 = A_3 - 1;
			int num4 = num3;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				if (A_2[num5] > num2)
				{
					num2 = A_2[num5];
				}
			}
			double num6 = num2 / 2.0;
			int num7 = num3;
			int num8 = default(int);
			for (int num5 = 0; num5 <= num7; num5++)
			{
				if (Math.Abs(A_0[num5]) < num && A_2[num5] >= num6)
				{
					num = Math.Abs(A_0[num5]);
					num8 = num5;
				}
				if (num5 < num3 && A_0[num5 + 1] * A_0[num5] < 0.0 && A_2[num5] >= num6 && A_2[num5 + 1] >= num6)
				{
					double num9 = (A_1[num5 + 1] - A_1[num5]) / (A_0[num5 + 1] - A_0[num5]);
					return (float)(A_1[num5] - num9 * A_0[num5]);
				}
			}
			return (float)A_1[num8];
		}
	}

	public bool m2(ref int A_0, ref int A_1, int A_2, short A_3, float A_4, bool A_5, ref float A_6, ref float A_7, ref bool A_8, hr A_9, hi A_10, string A_11, hg A_12, hd A_13, hc A_14, int A_15, int A_16, r.c A_17, double[] A_18)
	{
		double[] A_19 = new double[0];
		bool flag = true;
		et et2 = (et)A_9.cu().p();
		StreamWriter streamWriter = null;
		if (flag)
		{
			string text = i3.g();
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string text2 = text + "\\ObjCal\\";
			if (!Directory.Exists(text2))
			{
				Directory.CreateDirectory(text2);
			}
			streamWriter = new StreamWriter(text2 + "ObjectiveCurvCalibration_Iter" + Conversions.ToString(A_2) + ".log");
			streamWriter.WriteLine("NA Value, Curvature Value, Thickness Error (A), GOF");
		}
		float[] array = new float[10];
		eo.a a10 = eo.at();
		float a_ = m2((es)et2);
		float num = m2((es)et2, A_10, false, a10);
		et2.w(0f);
		float num2 = m2(num);
		short num3 = 0;
		float num4 = num2 / 9f;
		float num5 = 0f;
		checked
		{
			try
			{
				num3 = 0;
				do
				{
					Application.DoEvents();
					if (A_17.a)
					{
						A_8 = true;
						et2.w(a_);
						return true;
					}
					bool A_20 = false;
					string A_21 = string.Empty;
					if (m2(A_11, A_12, A_13, A_15, A_16, A_9, A_14, ref A_19, ref A_20, A_9: false, A_10: false, A_18, ref A_21, a10) != ErrPublic.None)
					{
						throw new Exception("Error in Calibrate NA call to MeasureLayers!");
					}
					float value = (float)(b6[1] - (double)et2.z());
					array[num3] = A_14.c2();
					if (flag)
					{
						streamWriter.WriteLine(num + ", " + et2.w() + ", " + value + ", " + array[num3]);
					}
					if (array[num3] > num5)
					{
						num5 = array[num3];
						A_7 = m2((es)et2);
						A_6 = Math.Abs(value);
					}
					et2.w(et2.w() + num4);
					if (et2.w() > num2)
					{
						et2.w(num2);
					}
					A_17.t(A_4 + (float)(((double)A_2 / (double)A_3 + (double)(A_0 - 1) / (double)(A_1 - 1) / (double)A_3 / 2.0 + (double)num3 / 9.0 / (double)A_3 / 2.0) * 50.0));
					num3 = (short)unchecked(num3 + 1);
				}
				while (num3 <= 9);
				double[] array2 = new double[3];
				double[] array3 = new double[3];
				double[] array4 = new double[3];
				num3 = 0;
				do
				{
					if ((double)array[num3] > array2[2])
					{
						array2[2] = array[num3];
						array3[2] = num3;
						if ((double)array[num3] > array2[1])
						{
							array2[2] = array2[1];
							array3[2] = array3[1];
							array2[1] = array[num3];
							array3[1] = num3;
							if ((double)array[num3] > array2[0])
							{
								array2[1] = array2[0];
								array3[1] = array3[0];
								array2[0] = array[num3];
								array3[0] = num3;
							}
						}
					}
					num3 = (short)unchecked(num3 + 1);
				}
				while (num3 <= 9);
				if (array3[1] < array3[0])
				{
					m2(array3, array2, 1, 0);
				}
				if (array3[2] < array3[1])
				{
					m2(array3, array2, 2, 1);
				}
				if (array3[1] < array3[0])
				{
					m2(array3, array2, 1, 0);
				}
				if (jf.a(array3, array2, 3, (short)2, array4) == 0 && array4[2] < 0.0)
				{
					double num6 = (0.0 - array4[1]) / (2.0 * array4[2]);
					if (num6 < array3[0])
					{
						num6 = array3[0];
					}
					else if (num6 > array3[2])
					{
						num6 = array3[2];
					}
					A_7 = (float)(num6 * (double)num4);
					et2.w(A_7);
					bool A_20 = false;
					string A_21 = string.Empty;
					if (m2(A_11, A_12, A_13, A_15, A_16, A_9, A_14, ref A_19, ref A_20, A_9: false, A_10: false, A_18, ref A_21, a10) != ErrPublic.None)
					{
						throw new Exception("Error in Calibrate NA call to MeasureLayers!");
					}
					float value = (float)(b6[1] - (double)et2.z());
					num5 = A_14.c2();
					A_6 = Math.Abs(value);
				}
				if (flag)
				{
					streamWriter.WriteLine("NA = " + Conversions.ToString(num) + ", bestCurv = " + Conversions.ToString(A_7) + ", minCurrThicknessError = " + Conversions.ToString(A_6));
				}
			}
			finally
			{
				streamWriter?.Close();
				et2.w(a_);
			}
			return true;
		}
	}

	protected void m2(double[] A_0, double[] A_1, int A_2, int A_3)
	{
		double num = A_0[A_3];
		double num2 = A_1[A_3];
		A_0[A_3] = A_0[A_2];
		A_1[A_3] = A_1[A_2];
		A_0[A_2] = num;
		A_1[A_2] = num2;
	}

	protected float m2(float A_0)
	{
		float num;
		if (A_0 == 0f)
		{
			num = 0f;
		}
		else
		{
			num = 10000f;
			double num2 = jf.c(A_0) * 180.0 / Math.PI / (double)qh();
			int num3 = qh();
			for (int num4 = 1; num4 <= num3; num4 = checked(num4 + 1))
			{
				float num5 = (float)(((double)num4 - 0.5) * num2);
				float num6 = (float)(1.0 / ((double)num5 * Math.PI / 180.0 * (double)num5 * Math.PI / 180.0));
				if (num6 < num)
				{
					num = num6;
				}
			}
		}
		return num;
	}

	protected void m2(int A_0, m A_1, es A_2, hi A_3, bool A_4, eo.a A_5, ref double A_6)
	{
		int num = qh();
		checked
		{
			int num2 = num - 1;
			float[] array;
			float[] array2;
			if (A_2 != null && A_2 is et && (!A_3.d6(A_5) || !A_3.d8(A_5) || A_4))
			{
				double num3 = jf.c(m2(A_2, A_3, A_4, A_5)) * 180.0 / Math.PI;
				if (jf.b(num3, 0.0))
				{
					array = new float[num2 + 1];
					array2 = new float[num2 + 1];
					A_1.p[A_0] = (short)num;
					double num4 = num3 / (double)num;
					int num5 = num;
					double num10 = default(double);
					for (int num6 = 1; num6 <= num5; num6++)
					{
						array2[num6 - 1] = (float)(((double)num6 - 0.5) * num4);
						double num7 = (double)num6 * num4 * ((double)num6 * num4);
						double num8 = (double)(num6 - 1) * num4 * ((double)(num6 - 1) * num4);
						double num9 = 1.0 - (double)(m2(A_2) * array2[num6 - 1]) * Math.PI / 180.0 * (double)array2[num6 - 1] * Math.PI / 180.0;
						array[num6 - 1] = (float)((num7 - num8) * num9);
						num10 += (double)array[num6 - 1];
					}
					int num11 = num;
					for (int num6 = 1; num6 <= num11; num6++)
					{
						array[num6 - 1] = array[num6 - 1] / (float)num10;
					}
					A_1.i[A_0] = 2;
				}
				else
				{
					array = new float[1] { 1f };
					array2 = new float[1] { (float)A_1.g };
					A_1.p[A_0] = 1;
					if (A_2 != null)
					{
						A_6 = Math.Sin(Math.Atan(m2(A_2, A_3, A_4, A_5)));
					}
				}
			}
			else
			{
				array = new float[1] { 1f };
				array2 = new float[1] { (float)A_1.g };
				A_1.p[A_0] = 1;
				if (A_2 != null)
				{
					A_6 = Math.Sin(Math.Atan(m2(A_2, A_3, A_4, A_5)));
				}
			}
			A_1.n.AddRange(array2);
			A_1.o.AddRange(array);
		}
	}

	protected float m2(es A_0, hi A_1, bool A_2, eo.a A_3)
	{
		if (A_0 is et)
		{
			return m2((et)A_0, A_1, A_2, A_3);
		}
		return 0f;
	}

	protected float m2(es A_0)
	{
		if (A_0 is et)
		{
			return m2((et)A_0);
		}
		return 0f;
	}

	protected int qh()
	{
		return sj();
	}

	protected float m2(et A_0, hi A_1, bool A_2, eo.a A_3)
	{
		if (A_0 != null)
		{
			if (A_0.aa())
			{
				return A_0.t();
			}
			if (A_1.d5(A_3) && !A_2)
			{
				return A_0.v();
			}
			return A_0.u();
		}
		return 0.001f;
	}

	protected float m2(et A_0)
	{
		if (A_0 != null)
		{
			if (A_0.aa())
			{
				return 0f;
			}
			return A_0.w();
		}
		return 0f;
	}

	protected int sj()
	{
		return 5;
	}

	public double m2(double A_0, double A_1, double A_2)
	{
		return Math.Cos(0.707 * jf.c(A_0 * A_2 / A_1));
	}

	protected void qh(int A_0)
	{
		checked
		{
			ah = new double[102, A_0 + 1];
			aj = new bool[102];
			ak = new string[102];
			al = new int[102];
			am = new string[102];
			an = new double[102, A_0 + 1];
			ao = new bool[102];
			a0 = new double[A_0 * 102 + 1];
			a1 = new double[A_0 * 102 + 1];
			a2 = new double[A_0 * 102 + 1];
			a3 = new double[A_0 * 102 + 1];
			bg = new double[100, A_0 + 1];
			bh = new double[100, A_0 + 1];
			bi = new double[100, A_0 + 1];
			bj = new double[100, A_0 + 1];
			bk = new double[A_0 + 1];
			bl = new double[A_0 + 1];
			bm = new double[A_0 + 1];
			bn = new double[A_0 + 1];
			bo = new double[A_0 + 1];
			bp = new double[A_0 + 1];
			bq = new double[A_0 + 1];
			br = new double[A_0 + 1];
			bs = new double[A_0 + 1];
			bt = new double[A_0 + 1];
			bu = new double[A_0 + 1];
			bv = new double[A_0 + 1];
			bw = new double[A_0 + 1];
			bx = new double[A_0 + 1];
			by = new double[A_0 + 1];
			bz = new double[A_0 + 1];
			b0 = new double[A_0 + 1];
			b1 = new double[A_0 + 1];
			b2 = new double[A_0 + 1];
			b3 = new double[A_0 + 1];
			b4 = new double[2 * A_0 + 1];
		}
	}

	protected void m2(double[,] A_0, double[,] A_1, hg A_2, double[] A_3, int A_4)
	{
		int num = A_2.b5(0);
		checked
		{
			int num2 = A_4 - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				bk[num3] = 6.2831852 * A_0[0, num3] / A_3[num3];
				bl[num3] = bk[num3] * bk[num3];
				int num4 = num;
				for (int num5 = 1; num5 <= num4; num5++)
				{
					bg[num5 - 1, num3] = 6.2831852 * A_0[num5, num3] / A_3[num3];
					bh[num5 - 1, num3] = bg[num5 - 1, num3] * bg[num5 - 1, num3];
					bi[num5 - 1, num3] = 6.2831852 * A_1[num5, num3] / A_3[num3];
					bj[num5 - 1, num3] = bi[num5 - 1, num3] * bi[num5 - 1, num3];
				}
				bm[num3] = 6.2831852 * A_0[num + 1, num3] / A_3[num3];
				bn[num3] = bm[num3] * bm[num3];
				bo[num3] = 6.2831852 * A_1[num + 1, num3] / A_3[num3];
				bp[num3] = bo[num3] * bo[num3];
			}
		}
	}

	protected void m2(ref double A_0, ref double A_1, ref double A_2, ref double A_3, ref double A_4, ref double A_5, ref double A_6, ref double A_7, double A_8, ref double A_9, ref double A_10)
	{
		double num = 2.0 * A_10 * A_8;
		num *= num * 0.5;
		double num2 = 2.0 * A_9 * A_8;
		num2 *= num2 * 0.5;
		if (num > 100.0 || num2 > 100.0)
		{
			A_2 = 0.0;
			A_6 = 0.0;
			A_1 = 0.0;
			A_5 = 0.0;
			A_0 = 1.0000000409184788E+35;
			A_4 = 0.0;
			A_3 = 0.0;
			A_7 = 0.0;
			return;
		}
		double num3 = Math.Exp(0.0 - num);
		double num4 = Math.Exp(0.0 - num2);
		num = (A_10 - A_9) * A_8;
		double num5 = Math.Exp(0.5 * num * num);
		double num6 = 1.0 / (A_0 * A_0 + A_4 * A_4);
		num = (A_2 * A_1 * A_0 - A_6 * A_5 * A_0 + A_6 * A_1 * A_4 + A_2 * A_5 * A_4) * num6;
		num2 = num3 * num4 * num5 * num5 - 1.0;
		A_3 = (A_3 + num2 * num) / num5;
		num = (A_6 * A_1 * A_0 + A_2 * A_5 * A_0 - A_2 * A_1 * A_4 + A_6 * A_5 * A_4) * num6;
		A_7 = (A_7 + num2 * num) / num5;
		A_0 *= num5;
		A_4 *= num5;
		num = num3 * num5;
		A_1 *= num;
		A_5 *= num;
		num = num4 * num5;
		A_2 *= num;
		A_6 *= num;
	}

	protected void m2(int A_0, hg A_1, double[] A_2, int A_3, double[] A_4)
	{
		hi hi2 = A_1.b3(A_1.c2());
		checked
		{
			int num = A_1.b5(0) - 1;
			int num2 = A_3 - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				double num4 = 2.0 * bk[num3];
				if (num < 0)
				{
					bq[num3] = (bk[num3] + bm[num3]) / num4;
					br[num3] = (0.0 - bo[num3]) / num4;
				}
				else
				{
					bq[num3] = (bk[num3] + bg[0, num3]) / num4;
					br[num3] = (0.0 - bi[0, num3]) / num4;
				}
				bu[num3] = 1.0 - bq[num3];
				bv[num3] = 0.0 - br[num3];
				bs[num3] = bu[num3];
				bt[num3] = bv[num3];
				bw[num3] = bq[num3];
				bx[num3] = br[num3];
				double num5 = hi2.eu(1).an();
				if (num5 != 0.0)
				{
					m2(ref bq[num3], ref bs[num3], ref bu[num3], ref bw[num3], ref br[num3], ref bt[num3], ref bv[num3], ref bx[num3], num5, ref bk[num3], ref bg[0, num3]);
				}
				for (int num6 = 1; num6 < A_0; num6++)
				{
					double num7 = bg[num6 - 1, num3] * A_4[num6];
					double num8 = Math.Cos(num7);
					double num9 = Math.Sin(num7);
					double num10 = bi[num6 - 1, num3] * A_4[num6];
					double num11 = ((!(num10 > 100.0)) ? Math.Exp(num10) : Math.Exp(100.0));
					double num12 = num8 * num11;
					double num13 = num9 * num11;
					double num14 = num8 / num11;
					double num15 = (0.0 - num9) / num11;
					double num16 = bq[num3] * num12 - br[num3] * num13;
					double num17 = br[num3] * num12 + bq[num3] * num13;
					double num18 = bs[num3] * num14 - bt[num3] * num15;
					double num19 = bt[num3] * num14 + bs[num3] * num15;
					double num20 = bu[num3] * num12 - bv[num3] * num13;
					double num21 = bv[num3] * num12 + bu[num3] * num13;
					double num22 = bw[num3] * num14 - bx[num3] * num15;
					double num23 = bx[num3] * num14 + bw[num3] * num15;
					bq[num3] = num16;
					br[num3] = num17;
					bs[num3] = num18;
					bt[num3] = num19;
					bu[num3] = num20;
					bv[num3] = num21;
					bw[num3] = num22;
					bx[num3] = num23;
					num4 = 2.0 * (bh[num6 - 1, num3] + bj[num6 - 1, num3]);
					double A_5 = (bj[num6 - 1, num3] + bi[num6 - 1, num3] * bi[num6, num3] + bh[num6 - 1, num3] + bg[num6 - 1, num3] * bg[num6, num3]) / num4;
					double A_6 = (bg[num6, num3] * bi[num6 - 1, num3] - bi[num6, num3] * bg[num6 - 1, num3]) / num4;
					double A_7 = 1.0 - A_5;
					double A_8 = 0.0 - A_6;
					double A_9 = A_7;
					double A_10 = A_8;
					double A_11 = A_5;
					double A_12 = A_6;
					num5 = hi2.eu(num6 + 1).an();
					if (num5 != 0.0)
					{
						m2(ref A_5, ref A_9, ref A_7, ref A_11, ref A_6, ref A_10, ref A_8, ref A_12, num5, ref bg[num6 - 1, num3], ref bg[num6, num3]);
					}
					num16 = bq[num3] * A_5 - br[num3] * A_6 + bs[num3] * A_7 - bt[num3] * A_8;
					num17 = br[num3] * A_5 + bq[num3] * A_6 + bt[num3] * A_7 + bs[num3] * A_8;
					num18 = bq[num3] * A_9 - br[num3] * A_10 + bs[num3] * A_11 - bt[num3] * A_12;
					num19 = br[num3] * A_9 + bq[num3] * A_10 + bt[num3] * A_11 + bs[num3] * A_12;
					num20 = bu[num3] * A_5 - bv[num3] * A_6 + bw[num3] * A_7 - bx[num3] * A_8;
					num21 = bv[num3] * A_5 + bu[num3] * A_6 + bx[num3] * A_7 + bw[num3] * A_8;
					num22 = bu[num3] * A_9 - bv[num3] * A_10 + bw[num3] * A_11 - bx[num3] * A_12;
					num23 = bv[num3] * A_9 + bu[num3] * A_10 + bx[num3] * A_11 + bw[num3] * A_12;
					bq[num3] = num16;
					br[num3] = num17;
					bs[num3] = num18;
					bt[num3] = num19;
					bu[num3] = num20;
					bv[num3] = num21;
					bw[num3] = num22;
					bx[num3] = num23;
				}
			}
			hi2 = A_1.b3(A_1.c2());
			int a_ = hi2.g7() + 1;
			int num24 = A_3 - 1;
			for (int num3 = 0; num3 <= num24; num3++)
			{
				if (num < 0)
				{
					by[num3] = 1.0;
					bz[num3] = 0.0;
					b0[num3] = 0.0;
					b1[num3] = 0.0;
				}
				else
				{
					double num4 = 2.0 * (bh[num, num3] + bj[num, num3]);
					by[num3] = (bj[num, num3] + bi[num, num3] * bo[num3] + bh[num, num3] + bg[num, num3] * bm[num3]) / num4;
					bz[num3] = (bm[num3] * bi[num, num3] - bo[num3] * bg[num, num3]) / num4;
					b0[num3] = 1.0 - by[num3];
					b1[num3] = 0.0 - bz[num3];
				}
				double num5 = hi2.eu(a_).an();
				if (num5 != 0.0)
				{
					double A_9 = b0[num3];
					double A_10 = b1[num3];
					double A_11 = by[num3];
					double A_12 = bz[num3];
					double A_13 = ((num >= 0) ? bg[num, num3] : bk[num3]);
					m2(ref by[num3], ref A_9, ref b0[num3], ref A_11, ref bz[num3], ref A_10, ref b1[num3], ref A_12, num5, ref A_13, ref bm[num3]);
				}
				for (int num6 = num; num6 >= A_0; num6--)
				{
					double num7 = bg[num6, num3] * A_4[num6 + 1];
					double num25 = Math.Cos(num7);
					double num9 = Math.Sin(num7);
					double num10 = bi[num6, num3] * A_4[num6 + 1];
					double num11 = ((!(num10 > 100.0)) ? Math.Exp(num10) : Math.Exp(100.0));
					double num12 = num25 * num11;
					double num13 = num9 * num11;
					double num14 = num25 / num11;
					double num15 = (0.0 - num9) / num11;
					double num26 = num12 * by[num3] - num13 * bz[num3];
					double num27 = num12 * bz[num3] + num13 * by[num3];
					double num28 = num14 * b0[num3] - num15 * b1[num3];
					double num29 = num14 * b1[num3] + num15 * b0[num3];
					by[num3] = num26;
					bz[num3] = num27;
					b0[num3] = num28;
					b1[num3] = num29;
					double num4 = 2.0 * (bh[num6 - 1, num3] + bj[num6 - 1, num3]);
					double A_5 = (bj[num6 - 1, num3] + bi[num6 - 1, num3] * bi[num6, num3] + bh[num6 - 1, num3] + bg[num6 - 1, num3] * bg[num6, num3]) / num4;
					double A_6 = (bg[num6, num3] * bi[num6 - 1, num3] - bi[num6, num3] * bg[num6 - 1, num3]) / num4;
					double A_7 = 1.0 - A_5;
					double A_8 = 0.0 - A_6;
					double A_9 = A_7;
					double A_10 = A_8;
					double A_11 = A_5;
					double A_12 = A_6;
					num5 = hi2.eu(num6 + 1).an();
					if (num5 != 0.0)
					{
						m2(ref A_5, ref A_9, ref A_7, ref A_11, ref A_6, ref A_10, ref A_8, ref A_12, num5, ref bg[num6 - 1, num3], ref bg[num6, num3]);
					}
					num26 = A_5 * by[num3] - A_6 * bz[num3] + A_9 * b0[num3] - A_10 * b1[num3];
					num27 = A_5 * bz[num3] + A_6 * by[num3] + A_9 * b1[num3] + A_10 * b0[num3];
					num28 = A_7 * by[num3] - A_8 * bz[num3] + A_11 * b0[num3] - A_12 * b1[num3];
					num29 = A_7 * bz[num3] + A_8 * by[num3] + A_11 * b1[num3] + A_12 * b0[num3];
					by[num3] = num26;
					bz[num3] = num27;
					b0[num3] = num28;
					b1[num3] = num29;
				}
			}
		}
	}

	protected void m2(int A_0, float[] A_1, float[] A_2, double[,] A_3, hg A_4, int A_5, int A_6)
	{
		int num = de[A_0];
		checked
		{
			int num2 = (int)Math.Round(0.5 * (double)(A_6 + A_5));
			hi hi2 = A_4.b3(A_4.c2());
			int num3 = hi2.g7();
			for (int num4 = 1; num4 <= num3; num4++)
			{
				double num5 = hi2.eu(num4).av();
				double num6 = A_3[num4, num2] * aq[num + num4];
				A_1[num4] = (float)(num6 * (1.0 - num5 * 0.01));
				if (A_1[num4] < 0f)
				{
					A_1[num4] = 0f;
				}
				if (num6 == 0.0)
				{
					A_2[num4] = 160000f;
				}
				else
				{
					A_2[num4] = (float)(num6 * (1.0 + num5 * 0.01));
				}
			}
		}
	}

	protected void m2(double[] A_0, double[] A_1, int A_2, int A_3, ref double A_4, ref double A_5, ref double A_6)
	{
		checked
		{
			double num = A_3 - A_2 + 1;
			double num2 = 0.0;
			for (int num3 = A_2; num3 <= A_3; num3++)
			{
				num2 += A_1[num3];
			}
			double num4 = 0.0;
			for (int num3 = A_2; num3 <= A_3; num3++)
			{
				num4 += A_1[num3] * A_1[num3];
			}
			double num5 = num2;
			double num6 = num4;
			double num7 = 0.0;
			for (int num3 = A_2; num3 <= A_3; num3++)
			{
				num7 += A_1[num3] * A_1[num3] * A_1[num3];
			}
			double num8 = num4;
			double num9 = num7;
			double num10 = 0.0;
			for (int num3 = A_2; num3 <= A_3; num3++)
			{
				num10 += A_1[num3] * A_1[num3] * A_1[num3] * A_1[num3];
			}
			double num11 = 0.0;
			for (int num3 = A_2; num3 <= A_3; num3++)
			{
				num11 += A_0[num3];
			}
			double num12 = 0.0;
			for (int num3 = A_2; num3 <= A_3; num3++)
			{
				num12 += A_0[num3] * A_1[num3];
			}
			double num13 = 0.0;
			for (int num3 = A_2; num3 <= A_3; num3++)
			{
				num13 += A_0[num3] * A_1[num3] * A_1[num3];
			}
			double num14 = num / num5;
			num5 *= num14;
			num6 *= num14;
			num7 *= num14;
			num12 *= num14;
			num5 = 0.0;
			num6 -= num2;
			num7 -= num4;
			num12 -= num11;
			num14 = num / num8;
			num8 *= num14;
			num9 *= num14;
			num10 *= num14;
			num13 *= num14;
			num8 = 0.0;
			num9 -= num2;
			num10 -= num4;
			num13 -= num11;
			num14 = num6 / num9;
			num9 *= num14;
			num10 *= num14;
			num13 *= num14;
			num9 = 0.0;
			num10 -= num7;
			num13 -= num12;
			A_6 = num13 / num10;
			A_5 = (num12 - A_6 * num7) / num6;
			A_4 = (num11 - A_6 * num4 - A_5 * num2) / num;
		}
	}

	protected void m2(int A_0, int A_1, int A_2, short A_3, double[] A_4, double[,] A_5, double[,] A_6, double[] A_7, double[] A_8, int A_9, bool A_10, bool A_11, int A_12, double A_13, ref int A_14, ref double A_15, ref double A_16, ref double A_17)
	{
		checked
		{
			short num = (short)(unchecked(checked(A_2 - A_1) / a5) + 1);
			int num2 = A_2 - A_1 + 1;
			short num3 = (short)unchecked(num - 1);
			short[] array = new short[1];
			int num4 = A_3 - 1;
			double[] array2 = new double[1];
			short[] array3 = new short[A_3 * 6 + 1];
			double[] array4 = new double[A_3 * 9 + 1];
			short[] array5 = new short[A_3 + 1];
			double[] array6 = new double[A_3 + 1];
			short[] array7 = new short[A_3 + 1];
			short[] array8 = new short[A_3 + 1];
			float[] array9 = new float[1];
			float[] array10 = new float[1] { 1f };
			int num5 = de[A_0];
			int num6 = dj[A_0];
			short[] array11 = new short[@as.GetUpperBound(0) + 1];
			double[] array12 = new double[c7 * 6 - 1 + 1];
			if (a8 == null || a8.GetUpperBound(0) != num3)
			{
				int num7 = 2 * num - 1;
				a8 = new double[num3 + 1];
				if (A_11)
				{
					a9 = new double[num7 + 1];
					bd = new double[num7 + 1];
				}
				else
				{
					a9 = new double[num3 + 1];
					bd = new double[num3 + 1];
				}
				ba = new double[num3 + 1];
				bb = new double[(short)unchecked(A_3 * num) + 1];
				bc = new double[(short)unchecked(A_3 * num) + 1];
				int num8 = num3;
				for (int num9 = 0; num9 <= num8; num9++)
				{
					int num10 = a5 * num9;
					int num11 = A_1 + num10;
					a8[num9] = A_7[num11] * 1E-09;
					a9[num9] = A_8[num10];
					ba[num9] = a7[num6 + num10];
					int num12 = num4;
					for (int num13 = 0; num13 <= num12; num13++)
					{
						bb[num9 + num13 * num] = A_5[num13, num11];
						bc[num9 + num13 * num] = A_6[num13, num11];
					}
				}
				if (A_11)
				{
					int num14 = num7;
					for (int num15 = num; num15 <= num14; num15++)
					{
						int num10 = num2 + a5 * (num15 - num);
						a9[num15] = A_8[num10];
					}
				}
			}
			short A_18 = unchecked((short)((!A_10) ? ((!A_11) ? 1 : 2) : 0));
			A_4[A_12] = A_13 * 1E-09;
			short A_19 = 1;
			short A_20 = (short)unchecked(num3 + 1);
			ref double a_ = ref a8[0];
			ref short a_2 = ref array[0];
			ref double a_3 = ref a9[0];
			ref double a_4 = ref ba[0];
			ref double a_5 = ref bd[0];
			ref double a_6 = ref A_4[0];
			ref double a_7 = ref array2[0];
			ref double a_8 = ref a4[0];
			ref short a_9 = ref array3[0];
			ref double a_10 = ref bb[0];
			ref double a_11 = ref bc[0];
			ref double a_12 = ref array4[0];
			ref short a_13 = ref array5[0];
			ref double a_14 = ref array6[0];
			ref short a_15 = ref array7[0];
			ref short a_16 = ref array8[0];
			ref float a_17 = ref array9[0];
			ref float a_18 = ref array10[0];
			short A_21 = 1;
			ref double a_19 = ref au[num5];
			short A_22 = 0;
			float A_23 = 0f;
			ref short a_20 = ref at[num5];
			ref short a_21 = ref @as[num5];
			ref float a_22 = ref aw[num5];
			ref short a_23 = ref array11[0];
			long a_24 = cu;
			short A_24 = 0;
			short A_25 = 0;
			ref double a_25 = ref array12[0];
			short A_26 = 0;
			short A_27 = 0;
			double A_28 = 0.0;
			double A_29 = 0.0;
			double A_30 = 0.0;
			double A_31 = 0.0;
			string A_32 = string.Empty;
			short A_33 = default(short);
			ct = unchecked((f6.e)f6.Solve25(1, 0, 0f, 0f, ref A_18, ref A_19, ref A_20, ref a_, ref A_33, ref a_2, ref a_3, ref a_4, ref a_5, ref A_3, ref a_6, ref a_7, ref a_8, ref a_9, ref a_10, ref a_11, ref a_12, ref a_13, ref a_14, ref a_15, ref a_16, ref a_17, ref a_18, ref A_21, ref a_19, ref A_22, ref A_23, ref a_20, ref a_21, ref a_22, ref a_23, a_24, 1, ref A_24, ref A_25, ref a_25, 1, 0, ref A_26, 0, ref A_27, ref A_28, ref A_29, 0f, ref A_30, ref A_31, 0, ref A_32));
			int num16 = a5;
			for (int num17 = A_1; ((num16 >> 31) ^ num17) <= ((num16 >> 31) ^ A_2); num17 += num16)
			{
				b4[num17] = bd[A_14];
				A_15 += b4[num17];
				int num10 = num17 - A_1;
				A_16 += A_8[num10];
				A_17 += Math.Abs(A_8[num10] - b2[num17]);
				A_14++;
			}
			if (A_11)
			{
				int num18 = a5;
				for (int num19 = A_1; ((num18 >> 31) ^ num19) <= ((num18 >> 31) ^ A_2); num19 += num18)
				{
					b4[A_9 + num19] = bd[A_14];
					A_14++;
				}
			}
		}
	}

	private float m2(int A_0, int A_1, double[] A_2, double[] A_3, bool A_4, double A_5, double A_6, int A_7)
	{
		float num = 0f;
		float num2 = 0f;
		int num3 = 0;
		checked
		{
			if (A_4)
			{
				int num4 = a5;
				for (int num5 = A_0; ((num4 >> 31) ^ num5) <= ((num4 >> 31) ^ A_1); num5 += num4)
				{
					int num6 = num5 + A_7;
					float num7 = (float)(A_2[num6] - b2[num6]);
					num += num7;
					float num8 = (float)((double)num7 - (A_3[num5] - b3[num5]) / A_5);
					num2 += num8 * num8;
					num3++;
				}
				if (A_5 > 1.0)
				{
					num2 *= (float)A_5;
				}
			}
			else
			{
				int num9 = a5;
				for (int num5 = A_0; ((num9 >> 31) ^ num5) <= ((num9 >> 31) ^ A_1); num5 += num9)
				{
					float num7 = (float)(A_2[num5 + A_7] + A_6);
					num += num7;
					float num8 = (float)((double)num7 - A_3[num5]);
					num2 += num8 * num8;
					num3++;
				}
			}
			float num10 = num / (float)num3;
			float num11 = 0f;
			if (A_4)
			{
				int num12 = a5;
				for (int num5 = A_0; ((num12 >> 31) ^ num5) <= ((num12 >> 31) ^ A_1); num5 += num12)
				{
					int num6 = num5 + A_7;
					float num8 = (float)(A_2[num6] - b2[num6] - (double)num10);
					num11 += num8 * num8;
				}
			}
			else
			{
				int num13 = a5;
				for (int num5 = A_0; ((num13 >> 31) ^ num5) <= ((num13 >> 31) ^ A_1); num5 += num13)
				{
					float num8 = (float)(A_2[num5 + A_7] + A_6 - (double)num10);
					num11 += num8 * num8;
				}
			}
			if (num11 == 0f)
			{
				return float.MaxValue;
			}
			return num2 / num11;
		}
	}

	private float m2(int A_0, int A_1, double[] A_2, double[] A_3, int A_4, int A_5)
	{
		float num = 0f;
		float num2 = 0f;
		int num3 = 0;
		int num4 = a5;
		checked
		{
			for (int num5 = A_0; ((num4 >> 31) ^ num5) <= ((num4 >> 31) ^ A_1); num5 += num4)
			{
				float num6 = (float)A_2[num5 + A_4];
				num += num6;
				float num7 = (float)((double)num6 - A_3[num5 + A_5]);
				num2 += num7 * num7;
				num3++;
			}
			if (num3 > 0)
			{
				float num8 = num / (float)num3;
				float num9 = 0f;
				int num10 = a5;
				for (int num5 = A_0; ((num10 >> 31) ^ num5) <= ((num10 >> 31) ^ A_1); num5 += num10)
				{
					float num7 = (float)(A_2[num5 + A_4] - (double)num8);
					num9 += num7 * num7;
				}
				return (num9 != 0f) ? (num2 / num9) : float.MaxValue;
			}
			return float.MaxValue;
		}
	}

	private void m2(double A_0, double A_1, int A_2, int A_3, int A_4, double[] A_5, ref double A_6, ref double A_7, ref double A_8)
	{
		double num = A_0 / (double)A_2;
		double num2 = A_1 / (double)A_2;
		double num3 = 0.0;
		double num4 = 0.0;
		checked
		{
			b2 = new double[b2.GetUpperBound(0) + 1];
			b3 = new double[b3.GetUpperBound(0) + 1];
			A_7 = A_1 / (double)A_2;
			A_6 = A_0 / (double)A_2;
			int num5 = a5;
			for (int num6 = A_3; ((num5 >> 31) ^ num6) <= ((num5 >> 31) ^ A_4); num6 += num5)
			{
				num3 += Math.Abs(A_5[num6] - num);
				num4 += Math.Abs(b4[num6] - num2);
				b3[num6] = A_7;
				b2[num6] = A_6;
			}
			if (num3 == 0.0)
			{
				A_8 = 1.0;
			}
			else
			{
				A_8 = num4 / num3;
			}
		}
	}

	protected void m2(int A_0, int A_1, float[] A_2, float[] A_3, int A_4, bool A_5, ref double A_6, ref double A_7, bool A_8, ref bool A_9, ref double A_10, ref double A_11, double[] A_12, double[,] A_13, double[,] A_14, ref bool A_15, double[] A_16, double[] A_17, double[] A_18, int A_19, double[] A_20, hr.b A_21, bool A_22, int A_23, int A_24, hg A_25, double[] A_26, bool A_27)
	{
		double[] array = new double[8];
		_ = new double[3];
		bool flag = hr.r(A_21);
		int num = A_25.ed().g7();
		StreamWriter streamWriter = null;
		string text = null;
		checked
		{
			int num2 = A_24 - A_23 + 1;
			bool A_28 = false;
			double[] A_29 = null;
			double num3 = A_16[A_23];
			try
			{
				double num4 = A_16[1] - A_16[0];
				int num5 = (int)Math.Round(0.5 * (double)(A_24 + A_23));
				float num6 = (float)(0.5 * (2.0 * A_16[num5] * A_16[num5] / (A_16[A_24] - num3) - A_16[num5]));
				double A_30 = default(double);
				m2(num6, ref A_30);
				double A_31 = default(double);
				double A_32 = default(double);
				double A_33 = default(double);
				if ((A_3[A_1] > num6 || (A_5 && A_3[A_4] > num6)) && !A_15)
				{
					m2(A_18, A_16, A_23, A_24, ref A_31, ref A_32, ref A_33);
					for (int num7 = A_23; num7 <= A_24; num7++)
					{
						b2[num7] = A_31 + (A_32 + A_33 * A_16[num7]) * A_16[num7];
					}
				}
				else
				{
					for (int num7 = A_23; num7 <= A_24; num7++)
					{
						b2[num7] = 0.0;
					}
				}
				A_6 = 3.4028234663852886E+38;
				float num8 = (float)(0.04 * Math.Abs(num3 + 1.0));
				float num9 = (float)(0.05 * Math.Abs(num3 + 1.0));
				double num10 = ((!A_5) ? ((double)A_2[A_1] + 1E-06) : (A_7 + 1E-06));
				double A_34;
				bool flag2;
				int num11 = default(int);
				bool A_35;
				if (A_3[A_1] > num6 && A_8)
				{
					A_34 = ((!A_5) ? ((double)(A_3[A_1] * 2f)) : num10);
					flag2 = true;
					num11 = a5;
					a5 = 1;
					A_35 = false;
				}
				else
				{
					flag2 = false;
					A_35 = true;
					A_34 = num10;
				}
				double num12 = 1.0;
				a8 = null;
				if (cs)
				{
					try
					{
						text = i3.o() + "\\GridSpectra";
						if (Directory.Exists(text))
						{
							Directory.Delete(text, recursive: true);
						}
						Directory.CreateDirectory(text);
						streamWriter = new StreamWriter(global::c.d().Info.DirectoryPath + "\\GridResults.csv", append: false, Encoding.ASCII);
						streamWriter.WriteLine("Thickness (nm), Min. Fitting Error (rms), Err(0), Err(1)(1 pt shift), Err(2)(2 pt shift), Err(3)(3 pt shift), Err(4) (Scaled+2ndOrd. Fit), Err(5)(Scaled+2ndOrd. Fit+1 pt shift), Err(6)(Scaled+2ndOrd. Fit+2 pt shift), Err(7)(Scaled+2ndOrd. Fit+3 pt shift), scaleFactor, dataAvgAmpl, SimAvgAmpl");
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2);
						Exception a_ = ex2;
						ab8().c(fz.b.a, "Failed to open diagnostics file in MeasEngine.CalcCoarseThickness", a_);
						if (streamWriter != null)
						{
							streamWriter.Close();
							streamWriter = null;
						}
						ProjectData.ClearProjectError();
					}
				}
				double A_36 = default(double);
				m2(num10, num3, ref A_36);
				double num40 = default(double);
				double A_41 = default(double);
				double num43 = default(double);
				double A_42 = default(double);
				double A_43 = default(double);
				double A_44 = default(double);
				double num44 = default(double);
				double num45 = default(double);
				double num46 = default(double);
				double num47 = default(double);
				bool flag4 = default(bool);
				double num53 = default(double);
				double num54 = default(double);
				int A_45 = default(int);
				do
				{
					if (!flag2)
					{
						if (A_5)
						{
							a5 = m2(0, A_4, A_34, A_13, A_23, A_24, A_16, A_25, A_17);
						}
						else
						{
							a5 = m2(0, A_1, A_34, A_13, A_23, A_24, A_16, A_25, A_17);
						}
						if (A_15)
						{
							a5 = (int)Math.Round((double)a5 / 3.0);
							if (a5 < 1)
							{
								a5 = 1;
							}
						}
					}
					double A_37 = 0.0;
					double A_38 = 0.0;
					double A_39 = 0.0;
					int num7 = 0;
					do
					{
						array[num7] = 0.0;
						num7++;
					}
					while (num7 <= 7);
					int A_40 = 0;
					double num13 = A_34 / A_13[A_1, num5];
					if (A_27 || A_22)
					{
						m2(A_0, A_23, A_24, (short)(num + 2), A_12, A_13, A_14, A_16, A_20, A_19, flag, A_22, A_4, num13, ref A_40, ref A_37, ref A_38, ref A_39);
						if (ct != 0)
						{
							return;
						}
					}
					else
					{
						int num14 = a5;
						for (num7 = A_23; ((num14 >> 31) ^ num7) <= ((num14 >> 31) ^ A_24); num7 += num14)
						{
							double num15 = bg[A_1 - 1, num7] * num13;
							double num16 = Math.Cos(num15);
							double num17 = Math.Sin(num15);
							double num18 = bi[A_1 - 1, num7] * num13;
							double num19 = ((!(num18 > 100.0)) ? Math.Exp(num18) : Math.Exp(100.0));
							double num20 = num16 * num19;
							double num21 = num17 * num19;
							double num22 = num16 / num19;
							double num23 = (0.0 - num17) / num19;
							double num24 = num20 * by[num7] - num21 * bz[num7];
							double num25 = num21 * by[num7] + num20 * bz[num7];
							double num26 = num22 * b0[num7] - num23 * b1[num7];
							double num27 = num23 * b0[num7] + num22 * b1[num7];
							double num28 = bq[num7] * num24 - br[num7] * num25 + bs[num7] * num26 - bt[num7] * num27;
							double num29 = bq[num7] * num25 + br[num7] * num24 + bs[num7] * num27 + bt[num7] * num26;
							double num30 = bu[num7] * num24 - bv[num7] * num25 + bw[num7] * num26 - bx[num7] * num27;
							double num31 = bu[num7] * num25 + bv[num7] * num24 + bw[num7] * num27 + bx[num7] * num26;
							if (flag)
							{
								double num32 = num28 * num28 + num29 * num29;
								b4[num7] = bm[num7] / (num32 * bk[num7]);
							}
							else
							{
								num28 /= 1E+120;
								num29 /= 1E+120;
								num30 /= 1E+120;
								num31 /= 1E+120;
								double num32 = num28 * num28 + num29 * num29;
								double num33 = num30 * num30 + num31 * num31;
								b4[num7] = num33 / num32;
							}
							A_37 += b4[num7];
							A_38 += A_18[num7];
							A_39 += Math.Abs(A_18[num7] - b2[num7]);
							A_40++;
						}
					}
					float num34 = ((!(A_34 > 1.0)) ? 1f : ((float)(0.25 * num3 * num12 / (A_34 * num4))));
					int num35 = (int)Math.Round(num34);
					int num36 = (int)Math.Round(num34 + num34);
					int num37 = (int)Math.Round(num34 + num34 + num34);
					int a_2 = A_23 - 1;
					int num38 = a5;
					for (num7 = A_23; ((num38 >> 31) ^ num7) <= ((num38 >> 31) ^ A_24); num7 += num38)
					{
						if (num7 + num37 < A_23 + num2)
						{
							a_2 = num7;
						}
					}
					bool flag3 = false;
					double num39;
					if (A_34 < (double)num6 || flag2)
					{
						num39 = (A_37 - A_38) / (double)A_40;
						if (A_23 + num37 > A_19 - 1 || A_5 || num > 1)
						{
							if (A_5)
							{
								if (A_26[A_4] * A_13[A_4, num5] < (double)num6)
								{
									array[0] = m2(A_23, A_24, A_18, b4, A_4: false, 1.0, num39, 0);
									if (A_22)
									{
										array[0] = 0.5 * (array[0] + (double)m2(A_23, A_24, A_20, b4, num2 - A_23, A_19));
									}
									num7 = 1;
									do
									{
										array[num7] = 3.4028234663852886E+38;
										num7++;
									}
									while (num7 <= 7);
								}
								else
								{
									A_37 /= (double)A_40;
									num40 = 0.0;
									int num41 = a5;
									for (num7 = A_23; ((num41 >> 31) ^ num7) <= ((num41 >> 31) ^ A_24); num7 += num41)
									{
										num40 += Math.Abs(b4[num7] - A_37);
									}
									A_41 = num40 / A_39;
									array[0] = m2(A_23, A_24, A_18, b4, A_4: false, A_41, num39, 0);
									array[4] = m2(A_23, A_24, A_18, b4, A_4: true, A_41, num39, 0);
									if (A_22)
									{
										float num42 = m2(A_23, A_24, A_20, b4, num2 - A_23, A_19);
										array[0] = 0.5 * (array[0] + (double)num42);
										array[4] = 0.5 * (array[4] + (double)num42);
									}
									num7 = 1;
									do
									{
										if (num7 != 4)
										{
											array[num7] = 3.4028234663852886E+38;
										}
										num7++;
									}
									while (num7 <= 7);
								}
							}
							else
							{
								array[0] = m2(A_23, A_24, A_18, b4, A_4: false, 1.0, num39, 0);
								if (A_22)
								{
									num43 = m2(A_23, A_24, A_20, b4, num2 - A_23, A_19);
									array[0] = 0.5 * (array[0] + num43);
								}
								if (!flag2 && !A_35 && !A_28)
								{
									double[] array2 = b2;
									double[] array3 = b3;
									m2(A_38, A_37, A_40, A_23, A_24, A_18, ref A_42, ref A_43, ref A_41);
									array[4] = m2(A_23, A_24, A_18, b4, A_4: true, A_41, 0.0, 0);
									if (A_22)
									{
										array[4] = 0.5 * (array[4] + num43);
									}
									array[4] *= m2(array[4], A_34, A_30, A_44);
									flag3 = true;
									b2 = array2;
									b3 = array3;
								}
								else
								{
									array[4] = 3.4028234663852886E+38;
								}
								num7 = 1;
								do
								{
									array[num7] = 3.4028234663852886E+38;
									num7++;
								}
								while (num7 <= 3);
								num7 = 5;
								do
								{
									array[num7] = 3.4028234663852886E+38;
									num7++;
								}
								while (num7 <= 7);
								num12 = 0.25 * (double)num9;
							}
						}
						else
						{
							array[0] = m2(A_23, a_2, A_18, b4, A_4: false, 1.0, num39, 0);
							array[1] = m2(A_23, a_2, A_18, b4, A_4: false, 1.0, num39, num35);
							array[2] = m2(A_23, a_2, A_18, b4, A_4: false, 1.0, num39, num36);
							array[3] = m2(A_23, a_2, A_18, b4, A_4: false, 1.0, num39, num37);
							if (A_22)
							{
								num44 = m2(A_23, a_2, A_20, b4, num2 - A_23, A_19);
								num45 = m2(A_23, a_2, A_20, b4, num2 - A_23 + num35, A_19);
								num46 = m2(A_23, a_2, A_20, b4, num2 - A_23 + num36, A_19);
								num47 = m2(A_23, a_2, A_20, b4, num2 - A_23 + num37, A_19);
								array[0] = 0.5 * (array[0] + num44);
								array[1] = 0.5 * (array[1] + num45);
								array[2] = 0.5 * (array[2] + num46);
								array[3] = 0.5 * (array[3] + num47);
							}
							if (!flag2 && !A_35 && !A_28)
							{
								double[] array4 = b2;
								double[] array5 = b3;
								m2(A_38, A_37, A_40, A_23, A_24, A_18, ref A_42, ref A_43, ref A_41);
								array[4] = m2(A_23, a_2, A_18, b4, A_4: true, A_41, 0.0, 0);
								array[5] = m2(A_23, a_2, A_18, b4, A_4: true, A_41, 0.0, num35);
								array[6] = m2(A_23, a_2, A_18, b4, A_4: true, A_41, 0.0, num36);
								array[7] = m2(A_23, a_2, A_18, b4, A_4: true, A_41, 0.0, num37);
								flag3 = true;
								b2 = array4;
								b3 = array5;
								if (A_22)
								{
									array[4] = 0.5 * (array[4] + num44);
									array[5] = 0.5 * (array[5] + num45);
									array[6] = 0.5 * (array[6] + num46);
									array[7] = 0.5 * (array[7] + num47);
								}
								double num48 = m2(1.0, A_34, A_30, A_44);
								array[4] *= num48;
								array[5] *= num48;
								array[6] *= num48;
								array[7] *= num48;
							}
							else
							{
								num7 = 4;
								do
								{
									array[num7] = 3.4028234663852886E+38;
									num7++;
								}
								while (num7 <= 7);
							}
							float num49 = (float)(0.25 * num3 * (double)num9 / (A_34 * num4));
							num12 = ((!((float)A_23 + 4f * (3f * num49) > (float)(A_19 - 1))) ? ((double)num9) : (0.25 * (double)num9));
						}
					}
					else
					{
						num39 = (A_37 - A_38) / (double)A_40;
						A_37 /= (double)A_40;
						num40 = 0.0;
						int num50 = a5;
						for (num7 = A_23; ((num50 >> 31) ^ num7) <= ((num50 >> 31) ^ A_24); num7 += num50)
						{
							num40 += Math.Abs(b4[num7] - A_37);
						}
						A_41 = ((A_39 != 0.0) ? (num40 / A_39) : 1.0);
						array[0] = m2(A_23, a_2, A_18, b4, A_4: false, 1.0, num39, 0);
						array[1] = m2(A_23, a_2, A_18, b4, A_4: false, 1.0, num39, num35);
						array[2] = m2(A_23, a_2, A_18, b4, A_4: false, 1.0, num39, num36);
						array[3] = m2(A_23, a_2, A_18, b4, A_4: false, 1.0, num39, num37);
						array[4] = m2(A_23, a_2, A_18, b4, A_4: true, A_41, 0.0, 0);
						array[5] = m2(A_23, a_2, A_18, b4, A_4: true, A_41, 0.0, num35);
						array[6] = m2(A_23, a_2, A_18, b4, A_4: true, A_41, 0.0, num36);
						array[7] = m2(A_23, a_2, A_18, b4, A_4: true, A_41, 0.0, num37);
						if (A_22)
						{
							float num51 = m2(A_23, a_2, A_20, b4, num2 - A_23, A_19);
							array[0] = 0.5 * (array[0] + (double)num51);
							array[4] = 0.5 * (array[4] + (double)num51);
							num51 = m2(A_23, a_2, A_20, b4, num2 - A_23 + num35, A_19);
							array[1] = 0.5 * (array[1] + (double)num51);
							array[5] = 0.5 * (array[5] + (double)num51);
							num51 = m2(A_23, a_2, A_20, b4, num2 - A_23 + num36, A_19);
							array[2] = 0.5 * (array[2] + (double)num51);
							array[6] = 0.5 * (array[6] + (double)num51);
							num51 = m2(A_23, a_2, A_20, b4, num2 - A_23 + num37, A_19);
							array[3] = 0.5 * (array[3] + (double)num51);
							array[7] = 0.5 * (array[7] + (double)num51);
						}
						num12 = num8;
						if (num12 > num13 * 0.05)
						{
							num12 = num9;
						}
					}
					if (!A_35 && !A_28)
					{
						double num52 = double.MaxValue;
						num7 = 0;
						do
						{
							if (array[num7] < A_6)
							{
								b5 = num13;
								A_6 = array[num7];
								A_10 = num39;
								A_11 = A_41;
								if (num7 > 3)
								{
									A_9 = true;
									flag4 = flag3;
									num53 = A_42;
									num54 = A_43;
								}
								else
								{
									A_9 = false;
								}
								if (streamWriter != null)
								{
									StreamWriter streamWriter2 = null;
									try
									{
										streamWriter2 = new StreamWriter(text + "\\spectrum-R (" + num13.ToString("0.0") + " nm).csv");
										streamWriter2.WriteLine("Wavelen, Meas, Calc, Delta0, Delta1, Delta2, Delta3, Delta4, Delta5, Delta6, Delta7, mReflShift, mGraphDataShift, meas-shift, sim-shift, scaled meas");
										int num55 = a5;
										for (int num56 = A_23; ((num55 >> 31) ^ num56) <= ((num55 >> 31) ^ A_24); num56 += num55)
										{
											if (num56 + num37 <= A_19 - 1)
											{
												streamWriter2.WriteLine(A_16[num56] + ", " + A_20[num56 - A_23] + ", " + b4[num56] + ", " + (b4[num56] - A_18[num56] - num39) + ", " + (b4[num56] - A_18[num56 + num35] - num39) + ", " + (b4[num56] - A_18[num56 + num36] - num39) + ", " + (b4[num56] - A_18[num56 + num37] - num39) + ", " + (b4[num56] - b3[num56] - A_41 * (A_18[num56] - b2[num56])) + ", " + (b4[num56] - b3[num56] - A_41 * (A_18[num56 + num35] - b2[num56 + num35])) + ", " + (b4[num56] - b3[num56] - A_41 * (A_18[num56 + num36] - b2[num56 + num36])) + ", " + (b4[num56] - b3[num56] - A_41 * (A_18[num56 + num37] - b2[num56 + num37])) + ", " + b3[num56] + ", " + b2[num56] + ", " + (A_18[num56] - b2[num56]) + ", " + (b4[num56] - b3[num56]) + ", " + A_41 * (A_18[num56] - b2[num56]));
											}
										}
									}
									catch (Exception ex3)
									{
										ProjectData.SetProjectError(ex3);
										Exception a_3 = ex3;
										ab8().c(fz.b.a, "Failed to open spectrum-R (" + num13.ToString("0.0") + " nm).csv in MeasEngine.CalcCoarseThickness", a_3);
										ProjectData.ClearProjectError();
									}
									finally
									{
										streamWriter2?.Close();
									}
									if (A_22)
									{
										try
										{
											int num57 = A_24 - A_23 + 1;
											streamWriter2 = new StreamWriter(text + "\\spectrum-T (" + num13.ToString("0.0") + " nm).csv");
											streamWriter2.WriteLine("Wavelen, Meas, Calc");
											int num58 = a5;
											for (int num59 = A_23; ((num58 >> 31) ^ num59) <= ((num58 >> 31) ^ A_24); num59 += num58)
											{
												streamWriter2.WriteLine(A_16[num59] + ", " + A_20[num57 + num59 - A_23] + ", " + b4[A_19 + num59]);
											}
										}
										finally
										{
											streamWriter2.Close();
										}
									}
								}
							}
							if (streamWriter != null && array[num7] < num52)
							{
								num52 = array[num7];
							}
							num7++;
						}
						while (num7 <= 7);
						if (streamWriter != null && !flag2)
						{
							num52 = Math.Sqrt(num52 / Math.Floor((double)(A_24 - A_23) / (double)a5 + 1.0));
							streamWriter.Write(num13.ToString("0.00") + ", " + num52.ToString("0.00000"));
							num7 = 0;
							do
							{
								double num60 = Math.Sqrt(array[num7] / Math.Floor((double)(A_24 - A_23) / (double)a5 + 1.0));
								if (num60 > 100.0)
								{
									num60 = 100.0;
								}
								streamWriter.Write(", " + num60.ToString("0.00000"));
								num7++;
							}
							while (num7 <= 7);
							streamWriter.Write(", " + A_41.ToString("0.00000"));
							streamWriter.Write(", " + (A_39 / (double)A_40).ToString("0.00000"));
							streamWriter.Write(", " + (num40 / (double)A_40).ToString("0.00000"));
							streamWriter.WriteLine();
						}
					}
					m2(ref A_35, ref A_28, ref A_34, num10, num12, A_36, A_23, A_24, ref A_29, A_30, ref A_45, ref A_44);
					if (flag2 && !A_35 && !A_28)
					{
						flag2 = false;
						m2(b4, A_16, A_23, A_24, ref A_31, ref A_32, ref A_33);
						for (num7 = A_23; num7 <= A_24; num7++)
						{
							b3[num7] = A_31 + (A_32 + A_33 * A_16[num7]) * A_16[num7];
						}
						A_34 = num10 - num12;
						A_35 = true;
						a5 = num11;
						a8 = null;
						A_6 = 3.4028234663852886E+38;
					}
					if (cq)
					{
						return;
					}
					A_34 += num12;
				}
				while ((!(A_34 >= (double)A_3[A_1]) && !A_5) || A_35 || A_28);
				if (flag4)
				{
					for (int num7 = A_23; num7 <= A_24; num7++)
					{
						b3[num7] = num54;
						b2[num7] = num53;
					}
				}
			}
			finally
			{
				streamWriter?.Close();
			}
		}
	}

	private void m2(double A_0, ref double A_1)
	{
		A_1 = 0.25 * A_0;
	}

	private void m2(double A_0, double A_1, ref double A_2)
	{
		A_2 = A_0 + 0.05 * A_1;
	}

	private double m2(double A_0, double A_1, double A_2, double A_3)
	{
		if (A_1 >= A_2)
		{
			return A_0;
		}
		double num = A_1 - A_2;
		return A_0 * (1.0 + num * num * A_3);
	}

	private void m2(ref bool A_0, ref bool A_1, ref double A_2, double A_3, double A_4, double A_5, int A_6, int A_7, ref double[] A_8, double A_9, ref int A_10, ref double A_11)
	{
		checked
		{
			if (A_1)
			{
				int num = a5;
				double num4 = default(double);
				double num5 = default(double);
				int num6 = default(int);
				for (int num2 = A_6; ((num >> 31) ^ num2) <= ((num >> 31) ^ A_7); num2 += num)
				{
					double num3 = A_8[num2] - b4[num2];
					num4 += num3 * num3;
					num5 += num3;
					num6++;
				}
				double num7 = num5 / (double)A_10;
				double num8 = num4 / (double)A_10;
				if (num8 > 0.0)
				{
					double num9 = 1.0 / (1.0 - num7 * num7 / num8);
					A_11 = num9 / (A_9 * A_9);
				}
				else
				{
					A_11 = 3.4028234663852886E+38;
				}
				A_2 = A_3 - A_4;
				A_1 = false;
			}
			else if (A_0)
			{
				A_8 = new double[b4.Length - 1 + 1];
				A_10 = 0;
				int num10 = a5;
				for (int num2 = A_6; ((num10 >> 31) ^ num2) <= ((num10 >> 31) ^ A_7); num2 += num10)
				{
					A_8[num2] = b4[num2];
					A_10++;
				}
				A_0 = false;
				A_1 = true;
				A_2 = A_5;
			}
		}
	}

	protected void m2(int A_0, int A_1, float[] A_2, float[] A_3, double A_4, ref double A_5, bool A_6, double[] A_7, double[,] A_8, double[,] A_9, double[] A_10, double[] A_11, int A_12, double[] A_13, hr.b A_14, bool A_15, int A_16, int A_17, int A_18, bool A_19, ref bool A_20)
	{
		double[] array = new double[8];
		bool flag = hr.r(A_14);
		bool A_21 = true;
		bool A_22 = false;
		double[] A_23 = null;
		double num = A_10[A_16];
		checked
		{
			int num2 = (int)Math.Round(0.5 * (double)(A_17 + A_16));
			float num3 = (float)(0.5 * (2.0 * A_10[num2] * A_10[num2] / (A_10[A_17] - num) - A_10[num2]));
			double num4 = 1.0;
			double num5 = A_8[A_1, num2];
			double A_24 = default(double);
			m2(num3, ref A_24);
			double A_25 = default(double);
			double A_31 = default(double);
			double A_32 = default(double);
			double A_33 = default(double);
			double A_34 = default(double);
			int A_35 = default(int);
			double num39 = default(double);
			double num40 = default(double);
			while (true)
			{
				double num6 = 3.4028234663852886E+38;
				double num7 = b5 * num5;
				double num8 = num7 - num4 * num;
				if (num8 < (double)A_2[A_1])
				{
					num8 = A_2[A_1];
				}
				double num9 = num7 + num4 * num;
				if (num9 > (double)A_3[A_1])
				{
					num9 = A_3[A_1];
				}
				m2(num8, num, ref A_25);
				double num10 = 0.0125 * (num9 - num8);
				double num11 = num8;
				double num12 = num9;
				double num13 = num10;
				bool flag2 = num13 >= 0.0;
				for (double A_26 = num11; flag2 ? (A_26 <= num12) : (A_26 >= num12); A_26 += num13)
				{
					double A_27 = 0.0;
					double A_28 = 0.0;
					double A_29 = 0.0;
					array[0] = 0.0;
					array[1] = 0.0;
					int A_30 = 0;
					bool flag3 = false;
					double num14 = A_26 / num5;
					int num16;
					if (A_19 || A_15)
					{
						m2(A_0, A_16, A_17, (short)A_18, A_7, A_8, A_9, A_10, A_13, A_12, flag, A_15, A_1, num14, ref A_30, ref A_27, ref A_28, ref A_29);
						if (cq)
						{
							return;
						}
					}
					else
					{
						if (ct != 0)
						{
							return;
						}
						int num15 = a5;
						for (num16 = A_16; ((num15 >> 31) ^ num16) <= ((num15 >> 31) ^ A_17); num16 += num15)
						{
							double num17 = bg[A_1 - 1, num16] * num14;
							double num18 = Math.Cos(num17);
							double num19 = Math.Sin(num17);
							double num20 = bi[A_1 - 1, num16] * num14;
							double num21 = ((!(num20 > 100.0)) ? Math.Exp(num20) : Math.Exp(100.0));
							double num22 = num18 * num21;
							double num23 = num19 * num21;
							double num24 = num18 / num21;
							double num25 = (0.0 - num19) / num21;
							double num26 = num22 * by[num16] - num23 * bz[num16];
							double num27 = num23 * by[num16] + num22 * bz[num16];
							double num28 = num24 * b0[num16] - num25 * b1[num16];
							double num29 = num25 * b0[num16] + num24 * b1[num16];
							double num30 = bq[num16] * num26 - br[num16] * num27 + bs[num16] * num28 - bt[num16] * num29;
							double num31 = bq[num16] * num27 + br[num16] * num26 + bs[num16] * num29 + bt[num16] * num28;
							double num32 = bu[num16] * num26 - bv[num16] * num27 + bw[num16] * num28 - bx[num16] * num29;
							double num33 = bu[num16] * num27 + bv[num16] * num26 + bw[num16] * num29 + bx[num16] * num28;
							if (flag)
							{
								double num34 = num30 * num30 + num31 * num31;
								b4[num16] = bm[num16] / (num34 * bk[num16]);
							}
							else
							{
								num30 /= 1E+120;
								num31 /= 1E+120;
								num32 /= 1E+120;
								num33 /= 1E+120;
								double num34 = num30 * num30 + num31 * num31;
								double num35 = num32 * num32 + num33 * num33;
								b4[num16] = num35 / num34;
							}
							A_27 += b4[num16];
							A_28 += A_11[num16];
							A_29 += Math.Abs(A_11[num16] - b2[num16]);
							A_30++;
							if (cq)
							{
								return;
							}
						}
					}
					double num36;
					if (A_26 < (double)num3)
					{
						num36 = (A_27 - A_28) / (double)A_30;
						if (!A_21 && !A_22)
						{
							array[0] = m2(A_16, A_17, A_11, b4, A_4: false, 1.0, num36, 0);
							double[] array2 = b2;
							double[] array3 = b3;
							m2(A_28, A_27, A_30, A_16, A_17, A_11, ref A_31, ref A_32, ref A_33);
							array[1] = m2(A_16, A_17, A_11, b4, A_4: true, A_33, 0.0, 0);
							array[1] = m2(array[1], A_26, A_24, A_34);
							flag3 = true;
							b2 = array2;
							b3 = array3;
						}
						else
						{
							array[0] = 3.4028234663852886E+38;
							array[1] = 3.4028234663852886E+38;
						}
					}
					else
					{
						num36 = (A_27 - A_28) / (double)A_30;
						A_27 /= (double)A_30;
						double num37 = 0.0;
						int num38 = a5;
						for (num16 = A_16; ((num38 >> 31) ^ num16) <= ((num38 >> 31) ^ A_17); num16 += num38)
						{
							num37 += Math.Abs(b4[num16] - A_27);
						}
						A_33 = num37 / A_29;
						array[0] = m2(A_16, A_17, A_11, b4, A_4: false, 1.0, num36, 0);
						array[1] = m2(A_16, A_17, A_11, b4, A_4: true, A_33, 0.0, 0);
					}
					m2(ref A_21, ref A_22, ref A_26, num8, num10, A_25, A_16, A_17, ref A_23, A_24, ref A_35, ref A_34);
					if (A_21 || A_22)
					{
						continue;
					}
					num16 = 0;
					do
					{
						if (array[num16] < num6)
						{
							b5 = num14;
							num6 = array[num16];
							A_6 = num16 == 1;
							A_4 = num36;
							A_5 = A_33;
							A_20 = flag3;
							num39 = A_31;
							num40 = A_32;
						}
						num16++;
					}
					while (num16 <= 1);
				}
				num4 *= 0.05;
				if (!(num4 < 0.0001))
				{
					continue;
				}
				if (A_20)
				{
					for (int num16 = A_16; num16 <= A_17; num16++)
					{
						b3[num16] = num40;
						b2[num16] = num39;
					}
				}
				break;
			}
		}
	}

	protected void m2(int A_0, ref int A_1, ref bool A_2, int A_3, double[] A_4, double[,] A_5, double[,] A_6, ref int A_7, ref int A_8, ref double A_9, ref bool A_10, hi A_11, ref float A_12, ref bool A_13, hg A_14, double[] A_15, double[] A_16, double[] A_17, int A_18, double[] A_19, hr.b A_20, bool A_21, double[] A_22, int A_23, int A_24, double[] A_25, bool A_26)
	{
		bool flag = hr.r(A_20);
		checked
		{
			_ = new float[A_3 + 1];
			_ = new float[A_3 + 1];
			float[] array = new float[A_3 + 1];
			float[] array2 = new float[A_3 + 1];
			m2(A_1, A_14, A_15, A_18, A_22);
			double A_28 = default(double);
			double A_29 = default(double);
			bool A_30 = default(bool);
			if (!A_2)
			{
				m2(A_0, array, array2, A_5, A_14, A_23, A_24);
				double A_27 = default(double);
				m2(A_0, A_1, array, array2, A_7, A_5: false, ref A_9, ref A_27, A_8: true, ref A_10, ref A_28, ref A_29, A_4, A_5, A_6, ref A_13, A_15, A_16, A_17, A_18, A_19, A_20, A_21, A_23, A_24, A_14, A_22, A_26);
				if (cq || ct != 0)
				{
					return;
				}
				m2(A_0, A_1, array, array2, A_28, ref A_29, A_10, A_4, A_5, A_6, A_15, A_17, A_18, A_19, A_20, A_21, A_23, A_24, A_3 + 2, A_26, ref A_30);
				if (cq || ct != 0)
				{
					return;
				}
			}
			else
			{
				b5 = A_22[A_1];
			}
			A_22[A_1] = b5;
			for (int num = 1; num <= A_3; num++)
			{
				float num2 = (float)(A_11.eu(num).av() * 0.01);
				if (A_22[num] < A_22[num] * (double)(1f - num2))
				{
					A_22[num] *= 1f - num2;
				}
				if (A_22[num] > A_22[num] * (double)(1f + num2))
				{
					A_22[num] *= 1f + num2;
				}
				A_4[num] = A_22[num] * 1E-09;
			}
			if (A_26 || A_21)
			{
				a5 = 1;
				a8 = null;
				short a_ = (short)(A_3 + 2);
				int a_2 = A_7;
				double a_3 = A_22[A_1];
				int A_31 = 0;
				double A_32 = 0.0;
				double A_33 = 0.0;
				double A_34 = 0.0;
				m2(A_0, A_23, A_24, a_, A_4, A_5, A_6, A_15, A_19, A_18, flag, A_21, a_2, a_3, ref A_31, ref A_32, ref A_33, ref A_34);
				A_31 = A_24;
				for (int num = A_23; num <= A_31; num++)
				{
					A_25[num - A_23] = b4[num];
				}
			}
			else
			{
				for (int num = A_23; num <= A_24; num++)
				{
					double num3;
					double num4;
					double num5;
					double num6;
					if (A_3 == 0)
					{
						num3 = 1.0;
						num4 = 0.0;
						num5 = 1.0;
						num6 = 0.0;
					}
					else
					{
						double num7 = bg[A_1 - 1, num] * b5;
						double num8 = Math.Cos(num7);
						double num9 = Math.Sin(num7);
						double num10 = bi[A_1 - 1, num] * b5;
						double num11 = ((!(num10 > 100.0)) ? Math.Exp(num10) : Math.Exp(100.0));
						num3 = num8 * num11;
						num4 = num9 * num11;
						num5 = num8 / num11;
						num6 = (0.0 - num9) / num11;
					}
					double num12 = num3 * by[num] - num4 * bz[num];
					double num13 = num4 * by[num] + num3 * bz[num];
					double num14 = num5 * b0[num] - num6 * b1[num];
					double num15 = num6 * b0[num] + num5 * b1[num];
					double num16 = bq[num] * num12 - br[num] * num13 + bs[num] * num14 - bt[num] * num15;
					double num17 = bq[num] * num13 + br[num] * num12 + bs[num] * num15 + bt[num] * num14;
					double num18 = bu[num] * num12 - bv[num] * num13 + bw[num] * num14 - bx[num] * num15;
					double num19 = bu[num] * num13 + bv[num] * num12 + bw[num] * num15 + bx[num] * num14;
					double num20;
					if (flag)
					{
						num20 = num16 * num16 + num17 * num17;
						A_25[num - A_23] = bm[num] / (num20 * bk[num]);
						continue;
					}
					num16 /= 1E+120;
					num17 /= 1E+120;
					num18 /= 1E+120;
					num19 /= 1E+120;
					num20 = num16 * num16 + num17 * num17;
					double num21 = num18 * num18 + num19 * num19;
					A_25[num - A_23] = num21 / num20;
				}
			}
			if (A_10 && A_29 == 0.0)
			{
				A_29 = 1.0;
			}
			if (A_10)
			{
				for (int num = A_23; num <= A_24; num++)
				{
					A_25[num - A_23] = (A_25[num - A_23] - b3[num]) / A_29 + b2[num];
				}
			}
			else
			{
				for (int num = A_23; num <= A_24; num++)
				{
					A_25[num - A_23] = A_25[num - A_23] - A_28;
				}
			}
			if (A_10)
			{
				if (A_30)
				{
					if (A_29 > 1.0)
					{
						A_12 = (float)(1.0 + 0.05 * (A_29 - 1.0));
					}
					else
					{
						A_12 = (float)(1.0 - 0.05 * (1.0 - A_29));
					}
				}
				else
				{
					A_12 = (float)A_29;
				}
			}
			else
			{
				A_12 = 1f;
			}
		}
	}

	protected void m2(ref double A_0, ref double A_1, ref double A_2, int A_3, int A_4, double[,] A_5, int A_6, double[] A_7, double[] A_8, int A_9, int A_10, short[] A_11, double[] A_12, ref bool A_13)
	{
		int try0000_dispatch = -1;
		checked
		{
			int num2 = default(int);
			int num6 = default(int);
			int num = default(int);
			int num3 = default(int);
			int num5 = default(int);
			int num7 = default(int);
			bool flag = default(bool);
			double num8 = default(double);
			int num9 = default(int);
			double num10 = default(double);
			double num11 = default(double);
			int num12 = default(int);
			double num13 = default(double);
			double num14 = default(double);
			int num16 = default(int);
			double num17 = default(double);
			double num18 = default(double);
			double num19 = default(double);
			double num20 = default(double);
			int num22 = default(int);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					int num15;
					int num21;
					switch (try0000_dispatch)
					{
					default:
						num2 = 1;
						num6 = -1;
						goto IL_0005;
					case 2145:
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
								goto IL_0005;
							case 3:
								goto IL_000c;
							case 4:
								goto IL_0018;
							case 5:
								goto IL_001f;
							case 6:
								goto IL_0029;
							case 7:
								goto IL_003a;
							case 9:
								goto IL_0041;
							case 8:
							case 10:
								goto IL_004d;
							case 11:
								goto IL_0071;
							case 12:
								goto IL_0081;
							case 15:
								goto IL_0089;
							case 13:
							case 14:
							case 16:
								goto IL_0092;
							case 17:
								goto IL_00a7;
							case 18:
								goto IL_00b5;
							case 19:
								goto IL_00c3;
							case 20:
								goto IL_00d1;
							case 21:
								goto IL_0192;
							case 22:
								goto IL_01e1;
							case 23:
								goto IL_01ee;
							case 24:
								goto IL_022a;
							case 26:
								goto IL_0268;
							case 27:
								goto IL_0279;
							case 25:
							case 28:
								goto IL_028a;
							case 29:
								goto IL_0294;
							case 30:
								goto IL_029e;
							case 31:
								goto IL_02ad;
							case 32:
								goto IL_02b9;
							case 33:
								goto IL_02c0;
							case 34:
								goto IL_02d1;
							case 35:
								goto IL_0392;
							case 36:
								goto IL_03e1;
							case 37:
								goto IL_03ee;
							case 38:
								goto IL_042a;
							case 40:
								goto IL_0468;
							case 41:
								goto IL_0479;
							case 39:
							case 42:
								goto IL_048a;
							case 43:
								goto IL_0494;
							case 44:
								goto IL_049e;
							case 45:
								goto IL_04ad;
							case 46:
								goto IL_04b6;
							case 48:
								goto IL_04bf;
							case 47:
							case 49:
								goto IL_04c6;
							case 50:
								goto IL_04cf;
							case 52:
								goto IL_04d8;
							case 51:
							case 53:
								goto end_IL_0000_2;
							case 55:
								goto IL_04f8;
							case 56:
								goto IL_0506;
							case 57:
								goto IL_0514;
							case 58:
								goto IL_0522;
							case 59:
								goto IL_0529;
							case 60:
								goto IL_053a;
							case 61:
								goto IL_05f9;
							case 62:
								goto IL_0648;
							case 63:
								goto IL_0658;
							case 64:
								goto IL_0694;
							case 65:
								goto IL_06d0;
							case 67:
								goto IL_06d9;
							case 68:
								goto IL_06ea;
							case 66:
							case 69:
								goto IL_06fb;
							case 70:
								goto IL_0705;
							case 71:
								goto IL_070f;
							case 72:
								goto IL_0719;
							default:
								goto end_IL_0000;
							case 54:
							case 73:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_0041:
						num2 = 9;
						num5++;
						goto IL_0048;
						IL_0005:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_000c;
						IL_000c:
						num2 = 3;
						num6 = Information.UBound(A_7);
						goto IL_0018;
						IL_0018:
						ProjectData.ClearProjectError();
						num3 = 0;
						goto IL_001f;
						IL_001f:
						num2 = 5;
						num7 = num6;
						num5 = 0;
						goto IL_0048;
						IL_0048:
						if (num5 <= num7)
						{
							goto IL_0029;
						}
						goto IL_004d;
						IL_0029:
						num2 = 6;
						if (A_7[num5] > 0.0)
						{
							goto IL_003a;
						}
						goto IL_0041;
						IL_003a:
						num2 = 7;
						flag = true;
						goto IL_004d;
						IL_004d:
						num2 = 10;
						num8 = A_5[A_6, (int)Math.Round((double)(A_9 + A_10) / 2.0)];
						goto IL_0071;
						IL_0071:
						num2 = 11;
						if (flag & (A_3 == 0))
						{
							goto IL_0081;
						}
						goto IL_04f8;
						IL_0081:
						num2 = 12;
						num9 = 1;
						goto IL_0092;
						IL_0092:
						num2 = 14;
						if (A_7[num9 - 1] == 0.0)
						{
							goto IL_0089;
						}
						goto IL_00a7;
						IL_00a7:
						num2 = 17;
						num10 = 0.0;
						goto IL_00b5;
						IL_00b5:
						num2 = 18;
						num11 = 0.0;
						goto IL_00c3;
						IL_00c3:
						num2 = 19;
						num12 = A_4;
						num5 = 1;
						goto IL_02a5;
						IL_02a5:
						if (num5 <= num12)
						{
							goto IL_00d1;
						}
						goto IL_02ad;
						IL_02ad:
						num2 = 31;
						num13 = A_7[num9 - 1];
						goto IL_02b9;
						IL_02b9:
						num2 = 32;
						num14 = num13;
						goto IL_02c0;
						IL_02c0:
						num2 = 33;
						num15 = A_4 + 1;
						num16 = num9;
						num5 = num15;
						goto IL_04a5;
						IL_04a5:
						if (num5 <= num16)
						{
							goto IL_02d1;
						}
						goto IL_04ad;
						IL_04ad:
						num2 = 45;
						if (num14 < num11)
						{
							goto IL_04b6;
						}
						goto IL_04bf;
						IL_04b6:
						num2 = 46;
						A_1 = num14;
						goto IL_04c6;
						IL_04bf:
						num2 = 48;
						A_1 = num11;
						goto IL_04c6;
						IL_04c6:
						num2 = 49;
						if (num13 > num10)
						{
							goto IL_04cf;
						}
						goto IL_04d8;
						IL_04cf:
						num2 = 50;
						A_0 = num13;
						break;
						IL_04d8:
						num2 = 52;
						A_0 = num10;
						break;
						IL_02d1:
						num2 = 34;
						num17 = 1.0 + (A_5[A_6, A_9] - A_5[A_6, A_10]) / (A_8[A_9] - A_8[A_10]) * 0.5 * (A_8[A_9] + A_8[A_10]) / A_5[A_6, (int)Math.Round((double)(A_9 + A_10) / 2.0)] - (A_5[num5, A_9] - A_5[num5, A_10]) / (A_8[A_9] - A_8[A_10]) * 0.5 * (A_8[A_9] + A_8[A_10]) / A_5[num5 + 1, (int)Math.Round((double)(A_9 + A_10) / 2.0)];
						goto IL_0392;
						IL_0392:
						num2 = 35;
						num18 = 0.5 * (A_12[num5 * 6 + 0] + A_12[num5 * 6 + 1]) * 1000000000.0 * num17 * A_5[num5, (int)Math.Round((double)(A_9 + A_10) / 2.0)] / num8;
						goto IL_03e1;
						IL_03e1:
						num2 = 36;
						if (A_11[num5 * 4 + 0] != 0)
						{
							goto IL_03ee;
						}
						goto IL_0468;
						IL_03ee:
						num2 = 37;
						num19 = A_12[num5 * 6 + 0] * 1000000000.0 * num17 * A_5[num5, (int)Math.Round((double)(A_9 + A_10) / 2.0)] / num8;
						goto IL_042a;
						IL_042a:
						num2 = 38;
						num20 = A_12[num5 * 6 + 1] * 1000000000.0 * num17 * A_5[num5, (int)Math.Round((double)(A_9 + A_10) / 2.0)] / num8;
						goto IL_048a;
						IL_0468:
						num2 = 40;
						num19 = num18 * 0.95;
						goto IL_0479;
						IL_0479:
						num2 = 41;
						num20 = num18 * 1.05;
						goto IL_048a;
						IL_048a:
						num2 = 42;
						num13 -= num20;
						goto IL_0494;
						IL_0494:
						num2 = 43;
						num14 -= num19;
						goto IL_049e;
						IL_049e:
						num2 = 44;
						num5++;
						goto IL_04a5;
						IL_00d1:
						num2 = 20;
						num17 = 1.0 + (A_5[A_6, A_9] - A_5[A_6, A_10]) / (A_8[A_9] - A_8[A_10]) * 0.5 * (A_8[A_9] + A_8[A_10]) / A_5[A_6, (int)Math.Round((double)(A_9 + A_10) / 2.0)] - (A_5[num5, A_9] - A_5[num5, A_10]) / (A_8[A_9] - A_8[A_10]) * 0.5 * (A_8[A_9] + A_8[A_10]) / A_5[num5 + 1, (int)Math.Round((double)(A_9 + A_10) / 2.0)];
						goto IL_0192;
						IL_0192:
						num2 = 21;
						num18 = 0.5 * (A_12[num5 * 6 + 0] + A_12[num5 * 6 + 1]) * 1000000000.0 * num17 * A_5[num5, (int)Math.Round((double)(A_9 + A_10) / 2.0)] / num8;
						goto IL_01e1;
						IL_01e1:
						num2 = 22;
						if (A_11[num5 * 4 + 0] != 0)
						{
							goto IL_01ee;
						}
						goto IL_0268;
						IL_01ee:
						num2 = 23;
						num19 = A_12[num5 * 6 + 0] * 1000000000.0 * num17 * A_5[num5, (int)Math.Round((double)(A_9 + A_10) / 2.0)] / num8;
						goto IL_022a;
						IL_022a:
						num2 = 24;
						num20 = A_12[num5 * 6 + 1] * 1000000000.0 * num17 * A_5[num5, (int)Math.Round((double)(A_9 + A_10) / 2.0)] / num8;
						goto IL_028a;
						IL_0268:
						num2 = 26;
						num19 = num18 * 0.95;
						goto IL_0279;
						IL_0279:
						num2 = 27;
						num20 = num18 * 1.05;
						goto IL_028a;
						IL_028a:
						num2 = 28;
						num10 += num19;
						goto IL_0294;
						IL_0294:
						num2 = 29;
						num11 += num20;
						goto IL_029e;
						IL_029e:
						num2 = 30;
						num5++;
						goto IL_02a5;
						IL_0089:
						num2 = 15;
						num9++;
						goto IL_0092;
						IL_04f8:
						num2 = 55;
						A_0 = 0.0;
						goto IL_0506;
						IL_0506:
						num2 = 56;
						A_1 = 0.0;
						goto IL_0514;
						IL_0514:
						num2 = 57;
						A_2 = 0.0;
						goto IL_0522;
						IL_0522:
						num2 = 58;
						A_13 = true;
						goto IL_0529;
						IL_0529:
						num2 = 59;
						num21 = A_3 + 1;
						num22 = A_4;
						num5 = num21;
						goto IL_0720;
						IL_0720:
						if (num5 > num22)
						{
							goto end_IL_0000_3;
						}
						goto IL_053a;
						IL_053a:
						num2 = 60;
						num17 = 1.0 + (A_5[A_6, A_9] - A_5[A_6, A_10]) / (A_8[A_9] - A_8[A_10]) * 0.5 * (A_8[A_9] + A_8[A_10]) / A_5[A_6, (int)Math.Round((double)(A_9 + A_10) / 2.0)] - (A_5[num5, A_9] - A_5[num5, A_10]) / (A_8[A_9] - A_8[A_10]) * 0.5 * (A_8[A_9] + A_8[A_10]) / A_5[num5, (int)Math.Round((double)(A_9 + A_10) / 2.0)];
						goto IL_05f9;
						IL_05f9:
						num2 = 61;
						num18 = 0.5 * (A_12[num5 * 6 + 0] + A_12[num5 * 6 + 1]) * 1000000000.0 * num17 * A_5[num5, (int)Math.Round((double)(A_9 + A_10) / 2.0)] / num8;
						goto IL_0648;
						IL_0648:
						num2 = 62;
						if (A_11[num5 * 4 + 0] != 0)
						{
							goto IL_0658;
						}
						goto IL_06d9;
						IL_0658:
						num2 = 63;
						num19 = A_12[num5 * 6 + 0] * 1000000000.0 * num17 * A_5[num5, (int)Math.Round((double)(A_9 + A_10) / 2.0)] / num8;
						goto IL_0694;
						IL_0694:
						num2 = 64;
						num20 = A_12[num5 * 6 + 1] * 1000000000.0 * num17 * A_5[num5, (int)Math.Round((double)(A_9 + A_10) / 2.0)] / num8;
						goto IL_06d0;
						IL_06d0:
						num2 = 65;
						A_13 = false;
						goto IL_06fb;
						IL_06d9:
						num2 = 67;
						num19 = num18 * 0.95;
						goto IL_06ea;
						IL_06ea:
						num2 = 68;
						num20 = num18 * 1.05;
						goto IL_06fb;
						IL_06fb:
						num2 = 69;
						A_2 += num18;
						goto IL_0705;
						IL_0705:
						num2 = 70;
						A_0 += num19;
						goto IL_070f;
						IL_070f:
						num2 = 71;
						A_1 += num20;
						goto IL_0719;
						IL_0719:
						num2 = 72;
						num5++;
						goto IL_0720;
						end_IL_0000_2:
						break;
					}
					num2 = 53;
					A_2 = 0.5 * (A_0 + A_1);
					break;
					end_IL_0000:;
				}
				catch (object obj) when ((obj is Exception) & (num3 != 0) & (num == 0))
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 2145;
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

	protected int m2(int A_0, int A_1, double[,] A_2, double[,] A_3, ref int A_4, ref int A_5, double[] A_6, double[] A_7, ref double A_8, ref bool[] A_9, ref short[] A_10, int A_11, int A_12)
	{
		int num = de[A_0];
		int num2 = 0;
		double num3 = 0.0;
		checked
		{
			int num4 = A_1 + 1;
			for (int num5 = 1; num5 <= num4; num5++)
			{
				if (num5 <= A_1)
				{
					if (A_10[num5 * 4 + 0] != 0)
					{
						A_9[num5] = true;
						unchecked
						{
							if (aq[checked(num + num5)] * A_2[num5, checked(A_11 + A_12) / 2] > num3)
							{
								if (num2 != 0)
								{
									A_5 = num2;
								}
								num2 = num5;
								num3 = aq[checked(num + num5)] * A_2[num5, checked(A_11 + A_12) / 2];
							}
							else
							{
								A_5 = num5;
							}
						}
						A_4++;
					}
				}
				else
				{
					double num6 = 0.0;
					for (int num7 = A_11; num7 <= A_12; num7++)
					{
						num6 += an[num5, num7];
					}
					if (A_12 - A_11 + 1 > 0)
					{
						A_6[num5 - 1] = num6 / (double)(A_12 - A_11 + 1);
					}
					else
					{
						A_6[num5 - 1] = 0.0;
					}
				}
				double num8 = 0.0;
				for (int num7 = A_11; num7 <= A_12; num7++)
				{
					num8 += Math.Abs(A_2[num5 - 1, num7] - A_2[num5, num7]);
				}
				if (A_12 - A_11 + 1 > 0)
				{
					A_7[num5 - 1] = num8 / (double)(A_12 - A_11 + 1);
				}
				else
				{
					A_7[num5 - 1] = 1.0;
				}
			}
			if (num2 == 0)
			{
				return 0;
			}
			A_8 = A_2[num2, (int)Math.Round((double)(A_11 + A_12) / 2.0)];
			return num2;
		}
	}

	protected void m2(int A_0, double A_1, double[,] A_2, int A_3, double A_4, ref double[] A_5, ref double[] A_6, ref double[] A_7, ref int A_8, ref int[] A_9, ref int[] A_10, ref double[] A_11, ref double[] A_12, ref double[] A_13, double[] A_14, int A_15, int A_16, ref short[] A_17, ref double[] A_18, bool[] A_19)
	{
		A_8 = 0;
		checked
		{
			int num = A_0 - 1;
			double A_20 = default(double);
			for (int num2 = 0; num2 <= num; num2++)
			{
				int num3 = num2;
				int num4 = num2 + 1;
				A_9[A_8] = num3;
				A_10[A_8] = num4;
				m2(ref A_11[A_8], ref A_12[A_8], ref A_20, num3, num4, A_2, A_3, A_7, A_14, A_15, A_16, A_17, A_18, ref A_19[A_8]);
				double num5 = 0.0;
				long num6 = 0L;
				for (int num7 = A_15; num7 <= A_16; num7 += 25)
				{
					double num8 = A_14[num7] * (A_14[num7] - 2.0 * A_1) / (2.0 * A_4 * 2.0 * A_1);
					double num9 = Math.Sin(Math.PI * A_20 / num8) / (Math.PI * A_20 / num8);
					num5 += num9 * num9;
					num6++;
				}
				if (num5 / (double)num6 < 0.009999999776482582)
				{
					A_13[A_8] = -1.0;
				}
				else if (A_6[num4] > 0.0)
				{
					A_13[A_8] = num5 / (double)num6 * Math.Sqrt(A_5[num4] * A_5[num4] + A_6[num4] * A_6[num4]) / (1.0 + A_6[num4]) * A_5[num3];
				}
				else
				{
					A_13[A_8] = num5 / (double)num6 * A_5[num4] * A_5[num3];
				}
				A_8++;
				for (num4 = num2 + 2; num4 <= A_0; num4++)
				{
					A_9[A_8] = num3;
					A_10[A_8] = num4;
					m2(ref A_11[A_8], ref A_12[A_8], ref A_20, num3, num4, A_2, A_3, A_7, A_14, A_15, A_16, A_17, A_18, ref A_19[A_8]);
					num5 = 0.0;
					num6 = 0L;
					for (int num7 = A_15; num7 <= A_16; num7 += 25)
					{
						double num8 = A_14[num7] * (A_14[num7] - 2.0 * A_1) / (2.0 * A_4 * 2.0 * A_1);
						double num9 = Math.Sin(Math.PI * A_20 / num8) / (Math.PI * A_20 / num8);
						num5 += num9 * num9;
						num6++;
					}
					if (num5 / (double)num6 < 0.009999999776482582)
					{
						A_13[A_8] = -1.0;
					}
					else if (A_6[num4] > 0.0)
					{
						A_13[A_8] = num5 / (double)num6 * Math.Sqrt(A_5[num4] * A_5[num4] + A_6[num4] * A_6[num4]) / (1.0 + A_6[num4]) * A_5[num3];
					}
					else
					{
						A_13[A_8] = num5 / (double)num6 * (A_5[num4] * A_5[num3]);
					}
					A_8++;
				}
			}
			int num10 = A_8 - 2;
			for (int num11 = 0; num11 <= num10; num11++)
			{
				int num12 = A_8 - 1;
				int num13 = num11 + 1;
				for (int num7 = num12; num7 >= num13; num7 += -1)
				{
					if (A_13[num7] > A_13[num7 - 1])
					{
						double num14 = A_13[num7 - 1];
						A_13[num7 - 1] = A_13[num7];
						A_13[num7] = num14;
						int num15 = A_10[num7 - 1];
						A_10[num7 - 1] = A_10[num7];
						A_10[num7] = num15;
						num15 = A_9[num7 - 1];
						A_9[num7 - 1] = A_9[num7];
						A_9[num7] = num15;
						num14 = A_11[num7 - 1];
						A_11[num7 - 1] = A_11[num7];
						A_11[num7] = num14;
						num14 = A_12[num7 - 1];
						A_12[num7 - 1] = A_12[num7];
						A_12[num7] = num14;
						bool flag = A_19[num7 - 1];
						A_19[num7 - 1] = A_19[num7];
						A_19[num7] = flag;
					}
				}
			}
		}
	}

	protected void m2(double[] A_0, double[] A_1, double[] A_2, int A_3, ref double[] A_4, ref double[] A_5, ref double[] A_6, ref int A_7)
	{
		A_4 = new double[51];
		A_5 = new double[51];
		A_6 = new double[51];
		bool flag = ((A_0[1] > A_0[0]) ? true : false);
		if (A_3 <= 0)
		{
			return;
		}
		double num = A_2[1] - A_2[0];
		checked
		{
			int num2 = A_3 - 1;
			bool flag2 = default(bool);
			for (int num3 = 1; num3 <= num2; num3++)
			{
				if (flag)
				{
					if (!(A_0[num3] < A_0[num3 - 1]))
					{
						continue;
					}
					flag = false;
					if (Information.UBound(A_4) == A_7)
					{
						A_4 = (double[])Utils.CopyArray(A_4, new double[A_7 + 50 + 1]);
						A_5 = (double[])Utils.CopyArray(A_5, new double[A_7 + 50 + 1]);
						A_6 = (double[])Utils.CopyArray(A_6, new double[A_7 + 50 + 1]);
					}
					A_4[A_7] = A_1[num3 - 1];
					double num4 = ((A_0[num3 - 1] - A_0[num3 - 2]) * (A_2[num3 - 1] * A_2[num3 - 1] - A_2[num3] * A_2[num3]) - (A_0[num3 - 1] - A_0[num3]) * (A_2[num3 - 1] * A_2[num3 - 1] - A_2[num3 - 2] * A_2[num3 - 2])) / (num * (2.0 * A_2[num3 - 1] * A_2[num3 - 1] - A_2[num3 - 2] * A_2[num3 - 2] - A_2[num3] * A_2[num3]));
					double num5 = (A_0[num3 - 1] - A_0[num3 - 2] - num4 * num) / (A_2[num3 - 1] * A_2[num3 - 1] - A_2[num3 - 2] * A_2[num3 - 2]);
					if (Math.Abs(num5) > 1E-140)
					{
						A_5[A_7] = (0.0 - num4) / (2.0 * num5);
						if (A_5[A_7] > A_2[num3])
						{
							A_5[A_7] = A_2[num3] * 1000.0;
						}
						else if (A_5[A_7] < A_2[num3 - 2])
						{
							A_5[A_7] = A_2[num3 - 2] * 1000.0;
						}
						else
						{
							A_5[A_7] *= 1000.0;
						}
					}
					else
					{
						A_5[A_7] = A_2[num3 - 1] * 1000.0;
					}
					A_7++;
					flag2 = false;
				}
				else
				{
					if (A_7 > 0 && (!flag2 & (A_0[num3] < 0.5 * A_4[A_7 - 1])))
					{
						flag2 = true;
						A_6[A_7 - 1] = 2.0 * (A_2[num3 - 1] * 1000.0 - A_5[A_7 - 1]);
					}
					if (A_0[num3] > A_0[num3 - 1])
					{
						flag = true;
					}
				}
			}
		}
	}

	protected void m2(int A_0, double[] A_1, double[] A_2, double[] A_3)
	{
		checked
		{
			int num = A_0 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				int num3 = A_0 - 1;
				int num4 = num2 + 1;
				for (int num5 = num3; num5 >= num4; num5 += -1)
				{
					if (A_1[num5] > A_1[num5 - 1])
					{
						double num6 = A_1[num5 - 1];
						A_1[num5 - 1] = A_1[num5];
						A_1[num5] = num6;
						num6 = A_2[num5 - 1];
						A_2[num5 - 1] = A_2[num5];
						A_2[num5] = num6;
						num6 = A_3[num5 - 1];
						A_3[num5 - 1] = A_3[num5];
						A_3[num5] = num6;
					}
				}
			}
		}
	}

	protected void m2(int A_0, int[] A_1, int[] A_2, int[] A_3, double[] A_4, hg A_5, short A_6)
	{
		cj = "FFT Details:";
		ck = cj;
		checked
		{
			int num = A_0 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (Operators.CompareString(cj, "", TextCompare: false) != 0)
				{
					cj += "\\par ";
				}
				if (Operators.CompareString(ck, "FFT Details:", TextCompare: false) != 0)
				{
					ck += ",";
				}
				cj += "Peak layer ";
				ck += " Peak layer ";
				int num3 = A_1[num2];
				if (A_2[num3] - A_3[num3] == 1)
				{
					cj += Strings.Trim(Conversion.Str(A_3[num3] + 1));
					ck += Strings.Trim(Conversion.Str(A_3[num3] + 1));
				}
				else
				{
					string text = "";
					int num4 = A_3[num3] + 1;
					int num5 = A_2[num3];
					for (int num6 = num4; num6 <= num5; num6++)
					{
						if (Operators.CompareString(text, "", TextCompare: false) != 0)
						{
							text += "+";
						}
						text += Strings.Trim(Conversion.Str(num6));
					}
					cj += text;
					ck += text;
				}
				cj = cj + "=" + hg.bu(hg.o.a, A_5.ca(), A_4[num3], A_6, new h4(h4.a.b), 0);
				ck = ck + "=" + hg.bu(hg.o.a, A_5.ca(), A_4[num3], A_6, new h4(h4.a.b), 0);
			}
		}
	}

	protected void m2(double A_0, int A_1, ref double A_2, double[] A_3, double[] A_4, hg A_5)
	{
		ce = A_1;
		checked
		{
			cc = new double[ce - 1 + 1];
			cd = new double[ce - 1 + 1];
			int num = ce - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				cd[num2] = A_3[num2];
				cc[num2] = A_4[num2] * 1000.0;
			}
			A_2 = h4.e(1, A_0, A_5.ca());
		}
	}

	protected int m2(double A_0, double A_1, int A_2, int A_3, double[] A_4, double[] A_5, double A_6, double A_7, double A_8, double[] A_9, double[] A_10, int A_11)
	{
		double A_12 = default(double);
		double A_13 = default(double);
		m2(40.0, A_7, A_9, A_10, A_11, ref A_12, ref A_13);
		double num = A_7 - A_12;
		double num2 = A_13 - A_7;
		double value = (num - num2) / (num + num2);
		checked
		{
			int num3;
			for (num3 = A_2; num3 <= A_3; num3++)
			{
				if (!((A_4[num3] > A_0) & (A_4[num3] < A_1)))
				{
					continue;
				}
				int num4;
				if (A_4[num3] - A_7 > 0.0)
				{
					if (Math.Abs(value) > 0.1)
					{
						num4 = (int)Math.Round(Math.Truncate((A_4[num3] - A_7) / A_8) - 1.0);
						if (num4 < 0)
						{
							num4 = 0;
						}
					}
					else
					{
						num4 = (int)Math.Round(Math.Truncate((A_4[num3] - A_7) / A_8));
					}
				}
				else if (Math.Abs(value) > 0.1)
				{
					num4 = -(int)Math.Round(Math.Truncate(Math.Abs(A_4[num3] - A_7) / A_8) + 1.0);
					if (num4 > 0)
					{
						num4 = 0;
					}
				}
				else
				{
					num4 = -(int)Math.Round(Math.Truncate(Math.Abs(A_4[num3] - A_7) / A_8));
				}
				double num5;
				if ((Math.Abs(A_4[num3] - A_7) < A_8 * 1.2) | ((num4 == 0) & (A_5[num3] / A_6 > 0.44999999999999996)))
				{
					num5 = 0.0;
				}
				else
				{
					double a_ = A_4[num3];
					double A_14 = 0.0;
					double A_15 = 0.0;
					num5 = m2(a_, ref A_9, ref A_10, A_11, ref A_14, ref A_15, A_8);
				}
				double num6;
				if (num4 == 0)
				{
					num6 = 0.15 * A_6;
				}
				else if ((num4 <= 3) & (num4 >= -3))
				{
					double num7 = (double)(2 * Math.Abs(num4) + 1) * Math.PI / 2.0;
					num6 = A_6 * 1.8 * Math.Pow(Math.Sin(num7) / num7, 2.0);
					if (Math.Abs(value) > 0.1)
					{
						num6 *= 3.0;
					}
				}
				else
				{
					num6 = ((Math.Abs(num4) <= 5) ? (0.013 * A_6) : ((Math.Abs(num4) >= 20) ? (0.013 * A_6 * 0.5) : ((1.0 + (double)(Math.Abs(num4) - 5) * -0.5 / 15.0) * 0.013 * A_6)));
					if (Math.Abs(value) > 0.1)
					{
						num6 *= 3.0;
					}
				}
				if (A_5[num3] - num5 > num6)
				{
					break;
				}
			}
			if (num3 > A_3)
			{
				return -1;
			}
			return num3;
		}
	}

	protected double m2(double A_0, double A_1, double[] A_2, double[] A_3, int A_4, ref double A_5, ref double A_6)
	{
		double num = 0.001 * A_1;
		checked
		{
			int num2 = A_4 - 1;
			int num3;
			for (num3 = 0; num3 <= num2 && !(A_3[num3] > num); num3++)
			{
			}
			int num4 = ((!(A_2[num3] > A_2[num3 - 1])) ? (num3 - 1) : num3);
			double num5 = A_2[num4] * A_0 / 100.0;
			for (num3 = num4; num3 >= 0 && !(A_2[num3] < num5); num3 += -1)
			{
			}
			if (num3 >= 0)
			{
				double num6 = (A_2[num3 + 1] - A_2[num3]) / (A_3[num3 + 1] - A_3[num3]);
				A_5 = ((num5 - A_2[num3]) / num6 + A_3[num3]) * 1000.0;
			}
			else
			{
				A_5 = -9999.0;
			}
			int num7 = A_4 - 1;
			for (num3 = num4; num3 <= num7 && !(A_2[num3] < num5); num3++)
			{
			}
			if (num3 <= A_4 - 1)
			{
				double num6 = (A_2[num3 - 1] - A_2[num3]) / (A_3[num3 - 1] - A_3[num3]);
				A_6 = ((num5 - A_2[num3]) / num6 + A_3[num3]) * 1000.0;
			}
			else
			{
				A_6 = 9999.0;
			}
			if ((A_5 == -9999.0) | (A_6 == 9999.0))
			{
				return 0.0;
			}
			return A_6 - A_5;
		}
	}

	protected double m2(double A_0, ref double[] A_1, ref double[] A_2, int A_3, ref double A_4, ref double A_5, double A_6)
	{
		double num = -1.0;
		double num2 = 0.001 * A_0;
		checked
		{
			int num3 = A_3 - 1;
			int num4;
			for (num4 = 0; num4 <= num3 && !(A_2[num4] > num2); num4++)
			{
			}
			int num5 = ((!(A_1[num4] > A_1[num4 - 1])) ? (num4 - 1) : num4);
			for (num4 = num5; num4 >= 1 && !(A_1[num4 - 1] > A_1[num4]); num4 += -1)
			{
			}
			int num6 = num4;
			A_4 = A_2[num4] * 1000.0;
			int num7 = A_3 - 2;
			for (num4 = num5; num4 <= num7 && !(A_1[num4 + 1] > A_1[num4]); num4++)
			{
			}
			int num8 = num4;
			A_5 = A_2[num4] * 1000.0;
			if ((Math.Abs(A_5 - A_0) > 1.0 * A_6) | (Math.Abs(A_0 - A_4) > 1.0 * A_6))
			{
				return (A_1[num6] + A_1[num8]) / 2.0;
			}
			double num9 = (A_1[num6] - A_1[num8]) / (A_2[num6] - A_2[num8]);
			return A_1[num6] + (num2 - A_2[num6]) * num9;
		}
	}

	protected double p9(double A_0, double A_1, double A_2)
	{
		double num = (A_0 + A_1) / 2.0;
		double num2 = A_1 - num;
		double num3 = Math.Abs(A_2 - num);
		if (num2 > 1E-06)
		{
			if (num3 <= num2)
			{
				return (1.0 - num3 / num2) * (1.0 - num3 / num2) / 2.0;
			}
			return 0.0;
		}
		return 0.0;
	}

	protected int m2(double A_0, double A_1, int A_2, int A_3, double[] A_4)
	{
		int num;
		for (num = A_2; num <= A_3 && !((A_4[num] > A_0) & (A_4[num] < A_1)); num = checked(num + 1))
		{
		}
		if (num > A_3)
		{
			return -1;
		}
		return num;
	}

	protected bool m2(int A_0, int A_1, int A_2, int A_3, int A_4, int A_5, double[] A_6, double[] A_7, double[] A_8, double[] A_9, int A_10, int A_11, double[] A_12, double[] A_13)
	{
		bool result = false;
		if (A_4 != -1)
		{
			A_8[A_0] = checked((A_7[A_2] = A_6[A_4]) - A_12[A_0 + 1] - A_13[A_0 - 1]) * 1E-09;
		}
		if (A_5 != -1)
		{
			double num = (A_7[A_3] = A_6[A_5]);
			double num2 = 1.0 + (ah[A_0, A_10] - ah[A_0, A_11]) / (A_9[A_10] - A_9[A_11]) * 0.5 * (A_9[A_10] + A_9[A_11]) / ah[A_0, checked(A_10 + A_11) / 2] - (ah[A_1, A_10] - ah[A_1, A_11]) / (A_9[A_10] - A_9[A_11]) * 0.5 * (A_9[A_10] + A_9[A_11]) / ah[A_1, checked(A_10 + A_11) / 2];
			A_8[A_1] = (num / num2 * ah[A_0, checked(A_10 + A_11) / 2] / ah[A_1, checked(A_10 + A_11) / 2] - A_12[checked(A_1 + 1)] - A_13[checked(A_1 - 1)]) * 1E-09;
		}
		if ((A_4 == -1) & (A_5 == -1))
		{
			result = true;
		}
		return result;
	}

	protected short m2(double A_0, double A_1, short A_2, ref short A_3, ref double[] A_4)
	{
		short num = A_3;
		short num2 = A_2;
		checked
		{
			while (num2 <= num && !((A_4[num2] > A_0) & (A_4[num2] < A_1)))
			{
				num2 = (short)unchecked(num2 + 1);
			}
			if (num2 > A_3)
			{
				return -1;
			}
			return num2;
		}
	}

	protected bool m2(short[] A_0, double[] A_1, ref double[] A_2, ref double A_3, ref int A_4, hg A_5, double[] A_6, int A_7, int A_8, double[] A_9, double[] A_10, int A_11, double A_12, short A_13)
	{
		double[] A_14 = null;
		double[] A_15 = null;
		double[] A_16 = null;
		double[] A_17 = new double[101];
		double[] A_18 = new double[101];
		bool[] A_19 = new bool[102];
		double[] A_20 = new double[5151];
		int[] A_21 = new int[5151];
		int[] A_22 = new int[5151];
		double[] A_23 = new double[5151];
		double[] A_24 = new double[5151];
		int[] array = new int[5151];
		int[] array2 = new int[101];
		_ = new int[101];
		double[] array3 = new double[100];
		_ = new double[100];
		_ = new double[100, 100];
		_ = new int[100];
		_ = new int[100];
		_ = new bool[100];
		double[] A_25 = null;
		bool[] array4 = new bool[5151];
		bool result = true;
		hi hi2 = A_5.b3(A_5.c2());
		int num = hi2.g7();
		checked
		{
			_ = A_6[(int)Math.Round((double)(A_7 + A_8) / 2.0)];
			double a_ = 1.5 * (A_6[(int)Math.Round(Conversion.Int((double)(A_7 + A_8) / 2.0 + 0.5) + 1.0)] - A_6[(int)Math.Round(Conversion.Int((double)(A_7 + A_8) / 2.0 + 0.5))]);
			int A_26 = default(int);
			double A_28 = default(double);
			int A_27 = default(int);
			A_4 = m2(0, num, ah, an, ref A_26, ref A_27, A_18, A_17, ref A_28, ref A_19, ref A_0, A_7, A_8);
			if (A_4 != 0)
			{
				int A_29 = default(int);
				m2(num, a_, ah, A_4, A_28, ref A_17, ref A_18, ref A_25, ref A_29, ref A_21, ref A_22, ref A_23, ref A_24, ref A_20, A_6, A_7, A_8, ref A_0, ref A_1, array4);
				int num2 = A_29 - 1;
				int num3;
				for (num3 = 0; num3 <= num2; num3++)
				{
					if ((A_22[num3] == A_21[num3] + 1) & (A_20[num3] >= 0.0))
					{
						if (A_19[A_22[num3]])
						{
							array[num3] = A_22[num3];
						}
						else
						{
							array[num3] = -1;
						}
					}
					else
					{
						array[num3] = -1;
					}
				}
				int num4 = 0;
				num3 = 0;
				while (num3 <= A_29 - 1)
				{
					if (array[num3] == -1)
					{
						bool flag = false;
						int num5 = num3;
						int num6 = A_29 - 1;
						for (int num7 = num5; num7 <= num6; num7++)
						{
							if (array[num7] > 0)
							{
								array[num3] = array[num7];
								array[num7] = -1;
								double num8 = A_23[num3];
								A_23[num3] = A_23[num7];
								A_23[num7] = num8;
								num8 = A_24[num3];
								A_24[num3] = A_24[num7];
								A_24[num7] = num8;
								num8 = A_20[num3];
								A_20[num3] = A_20[num7];
								A_20[num7] = num8;
								int num9 = A_22[num3];
								A_22[num3] = A_22[num7];
								A_22[num7] = num9;
								num9 = A_21[num3];
								A_21[num3] = A_21[num7];
								A_21[num7] = num9;
								bool flag2 = array4[num3];
								array4[num3] = array4[num7];
								array4[num7] = flag2;
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							num3++;
						}
					}
					else
					{
						array2[num3] = num3;
						num4++;
						num3++;
					}
				}
				if ((A_26 > 100) | (num > 100))
				{
					ab8().c(fz.a.b, "FFTMaxNumLayerReachedFmt1", 100);
				}
				else
				{
					int A_30 = default(int);
					m2(A_9, A_9, A_10, A_11, ref A_14, ref A_15, ref A_16, ref A_30);
					bool flag3;
					double num10 = default(double);
					if (A_30 < num4)
					{
						flag3 = true;
					}
					else
					{
						num10 = 0.0;
						int num11 = num4 - 1;
						for (num3 = 0; num3 <= num11; num3++)
						{
							if (A_24[array2[num3]] > num10)
							{
								num10 = A_24[array2[num3]];
							}
						}
						num10 = num10;
						m2(A_30, A_14, A_15, A_16);
						int num12;
						if (array[0] == A_4)
						{
							A_27 = 1;
							num12 = 0;
						}
						else
						{
							A_27 = 0;
							num12 = 1;
						}
						double[] A_31 = null;
						double[] A_32 = null;
						m2(A_7, A_8, A_6, hi2, ref A_31, ref A_32);
						if (A_26 > 1)
						{
							bool flag4;
							double num13 = default(double);
							double num14 = default(double);
							double a_2 = default(double);
							double a_3 = default(double);
							if (A_24[A_27] >= A_24[num12])
							{
								if (A_23[A_27] >= A_24[num12])
								{
									flag4 = false;
								}
								else
								{
									if (A_23[A_27] > A_23[num12])
									{
										num13 = A_23[A_27];
										num14 = A_24[num12];
										a_2 = A_23[num12];
										a_3 = A_24[A_27];
									}
									else
									{
										num13 = A_23[num12];
										num14 = A_24[num12];
										a_2 = A_23[A_27];
										a_3 = A_24[A_27];
									}
									flag4 = true;
								}
							}
							else if (A_23[num12] >= A_24[A_27])
							{
								flag4 = false;
							}
							else
							{
								if (A_23[A_27] >= A_23[num12])
								{
									num13 = A_23[A_27];
									num14 = A_24[A_27];
									a_2 = A_23[num12];
									a_3 = A_24[num12];
								}
								else
								{
									num13 = A_23[num12];
									num14 = A_24[A_27];
									a_2 = A_23[A_27];
									a_3 = A_24[num12];
								}
								flag4 = true;
							}
							if (flag4)
							{
								double a_4 = 1000000000.0 / (2.0 * A_12);
								if ((A_15[0] > num13) & (A_15[0] < num14))
								{
									int num15 = m2(a_2, a_3, 1, A_30, A_15, A_14, A_14[0], A_15[0], a_4, A_9, A_10, A_11);
									if (num15 != -1)
									{
										double num16 = p9(A_23[num12], A_24[num12], A_15[0]) + p9(A_23[A_27], A_24[A_27], A_15[num15]);
										double num17 = p9(A_23[num12], A_24[num12], A_15[num15]) + p9(A_23[A_27], A_24[A_27], A_15[0]);
										flag3 = ((!(num16 > num17)) ? m2(A_4, array[A_27], num12, A_27, num15, 0, A_15, array3, A_2, A_6, A_7, A_8, A_31, A_32) : m2(A_4, array[A_27], num12, A_27, 0, num15, A_15, array3, A_2, A_6, A_7, A_8, A_31, A_32));
									}
									else
									{
										flag3 = m2(A_4, array[A_27], num12, A_27, 0, 0, A_15, array3, A_2, A_6, A_7, A_8, A_31, A_32);
									}
								}
								else if ((A_15[0] > A_23[num12]) & (A_15[0] < A_24[num12]))
								{
									int num15 = m2(A_23[A_27], A_24[A_27], 1, A_30, A_15);
									flag3 = m2(A_4, array[A_27], num12, A_27, 0, num15, A_15, array3, A_2, A_6, A_7, A_8, A_31, A_32);
								}
								else if ((A_15[0] > A_23[A_27]) & (A_15[0] < A_24[A_27]))
								{
									int num15 = m2(A_23[num12], A_24[num12], 1, A_30, A_15);
									flag3 = m2(A_4, array[A_27], num12, A_27, num15, 0, A_15, array3, A_2, A_6, A_7, A_8, A_31, A_32);
								}
								else
								{
									flag3 = true;
								}
							}
							else
							{
								int a_5 = m2(A_23[num12], A_24[num12], 0, A_30, A_15);
								int a_6 = m2(A_23[A_27], A_24[A_27], 0, A_30, A_15);
								flag3 = m2(A_4, array[A_27], num12, A_27, a_5, a_6, A_15, array3, A_2, A_6, A_7, A_8, A_31, A_32);
							}
							m2(num4, array2, A_22, A_21, array3, A_5, A_13);
						}
						else
						{
							int num15 = m2(A_23[num12], A_24[num12], 0, A_30, A_15);
							flag3 = m2(A_4, array[A_27], num12, A_27, num15, -1, A_15, array3, A_2, A_6, A_7, A_8, A_31, A_32);
						}
					}
					if (flag3)
					{
						int num18 = num;
						for (int num19 = 1; num19 <= num18; num19++)
						{
							A_2[num19] = aq[num19] * 1E-09;
						}
					}
					m2(num10, A_11, ref A_3, A_9, A_10, A_5);
					if (!flag3)
					{
						result = false;
					}
				}
			}
			return result;
		}
	}

	protected bool m2(int A_0, ref short[] A_1, ref double[] A_2, ref double[] A_3, double[,] A_4, double[,] A_5, ref double A_6, ref int A_7, hg A_8, double[] A_9, int A_10, int A_11, double[] A_12, double[] A_13, int A_14, short A_15, bool A_16, float A_17)
	{
		double[] A_18 = null;
		double[] A_19 = null;
		double[] A_20 = null;
		double[] A_21 = new double[101];
		double[] A_22 = new double[101];
		bool[] A_23 = new bool[102];
		double[] A_24 = new double[5151];
		int[] A_25 = new int[5151];
		int[] A_26 = new int[5151];
		double[] A_27 = new double[5151];
		double[] A_28 = new double[5151];
		bool[] array = new bool[101];
		bool[] array2 = new bool[102];
		int[] array3 = new int[101];
		int[] array4 = new int[101];
		double[] array5 = new double[100];
		double[] array6 = new double[100];
		double[,] array7 = new double[100, 100];
		int[] array8 = new int[100];
		int[] array9 = new int[100];
		bool[] array10 = new bool[100];
		bool[] array11 = new bool[5151];
		int num = de[A_0];
		bool result = true;
		A_7 = 0;
		hi hi2 = A_8.b3(A_8.c2());
		int num2 = hi2.g7();
		double[] A_29 = new double[1];
		checked
		{
			_ = A_9[(int)Math.Round((double)(A_10 + A_11) / 2.0)];
			double a_ = 1.5 * (A_9[(int)Math.Round(Conversion.Int((double)(A_10 + A_11) / 2.0 + 0.5) + 1.0)] - A_9[(int)Math.Round(Conversion.Int((double)(A_10 + A_11) / 2.0 + 0.5))]);
			int A_30 = default(int);
			int A_31 = default(int);
			double A_32 = default(double);
			A_7 = m2(A_0, num2, A_4, A_5, ref A_30, ref A_31, A_22, A_21, ref A_32, ref A_23, ref A_1, A_10, A_11);
			if (A_7 != 0)
			{
				int A_33 = default(int);
				m2(num2, a_, A_4, A_7, A_32, ref A_21, ref A_22, ref A_29, ref A_33, ref A_25, ref A_26, ref A_27, ref A_28, ref A_24, A_9, A_10, A_11, ref A_1, ref A_2, array11);
				int num3 = num2 + 1;
				int num4 = num2;
				int num5 = 0;
				int num6 = 0;
				bool flag = true;
				do
				{
					bool flag2 = A_24[num5] >= 0.0;
					bool flag3 = (!array[A_26[num5]] | !array[A_25[num5]]) & flag2;
					bool flag4 = false;
					if (flag2)
					{
						int num7 = A_25[num5];
						int num8 = A_26[num5] - 1;
						for (int num9 = num7; num9 <= num8; num9++)
						{
							if (!array2[num9])
							{
								flag4 = true;
								break;
							}
						}
					}
					if (flag3 | flag4)
					{
						if (!array[A_26[num5]])
						{
							num3--;
							array[A_26[num5]] = true;
						}
						if (!array[A_25[num5]])
						{
							num3--;
							array[A_25[num5]] = true;
						}
						array3[num6] = num5;
						if (A_25[num5] != 0)
						{
							flag = false;
						}
						int num10 = A_25[num5];
						int num11 = A_26[num5] - 1;
						for (int num9 = num10; num9 <= num11; num9++)
						{
							if (!array2[num9])
							{
								array2[num9] = true;
								num4--;
							}
						}
						num6++;
					}
					num5++;
				}
				while ((num5 < A_33 - 1) & ((num3 > 0) | (num4 > 0)) & (num6 < num2));
				bool flag5 = false;
				int num12 = num6 - 1;
				for (num5 = 0; num5 <= num12; num5++)
				{
					int num13 = num6 - 1;
					for (int num14 = 0; num14 <= num13; num14++)
					{
						if (num14 != num5 && A_27[array3[num14]] < A_28[array3[num5]] && A_28[array3[num14]] > A_27[array3[num5]] && A_25[array3[num14]] != A_25[array3[num5]] && A_26[array3[num14]] != A_26[array3[num5]])
						{
							flag5 = true;
							break;
						}
					}
					if (flag5)
					{
						break;
					}
				}
				if ((A_30 > 100) | (num2 > 100))
				{
					ab8().c(fz.a.b, "FFTMaxNumLayerReachedFmt1", 100);
				}
				else
				{
					double[] array12 = new double[A_12.GetUpperBound(0) + 1];
					int upperBound = A_12.GetUpperBound(0);
					for (int num15 = 0; num15 <= upperBound; num15++)
					{
						array12[num15] = A_12[num15];
					}
					if (num6 == 1)
					{
						m2(hi2, A_9[A_10], A_9[A_10 + 1] - A_9[A_10], A_14, A_13, array12, double.MaxValue, A_4[A_7, unchecked(checked(A_10 + A_11) / 2)]);
					}
					int A_34 = default(int);
					m2(A_12, array12, A_13, A_14, ref A_18, ref A_19, ref A_20, ref A_34);
					bool flag6 = default(bool);
					double num19 = default(double);
					if (A_34 < num6)
					{
						flag6 = true;
					}
					else
					{
						double[] A_35 = null;
						double[] A_36 = null;
						m2(A_10, A_11, A_9, hi2, ref A_35, ref A_36);
						int num16;
						if (hi2.g7() > 1)
						{
							num16 = num6;
							if (A_30 == 1)
							{
								int num17 = A_33 - 1;
								for (num5 = 0; num5 <= num17 && (A_25[num5] + 1 > A_7 || A_26[num5] < A_7); num5++)
								{
								}
								bool flag7 = true;
								int num18 = num5 - 1;
								for (int num14 = 0; num14 <= num18; num14++)
								{
									if ((A_27[num14] < A_28[num5] && A_27[num14] > A_27[num5]) || (A_28[num14] < A_28[num5] && A_28[num14] > A_27[num5]))
									{
										flag7 = false;
										break;
									}
								}
								if (flag7)
								{
									num16 = 1;
									A_25[0] = A_25[num5];
									A_26[0] = A_26[num5];
									A_24[0] = A_24[num5];
									A_27[0] = A_27[num5];
									A_28[0] = A_28[num5];
									array11[0] = false;
								}
							}
						}
						else
						{
							num16 = 1;
						}
						if (num16 > 1)
						{
							num19 = 0.0;
							int num20 = num6 - 1;
							for (num5 = 0; num5 <= num20; num5++)
							{
								if (A_28[array3[num5]] > num19)
								{
									num19 = A_28[array3[num5]];
								}
							}
							num19 = num19;
							double num21 = 0.0;
							int num22 = num6 - 1;
							for (num5 = 0; num5 <= num22; num5++)
							{
								if (A_24[array3[num5]] > num21)
								{
									num21 = A_24[array3[num5]];
								}
							}
							_ = A_18[0];
							m2(A_34, A_18, A_19, A_20);
							int num23 = num2 - 1;
							for (int num24 = 0; num24 <= num23; num24++)
							{
								if (A_1[(num24 + 1) * 4 + 0] == 0)
								{
									array6[num24] = aq[num + num24] * A_4[num24, (int)Math.Round((double)(A_10 + A_11) / 2.0)];
								}
							}
							double num25 = A_27[0];
							double num26 = A_28[0];
							int num27 = num6 - 1;
							for (num5 = 1; num5 <= num27; num5++)
							{
								if (A_27[num5] < num25)
								{
									num25 = A_27[num5];
								}
								if (A_28[num5] > num26)
								{
									num26 = A_28[num5];
								}
							}
							int num28 = 1;
							bool flag8 = false;
							int num29 = 0;
							int num41 = default(int);
							double A_38 = default(double);
							double A_39 = default(double);
							double A_40 = default(double);
							double A_41 = default(double);
							double A_42 = default(double);
							double A_43 = default(double);
							bool flag14 = default(bool);
							do
							{
								A_29 = new double[100];
								if (flag | !flag5)
								{
									bool[] array13 = new bool[A_34 - 1 + 1];
									int num30 = num6 - 1;
									for (num5 = 0; num5 <= num30; num5++)
									{
										array8[num5] = array3[num5];
									}
									int num36;
									if (flag)
									{
										int num31 = num6 - 1;
										for (num5 = 0; num5 <= num31; num5++)
										{
											int num32 = num6 - 1;
											int num33 = num5 + 1;
											for (int num34 = num32; num34 >= num33; num34 += -1)
											{
												if (A_28[array8[num34]] > A_28[array8[num34 - 1]])
												{
													int num35 = array8[num34 - 1];
													array8[num34 - 1] = array8[num34];
													array8[num34] = num35;
												}
											}
										}
										num36 = 0;
									}
									else
									{
										int num37 = num6 - 1;
										for (num5 = 0; num5 <= num37; num5++)
										{
											int num38 = num6 - 1;
											int num39 = num5 + 1;
											for (int num34 = num38; num34 >= num39; num34 += -1)
											{
												if (A_28[array8[num34]] < A_28[array8[num34 - 1]])
												{
													int num35 = array8[num34 - 1];
													array8[num34 - 1] = array8[num34];
													array8[num34] = num35;
												}
											}
										}
										num36 = 1;
									}
									int num40 = 0;
									num5 = 0;
									do
									{
										if (!array13[num5] & (A_19[num5] >= num25) & (A_19[num5] <= num26))
										{
											num40++;
										}
										num5++;
									}
									while ((num40 < num6 - num41) & (num5 < A_34));
									if (num40 < num6 - num41)
									{
										flag6 = true;
									}
									if (!flag6)
									{
										int num42 = num6 - 1;
										for (num41 = 0; num41 <= num42; num41++)
										{
											bool flag9 = false;
											bool[] array14 = new bool[A_34 - 1 + 1];
											if (num41 < num6 - 1)
											{
												bool A_37;
												if (flag)
												{
													int a_2 = A_26[array8[num41]] - 1;
													int a_3 = A_7;
													double[] a_4 = A_29;
													short[] a_5 = A_1;
													double[] a_6 = A_2;
													A_37 = false;
													m2(ref A_38, ref A_39, ref A_40, 0, a_2, A_4, a_3, a_4, A_9, A_10, A_11, a_5, a_6, ref A_37);
												}
												else
												{
													int a_7 = A_25[array8[num41 + 1]];
													int a_8 = A_26[array8[num41 + 1]];
													int a_9 = A_7;
													double[] a_10 = A_29;
													short[] a_11 = A_1;
													double[] a_12 = A_2;
													A_37 = false;
													m2(ref A_41, ref A_38, ref A_40, a_7, a_8, A_4, a_9, a_10, A_9, A_10, A_11, a_11, a_12, ref A_37);
												}
												int a_13 = A_26[array8[num41]] - 1;
												int a_14 = A_26[array8[num41]];
												int a_15 = A_7;
												double[] a_16 = A_29;
												short[] a_17 = A_1;
												double[] a_18 = A_2;
												A_37 = false;
												m2(ref A_42, ref A_38, ref A_40, a_13, a_14, A_4, a_15, a_16, A_9, A_10, A_11, a_17, a_18, ref A_37);
											}
											while (!flag9 & !flag6)
											{
												double num43;
												double num44;
												if (flag)
												{
													num43 = num25;
													num44 = num26;
												}
												else
												{
													num43 = A_27[array8[num41]];
													num44 = A_28[array8[num41]];
												}
												num40 = 0;
												num5 = 0;
												do
												{
													if (!array13[num5] & !array14[num5] & (A_19[num5] >= num43) & (A_19[num5] <= num44))
													{
														array9[num40] = num5;
														num40++;
													}
													num5++;
												}
												while ((num40 < num6 - num41 + num36) & (num5 < A_34));
												bool flag10;
												if (num40 < 1)
												{
													if (array11[array8[num41]])
													{
														flag10 = true;
													}
													else
													{
														flag6 = true;
													}
												}
												if (flag6)
												{
													continue;
												}
												if (flag)
												{
													int num45 = num40 - 1;
													for (num5 = 0; num5 <= num45; num5++)
													{
														int num46 = num40 - 1;
														int num47 = num5 + 1;
														for (int num34 = num46; num34 >= num47; num34 += -1)
														{
															if (A_19[array9[num34]] > A_19[array9[num34 - 1]])
															{
																int num35 = array9[num34 - 1];
																array9[num34 - 1] = array9[num34];
																array9[num34] = num35;
															}
														}
													}
												}
												else
												{
													int num48 = num40 - 1;
													for (num5 = 0; num5 <= num48; num5++)
													{
														int num49 = num40 - 1;
														int num50 = num5 + 1;
														for (int num34 = num49; num34 >= num50; num34 += -1)
														{
															if (A_19[array9[num34]] < A_19[array9[num34 - 1]])
															{
																int num35 = array9[num34 - 1];
																array9[num34 - 1] = array9[num34];
																array9[num34] = num35;
															}
														}
													}
												}
												flag10 = false;
												double num51 = -1.0;
												int num52 = 0;
												if (num41 < A_33 - 1)
												{
													int num53 = num40 - 1;
													for (num5 = 0; num5 <= num53; num5++)
													{
														if (flag)
														{
															if ((A_18[array9[num5]] > num51) & (A_19[array9[num5]] > A_28[array8[num41 + 1]]))
															{
																num52 = num5;
																num51 = A_18[array9[num5]];
															}
														}
														else if ((A_18[array9[num5]] > num51) & ((num41 + 1 == num6) | (A_19[array9[num5]] < A_27[array8[num41 + 1]])))
														{
															num52 = num5;
															num51 = A_18[array9[num5]];
														}
													}
													if (num52 != 0)
													{
														int num35 = array9[num52];
														array9[num52] = array9[0];
														array9[0] = num35;
													}
												}
												if ((A_19[array9[0]] < A_28[array8[num41]] && A_19[array9[0]] > A_27[array8[num41]]) || array11[array8[num41]])
												{
													if (num41 < num6 - 1)
													{
														if (num40 > 1)
														{
															if (flag & (((A_19[array9[0]] > A_39) & (A_19[array9[1]] > A_39)) | (A_19[array9[0]] - A_19[array9[1]] < A_42)))
															{
																if (A_18[array9[0]] < A_18[array9[1]])
																{
																	array13[array9[0]] = true;
																}
																else
																{
																	array13[array9[1]] = true;
																}
															}
															else
															{
																flag10 = true;
															}
														}
														else
														{
															flag10 = true;
														}
													}
													else if (flag)
													{
														if (array11[array8[num41]])
														{
															array5[array8[num41]] = A_27[array8[num41]] / 0.95;
														}
														else
														{
															array5[array8[num41]] = A_19[array9[0]] - A_36[A_25[array8[num41]]] - A_35[A_26[array8[num41]] + 1];
														}
														flag9 = true;
													}
													else
													{
														flag10 = true;
													}
												}
												else
												{
													array14[array9[0]] = true;
												}
												if (!(!flag9 & flag10))
												{
													continue;
												}
												bool flag11 = false;
												if (num41 < num6 - 1)
												{
													bool flag12 = num40 > 1 && Math.Abs(A_19[array9[0]] - A_19[array9[1]]) < 4.0 * A_20[array9[0]] && (flag ? ((A_19[array9[1]] < A_28[array8[num41 + 1]]) ? true : false) : ((A_19[array9[1]] > A_27[array8[num41 + 1]]) ? true : false));
													double num54 = ((!(A_24[array8[num41]] > 0.0)) ? (1.0 / 30.0) : ((!(A_24[array8[num41 + 1]] > 0.0)) ? 30.0 : (A_24[array8[num41]] / A_24[array8[num41 + 1]])));
													if (flag12)
													{
														double num55 = A_18[array9[0]] / A_18[array9[1]];
														if (num55 < num54)
														{
															if (num54 / num55 > 5.0)
															{
																flag11 = true;
															}
														}
														else if (num55 / num54 > 5.0)
														{
															flag11 = true;
														}
													}
													if (flag11)
													{
														if (A_18[array9[0]] < A_18[array9[1]])
														{
															array14[array9[0]] = true;
														}
														else
														{
															array14[array9[1]] = true;
														}
														continue;
													}
													if (array11[array8[num41]])
													{
														array5[array8[num41]] = A_27[array8[num41]] / 0.95;
													}
													else
													{
														array5[array8[num41]] = A_19[array9[0]] - A_36[A_25[array8[num41]]] - A_35[A_26[array8[num41]] + 1];
													}
													if (num40 > 0)
													{
														array13[array9[0]] = true;
													}
													if (flag)
													{
														double num56 = ((!array11[array8[num41]]) ? (array5[array8[num41]] - 1.2 * A_20[array9[0]]) : (A_27[array8[num41]] / 0.95 - 1.2 * A_20[0]));
														if (num56 > A_39)
														{
															num56 = A_39;
														}
														int num57 = A_34 - 1;
														for (num5 = 0; num5 <= num57; num5++)
														{
															if (A_19[num5] > num56)
															{
																array13[num5] = true;
															}
														}
													}
													else
													{
														double num58 = ((!array11[array8[num41]]) ? (array5[array8[num41]] + 3.0 * A_20[array9[0]]) : (A_27[array8[num41]] / 0.95 + 3.0 * A_20[0]));
														if (num58 < A_41)
														{
															num58 = A_39;
														}
														int num59 = A_34 - 1;
														for (num5 = 0; num5 <= num59; num5++)
														{
															if (A_19[num5] < num58)
															{
																array13[num5] = true;
															}
														}
													}
													flag9 = true;
												}
												else
												{
													if (array11[array8[num41]])
													{
														array5[array8[num41]] = A_27[array8[num41]] / 0.95;
													}
													else
													{
														array5[array8[num41]] = A_19[array9[0]] - A_36[A_25[array8[num41]]] - A_35[A_26[array8[num41]] + 1];
													}
													flag9 = true;
												}
											}
											if (!(flag & (num41 < A_33 - 1)))
											{
												continue;
											}
											if (array11[array8[num41]])
											{
												A_29[A_26[array8[num41]] - 1] = A_27[array8[num41]] / 0.95;
											}
											else
											{
												A_29[A_26[array8[num41]] - 1] = array5[array8[num41]];
											}
											int num60 = num41 + 1;
											int num61 = num6 - 1;
											for (num5 = num60; num5 <= num61; num5++)
											{
												ref double a_19 = ref A_27[array8[num5]];
												ref double a_20 = ref A_28[array8[num5]];
												int a_21 = A_25[array8[num5]];
												int a_22 = A_26[array8[num5]];
												int a_23 = A_7;
												double[] a_24 = A_29;
												short[] a_25 = A_1;
												double[] a_26 = A_2;
												bool A_37 = false;
												m2(ref a_19, ref a_20, ref A_43, a_21, a_22, A_4, a_23, a_24, A_9, A_10, A_11, a_25, a_26, ref A_37);
											}
											num25 = A_27[array8[num41 + 1]];
											num26 = A_28[array8[num41 + 1]];
											int num62 = num41 + 2;
											int num63 = num6 - 1;
											for (num5 = num62; num5 <= num63; num5++)
											{
												if (A_27[array8[num5]] < num25)
												{
													num25 = A_27[array8[num5]];
												}
												if (A_28[array8[num5]] > num26)
												{
													num26 = A_28[array8[num5]];
												}
											}
										}
									}
								}
								else
								{
									bool[] array14 = new bool[A_34 - 1 + 1];
									int num64 = num6 - 1;
									for (num5 = 0; num5 <= num64; num5++)
									{
										int num65 = 0;
										int num66;
										int num67;
										if (flag8)
										{
											num66 = array4[num5];
											num67 = num66;
										}
										else
										{
											num66 = array3[num5];
											num67 = num66;
											int num68 = num67 - 1;
											for (int num69 = 0; num69 <= num68; num69++)
											{
												if (!array14[num69])
												{
													num67 = num69;
													break;
												}
											}
										}
										bool flag13 = false;
										while (!flag13 & (num66 + num65 < A_34))
										{
											if ((A_19[num67 + num65] >= A_27[num66]) & (A_19[num67 + num65] <= A_28[num66]) & !array14[num67 + num65])
											{
												if (array11[num66])
												{
													array5[num66] = A_27[num66] / 0.95;
												}
												else
												{
													array5[num66] = A_19[num67 + num65] - A_36[A_25[num66]] - A_35[A_26[num66] + 1];
												}
												flag13 = true;
												array14[num67 + num65] = true;
											}
											else
											{
												num65++;
											}
										}
										if (!flag13 && array11[num66])
										{
											flag13 = true;
											array5[num66] = A_27[num66] / 0.95;
										}
									}
								}
								if (flag6)
								{
									continue;
								}
								int num70 = num6 - 1;
								for (num5 = 0; num5 <= num70; num5++)
								{
									int num66 = array3[num5];
									int num71 = num2 - 1;
									for (int num24 = 0; num24 <= num71; num24++)
									{
										if ((num24 >= A_25[num66]) & (num24 < A_26[num66]))
										{
											double num72 = 1.0 + (A_4[A_7, A_10] - A_4[A_7, A_11]) / (A_9[A_10] - A_9[A_11]) * 0.5 * (A_9[A_10] + A_9[A_11]) / A_4[A_7, (int)Math.Round((double)(A_10 + A_11) / 2.0)] - (A_4[num24 + 1, A_10] - A_4[num24 + 1, A_11]) / (A_9[A_10] - A_9[A_11]) * 0.5 * (A_9[A_10] + A_9[A_11]) / A_4[num24 + 1, (int)Math.Round((double)(A_10 + A_11) / 2.0)];
											array7[num5, num24] = num72 * A_4[num24 + 1, (int)Math.Round((double)(A_10 + A_11) / 2.0)] / A_32;
											array10[num24] = true;
										}
										else
										{
											array7[num5, num24] = 0.0;
										}
									}
								}
								if (num6 < num2)
								{
									int num73 = 0;
									int num74 = num2 - 1;
									for (int num24 = 0; num24 <= num74; num24++)
									{
										if (array10[num24])
										{
											num73++;
											continue;
										}
										int num75 = num6 - 1;
										for (num5 = 0; num5 <= num75; num5++)
										{
											int num76 = num24 + 1;
											int num77 = num2 - 1;
											for (int num78 = num76; num78 <= num77; num78++)
											{
												array7[num5, num73 + num78 - (num24 + 1)] = array7[num5, num78];
											}
										}
									}
								}
								double[] array15 = new double[100];
								int num79 = num6 - 1;
								for (int num80 = 0; num80 <= num79; num80++)
								{
									array15[num80] = array5[array3[num80]];
								}
								if (jf.a(array7, num6, array15, array6) != 0)
								{
									ab8().c(fz.a.b, "FFTMeasureError");
								}
								if (num6 < num2)
								{
									int num73 = num6 - 1;
									for (int num24 = num2 - 1; num24 >= 0; num24 += -1)
									{
										if (array10[num24])
										{
											array6[num24] = array6[num73];
											num73--;
										}
										else
										{
											array6[num24] = 0.0;
										}
									}
								}
								flag14 = true;
								int num81 = num2 - 1;
								for (int num24 = 0; num24 <= num81; num24++)
								{
									if (array10[num24] & ((array6[num24] < A_2[(num24 + 1) * 6 + 0] * 1000000000.0) | (array6[num24] > A_2[(num24 + 1) * 6 + 1] * 1000000000.0)))
									{
										flag14 = false;
									}
								}
								if (!flag14 & !(flag | !flag5))
								{
									flag8 = true;
									int num82 = num6 - 1;
									for (num5 = 0; num5 <= num82; num5++)
									{
										array4[num5] = array3[num5];
									}
									int num83 = num6 - 2;
									for (num5 = 0; num5 <= num83; num5++)
									{
										if (((int)Math.Round(Math.Pow(2.0, num5)) & num28) != 0)
										{
											int num35 = array4[num5];
											array4[num5] = array4[num5 + 1];
											array4[num5 + 1] = num35;
										}
									}
									num28 *= 2;
								}
								num29++;
							}
							while (!flag & !flag14 & ((double)num28 < Math.Pow(2.0, num6)) & (num29 < A_34) & !flag6);
							if (!flag14)
							{
								flag6 = true;
							}
							int num84 = num2 - 1;
							for (int num24 = 0; num24 <= num84; num24++)
							{
								if (A_1[(num24 + 1) * 4 + 0] != 0)
								{
									A_3[num24 + 1] = array6[num24] * 1E-09;
								}
							}
							m2(num6, array3, A_26, A_25, array5, A_8, A_15);
						}
						else
						{
							double num85 = A_27[0];
							num19 = A_28[0];
							List<int> list = null;
							List<float> list2 = null;
							float num86 = default(float);
							if (A_16)
							{
								list = new List<int>();
								list2 = new List<float>();
								num86 = (float)((double)A_17 * 0.01);
							}
							int num87 = A_34 - 1;
							double num89 = default(double);
							int num90 = default(int);
							bool flag15 = default(bool);
							float num91 = default(float);
							for (num5 = 0; num5 <= num87; num5++)
							{
								if (!((A_19[num5] > num85) & (A_19[num5] < num19)))
								{
									continue;
								}
								double num88 = A_18[num5];
								if (num88 > num89)
								{
									num89 = num88;
									num90 = num5;
									flag15 = true;
									if (A_16)
									{
										num91 = (float)(num89 * (double)num86);
										for (int num92 = list2.Count - 1; num92 >= 0; num92 += -1)
										{
											if (list2[num92] < num91)
											{
												list2.RemoveAt(num92);
												list.RemoveAt(num92);
											}
										}
									}
								}
								if (A_16 && num88 > (double)num91)
								{
									list2.Add((float)num88);
									list.Add(num5);
								}
							}
							if (A_16 && list.Count > 0)
							{
								num90 = list[list.Count - 1];
								cm = true;
							}
							if (flag15)
							{
								A_3[A_7] = (A_19[num90] - A_36[A_25[0]] - A_35[A_26[0] + 1]) * 1E-09;
								int num93 = A_25[0] + 1;
								int num94 = A_26[0];
								for (int num24 = num93; num24 <= num94; num24++)
								{
									if (num24 != A_7)
									{
										double num72 = 1.0 + (A_4[A_7, A_10] - A_4[A_7, A_11]) / (A_9[A_10] - A_9[A_11]) * 0.5 * (A_9[A_10] + A_9[A_11]) / A_4[A_7, (int)Math.Round((double)(A_10 + A_11) / 2.0)] - (A_4[num24 + 1, A_10] - A_4[num24 + 1, A_11]) / (A_9[A_10] - A_9[A_11]) * 0.5 * (A_9[A_10] + A_9[A_11]) / A_4[num24 + 1, (int)Math.Round((double)(A_10 + A_11) / 2.0)];
										A_3[A_7] -= aq[num + num24] * 1E-09 * num72 * A_4[num24 + 1, (int)Math.Round((double)(A_10 + A_11) / 2.0)] / A_32;
									}
								}
							}
						}
					}
					if (flag6)
					{
						int num95 = num2;
						for (int num24 = 1; num24 <= num95; num24++)
						{
							A_3[num24] = aq[num + num24] * 1E-09;
						}
					}
					if (num2 == 1)
					{
						double a_27 = A_3[A_7] * 1000000.0;
						int upperBound2 = A_12.GetUpperBound(0);
						for (int num96 = 0; num96 <= upperBound2; num96++)
						{
							array12[num96] = A_12[num96];
						}
						m2(hi2, A_9[A_10], A_9[A_10 + 1] - A_9[A_10], A_14, A_13, array12, a_27, A_4[A_7, unchecked(checked(A_10 + A_11) / 2)]);
					}
					m2(num19, A_14, ref A_6, array12, A_13, A_8);
					if (!flag6)
					{
						result = false;
					}
				}
			}
			return result;
		}
	}

	protected void m2(int A_0, int A_1, double[] A_2, hi A_3, ref double[] A_4, ref double[] A_5)
	{
		checked
		{
			A_4 = new double[A_3.g7() + 1 + 1];
			A_5 = new double[A_3.g7() + 1 + 1];
			eo.b a_ = new eo.b(A_0: false, A_1: true, A_2: false, A_3: false);
			int num = A_3.g7() + 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (num2 > 0 && A_3.eu(num2 - 1).af(a_))
				{
					double num3 = ah[num2 - 1, A_0] - ah[num2, A_0] - (ah[num2 - 1, A_1] - ah[num2, A_1]);
					double num4 = an[num2 - 1, A_0] - an[num2, A_0] - (an[num2 - 1, A_1] - an[num2, A_1]);
					if (num4 != 0.0 && Math.Abs(num3 / num4) < 50.0)
					{
						A_4[num2] = m2(num2 - 1, num2, A_0, A_1, A_2);
					}
				}
				if (num2 < A_3.g7() + 1 && A_3.eu(num2 + 1).af(a_))
				{
					double num3 = ah[num2 + 1, A_0] - ah[num2, A_0] - (ah[num2 + 1, A_1] - ah[num2, A_1]);
					double num4 = an[num2 + 1, A_0] - an[num2, A_0] - (an[num2 + 1, A_1] - an[num2, A_1]);
					if (num4 != 0.0 && Math.Abs(num3 / num4) < 50.0)
					{
						A_5[num2] = m2(num2 + 1, num2, A_0, A_1, A_2);
					}
				}
			}
		}
	}

	protected double m2(int A_0, int A_1, int A_2, int A_3, double[] A_4)
	{
		double num = Math.PI * 2.0 * ah[A_0, A_2] / A_4[A_2];
		double num2 = num * num;
		double num3 = Math.PI * 2.0 * an[A_0, A_2] / A_4[A_2];
		double num4 = num3 * num3;
		double num5 = Math.PI * 2.0 * ah[A_1, A_2] / A_4[A_2];
		double num6 = Math.PI * 2.0 * an[A_1, A_2] / A_4[A_2];
		double num7 = 2.0 * (num2 + num4);
		double num8 = (num4 + num3 * num6 + num2 + num * num5) / num7;
		double num9 = (num5 * num3 - num6 * num) / num7;
		double num10 = 1.0 - num8;
		double num11 = 0.0 - num9;
		double num12 = Math.Atan2(num8 * num11 - num9 * num10, num8 * num10 + num9 * num11);
		num = Math.PI * 2.0 * ah[A_0, A_3] / A_4[A_3];
		num2 = num * num;
		num3 = Math.PI * 2.0 * an[A_0, A_3] / A_4[A_3];
		num4 = num3 * num3;
		num5 = Math.PI * 2.0 * ah[A_1, A_3] / A_4[A_3];
		num6 = Math.PI * 2.0 * an[A_1, A_3] / A_4[A_3];
		num7 = 2.0 * (num2 + num4);
		num8 = (num4 + num3 * num6 + num2 + num * num5) / num7;
		num9 = (num5 * num3 - num6 * num) / num7;
		num10 = 1.0 - num8;
		num11 = 0.0 - num9;
		double num13 = Math.Atan2(num8 * num11 - num9 * num10, num8 * num10 + num9 * num11);
		double num14 = num12 - num13;
		if (Math.Abs(num14) > Math.PI)
		{
			num14 -= Math.PI * 2.0 * Math.Round(num14 / (Math.PI * 2.0));
		}
		return num14 / (Math.PI * 4.0 * (ah[A_0, A_3] / A_4[A_3] - ah[A_0, A_2] / A_4[A_2]));
	}

	protected void m2(int A_0, ref int A_1, double[] A_2, double[,] A_3, double[,] A_4, hg A_5, double[] A_6, double[] A_7, double[] A_8, short A_9, int A_10, int A_11, double[] A_12, double[] A_13, double[] A_14, hr.b A_15, bool A_16, int A_17, double[] A_18, short[] A_19, bool A_20, [Optional][DefaultParameterValue(0f)] ref float A_21, [Optional][DefaultParameterValue(false)] ref bool A_22, [Optional][DefaultParameterValue(false)] ref bool A_23)
	{
		_ = new double[8];
		double[] array = new double[101];
		int num = de[A_0];
		ct = (f6.e)0;
		hi hi2 = A_5.b3(A_5.c2());
		int num2 = hi2.g7();
		checked
		{
			gc[] array2 = new gc[num2 + 1];
			bool A_24;
			if (A_1 == 0)
			{
				A_24 = true;
				A_1 = 1;
			}
			else
			{
				A_24 = false;
			}
			m2(A_3, A_4, A_5, A_6, A_9);
			_ = num2 - 1;
			int num3 = A_11 - A_10 + 1;
			int num4 = (int)Math.Round(0.5 * (double)(A_11 + A_10));
			int num5 = num2;
			for (int num6 = 1; num6 <= num5; num6++)
			{
				array[num6] = aq[num + num6];
			}
			int A_25 = 0;
			int A_26 = 0;
			eo.b a_ = new eo.b(A_0: true, A_1: false, A_2: false, A_3: false);
			int num7 = num2;
			for (int num6 = 1; num6 <= num7; num6++)
			{
				array2[num6] = hi2.eu(num6);
				if (!array2[num6].af(a_))
				{
					continue;
				}
				if (A_25 == 0)
				{
					A_25 = num6;
					A_26 = num6;
					continue;
				}
				if (A_25 == A_26)
				{
					if (array[num6] * A_3[num6, num4] > array[A_25] * A_3[A_25, num4])
					{
						A_25 = num6;
					}
					else
					{
						A_26 = num6;
					}
					continue;
				}
				if (array[num6] * A_3[num6, num4] > array[A_25] * A_3[A_25, num4])
				{
					A_25 = num6;
				}
				if (array[num6] * A_3[num6, num4] < array[A_26] * A_3[A_25, num4])
				{
					A_26 = num6;
				}
			}
			bool A_27 = default(bool);
			if (A_17 > 1)
			{
				A_23 = true;
				if (A_17 == 2)
				{
					float num8 = (float)Math.Abs(A_3[A_25, A_10] - A_3[A_25, A_11]);
					float num9 = (float)Math.Abs(A_3[A_26, A_10] - A_3[A_26, A_11]);
					float num10 = ((!(num8 > num9)) ? ((num9 + 0.1f) / (num8 + 0.1f)) : ((num8 + 0.1f) / (num9 + 0.1f)));
					A_27 = array[A_25] * A_3[A_25, num4] < 4000.0 * A_6[num4] / 600.0 * (double)num10 || array[A_26] * A_3[A_25, num4] < 2000.0 * A_6[num4] / 600.0 * (double)num10;
				}
				else
				{
					A_27 = false;
				}
			}
			double A_28 = default(double);
			if (A_23)
			{
				if (A_27)
				{
					float num11 = (float)(array[A_26] * (1.0 + array2[A_26].av() * 0.01));
					array[A_26] *= 1.0 - array2[A_26].av() * 0.01;
					if (array[A_26] < 0.0)
					{
						array[A_26] = 0.0;
					}
					float num12 = (float)(0.05 * A_6[A_10] / A_3[A_26, num4]);
					float num13 = 1E+30f;
					A_1 = A_25;
					float num14 = default(float);
					do
					{
						m2(A_0, ref A_1, ref A_24, num2, A_2, A_3, A_4, ref A_25, ref A_26, ref A_28, ref A_22, hi2, ref A_21, ref A_27, A_5, A_6, A_7, A_8, A_9, A_14, A_15, A_16, array, A_10, A_11, A_12, A_20);
						if (!cq && ct == (f6.e)0)
						{
							if (A_28 < (double)num13)
							{
								num13 = (float)A_28;
								num14 = (float)array[A_26];
							}
							array[A_26] += num12;
							continue;
						}
						return;
					}
					while (!(array[A_26] >= (double)num11));
					array[A_26] = num14;
					A_2[A_26] = (double)num14 * 1E-09;
					m2(A_0, ref A_1, ref A_24, num2, A_2, A_3, A_4, ref A_25, ref A_26, ref A_28, ref A_22, hi2, ref A_21, ref A_27, A_5, A_6, A_7, A_8, A_9, A_14, A_15, A_16, array, A_10, A_11, A_12, A_20);
					if (cq)
					{
						return;
					}
					if (array2[A_25].ai() == 0.0)
					{
						A_18[6 * A_25 + 1] = 2.0 * array[A_25] * 9.999999717180685E-10 + 9.999999717180685E-10;
					}
					_ = null;
					if (array[A_25] * 9.999999717180685E-10 < A_18[6 * A_25 + 0])
					{
						array[A_25] = (float)(A_18[6 * A_25 + 0] * 1000000000.0);
					}
					if (array[A_25] * 9.999999717180685E-10 > A_18[6 * A_25 + 1])
					{
						array[A_25] = (float)(A_18[6 * A_25 + 1] * 1000000000.0);
					}
					m2(A_0, ref A_26, ref A_24, num2, A_2, A_3, A_4, ref A_26, ref A_26, ref A_28, ref A_22, hi2, ref A_21, ref A_27, A_5, A_6, A_7, A_8, A_9, A_14, A_15, A_16, array, A_10, A_11, A_12, A_20);
					if (cq)
					{
						return;
					}
					if (array2[A_26].ai() == 0.0)
					{
						A_18[6 * A_26 + 1] = 2.0 * array[A_26] * 9.999999717180685E-10 + 9.999999717180685E-10;
					}
					_ = null;
					if (array[A_26] * 9.999999717180685E-10 < A_18[6 * A_26 + 0])
					{
						array[A_26] = (float)(A_18[6 * A_26 + 0] * 1000000000.0);
					}
					if (array[A_26] * 9.999999717180685E-10 > A_18[6 * A_26 + 1])
					{
						array[A_26] = (float)(A_18[6 * A_26 + 0] * 1000000000.0);
					}
				}
				else
				{
					A_2[0] = 1.0;
					int num15 = hi2.g7();
					for (int num16 = 1; num16 <= num15; num16++)
					{
						gc gc2 = array2[num16];
						if ((gc2.ai() == 0.0) & gc2.af(a_))
						{
							A_18[6 * num16 + 0] = 0.0005000000237487257;
						}
						gc2 = null;
					}
					int num17 = hi2.g7() + 2;
					int num18 = hi2.g7() + 1;
					double[] array3 = new double[num17 * num3 - 1 + 1];
					int num19 = num3 - 1;
					int num20 = num18;
					for (int num16 = 0; num16 <= num20; num16++)
					{
						int num21 = num19;
						for (int num6 = 0; num6 <= num21; num6++)
						{
							array3[num16 * num3 + num6] = A_3[num16, A_10 + num6];
						}
					}
					double A_29 = default(double);
					short A_30 = default(short);
					int A_31 = default(int);
					short A_32 = default(short);
					f6.FFTPrepare((short)num3, ref A_13[0], (short)(hi2.g7() + 2), ref A_2[0], ref A_19[0], ref array3[0], ref A_18[0], ref A_29, ref A_30, 2048, ref A_31, ref A_32);
					double[] array4 = new double[A_31 + 1];
					double A_33 = default(double);
					int num22 = f6.FFTStreamlined2((short)num3, ref A_13[0], ref A_14[0], ref array3[0], A_31, A_32, A_30, 1, 0.0, 0, ref array4[0], ref A_33);
					if (num22 != 0)
					{
						throw new ApplicationException("Error attempting to call FFTStreamlined in SolveForT. Error code=" + num22);
					}
					int num23 = (int)Math.Round(2.0 * A_29 / A_33);
					if (num23 > A_31)
					{
						num23 = A_31;
					}
					double[] array5 = new double[num23 + 1];
					A_33 *= 1000000.0;
					int num24 = num23 - 1;
					for (int num6 = 0; num6 <= num24; num6++)
					{
						array5[num6] = A_33 * (double)num6;
					}
					if (m2(A_0, ref A_19, ref A_18, ref A_2, A_3, A_4, ref ci, ref A_25, A_5, A_6, A_10, A_11, array4, array5, num23, 5, A_16: false, 0f))
					{
						ab8().c(fz.a.b, "MeasErrorFFTPeakIdFailure");
						return;
					}
					int num25 = hi2.g7();
					for (int num16 = 1; num16 <= num25; num16++)
					{
						if (array2[num16].af(a_))
						{
							array[num16] = A_2[num16] * 1000000000.0;
						}
						_ = null;
					}
					int num26 = hi2.g7();
					for (int num16 = 1; num16 <= num26; num16++)
					{
						gc gc3 = array2[num16];
						if (((gc3.ai() == 0.0) & gc3.af(a_)) && num16 != A_26)
						{
							A_18[6 * num16 + 1] = 2.0 * A_2[num16] * 9.999999717180685E-10 + 9.999999717180685E-10;
						}
						gc3 = null;
					}
				}
			}
			else
			{
				m2(A_0, ref A_1, ref A_24, num2, A_2, A_3, A_4, ref A_25, ref A_26, ref A_28, ref A_22, hi2, ref A_21, ref A_27, A_5, A_6, A_7, A_8, A_9, A_14, A_15, A_16, array, A_10, A_11, A_12, A_20);
				if (cq)
				{
					return;
				}
			}
			int num27 = hi2.g7();
			for (int num16 = 1; num16 <= num27; num16++)
			{
				if (array2[num16].af(a_))
				{
					A_2[num16] = array[num16] * 9.999999717180685E-10;
					if (jf.d(A_2[num16], A_18[6 * num16 + 0]))
					{
						A_2[num16] = jf.b((float)A_18[6 * num16 + 0]);
					}
					if (jf.b(A_2[num16], A_18[6 * num16 + 1]))
					{
						A_2[num16] = jf.a((float)A_18[6 * num16 + 1]);
					}
				}
				_ = null;
			}
		}
	}

	protected float m2(ref m A_0, short A_1, ref short[] A_2, ref short[] A_3, short A_4, short A_5, bool A_6, double A_7, double A_8, bool A_9, int A_10, ref int A_11, ref int A_12, ref double A_13, ref double A_14, ref double A_15, int A_16, float A_17, float A_18, hi A_19, short A_20, ref double[] A_21, ref double[] A_22, ref double[] A_23, ref double[] A_24, ref double[] A_25, ref short[] A_26, short A_27, bool A_28, short A_29, float[] A_30, short[] A_31, int A_32, eo.a A_33, bool A_34)
	{
		float num = -100f;
		checked
		{
			int num2 = A_16 - 1;
			float num5 = default(float);
			for (int num3 = 0; num3 <= num2; num3++)
			{
				az[A_5] = (A_17 + (float)num3 * A_18) / 1E+09f;
				float num4 = m2(ref A_0, A_1, ref A_2, ref A_3, A_4, A_5, A_6: false, A_7, A_8, A_9: false, A_10, ref A_11, ref A_12, ref A_13, ref A_14, ref A_15, A_19, A_20, ref A_21, ref A_22, ref A_23, ref A_24, ref A_25, ref A_26, A_27, A_28, A_29, A_30, ref A_31, A_32, A_33, A_34);
				if (num4 > num)
				{
					num = num4;
					num5 = (float)az[A_5];
				}
			}
			az[A_5] = num5;
			return num;
		}
	}

	protected float m2(double A_0, double A_1, long A_2, long A_3, double A_4)
	{
		float num = 0f;
		float num2 = 0f;
		checked
		{
			int num3 = (int)Math.Round(A_0 / A_1);
			if (num3 < 1)
			{
				num3 = 1;
			}
			int num4 = (int)Math.Round(A_1 / A_0);
			if (num4 < 1)
			{
				num4 = 1;
			}
			A_2 = (int)Math.Round((double)A_2 / (double)num3 * (double)num3);
			if ((double)A_3 / (double)num3 > (double)(ce - 1) / (double)num4)
			{
				A_3 = (int)Math.Round(Math.Truncate((double)((ce - 1) * num3) / (double)num4));
			}
			int num5 = 0;
			int num6 = (int)Math.Round((double)(A_2 * num4) / (double)num3);
			long num7 = A_2;
			long num8 = A_3;
			long num9 = num3;
			for (long num10 = num7; ((num9 >> 63) ^ num10) <= ((num9 >> 63) ^ num8); num10 += num9)
			{
				num = (float)((double)num + cd[num6]);
				float num11 = (float)(cd[num6] - cf[(int)num10]);
				num2 += num11 * num11;
				num5++;
				num6 += num4;
			}
			float num12 = num / (float)num5;
			float num13 = 0f;
			num6 = (int)Math.Round((double)(A_2 * num4) / (double)num3);
			long num14 = A_2;
			long num15 = A_3;
			long num16 = num3;
			for (long num10 = num14; ((num16 >> 63) ^ num10) <= ((num16 >> 63) ^ num15); num10 += num16)
			{
				float num11 = (float)(cd[num6] - (double)num12);
				num13 += num11 * num11;
				num6 += num4;
			}
			float num17 = ((num13 != 0f) ? (1f - num2 / num13) : 0f);
			return (float)((double)num17 * A_4);
		}
	}

	protected void m2(ref hi A_0, int A_1, bool A_2, double A_3, short A_4, double A_5, double A_6, bool A_7, ref double[] A_8, ref double[] A_9, ref double[] A_10, ref short[] A_11)
	{
		checked
		{
			double A_12 = default(double);
			short A_13 = default(short);
			int A_14 = default(int);
			short A_15 = default(short);
			f6.FFTPrepare(A_4, ref A_8[0], (short)(A_0.g7() + 2), ref az[0], ref A_11[0], ref a1[0], ref A_10[0], ref A_12, ref A_13, A_1, ref A_14, ref A_15);
			double[] array = new double[A_14 + 1];
			double A_16 = default(double);
			int num = unchecked(f6.FFTStreamlined2(A_4, ref A_8[0], ref A_9[0], ref a1[0], A_14, A_15, A_13, (short)(0 - (A_2 ? 1 : 0)), A_3, (int)A_0.g1(), ref array[0], ref A_16));
			if (num != 0)
			{
				throw new ApplicationException("Error calling FFTStreamlined in ComputeMeasuredFFT. Error code=" + num);
			}
			long num2 = (int)Math.Round(2.0 * A_12 / A_16);
			if (num2 > A_14)
			{
				num2 = A_14;
			}
			A_16 *= 1000000000.0;
			int num3 = (int)(num2 - 1);
			for (int num4 = 0; num4 <= num3; num4++)
			{
				cc[num4] = A_16 * (double)num4;
				cd[num4] = array[num4];
			}
			ce = (int)num2;
		}
	}

	private static void m2(hi A_0, double A_1, double A_2, int A_3, double[] A_4, double[] A_5, double A_6, double A_7)
	{
		double num = 0.002016942315449778 * A_7;
		if (!hr.r(A_1, A_2))
		{
			return;
		}
		bool flag = false;
		checked
		{
			int num2 = A_3 - 1;
			double num4 = default(double);
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (!flag)
				{
					num4 = Math.Exp(num * A_4[num3]);
					if (num4 > 100.0)
					{
						flag = true;
						num4 = 100.0;
					}
					else if (A_4[num3] > A_6)
					{
						flag = true;
					}
					num4 *= num4;
				}
				A_5[num3] *= num4;
			}
		}
	}

	protected void m2(ref m A_0, short A_1, ref short[] A_2, ref short[] A_3, int A_4, int A_5, bool A_6, double A_7, double A_8, bool A_9, int A_10, ref int A_11, ref int A_12, ref double A_13, ref double A_14, ref double A_15, hi A_16, short A_17, ref double[] A_18, ref double[] A_19, ref double[] A_20, ref double[] A_21, ref double[] A_22, ref short[] A_23, ref double A_24, short A_25, bool A_26, short A_27, float[] A_28, short[] A_29, int A_30, eo.a A_31, bool A_32)
	{
		gc gc2 = null;
		short[] A_33 = null;
		if (A_16.hf() && A_16.au(A_26, A_31))
		{
			double[] array = new double[103];
			A_16.au(ref A_33);
			f6.Solve18((short)A_0.c, A_0.e, 0f, A_0.f, -1, A_0.h, A_0.d[0], A_0.g, A_0.i[0], A_17, ref A_18[0], A_1, ref A_2[0], ref A_20[0], ref a7[0], ref A_19[0], checked((short)(A_16.g7() + 2)), ref az[0], ref array[0], ref a4[0], ref A_3[0], ref a1[0], ref a3[0], ref A_22[0], ref A_0.l[0], ref A_0.k[0], ref A_0.j[0], ref A_33[0], A_27, ref A_28[0], ref A_29[0], cu);
		}
		else
		{
			f6.Solve17((short)A_0.c, 0, 0f, 0.001f, A_0.d[0], A_0.g, A_0.i[0], A_17, ref A_21[0], A_1, ref A_2[0], ref A_20[0], ref a7[0], ref A_19[0], checked((short)(A_16.g7() + 2)), ref az[0], ref a4[0], ref A_3[0], ref a1[0], ref a3[0], ref A_22[0], ref A_0.l[0], ref A_0.k[0], ref A_0.j[0], A_27, ref A_28[0], ref A_29[0], cu);
		}
		ay[0] = 1.0;
		double A_34 = default(double);
		short A_35 = default(short);
		int A_36 = default(int);
		short A_37 = default(short);
		checked
		{
			f6.FFTPrepare(A_17, ref A_21[0], (short)(A_16.g7() + 2), ref az[0], ref A_23[0], ref a1[0], ref A_22[0], ref A_34, ref A_35, A_10, ref A_36, ref A_37);
			if (!A_6)
			{
				double num = 0.0;
				int num2 = A_17 - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					num += A_19[num3];
				}
				if (A_17 > 0)
				{
					num /= (double)A_17;
				}
				A_7 += num - A_8;
			}
			cf = new double[A_36 + 1 + 1];
		}
		double A_38 = default(double);
		f6.FFTStreamlined2(A_17, ref A_21[0], ref A_19[0], ref a1[0], A_36, A_37, A_35, (short)(0 - (A_6 ? 1 : 0)), A_7, (int)A_16.g1(), ref cf[0], ref A_38);
		checked
		{
			ch = (int)Math.Round(2.0 * A_34 / A_38);
			if (ch > A_36)
			{
				ch = A_36;
			}
			cg = new double[ch + 1];
			A_38 *= 1000000000.0;
			if (A_9)
			{
				int num4 = ch - 1;
				for (int num3 = 0; num3 <= num4; num3++)
				{
					cg[num3] = A_38 * (double)num3;
				}
			}
			else
			{
				cg[1] = A_38;
			}
			double num5 = 0.0;
			A_24 = 0.0;
			if (A_25 == 1)
			{
				gc2 = A_16.eu(A_5);
				double num6 = gc2.ai() * (1.0 - gc2.av() * 0.01);
				double num7 = gc2.ai() * (1.0 + gc2.av() * 0.01);
				int num8;
				for (num8 = 0; num8 < ce - 1 && cc[num8] < num6; num8++)
				{
				}
				if (ce > 0)
				{
					A_24 = cd[num8];
				}
				else
				{
					A_24 = 1.0;
				}
				for (; num8 < ce - 1 && cc[num8] < num7; num8++)
				{
					if (cd[num8] > A_24)
					{
						A_24 = cd[num8];
					}
				}
				if (gc2.av() * 0.01 < 0.25)
				{
					num6 = gc2.ai() * 0.75;
					num7 = gc2.ai() * 1.25;
				}
				for (num8 = 0; (num8 < ch - 1) & (A_38 * (double)num8 < num6); num8++)
				{
				}
				A_11 = num8 - 1;
				if (A_11 < 0)
				{
					A_11 = 0;
				}
				num5 = ((ce <= 0) ? 1.0 : cf[num8]);
				for (; (num8 < ch - 1) & (A_38 * (double)num8 < num7); num8++)
				{
					if (cf[num8] > num5)
					{
						num5 = cf[num8];
					}
				}
				A_12 = num8 - 1;
				if (A_12 < A_11)
				{
					A_12 = A_11 + 1;
				}
			}
			else
			{
				int num9 = ce - 1;
				for (int num3 = 0; num3 <= num9; num3++)
				{
					if (cd[num3] > A_24)
					{
						A_24 = cd[num3];
					}
				}
				int num10 = ch - 1;
				for (int num3 = 0; num3 <= num10; num3++)
				{
					if (cf[num3] > num5)
					{
						num5 = cf[num3];
					}
				}
				A_11 = 0;
				A_12 = ch - 1;
			}
			double num11 = ((!(num5 > 0.0)) ? 1.0 : (A_24 / num5));
			int num12 = ch - 1;
			for (int num3 = 0; num3 <= num12; num3++)
			{
				cf[num3] = num11 * cf[num3];
			}
			if (ce > 0)
			{
				A_13 = cc[1] - cc[0];
			}
			else
			{
				A_13 = 1.0;
			}
			if (ch > 0)
			{
				A_14 = cg[1] - cg[0];
			}
			else
			{
				A_14 = 1.0;
			}
			double num13 = A_14 / A_13;
			double num14 = Math.Sqrt(num11) * num13 * (double)A_16.g2();
			if (num14 > 1.0)
			{
				A_15 = 1.0 / ((num14 - 1.0) * 0.25 + 1.0);
			}
			else
			{
				A_15 = num14;
			}
		}
	}

	protected float m2(ref m A_0, short A_1, ref short[] A_2, ref short[] A_3, short A_4, short A_5, bool A_6, double A_7, double A_8, bool A_9, int A_10, ref int A_11, ref int A_12, ref double A_13, ref double A_14, ref double A_15, hi A_16, short A_17, ref double[] A_18, ref double[] A_19, ref double[] A_20, ref double[] A_21, ref double[] A_22, ref short[] A_23, short A_24, bool A_25, short A_26, float[] A_27, ref short[] A_28, int A_29, eo.a A_30, bool A_31)
	{
		double A_32 = 0.0;
		m2(ref A_0, A_1, ref A_2, ref A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10, ref A_11, ref A_12, ref A_13, ref A_14, ref A_15, A_16, A_17, ref A_18, ref A_19, ref A_20, ref A_21, ref A_22, ref A_23, ref A_32, A_24, A_25, A_26, A_27, A_28, A_29, A_30, A_31);
		if (!A_6)
		{
			return m2(A_13, A_14, 0L, A_12, A_15);
		}
		return m2(A_13, A_14, A_11, A_12, A_15);
	}

	protected void p9(f6.e A_0)
	{
		string A_1 = A_0 switch
		{
			f6.e.c => "MeasErrSolver1Fmt1", 
			f6.e.d => "MeasErrSolver2Fmt1", 
			f6.e.e => "MeasErrSolver3Fmt1", 
			f6.e.f => "MeasErrSolver4Fmt1", 
			f6.e.g => "MeasErrSolver5Fmt1", 
			f6.e.h => "MeasErrSolver6Fmt1", 
			f6.e.i => "MeasErrSolver7Fmt1", 
			f6.e.j => "MeasErrSolver8Fmt1", 
			f6.e.k => "MeasErrSolver9Fmt1", 
			f6.e.l => "MeasErrSolver10Fmt1", 
			f6.e.m => "MeasErrSolver11Fmt1", 
			_ => "MeasErrSolverOtherFmt1", 
		};
		string text = string.Format(hu.a(ref A_1), A_0);
		ab8().c(fz.a.b, "MeasErrSolverFmt1", text);
	}

	public k sm()
	{
		k k2;
		k result = (k2 = new k());
		short A_ = default(short);
		short A_2 = default(short);
		short A_3 = default(short);
		int A_4 = default(int);
		short A_5 = default(short);
		int A_6 = default(int);
		int calculationStatus = f6.GetCalculationStatus(cu, ref k2.i, ref k2.b, ref k2.c, ref k2.l, ref k2.m, ref A_, ref k2.k, ref A_2, ref k2.o, ref A_3, ref k2.q, ref k2.d, ref A_4, ref A_5, ref k2.g, ref A_6);
		k2.j = A_ != 0;
		k2.n = A_2 != 0;
		k2.p = A_3 != 0;
		k2.a = calculationStatus != -10;
		checked
		{
			k2.e = A_4 + k2.l;
			k2.f = A_5 != 0;
			if (k2.f)
			{
				k2.h = A_6 + k2.l;
			}
			k2 = null;
			return result;
		}
	}

	public l[] sn()
	{
		short A_ = default(short);
		if (f6.GetCurrentCalcSpectraStatus(cu, ref A_) != 0 || A_ == 0)
		{
			return null;
		}
		checked
		{
			int num = c4 - 1;
			int num3 = default(int);
			for (int num2 = 0; num2 <= num; num2++)
			{
				num3 += c5[num2];
				if (cx.d[num2] == 2)
				{
					num3 += c5[num2];
				}
			}
			double[] array = new double[num3 - 1 + 1];
			if (f6.GetCurrentCalcSpectra(cu, ref array[0], num3) != 0)
			{
				return null;
			}
			int num4 = 0;
			int num5 = c4 - 1;
			for (int num6 = 0; num6 <= num5; num6++)
			{
				num4++;
				if (cx.d[num6] == 2)
				{
					num4++;
				}
			}
			l[] array2 = new l[num4 - 1 + 1];
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			int num10 = c4 - 1;
			int num15 = default(int);
			for (int num11 = 0; num11 <= num10; num11++)
			{
				int num12 = c5[num11];
				num9 = dj[num11];
				l l2 = new l();
				l l3 = l2;
				l3.b = new double[num12 - 1 + 1];
				l3.c = new double[num12 - 1 + 1];
				int num13 = num12 - 1;
				for (int num14 = 0; num14 <= num13; num14++)
				{
					l3.b[num14] = cy[num9 + cz[num15 + num14]] * 1000000000.0;
					l3.c[num14] = array[num7 + num14];
				}
				num7 += num12;
				l3.a = num12;
				l3.d = c0;
				l3.e = c1;
				l3.f = c2;
				l3.g = c3;
				l3 = null;
				array2[num8] = l2;
				num8++;
				if (cx.d[num11] == 2)
				{
					l2 = new l();
					l l4 = l2;
					l4.b = new double[num12 - 1 + 1];
					l4.c = new double[num12 - 1 + 1];
					int num16 = num12 - 1;
					for (int num17 = 0; num17 <= num16; num17++)
					{
						l4.b[num17] = cy[num9 + cz[num15 + num17]] * 1000000000.0;
						l4.c[num17] = array[num7 + num17];
					}
					num7 += num12;
					l4.a = num12;
					l4 = null;
					array2[num8] = l2;
					num8++;
				}
				num15 += num12;
			}
			return array2;
		}
	}

	public void m2(hr A_0, double[] A_1, double[] A_2, double A_3, double A_4, ref double A_5)
	{
		int num = Information.UBound(A_1);
		checked
		{
			hr hr2;
			int num2 = default(int);
			for (hr2 = A_0; num2 < hr2.c2() && hr2.cz()[num2] < A_3; num2++)
			{
			}
			int num3 = default(int);
			if (num2 < hr2.c2())
			{
				num3 = num2;
			}
			for (; num2 < hr2.c2() && !(hr2.cz()[num2] >= A_4); num2++)
			{
			}
			int num4 = default(int);
			if (num2 < hr2.c2())
			{
				num4 = ((!(hr2.cz()[num2] > A_4)) ? num2 : (num2 - 1));
			}
			hr2 = null;
			int num5 = num4 - num3 + 1;
			int num6 = num5 - 1;
			double[] array = new double[num6 + 1];
			double[] array2 = new double[num6 + 1];
			double[] A_6 = new double[A_1.Length - 1 + 1];
			double[] A_7 = new double[num6 + 1];
			_ = new double[A_1.Length - 1 + 1];
			_ = new double[num6 + 1];
			_ = new double[num6 + 1];
			int num7 = num3;
			int num8 = num4;
			for (num2 = num7; num2 <= num8; num2++)
			{
				array[num2 - num3] = A_0.cz()[num2];
				array2[num2 - num3] = A_0.c0()[num2];
			}
			double a_ = (A_2[1] - A_2[0]) / (A_1[1] - A_1[0]);
			double a_2 = (A_2[num] - A_2[num - 1]) / (A_1[num] - A_1[num - 1]);
			jf.a(A_1, A_2, A_1.Length, a_, a_2, ref A_6);
			jf.a(A_1, A_2, A_6, A_1.Length, A_4: false, array, ref A_7, num5, A_8: false);
			if (A_7[0] < 0.0)
			{
				A_7[0] = 0.0;
			}
			double num9 = array[0] - A_3;
			double num10 = A_7[0] * array2[0] * num9;
			double num11 = A_7[0] * num9;
			int num12 = num5 - 1;
			for (num2 = 1; num2 <= num12; num2++)
			{
				if (A_7[num2] < 0.0)
				{
					A_7[num2] = 0.0;
				}
				num9 = array[num2] - array[num2 - 1];
				num10 += 0.5 * (A_7[num2 - 1] * array2[num2 - 1] + A_7[num2] * array2[num2]) * num9;
				num11 += 0.5 * (A_7[num2 - 1] + A_7[num2]) * num9;
			}
			num9 = A_4 - array[num5 - 1];
			num10 += A_7[num5 - 1] * array2[num5 - 1] * num9;
			num11 += A_7[num5 - 1] * num9;
			A_5 = num10 / num11;
		}
	}

	private static void m2(hr A_0, ref byte[] A_1)
	{
		int count = A_0.b8().Count;
		int num = 0;
		ReadOnlyCollection<Guid> readOnlyCollection = A_0.b8();
		checked
		{
			A_1 = new byte[count * 16 + 1];
			int num2 = default(int);
			for (; num2 < readOnlyCollection.Count; num2++)
			{
				int num3 = 0;
				byte[] array = readOnlyCollection[num2].ToByteArray();
				num3 = 0;
				do
				{
					A_1[num + num3] = array[num3];
					num3++;
				}
				while (num3 <= 15);
				num += 16;
			}
			readOnlyCollection = null;
		}
	}

	private static void m2(hr A_0, ref float[] A_1)
	{
		checked
		{
			A_1 = new float[A_0.c2() - 1 + 1];
			double[] array = A_0.cz();
			int num = A_0.c2() - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				A_1[num2] = (float)array[num2];
			}
		}
	}

	public void m2(hr A_0, b5 A_1, ref ix.c A_2, ref bool A_3)
	{
		float[] A_4 = null;
		int a_ = A_0.c2();
		byte[] A_5 = null;
		A_2 = null;
		m2(A_0, ref A_4);
		m2(A_0, ref A_5);
		ReadOnlyCollection<Guid> readOnlyCollection = A_0.b8();
		checked
		{
			if (global::b7.c(A_4[0], A_4[A_0.c2() - 1]))
			{
				int num = 1;
				float[] array = new float[1 * num * 3 - 1 + 1];
				short A_6 = default(short);
				int num2 = global::b1.ICRefreshCoeffs2(ref A_4[0], a_, ref A_5[0], readOnlyCollection.Count, 0, 1, cu, cv, ref cv, ref A_6);
				if (num2 != 0)
				{
					throw new Exception("Error trying to call ICRefreshCoeffs for YID1925 in MeasEngineBase.DetermineSpectrumColor(). ErrCode=" + Conversions.ToString(num2));
				}
				float A_7 = default(float);
				float A_8 = default(float);
				float A_9 = default(float);
				float A_10 = default(float);
				num2 = global::b1.ICComputeSpectrumColor(ref A_0.c0()[0], ref array[0], ref A_7, ref A_8, ref A_9, ref A_10, 0, cu, cv, ref cv);
				if (num2 != 0)
				{
					ab8().c(fz.b.b, "Error trying to call ICComputeSpectrumColor for YID1925. ErrCode=" + Conversions.ToString(num2));
				}
				float a_2 = (float)(100.0 * (1.275 * (double)A_8 - 1.0576 * (double)A_10) / (double)A_9);
				A_2 = new ix.c(global::y.c(global::u.a.b, a_2, A_1.j(), ref A_3));
			}
			readOnlyCollection = null;
		}
	}

	public void m2(hr A_0, ref cc.f A_1, b5 A_2)
	{
		checked
		{
			_ = new byte[1, A_0.c2() - 1 + 1];
			_ = new byte[1, A_0.c2() - 1 + 1];
			_ = new float[A_0.c2() - 1 + 1];
			_ = new byte[1, A_0.c2() - 1 + 1];
			int num = 1;
			int num2 = 1;
			float[] array = new float[3];
			bool flag = false;
			float[] a_ = new float[3];
			float[] array2 = new float[3];
			short num3 = 0;
			bool flag2 = false;
			_ = new float[A_0.c2() - 1 + 1];
			_ = global::e.a().ShowSpectrumCoordOption;
			try
			{
				if (!global::b5.g(A_0))
				{
					return;
				}
				A_1 = new cc.f();
				Collection<a4.d> collection = A_2.g();
				if (collection.Count == 0)
				{
					return;
				}
				if (collection[0].b == global::a4.b.b)
				{
					flag2 = true;
				}
				float[] array3 = new float[num * num2 * 3 - 1 + 1];
				float[] A_3 = null;
				m2(A_0, ref A_3);
				int num4 = A_3.Length;
				int num5 = num4 - 1;
				int num6 = 0;
				int num7 = num5;
				float num8 = A_3[0];
				float num9 = A_3[num5];
				bool flag3 = default(bool);
				if (global::e.a().RestrictColorWavelength)
				{
					float num10 = global::e.a().ColorWavelengthLowerLimitNm;
					float num11 = global::e.a().ColorWavelengthUpperLimitNm;
					if (num10 < num11 && num10 <= num9 && num11 >= num8)
					{
						if (num10 <= num8)
						{
							num6 = 0;
						}
						else
						{
							int num12 = num5;
							for (int num13 = 1; num13 <= num12; num13++)
							{
								if (num10 <= A_3[num13])
								{
									num6 = num13;
									break;
								}
							}
						}
						if (num11 >= num9)
						{
							num7 = num5;
						}
						else
						{
							for (int num13 = num5; num13 >= 1; num13 += -1)
							{
								if (num11 >= A_3[num13])
								{
									num7 = num13;
									break;
								}
							}
						}
						if (num6 >= num7)
						{
							flag3 = true;
						}
					}
					else
					{
						flag3 = true;
					}
				}
				else
				{
					flag3 = true;
				}
				double[] array4;
				if (flag3)
				{
					array4 = A_0.c0();
				}
				else
				{
					double[] array5 = A_0.c0();
					array4 = new double[num5 + 1];
					int num14 = num6 - 1;
					for (int num13 = 0; num13 <= num14; num13++)
					{
						array4[num13] = array5[num6];
					}
					int num15 = num6;
					int num16 = num7;
					for (int num13 = num15; num13 <= num16; num13++)
					{
						array4[num13] = array5[num13];
					}
					int num17 = num7 + 1;
					int num18 = num5;
					for (int num13 = num17; num13 <= num18; num13++)
					{
						array4[num13] = array5[num7];
					}
				}
				byte[] A_4 = null;
				m2(A_0, ref A_4);
				unchecked
				{
					short a_2 = (short)collection[0].c;
					short A_5 = default(short);
					int num19 = global::b1.ICRefreshCoeffs2(ref A_3[0], num4, ref A_4[0], A_0.b8().Count, (short)(0 - (flag2 ? 1 : 0)), a_2, cu, cv, ref cv, ref A_5);
					if (num19 != 0)
					{
						throw new Exception("Error trying to call ICRefreshCoeffs in MeasEngineBase.DetermineSpectrumColor(). ErrCode=" + Conversions.ToString(num19));
					}
					if (A_5 != 0)
					{
						double[] array6;
						checked
						{
							array6 = new double[num5 + 1];
							int num20 = num5;
							for (int num21 = 0; num21 <= num20; num21++)
							{
								array6[num21] = 1.0;
							}
						}
						num19 = global::b1.ICComputeSpectrumColor(ref array6[0], ref array3[0], ref cw, ref array[0], ref array[1], ref array[2], (short)(0 - (flag2 ? 1 : 0)), cu, cv, ref cv);
						if (num19 != 0)
						{
							ab8().c(fz.b.b, "Error trying to call ICComputeSpectrumColor for white spectrum. ErrCode=" + Conversions.ToString(num19));
							A_1.c(a_);
							A_1.d();
						}
					}
					float A_6 = default(float);
					num19 = global::b1.ICComputeSpectrumColor(ref array4[0], ref array3[0], ref A_6, ref array[0], ref array[1], ref array[2], (short)(0 - (flag2 ? 1 : 0)), cu, cv, ref cv);
					if (num19 != 0)
					{
						ab8().c(fz.b.b, "Error trying to call ICComputeSpectrumColor. ErrCode=" + Conversions.ToString(num19));
						A_1.c(a_);
						A_1.d();
					}
				}
				foreach (a4.d item in collection)
				{
					switch (item.a)
					{
					case global::a4.a.a:
					case global::a4.a.c:
					{
						if (flag)
						{
							break;
						}
						int num19 = global::b1.ConvertImageXYZToCIELab(array[0], array[1], array[2], ref array2[0], ref array2[1], ref array2[2], unchecked((short)(0 - (flag2 ? 1 : 0))), cu, cv, ref cv);
						if (num19 != 0)
						{
							ab8().c(fz.b.b, "Error trying to call ConvertImageXYZToCIELab. ErrCode=" + Conversions.ToString(num19));
						}
						else
						{
							bool A_9 = false;
							float[] array9 = global::y.c(global::a4.a.a, array2, A_2.j(), ref A_9);
							m2(array9[0], array9[1], array9[2], num3, A_1, item.c, global::a4.a.a, item.b, A_9);
							num3 = (short)unchecked(num3 + 1);
							float a_3 = array2[0];
							float a_4 = array2[1];
							float a_5 = array2[2];
							num19 = global::b1.ConvertImageCIELabToCIELch(a_3, a_4, a_5, ref array2[0], ref array2[1], ref array2[2]);
							unchecked
							{
								if (num19 != 0)
								{
									ab8().c(fz.b.b, "Error trying to call ConvertImageCIELabToCIELch. ErrCode=" + Conversions.ToString(num19));
								}
								else
								{
									if (item.a == global::a4.a.c)
									{
										num3 = 0;
									}
									array9 = global::y.c(global::a4.a.c, array2, A_2.j(), ref A_9);
									m2(array9[0], array9[1], array9[2], num3, A_1, item.c, global::a4.a.c, item.b, A_9);
									num3 = (short)((item.a != global::a4.a.c) ? checked((short)unchecked(num3 + 1)) : 2);
								}
							}
						}
						flag = true;
						break;
					}
					case global::a4.a.d:
					{
						bool A_8 = false;
						float[] array8 = global::y.c(global::a4.a.d, array, A_2.j(), ref A_8);
						m2(array8[0], array8[1], array8[2], num3, A_1, item.c, item.a, item.b, A_8);
						num3 = (short)unchecked(num3 + 1);
						break;
					}
					case global::a4.a.b:
					{
						int num19 = global::b1.ConvertImageXYZToCIELuv(array[0], array[1], array[2], ref array2[0], ref array2[1], ref array2[2], unchecked((short)(0 - (flag2 ? 1 : 0))), cu, cv, ref cv);
						if (num19 != 0)
						{
							ab8().c(fz.b.b, "Error trying to call ICRefreshMonoCoeffs. ErrCode=" + Conversions.ToString(num19));
							break;
						}
						bool A_7 = false;
						float[] array7 = global::y.c(global::a4.a.b, array2, A_2.j(), ref A_7);
						m2(array7[0], array7[1], array7[2], num3, A_1, item.c, item.a, item.b, A_7);
						num3 = (short)unchecked(num3 + 1);
						break;
					}
					}
				}
				A_1.c(m2(array3, cw));
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_6 = ex2;
				ab8().c(fz.b.b, "Exception Thrown", a_6);
				A_1.c(a_);
				A_1.d();
				ProjectData.ClearProjectError();
			}
		}
	}

	protected void m2(float A_0, float A_1, float A_2, short A_3, cc.f A_4, a4.c A_5, a4.a A_6, a4.b A_7, bool A_8)
	{
		cc.d d10 = new cc.d();
		d10.h(A_6, A_5, A_7, A_0, A_1, A_2, A_8);
		A_4.c(A_3, d10);
	}

	protected float[] m2(float[] A_0, float A_1)
	{
		float[] array = new float[3];
		float num = ((!(A_1 > 0f)) ? 1f : (1f / A_1));
		array[2] = Math.Max(0f, A_0[0] * num);
		array[1] = Math.Max(0f, A_0[1] * num);
		array[0] = Math.Max(0f, A_0[2] * num);
		return array;
	}

	public static float m2(double A_0, ref double[] A_1, int A_2, int A_3, ref int A_4, ref int A_5)
	{
		checked
		{
			int num;
			for (num = A_2; (A_1[num] < A_0) & (num < A_3); num++)
			{
			}
			if ((num > A_2) & (A_1[num] >= A_0))
			{
				A_4 = num - 1;
				A_5 = num;
				return (float)((A_1[A_5] - A_0) / (A_1[A_5] - A_1[A_4]));
			}
			A_4 = num;
			A_5 = num;
			return 1f;
		}
	}

	public ErrPublic m2(hr A_0, hc A_1)
	{
		int num = 0;
		double num2 = 0.0;
		hr hr2 = A_0;
		int upperBound = hr2.cz().GetUpperBound(0);
		_ = (hr2.cz()[upperBound] - hr2.cz()[0]) / 2.0;
		_ = A_0.cz()[0];
		int num3 = upperBound;
		checked
		{
			for (int num4 = 0; num4 <= num3; num4++)
			{
				if (num2 < hr2.c0()[num4])
				{
					num2 = hr2.c0()[num4];
					num = num4;
				}
			}
			double num5 = num2 / 2.0;
			int num6 = num;
			do
			{
				num6--;
			}
			while (hr2.c0()[num6] < num5);
			double num7 = hr2.cz()[num6];
			int num8 = num;
			do
			{
				num8++;
			}
			while (hr2.c0()[num8] < num5);
			_ = hr2.cz()[num8];
			hr2 = null;
			return ErrPublic.None;
		}
	}

	public void m2(hc A_0, hi.f A_1)
	{
		checked
		{
			int num = A_0.cn().c2() - 1;
			double[] array = A_0.cn().c0();
			double[] array2 = A_0.cn().cz();
			hi.f f10 = A_1;
			float num2 = (float)(0.01 * (double)f10.p());
			float num3 = (float)(0.01 * (double)f10.q());
			double num4 = 0.0;
			int num5 = num;
			for (int num6 = 0; num6 <= num5; num6++)
			{
				if (array[num6] > num4)
				{
					num4 = array[num6];
				}
			}
			int num7 = default(int);
			int num8 = default(int);
			if (!f10.o())
			{
				if (f10.r())
				{
					num2 = (float)((double)num2 * num4);
					num3 = (float)((double)num3 * num4);
				}
				int num6 = 0;
				bool flag = false;
				while (num6 <= num && !flag)
				{
					if (array[num6] >= (double)num2)
					{
						num7 = num6;
						flag = true;
					}
					else
					{
						num6++;
					}
				}
				if (!flag)
				{
					return;
				}
				num6 = num;
				flag = false;
				while (num6 >= 0 && !flag)
				{
					if (array[num6] >= (double)num3)
					{
						num8 = num6;
						flag = true;
					}
					else
					{
						num6--;
					}
				}
				if (!flag)
				{
					return;
				}
			}
			else
			{
				double num9 = 10000.0;
				int num10 = num;
				for (int num11 = 0; num11 <= num10; num11++)
				{
					double num12 = Math.Abs((double)f10.s() - array2[num11]);
					if (num12 < num9)
					{
						num7 = num11;
						num9 = num12;
					}
				}
				num9 = 10000.0;
				int num13 = num;
				for (int num11 = 0; num11 <= num13; num11++)
				{
					double num12 = Math.Abs((double)f10.t() - array2[num11]);
					if (num12 < num9)
					{
						num8 = num11;
						num9 = num12;
					}
				}
			}
			int num14 = num7;
			int num15 = num8;
			int num16 = default(int);
			for (int num6 = num14; num6 <= num15; num6++)
			{
				if (array[num6] <= num4)
				{
					num4 = array[num6];
					num16 = num6;
				}
			}
			f10 = null;
			A_0.cf(new cc.h((float)array2[num7], (float)array2[num8], (float)array2[num16]));
		}
	}

	public void p9(hc A_0, hi.f A_1)
	{
		checked
		{
			int num = A_0.cn().c2() - 1;
			double[] array = A_0.cn().c0();
			double[] array2 = A_0.cn().cz();
			float num2 = (float)(0.01 * (double)A_1.u());
			float num3 = 0f;
			int num4 = num;
			int num6 = default(int);
			int num5;
			for (num5 = 0; num5 <= num4; num5++)
			{
				if (array[num5] > (double)num3)
				{
					num3 = (float)array[num5];
					num6 = num5;
				}
			}
			if (A_1.v())
			{
				num2 *= num3;
			}
			if (num6 < 4)
			{
				num6 = 4;
			}
			if (num6 > num - 4)
			{
				num6 = num - 4;
			}
			num5 = num6;
			int num7 = -1;
			float num8 = 5000f;
			while (num5 > 0)
			{
				if (array[num5] <= (double)num2)
				{
					if (array[num5] < (double)num8)
					{
						num8 = (float)array[num5];
						num7 = num5;
					}
					if (num7 > 0 && array[num5 - 1] + array[num5] + array[num5 + 1] > array[num5 + 2] + array[num5 + 3] + array[num5 + 4])
					{
						break;
					}
				}
				num5--;
			}
			if (num7 < 0)
			{
				return;
			}
			num5 = num6;
			int num9 = -1;
			num8 = 5000f;
			for (; num5 < num; num5++)
			{
				if (array[num5] <= (double)num2)
				{
					if (array[num5] < (double)num8)
					{
						num8 = (float)array[num5];
						num9 = num5;
					}
					if (num9 > 0 && array[num5 - 1] + array[num5] + array[num5 + 1] > array[num5 - 2] + array[num5 - 3] + array[num5 - 4])
					{
						break;
					}
				}
			}
			if (num9 >= 0)
			{
				A_0.cf(new cc.i((float)array2[num7], (float)array2[num9], (float)(2.0 / (1.0 / array2[num7] + 1.0 / array2[num9]))));
			}
		}
	}

	[SpecialName]
	public bool so()
	{
		return cp;
	}

	public void st()
	{
		f6.SetTerminationRequest2(cu);
		cq = true;
	}

	public void s3()
	{
		f6.SetAcceptCurrentAnalysisResult(cu);
		cr = true;
	}

	public void s4()
	{
		cq = false;
	}

	protected virtual void m2(bool A_0)
	{
		if (!d1)
		{
			global::b1.ICDeleteCObj(cu, cv);
		}
		d1 = true;
	}

	public void s6()
	{
		m2(A_0: true);
		GC.SuppressFinalize(this);
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in s6
		this.s6();
	}

	~b9()
	{
		m2(A_0: false);
		base.Finalize();
	}
}
