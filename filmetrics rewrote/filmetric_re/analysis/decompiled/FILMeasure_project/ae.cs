using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class ae
{
	internal enum a : short
	{
		a,
		b
	}

	internal enum b : short
	{
		a,
		b
	}

	public enum c
	{
		a = -1001,
		b = -1002,
		c = -1003,
		d = -1004,
		e = -1005,
		f = -1006,
		g = -1007,
		h = -1008,
		i = -1009,
		j = -1010,
		k = -1011,
		l = -1012,
		m = -1013,
		n = -1014,
		o = -1015,
		p = -1016,
		q = -1017,
		r = -1018,
		s = -1019,
		t = -1020,
		u = -1021
	}

	internal const int a = -1014;

	internal const int b = -1020;

	internal const int c = -1020;

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int FMImageVer(ref short A_0, ref short A_1, ref short A_2, ref short A_3);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int GrabImageStart2(short A_0, short A_1, a A_2, short A_3, ref short A_4);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int GetImageSize(short A_0, ref short A_1, ref short A_2);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int ReportAvgFrameFromData(int A_0, int A_1, short A_2, float A_3, float A_4, ref float A_5);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int GetImageData(short A_0, ref byte A_1);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int FMImageGetFrameTime(short A_0, ref double A_1);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int FMImageGetIntTime(short A_0, ref double A_1);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int ReportCompAvgFrame(ref float A_0, short A_1, short A_2, short A_3, ref float A_4, float A_5, short A_6, float A_7, float A_8, short A_9, ref float A_10, ref float A_11);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int SetHWNumCameras(int A_0);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int AssemblePartialRawImage(short A_0, ref byte A_1, short A_2, short A_3, short A_4);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int IntensityCorrectImage(ref byte A_0, short A_1, short A_2, ref byte A_3, ref float A_4, ref float A_5);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int AngleCompCorrectImage(ref byte A_0, short A_1, short A_2, float A_3, short A_4, ref byte A_5, short A_6, short A_7);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int StretchImageAndPasteIntoImage(ref byte A_0, short A_1, short A_2, float A_3, ref byte A_4, short A_5, ref short A_6, short A_7);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int InitCam(short A_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_1, short A_2);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern short NumFramesAcquired(short A_0);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int FMImageSetIntTime(short A_0, double A_1, double A_2);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int FMImageSetFrameSize(short A_0, short A_1);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern short PRSpecCompare2(ref float A_0, ref double A_1, ref float A_2, short A_3, short A_4, ref float A_5, short A_6, short A_7, ref short A_8, ref short A_9, short A_10, int A_11);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern short PRSetBitmapBits(ref byte A_0, short A_1, short A_2, short A_3, ref byte A_4);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int ReportCompSpectrumFromData(short A_0, short A_1, short A_2, short A_3, short A_4, short A_5, short A_6, ref float A_7, float A_8, short A_9, float A_10, float A_11, short A_12, short A_13, ref float A_14, ref float A_15, ref float A_16, ref short A_17, ref short A_18, ref float A_19);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern short PRDetermineMaxInten(ref byte A_0, short A_1, short A_2, short A_3, short A_4, ref float A_5, ref float A_6, ref float A_7);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern short IRResetImages();

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern short TargetNumFramesToBeAcquired(short A_0);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int GetTotalImageBufSizeInBytes();

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern short PRSpliceImageOntoImage(ref byte A_0, short A_1, short A_2, float A_3, short A_4, short A_5, short A_6, short A_7, ref short A_8, ref short A_9, ref byte A_10, short A_11, short A_12);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int FMImageCalcMinFrameTime(short A_0, double A_1, ref double A_2, ref double A_3);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int FMImageCalcMaxIntTime(short A_0, double A_1, ref double A_2, ref double A_3);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int SSSetROIStart(short A_0, short A_1, short A_2, short A_3);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int SetGrabStartDelay(int A_0);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern void FMUpdateTargetSpec2(short A_0, short A_1, ref double A_2, ref double A_3, int A_4, ref double A_5, ref double A_6, float A_7, float A_8, float A_9, short A_10);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern float FMGOFGivenSpectra(ref double A_0, short A_1, short A_2, ref double A_3);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern void FMOptimizeCalCoeffs(float A_0, float A_1, ref float A_2, ref float A_3, ref float A_4, ref float A_5, short A_6, short A_7, ref double A_8, ref double A_9, int A_10, ref double A_11, ref double A_12, ref double A_13, short A_14);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern short IRRenderPartialFloatGOFImage(float A_0, float A_1, short A_2, short A_3, ref short A_4, ref short A_5, ref short A_6, short A_7, short A_8, ref float A_9, short A_10, short A_11, ref short A_12, ref short A_13, [MarshalAs(UnmanagedType.VBByRefStr)] ref string A_14, float A_15, float A_16, float A_17, short A_18, short A_19, int A_20, ref float A_21, ref float A_22, short A_23, ref int A_24);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int MUInterpolateArray(ref double A_0, ref double A_1, int A_2, ref double A_3, ref double A_4, int A_5);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int MUInterpolatePrepare(ref double A_0, int A_1, ref double A_2, int A_3, ref int A_4, ref int A_5, ref double A_6, ref double A_7);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int MUDistSensorAverageDataBasedOnTime(ref short A_0, int A_1, float A_2, ref float A_3, short A_4, ref short A_5, float A_6, float A_7);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int MUParseDistSensorReadingsStream(ref byte A_0, int A_1, ref short A_2, ref int A_3, ref float A_4, short A_5, short A_6, short A_7);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern short IRGetAvgSpecFromRotImage(float A_0, float A_1, short A_2, short A_3, float A_4, float A_5, float A_6, int A_7, int A_8, ref float A_9, ref float A_10, ref float A_11, ref float A_12, ref int A_13, ref int A_14);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern short ICBMPFromFloatImage(ref float A_0, int A_1, short A_2, float A_3, ref byte A_4);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int ICBuildColorImageSafe(Array A_0, Array A_1, Array A_2, Array A_3, ref float A_4, ref float A_5, long A_6, long A_7, ref long A_8);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern short ICBuildColorImage(ref byte A_0, ref byte A_1, ref byte A_2, ref float A_3, ref float A_4, ref float A_5, int A_6, int A_7);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int FMImageGetTimingExtraPixelsPerRow(ref int A_0);

	[DllImport("fmimage.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int FMImageCalcMinFrameTimeTheoretical(int A_0, short A_1, short A_2, double A_3, ref double A_4, ref double A_5);
}
