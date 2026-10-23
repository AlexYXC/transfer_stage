using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class f6
{
	internal enum a
	{
		a = 0,
		b = a,
		c = 1,
		d = 2,
		e = 3,
		f = 4,
		g = 5,
		h = 6
	}

	internal enum b
	{
		a = 0,
		b = a,
		c = 1,
		d = c,
		e = 2,
		f = 3,
		g = 4,
		h = 5,
		i = 6,
		j = 7,
		k = 8
	}

	public enum c
	{
		a = 0,
		b = -100,
		c = -101,
		d = -102,
		e = -103,
		f = -104,
		g = -105,
		h = -106,
		i = -107,
		j = -108,
		k = -109,
		l = -110
	}

	internal enum d
	{
		a = 0,
		b = -1,
		c = -2,
		d = -3,
		e = -4,
		f = -5,
		g = -6,
		h = -7,
		i = -8
	}

	internal enum e : short
	{
		a = -13,
		b = -10,
		c = 1,
		d = 2,
		e = 3,
		f = 4,
		g = 5,
		h = 6,
		i = 7,
		j = 8,
		k = 9,
		l = 10,
		m = 11,
		n = 12,
		o = 13,
		p = 14,
		q = 15,
		r = 16,
		s = 17,
		t = 18,
		u = 19,
		v = 20,
		w = 21,
		x = 22,
		y = 23,
		z = 24,
		aa = 25,
		ab = 26,
		ac = 27,
		ad = 28,
		ae = 29,
		af = 30,
		ag = 31,
		ah = 32,
		ai = 33,
		aj = 34,
		ak = 35,
		al = 36,
		am = 37,
		an = 38,
		ao = 39,
		ap = 40,
		aq = 41,
		ar = 42,
		@as = 43,
		at = 44,
		au = 45,
		av = 46,
		aw = 47
	}

	public const float a = 5E-05f;

	public static string a()
	{
		return i3.o() + "\\SolverReports\\";
	}

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short FMSolveVer(short A_0);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short FFTSolve(short A_0, ref double A_1, ref double A_2, short A_3, ref double A_4, ref short A_5, ref double A_6, ref double A_7);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short InitializeThreads();

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short ExitThreads();

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short NumberOfCPUs();

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern object ExtremaSolve(short A_0, ref double A_1, ref double A_2, short A_3, ref double A_4, ref short A_5, ref double A_6, ref double A_7, ref double A_8);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short FFTSolveShort(short A_0, ref double A_1, ref short A_2, short A_3, ref double A_4, ref short A_5, ref double A_6, ref double A_7);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short FFTSolveTD(short A_0, ref float A_1, ref float A_2, short A_3, ref double A_4, double A_5, double A_6);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short CorrectForLinearity(ref double A_0, int A_1, double A_2, float A_3);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void ReportModelInfo2(short A_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_1, ref short A_2, ref short A_3, ref short A_4, ref short A_5, ref short A_6);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void ReportModelParamName(short A_0, short A_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_2, ref short A_3);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void CalculateModelNK(short A_0, float A_1, ref float A_2, short A_3, short A_4, ref float A_5, ref float A_6);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve(short A_0, short A_1, float A_2, float A_3, short A_4, double A_5, short A_6, short A_7, ref double A_8, short A_9, ref short A_10, ref double A_11, ref double A_12, short A_13, ref double A_14, ref double A_15, ref short A_16, ref double A_17, ref double A_18, ref double A_19, ref short A_20, ref double A_21);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve2(short A_0, short A_1, float A_2, float A_3, short A_4, double A_5, short A_6, short A_7, ref double A_8, short A_9, ref short A_10, ref double A_11, ref double A_12, short A_13, ref double A_14, ref double A_15, ref short A_16, ref double A_17, ref double A_18, ref double A_19, ref short A_20, ref double A_21, ref short A_22);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve3(short A_0, short A_1, float A_2, float A_3, short A_4, double A_5, short A_6, short A_7, ref double A_8, short A_9, ref short A_10, ref double A_11, ref double A_12, short A_13, ref double A_14, ref double A_15, ref short A_16, ref double A_17, ref double A_18, ref double A_19, ref short A_20, ref double A_21, ref short A_22);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve5(short A_0, short A_1, float A_2, float A_3, short A_4, float A_5, short A_6, double A_7, short A_8, short A_9, ref double A_10, short A_11, ref short A_12, ref double A_13, ref double A_14, ref double A_15, short A_16, ref double A_17, ref double A_18, ref double A_19, ref short A_20, ref double A_21, ref double A_22, ref double A_23, ref short A_24, ref double A_25, ref short A_26);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short SolveSpectrumAvgCenteredOnZero(short A_0);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve6(short A_0, short A_1, float A_2, float A_3, short A_4, float A_5, short A_6, double A_7, short A_8, short A_9, ref double A_10, short A_11, ref short A_12, ref double A_13, short A_14, ref double A_15, ref double A_16, short A_17, ref double A_18, ref double A_19, ref double A_20, ref short A_21, ref double A_22, ref double A_23, ref double A_24, ref short A_25, ref double A_26, ref short A_27, ref short A_28);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve7(short A_0, short A_1, float A_2, float A_3, short A_4, short A_5, short A_6, ref double A_7, short A_8, ref short A_9, ref double A_10, ref double A_11, short A_12, ref double A_13, ref double A_14, ref short A_15, ref double A_16, ref double A_17, ref double A_18, ref short A_19, ref double A_20, ref short A_21, ref float A_22, ref float A_23, short A_24);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve8(short A_0, short A_1, float A_2, float A_3, short A_4, float A_5, short A_6, short A_7, short A_8, ref double A_9, short A_10, ref short A_11, ref double A_12, ref double A_13, ref double A_14, short A_15, ref double A_16, ref double A_17, ref double A_18, ref short A_19, ref double A_20, ref double A_21, ref double A_22, ref short A_23, ref double A_24, ref short A_25, ref float A_26, ref float A_27, short A_28);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve9(short A_0, short A_1, float A_2, float A_3, short A_4, short A_5, short A_6, ref double A_7, short A_8, ref short A_9, ref double A_10, short A_11, ref double A_12, ref double A_13, short A_14, ref double A_15, ref double A_16, ref double A_17, ref short A_18, ref double A_19, ref double A_20, ref double A_21, ref short A_22, ref double A_23, ref short A_24, ref short A_25, ref float A_26, ref float A_27, short A_28, ref double A_29);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve10(short A_0, short A_1, float A_2, float A_3, short A_4, double A_5, short A_6, short A_7, ref double A_8, short A_9, ref short A_10, ref double A_11, ref double A_12, short A_13, ref double A_14, ref double A_15, ref short A_16, ref double A_17, ref double A_18, ref double A_19, ref short A_20, ref double A_21, ref short A_22, ref float A_23);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve11(short A_0, short A_1, float A_2, float A_3, short A_4, float A_5, short A_6, double A_7, short A_8, short A_9, ref double A_10, short A_11, ref short A_12, ref double A_13, short A_14, ref double A_15, ref double A_16, short A_17, ref double A_18, ref double A_19, ref double A_20, ref short A_21, ref double A_22, ref double A_23, ref double A_24, ref short A_25, ref double A_26, ref short A_27, ref short A_28, ref float A_29);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve12(short A_0, short A_1, float A_2, float A_3, short A_4, short A_5, short A_6, ref double A_7, short A_8, ref short A_9, ref double A_10, short A_11, ref double A_12, ref double A_13, short A_14, ref double A_15, ref double A_16, ref double A_17, ref short A_18, ref double A_19, ref double A_20, ref double A_21, ref short A_22, ref double A_23, ref short A_24, ref short A_25, ref float A_26, ref float A_27, short A_28, ref double A_29, ref float A_30);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve13(short A_0, short A_1, float A_2, float A_3, short A_4, double A_5, short A_6, short A_7, ref double A_8, short A_9, ref short A_10, ref double A_11, ref double A_12, short A_13, ref double A_14, ref double A_15, ref short A_16, ref double A_17, ref double A_18, ref double A_19, ref short A_20, ref double A_21, ref short A_22, short A_23, ref float A_24, ref short A_25);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve14(short A_0, short A_1, float A_2, float A_3, short A_4, float A_5, short A_6, double A_7, short A_8, short A_9, ref double A_10, short A_11, ref short A_12, ref double A_13, short A_14, ref double A_15, ref double A_16, short A_17, ref double A_18, ref double A_19, ref double A_20, ref short A_21, ref double A_22, ref double A_23, ref double A_24, ref short A_25, ref double A_26, ref short A_27, ref short A_28, short A_29, ref float A_30, ref short A_31);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve15(short A_0, short A_1, float A_2, float A_3, short A_4, short A_5, short A_6, ref double A_7, short A_8, ref short A_9, ref double A_10, short A_11, ref double A_12, ref double A_13, short A_14, ref double A_15, ref double A_16, ref double A_17, ref short A_18, ref double A_19, ref double A_20, ref double A_21, ref short A_22, ref double A_23, ref short A_24, ref short A_25, ref float A_26, ref float A_27, short A_28, ref double A_29, short A_30, ref float A_31, ref short A_32);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve17(short A_0, short A_1, float A_2, float A_3, short A_4, double A_5, short A_6, short A_7, ref double A_8, short A_9, ref short A_10, ref double A_11, ref double A_12, ref double A_13, short A_14, ref double A_15, ref double A_16, ref short A_17, ref double A_18, ref double A_19, ref double A_20, ref short A_21, ref double A_22, ref short A_23, short A_24, ref float A_25, ref short A_26, long A_27);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve18(short A_0, short A_1, float A_2, float A_3, short A_4, float A_5, short A_6, double A_7, short A_8, short A_9, ref double A_10, short A_11, ref short A_12, ref double A_13, ref double A_14, ref double A_15, short A_16, ref double A_17, ref double A_18, ref double A_19, ref short A_20, ref double A_21, ref double A_22, ref double A_23, ref short A_24, ref double A_25, ref short A_26, ref short A_27, short A_28, ref float A_29, ref short A_30, long A_31);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve19(short A_0, short A_1, float A_2, float A_3, short A_4, short A_5, short A_6, ref double A_7, short A_8, ref short A_9, ref double A_10, ref double A_11, ref double A_12, short A_13, ref double A_14, ref double A_15, ref double A_16, ref short A_17, ref double A_18, ref double A_19, ref double A_20, ref short A_21, ref double A_22, ref short A_23, ref short A_24, ref float A_25, ref float A_26, short A_27, ref double A_28, short A_29, ref float A_30, ref short A_31, long A_32);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve20(short A_0, short A_1, float A_2, float A_3, short A_4, short A_5, short A_6, ref double A_7, short A_8, ref short A_9, ref double A_10, ref double A_11, ref double A_12, short A_13, ref double A_14, ref double A_15, ref double A_16, ref short A_17, ref double A_18, ref double A_19, ref double A_20, ref short A_21, ref double A_22, ref short A_23, ref short A_24, ref float A_25, ref float A_26, short A_27, ref double A_28, ref float A_29, ref short A_30, ref short A_31, ref float A_32, ref short A_33, long A_34);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve20(short A_0, short A_1, float A_2, float A_3, short A_4, short A_5, short A_6, ref double A_7, short A_8, ref short A_9, ref double A_10, IntPtr A_11, ref double A_12, short A_13, ref double A_14, ref double A_15, ref double A_16, ref short A_17, ref double A_18, ref double A_19, ref double A_20, ref short A_21, ref double A_22, ref short A_23, ref short A_24, ref float A_25, ref float A_26, short A_27, ref double A_28, IntPtr A_29, ref short A_30, ref short A_31, ref float A_32, ref short A_33, long A_34);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve21(short A_0, short A_1, float A_2, float A_3, ref short A_4, ref short A_5, ref short A_6, ref double A_7, ref short A_8, ref short A_9, ref double A_10, ref double A_11, ref double A_12, ref short A_13, ref double A_14, ref double A_15, ref double A_16, ref short A_17, ref double A_18, ref double A_19, ref double A_20, ref short A_21, ref double A_22, ref short A_23, ref short A_24, ref float A_25, ref float A_26, ref short A_27, ref double A_28, ref short A_29, ref float A_30, ref short A_31, long A_32, short A_33, ref short A_34, ref short A_35, ref double A_36);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve22(short A_0, short A_1, float A_2, float A_3, ref short A_4, ref short A_5, ref short A_6, ref double A_7, ref short A_8, ref short A_9, ref double A_10, ref double A_11, ref double A_12, ref short A_13, ref double A_14, ref double A_15, ref double A_16, ref short A_17, ref double A_18, ref double A_19, ref double A_20, ref short A_21, ref double A_22, ref short A_23, ref short A_24, ref float A_25, ref float A_26, ref short A_27, ref double A_28, ref short A_29, ref float A_30, ref short A_31, long A_32, short A_33, ref short A_34, ref short A_35, ref double A_36, short A_37, short A_38, ref short A_39, short A_40, ref short A_41, ref double A_42, ref double A_43, float A_44, ref double A_45, ref double A_46);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve23(short A_0, short A_1, float A_2, float A_3, ref short A_4, ref short A_5, ref short A_6, ref double A_7, ref short A_8, ref short A_9, ref double A_10, ref double A_11, ref double A_12, ref short A_13, ref double A_14, ref double A_15, ref double A_16, ref short A_17, ref double A_18, ref double A_19, ref double A_20, ref short A_21, ref double A_22, ref short A_23, ref short A_24, ref float A_25, ref float A_26, ref short A_27, ref double A_28, ref short A_29, ref float A_30, ref short A_31, ref short A_32, ref float A_33, ref short A_34, long A_35, short A_36, ref short A_37, ref short A_38, ref double A_39, short A_40, short A_41, ref short A_42, short A_43, ref short A_44, ref double A_45, ref double A_46, float A_47, ref double A_48, ref double A_49);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve24(short A_0, short A_1, float A_2, float A_3, ref short A_4, ref short A_5, ref short A_6, ref double A_7, ref short A_8, ref short A_9, ref double A_10, ref double A_11, ref double A_12, ref short A_13, ref double A_14, ref double A_15, ref double A_16, ref short A_17, ref double A_18, ref double A_19, ref double A_20, ref short A_21, ref double A_22, ref short A_23, ref short A_24, ref float A_25, ref float A_26, ref short A_27, ref double A_28, ref short A_29, ref float A_30, ref short A_31, ref short A_32, ref float A_33, ref short A_34, long A_35, short A_36, ref short A_37, ref short A_38, ref double A_39, short A_40, short A_41, ref short A_42, short A_43, ref short A_44, ref double A_45, ref double A_46, float A_47, ref double A_48, ref double A_49, short A_50);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short Solve25(short A_0, short A_1, float A_2, float A_3, ref short A_4, ref short A_5, ref short A_6, ref double A_7, ref short A_8, ref short A_9, ref double A_10, ref double A_11, ref double A_12, ref short A_13, ref double A_14, ref double A_15, ref double A_16, ref short A_17, ref double A_18, ref double A_19, ref double A_20, ref short A_21, ref double A_22, ref short A_23, ref short A_24, ref float A_25, ref float A_26, ref short A_27, ref double A_28, ref short A_29, ref float A_30, ref short A_31, ref short A_32, ref float A_33, ref short A_34, long A_35, short A_36, ref short A_37, ref short A_38, ref double A_39, short A_40, short A_41, ref short A_42, short A_43, ref short A_44, ref double A_45, ref double A_46, float A_47, ref double A_48, ref double A_49, short A_50, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_51);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void SetOutputFilesPath([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short ComputeNumGOFIndices(ref short A_0, short A_1);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short ComputeGofIndicesAndWeights(ref short A_0, short A_1, ref float A_2, ref short A_3, short A_4, ref float A_5, short A_6);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short CalculateHCMeasureFirstLastWavelen(ref double A_0, ref double A_1, int A_2, ref double A_3, ref double A_4, ref int A_5, ref int A_6);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short CorrectSpectrumForHC(float A_0, ref double A_1, ref double A_2, int A_3, ref double A_4, ref double A_5);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short CalculateExtrema2(ref double A_0, ref double A_1, int A_2, double A_3, double A_4, short A_5, ref double A_6, ref double A_7, short A_8);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short SolveCTM4(short A_0, short A_1, float A_2, float A_3, short A_4, ref double A_5, ref double A_6, ref double A_7, short A_8, ref double A_9, ref double A_10, ref short A_11, ref double A_12, long A_13, short A_14, short A_15, bool A_16, ref double A_17, bool A_18, ref float A_19);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short SolveExponential(short A_0, float A_1, float A_2, short A_3, ref double A_4, ref double A_5, ref double A_6, ref double A_7, ref double A_8, ref short A_9, long A_10);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short GenerateFFTThicknessData([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0, short A_1, ref double A_2, ref double A_3, short A_4, ref double A_5, ref short A_6, ref double A_7, ref double A_8);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void FFTPrepare(short A_0, ref double A_1, short A_2, ref double A_3, ref short A_4, ref double A_5, ref double A_6, ref double A_7, ref short A_8, int A_9, ref int A_10, ref short A_11);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void FFTPrepare2(short A_0, ref double A_1, short A_2, ref double A_3, ref short A_4, ref double A_5, ref double A_6, ref double A_7, ref short A_8, int A_9, ref int A_10, ref short A_11, ref short A_12, ref int A_13);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FFTStreamlined2(short A_0, ref double A_1, ref double A_2, ref double A_3, int A_4, short A_5, short A_6, short A_7, double A_8, int A_9, ref double A_10, ref double A_11);

	[DllImport("fmintonly.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int WriteFIBNKFile2([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0, short A_1, int A_2, int A_3, ref double A_4, ref double A_5, ref double A_6, int A_7, ref double A_8, ref short A_9, int A_10, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_11, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_12, int A_13, ref short A_14, ref int A_15, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_16);

	[DllImport("fmintonly.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int WriteFMNNNFile([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0, short A_1, int A_2, int A_3, ref double A_4, ref double A_5, int A_6, ref double A_7, ref short A_8, int A_9);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int SolveNProb([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0, short A_1, int A_2, int A_3, ref double A_4, ref double A_5, int A_6, ref double A_7, ref short A_8, int A_9);

	[DllImport("fmintonly.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int WriteFMKKKFile([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0, short A_1, ref double A_2, ref double A_3, int A_4);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int SolveKProb([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0, short A_1, ref double A_2, ref double A_3, int A_4);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern d ReadFIBNKFile3([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0, ref int A_1, ref int A_2, ref double A_3, ref int A_4, ref double A_5, ref double A_6, ref int A_7, ref double A_8, ref short A_9, ref int A_10, ref short A_11, [In][Out][MarshalAs(UnmanagedType.BStr)] ref string A_12, [In][Out][MarshalAs(UnmanagedType.BStr)] ref string A_13, ref int A_14, [In][Out][MarshalAs(UnmanagedType.BStr)] ref string A_15, ref int A_16, ref short A_17, ref int A_18, [In][Out][MarshalAs(UnmanagedType.BStr)] ref string A_19);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern d ParseFIBNKFileBuffer(ref byte A_0, uint A_1, ref int A_2, ref int A_3, ref double A_4, ref int A_5, ref double A_6, ref double A_7, ref int A_8, ref double A_9, ref short A_10, ref int A_11, ref short A_12, [In][Out][MarshalAs(UnmanagedType.BStr)] ref string A_13, [In][Out][MarshalAs(UnmanagedType.BStr)] ref string A_14, ref int A_15, [In][Out][MarshalAs(UnmanagedType.BStr)] ref string A_16, ref int A_17, ref short A_18, ref int A_19, [In][Out][MarshalAs(UnmanagedType.BStr)] ref string A_20);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int ReadFMNNNFile([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0, ref int A_1, ref int A_2, ref int A_3, ref int A_4, ref double A_5, ref int A_6, ref double A_7, ref int A_8, ref double A_9, ref short A_10, ref int A_11, ref short A_12);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int ReadFMKKKFile([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0, ref int A_1, ref int A_2, ref double A_3, ref int A_4, ref double A_5, ref int A_6, ref short A_7);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern void SmoothSpectrumGivenThickness(float A_0, ref double A_1, ref double A_2, int A_3, ref double A_4);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern void BoxSmoothSpectrum(int A_0, ref double A_1, int A_2, ref double A_3);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern void BRElimination(float A_0, int A_1, ref double A_2, ref double A_3, ref double A_4);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern void ClearTerminationRequest2(long A_0);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern void SetTerminationRequest2(long A_0);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern void SetAcceptCurrentAnalysisResult(long A_0);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern long UniqueMeasEngineID();

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int GetCalculationStatus(long A_0, ref int A_1, ref int A_2, ref int A_3, ref int A_4, ref int A_5, ref short A_6, ref float A_7, ref short A_8, ref int A_9, ref short A_10, ref int A_11, ref int A_12, ref int A_13, ref short A_14, ref int A_15, ref int A_16);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int GetCurrentCalcSpectraStatus(long A_0, ref short A_1);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int GetCurrentCalcSpectra(long A_0, ref double A_1, int A_2);

	[DllImport("fmsolve.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int PSOptimalPath2(ref float A_0, ref float A_1, int A_2, short A_3, float A_4, float A_5, float A_6, float A_7, float A_8, float A_9, ref int A_10, short A_11, ref float A_12, ref float A_13, ref float A_14, ref float A_15, short A_16, float A_17);
}
