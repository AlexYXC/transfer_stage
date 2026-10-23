using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FIUsbIntLib;

[ComImport]
[TypeIdentifier]
[Guid("55B882B7-5E20-43E5-B36A-AC604F98ADC1")]
[CompilerGenerated]
public interface IFMusbEnum
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1)]
	void EnumerateDevice([In] int lControllerIdx, [In] int lDeviceIdx, [In][Out] ref FMUSBIntErr eErrCode, [In][Out][MarshalAs(UnmanagedType.BStr)] ref string deviceSN, [In][Out][MarshalAs(UnmanagedType.BStr)] ref string deviceFriendlySN, [In][Out] ref FMUSBDeviceType eDeviceType, [In][Out] ref byte ucDeviceRevLevel);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(2)]
	void GetVersion([In][Out] ref short VerMSH, [In][Out] ref short VerMSL, [In][Out] ref short VerLSH, [In][Out] ref short VerLSL);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(3)]
	int ResetMicro([In] byte ucControllerIdx);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(4)]
	void Close();

	virtual void _VtblGap1_1();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(6)]
	void EnumerateController2([In] int lControllerIdx, [In][Out] ref FMUSBIntErr eErrCode, [In][Out][MarshalAs(UnmanagedType.BStr)] ref string deviceSN, [In][Out][MarshalAs(UnmanagedType.BStr)] ref string deviceFriendlySN, [In][Out] ref FMUSBDeviceType eDeviceType, [In][Out] ref byte ucDeviceRevLevel, [In][Out] ref byte ucSubsystemIdx, [In][Out] ref FMLegacyAllSystemTypes peSystemType, [In][Out] ref byte pucSystemSubtype);

	[DispId(7)]
	int XPVer
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(7)]
		get;
	}
}
