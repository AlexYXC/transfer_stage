using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FISerBuffMultPrj;

[ComImport]
[Guid("0AE78230-D1BA-4389-BDA5-01E0EDAA23FF")]
[CompilerGenerated]
[TypeIdentifier]
public interface _FISerBuffMult
{
	virtual void _VtblGap1_2();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809349)]
	int Init2([In] short intPortID, [In][Out][MarshalAs(UnmanagedType.BStr)] ref string strSettings, [In] bool blnBinary, [In][Out][MarshalAs(UnmanagedType.IDispatch)] ref object objCreator);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809350)]
	void AddToQueue([In][MarshalAs(UnmanagedType.Struct)] object varTheData, [In] float sngTimeout, [In] int lngCommandId, [In] bool blnAwaitCorrectResponse, [In] int lngCorrectResponse, [In] bool blnInstrTypeFilm, [In] bool blnInstrTypeMotor, [In] short intMotorAddr = 0);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809351)]
	int GetFromQueue([In] bool motorQueue, [In] short motorAddress, [In] int commandId, [In][Out] ref int RespCode, [In][Out][MarshalAs(UnmanagedType.Struct)] ref object RespData);

	// C# has no syntax for parameterized property 'SendQueueEmpty'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: DispId(1745027072)]
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1745027072)]
	bool get_SendQueueEmpty([In] bool motorQueue, [In] short motorAddress = 0);

	virtual void _VtblGap2_1();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809353)]
	void StopFirmwareApp();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809356)]
	void ShutDown();
}
