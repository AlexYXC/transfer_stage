using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class gw : ca
{
	[CompilerGenerated]
	private global::r.d hn;

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d m2()
	{
		return hn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void m2(global::r.d A_0)
	{
		global::r.d.b a_ = m2;
		hn?.e(a_);
		hn = A_0;
		hn?.d(a_);
	}

	public gw(fz A_0, ref string A_1)
		: base(A_0, ref A_1)
	{
		m2(new global::r.d());
	}

	public void m2(Guid A_0, global::r.d.a.b A_1, ref string A_2)
	{
		af.f(ab8(), ref A_2);
		uz(A_0).x1().d(A_0, new global::r.d.a(A_1, 0L));
	}

	public void m2(Guid A_0, global::r.d.a.b A_1)
	{
		ae.e();
		uz(A_0).x1().d(A_0, new global::r.d.a(A_1, 0L));
	}

	public void m2(string[] A_0, string A_1, global::r.d.a.b A_2, ref string A_3)
	{
		string text = i3.o() + "\\Optics\\";
		if (!Directory.Exists(text))
		{
			FileSystem.MkDir(text);
		}
		checked
		{
			int A_5 = default(int);
			bool flag = default(bool);
			bool flag2 = default(bool);
			foreach (string text2 in A_0)
			{
				if (Operators.CompareString(Path.GetExtension(text2).ToLower(), ".dat", TextCompare: false) == 0)
				{
					string a_ = File.ReadAllText(text2);
					string A_4 = null;
					eu eu2 = new eu();
					eu2.h("FM4 Microscope");
					i3.a(ref A_5, a_, ref A_4);
					i3.a(ref A_5, a_, ref A_4);
					int.Parse(A_4);
					i3.a(ref A_5, a_, ref A_4);
					i3.a(ref A_5, a_, ref A_4);
					if (int.Parse(A_4) <= 1)
					{
						i3.a(ref A_5, a_, ref A_4);
						i3.a(ref A_5, a_, ref A_4);
						int num2 = int.Parse(A_4) - 1;
						for (int num3 = 0; num3 <= num2; num3++)
						{
							string A_6 = null;
							i3.a(ref A_5, a_, ref A_6);
							A_6 = jg.e(A_6);
							i3.a(ref A_5, a_, ref A_4);
							float a_2 = float.Parse(A_4, CultureInfo.InvariantCulture);
							i3.a(ref A_5, a_, ref A_4);
							float a_3 = float.Parse(A_4, CultureInfo.InvariantCulture);
							i3.a(ref A_5, a_, ref A_4);
							float a_4 = float.Parse(A_4, CultureInfo.InvariantCulture);
							i3.a(ref A_5, a_, ref A_4);
							float a_5 = float.Parse(A_4, CultureInfo.InvariantCulture);
							i3.a(ref A_5, a_, ref A_4);
							float a_6 = float.Parse(A_4, CultureInfo.InvariantCulture);
							i3.a(ref A_5, a_, ref A_4);
							float a_7 = float.Parse(A_4, CultureInfo.InvariantCulture);
							i3.a(ref A_5, a_, ref A_4);
							float a_8 = float.Parse(A_4, CultureInfo.InvariantCulture);
							i3.a(ref A_5, a_, ref A_4);
							bool a_9 = bool.Parse(A_4.Trim('#'));
							i3.a(ref A_5, a_, ref A_4);
							bool a_10 = bool.Parse(A_4.Trim('#'));
							et et2 = new et();
							et2.u(a_10);
							et2.x(a_6);
							et2.y(a_7);
							et2.w(a_5);
							et2.t(A_6);
							et2.u(a_3);
							et2.v(a_4);
							et2.t(a_2);
							et2.z(a_8);
							et2.t(a_9);
							_ = null;
							eu2.l().Add(et2);
						}
						eu2.f();
					}
				}
				Path.GetFileNameWithoutExtension(text2);
				Path.GetFileName(text2);
				string destFileName = text + Path.GetFileName(text2);
				string left = Path.GetExtension(text2).ToLower();
				File.Copy(text2, destFileName, overwrite: true);
				if (Operators.CompareString(left, ".fictm", TextCompare: false) == 0 && !flag)
				{
					flag = true;
				}
				if (!flag2 && (Operators.CompareString(left, ".fimic", TextCompare: false) == 0 || Operators.CompareString(left, ".dat", TextCompare: false) == 0))
				{
					flag2 = true;
				}
			}
			bool flag3 = default(bool);
			foreach (g7 item in t)
			{
				hg hg2 = wu(item.zk());
				string text3 = ((!hg2.d0().q() || hg2.d0().s() == null) ? null : hg2.d0().s().n());
				if (flag)
				{
					m2(item.zk(), A_2, ref A_3);
				}
				if (flag2)
				{
					m2(item.zk(), A_2);
				}
				if (hg2.d0().q())
				{
					cf cf2 = null;
					if (!string.IsNullOrEmpty(text3))
					{
						cf2 = t9().f(text3);
					}
					if (cf2 == null && af.f() > 0)
					{
						cf2 = af.f(0);
						flag3 = true;
					}
					hg2.d0().a(cf2);
					if (flag3)
					{
						hg2.bv(A_1, DateTime.Now);
					}
				}
				else
				{
					hg2.bv(A_1, DateTime.Now);
				}
				hg2.bv(m2(), A_1: true);
				hg2 = null;
			}
		}
	}

	private void m2(global::r.d.a A_0)
	{
		if (A_0.a != global::r.d.a.a.a)
		{
			ab8().c(fz.b.b, "Error attempting to update recipe in MeasModuleMgr.mOpticsImported_TaskFinishedEvent");
		}
	}

	public void m2(Guid A_0, string A_1, h6.b A_2, int A_3, global::f.b A_4, global::r.d A_5, global::r.d.a.b A_6)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4, A_5, A_6);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, int A_3, global::r.d A_4, global::r.d.a.b A_5)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4, A_5);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, int A_3, h6.c A_4, global::r.d A_5, global::r.d.a.b A_6)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4, A_5, A_6);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, int A_3, im.a A_4, global::r.d A_5, global::r.d.a.b A_6)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4, A_5, A_6);
	}

	[SpecialName]
	private Guid m2(Guid A_0)
	{
		return ua(A_0)?.o[0] ?? A_0;
	}

	public bool m2(Guid A_0, bool A_1, eo.a A_2)
	{
		return uy(A_0)[0].m2(A_1, A_2);
	}

	public bool m2(Guid A_0, hg A_1)
	{
		return uy(A_0)[0].so(A_1);
	}

	public bool p9(Guid A_0)
	{
		return uz(A_0).ym();
	}

	public bool qh(Guid A_0)
	{
		return uz(A_0).yn();
	}

	public void m2(Guid A_0, global::r.d.a.b A_1, global::r.d A_2)
	{
		uz(A_0).qh(A_1, A_2);
	}

	public bool sj(Guid A_0)
	{
		return uz(A_0).yl();
	}

	public void m2(Guid A_0, string A_1, string A_2, global::r.d A_3, l A_4, global::r.d.a.b A_5, int A_6)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4, A_6, A_5);
	}

	public void m2(Guid A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		uz(A_0).p9(A_1, A_2);
	}

	public void p9(Guid A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		uz(A_0).qh(A_1, A_2);
	}

	public void m2(Guid A_0, string A_1, global::r.d A_2, global::r.d.a.b A_3)
	{
		uz(A_0).m2(A_1, A_2, A_3);
	}

	public void m2(Guid A_0, jf.a A_1, long A_2, global::r.d A_3, global::r.d.a.b A_4)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, jf.a A_1, long A_2, bool A_3, global::r.d A_4, global::r.d.a.b A_5)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4, A_5);
	}

	public void m2(Guid A_0, jl.d A_1, ref jl.e A_2)
	{
		uz(A_0).m2(A_1, ref A_2);
	}

	public void m2(Guid A_0, jl.f A_1, ref jl.g A_2)
	{
		uz(A_0).m2(A_1, ref A_2);
	}

	public void m2(Guid A_0, jl.h A_1, ref jl.i A_2)
	{
		uz(A_0).m2(A_1, ref A_2);
	}

	[SpecialName]
	public int m2(Guid A_0, long A_1)
	{
		return uz(A_0).m2(A_1);
	}

	[SpecialName]
	public jm sm(Guid A_0)
	{
		return uz(A_0).yo();
	}

	[SpecialName]
	public bool sn(Guid A_0)
	{
		return uz(A_0).yp();
	}

	[SpecialName]
	public jn so(Guid A_0)
	{
		return uz(A_0).yq();
	}

	public float m2(Guid A_0, float A_1, float A_2, long A_3)
	{
		return uz(A_0).m2(A_1, A_2, A_3);
	}

	public hr.b st(Guid A_0)
	{
		return uz(A_0).yr();
	}

	[SpecialName]
	public string s3(Guid A_0)
	{
		return uz(A_0).ys();
	}

	public void m2(Guid A_0, string A_1, int A_2)
	{
		uz(A_0).m2(A_1, A_2);
	}

	public float p9(Guid A_0, long A_1)
	{
		return uz(A_0).p9(A_1);
	}

	public ReadOnlyCollection<float> s4(Guid A_0)
	{
		return uz(A_0).yt();
	}

	[SpecialName]
	public bool s6(Guid A_0)
	{
		return uz(A_0).yu();
	}

	public void p9()
	{
		foreach (g7 item in t)
		{
			item.yx();
		}
	}

	public List<it> s8(Guid A_0)
	{
		return uz(A_0).yy();
	}

	public float[] tb(Guid A_0)
	{
		return uz(A_0).v2();
	}

	public float[] tc(Guid A_0)
	{
		return uz(A_0).v3();
	}

	public List<iv> td(Guid A_0)
	{
		return uz(A_0).yw();
	}

	public bool te(Guid A_0)
	{
		foreach (g7 item in uy(A_0))
		{
			if (item.v4())
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public bool m2(Guid A_0, int A_1, global::f.b A_2)
	{
		return uz(m2(A_0)).so(A_1, A_2);
	}

	[SpecialName]
	public bool tf(Guid A_0)
	{
		return uz(m2(A_0)).y2();
	}

	[SpecialName]
	public bool qh()
	{
		foreach (g7 item in t)
		{
			if (item.y4())
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public bool m2(Guid A_0, global::h.f A_1, global::f.b A_2)
	{
		return uz(m2(A_0)).m2(A_1, A_2);
	}

	[SpecialName]
	public bool tg(Guid A_0)
	{
		return uz(m2(A_0)).yz();
	}

	[SpecialName]
	public bool th(Guid A_0)
	{
		return uz(m2(A_0)).y0();
	}

	[SpecialName]
	public bool ti(Guid A_0)
	{
		return uz(m2(A_0)).y1();
	}

	[SpecialName]
	public bool tj(Guid A_0)
	{
		return uz(m2(A_0)).y5();
	}

	public void m2(Guid A_0, ref bool A_1, ref bool A_2)
	{
		uz(m2(A_0)).m2(ref A_1, ref A_2);
	}

	[SpecialName]
	public bool tl(Guid A_0)
	{
		return uz(m2(A_0)).y6();
	}

	public void m2(Guid A_0, global::r.c A_1, global::r.d A_2, global::r.d.a.b A_3)
	{
		uz(m2(A_0)).m2(A_1, A_2, A_3);
	}

	public void p9(Guid A_0, global::r.c A_1, global::r.d A_2, global::r.d.a.b A_3)
	{
		uz(m2(A_0)).p9(A_1, A_2, A_3);
	}

	public bool m2(Guid A_0, float A_1, float A_2)
	{
		return uz(A_0).m2(A_1, A_2);
	}

	public bool m2(Guid A_0, int A_1, float A_2, float A_3)
	{
		return uz(A_0).p9(A_1, A_2, A_3);
	}

	[SpecialName]
	public float t0(Guid A_0)
	{
		return uz(m2(A_0)).y7();
	}

	[SpecialName]
	public bool t5(Guid A_0)
	{
		return uz(m2(A_0)).y8();
	}

	[SpecialName]
	public bool t6(Guid A_0)
	{
		return uz(m2(A_0)).y9();
	}

	[SpecialName]
	public bool t7(Guid A_0)
	{
		return uz(m2(A_0)).za();
	}

	[SpecialName]
	public g9[] m2(Guid A_0, int A_1)
	{
		return uz(m2(A_0)).t8(A_1);
	}

	[SpecialName]
	public g6 t8(Guid A_0)
	{
		return uz(m2(A_0)).uy();
	}

	public void m2(Guid A_0, global::h.f A_1, global::f.b A_2, global::r.d A_3, global::r.d.a.b A_4)
	{
		uz(m2(A_0)).m2(A_1, A_2, A_3, A_4);
	}

	public void qh(Guid A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		uz(m2(A_0)).s6(A_1, A_2);
	}

	public void sj(Guid A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		uz(m2(A_0)).s8(A_1, A_2);
	}

	public void sm(Guid A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		uz(m2(A_0)).tb(A_1, A_2);
	}

	public void m2(Guid A_0, global::h.f A_1, global::f.b A_2, bool A_3, string A_4, global::r.d A_5, global::r.d.a.b A_6)
	{
		uz(m2(A_0)).m2(A_1, A_2, A_3, A_4, A_5, A_6);
	}

	public void m2(Guid A_0, float A_1, string A_2, global::r.d A_3, global::r.d.a.b A_4)
	{
		uz(m2(A_0)).m2(A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, int A_1, float A_2, string A_3, global::r.d A_4, global::r.d.a.b A_5)
	{
		uz(m2(A_0)).m2(A_1, A_2, A_3, A_4, A_5);
	}

	public void m2(Guid A_0, float A_1, bool A_2, global::r.d A_3, global::r.d.a.b A_4)
	{
		uz(m2(A_0)).m2(A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, bool A_1, string A_2, global::r.d A_3, global::r.d.a.b A_4)
	{
		uz(m2(A_0)).m2(A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, g6 A_1, global::r.d.a.b A_2)
	{
		uz(m2(A_0)).m2(A_1, A_2);
	}

	[SpecialName]
	public string p9(Guid A_0, int A_1, global::f.b A_2)
	{
		return uz(m2(A_0)).st(A_1, A_2);
	}

	public void p9(Guid A_0, global::h.f A_1, global::f.b A_2, bool A_3, string A_4, global::r.d A_5, global::r.d.a.b A_6)
	{
		uz(m2(A_0)).p9(A_1, A_2, A_3, A_4, A_5, A_6);
	}
}
