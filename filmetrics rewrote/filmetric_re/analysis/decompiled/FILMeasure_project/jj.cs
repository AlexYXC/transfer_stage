using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

internal class jj
{
	public struct a
	{
		public int a;

		public IntPtr b;

		public int c;

		public int d;

		public int e;
	}

	public enum b
	{
		a = 0,
		b = 1,
		c = 2,
		d = 3,
		e = 4,
		f = 12
	}

	public enum c
	{
		a = 0,
		b = 1,
		c = 2,
		d = 4,
		e = 8
	}

	internal class d
	{
		private class a
		{
			public struct a
			{
				public int a;

				public IntPtr b;

				public int c;
			}

			public struct b
			{
				public byte a;

				public byte b;

				public short c;

				public IntPtr d;

				public IntPtr e;

				public IntPtr f;

				public IntPtr g;
			}

			internal const int a = int.MinValue;

			internal const int b = 1;

			internal const int c = 2;

			internal const int d = int.MinValue;

			internal const int e = 1073741824;

			internal const int f = -1;

			internal const int g = 65535;

			internal const int h = 3;

			internal const int i = 3;

			internal const int j = 0;

			internal const int k = 0;

			internal const int l = 255;

			internal const int m = 0;

			public const int n = 1;

			public const int o = 20;

			public const int p = 0;

			public const int q = 64;

			public const int r = 64;

			[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
			internal static extern int CloseHandle(int A_0);

			[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
			internal static extern int ConnectNamedPipe(int A_0, int A_1);

			[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
			internal static extern int CreateFile(string A_0, int A_1, int A_2, int A_3, int A_4, int A_5, int A_6);

			[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
			internal static extern int CreateNamedPipe(string A_0, int A_1, int A_2, int A_3, int A_4, int A_5, int A_6, ref a A_7);

			[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
			internal static extern int CreateNamedPipe(string A_0, int A_1, int A_2, int A_3, int A_4, int A_5, int A_6, IntPtr A_7);

			[DllImport("advapi32.DLL", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
			public static extern int InitializeSecurityDescriptor(IntPtr A_0, int A_1);

			[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
			internal static extern int DisconnectNamedPipe(int A_0);

			[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
			internal static extern IntPtr GlobalAlloc(int A_0, int A_1);

			[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
			internal static extern int ReadFile(int A_0, ref byte A_1, int A_2, ref int A_3, int A_4);

			[DllImport("Advapi32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
			internal static extern int SetSecurityDescriptorDacl(IntPtr A_0, int A_1, int A_2, int A_3);

			[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
			internal static extern int WaitNamedPipe(string A_0, int A_1);

			[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
			internal static extern int WriteFile(int A_0, ref byte A_1, int A_2, ref int A_3, int A_4);
		}

		internal const int a = 16384;

		internal const int b = 16384;

		private string c;

		private int m_d;

		public d(string A_0)
		{
			this.m_d = -1;
			d(A_0);
		}

		[SpecialName]
		public string d()
		{
			return c;
		}

		[SpecialName]
		private void d(string A_0)
		{
			if (A_0.Length < 1 || A_0.Length >= 246)
			{
				throw new ArgumentException("Pipe name must be between 1 and 247 characters long.");
			}
			if (A_0.Contains("\\"))
			{
				throw new ArgumentException("Pipe name cannot contain backslash (\\).");
			}
			c = A_0;
		}

		[SpecialName]
		public string e()
		{
			return "\\\\.\\pipe\\" + d();
		}

		[SpecialName]
		public int f()
		{
			return this.m_d;
		}

		[SpecialName]
		private void d(int A_0)
		{
			this.m_d = A_0;
		}

		public void g()
		{
			IntPtr zero = IntPtr.Zero;
			d(jj.d.a.CreateNamedPipe(e(), -2147483645, 0, 255, 16384, 16384, 65535, zero));
			if (f() == -1)
			{
				throw new InvalidOperationException("CreateNamedPipeA returned invalid handle.");
			}
		}

		public void h()
		{
			d(jj.d.a.CreateFile(e(), -1073741824, 3, 0, 3, 0, 0));
			if (f() == -1)
			{
				throw new InvalidOperationException("CreateFile returned invalid handle. GetLastError returned " + Marshal.GetLastWin32Error());
			}
		}

		public bool i()
		{
			d(jj.d.a.CreateFile(e(), -1073741824, 3, 0, 3, 0, 0));
			bool num = f() != -1;
			if (num)
			{
				j();
			}
			return num;
		}

		public void j()
		{
			if (jj.d.a.CloseHandle(f()) == 0)
			{
				throw new InvalidOperationException("CloseHandle failed.");
			}
			d(-1);
		}

		public void k()
		{
			if (jj.d.a.ConnectNamedPipe(f(), 0) == 0)
			{
				throw new InvalidOperationException("ConnectNamedPipe failed.");
			}
		}

		public void l()
		{
			if (jj.d.a.DisconnectNamedPipe(f()) == 0)
			{
				throw new InvalidOperationException("DisconnectNamedPipe failed.");
			}
		}

		public byte[] m()
		{
			byte[] array = new byte[16384];
			int A_ = 0;
			if (jj.d.a.ReadFile(f(), ref array[0], array.Length, ref A_, 0) == 0)
			{
				throw new InvalidOperationException("ReadFile failed.");
			}
			if (A_ == 0)
			{
				return new byte[0];
			}
			byte[] array2 = new byte[checked(A_ - 1 + 1)];
			Array.Copy(array, array2, A_);
			return array2;
		}

		public void d(byte[] A_0)
		{
			if (A_0.Length > 0)
			{
				int a_ = f();
				ref byte a_2 = ref A_0[0];
				int a_3 = A_0.Length;
				int A_1 = 0;
				if (jj.d.a.WriteFile(a_, ref a_2, a_3, ref A_1, 0) == 0)
				{
					throw new InvalidOperationException("WriteFile failed.");
				}
			}
		}
	}

	internal class e
	{
		private enum a
		{
			a = 1,
			b,
			c
		}

		private enum b
		{
			a = 1,
			b,
			c,
			d,
			e,
			f,
			g,
			h,
			i,
			j,
			k,
			l,
			m,
			n,
			o,
			p,
			q,
			r,
			s,
			t,
			u,
			v,
			w,
			x,
			y,
			z,
			aa,
			ab,
			ac
		}

		private const uint m_a = 8u;

		private const int m_b = 4;

		[DllImport("kernel32.dll")]
		private static extern IntPtr GetCurrentProcess();

		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool OpenProcessToken(IntPtr A_0, uint A_1, ref IntPtr A_2);

		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool GetTokenInformation(IntPtr A_0, b A_1, IntPtr A_2, int A_3, ref uint A_4);

		public static bool c()
		{
			return global::c.c().IsInRole(BuiltInRole.Administrator);
		}

		public static bool b()
		{
			bool result;
			if (c())
			{
				result = true;
			}
			else if (Environment.OSVersion.Version.Major > 5)
			{
				try
				{
					IntPtr intPtr = Marshal.AllocHGlobal(4);
					IntPtr A_ = default(IntPtr);
					OpenProcessToken(GetCurrentProcess(), 8u, ref A_);
					uint A_2 = default(uint);
					GetTokenInformation(A_, jj.e.b.r, intPtr, 4, ref A_2);
					a a10 = (a)Marshal.ReadInt32(intPtr);
					Marshal.FreeHGlobal(intPtr);
					result = a10 == jj.e.a.c || a10 == jj.e.a.b;
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex3 = ex2;
					result = false;
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		public static bool a()
		{
			if (b())
			{
				return !c();
			}
			return false;
		}
	}

	private static Assembly m_a;

	private static object m_b;

	private static MethodInfo m_c;

	private static MethodInfo m_d;

	private const int m_e = 134217728;

	private const int f = 0;

	private const string g = "Software\\Classes\\";

	private const string h = "Software\\Adobe\\Acrobat Distiller\\PrinterJobControl";

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FlashWindowEx(ref a A_0);

	public static void a(IntPtr A_0, int A_1)
	{
		a A_2 = default(a);
		A_2.a = Marshal.SizeOf((object)A_2);
		A_2.b = A_0;
		A_2.c = A_1;
		A_2.e = 500;
		FlashWindowEx(ref A_2);
	}

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void SetProgressState(IntPtr A_0, c A_1);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void SetProgressValue(IntPtr A_0, ulong A_1, ulong A_2);

	public static void a(IntPtr A_0, c A_1, ulong A_2, ulong A_3)
	{
		Version version = Environment.OSVersion.Version;
		if (version.Major >= 6 && (version.Major != 6 || version.Minor >= 1))
		{
			version = null;
			if ((object)jj.m_a == null)
			{
				jj.m_a = Assembly.Load("Microsoft.WindowsAPICodePack.Shell, Version=1.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");
				Module module = jj.m_a.GetModule("Microsoft.WindowsAPICodePack.Shell.dll");
				Type type = module.GetType("Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState");
				Type type2 = module.GetType("Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager");
				jj.m_b = RuntimeHelpers.GetObjectValue(type2.GetMethod("get_Instance").Invoke(null, null));
				jj.m_c = type2.GetMethod("SetProgressState", new Type[2]
				{
					type,
					typeof(IntPtr)
				});
				jj.m_d = type2.GetMethod("SetProgressValue", new Type[3]
				{
					typeof(int),
					typeof(int),
					typeof(IntPtr)
				});
			}
			jj.m_c.Invoke(RuntimeHelpers.GetObjectValue(jj.m_b), new object[2] { A_1, A_0 });
			if (A_1 == jj.c.c)
			{
				jj.m_d.Invoke(RuntimeHelpers.GetObjectValue(jj.m_b), checked(new object[3]
				{
					(int)A_2,
					(int)A_3,
					A_0
				}));
			}
		}
	}

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void SHChangeNotify(int A_0, int A_1, IntPtr A_2, IntPtr A_3);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern UIntPtr GetProcAddress(IntPtr A_0, string A_1);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string A_0);

	[DllImport("Kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool IsWow64Process(SafeHandleZeroOrMinusOneIsInvalid A_0, ref bool A_1);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern SafeWaitHandle GetCurrentProcess();

	public static void b(string A_0)
	{
		string name = "LastPdfPortFolder - splwow64.exe";
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Adobe\\Acrobat Distiller\\PrinterJobControl", writable: true);
		registryKey.SetValue(name, A_0);
		registryKey.Close();
		_ = null;
	}

	public static void a(string A_0)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Adobe\\Acrobat Distiller\\PrinterJobControl", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue("C:\\Windows\\splwow64.exe", A_0);
			registryKey.Close();
			_ = null;
		}
	}

	public static void a(string A_0, string A_1, string A_2, string A_3)
	{
		RegistryKey currentUser = Registry.CurrentUser;
		currentUser.CreateSubKey("Software\\Classes\\" + A_2).SetValue(null, A_2);
		currentUser.CreateSubKey("Software\\Classes\\." + A_0).SetValue(null, A_2);
		currentUser.CreateSubKey("Software\\Classes\\" + A_2 + "\\shell\\open\\command").SetValue(null, "\"" + A_1 + "\" \"%1\"");
		currentUser.CreateSubKey("Software\\Classes\\" + A_2 + "\\DefaultIcon").SetValue(null, A_3);
		_ = null;
		SHChangeNotify(134217728, 0, IntPtr.Zero, IntPtr.Zero);
	}

	public static void b(string A_0, string A_1)
	{
		if (Operators.CompareString(A_0.Substring(0, 1), ".", TextCompare: false) == 0)
		{
			throw new ApplicationException("Invalid parameter");
		}
		try
		{
			Registry.CurrentUser.DeleteSubKeyTree("Software\\Classes\\" + A_1);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
		try
		{
			Registry.CurrentUser.DeleteSubKey("Software\\Classes\\." + A_0);
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception ex5 = ex4;
			ProjectData.ClearProjectError();
		}
		SHChangeNotify(134217728, 0, IntPtr.Zero, IntPtr.Zero);
	}

	public static bool a(string A_0, ref string A_1)
	{
		object objectValue;
		bool result;
		try
		{
			objectValue = RuntimeHelpers.GetObjectValue(Registry.ClassesRoot.OpenSubKey(A_0 + "\\shell\\open\\command").GetValue(null));
			_ = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			result = false;
			ProjectData.ClearProjectError();
			goto IL_007a;
		}
		if (!(objectValue is string))
		{
			result = false;
		}
		else
		{
			string text = (string)objectValue;
			if (!text.StartsWith("\""))
			{
				result = false;
			}
			else
			{
				A_1 = text.Substring(1);
				A_1 = A_1.Substring(0, A_1.IndexOf("\""));
				result = true;
			}
		}
		goto IL_007a;
		IL_007a:
		return result;
	}

	public static bool c()
	{
		if (b())
		{
			return true;
		}
		bool A_ = default(bool);
		return a("kernel32.dll", "IsWow64Process") && IsWow64Process(GetCurrentProcess(), ref A_) && A_;
	}

	public static bool b()
	{
		return IntPtr.Size == 8;
	}

	public static bool a()
	{
		return Environment.OSVersion.Version.Major < 6;
	}

	private static bool a(string A_0, string A_1)
	{
		IntPtr moduleHandle = GetModuleHandle(A_0);
		if (moduleHandle != IntPtr.Zero)
		{
			return GetProcAddress(moduleHandle, A_1) != UIntPtr.Zero;
		}
		return false;
	}
}
