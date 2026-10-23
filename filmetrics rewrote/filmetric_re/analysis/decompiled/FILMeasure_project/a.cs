using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using Filmetrics.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class a : WindowsFormsApplicationBase
{
	private delegate void a(object A_0, NewInstanceEventArgs A_1);

	public struct b
	{
		public int a;

		public int b;

		public int c;

		public Point d;

		public Point e;

		public Rectangle f;
	}

	private static Mutex m_a;

	private static Thread m_b;

	[CompilerGenerated]
	private static a m_c;

	private const string d = "AbortDueToShutdown";

	private const string e = "13CB54B4-18DF-4B27-87CC-7D716B34D8C0";

	private bool f;

	private Mutex g;

	private bool h;

	private string i;

	private static bool m_j;

	private string m_k;

	private bool m_l;

	private bool m_m;

	private ew.a m_n;

	private static string m_o;

	private static string m_p;

	private static FormCollection m_q;

	private const int m_r = 0;

	private const int s = 1;

	private const int m_t = 1;

	private const int m_u = 2;

	private const int m_v = 3;

	private const int m_w = 3;

	private const int m_x = 4;

	private const int m_y = 5;

	private const int m_z = 6;

	private const int m_aa = 7;

	private const int m_ab = 8;

	private const int m_ac = 9;

	private const int m_ad = 10;

	private const int ae = 11;

	private const int af = 11;

	public const string ag = "FIL";

	[SpecialName]
	private bool ah;

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerHidden]
	[STAThread]
	internal static void c(string[] A_0)
	{
		Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
		global::c.d().Run(A_0);
	}

	[SpecialName]
	[CompilerGenerated]
	private static void j(a A_0)
	{
		a a10 = global::a.m_c;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Combine(a11, A_0);
			a10 = Interlocked.CompareExchange(ref global::a.m_c, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	private static void c(a A_0)
	{
		a a10 = global::a.m_c;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Remove(a11, A_0);
			a10 = Interlocked.CompareExchange(ref global::a.m_c, value, a11);
		}
		while ((object)a10 != a11);
	}

	[DllImport("user32.dll")]
	public static extern bool GetWindowPlacement(IntPtr A_0, ref b A_1);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool SetForegroundWindow(IntPtr A_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool ShowWindow(IntPtr A_0, int A_1);

	private void c(object A_0, StartupEventArgs A_1)
	{
		try
		{
			global::a.m_j = File.Exists(aa());
			if (global::a.m_j)
			{
				File.Delete(aa());
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
		global::a.m_o = base.Info.Title;
		global::a.m_p = base.Info.DirectoryPath;
		global::a.m_q = base.OpenForms;
		i7 obj = a2.a;
		int A_2 = 0;
		string A_3 = null;
		string[] A_4 = null;
		if (obj.c(null, null, i7.e.ab, ref A_2, ref A_3, ref A_4))
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CHS");
		}
		i7 obj2 = a2.a;
		A_2 = 0;
		A_3 = null;
		A_4 = null;
		if (obj2.c(null, null, i7.e.ac, ref A_2, ref A_3, ref A_4))
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja-JP");
		}
		i7 obj3 = a2.a;
		A_2 = 0;
		A_3 = null;
		A_4 = null;
		if (obj3.c(null, null, i7.e.ae, ref A_2, ref A_3, ref A_4))
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
		}
		i7 obj4 = a2.a;
		A_2 = 0;
		A_3 = null;
		A_4 = null;
		if (obj4.c(null, null, i7.e.ad, ref A_2, ref A_3, ref A_4))
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
		}
		i7 obj5 = a2.a;
		A_2 = 0;
		A_3 = null;
		A_4 = null;
		if (obj5.c(null, null, i7.e.af, ref A_2, ref A_3, ref A_4))
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
		}
		global::a.m_a = new Mutex(initiallyOwned: true, j(), out f);
		if (f && t())
		{
			ab();
			if (File.Exists(r()))
			{
				try
				{
					this.m_n = (ew.a)checked((byte)Conversions.ToInteger(File.ReadAllText(r())));
				}
				catch (Exception ex4)
				{
					ProjectData.SetProjectError(ex4);
					Exception ex5 = ex4;
					this.m_n = ew.a.a;
					ProjectData.ClearProjectError();
				}
				this.m_k = c(this.m_n);
				this.m_l = Operators.CompareString(ew.b(this.m_n), ew.b(ew.a.a), TextCompare: false) == 0;
				eq.a = new e2();
				eq.a.Show();
				this.m_m = true;
			}
			global::a.m_b = new Thread(c);
			global::a.m_b.Start();
			return;
		}
		checked
		{
			if (!f)
			{
				if (base.CommandLineArgs.Count > 0)
				{
					Exception ex6 = null;
					MemoryStream memoryStream = new MemoryStream();
					new BinaryFormatter().Serialize(memoryStream, new NewInstanceEventArgs(base.CommandLineArgs));
					bool flag;
					int num = default(int);
					do
					{
						try
						{
							jj.d obj6 = new jj.d(j());
							obj6.h();
							obj6.d(memoryStream.GetBuffer());
							obj6.j();
							_ = null;
							flag = false;
						}
						catch (Exception ex7)
						{
							ProjectData.SetProjectError(ex7);
							Exception ex8 = ex7;
							flag = true;
							ex6 = ex8;
							Thread.Sleep(1000);
							ProjectData.ClearProjectError();
						}
						num++;
					}
					while (flag && num < 2);
					memoryStream.Close();
					if (flag)
					{
						throw ex6;
					}
				}
				Process[] processesByName = Process.GetProcessesByName(global::c.d().Info.AssemblyName);
				Process[] processesByName2 = Process.GetProcessesByName(global::c.d().Info.AssemblyName + ".vshost");
				int num2 = 0;
				b A_5 = default(b);
				do
				{
					Process[] array = ((num2 != 0) ? processesByName2 : processesByName);
					A_2 = array.GetUpperBound(0);
					for (int num3 = 0; num3 <= A_2; num3++)
					{
						try
						{
							if (array[num3].MainWindowHandle != IntPtr.Zero)
							{
								SetForegroundWindow(array[num3].MainWindowHandle);
								GetWindowPlacement(array[num3].MainWindowHandle, ref A_5);
								if (A_5.c == 2)
								{
									ShowWindow(array[num3].MainWindowHandle, 9);
								}
								A_1.Cancel = true;
								return;
							}
						}
						catch (Exception ex9)
						{
							ProjectData.SetProjectError(ex9);
							Exception ex10 = ex9;
							Interaction.MsgBox("Error attempting to show previous instance. Error is " + ex10.ToString());
							ProjectData.ClearProjectError();
						}
					}
					num2++;
				}
				while (num2 <= 1);
			}
			else if (!h)
			{
				Interaction.MsgBox("Hardware access denied - Only one program may access measurement system hardware.");
			}
			A_1.Cancel = true;
		}
	}

	[SpecialName]
	public void j(bool A_0)
	{
		h = A_0;
	}

	[SpecialName]
	public bool t()
	{
		if (g == null)
		{
			g = new Mutex(initiallyOwned: true, "13CB54B4-18DF-4B27-87CC-7D716B34D8C0", out ah);
		}
		if (!ah)
		{
			u();
		}
		return ah;
	}

	public void u()
	{
		if (g != null)
		{
			g.Close();
			g = null;
		}
	}

	public static string c(ew.a A_0)
	{
		return A_0 switch
		{
			ew.a.c => "AHT", 
			ew.a.b => "Leybold", 
			_ => "FIL", 
		};
	}

	[SpecialName]
	private string r()
	{
		return i3.o() + "\\LastOEM.txt";
	}

	[SpecialName]
	public ew.a v()
	{
		return this.m_n;
	}

	public void j(ew.a A_0)
	{
		string path = r();
		int num = (int)A_0;
		File.WriteAllText(path, num.ToString());
	}

	[SpecialName]
	public string w()
	{
		return this.m_k;
	}

	[SpecialName]
	public bool x()
	{
		return this.m_m;
	}

	[SpecialName]
	public bool y()
	{
		return this.m_l;
	}

	[SpecialName]
	public string z()
	{
		return Path.Combine(i3.g(), global::c.d().Info.AssemblyName + "_AttachDebugger.txt");
	}

	[SpecialName]
	public string aa()
	{
		return Path.Combine(i3.g(), global::c.d().Info.AssemblyName + "_Restarting.txt");
	}

	[SpecialName]
	public static bool q()
	{
		return global::a.m_j;
	}

	[SpecialName]
	public static string p()
	{
		return global::a.m_p;
	}

	[SpecialName]
	public static string c(int A_0)
	{
		return global::e.a().GraphMeasYLabelPercent[A_0];
	}

	[SpecialName]
	public static void c(int A_0, string A_1)
	{
		global::e.a().GraphMeasYLabelPercent[A_0] = A_1;
	}

	[SpecialName]
	public static byte o()
	{
		return global::e.a().DisplaySignificantDigits;
	}

	[SpecialName]
	public static void c(byte A_0)
	{
		global::e.a().DisplaySignificantDigits = A_0;
	}

	[SpecialName]
	public static short n()
	{
		return global::e.a().ShowSpectrumCoordOption;
	}

	[SpecialName]
	public static void c(short A_0)
	{
		global::e.a().ShowSpectrumCoordOption = A_0;
	}

	[SpecialName]
	public static bool m()
	{
		return global::e.a().AlwayShowSpectrumCoordXYZ;
	}

	[SpecialName]
	public static void c(bool A_0)
	{
		global::e.a().AlwayShowSpectrumCoordXYZ = A_0;
	}

	[SpecialName]
	public static string l()
	{
		return global::e.a().SampleID;
	}

	[SpecialName]
	public static void c(string A_0)
	{
		global::e.a().SampleID = A_0;
	}

	[SpecialName]
	public static string k()
	{
		return global::a.m_o;
	}

	private void c(ConfigurationUserLevel A_0, ref bool A_1, bool A_2)
	{
		Configuration configuration = ConfigurationManager.OpenExeConfiguration(A_0);
		if (configuration == null || !configuration.HasFile || f1.fz.f())
		{
			return;
		}
		ConfigurationSectionGroup sectionGroup = configuration.GetSectionGroup("userSettings");
		if (sectionGroup == null)
		{
			return;
		}
		ClientSettingsSection clientSettingsSection = (ClientSettingsSection)sectionGroup.Sections["Filmetrics.My.MySettings"];
		if (clientSettingsSection != null)
		{
			SettingElement settingElement = clientSettingsSection.Settings.Get("ShareSettingsWithSelectedUsers");
			if (settingElement != null && Conversions.ToBoolean(settingElement.Value.ValueXml.FirstChild.Value))
			{
				A_1 = true;
				f1.fz.d(A_0, ref A_2);
				configuration = ConfigurationManager.OpenExeConfiguration(A_0);
			}
		}
	}

	public void ab()
	{
		try
		{
			f2 f10 = f1.fz;
			bool A_ = default(bool);
			if (f10.f())
			{
				f10.d(ConfigurationUserLevel.PerUserRoamingAndLocal, ref A_);
			}
			bool A_2 = default(bool);
			c(ConfigurationUserLevel.PerUserRoamingAndLocal, ref A_2, A_);
			gg.b(A_2, A_);
		}
		catch (ConfigurationException ex2)
		{
			ProjectData.SetProjectError(ex2);
			ConfigurationException ex3 = ex2;
			string filename = ex3.Filename;
			string fileName = Path.GetFileName(filename);
			int num = default(int);
			do
			{
				num = checked(num + 1);
				i = Path.Combine(Path.GetDirectoryName(filename), "Bad" + num + "." + fileName);
			}
			while (File.Exists(i));
			File.Move(filename, i);
			ProjectData.ClearProjectError();
		}
	}

	public void c(fz A_0)
	{
		if (!string.IsNullOrEmpty(i))
		{
			A_0.c(fz.b.a, "Settings file corrupted. File renamed as " + i);
		}
	}

	public void ac()
	{
		if (f && ad())
		{
			if (global::a.m_a != null)
			{
				global::a.m_a.Close();
				global::a.m_a = null;
			}
			u();
			if (global::a.m_b.IsAlive)
			{
				List<string> list = new List<string>();
				list.Add("AbortDueToShutdown");
				ReadOnlyCollection<string> a_ = new ReadOnlyCollection<string>(list);
				MemoryStream memoryStream = new MemoryStream();
				new BinaryFormatter().Serialize(memoryStream, new NewInstanceEventArgs(a_));
				jj.d obj = new jj.d(j());
				obj.h();
				obj.d(memoryStream.GetBuffer());
				obj.j();
				_ = null;
				memoryStream.Close();
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		ac();
	}

	private void c(object A_0, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs A_1)
	{
		A_1.ExitApplication = true;
		ac();
		Interaction.MsgBox("An error occurred! If this happens again, please contact customer service. Error: (" + A_1.Exception.ToString() + ")", MsgBoxStyle.Critical, base.Info.ProductName);
	}

	[SpecialName]
	public static string j()
	{
		return ((GuidAttribute)Assembly.GetEntryAssembly().GetCustomAttributes(typeof(GuidAttribute), inherit: false)[0]).Value;
	}

	private static void c()
	{
		try
		{
			jj.d d10 = new jj.d(j());
			d10.g();
			while (true)
			{
				d10.k();
				byte[] buffer = d10.m();
				d10.l();
				MemoryStream memoryStream = new MemoryStream(buffer);
				NewInstanceEventArgs e10 = (NewInstanceEventArgs)new BinaryFormatter().Deserialize(memoryStream);
				memoryStream.Close();
				if (Operators.CompareString(e10.CommandLineArgs[0], "AbortDueToShutdown", TextCompare: false) == 0)
				{
					break;
				}
				try
				{
					foreach (Form item in global::a.m_q)
					{
						if (item is gg)
						{
							((gg)item).b(e10.CommandLineArgs);
							break;
						}
					}
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex3 = ex2;
					string text = null;
					if (e10.CommandLineArgs.Count > 0)
					{
						text = e10.CommandLineArgs[0];
					}
					Interaction.MsgBox("An error occurred attempting to process " + text + " (and possibly other) command line arguments: (" + ex3.ToString() + ")", MsgBoxStyle.Critical);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception ex5 = ex4;
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	public bool ad()
	{
		return global::a.m_b.IsAlive;
	}

	[DebuggerStepThrough]
	public a()
		: base(AuthenticationMode.Windows)
	{
		base.Startup += c;
		base.Shutdown += c;
		base.UnhandledException += c;
		base.IsSingleInstance = false;
		base.EnableVisualStyles = true;
		base.SaveMySettingsOnExit = true;
		base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		base.MainForm = global::c.b().gm();
	}
}
