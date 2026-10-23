using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

internal class jf
{
	public class a
	{
		private float m_a;

		private float b;

		private float c;

		private float d;

		public a(float A_0, float A_1, float A_2, float A_3)
		{
			if (A_0 < A_1)
			{
				m_a = A_0;
				b = A_1;
			}
			else
			{
				b = A_0;
				m_a = A_1;
			}
			if (A_2 < A_3)
			{
				c = A_2;
				d = A_3;
			}
			else
			{
				d = A_2;
				c = A_3;
			}
		}

		[SpecialName]
		public float e()
		{
			return m_a;
		}

		[SpecialName]
		public float f()
		{
			return b;
		}

		[SpecialName]
		public float g()
		{
			return c;
		}

		[SpecialName]
		public float h()
		{
			return d;
		}
	}

	public delegate bool b(double A_0, double A_1);

	public const double a = 1.0 / (2.0 * Math.PI);

	public const double b = Math.PI * 2.0;

	public const double c = Math.PI / 2.0;

	public const double d = 0.001;

	public const float e = 1000f;

	public const float f = 1E+09f;

	public const float g = 1E-09f;

	public const float h = 1000000f;

	public const float i = 1E-06f;

	public const float j = 0.001f;

	public const float k = 1000f;

	public const float l = 0.0001f;

	public const short m = 2;

	public const short n = 4;

	public const short o = 4;

	public const float p = 100f;

	public const double q = 0.01;

	private const float r = 1E-07f;

	private const double s = 1E-14;

	public const int t = 60;

	public const int u = 60;

	[SpecialName]
	private static bool v;

	[SpecialName]
	private static double w;

	public static bool a(double[] A_0, int A_1)
	{
		checked
		{
			int num = A_1 - 1;
			if (A_0 == null)
			{
				return false;
			}
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (A_0[num3] != 0.0)
				{
					return true;
				}
			}
			return false;
		}
	}

	public static double c(double A_0)
	{
		if (Math.Abs(A_0) >= 1.0)
		{
			return 99.0;
		}
		return Math.Atan(A_0 / Math.Sqrt((0.0 - A_0) * A_0 + 1.0));
	}

	public static double f(double A_0, double A_1)
	{
		if (A_0 > 0.0)
		{
			return Math.Atan(A_1 / A_0);
		}
		if (A_1 >= 0.0)
		{
			if (A_0 == 0.0)
			{
				return Math.PI / 2.0;
			}
			return Math.PI + Math.Atan(A_1 / A_0);
		}
		if (A_0 == 0.0)
		{
			return -Math.PI / 2.0;
		}
		return -Math.PI + Math.Atan(A_1 / A_0);
	}

	public static void b(float A_0, float A_1, ref float A_2, ref float A_3)
	{
		A_3 = (float)f((double)A_0, (double)A_1);
		A_2 = (float)Math.Sqrt(A_0 * A_0 + A_1 * A_1);
	}

	public static void a(float A_0, float A_1, ref float A_2, ref float A_3)
	{
		A_2 = (float)((double)Math.Abs(A_0) * Math.Cos(A_1));
		A_3 = (float)((double)Math.Abs(A_0) * Math.Sin(A_1));
	}

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int MUInterpolateArray(ref double A_0, ref double A_1, int A_2, ref double A_3, ref double A_4, int A_5);

	public static void a(ref double[] A_0, ref double[] A_1, int A_2, ref double[] A_3, ref double[] A_4, int A_5)
	{
		if (A_2 <= 0)
		{
			throw new IndexOutOfRangeException("Need at least one element in input array. NumIn=" + b3.a(A_2, CultureInfo.InvariantCulture));
		}
		checked
		{
			if (A_0.GetUpperBound(0) < A_2 - 1)
			{
				throw new IndexOutOfRangeException("xIn Upperbound=" + b3.a(A_0.GetUpperBound(0), CultureInfo.InvariantCulture) + ", but numIn=" + b3.a(A_2, CultureInfo.InvariantCulture));
			}
			if (A_1.GetUpperBound(0) < A_2 - 1)
			{
				throw new IndexOutOfRangeException("yIn Upperbound=" + b3.a(A_1.GetUpperBound(0), CultureInfo.InvariantCulture) + ", but numIn=" + b3.a(A_2, CultureInfo.InvariantCulture));
			}
			if (A_5 <= 0)
			{
				throw new IndexOutOfRangeException("Need at least one element in output array. NumOut=" + b3.a(A_5, CultureInfo.InvariantCulture));
			}
			if (A_3.GetUpperBound(0) < A_5 - 1)
			{
				throw new IndexOutOfRangeException("xOut Upperbound=" + b3.a(A_3.GetUpperBound(0), CultureInfo.InvariantCulture) + ", but numOut=" + b3.a(A_5, CultureInfo.InvariantCulture));
			}
			if (A_4 == null || A_4.GetUpperBound(0) < A_5 - 1)
			{
				A_4 = new double[A_5 - 1 + 1];
			}
			MUInterpolateArray(ref A_0[0], ref A_1[0], A_2, ref A_3[0], ref A_4[0], A_5);
		}
	}

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void FMInterpolateArrayFloat(ref float A_0, ref float A_1, int A_2, ref float A_3, ref float A_4, int A_5);

	public static void a(ref float[] A_0, ref float[] A_1, int A_2, ref float[] A_3, ref float[] A_4, int A_5)
	{
		if (A_2 <= 0)
		{
			throw new IndexOutOfRangeException("Need at least one element in input array. NumIn=" + b3.a(A_2, CultureInfo.InvariantCulture));
		}
		checked
		{
			if (A_0.GetUpperBound(0) < A_2 - 1)
			{
				throw new IndexOutOfRangeException("xIn Upperbound=" + b3.a(A_0.GetUpperBound(0), CultureInfo.InvariantCulture) + ", but numIn=" + b3.a(A_2, CultureInfo.InvariantCulture));
			}
			if (A_1.GetUpperBound(0) < A_2 - 1)
			{
				throw new IndexOutOfRangeException("yIn Upperbound=" + b3.a(A_1.GetUpperBound(0), CultureInfo.InvariantCulture) + ", but numIn=" + b3.a(A_2, CultureInfo.InvariantCulture));
			}
			if (A_5 <= 0)
			{
				throw new IndexOutOfRangeException("Need at least one element in output array. NumOut=" + b3.a(A_5, CultureInfo.InvariantCulture));
			}
			if (A_3.GetUpperBound(0) < A_5 - 1)
			{
				throw new IndexOutOfRangeException("xOut Upperbound=" + b3.a(A_3.GetUpperBound(0), CultureInfo.InvariantCulture) + ", but numOut=" + b3.a(A_5, CultureInfo.InvariantCulture));
			}
			if (A_4.GetUpperBound(0) < A_5 - 1)
			{
				A_4 = new float[A_5 - 1 + 1];
			}
			FMInterpolateArrayFloat(ref A_0[0], ref A_1[0], A_2, ref A_3[0], ref A_4[0], A_5);
		}
	}

	public static double a(double A_0, double A_1, double A_2, double A_3, double A_4, double A_5, double A_6)
	{
		double num = A_5 - A_3;
		double num2 = A_4 - A_2;
		double num3 = A_3 - A_1;
		double num4 = A_2 - A_0;
		double num5 = A_4 - A_0;
		double num6 = (num / num2 - num3 / num4) / num5;
		double num7 = (num / num2 * num4 + num3 / num4 * num2) / num5;
		double num8 = A_6 - A_2;
		return num6 * num8 * num8 + num7 * num8 + A_3;
	}

	public static void a(double A_0, double A_1, double A_2, double A_3, double A_4, double A_5, ref double A_6, ref double A_7)
	{
		double num = A_5 - A_3;
		double num2 = A_4 - A_2;
		double num3 = A_3 - A_1;
		double num4 = A_2 - A_0;
		double num5 = A_4 - A_0;
		double num6 = (num / num2 - num3 / num4) / num5;
		double num7 = (num / num2 * num4 + num3 / num4 * num2) / num5;
		A_6 = A_2 - num7 / (2.0 * num6);
		double num8 = A_6 - A_2;
		A_7 = num6 * num8 * num8 + num7 * num8 + A_3;
	}

	public static void a(double[] A_0, double[] A_1, int A_2, double A_3, double A_4, ref double[] A_5)
	{
		checked
		{
			double[] array = new double[A_2 + 1];
			int num = A_2 - 1;
			int num2 = A_2 - 2;
			if (A_3 > 1E+30)
			{
				A_5[0] = 0.0;
				array[0] = 0.0;
			}
			else
			{
				A_5[0] = -0.5;
				array[0] = 3.0 / (A_0[1] - A_0[0]) * ((A_1[1] - A_1[0]) / (A_0[1] - A_0[0]) - A_3);
			}
			int num3 = num2;
			for (int num4 = 1; num4 <= num3; num4++)
			{
				double num5 = (A_0[num4] - A_0[num4 - 1]) / (A_0[num4 + 1] - A_0[num4 - 1]);
				double num6 = num5 * A_5[num4 - 1] + 2.0;
				A_5[num4] = (num5 - 1.0) / num6;
				array[num4] = (6.0 * ((A_1[num4 + 1] - A_1[num4]) / (A_0[num4 + 1] - A_0[num4]) - (A_1[num4] - A_1[num4 - 1]) / (A_0[num4] - A_0[num4 - 1])) / (A_0[num4 + 1] - A_0[num4 - 1]) - num5 * array[num4 - 1]) / num6;
			}
			double num7;
			double num8;
			if (A_4 > 1E+30)
			{
				num7 = 0.0;
				num8 = 0.0;
			}
			else
			{
				num7 = 0.5;
				num8 = 3.0 / (A_0[num] - A_0[num2]) * (A_4 - (A_1[num] - A_1[num2]) / (A_0[num] - A_0[num2]));
			}
			A_5[num] = (num8 - num7 * array[num2]) / (num7 * A_5[num2] + 1.0);
			for (int num9 = num2; num9 >= 0; num9 += -1)
			{
				A_5[num9] = A_5[num9] * A_5[num9 + 1] + array[num9];
			}
		}
	}

	public static void a(double[] A_0, double[] A_1, double[] A_2, int A_3, double[] A_4, ref double[] A_5, int A_6)
	{
		a(A_0, A_1, A_2, A_3, A_4: false, A_4, ref A_5, A_6, A_8: false);
	}

	public static void a(double[] A_0, double[] A_1, double[] A_2, int A_3, bool A_4, double[] A_5, ref double[] A_6, int A_7, bool A_8)
	{
		checked
		{
			int num = A_7 - 1;
			int num2 = A_3 - 1;
			double num3 = 0.0;
			double num4 = 0.0;
			double num5 = double.MinValue;
			double num6 = double.MaxValue;
			double num7 = double.MinValue;
			double num8 = double.MaxValue;
			if (A_3 < 2 || A_7 < 2)
			{
				throw new Exception("For Spline Interpolation, xIn and xOut arrays must both have two or more points");
			}
			double num9 = default(double);
			if (A_4)
			{
				num9 = A_0[1] - A_0[0];
				if (num9 <= 0.0)
				{
					throw new Exception("For Spline Interpolation, the xIn array values must be distinct and incrementing");
				}
			}
			else
			{
				int num10 = num2;
				for (int num11 = 1; num11 <= num10; num11++)
				{
					double num12 = A_0[num11] - A_0[num11 - 1];
					if (num12 > num5)
					{
						num5 = num12;
					}
					if (num12 < num6)
					{
						num6 = num12;
					}
				}
				if (num6 <= 0.0)
				{
					throw new Exception("For Spline Interpolation, the xIn array values must be distinct and incrementing");
				}
			}
			double num13 = default(double);
			if (A_8)
			{
				num13 = A_5[1] - A_5[0];
				if (num13 <= 0.0)
				{
					throw new Exception("For Spline Interpolation, the xOut array values must be distinct and incrementing");
				}
			}
			else
			{
				int num14 = num;
				for (int num15 = 1; num15 <= num14; num15++)
				{
					double num12 = A_5[num15] - A_5[num15 - 1];
					if (num12 > num7)
					{
						num7 = num12;
					}
					if (num12 < num8)
					{
						num8 = num12;
					}
				}
				if (num8 <= 0.0)
				{
					throw new Exception("For Spline Interpolation, the xOut array values must be distinct and incrementing");
				}
			}
			double num16;
			double num17;
			if (A_4 && A_8)
			{
				num16 = num13 / num9;
				num17 = num16;
			}
			else if (A_4)
			{
				num16 = num8 / num9;
				num17 = num7 / num9;
			}
			else if (A_8)
			{
				num16 = num13 / num5;
				num17 = num13 / num6;
			}
			else
			{
				num16 = num8 / num5;
				num17 = num7 / num6;
			}
			if (num16 % (double)(int)Math.Round(Math.Floor(num16)) < 0.05)
			{
				num3 = 1.0;
			}
			if (num17 % (double)(int)Math.Round(Math.Floor(num17)) < 0.05)
			{
				num4 = 1.0;
			}
			int num18 = Math.Max((int)Math.Round(Math.Floor(num16 - num3)), 0);
			int num19 = (int)Math.Round(Math.Ceiling(num17 + num4));
			int A_9 = 0;
			int A_10 = num19;
			if (A_10 > num2)
			{
				A_10 = num2;
			}
			A_6 = new double[num + 1];
			if (num18 > 0)
			{
				int num20 = num;
				for (int num21 = 0; num21 <= num20; num21++)
				{
					A_6[num21] = a(A_0, A_1, A_2, A_3, A_5[num21], ref A_9, ref A_10);
					A_9 += num18;
					A_10 += num19;
					if (A_10 > num2)
					{
						A_10 = num2;
					}
				}
				return;
			}
			int num22 = num;
			for (int num23 = 0; num23 <= num22; num23++)
			{
				A_6[num23] = a(A_0, A_1, A_2, A_3, A_5[num23], ref A_9, ref A_10);
				A_10 += num19;
				if (A_10 > num2)
				{
					A_10 = num2;
				}
			}
		}
	}

	public static double a(double[] A_0, double[] A_1, double[] A_2, int A_3, double A_4, ref int A_5, ref int A_6)
	{
		int num = checked(A_3 - 1);
		if (!(A_0[A_5] <= A_4) || !(A_0[A_6] >= A_4))
		{
			A_6 = num;
			if (!(A_0[A_5] <= A_4) || !(A_0[A_6] >= A_4))
			{
				A_5 = 0;
				A_6 = num;
			}
		}
		while (checked(A_6 - A_5) > 1)
		{
			int num2 = checked(A_6 + A_5) / 2;
			if (A_0[num2] > A_4)
			{
				A_6 = num2;
			}
			else
			{
				A_5 = num2;
			}
		}
		double num3 = A_0[A_6] - A_0[A_5];
		if (num3 == 0.0)
		{
			throw new Exception("For Spline Interpolation, the xIn array values must all be distinct");
		}
		double num4 = (A_0[A_6] - A_4) / num3;
		double num5 = (A_4 - A_0[A_5]) / num3;
		return num4 * A_1[A_5] + num5 * A_1[A_6] + ((num4 * num4 * num4 - num4) * A_2[A_5] + (num5 * num5 * num5 - num5) * A_2[A_6]) * (num3 * num3) / 6.0;
	}

	public static void c(double[] A_0, double[] A_1, int A_2, int A_3, ref double[] A_4)
	{
		checked
		{
			int num = 2 * A_3;
			double[] array = new double[num + 1];
			double[] array2 = new double[num + 1];
			int num2 = A_2 - A_3;
			int num3 = num;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				array[num4] = A_0[num2 + num4];
				array2[num4] = A_1[num2 + num4];
			}
			double[] array3 = new double[3];
			a(array, array2, num + 1, (short)2, array3);
			A_4[A_2] = array3[0] + (array3[1] + array3[2] * A_0[A_2]) * A_0[A_2];
		}
	}

	public static void b(double[] A_0, double[] A_1, int A_2, int A_3, ref double[] A_4)
	{
		checked
		{
			double[] array = new double[2 * A_3 + 1];
			double[] array2 = new double[2 * A_3 + 1];
			double[] array3 = new double[3];
			A_4 = new double[A_2 - 1 + 1];
			A_4[0] = A_1[0];
			A_4[1] = A_1[1];
			for (int num = 2; num <= A_3; num++)
			{
				int num2 = num + num;
				int num3 = num2;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					array[num4] = A_0[num4];
					array2[num4] = A_1[num4];
				}
				a(array, array2, num2 + 1, (short)2, array3);
				A_4[num] = array3[0] + (array3[1] + array3[2] * A_0[num]) * A_0[num];
			}
		}
	}

	public static void a(double[] A_0, double[] A_1, int A_2, float A_3, double[] A_4)
	{
		float num = (A_3 + A_3) / 2f;
		checked
		{
			if (e(num, (int)Math.Round(num)))
			{
				c(A_0, A_1, A_2, (int)Math.Round(num), ref A_4);
				return;
			}
			int num2 = (int)Math.Round(Math.Floor(num));
			int num3 = num2 + num2 + 3 - 1;
			double[] array = new double[num3 + 1];
			double[] array2 = new double[num3 + 1];
			double[] array3 = new double[3];
			float num4 = num - (float)num2;
			int num5 = A_2 - num2;
			array[0] = A_0[num5] - (double)num4 * (A_0[num5] - A_0[num5 - 1]);
			array2[0] = A_1[num5] - (double)num4 * (A_1[num5] - A_1[num5 - 1]);
			int num6 = num3 - 2;
			for (int num7 = 0; num7 <= num6; num7++)
			{
				array[num7 + 1] = A_0[num5 + num7];
				array2[num7 + 1] = A_1[num5 + num7];
			}
			int num8 = A_2 + num2;
			array[num3] = A_0[num8] + (double)num4 * (A_0[num8 + 1] - A_0[num8]);
			array2[num3] = A_1[num8] + (double)num4 * (A_1[num8 + 1] - A_1[num8]);
			a(array, array2, num3 + 1, (short)2, array3);
			A_4[A_2] = array3[0] + (array3[1] + array3[2] * A_0[A_2]) * A_0[A_2];
		}
	}

	public static void a(double[] A_0, double[] A_1, int A_2, int A_3, double[] A_4)
	{
		checked
		{
			double[] array = new double[2 * A_3 + 1];
			double[] array2 = new double[2 * A_3 + 1];
			double[] array3 = new double[3];
			int num = A_2 - 1;
			int num2 = num - A_3;
			int num3 = num - 2;
			for (int num4 = num2; num4 <= num3; num4++)
			{
				int num5 = num - num4 + num - num4;
				int num6 = num5;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					array[num7] = A_0[num - num5 + num7];
					array2[num7] = A_1[num - num5 + num7];
				}
				a(array, array2, num5 + 1, (short)2, array3);
				A_4[num4] = array3[0] + array3[1] * A_0[num4] + array3[2] * A_0[num4] * A_0[num4];
			}
			A_4[num - 1] = A_1[num - 1];
			A_4[num] = A_1[num];
		}
	}

	public static void a(double[] A_0, double[] A_1, int A_2, int A_3, ref double[] A_4)
	{
		checked
		{
			int num = A_2 - 1;
			b(A_0, A_1, A_2, A_3, ref A_4);
			int num2 = A_3 + 1;
			int num3 = num - A_3;
			for (int num4 = num2; num4 <= num3; num4++)
			{
				c(A_0, A_1, num4, A_3, ref A_4);
			}
			a(A_0, A_1, A_2, A_3, A_4);
		}
	}

	public static void a(double[] A_0, double[] A_1, int A_2, ref double A_3, ref double A_4)
	{
		double num = A_2;
		checked
		{
			short num2 = (short)(A_2 - 1);
			double num6 = default(double);
			double num7 = default(double);
			double num8 = default(double);
			double num9 = default(double);
			for (short num3 = 0; num3 <= num2; num3 = (short)unchecked(num3 + 1))
			{
				double num4 = A_0[num3];
				double num5 = A_1[num3];
				num6 += num4;
				num7 += num4 * num4;
				num8 += num5;
				num9 += num5 * num4;
			}
			double num10 = num6 * num6 - num7 * num;
			if (num10 != 0.0 && num6 != 0.0)
			{
				A_3 = (num6 * num9 - num7 * num8) / num10;
				A_4 = (num8 - num * A_3) / num6;
			}
			else
			{
				A_3 = 0.0;
				A_4 = 0.0;
			}
		}
	}

	public static double[] a(double[] A_0, int A_1, int A_2)
	{
		return a(null, A_0, A_1, A_2);
	}

	public static double[] a(double[] A_0, double[] A_1, int A_2, int A_3)
	{
		checked
		{
			double[] array = new double[A_2 - 1 + 1];
			int num = 2 * A_3;
			int a_ = num + 1;
			int num2 = A_2 - A_3 - 1;
			double A_4 = default(double);
			double A_5 = default(double);
			for (int num3 = A_3; num3 <= num2; num3++)
			{
				double[] array2 = new double[num + 1];
				double[] array3 = new double[num + 1];
				if (A_0 == null)
				{
					int num4 = num;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						int num6 = num3 - A_3 + num5;
						array2[num5] = num6;
						array3[num5] = A_1[num6];
					}
				}
				else
				{
					int num7 = num;
					for (int num8 = 0; num8 <= num7; num8++)
					{
						int num6 = num3 - A_3 + num8;
						array2[num8] = A_0[num6];
						array3[num8] = A_1[num6];
					}
				}
				a(array2, array3, a_, ref A_4, ref A_5);
				array[num3] = A_5;
			}
			int num9 = A_3 - 1;
			for (int num10 = 0; num10 <= num9; num10++)
			{
				array[num10] = array[A_3];
				array[A_2 - num10 - 1] = array[A_2 - A_3 - 1];
			}
			return array;
		}
	}

	public static void a(double[] A_0, double[] A_1, int A_2, ref double[] A_3, ref double A_4, ref double A_5)
	{
		checked
		{
			int num = A_2 - 1;
			A_4 = double.MinValue;
			A_5 = 0.0;
			A_3 = new double[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				A_3[num3] = A_0[num3] - A_1[num3];
				if (Math.Abs(A_3[num3]) > A_4)
				{
					A_4 = Math.Abs(A_3[num3]);
				}
				A_5 += Math.Abs(A_3[num3]);
			}
			A_5 /= A_2;
		}
	}

	public static int a(int A_0, int A_1)
	{
		double num = 1.0;
		checked
		{
			for (int num2 = 1; num2 <= A_1; num2++)
			{
				num *= (double)(A_0 + 1 - num2) / (double)num2;
			}
			return (int)Math.Round(num);
		}
	}

	public static int a(double[] A_0, double[] A_1, int A_2, short A_3, double[] A_4)
	{
		double num = double.MinValue;
		double num2 = double.MaxValue;
		bool flag = false;
		if (A_3 < 1)
		{
			return -1;
		}
		checked
		{
			double[] array = new double[A_2 - 1 + 1];
			double[] array2 = new double[A_3 + 1];
			double num3 = ((unchecked(A_2 % 2) != 0) ? A_0[unchecked(A_2 / 2)] : (0.5 * A_0[unchecked(A_2 / 2)] + 0.5 * A_0[unchecked(A_2 / 2) - 1]));
			int num4 = A_2 - 1;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				if (A_0[num5] > num)
				{
					num = A_0[num5];
				}
				if (A_0[num5] < num2)
				{
					num2 = A_0[num5];
				}
			}
			if (Math.Abs(num3) > (num - num2) * 100.0)
			{
				flag = true;
				int num6 = A_2 - 1;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					array[num7] = A_0[num7] - num3;
				}
			}
			else
			{
				int num8 = A_2 - 1;
				for (int num9 = 0; num9 <= num8; num9++)
				{
					array[num9] = A_0[num9];
				}
			}
			double[,] array3 = new double[A_3 + 1, A_3 + 1];
			double[] array4 = new double[A_3 + 1];
			double[,] array5 = new double[A_2 + 1, A_3 * 2 + 1];
			double[] array6 = new double[A_3 * 2 + 1];
			int num10 = A_2 - 1;
			for (int num11 = 0; num11 <= num10; num11++)
			{
				array5[num11, 0] = 1.0;
			}
			int num12 = A_2 - 1;
			for (int num11 = 0; num11 <= num12; num11++)
			{
				short num13 = (short)unchecked(A_3 * 2);
				for (short num14 = 1; num14 <= num13; num14 = (short)unchecked(num14 + 1))
				{
					array5[num11, num14] = array5[num11, num14 - 1] * array[num11];
				}
			}
			array6[0] = A_2;
			short num15 = (short)unchecked(A_3 * 2);
			for (short num14 = 1; num14 <= num15; num14 = (short)unchecked(num14 + 1))
			{
				int num16 = A_2 - 1;
				for (int num11 = 0; num11 <= num16; num11++)
				{
					array6[num14] += array5[num11, num14];
				}
			}
			short num17 = A_3;
			for (short num18 = 0; num18 <= num17; num18 = (short)unchecked(num18 + 1))
			{
				short num19 = A_3;
				for (short num20 = 0; num20 <= num19; num20 = (short)unchecked(num20 + 1))
				{
					array3[num18, num20] = array6[(short)unchecked(num18 + num20)];
				}
			}
			short num21 = A_3;
			for (short num14 = 0; num14 <= num21; num14 = (short)unchecked(num14 + 1))
			{
				int num22 = A_2 - 1;
				for (int num11 = 0; num11 <= num22; num11++)
				{
					array4[num14] += A_1[num11] * array5[num11, num14];
				}
			}
			if (a(array3, A_3 + 1, array4, array2) != 0)
			{
				return -1;
			}
			if (flag)
			{
				for (int num23 = 0; num23 <= A_3; num23++)
				{
					int num24 = num23;
					for (int num25 = 0; num25 <= num24; num25++)
					{
						A_4[A_3 - num23] += array2[A_3 - num25] * (double)a(A_3 - num25, num23 - num25) * Math.Pow(0.0 - num3, num23 - num25);
					}
				}
			}
			else
			{
				for (int num26 = 0; num26 <= A_3; num26++)
				{
					A_4[num26] = array2[num26];
				}
			}
			return 0;
		}
	}

	public static double a(int A_0, double[] A_1, double A_2, double A_3, double A_4, double A_5)
	{
		checked
		{
			double num6;
			do
			{
				double num = A_3 + A_4;
				double num2 = 0.0;
				for (int num3 = A_0; num3 >= 0; num3 += -1)
				{
					num2 = A_1[num3] + num2 * A_3;
				}
				double num4 = 0.0;
				for (int num3 = A_0; num3 >= 0; num3 += -1)
				{
					num4 = A_1[num3] + num4 * num;
				}
				double num5 = (num4 - num2) / A_4;
				if (num5 == 0.0)
				{
					return A_3;
				}
				num6 = (num2 - A_2) / num5;
				A_3 -= num6;
				A_4 /= 2.0;
			}
			while (A_4 > A_5 && Math.Abs(num6) > 0.0);
			return A_3;
		}
	}

	public static void a(double[] A_0, int A_1, short A_2, double[] A_3, ref double[] A_4)
	{
		checked
		{
			int num = A_1 - 1;
			A_4 = new double[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				int num4 = A_2;
				double num5 = A_0[num3];
				double num6 = A_3[num4];
				do
				{
					num4--;
					num6 = num5 * num6 + A_3[num4];
				}
				while (num4 != 0);
				A_4[num3] = num6;
			}
		}
	}

	public static float h(float A_0, float A_1)
	{
		float num = A_0 - A_1;
		if ((double)num > Math.PI || (double)num < -Math.PI)
		{
			num = (float)((double)num - Conversion.Int((double)num / (Math.PI * 2.0) + 0.5) * (Math.PI * 2.0));
		}
		return num;
	}

	public static float g(float A_0, float A_1)
	{
		float num = A_0 - A_1;
		if ((double)num > Math.PI * 2.0)
		{
			num = (float)((double)num - Conversion.Int((double)num / (Math.PI * 2.0)) * (Math.PI * 2.0));
		}
		else if (num < 0f)
		{
			num = (float)((double)num - Conversion.Int((double)num / (Math.PI * 2.0)) * (Math.PI * 2.0));
		}
		return num;
	}

	public static float f(float A_0, float A_1)
	{
		float num = A_0 + A_1;
		if (num < 0f)
		{
			num = (float)((double)num - Conversion.Int((double)num / (Math.PI * 2.0)) * (Math.PI * 2.0));
		}
		else if ((double)num > Math.PI * 2.0)
		{
			num = (float)((double)num - Conversion.Int((double)num / (Math.PI * 2.0)) * (Math.PI * 2.0));
		}
		return num;
	}

	public static bool a(float A_0, float A_1, float A_2, float A_3, float A_4, float A_5, float A_6)
	{
		float num = (float)Math.Sqrt((A_0 - (A_2 + A_4)) * (A_0 - (A_2 + A_4)) + (A_1 - (A_3 + A_5)) * (A_1 - (A_3 + A_5)));
		float num2 = (float)Math.Sqrt((A_0 - (A_2 - A_4)) * (A_0 - (A_2 - A_4)) + (A_1 - (A_3 - A_5)) * (A_1 - (A_3 - A_5)));
		if (num + num2 <= A_6 + 1f)
		{
			return true;
		}
		return false;
	}

	private static bool a(int A_0, List<int> A_1)
	{
		if (A_0 >= 0)
		{
			if (A_1 != null)
			{
				return A_1.IndexOf(A_0) >= 0;
			}
			return true;
		}
		return false;
	}

	public static void a(int[] A_0, int A_1, ref double A_2, ref double A_3, ref double A_4)
	{
		checked
		{
			int[] array = new int[A_1 - 1 + 1];
			A_0.CopyTo(array, 0);
			Array.Sort(array);
			if (A_1 < 4)
			{
				throw new InvalidOperationException("Zero length array");
			}
			double num = 0.5 * (double)(A_1 + 1) - 1.0;
			bool flag = unchecked(A_1 % 2) > 0;
			double num2 = Math.Floor(num);
			int num3 = (int)Math.Round(num2);
			double num4 = num - num2;
			double num5 = 1.0 - num4;
			A_3 = num5 * (double)array[num3] + num4 * (double)array[num3 + 1];
			double num6;
			double num7;
			if (flag)
			{
				num6 = 0.5 * (double)(num3 + 1) - 1.0;
				num7 = 0.5 * (double)(num3 + 2) - 1.0;
			}
			else
			{
				num6 = 0.5 * (double)(num3 + 2) - 1.0;
				num7 = 0.5 * (double)(num3 + 2) - 1.0;
			}
			double num8 = (double)(A_1 - 1) - num6;
			double num9 = (double)(A_1 - 1) - num7;
			num2 = Math.Floor(num6);
			num3 = (int)Math.Round(num2);
			num4 = num6 - num2;
			num5 = 1.0 - num4;
			A_2 = num5 * (double)array[num3] + num4 * (double)array[num3 + 1];
			if (num6 != num7)
			{
				num2 = Math.Floor(num7);
				num3 = (int)Math.Round(num2);
				num4 = num7 - num2;
				num5 = 1.0 - num4;
				A_2 = 0.5 * (A_2 + num5 * (double)array[num3] + num4 * (double)array[num3 + 1]);
			}
			num2 = Math.Floor(num8);
			num3 = (int)Math.Round(num2);
			num4 = num8 - num2;
			num5 = 1.0 - num4;
			A_4 = num5 * (double)array[num3] + num4 * (double)array[num3 + 1];
			if (num8 != num9)
			{
				num2 = Math.Floor(num9);
				num3 = (int)Math.Round(num2);
				num4 = num9 - num2;
				num5 = 1.0 - num4;
				A_4 = 0.5 * (A_4 + num5 * (double)array[num3] + num4 * (double)array[num3 + 1]);
			}
		}
	}

	public static void a(double[] A_0, double A_1, List<int> A_2, ref List<int> A_3, ref List<int> A_4, ref List<double> A_5)
	{
		checked
		{
			int num = A_0.Length - 1;
			double num2 = double.MaxValue;
			double num3 = double.MinValue;
			int item = -1;
			bool flag = false;
			int num4 = 0;
			A_3.Clear();
			A_4.Clear();
			if (A_5 != null)
			{
				A_5.Clear();
			}
			int num6 = default(int);
			int num7 = default(int);
			do
			{
				double num5 = A_0[num4];
				if (num5 > num3)
				{
					num3 = num5;
					num6 = num4;
				}
				if (num5 < num2)
				{
					num2 = num5;
					num7 = num4;
				}
				if (flag)
				{
					if (num5 < num3 - A_1)
					{
						if (a(num6, A_2))
						{
							A_4.Add(item);
							A_3.Add(num6);
							if (A_5 != null)
							{
								A_5.Add(num3);
							}
						}
						num2 = num5;
						num7 = num4;
						flag = false;
					}
				}
				else if (num5 > num2 + A_1)
				{
					item = num7;
					num3 = num5;
					num6 = num4;
					flag = true;
				}
				num4++;
			}
			while (num4 < num);
			if (A_3.Count >= A_4.Count)
			{
				A_4.Add(num7);
			}
		}
	}

	public static int a(ref double[] A_0, int A_1, double A_2, int A_3 = 0)
	{
		checked
		{
			if (A_3 >= A_1)
			{
				return A_1 - 1;
			}
			int num = A_3;
			int num2 = A_1 - 1;
			bool flag = false;
			do
			{
				if ((A_0[num] < A_2) & (num < num2))
				{
					num++;
				}
				else
				{
					flag = true;
				}
			}
			while (!flag);
			if (num > 0 && Math.Abs(A_0[num] - A_2) > Math.Abs(A_0[num - 1] - A_2))
			{
				num--;
			}
			return num;
		}
	}

	public static float c(float[] A_0, short A_1)
	{
		float num = A_0[0];
		checked
		{
			short num2 = (short)unchecked(A_1 - 1);
			for (short num3 = 1; num3 <= num2; num3 = (short)unchecked(num3 + 1))
			{
				if (A_0[num3] > num)
				{
					num = A_0[num3];
				}
			}
			return num;
		}
	}

	public static float a(ref float[] A_0, short A_1)
	{
		if (A_1 <= 0)
		{
			return 0f;
		}
		short num = 0;
		checked
		{
			short num2 = (short)unchecked(A_1 - 1);
			short num3 = (short)(unchecked(checked(A_1 + 1) / 2) - 1);
			while (num2 > num + 1)
			{
				short num4 = (short)unchecked(checked((short)unchecked(num + num2)) / 2);
				float num5 = A_0[num4];
				A_0[num4] = A_0[num + 1];
				A_0[num + 1] = num5;
				if (A_0[num] > A_0[num2])
				{
					num5 = A_0[num];
					A_0[num] = A_0[num2];
					A_0[num2] = num5;
				}
				if (A_0[num + 1] > A_0[num2])
				{
					num5 = A_0[num + 1];
					A_0[num + 1] = A_0[num2];
					A_0[num2] = num5;
				}
				if (A_0[num] > A_0[num + 1])
				{
					num5 = A_0[num];
					A_0[num] = A_0[num + 1];
					A_0[num + 1] = num5;
				}
				short num6 = (short)unchecked(num + 1);
				short num7 = num2;
				float num8 = A_0[num + 1];
				bool flag = false;
				while (true)
				{
					num6 = (short)unchecked(num6 + 1);
					if (!(A_0[num6] < num8))
					{
						do
						{
							num7 = (short)unchecked(num7 - 1);
						}
						while (A_0[num7] > num8);
						if (num7 < num6)
						{
							flag = true;
						}
						else
						{
							num5 = A_0[num6];
							A_0[num6] = A_0[num7];
							A_0[num7] = num5;
						}
						if (flag)
						{
							break;
						}
					}
				}
				A_0[num + 1] = A_0[num7];
				A_0[num7] = num8;
				if (num7 >= num3)
				{
					num2 = (short)unchecked(num7 - 1);
				}
				if (num7 <= num3)
				{
					num = num6;
				}
			}
			if ((num2 == num + 1) & (A_0[num2] < A_0[num]))
			{
				float num5 = A_0[num];
				A_0[num] = A_0[num2];
				A_0[num2] = num5;
			}
			return A_0[num3];
		}
	}

	public static float b(float[] A_0, short A_1)
	{
		if (A_1 == 0)
		{
			return 0f;
		}
		checked
		{
			short num = (short)unchecked(A_1 - 1);
			float num3 = default(float);
			for (short num2 = 0; num2 <= num; num2 = (short)unchecked(num2 + 1))
			{
				num3 += A_0[num2];
			}
			return num3 / (float)A_1;
		}
	}

	public static float a(float[] A_0, short A_1)
	{
		float num = A_0[0];
		checked
		{
			short num2 = (short)unchecked(A_1 - 1);
			for (short num3 = 1; num3 <= num2; num3 = (short)unchecked(num3 + 1))
			{
				if (A_0[num3] < num)
				{
					num = A_0[num3];
				}
			}
			return num;
		}
	}

	public static double a(ref float[] A_0, short A_1, float A_2)
	{
		if (A_1 <= 1)
		{
			return 0.0;
		}
		double num = 0.0;
		if (A_1 <= 1)
		{
			return 0.0;
		}
		checked
		{
			short num2 = (short)unchecked(A_1 - 1);
			for (short num3 = 0; num3 <= num2; num3 = (short)unchecked(num3 + 1))
			{
				float num4 = A_0[num3] - A_2;
				num += (double)(num4 * num4);
			}
			return Math.Sqrt(num / (double)(A_1 - 1));
		}
	}

	public static void a(double[] A_0, int A_1, ref double A_2, ref double A_3)
	{
		A_2 = 0.0;
		A_3 = 0.0;
		if (A_1 < 1)
		{
			return;
		}
		if (A_1 == 1)
		{
			A_2 = A_0[0];
			return;
		}
		double num = 0.0;
		double num2 = 0.0;
		checked
		{
			int num3 = A_1 - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				num += A_0[num4];
				num2 += A_0[num4] * A_0[num4];
			}
			A_2 = num / (double)A_1;
			A_3 = Math.Sqrt((num2 - (double)A_1 * A_2 * A_2) / (double)(A_1 - 1));
		}
	}

	public static double a(double[] A_0, int A_1, double[] A_2, int A_3)
	{
		checked
		{
			int num = A_1 - 1;
			int num2 = A_3 - 1;
			if (A_0[0] < A_2[0])
			{
				if (A_0[num] < A_2[0])
				{
					return 0.0;
				}
				if (A_0[num] > A_2[num2])
				{
					return A_2[num2] - A_2[0];
				}
				return A_0[num] - A_2[0];
			}
			if (A_0[0] < A_2[num2])
			{
				if (A_0[num] > A_2[num2])
				{
					return A_2[num2] - A_0[0];
				}
				return A_0[num] - A_0[0];
			}
			return 0.0;
		}
	}

	public static int a(double[,] A_0, int A_1, double[] A_2, double[] A_3)
	{
		checked
		{
			double[] array = new double[A_2.GetUpperBound(0) + 1];
			int num = A_1 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				array[num2] = A_2[num2];
			}
			int num3 = A_1 - 2;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				double num5 = 0.0;
				int num6 = -1;
				int num7 = num4;
				int num8 = A_1 - 1;
				for (int num2 = num7; num2 <= num8; num2++)
				{
					if (Math.Abs(A_0[num2, num4]) > num5)
					{
						num5 = Math.Abs(A_0[num2, num4]);
						num6 = num2;
					}
				}
				if (num5 == 0.0)
				{
					return -1;
				}
				if (num6 != num4)
				{
					int num9 = num4;
					int num10 = A_1 - 1;
					double num12;
					for (int num11 = num9; num11 <= num10; num11++)
					{
						num12 = A_0[num4, num11];
						A_0[num4, num11] = A_0[num6, num11];
						A_0[num6, num11] = num12;
					}
					num12 = array[num4];
					array[num4] = array[num6];
					array[num6] = num12;
				}
				double num13 = A_0[num4, num4];
				int num14 = num4 + 1;
				int num15 = A_1 - 1;
				for (int num2 = num14; num2 <= num15; num2++)
				{
					double num16 = A_0[num2, num4] / num13;
					A_0[num2, num4] = 0.0;
					int num17 = num4 + 1;
					int num18 = A_1 - 1;
					for (int num11 = num17; num11 <= num18; num11++)
					{
						A_0[num2, num11] -= num16 * A_0[num4, num11];
					}
					array[num2] -= num16 * array[num4];
				}
			}
			for (int num4 = A_1 - 1; num4 >= 0; num4 += -1)
			{
				double num19 = array[num4];
				int num20 = num4 + 1;
				int num21 = A_1 - 1;
				for (int num11 = num20; num11 <= num21; num11++)
				{
					num19 -= A_0[num4, num11] * A_3[num11];
				}
				A_3[num4] = num19 / A_0[num4, num4];
			}
			return 0;
		}
	}

	public static double a(double A_0, int A_1)
	{
		double num = ((A_0 == 0.0) ? 1E-25 : Math.Pow(10.0, (double)A_1 - Conversion.Int(Math.Log10(Math.Abs(A_0))) - 1.0));
		return Conversion.Int(A_0 * num + 0.5) / num;
	}

	public static float b(float A_0)
	{
		if (A_0 == 0f)
		{
			return A_0;
		}
		if (A_0 > 0f)
		{
			return A_0 * 1.0000001f;
		}
		return A_0 * 0.9999999f;
	}

	public static double b(double A_0)
	{
		if (A_0 == 0.0)
		{
			return A_0;
		}
		if (A_0 > 0.0)
		{
			return A_0 * 1.00000000000001;
		}
		return A_0 * 0.99999999999999;
	}

	public static float a(float A_0)
	{
		if (A_0 == 0f)
		{
			return A_0;
		}
		if (A_0 > 0f)
		{
			return A_0 * 0.9999999f;
		}
		return A_0 * 1.0000001f;
	}

	public static double a(double A_0)
	{
		if (A_0 == 0.0)
		{
			return A_0;
		}
		if (A_0 > 0.0)
		{
			return A_0 * 0.99999999999999;
		}
		return A_0 * 1.00000000000001;
	}

	public static bool e(float A_0, float A_1)
	{
		if (A_0 == 0f && A_1 == 0f)
		{
			return true;
		}
		if (A_1 == 0f)
		{
			return false;
		}
		return Math.Abs((A_0 - A_1) / A_1) < 1E-07f;
	}

	public static bool e(double A_0, float A_1)
	{
		return e((float)A_0, A_1);
	}

	public static bool e(float A_0, double A_1)
	{
		return e(A_0, (float)A_1);
	}

	public static bool e(double A_0, double A_1)
	{
		if (A_0 == 0.0 && A_1 == 0.0)
		{
			return true;
		}
		if (A_1 == 0.0)
		{
			return false;
		}
		return Math.Abs((A_0 - A_1) / A_1) < 1E-14;
	}

	public static bool d(float A_0, float A_1)
	{
		if (e(A_0, A_1))
		{
			return false;
		}
		return A_0 < A_1;
	}

	public static bool d(double A_0, float A_1)
	{
		return d((float)A_0, A_1);
	}

	public static bool d(float A_0, double A_1)
	{
		return d(A_0, (float)A_1);
	}

	public static bool d(double A_0, double A_1)
	{
		if (e(A_0, A_1))
		{
			return false;
		}
		return A_0 < A_1;
	}

	public static bool c(float A_0, float A_1)
	{
		if (e(A_0, A_1))
		{
			return true;
		}
		return A_0 < A_1;
	}

	public static bool c(double A_0, float A_1)
	{
		return c((float)A_0, A_1);
	}

	public static bool c(float A_0, double A_1)
	{
		return c(A_0, (float)A_1);
	}

	public static bool c(double A_0, double A_1)
	{
		if (e(A_0, A_1))
		{
			return true;
		}
		return A_0 < A_1;
	}

	public static bool b(float A_0, float A_1)
	{
		if (e(A_0, A_1))
		{
			return false;
		}
		return A_0 > A_1;
	}

	public static bool b(double A_0, float A_1)
	{
		return b((float)A_0, A_1);
	}

	public static bool b(float A_0, double A_1)
	{
		return b(A_0, (float)A_1);
	}

	public static bool b(double A_0, double A_1)
	{
		if (e(A_0, A_1))
		{
			return false;
		}
		return A_0 > A_1;
	}

	public static bool a(float A_0, float A_1)
	{
		if (e(A_0, A_1))
		{
			return true;
		}
		return A_0 > A_1;
	}

	public static bool a(double A_0, float A_1)
	{
		return a((float)A_0, A_1);
	}

	public static bool a(float A_0, double A_1)
	{
		return a(A_0, (float)A_1);
	}

	public static bool a(double A_0, double A_1)
	{
		if (e(A_0, A_1))
		{
			return true;
		}
		return A_0 > A_1;
	}

	public static double a(Random A_0)
	{
		if (v)
		{
			v = false;
			return w;
		}
		double num;
		double num2;
		double num3;
		do
		{
			num = 2.0 * A_0.NextDouble() - 1.0;
			num2 = 2.0 * A_0.NextDouble() - 1.0;
			num3 = num * num + num2 * num2;
		}
		while ((num3 >= 1.0) | (num3 == 0.0));
		double num4 = Math.Sqrt(-2.0 * Math.Log(num3) / num3);
		w = num2 * num4;
		v = true;
		return num * num4;
	}
}
