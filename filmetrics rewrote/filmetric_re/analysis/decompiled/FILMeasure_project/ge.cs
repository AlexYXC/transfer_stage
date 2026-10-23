using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.FileIO;

internal class ge
{
	[CompilerGenerated]
	private FileSystemWatcher m_a;

	private bool m_b;

	private bool m_c;

	private string[] m_d;

	private string[] m_e;

	private string[] f;

	private string[] g;

	[SpecialName]
	[CompilerGenerated]
	private virtual FileSystemWatcher a()
	{
		return this.m_a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(FileSystemWatcher A_0)
	{
		this.m_a = A_0;
	}

	public ge()
	{
		this.m_b = true;
		this.m_c = true;
		if (!Directory.Exists(gd.i()))
		{
			Directory.CreateDirectory(gd.i());
		}
		if (!Directory.Exists(gf.b()))
		{
			Directory.CreateDirectory(gf.b());
		}
		a(new FileSystemWatcher(gd.i()));
		a().Filter = "*.*";
		a().NotifyFilter = NotifyFilters.FileName | NotifyFilters.Size | NotifyFilters.LastWrite | NotifyFilters.CreationTime;
		a().IncludeSubdirectories = false;
		a().EnableRaisingEvents = true;
		a().Changed += a;
		a().Created += a;
		a().Deleted += a;
		a().Renamed += a;
	}

	public string[] b()
	{
		if (this.m_b)
		{
			this.m_d = a(gd.ab);
		}
		return this.m_d;
	}

	public string[] c()
	{
		if (this.m_c)
		{
			this.m_e = a(gd.ac);
		}
		return this.m_e;
	}

	public string[] d()
	{
		if (this.m_c)
		{
			f = a(new string[1] { "*.fitls" });
		}
		return f;
	}

	public string[] e()
	{
		if (this.m_c)
		{
			g = a(new string[1] { "*.fitss" });
		}
		return g;
	}

	public string[] a(bool A_0, bool A_1)
	{
		if (A_0)
		{
			if (!A_1)
			{
				return e();
			}
			return c();
		}
		if (!A_1)
		{
			return d();
		}
		return b();
	}

	private string[] a(string[] A_0)
	{
		if (!Directory.Exists(gd.i()))
		{
			return new string[0];
		}
		string[] array = null;
		new Collection<string>();
		ReadOnlyCollection<string> files = global::c.e().FileSystem.GetFiles(gd.i(), Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, A_0);
		checked
		{
			if (array == null)
			{
				array = new string[files.Count - 1 + 1];
			}
			int num = files.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				array[num2] = Path.GetFileNameWithoutExtension(files[num2]);
			}
			Array.Sort(array);
			return array;
		}
	}

	private void a(object A_0, FileSystemEventArgs A_1)
	{
		this.m_b = true;
		this.m_c = true;
	}

	private void a(object A_0, RenamedEventArgs A_1)
	{
		this.m_b = true;
		this.m_c = true;
	}
}
