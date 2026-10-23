using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel;

[ComImport]
[Guid("000208DA-0000-0000-C000-000000000046")]
[TypeIdentifier]
[CompilerGenerated]
public interface _Workbook
{
	virtual void _VtblGap1_20();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(277)]
	[LCIDConversion(3)]
	void Close([Optional][In][MarshalAs(UnmanagedType.Struct)] object SaveChanges, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Filename, [Optional][In][MarshalAs(UnmanagedType.Struct)] object RouteWorkbook);

	virtual void _VtblGap2_103();

	[DispId(494)]
	Sheets Worksheets
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(494)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	virtual void _VtblGap3_40();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[LCIDConversion(12)]
	[DispId(1925)]
	void SaveAs([Optional][In][MarshalAs(UnmanagedType.Struct)] object Filename, [Optional][In][MarshalAs(UnmanagedType.Struct)] object FileFormat, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Password, [Optional][In][MarshalAs(UnmanagedType.Struct)] object WriteResPassword, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ReadOnlyRecommended, [Optional][In][MarshalAs(UnmanagedType.Struct)] object CreateBackup, [Optional][DefaultParameterValue(1)][In] XlSaveAsAccessMode AccessMode, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ConflictResolution, [Optional][In][MarshalAs(UnmanagedType.Struct)] object AddToMru, [Optional][In][MarshalAs(UnmanagedType.Struct)] object TextCodepage, [Optional][In][MarshalAs(UnmanagedType.Struct)] object TextVisualLayout, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Local);
}
