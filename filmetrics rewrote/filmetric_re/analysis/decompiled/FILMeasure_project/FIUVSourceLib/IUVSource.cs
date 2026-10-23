using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FIUVSourceLib;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[Guid("EB632DAB-8614-4FCF-9F94-7613D6532AF9")]
public interface IUVSource
{
	virtual void _VtblGap1_5();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(6)]
	int Connect([In] int connectToAnySource, [In][MarshalAs(UnmanagedType.BStr)] string sourceGuid);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(7)]
	int SetD2LampState([In] int lampOn);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(8)]
	int SetTHLampState([In] int lampOn);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(9)]
	int SetShutterState([In] int openShutter);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(10)]
	int GetShutterStatus([In][Out] ref int shutterIsOpen);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(11)]
	int GetStatus([In][Out] ref int d2LampIsOn, [In][Out] ref int thLampIsOn, [In][Out] ref int d2LampFault, [In][Out] ref int thLampBurnedOut, [In][Out] ref int overTemperature, [In][Out] ref int d2LampIsWarmingUp);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(12)]
	int SetFrontPanelDisable([In] int disableFrontPanel);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(13)]
	int GetFPDisableStatus([In][Out] ref int frontPanelIsDisabled);

	[DispId(14)]
	FMUVSourceSubTypes SystemSubtype
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(14)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(15)]
	int GetLampOnTime([In] int thLamp, out float onTimeHrs, out uint eventCount, out uint eventCountRemaining, out float onTimeRemainingHrs);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(16)]
	int ResetLampOnTime([In] int thLamp);

	// C# has no syntax for parameterized property 'HasLampOnTimer'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: DispId(17)]
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(17)]
	int get_HasLampOnTimer([In] int thLamp);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(18)]
	int GetFanStatus(out int fanFail, out float fanRpm);

	virtual void _VtblGap2_2();

	[DispId(21)]
	int D2LampOnRequestedViaUSB
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		get;
	}

	[DispId(22)]
	int THLampOnRequestedViaUSB
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(22)]
		get;
	}

	[DispId(23)]
	int ShutterOpenRequestedViaUSB
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(23)]
		get;
	}

	virtual void _VtblGap3_1();

	[DispId(25)]
	FISystemTypesUV SystemTypeUV
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(25)]
		get;
	}
}
