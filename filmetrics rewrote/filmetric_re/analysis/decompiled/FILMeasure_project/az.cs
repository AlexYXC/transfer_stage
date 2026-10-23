using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class az
{
	[ComImport]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("DC1C5A9C-E88A-4DDE-A5A1-60F82A20AEF7")]
	internal class a
	{
	}

	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("42F85136-DB7E-439C-85F1-E4075D135FC8")]
	internal interface b
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint a([In] IntPtr A_0 = default(IntPtr));

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint a([In] uint A_0, [In][MarshalAs(UnmanagedType.LPArray)] IntPtr A_1);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint a([In] uint A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint a(out uint A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint a([In][MarshalAs(UnmanagedType.Interface)] IntPtr A_0, out uint A_1);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint b([In] uint A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint c([In] uint A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint b(out uint A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void a([In][MarshalAs(UnmanagedType.Interface)] c A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint b([In][MarshalAs(UnmanagedType.Interface)] c A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint a([MarshalAs(UnmanagedType.Interface)] out c A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint b([MarshalAs(UnmanagedType.Interface)] out c A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint a([In][MarshalAs(UnmanagedType.LPWStr)] string A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint a([MarshalAs(UnmanagedType.LPWStr)] out string A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint b([In][MarshalAs(UnmanagedType.LPWStr)] string A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint c([In][MarshalAs(UnmanagedType.LPWStr)] string A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint d([In][MarshalAs(UnmanagedType.LPWStr)] string A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint c([MarshalAs(UnmanagedType.Interface)] out c A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint a([In][MarshalAs(UnmanagedType.Interface)] c A_0, uint A_1);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint e([In][MarshalAs(UnmanagedType.LPWStr)] string A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint d([MarshalAs(UnmanagedType.Error)] uint A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint a([In] ref Guid A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint a();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint b([MarshalAs(UnmanagedType.Interface)] IntPtr A_0);
	}

	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE")]
	internal interface c
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint a([In] IntPtr A_0, [In] ref Guid A_1, [In] ref Guid A_2, [MarshalAs(UnmanagedType.Interface)] out IntPtr A_3);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint a([MarshalAs(UnmanagedType.Interface)] out c A_0);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint a([In] uint A_0, out IntPtr A_1);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint a([In] uint A_0, out uint A_1);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint a([In][MarshalAs(UnmanagedType.Interface)] c A_0, [In] uint A_1, out int A_2);
	}

	public const uint a = 33554432u;

	public const uint b = 64u;

	public const uint c = 65536u;

	public const uint d = 256u;

	public const uint e = 32u;

	public const uint f = 0u;

	public const uint g = 2147844096u;

	[DllImport("shell32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int SHCreateItemFromParsingName([MarshalAs(UnmanagedType.LPWStr)] string A_0, IntPtr A_1, ref Guid A_2, [MarshalAs(UnmanagedType.Interface)] out c A_3);
}
