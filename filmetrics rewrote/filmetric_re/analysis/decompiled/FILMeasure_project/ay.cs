using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class ay
{
	private struct a
	{
		public int a;

		public int b;

		public int c;

		public int d;
	}

	[CompilerGenerated]
	private string m_a;

	[CompilerGenerated]
	private string b;

	[CompilerGenerated]
	private string c;

	[CompilerGenerated]
	private string d;

	[DllImport("user32.dll")]
	private static extern bool GetWindowRect(HandleRef A_0, ref a A_1);

	[SpecialName]
	[CompilerGenerated]
	public string e()
	{
		return this.m_a;
	}

	[SpecialName]
	[CompilerGenerated]
	public void e(string A_0)
	{
		this.m_a = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public string f()
	{
		return b;
	}

	[SpecialName]
	[CompilerGenerated]
	public void f(string A_0)
	{
		b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public string g()
	{
		return c;
	}

	[SpecialName]
	[CompilerGenerated]
	public void g(string A_0)
	{
		c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public string h()
	{
		return d;
	}

	[SpecialName]
	[CompilerGenerated]
	public void h(string A_0)
	{
		d = A_0;
	}

	public DialogResult g(IWin32Window A_0)
	{
		if (Environment.OSVersion.Version.Major >= 6)
		{
			return e(A_0);
		}
		return f(A_0);
	}

	private DialogResult f(IWin32Window A_0)
	{
		FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
		checked
		{
			try
			{
				FolderBrowserDialog folderBrowserDialog2 = folderBrowserDialog;
				if (g() != null)
				{
					folderBrowserDialog2.SelectedPath = g();
				}
				folderBrowserDialog2.Description = h();
				folderBrowserDialog2.ShowNewFolderButton = true;
				bool flag;
				a A_1 = default(a);
				Rectangle a_ = default(Rectangle);
				do
				{
					if (folderBrowserDialog2.ShowDialog(A_0) == DialogResult.Cancel)
					{
						return DialogResult.Cancel;
					}
					flag = Directory.Exists(folderBrowserDialog2.SelectedPath);
					if (!flag)
					{
						if (A_0 != null)
						{
							GetWindowRect(new HandleRef(this, A_0.Handle), ref A_1);
							a_.Location = new Point(A_1.a, A_1.b);
							a_.Width = A_1.c - A_1.a;
							a_.Height = A_1.d - A_1.b;
						}
						string a_2 = "Folder '" + folderBrowserDialog2.SelectedPath.Substring(Path.GetDirectoryName(folderBrowserDialog2.SelectedPath).Length + 1) + "' does not exist - Please choose again.";
						fe.b(null, a_2, i6.a(a_));
						folderBrowserDialog2.SelectedPath = Path.GetDirectoryName(folderBrowserDialog2.SelectedPath);
					}
				}
				while (!flag);
				f(Path.GetDirectoryName(folderBrowserDialog2.SelectedPath));
				return DialogResult.OK;
			}
			finally
			{
				folderBrowserDialog.Dispose();
			}
		}
	}

	private DialogResult e(IWin32Window A_0)
	{
		az.c A_1 = null;
		az.c A_2 = null;
		az.b b10 = (az.b)new az.a();
		b10.b(out uint A_3);
		A_3 |= 0x2010160;
		b10.c(A_3);
		if (g() != null)
		{
			Guid A_4 = new Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE");
			if (az.SHCreateItemFromParsingName(g(), IntPtr.Zero, ref A_4, out A_1) == 0)
			{
				b10.b(A_1);
			}
		}
		if (e() != null)
		{
			Guid A_4 = new Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE");
			if (az.SHCreateItemFromParsingName(e(), IntPtr.Zero, ref A_4, out A_1) == 0)
			{
				b10.a(A_1);
			}
		}
		b10.b(h());
		if ((long)b10.a(A_0.Handle) == 0L && (long)b10.c(out A_2) == 0L && (long)A_2.a(2147844096u, out IntPtr A_5) == 0L && A_5 != IntPtr.Zero)
		{
			try
			{
				f(Marshal.PtrToStringAuto(A_5));
				return DialogResult.OK;
			}
			finally
			{
				Marshal.FreeCoTaskMem(A_5);
			}
		}
		return DialogResult.Cancel;
	}
}
