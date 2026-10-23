using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Filmetrics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

[StandardModule]
internal sealed class j
{
	public delegate void a(string A_0, string A_1, string A_2, bool A_3);

	public delegate void b(l A_0);

	public delegate void c(d A_0);

	public class d
	{
		public string a;

		public bool b;
	}

	private static WebClient m_a;

	private static bu m_b;

	private static string m_c;

	private static bool m_d;

	private const string e = "http://files.filmetrics.com/FI_SW/SWUpdateV7B/";

	private static WebRequest f;

	public const string g = "\\InstallUpdate\\";

	private const string h = "\\InstallUpdate\\Unpacked\\";

	private const string i = "\\InstallUpdate\\TempUnpacked\\";

	private const string m_j = "DownloadedVersion.txt";

	private const string k = "PackedAutoUpdateFile.fibpf";

	private const string l = "NewVerInfo.txt";

	private const string m = "Unpacked";

	private const string n = "FILMeasure Installer.msi";

	private const string o = "SAFILMeasure Installer.msi";

	private const string p = "FILMapper Installer.msi";

	private const int q = 1;

	private const int r = 1;

	[CompilerGenerated]
	private static a s;

	[CompilerGenerated]
	private static b t;

	[CompilerGenerated]
	private static c u;

	public const string v = ".chm";

	static j()
	{
		global::j.m_a = new WebClient();
		global::j.m_b = new bu();
	}

	[SpecialName]
	[CompilerGenerated]
	public static void b(a A_0)
	{
		a a10 = s;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Combine(a11, A_0);
			a10 = Interlocked.CompareExchange(ref s, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public static void a(a A_0)
	{
		a a10 = s;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Remove(a11, A_0);
			a10 = Interlocked.CompareExchange(ref s, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public static void b(b A_0)
	{
		b b10 = t;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Combine(b11, A_0);
			b10 = Interlocked.CompareExchange(ref t, value, b11);
		}
		while ((object)b10 != b11);
	}

	[SpecialName]
	[CompilerGenerated]
	public static void a(b A_0)
	{
		b b10 = t;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Remove(b11, A_0);
			b10 = Interlocked.CompareExchange(ref t, value, b11);
		}
		while ((object)b10 != b11);
	}

	[SpecialName]
	[CompilerGenerated]
	public static void b(c A_0)
	{
		c c10 = u;
		c c11;
		do
		{
			c11 = c10;
			c value = (c)Delegate.Combine(c11, A_0);
			c10 = Interlocked.CompareExchange(ref u, value, c11);
		}
		while ((object)c10 != c11);
	}

	[SpecialName]
	[CompilerGenerated]
	public static void a(c A_0)
	{
		c c10 = u;
		c c11;
		do
		{
			c11 = c10;
			c value = (c)Delegate.Remove(c11, A_0);
			c10 = Interlocked.CompareExchange(ref u, value, c11);
		}
		while ((object)c10 != c11);
	}

	private static string b(AutoUpdateLicenseDetails.AutoUpdateLevel A_0)
	{
		string A_1 = "";
		string path = Application.StartupPath + "\\AUFilename.txt";
		if (File.Exists(path))
		{
			int A_2 = 0;
			i3.a(ref A_2, File.ReadAllText(path) + "\r\n", ref A_1);
		}
		else
		{
			A_1 = "Missing";
		}
		A_1 = A_1.Trim();
		return A_1 + "_" + AutoUpdateLicenseDetails.get_AutoUpdateLevelString(A_0);
	}

	private static string a(AutoUpdateLicenseDetails.AutoUpdateLevel A_0)
	{
		return b(A_0) + "_5abUChaF.txt";
	}

	private static void a(string A_0, string A_1, string A_2)
	{
		if (Operators.CompareString(global::e.a().AutoUpdateLastPromptVer, A_2, TextCompare: false) != 0 || DateTime.Now.Subtract(global::e.a().AutoUpdateLastReminderDateTime).TotalHours > global::e.a().AutoUpdateReminderPeriod)
		{
			DateTime t2 = global::e.a().AutoUpdateLastReminderDateTime;
			string left = global::e.a().AutoUpdateLastPromptVer;
			s?.Invoke(global::j.m_c, A_1, A_2, A_3: true);
			global::j.m_d = DateTime.Compare(t2, global::e.a().AutoUpdateLastReminderDateTime) != 0 || Operators.CompareString(left, global::e.a().AutoUpdateLastPromptVer, TextCompare: false) != 0;
		}
	}

	private static void a(string A_0, string A_1, bool A_2, ref bool A_3)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		string arguments = " /C copy \"" + A_0 + "\" \"" + A_1 + "\" /y";
		processStartInfo.CreateNoWindow = false;
		processStartInfo.FileName = "cmd.exe";
		if (A_2)
		{
			processStartInfo.Verb = "runas";
		}
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = arguments;
		try
		{
			Process process = Process.Start(processStartInfo);
			process.WaitForExit();
			A_3 = process.ExitCode == 0;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			A_3 = false;
			ProjectData.ClearProjectError();
		}
	}

	private static void a(string A_0, ref int A_1, ref string A_2, ref int A_3)
	{
		if (File.Exists(A_0))
		{
			if (!int.TryParse(File.ReadAllText(A_0, Encoding.UTF8), out A_1))
			{
				A_1 = 0;
			}
		}
		else
		{
			A_1 = 0;
		}
		A_2 = global::j.m_a.DownloadString("http://files.filmetrics.com/FI_SW/SWUpdateV7B/" + Path.GetFileName(A_0));
		A_3 = int.Parse(A_2);
	}

	private static void b(string A_0, ref List<m> A_1, ref List<m> A_2)
	{
		if (File.Exists(A_0))
		{
			A_1 = b(File.ReadAllText(A_0));
		}
		string a_ = global::j.m_a.DownloadString("http://files.filmetrics.com/FI_SW/SWUpdateV7B/" + Path.GetFileName(A_0));
		A_2 = b(a_);
	}

	private static void a(string A_0, ref List<m> A_1, ref List<m> A_2)
	{
		if (File.Exists(A_0))
		{
			A_1 = a(File.ReadAllText(A_0));
		}
		string a_ = global::j.m_a.DownloadString("http://files.filmetrics.com/FI_SW/SWUpdateV7B/" + Path.GetFileName(A_0));
		A_2 = a(a_);
	}

	private static List<n> a(List<m> A_0, List<m> A_1)
	{
		List<n> list = new List<n>();
		foreach (m item in A_0)
		{
			short a_ = a(item, A_1);
			list.Add(new n(item.a, item.b, a_));
		}
		return list;
	}

	private static short a(m A_0, List<m> A_1)
	{
		if (A_1 == null)
		{
			return 0;
		}
		checked
		{
			int num = A_1.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (Operators.CompareString(A_1[num2].a, A_0.a, TextCompare: false) == 0)
				{
					return A_1[num2].b;
				}
			}
			return 0;
		}
	}

	private static void b(string A_0, List<n> A_1)
	{
		short num = 1;
		StreamWriter streamWriter = new StreamWriter(File.Open(A_0, FileMode.Create));
		checked
		{
			try
			{
				streamWriter.WriteLine("Version, " + 1);
				streamWriter.WriteLine("Compatible Version, " + num);
				streamWriter.WriteLine("Help File Name, Current Version");
				int num2 = A_1.Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					streamWriter.WriteLine("\"" + A_1[num3].a + "\", " + A_1[num3].b);
				}
			}
			finally
			{
				streamWriter.Close();
			}
		}
	}

	private static void a(string A_0, List<n> A_1)
	{
		short num = 1;
		StreamWriter streamWriter = new StreamWriter(File.Open(A_0, FileMode.Create));
		checked
		{
			try
			{
				streamWriter.WriteLine("Version, " + 1);
				streamWriter.WriteLine("Compatible Version, " + num);
				streamWriter.WriteLine("Calibration File Name, Current Version");
				int num2 = A_1.Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					streamWriter.WriteLine("\"" + A_1[num3].a + "\", " + A_1[num3].b);
				}
			}
			finally
			{
				streamWriter.Close();
			}
		}
	}

	private static List<m> b(string A_0)
	{
		string A_1 = null;
		List<m> list = new List<m>();
		int A_2 = default(int);
		i3.a(ref A_2, A_0, ref A_1);
		i3.a(ref A_2, A_0, ref A_1);
		checked
		{
			_ = (short)Math.Round(Conversion.Val(A_1));
			i3.a(ref A_2, A_0, ref A_1);
			i3.a(ref A_2, A_0, ref A_1);
			short num = (short)Math.Round(Conversion.Val(A_1));
			if (num > 1)
			{
				throw new ApplicationException("Incompatible File Format in GetHelpVerInfoList(). Newer software version is required to read this file. FileVer=" + 1 + ", CompatVer=" + num);
			}
			i3.a(ref A_2, A_0, ref A_1);
			i3.a(ref A_2, A_0, ref A_1);
			while (A_2 < A_0.Length)
			{
				i3.a(ref A_2, A_0, ref A_1);
				string a_ = A_1;
				i3.a(ref A_2, A_0, ref A_1);
				short a_2 = (short)Math.Round(Conversion.Val(A_1));
				list.Add(new m(a_, a_2));
			}
			return list;
		}
	}

	private static List<m> a(string A_0)
	{
		string A_1 = null;
		List<m> list = new List<m>();
		int A_2 = default(int);
		i3.a(ref A_2, A_0, ref A_1);
		i3.a(ref A_2, A_0, ref A_1);
		checked
		{
			_ = (short)Math.Round(Conversion.Val(A_1));
			i3.a(ref A_2, A_0, ref A_1);
			i3.a(ref A_2, A_0, ref A_1);
			short num = (short)Math.Round(Conversion.Val(A_1));
			if (num > 1)
			{
				throw new ApplicationException("Incompatible File Format in GetWCalVerInfoList(). Newer software version is required to read this file. FileVer=" + 1 + ", CompatVer=" + num);
			}
			i3.a(ref A_2, A_0, ref A_1);
			i3.a(ref A_2, A_0, ref A_1);
			while (A_2 < A_0.Length)
			{
				i3.a(ref A_2, A_0, ref A_1);
				string a_ = A_1;
				i3.a(ref A_2, A_0, ref A_1);
				short a_2 = (short)Math.Round(Conversion.Val(A_1));
				list.Add(new m(a_, a_2));
			}
			return list;
		}
	}

	public static void a(object A_0)
	{
		string text = i3.o();
		fz fz2 = null;
		string text2 = text + "\\InstallUpdate\\";
		string text3 = text + "\\InstallUpdate\\Unpacked\\";
		string text4 = text + "\\InstallUpdate\\TempUnpacked\\";
		Version version = new Version("0.0.0.0");
		string text5 = "TempPackedAutoUpdateFile.fibpf";
		string empty = string.Empty;
		DateTime dateTime = DateTime.Now;
		l.a a_ = global::l.a.a;
		string a_2 = "";
		string text6 = "0.0.0.0";
		bool flag = false;
		bool a_3 = false;
		bool a_4 = false;
		checked
		{
			try
			{
				k obj = (k)A_0;
				AutoUpdateLicenseDetails.AutoUpdateLevel a_5 = obj.b;
				fz2 = obj.a;
				bool flag2 = obj.c;
				_ = null;
				string a_6 = b(a_5);
				t?.Invoke(new l("0.0.0.0", null, A_2: false, a_, DateTime.Now, a_6, a_3, a_4));
				if (!Directory.Exists(text2))
				{
					global::c.e().FileSystem.CreateDirectory(text2);
				}
				switch (Assembly.GetExecutingAssembly().GetName().Name)
				{
				case "FILMeasure":
				case "FILMeasure7":
					global::j.m_c = "FILMeasure Installer.msi";
					break;
				case "SAFILMeasure":
				case "SAFILMeasure7":
					global::j.m_c = "SAFILMeasure Installer.msi";
					break;
				case "FILMapper":
					global::j.m_c = "FILMapper Installer.msi";
					break;
				default:
					fz2.c(fz.b.b, "Invalid executable for autoupdating. Autoupdate disabled");
					t?.Invoke(null);
					return;
				}
				bool flag6 = default(bool);
				int A_2 = default(int);
				int A_3 = default(int);
				bool flag15 = default(bool);
				bool A_8 = default(bool);
				while (true)
				{
					Version version2 = ((!File.Exists(text2 + "DownloadedVersion.txt") || (!Directory.Exists(text2 + "Unpacked") && !File.Exists(text2 + "PackedAutoUpdateFile.fibpf"))) ? new Version("0.0.0.0") : new Version(File.ReadAllText(text2 + "DownloadedVersion.txt").Trim()));
					Version version3 = Assembly.GetExecutingAssembly().GetName().Version;
					bool flag3 = false;
					bool flag4;
					do
					{
						flag4 = false;
						if (Directory.Exists(text + "\\InstallUpdate\\Unpacked\\") && version2 > version3)
						{
							a(global::j.m_c, text3, version2.ToString());
							o o2 = new o(File.ReadAllText(text2 + "NewVerInfo.txt"));
							t?.Invoke(new l(o2.a, o2.c, A_2: true, a_, dateTime, a_6, a_3, a_4));
							o2 = null;
							flag4 = true;
							break;
						}
						if (!File.Exists(text2 + "PackedAutoUpdateFile.fibpf") || !(version2 > version3))
						{
							break;
						}
						if (Directory.Exists(text4))
						{
							global::c.e().FileSystem.DeleteDirectory(text4, DeleteDirectoryOption.DeleteAllContents);
						}
						a5.d(text2 + "PackedAutoUpdateFile.fibpf", text4);
						global::c.e().FileSystem.DeleteFile(text2 + "PackedAutoUpdateFile.fibpf");
						global::c.e().FileSystem.RenameDirectory(text4, "Unpacked");
						flag3 = true;
					}
					while (flag3);
					if (flag3)
					{
						string oSVersion = global::c.e().Info.OSVersion;
						if (int.Parse(oSVersion.Substring(0, oSVersion.IndexOf("."))) <= 5)
						{
							string destFileName = text2 + "Unpacked\\System Folder\\FIUsbInt.dll";
							string text7 = text2 + "Unpacked\\FIUsbIntXP\\FIUsbIntXP.dll";
							if (File.Exists(text7))
							{
								File.Copy(text7, destFileName, overwrite: true);
							}
						}
						oSVersion = null;
					}
					bool flag5 = DateTime.Compare(DateTime.Now, dateTime) >= 0;
					bool flag7;
					if (flag5)
					{
						dateTime = DateTime.Now.AddHours(0.5);
						try
						{
							a_ = global::l.a.b;
							flag6 = version > version3 && version > version2;
							t?.Invoke(new l(text6, a_2, flag4 && !flag6, a_, dateTime, a_6, a_3, a_4));
							string contents = global::j.m_a.DownloadString("http://files.filmetrics.com/FI_SW/SWUpdateV7B/" + a(a_5));
							File.WriteAllText(text2 + "NewVerInfo.txt", contents);
							flag7 = true;
							a_3 = false;
							a_ = global::l.a.d;
						}
						catch (Exception ex2)
						{
							ProjectData.SetProjectError(ex2);
							Exception a_7 = ex2;
							fz2.c(fz.b.a, "Exception caught in AutoUpdate.CheckAndAutoUpdate - Failed to download info file", a_7);
							flag7 = false;
							a_ = global::l.a.c;
							a_3 = true;
							t?.Invoke(new l(text6, a_2, flag4 && !flag6, a_, dateTime, a_6, a_3, a_4));
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						flag7 = false;
					}
					bool flag8;
					if (File.Exists(text2 + "NewVerInfo.txt"))
					{
						flag8 = true;
						o obj2 = new o(File.ReadAllText(text2 + "NewVerInfo.txt"));
						text6 = obj2.a;
						a_2 = obj2.c;
						version = new Version(text6);
						empty = obj2.b;
						flag6 = version > version3 && version > version2;
						t?.Invoke(new l(text6, a_2, flag4 && !flag6, a_, dateTime, a_6, a_3, a_4));
						_ = null;
					}
					else
					{
						flag6 = false;
						flag8 = false;
					}
					if (flag6 && flag7)
					{
						a_ = global::l.a.e;
						t?.Invoke(new l(version.ToString(), a_2, A_2: false, a_, dateTime, a_6, a_3, a_4));
						if (Directory.Exists(text3))
						{
							global::c.e().FileSystem.DeleteDirectory(text3, DeleteDirectoryOption.DeleteAllContents);
						}
						if (File.Exists(text2 + "PackedAutoUpdateFile.fibpf"))
						{
							global::c.e().FileSystem.DeleteFile(text2 + "PackedAutoUpdateFile.fibpf");
						}
						bool flag9;
						try
						{
							global::j.m_b.a("http://files.filmetrics.com/FI_SW/SWUpdateV7B/" + empty, text2 + text5, text6, fz2);
							flag9 = true;
							a_4 = false;
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception a_8 = ex3;
							fz2.c(fz.b.a, "Exception caught in AutoUpdate.CheckAndAutoUpdate - Failed to download packed file", a_8);
							flag9 = false;
							a_4 = true;
							a_ = global::l.a.f;
							ProjectData.ClearProjectError();
						}
						if (flag9)
						{
							int num = 0;
							bool flag10;
							do
							{
								flag10 = true;
								try
								{
									global::c.e().FileSystem.RenameFile(text2 + text5, "PackedAutoUpdateFile.fibpf");
								}
								catch (Exception ex4)
								{
									ProjectData.SetProjectError(ex4);
									Exception ex5 = ex4;
									flag10 = false;
									num++;
									fz2.c(fz.b.b, "Error encountered while trying to rename " + text5 + ". Error is: " + ex5.Message);
									Thread.Sleep(5000);
									ProjectData.ClearProjectError();
								}
							}
							while (!flag10 && num <= 10);
							if (!flag10)
							{
								break;
							}
							File.WriteAllText(text2 + "DownloadedVersion.txt", text6);
							flag = false;
						}
						else
						{
							flag = true;
							flag6 = false;
						}
					}
					else
					{
						flag = true;
					}
					if (flag5)
					{
						try
						{
							if (flag2)
							{
								if (!Directory.Exists(i3.i()))
								{
									Directory.CreateDirectory(i3.i());
								}
								string text8 = i3.i() + "\\MeasReport2_Ver.txt";
								string A_1 = null;
								a(text8, ref A_2, ref A_1, ref A_3);
								if (A_2 == 0 || A_3 > A_2)
								{
									global::j.m_b.a("http://files.filmetrics.com/FI_SW/SWUpdateV7B/MeasReport2_phus9uTR.xlt", i3.i() + "\\MeasReport2.xlt", A_1, fz2);
									File.WriteAllText(text8, A_1);
								}
								string text9 = i3.h();
								string text10 = text9 + "\\Temp";
								string a_9 = i3.i() + "\\FMeasHelpVer.txt";
								List<m> A_4 = null;
								List<m> A_5 = null;
								List<n> list = new List<n>();
								b(a_9, ref A_4, ref A_5);
								list = a(A_5, A_4);
								if (!Directory.Exists(text9))
								{
									global::c.e().FileSystem.CreateDirectory(text9);
								}
								if (!Directory.Exists(text10))
								{
									global::c.e().FileSystem.CreateDirectory(text10);
								}
								int num2 = list.Count - 1;
								for (int num3 = 0; num3 <= num2; num3++)
								{
									if (list[num3].c != list[num3].b)
									{
										try
										{
											global::j.m_b.a("http://files.filmetrics.com/FI_SW/SWUpdateV7B/Help/" + A_5[num3].a + ".chm", text10 + "\\" + list[num3].a + ".chm", list[num3].c.ToString(), fz2);
											list[num3].b = list[num3].c;
											b(a_9, list);
										}
										catch (Exception ex6)
										{
											ProjectData.SetProjectError(ex6);
											Exception a_10 = ex6;
											fz2.c(fz.b.a, "Exception caught in AutoUpdate.CheckAndAutoUpdate - Failed to download" + list[num3].a + ".chm", a_10);
											ProjectData.ClearProjectError();
										}
									}
									if (list[num3].c == list[num3].b && File.Exists(text10 + "\\" + list[num3].a + ".chm"))
									{
										try
										{
											global::c.e().FileSystem.CopyFile(text10 + "\\" + list[num3].a + ".chm", text9 + "\\" + list[num3].a + ".chm", overwrite: true);
											global::c.e().FileSystem.DeleteFile(text10 + "\\" + list[num3].a + ".chm");
										}
										catch (Exception ex7)
										{
											ProjectData.SetProjectError(ex7);
											Exception a_11 = ex7;
											fz2.c(fz.b.a, "Exception caught in AutoUpdate.CheckAndAutoUpdate - Failed to copy" + list[num3].a + ".chm", a_11);
											ProjectData.ClearProjectError();
										}
									}
								}
								if (flag2)
								{
									string text11 = ip.j.ah();
									string text12 = text11 + "\\Temp";
									string a_12 = i3.i() + "\\FIWCalVer5.txt";
									List<m> A_6 = null;
									List<m> A_7 = null;
									List<n> list2 = new List<n>();
									a(a_12, ref A_6, ref A_7);
									list2 = a(A_7, A_6);
									if (!Directory.Exists(text11))
									{
										global::c.e().FileSystem.CreateDirectory(text11);
									}
									if (!Directory.Exists(text12))
									{
										global::c.e().FileSystem.CreateDirectory(text12);
									}
									bool flag11 = false;
									bool flag12 = false;
									int num4 = list2.Count - 1;
									for (int num5 = 0; num5 <= num4; num5++)
									{
										if (list2[num5].c != list2[num5].b)
										{
											try
											{
												global::j.m_b.a("http://files.filmetrics.com/FI_SW/SWUpdateV7B/WCal/" + A_7[num5].a + ".txt", text12 + "\\" + list2[num5].a + ".txt", list2[num5].c.ToString(), fz2);
												global::j.m_b.a("http://files.filmetrics.com/FI_SW/SWUpdateV7B/WCal/" + A_7[num5].a + ".csv", text12 + "\\" + list2[num5].a + ".csv", list2[num5].c.ToString(), fz2);
												global::j.m_b.a("http://files.filmetrics.com/FI_SW/SWUpdateV7B/WCal/" + A_7[num5].a + "_KeyPeaksCheck.txt", text12 + "\\" + list2[num5].a + "_KeyPeaksCheck.txt", list2[num5].c.ToString(), fz2);
												list2[num5].b = list2[num5].c;
												flag11 = true;
											}
											catch (Exception ex8)
											{
												ProjectData.SetProjectError(ex8);
												Exception a_13 = ex8;
												fz2.c(fz.b.a, "Exception caught in AutoUpdate.CheckAndAutoUpdate - Failed to download" + list2[num5].a, a_13);
												flag12 = true;
												ProjectData.ClearProjectError();
											}
										}
										if (list2[num5].c == list2[num5].b && File.Exists(text12 + "\\" + list2[num5].a + ".txt") && File.Exists(text12 + "\\" + list2[num5].a + ".csv") && File.Exists(text12 + "\\" + list2[num5].a + "_KeyPeaksCheck.txt"))
										{
											try
											{
												global::c.e().FileSystem.CopyFile(text12 + "\\" + list2[num5].a + ".txt", text11 + "\\" + list2[num5].a + ".txt", overwrite: true);
												global::c.e().FileSystem.DeleteFile(text12 + "\\" + list2[num5].a + ".txt");
												global::c.e().FileSystem.CopyFile(text12 + "\\" + list2[num5].a + ".csv", text11 + "\\" + list2[num5].a + ".csv", overwrite: true);
												global::c.e().FileSystem.DeleteFile(text12 + "\\" + list2[num5].a + ".csv");
												global::c.e().FileSystem.CopyFile(text12 + "\\" + list2[num5].a + "_KeyPeaksCheck.txt", text11 + "\\" + list2[num5].a + "_KeyPeaksCheck.txt", overwrite: true);
												global::c.e().FileSystem.DeleteFile(text12 + "\\" + list2[num5].a + "_KeyPeaksCheck.txt");
											}
											catch (Exception ex9)
											{
												ProjectData.SetProjectError(ex9);
												Exception a_14 = ex9;
												fz2.c(fz.b.a, "Exception caught in AutoUpdate.CheckAndAutoUpdate - Failed to copy" + list2[num5].a, a_14);
												flag12 = true;
												ProjectData.ClearProjectError();
											}
										}
									}
									if (flag11 && !flag12)
									{
										a(a_12, list2);
									}
								}
								string text13 = i3.i() + "\\FMIntOnly_Ver.txt";
								string text14 = "\\FMIntOnly.dll";
								a(text13, ref A_2, ref A_1, ref A_3);
								if (A_2 == 0 || A_3 > A_2)
								{
									string text15 = i3.i() + text14;
									string empty2 = string.Empty;
									empty2 = ((!jj.c()) ? (Environment.GetFolderPath(Environment.SpecialFolder.System) + text14) : (Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.System)) + "\\SysWOW64" + text14));
									global::j.m_b.a("http://files.filmetrics.com/FI_SW/SWUpdateV7B/FMIntOnly_waTak4QA.dll", text15, A_1, fz2);
									bool flag13;
									if (File.Exists(empty2))
									{
										FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(text15);
										FileVersionInfo versionInfo2 = FileVersionInfo.GetVersionInfo(empty2);
										flag13 = versionInfo.FileMajorPart > versionInfo2.FileMajorPart || (versionInfo.FileMajorPart == versionInfo2.FileMajorPart && versionInfo.FileMinorPart > versionInfo2.FileMinorPart) || (versionInfo.FileMajorPart == versionInfo2.FileMajorPart && versionInfo.FileMinorPart == versionInfo2.FileMinorPart && versionInfo.FileBuildPart > versionInfo2.FileBuildPart) || (versionInfo.FileMajorPart == versionInfo2.FileMajorPart && versionInfo.FileMinorPart == versionInfo2.FileMinorPart && versionInfo.FileBuildPart == versionInfo2.FileBuildPart && versionInfo.FilePrivatePart > versionInfo2.FilePrivatePart);
									}
									else
									{
										flag13 = true;
									}
									if (flag13)
									{
										string oSVersion2 = global::c.e().Info.OSVersion;
										bool num6 = int.Parse(oSVersion2.Substring(0, oSVersion2.IndexOf("."))) > 5;
										oSVersion2 = null;
										bool flag14 = num6 || !jj.e.c();
										if (flag14)
										{
											d d10 = new d();
											d10.a = global::c.d().Info.Title + " is ready to install an updated version of FMIntOnly.dll.\r\nThe FMIntOnly dll allows Filmetrics Internal users to create encrypted material files.\r\n\r\nPlease answer Yes if a User Account Control dialog appears, requesting permission to allow the\r\n Windows Command Processor to make changes to your computer.\r\nIf your user account does not have Administrator priviledges you will be prompted to enter the \r\n username and password of an Administrator account.";
											u?.Invoke(d10);
											flag15 = d10.b;
										}
										if (!flag15)
										{
											a(text15, empty2, flag14, ref A_8);
										}
									}
									else
									{
										A_8 = true;
									}
									if (A_8)
									{
										File.WriteAllText(text13, A_1);
									}
									File.Delete(text15);
								}
							}
						}
						catch (Exception ex10)
						{
							ProjectData.SetProjectError(ex10);
							Exception a_15 = ex10;
							fz2.c(fz.b.a, "Exception caught in AutoUpdate.CheckAndAutoUpdate - Failed to download Filmetrics Internal files", a_15);
							a_ = global::l.a.g;
							t?.Invoke(new l(text6, a_2, flag4 && !flag6, a_, dateTime, a_6, a_3, a_4));
							ProjectData.ClearProjectError();
						}
					}
					if (flag)
					{
						a_ = global::l.a.i;
						if (flag8)
						{
							t?.Invoke(new l(text6, a_2, flag4 && !flag6, a_, dateTime, a_6, a_3, a_4));
						}
						else
						{
							t?.Invoke(new l("0.0.0.0", "", A_2: false, a_, dateTime, a_6, a_3, a_4));
						}
						double num7 = global::e.a().AutoUpdateReminderPeriod;
						double num8 = 1.0 / 12.0;
						if (num7 <= num8)
						{
							global::e.a().AutoUpdateReminderPeriod = num8;
						}
						DateTime t2 = global::e.a().AutoUpdateLastReminderDateTime.AddHours(num7);
						double num9 = ((DateTime.Compare(t2, dateTime) <= 0 && flag4) ? t2.Subtract(DateTime.Now).TotalHours : dateTime.Subtract(DateTime.Now).TotalHours);
						if (num9 < 0.0002777777777777778)
						{
							num9 = 0.0002777777777777778;
						}
						if (global::j.m_d && num9 > 0.0002777777777777778)
						{
							num9 = 0.0002777777777777778;
						}
						else if (num9 > 1.0 / 12.0)
						{
							num9 = 1.0 / 12.0;
						}
						int num10 = (int)Math.Round(num9 * 3600.0 * 1000.0);
						if (num10 > 0)
						{
							Thread.Sleep(num10);
						}
					}
				}
				throw new ApplicationException("Max number of attempts to rename download file exceeded.");
			}
			catch (Exception ex11)
			{
				ProjectData.SetProjectError(ex11);
				Exception a_16 = ex11;
				fz2.c(fz.b.b, "AutoUpdate Error", a_16);
				t?.Invoke(null);
				ProjectData.ClearProjectError();
			}
			finally
			{
				global::j.m_a.Dispose();
			}
		}
	}

	public static void a()
	{
		s?.Invoke(global::j.m_c, i3.o() + "\\InstallUpdate\\Unpacked\\", null, A_3: false);
	}
}
