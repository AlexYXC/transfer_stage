using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[ToolboxBitmap("C:\\Documents and Settings\\aglabman\\My Documents\\Visual Studio 2005\\Projects\\FILMapper IINet\\FILMapper IINet\\Resources\\IconControlGraph.bmp")]
[DesignerGenerated]
internal class fl : UserControl
{
	private class a<a> : Collection<a> where a : fx
	{
		public long a;

		public string b;

		public Color c;

		public bool d;

		public int e;

		public bool f;

		public h g;

		public string h;

		public string i;

		public List<string> j;

		private bool k;

		private bool l;

		private List<bool> m;

		public a()
		{
			l = true;
		}

		[SpecialName]
		public bool r()
		{
			return g == global::fl.h.a;
		}

		[SpecialName]
		public bool s()
		{
			return g == global::fl.h.b;
		}

		[SpecialName]
		public bool t()
		{
			return g == global::fl.h.c;
		}

		[SpecialName]
		public bool u()
		{
			return k;
		}

		[SpecialName]
		public void r(bool A_0)
		{
			k = A_0;
		}

		[SpecialName]
		public bool v()
		{
			if (base[0].ah() != null)
			{
				return l;
			}
			return false;
		}

		[SpecialName]
		public void s(bool A_0)
		{
			l = A_0;
		}

		[SpecialName]
		public bool r(int A_0)
		{
			if (m != null && base[0].ai()[A_0] != null)
			{
				return m[A_0];
			}
			return false;
		}

		[SpecialName]
		public void r(int A_0, bool A_1)
		{
			m[A_0] = A_1;
		}

		[SpecialName]
		public List<bool> w()
		{
			return m;
		}

		[SpecialName]
		public void r(List<bool> A_0)
		{
			m = A_0;
		}

		public void r(string A_0)
		{
			checked
			{
				for (int num = base.Count - 1; num >= 0; num += -1)
				{
					fx fx2 = base[num];
					if (!fx2.ad().Contains(A_0))
					{
						fx2.ad().Add(A_0);
					}
					if (fx2.ah() != null && !fx2.ah().ad().Contains(A_0))
					{
						fx2.ah().ad().Add(A_0);
					}
					if (fx2.ai() == null || fx2.ai().Count <= 0)
					{
						continue;
					}
					int num2 = fx2.ai().Count - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						fx fx3 = fx2.ai()[num3];
						if (!fx3.ad().Contains(A_0))
						{
							fx3.ad().Add(A_0);
						}
						fx3 = null;
					}
				}
			}
		}

		public void x()
		{
			checked
			{
				for (int num = base.Count - 1; num >= 0; num += -1)
				{
					fx fx2 = base[num];
					fx2?.ad().Clear();
					if (fx2.ah() != null)
					{
						fx2.ah().ad().Clear();
					}
					if (fx2.ai() != null && fx2.ai().Count > 0)
					{
						int num2 = fx2.ai().Count - 1;
						for (int num3 = 0; num3 <= num2; num3++)
						{
							fx2.ai()[num3].ad().Clear();
						}
					}
				}
			}
		}

		public void t(bool A_0)
		{
			checked
			{
				for (int num = base.Count - 1; num >= 0; num += -1)
				{
					fx fx2 = base[num];
					fx2?.u(A_0);
					if (fx2.ah() != null)
					{
						fx2.ah().u(A_0);
					}
					if (fx2.ai() != null && fx2.ai().Count > 0)
					{
						int num2 = fx2.ai().Count - 1;
						for (int num3 = 0; num3 <= num2; num3++)
						{
							fx2.ai()[num3].u(A_0);
						}
					}
				}
			}
		}
	}

	private class b
	{
		private Rectangle a;

		public f b;

		public bool c;

		public bool d;

		public j e;

		public bool f;

		public b()
		{
			a = default(Rectangle);
		}

		[SpecialName]
		public Rectangle l()
		{
			return a;
		}

		[SpecialName]
		public int m()
		{
			return a.Top;
		}

		[SpecialName]
		public void l(int A_0)
		{
			a.Y = A_0;
		}

		[SpecialName]
		public int n()
		{
			return a.Left;
		}

		[SpecialName]
		public void m(int A_0)
		{
			int a_ = o();
			a.X = A_0;
			n(a_);
		}

		[SpecialName]
		public int o()
		{
			return a.Right;
		}

		[SpecialName]
		public void n(int A_0)
		{
			a.Width = checked(A_0 - a.Left);
		}

		[SpecialName]
		public int p()
		{
			return a.Bottom;
		}

		[SpecialName]
		public void o(int A_0)
		{
			a.Height = checked(A_0 - a.Top);
		}

		[SpecialName]
		public int q()
		{
			return a.Height;
		}

		[SpecialName]
		public void p(int A_0)
		{
			a.Height = A_0;
		}
	}

	public delegate void c(j A_0);

	public delegate void d();

	public delegate void e(PointF A_0);

	public enum f
	{
		a,
		b,
		c
	}

	public enum g
	{
		a,
		b,
		c,
		d
	}

	public enum h
	{
		a,
		b,
		c
	}

	private enum i
	{
		a,
		b,
		c,
		d
	}

	public struct j
	{
		public double a;

		public double b;
	}

	private class k
	{
		public Rectangle a;

		public double b;

		public double c;

		public k()
		{
			a = default(Rectangle);
		}
	}

	public class l : Exception
	{
		public l(string A_0)
			: base(A_0)
		{
		}
	}

	public class m : Exception
	{
		public m(string A_0)
			: base(A_0)
		{
		}
	}

	public class n
	{
		private Collection<o> a;

		[SpecialName]
		public Collection<o> e()
		{
			return a;
		}

		[SpecialName]
		public bool f()
		{
			if (a.Count > 1)
			{
				return a[1].i();
			}
			return false;
		}

		[SpecialName]
		public bool g()
		{
			foreach (o item in a)
			{
				if (item.i())
				{
					return true;
				}
			}
			return false;
		}

		[SpecialName]
		public bool h()
		{
			foreach (o item in a)
			{
				if (item.j())
				{
					return true;
				}
			}
			return false;
		}

		public void i()
		{
			a.Clear();
		}

		public void e(o A_0)
		{
			a.Add(A_0);
		}

		public n()
		{
			a = new Collection<o>();
		}
	}

	public class o
	{
		public double[] a;

		public double[] b;

		public int c;

		public double[] d;

		public double[] e;

		public int f;

		[SpecialName]
		public bool i()
		{
			return c > 0;
		}

		[SpecialName]
		public bool j()
		{
			return f > 0;
		}

		public o(double[] A_0, double[] A_1, int A_2, double[] A_3, double[] A_4, int A_5)
		{
			a = A_0;
			b = A_1;
			c = A_2;
			d = A_3;
			e = A_4;
			f = A_5;
		}
	}

	public delegate void p(object A_0, long A_1, long A_2);

	public delegate void q(long A_0);

	public delegate void r(fu A_0, long A_1, long A_2);

	public delegate void s(long A_0, long A_1, global::r.d.a.b A_2);

	public delegate void t(long A_0, global::r.d.a.b A_1);

	public delegate void u(object A_0, string A_1, long A_2, global::r.d.a.b A_3);

	public delegate void v(fl A_0);

	public delegate void w(fl A_0, bool A_1, ref bool A_2);

	public delegate void x();

	public enum y : short
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
		j
	}

	public struct z
	{
		public float a;

		public float b;

		public float c;

		public float d;

		[SpecialName]
		public int j(fl A_0)
		{
			return checked((int)Math.Round(A_0.s(d) - A_0.s(c)));
		}

		[SpecialName]
		public void j(fl A_0, int A_1)
		{
			if (A_1 == 0)
			{
				d = c;
				return;
			}
			throw new ax("Argument must be zero");
		}

		[SpecialName]
		public int k(fl A_0)
		{
			return checked((int)Math.Round(A_0.t(a) - A_0.t(b)));
		}

		[SpecialName]
		public void k(fl A_0, int A_1)
		{
			if (A_1 == 0)
			{
				a = b;
				return;
			}
			throw new ax("Argument must be zero");
		}

		[SpecialName]
		public Rectangle l(fl A_0)
		{
			checked
			{
				Rectangle result = default(Rectangle);
				result.X = (int)Math.Round(A_0.t(b));
				result.Y = (int)Math.Round(A_0.s(c));
				result.Width = (int)Math.Round(A_0.t(a) - (float)result.X);
				result.Height = (int)Math.Round(A_0.s(d) - (float)result.Y);
				return result;
			}
		}

		public void j(Rectangle A_0, fl A_1)
		{
			b = (float)A_1.q((float)A_0.X);
			checked
			{
				a = (float)A_1.q((float)(A_0.X + A_0.Width));
				d = (float)A_1.p((float)(A_0.Y + A_0.Height));
				c = (float)A_1.p((float)A_0.Y);
			}
		}

		[SpecialName]
		public int m(fl A_0)
		{
			return checked((int)Math.Round(A_0.t(b)));
		}

		[SpecialName]
		public void l(fl A_0, int A_1)
		{
			b = (float)A_0.q((float)A_1);
		}

		[SpecialName]
		public int n(fl A_0)
		{
			return checked((int)Math.Round(A_0.s(c)));
		}

		[SpecialName]
		public void m(fl A_0, int A_1)
		{
			c = (float)A_0.p((float)A_1);
		}
	}

	private delegate bool aa(double A_0);

	private delegate void ab(object A_0, ElapsedEventArgs A_1);

	private delegate void ac(object A_0, ElapsedEventArgs A_1);

	public delegate void ad();

	private delegate void ae();

	private IContainer m_a;

	[CompilerGenerated]
	private ContextMenuStrip m_b;

	[CompilerGenerated]
	private ToolStripMenuItem m_c;

	[CompilerGenerated]
	private ToolStripMenuItem m_d;

	[CompilerGenerated]
	private ToolStripMenuItem m_e;

	[CompilerGenerated]
	private ToolStripMenuItem m_f;

	[CompilerGenerated]
	private ContextMenuStrip m_g;

	[CompilerGenerated]
	private ToolStripMenuItem m_h;

	[CompilerGenerated]
	private ToolTip m_i;

	[CompilerGenerated]
	private Panel m_j;

	[CompilerGenerated]
	private Panel m_k;

	[CompilerGenerated]
	private Panel m_l;

	[CompilerGenerated]
	private Label m_m;

	[CompilerGenerated]
	private Label m_n;

	[CompilerGenerated]
	private Label m_o;

	[CompilerGenerated]
	private Label m_p;

	[CompilerGenerated]
	private Label m_q;

	[CompilerGenerated]
	private Label m_r;

	[CompilerGenerated]
	private Label m_s;

	[CompilerGenerated]
	private Label m_t;

	[CompilerGenerated]
	private Label m_u;

	[CompilerGenerated]
	private Label m_v;

	[CompilerGenerated]
	private Panel m_w;

	[CompilerGenerated]
	private Panel m_x;

	[CompilerGenerated]
	private Panel m_y;

	[CompilerGenerated]
	private Label m_z;

	[CompilerGenerated]
	private hy m_aa;

	[CompilerGenerated]
	private ToolStripMenuItem m_ab;

	[CompilerGenerated]
	private ContextMenuStrip m_ac;

	[CompilerGenerated]
	private ToolStripMenuItem m_ad;

	[CompilerGenerated]
	private ToolStripMenuItem m_ae;

	[CompilerGenerated]
	private ToolStripMenuItem m_af;

	[CompilerGenerated]
	private ToolStripMenuItem m_ag;

	[CompilerGenerated]
	private ToolStripMenuItem m_ah;

	[CompilerGenerated]
	private ToolStripMenuItem m_ai;

	[CompilerGenerated]
	private ToolStripSeparator m_aj;

	[CompilerGenerated]
	private ToolStripMenuItem m_ak;

	[CompilerGenerated]
	private ToolStripSeparator m_al;

	[CompilerGenerated]
	private ToolStripMenuItem m_am;

	[CompilerGenerated]
	private ToolStripMenuItem m_an;

	private const int m_ao = 1;

	private const int m_ap = 1;

	private z m_aq;

	private z m_ar;

	private Point m_as;

	private Point m_at;

	private Pen au;

	private bool av;

	private bool aw;

	private bool ax;

	private bool ay;

	private fz az;

	private bool a0;

	private bool a1;

	private Label m_a2;

	private Label a3;

	private Label a4;

	private Label m_a5;

	private Label a6;

	private Label a7;

	private bool a8;

	private short a9;

	private bool ba;

	private int bb;

	private bool bc;

	private bool bd;

	private bool be;

	private string bf;

	private string[] bg;

	private string[] bh;

	private double bi;

	private double bj;

	private double bk;

	private double bl;

	private bool bm;

	private double bn;

	private bool bo;

	private Collection<a<fx>> bp;

	private bool bq;

	private bool br;

	private const string bs = " (%)";

	private string bt;

	private bool bu;

	private double bv;

	private object bw;

	private string bx;

	private string by;

	private short bz;

	private bool b0;

	private short b1;

	private short b2;

	private short b3;

	private short b4;

	private short b5;

	private short b6;

	private short m_b7;

	private short b8;

	private short b9;

	private short ca;

	private int cb;

	private bool cc;

	private bool cd;

	private float ce;

	private float cf;

	private short cg;

	private double[] ch;

	private int[] ci;

	private bool[] cj;

	private short ck;

	private short cl;

	private short cm;

	private short cn;

	private short co;

	private short cp;

	private bool cq;

	private Color cr;

	private Color cs;

	private Color ct;

	private Color cu;

	private Color cv;

	private Color cw;

	private bool cx;

	private int cy;

	private int cz;

	private Panel m_c0;

	private k m_c1;

	private k m_c2;

	private k m_c3;

	private int c4;

	private int m_c5;

	private int m_c6;

	private string m_c7;

	private double[] m_c8;

	private double[] m_c9;

	private double[] m_da;

	private double[] m_db;

	private bool[] m_dc;

	private bool[] m_dd;

	private double[] m_de;

	private int m_df;

	private int m_dg;

	private double[] m_dh;

	private double[] m_di;

	private double[] m_dj;

	private double[] m_dk;

	private bool[] m_dl;

	private bool[] m_dm;

	private cc.a[] m_dn;

	private int m_do;

	private int m_dp;

	private bool m_dq;

	private bool[] m_dr;

	private Color[] m_ds;

	private Label[] m_dt;

	private Label[] m_du;

	private int m_dv;

	private bool m_dw;

	private bool m_dx;

	private bool m_dy;

	private bool m_dz;

	private Label m_d0;

	private Label[] m_d1;

	private bool[] m_d2;

	private const int m_d3 = 5;

	private const int m_d4 = 4;

	private bool m_d5;

	private bool m_d6;

	private const string m_d7 = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";

	private bool m_d8;

	private fx m_d9;

	private string m_ea;

	private string m_eb;

	private long m_ec;

	private string m_ed;

	private h m_ee;

	private g m_ef;

	private bool m_eg;

	private bool m_eh;

	private string m_ei;

	private gq m_ej;

	public bool ek;

	private Bitmap m_el;

	private fu m_em;

	[CompilerGenerated]
	private System.Timers.Timer m_en;

	[CompilerGenerated]
	private System.Timers.Timer m_eo;

	[CompilerGenerated]
	private System.Timers.Timer m_ep;

	private bool m_eq;

	public ManualResetEvent er;

	private bool m_es;

	private bool m_et;

	private bool m_eu;

	private bool m_ev;

	[CompilerGenerated]
	private Label m_ew;

	[CompilerGenerated]
	private Label m_ex;

	[CompilerGenerated]
	private Label m_ey;

	private fh.a m_ez;

	private fm m_e0;

	private bool m_e1;

	private int m_e2;

	private int m_e3;

	private float m_e4;

	private bool m_e5;

	private double m_e6;

	private float m_e7;

	private float m_e8;

	private float[] m_e9;

	private float m_fa;

	private float m_fb;

	private float[] m_fc;

	private List<fo> m_fd;

	private List<string> m_fe;

	private List<string> m_ff;

	private Collection<List<string>> m_fg;

	private bool m_fh;

	private bool m_fi;

	private List<bool> m_fj;

	private Point m_fk;

	private const string m_fl = "OverlayCurveDotsInfo.txt";

	private const string m_fm = "GraphDotsInfo.txt";

	private bool m_fn;

	private string m_fo;

	private Rectangle m_fp;

	private PointF m_fq;

	private string m_fr;

	private string m_fs;

	private string m_ft;

	private bool m_fu;

	[CompilerGenerated]
	private c m_fv;

	[CompilerGenerated]
	private d m_fw;

	[CompilerGenerated]
	private e m_fx;

	private b m_fy;

	private f m_fz;

	private const int m_f0 = 8;

	private bool m_f1;

	private bool m_f2;

	private bool m_f3;

	private h m_f4;

	private bool m_f5;

	private static string m_f6;

	public bool f7;

	public const short f8 = 10;

	public bool f9;

	public bool ga;

	public bool gb;

	[CompilerGenerated]
	private bool m_gc;

	[CompilerGenerated]
	private p m_gd;

	[CompilerGenerated]
	private q m_ge;

	[CompilerGenerated]
	private r m_gf;

	[CompilerGenerated]
	private r m_gg;

	[CompilerGenerated]
	private s m_gh;

	[CompilerGenerated]
	private t m_gi;

	[CompilerGenerated]
	private u m_gj;

	[CompilerGenerated]
	private v m_gk;

	[CompilerGenerated]
	private w m_gl;

	public double gm;

	public bool gn;

	[CompilerGenerated]
	private x m_go;

	[CompilerGenerated]
	private bool m_gp;

	private float m_gq;

	private bool m_gr;

	private const float m_gs = 2.5f;

	private const float m_gt = 2f;

	private int m_gu;

	[CompilerGenerated]
	private ad m_gv;

	[SpecialName]
	private string m_gw;

	[SpecialName]
	private string m_gx;

	[SpecialName]
	private string m_gy;

	[SpecialName]
	private bool m_gz;

	[SpecialName]
	private IAsyncResult m_g0;

	[SpecialName]
	private StaticLocalInitFlag m_g1;

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && m_a != null)
		{
			m_a.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void dv()
	{
		m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fl));
		o(new ContextMenuStrip(m_a));
		r(new ToolStripMenuItem());
		o(new ToolStripMenuItem());
		q(new ToolStripMenuItem());
		p(new ToolStripMenuItem());
		t(new ToolStripMenuItem());
		u(new ToolStripMenuItem());
		p(new ContextMenuStrip(m_a));
		s(new ToolStripMenuItem());
		o(new ToolTip(m_a));
		p(new Panel());
		q(new Panel());
		r(new Panel());
		o(new Label());
		p(new Label());
		q(new Label());
		r(new Label());
		s(new Label());
		t(new Label());
		u(new Label());
		v(new Label());
		w(new Label());
		x(new Label());
		s(new Panel());
		t(new Panel());
		u(new Panel());
		y(new Label());
		q(new ContextMenuStrip(m_a));
		z(new ToolStripMenuItem());
		aa(new ToolStripMenuItem());
		o(new ToolStripSeparator());
		ab(new ToolStripMenuItem());
		ac(new ToolStripMenuItem());
		p(new ToolStripSeparator());
		v(new ToolStripMenuItem());
		w(new ToolStripMenuItem());
		x(new ToolStripMenuItem());
		y(new ToolStripMenuItem());
		o(new hy());
		dw().SuspendLayout();
		d1().SuspendLayout();
		d4().SuspendLayout();
		d5().SuspendLayout();
		d6().SuspendLayout();
		eh().SuspendLayout();
		ei().SuspendLayout();
		ej().SuspendLayout();
		eo().SuspendLayout();
		SuspendLayout();
		componentResourceManager.ApplyResources(dw(), "LegendRightClickMenu");
		dw().Items.AddRange(new ToolStripItem[6]
		{
			d0(),
			dx(),
			dz(),
			dy(),
			en(),
			ep()
		});
		dw().Name = "ContextMenuStrip1";
		d3().SetToolTip(dw(), componentResourceManager.GetString("LegendRightClickMenu.ToolTip"));
		componentResourceManager.ApplyResources(d0(), "SaveCurveToolStripMenuItem");
		d0().Name = "SaveCurveToolStripMenuItem";
		componentResourceManager.ApplyResources(dx(), "DeleteCurveToolStripMenuItem");
		dx().Name = "DeleteCurveToolStripMenuItem";
		componentResourceManager.ApplyResources(dz(), "RenameCurveToolStripMenuItem");
		dz().Name = "RenameCurveToolStripMenuItem";
		componentResourceManager.ApplyResources(dy(), "OpenCurveToolStripMenuItem");
		dy().Name = "OpenCurveToolStripMenuItem";
		componentResourceManager.ApplyResources(en(), "PropertiesToolStripMenuItem");
		en().Name = "PropertiesToolStripMenuItem";
		componentResourceManager.ApplyResources(ep(), "ShowCurveToolStripMenuItem");
		ep().Name = "ShowCurveToolStripMenuItem";
		componentResourceManager.ApplyResources(d1(), "LegendOverlayRightClickMenu");
		d1().Items.AddRange(new ToolStripItem[1] { d2() });
		d1().Name = "ContextMenuStrip2";
		d3().SetToolTip(d1(), componentResourceManager.GetString("LegendOverlayRightClickMenu.ToolTip"));
		componentResourceManager.ApplyResources(d2(), "SaveOverlayCurveToolStripMenuItem");
		d2().Name = "SaveOverlayCurveToolStripMenuItem";
		d3().AutoPopDelay = 5000;
		d3().InitialDelay = 0;
		d3().ReshowDelay = 1000;
		d3().ShowAlways = true;
		componentResourceManager.ApplyResources(d4(), "PanelLegendOuter");
		d4().Controls.Add(d5());
		d4().Cursor = Cursors.SizeAll;
		d4().Name = "PanelLegendOuter";
		d3().SetToolTip(d4(), componentResourceManager.GetString("PanelLegendOuter.ToolTip"));
		componentResourceManager.ApplyResources(d5(), "PanelLegend");
		d5().BackColor = Color.White;
		d5().BorderStyle = BorderStyle.FixedSingle;
		d5().Controls.Add(d6());
		d5().Cursor = Cursors.Default;
		d5().Name = "PanelLegend";
		d3().SetToolTip(d5(), componentResourceManager.GetString("PanelLegend.ToolTip"));
		componentResourceManager.ApplyResources(d6(), "PanelLegendBorder");
		d6().BackColor = Color.Black;
		d6().BorderStyle = BorderStyle.FixedSingle;
		d6().Controls.Add(d7());
		d6().Controls.Add(d8());
		d6().Controls.Add(d9());
		d6().Controls.Add(ea());
		d6().Controls.Add(eb());
		d6().Controls.Add(ec());
		d6().Controls.Add(ed());
		d6().Controls.Add(ee());
		d6().Controls.Add(ef());
		d6().Controls.Add(eg());
		d6().Name = "PanelLegendBorder";
		d3().SetToolTip(d6(), componentResourceManager.GetString("PanelLegendBorder.ToolTip"));
		componentResourceManager.ApplyResources(d7(), "Label0");
		d7().BackColor = Color.Transparent;
		d7().Cursor = Cursors.Hand;
		d7().ForeColor = Color.Blue;
		d7().Name = "Label0";
		d3().SetToolTip(d7(), componentResourceManager.GetString("Label0.ToolTip"));
		d7().UseMnemonic = false;
		componentResourceManager.ApplyResources(d8(), "Label4");
		d8().BackColor = Color.Transparent;
		d8().Cursor = Cursors.Hand;
		d8().ForeColor = Color.Green;
		d8().Name = "Label4";
		d3().SetToolTip(d8(), componentResourceManager.GetString("Label4.ToolTip"));
		d8().UseMnemonic = false;
		componentResourceManager.ApplyResources(d9(), "Label8");
		d9().BackColor = Color.Transparent;
		d9().Cursor = Cursors.Hand;
		d9().ForeColor = Color.Green;
		d9().Name = "Label8";
		d3().SetToolTip(d9(), componentResourceManager.GetString("Label8.ToolTip"));
		d9().UseMnemonic = false;
		componentResourceManager.ApplyResources(ea(), "Label5");
		ea().BackColor = Color.Transparent;
		ea().Cursor = Cursors.Hand;
		ea().ForeColor = Color.Green;
		ea().Name = "Label5";
		d3().SetToolTip(ea(), componentResourceManager.GetString("Label5.ToolTip"));
		ea().UseMnemonic = false;
		componentResourceManager.ApplyResources(eb(), "Label3");
		eb().BackColor = Color.Transparent;
		eb().Cursor = Cursors.Hand;
		eb().ForeColor = Color.Green;
		eb().Name = "Label3";
		d3().SetToolTip(eb(), componentResourceManager.GetString("Label3.ToolTip"));
		eb().UseMnemonic = false;
		componentResourceManager.ApplyResources(ec(), "Label1");
		ec().BackColor = Color.Transparent;
		ec().Cursor = Cursors.Hand;
		ec().ForeColor = Color.Green;
		ec().Name = "Label1";
		d3().SetToolTip(ec(), componentResourceManager.GetString("Label1.ToolTip"));
		ec().UseMnemonic = false;
		componentResourceManager.ApplyResources(ed(), "Label2");
		ed().BackColor = Color.Transparent;
		ed().Cursor = Cursors.Hand;
		ed().ForeColor = Color.Green;
		ed().Name = "Label2";
		d3().SetToolTip(ed(), componentResourceManager.GetString("Label2.ToolTip"));
		ed().UseMnemonic = false;
		componentResourceManager.ApplyResources(ee(), "Label6");
		ee().BackColor = Color.Transparent;
		ee().Cursor = Cursors.Hand;
		ee().ForeColor = Color.Green;
		ee().Name = "Label6";
		d3().SetToolTip(ee(), componentResourceManager.GetString("Label6.ToolTip"));
		ee().UseMnemonic = false;
		componentResourceManager.ApplyResources(ef(), "Label7");
		ef().BackColor = Color.Transparent;
		ef().Cursor = Cursors.Hand;
		ef().ForeColor = Color.Green;
		ef().Name = "Label7";
		d3().SetToolTip(ef(), componentResourceManager.GetString("Label7.ToolTip"));
		ef().UseMnemonic = false;
		componentResourceManager.ApplyResources(eg(), "Label9");
		eg().BackColor = Color.Transparent;
		eg().Cursor = Cursors.Hand;
		eg().ForeColor = Color.Green;
		eg().Name = "Label9";
		d3().SetToolTip(eg(), componentResourceManager.GetString("Label9.ToolTip"));
		eg().UseMnemonic = false;
		componentResourceManager.ApplyResources(eh(), "PanelOverlayLegendOuter");
		eh().BackColor = Color.Transparent;
		eh().Controls.Add(ei());
		eh().Cursor = Cursors.SizeAll;
		eh().Name = "PanelOverlayLegendOuter";
		d3().SetToolTip(eh(), componentResourceManager.GetString("PanelOverlayLegendOuter.ToolTip"));
		componentResourceManager.ApplyResources(ei(), "PanelOverlayLegend");
		ei().BackColor = Color.White;
		ei().BorderStyle = BorderStyle.FixedSingle;
		ei().Controls.Add(ej());
		ei().Cursor = Cursors.Default;
		ei().Name = "PanelOverlayLegend";
		d3().SetToolTip(ei(), componentResourceManager.GetString("PanelOverlayLegend.ToolTip"));
		componentResourceManager.ApplyResources(ej(), "PanelOverlayLegendBorder");
		ej().BackColor = Color.Black;
		ej().BorderStyle = BorderStyle.FixedSingle;
		ej().Controls.Add(el());
		ej().Name = "PanelOverlayLegendBorder";
		d3().SetToolTip(ej(), componentResourceManager.GetString("PanelOverlayLegendBorder.ToolTip"));
		componentResourceManager.ApplyResources(el(), "LabelOverlayCurve");
		el().BackColor = Color.Transparent;
		el().Cursor = Cursors.Arrow;
		el().ForeColor = Color.Red;
		el().Name = "LabelOverlayCurve";
		d3().SetToolTip(el(), componentResourceManager.GetString("LabelOverlayCurve.ToolTip"));
		el().UseMnemonic = false;
		componentResourceManager.ApplyResources(eo(), "ContextMenuGraph");
		eo().Items.AddRange(new ToolStripItem[7]
		{
			ev(),
			ex(),
			ew(),
			ez(),
			e0(),
			ey(),
			eq()
		});
		eo().Name = "ContextMenuGraph";
		d3().SetToolTip(eo(), componentResourceManager.GetString("ContextMenuGraph.ToolTip"));
		componentResourceManager.ApplyResources(ev(), "TrackValuesToolStripMenuItem");
		ev().Name = "TrackValuesToolStripMenuItem";
		componentResourceManager.ApplyResources(ex(), "DeleteTrackingValuesToolStripMenuItem");
		ex().Name = "DeleteTrackingValuesToolStripMenuItem";
		componentResourceManager.ApplyResources(ew(), "ToolStripSeparator4");
		ew().Name = "ToolStripSeparator4";
		componentResourceManager.ApplyResources(ez(), "TrackMovingCursorToolStripMenuItem");
		ez().Name = "TrackMovingCursorToolStripMenuItem";
		componentResourceManager.ApplyResources(e0(), "DeleteTrackingAtMovingCursorToolStripMenuItem");
		e0().Name = "DeleteTrackingAtMovingCursorToolStripMenuItem";
		componentResourceManager.ApplyResources(ey(), "ToolStripSeparator5");
		ey().Name = "ToolStripSeparator5";
		componentResourceManager.ApplyResources(eq(), "MarkerStyleToolStripMenuItem");
		eq().DropDownItems.AddRange(new ToolStripItem[3]
		{
			es(),
			et(),
			eu()
		});
		eq().Name = "MarkerStyleToolStripMenuItem";
		componentResourceManager.ApplyResources(es(), "DotToolStripMenuItem");
		es().CheckOnClick = true;
		es().Name = "DotToolStripMenuItem";
		componentResourceManager.ApplyResources(et(), "VerticalLineToolStripMenuItem");
		et().CheckOnClick = true;
		et().Name = "VerticalLineToolStripMenuItem";
		componentResourceManager.ApplyResources(eu(), "CursorShowXValueToolStripMenuItem");
		eu().CheckOnClick = true;
		eu().Name = "CursorShowXValueToolStripMenuItem";
		componentResourceManager.ApplyResources(em(), "TextBoxXRangeEndpointValue");
		em().f(A_0: false);
		em().Name = "TextBoxXRangeEndpointValue";
		em().e(A_0: false);
		d3().SetToolTip(em(), componentResourceManager.GetString("TextBoxXRangeEndpointValue.ToolTip"));
		componentResourceManager.ApplyResources(this, "$this");
		AllowDrop = true;
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.Transparent;
		base.Controls.Add(eh());
		base.Controls.Add(em());
		base.Controls.Add(d4());
		DoubleBuffered = true;
		base.Name = "FIControlGraph";
		d3().SetToolTip(this, componentResourceManager.GetString("$this.ToolTip"));
		dw().ResumeLayout(performLayout: false);
		d1().ResumeLayout(performLayout: false);
		d4().ResumeLayout(performLayout: false);
		d5().ResumeLayout(performLayout: false);
		d6().ResumeLayout(performLayout: false);
		d6().PerformLayout();
		eh().ResumeLayout(performLayout: false);
		ei().ResumeLayout(performLayout: false);
		ej().ResumeLayout(performLayout: false);
		ej().PerformLayout();
		eo().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ContextMenuStrip dw()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(ContextMenuStrip A_0)
	{
		CancelEventHandler value = o;
		ContextMenuStrip contextMenuStrip = this.m_b;
		if (contextMenuStrip != null)
		{
			contextMenuStrip.Opening -= value;
		}
		this.m_b = A_0;
		contextMenuStrip = this.m_b;
		if (contextMenuStrip != null)
		{
			contextMenuStrip.Opening += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem dx()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(ToolStripMenuItem A_0)
	{
		EventHandler value = da;
		ToolStripMenuItem toolStripMenuItem = this.m_c;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_c = A_0;
		toolStripMenuItem = this.m_c;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem dy()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(ToolStripMenuItem A_0)
	{
		EventHandler value = ag;
		ToolStripMenuItem toolStripMenuItem = this.m_d;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_d = A_0;
		toolStripMenuItem = this.m_d;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem dz()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(ToolStripMenuItem A_0)
	{
		EventHandler value = ae;
		ToolStripMenuItem toolStripMenuItem = this.m_e;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_e = A_0;
		toolStripMenuItem = this.m_e;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem d0()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(ToolStripMenuItem A_0)
	{
		EventHandler value = ad;
		ToolStripMenuItem toolStripMenuItem = this.m_f;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_f = A_0;
		toolStripMenuItem = this.m_f;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ContextMenuStrip d1()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(ContextMenuStrip A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem d2()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(ToolStripMenuItem A_0)
	{
		EventHandler value = ac;
		ToolStripMenuItem toolStripMenuItem = this.m_h;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_h = A_0;
		toolStripMenuItem = this.m_h;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip d3()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(ToolTip A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel d4()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(Panel A_0)
	{
		MouseEventHandler value = q;
		MouseEventHandler value2 = p;
		EventHandler value3 = ah;
		MouseEventHandler value4 = o;
		Panel panel = this.m_j;
		if (panel != null)
		{
			panel.MouseDown -= value;
			panel.MouseUp -= value2;
			panel.MouseLeave -= value3;
			panel.MouseMove -= value4;
		}
		this.m_j = A_0;
		panel = this.m_j;
		if (panel != null)
		{
			panel.MouseDown += value;
			panel.MouseUp += value2;
			panel.MouseLeave += value3;
			panel.MouseMove += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel d5()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(Panel A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel d6()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(Panel A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label d7()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(Label A_0)
	{
		MouseEventHandler value = aa;
		EventHandler value2 = @as;
		Label label = this.m_m;
		if (label != null)
		{
			label.MouseClick -= value;
			label.MouseEnter -= value2;
		}
		this.m_m = A_0;
		label = this.m_m;
		if (label != null)
		{
			label.MouseClick += value;
			label.MouseEnter += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label d8()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(Label A_0)
	{
		MouseEventHandler value = w;
		EventHandler value2 = @as;
		Label label = this.m_n;
		if (label != null)
		{
			label.MouseClick -= value;
			label.MouseEnter -= value2;
		}
		this.m_n = A_0;
		label = this.m_n;
		if (label != null)
		{
			label.MouseClick += value;
			label.MouseEnter += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label d9()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(Label A_0)
	{
		MouseEventHandler value = s;
		EventHandler value2 = @as;
		Label label = this.m_o;
		if (label != null)
		{
			label.MouseClick -= value;
			label.MouseEnter -= value2;
		}
		this.m_o = A_0;
		label = this.m_o;
		if (label != null)
		{
			label.MouseClick += value;
			label.MouseEnter += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ea()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(Label A_0)
	{
		MouseEventHandler value = v;
		EventHandler value2 = @as;
		Label label = this.m_p;
		if (label != null)
		{
			label.MouseClick -= value;
			label.MouseEnter -= value2;
		}
		this.m_p = A_0;
		label = this.m_p;
		if (label != null)
		{
			label.MouseClick += value;
			label.MouseEnter += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label eb()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(Label A_0)
	{
		MouseEventHandler value = x;
		EventHandler value2 = @as;
		Label label = this.m_q;
		if (label != null)
		{
			label.MouseClick -= value;
			label.MouseEnter -= value2;
		}
		this.m_q = A_0;
		label = this.m_q;
		if (label != null)
		{
			label.MouseClick += value;
			label.MouseEnter += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ec()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(Label A_0)
	{
		MouseEventHandler value = z;
		EventHandler value2 = @as;
		Label label = this.m_r;
		if (label != null)
		{
			label.MouseClick -= value;
			label.MouseEnter -= value2;
		}
		this.m_r = A_0;
		label = this.m_r;
		if (label != null)
		{
			label.MouseClick += value;
			label.MouseEnter += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ed()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(Label A_0)
	{
		MouseEventHandler value = y;
		EventHandler value2 = @as;
		Label label = this.m_s;
		if (label != null)
		{
			label.MouseClick -= value;
			label.MouseEnter -= value2;
		}
		this.m_s = A_0;
		label = this.m_s;
		if (label != null)
		{
			label.MouseClick += value;
			label.MouseEnter += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ee()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(Label A_0)
	{
		MouseEventHandler value = u;
		EventHandler value2 = @as;
		Label label = this.m_t;
		if (label != null)
		{
			label.MouseClick -= value;
			label.MouseEnter -= value2;
		}
		this.m_t = A_0;
		label = this.m_t;
		if (label != null)
		{
			label.MouseClick += value;
			label.MouseEnter += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ef()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(Label A_0)
	{
		MouseEventHandler value = t;
		EventHandler value2 = @as;
		Label label = this.m_u;
		if (label != null)
		{
			label.MouseClick -= value;
			label.MouseEnter -= value2;
		}
		this.m_u = A_0;
		label = this.m_u;
		if (label != null)
		{
			label.MouseClick += value;
			label.MouseEnter += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label eg()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(Label A_0)
	{
		MouseEventHandler value = r;
		EventHandler value2 = @as;
		Label label = this.m_v;
		if (label != null)
		{
			label.MouseClick -= value;
			label.MouseEnter -= value2;
		}
		this.m_v = A_0;
		label = this.m_v;
		if (label != null)
		{
			label.MouseClick += value;
			label.MouseEnter += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel eh()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(Panel A_0)
	{
		MouseEventHandler value = q;
		MouseEventHandler value2 = p;
		EventHandler value3 = ah;
		MouseEventHandler value4 = o;
		Panel panel = this.m_w;
		if (panel != null)
		{
			panel.MouseDown -= value;
			panel.MouseUp -= value2;
			panel.MouseLeave -= value3;
			panel.MouseMove -= value4;
		}
		this.m_w = A_0;
		panel = this.m_w;
		if (panel != null)
		{
			panel.MouseDown += value;
			panel.MouseUp += value2;
			panel.MouseLeave += value3;
			panel.MouseMove += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel ei()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(Panel A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel ej()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(Panel A_0)
	{
		this.m_y = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label el()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(Label A_0)
	{
		MouseEventHandler value = ab;
		EventHandler value2 = ar;
		Label label = this.m_z;
		if (label != null)
		{
			label.MouseClick -= value;
			label.MouseEnter -= value2;
		}
		this.m_z = A_0;
		label = this.m_z;
		if (label != null)
		{
			label.MouseClick += value;
			label.MouseEnter += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy em()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(hy A_0)
	{
		EventHandler value = c5;
		EventHandler value2 = c3;
		EventHandler value3 = c2;
		EventHandler value4 = c1;
		KeyEventHandler value5 = o;
		hy hy2 = this.m_aa;
		if (hy2 != null)
		{
			hy2.MouseEnter -= value;
			hy2.MouseLeave -= value2;
			hy2.GotFocus -= value3;
			hy2.LostFocus -= value4;
			hy2.KeyDown -= value5;
		}
		this.m_aa = A_0;
		hy2 = this.m_aa;
		if (hy2 != null)
		{
			hy2.MouseEnter += value;
			hy2.MouseLeave += value2;
			hy2.GotFocus += value3;
			hy2.LostFocus += value4;
			hy2.KeyDown += value5;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem en()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(ToolStripMenuItem A_0)
	{
		EventHandler value = af;
		ToolStripMenuItem toolStripMenuItem = this.m_ab;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_ab = A_0;
		toolStripMenuItem = this.m_ab;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ContextMenuStrip eo()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(ContextMenuStrip A_0)
	{
		this.m_ac = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem ep()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(ToolStripMenuItem A_0)
	{
		this.m_ad = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem eq()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(ToolStripMenuItem A_0)
	{
		this.m_ae = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem es()
	{
		return this.m_af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(ToolStripMenuItem A_0)
	{
		EventHandler value = c6;
		ToolStripMenuItem toolStripMenuItem = this.m_af;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.CheckedChanged -= value;
		}
		this.m_af = A_0;
		toolStripMenuItem = this.m_af;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem et()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(ToolStripMenuItem A_0)
	{
		EventHandler value = c7;
		ToolStripMenuItem toolStripMenuItem = this.m_ag;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.CheckedChanged -= value;
		}
		this.m_ag = A_0;
		toolStripMenuItem = this.m_ag;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem eu()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(ToolStripMenuItem A_0)
	{
		EventHandler value = c8;
		ToolStripMenuItem toolStripMenuItem = this.m_ah;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.CheckedChanged -= value;
		}
		this.m_ah = A_0;
		toolStripMenuItem = this.m_ah;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem ev()
	{
		return this.m_ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(ToolStripMenuItem A_0)
	{
		EventHandler value = s;
		ToolStripMenuItem toolStripMenuItem = this.m_ai;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.DropDownOpening -= value;
		}
		this.m_ai = A_0;
		toolStripMenuItem = this.m_ai;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.DropDownOpening += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripSeparator ew()
	{
		return this.m_aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(ToolStripSeparator A_0)
	{
		this.m_aj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem ex()
	{
		return this.m_ak;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aa(ToolStripMenuItem A_0)
	{
		EventHandler value = r;
		ToolStripMenuItem toolStripMenuItem = this.m_ak;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.DropDownOpening -= value;
		}
		this.m_ak = A_0;
		toolStripMenuItem = this.m_ak;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.DropDownOpening += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripSeparator ey()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(ToolStripSeparator A_0)
	{
		this.m_al = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem ez()
	{
		return this.m_am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(ToolStripMenuItem A_0)
	{
		EventHandler value = q;
		ToolStripMenuItem toolStripMenuItem = this.m_am;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.DropDownOpening -= value;
		}
		this.m_am = A_0;
		toolStripMenuItem = this.m_am;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.DropDownOpening += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem e0()
	{
		return this.m_an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(ToolStripMenuItem A_0)
	{
		EventHandler value = p;
		ToolStripMenuItem toolStripMenuItem = this.m_an;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.DropDownOpening -= value;
		}
		this.m_an = A_0;
		toolStripMenuItem = this.m_an;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.DropDownOpening += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer e1()
	{
		return this.m_en;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void o(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = o;
		System.Timers.Timer timer = this.m_en;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		this.m_en = A_0;
		timer = this.m_en;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer e2()
	{
		return this.m_eo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void p(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = q;
		System.Timers.Timer timer = this.m_eo;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		this.m_eo = A_0;
		timer = this.m_eo;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer e3()
	{
		return this.m_ep;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void q(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = p;
		System.Timers.Timer timer = this.m_ep;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		this.m_ep = A_0;
		timer = this.m_ep;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual Label e4()
	{
		return this.m_ew;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void z(Label A_0)
	{
		EventHandler value = c0;
		EventHandler value2 = b7;
		EventHandler value3 = @as;
		EventHandler value4 = ap;
		EventHandler value5 = am;
		Label label = this.m_ew;
		if (label != null)
		{
			label.Click -= value;
			label.VisibleChanged -= value2;
			label.MouseEnter -= value3;
			label.MouseHover -= value4;
			label.MouseLeave -= value5;
		}
		this.m_ew = A_0;
		label = this.m_ew;
		if (label != null)
		{
			label.Click += value;
			label.VisibleChanged += value2;
			label.MouseEnter += value3;
			label.MouseHover += value4;
			label.MouseLeave += value5;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual Label e5()
	{
		return this.m_ex;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void aa(Label A_0)
	{
		EventHandler value = a5;
		EventHandler value2 = a2;
		EventHandler value3 = @as;
		EventHandler value4 = ao;
		EventHandler value5 = al;
		Label label = this.m_ex;
		if (label != null)
		{
			label.Click -= value;
			label.VisibleChanged -= value2;
			label.MouseEnter -= value3;
			label.MouseHover -= value4;
			label.MouseLeave -= value5;
		}
		this.m_ex = A_0;
		label = this.m_ex;
		if (label != null)
		{
			label.Click += value;
			label.VisibleChanged += value2;
			label.MouseEnter += value3;
			label.MouseHover += value4;
			label.MouseLeave += value5;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual Label e6()
	{
		return this.m_ey;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void ab(Label A_0)
	{
		EventHandler value = at;
		EventHandler value2 = @as;
		EventHandler value3 = aq;
		EventHandler value4 = an;
		EventHandler value5 = ak;
		Label label = this.m_ey;
		if (label != null)
		{
			label.Click -= value;
			label.MouseEnter -= value2;
			label.VisibleChanged -= value3;
			label.MouseHover -= value4;
			label.MouseLeave -= value5;
		}
		this.m_ey = A_0;
		label = this.m_ey;
		if (label != null)
		{
			label.Click += value;
			label.MouseEnter += value2;
			label.VisibleChanged += value3;
			label.MouseHover += value4;
			label.MouseLeave += value5;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public void o(c A_0)
	{
		c c10 = this.m_fv;
		c c11;
		do
		{
			c11 = c10;
			c value = (c)Delegate.Combine(c11, A_0);
			c10 = Interlocked.CompareExchange(ref this.m_fv, value, c11);
		}
		while ((object)c10 != c11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void p(c A_0)
	{
		c c10 = this.m_fv;
		c c11;
		do
		{
			c11 = c10;
			c value = (c)Delegate.Remove(c11, A_0);
			c10 = Interlocked.CompareExchange(ref this.m_fv, value, c11);
		}
		while ((object)c10 != c11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void o(d A_0)
	{
		d d10 = this.m_fw;
		d d11;
		do
		{
			d11 = d10;
			d value = (d)Delegate.Combine(d11, A_0);
			d10 = Interlocked.CompareExchange(ref this.m_fw, value, d11);
		}
		while ((object)d10 != d11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void p(d A_0)
	{
		d d10 = this.m_fw;
		d d11;
		do
		{
			d11 = d10;
			d value = (d)Delegate.Remove(d11, A_0);
			d10 = Interlocked.CompareExchange(ref this.m_fw, value, d11);
		}
		while ((object)d10 != d11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void o(e A_0)
	{
		e e10 = this.m_fx;
		e e11;
		do
		{
			e11 = e10;
			e value = (e)Delegate.Combine(e11, A_0);
			e10 = Interlocked.CompareExchange(ref this.m_fx, value, e11);
		}
		while ((object)e10 != e11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void p(e A_0)
	{
		e e10 = this.m_fx;
		e e11;
		do
		{
			e11 = e10;
			e value = (e)Delegate.Remove(e11, A_0);
			e10 = Interlocked.CompareExchange(ref this.m_fx, value, e11);
		}
		while ((object)e10 != e11);
	}

	[SpecialName]
	[CompilerGenerated]
	private bool du()
	{
		return this.m_gc;
	}

	[SpecialName]
	[CompilerGenerated]
	private void s(bool A_0)
	{
		this.m_gc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void o(p A_0)
	{
		p p2 = this.m_gd;
		p p3;
		do
		{
			p3 = p2;
			p value = (p)Delegate.Combine(p3, A_0);
			p2 = Interlocked.CompareExchange(ref this.m_gd, value, p3);
		}
		while ((object)p2 != p3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void p(p A_0)
	{
		p p2 = this.m_gd;
		p p3;
		do
		{
			p3 = p2;
			p value = (p)Delegate.Remove(p3, A_0);
			p2 = Interlocked.CompareExchange(ref this.m_gd, value, p3);
		}
		while ((object)p2 != p3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void o(q A_0)
	{
		q q2 = this.m_ge;
		q q3;
		do
		{
			q3 = q2;
			q value = (q)Delegate.Combine(q3, A_0);
			q2 = Interlocked.CompareExchange(ref this.m_ge, value, q3);
		}
		while ((object)q2 != q3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void p(q A_0)
	{
		q q2 = this.m_ge;
		q q3;
		do
		{
			q3 = q2;
			q value = (q)Delegate.Remove(q3, A_0);
			q2 = Interlocked.CompareExchange(ref this.m_ge, value, q3);
		}
		while ((object)q2 != q3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void o(r A_0)
	{
		r r2 = this.m_gf;
		r r3;
		do
		{
			r3 = r2;
			r value = (r)Delegate.Combine(r3, A_0);
			r2 = Interlocked.CompareExchange(ref this.m_gf, value, r3);
		}
		while ((object)r2 != r3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void p(r A_0)
	{
		r r2 = this.m_gf;
		r r3;
		do
		{
			r3 = r2;
			r value = (r)Delegate.Remove(r3, A_0);
			r2 = Interlocked.CompareExchange(ref this.m_gf, value, r3);
		}
		while ((object)r2 != r3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void q(r A_0)
	{
		r r2 = this.m_gg;
		r r3;
		do
		{
			r3 = r2;
			r value = (r)Delegate.Combine(r3, A_0);
			r2 = Interlocked.CompareExchange(ref this.m_gg, value, r3);
		}
		while ((object)r2 != r3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void r(r A_0)
	{
		r r2 = this.m_gg;
		r r3;
		do
		{
			r3 = r2;
			r value = (r)Delegate.Remove(r3, A_0);
			r2 = Interlocked.CompareExchange(ref this.m_gg, value, r3);
		}
		while ((object)r2 != r3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void o(s A_0)
	{
		s s2 = this.m_gh;
		s s3;
		do
		{
			s3 = s2;
			s value = (s)Delegate.Combine(s3, A_0);
			s2 = Interlocked.CompareExchange(ref this.m_gh, value, s3);
		}
		while ((object)s2 != s3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void p(s A_0)
	{
		s s2 = this.m_gh;
		s s3;
		do
		{
			s3 = s2;
			s value = (s)Delegate.Remove(s3, A_0);
			s2 = Interlocked.CompareExchange(ref this.m_gh, value, s3);
		}
		while ((object)s2 != s3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void o(t A_0)
	{
		t t2 = this.m_gi;
		t t3;
		do
		{
			t3 = t2;
			t value = (t)Delegate.Combine(t3, A_0);
			t2 = Interlocked.CompareExchange(ref this.m_gi, value, t3);
		}
		while ((object)t2 != t3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void p(t A_0)
	{
		t t2 = this.m_gi;
		t t3;
		do
		{
			t3 = t2;
			t value = (t)Delegate.Remove(t3, A_0);
			t2 = Interlocked.CompareExchange(ref this.m_gi, value, t3);
		}
		while ((object)t2 != t3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void o(u A_0)
	{
		u u2 = this.m_gj;
		u u3;
		do
		{
			u3 = u2;
			u value = (u)Delegate.Combine(u3, A_0);
			u2 = Interlocked.CompareExchange(ref this.m_gj, value, u3);
		}
		while ((object)u2 != u3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void p(u A_0)
	{
		u u2 = this.m_gj;
		u u3;
		do
		{
			u3 = u2;
			u value = (u)Delegate.Remove(u3, A_0);
			u2 = Interlocked.CompareExchange(ref this.m_gj, value, u3);
		}
		while ((object)u2 != u3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void o(v A_0)
	{
		v v2 = this.m_gk;
		v v3;
		do
		{
			v3 = v2;
			v value = (v)Delegate.Combine(v3, A_0);
			v2 = Interlocked.CompareExchange(ref this.m_gk, value, v3);
		}
		while ((object)v2 != v3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void p(v A_0)
	{
		v v2 = this.m_gk;
		v v3;
		do
		{
			v3 = v2;
			v value = (v)Delegate.Remove(v3, A_0);
			v2 = Interlocked.CompareExchange(ref this.m_gk, value, v3);
		}
		while ((object)v2 != v3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void o(w A_0)
	{
		w w2 = this.m_gl;
		w w3;
		do
		{
			w3 = w2;
			w value = (w)Delegate.Combine(w3, A_0);
			w2 = Interlocked.CompareExchange(ref this.m_gl, value, w3);
		}
		while ((object)w2 != w3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void p(w A_0)
	{
		w w2 = this.m_gl;
		w w3;
		do
		{
			w3 = w2;
			w value = (w)Delegate.Remove(w3, A_0);
			w2 = Interlocked.CompareExchange(ref this.m_gl, value, w3);
		}
		while ((object)w2 != w3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void o(x A_0)
	{
		x x2 = this.m_go;
		x x3;
		do
		{
			x3 = x2;
			x value = (x)Delegate.Combine(x3, A_0);
			x2 = Interlocked.CompareExchange(ref this.m_go, value, x3);
		}
		while ((object)x2 != x3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void p(x A_0)
	{
		x x2 = this.m_go;
		x x3;
		do
		{
			x3 = x2;
			x value = (x)Delegate.Remove(x3, A_0);
			x2 = Interlocked.CompareExchange(ref this.m_go, value, x3);
		}
		while ((object)x2 != x3);
	}

	[SpecialName]
	public long e7()
	{
		if (bp.Count > 0)
		{
			return bp[this.m_c6].a;
		}
		return -1L;
	}

	[SpecialName]
	public long e8()
	{
		if (bp.Count > 0)
		{
			return bp[this.m_c6][0].ac();
		}
		return -1L;
	}

	[SpecialName]
	public double e9()
	{
		return bp[this.m_c6][0].s;
	}

	[SpecialName]
	public bool o(long A_0, long A_1)
	{
		int A_2 = default(int);
		if (o(A_0, ref A_2))
		{
			return bp[A_2][0].ac() == A_1;
		}
		return false;
	}

	public void o(string A_0, long A_1)
	{
		foreach (a<fx> item in bp)
		{
			if (item.a == A_1)
			{
				item.b = A_0;
				aq();
				break;
			}
		}
	}

	[SpecialName]
	public double fa()
	{
		double num = double.MinValue;
		foreach (a<fx> item in bp)
		{
			foreach (fx item2 in item)
			{
				if (item2.y() > num)
				{
					num = item2.y();
				}
			}
		}
		if (this.m_d9 != null)
		{
			if (this.m_d9.y() > num)
			{
				num = this.m_d9.y();
			}
			fx fx2 = this.m_d9.ah();
			if (fx2 != null && fx2.y() > num)
			{
				num = fx2.y();
			}
		}
		return num;
	}

	[SpecialName]
	public double fb()
	{
		double num = double.MaxValue;
		foreach (a<fx> item in bp)
		{
			foreach (fx item2 in item)
			{
				if (item2.z() < num)
				{
					num = item2.z();
				}
			}
		}
		if (this.m_d9 != null)
		{
			if (this.m_d9.z() < num)
			{
				num = this.m_d9.z();
			}
			fx fx2 = this.m_d9.ah();
			if (fx2 != null && fx2.z() < num)
			{
				num = fx2.z();
			}
		}
		return num;
	}

	[SpecialName]
	public double fc()
	{
		return p(A_0: true, A_1: false);
	}

	[SpecialName]
	public double fd()
	{
		return p(A_0: false, A_1: false);
	}

	[SpecialName]
	private double p(bool A_0, bool A_1)
	{
		double num = double.MinValue;
		fr fr2 = this.m_em.a2();
		fx fx2;
		foreach (a<fx> item in bp)
		{
			foreach (fx item2 in item)
			{
				fx2 = null;
				if (o(A_0, item))
				{
					fx2 = item2;
				}
				else if (item2 != null)
				{
					fx2 = item2.ah();
				}
				if (fx2 == null)
				{
					continue;
				}
				double num2;
				if (A_1)
				{
					num2 = fx2.w();
				}
				else
				{
					num2 = fx2.q(fr2.ap(), fr2.aq());
					if (fx2.ai() != null)
					{
						foreach (fx item3 in fx2.ai())
						{
							double num3 = item3.q(fr2.ap(), fr2.aq());
							if (num3 > num2)
							{
								num2 = num3;
							}
						}
					}
				}
				if (num2 > num)
				{
					num = num2;
				}
			}
		}
		fx2 = null;
		if (r(A_0))
		{
			fx2 = ((!da() || this.m_d9 == null) ? this.m_d9 : this.m_d9.ah());
		}
		else if (this.m_d9 != null)
		{
			fx2 = this.m_d9.ah();
		}
		if (fx2 != null)
		{
			double num2;
			if (A_1)
			{
				num2 = fx2.w();
			}
			else
			{
				num2 = fx2.q(fr2.ap(), fr2.aq());
				if (fx2.ai() != null)
				{
					foreach (fx item4 in fx2.ai())
					{
						double num3 = item4.q(fr2.ap(), fr2.aq());
						if (num3 > num2)
						{
							num2 = num3;
						}
					}
				}
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		fr2 = null;
		return num;
	}

	[SpecialName]
	public double fe()
	{
		return o(A_0: true, A_1: false);
	}

	[SpecialName]
	public double ff()
	{
		return o(A_0: false, A_1: false);
	}

	[SpecialName]
	private double o(bool A_0, bool A_1)
	{
		double num = double.MaxValue;
		fr fr2 = this.m_em.a2();
		fx fx2;
		foreach (a<fx> item in bp)
		{
			foreach (fx item2 in item)
			{
				fx2 = null;
				if (o(A_0, item))
				{
					fx2 = item2;
				}
				else if (item2 != null)
				{
					fx2 = item2.ah();
				}
				if (fx2 == null)
				{
					continue;
				}
				double num2;
				if (A_1)
				{
					num2 = fx2.x();
				}
				else
				{
					num2 = fx2.t(fr2.ap(), fr2.aq());
					if (fx2.ai() != null)
					{
						foreach (fx item3 in fx2.ai())
						{
							double num3 = item3.t(fr2.ap(), fr2.aq());
							if (num3 < num2)
							{
								num2 = num3;
							}
						}
					}
				}
				if (num2 < num)
				{
					num = num2;
				}
			}
		}
		fx2 = null;
		if (r(A_0))
		{
			fx2 = this.m_d9;
		}
		else if (this.m_d9 != null)
		{
			fx2 = this.m_d9.ah();
		}
		if (fx2 != null)
		{
			double num2;
			if (A_1)
			{
				num2 = fx2.x();
			}
			else
			{
				num2 = fx2.t(fr2.ap(), fr2.aq());
				if (fx2.ai() != null)
				{
					foreach (fx item4 in fx2.ai())
					{
						double num3 = item4.t(fr2.ap(), fr2.aq());
						if (num3 < num2)
						{
							num2 = num3;
						}
					}
				}
			}
			if (num2 < num)
			{
				num = num2;
			}
		}
		fr2 = null;
		return num;
	}

	[SpecialName]
	public int fg()
	{
		return bp.Count;
	}

	[SpecialName]
	public int p(long A_0, long A_1)
	{
		int A_2 = default(int);
		if (o(A_0, ref A_2) && bp[A_2][0].ac() == A_1)
		{
			return bp[A_2][0].aa();
		}
		return 0;
	}

	[SpecialName]
	public long fh()
	{
		return this.m_ec;
	}

	[SpecialName]
	public long fi()
	{
		if (this.m_d9 != null)
		{
			return this.m_d9.ac();
		}
		return -1L;
	}

	[SpecialName]
	public string fj()
	{
		string result;
		try
		{
			result = el().Text;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[SpecialName]
	public void q(string A_0)
	{
		int a_ = 0;
		el().Text = A_0;
		if (this.m_d9 != null)
		{
			a_ = 1;
		}
		Panel A_1 = eh();
		Panel A_2 = ei();
		o(ref A_1, ref A_2, this.m_du, this.m_d8, a_, this.m_c3);
		t(A_2);
		s(A_1);
	}

	[SpecialName]
	public bool fk()
	{
		if (this.m_d9 != null)
		{
			return this.m_d9.ah() != null;
		}
		return false;
	}

	[SpecialName]
	public bool fl()
	{
		if (bp != null && bp.Count > this.m_c6)
		{
			return bp[this.m_c6][0].ah() != null;
		}
		return false;
	}

	[SpecialName]
	public bool fm()
	{
		if (bp.Count <= 0 || !bq)
		{
			if (bp.Count == 0)
			{
				return br;
			}
			return false;
		}
		return true;
	}

	[SpecialName]
	public bool fn()
	{
		return a0;
	}

	[SpecialName]
	public void t(bool A_0)
	{
		a0 = A_0;
	}

	[SpecialName]
	public int fo()
	{
		return bb;
	}

	[SpecialName]
	public void q(int A_0)
	{
		bb = A_0;
	}

	[SpecialName]
	public bool fp()
	{
		return this.m_f5;
	}

	[SpecialName]
	public void u(bool A_0)
	{
		this.m_f5 = A_0;
		this.m_f1 = A_0;
	}

	[SpecialName]
	public bool fq()
	{
		return ax;
	}

	[SpecialName]
	public void v(bool A_0)
	{
		ax = A_0;
	}

	[SpecialName]
	public bool fr()
	{
		return aw;
	}

	public void fs()
	{
		this.m_aq = default(z);
		this.m_ar = default(z);
		aw = false;
		Invalidate();
	}

	[SpecialName]
	public z ft()
	{
		return this.m_aq;
	}

	[SpecialName]
	public bool fu()
	{
		return this.m_ev;
	}

	[SpecialName]
	public void w(bool A_0)
	{
		bool flag = this.m_ev;
		this.m_ev = A_0;
		if (this.m_ev != flag && this.m_em != null)
		{
			this.m_em.a5();
		}
	}

	[SpecialName]
	public bool fv()
	{
		return this.m_eh;
	}

	[SpecialName]
	public void x(bool A_0)
	{
		this.m_eh = A_0;
		Cursor cursor = ((!this.m_eh) ? Cursors.Hand : Cursors.Default);
		d7().Cursor = cursor;
		ec().Cursor = cursor;
		ed().Cursor = cursor;
		eb().Cursor = cursor;
		d8().Cursor = cursor;
		ea().Cursor = cursor;
		ee().Cursor = cursor;
		ef().Cursor = cursor;
		d9().Cursor = cursor;
		eg().Cursor = cursor;
		aq();
	}

	[SpecialName]
	public Rectangle fw()
	{
		p(false);
		checked
		{
			return new Rectangle(b3, b5, (short)unchecked(b4 - b3) + 1, (short)unchecked(b1 - b5) + 1);
		}
	}

	[SpecialName]
	public string fx()
	{
		return this.m_ei;
	}

	[SpecialName]
	public void r(string A_0)
	{
		this.m_ei = A_0;
	}

	[SpecialName]
	public double fy()
	{
		return this.m_em.a2().ap();
	}

	[SpecialName]
	public double fz()
	{
		return this.m_em.a2().aq();
	}

	[SpecialName]
	public double f0()
	{
		return this.m_em.a0();
	}

	[SpecialName]
	public double f1()
	{
		return this.m_em.at(false);
	}

	[SpecialName]
	public int f2()
	{
		r(CreateGraphics(), false);
		checked
		{
			return (short)unchecked(ak() - aj());
		}
	}

	[SpecialName]
	public bool f3()
	{
		return ba;
	}

	[SpecialName]
	public void y(bool A_0)
	{
		bool flag = false;
		if (A_0 != ba)
		{
			flag = true;
		}
		ba = A_0;
		if (flag)
		{
			hb();
		}
	}

	[SpecialName]
	public bool f4()
	{
		return this.m_dy;
	}

	[SpecialName]
	public void z(bool A_0)
	{
		this.m_dy = A_0;
		an();
	}

	[SpecialName]
	public bool f5()
	{
		return this.m_dx;
	}

	[SpecialName]
	public void aa(bool A_0)
	{
		this.m_dx = A_0;
		an();
	}

	[SpecialName]
	public bool f6()
	{
		return this.m_dw;
	}

	[SpecialName]
	public void ab(bool A_0)
	{
		this.m_dw = A_0;
		an();
	}

	[SpecialName]
	public bool f8()
	{
		return this.m_dz;
	}

	[SpecialName]
	public void ac(bool A_0)
	{
		this.m_dz = A_0;
		an();
	}

	[SpecialName]
	public bool gc()
	{
		return be;
	}

	[SpecialName]
	public void ad(bool A_0)
	{
		be = A_0;
	}

	[SpecialName]
	public bool gd()
	{
		Point point = PointToClient(Control.MousePosition);
		return p((float)point.X, (float)point.Y);
	}

	[SpecialName]
	public bool ge()
	{
		return this.m_dq;
	}

	[SpecialName]
	public void ae(bool A_0)
	{
		bool flag = false;
		if (A_0 != this.m_dq)
		{
			flag = true;
		}
		this.m_dq = A_0;
		Panel A_1 = d4();
		Panel A_2 = d5();
		o(ref A_1, ref A_2, this.m_dt, this.m_dq, bp.Count, this.m_c2);
		q(A_2);
		p(A_1);
		if (flag)
		{
			hb();
		}
	}

	[SpecialName]
	public bool gf()
	{
		return this.m_d8;
	}

	[SpecialName]
	public void af(bool A_0)
	{
		bool flag = false;
		int a_ = 0;
		if (A_0 != this.m_d8)
		{
			flag = true;
		}
		this.m_d8 = A_0;
		if (this.m_d9 != null)
		{
			a_ = 1;
		}
		Panel A_1 = eh();
		Panel A_2 = ei();
		o(ref A_1, ref A_2, this.m_du, this.m_d8, a_, this.m_c3);
		t(A_2);
		s(A_1);
		if (flag)
		{
			hb();
		}
	}

	[SpecialName]
	public bool gg()
	{
		return bc;
	}

	[SpecialName]
	public void ag(bool A_0)
	{
		bool flag = false;
		if (bc != A_0)
		{
			flag = true;
		}
		bc = A_0;
		if (flag)
		{
			hb();
		}
	}

	[SpecialName]
	public bool gh()
	{
		return bd;
	}

	[SpecialName]
	public void ah(bool A_0)
	{
		bool flag = false;
		if (bd != A_0)
		{
			flag = true;
		}
		bd = A_0;
		if (flag)
		{
			hb();
		}
	}

	[SpecialName]
	public fu gi()
	{
		return this.m_em;
	}

	[SpecialName]
	public void o(fu A_0)
	{
		if (this.m_em != null)
		{
			this.m_em.an(ae);
			this.m_em.a3().ap(r);
			this.m_em.a3().an((fs.a)q);
			this.m_em.a4().ap(p);
			this.m_em.a4().an((fs.a)o);
			this.m_em.a3().an((fs.b)p);
			this.m_em.a4().an((fs.b)p);
		}
		this.m_em = A_0;
		if (this.m_em != null)
		{
			this.m_em.am(ae);
			this.m_em.a3().ao(r);
			this.m_em.a3().am((fs.a)q);
			this.m_em.a4().ao(p);
			this.m_em.a4().am((fs.a)o);
			this.m_em.a3().am((fs.b)p);
			this.m_em.a4().am((fs.b)p);
			z();
			try
			{
				eu().Checked = this.m_em.a2().av();
				et().Checked = this.m_em.a2().au();
				es().Checked = this.m_em.a2().at();
			}
			finally
			{
				y();
			}
			hb();
		}
	}

	[SpecialName]
	public string gj()
	{
		return bf;
	}

	[SpecialName]
	public void s(string A_0)
	{
		bool flag = false;
		if (Operators.CompareString(bf, A_0, TextCompare: false) != 0)
		{
			flag = true;
		}
		bf = A_0;
		if (flag)
		{
			hb();
		}
	}

	[SpecialName]
	public string gk()
	{
		if (gj().LastIndexOf("(") > 0 && gj().LastIndexOf(")") > 0)
		{
			return gj().Substring(0, gj().LastIndexOf("(")).TrimEnd();
		}
		return gj();
	}

	[SpecialName]
	private string dt()
	{
		int num = gj().LastIndexOf("(");
		int num2 = gj().LastIndexOf(")");
		if (num >= 0 && num2 > num)
		{
			return checked(gj().Substring(num + 1, num2 - num - 1)).TrimEnd();
		}
		return string.Empty;
	}

	[SpecialName]
	public string r(int A_0)
	{
		return bg[A_0];
	}

	[SpecialName]
	public bool gl()
	{
		return bu;
	}

	[SpecialName]
	public bool go()
	{
		if (gv())
		{
			if (bo)
			{
				return fk();
			}
			return fl();
		}
		return bu;
	}

	[SpecialName]
	public bool gp()
	{
		if (gi().at())
		{
			return fm();
		}
		return false;
	}

	[SpecialName]
	public bool gq()
	{
		return this.m_es;
	}

	[SpecialName]
	public void ai(bool A_0)
	{
		this.m_es = A_0;
		hb();
	}

	[SpecialName]
	public bool gr()
	{
		return this.m_et;
	}

	[SpecialName]
	public void aj(bool A_0)
	{
		this.m_et = A_0;
	}

	[SpecialName]
	public void ak(bool A_0)
	{
		cq = A_0;
	}

	[SpecialName]
	public void o(short A_0)
	{
		cm = A_0;
	}

	[SpecialName]
	public void p(short A_0)
	{
		cn = A_0;
	}

	[SpecialName]
	public void q(short A_0)
	{
		cp = A_0;
	}

	[SpecialName]
	public void r(short A_0)
	{
		co = A_0;
	}

	[SpecialName]
	public void s(short A_0)
	{
		cl = A_0;
	}

	[SpecialName]
	public void ac(Label A_0)
	{
		this.m_a2 = A_0;
	}

	[SpecialName]
	public void ad(Label A_0)
	{
		a3 = A_0;
	}

	[SpecialName]
	public void ae(Label A_0)
	{
		a4 = A_0;
	}

	[SpecialName]
	public void af(Label A_0)
	{
		this.m_a5 = A_0;
	}

	[SpecialName]
	public void ag(Label A_0)
	{
		a6 = A_0;
	}

	[SpecialName]
	public void ah(Label A_0)
	{
		a7 = A_0;
	}

	[SpecialName]
	public bool gs()
	{
		return a8;
	}

	[SpecialName]
	public void al(bool A_0)
	{
		a8 = A_0;
	}

	[SpecialName]
	public bool gt()
	{
		return bm;
	}

	[SpecialName]
	public bool gu()
	{
		if (gt())
		{
			return bo;
		}
		return false;
	}

	[SpecialName]
	public bool gv()
	{
		if (bm && bp.Count > 0)
		{
			if (bo)
			{
				return this.m_d9 != null;
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool gw()
	{
		return this.m_gp;
	}

	[SpecialName]
	[CompilerGenerated]
	public void am(bool A_0)
	{
		this.m_gp = A_0;
	}

	[SpecialName]
	public fz gx()
	{
		return az;
	}

	[SpecialName]
	public void o(fz A_0)
	{
		az = A_0;
	}

	[SpecialName]
	public gq gy()
	{
		return this.m_ej;
	}

	[SpecialName]
	public void o(gq A_0)
	{
		this.m_ej = A_0;
	}

	[SpecialName]
	public void o(fm A_0)
	{
		if (this.m_e0 != null)
		{
			this.m_e0.c(al);
		}
		this.m_e0 = A_0;
		if (this.m_em != null)
		{
			this.m_e0.b(al);
		}
	}

	[SpecialName]
	public bool gz()
	{
		return this.m_fn;
	}

	[SpecialName]
	public void an(bool A_0)
	{
		this.m_fn = A_0;
	}

	[SpecialName]
	public string g0()
	{
		return this.m_fo;
	}

	[SpecialName]
	public void t(string A_0)
	{
		this.m_fo = A_0;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern int GetDoubleClickTime();

	public fl()
	{
		base.Load += df;
		base.MouseClick += ag;
		base.MouseHover += de;
		base.MouseLeave += dd;
		base.MouseMove += af;
		base.Paint += o;
		base.Resize += dc;
		base.SizeChanged += db;
		base.PreviewKeyDown += o;
		base.KeyDown += p;
		base.MouseDoubleClick += ae;
		base.MouseDown += ad;
		base.MouseUp += ac;
		base.MouseEnter += c9;
		base.HandleDestroyed += o;
		this.m_aq = default(z);
		this.m_ar = default(z);
		au = new Pen(Color.Blue, 1f);
		checked
		{
			bg = new string[Enum.GetValues(typeof(h)).Length - 1 + 1];
			bh = new string[Enum.GetValues(typeof(h)).Length - 1 + 1];
			cb = 25;
			cq = false;
			cr = SystemColors.Window;
			cs = Color.Black;
			ct = Color.Black;
			cu = Color.Blue;
			cv = Color.Lime;
			cw = Color.Red;
			this.m_c2 = new k();
			this.m_c3 = new k();
			this.m_dr = new bool[10];
			this.m_ds = new Color[10];
			this.m_dt = new Label[10];
			this.m_du = new Label[1];
			this.m_d1 = new Label[Enum.GetValues(typeof(h)).Length - 1 + 1];
			this.m_d2 = new bool[Enum.GetValues(typeof(h)).Length - 1 + 1];
			z(new Label());
			aa(new Label());
			ab(new Label());
			this.m_e4 = 1f;
			this.m_fd = new List<fo>();
			this.m_fe = new List<string>();
			this.m_ff = new List<string>();
			this.m_fg = new Collection<List<string>>();
			this.m_fj = new List<bool>();
			this.m_fn = true;
			this.m_fp = default(Rectangle);
			this.m_fy = new b();
			f7 = true;
			this.m_gq = 0.2f;
			dv();
			q(1);
			bz = 0;
			string A_ = "GraphToolTip";
			this.m_ei = hu.a(ref A_);
			this.m_fr = eu().Text;
			this.m_fs = ev().Text;
			this.m_ft = ex().Text;
			bp = new Collection<a<fx>>();
			a8 = true;
			d4().Visible = false;
			eh().Visible = false;
			short num = 0;
			do
			{
				this.m_dr[num] = false;
				num = (short)unchecked(num + 1);
			}
			while (num <= 9);
			this.m_dt[0] = d7();
			this.m_dt[1] = ec();
			this.m_dt[2] = ed();
			this.m_dt[3] = eb();
			this.m_dt[4] = d8();
			this.m_dt[5] = ea();
			this.m_dt[6] = ee();
			this.m_dt[7] = ef();
			this.m_dt[8] = d9();
			this.m_dt[9] = eg();
			this.m_du[0] = el();
			this.m_ds[0] = Color.FromArgb(255, 0, 0, 255);
			this.m_ds[3] = Color.FromArgb(255, 200, 200, 60);
			this.m_ds[2] = Color.FromArgb(255, 100, 20, 170);
			this.m_ds[1] = Color.FromArgb(255, 0, 255, 0);
			this.m_ds[4] = Color.FromArgb(255, 0, 128, 128);
			this.m_ds[5] = Color.FromArgb(255, 0, 255, 255);
			this.m_ds[6] = Color.FromArgb(255, 255, 127, 0);
			this.m_ds[7] = Color.FromArgb(255, 127, 127, 255);
			this.m_ds[8] = Color.FromArgb(255, 255, 0, 255);
			this.m_ds[9] = Color.FromArgb(255, 130, 72, 34);
			o(new System.Timers.Timer());
			System.Timers.Timer timer = e1();
			timer.Interval = 1.0;
			timer.AutoReset = false;
			_ = null;
			f9 = true;
			er = new ManualResetEvent(initialState: true);
			c0();
			p(new System.Timers.Timer());
			System.Timers.Timer timer2 = e2();
			timer2.Interval = 100.0;
			timer2.AutoReset = false;
			_ = null;
			q(new System.Timers.Timer());
			System.Timers.Timer timer3 = e3();
			timer3.Interval = GetDoubleClickTime() + 50;
			timer3.AutoReset = false;
			_ = null;
			r();
		}
	}

	~fl()
	{
		bp = null;
		base.Finalize();
	}

	public void o(double[] A_0, double[] A_1, double[] A_2, double[] A_3, bool[] A_4, bool[] A_5, int A_6)
	{
		bool flag = false;
		checked
		{
			if (A_6 != this.m_dg)
			{
				flag = true;
			}
			else if (this.m_dg > 0)
			{
				int num = this.m_dg - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (this.m_c8[num2] != A_0[num2])
					{
						flag = true;
						break;
					}
					if (this.m_c9[num2] != A_1[num2])
					{
						flag = true;
						break;
					}
					if (this.m_da[num2] != A_2[num2])
					{
						flag = true;
						break;
					}
					if (this.m_db[num2] != A_3[num2])
					{
						flag = true;
						break;
					}
					if (this.m_dc[num2] != A_4[num2])
					{
						flag = true;
						break;
					}
					if (this.m_dd[num2] != A_5[num2])
					{
						flag = true;
						break;
					}
				}
			}
			this.m_dg = A_6;
			if (this.m_dg == 0)
			{
				this.m_df = 0;
			}
			this.m_c8 = new double[this.m_dg - 1 + 1];
			this.m_c9 = new double[this.m_dg - 1 + 1];
			this.m_da = new double[this.m_dg - 1 + 1];
			this.m_db = new double[this.m_dg - 1 + 1];
			this.m_dc = new bool[this.m_dg - 1 + 1];
			this.m_dd = new bool[this.m_dg - 1 + 1];
			int num3 = this.m_dg - 1;
			for (int num2 = 0; num2 <= num3; num2++)
			{
				this.m_c8[num2] = A_0[num2];
				this.m_c9[num2] = A_1[num2];
				this.m_da[num2] = A_2[num2];
				this.m_db[num2] = A_3[num2];
				this.m_dc[num2] = A_4[num2];
				this.m_dd[num2] = A_5[num2];
			}
			if (flag)
			{
				hb();
			}
		}
	}

	public void p(double[] A_0, double[] A_1, double[] A_2, double[] A_3, bool[] A_4, bool[] A_5, int A_6)
	{
		bool flag = false;
		checked
		{
			if (A_6 != this.m_do)
			{
				flag = true;
			}
			else if (this.m_do > 0)
			{
				int num = this.m_do - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (this.m_dh[num2] != A_0[num2])
					{
						flag = true;
						break;
					}
					if (this.m_di[num2] != A_1[num2])
					{
						flag = true;
						break;
					}
					if (this.m_dj[num2] != A_2[num2])
					{
						flag = true;
						break;
					}
					if (this.m_dk[num2] != A_3[num2])
					{
						flag = true;
						break;
					}
					if (this.m_dl[num2] != A_4[num2])
					{
						flag = true;
						break;
					}
					if (this.m_dm[num2] != A_5[num2])
					{
						flag = true;
						break;
					}
				}
			}
			this.m_do = A_6;
			if (this.m_do == 0)
			{
				this.m_dp = 0;
			}
			this.m_dh = new double[this.m_do - 1 + 1];
			this.m_di = new double[this.m_do - 1 + 1];
			this.m_dj = new double[this.m_do - 1 + 1];
			this.m_dk = new double[this.m_do - 1 + 1];
			this.m_dl = new bool[this.m_do - 1 + 1];
			this.m_dm = new bool[this.m_do - 1 + 1];
			int num3 = this.m_do - 1;
			for (int num2 = 0; num2 <= num3; num2++)
			{
				this.m_dh[num2] = A_0[num2];
				this.m_di[num2] = A_1[num2];
				this.m_dj[num2] = A_2[num2];
				this.m_dk[num2] = A_3[num2];
				this.m_dl[num2] = A_4[num2];
				this.m_dm[num2] = A_5[num2];
			}
			if (flag)
			{
				hb();
			}
		}
	}

	public void o(float[] A_0, int A_1)
	{
		bool flag = false;
		checked
		{
			if (this.m_df != A_1)
			{
				flag = true;
			}
			else if (this.m_df > 0)
			{
				int num = this.m_df - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (this.m_de[num2] != (double)A_0[num2])
					{
						flag = true;
						break;
					}
				}
			}
			this.m_df = A_1;
			this.m_de = new double[this.m_df - 1 + 1];
			int num3 = this.m_df - 1;
			for (int num2 = 0; num2 <= num3; num2++)
			{
				this.m_de[num2] = A_0[num2];
			}
			if (flag)
			{
				hb();
			}
		}
	}

	public void o(cc.a[] A_0, int A_1)
	{
		bool flag = false;
		checked
		{
			if (this.m_dp != A_1)
			{
				flag = true;
			}
			else if (this.m_dp > 0)
			{
				int num = this.m_dp - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (global::cc.a.f(this.m_dn[num2], A_0[num2]))
					{
						flag = true;
						break;
					}
				}
			}
			this.m_dp = A_1;
			this.m_dn = new cc.a[this.m_dp - 1 + 1];
			int num3 = this.m_dp - 1;
			for (int num2 = 0; num2 <= num3; num2++)
			{
				this.m_dn[num2] = A_0[num2];
			}
			if (flag)
			{
				hb();
			}
		}
	}

	public void o(double[] A_0, double[] A_1, int A_2, long A_3, long A_4, double A_5, string A_6, string A_7, bool A_8, bool A_9)
	{
		n n2 = new n();
		o a_ = new o(A_0, A_1, A_2, null, null, 0);
		n2.e(a_);
		o(n2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_8: true, A_9: false, default(Color));
	}

	public void o(double[] A_0, double[] A_1, int A_2, long A_3, long A_4, double A_5, string A_6, string A_7, bool A_8, bool A_9, bool A_10, Color A_11)
	{
		n n2 = new n();
		o a_ = new o(A_0, A_1, A_2, null, null, 0);
		n2.e(a_);
		o(n2, A_3, A_4, A_5, A_6, A_7, A_8, A_10, A_9, A_9: true, A_11);
	}

	public void o(n A_0, long A_1, long A_2, double A_3, string A_4, string A_5, bool A_6, bool A_7, bool A_8, bool A_9, Color A_10)
	{
		o(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10, global::fl.h.a);
	}

	public void o(n A_0, long A_1, long A_2, double A_3, string A_4, string A_5, bool A_6, bool A_7, bool A_8, bool A_9, Color A_10, h A_11)
	{
		bool flag = false;
		if (!A_0.g())
		{
			return;
		}
		if (bp.Count > 0)
		{
			if (bq != A_7)
			{
				throw new l("Error: Attempt to add curve with yPercentageDisplay incompatible with existing curvesets");
			}
			if (Operators.CompareString(bt, A_5, TextCompare: false) != 0)
			{
				throw new l("Error: Attempt to add curve with curveTypeName different than existing curvesets");
			}
			bu = bu || (da() && A_11 != global::fl.h.b) || c7() > 0 || (!da() && A_11 == global::fl.h.b);
		}
		else
		{
			bq = A_7;
			bt = A_5;
			bu = A_0.h();
			an();
		}
		checked
		{
			a<fx> A_13;
			int A_12 = default(int);
			if (o(A_1, ref A_12))
			{
				A_13 = bp[A_12];
				this.m_c6 = A_12;
				flag = true;
				A_13.g = A_11;
				bool a_ = A_13.u();
				bool flag2 = A_13.v();
				bool flag3 = A_13[0].ah() != null;
				bool flag4 = A_13[0].ai() != null;
				bool[] array = null;
				if (flag4)
				{
					array = new bool[A_13[0].ai().Count - 1 + 1];
					int num = A_13[0].ai().Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						array[num2] = A_13.r(num2);
					}
				}
				o(A_13, A_0, A_2, A_3, A_6);
				A_13.r(a_);
				A_13.s((flag3 && flag2) || !flag3);
				if (A_13.w() != null)
				{
					int num3 = A_13[0].ai().Count - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						A_13.r(num4, (flag4 && array[num4]) || !flag4);
					}
				}
				else if (A_13[0].ai() != null)
				{
					A_13.r(new List<bool>());
					int num5 = A_13[0].ai().Count - 1;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						A_13.w().Add(item: true);
					}
					if (this.m_fj.Count == 0)
					{
						this.m_fj.Add(item: true);
					}
				}
			}
			else
			{
				A_13 = new a<fx>();
				a<fx> a10 = A_13;
				a10.a = A_1;
				a10.b = A_4;
				if (A_9)
				{
					a10.d = false;
					a10.c = A_10;
				}
				else
				{
					o(ref A_13);
				}
				a10 = null;
				A_12 = bp.Count;
				A_13.g = A_11;
				o(A_13, A_0, A_2, A_3, A_6);
				bp.Add(A_13);
				flag = true;
				int num7 = this.m_c6;
				this.m_c6 = bp.Count - 1;
				A_13.r(A_0.g());
				A_13.s(A_0.h());
				if (!A_0.f())
				{
					A_13.r((List<bool>)null);
				}
				else
				{
					if (A_13.w() == null)
					{
						A_13.r(new List<bool>());
					}
					int num8 = bp[this.m_c6][0].ai().Count - 1;
					for (int num9 = 0; num9 <= num8; num9++)
					{
						A_13.w().Add(item: true);
					}
					if (this.m_fj.Count == 0)
					{
						this.m_fj.Add(item: false);
					}
				}
				if (this.m_fd.Count > 0)
				{
					int num10 = this.m_fd.Count - 1;
					bool flag5 = default(bool);
					for (int num11 = 0; num11 <= num10; num11++)
					{
						if (this.m_fd[num11].a == -1)
						{
							flag5 = true;
							this.m_fd[num11].a = o(A_12);
							this.m_fd[num11].e = A_13.b;
							break;
						}
					}
					if (!flag5 && A_12 >= this.m_fd.Count)
					{
						this.m_fd.Add(new fo(o(A_12), A_13.b));
					}
				}
				else
				{
					this.m_fd.Add(new fo(o(A_12), A_13.b));
				}
				int num12 = this.m_fd[A_12].b.Count - 1;
				for (int num13 = 0; num13 <= num12; num13++)
				{
					List<string> list = A_13[0].ad();
					if (!list.Contains(this.m_fd[A_12].b[num13]))
					{
						list.Add(this.m_fd[A_12].b[num13]);
					}
					list = null;
				}
				if (A_13[0].ah() != null)
				{
					int num14 = this.m_fd[A_12].c.Count - 1;
					for (int num15 = 0; num15 <= num14; num15++)
					{
						List<string> list2 = A_13[0].ah().ad();
						if (!list2.Contains(this.m_fd[A_12].c[num15]))
						{
							list2.Add(this.m_fd[A_12].c[num15]);
						}
						list2 = null;
					}
				}
				if (A_13[0].ai() != null)
				{
					int num16 = this.m_fd[A_12].d.Count - 1;
					for (int num17 = 0; num17 <= num16; num17++)
					{
						int num18 = this.m_fd[A_12].d[num17].Count - 1;
						for (int num19 = 0; num19 <= num18; num19++)
						{
							List<string> list3 = A_13[0].ai()[num17].ad();
							if (!list3.Contains(this.m_fd[A_12].d[num17][num19]))
							{
								list3.Add(this.m_fd[A_12].d[num17][num19]);
							}
							list3 = null;
						}
					}
				}
				if (num7 != this.m_c6 && num7 != -1)
				{
					p(num7);
				}
				else
				{
					u();
				}
			}
			o();
			A_13.f = A_8;
			if (Operators.CompareString(A_13.b, A_4, TextCompare: false) != 0)
			{
				A_13.b = A_4;
				flag = true;
			}
			if (flag)
			{
				aq();
				ap();
			}
			hb();
		}
	}

	public void o(double[] A_0, double[] A_1, int A_2, long A_3, long A_4, string A_5, string A_6, string A_7, bool A_8, bool A_9)
	{
		n n2 = new n();
		o a_ = new o(A_0, A_1, A_2, null, null, 0);
		n2.e(a_);
		o(n2, A_3, A_4, A_5, A_6, A_7, A_8, global::fl.h.a, A_9);
	}

	public void o(n A_0, long A_1, long A_2, string A_3, string A_4, string A_5, bool A_6, h A_7, bool A_8)
	{
		if (!A_0.g())
		{
			return;
		}
		g a_ = ((A_7 == global::fl.h.b) ? ((!da() && fg() != 0) ? global::fl.g.c : global::fl.g.a) : ((A_7 == global::fl.h.c && !dm()) ? global::fl.g.b : global::fl.g.a));
		this.m_d9 = new fx(a_);
		this.m_ee = A_7;
		this.m_ef = a_;
		this.m_eg = A_8;
		fx obj = this.m_d9;
		double[] a_2 = A_0.e()[0].a;
		double[] a_3 = A_0.e()[0].b;
		int a_4 = A_0.e()[0].c;
		fl A_9 = this;
		obj.q(a_2, a_3, a_4, ref A_9);
		obj.q(Color.Red);
		obj.q(A_6);
		obj.q(A_2);
		_ = null;
		if (A_0.e()[0].f > 0)
		{
			this.m_d9.q(new fx(global::fl.g.c));
			fx obj2 = this.m_d9.ah();
			double[] a_5 = A_0.e()[0].d;
			double[] a_6 = A_0.e()[0].e;
			int a_7 = A_0.e()[0].f;
			A_9 = this;
			obj2.q(a_5, a_6, a_7, ref A_9);
			obj2.q(Color.Red);
			obj2.q(A_6);
			obj2.q(A_2);
			_ = null;
		}
		else
		{
			this.m_d9.q((fx)null);
		}
		if (this.m_d9.ai() != null)
		{
			this.m_d9.aj();
		}
		checked
		{
			int num = A_0.e().Count - 1;
			for (int num2 = 1; num2 <= num; num2++)
			{
				fx fx2 = new fx(global::fl.g.b);
				if (num2 > 1)
				{
					throw new l("Error: Attempting to add undefined curve type (index = " + num2 + ", type = primary)");
				}
				this.m_d9.t(fx2);
				fx2.q(A_2);
				fx2.q(A_6);
				double[] a_8 = A_0.e()[num2].a;
				double[] a_9 = A_0.e()[num2].b;
				int a_10 = A_0.e()[num2].c;
				A_9 = this;
				fx2.q(a_8, a_9, a_10, ref A_9);
				fx2.q(Color.Red);
				if (A_0.e()[num2].f > 0)
				{
					new fx(global::fl.g.d);
					throw new l("Error: Attempting to add undefined curve type (index = " + num2 + ", type = secondary)");
				}
			}
			this.m_ec = A_1;
			this.m_ed = A_3;
			this.m_ea = A_4;
			this.m_eb = A_5;
			am();
			ao();
			hb();
		}
	}

	public void o(ref double[] A_0, ref double[] A_1, int A_2, long A_3, long A_4, double A_5, string A_6, string A_7, bool A_8, bool A_9)
	{
		int A_10 = default(int);
		if (o(A_3, ref A_10) && bp[A_10][0].ac() == A_4 && A_9 == bq)
		{
			a<fx> obj = bp[A_10];
			obj.b = A_6;
			bt = A_7;
			fx obj2 = obj[0];
			fl A_11 = this;
			obj2.q(ref A_0, ref A_1, A_2, ref A_11);
			obj2.q(A_8);
			_ = null;
			hb();
		}
		else
		{
			o(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9);
		}
	}

	public void g1()
	{
		this.m_df = 0;
		this.m_dp = 0;
		while (bp.Count > 0)
		{
			int index = checked(bp.Count - 1);
			a<fx> a10 = bp[index];
			if (a10.d)
			{
				this.m_dr[a10.e] = false;
			}
			bp.RemoveAt(index);
		}
		this.m_c6 = 0;
		aq();
		ap();
		this.m_d9 = null;
		ao();
		hb();
	}

	public void o(long A_0, bool A_1, global::r.d.a.b A_2)
	{
		int A_3 = default(int);
		if (o(A_0, ref A_3))
		{
			o(A_3, A_1, A_2);
		}
	}

	public void g2()
	{
		this.m_d9 = null;
		eh().Visible = false;
		hb();
	}

	public void p(double[] A_0, double[] A_1, int A_2, long A_3, long A_4, double A_5, string A_6, string A_7, bool A_8, bool A_9)
	{
		n n2 = new n();
		o a_ = new o(A_0, A_1, A_2, null, null, 0);
		n2.e(a_);
		p(n2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_8: true, A_9: false, default(Color));
	}

	public void o(double[] A_0, double[] A_1, int A_2, long A_3, long A_4, double A_5, string A_6, string A_7, bool A_8, bool A_9, ref double[] A_10, ref double[] A_11, int A_12)
	{
		n n2 = new n();
		o a_ = new o(A_0, A_1, A_2, A_10, A_11, A_12);
		n2.e(a_);
		p(n2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_8: true, A_9: false, default(Color));
	}

	public void p(double[] A_0, double[] A_1, int A_2, long A_3, long A_4, double A_5, string A_6, string A_7, bool A_8, bool A_9, bool A_10, Color A_11)
	{
		n n2 = new n();
		o a_ = new o(A_0, A_1, A_2, null, null, 0);
		n2.e(a_);
		p(n2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10, A_9: true, A_11);
	}

	public void o(double[] A_0, double[] A_1, int A_2, long A_3, long A_4, double A_5, string A_6, string A_7, bool A_8, bool A_9, bool A_10, Color A_11, ref double[] A_12, ref double[] A_13, int A_14)
	{
		n n2 = new n();
		o a_ = new o(A_0, A_1, A_2, A_12, A_13, A_14);
		n2.e(a_);
		p(n2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10, A_9: true, A_11);
	}

	public void p(n A_0, long A_1, long A_2, double A_3, string A_4, string A_5, bool A_6, bool A_7, bool A_8, bool A_9, Color A_10)
	{
		g1();
		o(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10);
	}

	public void g3()
	{
		foreach (a<fx> item in bp)
		{
			foreach (fx item2 in item)
			{
				item2.ag();
			}
		}
	}

	public void g4()
	{
		bm = false;
		this.m_f1 = false;
		this.m_f3 = false;
		@as();
	}

	public void g5()
	{
		bm = false;
		hb();
	}

	public void g6()
	{
		fu fu2 = this.m_em;
		if (!fu2.ao() && !fu2.ap() && !fu2.a2().ar() && !fu2.aq() && fu2.ar())
		{
			return;
		}
		if (bp.Count < 1)
		{
			if (this.m_d9 == null)
			{
				return;
			}
		}
		else if (bp[0].Count < 1 && this.m_d9 == null)
		{
			return;
		}
		fu2.a2().aq();
		fu2.a2().ap();
		double num = default(double);
		double num2 = default(double);
		double A_2;
		fu fu6;
		double A_;
		fu fu5;
		bool A_4;
		fu fu4;
		bool A_3;
		fu fu3;
		if (bu || da())
		{
			num = fu2.ay();
			num2 = fu2.az();
			if (bu)
			{
				A_ = (fu3 = fu2).au(false);
				A_2 = (fu4 = fu2).a1();
				A_3 = (fu5 = fu2).aq();
				A_4 = (fu6 = fu2).ar();
				o(ref A_, ref A_2, ref A_3, ref A_4, num2, num);
				fu6.ap(A_4);
				fu5.ao(A_3);
				fu4.an(A_2);
				fu3.an(A_0: false, A_);
			}
		}
		double num3 = fu2.aw();
		double num4 = fu2.ax();
		if (da())
		{
			if (num2 > num4)
			{
				num4 = num2;
			}
			if (num < num3)
			{
				num3 = num;
			}
		}
		A_2 = (fu6 = fu2).at(false);
		A_ = (fu5 = fu2).a0();
		A_4 = (fu4 = fu2).ao();
		A_3 = (fu3 = fu2).ap();
		o(ref A_2, ref A_, ref A_4, ref A_3, num4, num3);
		fu3.an(A_3);
		fu4.am(A_4);
		fu5.am(A_);
		fu6.am(A_0: false, A_2);
		fu2 = null;
	}

	private void o(ref double A_0, ref double A_1, ref bool A_2, ref bool A_3, double A_4, double A_5)
	{
		bool num = A_2;
		bool flag = A_3;
		double num2 = A_0;
		double num3 = A_1;
		if (A_4 > num2)
		{
			num2 = (1.0 + (double)Math.Sign(A_4) * 0.1) * A_4;
		}
		else if (num2 - num3 > 0.0 && A_4 < num2 * 0.9 && (A_4 - num3) / (num2 - num3) < 1.2)
		{
			num2 = (1.0 + (double)Math.Sign(A_4) * 0.1) * A_4;
		}
		else if (A_4 != 0.0)
		{
			num2 = A_4 * (1.0 + (double)Math.Sign(A_4) * 0.1);
		}
		if (num && !flag)
		{
			if (A_4 < 0.0)
			{
				num3 = A_5 * 1.1;
				num2 = ((!(A_4 > A_5)) ? 0.0 : (A_4 * 0.9));
			}
			else
			{
				num3 = ((!(A_5 < 0.0)) ? 0.0 : (A_5 * 1.1));
				if (num2 <= num3)
				{
					num2 = num3 + 1.0;
				}
			}
		}
		else if ((A_5 < num3) & flag)
		{
			num3 = A_5;
		}
		if (A_2)
		{
			if (num3 == num2)
			{
				num2++;
			}
			if (global::e.a().AutoPositionLegends)
			{
				A_0 = num2 * (double)dr();
			}
			else
			{
				A_0 = num2;
			}
			A_1 = num3;
		}
	}

	private bool o(g A_0)
	{
		switch (A_0)
		{
		case global::fl.g.a:
		case global::fl.g.b:
			return false;
		case global::fl.g.c:
		case global::fl.g.d:
			return true;
		default:
		{
			bool result = default(bool);
			return result;
		}
		}
	}

	private bool v(double A_0)
	{
		return A_0 > 0.0;
	}

	private bool u(double A_0)
	{
		return A_0 < 0.0;
	}

	private void o(double A_0, double A_1, double A_2, double A_3, double A_4, double A_5, double A_6, aa A_7, ref List<double> A_8, ref List<double> A_9, ref bool A_10)
	{
		A_9.Add(A_0);
		if (A_7(A_5))
		{
			double num = (A_0 - A_6) / A_5;
			if (num < A_2)
			{
				if (num > A_1 && num <= A_3)
				{
					A_8.Add(num);
				}
				else
				{
					A_9.RemoveAt(0);
				}
				return;
			}
			A_10 = false;
			if (A_3 > A_2)
			{
				A_8.Add(A_2);
			}
			else
			{
				A_8.Add(A_3);
			}
		}
		else
		{
			A_10 = false;
			if (A_3 > A_2)
			{
				A_8.Add(A_2);
			}
			else
			{
				A_8.Add(A_3);
			}
		}
	}

	private void o(double A_0, double A_1, double A_2, double A_3, double A_4, double A_5, double A_6, double A_7, double A_8, ref List<double> A_9, ref List<double> A_10, ref bool A_11)
	{
		double num = A_0 * A_7 + A_8;
		if (num < A_3)
		{
			A_10.Add(A_3);
			if (jf.e(A_0, A_1))
			{
				o(A_3, A_1, A_2, A_5, A_6, A_7, A_8, v, ref A_9, ref A_10, ref A_11);
			}
			else
			{
				o(A_3, A_1, A_2, A_5, A_6, A_7, A_8, u, ref A_9, ref A_10, ref A_11);
			}
		}
		else if (num > A_4)
		{
			A_10.Add(A_4);
			if (jf.e(A_0, A_1))
			{
				o(A_4, A_1, A_2, A_5, A_6, A_7, A_8, u, ref A_9, ref A_10, ref A_11);
			}
			else
			{
				o(A_4, A_1, A_2, A_5, A_6, A_7, A_8, v, ref A_9, ref A_10, ref A_11);
			}
		}
		else
		{
			A_10.Add(num);
		}
	}

	private void o(double A_0, double A_1, double A_2, double A_3, double A_4, double A_5, double A_6, double A_7, bool A_8, ref List<double> A_9, ref List<double> A_10, ref bool A_11)
	{
		A_11 = true;
		A_9 = new List<double>();
		A_10 = new List<double>();
		if (A_4 != A_6)
		{
			double num = (A_5 - A_7) / (A_4 - A_6);
			double num2 = (A_5 * A_6 - A_7 * A_4) / (A_6 - A_4);
			if (A_4 < A_0)
			{
				A_9.Add(A_0);
				if (A_5 < A_2 && A_7 < A_2)
				{
					A_10.Add(A_2);
				}
				else if (A_5 > A_3 && A_7 > A_3)
				{
					A_10.Add(A_3);
				}
				else
				{
					o(A_0, A_0, A_1, A_2, A_3, A_6, A_7, num, num2, ref A_9, ref A_10, ref A_11);
				}
			}
			else
			{
				A_9.Add(A_4);
				if (A_5 < A_2)
				{
					A_10.Add(A_2);
					o(A_2, A_0, A_1, A_6, A_7, num, num2, v, ref A_9, ref A_10, ref A_11);
				}
				else if (A_5 > A_3)
				{
					A_10.Add(A_3);
					o(A_3, A_0, A_1, A_6, A_7, num, num2, u, ref A_9, ref A_10, ref A_11);
				}
			}
		}
		else
		{
			A_9.Add(A_4);
			if (A_5 < A_2)
			{
				A_10.Add(A_2);
			}
			else if (A_5 > A_3)
			{
				A_10.Add(A_3);
			}
			else
			{
				A_10.Add(A_5);
			}
		}
		if (A_11 && !A_8)
		{
			o(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, ref A_9, ref A_10);
			A_11 = false;
		}
	}

	private void o(double A_0, double A_1, double A_2, double A_3, double A_4, double A_5, double A_6, double A_7, ref List<double> A_8, ref List<double> A_9)
	{
		checked
		{
			double item;
			double item2 = default(double);
			if (A_4 != A_6)
			{
				double num = (A_5 - A_7) / (A_4 - A_6);
				double num2 = (A_5 * A_6 - A_7 * A_4) / (A_6 - A_4);
				if (A_6 > A_1)
				{
					item = A_1;
					if (A_7 < A_2 && A_5 < A_2)
					{
						item2 = A_2;
					}
					else if (A_7 > A_3 && A_5 > A_3)
					{
						item2 = A_3;
					}
					else
					{
						int num3 = A_9.Count - 1;
						bool A_10 = false;
						o(A_1, A_0, A_1, A_2, A_3, A_6, A_7, num, num2, ref A_8, ref A_9, ref A_10);
						item2 = A_9[num3 + 1];
						A_9.RemoveAt(num3 + 1);
					}
				}
				else
				{
					bool A_11 = true;
					item = A_6;
					if (A_7 < A_2)
					{
						item2 = A_2;
						o(A_2, A_0, A_1, A_6, A_7, num, num2, u, ref A_8, ref A_9, ref A_11);
					}
					else if (A_7 > A_3)
					{
						item2 = A_3;
						o(A_3, A_0, A_1, A_6, A_7, num, num2, v, ref A_8, ref A_9, ref A_11);
					}
					if (!A_11)
					{
						A_8.RemoveAt(A_8.Count - 1);
						A_9.RemoveAt(A_9.Count - 1);
					}
				}
			}
			else
			{
				item = A_6;
				item2 = ((A_7 < A_2) ? A_2 : ((!(A_7 > A_3)) ? A_7 : A_3));
			}
			A_8.Add(item);
			A_9.Add(item2);
		}
	}

	private void o(List<double> A_0, List<double> A_1, double A_2, double A_3, double A_4, double A_5, ref List<float> A_6, ref List<float> A_7)
	{
		checked
		{
			if (A_2 > 0.0 && A_3 > 0.0)
			{
				float num = (float)(A_2 * (double)this.m_gq);
				float num2 = (float)(A_3 * (double)this.m_gq);
				int num3 = A_0.Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					A_6.Add((float)b3 + (float)(int)Math.Round((A_0[num4] - A_4) * (double)b6 / (double)num) * this.m_gq);
					A_7.Add((float)b5 + (float)(int)Math.Round((A_5 - A_1[num4]) * (double)b2 / (double)num2) * this.m_gq);
				}
			}
			else
			{
				A_6.Add(b3);
				A_7.Add(b5);
			}
		}
	}

	public void o(ref double[] A_0, ref double[] A_1, int A_2, int A_3, bool A_4, Color A_5, Graphics A_6, g A_7)
	{
		List<float> A_8 = new List<float>();
		List<float> A_9 = new List<float>();
		double num = this.m_em.a2().aq();
		double num2 = this.m_em.a2().ap();
		bool flag = o(A_7);
		bool flag2 = A_7 == global::fl.g.b || A_7 == global::fl.g.c;
		int num3 = 30;
		int num4 = 15;
		int num5 = 5;
		float num6 = this.m_em.au();
		Pen pen = new Pen(Color.Blue);
		SolidBrush solidBrush = new SolidBrush(Color.Blue);
		double num7;
		double num8;
		if (flag)
		{
			num7 = this.m_em.au(false);
			num8 = this.m_em.a1();
		}
		else
		{
			num7 = this.m_em.at(false);
			num8 = this.m_em.a0();
		}
		if (((A_2 > A_3) | (A_2 < 0)) || ((A_0[A_2] > num) | (A_0[A_3] < num2)) || (A_4 & (A_0[A_2] >= A_0[A_3]) & (this.m_em.a2().ar() | this.m_em.a2().@as())))
		{
			return;
		}
		pen.Color = A_5;
		solidBrush.Color = A_5;
		double num9 = 0.0;
		int num10 = ((A_7 != global::fl.g.b) ? num3 : num4);
		int num11 = num10;
		bool flag3 = true;
		checked
		{
			int num13 = default(int);
			if (A_0[A_2] < num2)
			{
				int num12 = A_2;
				bool flag4 = false;
				do
				{
					if (A_0[num12] >= num2)
					{
						flag4 = true;
						num13 = num12;
					}
					else
					{
						num12++;
					}
				}
				while (!flag4);
			}
			else
			{
				num13 = A_2;
			}
			if (A_4 & (num13 > 0) & (A_0[num13] != num2))
			{
				num13--;
			}
			int num14 = default(int);
			if (A_0[A_3] > num)
			{
				int num12 = A_3;
				bool flag4 = false;
				do
				{
					if (A_0[num12] <= num)
					{
						flag4 = true;
						num14 = num12;
					}
					else
					{
						num12--;
					}
				}
				while (!flag4);
			}
			else
			{
				num14 = A_3;
			}
			if (A_4 & (num14 < A_3) & (A_0[num14] != num))
			{
				num14++;
			}
			int num15 = num13;
			int num16 = num13 + 1;
			double num17 = (bi = num - num2);
			if (num17 <= 0.0)
			{
				num17 = 1.0;
			}
			double num18 = (bj = num7 - num8);
			if (num18 <= 0.0)
			{
				num18 = 1.0;
			}
			double num19 = default(double);
			double num20 = default(double);
			double num21 = default(double);
			double num22 = default(double);
			Rectangle rect = default(Rectangle);
			if (A_4)
			{
				num19 = (double)b6 / (num17 * (double)this.m_gq);
				num20 = (double)b2 / (num18 * (double)this.m_gq);
				if (o(A_0[num15], A_1[num15], flag))
				{
					A_8.Add((float)b3 + (float)(int)Math.Round((A_0[num15] - num2) * num19) * this.m_gq);
					A_9.Add((float)b5 + (float)(int)Math.Round((num7 - A_1[num15]) * num20) * this.m_gq);
				}
				else
				{
					List<double> A_10 = null;
					List<double> A_11 = null;
					bool A_12 = default(bool);
					o(num2, num, num8, num7, A_0[num15], A_1[num15], A_0[num16], A_1[num16], o(A_0[num16], A_1[num16], flag), ref A_10, ref A_11, ref A_12);
					if (!A_12)
					{
						num15 = num16++;
					}
					o(A_10, A_11, num17, num18, num2, num7, ref A_8, ref A_9);
				}
			}
			else
			{
				num21 = (double)b6 / num17;
				num22 = (double)b2 / num18;
				rect.Width = (int)Math.Round(num6);
				rect.Height = (int)Math.Round(num6);
				if (q(A_0[num15]))
				{
					if ((num17 > 0.0) & (num18 > 0.0))
					{
						double num23 = ((!flag) ? p(A_1[num15]) : o(A_1[num15]));
						A_8.Add((float)((double)b3 + (A_0[num15] - num2) * num21));
						A_9.Add((float)((double)b5 + (num7 - num23) * num22));
					}
					else
					{
						A_8.Add(b3);
						A_9.Add(b5);
					}
				}
			}
			if (num16 > num14 && (!A_4 || A_8.Count <= 1) && (A_4 || A_8.Count <= 0))
			{
				return;
			}
			float A_13 = A_8[0];
			float A_14 = A_9[0];
			double num24 = default(double);
			double num25 = default(double);
			float A_23 = default(float);
			float A_24 = default(float);
			do
			{
				if (!A_4)
				{
					if (num16 <= num14 && q(A_0[num16]))
					{
						A_8.Add((float)((double)b3 + (A_0[num16] - num2) * num21));
						double num23 = ((!flag) ? p(A_1[num16]) : o(A_1[num16]));
						A_9.Add((float)((double)b5 + (num7 - num23) * num22));
					}
					while (A_9.Count > 0)
					{
						rect.X = (int)Math.Round((double)A_8[0] - 0.5 * (double)num6);
						rect.Y = (int)Math.Round((double)A_9[0] - 0.5 * (double)num6);
						A_6.FillEllipse(solidBrush, rect);
						A_6.DrawEllipse(pen, rect);
						A_8.RemoveAt(0);
						A_9.RemoveAt(0);
					}
				}
				else
				{
					if (num16 <= num14)
					{
						bool flag5 = o(A_0[num15], A_1[num15], flag);
						bool flag6 = o(A_0[num16], A_1[num16], flag);
						if (num16 == num14 && !flag6)
						{
							List<double> A_15 = new List<double>();
							List<double> A_16 = new List<double>();
							if (flag5)
							{
								o(num2, num, num8, num7, A_0[num15], A_1[num15], A_0[num16], A_1[num16], ref A_15, ref A_16);
							}
							else
							{
								double a_ = num8;
								double a_2 = num7;
								double a_3 = A_0[num15];
								double a_4 = A_1[num15];
								double a_5 = A_0[num16];
								double a_6 = A_1[num16];
								bool A_17 = false;
								o(num2, num, a_, a_2, a_3, a_4, a_5, a_6, flag6, ref A_15, ref A_16, ref A_17);
							}
							o(A_15, A_16, num17, num18, num2, num7, ref A_8, ref A_9);
						}
						else if (flag5 && flag6)
						{
							A_8.Add((float)b3 + (float)(int)Math.Round((A_0[num16] - num2) * num19) * this.m_gq);
							A_9.Add((float)b5 + (float)(int)Math.Round((num7 - A_1[num16]) * num20) * this.m_gq);
						}
						else if (!flag5 && !flag6)
						{
							List<double> A_18 = new List<double>();
							List<double> A_19 = new List<double>();
							if ((A_1[num15] < num8 && A_1[num16] > num7) || (A_1[num15] > num7 && A_1[num16] < num8))
							{
								double a_7 = num8;
								double a_8 = num7;
								double a_9 = A_0[num15];
								double a_10 = A_1[num15];
								double a_11 = A_0[num16];
								double a_12 = A_1[num16];
								bool A_17 = false;
								o(num2, num, a_7, a_8, a_9, a_10, a_11, a_12, flag6, ref A_18, ref A_19, ref A_17);
							}
							else
							{
								A_18.Add(A_0[num16]);
								if (A_1[num15] < num8)
								{
									A_19.Add(num8);
								}
								else
								{
									A_19.Add(num7);
								}
							}
							o(A_18, A_19, num17, num18, num2, num7, ref A_8, ref A_9);
						}
						else
						{
							List<double> A_20 = new List<double>();
							List<double> A_21 = new List<double>();
							if (A_0[num15] != A_0[num16])
							{
								num24 = (A_1[num15] - A_1[num16]) / (A_0[num15] - A_0[num16]);
								num25 = (A_1[num15] * A_0[num16] - A_1[num16] * A_0[num15]) / (A_0[num16] - A_0[num15]);
							}
							if (!flag5)
							{
								if (num15 > num13)
								{
									if (A_0[num15] != A_0[num16])
									{
										bool A_22 = true;
										if (A_1[num15] < num8)
										{
											o(num8, num2, num, A_0[num16], A_1[num16], num24, num25, v, ref A_20, ref A_21, ref A_22);
											if (A_22)
											{
												A_20.Add(A_0[num16]);
												A_21.Add(A_1[num16]);
											}
										}
										else if (A_1[num15] > num7)
										{
											o(num7, num2, num, A_0[num16], A_1[num16], num24, num25, u, ref A_20, ref A_21, ref A_22);
											if (A_22)
											{
												A_20.Add(A_0[num16]);
												A_21.Add(A_1[num16]);
											}
										}
									}
									else
									{
										A_20.Add(A_0[num15]);
										if (A_1[num15] < num8)
										{
											A_21.Add(num8);
										}
										else if (A_1[num15] > num7)
										{
											A_21.Add(num7);
										}
									}
								}
								else
								{
									A_20.Add(A_0[num16]);
									A_21.Add(A_1[num16]);
								}
							}
							else if (A_0[num15] != A_0[num16])
							{
								if (A_1[num16] < num8)
								{
									double a_13 = num8;
									double a_14 = A_0[num16];
									double a_15 = A_1[num16];
									double a_16 = num24;
									double a_17 = num25;
									aa a_18 = u;
									bool A_17 = false;
									o(a_13, num2, num, a_14, a_15, a_16, a_17, a_18, ref A_20, ref A_21, ref A_17);
								}
								else if (A_1[num16] > num7)
								{
									double a_19 = num7;
									double a_20 = A_0[num16];
									double a_21 = A_1[num16];
									double a_22 = num24;
									double a_23 = num25;
									aa a_24 = v;
									bool A_17 = false;
									o(a_19, num2, num, a_20, a_21, a_22, a_23, a_24, ref A_20, ref A_21, ref A_17);
								}
							}
							else
							{
								A_20.Add(A_0[num15]);
								if (A_1[num16] < num8)
								{
									A_21.Add(num8);
								}
								else if (A_1[num16] > num7)
								{
									A_21.Add(num7);
								}
							}
							o(A_20, A_21, num17, num18, num2, num7, ref A_8, ref A_9);
						}
					}
					bool flag7 = false;
					float num26 = A_8[0];
					float num27 = A_9[0];
					while (A_8.Count > 1)
					{
						float num28 = A_8[1];
						float num29 = A_9[1];
						flag7 = false;
						if (flag2)
						{
							if (num9 > 0.0)
							{
								double num30 = o(num26, num27, num28, num29);
								if (num30 + num9 < (double)num11)
								{
									if (flag3)
									{
										A_6.DrawLine(pen, num26, num27, num28, num29);
									}
									num9 += num30;
									flag7 = true;
								}
								else
								{
									o(num26, num27, num28, num29, ref A_13, ref A_14, (double)num11 - num9, num30);
									if (flag3)
									{
										A_6.DrawLine(pen, num26, num27, A_13, A_14);
									}
									num9 = 0.0;
									if (flag3)
									{
										pen.Color = Color.White;
										flag3 = false;
									}
									else
									{
										pen.Color = A_5;
										flag3 = true;
									}
								}
							}
							if (num9 == 0.0)
							{
								double num30 = o(A_13, A_14, num28, num29);
								num11 = ((!flag3) ? num5 : num10);
								if (num30 < (double)num11)
								{
									if (flag3)
									{
										A_6.DrawLine(pen, A_13, A_14, num28, num29);
									}
									num9 = num30;
									flag7 = true;
								}
								else
								{
									float num31 = A_13;
									float num32 = A_14;
									double num33 = num11;
									double num34;
									do
									{
										o(num31, num32, num28, num29, ref A_23, ref A_24, num33, num30);
										if (flag3)
										{
											A_6.DrawLine(pen, A_13, A_14, A_23, A_24);
										}
										A_13 = A_23;
										A_14 = A_24;
										if (flag3)
										{
											pen.Color = Color.White;
											flag3 = false;
											num11 = num5;
										}
										else
										{
											pen.Color = A_5;
											flag3 = true;
											num11 = num10;
										}
										num34 = num30 - num33;
										if (num34 > (double)num11)
										{
											num33 += (double)num11;
										}
									}
									while (num34 > (double)num11);
									if (flag3)
									{
										A_6.DrawLine(pen, A_13, A_14, num28, num29);
									}
									num9 = num34;
									flag7 = true;
								}
							}
						}
						else
						{
							flag7 = true;
							A_6.DrawLine(pen, num26, num27, num28, num29);
						}
						if (flag7)
						{
							A_8.RemoveAt(0);
							A_9.RemoveAt(0);
							num26 = num28;
							num27 = num29;
						}
					}
				}
				num15++;
				num16 = num15 + 1;
			}
			while (num16 <= num14);
		}
	}

	private void o(Color A_0, Graphics A_1, PointF A_2, bool A_3, bool A_4)
	{
		Point point = PointToClient(Cursor.Position);
		checked
		{
			if (A_2.X > 0f && A_2.Y > 0f && p((float)point.X, (float)point.Y) && this.m_eq && !bd)
			{
				int num = 5;
				SolidBrush solidBrush = new SolidBrush(A_0);
				Pen pen = new Pen(A_0, 1f);
				if (this.m_em.a2().at())
				{
					A_1.FillEllipse(solidBrush, A_2.X - 3f, A_2.Y - 3f, num * 2 - 4, num * 2 - 4);
					A_1.DrawEllipse(pen, A_2.X - 3f, A_2.Y - 3f, num * 2 - 4, num * 2 - 4);
				}
				float a_ = ((!A_3) ? ((float)p(A_2.Y)) : ((float)o(A_2.Y)));
				if (A_4)
				{
					A_1.DrawLine(pen, A_2.X, b1, A_2.X, b5);
				}
				if (this.m_em.a2().au() || this.m_em.a2().at())
				{
					o(A_2, A_1, a_, A_0);
				}
				pen.Dispose();
				solidBrush.Dispose();
			}
		}
	}

	private void o(Graphics A_0, Color A_1, fx A_2, bool A_3, bool A_4, List<string> A_5)
	{
		SolidBrush solidBrush = new SolidBrush(A_1);
		Pen pen = new Pen(A_1, 2f);
		int num = 5;
		if (!this.m_fn)
		{
			return;
		}
		List<string> list = ((!A_4) ? A_2.ad() : A_5);
		checked
		{
			foreach (string item in list)
			{
				double a_ = iz.e(item);
				A_2.u(a_);
				double num2 = A_2.ak();
				float num3 = ((!A_3) ? s(num2) : r(num2));
				float num4 = t(a_);
				A_0.FillEllipse(solidBrush, num4 - 3f, num3 - 3f, num * 2 - 4, num * 2 - 4);
				A_0.DrawEllipse(pen, num4 - 3f, num3 - 3f, num * 2 - 4, num * 2 - 4);
				o(new PointF(num4, num3), A_0, (float)num2, A_1);
			}
			solidBrush.Dispose();
			pen.Dispose();
		}
	}

	private void o(PointF A_0, Graphics A_1, float A_2, Color A_3)
	{
		string text = q(A_0.X).ToString("####.00") + " " + dt();
		Font font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point);
		checked
		{
			int num = (int)Math.Round(A_0.Y);
			int num2 = (int)Math.Round(A_0.X);
			SizeF sizeF = A_1.MeasureString(text, font);
			if (A_3 != Color.Red)
			{
				num2 = ((!((float)num2 + sizeF.Width + 20f > (float)b4)) ? ((int)Math.Round(A_0.X + 10f)) : ((int)Math.Round(A_0.X - sizeF.Width - 10f)));
				num = (this.m_em.a2().av() ? ((!((float)num + sizeF.Height * 2f > (float)b1)) ? ((int)Math.Round(A_0.Y - 20f)) : ((int)Math.Round(A_0.Y - sizeF.Height * 2f - 4f))) : ((!((float)num + sizeF.Height > (float)b1)) ? ((int)Math.Round(A_0.Y - 20f)) : ((int)Math.Round(A_0.Y - sizeF.Height - 4f))));
			}
			else if (!((float)num2 - sizeF.Width - 10f < (float)b3))
			{
				if ((float)num2 + sizeF.Width + 20f > (float)b4)
				{
					num2 = (int)Math.Round(A_0.X - sizeF.Width - 10f);
				}
				else
				{
					num2 = (int)Math.Round(A_0.X - sizeF.Width - 10f);
					num = (this.m_em.a2().av() ? ((!((float)num + sizeF.Height * 2f > (float)b1)) ? ((int)Math.Round(A_0.Y - 20f)) : ((int)Math.Round(A_0.Y - sizeF.Height * 2f - 4f))) : ((!((float)num + sizeF.Height > (float)b1)) ? ((int)Math.Round(A_0.Y - 20f)) : ((int)Math.Round(A_0.Y - sizeF.Height - 4f))));
				}
			}
			Rectangle rectangle = ((!this.m_em.a2().av()) ? new Rectangle(num2, num + 10, (int)Math.Round(sizeF.Width + 4f), (int)Math.Round(sizeF.Height + 4f)) : new Rectangle(num2, num, (int)Math.Round(sizeF.Width + 4f), (int)Math.Round(sizeF.Height * 2f + 4f)));
			if (A_3 != Color.Red)
			{
				this.m_fp = rectangle;
			}
			else if (o(rectangle, this.m_fp))
			{
				rectangle.Y = this.m_fp.Top + this.m_fp.Height + 10;
				if (rectangle.Y + this.m_fp.Height > b1)
				{
					rectangle.Y = this.m_fp.Top - this.m_fp.Height - 10;
				}
			}
			SolidBrush solidBrush = ((global::e.a().GraphBackColor != 0) ? new SolidBrush(Color.FromArgb(127, 0, 0, 0)) : new SolidBrush(Color.FromArgb(192, 255, 255, 255)));
			A_1.FillRectangle(solidBrush, rectangle);
			bool flag = (A_3.R > 200 && A_3.B > 200 && A_3.B > 200 && global::e.a().GraphBackColor == 0) || A_3.R < 120 || A_3.B < 120 || (A_3.B < 120 && global::e.a().GraphBackColor == 1);
			if (global::e.a().GraphBackColor == 0)
			{
				if (flag)
				{
					solidBrush.Color = A_3;
				}
				else
				{
					solidBrush.Color = Color.Black;
				}
			}
			else if (flag)
			{
				solidBrush.Color = A_3;
			}
			else
			{
				solidBrush.Color = Color.White;
			}
			string text2 = ((!gi().at() || !fm()) ? "0.0000" : "###.00%");
			if (this.m_em.a2().av())
			{
				A_1.DrawString(text, font, solidBrush, rectangle.Left + 2, (float)rectangle.Top + sizeF.Height + 2f);
				A_1.DrawString(A_2.ToString(text2), font, solidBrush, rectangle.Left + 2, rectangle.Top + 2);
			}
			else
			{
				A_1.DrawString(A_2.ToString(text2), font, solidBrush, rectangle.Left + 2, num + 12);
			}
			solidBrush.Dispose();
		}
	}

	private bool o(RectangleF A_0, RectangleF A_1)
	{
		float num = A_0.Left + A_0.Width;
		float num2 = A_0.Top + A_0.Height;
		float num3 = A_1.Left + A_1.Width;
		float num4 = A_1.Top + A_1.Height;
		if ((A_0.Left <= A_1.Left && A_1.Left <= num) || (A_0.Left <= num3 && num3 <= num))
		{
			if (!(A_0.Top <= A_1.Top) || !(A_1.Top <= num2))
			{
				if (A_0.Top <= num4)
				{
					return num4 <= num2;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	private void o(float A_0, float A_1, ref int A_2, ref bool A_3, ref int A_4, ref int A_5, ref string A_6)
	{
		double num = 1000.0;
		checked
		{
			int num2 = bp.Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				a<fx> a10 = bp[num3];
				for (int num4 = a10.Count - 1; num4 >= 0; num4 += -1)
				{
					fx fx2 = a10[num4];
					int num5 = fx2.ad().Count - 1;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						double a_ = Conversions.ToDouble(fx2.ad()[num6]);
						fx2.u(a_);
						double num7 = o(A_0, A_1, t(a_), (!da() && a10.s()) ? r(fx2.ak()) : s(fx2.ak()));
						if (num > num7)
						{
							num = num7;
							A_2 = num3;
							A_4 = num6;
							A_3 = false;
							A_5 = -1;
							A_6 = fx2.ad()[num6];
						}
					}
					if (fx2.ah() != null)
					{
						int num8 = fx2.ah().ad().Count - 1;
						for (int num9 = 0; num9 <= num8; num9++)
						{
							double a_2 = Conversions.ToDouble(fx2.ah().ad()[num9]);
							fx2.u(a_2);
							double num7 = o(A_0, A_1, t(a_2), r(fx2.ah().ak()));
							if (num > num7)
							{
								num = num7;
								A_2 = num3;
								A_4 = num9;
								A_3 = true;
								A_5 = -1;
								A_6 = fx2.ah().ad()[num9];
							}
						}
					}
					if (fx2.ai() == null || fx2.ai().Count <= 0)
					{
						continue;
					}
					int num10 = fx2.ai().Count - 1;
					for (int num11 = 0; num11 <= num10; num11++)
					{
						int num12 = fx2.ai()[num11].ad().Count - 1;
						for (int num13 = 0; num13 <= num12; num13++)
						{
							double a_3 = Conversions.ToDouble(fx2.ai()[num11].ad()[num13]);
							fx2.u(a_3);
							double num7 = o(A_0, A_1, t(a_3), s(fx2.ai()[num11].ak()));
							if (num > num7)
							{
								num = num7;
								A_2 = num3;
								A_4 = num13;
								A_3 = false;
								A_5 = num11;
								A_6 = fx2.ai()[num11].ad()[num13];
							}
						}
						_ = null;
					}
				}
			}
			if (this.m_d9 == null)
			{
				return;
			}
			int num14 = this.m_fe.Count - 1;
			for (int num15 = 0; num15 <= num14; num15++)
			{
				double a_4 = Conversions.ToDouble(this.m_fe[num15]);
				this.m_d9.u(a_4);
				double num7 = o(A_0, A_1, t(a_4), s(this.m_d9.ak()));
				if (num > num7)
				{
					num = num7;
					A_2 = -1;
					A_4 = num15;
					A_3 = false;
					A_5 = -1;
					A_6 = this.m_fe[num15];
				}
			}
			if (this.m_d9.ah() != null && this.m_ff.Count > 0)
			{
				int num16 = this.m_fg.Count - 1;
				for (int num17 = 0; num17 <= num16; num17++)
				{
					double a_5 = Conversions.ToDouble(this.m_ff[num17]);
					this.m_d9.u(a_5);
					double num7 = o(A_0, A_1, t(a_5), r(this.m_d9.ah().ak()));
					if (num > num7)
					{
						num = num7;
						A_2 = -1;
						A_4 = num17;
						A_3 = true;
						A_5 = -1;
						A_6 = this.m_ff[num17];
					}
				}
			}
			if (this.m_d9.ai() == null || this.m_d9.ai().Count <= 0 || this.m_fg.Count <= 0)
			{
				return;
			}
			int num18 = this.m_fg.Count - 1;
			for (int num19 = 0; num19 <= num18; num19++)
			{
				int num20 = this.m_fg[num19].Count - 1;
				for (int num21 = 0; num21 <= num20; num21++)
				{
					double a_6 = Conversions.ToDouble(this.m_fg[num19][num21]);
					this.m_d9.u(a_6);
					double num7 = o(A_0, A_1, t(a_6), s(this.m_d9.ai()[num19].ak()));
					if (num > num7)
					{
						num = num7;
						A_2 = -1;
						A_4 = num21;
						A_3 = false;
						A_5 = num19;
						A_6 = this.m_fg[num19][num21];
					}
				}
			}
		}
	}

	private void o(float A_0, float A_1, int A_2, bool A_3, bool A_4, bool A_5, bool A_6, int A_7)
	{
		double num = 1000.0;
		checked
		{
			int index = default(int);
			if (!A_6)
			{
				a<fx> a10 = bp[A_2];
				for (int num2 = a10.Count - 1; num2 >= 0; num2 += -1)
				{
					fx fx2 = a10[num2];
					if (A_3)
					{
						int num3 = fx2.ad().Count - 1;
						for (int num4 = 0; num4 <= num3; num4++)
						{
							double a_ = Conversions.ToDouble(fx2.ad()[num4]);
							fx2.u(a_);
							double num5 = o(A_0, A_1, t(a_), (!da() && a10.s()) ? r(fx2.ak()) : s(fx2.ak()));
							if (num > num5)
							{
								num = num5;
								index = num4;
							}
						}
						fx2.ad().RemoveAt(index);
					}
					else if (A_4 && fx2.ah() != null)
					{
						int num6 = fx2.ah().ad().Count - 1;
						for (int num7 = 0; num7 <= num6; num7++)
						{
							double a_2 = Conversions.ToDouble(fx2.ah().ad()[num7]);
							fx2.u(a_2);
							double num5 = o(A_0, A_1, t(a_2), r(fx2.ah().ak()));
							if (num > num5)
							{
								num = num5;
								index = num7;
							}
						}
						fx2.ah().ad().RemoveAt(index);
					}
					else
					{
						if (!A_5 || fx2.ai() == null || fx2.ai().Count <= 0)
						{
							continue;
						}
						int num8 = fx2.ai()[A_7].ad().Count - 1;
						for (int num9 = 0; num9 <= num8; num9++)
						{
							double a_3 = Conversions.ToDouble(fx2.ai()[A_7].ad()[num9]);
							fx2.u(a_3);
							double num5 = o(A_0, A_1, t(a_3), s(fx2.ai()[A_7].ak()));
							if (num > num5)
							{
								num = num5;
								index = num9;
							}
						}
						fx2.ai()[A_7].ad().RemoveAt(index);
						_ = null;
					}
				}
				return;
			}
			if (A_3)
			{
				int num10 = this.m_fe.Count - 1;
				for (int num11 = 0; num11 <= num10; num11++)
				{
					double a_4 = Conversions.ToDouble(this.m_fe[num11]);
					this.m_d9.u(a_4);
					double num5 = o(A_0, A_1, t(a_4), s(this.m_d9.ak()));
					if (num > num5)
					{
						num = num5;
						index = num11;
					}
				}
				this.m_fe.RemoveAt(index);
			}
			if (A_4 && this.m_d9.ah() != null && this.m_ff.Count > 0)
			{
				int num12 = this.m_fg.Count - 1;
				for (int num13 = 0; num13 <= num12; num13++)
				{
					double a_5 = Conversions.ToDouble(this.m_ff[num13]);
					this.m_d9.u(a_5);
					double num5 = o(A_0, A_1, t(a_5), r(this.m_d9.ah().ak()));
					if (num > num5)
					{
						num = num5;
						index = num13;
					}
				}
				this.m_ff.RemoveAt(index);
			}
			if (!A_5 || this.m_d9.ai() == null || this.m_d9.ai().Count <= 0 || this.m_fg.Count <= 0)
			{
				return;
			}
			int num14 = this.m_fg[A_7].Count - 1;
			for (int num15 = 0; num15 <= num14; num15++)
			{
				double a_6 = Conversions.ToDouble(this.m_fg[A_7][num15]);
				this.m_d9.u(a_6);
				double num5 = o(A_0, A_1, t(a_6), s(this.m_d9.ai()[A_7].ak()));
				if (num > num5)
				{
					num = num5;
					index = num15;
				}
			}
			this.m_fg[A_7].RemoveAt(index);
		}
	}

	private double o(double A_0, double A_1, double A_2, double A_3)
	{
		return Math.Sqrt((A_2 - A_0) * (A_2 - A_0) + (A_3 - A_1) * (A_3 - A_1));
	}

	private void o(double A_0, double A_1, double A_2, double A_3, ref float A_4, ref float A_5, double A_6, double A_7)
	{
		A_4 = (float)(A_6 / A_7 * (A_2 - A_0) + A_0);
		A_5 = (float)(A_6 / A_7 * (A_3 - A_1) + A_1);
	}

	public bool p(float A_0, float A_1)
	{
		if ((A_0 >= (float)b3) & (A_0 <= (float)b4) & (A_1 <= (float)b1) & (A_1 >= (float)b5))
		{
			return true;
		}
		return false;
	}

	public void g7()
	{
		if (this.m_em.a2().ar() && gm > this.m_em.a2().ap())
		{
			this.m_em.a2().an(gm);
		}
	}

	public void g8()
	{
		if (this.m_gr != (global::e.a().GraphBackColor == 0))
		{
			hb();
		}
	}

	public void u(Graphics A_0, bool A_1 = false)
	{
		if (ad())
		{
			return;
		}
		this.m_gr = global::e.a().GraphBackColor == 0;
		if (this.m_el == null || this.m_el.Width != base.ClientSize.Width || this.m_el.Height != base.ClientSize.Height)
		{
			if (base.ClientSize.Width == 0 || base.ClientSize.Height == 0)
			{
				return;
			}
			this.m_el = new Bitmap(base.ClientSize.Width, base.ClientSize.Height);
		}
		Graphics graphics = null;
		graphics = ((!A_1) ? Graphics.FromImage(this.m_el) : A_0);
		bool flag = global::e.a().GraphBackColor == 0;
		Color a_ = ((!flag) ? Color.Black : Color.White);
		if ((int)this.m_ez != global::e.a().GraphBackColor)
		{
			@as();
			this.m_ez = (fh.a)global::e.a().GraphBackColor;
		}
		if (!A_1)
		{
			p(graphics);
		}
		q(graphics, A_1);
		p(graphics, A_1);
		checked
		{
			if (bp != null)
			{
				if (!cq)
				{
					int num = bp.Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						if (num2 == this.m_c6)
						{
							continue;
						}
						a<fx> a10 = bp[num2];
						for (int num3 = a10.Count - 1; num3 >= 0; num3 += -1)
						{
							fx fx2 = a10[num3];
							Color a_2 = o(fx2.q(), a_, q(flag));
							g g10 = ((a10.s() && !da()) ? global::fl.g.c : ((a10.t() && !dm()) ? global::fl.g.b : global::fl.g.a));
							if (a10.u())
							{
								if (hc())
								{
									fx2.q(graphics, a_2, g10);
									o(graphics, a_2, fx2, A_3: false, A_4: false, null);
								}
								else
								{
									fx2.q(graphics, g10);
									o(graphics, fx2.q(), fx2, A_3: false, A_4: false, null);
								}
							}
							if ((bu || da()) && fx2.ah() != null)
							{
								bool a_3 = !da();
								fx fx3 = fx2.ah();
								fx3.ag();
								if (hc())
								{
									fx3.q(graphics, a_2);
									o(graphics, a_2, fx2.ah(), a_3, A_4: false, null);
								}
								else
								{
									fx3.q(graphics);
									o(graphics, fx2.q(), fx2.ah(), a_3, A_4: false, null);
								}
								fx3 = null;
							}
							if (fx2.ai() == null || fx2.ai().Count <= 0)
							{
								continue;
							}
							int num4 = fx2.ai().Count - 1;
							for (int num5 = 0; num5 <= num4; num5++)
							{
								if (a10.r(num5))
								{
									fx fx4 = fx2.ai()[num5];
									fx4.ag();
									if (hc())
									{
										fx4.q(graphics, a_2);
										o(graphics, a_2, fx2.ai()[num5], A_3: false, A_4: false, null);
									}
									else
									{
										fx4.q(graphics);
										o(graphics, fx2.ai()[num5].q(), fx2.ai()[num5], A_3: false, A_4: false, null);
									}
									if (bu && fx4.ah() != null)
									{
										fx4.ah().ag();
										fx4.ah().q(graphics);
									}
									fx4 = null;
								}
							}
						}
					}
				}
				if (this.m_c6 >= 0 && this.m_c6 < bp.Count)
				{
					a<fx> a10 = bp[this.m_c6];
					Color a_4 = o(a10.c, a_, q(flag));
					for (int num3 = a10.Count - 1; num3 >= 0; num3 += -1)
					{
						fx fx2 = a10[num3];
						fx2.ag();
						g g11;
						bool flag2;
						if (a10.s() && !da())
						{
							g11 = global::fl.g.c;
							flag2 = dp();
						}
						else if (a10.t() && !dm())
						{
							g11 = global::fl.g.b;
							flag2 = @do();
						}
						else
						{
							g11 = global::fl.g.a;
							flag2 = dq();
						}
						if (a10.u())
						{
							if (hc() && !flag2)
							{
								fx2.q(graphics, a_4, g11);
								o(graphics, a_4, fx2, A_3: false, A_4: false, null);
							}
							else
							{
								fx2.q(graphics, g11);
								o(graphics, fx2.q(), fx2, A_3: false, A_4: false, null);
							}
						}
						if (a10.v() && (bu || da()) && fx2.ah() != null)
						{
							bool a_5 = !da();
							fx fx5 = fx2.ah();
							fx5.ag();
							if (hc() && !dp())
							{
								fx5.q(graphics, a_4);
								o(graphics, a_4, fx2.ah(), a_5, A_4: false, null);
							}
							else
							{
								fx5.q(graphics);
								o(graphics, fx5.q(), fx2.ah(), a_5, A_4: false, null);
							}
							fx5 = null;
						}
						if (fx2.ai() == null || fx2.ai().Count <= 0)
						{
							continue;
						}
						int num6 = fx2.ai().Count - 1;
						for (int num7 = 0; num7 <= num6; num7++)
						{
							if (a10.r(num7))
							{
								fx fx6 = fx2.ai()[num7];
								fx6.ag();
								if (hc() && !@do())
								{
									fx6.q(graphics, a_4);
									o(graphics, a_4, fx2.ai()[num7], A_3: false, A_4: false, null);
								}
								else
								{
									fx6.q(graphics);
									o(graphics, fx6.q(), fx2.ai()[num7], A_3: false, A_4: false, null);
								}
								if (bu && fx6.ah() != null)
								{
									fx6.ah().ag();
									fx6.ah().q(graphics);
								}
								fx6 = null;
							}
						}
					}
				}
			}
			if (this.m_es)
			{
				if (!this.m_fy.c || this.m_fy.l().Width <= 1)
				{
					this.m_fy.m((int)Math.Round(t(this.m_fy.e.a)));
					if (this.m_fy.n() < b3)
					{
						this.m_fy.m(b3);
					}
					this.m_fy.n((int)Math.Round(t(this.m_fy.e.b)) + 1);
					if (this.m_fy.o() > b4)
					{
						this.m_fy.n(b4);
					}
					if (this.m_fy.l().Width == 0)
					{
						if (this.m_fy.o() == b4)
						{
							b b10;
							(b10 = this.m_fy).m(b10.n() - 1);
						}
						else
						{
							b b10;
							(b10 = this.m_fy).n(b10.o() + 1);
						}
					}
				}
				if (this.m_fy.c && this.m_fy.l().Width > 1)
				{
					o(this.m_fy.b, graphics);
				}
				else if (this.m_fy.d)
				{
					o(this.m_fy.b, graphics);
				}
				o(graphics);
			}
			if (this.m_d9 != null)
			{
				this.m_d9.ag();
				Color color = o(this.m_d9.q(), a_, q(flag));
				float A_2 = default(float);
				float A_3 = default(float);
				bool A_4 = default(bool);
				if (this.m_eg && this.m_c6 >= 0 && this.m_c6 < bp.Count)
				{
					if (bp.Count - dj() - dh() > 0)
					{
						if (this.m_ee == global::fl.h.a && dk() > 0)
						{
							this.m_d9.ag();
							o(this.m_d9, A_1: false, this.m_fq, ref A_2, ref A_3, ref A_4);
							bool flag3 = A_4 && (global::e.a().AutoTrackCalcCurve || this.m_fh) && p(A_2, A_3);
							if (hc() && !dq())
							{
								this.m_d9.q(graphics, color, global::fl.g.a);
								o(graphics, color, this.m_d9, A_3: false, A_4: true, this.m_fe);
								if (flag3)
								{
									o(color, graphics, new PointF(A_2, A_3), A_3: false, this.m_em.a2().au() && !this.m_d9.af() && !this.m_d9.ae());
								}
							}
							else
							{
								this.m_d9.q(graphics, global::fl.g.a);
								o(graphics, this.m_d9.q(), this.m_d9, A_3: false, A_4: true, this.m_fe);
								if (flag3)
								{
									o(this.m_d9.q(), graphics, new PointF(A_2, A_3), A_3: false, this.m_em.a2().au() && !this.m_d9.af() && !this.m_d9.ae());
								}
							}
						}
						if ((this.m_ee == global::fl.h.b || this.m_d9.ah() != null) && di() > 0)
						{
							fx fx7 = ((this.m_ee != global::fl.h.b) ? this.m_d9.ah() : this.m_d9);
							g g12;
							bool flag4;
							if (da())
							{
								g12 = global::fl.g.a;
								flag4 = false;
							}
							else
							{
								g12 = global::fl.g.c;
								flag4 = true;
							}
							fx7.ag();
							o(fx7, flag4, this.m_fq, ref A_2, ref A_3, ref A_4);
							bool flag3 = A_4 && (global::e.a().AutoTrackCalcCurve || this.m_fi) && p(A_2, A_3);
							if (hc() && !dp())
							{
								fx7.q(graphics, color, g12);
								o(graphics, color, fx7, flag4, A_4: true, this.m_fe);
								if (flag3)
								{
									o(color, graphics, new PointF(A_2, A_3), flag4, this.m_em.a2().au() && !fx7.af() && !fx7.ae());
								}
							}
							else
							{
								fx7.q(graphics, g12);
								o(graphics, this.m_d9.q(), fx7, flag4, A_4: true, this.m_fe);
								if (flag3)
								{
									o(this.m_d9.q(), graphics, new PointF(A_2, A_3), flag4, this.m_em.a2().au() && !fx7.af() && !fx7.ae());
								}
							}
						}
						if ((this.m_ee == global::fl.h.c || this.m_d9.ai() != null) && df() > 0)
						{
							fx fx8 = ((this.m_ee != global::fl.h.c) ? this.m_d9.ai()[0] : this.m_d9);
							g g13 = ((dk() > 0) ? global::fl.g.b : global::fl.g.a);
							fx8.ag();
							o(fx8, A_1: false, this.m_fq, ref A_2, ref A_3, ref A_4);
							bool flag3 = A_4 && (global::e.a().AutoTrackCalcCurve || this.m_fj[0]) && p(A_2, A_3);
							if (hc() && !@do())
							{
								fx8.q(graphics, color, g13);
								o(graphics, color, fx8, A_3: false, A_4: true, this.m_fe);
								if (flag3)
								{
									o(color, graphics, new PointF(A_2, A_3), A_3: false, this.m_em.a2().au() && !fx8.af() && !fx8.ae());
								}
							}
							else
							{
								fx8.q(graphics, g13);
								o(graphics, this.m_d9.q(), fx8, A_3: false, A_4: true, this.m_fe);
								if (flag3)
								{
									o(this.m_d9.q(), graphics, new PointF(A_2, A_3), A_3: false, this.m_em.a2().au() && !fx8.af() && !fx8.ae());
								}
							}
						}
					}
					if (dg() > 0)
					{
						if ((this.m_ee == global::fl.h.c || this.m_d9.ai() != null) && df() > 0)
						{
							g g14 = ((di() > 0) ? global::fl.g.b : global::fl.g.a);
							fx fx9 = ((this.m_ee != global::fl.h.c) ? this.m_d9.ai()[0] : this.m_d9);
							fx9.ag();
							o(fx9, A_1: false, this.m_fq, ref A_2, ref A_3, ref A_4);
							bool flag3 = A_4 && (global::e.a().AutoTrackCalcCurve || this.m_fj[0]) && p(A_2, A_3);
							if (hc() && !@do())
							{
								fx9.q(graphics, color, g14);
								o(graphics, color, fx9, A_3: false, A_4: true, this.m_fe);
								if (flag3)
								{
									o(color, graphics, new PointF(A_2, A_3), A_3: false, this.m_em.a2().au() && !fx9.af() && !fx9.ae());
								}
							}
							else
							{
								fx9.q(graphics, g14);
								o(graphics, this.m_d9.q(), fx9, A_3: false, A_4: true, this.m_fe);
								if (flag3)
								{
									o(this.m_d9.q(), graphics, new PointF(A_2, A_3), A_3: false, this.m_em.a2().au() && !fx9.af() && !fx9.ae());
								}
							}
						}
						if ((this.m_ee == global::fl.h.b || this.m_d9.ah() != null) && di() > 0)
						{
							fx fx10 = ((this.m_ee != global::fl.h.b) ? this.m_d9.ah() : this.m_d9);
							g g15;
							bool a_6;
							if (da())
							{
								g15 = global::fl.g.a;
								a_6 = false;
							}
							else
							{
								g15 = global::fl.g.c;
								a_6 = true;
							}
							fx10.ag();
							o(fx10, A_1: true, this.m_fq, ref A_2, ref A_3, ref A_4);
							bool flag3 = A_4 && (global::e.a().AutoTrackCalcCurve || this.m_fi) && p(A_2, A_3);
							if (hc() && !dp())
							{
								fx10.q(graphics, color, g15);
								o(graphics, color, fx10, a_6, A_4: true, this.m_fe);
								if (flag3)
								{
									o(color, graphics, new PointF(A_2, A_3), a_6, this.m_em.a2().au() && !fx10.af() && !fx10.ae());
								}
							}
							else
							{
								fx10.q(graphics, g15);
								o(graphics, this.m_d9.q(), fx10, a_6, A_4: true, this.m_fe);
								if (flag3)
								{
									o(this.m_d9.q(), graphics, new PointF(A_2, A_3), a_6, this.m_em.a2().au() && !fx10.af() && !fx10.ae());
								}
							}
						}
					}
					if (dj() > 0 && (this.m_ee == global::fl.h.b || this.m_d9.ah() != null) && di() > 0)
					{
						fx fx11 = ((this.m_ee != global::fl.h.b) ? this.m_d9.ah() : this.m_d9);
						bool flag5;
						g g16;
						if (da())
						{
							flag5 = false;
							g16 = global::fl.g.a;
						}
						else
						{
							flag5 = true;
							g16 = global::fl.g.c;
						}
						fx11.ag();
						o(fx11, flag5, this.m_fq, ref A_2, ref A_3, ref A_4);
						bool flag3 = A_4 && (global::e.a().AutoTrackCalcCurve || this.m_fi) && p(A_2, A_3);
						if (hc() && !dp())
						{
							fx11.q(graphics, color, g16);
							o(graphics, color, fx11, flag5, A_4: true, this.m_fe);
							if (flag3)
							{
								o(color, graphics, new PointF(A_2, A_3), flag5, this.m_em.a2().au() && !fx11.af() && !fx11.ae());
							}
						}
						else
						{
							fx11.q(graphics, g16);
							o(graphics, this.m_d9.q(), fx11, flag5, A_4: true, this.m_fe);
							if (flag3)
							{
								o(this.m_d9.q(), graphics, new PointF(A_2, A_3), flag5, this.m_em.a2().au() && !fx11.af() && !fx11.ae());
							}
						}
					}
				}
				else
				{
					bool flag6 = false;
					bool flag7;
					switch (this.m_ee)
					{
					case global::fl.h.b:
						flag7 = dp();
						flag6 = bu;
						break;
					case global::fl.h.c:
						flag7 = @do();
						break;
					default:
						flag7 = dq();
						break;
					}
					if (this.m_c6 < 0 || this.m_c6 >= bp.Count || bp[this.m_c6].u())
					{
						this.m_d9.ag();
						o(this.m_d9, flag6, this.m_fq, ref A_2, ref A_3, ref A_4);
						bool flag3 = A_4 && (global::e.a().AutoTrackCalcCurve || this.m_fh) && p(A_2, A_3);
						if (hc() && !flag7)
						{
							this.m_d9.q(graphics, color, this.m_ef);
							o(graphics, color, this.m_d9, flag6, A_4: true, this.m_fe);
							if (flag3)
							{
								o(color, graphics, new PointF(A_2, A_3), flag6, this.m_em.a2().au() && !this.m_d9.af() && !this.m_d9.ae());
							}
						}
						else
						{
							this.m_d9.q(graphics, this.m_ef);
							o(graphics, this.m_d9.q(), this.m_d9, flag6, A_4: true, this.m_fe);
							if (flag3)
							{
								o(this.m_d9.q(), graphics, new PointF(A_2, A_3), flag6, this.m_em.a2().au() && !this.m_d9.af() && !this.m_d9.ae());
							}
						}
					}
					fx fx12 = this.m_d9.ah();
					if (fx12 != null && (this.m_c6 < 0 || this.m_c6 >= bp.Count || bp[this.m_c6].v()))
					{
						fx12.ag();
						o(fx12, bu, this.m_fq, ref A_2, ref A_3, ref A_4);
						bool flag3 = A_4 && (global::e.a().AutoTrackCalcCurve || this.m_fi) && p(A_2, A_3);
						if (hc() && !dp())
						{
							fx12.q(graphics, color);
							o(graphics, color, fx12, bu, A_4: false, this.m_ff);
							if (flag3)
							{
								o(color, graphics, new PointF(A_2, A_3), bu, this.m_em.a2().au() && !fx12.af() && !fx12.ae());
							}
						}
						else
						{
							fx12.q(graphics);
							o(graphics, this.m_d9.q(), fx12, bu, A_4: false, this.m_ff);
							if (flag3)
							{
								o(this.m_d9.q(), graphics, new PointF(A_2, A_3), bu, this.m_em.a2().au() && !fx12.af() && !fx12.ae());
							}
						}
					}
					if (this.m_d9.ai() != null && (this.m_c6 < 0 || this.m_c6 >= bp.Count || this.m_d9.ai().Count > 0))
					{
						int num8 = this.m_d9.ai().Count - 1;
						for (int num9 = 0; num9 <= num8; num9++)
						{
							this.m_d9.ai()[num9].ag();
							bool flag3;
							if (bp[this.m_c6][0].ai() != null && bp[this.m_c6].r(num9))
							{
								o(this.m_d9.ai()[num9], A_1: false, this.m_fq, ref A_2, ref A_3, ref A_4);
								flag3 = A_4 && (global::e.a().AutoTrackCalcCurve || this.m_fj[num9]) && p(A_2, A_3);
								if (hc() && !@do())
								{
									this.m_d9.ai()[num9].q(graphics, color);
									o(graphics, color, this.m_d9.ai()[num9], A_3: false, A_4: true, this.m_fg[num9]);
									if (flag3)
									{
										o(color, graphics, new PointF(A_2, A_3), A_3: false, this.m_em.a2().au() && !this.m_d9.ai()[num9].af() && !this.m_d9.ai()[num9].ae());
									}
								}
								else
								{
									this.m_d9.ai()[num9].q(graphics);
									o(graphics, this.m_d9.q(), this.m_d9.ai()[num9], A_3: false, A_4: true, this.m_fg[num9]);
									if (flag3)
									{
										o(this.m_d9.q(), graphics, new PointF(A_2, A_3), A_3: false, this.m_em.a2().au() && !this.m_d9.ai()[num9].af() && !this.m_d9.ai()[num9].ae());
									}
								}
							}
							fx fx13 = this.m_d9.ai()[num9].ah();
							if (fx13 == null)
							{
								continue;
							}
							fx13.ag();
							o(fx12, A_1: true, this.m_fq, ref A_2, ref A_3, ref A_4);
							flag3 = A_4 && (global::e.a().AutoTrackCalcCurve || this.m_fi) && p(A_2, A_3);
							if (hc() && !dp())
							{
								fx13.q(graphics, color);
								o(graphics, color, fx13, A_3: true, A_4: false, this.m_ff);
								if (flag3)
								{
									o(color, graphics, new PointF(A_2, A_3), A_3: true, this.m_em.a2().au() && !fx13.af() && !fx13.ae());
								}
							}
							else
							{
								fx13.q(graphics);
								o(graphics, this.m_d9.q(), fx13, A_3: true, A_4: false, this.m_ff);
								if (flag3)
								{
									o(this.m_d9.q(), graphics, new PointF(A_2, A_3), A_3: true, this.m_em.a2().au() && !fx13.af() && !fx13.ae());
								}
							}
						}
					}
				}
			}
			if (bp.Count > 0 && at())
			{
				int num10 = bp.Count - 1;
				for (int num11 = 0; num11 <= num10; num11++)
				{
					a<fx> a10 = bp[num11];
					Color color2 = o(a10.c, a_, q(flag));
					fx fx2 = a10[0];
					fx2.ag();
					o(a10, this.m_fq);
					double num12 = q(this.m_fq.X);
					bool flag8 = jf.c((float)num12, (float)fx2.y()) && jf.a((float)num12, (float)fx2.z());
					bool a_7 = false;
					bool flag9;
					if (!a10.s() || da())
					{
						flag9 = ((!a10.t() || dm()) ? dq() : @do());
					}
					else
					{
						flag9 = dp();
						a_7 = true;
					}
					Color a_8 = ((!hc() || (flag9 && num11 == this.m_c6)) ? fx2.q() : color2);
					if (bp[num11].u() && p((float)this.m_e6, this.m_e7) && (fx2.af() || fx2.ae()) && flag8)
					{
						o(a_8, graphics, new PointF((float)this.m_e6, this.m_e7), a_7, this.m_em.a2().au() && (fx2.af() || fx2.ae()));
					}
					fx fx14 = ((fx2.ah() == null) ? fx2 : fx2.ah());
					flag8 = jf.c((float)num12, (float)fx14.y()) && jf.a((float)num12, (float)fx14.z());
					if (((bu && fx2.ah() != null && bp[num11].v()) || (a10.s() && a10.u()) || (fx2.ah() != null && a10.v()) || da()) && fx2.ah() != null && (fx2.ah().af() || fx2.ah().ae()) && flag8)
					{
						a_8 = ((!hc() || dp()) ? ((fx2.ah() != null) ? fx2.ah().q() : fx2.q()) : color2);
						o(a_8, graphics, new PointF((float)this.m_e6, this.m_e8), bu, this.m_em.a2().au() && (fx14.af() || fx14.ae()));
					}
					if (fx2.ai() == null || fx2.ai().Count <= 0)
					{
						continue;
					}
					int num13 = fx2.ai().Count - 1;
					for (int num14 = 0; num14 <= num13; num14++)
					{
						float a_9 = ((this.m_e9 == null) ? 0f : this.m_e9[num14]);
						fx fx15 = fx2.ai()[num14];
						a_8 = ((!hc() || @do()) ? fx15.q() : color2);
						if (fx2.ai() != null)
						{
							flag8 = jf.c((float)num12, (float)fx2.ai()[num14].y()) && jf.a((float)num12, (float)fx2.ai()[num14].z());
						}
						if (bp[num11].r(num14) && (fx15.af() || fx15.ae()) && p((float)this.m_e6, a_9) && flag8)
						{
							o(a_8, graphics, new PointF((float)this.m_e6, a_9), A_3: false, this.m_em.a2().au() && (fx2.ai()[num14].af() || fx2.ai()[num14].ae()));
						}
						fx15 = null;
					}
				}
			}
			if (A_1)
			{
				if ((bp.Count > 1 && !cq) || eh().Visible)
				{
					Rectangle A_5 = default(Rectangle);
					o(d4(), A_1: true, graphics, ref A_5);
					if (eh().Visible)
					{
						o(eh(), A_1: false, graphics, ref A_5);
					}
				}
			}
			else
			{
				ag();
			}
			t(graphics, A_1);
			r(graphics);
			s(graphics, A_1);
			q(graphics);
			if (aw)
			{
				int num15 = this.m_aq.m(this);
				int num16 = this.m_aq.m(this) + this.m_aq.k(this);
				int num17 = this.m_aq.n(this);
				int num18 = this.m_aq.n(this) + this.m_aq.j(this);
				if (av)
				{
					graphics.DrawRectangle(au, this.m_ar.l(this));
				}
				else if (num15 >= b3 && num16 <= b4 && num17 >= b5 && num18 <= b1)
				{
					graphics.DrawRectangle(au, this.m_aq.l(this));
				}
				else if (num15 < b4 && num16 > b3 && num17 < b1 && num18 > b5)
				{
					if (b5 < num18 && num18 < b1 && b3 < num16 && num16 < b4)
					{
						if (b5 < num17 && num17 < b1)
						{
							graphics.DrawLine(au, new Point(b3, num18), new Point(num16, num18));
							graphics.DrawLine(au, new Point(num16, num18), new Point(num16, num17));
							graphics.DrawLine(au, new Point(num16, num17), new Point(b3, num17));
						}
						else if (b3 < num15 && num15 < b4)
						{
							graphics.DrawLine(au, new Point(num15, num18), new Point(num16, num18));
							graphics.DrawLine(au, new Point(num16, num18), new Point(num16, b5));
							graphics.DrawLine(au, new Point(num15, num18), new Point(num15, b5));
						}
						else
						{
							graphics.DrawLine(au, new Point(b3, num18), new Point(num16, num18));
							graphics.DrawLine(au, new Point(num16, num18), new Point(num16, b5));
						}
					}
					else if (b5 < num17 && num17 < b1 && b3 < num15 && num15 < b4)
					{
						if (b3 < num16 && num16 < b4)
						{
							graphics.DrawLine(au, new Point(num15, b1), new Point(num15, num17));
							graphics.DrawLine(au, new Point(num15, num17), new Point(num16, num17));
							graphics.DrawLine(au, new Point(num16, b1), new Point(num16, num17));
						}
						else if (b5 < num18 && num18 < b1)
						{
							graphics.DrawLine(au, new Point(num15, num18), new Point(num15, num17));
							graphics.DrawLine(au, new Point(num15, num17), new Point(b4, num17));
							graphics.DrawLine(au, new Point(num15, num18), new Point(b4, num18));
						}
						else
						{
							graphics.DrawLine(au, new Point(num15, b1), new Point(num15, num17));
							graphics.DrawLine(au, new Point(num15, num17), new Point(b4, num17));
						}
					}
					else if (b5 < num17 && num17 < b1 && b3 < num16 && num16 < b4)
					{
						graphics.DrawLine(au, new Point(b3, num17), new Point(num16, num17));
						graphics.DrawLine(au, new Point(num16, num17), new Point(num16, b1));
					}
					else if (b5 < num18 && num18 < b1 && b3 < num15 && num15 < b4)
					{
						graphics.DrawLine(au, new Point(num15, b5), new Point(num15, num18));
						graphics.DrawLine(au, new Point(num15, num18), new Point(b4, num18));
					}
					else if (b3 < num16 && num16 < b4)
					{
						graphics.DrawLine(au, new Point(num16, b1), new Point(num16, b5));
						if (b3 < num15 && num15 < b4)
						{
							graphics.DrawLine(au, new Point(num15, b1), new Point(num15, b5));
						}
					}
					else if (b3 < num15 && num15 < b4)
					{
						graphics.DrawLine(au, new Point(num15, b1), new Point(num15, b5));
					}
					else if (b5 < num18 && num18 < b1)
					{
						graphics.DrawLine(au, new Point(b3, num18), new Point(b4, num18));
						if (b5 < num17 && num17 < b1)
						{
							graphics.DrawLine(au, new Point(b3, num17), new Point(b4, num17));
						}
					}
					else if (b5 < num17 && num17 < b1)
					{
						graphics.DrawLine(au, new Point(b3, num17), new Point(b4, num17));
					}
				}
			}
			if (!A_1)
			{
				graphics.Dispose();
				A_0.DrawImageUnscaled(this.m_el, 0, 0);
			}
		}
	}

	private void ds()
	{
		checked
		{
			try
			{
				if (!this.m_dq || ((bp == null || bp.Count == 0) && this.m_d9 == null) || x())
				{
					return;
				}
				ab();
				v();
				r(1f);
				Point point = new Point(b3, b5);
				bool flag = true;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				bool flag5 = false;
				bool flag6 = false;
				bool A_2 = default(bool);
				Point a_2 = default(Point);
				bool flag8 = default(bool);
				do
				{
					point = new Point(b3, b5);
					bool A_ = false;
					bool flag7;
					do
					{
						if (A_)
						{
							point = new Point(b3, b5);
							A_ = false;
						}
						flag7 = true;
						int num = bp.Count - 1;
						int num2 = 0;
						while (num2 <= num)
						{
							if (!A_2)
							{
								a<fx> a10 = bp[num2];
								int num3 = a10.Count - 1;
								for (int num4 = 0; num4 <= num3; num4++)
								{
									fx fx2 = a10[num4];
									if (a10.u())
									{
										if ((flag || flag2) && b7() && !o(fx2, A_1: false, ref A_, ref point, A_4: false, flag, flag2, flag3, ref A_2, num2 == 0 && num4 == 0))
										{
											flag7 = false;
											break;
										}
										if ((flag || flag3) && a2() && !o(fx2, A_1: false, ref A_, ref point, A_4: true, flag, flag2, flag3, ref A_2, num2 == 0 && num4 == 0))
										{
											flag7 = false;
											break;
										}
									}
									if (flag7 && fx2.ah() != null && a10.v())
									{
										if ((flag || flag2) && b7() && !o(fx2.ah(), A_1: true, ref A_, ref point, A_4: false, flag, flag2, flag3, ref A_2, num2 == 0 && num4 == 0))
										{
											flag7 = false;
											break;
										}
										if ((flag || flag3) && a2() && !o(fx2.ah(), A_1: true, ref A_, ref point, A_4: true, flag, flag2, flag3, ref A_2, num2 == 0 && num4 == 0))
										{
											flag7 = false;
											break;
										}
									}
									if (flag7 && a10.s() && a10.u())
									{
										if ((flag || flag2) && b7() && !o(fx2, A_1: true, ref A_, ref point, A_4: false, flag, flag2, flag3, ref A_2, num2 == 0 && num4 == 0))
										{
											flag7 = false;
											break;
										}
										if ((flag || flag3) && a2() && !o(fx2, A_1: true, ref A_, ref point, A_4: true, flag, flag2, flag3, ref A_2, num2 == 0 && num4 == 0))
										{
											flag7 = false;
											break;
										}
									}
									if (!flag7 || fx2.ai() == null || fx2.ai().Count <= 0)
									{
										continue;
									}
									int num5 = fx2.ai().Count - 1;
									for (int num6 = 0; num6 <= num5; num6++)
									{
										fx a_ = fx2.ai()[num6];
										if (a10.r(num6))
										{
											if ((flag || flag2) && b7() && !o(a_, A_1: false, ref A_, ref point, A_4: false, flag, flag2, flag3, ref A_2, A_9: false))
											{
												flag7 = false;
												break;
											}
											if ((flag || flag3) && a2() && !o(a_, A_1: false, ref A_, ref point, A_4: true, flag, flag2, flag3, ref A_2, A_9: false))
											{
												flag7 = false;
												break;
											}
										}
									}
									if (!flag7)
									{
										break;
									}
								}
								if (!flag7)
								{
									break;
								}
								num2++;
								continue;
							}
							goto IL_0353;
						}
						if (flag3 && o(point, a_2))
						{
							flag7 = false;
							int num7 = a_2.X + d4().Width + 5;
							int num8 = point.Y;
							if (num7 + eh().Width > b4)
							{
								num7 = point.X;
								num8 = a_2.Y + d4().Height + 2;
							}
							point.X = num7;
							point.Y = num8;
						}
						if (this.m_d9 == null || !flag7)
						{
							continue;
						}
						if ((flag || flag2) && b7() && !o(this.m_d9, A_1: false, ref A_, ref point, A_4: false, flag, flag2, flag3, ref A_2, A_9: true))
						{
							flag7 = false;
						}
						else if ((flag || flag3) && a2() && !o(this.m_d9, A_1: false, ref A_, ref point, A_4: true, flag, flag2, flag3, ref A_2, A_9: true))
						{
							flag7 = false;
						}
						if ((flag || flag2) && flag7 && this.m_d9.ah() != null && b7() && !o(this.m_d9.ah(), A_1: true, ref A_, ref point, A_4: false, flag, flag2, flag3, ref A_2, A_9: true))
						{
							flag7 = false;
						}
						else if ((flag || flag3) && a2() && !o(this.m_d9.ah(), A_1: true, ref A_, ref point, A_4: true, flag, flag2, flag3, ref A_2, A_9: true))
						{
							flag7 = false;
						}
						if (!flag7 || this.m_d9.ai() == null || this.m_d9.ai().Count <= 0)
						{
							continue;
						}
						foreach (fx item in this.m_d9.ai())
						{
							if ((flag || flag2) && b7() && !o(item, A_1: false, ref A_, ref point, A_4: false, flag, flag2, flag3, ref A_2, A_9: true))
							{
								flag7 = false;
								break;
							}
							if ((flag || flag3) && a2() && !o(item, A_1: false, ref A_, ref point, A_4: true, flag, flag2, flag3, ref A_2, A_9: true))
							{
								flag7 = false;
								break;
							}
						}
						continue;
						IL_0353:
						if ((!this.m_em.ao() && !bu) || (bu && !this.m_em.ao() && !this.m_em.aq()) || dr() > 3f)
						{
							flag8 = true;
							break;
						}
						A_2 = false;
						flag7 = false;
						flag6 = false;
						flag4 = false;
						flag5 = false;
						flag = true;
						flag2 = false;
						flag3 = false;
						break;
					}
					while (!flag7 && (!flag || !A_));
					if (flag8)
					{
						break;
					}
					if (flag2)
					{
						flag4 = flag7;
						a_2 = point;
					}
					if (flag3)
					{
						flag5 = flag7;
					}
					if (flag)
					{
						flag6 = flag7;
					}
					if (A_ && flag && !flag7)
					{
						flag = false;
						flag2 = true;
						flag3 = false;
					}
					if (flag7 && flag2 && !flag)
					{
						if (a2())
						{
							flag = false;
							flag2 = false;
							flag3 = true;
						}
						else
						{
							flag5 = true;
						}
					}
				}
				while (!flag6 && (!flag4 || !flag5));
				if (flag8)
				{
					r(1f);
					int num9 = ((d4().Width <= eh().Width) ? eh().Width : d4().Width);
					d4().Left = b4 - num9;
					d4().Top = b5;
					eh().Left = b4 - num9;
					eh().Top = d4().Bottom;
				}
				else if (flag6 && b7())
				{
					d4().Left = point.X;
					d4().Top = point.Y;
				}
				else
				{
					d4().Left = a_2.X;
					d4().Top = a_2.Y;
					eh().Left = point.X;
					eh().Top = point.Y;
				}
				if (flag && b7())
				{
					eh().Left = d4().Left;
					eh().Top = d4().Bottom;
				}
			}
			finally
			{
				ac();
				w();
			}
		}
	}

	private bool o(Point A_0, Point A_1)
	{
		Point point = A_0;
		Size size = eh().Size;
		if (!b7())
		{
			return false;
		}
		checked
		{
			int num = default(int);
			point.X -= num;
			point.Y -= num;
			size.Width += 2 * num;
			size.Height += 2 * num;
			return (point.X >= A_1.X && point.X < A_1.X + d4().Width && point.Y >= A_1.Y && point.Y < A_1.Y + d4().Height) || (point.X >= A_1.X && point.X < A_1.X + d4().Width && point.Y + size.Height >= A_1.Y && point.Y + size.Height < A_1.Y + d4().Height) || (point.X + size.Width >= A_1.X && point.X + size.Width < A_1.X + d4().Width && point.Y >= A_1.Y && point.Y < A_1.Y + d4().Height) || (point.X + size.Width >= A_1.X && point.X + size.Width < A_1.X + d4().Width && point.Y + size.Height >= A_1.Y && point.Y + size.Height < A_1.Y + d4().Height) || (A_1.X >= point.X && A_1.Y >= point.Y && A_1.X + d4().Width <= point.X + size.Width && A_1.Y + d4().Height <= point.Y + size.Height);
		}
	}

	private bool o(fx A_0, bool A_1, ref Point A_2, bool A_3, bool A_4, bool A_5, bool A_6, bool A_7)
	{
		if (A_0 == null)
		{
			return false;
		}
		int num = 2;
		int A_8 = default(int);
		int A_9 = default(int);
		o(A_0, ref A_8, ref A_9, ref A_2, (A_4 && A_3) || A_6);
		checked
		{
			int num2;
			int num3;
			if (this.m_d5)
			{
				num2 = d4().Width - 10;
				num3 = d4().Height - 10;
			}
			else if (b7())
			{
				num2 = d4().Width;
				num3 = d4().Height;
			}
			else
			{
				num2 = 0;
				num3 = 0;
			}
			int num4;
			int num5;
			if (this.m_d6)
			{
				num4 = eh().Width - 10;
				num5 = eh().Height - 10;
			}
			else if (a2())
			{
				num4 = eh().Width;
				num5 = eh().Height;
			}
			else
			{
				num4 = 0;
				num5 = 0;
			}
			if ((((A_4 && A_3) || A_6) ? num5 : num3) + A_2.Y > b1)
			{
				return true;
			}
			int num6 = ((((!A_4 || !A_3) && !A_6) || !a2()) ? (A_2.X + num2) : (A_2.X + num4));
			double a_ = q((float)(A_2.X - num));
			double a_2 = q((float)(num6 + num));
			double num7 = default(double);
			double num8 = default(double);
			if (!A_1)
			{
				if (A_4)
				{
					if (A_3 && a2())
					{
						num7 = p((float)(A_2.Y + num3 + num5 + num));
						num8 = p((float)(A_2.Y + num3));
					}
					else
					{
						num7 = p((float)(A_2.Y + num3 + num));
						num8 = p((float)(A_2.Y - num));
					}
				}
				else if (A_5)
				{
					num7 = p((float)(A_2.Y + num3 + num));
					num8 = p((float)(A_2.Y - num));
				}
				else if (A_6)
				{
					num7 = p((float)(A_2.Y + num5 + num));
					num8 = p((float)(A_2.Y - num));
				}
			}
			else if (A_4)
			{
				if (A_3 && a2())
				{
					num7 = o((float)(A_2.Y + num3 + num5 + num));
					num8 = o((float)(A_2.Y + num3));
				}
				else
				{
					num7 = o((float)(A_2.Y + num3 + num));
					num8 = o((float)(A_2.Y - num));
				}
			}
			else if (A_5)
			{
				num7 = o((float)(A_2.Y + num3 + num));
				num8 = o((float)(A_2.Y - num));
			}
			else if (A_6)
			{
				num7 = o((float)(A_2.Y + num5 + num));
				num8 = o((float)(A_2.Y - num));
			}
			if (A_0.q(A_8, A_9, num8, num7))
			{
				return true;
			}
			if (A_7)
			{
				if (A_4)
				{
					if (eh().Width > d4().Width && a2())
					{
						_ = eh().Width;
					}
					else
					{
						_ = d4().Width;
					}
					if (ei().Visible)
					{
						_ = d4().Height + eh().Height;
					}
					else
					{
						_ = d4().Height;
					}
				}
				else if (A_5)
				{
					_ = d4().Width;
					_ = d4().Height;
				}
				else if (A_6)
				{
					_ = eh().Width;
					_ = eh().Height;
				}
				if (this.m_dg > 0)
				{
					int num9 = this.m_dg - 1;
					for (int num10 = 0; num10 <= num9; num10++)
					{
						double num11;
						double num12;
						if (this.m_dc[num10])
						{
							if (A_1)
							{
								continue;
							}
							num11 = this.m_em.at(false);
							num12 = this.m_em.a0();
						}
						else
						{
							if (!A_1)
							{
								continue;
							}
							num11 = this.m_em.au(false);
							num12 = this.m_em.a1();
						}
						double num13 = num11 - num12;
						double num14 = 0.0;
						if (this.m_de.Length == this.m_dg && this.m_dg > 0)
						{
							int num15 = (int)Math.Round((double)b5 + (num11 - this.m_de[num10]) * (double)b2 / num13);
							num14 = ((!this.m_dc[num10]) ? o((float)num15) : p((float)num15));
						}
						if ((this.m_c8[num10] > q((float)(A_2.X - num)) && this.m_c9[num10] < q((float)(num6 + num)) && this.m_da[num10] > num8 && this.m_db[num10] > num7) || o(this.m_c8[num10], this.m_c9[num10], this.m_da[num10], this.m_db[num10], a_, a_2, num8, num7, A_8: true) || o(this.m_c8[num10], this.m_c9[num10], this.m_da[num10], this.m_db[num10], a_, a_2, num8, num7, A_8: false) || o(this.m_c8[num10], this.m_c9[num10], num14, num14, a_, a_2, num8, num7, A_8: true) || o(t(this.m_c8[num10]), s(this.m_db[num10]), A_2.X, num6, s(num8), s(num7), A_6: true))
						{
							return true;
						}
					}
				}
				if (this.m_do > 0)
				{
					this.m_em.a2().aq();
					double num16 = this.m_em.a2().ap();
					int num17 = this.m_do - 1;
					for (int num18 = 0; num18 <= num17; num18++)
					{
						if (this.m_dl[num18])
						{
							if (A_1)
							{
								continue;
							}
							double num19 = this.m_em.at(false);
							double num20 = this.m_em.a0();
						}
						else
						{
							if (!A_1)
							{
								continue;
							}
							double num19 = this.m_em.au(false);
							double num20 = this.m_em.a1();
						}
						double a_3;
						double a_4;
						if (this.m_dn.Length == this.m_dp && this.m_dp > 0)
						{
							a_3 = this.m_dn[num18].e();
							a_4 = this.m_dn[num18].f();
						}
						else
						{
							a_3 = 0.0;
							a_4 = 0.0;
						}
						if ((this.m_dh[num18] > q((float)(A_2.X - num)) && this.m_di[num18] < q((float)(num6 + num)) && this.m_dj[num18] > num8 && this.m_dk[num18] > num7) || o(this.m_dh[num18], this.m_di[num18], this.m_dj[num18], this.m_dk[num18], a_, a_2, num8, num7, A_8: true) || o(this.m_dh[num18], this.m_di[num18], this.m_dj[num18], this.m_dk[num18], a_, a_2, num8, num7, A_8: false) || o(t(this.m_dh[num18]), s(this.m_dk[num18]), A_2.X, num6, s(num8), s(num7), A_6: true) || o(t(a_3), s(a_4), A_2.X, num6, s(num8), s(num7), A_6: false))
						{
							return true;
						}
					}
				}
			}
			return false;
		}
	}

	private bool o(double A_0, double A_1, double A_2, double A_3, double A_4, double A_5, double A_6, double A_7, bool A_8)
	{
		if (A_2 == 0.0 && A_3 == 0.0)
		{
			return false;
		}
		if (A_8)
		{
			if (((A_2 > A_7 && A_2 < A_6) || (A_3 > A_7 && A_3 < A_6)) && ((A_1 > A_4 && A_1 <= A_5) || (A_0 > A_4 && A_0 < A_5) || (A_0 > A_4 && A_1 < A_5) || (A_0 < A_4 && A_1 > A_5)))
			{
				return true;
			}
		}
		else if (((A_0 > A_4 && A_0 < A_5) || (A_1 > A_4 && A_1 < A_5)) && ((A_2 < A_6 && A_3 > A_7) || (A_2 > A_6 && A_2 < A_7) || (A_3 > A_6 && A_3 < A_7) || (A_2 > A_6 && A_3 < A_7)))
		{
			return true;
		}
		return false;
	}

	private bool o(double A_0, double A_1, double A_2, double A_3, double A_4, double A_5, bool A_6)
	{
		double num;
		double num2;
		double num3;
		double num4;
		if (A_6)
		{
			num = A_0;
			num2 = A_1 - 12.0;
			num3 = num + 22.0;
			num4 = A_1;
		}
		else
		{
			num = A_0;
			num2 = A_1;
			num3 = num + 22.0;
			num4 = A_1 + 12.0;
		}
		if (A_0 == 0.0 && A_1 == 0.0)
		{
			return false;
		}
		if ((num3 > A_2 && num3 < A_3 && ((num2 >= A_4 && num2 < A_5) || (num4 > A_4 && num4 < A_5) || (num2 < A_4 && num4 > A_5))) || (num > A_2 && num < A_3 && ((num2 >= A_4 && num2 < A_5) || (num4 > A_4 && num4 < A_5))) || (num > A_2 && num3 < A_3 && num2 > A_4 && num4 < A_5) || (num > A_2 && num3 < A_3 && num2 < A_5 && num4 > A_4))
		{
			return true;
		}
		return false;
	}

	private bool o(fx A_0, bool A_1, ref bool A_2, ref Point A_3, bool A_4, bool A_5, bool A_6, bool A_7, ref bool A_8, bool A_9)
	{
		checked
		{
			bool flag = default(bool);
			if (o(A_0, A_1, ref A_3, A_4, A_5, A_6, A_7, A_9))
			{
				int num = default(int);
				int num2 = default(int);
				if (A_6)
				{
					num = d4().Width;
					num2 = d4().Height;
				}
				else if (A_7)
				{
					num = eh().Width;
					num2 = eh().Height;
				}
				else if (A_5)
				{
					num = ((eh().Width <= d4().Width || !a2()) ? d4().Width : eh().Width);
					num2 = ((!a2()) ? d4().Height : (eh().Height + d4().Height));
				}
				if (A_3.X + num + 20 < b4)
				{
					A_3.X += 20;
					flag = true;
				}
				else if (A_3.Y + num2 + 20 > b1)
				{
					flag = true;
					if (A_6 || A_7)
					{
						A_8 = true;
						r(dr() * 1.1f);
					}
					A_2 = true;
				}
				else
				{
					A_3.Y += 20;
					A_3.X = b3 + 5;
					flag = true;
				}
			}
			return !flag;
		}
	}

	[SpecialName]
	private float dr()
	{
		return this.m_e4;
	}

	[SpecialName]
	private void r(float A_0)
	{
		this.m_e4 = A_0;
		g6();
	}

	private void o(fx A_0, ref int A_1, ref int A_2, ref Point A_3, bool A_4)
	{
		int num = 2;
		checked
		{
			int num3;
			if (A_4)
			{
				int num2 = ((!this.m_d6) ? eh().Width : (eh().Width - 10));
				num3 = A_3.X + num2;
			}
			else
			{
				int num4 = ((!this.m_d5) ? d4().Width : (d4().Width - 10));
				num3 = A_3.X + num4;
			}
			double a_ = q((float)(A_3.X - num));
			double a_2 = q((float)(num3 + num));
			A_0.q(a_, a_2, ref A_1, ref A_2);
		}
	}

	public static void o(double A_0, double A_1, short A_2, ref double A_3, ref double A_4)
	{
		short[] array = new short[4];
		if (A_0 >= 3.4028234663852886E+38)
		{
			A_0 = 0.0;
		}
		if (A_1 >= 3.4028234663852886E+38 || A_1 - A_0 > 3.4028234663852886E+38)
		{
			A_1 = 3.4028234663852886E+38;
			A_0 = 0.0;
		}
		array[0] = 5;
		array[1] = 2;
		array[2] = 1;
		double num = A_1 - A_0;
		if (num <= 0.0)
		{
			A_3 = A_0;
			A_4 = 1.0;
			return;
		}
		short num2 = -1;
		checked
		{
			short num6 = default(short);
			short num7 = default(short);
			double num8 = default(double);
			do
			{
				num2++;
				short num3 = (short)Math.Round(Conversion.Int(Math.Log((short)unchecked(A_2 * array[num2])) * 0.4342944819032604));
				double num4 = Math.Pow(10.0, Conversion.Int(Math.Log(num) * 0.4342944819032604) - (double)num3);
				short num5 = (short)Math.Round(Conversion.Int(num / (num4 * (double)array[num2])));
				if (num5 > A_2)
				{
					num3--;
					num4 = Math.Pow(10.0, Conversion.Int(Math.Log(num) * 0.4342944819032604) - (double)num3);
					num5 = (short)Math.Round(Conversion.Int(num / (num4 * (double)array[num2])));
				}
				if ((num5 <= A_2) & (num5 > num6))
				{
					num6 = num5;
					num7 = num2;
					num8 = num4;
				}
			}
			while (num2 != 2);
			A_3 = Conversion.Int(A_0 / ((double)array[num7] * num8)) * (double)array[num7] * num8;
			if (A_3 < A_0)
			{
				A_3 += (double)array[num7] * num8;
			}
			A_4 = (double)array[num7] * num8;
		}
	}

	public void q(float A_0, float A_1)
	{
		checked
		{
			d4().Left = (int)Math.Round((double)((float)b3 + A_0 * (float)b6) - (double)d6().Width / 2.0);
			d4().Top = (int)Math.Round((double)((float)b5 + A_1 * (float)b2) - (double)d6().Height / 2.0);
		}
	}

	public void g9()
	{
		if (a3 != null)
		{
			a3.Text = bf + ":";
		}
		bool flag = bu && (!gv() || !bo || this.m_d9.ah() != null);
		bool flag2 = gv() && bo && this.m_ee == global::fl.h.b;
		if (this.m_a5 != null)
		{
			if (flag)
			{
				this.m_a5.Text = bh[0] + ":";
			}
			else if (flag2)
			{
				this.m_a5.Text = bg[1] + ":";
			}
			else
			{
				this.m_a5.Text = bg[0] + ":";
			}
		}
		if (flag && a7 != null)
		{
			a7.Text = bh[1] + ":";
		}
	}

	public void ha()
	{
		g9();
		this.m_gk?.Invoke(this);
	}

	public void p(double A_0, double A_1, bool A_2)
	{
		b b10 = this.m_fy;
		if (A_2)
		{
			b10.e.a = this.m_em.a2().ap();
			b10.e.b = this.m_em.a2().aq();
		}
		else
		{
			b10.e.a = A_0;
			b10.e.b = A_1;
		}
		b10.f = A_2;
		b10 = null;
	}

	public void o(double A_0, double A_1)
	{
		fr fr2 = this.m_em.a2();
		if ((A_1 < fr2.ap() || A_0 > fr2.aq()) && !jf.e(A_1, A_0))
		{
			fr2.am(A_0);
			fr2.an(A_1);
		}
		fr2 = null;
	}

	public void o(string A_0, string A_1, bool A_2)
	{
		o(global::fl.h.a, A_0, A_1, A_2);
	}

	public void o(h A_0, string A_1, string A_2)
	{
		o(A_0, A_1, A_2, A_3: false);
	}

	public void o(h A_0, string A_1, string A_2, bool A_3)
	{
		bool flag = false;
		if (Operators.CompareString(bg[(int)A_0], A_1, TextCompare: false) != 0)
		{
			flag = true;
		}
		bg[(int)A_0] = A_1;
		bh[(int)A_0] = A_2;
		switch (A_0)
		{
		case global::fl.h.a:
			br = A_3;
			break;
		case global::fl.h.b:
			br = A_3;
			bu = !string.IsNullOrEmpty(bg[(int)A_0]) && !da();
			break;
		}
		if (bp.Count > 0)
		{
			flag = true;
		}
		if (flag)
		{
			aq();
			hb();
		}
	}

	protected void hb()
	{
		if (f9)
		{
			er.Reset();
			e1().Start();
		}
	}

	private void t(Graphics A_0, bool A_1)
	{
		if (this.m_dg <= 0)
		{
			return;
		}
		checked
		{
			int num = this.m_dg - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (this.m_dc[num2] || (bu && this.m_dd[num2]))
				{
					double a_ = this.m_c8[num2];
					double a_2 = this.m_c9[num2];
					double a_3 = this.m_da[num2];
					double a_4 = this.m_db[num2];
					o(a_, a_2, a_3, a_4, A_0, A_1, A_6: false, num2 + 1, this.m_dd[num2]);
				}
			}
		}
	}

	private void r(Graphics A_0)
	{
		Pen pen = new Pen(Color.FromArgb(185, 0, 255, 0), 3f);
		Pen pen2 = new Pen(Color.FromArgb(185, 255, 0, 0), 3f);
		if (this.m_em == null)
		{
			return;
		}
		double num = this.m_em.a2().aq();
		double num2 = this.m_em.a2().ap();
		double num3 = num - num2;
		pen2.StartCap = LineCap.Flat;
		pen2.EndCap = LineCap.Flat;
		if (this.m_df <= 0)
		{
			return;
		}
		checked
		{
			int num4 = this.m_df - 1;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				if (!this.m_dc[num5] && !this.m_dd[num5])
				{
					continue;
				}
				double num6;
				double num7;
				if (this.m_dc[num5])
				{
					num6 = this.m_em.at(false);
					num7 = this.m_em.a0();
				}
				else
				{
					num6 = this.m_em.au(false);
					num7 = this.m_em.a1();
				}
				double num8 = num6 - num7;
				double num9 = this.m_c8[num5];
				double num10 = this.m_c9[num5];
				double num11 = this.m_da[num5];
				double num12 = this.m_db[num5];
				double num13 = this.m_de[num5];
				if (!(((num9 < num2) & (num10 < num2)) | ((num9 > num) & (num10 > num)) | ((num11 < num7) & (num12 < num7)) | ((num11 > num6) & (num12 > num6)) | (num13 < num7) | (num13 > num6)))
				{
					if (num9 < num2)
					{
						num9 = num2;
					}
					if (num10 > num)
					{
						num10 = num;
					}
					int x2 = (int)Math.Round((double)b3 + (num9 - num2) * (double)b6 / num3);
					int x3 = (int)Math.Round((double)b3 + (num10 - num2) * (double)b6 / num3);
					int num14 = (int)Math.Round((double)b5 + (num6 - num13) * (double)b2 / num8);
					int y2 = num14;
					if ((num13 >= num11) & (num13 <= num12))
					{
						A_0.DrawLine(pen, x2, num14, x3, y2);
					}
					else
					{
						A_0.DrawLine(pen2, x2, num14, x3, y2);
					}
				}
			}
		}
	}

	private void s(Graphics A_0, bool A_1)
	{
		if (this.m_do <= 0)
		{
			return;
		}
		checked
		{
			int num = this.m_do - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (this.m_dl[num2] || (bu && this.m_dm[num2]))
				{
					double a_ = this.m_dh[num2];
					double a_2 = this.m_di[num2];
					double a_3 = this.m_dj[num2];
					double a_4 = this.m_dk[num2];
					o(a_, a_2, a_3, a_4, A_0, A_1, A_6: true, num2 + 1, this.m_dm[num2]);
				}
			}
		}
	}

	private void q(Graphics A_0)
	{
		Pen pen = new Pen(Color.FromArgb(185, 0, 255, 0), 3f);
		Pen pen2 = new Pen(Color.FromArgb(185, 255, 0, 0), 3f);
		Font font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point);
		if (this.m_em == null)
		{
			return;
		}
		double num = this.m_em.a2().aq();
		double num2 = this.m_em.a2().ap();
		double num3 = num - num2;
		SolidBrush brush = ((global::e.a().GraphBackColor != 0) ? new SolidBrush(Color.White) : new SolidBrush(Color.Black));
		if (this.m_dp <= 0)
		{
			return;
		}
		checked
		{
			int num4 = this.m_dp - 1;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				if (!this.m_dl[num5] && !this.m_dm[num5])
				{
					continue;
				}
				double num6;
				double num7;
				if (this.m_dl[num5])
				{
					num6 = this.m_em.at(false);
					num7 = this.m_em.a0();
				}
				else
				{
					num6 = this.m_em.au(false);
					num7 = this.m_em.a1();
				}
				double num8 = num6 - num7;
				double num9 = this.m_dh[num5];
				double num10 = this.m_di[num5];
				double num11 = this.m_dj[num5];
				double num12 = this.m_dk[num5];
				float num13 = this.m_dn[num5].e();
				float num14 = this.m_dn[num5].f();
				if (!(((num9 < num2) & (num10 < num2)) | ((num9 > num) & (num10 > num)) | ((num11 < num7) & (num12 < num7)) | ((num11 > num6) & (num12 > num6)) | ((double)num14 < num7) | ((double)num14 > num6) | ((double)num13 < num2) | ((double)num13 > num)))
				{
					float num15 = (float)((double)b3 + ((double)num13 - num2) * (double)b6 / num3);
					float num16 = (float)((double)b5 + (num6 - (double)num14) * (double)b2 / num8);
					float num17 = 3f;
					float num18 = 3f;
					num15 = (float)((double)num15 - 1.5);
					num16 = (float)((double)num16 - 1.5);
					if (((double)num13 >= num9) & ((double)num13 <= num10) & (((double)num14 >= num11) & ((double)num14 <= num12)))
					{
						A_0.DrawEllipse(pen, num15, num16, num17, num18);
					}
					else
					{
						A_0.DrawEllipse(pen2, num15, num16, num17, num18);
					}
					string text = "M" + Conversions.ToString(num5 + 1);
					SizeF sizeF = A_0.MeasureString(text, font);
					float num19 = num15 + (num17 - sizeF.Width) / 2f;
					float num20 = ((!(num16 + num18 + sizeF.Height > (float)b1)) ? (num16 + num18) : (num16 - sizeF.Height));
					A_0.DrawString(text, font, brush, num19, num20);
				}
			}
		}
	}

	private bool o(double A_0, double A_1, double A_2, double A_3, Graphics A_4, bool A_5, bool A_6, int A_7, bool A_8)
	{
		double num = this.m_em.a2().aq();
		double num2 = this.m_em.a2().ap();
		double num3 = num - num2;
		Pen pen = new Pen(Color.FromArgb(185, 125, 125, 125), 3f);
		Pen pen2 = new Pen(Color.FromArgb(185, 110, 110, 110), 3f);
		string text = "R" + Conversions.ToString(A_7);
		Font font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point);
		double num4;
		double num5;
		if (A_8)
		{
			num4 = this.m_em.au(false);
			num5 = this.m_em.a1();
		}
		else
		{
			num4 = this.m_em.at(false);
			num5 = this.m_em.a0();
		}
		double num6 = num4 - num5;
		if (A_6)
		{
			pen.DashStyle = DashStyle.Dash;
			pen2.DashStyle = DashStyle.Dash;
			text = "M" + Conversions.ToString(A_7);
		}
		Pen pen3 = ((global::e.a().GraphBackColor != 0 && !A_5) ? pen2 : pen);
		if ((A_0 < num2 && A_1 < num2) || (A_0 > num && A_1 > num) || (A_2 < num5 && A_3 < num5) || (A_2 > num4 && A_3 > num4))
		{
			return false;
		}
		checked
		{
			int num7 = (int)Math.Round((double)b3 + num2 * (double)b6 / num3);
			int num8 = (int)Math.Round((double)b5 + num5 * (double)b2 / num6);
			int num9 = (int)Math.Round((double)b3 + (A_0 - num2) * (double)b6 / num3);
			int num10 = (int)Math.Round((double)b3 + (A_1 - num2) * (double)b6 / num3);
			int num11 = (int)Math.Round((double)b5 + (num4 - A_3) * (double)b2 / num6);
			int num12 = (int)Math.Round((double)b5 + (num4 - A_2) * (double)b2 / num6);
			SolidBrush brush = ((global::e.a().GraphBackColor != 0) ? new SolidBrush(pen.Color) : new SolidBrush(pen2.Color));
			SizeF sizeF = A_4.MeasureString(text, font);
			if ((A_0 < num2) | (A_3 > num4) | (A_2 < num5) | (A_1 > num))
			{
				bool flag = true;
				bool flag2 = true;
				bool flag3 = true;
				bool flag4 = true;
				if (A_0 < num2)
				{
					flag = false;
					num9 = b3;
				}
				if (A_1 > num)
				{
					flag3 = false;
					num10 = (int)Math.Round((double)b3 + (num - num2) * (double)b6 / num3);
				}
				if (A_2 < num5)
				{
					flag4 = false;
					num12 = (int)Math.Round((double)b5 + (num4 - num5) * (double)b2 / num6);
				}
				if (A_3 > num4)
				{
					flag2 = false;
					num11 = b5;
				}
				if (flag)
				{
					A_4.DrawLine(pen3, num9, num11, num9, num12);
				}
				if (flag2)
				{
					A_4.DrawLine(pen3, num9, num11, num10, num11);
				}
				if (flag3)
				{
					A_4.DrawLine(pen3, num10, num11, num10, num12);
				}
				if (flag4)
				{
					A_4.DrawLine(pen3, num9, num12, num10, num12);
				}
				if (flag && flag2)
				{
					float num13 = num9 + 2;
					float num14 = (float)num11 - sizeF.Height + 2f;
					if (num13 > (float)num7 && num14 > (float)num8)
					{
						if (A_5)
						{
							A_4.DrawString(text, font, Brushes.Black, num13, num14);
						}
						else
						{
							A_4.DrawString(text, font, brush, num13, num14);
						}
					}
				}
			}
			else
			{
				Rectangle rect = new Rectangle
				{
					X = num9,
					Y = num11,
					Width = num10 - num9,
					Height = num12 - num11
				};
				A_4.DrawRectangle(pen3, rect);
				float num13 = rect.X + 2;
				float num14 = (float)rect.Y - sizeF.Height + 2f;
				if (A_5)
				{
					A_4.DrawString(text, font, Brushes.Black, num13, num14);
				}
				else
				{
					A_4.DrawString(text, font, brush, num13, num14);
				}
			}
			return true;
		}
	}

	[SpecialName]
	private bool dq()
	{
		return this.m_f4 == global::fl.h.a;
	}

	[SpecialName]
	private bool dp()
	{
		return this.m_f4 == global::fl.h.b;
	}

	[SpecialName]
	private bool @do()
	{
		return this.m_f4 == global::fl.h.c;
	}

	private void o(a<fx> A_0, ref double[] A_1, ref double[] A_2, int A_3, long A_4, double A_5, bool A_6, ref double[] A_7, ref double[] A_8, int A_9)
	{
		fx fx2 = new fx();
		a<fx> a10 = A_0;
		checked
		{
			if (a0)
			{
				while (a10.Count + 1 > bb)
				{
					a10.RemoveAt(a10.Count - 1);
				}
			}
			else
			{
				a10.Clear();
			}
			a10.Insert(0, fx2);
			a10 = null;
			fx2.q(A_4);
			fx2.q(A_6);
			double[] a_ = A_1;
			double[] a_2 = A_2;
			fl A_10 = this;
			fx2.q(a_, a_2, A_3, ref A_10);
			fx2.q(A_0.c);
			fx2.s = A_5;
			if (A_9 > 0)
			{
				fx fx3 = new fx(global::fl.g.c);
				fx2.q(fx3);
				fx3.q(A_4);
				fx3.q(A_6);
				double[] a_3 = A_7;
				double[] a_4 = A_8;
				A_10 = this;
				fx3.q(a_3, a_4, A_9, ref A_10);
				fx3.q(A_0.c);
			}
			_ = null;
		}
	}

	private void o(a<fx> A_0, n A_1, long A_2, double A_3, bool A_4)
	{
		fx fx2 = new fx(global::fl.g.a);
		fx fx3 = fx2;
		fx3.q(A_2);
		fx3.q(A_4);
		fx obj = fx3;
		double[] a_ = A_1.e()[0].a;
		double[] a_2 = A_1.e()[0].b;
		int a_3 = A_1.e()[0].c;
		fl A_5 = this;
		obj.q(a_, a_2, a_3, ref A_5);
		fx3.q(A_0.c);
		fx3.s = A_3;
		if (A_0.Count > 0)
		{
			fx3.q(A_0[0].ad());
			fx2.v(A_0[0].af());
			fx2.u(A_0[0].ae());
		}
		if (A_1.e()[0].f > 0)
		{
			fx fx4 = new fx(global::fl.g.c);
			fx2.q(fx4);
			fx4.q(A_2);
			fx4.q(A_4);
			double[] a_4 = A_1.e()[0].d;
			double[] a_5 = A_1.e()[0].e;
			int a_6 = A_1.e()[0].f;
			A_5 = this;
			fx4.q(a_4, a_5, a_6, ref A_5);
			fx4.q(A_0.c);
			if (A_0.Count > 0)
			{
				fx4.q(A_0[0].ah().ad());
				fx4.v(A_0[0].ah().af());
				fx4.u(A_0[0].ah().ae());
			}
		}
		checked
		{
			int num = A_1.e().Count - 1;
			for (int num2 = 1; num2 <= num; num2++)
			{
				fx fx5 = new fx(global::fl.g.b);
				if (num2 > 1)
				{
					throw new l("Error: Attempting to add undefined curve type (index = " + num2 + ", type = primary)");
				}
				fx2.t(fx5);
				fx5.q(A_2);
				fx5.q(A_4);
				double[] a_7 = A_1.e()[num2].a;
				double[] a_8 = A_1.e()[num2].b;
				int a_9 = A_1.e()[num2].c;
				A_5 = this;
				fx5.q(a_7, a_8, a_9, ref A_5);
				fx5.q(A_0.c);
				if (A_0.Count > 0)
				{
					fx5.q(A_0[0].ai()[0].ad());
					fx5.v(A_0[0].ai()[0].af());
					fx5.u(A_0[0].ai()[0].ae());
				}
				if (A_1.e()[num2].f > 0)
				{
					fx fx6 = new fx(global::fl.g.d);
					throw new l("Error: Attempting to add undefined curve type (index = " + num2 + ", type = secondary)");
				}
			}
			fx3 = null;
			a<fx> a10 = A_0;
			if (a0)
			{
				while (a10.Count + 1 > bb)
				{
					a10.RemoveAt(a10.Count - 1);
				}
			}
			else
			{
				a10.Clear();
			}
			a10.Insert(0, fx2);
			a10 = null;
		}
	}

	[SpecialName]
	public bool hc()
	{
		if (this.m_f1)
		{
			return bp.Count > 0;
		}
		return false;
	}

	private bool o(long A_0, ref int A_1)
	{
		A_1 = 0;
		checked
		{
			while (A_1 < bp.Count)
			{
				if (bp[A_1].a == A_0)
				{
					return true;
				}
				A_1++;
			}
			A_1 = -1;
			return false;
		}
	}

	[SpecialName]
	private bool dn()
	{
		if (bp.Count > 0)
		{
			return de() == bp.Count;
		}
		return false;
	}

	[SpecialName]
	private bool dm()
	{
		if (dk() > 0 || di() > 0)
		{
			return false;
		}
		return true;
	}

	private int dl()
	{
		int num = default(int);
		foreach (a<fx> item in bp)
		{
			if (item.r() && item[0].ah() == null && item[0].ai() == null)
			{
				num = checked(num + 1);
			}
		}
		return num;
	}

	private int dk()
	{
		int num = default(int);
		foreach (a<fx> item in bp)
		{
			if (item.r() && item.u())
			{
				num = checked(num + 1);
			}
		}
		return num;
	}

	private int dj()
	{
		int num = default(int);
		foreach (a<fx> item in bp)
		{
			if (item.s())
			{
				num = checked(num + 1);
			}
		}
		return num;
	}

	private int di()
	{
		int num = default(int);
		foreach (a<fx> item in bp)
		{
			if ((item.s() && item.u()) || (item[0].ah() != null && item.v()))
			{
				num = checked(num + 1);
			}
		}
		return num;
	}

	private int dh()
	{
		int num = default(int);
		foreach (a<fx> item in bp)
		{
			if (item.t())
			{
				num = checked(num + 1);
			}
		}
		return num;
	}

	private int dg()
	{
		int num = default(int);
		foreach (a<fx> item in bp)
		{
			if (item.t() && item.u())
			{
				num = checked(num + 1);
			}
		}
		return num;
	}

	private int df()
	{
		int num = default(int);
		foreach (a<fx> item in bp)
		{
			if ((item.t() && item.u()) || (item[0].ai() != null && item.r(0)))
			{
				num = checked(num + 1);
			}
		}
		return num;
	}

	private int de()
	{
		int num = default(int);
		foreach (a<fx> item in bp)
		{
			if (item.t() && item[0].ah() == null)
			{
				num = checked(num + 1);
			}
		}
		return num;
	}

	private bool dd()
	{
		foreach (a<fx> item in bp)
		{
			foreach (fx item2 in item)
			{
				if (item2.ah() != null && item.v())
				{
					return true;
				}
			}
		}
		return false;
	}

	private int dc()
	{
		checked
		{
			int num = default(int);
			foreach (a<fx> item in bp)
			{
				if ((item.r() || item.t()) && item.u())
				{
					num++;
				}
				if (item[0].ai() == null)
				{
					continue;
				}
				int num2 = item[0].ai().Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (item.r(num3))
					{
						num++;
					}
				}
			}
			return num;
		}
	}

	private bool db()
	{
		int num = c7();
		int num2 = c6();
		int num3 = c5();
		int num4 = c3();
		int num5 = c2();
		if (num2 > 0)
		{
			return num3 > 0 || num > 0 || num5 > 0 || num4 > 0;
		}
		if (num3 > 0 || num > 0)
		{
			return num5 > 0 || num4 > 0;
		}
		if (num4 > 0 || num5 > 0)
		{
			return num > 0;
		}
		return false;
	}

	private bool da()
	{
		int num = c7();
		int num2 = c6();
		int num3 = c5();
		int num4 = c3();
		int num5 = c2();
		if (num3 > 0 || num > 0)
		{
			return num5 == 0 && num2 == 0 && num4 == 0;
		}
		return false;
	}

	private int c9()
	{
		checked
		{
			bool flag = default(bool);
			int num3 = default(int);
			foreach (a<fx> item in bp)
			{
				if (item[0].ai() == null)
				{
					flag = false;
				}
				else
				{
					int num = item[0].ai().Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						if (item[0].ai()[num2] != null && item.r(num2))
						{
							flag = true;
							break;
						}
					}
				}
				if (item.u() || item.v() || flag)
				{
					num3++;
				}
			}
			return num3;
		}
	}

	private bool c8()
	{
		foreach (a<fx> item in bp)
		{
			foreach (fx item2 in item)
			{
				if (item2.ai() != null)
				{
					return true;
				}
			}
		}
		return false;
	}

	private int c7()
	{
		int num = 0;
		checked
		{
			int num2 = bp.Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (bp[num3][0].ah() != null && bp[num3].v())
				{
					num++;
				}
			}
			return num;
		}
	}

	private int c6()
	{
		int num = 0;
		checked
		{
			int num2 = bp.Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (bp[num3].u() && bp[num3].r())
				{
					num++;
				}
			}
			return num;
		}
	}

	private int c5()
	{
		int num = 0;
		checked
		{
			int num2 = bp.Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (bp[num3].u() && bp[num3].s())
				{
					num++;
				}
			}
			return num;
		}
	}

	private int c3()
	{
		int num = 0;
		checked
		{
			int num2 = bp.Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (bp[num3].u() && bp[num3].t())
				{
					num++;
				}
			}
			return num;
		}
	}

	private int c2()
	{
		int num = 0;
		checked
		{
			int num2 = bp.Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (bp[num3][0].ai() == null)
				{
					continue;
				}
				int num4 = bp[num3][0].ai().Count - 1;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					if (bp[num3][0].ai()[num5] != null && bp[num3].r(num5))
					{
						num++;
					}
				}
			}
			return num;
		}
	}

	private bool c1()
	{
		checked
		{
			int num = bp.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (bp[num2][0].ai() == null)
				{
					continue;
				}
				int num3 = bp[num2][0].ai().Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (bp[num2][0].ai()[num4] != null && bp[num2].r(num4))
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	private bool o(bool A_0, a<fx> A_1)
	{
		if (!A_0 || da() || !A_1.s())
		{
			if (!A_0)
			{
				if (!A_1.r() && !A_1.t())
				{
					return da();
				}
				return true;
			}
			return false;
		}
		return true;
	}

	private bool r(bool A_0)
	{
		if (!A_0 || this.m_ee != global::fl.h.b)
		{
			if (!A_0)
			{
				if (this.m_ee != global::fl.h.a && this.m_ee != global::fl.h.c)
				{
					if (this.m_ee == global::fl.h.b)
					{
						return da();
					}
					return false;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	private bool o(a<fx> A_0, long A_1, ref int A_2)
	{
		A_2 = 0;
		checked
		{
			while (A_2 < bp.Count)
			{
				if (A_0[A_2].ac() == A_1)
				{
					return true;
				}
				A_2++;
			}
			A_2 = -1;
			return false;
		}
	}

	private void o(int A_0, bool A_1, global::r.d.a.b A_2)
	{
		a<fx> a10 = bp[A_0];
		long num = a10.a;
		bool flag = false;
		if (a10.d)
		{
			this.m_dr[a10.e] = false;
		}
		int index = p(bp[A_0].b);
		checked
		{
			if (A_0 < bp.Count - 1)
			{
				this.m_fd.RemoveAt(index);
			}
			else
			{
				this.m_fd[index].a = -1;
			}
			bp.RemoveAt(A_0);
			if (bu & da())
			{
				flag = true;
			}
			bu = (dd() && !da()) || (di() > 0 && !da());
			o();
			if (this.m_c6 == A_0)
			{
				flag = true;
				if (this.m_c6 >= bp.Count)
				{
					this.m_c6 = bp.Count - 1;
				}
			}
			else if (this.m_c6 > A_0)
			{
				this.m_c6--;
			}
			if (this.m_d9 != null && this.m_ec == num)
			{
				g2();
				ao();
			}
			u();
			aq();
			if (bp.Count > 0)
			{
				if (!A_1 && flag)
				{
					a<fx> a11 = bp[this.m_c6];
					this.m_gh?.Invoke(a11.a, a11[0].ac(), A_2);
					a11 = null;
				}
				else
				{
					this.m_go?.Invoke();
				}
			}
			ap();
			hb();
		}
	}

	private int p(string A_0)
	{
		checked
		{
			int num = this.m_fd.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (Operators.CompareString(this.m_fd[num2].e, A_0, TextCompare: false) == 0)
				{
					return num2;
				}
			}
			return 0;
		}
	}

	private void o(ref a<fx> A_0)
	{
		int num = 0;
		do
		{
			if (!this.m_dr[num])
			{
				a<fx> obj = A_0;
				obj.c = this.m_ds[num];
				obj.d = true;
				obj.e = num;
				_ = null;
				this.m_dr[num] = true;
				break;
			}
			num = checked(num + 1);
		}
		while (num <= 9);
	}

	private void c0()
	{
		this.m_d0 = new Label();
		this.m_d0.AutoSize = true;
		this.m_d0.BackColor = Color.Transparent;
		this.m_d0.Cursor = Cursors.Default;
		this.m_d0.ForeColor = Color.LightGray;
		this.m_d0.Margin = new Padding(0, 0, 4, 0);
		this.m_d0.Name = "Dashed Line";
		this.m_d0.Size = new Size(293, 16);
		this.m_d0.Text = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
		this.m_d0.Visible = false;
		this.m_d0.TextAlign = ContentAlignment.BottomCenter;
		this.m_d0.MouseEnter += @as;
		this.m_d1[0] = e4();
		this.m_d1[0].AutoSize = true;
		this.m_d1[0].BackColor = Color.Transparent;
		this.m_d1[0].Cursor = Cursors.Hand;
		this.m_d1[0].ForeColor = Color.Black;
		this.m_d1[0].Margin = new Padding(4, 0, 4, 0);
		this.m_d1[0].Name = "mYTitleLabel";
		this.m_d1[0].Size = new Size(293, 16);
		this.m_d1[0].Text = "SiO2 on Si Spectrum taken 01/31/2007 12:34 PM ";
		this.m_d1[0].Visible = false;
		this.m_d2[0] = false;
		this.m_d1[0].TextAlign = ContentAlignment.MiddleCenter;
		this.m_d1[1] = e5();
		this.m_d1[1].AutoSize = true;
		this.m_d1[1].BackColor = Color.Transparent;
		this.m_d1[1].Cursor = Cursors.Hand;
		this.m_d1[1].ForeColor = Color.Black;
		this.m_d1[1].Margin = new Padding(4, 0, 4, 0);
		this.m_d1[1].Name = "mY2TitleLabel";
		this.m_d1[1].Size = new Size(293, 16);
		this.m_d1[1].Text = "SiO2 on Si Spectrum taken 01/31/2007 12:34 PM ";
		this.m_d1[1].Visible = false;
		this.m_d2[1] = false;
		this.m_d1[1].TextAlign = ContentAlignment.MiddleCenter;
		this.m_d1[2] = e6();
		this.m_d1[2].AutoSize = true;
		this.m_d1[2].BackColor = Color.Transparent;
		this.m_d1[2].Cursor = Cursors.Hand;
		this.m_d1[2].ForeColor = Color.Black;
		this.m_d1[2].Margin = new Padding(4, 0, 4, 0);
		this.m_d1[2].Name = "mY1stAddPrimTitleLabel";
		this.m_d1[2].Size = new Size(293, 16);
		this.m_d1[2].Text = "SiO2 on Si Spectrum taken 01/31/2007 12:34 PM ";
		this.m_d1[2].Visible = false;
		this.m_d2[2] = false;
		this.m_d1[2].TextAlign = ContentAlignment.MiddleCenter;
		string A_ = "GraphLegendTypeToolTip";
		string caption = hu.a(ref A_);
		d3().SetToolTip(this.m_d1[0], caption);
		d3().SetToolTip(this.m_d1[1], caption);
		d3().SetToolTip(this.m_d1[2], caption);
		d5().Controls[0].Controls.Add(this.m_d0);
		d5().Controls[0].Controls.Add(this.m_d1[0]);
		d5().Controls[0].Controls.Add(this.m_d1[1]);
		d5().Controls[0].Controls.Add(this.m_d1[2]);
	}

	[SpecialName]
	private bool b7()
	{
		if (bp != null && bp.Count > 0)
		{
			return this.m_dq;
		}
		return false;
	}

	[SpecialName]
	private bool a5()
	{
		if (this.m_c6 >= 0 && this.m_c6 < bp.Count)
		{
			return this.m_d9 != null && ((dk() > 0 && this.m_ee == global::fl.h.a) || (di() > 0 && (this.m_ee == global::fl.h.b || this.m_d9.ah() != null)) || (df() > 0 && (this.m_ee == global::fl.h.c || this.m_d9.ai() != null)));
		}
		return this.m_d9 != null;
	}

	[SpecialName]
	private bool a2()
	{
		if (this.m_d8)
		{
			return a5();
		}
		return false;
	}

	[SpecialName]
	private bool at()
	{
		checked
		{
			int num = bp.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (!bp[num2][0].t())
				{
					return false;
				}
			}
			return true;
		}
	}

	private void o(Panel A_0)
	{
		if (base.Width <= 0 || base.Height <= 0 || !a2())
		{
			return;
		}
		checked
		{
			Panel panel;
			bool flag;
			bool flag2;
			if (A_0 == eh())
			{
				panel = d4();
				flag = eh().Width - ej().Width > this.m_c5;
				flag2 = d4().Width - d6().Width > c4;
			}
			else
			{
				A_0 = d4();
				panel = eh();
				flag2 = eh().Width - ej().Width > this.m_c5;
				flag = d4().Width - d6().Width > c4;
			}
			int num = (flag ? 5 : 0);
			Panel panel2 = A_0;
			Rectangle rectangle = new Rectangle(panel2.Left + num - 0, panel2.Top + num - 0, panel2.Width - 2 * num + 0, panel2.Height - 2 * num + 0);
			panel2 = null;
			int num2 = (flag2 ? 5 : 0);
			Panel panel3 = panel;
			Rectangle rectangle2 = new Rectangle(panel3.Left + num2, panel3.Top + num2, panel3.Width - 2 * num2, panel3.Height - 2 * num2);
			panel3 = null;
			Rectangle rectangle3 = Rectangle.Intersect(rectangle, rectangle2);
			if (rectangle3.Width <= 0 || rectangle3.Height <= 0)
			{
				return;
			}
			int num3 = Math.Min(panel.Width, A_0.Width);
			int num4 = Math.Min(panel.Height, A_0.Height);
			if ((double)rectangle3.Width / (double)num3 < (double)rectangle3.Height / (double)num4)
			{
				int num5 = A_0.Left;
				int num6;
				if (panel.Left + unchecked(panel.Width / 2) < num5 + unchecked(A_0.Width / 2))
				{
					num6 = num5 + num - panel.Width + num2 - 0;
					Rectangle rectangle4 = fw();
					if (num6 + num2 < rectangle4.Left)
					{
						num6 = rectangle4.Left - num2;
						num5 = num6 + panel.Width - num2 - num + 0;
						if (num5 + A_0.Width - num > rectangle4.Right)
						{
							num5 = rectangle4.Right + num - A_0.Width;
						}
					}
				}
				else
				{
					num6 = A_0.Right - num - num2 + 0;
					Rectangle rectangle5 = fw();
					if (num6 + panel.Width - num2 > rectangle5.Right)
					{
						num6 = rectangle5.Right - panel.Width + num2;
						num5 = num6 - A_0.Width + num - 0;
						if (num5 + num < rectangle5.Left)
						{
							num5 = rectangle5.Left - num;
						}
					}
				}
				panel.Left = num6;
				A_0.Left = num5;
				return;
			}
			int num7 = A_0.Top;
			int num8;
			if (panel.Top + unchecked(panel.Height / 2) < num7 + unchecked(A_0.Height / 2))
			{
				num8 = num7 + num - (panel.Height - num2) - 0;
				Rectangle rectangle6 = fw();
				if (num8 + num2 < rectangle6.Top)
				{
					num8 = rectangle6.Top - num2;
					num7 = num8 + panel.Height - num2 - num + 0;
					if (num7 + A_0.Height - num > rectangle6.Bottom)
					{
						num7 = rectangle6.Bottom + num - A_0.Height;
					}
				}
			}
			else
			{
				num8 = A_0.Bottom - num - num2 + 0;
				Rectangle rectangle7 = fw();
				if (num8 + panel.Height - num2 > rectangle7.Bottom)
				{
					num8 = rectangle7.Bottom - panel.Height + num2;
					num7 = num8 - A_0.Height + num - 0;
					if (num7 + num < rectangle7.Top)
					{
						num7 = rectangle7.Top - num;
					}
				}
			}
			panel.Top = num8;
			A_0.Top = num7;
		}
	}

	private void p(Panel A_0, k A_1)
	{
		checked
		{
			if (A_0.Visible && base.Width > 0 && base.Height > 0)
			{
				Rectangle rectangle = fw();
				int num = (int)Math.Round(A_1.b * (double)rectangle.Width) + rectangle.Left;
				if (num + unchecked(A_0.Width / 2) + 10 > rectangle.Right)
				{
					num = rectangle.Right - unchecked(A_0.Width / 2) - 10;
				}
				else if (num < rectangle.Left + unchecked(A_0.Width / 2))
				{
					num = rectangle.Left + unchecked(A_0.Width / 2);
				}
				int num2 = (int)Math.Round(A_1.c * (double)rectangle.Height) + rectangle.Top;
				if (num2 + unchecked(A_0.Height / 2) + 10 > rectangle.Bottom)
				{
					num2 = rectangle.Bottom - unchecked(A_0.Height / 2) - 10;
				}
				else if (num2 < rectangle.Top + unchecked(A_0.Height / 2))
				{
					num2 = rectangle.Top + unchecked(A_0.Height / 2);
				}
				A_0.Location = new Point(num - unchecked(A_0.Width / 2), num2 - unchecked(A_0.Height / 2));
				if (!global::e.a().AutoPositionLegends)
				{
					o((Panel)null);
					o(A_0, A_1);
				}
			}
		}
	}

	private void o(Label A_0, bool A_1, bool A_2, bool A_3)
	{
		Color backColor = Color.FromArgb(255, 234, 179);
		Color backColor2 = Color.FromArgb(255, 199, 60);
		if (A_3 || A_1 || A_2)
		{
			if (A_3)
			{
				if (global::e.a().GraphBackColor == 0)
				{
					A_0.ForeColor = Color.Gray;
				}
				else
				{
					A_0.ForeColor = Color.FromArgb(100, 100, 100);
				}
				A_0.BackColor = Color.Transparent;
			}
			else
			{
				A_0.ForeColor = Color.Black;
				if (A_1)
				{
					A_0.BackColor = backColor;
				}
				else if (A_2)
				{
					A_0.BackColor = backColor2;
				}
			}
		}
		else
		{
			A_0.BackColor = Color.Transparent;
			if (global::e.a().GraphBackColor == 0)
			{
				A_0.ForeColor = Color.Black;
			}
			else
			{
				A_0.ForeColor = Color.LightGray;
			}
		}
		if (A_3)
		{
			A_0.Cursor = Cursors.Default;
		}
		else
		{
			A_0.Cursor = Cursors.Hand;
		}
	}

	private void @as()
	{
		if (this.m_c6 >= 0 && checked(bp.Count - 1) >= this.m_c6 && !da() && !dm())
		{
			bool flag = bp[this.m_c6].s();
			bool flag2 = bp[this.m_c6].t();
			o(e4(), this.m_f1 && dq() && !this.m_f3, dq() && this.m_f3, flag || flag2);
			o(e5(), this.m_f1 && dp() && !this.m_f3, dp() && this.m_f3, bp[this.m_c6][0].ah() == null && !flag);
			o(e6(), this.m_f1 && @do() && !this.m_f3, @do() && this.m_f3, bp[this.m_c6][0].ai() == null && !flag2);
		}
	}

	private void ar()
	{
		if (base.ClientSize.Width > 0 && base.ClientSize.Height > 0 && (this.m_el == null || this.m_el.Width != base.ClientSize.Width || this.m_el.Height != base.ClientSize.Height))
		{
			this.m_el = new Bitmap(base.ClientSize.Width, base.ClientSize.Height);
		}
		r(Graphics.FromImage(this.m_el), false);
		o(d4(), this.m_c2);
		o(eh(), this.m_c3);
	}

	private void o(Panel A_0, k A_1)
	{
		Rectangle rectangle = fw();
		if ((rectangle.Width > 0) & (rectangle.Height > 0))
		{
			A_1.a.Width = rectangle.Width;
			A_1.a.Height = rectangle.Height;
			A_1.a.Location = new Point(rectangle.Left, rectangle.Top);
		}
		k k2 = A_1;
		A_1.b = ((double)A_0.Left + (double)A_0.Width / 2.0 - (double)k2.a.Left) / (double)k2.a.Width;
		A_1.c = ((double)A_0.Top + (double)A_0.Height / 2.0 - (double)k2.a.Top) / (double)k2.a.Height;
		k2 = null;
	}

	private void aq()
	{
		bool flag = false;
		bool flag2 = false;
		int num = 16;
		checked
		{
			if (this.m_dq && bp.Count > 0)
			{
				Color color = ((global::e.a().GraphBackColor != 0) ? Color.Gray : Color.Gainsboro);
				if (bp.Count > 0 && db())
				{
					this.m_d0.Visible = true;
					if (c6() > 0)
					{
						if (Operators.CompareString(this.m_d1[0].Text, "-------------- " + bg[0], TextCompare: false) != 0)
						{
							this.m_d1[0].Text = "-------------- " + bg[0];
							flag = true;
						}
						if (!this.m_d2[0])
						{
							flag2 = true;
						}
						this.m_d1[0].Visible = true;
					}
					else
					{
						if (this.m_d2[0])
						{
							flag2 = true;
						}
						this.m_d1[0].Visible = false;
						this.m_d1[0].Text = string.Empty;
					}
					if (bu || da() || c7() > 0)
					{
						if (Operators.CompareString(this.m_d1[1].Text, "---- ---- ---- " + bg[1], TextCompare: false) != 0)
						{
							this.m_d1[1].Text = "---- ---- ---- " + bg[1];
							flag = true;
						}
						if (!this.m_d2[1])
						{
							flag2 = true;
						}
						this.m_d1[1].Visible = true;
					}
					else
					{
						if (this.m_d2[1])
						{
							flag2 = true;
						}
						this.m_d1[1].Visible = false;
						this.m_d1[1].Text = string.Empty;
					}
					if (c1() || c3() > 0)
					{
						if (Operators.CompareString(this.m_d1[2].Text, "-- -- -- -- --  " + bg[2], TextCompare: false) != 0)
						{
							this.m_d1[2].Text = "-- -- -- -- --  " + bg[2];
							flag = true;
						}
						if (!this.m_d2[2])
						{
							flag2 = true;
						}
						this.m_d1[2].Visible = true;
					}
					else
					{
						if (this.m_d2[2])
						{
							flag2 = true;
						}
						this.m_d1[2].Visible = false;
						this.m_d1[2].Text = string.Empty;
					}
				}
				else
				{
					flag2 = true;
					this.m_d1[0].Visible = false;
					this.m_d1[0].Text = string.Empty;
					this.m_d1[1].Visible = false;
					this.m_d1[1].Text = string.Empty;
					this.m_d1[2].Visible = false;
					this.m_d1[2].Text = string.Empty;
				}
				int num2 = bp.Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					Label obj = this.m_dt[num3];
					a<fx> a10 = bp[num3];
					Label label = obj;
					if (Operators.CompareString(label.Text, a10.b, TextCompare: false) != 0)
					{
						label.Text = a10.b;
						flag = true;
					}
					if (label.ForeColor != a10.c)
					{
						label.ForeColor = a10.c;
					}
					if (num3 == this.m_c6 && label.BackColor != color && bp.Count > 1 && !this.m_eh)
					{
						label.BackColor = color;
					}
					else if ((bp.Count <= 1 || num3 != this.m_c6) && label.BackColor != Color.Transparent)
					{
						label.BackColor = Color.Transparent;
					}
					if (!label.Visible)
					{
						flag2 = true;
					}
					label.Visible = true;
					if (num3 == this.m_c6)
					{
						this.m_c7 = label.Text;
					}
					label = null;
				}
				for (int num3 = bp.Count; num3 <= 9; num3++)
				{
					Label obj2 = this.m_dt[num3];
					if (obj2.Visible)
					{
						flag2 = true;
					}
					obj2.Visible = false;
					_ = null;
				}
				if (!flag && !flag2)
				{
					return;
				}
				int count = bp.Count;
				int num4 = 0;
				if (this.m_d0 != null)
				{
					this.m_d0.Location = new Point(this.m_dt[0].Location.X, count * num + this.m_dt[0].Location.Y);
					if (!string.IsNullOrEmpty(this.m_d1[0].Text))
					{
						this.m_d1[0].Location = new Point(this.m_dt[0].Location.X, (count + 1) * num + this.m_dt[0].Location.Y);
						num4++;
					}
					if (!string.IsNullOrEmpty(this.m_d1[1].Text))
					{
						this.m_d1[1].Location = new Point(this.m_dt[0].Location.X, (count + 1 + num4) * num + this.m_dt[0].Location.Y);
						num4++;
					}
					if (!string.IsNullOrEmpty(this.m_d1[2].Text))
					{
						this.m_d1[2].Location = new Point(this.m_dt[0].Location.X, (count + 1 + num4) * num + this.m_dt[0].Location.Y);
					}
				}
				Panel A_ = d4();
				Panel A_2 = d5();
				o(ref A_, ref A_2, this.m_dt, this.m_dq, bp.Count, this.m_c2);
				q(A_2);
				p(A_);
				if (!global::e.a().AutoPositionLegends)
				{
					o(d4());
				}
				else
				{
					this.m_e5 = true;
				}
				d5().Refresh();
			}
			else
			{
				d4().Visible = false;
			}
		}
	}

	private void ap()
	{
		if (this.m_c6 <= -1 || bp.Count <= 0)
		{
			return;
		}
		a<fx> a10 = bp[this.m_c6];
		if (hc() && this.m_f3 && this.m_f4 != a10.g)
		{
			switch (this.m_f4)
			{
			case global::fl.h.a:
			case global::fl.h.c:
				this.m_f4 = a10.g;
				break;
			case global::fl.h.b:
				if (bp[this.m_c6][0].ah() == null)
				{
					this.m_f4 = a10.g;
				}
				break;
			}
		}
		@as();
	}

	private void ao()
	{
		bool flag = false;
		bool flag2 = false;
		if (a2())
		{
			Label label = el();
			if (Operators.CompareString(label.Text, this.m_ea, TextCompare: false) != 0)
			{
				label.Text = this.m_ea;
				flag = true;
			}
			if (label.ForeColor != this.m_d9.q())
			{
				label.ForeColor = this.m_d9.q();
			}
			if (!label.Visible)
			{
				flag2 = true;
			}
			label.Visible = true;
			label = null;
			if (flag || flag2)
			{
				Panel A_ = eh();
				Panel A_2 = ei();
				o(ref A_, ref A_2, this.m_du, this.m_d8, 1, this.m_c3);
				t(A_2);
				s(A_);
				if (!global::e.a().AutoPositionLegends)
				{
					o(eh());
				}
				else
				{
					this.m_e5 = true;
				}
			}
		}
		else
		{
			eh().Visible = false;
		}
	}

	private void o(Label[] A_0, int A_1, ref Size A_2)
	{
		bool flag = false;
		checked
		{
			int num = A_1 - 1;
			A_2 = new Size(0, 0);
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				Size size = TextRenderer.MeasureText(A_0[num3].Text, A_0[num3].Font, new Size(0, 0), TextFormatFlags.NoPrefix);
				size.Width++;
				if (size.Width > A_2.Width)
				{
					A_2 = size;
					flag = true;
				}
			}
			if (flag)
			{
				int num4 = num;
				for (int num3 = 0; num3 <= num4; num3++)
				{
					A_0[num3].Width = A_2.Width;
				}
			}
		}
	}

	private void an()
	{
		if (!f4())
		{
			if (string.IsNullOrEmpty(this.m_gw))
			{
				string A_ = "GraphLegendDeleteCurve";
				this.m_gw = hu.a(ref A_);
			}
			dx().Text = string.Format(this.m_gw, bt);
		}
		dx().Visible = !f4();
		if (!f6())
		{
			if (string.IsNullOrEmpty(this.m_gx))
			{
				string A_ = "GraphLegendRenameCurve";
				this.m_gx = hu.a(ref A_);
			}
			if (hu.b(this.m_gx) == 1)
			{
				dz().Text = string.Format(this.m_gx, bt);
			}
			else
			{
				dz().Text = string.Format(this.m_gx);
			}
		}
		dz().Visible = !f6();
		if (string.IsNullOrEmpty(global::fl.m_f6))
		{
			string A_ = "GraphLegendSaveCurve";
			global::fl.m_f6 = hu.a(ref A_);
		}
		d0().Text = string.Format(global::fl.m_f6, bt);
		if (!f5())
		{
			if (string.IsNullOrEmpty(this.m_gy))
			{
				string A_ = "GraphLegendOpenCurve";
				this.m_gy = hu.a(ref A_);
			}
			dy().Text = string.Format(this.m_gy, bt);
		}
		dy().Visible = !f5();
		en().Visible = !f8();
	}

	private void am()
	{
		if (string.IsNullOrEmpty(global::fl.m_f6))
		{
			string A_ = "GraphLegendSaveCurve";
			global::fl.m_f6 = hu.a(ref A_);
		}
		d2().Text = string.Format(global::fl.m_f6, this.m_eb);
	}

	private void o(ref Panel A_0, ref Panel A_1, Label[] A_2, bool A_3, int A_4, k A_5)
	{
		checked
		{
			if (A_3 && A_4 > 0)
			{
				bool flag = c2() > 0;
				Size A_6 = default(Size);
				o(A_2, A_4, ref A_6);
				int num;
				int num2;
				if (db() && A_1 == d5() && this.m_d0 != null)
				{
					num = 3;
					if ((c2() > 0 || c3() > 0) && c6() > 0 && (bu || c7() > 0))
					{
						num++;
					}
					Size A_7 = default(Size);
					o(this.m_d1, this.m_d1.Length, ref A_7);
					num2 = ((A_7.Width <= A_6.Width) ? A_6.Width : A_7.Width);
				}
				else
				{
					num = 0;
					num2 = A_6.Width;
				}
				A_1.Height = A_1.Margin.Top + (A_4 + num) * A_2[0].Height + A_1.Margin.Bottom + 3;
				A_1.Width = 0 + num2 + 0;
				if (this.m_d5 || this.m_d6)
				{
					A_0.Height = A_1.Height + 10;
					A_0.Width = A_1.Width + 10;
				}
				else
				{
					A_0.Height = A_1.Height;
					A_0.Width = A_1.Width;
				}
				if ((bu || flag) && A_1 == d5() && this.m_d0 != null)
				{
					int num3 = ((this.m_d1[1].Width <= this.m_d1[0].Width || !bu) ? this.m_d1[0].Width : this.m_d1[1].Width);
					if (this.m_d1[2].Width > num3 && (flag || dg() > 0))
					{
						num3 = this.m_d1[2].Width;
					}
					this.m_d1[0].Left = (int)Math.Round((double)(A_1.Width - num3) / 2.0);
					this.m_d1[1].Left = (int)Math.Round((double)(A_1.Width - num3) / 2.0);
					this.m_d1[2].Left = (int)Math.Round((double)(A_1.Width - num3) / 2.0);
					this.m_d0.Left = -5;
				}
				if (!A_1.Visible)
				{
					A_0.Visible = true;
				}
				o(A_0, A_5);
			}
			else
			{
				A_0.Visible = false;
			}
		}
	}

	private void al()
	{
		if (global::e.a().AutoPositionLegends && bp != null && bp.Count > 0)
		{
			this.m_e5 = true;
			Invalidate();
		}
	}

	private void p(Graphics A_0)
	{
		Color color = SystemColors.Control;
		if (base.ParentForm != null)
		{
			color = base.ParentForm.BackColor;
		}
		A_0.Clear(color);
		g3();
	}

	private void r(Graphics A_0, bool A_1 = false)
	{
		Font font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point);
		cg = checked((short)Math.Round(A_0.MeasureString("x", font).Width));
		SizeF sizeF = A_0.MeasureString("x4000x", font);
		ce = sizeF.Height;
		if (this.m_em != null && this.m_em.av())
		{
			cf = (float)((double)sizeF.Width + (double)ce * 1.1);
		}
		else
		{
			cf = sizeF.Width;
		}
		font.Dispose();
		p(A_1);
	}

	private Color o(Color A_0, Color A_1, double A_2)
	{
		float num = (float)A_2;
		float num2 = 1f - num;
		checked
		{
			return Color.FromArgb((int)Math.Round(unchecked((float)(int)A_0.R * num + (float)(int)A_1.R * num2)), (int)Math.Round(unchecked((float)(int)A_0.G * num + (float)(int)A_1.G * num2)), (int)Math.Round(unchecked((float)(int)A_0.B * num + (float)(int)A_1.B * num2)));
		}
	}

	private float q(bool A_0)
	{
		if (A_0)
		{
			return 0.2f;
		}
		return 0.4f;
	}

	private short ak()
	{
		return checked((short)Math.Round((float)base.Height - ce));
	}

	private short aj()
	{
		return checked((short)Math.Round((float)ak() - 2.5f * ce));
	}

	private short ai()
	{
		return checked((short)Math.Round((double)base.Width - 1.5 * (double)cf));
	}

	private short ah()
	{
		return checked((short)Math.Round((float)base.Width - 2f * cf));
	}

	private void p(bool A_0 = false)
	{
		checked
		{
			this.m_b7 = (short)Math.Round(1.1 * (double)cf);
			if (be)
			{
				b8 = (short)Math.Round(ce / 2f);
			}
			else
			{
				b8 = (short)Math.Round(ce);
			}
			if (bu)
			{
				b9 = ah();
			}
			else
			{
				b9 = ai();
			}
			if (f3())
			{
				ca = aj();
			}
			else
			{
				ca = ak();
			}
			if (A_0)
			{
				if (bu)
				{
					b6 = (short)Math.Round((float)cp - 3f * cf + (float)cb);
				}
				else
				{
					b6 = (short)Math.Round((float)cp - 2f * cf);
				}
				b2 = (short)Math.Round((float)co - ce);
				if (f3())
				{
					ref short reference = ref b2;
					reference = (short)unchecked(reference - checked((short)Math.Round(2.5f * ce)));
				}
				b3 = (short)unchecked(cn + this.m_b7);
				b5 = (short)unchecked(cm + b8);
			}
			else
			{
				b6 = b9;
				b2 = ca;
				b3 = this.m_b7;
				b5 = b8;
			}
			b4 = (short)unchecked(b3 + b6);
			b1 = (short)unchecked(b5 + b2);
			this.m_fy.l(b1 - 10);
		}
	}

	private void q(Graphics A_0, bool A_1 = false)
	{
		Font font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point);
		SolidBrush solidBrush = new SolidBrush(Color.Black);
		bool num = (global::e.a().GraphBackColor == 0) | A_1;
		r(A_0, A_1);
		checked
		{
			Rectangle rect = default(Rectangle);
			rect.X = b3 - 2;
			rect.Y = b5 - 2;
			rect.Width = b6 + 4;
			rect.Height = b2 + 4;
			if (num)
			{
				A_0.FillRectangle(Brushes.White, rect);
				A_0.DrawRectangle(Pens.Black, rect);
			}
			else
			{
				A_0.FillRectangle(Brushes.Black, rect);
				A_0.DrawRectangle(Pens.White, rect);
			}
			if (f3())
			{
				SizeF sizeF = A_0.MeasureString(bf, font);
				A_0.DrawString(x: (float)((double)b3 + 0.5 * (double)((float)b6 - sizeF.Width)), y: (!A_1) ? ((float)base.Height - sizeF.Height) : ((float)cl - sizeF.Height), s: bf, font: font, brush: solidBrush);
				bx = bf;
			}
			rect.X = b3 - 1;
			rect.Y = b5 - 1;
			rect.Width = b6 + 2;
			rect.Height = b2 + 2;
			if (num)
			{
				A_0.DrawRectangle(Pens.Black, rect);
			}
			else
			{
				A_0.DrawRectangle(Pens.White, rect);
			}
			font.Dispose();
			solidBrush.Dispose();
		}
	}

	private void o(Graphics A_0)
	{
		Rectangle rectangle = default(Rectangle);
		checked
		{
			this.m_fy.l(b1 - 10);
			this.m_fy.p(5);
			Rectangle rectangle2 = this.m_fy.l();
			A_0.FillRectangle(rect: new Rectangle(rectangle2.X, rectangle2.Y, rectangle2.Width + 1, rectangle2.Height), brush: new SolidBrush(Color.FromArgb(90, 88, 88, 88)));
		}
	}

	private void o(Panel A_0, bool A_1, Graphics A_2, ref Rectangle A_3)
	{
		Font font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point);
		SolidBrush solidBrush = new SolidBrush(Color.Black);
		SolidBrush solidBrush2 = new SolidBrush(Color.White);
		string text = "";
		Font font2 = null;
		bool flag = false;
		if (!A_0.Visible)
		{
			return;
		}
		checked
		{
			float num = (float)((double)(A_0.Left + 4 - this.m_b7) / (double)b9);
			float num2 = (float)((double)(A_0.Top - b8) / (double)ca);
			if (A_0 == d4() || !global::e.a().AutoPositionLegends)
			{
				A_3.X = (short)Math.Round(num * (float)b6 + (float)b3);
				A_3.Y = (short)unchecked(checked((short)Math.Round(num2 * (float)b2)) + b5);
			}
			float num4 = default(float);
			float num5 = default(float);
			foreach (Control control3 in A_0.Controls[0].Controls[0].Controls)
			{
				if (!(control3 is Label) || !control3.Visible)
				{
					continue;
				}
				if (cq)
				{
					if (Operators.CompareString(control3.Text, this.m_c7, TextCompare: false) == 0 || A_0 == eh())
					{
						float num3 = A_2.MeasureString(control3.Text, control3.Font).Width;
						if (num3 > num4)
						{
							num4 = num3;
						}
						num5 = A_2.MeasureString(control3.Text, control3.Font).Height;
					}
					continue;
				}
				if (Operators.CompareString(control3.Text, "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", TextCompare: false) == 0)
				{
					flag = true;
					font2 = control3.Font;
				}
				else
				{
					float num3 = A_2.MeasureString(control3.Text, control3.Font).Width;
					if (num3 > num4)
					{
						num4 = num3;
					}
				}
				num5 = A_0.Height - 2;
			}
			A_3.Width = (int)Math.Round(num4);
			if (A_3.Right > b4)
			{
				A_3.X = b4 - A_3.Width;
				if (A_3.X < b3)
				{
					A_3.X = b3;
				}
			}
			if (A_0 == d4() || !global::e.a().AutoPositionLegends)
			{
				A_3.Height = (int)Math.Round(num5);
				if (A_3.Bottom > b1)
				{
					A_3.Y = b1 - A_3.Height;
					if (A_3.Y < b5)
					{
						A_3.Y = b5;
					}
				}
			}
			else
			{
				A_3.Y = (short)(A_3.Bottom + 1);
				A_3.Height = (int)Math.Round(num5);
			}
			Rectangle rect = default(Rectangle);
			rect.X = A_3.X + 1;
			rect.Y = A_3.Y + 1;
			rect.Width = A_3.Width - 2;
			rect.Height = A_3.Height - 2;
			if (flag)
			{
				text = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
				while (text.Length > 0 && A_2.MeasureString(text, font2).Width > (float)rect.Width)
				{
					text = text.Substring(1);
				}
			}
			A_2.FillRectangle(Brushes.White, A_3);
			A_2.DrawRectangle(Pens.Black, A_3);
			A_2.FillRectangle(Brushes.White, rect);
			A_2.DrawRectangle(Pens.White, rect);
			foreach (Control control4 in A_0.Controls[0].Controls[0].Controls)
			{
				if (!((control4 is Label) & control4.Visible))
				{
					continue;
				}
				solidBrush2 = new SolidBrush(control4.ForeColor);
				string left;
				float num6;
				if (Operators.CompareString(control4.Text, "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", TextCompare: false) == 0)
				{
					left = text;
					num6 = A_2.MeasureString("-", font2).Width;
				}
				else
				{
					left = control4.Text;
					num6 = 0f;
				}
				if (cq || bp.Count == 1)
				{
					if (Operators.CompareString(left, this.m_c7, TextCompare: false) == 0 || A_0 == eh())
					{
						A_2.DrawString(left, control4.Font, solidBrush2, (float)(A_3.Left + control4.Location.X) + num6, A_3.Top);
					}
					continue;
				}
				if (!this.m_eh && A_1 && Operators.CompareString(left, this.m_c7, TextCompare: false) == 0)
				{
					A_2.FillRectangle(Brushes.Gainsboro, A_3.Left + control4.Location.X + 1, A_3.Top + control4.Location.Y + 1, rect.Width, control4.Height);
				}
				A_2.DrawString(left, control4.Font, solidBrush2, (float)(A_3.Left + control4.Location.X) + num6, A_3.Top + control4.Location.Y);
			}
			font.Dispose();
			solidBrush.Dispose();
			solidBrush2.Dispose();
		}
	}

	private void ag()
	{
		if (global::e.a().GraphBackColor == 0)
		{
			d6().BackColor = Color.White;
			d6().BorderStyle = BorderStyle.None;
			d6().Margin = new Padding(2);
			ej().BackColor = Color.White;
			ej().BorderStyle = BorderStyle.None;
			ej().Margin = new Padding(2);
		}
		else
		{
			d6().BackColor = Color.Black;
			d6().BorderStyle = BorderStyle.FixedSingle;
			d6().Margin = new Padding(1);
			ej().BackColor = Color.Black;
			ej().BorderStyle = BorderStyle.FixedSingle;
			ej().Margin = new Padding(1);
		}
	}

	private void p(Graphics A_0, bool A_1)
	{
		if (this.m_em != null)
		{
			this.m_em.at(false);
			this.m_em.a0();
			this.m_em.au(false);
			this.m_em.a1();
		}
		if (this.m_em != null && (this.m_em.ao() || this.m_em.ap() || this.m_em.aq() || this.m_em.ar() || this.m_em.a2().ar() || this.m_em.a2().@as()))
		{
			g6();
		}
		if (this.m_e5)
		{
			ds();
			this.m_e5 = false;
		}
		int A_2 = default(int);
		int A_3 = default(int);
		if (this.m_em != null && this.m_em.av())
		{
			o(A_0: false, A_0, A_1, A_3: false, ref A_2);
			if (bu)
			{
				o(A_0: false, A_0, A_1, A_3: true, ref A_3);
			}
		}
		else
		{
			o(A_0, bu);
		}
		if (bc)
		{
			o(he(), A_0, A_2);
			if (bu)
			{
				o(hh(), A_0, A_1, A_3);
			}
		}
		if (ba)
		{
			o(A_0: false, A_0, A_1);
		}
		if (this.m_em != null && this.m_em.av())
		{
			o(A_0: true, A_0, A_1);
			int A_4 = 0;
			o(A_0: true, A_0, A_1, A_3: false, ref A_4);
			if (bu)
			{
				A_4 = 0;
				o(A_0: true, A_0, A_1, A_3: true, ref A_4);
			}
		}
	}

	public string hd()
	{
		if (bp == null || bp.Count == 0)
		{
			return bg[0];
		}
		if (c9() > 0)
		{
			if (da() && bp != null && bp.Count > 0)
			{
				return bg[1];
			}
			if (bp != null && bp.Count > 0 && dk() == 0)
			{
				return bg[2];
			}
			return bg[0];
		}
		if (checked(bp.Count - dj() - dh()) > 0)
		{
			return bg[0];
		}
		if (dh() > 0)
		{
			return bg[2];
		}
		return bg[1];
	}

	public string he()
	{
		return o(hd());
	}

	private string o(string A_0)
	{
		if (this.m_em != null && this.m_em.at() && fm())
		{
			A_0 += " (%)";
		}
		return A_0;
	}

	public string hf()
	{
		return hd() + " (%)";
	}

	public string hg()
	{
		return bg[1];
	}

	public string hh()
	{
		return o(hg());
	}

	public string hi()
	{
		return hg() + " (%)";
	}

	private void o(bool A_0, Graphics A_1, bool A_2)
	{
		Font font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point);
		SolidBrush brush = new SolidBrush(Color.Black);
		char c10 = Conversions.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
		double num;
		double num2;
		if (this.m_em != null)
		{
			num = this.m_em.a2().aq();
			num2 = this.m_em.a2().ap();
		}
		else
		{
			num2 = 0.0;
			num = 1.0;
		}
		double A_3 = default(double);
		double A_4 = default(double);
		o(num2, num, 10, ref A_3, ref A_4);
		double num3 = num - num2;
		if (num3 > 3.4028234663852886E+38)
		{
			num3 = 3.4028234663852886E+38;
		}
		bi = num3;
		if (num3 <= 0.0)
		{
			return;
		}
		float num4 = (float)(A_4 * (double)b6 / num3);
		if (num4 <= 0f)
		{
			return;
		}
		int num5 = 0;
		bool flag = A_0 && (global::e.a().GraphBackColor == 0 || A_2);
		checked
		{
			float num6;
			do
			{
				num6 = (float)((double)b3 + (double)b6 * (A_3 - num2) / num3 + (double)(num4 * (float)num5));
				if (A_0)
				{
					if (flag)
					{
						A_1.DrawLine(Pens.Gray, num6, b1 - 1, num6, b5);
					}
					else
					{
						A_1.DrawLine(new Pen(Color.FromArgb(255, 64, 64, 64)), num6, b1 - 1, num6, b5);
					}
				}
				else
				{
					float y2 = b1;
					float y3 = (float)((double)b1 + 0.5 * (double)ce);
					A_1.DrawLine(Pens.Black, num6, y2, num6, y3);
					string text = Strings.Format(A_3 + A_4 * (double)num5, "0.#####");
					text = text.TrimEnd(c10);
					float num7 = (float)((double)num6 - (double)A_1.MeasureString(text, font).Width * 0.5);
					A_1.DrawString(text, font, brush, num7, y3);
				}
				num5++;
			}
			while (!(Conversion.Int(num6 + num4) > (float)(short)unchecked(b3 + b6)));
		}
	}

	private void o(string A_0, Graphics A_1, int A_2)
	{
		Font font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point);
		SolidBrush solidBrush = new SolidBrush(Color.Black);
		if (hc() && dp())
		{
			Color color = o(solidBrush.Color, SystemColors.Control, q(A_0: true));
			solidBrush.Color = color;
		}
		SizeF sizeF = A_1.MeasureString(A_0, font);
		checked
		{
			A_1.TranslateTransform((float)b3 - af() - (float)A_2 - (float)(int)Math.Round(1.5 * (double)sizeF.Height), (float)(0.5 * (double)((float)(short)unchecked(b5 + b1) + sizeF.Width)));
			A_1.RotateTransform(270f);
			A_1.DrawString(A_0, font, solidBrush, 0f, 0f);
			A_1.ResetTransform();
			by = A_0;
			font.Dispose();
			solidBrush.Dispose();
		}
	}

	private void o(string A_0, Graphics A_1, bool A_2, int A_3)
	{
		Font font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point);
		SolidBrush solidBrush = new SolidBrush(Color.Black);
		if (hc() && (dq() || @do()))
		{
			Color color = o(solidBrush.Color, SystemColors.Control, q(A_0: true));
			solidBrush.Color = color;
		}
		SizeF sizeF = A_1.MeasureString(A_0, font);
		checked
		{
			if (A_2)
			{
				A_1.TranslateTransform(cp + cb, (float)(0.5 * (double)((float)(short)unchecked(b5 + b1) - sizeF.Width)));
			}
			else
			{
				A_1.TranslateTransform((float)((double)(b4 + A_3) + 1.5 * (double)sizeF.Height), (float)(0.5 * (double)((float)(short)unchecked(b5 + b1) - sizeF.Width)));
			}
			A_1.RotateTransform(90f);
			A_1.DrawString(A_0, font, solidBrush, 0f, 0f);
			A_1.ResetTransform();
			by = A_0;
			font.Dispose();
			solidBrush.Dispose();
		}
	}

	private void o(bool A_0, Graphics A_1, bool A_2, bool A_3, ref int A_4)
	{
		bool flag = (global::e.a().GraphBackColor == 0) | A_2;
		Font font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 1, gdiVerticalFont: true);
		SizeF sizeF = default(SizeF);
		SolidBrush solidBrush = new SolidBrush(Color.Black);
		double num = this.m_em.au(false);
		double num2 = this.m_em.a1();
		Pen pen = new Pen(Color.Gray);
		char c10 = Conversions.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
		Color color = default(Color);
		Color color2 = default(Color);
		Color a_ = ((!A_0) ? SystemColors.Control : ((!flag) ? Color.Black : Color.White));
		if (A_0 && !flag)
		{
			pen.Color = Color.FromArgb(255, 64, 64, 64);
		}
		if (hc() && ((!A_3 && dp()) || (A_3 && !dp())))
		{
			color = o(pen.Color, a_, q(flag));
			color2 = o(solidBrush.Color, a_, q(flag));
			pen.Color = color;
			solidBrush.Color = color2;
		}
		float num3 = default(float);
		if (!A_0)
		{
			A_4 = 0;
			num3 = af();
		}
		if (A_3)
		{
			num = this.m_em.au(false);
			num2 = this.m_em.a1();
			if (!hc())
			{
				pen.DashStyle = DashStyle.Dot;
			}
		}
		else
		{
			num = this.m_em.at(false);
			num2 = this.m_em.a0();
		}
		double A_5 = default(double);
		double A_6 = default(double);
		o(num2, num, 10, ref A_5, ref A_6);
		float num4 = (float)(num - num2);
		if (num4 > float.MaxValue)
		{
			num4 = float.MaxValue;
		}
		bj = num4;
		if (num4 <= 0f)
		{
			return;
		}
		float num5 = (float)(A_6 * (double)b2 / (double)num4);
		int num6 = 0;
		checked
		{
			float num7;
			do
			{
				num7 = (float)((double)b1 - (double)b2 * (A_5 - num2) / (double)num4 - (double)(num5 * (float)num6));
				if (A_0)
				{
					A_1.DrawLine(pen, b3, num7, b4, num7);
				}
				else
				{
					if (!hc() || (!A_3 && !dp()) || (A_3 && dp()))
					{
						pen.Color = Color.Black;
					}
					if (A_3)
					{
						A_1.DrawLine(pen, b4, num7, (float)b4 + ce / 3f, num7);
					}
					else
					{
						A_1.DrawLine(pen, (float)b3 - ce / 3f, num7, b3, num7);
					}
					string text = ((!fm() || !this.m_em.at()) ? Strings.Format(A_5 + A_6 * (double)num6, "0.#####") : Strings.Format((A_5 + A_6 * (double)num6) * 100.0, "0.###"));
					text = text.TrimEnd(c10);
					sizeF = A_1.MeasureString(text, font);
					if (sizeF.Width > (float)A_4)
					{
						A_4 = (int)Math.Round(sizeF.Width);
					}
					if (A_3)
					{
						A_1.DrawString(text, font, solidBrush, b4 + 4, num7 - ce / 2f);
					}
					else
					{
						A_1.DrawString(text, font, solidBrush, (float)b3 - sizeF.Width - num3, num7 - ce / 2f);
					}
				}
				num6++;
			}
			while (!(num7 - num5 < (float)b5));
			font.Dispose();
			solidBrush.Dispose();
			pen.Dispose();
		}
	}

	private void o(Graphics A_0, bool A_1)
	{
		Font font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point);
		SolidBrush solidBrush = new SolidBrush(Color.Black);
		string empty = string.Empty;
		double num;
		double num2;
		double num3;
		double num4;
		if (this.m_em != null)
		{
			num = this.m_em.at(false);
			num2 = this.m_em.a0();
			num3 = this.m_em.au(false);
			num4 = this.m_em.a1();
		}
		else
		{
			num2 = 0.0;
			num = 1.0;
			num4 = 0.0;
			num3 = 1.0;
		}
		empty = ((!fm() || !this.m_em.at()) ? Strings.Format(num2, "0.####") : Strings.Format(num2 * 100.0, "0.##"));
		SizeF sizeF = A_0.MeasureString(empty, font);
		checked
		{
			A_0.DrawLine(Pens.Black, b3 - 1, b1, (short)unchecked(b3 - cg), b1);
			A_0.DrawLine(Pens.Black, b3 - 1, b5, (short)unchecked(b3 - cg), b5);
			Rectangle rectangle = default(Rectangle);
			rectangle.X = (int)Math.Round((float)b3 - sizeF.Width - (float)cg);
			rectangle.Y = (int)Math.Round((float)b1 - ce / 2f - 1f);
			A_0.DrawString(empty, font, solidBrush, rectangle.Left, rectangle.Top);
			if (A_1)
			{
				string text = ((!fm() || !this.m_em.at()) ? Strings.Format(num4, "0.####") : Strings.Format(num4 * 100.0, "0.##"));
				sizeF = A_0.MeasureString(text, font);
				A_0.DrawLine(Pens.Black, b4 + 1, b1, (short)unchecked(b4 + cg), b1);
				rectangle.X = (short)unchecked(b4 + cg);
				rectangle.Y = (int)Math.Round((float)b1 - ce / 2f - 1f);
				A_0.DrawString(text, font, solidBrush, rectangle.Left, rectangle.Top);
			}
			empty = ((fm() && this.m_em.at()) ? Strings.Format(num * 100.0, "0.##") : ((num < 1000.0) ? Strings.Format(num, "0.####") : ((num >= 1000.0 && num < 10000.0) ? Strings.Format(num, "0.###") : ((!(num >= 10000.0) || !(num < 100000.0)) ? Strings.Format(num, "0.#") : Strings.Format(num, "0.##")))));
			sizeF = A_0.MeasureString(empty, font);
			rectangle.X = (int)Math.Round((float)b3 - sizeF.Width - (float)cg);
			rectangle.Y = (int)Math.Round((float)b5 - ce / 2f + 1f);
			A_0.DrawString(empty, font, solidBrush, rectangle.Left, rectangle.Top);
			if (A_1)
			{
				string text = ((fm() && this.m_em.at()) ? Strings.Format(num3 * 100.0, "0.##") : ((num3 < 1000.0) ? Strings.Format(num3, "0.####") : ((num >= 1000.0 && num < 10000.0) ? Strings.Format(num3, "0.###") : ((!(num >= 10000.0) || !(num < 100000.0)) ? Strings.Format(num3, "0.#") : Strings.Format(num3, "0.##")))));
				sizeF = A_0.MeasureString(text, font);
				rectangle.X = (short)unchecked(b4 + cg);
				rectangle.Y = (int)Math.Round((float)b5 - ce / 2f + 1f);
				A_0.DrawLine(Pens.Black, b4 + 1, b5, (short)unchecked(b4 + cg), b5);
				A_0.DrawString(text, font, solidBrush, rectangle.Left, rectangle.Top);
			}
			font.Dispose();
			solidBrush.Dispose();
		}
	}

	private float t(double A_0)
	{
		checked
		{
			if (this.m_em != null)
			{
				return (float)((double)b3 + (A_0 - this.m_em.a2().ap()) * (double)(short)unchecked(b4 - b3) / (this.m_em.a2().aq() - this.m_em.a2().ap()));
			}
			return 0f;
		}
	}

	private double q(float A_0)
	{
		checked
		{
			double num = (short)unchecked(b4 - b3);
			if (num > 0.0)
			{
				return this.m_em.a2().ap() + (this.m_em.a2().aq() - this.m_em.a2().ap()) * (double)(A_0 - (float)b3) / num;
			}
			return 0.0;
		}
	}

	private float s(double A_0)
	{
		return (float)((double)b5 + (this.m_em.at(false) - A_0) * (double)b2 / (this.m_em.at(false) - this.m_em.a0()));
	}

	private double p(float A_0)
	{
		checked
		{
			double num = (short)unchecked(b1 - b5);
			if (num > 0.0)
			{
				return this.m_em.a0() + (this.m_em.at(false) - this.m_em.a0()) * (double)((float)b1 - A_0) / num;
			}
			return 0.0;
		}
	}

	private float r(double A_0)
	{
		return (float)((double)b5 + (this.m_em.au(false) - A_0) * (double)b2 / (this.m_em.au(false) - this.m_em.a1()));
	}

	private double o(float A_0)
	{
		checked
		{
			double num = (short)unchecked(b1 - b5);
			if (num > 0.0)
			{
				return this.m_em.a1() + (this.m_em.au(false) - this.m_em.a1()) * (double)((float)b1 - A_0) / num;
			}
			return 0.0;
		}
	}

	private float af()
	{
		return ce / 3f - 2f;
	}

	private bool p(int A_0, int A_1)
	{
		b b10 = this.m_fy;
		float num = t(b10.e.a);
		float num2 = t(b10.e.b);
		checked
		{
			if (this.m_ej != null)
			{
				if (!b10.c && this.m_es && this.m_ej.h() >= global::gq.a.c)
				{
					if (A_0 >= b10.n() - 8 && A_0 <= b10.n() + 8 && num >= (float)b3 && num2 <= (float)b4 && A_1 >= b10.m() - 8 && A_1 <= b10.m() + 8)
					{
						b10.b = global::fl.f.b;
						return true;
					}
					if (A_0 >= b10.n() - 8 && A_0 <= b10.n() + 8 && num >= (float)b3 && num2 > (float)b4 && A_1 >= b10.m() - 8 && A_1 <= b10.m() + 8)
					{
						b10.b = global::fl.f.b;
						return true;
					}
					if (A_0 >= b3 - 8 && A_0 <= b3 + 8 && num < (float)b3 && num2 >= (float)b3 && A_1 >= b10.m() - 8 && A_1 <= b10.m() + 8)
					{
						b10.b = global::fl.f.b;
						return true;
					}
					if (A_0 >= b3 - 8 && A_0 <= b3 + 8 && num < (float)b3 && num2 < (float)b3 && A_1 >= b10.m() - 8 && A_1 <= b10.m() + 8)
					{
						b10.b = global::fl.f.c;
						return true;
					}
					if (A_0 >= b10.o() - 8 && A_0 <= b10.o() + 8 && num2 <= (float)b4 && num >= (float)b3 && A_1 >= b10.m() - 8 && A_1 <= b10.p() + 8)
					{
						b10.b = global::fl.f.c;
						return true;
					}
					if (A_0 >= b10.o() - 8 && A_0 <= b10.o() + 8 && num2 <= (float)b4 && num < (float)b3 && A_1 >= b10.m() - 8 && A_1 <= b10.p() + 8)
					{
						b10.b = global::fl.f.c;
						return true;
					}
					if (A_0 >= b4 - 8 && A_0 <= b4 + 8 && num <= (float)b4 && num2 > (float)b4 && A_1 >= b10.m() - 8 && A_1 <= b10.m() + 8)
					{
						b10.b = global::fl.f.c;
						return true;
					}
					if (A_0 >= b4 - 8 && A_0 <= b4 + 8 && num > (float)b4 && num2 > (float)b4 && A_1 >= b10.m() - 8 && A_1 <= b10.m() + 8)
					{
						b10.b = global::fl.f.b;
						return true;
					}
					b10.b = global::fl.f.a;
					return false;
				}
				return false;
			}
			bool result = default(bool);
			return result;
		}
	}

	private void o(f A_0, Graphics A_1)
	{
		Color color = Color.FromArgb(210, 255, 127, 80);
		if (base.ActiveControl == em())
		{
			A_0 = this.m_fz;
		}
		checked
		{
			switch (A_0)
			{
			case global::fl.f.b:
				if (t(this.m_fy.e.a) > (float)b4)
				{
					this.m_fy.m(b4);
				}
				else if (t(this.m_fy.e.b) < (float)b3)
				{
					this.m_fy.m(b3);
				}
				A_1.FillRectangle(new SolidBrush(color), new Rectangle(this.m_fy.n() - 5, this.m_fy.m() - 3, 5, 11));
				A_1.FillRectangle(new SolidBrush(color), new Rectangle(this.m_fy.n(), this.m_fy.m() - 3, 6, 3));
				A_1.FillRectangle(new SolidBrush(color), new Rectangle(this.m_fy.n(), this.m_fy.m() + 5, 6, 3));
				break;
			case global::fl.f.c:
				if (t(this.m_fy.e.b) < (float)b3)
				{
					this.m_fy.n(b3);
				}
				else if (t(this.m_fy.e.a) > (float)b4)
				{
					this.m_fy.m(b4);
				}
				A_1.FillRectangle(new SolidBrush(color), new Rectangle(this.m_fy.o() + 1, this.m_fy.m() - 3, 5, 11));
				A_1.FillRectangle(new SolidBrush(color), new Rectangle(this.m_fy.o() - 5, this.m_fy.m() - 3, 6, 3));
				A_1.FillRectangle(new SolidBrush(color), new Rectangle(this.m_fy.o() - 5, this.m_fy.m() + 5, 6, 3));
				break;
			}
		}
	}

	private bool o(double A_0, double A_1, bool A_2 = false)
	{
		if (A_2)
		{
			if (A_0 < this.m_em.a2().ap() || A_0 > this.m_em.a2().aq() || A_1 < this.m_em.a1() || A_1 > this.m_em.au(false))
			{
				return false;
			}
			return true;
		}
		if (A_0 < this.m_em.a2().ap() || A_0 > this.m_em.a2().aq() || A_1 < this.m_em.a0() || A_1 > this.m_em.at(false))
		{
			return false;
		}
		return true;
	}

	private bool q(double A_0)
	{
		if (A_0 < this.m_em.a2().ap() || A_0 > this.m_em.a2().aq())
		{
			return false;
		}
		return true;
	}

	private double p(double A_0)
	{
		if (A_0 < this.m_em.a0())
		{
			return this.m_em.a0();
		}
		if (A_0 > this.m_em.at(false))
		{
			return this.m_em.at(false);
		}
		return A_0;
	}

	private double o(double A_0)
	{
		if (A_0 < this.m_em.a1())
		{
			return this.m_em.a1();
		}
		if (A_0 > this.m_em.au(false))
		{
			return this.m_em.au(false);
		}
		return A_0;
	}

	private void ae()
	{
		b b10 = this.m_fy;
		if (b10.f)
		{
			b10.e.a = this.m_em.a2().ap();
			b10.e.b = this.m_em.a2().aq();
		}
		z();
		try
		{
			eu().Checked = this.m_em.a2().av();
			et().Checked = this.m_em.a2().au();
			es().Checked = this.m_em.a2().at();
		}
		finally
		{
			y();
		}
		b10 = null;
		hb();
	}

	[SpecialName]
	private bool ad()
	{
		return this.m_e2 > 0;
	}

	private void ac()
	{
		checked
		{
			this.m_e2--;
			if (this.m_e2 < 0)
			{
				this.m_e2 = 0;
			}
		}
	}

	private void ab()
	{
		checked
		{
			this.m_e2++;
		}
	}

	[SpecialName]
	private bool aa()
	{
		return this.m_gu > 0;
	}

	private void z()
	{
		checked
		{
			this.m_gu++;
		}
	}

	private void y()
	{
		checked
		{
			this.m_gu--;
		}
	}

	[SpecialName]
	private bool x()
	{
		return this.m_e3 > 0;
	}

	private void w()
	{
		checked
		{
			this.m_e3--;
			if (this.m_e3 < 0)
			{
				this.m_e3 = 0;
			}
		}
	}

	private void v()
	{
		checked
		{
			this.m_e3++;
		}
	}

	private void o(int A_0, int A_1)
	{
		if (!bd)
		{
			this.m_fk = new Point(A_0, A_1);
			eu().Text = string.Format(this.m_fr, gk());
			ev().Text = string.Format(this.m_fs, gk());
			ex().Text = string.Format(this.m_ft, gk());
			ev().DropDownItems.Clear();
			ex().DropDownItems.Clear();
			ez().DropDownItems.Clear();
			e0().DropDownItems.Clear();
			ev().DropDownItems.Add(new ToolStripMenuItem());
			ex().DropDownItems.Add(new ToolStripMenuItem());
			ez().DropDownItems.Add(new ToolStripMenuItem());
			e0().DropDownItems.Add(new ToolStripMenuItem());
			eo().Show(PointToScreen(new Point(A_0, A_1)));
			ev().Visible = gz();
			ex().Visible = gz();
			ew().Visible = gz();
		}
	}

	private void o(ToolStripMenuItem A_0, i A_1)
	{
		bool flag = true;
		checked
		{
			if (bp.Count > 0)
			{
				int num = bp.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (bp[num2].j == null)
					{
						bp[num2].j = new List<string>();
					}
					string text = (bp[num2].r() ? bh[0] : ((!bp[num2].s()) ? bh[2] : bh[1]));
					bp[num2].h = text;
					bp[num2].i = bh[1];
					if (bp[num2][0].ai() != null)
					{
						int num3 = bp[num2][0].ai().Count - 1;
						for (int num4 = 0; num4 <= num3; num4++)
						{
							bp[num2].j.Add(bh[2]);
						}
					}
					List<fn> list = bp[num2][0].q(bp[num2].b, num2, A_2: false);
					foreach (fn item in list)
					{
						string text2;
						if (item.m())
						{
							text2 = bp[num2].h;
							if (global::e.a().AutoTrackActiveCurve && item.l() == this.m_c6)
							{
								bp[num2][0].v(A_0: true);
								item.p(A_0: true);
							}
						}
						else if (item.n())
						{
							text2 = bp[num2].i;
							if (global::e.a().AutoTrackActiveCurve && item.l() == this.m_c6)
							{
								bp[num2][0].ah().v(A_0: true);
								item.p(A_0: true);
							}
						}
						else
						{
							text2 = bp[num2].j[item.q()];
							if (global::e.a().AutoTrackActiveCurve && item.l() == this.m_c6)
							{
								bp[num2][0].ai()[item.q()].v(A_0: true);
								item.p(A_0: true);
							}
						}
						string name = item.k() + " - " + text2;
						ToolStripMenuItem toolStripMenuItem = null;
						if (A_1 == global::fl.i.d && !item.s())
						{
							continue;
						}
						toolStripMenuItem = new ToolStripMenuItem(name);
						toolStripMenuItem.Name = name;
						toolStripMenuItem.Enabled = !this.m_f1 || (this.m_f1 && item.m() && dq()) || (this.m_f1 && item.n() && dp()) || (this.m_f1 && item.o() && @do());
						toolStripMenuItem.ForeColor = bp[num2][0].q();
						switch (A_1)
						{
						case global::fl.i.b:
							if (item.r().Count > 0)
							{
								ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem(global::ey.t());
								ToolStripMenuItem toolStripMenuItem5 = new ToolStripMenuItem(global::ey.s());
								toolStripMenuItem4.Tag = item;
								toolStripMenuItem5.Tag = item;
								toolStripMenuItem4.Click += x;
								toolStripMenuItem5.Click += x;
								toolStripMenuItem.DropDownItems.Add(toolStripMenuItem4);
								toolStripMenuItem.DropDownItems.Add(toolStripMenuItem5);
								int num5 = item.r().Count - 1;
								for (int num6 = 0; num6 <= num5; num6++)
								{
									ToolStripMenuItem toolStripMenuItem6 = new ToolStripMenuItem(item.r()[num6] + " (nm)");
									toolStripMenuItem6.Tag = item;
									toolStripMenuItem6.Click += x;
									toolStripMenuItem.DropDownItems.Add(toolStripMenuItem6);
								}
							}
							else
							{
								flag = false;
							}
							break;
						case global::fl.i.a:
						{
							ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(string.Format(global::ey.w(), ((float)q((float)this.m_fk.X)).ToString("##0.00") + " (nm)"));
							toolStripMenuItem2.Tag = item;
							ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem(global::ey.v());
							toolStripMenuItem3.Tag = item;
							toolStripMenuItem2.Click += aj;
							toolStripMenuItem3.Click += ab;
							toolStripMenuItem.DropDownItems.Add(toolStripMenuItem2);
							toolStripMenuItem.DropDownItems.Add(toolStripMenuItem3);
							break;
						}
						case global::fl.i.c:
							toolStripMenuItem.Tag = item;
							toolStripMenuItem.Click += t;
							break;
						case global::fl.i.d:
							toolStripMenuItem.Tag = item;
							toolStripMenuItem.Click += t;
							break;
						}
						if (flag)
						{
							A_0.DropDownItems.Add(toolStripMenuItem);
						}
						flag = true;
					}
				}
			}
			if (this.m_d9 == null || !this.m_fn)
			{
				return;
			}
			List<fn> list2 = this.m_d9.q(this.m_ea, -1, A_2: true);
			bool flag2 = this.m_c6 < 0 || this.m_c6 > bp.Count;
			foreach (fn item2 in list2)
			{
				string text3;
				List<string> list3;
				if (item2.m())
				{
					text3 = ((!flag2) ? bh[0] : bp[this.m_c6].h);
					list3 = this.m_fe;
					item2.p(global::e.a().AutoTrackCalcCurve);
					item2.o(this.m_fh);
				}
				else if (item2.n())
				{
					text3 = ((!flag2) ? bh[1] : bp[this.m_c6].i);
					list3 = this.m_ff;
					item2.p(global::e.a().AutoTrackCalcCurve);
					item2.o(this.m_fi);
				}
				else
				{
					text3 = ((!flag2) ? bh[2] : bp[this.m_c6].j[item2.q()]);
					list3 = this.m_fg[item2.q()];
					if (this.m_fj.Count == 0)
					{
						this.m_fj.Add(item: false);
					}
					item2.p(global::e.a().AutoTrackCalcCurve);
					item2.o(this.m_fj[item2.q()]);
				}
				string name2 = item2.k() + " - " + text3;
				if (!item2.s() && A_1 == global::fl.i.d)
				{
					continue;
				}
				ToolStripMenuItem toolStripMenuItem7 = new ToolStripMenuItem(name2);
				toolStripMenuItem7.Name = name2;
				toolStripMenuItem7.Enabled = !this.m_f1 || (this.m_f1 && item2.m() && dq()) || (this.m_f1 && item2.n() && dp()) || (this.m_f1 && item2.o() && @do());
				toolStripMenuItem7.ForeColor = this.m_d9.q();
				switch (A_1)
				{
				case global::fl.i.b:
					if (list3.Count > 0)
					{
						ToolStripMenuItem toolStripMenuItem10 = new ToolStripMenuItem(global::ey.t());
						ToolStripMenuItem toolStripMenuItem11 = new ToolStripMenuItem(global::ey.s());
						toolStripMenuItem11.Tag = item2;
						toolStripMenuItem10.Tag = item2;
						toolStripMenuItem7.DropDownItems.Add(toolStripMenuItem10);
						toolStripMenuItem7.DropDownItems.Add(toolStripMenuItem11);
						toolStripMenuItem10.Click += x;
						toolStripMenuItem11.Click += x;
						int num7 = list3.Count - 1;
						for (int num8 = 0; num8 <= num7; num8++)
						{
							ToolStripMenuItem toolStripMenuItem12 = new ToolStripMenuItem(list3[num8] + " (nm)");
							toolStripMenuItem12.Tag = item2;
							toolStripMenuItem12.Click += x;
							toolStripMenuItem7.DropDownItems.Add(toolStripMenuItem12);
						}
					}
					else
					{
						flag = false;
					}
					break;
				case global::fl.i.a:
				{
					ToolStripMenuItem toolStripMenuItem8 = new ToolStripMenuItem(string.Format(global::ey.w(), ((float)q((float)this.m_fk.X)).ToString("##0.00") + " (nm)"));
					toolStripMenuItem8.Tag = item2;
					ToolStripMenuItem toolStripMenuItem9 = new ToolStripMenuItem(global::ey.v());
					toolStripMenuItem9.Tag = item2;
					toolStripMenuItem7.DropDownItems.Add(toolStripMenuItem8);
					toolStripMenuItem7.DropDownItems.Add(toolStripMenuItem9);
					toolStripMenuItem8.Click += aj;
					toolStripMenuItem9.Click += ab;
					break;
				}
				case global::fl.i.c:
					toolStripMenuItem7.Tag = item2;
					toolStripMenuItem7.Click += t;
					break;
				case global::fl.i.d:
					toolStripMenuItem7.Tag = item2;
					toolStripMenuItem7.Click += t;
					break;
				}
				if (flag)
				{
					A_0.DropDownItems.Add(toolStripMenuItem7);
				}
				flag = true;
			}
		}
	}

	private void p(int A_0)
	{
		if (bp.Count == 0)
		{
			return;
		}
		a<fx> a10 = bp[this.m_c6];
		fx fx2 = a10[0];
		checked
		{
			if (global::e.a().AutoTrackActiveCurve)
			{
				fx2.v(A_0: true);
				if (fx2.ah() != null)
				{
					fx2.ah().v(A_0: true);
				}
				if (fx2.ai() != null && fx2.ai().Count > 0)
				{
					int num = fx2.ai().Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						fx2.ai()[num2].v(A_0: true);
					}
				}
			}
			a10 = bp[A_0];
			if (a10.Count < 1)
			{
				return;
			}
			fx2 = a10[0];
			fx2.v(A_0: false);
			if (fx2.ah() != null)
			{
				fx2.ah().v(A_0: false);
			}
			if (fx2.ai() != null && fx2.ai().Count > 0)
			{
				int num3 = fx2.ai().Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					fx2.ai()[num4].v(A_0: false);
				}
			}
		}
	}

	private void u()
	{
		checked
		{
			int num = bp.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				fx fx2 = bp[num2][0];
				if (num2 == this.m_c6)
				{
					fx2.v(global::e.a().AutoTrackActiveCurve);
					if (fx2.ah() != null)
					{
						fx2.ah().v(global::e.a().AutoTrackActiveCurve);
					}
					if (fx2.ai() != null && fx2.ai().Count > 0)
					{
						int num3 = fx2.ai().Count - 1;
						for (int num4 = 0; num4 <= num3; num4++)
						{
							fx2.ai()[num4].v(global::e.a().AutoTrackActiveCurve);
						}
					}
					continue;
				}
				fx2.v(A_0: false);
				if (fx2.ah() != null)
				{
					fx2.ah().v(A_0: false);
				}
				if (fx2.ai() != null && fx2.ai().Count > 0)
				{
					int num5 = fx2.ai().Count - 1;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						fx2.ai()[num6].v(A_0: false);
					}
				}
			}
			if (this.m_d9 == null)
			{
				return;
			}
			this.m_d9.v(global::e.a().AutoTrackCalcCurve);
			if (this.m_d9.ah() != null)
			{
				this.m_d9.ah().v(global::e.a().AutoTrackCalcCurve);
			}
			if (this.m_d9.ai() != null && this.m_d9.ai().Count > 0)
			{
				int num7 = this.m_d9.ai().Count - 1;
				for (int num8 = 0; num8 <= num7; num8++)
				{
					this.m_d9.ai()[num8].v(global::e.a().AutoTrackCalcCurve);
				}
			}
		}
	}

	public void o(fx A_0, bool A_1, PointF A_2, ref float A_3, ref float A_4, ref bool A_5)
	{
		A_5 = true;
		double num = q(A_2.X);
		if (num > A_0.y())
		{
			num = A_0.y();
			A_5 = false;
		}
		if (num < A_0.z())
		{
			num = A_0.z();
			A_5 = false;
		}
		A_0.u(num);
		A_3 = t(num);
		if (A_1)
		{
			A_4 = r(A_0.ak());
		}
		else
		{
			A_4 = s(A_0.ak());
		}
	}

	private void o(a<fx> A_0, PointF A_1)
	{
		fx a_ = A_0[0];
		o(a_, A_1, A_0.s());
	}

	private void o(fx A_0, PointF A_1, bool A_2)
	{
		double num = q(A_1.X);
		if (num > A_0.y())
		{
			num = A_0.y();
		}
		if (num < A_0.z())
		{
			num = A_0.z();
		}
		A_0.u(num);
		this.m_e6 = t(num);
		if (bu && !da() && A_2)
		{
			this.m_e7 = r(A_0.ak());
		}
		else
		{
			this.m_e7 = s(A_0.ak());
		}
		if ((bu || da()) && A_0.ah() != null)
		{
			A_0.ah().u(num);
			if (da())
			{
				this.m_e8 = s(A_0.ah().ak());
			}
			else
			{
				this.m_e8 = r(A_0.ah().ak());
			}
		}
		checked
		{
			if (this.m_d9 != null)
			{
				this.m_d9.u(num);
				if (bu && !da() && A_2)
				{
					this.m_fa = r(this.m_d9.ak());
				}
				else
				{
					this.m_fa = s(this.m_d9.ak());
				}
				if (bu && this.m_d9.ah() != null)
				{
					this.m_d9.ah().u(num);
					this.m_fb = r(this.m_d9.ah().ak());
				}
				if (this.m_d9.ai() != null && this.m_d9.ai().Count > 0 && A_0.ai() != null && A_0.ai().Count > 0)
				{
					ref float[] reference = ref this.m_fc;
					reference = (float[])Utils.CopyArray(reference, new float[this.m_d9.ai().Count + 1]);
					int num2 = A_0.ai().Count - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						this.m_d9.ai()[num3].u(num);
						this.m_fc[num3] = s(this.m_d9.ai()[num3].ak());
					}
				}
			}
			if (A_0.ai() != null && A_0.ai().Count > 0)
			{
				this.m_e9 = new float[A_0.ai().Count + 1];
				int num4 = A_0.ai().Count - 1;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					A_0.ai()[num5].u(num);
					this.m_e9[num5] = s(A_0.ai()[num5].ak());
				}
			}
		}
	}

	private void o(float A_0, float A_1)
	{
		this.m_fq = new PointF(A_0, A_1);
		Invalidate();
	}

	private void o(double A_0, double A_1, ref bool A_2)
	{
		bool A_3 = default(bool);
		o(A_0: false, A_0, A_1, ref A_3, ref A_2);
	}

	private void o(bool A_0, double A_1, double A_2, ref bool A_3, ref bool A_4)
	{
		A_4 = false;
		this.m_gl?.Invoke(this, A_1: false, ref A_4);
		if (A_4 || this.m_a2 == null || a4 == null)
		{
			return;
		}
		A_3 = this.m_em.at() && fm();
		if (A_0)
		{
			this.m_a2.Text = "";
			a4.Text = "";
			return;
		}
		this.m_a2.Text = Strings.Format(A_1, "###0.##");
		if (A_3)
		{
			a4.Text = Strings.Format(A_2 * 100.0, "###0.##") + "%";
		}
		else
		{
			a4.Text = Strings.Format(A_2, "###0.####");
		}
	}

	private void o(ref bool A_0)
	{
		o(A_0: true, 0.0, 0.0, 0.0, ref A_0);
	}

	private void o(double A_0, double A_1, double A_2, ref bool A_3)
	{
		o(A_0: false, A_0, A_1, A_2, ref A_3);
	}

	private void o(bool A_0, double A_1, double A_2, double A_3, ref bool A_4)
	{
		bool A_5 = default(bool);
		o(A_0, A_1, A_2, ref A_5, ref A_4);
		if (A_4 || a6 == null)
		{
			return;
		}
		if (A_0)
		{
			a6.Text = "";
		}
		else if (a6 != null)
		{
			if (A_5)
			{
				a6.Text = Strings.Format(A_3 * 100.0, "###0.##") + "%";
			}
			else
			{
				a6.Text = Strings.Format(A_3, "###0.####");
			}
		}
	}

	private void t()
	{
		if (!Directory.Exists(i3.i()))
		{
			Directory.CreateDirectory(i3.i());
		}
		string path = i3.i() + "\\GraphDotsInfo.txt";
		StreamWriter streamWriter = new StreamWriter(File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite));
		checked
		{
			try
			{
				if (gw())
				{
					streamWriter.WriteLine("Version, " + 1);
					streamWriter.WriteLine("Compatible Version, " + 1);
					streamWriter.WriteLine(this.m_fd.Count);
					int num = this.m_fd.Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						this.m_fd[num2].f(streamWriter);
					}
				}
			}
			finally
			{
				streamWriter.Close();
			}
		}
	}

	private void s()
	{
		if (!Directory.Exists(i3.i()))
		{
			Directory.CreateDirectory(i3.i());
		}
		string path = i3.i() + "\\OverlayCurveDotsInfo.txt";
		StreamWriter streamWriter = new StreamWriter(File.Open(path, FileMode.OpenOrCreate));
		checked
		{
			try
			{
				if (!gw())
				{
					return;
				}
				streamWriter.WriteLine("Version, " + 1);
				streamWriter.WriteLine("Compatible Version, " + 1);
				streamWriter.WriteLine(this.m_fe.Count);
				int num = this.m_fe.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					streamWriter.WriteLine(this.m_fe[num2]);
				}
				streamWriter.WriteLine(this.m_ff.Count);
				int num3 = this.m_ff.Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					streamWriter.WriteLine(this.m_ff[num4]);
				}
				streamWriter.WriteLine(this.m_fg.Count);
				int num5 = this.m_fg.Count - 1;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					streamWriter.WriteLine(this.m_fg[num6].Count);
					int num7 = this.m_fg[num6].Count - 1;
					for (int num8 = 0; num8 <= num7; num8++)
					{
						streamWriter.WriteLine(this.m_fg[num6][num8]);
					}
				}
			}
			finally
			{
				streamWriter.Close();
			}
		}
	}

	public void hj()
	{
		if (!File.Exists(i3.i() + "\\GraphDotsInfo.txt"))
		{
			return;
		}
		StreamReader streamReader = new StreamReader(i3.i() + "\\GraphDotsInfo.txt");
		checked
		{
			try
			{
				if (gw())
				{
					streamReader.ReadLine();
					streamReader.ReadLine();
					int num = iz.c(streamReader.ReadLine()) - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						fo fo2 = new fo();
						fo2.f(streamReader);
						this.m_fd.Add(fo2);
					}
				}
			}
			finally
			{
				streamReader.Close();
			}
		}
	}

	private void r()
	{
		StreamReader streamReader = null;
		checked
		{
			try
			{
				string path = i3.i() + "\\OverlayCurveDotsInfo.txt";
				if (!File.Exists(path))
				{
					return;
				}
				streamReader = new StreamReader(path);
				streamReader.ReadLine();
				streamReader.ReadLine();
				int num = iz.c(streamReader.ReadLine());
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					this.m_fe.Add(streamReader.ReadLine().Trim());
				}
				num = iz.c(streamReader.ReadLine());
				int num4 = num - 1;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					this.m_ff.Add(streamReader.ReadLine().Trim());
				}
				num = iz.c(streamReader.ReadLine());
				int num6 = num - 1;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					this.m_fg.Add(new List<string>());
				}
				int num8 = num - 1;
				for (int num9 = 0; num9 <= num8; num9++)
				{
					int num10 = iz.c(streamReader.ReadLine()) - 1;
					for (int num11 = 0; num11 <= num10; num11++)
					{
						this.m_fg[num9].Add(streamReader.ReadLine());
					}
				}
			}
			finally
			{
				streamReader?.Close();
				if (this.m_fg.Count == 0)
				{
					this.m_fg.Add(new List<string>());
				}
			}
		}
	}

	private int o(int A_0)
	{
		int num = A_0;
		checked
		{
			bool flag;
			do
			{
				flag = true;
				int num2 = this.m_fd.Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (this.m_fd[num3].a == num)
					{
						num++;
						flag = false;
						break;
					}
				}
			}
			while (!flag);
			return num;
		}
	}

	private void df(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				ar();
				c4 = d4().Width - d6().Width;
				this.m_c5 = eh().Width - ej().Width;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				az.c(global::fz.b.b, "Exception in FIControlGraph.FIControlGraph_Load", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ag(object A_0, MouseEventArgs A_1)
	{
		try
		{
			if (A_1.Button == MouseButtons.Left && base.ActiveControl == em())
			{
				this.m_fy.d = false;
				if (base.ActiveControl == em())
				{
					base.ActiveControl = null;
				}
				Invalidate();
			}
			else if (!ay && A_1.Button == MouseButtons.Left && A_1.X < b4 && A_1.X > b3 && A_1.Y < b1 && A_1.Y > b5)
			{
				PointF a_ = default(PointF);
				a_.X = (float)q((float)A_1.X);
				a_.Y = (float)p((float)A_1.Y);
				this.m_fx?.Invoke(a_);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.FIControlGraph_MouseClick", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void de(object A_0, EventArgs A_1)
	{
		try
		{
			if (gd() && !bm && this.m_fn)
			{
				d3().SetToolTip(this, this.m_ei);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.ControlGraph_MouseHover", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void dd(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_eq = false;
			this.m_e6 = 0.0;
			this.m_e7 = 0f;
			this.m_e8 = 0f;
			e2().Start();
			if (!gv())
			{
				bool A_2 = default(bool);
				o(ref A_2);
				if (!A_2)
				{
					this.m_gk?.Invoke(null);
				}
			}
			d3().Hide(this);
			Point position = Cursor.Position;
			Point point = PointToScreen(new Point(0, 0));
			if (!new Rectangle(point.X, point.Y, base.Width, base.Height).Contains(position))
			{
				o(d4(), d5(), c4);
				this.m_d5 = false;
				o(eh(), ei(), c4);
				this.m_d6 = false;
			}
			hb();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.ControlGraph_MouseLeave", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void af(object A_0, MouseEventArgs A_1)
	{
		if (this.m_fu)
		{
			this.m_fu = false;
			return;
		}
		checked
		{
			try
			{
				if (av && ax)
				{
					_ = this.m_em;
					Rectangle a_ = this.m_ar.l(this);
					_ = null;
					this.m_as = this.m_at;
					if (A_1.X < this.m_as.X)
					{
						if (A_1.X > b3)
						{
							a_.X = A_1.X;
						}
						else
						{
							a_.X = b3;
						}
						a_.Width = this.m_as.X - a_.X;
					}
					else
					{
						a_.X = this.m_as.X;
						if (A_1.X < b4)
						{
							a_.Width = A_1.X - this.m_as.X;
						}
						else
						{
							a_.Width = b4 - this.m_as.X;
						}
					}
					if (A_1.Y < this.m_as.Y)
					{
						if (A_1.Y > b5)
						{
							a_.Y = A_1.Y;
						}
						else
						{
							a_.Y = b5;
						}
						a_.Height = this.m_as.Y - a_.Y;
					}
					else
					{
						a_.Y = this.m_as.Y;
						if (A_1.Y < b1)
						{
							a_.Height = A_1.Y - this.m_as.Y;
						}
						else
						{
							a_.Height = b1 - this.m_as.Y;
						}
					}
					if (a_.Height > 1 && a_.Width > 1)
					{
						if (e3().Enabled)
						{
							e3().Enabled = false;
						}
						aw = true;
						ay = true;
						this.m_ar.j(a_, this);
						Invalidate();
					}
				}
				this.m_eu = false;
				o(d4(), d5(), A_1);
				if (d4().Height == d5().Height)
				{
					o(eh(), ei(), A_1);
				}
				if ((p(A_1.X, A_1.Y) || this.m_fy.c || base.ActiveControl == em()) && !this.m_et)
				{
					if (!this.m_fy.d)
					{
						this.m_fy.d = true;
						Invalidate();
					}
					if (base.ActiveControl == em())
					{
						this.m_fy.b = this.m_fz;
					}
					if (!this.m_fy.c)
					{
						if (!em().Visible)
						{
							int num2 = default(int);
							if (this.m_fy.b == global::fl.f.b)
							{
								double num = t(this.m_fy.e.a);
								num2 = ((!(num > (double)b4)) ? Conversions.ToInteger(Interaction.IIf((double)b3 >= num, b3 - unchecked(em().Size.Width / 2), num - (double)unchecked(em().Size.Width / 2))) : (b4 - unchecked(em().Size.Width / 2)));
							}
							else if (this.m_fy.b == global::fl.f.c)
							{
								double num3 = t(this.m_fy.e.b);
								num2 = ((!(num3 < (double)b3)) ? Conversions.ToInteger(Interaction.IIf((double)b4 <= num3, b4 - unchecked(em().Size.Width / 2), num3 - (double)unchecked(em().Size.Width / 2))) : (b3 - unchecked(em().Size.Width / 2)));
							}
							int num4 = this.m_fy.m() - 30;
							em().Location = new Point(num2, num4);
							ToolTip toolTip = d3();
							hy control = em();
							string A_2 = "PressEnterToApply";
							toolTip.SetToolTip(control, hu.a(ref A_2));
							if (this.m_fy.b == global::fl.f.b)
							{
								em().Text = this.m_fy.e.a.ToString("0.##");
							}
							else if (this.m_fy.b == global::fl.f.c)
							{
								em().Text = this.m_fy.e.b.ToString("0.##");
							}
							em().Visible = true;
						}
					}
					else
					{
						em().Visible = false;
						if (this.m_fy.b == global::fl.f.b)
						{
							if (A_1.X > this.m_fy.o() - 10)
							{
								this.m_fy.m(this.m_fy.o() - 10 + 1);
								this.m_fy.e.a = q((float)(this.m_fy.o() - 10 + 1));
							}
							else
							{
								double num5 = q((float)A_1.X);
								if (num5 < this.m_em.a2().ap())
								{
									this.m_fy.e.a = this.m_em.a2().ap();
									this.m_fy.m(b3);
								}
								else
								{
									this.m_fy.e.a = num5;
									this.m_fy.m(A_1.X);
								}
							}
							Invalidate();
						}
						else if (this.m_fy.b == global::fl.f.c)
						{
							if (A_1.X < this.m_fy.n() + 10)
							{
								this.m_fy.e.b = q((float)(this.m_fy.n() + 10 - 1));
								this.m_fy.n(this.m_fy.n() + 10 - 1);
							}
							else
							{
								double num6 = q((float)A_1.X);
								if (num6 > this.m_em.a2().aq())
								{
									this.m_fy.e.b = this.m_em.a2().aq();
									this.m_fy.n(b4);
								}
								else
								{
									this.m_fy.e.b = num6;
									this.m_fy.n(A_1.X);
								}
							}
							Invalidate();
						}
					}
				}
				else
				{
					q();
				}
				bool A_3 = default(bool);
				if (p((float)A_1.X, (float)A_1.Y))
				{
					o(q((float)A_1.X), p((float)A_1.Y), o((float)A_1.Y), ref A_3);
					o((float)A_1.X, (float)A_1.Y);
					if (A_3)
					{
						Cursor = Cursors.Default;
						return;
					}
					if (this.m_fy.d)
					{
						Cursor = Cursors.Default;
					}
					else
					{
						Cursor = Cursors.Cross;
					}
				}
				else
				{
					this.m_e6 = 0.0;
					this.m_e7 = 0f;
					this.m_e8 = 0f;
					d3().Hide(this);
					o(ref A_3);
					Cursor = Cursors.Default;
					Invalidate();
				}
				if (!A_3)
				{
					this.m_gk?.Invoke(this);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				az.c(global::fz.b.b, "Exception in FIControlGraph.ControlGraph_MouseMove", a_2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void q()
	{
		if (base.ActiveControl != em() && this.m_fy.d)
		{
			this.m_fy.d = false;
			em().Visible = false;
			Invalidate();
		}
	}

	private void o(Panel A_0, Panel A_1, MouseEventArgs A_2)
	{
		Panel panel = A_0;
		checked
		{
			if (A_2.X >= panel.Left - 4 && A_2.X <= panel.Right + 4 && A_2.Y >= panel.Top - 4 && A_2.Y <= panel.Bottom + 4 && panel.Height == A_1.Height && panel.Visible && !cx)
			{
				panel.Visible = false;
				A_1.Location = new Point(5, 5);
				panel.Left -= 5;
				panel.Top -= 5;
				panel.Width += 10;
				panel.Height += 10;
				panel.BackColor = Color.FromArgb(255, 234, 179);
				panel.Visible = true;
				panel.BringToFront();
				if (A_0 == d4())
				{
					this.m_d5 = true;
					this.m_d6 = false;
				}
				else if (A_0 == eh())
				{
					this.m_d6 = true;
					this.m_d5 = false;
				}
			}
			else
			{
				o(A_0, A_1, c4);
				if (A_0 == d4())
				{
					this.m_d5 = false;
				}
				else
				{
					this.m_d6 = false;
				}
			}
			panel = null;
		}
	}

	private void o(object A_0, PaintEventArgs A_1)
	{
		try
		{
			if (!fu())
			{
				u(A_1.Graphics);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception caught in FIControlGraph.ControlGraph_Paint.", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void dc(object A_0, EventArgs A_1)
	{
		try
		{
			if (base.Width > 0 && base.Height > 0)
			{
				if (!global::e.a().AutoPositionLegends)
				{
					p(d4(), this.m_c2);
					p(eh(), this.m_c3);
				}
				else
				{
					this.m_e5 = true;
				}
				Invalidate();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception caught in FIControlGraph.FIControlGraph_Resize.", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void db(object A_0, EventArgs A_1)
	{
		try
		{
			ar();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception caught in FIControlGraph.FIControlGraph_SizeChanged.", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void da(object A_0, EventArgs A_1)
	{
		try
		{
			long a_ = bp[this.m_dv].a;
			long a_2 = bp[this.m_dv][0].ac();
			o(this.m_dv, A_1: false, global::r.d.a.b.a);
			this.m_gd?.Invoke(this, a_, a_2);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			az.c(global::fz.b.b, "Exception caught in FIControlGraph.DeleteCurveToolStripMenuItem_Click.", a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void o(object A_0, PreviewKeyDownEventArgs A_1)
	{
		try
		{
			switch (A_1.KeyCode)
			{
			case Keys.Left:
			case Keys.Up:
			case Keys.Right:
			case Keys.Down:
				A_1.IsInputKey = true;
				break;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception caught in FIControlGraph.FIControlGraph_PreviewKeyDown.", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void p(object A_0, KeyEventArgs A_1)
	{
		try
		{
			if (this.m_c6 < 0 || bp.Count <= 0 || this.m_c6 > bp.Count)
			{
				return;
			}
			fx fx2 = ((!bo) ? bp[this.m_c6][0] : this.m_d9);
			switch (A_1.KeyCode)
			{
			case Keys.Left:
			case Keys.Up:
			case Keys.Right:
			case Keys.Down:
			{
				double A_2 = q((float)this.m_e6);
				if (!jf.b((float)A_2, (float)fx2.y()) && !jf.d((float)A_2, (float)fx2.z()))
				{
					fx2.u(A_2);
					fx2.q(ref A_2, (float)fb(), (float)fa());
					fx2.q(A_1.KeyCode, ref A_2);
					this.m_e7 = s(fx2.ak());
					this.m_e6 = t(A_2);
					if (this.m_e6 > (double)b3 && this.m_e6 < (double)b4 && this.m_e7 < (float)b1 && this.m_e7 > (float)b5)
					{
						this.m_fu = true;
						Cursor.Position = PointToScreen(checked(new Point((int)Math.Round(this.m_e6), (int)Math.Round(this.m_fq.Y))));
					}
					o((float)this.m_e6, this.m_fq.Y);
				}
				break;
			}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.FIControlGraph_KeyDown.", ex3);
			Interaction.MsgBox("Exception in FIControlGraph.FIControlGraph_KeyDown. Exception is:" + ex3.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void ae(object A_0, MouseEventArgs A_1)
	{
		try
		{
			if (A_1.Button == MouseButtons.Left && f7)
			{
				e3().Stop();
				global::fb.b(gx()).b(this, i6.a(this));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.FIControlGraph_DoubleClick.", ex3);
			Interaction.MsgBox("Exception in FIControlGraph.FIControlGraph_DoubleClick. Exception is:" + ex3.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void ad(object A_0, MouseEventArgs A_1)
	{
		try
		{
			ay = false;
			if (A_1.X > b3 && A_1.X < b4 && A_1.Y < b1 && A_1.Y > b5)
			{
				if (e3().Enabled)
				{
					e3().Stop();
				}
				else if (ax)
				{
					e3().Start();
				}
				if (A_1.Button == MouseButtons.Right)
				{
					if (((bp != null && bp.Count > 0) || (this.m_d9 != null && this.m_d9.ab())) && (at() || ax))
					{
						o(A_1.X, A_1.Y);
					}
					Invalidate();
				}
				else if (A_1.Button == MouseButtons.Left && ax)
				{
					this.m_ar.l(this, A_1.X);
					this.m_ar.m(this, A_1.Y);
					this.m_ar.k(this, 0);
					this.m_ar.j(this, 0);
					this.m_at.X = A_1.X;
					this.m_at.Y = A_1.Y;
					av = true;
				}
			}
			if (A_1.Button == MouseButtons.Left && !gr())
			{
				if (em().Visible)
				{
					em().Visible = false;
				}
				if (base.ActiveControl == em())
				{
					base.ActiveControl = null;
				}
				if (p(A_1.X, A_1.Y))
				{
					this.m_fy.c = true;
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.ControlGraph_MouseDown", ex3);
			Interaction.MsgBox("Exception in FIControlGraph.FIControlGraph_MouseDown. Exception is:" + ex3.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void ac(object A_0, MouseEventArgs A_1)
	{
		try
		{
			av = false;
			if (A_1.Button == MouseButtons.Left)
			{
				if (ay)
				{
					this.m_aq = this.m_ar;
					this.m_as = this.m_at;
					this.m_fw?.Invoke();
				}
				if (this.m_fy.c)
				{
					this.m_fy.c = false;
					this.m_fv?.Invoke(this.m_fy.e);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception caught in FIControlGraph.FIControlGraph_MouseUp.", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c9(object A_0, EventArgs A_1)
	{
		this.m_eq = true;
	}

	private void o(object A_0, CancelEventArgs A_1)
	{
		try
		{
			if (!ga || (f4() && f5() && f6() && this.m_dv >= bp.Count))
			{
				A_1.Cancel = true;
			}
			else
			{
				d0().Visible = bp[this.m_dv].f;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.LegendRightClickMenu_Opening", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c8(object A_0, EventArgs A_1)
	{
		try
		{
			if (!aa() && this.m_em.a2().av() != eu().Checked)
			{
				this.m_em.a2().aq(eu().Checked);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Error in CursorShowXValueToolStripMenuItem_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c7(object A_0, EventArgs A_1)
	{
		try
		{
			if (!aa() && this.m_em.a2().au() != et().Checked)
			{
				this.m_em.a2().ap(et().Checked);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Error in VerticalLineToolStripMenuItem_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c6(object A_0, EventArgs A_1)
	{
		try
		{
			if (!aa() && this.m_em.a2().at() != es().Checked)
			{
				this.m_em.a2().ao(es().Checked);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Error in DotToolStripMenuItem_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void r(ref double A_0)
	{
		double num = ff();
		if (!fu() && base.Visible && num < A_0)
		{
			A_0 = num;
		}
	}

	private void q(ref double A_0)
	{
		double num = fd();
		if (!fu() && base.Visible && num > A_0)
		{
			A_0 = num;
		}
	}

	private void p(ref double A_0)
	{
		double num = fe();
		if (!fu() && base.Visible && num < A_0)
		{
			A_0 = num;
		}
	}

	private void o(ref double A_0)
	{
		double num = fc();
		if (!fu() && base.Visible && num > A_0)
		{
			A_0 = num;
		}
	}

	private void q(object A_0, ElapsedEventArgs A_1)
	{
		try
		{
			if (!this.m_eq && !this.m_eu)
			{
				if (base.InvokeRequired)
				{
					Invoke(new ab(q), A_0, A_1);
				}
				else
				{
					q();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Error in FIGraphControl.mMouseHasLeftCleanupTimer_Elapsed", a_);
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public void o(ad A_0)
	{
		ad ad2 = this.m_gv;
		ad ad3;
		do
		{
			ad3 = ad2;
			ad value = (ad)Delegate.Combine(ad3, A_0);
			ad2 = Interlocked.CompareExchange(ref this.m_gv, value, ad3);
		}
		while ((object)ad2 != ad3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void p(ad A_0)
	{
		ad ad2 = this.m_gv;
		ad ad3;
		do
		{
			ad3 = ad2;
			ad value = (ad)Delegate.Remove(ad3, A_0);
			ad2 = Interlocked.CompareExchange(ref this.m_gv, value, ad3);
		}
		while ((object)ad2 != ad3);
	}

	private void p(object A_0, ElapsedEventArgs A_1)
	{
		try
		{
			if (!av)
			{
				this.m_aq = default(z);
				aw = false;
				if (base.InvokeRequired)
				{
					Invoke(new ac(p), A_0, A_1);
				}
				else
				{
					g2();
					hb();
					this.m_gv?.Invoke();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.mMouseClickTimer_Elapsed", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void p()
	{
		if (!fu() && base.Visible)
		{
			hb();
		}
	}

	private void c5(object A_0, EventArgs A_1)
	{
		this.m_eu = true;
	}

	private void c3(object A_0, EventArgs A_1)
	{
		this.m_eu = false;
	}

	private void c2(object A_0, EventArgs A_1)
	{
		this.m_fz = this.m_fy.b;
	}

	private void c1(object A_0, EventArgs A_1)
	{
		try
		{
			em().Visible = false;
			this.m_fy.d = false;
			if (base.ActiveControl == em())
			{
				base.ActiveControl = null;
			}
			Invalidate();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Error in FIGraphControl.txtWaveLengthLimit_LostFocus", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void o(object A_0, KeyEventArgs A_1)
	{
		checked
		{
			try
			{
				if (A_1.KeyCode != Keys.Return)
				{
					return;
				}
				double num = iz.e(em().Text);
				if (this.m_fy.b == global::fl.f.b)
				{
					if (!(num < this.m_fy.e.b))
					{
						fz a_ = az;
						string A_2 = "GraphXRangeLimitWarning";
						global::fe.b(a_, hu.a(ref A_2), "Warning", i6.a(this));
						return;
					}
					this.m_fy.m((int)Math.Round(t(num)));
					this.m_fy.e.a = num;
				}
				else if (this.m_fy.b == global::fl.f.c)
				{
					if (!(num > this.m_fy.e.a))
					{
						fz a_2 = az;
						string A_2 = "GraphXRangeLimitWarning";
						global::fe.b(a_2, hu.a(ref A_2), "Warning", i6.a(this));
						return;
					}
					this.m_fy.n((int)Math.Round(t(num)));
					this.m_fy.e.b = num;
				}
				this.m_fv?.Invoke(this.m_fy.e);
				em().Visible = false;
				base.ActiveControl = null;
				Invalidate();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				az.c(global::fz.b.b, "Error in FIGraphControl.txtWaveLengthLimit_KeyDown", a_3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ab(object A_0, MouseEventArgs A_1)
	{
		try
		{
			if ((A_1.Button == MouseButtons.Right) & gb)
			{
				d1().Show(el(), checked(el().Location.X + el().Width), A_1.Location.Y);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Error in FIGraphControl.LabelOverlayCurve_MouseClick", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void o(Label A_0, int A_1)
	{
		if (this.m_c6 == A_1)
		{
			return;
		}
		int a_ = this.m_c6;
		this.m_c6 = A_1;
		this.m_e6 = 0.0;
		this.m_e7 = 0f;
		this.m_e8 = 0f;
		checked
		{
			if (this.m_e9 != null)
			{
				int num = this.m_e9.Length - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					this.m_e9[num2] = 0f;
				}
			}
			aq();
			ap();
			p(a_);
			hb();
			a<fx> a10 = bp[A_1];
			this.m_gh?.Invoke(a10.a, a10[0].ac(), global::r.d.a.b.a);
			a10 = null;
		}
	}

	private void o(Label A_0, int A_1, MouseEventArgs A_2)
	{
		this.m_dv = A_1;
		ep().DropDownItems.Clear();
		checked
		{
			int num = bp.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (bp[num2].j == null)
				{
					bp[num2].j = new List<string>();
				}
				if (bp[num2].r())
				{
					bp[num2].h = bh[0];
				}
				else if (bp[num2].s())
				{
					bp[num2].h = bh[1];
				}
				else
				{
					bp[num2].h = bh[2];
				}
				bp[num2].i = bh[1];
				if (bp[num2][0].ai() != null)
				{
					int num3 = bp[num2][0].ai().Count - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						bp[num2].j.Add(bh[2]);
					}
				}
			}
			List<fn> list = bp[A_1][0].q(bp[A_1].b, A_1, A_2: false);
			foreach (fn item in list)
			{
				string text = null;
				if (item.m())
				{
					text = bp[A_1].h;
				}
				else if (item.n())
				{
					text = bp[A_1].i;
				}
				else if (bp[A_1].j != null)
				{
					text = bp[A_1].j[item.q()];
				}
				string name = "Show " + item.k() + " - " + text;
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(name);
				toolStripMenuItem.Name = name;
				toolStripMenuItem.Tag = item;
				toolStripMenuItem.Checked = (item.m() && bp[A_1].u()) || (item.n() && bp[A_1].v()) || (item.o() && bp[A_1].r(item.q()));
				toolStripMenuItem.ForeColor = bp[A_1][0].q();
				toolStripMenuItem.Click += ai;
				ep().DropDownItems.Add(toolStripMenuItem);
			}
			dw().Show(A_0, A_0.Location.X + A_0.Width, A_2.Location.Y);
		}
	}

	private void aa(object A_0, MouseEventArgs A_1)
	{
		if (A_1.Button == MouseButtons.Right)
		{
			o((Label)A_0, 0, A_1);
		}
		else
		{
			o((Label)A_0, 0);
		}
	}

	private void z(object A_0, MouseEventArgs A_1)
	{
		if (A_1.Button == MouseButtons.Right)
		{
			o((Label)A_0, 1, A_1);
		}
		else
		{
			o((Label)A_0, 1);
		}
	}

	private void y(object A_0, MouseEventArgs A_1)
	{
		if (A_1.Button == MouseButtons.Right)
		{
			o((Label)A_0, 2, A_1);
		}
		else
		{
			o((Label)A_0, 2);
		}
	}

	private void x(object A_0, MouseEventArgs A_1)
	{
		if (A_1.Button == MouseButtons.Right)
		{
			o((Label)A_0, 3, A_1);
		}
		else
		{
			o((Label)A_0, 3);
		}
	}

	private void w(object A_0, MouseEventArgs A_1)
	{
		if (A_1.Button == MouseButtons.Right)
		{
			o((Label)A_0, 4, A_1);
		}
		else
		{
			o((Label)A_0, 4);
		}
	}

	private void v(object A_0, MouseEventArgs A_1)
	{
		if (A_1.Button == MouseButtons.Right)
		{
			o((Label)A_0, 5, A_1);
		}
		else
		{
			o((Label)A_0, 5);
		}
	}

	private void u(object A_0, MouseEventArgs A_1)
	{
		if (A_1.Button == MouseButtons.Right)
		{
			o((Label)A_0, 6, A_1);
		}
		else
		{
			o((Label)A_0, 6);
		}
	}

	private void t(object A_0, MouseEventArgs A_1)
	{
		if (A_1.Button == MouseButtons.Right)
		{
			o((Label)A_0, 7, A_1);
		}
		else
		{
			o((Label)A_0, 7);
		}
	}

	private void s(object A_0, MouseEventArgs A_1)
	{
		if (A_1.Button == MouseButtons.Right)
		{
			o((Label)A_0, 8, A_1);
		}
		else
		{
			o((Label)A_0, 8);
		}
	}

	private void r(object A_0, MouseEventArgs A_1)
	{
		if (A_1.Button == MouseButtons.Right)
		{
			o((Label)A_0, 9, A_1);
		}
		else
		{
			o((Label)A_0, 9);
		}
	}

	private void c0(object A_0, EventArgs A_1)
	{
		try
		{
			o(this.m_c6 >= 0 && this.m_c6 < bp.Count && bp[this.m_c6].r(), dq(), A_2: false, global::fl.h.a);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.mLegendLabel0_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b7(object A_0, EventArgs A_1)
	{
		this.m_d2[0] = !this.m_d2[0];
	}

	private void a5(object A_0, EventArgs A_1)
	{
		try
		{
			o(this.m_c6 >= 0 && this.m_c6 < bp.Count && (bp[this.m_c6].s() || bp[this.m_c6][0].ah() != null), dp(), A_2: true, global::fl.h.b);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.mLegendLabel1_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a2(object A_0, EventArgs A_1)
	{
		this.m_d2[1] = !this.m_d2[1];
	}

	private void at(object A_0, EventArgs A_1)
	{
		try
		{
			o(this.m_c6 >= 0 && this.m_c6 < bp.Count && (bp[this.m_c6].t() || bp[this.m_c6][0].ai() != null), @do(), A_2: false, global::fl.h.c);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.mLegendLabel2_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void @as(object A_0, EventArgs A_1)
	{
		try
		{
			o(d4(), d5(), c4);
			this.m_d5 = false;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.LabelLegend_MouseEnter", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ar(object A_0, EventArgs A_1)
	{
		try
		{
			o(eh(), ei(), c4);
			this.m_d6 = false;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.LabelOverlayCurve_MouseEnter", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void aq(object A_0, EventArgs A_1)
	{
		this.m_d2[2] = !this.m_d2[2];
	}

	private void o(bool A_0, bool A_1, bool A_2, h A_3)
	{
		if (A_0)
		{
			if (A_1)
			{
				this.m_f3 = !this.m_f3;
			}
			else
			{
				this.m_f1 = true;
				this.m_f4 = A_3;
				this.m_f2 = A_2;
			}
			@as();
			Invalidate();
		}
	}

	private void ap(object A_0, EventArgs A_1)
	{
		try
		{
			o(this.m_c6 >= 0 && this.m_c6 < bp.Count && bp[this.m_c6].r(), A_1: false, global::fl.h.a);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.mLegendLabel0_MouseHover", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ao(object A_0, EventArgs A_1)
	{
		try
		{
			o(this.m_c6 >= 0 && this.m_c6 < bp.Count && (bp[this.m_c6].s() || bp[this.m_c6][0].ah() != null), A_1: true, global::fl.h.b);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.mLegendLabel1_MouseHover", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void an(object A_0, EventArgs A_1)
	{
		try
		{
			o(this.m_c6 >= 0 && this.m_c6 < bp.Count && (bp[this.m_c6].t() || bp[this.m_c6][0].ai() != null), A_1: false, global::fl.h.c);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.mLegendLabel2_MouseHover", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void o(bool A_0, bool A_1, h A_2)
	{
		if (A_0 && !this.m_f3)
		{
			this.m_f1 = true;
			this.m_f4 = A_2;
			this.m_f2 = A_1;
			@as();
			Invalidate();
		}
	}

	private void am(object A_0, EventArgs A_1)
	{
		try
		{
			o(A_0: true);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.mLegendLabel_MouseLeave0", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void al(object A_0, EventArgs A_1)
	{
		try
		{
			o(this.m_c6 >= 0 && this.m_c6 < bp.Count && (bp[this.m_c6][0].ah() != null || bp[this.m_c6].s()));
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.mLegendLabel_MouseLeave1", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ak(object A_0, EventArgs A_1)
	{
		try
		{
			o(this.m_c6 >= 0 && this.m_c6 < bp.Count && (bp[this.m_c6][0].ai() != null || bp[this.m_c6].t()));
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.mLegendLabel_MouseLeave2", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void o(bool A_0)
	{
		if (A_0 && !this.m_f3)
		{
			this.m_f1 = false;
			@as();
			Invalidate();
		}
	}

	private void aj(object A_0, EventArgs A_1)
	{
		string item = q((float)this.m_fk.X).ToString("##0.000");
		fn fn2 = (fn)((ToolStripMenuItem)A_0).Tag;
		if (fn2.p())
		{
			if (fn2.m())
			{
				if (!this.m_fe.Contains(item))
				{
					this.m_fe.Add(item);
				}
			}
			else if (fn2.n())
			{
				if (!this.m_ff.Contains(item))
				{
					this.m_ff.Add(item);
				}
			}
			else if (fn2.o())
			{
				if (this.m_fg.Count == 0)
				{
					this.m_fg.Add(new List<string>());
				}
				if (!this.m_fg[fn2.q()].Contains(item))
				{
					this.m_fg[fn2.q()].Add(item);
				}
			}
		}
		else if (fn2.m())
		{
			if (!bp[fn2.l()][0].ad().Contains(item))
			{
				bp[fn2.l()][0].ad().Add(item);
				if (!this.m_fd[fn2.l()].b.Contains(item))
				{
					this.m_fd[fn2.l()].b.Add(item);
				}
			}
		}
		else if (fn2.n())
		{
			if (!bp[fn2.l()][0].ah().ad().Contains(item))
			{
				bp[fn2.l()][0].ah().ad().Add(item);
				if (!this.m_fd[fn2.l()].c.Contains(item))
				{
					this.m_fd[fn2.l()].c.Add(item);
				}
			}
		}
		else if (fn2.o() && !bp[fn2.l()][0].ai()[fn2.q()].ad().Contains(item))
		{
			bp[fn2.l()][0].ai()[fn2.q()].ad().Add(item);
			if (this.m_fd[fn2.l()].d.Count == 0)
			{
				this.m_fd[fn2.l()].d.Add(new List<string>());
			}
			if (!this.m_fd[fn2.l()].d[fn2.q()].Contains(item))
			{
				this.m_fd[fn2.l()].d[fn2.q()].Add(item);
			}
		}
		Invalidate();
	}

	private void o()
	{
		checked
		{
			int num = bp.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (bp[num2][0].ah() != null)
				{
					if (da())
					{
						bp[num2][0].ah().r = global::fl.g.a;
					}
					else
					{
						bp[num2][0].ah().r = global::fl.g.c;
					}
				}
				if (bp[num2][0].ai() != null && bp[num2][0].ai().Count > 0)
				{
					if (bp[num2].t() || dm())
					{
						bp[num2][0].ai()[0].r = global::fl.g.a;
					}
					else
					{
						bp[num2][0].ai()[0].r = global::fl.g.b;
					}
				}
			}
		}
	}

	private void ai(object A_0, EventArgs A_1)
	{
		fn fn2 = (fn)((ToolStripMenuItem)A_0).Tag;
		ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)A_0;
		a<fx> a10 = bp[fn2.l()];
		fn fn3 = fn2;
		if (fn3.m())
		{
			a10.r(!toolStripMenuItem.Checked);
		}
		else if (fn3.n())
		{
			a10.s(!toolStripMenuItem.Checked);
		}
		else if (fn3.o())
		{
			a10.r(fn3.q(), !toolStripMenuItem.Checked);
		}
		fn3 = null;
		bu = (dd() && !da()) || (di() > 0 && !da()) || (dd() && a10.u());
		g4();
		o();
		toolStripMenuItem.Checked = !toolStripMenuItem.Checked;
		this.m_e5 = true;
		aq();
		ao();
		Invalidate();
	}

	private void q(object A_0, MouseEventArgs A_1)
	{
		try
		{
			cx = true;
			cy = A_1.X;
			cz = A_1.Y;
			if (A_0 == d5() || A_0 == d6() || A_0 == d4())
			{
				this.m_c0 = d4();
				this.m_c1 = this.m_c2;
			}
			else
			{
				this.m_c0 = eh();
				this.m_c1 = this.m_c3;
			}
			this.m_c0.BackColor = Color.FromArgb(255, 199, 60);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.PanelLegends_MouseDown", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void p(object A_0, MouseEventArgs A_1)
	{
		try
		{
			if (global::e.a().AutoPositionLegends && A_0 != d5() && A_0 != d6() && A_0 != d4() && A_0 != ei() && A_0 != ej())
			{
				eh();
			}
			cx = false;
			if (this.m_c0 != null)
			{
				this.m_c0.BackColor = Color.FromArgb(255, 234, 179);
			}
			o((Panel)A_0);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.PanelLegends_MouseUp", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ah(object A_0, EventArgs A_1)
	{
		try
		{
			if (A_0 == d4())
			{
				o(d4(), d5(), c4);
				this.m_d5 = false;
			}
			else
			{
				o(eh(), ei(), this.m_c5);
				this.m_d6 = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Exception in FIControlGraph.PanelLegendOuter_MouseLeave", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void o(Panel A_0, Panel A_1, int A_2)
	{
		Panel panel = A_0;
		checked
		{
			if (panel.Width - A_1.Width > A_2)
			{
				try
				{
					ab();
					panel.Visible = false;
					panel.Left += 5;
					panel.Top += 5;
					A_1.Location = new Point(0, 0);
					panel.Width -= 10;
					panel.Height -= 10;
				}
				finally
				{
					ac();
				}
				panel.Visible = true;
			}
			panel = null;
		}
	}

	private void o(object A_0, MouseEventArgs A_1)
	{
		checked
		{
			try
			{
				if (cx)
				{
					int num = ((cy <= 0) ? (this.m_c0.Location.X + A_1.X) : (this.m_c0.Location.X + A_1.X - cy));
					int num2 = b3 - this.m_c0.Controls[0].Left;
					int num3 = b4 - this.m_c0.Width + this.m_c0.Width - (this.m_c0.Controls[0].Left + this.m_c0.Controls[0].Width) + 1;
					if (num < num2)
					{
						num = num2;
					}
					else if (num > num3)
					{
						num = num3;
					}
					int num4 = ((cz <= 0) ? (this.m_c0.Location.Y + A_1.Y) : (this.m_c0.Location.Y + A_1.Y - cz));
					int num5 = b5 - this.m_c0.Controls[0].Top;
					int num6 = b1 - this.m_c0.Height + this.m_c0.Height - (this.m_c0.Controls[0].Top + this.m_c0.Controls[0].Height) + 1;
					if (num4 < num5)
					{
						num4 = num5;
					}
					else if (num4 > num6)
					{
						num4 = num6;
					}
					this.m_c0.Location = new Point(num, num4);
					o(this.m_c0, this.m_c1);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				az.c(global::fz.b.b, "Exception in FIControlGraph.PanelLegends_MouseMove", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ag(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_ge?.Invoke(bp[this.m_dv].a);
		}
		catch (ao ao2)
		{
			ProjectData.SetProjectError(ao2);
			ao a_ = ao2;
			az.c(global::fz.b.b, "Error in OpenCurveToolStripMenuItem_Click", a_);
			fz a_2 = az;
			string A_2 = "ErrorMessageProcessNotResponding";
			global::fe.b(a_2, hu.a(ref A_2), i6.a(this));
			ProjectData.ClearProjectError();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			az.c(global::fz.b.b, "Error in OpenCurveToolStripMenuItem_Click", a_3);
			global::fe.b(az, "Error in OpenCurveToolStripMenuItem_Click", i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void af(object A_0, EventArgs A_1)
	{
		try
		{
			a<fx> a10 = bp[this.m_dv];
			this.m_gi?.Invoke(a10.a, global::r.d.a.b.a);
		}
		catch (ao ao2)
		{
			ProjectData.SetProjectError(ao2);
			ao a_ = ao2;
			az.c(global::fz.b.b, "Error in PropertiesToolStripMenuItem_Click", a_);
			fz a_2 = az;
			string A_2 = "ErrorMessageProcessNotResponding";
			global::fe.b(a_2, hu.a(ref A_2), i6.a(this));
			ProjectData.ClearProjectError();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			az.c(global::fz.b.b, "Error in PropertiesToolStripMenuItem_Click", a_3);
			global::fe.b(az, "Error in PropertiesToolStripMenuItem_Click", i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void ae(object A_0, EventArgs A_1)
	{
		try
		{
			fe fe2 = new fe(az);
			a<fx> a10 = bp[this.m_dv];
			fe2 = new fe(az);
			fe.a a11 = new fe.a();
			string A_2 = "RenameSpectrumPrompt";
			a11.w(string.Format(hu.a(ref A_2)));
			a11.w(MsgBoxStyle.OkCancel);
			a11.ad(a10.b);
			a11.w(global::fe.b.a);
			a11.x("Information");
			a11.y("OKString");
			a11.aa("CancelString");
			a11.w(base.ParentForm);
			if (fe2.b(a11) == DialogResult.OK)
			{
				a10.b = a11.ag();
				aq();
				this.m_gj?.Invoke(this, a10.b, a10.a, global::r.d.a.b.a);
			}
		}
		catch (ao ao2)
		{
			ProjectData.SetProjectError(ao2);
			ao a_ = ao2;
			az.c(global::fz.b.b, "Error in RenameCurveToolStripMenuItem_Click", a_);
			fz a_2 = az;
			string A_2 = "ErrorMessageProcessNotResponding";
			global::fe.b(a_2, hu.a(ref A_2), i6.a(this));
			ProjectData.ClearProjectError();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			az.c(global::fz.b.b, "Error in RenameCurveToolStripMenuItem_Click", a_3);
			global::fe.b(az, "Error in RenameCurveToolStripMenuItem_Click", i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void ad(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_gf?.Invoke(this.m_em, bp[this.m_dv].a, bp[this.m_dv][0].ac());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Error in SaveCurveToolStripMenuItem_Click", a_);
			global::fe.b(az, "Error in SaveCurveToolStripMenuItem_Click", i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void ac(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_gg?.Invoke(this.m_em, this.m_ec, this.m_d9.ac());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Error in SaveOverlayCurveToolStripMenuItem_Click", a_);
			global::fe.b(az, "Error in SaveOverlayCurveToolStripMenuItem_Click", i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void o(object A_0, ElapsedEventArgs A_1)
	{
		bool flag = false;
		try
		{
			if (!this.m_gz)
			{
				flag = true;
				this.m_gz = true;
				hk();
			}
		}
		finally
		{
			if (flag)
			{
				this.m_gz = false;
				er.Set();
			}
		}
	}

	public void hk()
	{
		if (this.m_g1 == null)
		{
			Interlocked.CompareExchange(ref this.m_g1, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(this.m_g1, ref lockTaken);
			if (this.m_g1.State == 0)
			{
				this.m_g1.State = 2;
				this.m_g0 = null;
			}
			else if (this.m_g1.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			this.m_g1.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(this.m_g1);
			}
		}
		try
		{
			if (base.InvokeRequired)
			{
				ae method = hk;
				this.m_g0 = BeginInvoke(method);
				EndInvoke(this.m_g0);
			}
			else if (base.IsHandleCreated)
			{
				this.m_e5 = global::e.a().AutoPositionLegends;
				Invalidate();
				Update();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			gx().c(global::fz.b.b, "Exception Thrown", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ab(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				new fe(az);
				fe obj = new fe(az);
				fe.a a10 = new fe.a();
				a10.w("Please enter the wavelength");
				a10.w(MsgBoxStyle.OkCancel);
				a10.ad("");
				a10.w(global::fe.b.a);
				a10.x("Information");
				a10.y("OKString");
				a10.aa("CancelString");
				a10.w(base.ParentForm);
				if (obj.b(a10) != DialogResult.OK)
				{
					return;
				}
				string text = a10.ag();
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)A_0;
				if (Operators.CompareString(toolStripMenuItem.OwnerItem.ToString(), "All Curves", TextCompare: false) != 0 && Operators.CompareString(toolStripMenuItem.OwnerItem.ToString(), "Active Curve", TextCompare: false) != 0)
				{
					fn fn2 = (fn)toolStripMenuItem.Tag;
					if (fn2.p())
					{
						if (fn2.m())
						{
							if (!this.m_fe.Contains(text))
							{
								this.m_fe.Add(text);
							}
						}
						else if (fn2.n())
						{
							if (!this.m_ff.Contains(text))
							{
								this.m_ff.Add(text);
							}
						}
						else if (fn2.o())
						{
							if (this.m_fg.Count == 0)
							{
								this.m_fg.Add(new List<string>());
							}
							if (!this.m_fg[fn2.q()].Contains(text))
							{
								this.m_fg[fn2.q()].Add(text);
							}
						}
					}
					else if (fn2.m())
					{
						if (!bp[fn2.l()][0].ad().Contains(text))
						{
							bp[fn2.l()][0].ad().Add(text);
							this.m_fd[fn2.l()].b.Add(text);
						}
					}
					else if (fn2.n())
					{
						if (!bp[fn2.l()][0].ah().ad().Contains(text))
						{
							bp[fn2.l()][0].ah().ad().Add(text);
							this.m_fd[fn2.l()].c.Add(text);
						}
					}
					else if (fn2.o() && !bp[fn2.l()][0].ai()[fn2.q()].ad().Contains(text))
					{
						bp[fn2.l()][0].ai()[fn2.q()].ad().Add(text);
						this.m_fd[fn2.l()].d[fn2.q()].Add(text);
					}
				}
				else
				{
					if (Operators.CompareString(toolStripMenuItem.OwnerItem.ToString(), "All Curves", TextCompare: false) == 0)
					{
						int num = bp.Count - 1;
						for (int num2 = 0; num2 <= num; num2++)
						{
							if (bp[num2][0].y() > iz.e(text) && bp[num2][0].z() < iz.e(text))
							{
								bp[num2].r(text);
								this.m_fd[num2].f(text);
							}
							else
							{
								ref fz a_ = ref az;
								Point A_2 = i6.a(this);
								global::fe.b(ref a_, "the wavelength location is out of the curve wavelength", ref A_2);
							}
						}
					}
					else if (bp[this.m_c6][0].y() > iz.e(text) && bp[this.m_c6][0].z() < iz.e(text))
					{
						bp[this.m_c6].r(text);
					}
					else
					{
						ref fz a_2 = ref az;
						Point A_2 = i6.a(this);
						global::fe.b(ref a_2, "the wavelength location is out of the curve wavelength", ref A_2);
					}
					if (this.m_d9 != null)
					{
						if (!this.m_fe.Contains(text))
						{
							this.m_fe.Add(text);
						}
						if (this.m_d9.ah() != null && !this.m_ff.Contains(text))
						{
							this.m_ff.Add(text);
						}
						if (this.m_d9.ai() != null)
						{
							int num3 = this.m_d9.ai().Count - 1;
							for (int num4 = 0; num4 <= num3; num4++)
							{
								if (this.m_d9.ai()[num4] != null && !this.m_fg[num4].Contains(text))
								{
									this.m_fg[num4].Add(text);
								}
							}
						}
					}
				}
				Invalidate();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				az.c(global::fz.b.b, "Error in AddDotsToSpecLocForCurves", a_3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void aa(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (bp.Count == 0)
				{
					return;
				}
				string text = q((float)this.m_fk.X).ToString("##0.00");
				if (this.m_f1)
				{
					if (dq() && this.m_f3)
					{
						bp[this.m_c6][0].ad().Add(text);
					}
					else if (dp() && this.m_f3)
					{
						bp[this.m_c6][0].ah().ad().Add(text);
					}
					else if (@do() && this.m_f3)
					{
						int num = bp[this.m_c6][0].ai().Count - 1;
						for (int num2 = 0; num2 <= num; num2++)
						{
							bp[this.m_c6][0].ai()[0].ad().Add(text);
						}
						_ = null;
					}
				}
				else
				{
					bp[this.m_c6].r(text);
				}
				if (this.m_d9 != null)
				{
					if (!this.m_fe.Contains(text))
					{
						this.m_fe.Add(text);
					}
					if (this.m_d9.ah() != null && !this.m_ff.Contains(text))
					{
						this.m_ff.Add(text);
					}
					if (this.m_d9.ai() != null)
					{
						int num3 = this.m_d9.ai().Count - 1;
						for (int num4 = 0; num4 <= num3; num4++)
						{
							if (this.m_d9.ai()[num4] != null && !this.m_fg[num4].Contains(text))
							{
								this.m_fg[num4].Add(text);
							}
						}
					}
				}
				Invalidate();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				az.c(global::fz.b.b, "Error in AddDotsHereForActive", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void z(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				string text = q((float)this.m_fk.X).ToString("##0.00");
				int num = bp.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					this.m_fd[num2].f(text);
				}
				int num3 = bp.Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					bp[num4].r(text);
				}
				if (this.m_d9 != null)
				{
					if (!this.m_fe.Contains(text))
					{
						this.m_fe.Add(text);
					}
					if (this.m_d9.ah() != null && !this.m_ff.Contains(text))
					{
						this.m_ff.Add(text);
					}
					if (this.m_d9.ai() != null)
					{
						int num5 = this.m_d9.ai().Count - 1;
						for (int num6 = 0; num6 <= num5; num6++)
						{
							if (this.m_d9.ai()[num6] != null && !this.m_fg[num6].Contains(text))
							{
								this.m_fg[num6].Add(text);
							}
						}
					}
				}
				Invalidate();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				az.c(global::fz.b.b, "Error in AddDotsHereForActive", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void y(object A_0, EventArgs A_1)
	{
		try
		{
			string A_2 = null;
			if (bp.Count == 0)
			{
				return;
			}
			int A_3 = default(int);
			bool A_4 = default(bool);
			int A_5 = default(int);
			int A_6 = default(int);
			o(this.m_fk.X, this.m_fk.Y, ref A_3, ref A_4, ref A_5, ref A_6, ref A_2);
			if (A_3 > -1)
			{
				this.m_fd[A_3].f(A_3, A_4, A_6, A_2);
				if (A_4)
				{
					List<string> list = bp[A_3][0].ah().ad();
					if (list.Count > 0)
					{
						list.RemoveAt(A_5);
					}
					list = null;
				}
				else if (A_6 == -1)
				{
					List<string> list2 = bp[A_3][0].ad();
					if (list2.Count > 0)
					{
						list2.RemoveAt(A_5);
					}
					list2 = null;
				}
				else if (bp[A_3][0].ai() != null)
				{
					List<string> list3 = bp[A_3][0].ai()[A_6].ad();
					if (list3.Count > 0)
					{
						list3.RemoveAt(A_5);
					}
					list3 = null;
				}
			}
			else if (A_4)
			{
				List<string> list4 = this.m_ff;
				if (list4.Count > 0)
				{
					list4.RemoveAt(A_5);
				}
				list4 = null;
			}
			else if (A_6 == -1)
			{
				if (this.m_fe.Count > 0)
				{
					this.m_fe.RemoveAt(A_5);
				}
			}
			else
			{
				List<string> list5 = this.m_fg[A_6];
				if (list5.Count > 0)
				{
					list5.RemoveAt(A_5);
				}
				list5 = null;
			}
			Invalidate();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Error in DeleteClosestDot", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void x(object A_0, EventArgs A_1)
	{
		try
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)A_0;
			fn fn2 = (fn)toolStripMenuItem.Tag;
			if (Operators.CompareString(toolStripMenuItem.Text, global::ey.t(), TextCompare: false) != 0 && Operators.CompareString(toolStripMenuItem.Text, global::ey.s(), TextCompare: false) != 0)
			{
				string item = toolStripMenuItem.Text.Substring(0, toolStripMenuItem.Text.IndexOf(" (nm)"));
				if (fn2.p())
				{
					if (fn2.m())
					{
						if (this.m_fe.Contains(item))
						{
							this.m_fe.Remove(item);
						}
					}
					else if (fn2.n())
					{
						if (this.m_ff.Contains(item))
						{
							this.m_ff.Remove(item);
						}
					}
					else if (fn2.o() && this.m_fg != null && this.m_fg.Count > 0 && this.m_fg[fn2.q()].Contains(item))
					{
						this.m_fg[fn2.q()].Remove(item);
					}
				}
				else if (fn2.m())
				{
					if (bp[fn2.l()][0].ad().Contains(item))
					{
						bp[fn2.l()][0].ad().Remove(item);
					}
				}
				else if (fn2.n())
				{
					if (bp[fn2.l()][0].ah().ad().Contains(item))
					{
						bp[fn2.l()][0].ah().ad().Remove(item);
					}
				}
				else if (fn2.o() && bp[fn2.l()][0].ai()[fn2.q()].ad().Contains(item))
				{
					bp[fn2.l()][0].ai()[fn2.q()].ad().Remove(item);
				}
			}
			else if (Operators.CompareString(toolStripMenuItem.Text, global::ey.t(), TextCompare: false) == 0)
			{
				if (fn2.p())
				{
					if (fn2.m())
					{
						this.m_fe.Clear();
					}
					if (fn2.n())
					{
						this.m_ff.Clear();
					}
					if (fn2.o())
					{
						this.m_fg[fn2.q()].Clear();
					}
				}
				else
				{
					if (fn2.m())
					{
						bp[fn2.l()][0].ad().Clear();
					}
					if (fn2.n())
					{
						bp[fn2.l()][0].ah().ad().Clear();
					}
					if (fn2.o())
					{
						bp[fn2.l()][0].ai()[fn2.q()].ad().Clear();
					}
				}
			}
			else
			{
				o(this.m_fk.X, this.m_fk.Y, fn2.l(), fn2.m(), fn2.n(), fn2.o(), fn2.p(), fn2.q());
			}
			Invalidate();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Error in DeleteDotsFromACurve", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void w(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				int num = bp.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					bp[num2].x();
				}
				int num3 = bp.Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					this.m_fd[num4].f();
				}
				if (this.m_d9 != null)
				{
					if (this.m_fe.Count > 0)
					{
						this.m_fe.Clear();
					}
					if (this.m_ff.Count > 0)
					{
						this.m_ff.Clear();
					}
					if (this.m_fg.Count > 0)
					{
						int num5 = this.m_fg.Count - 1;
						for (int num6 = 0; num6 <= num5; num6++)
						{
							this.m_fg[num6].Clear();
						}
					}
				}
				Invalidate();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				az.c(global::fz.b.b, "Error in DeleteAllDots", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void v(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				ToolStripMenuItem obj = (ToolStripMenuItem)A_0;
				bool flag = !obj.OwnerItem.ToString().Contains("Delete");
				if (Operators.CompareString(obj.Text, "All Curves", TextCompare: false) == 0)
				{
					int num = bp.Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						bp[num2].t(flag);
					}
				}
				else
				{
					bool a_ = flag && !flag;
					int num3 = bp.Count - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						bp[num4].t(a_);
					}
					bp[this.m_c6].t(flag);
				}
				if (this.m_d9 != null)
				{
					this.m_fh = flag;
					this.m_fi = flag;
					if (this.m_fj.Count > 0)
					{
						int num5 = this.m_fj.Count - 1;
						for (int num6 = 0; num6 <= num5; num6++)
						{
							this.m_fj[num6] = flag;
						}
					}
				}
				Invalidate();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				az.c(global::fz.b.b, "Error in ShowHideCursorsForCurves", a_2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void u(object A_0, EventArgs A_1)
	{
		new bd().a(az);
		u();
	}

	private void t(object A_0, EventArgs A_1)
	{
		try
		{
			ToolStripMenuItem obj = (ToolStripMenuItem)A_0;
			fn fn2 = (fn)obj.Tag;
			bool flag = Operators.CompareString(obj.OwnerItem.ToString(), "Track Value at Moving Cursor", TextCompare: false) == 0;
			if (fn2.p())
			{
				if (fn2.m())
				{
					this.m_fh = flag;
				}
				if (fn2.n())
				{
					this.m_fi = flag;
				}
				if (fn2.o())
				{
					if (this.m_fj.Count == 0)
					{
						this.m_fj.Add(item: false);
					}
					this.m_fj[fn2.q()] = flag;
				}
			}
			else
			{
				if (fn2.m())
				{
					bp[fn2.l()][0].u(flag);
				}
				if (fn2.n())
				{
					bp[fn2.l()][0].ah().u(flag);
				}
				if (fn2.o())
				{
					bp[fn2.l()][0].ai()[fn2.q()].u(flag);
				}
			}
			Invalidate();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Error in ChangeCurveMovingCursor", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void s(object A_0, EventArgs A_1)
	{
		try
		{
			if (this.m_fn)
			{
				ev().DropDownItems.Clear();
				o(ev(), global::fl.i.a);
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(global::ey.x());
				ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(string.Format(global::ey.w(), ((float)q((float)this.m_fk.X)).ToString("##0.00") + " (nm)"));
				ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem(global::ey.v());
				toolStripMenuItem2.Click += z;
				toolStripMenuItem3.Click += ab;
				toolStripMenuItem.DropDownItems.Add(toolStripMenuItem2);
				toolStripMenuItem.DropDownItems.Add(toolStripMenuItem3);
				ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem(global::ey.u());
				ToolStripMenuItem toolStripMenuItem5 = new ToolStripMenuItem(string.Format(global::ey.w(), ((float)q((float)this.m_fk.X)).ToString("##0.00") + " (nm)"));
				ToolStripMenuItem toolStripMenuItem6 = new ToolStripMenuItem(global::ey.v());
				toolStripMenuItem5.Click += aa;
				toolStripMenuItem6.Click += ab;
				toolStripMenuItem4.DropDownItems.Add(toolStripMenuItem5);
				toolStripMenuItem4.DropDownItems.Add(toolStripMenuItem6);
				ev().DropDownItems.Add(toolStripMenuItem);
				ev().DropDownItems.Add(toolStripMenuItem4);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Error in TrackValuesToolStripMenuItem_DropDownOpening", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void r(object A_0, EventArgs A_1)
	{
		try
		{
			ex().DropDownItems.Clear();
			o(ex(), global::fl.i.b);
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(global::ey.t());
			ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(global::ey.s());
			toolStripMenuItem.Click += w;
			toolStripMenuItem2.Click += y;
			ex().DropDownItems.Add(toolStripMenuItem);
			ex().DropDownItems.Add(toolStripMenuItem2);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Error in DeleteTrackingValuesToolStripMenuItem_DropDownOpening", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void q(object A_0, EventArgs A_1)
	{
		try
		{
			ez().DropDownItems.Clear();
			o(ez(), global::fl.i.c);
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(global::ey.x());
			ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(global::ey.u());
			ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem(global::ey.r());
			toolStripMenuItem.Click += v;
			toolStripMenuItem2.Click += v;
			toolStripMenuItem3.Click += u;
			ez().DropDownItems.Add(toolStripMenuItem);
			ez().DropDownItems.Add(toolStripMenuItem2);
			ez().DropDownItems.Add(toolStripMenuItem3);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Error in TrackMovingCursorToolStripMenuItem_DropDownOpening", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void p(object A_0, EventArgs A_1)
	{
		try
		{
			e0().DropDownItems.Clear();
			o(e0(), global::fl.i.d);
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(global::ey.x());
			ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(global::ey.u());
			toolStripMenuItem.Click += v;
			toolStripMenuItem2.Click += v;
			e0().DropDownItems.Add(toolStripMenuItem);
			e0().DropDownItems.Add(toolStripMenuItem2);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Error in DeleteTrackingAtMovingCursorToolStripMenuItem_DropDownOpening", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		try
		{
			t();
			s();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(global::fz.b.b, "Error in FIControlGraph_HandleDestroyed", a_);
			ProjectData.ClearProjectError();
		}
	}

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}
}
