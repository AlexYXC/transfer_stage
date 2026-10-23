using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Office.Core;

namespace Microsoft.Office.Interop.Excel;

[ComImport]
[Guid("00024439-0000-0000-C000-000000000046")]
[InterfaceType(2)]
[TypeIdentifier]
[CompilerGenerated]
public interface Shape
{
	virtual void _VtblGap1_12();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1684)]
	void ScaleHeight([In] float Factor, [In] MsoTriState RelativeToOriginalSize, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Scale);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1688)]
	void ScaleWidth([In] float Factor, [In] MsoTriState RelativeToOriginalSize, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Scale);
}
