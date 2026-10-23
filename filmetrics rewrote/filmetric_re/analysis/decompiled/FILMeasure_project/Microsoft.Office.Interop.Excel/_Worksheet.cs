using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel;

[ComImport]
[CompilerGenerated]
[Guid("000208D8-0000-0000-C000-000000000046")]
[TypeIdentifier]
public interface _Worksheet
{
	virtual void _VtblGap1_5();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[LCIDConversion(0)]
	[DispId(117)]
	void Delete();

	virtual void _VtblGap2_4();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[LCIDConversion(2)]
	[DispId(637)]
	void Move([Optional][In][MarshalAs(UnmanagedType.Struct)] object Before, [Optional][In][MarshalAs(UnmanagedType.Struct)] object After);

	[DispId(110)]
	string Name
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(110)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(110)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	virtual void _VtblGap3_17();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(235)]
	[LCIDConversion(1)]
	void Select([Optional][In][MarshalAs(UnmanagedType.Struct)] object Replace);

	virtual void _VtblGap4_3();

	[DispId(1377)]
	Shapes Shapes
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1377)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	virtual void _VtblGap5_10();

	[DispId(238)]
	Range Cells
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(238)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	virtual void _VtblGap6_42();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(211)]
	[LCIDConversion(2)]
	void Paste([Optional][In][MarshalAs(UnmanagedType.Struct)] object Destination, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Link);

	virtual void _VtblGap7_4();

	// C# has no syntax for parameterized property 'Range'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: DispId(197)]
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(197)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Range get_Range([In][MarshalAs(UnmanagedType.Struct)] object Cell1, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Cell2);
}
