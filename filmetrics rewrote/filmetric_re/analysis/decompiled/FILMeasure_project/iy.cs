using System;
using System.Collections.Generic;

internal class iy
{
	public static void a(int A_0, float[] A_1, int A_2, double A_3, ref ushort A_4, ref ushort[] A_5)
	{
		checked
		{
			int num = A_0 - 1;
			double[] array = new double[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				array[num3] = Convert.ToDouble(A_1[num3]);
			}
			a(A_0, array, A_2, A_3, ref A_4, ref A_5);
		}
	}

	public static void a(int A_0, double[] A_1, int A_2, double A_3, ref ushort A_4, ref ushort[] A_5)
	{
		checked
		{
			int num = A_0 - 1;
			double[] array = new double[num + 1];
			int num2 = A_2 + 1;
			A_4 = (ushort)Math.Round(Math.Ceiling((double)A_0 / (double)num2));
			if (unchecked(checked(A_0 + A_2) % num2) > 0)
			{
				A_4 = (ushort)unchecked((uint)(A_4 + 1));
			}
			A_5 = new ushort[A_4 - 1 + 1];
			f6.BoxSmoothSpectrum(A_2 * 2 + 1, ref A_1[0], A_0, ref array[0]);
			int num3 = A_4 - 2;
			double num5;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				num5 = Math.Max(array[num4 * num2], 0.0);
				A_5[num4] = (ushort)Math.Round(num5 * A_3);
			}
			num5 = Math.Max(array[num], 0.0);
			A_5[A_4 - 1] = (ushort)Math.Round(num5 * A_3);
		}
	}

	public static float[] b(int A_0, double A_1, ushort A_2, int A_3, ushort[] A_4)
	{
		checked
		{
			int num = A_0 - 1;
			float[] array = new float[num + 1];
			double[] array2 = a(A_0, A_1, A_2, A_3, A_4);
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				array[num3] = Convert.ToSingle(array2[num3]);
			}
			return array;
		}
	}

	public static double[] a(int A_0, double A_1, ushort A_2, int A_3, ushort[] A_4)
	{
		List<double> list = new List<double>();
		int num6;
		int num7;
		checked
		{
			int num = A_3 + 1;
			int num2 = A_2 - 2;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				for (int num4 = 0; num4 <= A_3; num4++)
				{
					unchecked
					{
						double num5 = ((double)(int)A_4[checked(num3 + 1)] - (double)(int)A_4[num3]) / (double)num;
						list.Add(((double)(int)A_4[num3] + num5 * (double)num4) / A_1);
					}
				}
			}
			num6 = A_0 - (A_2 - 1) * num;
			num7 = num6 - 1;
		}
		for (int num8 = 0; num8 <= num7; num8 = checked(num8 + 1))
		{
			double num5 = ((double)(int)A_4[checked(A_2 - 1)] - (double)(int)A_4[checked(A_2 - 2)]) / (double)num6;
			list.Add(((double)(int)A_4[checked(A_2 - 2)] + num5 * (double)checked(num8 + 1)) / A_1);
		}
		return list.ToArray();
	}
}
