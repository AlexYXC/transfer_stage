using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Filmetrics.FIMatFileDBService;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

internal class gr : q
{
	public class a
	{
		public string a;

		public string b;

		public bool c;

		public bool d;

		public a(string A_0, string A_1, bool A_2)
		{
			a = A_0;
			b = A_1;
			d = A_2;
		}
	}

	private class b
	{
		public string a;

		public string b;

		public bool c;

		public d d;

		public List<string> e;

		public List<string> f;

		public b()
		{
			e = new List<string>();
			f = new List<string>();
		}
	}

	public class c : IComparable
	{
		public string a;

		public Collection<string> b;

		private const string m_c = "_";

		private const string m_d = "0.00_TE";

		public static void c(string A_0, ref string A_1, ref string A_2)
		{
			checked
			{
				if (A_0.EndsWith("##"))
				{
					int num = A_0.IndexOf("##");
					if (num != A_0.Length - 2)
					{
						_ = num - 1;
						_ = num + 2;
						A_1 = A_0.Substring(0, num);
						A_2 = A_0.Substring(num + 2, A_0.Length - num - 4);
					}
					else
					{
						A_1 = A_0;
						A_2 = "0.00_TE";
					}
				}
				else
				{
					A_1 = A_0;
					A_2 = "0.00_TE";
				}
			}
		}

		public static string c(string A_0, string A_1)
		{
			if (Operators.CompareString(A_1, "0.00_TE", TextCompare: false) == 0)
			{
				return A_0;
			}
			return A_0 + "##" + A_1 + "##";
		}

		public void d(string A_0, string A_1)
		{
			if (a == null)
			{
				a = A_0;
				b = new Collection<string>();
				b.Add(A_1);
			}
			else if (Operators.CompareString(A_0, a, TextCompare: false) == 0)
			{
				b.Add(A_1);
			}
		}

		public static string c(float A_0, bool A_1, bool A_2)
		{
			if (jf.e(A_0, 0.0))
			{
				return "0.00_TE";
			}
			string text = b3.a(A_0, "0.00", CultureInfo.InvariantCulture);
			if (A_1)
			{
				if (A_2)
				{
					return text + "_TM";
				}
				return text + "_TE";
			}
			return text + "_Mixed";
		}

		public bool c(string A_0, bool A_1, bool A_2)
		{
			bool flag = b.IndexOf("0.00_TE") >= 0;
			bool flag2 = b.IndexOf(A_0) >= 0;
			if (A_1)
			{
				return flag;
			}
			if (A_2)
			{
				return flag2;
			}
			return flag && flag2;
		}

		public void c(string A_0)
		{
			string A_1 = null;
			string A_2 = null;
			c(A_0, ref A_1, ref A_2);
			if (Operators.CompareString(a, A_1, TextCompare: false) != 0)
			{
				return;
			}
			int num = b.IndexOf(A_2);
			if (num >= 0)
			{
				b.RemoveAt(num);
				if (b.Count < 1)
				{
					b = null;
					a = null;
				}
			}
		}

		public int c(object A_0)
		{
			if (!(A_0 is c))
			{
				throw new Exception();
			}
			c c10 = (c)A_0;
			if (a == null)
			{
				if (c10.a == null)
				{
					return 0;
				}
				return 1;
			}
			if (c10.a == null)
			{
				return -1;
			}
			return string.Compare(a, c10.a);
		}

		int IComparable.CompareTo(object A_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in c
			return this.c(A_0);
		}
	}

	public enum d
	{
		a = 1,
		b,
		c,
		d,
		e,
		f,
		g,
		h
	}

	public enum e
	{
		a,
		b,
		c,
		d,
		e
	}

	public enum f
	{
		a,
		b,
		c
	}

	private const short gt = 32;

	private const int gu = 27;

	private const int g3 = 864;

	private const string g4 = "\\Material";

	private const int g5 = 5;

	private const int g6 = 10;

	private Collection<string> g7;

	private bool g8;

	private c[] g9;

	private short ha;

	private c[] hb;

	private short hc;

	private string[] hd;

	private string[] he;

	private string[] hf;

	private string[] hg;

	private string[] hh;

	private Collection<a> hi;

	private Collection<a> hj;

	private DateTime hk;

	private DateTime hl;

	private bool hm;

	[CompilerGenerated]
	private FileSystemWatcher hn;

	private int ho;

	private bool hp;

	public const string hq = "##";

	public const string hr = "_";

	public const string hs = "_TM##";

	public const string ht = "_TE##";

	public const string hu = "_MIXED##";

	public const string hv = "Metal";

	public const string hw = "Semiconductor";

	public const string hx = "Dielectric";

	public const string hy = "Photoresist";

	public const string hz = "Other";

	[SpecialName]
	[CompilerGenerated]
	private virtual FileSystemWatcher sj()
	{
		return hn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void m2(FileSystemWatcher A_0)
	{
		FileSystemEventHandler value = m2;
		FileSystemEventHandler value2 = m2;
		FileSystemEventHandler value3 = m2;
		RenamedEventHandler value4 = m2;
		FileSystemWatcher fileSystemWatcher = hn;
		if (fileSystemWatcher != null)
		{
			fileSystemWatcher.Changed -= value;
			fileSystemWatcher.Created -= value2;
			fileSystemWatcher.Deleted -= value3;
			fileSystemWatcher.Renamed -= value4;
		}
		hn = A_0;
		fileSystemWatcher = hn;
		if (fileSystemWatcher != null)
		{
			fileSystemWatcher.Changed += value;
			fileSystemWatcher.Created += value2;
			fileSystemWatcher.Deleted += value3;
			fileSystemWatcher.Renamed += value4;
		}
	}

	private string m2(d A_0)
	{
		return A_0 switch
		{
			d.a => "Metal", 
			d.b => "Semiconductor", 
			d.c => "Dielectric", 
			d.f => "Photoresist", 
			_ => "Other", 
		};
	}

	public gr(fz A_0, bool A_1, bool A_2, hd A_3, ref string A_4)
		: base(ref A_0)
	{
		g7 = new Collection<string>();
		g7 = jb.k();
		g8 = A_1;
		string path = jb.d() + "\\";
		if (!Directory.Exists(path))
		{
			Directory.CreateDirectory(jb.d() + "\\");
		}
		if (Directory.Exists(path))
		{
			m2(new FileSystemWatcher(path));
			sj().Filter = "*.*";
			sj().NotifyFilter = NotifyFilters.FileName | NotifyFilters.Size | NotifyFilters.LastWrite | NotifyFilters.CreationTime;
			sj().IncludeSubdirectories = true;
			sj().EnableRaisingEvents = true;
		}
		p9(A_2, A_3, ref A_4);
	}

	[SpecialName]
	public bool sm()
	{
		if (DateTime.Compare(hk, hl) <= 0)
		{
			return !hm;
		}
		return true;
	}

	[SpecialName]
	public Collection<a> sn()
	{
		return hi;
	}

	[SpecialName]
	public Collection<a> so()
	{
		return hj;
	}

	[SpecialName]
	public int st()
	{
		return ho;
	}

	[SpecialName]
	public void m2(int A_0)
	{
		ho = A_0;
	}

	private e p9(bool A_0, hd A_1, ref string A_2)
	{
		qh();
		p9();
		m2(A_0, A_1, ref A_2);
		e result = default(e);
		return result;
	}

	private void qh()
	{
		m2(ref ha, new string[3] { "*.rrr", "*.fmrrr", "*.fitdr" }, ".rrr", ref g9);
	}

	private void p9()
	{
		m2(ref hc, new string[2] { "*.ttt", "*.fmttt" }, ".ttt", ref hb);
	}

	private int m2(string A_0, List<c> A_1)
	{
		checked
		{
			int num = A_1.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (Operators.CompareString(A_1[num2].a, A_0, TextCompare: false) == 0)
				{
					return num2;
				}
			}
			return -1;
		}
	}

	private void m2(ref short A_0, string[] A_1, string A_2, ref c[] A_3)
	{
		string text = "";
		List<c> list = new List<c>();
		checked
		{
			foreach (string item in g7)
			{
				Collection<string> collection = new Collection<string>();
				Collection<string> collection2 = new Collection<string>();
				ReadOnlyCollection<string> files = global::c.e().FileSystem.GetFiles(item, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, A_1);
				bool[] array = new bool[files.Count - 1 + 1];
				int num = files.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					string fileName = Path.GetFileName(files[num2]);
					if (Operators.CompareString(fileName, string.Empty, TextCompare: false) != 0)
					{
						Path.GetExtension(fileName);
						string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
						if (ex.h(fileNameWithoutExtension))
						{
							int num3 = num2 + 1;
							int num4 = files.Count - 1;
							for (int num5 = num3; num5 <= num4; num5++)
							{
								string fileName2 = Path.GetFileName(files[num5]);
								if (Operators.CompareString(fileName2, string.Empty, TextCompare: false) == 0 || array[num5])
								{
									continue;
								}
								text = Path.GetFileNameWithoutExtension(fileName2);
								if (string.Compare(fileNameWithoutExtension, text, ignoreCase: true) == 0)
								{
									if (ex.f(fileName) > ex.f(fileName2))
									{
										File.Delete(item + "\\" + fileName2);
										array[num5] = true;
									}
									else
									{
										File.Delete(item + "\\" + fileName);
										array[num2] = true;
									}
								}
							}
						}
						else
						{
							array[num2] = true;
						}
					}
					else
					{
						array[num2] = true;
					}
				}
				int num6 = files.Count - 1;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					if (!array[num7])
					{
						collection.Add(Path.GetFileNameWithoutExtension(files[num7]));
						collection2.Add(Path.GetExtension(files[num7]));
					}
				}
				int num8 = collection.Count - 1;
				for (int num9 = 0; num9 <= num8; num9++)
				{
					bool flag = false;
					text = collection[num9];
					int num10 = list.Count - 1;
					for (int num11 = 0; num11 <= num10; num11++)
					{
						foreach (string item2 in list[num11].b)
						{
							if (string.Compare(c.c(list[num11].a, item2), text, ignoreCase: true) == 0)
							{
								flag = true;
								break;
							}
						}
						if (flag)
						{
							break;
						}
					}
					if (flag)
					{
						global::c.e().FileSystem.DeleteFile(item + "\\" + text + collection2[num9]);
						continue;
					}
					string A_4 = null;
					string A_5 = null;
					c.c(text, ref A_4, ref A_5);
					int num12 = m2(A_4, list);
					if (num12 >= 0)
					{
						list[num12].d(A_4, A_5);
						continue;
					}
					list.Add(new c());
					list[list.Count - 1].d(A_4, A_5);
				}
			}
			A_3 = list.ToArray();
			A_0 = (short)list.Count;
			Array.Sort(A_3);
		}
	}

	private List<b> m2()
	{
		Collection<string> collection = new Collection<string>();
		string path = "";
		Collection<eb.c> A_ = null;
		bool flag = jb.i();
		string[] array = new string[14]
		{
			"acrylic2", "carbon_am", "dlc", "dlcarbon", "hc standard2", "polycarb", "polyolef", "polystyr", "si_am", "si_poly",
			"si_poly_brugg", "thermaloxide", "tin-palik", "zns_cub"
		};
		List<b> list = new List<b>();
		LicenseLevel A_4 = default(LicenseLevel);
		if (flag)
		{
			DateTime A_2 = DateTime.MinValue;
			DateTime A_3 = DateTime.MinValue;
			d9.a(eb.b.a, ref A_2, ref A_3, ref A_4, ref A_);
			if (!g8)
			{
				A_4 = LicenseLevel.ShippingReadOnly;
			}
		}
		checked
		{
			eb.a a10 = default(eb.a);
			bool flag5 = default(bool);
			foreach (string item in g7)
			{
				bool flag2 = Operators.CompareString(item, jb.h(), TextCompare: false) == 0;
				Collection<string> collection2 = new Collection<string>();
				ReadOnlyCollection<string> files = global::c.e().FileSystem.GetFiles(item, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, jb.c(eb.b.a));
				foreach (string item2 in files)
				{
					if (Operators.CompareString(Path.GetFileName(item2), "", TextCompare: false) == 0)
					{
						continue;
					}
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(item2);
					int num = collection.Count - 1;
					bool flag3 = true;
					int num2 = num;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						Collection<string> collection3 = collection;
						if (string.Compare(Path.GetFileNameWithoutExtension(collection3[num3]), fileNameWithoutExtension, ignoreCase: true) == 0)
						{
							flag3 = false;
							int num4 = jb.c(collection3[num3]);
							int num5 = jb.c(item2);
							if ((num5 == num4 || (!jb.n(item2) && !jb.n(collection3[num3]) && (!jb.j(item2) || !jb.j(collection3[num3])) && (!jb.k(item2) || !jb.k(collection3[num3])))) && (num5 != num4 || !jb.n(item2)))
							{
								break;
							}
							string text;
							if (num5 < num4 || num5 == num4)
							{
								text = item2;
								_ = item + "\\" + collection3[num3];
							}
							else
							{
								text = item + "\\" + collection3[num3];
							}
							try
							{
								if (File.Exists(text))
								{
									FileInfo fileInfo = global::c.e().FileSystem.GetFileInfo(text);
									if ((fileInfo.Attributes & FileAttributes.ReadOnly) != 0)
									{
										File.SetAttributes(text, fileInfo.Attributes & ~FileAttributes.ReadOnly);
									}
									fileInfo = null;
									File.Delete(text);
								}
								if (jb.n(text))
								{
									break;
								}
								text = ((!jb.j(text)) ? Path.ChangeExtension(text, jb.i(text)) : Path.ChangeExtension(text, jb.g(text)));
								if (File.Exists(text))
								{
									FileInfo fileInfo2 = global::c.e().FileSystem.GetFileInfo(text);
									if ((fileInfo2.Attributes & FileAttributes.ReadOnly) != 0)
									{
										File.SetAttributes(text, fileInfo2.Attributes & ~FileAttributes.ReadOnly);
									}
									fileInfo2 = null;
									File.Delete(text);
								}
							}
							catch (Exception ex2)
							{
								ProjectData.SetProjectError(ex2);
								Exception a_ = ex2;
								ab8().c(fz.b.b, "Error attempting to delete " + text, a_);
								ProjectData.ClearProjectError();
							}
							break;
						}
						collection3 = null;
					}
					string fileName = Path.GetFileName(item2);
					if (flag3 && (!flag2 || !Path.GetFileNameWithoutExtension(fileName.Substring(0)).ToLower().EndsWith("#Public#".ToLower())))
					{
						collection2.Add(item2);
					}
					fileName = null;
				}
				foreach (string item3 in collection2)
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(item3);
					bool flag3 = true;
					foreach (string item4 in collection)
					{
						path = item4;
						if (string.Compare(fileNameWithoutExtension, Path.GetFileNameWithoutExtension(path), ignoreCase: true) == 0)
						{
							flag3 = false;
							break;
						}
					}
					if (flag3 && flag2)
					{
						bool flag4 = false;
						foreach (eb.c item5 in A_)
						{
							if (string.Compare(item5.a, Path.GetFileNameWithoutExtension(item3), ignoreCase: true) == 0)
							{
								a10 = item5.c;
								flag4 = true;
								break;
							}
						}
						flag5 = flag4 && (a10 == eb.a.f || A_4 >= LicenseLevel.ReadOnly);
					}
					if (flag3 && (!flag2 || flag5))
					{
						bool flag6;
						if (flag && !flag2)
						{
							flag6 = true;
							string[] array2 = array;
							foreach (string strB in array2)
							{
								int num7 = string.Compare(fileNameWithoutExtension, strB, ignoreCase: true);
								if (num7 == 0)
								{
									flag6 = false;
									break;
								}
								if (num7 < 0)
								{
									break;
								}
							}
						}
						else
						{
							flag6 = true;
						}
						if (flag6)
						{
							collection.Add(item3);
						}
					}
					else if (!flag2 && Operators.CompareString(Path.GetDirectoryName(path), Path.GetDirectoryName(item3), TextCompare: false) != 0)
					{
						jb.a(item3, eb.b.a);
					}
				}
			}
			hl = DateTime.Now;
			hm = true;
			foreach (string item6 in collection)
			{
				b b10 = new b();
				b b11 = b10;
				if ((jb.n(item6) || jb.j(item6)) && m2(item6, ref b11.d, ref b11.e, ref b11.f) == e.a)
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(item6);
					if (b11.d != d.c || string.Compare(fileNameWithoutExtension, "Insulator", StringComparison.InvariantCultureIgnoreCase) != 0)
					{
						b11.b = item6;
						b11.a = fileNameWithoutExtension;
						b11.c = item6.StartsWith(jb.h());
						list.Add(b10);
					}
				}
				b11 = null;
			}
			return list;
		}
	}

	private void m2(bool A_0, hd A_1, ref string A_2)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		List<string> list3 = new List<string>();
		List<string> list4 = new List<string>();
		List<string> list5 = new List<string>();
		Collection<string> a_ = new Collection<string>();
		List<b> list6 = m2();
		checked
		{
			if (A_0)
			{
				for (int num = list6.Count - 1; num >= 0; num += -1)
				{
					b b10 = list6[num];
					if (Operators.CompareString(b10.a, "Air", TextCompare: false) == 0)
					{
						list6.RemoveAt(num);
						string text = "Material File Error: Found a material file named " + b10.a + " but this is a reserved name that can not be used as a material file name. ";
						try
						{
							string text2 = jd.a();
							jb.a(b10.b, eb.b.a, text2);
							text = text + "Material file '" + Path.GetFileName(b10.b) + "' has been moved to '" + text2 + "'.";
						}
						catch (Exception ex2)
						{
							ProjectData.SetProjectError(ex2);
							Exception ex3 = ex2;
							text = text + "Failed to delete material file. Error=" + ex3.ToString();
							ProjectData.ClearProjectError();
						}
						if (!string.IsNullOrEmpty(A_2))
						{
							A_2 += "\r\n";
						}
						A_2 += text;
					}
					if (!b10.c)
					{
						continue;
					}
					foreach (string item2 in b10.e)
					{
						foreach (b item3 in list6)
						{
							if (!item3.c && string.Compare(item2, item3.a, ignoreCase: true) == 0)
							{
								list6.RemoveAt(num);
								string text = "Local Material Folder Error: Duplicate material file synonym declaration. OMDB Material file '" + b10.a + "' claims to be synonymous with '" + item2 + "'. However, there is also a local material file named '" + item3.a + "'. ";
								try
								{
									string text3 = jd.a();
									jb.a(item3.b, eb.b.a, text3);
									text = text + "Local material file '" + Path.GetFileName(item3.b) + "' has been moved to '" + text3 + "'.";
								}
								catch (Exception ex4)
								{
									ProjectData.SetProjectError(ex4);
									Exception ex5 = ex4;
									text = text + "Failed to delete local material file. Error=" + ex5.ToString();
									ProjectData.ClearProjectError();
								}
								if (!string.IsNullOrEmpty(A_2))
								{
									A_2 += "\r\n";
								}
								A_2 += text;
								break;
							}
						}
					}
				}
			}
			hi = new Collection<a>();
			hj = new Collection<a>();
			hi.Add(new a("Air", "Air", A_2: false));
			foreach (b item4 in list6)
			{
				string text4 = item4.b;
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text4);
				string item = jb.a(fileNameWithoutExtension, text4);
				if (jb.aa(fileNameWithoutExtension))
				{
					continue;
				}
				switch (item4.d)
				{
				case d.a:
					list3.Add(item);
					break;
				case d.b:
					list2.Add(item);
					break;
				case d.c:
					list.Add(item);
					break;
				case d.f:
					list4.Add(item);
					break;
				default:
					list5.Add(item);
					break;
				}
				bool a_2 = jb.m(text4);
				m2(hi, fileNameWithoutExtension, fileNameWithoutExtension, a_2, A_0, A_1, ref A_2, a_);
				m2(hj, fileNameWithoutExtension, m2(item4.d), a_2, A_0, A_1, ref A_2, a_);
				foreach (string item5 in item4.e)
				{
					m2(hi, fileNameWithoutExtension, item5, a_2, A_0, A_1, ref A_2, a_);
				}
				foreach (string item6 in item4.f)
				{
					m2(hj, fileNameWithoutExtension, item6, a_2, A_0, A_1, ref A_2, a_);
				}
			}
			list3.Sort();
			hd = list3.ToArray();
			list2.Sort();
			he = list2.ToArray();
			list.Sort();
			hf = list.ToArray();
			list4.Sort();
			hg = list4.ToArray();
			list5.Sort();
			hh = list5.ToArray();
		}
	}

	private void m2(Collection<a> A_0, hd A_1, string A_2, string A_3, string A_4, ref string A_5, Collection<string> A_6)
	{
		double[] A_7 = null;
		double[] A_8 = null;
		double[] A_9 = null;
		short[] A_10 = null;
		double[] A_11 = null;
		string A_12 = null;
		string A_13 = null;
		string A_14 = null;
		jb.d[] A_15 = null;
		string[] A_16 = null;
		eo eo2 = new eo();
		eo2.at(eo.at());
		string A_17 = null;
		bool A_18 = false;
		bool A_19 = false;
		bool A_20 = false;
		string A_21 = null;
		jc A_22 = null;
		int A_23 = default(int);
		short A_24 = default(short);
		short A_25 = default(short);
		int A_26 = default(int);
		int A_27 = default(int);
		bool A_29 = default(bool);
		int A_28 = default(int);
		jb.a(A_3, A_1: false, ref A_7, ref A_8, ref A_9, A_5: true, A_6: true, ref A_23, A_1, ref A_24, ref A_25, ref A_26, ref A_10, ref A_11, eo2, ref A_17, ref A_18, ref A_19, ref A_20, ref A_12, ref A_13, ref A_27, ref A_14, ref A_28, ref A_15, ref A_16, ref A_29, ref A_21, ref A_22, null);
		List<jb.d> list = new List<jb.d>();
		List<string> list2 = new List<string>();
		checked
		{
			int num = A_15.Length - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (A_15[num2] != jb.d.a || Operators.CompareString(A_16[num2], A_2, TextCompare: false) != 0)
				{
					list.Add(A_15[num2]);
					list2.Add(A_16[num2]);
				}
			}
			A_16 = list2.ToArray();
			A_15 = list.ToArray();
			A_28 = list2.Count;
			string text = jb.s(A_3);
			A_5 = "Local Material Folder Error: Duplicate material file synonym declaration. Local Material file '" + A_3 + "' claims to be synonymous with '" + A_2 + "'.";
			if (string.IsNullOrEmpty(A_4))
			{
				A_5 = A_5 + " However, there is also a material file named '" + A_2 + "'. ";
			}
			else
			{
				A_5 = A_5 + " However, the file '" + Path.GetFileName(A_4) + "' also claims to be synonymous with '" + A_2 + "'. ";
			}
			string text2 = jd.a();
			bool flag = default(bool);
			try
			{
				if (!A_6.Contains(text))
				{
					jb.a(text, eb.b.a, text2);
					A_6.Add(text);
					flag = true;
				}
				Path.GetExtension(text);
				jb.a(text, A_7, A_8, A_9, (short)A_23, A_24, A_25, (short)A_26, A_11, A_10, A_12, A_13, A_28, A_15, A_16, !A_29);
				A_5 = A_5 + "Synonym '" + A_2 + "' has been deleted from '" + A_3 + "' and the file has been rewritten.";
				if (flag)
				{
					A_5 = A_5 + "The original file has been moved to '" + text2 + "\\'.";
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				A_5 = A_5 + "Failed attempting to modify '" + A_3 + "'.";
				if (flag)
				{
					A_5 = A_5 + " The file has been moved to '" + text2 + "\\'.";
				}
				ProjectData.ClearProjectError();
			}
			_ = null;
		}
	}

	private void m2(Collection<a> A_0, string A_1, string A_2, bool A_3, bool A_4, hd A_5, ref string A_6, Collection<string> A_7)
	{
		bool flag = A_0 == hi;
		bool ignoreCase = !flag;
		Collection<a> collection = A_0;
		checked
		{
			int num = default(int);
			if (collection.Count == 0 || string.Compare(collection[collection.Count - 1].b, A_2, ignoreCase) < 0)
			{
				num = collection.Count;
				collection.Add(new a(A_1, A_2, A_3));
			}
			else if (string.Compare(collection[0].b, A_2, ignoreCase) > 0)
			{
				collection.Insert(0, new a(A_1, A_2, A_3));
				num = 0;
			}
			else if (!flag && collection.Count == 1)
			{
				collection.Add(new a(A_1, A_2, A_3));
			}
			else
			{
				int index = 0;
				bool flag2 = default(bool);
				if (flag)
				{
					flag2 = string.Compare(collection[0].b, A_2, ignoreCase) == 0;
					if (!flag2)
					{
						flag2 = string.Compare(collection[collection.Count - 1].b, A_2, ignoreCase) == 0;
						index = collection.Count - 1;
					}
				}
				int num2 = default(int);
				if (!flag || !flag2)
				{
					num2 = 1;
					int num3 = collection.Count - 1;
					while ((!flag || !flag2) && num3 - num2 > 0)
					{
						int num4;
						int num5;
						unchecked
						{
							num4 = checked(num2 + num3) / 2;
							num5 = string.Compare(collection[num4].b, A_2, ignoreCase);
						}
						if (num5 == 0)
						{
							if (flag)
							{
								flag2 = true;
								index = num4;
							}
							else
							{
								num3 = num4;
								num2 = num4;
							}
						}
						else if (num5 > 0)
						{
							num3 = num4;
						}
						else
						{
							num2 = num4 + 1;
						}
					}
				}
				string A_8 = null;
				if (flag && flag2)
				{
					string text = collection[index].a;
					bool flag3 = jb.s(text).StartsWith(jb.h());
					bool flag4 = jb.s(A_1).StartsWith(jb.h());
					bool flag5 = string.Compare(text, A_2, ignoreCase) == 0;
					bool flag6 = string.Compare(A_1, A_2, ignoreCase) == 0;
					if (flag5 || flag6)
					{
						string text2;
						if (flag6)
						{
							text2 = text;
							collection[index].a = A_1;
						}
						else
						{
							text2 = A_1;
						}
						if (A_4)
						{
							bool flag7 = default(bool);
							bool flag8 = default(bool);
							if (flag3 && flag4)
							{
								A_8 = "OMDB Error: Duplicate material file synonym declaration. OMDB Material file '" + text2 + "' claims to be synonymous with '" + A_2 + "'. However, there is also an OMDB material file named '" + A_2 + "'. Synonym declaration in '" + text2 + "' for '" + A_2 + "' will be ignored.";
							}
							else if ((flag3 && flag6) || (flag4 && flag5))
							{
								A_8 = "Software Error: Duplicate material file synonym declaration - unable to delete local mat file. OMDB Material file '" + text2 + "' claims to be synonymous with '" + A_2 + "'. However, there is also a local material file named '" + A_2 + "'. Synonym declaration in '" + text2 + "' for '" + A_2 + "' will be ignored.";
							}
							else if (flag5)
							{
								flag7 = true;
							}
							else
							{
								flag8 = true;
							}
							if (flag8 || flag7)
							{
								m2(A_0, A_5, A_2, text2, null, ref A_8, A_7);
							}
						}
						else
						{
							A_8 = "Duplicate material file synonym declaration. Material file '" + text2 + "' claims to be synonymous with '" + A_2 + "'. However, there is also a material file named '" + A_2 + "'. Synonym declaration in '" + text2 + "' for '" + A_2 + "' will be ignored.";
						}
					}
					else
					{
						string text3 = text;
						string text4 = null;
						string text5 = null;
						DateTime lastWriteTimeUtc = File.GetLastWriteTimeUtc(jb.s(text3));
						DateTime lastWriteTimeUtc2 = File.GetLastWriteTimeUtc(jb.s(A_1));
						if ((flag3 && !flag4) || (DateTime.Compare(lastWriteTimeUtc, lastWriteTimeUtc2) < 0 && (flag3 || !flag4)))
						{
							text4 = A_1;
							text5 = text3;
						}
						else
						{
							text4 = text3;
							text5 = A_1;
							if (!A_4 || (flag3 && flag4) || !flag3)
							{
								collection[index].a = A_1;
							}
						}
						if (A_4)
						{
							if (flag3 && flag4)
							{
								A_8 = "OMDB Error: Duplicate material file synonym declaration. OMDB Material file '" + text3 + "' and OMDB material file '" + A_1 + "' both claim to be synonymous with '" + A_2 + "'. Synonym declaration in '" + text4 + "' for '" + A_2 + "' will be ignored.";
							}
							else
							{
								m2(A_0, A_5, A_2, text4, text5, ref A_8, A_7);
							}
						}
						else
						{
							A_8 = "Duplicate material file synonym declaration. Material file '" + text3 + "' and material file '" + A_1 + "' both claim to be synonymous with '" + A_2 + "'. Synonym declaration in '" + text4 + "' for '" + A_2 + "' will be ignored.";
						}
					}
					ab8().c(fz.b.a, A_8);
					if (!string.IsNullOrEmpty(A_8))
					{
						if (!string.IsNullOrEmpty(A_6))
						{
							A_6 += "\r\n";
						}
						A_6 += A_8;
					}
				}
				else
				{
					num = num2;
					collection.Insert(num2, new a(A_1, A_2, A_3));
				}
			}
			if (flag)
			{
				if (collection.Count > 1 && num > 0 && string.Compare(A_2, collection[num - 1].b, ignoreCase: true) == 0)
				{
					collection[num - 1].c = true;
					collection[num].c = true;
				}
				else if (collection.Count > num + 1 && string.Compare(A_2, collection[num + 1].b, ignoreCase: true) == 0)
				{
					collection[num].c = true;
					collection[num + 1].c = true;
				}
			}
			collection = null;
		}
	}

	public void m2(ref string[] A_0, ref short A_1, ref string[] A_2, ref short A_3, ref string[] A_4, ref short A_5, ref string[] A_6, ref short A_7, ref string[] A_8, ref short A_9)
	{
		if (sm())
		{
			string A_10 = null;
			p9(A_0: false, null, ref A_10);
		}
		checked
		{
			A_0 = new string[hd.Length - 1 + 1];
			A_2 = new string[he.Length - 1 + 1];
			A_4 = new string[hf.Length - 1 + 1];
			A_6 = new string[hg.Length - 1 + 1];
			A_8 = new string[hh.Length - 1 + 1];
			Array.Copy(hd, A_0, hd.Length);
			Array.Copy(he, A_2, he.Length);
			Array.Copy(hf, A_4, hf.Length);
			Array.Copy(hg, A_6, hg.Length);
			Array.Copy(hh, A_8, hh.Length);
			A_1 = (short)hd.Length;
			A_3 = (short)he.Length;
			A_5 = (short)hf.Length;
			A_7 = (short)hg.Length;
			A_9 = (short)hh.Length;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public static e m2(string A_0, ref d A_1, ref List<string> A_2, ref List<string> A_3)
	{
		e result = e.a;
		try
		{
			A_2 = new List<string>();
			A_3 = new List<string>();
			if (Operators.CompareString(Path.GetExtension(A_0), ".fmnnn", TextCompare: false) == 0)
			{
				BinaryReader binaryReader = new BinaryReader(File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read));
				int num = binaryReader.ReadInt32();
				binaryReader.ReadInt32();
				A_1 = (d)binaryReader.ReadInt32();
				binaryReader.Close();
			}
			else if (A_0.ToLower().EndsWith(".fibnk"))
			{
				jb.d[] A_4 = null;
				string[] A_5 = null;
				short A_6 = 0;
				int A_7 = 0;
				double[] A_8 = null;
				short[] A_9 = null;
				short A_10 = 0;
				short A_11 = 0;
				double[] A_12 = null;
				double[] A_13 = null;
				double[] A_14 = null;
				string A_15 = null;
				string A_16 = null;
				int A_17 = 0;
				string A_18 = null;
				short A_19 = default(short);
				int A_20 = default(int);
				if (jb.a(A_0, A_1: false, ref A_19, ref A_6, ref A_7, ref A_8, ref A_9, ref A_10, ref A_11, ref A_12, ref A_13, ref A_14, ref A_15, ref A_16, ref A_17, ref A_18, ref A_20, ref A_4, ref A_5) != jb.a.a)
				{
					return e.d;
				}
				checked
				{
					A_17 = A_20 - 1;
					for (int num2 = 0; num2 <= A_17; num2++)
					{
						if (A_4[num2] == jb.d.a)
						{
							A_2.Add(A_5[num2]);
						}
						else if (A_4[num2] == jb.d.b)
						{
							A_3.Add(A_5[num2]);
						}
					}
				}
				A_1 = (d)A_19;
			}
			else if (A_0.ToLower().EndsWith(".fitnk"))
			{
				A_1 = (d)jb.r(A_0);
			}
			else if (A_0.ToLower().EndsWith(".fibnx"))
			{
				jb.d[] A_21 = null;
				string[] A_22 = null;
				jc A_23 = null;
				string A_18 = null;
				string A_16 = null;
				int A_7 = 0;
				string A_15 = null;
				short A_24 = default(short);
				int A_25 = default(int);
				jb.a(A_0, A_1: false, ref A_23, ref A_24, ref A_18, ref A_16, ref A_7, ref A_15, ref A_25, ref A_21, ref A_22);
				checked
				{
					A_7 = A_25 - 1;
					for (int num3 = 0; num3 <= A_7; num3++)
					{
						if (A_21[num3] == jb.d.a)
						{
							A_2.Add(A_22[num3]);
						}
						else if (A_21[num3] == jb.d.b)
						{
							A_3.Add(A_22[num3]);
						}
					}
				}
				A_1 = (d)A_24;
			}
			else if (A_0.ToLower().EndsWith(".fitnx"))
			{
				StreamReader streamReader = null;
				short A_27 = default(short);
				try
				{
					streamReader = new StreamReader(File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read), Encoding.UTF8);
					StreamReader a_ = streamReader;
					int A_26 = 0;
					jb.a(a_, ref A_26, ref A_27);
				}
				finally
				{
					streamReader.Close();
				}
				A_1 = (d)A_27;
			}
			else
			{
				string Value = "";
				int num4 = Microsoft.VisualBasic.FileSystem.FreeFile();
				try
				{
					Microsoft.VisualBasic.FileSystem.FileOpen(num4, A_0, OpenMode.Input);
					Microsoft.VisualBasic.FileSystem.Input(num4, ref Value);
					int num = default(int);
					Microsoft.VisualBasic.FileSystem.Input(num4, ref num);
					Microsoft.VisualBasic.FileSystem.Input(num4, ref Value);
					int Value2 = default(int);
					Microsoft.VisualBasic.FileSystem.Input(num4, ref Value2);
					A_1 = (d)Value2;
				}
				finally
				{
					Microsoft.VisualBasic.FileSystem.FileClose(num4);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			result = e.d;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void m2(Collection<string> A_0, f A_1, bool A_2, ref ContextMenuStrip A_3)
	{
		if (A_2)
		{
			m2(ref A_3);
		}
		m2(ref A_0, A_1);
		checked
		{
			int num = A_0.Count - 1;
			int num3 = default(int);
			for (int num2 = 0; num2 <= num; num2++)
			{
				string text = A_0[num2].ToString();
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
				if (float.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out var result))
				{
					toolStripMenuItem.Text = result.ToString();
				}
				else
				{
					toolStripMenuItem.Text = text;
				}
				A_3.Items.Insert(num2, toolStripMenuItem);
				num3++;
				if (num3 == 5)
				{
					break;
				}
			}
			if (num3 > 0)
			{
				ToolStripSeparator value = new ToolStripSeparator();
				A_3.Items.Insert(num3, value);
				value = new ToolStripSeparator();
				A_3.Items.Insert(A_3.Items.Count, value);
				ToolStripButton toolStripButton = new ToolStripButton();
				string A_4 = "ClearMRLddd";
				toolStripButton.Text = global::hu.a(ref A_4);
				A_3.Items.Insert(A_3.Items.Count, toolStripButton);
			}
			ho = num3;
		}
	}

	private Collection<string> m2(Collection<string> A_0, Collection<string> A_1, bool A_2)
	{
		Collection<string> collection = new Collection<string>();
		checked
		{
			int num = A_0.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (!A_1.Contains(A_0[num2]))
				{
					if (!A_2)
					{
						continue;
					}
					string text = A_0[num2];
					double result = 0.0;
					if (!double.TryParse(text, out result))
					{
						continue;
					}
				}
				collection.Add(A_0[num2]);
			}
			return collection;
		}
	}

	public void m2(ref Collection<string> A_0, ref Collection<string> A_1, ref ContextMenuStrip A_2, bool A_3, bool A_4, float A_5, bool A_6, bool A_7, EventHandler A_8)
	{
		A_1 = null;
		if (sm())
		{
			string A_9 = null;
			p9(A_0: false, null, ref A_9);
		}
		m2(g9, ha, ref A_2, ref A_1, A_3, A_4, A_5, A_6, A_7, A_8);
		A_0 = m2(A_0, A_1, A_2: true);
		m2(A_0, f.b, A_2: false, ref A_2);
	}

	public void m2(Collection<string> A_0, ref Collection<string> A_1, ref ContextMenuStrip A_2, bool A_3, bool A_4, float A_5, bool A_6, bool A_7, EventHandler A_8)
	{
		A_1 = null;
		if (sm())
		{
			string A_9 = null;
			p9(A_0: false, null, ref A_9);
		}
		m2(hb, hc, ref A_2, ref A_1, A_3, A_4, A_5, A_6, A_7, A_8);
		m2(A_0, f.c, A_2: false, ref A_2);
	}

	private void m2(c[] A_0, short A_1, ref ContextMenuStrip A_2, ref Collection<string> A_3, bool A_4, bool A_5, float A_6, bool A_7, bool A_8, EventHandler A_9)
	{
		short num = 0;
		A_3 = new Collection<string>();
		string a_ = ((!A_4) ? c.c(A_6, A_7, A_8) : c.c(0f, A_1: false, A_2: false));
		checked
		{
			int num2 = A_1 - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (A_0[num3].c(a_, A_4, A_5))
				{
					num = (short)unchecked(num + 1);
				}
			}
			string A_10;
			if (num > 27)
			{
				short num4 = 0;
				short num5 = 0;
				short num6 = 0;
				while ((short)unchecked(num6 + num5) < num)
				{
					if (A_0[num6].c(a_, A_4, A_5))
					{
						ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem("New", null, A_9);
						string text = Strings.UCase(Strings.Left(A_0[num5].a, 1));
						while ((num6 < 27) & ((short)unchecked(num6 + num5) < num))
						{
							toolStripMenuItem.DropDownItems.Add(A_0[(short)unchecked(num5 + num6)].a, null, A_9);
							A_3.Add(A_0[(short)unchecked(num5 + num6)].a);
							num6 = (short)unchecked(num6 + 1);
						}
						string text2 = Strings.UCase(Strings.Left(A_0[(short)unchecked(num5 + num6) - 1].a, 1));
						toolStripMenuItem.Text = text + " - " + text2;
						A_2.Items.Add(toolStripMenuItem);
						if ((num6 == 27) & (num4 < 32))
						{
							num5 += 27;
							num6 = 0;
							num4 = (short)unchecked(num4 + 1);
						}
						if ((num6 == 27) & (num4 == 32))
						{
							fz obj = ab8();
							A_10 = "FilmstackTooManyRefNNNFiles";
							obj.c(fz.b.a, global::hu.a(ref A_10));
							num6 = num;
						}
					}
				}
			}
			else
			{
				short num7 = (short)unchecked(A_1 - 1);
				for (short num6 = 0; num6 <= num7; num6 = (short)unchecked(num6 + 1))
				{
					if (A_0[num6].c(a_, A_4, A_5))
					{
						A_2.Items.Add(A_0[num6].a);
						A_3.Add(A_0[num6].a);
					}
				}
			}
			ToolStripSeparator value = new ToolStripSeparator();
			A_2.Items.Insert(0, value);
			ToolStripButton toolStripButton = new ToolStripButton();
			A_10 = "EnterConstant";
			toolStripButton.Text = global::hu.a(ref A_10);
			A_2.Items.Insert(0, toolStripButton);
		}
	}

	public void m2(ref ContextMenuStrip A_0)
	{
		checked
		{
			if (ho > 0)
			{
				int num = ho;
				for (int num2 = 0; num2 <= num; num2++)
				{
					A_0.Items.RemoveAt(0);
				}
				A_0.Items.RemoveAt(A_0.Items.Count - 1);
				A_0.Items.RemoveAt(A_0.Items.Count - 1);
			}
		}
	}

	public void m2(ref Collection<string> A_0, string A_1, f A_2, bool A_3 = false)
	{
		bool flag = false;
		if (string.IsNullOrEmpty(A_1) || (gd.l(A_1) && !gd.i(A_1.Substring("Stack: ".Length), A_3)))
		{
			return;
		}
		checked
		{
			int num = A_0.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (Operators.CompareString(A_0[num2], A_1, TextCompare: false) == 0)
				{
					A_0.RemoveAt(num2);
					flag = true;
					break;
				}
			}
			if (!flag && A_0.Count >= 10)
			{
				A_0.RemoveAt(A_0.Count - 1);
			}
			m2(ref A_0, A_2);
			A_0.Insert(0, A_1);
		}
	}

	public void m2(ref Collection<string> A_0, f A_1)
	{
		int num = -1;
		string[] array = null;
		string[] array2 = new string[4] { ".fibls", ".fibss", ".fitls", ".fitss" };
		checked
		{
			if (A_1 == f.a)
			{
				num = 5;
				array = new string[num + 1];
				array[0] = ".fibnk";
				array[1] = ".fitnk";
				array[2] = ".fmnnn";
				array[3] = ".nnn";
				array[4] = ".fibnx";
				array[5] = ".fitnx";
			}
			else
			{
				if (A_1 == f.b)
				{
					num = 2;
					array = new string[num + 1];
					array[0] = ".fmrrr";
					array[1] = ".rrr";
					array[2] = ".fitdr";
				}
				if (A_1 == f.c)
				{
					num = 1;
					array = (string[])Utils.CopyArray(array, new string[num + 1]);
					array[0] = ".fmttt";
					array[1] = ".ttt";
				}
			}
			if (num < 0)
			{
				throw new ArgumentOutOfRangeException("Invalid MostRecentFileType");
			}
			Collection<string> collection = jb.k();
			int num2 = 0;
			bool flag3 = default(bool);
			while (num2 < A_0.Count)
			{
				string text = A_0[num2];
				bool flag = gd.l(text);
				if (A_1 == f.a)
				{
					string left = Strings.LCase(text);
					string A_2 = "Air";
					if (Operators.CompareString(left, Strings.LCase(global::hu.a(ref A_2)), TextCompare: false) == 0 || Operators.CompareString(Strings.Left(text, 11), "Generic, n=", TextCompare: false) == 0)
					{
						goto IL_015b;
					}
				}
				if (Operators.CompareString(text, "<Graded Interface>", TextCompare: false) == 0 || Operators.CompareString(text, "<Roughness>", TextCompare: false) == 0 || flag)
				{
					goto IL_015b;
				}
				bool flag2;
				if (A_1 == f.b || A_1 == f.c)
				{
					string text2 = text;
					double result = 0.0;
					if (double.TryParse(text2, out result))
					{
						flag2 = false;
						goto IL_0255;
					}
				}
				text = jb.x(text);
				foreach (string item in collection)
				{
					string text3 = item + "\\" + text;
					flag3 = false;
					int num3 = num;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						if (File.Exists(text3 + array[num4]))
						{
							flag3 = true;
							break;
						}
					}
					if (flag3)
					{
						break;
					}
				}
				flag2 = !flag3;
				goto IL_0255;
				IL_0255:
				if (flag2)
				{
					A_0.RemoveAt(num2);
				}
				else
				{
					num2++;
				}
				continue;
				IL_015b:
				if (flag)
				{
					string text4 = text.Substring("Stack: ".Length);
					int num5 = array2.Length - 1;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						flag3 = false;
						if (File.Exists(gd.i() + text4 + array2[num6]))
						{
							flag3 = true;
							break;
						}
					}
					flag2 = !flag3;
				}
				else
				{
					flag2 = false;
				}
				goto IL_0255;
			}
		}
	}

	public void m2(ref Collection<string> A_0, f A_1, ref string A_2)
	{
		string text = "";
		StreamReader streamReader = null;
		string text2 = "";
		try
		{
			A_0 = new Collection<string>();
			text2 = i3.i() + A_2;
			if (File.Exists(text2))
			{
				streamReader = new StreamReader(File.Open(text2, FileMode.Open, FileAccess.Read, FileShare.Read));
				int num = Conversions.ToInteger(streamReader.ReadLine());
				for (int num2 = 1; num2 <= num; num2 = checked(num2 + 1))
				{
					text = streamReader.ReadLine();
					A_0.Add(text);
				}
				m2(ref A_0, A_1);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (streamReader != null)
			{
				streamReader.Close();
				string text3 = Path.ChangeExtension(text2, ".bad");
				if (File.Exists(text3))
				{
					File.Delete(text3);
				}
				global::c.e().FileSystem.RenameFile(text2, Path.GetFileName(text3));
				throw new av("Most Recent Materials File " + text2 + "is Corrupted. File has been renamed as " + text3);
			}
			throw ex3;
		}
		finally
		{
			streamReader?.Close();
		}
	}

	public void m2(ref Collection<string> A_0, ref string A_1)
	{
		StreamWriter streamWriter = null;
		string text = "";
		try
		{
			if (!Directory.Exists(i3.i()))
			{
				Directory.CreateDirectory(i3.i());
			}
			text = i3.i() + A_1;
			streamWriter = new StreamWriter(File.Open(text, FileMode.Create));
			int value = ((A_0 != null) ? A_0.Count : 0);
			streamWriter.WriteLine(value);
			if (A_0 == null)
			{
				return;
			}
			foreach (string item in A_0)
			{
				streamWriter.WriteLine(item);
			}
		}
		finally
		{
			streamWriter?.Close();
		}
	}

	private void m2(object A_0, FileSystemEventArgs A_1)
	{
		if (!A_1.FullPath.ToLower().EndsWith(".fibfs"))
		{
			hk = DateTime.Now;
		}
	}

	private void m2(object A_0, RenamedEventArgs A_1)
	{
		hk = DateTime.Now;
	}
}
