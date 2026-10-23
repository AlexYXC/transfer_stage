using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FIUsbIntLib;

[ComImport]
[CompilerGenerated]
[TypeIdentifier]
[Guid("4033C9B9-C12D-4A00-B6A1-6D7E572571C3")]
public interface IFIUsbSpectrometer
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1)]
	void Connect([In] int bUseFirstAvail, [In][MarshalAs(UnmanagedType.BStr)] string ControllerSN, [In] byte ucDevIdx, [In][Out] ref int plErrCode);

	virtual void _VtblGap1_2();

	[DispId(4)]
	byte DeviceRevLevel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		get;
	}

	[DispId(5)]
	string FriendlySN
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(6)]
	byte FWSpectromBitPat
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(6)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(6)]
		[param: In]
		set;
	}

	[DispId(7)]
	int FWCorrupt
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(7)]
		get;
	}

	virtual void _VtblGap2_3();

	[DispId(10)]
	DateTime FWLastUpdate
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(10)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(10)]
		[param: In]
		set;
	}

	[DispId(11)]
	byte FWRevNum
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(11)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(11)]
		[param: In]
		set;
	}

	[DispId(12)]
	int FWUpdateRevLevel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		[param: In]
		set;
	}

	[DispId(13)]
	int FWWriteEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		get;
	}

	[DispId(14)]
	string SerialNumber
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(14)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(14)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(15)]
	float FWCalOffset
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(15)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(15)]
		[param: In]
		set;
	}

	[DispId(16)]
	float FWCalSlope
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		[param: In]
		set;
	}

	[DispId(17)]
	float FWCalCurv
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		[param: In]
		set;
	}

	[DispId(18)]
	float FWDCScatter
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(18)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(18)]
		[param: In]
		set;
	}

	[DispId(19)]
	float FWLinInt
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(19)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(19)]
		[param: In]
		set;
	}

	[DispId(20)]
	float FWLinSlope
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(20)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(20)]
		[param: In]
		set;
	}

	[DispId(21)]
	FMUSBDeviceType eSpectromType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(22)]
	void WriteFirmware([In][Out] ref int lErrCode);

	[DispId(23)]
	double IntegrationTime
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(23)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(24)]
	int SetIntegrationTime([In] double newVal);

	[DispId(25)]
	double MinIntegrationTime
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(25)]
		get;
	}

	[DispId(26)]
	double MaxIntegrationTime
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(26)]
		get;
	}

	virtual void _VtblGap3_1();

	[DispId(28)]
	int NumPixels
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(28)]
		get;
	}

	virtual void _VtblGap4_10();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(37)]
	int GetSpectraStart([In] short sNumSpectra, [In] short sNumAveragesPerSpectrum, [In][Out] ref int plGroupID);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(38)]
	int GetSpectraStatus([In] int groupID, [In][Out] ref short numSpectraFinished, [In][Out] ref short allDone, [In][Out] ref float subFractionComplete, [In][Out] ref float fractionComplete);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(39)]
	int GetSpectraAbort([In] int groupID);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(40)]
	int GetSpectraFinish([In] int groupID, [In] short sNumSpectra, [In] short sSmoothPts, [In][Out] ref int pbZeroError, [In][Out] ref int pbSatError, [In][Out] ref int pbIntTimeError, [In][Out] ref double actualIntTime, [In] int lBufferSize, [In][Out] ref double pdBuffer, [In][Out] ref double elapsedTimes_s);

	virtual void _VtblGap5_1();

	// C# has no syntax for parameterized property 'QuantizedIntegrationTime_ms'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: DispId(42)]
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(42)]
	double get_QuantizedIntegrationTime_ms([In] double requestedIntegrationTime_ms);

	virtual void _VtblGap6_1();

	[DispId(44)]
	float FWWaveRangeStart
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(44)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(44)]
		[param: In]
		set;
	}

	[DispId(45)]
	float FWWaveRangeEnd
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(45)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(45)]
		[param: In]
		set;
	}

	[DispId(46)]
	byte FWDevSpecificRevNum
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(46)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(46)]
		[param: In]
		set;
	}

	[DispId(47)]
	byte FWDevSpecificHighestCompatRevLev
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(47)]
		get;
	}

	virtual void _VtblGap7_2();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(50)]
	void SetFirstLastValidPixelIdx([In] int newFirstIdx, [In] int newLastIdx);

	[DispId(51)]
	int NumHWPixels
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(51)]
		get;
	}

	virtual void _VtblGap8_1();

	[DispId(53)]
	float FWDCScatterLong
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(53)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(53)]
		[param: In]
		set;
	}

	[DispId(54)]
	float FWDCScatterTransWaveStart
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(54)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(54)]
		[param: In]
		set;
	}

	[DispId(55)]
	float FWDCScatterTransWaveEnd
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(55)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(55)]
		[param: In]
		set;
	}

	[DispId(56)]
	float FWDCScatterShort
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(56)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(56)]
		[param: In]
		set;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(57)]
	int GetSpectraSmoothedAndUnsmoothedSafe([In] short sNumSpectra, [In] short sNumAveragesPerSpectrum, [In] short sSmoothPts, [In][Out] ref int bZeroError, [In][Out] ref int bSatError, [In] int lBufferSize, [In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R8)] Array dBufferSmoothed, [In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R8)] Array dBufferUnsmoothed);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(58)]
	int GetSpectraSafe([In] short sNumSpectra, [In] short sNumAveragesPerSpectrum, [In] short sSmoothPts, [In][Out] ref int bZeroError, [In][Out] ref int bSatError, [In] int lBufferSize, [In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R8)] Array dBuffer);

	[DispId(59)]
	int HWTrueDark
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(59)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(60)]
	int IntTimesEqual([In] double intTime1, [In] double intTime2);

	virtual void _VtblGap9_1();

	[DispId(62)]
	short FWAtoDOffsetRegisterSetting
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(62)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(62)]
		[param: In]
		set;
	}

	[DispId(63)]
	short FWChannel0SoftwareOffset
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(63)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(63)]
		[param: In]
		set;
	}

	[DispId(64)]
	short FWChannel1SoftwareOffset
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(64)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(64)]
		[param: In]
		set;
	}

	virtual void _VtblGap10_1();

	[DispId(66)]
	short FWAtoDGainRegisterSetting
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(66)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(67)]
	void CorrectForScatterSafe([In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R8)] Array specDataRawNoDark, [In] int numPts, [In] int lastShortWavePt, [In] int firstLongWavePt);

	[DispId(68)]
	float ReadoutNoiseRms
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(68)]
		get;
	}

	[DispId(69)]
	float FullWellNumElectrons
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(69)]
		get;
	}

	virtual void _VtblGap11_2();

	[DispId(71)]
	byte FWLinVer
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(71)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(71)]
		[param: In]
		set;
	}

	// C# has no syntax for parameterized property 'FWLinV2Coeff'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: DispId(72)]
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(72)]
	float get_FWLinV2Coeff([In] byte coeffIdx);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(72)]
	void set_FWLinV2Coeff([In] byte coeffIdx, [In] float pVal);

	virtual void _VtblGap12_2();

	[DispId(75)]
	float PGAGainSetting
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(75)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(76)]
	int ReadTemperature([In] SpectromTempSensorLoc sensorLoc, out float fTemperatureDegC);

	// C# has no syntax for parameterized property 'FWLinV2CoeffT2'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: DispId(77)]
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(77)]
	float get_FWLinV2CoeffT2([In] byte coeffIdx);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(77)]
	void set_FWLinV2CoeffT2([In] byte coeffIdx, [In] float pVal);

	// C# has no syntax for parameterized property 'FWLinCoeffTemperature'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: DispId(78)]
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(78)]
	float get_FWLinCoeffTemperature([In] short coeffSetID);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(78)]
	void set_FWLinCoeffTemperature([In] short coeffSetID, [In] float pVal);

	virtual void _VtblGap13_1();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(80)]
	void CorrectForLinearitySafe2([In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R8)] Array specDataRawNoDark, [In] int numPts, [In] float detectorTemperature);

	// C# has no syntax for parameterized property 'TemperatureSensorExists'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: DispId(81)]
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(81)]
	int get_TemperatureSensorExists([In] SpectromTempSensorLoc sensorLoc);

	[DispId(82)]
	int LightSourceIsStrobe
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(82)]
		get;
	}

	virtual void _VtblGap14_2();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(85)]
	void GetFirstLastValidPixelIdx(out int firstIdx, out int lastIdx);

	[DispId(86)]
	short FWShortScatterBroadNumPts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(86)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(86)]
		[param: In]
		set;
	}

	[DispId(87)]
	float FWShortScatterBroadSlopeCoeff
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(87)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(87)]
		[param: In]
		set;
	}

	[DispId(88)]
	float FWShortScatterBroadInterceptCoeff
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(88)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(88)]
		[param: In]
		set;
	}

	[DispId(89)]
	short FWShortScatterNarrowNumPts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(89)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(89)]
		[param: In]
		set;
	}

	[DispId(90)]
	float FWShortScatterNarrowCoeff
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(90)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(90)]
		[param: In]
		set;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(91)]
	int CalibrateVGAGain(out short psNewGainSetting);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(92)]
	void SetFWAtoDGainRegisterSetting([In] short newVal);

	[DispId(93)]
	short BuiltInMemorySize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(93)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(94)]
	void ReadBuiltInMemory([In] short sNumBytes, [In] short sStartAddr, [In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_UI1)] Array pucSafeBuffer, [In][Out] ref int lErrCode);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(95)]
	void WriteBuiltInMemory([In] short sNumBytes, [In] short sStartAddr, [In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_UI1)] Array pucSafeBuffer, [In][Out] ref int lErrCode);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(96)]
	void ReadMemBlockID([In] byte blockIdx, [In][Out] ref byte type, [In][Out][MarshalAs(UnmanagedType.BStr)] ref string ident, [In][Out] ref double date, [In][Out] ref ushort sDataNumBytes, [In][Out] ref ushort sDataStartAddr, [In][Out] ref ushort sBlockNumBytes, [In][Out] ref ushort sBlockStartAddr, [In][Out] ref int lErrCode);

	// C# has no syntax for parameterized property 'FWSecondOrderCoeffs'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: DispId(97)]
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(97)]
	float get_FWSecondOrderCoeffs([In] byte coeffIdx);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(97)]
	void set_FWSecondOrderCoeffs([In] byte coeffIdx, [In] float pVal);

	[DispId(98)]
	float FWResolution
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(98)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(98)]
		[param: In]
		set;
	}

	[DispId(99)]
	float FWResolutionSlope
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(99)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(99)]
		[param: In]
		set;
	}

	[DispId(100)]
	float FWResolutionRefWavelength
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		[param: In]
		set;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(101)]
	void SetSecondOrderTable([In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R4)] Array secondOrderTable, [In] short bufferSize);

	[DispId(102)]
	short FWSecondOrderNumPts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		get;
	}

	[DispId(103)]
	float FWSecondOrderAvgRatio
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		get;
	}

	virtual void _VtblGap15_1();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(105)]
	int UpdateWavelengthOffset([In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R8)] Array measuredSpec);

	[DispId(106)]
	float FWCalOffsetDelta
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(106)]
		get;
	}

	[DispId(107)]
	float CalOffsetDeltaDelta
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(107)]
		get;
	}

	[DispId(108)]
	float EffectiveCalOffset
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(108)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(109)]
	int SetCalibrateDataFilePath([In][MarshalAs(UnmanagedType.BStr)] string caliDataPath, [In][MarshalAs(UnmanagedType.BStr)] string debugDataPath);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(110)]
	int EnableDisableHighVoltage([In] int enable);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(111)]
	int SetLightSourceCalibLampPowerOnState([In] int enable);

	[DispId(112)]
	int HasHighVoltageGenerator
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(112)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(113)]
	int GetLightSourceCalibLampPowerOnState(out int powerOn);

	[DispId(114)]
	float FWNextCalPeakLeftWidth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(114)]
		get;
	}

	[DispId(115)]
	float FWNextCalPeakRightWidth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(115)]
		get;
	}

	[DispId(116)]
	float FWNextCalOffsetDelta
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(116)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(117)]
	void DeletePendingFW();

	[DispId(118)]
	float FixedCalOffset
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(118)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(119)]
	void GetFirstLastValidPixelDueToHW(out int firstIdx, out int lastIdx);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(120)]
	int SetAcqStatusLEDEnableState([In] int enable);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(121)]
	int RefreshHardwareSettings();

	virtual void _VtblGap16_1();

	[DispId(123)]
	float FWCalTemp1
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(123)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(123)]
		[param: In]
		set;
	}

	[DispId(124)]
	float FWCalOffset2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(124)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(124)]
		[param: In]
		set;
	}

	[DispId(125)]
	float FWCalSlope2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(125)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(125)]
		[param: In]
		set;
	}

	[DispId(126)]
	float FWCalCurv2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(126)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(126)]
		[param: In]
		set;
	}

	[DispId(127)]
	float FWCalTemp2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(127)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(127)]
		[param: In]
		set;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(128)]
	int CalibrateAtoDOffset2(out short psNewHWOffsetSetting, out short psNewSWOffsetEvenSetting, out short psNewSWOffsetOddSetting);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(129)]
	int CalibrateAtoDGain2(out short psNewGainSetting);

	virtual void _VtblGap17_1();

	[DispId(131)]
	float GainProgress
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(131)]
		get;
	}

	[DispId(132)]
	byte FWScatterNumberOfLEDSources
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(132)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(132)]
		[param: In]
		set;
	}

	[DispId(133)]
	short FWScatterNumberOfDetectedRegions
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(133)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(133)]
		[param: In]
		set;
	}

	[DispId(134)]
	short FWScatterNumberOfExtendedDetectedRegions
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(134)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(134)]
		[param: In]
		set;
	}

	[DispId(135)]
	short FWScatterNumberOfReducedWavePts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(135)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(135)]
		[param: In]
		set;
	}

	[DispId(136)]
	short FWScatterNumberOfInterpSourcePts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(136)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(136)]
		[param: In]
		set;
	}

	[DispId(137)]
	double FWScatterEfficiency
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(137)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(137)]
		[param: In]
		set;
	}

	[DispId(138)]
	double FWScatterMaxCoeff
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(138)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(138)]
		[param: In]
		set;
	}

	[DispId(139)]
	double FWScatterExtendedPointSpacing
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(139)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(139)]
		[param: In]
		set;
	}

	[DispId(140)]
	short FWScatterExtendedPointOffset
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(140)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(140)]
		[param: In]
		set;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(141)]
	int SetFWScatterLEDArrays([In] short sNumLEDSources, [In] short sNumExtendedDetectedRegions, [In][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R4)] Array fLEDIndices, [In][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R4)] Array fLEDWidths, [In][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_UI2)] Array usScattCoeffs);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(142)]
	int GetFWScatterLEDArrays([In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R4)] Array fLEDIndices, [In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R4)] Array fLEDWidths, [In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_UI2)] Array usScattCoeffs);

	[DispId(143)]
	byte FWScatterUseLEDCalibIfAvailable
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(143)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(143)]
		[param: In]
		set;
	}

	[DispId(144)]
	int HasTwoStageTEC
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(144)]
		get;
	}

	[DispId(145)]
	int TECCircuitIsCalibrated
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(145)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(145)]
		[param: In]
		set;
	}

	[DispId(146)]
	float TECCircuitSupplyPotRMax
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(146)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(146)]
		[param: In]
		set;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(147)]
	int CalibrateTECCircuit(out float newTECSupplyPotRMax);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(148)]
	void GetTECCirCalStatusInfo(out int started, out float tempDelta, out float detTemp, out int detTSlopeKnown, out float detTSlope);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(149)]
	void RequestCancelProcess();

	[DispId(150)]
	float MaxTECSetpoint
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(150)]
		get;
	}

	[DispId(151)]
	float TECTemperatureSetpoint
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(151)]
		get;
	}

	virtual void _VtblGap18_1();

	[DispId(153)]
	float FWLEDScatterLongOffset
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(153)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(153)]
		[param: In]
		set;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(154)]
	int RefreshWriteEnabledState();

	[DispId(155)]
	float ScatterLEDTransWaveStart
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(155)]
		get;
	}

	[DispId(156)]
	float ScatterLEDTransWaveEnd
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(156)]
		get;
	}

	[DispId(157)]
	short FirstFirmwareRevThatSupportsScatterLED
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(157)]
		get;
	}

	[DispId(158)]
	short FirstFirmwareRevThatSupportsScatterLEDOffset
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(158)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(159)]
	int SetTECSetpoint2([In] float newTemperature, [In] int setAsPowerOnSetting, [In] int powerIsRegularUsb, [In] int powerIsChargePort);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(160)]
	int SetTECSupplyNVSetpoint2([In] float newTemperature, [In] int powerIsRegularUsb, [In] int powerIsChargePort);

	[DispId(161)]
	float FWWaveLengthOf2ndOrderFilterEdge
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		[param: In]
		set;
	}

	[DispId(162)]
	double PostIntegrationReadoutTime
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(162)]
		get;
	}

	virtual void _VtblGap19_1();

	[DispId(164)]
	int HasGPIOBits
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(164)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(165)]
	int SetStrobeModeEnable([In] int enable);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(166)]
	int SetGPIOBit([In] int value);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(167)]
	int GetGPIOBit([In] ref int value);

	virtual void _VtblGap20_2();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(169)]
	int SetExtTrigEnable([In] int enable);

	virtual void _VtblGap21_1();

	[DispId(171)]
	int EnableActiveCalParams
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(171)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(171)]
		[param: In]
		set;
	}

	[DispId(172)]
	float FWCalOffsetDeltaOffset
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(172)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(172)]
		[param: In]
		set;
	}

	virtual void _VtblGap22_1();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(174)]
	int UpdateWavelenCal2([In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R8)] Array measuredSpec, [In] float offsetDeltaOffset);

	[DispId(175)]
	float NotchSharpenAmplitude
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(175)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(175)]
		[param: In]
		set;
	}

	[DispId(176)]
	float NotchSharpenInterval
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(176)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(176)]
		[param: In]
		set;
	}

	[DispId(177)]
	float FWCalThird
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(177)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(177)]
		[param: In]
		set;
	}

	[DispId(178)]
	float FWCalFourth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(178)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(178)]
		[param: In]
		set;
	}

	[DispId(179)]
	float FWCalThird2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(179)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(179)]
		[param: In]
		set;
	}

	[DispId(180)]
	float FWCalFourth2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(180)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(180)]
		[param: In]
		set;
	}

	virtual void _VtblGap23_1();

	[DispId(182)]
	float FWBaselineLinearityAmplitude
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(182)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(182)]
		[param: In]
		set;
	}

	[DispId(183)]
	float FWBaselineLinearityAmplitudeT
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(183)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(183)]
		[param: In]
		set;
	}

	[DispId(184)]
	float FWNextCalOffsetDeltaOffset
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(184)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(185)]
	void SetPendingFWCalDelete();

	[DispId(186)]
	float FWTransCurvedCorrection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(186)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(186)]
		[param: In]
		set;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(187)]
	int FindPeaks3([In][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R4)] Array measSpec, [In] int numPeaks, [In][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R4)] Array nomPeakInPixOrNm, [In] int isPeakInPix, [In][MarshalAs(UnmanagedType.BStr)] string settingsFile, [In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R4)] Array actualPeakPix, out float leftWidth, out float rightWidth, [In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R4)] Array actualPeak10PercentCenterPix, [In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R4)] Array actualPeak10PercentWidthPix, [In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R4)] Array actualPeak50PercentCenterPix, [In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_R4)] Array actualPeak50PercentWidthPix);
}
