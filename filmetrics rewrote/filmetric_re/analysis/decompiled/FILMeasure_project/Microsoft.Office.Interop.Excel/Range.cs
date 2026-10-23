using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel;

[ComImport]
[Guid("00020846-0000-0000-C000-000000000046")]
[TypeIdentifier]
[InterfaceType(2)]
[CompilerGenerated]
public interface Range : IEnumerable
{
	virtual void _VtblGap1_18();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1067)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object BorderAround([Optional][In][MarshalAs(UnmanagedType.Struct)] object LineStyle, [Optional][DefaultParameterValue(2)][In] XlBorderWeight Weight, [Optional][DefaultParameterValue(-4105)][In] XlColorIndex ColorIndex, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Color);

	virtual void _VtblGap2_2();

	[DispId(238)]
	Range Cells
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(238)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	virtual void _VtblGap3_23();

	[IndexerName("_Default")]
	[DispId(0)]
	object this[[Optional][In][MarshalAs(UnmanagedType.Struct)] object RowIndex, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ColumnIndex]
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(0)]
		[param: Optional]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	virtual void _VtblGap4_16();

	[DispId(146)]
	Font Font
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(146)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	virtual void _VtblGap5_28();

	[DispId(129)]
	Interior Interior
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(129)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	virtual void _VtblGap6_52();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(235)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Select();

	virtual void _VtblGap7_27();

	// C# has no syntax for parameterized property 'Value'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: DispId(6)]
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(6)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object get_Value([Optional][In][MarshalAs(UnmanagedType.Struct)] object RangeValueDataType);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(6)]
	void set_Value([Optional][In][MarshalAs(UnmanagedType.Struct)] object RangeValueDataType, [Optional][In][MarshalAs(UnmanagedType.Struct)] object A_2);

	[DispId(1388)]
	object Value2
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1388)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1388)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}
}
