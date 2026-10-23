using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Filmetrics.FIMatFileDBService;
using Filmetrics.My;
using Filmetrics.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class f4 : UserControl
{
	internal enum a
	{
		a,
		b,
		c
	}

	private enum b
	{
		a,
		b,
		c,
		d
	}

	private enum c
	{
		a,
		b,
		c,
		d
	}

	private class d
	{
		public c a;

		public global::r.d.a.b b;

		public DateTime c;

		public bool d;

		public int e;

		public int f;
	}

	public delegate void e(Guid A_0, string A_1, bool A_2);

	public delegate void f(bool A_0);

	public delegate void g(Size A_0);

	public delegate void h();

	public delegate void i(string A_0, f4 A_1);

	public delegate void j(int A_0, f4 A_1);

	public delegate void k(double A_0, bool A_1, bool A_2);

	public delegate void l(ulong A_0, ulong A_1);

	private enum m
	{
		a,
		b
	}

	private delegate void n(global::r.d A_0, bool A_1, global::r.d.a.b A_2);

	private delegate void o(global::r.c A_0, bool A_1);

	private delegate void p();

	private delegate void q();

	public delegate void r(object A_0, ElapsedEventArgs A_1);

	private delegate void s();

	private delegate void t(object A_0, ElapsedEventArgs A_1);

	private IContainer m_a;

	[CompilerGenerated]
	private fl m_b;

	[CompilerGenerated]
	private fl m_c;

	[CompilerGenerated]
	private fl m_d;

	[CompilerGenerated]
	private ComboBox m_e;

	[CompilerGenerated]
	private Label m_f;

	[CompilerGenerated]
	private Button m_g;

	[CompilerGenerated]
	private Button m_h;

	[CompilerGenerated]
	private e1 m_i;

	[CompilerGenerated]
	private Button m_j;

	[CompilerGenerated]
	private VScrollBar m_k;

	[CompilerGenerated]
	private HScrollBar m_l;

	[CompilerGenerated]
	private TrackBar m_m;

	[CompilerGenerated]
	private Label m_n;

	[CompilerGenerated]
	private Button m_o;

	[CompilerGenerated]
	private Button m_p;

	[CompilerGenerated]
	private Panel m_q;

	[CompilerGenerated]
	private PictureBox m_r;

	[CompilerGenerated]
	private PictureBox m_s;

	[CompilerGenerated]
	private TabControl m_t;

	[CompilerGenerated]
	private TabPage m_u;

	[CompilerGenerated]
	private TabPage m_v;

	[CompilerGenerated]
	private Button m_w;

	[CompilerGenerated]
	private TrackBar m_x;

	[CompilerGenerated]
	private Button m_y;

	[CompilerGenerated]
	private Label m_z;

	[CompilerGenerated]
	private ToolTip m_aa;

	[CompilerGenerated]
	private ContextMenuStrip m_ab;

	[CompilerGenerated]
	private ToolStripMenuItem m_ac;

	[CompilerGenerated]
	private ContextMenuStrip m_ad;

	[CompilerGenerated]
	private ToolStripMenuItem m_ae;

	[CompilerGenerated]
	private Button m_af;

	[CompilerGenerated]
	private TableLayoutPanel m_ag;

	[CompilerGenerated]
	private GroupBox m_ah;

	[CompilerGenerated]
	private TableLayoutPanel m_ai;

	[CompilerGenerated]
	private Label m_aj;

	[CompilerGenerated]
	private Label m_ak;

	[CompilerGenerated]
	private Label m_al;

	[CompilerGenerated]
	private Label m_am;

	[CompilerGenerated]
	private Label m_an;

	[CompilerGenerated]
	private Label m_ao;

	[CompilerGenerated]
	private Label m_ap;

	[CompilerGenerated]
	private Label m_aq;

	[CompilerGenerated]
	private Button m_ar;

	[CompilerGenerated]
	private GroupBox m_as;

	[CompilerGenerated]
	private Button m_at;

	[CompilerGenerated]
	private Button m_au;

	[CompilerGenerated]
	private Label m_av;

	[CompilerGenerated]
	private Button m_aw;

	[CompilerGenerated]
	private GroupBox m_ax;

	[CompilerGenerated]
	private TableLayoutPanel m_ay;

	[CompilerGenerated]
	private PictureBox m_az;

	[CompilerGenerated]
	private Panel m_a0;

	[CompilerGenerated]
	private TableLayoutPanel m_a1;

	[CompilerGenerated]
	private Label m_a2;

	[CompilerGenerated]
	private Label m_a3;

	[CompilerGenerated]
	private Label m_a4;

	[CompilerGenerated]
	private Label m_a5;

	[CompilerGenerated]
	private Label m_a6;

	[CompilerGenerated]
	private Label m_a7;

	[CompilerGenerated]
	private TableLayoutPanel m_a8;

	[CompilerGenerated]
	private Label m_a9;

	[CompilerGenerated]
	private Label m_ba;

	[CompilerGenerated]
	private Label m_bb;

	[CompilerGenerated]
	private Label m_bc;

	[CompilerGenerated]
	private Label m_bd;

	[CompilerGenerated]
	private Label m_be;

	[CompilerGenerated]
	private GroupBox m_bf;

	[CompilerGenerated]
	private TableLayoutPanel m_bg;

	[CompilerGenerated]
	private TableLayoutPanel m_bh;

	[CompilerGenerated]
	private Label m_bi;

	[CompilerGenerated]
	private Label m_bj;

	[CompilerGenerated]
	private Label m_bk;

	[CompilerGenerated]
	private Label m_bl;

	[CompilerGenerated]
	private Label m_bm;

	[CompilerGenerated]
	private Label m_bn;

	[CompilerGenerated]
	private PictureBox m_bo;

	[CompilerGenerated]
	private Panel m_bp;

	[CompilerGenerated]
	private TableLayoutPanel m_bq;

	[CompilerGenerated]
	private Label m_br;

	[CompilerGenerated]
	private Label m_bs;

	[CompilerGenerated]
	private Label m_bt;

	[CompilerGenerated]
	private Label m_bu;

	[CompilerGenerated]
	private Label m_bv;

	[CompilerGenerated]
	private Label m_bw;

	[CompilerGenerated]
	private TabControl m_bx;

	[CompilerGenerated]
	private TabPage m_by;

	[CompilerGenerated]
	private Button m_bz;

	[CompilerGenerated]
	private Label m_b0;

	[CompilerGenerated]
	private Button m_b1;

	[CompilerGenerated]
	private TabPage m_b2;

	[CompilerGenerated]
	private Button m_b3;

	[CompilerGenerated]
	private Label m_b4;

	[CompilerGenerated]
	private Button m_b5;

	[CompilerGenerated]
	private GroupBox m_b6;

	[CompilerGenerated]
	private Button m_b7;

	[CompilerGenerated]
	private Label m_b8;

	[CompilerGenerated]
	private Button m_b9;

	[CompilerGenerated]
	private GroupBox m_ca;

	[CompilerGenerated]
	private Label m_cb;

	[CompilerGenerated]
	private Label m_cc;

	[CompilerGenerated]
	private Button m_cd;

	[CompilerGenerated]
	private Label m_ce;

	[CompilerGenerated]
	private Label m_cf;

	[CompilerGenerated]
	private Label m_cg;

	[CompilerGenerated]
	private Label m_ch;

	[CompilerGenerated]
	private Label m_ci;

	[CompilerGenerated]
	private ProgressBar m_cj;

	[CompilerGenerated]
	private Button m_ck;

	[CompilerGenerated]
	private GroupBox m_cl;

	[CompilerGenerated]
	private Button m_cm;

	[CompilerGenerated]
	private Button m_cn;

	[CompilerGenerated]
	private Button m_co;

	[CompilerGenerated]
	private TableLayoutPanel m_cp;

	[CompilerGenerated]
	private Label m_cq;

	[CompilerGenerated]
	private ComboBox m_cr;

	[CompilerGenerated]
	private PictureBox m_cs;

	[CompilerGenerated]
	private GroupBox m_ct;

	[CompilerGenerated]
	private Button m_cu;

	[CompilerGenerated]
	private Button m_cv;

	[CompilerGenerated]
	private Label m_cw;

	[CompilerGenerated]
	private Label m_cx;

	[CompilerGenerated]
	private Label m_cy;

	[CompilerGenerated]
	private RichTextBox m_cz;

	[CompilerGenerated]
	private Button m_c0;

	[CompilerGenerated]
	private GroupBox m_c1;

	[CompilerGenerated]
	private TextBox m_c2;

	[CompilerGenerated]
	private GroupBox m_c3;

	[CompilerGenerated]
	private TableLayoutPanel m_c4;

	[CompilerGenerated]
	private Label m_c5;

	[CompilerGenerated]
	private hx m_c6;

	[CompilerGenerated]
	private Label m_c7;

	[CompilerGenerated]
	private hx m_c8;

	[CompilerGenerated]
	private PictureBox m_c9;

	[CompilerGenerated]
	private PictureBox m_da;

	[CompilerGenerated]
	private PictureBox m_db;

	[CompilerGenerated]
	private PictureBox m_dc;

	[CompilerGenerated]
	private PictureBox m_dd;

	[CompilerGenerated]
	private PictureBox m_de;

	[CompilerGenerated]
	private PictureBox m_df;

	[CompilerGenerated]
	private PictureBox m_dg;

	[CompilerGenerated]
	private PictureBox m_dh;

	[CompilerGenerated]
	private Label m_di;

	[CompilerGenerated]
	private TableLayoutPanel m_dj;

	[CompilerGenerated]
	private TableLayoutPanel m_dk;

	[CompilerGenerated]
	private TableLayoutPanel m_dl;

	[CompilerGenerated]
	private Panel m_dm;

	[CompilerGenerated]
	private er m_dn;

	[CompilerGenerated]
	private TableLayoutPanel m_do;

	[CompilerGenerated]
	private TableLayoutPanel m_dp;

	[CompilerGenerated]
	private TableLayoutPanel m_dq;

	[CompilerGenerated]
	private TableLayoutPanel m_dr;

	[CompilerGenerated]
	private TableLayoutPanel m_ds;

	[CompilerGenerated]
	private TableLayoutPanel m_dt;

	[CompilerGenerated]
	private TableLayoutPanel m_du;

	[CompilerGenerated]
	private Button m_dv;

	[CompilerGenerated]
	private Button m_dw;

	[CompilerGenerated]
	private Button m_dx;

	[CompilerGenerated]
	private Button m_dy;

	[CompilerGenerated]
	private Panel m_dz;

	[CompilerGenerated]
	private Label m_d0;

	[CompilerGenerated]
	private Button m_d1;

	[CompilerGenerated]
	private Button m_d2;

	[CompilerGenerated]
	private Button m_d3;

	[CompilerGenerated]
	private Button m_d4;

	[CompilerGenerated]
	private Button m_d5;

	[CompilerGenerated]
	private Button m_d6;

	[CompilerGenerated]
	private Button m_d7;

	[CompilerGenerated]
	private Button m_d8;

	[CompilerGenerated]
	private CheckBox m_d9;

	[CompilerGenerated]
	private fl m_ea;

	[CompilerGenerated]
	private CheckBox m_eb;

	[CompilerGenerated]
	private CheckBox m_ec;

	[CompilerGenerated]
	private Button m_ed;

	private const string m_ee = "FIControlPanelMeasModule";

	private f1 m_ef;

	private bool m_eg;

	private bool m_eh;

	private bool m_ei;

	private fl m_ej;

	private string m_ek;

	private Guid m_el;

	private object m_em;

	private int m_en;

	private fz m_eo;

	private f m_ep;

	private hs m_eq;

	private global::i m_er;

	private bool m_es;

	private d1 m_et;

	private d1 m_eu;

	private d1 m_ev;

	private d1 m_ew;

	private d1 m_ex;

	private ho m_ey;

	private Collection<hc> m_ez;

	private Collection<hr> m_e0;

	private fh.b m_e1;

	private cb m_e2;

	private bool m_e3;

	private bool m_e4;

	private gh m_e5;

	private global::r.l m_e6;

	private global::r.l m_e7;

	[CompilerGenerated]
	private global::r.d e8;

	[CompilerGenerated]
	private global::r.d m_e9;

	[CompilerGenerated]
	private global::r.d m_fa;

	[CompilerGenerated]
	private global::r.d m_fb;

	[CompilerGenerated]
	private global::r.d m_fc;

	[CompilerGenerated]
	private global::r.d fd;

	[CompilerGenerated]
	private global::r.d m_fe;

	[CompilerGenerated]
	private global::r.d ff;

	[CompilerGenerated]
	private global::r.d fg;

	[CompilerGenerated]
	private global::r.d fh;

	[CompilerGenerated]
	private global::r.c fi;

	[CompilerGenerated]
	private global::r.d fj;

	[CompilerGenerated]
	private global::r.c fk;

	[CompilerGenerated]
	private global::r.d m_fl;

	private int m_fm;

	private bool m_fn;

	private bool fo;

	private bool fp;

	private c1 m_fq;

	private DateTime fr;

	private float fs;

	[CompilerGenerated]
	private System.Timers.Timer ft;

	[CompilerGenerated]
	private System.Timers.Timer fu;

	private bool fv;

	[CompilerGenerated]
	private System.Timers.Timer fw;

	private bool m_fx;

	[CompilerGenerated]
	private System.Timers.Timer fy;

	[CompilerGenerated]
	private System.Timers.Timer m_fz;

	[CompilerGenerated]
	private System.Timers.Timer m_f0;

	private int m_f1;

	private bool m_f2;

	private bool m_f3;

	private bool m_f4;

	private e9 m_f5;

	private DateTime m_f6;

	private bool m_f7;

	private DateTime m_f8;

	private global::r.d.a.b m_f9;

	private bool m_ga;

	private int m_gb;

	private int m_gc;

	private DateTime m_gd;

	private float m_ge;

	private hg m_gf;

	private global::r.c m_gg;

	private global::r.c m_gh;

	private global::r.c m_gi;

	private global::r.d m_gj;

	private bx m_gk;

	private bx m_gl;

	private bx m_gm;

	private bx m_gn;

	private bx m_go;

	private bx m_gp;

	private bx m_gq;

	private bx m_gr;

	private bx m_gs;

	private bool m_gt;

	private bool m_gu;

	private bool m_gv;

	private bool m_gw;

	private int m_gx;

	private int m_gy;

	private bool m_gz;

	private bool m_g0;

	private bm m_g1;

	private int m_g2;

	private d m_g3;

	[CompilerGenerated]
	private e m_g4;

	[CompilerGenerated]
	private ce.a m_g5;

	[CompilerGenerated]
	private g m_g6;

	[CompilerGenerated]
	private h m_g7;

	[CompilerGenerated]
	private global::r.d m_g8;

	private global::r.l m_g9;

	[CompilerGenerated]
	private global::r.d m_ha;

	[CompilerGenerated]
	private global::r.d m_hb;

	private float m_hc;

	private bool m_hd;

	private bool m_he;

	private bool m_hf;

	private ToolTip m_hg;

	private const int m_hh = 3;

	private const int m_hi = 15;

	private const int m_hj = 10;

	private const int m_hk = 6;

	private const int m_hl = 20;

	private const int m_hm = 360;

	private const int m_hn = 150;

	public const float ho = 540f;

	public const int hp = 500;

	private f7 m_hq;

	private f8 m_hr;

	private f8.a m_hs;

	private bool m_ht;

	private bool m_hu;

	private int[] m_hv;

	private int[] m_hw;

	private int[] m_hx;

	private int[] m_hy;

	private gr m_hz;

	private ge m_h0;

	private je m_h1;

	private bool m_h2;

	private int m_h3;

	private string m_h4;

	private gq m_h5;

	private ek m_h6;

	private bool m_h7;

	private bool m_h8;

	[CompilerGenerated]
	private i h9;

	[CompilerGenerated]
	private j ia;

	[CompilerGenerated]
	private k ib;

	[CompilerGenerated]
	private l ic;

	private bool id;

	[CompilerGenerated]
	private global::r.d ie;

	private ej @if;

	private const int ig = 18;

	private bool ih;

	[CompilerGenerated]
	private System.Timers.Timer ii;

	private bs ij;

	private gl ik;

	private int il;

	private string im;

	private string @in;

	private DateTime io;

	private bool ip;

	private bool iq;

	private bool ir;

	private float @is;

	private bool it;

	private bool[] iu;

	private float[] iv;

	[SpecialName]
	private bool iw;

	[SpecialName]
	private bool ix;

	[SpecialName]
	private IAsyncResult iy;

	[SpecialName]
	private StaticLocalInitFlag iz;

	[SpecialName]
	private IAsyncResult i0;

	[SpecialName]
	private StaticLocalInitFlag i1;

	[SpecialName]
	private bool i2;

	[SpecialName]
	private bool i3;

	[SpecialName]
	private int i4;

	[SpecialName]
	private int i5;

	[SpecialName]
	private DateTime i6;

	[SpecialName]
	private float i7;

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_a != null)
		{
			this.m_a.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void a9()
	{
		this.m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(f4));
		i(new ComboBox());
		i(new Label());
		i(new Button());
		j(new Button());
		k(new Button());
		i(new VScrollBar());
		i(new HScrollBar());
		i(new TrackBar());
		j(new Label());
		l(new Button());
		i(new Panel());
		j(new PictureBox());
		i(new TabControl());
		j(new TabPage());
		n(new Button());
		j(new TrackBar());
		o(new Button());
		k(new Label());
		i(new TabPage());
		au(new Button());
		i(new CheckBox());
		aq(new Button());
		ar(new Button());
		@as(new Button());
		at(new Button());
		am(new Button());
		an(new Button());
		ao(new Button());
		ap(new Button());
		m(new Panel());
		a9(new Label());
		ai(new Button());
		ak(new Button());
		aj(new Button());
		al(new Button());
		m(new Button());
		k(new PictureBox());
		i(new ToolTip(this.m_a));
		i(new ContextMenuStrip(this.m_a));
		i(new ToolStripMenuItem());
		j(new ContextMenuStrip(this.m_a));
		j(new ToolStripMenuItem());
		i(new TableLayoutPanel());
		n(new PictureBox());
		r(new GroupBox());
		r(new TableLayoutPanel());
		a6(new Label());
		i(new hx());
		a7(new Label());
		j(new hx());
		n(new GroupBox());
		z(new TableLayoutPanel());
		v(new TableLayoutPanel());
		w(new TableLayoutPanel());
		i(new ProgressBar());
		az(new Label());
		x(new TableLayoutPanel());
		ab(new Button());
		aa(new Button());
		aa(new TableLayoutPanel());
		aw(new Label());
		av(new Label());
		y(new TableLayoutPanel());
		ay(new Label());
		a1(new Label());
		ax(new Label());
		a0(new Label());
		q(new GroupBox());
		i(new TextBox());
		o(new GroupBox());
		t(new TableLayoutPanel());
		ab(new TableLayoutPanel());
		ac(new Button());
		s(new TableLayoutPanel());
		a8(new Label());
		i(new er(this.m_a));
		k(new CheckBox());
		q(new TableLayoutPanel());
		a2(new Label());
		j(new ComboBox());
		u(new TableLayoutPanel());
		ad(new Button());
		ae(new Button());
		m(new GroupBox());
		y(new Button());
		au(new Label());
		z(new Button());
		j(new TabControl());
		k(new TabPage());
		u(new Button());
		@as(new Label());
		v(new Button());
		l(new TabPage());
		w(new Button());
		at(new Label());
		x(new Button());
		j(new GroupBox());
		r(new Button());
		s(new Button());
		t(new Label());
		t(new Button());
		l(new GroupBox());
		n(new TableLayoutPanel());
		o(new TableLayoutPanel());
		ag(new Label());
		ah(new Label());
		ai(new Label());
		aj(new Label());
		ak(new Label());
		al(new Label());
		m(new PictureBox());
		k(new Panel());
		p(new TableLayoutPanel());
		am(new Label());
		an(new Label());
		ao(new Label());
		ap(new Label());
		aq(new Label());
		ar(new Label());
		k(new GroupBox());
		k(new TableLayoutPanel());
		l(new PictureBox());
		j(new Panel());
		l(new TableLayoutPanel());
		u(new Label());
		v(new Label());
		w(new Label());
		x(new Label());
		y(new Label());
		z(new Label());
		m(new TableLayoutPanel());
		aa(new Label());
		ab(new Label());
		ac(new Label());
		ad(new Label());
		ae(new Label());
		af(new Label());
		p(new GroupBox());
		af(new Button());
		ag(new Button());
		a3(new Label());
		a4(new Label());
		a5(new Label());
		i(new RichTextBox());
		ah(new Button());
		i(new GroupBox());
		j(new TableLayoutPanel());
		j(new CheckBox());
		l(new Label());
		m(new Label());
		n(new Label());
		o(new Label());
		p(new Label());
		q(new Label());
		r(new Label());
		s(new Label());
		q(new Button());
		o(new PictureBox());
		p(new PictureBox());
		q(new PictureBox());
		r(new PictureBox());
		s(new PictureBox());
		v(new PictureBox());
		t(new PictureBox());
		u(new PictureBox());
		w(new PictureBox());
		l(new Panel());
		p(new Button());
		l(new fl());
		i(new e1(this.m_a));
		k(new fl());
		i(new fl());
		j(new fl());
		((ISupportInitialize)bl()).BeginInit();
		bp().SuspendLayout();
		((ISupportInitialize)bq()).BeginInit();
		bs().SuspendLayout();
		bu().SuspendLayout();
		((ISupportInitialize)bw()).BeginInit();
		bt().SuspendLayout();
		f5().SuspendLayout();
		((ISupportInitialize)br()).BeginInit();
		b0().SuspendLayout();
		b2().SuspendLayout();
		b5().SuspendLayout();
		((ISupportInitialize)eh()).BeginInit();
		es().SuspendLayout();
		et().SuspendLayout();
		dz().SuspendLayout();
		fx().SuspendLayout();
		fl().SuspendLayout();
		fm().SuspendLayout();
		fn().SuspendLayout();
		fz().SuspendLayout();
		fq().SuspendLayout();
		eq().SuspendLayout();
		ea().SuspendLayout();
		fa().SuspendLayout();
		f0().SuspendLayout();
		e9().SuspendLayout();
		ee().SuspendLayout();
		fb().SuspendLayout();
		dv().SuspendLayout();
		dm().SuspendLayout();
		dn().SuspendLayout();
		dr().SuspendLayout();
		ch().SuspendLayout();
		c4().SuspendLayout();
		c5().SuspendLayout();
		c6().SuspendLayout();
		((ISupportInitialize)dd()).BeginInit();
		de().SuspendLayout();
		df().SuspendLayout();
		cm().SuspendLayout();
		cn().SuspendLayout();
		((ISupportInitialize)co()).BeginInit();
		cp().SuspendLayout();
		cq().SuspendLayout();
		cx().SuspendLayout();
		ei().SuspendLayout();
		b6().SuspendLayout();
		b7().SuspendLayout();
		((ISupportInitialize)ey()).BeginInit();
		((ISupportInitialize)ez()).BeginInit();
		((ISupportInitialize)e0()).BeginInit();
		((ISupportInitialize)e1()).BeginInit();
		((ISupportInitialize)e2()).BeginInit();
		((ISupportInitialize)e5()).BeginInit();
		((ISupportInitialize)e3()).BeginInit();
		((ISupportInitialize)e4()).BeginInit();
		((ISupportInitialize)e6()).BeginInit();
		fc().SuspendLayout();
		((ISupportInitialize)bh()).BeginInit();
		SuspendLayout();
		componentResourceManager.ApplyResources(bd(), "ComboMeasResult");
		bd().DropDownStyle = ComboBoxStyle.DropDownList;
		bd().FormattingEnabled = true;
		bd().Name = "ComboMeasResult";
		bz().SetToolTip(bd(), componentResourceManager.GetString("ComboMeasResult.ToolTip"));
		componentResourceManager.ApplyResources(be(), "lbMicroImage");
		be().Name = "lbMicroImage";
		bz().SetToolTip(be(), componentResourceManager.GetString("lbMicroImage.ToolTip"));
		componentResourceManager.ApplyResources(bf(), "ButtonStopVideo");
		bf().Name = "ButtonStopVideo";
		bz().SetToolTip(bf(), componentResourceManager.GetString("ButtonStopVideo.ToolTip"));
		bf().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bg(), "ButtonWhiteBalance");
		bg().Name = "ButtonWhiteBalance";
		bz().SetToolTip(bg(), componentResourceManager.GetString("ButtonWhiteBalance.ToolTip"));
		bg().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bi(), "ButtonPlayVideo");
		bi().Name = "ButtonPlayVideo";
		bz().SetToolTip(bi(), componentResourceManager.GetString("ButtonPlayVideo.ToolTip"));
		bi().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bj(), "VScrollVideo");
		bj().Maximum = 480;
		bj().Name = "VScrollVideo";
		bz().SetToolTip(bj(), componentResourceManager.GetString("VScrollVideo.ToolTip"));
		componentResourceManager.ApplyResources(bk(), "HScrollVideo");
		bk().Maximum = 640;
		bk().Name = "HScrollVideo";
		bz().SetToolTip(bk(), componentResourceManager.GetString("HScrollVideo.ToolTip"));
		componentResourceManager.ApplyResources(bl(), "TrackBarVideo");
		bl().BackColor = SystemColors.Window;
		bl().Maximum = 4;
		bl().Minimum = 1;
		bl().Name = "TrackBarVideo";
		bz().SetToolTip(bl(), componentResourceManager.GetString("TrackBarVideo.ToolTip"));
		bl().Value = 1;
		componentResourceManager.ApplyResources(bm(), "LbZoom");
		bm().Name = "LbZoom";
		bz().SetToolTip(bm(), componentResourceManager.GetString("LbZoom.ToolTip"));
		componentResourceManager.ApplyResources(bn(), "ButtonVideoSettings");
		bn().Name = "ButtonVideoSettings";
		bz().SetToolTip(bn(), componentResourceManager.GetString("ButtonVideoSettings.ToolTip"));
		bn().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bp(), "PanelPic");
		bp().BackColor = Color.Transparent;
		bp().Controls.Add(bq());
		bp().Name = "PanelPic";
		bz().SetToolTip(bp(), componentResourceManager.GetString("PanelPic.ToolTip"));
		componentResourceManager.ApplyResources(bq(), "PicImage");
		bq().BackColor = SystemColors.ButtonShadow;
		bq().Name = "PicImage";
		bq().TabStop = false;
		bz().SetToolTip(bq(), componentResourceManager.GetString("PicImage.ToolTip"));
		componentResourceManager.ApplyResources(bs(), "TabControlVideoAndImage");
		bs().Controls.Add(bu());
		bs().Controls.Add(bt());
		bs().Name = "TabControlVideoAndImage";
		bs().SelectedIndex = 0;
		bs().SizeMode = TabSizeMode.Fixed;
		bz().SetToolTip(bs(), componentResourceManager.GetString("TabControlVideoAndImage.ToolTip"));
		componentResourceManager.ApplyResources(bu(), "TabPageImage");
		bu().Controls.Add(bv());
		bu().Controls.Add(bp());
		bu().Controls.Add(bw());
		bu().Controls.Add(bx());
		bu().Controls.Add(by());
		bu().Name = "TabPageImage";
		bz().SetToolTip(bu(), componentResourceManager.GetString("TabPageImage.ToolTip"));
		bu().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bv(), "ButtonImageCenter");
		bv().Name = "ButtonImageCenter";
		bz().SetToolTip(bv(), componentResourceManager.GetString("ButtonImageCenter.ToolTip"));
		bv().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bw(), "TrackBarImage");
		bw().BackColor = SystemColors.Window;
		bw().Maximum = 4;
		bw().Minimum = 1;
		bw().Name = "TrackBarImage";
		bz().SetToolTip(bw(), componentResourceManager.GetString("TrackBarImage.ToolTip"));
		bw().Value = 1;
		componentResourceManager.ApplyResources(bx(), "ButtonImageSettings");
		bx().Name = "ButtonImageSettings";
		bz().SetToolTip(bx(), componentResourceManager.GetString("ButtonImageSettings.ToolTip"));
		bx().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(by(), "Label1");
		by().Name = "Label1";
		bz().SetToolTip(by(), componentResourceManager.GetString("Label1.ToolTip"));
		componentResourceManager.ApplyResources(bt(), "TabPageVideo");
		bt().Controls.Add(gj());
		bt().Controls.Add(gf());
		bt().Controls.Add(gb());
		bt().Controls.Add(gc());
		bt().Controls.Add(gd());
		bt().Controls.Add(ge());
		bt().Controls.Add(f7());
		bt().Controls.Add(f8());
		bt().Controls.Add(f9());
		bt().Controls.Add(ga());
		bt().Controls.Add(f5());
		bt().Controls.Add(bj());
		bt().Controls.Add(bk());
		bt().Controls.Add(bo());
		bt().Controls.Add(bl());
		bt().Controls.Add(bn());
		bt().Controls.Add(bm());
		bt().Controls.Add(br());
		bt().Name = "TabPageVideo";
		bz().SetToolTip(bt(), componentResourceManager.GetString("TabPageVideo.ToolTip"));
		bt().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(gj(), "ButtonShowVideoDialog");
		gj().Name = "ButtonShowVideoDialog";
		bz().SetToolTip(gj(), componentResourceManager.GetString("ButtonShowVideoDialog.ToolTip"));
		gj().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(gf(), "CheckBoxLED");
		gf().Name = "CheckBoxLED";
		bz().SetToolTip(gf(), componentResourceManager.GetString("CheckBoxLED.ToolTip"));
		gf().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(gb(), "ButtonYDownSlow");
		gb().Image = Resources.SlowDescend;
		gb().Name = "ButtonYDownSlow";
		gb().TabStop = false;
		bz().SetToolTip(gb(), componentResourceManager.GetString("ButtonYDownSlow.ToolTip"));
		gb().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(gc(), "ButtonYUpFast");
		gc().Image = Resources.FastAscend;
		gc().Name = "ButtonYUpFast";
		gc().TabStop = false;
		bz().SetToolTip(gc(), componentResourceManager.GetString("ButtonYUpFast.ToolTip"));
		gc().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(gd(), "ButtonYDownFast");
		gd().Image = Resources.FastDescend;
		gd().Name = "ButtonYDownFast";
		gd().TabStop = false;
		bz().SetToolTip(gd(), componentResourceManager.GetString("ButtonYDownFast.ToolTip"));
		gd().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ge(), "ButtonYUpSlow");
		ge().Image = Resources.SlowAscend;
		ge().Name = "ButtonYUpSlow";
		ge().TabStop = false;
		bz().SetToolTip(ge(), componentResourceManager.GetString("ButtonYUpSlow.ToolTip"));
		ge().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(f7(), "ButtonXUpFast");
		f7().Name = "ButtonXUpFast";
		f7().TabStop = false;
		bz().SetToolTip(f7(), componentResourceManager.GetString("ButtonXUpFast.ToolTip"));
		f7().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(f8(), "ButtonXDownFast");
		f8().Name = "ButtonXDownFast";
		f8().TabStop = false;
		bz().SetToolTip(f8(), componentResourceManager.GetString("ButtonXDownFast.ToolTip"));
		f8().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(f9(), "ButtonXUpSlow");
		f9().Name = "ButtonXUpSlow";
		f9().TabStop = false;
		bz().SetToolTip(f9(), componentResourceManager.GetString("ButtonXUpSlow.ToolTip"));
		f9().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ga(), "ButtonXDownSlow");
		ga().Name = "ButtonXDownSlow";
		ga().TabStop = false;
		bz().SetToolTip(ga(), componentResourceManager.GetString("ButtonXDownSlow.ToolTip"));
		ga().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(f5(), "PanelZMotorControl");
		f5().Controls.Add(f6());
		f5().Controls.Add(f1());
		f5().Controls.Add(f3());
		f5().Controls.Add(f2());
		f5().Controls.Add(f4());
		f5().Name = "PanelZMotorControl";
		bz().SetToolTip(f5(), componentResourceManager.GetString("PanelZMotorControl.ToolTip"));
		componentResourceManager.ApplyResources(f6(), "Label3");
		f6().Name = "Label3";
		bz().SetToolTip(f6(), componentResourceManager.GetString("Label3.ToolTip"));
		componentResourceManager.ApplyResources(f1(), "ButtonZFastDown");
		f1().Image = Resources.FastDescend;
		f1().Name = "ButtonZFastDown";
		bz().SetToolTip(f1(), componentResourceManager.GetString("ButtonZFastDown.ToolTip"));
		f1().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(f3(), "ButtonZSlowUp");
		f3().Image = Resources.SlowAscend;
		f3().Name = "ButtonZSlowUp";
		bz().SetToolTip(f3(), componentResourceManager.GetString("ButtonZSlowUp.ToolTip"));
		f3().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(f2(), "ButtonZSlowDown");
		f2().Image = Resources.SlowDescend;
		f2().Name = "ButtonZSlowDown";
		bz().SetToolTip(f2(), componentResourceManager.GetString("ButtonZSlowDown.ToolTip"));
		f2().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(f4(), "ButtonZFastUp");
		f4().Image = Resources.FastAscend;
		f4().Name = "ButtonZFastUp";
		bz().SetToolTip(f4(), componentResourceManager.GetString("ButtonZFastUp.ToolTip"));
		f4().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bo(), "ButtonVideoCenter");
		bo().Name = "ButtonVideoCenter";
		bz().SetToolTip(bo(), componentResourceManager.GetString("ButtonVideoCenter.ToolTip"));
		bo().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(br(), "PicVideo");
		br().BackColor = SystemColors.ButtonShadow;
		br().Name = "PicVideo";
		br().TabStop = false;
		bz().SetToolTip(br(), componentResourceManager.GetString("PicVideo.ToolTip"));
		componentResourceManager.ApplyResources(b0(), "ContextMenuStripForImage");
		b0().Items.AddRange(new ToolStripItem[1] { b1() });
		b0().Name = "ContextMenuStripForImage";
		bz().SetToolTip(b0(), componentResourceManager.GetString("ContextMenuStripForImage.ToolTip"));
		componentResourceManager.ApplyResources(b1(), "ToolStripMenuItemSaveImage");
		b1().Name = "ToolStripMenuItemSaveImage";
		componentResourceManager.ApplyResources(b2(), "SelectRecipeRightClickContextMenuStrip");
		b2().Items.AddRange(new ToolStripItem[1] { b3() });
		b2().Name = "NewCompositeContextMenuStrip";
		bz().SetToolTip(b2(), componentResourceManager.GetString("SelectRecipeRightClickContextMenuStrip.ToolTip"));
		componentResourceManager.ApplyResources(b3(), "NewCompositeRecipeToolStripMenuItem");
		b3().Alignment = ToolStripItemAlignment.Right;
		b3().Name = "NewCompositeRecipeToolStripMenuItem";
		componentResourceManager.ApplyResources(b5(), "TableLayoutPanelControlsResults");
		b5().Controls.Add(eh(), 0, 0);
		b5().Controls.Add(es(), 0, 1);
		b5().Controls.Add(dz(), 0, 2);
		b5().Controls.Add(eq(), 0, 3);
		b5().Controls.Add(ea(), 0, 4);
		b5().Controls.Add(dv(), 0, 5);
		b5().Controls.Add(dm(), 0, 6);
		b5().Controls.Add(ch(), 0, 7);
		b5().Controls.Add(c4(), 0, 8);
		b5().Controls.Add(cm(), 0, 9);
		b5().Controls.Add(ei(), 0, 10);
		b5().Controls.Add(b6(), 0, 11);
		b5().Controls.Add(ey(), 1, 1);
		b5().Controls.Add(ez(), 1, 3);
		b5().Controls.Add(e0(), 1, 4);
		b5().Controls.Add(e1(), 1, 5);
		b5().Controls.Add(e2(), 1, 6);
		b5().Controls.Add(e5(), 1, 7);
		b5().Controls.Add(e3(), 1, 8);
		b5().Controls.Add(e4(), 1, 9);
		b5().Controls.Add(e6(), 1, 10);
		b5().Name = "TableLayoutPanelControlsResults";
		bz().SetToolTip(b5(), componentResourceManager.GetString("TableLayoutPanelControlsResults.ToolTip"));
		componentResourceManager.ApplyResources(eh(), "PictureBoxLogo");
		b5().SetColumnSpan(eh(), 2);
		eh().Image = Resources.FilmLogoLrg;
		eh().Name = "PictureBoxLogo";
		eh().TabStop = false;
		bz().SetToolTip(eh(), componentResourceManager.GetString("PictureBoxLogo.ToolTip"));
		componentResourceManager.ApplyResources(es(), "GroupSampleInfo");
		es().Controls.Add(et());
		es().Name = "GroupSampleInfo";
		es().TabStop = false;
		bz().SetToolTip(es(), componentResourceManager.GetString("GroupSampleInfo.ToolTip"));
		componentResourceManager.ApplyResources(et(), "TableLayoutPanelUserInfo");
		et().Controls.Add(eu(), 0, 0);
		et().Controls.Add(ev(), 1, 1);
		et().Controls.Add(ew(), 0, 1);
		et().Controls.Add(ex(), 1, 0);
		et().Name = "TableLayoutPanelUserInfo";
		bz().SetToolTip(et(), componentResourceManager.GetString("TableLayoutPanelUserInfo.ToolTip"));
		componentResourceManager.ApplyResources(eu(), "LabelMeasSampleId");
		eu().Name = "LabelMeasSampleId";
		bz().SetToolTip(eu(), componentResourceManager.GetString("LabelMeasSampleId.ToolTip"));
		componentResourceManager.ApplyResources(ev(), "TextBoxOperatorId");
		ev().Name = "TextBoxOperatorId";
		bz().SetToolTip(ev(), componentResourceManager.GetString("TextBoxOperatorId.ToolTip"));
		ev().e(A_0: false);
		componentResourceManager.ApplyResources(ew(), "LabelMeasOperatorId");
		ew().Name = "LabelMeasOperatorId";
		bz().SetToolTip(ew(), componentResourceManager.GetString("LabelMeasOperatorId.ToolTip"));
		componentResourceManager.ApplyResources(ex(), "TextBoxSampleId");
		ex().Name = "TextBoxSampleId";
		bz().SetToolTip(ex(), componentResourceManager.GetString("TextBoxSampleId.ToolTip"));
		ex().e(A_0: false);
		componentResourceManager.ApplyResources(dz(), "GroupBoxCalculationStatus");
		dz().Controls.Add(fx());
		dz().Name = "GroupBoxCalculationStatus";
		dz().TabStop = false;
		bz().SetToolTip(dz(), componentResourceManager.GetString("GroupBoxCalculationStatus.ToolTip"));
		componentResourceManager.ApplyResources(fx(), "TableLayoutPanelCalcStatusOuter");
		fx().Controls.Add(fl(), 0, 0);
		fx().Name = "TableLayoutPanelCalcStatusOuter";
		bz().SetToolTip(fx(), componentResourceManager.GetString("TableLayoutPanelCalcStatusOuter.ToolTip"));
		componentResourceManager.ApplyResources(fl(), "TableLayoutPanel1");
		fl().Controls.Add(fm(), 0, 0);
		fl().Controls.Add(fn(), 1, 1);
		fl().Controls.Add(fq(), 0, 1);
		fl().Name = "TableLayoutPanel1";
		bz().SetToolTip(fl(), componentResourceManager.GetString("TableLayoutPanel1.ToolTip"));
		componentResourceManager.ApplyResources(fm(), "TableLayoutPanel2");
		fl().SetColumnSpan(fm(), 2);
		fm().Controls.Add(d8(), 0, 1);
		fm().Controls.Add(d5(), 0, 0);
		fm().Name = "TableLayoutPanel2";
		bz().SetToolTip(fm(), componentResourceManager.GetString("TableLayoutPanel2.ToolTip"));
		componentResourceManager.ApplyResources(d8(), "ProgressBarAnalysis");
		d8().Name = "ProgressBarAnalysis";
		bz().SetToolTip(d8(), componentResourceManager.GetString("ProgressBarAnalysis.ToolTip"));
		componentResourceManager.ApplyResources(d5(), "LabelMeasStatus");
		d5().BackColor = Color.Transparent;
		d5().Name = "LabelMeasStatus";
		bz().SetToolTip(d5(), componentResourceManager.GetString("LabelMeasStatus.ToolTip"));
		componentResourceManager.ApplyResources(fn(), "TableLayoutPanel3");
		fn().Controls.Add(d9(), 1, 1);
		fn().Controls.Add(d2(), 0, 1);
		fn().Controls.Add(fz(), 0, 0);
		fn().Name = "TableLayoutPanel3";
		bz().SetToolTip(fn(), componentResourceManager.GetString("TableLayoutPanel3.ToolTip"));
		componentResourceManager.ApplyResources(d9(), "ButtonMeasCancel");
		d9().Name = "ButtonMeasCancel";
		bz().SetToolTip(d9(), componentResourceManager.GetString("ButtonMeasCancel.ToolTip"));
		d9().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(d2(), "ButtonAnalysisAccept");
		d2().Name = "ButtonAnalysisAccept";
		bz().SetToolTip(d2(), componentResourceManager.GetString("ButtonAnalysisAccept.ToolTip"));
		d2().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(fz(), "TableLayoutPanel5");
		fn().SetColumnSpan(fz(), 2);
		fz().Controls.Add(d1(), 0, 0);
		fz().Controls.Add(d0(), 1, 0);
		fz().Name = "TableLayoutPanel5";
		bz().SetToolTip(fz(), componentResourceManager.GetString("TableLayoutPanel5.ToolTip"));
		componentResourceManager.ApplyResources(d1(), "LabelAnalysisTimeLabel");
		d1().Name = "LabelAnalysisTimeLabel";
		bz().SetToolTip(d1(), componentResourceManager.GetString("LabelAnalysisTimeLabel.ToolTip"));
		componentResourceManager.ApplyResources(d0(), "LabelAnalysisTimeRemaining");
		d0().Name = "LabelAnalysisTimeRemaining";
		bz().SetToolTip(d0(), componentResourceManager.GetString("LabelAnalysisTimeRemaining.ToolTip"));
		componentResourceManager.ApplyResources(fq(), "TableLayoutPanel4");
		fq().Controls.Add(d4(), 0, 0);
		fq().Controls.Add(d7(), 1, 0);
		fq().Controls.Add(d3(), 0, 1);
		fq().Controls.Add(d6(), 1, 1);
		fq().Name = "TableLayoutPanel4";
		bz().SetToolTip(fq(), componentResourceManager.GetString("TableLayoutPanel4.ToolTip"));
		componentResourceManager.ApplyResources(d4(), "LabelAnalysisStageLabel");
		d4().Name = "LabelAnalysisStageLabel";
		bz().SetToolTip(d4(), componentResourceManager.GetString("LabelAnalysisStageLabel.ToolTip"));
		componentResourceManager.ApplyResources(d7(), "LabelAnalysisStage");
		d7().Name = "LabelAnalysisStage";
		bz().SetToolTip(d7(), componentResourceManager.GetString("LabelAnalysisStage.ToolTip"));
		componentResourceManager.ApplyResources(d3(), "LabelAnalysisGofLabel");
		d3().Name = "LabelAnalysisGofLabel";
		bz().SetToolTip(d3(), componentResourceManager.GetString("LabelAnalysisGofLabel.ToolTip"));
		componentResourceManager.ApplyResources(d6(), "LabelAnalysisGof");
		d6().Name = "LabelAnalysisGof";
		bz().SetToolTip(d6(), componentResourceManager.GetString("LabelAnalysisGof.ToolTip"));
		componentResourceManager.ApplyResources(eq(), "GroupMeasurementResult");
		eq().Controls.Add(er());
		eq().Name = "GroupMeasurementResult";
		eq().TabStop = false;
		bz().SetToolTip(eq(), componentResourceManager.GetString("GroupMeasurementResult.ToolTip"));
		componentResourceManager.ApplyResources(er(), "TextBoxMeasThickness");
		er().BackColor = SystemColors.ButtonFace;
		er().BorderStyle = BorderStyle.None;
		er().Cursor = Cursors.Default;
		er().Name = "TextBoxMeasThickness";
		er().ReadOnly = true;
		er().TabStop = false;
		bz().SetToolTip(er(), componentResourceManager.GetString("TextBoxMeasThickness.ToolTip"));
		componentResourceManager.ApplyResources(ea(), "GroupOperation");
		ea().Controls.Add(fa());
		ea().Name = "GroupOperation";
		ea().TabStop = false;
		bz().SetToolTip(ea(), componentResourceManager.GetString("GroupOperation.ToolTip"));
		componentResourceManager.ApplyResources(fa(), "TableLayoutPanelMeasureButton");
		fa().Controls.Add(f0(), 0, 2);
		fa().Controls.Add(e9(), 0, 1);
		fa().Controls.Add(ee(), 0, 0);
		fa().Controls.Add(fb(), 0, 3);
		fa().Name = "TableLayoutPanelMeasureButton";
		bz().SetToolTip(fa(), componentResourceManager.GetString("TableLayoutPanelMeasureButton.ToolTip"));
		componentResourceManager.ApplyResources(f0(), "TableLayoutPanelMeasureAndGoTo");
		f0().Controls.Add(eb(), 0, 0);
		f0().Name = "TableLayoutPanelMeasureAndGoTo";
		bz().SetToolTip(f0(), componentResourceManager.GetString("TableLayoutPanelMeasureAndGoTo.ToolTip"));
		componentResourceManager.ApplyResources(eb(), "ButtonMeasure");
		eb().BackColor = Color.WhiteSmoke;
		eb().Name = "ButtonMeasure";
		bz().SetToolTip(eb(), componentResourceManager.GetString("ButtonMeasure.ToolTip"));
		eb().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(e9(), "TableLayoutPanelAutoBaselineRefStatus");
		e9().Controls.Add(e7(), 0, 0);
		e9().Controls.Add(fe(), 1, 0);
		e9().Controls.Add(gi(), 2, 0);
		e9().Name = "TableLayoutPanelAutoBaselineRefStatus";
		bz().SetToolTip(e9(), componentResourceManager.GetString("TableLayoutPanelAutoBaselineRefStatus.ToolTip"));
		componentResourceManager.ApplyResources(e7(), "LabelAutoBaselineRefStatus");
		e7().Name = "LabelAutoBaselineRefStatus";
		bz().SetToolTip(e7(), componentResourceManager.GetString("LabelAutoBaselineRefStatus.ToolTip"));
		componentResourceManager.ApplyResources(fe(), "FIPanelBufferedBaselineRefStatus");
		fe().BackColor = SystemColors.ButtonFace;
		fe().BorderStyle = BorderStyle.FixedSingle;
		fe().Name = "FIPanelBufferedBaselineRefStatus";
		bz().SetToolTip(fe(), componentResourceManager.GetString("FIPanelBufferedBaselineRefStatus.ToolTip"));
		componentResourceManager.ApplyResources(gi(), "CheckBoxBaselineLock");
		gi().Name = "CheckBoxBaselineLock";
		bz().SetToolTip(gi(), componentResourceManager.GetString("CheckBoxBaselineLock.ToolTip"));
		gi().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ee(), "TableLayoutPanelSelectCTMOrObjective");
		ee().Controls.Add(ef(), 0, 0);
		ee().Controls.Add(eg(), 1, 0);
		ee().Name = "TableLayoutPanelSelectCTMOrObjective";
		bz().SetToolTip(ee(), componentResourceManager.GetString("TableLayoutPanelSelectCTMOrObjective.ToolTip"));
		componentResourceManager.ApplyResources(ef(), "lbObjective");
		ef().Name = "lbObjective";
		bz().SetToolTip(ef(), componentResourceManager.GetString("lbObjective.ToolTip"));
		componentResourceManager.ApplyResources(eg(), "ComboActiveObjectiveOrCTM");
		eg().DropDownStyle = ComboBoxStyle.DropDownList;
		eg().FormattingEnabled = true;
		eg().Name = "ComboActiveObjectiveOrCTM";
		bz().SetToolTip(eg(), componentResourceManager.GetString("ComboActiveObjectiveOrCTM.ToolTip"));
		componentResourceManager.ApplyResources(fb(), "TableLayoutPanelBaseAndAnalyze");
		fb().Controls.Add(ec(), 0, 0);
		fb().Controls.Add(ed(), 1, 0);
		fb().Name = "TableLayoutPanelBaseAndAnalyze";
		bz().SetToolTip(fb(), componentResourceManager.GetString("TableLayoutPanelBaseAndAnalyze.ToolTip"));
		componentResourceManager.ApplyResources(ec(), "ButtonMeasBaseline");
		ec().BackColor = SystemColors.ButtonFace;
		ec().Name = "ButtonMeasBaseline";
		bz().SetToolTip(ec(), componentResourceManager.GetString("ButtonMeasBaseline.ToolTip"));
		ec().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ed(), "ButtonAnalyze");
		ed().Name = "ButtonAnalyze";
		bz().SetToolTip(ed(), componentResourceManager.GetString("ButtonAnalyze.ToolTip"));
		ed().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(dv(), "GroupMeasRecipe");
		dv().Controls.Add(dw());
		dv().Controls.Add(dx());
		dv().Controls.Add(dy());
		dv().Name = "GroupMeasRecipe";
		dv().TabStop = false;
		bz().SetToolTip(dv(), componentResourceManager.GetString("GroupMeasRecipe.ToolTip"));
		componentResourceManager.ApplyResources(dw(), "ButtonGetRecipe");
		dw().Image = Resources.DropDownImage;
		dw().Name = "ButtonGetRecipe";
		bz().SetToolTip(dw(), componentResourceManager.GetString("ButtonGetRecipe.ToolTip"));
		dw().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(dx(), "LabelRecipeName");
		dx().AutoEllipsis = true;
		dx().BackColor = SystemColors.ButtonHighlight;
		dx().BorderStyle = BorderStyle.Fixed3D;
		dx().Name = "LabelRecipeName";
		bz().SetToolTip(dx(), componentResourceManager.GetString("LabelRecipeName.ToolTip"));
		dx().UseMnemonic = false;
		componentResourceManager.ApplyResources(dy(), "ButtonMeasEdit");
		dy().BackColor = SystemColors.ButtonFace;
		dy().Name = "ButtonMeasEdit";
		bz().SetToolTip(dy(), componentResourceManager.GetString("ButtonMeasEdit.ToolTip"));
		dy().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(dm(), "TabControlARHC");
		dm().Controls.Add(dn());
		dm().Controls.Add(dr());
		dm().Name = "TabControlARHC";
		dm().SelectedIndex = 0;
		dm().SizeMode = TabSizeMode.Fixed;
		bz().SetToolTip(dm(), componentResourceManager.GetString("TabControlARHC.ToolTip"));
		componentResourceManager.ApplyResources(dn(), "TabPageAR");
		dn().BackColor = Color.FromArgb(180, 240, 240);
		dn().Controls.Add(@do());
		dn().Controls.Add(dp());
		dn().Controls.Add(dq());
		dn().Name = "TabPageAR";
		bz().SetToolTip(dn(), componentResourceManager.GetString("TabPageAR.ToolTip"));
		componentResourceManager.ApplyResources(@do(), "ButtonGetRecipeAR");
		@do().Image = Resources.DropDownImage;
		@do().Name = "ButtonGetRecipeAR";
		bz().SetToolTip(@do(), componentResourceManager.GetString("ButtonGetRecipeAR.ToolTip"));
		@do().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(dp(), "LabelRecipeNameAR");
		dp().BackColor = SystemColors.ButtonHighlight;
		dp().BorderStyle = BorderStyle.Fixed3D;
		dp().Name = "LabelRecipeNameAR";
		bz().SetToolTip(dp(), componentResourceManager.GetString("LabelRecipeNameAR.ToolTip"));
		dp().UseMnemonic = false;
		componentResourceManager.ApplyResources(dq(), "ButtonMeasEditAR");
		dq().BackColor = SystemColors.ButtonFace;
		dq().Name = "ButtonMeasEditAR";
		bz().SetToolTip(dq(), componentResourceManager.GetString("ButtonMeasEditAR.ToolTip"));
		dq().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(dr(), "TabPageHC");
		dr().BackColor = Color.FromArgb(220, 200, 160);
		dr().Controls.Add(ds());
		dr().Controls.Add(dt());
		dr().Controls.Add(du());
		dr().Name = "TabPageHC";
		bz().SetToolTip(dr(), componentResourceManager.GetString("TabPageHC.ToolTip"));
		componentResourceManager.ApplyResources(ds(), "ButtonGetRecipeHC");
		ds().Image = Resources.DropDownImage;
		ds().Name = "ButtonGetRecipeHC";
		bz().SetToolTip(ds(), componentResourceManager.GetString("ButtonGetRecipeHC.ToolTip"));
		ds().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(dt(), "LabelRecipeNameHC");
		dt().BackColor = SystemColors.ButtonHighlight;
		dt().BorderStyle = BorderStyle.Fixed3D;
		dt().Name = "LabelRecipeNameHC";
		bz().SetToolTip(dt(), componentResourceManager.GetString("LabelRecipeNameHC.ToolTip"));
		dt().UseMnemonic = false;
		componentResourceManager.ApplyResources(du(), "ButtonMeasEditHC");
		du().BackColor = SystemColors.ButtonFace;
		du().Name = "ButtonMeasEditHC";
		bz().SetToolTip(du(), componentResourceManager.GetString("ButtonMeasEditHC.ToolTip"));
		du().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ch(), "GroupBoxTemplate");
		ch().Controls.Add(ci());
		ch().Controls.Add(cj());
		ch().Controls.Add(ck());
		ch().Controls.Add(cl());
		ch().Name = "GroupBoxTemplate";
		ch().TabStop = false;
		bz().SetToolTip(ch(), componentResourceManager.GetString("GroupBoxTemplate.ToolTip"));
		componentResourceManager.ApplyResources(ci(), "ButtonMeasureToTemplate");
		ci().Name = "ButtonMeasureToTemplate";
		bz().SetToolTip(ci(), componentResourceManager.GetString("ButtonMeasureToTemplate.ToolTip"));
		ci().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(cj(), "ButtonGetTemplate");
		cj().Image = Resources.DropDownImage;
		cj().Name = "ButtonGetTemplate";
		bz().SetToolTip(cj(), componentResourceManager.GetString("ButtonGetTemplate.ToolTip"));
		cj().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ck(), "LabelTemplate");
		ck().BackColor = SystemColors.ButtonHighlight;
		ck().BorderStyle = BorderStyle.Fixed3D;
		ck().Name = "LabelTemplate";
		bz().SetToolTip(ck(), componentResourceManager.GetString("LabelTemplate.ToolTip"));
		componentResourceManager.ApplyResources(cl(), "ButtonEditTemplate");
		cl().Name = "ButtonEditTemplate";
		bz().SetToolTip(cl(), componentResourceManager.GetString("ButtonEditTemplate.ToolTip"));
		cl().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(c4(), "GroupSpectrumColor");
		c4().Controls.Add(c5());
		c4().Name = "GroupSpectrumColor";
		c4().TabStop = false;
		bz().SetToolTip(c4(), componentResourceManager.GetString("GroupSpectrumColor.ToolTip"));
		componentResourceManager.ApplyResources(c5(), "TableLayoutPanelSpecColor");
		c5().Controls.Add(c6(), 1, 0);
		c5().Controls.Add(dd(), 0, 0);
		c5().Controls.Add(de(), 2, 0);
		c5().Name = "TableLayoutPanelSpecColor";
		bz().SetToolTip(c5(), componentResourceManager.GetString("TableLayoutPanelSpecColor.ToolTip"));
		componentResourceManager.ApplyResources(c6(), "TableLayoutPanelSpecColorValues");
		c6().Controls.Add(c7(), 0, 0);
		c6().Controls.Add(c8(), 0, 1);
		c6().Controls.Add(c9(), 1, 2);
		c6().Controls.Add(da(), 0, 2);
		c6().Controls.Add(db(), 1, 1);
		c6().Controls.Add(dc(), 1, 0);
		c6().Name = "TableLayoutPanelSpecColorValues";
		bz().SetToolTip(c6(), componentResourceManager.GetString("TableLayoutPanelSpecColorValues.ToolTip"));
		componentResourceManager.ApplyResources(c7(), "LabelX");
		c7().Name = "LabelX";
		bz().SetToolTip(c7(), componentResourceManager.GetString("LabelX.ToolTip"));
		componentResourceManager.ApplyResources(c8(), "LabelY");
		c8().Name = "LabelY";
		bz().SetToolTip(c8(), componentResourceManager.GetString("LabelY.ToolTip"));
		componentResourceManager.ApplyResources(c9(), "LabelZValue");
		c9().BorderStyle = BorderStyle.Fixed3D;
		c9().Name = "LabelZValue";
		bz().SetToolTip(c9(), componentResourceManager.GetString("LabelZValue.ToolTip"));
		componentResourceManager.ApplyResources(da(), "LabelZ");
		da().Name = "LabelZ";
		bz().SetToolTip(da(), componentResourceManager.GetString("LabelZ.ToolTip"));
		componentResourceManager.ApplyResources(db(), "LabelYValue");
		db().BorderStyle = BorderStyle.Fixed3D;
		db().Name = "LabelYValue";
		bz().SetToolTip(db(), componentResourceManager.GetString("LabelYValue.ToolTip"));
		componentResourceManager.ApplyResources(dc(), "LabelXValue");
		dc().BorderStyle = BorderStyle.Fixed3D;
		dc().Name = "LabelXValue";
		bz().SetToolTip(dc(), componentResourceManager.GetString("LabelXValue.ToolTip"));
		componentResourceManager.ApplyResources(dd(), "PictureSpectrumColor");
		dd().BackColor = SystemColors.Control;
		dd().BorderStyle = BorderStyle.Fixed3D;
		dd().Name = "PictureSpectrumColor";
		dd().TabStop = false;
		bz().SetToolTip(dd(), componentResourceManager.GetString("PictureSpectrumColor.ToolTip"));
		componentResourceManager.ApplyResources(de(), "PanelColorXYZ");
		de().Controls.Add(df());
		de().Name = "PanelColorXYZ";
		bz().SetToolTip(de(), componentResourceManager.GetString("PanelColorXYZ.ToolTip"));
		componentResourceManager.ApplyResources(df(), "TableLayoutPanelSpecColorXYZ");
		df().Controls.Add(dg(), 0, 0);
		df().Controls.Add(dh(), 1, 2);
		df().Controls.Add(di(), 1, 0);
		df().Controls.Add(dj(), 0, 2);
		df().Controls.Add(dk(), 1, 1);
		df().Controls.Add(dl(), 0, 1);
		df().Name = "TableLayoutPanelSpecColorXYZ";
		bz().SetToolTip(df(), componentResourceManager.GetString("TableLayoutPanelSpecColorXYZ.ToolTip"));
		componentResourceManager.ApplyResources(dg(), "LabelX1");
		dg().Name = "LabelX1";
		bz().SetToolTip(dg(), componentResourceManager.GetString("LabelX1.ToolTip"));
		componentResourceManager.ApplyResources(dh(), "LabelZValue2");
		dh().BorderStyle = BorderStyle.Fixed3D;
		dh().Name = "LabelZValue2";
		bz().SetToolTip(dh(), componentResourceManager.GetString("LabelZValue2.ToolTip"));
		componentResourceManager.ApplyResources(di(), "LabelXValue2");
		di().BorderStyle = BorderStyle.Fixed3D;
		di().Name = "LabelXValue2";
		bz().SetToolTip(di(), componentResourceManager.GetString("LabelXValue2.ToolTip"));
		componentResourceManager.ApplyResources(dj(), "LabelZ1");
		dj().Name = "LabelZ1";
		bz().SetToolTip(dj(), componentResourceManager.GetString("LabelZ1.ToolTip"));
		componentResourceManager.ApplyResources(dk(), "LabelYValue2");
		dk().BorderStyle = BorderStyle.Fixed3D;
		dk().Name = "LabelYValue2";
		bz().SetToolTip(dk(), componentResourceManager.GetString("LabelYValue2.ToolTip"));
		componentResourceManager.ApplyResources(dl(), "LabelY1");
		dl().Name = "LabelY1";
		bz().SetToolTip(dl(), componentResourceManager.GetString("LabelY1.ToolTip"));
		componentResourceManager.ApplyResources(cm(), "GroupSecondaryColor");
		cm().Controls.Add(cn());
		cm().Name = "GroupSecondaryColor";
		cm().TabStop = false;
		bz().SetToolTip(cm(), componentResourceManager.GetString("GroupSecondaryColor.ToolTip"));
		componentResourceManager.ApplyResources(cn(), "TableLayoutPanelTransColor");
		cn().Controls.Add(co(), 0, 0);
		cn().Controls.Add(cp(), 2, 0);
		cn().Controls.Add(cx(), 1, 0);
		cn().Name = "TableLayoutPanelTransColor";
		bz().SetToolTip(cn(), componentResourceManager.GetString("TableLayoutPanelTransColor.ToolTip"));
		componentResourceManager.ApplyResources(co(), "PictureBoxSecondaryColor");
		co().BackColor = SystemColors.Control;
		co().BorderStyle = BorderStyle.Fixed3D;
		co().Name = "PictureBoxSecondaryColor";
		co().TabStop = false;
		bz().SetToolTip(co(), componentResourceManager.GetString("PictureBoxSecondaryColor.ToolTip"));
		componentResourceManager.ApplyResources(cp(), "PanelSecondaryColorXYZ");
		cp().Controls.Add(cq());
		cp().Name = "PanelSecondaryColorXYZ";
		bz().SetToolTip(cp(), componentResourceManager.GetString("PanelSecondaryColorXYZ.ToolTip"));
		componentResourceManager.ApplyResources(cq(), "TableLayoutPanelTransColorXYZ");
		cq().Controls.Add(cr(), 0, 0);
		cq().Controls.Add(cs(), 1, 2);
		cq().Controls.Add(ct(), 1, 0);
		cq().Controls.Add(cu(), 0, 2);
		cq().Controls.Add(cv(), 1, 1);
		cq().Controls.Add(cw(), 0, 1);
		cq().Name = "TableLayoutPanelTransColorXYZ";
		bz().SetToolTip(cq(), componentResourceManager.GetString("TableLayoutPanelTransColorXYZ.ToolTip"));
		componentResourceManager.ApplyResources(cr(), "LabelSecondaryX1");
		cr().Name = "LabelSecondaryX1";
		bz().SetToolTip(cr(), componentResourceManager.GetString("LabelSecondaryX1.ToolTip"));
		componentResourceManager.ApplyResources(cs(), "LabelSecondaryZValue2");
		cs().BorderStyle = BorderStyle.Fixed3D;
		cs().Name = "LabelSecondaryZValue2";
		bz().SetToolTip(cs(), componentResourceManager.GetString("LabelSecondaryZValue2.ToolTip"));
		componentResourceManager.ApplyResources(ct(), "LabelSecondaryXValue2");
		ct().BorderStyle = BorderStyle.Fixed3D;
		ct().Name = "LabelSecondaryXValue2";
		bz().SetToolTip(ct(), componentResourceManager.GetString("LabelSecondaryXValue2.ToolTip"));
		componentResourceManager.ApplyResources(cu(), "LabelSecondaryZ1");
		cu().Name = "LabelSecondaryZ1";
		bz().SetToolTip(cu(), componentResourceManager.GetString("LabelSecondaryZ1.ToolTip"));
		componentResourceManager.ApplyResources(cv(), "LabelSecondaryYValue2");
		cv().BorderStyle = BorderStyle.Fixed3D;
		cv().Name = "LabelSecondaryYValue2";
		bz().SetToolTip(cv(), componentResourceManager.GetString("LabelSecondaryYValue2.ToolTip"));
		componentResourceManager.ApplyResources(cw(), "LabelSecondaryY1");
		cw().Name = "LabelSecondaryY1";
		bz().SetToolTip(cw(), componentResourceManager.GetString("LabelSecondaryY1.ToolTip"));
		componentResourceManager.ApplyResources(cx(), "TableLayoutPanelTransColorValues");
		cx().Controls.Add(cy(), 0, 0);
		cx().Controls.Add(cz(), 1, 0);
		cx().Controls.Add(c0(), 1, 2);
		cx().Controls.Add(c1(), 0, 1);
		cx().Controls.Add(c2(), 0, 2);
		cx().Controls.Add(c3(), 1, 1);
		cx().Name = "TableLayoutPanelTransColorValues";
		bz().SetToolTip(cx(), componentResourceManager.GetString("TableLayoutPanelTransColorValues.ToolTip"));
		componentResourceManager.ApplyResources(cy(), "LabelSecondaryX");
		cy().Name = "LabelSecondaryX";
		bz().SetToolTip(cy(), componentResourceManager.GetString("LabelSecondaryX.ToolTip"));
		componentResourceManager.ApplyResources(cz(), "LabelSecondaryXValue");
		cz().BorderStyle = BorderStyle.Fixed3D;
		cz().Name = "LabelSecondaryXValue";
		bz().SetToolTip(cz(), componentResourceManager.GetString("LabelSecondaryXValue.ToolTip"));
		componentResourceManager.ApplyResources(c0(), "LabelSecondaryZValue");
		c0().BorderStyle = BorderStyle.Fixed3D;
		c0().Name = "LabelSecondaryZValue";
		bz().SetToolTip(c0(), componentResourceManager.GetString("LabelSecondaryZValue.ToolTip"));
		componentResourceManager.ApplyResources(c1(), "LabelSecondaryY");
		c1().Name = "LabelSecondaryY";
		bz().SetToolTip(c1(), componentResourceManager.GetString("LabelSecondaryY.ToolTip"));
		componentResourceManager.ApplyResources(c2(), "LabelSecondaryZ");
		c2().Name = "LabelSecondaryZ";
		bz().SetToolTip(c2(), componentResourceManager.GetString("LabelSecondaryZ.ToolTip"));
		componentResourceManager.ApplyResources(c3(), "LabelSecondaryYValue");
		c3().BorderStyle = BorderStyle.Fixed3D;
		c3().Name = "LabelSecondaryYValue";
		bz().SetToolTip(c3(), componentResourceManager.GetString("LabelSecondaryYValue.ToolTip"));
		componentResourceManager.ApplyResources(ei(), "GroupMeasDetails");
		ei().Controls.Add(ej());
		ei().Controls.Add(ek());
		ei().Controls.Add(el());
		ei().Controls.Add(em());
		ei().Controls.Add(en());
		ei().Controls.Add(eo());
		ei().Controls.Add(ep());
		ei().Name = "GroupMeasDetails";
		ei().TabStop = false;
		bz().SetToolTip(ei(), componentResourceManager.GetString("GroupMeasDetails.ToolTip"));
		componentResourceManager.ApplyResources(ej(), "ButtonPrecisionHideShow");
		ej().Name = "ButtonPrecisionHideShow";
		bz().SetToolTip(ej(), componentResourceManager.GetString("ButtonPrecisionHideShow.ToolTip"));
		ej().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ek(), "ButtonConfigurePrecision");
		ek().Name = "ButtonConfigurePrecision";
		bz().SetToolTip(ek(), componentResourceManager.GetString("ButtonConfigurePrecision.ToolTip"));
		ek().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(el(), "lblPrecision");
		el().Name = "lblPrecision";
		bz().SetToolTip(el(), componentResourceManager.GetString("lblPrecision.ToolTip"));
		componentResourceManager.ApplyResources(em(), "LabelMeasCount");
		em().BackColor = Color.Gainsboro;
		em().BorderStyle = BorderStyle.Fixed3D;
		em().Name = "LabelMeasCount";
		bz().SetToolTip(em(), componentResourceManager.GetString("LabelMeasCount.ToolTip"));
		componentResourceManager.ApplyResources(en(), "LabelMeas");
		en().Name = "LabelMeas";
		bz().SetToolTip(en(), componentResourceManager.GetString("LabelMeas.ToolTip"));
		componentResourceManager.ApplyResources(eo(), "RichTextBoxMeas");
		eo().BackColor = Color.White;
		eo().Name = "RichTextBoxMeas";
		eo().ReadOnly = true;
		bz().SetToolTip(eo(), componentResourceManager.GetString("RichTextBoxMeas.ToolTip"));
		componentResourceManager.ApplyResources(ep(), "ButtonComputePrecision");
		ep().Name = "ButtonComputePrecision";
		bz().SetToolTip(ep(), componentResourceManager.GetString("ButtonComputePrecision.ToolTip"));
		ep().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(b6(), "GroupBoxConfig");
		b6().Controls.Add(b7());
		b6().Name = "GroupBoxConfig";
		b6().TabStop = false;
		bz().SetToolTip(b6(), componentResourceManager.GetString("GroupBoxConfig.ToolTip"));
		componentResourceManager.ApplyResources(b7(), "TLPConfigSettings");
		b7().Controls.Add(gh(), 0, 4);
		b7().Controls.Add(b8(), 1, 3);
		b7().Controls.Add(b9(), 1, 2);
		b7().Controls.Add(ca(), 0, 3);
		b7().Controls.Add(cb(), 0, 2);
		b7().Controls.Add(cc(), 1, 1);
		b7().Controls.Add(cd(), 0, 1);
		b7().Controls.Add(ce(), 1, 0);
		b7().Controls.Add(cf(), 0, 0);
		b7().Controls.Add(cg(), 1, 4);
		b7().Name = "TLPConfigSettings";
		bz().SetToolTip(b7(), componentResourceManager.GetString("TLPConfigSettings.ToolTip"));
		componentResourceManager.ApplyResources(gh(), "CheckBoxDualSpectrumGraphs");
		gh().Name = "CheckBoxDualSpectrumGraphs";
		bz().SetToolTip(gh(), componentResourceManager.GetString("CheckBoxDualSpectrumGraphs.ToolTip"));
		gh().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(b8(), "LabelActiveSpecsAddl");
		b8().Name = "LabelActiveSpecsAddl";
		bz().SetToolTip(b8(), componentResourceManager.GetString("LabelActiveSpecsAddl.ToolTip"));
		componentResourceManager.ApplyResources(b9(), "LabelActiveSpecsSec");
		b9().Name = "LabelActiveSpecsSec";
		bz().SetToolTip(b9(), componentResourceManager.GetString("LabelActiveSpecsSec.ToolTip"));
		componentResourceManager.ApplyResources(ca(), "LabelActiveSpecAddlLabel");
		ca().Name = "LabelActiveSpecAddlLabel";
		bz().SetToolTip(ca(), componentResourceManager.GetString("LabelActiveSpecAddlLabel.ToolTip"));
		componentResourceManager.ApplyResources(cb(), "LabelActiveSpecsSecLabel");
		cb().Name = "LabelActiveSpecsSecLabel";
		bz().SetToolTip(cb(), componentResourceManager.GetString("LabelActiveSpecsSecLabel.ToolTip"));
		componentResourceManager.ApplyResources(cc(), "LabelActiveSpecsPrim");
		cc().Name = "LabelActiveSpecsPrim";
		bz().SetToolTip(cc(), componentResourceManager.GetString("LabelActiveSpecsPrim.ToolTip"));
		componentResourceManager.ApplyResources(cd(), "LabelActiveSpecsPrimLabel");
		cd().Name = "LabelActiveSpecsPrimLabel";
		bz().SetToolTip(cd(), componentResourceManager.GetString("LabelActiveSpecsPrimLabel.ToolTip"));
		componentResourceManager.ApplyResources(ce(), "LabelOpticsConfig");
		ce().Name = "LabelOpticsConfig";
		bz().SetToolTip(ce(), componentResourceManager.GetString("LabelOpticsConfig.ToolTip"));
		componentResourceManager.ApplyResources(cf(), "Label2");
		cf().Name = "Label2";
		bz().SetToolTip(cf(), componentResourceManager.GetString("Label2.ToolTip"));
		componentResourceManager.ApplyResources(cg(), "ButtonFirmware");
		cg().Name = "ButtonFirmware";
		bz().SetToolTip(cg(), componentResourceManager.GetString("ButtonFirmware.ToolTip"));
		cg().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ey(), "PictureBoxCRSampleInfo");
		ey().Image = Resources.OutlineVertExpanded;
		ey().Name = "PictureBoxCRSampleInfo";
		ey().TabStop = false;
		bz().SetToolTip(ey(), componentResourceManager.GetString("PictureBoxCRSampleInfo.ToolTip"));
		componentResourceManager.ApplyResources(ez(), "PictureBoxCRMeasurementResult");
		ez().Image = Resources.OutlineVertExpanded;
		ez().Name = "PictureBoxCRMeasurementResult";
		ez().TabStop = false;
		bz().SetToolTip(ez(), componentResourceManager.GetString("PictureBoxCRMeasurementResult.ToolTip"));
		componentResourceManager.ApplyResources(e0(), "PictureBoxCROperation");
		e0().Image = Resources.OutlineVertExpanded;
		e0().Name = "PictureBoxCROperation";
		e0().TabStop = false;
		bz().SetToolTip(e0(), componentResourceManager.GetString("PictureBoxCROperation.ToolTip"));
		componentResourceManager.ApplyResources(e1(), "PictureBoxCRMeasRecipe");
		e1().Image = Resources.OutlineVertExpanded;
		e1().Name = "PictureBoxCRMeasRecipe";
		e1().TabStop = false;
		bz().SetToolTip(e1(), componentResourceManager.GetString("PictureBoxCRMeasRecipe.ToolTip"));
		componentResourceManager.ApplyResources(e2(), "PictureBoxCRARHC");
		e2().ErrorImage = Resources.OutlineVertExpanded;
		e2().Image = Resources.OutlineVertExpanded;
		e2().Name = "PictureBoxCRARHC";
		e2().TabStop = false;
		bz().SetToolTip(e2(), componentResourceManager.GetString("PictureBoxCRARHC.ToolTip"));
		componentResourceManager.ApplyResources(e5(), "PictureBoxCRTemplate");
		e5().Image = Resources.OutlineVertExpanded;
		e5().Name = "PictureBoxCRTemplate";
		e5().TabStop = false;
		bz().SetToolTip(e5(), componentResourceManager.GetString("PictureBoxCRTemplate.ToolTip"));
		componentResourceManager.ApplyResources(e3(), "PictureBoxCRSpectrumColor");
		e3().Image = Resources.OutlineVertExpanded;
		e3().Name = "PictureBoxCRSpectrumColor";
		e3().TabStop = false;
		bz().SetToolTip(e3(), componentResourceManager.GetString("PictureBoxCRSpectrumColor.ToolTip"));
		componentResourceManager.ApplyResources(e4(), "PictureBoxCRSecondaryColor");
		e4().Image = Resources.OutlineVertExpanded;
		e4().Name = "PictureBoxCRSecondaryColor";
		e4().TabStop = false;
		bz().SetToolTip(e4(), componentResourceManager.GetString("PictureBoxCRSecondaryColor.ToolTip"));
		componentResourceManager.ApplyResources(e6(), "PictureBoxCRMeasDetails");
		e6().Image = Resources.OutlineVertExpanded;
		e6().Name = "PictureBoxCRMeasDetails";
		e6().TabStop = false;
		bz().SetToolTip(e6(), componentResourceManager.GetString("PictureBoxCRMeasDetails.ToolTip"));
		componentResourceManager.ApplyResources(fc(), "PanelControlsResults");
		fc().Controls.Add(b5());
		fc().Name = "PanelControlsResults";
		bz().SetToolTip(fc(), componentResourceManager.GetString("PanelControlsResults.ToolTip"));
		componentResourceManager.ApplyResources(b4(), "ButtonHideTabControl");
		b4().Image = Resources.Hide;
		b4().Name = "ButtonHideTabControl";
		bz().SetToolTip(b4(), componentResourceManager.GetString("ButtonHideTabControl.ToolTip"));
		b4().UseVisualStyleBackColor = true;
		gg().o((gq)null);
		componentResourceManager.ApplyResources(gg(), "GraphMeasThickness2");
		gg().v(A_0: false);
		gg().AllowDrop = true;
		gg().u(A_0: false);
		gg().BackColor = Color.Transparent;
		gg().w(A_0: false);
		gg().al(A_0: false);
		gg().x(A_0: false);
		gg().ah(A_0: false);
		gg().r("Right-click activates/deactivates Cursor");
		gg().y(A_0: true);
		gg().z(A_0: false);
		gg().aa(A_0: false);
		gg().ac(A_0: false);
		gg().ab(A_0: false);
		gg().o((fz)null);
		gg().ad(A_0: false);
		gg().Name = "GraphMeasThickness2";
		gg().q("SiO2 on Si Spectrum taken 01/31/2007 12:34 PM ");
		gg().q(1);
		gg().t(A_0: false);
		gg().am(A_0: false);
		gg().t((string)null);
		gg().an(A_0: false);
		gg().ae(A_0: false);
		gg().af(A_0: false);
		gg().ag(A_0: true);
		gg().o((fu)null);
		bz().SetToolTip(gg(), componentResourceManager.GetString("GraphMeasThickness2.ToolTip"));
		gg().aj(A_0: false);
		gg().ai(A_0: true);
		gg().s((string)null);
		componentResourceManager.ApplyResources(bh(), "sPicBox");
		bh().h(A_0: true);
		bh().BackColor = Color.Gray;
		bh().h(0);
		bh().Name = "sPicBox";
		bh().TabStop = false;
		bz().SetToolTip(bh(), componentResourceManager.GetString("sPicBox.ToolTip"));
		bh().i(0);
		bc().o((gq)null);
		componentResourceManager.ApplyResources(bc(), "GraphMeasIndex");
		bc().v(A_0: false);
		bc().AllowDrop = true;
		bc().u(A_0: false);
		bc().BackColor = Color.Transparent;
		bc().w(A_0: false);
		bc().al(A_0: true);
		bc().x(A_0: false);
		bc().ah(A_0: false);
		bc().r("Right-click activates/deactivates Cursor");
		bc().y(A_0: true);
		bc().z(A_0: false);
		bc().aa(A_0: false);
		bc().ac(A_0: true);
		bc().ab(A_0: false);
		bc().o((fz)null);
		bc().ad(A_0: false);
		bc().Name = "GraphMeasIndex";
		bc().q("SiO2 on Si Spectrum taken 01/31/2007 12:34 PM ");
		bc().q(1);
		bc().t(A_0: false);
		bc().am(A_0: false);
		bc().t((string)null);
		bc().an(A_0: false);
		bc().ae(A_0: false);
		bc().af(A_0: false);
		bc().ag(A_0: true);
		bc().o((fu)null);
		bz().SetToolTip(bc(), componentResourceManager.GetString("GraphMeasIndex.ToolTip"));
		bc().aj(A_0: false);
		bc().ai(A_0: false);
		bc().s((string)null);
		ba().o((gq)null);
		componentResourceManager.ApplyResources(ba(), "GraphMeasFFTThickness");
		ba().v(A_0: false);
		ba().AllowDrop = true;
		ba().u(A_0: false);
		ba().BackColor = Color.Transparent;
		ba().w(A_0: false);
		ba().al(A_0: true);
		ba().x(A_0: false);
		ba().ah(A_0: false);
		ba().r("Right-click activates/deactivates Cursor");
		ba().y(A_0: true);
		ba().z(A_0: false);
		ba().aa(A_0: false);
		ba().ac(A_0: false);
		ba().ab(A_0: false);
		ba().o((fz)null);
		ba().ad(A_0: false);
		ba().Name = "GraphMeasFFTThickness";
		ba().q("SiO2 on Si Spectrum taken 01/31/2007 12:34 PM ");
		ba().q(1);
		ba().t(A_0: false);
		ba().am(A_0: false);
		ba().t((string)null);
		ba().an(A_0: false);
		ba().ae(A_0: false);
		ba().af(A_0: false);
		ba().ag(A_0: true);
		ba().o((fu)null);
		bz().SetToolTip(ba(), componentResourceManager.GetString("GraphMeasFFTThickness.ToolTip"));
		ba().aj(A_0: false);
		ba().ai(A_0: false);
		ba().s((string)null);
		bb().o((gq)null);
		componentResourceManager.ApplyResources(bb(), "GraphMeasThickness");
		bb().v(A_0: false);
		bb().AllowDrop = true;
		bb().u(A_0: false);
		bb().BackColor = Color.Maroon;
		bb().w(A_0: false);
		bb().al(A_0: true);
		bb().x(A_0: false);
		bb().ah(A_0: false);
		bb().r("Right-click activates/deactivates Cursor");
		bb().y(A_0: true);
		bb().z(A_0: false);
		bb().aa(A_0: false);
		bb().ac(A_0: false);
		bb().ab(A_0: false);
		bb().o((fz)null);
		bb().ad(A_0: false);
		bb().Name = "GraphMeasThickness";
		bb().q("SiO2 on Si Spectrum taken 01/31/2007 12:34 PM ");
		bb().q(1);
		bb().t(A_0: false);
		bb().am(A_0: false);
		bb().t((string)null);
		bb().an(A_0: false);
		bb().ae(A_0: false);
		bb().af(A_0: false);
		bb().ag(A_0: true);
		bb().o((fu)null);
		bz().SetToolTip(bb(), componentResourceManager.GetString("GraphMeasThickness.ToolTip"));
		bb().aj(A_0: false);
		bb().ai(A_0: true);
		bb().s((string)null);
		componentResourceManager.ApplyResources(this, "$this");
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = SystemColors.ButtonFace;
		base.Controls.Add(gg());
		base.Controls.Add(b4());
		base.Controls.Add(bi());
		base.Controls.Add(bs());
		base.Controls.Add(bh());
		base.Controls.Add(bg());
		base.Controls.Add(bf());
		base.Controls.Add(be());
		base.Controls.Add(bd());
		base.Controls.Add(bc());
		base.Controls.Add(fc());
		base.Controls.Add(ba());
		base.Controls.Add(bb());
		DoubleBuffered = true;
		base.Name = "FIControlPanelMeasModule";
		bz().SetToolTip(this, componentResourceManager.GetString("$this.ToolTip"));
		((ISupportInitialize)bl()).EndInit();
		bp().ResumeLayout(performLayout: false);
		bp().PerformLayout();
		((ISupportInitialize)bq()).EndInit();
		bs().ResumeLayout(performLayout: false);
		bu().ResumeLayout(performLayout: false);
		bu().PerformLayout();
		((ISupportInitialize)bw()).EndInit();
		bt().ResumeLayout(performLayout: false);
		bt().PerformLayout();
		f5().ResumeLayout(performLayout: false);
		f5().PerformLayout();
		((ISupportInitialize)br()).EndInit();
		b0().ResumeLayout(performLayout: false);
		b2().ResumeLayout(performLayout: false);
		b5().ResumeLayout(performLayout: false);
		b5().PerformLayout();
		((ISupportInitialize)eh()).EndInit();
		es().ResumeLayout(performLayout: false);
		es().PerformLayout();
		et().ResumeLayout(performLayout: false);
		et().PerformLayout();
		dz().ResumeLayout(performLayout: false);
		fx().ResumeLayout(performLayout: false);
		fx().PerformLayout();
		fl().ResumeLayout(performLayout: false);
		fl().PerformLayout();
		fm().ResumeLayout(performLayout: false);
		fm().PerformLayout();
		fn().ResumeLayout(performLayout: false);
		fn().PerformLayout();
		fz().ResumeLayout(performLayout: false);
		fz().PerformLayout();
		fq().ResumeLayout(performLayout: false);
		fq().PerformLayout();
		eq().ResumeLayout(performLayout: false);
		eq().PerformLayout();
		ea().ResumeLayout(performLayout: false);
		ea().PerformLayout();
		fa().ResumeLayout(performLayout: false);
		fa().PerformLayout();
		f0().ResumeLayout(performLayout: false);
		e9().ResumeLayout(performLayout: false);
		e9().PerformLayout();
		ee().ResumeLayout(performLayout: false);
		ee().PerformLayout();
		fb().ResumeLayout(performLayout: false);
		dv().ResumeLayout(performLayout: false);
		dm().ResumeLayout(performLayout: false);
		dn().ResumeLayout(performLayout: false);
		dr().ResumeLayout(performLayout: false);
		ch().ResumeLayout(performLayout: false);
		c4().ResumeLayout(performLayout: false);
		c4().PerformLayout();
		c5().ResumeLayout(performLayout: false);
		c5().PerformLayout();
		c6().ResumeLayout(performLayout: false);
		c6().PerformLayout();
		((ISupportInitialize)dd()).EndInit();
		de().ResumeLayout(performLayout: false);
		de().PerformLayout();
		df().ResumeLayout(performLayout: false);
		df().PerformLayout();
		cm().ResumeLayout(performLayout: false);
		cm().PerformLayout();
		cn().ResumeLayout(performLayout: false);
		cn().PerformLayout();
		((ISupportInitialize)co()).EndInit();
		cp().ResumeLayout(performLayout: false);
		cp().PerformLayout();
		cq().ResumeLayout(performLayout: false);
		cq().PerformLayout();
		cx().ResumeLayout(performLayout: false);
		cx().PerformLayout();
		ei().ResumeLayout(performLayout: false);
		ei().PerformLayout();
		b6().ResumeLayout(performLayout: false);
		b6().PerformLayout();
		b7().ResumeLayout(performLayout: false);
		b7().PerformLayout();
		((ISupportInitialize)ey()).EndInit();
		((ISupportInitialize)ez()).EndInit();
		((ISupportInitialize)e0()).EndInit();
		((ISupportInitialize)e1()).EndInit();
		((ISupportInitialize)e2()).EndInit();
		((ISupportInitialize)e5()).EndInit();
		((ISupportInitialize)e3()).EndInit();
		((ISupportInitialize)e4()).EndInit();
		((ISupportInitialize)e6()).EndInit();
		fc().ResumeLayout(performLayout: false);
		fc().PerformLayout();
		((ISupportInitialize)bh()).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual fl ba()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(fl A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual fl bb()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(fl A_0)
	{
		fl.c a_ = i;
		this.m_c?.p(a_);
		this.m_c = A_0;
		this.m_c?.o(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual fl bc()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(fl A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox bd()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(ComboBox A_0)
	{
		EventHandler value = an;
		ComboBox comboBox = this.m_e;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_e = A_0;
		comboBox = this.m_e;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label be()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Label A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button bf()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Button A_0)
	{
		EventHandler value = ae;
		Button button = this.m_g;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_g = A_0;
		button = this.m_g;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button bg()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Button A_0)
	{
		EventHandler value = ad;
		Button button = this.m_h;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_h = A_0;
		button = this.m_h;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual e1 bh()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(e1 A_0)
	{
		ScrollEventHandler a_ = k;
		this.m_i?.i(a_);
		this.m_i = A_0;
		this.m_i?.h(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button bi()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Button A_0)
	{
		EventHandler value = af;
		Button button = this.m_j;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_j = A_0;
		button = this.m_j;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual VScrollBar bj()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(VScrollBar A_0)
	{
		ScrollEventHandler value = j;
		VScrollBar vScrollBar = this.m_k;
		if (vScrollBar != null)
		{
			vScrollBar.Scroll -= value;
		}
		this.m_k = A_0;
		vScrollBar = this.m_k;
		if (vScrollBar != null)
		{
			vScrollBar.Scroll += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual HScrollBar bk()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(HScrollBar A_0)
	{
		ScrollEventHandler value = j;
		HScrollBar hScrollBar = this.m_l;
		if (hScrollBar != null)
		{
			hScrollBar.Scroll -= value;
		}
		this.m_l = A_0;
		hScrollBar = this.m_l;
		if (hScrollBar != null)
		{
			hScrollBar.Scroll += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TrackBar bl()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TrackBar A_0)
	{
		EventHandler value = x;
		TrackBar trackBar = this.m_m;
		if (trackBar != null)
		{
			trackBar.Scroll -= value;
		}
		this.m_m = A_0;
		trackBar = this.m_m;
		if (trackBar != null)
		{
			trackBar.Scroll += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bm()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Label A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button bn()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(Button A_0)
	{
		EventHandler value = y;
		Button button = this.m_o;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_o = A_0;
		button = this.m_o;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button bo()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(Button A_0)
	{
		EventHandler value = w;
		Button button = this.m_p;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_p = A_0;
		button = this.m_p;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel bp()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Panel A_0)
	{
		ScrollEventHandler value = i;
		Panel panel = this.m_q;
		if (panel != null)
		{
			panel.Scroll -= value;
		}
		this.m_q = A_0;
		panel = this.m_q;
		if (panel != null)
		{
			panel.Scroll += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox bq()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(PictureBox A_0)
	{
		MouseEventHandler value = j;
		PictureBox pictureBox = this.m_r;
		if (pictureBox != null)
		{
			pictureBox.MouseClick -= value;
		}
		this.m_r = A_0;
		pictureBox = this.m_r;
		if (pictureBox != null)
		{
			pictureBox.MouseClick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox br()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(PictureBox A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabControl bs()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TabControl A_0)
	{
		EventHandler value = v;
		EventHandler value2 = u;
		TabControl tabControl = this.m_t;
		if (tabControl != null)
		{
			tabControl.Resize -= value;
			tabControl.SelectedIndexChanged -= value2;
		}
		this.m_t = A_0;
		tabControl = this.m_t;
		if (tabControl != null)
		{
			tabControl.Resize += value;
			tabControl.SelectedIndexChanged += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage bt()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TabPage A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage bu()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(TabPage A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button bv()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(Button A_0)
	{
		EventHandler value = t;
		Button button = this.m_w;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_w = A_0;
		button = this.m_w;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TrackBar bw()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(TrackBar A_0)
	{
		EventHandler value = s;
		TrackBar trackBar = this.m_x;
		if (trackBar != null)
		{
			trackBar.Scroll -= value;
		}
		this.m_x = A_0;
		trackBar = this.m_x;
		if (trackBar != null)
		{
			trackBar.Scroll += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button bx()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(Button A_0)
	{
		EventHandler value = y;
		Button button = this.m_y;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_y = A_0;
		button = this.m_y;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label by()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Label A_0)
	{
		this.m_z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip bz()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(ToolTip A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ContextMenuStrip b0()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(ContextMenuStrip A_0)
	{
		this.m_ab = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem b1()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(ToolStripMenuItem A_0)
	{
		EventHandler value = r;
		ToolStripMenuItem toolStripMenuItem = this.m_ac;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_ac = A_0;
		toolStripMenuItem = this.m_ac;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ContextMenuStrip b2()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(ContextMenuStrip A_0)
	{
		this.m_ad = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem b3()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(ToolStripMenuItem A_0)
	{
		EventHandler value = q;
		ToolStripMenuItem toolStripMenuItem = this.m_ae;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_ae = A_0;
		toolStripMenuItem = this.m_ae;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button b4()
	{
		return this.m_af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(Button A_0)
	{
		EventHandler value = p;
		Button button = this.m_af;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_af = A_0;
		button = this.m_af;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel b5()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TableLayoutPanel A_0)
	{
		this.m_ag = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox b6()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(GroupBox A_0)
	{
		this.m_ah = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel b7()
	{
		return this.m_ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(TableLayoutPanel A_0)
	{
		this.m_ai = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b8()
	{
		return this.m_aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(Label A_0)
	{
		this.m_aj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b9()
	{
		return this.m_ak;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(Label A_0)
	{
		this.m_ak = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ca()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(Label A_0)
	{
		this.m_al = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cb()
	{
		return this.m_am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(Label A_0)
	{
		this.m_am = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cc()
	{
		return this.m_an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(Label A_0)
	{
		this.m_an = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cd()
	{
		return this.m_ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(Label A_0)
	{
		this.m_ao = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ce()
	{
		return this.m_ap;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(Label A_0)
	{
		this.m_ap = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cf()
	{
		return this.m_aq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(Label A_0)
	{
		this.m_aq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button cg()
	{
		return this.m_ar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(Button A_0)
	{
		EventHandler value = o;
		Button button = this.m_ar;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ar = A_0;
		button = this.m_ar;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ch()
	{
		return this.m_as;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(GroupBox A_0)
	{
		this.m_as = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ci()
	{
		return this.m_at;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(Button A_0)
	{
		EventHandler value = ao;
		Button button = this.m_at;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_at = A_0;
		button = this.m_at;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button cj()
	{
		return this.m_au;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(Button A_0)
	{
		EventHandler value = aq;
		Button button = this.m_au;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_au = A_0;
		button = this.m_au;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ck()
	{
		return this.m_av;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(Label A_0)
	{
		this.m_av = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button cl()
	{
		return this.m_aw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(Button A_0)
	{
		EventHandler value = ap;
		Button button = this.m_aw;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_aw = A_0;
		button = this.m_aw;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox cm()
	{
		return this.m_ax;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(GroupBox A_0)
	{
		this.m_ax = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel cn()
	{
		return this.m_ay;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(TableLayoutPanel A_0)
	{
		this.m_ay = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox co()
	{
		return this.m_az;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(PictureBox A_0)
	{
		this.m_az = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel cp()
	{
		return this.m_a0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Panel A_0)
	{
		this.m_a0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel cq()
	{
		return this.m_a1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(TableLayoutPanel A_0)
	{
		this.m_a1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cr()
	{
		return this.m_a2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(Label A_0)
	{
		this.m_a2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cs()
	{
		return this.m_a3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(Label A_0)
	{
		this.m_a3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ct()
	{
		return this.m_a4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(Label A_0)
	{
		this.m_a4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cu()
	{
		return this.m_a5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(Label A_0)
	{
		this.m_a5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cv()
	{
		return this.m_a6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(Label A_0)
	{
		this.m_a6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cw()
	{
		return this.m_a7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(Label A_0)
	{
		this.m_a7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel cx()
	{
		return this.m_a8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(TableLayoutPanel A_0)
	{
		this.m_a8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cy()
	{
		return this.m_a9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aa(Label A_0)
	{
		this.m_a9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cz()
	{
		return this.m_ba;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(Label A_0)
	{
		this.m_ba = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c0()
	{
		return this.m_bb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(Label A_0)
	{
		this.m_bb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c1()
	{
		return this.m_bc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(Label A_0)
	{
		this.m_bc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c2()
	{
		return this.m_bd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ae(Label A_0)
	{
		this.m_bd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c3()
	{
		return this.m_be;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void af(Label A_0)
	{
		this.m_be = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox c4()
	{
		return this.m_bf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(GroupBox A_0)
	{
		this.m_bf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel c5()
	{
		return this.m_bg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(TableLayoutPanel A_0)
	{
		this.m_bg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel c6()
	{
		return this.m_bh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(TableLayoutPanel A_0)
	{
		this.m_bh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c7()
	{
		return this.m_bi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ag(Label A_0)
	{
		this.m_bi = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c8()
	{
		return this.m_bj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ah(Label A_0)
	{
		this.m_bj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c9()
	{
		return this.m_bk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ai(Label A_0)
	{
		this.m_bk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label da()
	{
		return this.m_bl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aj(Label A_0)
	{
		this.m_bl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label db()
	{
		return this.m_bm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ak(Label A_0)
	{
		this.m_bm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label dc()
	{
		return this.m_bn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void al(Label A_0)
	{
		this.m_bn = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox dd()
	{
		return this.m_bo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(PictureBox A_0)
	{
		this.m_bo = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel de()
	{
		return this.m_bp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Panel A_0)
	{
		this.m_bp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel df()
	{
		return this.m_bq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(TableLayoutPanel A_0)
	{
		this.m_bq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label dg()
	{
		return this.m_br;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void am(Label A_0)
	{
		this.m_br = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label dh()
	{
		return this.m_bs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void an(Label A_0)
	{
		this.m_bs = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label di()
	{
		return this.m_bt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ao(Label A_0)
	{
		this.m_bt = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label dj()
	{
		return this.m_bu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ap(Label A_0)
	{
		this.m_bu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label dk()
	{
		return this.m_bv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aq(Label A_0)
	{
		this.m_bv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label dl()
	{
		return this.m_bw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ar(Label A_0)
	{
		this.m_bw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabControl dm()
	{
		return this.m_bx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(TabControl A_0)
	{
		EventHandler value = am;
		TabControlCancelEventHandler value2 = i;
		TabControl tabControl = this.m_bx;
		if (tabControl != null)
		{
			tabControl.SelectedIndexChanged -= value;
			tabControl.Selecting -= value2;
		}
		this.m_bx = A_0;
		tabControl = this.m_bx;
		if (tabControl != null)
		{
			tabControl.SelectedIndexChanged += value;
			tabControl.Selecting += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage dn()
	{
		return this.m_by;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(TabPage A_0)
	{
		this.m_by = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button @do()
	{
		return this.m_bz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(Button A_0)
	{
		EventHandler value = aj;
		Button button = this.m_bz;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_bz = A_0;
		button = this.m_bz;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label dp()
	{
		return this.m_b0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void @as(Label A_0)
	{
		this.m_b0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button dq()
	{
		return this.m_b1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(Button A_0)
	{
		EventHandler value = al;
		Button button = this.m_b1;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_b1 = A_0;
		button = this.m_b1;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage dr()
	{
		return this.m_b2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(TabPage A_0)
	{
		this.m_b2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ds()
	{
		return this.m_b3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(Button A_0)
	{
		EventHandler value = ai;
		MouseEventHandler value2 = i;
		Button button = this.m_b3;
		if (button != null)
		{
			button.Click -= value;
			button.MouseUp -= value2;
		}
		this.m_b3 = A_0;
		button = this.m_b3;
		if (button != null)
		{
			button.Click += value;
			button.MouseUp += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label dt()
	{
		return this.m_b4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void at(Label A_0)
	{
		this.m_b4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button du()
	{
		return this.m_b5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(Button A_0)
	{
		EventHandler value = ak;
		Button button = this.m_b5;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_b5 = A_0;
		button = this.m_b5;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox dv()
	{
		return this.m_b6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(GroupBox A_0)
	{
		this.m_b6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button dw()
	{
		return this.m_b7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(Button A_0)
	{
		EventHandler value = ax;
		MouseEventHandler value2 = i;
		Button button = this.m_b7;
		if (button != null)
		{
			button.Click -= value;
			button.MouseUp -= value2;
		}
		this.m_b7 = A_0;
		button = this.m_b7;
		if (button != null)
		{
			button.Click += value;
			button.MouseUp += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label dx()
	{
		return this.m_b8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void au(Label A_0)
	{
		this.m_b8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button dy()
	{
		return this.m_b9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(Button A_0)
	{
		EventHandler value = ar;
		Button button = this.m_b9;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_b9 = A_0;
		button = this.m_b9;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox dz()
	{
		return this.m_ca;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(GroupBox A_0)
	{
		this.m_ca = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label d0()
	{
		return this.m_cb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void av(Label A_0)
	{
		this.m_cb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label d1()
	{
		return this.m_cc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aw(Label A_0)
	{
		this.m_cc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button d2()
	{
		return this.m_cd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aa(Button A_0)
	{
		EventHandler value = av;
		Button button = this.m_cd;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_cd = A_0;
		button = this.m_cd;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label d3()
	{
		return this.m_ce;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ax(Label A_0)
	{
		this.m_ce = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label d4()
	{
		return this.m_cf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ay(Label A_0)
	{
		this.m_cf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label d5()
	{
		return this.m_cg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void az(Label A_0)
	{
		this.m_cg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label d6()
	{
		return this.m_ch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a0(Label A_0)
	{
		this.m_ch = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label d7()
	{
		return this.m_ci;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a1(Label A_0)
	{
		this.m_ci = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ProgressBar d8()
	{
		return this.m_cj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(ProgressBar A_0)
	{
		this.m_cj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button d9()
	{
		return this.m_ck;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(Button A_0)
	{
		EventHandler value = au;
		Button button = this.m_ck;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ck = A_0;
		button = this.m_ck;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ea()
	{
		return this.m_cl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(GroupBox A_0)
	{
		this.m_cl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button eb()
	{
		return this.m_cm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(Button A_0)
	{
		EventHandler value = aw;
		Button button = this.m_cm;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_cm = A_0;
		button = this.m_cm;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ec()
	{
		return this.m_cn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(Button A_0)
	{
		EventHandler value = at;
		Button button = this.m_cn;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_cn = A_0;
		button = this.m_cn;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ed()
	{
		return this.m_co;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ae(Button A_0)
	{
		EventHandler value = ac;
		Button button = this.m_co;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_co = A_0;
		button = this.m_co;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ee()
	{
		return this.m_cp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(TableLayoutPanel A_0)
	{
		this.m_cp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ef()
	{
		return this.m_cq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a2(Label A_0)
	{
		this.m_cq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox eg()
	{
		return this.m_cr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(ComboBox A_0)
	{
		EventHandler value = ag;
		ComboBox comboBox = this.m_cr;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_cr = A_0;
		comboBox = this.m_cr;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox eh()
	{
		return this.m_cs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(PictureBox A_0)
	{
		this.m_cs = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ei()
	{
		return this.m_ct;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(GroupBox A_0)
	{
		this.m_ct = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ej()
	{
		return this.m_cu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void af(Button A_0)
	{
		EventHandler value = z;
		Button button = this.m_cu;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_cu = A_0;
		button = this.m_cu;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ek()
	{
		return this.m_cv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ag(Button A_0)
	{
		EventHandler value = aa;
		Button button = this.m_cv;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_cv = A_0;
		button = this.m_cv;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label el()
	{
		return this.m_cw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a3(Label A_0)
	{
		this.m_cw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label em()
	{
		return this.m_cx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a4(Label A_0)
	{
		this.m_cx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label en()
	{
		return this.m_cy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a5(Label A_0)
	{
		this.m_cy = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RichTextBox eo()
	{
		return this.m_cz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(RichTextBox A_0)
	{
		this.m_cz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ep()
	{
		return this.m_c0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ah(Button A_0)
	{
		EventHandler value = ab;
		Button button = this.m_c0;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_c0 = A_0;
		button = this.m_c0;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox eq()
	{
		return this.m_c1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(GroupBox A_0)
	{
		this.m_c1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox er()
	{
		return this.m_c2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TextBox A_0)
	{
		this.m_c2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox es()
	{
		return this.m_c3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(GroupBox A_0)
	{
		this.m_c3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel et()
	{
		return this.m_c4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(TableLayoutPanel A_0)
	{
		this.m_c4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label eu()
	{
		return this.m_c5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a6(Label A_0)
	{
		this.m_c5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx ev()
	{
		return this.m_c6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(hx A_0)
	{
		EventHandler value = ah;
		hx hx2 = this.m_c6;
		if (hx2 != null)
		{
			hx2.TextChanged -= value;
		}
		this.m_c6 = A_0;
		hx2 = this.m_c6;
		if (hx2 != null)
		{
			hx2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ew()
	{
		return this.m_c7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a7(Label A_0)
	{
		this.m_c7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx ex()
	{
		return this.m_c8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(hx A_0)
	{
		EventHandler value = @as;
		hx hx2 = this.m_c8;
		if (hx2 != null)
		{
			hx2.TextChanged -= value;
		}
		this.m_c8 = A_0;
		hx2 = this.m_c8;
		if (hx2 != null)
		{
			hx2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox ey()
	{
		return this.m_c9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(PictureBox A_0)
	{
		EventHandler value = k;
		EventHandler value2 = j;
		EventHandler value3 = i;
		PictureBox pictureBox = this.m_c9;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter -= value;
			pictureBox.MouseLeave -= value2;
			pictureBox.Click -= value3;
		}
		this.m_c9 = A_0;
		pictureBox = this.m_c9;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter += value;
			pictureBox.MouseLeave += value2;
			pictureBox.Click += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox ez()
	{
		return this.m_da;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(PictureBox A_0)
	{
		EventHandler value = k;
		EventHandler value2 = j;
		EventHandler value3 = i;
		PictureBox pictureBox = this.m_da;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter -= value;
			pictureBox.MouseLeave -= value2;
			pictureBox.Click -= value3;
		}
		this.m_da = A_0;
		pictureBox = this.m_da;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter += value;
			pictureBox.MouseLeave += value2;
			pictureBox.Click += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox e0()
	{
		return this.m_db;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(PictureBox A_0)
	{
		EventHandler value = k;
		EventHandler value2 = j;
		EventHandler value3 = i;
		PictureBox pictureBox = this.m_db;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter -= value;
			pictureBox.MouseLeave -= value2;
			pictureBox.Click -= value3;
		}
		this.m_db = A_0;
		pictureBox = this.m_db;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter += value;
			pictureBox.MouseLeave += value2;
			pictureBox.Click += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox e1()
	{
		return this.m_dc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(PictureBox A_0)
	{
		EventHandler value = k;
		EventHandler value2 = j;
		EventHandler value3 = i;
		PictureBox pictureBox = this.m_dc;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter -= value;
			pictureBox.MouseLeave -= value2;
			pictureBox.Click -= value3;
		}
		this.m_dc = A_0;
		pictureBox = this.m_dc;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter += value;
			pictureBox.MouseLeave += value2;
			pictureBox.Click += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox e2()
	{
		return this.m_dd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(PictureBox A_0)
	{
		EventHandler value = k;
		EventHandler value2 = j;
		EventHandler value3 = i;
		PictureBox pictureBox = this.m_dd;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter -= value;
			pictureBox.MouseLeave -= value2;
			pictureBox.Click -= value3;
		}
		this.m_dd = A_0;
		pictureBox = this.m_dd;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter += value;
			pictureBox.MouseLeave += value2;
			pictureBox.Click += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox e3()
	{
		return this.m_de;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(PictureBox A_0)
	{
		EventHandler value = k;
		EventHandler value2 = j;
		EventHandler value3 = i;
		PictureBox pictureBox = this.m_de;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter -= value;
			pictureBox.MouseLeave -= value2;
			pictureBox.Click -= value3;
		}
		this.m_de = A_0;
		pictureBox = this.m_de;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter += value;
			pictureBox.MouseLeave += value2;
			pictureBox.Click += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox e4()
	{
		return this.m_df;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(PictureBox A_0)
	{
		EventHandler value = k;
		EventHandler value2 = j;
		EventHandler value3 = i;
		PictureBox pictureBox = this.m_df;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter -= value;
			pictureBox.MouseLeave -= value2;
			pictureBox.Click -= value3;
		}
		this.m_df = A_0;
		pictureBox = this.m_df;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter += value;
			pictureBox.MouseLeave += value2;
			pictureBox.Click += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox e5()
	{
		return this.m_dg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(PictureBox A_0)
	{
		EventHandler value = k;
		EventHandler value2 = j;
		EventHandler value3 = i;
		PictureBox pictureBox = this.m_dg;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter -= value;
			pictureBox.MouseLeave -= value2;
			pictureBox.Click -= value3;
		}
		this.m_dg = A_0;
		pictureBox = this.m_dg;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter += value;
			pictureBox.MouseLeave += value2;
			pictureBox.Click += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox e6()
	{
		return this.m_dh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(PictureBox A_0)
	{
		EventHandler value = k;
		EventHandler value2 = j;
		EventHandler value3 = i;
		PictureBox pictureBox = this.m_dh;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter -= value;
			pictureBox.MouseLeave -= value2;
			pictureBox.Click -= value3;
		}
		this.m_dh = A_0;
		pictureBox = this.m_dh;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter += value;
			pictureBox.MouseLeave += value2;
			pictureBox.Click += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label e7()
	{
		return this.m_di;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a8(Label A_0)
	{
		this.m_di = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel e9()
	{
		return this.m_dj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(TableLayoutPanel A_0)
	{
		this.m_dj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel fa()
	{
		return this.m_dk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(TableLayoutPanel A_0)
	{
		this.m_dk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel fb()
	{
		return this.m_dl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(TableLayoutPanel A_0)
	{
		this.m_dl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel fc()
	{
		return this.m_dm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(Panel A_0)
	{
		this.m_dm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual er fe()
	{
		return this.m_dn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(er A_0)
	{
		PaintEventHandler value = i;
		er er2 = this.m_dn;
		if (er2 != null)
		{
			er2.Paint -= value;
		}
		this.m_dn = A_0;
		er2 = this.m_dn;
		if (er2 != null)
		{
			er2.Paint += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel fl()
	{
		return this.m_do;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(TableLayoutPanel A_0)
	{
		this.m_do = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel fm()
	{
		return this.m_dp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(TableLayoutPanel A_0)
	{
		this.m_dp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel fn()
	{
		return this.m_dq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(TableLayoutPanel A_0)
	{
		this.m_dq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel fq()
	{
		return this.m_dr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(TableLayoutPanel A_0)
	{
		this.m_dr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel fx()
	{
		return this.m_ds;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(TableLayoutPanel A_0)
	{
		this.m_ds = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel fz()
	{
		return this.m_dt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aa(TableLayoutPanel A_0)
	{
		this.m_dt = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel f0()
	{
		return this.m_du;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(TableLayoutPanel A_0)
	{
		this.m_du = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button f1()
	{
		return this.m_dv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ai(Button A_0)
	{
		this.m_dv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button f2()
	{
		return this.m_dw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aj(Button A_0)
	{
		this.m_dw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button f3()
	{
		return this.m_dx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ak(Button A_0)
	{
		this.m_dx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button f4()
	{
		return this.m_dy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void al(Button A_0)
	{
		this.m_dy = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel f5()
	{
		return this.m_dz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(Panel A_0)
	{
		this.m_dz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label f6()
	{
		return this.m_d0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a9(Label A_0)
	{
		this.m_d0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button f7()
	{
		return this.m_d1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void am(Button A_0)
	{
		this.m_d1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button f8()
	{
		return this.m_d2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void an(Button A_0)
	{
		this.m_d2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button f9()
	{
		return this.m_d3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ao(Button A_0)
	{
		this.m_d3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ga()
	{
		return this.m_d4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ap(Button A_0)
	{
		this.m_d4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button gb()
	{
		return this.m_d5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aq(Button A_0)
	{
		this.m_d5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button gc()
	{
		return this.m_d6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ar(Button A_0)
	{
		this.m_d6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button gd()
	{
		return this.m_d7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void @as(Button A_0)
	{
		this.m_d7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ge()
	{
		return this.m_d8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void at(Button A_0)
	{
		this.m_d8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox gf()
	{
		return this.m_d9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(CheckBox A_0)
	{
		this.m_d9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual fl gg()
	{
		return this.m_ea;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(fl A_0)
	{
		this.m_ea = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox gh()
	{
		return this.m_eb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(CheckBox A_0)
	{
		EventHandler value = n;
		CheckBox checkBox = this.m_eb;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_eb = A_0;
		checkBox = this.m_eb;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox gi()
	{
		return this.m_ec;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(CheckBox A_0)
	{
		EventHandler value = m;
		CheckBox checkBox = this.m_ec;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_ec = A_0;
		checkBox = this.m_ec;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button gj()
	{
		return this.m_ed;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void au(Button A_0)
	{
		EventHandler value = l;
		Button button = this.m_ed;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ed = A_0;
		button = this.m_ed;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d gk()
	{
		return e8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void j(global::r.d A_0)
	{
		global::r.d.b a_ = x;
		e8?.e(a_);
		e8 = A_0;
		e8?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d gl()
	{
		return this.m_e9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void k(global::r.d A_0)
	{
		global::r.d.b a_ = y;
		this.m_e9?.e(a_);
		this.m_e9 = A_0;
		this.m_e9?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d gm()
	{
		return this.m_fa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void l(global::r.d A_0)
	{
		global::r.d.c a_ = v;
		global::r.d.b a_2 = u;
		global::r.d d10 = this.m_fa;
		if (d10 != null)
		{
			d10.e(a_);
			d10.e(a_2);
		}
		this.m_fa = A_0;
		d10 = this.m_fa;
		if (d10 != null)
		{
			d10.d(a_);
			d10.d(a_2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d gn()
	{
		return this.m_fb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void m(global::r.d A_0)
	{
		global::r.d.c a_ = t;
		global::r.d.b a_2 = s;
		global::r.d d10 = this.m_fb;
		if (d10 != null)
		{
			d10.e(a_);
			d10.e(a_2);
		}
		this.m_fb = A_0;
		d10 = this.m_fb;
		if (d10 != null)
		{
			d10.d(a_);
			d10.d(a_2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d go()
	{
		return this.m_fc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void n(global::r.d A_0)
	{
		global::r.d.c a_ = r;
		global::r.d.b a_2 = q;
		global::r.d d10 = this.m_fc;
		if (d10 != null)
		{
			d10.e(a_);
			d10.e(a_2);
		}
		this.m_fc = A_0;
		d10 = this.m_fc;
		if (d10 != null)
		{
			d10.d(a_);
			d10.d(a_2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d gp()
	{
		return fd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void o(global::r.d A_0)
	{
		global::r.d.b a_ = w;
		fd?.e(a_);
		fd = A_0;
		fd?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d gq()
	{
		return this.m_fe;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void p(global::r.d A_0)
	{
		global::r.d.b a_ = p;
		this.m_fe?.e(a_);
		this.m_fe = A_0;
		this.m_fe?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d gr()
	{
		return ff;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void q(global::r.d A_0)
	{
		global::r.d.b a_ = m;
		ff?.e(a_);
		ff = A_0;
		ff?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d gs()
	{
		return fg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void r(global::r.d A_0)
	{
		global::r.d.b a_ = n;
		fg?.e(a_);
		fg = A_0;
		fg?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d gt()
	{
		return fh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void s(global::r.d A_0)
	{
		fh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.c gu()
	{
		return fi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void m(global::r.c A_0)
	{
		fi = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d gv()
	{
		return fj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void t(global::r.d A_0)
	{
		fj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.c gw()
	{
		return fk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void n(global::r.c A_0)
	{
		fk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d gx()
	{
		return this.m_fl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void u(global::r.d A_0)
	{
		this.m_fl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer gy()
	{
		return ft;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void i(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = o;
		System.Timers.Timer timer = ft;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		ft = A_0;
		timer = ft;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer gz()
	{
		return fu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void j(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = k;
		System.Timers.Timer timer = fu;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		fu = A_0;
		timer = fu;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer g0()
	{
		return fw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void k(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = i;
		System.Timers.Timer timer = fw;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		fw = A_0;
		timer = fw;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer g1()
	{
		return fy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void l(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = j;
		System.Timers.Timer timer = fy;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		fy = A_0;
		timer = fy;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer g2()
	{
		return this.m_fz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void m(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = n;
		System.Timers.Timer timer = this.m_fz;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		this.m_fz = A_0;
		timer = this.m_fz;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer g3()
	{
		return this.m_f0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void n(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = m;
		System.Timers.Timer timer = this.m_f0;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		this.m_f0 = A_0;
		timer = this.m_f0;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(e A_0)
	{
		e e10 = this.m_g4;
		e e11;
		do
		{
			e11 = e10;
			e value = (e)Delegate.Combine(e11, A_0);
			e10 = Interlocked.CompareExchange(ref this.m_g4, value, e11);
		}
		while ((object)e10 != e11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void j(e A_0)
	{
		e e10 = this.m_g4;
		e e11;
		do
		{
			e11 = e10;
			e value = (e)Delegate.Remove(e11, A_0);
			e10 = Interlocked.CompareExchange(ref this.m_g4, value, e11);
		}
		while ((object)e10 != e11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(ce.a A_0)
	{
		ce.a a10 = this.m_g5;
		ce.a a11;
		do
		{
			a11 = a10;
			ce.a value = (ce.a)Delegate.Combine(a11, A_0);
			a10 = Interlocked.CompareExchange(ref this.m_g5, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void j(ce.a A_0)
	{
		ce.a a10 = this.m_g5;
		ce.a a11;
		do
		{
			a11 = a10;
			ce.a value = (ce.a)Delegate.Remove(a11, A_0);
			a10 = Interlocked.CompareExchange(ref this.m_g5, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(g A_0)
	{
		g g10 = this.m_g6;
		g g11;
		do
		{
			g11 = g10;
			g value = (g)Delegate.Combine(g11, A_0);
			g10 = Interlocked.CompareExchange(ref this.m_g6, value, g11);
		}
		while ((object)g10 != g11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void j(g A_0)
	{
		g g10 = this.m_g6;
		g g11;
		do
		{
			g11 = g10;
			g value = (g)Delegate.Remove(g11, A_0);
			g10 = Interlocked.CompareExchange(ref this.m_g6, value, g11);
		}
		while ((object)g10 != g11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(h A_0)
	{
		h h10 = this.m_g7;
		h h11;
		do
		{
			h11 = h10;
			h value = (h)Delegate.Combine(h11, A_0);
			h10 = Interlocked.CompareExchange(ref this.m_g7, value, h11);
		}
		while ((object)h10 != h11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void j(h A_0)
	{
		h h10 = this.m_g7;
		h h11;
		do
		{
			h11 = h10;
			h value = (h)Delegate.Remove(h11, A_0);
			h10 = Interlocked.CompareExchange(ref this.m_g7, value, h11);
		}
		while ((object)h10 != h11);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d g4()
	{
		return this.m_g8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void v(global::r.d A_0)
	{
		global::r.d.b a_ = l;
		this.m_g8?.e(a_);
		this.m_g8 = A_0;
		this.m_g8?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d g5()
	{
		return this.m_ha;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void w(global::r.d A_0)
	{
		global::r.d.b a_ = j;
		this.m_ha?.e(a_);
		this.m_ha = A_0;
		this.m_ha?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d g6()
	{
		return this.m_hb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void x(global::r.d A_0)
	{
		global::r.d.b a_ = k;
		this.m_hb?.e(a_);
		this.m_hb = A_0;
		this.m_hb?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(i A_0)
	{
		i i10 = h9;
		i i11;
		do
		{
			i11 = i10;
			i value = (i)Delegate.Combine(i11, A_0);
			i10 = Interlocked.CompareExchange(ref h9, value, i11);
		}
		while ((object)i10 != i11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void j(i A_0)
	{
		i i10 = h9;
		i i11;
		do
		{
			i11 = i10;
			i value = (i)Delegate.Remove(i11, A_0);
			i10 = Interlocked.CompareExchange(ref h9, value, i11);
		}
		while ((object)i10 != i11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(j A_0)
	{
		j j2 = ia;
		j j3;
		do
		{
			j3 = j2;
			j value = (j)Delegate.Combine(j3, A_0);
			j2 = Interlocked.CompareExchange(ref ia, value, j3);
		}
		while ((object)j2 != j3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void j(j A_0)
	{
		j j2 = ia;
		j j3;
		do
		{
			j3 = j2;
			j value = (j)Delegate.Remove(j3, A_0);
			j2 = Interlocked.CompareExchange(ref ia, value, j3);
		}
		while ((object)j2 != j3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(k A_0)
	{
		k k2 = ib;
		k k3;
		do
		{
			k3 = k2;
			k value = (k)Delegate.Combine(k3, A_0);
			k2 = Interlocked.CompareExchange(ref ib, value, k3);
		}
		while ((object)k2 != k3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void j(k A_0)
	{
		k k2 = ib;
		k k3;
		do
		{
			k3 = k2;
			k value = (k)Delegate.Remove(k3, A_0);
			k2 = Interlocked.CompareExchange(ref ib, value, k3);
		}
		while ((object)k2 != k3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(l A_0)
	{
		l l2 = ic;
		l l3;
		do
		{
			l3 = l2;
			l value = (l)Delegate.Combine(l3, A_0);
			l2 = Interlocked.CompareExchange(ref ic, value, l3);
		}
		while ((object)l2 != l3);
	}

	[SpecialName]
	[CompilerGenerated]
	public void j(l A_0)
	{
		l l2 = ic;
		l l3;
		do
		{
			l3 = l2;
			l value = (l)Delegate.Remove(l3, A_0);
			l2 = Interlocked.CompareExchange(ref ic, value, l3);
		}
		while ((object)l2 != l3);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d g7()
	{
		return ie;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void y(global::r.d A_0)
	{
		global::r.d.b a_ = i;
		ie?.e(a_);
		ie = A_0;
		ie?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer g8()
	{
		return ii;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void o(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = l;
		System.Timers.Timer timer = ii;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		ii = A_0;
		timer = ii;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	public f4()
	{
		q(new global::r.d());
		m(new global::r.c());
		t(new global::r.d());
		n(new global::r.c());
		fs = 2f;
		this.m_f1 = 500;
		this.m_g3 = new d();
		this.m_hv = new int[2];
		this.m_hw = new int[2];
		this.m_hx = new int[2];
		this.m_hy = new int[2];
		y(new global::r.d());
		o(new System.Timers.Timer());
		iu = new bool[4];
		iv = new float[4];
		a9();
		this.m_h3 = c4().Width;
		this.m_h4 = c4().Text;
	}

	public f4(Guid A_0, f1 A_1, fz A_2, hs A_3, Collection<gn> A_4, gr A_5, ge A_6, ew.a A_7, gh A_8, gq A_9, string A_10, je A_11, fm A_12, global::i A_13, gl A_14)
		: this()
	{
		this.m_ef = A_1;
		this.m_e5 = A_8;
		this.m_er = A_13;
		ik = A_14;
		this.m_h1 = A_11;
		this.m_ek = A_0.ToString();
		this.m_el = A_0;
		this.m_eo = A_2;
		this.m_eq = A_3;
		this.m_ep = k;
		this.m_hg = new ToolTip();
		this.m_hg.IsBalloon = true;
		this.m_hg.ShowAlways = true;
		this.m_ez = new Collection<hc>();
		this.m_e0 = new Collection<hr>();
		this.m_hz = A_5;
		this.m_h0 = A_6;
		this.m_em = RuntimeHelpers.GetObjectValue(new object());
		this.m_en = 0;
		this.m_fn = false;
		fo = false;
		this.m_ga = false;
		j(new global::r.d());
		this.m_e6 = new global::r.l();
		this.m_e6.m = gk();
		fp = false;
		k(new global::r.d());
		this.m_e7 = new global::r.l();
		this.m_e7.m = gl();
		o(new global::r.d());
		this.m_h8 = global::e.a().VideoCollapseControl;
		l(new global::r.d());
		m(new global::r.d());
		n(new global::r.d());
		p(new global::r.d());
		r(new global::r.d());
		s(new global::r.d());
		i(new System.Timers.Timer());
		j(new System.Timers.Timer());
		k(new System.Timers.Timer());
		l(new System.Timers.Timer());
		m(new System.Timers.Timer());
		this.m_f5 = new e9(A_2);
		this.m_fm = d9().Width;
		u(new global::r.d());
		MySettings mySettings = global::e.a();
		if (!this.m_ef.ui() && !this.m_ef.uo() && this.m_ef.up())
		{
			mySettings.PrecSimSetupMethod = 1;
			mySettings.PrecSimOverrideSpecAmplitudeUncertainty = false;
			mySettings.PrecSimDoWavelengthRangeStabilityCheck = false;
		}
		bool a_ = false;
		if (mySettings.PrecSimSetupMethod == 1)
		{
			a_ = true;
		}
		this.m_ey = new ho(mySettings.PrecSimNumIterations, mySettings.PrecSimNumIntegrationCycles, mySettings.PrecSimSpectrometerResolution_nm, mySettings.PrecSimFullScaleCounts, mySettings.PrecSimShotNoiseWellDepthElectrons, mySettings.PrecSimRawFile, mySettings.PrecSimPeakSignalIntensity, mySettings.PrecSimPixToPixNoisePkToPkRaw, mySettings.PrecSimDCNoisePkToPkRaw, mySettings.PrecSimDCAmplitudeUncertaintyPkToPkPct, mySettings.PrecSimSampleHeightUncertainty_mm, mySettings.PrecSimWavelenCalNoise_nm, a_, mySettings.PrecSimOverrideSpecAmplitudeUncertainty, mySettings.PrecSimDCAmplitudeUncertaintyPkToPkPctSpecOverride, mySettings.PrecSimDoWavelengthRangeStabilityCheck, mySettings.PrecSimWavelengthRangeReductionAmount, mySettings.PrecSimIntegrationTime, mySettings.PrecSimAcqSettingsFromSpectrumIfAvailable);
		mySettings = null;
		bool visible = a6();
		el().Visible = visible;
		ej().Visible = a5();
		ep().Visible = visible;
		ek().Visible = a7();
		this.m_g9 = new global::r.l();
		w(new global::r.d());
		this.m_g9.m = g5();
		x(new global::r.d());
		v(new global::r.d());
		this.m_h5 = A_9;
		aq();
		i(this.m_ef.wc(this.m_el));
		id = this.m_ef.sj(this.m_el);
		this.m_gk = new bx(e2(), A_1: false);
		this.m_gl = new bx(e6(), A_1: false);
		this.m_gm = new bx(e1(), A_1: false);
		this.m_gn = new bx(ez(), A_1: false);
		this.m_go = new bx(e0(), A_1: false);
		this.m_gp = new bx(ey(), A_1: false);
		this.m_gq = new bx(e4(), A_1: false);
		this.m_gr = new bx(e3(), A_1: false);
		this.m_gs = new bx(e5(), A_1: false);
		hs.a a_2 = az;
		this.m_eq.b(a_2);
		fl.s a_3 = i;
		bb().o(a_3);
		bb().o((fl.x)ag);
		gg().o(a_3);
		gg().o((fl.x)ag);
		fl.p a_4 = i;
		bb().o(a_4);
		gg().o(a_4);
		fl.r a_5 = j;
		bb().o(a_5);
		gg().o(a_5);
		fl.q a_6 = i;
		bb().o(a_6);
		gg().o(a_6);
		fl.t a_7 = i;
		bb().o(a_7);
		gg().o(a_7);
		fl.u a_8 = i;
		bb().o(a_8);
		gg().o(a_8);
		fl.r a_9 = i;
		bb().q(a_9);
		gg().q(a_9);
		A_4[0].am(y);
		ba().o((fl.r)l);
		global::db.b((db.b)h4);
		fl obj = ba();
		obj.ae(A_0: true);
		obj.af(A_0: true);
		obj.o(A_4[1]);
		obj.o(this.m_eo);
		obj.o(this.m_h5);
		obj.gn = true;
		obj.ga = true;
		obj.aa(A_0: true);
		obj.z(A_0: true);
		obj.ab(A_0: true);
		obj.o(A_12);
		string A_15 = "GraphToolTip";
		obj.r(global::hu.a(ref A_15));
		_ = null;
		fl obj2 = bb();
		obj2.ae(A_0: true);
		obj2.af(A_0: true);
		obj2.ga = true;
		obj2.gb = true;
		obj2.o(A_4[0]);
		obj2.o(this.m_eo);
		obj2.o(this.m_h5);
		obj2.ek = true;
		obj2.o(A_12);
		obj2.an(A_0: true);
		obj2.am(A_0: true);
		obj2.hj();
		A_15 = "GraphToolTip";
		obj2.r(global::hu.a(ref A_15));
		_ = null;
		fl obj3 = gg();
		obj3.ae(A_0: true);
		obj3.af(A_0: true);
		obj3.ga = true;
		obj3.gb = true;
		go go2 = new go(global::go.a.f);
		go2.ao(A_0: true);
		gn obj4 = A_4[0];
		ft a_10 = obj4.a3();
		fs a_11 = obj4.a4();
		_ = null;
		obj3.o(A_4[0].am(go2, a_10, a_11));
		obj3.o(this.m_eo);
		obj3.o(this.m_h5);
		obj3.ek = true;
		obj3.o(A_12);
		obj3.an(A_0: true);
		obj3.am(A_0: true);
		obj3.hj();
		A_15 = "GraphToolTip";
		obj3.r(global::hu.a(ref A_15));
		_ = null;
		fl obj5 = bc();
		obj5.ae(A_0: true);
		obj5.af(A_0: true);
		obj5.z(A_0: true);
		obj5.aa(A_0: true);
		obj5.ab(A_0: true);
		obj5.ga = true;
		obj5.o(A_4[2]);
		obj5.o(this.m_eo);
		obj5.o(this.m_h5);
		obj5.ek = true;
		obj5.x(A_0: true);
		obj5.o(A_12);
		A_15 = "GraphToolTip";
		obj5.r(global::hu.a(ref A_15));
		_ = null;
		ah();
		this.m_gf = this.m_ef.t0(this.m_ek);
		this.m_gf.bu(i, m);
		i(this.m_gf, A_1: false, global::r.d.a.b.b);
		this.m_gg = this.m_ef.tg(this.m_ek);
		this.m_gg.t(o);
		this.m_gg.v(p);
		this.m_gg.t((global::r.c.b)i);
		this.m_gh = this.m_ef.th(this.m_ek);
		this.m_gh.t(l);
		this.m_gh.v(k);
		this.m_gh.t((global::r.c.b)k);
		this.m_gi = this.m_ef.v5(this.m_el);
		this.m_gi.t((global::r.c.a)j);
		this.m_gi.v(i);
		this.m_gi.t((global::r.c.b)j);
		ec().Enabled = this.m_ef.wv(this.m_el);
		cg().Visible = this.m_ef.ul();
		global::i5.a(A_7, eh());
		ev().Text = global::e.a().OperatorID;
		ex().Text = global::e.a().SampleID;
		if (Operators.CompareString(A_10, "None", TextCompare: false) != 0 && global::d4.a(null).Count > 0)
		{
			this.m_ef.m2(this.m_ek, br().Handle, g7(), global::r.d.a.b.a, A_10);
		}
		if (this.m_ef.vb())
		{
			bh().h(this.m_ef.vc());
			bh().i(this.m_ef.vd());
			bh().m().Maximum = bh().n();
			bh().p().Maximum = bh().o();
			this.m_hc = 1f;
		}
		j();
		this.m_gt = false;
		this.m_gu = this.m_ef.u8(this.m_el) == global::g2.a.b;
		e9().Visible = this.m_gu;
		i();
		this.m_e3 = true;
		if (this.m_ef.u8(this.m_el) == global::g2.a.m)
		{
			Label label = ef();
			A_15 = "CTMProbeLabel";
			label.Text = global::hu.a(ref A_15);
		}
		h4();
		x();
		this.m_gj = this.m_ef.wa(this.m_el);
		this.m_gj.d((global::r.d.b)o);
		g8().Interval = 5000.0;
		g8().AutoReset = false;
		ToolTip toolTip = bz();
		CheckBox control = gi();
		A_15 = "BaselineLockToolTip";
		toolTip.SetToolTip(control, global::hu.a(ref A_15));
	}

	public void g9()
	{
		this.m_f4 = true;
		g2().Stop();
		o();
		this.m_eq.c(az);
		bb().gi().an(y);
		gg().gi().an(y);
		ba().o((fu)null);
		bb().o((fu)null);
		gg().o((fu)null);
		bc().o((fu)null);
		this.m_f5.b();
		this.m_f5 = null;
		this.m_gf.bv(i, m);
		this.m_gg.u(o);
		this.m_gg.w(p);
		this.m_gg.u((global::r.c.b)i);
		this.m_gh.u(l);
		this.m_gh.w(k);
		this.m_gh.u((global::r.c.b)k);
		this.m_gi.u((global::r.c.a)j);
		this.m_gi.w(i);
		this.m_gi.u((global::r.c.b)j);
		global::db.a((db.b)h4);
		this.m_gj.e((global::r.d.b)o);
	}

	[SpecialName]
	private Point a8()
	{
		return global::i6.a(this);
	}

	[SpecialName]
	private bool a7()
	{
		if (!this.m_ef.ui())
		{
			return this.m_ef.uo();
		}
		return true;
	}

	[SpecialName]
	private bool a6()
	{
		if (!a7())
		{
			return this.m_ef.up();
		}
		return true;
	}

	[SpecialName]
	private bool a5()
	{
		if (a6())
		{
			return this.m_ef.ui();
		}
		return false;
	}

	[SpecialName]
	private fz a4()
	{
		return this.m_eo;
	}

	[SpecialName]
	private Point a3()
	{
		return global::i6.a(this);
	}

	[SpecialName]
	public bool ha()
	{
		hc hc2 = a2();
		if (hc2 != null)
		{
			if (hc2.ek() <= 0)
			{
				return hc2.em() > 0;
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	private hc m(hc A_0)
	{
		A_0 = a2();
		return A_0;
	}

	[SpecialName]
	private hc a2()
	{
		bool A_ = false;
		try
		{
			if (i(ref A_) != global::f4.b.a)
			{
				throw new ao("Timeout waiting for lock on measResults collection in ActiveMeasResultIncludesMeasuredNorK");
			}
			fl fl2 = bb();
			int A_2 = default(int);
			if (i(fl2.e7(), ref A_2))
			{
				return this.m_ez[A_2];
			}
			return null;
		}
		finally
		{
			if (A_)
			{
				Monitor.Exit(this.m_ez);
			}
		}
	}

	[SpecialName]
	private void s(bool A_0)
	{
		this.m_eg = A_0;
		ba().Visible = this.m_eg;
	}

	[SpecialName]
	private void r(bool A_0)
	{
		this.m_eh = A_0;
		bc().Visible = this.m_eh;
		bd().BringToFront();
	}

	[SpecialName]
	public void t(bool A_0)
	{
		bb().w(A_0);
		gg().w(A_0);
		bc().w(A_0);
		ba().w(A_0);
		ih = !A_0;
	}

	[SpecialName]
	private bool a1()
	{
		return this.m_ei;
	}

	[SpecialName]
	private void q(bool A_0)
	{
		this.m_ei = A_0;
	}

	[SpecialName]
	public string hb()
	{
		return this.m_ek;
	}

	[SpecialName]
	public Guid hc()
	{
		return this.m_el;
	}

	[SpecialName]
	public string hd()
	{
		string text = ex().Text;
		if (string.IsNullOrEmpty(text))
		{
			string A_ = "Unknown";
			text = global::hu.a(ref A_);
		}
		return text;
	}

	[SpecialName]
	public Collection<hc> he()
	{
		return this.m_ez;
	}

	[SpecialName]
	public Collection<hr> hf()
	{
		return this.m_e0;
	}

	[SpecialName]
	public ek hg()
	{
		return this.m_h6;
	}

	[SpecialName]
	public void i(ek A_0)
	{
		this.m_h6 = A_0;
		bb().ab(A_0 != null);
		gg().ab(A_0 != null);
	}

	private void j(int A_0, int A_1, int A_2, int A_3)
	{
		int num = ((!this.m_ef.wq(this.m_el).b5() || !this.m_ef.sj((eo.a)null)) ? 1 : 0);
		this.m_hv[num] = A_0;
		this.m_hw[num] = A_1;
		this.m_hx[num] = A_2;
		this.m_hy[num] = A_3;
		if (Operators.CompareString(eb().Text, global::ey.a1(), TextCompare: false) == 0)
		{
			aw(null, null);
		}
		this.m_ht = false;
		az();
		this.m_hr = null;
	}

	private void i(global::r.d A_0, bool A_1, global::r.d.a.b A_2)
	{
		if (base.InvokeRequired)
		{
			Invoke(new n(i), A_0, A_1, A_2);
		}
		else
		{
			this.m_hd = false;
			i(this.m_ef.t0(this.m_ek), A_1, A_2);
		}
	}

	private void m(hg A_0)
	{
		this.m_gf.bv(i, m);
		this.m_gf = A_0;
		this.m_gf.bu(i, m);
	}

	private void p(bool A_0)
	{
		if (this.m_gt != A_0)
		{
			ee().Visible = A_0;
			this.m_gt = A_0;
			i(e0(), this.m_go.f(global::e.a().FICPMMOperationIsCollapsed));
		}
	}

	[SpecialName]
	private bool a0()
	{
		if (!this.m_ef.ui())
		{
			return this.m_ef.qh(h2());
		}
		return true;
	}

	[SpecialName]
	private bool l(hg A_0)
	{
		return this.m_ef.sj(h2());
	}

	private void i(bool A_0, bool A_1, bool A_2, string A_3)
	{
		i(ec(), bz(), A_0, A_1, A_2, A_3);
	}

	public static void i(Button A_0, ToolTip A_1, bool A_2, bool A_3, bool A_4, string A_5)
	{
		if (A_2)
		{
			A_1.SetToolTip(A_0, A_5);
		}
		else if (!A_3)
		{
			if (A_4)
			{
				A_1.SetToolTip(A_0, null);
			}
			else
			{
				A_1.SetToolTip(A_0, A_5);
			}
		}
	}

	private bool i(hg A_0, bool A_1, eo A_2, eo.a A_3)
	{
		if (!A_1 && A_2.az(A_3))
		{
			if (A_0.ed().d7(A_3))
			{
				return !A_0.ed().d8(A_3);
			}
			return true;
		}
		return false;
	}

	private bool i(hr A_0, eo A_1, eo.a A_2)
	{
		if (A_0 != null && A_0.ag())
		{
			if (A_0.cu().q() == null && !A_1.az(A_2) && !A_1.av(A_2))
			{
				return A_1.a1(A_2);
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	private eo.a k(hr A_0)
	{
		return null;
	}

	private void az()
	{
		try
		{
			this.m_es = true;
			SuspendLayout();
			try
			{
				if (base.InvokeRequired)
				{
					hs.a method = az;
					BeginInvoke(method);
				}
				else if (base.IsHandleCreated)
				{
					if (global::g2.d(this.m_ef.u8(this.m_el)) && this.m_ef.u8(this.m_el) != global::g2.a.b)
					{
						if (this.m_ef.te(this.m_ek))
						{
							eb().Text = global::ey.a1();
						}
						else
						{
							eb().Text = global::ey.a0();
						}
					}
					else
					{
						eb().Text = global::ey.az();
					}
					d4.a a10 = this.m_ef.t6(this.m_ek);
					bo().Enabled = a10?.o() ?? false;
					eo.a a11 = null;
					hr hr2 = h1();
					hc hc2 = a2();
					hg hg2 = this.m_ef.t0(this.m_ek);
					bool A_ = false;
					bool A_2 = false;
					he he2 = this.m_ef.wr(this.m_el);
					bool flag = this.m_ef.ws(this.m_el);
					if (hc2 != null && !hc2.cf(hg2) && !flag)
					{
						try
						{
							if (i(ref A_, ref A_2) != global::f4.b.a)
							{
								throw new ao("Timeout waiting for lock on collections in PanelGUIUpdateHandler Loc 0");
							}
							i(hc2.cn().b9(), hc2.cn().ca(), A_2: true);
							@as();
						}
						finally
						{
							if (A_)
							{
								Monitor.Exit(this.m_e0);
							}
							if (A_2)
							{
								Monitor.Exit(this.m_ez);
							}
						}
					}
					if (global::e.a().DisplaySpectrumColorControls && global::e.a().ShowSpectrumColor)
					{
						c4().Visible = !aj();
						e3().Visible = c4().Visible;
						a4.a a_ = ((hc2 != null && hc2.co() != null && hc2.co().e() != null && hc2.co().e().Count != 0) ? hc2.co().e()[0].h() : ((a4.a)global::e.a().ShowSpectrumCoordOption));
						short a_2 = global::e.a().ShowSpectrumCoordOption;
						global::hg.bu(a_, c7(), c8(), da());
						global::hg.bu((a4.a)a_2, cy(), c1(), c2());
					}
					else
					{
						c4().Visible = false;
						e3().Visible = false;
					}
					if (this.m_ef.xa(this.m_el))
					{
						ck().Text = Path.GetFileNameWithoutExtension(this.m_ef.t5(this.m_ek));
						if (string.IsNullOrEmpty(ck().Text))
						{
							ck().Text = "DefaultTemplate";
						}
					}
					gz gz2 = this.m_ef.ti();
					bool flag2 = default(bool);
					foreach (gy item in gz2.i())
					{
						if (Operators.CompareString(item.x(), this.m_ek, TextCompare: false) == 0)
						{
							item.u(item.z());
							item.w(this.m_ef.t5(this.m_ek));
							flag2 = item.z();
							if (!flag2)
							{
								item.v(he2.v());
								item.t(flag);
							}
							break;
						}
					}
					bool a_3 = l(hg2);
					i(a_3, a0());
					if (flag)
					{
						dx().Text = he2.x();
					}
					else
					{
						dx().Text = hg2.ci();
					}
					i(hg2);
					if (hg2.b5())
					{
						dp().Text = dx().Text;
					}
					else
					{
						dt().Text = dx().Text;
					}
					bb().ai(!flag2 && !aj() && (this.m_ef.so(a11) || this.m_ef.sn(a11)));
					bb().g8();
					if (gg().Height > 0)
					{
						gg().g8();
					}
					checked
					{
						if (this.m_ef.w0(this.m_el) && global::g2.c(this.m_ef.u8(this.m_el)))
						{
							eu eu2 = this.m_ef.so(this.m_ef.u9(this.m_el).w);
							if (eu2 != null)
							{
								string[] array = eu2.k();
								bool flag3 = false;
								string right = global::ey.ay();
								string right2 = global::ey.ax();
								if (array != null)
								{
									int num = array.Length - 1;
									for (int num2 = 0; num2 <= num; num2++)
									{
										if (eg().Items.Count <= num2 || Operators.CompareString(eg().Items[num2].ToString(), array[num2], TextCompare: false) != 0)
										{
											flag3 = true;
											break;
										}
									}
								}
								else if (eg().Items.Count > 0 && (Operators.CompareString(eg().Items[eg().Items.Count - 1].ToString(), right, TextCompare: false) != 0 || Operators.CompareString(eg().Items[0].ToString(), right2, TextCompare: false) != 0))
								{
									flag3 = true;
								}
								if (!flag3 && eg().Items.Count == 0)
								{
									flag3 = true;
								}
								if (flag3)
								{
									i(eu2);
									if (eu2 != null && eu2.l() != null && eu2.l().Count > 0)
									{
										if (this.m_ef.u9(this.m_el).r() != null)
										{
											eg().SelectedItem = this.m_ef.u9(this.m_el).r().al();
										}
										else
										{
											eg().SelectedIndex = 0;
										}
									}
									else
									{
										eg().SelectedIndex = 0;
									}
								}
								else
								{
									es es2 = this.m_ef.u9(this.m_el).r();
									if (es2 != null && Operators.CompareString(eg().Text, es2.al(), TextCompare: false) != 0)
									{
										eg().Text = es2.al();
									}
								}
							}
						}
						else if (this.m_ef.w1(this.m_el) && global::g2.a(this.m_ef.u8(this.m_el)))
						{
							bool flag4 = false;
							cg cg2 = this.m_ef.uu();
							if (cg2.h() != null && cg2.h().Length > 0)
							{
								int num3 = cg2.h().Length - 1;
								for (int num4 = 0; num4 <= num3; num4++)
								{
									if (eg().Items.Count <= num4 || Operators.CompareString(eg().Items[num4].ToString(), cg2.h()[num4], TextCompare: false) != 0)
									{
										flag4 = true;
										break;
									}
								}
							}
							if (flag4)
							{
								eg().Items.Clear();
								if (cg2.h() != null && cg2.h().Length > 0)
								{
									eg().Items.AddRange(cg2.h());
								}
								if (cg2 != null && cg2.h() != null)
								{
									if (this.m_ef.u9(this.m_el).s() != null)
									{
										eg().SelectedItem = this.m_ef.u9(this.m_el).s().n();
									}
									else if (eg().Items.Count > 0)
									{
										eg().SelectedIndex = 0;
									}
									else
									{
										eg().SelectedIndex = -1;
									}
								}
								else
								{
									eg().SelectedIndex = -1;
								}
							}
							else
							{
								cf cf2 = this.m_ef.u9(this.m_el).s();
								if (cf2 != null && Operators.CompareString(eg().Text, cf2.n(), TextCompare: false) != 0)
								{
									eg().Text = cf2.n();
								}
							}
						}
						if (this.m_ef.u8(this.m_el) == global::g2.a.g || this.m_ef.u8(this.m_el) == global::g2.a.f)
						{
							if (!this.m_gt || !iw)
							{
								Label label = ef();
								string A_3 = "ObjectiveLabel";
								label.Text = global::hu.a(ref A_3);
								p(A_0: true);
								iw = true;
							}
							this.m_h2 = this.m_ef.vb();
						}
						else if (this.m_ef.u8(this.m_el) == global::g2.a.m)
						{
							if (!this.m_gt || iw)
							{
								Label label2 = ef();
								string A_3 = "CTMProbeLabel";
								label2.Text = global::hu.a(ref A_3);
								p(A_0: true);
								iw = false;
								ee().Left = eb().Left + unchecked(eb().Width / 2) - unchecked(ee().Width / 2);
							}
						}
						else
						{
							p(A_0: false);
							this.m_h2 = false;
						}
						bool flag5 = !this.m_h5.g() || this.m_h5.h() >= global::gq.a.c;
						dy().Visible = flag5;
						dq().Visible = flag5;
						du().Visible = flag5;
						bx().Enabled = flag5;
						bn().Enabled = flag5;
						bool enabled = this.m_ef.v3(this.m_el) && !this.m_ef.s6(this.m_ek);
						dy().Enabled = enabled;
						dq().Enabled = enabled;
						du().Enabled = enabled;
						dw().Enabled = enabled;
						@do().Enabled = enabled;
						ds().Enabled = enabled;
						ed().Top = ec().Top;
						eo a_4 = hg2.dh();
						if (global::eo.at(this.m_ef.sm(this.m_el), this.m_ef.sn(this.m_el), a11))
						{
							ec().Text = global::ey.e() + "...";
							ec().Width = eb().Width;
						}
						else
						{
							ec().Width = 113;
							ec().Text = global::ey.d() + "...";
						}
						ec().Enabled = this.m_ef.vj(this.m_el) && !this.m_ef.s6(this.m_ek);
						bool flag6 = i(hg2, a11);
						if (flag6)
						{
							bool flag7 = i(hg2, flag2, a_4, a11) && !hg2.d0().q();
							bool flag8 = flag;
							if (flag8)
							{
								int num5 = he2.ab() - 1;
								for (int num6 = 0; num6 <= num5; num6++)
								{
									if (this.m_e0.Count <= num6 || this.m_e0[num6].cu().q() != null)
									{
										flag8 = false;
										break;
									}
								}
							}
							ed().Enabled = (hc2 == null || hc2.dc()) && ((hr2 != null && i(hr2, this.m_ef.ut(), a11)) || (hr2 == null && flag7)) && (!flag || (flag8 && this.m_e0.Count >= he2.ab() && !this.m_ef.s8(this.m_ek)));
							ed().Visible = true;
						}
						else
						{
							ed().Visible = false;
						}
						b5().SuspendLayout();
						es().Visible = global::e.a().DisplaySampleInfoControls;
						i(l(hg2), a0());
						eo().Visible = flag6;
						string A_4 = null;
						i(A_0: false, g3() != null, this.m_ef.m2(this.m_el, ref A_4), "Baseline disabled because: \r\n" + A_4);
						s();
						int A_5 = default(int);
						i(ref A_5);
						hh();
						A_ = false;
						A_2 = false;
						try
						{
							short num7 = ((!flag || he2.ab() <= 0) ? global::e.a().GraphMeasUserDefinedMaxCurves : ((short)he2.ab()));
							if (i(ref A_, ref A_2) != global::f4.b.a)
							{
								throw new ao("Timeout waiting for lock on collections in PanelGUIUpdateHandler");
							}
							while (this.m_e0.Count > num7)
							{
								Collection<hr> collection = this.m_e0;
								long a_5 = collection[0].b9();
								bool a_6 = this.m_e0.Count != num7 + 1;
								i(a_5, collection[0].ca(), A_2: true);
								collection.RemoveAt(0);
								bb().o(a_5, a_6, global::r.d.a.b.b);
								gg().o(a_5, a_6, global::r.d.a.b.b);
								collection = null;
							}
							hc hc3 = null;
							fh.b A_6 = default(fh.b);
							hr.b A_7 = default(hr.b);
							global::d7.a(this.m_e0, null, ref A_6, ref A_7);
							if (A_6 != this.m_e1 && hc2 != null)
							{
								hc3 = hc2;
							}
							i(A_6, A_7);
							bool flag9 = gg().Height > 0 && ix != global::e.a().DualSpectrumGraphs;
							if (flag9)
							{
								gg().g1();
								foreach (hr item2 in this.m_e0)
								{
									global::d7.a(this.m_ef, gg(), item2, A_6, A_7);
								}
								hc3 = hc2;
							}
							if (hc3 != null || (flag9 && hc2 != null))
							{
								i(hc3, A_1: false, A_2: true);
							}
							ix = global::e.a().DualSpectrumGraphs;
						}
						finally
						{
							if (A_)
							{
								Monitor.Exit(this.m_e0);
							}
							if (A_2)
							{
								Monitor.Exit(this.m_ez);
							}
						}
						if (gh().Checked != ix)
						{
							try
							{
								aa();
								gh().Checked = ix;
							}
							finally
							{
								z();
							}
						}
						ah();
						if (hc2 == null && k(hg2))
						{
							n(hg2);
						}
						if (ax())
						{
							aw();
						}
						b5().ResumeLayout(performLayout: true);
					}
				}
				r();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_7 = ex2;
				a4().c(global::fz.b.b, "Exception caught in FIControlPanelMeasModule.PanelGUIUpdateHandler. ", a_7);
				ProjectData.ClearProjectError();
			}
		}
		finally
		{
			ResumeLayout(performLayout: true);
			i(new Size(0, v(A_0: true)));
			this.m_es = false;
		}
	}

	private bool i(hg A_0, eo.a A_1)
	{
		hr A_2 = null;
		if (!global::eo.at(this.m_ef.sm(this.m_el), this.m_ef.sn(this.m_el), A_1))
		{
			if (!A_0.b5() && !A_0.dh().az(A_1) && !A_0.dh().av(A_1) && !A_0.dh().a1(A_1))
			{
				if (this.m_ef.sm())
				{
					if (i(ref A_2) != null)
					{
						return A_2.cu().q() != null;
					}
					return true;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	private void ay()
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new hs.a(ay));
			}
			else if (base.IsHandleCreated)
			{
				au();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			a4().c(global::fz.b.b, "Exception caught in FIControlPanelMeasModule.ConfigItemsGuiUpdateHandler. ", a_);
			ProjectData.ClearProjectError();
		}
	}

	public void u(bool A_0)
	{
		bool visible = ch().Visible;
		if (this.m_ef.xa(this.m_el))
		{
			ch().Visible = global::e.a().DisplayTemplateControls;
			if (this.m_ht)
			{
				A_0 = false;
				cj().Enabled = A_0;
				cl().Enabled = A_0;
			}
			else
			{
				cj().Enabled = true;
				cl().Enabled = true;
			}
			ci().Enabled = A_0;
		}
		else
		{
			ch().Visible = false;
		}
		if (visible != ch().Visible)
		{
			e5().Visible = ch().Visible;
			i(base.Width, base.Height);
		}
	}

	private bool ax()
	{
		if (global::e.a().ShowOpticsAndSpecStatus && this.m_ef.ui())
		{
			return !this.m_h7;
		}
		return false;
	}

	private void aw()
	{
		hg hg2 = this.m_ef.wq(this.m_el);
		ce().Text = hg2.d0().a();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		if (this.m_ef.vm(this.m_el))
		{
			global::h.e a_ = hg2.b8().a(this.m_ef.va(this.m_el));
			global::h.f[] array = this.m_ef.vb(this.m_el);
			int upperBound = array.GetUpperBound(0);
			for (int num = 0; num <= upperBound; num = checked(num + 1))
			{
				global::f f10 = ((!hg2.b8().t()) ? hg2.b8().a((int)array[num]) : hg2.b8().a(0));
				switch (array[num])
				{
				case global::h.f.a:
					flag = true;
					cd().Text = "Active Specs R:";
					if (global::h.p(a_))
					{
						cc().Text = f10.b();
					}
					else
					{
						cc().Text = "None";
					}
					break;
				case global::h.f.b:
					flag2 = true;
					if (global::h.n(a_))
					{
						b9().Text = f10.b();
					}
					else
					{
						b9().Text = "None";
					}
					break;
				case global::h.f.c:
					flag3 = true;
					ca().Text = "Active Specs R" + this.m_ef.vc(this.m_el)[num].ToString("0") + ":";
					if (global::h.d(a_))
					{
						b8().Text = f10.b();
					}
					else
					{
						b8().Text = "None";
					}
					break;
				}
			}
		}
		else
		{
			cd().Text = "Active Specs:";
			cc().Text = hg2.b8().a(0).b();
			flag = true;
			flag2 = false;
			flag3 = false;
		}
		if (flag != cc().Visible)
		{
			cc().Visible = flag;
		}
		if (flag2 != b9().Visible)
		{
			b9().Visible = flag2;
		}
		if (flag3 != b8().Visible)
		{
			b8().Visible = flag3;
		}
		cd().Visible = cc().Visible;
		cb().Visible = b9().Visible;
		ca().Visible = b8().Visible;
		hg2 = null;
	}

	private void i(ref int A_0)
	{
		A_0 = v(A_0: false);
		if (!global::e.a().DisplayMeasResultsControls)
		{
			ei().Visible = false;
			e6().Visible = false;
			return;
		}
		ei().Visible = true;
		e6().Visible = true;
		checked
		{
			if (this.m_gl.i() == global::bx.a.b)
			{
				A_0 += ei().Height;
				return;
			}
			int num = base.ClientRectangle.Height - A_0;
			if (num > 360)
			{
				ei().Height = 360;
			}
			else if (num > 150)
			{
				ei().Height = num;
			}
			else
			{
				ei().Height = 150;
			}
			A_0 += ei().Height;
			bool num2 = a6();
			RichTextBox richTextBox = eo();
			richTextBox.Top = 21;
			em().Top = ei().Height - em().Height - 6;
			en().Top = em().Top;
			if (num2)
			{
				ek().Top = em().Top - 6 - ep().Height;
				ep().Top = ek().Top;
				if (a5())
				{
					el().Top = ek().Top - unchecked(el().Height / 2);
				}
				else
				{
					el().Top = ek().Top + unchecked(ek().Height / 2) - unchecked(el().Height / 2);
				}
				ej().Top = el().Bottom;
				richTextBox.Height = ep().Top - richTextBox.Top - richTextBox.Left;
				if (!a7())
				{
					int num3 = ek().Left + unchecked(ek().Width / 2);
					el().Left = num3 - el().Width - 3;
					ep().Left = num3 + 3;
				}
				ej().Left = el().Left + unchecked(el().Width / 2) - unchecked(ej().Width / 2);
				em().Top = ej().Bottom + 4;
				en().Top = em().Top;
			}
			else
			{
				richTextBox.Height = em().Top - richTextBox.Top - richTextBox.Left;
			}
			richTextBox = null;
		}
	}

	private void av()
	{
		int num = 5;
		Label label = ((!this.m_ef.vm(this.m_el)) ? cc() : ((!this.m_ef.va(this.m_el)[2]) ? b9() : b8()));
		int num2 = default(int);
		if (cg().Visible)
		{
			num2 = cg().Height;
		}
		b6().Height = checked(b6().Height - b6().ClientSize.Height + num + num + b7().Top + label.Top + label.Height + num2);
	}

	private void au()
	{
		if (ax())
		{
			b6().Visible = true;
		}
		else
		{
			b6().Visible = false;
		}
	}

	private void i(long A_0, global::r.d.a.b A_1)
	{
		bool A_2 = false;
		bool A_3 = false;
		try
		{
			if (j(ref A_2) != global::f4.b.a)
			{
				throw new ao("Timeout waiting for lock on spectrum collection in AddEllipsometerDataToSpectrum");
			}
			int A_4 = default(int);
			if (j(A_0, ref A_4))
			{
				hr hr2 = this.m_e0[A_4].cw();
				hr hr3;
				(hr3 = hr2).t(checked(hr3.ca() + 1));
				if (i(ref A_3) != global::f4.b.a)
				{
					throw new ao("Timeout waiting for lock on MeasResults collection in AddEllipsometerDataToSpectrum");
				}
				bool A_5 = default(bool);
				bool A_6 = default(bool);
				new du().a(hr2, this.m_ef.ui(), ref A_5, ref A_6);
				if (A_5 || A_6)
				{
					i(hr2, "Analyzing spectrum...", A_2: true, A_3: true, A_1);
				}
			}
		}
		finally
		{
			if (A_3)
			{
				Monitor.Exit(this.m_ez);
			}
			if (A_2)
			{
				Monitor.Exit(this.m_e0);
			}
		}
	}

	private void i(object A_0, string A_1, long A_2, global::r.d.a.b A_3)
	{
		if (A_0 != gg() && gg().Height > 0)
		{
			gg().o(A_1, A_2);
		}
		if (A_0 != bb())
		{
			bb().o(A_1, A_2);
		}
		i(A_1, A_2, A_3);
	}

	public void i(string A_0, long A_1, global::r.d.a.b A_2)
	{
		bool A_3 = false;
		bool A_4 = false;
		try
		{
			if (j(ref A_3) != global::f4.b.a)
			{
				throw new ao("Timeout waiting for lock on spectrum collection in SpectrumRenamedByUserHandler");
			}
			int A_5 = default(int);
			if (j(A_1, ref A_5))
			{
				hr hr2 = this.m_e0[A_5];
				hr hr3;
				(hr3 = hr2).t(checked(hr3.ca() + 1));
				hr2.ak(A_0);
				if (i(ref A_4) != global::f4.b.a)
				{
					throw new ao("Timeout waiting for lock on MeasResults collection in SpectrumRenamedByUserHandler");
				}
				int A_6 = default(int);
				if (i(A_1, ref A_6) && Operators.CompareString(this.m_ez[A_6].cy().cl(), this.m_ef.t0(this.m_ek).cl(), TextCompare: false) == 0)
				{
					hc hc2 = this.m_ez[A_6];
					hc2.cf((a4.a)global::e.a().ShowSpectrumCoordOption, global::e.a().AlwayShowSpectrumCoordXYZ);
					i(hc2, A_1: true);
					this.m_e5.b(hc2);
				}
				else if (i(hr2, this.m_ef.ut(), k(hr2)))
				{
					i(hr2, "Analyzing spectrum...", A_2: true, A_3: true, A_2);
				}
				else
				{
					i(hr2, null, false);
				}
			}
		}
		finally
		{
			if (A_4)
			{
				Monitor.Exit(this.m_ez);
			}
			if (A_3)
			{
				Monitor.Exit(this.m_e0);
			}
		}
	}

	private void i(object A_0, long A_1, long A_2)
	{
		bool A_3 = false;
		bool A_4 = false;
		try
		{
			if (i(ref A_3, ref A_4) != global::f4.b.a)
			{
				throw new ao("Timeout waiting for lock on collections in SpectrumDeletedByUserHandler");
			}
			int A_5 = default(int);
			if (j(A_1, ref A_5) && this.m_e0[A_5].ca() == A_2)
			{
				this.m_e0.RemoveAt(A_5);
				i(A_1, A_2, A_2: true);
				fh.b A_6 = default(fh.b);
				hr.b A_7 = default(hr.b);
				global::d7.a(this.m_e0, null, ref A_6, ref A_7);
				i(A_6, A_7);
				if (A_0 == bb())
				{
					if (gg().Height > 0)
					{
						gg().o(A_1, A_1: true, global::r.d.a.b.a);
					}
				}
				else
				{
					bb().o(A_1, A_1: true, global::r.d.a.b.a);
				}
			}
			if (this.m_ez.Count == 0)
			{
				@as();
				this.m_eq.b();
			}
		}
		finally
		{
			if (A_3)
			{
				Monitor.Exit(this.m_e0);
			}
			if (A_4)
			{
				Monitor.Exit(this.m_ez);
			}
		}
	}

	private void at()
	{
		while (this.m_e0.Count > 0)
		{
			i(0, A_1: true);
		}
		@as();
	}

	private void i(int A_0, bool A_1)
	{
		Collection<hr> collection = this.m_e0;
		long a_ = collection[A_0].b9();
		i(a_, collection[A_0].ca(), A_2: true);
		bb().o(a_, A_1, global::r.d.a.b.b);
		if (gg().Height > 0)
		{
			gg().o(a_, A_1, global::r.d.a.b.b);
		}
		collection.RemoveAt(A_0);
		collection = null;
	}

	private void i(long A_0, long A_1, bool A_2)
	{
		if (this.m_eg)
		{
			fl fl2 = ba();
			if (fl2.o(A_0, A_1))
			{
				fl2.o(A_0, A_1: true, global::r.d.a.b.b);
			}
			if (fl2.fh() == A_0 && fl2.fi() == A_1)
			{
				fl2.g1();
			}
			fl2 = null;
		}
		else
		{
			fl fl3 = bb();
			if ((fl3.fh() == A_0) & (fl3.fi() == A_1))
			{
				fl3.g2();
			}
			fl3 = null;
			if (gg().Height > 0)
			{
				fl fl4 = gg();
				if ((fl4.fh() == A_0) & (fl4.fi() == A_1))
				{
					fl4.g2();
				}
				fl4 = null;
			}
		}
		Collection<hc> collection = this.m_ez;
		int A_3 = default(int);
		if (i(A_0, ref A_3) && collection[A_3].cn().ca() == A_1)
		{
			if (A_2 && this.m_e2 != null && this.m_e2.h().Contains(collection[A_3]))
			{
				foreach (hc item in this.m_e2.h())
				{
					collection.Remove(item);
				}
				this.m_e2 = null;
			}
			else
			{
				collection.RemoveAt(A_3);
			}
		}
		collection = null;
	}

	private void @as()
	{
		if (this.m_eg)
		{
			ba().g1();
		}
		else
		{
			if (this.m_ef.wq(this.m_el).b5())
			{
				bb().o((float[])null, 0);
				bb().o((cc.a[])null, 0);
				if (gg().Height > 0)
				{
					gg().o((float[])null, 0);
					gg().o((cc.a[])null, 0);
				}
			}
			else
			{
				bb().g2();
				if (gg().Height > 0)
				{
					gg().g2();
				}
			}
			if (this.m_eh)
			{
				bc().g1();
				bd().Visible = false;
			}
		}
		l((hc)null);
		k((hc)null);
	}

	public void hh()
	{
		eo.a a10 = null;
		hc hc2 = a2();
		if (hc2 != null)
		{
			hc hc3 = hc2;
			a10 = hc3.c0();
			s(hc3.cy().bz(a10) && hc3.cn().cu().q() == null && !global::eo.at(this.m_ef.sm(this.m_el), this.m_ef.sn(this.m_el), a10));
			r(hc3.cy().by(a10) && !aj() && !global::eo.at(this.m_ef.sm(this.m_el), this.m_ef.sn(this.m_el), a10));
			hc3 = null;
		}
		else
		{
			hg hg2 = this.m_ef.t0(this.m_ek);
			h1();
			s(hg2.bz(a10) && !aj() && !global::eo.at(this.m_ef.sm(this.m_el), this.m_ef.sn(this.m_el), a10));
			r(hg2.by(a10) && !aj() && !global::eo.at(this.m_ef.sm(this.m_el), this.m_ef.sn(this.m_el), a10));
			hg2 = null;
		}
		checked
		{
			int num = fc().Left - (base.Left + 3) - 15;
			int num2 = base.Height - 40;
			if (global::e.a().AlwayShowSpectrumCoordXYZ && global::e.a().ShowSpectrumCoordOption != 3)
			{
				de().Visible = true;
				cp().Visible = true;
			}
			else
			{
				de().Visible = false;
				cp().Visible = false;
			}
			ae();
			bh().Visible = this.m_h2;
			bi().Visible = this.m_h2 && bi().Enabled;
			bf().Visible = this.m_h2 && bf().Enabled;
			bg().Visible = this.m_h2;
			be().Visible = this.m_h2;
			int num7;
			int num8;
			if (this.m_h2)
			{
				int num3 = this.m_ef.vc();
				int num4 = this.m_ef.vd();
				int num5;
				int num6;
				int left;
				unchecked
				{
					num5 = num3 / 3;
					num6 = num4 / 3;
					left = 10;
					num7 = 60;
					num = checked(num + 30);
					num8 = num / 3;
					bi().Top = 12;
					bf().Top = bi().Top;
					bg().Top = bi().Top;
				}
				be().Top = bi().Top + unchecked(checked(bi().Height - be().Height) / 2);
				bh().Left = left;
				bh().Top = bi().Bottom + 6;
				int num9 = (int)Math.Round((float)(num8 - (int)Math.Round((double)num7 / 1.5)) * this.m_hc);
				if (num9 > num3)
				{
					num9 = num3;
				}
				else if (num9 < num5)
				{
					num9 = num5;
				}
				num8 = num9 + (int)Math.Round((double)num7 / 1.5);
				if (num8 < bg().Right)
				{
					num8 = bg().Right;
				}
				bh().Width = num9;
				int num10 = (int)Math.Round((float)(num2 - bi().Height - 12) * this.m_hc);
				if (num10 > num4)
				{
					num10 = num4;
				}
				else if (num10 < num6)
				{
					num10 = num6;
				}
				bh().Height = num10;
				int num11 = num3 - num9;
				int num12 = num4 - num10;
				int num13 = global::e.a().CameraImageCenterCol - unchecked(num9 / 2);
				if (num13 <= 0)
				{
					num13 = 0;
				}
				else if (num13 >= num11)
				{
					num13 = num11;
				}
				bh().m().Value = num13;
				global::e.a().CameraImageCenterCol = num13 + unchecked(num9 / 2);
				int num14 = global::e.a().CameraImageCenterRow - unchecked(num10 / 2);
				if (num14 <= 0)
				{
					num14 = 0;
				}
				else if (num14 >= num12)
				{
					num14 = num12;
				}
				bh().p().Value = num14;
				global::e.a().CameraImageCenterRow = num14 + unchecked(num10 / 2);
				this.m_ef.m2(num13, num14, num9, num10);
				be().Left = bh().Left;
			}
			else
			{
				num7 = 0;
				num8 = 0;
				num = fc().Left - (base.Left + 3) - 15;
			}
			bool flag = this.m_ef.t6(this.m_ek) != null;
			bool flag2 = flag;
			if (!flag2)
			{
				hr hr2 = null;
				int A_ = default(int);
				if (j(bb().e7(), ref A_))
				{
					hr2 = this.m_e0[A_];
				}
				flag2 = hr2 != null && hr2.bp() != null && hr2.bp().l() != null;
			}
			bool flag3 = flag2 & !this.m_h8;
			bool num15 = bs().Visible != flag3;
			bs().Visible = flag3;
			if (num15)
			{
				k();
			}
			b4().Visible = flag2;
			if (flag2)
			{
				num8 = unchecked(num / 3);
				bs().Top = 12;
				bs().Left = 0;
				bs().Width = num8 - 18;
				bs().Height = num2;
				if (bs().SelectedTab == bu())
				{
					int num16 = bu().ClientRectangle.Width - bw().Left - (2 + bv().Width + 2 + bx().Width);
					if (bx().Right > bu().ClientRectangle.Width)
					{
						if (num16 < 60 && bx().Image == null)
						{
							n(A_0: true);
							bw().Width = Math.Max(60, bu().ClientRectangle.Width - bw().Left - (2 + bv().Width + 2 + bx().Width));
						}
						else
						{
							bw().Width = Math.Max(num16, 60);
						}
					}
					else if (num16 >= 180 && bx().Image != null)
					{
						n(A_0: false);
						bw().Width = bu().ClientRectangle.Width - bw().Left - (2 + bv().Width + 2 + bx().Width);
					}
					else
					{
						bw().Width = num16;
					}
					bv().Left = bw().Right + 2;
					bx().Left = bv().Right + 2;
				}
				else if (bs().SelectedTab == bt())
				{
					int num16 = bt().ClientRectangle.Width - bl().Left - (2 + bo().Width + 2 + bn().Width);
					bool flag4 = default(bool);
					int right;
					if (flag4)
					{
						num16 = num16 - f5().Width - 2;
						right = f5().Right;
					}
					else
					{
						right = bn().Right;
					}
					if (right > bt().ClientRectangle.Width)
					{
						if (num16 < 60 && bn().Image == null)
						{
							o(A_0: true);
							bl().Width = bt().ClientRectangle.Width - bl().Left - (2 + bo().Width + 2 + bn().Width);
							if (flag4)
							{
								bl().Width = bl().Width - f5().Width - 2;
							}
							bl().Width = Math.Max(60, bl().Width);
						}
						else
						{
							bl().Width = Math.Max(num16, 60);
						}
					}
					else if (num16 >= 180 && bn().Image != null)
					{
						o(A_0: false);
						bl().Width = bt().ClientRectangle.Width - bl().Left - (2 + bo().Width + 2 + bn().Width);
						if (flag4)
						{
							bl().Width = bl().Width - f5().Width - 2;
						}
					}
					else
					{
						bl().Width = num16;
					}
					bo().Left = bl().Right + 2;
					bn().Left = bo().Right + 2;
					if (flag4)
					{
						f5().Left = bn().Right + 2;
					}
				}
				if (bs().SelectedTab == bu())
				{
					i(global::ej.a(bw().Value), bu().ClientSize);
				}
				else
				{
					float A_2 = 0f;
					float A_3 = 0f;
					i(ref A_2, ref A_3);
				}
				if (!flag)
				{
					if (bs().TabPages.Count > 1)
					{
						bs().TabPages.Remove(bt());
					}
				}
				else if (bs().TabPages.Count == 1)
				{
					bs().TabPages.Add(bt());
				}
			}
			if (bs().Visible)
			{
				b4().Left = bs().Right - 3;
				b4().Top = bs().Top + bs().ItemSize.Height + 1;
				b4().Height = bs().Height - bs().ItemSize.Height - 1;
			}
			else
			{
				b4().Left = bs().Left;
				b4().Top = bs().Top;
				b4().Height = bs().Height;
			}
			if (!flag3)
			{
				num8 = (flag2 ? b4().Right : 0);
			}
			int num17 = 1;
			if (this.m_eg | this.m_eh)
			{
				num17 = 2;
			}
			bool num18 = global::e.a().DualSpectrumGraphs;
			fl fl2 = bb();
			fl2.Top = 12;
			fl2.Left = num8 - num7;
			fl2.Width = num - num8 + num7;
			if (num18)
			{
				fl2.Width = (int)Math.Round((double)(num - num8 + num7) / 2.0);
				gg().Top = 12;
				gg().Left = num8 - num7 + fl2.Width;
				gg().Width = fl2.Width;
			}
			else
			{
				gg().Top = 0;
				gg().Left = 0;
				gg().Width = 0;
			}
			if (num17 == 1)
			{
				fl2.Height = num2;
			}
			else
			{
				fl2.Height = (int)Math.Round((double)num2 / 2.0 - 6.0);
				ba().Left = fl2.Left;
				ba().Top = fl2.Top + fl2.Height + 6;
				ba().Width = num - num8 + num7;
				ba().Height = (int)Math.Round((double)num2 / 2.0 - 6.0);
				bc().Left = ba().Left;
				bc().Top = ba().Top;
				bc().Width = ba().Width;
				bc().Height = ba().Height;
				Rectangle rectangle = bc().fw();
				bd().Left = bc().Left + rectangle.Right - bd().Width;
				bd().Top = bc().Top + rectangle.Top;
			}
			if (num18)
			{
				gg().Height = fl2.Height;
			}
			else
			{
				gg().Height = 0;
			}
			fl2 = null;
		}
	}

	private void o(bool A_0)
	{
		if (A_0)
		{
			Button button = bo();
			bz().SetToolTip(bo(), button.Text);
			button.Text = string.Empty;
			button.Image = Resources.CenterImage;
			button.AutoSize = false;
			button.Width = button.Height;
			button = null;
			Button button2 = bn();
			bz().SetToolTip(bn(), button2.Text);
			button2.Text = string.Empty;
			button2.Image = Resources.SettingImage;
			button2.AutoSize = false;
			button2.Width = button2.Height;
			button2 = null;
		}
		else
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(f4));
			Button button3 = bo();
			bz().SetToolTip(bo(), null);
			componentResourceManager.ApplyResources(bo(), "ButtonVideoCenter");
			button3.Image = null;
			button3.AutoSize = true;
			_ = null;
			Button button4 = bn();
			bz().SetToolTip(bn(), null);
			componentResourceManager.ApplyResources(bn(), "ButtonVideoSettings");
			button4.Image = null;
			button4.AutoSize = true;
			_ = null;
		}
	}

	private void n(bool A_0)
	{
		if (A_0)
		{
			Button button = bv();
			bz().SetToolTip(bv(), button.Text);
			button.Text = string.Empty;
			button.Image = Resources.CenterImage;
			button.AutoSize = false;
			button.Width = button.Height;
			button = null;
			Button button2 = bx();
			bz().SetToolTip(bx(), button2.Text);
			button2.Text = string.Empty;
			button2.Image = Resources.SettingImage;
			button2.AutoSize = false;
			button2.Width = button2.Height;
			button2 = null;
		}
		else
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(f4));
			Button button3 = bv();
			bz().SetToolTip(bv(), null);
			componentResourceManager.ApplyResources(bv(), "ButtonImageCenter");
			button3.Image = null;
			button3.AutoSize = true;
			_ = null;
			Button button4 = bx();
			bz().SetToolTip(bx(), null);
			componentResourceManager.ApplyResources(bx(), "ButtonImageSettings");
			button4.Image = null;
			button4.AutoSize = true;
			_ = null;
		}
	}

	public fl hi()
	{
		return bb();
	}

	public void j(ref float A_0, ref float A_1)
	{
		A_0 = (float)bb().fy();
		A_1 = (float)bb().fz();
	}

	public bool hj()
	{
		return this.m_en > 0;
	}

	private void ar()
	{
		checked
		{
			if (fc().ClientSize.Height < b5().Height)
			{
				fc().Left = base.Width - fc().Width;
			}
			else
			{
				fc().Left = base.Width - fc().Width + 18;
			}
		}
	}

	public void i(int A_0, int A_1)
	{
		try
		{
			base.Height = A_1;
			base.Width = A_0;
			fc().Height = checked(base.ClientRectangle.Height - fc().Top);
			bool flag = l(this.m_ef.wq(this.m_el));
			TabControl tabControl = dm();
			if (flag && (this.m_ef.vl(this.m_el) || this.m_ef.t0(this.m_ek).d0().c() == global::g2.a.b || !this.m_ef.vq(this.m_el)))
			{
				TabPage tabPage = dn();
				string A_2 = "SpectrumAnalysisModeName";
				tabPage.Text = global::hu.a(ref A_2);
				if (this.m_ef.p9(h2()))
				{
					TabPage tabPage2 = dr();
					A_2 = "ThicknessNKRMeasurementModeName";
					tabPage2.Text = global::hu.a(ref A_2);
				}
				else
				{
					TabPage tabPage3 = dr();
					A_2 = "ThicknessMeasurementModeName";
					tabPage3.Text = global::hu.a(ref A_2);
				}
				tabControl.ItemSize = new Size(tabControl.ItemSize.Width, tabControl.ItemSize.Height);
			}
			tabControl = null;
			i(flag, a0());
			int A_3 = default(int);
			i(ref A_3);
			au();
			s();
			ar();
			hh();
			k();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			a4().c(global::fz.b.b, "Exception caught in FIControlPanelMeasModule.ResizePanel. ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void aq()
	{
		if (a0())
		{
			bz().SetToolTip(dw(), "Right-click to edit a new Composite Recipe");
		}
	}

	private void i(bool A_0, bool A_1)
	{
		bool visible = global::e.a().DisplayRecipeControls && !A_0;
		bool visible2 = global::e.a().DisplayRecipeControls && A_0;
		dv().Visible = visible;
		e1().Visible = visible;
		dm().Visible = visible2;
		e2().Visible = visible2;
	}

	public int v(bool A_0)
	{
		int num = 48;
		checked
		{
			num += eh().Height + 6;
			if (global::e.a().DisplaySampleInfoControls)
			{
				num += es().Height + 6;
			}
			if (global::e.a().DisplayMeasStatusControls)
			{
				num = ((!this.m_ga) ? (num + (eq().Height + 6)) : (num + (dz().Height + 6)));
			}
			num += ea().Height + 6;
			if (global::e.a().DisplayRecipeControls)
			{
				num = ((!this.m_ef.sj(h2())) ? (num + (dv().Height + 6)) : (num + (dm().Height + 6)));
			}
			if (global::e.a().DisplayTemplateControls && this.m_ef.xa(this.m_el))
			{
				num += ch().Height + 6;
			}
			if (ac())
			{
				num += c4().Height + 6;
			}
			if (ad())
			{
				num += cm().Height + 6;
			}
			if (global::e.a().DisplayMeasResultsControls && A_0)
			{
				num = ((this.m_gl == null || this.m_gl.i() != global::bx.a.b) ? (num + 150) : (num + ei().Height));
			}
			if (ax())
			{
				num += b6().Height;
			}
			return num;
		}
	}

	private int m(bool A_0)
	{
		int result = default(int);
		return result;
	}

	public int hk()
	{
		if (global::e.a().DisplayMeasStatusControls)
		{
			return eq().Bottom;
		}
		int result = default(int);
		return result;
	}

	public void hl()
	{
		if (this.m_eg)
		{
			ba().g7();
		}
	}

	private b i(ref bool A_0, ref bool A_1)
	{
		b b10 = j(ref A_0);
		if (b10 != global::f4.b.a)
		{
			return b10;
		}
		return i(ref A_1);
	}

	private b j(ref bool A_0)
	{
		if (Monitor.TryEnter(this.m_e0, 300))
		{
			A_0 = true;
			return global::f4.b.a;
		}
		A_0 = false;
		return global::f4.b.b;
	}

	private b i(ref bool A_0)
	{
		if (Monitor.TryEnter(this.m_ez, 300))
		{
			A_0 = true;
			return global::f4.b.a;
		}
		A_0 = false;
		return global::f4.b.c;
	}

	private void i(fh.b A_0, hr.b A_1)
	{
		if (this.m_e1 == A_0)
		{
			return;
		}
		bb().g1();
		if (gg().Height > 0)
		{
			gg().g1();
		}
		foreach (hr item in this.m_e0)
		{
			global::d7.a(this.m_ef, bb(), item, A_0, A_1);
			if (gg().Height > 0)
			{
				global::d7.a(this.m_ef, gg(), item, A_0, A_1);
			}
		}
		this.m_e1 = A_0;
	}

	private void ap()
	{
		dm().SelectedTab = dn();
		i(l(this.m_ef.wq(this.m_el)), a0());
	}

	private void ao()
	{
		bool a_ = l((hg)null);
		i(a_, a0());
		dm().SelectedTab = dr();
	}

	private void i(hr A_0, object A_1, bool A_2 = false)
	{
		this.m_er.b();
		bool A_3 = false;
		bool A_4 = false;
		checked
		{
			try
			{
				short num = ((!this.m_ef.ws(this.m_el)) ? global::e.a().GraphMeasUserDefinedMaxCurves : ((short)this.m_ef.wr(this.m_el).ab()));
				if (!A_2 && i(ref A_3, ref A_4) != global::f4.b.a)
				{
					this.m_eo.c(global::fz.b.b, "Failed to lock spectrum collection in AddSpectrum", Environment.StackTrace);
					return;
				}
				hr hr2 = A_0;
				if (!j(A_0))
				{
					for (int num2 = this.m_e0.Count - 1; num2 >= 0; num2 += -1)
					{
						i(num2, A_1: true);
					}
				}
				int A_5 = default(int);
				if (j(hr2.b9(), ref A_5))
				{
					this.m_e0.RemoveAt(A_5);
					int A_6 = default(int);
					if (i(hr2.b9(), ref A_6) && this.m_ez[A_6].cn().ca() != hr2.ca())
					{
						this.m_ez.RemoveAt(A_6);
					}
				}
				else
				{
					if (this.m_e0.Count >= num)
					{
						i(0, A_1: true);
					}
					A_5 = this.m_e0.Count;
				}
				fh.b A_7 = default(fh.b);
				hr.b A_8 = default(hr.b);
				global::d7.a(this.m_e0, A_0, ref A_7, ref A_8);
				i(A_7, A_8);
				global::d7.a(this.m_ef, bb(), A_0, A_7, A_8);
				if (gg().Height > 0)
				{
					global::d7.a(this.m_ef, gg(), A_0, A_7, A_8);
				}
				bool flag = this.m_ef.t6(this.m_ek) != null;
				@if = hr2.bp();
				if (hr2.bp() != null || flag)
				{
					if (hr2.bp() == null)
					{
						bq().Image = null;
					}
					else
					{
						j(bu().ClientSize);
					}
				}
				bb().s(global::ey.a8());
				if (gg().Height > 0)
				{
					gg().s(global::ey.a8());
				}
				this.m_e0.Insert(A_5, A_0);
				if (this.m_ef.ws(this.m_el))
				{
					j(this.m_ef.wr(this.m_el).ad()[A_5]);
				}
				long a_ = hr2.b9();
				int A_9 = 0;
				if (!i(a_, ref A_9))
				{
					@as();
				}
				hr2 = null;
			}
			finally
			{
				if (!A_2)
				{
					if (A_4)
					{
						Monitor.Exit(this.m_ez);
					}
					if (A_3)
					{
						Monitor.Exit(this.m_e0);
					}
				}
			}
		}
	}

	private bool j(long A_0, ref int A_1)
	{
		checked
		{
			int num = this.m_e0.Count - 1;
			A_1 = 0;
			while (A_1 <= num)
			{
				if (this.m_e0[A_1].b9() == A_0)
				{
					return true;
				}
				A_1++;
			}
			A_1 = -1;
			return false;
		}
	}

	private bool i(long A_0, ref int A_1)
	{
		checked
		{
			int num = this.m_ez.Count - 1;
			A_1 = 0;
			while (A_1 <= num)
			{
				if (this.m_ez[A_1].cn().b9() == A_0)
				{
					return true;
				}
				A_1++;
			}
			A_1 = -1;
			return false;
		}
	}

	private string an()
	{
		string text = ev().Text.ToString();
		if (Operators.CompareString(text, "", TextCompare: false) == 0)
		{
			string A_ = "Unknown";
			text = global::hu.a(ref A_);
		}
		return text;
	}

	private void am()
	{
		l(A_0: true);
	}

	private void al()
	{
		l(A_0: false);
	}

	private void l(bool A_0)
	{
		bool flag = this.m_ef.t0(this.m_ek).ed().ft();
		bb().f7 = !A_0 | flag;
		bb().aj(A_0);
		gg().f7 = !A_0 | flag;
		gg().aj(A_0);
		dy().Enabled = !A_0;
		dw().Enabled = !A_0;
		dq().Enabled = !A_0;
		@do().Enabled = !A_0;
		du().Enabled = !A_0;
		ds().Enabled = !A_0;
	}

	[SpecialName]
	public bool hm()
	{
		if (!this.m_fn && !fo && !fp && g3() != null)
		{
			return true;
		}
		return false;
	}

	public void i(bool A_0, Point A_1, ref bool A_2)
	{
		if (hm())
		{
			bool A_3 = !global::e.a().PromptForBaselineReminder;
			float A_4 = global::e.a().BaselineRemindTimeMinutes / 60f;
			bb obj = new bb();
			Point a_ = ((!A_0) ? A_1 : global::i6.a(eb()));
			bb.a a10 = obj.a(ref A_4, ref A_3, a_, this.m_ef.sm(this.m_el), global::e.a().ForceBaselineIfIntervalExceeded);
			if (a10 != global::bb.a.a)
			{
				global::e.a().PromptForBaselineReminder = !A_3;
				global::e.a().BaselineRemindTimeMinutes = A_4 * 60f;
				h4();
			}
			switch (a10)
			{
			case global::bb.a.a:
				A_2 = false;
				break;
			case global::bb.a.b:
				A_2 = true;
				break;
			case global::bb.a.c:
			{
				A_2 = false;
				Point a_2 = ((!A_0) ? A_1 : global::i6.a(ec()));
				f1 a_3 = this.m_ef;
				Guid a_4 = this.m_el;
				fz a_5 = this.m_eo;
				gr a_6 = this.m_hz;
				bool A_5 = false;
				i(a_3, a_4, a_5, this, a_6, a_2, ref A_5);
				break;
			}
			}
		}
		else
		{
			A_2 = true;
		}
	}

	private void aw(object A_0, EventArgs A_1)
	{
		try
		{
			bool A_2 = false;
			i(A_0: true, default(Point), ref A_2);
			if (A_2)
			{
				w(A_0: true);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_eo, this.m_ef, this, a3(), "FIControlPanelMeasModule.ButtonMeasure_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void av(object A_0, EventArgs A_1)
	{
		try
		{
			ce.ErrPublic errPublic = this.m_ef.sm(this.m_ek);
			if (errPublic != global::ce.ErrPublic.None)
			{
				global::fe.b(this.m_eo, "Error in ButtonAnalysisAccept_Click. errCode=" + errPublic, a3());
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_eo, this.m_ef, this, a3(), "FIControlPanelMeasModule.ButtonAnalysisAccept_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void au(object A_0, EventArgs A_1)
	{
		try
		{
			string A_2 = "";
			this.m_e7.q(A_0: true);
			f1 obj = this.m_ef;
			string a_ = this.m_ek;
			string A_3 = "AnalysisCancelled";
			if (obj.p9(a_, "Cancelling Analysis", ref A_2, global::hu.a(ref A_3)) != global::ce.ErrPublic.None || !string.IsNullOrEmpty(A_2))
			{
				global::fe.b(this.m_eo, "Error in ButtonMeasCancel_Click. Failure message=" + A_2, a3());
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_eo, this.m_ef, this, a3(), "FIControlPanelMeasModule.ButtonMeasCancel_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void at(object A_0, EventArgs A_1)
	{
		try
		{
			string A_2 = null;
			if (this.m_ef.m2(this.m_el, ref A_2))
			{
				f1 a_ = this.m_ef;
				Guid a_2 = this.m_el;
				fz a_3 = this.m_eo;
				gr a_4 = this.m_hz;
				Point a_5 = global::i6.a(ec());
				bool A_3 = false;
				i(a_, a_2, a_3, this, a_4, a_5, ref A_3);
				this.m_eq.b();
			}
			else
			{
				ref fz a_6 = ref this.m_eo;
				string toolTip = bz().GetToolTip(ec());
				Point A_4 = a3();
				global::fe.b(ref a_6, toolTip, ref A_4);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_7 = ex2;
			global::i5.a(this.m_eo, this.m_ef, this, a3(), "FIControlPanelMeasModule.ButtonMeasBaseline_Click", a_7);
			ProjectData.ClearProjectError();
		}
	}

	public void hn()
	{
		if (!hx())
		{
			return;
		}
		bool flag = true;
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		do
		{
			if (hx())
			{
				Application.DoEvents();
				Thread.Sleep(500);
				continue;
			}
			flag = false;
			break;
		}
		while (stopwatch.ElapsedMilliseconds < 5000);
		stopwatch.Stop();
		if (flag)
		{
			throw new Exception("Timeout waiting more than " + 5.0 + " s for continuous acquire to stop before starting another one.");
		}
	}

	public void i(bool A_0, bool A_1, bool A_2, bool A_3, global::r.d A_4, ref bool A_5, Point A_6, Form A_7 = null)
	{
		i(A_0, A_1, A_2, A_3, A_4, global::bg.a.a, ref A_5, A_6, A_7);
	}

	public void i(bool A_0, bool A_1, bool A_2, bool A_3, global::r.d A_4, bg.a A_5, ref bool A_6, Point A_7, Form A_8 = null)
	{
		hn();
		bg bg2 = new bg(this.m_ef, this.m_eo, this.m_el);
		bg.b a_ = global::bg.b.a;
		if (this.m_ef.u8(this.m_el) == global::g2.a.f)
		{
			a_ = global::bg.b.c;
		}
		fu obj = bb().gi();
		bool a_2 = obj.ao();
		double a_3 = obj.at(false);
		obj.am(A_0: false);
		obj.am(A_0: false, 4096.0);
		_ = null;
		Point a_4 = global::i6.a(dw());
		Point location = default(Point);
		if (A_8 != null)
		{
			location = A_8.Location;
			global::i6.a(a_4, A_8);
		}
		try
		{
			try
			{
				i(A_0: false, A_1: false, A_2: true, A_3: false, global::h6.b.b);
				if (this.m_ef.t6(this.m_ek) != null)
				{
					if (this.m_h8)
					{
						p(null, null);
					}
					if (bs().SelectedTab != bt())
					{
						bs().SelectedTab = bt();
					}
				}
				bg2.c(a_4, A_5, a_, A_3: true, gv());
				if (bg2.DialogResult == DialogResult.OK)
				{
					A_6 = true;
				}
				else
				{
					A_6 = false;
				}
			}
			finally
			{
				i(A_0: false, A_1: false, A_2: true, A_3: false, global::h6.b.b);
			}
		}
		finally
		{
			fu obj2 = bb().gi();
			obj2.am(a_2);
			obj2.am(A_0: false, a_3);
			_ = null;
			if (A_8 != null)
			{
				A_8.Location = location;
			}
		}
		hn();
		if (A_6)
		{
			A_4?.d(this.m_el, null);
		}
	}

	public static void i(f1 A_0, Guid A_1, fz A_2, f4 A_3, gr A_4, Point A_5, ref bool A_6)
	{
		ix.b b10 = new ix.b();
		if (A_0.u8(A_1) == global::g2.a.b && A_0.w8(A_1))
		{
			A_3.gi().CheckState = CheckState.Unchecked;
			string A_7 = "LockRemovedMessage";
			string a_ = global::hu.a(ref A_7);
			global::fe.b(A_2, a_, "LockRemovedTitle", global::i6.a(A_3));
		}
		A_0.m2(A_1, A_4, A_3, A_5, b10, A_5: false, global::r.d.a.b.a, new ix.b(), new ix.e());
		A_6 = b10.a;
	}

	public void i(Point A_0, ref bool A_1)
	{
		i(this.m_ef, this.m_el, this.m_eo, this, this.m_hz, A_0, ref A_1);
	}

	private void ak()
	{
		e6.b a_ = global::e6.b.c;
		new e6(this.m_eo).a(a_, this.m_hz, this.m_ef, this, this.m_el, A_5: false);
	}

	private void @as(object A_0, EventArgs A_1)
	{
		try
		{
			if (this.m_e3)
			{
				string text = ex().Text;
				if (Operators.CompareString(global::e.a().SampleID, text, TextCompare: false) != 0)
				{
					global::e.a().SampleID = text;
					this.m_g4?.Invoke(this.m_el, text, A_2: true);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.b, "Error in FIControlPanelMeasModule.TextBoxSampleId_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	public bool ho()
	{
		if (this.m_e0.Count > 0 && (this.m_ef.ws(this.m_el) || global::e.a().GraphMeasUserDefinedMaxCurves > 1))
		{
			hr.b[] array = this.m_ef.ti(hb());
			if (!i(array[0], this.m_e0[0].cj()))
			{
				ref fz a_ = ref this.m_eo;
				string A_ = "GraphDataTypeChangePrompt";
				if (global::fe.b(ref a_, string.Format(global::hu.a(ref A_), '\r'.ToString()), "Information", "Yes", "No", a3()))
				{
					this.m_ef.m2(this.m_el, hd(), A_2: true);
					return true;
				}
				return false;
			}
			return true;
		}
		return true;
	}

	public bool i(ref f5 A_0)
	{
		int A_1 = default(int);
		if (!j(bb().e7(), ref A_1))
		{
			return false;
		}
		A_0.t(hd());
		A_0.u(ev().Text);
		A_0.g(this.m_e0[A_1].cn());
		A_0.a(DateAndTime.Now);
		Bitmap bitmap = null;
		if (this.m_ef.uk())
		{
			bitmap = global::i5.a();
		}
		if (bitmap == null)
		{
			A_0.a(global::i5.a(this.m_ef.qh(this.m_ek), A_1: true));
		}
		else
		{
			A_0.a(bitmap);
		}
		if (this.m_eg | this.m_eh)
		{
			A_0.a(2);
		}
		else
		{
			A_0.a(1);
		}
		A_0.a(0, bb());
		if (this.m_eg)
		{
			A_0.a(1, ba());
		}
		else if (this.m_eh)
		{
			A_0.a(1, bc());
		}
		return true;
	}

	public void ax(object A_0, EventArgs A_1)
	{
		bool A_2 = false;
		hg hg2 = this.m_ef.t0(this.m_ek);
		string text = "";
		checked
		{
			try
			{
				if (global::gq.g(this.m_h5))
				{
					this.m_ef.m2(this.m_el, this.m_eo, global::i6.a(dw()), ref A_2);
				}
				if (A_2)
				{
					return;
				}
				bool flag = hg2.b5() && this.m_ef.sj(h2());
				text = ((Operators.CompareString(hg2.ci(), "DefaultRecipe", TextCompare: false) != 0 || !flag) ? Path.GetExtension(hg2.c1()) : ".fitra");
				if (!new DirectoryInfo(global::hg.b0()).Exists)
				{
					global::c.e().FileSystem.CreateDirectory(global::hg.b0());
				}
				string a_ = ((!this.m_ef.ws(this.m_el)) ? hg2.c1() : this.m_ef.wr(this.m_el).w());
				fk fk2 = null;
				List<string> a_2 = null;
				h2();
				bool a_3 = a0();
				if (this.m_h5 != null && this.m_h5.k() && this.m_h5.g() && this.m_h5.h() <= global::gq.a.b)
				{
					a_2 = this.m_h5.l();
				}
				fk2 = new fk(this.m_eo, global::hg.b0(), a_, text, global::fk.a.a, "DefaultRecipe", a_3, a_2);
				Point point = ((!global::e.a().DisplayRecipeControls || !this.m_ef.sj(h2())) ? global::i6.a(dw()) : ((!flag) ? global::i6.a(ds()) : global::i6.a(@do())));
				Point a_4 = new Point(point.X + unchecked(dw().Width / 2), point.Y - unchecked(dw().Height / 2));
				fk2.a(a_4);
				if (!fk2.k())
				{
					try
					{
						i(fk2.q(), flag, global::r.d.a.b.a, gq());
						return;
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2);
						Exception ex3 = ex2;
						fz a_5 = this.m_eo;
						string A_3 = "RecipeLoadErrFmt2";
						global::fe.b(a_5, string.Format(global::hu.a(ref A_3), Strings.LCase("Recipe"), fk2.q()), "RecipeLoadTitle", global::i6.a(dw()));
						ProjectData.ClearProjectError();
						return;
					}
				}
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception a_6 = ex4;
				this.m_eo.c(global::fz.b.b, "Error in FIControlPanelMeasModule ButtonGetRecipe_Click.", a_6);
				string[] array = new string[6];
				string A_3 = "GeneralFunctionErrIn";
				array[0] = global::hu.a(ref A_3);
				array[1] = " FIControlPanelMeasModule ButtonGetRecipe_Click.\r\n";
				A_3 = "GeneralFunctionErrIs";
				array[2] = global::hu.a(ref A_3);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString("General Date");
				string a_7 = string.Concat(array);
				global::fe.b(this.m_eo, a_7, "Information", global::i6.a(dw()));
				ProjectData.ClearProjectError();
			}
		}
	}

	public void i(string A_0, bool A_1, global::r.d.a.b A_2, global::r.d A_3)
	{
		if (Operators.CompareString(Path.GetExtension(A_0), ".ficrp", TextCompare: false) == 0)
		{
			if (!this.m_ef.wr(this.m_el).s(A_0, this.m_ef.ut(), this.m_ef.t0(this.m_ek), global::hg.b4(), A_3, A_2, A_6: true, A_7: true, global::i6.a(this), global::e.a().OperatorID, this.m_ef.w9(this.m_el), !this.m_ef.w6(this.m_el), this.m_eo))
			{
				throw new ApplicationException("Failure attempting to load composite recipe " + A_0);
			}
			az();
			return;
		}
		hg hg2 = this.m_ef.t0(this.m_ek);
		if (!hg2.bu(A_0, global::hg.b4(), A_3, A_2, A_4: true, A_5: true, global::i6.a(dm()), global::e.a().OperatorID, this.m_ef.w9(this.m_el), !this.m_ef.w6(this.m_el), this.m_eo, this.m_ef.xk(this.m_el), A_12: false, A_13: false, null, A_15: false) && !global::hg.bu(hg2, global::hg.b4(), A_1, gq(), global::r.d.a.b.a, this.m_eo, this.m_ef.w9(this.m_el), !this.m_ef.w6(this.m_el), A_8: false))
		{
			fz a_ = this.m_eo;
			string A_4 = "RecipeLoadErrFmt2";
			global::fe.b(a_, string.Format(global::hu.a(ref A_4), Strings.LCase("Recipe"), A_0), "RecipeLoadTitle", global::i6.a(dm()));
		}
	}

	public bool hp()
	{
		return this.m_ef.wq(this.m_el).d0().q();
	}

	private bool aj()
	{
		if (this.m_ef.wq(this.m_el).b5())
		{
			return false;
		}
		hr hr2 = null;
		int A_ = default(int);
		if (j(bb().e7(), ref A_))
		{
			hr2 = this.m_e0[A_];
		}
		if (hr2 == null)
		{
			return hp();
		}
		return hr2.cu().q() != null;
	}

	private void ar(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				hg hg2 = this.m_ef.wq(this.m_el);
				eo.a a_ = h2();
				hr hr2 = h1();
				bool a_2 = default(bool);
				bool a_3 = default(bool);
				bool a_4 = default(bool);
				bool a_5 = default(bool);
				bool a_6 = default(bool);
				if (hg2.b5())
				{
					a_2 = true;
					a_3 = hr2 != null && hr2.ao() && hr2.bl() != null && hr2.bl().ap();
				}
				else if (hr2 == null)
				{
					a_4 = this.m_ef.m2(this.m_el);
					a_2 = !this.m_ef.sm();
				}
				else
				{
					a_5 = true;
					a_6 = hr2.cu().q() != null;
				}
				bool flag;
				bool flag2;
				if (hr2 == null)
				{
					flag = this.m_ef.qh();
					flag2 = this.m_ef.sj();
				}
				else
				{
					flag = global::b6.c(hr2.cz()[0], hr2.cz()[hr2.c2() - 1]);
					flag2 = global::b7.c(hr2.cz()[0], hr2.cz()[hr2.c2() - 1]);
				}
				global::e.a().SASWShowUVAnalysisFeaturesIfNoSpectrum = flag;
				global::e.a().SASWShowLuminousReflectanceIfNoSpectrum = flag2;
				string A_2 = null;
				f1 obj = this.m_ef;
				Guid a_7 = this.m_el;
				string A_3 = null;
				obj.m2(a_7, ref A_2, ref A_3);
				e8.f a_8 = default(e8.f);
				this.m_f5.a(this.m_ef, this.m_h5, this.m_el, hg2.b5() && this.m_ef.sj(h2()), ev().Text, this.m_hz, this.m_h0, this, new e8.a(a_5, a_6, a_4, a_2, hp(), A_2, flag, flag2, a_, a_3), A_9: false, a_8);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_9 = ex2;
				this.m_f5.c();
				global::i5.a(this.m_eo, this.m_ef, this, a3(), "FIControlPanelMeasModule.ButtonMeasEdit_Click", a_9);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void i(global::r.d.a.b A_0)
	{
		bool A_1 = false;
		bool A_2 = false;
		hr hr2 = null;
		try
		{
			if (j(ref A_1) != global::f4.b.a)
			{
				throw new ao("Timeout waiting for lock on spectrum collection in ReanalyzeActiveSpectrum");
			}
			if (i(ref A_2) != global::f4.b.a)
			{
				throw new ao("Timeout waiting for lock on spectrum collection in ReanalyzeActiveSpectrum");
			}
			long a_ = bb().e7();
			int A_3 = default(int);
			if (j(a_, ref A_3))
			{
				hr2 = this.m_e0[A_3];
			}
			int A_4 = default(int);
			if (i(a_, ref A_4))
			{
				i(a_, hr2.ca(), A_2: true);
			}
			if (hr2 != null)
			{
				i(hr2, "Reanalyzing Spectrum after changing optics configuration...", A_2: true, A_3: true, A_0);
			}
		}
		finally
		{
			if (A_2)
			{
				Monitor.Exit(this.m_ez);
			}
			if (A_1)
			{
				Monitor.Exit(this.m_e0);
			}
		}
	}

	public void i(hg A_0, bool A_1, global::r.d.a.b A_2)
	{
		checked
		{
			int A_6 = default(int);
			if (A_1)
			{
				bool A_3 = false;
				bool A_4 = false;
				try
				{
					hr hr2 = null;
					long a_ = bb().e7();
					if (j(ref A_3) != global::f4.b.a)
					{
						throw new ao("Timeout waiting for lock on spectrum collection in ReanalyzeActiveSpectrum");
					}
					if (i(ref A_4) != global::f4.b.a)
					{
						throw new ao("Timeout waiting for lock on spectrum collection in ReanalyzeActiveSpectrum");
					}
					bool flag = false;
					int A_5 = default(int);
					if (this.m_ef.ws(this.m_el))
					{
						int num = this.m_e0.Count - 1;
						for (int num2 = 0; num2 <= num; num2++)
						{
							hr hr3 = this.m_e0[num2];
							a_ = hr3.b9();
							if (i(a_, ref A_5) && !this.m_ez[A_5].cf(this.m_ef.wr(this.m_el).ad()[num2]))
							{
								flag = true;
								hr2 = hr3;
								break;
							}
						}
					}
					else if (j(a_, ref A_6) && i(a_, ref A_5))
					{
						flag = !this.m_ez[A_5].cf(this.m_ef.t0(this.m_ek)) || this.m_e2 != null;
						hr2 = this.m_e0[A_6];
					}
					if (flag)
					{
						i(a_, hr2.ca(), A_2: true);
						@as();
					}
				}
				finally
				{
					if (A_4)
					{
						Monitor.Exit(this.m_ez);
					}
					if (A_3)
					{
						Monitor.Exit(this.m_e0);
					}
				}
			}
			v();
			this.m_eq.b();
			hg hg2 = this.m_ef.wq(this.m_el);
			hg hg3 = hg2;
			hi hi2 = hg3.ed();
			if (hi2 == null)
			{
				return;
			}
			hr a_2 = null;
			g2.a a_3 = this.m_ef.u8(this.m_el);
			if (this.m_e0.Count != 0)
			{
				a_2 = this.m_e0[0];
			}
			global::h.e a_4 = hg3.b8().a(this.m_ef.va(this.m_el));
			global::d7.a(bb(), a_2, hg2, a_3, a_4);
			if (hg3.cb() && (hg3.cj() != 0.0 || hg3.ck() != 0.0))
			{
				bb().gi().a2().am(hg3.cj());
				bb().gi().a2().an(hg3.ck());
			}
			else
			{
				fr fr2 = bb().gi().a2();
				double num3 = this.m_ef.ux();
				double num4 = this.m_ef.uz();
				double num5 = global::e.a().LastWavelengthMinActiveSpec;
				double num6 = global::e.a().LastWavelengthMaxActiveSpec;
				bool flag2 = Math.Abs(num5 - num3) > 50.0;
				bool flag3 = Math.Abs(num6 - num4) > 50.0;
				bool flag4 = false;
				if ((fr2.ap() == 0.0 && fr2.aq() == 0.0) || flag2 || flag3)
				{
					if (num5 != 0.0 && num6 != 0.0 && fr2.ap() != 0.0 && fr2.aq() != 0.0)
					{
						bool flag5 = flag2 && jf.d(num5, num3);
						bool flag6 = flag3 && jf.b(num6, num4);
						bool num7 = (flag5 && (!flag3 || flag6)) || (flag6 && (!flag2 || flag5));
						bool flag7 = (Math.Abs(fr2.ap() - num3) < 0.10000000149011612 || fr2.ap() > num3) && (Math.Abs(fr2.aq() - num4) < 0.10000000149011612 || fr2.aq() < num4);
						flag4 = num7 && flag7;
					}
					if (!flag4)
					{
						fr2.am(num3);
						fr2.an(num4);
					}
					global::e.a().LastWavelengthMinActiveSpec = num3;
					global::e.a().LastWavelengthMaxActiveSpec = num4;
				}
				hg2.bu(fr2.ap());
				hg2.bv(fr2.aq());
				fr2 = null;
				if (hg3.cb() && !hg3.b5())
				{
					A_1 = true;
					hg2.bu(gq());
				}
			}
			hg3 = null;
			n(this.m_ef.t0(this.m_ek));
			if (!A_1)
			{
				bool A_7 = default(bool);
				try
				{
					if (j(ref A_7) != global::f4.b.a)
					{
						throw new ao("Timeout waiting for lock on spectrum collection in SpectrumRenamedByUserHandler");
					}
					long a_5 = bb().e7();
					int A_8 = 0;
					if (j(a_5, ref A_8) && A_2 == global::r.d.a.b.a)
					{
						i(A_2);
					}
				}
				finally
				{
					if (A_7)
					{
						Monitor.Exit(this.m_e0);
					}
				}
			}
			if (this.m_ef.ws(this.m_el) && j(bb().e7(), ref A_6))
			{
				if (A_6 < this.m_ef.wr(this.m_el).ad().Count)
				{
					j(this.m_ef.wr(this.m_el).ad()[A_6]);
				}
			}
			else
			{
				bb().p(hi2.fs(), hi2.fr(), hi2.fu());
			}
		}
	}

	private void i(hr.b[] A_0, ref bool A_1, ref bool A_2)
	{
		A_1 = false;
		A_2 = false;
		for (int num = 0; num < A_0.Length; num = checked(num + 1))
		{
			switch (A_0[num])
			{
			case global::hr.b.c:
				A_1 = true;
				break;
			case global::hr.b.j:
				A_2 = true;
				break;
			}
		}
	}

	private bool ai()
	{
		g2 g10 = this.m_ef.u9(this.m_el);
		if (g10.r() == null)
		{
			return false;
		}
		return (et)this.m_ef.so(g10.w).i(((et)g10.r()).al()) != null;
	}

	private void i(hr A_0, hr.b[] A_1, ref fl.n A_2, ref fl.h A_3)
	{
		double[] a_ = null;
		double[] a_2 = null;
		double[] a_3 = null;
		double[] a_4 = null;
		double[] array = null;
		double[] a_5 = null;
		fl.h h10 = (((A_0.cj() != global::hr.b.c || !jf.e(A_0.cu().m(), 0f)) && A_0.cj() != global::hr.b.a) ? ((A_0.cj() != global::hr.b.c) ? global::fl.h.b : global::fl.h.c) : global::fl.h.a);
		fh.b A_4 = default(fh.b);
		hr.b A_5 = default(hr.b);
		global::d7.a(null, A_0, ref A_4, ref A_5);
		if (A_4 != global::fh.b.a)
		{
			fl.o a_6 = global::d7.a(A_0, A_0, A_5);
			A_2.e(a_6);
			A_3 = global::fl.h.a;
			return;
		}
		int a_7 = default(int);
		int a_8 = default(int);
		int a_9 = default(int);
		if (h1() != null)
		{
			A_3 = h10;
			a_ = A_0.cz();
			a_2 = A_0.c0();
			a_7 = A_0.c2();
			if (A_0.bl() != null)
			{
				a_3 = A_0.bl().cz();
				a_4 = A_0.bl().c0();
				a_8 = A_0.bl().c2();
			}
			if (A_0.bm() != null)
			{
				array = A_0.bm()[0].cz();
				a_5 = A_0.bm()[0].c0();
				a_9 = A_0.bm()[0].c2();
			}
		}
		else
		{
			bool A_6 = default(bool);
			bool A_7 = default(bool);
			i(A_1, ref A_6, ref A_7);
			if (h10 == global::fl.h.a)
			{
				if (A_6)
				{
					A_3 = global::fl.h.a;
					a_ = A_0.cz();
					a_2 = A_0.c0();
					a_7 = A_0.c2();
					if (A_7 && A_0.bl() != null)
					{
						a_3 = A_0.bl().cz();
						a_4 = A_0.bl().c0();
						a_8 = A_0.bl().c2();
					}
					if (A_0.bm() != null)
					{
						array = A_0.bm()[0].cz();
						a_5 = A_0.bm()[0].c0();
						a_9 = A_0.bm()[0].c2();
					}
				}
				else if (A_7 && A_0.bl() != null)
				{
					A_3 = global::fl.h.a;
					a_ = A_0.bl().cz();
					a_2 = A_0.bl().c0();
					a_7 = A_0.bl().c2();
				}
			}
			else if (h10 == global::fl.h.b && A_7)
			{
				if (A_6)
				{
					A_3 = global::fl.h.a;
				}
				else
				{
					A_3 = global::fl.h.b;
				}
				a_ = A_0.cz();
				a_2 = A_0.c0();
				a_7 = A_0.c2();
			}
			else if (A_6)
			{
				A_3 = global::fl.h.a;
				a_ = A_0.cz();
				a_2 = A_0.c0();
				a_7 = A_0.c2();
				if (A_7 && A_0.bl() != null)
				{
					a_3 = A_0.bl().cz();
					a_4 = A_0.bl().c0();
					a_8 = A_0.bl().c2();
				}
			}
			else if (A_7 && A_0.bl() != null)
			{
				A_3 = global::fl.h.a;
				a_ = A_0.bl().cz();
				a_2 = A_0.bl().c0();
				a_7 = A_0.bl().c2();
			}
		}
		fl.o a_10 = new fl.o(a_, a_2, a_7, a_3, a_4, a_8);
		A_2.e(a_10);
		if (array != null)
		{
			a_10 = new fl.o(array, a_5, a_9, null, null, 0);
			A_2.e(a_10);
		}
	}

	private bool k(hg A_0)
	{
		hi hi2 = A_0.ed();
		if (A_0.b5() && !string.IsNullOrEmpty(hi2.e2()))
		{
			return global::c.e().FileSystem.FileExists(hi2.e2());
		}
		return false;
	}

	public void n(hg A_0)
	{
		if (k(A_0))
		{
			hi hi2 = A_0.ed();
			hr hr2;
			if (Operators.CompareString(Path.GetExtension(hi2.e2()), ".fmspe", TextCompare: false) == 0)
			{
				hr2 = new hr(null);
			}
			else
			{
				string A_1 = "";
				string A_2 = "";
				this.m_ef.m2(this.m_el, ref A_2, ref A_1);
				hr2 = new hr(A_1, DateAndTime.Now, ev().Text, null);
			}
			hr obj = hr2;
			hi hi3;
			string A_3 = (hi3 = hi2).e2();
			obj.ag(ref A_3, null);
			hi3.d7(A_3);
			hi2 = null;
			if (hr2 == null)
			{
				return;
			}
			bb().s(global::ey.a8());
			hr.b[] array = this.m_ef.wh(this.m_el);
			hr hr3 = hr2;
			fl.n A_4 = new fl.n();
			fl.h A_5 = default(fl.h);
			i(hr2, array, ref A_4, ref A_5);
			bool A_6 = default(bool);
			bool A_7 = default(bool);
			i(array, ref A_6, ref A_7);
			if (h1() != null || (A_6 && (A_5 == global::fl.h.a || A_5 == global::fl.h.c)) || (A_7 && A_5 == global::fl.h.b) || hr2.c3() != null)
			{
				bb().o(A_4, -1L, 0L, "", string.Format(global::ey.aq(), hr3.b5()), global::ey.ap(), A_6: true, A_5, A_8: true);
				if (gg().Height > 0)
				{
					gg().o(A_4, -1L, 0L, "", string.Format(global::ey.aq(), hr3.b5()), global::ey.ap(), A_6: true, A_5, A_8: true);
				}
			}
			else
			{
				bb().g2();
				if (gg().Height > 0)
				{
					gg().g2();
				}
			}
			hr3 = null;
			bb().gb = false;
			bb().Invalidate();
			if (gg().Height > 0)
			{
				gg().gb = false;
				gg().Invalidate();
			}
		}
		else
		{
			bb().g2();
			if (gg().Height > 0)
			{
				gg().g2();
			}
		}
	}

	private void j(hg A_0)
	{
		hi hi2 = A_0.ed();
		if (hi2 != null)
		{
			bb().p(hi2.fs(), hi2.fr(), hi2.fu());
		}
	}

	private void ah()
	{
		global::d7.a(bb(), this.m_ef.wh(this.m_el));
		global::d7.a(gg(), this.m_ef.wh(this.m_el));
		global::gp.a(ba(), this.m_ef.t0(this.m_ek));
		global::gp.a(bc());
	}

	public bool hq()
	{
		if (this.m_ef.wq(this.m_el).b5())
		{
			return this.m_ef.sj(h2());
		}
		return false;
	}

	public bool hr()
	{
		return this.m_hr != null;
	}

	public void hs()
	{
		if (this.m_hr != null)
		{
			this.m_hr.Activate();
		}
	}

	private void i(long A_0, long A_1, global::r.d.a.b A_2)
	{
		try
		{
			bool A_3 = false;
			bool A_4 = false;
			hr hr2 = null;
			hc hc2 = null;
			hg hg2 = null;
			try
			{
				if (i(ref A_3, ref A_4) != global::f4.b.a)
				{
					throw new ao("Timeout waiting for lock on collections in ActiveSpectrumChangedByUserHandler");
				}
				int A_5 = default(int);
				if (!j(A_0, ref A_5) || this.m_e0[A_5].ca() != A_1)
				{
					return;
				}
				if (this.m_ef.ws(this.m_el))
				{
					j(this.m_ef.wr(this.m_el).ad()[A_5]);
				}
				int A_6 = default(int);
				if (this.m_e2 == null)
				{
					hg2 = this.m_ef.t0(this.m_ek);
				}
				else
				{
					if (!i(A_0, ref A_6))
					{
						return;
					}
					hg2 = this.m_ez[A_6].cy();
				}
				hr2 = this.m_e0[A_5];
				@if = hr2.bp();
				hg hg3 = hg2;
				if (i(A_0, ref A_6))
				{
					hc hc3 = this.m_ez[A_6];
					bool flag;
					if (global::e.a().ShowSpectrumColor && global::b5.g(hc3.cn()))
					{
						if (hc3.co() == null)
						{
							flag = true;
						}
						else
						{
							flag = true;
							foreach (cc.d item in hc3.co().e())
							{
								if (item.h() == (a4.a)global::e.a().ShowSpectrumCoordOption)
								{
									flag = false;
									break;
								}
							}
							if (global::e.a().AlwayShowSpectrumCoordXYZ && global::e.a().ShowSpectrumCoordOption != 3 && !flag)
							{
								flag = true;
								foreach (cc.d item2 in hc3.co().e())
								{
									if (item2.h() == global::a4.a.d)
									{
										flag = false;
										break;
									}
								}
							}
						}
					}
					else
					{
						flag = false;
					}
					if (hc3.cn().ca() == A_1 && hc3.cf(hg2) && (hc3.cy().b5() || !hg3.ed().fu() || !this.m_ef.m2(this.m_ek, hc3)) && !flag)
					{
						hc2 = hc3;
					}
					else
					{
						i(A_0, A_1, A_2: true);
					}
				}
				j(bu().ClientSize);
				hg3 = null;
			}
			finally
			{
				if (A_3)
				{
					Monitor.Exit(this.m_e0);
				}
				if (A_4)
				{
					Monitor.Exit(this.m_ez);
				}
			}
			if (hc2 == null)
			{
				i(hr2, "Analyzing spectrum...", A_2: true, A_3: true, A_2);
				return;
			}
			if (this.m_ef.s8(this.m_ek))
			{
				f1 obj = this.m_ef;
				string a_ = this.m_ek;
				string A_7 = "";
				string A_8 = "AnalysisCancelledDueToActiveSpecChange";
				if (obj.m2(a_, "", ref A_7, global::hu.a(ref A_8)) != global::ce.ErrPublic.None)
				{
					throw new ApplicationException("Error attempting to abort analysis in ActiveSpectrumChangedByUserHandler");
				}
			}
			i(hc2, A_1: false, A_2: false);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			fz a_2 = this.m_eo;
			string A_7 = "ErrSpectrumAnalysis";
			global::fe.b(a_2, global::hu.a(ref A_7) + ex3.ToString(), "Information", a3());
			ProjectData.ClearProjectError();
		}
	}

	private void ag()
	{
		az();
	}

	public void z(global::r.d A_0)
	{
		if (A_0 != null)
		{
			A_0.d((global::r.d.b)z);
		}
		else
		{
			a4().c(global::fz.b.b, "Error in FIControlPanelMeasModule.AddSpectrumAcquiredHandler(): spectrumAcquiredCompletionTask is Nothing. ");
		}
	}

	public void aa(global::r.d A_0)
	{
		if (A_0 != null)
		{
			A_0.d((global::r.d.b)ab);
		}
		else
		{
			a4().c(global::fz.b.b, "Error in FIControlPanelMeasModule.AddAutoBaselineRefStatusHandler(): autoBaselineRefStatusCompletionTask is Nothing. ");
		}
	}

	private void y(global::r.d.a A_0)
	{
		if (base.InvokeRequired)
		{
			global::r.d.b method = y;
			BeginInvoke(method, A_0);
		}
		else
		{
			if (!base.IsHandleCreated)
			{
				return;
			}
			fp = false;
			this.m_e7.j = true;
			this.m_eq.b();
			if (A_0.a != global::r.d.a.a.b || A_0.a8() != global::r.d.a.b.a)
			{
				return;
			}
			global::r.k.a a10 = (global::r.k.a)A_0;
			global::r.g.a.a a11 = (global::r.g.a.a)a10.ao;
			if (a11 == global::r.g.a.a.a)
			{
				string A_1 = "UnknownErrFmt";
				string format = global::hu.a(ref A_1);
				A_1 = "ContinuousAcquire";
				Interaction.MsgBox(string.Format(format, global::hu.a(ref A_1)), MsgBoxStyle.OkOnly, Application.CompanyName);
			}
			else
			{
				bool flag = false;
				string a_ = global::r.g.a.a6(a11, a10.ap, a10.aq, a10.ar, a10.@as, a10.at, a10.au, a10.av, flag, this.m_ef.ti(this.m_el));
				if (a11 == global::r.g.a.a.q)
				{
					bool flag2;
					if (!global::fe.b(ref this.m_eo, a_, "Warning", "IgnoreStaturationOKString", flag ? "StrStop" : "NewBaseline", global::i6.a(this)))
					{
						flag2 = !flag;
					}
					else
					{
						i(A_0: false, A_1: false, global::h6.b.b);
						flag2 = false;
					}
					if (flag2)
					{
						ak();
					}
				}
				else if (this.m_ef.sm(this.m_el) && a11 == global::r.g.a.a.j)
				{
					ref fz a_2 = ref this.m_eo;
					string A_1 = "USBSpecAcquireSatAtFixedIntTimeWarning";
					string a_3 = global::hu.a(ref A_1);
					Point A_2 = global::i6.a(this);
					global::fe.b(ref a_2, a_3, ref A_2);
					i(A_0: false, A_1: false, global::h6.b.b);
				}
				else if (a11 == global::r.g.a.a.t)
				{
					global::fe.b(this.m_eo, a10.ap, global::i6.a(this));
				}
				else
				{
					global::fe.b(this.m_eo, a_, global::i6.a(this));
				}
			}
			a10 = null;
		}
	}

	private void x(global::r.d.a A_0)
	{
		if (this.m_ef.tc())
		{
			return;
		}
		this.m_hd = false;
		try
		{
			if (base.InvokeRequired)
			{
				global::r.d.b method = x;
				BeginInvoke(method, A_0);
				return;
			}
			if (!base.IsHandleCreated)
			{
				this.m_eo.c(global::fz.b.b, "Attempt to terminate measurements before handle created-Aborted", Environment.StackTrace);
				return;
			}
			bool flag = this.m_fn;
			bool flag2 = fo;
			this.m_fn = false;
			fo = false;
			if (A_0.a != global::r.d.a.a.b || A_0.a8() != global::r.d.a.b.a)
			{
				return;
			}
			global::r.k.a a10 = (global::r.k.a)A_0;
			global::r.g.a.a a11 = (global::r.g.a.a)a10.ao;
			if (a11 == global::r.g.a.a.a)
			{
				string A_1 = "UnknownErrFmt";
				string format = global::hu.a(ref A_1);
				A_1 = "ContinuousMeasure";
				Interaction.MsgBox(string.Format(format, global::hu.a(ref A_1)), MsgBoxStyle.OkOnly, Application.CompanyName);
			}
			else
			{
				bool flag3 = false;
				string a_ = global::r.g.a.a6(a11, a10.ap, a10.aq, a10.ar, a10.@as, a10.at, a10.au, a10.av, flag3, this.m_ef.ti(this.m_el));
				bool flag4 = true;
				bool flag5 = this.m_ef.sm(this.m_el) && a11 == global::r.g.a.a.j;
				bool flag6 = a11 != global::r.g.a.a.q && !flag5;
				if (flag6)
				{
					global::fe.b(this.m_eo, a_, global::i6.a(this));
				}
				else if (flag5)
				{
					ref fz a_2 = ref this.m_eo;
					string A_1 = "USBSpecAcquireSatAtFixedIntTimeWarning";
					string a_3 = global::hu.a(ref A_1);
					Point A_2 = global::i6.a(this);
					global::fe.b(ref a_2, a_3, ref A_2);
				}
				else
				{
					flag4 = global::fe.b(ref this.m_eo, a_, "Warning", "IgnoreStaturationOKString", flag3 ? "StrStop" : "NewBaseline", global::i6.a(this));
				}
				bool flag7 = default(bool);
				if (flag4)
				{
					if (flag2 || flag)
					{
						if (flag6)
						{
							this.m_e6.q(A_0: true);
						}
						else if (flag)
						{
							i(A_0: false, global::r.o.a);
						}
						else
						{
							x(A_0: false);
						}
					}
					else
					{
						string A_3 = "";
						if (this.m_ef.m2(this.m_el, hd(), an(), "Contact Probe Measuring...", ref A_3, null, this.m_e6, global::r.o.a, A_8: false, (float)bb().fy(), (float)bb().fz(), global::r.d.a.b.a, 0, null, A_14: false, A_15: false, A_16: false, 0) != global::ce.ErrPublic.None)
						{
							Interaction.MsgBox("Error executing automatic measurement. " + A_3, MsgBoxStyle.OkOnly, Application.CompanyName);
						}
					}
				}
				else
				{
					flag7 = !flag3;
				}
				if (flag7)
				{
					ak();
				}
			}
			a10 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_4 = ex2;
			this.m_eo.c(global::fz.b.b, "Exception Thrown in MeasurementTerminatedEventHandler(). ", a_4);
			ProjectData.ClearProjectError();
		}
	}

	public void ht()
	{
		string A_ = "";
		if (this.m_ef.wq(this.m_el).d0().c() == global::g2.a.b)
		{
			i(A_0: true, global::r.o.g);
		}
		else if (ho())
		{
			this.m_ef.m2(this.m_el, hd(), an(), "Acquiring Spectrum...", ref A_, gp(), null, global::r.d.a.b.a, 1, null);
			this.m_eq.b();
		}
	}

	public void i(bool A_0, bool A_1, h6.b A_2)
	{
		i(A_0, A_1: false, A_1, A_3: true, A_2);
	}

	public void i(bool A_0, bool A_1, bool A_2, bool A_3, h6.b A_4)
	{
		string A_5 = "";
		try
		{
			this.m_hd = false;
			if (this.m_ef.wq(this.m_el).d0().c() == global::g2.a.b && !A_1)
			{
				i(A_0: true, global::r.o.h);
				return;
			}
			if (fp)
			{
				this.m_e7.q(A_0: true);
			}
			else if (!A_3 || ho())
			{
				string a_ = global::e.a().OperatorID;
				this.m_e7.j = A_0;
				this.m_ef.m2(this.m_el, hd(), a_, "Acquiring Continuously...", ref A_5, null, this.m_e7, global::r.d.a.b.a, 1, null, A_2, A_4);
				fp = true;
			}
			v();
			this.m_eq.b();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			this.m_eo.c(global::fz.b.b, "Exception in StartContinuousAcquire(). ", a_2);
			ProjectData.ClearProjectError();
		}
	}

	public void w(bool A_0)
	{
		if (this.m_ef.p9(this.m_el, this.m_ef.wq(this.m_el)))
		{
			fz a_ = this.m_eo;
			string A_1 = "AdditionalRecipeSpecRangeConflict";
			global::fe.b(a_, global::hu.a(ref A_1), a3());
			return;
		}
		if (this.m_ef.u8(this.m_el) == global::g2.a.b && (this.m_gv || this.m_gw))
		{
			this.m_g1 = new bm();
			this.m_g1.a(this.m_ef, this, this.m_eo, global::i6.a(eb()));
			return;
		}
		if (this.m_fn || fo)
		{
			this.m_e6.q(A_0: true);
			this.m_hd = false;
			this.m_eq.b();
			return;
		}
		this.m_ef.t0(this.m_ek).bu(this.m_eo, a3(), this.m_ef.wq(this.m_el).d0().q());
		if (this.m_ef.u7(this.m_el) && A_0)
		{
			fr = DateTime.Now;
			this.m_hd = false;
			i(A_0: true, global::r.o.a);
		}
		else if (this.m_ef.wq(this.m_el).d0().c() == global::g2.a.b)
		{
			fr = DateTime.Now;
			this.m_hd = false;
			i(A_0: true, global::r.o.d);
		}
		else if (ho())
		{
			this.m_ef.m2(this.m_el, hd(), an(), gm(), null, global::e.a().DisplaySignificantDigits, global::r.d.a.b.a, A_7: true, 1);
			this.m_eq.b();
		}
	}

	public void x(bool A_0)
	{
		this.m_hd = false;
		if (this.m_ef.wq(this.m_el).d0().c() == global::g2.a.b)
		{
			i(A_0: true, global::r.o.e);
			return;
		}
		if (this.m_fn || fo)
		{
			this.m_e6.q(A_0: true);
		}
		else if (ho())
		{
			if (global::e.a().ContMeasPromptUserReAddToHistInclusion && A_0)
			{
				Point a_ = global::i6.a(this, 0, 0);
				MySettings mySettings = global::e.a();
				ref fz a_2 = ref this.m_eo;
				string A_1 = "ContMeasHistoryInclusionPrompt";
				string a_3 = global::hu.a(ref A_1);
				A_1 = "DontAskMeThisAgain";
				bool A_2 = default(bool);
				mySettings.ContMeasAddAllToHist = global::fe.b(ref a_2, a_3, "ContMeasHistoryInclusionTitle", "AllMeasurements", "OnlyLastMeasurement", a_, global::hu.a(ref A_1), ref A_2);
				global::e.a().ContMeasPromptUserReAddToHistInclusion = !A_2;
			}
			string a_4 = global::e.a().OperatorID;
			this.m_e6.j = A_0;
			this.m_ef.t0(this.m_ek).bu(this.m_eo, a3(), this.m_ef.wq(this.m_el).d0().q());
			this.m_ef.m2(this.m_el, hd(), a_4, null, this.m_e6, global::e.a().DisplaySignificantDigits, global::r.d.a.b.a, global::e.a().ContMeasAddAllToHist, 1);
			fo = true;
		}
		v();
		this.m_eq.b();
	}

	private void i(bool A_0, global::r.o A_1)
	{
		string A_2 = "";
		bool a_ = false;
		string a_2 = null;
		bool a_3 = false;
		bool a_4 = false;
		bool a_5 = false;
		global::r.d a_6 = null;
		if (!ho())
		{
			return;
		}
		if (this.m_ef.u8(this.m_el) != global::g2.a.b)
		{
			this.m_fn = true;
		}
		this.m_e6.j = A_0;
		int a_10 = default(int);
		short a_11 = default(short);
		switch (A_1)
		{
		case global::r.o.e:
			if (fo)
			{
				A_1 = global::r.o.f;
				a_ = true;
				fo = false;
				break;
			}
			if (global::e.a().ContMeasPromptUserReAddToHistInclusion && A_0)
			{
				Point a_7 = global::i6.a(this, 0, 0);
				MySettings mySettings = global::e.a();
				ref fz a_8 = ref this.m_eo;
				string A_3 = "ContMeasHistoryInclusionPrompt";
				string a_9 = global::hu.a(ref A_3);
				A_3 = "DontAskMeThisAgain";
				bool A_4 = default(bool);
				mySettings.ContMeasAddAllToHist = global::fe.b(ref a_8, a_9, "ContMeasHistoryInclusionTitle", "AllMeasurements", "OnlyLastMeasurement", a_7, global::hu.a(ref A_3), ref A_4);
				global::e.a().ContMeasPromptUserReAddToHistInclusion = !A_4;
			}
			a_ = global::e.a().ContMeasAddAllToHist;
			fo = true;
			break;
		case global::r.o.h:
			if (fp)
			{
				fp = false;
				A_1 = global::r.o.i;
			}
			else
			{
				fp = true;
			}
			break;
		case global::r.o.j:
		case global::r.o.k:
		{
			MySettings mySettings2 = global::e.a();
			if (mySettings2.LastBatchAcqSaveSetting)
			{
				a_2 = mySettings2.LastBatchAcqSaveFilenamePath;
			}
			a_10 = mySettings2.LastBatchAcqQuantity;
			a_3 = bb().gp();
			a_6 = gr();
			a_11 = mySettings2.DisplaySignificantDigits;
			a_4 = mySettings2.UniformSpectrumDataPointSpacing;
			a_5 = mySettings2.UniformSpectrumDataFinePointSpacing;
			mySettings2 = null;
			break;
		}
		default:
			a_ = A_1 != global::r.o.h && A_1 != global::r.o.g;
			break;
		}
		if (this.m_ef.m2(this.m_el, hd(), an(), "Contact Probe Measuring...", ref A_2, a_6, this.m_e6, A_1, a_, (float)bb().fy(), (float)bb().fz(), global::r.d.a.b.a, a_10, a_2, a_3, a_4, a_5, a_11) != global::ce.ErrPublic.None)
		{
			Interaction.MsgBox("Error executing automatic measurement. " + A_2, MsgBoxStyle.OkOnly, Application.CompanyName);
		}
		v();
		this.m_eq.b();
	}

	public void z(global::r.d.a A_0)
	{
		if (iz == null)
		{
			Interlocked.CompareExchange(ref iz, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(iz, ref lockTaken);
			if (iz.State == 0)
			{
				iz.State = 2;
				iy = null;
			}
			else if (iz.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			iz.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(iz);
			}
		}
		checked
		{
			try
			{
				if (this.m_ef.tc())
				{
					return;
				}
				global::r.h.a a10 = (global::r.h.a)A_0;
				if (((global::r.d.a)a10).a == global::r.d.a.a.a && !a10.x)
				{
					return;
				}
				if (base.InvokeRequired)
				{
					v();
					if (this.m_h6 != null)
					{
						i(a10.w);
					}
					if (iy != null)
					{
						if (!Monitor.TryEnter(RuntimeHelpers.GetObjectValue(this.m_em), 1000))
						{
							return;
						}
						try
						{
							this.m_en++;
							global::i6.a(iy, this);
							bb().er.WaitOne(1000, exitContext: false);
						}
						finally
						{
							this.m_en--;
							Monitor.Exit(RuntimeHelpers.GetObjectValue(this.m_em));
						}
					}
					global::r.d.b method = z;
					iy = BeginInvoke(method, A_0);
				}
				else if (!base.IsHandleCreated)
				{
					a4().c(global::fz.b.b, "Attempt to SpectrometerSpectrumAcquiredEventHandler before handle created-Aborted", Environment.StackTrace);
				}
				else
				{
					if (a10.x)
					{
						i(a10.w, null, false);
					}
					l((hc)null);
					s();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				a4().c(global::fz.b.b, "Exception Thrown", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void o(global::r.c A_0)
	{
		try
		{
			if (!this.m_ef.tc())
			{
				if (base.InvokeRequired)
				{
					Invoke(new global::r.c.a(o), A_0);
				}
				else if (!base.IsHandleCreated)
				{
					a4().c(global::fz.b.b, "Attempt to SpectrometerSpectrumAcquiredLongStepStarting before handle created-Aborted", Environment.StackTrace);
				}
				else if (A_0.aa() == global::r.d.a.b.a)
				{
					this.m_fq = new c1();
					c1 obj = this.m_fq;
					float a_ = A_0.ab();
					string A_1 = "LongStepProgressMessage";
					obj.a(a_, global::hu.a(ref A_1));
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			a4().c(global::fz.b.b, "Exception Thrown", a_2);
			ProjectData.ClearProjectError();
		}
	}

	public void i(en A_0, Guid A_1, bool A_2)
	{
		if ((A_0.b == null || A_1 != this.m_el) && A_0.a != null)
		{
			if (A_0.a == null)
			{
				z(A_0: false);
				return;
			}
			i(A_0.a, null, false);
			l((hc)null);
			s();
		}
		else if (A_0.b != null)
		{
			hc a_ = A_0.b;
			bool A_3 = false;
			i(a_, null, A_1, A_3: false, A_2, ref A_3);
		}
	}

	[SpecialName]
	public void y(bool A_0)
	{
		el().Visible = A_0 && a6();
		ej().Visible = A_0 && a5();
		ek().Visible = A_0 && a7();
		ep().Visible = A_0 && a6();
		this.m_h7 = !A_0;
		i(base.Width, base.Height);
	}

	private void l(global::r.c A_0)
	{
		v();
		this.m_eq.b();
		this.m_g5?.Invoke(this.m_el, A_1: true, A_0, global::ey.z(), this);
	}

	private void k(global::r.c A_0, bool A_1)
	{
		this.m_g5?.Invoke(this.m_el, A_1: true, A_0, global::ey.z(), this);
	}

	private void k(global::r.c A_0)
	{
		v();
		this.m_eq.b();
		this.m_g5?.Invoke(this.m_el, A_1: false, A_0, global::ey.z(), this);
	}

	private void j(global::r.c A_0)
	{
		v();
		this.m_eq.b();
	}

	private void j(global::r.c A_0, bool A_1)
	{
		if (base.InvokeRequired)
		{
			BeginInvoke(new o(j), A_0, A_1);
			return;
		}
		d d10 = this.m_g3;
		d10.f = A_0.ac();
		int num = d10.f;
		int num2 = d10.e;
		if (d10.a == global::f4.c.a)
		{
			d5().Text = string.Format(global::ey.a7(), num.ToString(), num2.ToString());
		}
		else if (d10.a == global::f4.c.b)
		{
			d5().Text = string.Format(global::ey.a4(), num.ToString(), num2.ToString());
		}
		else
		{
			d5().Text = string.Format(global::ey.a2(), num.ToString(), num2.ToString());
		}
		d10 = null;
	}

	private void i(global::r.c A_0)
	{
		v();
		this.m_eq.b();
	}

	private void i(global::r.c A_0, bool A_1)
	{
		lock (g0())
		{
			this.m_gb = A_0.v();
			this.m_gc = A_0.w();
			this.m_gd = A_0.x();
			this.m_ge = A_0.y();
		}
	}

	public void p(global::r.c A_0)
	{
		try
		{
			if (!this.m_ef.tc())
			{
				if (base.InvokeRequired)
				{
					Invoke(new global::r.c.a(p), A_0);
				}
				else if (!base.IsHandleCreated)
				{
					a4().c(global::fz.b.b, "Attempt to SpectrometerSpectrumAcquiredLongStepFinished before handle created-Aborted", Environment.StackTrace);
				}
				else if (A_0.aa() == global::r.d.a.b.a && this.m_fq != null)
				{
					this.m_fq.i();
					this.m_fq.Dispose();
					this.m_fq = null;
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			a4().c(global::fz.b.b, "Exception Thrown", a_);
			ProjectData.ClearProjectError();
		}
	}

	public void ab(global::r.d A_0)
	{
		if (A_0 != null)
		{
			A_0.d((global::r.d.b)aa);
		}
		else
		{
			a4().c(global::fz.b.b, "Error in FIControlPanelMeasModule.AddSpectrumCalculatedHandler(): spectrumCalculatedCompletionTask is Nothing. ");
		}
	}

	private void i(hc A_0, bool A_1)
	{
		bool A_2 = false;
		bool A_3 = false;
		try
		{
			bool flag = this.m_ef.wq(this.m_el).b5() && this.m_ef.sj(A_0.c0());
			if (A_0.ch() == global::cc.j.c == flag)
			{
				if (i(ref A_2, ref A_3) != global::f4.b.a)
				{
					throw new ao("Timeout waiting for lock on collections in SpectrometerSpectrumCalculatedEventHandler");
				}
				hr hr2 = A_0.cn();
				int A_4 = default(int);
				if (!j(hr2.b9(), ref A_4) || A_0.cn() != this.m_e0[A_4] || A_1)
				{
					i(A_0.cn(), null, A_2: true);
				}
				int A_5 = default(int);
				if (i(hr2.b9(), ref A_5) && this.m_ez[A_5].cn().ca() == hr2.ca())
				{
					i(hr2.b9(), hr2.ca(), A_2: false);
				}
				hr2 = null;
				this.m_ez.Add(A_0);
				i(A_0, A_1: true, A_2: false);
			}
		}
		finally
		{
			if (A_2)
			{
				Monitor.Exit(this.m_e0);
			}
			if (A_3)
			{
				Monitor.Exit(this.m_ez);
			}
		}
	}

	public void aa(global::r.d.a A_0)
	{
		Collection<hc> collection = new Collection<hc>();
		if (i1 == null)
		{
			Interlocked.CompareExchange(ref i1, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(i1, ref lockTaken);
			if (i1.State == 0)
			{
				i1.State = 2;
				i0 = null;
			}
			else if (i1.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			i1.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(i1);
			}
		}
		checked
		{
			try
			{
				if (this.m_ef.tc())
				{
					return;
				}
				global::r.i.b b10 = (global::r.i.b)A_0;
				if (b10.ae)
				{
					return;
				}
				int num;
				if (b10.ac == null)
				{
					if (b10.ab == null)
					{
						throw new ApplicationException("MeasResult and CompositeMeasResult are both Nothing in SpectrometerSpectrumCalculatedEventHandler.");
					}
					num = 0;
					collection.Add(b10.ab);
					this.m_e2 = null;
				}
				else
				{
					num = b10.ac.g() - 1;
					collection = b10.ac.h();
					this.m_e2 = b10.ac;
				}
				if (base.InvokeRequired)
				{
					v();
					if (i0 != null)
					{
						if (!Monitor.TryEnter(RuntimeHelpers.GetObjectValue(this.m_em), 1000))
						{
							return;
						}
						try
						{
							this.m_en++;
							global::i6.a(i0, this);
							bb().er.WaitOne(1000, exitContext: false);
						}
						finally
						{
							this.m_en--;
							Monitor.Exit(RuntimeHelpers.GetObjectValue(this.m_em));
						}
					}
					int num2 = num;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						i(collection[num3]);
					}
					global::r.d.b method = aa;
					if (A_0.a8() == global::r.d.a.b.a)
					{
						i0 = BeginInvoke(method, A_0);
					}
					else
					{
						i0 = null;
						Invoke(method, A_0);
					}
					return;
				}
				if (!base.IsHandleCreated)
				{
					a4().c(global::fz.b.b, "Attempt to SpectrometerSpectrumCalculatedEventHandler before handle created-Aborted", Environment.StackTrace);
					return;
				}
				lock (gz())
				{
					bool flag = fv;
					u();
					Guid A_1 = default(Guid);
					ib?.Invoke(DateTime.Now.Subtract(this.m_f6).TotalSeconds, ((global::r.d.a)b10).a != global::r.d.a.a.a || !flag, (!this.m_ef.m2(this.m_el, ref A_1) || !this.m_ef.vx(A_1)) && A_0.a8() == global::r.d.a.b.a);
				}
				s();
				int index = 0;
				if (num > 0)
				{
					int num4 = num;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						if (collection[num5] != null)
						{
							if (bb().e7() != collection[num5].cn().b9())
							{
								i(collection[num5], A_1: false);
							}
							else
							{
								index = num5;
							}
						}
					}
				}
				if (collection[index] != null)
				{
					i(collection[index], A_1: false);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				a4().c(global::fz.b.b, "Exception Caught in FIControlPanelMeasModule.SpectrometerSpectrumCalculatedEventHandler", a_);
				if (A_0.a8() == global::r.d.a.b.a)
				{
					global::fe.b(this.m_eo, "Error in SpectrometerSpectrumCalculatedEventHandler", a3());
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public void ab(global::r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				global::r.d.b method = ab;
				BeginInvoke(method, A_0);
				return;
			}
			float val = 1f;
			global::r.j.a a10 = (global::r.j.a)A_0;
			this.m_gx = checked((int)Math.Round(0.01 * (double)Math.Max(a10.ag, val) * (double)fe().Width));
			this.m_gz = a10.an;
			if (this.m_gx != this.m_gy || this.m_gz != this.m_g0)
			{
				fe().Invalidate();
			}
			this.m_gv = a10.ah;
			this.m_gw = a10.ai;
			if (this.m_g1 != null)
			{
				this.m_g1.a(a10.ak, a10.al, a10.am);
			}
			a10 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.b, "Error in AutoBaselineRefStatusUpdate", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void w(global::r.d.a A_0)
	{
		if (A_0.a != global::r.d.a.a.b || A_0.a8() != global::r.d.a.b.a)
		{
			return;
		}
		if (base.InvokeRequired)
		{
			global::r.d.b method = w;
			BeginInvoke(method, A_0);
			return;
		}
		global::r.g.a a10 = (global::r.g.a)A_0;
		if (a10.j == global::r.g.a.a.a)
		{
			fz a_ = this.m_eo;
			string A_1 = "ErrSingleAcq";
			global::fe.b(a_, global::hu.a(ref A_1), global::i6.a(this));
			return;
		}
		global::r.g.a a11 = a10;
		string a_2 = a11.a6();
		if (a11.j == global::r.g.a.a.q)
		{
			if (false)
			{
				ref fz a_3 = ref this.m_eo;
				Point A_2 = global::i6.a(this);
				global::fe.b(ref a_3, a_2, ref A_2);
			}
			else if (!global::fe.b(ref this.m_eo, a_2, "Warning", "IgnoreStaturationOKString", "NewBaseline", global::i6.a(this)))
			{
				ak();
			}
		}
		else if (this.m_ef.sm(this.m_el) && a11.j == global::r.g.a.a.j)
		{
			ref fz a_4 = ref this.m_eo;
			string A_1 = "USBSpecAcquireSatAtFixedIntTimeWarning";
			string a_5 = global::hu.a(ref A_1);
			Point A_2 = global::i6.a(this);
			global::fe.b(ref a_4, a_5, ref A_2);
		}
		else
		{
			ref fz a_6 = ref this.m_eo;
			Point A_2 = global::i6.a(this);
			global::fe.b(ref a_6, a_2, ref A_2);
		}
		a11 = null;
	}

	private void v(global::r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				global::r.d.b method = v;
				BeginInvoke(method, A_0);
			}
			else
			{
				az();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.b, "Error in mSingleMeasCompletionTask_TaskStartedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void u(global::r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				global::r.d.b method = u;
				BeginInvoke(method, A_0);
				return;
			}
			bool flag = default(bool);
			if (A_0.a == global::r.d.a.a.b && A_0.a8() == global::r.d.a.b.a)
			{
				if (A_0 is global::r.g.a)
				{
					global::r.g.a a10 = (global::r.g.a)A_0;
					if (a10.j == global::r.g.a.a.a)
					{
						if (string.IsNullOrEmpty(((global::r.d.a)a10).b))
						{
							fz a_ = this.m_eo;
							string A_1 = "ErrSingleMeas";
							global::fe.b(a_, global::hu.a(ref A_1), global::i6.a(this));
						}
						else
						{
							global::fe.b(this.m_eo, ((global::r.d.a)a10).b, a3());
						}
					}
					else
					{
						global::r.g.a a11 = a10;
						string a_2 = a11.a6();
						if (a11.j == global::r.g.a.a.q)
						{
							if (false)
							{
								ref fz a_3 = ref this.m_eo;
								Point A_2 = global::i6.a(this);
								global::fe.b(ref a_3, a_2, ref A_2);
								w();
							}
							else if (!global::fe.b(ref this.m_eo, a_2, "Warning", "IgnoreStaturationOKString", "NewBaseline", global::i6.a(this)))
							{
								flag = true;
							}
							else
							{
								w();
							}
						}
						else if (this.m_ef.sm(this.m_el) && a11.j == global::r.g.a.a.j)
						{
							ref fz a_4 = ref this.m_eo;
							string A_1 = "USBSpecAcquireSatAtFixedIntTimeWarning";
							string a_5 = global::hu.a(ref A_1);
							Point A_2 = global::i6.a(this);
							global::fe.b(ref a_4, a_5, ref A_2);
							w();
						}
						else
						{
							global::fe.b(this.m_eo, a_2, a3());
						}
						a11 = null;
					}
				}
				else
				{
					global::fe.b(this.m_eo, A_0.b, a3());
				}
			}
			if (A_0.a != global::r.d.a.a.a)
			{
				this.m_eq.b();
			}
			if (flag)
			{
				ak();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_6 = ex2;
			this.m_eo.c(global::fz.b.b, "Error in mSingleMeasCompletionTask_TaskFinishedEvent", a_6);
			ProjectData.ClearProjectError();
		}
	}

	private void af()
	{
		if (!base.IsHandleCreated)
		{
			a4().c(global::fz.b.b, "Attempt to show error dialog before handle created-Aborted", Environment.StackTrace);
			return;
		}
		fz a_ = this.m_eo;
		string A_ = "ErrReanalyzingSpectrum";
		global::fe.b(a_, global::hu.a(ref A_), global::i6.a(this));
	}

	private void t(global::r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				v();
				global::r.d.b method = t;
				BeginInvoke(method, A_0);
			}
			else
			{
				s();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.b, "Error in mSingleAnalyzeCompletionTask_TaskStartedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void s(global::r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				v();
				BeginInvoke(new global::r.d.b(s), A_0);
				return;
			}
			if (A_0.a != global::r.d.a.a.a)
			{
				bb().g2();
				if (A_0.a8() == global::r.d.a.b.a)
				{
					string a_;
					if (string.IsNullOrEmpty(A_0.b))
					{
						string A_1 = "UnknownErrFmt";
						string format = global::hu.a(ref A_1);
						A_1 = "SpectrumAnalysis";
						a_ = string.Format(format, global::hu.a(ref A_1));
					}
					else
					{
						a_ = A_0.b;
					}
					d9().Visible = false;
					d8().Visible = false;
					d5().Text = null;
					d4().Visible = false;
					global::fe.b(this.m_eo, a_, a3());
				}
				this.m_eq.b();
			}
			s();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			this.m_eo.c(global::fz.b.b, "Error in mSingleAnalyzeCompletionTask_TaskFinishedEvent", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void r(global::r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				v();
				global::r.d.b method = r;
				BeginInvoke(method, A_0);
			}
			else
			{
				s();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.b, "Error in mComputePrecisionCompletionTask_TaskStartedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void q(global::r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				v();
				BeginInvoke(new global::r.d.b(q), A_0);
				return;
			}
			if (A_0.a != global::r.d.a.a.a)
			{
				if (A_0.a8() == global::r.d.a.b.a)
				{
					string left = A_0.b;
					string A_1 = "AnalysisCancelled";
					if (Operators.CompareString(left, global::hu.a(ref A_1), TextCompare: false) != 0)
					{
						global::i5.a(this.m_eo, this.m_ef, this, a3(), "Precision Task Completion", A_0.b);
					}
				}
				this.m_eq.b();
			}
			s();
			long A_2 = default(long);
			this.m_ex.e(ref A_2);
			i(checked((int)A_2));
			al();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.b, "Error in mComputePrecisionCompletionTask_TaskFinishedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void i(hc A_0, bool A_1, bool A_2)
	{
		hc hc2 = A_0;
		if (hc2.ch() == global::cc.j.b)
		{
			bb().g2();
			if (gg().Height > 0)
			{
				gg().g2();
			}
			ba().s(global::ey.aw() + " (" + global::h4.e(this.m_ef.t0(this.m_ek).ca(), false, false) + ")");
			ba().o(global::ey.av(), global::ey.au(), global::hr.af(global::hr.b.f));
			ba().g1();
			if (hc2.cu() != null)
			{
				ba().o(hc2.cu().cz(), hc2.cu().c0(), hc2.cu().c2(), hc2.cn().b9(), hc2.cn().ca(), 0.0, hc2.cn().b5(), global::ey.@as() + " FFT", A_8: true, A_9: false);
			}
			if (hc2.cv() != null)
			{
				ba().o(hc2.cv().cz(), hc2.cv().c0(), hc2.cv().c2(), hc2.cn().b9(), hc2.cn().ca(), hc2.cy().cl(), string.Format(global::ey.at(), hc2.cn().b5()), global::ey.ar() + " FFT", A_8: true, A_9: false);
			}
			if (string.IsNullOrEmpty(A_0.b9))
			{
				ba().gi().a2().am(0.0);
				ba().gm = hc2.cx();
				ba().g7();
				ba().gi().am(0.0);
			}
		}
		else if (hc2.ch() == global::cc.j.a)
		{
			if (hc2.cs() != null)
			{
				fh.b A_3 = default(fh.b);
				hr.b A_4 = default(hr.b);
				global::d7.a(this.m_e0, hc2.cn(), ref A_3, ref A_4);
				global::d7.a(this.m_ef, bb(), A_0, A_3, A_4);
				if (gg().Height > 0)
				{
					global::d7.a(this.m_ef, gg(), A_0, A_3, A_4);
					gg().gb = true;
				}
				bb().gb = true;
			}
		}
		else if (hc2.ch() == global::cc.j.c)
		{
			bb().o(hc2.ci(), hc2.cj());
			bb().o(hc2.ck(), hc2.cl());
			n(hc2.cy());
		}
		global::hg.bu(bd(), hc2.cy(), hc2.cf(), hc2.c0());
		hc2 = null;
		k(A_0);
		l(A_0);
		if (A_1 && this.m_ht && A_0.db())
		{
			this.m_hr.v(A_0, A_1: true, bb().gp(), A_0.c0(), A_0.cn().af());
			if (gg().Height > 0)
			{
				this.m_hr.v(A_0, A_1: true, gg().gp(), A_0.c0(), A_0.cn().af());
			}
			if (!this.m_hr.ay())
			{
				em().Text = Conversions.ToString(Conversions.ToDouble(em().Text) + 1.0);
			}
		}
		if (!A_2)
		{
			this.m_eq.b();
		}
	}

	private void l(hc A_0)
	{
		string A_1 = string.Empty;
		string A_2 = string.Empty;
		string A_3 = null;
		string A_4 = null;
		string A_5 = null;
		eo().Text = string.Empty;
		if (A_0 == null)
		{
			er().Visible = false;
			dc().BackColor = SystemColors.Control;
			db().BackColor = SystemColors.Control;
			c9().BackColor = SystemColors.Control;
			return;
		}
		eo().Visible = i(A_0.cy(), A_0.c0());
		bool A_6 = default(bool);
		Color A_7 = default(Color);
		BorderStyle A_8 = default(BorderStyle);
		Color A_9 = default(Color);
		Color A_10 = default(Color);
		Color A_11 = default(Color);
		eo().Rtf = A_0.cf(A_0: true, global::e.a().DisplaySignificantDigits, Conversions.ToBoolean(global::e.a().GraphMeasYLabelPercent[0]), this.m_e2, ref A_6, ref A_1, ref A_7, ref A_8, ref A_2, ref A_9, ref A_10, ref A_11, ref A_3, ref A_4, ref A_5);
		er().BorderStyle = A_8;
		i(A_1);
		er().Visible = A_6 && this.m_gn.i() == global::bx.a.a;
		er().BackColor = A_7;
		this.m_hg.SetToolTip(er(), A_2);
		dc().BackColor = A_9;
		db().BackColor = A_10;
		c9().BackColor = A_11;
		this.m_hg.SetToolTip(dc(), A_3);
		this.m_hg.SetToolTip(db(), A_4);
		this.m_hg.SetToolTip(c9(), A_5);
		er().Refresh();
		em().Refresh();
		eo().Refresh();
	}

	private void i(string A_0)
	{
		Graphics graphics = CreateGraphics();
		er().Font = new Font("Microsoft Sans Serif", 36f, FontStyle.Bold, GraphicsUnit.Point, 0);
		Font font = er().Font;
		float num = graphics.MeasureString(A_0, font).Width;
		float num2 = er().Font.Size;
		while (num > (float)er().Width)
		{
			num2 -= 2f;
			er().Font = new Font("Microsoft Sans Serif", num2, FontStyle.Bold, GraphicsUnit.Point, 0);
			font = er().Font;
			num = graphics.MeasureString(A_0, font).Width;
		}
		er().Text = A_0;
	}

	private void k(hc A_0)
	{
		cc.f a_ = A_0?.co();
		i(a_, dd(), dc(), db(), c9(), di(), dk(), dh(), c4());
		a_ = ((A_0 == null || A_0.cp() == null) ? null : A_0.cp());
		i(a_, co(), cz(), c3(), c0(), ct(), cv(), cs(), cm());
		ae();
	}

	private void ae()
	{
		bool visible = ad();
		cm().Visible = visible;
		e4().Visible = cm().Visible;
		if (Conversions.ToBoolean(cm().Tag))
		{
			if (!cm().Text.EndsWith(" (Correlation On)"))
			{
				cm().Text += " (Correlation On)";
			}
		}
		else if (cm().Text.EndsWith(" (Correlation On)"))
		{
			cm().Text = cm().Text.Substring(0, checked(cm().Text.Length - " (Correlation On)".Length));
		}
		string text = ((!cm().Visible) ? this.m_h4 : global::ey.ao());
		if (Conversions.ToBoolean(c4().Tag))
		{
			text += " (Correlation On)";
		}
		c4().Text = text;
	}

	private bool ad()
	{
		if (global::e.a().DisplayTransmittanceColorControls && global::e.a().ShowSpectrumColor && !aj())
		{
			if (this.m_e0.Count == 0 && this.m_ef.wh(this.m_el).GetUpperBound(0) > 0)
			{
				return true;
			}
			hc hc2 = a2();
			return hc2 != null && hc2.cp() != null;
		}
		return false;
	}

	private bool ac()
	{
		if (global::e.a().DisplaySpectrumColorControls && global::e.a().ShowSpectrumColor)
		{
			return !aj();
		}
		return false;
	}

	private void i(cc.f A_0, PictureBox A_1, Label A_2, Label A_3, Label A_4, Label A_5, Label A_6, Label A_7, GroupBox A_8)
	{
		cc.d d10 = null;
		cc.d d11 = null;
		if (A_0 == null || A_0.e().Count <= 0)
		{
			A_1.BackColor = BackColor;
			A_2.Text = "";
			A_3.Text = "";
			A_4.Text = "";
			A_5.Text = "";
			A_6.Text = "";
			A_7.Text = "";
			A_8.Tag = false;
			return;
		}
		float num = default(float);
		foreach (cc.d item in A_0.e())
		{
			if (item.h() == (a4.a)global::e.a().ShowSpectrumCoordOption)
			{
				d10 = item;
			}
			if (item.h() == global::a4.a.d && global::e.a().AlwayShowSpectrumCoordXYZ && global::e.a().ShowSpectrumCoordOption != 3)
			{
				d11 = item;
			}
			if (item.h() == global::a4.a.a || item.h() == global::a4.a.c || item.h() == global::a4.a.b)
			{
				num = item.k();
			}
		}
		float[] array = A_0.c();
		if (global::e.a().SpectrumColorFixLuminance)
		{
			float num2 = 0f;
			float num3 = 0f;
			float num4 = array[0];
			float num5 = array[1];
			float num6 = array[2];
			float num7 = (num4 + num5 + num6) / 765f;
			num3 = ((num7 > 0f && num > 10f) ? (global::e.a().SpectrumColorLumValue / (num7 * 100f)) : ((!(num7 > 0f) || !(num > 0f)) ? 1f : (global::e.a().SpectrumColorLumValue * num / (10f * num7 * 100f))));
			if (num4 > num2)
			{
				num2 = num4;
			}
			if (num5 > num2)
			{
				num2 = num5;
			}
			if (num6 > num2)
			{
				num2 = num6;
			}
			if (num2 * num3 > 255f)
			{
				num3 = 255f / num2;
			}
			num4 *= num3;
			num5 *= num3;
			num6 *= num3;
			array[0] = num4;
			array[1] = num5;
			array[2] = num6;
		}
		else
		{
			array[0] = Math.Min(array[0] * 255f, 255f);
			array[1] = Math.Min(array[1] * 255f, 255f);
			array[2] = Math.Min(array[2] * 255f, 255f);
		}
		A_1.BackColor = checked(Color.FromArgb((int)Math.Round(array[0]), (int)Math.Round(array[1]), (int)Math.Round(array[2])));
		if (d10 != null)
		{
			A_2.Text = Strings.Format(d10.k(), "0.####");
			A_3.Text = Strings.Format(d10.l(), "0.####");
			A_4.Text = Strings.Format(d10.m(), "0.####");
		}
		else
		{
			A_2.Text = "";
			A_3.Text = "";
			A_4.Text = "";
		}
		if (d11 != null)
		{
			A_5.Text = Strings.Format(d11.k(), "0.####");
			A_6.Text = Strings.Format(d11.l(), "0.####");
			A_7.Text = Strings.Format(d11.m(), "0.####");
		}
		else
		{
			A_5.Text = "";
			A_6.Text = "";
			A_7.Text = "";
		}
		A_8.Tag = d10.n() || (d11?.n() ?? false);
		A_1.Refresh();
		A_2.Refresh();
		A_3.Refresh();
		A_4.Refresh();
		A_5.Refresh();
		A_6.Refresh();
		A_7.Refresh();
	}

	public void i(f3.a A_0)
	{
		A_0.c(i);
	}

	public void j(f3.a A_0)
	{
		A_0.b(i);
	}

	private void i(int A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				f3.a.a method = i;
				BeginInvoke(method, A_0);
			}
			else if (!base.IsHandleCreated)
			{
				a4().c(global::fz.b.b, "Attempt to UpdateMeasuredSpectraNumber before handle created-Aborted", Environment.StackTrace);
			}
			else
			{
				em().Text = A_0.ToString();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			a4().c(global::fz.b.b, "Exception Thrown in UpdateMeasuredSpectraNumber(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	public void i(gk A_0)
	{
		A_0.c(i);
	}

	public void j(gk A_0)
	{
		A_0.b(i);
	}

	public void i(f3.b A_0)
	{
		if (A_0 != null)
		{
			A_0.d((f3.b.a)i);
			A_0.d(j);
		}
	}

	public void j(f3.b A_0)
	{
		A_0.c((f3.b.a)i);
		A_0.c(j);
	}

	public void i(d1 A_0)
	{
		this.m_et = A_0;
	}

	public void j(d1 A_0)
	{
		this.m_eu = A_0;
	}

	public void k(d1 A_0)
	{
		this.m_ev = A_0;
	}

	public void l(d1 A_0)
	{
		this.m_ew = A_0;
	}

	public void m(d1 A_0)
	{
		this.m_ex = A_0;
	}

	private void i(global::r.d A_0)
	{
		A_0?.d((global::r.d.b)ac);
	}

	public void ac(global::r.d.a A_0)
	{
		if (base.InvokeRequired)
		{
			v();
			global::r.d.b method = ac;
			BeginInvoke(method, A_0);
		}
		else if (base.IsHandleCreated && !this.m_fn && !fo && !fp)
		{
			this.m_eq.b();
		}
	}

	private void i(hg A_0)
	{
		if (A_0.b5() && dm().SelectedTab != dn())
		{
			try
			{
				this.m_e4 = true;
				ap();
				return;
			}
			finally
			{
				this.m_e4 = false;
			}
		}
		if (!A_0.b5() && dm().SelectedTab != dr())
		{
			try
			{
				this.m_e4 = true;
				ao();
			}
			finally
			{
				this.m_e4 = false;
			}
		}
	}

	private void i(hc A_0, cb A_1, Guid A_2, bool A_3, bool A_4, ref bool A_5)
	{
		Collection<hc> collection = new Collection<hc>();
		hc hc2 = null;
		checked
		{
			try
			{
				if (!(this.m_el == A_2))
				{
					return;
				}
				if (base.InvokeRequired)
				{
					gk.a method = i;
					BeginInvoke(method, A_0, A_1, A_2, A_3, A_4);
					return;
				}
				if (!base.IsHandleCreated)
				{
					a4().c(global::fz.b.b, "Attempt to UpdateMeasModWithSelectedMeasurement before handle created-Aborted", Environment.StackTrace);
					return;
				}
				int num;
				if (A_1 == null)
				{
					if (A_0 == null)
					{
						throw new ax("measResult and compositeMeasResult are both passed as Nothing to UpdateMeasModWithSelectedMeasurement");
					}
					num = 0;
					collection.Add(A_0);
					this.m_e2 = null;
				}
				else
				{
					Collection<hg> collection2 = new Collection<hg>();
					int A_6 = default(int);
					if (i(bb().e7(), ref A_6))
					{
						i(bb().e7(), A_6, A_2: true);
					}
					at();
					he A_7 = new he(string.Empty, string.Empty, string.Empty);
					A_1.k().s(ref A_7);
					this.m_e2 = A_1;
					num = A_1.g() - 1;
					collection = A_1.h();
					int num2 = num;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						hg hg2 = collection[num3].cy();
						hg A_8 = new hg(hg2.dh(), hg2.cd());
						hg2 = null;
						collection[num3].cy().bu(ref A_8);
						collection2.Add(A_8);
					}
					A_7.s(collection2);
					he obj = A_7;
					he A_9 = this.m_ef.wr(this.m_el);
					obj.s(ref A_9, A_1: true);
					_ = null;
				}
				int num4 = -1;
				hg hg3 = null;
				int num5 = num;
				int A_10 = default(int);
				bool A_11 = default(bool);
				int A_12 = default(int);
				int A_13 = default(int);
				int A_14 = default(int);
				bool flag = default(bool);
				bool flag2 = default(bool);
				for (int num6 = 0; num6 <= num5; num6++)
				{
					hc2 = collection[num6];
					if (A_4)
					{
						i(hc2.cn(), null, false);
						if (this.m_h6 != null && A_3)
						{
							if (this.m_h6.c[this.m_h6.l()].b[this.m_h6.m()].f(hc2.cn().b9(), ref A_10))
							{
								ia?.Invoke(A_10, this);
							}
							else
							{
								i(hc2.cn());
							}
						}
					}
					else
					{
						if (this.m_h6 != null)
						{
							A_5 = true;
							if (this.m_h6.l(hc2.cn().b9(), ref A_11, ref A_12, ref A_13, ref A_14) && A_11 && A_3)
							{
								hg().g = hg().c[A_12].b[A_13].b[A_14].b;
								global::fe.b(this.m_eo, "The measurement report already contains this result. Existing result is now displayed", global::i6.a(this));
								return;
							}
							global::c6.a();
						}
						bool A_15 = false;
						try
						{
							if (j(ref A_15) == global::f4.b.a)
							{
								if (!this.m_e0.Contains(hc2.cn()))
								{
									hc2.cn().r(this.m_ef.sn(this.m_ek));
								}
							}
							else
							{
								this.m_eo.c(global::fz.b.b, "Error attempting to lock spectrum collection in FIControlPanelMeasModule.UpdateMeasModWithSelectedMeasurement", Environment.StackTrace);
							}
						}
						finally
						{
							if (A_15)
							{
								Monitor.Exit(this.m_e0);
							}
						}
						hg3 = ((A_0 == null) ? this.m_ef.wr(this.m_el).ad()[num6] : this.m_ef.t0(this.m_ek));
						hi hi2 = hc2.cy().b3(hc2.cf());
						if (hi2.cs.Count > 0)
						{
							hi hi3 = hi2.ht();
							if (hi3 != null)
							{
								hc hc3 = new hc();
								hc2.cf((cc)hc3);
								hi A_16 = hc3.cy().b3(hc3.cf());
								hi3.au(ref A_16);
								hc2 = hc3;
								if (A_1 != null)
								{
									A_1.h()[num6] = hc2;
								}
								hc2.cy().bv(global::e.a().OperatorID, DateTime.Now);
								flag = true;
							}
							else
							{
								flag2 = !global::hg.bu(hi2.cr, hg3.ed().cr);
							}
						}
						hg hg4 = ((hc2.cb != null) ? hc2.cb : hc2.cy());
						if (!hc2.cf(hg3) || flag2)
						{
							hg4.bu(ref hg3);
							hg3.bx(hc2.cf());
							if (flag)
							{
								hg3.b5(A_0: false);
							}
							if (!j(collection[0].cn()))
							{
								at();
							}
							i(hg3);
							if (num6 == 0 && A_1 != null)
							{
								hg A_17 = this.m_ef.t0(this.m_ek);
								this.m_ef.wr(this.m_el).ad()[0].bu(ref A_17);
								this.m_ef.wr(this.m_el).ad()[0] = A_17;
								A_17.ca(A_0: true);
								A_17.bv(gq(), A_1: true);
							}
							else
							{
								hg3.bv(gq(), A_1: true);
							}
						}
						if (A_3)
						{
							i(hc2);
						}
						bool flag3 = bb().e8() != hc2.cn().ca();
						if (bb().e7() != hc2.cn().b9() || flag3)
						{
							i(hc2, flag3);
						}
						else
						{
							num4 = num6;
						}
					}
					ex().Text = hc2.cn().b5();
					ev().Text = hc2.cn().b4();
				}
				if (num4 >= 0)
				{
					i(collection[num4], A_1: false);
				}
				if (this.m_e2 != null)
				{
					int A_18 = default(int);
					if (j(bb().e7(), ref A_18) && A_18 < this.m_ef.wr(this.m_el).ad().Count)
					{
						j(this.m_ef.wr(this.m_el).ad()[A_18]);
					}
					this.m_eq.b();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				a4().c(global::fz.b.b, "Exception Thrown in UpdateMeasModWithSelectedMeasurement(). ", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	[SpecialName]
	private bool ab()
	{
		return this.m_g2 > 0;
	}

	private void aa()
	{
		checked
		{
			this.m_g2++;
		}
	}

	private void z()
	{
		checked
		{
			this.m_g2--;
		}
	}

	public void i(hc A_0, ref ek A_1, ref int A_2, ref int A_3, ref int A_4, ref List<ek> A_5)
	{
		if (this.m_h6 == null)
		{
			return;
		}
		if (A_5 != null)
		{
			A_5.Add(this.m_h6);
		}
		if (A_0 == null)
		{
			return;
		}
		foreach (el item in this.m_h6.c)
		{
			foreach (em item2 in item.b)
			{
				foreach (en item3 in item2.b)
				{
					if (item3.b == A_0)
					{
						A_1 = this.m_h6;
						A_2 = this.m_h6.c.IndexOf(item);
						A_3 = item.b.IndexOf(item2);
						A_4 = item2.b.IndexOf(item3);
						return;
					}
				}
			}
		}
	}

	private void j(hc A_0)
	{
		if (this.m_h6 == null)
		{
			return;
		}
		foreach (el item in this.m_h6.c)
		{
			foreach (em item2 in item.b)
			{
				foreach (en item3 in item2.b)
				{
					if (item3.b == A_0)
					{
						item2.b.Remove(item3);
						return;
					}
				}
			}
		}
	}

	private void i(hc A_0)
	{
		if (this.m_h6 != null && A_0 != null)
		{
			this.m_h6.l(A_0);
			em em2 = this.m_h6.c[hg().l()].b[hg().m()];
			int A_1 = default(int);
			if (!em2.f(A_0.cn().b9(), ref A_1) || (em2.b[A_1].b != null && !A_0.cf(em2.b[A_1].b)))
			{
				i(A_0.cn());
				A_1 = checked(em2.b.Count - 1);
			}
			else
			{
				ia?.Invoke(A_1, this);
			}
			if (em2.b[A_1].b == null)
			{
				em2.b[A_1].b = A_0;
				hg().l(global::c5.e(hg()));
			}
		}
	}

	private void k(bool A_0)
	{
		if (base.InvokeRequired)
		{
			f method = k;
			BeginInvoke(method, A_0);
			return;
		}
		eb().Enabled = A_0 && this.m_ef.wv(this.m_el);
		u(A_0);
		if (this.m_ef.v2(this.m_el) && !A_0 && (this.m_fn || fo))
		{
			this.m_e6.q(A_0: true);
		}
	}

	[SpecialName]
	public f hu()
	{
		return this.m_ep;
	}

	[SpecialName]
	public bool hv()
	{
		return this.m_fn;
	}

	[SpecialName]
	public bool hw()
	{
		return fo;
	}

	[SpecialName]
	public bool hx()
	{
		return fp;
	}

	private void aq(object A_0, EventArgs A_1)
	{
		bool flag = false;
		string A_2 = "";
		try
		{
			hg hg2 = this.m_ef.t0(this.m_ek);
			if (!hg2.c9())
			{
				ref fz a_ = ref this.m_eo;
				string A_3 = "RecipeUnsavedPromptFmt3";
				if (!global::fe.b(ref a_, string.Format(global::hu.a(ref A_3), Strings.LCase("Recipe"), "\r\n", Strings.LCase("Recipe")), "RecipeLoadTitle", "OKString", "CancelString", global::i6.a(cj())))
				{
					flag = true;
				}
			}
			if (flag)
			{
				return;
			}
			string text = "";
			string text2 = "";
			if (this.m_ef.wq(this.m_el).b5())
			{
				text = ".fmtpa";
				text2 = "DefaultTemplate";
			}
			else
			{
				text = ".fmtpe";
				text2 = "DefaultTemplate";
			}
			global::e4.a();
			List<string> a_2 = null;
			if (this.m_h5 != null && this.m_h5.k() && this.m_h5.g() && this.m_h5.h() <= global::gq.a.b)
			{
				a_2 = this.m_h5.l();
			}
			fk fk2 = new fk(this.m_eo, global::e4.aa(), global::e4.aa() + this.m_ef.t5(this.m_ek), text, global::fk.a.b, text2, A_6: false, a_2);
			Point a_3 = new Point(dv().Left, checked(dv().Top + dv().Height));
			fk2.a(a_3);
			if (fk2.k())
			{
				return;
			}
			string text3 = fk2.q();
			if (global::e4.a(text3, ref A_2))
			{
				if (hg2.bu(global::hg.bz() + A_2, global::hg.b4(), gq(), global::r.d.a.b.a, A_4: true, A_5: true, global::i6.a(cj()), global::e.a().OperatorID, this.m_ef.w9(this.m_el), !this.m_ef.w6(this.m_el), this.m_eo, this.m_ef.xk(this.m_el), A_12: false, A_13: false, null, A_15: false))
				{
					this.m_ef.m2(this.m_ek, text3.Substring(global::e4.aa().Length));
					return;
				}
				fz a_4 = this.m_eo;
				string A_3 = "RecipeLoadErrFmt2";
				global::fe.b(a_4, string.Format(global::hu.a(ref A_3), Strings.LCase("Recipe"), global::hg.bz() + A_2), "RecipeLoadTitle", global::i6.a(cj()));
			}
			else
			{
				fz a_5 = this.m_eo;
				string A_3 = "RetrieveRecipeDataFromTemplateErrFmt";
				global::fe.b(a_5, string.Format(global::hu.a(ref A_3), A_2), "ErrorTitle", global::i6.a(cj()));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_6 = ex2;
			this.m_eo.c(global::fz.b.b, "Error in FIControlPanelMeasModule ButtonGetTemplate_Click.", a_6);
			string[] array = new string[6];
			string A_3 = "GeneralFunctionErrIn";
			array[0] = global::hu.a(ref A_3);
			array[1] = " FIControlPanelMeasModule ButtonGetTemplate_Click.\r\n";
			A_3 = "GeneralFunctionErrIs";
			array[2] = global::hu.a(ref A_3);
			array[3] = Information.Err().Description;
			array[4] = ", ";
			array[5] = DateAndTime.Now.ToString("General Date");
			string a_7 = string.Concat(array);
			global::fe.b(this.m_eo, a_7, "Information", global::i6.a(cj()));
			ProjectData.ClearProjectError();
		}
	}

	private void ap(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				string A_2 = global::e4.aa() + this.m_ef.t5(this.m_ek);
				string A_3 = "";
				hg A_4 = this.m_ef.t0(this.m_ek);
				this.m_hq = new f7(this.m_eo);
				bool A_5 = default(bool);
				this.m_hq.s(this.m_ef, this, ref A_2, ev().Text, this.m_ef.p9((eo.a)null), this.m_ef.st((eo.a)null), A_4.b5() && this.m_ef.sj((eo.a)null), ref A_5);
				if (!global::e4.a(A_2, ref A_3))
				{
					fz a_ = this.m_eo;
					string A_6 = "RetrieveRecipeDataFromTemplateErrFmt";
					global::fe.b(a_, string.Format(global::hu.a(ref A_6), A_3), "ErrorTitle", global::i6.a(cj()));
					return;
				}
				bool flag;
				if (this.m_hq.a0())
				{
					flag = Operators.CompareString(A_3, A_4.c1().Substring(global::hg.bz().Length), TextCompare: false) != 0;
					if (flag && !A_4.c9() && Operators.CompareString(Path.GetFileNameWithoutExtension(A_4.c1()), "DefaultRecipe", TextCompare: false) != 0 && global::fe.b(ref this.m_eo, "Existing measurement recipe has been modified, but not saved. Changes in the current recipe will be discarded if you do not save them.", "LoadingTemplateString", "SaveString", "DiscardString", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2))))
					{
						A_4.ch(A_4.c1());
					}
				}
				else
				{
					flag = A_5;
					this.m_ef.m2(this.m_ek, A_2.Substring(global::e4.aa().Length));
				}
				if (flag)
				{
					string A_6 = global::hg.bz() + A_3;
					global::hg.bu(ref A_4, ref A_6, global::hg.b4(), A_4.b5() && this.m_ef.sj((eo.a)null), gq(), global::r.d.a.b.a, this.m_eo, A_7: true, global::i6.a(cl()), ev().Text, this.m_ef.w9(this.m_el), !this.m_ef.w6(this.m_el), this.m_ef.xk(this.m_el), A_13: false);
				}
				else
				{
					ck().Text = Path.GetFileNameWithoutExtension(A_2);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				this.m_eo.c(global::fz.b.b, "Error in FIControlPanelMeasModule ButtonEditTemplate_Click.", a_2);
				string[] array = new string[6];
				string A_6 = "GeneralFunctionErrIn";
				array[0] = global::hu.a(ref A_6);
				array[1] = " FIControlPanelMeasModule ButtonEditTemplate_Click.\r\n";
				A_6 = "GeneralFunctionErrIs";
				array[2] = global::hu.a(ref A_6);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString("General Date");
				string a_3 = string.Concat(array);
				global::fe.b(this.m_eo, a_3, "Information", global::i6.a(cl()));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ao(object A_0, EventArgs A_1)
	{
		Point a_ = default(Point);
		int num = 0;
		checked
		{
			try
			{
				this.m_hr = new f8(this.m_eo);
				hg hg2 = this.m_ef.t0(this.m_ek);
				bool flag = hg2.b5() && this.m_ef.sj((eo.a)null);
				if (!flag)
				{
					num = 1;
				}
				int num2;
				int num3;
				if (i2)
				{
					a_.X = this.m_hv[num];
					a_.Y = this.m_hw[num];
					num2 = this.m_hy[num];
					num3 = this.m_hx[num];
				}
				else
				{
					a_.X = (int)Math.Round((double)base.Width * 0.5 - (double)this.m_hr.Width * 0.5);
					a_.Y = (int)Math.Round((double)base.Height * 0.5 - (double)this.m_hr.Height * 0.5);
					num2 = this.m_hr.Height;
					num3 = this.m_hr.Width;
					this.m_hv[0] = a_.X;
					this.m_hw[0] = a_.Y;
					this.m_hy[0] = num2;
					this.m_hx[0] = num3;
					this.m_hv[1] = a_.X;
					this.m_hw[1] = a_.Y;
					this.m_hy[1] = num2;
					this.m_hx[1] = num3;
					i2 = true;
				}
				hi hi2 = hg2.ed();
				string a_2 = global::e4.aa() + this.m_ef.t5(this.m_ek);
				if (this.m_hr.v(a_2, hg2.ci(), hg2.b5(0), hg2.ed().g5(), a_, num3, num2, flag, hi2.e3(), hi2.e9(), bb().gp()))
				{
					this.m_hs = j;
					this.m_hr.v(this.m_hs);
					if (ho())
					{
						this.m_ht = true;
						if (Operators.CompareString(eb().Text, global::ey.a0(), TextCompare: false) == 0)
						{
							aw(RuntimeHelpers.GetObjectValue(A_0), A_1);
						}
					}
					this.m_hr.Invalidate();
					this.m_hr.Update();
				}
				if (!this.m_hr.v(a_2, hg2.ci(), hg2.b5(0), hg2.ed().g5(), a_, num3, num2, flag, hi2.e3(), hi2.e9(), gg().gp()))
				{
					return;
				}
				this.m_hs = j;
				this.m_hr.v(this.m_hs);
				if (ho())
				{
					this.m_ht = true;
					if (Operators.CompareString(eb().Text, global::ey.a0(), TextCompare: false) == 0)
					{
						aw(RuntimeHelpers.GetObjectValue(A_0), A_1);
					}
				}
				this.m_hr.Invalidate();
				this.m_hr.Update();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				this.m_eo.c(global::fz.b.b, "Error in FIControlPanelMeasModule ButtonMeasureToTemplate_Click.", a_3);
				string[] array = new string[6];
				string A_2 = "GeneralFunctionErrIn";
				array[0] = global::hu.a(ref A_2);
				array[1] = " FIControlPanelMeasModule ButtonMeasureToTemplate_Click.\r\n";
				A_2 = "GeneralFunctionErrIs";
				array[2] = global::hu.a(ref A_2);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString("General Date");
				string a_4 = string.Concat(array);
				global::fe.b(this.m_eo, a_4, "Information", global::i6.a(ci()));
				ProjectData.ClearProjectError();
			}
		}
	}

	private bool i(hr.b A_0, hr.b A_1)
	{
		switch (A_0)
		{
		case global::hr.b.c:
		case global::hr.b.j:
			return A_1 == global::hr.b.c || A_1 == global::hr.b.j;
		case global::hr.b.b:
		case global::hr.b.k:
			return A_1 == global::hr.b.b || A_1 == global::hr.b.k;
		default:
			return A_0 == A_1;
		}
	}

	private bool j(hr A_0)
	{
		Collection<hr> collection = this.m_e0;
		if (collection.Count > 0)
		{
			hr hr2 = collection[0];
			return i(hr2.cj(), A_0.cj());
		}
		collection = null;
		return true;
	}

	public void hy()
	{
		if (this.m_f3)
		{
			this.m_f3 = false;
			if (this.m_ef.uh(this.m_el))
			{
				r();
			}
		}
	}

	public void hz()
	{
		if (!this.m_f3)
		{
			lock (g2())
			{
				this.m_f3 = true;
				g2().Stop();
			}
			o();
		}
	}

	public void k(ref bool A_0)
	{
		A_0 = false;
		if (this.m_ef.t6(this.m_ek) != null)
		{
			if (fo)
			{
				this.m_e6.q(A_0: true);
				A_0 = true;
			}
			else if (this.m_ef.tb(this.m_ek))
			{
				au(null, null);
				A_0 = true;
			}
			if (bs().SelectedTab == bt())
			{
				bs().SelectedTab = bu();
				A_0 = true;
			}
		}
	}

	public void j(int A_0)
	{
		this.m_hd = false;
		if (this.m_ef.wq(this.m_el).d0().c() == global::g2.a.b)
		{
			i(A_0: true, global::r.o.k);
			return;
		}
		string a_ = null;
		MySettings mySettings = global::e.a();
		if (mySettings.LastBatchAcqSaveSetting)
		{
			a_ = mySettings.LastBatchAcqSaveFilenamePath;
		}
		this.m_ef.m2(this.m_el, hd(), mySettings.OperatorID, gr(), 1, mySettings.LastBatchAcqQuantity, a_, bb().gp(), global::e.a().UniformSpectrumDataPointSpacing, global::e.a().UniformSpectrumDataFinePointSpacing, A_0, this.m_e7, global::r.d.a.b.a);
		mySettings = null;
	}

	public void k(int A_0)
	{
		fr = DateTime.Now;
		this.m_hd = false;
		if (this.m_ef.wq(this.m_el).d0().c() == global::g2.a.b)
		{
			i(A_0: true, global::r.o.j);
			return;
		}
		string a_ = null;
		MySettings mySettings = global::e.a();
		if (mySettings.LastBatchAcqSaveSetting)
		{
			a_ = mySettings.LastBatchAcqSaveFilenamePath;
		}
		this.m_ef.m2(this.m_el, hd(), mySettings.OperatorID, gr(), 1, mySettings.LastBatchAcqQuantity, a_, bb().gp(), global::e.a().UniformSpectrumDataPointSpacing, global::e.a().UniformSpectrumDataFinePointSpacing, mySettings.DisplaySignificantDigits, A_0, this.m_e7, global::r.d.a.b.a);
		mySettings = null;
	}

	public void i(string[] A_0)
	{
		MySettings mySettings = global::e.a();
		this.m_ef.m2(this.m_el, A_0, gr(), mySettings.DisplaySignificantDigits, mySettings.OperatorID, global::r.d.a.b.a);
		mySettings = null;
	}

	public void j(string A_0, long A_1, global::r.d.a.b A_2)
	{
		i(A_0, A_1, A_2, string.Empty, null, null, null, null);
	}

	public void i(string A_0, string A_1, long A_2, global::r.d.a.b A_3)
	{
		i(A_0, A_2, A_3, string.Empty, null, null, null, A_1);
	}

	public void i(string A_0, long A_1, global::r.d.a.b A_2, string A_3, List<string> A_4, List<string> A_5, string A_6, string A_7)
	{
		bool flag = false;
		hr hr2 = this.m_ef.m2(A_0, ev().Text, A_7);
		if (!string.IsNullOrEmpty(A_3))
		{
			hr2.r(this.m_ef.m2(A_3, ev().Text, A_7));
			flag = true;
		}
		checked
		{
			if (A_4 != null)
			{
				hr2.cx();
				int num = A_4.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					hr hr3 = this.m_ef.m2(A_4[num2], ev().Text, A_7);
					if (!string.IsNullOrEmpty(A_5[num2]))
					{
						hr3.r(this.m_ef.m2(A_5[num2], ev().Text, A_7));
					}
					hr2.r((fy)hr3);
				}
				flag = true;
			}
			if (flag)
			{
				hr2.ak(hr2.b5().Substring(0, hr2.b5().LastIndexOf(A_6)));
				if (hr2.bl() != null)
				{
					hr2.bl().ak(hr2.b5());
				}
				if (hr2.bm() != null)
				{
					foreach (hr item in hr2.bm())
					{
						item.ak(hr2.b5());
					}
				}
			}
			if (this.m_ef.u2())
			{
				if (!this.m_ef.u3())
				{
					if (!hr2.aq())
					{
						SystemSounds.Exclamation.Play();
						global::fe.b(this.m_eo, "Unlicensed Spectrum file. Only Demo files may be opened.", "ErrorTitle", a3());
						return;
					}
				}
				else if (!this.m_ef.u4() && Operators.CompareString(hr2.cn(), "Unknown", TextCompare: false) == 0)
				{
					SystemSounds.Exclamation.Play();
					global::fe.b(this.m_eo, "Unlicensed Spectrum file. \r\nOnly files containing data acquired using FILMeasure may be opened.", "ErrorTitle", a3());
					return;
				}
			}
			bool flag2 = default(bool);
			if (!j(hr2))
			{
				ref fz a_ = ref this.m_eo;
				string A_8 = "GraphDataTypeChangePrompt";
				if (global::fe.b(ref a_, string.Format(global::hu.a(ref A_8), '\r'.ToString()), "Information", "Yes", "No", a3()))
				{
					flag2 = true;
				}
			}
			else
			{
				flag2 = true;
			}
			hr2.r(A_1);
			if (flag2)
			{
				i(hr2, "Measuring loaded spectrum...", A_2: false, A_3: false, A_2);
			}
		}
	}

	public void i(long A_0)
	{
		i(A_0, A_1: false);
	}

	public void h0()
	{
		i(0L, A_1: true);
	}

	private void i(long A_0, bool A_1)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		bool flag = this.m_ef.t0(this.m_ek).dh().a8();
		if (this.m_ef.u2())
		{
			f1 f10 = this.m_ef;
			openFileDialog.Filter = global::hr.t(f10.u3(), f10.u4(), flag);
			f10 = null;
		}
		else
		{
			openFileDialog.Filter = global::hr.af(flag || this.m_ef.uq());
		}
		openFileDialog.FilterIndex = global::e.a().LastUsedOpenSpectrumFilter;
		openFileDialog.Multiselect = A_1;
		openFileDialog.InitialDirectory = global::i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
		if (openFileDialog.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		string text = string.Empty;
		bool flag2 = false;
		List<string> list = null;
		List<string> list2 = null;
		global::e.a().LastUsedOpenSpectrumFilter = openFileDialog.FilterIndex;
		global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(openFileDialog.FileName);
		fz a_ = this.m_eo;
		int a_2 = openFileDialog.FileNames.Length;
		string A_2 = "SpectrumSingularString";
		string a_3 = global::hu.a(ref A_2);
		A_2 = "SpectrumPluralString";
		global::d7.a(a_, a_2, a_3, global::hu.a(ref A_2), a3());
		string[] fileNames = openFileDialog.FileNames;
		checked
		{
			bool flag4 = default(bool);
			foreach (string text2 in fileNames)
			{
				string text3 = Path.GetExtension(text2).ToLower();
				string text4 = null;
				if (A_1)
				{
					A_0 = this.m_ef.sn(this.m_ek);
				}
				if (global::hr.aj(text2))
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text2);
					string text5 = Path.GetDirectoryName(text2) + "\\";
					string text6 = null;
					if (fileNameWithoutExtension.EndsWith("-R"))
					{
						text6 = fileNameWithoutExtension.Substring(0, fileNameWithoutExtension.Length - "-R".Length);
					}
					else if (fileNameWithoutExtension.EndsWith("-T"))
					{
						text6 = fileNameWithoutExtension.Substring(0, fileNameWithoutExtension.Length - "-T".Length);
					}
					else if (fileNameWithoutExtension.EndsWith("-R1"))
					{
						text6 = fileNameWithoutExtension.Substring(0, fileNameWithoutExtension.Length - "-R1".Length);
					}
					if (!string.IsNullOrEmpty(text6))
					{
						bool flag3 = false;
						list = new List<string>();
						list2 = new List<string>();
						if (File.Exists(text5 + text6 + "-R" + text3))
						{
							text4 = text5 + text6 + "-R" + text3;
						}
						else if (File.Exists(text5 + text6 + "-R1" + text3))
						{
							text4 = text5 + text6 + "-R1" + text3;
							flag4 = true;
						}
						if (string.IsNullOrEmpty(text4))
						{
							text4 = text2;
						}
						else
						{
							text = text5 + text6 + "-T" + text3;
							if (File.Exists(text))
							{
								flag2 = true;
							}
							else
							{
								text = string.Empty;
							}
							if (!flag4)
							{
								int num2 = 1;
								do
								{
									string text7 = text5 + text6 + "-R" + num2.ToString().Trim() + text3;
									if (File.Exists(text7))
									{
										flag2 = true;
										list.Add(text7);
										string text8 = text5 + text6 + "-T" + num2.ToString().Trim() + text3;
										if (File.Exists(text8))
										{
											list2.Add(text8);
										}
										else
										{
											list2.Add(string.Empty);
										}
									}
									else
									{
										flag3 = true;
									}
									num2++;
								}
								while (!flag3);
							}
						}
					}
					else
					{
						text4 = text2;
					}
				}
				else
				{
					text4 = text2;
				}
				if (flag2)
				{
					ref fz a_4 = ref this.m_eo;
					A_2 = "OpenAdditionalSpectrumData";
					if (!global::fe.b(ref a_4, string.Format(global::hu.a(ref A_2), '\r'.ToString()), "UserQuery", "Yes", "No", a3()))
					{
						text = string.Empty;
						list = null;
						list2 = null;
						text4 = text2;
					}
				}
				i(text4, A_0, global::r.d.a.b.a, text, list, list2, "-", null);
			}
		}
	}

	private void j(ref hr A_0)
	{
		bool A_1 = default(bool);
		if (this.m_h6 != null && this.m_h6.l(A_0.b9(), ref A_1) && A_1)
		{
			A_0 = A_0.cw();
			A_0.r(this.m_ef.sn(this.m_ek));
		}
	}

	private void i(Collection<hr> A_0, string A_1, bool A_2, bool A_3, global::r.d.a.b A_4)
	{
		Collection<hr> collection = new Collection<hr>();
		string A_5 = "";
		he he2 = this.m_ef.wr(this.m_el);
		checked
		{
			int num = he2.ab() - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				hr hr2 = A_0[num2];
				hr A_6;
				if (global::hg.bu(hr2, he2.ad()[num2], this.m_ef.sm(this.m_el), this.m_ef.sn(this.m_el), A_4: false))
				{
					A_6 = this.m_ef.m2(this.m_ek, hr2, num2, !A_3, A_4, A_5: false);
					if (this.m_h6 != null)
					{
						j(ref A_6);
						i(A_6);
					}
					i(A_6, null, A_2);
					A_3 = true;
				}
				else
				{
					A_6 = hr2;
					j(ref A_6);
				}
				collection.Add(A_6);
			}
			@as();
			if (this.m_ef.m2(this.m_ek, A_1, ref A_5, gn(), null, collection, global::e.a().DisplaySignificantDigits, A_4, A_8: true, A_9: false) != global::ce.ErrPublic.None)
			{
				throw new ao("Failure to lock required object when calling AnalyzeMultipleSpectra");
			}
		}
	}

	private void i(hr A_0, string A_1, bool A_2, bool A_3, global::r.d.a.b A_4)
	{
		string A_5 = "";
		hr A_6;
		if (global::hg.bu(A_0, this.m_ef.t0(this.m_ek), this.m_ef.sm(this.m_el), this.m_ef.sn(this.m_el), A_4: false))
		{
			A_6 = this.m_ef.m2(this.m_ek, A_0, 0, !A_3, A_4, A_5: false);
			if (this.m_h6 != null)
			{
				j(ref A_6);
				i(A_6);
			}
			i(A_6, null, A_2);
			A_3 = true;
		}
		else
		{
			A_6 = A_0;
			j(ref A_6);
		}
		this.m_ef.t0(this.m_ek).bu(this.m_eo, a3(), aj());
		i(A_6, A_1, this.m_ek, ref A_5, !A_3, A_4);
	}

	private void i(hr A_0, string A_1, string A_2, ref string A_3, bool A_4, global::r.d.a.b A_5)
	{
		if (A_4)
		{
			i(A_0, null, false);
		}
		@as();
		if (this.m_ef.ws(this.m_el))
		{
			this.m_eq.b();
			return;
		}
		this.m_f6 = DateTime.Now;
		if (this.m_ef.m2(A_2, A_1, ref A_3, gn(), null, A_0, global::e.a().DisplaySignificantDigits, A_5, A_8: true, A_9: false) == global::ce.ErrPublic.None)
		{
			return;
		}
		throw new ao("Failure to lock required object when calling AnalyzeSpectrumData");
	}

	public void i(long A_0, long A_1)
	{
		hc hc2 = null;
		string A_2 = "";
		string A_3 = "";
		eo eo2 = this.m_ef.t0(this.m_ek).dh();
		bool flag = eo2.a8();
		bool A_4 = default(bool);
		try
		{
			if (i(ref A_4) != global::f4.b.a)
			{
				throw new ao("Timeout waiting for lock on measResults collection in SaveNandKtoFile");
			}
			int A_5 = default(int);
			if (i(A_0, ref A_5))
			{
				hc2 = this.m_ez[A_5];
			}
		}
		finally
		{
			if (A_4)
			{
				Monitor.Exit(this.m_ez);
			}
		}
		if (hc2 == null)
		{
			return;
		}
		bool A_6 = default(bool);
		int num = new cy().a(flag, hc2, ref A_6, ref A_2, ref A_3);
		_ = null;
		if (A_6)
		{
			return;
		}
		string a_ = ((num == checked(hc2.cy().b3(hc2.cf()).g7() + 1)) ? "Substrate" : ((num != 0) ? ("Layer " + num) : "Medium"));
		ch ch2 = hc2.cz(num);
		ga obj = hc2.c1(num);
		ch ch3;
		if (ch2 == null)
		{
			ch3 = hc2.cy(num);
		}
		else
		{
			ch3 = hc2.cz(num);
			ch3.r(A_2);
			ch3.t(A_3);
		}
		ga ga2 = ((obj != null) ? hc2.c1(num) : hc2.c0(num));
		bool flag2 = jf.a(ga2.c0(), ga2.c2());
		bool a_2 = !ch3.bk() && (!ga2.bk() || !flag2);
		bool a_3;
		LicenseLevel A_7 = default(LicenseLevel);
		if (eo2.bl())
		{
			a_3 = global::d9.a(this.m_eo, eo2.bb(), global::i6.a(this), ref A_7);
		}
		else
		{
			a_3 = false;
			A_7 = LicenseLevel.Unlicensed;
		}
		eb.a A_9 = default(eb.a);
		bool A_10 = default(bool);
		bool A_11 = default(bool);
		string A_8 = jb.a(this.m_eo, this.m_ef, this, a_3, A_7, ch3.bk(), ga2.bk(), flag, a_2, flag2, a_, global::eb.b.a, null, eo2.bh(), A_14: false, global::i6.a(this), ref A_9, ref A_10, ref A_11);
		if (string.IsNullOrEmpty(A_8))
		{
			return;
		}
		jb.a(A_8, global::eb.b.a);
		if (jb.p(A_8) && (!jb.q(A_8) || flag))
		{
			ch3.r(ref A_8, "Wavelength (nm)", "n", ga2.c0());
			return;
		}
		if (jb.p(A_8) && !ch3.bk() && (!ga2.bk() || !flag2))
		{
			ch3.r(ref A_8, "Wavelength (nm)", "n", ga2.c0());
			return;
		}
		if ((jb.q(A_8) && flag) || ch3.bk())
		{
			ch ch4 = ch3;
			double[] array = new double[1];
			short[] array2 = new short[1];
			if (ch4.aq() > 0)
			{
				array = ch4.r();
				array2 = ch4.t();
			}
			string A_12 = Path.ChangeExtension(A_8, ".fmnnn");
			global::f6.SolveNProb(ref A_12, -1, (int)ch4.bl(), (int)ch4.af(), ref ch4.cz()[0], ref ch4.c0()[0], ch4.c2(), ref array[0], ref array2[0], ch4.aq());
			ch4 = null;
		}
		else
		{
			ch obj2 = ch3;
			string A_12 = Path.ChangeExtension(A_8, ".nnn");
			obj2.k(ref A_12, "Wavelength (nm)", "n");
		}
		if ((jb.q(A_8) && flag) || ga2.bk())
		{
			ga ga3 = ga2;
			string A_12 = Path.ChangeExtension(A_8, ".fmkkk");
			global::f6.SolveKProb(ref A_12, -1, ref ga3.cz()[0], ref ga3.c0()[0], ga3.c2());
			ga3 = null;
		}
		else
		{
			string A_12 = Path.ChangeExtension(A_8, ".kkk");
			ga2.k(ref A_12, "Wavelength (nm)", "k");
		}
	}

	private hr i(ref hr A_0)
	{
		A_0 = h1();
		return A_0;
	}

	[SpecialName]
	public hr h1()
	{
		bool A_ = false;
		try
		{
			if (j(ref A_) != global::f4.b.a)
			{
				throw new ao("Timeout waiting for lock on spectrum collection in SaveSpectrumHandler");
			}
			int A_2 = default(int);
			if (j(bb().e7(), ref A_2))
			{
				return this.m_e0[A_2];
			}
			return null;
		}
		finally
		{
			if (A_)
			{
				Monitor.Exit(this.m_e0);
			}
		}
	}

	[SpecialName]
	public eo.a h2()
	{
		return null;
	}

	public void j(fu A_0, long A_1, long A_2)
	{
		try
		{
			k(A_0, A_1, A_2);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_eo, this.m_ef, this, global::i6.a(this), "FIControlPanelMeasModule.SaveSpectrumHandler", a_);
			ProjectData.ClearProjectError();
		}
	}

	public void k(fu A_0, long A_1, long A_2)
	{
		new SaveFileDialog();
		bool A_3 = false;
		hr hr2 = null;
		_ = string.Empty;
		try
		{
			if (j(ref A_3) != global::f4.b.a)
			{
				throw new ao("Timeout waiting for lock on spectrum collection in SaveSpectrumHandler");
			}
			int A_4 = default(int);
			if (j(A_1, ref A_4))
			{
				hr2 = this.m_e0[A_4];
			}
		}
		finally
		{
			if (A_3)
			{
				Monitor.Exit(this.m_e0);
			}
		}
		if (hr2 != null)
		{
			string A_5 = null;
			global::d7.a(hr2, this.m_ef, this, global::i6.a(this), bb().gp(), this.m_eo, ref A_5);
			if (A_5 != null)
			{
				i((object)null, Path.GetFileNameWithoutExtension(A_5), hr2.b9(), global::r.d.a.b.a);
			}
		}
	}

	public void l(fu A_0, long A_1, long A_2)
	{
		bool A_3 = default(bool);
		hc hc2;
		try
		{
			if (i(ref A_3) != global::f4.b.a)
			{
				throw new ao("Timeout waiting for lock on measResults collection in SaveFFTHandler");
			}
			int A_4 = default(int);
			if (!i(A_1, ref A_4))
			{
				throw new aq("Attempt to save FFT curve, but measResult doesn't exist.");
			}
			hc2 = this.m_ez[A_4];
		}
		finally
		{
			if (A_3)
			{
				Monitor.Exit(this.m_ez);
			}
		}
		fy fy2 = hc2.cu();
		if (fy2 == null)
		{
			return;
		}
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		b2 b10 = new b2();
		b10.a("CSV File (*.csv)", "*.csv", 1);
		b10.a("Text File (*.txt)", "*.txt", 2);
		if (global::i3.f(hc2.cn().b5()))
		{
			saveFileDialog.FileName = hc2.cn().b5();
		}
		else
		{
			saveFileDialog.FileName = "FFT Curve";
		}
		saveFileDialog.Filter = b10.b();
		saveFileDialog.InitialDirectory = global::i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
		if (saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(saveFileDialog.FileName);
			string A_5 = b10.a(saveFileDialog.FileName, saveFileDialog.FilterIndex);
			fy fy3 = fy2;
			try
			{
				fy3.r(ref A_5, "Thickness (" + hc2.cy().ca().l() + ")", "FFT Intensity", string.Empty, null, null, A_6: false, A_7: false, A_8: false);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				this.m_eo.c(global::fz.b.b, "Error in FIControlPanelMeasModule.SaveSpectrumHandler", ex3);
				global::fe.b(this.m_eo, "Error saving spectrum. Failed to write file. Error is " + ex3.Message, "Information", a3());
				ProjectData.ClearProjectError();
			}
			fy3 = null;
		}
	}

	private void i(object A_0, CancelEventArgs A_1)
	{
		try
		{
			SaveFileDialog obj = (SaveFileDialog)A_0;
			string fileName = obj.FileName;
			hr hr2 = (hr)obj.Tag;
			string path = hr2.ay(fileName);
			string text = global::hr.ah(fileName);
			string text2 = global::hr.ag(fileName);
			string text3 = global::hr.af(fileName);
			string text4 = global::hr.t(fileName);
			Collection<string> collection = new Collection<string>();
			if (File.Exists(path))
			{
				collection.Add(Path.GetFileName(path));
			}
			if (hr2.c3() != null && !string.IsNullOrEmpty(text) && File.Exists(text))
			{
				collection.Add(Path.GetFileName(text));
			}
			if (hr2.c4() != null && hr2.c4().Count > 0 && !string.IsNullOrEmpty(text4) && File.Exists(text4))
			{
				collection.Add(Path.GetFileName(text4));
			}
			if (hr2.c3() != null && !string.IsNullOrEmpty(text2) && File.Exists(text2))
			{
				collection.Add(Path.GetFileName(text2));
			}
			if (hr2.c3() != null && !string.IsNullOrEmpty(text3) && File.Exists(text3))
			{
				collection.Add(Path.GetFileName(text3));
			}
			if (collection.Count > 0)
			{
				A_1.Cancel = !global::i5.a(this.m_eo, collection, A_2: false, global::i6.a(this));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_eo, this.m_ef, this, global::i6.a(ej()), "FIControlPanelMeasModule.VerifySpectrumWithSecondaryOrAdditionalDataSaveOverwriteOK", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void y()
	{
		try
		{
			if (base.InvokeRequired)
			{
				q method = y;
				BeginInvoke(method);
			}
			else
			{
				if (!base.IsHandleCreated)
				{
					return;
				}
				hg hg2 = this.m_ef.t0(this.m_ek);
				hg hg3 = hg2;
				if (!jf.e(bb().gi().a2().ap(), hg3.cj()) || !jf.e(bb().gi().a2().aq(), hg3.ck()))
				{
					hg3.bu(bb().gi().a2().ap());
					hg3.bv(bb().gi().a2().aq());
					if (hg3.cb())
					{
						bool a_ = hg2.c9();
						hg2.bu(gq());
						if (hg3.b5() || aj())
						{
							hg2.b5(a_);
						}
					}
				}
				hg3 = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			this.m_eo.c(global::fz.b.b, "Error updating result box. Error is: ", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void i(fu A_0, long A_1, long A_2)
	{
		checked
		{
			try
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				bool A_3 = false;
				hr hr2 = null;
				if (!this.m_ef.t0(this.m_ek).dh().bh())
				{
					SystemSounds.Exclamation.Play();
					fz a_ = this.m_eo;
					string A_4 = "ErrorMessageDemoNoSaveSpectra";
					global::fe.b(a_, global::hu.a(ref A_4), "ErrorTitle", a3());
					return;
				}
				try
				{
					if (i(ref A_3) != global::f4.b.a)
					{
						throw new ao("Timeout waiting for lock on measResults collection in SaveCalcSpectrumHandler");
					}
					int A_5 = default(int);
					if (!i(A_1, ref A_5))
					{
						throw new ap("Attempt to save calculated spectrum, but it doesn't exist in SaveCalcSpectrumHandler");
					}
					hc hc2 = this.m_ez[A_5];
					hr2 = hc2.cn().cw();
					hr2.ak(A_0: true);
					hr2.t(hc2.cs().cz());
					hr2.r(hc2.cs().c0());
					hr2.af(hc2.cs().c0());
					if (hc2.cs().c3() != null)
					{
						hr2.c3().t(hc2.cs().c3().cz());
						hr2.bl().r(hc2.cs().c3().c0());
						hr2.c3().af(hc2.cs().c3().c0());
					}
					else
					{
						hr2.t((fy)null);
					}
					if (hc2.cs().c4() == null || hc2.cs().c4().Count == 0)
					{
						hr2.cx();
					}
					else
					{
						int num = hc2.cs().c4().Count - 1;
						for (int num2 = 0; num2 <= num; num2++)
						{
							fy fy2 = hc2.cs().c4()[num2];
							hr hr3 = (hr)hr2.c4()[num2];
							hr3.ak(A_0: true);
							hr3.t(fy2.cz());
							hr3.r(fy2.c0());
							hr3.af(fy2.c0());
							if (fy2.c3() != null)
							{
								hr3.c3().t(fy2.c3().cz());
								hr3.c3().af(fy2.c3().c0());
							}
							else
							{
								hr3.t((fy)null);
							}
						}
					}
					hc2 = null;
				}
				finally
				{
					if (A_3)
					{
						Monitor.Exit(this.m_ez);
					}
				}
				if (global::i3.f(hr2.b5() + "-Calculated"))
				{
					saveFileDialog.FileName = hr2.b5() + "-Calculated";
				}
				else
				{
					saveFileDialog.FileName = "Calculated Spectrum";
				}
				b2 b10 = hr2.bu();
				saveFileDialog.Filter = b10.b();
				if (string.IsNullOrEmpty(global::e.a().LastOpenSaveExportTargetImportSourcePath))
				{
					saveFileDialog.InitialDirectory = global::i3.b();
				}
				else
				{
					saveFileDialog.InitialDirectory = global::e.a().LastOpenSaveExportTargetImportSourcePath;
				}
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(saveFileDialog.FileName);
					string A_6 = b10.a(saveFileDialog.FileName, saveFileDialog.FilterIndex);
					hr hr4 = hr2;
					try
					{
						string A_7 = string.Empty;
						Collection<string> A_8 = null;
						Collection<string> A_9 = null;
						hr4.r(ref A_7, ref A_8, ref A_9);
						hr4.r(ref A_6, hr4.bz(), hr4.by(), A_7, A_8, A_9, bb().gp(), global::e.a().UniformSpectrumDataPointSpacing, global::e.a().UniformSpectrumDataFinePointSpacing);
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2);
						Exception ex3 = ex2;
						global::fe.b(this.m_eo, "Error saving spectrum. Failed to write file. Error is " + ex3.Message, "Information", a3());
						ProjectData.ClearProjectError();
					}
					hr4 = null;
				}
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception a_2 = ex4;
				global::i5.a(this.m_eo, this.m_ef, this, global::i6.a(this), "FIControlPanelMeasModule.SaveCalcSpectrumHandler", a_2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void an(object A_0, EventArgs A_1)
	{
		try
		{
			if (bd().Items.Count <= 0)
			{
				return;
			}
			bool A_2 = false;
			try
			{
				if (i(ref A_2) != global::f4.b.a)
				{
					throw new ao("Timeout waiting for lock on measResults collection in ComboMeasResult_SelectedIndexChanged");
				}
				int A_3 = default(int);
				if (i(bb().e7(), ref A_3))
				{
					hc hc2 = this.m_ez[A_3];
					ComboBox A_4 = bd();
					int num = global::hg.bu(ref A_4);
					i(A_4);
					if (num >= 0)
					{
						fl A_5 = bc();
						A_4 = bd();
						int a_ = global::hg.bu(ref A_4);
						i(A_4);
						jb.a(ref A_5, hc2, a_, A_3: true, this.m_h1, this.m_eo, hc2.cz());
						k(A_5);
					}
				}
			}
			finally
			{
				if (A_2)
				{
					Monitor.Exit(this.m_ez);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			this.m_eo.c(global::fz.b.b, "Error in FIControlPanelMeasModule ComboMeasResult_SelectedIndexChanged.", a_2);
			string[] array = new string[6];
			string A_6 = "GeneralFunctionErrIn";
			array[0] = global::hu.a(ref A_6);
			array[1] = " FIControlPanelMeasModule ComboMeasResult_SelectedIndexChanged.\r\n";
			A_6 = "GeneralFunctionErrIs";
			array[2] = global::hu.a(ref A_6);
			array[3] = Information.Err().Description;
			array[4] = ", ";
			array[5] = DateAndTime.Now.ToString("General Date");
			string a_3 = string.Concat(array);
			global::fe.b(this.m_eo, a_3, "Information", a3());
			ProjectData.ClearProjectError();
		}
	}

	public void h3()
	{
		z(A_0: true);
	}

	public void z(bool A_0)
	{
		checked
		{
			if (A_0 && global::e.a().ConfirmBeforeClearingGraph && this.m_e0.Count > 0)
			{
				Point point = global::i6.a(bb());
				point.Y -= unchecked(bb().Height / 2);
				ref fz a_ = ref this.m_eo;
				string A_1 = "ConfirmBeforeSpectrumDeleteQuery";
				string a_2 = global::hu.a(ref A_1);
				Point a_3 = point;
				A_1 = "DontAskMeThisAgain";
				bool A_2 = default(bool);
				if (!global::fe.b(ref a_, a_2, "ConfirmBeforeDeleteTitle", "Yes", "No", a_3, global::hu.a(ref A_1), ref A_2))
				{
					return;
				}
				global::e.a().ConfirmBeforeClearingGraph = !A_2;
			}
			if (this.m_e0.Count > 0)
			{
				@if = null;
				j(bu().ClientSize);
			}
			bb().g4();
			gg().g4();
			bc().g4();
			ba().g4();
			at();
			n(this.m_ef.t0(this.m_ek));
			this.m_eq.b();
		}
	}

	private void i(bool A_0, bool A_1, bool A_2, ref bool A_3, ref bool A_4)
	{
		hg hg2 = this.m_ef.t0(this.m_ek);
		if (A_0 && this.m_ef.xa(this.m_el))
		{
			this.m_ef.xb(this.m_el);
		}
		string a_ = ((!this.m_ef.ws(this.m_el) || !A_1) ? this.m_ef.m2(this.m_el, A_0, A_2: true) : this.m_ef.wq(this.m_el).c1());
		if (this.m_e4)
		{
			return;
		}
		if (A_2 && global::gq.g(this.m_h5) && !hg2.c9() && !hg2.fy && Operators.CompareString(hg2.ci(), "DefaultRecipe", TextCompare: false) != 0)
		{
			ref fz a_2 = ref this.m_eo;
			string A_5 = "RecipeUnsavedPromptFmt3";
			if (!global::fe.b(ref a_2, string.Format(global::hu.a(ref A_5), Strings.LCase("Recipe"), "\r\n", Strings.LCase("Recipe")), "RecipeLoadTitle", "OKString", "CancelString", global::i6.a(dm())))
			{
				A_3 = true;
				A_4 = true;
				if (dm().SelectedTab == dn())
				{
					dm().SelectedTab = dr();
				}
				else
				{
					dm().SelectedTab = dn();
				}
				goto IL_016b;
			}
		}
		i(a_, A_0, global::r.d.a.b.a, gq());
		goto IL_016b;
		IL_016b:
		aq();
	}

	private void am(object A_0, EventArgs A_1)
	{
		bool A_2 = false;
		try
		{
			if (i3)
			{
				return;
			}
			if (this.m_ef.td(this.m_ek))
			{
				A_2 = true;
				i3 = true;
				if (dm().SelectedTab == dn())
				{
					dm().SelectedTab = dr();
				}
				else
				{
					dm().SelectedTab = dn();
				}
			}
			else
			{
				bool a_ = dm().SelectedTab == dn() && this.m_ef.sj(h2());
				i(a_, A_1: false, A_2: true, ref A_2, ref i3);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			this.m_eo.c(global::fz.b.b, "Error in FIControlPanelMeasModule TabControlARHC_SelectedIndexChanged.", a_2);
			string[] array = new string[6];
			string A_3 = "GeneralFunctionErrIn";
			array[0] = global::hu.a(ref A_3);
			array[1] = " FIControlPanelMeasModule TabControlARHC_SelectedIndexChanged.\r\n";
			A_3 = "GeneralFunctionErrIs";
			array[2] = global::hu.a(ref A_3);
			array[3] = Information.Err().Description;
			array[4] = ", ";
			array[5] = DateAndTime.Now.ToString("General Date");
			string a_3 = string.Concat(array);
			global::fe.b(this.m_eo, a_3, "Information", global::i6.a(dm()));
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (A_2)
			{
				i3 = false;
			}
		}
	}

	private void al(object A_0, EventArgs A_1)
	{
		ar(RuntimeHelpers.GetObjectValue(A_0), A_1);
	}

	private void ak(object A_0, EventArgs A_1)
	{
		ar(RuntimeHelpers.GetObjectValue(A_0), A_1);
	}

	private void aj(object A_0, EventArgs A_1)
	{
		ax(RuntimeHelpers.GetObjectValue(A_0), A_1);
	}

	private void ai(object A_0, EventArgs A_1)
	{
		ax(RuntimeHelpers.GetObjectValue(A_0), A_1);
	}

	private void i(object A_0, TabControlCancelEventArgs A_1)
	{
		if (A_1.TabPage != dr())
		{
			return;
		}
		hg a_ = this.m_ef.wq(this.m_el);
		if (l(a_))
		{
			eo.a a_2 = h2();
			if (!this.m_ef.st(a_2) && !this.m_ef.sn(a_2) && !this.m_ef.sm())
			{
				string A_2 = "UnlicensedFeatureNotice";
				A_1.Cancel = true;
				global::fe.b(this.m_eo, global::hu.a(ref A_2), "UnlicensedFeatureNoticeTitle", null, global::i6.a(dm()), A_5: false, "http://www.filmetrics.com/accessories/software-upgrades/", "Upgrade Information");
			}
		}
	}

	private void ah(object A_0, EventArgs A_1)
	{
		try
		{
			if (this.m_e3)
			{
				string text = ev().Text;
				if (Operators.CompareString(global::e.a().OperatorID, text, TextCompare: false) != 0)
				{
					global::e.a().OperatorID = text;
					this.m_g4?.Invoke(this.m_el, text, A_2: false);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.b, "Error in FIControlPanelMeasModule.TextBoxOperatorId_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void x()
	{
		string A_ = null;
		string A_2 = null;
		bool A_3 = default(bool);
		this.m_ef.m2(this.m_el, ref A_, ref A_3, ref A_2);
		i(A_3, A_, A_2);
		io = this.m_ef.st(this.m_el, A_1: false);
	}

	private void i(bool A_0, string A_1, string A_2)
	{
		if (A_0)
		{
			@in = A_1;
			im = A_2;
		}
	}

	private void p(global::r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new global::r.d.b(p), A_0);
				return;
			}
			if (A_0.a != global::r.d.a.a.a)
			{
				global::fe.b(this.m_eo, "Error attempting to update recipe", global::i6.a(this));
				return;
			}
			string A_1 = null;
			string A_2 = null;
			DateTime dateTime = this.m_ef.st(this.m_el, A_1: false);
			float num = global::e.a().BaselineRemindTimeMinutes / 60f;
			bool flag = DateTime.Now.Subtract(io).TotalHours > (double)num;
			bool A_3 = default(bool);
			this.m_ef.m2(this.m_el, ref A_1, ref A_3, ref A_2);
			if (A_0.a8() == global::r.d.a.b.a && !flag && A_3 && (g3() != null || ip) && (Operators.CompareString(A_1, @in, TextCompare: false) != 0 || Operators.CompareString(A_2, im, TextCompare: false) != 0))
			{
				bool A_4 = !global::e.a().PromptForBaselineReminder;
				float num2 = num;
				string a_ = "0.##";
				string arg;
				if (Math.Round(num, 2) == 1.0)
				{
					arg = "hour";
				}
				else if (num < 1f)
				{
					num2 *= 60f;
					arg = ((Math.Round(num2, 2) != 1.0) ? "minutes" : "minute");
				}
				else
				{
					arg = "hours";
				}
				string text = @in;
				string text2 = A_1;
				hg hg2 = this.m_ef.wq(this.m_el);
				if (hg2.d0().c() == global::g2.a.b)
				{
					if (text.StartsWith(global::ex.e()))
					{
						text = text.Substring(global::ex.e().Length);
					}
					if (text2.StartsWith(global::ex.e()))
					{
						text2 = text2.Substring(global::ex.e().Length);
					}
				}
				string text3;
				if (Operators.CompareString(im, A_2, TextCompare: false) == 0)
				{
					string A_5 = "BaselineWarningNewReflStandardFmt";
					text3 = string.Format(global::hu.a(ref A_5), text2);
				}
				else if (Operators.CompareString(@in, A_1, TextCompare: false) == 0)
				{
					string A_5 = "BaselineWarningNewBaselineFmt";
					text3 = string.Format(global::hu.a(ref A_5), A_2);
				}
				else
				{
					string A_5 = "BaselineWarningNewReflStdAndBaselineFmt2";
					text3 = string.Format(global::hu.a(ref A_5), A_2, text2);
				}
				Point a_2 = ((!l(hg2)) ? global::i6.a(dx()) : global::i6.a(dm()));
				if (global::e.a().ForceBaselineIfIntervalExceeded)
				{
					fz a_3 = this.m_eo;
					string obj = text3;
					string A_5 = "BaselineWarningAgeFmt2";
					global::fe.b(a_3, obj + "\r\n\r\n" + string.Format(global::hu.a(ref A_5), global::i6.a(num2, a_), arg), "BaselineWarningTitle", null, a_2, A_5: false, null, null);
				}
				else
				{
					fz a_4 = this.m_eo;
					string obj2 = text3;
					string A_5 = "BaselineWarningAgeFmt2";
					string a_5 = obj2 + "\r\n\r\n" + string.Format(global::hu.a(ref A_5), global::i6.a(num2, a_), arg);
					A_5 = "DontRemindMeAgain";
					global::fe.b(a_4, a_5, "BaselineWarningTitle", null, a_2, A_5: false, null, null, global::hu.a(ref A_5), ref A_4);
					if (global::e.a().PromptForBaselineReminder != !A_4)
					{
						global::e.a().PromptForBaselineReminder = !A_4;
						h4();
					}
				}
			}
			i(A_3, A_1, A_2);
			io = dateTime;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_6 = ex2;
			this.m_eo.c(global::fz.b.b, "Exception caught in FIControlPanelMeasModule.RecipeChangedFinishedHandler()", a_6);
			ProjectData.ClearProjectError();
		}
	}

	private void o(global::r.d.a A_0)
	{
		x();
	}

	private void n(global::r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new global::r.d.b(n), A_0);
			}
			else if (A_0.a == global::r.d.a.a.a)
			{
				cx obj = new cx();
				a9[] A_1 = null;
				this.m_ef.m2(this.m_el, ref A_1);
				fz a_ = this.m_eo;
				f1 a_2 = this.m_ef;
				Guid a_3 = this.m_el;
				a9[] a_4 = A_1;
				Form parentForm = base.ParentForm;
				Point a_5 = global::i6.a(this);
				bool A_2 = false;
				obj.a(a_, a_2, a_3, this, a_4, parentForm, a_5, ref A_2);
			}
			else
			{
				global::fe.b(this.m_eo, "Error encountered while attempting to refresh the write enabled states.", global::i6.a(this));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_6 = ex2;
			this.m_eo.c(global::fz.b.b, "Exception caught in FIControlPanelMeasModule.RefreshWriteEnabledFinishedHandler()", a_6);
			ProjectData.ClearProjectError();
		}
	}

	private void m(global::r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				global::r.d.b method = m;
				BeginInvoke(method, A_0);
			}
			else if (A_0.a != global::r.d.a.a.a)
			{
				string text = "Error encountered during batch acquire or measure. Error is:\r\n";
				global::fe.b(A_1: (!string.IsNullOrEmpty(A_0.b)) ? (text + A_0.b) : (text + "Unknown Error"), A_0: this.m_eo, A_2: global::i6.a(this));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.b, "Exception caught in FIControlPanelMeasModule.BatchAcquireFinishedHandler()", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ag(object A_0, EventArgs A_1)
	{
		try
		{
			hg hg2 = this.m_ef.t0(this.m_ek);
			if (global::g2.a(this.m_ef.u8(this.m_el)))
			{
				if (eg().SelectedIndex != -1 && (this.m_ef.s4(this.m_ek) == null || Operators.CompareString(this.m_ef.s4(this.m_ek).n(), eg().Text, TextCompare: false) != 0))
				{
					hg2.d0().a(this.m_ef.uu().f(eg().Text));
					hg2.bu(gq(), true, true);
					return;
				}
				g2 g10 = hg2.d0();
				if (this.m_ef.uu().h().Length == 0 && g10.s() != null)
				{
					g10.a((cf)null);
					hg2.bu(gq(), true, true);
				}
				g10 = null;
				return;
			}
			eu eu2 = null;
			eu2 = this.m_ef.so(this.m_ef.u9(this.m_el).w);
			if (Operators.CompareString(eg().Text, global::ey.ay(), TextCompare: false) == 0)
			{
				et et2 = new et();
				g2 g11 = hg2.d0();
				if (g11.r() != null)
				{
					g11.r().ad(et2);
				}
				g11 = null;
				if (eu2.l() == null || eu2.l().Count == 0)
				{
					es es2 = new et();
					ef ef2 = new ef(this.m_eo);
					List<short> a_ = null;
					bool a_2 = default(bool);
					ef2.i(this.m_ef, this, this.m_el, this.m_hz, (et)es2, 0, new string[1] { es2.al() }, a_2, a_, global::i6.a(eg()));
					if (ef2.DialogResult == DialogResult.OK)
					{
						eu2.f(new Collection<es>());
						eu2.l().Add(es2);
						i(eu2);
						eu2.f();
						eg().SelectedIndex = 0;
					}
					else
					{
						eg().SelectedIndex = 0;
					}
					ef2.Dispose();
				}
				else
				{
					int A_2 = i4;
					eg obj = new eg(this.m_eo);
					f1 a_3 = this.m_ef;
					Guid a_4 = this.m_el;
					gr a_5 = this.m_hz;
					string A_3 = "ObjectiveSelectionTitleFmt2";
					string format = global::hu.a(ref A_3);
					string arg = global::ey.ay();
					A_3 = "Objective";
					obj.m(a_3, this, a_4, a_5, ref eu2, ref A_2, string.Format(format, arg, global::hu.a(ref A_3)), global::i6.a(eg()));
					i(eu2);
					if (eg().Items.Count > A_2 && A_2 != -1)
					{
						eg().SelectedIndex = A_2;
					}
					else
					{
						eg().SelectedIndex = 0;
					}
					obj.Dispose();
				}
				if (eu2.l() != null && eu2.l().Count > 0 && global::et.u((et)eu2.l()[eg().SelectedIndex], et2))
				{
					hg2.bu(gq(), true, true);
				}
				return;
			}
			if (eu2.l().Count != 0 && eg().SelectedIndex != -1 && (this.m_ef.s3(this.m_ek) == null || Operators.CompareString(this.m_ef.s3(this.m_ek).al(), eg().Text, TextCompare: false) != 0))
			{
				hg2.d0().a(eu2.f(eg().SelectedIndex));
				hg2.d0().w = eu2.i();
				hg2.bu(gq(), true, true);
			}
			else
			{
				g2 g12 = hg2.d0();
				if (eu2.l().Count == 0 && (g12.r() != null || Operators.CompareString(g12.w, eu2.i(), TextCompare: false) != 0))
				{
					g12.a((es)null);
					g12.w = eu2.i();
					hg2.bu(gq(), true, true);
				}
				g12 = null;
			}
			if (Operators.CompareString(eg().Text, global::ey.ax(), TextCompare: false) == 0)
			{
				i4 = -1;
			}
			else
			{
				i4 = eg().SelectedIndex;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_6 = ex2;
			this.m_eo.c(global::fz.b.b, "Exception caught in FIControlPanelMeasModule.ComboActiveObjective_SelectedIndexChanged", a_6);
			ProjectData.ClearProjectError();
		}
	}

	private void i(eu A_0)
	{
		eg().Items.Clear();
		checked
		{
			if (A_0 != null && A_0.k() != null)
			{
				int num = A_0.k().Length - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					eg().Items.Add(A_0.k()[num2]);
				}
			}
			else
			{
				eg().Items.Add(global::ey.ax());
			}
			eg().Items.Add(global::ey.ay());
		}
	}

	private void af(object A_0, EventArgs A_1)
	{
		try
		{
			bi().Enabled = false;
			bi().Visible = false;
			bf().Enabled = true;
			bf().Visible = true;
			this.m_hd = false;
			string A_2 = "";
			if (this.m_ef.m2("Acquiring Image Continuously...", ref A_2, g4(), this.m_g9) != global::ce.ErrPublic.None)
			{
				fz a_ = this.m_eo;
				string A_3 = "F40AcquireImageFailure";
				global::fe.b(a_, global::hu.a(ref A_3), a3());
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			this.m_eo.c(global::fz.b.b, "Error in ButtonPlayVideo_Click", a_2);
			Interaction.MsgBox("Error in ButtonPlayVideo_Click");
			ProjectData.ClearProjectError();
		}
	}

	private void ae(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_g9.q(A_0: true);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.b, "Error in ButtonStopVideo_Click", a_);
			Interaction.MsgBox("Error in ButtonStopVideo_Click");
			ProjectData.ClearProjectError();
		}
	}

	private void l(global::r.d.a A_0)
	{
		checked
		{
			try
			{
				if (base.InvokeRequired)
				{
					Invoke(new global::r.d.b(l), A_0);
					return;
				}
				d3.d d10 = (d3.d)A_0;
				if (((global::r.d.a)d10).a != global::r.d.a.a.a)
				{
					bool flag = default(bool);
					if (Operators.CompareString(((global::r.d.a)d10).b, "Dropped frame", TextCompare: false) == 0)
					{
						i5++;
						if (i5 >= 100)
						{
							flag = true;
							ref string reference = ref ((global::r.d.a)d10).b;
							reference = reference + " (" + 100 + " dropped frame events)";
							i5 = 0;
						}
					}
					else
					{
						flag = true;
					}
					if (flag)
					{
						this.m_eo.c(global::fz.b.a, "Error in video mVideoAcquireFrameCompletionTask_TaskFinishedEvent: " + ((global::r.d.a)d10).b);
					}
				}
				else if (d10.a4 == bh().Width && d10.a5 == bh().Height)
				{
					bh().h(Image.FromHbitmap(d10.a2));
					bh().Refresh();
				}
				if (d10.a3 > 0.5f)
				{
					this.m_hc = (float)((double)this.m_hc * 0.9);
					this.m_hd = true;
				}
				else if (d10.a3 < 0.25f && !this.m_hd)
				{
					this.m_hc = (float)((double)this.m_hc * 1.1);
					if (this.m_hc > 1f)
					{
						this.m_hc = 1f;
					}
				}
				hh();
			}
			catch (ThreadInterruptedException ex2)
			{
				ProjectData.SetProjectError(ex2);
				ThreadInterruptedException ex3 = ex2;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception a_ = ex4;
				this.m_eo.c(global::fz.b.b, "Exception caught in FIControlPanelMeasModule.VideoAcquireFrameCompletionTask_TaskFinishedEvent()", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ad(object A_0, EventArgs A_1)
	{
		try
		{
			string A_2 = "";
			ref fz a_ = ref this.m_eo;
			string A_3 = "F40WhiteBalanceStartMessage";
			if (global::fe.b(ref a_, global::hu.a(ref A_3), "F40WhiteBalance", "OKString", "CancelString", global::i6.a(bg())) && this.m_ef.m2("White Balance Image ...", ref A_2, g6(), g4()) != global::ce.ErrPublic.None)
			{
				fz a_2 = this.m_eo;
				A_3 = "F40WhiteBalanceFailure";
				global::fe.b(a_2, global::hu.a(ref A_3), a3());
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			this.m_eo.c(global::fz.b.b, "Error in ButtonWhiteBalance_Click", a_3);
			Interaction.MsgBox("Error in ButtonWhiteBalance_Click");
			ProjectData.ClearProjectError();
		}
	}

	private void k(global::r.d.a A_0)
	{
		if (base.InvokeRequired)
		{
			Invoke(new global::r.d.b(k), A_0);
		}
		else if (((global::r.d.a)(d3.d)A_0).a == global::r.d.a.a.b)
		{
			fz a_ = this.m_eo;
			string A_1 = "F40WhiteBalanceFailure";
			global::fe.b(a_, global::hu.a(ref A_1), "F40WhiteBalance", a3());
		}
		else
		{
			fz a_2 = this.m_eo;
			string A_1 = "F40WhiteBalanceFinished";
			global::fe.b(a_2, global::hu.a(ref A_1), "F40WhiteBalance", a3());
		}
	}

	private void k(object A_0, ScrollEventArgs A_1)
	{
		int num = this.m_ef.vc();
		int num2 = this.m_ef.vd();
		int a_ = ((bh().Width < num) ? bh().Width : num);
		int a_2 = ((bh().Height < num2) ? bh().Height : num2);
		if (A_1.ScrollOrientation == ScrollOrientation.HorizontalScroll)
		{
			this.m_ef.m2(A_1.NewValue, bh().p().Value, a_, a_2);
		}
		else
		{
			this.m_ef.m2(bh().m().Value, A_1.NewValue, a_, a_2);
		}
		checked
		{
			global::e.a().CameraImageCenterCol = bh().m().Value + unchecked(bh().Width / 2);
			global::e.a().CameraImageCenterRow = bh().p().Value + unchecked(bh().Height / 2);
		}
	}

	private void j(global::r.d.a A_0)
	{
		if (base.InvokeRequired)
		{
			Invoke(new global::r.d.b(j), A_0);
			return;
		}
		if (A_0.a != global::r.d.a.a.a)
		{
			fz a_ = this.m_eo;
			string A_1 = "F40AcquireImageFailure";
			global::fe.b(a_, global::hu.a(ref A_1), a3());
		}
		bi().Enabled = true;
		bi().Visible = true;
		bf().Enabled = false;
		bf().Visible = false;
	}

	private void w()
	{
		hr hr2 = null;
		int A_ = default(int);
		if (this.m_ef.ws(this.m_el))
		{
			he he2 = this.m_ef.wr(this.m_el);
			if (he2.ad().Count == he2.af().Count)
			{
				i(this.m_e0, "Analyze Button", A_2: false, A_3: true, global::r.d.a.b.a);
				he2 = null;
			}
			else
			{
				global::fe.b(this.m_eo, "One of recipes referenced in the Composite Recipe is missing or corrupted. Edit the Composite Recipe to select a valid recipe.", a3());
			}
		}
		else if (j(bb().e7(), ref A_))
		{
			hr2 = this.m_e0[A_];
			i(hr2, "Analyze Button", A_2: false, A_3: true, global::r.d.a.b.a);
		}
		else
		{
			this.m_ef.t0(this.m_ek).bu(this.m_eo, a3(), aj());
			hr a_ = hr2;
			string a_2 = this.m_ek;
			string A_2 = "";
			i(a_, "Analyze Button", a_2, ref A_2, A_4: false, global::r.d.a.b.a);
		}
	}

	private void ac(object A_0, EventArgs A_1)
	{
		try
		{
			w();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_eo.c(global::fz.b.b, "Error in ButtonAnalyze_Click.", ex3);
			global::fe.b(this.m_eo, "Error in ButtonAnalyze_Click. Error is " + ex3.ToString(), a3());
			ProjectData.ClearProjectError();
		}
	}

	private void v()
	{
		bool flag = false;
		try
		{
			if (Monitor.TryEnter(this.m_g3, 500))
			{
				flag = true;
				d d10 = this.m_g3;
				d10.c = DateTime.Now;
				if (this.m_ef.td(this.m_ek))
				{
					d10.a = global::f4.c.c;
				}
				else if (this.m_ef.s6(this.m_ek))
				{
					d10.a = global::f4.c.a;
				}
				else if (this.m_ef.s8(this.m_ek))
				{
					d10.a = global::f4.c.b;
					d10.b = this.m_ef.tc(this.m_ek);
				}
				else
				{
					d10.a = global::f4.c.d;
				}
				d10.d = this.m_ef.u5(this.m_el);
				if (d10.d)
				{
					this.m_ef.m2(this.m_el, ref d10.f, ref d10.e);
				}
				d10 = null;
			}
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(this.m_g3);
			}
		}
	}

	private void j(bool A_0)
	{
		b9.k k2 = this.m_ef.xe(this.m_el);
		double A_1 = 0.0;
		bool flag = i(k2, ref A_1);
		b9.k k3 = k2;
		d8().Visible = A_0;
		d7().Visible = A_0 && k3.c > 1;
		d4().Visible = A_0 && k3.c > 1;
		iq = A_0 && flag;
		d0().Visible = iq;
		d1().Visible = iq;
		if (!A_0)
		{
			d8().Value = 0;
			d6().Visible = false;
			d3().Visible = false;
			d7().Text = string.Empty;
			d0().Text = string.Empty;
			d2().Visible = false;
		}
		k3 = null;
	}

	private void u()
	{
		fv = false;
		gz().Stop();
		d8().Value = 0;
	}

	private void t()
	{
		this.m_fx = false;
		g0().Stop();
		this.m_gb = 0;
		d8().Value = 0;
	}

	private void s()
	{
		bool flag = false;
		bool flag2 = false;
		double totalSeconds = default(double);
		c c10 = default(c);
		global::r.d.a.b b10 = default(global::r.d.a.b);
		bool flag3 = default(bool);
		int num = default(int);
		int num2 = default(int);
		bool flag4 = default(bool);
		try
		{
			if (Monitor.TryEnter(this.m_g3, 500))
			{
				flag = true;
				d d10 = this.m_g3;
				totalSeconds = DateTime.Now.Subtract(d10.c).TotalSeconds;
				c10 = d10.a;
				b10 = d10.b;
				flag3 = d10.d;
				if (flag3)
				{
					num = d10.f;
					num2 = d10.e;
					flag4 = c10 == global::f4.c.d;
				}
				d10 = null;
			}
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(this.m_g3);
			}
		}
		try
		{
			b5().SuspendLayout();
			if (!global::e.a().DisplayMeasStatusControls)
			{
				eq().Visible = false;
				ez().Visible = false;
				b5().Controls.Remove(ez());
				dz().Visible = false;
				this.m_ga = false;
				return;
			}
			if (!this.m_ga)
			{
				if (!b5().Controls.Contains(ez()))
				{
					b5().Controls.Add(ez(), 1, b5().GetRow(eq()));
				}
				ez().Visible = global::e.a().DisplayMeasStatusControls;
				eq().Visible = global::e.a().DisplayMeasStatusControls;
				if (this.m_gn.i() == global::bx.a.b)
				{
					return;
				}
			}
			if (c10 != global::f4.c.d || flag3)
			{
				if (!this.m_fn || flag3 || jf.a(totalSeconds, fs))
				{
					if (!this.m_ga)
					{
						eq().Visible = false;
						ez().Visible = false;
						b5().Controls.Remove(ez());
						dz().Visible = true;
						this.m_ga = true;
					}
					flag2 = c10 == global::f4.c.b || c10 == global::f4.c.c;
					bool visible = flag2;
					switch (c10)
					{
					case global::f4.c.a:
					{
						if (flag3)
						{
							d5().Text = string.Format(global::ey.a7(), num.ToString(), num2.ToString());
							visible = true;
						}
						else
						{
							d5().Text = global::ey.a6();
						}
						u();
						g1().Stop();
						System.Timers.Timer timer3 = g0();
						if (!timer3.Enabled)
						{
							timer3.Interval = 100.0;
							timer3.AutoReset = false;
							lock (g0())
							{
								this.m_fx = true;
								timer3.Start();
							}
						}
						timer3 = null;
						j(A_0: true);
						break;
					}
					case global::f4.c.c:
						d5().Text = global::ey.a5();
						u();
						g1().Stop();
						j(A_0: false);
						t();
						break;
					default:
					{
						if (flag3 && flag4)
						{
							d5().Text = string.Format(global::ey.a2(), num.ToString(), num2.ToString());
							visible = true;
							break;
						}
						if (flag3)
						{
							d5().Text = string.Format(global::ey.a4(), num.ToString(), num2.ToString());
						}
						else
						{
							d5().Text = global::ey.a3();
						}
						j(A_0: true);
						t();
						System.Timers.Timer timer = gz();
						if (!timer.Enabled)
						{
							this.m_f6 = DateTime.Now;
							this.m_f9 = b10;
							this.m_f7 = false;
							timer.Interval = 200.0;
							timer.AutoReset = true;
							lock (gz())
							{
								fv = true;
								timer.Start();
							}
						}
						timer = null;
						System.Timers.Timer timer2 = g1();
						if (!timer2.Enabled)
						{
							timer2.Interval = 1000.0;
							timer2.AutoReset = true;
							timer2.Start();
						}
						timer2 = null;
						break;
					}
					}
					d9().Visible = visible;
				}
				else if (!gy().Enabled)
				{
					float num3 = checked((int)Math.Round(DateTime.Now.AddSeconds(fs).Subtract(fr).TotalMilliseconds));
					if (num3 < 1f)
					{
						num3 = 1f;
					}
					System.Timers.Timer timer4 = gy();
					timer4.Interval = num3;
					timer4.AutoReset = false;
					timer4.Start();
					_ = null;
				}
			}
			else
			{
				lock (gz())
				{
					if (fv)
					{
						u();
						ib?.Invoke(DateTime.Now.Subtract(this.m_f6).TotalSeconds, A_1: true, A_2: false);
					}
				}
				g1().Stop();
				lock (g0())
				{
					if (this.m_fx)
					{
						t();
					}
				}
				j(A_0: false);
				gy().Enabled = false;
				fr = DateTime.Now;
				if (this.m_ga)
				{
					eq().Visible = global::e.a().DisplayMeasStatusControls;
					ez().Visible = global::e.a().DisplayMeasStatusControls;
					b5().Controls.Add(ez(), 1, b5().GetRow(eq()));
					dz().Visible = false;
				}
				this.m_ga = false;
			}
			hg hg2 = this.m_ef.wq(this.m_el);
			hr hr2 = h1();
			eo.a a_ = null;
			ep().Enabled = !hg2.b5() && !flag2 && (!string.IsNullOrEmpty(global::e.a().PrecSimConfigFile) || global::e.a().PrecSimSetupMethod == 1) && ((hr2 != null && i(hr2, this.m_ef.ut(), a_) && !hr2.af() && hr2.ah()) || (hr2 == null && i(hg2, hg2.b5(), this.m_ef.ut(), null))) && !this.m_ef.ws(this.m_el);
			ek().Enabled = !flag2;
		}
		finally
		{
			b5().ResumeLayout();
		}
	}

	private void o(object A_0, ElapsedEventArgs A_1)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new r(o), A_0, A_1);
			}
			else if (!base.IsHandleCreated)
			{
				this.m_eo.c(global::fz.b.b, "Attempted mShowMeasStatusPanelTimer_Elapsed before handle created-Aborted", Environment.StackTrace);
			}
			else
			{
				s();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.b, "Exception caught in FIControlPanelMeasModule.mShowMeasStatusPanelTimer_Elapsed", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void i(fl.j A_0)
	{
		hg hg2 = null;
		bool flag = false;
		int A_1 = default(int);
		hg2 = ((!this.m_ef.ws(this.m_el) || !j(bb().e7(), ref A_1)) ? this.m_ef.t0(this.m_ek) : this.m_ef.wr(this.m_el).ad()[A_1]);
		hi hi2 = hg2.ed();
		flag = flag || hi2.fs() != A_0.a || hi2.fr() != A_0.b;
		hi2.d7(A_0.a);
		hi2.d6(A_0.b);
		if (!hi2.ft())
		{
			hi2.el(A_0: true);
			flag = true;
		}
		if (flag)
		{
			hg2.bu(gq());
			if (this.m_ef.ws(this.m_el) & (A_1 > 0))
			{
				i(bb().e7(), this.m_e0[A_1].ca(), A_2: true);
				@as();
				az();
			}
		}
	}

	private void ab(object A_0, EventArgs A_1)
	{
		try
		{
			string A_2 = "";
			hr hr2 = null;
			this.m_ef.sn(this.m_ek);
			bool flag = j(bb().e7(), ref il);
			if (flag)
			{
				hr2 = this.m_e0[il];
			}
			if (!this.m_ey.u || (flag && hr2.br() != null && hr2.br().Count >= 1))
			{
				d1 obj = this.m_ev;
				long A_3 = Convert.ToInt64(value: true);
				obj.e(ref A_3);
				this.m_et.e(global::r.d.a.b.a);
				am();
				if (this.m_ef.m2(this.m_ek, "Compute Precision Button", ref A_2, go(), null, hr2, this.m_ey, global::e.a().DisplaySignificantDigits, global::r.d.a.b.a) != global::ce.ErrPublic.None)
				{
					throw new ao("Failure to lock required object in ButtonComputePrecision_Click");
				}
			}
			else
			{
				string A_4 = "ComputePrecisionNoValidSpectrum";
				string a_ = global::hu.a(ref A_4);
				global::fe.b(this.m_eo, a_, a3());
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			al();
			this.m_eo.c(global::fz.b.b, "Error in ButtonComputePrecision_Click.", ex3);
			global::fe.b(this.m_eo, "Error in ButtonComputePrecision_Click. Error is " + ex3.ToString(), a3());
			ProjectData.ClearProjectError();
		}
	}

	private void aa(object A_0, EventArgs A_1)
	{
		try
		{
			new cp().a(this.m_ey, this.m_ef.ui());
			s();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_eo.c(global::fz.b.b, "Error in ButtonConfigurePrecision_Click.", ex3);
			global::fe.b(this.m_eo, "Error in ButtonConfigurePrecision_Click. Error is " + ex3.ToString(), a3());
			ProjectData.ClearProjectError();
		}
	}

	private void z(object A_0, EventArgs A_1)
	{
		try
		{
			bool flag = Operators.CompareString(ej().Text, "Show", TextCompare: false) == 0;
			bool visible = flag && a7();
			hc hc2 = null;
			ep().Visible = flag;
			ek().Visible = visible;
			if (Operators.CompareString(ej().Text, "Show", TextCompare: false) == 0)
			{
				ej().Text = "Hide";
				return;
			}
			ej().Text = "Show";
			d1 obj = this.m_ew;
			long A_2 = 0L;
			obj.e(ref A_2);
			bool A_3 = false;
			try
			{
				if (i(ref A_3) != global::f4.b.a)
				{
					throw new ao("Timeout waiting for lock on measResults collection in ActiveMeasResultIncludesMeasuredNorK");
				}
				int A_4 = default(int);
				if (i(bb().e7(), ref A_4))
				{
					hc2 = this.m_ez[A_4];
				}
				if (hc2 != null)
				{
					hc hc3 = hc2;
					if (hc3.dr() != null || hc3.du() != null || hc3.dv() != null || hc3.dw() != null || hc3.c8() != null || hc3.ds() != null)
					{
						hc3.cf(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 0f);
						i(hc2, A_1: false, A_2: false);
						d1 obj2 = this.m_ex;
						A_2 = 0L;
						obj2.e(ref A_2);
					}
					hc3 = null;
				}
			}
			finally
			{
				if (A_3)
				{
					Monitor.Exit(this.m_ez);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_eo, this.m_ef, this, global::i6.a(ej()), "FIControlPanelMeasModule.ButtonPrecisionHideShow_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void i(hr A_0)
	{
		this.m_h6.l(A_0, this.m_h6.l(), this.m_h6.m());
		Collection<en> collection = this.m_h6.c[this.m_h6.l()].b[this.m_h6.m()].b;
		en en2 = collection[checked(collection.Count - 1)];
		hg().l(hg().d);
		h9?.Invoke(en2.g, this);
	}

	public void h4()
	{
		try
		{
			@is = global::e.a().BaselineRemindTimeMinutes;
			it = global::e.a().PromptForBaselineReminder;
			r();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.b, "Error in FIControlPanelMeasModule.BaselineReminderSettingChangedHandler", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void r()
	{
		DateTime dateTime = this.m_ef.st(this.m_el, A_1: false);
		lock (g2())
		{
			if (q())
			{
				if (DateTime.Compare(dateTime, i6) != 0 || @is != i7 || (!g2().Enabled && g3() == null))
				{
					g2().Stop();
					double num = (double)(@is * 60000f) - DateTime.Now.Subtract(dateTime).TotalMilliseconds;
					System.Timers.Timer timer = g2();
					timer.Interval = ((num > 0.0) ? num : 1.0);
					timer.AutoReset = false;
					o();
					ip = timer.Interval < (double)this.m_f1;
					if (ip)
					{
						i(A_0: true);
					}
					timer = null;
					g2().Start();
					i6 = dateTime;
					i7 = @is;
				}
				else
				{
					ip = false;
				}
			}
			else
			{
				g2().Stop();
				ip = false;
				o();
			}
		}
	}

	[SpecialName]
	private bool q()
	{
		if (it && eb().Enabled)
		{
			return !this.m_f3;
		}
		return false;
	}

	private void n(object A_0, ElapsedEventArgs A_1)
	{
		try
		{
			lock (g2())
			{
				if (q())
				{
					p();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.b, "Error in FIControlPanelMeasModule.mBaselineReminderTimer_Elapsed", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void p()
	{
		try
		{
			if (g3() != null)
			{
				return;
			}
			if (base.InvokeRequired)
			{
				BeginInvoke(new s(p));
				return;
			}
			lock (g2())
			{
				if (!this.m_f4 && !this.m_f3)
				{
					n(new System.Timers.Timer());
					g3().Interval = this.m_f1;
					string A_ = "BaselineTooltip";
					string text = global::hu.a(ref A_);
					bz().SetToolTip(eb(), text);
					i(A_0: true, A_1: true, A_2: true, text);
					g3().Start();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.b, "Error in FIControlPanelMeasModule.BaselineStartBlink", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void o()
	{
		try
		{
			if (g3() != null)
			{
				if (!base.InvokeRequired)
				{
					lock (g2())
					{
						g3().Stop();
						g3().Dispose();
						n((System.Timers.Timer)null);
						bz().SetToolTip(eb(), null);
						i(A_0: false, A_1: false, A_2: true, null);
						i(A_0: false);
						return;
					}
				}
				BeginInvoke(new s(o));
			}
			else
			{
				i(A_0: false);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.b, "Error in FIControlPanelMeasModule.BaselineStopBlink", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void i(bool A_0)
	{
		i(ec(), A_0);
		if (A_0)
		{
			this.m_f2 = true;
			return;
		}
		this.m_f2 = false;
		ec().Invalidate();
	}

	public static void i(Button A_0, bool A_1)
	{
		if (A_1)
		{
			A_0.BackColor = Color.PaleGoldenrod;
			return;
		}
		A_0.BackColor = SystemColors.ButtonFace;
		A_0.UseVisualStyleBackColor = true;
	}

	private void m(object A_0, ElapsedEventArgs A_1)
	{
		try
		{
			if (!global::e.a().FICPMMOperationIsCollapsed && g3() != null)
			{
				if (base.InvokeRequired)
				{
					BeginInvoke(new t(m), A_0, A_1);
				}
				else
				{
					i(!this.m_f2);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.b, "Error in FIControlPanelMeasModule.mBaselineBlinkTimer_Elapsed", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void i(d5 A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new d4.c(i), A_0);
				return;
			}
			try
			{
				if (A_0.a)
				{
					if (this.m_e0.Count == 0)
					{
						d4.a a10 = this.m_ef.t6(this.m_ek);
						@if = new ej();
						@if.b(a10.s());
						@if.a(A_0.b, this.m_eo);
						@if.a(a10.u());
						@if.b(a10.v());
						@if.a(a10.w());
						@if.a(a10.q());
						a10 = null;
					}
					j(bu().ClientSize);
				}
				else
				{
					float A_1 = 0f;
					float A_2 = 0f;
					i(ref A_1, ref A_2);
				}
			}
			finally
			{
				if (A_0.b != null)
				{
					A_0.b.Dispose();
					A_0.b = null;
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.a, "Error in FIControlPanelMeasModule.VideoEventHandler", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void y(object A_0, EventArgs A_1)
	{
		try
		{
			d2 obj = new d2();
			d4.a a10 = this.m_ef.t6(this.m_ek);
			d4.e A_2 = default(d4.e);
			if (a10 != null)
			{
				A_2 = a10.ab();
			}
			bool a_;
			ej.b a_2;
			bool a_3;
			int a_4;
			if (A_0 == bn())
			{
				a_ = a10 != null;
				a_2 = a10.q();
				a_3 = true;
				a_4 = a10.r();
			}
			else
			{
				a_ = false;
				a_2 = ((@if != null) ? @if.q() : global::ej.b.a);
				a_3 = false;
				a_4 = 0;
			}
			obj.a(this.m_eo, a_, a_2, a_3, a_4, this.m_ef, this, this.m_el, ref A_2);
			if (obj.DialogResult != DialogResult.OK)
			{
				return;
			}
			if (a10 != null && a10.ab() != A_2 && bs().SelectedTab == bt())
			{
				if (ij != null)
				{
					ij.Close();
				}
				this.m_ef.m2(this.m_ek, g7(), global::r.d.a.b.a, A_2);
			}
			if (bs().SelectedTab == bu())
			{
				j(bu().ClientSize);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_eo.c(global::fz.b.a, "Error in FIControlPanelMeasModule.ButtonVideoSettings_Click", ex3);
			global::fe.b(this.m_eo, "Error in ButtonVideoSettings_Click. Error is: " + ex3.Message, global::i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private float i(int A_0, int A_1, int A_2)
	{
		return (float)(((double)A_0 + 0.5 * (double)A_1) / (double)A_2);
	}

	private void j(object A_0, ScrollEventArgs A_1)
	{
		try
		{
			d4.a a10 = this.m_ef.t6(this.m_ek);
			if (a10 != null && a10.p())
			{
				ScrollBar scrollBar = (ScrollBar)A_0;
				float num = i(A_1.NewValue, scrollBar.LargeChange, scrollBar.Maximum);
				scrollBar = null;
				if (A_1.ScrollOrientation == ScrollOrientation.HorizontalScroll)
				{
					this.m_ef.m2(this.m_ek, num, a10.v(), ScrollOrientation.HorizontalScroll);
				}
				else
				{
					this.m_ef.m2(this.m_ek, a10.u(), num, ScrollOrientation.VerticalScroll);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.a, "Error in FIControlPanelMeasModule.ScrollVideo_Scroll", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void x(object A_0, EventArgs A_1)
	{
		try
		{
			d4.a a10 = this.m_ef.t6(this.m_ek);
			float A_2 = default(float);
			float A_3 = default(float);
			i(ref A_2, ref A_3);
			if (a10 != null && (a10.p() || bq().Image == null))
			{
				this.m_ef.m2(this.m_ek, bl().Value, A_2, A_3);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_eo.c(global::fz.b.b, "Failed to lock spectrum collection in TrackBarZoom_ValueChanged", ex3.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private int i(int A_0, int A_1, int A_2, int A_3)
	{
		checked
		{
			int num = bl().Maximum - 1;
			int num2;
			for (num2 = 1; num2 <= num; num2++)
			{
				float num3 = global::ej.a(num2 + 1);
				if ((float)A_0 * num3 > (float)A_2 || (float)A_1 * num3 > (float)A_3)
				{
					break;
				}
			}
			return num2;
		}
	}

	private void i(ref float A_0, ref float A_1)
	{
		checked
		{
			int num = bt().ClientSize.Width - br().Left - bj().Width;
			int num2 = bt().ClientSize.Height - br().Top - bk().Height;
			int num3 = bt().ClientSize.Width - br().Left;
			int num4 = bt().ClientSize.Height - br().Top;
			d4.a a10 = this.m_ef.t6(this.m_ek);
			if (a10 == null)
			{
				return;
			}
			int num5 = i(a10.z(), a10.aa(), num3, num4);
			if (bl().Minimum != num5)
			{
				bl().Minimum = num5;
				x(bl(), new EventArgs());
				return;
			}
			float num6 = global::ej.a(bl().Value);
			bk().Maximum = (int)Math.Round((float)a10.z() * num6);
			bj().Maximum = (int)Math.Round((float)a10.aa() * num6);
			int num7 = (int)Math.Round((float)a10.z() * num6);
			int num8 = (int)Math.Round((float)a10.aa() * num6);
			bool flag = num8 > num4;
			bool flag2 = num7 > num3;
			if (flag)
			{
				flag2 = num7 > num;
			}
			if (flag2)
			{
				flag = num8 > num2;
			}
			if (flag)
			{
				flag2 = num7 > num;
				if (num7 > num)
				{
					br().Width = num;
				}
				else
				{
					br().Width = num7;
				}
			}
			else if (num7 > num3)
			{
				br().Width = num3;
			}
			else
			{
				br().Width = num7;
			}
			if (flag2)
			{
				if (num8 > num2)
				{
					br().Height = num2;
				}
				else
				{
					br().Height = num8;
				}
			}
			else if (num8 > num4)
			{
				br().Height = num4;
			}
			else
			{
				br().Height = num8;
			}
			this.m_ef.m2(this.m_ek, br().Width, br().Height, bl().Value);
			bk().LargeChange = br().Width;
			bj().LargeChange = br().Height;
			bj().Left = br().Right;
			bj().Top = br().Top;
			bj().Height = br().Height;
			bk().Width = br().Width;
			bk().Left = br().Left;
			bk().Top = br().Bottom;
			this.m_he = bj().Maximum > br().Height;
			this.m_hf = bk().Maximum > br().Width;
			bj().Visible = this.m_he;
			bk().Visible = this.m_hf;
			HScrollBar hScrollBar = bk();
			hScrollBar.Value = i(hScrollBar.Maximum, hScrollBar.LargeChange, this.m_hf, a10.u(), hScrollBar.Width);
			hScrollBar = null;
			VScrollBar vScrollBar = bj();
			vScrollBar.Value = i(vScrollBar.Maximum, vScrollBar.LargeChange, this.m_he, a10.v(), vScrollBar.Height);
			vScrollBar = null;
			if (!flag2)
			{
				A_0 = 0.5f;
			}
			else
			{
				HScrollBar hScrollBar2 = bk();
				A_0 = i(hScrollBar2.Value, hScrollBar2.LargeChange, hScrollBar2.Maximum);
				hScrollBar2 = null;
			}
			if (!flag)
			{
				A_1 = 0.5f;
			}
			else
			{
				VScrollBar vScrollBar2 = bj();
				A_1 = i(vScrollBar2.Value, vScrollBar2.LargeChange, vScrollBar2.Maximum);
				vScrollBar2 = null;
			}
			this.m_ef.m2(this.m_ek, A_0, A_1, ScrollOrientation.HorizontalScroll);
			this.m_ef.m2(this.m_ek, A_0, A_1, ScrollOrientation.VerticalScroll);
		}
	}

	private void i(float A_0, Size A_1)
	{
		bool flag = bp().Height < bq().Height;
		checked
		{
			bool flag2 = ((!flag) ? (bp().Width < bq().Width) : (bp().Width < bq().Width + 18));
			if (flag2)
			{
				flag = bp().Height < bq().Height + 18;
			}
			Point autoScrollPosition = default(Point);
			if (flag2)
			{
				int num = (bp().VerticalScroll.Visible ? 18 : 0);
				HScrollProperties hScrollProperties = bp().HorizontalScroll;
				autoScrollPosition.X = i(A_3: (@if != null) ? @if.s() : 0f, A_0: hScrollProperties.Maximum, A_1: hScrollProperties.LargeChange, A_2: hScrollProperties.Visible, A_4: bp().Width - num);
				hScrollProperties = null;
			}
			else if (@if != null)
			{
				@if.a(0.5f);
			}
			if (flag)
			{
				int num2 = (bp().HorizontalScroll.Visible ? 18 : 0);
				VScrollProperties vScrollProperties = bp().VerticalScroll;
				autoScrollPosition.Y = i(A_3: (@if != null) ? @if.t() : 0f, A_0: vScrollProperties.Maximum, A_1: vScrollProperties.LargeChange, A_2: vScrollProperties.Visible, A_4: bp().Height - num2);
				vScrollProperties = null;
			}
			else if (@if != null)
			{
				@if.b(0.5f);
			}
			bp().AutoScrollPosition = autoScrollPosition;
		}
	}

	private void j(Size A_0)
	{
		checked
		{
			if (@if != null)
			{
				ej ej2 = @if;
				bv().Enabled = ej2.o();
				if (ej2.r() == 0)
				{
					ej2.b(1);
				}
				float num = global::ej.a(ej2.r());
				if (bw().Minimum > ej2.r())
				{
					bw().Minimum = ej2.r();
				}
				bw().Value = ej2.r();
				Image image = ej2.l();
				if (image != null)
				{
					int a_ = A_0.Width;
					int a_2 = A_0.Height - bp().Top - 18;
					int num2 = i(image.Width, image.Height, a_, a_2);
					if (bw().Minimum != num2)
					{
						bw().Minimum = num2;
						ej2.b(bw().Value);
						num = global::ej.a(ej2.r());
					}
					Image image2 = new Bitmap(image, (int)Math.Round((float)image.Width * num), (int)Math.Round((float)image.Height * num));
					if (global::e.a().VideoShowSpot)
					{
						Rectangle a_3 = default(Rectangle);
						a_3.X = (int)Math.Round((float)ej2.p().X * num);
						a_3.Y = (int)Math.Round((float)ej2.p().Y * num);
						a_3.Width = (int)Math.Round((float)ej2.p().Width * num);
						a_3.Height = (int)Math.Round((float)ej2.p().Height * num);
						i(image2, a_3);
					}
					bq().Image = image2;
					i(num, A_0);
				}
				else
				{
					bq().Image = null;
				}
				ej2 = null;
			}
			else
			{
				bq().Image = null;
				bv().Enabled = false;
			}
		}
	}

	public static void i(Image A_0, Rectangle A_1)
	{
		Graphics graphics = Graphics.FromImage(A_0);
		int alpha = checked((int)Math.Round((double)global::e.a().VideoOpacity / 100.0 * 255.0));
		graphics.FillEllipse(new SolidBrush(Color.FromArgb(alpha, global::e.a().MeasureSpotColor)), A_1);
		graphics.Dispose();
	}

	private void w(object A_0, EventArgs A_1)
	{
		try
		{
			float num = global::ej.a(bl().Value);
			d4.a a10 = this.m_ef.t6(this.m_ek);
			Rectangle A_2 = default(Rectangle);
			Point A_3 = default(Point);
			i(bl().Value, a10.w(), br().Width, br().Height, bk().Maximum, bj().Maximum, ref A_2, ref A_3);
			this.m_ef.m2(this.m_ek, (float)((double)A_3.X + (double)br().Width / 2.0) / ((float)a10.z() * num), (float)((double)A_3.Y + (double)br().Height / 2.0) / ((float)a10.aa() * num), ScrollOrientation.HorizontalScroll);
			this.m_ef.m2(this.m_ek, (float)((double)A_3.X + (double)br().Width / 2.0) / ((float)a10.z() * num), (float)((double)A_3.Y + (double)br().Height / 2.0) / ((float)a10.aa() * num), ScrollOrientation.VerticalScroll);
			bk().Value = A_3.X;
			bj().Value = A_3.Y;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.a, "Error in ButtonCenter_Click", a_);
			global::fe.b(this.m_eo, "Error in FIControlPanelMeasModule.ButtonCenter_Click", global::i6.a(bo()));
			ProjectData.ClearProjectError();
		}
	}

	private void n()
	{
		try
		{
			d4.a a10 = this.m_ef.t6(this.m_ek);
			if (a10 != null)
			{
				this.m_ef.m2(this.m_ek, i);
			}
			if (base.IsHandleCreated && !base.InvokeRequired)
			{
				if (a10.s() < bl().Minimum)
				{
					bl().Value = bl().Minimum;
					x(bl(), new EventArgs());
					return;
				}
				bl().Value = a10.s();
				float A_ = 0f;
				float A_2 = 0f;
				i(ref A_, ref A_2);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.a, "Error in addVideoHandler", a_);
			ProjectData.ClearProjectError();
		}
	}

	private int i(int A_0, int A_1, bool A_2, double A_3, int A_4)
	{
		checked
		{
			int num = (int)Math.Round((double)A_0 * A_3 - 0.5 * (double)A_4);
			if (num < A_0 && A_2 && num > 0)
			{
				if (num + A_1 > A_0)
				{
					return A_0 - A_1;
				}
				return num;
			}
			return 0;
		}
	}

	private void i(global::r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new global::r.d.b(i), A_0);
			}
			else if (A_0.a == global::r.d.a.a.a)
			{
				if (l())
				{
					g8().Start();
				}
				n();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_eo.c(global::fz.b.b, "Exception caught in FIControlPanelMeasModule.mVideoCameraInitCompletionTask_TaskFinishedEvent", ex3.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void v(object A_0, EventArgs A_1)
	{
		try
		{
			d4.a a10 = null;
			if (this.m_ef != null)
			{
				a10 = this.m_ef.t6(this.m_ek);
			}
			if ((a10 == null || bs().SelectedTab != bt()) && bq().Image != null && bs().SelectedTab == bu())
			{
				j(((Control)A_0).ClientSize);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_eo.c(global::fz.b.b, "Exception caught in FIControlPanelMeasModule.TabControlVideoAndImage_Resize", ex3.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private bool m()
	{
		Graphics graphics = null;
		Bitmap bitmap = null;
		Graphics graphics2 = null;
		IntPtr hdc = default(IntPtr);
		IntPtr hdc2 = default(IntPtr);
		bool result = default(bool);
		try
		{
			PictureBox pictureBox = br();
			Size clientSize = pictureBox.ClientSize;
			graphics = pictureBox.CreateGraphics();
			bitmap = new Bitmap(clientSize.Width, clientSize.Height, graphics);
			graphics2 = Graphics.FromImage(bitmap);
			hdc = graphics2.GetHdc();
			hdc2 = graphics.GetHdc();
			bool num = global::gg.BitBlt(hdc, 0, 0, clientSize.Width, clientSize.Height, hdc2, 0, 0, 13369376);
			graphics.ReleaseHdc(hdc2);
			graphics.Dispose();
			graphics = null;
			graphics2.ReleaseHdc(hdc);
			graphics2.Dispose();
			graphics2 = null;
			if (!num)
			{
				return false;
			}
			result = i(bitmap);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_eo.c(global::fz.b.b, "Error in GetPicVideoImage.");
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (graphics != null)
			{
				graphics.ReleaseHdc(hdc2);
				graphics.Dispose();
			}
			if (graphics2 != null)
			{
				graphics2.ReleaseHdc(hdc);
				graphics2.Dispose();
			}
			bitmap?.Dispose();
		}
		return result;
	}

	private bool i(Bitmap A_0)
	{
		int num = br().BackColor.ToArgb();
		if (A_0 == null)
		{
			return false;
		}
		int num2 = A_0.Width / 4;
		int num3 = A_0.Height / 4;
		int num4 = 0;
		checked
		{
			do
			{
				int num5 = num3 * num4;
				int num6 = 0;
				do
				{
					int num7 = num2 * num6;
					if (A_0.GetPixel(num7, num5).ToArgb() != num)
					{
						return false;
					}
					num6++;
				}
				while (num6 <= 3);
				num4++;
			}
			while (num4 <= 3);
			return true;
		}
	}

	private void l(object A_0, ElapsedEventArgs A_1)
	{
		if (this.m_ef.tc())
		{
			return;
		}
		try
		{
			if (base.InvokeRequired)
			{
				g8().Stop();
				Invoke(new ElapsedEventHandler(l), A_0, A_1);
			}
			else if (l() && br().Visible)
			{
				if (global::e.a().DetectGrayImageFromCamera && m())
				{
					this.m_eo.c(global::fz.b.b, "Gray image detected.");
					if (ij != null)
					{
						ij.Close();
					}
					this.m_ef.m2(this.m_ek, g7(), global::r.d.a.b.a);
				}
				else
				{
					g8().Start();
				}
			}
			else
			{
				g8().Start();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			if (this.m_ef.tc())
			{
				ProjectData.ClearProjectError();
				return;
			}
			this.m_eo.c(global::fz.b.b, "Exception caught in FIControlPanelMeasModule.mTimerDetectGrayVideo_Elapsed", a_);
			ProjectData.ClearProjectError();
		}
	}

	private bool l()
	{
		return bs().SelectedTab == bt();
	}

	private void u(object A_0, EventArgs A_1)
	{
		try
		{
			d4.a a10 = this.m_ef.t6(this.m_ek);
			if (bs().SelectedTab == bt())
			{
				if (a10.s() < bl().Minimum)
				{
					bl().Value = bl().Minimum;
				}
				else
				{
					bl().Value = a10.s();
				}
				float A_2 = default(float);
				float A_3 = default(float);
				i(ref A_2, ref A_3);
				GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
				this.m_ef.m2(this.m_ek, global::e.a().VideoShowSpot, null, global::r.d.a.b.a);
				this.m_ef.m2(this.m_ek, bl().Value, A_2, A_3);
				g8().Start();
				if (ij != null)
				{
					ij.e();
				}
			}
			else
			{
				if (ij != null)
				{
					ij.d();
				}
				g8().Stop();
				if (a10 != null)
				{
					this.m_ef.qh(this.m_ek, null, global::r.d.a.b.a);
				}
			}
			hh();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_eo.c(global::fz.b.b, "Failed to lock spectrum collection in TabControlVideoAndImage_SelectedIndexChanged", ex3.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void i(int A_0, Rectangle A_1, int A_2, int A_3, int A_4, int A_5, ref Rectangle A_6, ref Point A_7)
	{
		float num = global::ej.a(A_0);
		A_6 = A_1;
		checked
		{
			A_6.X = (int)Math.Round((float)A_6.X * num + (float)A_6.Width * num / 2f);
			A_6.Y = (int)Math.Round((float)A_6.Y * num + (float)A_6.Height * num / 2f);
			A_6.Width = (int)Math.Round((float)A_6.Width * num);
			A_6.Height = (int)Math.Round((float)A_6.Height * num);
			if (A_6.X + unchecked(A_2 / 2) > A_4 - 1)
			{
				A_7.X = A_4 - A_2;
			}
			else if (A_6.X - unchecked(A_2 / 2) >= 0)
			{
				A_7.X = A_6.X - unchecked(A_2 / 2);
			}
			else
			{
				A_7.X = 0;
			}
			if (A_6.Y + unchecked(A_3 / 2) > A_5 - 1)
			{
				A_7.Y = A_5 - A_3;
			}
			else if (A_6.Y - unchecked(A_3 / 2) >= 0)
			{
				A_7.Y = A_6.Y - unchecked(A_3 / 2);
			}
			else
			{
				A_7.Y = 0;
			}
		}
	}

	private void t(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				Rectangle A_2 = default(Rectangle);
				Point A_3 = default(Point);
				i(bw().Value, @if.p(), bp().Width - 17, bp().Height - 17, bq().Width, bq().Height, ref A_2, ref A_3);
				bp().AutoScrollPosition = A_3;
				@if.a((float)((double)A_2.X / (double)bp().HorizontalScroll.Maximum));
				@if.b((float)((double)A_2.Y / (double)bp().VerticalScroll.Maximum));
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				this.m_eo.c(global::fz.b.b, "Failed to lock spectrum collection in ButtonImageCenter_Click", ex3.ToString());
				ProjectData.ClearProjectError();
			}
		}
	}

	private void s(object A_0, EventArgs A_1)
	{
		try
		{
			if (bq().Image != null)
			{
				@if.b(bw().Value);
				j(bu().ClientSize);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_eo.c(global::fz.b.b, "Failed to lock spectrum collection in TrackBarImage_ValueChanged", ex3.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void i(object A_0, ScrollEventArgs A_1)
	{
		try
		{
			int a_;
			int a_2;
			if (A_1.ScrollOrientation == ScrollOrientation.HorizontalScroll)
			{
				a_ = A_1.NewValue;
				a_2 = bp().VerticalScroll.Value;
			}
			else
			{
				a_ = bp().HorizontalScroll.Value;
				a_2 = A_1.NewValue;
			}
			@if.a(i(a_, bp().HorizontalScroll.LargeChange, bp().HorizontalScroll.Maximum));
			@if.b(i(a_2, bp().VerticalScroll.LargeChange, bp().VerticalScroll.Maximum));
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_eo.c(global::fz.b.b, "Failed to lock spectrum collection in PanelPic_Scroll", ex3.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void k()
	{
		if (bs().Visible)
		{
			TabControl tabControl = bs();
			int num;
			checked
			{
				num = unchecked(tabControl.ClientSize.Width / tabControl.TabCount) - 2;
			}
			if (tabControl.TabCount == 1)
			{
				num /= 2;
			}
			if (tabControl.ItemSize.Width != num && num > 0)
			{
				tabControl.ItemSize = new Size(num, tabControl.ItemSize.Height);
			}
			tabControl = null;
		}
	}

	public void i(ref IntPtr A_0, ref global::r.d A_1)
	{
		A_0 = br().Handle;
		A_1 = g7();
	}

	private void r(object A_0, EventArgs A_1)
	{
		try
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Image Files (*.jpg, *.jpeg )|*.jpg";
			saveFileDialog.InitialDirectory = global::c.e().FileSystem.SpecialDirectories.MyPictures;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				bq().Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_eo.c(global::fz.b.b, "Error caught in FIControlPanelMeasModule.ToolStripMenuItemSaveImage_Click", ex3.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void j(object A_0, MouseEventArgs A_1)
	{
		try
		{
			if (A_1.Button == MouseButtons.Right)
			{
				b0().Show(bq(), A_1.Location.X, A_1.Location.Y);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_eo.c(global::fz.b.b, "Error caught in FIControlPanelMeasModule.PicImage_MouseClick", ex3.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public bool h5()
	{
		return bs().SelectedTab == bt();
	}

	private void q(object A_0, EventArgs A_1)
	{
		try
		{
			eo a_ = this.m_ef.ut();
			hg A_2 = new hg(a_, global::hg.b4());
			he A_3 = new he(string.Empty, string.Empty, string.Empty);
			this.m_ef.wr(this.m_el).s(ref A_3, A_1: true);
			this.m_ef.t0(this.m_ek).bu(ref A_2);
			he he2 = new he(string.Empty, this.m_ef.t0(this.m_ek).c1(), ev().Text);
			he2.ad().Add(this.m_ef.t0(this.m_ek));
			using ct ct2 = new ct(this.m_eo);
			ct2.a(he2, A_2.c1(), ev().Text, this.m_ef, this, this.m_hz, this.m_h0, h2());
			he A_4;
			if (ct2.DialogResult != DialogResult.Cancel)
			{
				this.m_ef.t0(this.m_ek).ca(A_0: true);
				A_4 = this.m_ef.wr(this.m_el);
				he2.s(ref A_4, A_1: true);
				az();
				return;
			}
			he obj = A_3;
			A_4 = this.m_ef.wr(this.m_el);
			obj.s(ref A_4, A_1: true);
			if (!this.m_ef.ws(this.m_el))
			{
				hg obj2 = A_2;
				hg A_5 = this.m_ef.t0(this.m_ek);
				obj2.bu(ref A_5);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_eo, this.m_ef, this, a3(), "FIControlPanelMeasModule.NewCompositeRecipeToolStripMenuItem_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void i(object A_0, MouseEventArgs A_1)
	{
		Button button = (Button)A_0;
		this.m_ef.t0(this.m_ek).dh();
		if (A_1.Button == MouseButtons.Right && a0())
		{
			b2().Show(button, checked(button.Width - b2().Width), button.Height);
		}
		_ = null;
	}

	private bool i(b9.k A_0, ref double A_1)
	{
		if (A_0.f)
		{
			A_1 = DateTime.Now.Subtract(this.m_f8).TotalSeconds;
		}
		if (A_0.f && A_0.h > 0 && this.m_f7 && (A_1 > 3.0 || (double)A_0.h / (double)A_0.g > 0.10000000149011612))
		{
			return A_0.b < A_0.c;
		}
		return false;
	}

	private void k(object A_0, ElapsedEventArgs A_1)
	{
		checked
		{
			try
			{
				if (this.m_ef.tc())
				{
					return;
				}
				if (base.InvokeRequired)
				{
					try
					{
						gz().Stop();
						Invoke(new ElapsedEventHandler(k), A_0, A_1);
						return;
					}
					finally
					{
						lock (gz())
						{
							if (fv)
							{
								gz().Start();
							}
						}
					}
				}
				if (!base.IsHandleCreated)
				{
					this.m_eo.c(global::fz.b.b, "Attempted mAnalysisStatusUpdateTimer_Elapsed before handle created-Aborted", Environment.StackTrace);
					return;
				}
				lock (gz())
				{
					if (!fv)
					{
						return;
					}
					b9.k k2 = this.m_ef.xe(this.m_el);
					b9.k k3 = k2;
					if (k3.b < k3.c)
					{
						d7().Text = k3.b + 1 + " of " + k3.c;
					}
					else
					{
						d7().Text = string.Empty;
					}
					if (k3.a)
					{
						if (k3.d > 0)
						{
							d8().Value = (int)Math.Round((double)(100 * k3.e) / (double)k3.d);
						}
						else
						{
							d8().Value = 0;
						}
						if (k3.j)
						{
							d6().Visible = true;
							d3().Visible = true;
							d6().Text = k3.k.ToString("0.####");
							d2().Visible = true;
						}
						else
						{
							d6().Visible = false;
							d3().Visible = false;
							d2().Visible = false;
						}
						if (k3.a && k3.f && !this.m_f7)
						{
							this.m_f8 = DateTime.Now;
							this.m_f7 = true;
						}
						if (this.m_f9 == global::r.d.a.b.a)
						{
							ic?.Invoke((uint)k3.e, (uint)k3.d);
						}
					}
					else
					{
						d8().Value = 0;
						d6().Visible = false;
						d3().Visible = false;
						d2().Visible = false;
					}
					double A_2 = default(double);
					if (i(k2, ref A_2))
					{
						double num = A_2 / (double)k3.h * (double)(k3.g - k3.h);
						string text = ((num > 3600.0) ? "hh:mm:ss" : ((!(num > 60.0)) ? "ss" : "mm:ss"));
						d0().Text = DateTime.MinValue.AddSeconds(num).ToString(text);
						if (!iq)
						{
							j(A_0: true);
						}
					}
					else if (iq)
					{
						j(A_0: true);
					}
					k3 = null;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				if (this.m_ef.tc())
				{
					ProjectData.ClearProjectError();
					return;
				}
				this.m_eo.c(global::fz.b.b, "Exception caught in FIControlPanelMeasModule.mAnalysisStatusUpdateTimer_Elapsed", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void j(object A_0, ElapsedEventArgs A_1)
	{
		try
		{
			if (this.m_ef.tc())
			{
				return;
			}
			if (base.InvokeRequired)
			{
				try
				{
					g1().Stop();
					Invoke(new ElapsedEventHandler(j), A_0, A_1);
					return;
				}
				finally
				{
					g1().Start();
				}
			}
			if (!base.IsHandleCreated)
			{
				this.m_eo.c(global::fz.b.b, "Attempted mAnalysisCalcSpectraUpdateTimer before handle created-Aborted", Environment.StackTrace);
			}
			else
			{
				if (!this.m_ef.u0(this.m_el))
				{
					return;
				}
				b9.l[] array = this.m_ef.xf(this.m_el);
				if (array == null)
				{
					return;
				}
				fl.n n2 = new fl.n();
				double[] a_ = null;
				double[] a_2 = null;
				double[] array2 = null;
				double[] a_3 = null;
				hr hr2 = h1();
				if (hr2 == null)
				{
					return;
				}
				hi hi2 = this.m_ef.wq(this.m_el).ed();
				fl.h a_4;
				int a_5 = default(int);
				int a_6 = default(int);
				if (hi2.d6(0, hr2))
				{
					a_4 = global::fl.h.a;
					if (hi2.d5(0, hr2))
					{
						a_ = array[1].b;
						a_2 = array[1].c;
						a_5 = array[1].a;
						if (hi2.d6(1, hr2))
						{
							array2 = array[2].b;
							a_3 = array[2].c;
							a_6 = array[2].a;
						}
					}
					else if (hi2.d6(1, hr2))
					{
						array2 = array[1].b;
						a_3 = array[1].c;
						a_6 = array[1].a;
					}
				}
				else if (hi2.d6(1, hr2))
				{
					a_4 = global::fl.h.c;
					if (array.Length > 1)
					{
						a_ = array[1].b;
						a_2 = array[1].c;
						a_5 = array[1].a;
					}
				}
				else
				{
					a_4 = global::fl.h.b;
				}
				hi2 = null;
				fl.o a_7 = new fl.o(array[0].b, array[0].c, array[0].a, a_, a_2, a_5);
				n2.e(a_7);
				if (array2 != null)
				{
					a_7 = new fl.o(array2, a_3, a_6, null, null, 0);
					n2.e(a_7);
				}
				bb().g2();
				bb().o(n2, array[0].d, array[0].e, array[0].g, string.Format(global::ey.at(), array[0].f), global::ey.ap(), A_6: false, a_4, A_8: false);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_8 = ex2;
			if (this.m_ef.tc())
			{
				ProjectData.ClearProjectError();
				return;
			}
			this.m_eo.c(global::fz.b.b, "Exception caught in FIControlPanelMeasModule.mAnalysisCalcSpectraUpdateTimer", a_8);
			ProjectData.ClearProjectError();
		}
	}

	public void h6()
	{
		h7();
	}

	public void h7()
	{
		u();
		g1().Stop();
		this.m_e7.q(A_0: true);
		f1 obj = this.m_ef;
		string a_ = this.m_ek;
		string A_ = null;
		string A_2 = "AnalysisCancelled";
		obj.p9(a_, "Cancelling Analysis", ref A_, global::hu.a(ref A_2));
	}

	private void j()
	{
		b4().Image = (this.m_h8 ? Resources.Expand : Resources.Hide);
		b4().ImageAlign = (this.m_h8 ? ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft);
	}

	private void p(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_h8 = !this.m_h8;
			global::e.a().VideoCollapseControl = this.m_h8;
			j();
			hh();
			this.m_g7?.Invoke();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_eo, this.m_ef, this, a3(), "FIControlPanelMeasModule.ButtonHideTabControl_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_ef.m2(this.m_el, A_1: true, A_2: true, gs());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_eo, this.m_ef, this, global::i6.a(this), "FIControlPanelMeasModule.ButtonFirmware_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void n(object A_0, EventArgs A_1)
	{
		if (!ab())
		{
			global::e.a().DualSpectrumGraphs = gh().Checked;
			az();
		}
	}

	private void m(object A_0, EventArgs A_1)
	{
		this.m_ef.tg(this.m_el, gi().CheckState == CheckState.Checked);
	}

	[SpecialName]
	public bs h8()
	{
		return ij;
	}

	private void l(object A_0, EventArgs A_1)
	{
		try
		{
			gj().Enabled = false;
			ij = new bs();
			ij.FormClosed += i;
			ij.a(this.m_eo, this.m_ef, this.m_el);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_eo, this.m_ef, this, a3(), "FIControlPanelMeasModule.ButtonShowVideoDialog_Click", a_);
			gj().Enabled = true;
			ProjectData.ClearProjectError();
		}
	}

	private void i(object A_0, FormClosedEventArgs A_1)
	{
		try
		{
			ij.FormClosed -= i;
			ij = null;
			gj().Enabled = true;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_eo, this.m_ef, this, a3(), "FIControlPanelMeasModule.DialogVideoFormClosedEventHandler", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		try
		{
			i((PictureBox)A_0).g();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.b, "Error inFIControlPanelMeasModule.OutlinePicturebox_MouseEnter", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		try
		{
			i((PictureBox)A_0).h();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_eo.c(global::fz.b.b, "Error inFIControlPanelMeasModule.OutlinePicturebox_MouseLeave", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		try
		{
			SuspendLayout();
			i((PictureBox)A_0, global::bx.b.a);
			ar();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_eo, this.m_ef, this, a8(), "FIControlPanelMeasModule.OutlinePicturebox_Click", a_);
			ProjectData.ClearProjectError();
		}
		finally
		{
			ResumeLayout(performLayout: true);
		}
	}

	private bx i(PictureBox A_0)
	{
		bool flag = true;
		if (flag == (A_0 == e2()))
		{
			return this.m_gk;
		}
		if (flag == (A_0 == e6()))
		{
			return this.m_gl;
		}
		if (flag == (A_0 == e1()))
		{
			return this.m_gm;
		}
		if (flag == (A_0 == ez()))
		{
			return this.m_gn;
		}
		if (flag == (A_0 == e0()))
		{
			return this.m_go;
		}
		if (flag == (A_0 == ey()))
		{
			return this.m_gp;
		}
		if (flag == (A_0 == e4()))
		{
			return this.m_gq;
		}
		if (flag == (A_0 == e3()))
		{
			return this.m_gr;
		}
		if (flag == (A_0 == e5()))
		{
			return this.m_gs;
		}
		this.m_eo.c(global::fz.b.b, "Error inFIControlPanelMeasModule.GetPicBoxECCHelper - Software Bug - About to return Nothing.");
		return null;
	}

	private void i()
	{
		try
		{
			b5().SuspendLayout();
			i(e2(), this.m_gk.f(global::e.a().FICPMMTabPanelARHCIsCollapsed));
			i(e6(), this.m_gl.f(global::e.a().FICPMMMeasDetailsIsCollapsed));
			i(e1(), this.m_gm.f(global::e.a().FICPMMMeasRecipeIsCollapsed));
			i(ez(), this.m_gn.f(global::e.a().FICPMMMeasurementResultIsCollapsed));
			i(e0(), this.m_go.f(global::e.a().FICPMMOperationIsCollapsed));
			i(ey(), this.m_gp.f(global::e.a().FICPMMSampleInfoIsCollapsed));
			i(e4(), this.m_gq.f(global::e.a().FICPMMSecondaryColorIsCollapsed));
			i(e3(), this.m_gr.f(global::e.a().FICPMMSpectrumColorIsCollapsed));
			i(e5(), this.m_gs.f(global::e.a().FICPMMTemplateIsCollapsed));
		}
		finally
		{
			b5().ResumeLayout(performLayout: true);
		}
	}

	private void i(PictureBox A_0, bx.b A_1)
	{
		bx obj = i(A_0);
		obj.f(A_1);
		bool num = obj.i() == global::bx.a.a;
		_ = null;
		checked
		{
			if (num)
			{
				bool flag = true;
				if (flag == (A_0 == e2()))
				{
					dm().Height = 108;
					global::e.a().FICPMMTabPanelARHCIsCollapsed = false;
				}
				else if (flag == (A_0 == e6()))
				{
					ei().ForeColor = Color.Black;
					if (this.m_e3)
					{
						aw();
					}
					en().Visible = true;
					em().Visible = true;
					global::e.a().FICPMMMeasDetailsIsCollapsed = false;
				}
				else if (flag == (A_0 == e1()))
				{
					dv().Height = 92;
					global::e.a().FICPMMMeasRecipeIsCollapsed = false;
				}
				else if (flag == (A_0 == ez()))
				{
					eq().Height = 115;
					dz().Height = eq().Height;
					eq().ForeColor = Color.Black;
					er().Visible = true;
					global::e.a().FICPMMMeasurementResultIsCollapsed = false;
				}
				else if (flag == (A_0 == e0()))
				{
					_ = ea().Height;
					fb().Visible = true;
					if (!this.m_gt && !this.m_gu)
					{
						ea().Height = 183 - ee().Height - e9().Height - 12;
					}
					else if (this.m_gt && !this.m_gu)
					{
						ea().Height = 183 - e9().Height - 6;
					}
					else if (!this.m_gt && this.m_gu)
					{
						ea().Height = 183 - ee().Height - 6;
					}
					else
					{
						ea().Height = 183;
					}
					global::e.a().FICPMMOperationIsCollapsed = false;
				}
				else if (flag == (A_0 == ey()))
				{
					es().Height = 77;
					es().ForeColor = Color.Black;
					global::e.a().FICPMMSampleInfoIsCollapsed = false;
				}
				else if (flag == (A_0 == e4()))
				{
					cm().Height = 75;
					cm().ForeColor = Color.Black;
					global::e.a().FICPMMSecondaryColorIsCollapsed = false;
				}
				else if (flag == (A_0 == e3()))
				{
					c4().Height = 75;
					c4().ForeColor = Color.Black;
					global::e.a().FICPMMSpectrumColorIsCollapsed = false;
				}
				else if (flag == (A_0 == e5()))
				{
					ch().Height = 127;
					global::e.a().FICPMMTemplateIsCollapsed = false;
				}
			}
			else
			{
				bool flag2 = true;
				if (flag2 == (A_0 == e2()))
				{
					dm().Height = 68;
					global::e.a().FICPMMTabPanelARHCIsCollapsed = true;
				}
				else if (flag2 == (A_0 == e6()))
				{
					ei().Height = 15;
					ei().ForeColor = Color.LightGray;
					en().Visible = false;
					em().Visible = false;
					global::e.a().FICPMMMeasDetailsIsCollapsed = true;
				}
				else if (flag2 == (A_0 == e1()))
				{
					dv().Height = 48;
					global::e.a().FICPMMMeasRecipeIsCollapsed = true;
				}
				else if (flag2 == (A_0 == ez()))
				{
					eq().Height = 15;
					dz().Height = 15;
					eq().ForeColor = Color.LightGray;
					er().Visible = false;
					global::e.a().FICPMMMeasurementResultIsCollapsed = true;
				}
				else if (flag2 == (A_0 == e0()))
				{
					fb().Visible = false;
					if (!this.m_gt && !this.m_gu)
					{
						ea().Height = 76;
					}
					else if (this.m_gt && !this.m_gu)
					{
						ea().Height = 76 + ee().Height + 6;
					}
					else if (!this.m_gt && this.m_gu)
					{
						ea().Height = 76 + e9().Height + 6;
					}
					global::e.a().FICPMMOperationIsCollapsed = true;
				}
				else if (flag2 == (A_0 == ey()))
				{
					es().Height = 15;
					es().ForeColor = Color.LightGray;
					global::e.a().FICPMMSampleInfoIsCollapsed = true;
				}
				else if (flag2 == (A_0 == e4()))
				{
					cm().Height = 15;
					cm().ForeColor = Color.LightGray;
					global::e.a().FICPMMSecondaryColorIsCollapsed = true;
				}
				else if (flag2 == (A_0 == e3()))
				{
					c4().Height = 15;
					c4().ForeColor = Color.LightGray;
					global::e.a().FICPMMSpectrumColorIsCollapsed = true;
				}
				else if (flag2 == (A_0 == e5()))
				{
					ch().Height = 88;
					global::e.a().FICPMMTemplateIsCollapsed = true;
				}
			}
			int A_2 = default(int);
			i(ref A_2);
			i(new Size(0, A_2));
		}
	}

	private void i(Size A_0)
	{
		this.m_g6?.Invoke(A_0);
		if (base.Parent != null && (base.Parent.ClientSize.Width != base.Width || base.Parent.ClientSize.Height != base.Height))
		{
			i(base.Parent.ClientSize.Width, base.Parent.ClientSize.Height);
		}
	}

	private void i(object A_0, PaintEventArgs A_1)
	{
		checked
		{
			try
			{
				Graphics graphics = A_1.Graphics;
				int num = this.m_gx;
				double num2 = (double)num / (double)fe().Width;
				string text;
				Color color = default(Color);
				float num3 = default(float);
				if (this.m_gz)
				{
					num = 0;
					text = string.Empty;
				}
				else if (num2 < 0.15)
				{
					color = Color.FromArgb(255, 80, 80);
					if (eb().Enabled)
					{
						text = global::ey.q();
						if (iu[0])
						{
							num3 = iv[0];
						}
						else
						{
							num3 = (float)((double)(fe().ClientSize.Width - jg.a(graphics, text, e7().Font)) * 0.5);
							iv[0] = num3;
							iu[0] = true;
						}
					}
					else
					{
						text = string.Empty;
					}
				}
				else if (num2 < 0.3)
				{
					color = Color.FromArgb(252, 224, 69);
					text = global::ey.p();
					if (iu[1])
					{
						num3 = iv[1];
					}
					else
					{
						num3 = (float)((double)(fe().ClientSize.Width - jg.a(graphics, text, e7().Font)) * 0.5);
						iv[1] = num3;
						iu[1] = true;
					}
				}
				else if (num2 < 0.5)
				{
					color = Color.FromArgb(140, 255, 140);
					text = global::ey.o();
					if (iu[2])
					{
						num3 = iv[2];
					}
					else
					{
						num3 = (float)((double)(fe().ClientSize.Width - jg.a(graphics, text, e7().Font)) * 0.5);
						iv[2] = num3;
						iu[2] = true;
					}
				}
				else
				{
					color = Color.FromArgb(140, 255, 140);
					text = global::ey.n();
					if (iu[3])
					{
						num3 = iv[3];
					}
					else
					{
						num3 = (float)((double)(fe().ClientSize.Width - jg.a(graphics, text, e7().Font)) * 0.5);
						iv[3] = num3;
						iu[3] = true;
					}
				}
				graphics.FillRectangle(new SolidBrush(color), new Rectangle(new Point(0, 0), new Size(num, fe().Height)));
				if (!string.IsNullOrEmpty(text))
				{
					graphics.DrawString(text, e7().Font, new SolidBrush(Color.Black), new PointF(num3, 0f));
				}
				this.m_gy = num;
				this.m_g0 = this.m_gz;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				a4().c(global::fz.b.b, "Error in FIPanelBufferedBaselineRefStatus_Paint", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void i(object A_0, ElapsedEventArgs A_1)
	{
		checked
		{
			float num3 = default(float);
			try
			{
				if (this.m_ef.tc() || !ih)
				{
					return;
				}
				if (base.InvokeRequired)
				{
					try
					{
						g0().Stop();
						Invoke(new ElapsedEventHandler(i), A_0, A_1);
						return;
					}
					finally
					{
						lock (g0())
						{
							if (this.m_fx)
							{
								g0().Start();
							}
						}
					}
				}
				float num = 2f;
				lock (g0())
				{
					if (this.m_gb > 0 && this.m_gc > 0)
					{
						float num2 = (float)(100.0 / (double)this.m_gb);
						num3 = (float)DateTime.Now.Subtract(this.m_gd).TotalMilliseconds;
						num = num2 * (float)(this.m_gc - 1) + num2 * (1f - (float)Math.Exp(-3f * num3 / this.m_ge));
					}
				}
				d8().Value = (int)Math.Round((double)num * 0.01 * (double)d8().Maximum);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				if (this.m_ef.tc())
				{
					ProjectData.ClearProjectError();
					return;
				}
				this.m_eo.c(global::fz.b.b, "Exception caught in FIControlPanelMeasModule.mAcqProgressTimer_Elapsed, elapsed time = " + num3 + ", mAcqProgressCurrentSegmentStartTime = " + this.m_gd.ToString() + ", mAcqProgressSegmentTime = " + this.m_ge, a_);
				ProjectData.ClearProjectError();
			}
		}
	}
}
