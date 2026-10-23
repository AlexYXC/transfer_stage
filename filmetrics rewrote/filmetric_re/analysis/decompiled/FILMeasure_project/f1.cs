using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;

internal class f1 : ce
{
	private new delegate void a(Guid A_0, gr A_1, f4 A_2, Point A_3, ix.b A_4, bool A_5, r.d.a.b A_6, ix.b A_7, ix.e A_8);

	public static f2 fz = new f2();

	private const string f0 = "UserRecipes";

	public f1(ref fz A_0, ref string A_1)
		: base(ref A_0)
	{
		m2(ref A_0, ref A_1);
	}

	private void m2(ref fz A_0, ref string A_1)
	{
		A_0 = new fz();
		m2(A_0);
		ab8().c(i3.o() + "\\Logs\\");
		AssemblyInfo info = c.d().Info;
		string text = null;
		ab8().c(global::fz.b.a, "Starting " + info.AssemblyName + text + ". Version=" + info.Version.ToString());
		AssemblyName name = Assembly.GetExecutingAssembly().GetName();
		if (Operators.CompareString(info.AssemblyName, name.Name, TextCompare: false) != 0)
		{
			ab8().c(global::fz.b.a, "Executing assembly name=" + name.Name + ". Version=" + name.Version.ToString());
		}
		name = null;
		hg.bw(e.a().CustomRecipePath);
		jb.w(e.a().CustomMaterialPath);
		u = new f9(ab8());
		t = new gw(ab8(), ref A_1);
		m2(new r.d());
		c0 = null;
	}

	public ErrPublic m2(gt A_0, string A_1, ref string A_2, r.d A_3, r.c A_4, r.d.a.b A_5)
	{
		ErrPublic result = ErrPublic.None;
		cz = A_3;
		c0 = A_0;
		if (A_0 != null)
		{
			c3 = new i7.b();
		}
		else
		{
			c3 = new a6();
		}
		if (A_0 == null)
		{
			ip.ue();
		}
		if (Directory.Exists(i3.o() + "\\ImportRecipes\\") || Directory.Exists(hg.bw()) || Directory.Exists(jb.l()) || Directory.Exists(e4.b()))
		{
			c1 c10 = new c1();
			c1 obj = c10;
			string A_6 = "CopyRecipesAndMaterialMessage";
			obj.d(hu.a(ref A_6));
			if (Directory.Exists(i3.o() + "\\ImportRecipes\\") || Directory.Exists(hg.bw()) || Directory.Exists(jb.l()))
			{
				if (Directory.Exists(i3.o() + "\\ImportRecipes\\"))
				{
					FileInfo[] files = new DirectoryInfo(i3.o() + "\\ImportRecipes\\").GetFiles("*", System.IO.SearchOption.AllDirectories);
					foreach (FileInfo fileInfo in files)
					{
						if (Operators.CompareString(fileInfo.Extension.ToLower(), ".fibrp", TextCompare: false) == 0 || Operators.CompareString(fileInfo.Extension.ToLower(), ".fibra", TextCompare: false) == 0)
						{
							fz a_ = ab8();
							string fullName = fileInfo.FullName;
							string a_2 = hg.bw();
							bool A_7 = false;
							hg.bu(a_, fullName, a_2, A_3: true, ref A_7, A_5: false);
							if (File.GetAttributes(fileInfo.FullName) != FileAttributes.Normal)
							{
								File.SetAttributes(fileInfo.FullName, FileAttributes.Normal);
							}
							File.Delete(fileInfo.FullName);
						}
					}
					if (Directory.Exists(i3.o() + "\\ImportRecipes\\"))
					{
						c.e().FileSystem.DeleteDirectory(i3.o() + "\\ImportRecipes\\", DeleteDirectoryOption.DeleteAllContents);
					}
				}
				i3.c(hg.bw(), hg.bz());
				i3.c(jb.l(), jb.d());
			}
			i3.c(e4.b(), e4.aa());
			c10.i();
			c10.Dispose();
			c10 = null;
		}
		string text = i3.o() + "\\FIUsbDrvrVers.dat";
		if (File.Exists(text))
		{
			string text2 = i3.m() + "\\FIUsbDrvrVers.dat";
			if (!File.Exists(text2) || DateTime.Compare(File.GetLastWriteTimeUtc(text), File.GetLastWriteTimeUtc(text2)) > 0)
			{
				File.Copy(text, text2, overwrite: true);
			}
		}
		m2();
		if (f6.InitializeThreads() != 0)
		{
			result = ErrPublic.Generic;
		}
		c4 = f6.NumberOfCPUs();
		c5 = A_4;
		if (u.m2(A_0, A_1, ref A_2, s3(), A_4, A_5) != r.a.a)
		{
			result = ErrPublic.Hardware;
		}
		return result;
	}

	public void m2(r.d.a.b A_0)
	{
		u.sn();
		t.p9(A_0: true);
		f9 obj = u;
		gt a_ = c0;
		string A_1 = null;
		string A_2 = null;
		if (obj.m2(a_, ref A_1, ref A_2, s3(), A_0, A_5: true) != f9.a.a)
		{
			throw new Exception("Error attempting to ReinitializeHWMgr");
		}
	}

	[SpecialName]
	public float p9()
	{
		return u.tb();
	}

	public bool m2(eo.a A_0)
	{
		eo eo2 = ut();
		if (!eo2.az(A_0) && !eo2.av(A_0))
		{
			return sm();
		}
		return true;
	}

	public bool qh()
	{
		return b6.c(uy(), u0());
	}

	public bool sj()
	{
		return b7.c(uy(), u0());
	}

	[SpecialName]
	public bool sm()
	{
		return t.th();
	}

	[SpecialName]
	public bool m2(Guid A_0)
	{
		return t.ue(A_0);
	}

	[SpecialName]
	public float m2(Guid A_0, int A_1, int A_2)
	{
		return ((ca)t).m2(A_0, A_1, A_2);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, int A_3, ref bool A_4, ref float A_5, ref float A_6, ref bool A_7, ref float A_8)
	{
		t.m2(A_0, A_1, A_2, A_3, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8);
	}

	[SpecialName]
	public float m2(Guid A_0, int A_1, f.b A_2)
	{
		return t.qh(A_0, A_1, A_2);
	}

	[SpecialName]
	public float p9(Guid A_0, int A_1, f.b A_2)
	{
		return t.sj(A_0, A_1, A_2);
	}

	public bool m2(Guid A_0, bool A_1, eo.a A_2)
	{
		return t.m2(A_0, A_1, A_2);
	}

	public bool m2(Guid A_0, hg A_1)
	{
		return t.m2(A_0, A_1);
	}

	public f.c sn()
	{
		Collection<Guid> collection = tj();
		bool flag = default(bool);
		f.c result = default(f.c);
		bool flag2 = default(bool);
		foreach (Guid item in collection)
		{
			if (sm(item))
			{
				flag = true;
				result = f.c.b;
			}
			else
			{
				flag2 = true;
				result = f.c.a;
			}
		}
		if (flag2 && flag)
		{
			result = f.c.c;
		}
		return result;
	}

	public void m2(Guid A_0, ref a9[] A_1)
	{
		int num = (vm(A_0) ? vb(A_0).GetUpperBound(0) : 0);
		checked
		{
			A_1 = new a9[num + 1];
			float[] array = vc(A_0);
			h.f[] array2 = vb(A_0);
			int num2 = num;
			int A_2 = default(int);
			for (int num3 = 0; num3 <= num2; num3++)
			{
				A_1[num3] = new a9();
				a9 a10 = A_1[num3];
				m2(A_0, num3, ref a10.d, ref a10.e, ref a10.q, ref a10.r, ref A_2);
				a10.o = A_2 == 2;
				a10.p = A_2 == 0;
				m2(A_0, num3, ref a10.f, ref a10.g, ref a10.s, ref a10.t, ref a10.h, ref a10.i, ref a10.u, ref a10.v, ref a10.j, ref a10.k, ref a10.w, ref a10.x, ref a10.l, ref a10.m, ref a10.y, ref a10.z, ref a10.n, ref a10.aa);
				if (array != null)
				{
					a10.ac = array[num3];
				}
				if (array2 != null)
				{
					a10.ab = array2[num3];
				}
				a10.c = vf(A_0);
				a10.a = vg(A_0);
				a10.b = vh(A_0);
				a10 = null;
			}
		}
	}

	private void m2()
	{
		string A_ = string.Empty;
		string A_2 = string.Empty;
		string text = i3.m() + "\\FM4RecipeAndMaterialFilesImported";
		string text2 = "FM4RecipeAndMaterialFilesImported";
		StreamWriter streamWriter = null;
		c1 c10 = null;
		string a_ = "TypeLib\\{FF489448-7277-498A-8857-5C3DE871E562}";
		checked
		{
			try
			{
				if (File.Exists(text + ".txt") || !p9(a_, ref A_))
				{
					return;
				}
				string text3 = null;
				string A_3 = "ImportFM4RecipeAndMaterialFiles";
				text3 = hu.a(ref A_3);
				fz A_4 = ab8();
				bool num = fe.b(ref A_4, text3, "ImportRecipeFileTitle", "Yes", "No", new Point(c.b().gm().Left + unchecked(c.b().gm().Width / 2) + 20, c.b().gm().Top + unchecked(c.b().gm().Height / 2)));
				m2(A_4);
				if (num)
				{
					string text4 = ((!m2(A_ + "RecipeFilesPath.txt", ref A_2)) ? A_ : A_2);
					string a_2 = text4 + "UserRecipes";
					string a_3 = text4 + "Material";
					streamWriter = new StreamWriter(text + ".tmp");
					c10 = new c1();
					c1 obj = c10;
					A_3 = "CopyRecipesAndMaterialMessage";
					obj.d(hu.a(ref A_3));
					m2(a_2, text4, streamWriter);
					m2(a_3, streamWriter);
					if (streamWriter != null)
					{
						streamWriter.Close();
						c.e().FileSystem.RenameFile(text + ".tmp", text2 + ".txt");
					}
				}
				else
				{
					streamWriter = new StreamWriter(text + ".txt");
				}
			}
			catch (ThreadAbortException ex2)
			{
				ProjectData.SetProjectError(ex2);
				ThreadAbortException ex3 = ex2;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception a_4 = ex4;
				ab8().c(global::fz.b.b, "Error attempting to import FILMeasure 4 Recipes and Material files", a_4);
				ProjectData.ClearProjectError();
			}
			finally
			{
				streamWriter?.Close();
				if (c10 != null)
				{
					c10.Close();
					c10.Dispose();
				}
			}
		}
	}

	private bool p9(string A_0, ref string A_1)
	{
		RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(A_0, writable: false);
		if (registryKey != null)
		{
			registryKey = registryKey.OpenSubKey("1.0\\0\\win32", writable: false);
			if (registryKey != null)
			{
				A_1 = Path.GetDirectoryName(registryKey.GetValue("").ToString()) + "\\";
				return true;
			}
			return false;
		}
		return false;
	}

	private bool m2(string A_0, ref string A_1)
	{
		if (c.e().FileSystem.FileExists(A_0))
		{
			StreamReader streamReader = new StreamReader(File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read));
			streamReader.ReadLine();
			A_1 = streamReader.ReadLine();
			streamReader.Close();
			A_1 = A_1.Substring(1, checked(A_1.Length - 2));
			if (A_1.Length > 0)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private void m2(string A_0, string A_1, StreamWriter A_2)
	{
		if (!c.e().FileSystem.DirectoryExists(A_0))
		{
			return;
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(A_0);
		string text = hg.bz();
		string text2 = A_0.Substring(checked(A_1.Length + "UserRecipes".Length));
		string text3 = text + text2 + "\\";
		if (!Directory.Exists(text3))
		{
			c.e().FileSystem.CreateDirectory(text3);
		}
		FileInfo[] files = directoryInfo.GetFiles("*.rpe");
		foreach (FileInfo fileInfo in files)
		{
			if (Operators.CompareString(fileInfo.Name, "DefaultStructure.rpe", TextCompare: false) != 0)
			{
				hg.bu(A_0 + "\\" + fileInfo.Name, text3, ab8(), A_2, hg.b4());
			}
			Application.DoEvents();
		}
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		foreach (DirectoryInfo directoryInfo2 in directories)
		{
			m2(A_0 + "\\" + directoryInfo2.Name, A_1, A_2);
		}
	}

	private void m2(string A_0, StreamWriter A_1)
	{
		if (!c.e().FileSystem.DirectoryExists(A_0))
		{
			return;
		}
		FileInfo[] files = new DirectoryInfo(A_0).GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			switch (fileInfo.Extension)
			{
			case ".nnn":
			case ".kkk":
			case ".rrr":
			case ".fmnnn":
			case ".fmkkk":
				jb.a(A_0 + "\\" + fileInfo.Name, ab8(), A_1);
				Application.DoEvents();
				break;
			}
		}
	}

	public string m2(Guid A_0, bool A_1, bool A_2)
	{
		hg hg2 = wq(A_0);
		gz gz2 = ti();
		string text = null;
		string A_3 = null;
		foreach (gy item in gz2.i())
		{
			if (item.y() == A_0)
			{
				bool a_ = item.z();
				bool a_2 = item.ae();
				item.s(A_1);
				item.u(A_1);
				if (!item.ag() || !g2.k(u8(A_0)))
				{
					text = ((!A_1 && item.ac()) ? (hg.bz() + item.ab()) : ((item.aa() != null) ? (hg.bz() + item.aa()) : (hg.b0() + hg2.ci() + ".rpe")));
				}
				else if (!e4.a(e4.aa() + item.af(), ref A_3))
				{
					ab8().c(global::fz.b.b, "Unable to Retrieve Recipe Data From Template");
					text = hg.bz() + item.aa();
				}
				else
				{
					text = hg.bz() + A_3;
				}
				if (!A_2)
				{
					item.s(a_);
					item.u(a_2);
				}
				return text;
			}
		}
		return null;
	}

	public void m2(Guid A_0, gr A_1, f4 A_2, Point A_3, ix.b A_4, bool A_5, r.d.a.b A_6, ix.b A_7, ix.e A_8)
	{
		if (A_4 == null)
		{
			throw new NullReferenceException("theDialogCanceled must be supplied");
		}
		if (A_7 == null)
		{
			throw new NullReferenceException("baselineNotAllowed must be supplied");
		}
		if (A_8 == null)
		{
			throw new NullReferenceException("baselineNotAllowedReason must be supplied");
		}
		if (A_2 != null && A_2.InvokeRequired)
		{
			IAsyncResult asyncResult = A_2.BeginInvoke(new a(m2), A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8);
			do
			{
				Application.DoEvents();
			}
			while (!asyncResult.IsCompleted);
			return;
		}
		string A_9 = null;
		A_7.a = !m2(A_0, r.d.a.b.a, ref A_9);
		if (A_7.a)
		{
			if (A_6 == r.d.a.b.a)
			{
				fe.b(ab8(), A_9, A_3);
				A_4.a = true;
			}
			else
			{
				A_8.a = A_9;
			}
			return;
		}
		string A_10 = null;
		if (!m2(A_0, ref A_10))
		{
			throw new InvalidOperationException("Baseline disabled because: " + A_10);
		}
		hg hg2 = wq(A_0);
		if (hg2.d0().q())
		{
			cq cq2 = new cq(ab8());
			cq2.a(cq.a.b, this, A_2, A_0, A_3);
			A_4.a = cq2.DialogResult == DialogResult.Cancel;
		}
		else if (sm(A_0))
		{
			e6 obj = new e6(ab8());
			obj.e(A_0: true);
			obj.c(e6.b.b, A_1, this, A_2, A_0, A_5: false);
		}
		else
		{
			m2(A_0, 0f);
			e6 e10 = new e6(ab8());
			e6.b a_ = e6.b.c;
			if (u6(A_0) && !w5(A_0) && hg2.d0().c() != g2.a.b)
			{
				a_ = e6.b.d;
			}
			if (A_5)
			{
				e10.b(a_, A_1, this, A_2, A_0, A_5: false);
			}
			else
			{
				e10.c(a_, A_1, this, A_2, A_0, A_5: false);
			}
			A_4.a = e10.DialogResult == DialogResult.Cancel;
		}
		hg2 = null;
	}

	public void m2(Guid A_0, fz A_1, List<string> A_2, Point A_3, r.d A_4)
	{
		hg hg2 = t0(A_0.ToString());
		string text = hg2.c1();
		string extension = Path.GetExtension(text);
		fk fk2 = new fk(A_1, hg.b0(), text, extension, fk.a.a, "DefaultRecipe", A_6: false, A_2);
		fk2.a(A_3);
		if (!fk2.k())
		{
			hg2.bu(fk2.q(), hg.b4(), A_4, r.d.a.b.a, A_4: true, A_5: true, default(Point), null, w9(A_0), !w6(A_0), A_1, xk(A_0), A_12: false, A_13: false, null, A_15: false);
		}
	}

	public void m2(string[] A_0, string A_1, r.d.a.b A_2, ref string A_3)
	{
		t.m2(A_0, A_1, A_2, ref A_3);
	}

	public void m2(Guid A_0, string A_1, h6.b A_2, int A_3, f.b A_4, r.d A_5, r.d.a.b A_6)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, int A_3, h6.c A_4, r.d A_5, r.d.a.b A_6)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, int A_3, r.d A_4, r.d.a.b A_5)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, int A_3, im.a A_4, r.d A_5, r.d.a.b A_6)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6);
	}

	[SpecialName]
	public r.d so()
	{
		return t.td();
	}

	public bool p9(Guid A_0)
	{
		return t.p9(A_0);
	}

	public bool qh(Guid A_0)
	{
		return t.qh(A_0);
	}

	public void m2(Guid A_0, r.d.a.b A_1, r.d A_2)
	{
		t.m2(A_0, A_1, A_2);
	}

	public bool sj(Guid A_0)
	{
		return t.sj(A_0);
	}

	public void m2(Guid A_0, string A_1, string A_2, r.d A_3, r.l A_4, r.d.a.b A_5, int A_6)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6);
	}

	public void m2(Guid A_0, r.d A_1, r.d.a.b A_2)
	{
		t.m2(A_0, A_1, A_2);
	}

	public void p9(Guid A_0, r.d A_1, r.d.a.b A_2)
	{
		t.p9(A_0, A_1, A_2);
	}

	public void m2(Guid A_0, string A_1, r.d A_2, r.d.a.b A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void m2(Guid A_0, jf.a A_1, long A_2, r.d A_3, r.d.a.b A_4)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, jf.a A_1, long A_2, bool A_3, r.d A_4, r.d.a.b A_5)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5);
	}

	public bool m2(Guid A_0, bool A_1)
	{
		bool flag = false;
		if (tb(A_0) && A_1)
		{
			return sj(A_0, A_1: true);
		}
		bool A_2 = default(bool);
		flag = ((!eo.at(sm(A_0), sn(A_0), null)) ? (m2(A_0, A_1: false, ref A_2) && s3(A_0, A_1: false) && s4(A_0, A_1: false) && sn(A_0, A_1: false) && so(A_0, A_1: false) && v3(A_0)) : (m2(A_0, A_1: false, ref A_2) && s4(A_0, A_1: false) && sn(A_0, A_1: false) && v3(A_0)));
		if (!flag && u6(A_0) && A_2 && s3(A_0, A_1: false))
		{
			flag = true;
		}
		return flag;
	}

	[SpecialName]
	public bool sm(Guid A_0)
	{
		return t.ud(A_0);
	}

	[SpecialName]
	public bool sn(Guid A_0)
	{
		return false;
	}

	public void m2(Guid A_0, jl.d A_1, ref jl.e A_2)
	{
		t.m2(A_0, A_1, ref A_2);
	}

	public void m2(Guid A_0, jl.f A_1, ref jl.g A_2)
	{
		t.m2(A_0, A_1, ref A_2);
	}

	public void m2(Guid A_0, jl.h A_1, ref jl.i A_2)
	{
		t.m2(A_0, A_1, ref A_2);
	}

	[SpecialName]
	public int m2(Guid A_0, long A_1)
	{
		return t.m2(A_0, A_1);
	}

	[SpecialName]
	public jm so(Guid A_0)
	{
		return t.sm(A_0);
	}

	[SpecialName]
	public bool st(Guid A_0)
	{
		return t.sn(A_0);
	}

	[SpecialName]
	public jn s3(Guid A_0)
	{
		return t.so(A_0);
	}

	public float m2(Guid A_0, float A_1, float A_2, long A_3)
	{
		return t.m2(A_0, A_1, A_2, A_3);
	}

	public hr.b s4(Guid A_0)
	{
		return t.st(A_0);
	}

	[SpecialName]
	public string s6(Guid A_0)
	{
		return t.s3(A_0);
	}

	public void m2(Guid A_0, string A_1, int A_2)
	{
		t.m2(A_0, A_1, A_2);
	}

	public float p9(Guid A_0, long A_1)
	{
		return t.p9(A_0, A_1);
	}

	public ReadOnlyCollection<float> s8(Guid A_0)
	{
		return t.s4(A_0);
	}

	[SpecialName]
	public bool tb(Guid A_0)
	{
		return t.s6(A_0);
	}

	public List<it> tc(Guid A_0)
	{
		return t.s8(A_0);
	}

	public float[] td(Guid A_0)
	{
		return t.tb(A_0);
	}

	public float[] te(Guid A_0)
	{
		return t.tc(A_0);
	}

	public List<iv> tf(Guid A_0)
	{
		return t.td(A_0);
	}

	public bool tg(Guid A_0)
	{
		return t.te(A_0);
	}

	[SpecialName]
	public bool qh(Guid A_0, int A_1, f.b A_2)
	{
		return t.m2(A_0, A_1, A_2);
	}

	[SpecialName]
	public bool st()
	{
		return t.qh();
	}

	[SpecialName]
	public bool m2(Guid A_0, h.f A_1, f.b A_2)
	{
		return t.m2(A_0, A_1, A_2);
	}

	[SpecialName]
	public bool th(Guid A_0)
	{
		return t.tg(A_0);
	}

	[SpecialName]
	public bool ti(Guid A_0)
	{
		return t.th(A_0);
	}

	[SpecialName]
	public bool tj(Guid A_0)
	{
		return t.ti(A_0);
	}

	[SpecialName]
	public bool tl(Guid A_0)
	{
		return t.tj(A_0);
	}

	public void m2(Guid A_0, ref bool A_1, ref bool A_2)
	{
		t.m2(A_0, ref A_1, ref A_2);
	}

	[SpecialName]
	public bool t0(Guid A_0)
	{
		return t.tl(A_0);
	}

	public void m2(Guid A_0, r.c A_1, r.d A_2, r.d.a.b A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void p9(Guid A_0, r.c A_1, r.d A_2, r.d.a.b A_3)
	{
		t.p9(A_0, A_1, A_2, A_3);
	}

	public bool m2(Guid A_0, float A_1, float A_2)
	{
		return t.m2(A_0, A_1, A_2);
	}

	public bool m2(Guid A_0, int A_1, float A_2, float A_3)
	{
		return t.m2(A_0, A_1, A_2, A_3);
	}

	[SpecialName]
	public float t5(Guid A_0)
	{
		return t.t0(A_0);
	}

	[SpecialName]
	public bool t6(Guid A_0)
	{
		return t.t5(A_0);
	}

	[SpecialName]
	public bool t7(Guid A_0)
	{
		return t.t6(A_0);
	}

	[SpecialName]
	public bool t8(Guid A_0)
	{
		return t.t7(A_0);
	}

	[SpecialName]
	public g9[] m2(Guid A_0, int A_1)
	{
		return t.m2(A_0, A_1);
	}

	[SpecialName]
	public g6 t9(Guid A_0)
	{
		return t.t8(A_0);
	}

	public void m2(Guid A_0, h.f A_1, f.b A_2, r.d A_3, r.d.a.b A_4)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4);
	}

	public void qh(Guid A_0, r.d A_1, r.d.a.b A_2)
	{
		t.qh(A_0, A_1, A_2);
	}

	public void sj(Guid A_0, r.d A_1, r.d.a.b A_2)
	{
		t.sj(A_0, A_1, A_2);
	}

	public void sm(Guid A_0, r.d A_1, r.d.a.b A_2)
	{
		t.sm(A_0, A_1, A_2);
	}

	public void m2(Guid A_0, h.f A_1, f.b A_2, bool A_3, string A_4, r.d A_5, r.d.a.b A_6)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6);
	}

	public void m2(Guid A_0, float A_1, string A_2, r.d A_3, r.d.a.b A_4)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, int A_1, float A_2, string A_3, r.d A_4, r.d.a.b A_5)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5);
	}

	public void m2(Guid A_0, float A_1, bool A_2, r.d A_3, r.d.a.b A_4)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, bool A_1, string A_2, r.d A_3, r.d.a.b A_4)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, g6 A_1, r.d.a.b A_2)
	{
		t.m2(A_0, A_1, A_2);
	}

	[SpecialName]
	public string sj(Guid A_0, int A_1, f.b A_2)
	{
		return t.p9(A_0, A_1, A_2);
	}

	public void p9(Guid A_0, h.f A_1, f.b A_2, bool A_3, string A_4, r.d A_5, r.d.a.b A_6)
	{
		t.p9(A_0, A_1, A_2, A_3, A_4, A_5, A_6);
	}
}
