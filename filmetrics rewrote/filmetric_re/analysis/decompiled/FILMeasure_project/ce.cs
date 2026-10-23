using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FIUsbIntLib;
using Filmetrics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal abstract class ce : q
{
	public enum ErrPublic
	{
		None,
		Generic,
		Hardware,
		MeasModule,
		Video,
		StartupRecipeLoadWarning,
		StartupCTMFirmwareCompatibilityWarning,
		ScatterStationNoUniqueSystemError,
		ScatterStationTooManyStationsError,
		ScatterStationTooFewControllersWarning,
		ScatterStationTooManyControllersWarning,
		StartupModuleControllersOutOfSyncWarning,
		StartupNumExpectedControllersNotFoundWarning,
		StartupNumExpectedSubModulesNotFoundWarning,
		ScatterStationNoFiberMuxWarning,
		StartupNotchFlatFindSpecNotFoundWarning,
		StartupNotchFlatFindSpecUnexpectedWarning,
		StartupNotchFlatFindSpecUsedForMeasWarning
	}

	public delegate void a(Guid A_0, bool A_1, r.c A_2, string A_3, object A_4);

	protected gw t;

	protected f9 u;

	protected const string v = "\\Logs\\";

	[CompilerGenerated]
	private r.d cy;

	protected r.d cz;

	protected gt c0;

	protected bool c1;

	protected bool c2;

	protected a6 c3;

	protected int c4;

	protected r.c c5;

	private bool c6;

	private bool c7;

	private int c8;

	private int c9;

	private r.d.a.b da;

	private List<Guid> db;

	private List<Guid> dc;

	private List<r.d> dd;

	private List<r.d> de;

	private List<r.d> df;

	[SpecialName]
	[CompilerGenerated]
	protected virtual r.d s3()
	{
		return cy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	protected virtual void m2(r.d A_0)
	{
		r.d.c a_ = sj;
		r.d.b a_2 = sm;
		r.d d10 = cy;
		if (d10 != null)
		{
			d10.e(a_);
			d10.e(a_2);
		}
		cy = A_0;
		d10 = cy;
		if (d10 != null)
		{
			d10.d(a_);
			d10.d(a_2);
		}
	}

	public ce()
	{
		db = new List<Guid>();
		dc = new List<Guid>();
		dd = new List<r.d>();
		de = new List<r.d>();
		df = new List<r.d>();
	}

	public ce(ref fz A_0)
		: base(ref A_0)
	{
		db = new List<Guid>();
		dc = new List<Guid>();
		dd = new List<r.d>();
		de = new List<r.d>();
		df = new List<r.d>();
	}

	public void s4()
	{
		t.s4();
	}

	[SpecialName]
	public bool s6()
	{
		return t.tc();
	}

	[SpecialName]
	public void m2(bool A_0)
	{
		t.m2(A_0);
	}

	public bool m2(bool A_0, bool A_1)
	{
		return t.m2(A_0, A_1);
	}

	public void s8()
	{
		c1 = true;
	}

	public void tb()
	{
		if (!c2)
		{
			u.so();
			r.a a10 = t.i(A_0: false);
			if (a10 != r.a.a)
			{
				fz obj = ab8();
				int num = (int)a10;
				obj.c(fz.b.b, "Error when attempting mMeasModuleMgr.Shutdown. Error code is " + num);
			}
			u.i(A_0: false);
			int num2 = f6.ExitThreads();
			if (num2 != 0)
			{
				ab8().c(fz.b.b, "FMSolve error when attempting to shutdown threads. Error code is " + num2);
			}
			c.d().u();
			c2 = true;
		}
	}

	[SpecialName]
	public bool tc()
	{
		return c1;
	}

	[SpecialName]
	public int td()
	{
		return c4;
	}

	public void sj(r.d.a A_0)
	{
		cz.e(default(Guid), A_0);
	}

	public void sm(r.d.a A_0)
	{
		new Collection<f0>();
		if (A_0.a == r.d.a.a.a)
		{
			Collection<string> A_1 = new Collection<string>();
			bool A_2 = true;
			Collection<r.e.a.b> collection = new Collection<r.e.a.b>();
			bool flag = false;
			Collection<ErrPublic> collection2 = m2(ref A_1, ref A_2, c5);
			r.e.a a10 = (r.e.a)A_0;
			foreach (ErrPublic item in collection2)
			{
				switch (item)
				{
				case ErrPublic.StartupRecipeLoadWarning:
					collection.Add(r.e.a.b.l);
					break;
				case ErrPublic.StartupCTMFirmwareCompatibilityWarning:
					collection.Add(r.e.a.b.m);
					break;
				case ErrPublic.ScatterStationNoUniqueSystemError:
					flag = true;
					((r.d.a)a10).a = r.d.a.a.b;
					a10.g = r.e.a.b.ae;
					break;
				case ErrPublic.ScatterStationTooManyStationsError:
					flag = true;
					((r.d.a)a10).a = r.d.a.a.b;
					a10.g = r.e.a.b.af;
					break;
				case ErrPublic.ScatterStationTooFewControllersWarning:
					collection.Add(r.e.a.b.ag);
					break;
				case ErrPublic.ScatterStationTooManyControllersWarning:
					collection.Add(r.e.a.b.ah);
					break;
				case ErrPublic.StartupModuleControllersOutOfSyncWarning:
					collection.Add(r.e.a.b.ak);
					break;
				case ErrPublic.StartupNumExpectedControllersNotFoundWarning:
					collection.Add(r.e.a.b.al);
					break;
				case ErrPublic.StartupNumExpectedSubModulesNotFoundWarning:
					collection.Add(r.e.a.b.am);
					break;
				case ErrPublic.ScatterStationNoFiberMuxWarning:
					collection.Add(r.e.a.b.an);
					break;
				case ErrPublic.StartupNotchFlatFindSpecNotFoundWarning:
					collection.Add(r.e.a.b.ao);
					break;
				case ErrPublic.StartupNotchFlatFindSpecUnexpectedWarning:
					collection.Add(r.e.a.b.ap);
					break;
				case ErrPublic.StartupNotchFlatFindSpecUsedForMeasWarning:
					collection.Add(r.e.a.b.aq);
					break;
				default:
					flag = true;
					A_0.a = r.d.a.a.b;
					ab8().c(fz.a.b, "HwChangedError");
					break;
				case ErrPublic.None:
					break;
				}
			}
			if (tf() && (!ui() || !ul()) && !um())
			{
				flag = true;
				((r.d.a)a10).a = r.d.a.a.b;
				a10.g = te();
			}
			if (flag)
			{
				a10.d = null;
			}
			else
			{
				r.e.a.a a11 = new r.e.a.a();
				a11.a = collection;
				a11.b = A_1;
				a10.d = a11;
				((r.d.a)a10).a = r.d.a.a.a;
			}
			a10 = null;
		}
		cz.d(default(Guid), A_0);
	}

	public r.e.a.b te()
	{
		return u.tc();
	}

	[SpecialName]
	public bool tf()
	{
		return u.st();
	}

	[SpecialName]
	public bool tg()
	{
		return u.s4();
	}

	public Collection<ErrPublic> m2(ref Collection<string> A_0, ref bool A_1, r.c A_2)
	{
		Collection<ErrPublic> collection = new Collection<ErrPublic>();
		Collection<f0> A_3 = new Collection<f0>();
		if (u.m2(ref A_3) == f9.a.a)
		{
			Collection<ca.d> collection2 = t.m2(ref A_3, c0, hg.b4(), ref A_0, ref A_1, A_2);
			foreach (ca.d item in collection2)
			{
				switch (item)
				{
				case ca.d.i:
					collection.Add(ErrPublic.StartupRecipeLoadWarning);
					break;
				case ca.d.j:
					collection.Add(ErrPublic.StartupCTMFirmwareCompatibilityWarning);
					break;
				case ca.d.l:
					collection.Add(ErrPublic.ScatterStationNoUniqueSystemError);
					break;
				case ca.d.o:
					collection.Add(ErrPublic.ScatterStationTooManyStationsError);
					break;
				case ca.d.m:
					collection.Add(ErrPublic.ScatterStationTooFewControllersWarning);
					break;
				case ca.d.n:
					collection.Add(ErrPublic.ScatterStationTooManyControllersWarning);
					break;
				case ca.d.p:
					collection.Add(ErrPublic.StartupModuleControllersOutOfSyncWarning);
					break;
				case ca.d.r:
					collection.Add(ErrPublic.StartupNumExpectedControllersNotFoundWarning);
					break;
				case ca.d.q:
					collection.Add(ErrPublic.StartupNumExpectedSubModulesNotFoundWarning);
					break;
				case ca.d.s:
					collection.Add(ErrPublic.ScatterStationNoFiberMuxWarning);
					break;
				case ca.d.t:
					collection.Add(ErrPublic.StartupNotchFlatFindSpecNotFoundWarning);
					break;
				case ca.d.u:
					collection.Add(ErrPublic.StartupNotchFlatFindSpecUnexpectedWarning);
					break;
				case ca.d.v:
					collection.Add(ErrPublic.StartupNotchFlatFindSpecUsedForMeasWarning);
					break;
				default:
					collection.Add(ErrPublic.MeasModule);
					break;
				case ca.d.a:
					break;
				}
			}
			t.p9();
		}
		else
		{
			collection.Add(ErrPublic.Hardware);
		}
		return collection;
	}

	public gx ua(Guid A_0)
	{
		return t.t9(A_0);
	}

	public Collection<gx> th()
	{
		return t.te();
	}

	public bool ub(Guid A_0)
	{
		int[] array = un(A_0);
		if (array == null)
		{
			return false;
		}
		int[] array2 = array;
		for (int num = 0; num < array2.Length; num = checked(num + 1))
		{
			if (array2[num] == 0)
			{
				return false;
			}
		}
		return true;
	}

	public bool uc(Guid A_0)
	{
		return um(A_0) > 0;
	}

	public bool m2(Guid A_0, ref Guid A_1)
	{
		return t.m2(A_0, ref A_1);
	}

	public ErrPublic m2(ref Collection<gu.a> A_0)
	{
		ErrPublic result = ErrPublic.None;
		if (t.m2(ref A_0) != ca.d.a)
		{
			result = ErrPublic.Hardware;
		}
		return result;
	}

	public gz ti()
	{
		return t.ti();
	}

	public Collection<Guid> tj()
	{
		return t.tf();
	}

	public Collection<Guid> tl()
	{
		return t.tg();
	}

	public Guid ud(Guid A_0)
	{
		return t.ux(A_0);
	}

	public Collection<h6.c> p9(Guid A_0, int A_1)
	{
		return ((ca)t).p9(A_0, A_1);
	}

	public Collection<h6.d> qh(Guid A_0, int A_1)
	{
		return t.qh(A_0, A_1);
	}

	public Collection<string> ue(Guid A_0)
	{
		return t.uf(A_0);
	}

	public Collection<@in.b> uf(Guid A_0)
	{
		return t.ub(A_0);
	}

	public Collection<@in.c> ug(Guid A_0)
	{
		return t.uc(A_0);
	}

	public bool uh(Guid A_0)
	{
		return t.ug(A_0);
	}

	public string m2(string A_0)
	{
		return t.m2(A_0);
	}

	public string p9(string A_0)
	{
		return t.p9(A_0);
	}

	public int ui(Guid A_0)
	{
		return t.ui(A_0);
	}

	public string p9(Guid A_0, int A_1, int A_2)
	{
		return t.p9(A_0, A_1, A_2);
	}

	[SpecialName]
	public string sj(Guid A_0, int A_1)
	{
		return t.sj(A_0, A_1);
	}

	[SpecialName]
	public int uj(Guid A_0)
	{
		return t.uj(A_0);
	}

	[SpecialName]
	public int t0()
	{
		return t.t6();
	}

	[SpecialName]
	public int t5()
	{
		return t.t7();
	}

	[SpecialName]
	public float t6()
	{
		return t.st();
	}

	public void t7()
	{
		t.s3();
	}

	public void t8()
	{
		t.so();
	}

	public void m2(Guid A_0, ref bool A_1, bool A_2, bool A_3, ref string A_4)
	{
		t.m2(A_0, ref A_1, A_2, A_3, ref A_4);
	}

	public f.b qh(Guid A_0, int A_1, int A_2)
	{
		return t.sm(A_0, A_1, A_2);
	}

	public void m2(Guid A_0, h A_1, bool A_2, bool A_3, ref bool[] A_4)
	{
		t.m2(A_0, A_1, A_2, A_3, ref A_4);
	}

	public ew.a qh(string A_0)
	{
		return t.qh(A_0);
	}

	public double m2(Guid A_0, h6.b A_1, int A_2, f.b A_3)
	{
		return t.m2(A_0, A_1, A_2, A_3);
	}

	public double p9(Guid A_0, h6.b A_1, int A_2, f.b A_3)
	{
		return t.p9(A_0, A_1, A_2, A_3);
	}

	public double m2(Guid A_0, h6.b A_1, int A_2, f.b A_3, double A_4)
	{
		return t.m2(A_0, A_1, A_2, A_3, A_4);
	}

	[SpecialName]
	public int m2(string A_0, h6.b A_1, int A_2, f.b A_3)
	{
		return t.m2(A_0, A_1, A_2, A_3);
	}

	[SpecialName]
	public string m2(Guid A_0, f.b A_1, int A_2)
	{
		return t.m2(A_0, A_1, A_2);
	}

	public void m2(Guid A_0, ref string A_1, ref bool A_2, ref string A_3)
	{
		t.m2(A_0, ref A_1, ref A_2, ref A_3);
	}

	public void m2(Guid A_0, string A_1, bool A_2, r.d.a.b A_3, ref bool A_4)
	{
		m2(A_0, wq(A_0).b8(), A_1, A_2, A_3, ref A_4);
	}

	public void m2(Guid A_0, h A_1, string A_2, bool A_3, r.d.a.b A_4, ref bool A_5)
	{
		if (A_3)
		{
			t.m2(A_0, 0, A_2, A_3, A_4, ref A_5);
			return;
		}
		bool[] A_6 = null;
		m2(A_0, A_1, A_2: true, A_3: true, ref A_6);
		int upperBound = A_6.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (A_6[num])
			{
				if (num != 1 || (!A_6[0] && !A_6[2]))
				{
					t.m2(A_0, num, A_2, A_3: false, A_4, ref A_5);
				}
				else
				{
					t.m2(A_0, num, "1", A_3: false, A_4, ref A_5);
				}
			}
		}
	}

	public float[] uk(Guid A_0)
	{
		return t.ul(A_0);
	}

	public void m2(Guid A_0, h.f A_1, f.b A_2, ref double A_3)
	{
		t.m2(A_0, A_1, A_2, ref A_3);
	}

	public void m2(Guid A_0, int A_1, ref double A_2, ref int A_3, ref double A_4, ref int A_5, ref int A_6)
	{
		t.m2(A_0, A_1, ref A_2, ref A_3, ref A_4, ref A_5, ref A_6);
	}

	public bool ul(Guid A_0)
	{
		return t.xh(A_0);
	}

	public int um(Guid A_0)
	{
		return t.xi(A_0);
	}

	public int[] un(Guid A_0)
	{
		return t.xj(A_0);
	}

	public bool[] uo(Guid A_0)
	{
		return t.xk(A_0);
	}

	public bool p9(Guid A_0, hg A_1)
	{
		return t.p9(A_0, A_1);
	}

	public void m2(Guid A_0, int A_1, ref double A_2, ref double A_3)
	{
		t.m2(A_0, A_1, ref A_2, ref A_3);
	}

	public List<it> m2(Guid A_0, hg A_1, bool A_2)
	{
		return t.p9(A_0, A_1, A_2);
	}

	public List<it> m2(Guid A_0, hg A_1, bool A_2, ref bool A_3, ref int A_4)
	{
		return t.m2(A_0, A_1, A_2, ref A_3, ref A_4);
	}

	public List<iu> m2(Guid A_0, List<it> A_1, List<iv> A_2)
	{
		return t.m2(A_0, A_1, A_2);
	}

	public List<it> m2(Guid A_0, bool A_1, h A_2)
	{
		return t.m2(A_0, A_1, A_2);
	}

	public List<it> up(Guid A_0)
	{
		return t.xl(A_0);
	}

	public List<iv> uq(Guid A_0)
	{
		return t.xm(A_0);
	}

	public void m2(Guid A_0, int A_1, ref float[] A_2, ref float[] A_3, ref float[] A_4, ref float[] A_5, ref float A_6, ref float A_7, ref float A_8, ref float A_9, ref float A_10, ref float A_11, ref float A_12, ref float A_13, ref float A_14, ref float A_15, ref float A_16, ref float A_17, ref double A_18, ref double A_19)
	{
		t.m2(A_0, A_1, ref A_2, ref A_3, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8, ref A_9, ref A_10, ref A_11, ref A_12, ref A_13, ref A_14, ref A_15, ref A_16, ref A_17, ref A_18, ref A_19);
	}

	public void m2(Guid A_0, int A_1, int A_2, int A_3, ref float[] A_4, ref float[] A_5, ref int[] A_6, ref int[] A_7)
	{
		t.m2(A_0, A_1, A_2, A_3, ref A_4, ref A_5, ref A_6, ref A_7);
	}

	public void m2(Guid A_0, int A_1, int A_2, int[] A_3, int[] A_4, ref float[] A_5, ref float[] A_6)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, ref A_5, ref A_6);
	}

	public void m2(Guid A_0, bool A_1, r.d A_2, r.d.a.b A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void m2(Guid A_0, bool A_1, bool A_2, r.d A_3, bool A_4, r.d.a.b A_5)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5);
	}

	[SpecialName]
	public bool ur(Guid A_0)
	{
		return t.um(A_0);
	}

	[SpecialName]
	public void p9(Guid A_0, bool A_1)
	{
		t.m2(A_0, A_1);
	}

	[SpecialName]
	public bool us(Guid A_0)
	{
		return t.un(A_0);
	}

	[SpecialName]
	public void qh(Guid A_0, bool A_1)
	{
		t.p9(A_0, A_1);
	}

	public void m2(Guid A_0, ref bool A_1, ref bool A_2, ref bool A_3, ref float A_4, ref float A_5)
	{
		t.m2(A_0, ref A_1, ref A_2, ref A_3, ref A_4, ref A_5);
	}

	public void ut(Guid A_0)
	{
		t.uk(A_0);
	}

	public void t9()
	{
		t.tb();
	}

	public void m2(Guid A_0, ref string A_1, ref string A_2)
	{
		t.m2(A_0, ref A_1, ref A_2);
	}

	[SpecialName]
	public string sj(string A_0)
	{
		return t.sj(A_0);
	}

	[SpecialName]
	public string uu(Guid A_0)
	{
		return t.uo(A_0);
	}

	public bool p9(eo.a A_0)
	{
		return t.p9(A_0);
	}

	public bool qh(eo.a A_0)
	{
		return t.qh(A_0);
	}

	public bool sj(eo.a A_0)
	{
		return t.sj(A_0);
	}

	public bool uv(Guid A_0)
	{
		return t.wi(A_0);
	}

	public bool uw(Guid A_0)
	{
		return t.wj(A_0);
	}

	public bool ua()
	{
		return t.ud();
	}

	public bool ux(Guid A_0)
	{
		return t.wk(A_0);
	}

	public bool sm(eo.a A_0)
	{
		return t.sm(A_0);
	}

	public bool ub()
	{
		return t.ue();
	}

	public bool uc()
	{
		return t.uf();
	}

	public bool ud()
	{
		return t.ug();
	}

	public bool sn(eo.a A_0)
	{
		return t.sn(A_0);
	}

	public bool uy(Guid A_0)
	{
		return t.wl(A_0);
	}

	public bool so(eo.a A_0)
	{
		return t.so(A_0);
	}

	public bool uz(Guid A_0)
	{
		return t.wm(A_0);
	}

	public float ue()
	{
		return t.uh();
	}

	public string uf()
	{
		return t.ui();
	}

	public bool ug()
	{
		return t.uj();
	}

	public bool uh()
	{
		return t.uk();
	}

	public bool ui()
	{
		return t.ul();
	}

	public bool uj()
	{
		return t.um();
	}

	public bool uk()
	{
		return t.un();
	}

	[SpecialName]
	public bool ul()
	{
		return t.up();
	}

	public bool um()
	{
		return t.uo();
	}

	public bool un()
	{
		return t.uq();
	}

	public bool uo()
	{
		return t.ur();
	}

	public bool up()
	{
		return t.us();
	}

	public bool uq()
	{
		return t.ut();
	}

	public bool ur()
	{
		return t.uu();
	}

	public bool us()
	{
		return t.uv();
	}

	public eo ut()
	{
		return t.uw();
	}

	public void p9(Guid A_0, hg A_1, bool A_2)
	{
		t.m2(A_0, A_1, A_2);
	}

	[SpecialName]
	public bool u0(Guid A_0)
	{
		return t.up(A_0);
	}

	public ErrPublic m2(string A_0, string A_1, ref string A_2, string A_3)
	{
		if (t.m2(A_0, A_1, ref A_2, A_3) != ca.d.a)
		{
			return ErrPublic.MeasModule;
		}
		return ErrPublic.None;
	}

	public ErrPublic p9(string A_0, string A_1, ref string A_2, string A_3)
	{
		if (t.p9(A_0, A_1, ref A_2, A_3) != ca.d.a)
		{
			return ErrPublic.MeasModule;
		}
		return ErrPublic.None;
	}

	public ErrPublic sm(string A_0)
	{
		if (t.sm(A_0) != ca.d.a)
		{
			return ErrPublic.MeasModule;
		}
		return ErrPublic.None;
	}

	public ErrPublic m2(string A_0, ref string A_1, hr A_2, bool A_3, r.c A_4, r.d A_5, r.d.a.b A_6)
	{
		if (t.m2(A_0, ref A_1, A_2, A_3, A_4, A_5, A_6) != ca.d.a)
		{
			return ErrPublic.MeasModule;
		}
		return ErrPublic.None;
	}

	public ErrPublic m2(string A_0, string A_1, ref string A_2, r.d A_3, r.l A_4, Collection<hr> A_5, short A_6, r.d.a.b A_7, bool A_8, bool A_9)
	{
		ErrPublic result = ErrPublic.None;
		try
		{
			if (t.m2(A_0, A_1, ref A_2, A_3, A_4, A_5, A_6, c3, A_7, A_8, A_9) != ca.d.a)
			{
				result = ErrPublic.MeasModule;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = ErrPublic.Generic;
			ab8().c(fz.b.b, "Exception caught in FILMeasureMain.MeasureSpectrum(). ", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public ErrPublic m2(string A_0, string A_1, ref string A_2, r.d A_3, r.l A_4, hr A_5, short A_6, r.d.a.b A_7, bool A_8, bool A_9)
	{
		ErrPublic result = ErrPublic.None;
		try
		{
			if (t.m2(A_0, A_1, ref A_2, A_3, A_4, A_5, A_6, c3, A_7, A_8, A_9) != ca.d.a)
			{
				result = ErrPublic.MeasModule;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = ErrPublic.Generic;
			ab8().c(fz.b.b, "Exception caught in FILMeasureMain.MeasureSpectrum(). ", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public ErrPublic m2(string A_0, string A_1, ref string A_2, r.d A_3, r.l A_4, hr A_5, ho A_6, short A_7, r.d.a.b A_8)
	{
		ErrPublic result = ErrPublic.None;
		try
		{
			if (t.m2(A_0, A_1, ref A_2, A_3, A_4, A_5, A_6, A_7, A_8) != ca.d.a)
			{
				result = ErrPublic.MeasModule;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = ErrPublic.Generic;
			ab8().c(fz.b.b, "Exception caught in FILMeasureMain.MeasureSpectrum(). ", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public hr m2(string A_0, hr A_1, int A_2, bool A_3, r.d.a.b A_4, bool A_5)
	{
		return t.m2(A_0, A_1, A_2, A_3, A_4, A_5);
	}

	public long sn(string A_0)
	{
		return t.sn(A_0);
	}

	public void m2(Guid A_0, string A_1, string A_2, r.d A_3, r.l A_4, short A_5, r.d.a.b A_6, bool A_7, int A_8)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8);
	}

	public void m2(Guid A_0, string A_1, string A_2, r.d A_3, int A_4, int A_5, string A_6, bool A_7, bool A_8, bool A_9, int A_10, r.l A_11, r.d.a.b A_12)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10, A_11, A_12);
	}

	public void m2(Guid A_0, string A_1, string A_2, r.d A_3, int A_4, int A_5, string A_6, bool A_7, bool A_8, bool A_9, short A_10, int A_11, r.l A_12, r.d.a.b A_13)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10, A_11, A_12, A_13);
	}

	public void m2(Guid A_0, string[] A_1, r.d A_2, short A_3, string A_4, r.d.a.b A_5)
	{
		t.m2(A_0, A_1, A_2, A_3, c3, A_4, A_5);
	}

	public ErrPublic m2(Guid A_0, string A_1, string A_2, string A_3, ref string A_4, r.d A_5, r.l A_6, r.o A_7, bool A_8, float A_9, float A_10, r.d.a.b A_11, int A_12, string A_13, bool A_14, bool A_15, bool A_16, short A_17)
	{
		ErrPublic result = ErrPublic.None;
		try
		{
			if (t.m2(A_0, A_1, A_2, A_3, ref A_4, A_5, A_6, A_7, A_8, A_9, A_10, A_11, A_12, A_13, A_14, A_15, A_16, A_17) != ca.d.a)
			{
				result = ErrPublic.MeasModule;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = ErrPublic.Generic;
			ab8().c(fz.b.b, "Exception caught in FILMeasureMain.MeasureContactProbeSpectra(). ", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public ErrPublic u1(Guid A_0)
	{
		t.uq(A_0);
		return ErrPublic.None;
	}

	public void u2(Guid A_0)
	{
		t.ur(A_0);
	}

	public void m2(Guid A_0, string A_1, string A_2, short A_3, r.d.a.b A_4, bool A_5)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6: true);
	}

	public void u3(Guid A_0)
	{
		t.us(A_0);
	}

	public void m2(Guid A_0, r.d.a.b A_1)
	{
		t.qh(A_0, A_1);
	}

	public void m2(Guid A_0, string A_1, string A_2, string A_3, ref string A_4, r.d A_5, r.l A_6, r.d.a.b A_7, int A_8, hr A_9, bool A_10 = false, h6.b A_11 = h6.b.b)
	{
		t.m2(A_0, A_1, A_2, A_3, ref A_4, A_5, A_6, A_7, A_8, A_9, A_10, A_11);
	}

	public hr m2(string A_0, string A_1, string A_2)
	{
		hr obj = hr.r(A_0, u2(), ui(), un(), A_1);
		obj.r(u7());
		obj.ag(ref A_0, A_2);
		return obj;
	}

	public ErrPublic m2(Guid A_0, int A_1, f.b A_2, SpectromTempSensorLoc A_3, string A_4, ref string A_5, r.d A_6, r.d.a.b A_7)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, ref A_5, A_6, A_7);
		return ErrPublic.None;
	}

	public void sn(Guid A_0, r.d A_1, r.d.a.b A_2)
	{
		t.sn(A_0, A_1, A_2);
	}

	public void so(Guid A_0, r.d A_1, r.d.a.b A_2)
	{
		t.so(A_0, A_1, A_2);
	}

	public bool m2(Guid A_0, r.d.a.b A_1, ref string A_2)
	{
		hg hg2 = wq(A_0);
		List<hj> list = hg2.ed().es();
		if (list == null || list.Count == 0)
		{
			return true;
		}
		List<hg> list2 = new List<hg>();
		list2.Add(hg2);
		foreach (hj item in list)
		{
			if (item.f() != hj.a.a && item.g())
			{
				hg hg3 = new hg(hg2.dh(), hg2.cd());
				hg3.bu(hg.b0() + item.e(), hg2.cd(), null, A_1, A_4: false, A_5: false, default(Point), null, g2.b.a, A_9: false, ab8(), null, A_12: false, A_13: false, null, A_15: false);
				list2.Add(hg3);
			}
		}
		if (list2.Count == 1)
		{
			return true;
		}
		List<List<hg>> list3 = new List<List<hg>>();
		foreach (hg item2 in list2)
		{
			bool flag = false;
			foreach (List<hg> item3 in list3)
			{
				if (Operators.CompareString(item2.b8().@as(), item3[0].b8().@as(), TextCompare: false) == 0)
				{
					item3.Add(item2);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				List<hg> current2 = new List<hg>();
				current2.Add(item2);
				list3.Add(current2);
			}
		}
		bool[] array = t.vl(A_0);
		bool flag2 = t.vx(A_0);
		bool flag3 = ((t.uj(A_0) <= 0) ? (un(A_0)[0] == 2) : t.uu(A_0));
		foreach (List<hg> item4 in list3)
		{
			int num = checked(item4.Count - 1);
			if (num <= 0)
			{
				continue;
			}
			foreach (object value in Enum.GetValues(typeof(h.f)))
			{
				h.f f10 = (h.f)Conversions.ToInteger(value);
				if (flag2)
				{
					if (!array[(int)f10])
					{
						continue;
					}
				}
				else if (f10 != h.f.a)
				{
					continue;
				}
				checked
				{
					int num2 = num - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						int num4 = num3 + 1;
						int num5 = num;
						for (int num6 = num4; num6 <= num5; num6++)
						{
							hg obj = item4[num3];
							hg hg4 = item4[num6];
							unchecked
							{
								f f11 = obj.b8().a((int)f10);
								f f12 = hg4.b8().a((int)f10);
								if (obj.b8().a(f10, array) && hg4.b8().a(f10, array))
								{
									if (!flag3)
									{
										A_2 = "Additional Recipes Conflict:\r\nTwo recipes that have Acquire New Spectrum checked and \r\n share same baseline file have conflicting acquisition settings.\r\n\r\nTo fix this problem, for each Recipe that has Acquire New Spectrum checked:\r\nUncheck Acquire New Spectrum\r\n OR \r\nClick Edit Recipe; Select Acquisition Settings Tab;\r\n click Advanced...; Enter a unique name in the Baseline Name box.";
										return false;
									}
									if ((f11.h() != f.a.b || f12.h() != f.a.c) && (f11.h() != f.a.c || f12.h() != f.a.b))
									{
										A_2 = "Additional Recipes Conflict:\r\nTwo recipes that have Acquire New Spectrum checked and \r\n share same baseline file have conflicting acquisition settings.\r\n\r\nTo fix this problem, for each Recipe that has Acquire New Spectrum checked:\r\nUncheck Acquire New Spectrum\r\n OR \r\nClick Edit Recipe; Select Acquisition Settings Tab;\r\n click Advanced...; Enter a unique name in the Baseline Name box.";
										return false;
									}
								}
							}
						}
					}
				}
			}
		}
		if (flag2)
		{
			h h10 = hg2.b8();
			foreach (hg item5 in list2)
			{
				if (h10.a(array) != item5.b8().a(array))
				{
					A_2 = "Additional Recipes Conflict:\r\nTwo recipes that have Acquire New Spectrum checked and \r\n share same baseline file have conflicting acquisition settings.\r\n\r\nTo fix this problem, for each Recipe that has Acquire New Spectrum checked:\r\nUncheck Acquire New Spectrum\r\n OR \r\nClick Edit Recipe; Select Acquisition Settings Tab;\r\n change Measurement Type in each Recipe to be the same.";
					return false;
				}
			}
		}
		return true;
	}

	public void m2(Guid A_0, r.d A_1, float[] A_2, bool A_3, r.d.a.b A_4, int A_5, bool A_6, r.c A_7, Point A_8, bool A_9)
	{
		string A_10 = null;
		if (!m2(A_0, A_4, ref A_10))
		{
			throw new ah(A_10);
		}
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9);
	}

	public void m2(Guid A_0, r.d A_1, bool A_2, r.d.a.b A_3, r.c A_4, Point A_5)
	{
		string A_6 = null;
		if (!m2(A_0, A_3, ref A_6))
		{
			throw new ah(A_6);
		}
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5);
	}

	public void m2(Guid A_0, r.d A_1, bool A_2, bool A_3, r.d.a.b A_4, r.c A_5)
	{
		string A_6 = null;
		if (!m2(A_0, A_4, ref A_6))
		{
			throw new ah(A_6);
		}
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5);
	}

	public void p9(Guid A_0, r.d A_1, bool A_2, bool A_3, r.d.a.b A_4, r.c A_5)
	{
		string A_6 = null;
		if (!m2(A_0, A_4, ref A_6))
		{
			throw new ah(A_6);
		}
		t.p9(A_0, A_1, A_2, A_3, A_4, A_5);
	}

	public void m2(Guid A_0, r.d A_1, bool A_2, r.d.a.b A_3, bool A_4, r.c A_5)
	{
		string A_6 = null;
		if (!m2(A_0, A_3, ref A_6))
		{
			throw new ah(A_6);
		}
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5);
	}

	public void m2(Guid A_0, r.d A_1, double A_2, bool A_3, r.d.a.b A_4, int A_5)
	{
		string A_6 = null;
		if (!m2(A_0, A_4, ref A_6))
		{
			throw new ah(A_6);
		}
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5);
	}

	public void m2(Guid A_0, r.d A_1, r.d.a.b A_2, r.c A_3)
	{
		string A_4 = null;
		if (!m2(A_0, A_2, ref A_4))
		{
			throw new ah(A_4);
		}
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void p9(Guid A_0, r.d A_1, r.d.a.b A_2, r.c A_3)
	{
		string A_4 = null;
		if (!m2(A_0, A_2, ref A_4))
		{
			throw new ah(A_4);
		}
		t.p9(A_0, A_1, A_2, A_3);
	}

	public void m2(Guid A_0, r.d A_1, r.c A_2, r.d.a.b A_3)
	{
		string A_4 = null;
		if (!m2(A_0, A_3, ref A_4))
		{
			throw new ah(A_4);
		}
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void m2(string A_0, int A_1, bool A_2, int A_3, r.d.a.b A_4)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4);
	}

	public hr m2(string A_0, int A_1, bool A_2, int A_3)
	{
		return t.m2(A_0, A_1, A_2, A_3);
	}

	public hr m2(Guid A_0, int A_1, bool A_2)
	{
		return t.m2(A_0, A_1, A_2);
	}

	public void m2(string A_0, int A_1, bool A_2, r.d.a.b A_3)
	{
		t.p9(A_0, A_1, A_2, A_3);
	}

	public hr m2(string A_0, int A_1, bool A_2)
	{
		return t.m2(A_0, A_1, A_2);
	}

	[SpecialName]
	public string m2(string A_0, int A_1, f.b A_2, int A_3)
	{
		return t.m2(A_0, A_1, A_2, A_3);
	}

	[SpecialName]
	public string m2(string A_0, int A_1, f.b A_2)
	{
		return t.m2(A_0, A_1, A_2);
	}

	public void m2(string A_0, int A_1, bool A_2, ref Collection<double[]> A_3, ref Collection<DateTime[]> A_4, ref int[] A_5)
	{
		t.m2(A_0, A_1, A_2, ref A_3, ref A_4, ref A_5);
	}

	[SpecialName]
	public string p9(string A_0, int A_1, bool A_2)
	{
		return t.p9(A_0, A_1, A_2);
	}

	public void u4(Guid A_0)
	{
		t.ut(A_0);
	}

	public void m2(Guid A_0, float A_1, float A_2, bool A_3, bool A_4, int A_5, bool A_6, ref bool A_7, ref string A_8, ref string A_9)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6, ref A_7, ref A_8, ref A_9);
	}

	public hr qh(string A_0, int A_1, bool A_2)
	{
		return t.qh(A_0, A_1, A_2);
	}

	[SpecialName]
	public string p9(string A_0, int A_1, f.b A_2)
	{
		return t.p9(A_0, A_1, A_2);
	}

	public void p9(string A_0, int A_1, bool A_2, r.d.a.b A_3)
	{
		t.qh(A_0, A_1, A_2, A_3);
	}

	public void qh(string A_0, int A_1, bool A_2, r.d.a.b A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	[SpecialName]
	public cg uu()
	{
		return t.t9();
	}

	[SpecialName]
	public string[] uv()
	{
		return t.ua();
	}

	[SpecialName]
	public eu m2(int A_0)
	{
		return t.m2(A_0);
	}

	[SpecialName]
	public eu so(string A_0)
	{
		return t.s8(A_0);
	}

	[SpecialName]
	public Collection<eu> uw()
	{
		return t.ub();
	}

	[SpecialName]
	public string st(string A_0)
	{
		return t.tb(A_0);
	}

	[SpecialName]
	public es s3(string A_0)
	{
		return t.tc(A_0);
	}

	[SpecialName]
	public cf s4(string A_0)
	{
		return t.td(A_0);
	}

	[SpecialName]
	public bool s6(string A_0)
	{
		return t.te(A_0);
	}

	[SpecialName]
	public bool s8(string A_0)
	{
		return t.tf(A_0);
	}

	[SpecialName]
	public bool tb(string A_0)
	{
		return t.tg(A_0);
	}

	[SpecialName]
	public r.d.a.b tc(string A_0)
	{
		return t.th(A_0);
	}

	[SpecialName]
	public bool u5(Guid A_0)
	{
		return t.vc(A_0);
	}

	public void m2(Guid A_0, ref int A_1, ref int A_2)
	{
		t.m2(A_0, ref A_1, ref A_2);
	}

	[SpecialName]
	public bool td(string A_0)
	{
		return t.ti(A_0);
	}

	[SpecialName]
	public bool u6(Guid A_0)
	{
		return t.vd(A_0);
	}

	[SpecialName]
	public bool u7(Guid A_0)
	{
		return t.ve(A_0);
	}

	[SpecialName]
	public g2.a u8(Guid A_0)
	{
		return t.vf(A_0);
	}

	[SpecialName]
	public g2 u9(Guid A_0)
	{
		return t.vg(A_0);
	}

	[SpecialName]
	public bool[] va(Guid A_0)
	{
		return t.vl(A_0);
	}

	[SpecialName]
	public int m2(Guid A_0, h.f A_1)
	{
		return t.m2(A_0, A_1);
	}

	[SpecialName]
	public h.f[] vb(Guid A_0)
	{
		return t.vm(A_0);
	}

	[SpecialName]
	public float[] vc(Guid A_0)
	{
		return t.vn(A_0);
	}

	[SpecialName]
	public bool[] vd(Guid A_0)
	{
		return t.vo(A_0);
	}

	[SpecialName]
	public bool[] ve(Guid A_0)
	{
		return t.vp(A_0);
	}

	[SpecialName]
	public a9.a vf(Guid A_0)
	{
		return t.vq(A_0);
	}

	[SpecialName]
	public a9.b vg(Guid A_0)
	{
		return t.vr(A_0);
	}

	[SpecialName]
	public bool vh(Guid A_0)
	{
		return t.vs(A_0);
	}

	[SpecialName]
	public Collection<string> vi(Guid A_0)
	{
		return t.vt(A_0);
	}

	[SpecialName]
	public bool vj(Guid A_0)
	{
		return t.vu(A_0);
	}

	[SpecialName]
	public bool vk(Guid A_0)
	{
		return t.vv(A_0);
	}

	[SpecialName]
	public bool vl(Guid A_0)
	{
		return t.vw(A_0);
	}

	[SpecialName]
	public bool vm(Guid A_0)
	{
		return t.vx(A_0);
	}

	[SpecialName]
	public string p9(string A_0, h6.b A_1, int A_2, f.b A_3)
	{
		return t.p9(A_0, A_1, A_2, A_3);
	}

	[SpecialName]
	public Collection m2(string A_0, int A_1)
	{
		return t.m2(A_0, A_1);
	}

	[SpecialName]
	public bool m2(Guid A_0, h6.b A_1, int A_2, int A_3, SpectromTempSensorLoc A_4)
	{
		return t.m2(A_0, A_1, A_2, A_3, A_4);
	}

	[SpecialName]
	public bool m2(Guid A_0, h6.b A_1, int A_2, f.b A_3, SpectromTempSensorLoc A_4)
	{
		return t.m2(A_0, A_1, A_2, A_3, A_4);
	}

	[SpecialName]
	public bool vn(Guid A_0)
	{
		return t.vy(A_0);
	}

	[SpecialName]
	public bool qh(string A_0, h6.b A_1, int A_2, f.b A_3)
	{
		return t.qh(A_0, A_1, A_2, A_3);
	}

	[SpecialName]
	public float ux()
	{
		return t.tl();
	}

	[SpecialName]
	public float uy()
	{
		return t.tj();
	}

	[SpecialName]
	public float sm(Guid A_0, int A_1)
	{
		return t.sm(A_0, A_1);
	}

	[SpecialName]
	public float sj(Guid A_0, int A_1, int A_2)
	{
		return t.qh(A_0, A_1, A_2);
	}

	[SpecialName]
	public float uz()
	{
		return t.t0();
	}

	[SpecialName]
	public float u0()
	{
		return t.t5();
	}

	[SpecialName]
	public float sn(Guid A_0, int A_1)
	{
		return t.sn(A_0, A_1);
	}

	[SpecialName]
	public float sm(Guid A_0, int A_1, int A_2)
	{
		return t.sj(A_0, A_1, A_2);
	}

	[SpecialName]
	public h vo(Guid A_0)
	{
		return t.vz(A_0);
	}

	public void m2(Guid A_0, string A_1, bool A_2)
	{
		t.m2(A_0, A_1, A_2);
	}

	public bool te(string A_0)
	{
		bool result = false;
		try
		{
			if (t.tl(A_0))
			{
				result = true;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = false;
			ab8().c(fz.b.b, "Exception caught in FILMeasureMain.AutoMeasureStopMeasureIsPermissible(). ", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool vp(Guid A_0)
	{
		bool result;
		try
		{
			result = t.v2(A_0);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ab8().c(fz.b.b, "Exception caught in FILMeasureMain.IsOpticConfigPermissible(). ", a_);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool vq(Guid A_0)
	{
		return t.v3(A_0);
	}

	public bool vr(Guid A_0)
	{
		return t.v4(A_0);
	}

	public bool u1()
	{
		return t.uc();
	}

	public bool vs(Guid A_0)
	{
		return t.v5(A_0);
	}

	public bool vt(Guid A_0)
	{
		return t.v6(A_0);
	}

	public void st(Guid A_0, r.d A_1, r.d.a.b A_2)
	{
		t.st(A_0, A_1, A_2);
	}

	public void m2(Guid A_0, ref FMLegacyAllSystemTypes A_1, ref int A_2)
	{
		t.m2(A_0, ref A_1, ref A_2);
	}

	public bool vu(Guid A_0)
	{
		return t.v8(A_0);
	}

	public bool vv(Guid A_0)
	{
		return t.v9(A_0);
	}

	[SpecialName]
	public Guid vw(Guid A_0)
	{
		return t.wa(A_0);
	}

	public bool vx(Guid A_0)
	{
		return t.wb(A_0);
	}

	public string vy(Guid A_0)
	{
		return t.wc(A_0);
	}

	public string vz(Guid A_0)
	{
		return t.wd(A_0);
	}

	public bool v0(Guid A_0)
	{
		return t.we(A_0);
	}

	public bool v1(Guid A_0)
	{
		return t.wf(A_0);
	}

	public bool v2(Guid A_0)
	{
		return t.wg(A_0);
	}

	public bool v3(Guid A_0)
	{
		return t.wh(A_0);
	}

	public bool sj(Guid A_0, bool A_1)
	{
		return t.sn(A_0, A_1);
	}

	public bool m2(Guid A_0, ref string A_1)
	{
		return t.m2(A_0, ref A_1);
	}

	[SpecialName]
	public bool u2()
	{
		return c0 != null;
	}

	[SpecialName]
	public bool u3()
	{
		return c0.aw();
	}

	[SpecialName]
	public bool u4()
	{
		return c0.ax();
	}

	public bool st(eo.a A_0)
	{
		return t.m2(A_0);
	}

	public void tf(string A_0 = "")
	{
		t.m2(u.s8(), A_0);
	}

	public r.d v4(Guid A_0)
	{
		return t.u0(A_0);
	}

	public r.c tg(string A_0)
	{
		return t.s4(A_0);
	}

	[SpecialName]
	public r.c v5(Guid A_0)
	{
		return t.u1(A_0);
	}

	[SpecialName]
	public r.c th(string A_0)
	{
		return t.s6(A_0);
	}

	[SpecialName]
	public r.c v6(Guid A_0)
	{
		return t.u2(A_0);
	}

	public r.d v8(Guid A_0)
	{
		return t.u3(A_0);
	}

	public r.d v9(Guid A_0)
	{
		return t.u4(A_0);
	}

	[SpecialName]
	public r.d wa(Guid A_0)
	{
		return t.u5(A_0);
	}

	public r.d wb(Guid A_0)
	{
		return t.u6(A_0);
	}

	public r.d wc(Guid A_0)
	{
		return t.u7(A_0);
	}

	public r.d wd(Guid A_0)
	{
		return t.u8(A_0);
	}

	[SpecialName]
	public bool we(Guid A_0)
	{
		return t.u9(A_0);
	}

	[SpecialName]
	public void sm(Guid A_0, bool A_1)
	{
		t.qh(A_0, A_1);
	}

	[SpecialName]
	public string wf(Guid A_0)
	{
		return t.va(A_0);
	}

	[SpecialName]
	public void m2(Guid A_0, string A_1)
	{
		t.m2(A_0, A_1);
	}

	public r.d wg(Guid A_0)
	{
		return t.vb(A_0);
	}

	public void m2(Guid A_0, gx.b A_1)
	{
		t.m2(A_0, A_1);
	}

	public ErrPublic m2(string A_0, string A_1, string A_2, hr.b A_3, int A_4, string A_5)
	{
		if (t.m2(A_0, A_1, A_2, A_3, A_4, A_5) != ca.d.a)
		{
			return ErrPublic.MeasModule;
		}
		return ErrPublic.None;
	}

	public void m2(Guid A_0, bool A_1, bool A_2, bool A_3, bool A_4, r.d A_5, r.d.a.b A_6)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6);
	}

	public void p9(Guid A_0, bool A_1, r.d A_2, r.d.a.b A_3)
	{
		t.p9(A_0, A_1, A_2, A_3);
	}

	public bool sn(Guid A_0, bool A_1)
	{
		return t.sj(A_0, A_1);
	}

	public bool so(Guid A_0, bool A_1)
	{
		return t.sm(A_0, A_1);
	}

	public bool m2(string A_0, hr.b[] A_1)
	{
		return t.m2(A_0, A_1);
	}

	public hr.b[] ti(string A_0)
	{
		return t.tj(A_0);
	}

	public hr.b[] wh(Guid A_0)
	{
		return t.v0(A_0);
	}

	public bool[] wi(Guid A_0)
	{
		return t.v1(A_0);
	}

	public bool m2(Guid A_0, bool A_1, ref bool A_2)
	{
		return t.m2(A_0, A_1, ref A_2);
	}

	public DateTime st(Guid A_0, bool A_1)
	{
		return t.so(A_0, A_1);
	}

	public void m2(Guid A_0, r.d.a.b A_1, bool A_2)
	{
		t.m2(A_0, A_1, A_2);
	}

	public bool tj(string A_0)
	{
		return t.t0(A_0);
	}

	public bool qh(string A_0, int A_1, f.b A_2)
	{
		return t.qh(A_0, A_1, A_2);
	}

	public bool s3(Guid A_0, bool A_1)
	{
		return t.st(A_0, A_1);
	}

	public bool sj(string A_0, int A_1, f.b A_2)
	{
		return t.sj(A_0, A_1, A_2);
	}

	public bool s4(Guid A_0, bool A_1)
	{
		return t.s3(A_0, A_1);
	}

	public bool sm(string A_0, int A_1, f.b A_2)
	{
		return t.sm(A_0, A_1, A_2);
	}

	public bool s6(Guid A_0, bool A_1)
	{
		return t.s4(A_0, A_1);
	}

	public bool sn(string A_0, int A_1, f.b A_2)
	{
		return t.sn(A_0, A_1, A_2);
	}

	public bool so(string A_0, int A_1, f.b A_2)
	{
		return t.so(A_0, A_1, A_2);
	}

	public bool sm(Guid A_0, int A_1, f.b A_2)
	{
		return t.sm(A_0, A_1, A_2);
	}

	public bool tl(string A_0)
	{
		return t.t5(A_0);
	}

	public bool st(string A_0, int A_1, f.b A_2)
	{
		return t.st(A_0, A_1, A_2);
	}

	public bool s3(string A_0, int A_1, f.b A_2)
	{
		return t.s3(A_0, A_1, A_2);
	}

	public bool s8(Guid A_0, bool A_1)
	{
		return t.s6(A_0, A_1);
	}

	public bool wj(Guid A_0)
	{
		return t.wn(A_0);
	}

	public bool wk(Guid A_0)
	{
		return t.wo(A_0);
	}

	public void so(Guid A_0, int A_1)
	{
		t.so(A_0, A_1);
	}

	[SpecialName]
	public string m2(Guid A_0, h.f A_1, bool A_2)
	{
		return t.m2(A_0, A_1, A_2);
	}

	[SpecialName]
	public bool tb(Guid A_0, bool A_1)
	{
		return t.s8(A_0, A_1);
	}

	[SpecialName]
	public void p9(Guid A_0, bool A_1, bool A_2)
	{
		t.m2(A_0, A_1, A_2);
	}

	public bool p9(Guid A_0, string A_1)
	{
		return t.p9(A_0, A_1);
	}

	public bool m2(Guid A_0, int A_1, string A_2, bool A_3)
	{
		return t.m2(A_0, A_1, A_2, A_3);
	}

	[SpecialName]
	public int tc(Guid A_0, bool A_1)
	{
		return t.tb(A_0, A_1);
	}

	public void wl(Guid A_0)
	{
		t.wp(A_0);
	}

	public bool td(Guid A_0, bool A_1)
	{
		return t.tc(A_0, A_1);
	}

	public bool wm(Guid A_0)
	{
		return t.wq(A_0);
	}

	public bool wn(Guid A_0)
	{
		return t.wr(A_0);
	}

	public bool qh(Guid A_0, string A_1)
	{
		return t.qh(A_0, A_1);
	}

	public bool te(Guid A_0, bool A_1)
	{
		return t.td(A_0, A_1);
	}

	public bool wo(Guid A_0)
	{
		return t.ws(A_0);
	}

	public bool wp(Guid A_0)
	{
		return t.wt(A_0);
	}

	public bool s4(string A_0, int A_1, f.b A_2)
	{
		return t.s4(A_0, A_1, A_2);
	}

	public double tf(Guid A_0, bool A_1)
	{
		return t.te(A_0, A_1);
	}

	public int m2(ref short A_0, ref short A_1, ref short A_2, ref short A_3)
	{
		return b1.FIImageVer(ref A_0, ref A_1, ref A_2, ref A_3);
	}

	public hg t0(string A_0)
	{
		return t.t6(A_0);
	}

	public hg wq(Guid A_0)
	{
		return t.wu(A_0);
	}

	public void m2(Guid A_0, hg A_1, r.d A_2, bool A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public he wr(Guid A_0)
	{
		return t.wv(A_0);
	}

	public bool ws(Guid A_0)
	{
		return t.ww(A_0);
	}

	public void m2(Guid A_0, fz A_1, Point A_2, ref bool A_3)
	{
		if (ws(A_0))
		{
			wr(A_0).s(A_1, A_2, ref A_3);
		}
		else
		{
			wq(A_0).bu(A_1, A_2, ref A_3);
		}
	}

	public hg wt(Guid A_0)
	{
		return t.wx(A_0);
	}

	public int m2(Guid A_0, ref long A_1)
	{
		return t.m2(A_0, ref A_1);
	}

	public void m2(Guid A_0, ref int[] A_1, ref float[] A_2, ref Collection<Collection<float[]>> A_3, ref Collection<cd.b[]> A_4, ref Collection<r.g.a[]> A_5)
	{
		t.m2(A_0, ref A_1, ref A_2, ref A_3, ref A_4, ref A_5);
	}

	public void m2(Guid A_0, ref double[] A_1, ref Collection<cd.b[]> A_2, ref Collection<r.g.a[]> A_3)
	{
		t.m2(A_0, ref A_1, ref A_2, ref A_3);
	}

	public void m2(Guid A_0, int A_1, int A_2, ref double[] A_3, ref Collection<double[]> A_4, ref bool A_5, ref hg A_6, ref r.g.a A_7, ref int A_8, ref float A_9, ref int A_10, ref string A_11, ref long A_12)
	{
		t.m2(A_0, A_1, A_2, ref A_3, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8, ref A_9, ref A_10, ref A_11, ref A_12);
	}

	[SpecialName]
	public gt wu(Guid A_0)
	{
		return t.xn(A_0);
	}

	[SpecialName]
	public bool wv(Guid A_0)
	{
		return t.xn(A_0) == null;
	}

	public b5 u5()
	{
		return t.ux();
	}

	public void u6()
	{
		i7.b obj = (i7.b)c3;
		obj.c(u.s6());
		obj.d(c0.ac(u.sj(), u.sm()));
		_ = null;
	}

	[SpecialName]
	public a6 u7()
	{
		return c3;
	}

	public hd u8()
	{
		return t.uy();
	}

	public bool ww(Guid A_0)
	{
		return t.w1(A_0);
	}

	public void m2(Guid A_0, LEDChannel A_1, LightState A_2, ref FiberMuxChannel A_3)
	{
		t.m2(A_0, A_1, A_2, ref A_3);
	}

	public void m2(Guid A_0, LampChannel A_1, LightState A_2, ref FiberMuxChannel A_3)
	{
		t.m2(A_0, A_1, A_2, ref A_3);
	}

	public int m2(Guid A_0, ref float A_1)
	{
		t.m2(A_0, ref A_1);
		int result = default(int);
		return result;
	}

	[SpecialName]
	public double[] wx(Guid A_0)
	{
		return t.w2(A_0);
	}

	[SpecialName]
	public double[] wy(Guid A_0)
	{
		return t.w3(A_0);
	}

	public void m2(Guid A_0, double A_1, r.d.a.b A_2, r.d A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void m2(Guid A_0, FiberMuxChannel A_1, r.d.a.b A_2, r.d A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void p9(Guid A_0, r.d.a.b A_1, r.d A_2)
	{
		t.p9(A_0, A_1, A_2);
	}

	public void qh(Guid A_0, r.d.a.b A_1, r.d A_2)
	{
		t.qh(A_0, A_1, A_2);
	}

	public bool wz(Guid A_0)
	{
		return t.w4(A_0);
	}

	public bool w0(Guid A_0)
	{
		return t.w5(A_0);
	}

	public bool w1(Guid A_0)
	{
		return t.w6(A_0);
	}

	public bool w2(Guid A_0)
	{
		return t.w7(A_0);
	}

	public bool w3(Guid A_0)
	{
		return t.w8(A_0);
	}

	public bool w4(Guid A_0)
	{
		return t.w9(A_0);
	}

	public bool w5(Guid A_0)
	{
		return t.xa(A_0);
	}

	public bool w6(Guid A_0)
	{
		return t.xb(A_0);
	}

	public bool w7(Guid A_0)
	{
		string A_1 = "";
		string A_2 = "";
		if (w5(A_0))
		{
			return false;
		}
		if (m2(A_0))
		{
			return true;
		}
		m2(A_0, ref A_1, ref A_2);
		return a2.a.c(A_1, A_2, i7.e.h);
	}

	private bool m2(Guid A_0)
	{
		return t.xc(A_0);
	}

	public bool m2(string A_0, hc A_1)
	{
		return t.m2(A_0, A_1);
	}

	[SpecialName]
	public bool w8(Guid A_0)
	{
		return t.xd(A_0);
	}

	[SpecialName]
	public void tg(Guid A_0, bool A_1)
	{
		t.tf(A_0, A_1);
	}

	[SpecialName]
	public g2.b w9(Guid A_0)
	{
		return t.wy(A_0);
	}

	[SpecialName]
	public bool xa(Guid A_0)
	{
		return t.wz(A_0);
	}

	public void p9(Guid A_0, r.d.a.b A_1)
	{
		t.m2(A_0, A_1, hg.b4());
	}

	public void xb(Guid A_0)
	{
		t.w0(A_0);
	}

	[SpecialName]
	public string t5(string A_0)
	{
		return t.t7(A_0);
	}

	[SpecialName]
	public void m2(string A_0, string A_1)
	{
		t.p9(A_0, A_1);
	}

	public d4.a t6(string A_0)
	{
		return t.t8(A_0);
	}

	public void m2(string A_0, d4.c A_1)
	{
		t.m2(A_0, A_1);
	}

	public void m2(string A_0, int A_1, int A_2, int A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void p9(string A_0, int A_1)
	{
		t.qh(A_0, A_1);
	}

	public void m2(string A_0, IntPtr A_1, r.d A_2, r.d.a.b A_3, string A_4)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4);
	}

	public bool xc(Guid A_0)
	{
		if (!c6)
		{
			Collection<Guid> collection = t.tf();
			foreach (Guid item in collection)
			{
				if (item != A_0 && (t.xo(item) || t.xp(item)))
				{
					return false;
				}
			}
		}
		return true;
	}

	[SpecialName]
	public bool u9()
	{
		return c6;
	}

	[SpecialName]
	public bool va()
	{
		return c7;
	}

	public void p9(r.d.a.b A_0)
	{
		da = A_0;
		m2();
		c7 = true;
		c6 = false;
		Collection<Guid> collection = t.tf();
		foreach (Guid item in collection)
		{
			if (t.t8(item.ToString()) != null)
			{
				db.Add(item);
			}
		}
		if (db.Count > 1)
		{
			foreach (Guid item2 in db)
			{
				if (!t.xo(item2) && !t.xp(item2))
				{
					dc.Add(item2);
				}
			}
			if (dc.Count > 0)
			{
				foreach (Guid item3 in dc)
				{
					r.d d10 = new r.d();
					dd.Add(d10);
					d10.d((r.d.b)qh);
					t.m2(item3.ToString(), A_1: false, d10, da);
				}
				return;
			}
			p9();
		}
		else
		{
			c6 = true;
			m2();
		}
	}

	private void qh(r.d.a A_0)
	{
		checked
		{
			lock (dd)
			{
				c8++;
				if (c8 < dc.Count)
				{
					return;
				}
				c8 = 0;
			}
			p9();
		}
	}

	private void p9()
	{
		foreach (Guid item in db)
		{
			r.d d10 = new r.d();
			df.Add(d10);
			d10.d((r.d.b)p9);
			t.p9(item.ToString(), d10, da);
		}
	}

	private void p9(r.d.a A_0)
	{
		checked
		{
			lock (dd)
			{
				c8++;
				if (Conversions.ToBoolean(A_0.d))
				{
					c9++;
				}
				if (c8 < db.Count)
				{
					return;
				}
				c8 = 0;
			}
			c6 = c9 == db.Count;
			if (dc.Count > 0)
			{
				foreach (Guid item in dc)
				{
					r.d d10 = new r.d();
					de.Add(d10);
					d10.d((r.d.b)m2);
					t.sj(item.ToString(), d10, da);
				}
				return;
			}
			m2();
		}
	}

	private void m2(r.d.a A_0)
	{
		checked
		{
			lock (dd)
			{
				c8++;
				if (c8 < dc.Count)
				{
					return;
				}
				c8 = 0;
			}
			m2();
		}
	}

	private void m2()
	{
		db.Clear();
		dc.Clear();
		dd.Clear();
		de.Clear();
		df.Clear();
		c8 = 0;
		c9 = 0;
		c7 = false;
	}

	public void m2(string A_0, r.d A_1, r.d.a.b A_2)
	{
		t.m2(A_0, A_1, A_2);
	}

	public void m2(Guid A_0, bool A_1, r.l A_2, r.d.a.b A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public gy t7(string A_0)
	{
		gz gz2 = ti();
		foreach (gy item in gz2.i())
		{
			if (Operators.CompareString(item.x(), A_0, TextCompare: false) == 0)
			{
				return item;
			}
		}
		return null;
	}

	public void p9(string A_0, r.d A_1, r.d.a.b A_2)
	{
		t.qh(A_0, A_1, A_2);
	}

	public void m2(string A_0, bool A_1, r.d A_2, r.d.a.b A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void qh(string A_0, r.d A_1, r.d.a.b A_2)
	{
		t.sj(A_0, A_1, A_2);
	}

	public void m2(string A_0, bool A_1, int A_2, ej.b A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void m2(string A_0, int A_1, float A_2, float A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void m2(string A_0, float A_1, float A_2, ScrollOrientation A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void m2(string A_0, r.d A_1)
	{
		t.m2(A_0, A_1);
	}

	public void m2(string A_0, r.d A_1, r.d.a.b A_2, d4.e A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	[SpecialName]
	public bool vb()
	{
		return t.u1();
	}

	[SpecialName]
	public int vc()
	{
		return t.u2();
	}

	[SpecialName]
	public int vd()
	{
		return t.u3();
	}

	public ErrPublic m2(string A_0, ref string A_1, r.d A_2, r.l A_3)
	{
		if (t.m2(A_0, A_1, A_2, A_3) != ca.d.a)
		{
			return ErrPublic.Video;
		}
		return ErrPublic.None;
	}

	public ErrPublic m2(string A_0, ref string A_1, r.d A_2, r.d A_3)
	{
		if (t.m2(A_0, A_1, A_2, A_3) != ca.d.a)
		{
			return ErrPublic.Video;
		}
		return ErrPublic.None;
	}

	public void m2(int A_0, int A_1, int A_2, int A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void m2(Guid A_0, byte A_1, r.d A_2, r.d.a.b A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void s3(Guid A_0, r.d A_1, r.d.a.b A_2)
	{
		t.s3(A_0, A_1, A_2);
	}

	public float xd(Guid A_0)
	{
		return t.xe(A_0);
	}

	public b9.k xe(Guid A_0)
	{
		return t.xf(A_0);
	}

	public b9.l[] xf(Guid A_0)
	{
		return t.xg(A_0);
	}

	public void m2(ref List<Guid> A_0, ref List<string> A_1)
	{
		Collection<Guid> collection = tj();
		string A_2 = null;
		new i7();
		A_0 = new List<Guid>();
		A_1 = new List<string>();
		foreach (Guid item in collection)
		{
			Collection<string> collection2 = vi(item);
			if (collection2 == null)
			{
				continue;
			}
			foreach (string item2 in collection2)
			{
				if (a2.a.c(string.Empty, item2, i7.e.bl, ref A_2))
				{
					A_0.Add(item);
					A_1.Add(A_2);
					break;
				}
			}
		}
	}

	public void p9(string A_0, string A_1)
	{
		t.qh(A_0, A_1);
	}

	[SpecialName]
	public float xg(Guid A_0)
	{
		return t.vh(A_0);
	}

	[SpecialName]
	public void m2(Guid A_0, float A_1)
	{
		t.m2(A_0, A_1);
	}

	[SpecialName]
	public string xh(Guid A_0)
	{
		return t.vi(A_0);
	}

	[SpecialName]
	public int xi(Guid A_0)
	{
		return t.vj(A_0);
	}

	[SpecialName]
	public int xj(Guid A_0)
	{
		return t.vk(A_0);
	}

	public void m2(Guid A_0, ip.m A_1, r.d.a.b A_2, r.d A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void m2(Guid A_0, ip.i A_1, bool A_2, bool A_3, r.d.a.b A_4, r.d A_5, r.c A_6)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6);
	}

	public void m2(Guid A_0, ip.j A_1, r.d.a.b A_2, r.d A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void m2(Guid A_0, ip.h A_1, r.d.a.b A_2, r.d A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void p9(Guid A_0, ip.h A_1, r.d.a.b A_2, r.d A_3)
	{
		t.p9(A_0, A_1, A_2, A_3);
	}

	public void qh(Guid A_0, ip.h A_1, r.d.a.b A_2, r.d A_3)
	{
		t.qh(A_0, A_1, A_2, A_3);
	}

	public void m2(string A_0, @in.b A_1, int A_2, r.d A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void m2(Guid A_0, Collection<ip.d>[] A_1, r.d A_2)
	{
		t.m2(A_0, A_1, A_2);
	}

	public void m2(string A_0, ip.d A_1, h6.b A_2, int A_3, int A_4, r.d A_5)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, int A_3, float A_4, r.d A_5)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, int A_3, r.d A_4)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4);
	}

	public void p9(Guid A_0, h6.b A_1, int A_2, int A_3, r.d A_4)
	{
		t.p9(A_0, A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, int A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	[SpecialName]
	public float qh(Guid A_0, h6.b A_1, int A_2, f.b A_3)
	{
		return t.qh(A_0, A_1, A_2, A_3);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, f.b A_3, float A_4, r.d A_5)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, f.b A_3, r.d A_4)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, r.d A_1)
	{
		t.m2(A_0, A_1);
	}

	public void m2(string A_0, h6.c A_1, h6.b A_2, int A_3, r.d A_4)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, bool A_1, bool A_2, r.d A_3)
	{
		t.m2(A_0, A_1, A_2, A_3);
	}

	public void m2(Guid A_0, int A_1, f.b A_2, r.d.a.b A_3, r.d A_4)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, bool A_1, bool A_2, r.d A_3, r.d.a.b A_4)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, int A_1, float A_2, r.c A_3, r.d A_4, r.d.a.b A_5)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5);
	}

	public void s4(Guid A_0, r.d A_1, r.d.a.b A_2)
	{
		t.s4(A_0, A_1, A_2);
	}

	public FMUSBDeviceType m2(string A_0, int A_1, int A_2)
	{
		return t.m2(A_0, A_1, A_2);
	}

	public bool m2(string A_0, ref Guid A_1)
	{
		return t.m2(A_0, ref A_1);
	}

	public void qh(Guid A_0, h6.b A_1, int A_2, int A_3, r.d A_4)
	{
		t.qh(A_0, A_1, A_2, A_3, A_4);
	}

	public void sj(Guid A_0, h6.b A_1, int A_2, int A_3, r.d A_4)
	{
		t.sj(A_0, A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, int A_3, Collection<cf> A_4, bool A_5, r.d A_6)
	{
		t.m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6);
	}

	public ip.d sn(Guid A_0, int A_1, int A_2)
	{
		return t.sn(A_0, A_1, A_2);
	}

	public ip.e so(Guid A_0, int A_1, int A_2)
	{
		return t.so(A_0, A_1, A_2);
	}

	public FMUSBDeviceType qh(string A_0, int A_1)
	{
		return t.p9(A_0, A_1);
	}

	public void m2(hc A_0, ref Guid A_1, ref bool A_2)
	{
		bool flag = false;
		Collection<gu.a> A_3 = null;
		A_2 = false;
		m2(ref A_3);
		foreach (gu.a item in A_3)
		{
			if (Operators.CompareString(A_0.c1(), item.a.ToString(), TextCompare: false) == 0)
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			A_1 = new Guid(A_0.c1());
			A_2 = true;
		}
		else
		{
			hg hg2 = A_0.cy();
			if (!hg2.b5())
			{
				foreach (gu.a item2 in A_3)
				{
					if (uy(item2.a) == (A_0.cu() == null) || uz(item2.a) == (A_0.cu() != null) || A_0.cn().af())
					{
						A_1 = item2.a;
						A_2 = true;
						break;
					}
				}
			}
			else if (hg2.dh().a0(A_0.c0()))
			{
				if (!A_0.ct())
				{
					foreach (gu.a item3 in A_3)
					{
						if ((uv(item3.a) || hg2.dh().a0(A_0.c0())) && !vl(item3.a))
						{
							A_1 = item3.a;
							A_2 = true;
							break;
						}
					}
				}
				else
				{
					foreach (gu.a item4 in A_3)
					{
						if (vl(item4.a))
						{
							A_1 = item4.a;
							A_2 = true;
							break;
						}
					}
				}
			}
			hg2 = null;
		}
		if (!A_2)
		{
			A_1 = A_3[0].a;
		}
	}

	public void m2(hc A_0, Point A_1, ref Guid A_2, ref bool A_3)
	{
		m2(A_0, ref A_2, ref A_3);
		m2(A_0, A_1, A_2, ref A_3);
	}

	protected void m2(hc A_0, Point A_1, Guid A_2, ref bool A_3)
	{
		hg hg2 = wq(A_2);
		bool flag;
		string arg;
		string text;
		string a_;
		if (ws(A_2))
		{
			flag = !wr(A_2).ae();
			string A_4 = "SpectrumPluralString";
			arg = hu.a(ref A_4).ToLower();
			text = "Composite Recipe";
			A_4 = "RecipeUnsavedHistPromptFmt2";
			string format = hu.a(ref A_4);
			A_4 = "CompRecipeUnsavedHistPrompt";
			a_ = string.Format(format, hu.a(ref A_4), text.ToLower());
		}
		else
		{
			flag = false;
			string A_4 = "SpectrumSingularString";
			arg = hu.a(ref A_4).ToLower();
			text = "Recipe";
			A_4 = "RecipeUnsavedHistPromptFmt2";
			a_ = string.Format(hu.a(ref A_4), text.ToLower(), text.ToLower());
		}
		if (A_3)
		{
			if ((!hg2.c9() && Operators.CompareString(hg2.cl(), A_0.cy().cl(), TextCompare: false) != 0) || flag)
			{
				SystemSounds.Exclamation.Play();
				fz A_5 = ab8();
				bool num = fe.b(ref A_5, a_, "RecipeLoadTitle", "OKString", "CancelString", A_1);
				m2(A_5);
				if (!num)
				{
					hg2.fy = false;
					return;
				}
			}
			hg2.fy = true;
		}
		else
		{
			fz A_5 = ab8();
			string A_4 = "HistoryIncompatibleRecipe";
			fe.b(ref A_5, string.Format(hu.a(ref A_4), text, arg), ref A_1);
			m2(A_5);
		}
	}

	public hf xk(Guid A_0)
	{
		return null;
	}

	public void xl(Guid A_0)
	{
	}
}
