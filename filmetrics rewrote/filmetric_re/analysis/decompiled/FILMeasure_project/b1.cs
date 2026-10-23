using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class b1
{
	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int ICComputeSpectrumColor(ref double A_0, ref float A_1, ref float A_2, ref float A_3, ref float A_4, ref float A_5, short A_6, long A_7, int A_8, ref int A_9);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int ICRefreshCoeffs2(ref float A_0, int A_1, ref byte A_2, int A_3, short A_4, int A_5, long A_6, int A_7, ref int A_8, ref short A_9);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int ICInitFromFiles([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int ICCreateCObj(long A_0);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern void ICDeleteCObj(long A_0, int A_1);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int ConvertImageXYZToCIELab(float A_0, float A_1, float A_2, ref float A_3, ref float A_4, ref float A_5, short A_6, long A_7, int A_8, ref int A_9);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int ConvertImageXYZToCIELuv(float A_0, float A_1, float A_2, ref float A_3, ref float A_4, ref float A_5, short A_6, long A_7, int A_8, ref int A_9);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int ConvertImageCIELabToCIELch(float A_0, float A_1, float A_2, ref float A_3, ref float A_4, ref float A_5);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int FIImageVer(ref short A_0, ref short A_1, ref short A_2, ref short A_3);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern void FIInterpolatePrepare(ref double A_0, int A_1, ref double A_2, int A_3, ref int A_4, ref int A_5, ref double A_6, ref double A_7);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int ImageFocusGoodness(ref IntPtr A_0, int A_1, int A_2, int A_3, int A_4, int A_5, int A_6, int A_7, ref double A_8);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int ImageFocusGoodnessWithExclusionZone(ref IntPtr A_0, int A_1, int A_2, int A_3, int A_4, int A_5, int A_6, int A_7, int A_8, int A_9, int A_10, int A_11, ref double A_12);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int EdgeLocate(ref IntPtr A_0, int A_1, int A_2, int A_3, int A_4, int A_5, int A_6, int A_7, short A_8, ref float A_9, ref float A_10, ref float A_11, ref float A_12, ref short A_13, ref short A_14);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int EdgeFocusGoodness(ref IntPtr A_0, float A_1, float A_2, int A_3, float A_4, float A_5, int A_6, int A_7, int A_8, int A_9, int A_10, int A_11, int A_12, int A_13, short A_14, ref double A_15, ref double A_16, ref double A_17, ref double A_18, ref double A_19, ref double A_20);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int EdgeFocusGoodness2(ref IntPtr A_0, float A_1, float A_2, int A_3, float A_4, float A_5, int A_6, int A_7, int A_8, int A_9, int A_10, int A_11, int A_12, int A_13, short A_14, ref double A_15, ref double A_16, ref double A_17, ref double A_18, ref double A_19, ref double A_20, ref double A_21);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern short IRSetImage(short A_0, short A_1, ref byte A_2);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern short IRSetup4(ref short A_0, ref short A_1, ref float A_2, ref int A_3, ref float A_4, ref float A_5, ref float A_6, ref float A_7, ref float A_8, ref float A_9, float A_10, float A_11, int A_12, ref float A_13, ref float A_14);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern short IRRenderPartialFloatRotImage2(float A_0, float A_1, short A_2, short A_3, short A_4, short A_5, float A_6, float A_7, float A_8, short A_9, short A_10, ref float A_11, ref float A_12);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern void IRInitializeThreads();

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern void IRExitThreads();

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int MUEdgeImageCreate(ref float A_0, int A_1, int A_2, ref float A_3, ref float A_4, short A_5, short A_6, ref float A_7, ref float A_8, short A_9, short A_10, int A_11, int A_12, float A_13);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int MUShrinkImage(ref float A_0, int A_1, int A_2, ref float A_3, int A_4, int A_5, short A_6, int A_7, int A_8, int A_9, int A_10, float A_11);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern short IRFindRegMark3(ref float A_0, short A_1, int A_2, ref short A_3, ref short A_4, ref float A_5, short A_6, int A_7, ref short A_8, ref short A_9, short A_10, short A_11, float A_12, float A_13, ref float A_14, ref float A_15, short A_16, ref int A_17, ref int A_18, ref short A_19, ref short A_20, short A_21, ref float A_22, short A_23);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern short IRFindRegMark4(ref float A_0, short A_1, int A_2, ref short A_3, ref short A_4, ref float A_5, short A_6, int A_7, ref short A_8, ref short A_9, ref byte A_10, short A_11, short A_12, float A_13, float A_14, ref float A_15, ref float A_16, short A_17, ref int A_18, ref int A_19, ref short A_20, ref short A_21, short A_22, ref float A_23, short A_24, ref short A_25, ref short A_26);

	[DllImport("FIImage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int ImageAvgIntensity(ref byte A_0, int A_1, int A_2, int A_3, int A_4, int A_5, int A_6, int A_7, int A_8, ref float A_9);
}
