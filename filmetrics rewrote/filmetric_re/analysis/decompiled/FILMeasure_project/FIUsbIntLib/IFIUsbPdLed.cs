using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FIUsbIntLib;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[Guid("E3C63D48-B239-442C-8A89-4B8EFA454710")]
public interface IFIUsbPdLed
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1)]
	int Connect([In] int useFirstAvail, [In][MarshalAs(UnmanagedType.BStr)] string ControllerSN, [In] byte devIdx);

	[DispId(2)]
	string SerialNumber
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(3)]
	int FWCorrupt
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		get;
	}

	[DispId(4)]
	string FriendlySN
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	virtual void _VtblGap1_1();

	[DispId(6)]
	DateTime FWLastUpdate
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
	byte FWRevNum
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(7)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(7)]
		[param: In]
		set;
	}

	[DispId(8)]
	int FWUpdateRevLevel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(8)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(8)]
		[param: In]
		set;
	}

	[DispId(9)]
	int FWWriteEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(9)]
		get;
	}

	[DispId(10)]
	byte FWNumPhotodiodes
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
	byte FWDevSpecificRevNum
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
	byte FWDevSpecificHighestCompatRevLev
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(13)]
	int WriteFirmware();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(14)]
	int TriggerAcquisition([In] short numSampleBlocks);

	[DispId(15)]
	int SamplesPerSampleBlock
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(15)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(16)]
	int RetrieveAcquiredData([In] short numSampleBlocks, [In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_UI2)] Array chan0Buffer, [In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_UI2)] Array chan1Buffer, [In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_UI2)] Array chan2Buffer, [In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_UI2)] Array sampleBlockIds, [In][Out][MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_UI1)] Array satErrorStatus);

	[DispId(17)]
	byte DeviceRevLevel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		get;
	}

	[DispId(18)]
	double SamplingFrequency
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(18)]
		get;
	}

	[DispId(19)]
	int MaxNumSampleBlocksInBuffer
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(19)]
		get;
	}

	// C# has no syntax for parameterized property 'ChannelIsActive'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: DispId(20)]
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(20)]
	int get_ChannelIsActive([In] byte channelIdx);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(21)]
	int SetActiveChannels([In] int chan0Active, [In] int chan1Active, [In] int chan2Active);

	// C# has no syntax for parameterized property 'Gain'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: DispId(22)]
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(22)]
	float get_Gain([In] byte channelIdx);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(23)]
	int SetGain([In] byte channelIdx, [In] float targetGain);

	// C# has no syntax for parameterized property 'GainMin'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: DispId(24)]
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(24)]
	float get_GainMin([In] byte channelIdx);

	// C# has no syntax for parameterized property 'GainMax'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: DispId(25)]
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(25)]
	float get_GainMax([In] byte channelIdx);

	[DispId(26)]
	int MaxADValue
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(26)]
		get;
	}

	// C# has no syntax for parameterized property 'FWPDWavelength'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: DispId(27)]
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(27)]
	float get_FWPDWavelength([In] byte channelIdx);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(27)]
	void set_FWPDWavelength([In] byte channelIdx, [In] float pVal);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(28)]
	int GainsAreEqual([In] byte channelIdx, [In] float gain1, [In] float gain2);
}
