using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using FIUsbIntLib;
using Filmetrics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal abstract class ca : r
{
	protected new class a : m
	{
		public bool dp;

		public short dq;

		public Guid dr;

		public t ds;

		public string dt;

		public string du;

		public bool dv;

		public DateTime dw;

		public bool dx;

		public AutoResetEvent dy;

		public a(Guid A_0, global::r.d.a.b A_1)
			: base(A_1)
		{
			dr = A_0;
			d = TaskExecutionType.System;
		}
	}

	internal class b : global::r.d
	{
		public new class a : global::r.d.a
		{
			public Guid a0;

			public a(b A_0, long A_1)
				: base(A_0, A_1)
			{
			}
		}
	}

	internal new class c
	{
		public long a;

		public int b;

		public l c;

		public global::r.d d;

		public global::r.d.a e;

		public AutoResetEvent f;

		public Guid g;

		public c()
		{
			f = new AutoResetEvent(initialState: false);
		}
	}

	public new enum d
	{
		a,
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
		v
	}

	protected new Collection<g7> t;

	protected new Collection<gx> u;

	protected new long v;

	protected new Collection<c> w;

	[CompilerGenerated]
	private new System.Timers.Timer x;

	protected new AutoResetEvent y;

	protected new global::r.d z;

	protected new const byte aa = 1;

	protected const byte ab = 2;

	protected const byte ac = byte.MaxValue;

	protected const int ad = 500;

	protected ep ae;

	protected cg af;

	protected Collection<d3> ag;

	protected new hd ah;

	protected gz ai;

	protected eo aj;

	protected bool ak;

	protected b5 al;

	protected float am;

	protected float an;

	[CompilerGenerated]
	private global::r.d ao;

	[CompilerGenerated]
	private global::r.d ap;

	protected AutoResetEvent aq;

	protected bool ar;

	protected const float @as = 4f;

	protected const float at = 2f;

	[CompilerGenerated]
	private bool au;

	[SpecialName]
	[CompilerGenerated]
	protected virtual System.Timers.Timer sj()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	protected virtual void m2(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = m2;
		System.Timers.Timer timer = x;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		x = A_0;
		timer = x;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	protected virtual global::r.d sm()
	{
		return ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	protected virtual void p9(global::r.d A_0)
	{
		global::r.d.b a_ = sn;
		ao?.e(a_);
		ao = A_0;
		ao?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	protected virtual global::r.d sn()
	{
		return ap;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	protected virtual void qh(global::r.d A_0)
	{
		global::r.d.b a_ = so;
		ap?.e(a_);
		ap = A_0;
		ap?.d(a_);
	}

	public ca(fz A_0, ref string A_1)
		: base(A_0, "MeasModuleMgr")
	{
		t = new Collection<g7>();
		u = new Collection<gx>();
		w = new Collection<c>();
		m2(new System.Timers.Timer());
		y = new AutoResetEvent(initialState: false);
		z = new global::r.d();
		aq = new AutoResetEvent(initialState: false);
		ah = new hd();
		al = new b5(A_0);
		al.k();
		aj = new eo();
		p9(new global::r.d());
		qh(new global::r.d());
		string A_2 = global::c.d().Info.DirectoryPath + "\\Color\\";
		int num = b1.ICInitFromFiles(ref A_2);
		if (num != 0)
		{
			ab8().c(fz.b.a, "Error in MeasModuleMgrBase.ICInitFromFiles", num.ToString());
		}
		ae = new ep();
		ae.e();
		af = new cg();
		af.f(ab8(), ref A_1);
		if (uz() != d.a)
		{
			throw new Exception("Error Creating Camera Manager!");
		}
		try
		{
			al.o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ab8().c(fz.b.a, "Error in MeasModuleMgrBase.LoadSolarDataFromFile - Data not loaded");
			ProjectData.ClearProjectError();
		}
	}

	public void so()
	{
		foreach (g7 item in t)
		{
			item.t6(A_0: true);
		}
		_ = DateTime.Now;
		foreach (g7 item2 in t)
		{
			do
			{
				Thread.Sleep(50);
			}
			while (!item2.z1());
		}
	}

	[SpecialName]
	public float st()
	{
		return 18f;
	}

	public void s3()
	{
		Thread.Sleep(4000);
		foreach (g7 item in t)
		{
			item.vd();
		}
		Thread.Sleep(2000);
		foreach (g7 item2 in t)
		{
			item2.t6(A_0: false);
		}
		_ = DateTime.Now;
		foreach (g7 item3 in t)
		{
			do
			{
				Thread.Sleep(50);
			}
			while (item3.z1());
		}
	}

	protected override void f(m A_0)
	{
		try
		{
			switch (A_0.d)
			{
			case m.TaskExecutionType.System:
				m2((a)A_0);
				break;
			case m.TaskExecutionType.Execution:
				m2((t)A_0);
				break;
			default:
				ab8().c(fz.b.b, "Error: Trying to execute a task of type " + A_0.d.ToString() + " in a MeasModuleMgr object. ", Environment.StackTrace);
				break;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ab8().c(fz.b.b, "Exception caught in MeasModuleMgr.ExecuteATask(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	protected override void g(m A_0)
	{
	}

	protected override void h(m A_0)
	{
	}

	protected void m2(a A_0)
	{
		try
		{
			m.a a10 = ((m)A_0).a;
			if (a10 != m.a.t)
			{
				return;
			}
			a a11 = A_0;
			gx gx2 = ua(a11.dr);
			AutoResetEvent A_1 = null;
			if (a11.dy == null)
			{
				if (a11.ds != null)
				{
					if (a11.dx)
					{
						a11.ds.ce = a11.dw.AddSeconds(a11.ds.cf);
					}
					else
					{
						a11.ds.ce = DateTime.Now;
						a11.dx = true;
					}
					a11.dw = a11.ds.ce;
				}
				gx2.aj.Reset();
				m2(a11.dr, a11.dt, a11.du, a11.g, null, a11.dq, a11.d3(), a11.dp, 0, A_9: true, A_0.l, ref A_1, a11.dv);
				a11.dy = A_1;
				if (a11.dv)
				{
					a11.dv = false;
				}
			}
			else
			{
				int num = 300000;
				if (a11.ds != null && (float)num < a11.ds.cf * 1000f * 2f)
				{
					num = checked((int)Math.Round(a11.ds.cf * 1000f * 2f));
				}
				A_1 = a11.dy;
				a11.dy = null;
				if (!A_1.WaitOne(num, exitContext: false))
				{
					throw new ApplicationException("Timeout waiting for completion of aggregate AcquireAndMeasureSpectra");
				}
				gx gx3 = gx2;
				if (gx3.x)
				{
					if (!ua(gx3.n()).aj.WaitOne(num, exitContext: false))
					{
						throw new ApplicationException("Timeout waiting for start of subsystem zero acquire");
					}
					if (!ua(gx3.n()).ai.WaitOne(num, exitContext: false))
					{
						throw new ApplicationException("Timeout waiting for update of input signals");
					}
				}
				gx3 = null;
			}
			a11 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ab8().c(fz.b.b, "Error in TaskCoreExecution. Task ID=" + ((m)A_0).a, a_);
			ProjectData.ClearProjectError();
		}
	}

	protected void m2(t A_0)
	{
		long a_ = default(long);
		if (A_0.g != null)
		{
			a_ = A_0.g.d();
		}
		f.a a10 = new f.a(A_0.d3(), a_);
		global::r.d.a a11 = new global::r.d.a(A_0.d3(), a_);
		((global::r.d.a)a10).a = global::r.d.a.a.b;
		a10.c = A_0.e;
		try
		{
			a11.a = global::r.d.a.a.a;
			A_0.g.e(A_0.e, a11);
			m.a a12 = ((m)A_0).a;
			if (a12 == m.a.q)
			{
				if (A_0.cf > 0f)
				{
					DateTime t2 = A_0.ce.AddSeconds(A_0.cf);
					A_0.h.t(A_0.cf, A_0.d3());
					do
					{
						double totalSeconds = DateTime.Now.Subtract(A_0.ce).TotalSeconds;
						A_0.h.t((float)(100.0 * totalSeconds / (double)A_0.cf));
						double num = (double)A_0.cf - totalSeconds;
						if (num * 1000.0 > 50.0)
						{
							sj().Interval = 50.0;
						}
						else if (num > 0.0)
						{
							sj().Interval = checked((int)Math.Round(num * 1000.0));
						}
						sj().Start();
						if (!y.WaitOne(200, exitContext: false))
						{
							ab8().c(fz.b.a, "Timeout in MeasModuleMgr.TaskCoreExecution waiting for delay timer elapsed");
						}
					}
					while (DateTime.Compare(DateTime.Now, t2) < 0 && !A_0.l.q());
					A_0.h.z();
				}
				((global::r.d.a)a10).a = global::r.d.a.a.a;
				return;
			}
			int num2 = (int)((m)A_0).a;
			throw new ArgumentOutOfRangeException("Unknown Task.ID in TaskCoreExecution. Task.Id=" + num2);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			ab8().c(fz.b.b, "Error in TaskCoreExecution. Task ID=" + ((m)A_0).a, a_2);
			ProjectData.ClearProjectError();
		}
		finally
		{
			A_0.g.d(A_0.e, a10);
		}
	}

	protected void m2(object A_0, ElapsedEventArgs A_1)
	{
		y.Set();
	}

	public void s4()
	{
		if (aj.a0())
		{
			Thread thread = new Thread((ParameterizedThreadStart)global::j.a);
			thread.IsBackground = true;
			thread.Name = "AutoUpdate";
			global::k parameter = new global::k(ab8(), aj.ay(), aj.a8());
			thread.Start(parameter);
		}
	}

	public void s6()
	{
		if (aj.bl())
		{
			Thread thread = new Thread((ParameterizedThreadStart)jd.a);
			thread.IsBackground = true;
			thread.Name = "MatFileDBUpdate";
			jd.a parameter = new jd.a(ab8(), aj.bb());
			thread.Start(parameter);
		}
	}

	protected void m2(gy A_0, hg A_1, hd A_2, g2 A_3, he A_4, bool A_5)
	{
		g7 g10 = null;
		Guid guid = new Guid(A_0.x());
		if (A_0.ad() == null)
		{
			ep obj = ae;
			bool A_6 = false;
			obj.e(A_3, ref A_6);
			cg a_ = af;
			A_6 = false;
			g7.m2(a_, A_3, ref A_6);
			g10 = new g7(ab8(), new Guid(A_0.x()), A_0.u(), A_1, A_2, al, A_3, A_4, A_5, ae, af, sj, z);
			if (uw(guid) != null)
			{
				g10.x1().d((global::r.d.b)qh);
			}
		}
		else
		{
			g10 = new g7(ab8(), guid, A_0.ad(), A_1, A_2, al, A_3, A_4, A_5);
		}
		if (g10.zm() == global::r.a.a)
		{
			t.Add(g10);
			return;
		}
		throw new Exception("Error Initializing Thread for Measurement Module '" + A_0.u() + "'");
	}

	protected d m2(hg.j A_0)
	{
		d result = d.a;
		string A_1 = "";
		try
		{
			foreach (gy item in ai.i())
			{
				if (item.t() == gu.a.a.a)
				{
					gx gx2 = null;
					foreach (gx item2 in ai.j())
					{
						if (item2.o.Contains(item.y()))
						{
							gx2 = item2;
							break;
						}
					}
					g7 g10 = null;
					if (gx2 != null)
					{
						foreach (Guid item3 in gx2.o)
						{
							g10 = so(item3.ToString());
							if (g10 != null)
							{
								break;
							}
						}
					}
					hg hg2;
					he he2;
					if (g10 != null)
					{
						hg2 = g10.zg();
						he2 = g10.zh();
					}
					else
					{
						hg2 = new hg(aj, A_0);
						hg.bu(hg2, A_0, item.z(), null, global::r.d.a.b.b, ab8(), g2.b.a, A_7: true, A_8: false);
						he2 = new he(string.Empty, hg2.c1(), string.Empty);
						he2.ad().Add(hg2);
					}
					if ((!aj.a8() && !aj.a3(null)) || item.ab() == null || !File.Exists(hg.bz() + item.ab()))
					{
						item.v(he.s());
						item.t(A_0: false);
					}
					if (!item.z() && item.ac())
					{
						if (!he2.s(hg.bz() + item.ab(), aj, hg2, hg.j.a, null, global::r.d.a.b.b, A_6: true, A_7: false, default(Point), null, g2.b.a, A_11: true, ab8()))
						{
							ab8().c(fz.b.b, "Problem reading in the Composite Recipe " + item.ab() + " or one of its referenced recipes.");
							item.v(he.s());
							item.t(A_0: false);
						}
						else
						{
							hg2.ca(A_0: true);
						}
					}
					else
					{
						if (item.ag() && item.w().m())
						{
							if (!e4.a(e4.aa() + item.af(), ref A_1))
							{
								ab8().c(fz.b.b, "Unable to Retrieve Recipe Data From Template");
								A_1 = hg.bz() + item.aa();
							}
							else
							{
								A_1 = hg.bz() + A_1;
							}
						}
						else
						{
							A_1 = hg.bz() + item.aa();
						}
						hg2.cc(A_1);
					}
					m2(item, hg2, ah, item.w(), he2, item.ac());
					item.t(hg2);
				}
				else
				{
					item.t();
					_ = 1;
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = d.b;
			ab8().c(fz.b.b, "Error creating measurement modules. ", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	protected void s8()
	{
		foreach (gx item in ai.j())
		{
			gx gx2 = item.ah();
			gx2.j(sj, sm, qh, sj, sm);
			u.Add(gx2);
		}
	}

	public void tb()
	{
		gz obj = ai;
		obj.i().Clear();
		obj.j().Clear();
		obj.k().Clear();
		obj.h();
		_ = null;
	}

	protected bool m2(Collection<f0> A_0, gy A_1)
	{
		foreach (f0 item in A_0)
		{
			if (item is ip)
			{
				ip ip2 = (ip)item;
				if (Operators.CompareString(ip2.yq(), A_1.ak()[0].n(), TextCompare: false) == 0 && ip2.u0())
				{
					return true;
				}
				ip2 = null;
			}
		}
		return false;
	}

	private void p9(d A_0, string A_1, Collection<d> A_2, Collection<string> A_3)
	{
		A_3.Add(A_1);
		A_2.Add(A_0);
	}

	private void m2(d A_0, string A_1, Collection<d> A_2, Collection<string> A_3)
	{
		Collection<string> collection;
		int index;
		(collection = A_3)[index = A_2.IndexOf(A_0)] = collection[index] + "\r\n" + A_1;
	}

	private string m2(global::h.f A_0, g7 A_1, h6.c A_2)
	{
		string result = string.Empty;
		if (A_1.vk())
		{
			result = " (" + global::h.b(A_0) + ")";
		}
		else if (A_2.bt > 0)
		{
			result = " (" + A_2.bt + ")";
		}
		return result;
	}

	public void m2(h6 A_0)
	{
		h6 h10 = A_0;
		if (h10.abk().HasLightSourceOnTimer != 0 && (h10.abk().HasLowPowerLightSource != 0 || h10.abk().HasHighPowerLightSource != 0))
		{
			h10.abk().ReadLightSourceOnTime(out var onTimeHrs, out var eventCount, out var eventCountRemaining, out var onTimeRemainingHrs);
			string text = ((!(onTimeRemainingHrs > 8760f)) ? (onTimeRemainingHrs.ToString("0.0", CultureInfo.InvariantCulture) + " hrs") : ((onTimeRemainingHrs / 8760f).ToString("0.0", CultureInfo.InvariantCulture) + " yrs"));
			ab8().c(fz.b.a, "Light Source On Timer is present: OnTime=" + onTimeHrs.ToString("0.000", CultureInfo.InvariantCulture) + " hrs, EventCount=" + eventCount + ", EventCountRemaining=" + eventCountRemaining + ", OnTimeRemaining=" + text);
		}
		h10 = null;
	}

	private bool m2(Collection<h6.c> A_0)
	{
		string text = null;
		foreach (h6.c item in A_0)
		{
			if (text == null)
			{
				text = item.a;
			}
			else if (Operators.CompareString(item.a, text, TextCompare: false) != 0)
			{
				return false;
			}
		}
		return true;
	}

	public Collection<d> m2(ref Collection<f0> A_0, gt A_1, hg.j A_2, ref Collection<string> A_3, ref bool A_4, global::r.c A_5)
	{
		Collection<d> collection = new Collection<d>();
		g7 A_6 = null;
		string text = null;
		Collection<g7> collection2 = new Collection<g7>();
		bool flag = false;
		b0 b10 = null;
		Collection<h5> collection3 = new Collection<h5>();
		collection3.Add(null);
		collection3.Add(null);
		collection3.Add(null);
		checked
		{
			try
			{
				if (ai == null && z0() != global::r.a.a)
				{
					text = "Error in MeasModuleMgr when calling MyBase.InitThreading";
					p9(d.c, text, collection, A_3);
					ab8().c(fz.b.b, text);
					return collection;
				}
				if (t != null && t.Count > 0)
				{
					foreach (g7 item2 in t)
					{
						item2.i(A_0: false);
					}
					t.Clear();
					if (d4.a(null).Count > 0)
					{
						d4.y();
					}
				}
				am = float.MaxValue;
				an = 0f;
				m2(A_0, A_1, ref aj);
				if (uw().a8())
				{
					gf.a();
				}
				string text2 = string.Empty;
				foreach (f0 item3 in A_0)
				{
					switch (item3.ab4())
					{
					case f0.a.c:
					{
						ip ip2 = (ip)item3;
						ab8().c(fz.b.a, "Detected system " + ip2.abk().FWInstTypeCodeAsEnum.ToString() + " with serial number=" + ip2.abk().FriendlySN + ", GUID=" + ip2.abk().SerialNumber + " with spectrometer type " + ip2.xs().ToString() + ", HWRev=" + ip2.xt() + ", S/N=" + ip2.uq() + ", GUID=" + ip2.yq() + ", Channel #" + (ip2.ut() + 1));
						m2((h6)item3);
						Collection<ia> A_7 = null;
						int num = ip2.m2(ref A_7);
						if (num != 0)
						{
							ab8().c(fz.b.b, "Error reading memory block headers. Error is " + num);
						}
						foreach (ia item4 in A_7)
						{
							string a_ = "Memory Block: " + ia.h(item4, A_1: false);
							ab8().c(fz.b.a, a_);
							if (item4.a != h8.c || af.f(item4.b) != null)
							{
								continue;
							}
							byte[] array = new byte[item4.d - 1 + 1];
							num = ip2.p9((short)item4.d, (short)item4.e, array);
							ic ic2 = new ic();
							string A_8 = null;
							if (ic2.b(array, ref A_8) == h7.a)
							{
								cf cf2 = ic2.b(item4.b, item4.c);
								string text3 = i3.o() + cf.l();
								try
								{
									cf2.n(text3 + cf2.m());
									a_ = "CTM Cal file \"" + cf2.m() + "\" was missing and has been restored from memory.";
									ab8().c(fz.b.a, a_);
									flag = true;
								}
								catch (Exception ex2)
								{
									ProjectData.SetProjectError(ex2);
									Exception a_2 = ex2;
									ab8().c(fz.b.b, "Exception Caught While Writing CTM File", a_2);
									ProjectData.ClearProjectError();
								}
							}
							else
							{
								if (string.IsNullOrEmpty(text2))
								{
									text2 = "One or more of the CTM calibration firmware blocks is not compatible with the current software version. To read this calibration block, you will need to upgrade to a later version of software. \r\n";
								}
								text2 = text2 + "\r\nCTM Cal file \"" + item4.b + "\" cannot be read from firmware. " + A_8;
							}
						}
						ip2 = null;
						break;
					}
					case f0.a.g:
						b10 = (b0)item3;
						break;
					case f0.a.b:
						m2((h6)item3);
						break;
					case f0.a.f:
					{
						@in obj = (@in)item3;
						ab8().c(fz.b.a, "Detected system " + obj.abk().FWInstTypeCodeAsEnum.ToString() + " with serial number=" + obj.abk().FriendlySN + ", GUID=" + obj.abk().SerialNumber + " with Photodiode/LED , S/N=" + obj.td() + ", GUID=" + obj.yq());
						obj = null;
						break;
					}
					}
				}
				if (flag)
				{
					string A_9 = null;
					af.f(ab8(), ref A_9);
					if (!string.IsNullOrEmpty(A_9))
					{
						text2 = ((!string.IsNullOrEmpty(text2)) ? (text2 + "\r\n\r\n" + A_9) : A_9);
					}
				}
				if (!string.IsNullOrEmpty(text2))
				{
					ab8().c(fz.b.a, text2);
					p9(d.j, text2, collection, A_3);
				}
				if (ai == null)
				{
					ai = new gz(ab8(), A_1: true);
				}
				Collection<gy> collection4 = new Collection<gy>();
				Collection<gx> collection5 = new Collection<gx>();
				if (A_0.Count > 0)
				{
					int num2 = ai.i().Count - 1;
					if (num2 >= 0)
					{
						_ = new bool[num2 + 1];
						Collection<gy> collection6 = new Collection<gy>();
						int num3 = num2;
						bool flag3 = default(bool);
						bool flag5 = default(bool);
						for (int num4 = 0; num4 <= num3; num4++)
						{
							gy gy2 = ai.i()[num4];
							gy gy3 = gy2;
							bool flag2 = false;
							foreach (ip.a item5 in gy3.ak())
							{
								foreach (f0 item6 in A_0)
								{
									if (item6 is ip)
									{
										ip ip3 = (ip)item6;
										if (Operators.CompareString(ip3.yq(), item5.n(), TextCompare: false) == 0 && (string.IsNullOrEmpty(gy3.v()) == string.IsNullOrEmpty(ip3.ux()) || Operators.CompareString(gy3.v(), ip3.ux(), TextCompare: false) == 0))
										{
											flag2 = true;
											break;
										}
									}
								}
								if (flag2)
								{
									break;
								}
							}
							foreach (h5.a item7 in gy3.ai())
							{
								foreach (f0 item8 in A_0)
								{
									if (item8 is h5 && Operators.CompareString(((h5)item8).abk().SerialNumber, item7.f(), TextCompare: false) == 0)
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
							bool flag4 = false;
							if (gy3.aj() != null)
							{
								foreach (@in.a item9 in gy3.aj())
								{
									foreach (f0 item10 in A_0)
									{
										if (item10 is @in && Operators.CompareString(((@in)item10).yq(), item9.k(), TextCompare: false) == 0)
										{
											flag4 = true;
											break;
										}
									}
								}
							}
							if (flag2 || flag5 || flag3 || flag4)
							{
								foreach (ip.a item11 in gy3.ak())
								{
									bool flag6 = false;
									foreach (f0 item12 in A_0)
									{
										if (item12 is ip)
										{
											ip a_3 = (ip)item12;
											bool A_10 = false;
											if (gz.f(item11, a_3, ref A_10))
											{
												flag6 = true;
												break;
											}
										}
									}
									if (!flag6)
									{
										collection6.Add(gy2);
										break;
									}
								}
								if (!collection6.Contains(gy2))
								{
									foreach (@in.a item13 in gy3.aj())
									{
										bool flag6 = false;
										foreach (f0 item14 in A_0)
										{
											if (item14 is @in && Operators.CompareString(((@in)item14).yq(), item13.k(), TextCompare: false) == 0)
											{
												flag6 = true;
												break;
											}
										}
										if (!flag6)
										{
											collection6.Add(gy2);
											break;
										}
									}
								}
								if (!collection6.Contains(gy2))
								{
									foreach (h5.a item15 in gy3.ai())
									{
										bool flag6 = false;
										foreach (f0 item16 in A_0)
										{
											if (item16 is h5 && Operators.CompareString(((h5)item16).abk().SerialNumber, item15.f(), TextCompare: false) == 0)
											{
												flag6 = true;
												break;
											}
										}
										if (!flag6)
										{
											collection6.Add(gy2);
											break;
										}
									}
								}
								if (gy3.ai().Count > 0 && !collection6.Contains(gy2))
								{
									foreach (h5.a item17 in gy3.ai())
									{
										bool flag7 = h6.m2(item17.g());
										if (flag7 && gy3.ak().Count == 0)
										{
											collection6.Add(gy2);
											break;
										}
										if (!flag7)
										{
											collection6.Add(gy2);
											break;
										}
									}
								}
							}
							else
							{
								collection4.Add(gy2);
							}
							gy3 = null;
						}
						foreach (gy item18 in collection6)
						{
							ai.i().Remove(item18);
						}
						foreach (gy item19 in collection4)
						{
							ai.i().Remove(item19);
						}
					}
					int num5 = ai.j().Count - 1;
					if (num5 >= 0)
					{
						Collection<gx> collection7 = new Collection<gx>();
						int num6 = num5;
						for (int num7 = 0; num7 <= num6; num7++)
						{
							gx gx2 = ai.j()[num7];
							bool flag8 = false;
							gx gx3 = gx2;
							foreach (Guid item20 in gx3.o)
							{
								foreach (gy item21 in ai.i())
								{
									if (item21.y() == item20)
									{
										flag8 = m2(A_0, item21);
										if (flag8)
										{
											break;
										}
									}
								}
								if (flag8)
								{
									break;
								}
							}
							if (flag8)
							{
								foreach (Guid item22 in gx3.o)
								{
									bool flag9 = false;
									foreach (gy item23 in ai.i())
									{
										if (item23.y() == item22)
										{
											flag9 = m2(A_0, item23);
											if (flag9)
											{
												break;
											}
										}
									}
									if (!flag9)
									{
										collection7.Add(gx2);
										break;
									}
								}
							}
							else
							{
								collection5.Add(gx2);
							}
							gx3 = null;
						}
						foreach (gx item24 in collection7)
						{
							ai.j().Remove(item24);
						}
						foreach (gx item25 in collection5)
						{
							ai.j().Remove(item25);
						}
					}
				}
				s8();
				Collection<string> A_11 = null;
				bool A_12 = default(bool);
				bool A_13 = default(bool);
				m2(A_0, ref A_11, ref A_12, ref A_13);
				bool flag10 = A_11.Count == 1 && !A_12 && !A_13;
				int num9 = default(int);
				for (int num8 = A_0.Count - 2; num9 <= num8; num9++)
				{
					f0 f10 = A_0[num9];
					if (f10.ab4() == f0.a.b)
					{
						A_0.Add(f10);
						A_0.RemoveAt(num9);
						num8--;
					}
				}
				d d10 = d.a;
				bool A_14;
				bool A_16 = default(bool);
				do
				{
					A_14 = false;
					if (m2(A_2) != d.a)
					{
						throw new Exception("Error Creating Measurement Module Manager!");
					}
					foreach (gx item26 in u)
					{
						if (item26.r != null)
						{
							item26.r = null;
						}
					}
					if (A_0.Count > 0)
					{
						foreach (f0 item27 in A_0)
						{
							switch (item27.ab4())
							{
							case f0.a.c:
							{
								ip ip4 = (ip)item27;
								d10 = m2(ip4, A_2, ref A_6, ref A_14);
								if (A_14)
								{
									goto IL_15b5;
								}
								switch (d10)
								{
								case d.a:
									m2(A_6, A_2, ref A_16);
									if (am > ip4.vu())
									{
										am = ip4.vu();
									}
									if (an < ip4.vv())
									{
										an = ip4.vv();
									}
									goto end_IL_0de2;
								case d.f:
									d10 = d.a;
									goto end_IL_0de2;
								default:
									d10 = d.c;
									break;
								}
								goto end_IL_0f98;
							}
							case f0.a.b:
							{
								h5 h10 = (h5)item27;
								if (flag10 && Operators.CompareString(h10.abo(), A_11[0] + "ScattCal_1", TextCompare: false) == 0)
								{
									collection3[0] = h10;
									break;
								}
								if (flag10 && Operators.CompareString(h10.abo(), A_11[0] + "ScattCal_2", TextCompare: false) == 0)
								{
									collection3[1] = h10;
									break;
								}
								if (flag10 && Operators.CompareString(h10.abo(), A_11[0] + "ScattCal_3", TextCompare: false) == 0)
								{
									collection3[2] = h10;
									break;
								}
								d10 = m2(h10, hg.j.a);
								switch (d10)
								{
								case d.g:
									d10 = d.a;
									break;
								default:
									d10 = d.c;
									goto end_IL_0f98;
								case d.a:
									break;
								}
								break;
							}
							case f0.a.f:
							{
								g7 A_15 = null;
								d10 = m2((@in)item27, ref A_15);
								m2(A_15, A_2, ref A_16);
								break;
							}
							case f0.a.e:
								{
									d10 = d.c;
									ab8().c(fz.a.b, "DeviceNotSupportedFmt2", item27.ab5(), ((h6)item27).abp());
									break;
								}
								end_IL_0de2:
								break;
							}
							continue;
							end_IL_0f98:
							break;
						}
						Collection<g7> collection8 = new Collection<g7>();
						foreach (g7 item28 in t)
						{
							bool flag11 = false;
							foreach (f0 item29 in A_0)
							{
								switch (item29.ab4())
								{
								case f0.a.c:
									if (!ai.f((ip)item29, item28))
									{
										break;
									}
									flag11 = true;
									goto end_IL_10e1;
								case f0.a.f:
									if (!ai.f((@in)item29, item28))
									{
										break;
									}
									flag11 = true;
									goto end_IL_10e1;
								case f0.a.b:
								{
									h5 h11 = (h5)item29;
									if (ai.f(h11, item28) && (!flag10 || (Operators.CompareString(h11.abo(), A_11[0] + "ScattCal_1", TextCompare: false) != 0 && Operators.CompareString(h11.abo(), A_11[0] + "ScattCal_2", TextCompare: false) != 0 && Operators.CompareString(h11.abo(), A_11[0] + "ScattCal_3", TextCompare: false) != 0)))
									{
										flag11 = true;
										goto end_IL_10e1;
									}
									break;
								}
								}
								continue;
								end_IL_10e1:
								break;
							}
							if (!flag11)
							{
								collection8.Add(item28);
							}
						}
						foreach (g7 item30 in collection8)
						{
							t.Remove(item30);
							if (item30.i(A_0: false) != global::r.a.a)
							{
								ab8().c(fz.b.b, "Error shutting-down measurement module thread (" + item30.zl() + ") after hardware update.");
							}
						}
						for (int num10 = u.Count - 1; num10 >= 0; num10 += -1)
						{
							Collection<Guid> collection9 = u[num10].o;
							for (int num11 = collection9.Count - 1; num11 >= 0; num11 += -1)
							{
								if (so(collection9[num11].ToString()) == null)
								{
									collection9.RemoveAt(num11);
									u[num10].r = null;
								}
							}
							collection9 = null;
							gx gx4 = u[num10];
							if (gx4.o.Count == 0)
							{
								gx4.ak();
								u.RemoveAt(num10);
							}
							gx4 = null;
						}
						foreach (gx item31 in u)
						{
							Collection<Guid> collection10 = item31.o;
							int num12 = collection10.Count - 1;
							bool flag12 = true;
							int num13 = num12;
							for (int num14 = 0; num14 <= num13; num14++)
							{
								if (!string.IsNullOrEmpty(uz(collection10[num14]).zl()))
								{
									flag12 = false;
									break;
								}
							}
							if (flag12)
							{
								string[] array2 = new string[num12 + 1];
								int num15 = num12;
								for (int num16 = 0; num16 <= num15; num16++)
								{
									array2[num16] = item31.p[num16].ToString("000") + "_" + uz(collection10[num16]).qh(h6.b.b, 0, 0).ToString("000");
								}
								int num17 = num12 - 1;
								for (int num18 = 0; num18 <= num17; num18++)
								{
									int num19 = num12 - 1;
									int num20 = num18;
									for (int num21 = num19; num21 >= num20; num21 += -1)
									{
										if (Operators.CompareString(array2[num21], array2[num21 + 1], TextCompare: false) > 0)
										{
											string text4 = array2[num21 + 1];
											array2[num21 + 1] = array2[num21];
											array2[num21] = text4;
											Guid value = collection10[num21 + 1];
											collection10[num21 + 1] = collection10[num21];
											collection10[num21] = value;
										}
									}
								}
							}
							int num22 = num12;
							for (int num23 = 0; num23 <= num22; num23++)
							{
								g7 g10 = st(collection10[num23].ToString());
								if (string.IsNullOrEmpty(g10.zl()))
								{
									g7 obj2 = g10;
									string A_17 = "ChannelNameFmt";
									obj2.sm(string.Format(hu.a(ref A_17), g10.vb().ToString()));
								}
								g10 = null;
							}
							collection10 = null;
						}
						int num24 = 0;
						new Collection<g7>();
						int num25 = u.Count - 1;
						for (int num26 = 0; num26 <= num25; num26++)
						{
							Collection<Guid> collection11 = u[num26].o;
							int num27 = collection11.Count - 1;
							for (int num28 = 0; num28 <= num27; num28++)
							{
								Guid guid = collection11[num28];
								int num29 = num24;
								int num30 = t.Count - 1;
								for (int num31 = num29; num31 <= num30; num31++)
								{
									g7 g11 = t[num31];
									if (g11.zk() == guid)
									{
										t.Remove(g11);
										t.Insert(num24, g11);
										num24++;
										break;
									}
								}
							}
							collection11 = null;
						}
					}
					else if (A_1 == null)
					{
						d10 = d.c;
						ab8().c(fz.a.a, "HardwareNotConnected");
					}
					else
					{
						d10 = m2(A_1, A_2, ref A_6);
						am = A_6.zd();
						an = A_6.ze();
						if (d10 == d.a)
						{
							m2(A_6, A_2, ref A_16);
						}
					}
					int num32 = 0;
					foreach (gy item32 in collection4)
					{
						if (num32 < 20)
						{
							ai.i().Add(item32);
							num32++;
						}
					}
					IL_15b5:;
				}
				while (A_14);
				if (d10 != d.a)
				{
					p9(d10, string.Empty, collection, A_3);
				}
				if (A_16)
				{
					p9(d.i, string.Empty, collection, A_3);
				}
				foreach (gx item33 in collection5)
				{
					ai.j().Add(item33);
				}
				foreach (g7 item34 in t)
				{
					if (gt.ad(item34.zc(), A_1))
					{
						collection2.Add(item34);
					}
				}
				foreach (g7 item35 in collection2)
				{
					t.Remove(item35);
					item35.i(A_0: false);
				}
				foreach (g7 item36 in t)
				{
					item36.wl();
					item36.lz = true;
					if (item36.y2() && item36.y4())
					{
						item36.m2(new g6(global::e.a().WavelenCalEnable, unchecked((g6.a)global::e.a().WavelenCalMode), global::e.a().WavelenCalPeriodMinutes), global::r.d.a.b.b);
					}
					else if (!item36.y3())
					{
						item36.m2(new g6(A_0: false, g6.a.c, 0f), global::r.d.a.b.b);
					}
				}
				d10 = d.a;
				if (flag10)
				{
					if (t.Count == 1)
					{
						if (b10 == null)
						{
							p9(d.s, "A scatter calibration module was detected but the mux motor initialization failed", collection, A_3);
						}
						else
						{
							t[0].m2(collection3, A_11[0], b10);
						}
					}
					else
					{
						d10 = d.l;
					}
				}
				else if (A_11.Count > 1)
				{
					d10 = d.o;
				}
				else if (A_12)
				{
					d10 = d.m;
				}
				else if (A_13)
				{
					d10 = d.n;
				}
				if (d10 != d.a)
				{
					p9(d10, string.Empty, collection, A_3);
				}
				text = null;
				Collection<string> collection12 = new Collection<string>();
				Collection<int> collection13 = new Collection<int>();
				Collection<int> collection14 = new Collection<int>();
				Collection<bool> collection15 = new Collection<bool>();
				List<List<int>> list = new List<List<int>>();
				foreach (g7 item37 in t)
				{
					g7 g12 = item37;
					if (g12.vo() != null && g12.vo().Length > global::h.a())
					{
						int num33 = global::h.a();
						for (int num34 = 0; num34 <= num33; num34++)
						{
							global::h.f a_4 = unchecked((global::h.f)num34);
							if (!g12.vo()[num34])
							{
								continue;
							}
							Collection<h6.c> collection16 = g12.m2(g12.p9(a_4), A_1: false, A_2: true, A_3: false);
							string text5 = collection16[0].a;
							int num35 = collection12.IndexOf(text5);
							List<int> list2;
							if (num35 < 0)
							{
								collection12.Add(text5);
								list2 = new List<int>();
								list.Add(list2);
								collection13.Add(1);
								collection14.Add(collection16[0].bu);
								collection15.Add(collection16[0].b1);
							}
							else
							{
								collection13[num35]++;
								list2 = list[num35];
							}
							int item = g12.vb();
							if (!list2.Contains(item))
							{
								list2.Add(item);
							}
							if (collection16.Count != collection16[0].bv && (collection16.Count < collection16[0].bv || m2(collection16)) && collection16[0].b1)
							{
								string text6 = m2(a_4, item37, collection16[0]);
								text = "SN" + text5 + text6 + ": Found " + Conversions.ToString(collection16.Count) + " spectrometer(s). Expected " + Conversions.ToString(collection16[0].bv) + " spectrometer(s).";
								ab8().c(fz.b.b, text);
								if (collection.Contains(d.r))
								{
									m2(d.r, text, collection, A_3);
								}
								else
								{
									p9(d.r, text, collection, A_3);
								}
							}
							if (collection16.Count == 2 && m2(collection16) && h6.c.dg(collection16[0], collection16[1], ref text))
							{
								string text7 = m2(a_4, item37, collection16[0]);
								string a_5 = "SN" + text5 + text7 + ": " + text;
								ab8().c(fz.b.b, a_5);
								if (collection.Contains(d.p))
								{
									m2(d.p, a_5, collection, A_3);
								}
								else
								{
									p9(d.p, a_5, collection, A_3);
								}
							}
						}
					}
					g12 = null;
				}
				text = null;
				int num36 = collection12.Count - 1;
				for (int num37 = 0; num37 <= num36; num37++)
				{
					if (collection13[num37] == collection14[num37] || !collection15[num37])
					{
						continue;
					}
					text = "SN" + collection12[num37] + ": Found " + collection13[num37] + " submodule(s). Expected " + collection14[num37] + " submodule(s).";
					string text8 = null;
					foreach (int item38 in list[num37])
					{
						text8 = ((!string.IsNullOrEmpty(text8)) ? (text8 + ", " + item38) : item38.ToString());
					}
					text = text + " List of found channel numbers: " + text8;
					ab8().c(fz.b.a, text);
					if (collection.Contains(d.q))
					{
						m2(d.q, text, collection, A_3);
					}
					else
					{
						p9(d.q, text, collection, A_3);
					}
				}
				foreach (gx item39 in u)
				{
					item39.af();
				}
				text = null;
				foreach (g7 item40 in t)
				{
					item40.xj();
					if (item40.xi() != gu.ErrPublic.None)
					{
						A_3.Add(string.Empty);
						text = item40.vc() + ": R and T Autobaseline task loop failed at startup.";
						if (collection.Contains(d.k))
						{
							m2(d.k, text, collection, A_3);
						}
						else
						{
							p9(d.k, text, collection, A_3);
						}
					}
				}
				s6();
			}
			catch (ThreadAbortException ex3)
			{
				ProjectData.SetProjectError(ex3);
				ThreadAbortException ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception a_6 = ex5;
				if (collection.Count == 0)
				{
					p9(d.b, string.Empty, collection, A_3);
				}
				ab8().c(fz.b.b, "Exception caught in MeasModuleMgr.Init. ", a_6);
				ProjectData.ClearProjectError();
			}
			return collection;
		}
	}

	private void m2(string A_0, ref string A_1, ref bool A_2, ref bool A_3, ref bool A_4)
	{
		A_2 = A_0.EndsWith("ScattCal_1");
		A_3 = A_0.EndsWith("ScattCal_2");
		A_4 = A_0.EndsWith("ScattCal_3");
		A_1 = null;
		checked
		{
			if (A_2)
			{
				A_1 = A_0.Substring(0, A_0.Length - "ScattCal_1".Length);
			}
			else if (A_3)
			{
				A_1 = A_0.Substring(0, A_0.Length - "ScattCal_2".Length);
			}
			else if (A_4)
			{
				A_1 = A_0.Substring(0, A_0.Length - "ScattCal_3".Length);
			}
		}
	}

	private void m2(Collection<f0> A_0, ref Collection<string> A_1, ref bool A_2, ref bool A_3)
	{
		Collection<string> collection = new Collection<string>();
		bool[] array = new bool[0];
		bool[] array2 = new bool[0];
		bool[] array3 = new bool[0];
		int[] array4 = new int[0];
		checked
		{
			if (A_0.Count > 0)
			{
				bool A_5 = default(bool);
				bool A_6 = default(bool);
				bool A_7 = default(bool);
				foreach (f0 item in A_0)
				{
					if (item.ab4() != f0.a.b)
					{
						continue;
					}
					h5 h10 = (h5)item;
					string A_4 = null;
					m2(h10.abo(), ref A_4, ref A_5, ref A_6, ref A_7);
					if (A_5)
					{
						if (!collection.Contains(A_4))
						{
							collection.Add(A_4);
							if (array.Length < collection.Count)
							{
								array = (bool[])Utils.CopyArray(array, new bool[collection.Count - 1 + 1]);
								array2 = (bool[])Utils.CopyArray(array2, new bool[collection.Count - 1 + 1]);
								array3 = (bool[])Utils.CopyArray(array3, new bool[collection.Count - 1 + 1]);
								array4 = (int[])Utils.CopyArray(array4, new int[collection.Count - 1 + 1]);
							}
						}
						array[collection.IndexOf(A_4)] = true;
						array4[collection.IndexOf(A_4)]++;
					}
					else if (A_6)
					{
						if (!collection.Contains(A_4))
						{
							collection.Add(A_4);
							if (array2.Length < collection.Count)
							{
								array = (bool[])Utils.CopyArray(array, new bool[collection.Count - 1 + 1]);
								array2 = (bool[])Utils.CopyArray(array2, new bool[collection.Count - 1 + 1]);
								array3 = (bool[])Utils.CopyArray(array3, new bool[collection.Count - 1 + 1]);
								array4 = (int[])Utils.CopyArray(array4, new int[collection.Count - 1 + 1]);
							}
						}
						array2[collection.IndexOf(A_4)] = true;
						array4[collection.IndexOf(A_4)]++;
					}
					else
					{
						if (!A_7)
						{
							continue;
						}
						if (!collection.Contains(A_4))
						{
							collection.Add(A_4);
							if (array3.Length < collection.Count)
							{
								array = (bool[])Utils.CopyArray(array, new bool[collection.Count - 1 + 1]);
								array2 = (bool[])Utils.CopyArray(array2, new bool[collection.Count - 1 + 1]);
								array3 = (bool[])Utils.CopyArray(array3, new bool[collection.Count - 1 + 1]);
								array4 = (int[])Utils.CopyArray(array4, new int[collection.Count - 1 + 1]);
							}
						}
						array3[collection.IndexOf(A_4)] = true;
						array4[collection.IndexOf(A_4)]++;
					}
				}
			}
			A_1 = new Collection<string>();
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (array[num2] && array2[num2] && array3[num2])
				{
					if (array4[num2] == 3)
					{
						A_1.Add(collection[num2]);
					}
					else if (array4[num2] > 3)
					{
						A_3 = true;
					}
					else
					{
						A_2 = true;
					}
				}
				else
				{
					A_2 = true;
				}
			}
		}
	}

	private void m2(g7 A_0, hg.j A_1, ref bool A_2)
	{
		Guid a_ = A_0.zk();
		hg A_3 = A_0.zg();
		bool a_2 = sj((eo.a)null) && (A_3.b5() || (!sn((eo.a)null) && !aj.av(null) && !th()));
		hg hg2;
		string A_4 = (hg2 = A_3).c1();
		bool num = hg.bu(ref A_3, ref A_4, A_1, a_2, sn(), global::r.d.a.b.b, ab8(), A_7: false, default(Point), null, wy(a_), !xb(a_), null, A_3.ei());
		hg2.cc(A_4);
		if (!num)
		{
			ab8().c(fz.b.b, "Error loading recipe - using default");
		}
		else if (!aq.WaitOne(2000, exitContext: false))
		{
			A_2 = true;
		}
	}

	protected void m2(ref bool A_0, string A_1, string[] A_2, i7.e A_3)
	{
		if (!A_0)
		{
			return;
		}
		if (i7.c(A_1, A_2, A_3))
		{
			int A_4 = default(int);
			int A_5 = default(int);
			string left = i7.c(A_2, A_3, ref A_4, ref A_5);
			string right = i7.c(A_2[A_4], A_5);
			if (Operators.CompareString(left, right, TextCompare: false) != 0)
			{
				A_0 = false;
			}
		}
		else
		{
			A_0 = false;
		}
	}

	protected void m2(Collection<f0> A_0, gt A_1, ref eo A_2)
	{
		string[] A_3 = null;
		string[] A_4 = null;
		bool flag = false;
		string[] A_5 = null;
		bool flag2 = false;
		string[] A_6 = null;
		bool flag3 = false;
		string[] A_7 = null;
		bool flag4 = false;
		string[] A_8 = null;
		eo.a a10 = new eo.a();
		a10.p = i7.e();
		a10.i = a2.a.c(a10.p, i7.e.g, ref a10.k, ref A_3);
		bool A_9 = a2.a.c(a10.p, i7.e.s, ref a10.q, ref A_4);
		flag = a2.a.c(a10.p, i7.e.t, ref A_5);
		flag2 = a2.a.c(a10.p, i7.e.x, ref A_6);
		flag3 = a2.a.c(a10.p, i7.e.ar, ref A_7);
		flag4 = a2.a.c(a10.p, i7.e.av, ref A_8);
		if (A_0.Count > 0)
		{
			a10.l = true;
			foreach (f0 item in A_0)
			{
				switch (item.ab4())
				{
				case f0.a.c:
				{
					ip ip2 = (ip)item;
					a10.a = a10.a || ip2.zg();
					a10.b = a10.b || ip2.zb();
					a10.c = a10.c || ip2.zc();
					a10.d = a10.d || ip2.yv();
					a10.z = a10.z || ip2.yw();
					a10.af = a10.af || ip2.yx();
					a10.aa = a10.aa || ip2.yy();
					ab8().c(fz.b.b, "PermitThicknessMeas state=" + a10.d.ToString(CultureInfo.InvariantCulture));
					a10.e = a10.e || ip2.zi();
					a10.f = a10.f || ip2.aaz();
					a10.t = ip2.aa0();
					a10.s = ip2.aa6();
					if (a10.h < ip2.aa8())
					{
						a10.h = ip2.aa8();
					}
					a10.g = a10.g || ip2.aba();
					a10.ad = a10.ad || ip2.zk();
					a10.ah = a10.ah || ip2.zx();
					a10.ae = a10.ae || ip2.aa2();
					a10.ai = a10.ai || ip2.aa4();
					a10.aj = a10.aj || ip2.aa5();
					ip2 = null;
					break;
				}
				case f0.a.b:
					a10.h = 100000000f;
					break;
				}
			}
			m2(ref a10.i, a10.p, A_3, i7.e.g);
			m2(ref A_9, a10.p, A_4, i7.e.s);
			m2(ref flag, a10.p, A_5, i7.e.t);
			m2(ref flag2, a10.p, A_6, i7.e.x);
			m2(ref flag3, a10.p, A_7, i7.e.ar);
			m2(ref flag4, a10.p, A_8, i7.e.av);
		}
		else if (A_1 != null)
		{
			gt gt2 = A_1;
			a10.a = gt2.ai();
			a10.b = gt2.ap() || gt2.aq();
			a10.c = gt2.aq();
			a10.d = gt2.at();
			a10.z = gt2.au();
			a10.aa = gt2.av();
			a10.e = gt2.af();
			a10.f = gt2.ag();
			a10.h = 100000000f;
			a10.l = gt2.aw();
			a10.g = gt2.ae();
			a10.t = gt2.ak();
			a10.s = gt2.al();
			a10.ad = gt2.ay();
			a10.ah = gt2.az();
			a10.ae = gt2.a0();
			a10.ai = gt2.a1();
			a10.aj = gt2.a2();
			gt2 = null;
		}
		a10.m = a2.a.c(a10.p, "SaSwSn", i7.e.o);
		if (a10.m)
		{
			if (string.IsNullOrEmpty(global::e.a().TechSupportFilesRootPath))
			{
				global::e.a().TechSupportFilesRootPath = global::c.e().FileSystem.SpecialDirectories.MyDocuments + "\\FI Tech Support";
				try
				{
					if (!Directory.Exists(global::e.a().TechSupportFilesRootPath))
					{
						Directory.CreateDirectory(global::e.a().TechSupportFilesRootPath);
					}
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex3 = ex2;
					ab8().c(fz.b.b, "Error attempting to create folder for importing tech support files");
					ProjectData.ClearProjectError();
				}
			}
			if (string.IsNullOrEmpty(global::e.a().TechSupportRecipesRootPath))
			{
				global::e.a().TechSupportRecipesRootPath = hg.b0() + "Tech Support";
				try
				{
					if (!Directory.Exists(hg.bz()))
					{
						Directory.CreateDirectory(hg.bz());
					}
					if (!Directory.Exists(global::e.a().TechSupportRecipesRootPath))
					{
						Directory.CreateDirectory(global::e.a().TechSupportRecipesRootPath);
					}
				}
				catch (Exception ex4)
				{
					ProjectData.SetProjectError(ex4);
					Exception ex5 = ex4;
					ab8().c(fz.b.b, "Error attempting to create folder for importing tech support files");
					ProjectData.ClearProjectError();
				}
			}
		}
		int A_10 = default(int);
		a10.n = a2.a.c(a10.p, "SaSwSn", i7.e.p, ref A_10);
		a10.s = a10.s || a2.a.c(a10.p, "SaSwSn", i7.e.u);
		a10.t = a10.t || a2.a.c(a10.p, "SaSwSn", i7.e.v);
		a10.v = a2.a.k();
		a10.w = a2.a.c(a10.p, "SaSwSn", i7.e.aa);
		a10.j = a10.i && a2.a.c(a10.p, "SaSwSn", i7.e.ag);
		if (!a10.a || !a10.d)
		{
			bool flag5 = a10.i && a2.a.c(a10.p, "SaSwSn", i7.e.be);
			a10.a = a10.a || flag5;
			a10.d = a10.d || flag5;
		}
		a10.x = a10.x || a2.a.c(a10.p, "SaSwSn", i7.e.ai);
		a10.y = a10.y || a10.i || a2.a.e(i7.e.aj);
		a10.al = a10.al || a2.a.e(i7.e.bj);
		a10.am = a10.i && (a10.am || a2.a.e(i7.e.bk));
		a10.ab = a2.a.e(i7.e.ao);
		a10.ac = a2.a.e(i7.e.aq);
		a10.ad = a10.ad || a2.a.c(a10.p, "SaSwSn", i7.e.ar);
		a10.o = (AutoUpdateLicenseDetails.AutoUpdateLevel)A_10;
		if (!A_9)
		{
			a10.q = string.Empty;
		}
		a10.ai = a10.ai || a2.a.e(i7.e.bc);
		flag2 = flag2 || (a10.i && !string.IsNullOrEmpty(a10.k));
		if (flag2)
		{
			jb.j();
		}
		a10.u = flag2;
		a10.r = flag;
		if (!a10.ad)
		{
			a10.ad = flag3;
		}
		if (!a10.aj)
		{
			a10.aj = a10.i && a2.a.c(i7.e.bd, A_1: true);
		}
		a10.ak = a2.a.c(a10.p, "SaSwSn", i7.e.bi);
		if (a10.i)
		{
			string text = a2.a.bg(26);
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			m2(i7.e.z, a10.v, text, A_3: true, ref a10.v);
			bool a_ = a10.ab;
			bool A_11 = false;
			m2(i7.e.ao, a_, text, A_3: false, ref A_11);
			bool a_2 = a10.ac;
			A_11 = false;
			m2(i7.e.aq, a_2, text, A_3: false, ref A_11);
			bool a_3 = a2.a.e(i7.e.au);
			A_11 = false;
			m2(i7.e.au, a_3, text, A_3: false, ref A_11);
			bool a_4 = a10.ai;
			A_11 = false;
			m2(i7.e.bc, a_4, text, A_3: false, ref A_11);
			bool a_5 = a10.aj;
			A_11 = false;
			m2(i7.e.bd, a_5, text, A_3: false, ref A_11);
			A_11 = false;
			m2(i7.e.be, A_1: false, text, A_3: false, ref A_11);
			A_11 = false;
			m2(i7.e.al, A_1: false, text, A_3: false, ref A_11);
			m2(i7.e.bj, A_1: false, text, A_3: true, ref a10.al);
			m2(i7.e.bk, A_1: false, text, A_3: false, ref a10.am);
		}
		A_2.at(a10);
		if (!A_9)
		{
			A_2.ax();
		}
		ak = true;
	}

	private void m2(i7.e A_0, bool A_1, string A_2, bool A_3, ref bool A_4)
	{
		if (A_1)
		{
			return;
		}
		string text = a2.a.br((int)A_0);
		string path = A_2 + text + a2.a.b1();
		string path2 = A_2 + text + "_off" + a2.a.b1();
		if (!File.Exists(path) && !File.Exists(path2))
		{
			if (A_3)
			{
				File.WriteAllText(path, string.Empty);
			}
			else
			{
				File.WriteAllText(path2, string.Empty);
			}
			A_4 = A_3;
		}
	}

	protected void m2(hg A_0)
	{
		hg hg2 = A_0;
		if (Operators.CompareString(Path.GetExtension(hg2.c1()), ".rpe", TextCompare: false) == 0)
		{
			hg2.cc(hg2.c1().Substring(0, checked(hg2.c1().Length - ".rpe".Length)) + ".fitrp");
		}
		if (hg2.ch(hg2.c1()) != 0)
		{
			Interaction.MsgBox(" Failed to save " + Strings.LCase("Recipe") + " file : " + hg2.c1(), MsgBoxStyle.OkOnly, "Recipe Save");
		}
		hg2 = null;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool tc()
	{
		return au;
	}

	[SpecialName]
	[CompilerGenerated]
	public void m2(bool A_0)
	{
		au = A_0;
	}

	[SpecialName]
	public global::r.d td()
	{
		return z;
	}

	public bool m2(bool A_0, bool A_1)
	{
		if (tc())
		{
			return true;
		}
		bool result = true;
		short A_3 = default(short);
		foreach (g7 item in t)
		{
			hg hg2 = item.zg();
			if (A_1 && ((item.zi() && !item.zh().ae()) || !item.zg().c9()))
			{
				fa obj = new fa();
				string a_;
				if (item.zi())
				{
					string A_2 = "PromptRecipeSaveChangesComposite";
					a_ = string.Format(hu.a(ref A_2), item.zh().x());
				}
				else
				{
					string A_2 = "PromptRecipeSaveChanges";
					a_ = string.Format(hu.a(ref A_2), hg2.ci());
				}
				obj.d().Enabled = !A_0;
				obj.a(a_, global::c.d().Info.Title, hg.b3(), ref A_3);
				switch (A_3)
				{
				case 2:
					result = false;
					goto end_IL_0171;
				case 6:
					if (item.zi())
					{
						foreach (hg item2 in item.zh().ad())
						{
							m2(item2);
						}
						item.zh().z(item.zh().w());
					}
					else
					{
						m2(item.zg());
					}
					result = true;
					break;
				default:
					item.zg().b5(A_0: true);
					item.zh().s(A_0: true);
					result = true;
					break;
				}
			}
			else
			{
				result = true;
			}
			hg2 = null;
			continue;
			end_IL_0171:
			break;
		}
		return result;
	}

	public global::r.a p9(bool A_0)
	{
		global::r.a result = global::r.a.a;
		if (ai != null)
		{
			foreach (gy item in ai.i())
			{
				if (s3(item.x()))
				{
					item.s(vg(item.y()));
				}
			}
			foreach (gx item2 in u)
			{
				foreach (gx item3 in ai.j())
				{
					if (item2.n() == item3.n())
					{
						item3.ab = item2.ab;
						item3.ac = item2.ac;
					}
				}
			}
			if (ai.h() != gz.a.a)
			{
				result = global::r.a.b;
				ab8().c(fz.a.b, "ErrStoringMeasModsConfig");
			}
		}
		checked
		{
			if (u != null)
			{
				for (int num = u.Count - 1; num >= 0; num += -1)
				{
					gx.a a10 = qh;
					if (a10 != null)
					{
						u[num].k(a10);
					}
					u[num].ak();
					u.RemoveAt(num);
				}
			}
			if (t != null)
			{
				foreach (g7 item4 in t)
				{
					if (item4.i(A_0) != global::r.a.a)
					{
						result = global::r.a.b;
						ab8().c(fz.b.b, "Error shutting-down measurement module thread (" + item4.zl() + ") ");
					}
				}
			}
			if (ag != null)
			{
				foreach (d3 item5 in ag)
				{
					if (item5.i(A_0) != global::r.a.a)
					{
						result = global::r.a.b;
						ab8().c(fz.b.b, "Error shutting-down camera worker thread");
					}
				}
			}
			return result;
		}
	}

	public override global::r.a i(bool A_0)
	{
		if (ar)
		{
			return global::r.a.a;
		}
		global::r.a a10 = base.i(A_0);
		if (a10 != global::r.a.a)
		{
			return a10;
		}
		a10 = p9(A_0);
		if (a10 != global::r.a.a)
		{
			return a10;
		}
		ar = true;
		return global::r.a.a;
	}

	public bool m2(Guid A_0, ref Guid A_1)
	{
		gx gx2 = uw(A_0);
		if (gx2 == null)
		{
			return false;
		}
		A_1 = gx2.n();
		return true;
	}

	protected gx m2(gx A_0)
	{
		string A_1 = "MonitorPanelName";
		string arg = hu.a(ref A_1);
		gx gx2 = A_0.ah();
		checked
		{
			if (!string.IsNullOrEmpty(A_0.q))
			{
				A_1 = "PanelNameWithDetailsFmt2";
				gx2.q = string.Format(hu.a(ref A_1), arg, A_0.q);
			}
			else if (u.Count > 1)
			{
				Collection<Guid> collection = A_0.o;
				string text = null;
				List<string> list = new List<string>();
				int num = collection.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					list.Add(uh(collection[num2]));
				}
				text = list[0];
				string text2 = text;
				int num3 = collection.Count - 1;
				for (int num4 = 1; num4 <= num3; num4++)
				{
					int num5 = text2.Length - 1;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						if (list[num4].Length > num6 && list[num4][num6] != text2[num6])
						{
							text = text + ", " + list[num4].Substring(num6);
							break;
						}
					}
				}
				A_1 = "PanelNameWithDetailsFmt2";
				gx2.q = string.Format(hu.a(ref A_1), arg, uh(A_0.o[0]));
			}
			else
			{
				gx2.q = arg;
			}
			return gx2;
		}
	}

	public gx t9(Guid A_0)
	{
		return m2(ua(A_0));
	}

	public Collection<gx> te()
	{
		Collection<gx> collection = new Collection<gx>();
		foreach (gx item in u)
		{
			collection.Add(m2(item));
		}
		return collection;
	}

	protected gx ua(Guid A_0)
	{
		foreach (gx item in u)
		{
			if (item.n() == A_0)
			{
				return item;
			}
		}
		return null;
	}

	public d m2(ref Collection<gu.a> A_0)
	{
		d result = d.a;
		gu.a a10 = null;
		try
		{
			string A_1 = "MeasurePanelName";
			string arg = hu.a(ref A_1);
			A_0 = new Collection<gu.a>();
			foreach (g7 item in t)
			{
				a10 = new gu.a();
				a10.b = gu.a.a.a;
				a10.a = item.zk();
				a10.d = item.yf();
				if (Operators.CompareString(item.zl(), string.Empty, TextCompare: false) != 0)
				{
					gu.a obj = a10;
					A_1 = "PanelNameWithDetailsFmt2";
					obj.c = string.Format(hu.a(ref A_1), arg, item.zl());
				}
				else if (t.Count > 1)
				{
					gu.a obj2 = a10;
					A_1 = "PanelNameWithDetailsFmt2";
					obj2.c = string.Format(hu.a(ref A_1), arg, p9(item.zj()));
				}
				else
				{
					a10.c = arg;
				}
				A_0.Add(a10);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = d.b;
			ab8().c(fz.b.b, "Exception caught in MeasModuleMgr.GetMeasModuleInfoList(). ", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public Collection<Guid> tf()
	{
		Collection<Guid> collection = new Collection<Guid>();
		foreach (g7 item in t)
		{
			collection.Add(item.zk());
		}
		return collection;
	}

	public Collection<Guid> tg()
	{
		Collection<Guid> collection = new Collection<Guid>();
		foreach (gx item in u)
		{
			collection.Add(item.n());
		}
		return collection;
	}

	public Collection<h6.c> p9(Guid A_0, int A_1)
	{
		return uz(A_0).m2(A_1, A_1: true, up(), A_3: true);
	}

	public Collection<h6.d> qh(Guid A_0, int A_1)
	{
		return uz(A_0).tl(A_1);
	}

	public Collection<@in.b> ub(Guid A_0)
	{
		return uz(A_0).xq();
	}

	public Collection<@in.c> uc(Guid A_0)
	{
		return uz(A_0).xr();
	}

	[SpecialName]
	public bool ud(Guid A_0)
	{
		return uy(A_0)[0].v6();
	}

	[SpecialName]
	public bool th()
	{
		return af.f() > 0;
	}

	[SpecialName]
	public float m2(Guid A_0, int A_1, int A_2)
	{
		return uz(A_0).st(A_1, A_2);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, int A_3, ref bool A_4, ref float A_5, ref float A_6, ref bool A_7, ref float A_8)
	{
		uz(A_0).m2(A_1, A_2, A_3, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8);
	}

	[SpecialName]
	public float qh(Guid A_0, int A_1, global::f.b A_2)
	{
		return uz(A_0).sm(A_1, A_2);
	}

	[SpecialName]
	public float sj(Guid A_0, int A_1, global::f.b A_2)
	{
		return uz(A_0).sn(A_1, A_2);
	}

	[SpecialName]
	public bool ue(Guid A_0)
	{
		if (!aj.bq())
		{
			return uy(A_0)[0].xs();
		}
		return true;
	}

	public Collection<string> uf(Guid A_0)
	{
		return uz(A_0).xp();
	}

	public bool ug(Guid A_0)
	{
		return uv(A_0) != null;
	}

	public string m2(string A_0)
	{
		return st(A_0).zl();
	}

	public string p9(string A_0)
	{
		return st(A_0).vc();
	}

	public string uh(Guid A_0)
	{
		return uz(A_0).vc();
	}

	public int ui(Guid A_0)
	{
		return uz(A_0).vb();
	}

	public string p9(Guid A_0, int A_1, int A_2)
	{
		return uz(A_0).qh(A_1, A_2);
	}

	[SpecialName]
	public string sj(Guid A_0, int A_1)
	{
		return uz(A_0).s6(A_1);
	}

	[SpecialName]
	public gz ti()
	{
		return ai;
	}

	[SpecialName]
	public float tj()
	{
		return am;
	}

	[SpecialName]
	public float sm(Guid A_0, int A_1)
	{
		return uz(A_0).tg(A_1);
	}

	[SpecialName]
	public float qh(Guid A_0, int A_1, int A_2)
	{
		return uz(A_0).sm(A_1, A_2);
	}

	[SpecialName]
	public float tl()
	{
		float num = float.MaxValue;
		foreach (g7 item in t)
		{
			float num2 = item.wg();
			if (num2 < num)
			{
				num = num2;
			}
		}
		return num;
	}

	[SpecialName]
	public float t0()
	{
		float num = float.MinValue;
		foreach (g7 item in t)
		{
			float num2 = item.wh();
			if (num2 > num)
			{
				num = num2;
			}
		}
		return num;
	}

	[SpecialName]
	public float t5()
	{
		return an;
	}

	[SpecialName]
	public float sn(Guid A_0, int A_1)
	{
		return uz(A_0).th(A_1);
	}

	[SpecialName]
	public float sj(Guid A_0, int A_1, int A_2)
	{
		return uz(A_0).sn(A_1, A_2);
	}

	[SpecialName]
	public int t6()
	{
		return t.Count;
	}

	[SpecialName]
	public int t7()
	{
		return u.Count;
	}

	[SpecialName]
	public int uj(Guid A_0)
	{
		return ua(A_0)?.o.Count ?? 0;
	}

	protected bool p9(h6 A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		if (A_0.abc() > A_0.abb())
		{
			return true;
		}
		if (!(A_0 is ip))
		{
			return false;
		}
		ip ip2 = (ip)A_0;
		if (ip2.yb())
		{
			return false;
		}
		if (ip2.u0())
		{
			return true;
		}
		if (ip2.abb() >= 1)
		{
			return false;
		}
		foreach (gy item in ai.i())
		{
			foreach (ip.a item2 in item.ak())
			{
				if (!item2.v() && Operators.CompareString(item2.o(), ip2.abk().FriendlySN, TextCompare: false) == 0 && item2.l() == (FMLegacyAllSystemTypes)ip2.abk().FWInstTypeCode && Operators.CompareString(item2.n(), ip2.ur(), TextCompare: false) != 0)
				{
					return !ip.m2(item2.q(), item2.r(), ip2.vu(), ip2.vv(), Operators.CompareString(item2.p(), ip2.abk().SerialNumber, TextCompare: false) == 0);
				}
			}
		}
		ip2 = null;
		return false;
	}

	protected d m2(gt A_0, hg.j A_1, ref g7 A_2)
	{
		bool A_3 = false;
		return m2(null, A_0, A_1, ref A_2, ref A_3);
	}

	protected d m2(ip A_0, hg.j A_1, ref g7 A_2, ref bool A_3)
	{
		return m2(A_0, null, A_1, ref A_2, ref A_3);
	}

	protected d m2(ip A_0, gt A_1, hg.j A_2, ref g7 A_3, ref bool A_4)
	{
		d result = d.a;
		bool flag = false;
		bool flag2 = false;
		try
		{
			if (A_0 != null)
			{
				foreach (ip.a item in ai.k())
				{
					if (string.Compare(A_0.yq(), item.n()) == 0)
					{
						flag2 = true;
						break;
					}
				}
			}
			if (!flag2 || A_0 == null)
			{
				bool A_5 = default(bool);
				foreach (g7 item2 in t)
				{
					if (A_0 != null)
					{
						ai.f(A_0, item2, ref A_5);
						if (A_5)
						{
							A_3 = item2;
							flag = true;
							break;
						}
					}
					else if (ai.f(A_1, item2))
					{
						A_3 = item2;
						flag = true;
						break;
					}
				}
				if (flag)
				{
					if (A_0 != null && !A_3.sj(A_0))
					{
						hg A_6 = null;
						gx A_7 = null;
						m2(A_0, A_3.zk(), ref A_7, ref A_6, A_2);
						m2(A_0, A_3.zk());
						if (A_6 != null && A_7.o.Count > 1)
						{
							A_4 = true;
							foreach (g7 item3 in t)
							{
								item3.i(A_0: false);
							}
							t = new Collection<g7>();
							foreach (gx item4 in u)
							{
								item4.r = null;
							}
							return d.a;
						}
						if (A_3.m2(A_0, t9().g()) != gu.ErrPublic.None)
						{
							result = d.c;
						}
					}
				}
				else
				{
					result = m2(A_0, A_1, A_2, ref A_3);
				}
				if (global::e.a().ShowSpectrumColor && !sm((eo.a)null))
				{
					global::e.a().ShowSpectrumColor = false;
				}
			}
			else
			{
				result = d.f;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = d.b;
			ab8().c(fz.b.b, "Exception caught in MeasModuleMgr.AssignDeviceToMeasModule(). ", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	protected d m2(h5 A_0, hg.j A_1)
	{
		d result = d.a;
		bool flag = false;
		try
		{
			foreach (h5.a item in ai.l())
			{
				if (string.Compare(A_0.abk().SerialNumber, item.f()) == 0)
				{
					return d.g;
				}
			}
			g7 A_2 = null;
			bool A_3 = default(bool);
			foreach (g7 item2 in t)
			{
				if (A_0 != null)
				{
					ai.f(A_0, item2, ref A_3);
					if (A_3)
					{
						A_2 = item2;
						flag = true;
						break;
					}
				}
			}
			if (!flag && A_0.abq())
			{
				foreach (g7 item3 in t)
				{
					ai.g(A_0, item3, ref A_3);
					if (A_3)
					{
						A_2 = item3;
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					foreach (g7 item4 in t)
					{
						ai.h(A_0, item4, ref A_3);
						if (A_3)
						{
							A_2 = item4;
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						foreach (g7 item5 in t)
						{
							ai.i(A_0, item5, ref A_3);
							if (A_3)
							{
								A_2 = item5;
								flag = true;
								break;
							}
						}
					}
				}
			}
			if (flag)
			{
				if (A_2.m2(A_0, t9().g()) != gu.ErrPublic.None)
				{
					result = d.c;
				}
			}
			else
			{
				result = m2(A_0, null, A_1, ref A_2);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = d.b;
			ab8().c(fz.b.b, "Exception caught in MeasModuleMgr.AssignControllerToMeasModule(). ", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	protected d m2(@in A_0)
	{
		g7 A_1 = null;
		return m2(A_0, ref A_1);
	}

	protected d m2(@in A_0, ref g7 A_1)
	{
		d result = d.a;
		bool flag = false;
		bool flag2 = false;
		try
		{
			if (A_0 != null)
			{
				foreach (@in.a item in ai.m())
				{
					if (string.Compare(A_0.yq(), item.k()) == 0)
					{
						flag2 = true;
						break;
					}
				}
			}
			if (!flag2 || A_0 == null)
			{
				bool A_2 = default(bool);
				foreach (g7 item2 in t)
				{
					if (A_0 != null)
					{
						ai.f(A_0, item2, ref A_2);
						if (A_2)
						{
							A_1 = item2;
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					if (A_0 != null && !A_1.m2(A_0) && A_1.m2(A_0, t9().g()) != gu.ErrPublic.None)
					{
						result = d.c;
					}
				}
				else
				{
					result = m2(A_0, null, hg.j.a, ref A_1);
				}
				if (global::e.a().ShowSpectrumColor && !sm((eo.a)null))
				{
					global::e.a().ShowSpectrumColor = false;
				}
			}
			else
			{
				result = d.f;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = d.b;
			ab8().c(fz.b.b, "Exception caught in MeasModuleMgr.GetCompatibleMeasModule(). ", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	protected d m2(f0 A_0, gt A_1, hg.j A_2, ref g7 A_3)
	{
		string A_4 = null;
		string A_5 = null;
		string A_6 = null;
		Guid a_ = Guid.NewGuid();
		hg A_7 = null;
		he he2 = null;
		gx A_8 = null;
		d result = d.a;
		gy gy2 = null;
		if (A_0 is ip)
		{
			m2((ip)A_0, a_, ref A_8, ref A_7, A_2);
		}
		if (A_7 == null)
		{
			A_7 = new hg(aj, A_2);
		}
		he2 = new he(string.Empty, A_7.c1(), string.Empty);
		bool A_9 = default(bool);
		hg.bu(aj, ref A_4, ref A_5, ref A_6, ref A_9);
		hg.bu(A_7, A_2, A_9, sn(), global::r.d.a.b.b, ab8(), g2.b.a, A_7: true, A_8: false);
		if (A_6 != null)
		{
			A_7.cc(A_6);
		}
		string a_2 = "";
		if (A_0 != null)
		{
			a_2 = ae.e(0).i();
		}
		h6 h10 = A_0 as h6;
		g2 g10 = new g2(g2.a.d, a_2);
		if (h10 != null)
		{
			if (A_0 != null && h10.abb() > 0)
			{
				if (h10.abk().FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF2)
				{
					g10.o(g2.a.b);
				}
				else
				{
					g10.o(g2.a.c);
				}
			}
			else if (A_1 == null)
			{
				g10.d(h10.abk().FWDefOpticConfig);
			}
			else
			{
				g10.o(A_1.ad());
			}
		}
		if (A_0 == null)
		{
			A_3 = new g7(ab8(), a_, A_1, A_7, ah, al, g10, he2, A_8: false);
		}
		else
		{
			A_3 = new g7(ab8(), a_, string.Empty, A_7, ah, al, g10, he2, A_8: false, ae, af, sj, z);
			if (A_8 != null)
			{
				A_3.x1().d((global::r.d.b)qh);
			}
		}
		A_3.zm();
		checked
		{
			if (A_8 != null)
			{
				int num = u.IndexOf(A_8);
				int num2 = t.Count - 1;
				int num3;
				for (num3 = 0; num3 <= num2; num3++)
				{
					Guid guid = t[num3].zk();
					gx gx2 = uw(guid);
					if (gx2 == null)
					{
						break;
					}
					if (gx2 == A_8)
					{
						gx gx3 = gx2;
						if (((ip)A_0).uy() < gx3.p[gx3.o.IndexOf(guid)])
						{
							break;
						}
						gx3 = null;
					}
					else if (num < u.IndexOf(gx2))
					{
						break;
					}
				}
				t.Insert(num3, A_3);
			}
			else
			{
				t.Add(A_3);
			}
			if (A_8 != null)
			{
				A_8.r = null;
			}
			if (A_0 != null && A_3.m2(A_0, t9().g()) != gu.ErrPublic.None)
			{
				result = d.c;
			}
			else
			{
				gy2 = new gy(ab8(), A_3);
				if (A_0 == null)
				{
					gy2.s(A_1);
				}
				else if (A_0 is ip)
				{
					gy2.s(new ip.a((ip)A_0), gy2.ak().Count);
				}
				else if (A_0 is @in)
				{
					gy2.s(new @in.a((@in)A_0), gy2.aj().Count);
				}
				else if (A_0 is h5)
				{
					gy2.s(new h5.a(((h5)A_0).abk()));
				}
				gy2.s(A_9);
				int num4 = ai.i().Count;
				if (A_0 != null && A_8 != null)
				{
					int num5 = ai.j().Count - 1;
					int num6;
					for (num6 = 0; num6 <= num5 && !(ai.j()[num6].n() == A_8.n()); num6++)
					{
					}
					int num7 = ai.i().Count - 1;
					for (num4 = 0; num4 <= num7; num4++)
					{
						Guid guid2 = ai.i()[num4].y();
						gx gx4 = null;
						foreach (gx item in ai.j())
						{
							foreach (Guid item2 in item.o)
							{
								if (item2 == guid2)
								{
									gx4 = item;
									break;
								}
							}
							if (gx4 != null)
							{
								break;
							}
						}
						if (gx4 == null)
						{
							break;
						}
						if (gx4.n() == A_8.n())
						{
							gx gx5 = gx4;
							if (((ip)A_0).uy() < gx5.p[gx5.o.IndexOf(guid2)])
							{
								break;
							}
							gx5 = null;
						}
						else if (num6 < ai.j().IndexOf(gx4))
						{
							break;
						}
					}
				}
				if (ai.f(gy2, num4) != gz.a.a)
				{
					result = d.b;
					ab8().c(fz.b.a, "Error adding meas module configuration to the collection.");
				}
				else
				{
					if (A_0 is ip)
					{
						m2((ip)A_0, A_3.zk());
					}
					gy2.u("\\" + A_7.b6());
					if (A_9)
					{
						if (A_5 != null)
						{
							gy2.s(A_0: false);
							gy2.u("\\" + i3.d(A_5, hg.bz()));
						}
					}
					else if (A_4 != null)
					{
						gy2.s(A_0: true);
						gy2.u("\\" + i3.d(A_4, hg.bz()));
					}
					gy2.s(A_9);
					gy2.t(A_7);
					string text = null;
					string text2 = null;
					string text3 = null;
					text = e4.aa() + "\\StartupTemplateAR.txt";
					if (global::c.e().FileSystem.FileExists(text))
					{
						StreamReader streamReader = new StreamReader(File.Open(text, FileMode.Open, FileAccess.Read, FileShare.Read));
						string text4 = streamReader.ReadLine();
						text2 = ((!string.IsNullOrEmpty(text4)) ? (e4.aa() + "\\" + text4) : (e4.aa() + "\\DefaultTemplate"));
						text2 += ".fmtpa";
						streamReader.Close();
					}
					else
					{
						text2 = e4.aa() + "\\DefaultTemplate";
					}
					text = e4.aa() + "\\StartupTemplate.txt";
					if (global::c.e().FileSystem.FileExists(text))
					{
						StreamReader streamReader2 = new StreamReader(File.Open(text, FileMode.Open, FileAccess.Read, FileShare.Read));
						string text5 = streamReader2.ReadLine();
						text3 = ((!string.IsNullOrEmpty(text5)) ? (e4.aa() + "\\" + text5) : (e4.aa() + "\\DefaultTemplate"));
						text3 += ".fmtpe";
						streamReader2.Close();
					}
					else
					{
						text3 = e4.aa() + "\\DefaultTemplate";
					}
					if (text3 != null)
					{
						gy2.u(A_0: false);
						gy2.w("\\" + Path.GetFileName(text3));
					}
					else
					{
						gy2.u(A_0: false);
						gy2.w("\\DefaultTemplate");
					}
					if (text2 != null)
					{
						gy2.u(A_0: true);
						gy2.w("\\" + Path.GetFileName(text2));
					}
					else
					{
						gy2.u(A_0: true);
						gy2.w("\\DefaultTemplate");
					}
					gy2.u(A_9);
					gy2.s(g10);
					if (A_1 == null && h10 != null)
					{
						if (h10.abk().FWDefNumCurves > 0)
						{
							global::e.a().GraphMeasUserDefinedMaxCurves = h10.abk().FWDefNumCurves;
						}
						switch (h10.abk().FWDefRefMat)
						{
						case FMRefMatEnums.kRefMatBk7:
							global::e.a().LastUsedReflReferenceMaterial = "BK7";
							break;
						case FMRefMatEnums.kRefMatSi:
							global::e.a().LastUsedReflReferenceMaterial = "Si";
							break;
						case FMRefMatEnums.kRefMatFusedSilica2Sided:
							global::e.a().LastUsedReflReferenceMaterial = "Fused Silica (2-sided)";
							break;
						}
					}
					else if (A_1 != null)
					{
						global::e.a().GraphMeasUserDefinedMaxCurves = A_1.ah();
						global::e.a().DisplaySignificantDigits = A_3.zf();
					}
					if (!global::e.a().ShowSpectrumColorDefaultHasBeenSet)
					{
						global::e.a().ShowSpectrumColor = ud();
						global::e.a().ShowSpectrumColorDefaultHasBeenSet = true;
						al.k();
					}
				}
			}
			return result;
		}
	}

	protected void m2(ip A_0, Guid A_1, ref gx A_2, ref hg A_3, hg.j A_4)
	{
		if (!p9(A_0))
		{
			return;
		}
		checked
		{
			int num = default(int);
			try
			{
				foreach (gx item in u)
				{
					num = item.o.IndexOf(A_1);
					if (num >= 0)
					{
						A_2 = item;
						if (A_2.p[num] < 0)
						{
							A_2.p[num] = A_0.uy();
						}
						return;
					}
				}
				foreach (gy item2 in ai.i())
				{
					if (A_0.uv())
					{
						if (Operators.CompareString(A_0.ux(), item2.v(), TextCompare: false) == 0 && !string.IsNullOrEmpty(A_0.ux()) && item2.y() != A_1)
						{
							A_2 = uw(item2.y());
						}
					}
					else if (string.IsNullOrEmpty(item2.v()))
					{
						foreach (ip.a item3 in item2.ak())
						{
							if (Operators.CompareString(item3.o(), A_0.abk().FriendlySN, TextCompare: false) == 0 && item3.l() == unchecked((FMLegacyAllSystemTypes)A_0.abk().FWInstTypeCode))
							{
								A_2 = uw(item2.y());
							}
							if (A_2 != null)
							{
								break;
							}
						}
					}
					if (A_2 != null)
					{
						break;
					}
				}
				if (A_2 == null)
				{
					A_2 = new gx(sj, sm, qh, sj, sm);
					u.Add(A_2);
					ai.j().Add(new gx(A_2.n()));
					uv(A_1)?.x1().d((global::r.d.b)qh);
				}
				else
				{
					g7 g10 = null;
					foreach (Guid item4 in A_2.o)
					{
						g10 = uv(item4);
						if (g10 != null)
						{
							break;
						}
					}
					if (g10 != null)
					{
						if (A_2.o.Contains(A_1))
						{
							return;
						}
						A_3 = g10.zg();
					}
				}
				int num2 = 0;
				int num3 = A_2.o.Count - 1;
				for (num2 = 0; num2 <= num3 && A_0.uy() >= A_2.p[num2]; num2++)
				{
				}
				A_2.o.Insert(num2, A_1);
				A_2.p.Insert(num2, A_0.uy());
				A_2.r = null;
				foreach (gx item5 in ai.j())
				{
					if (item5.n() == A_2.n() && !item5.o.Contains(A_1))
					{
						num2 = 0;
						int num4 = item5.o.Count - 1;
						for (num2 = 0; num2 <= num4 && A_0.uy() >= item5.p[num2]; num2++)
						{
						}
						item5.o.Insert(num2, A_1);
						item5.p.Insert(num2, A_0.uy());
						break;
					}
				}
			}
			finally
			{
				bool flag = false;
				Collection<Guid> collection = A_2.o;
				g7 g11 = uv(collection[0]);
				string text = null;
				if (g11 != null)
				{
					text = g11.s6(0);
					if (string.IsNullOrEmpty(text) && A_2 != null && num == 0)
					{
						text = A_0.abk().SerialNumber;
					}
				}
				if (!string.IsNullOrEmpty(text))
				{
					int num5 = collection.Count - 1;
					for (int num6 = 1; num6 <= num5; num6++)
					{
						g7 g12 = uv(collection[num6]);
						if (g12 != null)
						{
							g7 g13 = g12;
							if (!string.IsNullOrEmpty(g13.s6(0)) && Operators.CompareString(g13.s6(0), text, TextCompare: false) != 0 && !g13.zg().d0().l())
							{
								g13.m2(text);
								flag = true;
							}
							g13 = null;
						}
					}
					if (Operators.CompareString(A_0.abd(), text, TextCompare: false) != 0)
					{
						A_0.p9(text);
					}
				}
				if (flag)
				{
					hg A_5 = g11.zg();
					hg A_6 = new hg(A_5.dh(), A_5.cd());
					Guid a_ = g11.zk();
					hg hg2;
					string A_7 = (hg2 = A_5).c1();
					hg.bu(ref A_6, ref A_7, A_4, A_5.b5(), null, global::r.d.a.b.b, ab8(), A_7: false, default(Point), A_5.cm(), wy(a_), !xb(a_), xq(a_), A_5.ei());
					hg2.cc(A_7);
					A_6.bu(ref A_5);
					A_5.bv(new global::r.d(), A_1: true);
				}
				collection = null;
			}
		}
	}

	protected void m2(ip A_0, Guid A_1)
	{
		if (A_0 == null || !A_0.uv())
		{
			return;
		}
		foreach (gy item in ai.i())
		{
			if (item.y() == A_1)
			{
				item.t(A_0.ux());
				break;
			}
		}
	}

	public void uk(Guid A_0)
	{
		checked
		{
			int num = ai.j().Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				gx gx2 = ai.j()[num2];
				int num3 = gx2.o.Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (!(gx2.o[num4] == A_0))
					{
						continue;
					}
					gx2.o.RemoveAt(num4);
					gx2.p.RemoveAt(num4);
					if (gx2.o.Count == 0)
					{
						ai.j().RemoveAt(num2);
					}
					Collection<gy> collection = ai.i();
					int num5 = collection.Count - 1;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						gy gy2 = collection[num6];
						if (gy2.y() == A_0)
						{
							gy2.t(string.Empty);
							collection.Remove(gy2);
							collection.Add(gy2);
							break;
						}
					}
					return;
				}
				gx2 = null;
			}
		}
	}

	public void m2(Guid A_0, ref bool A_1, bool A_2, bool A_3, ref string A_4)
	{
		Collection<g7> collection = uy(A_0);
		foreach (g7 item in collection)
		{
			item.m2(ref A_1, A_2, A_3, ref A_4);
			if (!A_1)
			{
				continue;
			}
			if (collection.Count > 1)
			{
				string text = item.zl();
				if (string.IsNullOrEmpty(A_4))
				{
					A_4 = text;
					break;
				}
				string A_5 = "SpectromIDWithChannelFmt2";
				string.Format(hu.a(ref A_5), text, A_4);
			}
			break;
		}
	}

	public global::f.b sm(Guid A_0, int A_1, int A_2)
	{
		return uz(A_0).so(A_1, A_2);
	}

	public void m2(Guid A_0, global::h A_1, bool A_2, bool A_3, ref bool[] A_4)
	{
		uy(A_0)[0].m2(A_1, A_2, A_3, ref A_4);
	}

	public ew.a qh(string A_0)
	{
		g7 g10 = so(A_0);
		if (g10 == null)
		{
			g10 = t[0];
		}
		return g10.xo();
	}

	public double m2(Guid A_0, h6.b A_1, int A_2, global::f.b A_3)
	{
		return uz(A_0).sm(A_1, A_2, A_3);
	}

	public double p9(Guid A_0, h6.b A_1, int A_2, global::f.b A_3)
	{
		return uz(A_0).sj(A_1, A_2, A_3);
	}

	public double m2(Guid A_0, h6.b A_1, int A_2, global::f.b A_3, double A_4)
	{
		return uz(A_0).m2(A_1, A_2, A_3, A_4);
	}

	[SpecialName]
	public int m2(string A_0, h6.b A_1, int A_2, global::f.b A_3)
	{
		return st(A_0).sn(A_1, A_2, A_3);
	}

	[SpecialName]
	public string m2(Guid A_0, global::f.b A_1, int A_2)
	{
		return uz(A_0).m2(A_1, A_2);
	}

	public void m2(Guid A_0, ref string A_1, ref bool A_2, ref string A_3)
	{
		uy(A_0)[0].m2(ref A_1, ref A_2, ref A_3);
	}

	public void m2(Guid A_0, int A_1, string A_2, bool A_3, global::r.d.a.b A_4, ref bool A_5)
	{
		foreach (g7 item in uy(A_0))
		{
			item.m2(A_2, A_1, A_3, A_4, ref A_5);
		}
	}

	public float[] ul(Guid A_0)
	{
		float[] array = new float[2];
		Collection<g7> collection = uy(A_0);
		float[] array2 = collection[0].wr();
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 1; num2 <= num; num2++)
			{
				array = collection[num2].wr();
				if (array[0] > array2[0])
				{
					array2[0] = array[0];
				}
				if (array[1] > array2[1])
				{
					array2[1] = array[1];
				}
			}
			return array2;
		}
	}

	public void m2(Guid A_0, bool A_1, global::r.d A_2, global::r.d.a.b A_3)
	{
		foreach (g7 item in uy(A_0))
		{
			item.m2(A_1, A_2, A_3);
		}
	}

	public void m2(Guid A_0, bool A_1, bool A_2, global::r.d A_3, bool A_4, global::r.d.a.b A_5)
	{
		gx A_6 = null;
		Collection<g7> collection = m2(A_0, ref A_6);
		Collection<global::r.d> collection2 = new Collection<global::r.d>();
		if (A_6 == null)
		{
			collection2.Add(A_3);
		}
		else
		{
			c A_7 = null;
			m2(A_0, A_3, null, collection, collection2, ref A_7);
		}
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				collection[num2].m2(A_1, A_2, collection2[num2], A_4, A_5);
			}
		}
	}

	[SpecialName]
	public bool um(Guid A_0)
	{
		gx A_1 = null;
		Collection<g7> collection = m2(A_0, ref A_1);
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (!collection[num2].wm())
				{
					return false;
				}
			}
			return collection.Count > 0;
		}
	}

	[SpecialName]
	public void m2(Guid A_0, bool A_1)
	{
		gx A_2 = null;
		Collection<g7> collection = m2(A_0, ref A_2);
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				collection[num2].s6(A_1);
			}
		}
	}

	[SpecialName]
	public bool un(Guid A_0)
	{
		gx A_1 = null;
		Collection<g7> collection = m2(A_0, ref A_1);
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (!collection[num2].wn())
				{
					return false;
				}
			}
			return collection.Count > 0;
		}
	}

	[SpecialName]
	public void p9(Guid A_0, bool A_1)
	{
		gx A_2 = null;
		Collection<g7> collection = m2(A_0, ref A_2);
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				collection[num2].s8(A_1);
			}
		}
	}

	public void m2(Guid A_0, ref bool A_1, ref bool A_2, ref bool A_3, ref float A_4, ref float A_5)
	{
		gx A_6 = null;
		Collection<g7> collection = m2(A_0, ref A_6);
		A_1 = false;
		A_2 = false;
		A_3 = false;
		A_4 = float.MaxValue;
		A_5 = float.MaxValue;
		checked
		{
			int num = collection.Count - 1;
			bool A_9 = default(bool);
			bool A_10 = default(bool);
			bool A_11 = default(bool);
			for (int num2 = 0; num2 <= num; num2++)
			{
				float A_7 = float.MaxValue;
				float A_8 = float.MaxValue;
				collection[num2].m2(ref A_9, ref A_10, ref A_11, ref A_7, ref A_8);
				A_1 = A_1 || A_9;
				A_2 = A_2 || A_10;
				A_3 = A_3 || A_11;
				if (A_4 > A_7)
				{
					A_4 = A_7;
				}
				if (A_5 > A_8)
				{
					A_5 = A_8;
				}
			}
		}
	}

	public void m2(Guid A_0, ref string A_1, ref string A_2)
	{
		g7 obj = uz(A_0);
		short A_3 = 0;
		obj.m2(ref A_1, ref A_2, ref A_3);
	}

	[SpecialName]
	public string sj(string A_0)
	{
		return st(A_0).wv();
	}

	[SpecialName]
	public string uo(Guid A_0)
	{
		return uz(A_0).ww();
	}

	public void m2(Guid A_0, hg A_1, bool A_2)
	{
		uy(A_0)[0].p9(A_1, A_2);
	}

	[SpecialName]
	public bool up(Guid A_0)
	{
		return uz(A_0).xe();
	}

	public d m2(string A_0, string A_1, ref string A_2, string A_3)
	{
		if (st(A_0).m2(ref A_1, ref A_2, A_2: false, A_3) != gu.ErrPublic.None)
		{
			return d.d;
		}
		return d.a;
	}

	public d p9(string A_0, string A_1, ref string A_2, string A_3)
	{
		g7 g10 = st(A_0);
		if (g10.ya())
		{
			if (g10.x8())
			{
				m2(A_0, A_1, ref A_2, A_3);
			}
			g10.xf();
			return d.a;
		}
		return m2(A_0, A_1, ref A_2, A_3);
	}

	public d sm(string A_0)
	{
		if (st(A_0).xg() != gu.ErrPublic.None)
		{
			return d.d;
		}
		return d.a;
	}

	public d m2(string A_0, ref string A_1, hr A_2, bool A_3, global::r.c A_4, global::r.d A_5, global::r.d.a.b A_6)
	{
		if (st(A_0).m2(ref A_1, A_2, A_3, A_4, A_5, A_6) != gu.ErrPublic.None)
		{
			return d.d;
		}
		return d.a;
	}

	public d m2(string A_0, string A_1, ref string A_2, global::r.d A_3, l A_4, Collection<hr> A_5, short A_6, a6 A_7, global::r.d.a.b A_8, bool A_9, bool A_10)
	{
		d result = default(d);
		try
		{
			if (st(A_0).m2(A_1, ref A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10) != gu.ErrPublic.None)
			{
				result = d.d;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = d.b;
			ab8().c(fz.b.b, "Exception caught in MeasModuleMgr.AnalyzeMultipleSpectra().", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public d m2(string A_0, string A_1, ref string A_2, global::r.d A_3, l A_4, hr A_5, short A_6, a6 A_7, global::r.d.a.b A_8, bool A_9, bool A_10)
	{
		d result = default(d);
		try
		{
			if (st(A_0).m2(A_1, ref A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10) != gu.ErrPublic.None)
			{
				result = d.d;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = d.b;
			ab8().c(fz.b.b, "Exception caught in MeasModuleMgr.AnalyzeSpectrum().", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public d m2(string A_0, string A_1, ref string A_2, global::r.d A_3, l A_4, hr A_5, ho A_6, short A_7, global::r.d.a.b A_8)
	{
		d result = default(d);
		try
		{
			if (st(A_0).m2(A_1, ref A_2, A_3, A_4, A_5, A_6, A_7, A_8) != gu.ErrPublic.None)
			{
				result = d.d;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = d.b;
			ab8().c(fz.b.b, "Exception caught in MeasModuleMgr.ComputePrecision().", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public hr m2(string A_0, hr A_1, int A_2, bool A_3, global::r.d.a.b A_4, bool A_5)
	{
		return st(A_0).m2(A_1, A_2, A_3, A_4, A_5);
	}

	public void m2(Guid A_0, string A_1, string A_2, global::r.d A_3, l A_4, short A_5, global::r.d.a.b A_6, bool A_7, int A_8)
	{
		AutoResetEvent A_9 = null;
		m2(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9: false, null, ref A_9, A_12: false);
	}

	public void m2(Guid A_0, string A_1, string A_2, global::r.d A_3, l A_4, short A_5, global::r.d.a.b A_6, bool A_7, int A_8, bool A_9, l A_10, ref AutoResetEvent A_11, bool A_12)
	{
		gx A_13 = null;
		Collection<g7> collection = m2(A_0, ref A_13);
		if (!A_9 && A_13 != null)
		{
			m2(A_0, collection, A_6);
		}
		A_8 = ((A_4 == null) ? 1 : 0);
		Collection<global::r.d> collection2 = new Collection<global::r.d>();
		bool a_;
		if (A_13 == null)
		{
			collection2.Add(A_3);
			a_ = false;
		}
		else
		{
			c A_14 = null;
			bool flag = false;
			m2(A_0, A_3, A_10, collection, collection2, ref A_14);
			A_11 = A_14.f;
			a_ = true;
			gx gx2 = A_13;
			if (!gx2.ae())
			{
				gx2.j(DateTime.Now);
				flag = true;
			}
			gx2 = null;
			bool flag2 = default(bool);
			try
			{
				if (!Monitor.TryEnter(A_13.ad, 500))
				{
					throw new ao("Unable to lock theInfo.ElapsedTimeSeconds");
				}
				flag2 = true;
				if (!A_12)
				{
					g7 g10 = collection[0];
					hg hg2 = g10.v8();
					if (hg2 != null && (Operators.CompareString(hg2.cl(), g10.zg().cl(), TextCompare: false) != 0 || g10.m2(!g10.zg().d0().q(), (eo.a)null) != g10.v9() || al.h() != g10.wa() || al.i() != g10.wb()))
					{
						A_12 = true;
					}
					g10 = null;
				}
				Collection<float> collection3 = A_13.ad;
				if (A_12)
				{
					collection3.Clear();
					A_13.j(DateTime.Now);
					flag = true;
					collection3.Add(0f);
				}
				else
				{
					collection3.Add((float)(DateTime.Now - A_13.w()).TotalSeconds);
				}
				collection3 = null;
				if (flag)
				{
					gx gx3 = A_13;
					hg hg3 = wu(gx3.n());
					gx3.j(hg3, collection[0].m2(!hg3.d0().q(), (eo.a)null), al.h(), al.i(), v1(A_0)[0], collection[0].so(hg3));
					gx3.z = gx3.ab;
					if (gx3.z)
					{
						A_13.aa = i3.c(gx3.ac, gx3.w());
						gx3.j(ab8(), hg3);
					}
					gx3 = null;
				}
			}
			finally
			{
				if (flag2)
				{
					Monitor.Exit(A_13.ad);
				}
			}
			if (A_10 == null)
			{
				p9(A_13)[0].m2(254, new global::r.d(), A_6);
				_ = null;
			}
		}
		if (A_13 != null)
		{
			collection2[0].d((global::r.d.c)A_13.k);
		}
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				collection[num2].m2(A_1, A_2, collection2[num2], A_4, A_4: true, A_8, A_5, A_6, A_7, a_, A_12);
			}
		}
	}

	public void m2(Guid A_0, string A_1, string A_2, global::r.d A_3, int A_4, int A_5, string A_6, bool A_7, bool A_8, bool A_9, int A_10, l A_11, global::r.d.a.b A_12)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10, A_11, A_12);
	}

	public void m2(Guid A_0, string A_1, string A_2, global::r.d A_3, int A_4, int A_5, string A_6, bool A_7, bool A_8, bool A_9, short A_10, int A_11, l A_12, global::r.d.a.b A_13)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10, A_11, A_12, A_13);
	}

	public void m2(Guid A_0, string[] A_1, global::r.d A_2, short A_3, a6 A_4, string A_5, global::r.d.a.b A_6)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4, A_5, A_6);
	}

	public d m2(Guid A_0, string A_1, string A_2, string A_3, ref string A_4, global::r.d A_5, l A_6, o A_7, bool A_8, float A_9, float A_10, global::r.d.a.b A_11, int A_12, string A_13, bool A_14, bool A_15, bool A_16, short A_17)
	{
		float[] a_ = new float[checked(Enum.GetValues(typeof(global::h.h)).GetUpperBound(0) + 1)];
		d result = default(d);
		try
		{
			if (uz(A_0).m2(A_1, A_2, A_3, ref A_4, A_5, A_7, A_6, A_7: false, a_, A_9: true, A_8, 0, A_9, A_10, A_11, A_12, A_13, A_14, A_15, A_16, A_17) != gu.ErrPublic.None)
			{
				result = d.d;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			result = d.b;
			ab8().c(fz.b.b, "Exception caught in MeasModuleMgr.MeasureContactProbeSpectra().", a_2);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public d uq(Guid A_0)
	{
		if (uz(A_0).xi() != gu.ErrPublic.None)
		{
			return d.k;
		}
		return d.a;
	}

	public void ur(Guid A_0)
	{
		g7 g10 = uz(A_0);
		if (g10.zp() == g2.a.b)
		{
			g10.xk();
		}
	}

	protected void p9(Guid A_0, global::r.d.a.b A_1)
	{
		Collection<g7> a_ = uy(A_0);
		m2(A_0, a_, A_1);
	}

	protected void m2(Guid A_0, Collection<g7> A_1, global::r.d.a.b A_2)
	{
		bool A_3 = default(bool);
		foreach (g7 item in A_1)
		{
			if (!item.m2(A_0: false, ref A_3))
			{
				if (!A_3)
				{
					throw new ah("Attempt to acquire and measure, but ref and bac cannot be authenticated");
				}
				item.m2(A_2, 0L, A_2: false);
			}
		}
	}

	public void m2(Guid A_0, string A_1, string A_2, short A_3, global::r.d.a.b A_4, bool A_5, bool A_6)
	{
		gx A_7 = ua(A_0);
		p9(A_0, A_4);
		t t2 = null;
		float num = p9(A_0, ref A_7).b8().at();
		t2 = new t(A_4);
		t obj = t2;
		((m)obj).a = m.a.q;
		obj.d = m.TaskExecutionType.Execution;
		obj.cf = num;
		obj.g = new global::r.d();
		obj.h = A_7.v;
		obj.l = A_7.u;
		obj.e = A_7.n();
		_ = null;
		a a10 = new a(A_0, A_4);
		((m)a10).a = m.a.t;
		a10.dp = A_5;
		a10.dq = A_3;
		a10.dt = A_1;
		a10.du = A_2;
		a10.g = A_7.t;
		a10.ds = t2;
		a10.dv = A_6;
		a10.l = A_7.u;
		a10.e = A_7.n();
		_ = null;
		if (sj(a10) != global::r.a.a)
		{
			throw new ah("Failed to start Monitoring");
		}
		if (sj(t2) != global::r.a.a)
		{
			throw new ah("Failed to start Monitoring Delay");
		}
		p9(A_7)[0].m2(254, new global::r.d(), A_4);
		_ = null;
		Guid a_ = A_7.o[0];
		uz(a_).x1().d(a_, new global::r.d.a(A_4, 0L));
	}

	public void us(Guid A_0)
	{
		ua(A_0).u.q(A_0: true);
	}

	public void qh(Guid A_0, global::r.d.a.b A_1)
	{
		if (wb(A_0))
		{
			throw new ah("Clear data operation not permitted when monitoring is active");
		}
		gx A_2 = null;
		Collection<g7> collection = m2(A_0, ref A_2);
		foreach (g7 item in collection)
		{
			item.wf();
		}
		A_2.ad.Clear();
		A_2.ag();
		collection[0].m2(byte.MaxValue, new global::r.d(), A_1);
		_ = null;
		collection[0].x1().d(A_2.o[0], new global::r.d.a(A_1, 0L));
	}

	public void m2(Guid A_0, string A_1, string A_2, string A_3, ref string A_4, global::r.d A_5, l A_6, global::r.d.a.b A_7, int A_8, hr A_9, bool A_10, h6.b A_11)
	{
		if (A_6 != null)
		{
			A_8 = 0;
		}
		uz(A_0).m2(A_1, A_2, A_3, ref A_4, A_5, A_6, A_6: true, A_8, A_7, A_9, A_10, A_11: false, A_11);
	}

	public long sn(string A_0)
	{
		return st(A_0).u1();
	}

	public d m2(Guid A_0, int A_1, global::f.b A_2, SpectromTempSensorLoc A_3, string A_4, ref string A_5, global::r.d A_6, global::r.d.a.b A_7)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4, ref A_5, A_6, A_7);
		return d.a;
	}

	public void sn(Guid A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		uy(A_0)[0].s3(A_1, A_2);
	}

	public void so(Guid A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		uy(A_0)[0].s4(A_1, A_2);
	}

	public void m2(Guid A_0, global::r.d A_1, double A_2, bool A_3, global::r.d.a.b A_4, int A_5)
	{
		gx A_6 = null;
		Collection<g7> collection = m2(A_0, ref A_6);
		Collection<global::r.d> collection2 = new Collection<global::r.d>();
		if (A_6 == null)
		{
			collection2.Add(A_1);
		}
		else
		{
			c A_7 = null;
			m2(A_0, A_1, null, collection, collection2, ref A_7);
		}
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				collection[num2].m2(collection2[num2], A_2, A_3, A_4, A_5);
			}
		}
	}

	public void m2(Guid A_0, global::r.d A_1, float[] A_2, bool A_3, global::r.d.a.b A_4, int A_5, bool A_6, global::r.c A_7, Point A_8, bool A_9)
	{
		gx A_10 = null;
		Collection<g7> collection = m2(A_0, ref A_10);
		Collection<global::r.d> collection2 = new Collection<global::r.d>();
		if (A_10 == null)
		{
			collection2.Add(A_1);
		}
		else
		{
			c A_11 = null;
			m2(A_0, A_1, null, collection, collection2, ref A_11);
		}
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				collection[num2].m2(collection2[num2], A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9);
			}
		}
	}

	public void m2(Guid A_0, global::r.d A_1, bool A_2, global::r.d.a.b A_3, global::r.c A_4, Point A_5)
	{
		gx A_6 = null;
		Collection<g7> collection = m2(A_0, ref A_6);
		Collection<global::r.d> collection2 = new Collection<global::r.d>();
		if (A_6 == null)
		{
			collection2.Add(A_1);
		}
		else
		{
			c A_7 = null;
			m2(A_0, A_1, null, collection, collection2, ref A_7);
		}
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				collection[num2].m2(collection2[num2], A_2, A_3, A_4, A_5);
			}
		}
	}

	public void m2(Guid A_0, global::r.d A_1, bool A_2, bool A_3, global::r.d.a.b A_4, global::r.c A_5)
	{
		gx A_6 = null;
		Collection<g7> collection = m2(A_0, ref A_6);
		Collection<global::r.d> collection2 = new Collection<global::r.d>();
		if (A_6 == null)
		{
			collection2.Add(A_1);
		}
		else
		{
			c A_7 = null;
			m2(A_0, A_1, null, collection, collection2, ref A_7);
		}
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				collection[num2].p9(collection2[num2], A_2, A_3, A_4, A_5);
			}
		}
	}

	public d p9(Guid A_0, global::r.d A_1, bool A_2, bool A_3, global::r.d.a.b A_4, global::r.c A_5)
	{
		gx A_6 = null;
		Collection<g7> collection = m2(A_0, ref A_6);
		Collection<global::r.d> collection2 = new Collection<global::r.d>();
		if (A_6 == null)
		{
			collection2.Add(A_1);
		}
		else
		{
			c A_7 = null;
			m2(A_0, A_1, null, collection, collection2, ref A_7);
		}
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				collection[num2].m2(collection2[num2], A_2, A_3, A_4, A_5);
			}
			return d.a;
		}
	}

	public d m2(Guid A_0, global::r.d A_1, bool A_2, global::r.d.a.b A_3, bool A_4, global::r.c A_5)
	{
		gx A_6 = null;
		Collection<g7> collection = m2(A_0, ref A_6);
		Collection<global::r.d> collection2 = new Collection<global::r.d>();
		if (A_6 == null)
		{
			collection2.Add(A_1);
		}
		else
		{
			c A_7 = null;
			m2(A_0, A_1, null, collection, collection2, ref A_7);
		}
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				collection[num2].m2(collection2[num2], A_2, A_3, A_4, A_5);
			}
			return d.a;
		}
	}

	public void m2(Guid A_0, global::r.d A_1, global::r.d.a.b A_2, global::r.c A_3)
	{
		gx A_4 = null;
		Collection<g7> collection = m2(A_0, ref A_4);
		Collection<global::r.d> collection2 = new Collection<global::r.d>();
		if (A_4 == null)
		{
			collection2.Add(A_1);
		}
		else
		{
			c A_5 = null;
			m2(A_0, A_1, null, collection, collection2, ref A_5);
		}
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				collection[num2].m2(collection2[num2], A_2, A_3);
			}
		}
	}

	public void p9(Guid A_0, global::r.d A_1, global::r.d.a.b A_2, global::r.c A_3)
	{
		gx A_4 = null;
		Collection<g7> collection = m2(A_0, ref A_4);
		Collection<global::r.d> collection2 = new Collection<global::r.d>();
		if (A_4 == null)
		{
			collection2.Add(A_1);
		}
		else
		{
			c A_5 = null;
			m2(A_0, A_1, null, collection, collection2, ref A_5);
		}
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				collection[num2].p9(collection2[num2], A_2, A_3);
			}
		}
	}

	public void m2(Guid A_0, global::r.d A_1, global::r.c A_2, global::r.d.a.b A_3)
	{
		gx A_4 = null;
		Collection<g7> collection = m2(A_0, ref A_4);
		Collection<global::r.d> collection2 = new Collection<global::r.d>();
		if (A_2 == null)
		{
			A_2 = new global::r.c();
		}
		if (A_4 == null)
		{
			collection2.Add(A_1);
		}
		else
		{
			c A_5 = null;
			m2(A_0, A_1, null, collection, collection2, ref A_5);
		}
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				collection[num2].m2(collection2[num2], A_2, A_3);
			}
		}
	}

	public void m2(string A_0, int A_1, bool A_2, int A_3, global::r.d.a.b A_4)
	{
		st(A_0).m2(A_1, A_2, A_3, A_4);
	}

	public hr m2(string A_0, int A_1, bool A_2, int A_3)
	{
		return st(A_0).m2(A_1, A_2, A_3);
	}

	public void m2(string A_0, int A_1, bool A_2, global::r.d.a.b A_3)
	{
		st(A_0).m2(A_1, A_2, A_3);
	}

	public hr m2(Guid A_0, int A_1, bool A_2)
	{
		return uz(A_0).m2(A_1, A_2);
	}

	public void p9(string A_0, int A_1, bool A_2, global::r.d.a.b A_3)
	{
		st(A_0).p9(A_1, A_2, A_3);
	}

	public hr m2(string A_0, int A_1, bool A_2)
	{
		return st(A_0).p9(A_1, A_2);
	}

	[SpecialName]
	public string m2(string A_0, int A_1, global::f.b A_2, int A_3)
	{
		return st(A_0).m2(A_1, A_2, A_3);
	}

	[SpecialName]
	public string m2(string A_0, int A_1, global::f.b A_2)
	{
		return st(A_0).qh(A_1, A_2);
	}

	public void m2(string A_0, int A_1, bool A_2, ref Collection<double[]> A_3, ref Collection<DateTime[]> A_4, ref int[] A_5)
	{
		st(A_0).m2(A_1, A_2, ref A_3, ref A_4, ref A_5);
	}

	[SpecialName]
	public string p9(string A_0, int A_1, bool A_2)
	{
		return st(A_0).qh(A_1, A_2);
	}

	public void ut(Guid A_0)
	{
		foreach (g7 item in uy(A_0))
		{
			item.wo();
		}
	}

	public void m2(Guid A_0, float A_1, float A_2, bool A_3, bool A_4, int A_5, bool A_6, ref bool A_7, ref string A_8, ref string A_9)
	{
		A_7 = true;
		bool A_10 = default(bool);
		foreach (g7 item in uy(A_0))
		{
			item.m2(A_1, A_2, A_3, A_4, A_5, A_6, ref A_10, ref A_8, ref A_9);
			if (!A_10)
			{
				A_7 = false;
			}
		}
	}

	public void qh(string A_0, int A_1, bool A_2, global::r.d.a.b A_3)
	{
		st(A_0).qh(A_1, A_2, A_3);
	}

	public hr qh(string A_0, int A_1, bool A_2)
	{
		return st(A_0).sj(A_1, A_2);
	}

	[SpecialName]
	public string p9(string A_0, int A_1, global::f.b A_2)
	{
		return st(A_0).sj(A_1, A_2);
	}

	[SpecialName]
	public bool uu(Guid A_0)
	{
		int[] array = uy(A_0)[0].ve();
		if (array.Length == 1)
		{
			return array[0] == 1;
		}
		return false;
	}

	protected g7 so(string A_0)
	{
		foreach (g7 item in t)
		{
			if (Operators.CompareString(item.zj(), A_0, TextCompare: false) == 0)
			{
				return item;
			}
		}
		return null;
	}

	protected g7 uv(Guid A_0)
	{
		foreach (g7 item in t)
		{
			if (item.zk() == A_0)
			{
				return item;
			}
		}
		return null;
	}

	protected long t8()
	{
		long result = v;
		checked
		{
			if (v < long.MaxValue)
			{
				v++;
				return result;
			}
			v = 0L;
			return result;
		}
	}

	protected gx uw(Guid A_0)
	{
		foreach (gx item in u)
		{
			foreach (Guid item2 in item.o)
			{
				if (item2 == A_0)
				{
					return item;
				}
			}
		}
		return null;
	}

	public Guid ux(Guid A_0)
	{
		return (uw(A_0) ?? throw new al("Measurement Module with guid=" + A_0.ToString() + " is not associated with a System")).n();
	}

	protected Collection<g7> uy(Guid A_0)
	{
		gx A_1 = null;
		return m2(A_0, ref A_1);
	}

	protected Collection<g7> p9(gx A_0)
	{
		if (A_0.r == null)
		{
			Collection<g7> collection = new Collection<g7>();
			collection = new Collection<g7>();
			foreach (Guid item2 in A_0.o)
			{
				g7 item = uv(item2);
				collection.Add(item);
			}
			A_0.r = collection;
		}
		return A_0.r;
	}

	protected Collection<g7> m2(Guid A_0, ref gx A_1)
	{
		A_1 = ua(A_0);
		if (A_1 != null)
		{
			return p9(A_1);
		}
		g7 g10 = uv(A_0);
		if (g10 == null)
		{
			throw new ak("Attempted to get nonexistent measModule-Requested GUID is " + A_0.ToString());
		}
		return new Collection<g7> { g10 };
	}

	protected g7 st(string A_0)
	{
		g7 g10 = so(A_0);
		if (g10 != null)
		{
			return g10;
		}
		throw new ak("Attempted to get nonexistent measModule-Requested GUID is " + A_0);
	}

	protected g7 uz(Guid A_0)
	{
		g7 g10 = uv(A_0);
		if (g10 != null)
		{
			return g10;
		}
		throw new ak("Attempted to get nonexistent measModule-Requested GUID is " + A_0.ToString());
	}

	protected bool s3(string A_0)
	{
		if (so(A_0) != null)
		{
			return true;
		}
		return false;
	}

	protected void m2(Guid A_0, global::r.d A_1, l A_2, Collection<g7> A_3, Collection<global::r.d> A_4, ref c A_5)
	{
		A_5 = new c();
		long a_ = t8();
		c obj = A_5;
		obj.a = a_;
		obj.c = A_2;
		obj.d = A_1;
		obj.g = A_0;
		_ = null;
		int count = A_3.Count;
		checked
		{
			for (int num = 1; num <= count; num++)
			{
				global::r.d d10 = new global::r.d(a_);
				d10.d((global::r.d.b)p9);
				A_5.b++;
				A_4.Add(d10);
			}
			bool flag = false;
			try
			{
				if (Monitor.TryEnter(w, 500))
				{
					flag = true;
					w.Add(A_5);
				}
				else
				{
					ab8().c(fz.b.b, "Failed to obtain lock on mMeasSystemUnfinishedAggregateTasks in PrepareToAttemptOnMultipleMMs", Environment.StackTrace);
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(w);
				}
			}
		}
	}

	protected void p9(global::r.d.a A_0)
	{
		bool flag = false;
		checked
		{
			try
			{
				if (Monitor.TryEnter(w, 500))
				{
					flag = true;
					int num = w.Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						c c10 = w[num2];
						if (c10.a == A_0.a7())
						{
							if (c10.e == null)
							{
								c10.e = A_0;
							}
							else
							{
								c10.e.a(A_0);
							}
							c10.b--;
							if (A_0.a != global::r.d.a.a.a && c10.c != null)
							{
								c10.c.q(A_0: true);
							}
							if (c10.b == 0)
							{
								w.Remove(c10);
								c10.f.Set();
								c10.d.d(c10.g, c10.e);
							}
							break;
						}
					}
				}
				else
				{
					ab8().c(fz.b.b, "Failed to obtain lock on mMeasSystemUnfinishedAggregateTasks in AggregateTaskCompletionHandler", Environment.StackTrace);
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(w);
				}
			}
		}
	}

	protected void qh(global::r.d.a A_0)
	{
		uw(A_0.c).s.d(default(Guid), A_0);
	}

	protected void sj(global::r.d.a A_0)
	{
		gx gx2 = ua(A_0.c);
		if (gx2 != null)
		{
			g7 g10 = p9(gx2)[0];
			byte b10 = g10.xh();
			g10.m2((byte)(b10 | 1), new global::r.d(), global::r.d.a.b.b);
			g10.x1().d(g10.zk(), new global::r.d.a(A_0.a8(), 0L));
			g10 = null;
		}
	}

	protected void qh(gx A_0)
	{
		Collection<g7> collection = p9(A_0);
		if (collection != null && collection[0] != null)
		{
			collection[0].st(A_0.l(), global::r.d.a.b.b);
		}
	}

	protected void sj(gx A_0)
	{
		if (wb(A_0.n()))
		{
			global::r.d.a a10 = new global::r.d.a(global::r.d.a.b.b, 0L);
			a10.a = global::r.d.a.a.a;
			a10.c = A_0.n();
			A_0.s.d(default(Guid), a10);
		}
		else if (wf(A_0.n()))
		{
			m2(A_0.n(), global::e.a().SampleID, global::e.a().OperatorID, global::e.a().DisplaySignificantDigits, global::r.d.a.b.b, A_5: true, !A_0.y);
		}
	}

	protected void sm(gx A_0)
	{
		if (wb(A_0.n()))
		{
			A_0.u.q(A_0: true);
		}
	}

	protected void sm(global::r.d.a A_0)
	{
		gx A_1 = null;
		Collection<g7> collection = m2(A_0.c, ref A_1);
		int num = checked(A_1.ad.Count - 1);
		bool flag = false;
		foreach (g7 item in collection)
		{
			if (item.te(num) && A_0 is g.a)
			{
				item.m2(num, (g.a)A_0);
			}
			if (item.sj(num, num))
			{
				flag = true;
				break;
			}
		}
		bool flag2 = true;
		Collection<m> collection2 = zy();
		Collection<m> collection3 = zz();
		lock (collection2)
		{
			lock (collection3)
			{
				if (collection2.Count != 0 || collection3.Count != 0)
				{
					foreach (m item2 in collection2)
					{
						m.TaskExecutionType taskExecutionType = item2.d;
						if (taskExecutionType == m.TaskExecutionType.System)
						{
							a a10 = (a)item2;
							if (((m)a10).a == m.a.t && a10.dr == A_1.n() && a10.l != null)
							{
								flag2 = false;
								break;
							}
							a10 = null;
						}
					}
					if (flag2)
					{
						foreach (m item3 in collection3)
						{
							m.TaskExecutionType taskExecutionType2 = item3.d;
							if (taskExecutionType2 == m.TaskExecutionType.System)
							{
								a a11 = (a)item3;
								if (((m)a11).a == m.a.t && a11.dr == A_1.n() && a11.l != null)
								{
									flag2 = false;
									break;
								}
								a11 = null;
							}
						}
					}
				}
			}
		}
		g7 g10 = collection[0];
		byte b10 = g10.xh();
		byte b11 = b10;
		b11 = (byte)((!flag) ? (b10 | 2) : (b10 & 0xFD));
		if (flag2)
		{
			b11 |= 1;
		}
		if (b10 != b11)
		{
			g10.m2(b11, new global::r.d(), global::r.d.a.b.b);
		}
		g10 = null;
		gx gx2 = A_1;
		Collection<g.a> A_2 = null;
		Collection<Collection<float[]>> A_3 = null;
		float A_4 = default(float);
		m2(A_1, num, ref A_4, ref A_3, ref A_2);
		string text = gx.j(A_2);
		if (gx2.z)
		{
			gx2.j(ab8(), A_4, A_3, text);
		}
		gx2.j(A_4, A_3, text);
		gx2 = null;
	}

	public global::r.d u0(Guid A_0)
	{
		return uz(A_0).xt();
	}

	public global::r.c s4(string A_0)
	{
		return st(A_0).xu();
	}

	[SpecialName]
	public global::r.c u1(Guid A_0)
	{
		return uz(A_0).xv();
	}

	[SpecialName]
	public global::r.c s6(string A_0)
	{
		return st(A_0).xw();
	}

	[SpecialName]
	public global::r.c u2(Guid A_0)
	{
		return ua(A_0).v;
	}

	public global::r.d u3(Guid A_0)
	{
		return uz(A_0).xx();
	}

	public global::r.d u4(Guid A_0)
	{
		return uz(A_0).xy();
	}

	[SpecialName]
	public global::r.d u5(Guid A_0)
	{
		return uz(A_0).xz();
	}

	public global::r.d u6(Guid A_0)
	{
		return uz(A_0).x0();
	}

	public global::r.d u7(Guid A_0)
	{
		gx gx2 = ua(A_0);
		if (gx2 == null)
		{
			return uz(A_0).x1();
		}
		return gx2.s;
	}

	public global::r.d u8(Guid A_0)
	{
		return uz(A_0).x2();
	}

	[SpecialName]
	public bool u9(Guid A_0)
	{
		return ua(A_0).ab;
	}

	[SpecialName]
	public void qh(Guid A_0, bool A_1)
	{
		ua(A_0).ab = A_1;
	}

	[SpecialName]
	public string va(Guid A_0)
	{
		return ua(A_0).ac;
	}

	[SpecialName]
	public void m2(Guid A_0, string A_1)
	{
		ua(A_0).ac = A_1;
	}

	public global::r.d vb(Guid A_0)
	{
		return ua(A_0).t;
	}

	public void m2(Guid A_0, gx.b A_1)
	{
		ua(A_0).j(A_1);
	}

	public d m2(string A_0, string A_1, string A_2, hr.b A_3, int A_4, string A_5)
	{
		d result = default(d);
		try
		{
			if (st(A_0).m2(A_1, A_2, A_3, A_4) != gu.ErrPublic.None)
			{
				result = d.d;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = d.b;
			ab8().c(fz.b.b, "Exception caught in MeasModuleMgr.SaveIndexFile().", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[SpecialName]
	public cg t9()
	{
		return af;
	}

	[SpecialName]
	public string[] ua()
	{
		return ae.f();
	}

	[SpecialName]
	public eu m2(int A_0)
	{
		return ae.e(A_0);
	}

	[SpecialName]
	public eu s8(string A_0)
	{
		return ae.e(A_0);
	}

	[SpecialName]
	public Collection<eu> ub()
	{
		return ae.g();
	}

	[SpecialName]
	public string tb(string A_0)
	{
		return st(A_0).zt();
	}

	[SpecialName]
	public es tc(string A_0)
	{
		return st(A_0).zr();
	}

	[SpecialName]
	public cf td(string A_0)
	{
		return st(A_0).zs();
	}

	[SpecialName]
	public bool te(string A_0)
	{
		return st(A_0).x5();
	}

	[SpecialName]
	public bool tf(string A_0)
	{
		return st(A_0).x8();
	}

	[SpecialName]
	public bool tg(string A_0)
	{
		return st(A_0).x6();
	}

	[SpecialName]
	public global::r.d.a.b th(string A_0)
	{
		return st(A_0).x9();
	}

	[SpecialName]
	public bool vc(Guid A_0)
	{
		return uz(A_0).ya();
	}

	public void m2(Guid A_0, ref int A_1, ref int A_2)
	{
		uz(A_0).m2(ref A_1, ref A_2);
	}

	[SpecialName]
	public bool ti(string A_0)
	{
		return st(A_0).x7();
	}

	[SpecialName]
	public bool vd(Guid A_0)
	{
		return uy(A_0)[0].zn();
	}

	[SpecialName]
	public bool ve(Guid A_0)
	{
		return uy(A_0)[0].zo();
	}

	[SpecialName]
	public g2.a vf(Guid A_0)
	{
		return uy(A_0)[0].zp();
	}

	[SpecialName]
	public g2 vg(Guid A_0)
	{
		return uz(A_0).zq();
	}

	[SpecialName]
	public float vh(Guid A_0)
	{
		return uy(A_0)[0].vn();
	}

	[SpecialName]
	public void m2(Guid A_0, float A_1)
	{
		foreach (g7 item in uy(A_0))
		{
			item.p9(A_1);
		}
	}

	[SpecialName]
	public string vi(Guid A_0)
	{
		return uy(A_0)[0].vw();
	}

	[SpecialName]
	public int vj(Guid A_0)
	{
		return uy(A_0)[0].vx();
	}

	[SpecialName]
	public int vk(Guid A_0)
	{
		return uy(A_0)[0].vy();
	}

	[SpecialName]
	public bool[] vl(Guid A_0)
	{
		return uy(A_0)[0].vo();
	}

	[SpecialName]
	public int m2(Guid A_0, global::h.f A_1)
	{
		return uy(A_0)[0].p9(A_1);
	}

	[SpecialName]
	public global::h.f[] vm(Guid A_0)
	{
		return uy(A_0)[0].vp();
	}

	[SpecialName]
	public float[] vn(Guid A_0)
	{
		return uy(A_0)[0].vq();
	}

	[SpecialName]
	public bool[] vo(Guid A_0)
	{
		return uy(A_0)[0].vr();
	}

	[SpecialName]
	public bool[] vp(Guid A_0)
	{
		return uy(A_0)[0].vs();
	}

	[SpecialName]
	public a9.a vq(Guid A_0)
	{
		return uy(A_0)[0].vt();
	}

	[SpecialName]
	public a9.b vr(Guid A_0)
	{
		return uy(A_0)[0].vu();
	}

	[SpecialName]
	public bool vs(Guid A_0)
	{
		return uy(A_0)[0].vv();
	}

	[SpecialName]
	public Collection<string> vt(Guid A_0)
	{
		return uz(A_0).wk();
	}

	[SpecialName]
	public bool vu(Guid A_0)
	{
		return uz(A_0).v5();
	}

	[SpecialName]
	public bool vv(Guid A_0)
	{
		return uz(A_0).u0();
	}

	[SpecialName]
	public bool vw(Guid A_0)
	{
		bool flag = default(bool);
		bool flag2 = default(bool);
		foreach (g7 item in uy(A_0))
		{
			if (item.vk())
			{
				flag = true;
			}
			else
			{
				flag2 = true;
			}
		}
		if (flag && flag2)
		{
			throw new ApplicationException("Illegal system configuration. Channels in a system must all have matching DualMeasCapable setting");
		}
		return flag;
	}

	[SpecialName]
	public bool vx(Guid A_0)
	{
		bool flag = default(bool);
		bool flag2 = default(bool);
		foreach (g7 item in uy(A_0))
		{
			if (item.vj())
			{
				flag = true;
			}
			else
			{
				flag2 = true;
			}
		}
		if (flag && flag2)
		{
			throw new ApplicationException("Illegal system configuration. Channels in a system must all have matching MultiMeasCapable setting");
		}
		return flag;
	}

	[SpecialName]
	public string p9(string A_0, h6.b A_1, int A_2, global::f.b A_3)
	{
		return st(A_0).p9(A_1, A_2, A_3);
	}

	[SpecialName]
	public Collection m2(string A_0, int A_1)
	{
		return st(A_0).tb(A_1);
	}

	[SpecialName]
	public bool m2(Guid A_0, h6.b A_1, int A_2, int A_3, SpectromTempSensorLoc A_4)
	{
		return uz(A_0).m2(A_1, A_2, A_3, A_4);
	}

	[SpecialName]
	public bool m2(Guid A_0, h6.b A_1, int A_2, global::f.b A_3, SpectromTempSensorLoc A_4)
	{
		return uz(A_0).m2(A_1, A_2, A_3, A_4);
	}

	[SpecialName]
	public bool vy(Guid A_0)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.vm())
			{
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	public bool qh(string A_0, h6.b A_1, int A_2, global::f.b A_3)
	{
		return st(A_0).qh(A_1, A_2, A_3);
	}

	[SpecialName]
	public global::h vz(Guid A_0)
	{
		return uy(A_0)[0].zu();
	}

	public bool sj(Guid A_0, bool A_1)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.s4(A_1))
			{
				return false;
			}
		}
		return true;
	}

	public bool sm(Guid A_0, bool A_1)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.s3(A_1))
			{
				return false;
			}
		}
		return true;
	}

	public void m2(Guid A_0, bool A_1, bool A_2, bool A_3, bool A_4, global::r.d A_5, global::r.d.a.b A_6)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4, A_5, A_6);
	}

	public void p9(Guid A_0, bool A_1, global::r.d A_2, global::r.d.a.b A_3)
	{
		uz(A_0).qh(A_1, A_2, A_3);
	}

	public hr.b[] tj(string A_0)
	{
		return st(A_0).vz();
	}

	public hr.b[] v0(Guid A_0)
	{
		return uy(A_0)[0].v0();
	}

	public bool[] v1(Guid A_0)
	{
		Collection<g7> collection = uy(A_0);
		checked
		{
			bool[] array = new bool[collection.Count - 1 + 1];
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				array[num2] = collection[num2].v1();
			}
			return array;
		}
	}

	public bool m2(string A_0, hr.b[] A_1)
	{
		return st(A_0).m2(A_1);
	}

	public void m2(Guid A_0, string A_1, bool A_2)
	{
		gx gx2 = ua(A_0);
		if (gx2 == null)
		{
			uz(A_0).m2(A_1, A_2);
			return;
		}
		foreach (Guid item in gx2.o)
		{
			uz(item).m2(A_1, A_2);
		}
	}

	public bool tl(string A_0)
	{
		return st(A_0).zv();
	}

	public bool v2(Guid A_0)
	{
		return uz(A_0).u2();
	}

	public bool v3(Guid A_0)
	{
		return uv(A_0)?.ws() ?? false;
	}

	public bool v4(Guid A_0)
	{
		return uv(A_0)?.wt() ?? false;
	}

	public bool uc()
	{
		foreach (g7 item in t)
		{
			if (!item.wu())
			{
				return false;
			}
		}
		return true;
	}

	public bool v5(Guid A_0)
	{
		return uz(A_0).wi();
	}

	public bool v6(Guid A_0)
	{
		return uz(A_0).wj();
	}

	public void st(Guid A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		uz(A_0).m2(A_1, A_2);
	}

	public void m2(Guid A_0, ref FMLegacyAllSystemTypes A_1, ref int A_2)
	{
		uy(A_0)[0].m2(ref A_1, ref A_2);
	}

	public bool v8(Guid A_0)
	{
		gx A_1 = null;
		Collection<g7> collection = m2(A_0, ref A_1);
		foreach (g7 item in collection)
		{
			cd.b[] array = item.wd();
			if (array != null && array.Length > 0)
			{
				return true;
			}
		}
		return false;
	}

	public bool v9(Guid A_0)
	{
		return ua(A_0) != null;
	}

	[SpecialName]
	public Guid wa(Guid A_0)
	{
		return uy(A_0)[0].zk();
	}

	public bool wb(Guid A_0)
	{
		Collection<g7> A_1 = null;
		return m2(A_0, ref A_1);
	}

	protected bool m2(Guid A_0, ref Collection<g7> A_1)
	{
		gx A_2 = null;
		A_1 = m2(A_0, ref A_2);
		bool flag = false;
		bool flag2 = false;
		try
		{
			if (!Monitor.TryEnter(zy(), 500))
			{
				return true;
			}
			flag = true;
			Collection<m> collection = zy();
			if (!Monitor.TryEnter(zz(), 500))
			{
				return true;
			}
			flag2 = true;
			Collection<m> collection2 = zz();
			if ((collection.Count == 0) & (collection2.Count == 0))
			{
				return false;
			}
			foreach (m item in collection)
			{
				m.TaskExecutionType taskExecutionType = item.d;
				if (taskExecutionType == m.TaskExecutionType.System)
				{
					a a10 = (a)item;
					if (((m)a10).a == m.a.t && a10.dr == A_0)
					{
						return true;
					}
					a10 = null;
				}
			}
			foreach (m item2 in collection2)
			{
				m.TaskExecutionType taskExecutionType2 = item2.d;
				if (taskExecutionType2 == m.TaskExecutionType.System)
				{
					a a11 = (a)item2;
					if (((m)a11).a == m.a.t && a11.dr == A_0)
					{
						return true;
					}
					a11 = null;
				}
			}
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(zy());
			}
			if (flag2)
			{
				Monitor.Exit(zz());
			}
		}
		return false;
	}

	public string wc(Guid A_0)
	{
		return ua(A_0).q;
	}

	public string wd(Guid A_0)
	{
		return uy(A_0)[0].vc();
	}

	public bool we(Guid A_0)
	{
		return ua(A_0).x;
	}

	public bool wf(Guid A_0)
	{
		Collection<g7> A_1 = null;
		if (m2(A_0, ref A_1))
		{
			return false;
		}
		foreach (g7 item in A_1)
		{
			if (item.yb())
			{
				return false;
			}
		}
		bool A_2 = default(bool);
		bool flag = m2(A_0, A_1: false, ref A_2);
		return (flag || A_2) && st(A_0, A_1: false) && s3(A_0, A_1: false) && (!flag || (sj(A_0, A_1: false) && sm(A_0, A_1: false)));
	}

	public bool wg(Guid A_0)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.yc())
			{
				return false;
			}
		}
		return true;
	}

	public bool wh(Guid A_0)
	{
		if (uz(A_0).zi() && uz(A_0).x8())
		{
			return false;
		}
		gx gx2 = uw(A_0);
		if (gx2 == null)
		{
			gx2 = ua(A_0);
		}
		if (gx2 == null)
		{
			return true;
		}
		return !wb(gx2.n());
	}

	public bool sn(Guid A_0, bool A_1)
	{
		return uz(A_0).t0(A_1);
	}

	public bool m2(Guid A_0, ref string A_1)
	{
		return uz(A_0).m2(ref A_1);
	}

	public bool m2(eo.a A_0)
	{
		return aj.aw(A_0);
	}

	public bool p9(eo.a A_0)
	{
		return aj.ax(A_0);
	}

	public bool qh(eo.a A_0)
	{
		return aj.a3(A_0);
	}

	public bool sj(eo.a A_0)
	{
		return aj.a0(A_0);
	}

	public bool wi(Guid A_0)
	{
		return uz(A_0).wy();
	}

	public bool wj(Guid A_0)
	{
		return uz(A_0).wx();
	}

	public bool ud()
	{
		return aj.a7();
	}

	public bool wk(Guid A_0)
	{
		return uz(A_0).w1();
	}

	public bool sm(eo.a A_0)
	{
		return aj.a1(A_0);
	}

	public bool ue()
	{
		return aj.a0();
	}

	public bool sn(eo.a A_0)
	{
		return aj.az(A_0);
	}

	public bool wl(Guid A_0)
	{
		return uz(A_0).w0();
	}

	public bool so(eo.a A_0)
	{
		return aj.av(A_0);
	}

	public bool wm(Guid A_0)
	{
		return uz(A_0).wz();
	}

	[SpecialName]
	public bool uf()
	{
		return aj.a2();
	}

	[SpecialName]
	public bool ug()
	{
		return aj.a1();
	}

	public float uh()
	{
		return aj.az();
	}

	public string ui()
	{
		return aj.bb();
	}

	public bool uj()
	{
		return aj.bl();
	}

	public bool uk()
	{
		return aj.bp();
	}

	public bool ul()
	{
		return aj.a8();
	}

	public bool um()
	{
		return aj.bs();
	}

	public bool un()
	{
		return aj.bt();
	}

	public bool uo()
	{
		return aj.bv();
	}

	public bool up()
	{
		if (ak)
		{
			return aj.bn();
		}
		i7 obj = a2.a;
		string a_ = i7.e();
		string A_ = null;
		string[] A_2 = null;
		if (obj.c(a_, i7.e.g, ref A_, ref A_2))
		{
			return a2.a.c(null, "SaSwSn", i7.e.ag);
		}
		return false;
	}

	public bool uq()
	{
		return aj.bh();
	}

	public bool ur()
	{
		return aj.bj();
	}

	public bool us()
	{
		return aj.bk();
	}

	public bool ut()
	{
		return aj.bm();
	}

	public bool uu()
	{
		return aj.bo();
	}

	public bool uv()
	{
		return aj.a5();
	}

	public eo uw()
	{
		return aj;
	}

	public void m2(string A_0, string A_1 = "")
	{
		foreach (g7 item in t)
		{
			item.m2(A_0, A_1);
		}
	}

	public bool m2(Guid A_0, bool A_1, ref bool A_2)
	{
		bool flag = true;
		A_2 = true;
		bool A_3 = default(bool);
		foreach (g7 item in uy(A_0))
		{
			flag &= item.m2(A_1, ref A_3);
			A_2 = A_2 && A_3;
		}
		return flag;
	}

	public DateTime so(Guid A_0, bool A_1)
	{
		Collection<g7> collection = uy(A_0);
		DateTime dateTime = collection[0].tb(A_1);
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 1; num2 <= num; num2++)
			{
				DateTime dateTime2 = collection[num2].tb(A_1);
				if (DateTime.Compare(dateTime2, dateTime) < 0)
				{
					dateTime = dateTime2;
				}
			}
			return dateTime;
		}
	}

	public void m2(Guid A_0, global::r.d.a.b A_1, bool A_2)
	{
		foreach (g7 item in uy(A_0))
		{
			item.m2(A_1, 0L, A_2);
		}
	}

	public bool t0(string A_0)
	{
		return st(A_0).w2();
	}

	public bool qh(string A_0, int A_1, global::f.b A_2)
	{
		return st(A_0).p9(A_2, A_1);
	}

	public bool st(Guid A_0, bool A_1)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.tc(A_1))
			{
				return false;
			}
		}
		return true;
	}

	public bool sj(string A_0, int A_1, global::f.b A_2)
	{
		return st(A_0).qh(A_2, A_1);
	}

	public bool s3(Guid A_0, bool A_1)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.td(A_1))
			{
				return false;
			}
		}
		return true;
	}

	public bool sm(string A_0, int A_1, global::f.b A_2)
	{
		return st(A_0).sj(A_2, A_1);
	}

	public bool s4(Guid A_0, bool A_1)
	{
		return uz(A_0).te(A_1);
	}

	public bool sn(string A_0, int A_1, global::f.b A_2)
	{
		return st(A_0).sm(A_2, A_1);
	}

	public bool so(string A_0, int A_1, global::f.b A_2)
	{
		return st(A_0).sn(A_2, A_1);
	}

	public bool sm(Guid A_0, int A_1, global::f.b A_2)
	{
		return uz(A_0).so(A_2, A_1);
	}

	public bool t5(string A_0)
	{
		return st(A_0).w3();
	}

	public bool st(string A_0, int A_1, global::f.b A_2)
	{
		return st(A_0).st(A_2, A_1);
	}

	public bool s6(Guid A_0, bool A_1)
	{
		return uz(A_0).tf(A_1);
	}

	public bool s3(string A_0, int A_1, global::f.b A_2)
	{
		return st(A_0).s3(A_2, A_1);
	}

	public bool wn(Guid A_0)
	{
		return uz(A_0).w6();
	}

	public bool wo(Guid A_0)
	{
		return uz(A_0).w4();
	}

	[SpecialName]
	public string m2(Guid A_0, global::h.f A_1, bool A_2)
	{
		return uy(A_0)[0].m2(A_1, A_2);
	}

	public void so(Guid A_0, int A_1)
	{
		foreach (g7 item in uy(A_0))
		{
			item.ti(A_1);
		}
	}

	[SpecialName]
	public bool s8(Guid A_0, bool A_1)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.tg(A_1))
			{
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	public void m2(Guid A_0, bool A_1, bool A_2)
	{
		foreach (g7 item in uy(A_0))
		{
			item.sj(A_1, A_2);
		}
	}

	[SpecialName]
	public bool p9(Guid A_0, string A_1)
	{
		return uy(A_0)[0].p9(A_1);
	}

	public bool m2(Guid A_0, int A_1, string A_2, bool A_3)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.m2(A_1, A_2, A_3))
			{
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	public int tb(Guid A_0, bool A_1)
	{
		return uy(A_0)[0].th(A_1);
	}

	public void wp(Guid A_0)
	{
		foreach (g7 item in uy(A_0))
		{
			item.w7();
		}
	}

	public bool tc(Guid A_0, bool A_1)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.ti(A_1))
			{
				return false;
			}
		}
		return true;
	}

	public bool wq(Guid A_0)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.w9())
			{
				return false;
			}
		}
		return true;
	}

	public bool wr(Guid A_0)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.w8())
			{
				return false;
			}
		}
		return true;
	}

	public bool qh(Guid A_0, string A_1)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.qh(A_1))
			{
				return false;
			}
		}
		return true;
	}

	public bool td(Guid A_0, bool A_1)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.tj(A_1))
			{
				return false;
			}
		}
		return true;
	}

	public bool ws(Guid A_0)
	{
		return uz(A_0).xb();
	}

	public bool wt(Guid A_0)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.xc())
			{
				return false;
			}
		}
		return true;
	}

	public bool s4(string A_0, int A_1, global::f.b A_2)
	{
		return st(A_0).s4(A_2, A_1);
	}

	public double te(Guid A_0, bool A_1)
	{
		return uz(A_0).tl(A_1);
	}

	public hg t6(string A_0)
	{
		return st(A_0).zg();
	}

	public hg wu(Guid A_0)
	{
		gx A_1 = null;
		return p9(A_0, ref A_1);
	}

	public void m2(Guid A_0, hg A_1, global::r.d A_2, bool A_3)
	{
		uz(A_0).m2(A_1, A_2, A_3);
	}

	protected hg p9(Guid A_0, ref gx A_1)
	{
		return m2(A_0, ref A_1)[0].zg();
	}

	public he wv(Guid A_0)
	{
		return uz(A_0).zh();
	}

	public bool ww(Guid A_0)
	{
		return uz(A_0).zi();
	}

	public hg wx(Guid A_0)
	{
		gx a_ = ua(A_0);
		return m2(A_0, a_);
	}

	public hg m2(Guid A_0, gx A_1)
	{
		return st(A_1.o[0].ToString()).v8();
	}

	public int m2(Guid A_0, ref long A_1)
	{
		Collection<g7> A_2 = null;
		return m2(A_0, ref A_2, ref A_1);
	}

	protected int m2(Guid A_0, ref Collection<g7> A_1, ref long A_2)
	{
		int num = 0;
		A_1 = uy(A_0);
		num = A_1[0].m2(ref A_2);
		checked
		{
			int num2 = A_1.Count - 1;
			for (int num3 = 1; num3 <= num2; num3++)
			{
				g7 obj = A_1[num3];
				long A_3 = 0L;
				int num4 = obj.m2(ref A_3);
				if (num4 < num)
				{
					num = num4;
				}
			}
			return num;
		}
	}

	public void m2(Guid A_0, ref int[] A_1, ref float[] A_2, ref Collection<Collection<float[]>> A_3, ref Collection<cd.b[]> A_4, ref Collection<g.a[]> A_5)
	{
		gx gx2 = ua(A_0);
		Collection<g7> A_6 = null;
		long A_7 = 0L;
		checked
		{
			int num = m2(A_0, ref A_6, ref A_7) - 1;
			if (num >= 0)
			{
				A_2 = new float[num + 1];
				A_3 = new Collection<Collection<float[]>>();
				A_4 = new Collection<cd.b[]>();
				A_5 = new Collection<g.a[]>();
				lock (gx2.ad)
				{
					Collection<float> collection = gx2.ad;
					int num2 = num;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						A_2[num3] = collection[num3];
					}
					collection = null;
				}
				Collection<int> collection2 = A_6[0].wc();
				foreach (g7 item in A_6)
				{
					A_3.Add(item.tc(num));
					A_4.Add(item.wd());
					A_5.Add(item.we());
				}
				for (int num4 = collection2.Count - 1; num4 >= 0; num4 += -1)
				{
					bool flag = true;
					int num5 = A_3.Count - 1;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						if (A_3[num6][num4] != null && A_3[num6][num4].Length - 1 >= num)
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						int num7 = A_3.Count - 1;
						for (int num8 = 0; num8 <= num7; num8++)
						{
							A_3[num8].RemoveAt(num4);
						}
						collection2.Remove(num4);
					}
				}
				A_1 = new int[collection2.Count - 1 + 1];
				int num9 = collection2.Count - 1;
				for (int num10 = 0; num10 <= num9; num10++)
				{
					A_1[num10] = collection2[num10];
				}
			}
			else
			{
				A_2 = null;
				A_3 = null;
				A_4 = null;
				A_5 = null;
			}
		}
	}

	public void m2(Guid A_0, ref double[] A_1, ref Collection<cd.b[]> A_2, ref Collection<g.a[]> A_3)
	{
		gx A_4 = null;
		Collection<g7> collection = m2(A_0, ref A_4);
		long A_5 = 0L;
		checked
		{
			int num = m2(A_0, ref A_5) - 1;
			if (num >= 0)
			{
				A_2 = new Collection<cd.b[]>();
				A_3 = new Collection<g.a[]>();
				foreach (g7 item in collection)
				{
					A_2.Add(item.wd());
					A_3.Add(item.we());
				}
				A_1 = new double[num + 1];
				lock (A_4.ad)
				{
					Collection<float> collection2 = A_4.ad;
					int num2 = num;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						A_1[num3] = collection2[num3];
					}
					collection2 = null;
					return;
				}
			}
			A_2 = null;
			A_3 = null;
		}
	}

	public void m2(Guid A_0, int A_1, int A_2, ref double[] A_3, ref Collection<double[]> A_4, ref bool A_5, ref hg A_6, ref g.a A_7, ref int A_8, ref float A_9, ref int A_10, ref string A_11, ref long A_12)
	{
		gx gx2 = ua(A_0);
		Collection<g7> A_13 = null;
		checked
		{
			int num = m2(A_0, ref A_13, ref A_12) - 1;
			int num2 = A_13.Count - 1;
			if (num >= 0)
			{
				A_3 = new double[num - A_2 + 1];
				g.a A_14 = null;
				lock (gx2.ad)
				{
					Collection<float> collection = gx2.ad;
					int num3 = num;
					for (int num4 = A_2; num4 <= num3; num4++)
					{
						A_3[num4 - A_2] = collection[num4];
					}
					collection = null;
				}
				A_4 = new Collection<double[]>();
				A_7 = null;
				int num5 = num2;
				int A_15 = default(int);
				for (int num6 = 0; num6 <= num5; num6++)
				{
					g7 g10 = A_13[num6];
					A_4.Add(g10.m2(A_1, A_2, num));
					g10.m2(num, ref A_14, ref A_15);
					if (A_14 != null && (A_7 == null || A_15 > A_10))
					{
						A_7 = A_14;
						A_10 = A_15;
						lock (gx2.ad)
						{
							A_9 = gx2.ad[A_15];
						}
						A_8 = num6;
					}
				}
				A_11 = gx2.m();
			}
			else
			{
				A_3 = null;
				A_4 = null;
				A_7 = null;
				A_11 = null;
			}
			A_5 = false;
			A_6 = A_13[0].v8();
		}
	}

	protected void m2(gx A_0, int A_1, ref float A_2, ref Collection<Collection<float[]>> A_3, ref Collection<g.a> A_4)
	{
		A_3 = new Collection<Collection<float[]>>();
		A_4 = new Collection<g.a>();
		lock (A_0.ad)
		{
			A_2 = A_0.ad[A_1];
		}
		foreach (g7 item in A_0.r)
		{
			A_3.Add(item.td(A_1));
			A_4.Add(item.tf(A_1));
		}
	}

	public b5 ux()
	{
		return al;
	}

	[SpecialName]
	public g2.b wy(Guid A_0)
	{
		if (wz(A_0))
		{
			return g2.b.b;
		}
		return g2.b.a;
	}

	[SpecialName]
	public bool wz(Guid A_0)
	{
		foreach (gy item in ai.i())
		{
			if (item.y() == A_0)
			{
				return item.ag() && g2.k(uz(A_0).zp());
			}
		}
		return false;
	}

	public void m2(Guid A_0, global::r.d.a.b A_1, hg.j A_2)
	{
		hg hg2 = null;
		foreach (gy item in ai.i())
		{
			if (!(item.y() == A_0))
			{
				continue;
			}
			item.v(A_0: true);
			hg2 = uz(A_0).zg();
			string A_3 = "";
			if (!e4.a(e4.aa() + item.af(), ref A_3))
			{
				ab8().c(fz.b.b, "Unable to Retrieve Recipe Data From Template.");
				continue;
			}
			A_3 = hg.bz() + A_3;
			bool flag = Operators.CompareString(Path.GetExtension(A_3), ".fitra", TextCompare: false) == 0;
			Rectangle bounds = Screen.AllScreens[0].Bounds;
			if (!hg.bu(ref hg2, ref A_3, A_2, sj((eo.a)null) && flag, sn(), A_1, ab8(), A_1 == global::r.d.a.b.a, new Point(bounds.Width / 2, bounds.Height / 2), global::e.a().OperatorID, g2.b.b, !xb(A_0), xq(A_0), A_13: false))
			{
				ab8().c(fz.b.b, "Error loading recipe - using default");
				hg.bu(hg2, A_2, sj((eo.a)null) && flag, sn(), A_1, ab8(), g2.b.b, !xb(A_0), A_8: false);
			}
		}
	}

	public void w0(Guid A_0)
	{
		foreach (gy item in ai.i())
		{
			if (item.y() == A_0)
			{
				item.v(A_0: false);
			}
		}
	}

	[SpecialName]
	public string t7(string A_0)
	{
		string result = "";
		try
		{
			foreach (gy item in ai.i())
			{
				if (Operators.CompareString(item.x(), A_0, TextCompare: false) == 0)
				{
					result = item.af();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ab8().c(fz.b.b, "Exception caught in MeasModuleMgr.TemplateName().", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[SpecialName]
	public void p9(string A_0, string A_1)
	{
		try
		{
			foreach (gy item in ai.i())
			{
				if (Operators.CompareString(item.x(), A_0, TextCompare: false) == 0)
				{
					item.w(A_1);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ab8().c(fz.b.b, "Exception caught in MeasModuleMgr.TemplateName().", a_);
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	public hd uy()
	{
		return ah;
	}

	public bool w1(Guid A_0)
	{
		return uy(A_0)[0].u3();
	}

	public void m2(Guid A_0, LEDChannel A_1, LightState A_2, ref FiberMuxChannel A_3)
	{
		uy(A_0)[0].m2(A_1, A_2, ref A_3);
	}

	public void m2(Guid A_0, LampChannel A_1, LightState A_2, ref FiberMuxChannel A_3)
	{
		uy(A_0)[0].m2(A_1, A_2, ref A_3);
	}

	public int m2(Guid A_0, ref float A_1)
	{
		uy(A_0)[0].m2(ref A_1);
		int result = default(int);
		return result;
	}

	[SpecialName]
	public double[] w2(Guid A_0)
	{
		return uy(A_0)[0].yj();
	}

	[SpecialName]
	public double[] w3(Guid A_0)
	{
		return uy(A_0)[0].yk();
	}

	public bool w4(Guid A_0)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.u4())
			{
				return false;
			}
		}
		return true;
	}

	public bool w5(Guid A_0)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.u5())
			{
				return false;
			}
		}
		return true;
	}

	public bool w6(Guid A_0)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.u6())
			{
				return false;
			}
		}
		return true;
	}

	public bool w7(Guid A_0)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.u7())
			{
				return false;
			}
		}
		return true;
	}

	public bool w8(Guid A_0)
	{
		foreach (g7 item in uy(A_0))
		{
			if (item.u8())
			{
				return true;
			}
		}
		return false;
	}

	public bool w9(Guid A_0)
	{
		foreach (g7 item in uy(A_0))
		{
			if (item.u9())
			{
				return true;
			}
		}
		return false;
	}

	public bool xa(Guid A_0)
	{
		return uz(A_0).x3();
	}

	public bool xb(Guid A_0)
	{
		return uz(A_0).x4();
	}

	public bool xc(Guid A_0)
	{
		foreach (g7 item in uy(A_0))
		{
			if (!item.yd())
			{
				return false;
			}
		}
		return true;
	}

	public bool m2(string A_0, hc A_1)
	{
		return st(A_0).m2(A_1);
	}

	[SpecialName]
	public bool xd(Guid A_0)
	{
		return uz(A_0).va();
	}

	[SpecialName]
	public void tf(Guid A_0, bool A_1)
	{
		uz(A_0).st(A_1);
	}

	public void m2(Guid A_0, byte A_1, global::r.d A_2, global::r.d.a.b A_3)
	{
		uz(A_0).m2(A_1, A_2, A_3);
	}

	public void s3(Guid A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		uz(A_0).st(A_1, A_2);
	}

	public float xe(Guid A_0)
	{
		float num2 = default(float);
		foreach (g7 item in uy(A_0))
		{
			float num = item.ye();
			if (num2 < num)
			{
				num2 = num;
			}
		}
		return num2;
	}

	public b9.k xf(Guid A_0)
	{
		return uz(A_0).yh();
	}

	public b9.l[] xg(Guid A_0)
	{
		return uz(A_0).yi();
	}

	public void m2(Guid A_0, global::h.f A_1, global::f.b A_2, ref double A_3)
	{
		uz(A_0).m2(A_1, A_2, ref A_3);
	}

	public void m2(Guid A_0, int A_1, ref double A_2, ref int A_3, ref double A_4, ref int A_5, ref int A_6)
	{
		g7 g10 = uz(A_0);
		g10.m2(A_1, ref A_2, ref A_3, ref A_4, ref A_5);
		A_6 = g10.s8(A_1);
	}

	public bool xh(Guid A_0)
	{
		return uz(A_0).vg();
	}

	public int xi(Guid A_0)
	{
		return uz(A_0).yv();
	}

	public int[] xj(Guid A_0)
	{
		return uz(A_0).ve();
	}

	public bool[] xk(Guid A_0)
	{
		Collection<g7> collection = uy(A_0);
		bool[] array = null;
		checked
		{
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				bool[] array2 = collection[num2].vf();
				if (array == null)
				{
					array = array2;
					continue;
				}
				if (array.Length < array2.Length)
				{
					bool[] array3 = array;
					array = array2;
					array2 = array3;
				}
				int num3 = array2.Length - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					array[num4] = array[num4] && array2[num4];
				}
			}
			return array;
		}
	}

	public bool p9(Guid A_0, hg A_1)
	{
		return uy(A_0)[0].sn(A_1);
	}

	public void m2(Guid A_0, int A_1, ref double A_2, ref double A_3)
	{
		uz(A_0).m2(A_1, ref A_2, ref A_3);
	}

	public List<it> p9(Guid A_0, hg A_1, bool A_2)
	{
		return uz(A_0).m2(A_1, A_2);
	}

	public List<it> m2(Guid A_0, hg A_1, bool A_2, ref bool A_3, ref int A_4)
	{
		return uz(A_0).m2(A_1, A_2, ref A_3, ref A_4);
	}

	public List<iu> m2(Guid A_0, List<it> A_1, List<iv> A_2)
	{
		return uz(A_0).m2(A_1, A_2);
	}

	public List<it> m2(Guid A_0, bool A_1, global::h A_2)
	{
		return uz(A_0).m2(A_1, A_2);
	}

	public List<it> xl(Guid A_0)
	{
		return uz(A_0).vh();
	}

	public List<iv> xm(Guid A_0)
	{
		return uz(A_0).vi();
	}

	public gt xn(Guid A_0)
	{
		return uz(A_0).zc();
	}

	public void m2(Guid A_0, int A_1, ref float[] A_2, ref float[] A_3, ref float[] A_4, ref float[] A_5, ref float A_6, ref float A_7, ref float A_8, ref float A_9, ref float A_10, ref float A_11, ref float A_12, ref float A_13, ref float A_14, ref float A_15, ref float A_16, ref float A_17, ref double A_18, ref double A_19)
	{
		uz(A_0).m2(A_1, ref A_2, ref A_3, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8, ref A_9, ref A_10, ref A_11, ref A_12, ref A_13, ref A_14, ref A_15, ref A_16, ref A_17, ref A_18, ref A_19);
	}

	public void m2(Guid A_0, int A_1, int A_2, int A_3, ref float[] A_4, ref float[] A_5, ref int[] A_6, ref int[] A_7)
	{
		Collection<g7> collection = uy(A_0);
		checked
		{
			int num = collection.Count - 1;
			A_4 = new float[num + 1];
			A_5 = new float[num + 1];
			A_6 = new int[num + 1];
			A_7 = new int[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				collection[num3].m2(A_1, A_2, A_3, ref A_4[num3], ref A_5[num3], ref A_6[num3], ref A_7[num3]);
			}
		}
	}

	public void m2(Guid A_0, int A_1, int A_2, int[] A_3, int[] A_4, ref float[] A_5, ref float[] A_6)
	{
		Collection<g7> collection = uy(A_0);
		checked
		{
			int num = collection.Count - 1;
			A_5 = new float[num + 1];
			A_6 = new float[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				g7 obj = collection[num3];
				int a_ = A_3[num3];
				int a_2 = A_4[num3];
				ref float a_3 = ref A_5[num3];
				ref float a_4 = ref A_6[num3];
				float A_7 = 0f;
				float A_8 = 0f;
				obj.m2(A_1, A_2, a_, a_2, ref a_3, ref a_4, ref A_7, ref A_8);
			}
		}
	}

	public void qh(string A_0, string A_1)
	{
		bool flag = default(bool);
		foreach (g7 item in t)
		{
			if (Operators.CompareString(item.zj(), A_0, TextCompare: false) == 0)
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			st(A_0).sm(A_1);
		}
	}

	protected void sn(global::r.d.a A_0)
	{
		try
		{
			if (A_0.a != global::r.d.a.a.a)
			{
				ab8().c(fz.b.b, "Error when updating optics config in MainForm.OpticsConfigUpdatedFinishedHandler()");
				fe.b(ab8(), "Error attempting to update optics configuration", new Point(global::c.e().Screen.Bounds.Width / 2, global::c.e().Screen.Bounds.Height / 2));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ab8().c(fz.b.b, "Exception caught in MainForm.OpticsConfigUpdatedFinishedHandler()", a_);
			ProjectData.ClearProjectError();
		}
	}

	protected void so(global::r.d.a A_0)
	{
		try
		{
			if (A_0.a != global::r.d.a.a.a)
			{
				ab8().c(fz.b.b, "Error when updating recipe in MainForm.OpticsConfigUpdatedFinishedHandler()");
				if (A_0.a8() == global::r.d.a.b.a)
				{
					fe.b(ab8(), "Error attempting to update recipe", new Point(global::c.e().Screen.Bounds.Width / 2, global::c.e().Screen.Bounds.Height / 2));
				}
			}
			aq.Set();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ab8().c(fz.b.b, "Exception caught in MainForm.RecipeChangedFinishedHandler()", a_);
			ProjectData.ClearProjectError();
		}
	}

	public void m2(Guid A_0, double A_1, global::r.d.a.b A_2, global::r.d A_3)
	{
		uz(A_0).m2(A_1, A_2, A_3);
	}

	public void m2(Guid A_0, FiberMuxChannel A_1, global::r.d.a.b A_2, global::r.d A_3)
	{
		uz(A_0).m2(A_1, A_2, A_3);
	}

	public void p9(Guid A_0, global::r.d.a.b A_1, global::r.d A_2)
	{
		uz(A_0).m2(A_1, A_2);
	}

	public void qh(Guid A_0, global::r.d.a.b A_1, global::r.d A_2)
	{
		uz(A_0).p9(A_1, A_2);
	}

	public void m2(Guid A_0, ip.m A_1, global::r.d.a.b A_2, global::r.d A_3)
	{
		uz(A_0).m2(A_1, A_2, A_3);
	}

	public void m2(Guid A_0, ip.i A_1, bool A_2, bool A_3, global::r.d.a.b A_4, global::r.d A_5, global::r.c A_6)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4, A_5, A_6);
	}

	public void m2(Guid A_0, ip.j A_1, global::r.d.a.b A_2, global::r.d A_3)
	{
		uz(A_0).m2(A_1, A_2, A_3);
	}

	public void m2(Guid A_0, ip.h A_1, global::r.d.a.b A_2, global::r.d A_3)
	{
		uz(A_0).m2(A_1, A_2, A_3);
	}

	public void p9(Guid A_0, ip.h A_1, global::r.d.a.b A_2, global::r.d A_3)
	{
		uz(A_0).p9(A_1, A_2, A_3);
	}

	public void qh(Guid A_0, ip.h A_1, global::r.d.a.b A_2, global::r.d A_3)
	{
		uz(A_0).qh(A_1, A_2, A_3);
	}

	public void m2(string A_0, @in.b A_1, int A_2, global::r.d A_3)
	{
		st(A_0).m2(A_1, A_2, A_3);
	}

	public void m2(Guid A_0, Collection<ip.d>[] A_1, global::r.d A_2)
	{
		uz(A_0).m2(A_1, A_2);
	}

	public void m2(string A_0, ip.d A_1, h6.b A_2, int A_3, int A_4, global::r.d A_5)
	{
		st(A_0).m2(A_1, A_2, A_3, A_4, A_5);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, int A_3, float A_4, global::r.d A_5)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4, A_5);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, int A_3, global::r.d A_4)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4);
	}

	public void p9(Guid A_0, h6.b A_1, int A_2, int A_3, global::r.d A_4)
	{
		uz(A_0).p9(A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, int A_3)
	{
		uz(A_0).sj(A_1, A_2, A_3);
	}

	[SpecialName]
	public float qh(Guid A_0, h6.b A_1, int A_2, global::f.b A_3)
	{
		return uz(A_0).so(A_1, A_2, A_3);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, global::f.b A_3, float A_4, global::r.d A_5)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4, A_5);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, global::f.b A_3, global::r.d A_4)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, global::r.d A_1)
	{
		uz(A_0).p9(A_1);
	}

	public void m2(string A_0, h6.c A_1, h6.b A_2, int A_3, global::r.d A_4)
	{
		st(A_0).m2(A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, bool A_1, bool A_2, global::r.d A_3)
	{
		uz(A_0).m2(A_1, A_2, A_3);
	}

	public void m2(Guid A_0, int A_1, global::f.b A_2, global::r.d.a.b A_3, global::r.d A_4)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, bool A_1, bool A_2, global::r.d A_3, global::r.d.a.b A_4)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, int A_1, float A_2, global::r.c A_3, global::r.d A_4, global::r.d.a.b A_5)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4, A_5);
	}

	public void s4(Guid A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		uz(A_0).so(A_1, A_2);
	}

	public FMUSBDeviceType m2(string A_0, int A_1, int A_2)
	{
		return st(A_0).s3(A_1, A_2);
	}

	public bool m2(string A_0, ref Guid A_1)
	{
		foreach (g7 item in t)
		{
			foreach (string item2 in item.xp())
			{
				if (Operators.CompareString(A_0, item2, TextCompare: false) == 0)
				{
					A_1 = item.zk();
					return true;
				}
			}
			if (item.vp() == null)
			{
				continue;
			}
			int upperBound = item.vp().GetUpperBound(0);
			for (int num = 0; num <= upperBound; num = checked(num + 1))
			{
				foreach (h6.c item3 in item.m2(num, A_1: true, up(), A_3: true))
				{
					if (Operators.CompareString(A_0, item3.a, TextCompare: false) == 0)
					{
						A_1 = item.zk();
						return true;
					}
				}
			}
		}
		return false;
	}

	public void qh(Guid A_0, h6.b A_1, int A_2, int A_3, global::r.d A_4)
	{
		uz(A_0).qh(A_1, A_2, A_3, A_4);
	}

	public void sj(Guid A_0, h6.b A_1, int A_2, int A_3, global::r.d A_4)
	{
		uz(A_0).sj(A_1, A_2, A_3, A_4);
	}

	public void m2(Guid A_0, h6.b A_1, int A_2, int A_3, Collection<cf> A_4, bool A_5, global::r.d A_6)
	{
		uz(A_0).m2(A_1, A_2, A_3, A_4, A_5, A_6);
	}

	public ip.d sn(Guid A_0, int A_1, int A_2)
	{
		return uz(A_0).s4(A_1, A_2);
	}

	public ip.e so(Guid A_0, int A_1, int A_2)
	{
		return uz(A_0).s6(A_1, A_2);
	}

	public FMUSBDeviceType p9(string A_0, int A_1)
	{
		return st(A_0).t0(A_1);
	}

	public void m2(string A_0, d4.c A_1)
	{
		st(A_0).m2(A_1);
	}

	public d4.a t8(string A_0)
	{
		return st(A_0).xd();
	}

	protected void sj(Guid A_0, string A_1)
	{
		foreach (gy item in ai.i())
		{
			if (item.y() == A_0)
			{
				item.x(A_1);
				break;
			}
		}
	}

	public void m2(string A_0, int A_1, int A_2, int A_3)
	{
		st(A_0).p9(A_1, A_2, A_3);
	}

	public void qh(string A_0, int A_1)
	{
		st(A_0).tj(A_1);
	}

	public void m2(string A_0, IntPtr A_1, global::r.d A_2, global::r.d.a.b A_3, string A_4)
	{
		st(A_0).m2(A_1, A_2, A_3, A_4);
	}

	public void m2(string A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		st(A_0).sj(A_1, A_2);
	}

	public void p9(string A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		st(A_0).sm(A_1, A_2);
	}

	public void m2(Guid A_0, bool A_1, l A_2, global::r.d.a.b A_3)
	{
		uz(A_0).m2(A_1, A_2, A_3);
	}

	public void qh(string A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		st(A_0).m2(A_2, A_1, null);
	}

	public void m2(string A_0, bool A_1, global::r.d A_2, global::r.d.a.b A_3)
	{
		st(A_0).p9(A_1, A_2, A_3);
	}

	public bool xo(Guid A_0)
	{
		return uz(A_0).wp();
	}

	public bool xp(Guid A_0)
	{
		return uz(A_0).wq();
	}

	public void m2(string A_0, bool A_1, int A_2, ej.b A_3)
	{
		st(A_0).m2(A_1, A_2, A_3);
	}

	public void m2(string A_0, int A_1, float A_2, float A_3)
	{
		st(A_0).m2(A_1, A_2, A_3);
	}

	public void m2(string A_0, float A_1, float A_2, ScrollOrientation A_3)
	{
		st(A_0).m2(A_1, A_2, A_3);
	}

	public void sj(string A_0, global::r.d A_1, global::r.d.a.b A_2)
	{
		st(A_0).sn(A_1, A_2);
	}

	public void m2(string A_0, global::r.d A_1)
	{
		st(A_0).m2(A_1);
	}

	public hf xq(Guid A_0)
	{
		return null;
	}

	public void m2(string A_0, global::r.d A_1, global::r.d.a.b A_2, d4.e A_3)
	{
		st(A_0).m2(A_1, A_3, A_2);
	}

	protected d uz()
	{
		ag = new Collection<d3>();
		d3 d10 = new ee(ab8());
		if (d10.o() != 0)
		{
			return d.a;
		}
		if (d10.p9() == global::r.a.a)
		{
			ag.Add(d10);
			return d.a;
		}
		return d.c;
	}

	protected d3 u0()
	{
		return ag[0];
	}

	public d m2(string A_0, string A_1, global::r.d A_2, l A_3)
	{
		if (u0().p(A_0, A_1, A_2, A_3, global::r.d.a.b.a) != global::r.a.a)
		{
			return d.h;
		}
		return d.a;
	}

	public d m2(string A_0, string A_1, global::r.d A_2, global::r.d A_3)
	{
		if (((ee)u0()).m2(A_0, A_1, A_2, A_3, global::r.d.a.b.a) != global::r.a.a)
		{
			return d.h;
		}
		return d.a;
	}

	public bool u1()
	{
		return ag.Count > 0;
	}

	[SpecialName]
	public int u2()
	{
		return ag[0].q();
	}

	[SpecialName]
	public int u3()
	{
		return ag[0].r();
	}

	public void m2(int A_0, int A_1, int A_2, int A_3)
	{
		u0().m2(A_0, A_1, A_2, A_3);
	}
}
