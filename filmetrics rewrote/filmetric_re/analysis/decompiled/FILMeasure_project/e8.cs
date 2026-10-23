using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Forms;
using Filmetrics.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

[DesignerGenerated]
internal class e8 : Form
{
	public class a
	{
		private bool m_a;

		private bool m_b;

		private bool c;

		private bool d;

		private bool e;

		private bool f;

		private string m_g;

		private bool m_h;

		private bool i;

		private eo.a j;

		public a(bool A_0, bool A_1, bool A_2, bool A_3, bool A_4, string A_5, bool A_6, bool A_7, eo.a A_8, bool A_9)
		{
			this.m_a = A_0;
			this.m_b = A_9;
			c = A_1;
			d = A_2;
			e = A_3;
			f = A_4;
			this.m_g = A_5;
			this.m_h = A_6;
			i = A_7;
			j = A_8;
		}

		[SpecialName]
		public static bool a(a A_0, g2 A_1)
		{
			return A_0?.a(A_1) ?? false;
		}

		[SpecialName]
		private bool a(g2 A_0)
		{
			if (!this.m_a || !c)
			{
				if (!this.m_a)
				{
					if (!d)
					{
						if (!e)
						{
							if (A_0 == null || (!A_0.l() && Operators.CompareString(A_0.k(), this.m_g, TextCompare: false) != 0) || A_0.c() != global::g2.a.m)
							{
								if (A_0 == null)
								{
									return f;
								}
								return false;
							}
							return true;
						}
						return false;
					}
					return true;
				}
				return false;
			}
			return true;
		}

		[SpecialName]
		public bool a()
		{
			return this.m_h;
		}

		[SpecialName]
		public bool b()
		{
			return this.m_b;
		}

		[SpecialName]
		public bool g()
		{
			return i;
		}

		[SpecialName]
		public eo.a h()
		{
			return j;
		}
	}

	public enum b
	{
		a = -1,
		b = -2
	}

	private enum c
	{
		a,
		b
	}

	public struct d
	{
		public bool a;

		public bool b;

		public bool c;
	}

	public enum e
	{
		a,
		b,
		c
	}

	public enum f : short
	{
		a,
		b,
		c
	}

	private IContainer m_a;

	[CompilerGenerated]
	private TableLayoutPanel m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private Button m_e;

	[CompilerGenerated]
	private Label m_f;

	[CompilerGenerated]
	private Label m_g;

	[CompilerGenerated]
	private TableLayoutPanel m_h;

	[CompilerGenerated]
	private TableLayoutPanel m_i;

	[CompilerGenerated]
	private ToolStrip m_j;

	[CompilerGenerated]
	private ToolStripButton m_k;

	[CompilerGenerated]
	private ToolStripButton m_l;

	[CompilerGenerated]
	private ToolStripButton m_m;

	[CompilerGenerated]
	private ToolStripButton m_n;

	[CompilerGenerated]
	private TabControl m_o;

	[CompilerGenerated]
	private TabPage m_p;

	[CompilerGenerated]
	private TabPage m_q;

	[CompilerGenerated]
	private Button r;

	[CompilerGenerated]
	private Label s;

	[CompilerGenerated]
	private ComboBox m_t;

	[CompilerGenerated]
	private Panel m_u;

	[CompilerGenerated]
	private TableLayoutPanel m_v;

	[CompilerGenerated]
	private Button m_w;

	[CompilerGenerated]
	private GroupBox m_x;

	[CompilerGenerated]
	private Label m_y;

	[CompilerGenerated]
	private hy m_z;

	[CompilerGenerated]
	private Label m_aa;

	[CompilerGenerated]
	private GroupBox m_ab;

	[CompilerGenerated]
	private Label m_ac;

	[CompilerGenerated]
	private CheckBox m_ad;

	[CompilerGenerated]
	private GroupBox ae;

	[CompilerGenerated]
	private CheckBox m_af;

	[CompilerGenerated]
	private GroupBox ag;

	[CompilerGenerated]
	private hy ah;

	[CompilerGenerated]
	private Label ai;

	[CompilerGenerated]
	private hy aj;

	[CompilerGenerated]
	private hy ak;

	[CompilerGenerated]
	private Label m_al;

	[CompilerGenerated]
	private Label m_am;

	[CompilerGenerated]
	private Label m_an;

	[CompilerGenerated]
	private Label m_ao;

	[CompilerGenerated]
	private CheckBox ap;

	[CompilerGenerated]
	private GroupBox m_aq;

	[CompilerGenerated]
	private RadioButton m_ar;

	[CompilerGenerated]
	private RadioButton @as;

	[CompilerGenerated]
	private GroupBox at;

	[CompilerGenerated]
	private hy au;

	[CompilerGenerated]
	private hy av;

	[CompilerGenerated]
	private Label aw;

	[CompilerGenerated]
	private Label ax;

	[CompilerGenerated]
	private Label ay;

	[CompilerGenerated]
	private Label az;

	[CompilerGenerated]
	private CheckBox a0;

	[CompilerGenerated]
	private CheckBox m_a1;

	[CompilerGenerated]
	private TabPage m_a2;

	[CompilerGenerated]
	private TabPage m_a3;

	[CompilerGenerated]
	private TabPage a4;

	[CompilerGenerated]
	private hy a5;

	[CompilerGenerated]
	private hy a6;

	[CompilerGenerated]
	private Label a7;

	[CompilerGenerated]
	private Label a8;

	[CompilerGenerated]
	private Label a9;

	[CompilerGenerated]
	private Label ba;

	[CompilerGenerated]
	private Label bb;

	[CompilerGenerated]
	private Label bc;

	[CompilerGenerated]
	private CheckBox m_bd;

	[CompilerGenerated]
	private TabPage m_be;

	[CompilerGenerated]
	private Button m_bf;

	[CompilerGenerated]
	private Button m_bg;

	[CompilerGenerated]
	private GroupBox m_bh;

	[CompilerGenerated]
	private RadioButton m_bi;

	[CompilerGenerated]
	private RadioButton m_bj;

	[CompilerGenerated]
	private RadioButton m_bk;

	[CompilerGenerated]
	private RadioButton m_bl;

	[CompilerGenerated]
	private GroupBox m_bm;

	[CompilerGenerated]
	private RadioButton m_bn;

	[CompilerGenerated]
	private RadioButton m_bo;

	[CompilerGenerated]
	private GroupBox m_bp;

	[CompilerGenerated]
	private Label m_bq;

	[CompilerGenerated]
	private Label m_br;

	[CompilerGenerated]
	private Label m_bs;

	[CompilerGenerated]
	private RadioButton m_bt;

	[CompilerGenerated]
	private GroupBox m_bu;

	[CompilerGenerated]
	private hy m_bv;

	[CompilerGenerated]
	private Label m_bw;

	[CompilerGenerated]
	private Label m_bx;

	[CompilerGenerated]
	private GroupBox m_by;

	[CompilerGenerated]
	private Label m_bz;

	[CompilerGenerated]
	private Label m_b0;

	[CompilerGenerated]
	private Label m_b1;

	[CompilerGenerated]
	private hy m_b2;

	[CompilerGenerated]
	private hy m_b3;

	[CompilerGenerated]
	private hy m_b4;

	[CompilerGenerated]
	private hy m_b5;

	[CompilerGenerated]
	private Label m_b6;

	[CompilerGenerated]
	private Button m_b7;

	[CompilerGenerated]
	private Button m_b8;

	[CompilerGenerated]
	private GroupBox m_b9;

	[CompilerGenerated]
	private CheckBox m_ca;

	[CompilerGenerated]
	private TabControl m_cb;

	[CompilerGenerated]
	private TabPage m_cc;

	[CompilerGenerated]
	private RadioButton m_cd;

	[CompilerGenerated]
	private RadioButton m_ce;

	[CompilerGenerated]
	private RadioButton m_cf;

	[CompilerGenerated]
	private RadioButton m_cg;

	[CompilerGenerated]
	private TabPage m_ch;

	[CompilerGenerated]
	private RadioButton m_ci;

	[CompilerGenerated]
	private RadioButton m_cj;

	[CompilerGenerated]
	private RadioButton m_ck;

	[CompilerGenerated]
	private RadioButton m_cl;

	[CompilerGenerated]
	private GroupBox m_cm;

	[CompilerGenerated]
	private GroupBox m_cn;

	[CompilerGenerated]
	private RadioButton m_co;

	[CompilerGenerated]
	private RadioButton m_cp;

	[CompilerGenerated]
	private GroupBox m_cq;

	[CompilerGenerated]
	private Label m_cr;

	[CompilerGenerated]
	private Label m_cs;

	[CompilerGenerated]
	private Label m_ct;

	[CompilerGenerated]
	private RadioButton m_cu;

	[CompilerGenerated]
	private GroupBox m_cv;

	[CompilerGenerated]
	private hy m_cw;

	[CompilerGenerated]
	private Label m_cx;

	[CompilerGenerated]
	private Label m_cy;

	[CompilerGenerated]
	private GroupBox m_cz;

	[CompilerGenerated]
	private TabControl m_c0;

	[CompilerGenerated]
	private TabPage m_c1;

	[CompilerGenerated]
	private Label m_c2;

	[CompilerGenerated]
	private Label m_c3;

	[CompilerGenerated]
	private Label m_c4;

	[CompilerGenerated]
	private hy m_c5;

	[CompilerGenerated]
	private hy m_c6;

	[CompilerGenerated]
	private hy m_c7;

	[CompilerGenerated]
	private hy m_c8;

	[CompilerGenerated]
	private Label m_c9;

	[CompilerGenerated]
	private TabPage m_da;

	[CompilerGenerated]
	private Label m_db;

	[CompilerGenerated]
	private Label m_dc;

	[CompilerGenerated]
	private Label m_dd;

	[CompilerGenerated]
	private Label m_de;

	[CompilerGenerated]
	private hy m_df;

	[CompilerGenerated]
	private hy m_dg;

	[CompilerGenerated]
	private hy m_dh;

	[CompilerGenerated]
	private hy m_di;

	[CompilerGenerated]
	private Button m_dj;

	[CompilerGenerated]
	private ToolTip m_dk;

	[CompilerGenerated]
	private CheckBox m_dl;

	[CompilerGenerated]
	private TableLayoutPanel dm;

	[CompilerGenerated]
	private Button dn;

	[CompilerGenerated]
	private Button @do;

	[CompilerGenerated]
	private TextBox m_dp;

	[CompilerGenerated]
	private PictureBox dq;

	[CompilerGenerated]
	private Label dr;

	[CompilerGenerated]
	private Label ds;

	[CompilerGenerated]
	private Button dt;

	[CompilerGenerated]
	private hy du;

	[CompilerGenerated]
	private hy dv;

	[CompilerGenerated]
	private Label dw;

	[CompilerGenerated]
	private Label dx;

	[CompilerGenerated]
	private CheckBox dy;

	[CompilerGenerated]
	private Label dz;

	[CompilerGenerated]
	private hy d0;

	[CompilerGenerated]
	private Label d1;

	[CompilerGenerated]
	private Label m_d2;

	[CompilerGenerated]
	private PictureBox d3;

	[CompilerGenerated]
	private CheckBox d4;

	[CompilerGenerated]
	private Label d5;

	[CompilerGenerated]
	private Button m_d6;

	[CompilerGenerated]
	private PictureBox d7;

	[CompilerGenerated]
	private Label d8;

	[CompilerGenerated]
	private CheckBox d9;

	[CompilerGenerated]
	private Label ea;

	[CompilerGenerated]
	private Label eb;

	[CompilerGenerated]
	private hy ec;

	[CompilerGenerated]
	private Label ed;

	[CompilerGenerated]
	private hy ee;

	[CompilerGenerated]
	private Label m_ef;

	[CompilerGenerated]
	private PictureBox eg;

	[CompilerGenerated]
	private Label m_eh;

	[CompilerGenerated]
	private ComboBox ei;

	[CompilerGenerated]
	private CheckBox ej;

	[CompilerGenerated]
	private hy ek;

	[CompilerGenerated]
	private Label el;

	[CompilerGenerated]
	private Label em;

	[CompilerGenerated]
	private Label en;

	[CompilerGenerated]
	private Label eo;

	[CompilerGenerated]
	private Label m_ep;

	[CompilerGenerated]
	private PictureBox m_eq;

	[CompilerGenerated]
	private PictureBox m_er;

	[CompilerGenerated]
	private PictureBox m_es;

	[CompilerGenerated]
	private ContextMenuStrip m_et;

	[CompilerGenerated]
	private TableLayoutPanel m_eu;

	[CompilerGenerated]
	private GroupBox m_ev;

	[CompilerGenerated]
	private GroupBox m_ew;

	[CompilerGenerated]
	private RadioButton m_ex;

	[CompilerGenerated]
	private GroupBox m_ey;

	[CompilerGenerated]
	private RadioButton m_ez;

	[CompilerGenerated]
	private GroupBox m_e0;

	[CompilerGenerated]
	private Label m_e1;

	[CompilerGenerated]
	private Label m_e2;

	[CompilerGenerated]
	private RadioButton m_e3;

	[CompilerGenerated]
	private RadioButton m_e4;

	[CompilerGenerated]
	private Panel m_e5;

	[CompilerGenerated]
	private TableLayoutPanel m_e6;

	[CompilerGenerated]
	private Panel m_e7;

	[CompilerGenerated]
	private TableLayoutPanel m_e8;

	[CompilerGenerated]
	private Label m_e9;

	[CompilerGenerated]
	private Panel m_fa;

	[CompilerGenerated]
	private TabControl m_fb;

	[CompilerGenerated]
	private TabPage m_fc;

	[CompilerGenerated]
	private TabPage fd;

	[CompilerGenerated]
	private Label fe;

	[CompilerGenerated]
	private Label ff;

	[CompilerGenerated]
	private Label fg;

	[CompilerGenerated]
	private Label fh;

	[CompilerGenerated]
	private Label fi;

	[CompilerGenerated]
	private Label fj;

	[CompilerGenerated]
	private Label fk;

	[CompilerGenerated]
	private Label fl;

	[CompilerGenerated]
	private Label fm;

	[CompilerGenerated]
	private Button fn;

	[CompilerGenerated]
	private Label fo;

	[CompilerGenerated]
	private Label fp;

	[CompilerGenerated]
	private Label fq;

	[CompilerGenerated]
	private GroupBox m_fr;

	[CompilerGenerated]
	private Panel m_fs;

	[CompilerGenerated]
	private RadioButton m_ft;

	[CompilerGenerated]
	private RadioButton m_fu;

	[CompilerGenerated]
	private CheckBox m_fv;

	[CompilerGenerated]
	private RadioButton m_fw;

	[CompilerGenerated]
	private RadioButton fx;

	[CompilerGenerated]
	private hy fy;

	[CompilerGenerated]
	private hy m_fz;

	[CompilerGenerated]
	private CheckBox f0;

	[CompilerGenerated]
	private hy f1;

	[CompilerGenerated]
	private Button f2;

	[CompilerGenerated]
	private hy f3;

	[CompilerGenerated]
	private Label f4;

	[CompilerGenerated]
	private Button f5;

	[CompilerGenerated]
	private GroupBox m_f6;

	[CompilerGenerated]
	private Panel m_f7;

	[CompilerGenerated]
	private RadioButton m_f8;

	[CompilerGenerated]
	private RadioButton m_f9;

	[CompilerGenerated]
	private RadioButton m_ga;

	[CompilerGenerated]
	private RadioButton m_gb;

	[CompilerGenerated]
	private CheckBox gc;

	[CompilerGenerated]
	private hy gd;

	[CompilerGenerated]
	private hy m_ge;

	[CompilerGenerated]
	private CheckBox gf;

	[CompilerGenerated]
	private hy gg;

	[CompilerGenerated]
	private Button gh;

	[CompilerGenerated]
	private hy gi;

	[CompilerGenerated]
	private Label gj;

	[CompilerGenerated]
	private GroupBox m_gk;

	[CompilerGenerated]
	private Panel m_gl;

	[CompilerGenerated]
	private RadioButton m_gm;

	[CompilerGenerated]
	private RadioButton m_gn;

	[CompilerGenerated]
	private RadioButton m_go;

	[CompilerGenerated]
	private RadioButton m_gp;

	[CompilerGenerated]
	private CheckBox gq;

	[CompilerGenerated]
	private hy gr;

	[CompilerGenerated]
	private hy m_gs;

	[CompilerGenerated]
	private CheckBox gt;

	[CompilerGenerated]
	private hy gu;

	[CompilerGenerated]
	private Button gv;

	[CompilerGenerated]
	private hy gw;

	[CompilerGenerated]
	private Label gx;

	[CompilerGenerated]
	private GroupBox m_gy;

	[CompilerGenerated]
	private Panel m_gz;

	[CompilerGenerated]
	private RadioButton m_g0;

	[CompilerGenerated]
	private RadioButton m_g1;

	[CompilerGenerated]
	private RadioButton m_g2;

	[CompilerGenerated]
	private RadioButton m_g3;

	[CompilerGenerated]
	private CheckBox g4;

	[CompilerGenerated]
	private hy g5;

	[CompilerGenerated]
	private hy m_g6;

	[CompilerGenerated]
	private CheckBox g7;

	[CompilerGenerated]
	private hy g8;

	[CompilerGenerated]
	private Button g9;

	[CompilerGenerated]
	private hy ha;

	[CompilerGenerated]
	private Label hb;

	[CompilerGenerated]
	private GroupBox m_hc;

	[CompilerGenerated]
	private Panel m_hd;

	[CompilerGenerated]
	private RadioButton m_he;

	[CompilerGenerated]
	private RadioButton m_hf;

	[CompilerGenerated]
	private RadioButton m_hg;

	[CompilerGenerated]
	private RadioButton m_hh;

	[CompilerGenerated]
	private CheckBox hi;

	[CompilerGenerated]
	private hy hj;

	[CompilerGenerated]
	private hy m_hk;

	[CompilerGenerated]
	private CheckBox hl;

	[CompilerGenerated]
	private hy hm;

	[CompilerGenerated]
	private Button hn;

	[CompilerGenerated]
	private hy ho;

	[CompilerGenerated]
	private Label hp;

	[CompilerGenerated]
	private GroupBox m_hq;

	[CompilerGenerated]
	private Panel m_hr;

	[CompilerGenerated]
	private RadioButton m_hs;

	[CompilerGenerated]
	private RadioButton m_ht;

	[CompilerGenerated]
	private RadioButton m_hu;

	[CompilerGenerated]
	private RadioButton m_hv;

	[CompilerGenerated]
	private CheckBox hw;

	[CompilerGenerated]
	private hy hx;

	[CompilerGenerated]
	private hy m_hy;

	[CompilerGenerated]
	private CheckBox hz;

	[CompilerGenerated]
	private hy h0;

	[CompilerGenerated]
	private Button h1;

	[CompilerGenerated]
	private hy h2;

	[CompilerGenerated]
	private Label h3;

	[CompilerGenerated]
	private Button h4;

	[CompilerGenerated]
	private Button h5;

	[CompilerGenerated]
	private Button h6;

	[CompilerGenerated]
	private Button h7;

	[CompilerGenerated]
	private Label m_h8;

	[CompilerGenerated]
	private TabPage m_h9;

	[CompilerGenerated]
	private GroupBox m_ia;

	[CompilerGenerated]
	private Label m_ib;

	[CompilerGenerated]
	private Label m_ic;

	[CompilerGenerated]
	private hy m_id;

	[CompilerGenerated]
	private Label m_ie;

	[CompilerGenerated]
	private Button m_if;

	[CompilerGenerated]
	private Label m_ig;

	[CompilerGenerated]
	private Label m_ih;

	[CompilerGenerated]
	private Button m_ii;

	[CompilerGenerated]
	private TableLayoutPanel m_ij;

	[CompilerGenerated]
	private hy m_ik;

	[CompilerGenerated]
	private Label m_il;

	[CompilerGenerated]
	private Panel m_im;

	[CompilerGenerated]
	private Panel m_in;

	[CompilerGenerated]
	private TableLayoutPanel m_io;

	[CompilerGenerated]
	private Label m_ip;

	[CompilerGenerated]
	private Label m_iq;

	[CompilerGenerated]
	private Label m_ir;

	[CompilerGenerated]
	private Label m_is;

	[CompilerGenerated]
	private TabPage m_it;

	[CompilerGenerated]
	private Panel iu;

	[CompilerGenerated]
	private GroupBox iv;

	[CompilerGenerated]
	private ComboBox iw;

	[CompilerGenerated]
	private GroupBox ix;

	[CompilerGenerated]
	private RadioButton iy;

	[CompilerGenerated]
	private RadioButton iz;

	[CompilerGenerated]
	private RadioButton i0;

	[CompilerGenerated]
	private RadioButton i1;

	[CompilerGenerated]
	private GroupBox i2;

	[CompilerGenerated]
	private ComboBox i3;

	[CompilerGenerated]
	private ComboBox i4;

	[CompilerGenerated]
	private Label i5;

	[CompilerGenerated]
	private Label i6;

	[CompilerGenerated]
	private Label i7;

	[CompilerGenerated]
	private Label i8;

	[CompilerGenerated]
	private Label i9;

	[CompilerGenerated]
	private GroupBox ja;

	[CompilerGenerated]
	private CheckBox jb;

	[CompilerGenerated]
	private CheckBox jc;

	[CompilerGenerated]
	private GroupBox jd;

	[CompilerGenerated]
	private Label je;

	[CompilerGenerated]
	private Label jf;

	[CompilerGenerated]
	private Label jg;

	[CompilerGenerated]
	private Label jh;

	[CompilerGenerated]
	private Label ji;

	[CompilerGenerated]
	private Label jj;

	[CompilerGenerated]
	private CheckBox jk;

	[CompilerGenerated]
	private CheckBox jl;

	[CompilerGenerated]
	private GroupBox jm;

	[CompilerGenerated]
	private CheckBox jn;

	[CompilerGenerated]
	private CheckBox jo;

	[CompilerGenerated]
	private CheckBox jp;

	[CompilerGenerated]
	private CheckBox jq;

	[CompilerGenerated]
	private GroupBox jr;

	[CompilerGenerated]
	private RadioButton js;

	[CompilerGenerated]
	private RadioButton jt;

	[CompilerGenerated]
	private Label ju;

	[CompilerGenerated]
	private Label jv;

	[CompilerGenerated]
	private Label jw;

	[CompilerGenerated]
	private Label jx;

	[CompilerGenerated]
	private Label jy;

	[CompilerGenerated]
	private Label jz;

	[CompilerGenerated]
	private CheckBox j0;

	[CompilerGenerated]
	private CheckBox m_j1;

	[CompilerGenerated]
	private hy m_j2;

	[CompilerGenerated]
	private hy m_j3;

	[CompilerGenerated]
	private hy m_j4;

	[CompilerGenerated]
	private hy m_j5;

	[CompilerGenerated]
	private hy m_j6;

	[CompilerGenerated]
	private hy m_j7;

	[CompilerGenerated]
	private hy m_j8;

	[CompilerGenerated]
	private TabPage m_j9;

	[CompilerGenerated]
	private Label m_ka;

	[CompilerGenerated]
	private Label m_kb;

	[CompilerGenerated]
	private Label m_kc;

	[CompilerGenerated]
	private hy m_kd;

	[CompilerGenerated]
	private hy m_ke;

	[CompilerGenerated]
	private hy m_kf;

	[CompilerGenerated]
	private hy m_kg;

	[CompilerGenerated]
	private Label m_kh;

	[CompilerGenerated]
	private TabPage m_ki;

	[CompilerGenerated]
	private RadioButton m_kj;

	[CompilerGenerated]
	private RadioButton m_kk;

	[CompilerGenerated]
	private RadioButton m_kl;

	[CompilerGenerated]
	private RadioButton m_km;

	[CompilerGenerated]
	private CheckBox m_kn;

	[CompilerGenerated]
	private CheckBox m_ko;

	[CompilerGenerated]
	private CheckBox m_kp;

	[CompilerGenerated]
	private CheckBox m_kq;

	[CompilerGenerated]
	private CheckBox m_kr;

	[CompilerGenerated]
	private CheckBox m_ks;

	[CompilerGenerated]
	private CheckBox m_kt;

	[CompilerGenerated]
	private CheckBox m_ku;

	[CompilerGenerated]
	private TableLayoutPanel m_kv;

	[CompilerGenerated]
	private TableLayoutPanel m_kw;

	[CompilerGenerated]
	private Panel m_kx;

	[CompilerGenerated]
	private hy m_ky;

	[CompilerGenerated]
	private hy m_kz;

	[CompilerGenerated]
	private Label m_k0;

	[CompilerGenerated]
	private Label m_k1;

	[CompilerGenerated]
	private Label m_k2;

	[CompilerGenerated]
	private Label m_k3;

	[CompilerGenerated]
	private TableLayoutPanel m_k4;

	[CompilerGenerated]
	private CheckBox m_k5;

	[CompilerGenerated]
	private Label m_k6;

	[CompilerGenerated]
	private Label m_k7;

	[CompilerGenerated]
	private hy m_k8;

	[CompilerGenerated]
	private hy m_k9;

	[CompilerGenerated]
	private hy m_la;

	[CompilerGenerated]
	private hy m_lb;

	[CompilerGenerated]
	private hy m_lc;

	[CompilerGenerated]
	private hy m_ld;

	[CompilerGenerated]
	private Label m_le;

	[CompilerGenerated]
	private Label m_lf;

	[CompilerGenerated]
	private Label m_lg;

	[CompilerGenerated]
	private GroupBox m_lh;

	[CompilerGenerated]
	private RadioButton m_li;

	[CompilerGenerated]
	private RadioButton m_lj;

	[CompilerGenerated]
	private RadioButton m_lk;

	[CompilerGenerated]
	private ToolStripButton m_ll;

	[CompilerGenerated]
	private ToolStripSeparator m_lm;

	[CompilerGenerated]
	private Button m_ln;

	[CompilerGenerated]
	private TableLayoutPanel m_lo;

	[CompilerGenerated]
	private TableLayoutPanel m_lp;

	[CompilerGenerated]
	private ComboBox m_lq;

	[CompilerGenerated]
	private Label m_lr;

	[CompilerGenerated]
	private DataGridView m_ls;

	[CompilerGenerated]
	private TableLayoutPanel m_lt;

	[CompilerGenerated]
	private TableLayoutPanel m_lu;

	[CompilerGenerated]
	private GroupBox m_lv;

	[CompilerGenerated]
	private CheckBox m_lw;

	[CompilerGenerated]
	private GroupBox m_lx;

	[CompilerGenerated]
	private hy m_ly;

	[CompilerGenerated]
	private Label m_lz;

	[CompilerGenerated]
	private Label m_l0;

	[CompilerGenerated]
	private hy m_l1;

	[CompilerGenerated]
	private Label m_l2;

	[CompilerGenerated]
	private hy m_l3;

	[CompilerGenerated]
	private Label m_l4;

	[CompilerGenerated]
	private Label m_l5;

	[CompilerGenerated]
	private TableLayoutPanel m_l6;

	[CompilerGenerated]
	private TabPage m_l7;

	[CompilerGenerated]
	private Panel m_l8;

	[CompilerGenerated]
	private TableLayoutPanel m_l9;

	[CompilerGenerated]
	private TableLayoutPanel m_ma;

	[CompilerGenerated]
	private Label m_mb;

	[CompilerGenerated]
	private NumericUpDown m_mc;

	[CompilerGenerated]
	private CheckBox m_md;

	[CompilerGenerated]
	private TableLayoutPanel m_me;

	[CompilerGenerated]
	private ComboBox m_mf;

	[CompilerGenerated]
	private Label m_mg;

	[CompilerGenerated]
	private TableLayoutPanel m_mh;

	[CompilerGenerated]
	private Label m_mi;

	[CompilerGenerated]
	private hy m_mj;

	[CompilerGenerated]
	private RadioButton m_mk;

	[CompilerGenerated]
	private RadioButton m_ml;

	[CompilerGenerated]
	private CheckBox m_mm;

	[CompilerGenerated]
	private Label m_mn;

	[CompilerGenerated]
	private TableLayoutPanel m_mo;

	[CompilerGenerated]
	private Label m_mp;

	[CompilerGenerated]
	private hy m_mq;

	[CompilerGenerated]
	private Label m_mr;

	[CompilerGenerated]
	private TableLayoutPanel m_ms;

	[CompilerGenerated]
	private Label m_mt;

	[CompilerGenerated]
	private NumericUpDown m_mu;

	[CompilerGenerated]
	private CheckBox m_mv;

	[CompilerGenerated]
	private TableLayoutPanel m_mw;

	[CompilerGenerated]
	private Label m_mx;

	[CompilerGenerated]
	private CheckBox m_my;

	[CompilerGenerated]
	private NumericUpDown m_mz;

	[CompilerGenerated]
	private TableLayoutPanel m_m0;

	[CompilerGenerated]
	private CheckBox m_m1;

	[CompilerGenerated]
	private Label m_m2;

	[CompilerGenerated]
	private NumericUpDown m_m3;

	[CompilerGenerated]
	private TableLayoutPanel m_m4;

	[CompilerGenerated]
	private Label m_m5;

	[CompilerGenerated]
	private ComboBox m_m6;

	[CompilerGenerated]
	private TableLayoutPanel m_m7;

	[CompilerGenerated]
	private hy m_m8;

	[CompilerGenerated]
	private Label m_m9;

	[CompilerGenerated]
	private GroupBox m_na;

	[CompilerGenerated]
	private RadioButton m_nb;

	[CompilerGenerated]
	private RadioButton m_nc;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_nd;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_ne;

	[CompilerGenerated]
	private DataGridViewCheckBoxColumn m_nf;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_ng;

	[CompilerGenerated]
	private TabPage m_nh;

	[CompilerGenerated]
	private GroupBox ni;

	[CompilerGenerated]
	private Button nj;

	[CompilerGenerated]
	private TextBox nk;

	[CompilerGenerated]
	private Label m_nl;

	[CompilerGenerated]
	private CheckBox m_nm;

	[CompilerGenerated]
	private Panel m_nn;

	[CompilerGenerated]
	private TableLayoutPanel m_no;

	[CompilerGenerated]
	private Panel m_np;

	[CompilerGenerated]
	private Panel m_nq;

	[CompilerGenerated]
	private Label m_nr;

	[CompilerGenerated]
	private CheckBox m_ns;

	[CompilerGenerated]
	private TextBox m_nt;

	[CompilerGenerated]
	private Button nu;

	[CompilerGenerated]
	private Label m_nv;

	[CompilerGenerated]
	private CheckBox m_nw;

	[CompilerGenerated]
	private CheckBox m_nx;

	[CompilerGenerated]
	private CheckBox m_ny;

	[CompilerGenerated]
	private CheckBox m_nz;

	[CompilerGenerated]
	private CheckBox m_n0;

	[CompilerGenerated]
	private CheckBox m_n1;

	[CompilerGenerated]
	private TableLayoutPanel n2;

	[CompilerGenerated]
	private GroupBox m_n3;

	[CompilerGenerated]
	private hy m_n4;

	[CompilerGenerated]
	private hy n5;

	[CompilerGenerated]
	private Label n6;

	[CompilerGenerated]
	private Label n7;

	[CompilerGenerated]
	private Label m_n8;

	[CompilerGenerated]
	private hy n9;

	[CompilerGenerated]
	private RadioButton oa;

	[CompilerGenerated]
	private RadioButton ob;

	[CompilerGenerated]
	private Label m_oc;

	[CompilerGenerated]
	private NumericUpDown m_od;

	[CompilerGenerated]
	private GroupBox m_oe;

	[CompilerGenerated]
	private GroupBox of;

	[CompilerGenerated]
	private RadioButton og;

	[CompilerGenerated]
	private RadioButton m_oh;

	[CompilerGenerated]
	private GroupBox oi;

	[CompilerGenerated]
	private CheckBox m_oj;

	[CompilerGenerated]
	private Button m_ok;

	[CompilerGenerated]
	private ErrorProvider m_ol;

	[CompilerGenerated]
	private Label m_om;

	[CompilerGenerated]
	private hy m_on;

	[CompilerGenerated]
	private TableLayoutPanel m_oo;

	[CompilerGenerated]
	private GroupBox m_op;

	[CompilerGenerated]
	private RadioButton m_oq;

	[CompilerGenerated]
	private RadioButton m_or;

	[CompilerGenerated]
	private RadioButton m_os;

	[CompilerGenerated]
	private CheckBox m_ot;

	[CompilerGenerated]
	private Label m_ou;

	[CompilerGenerated]
	private Label m_ov;

	[CompilerGenerated]
	private hy m_ow;

	[CompilerGenerated]
	private Button m_ox;

	[CompilerGenerated]
	private GroupBox m_oy;

	[CompilerGenerated]
	private Label m_oz;

	[CompilerGenerated]
	private Label m_o0;

	[CompilerGenerated]
	private Label m_o1;

	[CompilerGenerated]
	private hy m_o2;

	[CompilerGenerated]
	private CheckBox m_o3;

	[CompilerGenerated]
	private GroupBox m_o4;

	[CompilerGenerated]
	private Button m_o5;

	[CompilerGenerated]
	private TableLayoutPanel m_o6;

	[CompilerGenerated]
	private Panel m_o7;

	[CompilerGenerated]
	private CheckBox m_o8;

	[CompilerGenerated]
	private CheckBox m_o9;

	[CompilerGenerated]
	private Panel pa;

	[CompilerGenerated]
	private Label pb;

	[CompilerGenerated]
	private Label pc;

	[CompilerGenerated]
	private Label pd;

	[CompilerGenerated]
	private Label pe;

	[CompilerGenerated]
	private Button pf;

	[CompilerGenerated]
	private Label pg;

	[CompilerGenerated]
	private Label ph;

	[CompilerGenerated]
	private Label pi;

	[CompilerGenerated]
	private Label pj;

	[CompilerGenerated]
	private Label pk;

	[CompilerGenerated]
	private GroupBox m_pl;

	[CompilerGenerated]
	private RadioButton m_pm;

	[CompilerGenerated]
	private RadioButton m_pn;

	[CompilerGenerated]
	private CheckBox po;

	[CompilerGenerated]
	private hy pp;

	[CompilerGenerated]
	private hy pq;

	[CompilerGenerated]
	private Button pr;

	[CompilerGenerated]
	private hy ps;

	[CompilerGenerated]
	private hy pt;

	[CompilerGenerated]
	private Label pu;

	[CompilerGenerated]
	private Button pv;

	[CompilerGenerated]
	private GroupBox m_pw;

	[CompilerGenerated]
	private RadioButton m_px;

	[CompilerGenerated]
	private RadioButton m_py;

	[CompilerGenerated]
	private CheckBox pz;

	[CompilerGenerated]
	private hy p0;

	[CompilerGenerated]
	private hy p1;

	[CompilerGenerated]
	private hy p2;

	[CompilerGenerated]
	private Button p3;

	[CompilerGenerated]
	private hy p4;

	[CompilerGenerated]
	private Label p5;

	[CompilerGenerated]
	private GroupBox m_p6;

	[CompilerGenerated]
	private RadioButton m_p7;

	[CompilerGenerated]
	private RadioButton m_p8;

	[CompilerGenerated]
	private CheckBox p9;

	[CompilerGenerated]
	private hy qa;

	[CompilerGenerated]
	private hy qb;

	[CompilerGenerated]
	private hy qc;

	[CompilerGenerated]
	private Button qd;

	[CompilerGenerated]
	private hy qe;

	[CompilerGenerated]
	private Label qf;

	[CompilerGenerated]
	private GroupBox m_qg;

	[CompilerGenerated]
	private RadioButton m_qh;

	[CompilerGenerated]
	private RadioButton m_qi;

	[CompilerGenerated]
	private CheckBox qj;

	[CompilerGenerated]
	private hy qk;

	[CompilerGenerated]
	private hy ql;

	[CompilerGenerated]
	private hy qm;

	[CompilerGenerated]
	private Button qn;

	[CompilerGenerated]
	private hy qo;

	[CompilerGenerated]
	private Label qp;

	[CompilerGenerated]
	private GroupBox m_qq;

	[CompilerGenerated]
	private RadioButton m_qr;

	[CompilerGenerated]
	private RadioButton m_qs;

	[CompilerGenerated]
	private CheckBox qt;

	[CompilerGenerated]
	private hy qu;

	[CompilerGenerated]
	private hy qv;

	[CompilerGenerated]
	private hy qw;

	[CompilerGenerated]
	private Button qx;

	[CompilerGenerated]
	private hy qy;

	[CompilerGenerated]
	private Label qz;

	[CompilerGenerated]
	private GroupBox m_q0;

	[CompilerGenerated]
	private RadioButton m_q1;

	[CompilerGenerated]
	private RadioButton m_q2;

	[CompilerGenerated]
	private CheckBox q3;

	[CompilerGenerated]
	private hy q4;

	[CompilerGenerated]
	private hy q5;

	[CompilerGenerated]
	private hy q6;

	[CompilerGenerated]
	private Button q7;

	[CompilerGenerated]
	private hy q8;

	[CompilerGenerated]
	private Label q9;

	[CompilerGenerated]
	private Button ra;

	[CompilerGenerated]
	private Button rb;

	[CompilerGenerated]
	private Button rc;

	[CompilerGenerated]
	private Button rd;

	[CompilerGenerated]
	private Label m_re;

	[CompilerGenerated]
	private GroupBox m_rf;

	[CompilerGenerated]
	private Label m_rg;

	[CompilerGenerated]
	private CheckBox rh;

	[CompilerGenerated]
	private Button ri;

	[CompilerGenerated]
	private GroupBox m_rj;

	[CompilerGenerated]
	private RadioButton m_rk;

	[CompilerGenerated]
	private RadioButton m_rl;

	[CompilerGenerated]
	private CheckBox rm;

	[CompilerGenerated]
	private hy rn;

	[CompilerGenerated]
	private hy ro;

	[CompilerGenerated]
	private hy rp;

	[CompilerGenerated]
	private Button rq;

	[CompilerGenerated]
	private hy rr;

	[CompilerGenerated]
	private Label rs;

	[CompilerGenerated]
	private Button rt;

	[CompilerGenerated]
	private GroupBox m_ru;

	[CompilerGenerated]
	private RadioButton m_rv;

	[CompilerGenerated]
	private RadioButton m_rw;

	[CompilerGenerated]
	private CheckBox rx;

	[CompilerGenerated]
	private hy ry;

	[CompilerGenerated]
	private hy rz;

	[CompilerGenerated]
	private hy r0;

	[CompilerGenerated]
	private Button r1;

	[CompilerGenerated]
	private hy r2;

	[CompilerGenerated]
	private Label r3;

	[CompilerGenerated]
	private Button r4;

	[CompilerGenerated]
	private GroupBox m_r5;

	[CompilerGenerated]
	private RadioButton m_r6;

	[CompilerGenerated]
	private RadioButton m_r7;

	[CompilerGenerated]
	private CheckBox r8;

	[CompilerGenerated]
	private hy r9;

	[CompilerGenerated]
	private hy sa;

	[CompilerGenerated]
	private hy sb;

	[CompilerGenerated]
	private Button sc;

	[CompilerGenerated]
	private hy sd;

	[CompilerGenerated]
	private Label se;

	[CompilerGenerated]
	private Button sf;

	[CompilerGenerated]
	private GroupBox m_sg;

	[CompilerGenerated]
	private RadioButton m_sh;

	[CompilerGenerated]
	private RadioButton m_si;

	[CompilerGenerated]
	private CheckBox sj;

	[CompilerGenerated]
	private hy sk;

	[CompilerGenerated]
	private hy sl;

	[CompilerGenerated]
	private hy sm;

	[CompilerGenerated]
	private Button sn;

	[CompilerGenerated]
	private hy so;

	[CompilerGenerated]
	private Label sp;

	[CompilerGenerated]
	private Button sq;

	[CompilerGenerated]
	private GroupBox m_sr;

	[CompilerGenerated]
	private RadioButton m_ss;

	[CompilerGenerated]
	private RadioButton m_st;

	[CompilerGenerated]
	private CheckBox su;

	[CompilerGenerated]
	private hy sv;

	[CompilerGenerated]
	private hy sw;

	[CompilerGenerated]
	private hy sx;

	[CompilerGenerated]
	private Button sy;

	[CompilerGenerated]
	private hy sz;

	[CompilerGenerated]
	private Label s0;

	[CompilerGenerated]
	private Button s1;

	[CompilerGenerated]
	private GroupBox m_s2;

	[CompilerGenerated]
	private RadioButton m_s3;

	[CompilerGenerated]
	private RadioButton m_s4;

	[CompilerGenerated]
	private CheckBox s5;

	[CompilerGenerated]
	private hy s6;

	[CompilerGenerated]
	private hy s7;

	[CompilerGenerated]
	private hy s8;

	[CompilerGenerated]
	private Button s9;

	[CompilerGenerated]
	private hy ta;

	[CompilerGenerated]
	private Label m_tb;

	[CompilerGenerated]
	private TableLayoutPanel m_tc;

	[CompilerGenerated]
	private Button m_td;

	[CompilerGenerated]
	private TableLayoutPanel m_te;

	[CompilerGenerated]
	private GroupBox m_tf;

	[CompilerGenerated]
	private CheckBox m_tg;

	[CompilerGenerated]
	private ToolTip m_th;

	[CompilerGenerated]
	private ToolTip m_ti;

	[CompilerGenerated]
	private ToolTip m_tj;

	[CompilerGenerated]
	private ToolTip m_tk;

	[CompilerGenerated]
	private ToolTip m_tl;

	[CompilerGenerated]
	private ToolTip m_tm;

	[CompilerGenerated]
	private Button m_tn;

	[CompilerGenerated]
	private TabPage m_to;

	[CompilerGenerated]
	private TabPage m_tp;

	[CompilerGenerated]
	private Panel tq;

	[CompilerGenerated]
	private GroupBox m_tr;

	[CompilerGenerated]
	private hy m_ts;

	[CompilerGenerated]
	private hy m_tt;

	[CompilerGenerated]
	private hy tu;

	[CompilerGenerated]
	private RadioButton tv;

	[CompilerGenerated]
	private RadioButton tw;

	[CompilerGenerated]
	private CheckBox tx;

	[CompilerGenerated]
	private CheckBox ty;

	[CompilerGenerated]
	private Label tz;

	[CompilerGenerated]
	private Label t0;

	[CompilerGenerated]
	private Label t1;

	[CompilerGenerated]
	private Label t2;

	[CompilerGenerated]
	private Label t3;

	[CompilerGenerated]
	private Label t4;

	[CompilerGenerated]
	private GroupBox m_t5;

	[CompilerGenerated]
	private Panel m_t6;

	[CompilerGenerated]
	private Label m_t7;

	[CompilerGenerated]
	private Label m_t8;

	[CompilerGenerated]
	private hy m_t9;

	[CompilerGenerated]
	private hy m_ua;

	[CompilerGenerated]
	private Label m_ub;

	[CompilerGenerated]
	private Label uc;

	[CompilerGenerated]
	private ComboBox ud;

	[CompilerGenerated]
	private GroupBox m_ue;

	[CompilerGenerated]
	private hy uf;

	[CompilerGenerated]
	private ComboBox ug;

	[CompilerGenerated]
	private ComboBox uh;

	[CompilerGenerated]
	private Label ui;

	[CompilerGenerated]
	private Label uj;

	[CompilerGenerated]
	private Label uk;

	[CompilerGenerated]
	private Label ul;

	[CompilerGenerated]
	private Label m_um;

	[CompilerGenerated]
	private Panel un;

	[CompilerGenerated]
	private GroupBox uo;

	[CompilerGenerated]
	private CheckBox up;

	[CompilerGenerated]
	private CheckBox uq;

	[CompilerGenerated]
	private CheckBox ur;

	[CompilerGenerated]
	private GroupBox us;

	[CompilerGenerated]
	private CheckBox ut;

	[CompilerGenerated]
	private GroupBox m_uu;

	[CompilerGenerated]
	private hy m_uv;

	[CompilerGenerated]
	private hy m_uw;

	[CompilerGenerated]
	private hy ux;

	[CompilerGenerated]
	private CheckBox uy;

	[CompilerGenerated]
	private Label uz;

	[CompilerGenerated]
	private Label u0;

	[CompilerGenerated]
	private Label u1;

	[CompilerGenerated]
	private Label u2;

	[CompilerGenerated]
	private Label u3;

	[CompilerGenerated]
	private Label u4;

	[CompilerGenerated]
	private CheckBox u5;

	[CompilerGenerated]
	private GroupBox m_u6;

	[CompilerGenerated]
	private Button m_u7;

	[CompilerGenerated]
	private CheckBox m_u8;

	[CompilerGenerated]
	private Button m_u9;

	[CompilerGenerated]
	private GroupBox m_va;

	[CompilerGenerated]
	private Label m_vb;

	[CompilerGenerated]
	private hy m_vc;

	[CompilerGenerated]
	private Label m_vd;

	[CompilerGenerated]
	private TableLayoutPanel m_ve;

	[CompilerGenerated]
	private TabPage m_vf;

	[CompilerGenerated]
	private CheckBox m_vg;

	[CompilerGenerated]
	private CheckBox m_vh;

	[CompilerGenerated]
	private GroupBox m_vi;

	[CompilerGenerated]
	private TableLayoutPanel m_vj;

	[CompilerGenerated]
	private RadioButton m_vk;

	[CompilerGenerated]
	private RadioButton m_vl;

	[CompilerGenerated]
	private TableLayoutPanel m_vm;

	[CompilerGenerated]
	private Label m_vn;

	[CompilerGenerated]
	private hy m_vo;

	[CompilerGenerated]
	private Label m_vp;

	[CompilerGenerated]
	private GroupBox m_vq;

	[CompilerGenerated]
	private TableLayoutPanel m_vr;

	[CompilerGenerated]
	private Label m_vs;

	[CompilerGenerated]
	private RadioButton m_vt;

	[CompilerGenerated]
	private hy m_vu;

	[CompilerGenerated]
	private Label m_vv;

	[CompilerGenerated]
	private hy m_vw;

	[CompilerGenerated]
	private Label m_vx;

	[CompilerGenerated]
	private hy m_vy;

	[CompilerGenerated]
	private RadioButton m_vz;

	[CompilerGenerated]
	private Label m_v0;

	[CompilerGenerated]
	private TableLayoutPanel m_v1;

	[CompilerGenerated]
	private GroupBox m_v2;

	[CompilerGenerated]
	private TableLayoutPanel m_v3;

	[CompilerGenerated]
	private Label m_v4;

	[CompilerGenerated]
	private TableLayoutPanel m_v5;

	[CompilerGenerated]
	private Label m_v6;

	[CompilerGenerated]
	private Label m_v7;

	[CompilerGenerated]
	private hy m_v8;

	[CompilerGenerated]
	private TableLayoutPanel m_v9;

	[CompilerGenerated]
	private RadioButton m_wa;

	[CompilerGenerated]
	private RadioButton m_wb;

	[CompilerGenerated]
	private GroupBox m_wc;

	[CompilerGenerated]
	private TableLayoutPanel m_wd;

	[CompilerGenerated]
	private TableLayoutPanel m_we;

	[CompilerGenerated]
	private Panel m_wf;

	[CompilerGenerated]
	private Panel m_wg;

	[CompilerGenerated]
	private Label m_wh;

	[CompilerGenerated]
	private Label m_wi;

	[CompilerGenerated]
	private Label m_wj;

	[CompilerGenerated]
	private hy m_wk;

	[CompilerGenerated]
	private hy m_wl;

	[CompilerGenerated]
	private Panel m_wm;

	[CompilerGenerated]
	private Label m_wn;

	[CompilerGenerated]
	private hy m_wo;

	[CompilerGenerated]
	private Label m_wp;

	[CompilerGenerated]
	private ToolTip m_wq;

	[CompilerGenerated]
	private GroupBox m_wr;

	[CompilerGenerated]
	private CheckBox m_ws;

	[CompilerGenerated]
	private GroupBox wt;

	[CompilerGenerated]
	private CheckBox m_wu;

	[CompilerGenerated]
	private hy m_wv;

	[CompilerGenerated]
	private hy ww;

	[CompilerGenerated]
	private Label wx;

	[CompilerGenerated]
	private Label wy;

	[CompilerGenerated]
	private Label wz;

	[CompilerGenerated]
	private Label m_w0;

	[CompilerGenerated]
	private RadioButton m_w1;

	[CompilerGenerated]
	private RadioButton m_w2;

	[CompilerGenerated]
	private hy m_w3;

	[CompilerGenerated]
	private Label m_w4;

	[CompilerGenerated]
	private RadioButton m_w5;

	[CompilerGenerated]
	private RadioButton m_w6;

	[CompilerGenerated]
	private RadioButton m_w7;

	[CompilerGenerated]
	private RadioButton m_w8;

	[CompilerGenerated]
	private RadioButton m_w9;

	[CompilerGenerated]
	private RadioButton m_xa;

	[CompilerGenerated]
	private RadioButton m_xb;

	[CompilerGenerated]
	private RadioButton m_xc;

	[CompilerGenerated]
	private RadioButton m_xd;

	[CompilerGenerated]
	private RadioButton m_xe;

	[CompilerGenerated]
	private RadioButton m_xf;

	[CompilerGenerated]
	private RadioButton xg;

	[CompilerGenerated]
	private Label xh;

	[CompilerGenerated]
	private Label m_xi;

	[CompilerGenerated]
	private RadioButton m_xj;

	[CompilerGenerated]
	private RadioButton m_xk;

	[CompilerGenerated]
	private RadioButton m_xl;

	[CompilerGenerated]
	private RadioButton m_xm;

	[CompilerGenerated]
	private RadioButton m_xn;

	[CompilerGenerated]
	private RadioButton m_xo;

	[CompilerGenerated]
	private Button m_xp;

	private object m_xq;

	private Guid m_xr;

	private Collection<Collection<Control>> m_xs;

	private Collection<Control> m_xt;

	private Collection<Label> m_xu;

	private Collection<Label> m_xv;

	private Collection<hy> m_xw;

	private Collection<hy> m_xx;

	private string m_xy;

	private bool m_xz;

	private string m_x0;

	private string m_x1;

	private hg m_x2;

	private bool m_x3;

	private hg m_x4;

	private DateTime m_x5;

	private f1 m_x6;

	private gq m_x7;

	private Collection<hy> m_x8;

	private Collection<hy> m_x9;

	private Collection<Button> m_ya;

	private Collection<hy> m_yb;

	private Collection<Label> m_yc;

	private Collection<Button> m_yd;

	private bx m_ye;

	private Collection<Collection<Control>> m_yf;

	private Collection<Control> m_yg;

	private Collection<Collection<Control>> m_yh;

	private Collection<Label> m_yi;

	private bx m_yj;

	private Collection<Collection<Control>> m_yk;

	private Collection<Control> m_yl;

	private bx m_ym;

	private Collection<Collection<Control>> m_yn;

	private Collection<Control> m_yo;

	private Collection<TextBox> m_yp;

	private Collection<hy> m_yq;

	private Collection<TableLayoutPanel> m_yr;

	private Collection<Button> m_ys;

	private Collection<hy> m_yt;

	private Collection<CheckBox> m_yu;

	private Collection<CheckBox> m_yv;

	private Collection<CheckBox> m_yw;

	private Collection<CheckBox> m_yx;

	private Collection<hy> m_yy;

	private Collection<Label> m_yz;

	private Collection<hy> m_y0;

	private Collection<ComboBox> m_y1;

	private Collection<Control> m_y2;

	private ge m_y3;

	private bool m_y4;

	private fz m_y5;

	private string m_y6;

	private gr m_y7;

	private float m_y8;

	private bool m_y9;

	private float[] m_za;

	private float[] m_zb;

	private List<it> m_zc;

	private hg m_zd;

	private hd m_ze;

	private int[] m_zf;

	private bool m_zg;

	private TabPage m_zh;

	private string m_zi;

	private r.d m_zj;

	private double m_zk;

	private Collection<Button> m_zl;

	private Collection<Button> m_zm;

	private Collection<Button> m_zn;

	private Collection<Button> m_zo;

	private Collection<CheckBox> m_zp;

	private Collection<CheckBox> m_zq;

	private Collection<CheckBox> m_zr;

	private Collection<CheckBox> m_zs;

	private Collection<GroupBox> m_zt;

	private Collection<GroupBox> m_zu;

	private bool m_zv;

	private Collection<hy> m_zw;

	private Collection<hy> m_zx;

	private Collection<hy> m_zy;

	private Collection<hy> m_zz;

	private Collection<Panel> m_z0;

	private Collection<RadioButton> m_z1;

	private Collection<RadioButton> m_z2;

	private Collection<RadioButton> m_z3;

	private Collection<RadioButton> m_z4;

	private Collection<RadioButton> m_z5;

	private Collection<RadioButton> m_z6;

	private Collection<RadioButton> m_z7;

	private Collection<RadioButton> m_z8;

	private bool m_z9;

	private Collection<hy> m_aaa;

	private Collection<hy> m_aab;

	private Collection<hy> m_aac;

	private Collection<hy> m_aad;

	private List<it> m_aae;

	private int m_aaf;

	private string m_aag;

	private a m_aah;

	private e m_aai;

	private int m_aaj;

	private bool m_aak;

	private d m_aal;

	private bool m_aam;

	private bool m_aan;

	private eo.b m_aao;

	private bool m_aap;

	private bool m_aaq;

	private bool m_aar;

	private bool m_aas;

	private bool m_aat;

	private bool m_aau;

	private bool m_aav;

	[CompilerGenerated]
	private r.aa m_aaw;

	private f m_aax;

	private bool[] m_aay;

	private string m_aaz;

	private bool[] m_aa0;

	private h.f[] m_aa1;

	private const string m_aa2 = "DialogEditRecipe";

	private const string m_aa3 = "\\MostRecentLayerMaterials.fmslf";

	private const string m_aa4 = "\\MostRecentMediumMaterials.fmslf";

	private const string m_aa5 = "\\MostRecentSubstrateMaterials.fmslf";

	private const string m_aa6 = "Grid";

	private const string m_aa7 = "FFT";

	private const string m_aa8 = "None";

	private const double m_aa9 = 100.0;

	private const float m_aba = 2000f;

	private const short m_abb = 100;

	private bool m_abc;

	private const string m_abd = "Spectrometer";

	private const string m_abe = "Photodiode";

	private iw m_abf;

	[CompilerGenerated]
	private System.Timers.Timer m_abg;

	private const int m_abh = 20;

	[SpecialName]
	private bool m_abi;

	[SpecialName]
	private bool m_abj;

	[SpecialName]
	private bool m_abk;

	[SpecialName]
	private bool m_abl;

	[SpecialName]
	private bool m_abm;

	[SpecialName]
	private bool m_abn;

	[SpecialName]
	private bool m_abo;

	[SpecialName]
	private bool m_abp;

	[SpecialName]
	private TabPage m_abq;

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.m_a != null)
			{
				this.m_a.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void b3()
	{
		this.m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(e8));
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
		a(new TableLayoutPanel());
		d(new Button());
		a(new Button());
		b(new Button());
		a(new Label());
		b(new Label());
		b(new TableLayoutPanel());
		f(new TableLayoutPanel());
		b0(new Button());
		j(new Button());
		a(new ToolStrip());
		d(new ToolStripButton());
		a(new ToolStripButton());
		b(new ToolStripButton());
		c(new ToolStripButton());
		e(new ToolStripButton());
		a(new ToolStripSeparator());
		j(new TableLayoutPanel());
		ct(new Label());
		cu(new Label());
		cv(new Label());
		cw(new Label());
		c(new TableLayoutPanel());
		c(new Button());
		a(new TabControl());
		a(new TabPage());
		a(new Panel());
		e(new TableLayoutPanel());
		af(new Button());
		g(new PictureBox());
		h(new PictureBox());
		m(new CheckBox());
		af(new hy());
		bw(new Label());
		bx(new Label());
		by(new Label());
		bz(new Label());
		b0(new Label());
		f(new PictureBox());
		e(new PictureBox());
		bv(new Label());
		l(new CheckBox());
		b(new ComboBox());
		bq(new Label());
		br(new Label());
		bs(new Label());
		ac(new hy());
		bt(new Label());
		ad(new hy());
		bu(new Label());
		n(new Button());
		d(new PictureBox());
		c(new PictureBox());
		k(new CheckBox());
		bm(new Label());
		ab(new hy());
		bn(new Label());
		bo(new Label());
		z(new hy());
		aa(new hy());
		bk(new Label());
		bl(new Label());
		l(new Button());
		b(new TextBox());
		bi(new Label());
		bj(new Label());
		m(new Button());
		k(new Button());
		j(new CheckBox());
		bp(new Label());
		b(new PictureBox());
		d(new TableLayoutPanel());
		c(new Label());
		a(new ComboBox());
		an(new Button());
		am(new TableLayoutPanel());
		cm(new hy());
		fr(new Label());
		b(new TabPage());
		b(new Panel());
		g(new TableLayoutPanel());
		e(new Button());
		u(new GroupBox());
		w(new RadioButton());
		v(new GroupBox());
		x(new RadioButton());
		w(new GroupBox());
		b(new CheckBox());
		i(new CheckBox());
		b1(new Label());
		b2(new Label());
		e(new CheckBox());
		f(new CheckBox());
		y(new RadioButton());
		z(new RadioButton());
		t(new GroupBox());
		e(new GroupBox());
		a(new RadioButton());
		b(new RadioButton());
		f(new GroupBox());
		f(new hy());
		g(new hy());
		l(new Label());
		m(new Label());
		n(new Label());
		o(new Label());
		a(new GroupBox());
		d(new Label());
		b(new hy());
		e(new Label());
		b(new GroupBox());
		bg(new CheckBox());
		a2(new CheckBox());
		a3(new CheckBox());
		a1(new CheckBox());
		f(new Label());
		c(new GroupBox());
		c(new CheckBox());
		d(new GroupBox());
		c(new hy());
		g(new Label());
		d(new hy());
		e(new hy());
		h(new Label());
		i(new Label());
		j(new Label());
		k(new Label());
		d(new CheckBox());
		c(new TabPage());
		m(new TableLayoutPanel());
		bi(new CheckBox());
		dp(new Label());
		d2(new Label());
		b7(new hy());
		b8(new hy());
		b9(new hy());
		ca(new hy());
		cb(new hy());
		cc(new hy());
		d6(new Label());
		ef(new Label());
		eh(new Label());
		c(new Panel());
		h(new TableLayoutPanel());
		i(new TableLayoutPanel());
		j7(new Label());
		fz(new hy());
		bt(new hy());
		cs(new Label());
		h(new hy());
		g(new CheckBox());
		b3(new Label());
		i(new hy());
		t(new Label());
		p(new Label());
		u(new Label());
		q(new Label());
		v(new Label());
		w(new Label());
		d(new TabPage());
		u(new Panel());
		d(new Panel());
		d(new TabControl());
		k(new TabPage());
		an(new TableLayoutPanel());
		aq(new TableLayoutPanel());
		cc(new GroupBox());
		cr(new CheckBox());
		bz(new GroupBox());
		cf(new CheckBox());
		bs(new GroupBox());
		b8(new CheckBox());
		gz(new Label());
		b1(new CheckBox());
		b0(new CheckBox());
		v(new Panel());
		j8(new Label());
		bt(new Button());
		bx(new GroupBox());
		da(new RadioButton());
		cv(new RadioButton());
		cw(new RadioButton());
		cd(new CheckBox());
		er(new hy());
		es(new hy());
		et(new hy());
		bu(new Button());
		eu(new hy());
		g6(new Label());
		bv(new Button());
		by(new GroupBox());
		db(new RadioButton());
		cx(new RadioButton());
		cy(new RadioButton());
		ce(new CheckBox());
		ev(new hy());
		ew(new hy());
		ex(new hy());
		bw(new Button());
		ey(new hy());
		hc(new Label());
		bl(new Button());
		bt(new GroupBox());
		dc(new RadioButton());
		cn(new RadioButton());
		co(new RadioButton());
		b9(new CheckBox());
		dd(new hy());
		de(new hy());
		df(new hy());
		bm(new Button());
		dg(new hy());
		g0(new Label());
		bn(new Button());
		bu(new GroupBox());
		dd(new RadioButton());
		cp(new RadioButton());
		cq(new RadioButton());
		ca(new CheckBox());
		dh(new hy());
		di(new hy());
		dj(new hy());
		bo(new Button());
		dk(new hy());
		g1(new Label());
		bp(new Button());
		bv(new GroupBox());
		de(new RadioButton());
		cr(new RadioButton());
		cs(new RadioButton());
		cb(new CheckBox());
		dl(new hy());
		dp(new hy());
		d2(new hy());
		bq(new Button());
		d6(new hy());
		g2(new Label());
		br(new Button());
		bw(new GroupBox());
		df(new RadioButton());
		ct(new RadioButton());
		cu(new RadioButton());
		cc(new CheckBox());
		ef(new hy());
		eh(new hy());
		ep(new hy());
		bs(new Button());
		eq(new hy());
		g3(new Label());
		fz(new Label());
		f6(new Label());
		f7(new Label());
		f8(new Label());
		ar(new Button());
		f9(new Label());
		ga(new Label());
		gb(new Label());
		ge(new Label());
		gk(new Label());
		bm(new GroupBox());
		dg(new RadioButton());
		cb(new RadioButton());
		cc(new RadioButton());
		b2(new CheckBox());
		cp(new hy());
		cq(new hy());
		a1(new Button());
		cr(new hy());
		cs(new hy());
		gl(new Label());
		a2(new Button());
		bn(new GroupBox());
		c9(new RadioButton());
		cd(new RadioButton());
		ce(new RadioButton());
		b3(new CheckBox());
		ct(new hy());
		cu(new hy());
		cv(new hy());
		a3(new Button());
		cw(new hy());
		gm(new Label());
		bo(new GroupBox());
		dh(new RadioButton());
		cf(new RadioButton());
		cg(new RadioButton());
		b4(new CheckBox());
		cx(new hy());
		cy(new hy());
		cz(new hy());
		bd(new Button());
		c0(new hy());
		gn(new Label());
		bp(new GroupBox());
		di(new RadioButton());
		ch(new RadioButton());
		ci(new RadioButton());
		b5(new CheckBox());
		c1(new hy());
		c2(new hy());
		c3(new hy());
		be(new Button());
		c4(new hy());
		go(new Label());
		bq(new GroupBox());
		dj(new RadioButton());
		cj(new RadioButton());
		ck(new RadioButton());
		b6(new CheckBox());
		c5(new hy());
		c6(new hy());
		c7(new hy());
		bf(new Button());
		c8(new hy());
		gp(new Label());
		br(new GroupBox());
		dk(new RadioButton());
		cl(new RadioButton());
		cm(new RadioButton());
		b7(new CheckBox());
		c9(new hy());
		da(new hy());
		db(new hy());
		bg(new Button());
		dc(new hy());
		gs(new Label());
		bh(new Button());
		bi(new Button());
		bj(new Button());
		bk(new Button());
		gy(new Label());
		l(new TabPage());
		af(new TableLayoutPanel());
		q(new Panel());
		j9(new Label());
		e8(new Label());
		b8(new Label());
		x(new GroupBox());
		br(new CheckBox());
		e(new Panel());
		dl(new RadioButton());
		aa(new RadioButton());
		ab(new RadioButton());
		n(new CheckBox());
		ac(new RadioButton());
		ad(new RadioButton());
		al(new hy());
		am(new hy());
		o(new CheckBox());
		an(new hy());
		p(new Button());
		ao(new hy());
		cg(new Label());
		b4(new Label());
		b5(new Label());
		cc(new Label());
		ab(new Button());
		cf(new Label());
		b6(new Label());
		ce(new Label());
		aa(new Button());
		q(new Button());
		b7(new Label());
		cd(new Label());
		z(new Button());
		y(new GroupBox());
		bs(new CheckBox());
		f(new Panel());
		dp(new RadioButton());
		af(new RadioButton());
		al(new RadioButton());
		am(new RadioButton());
		an(new RadioButton());
		p(new CheckBox());
		aq(new hy());
		ar(new hy());
		q(new CheckBox());
		a1(new hy());
		t(new Button());
		a2(new hy());
		ch(new Label());
		y(new Button());
		o(new Button());
		b9(new Label());
		z(new GroupBox());
		bt(new CheckBox());
		g(new Panel());
		d2(new RadioButton());
		ao(new RadioButton());
		aq(new RadioButton());
		ar(new RadioButton());
		a1(new RadioButton());
		t(new CheckBox());
		a3(new hy());
		bd(new hy());
		u(new CheckBox());
		be(new hy());
		u(new Button());
		bf(new hy());
		ci(new Label());
		ac(new GroupBox());
		bw(new CheckBox());
		j(new Panel());
		d6(new RadioButton());
		bj(new RadioButton());
		bk(new RadioButton());
		bl(new RadioButton());
		bm(new RadioButton());
		z(new CheckBox());
		bo(new hy());
		bp(new hy());
		aa(new CheckBox());
		bq(new hy());
		x(new Button());
		br(new hy());
		cl(new Label());
		aa(new GroupBox());
		bu(new CheckBox());
		h(new Panel());
		ef(new RadioButton());
		a2(new RadioButton());
		a3(new RadioButton());
		bd(new RadioButton());
		be(new RadioButton());
		v(new CheckBox());
		bg(new hy());
		bh(new hy());
		w(new CheckBox());
		bi(new hy());
		v(new Button());
		bj(new hy());
		cj(new Label());
		ca(new Label());
		cb(new Label());
		ab(new GroupBox());
		bv(new CheckBox());
		i(new Panel());
		eh(new RadioButton());
		bf(new RadioButton());
		bg(new RadioButton());
		bh(new RadioButton());
		bi(new RadioButton());
		x(new CheckBox());
		bk(new hy());
		bl(new hy());
		y(new CheckBox());
		bm(new hy());
		w(new Button());
		bn(new hy());
		ck(new Label());
		cm(new Label());
		t(new Panel());
		am(new Button());
		e7(new Label());
		bq(new CheckBox());
		d(new TextBox());
		w(new TabPage());
		bi(new TableLayoutPanel());
		z(new Panel());
		cq(new CheckBox());
		b9(new GroupBox());
		bh(new TableLayoutPanel());
		bd(new TableLayoutPanel());
		il(new Label());
		c4(new RadioButton());
		fb(new hy());
		fc(new hy());
		im(new Label());
		a3(new TableLayoutPanel());
		ik(new Label());
		c3(new RadioButton());
		fa(new hy());
		a2(new TableLayoutPanel());
		@in(new Label());
		b8(new GroupBox());
		a1(new TableLayoutPanel());
		c1(new RadioButton());
		c2(new RadioButton());
		ii(new Label());
		e9(new hy());
		ij(new Label());
		aa(new Panel());
		cp(new CheckBox());
		ca(new GroupBox());
		be(new TableLayoutPanel());
		io(new Label());
		bf(new TableLayoutPanel());
		cb(new GroupBox());
		bg(new TableLayoutPanel());
		c5(new RadioButton());
		c6(new RadioButton());
		ip(new Label());
		iq(new Label());
		fr(new hy());
		m(new TabPage());
		bk(new GroupBox());
		fu(new Label());
		fv(new Label());
		fw(new Label());
		co(new hy());
		ad(new GroupBox());
		cn(new Label());
		co(new Label());
		bs(new hy());
		cp(new Label());
		ac(new Button());
		cq(new Label());
		cr(new Label());
		ad(new Button());
		e(new TabPage());
		k(new Panel());
		n(new TableLayoutPanel());
		p(new TableLayoutPanel());
		al(new TableLayoutPanel());
		bd(new GroupBox());
		b2(new RadioButton());
		b3(new RadioButton());
		q(new TableLayoutPanel());
		g(new Button());
		f(new Button());
		bj(new GroupBox());
		ab(new Panel());
		j1(new Label());
		fu(new hy());
		j2(new Label());
		b8(new RadioButton());
		b9(new RadioButton());
		ca(new RadioButton());
		by(new CheckBox());
		b7(new GroupBox());
		ar(new TableLayoutPanel());
		ir(new Label());
		ih(new Label());
		ig(new Label());
		fs(new Label());
		e8(new hy());
		ao(new Button());
		cn(new hy());
		ft(new Label());
		@is(new Label());
		it(new Label());
		fs(new hy());
		ft(new hy());
		g(new GroupBox());
		c(new RadioButton());
		d(new RadioButton());
		e(new RadioButton());
		f(new RadioButton());
		a(new DataGridView());
		a(new DataGridViewTextBoxColumn());
		b(new DataGridViewTextBoxColumn());
		a(new DataGridViewCheckBoxColumn());
		c(new DataGridViewTextBoxColumn());
		t(new TableLayoutPanel());
		h(new GroupBox());
		g(new RadioButton());
		h(new RadioButton());
		i(new GroupBox());
		x(new Label());
		y(new Label());
		z(new Label());
		i(new RadioButton());
		j(new GroupBox());
		j(new hy());
		aa(new Label());
		ab(new Label());
		k(new GroupBox());
		ac(new Label());
		ad(new Label());
		af(new Label());
		k(new hy());
		l(new hy());
		m(new hy());
		n(new hy());
		al(new Label());
		a2(new GroupBox());
		bj(new CheckBox());
		a3(new GroupBox());
		cd(new hy());
		eq(new Label());
		er(new Label());
		ce(new hy());
		es(new Label());
		cf(new hy());
		et(new Label());
		eu(new Label());
		o(new TableLayoutPanel());
		f(new ComboBox());
		ep(new Label());
		f(new TabPage());
		l(new Panel());
		n(new GroupBox());
		t(new RadioButton());
		u(new RadioButton());
		o(new GroupBox());
		am(new Label());
		an(new Label());
		ao(new Label());
		v(new RadioButton());
		p(new GroupBox());
		o(new hy());
		aq(new Label());
		ar(new Label());
		q(new GroupBox());
		c(new TabControl());
		i(new TabPage());
		a1(new Label());
		a2(new Label());
		a3(new Label());
		p(new hy());
		q(new hy());
		t(new hy());
		u(new hy());
		bd(new Label());
		j(new TabPage());
		be(new Label());
		bf(new Label());
		bg(new Label());
		bh(new Label());
		v(new hy());
		w(new hy());
		x(new hy());
		y(new hy());
		o(new TabPage());
		de(new Label());
		df(new Label());
		dg(new Label());
		b1(new hy());
		b2(new hy());
		b3(new hy());
		b4(new hy());
		dh(new Label());
		h(new Button());
		m(new GroupBox());
		k(new TableLayoutPanel());
		l(new TableLayoutPanel());
		bh(new CheckBox());
		bd(new CheckBox());
		bf(new CheckBox());
		be(new CheckBox());
		i(new Button());
		l(new GroupBox());
		h(new CheckBox());
		b(new TabControl());
		g(new TabPage());
		j(new RadioButton());
		k(new RadioButton());
		l(new RadioButton());
		m(new RadioButton());
		h(new TabPage());
		n(new RadioButton());
		o(new RadioButton());
		p(new RadioButton());
		q(new RadioButton());
		p(new TabPage());
		bt(new RadioButton());
		bu(new RadioButton());
		bv(new RadioButton());
		bw(new RadioButton());
		n(new TabPage());
		m(new Panel());
		bf(new GroupBox());
		bh(new GroupBox());
		b6(new RadioButton());
		b7(new RadioButton());
		bi(new GroupBox());
		b5(new RadioButton());
		b4(new RadioButton());
		cl(new hy());
		fc(new Label());
		e(new NumericUpDown());
		fb(new Label());
		bg(new GroupBox());
		e9(new Label());
		ck(new hy());
		fa(new Label());
		cj(new hy());
		cd(new GroupBox());
		fv(new hy());
		fw(new hy());
		j3(new Label());
		j4(new Label());
		j5(new Label());
		j6(new Label());
		c7(new RadioButton());
		c8(new RadioButton());
		cs(new CheckBox());
		a1(new GroupBox());
		bx(new RadioButton());
		by(new RadioButton());
		bz(new RadioButton());
		ar(new GroupBox());
		bu(new hy());
		bv(new hy());
		bw(new hy());
		br(new RadioButton());
		bs(new RadioButton());
		aq(new CheckBox());
		ar(new CheckBox());
		c8(new Label());
		c9(new Label());
		da(new Label());
		db(new Label());
		dc(new Label());
		dd(new Label());
		aq(new GroupBox());
		b1(new Button());
		al(new CheckBox());
		am(new CheckBox());
		an(new CheckBox());
		ao(new CheckBox());
		an(new GroupBox());
		bx(new CheckBox());
		ab(new CheckBox());
		ac(new CheckBox());
		ao(new GroupBox());
		by(new hy());
		bz(new hy());
		b0(new hy());
		ad(new CheckBox());
		c2(new Label());
		c3(new Label());
		c4(new Label());
		c5(new Label());
		c6(new Label());
		c7(new Label());
		af(new CheckBox());
		af(new GroupBox());
		n(new Panel());
		dl(new Label());
		dk(new Label());
		b5(new hy());
		b6(new hy());
		di(new Label());
		dj(new Label());
		by(new Button());
		ao(new TableLayoutPanel());
		bx(new Button());
		al(new GroupBox());
		bq(new RadioButton());
		bl(new GroupBox());
		aq(new Button());
		bn(new RadioButton());
		bo(new RadioButton());
		bp(new RadioButton());
		bz(new CheckBox());
		c(new ComboBox());
		am(new GroupBox());
		bx(new hy());
		d(new ComboBox());
		e(new ComboBox());
		cx(new Label());
		cy(new Label());
		cz(new Label());
		c0(new Label());
		c1(new Label());
		q(new TabPage());
		o(new Panel());
		u(new TableLayoutPanel());
		v(new TableLayoutPanel());
		ev(new Label());
		a(new NumericUpDown());
		bk(new CheckBox());
		w(new TableLayoutPanel());
		g(new ComboBox());
		ew(new Label());
		x(new TableLayoutPanel());
		ex(new Label());
		cg(new hy());
		b0(new RadioButton());
		b1(new RadioButton());
		bl(new CheckBox());
		ey(new Label());
		y(new TableLayoutPanel());
		ez(new Label());
		ch(new hy());
		e0(new Label());
		z(new TableLayoutPanel());
		e1(new Label());
		b(new NumericUpDown());
		bm(new CheckBox());
		aa(new TableLayoutPanel());
		e2(new Label());
		bn(new CheckBox());
		c(new NumericUpDown());
		ab(new TableLayoutPanel());
		bo(new CheckBox());
		e3(new Label());
		d(new NumericUpDown());
		ac(new TableLayoutPanel());
		e4(new Label());
		h(new ComboBox());
		ad(new TableLayoutPanel());
		ci(new hy());
		e5(new Label());
		t(new TabPage());
		p(new Panel());
		bp(new CheckBox());
		be(new GroupBox());
		al(new Button());
		c(new TextBox());
		e6(new Label());
		u(new TabPage());
		w(new Panel());
		b0(new GroupBox());
		ez(new hy());
		e0(new hy());
		e1(new hy());
		cz(new RadioButton());
		c0(new RadioButton());
		cg(new CheckBox());
		ch(new CheckBox());
		hd(new Label());
		he(new Label());
		hf(new Label());
		hg(new Label());
		hh(new Label());
		hk(new Label());
		b1(new GroupBox());
		x(new Panel());
		hq(new Label());
		hr(new Label());
		e2(new hy());
		e3(new hy());
		hs(new Label());
		ht(new Label());
		i(new ComboBox());
		b2(new GroupBox());
		e4(new hy());
		j(new ComboBox());
		k(new ComboBox());
		hu(new Label());
		hv(new Label());
		hy(new Label());
		h8(new Label());
		h9(new Label());
		v(new TabPage());
		y(new Panel());
		b3(new GroupBox());
		ci(new CheckBox());
		cj(new CheckBox());
		ck(new CheckBox());
		b4(new GroupBox());
		cl(new CheckBox());
		b5(new GroupBox());
		e5(new hy());
		e6(new hy());
		e7(new hy());
		cm(new CheckBox());
		ia(new Label());
		ib(new Label());
		ic(new Label());
		id(new Label());
		ie(new Label());
		@if(new Label());
		cn(new CheckBox());
		b6(new GroupBox());
		bz(new Button());
		co(new CheckBox());
		a(new ContextMenuStrip(this.m_a));
		a(new ToolTip(this.m_a));
		a(new ErrorProvider(this.m_a));
		b(new ToolTip(this.m_a));
		c(new ToolTip(this.m_a));
		d(new ToolTip(this.m_a));
		e(new ToolTip(this.m_a));
		f(new ToolTip(this.m_a));
		g(new ToolTip(this.m_a));
		h(new ToolTip(this.m_a));
		b4().SuspendLayout();
		ca().SuspendLayout();
		k7().SuspendLayout();
		cc().SuspendLayout();
		py().SuspendLayout();
		cb().SuspendLayout();
		ch().SuspendLayout();
		ci().SuspendLayout();
		cn().SuspendLayout();
		@is().SuspendLayout();
		((ISupportInitialize)k4()).BeginInit();
		((ISupportInitialize)k5()).BeginInit();
		((ISupportInitialize)k3()).BeginInit();
		((ISupportInitialize)kt()).BeginInit();
		((ISupportInitialize)kk()).BeginInit();
		((ISupportInitialize)kg()).BeginInit();
		((ISupportInitialize)j3()).BeginInit();
		co().SuspendLayout();
		zl().SuspendLayout();
		cj().SuspendLayout();
		li().SuspendLayout();
		lj().SuspendLayout();
		k9().SuspendLayout();
		lb().SuspendLayout();
		ld().SuspendLayout();
		k8().SuspendLayout();
		c9().SuspendLayout();
		dc().SuspendLayout();
		cq().SuspendLayout();
		cu().SuspendLayout();
		cx().SuspendLayout();
		cz().SuspendLayout();
		dl().SuspendLayout();
		vu().SuspendLayout();
		lk().SuspendLayout();
		ll().SuspendLayout();
		pl().SuspendLayout();
		dp().SuspendLayout();
		ln().SuspendLayout();
		lo().SuspendLayout();
		lp().SuspendLayout();
		z3().SuspendLayout();
		aeb().SuspendLayout();
		aho().SuspendLayout();
		aec().SuspendLayout();
		acc().SuspendLayout();
		z7().SuspendLayout();
		ado().SuspendLayout();
		adz().SuspendLayout();
		acg().SuspendLayout();
		acr().SuspendLayout();
		ac2().SuspendLayout();
		add().SuspendLayout();
		aai().SuspendLayout();
		aat().SuspendLayout();
		aa3().SuspendLayout();
		abd().SuspendLayout();
		abn().SuspendLayout();
		abx().SuspendLayout();
		lq().SuspendLayout();
		yl().SuspendLayout();
		ym().SuspendLayout();
		l4().SuspendLayout();
		l5().SuspendLayout();
		mj().SuspendLayout();
		mk().SuspendLayout();
		mx().SuspendLayout();
		my().SuspendLayout();
		oe().SuspendLayout();
		oh().SuspendLayout();
		nb().SuspendLayout();
		nc().SuspendLayout();
		ns().SuspendLayout();
		nt().SuspendLayout();
		yn().SuspendLayout();
		agc().SuspendLayout();
		ahb().SuspendLayout();
		ahc().SuspendLayout();
		agn().SuspendLayout();
		aha().SuspendLayout();
		agy().SuspendLayout();
		ago().SuspendLayout();
		agj().SuspendLayout();
		agf().SuspendLayout();
		agg().SuspendLayout();
		ahd().SuspendLayout();
		agz().SuspendLayout();
		ag0().SuspendLayout();
		ag2().SuspendLayout();
		ag9().SuspendLayout();
		ag6().SuspendLayout();
		o0().SuspendLayout();
		zv().SuspendLayout();
		o1().SuspendLayout();
		d2().SuspendLayout();
		pw().SuspendLayout();
		we().SuspendLayout();
		wj().SuspendLayout();
		yz().SuspendLayout();
		x7().SuspendLayout();
		wk().SuspendLayout();
		zm().SuspendLayout();
		ahj().SuspendLayout();
		af7().SuspendLayout();
		agb().SuspendLayout();
		ey().SuspendLayout();
		((ISupportInitialize)wi()).BeginInit();
		w1().SuspendLayout();
		e3().SuspendLayout();
		e6().SuspendLayout();
		fb().SuspendLayout();
		ft().SuspendLayout();
		wl().SuspendLayout();
		wn().SuspendLayout();
		wf().SuspendLayout();
		ev().SuspendLayout();
		px().SuspendLayout();
		g6().SuspendLayout();
		he().SuspendLayout();
		hq().SuspendLayout();
		hu().SuspendLayout();
		hv().SuspendLayout();
		hy().SuspendLayout();
		ig().SuspendLayout();
		ua().SuspendLayout();
		g3().SuspendLayout();
		vl().SuspendLayout();
		vm().SuspendLayout();
		ge().SuspendLayout();
		gl().SuspendLayout();
		gm().SuspendLayout();
		gy().SuspendLayout();
		u8().SuspendLayout();
		qh().SuspendLayout();
		qi().SuspendLayout();
		y0().SuspendLayout();
		zc().SuspendLayout();
		zf().SuspendLayout();
		((ISupportInitialize)za()).BeginInit();
		zb().SuspendLayout();
		ahq().SuspendLayout();
		v7().SuspendLayout();
		tg().SuspendLayout();
		tb().SuspendLayout();
		r5().SuspendLayout();
		sg().SuspendLayout();
		qq().SuspendLayout();
		vn().SuspendLayout();
		ad9().SuspendLayout();
		qs().SuspendLayout();
		z1().SuspendLayout();
		rf().SuspendLayout();
		w2().SuspendLayout();
		w3().SuspendLayout();
		w4().SuspendLayout();
		w5().SuspendLayout();
		((ISupportInitialize)w7()).BeginInit();
		w9().SuspendLayout();
		xc().SuspendLayout();
		xl().SuspendLayout();
		xp().SuspendLayout();
		((ISupportInitialize)xr()).BeginInit();
		xt().SuspendLayout();
		((ISupportInitialize)xw()).BeginInit();
		xx().SuspendLayout();
		((ISupportInitialize)x0()).BeginInit();
		x1().SuspendLayout();
		x4().SuspendLayout();
		ye().SuspendLayout();
		yk().SuspendLayout();
		yf().SuspendLayout();
		ael().SuspendLayout();
		aen().SuspendLayout();
		aeo().SuspendLayout();
		ae2().SuspendLayout();
		ae3().SuspendLayout();
		afb().SuspendLayout();
		aem().SuspendLayout();
		afk().SuspendLayout();
		afl().SuspendLayout();
		afp().SuspendLayout();
		afr().SuspendLayout();
		af3().SuspendLayout();
		((ISupportInitialize)zi()).BeginInit();
		SuspendLayout();
		b4().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		b4().AutoSize = true;
		b4().CausesValidation = false;
		b4().ColumnCount = 3;
		b4().ColumnStyles.Add(new ColumnStyle());
		b4().ColumnStyles.Add(new ColumnStyle());
		b4().ColumnStyles.Add(new ColumnStyle());
		b4().Controls.Add(ck(), 2, 0);
		b4().Controls.Add(b5(), 0, 0);
		b4().Controls.Add(b6(), 1, 0);
		b4().Location = new Point(467, 10);
		b4().Margin = new Padding(3, 10, 3, 4);
		b4().Name = "TLPOkCancel";
		b4().RowCount = 1;
		b4().RowStyles.Add(new RowStyle());
		b4().Size = new Size(315, 41);
		b4().TabIndex = 0;
		ck().Anchor = AnchorStyles.None;
		ck().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ck().Location = new Point(213, 4);
		ck().Margin = new Padding(3, 4, 3, 4);
		ck().Name = "ButtonApply";
		ck().Size = new Size(99, 33);
		ck().TabIndex = 135;
		ck().Text = "Apply";
		iq().SetToolTip(ck(), "Apply changes to Recipe, resulting in Reanalysis of current Spectrum.");
		b5().Anchor = AnchorStyles.None;
		b5().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b5().Location = new Point(3, 4);
		b5().Margin = new Padding(3, 4, 3, 4);
		b5().Name = "ButtonOK";
		b5().Size = new Size(99, 33);
		b5().TabIndex = 0;
		b5().Text = "OK";
		iq().SetToolTip(b5(), "Apply any changes to Recipe and close dialog");
		b6().Anchor = AnchorStyles.None;
		b6().CausesValidation = false;
		b6().DialogResult = DialogResult.Cancel;
		b6().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b6().Location = new Point(108, 4);
		b6().Margin = new Padding(3, 4, 3, 4);
		b6().Name = "ButtonCancel";
		b6().Size = new Size(99, 33);
		b6().TabIndex = 1;
		b6().Text = "Cancel";
		iq().SetToolTip(b6(), "Close dialog, disregarding any changes to Recipe");
		b8().Anchor = AnchorStyles.None;
		b8().AutoSize = true;
		b8().BackColor = SystemColors.ButtonHighlight;
		b8().BorderStyle = BorderStyle.Fixed3D;
		b8().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b8().Location = new Point(94, 3);
		b8().Margin = new Padding(0);
		b8().MinimumSize = new Size(158, 0);
		b8().Name = "LabelRecipeName";
		b8().Size = new Size(158, 18);
		b8().TabIndex = 130;
		b8().Text = "RecipeNameRecipeName";
		b8().TextAlign = ContentAlignment.MiddleLeft;
		iq().SetToolTip(b8(), "Name of Recipe file");
		b8().UseMnemonic = false;
		b9().Anchor = AnchorStyles.None;
		b9().AutoSize = true;
		b9().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b9().Location = new Point(2, 5);
		b9().Margin = new Padding(2, 1, 2, 0);
		b9().Name = "LabelRecipeNameLabel";
		b9().Size = new Size(90, 16);
		b9().TabIndex = 129;
		b9().Text = "Recipe Name:";
		ca().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		ca().AutoSize = true;
		ca().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ca().BackColor = Color.Transparent;
		ca().CausesValidation = false;
		ca().ColumnCount = 2;
		ca().ColumnStyles.Add(new ColumnStyle());
		ca().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		ca().Controls.Add(k7(), 0, 3);
		ca().Controls.Add(cc(), 0, 0);
		ca().Controls.Add(py(), 1, 1);
		ca().Controls.Add(cb(), 0, 1);
		ca().Controls.Add(ch(), 0, 2);
		ca().Location = new Point(0, 0);
		ca().Margin = new Padding(10, 3, 10, 3);
		ca().Name = "TLPMain";
		ca().Padding = new Padding(10, 0, 10, 0);
		ca().RowCount = 4;
		ca().RowStyles.Add(new RowStyle());
		ca().RowStyles.Add(new RowStyle());
		ca().RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		ca().RowStyles.Add(new RowStyle());
		ca().Size = new Size(811, 624);
		ca().TabIndex = 132;
		k7().Anchor = AnchorStyles.Left | AnchorStyles.Right;
		k7().AutoSize = true;
		k7().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		k7().CausesValidation = false;
		k7().ColumnCount = 3;
		ca().SetColumnSpan(k7(), 2);
		k7().ColumnStyles.Add(new ColumnStyle());
		k7().ColumnStyles.Add(new ColumnStyle());
		k7().ColumnStyles.Add(new ColumnStyle());
		k7().Controls.Add(af6(), 0, 0);
		k7().Controls.Add(ip(), 0, 0);
		k7().Controls.Add(b4(), 2, 0);
		k7().Location = new Point(13, 566);
		k7().Name = "TableLayoutPanel3";
		k7().RowCount = 1;
		k7().RowStyles.Add(new RowStyle());
		k7().Size = new Size(785, 55);
		k7().TabIndex = 126;
		af6().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		af6().AutoSize = true;
		af6().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		af6().Location = new Point(148, 15);
		af6().Margin = new Padding(3, 3, 3, 8);
		af6().Name = "ButtonAdditionalRecipes";
		af6().Size = new Size(162, 32);
		af6().TabIndex = 136;
		af6().Text = "Additional Recipes...";
		af6().UseVisualStyleBackColor = true;
		ip().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		ip().AutoSize = true;
		ip().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ip().Location = new Point(3, 15);
		ip().Margin = new Padding(3, 3, 3, 8);
		ip().Name = "ButtonEditCorrCoef";
		ip().Size = new Size(139, 32);
		ip().TabIndex = 135;
		ip().Text = "Edit Correlation...";
		ip().UseVisualStyleBackColor = true;
		ca().SetColumnSpan(cc(), 2);
		cc().Dock = DockStyle.None;
		cc().GripStyle = ToolStripGripStyle.Hidden;
		cc().Items.AddRange(new ToolStripItem[6]
		{
			cg(),
			cd(),
			ce(),
			cf(),
			wb(),
			wc()
		});
		cc().LayoutStyle = ToolStripLayoutStyle.Flow;
		cc().Location = new Point(10, 0);
		cc().Name = "ToolStripFileButtons";
		cc().RenderMode = ToolStripRenderMode.System;
		cc().Size = new Size(122, 23);
		cc().TabIndex = 134;
		cc().Text = "ToolStrip1";
		cg().DisplayStyle = ToolStripItemDisplayStyle.Image;
		cg().Image = Resources.OpenFile;
		cg().ImageTransparentColor = Color.Magenta;
		cg().Name = "ToolStripButtonOpen";
		cg().Size = new Size(23, 20);
		cg().ToolTipText = "Open Recipe from file";
		cd().DisplayStyle = ToolStripItemDisplayStyle.Image;
		cd().Image = Resources.NewFile;
		cd().ImageTransparentColor = Color.Magenta;
		cd().Name = "ToolStripButtonNew";
		cd().Size = new Size(23, 20);
		cd().ToolTipText = "Create new Recipe";
		ce().DisplayStyle = ToolStripItemDisplayStyle.Image;
		ce().Image = Resources.Save;
		ce().ImageTransparentColor = Color.Magenta;
		ce().Name = "ToolStripButtonSave";
		ce().Size = new Size(23, 20);
		ce().ToolTipText = "Save Recipe to file";
		cf().DisplayStyle = ToolStripItemDisplayStyle.Image;
		cf().Image = Resources.SaveAs;
		cf().ImageTransparentColor = Color.Magenta;
		cf().Name = "ToolStripButtonSaveAs";
		cf().Size = new Size(23, 20);
		cf().ToolTipText = "Save Recipe as different filename";
		wb().DisplayStyle = ToolStripItemDisplayStyle.Image;
		wb().Image = Resources.DeleteFile;
		wb().ImageTransparentColor = Color.Magenta;
		wb().Name = "ToolStripButtonDeleteFile";
		wb().Size = new Size(23, 20);
		wb().ToolTipText = "Delete currently selected Recipe";
		wc().Name = "ToolStripSeparator1";
		wc().Size = new Size(6, 23);
		py().Anchor = AnchorStyles.Top | AnchorStyles.Right;
		py().AutoSize = true;
		py().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		py().ColumnCount = 2;
		py().ColumnStyles.Add(new ColumnStyle());
		py().ColumnStyles.Add(new ColumnStyle());
		py().Controls.Add(p6(), 0, 0);
		py().Controls.Add(p7(), 0, 1);
		py().Controls.Add(p8(), 1, 1);
		py().Controls.Add(qg(), 1, 0);
		py().Location = new Point(629, 23);
		py().Margin = new Padding(0, 0, 2, 0);
		py().Name = "TLPNameAndDate";
		py().RowCount = 2;
		py().RowStyles.Add(new RowStyle());
		py().RowStyles.Add(new RowStyle());
		py().Size = new Size(170, 41);
		py().TabIndex = 133;
		p6().Anchor = AnchorStyles.Right;
		p6().AutoSize = true;
		p6().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		p6().Location = new Point(40, 1);
		p6().Margin = new Padding(2, 0, 2, 2);
		p6().Name = "LabelAuthorLabel";
		p6().Size = new Size(50, 16);
		p6().TabIndex = 125;
		p6().Text = "Author:";
		p7().Anchor = AnchorStyles.Right;
		p7().AutoSize = true;
		p7().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		p7().Location = new Point(0, 24);
		p7().Margin = new Padding(0, 3, 3, 0);
		p7().Name = "LabelLastModLabel";
		p7().Size = new Size(89, 16);
		p7().TabIndex = 126;
		p7().Text = "Last Modified:";
		p8().Anchor = AnchorStyles.Left | AnchorStyles.Right;
		p8().AutoSize = true;
		p8().BackColor = SystemColors.ButtonHighlight;
		p8().BorderStyle = BorderStyle.Fixed3D;
		p8().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		p8().Location = new Point(92, 23);
		p8().Margin = new Padding(0, 3, 2, 0);
		p8().Name = "LabelModDate";
		p8().Size = new Size(76, 18);
		p8().TabIndex = 127;
		p8().Text = "Mod. Date:";
		p8().TextAlign = ContentAlignment.MiddleLeft;
		iq().SetToolTip(p8(), "Date this Recipe was last modified");
		qg().Anchor = AnchorStyles.Left | AnchorStyles.Right;
		qg().AutoSize = true;
		qg().BackColor = SystemColors.ButtonHighlight;
		qg().BorderStyle = BorderStyle.Fixed3D;
		qg().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		qg().Location = new Point(92, 0);
		qg().Margin = new Padding(0, 0, 3, 2);
		qg().MinimumSize = new Size(75, 0);
		qg().Name = "LabelAuthor";
		qg().Size = new Size(75, 18);
		qg().TabIndex = 128;
		qg().Text = "User Name";
		qg().TextAlign = ContentAlignment.MiddleLeft;
		iq().SetToolTip(qg(), "User who last modified this Recipe");
		cb().Anchor = AnchorStyles.Left;
		cb().AutoSize = true;
		cb().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		cb().ColumnCount = 3;
		cb().ColumnStyles.Add(new ColumnStyle());
		cb().ColumnStyles.Add(new ColumnStyle());
		cb().ColumnStyles.Add(new ColumnStyle());
		cb().Controls.Add(b9(), 0, 0);
		cb().Controls.Add(b8(), 1, 0);
		cb().Controls.Add(b7(), 2, 0);
		cb().Location = new Point(12, 31);
		cb().Margin = new Padding(2, 3, 0, 3);
		cb().Name = "TLPRecipeName";
		cb().RowCount = 1;
		cb().RowStyles.Add(new RowStyle());
		cb().Size = new Size(271, 25);
		cb().TabIndex = 133;
		b7().Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
		b7().BackgroundImage = Resources.DropDownImage;
		b7().BackgroundImageLayout = ImageLayout.Center;
		b7().Location = new Point(252, 0);
		b7().Margin = new Padding(0);
		b7().Name = "ButtonGetRecipe";
		b7().Size = new Size(19, 25);
		b7().TabIndex = 131;
		iq().SetToolTip(b7(), "Open Recipe from file");
		b7().UseVisualStyleBackColor = true;
		ca().SetColumnSpan(ch(), 2);
		ch().Controls.Add(ci());
		ch().Controls.Add(cj());
		ch().Controls.Add(dl());
		ch().Controls.Add(dp());
		ch().Controls.Add(d2());
		ch().Controls.Add(ev());
		ch().Controls.Add(qh());
		ch().Controls.Add(w2());
		ch().Controls.Add(ye());
		ch().Controls.Add(ael());
		ch().Controls.Add(aem());
		ch().Dock = DockStyle.Fill;
		ch().Location = new Point(12, 67);
		ch().Margin = new Padding(2, 3, 2, 3);
		ch().Name = "TabControlMain";
		ch().SelectedIndex = 0;
		ch().Size = new Size(787, 493);
		ch().TabIndex = 134;
		ci().AutoScroll = true;
		ci().Controls.Add(cn());
		ci().Location = new Point(4, 25);
		ci().Margin = new Padding(2, 3, 2, 3);
		ci().Name = "TabPageFilmstack";
		ci().Padding = new Padding(2, 3, 2, 3);
		ci().Size = new Size(779, 464);
		ci().TabIndex = 0;
		ci().Text = "Film Stack";
		ci().UseVisualStyleBackColor = true;
		cn().AutoSize = true;
		cn().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		cn().Controls.Add(@is());
		cn().Location = new Point(0, 0);
		cn().Name = "PanelFilmstackMain";
		cn().Size = new Size(1182, 151);
		cn().TabIndex = 125;
		@is().AutoSize = true;
		@is().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		@is().ColumnCount = 27;
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0f));
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 2f));
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 2f));
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().Controls.Add(wd(), 17, 0);
		@is().Controls.Add(k4(), 24, 2);
		@is().Controls.Add(k5(), 26, 2);
		@is().Controls.Add(kw(), 25, 4);
		@is().Controls.Add(kx(), 24, 4);
		@is().Controls.Add(ky(), 25, 3);
		@is().Controls.Add(kz(), 24, 3);
		@is().Controls.Add(k0(), 24, 1);
		@is().Controls.Add(k1(), 17, 1);
		@is().Controls.Add(k2(), 4, 1);
		@is().Controls.Add(k3(), 17, 2);
		@is().Controls.Add(kt(), 23, 2);
		@is().Controls.Add(ku(), 22, 3);
		@is().Controls.Add(km(), 21, 4);
		@is().Controls.Add(kv(), 22, 4);
		@is().Controls.Add(kl(), 21, 3);
		@is().Controls.Add(kn(), 20, 3);
		@is().Controls.Add(ko(), 19, 3);
		@is().Controls.Add(kp(), 19, 4);
		@is().Controls.Add(kq(), 18, 4);
		@is().Controls.Add(kr(), 17, 4);
		@is().Controls.Add(ks(), 17, 3);
		@is().Controls.Add(kj(), 0, 5);
		@is().Controls.Add(kk(), 4, 2);
		@is().Controls.Add(kg(), 16, 2);
		@is().Controls.Add(kh(), 15, 4);
		@is().Controls.Add(kc(), 13, 4);
		@is().Controls.Add(kd(), 12, 4);
		@is().Controls.Add(ke(), 12, 3);
		@is().Controls.Add(kf(), 10, 3);
		@is().Controls.Add(j7(), 9, 4);
		@is().Controls.Add(j8(), 8, 4);
		@is().Controls.Add(j9(), 9, 3);
		@is().Controls.Add(ka(), 8, 3);
		@is().Controls.Add(j1(), 6, 4);
		@is().Controls.Add(j2(), 4, 4);
		@is().Controls.Add(j4(), 2, 3);
		@is().Controls.Add(j5(), 2, 4);
		@is().Controls.Add(j6(), 1, 4);
		@is().Controls.Add(it(), 0, 3);
		@is().Controls.Add(kb(), 11, 4);
		@is().Controls.Add(ki(), 14, 3);
		@is().Controls.Add(j3(), 3, 2);
		@is().Controls.Add(co(), 0, 0);
		@is().Controls.Add(zl(), 7, 4);
		@is().Location = new Point(3, 3);
		@is().Name = "TLPFilmstack";
		@is().RowCount = 7;
		@is().RowStyles.Add(new RowStyle(SizeType.Absolute, 50f));
		@is().RowStyles.Add(new RowStyle());
		@is().RowStyles.Add(new RowStyle());
		@is().RowStyles.Add(new RowStyle());
		@is().RowStyles.Add(new RowStyle());
		@is().RowStyles.Add(new RowStyle());
		@is().RowStyles.Add(new RowStyle());
		@is().Size = new Size(1176, 145);
		@is().TabIndex = 126;
		wd().Anchor = AnchorStyles.None;
		@is().SetColumnSpan(wd(), 6);
		wd().Location = new Point(800, 13);
		wd().Name = "ButtonAdvanced";
		wd().Size = new Size(110, 24);
		wd().TabIndex = 0;
		wd().Text = "Advanced...";
		wd().UseVisualStyleBackColor = true;
		k4().Anchor = AnchorStyles.Left | AnchorStyles.Right;
		@is().SetColumnSpan(k4(), 2);
		k4().Image = Resources.OutlineHorizExpanded;
		k4().Location = new Point(1049, 66);
		k4().Margin = new Padding(0);
		k4().Name = "PictureBoxFSOutlineNonuniformity";
		k4().Size = new Size(126, 11);
		k4().SizeMode = PictureBoxSizeMode.CenterImage;
		k4().TabIndex = 128;
		k4().TabStop = false;
		aee().SetToolTip(k4(), "Click to toggle Expansion/Contraction");
		k5().Image = Resources.OutlineHorizDivider;
		k5().Location = new Point(1175, 66);
		k5().Margin = new Padding(0);
		k5().Name = "PictureBoxNURight";
		k5().Size = new Size(1, 11);
		k5().TabIndex = 129;
		k5().TabStop = false;
		kw().Anchor = AnchorStyles.None;
		kw().AutoSize = true;
		kw().BackColor = Color.Transparent;
		kw().Cursor = Cursors.Default;
		kw().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		kw().ForeColor = SystemColors.ControlText;
		kw().Location = new Point(1140, 100);
		kw().Margin = new Padding(11, 3, 2, 3);
		kw().Name = "CheckBoxSolveForNonuniformity";
		kw().RightToLeft = RightToLeft.No;
		@is().SetRowSpan(kw(), 2);
		kw().Size = new Size(31, 20);
		kw().TabIndex = 129;
		kw().Text = " ";
		aee().SetToolTip(kw(), "Measure nonuniformity");
		kw().UseVisualStyleBackColor = false;
		kx().Anchor = AnchorStyles.None;
		kx().BackColor = SystemColors.Window;
		kx().Cursor = Cursors.Default;
		kx().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		kx().ForeColor = SystemColors.WindowText;
		kx().f(A_0: false);
		kx().Location = new Point(1064, 99);
		kx().Margin = new Padding(15, 3, 0, 3);
		kx().Name = "TextBoxNumNonuniformity";
		kx().e(A_0: false);
		kx().RightToLeft = RightToLeft.No;
		@is().SetRowSpan(kx(), 2);
		kx().Size = new Size(63, 22);
		kx().TabIndex = 263;
		kx().TextAlign = HorizontalAlignment.Right;
		aee().SetToolTip(kx(), "Nonuniformity of layer within measurement spot");
		ky().Anchor = AnchorStyles.None;
		ky().AutoSize = true;
		ky().BackColor = Color.Transparent;
		ky().Cursor = Cursors.Default;
		ky().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ky().ForeColor = Color.DimGray;
		ky().Location = new Point(1129, 77);
		ky().Margin = new Padding(0);
		ky().Name = "LabelVaryNonuniformity";
		ky().RightToLeft = RightToLeft.No;
		ky().Size = new Size(44, 16);
		ky().TabIndex = 265;
		ky().Text = "Meas.";
		ky().TextAlign = ContentAlignment.MiddleCenter;
		ky().Visible = false;
		kz().Anchor = AnchorStyles.None;
		kz().AutoSize = true;
		kz().BackColor = Color.Transparent;
		kz().Cursor = Cursors.Default;
		kz().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		kz().ForeColor = SystemColors.ControlText;
		kz().Location = new Point(1082, 77);
		kz().Margin = new Padding(17, 0, 0, 0);
		kz().Name = "LabelNonuniformityUnits";
		kz().RightToLeft = RightToLeft.No;
		kz().Size = new Size(28, 16);
		kz().TabIndex = 264;
		kz().Text = "(%)";
		kz().TextAlign = ContentAlignment.MiddleCenter;
		aee().SetToolTip(kz(), "Click to toggle units");
		k0().Anchor = AnchorStyles.None;
		k0().AutoSize = true;
		k0().BackColor = Color.Transparent;
		@is().SetColumnSpan(k0(), 2);
		k0().Cursor = Cursors.Default;
		k0().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		k0().ForeColor = Color.DimGray;
		k0().Location = new Point(1068, 50);
		k0().Margin = new Padding(2, 0, 2, 0);
		k0().Name = "LabelSummaryNonuniformity";
		k0().RightToLeft = RightToLeft.No;
		k0().Size = new Size(87, 16);
		k0().TabIndex = 261;
		k0().Text = "Nonuniformity";
		k0().TextAlign = ContentAlignment.MiddleCenter;
		k1().Anchor = AnchorStyles.None;
		k1().AutoSize = true;
		k1().BackColor = Color.Transparent;
		@is().SetColumnSpan(k1(), 6);
		k1().Cursor = Cursors.Default;
		k1().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		k1().ForeColor = Color.DimGray;
		k1().Location = new Point(821, 50);
		k1().Margin = new Padding(2, 0, 2, 0);
		k1().Name = "LabelSummaryThickness";
		k1().RightToLeft = RightToLeft.No;
		k1().Size = new Size(67, 16);
		k1().TabIndex = 260;
		k1().Text = "Thickness";
		k1().TextAlign = ContentAlignment.MiddleCenter;
		k2().Anchor = AnchorStyles.None;
		k2().AutoSize = true;
		k2().BackColor = Color.Transparent;
		@is().SetColumnSpan(k2(), 12);
		k2().Cursor = Cursors.Default;
		k2().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		k2().ForeColor = Color.DimGray;
		k2().Location = new Point(348, 50);
		k2().Margin = new Padding(2, 0, 2, 0);
		k2().Name = "LabelSummaryComposition";
		k2().RightToLeft = RightToLeft.No;
		k2().Size = new Size(80, 16);
		k2().TabIndex = 260;
		k2().Text = "Composition";
		k2().TextAlign = ContentAlignment.MiddleCenter;
		k3().Anchor = AnchorStyles.Left | AnchorStyles.Right;
		@is().SetColumnSpan(k3(), 6);
		k3().Image = Resources.OutlineHorizExpanded;
		k3().Location = new Point(662, 66);
		k3().Margin = new Padding(0);
		k3().Name = "PictureBoxFSOutlineThickness";
		k3().Size = new Size(386, 11);
		k3().SizeMode = PictureBoxSizeMode.CenterImage;
		k3().TabIndex = 127;
		k3().TabStop = false;
		aee().SetToolTip(k3(), "Click to toggle Expansion/Contraction");
		kt().Image = Resources.OutlineHorizDivider;
		kt().Location = new Point(1048, 66);
		kt().Margin = new Padding(0);
		kt().Name = "PictureBox6";
		kt().Size = new Size(1, 11);
		kt().TabIndex = 128;
		kt().TabStop = false;
		ku().Anchor = AnchorStyles.None;
		ku().AutoSize = true;
		ku().BackColor = Color.Transparent;
		ku().Cursor = Cursors.Default;
		ku().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ku().ForeColor = Color.DimGray;
		ku().Location = new Point(939, 77);
		ku().Margin = new Padding(0, 0, 5, 0);
		ku().Name = "LabelThicknessRefine";
		ku().RightToLeft = RightToLeft.No;
		ku().Size = new Size(63, 16);
		ku().TabIndex = 265;
		ku().Text = "Refine via";
		ku().TextAlign = ContentAlignment.MiddleCenter;
		km().Anchor = AnchorStyles.None;
		km().AutoSize = true;
		km().BackColor = Color.Transparent;
		km().Cursor = Cursors.Default;
		km().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		km().ForeColor = SystemColors.ControlText;
		km().Location = new Point(864, 100);
		km().Margin = new Padding(9, 3, 0, 3);
		km().Name = "CheckBoxSolveForThickness";
		km().RightToLeft = RightToLeft.No;
		@is().SetRowSpan(km(), 2);
		km().Size = new Size(31, 20);
		km().TabIndex = 128;
		km().Text = " ";
		aee().SetToolTip(km(), "Measure layer thickness");
		km().UseVisualStyleBackColor = false;
		kv().Anchor = AnchorStyles.Left | AnchorStyles.Right;
		kv().DropDownStyle = ComboBoxStyle.DropDownList;
		kv().FormattingEnabled = true;
		kv().Location = new Point(898, 100);
		kv().Margin = new Padding(0, 3, 6, 3);
		kv().Name = "ComboBoxThicknessRefine";
		@is().SetRowSpan(kv(), 2);
		kv().Size = new Size(144, 24);
		kv().TabIndex = 133;
		aee().SetToolTip(kv(), "If varied, refine thickness guess during initial pass using selected method");
		kl().Anchor = AnchorStyles.None;
		kl().AutoSize = true;
		kl().BackColor = Color.Transparent;
		kl().Cursor = Cursors.Default;
		kl().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		kl().ForeColor = Color.DimGray;
		kl().Location = new Point(854, 77);
		kl().Margin = new Padding(2, 0, 0, 0);
		kl().Name = "LabelVaryThickness";
		kl().RightToLeft = RightToLeft.No;
		kl().Size = new Size(44, 16);
		kl().TabIndex = 264;
		kl().Text = "Meas.";
		kl().TextAlign = ContentAlignment.MiddleCenter;
		kl().Visible = false;
		kn().Anchor = AnchorStyles.Left;
		kn().AutoSize = true;
		kn().BackColor = Color.Transparent;
		kn().Cursor = Cursors.Default;
		kn().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		kn().ForeColor = SystemColors.ControlText;
		kn().Location = new Point(822, 77);
		kn().Margin = new Padding(0, 0, 2, 0);
		kn().Name = "LabelThicknessRangeUnits";
		kn().RightToLeft = RightToLeft.No;
		kn().Size = new Size(28, 16);
		kn().TabIndex = 260;
		kn().Text = "(%)";
		kn().TextAlign = ContentAlignment.MiddleCenter;
		aee().SetToolTip(kn(), "Click to toggle units");
		ko().Anchor = AnchorStyles.Right;
		ko().AutoSize = true;
		ko().BackColor = Color.Transparent;
		ko().Cursor = Cursors.Default;
		ko().FlatStyle = FlatStyle.System;
		ko().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ko().ForeColor = Color.DimGray;
		ko().Location = new Point(777, 77);
		ko().Margin = new Padding(4, 0, 0, 0);
		ko().Name = "LabelThicknessRange";
		ko().RightToLeft = RightToLeft.No;
		ko().Size = new Size(45, 16);
		ko().TabIndex = 265;
		ko().Text = "Range";
		ko().TextAlign = ContentAlignment.MiddleRight;
		kp().Anchor = AnchorStyles.Left | AnchorStyles.Right;
		kp().BackColor = SystemColors.Window;
		@is().SetColumnSpan(kp(), 2);
		kp().Cursor = Cursors.Default;
		kp().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		kp().ForeColor = SystemColors.WindowText;
		kp().f(A_0: false);
		kp().Location = new Point(781, 99);
		kp().Margin = new Padding(8, 3, 8, 3);
		kp().Name = "TextBoxNumThicknessRange";
		kp().e(A_0: false);
		kp().RightToLeft = RightToLeft.No;
		@is().SetRowSpan(kp(), 2);
		kp().Size = new Size(63, 22);
		kp().TabIndex = 260;
		kp().Text = "10000000";
		aee().SetToolTip(kp(), "Constraint for layer thickness if varied");
		kq().Anchor = AnchorStyles.None;
		kq().AutoSize = true;
		kq().BackColor = Color.Transparent;
		kq().Cursor = Cursors.Default;
		kq().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		kq().ForeColor = SystemColors.ControlText;
		kq().Location = new Point(758, 102);
		kq().Margin = new Padding(0);
		kq().Name = "LabelThicknessPlusMinus";
		kq().RightToLeft = RightToLeft.No;
		@is().SetRowSpan(kq(), 2);
		kq().Size = new Size(15, 16);
		kq().TabIndex = 259;
		kq().Text = "±";
		kq().TextAlign = ContentAlignment.MiddleCenter;
		kr().Anchor = AnchorStyles.Left | AnchorStyles.Right;
		kr().BackColor = SystemColors.Window;
		kr().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		kr().ForeColor = SystemColors.WindowText;
		kr().f(A_0: false);
		kr().Location = new Point(677, 99);
		kr().Margin = new Padding(15, 3, 10, 3);
		kr().Name = "TextBoxNumThickness";
		kr().e(A_0: false);
		kr().RightToLeft = RightToLeft.No;
		@is().SetRowSpan(kr(), 2);
		kr().Size = new Size(71, 22);
		kr().TabIndex = 127;
		kr().Text = "20000000";
		kr().TextAlign = HorizontalAlignment.Right;
		aee().SetToolTip(kr(), "Nominal thickness of layer");
		ks().Anchor = AnchorStyles.None;
		ks().AutoSize = true;
		ks().BackColor = Color.Transparent;
		ks().Cursor = Cursors.Default;
		ks().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ks().ForeColor = Color.DimGray;
		ks().Location = new Point(672, 77);
		ks().Margin = new Padding(9, 0, 0, 0);
		ks().Name = "LabelThickness";
		ks().RightToLeft = RightToLeft.No;
		ks().Size = new Size(85, 16);
		ks().TabIndex = 264;
		ks().Text = "Nominal (nm)";
		ks().TextAlign = ContentAlignment.MiddleCenter;
		kj().Anchor = AnchorStyles.None;
		kj().BackColor = SystemColors.Control;
		kj().BackgroundImage = Resources.Insert;
		kj().BackgroundImageLayout = ImageLayout.Center;
		kj().Cursor = Cursors.Default;
		kj().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		kj().ForeColor = SystemColors.ControlText;
		kj().Location = new Point(2, 116);
		kj().Margin = new Padding(2, 5, 2, 5);
		kj().Name = "ButtonInsertLayer1";
		kj().RightToLeft = RightToLeft.No;
		@is().SetRowSpan(kj(), 2);
		kj().Size = new Size(24, 24);
		kj().TabIndex = 128;
		kj().TextAlign = ContentAlignment.BottomCenter;
		aee().SetToolTip(kj(), "Insert Layer");
		kj().UseVisualStyleBackColor = true;
		kk().Anchor = AnchorStyles.Left | AnchorStyles.Right;
		kk().BackColor = Color.Transparent;
		@is().SetColumnSpan(kk(), 12);
		kk().Image = Resources.OutlineHorizExpanded;
		kk().Location = new Point(116, 66);
		kk().Margin = new Padding(0);
		kk().Name = "PictureBoxFSOutlineComposition";
		kk().Size = new Size(545, 11);
		kk().SizeMode = PictureBoxSizeMode.CenterImage;
		kk().TabIndex = 127;
		kk().TabStop = false;
		aee().SetToolTip(kk(), "Click to toggle Expansion/Contraction");
		kg().Image = Resources.OutlineHorizDivider;
		kg().Location = new Point(661, 66);
		kg().Margin = new Padding(0);
		kg().Name = "PictureBox3";
		kg().Size = new Size(1, 11);
		kg().TabIndex = 127;
		kg().TabStop = false;
		kh().Anchor = AnchorStyles.None;
		kh().AutoSize = true;
		kh().BackColor = Color.Transparent;
		kh().Cursor = Cursors.Default;
		kh().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		kh().ForeColor = SystemColors.ControlText;
		kh().Location = new Point(574, 100);
		kh().Margin = new Padding(6, 3, 0, 3);
		kh().Name = "CheckBoxSolveForGrading";
		kh().RightToLeft = RightToLeft.No;
		@is().SetRowSpan(kh(), 2);
		kh().Size = new Size(31, 20);
		kh().TabIndex = 127;
		kh().Text = " ";
		aee().SetToolTip(kh(), "Measure compositional grading");
		kh().UseVisualStyleBackColor = false;
		kc().Anchor = AnchorStyles.None;
		kc().AutoSize = true;
		kc().BackColor = Color.Transparent;
		@is().SetColumnSpan(kc(), 2);
		kc().Cursor = Cursors.Default;
		kc().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		kc().ForeColor = SystemColors.ControlText;
		kc().Location = new Point(492, 102);
		kc().Margin = new Padding(2, 0, 0, 0);
		kc().Name = "LabelGradingUnits";
		kc().RightToLeft = RightToLeft.No;
		@is().SetRowSpan(kc(), 2);
		kc().Size = new Size(20, 16);
		kc().TabIndex = 262;
		kc().Text = "%";
		kc().TextAlign = ContentAlignment.MiddleCenter;
		kd().Anchor = AnchorStyles.Left | AnchorStyles.Right;
		kd().BackColor = SystemColors.Window;
		kd().Cursor = Cursors.Default;
		kd().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		kd().ForeColor = SystemColors.WindowText;
		kd().f(A_0: false);
		kd().Location = new Point(456, 99);
		kd().Margin = new Padding(8, 3, 0, 3);
		kd().Name = "TextBoxNumGrading";
		kd().e(A_0: true);
		kd().RightToLeft = RightToLeft.No;
		@is().SetRowSpan(kd(), 2);
		kd().Size = new Size(34, 22);
		kd().TabIndex = 262;
		kd().TextAlign = HorizontalAlignment.Right;
		aee().SetToolTip(kd(), componentResourceManager.GetString("TextBoxNumGrading.ToolTip"));
		ke().Anchor = AnchorStyles.Right;
		ke().AutoSize = true;
		ke().BackColor = Color.Transparent;
		@is().SetColumnSpan(ke(), 2);
		ke().Cursor = Cursors.Default;
		ke().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ke().ForeColor = Color.DimGray;
		ke().Location = new Point(452, 77);
		ke().Margin = new Padding(3, 0, 5, 0);
		ke().Name = "LabelGrading";
		ke().RightToLeft = RightToLeft.No;
		ke().Size = new Size(53, 16);
		ke().TabIndex = 261;
		ke().Text = "Grading";
		ke().TextAlign = ContentAlignment.MiddleCenter;
		kf().Anchor = AnchorStyles.None;
		kf().AutoSize = true;
		kf().BackColor = Color.Transparent;
		@is().SetColumnSpan(kf(), 2);
		kf().Cursor = Cursors.Default;
		kf().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		kf().ForeColor = Color.DimGray;
		kf().Location = new Point(404, 77);
		kf().Margin = new Padding(0);
		kf().Name = "LabelVaryNK";
		kf().RightToLeft = RightToLeft.No;
		kf().Size = new Size(44, 16);
		kf().TabIndex = 262;
		kf().Text = "Meas.";
		kf().TextAlign = ContentAlignment.MiddleCenter;
		j7().Anchor = AnchorStyles.None;
		j7().BackColor = SystemColors.Window;
		@is().SetColumnSpan(j7(), 2);
		j7().Cursor = Cursors.Default;
		j7().Enabled = false;
		j7().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		j7().ForeColor = SystemColors.WindowText;
		j7().f(A_0: false);
		j7().Location = new Point(374, 99);
		j7().Margin = new Padding(2, 3, 2, 3);
		j7().Name = "TextBoxNumDeltaK";
		j7().e(A_0: false);
		j7().RightToLeft = RightToLeft.No;
		@is().SetRowSpan(j7(), 2);
		j7().Size = new Size(30, 22);
		j7().TabIndex = 127;
		j7().TextAlign = HorizontalAlignment.Right;
		aee().SetToolTip(j7(), "Constraint on Extinction Coefficient (set to zero to disable measurement)");
		j8().Anchor = AnchorStyles.None;
		j8().BackColor = SystemColors.Window;
		j8().Cursor = Cursors.Default;
		j8().Enabled = false;
		j8().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		j8().ForeColor = SystemColors.WindowText;
		j8().f(A_0: false);
		j8().Location = new Point(340, 99);
		j8().Margin = new Padding(3, 3, 2, 3);
		j8().Name = "TextBoxNumDeltaN";
		j8().e(A_0: false);
		j8().RightToLeft = RightToLeft.No;
		@is().SetRowSpan(j8(), 2);
		j8().Size = new Size(30, 22);
		j8().TabIndex = 127;
		j8().TextAlign = HorizontalAlignment.Right;
		aee().SetToolTip(j8(), "Constraint on Refractive Index (set to zero to disable measurement)");
		j9().Anchor = AnchorStyles.None;
		j9().AutoSize = true;
		j9().BackColor = Color.Transparent;
		j9().Cursor = Cursors.Default;
		j9().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		j9().ForeColor = Color.DimGray;
		j9().Location = new Point(377, 77);
		j9().Margin = new Padding(2, 0, 2, 0);
		j9().Name = "LabelKColumn";
		j9().RightToLeft = RightToLeft.No;
		j9().Size = new Size(22, 16);
		j9().TabIndex = 260;
		j9().Text = "±k";
		j9().TextAlign = ContentAlignment.MiddleCenter;
		ka().Anchor = AnchorStyles.None;
		ka().AutoSize = true;
		ka().BackColor = Color.Transparent;
		ka().Cursor = Cursors.Default;
		ka().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ka().ForeColor = Color.DimGray;
		ka().Location = new Point(343, 77);
		ka().Margin = new Padding(2, 0, 2, 0);
		ka().Name = "LabelNColumn";
		ka().RightToLeft = RightToLeft.No;
		ka().Size = new Size(22, 16);
		ka().TabIndex = 259;
		ka().Text = "±n";
		ka().TextAlign = ContentAlignment.MiddleCenter;
		j1().Anchor = AnchorStyles.None;
		j1().BackColor = SystemColors.Control;
		j1().BackgroundImage = Resources.DropDownImage;
		j1().BackgroundImageLayout = ImageLayout.Center;
		j1().Cursor = Cursors.Default;
		j1().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		j1().ForeColor = SystemColors.ControlText;
		j1().Location = new Point(316, 99);
		j1().Margin = new Padding(0, 3, 2, 3);
		j1().Name = "ButtonGetMaterial";
		j1().RightToLeft = RightToLeft.No;
		@is().SetRowSpan(j1(), 2);
		j1().Size = new Size(19, 22);
		j1().TabIndex = 127;
		j1().TextAlign = ContentAlignment.BottomCenter;
		aee().SetToolTip(j1(), "Drop-down list of Materials");
		j1().UseVisualStyleBackColor = true;
		j2().AcceptsReturn = true;
		j2().Anchor = AnchorStyles.None;
		j2().BackColor = SystemColors.Window;
		@is().SetColumnSpan(j2(), 2);
		j2().Cursor = Cursors.IBeam;
		j2().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		j2().ForeColor = SystemColors.WindowText;
		j2().Location = new Point(118, 99);
		j2().Margin = new Padding(2, 3, 2, 3);
		j2().MaxLength = 0;
		j2().Name = "TextBoxMaterial";
		j2().ReadOnly = true;
		j2().RightToLeft = RightToLeft.No;
		@is().SetRowSpan(j2(), 2);
		j2().Size = new Size(196, 22);
		j2().TabIndex = 127;
		j2().TabStop = false;
		j2().Text = "ITO fluoro surf- Pilkington.nnn";
		aee().SetToolTip(j2(), "Layer material - Click to open search dialog");
		j4().Anchor = AnchorStyles.None;
		j4().AutoSize = true;
		j4().BackColor = Color.Transparent;
		j4().Cursor = Cursors.Default;
		j4().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		j4().ForeColor = Color.DimGray;
		j4().Location = new Point(61, 77);
		j4().Margin = new Padding(2, 0, 2, 0);
		j4().Name = "LabelLayerIDColumn";
		j4().RightToLeft = RightToLeft.No;
		j4().Size = new Size(40, 16);
		j4().TabIndex = 259;
		j4().Text = "Layer";
		j4().TextAlign = ContentAlignment.MiddleCenter;
		j5().Anchor = AnchorStyles.None;
		j5().AutoSize = true;
		j5().BackColor = Color.Transparent;
		j5().Cursor = Cursors.Default;
		j5().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		j5().ForeColor = SystemColors.ControlText;
		j5().Location = new Point(50, 102);
		j5().Margin = new Padding(2, 0, 1, 0);
		j5().Name = "LabelFilmStackLayerLabel";
		j5().RightToLeft = RightToLeft.No;
		@is().SetRowSpan(j5(), 2);
		j5().Size = new Size(64, 16);
		j5().TabIndex = 258;
		j5().Text = "Substrate";
		j5().TextAlign = ContentAlignment.MiddleCenter;
		j6().Anchor = AnchorStyles.None;
		j6().BackColor = SystemColors.Control;
		j6().BackgroundImage = Resources.x;
		j6().BackgroundImageLayout = ImageLayout.Center;
		j6().Cursor = Cursors.Default;
		j6().FlatAppearance.BorderColor = SystemColors.HotTrack;
		j6().FlatAppearance.BorderSize = 0;
		j6().FlatAppearance.MouseDownBackColor = Color.White;
		j6().FlatAppearance.MouseOverBackColor = Color.White;
		j6().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		j6().ForeColor = SystemColors.ControlText;
		j6().Location = new Point(30, 101);
		j6().Margin = new Padding(2, 3, 0, 3);
		j6().Name = "ButtonDeleteLayer";
		j6().RightToLeft = RightToLeft.No;
		@is().SetRowSpan(j6(), 2);
		j6().Size = new Size(18, 19);
		j6().TabIndex = 127;
		j6().TextAlign = ContentAlignment.BottomCenter;
		aee().SetToolTip(j6(), "Delete Layer");
		j6().UseVisualStyleBackColor = true;
		it().Anchor = AnchorStyles.None;
		it().BackColor = SystemColors.Control;
		it().BackgroundImage = Resources.Insert;
		it().BackgroundImageLayout = ImageLayout.Center;
		it().Cursor = Cursors.Default;
		it().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		it().ForeColor = SystemColors.ControlText;
		it().Location = new Point(2, 82);
		it().Margin = new Padding(2, 5, 2, 5);
		it().Name = "ButtonInsertLayer0";
		it().RightToLeft = RightToLeft.No;
		@is().SetRowSpan(it(), 2);
		it().Size = new Size(24, 24);
		it().TabIndex = 127;
		it().TextAlign = ContentAlignment.BottomCenter;
		aee().SetToolTip(it(), "Insert Layer");
		it().UseVisualStyleBackColor = true;
		kb().Anchor = AnchorStyles.None;
		kb().AutoSize = true;
		kb().BackColor = Color.Transparent;
		kb().Cursor = Cursors.Default;
		kb().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		kb().ForeColor = SystemColors.ControlText;
		kb().Location = new Point(414, 100);
		kb().Margin = new Padding(8, 3, 2, 3);
		kb().Name = "CheckBoxSolveForNK";
		kb().RightToLeft = RightToLeft.No;
		@is().SetRowSpan(kb(), 2);
		kb().Size = new Size(31, 20);
		kb().TabIndex = 127;
		kb().Text = " ";
		aee().SetToolTip(kb(), "Measure n and k within range defined by constraints");
		kb().UseVisualStyleBackColor = false;
		ki().Anchor = AnchorStyles.None;
		ki().AutoSize = true;
		ki().BackColor = Color.Transparent;
		@is().SetColumnSpan(ki(), 2);
		ki().Cursor = Cursors.Default;
		ki().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ki().ForeColor = Color.DimGray;
		ki().Location = new Point(563, 77);
		ki().Margin = new Padding(0);
		ki().Name = "LabelVaryGrading";
		ki().RightToLeft = RightToLeft.No;
		ki().Size = new Size(44, 16);
		ki().TabIndex = 263;
		ki().Text = "Meas.";
		ki().TextAlign = ContentAlignment.MiddleCenter;
		j3().Anchor = AnchorStyles.Right;
		j3().Image = Resources.OutlineHorizDivider;
		j3().Location = new Point(115, 66);
		j3().Margin = new Padding(0);
		j3().Name = "PictureBox1";
		j3().Size = new Size(1, 11);
		j3().TabIndex = 127;
		j3().TabStop = false;
		co().Anchor = AnchorStyles.Left;
		co().AutoSize = true;
		co().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		co().ColumnCount = 3;
		@is().SetColumnSpan(co(), 5);
		co().ColumnStyles.Add(new ColumnStyle());
		co().ColumnStyles.Add(new ColumnStyle());
		co().ColumnStyles.Add(new ColumnStyle());
		co().Controls.Add(cl(), 0, 0);
		co().Controls.Add(cm(), 1, 0);
		co().Controls.Add(zh(), 2, 0);
		co().Location = new Point(3, 10);
		co().Name = "TLPUnits";
		co().RowCount = 1;
		co().RowStyles.Add(new RowStyle());
		co().Size = new Size(272, 30);
		co().TabIndex = 126;
		cl().Anchor = AnchorStyles.None;
		cl().BackColor = Color.Transparent;
		cl().Cursor = Cursors.Default;
		cl().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cl().ForeColor = SystemColors.ControlText;
		cl().Location = new Point(3, 6);
		cl().Margin = new Padding(3, 0, 0, 0);
		cl().Name = "LabelUnits";
		cl().RightToLeft = RightToLeft.No;
		cl().Size = new Size(45, 17);
		cl().TabIndex = 306;
		cl().Text = "Units:";
		cm().Anchor = AnchorStyles.None;
		cm().BackColor = SystemColors.Window;
		cm().Cursor = Cursors.Default;
		cm().DropDownStyle = ComboBoxStyle.DropDownList;
		cm().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cm().ForeColor = SystemColors.WindowText;
		cm().FormattingEnabled = true;
		cm().Location = new Point(48, 3);
		cm().Margin = new Padding(0, 3, 3, 3);
		cm().Name = "cboUnit";
		cm().RightToLeft = RightToLeft.No;
		cm().Size = new Size(160, 24);
		cm().TabIndex = 303;
		aee().SetToolTip(cm(), "Units for thicknesses");
		zh().Location = new Point(214, 3);
		zh().Name = "BtnEditCustomUnit";
		zh().Size = new Size(55, 24);
		zh().TabIndex = 307;
		zh().Text = "Edit...";
		zh().UseVisualStyleBackColor = true;
		zh().Visible = false;
		zl().Anchor = AnchorStyles.Right;
		zl().AutoSize = true;
		zl().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		zl().ColumnCount = 2;
		zl().ColumnStyles.Add(new ColumnStyle());
		zl().ColumnStyles.Add(new ColumnStyle());
		zl().Controls.Add(zk(), 1, 0);
		zl().Controls.Add(zj(), 0, 0);
		zl().Location = new Point(340, 98);
		zl().Name = "TableLayoutPanelStackRepeatNumber";
		zl().RowCount = 1;
		@is().SetRowSpan(zl(), 2);
		zl().RowStyles.Add(new RowStyle());
		zl().Size = new Size(1, 25);
		zl().TabIndex = 268;
		zk().Anchor = AnchorStyles.Left;
		zk().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		zk().f(A_0: true);
		zk().Location = new Point(67, 3);
		zk().Margin = new Padding(0, 3, 20, 0);
		zk().MaxLength = 12;
		zk().Name = "TextBoxNumStackRepeats";
		zk().e(A_0: false);
		zk().Size = new Size(32, 22);
		zk().TabIndex = 267;
		zk().Text = "123";
		zj().Anchor = AnchorStyles.Right;
		zj().AutoSize = true;
		zj().Location = new Point(3, 6);
		zj().Margin = new Padding(3, 3, 0, 0);
		zj().Name = "LabelStackRepeatNumber";
		zj().Size = new Size(64, 16);
		zj().TabIndex = 266;
		zj().Text = "# Stacks:";
		zj().TextAlign = ContentAlignment.MiddleRight;
		cj().AutoScroll = true;
		cj().Controls.Add(li());
		cj().Controls.Add(cx());
		cj().Location = new Point(4, 25);
		cj().Margin = new Padding(2, 3, 2, 3);
		cj().Name = "TabPageAnalysisOptions";
		cj().Padding = new Padding(2, 3, 2, 3);
		cj().Size = new Size(779, 464);
		cj().TabIndex = 1;
		cj().Text = "Analysis Options";
		cj().UseVisualStyleBackColor = true;
		li().AutoSize = true;
		li().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		li().Controls.Add(lj());
		li().Controls.Add(k8());
		li().Location = new Point(0, 10);
		li().Name = "PanelAnalysisOptionsMain";
		li().Size = new Size(535, 448);
		li().TabIndex = 30;
		lj().AutoSize = true;
		lj().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		lj().ColumnCount = 1;
		lj().ColumnStyles.Add(new ColumnStyle());
		lj().Controls.Add(cp(), 0, 1);
		lj().Controls.Add(k9(), 0, 0);
		lj().Location = new Point(220, 0);
		lj().Margin = new Padding(3, 0, 3, 3);
		lj().Name = "TLPAnalysisMethod";
		lj().RowCount = 2;
		lj().RowStyles.Add(new RowStyle());
		lj().RowStyles.Add(new RowStyle());
		lj().Size = new Size(312, 327);
		lj().TabIndex = 30;
		cp().Anchor = AnchorStyles.None;
		cp().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cp().Location = new Point(98, 291);
		cp().Name = "AdvancedOptionsButton";
		cp().Size = new Size(115, 33);
		cp().TabIndex = 24;
		cp().Text = "Advanced...";
		cp().UseVisualStyleBackColor = true;
		k9().Anchor = AnchorStyles.None;
		k9().Controls.Add(la());
		k9().Controls.Add(lb());
		k9().Controls.Add(lh());
		k9().ForeColor = Color.DimGray;
		k9().Location = new Point(3, 0);
		k9().Margin = new Padding(3, 0, 3, 3);
		k9().Name = "GroupBoxOptionsAnalysisMethod";
		k9().Padding = new Padding(3, 0, 3, 3);
		k9().Size = new Size(306, 285);
		k9().TabIndex = 29;
		k9().TabStop = false;
		k9().Text = "Analysis Method";
		la().AutoSize = true;
		la().BackColor = Color.Transparent;
		la().Cursor = Cursors.Default;
		la().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		la().ForeColor = SystemColors.ControlText;
		la().Location = new Point(21, 50);
		la().Name = "RadioButtonOptionsSpectrumMatching";
		la().RightToLeft = RightToLeft.No;
		la().Size = new Size(139, 20);
		la().TabIndex = 3;
		la().TabStop = true;
		la().Text = "Spectrum matching";
		aeg().SetToolTip(la(), "Analyze Spectrum by varying measured parameters to obtain best match between theoretical and measured spectra");
		la().UseVisualStyleBackColor = false;
		lb().Controls.Add(lc());
		lb().Controls.Add(ld());
		lb().Controls.Add(lg());
		lb().Location = new Point(11, 53);
		lb().Name = "GroupBoxOptionsSpectrumMatching";
		lb().Size = new Size(284, 221);
		lb().TabIndex = 4;
		lb().TabStop = false;
		lc().AutoSize = true;
		lc().BackColor = Color.Transparent;
		lc().Cursor = Cursors.Default;
		lc().Enabled = false;
		lc().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lc().ForeColor = SystemColors.ControlText;
		lc().Location = new Point(28, 51);
		lc().Name = "RadioButtonOptionsExact";
		lc().RightToLeft = RightToLeft.No;
		lc().Size = new Size(60, 20);
		lc().TabIndex = 4;
		lc().TabStop = true;
		lc().Text = "Exact";
		aeg().SetToolTip(lc(), "Use strict matching of measured and theoretical spectra");
		lc().UseVisualStyleBackColor = false;
		ld().Controls.Add(cw());
		ld().Controls.Add(ir());
		ld().Controls.Add(le());
		ld().Controls.Add(lf());
		ld().Controls.Add(dj());
		ld().Controls.Add(dk());
		ld().Location = new Point(11, 54);
		ld().Name = "GroupBox1";
		ld().Size = new Size(262, 156);
		ld().TabIndex = 5;
		ld().TabStop = false;
		cw().AutoSize = true;
		cw().Enabled = false;
		cw().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cw().ForeColor = SystemColors.ControlText;
		cw().Location = new Point(27, 127);
		cw().Name = "CheckBoxLockIdenticalComposition";
		cw().Size = new Size(99, 20);
		cw().TabIndex = 5;
		cw().Text = "Composition";
		cw().UseVisualStyleBackColor = true;
		ir().AutoSize = true;
		ir().Enabled = false;
		ir().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ir().ForeColor = SystemColors.ControlText;
		ir().Location = new Point(27, 107);
		ir().Name = "CheckBoxLockIdenticalThickness";
		ir().Size = new Size(86, 20);
		ir().TabIndex = 6;
		ir().Text = "Thickness";
		ir().UseVisualStyleBackColor = true;
		le().AutoSize = true;
		le().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		le().ForeColor = Color.DimGray;
		le().Location = new Point(14, 87);
		le().Name = "LabelOptionsLocking";
		le().Size = new Size(209, 16);
		le().TabIndex = 23;
		le().Text = "Lock together layers with identical:";
		lf().AutoSize = true;
		lf().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lf().ForeColor = Color.DimGray;
		lf().Location = new Point(14, 18);
		lf().Name = "LabelOptionsCompensateFor";
		lf().Size = new Size(103, 16);
		lf().TabIndex = 22;
		lf().Text = "Compensate for:";
		dj().BackColor = Color.Transparent;
		dj().Cursor = Cursors.Default;
		dj().Enabled = false;
		dj().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dj().ForeColor = SystemColors.ControlText;
		dj().Location = new Point(27, 58);
		dj().Name = "CheckBoxAccountForNonPlanarity";
		dj().RightToLeft = RightToLeft.No;
		dj().Size = new Size(199, 20);
		dj().TabIndex = 9;
		dj().Text = "Tilted sample/Lost light";
		aeg().SetToolTip(dj(), "Compensate for errors caused by non-flat samples");
		dj().UseVisualStyleBackColor = false;
		dk().AutoSize = true;
		dk().BackColor = Color.Transparent;
		dk().Cursor = Cursors.Default;
		dk().Enabled = false;
		dk().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dk().ForeColor = SystemColors.ControlText;
		dk().Location = new Point(27, 37);
		dk().Name = "CheckBoxAccountForBacksideRefl";
		dk().RightToLeft = RightToLeft.No;
		dk().Size = new Size(211, 20);
		dk().TabIndex = 8;
		dk().Text = "Unmodeled backside reflections";
		aeg().SetToolTip(dk(), "Compensate for light reflected from far surface of substrate\r\nor similar types of errors");
		dk().UseVisualStyleBackColor = false;
		lg().AutoSize = true;
		lg().BackColor = Color.Transparent;
		lg().Cursor = Cursors.Default;
		lg().Enabled = false;
		lg().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lg().ForeColor = SystemColors.ControlText;
		lg().Location = new Point(28, 24);
		lg().Name = "RadioButtonOptionsRobust";
		lg().RightToLeft = RightToLeft.No;
		lg().Size = new Size(218, 20);
		lg().TabIndex = 3;
		lg().TabStop = true;
		lg().Text = "Robust (adaptive; thickness only)";
		aeg().SetToolTip(lg(), "Use proprietary adaptive method,\r\ncompensating for certain common inaccuracies \r\nin measured data or film stack definition");
		lg().UseVisualStyleBackColor = false;
		lh().AutoSize = true;
		lh().BackColor = Color.Transparent;
		lh().Cursor = Cursors.Default;
		lh().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lh().ForeColor = SystemColors.ControlText;
		lh().Location = new Point(21, 21);
		lh().Name = "RadioButtonOptionsFFT";
		lh().RightToLeft = RightToLeft.No;
		lh().Size = new Size(145, 20);
		lh().TabIndex = 2;
		lh().TabStop = true;
		lh().Text = "FFT (thickness only)";
		aeg().SetToolTip(lh(), "Analyze spectrum using Fast Fourier Transform");
		lh().UseVisualStyleBackColor = false;
		k8().Controls.Add(c9());
		k8().Controls.Add(cq());
		k8().Controls.Add(cu());
		k8().ForeColor = Color.DimGray;
		k8().Location = new Point(0, 0);
		k8().Name = "GroupBoxOptionsDataSelection";
		k8().Size = new Size(209, 445);
		k8().TabIndex = 28;
		k8().TabStop = false;
		k8().Text = "Data Selection";
		c9().BackColor = Color.Transparent;
		c9().Controls.Add(da());
		c9().Controls.Add(db());
		c9().Controls.Add(dc());
		c9().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c9().ForeColor = Color.DimGray;
		c9().Location = new Point(11, 21);
		c9().Name = "RangeFrame";
		c9().RightToLeft = RightToLeft.No;
		c9().Size = new Size(185, 147);
		c9().TabIndex = 20;
		c9().TabStop = false;
		c9().Text = "Wavelength Range";
		da().BackColor = Color.Transparent;
		da().Cursor = Cursors.Default;
		da().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		da().ForeColor = SystemColors.ControlText;
		da().Location = new Point(26, 43);
		da().Name = "RadioButtonOptionsFixedRange";
		da().RightToLeft = RightToLeft.No;
		da().Size = new Size(100, 26);
		da().TabIndex = 2;
		da().TabStop = true;
		da().Text = "Fixed range";
		aeg().SetToolTip(da(), "Wavelength range of data used in analysis is controlled by settings in Recipe");
		da().UseVisualStyleBackColor = false;
		db().BackColor = Color.Transparent;
		db().Cursor = Cursors.Default;
		db().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		db().ForeColor = SystemColors.ControlText;
		db().Location = new Point(26, 22);
		db().Name = "RadioButtonOptionsDisplayedData";
		db().RightToLeft = RightToLeft.No;
		db().Size = new Size(119, 19);
		db().TabIndex = 1;
		db().TabStop = true;
		db().Text = "Displayed data";
		aeg().SetToolTip(db(), "Spectrum Graph Wavelength Axis Limits control Wavelength range of data used in analysis");
		db().UseVisualStyleBackColor = false;
		dc().BackColor = Color.Transparent;
		dc().Controls.Add(dd());
		dc().Controls.Add(de());
		dc().Controls.Add(df());
		dc().Controls.Add(dg());
		dc().Controls.Add(dh());
		dc().Controls.Add(di());
		dc().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dc().ForeColor = SystemColors.ControlText;
		dc().Location = new Point(17, 49);
		dc().Name = "WavelengthLimitsFrame";
		dc().RightToLeft = RightToLeft.No;
		dc().Size = new Size(151, 83);
		dc().TabIndex = 2;
		dc().TabStop = false;
		dd().AcceptsReturn = true;
		dd().BackColor = SystemColors.Window;
		dd().Cursor = Cursors.IBeam;
		dd().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dd().ForeColor = SystemColors.WindowText;
		dd().f(A_0: false);
		dd().Location = new Point(55, 47);
		dd().MaxLength = 0;
		dd().Name = "EndWavelenBox";
		dd().e(A_0: false);
		dd().RightToLeft = RightToLeft.No;
		dd().Size = new Size(57, 22);
		dd().TabIndex = 4;
		dd().Text = "850";
		dd().TextAlign = HorizontalAlignment.Center;
		aeg().SetToolTip(dd(), "End Wavelength for data used in analysis");
		de().AcceptsReturn = true;
		de().BackColor = SystemColors.Window;
		de().Cursor = Cursors.IBeam;
		de().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		de().ForeColor = SystemColors.WindowText;
		de().f(A_0: false);
		de().Location = new Point(55, 20);
		de().MaxLength = 0;
		de().Name = "StartWavelenBox";
		de().e(A_0: false);
		de().RightToLeft = RightToLeft.No;
		de().Size = new Size(57, 22);
		de().TabIndex = 3;
		de().Text = "400";
		de().TextAlign = HorizontalAlignment.Center;
		aeg().SetToolTip(de(), "Start Wavelength for data used in analysis");
		df().AutoSize = true;
		df().BackColor = Color.Transparent;
		df().Cursor = Cursors.Default;
		df().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		df().ForeColor = SystemColors.ControlText;
		df().Location = new Point(32, 50);
		df().Name = "Label27";
		df().RightToLeft = RightToLeft.No;
		df().Size = new Size(21, 16);
		df().TabIndex = 67;
		df().Text = "To";
		df().TextAlign = ContentAlignment.MiddleRight;
		dg().BackColor = Color.Transparent;
		dg().Cursor = Cursors.Default;
		dg().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dg().ForeColor = SystemColors.ControlText;
		dg().Location = new Point(115, 49);
		dg().Name = "Label28";
		dg().RightToLeft = RightToLeft.No;
		dg().Size = new Size(26, 17);
		dg().TabIndex = 66;
		dg().Text = "nm";
		dh().BackColor = Color.Transparent;
		dh().Cursor = Cursors.Default;
		dh().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dh().ForeColor = SystemColors.ControlText;
		dh().Location = new Point(115, 23);
		dh().Name = "Label29";
		dh().RightToLeft = RightToLeft.No;
		dh().Size = new Size(26, 17);
		dh().TabIndex = 65;
		dh().Text = "nm";
		di().AutoSize = true;
		di().BackColor = Color.Transparent;
		di().Cursor = Cursors.Default;
		di().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		di().ForeColor = SystemColors.ControlText;
		di().Location = new Point(15, 23);
		di().Name = "Label31";
		di().RightToLeft = RightToLeft.No;
		di().Size = new Size(38, 16);
		di().TabIndex = 64;
		di().Text = "From";
		di().TextAlign = ContentAlignment.MiddleRight;
		cq().Controls.Add(cr());
		cq().Controls.Add(cs());
		cq().Controls.Add(ct());
		cq().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cq().ForeColor = Color.DimGray;
		cq().Location = new Point(11, 174);
		cq().Name = "GroupBoxAnalysisOptionsPreprocess";
		cq().Size = new Size(185, 77);
		cq().TabIndex = 23;
		cq().TabStop = false;
		cq().Text = "Smoothing";
		cr().AutoSize = true;
		cr().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cr().ForeColor = Color.Black;
		cr().Location = new Point(112, 44);
		cr().Name = "LabelSmoothingUnits";
		cr().Size = new Size(26, 16);
		cr().TabIndex = 39;
		cr().Text = "nm";
		cr().TextAlign = ContentAlignment.MiddleLeft;
		cs().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cs().ForeColor = Color.Black;
		cs().f(A_0: false);
		cs().Location = new Point(39, 41);
		cs().Name = "TextBoxSmoothingThickness";
		cs().e(A_0: false);
		cs().Size = new Size(72, 22);
		cs().TabIndex = 40;
		cs().TextAlign = HorizontalAlignment.Right;
		aeg().SetToolTip(cs(), "Smoothing thickness. Smaller values reduce noise in Measure Spectrum.");
		ct().AutoSize = true;
		ct().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ct().ForeColor = Color.Black;
		ct().Location = new Point(36, 18);
		ct().Name = "Label30";
		ct().Size = new Size(112, 16);
		ct().TabIndex = 38;
		ct().Text = "Optical thickness:";
		ct().TextAlign = ContentAlignment.MiddleRight;
		cu().Controls.Add(vj());
		cu().Controls.Add(ve());
		cu().Controls.Add(vf());
		cu().Controls.Add(vd());
		cu().Controls.Add(cv());
		cu().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cu().ForeColor = Color.DimGray;
		cu().Location = new Point(11, 257);
		cu().Name = "GroupBoxSourceData";
		cu().Size = new Size(185, 148);
		cu().TabIndex = 21;
		cu().TabStop = false;
		cu().Text = "Source Data";
		vj().AutoSize = true;
		vj().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		vj().ForeColor = SystemColors.ControlText;
		vj().Location = new Point(27, 40);
		vj().Name = "CheckBoxAnalyzeAll";
		vj().Size = new Size(42, 20);
		vj().TabIndex = 29;
		vj().Text = "All";
		aeg().SetToolTip(vj(), "Analyze the reflectance at 0° data if it exists in the measured spectra. At least one check box must be selected.");
		vj().UseVisualStyleBackColor = true;
		ve().AutoSize = true;
		ve().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ve().ForeColor = SystemColors.ControlText;
		ve().Location = new Point(27, 118);
		ve().Name = "CheckBoxRAtAngle";
		ve().Size = new Size(118, 20);
		ve().TabIndex = 28;
		ve().Text = "Reflectance 70°";
		aeg().SetToolTip(ve(), "Analyze the reflectance at angle data if it exists in the measured spectra. At least one check box must be selected.");
		ve().UseVisualStyleBackColor = true;
		vf().AutoSize = true;
		vf().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		vf().ForeColor = SystemColors.ControlText;
		vf().Location = new Point(27, 92);
		vf().Name = "CheckBoxTransmittance";
		vf().Size = new Size(125, 20);
		vf().TabIndex = 27;
		vf().Text = "Transmittance 0°";
		aeg().SetToolTip(vf(), "Analyze the transmittance at 0° data if it exists in the measured spectra. At least one check box must be selected.");
		vf().UseVisualStyleBackColor = true;
		vd().AutoSize = true;
		vd().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		vd().ForeColor = SystemColors.ControlText;
		vd().Location = new Point(27, 66);
		vd().Name = "CheckBoxReflectance";
		vd().Size = new Size(111, 20);
		vd().TabIndex = 26;
		vd().Text = "Reflectance 0°";
		aeg().SetToolTip(vd(), "Analyze the reflectance at  0° data if it exists in the measured spectra. At least one check box must be selected.");
		vd().UseVisualStyleBackColor = true;
		cv().AutoSize = true;
		cv().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cv().ForeColor = Color.Black;
		cv().Location = new Point(14, 19);
		cv().Name = "Label3";
		cv().Size = new Size(159, 16);
		cv().TabIndex = 21;
		cv().Text = "Analyze using (if present):";
		cx().Controls.Add(cy());
		cx().Controls.Add(cz());
		cx().Controls.Add(c8());
		cx().ForeColor = Color.Black;
		cx().Location = new Point(546, 49);
		cx().Name = "GroupBoxAdditionalMapParams";
		cx().Size = new Size(226, 218);
		cx().TabIndex = 27;
		cx().TabStop = false;
		cx().Text = "Additional Map Parameters";
		cx().Visible = false;
		cy().BackColor = Color.Transparent;
		cy().Cursor = Cursors.Default;
		cy().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cy().ForeColor = SystemColors.ControlText;
		cy().Location = new Point(12, 177);
		cy().Name = "ckF80SolveForGOF";
		cy().RightToLeft = RightToLeft.No;
		cy().Size = new Size(202, 27);
		cy().TabIndex = 23;
		cy().Text = "Map GOF (Goodness Of Fit)";
		cy().UseVisualStyleBackColor = false;
		cz().Controls.Add(c0());
		cz().Controls.Add(c1());
		cz().Controls.Add(c2());
		cz().Controls.Add(c3());
		cz().Controls.Add(c4());
		cz().Controls.Add(c5());
		cz().Controls.Add(c6());
		cz().Controls.Add(c7());
		cz().Location = new Point(10, 54);
		cz().Name = "GroupBoxAvgReflectance";
		cz().Size = new Size(206, 111);
		cz().TabIndex = 20;
		cz().TabStop = false;
		c0().AcceptsReturn = true;
		c0().BackColor = SystemColors.Window;
		c0().Cursor = Cursors.IBeam;
		c0().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c0().ForeColor = SystemColors.WindowText;
		c0().f(A_0: false);
		c0().Location = new Point(125, 19);
		c0().MaxLength = 0;
		c0().Name = "TextBoxAvgRefStartWave";
		c0().e(A_0: false);
		c0().RightToLeft = RightToLeft.No;
		c0().Size = new Size(50, 22);
		c0().TabIndex = 20;
		c0().Text = "630";
		c0().TextAlign = HorizontalAlignment.Right;
		c1().BackColor = Color.Transparent;
		c1().Cursor = Cursors.Default;
		c1().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c1().ForeColor = SystemColors.ControlText;
		c1().Location = new Point(178, 22);
		c1().Name = "Label7";
		c1().RightToLeft = RightToLeft.No;
		c1().Size = new Size(26, 17);
		c1().TabIndex = 54;
		c1().Text = "nm";
		c2().AcceptsReturn = true;
		c2().BackColor = SystemColors.Window;
		c2().Cursor = Cursors.IBeam;
		c2().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c2().ForeColor = SystemColors.WindowText;
		c2().f(A_0: false);
		c2().Location = new Point(125, 75);
		c2().MaxLength = 0;
		c2().Name = "TextBoxAvgRefRefWave";
		c2().e(A_0: false);
		c2().RightToLeft = RightToLeft.No;
		c2().Size = new Size(50, 22);
		c2().TabIndex = 22;
		c2().Text = "630";
		c2().TextAlign = HorizontalAlignment.Right;
		c3().BackColor = SystemColors.Window;
		c3().Cursor = Cursors.IBeam;
		c3().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c3().ForeColor = SystemColors.WindowText;
		c3().f(A_0: false);
		c3().Location = new Point(125, 47);
		c3().MaxLength = 0;
		c3().Name = "TextBoxAvgRefEndWave";
		c3().e(A_0: false);
		c3().RightToLeft = RightToLeft.No;
		c3().Size = new Size(50, 22);
		c3().TabIndex = 21;
		c3().Text = "630";
		c3().TextAlign = HorizontalAlignment.Right;
		c4().BackColor = Color.Transparent;
		c4().Cursor = Cursors.Default;
		c4().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c4().ForeColor = SystemColors.ControlText;
		c4().Location = new Point(178, 50);
		c4().Name = "Label26";
		c4().RightToLeft = RightToLeft.No;
		c4().Size = new Size(26, 17);
		c4().TabIndex = 50;
		c4().Text = "nm";
		c5().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c5().Location = new Point(8, 78);
		c5().Name = "LabelAveRefRefWave";
		c5().Size = new Size(119, 18);
		c5().TabIndex = 3;
		c5().Text = "Ref Wavelength";
		c6().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c6().Location = new Point(8, 50);
		c6().Name = "LabelAveRefEndWave";
		c6().Size = new Size(111, 18);
		c6().TabIndex = 2;
		c6().Text = "End Wavelength";
		c7().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c7().Location = new Point(8, 22);
		c7().Name = "LabelAveRefStartWave";
		c7().Size = new Size(111, 18);
		c7().TabIndex = 1;
		c7().Text = "Start Wavelength";
		c8().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c8().Location = new Point(12, 26);
		c8().Name = "CheckBoxAvgReflectance";
		c8().Size = new Size(196, 21);
		c8().TabIndex = 19;
		c8().Text = "Average Reflectance Ratio";
		c8().UseVisualStyleBackColor = true;
		dl().AutoScroll = true;
		dl().Controls.Add(vu());
		dl().Controls.Add(lk());
		dl().Location = new Point(4, 25);
		dl().Name = "TabPageAlarms";
		dl().Size = new Size(779, 464);
		dl().TabIndex = 2;
		dl().Text = "Alarms";
		dl().UseVisualStyleBackColor = true;
		vu().Anchor = AnchorStyles.None;
		vu().AutoSize = true;
		vu().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		vu().ColumnCount = 3;
		vu().ColumnStyles.Add(new ColumnStyle());
		vu().ColumnStyles.Add(new ColumnStyle());
		vu().ColumnStyles.Add(new ColumnStyle());
		vu().Controls.Add(vv(), 0, 0);
		vu().Controls.Add(vw(), 1, 1);
		vu().Controls.Add(vx(), 2, 1);
		vu().Controls.Add(vy(), 1, 2);
		vu().Controls.Add(vz(), 2, 2);
		vu().Controls.Add(v0(), 1, 3);
		vu().Controls.Add(v1(), 2, 3);
		vu().Controls.Add(v2(), 1, 4);
		vu().Controls.Add(v3(), 2, 4);
		vu().Controls.Add(v4(), 0, 2);
		vu().Controls.Add(v5(), 0, 3);
		vu().Controls.Add(v6(), 0, 4);
		vu().Location = new Point(623, 240);
		vu().Margin = new Padding(3, 6, 3, 6);
		vu().Name = "TLPColorAlarm";
		vu().RowCount = 5;
		vu().RowStyles.Add(new RowStyle());
		vu().RowStyles.Add(new RowStyle());
		vu().RowStyles.Add(new RowStyle());
		vu().RowStyles.Add(new RowStyle());
		vu().RowStyles.Add(new RowStyle());
		vu().Size = new Size(257, 132);
		vu().TabIndex = 7;
		vv().Anchor = AnchorStyles.None;
		vv().AutoSize = true;
		vu().SetColumnSpan(vv(), 3);
		vv().Location = new Point(62, 3);
		vv().Name = "chkColorAlarmActive";
		vv().Size = new Size(132, 20);
		vv().TabIndex = 0;
		vv().Text = "Color Alarm Active";
		vv().UseVisualStyleBackColor = true;
		vw().Anchor = AnchorStyles.None;
		vw().AutoSize = true;
		vw().Location = new Point(83, 29);
		vw().Margin = new Padding(3);
		vw().Name = "Label11";
		vw().Size = new Size(29, 16);
		vw().TabIndex = 1;
		vw().Text = "Min";
		vx().Anchor = AnchorStyles.None;
		vx().AutoSize = true;
		vx().Location = new Point(187, 29);
		vx().Name = "Label12";
		vx().Size = new Size(33, 16);
		vx().TabIndex = 2;
		vx().Text = "Max";
		vy().Anchor = AnchorStyles.None;
		vy().f(A_0: false);
		vy().Location = new Point(48, 51);
		vy().Name = "txtNumColorCoord1Min";
		vy().e(A_0: true);
		vy().Size = new Size(100, 22);
		vy().TabIndex = 3;
		vy().TextAlign = HorizontalAlignment.Center;
		vz().Anchor = AnchorStyles.None;
		vz().f(A_0: false);
		vz().Location = new Point(154, 51);
		vz().Name = "txtNumColorCoord1Max";
		vz().e(A_0: true);
		vz().Size = new Size(100, 22);
		vz().TabIndex = 4;
		vz().TextAlign = HorizontalAlignment.Center;
		v0().Anchor = AnchorStyles.None;
		v0().f(A_0: false);
		v0().Location = new Point(48, 79);
		v0().Name = "txtNumColorCoord2Min";
		v0().e(A_0: true);
		v0().Size = new Size(100, 22);
		v0().TabIndex = 5;
		v0().TextAlign = HorizontalAlignment.Center;
		v1().Anchor = AnchorStyles.None;
		v1().f(A_0: false);
		v1().Location = new Point(154, 79);
		v1().Name = "txtNumColorCoord2Max";
		v1().e(A_0: true);
		v1().Size = new Size(100, 22);
		v1().TabIndex = 6;
		v1().TextAlign = HorizontalAlignment.Center;
		v2().Anchor = AnchorStyles.None;
		v2().f(A_0: false);
		v2().Location = new Point(48, 107);
		v2().Name = "txtNumColorCoord3Min";
		v2().e(A_0: true);
		v2().Size = new Size(100, 22);
		v2().TabIndex = 7;
		v2().TextAlign = HorizontalAlignment.Center;
		v3().Anchor = AnchorStyles.None;
		v3().f(A_0: false);
		v3().Location = new Point(154, 107);
		v3().Name = "txtNumColorCoord3Max";
		v3().e(A_0: true);
		v3().Size = new Size(100, 22);
		v3().TabIndex = 8;
		v3().TextAlign = HorizontalAlignment.Center;
		v4().Anchor = AnchorStyles.None;
		v4().AutoSize = true;
		v4().Location = new Point(15, 54);
		v4().Margin = new Padding(15, 0, 15, 0);
		v4().Name = "lblColorCoord1";
		v4().Size = new Size(15, 16);
		v4().TabIndex = 9;
		v4().Text = "L";
		v5().Anchor = AnchorStyles.None;
		v5().AutoSize = true;
		v5().Location = new Point(15, 82);
		v5().Name = "lblColorCoord2";
		v5().Size = new Size(15, 16);
		v5().TabIndex = 10;
		v5().Text = "a";
		v6().Anchor = AnchorStyles.None;
		v6().AutoSize = true;
		v6().Location = new Point(15, 110);
		v6().Name = "lblColorCoord3";
		v6().Size = new Size(15, 16);
		v6().TabIndex = 11;
		v6().Text = "b";
		lk().AutoSize = true;
		lk().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		lk().Controls.Add(ll());
		lk().Location = new Point(0, 10);
		lk().Name = "PanelAlarms";
		lk().Size = new Size(341, 188);
		lk().TabIndex = 5;
		ll().AutoSize = true;
		ll().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ll().ColumnCount = 4;
		ll().ColumnStyles.Add(new ColumnStyle());
		ll().ColumnStyles.Add(new ColumnStyle());
		ll().ColumnStyles.Add(new ColumnStyle());
		ll().ColumnStyles.Add(new ColumnStyle());
		ll().Controls.Add(pl(), 0, 0);
		ll().Controls.Add(d6(), 3, 4);
		ll().Controls.Add(eu(), 0, 1);
		ll().Controls.Add(lm(), 0, 2);
		ll().Controls.Add(ef(), 2, 4);
		ll().Controls.Add(eq(), 0, 3);
		ll().Controls.Add(eh(), 1, 4);
		ll().Controls.Add(er(), 1, 3);
		ll().Controls.Add(ep(), 0, 4);
		ll().Controls.Add(es(), 2, 3);
		ll().Controls.Add(et(), 3, 3);
		ll().Location = new Point(3, 3);
		ll().Name = "TLPAlarms";
		ll().RowCount = 5;
		ll().RowStyles.Add(new RowStyle());
		ll().RowStyles.Add(new RowStyle());
		ll().RowStyles.Add(new RowStyle());
		ll().RowStyles.Add(new RowStyle());
		ll().RowStyles.Add(new RowStyle());
		ll().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		ll().Size = new Size(335, 182);
		ll().TabIndex = 0;
		pl().Anchor = AnchorStyles.None;
		pl().AutoSize = true;
		pl().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		pl().ColumnCount = 2;
		ll().SetColumnSpan(pl(), 4);
		pl().ColumnStyles.Add(new ColumnStyle());
		pl().ColumnStyles.Add(new ColumnStyle());
		pl().Controls.Add(ah1(), 0, 1);
		pl().Controls.Add(ah0(), 1, 1);
		pl().Controls.Add(pm(), 1, 0);
		pl().Controls.Add(pn(), 0, 0);
		pl().Location = new Point(44, 3);
		pl().Name = "TableLayoutPanelMinGOFAndFFT";
		pl().RowCount = 2;
		pl().RowStyles.Add(new RowStyle());
		pl().RowStyles.Add(new RowStyle());
		pl().Size = new Size(247, 56);
		pl().TabIndex = 6;
		ah1().Anchor = AnchorStyles.Right;
		ah1().AutoSize = true;
		ah1().Location = new Point(3, 34);
		ah1().Name = "Label54";
		ah1().Size = new Size(177, 16);
		ah1().TabIndex = 6;
		ah1().Text = "Minimum Valid FFT Intensity:";
		ah0().f(A_0: false);
		ah0().Location = new Point(186, 31);
		ah0().Name = "TextBoxNumFFTThreshold";
		ah0().e(A_0: false);
		ah0().Size = new Size(58, 22);
		ah0().TabIndex = 6;
		pm().f(A_0: false);
		pm().Location = new Point(186, 3);
		pm().Name = "TextBoxNumGOFThreshold";
		pm().e(A_0: false);
		pm().Size = new Size(58, 22);
		pm().TabIndex = 6;
		pn().Anchor = AnchorStyles.Right;
		pn().AutoSize = true;
		pn().Location = new Point(51, 6);
		pn().Name = "Label2";
		pn().Size = new Size(129, 16);
		pn().TabIndex = 6;
		pn().Text = "Minimum Valid GOF:";
		d6().AcceptsReturn = true;
		d6().Anchor = AnchorStyles.None;
		d6().BackColor = SystemColors.Window;
		d6().Cursor = Cursors.IBeam;
		d6().Enabled = false;
		d6().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		d6().ForeColor = SystemColors.WindowText;
		d6().f(A_0: false);
		d6().Location = new Point(239, 157);
		d6().MaxLength = 0;
		d6().Name = "TextBoxNumAlarmsMax";
		d6().e(A_0: false);
		d6().RightToLeft = RightToLeft.No;
		d6().Size = new Size(93, 22);
		d6().TabIndex = 3;
		d6().Text = "MaxBox";
		d6().TextAlign = HorizontalAlignment.Center;
		eu().Anchor = AnchorStyles.None;
		eu().AutoSize = true;
		eu().BackColor = Color.Transparent;
		ll().SetColumnSpan(eu(), 4);
		eu().Cursor = Cursors.Default;
		eu().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		eu().ForeColor = SystemColors.ControlText;
		eu().Location = new Point(109, 82);
		eu().Margin = new Padding(3, 20, 3, 8);
		eu().Name = "CheckBoxActivateAlarms";
		eu().RightToLeft = RightToLeft.No;
		eu().Size = new Size(116, 20);
		eu().TabIndex = 3;
		eu().Text = "Activate alarms";
		eu().UseVisualStyleBackColor = false;
		lm().Anchor = AnchorStyles.None;
		lm().AutoSize = true;
		ll().SetColumnSpan(lm(), 4);
		lm().ForeColor = Color.DimGray;
		lm().Location = new Point(99, 110);
		lm().Margin = new Padding(3, 0, 3, 6);
		lm().Name = "LabelAlarmsOverallHeading";
		lm().Size = new Size(136, 16);
		lm().TabIndex = 0;
		lm().Text = "Thickness Limits (nm)";
		ef().AcceptsReturn = true;
		ef().Anchor = AnchorStyles.None;
		ef().BackColor = SystemColors.Window;
		ef().Cursor = Cursors.IBeam;
		ef().Enabled = false;
		ef().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ef().ForeColor = SystemColors.WindowText;
		ef().f(A_0: false);
		ef().Location = new Point(140, 157);
		ef().MaxLength = 0;
		ef().Name = "TextBoxNumAlarmsMin";
		ef().e(A_0: false);
		ef().RightToLeft = RightToLeft.No;
		ef().Size = new Size(93, 22);
		ef().TabIndex = 2;
		ef().Text = "MinBox";
		ef().TextAlign = HorizontalAlignment.Center;
		eq().Anchor = AnchorStyles.None;
		eq().AutoSize = true;
		eq().BackColor = Color.Transparent;
		eq().Cursor = Cursors.Default;
		eq().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		eq().ForeColor = Color.DimGray;
		eq().Location = new Point(10, 132);
		eq().Margin = new Padding(3, 0, 3, 6);
		eq().Name = "LabelAlarmsLayer";
		eq().RightToLeft = RightToLeft.No;
		eq().Size = new Size(40, 16);
		eq().TabIndex = 36;
		eq().Text = "Layer";
		eq().TextAlign = ContentAlignment.TopCenter;
		eh().Anchor = AnchorStyles.None;
		eh().BackColor = Color.Transparent;
		eh().BorderStyle = BorderStyle.FixedSingle;
		eh().Cursor = Cursors.Default;
		eh().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		eh().ForeColor = SystemColors.ControlText;
		eh().Location = new Point(63, 157);
		eh().Margin = new Padding(3);
		eh().MinimumSize = new Size(71, 22);
		eh().Name = "LabelAlarmsNominalThickness";
		eh().RightToLeft = RightToLeft.No;
		eh().Size = new Size(71, 22);
		eh().TabIndex = 6;
		eh().Text = "NominalThkBox";
		eh().TextAlign = ContentAlignment.MiddleCenter;
		er().Anchor = AnchorStyles.None;
		er().AutoSize = true;
		er().BackColor = Color.Transparent;
		er().Cursor = Cursors.Default;
		er().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		er().ForeColor = Color.DimGray;
		er().Location = new Point(71, 132);
		er().Margin = new Padding(3, 0, 3, 6);
		er().Name = "LabelAlarmsNominal";
		er().RightToLeft = RightToLeft.No;
		er().Size = new Size(55, 16);
		er().TabIndex = 35;
		er().Text = "Nominal";
		er().TextAlign = ContentAlignment.TopCenter;
		ep().Anchor = AnchorStyles.None;
		ep().AutoSize = true;
		ep().BackColor = Color.Transparent;
		ep().Cursor = Cursors.Default;
		ep().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ep().ForeColor = SystemColors.ControlText;
		ep().Location = new Point(3, 160);
		ep().Margin = new Padding(3);
		ep().Name = "LabelAlarmLayer";
		ep().RightToLeft = RightToLeft.No;
		ep().Size = new Size(54, 16);
		ep().TabIndex = 5;
		ep().Text = "Medium";
		ep().TextAlign = ContentAlignment.MiddleCenter;
		es().Anchor = AnchorStyles.None;
		es().AutoSize = true;
		es().BackColor = Color.Transparent;
		es().Cursor = Cursors.Default;
		es().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		es().ForeColor = Color.DimGray;
		es().Location = new Point(172, 132);
		es().Margin = new Padding(3, 0, 3, 6);
		es().Name = "LabelAlarmsMin";
		es().RightToLeft = RightToLeft.No;
		es().Size = new Size(29, 16);
		es().TabIndex = 34;
		es().Text = "Min";
		es().TextAlign = ContentAlignment.TopCenter;
		et().Anchor = AnchorStyles.None;
		et().AutoSize = true;
		et().BackColor = Color.Transparent;
		et().Cursor = Cursors.Default;
		et().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		et().ForeColor = Color.DimGray;
		et().Location = new Point(269, 132);
		et().Margin = new Padding(3, 0, 3, 6);
		et().Name = "LabelAlarmsMax";
		et().RightToLeft = RightToLeft.No;
		et().Size = new Size(33, 16);
		et().TabIndex = 33;
		et().Text = "Max";
		et().TextAlign = ContentAlignment.TopCenter;
		dp().AutoScroll = true;
		dp().Controls.Add(z4());
		dp().Controls.Add(ln());
		dp().Location = new Point(4, 25);
		dp().Name = "TabPageSpectrumAnalysis";
		dp().Size = new Size(779, 464);
		dp().TabIndex = 3;
		dp().Text = "Spectrum Analysis";
		dp().UseVisualStyleBackColor = true;
		z4().AutoSize = true;
		z4().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		z4().Location = new Point(777, 23);
		z4().Name = "PanelSUV";
		z4().Size = new Size(0, 0);
		z4().TabIndex = 329;
		ln().AutoSize = true;
		ln().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ln().Controls.Add(lo());
		ln().Controls.Add(o6());
		ln().Controls.Add(o7());
		ln().Controls.Add(o8());
		ln().Controls.Add(o9());
		ln().Location = new Point(3, 3);
		ln().Name = "PanelSpectrumAnalysis";
		ln().Size = new Size(786, 435);
		ln().TabIndex = 326;
		lo().Controls.Add(lp());
		lo().Controls.Add(lq());
		lo().Controls.Add(agc());
		lo().Controls.Add(o0());
		lo().Location = new Point(3, 37);
		lo().Multiline = true;
		lo().Name = "TabControlSpecAnalysis";
		lo().SelectedIndex = 0;
		lo().Size = new Size(780, 395);
		lo().TabIndex = 324;
		lp().AutoScroll = true;
		lp().Controls.Add(z3());
		lp().Location = new Point(4, 25);
		lp().Name = "TabPageAvgVal";
		lp().Padding = new Padding(3);
		lp().Size = new Size(772, 366);
		lp().TabIndex = 0;
		lp().Text = "Average";
		lp().UseVisualStyleBackColor = true;
		z3().AutoSize = true;
		z3().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		z3().ColumnCount = 1;
		z3().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		z3().Controls.Add(aeb(), 0, 0);
		z3().Controls.Add(z7(), 0, 1);
		z3().Location = new Point(6, 3);
		z3().Name = "TableLayoutPanelAvgRefl";
		z3().RowCount = 2;
		z3().RowStyles.Add(new RowStyle());
		z3().RowStyles.Add(new RowStyle());
		z3().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		z3().Size = new Size(1036, 626);
		z3().TabIndex = 327;
		aeb().AutoSize = true;
		aeb().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		aeb().ColumnCount = 3;
		aeb().ColumnStyles.Add(new ColumnStyle());
		aeb().ColumnStyles.Add(new ColumnStyle());
		aeb().ColumnStyles.Add(new ColumnStyle());
		aeb().Controls.Add(aho(), 1, 0);
		aeb().Controls.Add(aec(), 0, 0);
		aeb().Controls.Add(acc(), 2, 0);
		aeb().Dock = DockStyle.Top;
		aeb().Location = new Point(3, 3);
		aeb().Name = "TableLayoutPanelWeightedReflectance";
		aeb().RowCount = 1;
		aeb().RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		aeb().Size = new Size(1030, 44);
		aeb().TabIndex = 133;
		aho().Anchor = AnchorStyles.None;
		aho().Controls.Add(ahp());
		aho().Location = new Point(364, 3);
		aho().Name = "GroupBoxYID1925";
		aho().Size = new Size(321, 38);
		aho().TabIndex = 332;
		aho().TabStop = false;
		ahp().Anchor = AnchorStyles.None;
		ahp().AutoSize = true;
		ahp().Location = new Point(120, 13);
		ahp().Name = "CheckBoxYID1925";
		ahp().Size = new Size(80, 20);
		ahp().TabIndex = 0;
		ahp().Text = "YI D1925";
		aei().SetToolTip(ahp(), componentResourceManager.GetString("CheckBoxYID1925.ToolTip"));
		ahp().UseVisualStyleBackColor = true;
		aec().Anchor = AnchorStyles.None;
		aec().Controls.Add(aed());
		aec().Location = new Point(37, 3);
		aec().Margin = new Padding(37, 3, 3, 3);
		aec().Name = "GroupBoxLuminousReflectance";
		aec().Size = new Size(321, 38);
		aec().TabIndex = 331;
		aec().TabStop = false;
		aed().Anchor = AnchorStyles.None;
		aed().AutoSize = true;
		aed().Location = new Point(83, 12);
		aed().Name = "CheckBoxLuminousReflectance";
		aed().Size = new Size(155, 20);
		aed().TabIndex = 0;
		aed().Text = "Luminous Reflectance";
		aei().SetToolTip(aed(), componentResourceManager.GetString("CheckBoxLuminousReflectance.ToolTip"));
		aed().UseVisualStyleBackColor = true;
		acc().Controls.Add(ace());
		acc().Controls.Add(acd());
		acc().Controls.Add(z6());
		acc().Controls.Add(z5());
		acc().Location = new Point(691, 3);
		acc().Name = "GroupBoxSUV";
		acc().Size = new Size(336, 38);
		acc().TabIndex = 330;
		acc().TabStop = false;
		acc().Visible = false;
		ace().Anchor = AnchorStyles.None;
		ace().AutoSize = true;
		ace().Location = new Point(275, 12);
		ace().Name = "CheckBoxSUVAB";
		ace().Size = new Size(45, 20);
		ace().TabIndex = 6;
		ace().Text = "AB";
		aei().SetToolTip(ace(), "Calculate sum of Solar UV-A and UV-B Reflectance and/or Transmittance.\r\nUV-A+UV-B Wavelength Range is 280-380nm. Calculation is defined in ISO 13666:2012 ");
		ace().UseVisualStyleBackColor = true;
		acd().Anchor = AnchorStyles.None;
		acd().AutoSize = true;
		acd().Location = new Point(16, 13);
		acd().Name = "Label38";
		acd().Size = new Size(162, 16);
		acd().TabIndex = 5;
		acd().Text = "Weighted Solar UV (SUV):";
		z6().Anchor = AnchorStyles.None;
		z6().AutoSize = true;
		z6().Location = new Point(193, 12);
		z6().Name = "CheckBoxSUVA";
		z6().Size = new Size(36, 20);
		z6().TabIndex = 0;
		z6().Text = "A";
		aei().SetToolTip(z6(), "Calculate Solar UV-A Reflectance and/or Transmittance.\r\nUV-A Wavelength Range is 315-380 nm. Calculation is defined in ISO 13666:2012");
		z6().UseVisualStyleBackColor = true;
		z5().Anchor = AnchorStyles.None;
		z5().AutoSize = true;
		z5().Location = new Point(234, 12);
		z5().Name = "CheckBoxSUVB";
		z5().Size = new Size(36, 20);
		z5().TabIndex = 1;
		z5().Text = "B";
		aei().SetToolTip(z5(), "Calculate Solar UV-B Reflectance and/or Transmittance.\r\nUV-B Wavelength Range is 280-315 nm. Calculation is defined in ISO 13666:2012 ");
		z5().UseVisualStyleBackColor = true;
		z7().AutoSize = true;
		z7().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		z7().Controls.Add(aie());
		z7().Controls.Add(adn());
		z7().Controls.Add(ado());
		z7().Controls.Add(ady());
		z7().Controls.Add(adz());
		z7().Controls.Add(acf());
		z7().Controls.Add(acg());
		z7().Controls.Add(acq());
		z7().Controls.Add(acr());
		z7().Controls.Add(ac1());
		z7().Controls.Add(ac2());
		z7().Controls.Add(adc());
		z7().Controls.Add(add());
		z7().Controls.Add(z8());
		z7().Controls.Add(z9());
		z7().Controls.Add(aaa());
		z7().Controls.Add(aab());
		z7().Controls.Add(aac());
		z7().Controls.Add(aad());
		z7().Controls.Add(aae());
		z7().Controls.Add(aaf());
		z7().Controls.Add(aag());
		z7().Controls.Add(aah());
		z7().Controls.Add(aai());
		z7().Controls.Add(aas());
		z7().Controls.Add(aat());
		z7().Controls.Add(aa3());
		z7().Controls.Add(abd());
		z7().Controls.Add(abn());
		z7().Controls.Add(abx());
		z7().Controls.Add(ab7());
		z7().Controls.Add(ab8());
		z7().Controls.Add(ab9());
		z7().Controls.Add(aca());
		z7().Controls.Add(acb());
		z7().Location = new Point(3, 53);
		z7().Name = "PanelAvgRefl";
		z7().Size = new Size(718, 570);
		z7().TabIndex = 328;
		aie().BackColor = Color.Transparent;
		aie().Cursor = Cursors.Default;
		aie().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aie().ForeColor = SystemColors.WindowText;
		aie().Location = new Point(617, 22);
		aie().Name = "LabelSpecAnalysisAvgRSpecTypeA";
		aie().RightToLeft = RightToLeft.No;
		aie().Size = new Size(25, 17);
		aie().TabIndex = 372;
		aie().Text = "A";
		aie().TextAlign = ContentAlignment.TopCenter;
		adn().BackColor = SystemColors.Control;
		adn().BackgroundImage = Resources.Insert;
		adn().BackgroundImageLayout = ImageLayout.Center;
		adn().Cursor = Cursors.Default;
		adn().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		adn().ForeColor = SystemColors.ControlText;
		adn().Location = new Point(5, 515);
		adn().Name = "ButtonAddRegion_12";
		adn().RightToLeft = RightToLeft.No;
		adn().Size = new Size(24, 24);
		adn().TabIndex = 370;
		adn().TextAlign = ContentAlignment.BottomCenter;
		adn().UseVisualStyleBackColor = false;
		ado().BackColor = Color.Transparent;
		ado().Controls.Add(ah3());
		ado().Controls.Add(adp());
		ado().Controls.Add(adq());
		ado().Controls.Add(adr());
		ado().Controls.Add(ads());
		ado().Controls.Add(adt());
		ado().Controls.Add(adu());
		ado().Controls.Add(adv());
		ado().Controls.Add(adw());
		ado().Controls.Add(adx());
		ado().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ado().ForeColor = SystemColors.ControlText;
		ado().Location = new Point(37, 525);
		ado().Name = "GroupBoxRegion_12";
		ado().RightToLeft = RightToLeft.No;
		ado().Size = new Size(678, 42);
		ado().TabIndex = 371;
		ado().TabStop = false;
		ah3().AutoSize = true;
		ah3().Location = new Point(585, 18);
		ah3().Name = "RadioButtonAvgReflA12";
		ah3().Size = new Size(14, 13);
		ah3().TabIndex = 297;
		ah3().TabStop = true;
		ah3().UseVisualStyleBackColor = true;
		adp().AutoSize = true;
		adp().Location = new Point(555, 18);
		adp().Name = "RadioButtonAvgReflT12";
		adp().Size = new Size(14, 13);
		adp().TabIndex = 8;
		adp().TabStop = true;
		adp().UseVisualStyleBackColor = true;
		adq().AutoSize = true;
		adq().Location = new Point(525, 18);
		adq().Name = "RadioButtonAvgReflR12";
		adq().Size = new Size(14, 13);
		adq().TabIndex = 7;
		adq().TabStop = true;
		adq().UseVisualStyleBackColor = true;
		adr().Location = new Point(641, 14);
		adr().Name = "CheckBoxRegionActive_12";
		adr().Size = new Size(35, 22);
		adr().TabIndex = 9;
		adr().Text = " ";
		adr().UseVisualStyleBackColor = true;
		ads().AcceptsReturn = true;
		ads().BackColor = SystemColors.Window;
		ads().Cursor = Cursors.Default;
		ads().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ads().ForeColor = SystemColors.WindowText;
		ads().f(A_0: false);
		ads().Location = new Point(425, 12);
		ads().MaxLength = 0;
		ads().Name = "TextBoxMaxR_12";
		ads().e(A_0: false);
		ads().RightToLeft = RightToLeft.No;
		ads().Size = new Size(75, 22);
		ads().TabIndex = 41;
		ads().TextAlign = HorizontalAlignment.Right;
		adt().BackColor = SystemColors.Window;
		adt().Cursor = Cursors.Default;
		adt().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		adt().ForeColor = SystemColors.WindowText;
		adt().f(A_0: false);
		adt().Location = new Point(228, 12);
		adt().Name = "TextBoxEndWave_12";
		adt().e(A_0: false);
		adt().RightToLeft = RightToLeft.No;
		adt().Size = new Size(85, 22);
		adt().TabIndex = 39;
		adt().TextAlign = HorizontalAlignment.Right;
		adu().AcceptsReturn = true;
		adu().BackColor = SystemColors.Window;
		adu().Cursor = Cursors.Default;
		adu().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		adu().ForeColor = SystemColors.WindowText;
		adu().f(A_0: false);
		adu().Location = new Point(331, 12);
		adu().MaxLength = 0;
		adu().Name = "TextBoxMinR_12";
		adu().e(A_0: false);
		adu().RightToLeft = RightToLeft.No;
		adu().Size = new Size(75, 22);
		adu().TabIndex = 40;
		adu().TextAlign = HorizontalAlignment.Right;
		adv().BackColor = SystemColors.Control;
		adv().BackgroundImage = Resources.x;
		adv().BackgroundImageLayout = ImageLayout.Center;
		adv().Cursor = Cursors.Default;
		adv().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		adv().ForeColor = SystemColors.ControlText;
		adv().Location = new Point(8, 14);
		adv().Name = "ButtonDeleteRegion_12";
		adv().RightToLeft = RightToLeft.No;
		adv().Size = new Size(18, 19);
		adv().TabIndex = 37;
		adv().TextAlign = ContentAlignment.BottomCenter;
		adv().UseVisualStyleBackColor = false;
		adw().AcceptsReturn = true;
		adw().BackColor = SystemColors.Window;
		adw().Cursor = Cursors.Default;
		adw().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		adw().ForeColor = SystemColors.WindowText;
		adw().f(A_0: false);
		adw().Location = new Point(128, 12);
		adw().MaxLength = 0;
		adw().Name = "TextBoxStartWave_12";
		adw().e(A_0: false);
		adw().RightToLeft = RightToLeft.No;
		adw().Size = new Size(85, 22);
		adw().TabIndex = 38;
		adw().TextAlign = HorizontalAlignment.Right;
		adx().BackColor = Color.Transparent;
		adx().Cursor = Cursors.Default;
		adx().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		adx().ForeColor = SystemColors.ControlText;
		adx().Location = new Point(40, 12);
		adx().Name = "LabelRegion_12";
		adx().RightToLeft = RightToLeft.No;
		adx().Size = new Size(73, 22);
		adx().TabIndex = 296;
		adx().Text = "R12";
		adx().TextAlign = ContentAlignment.MiddleCenter;
		ady().BackColor = SystemColors.Control;
		ady().BackgroundImage = Resources.Insert;
		ady().BackgroundImageLayout = ImageLayout.Center;
		ady().Cursor = Cursors.Default;
		ady().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ady().ForeColor = SystemColors.ControlText;
		ady().Location = new Point(5, 471);
		ady().Name = "ButtonAddRegion_11";
		ady().RightToLeft = RightToLeft.No;
		ady().Size = new Size(24, 24);
		ady().TabIndex = 368;
		ady().TextAlign = ContentAlignment.BottomCenter;
		ady().UseVisualStyleBackColor = false;
		adz().BackColor = Color.Transparent;
		adz().Controls.Add(ah4());
		adz().Controls.Add(ad0());
		adz().Controls.Add(ad1());
		adz().Controls.Add(ad2());
		adz().Controls.Add(ad3());
		adz().Controls.Add(ad4());
		adz().Controls.Add(ad5());
		adz().Controls.Add(ad6());
		adz().Controls.Add(ad7());
		adz().Controls.Add(ad8());
		adz().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		adz().ForeColor = SystemColors.ControlText;
		adz().Location = new Point(37, 481);
		adz().Name = "GroupBoxRegion_11";
		adz().RightToLeft = RightToLeft.No;
		adz().Size = new Size(678, 42);
		adz().TabIndex = 369;
		adz().TabStop = false;
		ah4().AutoSize = true;
		ah4().Location = new Point(585, 18);
		ah4().Name = "RadioButtonAvgReflA11";
		ah4().Size = new Size(14, 13);
		ah4().TabIndex = 297;
		ah4().TabStop = true;
		ah4().UseVisualStyleBackColor = true;
		ad0().AutoSize = true;
		ad0().Location = new Point(555, 18);
		ad0().Name = "RadioButtonAvgReflT11";
		ad0().Size = new Size(14, 13);
		ad0().TabIndex = 8;
		ad0().TabStop = true;
		ad0().UseVisualStyleBackColor = true;
		ad1().AutoSize = true;
		ad1().Location = new Point(525, 18);
		ad1().Name = "RadioButtonAvgReflR11";
		ad1().Size = new Size(14, 13);
		ad1().TabIndex = 7;
		ad1().TabStop = true;
		ad1().UseVisualStyleBackColor = true;
		ad2().Location = new Point(641, 14);
		ad2().Name = "CheckBoxRegionActive_11";
		ad2().Size = new Size(35, 22);
		ad2().TabIndex = 9;
		ad2().Text = " ";
		ad2().UseVisualStyleBackColor = true;
		ad3().AcceptsReturn = true;
		ad3().BackColor = SystemColors.Window;
		ad3().Cursor = Cursors.Default;
		ad3().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ad3().ForeColor = SystemColors.WindowText;
		ad3().f(A_0: false);
		ad3().Location = new Point(425, 12);
		ad3().MaxLength = 0;
		ad3().Name = "TextBoxMaxR_11";
		ad3().e(A_0: false);
		ad3().RightToLeft = RightToLeft.No;
		ad3().Size = new Size(75, 22);
		ad3().TabIndex = 41;
		ad3().TextAlign = HorizontalAlignment.Right;
		ad4().BackColor = SystemColors.Window;
		ad4().Cursor = Cursors.Default;
		ad4().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ad4().ForeColor = SystemColors.WindowText;
		ad4().f(A_0: false);
		ad4().Location = new Point(228, 12);
		ad4().Name = "TextBoxEndWave_11";
		ad4().e(A_0: false);
		ad4().RightToLeft = RightToLeft.No;
		ad4().Size = new Size(85, 22);
		ad4().TabIndex = 39;
		ad4().TextAlign = HorizontalAlignment.Right;
		ad5().AcceptsReturn = true;
		ad5().BackColor = SystemColors.Window;
		ad5().Cursor = Cursors.Default;
		ad5().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ad5().ForeColor = SystemColors.WindowText;
		ad5().f(A_0: false);
		ad5().Location = new Point(331, 12);
		ad5().MaxLength = 0;
		ad5().Name = "TextBoxMinR_11";
		ad5().e(A_0: false);
		ad5().RightToLeft = RightToLeft.No;
		ad5().Size = new Size(75, 22);
		ad5().TabIndex = 40;
		ad5().TextAlign = HorizontalAlignment.Right;
		ad6().BackColor = SystemColors.Control;
		ad6().BackgroundImage = Resources.x;
		ad6().BackgroundImageLayout = ImageLayout.Center;
		ad6().Cursor = Cursors.Default;
		ad6().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ad6().ForeColor = SystemColors.ControlText;
		ad6().Location = new Point(8, 14);
		ad6().Name = "ButtonDeleteRegion_11";
		ad6().RightToLeft = RightToLeft.No;
		ad6().Size = new Size(18, 19);
		ad6().TabIndex = 37;
		ad6().TextAlign = ContentAlignment.BottomCenter;
		ad6().UseVisualStyleBackColor = false;
		ad7().AcceptsReturn = true;
		ad7().BackColor = SystemColors.Window;
		ad7().Cursor = Cursors.Default;
		ad7().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ad7().ForeColor = SystemColors.WindowText;
		ad7().f(A_0: false);
		ad7().Location = new Point(128, 12);
		ad7().MaxLength = 0;
		ad7().Name = "TextBoxStartWave_11";
		ad7().e(A_0: false);
		ad7().RightToLeft = RightToLeft.No;
		ad7().Size = new Size(85, 22);
		ad7().TabIndex = 38;
		ad7().TextAlign = HorizontalAlignment.Right;
		ad8().BackColor = Color.Transparent;
		ad8().Cursor = Cursors.Default;
		ad8().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ad8().ForeColor = SystemColors.ControlText;
		ad8().Location = new Point(40, 12);
		ad8().Name = "LabelRegion_11";
		ad8().RightToLeft = RightToLeft.No;
		ad8().Size = new Size(73, 22);
		ad8().TabIndex = 296;
		ad8().Text = "R11";
		ad8().TextAlign = ContentAlignment.MiddleCenter;
		acf().BackColor = SystemColors.Control;
		acf().BackgroundImage = Resources.Insert;
		acf().BackgroundImageLayout = ImageLayout.Center;
		acf().Cursor = Cursors.Default;
		acf().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		acf().ForeColor = SystemColors.ControlText;
		acf().Location = new Point(5, 427);
		acf().Name = "ButtonAddRegion_10";
		acf().RightToLeft = RightToLeft.No;
		acf().Size = new Size(24, 24);
		acf().TabIndex = 366;
		acf().TextAlign = ContentAlignment.BottomCenter;
		acf().UseVisualStyleBackColor = false;
		acg().BackColor = Color.Transparent;
		acg().Controls.Add(ah5());
		acg().Controls.Add(ach());
		acg().Controls.Add(aci());
		acg().Controls.Add(acj());
		acg().Controls.Add(ack());
		acg().Controls.Add(acl());
		acg().Controls.Add(acm());
		acg().Controls.Add(acn());
		acg().Controls.Add(aco());
		acg().Controls.Add(acp());
		acg().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		acg().ForeColor = SystemColors.ControlText;
		acg().Location = new Point(37, 437);
		acg().Name = "GroupBoxRegion_10";
		acg().RightToLeft = RightToLeft.No;
		acg().Size = new Size(678, 42);
		acg().TabIndex = 367;
		acg().TabStop = false;
		ah5().AutoSize = true;
		ah5().Location = new Point(585, 18);
		ah5().Name = "RadioButtonAvgReflA10";
		ah5().Size = new Size(14, 13);
		ah5().TabIndex = 297;
		ah5().TabStop = true;
		ah5().UseVisualStyleBackColor = true;
		ach().AutoSize = true;
		ach().Location = new Point(555, 18);
		ach().Name = "RadioButtonAvgReflT10";
		ach().Size = new Size(14, 13);
		ach().TabIndex = 8;
		ach().TabStop = true;
		ach().UseVisualStyleBackColor = true;
		aci().AutoSize = true;
		aci().Location = new Point(525, 18);
		aci().Name = "RadioButtonAvgReflR10";
		aci().Size = new Size(14, 13);
		aci().TabIndex = 7;
		aci().TabStop = true;
		aci().UseVisualStyleBackColor = true;
		acj().Location = new Point(641, 14);
		acj().Name = "CheckBoxRegionActive_10";
		acj().Size = new Size(35, 22);
		acj().TabIndex = 9;
		acj().Text = " ";
		acj().UseVisualStyleBackColor = true;
		ack().AcceptsReturn = true;
		ack().BackColor = SystemColors.Window;
		ack().Cursor = Cursors.Default;
		ack().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ack().ForeColor = SystemColors.WindowText;
		ack().f(A_0: false);
		ack().Location = new Point(425, 12);
		ack().MaxLength = 0;
		ack().Name = "TextBoxMaxR_10";
		ack().e(A_0: false);
		ack().RightToLeft = RightToLeft.No;
		ack().Size = new Size(75, 22);
		ack().TabIndex = 41;
		ack().TextAlign = HorizontalAlignment.Right;
		acl().BackColor = SystemColors.Window;
		acl().Cursor = Cursors.Default;
		acl().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		acl().ForeColor = SystemColors.WindowText;
		acl().f(A_0: false);
		acl().Location = new Point(228, 12);
		acl().Name = "TextBoxEndWave_10";
		acl().e(A_0: false);
		acl().RightToLeft = RightToLeft.No;
		acl().Size = new Size(85, 22);
		acl().TabIndex = 39;
		acl().TextAlign = HorizontalAlignment.Right;
		acm().AcceptsReturn = true;
		acm().BackColor = SystemColors.Window;
		acm().Cursor = Cursors.Default;
		acm().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		acm().ForeColor = SystemColors.WindowText;
		acm().f(A_0: false);
		acm().Location = new Point(331, 12);
		acm().MaxLength = 0;
		acm().Name = "TextBoxMinR_10";
		acm().e(A_0: false);
		acm().RightToLeft = RightToLeft.No;
		acm().Size = new Size(75, 22);
		acm().TabIndex = 40;
		acm().TextAlign = HorizontalAlignment.Right;
		acn().BackColor = SystemColors.Control;
		acn().BackgroundImage = Resources.x;
		acn().BackgroundImageLayout = ImageLayout.Center;
		acn().Cursor = Cursors.Default;
		acn().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		acn().ForeColor = SystemColors.ControlText;
		acn().Location = new Point(8, 14);
		acn().Name = "ButtonDeleteRegion_10";
		acn().RightToLeft = RightToLeft.No;
		acn().Size = new Size(18, 19);
		acn().TabIndex = 37;
		acn().TextAlign = ContentAlignment.BottomCenter;
		acn().UseVisualStyleBackColor = false;
		aco().AcceptsReturn = true;
		aco().BackColor = SystemColors.Window;
		aco().Cursor = Cursors.Default;
		aco().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aco().ForeColor = SystemColors.WindowText;
		aco().f(A_0: false);
		aco().Location = new Point(128, 12);
		aco().MaxLength = 0;
		aco().Name = "TextBoxStartWave_10";
		aco().e(A_0: false);
		aco().RightToLeft = RightToLeft.No;
		aco().Size = new Size(85, 22);
		aco().TabIndex = 38;
		aco().TextAlign = HorizontalAlignment.Right;
		acp().BackColor = Color.Transparent;
		acp().Cursor = Cursors.Default;
		acp().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		acp().ForeColor = SystemColors.ControlText;
		acp().Location = new Point(40, 12);
		acp().Name = "LabelRegion_10";
		acp().RightToLeft = RightToLeft.No;
		acp().Size = new Size(73, 22);
		acp().TabIndex = 296;
		acp().Text = "R10";
		acp().TextAlign = ContentAlignment.MiddleCenter;
		acq().BackColor = SystemColors.Control;
		acq().BackgroundImage = Resources.Insert;
		acq().BackgroundImageLayout = ImageLayout.Center;
		acq().Cursor = Cursors.Default;
		acq().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		acq().ForeColor = SystemColors.ControlText;
		acq().Location = new Point(5, 383);
		acq().Name = "ButtonAddRegion_9";
		acq().RightToLeft = RightToLeft.No;
		acq().Size = new Size(24, 24);
		acq().TabIndex = 364;
		acq().TextAlign = ContentAlignment.BottomCenter;
		acq().UseVisualStyleBackColor = false;
		acr().BackColor = Color.Transparent;
		acr().Controls.Add(ah6());
		acr().Controls.Add(acs());
		acr().Controls.Add(act());
		acr().Controls.Add(acu());
		acr().Controls.Add(acv());
		acr().Controls.Add(acw());
		acr().Controls.Add(acx());
		acr().Controls.Add(acy());
		acr().Controls.Add(acz());
		acr().Controls.Add(ac0());
		acr().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		acr().ForeColor = SystemColors.ControlText;
		acr().Location = new Point(37, 393);
		acr().Name = "GroupBoxRegion_9";
		acr().RightToLeft = RightToLeft.No;
		acr().Size = new Size(678, 42);
		acr().TabIndex = 365;
		acr().TabStop = false;
		ah6().AutoSize = true;
		ah6().Location = new Point(585, 18);
		ah6().Name = "RadioButtonAvgReflA9";
		ah6().Size = new Size(14, 13);
		ah6().TabIndex = 297;
		ah6().TabStop = true;
		ah6().UseVisualStyleBackColor = true;
		acs().AutoSize = true;
		acs().Location = new Point(555, 18);
		acs().Name = "RadioButtonAvgReflT9";
		acs().Size = new Size(14, 13);
		acs().TabIndex = 8;
		acs().TabStop = true;
		acs().UseVisualStyleBackColor = true;
		act().AutoSize = true;
		act().Location = new Point(525, 18);
		act().Name = "RadioButtonAvgReflR9";
		act().Size = new Size(14, 13);
		act().TabIndex = 7;
		act().TabStop = true;
		act().UseVisualStyleBackColor = true;
		acu().Location = new Point(641, 14);
		acu().Name = "CheckBoxRegionActive_9";
		acu().Size = new Size(35, 22);
		acu().TabIndex = 9;
		acu().Text = " ";
		acu().UseVisualStyleBackColor = true;
		acv().AcceptsReturn = true;
		acv().BackColor = SystemColors.Window;
		acv().Cursor = Cursors.Default;
		acv().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		acv().ForeColor = SystemColors.WindowText;
		acv().f(A_0: false);
		acv().Location = new Point(425, 12);
		acv().MaxLength = 0;
		acv().Name = "TextBoxMaxR_9";
		acv().e(A_0: false);
		acv().RightToLeft = RightToLeft.No;
		acv().Size = new Size(75, 22);
		acv().TabIndex = 41;
		acv().TextAlign = HorizontalAlignment.Right;
		acw().BackColor = SystemColors.Window;
		acw().Cursor = Cursors.Default;
		acw().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		acw().ForeColor = SystemColors.WindowText;
		acw().f(A_0: false);
		acw().Location = new Point(228, 12);
		acw().Name = "TextBoxEndWave_9";
		acw().e(A_0: false);
		acw().RightToLeft = RightToLeft.No;
		acw().Size = new Size(85, 22);
		acw().TabIndex = 39;
		acw().TextAlign = HorizontalAlignment.Right;
		acx().AcceptsReturn = true;
		acx().BackColor = SystemColors.Window;
		acx().Cursor = Cursors.Default;
		acx().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		acx().ForeColor = SystemColors.WindowText;
		acx().f(A_0: false);
		acx().Location = new Point(331, 12);
		acx().MaxLength = 0;
		acx().Name = "TextBoxMinR_9";
		acx().e(A_0: false);
		acx().RightToLeft = RightToLeft.No;
		acx().Size = new Size(75, 22);
		acx().TabIndex = 40;
		acx().TextAlign = HorizontalAlignment.Right;
		acy().BackColor = SystemColors.Control;
		acy().BackgroundImage = Resources.x;
		acy().BackgroundImageLayout = ImageLayout.Center;
		acy().Cursor = Cursors.Default;
		acy().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		acy().ForeColor = SystemColors.ControlText;
		acy().Location = new Point(8, 14);
		acy().Name = "ButtonDeleteRegion_9";
		acy().RightToLeft = RightToLeft.No;
		acy().Size = new Size(18, 19);
		acy().TabIndex = 37;
		acy().TextAlign = ContentAlignment.BottomCenter;
		acy().UseVisualStyleBackColor = false;
		acz().AcceptsReturn = true;
		acz().BackColor = SystemColors.Window;
		acz().Cursor = Cursors.Default;
		acz().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		acz().ForeColor = SystemColors.WindowText;
		acz().f(A_0: false);
		acz().Location = new Point(128, 12);
		acz().MaxLength = 0;
		acz().Name = "TextBoxStartWave_9";
		acz().e(A_0: false);
		acz().RightToLeft = RightToLeft.No;
		acz().Size = new Size(85, 22);
		acz().TabIndex = 38;
		acz().TextAlign = HorizontalAlignment.Right;
		ac0().BackColor = Color.Transparent;
		ac0().Cursor = Cursors.Default;
		ac0().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ac0().ForeColor = SystemColors.ControlText;
		ac0().Location = new Point(40, 12);
		ac0().Name = "LabelRegion_9";
		ac0().RightToLeft = RightToLeft.No;
		ac0().Size = new Size(73, 22);
		ac0().TabIndex = 296;
		ac0().Text = "R9";
		ac0().TextAlign = ContentAlignment.MiddleCenter;
		ac1().BackColor = SystemColors.Control;
		ac1().BackgroundImage = Resources.Insert;
		ac1().BackgroundImageLayout = ImageLayout.Center;
		ac1().Cursor = Cursors.Default;
		ac1().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ac1().ForeColor = SystemColors.ControlText;
		ac1().Location = new Point(5, 339);
		ac1().Name = "ButtonAddRegion_8";
		ac1().RightToLeft = RightToLeft.No;
		ac1().Size = new Size(24, 24);
		ac1().TabIndex = 362;
		ac1().TextAlign = ContentAlignment.BottomCenter;
		ac1().UseVisualStyleBackColor = false;
		ac2().BackColor = Color.Transparent;
		ac2().Controls.Add(ah7());
		ac2().Controls.Add(ac3());
		ac2().Controls.Add(ac4());
		ac2().Controls.Add(ac5());
		ac2().Controls.Add(ac6());
		ac2().Controls.Add(ac7());
		ac2().Controls.Add(ac8());
		ac2().Controls.Add(ac9());
		ac2().Controls.Add(ada());
		ac2().Controls.Add(adb());
		ac2().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ac2().ForeColor = SystemColors.ControlText;
		ac2().Location = new Point(37, 349);
		ac2().Name = "GroupBoxRegion_8";
		ac2().RightToLeft = RightToLeft.No;
		ac2().Size = new Size(678, 42);
		ac2().TabIndex = 363;
		ac2().TabStop = false;
		ah7().AutoSize = true;
		ah7().Location = new Point(585, 18);
		ah7().Name = "RadioButtonAvgReflA8";
		ah7().Size = new Size(14, 13);
		ah7().TabIndex = 297;
		ah7().TabStop = true;
		ah7().UseVisualStyleBackColor = true;
		ac3().AutoSize = true;
		ac3().Location = new Point(555, 18);
		ac3().Name = "RadioButtonAvgReflT8";
		ac3().Size = new Size(14, 13);
		ac3().TabIndex = 8;
		ac3().TabStop = true;
		ac3().UseVisualStyleBackColor = true;
		ac4().AutoSize = true;
		ac4().Location = new Point(525, 18);
		ac4().Name = "RadioButtonAvgReflR8";
		ac4().Size = new Size(14, 13);
		ac4().TabIndex = 7;
		ac4().TabStop = true;
		ac4().UseVisualStyleBackColor = true;
		ac5().Location = new Point(641, 14);
		ac5().Name = "CheckBoxRegionActive_8";
		ac5().Size = new Size(35, 22);
		ac5().TabIndex = 9;
		ac5().Text = " ";
		ac5().UseVisualStyleBackColor = true;
		ac6().AcceptsReturn = true;
		ac6().BackColor = SystemColors.Window;
		ac6().Cursor = Cursors.Default;
		ac6().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ac6().ForeColor = SystemColors.WindowText;
		ac6().f(A_0: false);
		ac6().Location = new Point(425, 12);
		ac6().MaxLength = 0;
		ac6().Name = "TextBoxMaxR_8";
		ac6().e(A_0: false);
		ac6().RightToLeft = RightToLeft.No;
		ac6().Size = new Size(75, 22);
		ac6().TabIndex = 41;
		ac6().TextAlign = HorizontalAlignment.Right;
		ac7().BackColor = SystemColors.Window;
		ac7().Cursor = Cursors.Default;
		ac7().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ac7().ForeColor = SystemColors.WindowText;
		ac7().f(A_0: false);
		ac7().Location = new Point(228, 12);
		ac7().Name = "TextBoxEndWave_8";
		ac7().e(A_0: false);
		ac7().RightToLeft = RightToLeft.No;
		ac7().Size = new Size(85, 22);
		ac7().TabIndex = 39;
		ac7().TextAlign = HorizontalAlignment.Right;
		ac8().AcceptsReturn = true;
		ac8().BackColor = SystemColors.Window;
		ac8().Cursor = Cursors.Default;
		ac8().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ac8().ForeColor = SystemColors.WindowText;
		ac8().f(A_0: false);
		ac8().Location = new Point(331, 12);
		ac8().MaxLength = 0;
		ac8().Name = "TextBoxMinR_8";
		ac8().e(A_0: false);
		ac8().RightToLeft = RightToLeft.No;
		ac8().Size = new Size(75, 22);
		ac8().TabIndex = 40;
		ac8().TextAlign = HorizontalAlignment.Right;
		ac9().BackColor = SystemColors.Control;
		ac9().BackgroundImage = Resources.x;
		ac9().BackgroundImageLayout = ImageLayout.Center;
		ac9().Cursor = Cursors.Default;
		ac9().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ac9().ForeColor = SystemColors.ControlText;
		ac9().Location = new Point(8, 14);
		ac9().Name = "ButtonDeleteRegion_8";
		ac9().RightToLeft = RightToLeft.No;
		ac9().Size = new Size(18, 19);
		ac9().TabIndex = 37;
		ac9().TextAlign = ContentAlignment.BottomCenter;
		ac9().UseVisualStyleBackColor = false;
		ada().AcceptsReturn = true;
		ada().BackColor = SystemColors.Window;
		ada().Cursor = Cursors.Default;
		ada().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ada().ForeColor = SystemColors.WindowText;
		ada().f(A_0: false);
		ada().Location = new Point(128, 12);
		ada().MaxLength = 0;
		ada().Name = "TextBoxStartWave_8";
		ada().e(A_0: false);
		ada().RightToLeft = RightToLeft.No;
		ada().Size = new Size(85, 22);
		ada().TabIndex = 38;
		ada().TextAlign = HorizontalAlignment.Right;
		adb().BackColor = Color.Transparent;
		adb().Cursor = Cursors.Default;
		adb().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		adb().ForeColor = SystemColors.ControlText;
		adb().Location = new Point(40, 12);
		adb().Name = "LabelRegion_8";
		adb().RightToLeft = RightToLeft.No;
		adb().Size = new Size(73, 22);
		adb().TabIndex = 296;
		adb().Text = "R8";
		adb().TextAlign = ContentAlignment.MiddleCenter;
		adc().BackColor = SystemColors.Control;
		adc().BackgroundImage = Resources.Insert;
		adc().BackgroundImageLayout = ImageLayout.Center;
		adc().Cursor = Cursors.Default;
		adc().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		adc().ForeColor = SystemColors.ControlText;
		adc().Location = new Point(5, 295);
		adc().Name = "ButtonAddRegion_7";
		adc().RightToLeft = RightToLeft.No;
		adc().Size = new Size(24, 24);
		adc().TabIndex = 360;
		adc().TextAlign = ContentAlignment.BottomCenter;
		adc().UseVisualStyleBackColor = false;
		add().BackColor = Color.Transparent;
		add().Controls.Add(ah8());
		add().Controls.Add(ade());
		add().Controls.Add(adf());
		add().Controls.Add(adg());
		add().Controls.Add(adh());
		add().Controls.Add(adi());
		add().Controls.Add(adj());
		add().Controls.Add(adk());
		add().Controls.Add(adl());
		add().Controls.Add(adm());
		add().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		add().ForeColor = SystemColors.ControlText;
		add().Location = new Point(37, 305);
		add().Name = "GroupBoxRegion_7";
		add().RightToLeft = RightToLeft.No;
		add().Size = new Size(678, 42);
		add().TabIndex = 361;
		add().TabStop = false;
		ah8().AutoSize = true;
		ah8().Location = new Point(585, 18);
		ah8().Name = "RadioButtonAvgReflA7";
		ah8().Size = new Size(14, 13);
		ah8().TabIndex = 297;
		ah8().TabStop = true;
		ah8().UseVisualStyleBackColor = true;
		ade().AutoSize = true;
		ade().Location = new Point(555, 18);
		ade().Name = "RadioButtonAvgReflT7";
		ade().Size = new Size(14, 13);
		ade().TabIndex = 8;
		ade().TabStop = true;
		ade().UseVisualStyleBackColor = true;
		adf().AutoSize = true;
		adf().Location = new Point(525, 18);
		adf().Name = "RadioButtonAvgReflR7";
		adf().Size = new Size(14, 13);
		adf().TabIndex = 7;
		adf().TabStop = true;
		adf().UseVisualStyleBackColor = true;
		adg().Location = new Point(641, 14);
		adg().Name = "CheckBoxRegionActive_7";
		adg().Size = new Size(35, 22);
		adg().TabIndex = 9;
		adg().Text = " ";
		adg().UseVisualStyleBackColor = true;
		adh().AcceptsReturn = true;
		adh().BackColor = SystemColors.Window;
		adh().Cursor = Cursors.Default;
		adh().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		adh().ForeColor = SystemColors.WindowText;
		adh().f(A_0: false);
		adh().Location = new Point(425, 12);
		adh().MaxLength = 0;
		adh().Name = "TextBoxMaxR_7";
		adh().e(A_0: false);
		adh().RightToLeft = RightToLeft.No;
		adh().Size = new Size(75, 22);
		adh().TabIndex = 41;
		adh().TextAlign = HorizontalAlignment.Right;
		adi().BackColor = SystemColors.Window;
		adi().Cursor = Cursors.Default;
		adi().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		adi().ForeColor = SystemColors.WindowText;
		adi().f(A_0: false);
		adi().Location = new Point(228, 12);
		adi().Name = "TextBoxEndWave_7";
		adi().e(A_0: false);
		adi().RightToLeft = RightToLeft.No;
		adi().Size = new Size(85, 22);
		adi().TabIndex = 39;
		adi().TextAlign = HorizontalAlignment.Right;
		adj().AcceptsReturn = true;
		adj().BackColor = SystemColors.Window;
		adj().Cursor = Cursors.Default;
		adj().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		adj().ForeColor = SystemColors.WindowText;
		adj().f(A_0: false);
		adj().Location = new Point(331, 12);
		adj().MaxLength = 0;
		adj().Name = "TextBoxMinR_7";
		adj().e(A_0: false);
		adj().RightToLeft = RightToLeft.No;
		adj().Size = new Size(75, 22);
		adj().TabIndex = 40;
		adj().TextAlign = HorizontalAlignment.Right;
		adk().BackColor = SystemColors.Control;
		adk().BackgroundImage = Resources.x;
		adk().BackgroundImageLayout = ImageLayout.Center;
		adk().Cursor = Cursors.Default;
		adk().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		adk().ForeColor = SystemColors.ControlText;
		adk().Location = new Point(8, 14);
		adk().Name = "ButtonDeleteRegion_7";
		adk().RightToLeft = RightToLeft.No;
		adk().Size = new Size(18, 19);
		adk().TabIndex = 37;
		adk().TextAlign = ContentAlignment.BottomCenter;
		adk().UseVisualStyleBackColor = false;
		adl().AcceptsReturn = true;
		adl().BackColor = SystemColors.Window;
		adl().Cursor = Cursors.Default;
		adl().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		adl().ForeColor = SystemColors.WindowText;
		adl().f(A_0: false);
		adl().Location = new Point(128, 12);
		adl().MaxLength = 0;
		adl().Name = "TextBoxStartWave_7";
		adl().e(A_0: false);
		adl().RightToLeft = RightToLeft.No;
		adl().Size = new Size(85, 22);
		adl().TabIndex = 38;
		adl().TextAlign = HorizontalAlignment.Right;
		adm().BackColor = Color.Transparent;
		adm().Cursor = Cursors.Default;
		adm().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		adm().ForeColor = SystemColors.ControlText;
		adm().Location = new Point(40, 12);
		adm().Name = "LabelRegion_7";
		adm().RightToLeft = RightToLeft.No;
		adm().Size = new Size(73, 22);
		adm().TabIndex = 296;
		adm().Text = "R7";
		adm().TextAlign = ContentAlignment.MiddleCenter;
		z8().BackColor = Color.Transparent;
		z8().Cursor = Cursors.Default;
		z8().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		z8().ForeColor = SystemColors.WindowText;
		z8().Location = new Point(587, 22);
		z8().Name = "LabelSpecAnalysisAvgRSpecTypeT";
		z8().RightToLeft = RightToLeft.No;
		z8().Size = new Size(25, 17);
		z8().TabIndex = 359;
		z8().Text = "T";
		z8().TextAlign = ContentAlignment.TopCenter;
		z9().BackColor = Color.Transparent;
		z9().Cursor = Cursors.Default;
		z9().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		z9().ForeColor = SystemColors.WindowText;
		z9().Location = new Point(557, 22);
		z9().Name = "LabelSpecAnalysisAvgRSpecTypeR";
		z9().RightToLeft = RightToLeft.No;
		z9().Size = new Size(25, 17);
		z9().TabIndex = 358;
		z9().Text = "R";
		z9().TextAlign = ContentAlignment.TopCenter;
		aaa().BackColor = Color.Transparent;
		aaa().Cursor = Cursors.Default;
		aaa().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aaa().ForeColor = SystemColors.WindowText;
		aaa().Location = new Point(555, 6);
		aaa().Name = "LabelSpecAnalysisAvgRSpecType";
		aaa().RightToLeft = RightToLeft.No;
		aaa().Size = new Size(96, 17);
		aaa().TabIndex = 357;
		aaa().Text = "Spectrum Type";
		aaa().TextAlign = ContentAlignment.TopCenter;
		aab().BackColor = Color.Transparent;
		aab().Cursor = Cursors.Default;
		aab().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aab().ForeColor = SystemColors.WindowText;
		aab().Location = new Point(658, 22);
		aab().Name = "LabelSpecAnalysisAvgRActive";
		aab().RightToLeft = RightToLeft.No;
		aab().Size = new Size(51, 17);
		aab().TabIndex = 356;
		aab().Text = "Active";
		aab().TextAlign = ContentAlignment.TopCenter;
		aac().BackColor = SystemColors.Control;
		aac().BackgroundImage = Resources.Insert;
		aac().BackgroundImageLayout = ImageLayout.Center;
		aac().Cursor = Cursors.Default;
		aac().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		aac().ForeColor = SystemColors.ControlText;
		aac().Location = new Point(5, 251);
		aac().Name = "ButtonAddRegion_6";
		aac().RightToLeft = RightToLeft.No;
		aac().Size = new Size(24, 24);
		aac().TabIndex = 348;
		aac().TextAlign = ContentAlignment.BottomCenter;
		aac().UseVisualStyleBackColor = false;
		aad().BackColor = Color.Transparent;
		aad().Cursor = Cursors.Default;
		aad().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aad().ForeColor = SystemColors.WindowText;
		aad().Location = new Point(463, 22);
		aad().Name = "LabelSpecAnalysisAvgRMax";
		aad().RightToLeft = RightToLeft.No;
		aad().Size = new Size(75, 17);
		aad().TabIndex = 351;
		aad().Text = "Max R";
		aad().TextAlign = ContentAlignment.MiddleCenter;
		aae().BackColor = Color.Transparent;
		aae().Cursor = Cursors.Default;
		aae().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aae().ForeColor = SystemColors.WindowText;
		aae().Location = new Point(265, 6);
		aae().Name = "LabelSpecAnalysisAvgREndWave";
		aae().RightToLeft = RightToLeft.No;
		aae().Size = new Size(85, 36);
		aae().TabIndex = 352;
		aae().Text = "End Wavelength";
		aae().TextAlign = ContentAlignment.TopCenter;
		aaf().BackColor = Color.Transparent;
		aaf().Cursor = Cursors.Default;
		aaf().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aaf().ForeColor = SystemColors.WindowText;
		aaf().Location = new Point(368, 22);
		aaf().Name = "LabelSpecAnalysisAvgRMin";
		aaf().RightToLeft = RightToLeft.No;
		aaf().Size = new Size(75, 19);
		aaf().TabIndex = 353;
		aaf().Text = "Min R";
		aaf().TextAlign = ContentAlignment.TopCenter;
		aag().BackColor = Color.Transparent;
		aag().Cursor = Cursors.Default;
		aag().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aag().ForeColor = SystemColors.WindowText;
		aag().Location = new Point(164, 4);
		aag().Name = "LabelSpecAnalysisAvgRStartWave";
		aag().RightToLeft = RightToLeft.No;
		aag().Size = new Size(85, 36);
		aag().TabIndex = 354;
		aag().Text = "Start Wavelength";
		aag().TextAlign = ContentAlignment.MiddleCenter;
		aah().BackColor = Color.Transparent;
		aah().Cursor = Cursors.Default;
		aah().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aah().ForeColor = SystemColors.WindowText;
		aah().Location = new Point(77, 22);
		aah().Name = "LabelSpecAnalysisAvgRRegion";
		aah().RightToLeft = RightToLeft.No;
		aah().Size = new Size(73, 17);
		aah().TabIndex = 355;
		aah().Text = "Region";
		aah().TextAlign = ContentAlignment.TopCenter;
		aai().BackColor = Color.Transparent;
		aai().Controls.Add(ah9());
		aai().Controls.Add(aaj());
		aai().Controls.Add(aak());
		aai().Controls.Add(aal());
		aai().Controls.Add(aam());
		aai().Controls.Add(aan());
		aai().Controls.Add(aao());
		aai().Controls.Add(aap());
		aai().Controls.Add(aaq());
		aai().Controls.Add(aar());
		aai().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aai().ForeColor = SystemColors.ControlText;
		aai().Location = new Point(37, 41);
		aai().Name = "GroupBoxRegion_1";
		aai().RightToLeft = RightToLeft.No;
		aai().Size = new Size(678, 42);
		aai().TabIndex = 339;
		aai().TabStop = false;
		ah9().AutoSize = true;
		ah9().Location = new Point(585, 18);
		ah9().Name = "RadioButtonAvgReflA1";
		ah9().Size = new Size(14, 13);
		ah9().TabIndex = 107;
		ah9().TabStop = true;
		ah9().UseVisualStyleBackColor = true;
		aaj().AutoSize = true;
		aaj().Location = new Point(555, 18);
		aaj().Name = "RadioButtonAvgReflT1";
		aaj().Size = new Size(14, 13);
		aaj().TabIndex = 8;
		aaj().TabStop = true;
		aaj().UseVisualStyleBackColor = true;
		aak().AutoSize = true;
		aak().Location = new Point(525, 18);
		aak().Name = "RadioButtonAvgReflR1";
		aak().Size = new Size(14, 13);
		aak().TabIndex = 7;
		aak().TabStop = true;
		aak().UseVisualStyleBackColor = true;
		aal().Location = new Point(641, 14);
		aal().Name = "CheckBoxRegionActive_1";
		aal().Size = new Size(35, 22);
		aal().TabIndex = 9;
		aal().Text = " ";
		aal().UseVisualStyleBackColor = true;
		aam().AcceptsReturn = true;
		aam().BackColor = SystemColors.Window;
		aam().Cursor = Cursors.Default;
		aam().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aam().ForeColor = SystemColors.WindowText;
		aam().f(A_0: false);
		aam().Location = new Point(425, 12);
		aam().MaxLength = 0;
		aam().Name = "TextBoxMaxR_1";
		aam().e(A_0: false);
		aam().RightToLeft = RightToLeft.No;
		aam().Size = new Size(75, 22);
		aam().TabIndex = 6;
		aam().TextAlign = HorizontalAlignment.Right;
		aan().BackColor = SystemColors.Window;
		aan().Cursor = Cursors.Default;
		aan().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aan().ForeColor = SystemColors.WindowText;
		aan().f(A_0: false);
		aan().Location = new Point(228, 12);
		aan().Name = "TextBoxEndWave_1";
		aan().e(A_0: false);
		aan().RightToLeft = RightToLeft.No;
		aan().Size = new Size(85, 22);
		aan().TabIndex = 4;
		aan().TextAlign = HorizontalAlignment.Right;
		aao().BackColor = SystemColors.Control;
		aao().BackgroundImage = Resources.x;
		aao().BackgroundImageLayout = ImageLayout.Center;
		aao().Cursor = Cursors.Default;
		aao().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		aao().ForeColor = SystemColors.ControlText;
		aao().Location = new Point(8, 14);
		aao().Name = "ButtonDeleteRegion_1";
		aao().RightToLeft = RightToLeft.No;
		aao().Size = new Size(18, 19);
		aao().TabIndex = 2;
		aao().TextAlign = ContentAlignment.BottomCenter;
		aao().UseVisualStyleBackColor = false;
		aap().AcceptsReturn = true;
		aap().BackColor = SystemColors.Window;
		aap().Cursor = Cursors.Default;
		aap().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aap().ForeColor = SystemColors.WindowText;
		aap().f(A_0: false);
		aap().Location = new Point(331, 12);
		aap().MaxLength = 0;
		aap().Name = "TextBoxMinR_1";
		aap().e(A_0: false);
		aap().RightToLeft = RightToLeft.No;
		aap().Size = new Size(75, 22);
		aap().TabIndex = 5;
		aap().TextAlign = HorizontalAlignment.Right;
		aaq().AcceptsReturn = true;
		aaq().BackColor = SystemColors.Window;
		aaq().Cursor = Cursors.Default;
		aaq().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aaq().ForeColor = SystemColors.WindowText;
		aaq().f(A_0: false);
		aaq().Location = new Point(128, 12);
		aaq().MaxLength = 0;
		aaq().Name = "TextBoxStartWave_1";
		aaq().e(A_0: false);
		aaq().RightToLeft = RightToLeft.No;
		aaq().Size = new Size(85, 22);
		aaq().TabIndex = 3;
		aaq().TextAlign = HorizontalAlignment.Right;
		aar().BackColor = Color.Transparent;
		aar().Cursor = Cursors.Default;
		aar().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		aar().ForeColor = SystemColors.ControlText;
		aar().Location = new Point(40, 12);
		aar().Name = "LabelRegion_1";
		aar().RightToLeft = RightToLeft.No;
		aar().Size = new Size(73, 22);
		aar().TabIndex = 106;
		aar().Text = "R1";
		aar().TextAlign = ContentAlignment.MiddleCenter;
		aas().BackColor = SystemColors.Control;
		aas().BackgroundImage = Resources.Insert;
		aas().BackgroundImageLayout = ImageLayout.Center;
		aas().Cursor = Cursors.Default;
		aas().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		aas().ForeColor = SystemColors.ControlText;
		aas().Location = new Point(5, 31);
		aas().Name = "ButtonAddRegion_1";
		aas().RightToLeft = RightToLeft.No;
		aas().Size = new Size(24, 24);
		aas().TabIndex = 338;
		aas().TextAlign = ContentAlignment.BottomCenter;
		aas().UseVisualStyleBackColor = false;
		aat().BackColor = Color.Transparent;
		aat().Controls.Add(ah2());
		aat().Controls.Add(aau());
		aat().Controls.Add(aav());
		aat().Controls.Add(aaw());
		aat().Controls.Add(aax());
		aat().Controls.Add(aay());
		aat().Controls.Add(aaz());
		aat().Controls.Add(aa0());
		aat().Controls.Add(aa1());
		aat().Controls.Add(aa2());
		aat().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aat().ForeColor = SystemColors.ControlText;
		aat().Location = new Point(37, 85);
		aat().Name = "GroupBoxRegion_2";
		aat().RightToLeft = RightToLeft.No;
		aat().Size = new Size(678, 42);
		aat().TabIndex = 341;
		aat().TabStop = false;
		ah2().AutoSize = true;
		ah2().Location = new Point(585, 18);
		ah2().Name = "RadioButtonAvgReflA2";
		ah2().Size = new Size(14, 13);
		ah2().TabIndex = 257;
		ah2().TabStop = true;
		ah2().UseVisualStyleBackColor = true;
		aau().AutoSize = true;
		aau().Location = new Point(555, 18);
		aau().Name = "RadioButtonAvgReflT2";
		aau().Size = new Size(14, 13);
		aau().TabIndex = 8;
		aau().TabStop = true;
		aau().UseVisualStyleBackColor = true;
		aav().AutoSize = true;
		aav().Location = new Point(525, 18);
		aav().Name = "RadioButtonAvgReflR2";
		aav().Size = new Size(14, 13);
		aav().TabIndex = 7;
		aav().TabStop = true;
		aav().UseVisualStyleBackColor = true;
		aaw().Location = new Point(641, 14);
		aaw().Name = "CheckBoxRegionActive_2";
		aaw().Size = new Size(35, 22);
		aaw().TabIndex = 9;
		aaw().Text = " ";
		aaw().UseVisualStyleBackColor = true;
		aax().AcceptsReturn = true;
		aax().BackColor = SystemColors.Window;
		aax().Cursor = Cursors.Default;
		aax().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aax().ForeColor = SystemColors.WindowText;
		aax().f(A_0: false);
		aax().Location = new Point(425, 12);
		aax().MaxLength = 0;
		aax().Name = "TextBoxMaxR_2";
		aax().e(A_0: false);
		aax().RightToLeft = RightToLeft.No;
		aax().Size = new Size(75, 22);
		aax().TabIndex = 13;
		aax().TextAlign = HorizontalAlignment.Right;
		aay().BackColor = SystemColors.Window;
		aay().Cursor = Cursors.Default;
		aay().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aay().ForeColor = SystemColors.WindowText;
		aay().f(A_0: false);
		aay().Location = new Point(228, 12);
		aay().Name = "TextBoxEndWave_2";
		aay().e(A_0: false);
		aay().RightToLeft = RightToLeft.No;
		aay().Size = new Size(85, 22);
		aay().TabIndex = 11;
		aay().TextAlign = HorizontalAlignment.Right;
		aaz().AcceptsReturn = true;
		aaz().BackColor = SystemColors.Window;
		aaz().Cursor = Cursors.Default;
		aaz().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aaz().ForeColor = SystemColors.WindowText;
		aaz().f(A_0: false);
		aaz().Location = new Point(331, 12);
		aaz().MaxLength = 0;
		aaz().Name = "TextBoxMinR_2";
		aaz().e(A_0: false);
		aaz().RightToLeft = RightToLeft.No;
		aaz().Size = new Size(75, 22);
		aaz().TabIndex = 12;
		aaz().TextAlign = HorizontalAlignment.Right;
		aa0().BackColor = SystemColors.Control;
		aa0().BackgroundImage = Resources.x;
		aa0().BackgroundImageLayout = ImageLayout.Center;
		aa0().Cursor = Cursors.Default;
		aa0().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		aa0().ForeColor = SystemColors.ControlText;
		aa0().Location = new Point(8, 14);
		aa0().Name = "ButtonDeleteRegion_2";
		aa0().RightToLeft = RightToLeft.No;
		aa0().Size = new Size(18, 19);
		aa0().TabIndex = 9;
		aa0().TextAlign = ContentAlignment.BottomCenter;
		aa0().UseVisualStyleBackColor = false;
		aa1().AcceptsReturn = true;
		aa1().BackColor = SystemColors.Window;
		aa1().Cursor = Cursors.Default;
		aa1().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aa1().ForeColor = SystemColors.WindowText;
		aa1().f(A_0: false);
		aa1().Location = new Point(128, 12);
		aa1().MaxLength = 0;
		aa1().Name = "TextBoxStartWave_2";
		aa1().e(A_0: false);
		aa1().RightToLeft = RightToLeft.No;
		aa1().Size = new Size(85, 22);
		aa1().TabIndex = 10;
		aa1().TextAlign = HorizontalAlignment.Right;
		aa2().BackColor = Color.Transparent;
		aa2().Cursor = Cursors.Default;
		aa2().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		aa2().ForeColor = SystemColors.ControlText;
		aa2().Location = new Point(40, 12);
		aa2().Name = "LabelRegion_2";
		aa2().RightToLeft = RightToLeft.No;
		aa2().Size = new Size(73, 22);
		aa2().TabIndex = 256;
		aa2().Text = "R2";
		aa2().TextAlign = ContentAlignment.MiddleCenter;
		aa3().BackColor = Color.Transparent;
		aa3().Controls.Add(aia());
		aa3().Controls.Add(aa4());
		aa3().Controls.Add(aa5());
		aa3().Controls.Add(aa6());
		aa3().Controls.Add(aa7());
		aa3().Controls.Add(aa8());
		aa3().Controls.Add(aa9());
		aa3().Controls.Add(aba());
		aa3().Controls.Add(abb());
		aa3().Controls.Add(abc());
		aa3().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aa3().ForeColor = SystemColors.ControlText;
		aa3().Location = new Point(37, 129);
		aa3().Name = "GroupBoxRegion_3";
		aa3().RightToLeft = RightToLeft.No;
		aa3().Size = new Size(678, 42);
		aa3().TabIndex = 343;
		aa3().TabStop = false;
		aia().AutoSize = true;
		aia().Location = new Point(585, 18);
		aia().Name = "RadioButtonAvgReflA3";
		aia().Size = new Size(14, 13);
		aia().TabIndex = 267;
		aia().TabStop = true;
		aia().UseVisualStyleBackColor = true;
		aa4().AutoSize = true;
		aa4().Location = new Point(555, 18);
		aa4().Name = "RadioButtonAvgReflT3";
		aa4().Size = new Size(14, 13);
		aa4().TabIndex = 8;
		aa4().TabStop = true;
		aa4().UseVisualStyleBackColor = true;
		aa5().AutoSize = true;
		aa5().Location = new Point(525, 18);
		aa5().Name = "RadioButtonAvgReflR3";
		aa5().Size = new Size(14, 13);
		aa5().TabIndex = 7;
		aa5().TabStop = true;
		aa5().UseVisualStyleBackColor = true;
		aa6().Location = new Point(641, 14);
		aa6().Name = "CheckBoxRegionActive_3";
		aa6().Size = new Size(35, 22);
		aa6().TabIndex = 9;
		aa6().Text = " ";
		aa6().UseVisualStyleBackColor = true;
		aa7().AcceptsReturn = true;
		aa7().BackColor = SystemColors.Window;
		aa7().Cursor = Cursors.Default;
		aa7().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aa7().ForeColor = SystemColors.WindowText;
		aa7().f(A_0: false);
		aa7().Location = new Point(425, 12);
		aa7().MaxLength = 0;
		aa7().Name = "TextBoxMaxR_3";
		aa7().e(A_0: false);
		aa7().RightToLeft = RightToLeft.No;
		aa7().Size = new Size(75, 22);
		aa7().TabIndex = 20;
		aa7().TextAlign = HorizontalAlignment.Right;
		aa8().BackColor = SystemColors.Window;
		aa8().Cursor = Cursors.Default;
		aa8().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aa8().ForeColor = SystemColors.WindowText;
		aa8().f(A_0: false);
		aa8().Location = new Point(228, 12);
		aa8().Name = "TextBoxEndWave_3";
		aa8().e(A_0: false);
		aa8().RightToLeft = RightToLeft.No;
		aa8().Size = new Size(85, 22);
		aa8().TabIndex = 18;
		aa8().TextAlign = HorizontalAlignment.Right;
		aa9().AcceptsReturn = true;
		aa9().BackColor = SystemColors.Window;
		aa9().Cursor = Cursors.Default;
		aa9().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aa9().ForeColor = SystemColors.WindowText;
		aa9().f(A_0: false);
		aa9().Location = new Point(331, 12);
		aa9().MaxLength = 0;
		aa9().Name = "TextBoxMinR_3";
		aa9().e(A_0: false);
		aa9().RightToLeft = RightToLeft.No;
		aa9().Size = new Size(75, 22);
		aa9().TabIndex = 19;
		aa9().TextAlign = HorizontalAlignment.Right;
		aba().BackColor = SystemColors.Control;
		aba().BackgroundImage = Resources.x;
		aba().BackgroundImageLayout = ImageLayout.Center;
		aba().Cursor = Cursors.Default;
		aba().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		aba().ForeColor = SystemColors.ControlText;
		aba().Location = new Point(8, 14);
		aba().Name = "ButtonDeleteRegion_3";
		aba().RightToLeft = RightToLeft.No;
		aba().Size = new Size(18, 19);
		aba().TabIndex = 16;
		aba().TextAlign = ContentAlignment.BottomCenter;
		aba().UseVisualStyleBackColor = false;
		abb().AcceptsReturn = true;
		abb().BackColor = SystemColors.Window;
		abb().Cursor = Cursors.Default;
		abb().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		abb().ForeColor = SystemColors.WindowText;
		abb().f(A_0: false);
		abb().Location = new Point(128, 12);
		abb().MaxLength = 0;
		abb().Name = "TextBoxStartWave_3";
		abb().e(A_0: false);
		abb().RightToLeft = RightToLeft.No;
		abb().Size = new Size(85, 22);
		abb().TabIndex = 17;
		abb().TextAlign = HorizontalAlignment.Right;
		abc().BackColor = Color.Transparent;
		abc().Cursor = Cursors.Default;
		abc().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		abc().ForeColor = SystemColors.ControlText;
		abc().Location = new Point(40, 12);
		abc().Name = "LabelRegion_3";
		abc().RightToLeft = RightToLeft.No;
		abc().Size = new Size(73, 22);
		abc().TabIndex = 266;
		abc().Text = "R3";
		abc().TextAlign = ContentAlignment.MiddleCenter;
		abd().BackColor = Color.Transparent;
		abd().Controls.Add(aib());
		abd().Controls.Add(abe());
		abd().Controls.Add(abf());
		abd().Controls.Add(abg());
		abd().Controls.Add(abh());
		abd().Controls.Add(abi());
		abd().Controls.Add(abj());
		abd().Controls.Add(abk());
		abd().Controls.Add(abl());
		abd().Controls.Add(abm());
		abd().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		abd().ForeColor = SystemColors.ControlText;
		abd().Location = new Point(37, 173);
		abd().Name = "GroupBoxRegion_4";
		abd().RightToLeft = RightToLeft.No;
		abd().Size = new Size(678, 42);
		abd().TabIndex = 345;
		abd().TabStop = false;
		aib().AutoSize = true;
		aib().Location = new Point(585, 18);
		aib().Name = "RadioButtonAvgReflA4";
		aib().Size = new Size(14, 13);
		aib().TabIndex = 277;
		aib().TabStop = true;
		aib().UseVisualStyleBackColor = true;
		abe().AutoSize = true;
		abe().Location = new Point(555, 18);
		abe().Name = "RadioButtonAvgReflT4";
		abe().Size = new Size(14, 13);
		abe().TabIndex = 268;
		abe().TabStop = true;
		abe().UseVisualStyleBackColor = true;
		abf().AutoSize = true;
		abf().Location = new Point(525, 18);
		abf().Name = "RadioButtonAvgReflR4";
		abf().Size = new Size(14, 13);
		abf().TabIndex = 7;
		abf().TabStop = true;
		abf().UseVisualStyleBackColor = true;
		abg().Location = new Point(641, 14);
		abg().Name = "CheckBoxRegionActive_4";
		abg().Size = new Size(35, 22);
		abg().TabIndex = 9;
		abg().Text = " ";
		abg().UseVisualStyleBackColor = true;
		abh().AcceptsReturn = true;
		abh().BackColor = SystemColors.Window;
		abh().Cursor = Cursors.Default;
		abh().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		abh().ForeColor = SystemColors.WindowText;
		abh().f(A_0: false);
		abh().Location = new Point(425, 12);
		abh().MaxLength = 0;
		abh().Name = "TextBoxMaxR_4";
		abh().e(A_0: false);
		abh().RightToLeft = RightToLeft.No;
		abh().Size = new Size(75, 22);
		abh().TabIndex = 27;
		abh().TextAlign = HorizontalAlignment.Right;
		abi().BackColor = SystemColors.Window;
		abi().Cursor = Cursors.Default;
		abi().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		abi().ForeColor = SystemColors.WindowText;
		abi().f(A_0: false);
		abi().Location = new Point(228, 12);
		abi().Name = "TextBoxEndWave_4";
		abi().e(A_0: false);
		abi().RightToLeft = RightToLeft.No;
		abi().Size = new Size(85, 22);
		abi().TabIndex = 25;
		abi().TextAlign = HorizontalAlignment.Right;
		abj().AcceptsReturn = true;
		abj().BackColor = SystemColors.Window;
		abj().Cursor = Cursors.Default;
		abj().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		abj().ForeColor = SystemColors.WindowText;
		abj().f(A_0: false);
		abj().Location = new Point(331, 12);
		abj().MaxLength = 0;
		abj().Name = "TextBoxMinR_4";
		abj().e(A_0: false);
		abj().RightToLeft = RightToLeft.No;
		abj().Size = new Size(75, 22);
		abj().TabIndex = 26;
		abj().TextAlign = HorizontalAlignment.Right;
		abk().BackColor = SystemColors.Control;
		abk().BackgroundImage = Resources.x;
		abk().BackgroundImageLayout = ImageLayout.Center;
		abk().Cursor = Cursors.Default;
		abk().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		abk().ForeColor = SystemColors.ControlText;
		abk().Location = new Point(8, 14);
		abk().Name = "ButtonDeleteRegion_4";
		abk().RightToLeft = RightToLeft.No;
		abk().Size = new Size(18, 19);
		abk().TabIndex = 23;
		abk().TextAlign = ContentAlignment.BottomCenter;
		abk().UseVisualStyleBackColor = false;
		abl().AcceptsReturn = true;
		abl().BackColor = SystemColors.Window;
		abl().Cursor = Cursors.Default;
		abl().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		abl().ForeColor = SystemColors.WindowText;
		abl().f(A_0: false);
		abl().Location = new Point(128, 12);
		abl().MaxLength = 0;
		abl().Name = "TextBoxStartWave_4";
		abl().e(A_0: false);
		abl().RightToLeft = RightToLeft.No;
		abl().Size = new Size(85, 22);
		abl().TabIndex = 24;
		abl().TextAlign = HorizontalAlignment.Right;
		abm().BackColor = Color.Transparent;
		abm().Cursor = Cursors.Default;
		abm().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		abm().ForeColor = SystemColors.ControlText;
		abm().Location = new Point(40, 12);
		abm().Name = "LabelRegion_4";
		abm().RightToLeft = RightToLeft.No;
		abm().Size = new Size(73, 22);
		abm().TabIndex = 276;
		abm().Text = "R4";
		abm().TextAlign = ContentAlignment.MiddleCenter;
		abn().BackColor = Color.Transparent;
		abn().Controls.Add(aic());
		abn().Controls.Add(abo());
		abn().Controls.Add(abp());
		abn().Controls.Add(abq());
		abn().Controls.Add(abr());
		abn().Controls.Add(abs());
		abn().Controls.Add(abt());
		abn().Controls.Add(abu());
		abn().Controls.Add(abv());
		abn().Controls.Add(abw());
		abn().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		abn().ForeColor = SystemColors.ControlText;
		abn().Location = new Point(37, 217);
		abn().Name = "GroupBoxRegion_5";
		abn().RightToLeft = RightToLeft.No;
		abn().Size = new Size(678, 42);
		abn().TabIndex = 347;
		abn().TabStop = false;
		aic().AutoSize = true;
		aic().Location = new Point(585, 18);
		aic().Name = "RadioButtonAvgReflA5";
		aic().Size = new Size(14, 13);
		aic().TabIndex = 287;
		aic().TabStop = true;
		aic().UseVisualStyleBackColor = true;
		abo().AutoSize = true;
		abo().Location = new Point(555, 18);
		abo().Name = "RadioButtonAvgReflT5";
		abo().Size = new Size(14, 13);
		abo().TabIndex = 8;
		abo().TabStop = true;
		abo().UseVisualStyleBackColor = true;
		abp().AutoSize = true;
		abp().Location = new Point(525, 18);
		abp().Name = "RadioButtonAvgReflR5";
		abp().Size = new Size(14, 13);
		abp().TabIndex = 7;
		abp().TabStop = true;
		abp().UseVisualStyleBackColor = true;
		abq().Location = new Point(641, 14);
		abq().Name = "CheckBoxRegionActive_5";
		abq().Size = new Size(35, 22);
		abq().TabIndex = 9;
		abq().Text = " ";
		abq().UseVisualStyleBackColor = true;
		abr().AcceptsReturn = true;
		abr().BackColor = SystemColors.Window;
		abr().Cursor = Cursors.Default;
		abr().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		abr().ForeColor = SystemColors.WindowText;
		abr().f(A_0: false);
		abr().Location = new Point(425, 12);
		abr().MaxLength = 0;
		abr().Name = "TextBoxMaxR_5";
		abr().e(A_0: false);
		abr().RightToLeft = RightToLeft.No;
		abr().Size = new Size(75, 22);
		abr().TabIndex = 34;
		abr().TextAlign = HorizontalAlignment.Right;
		abs().BackColor = SystemColors.Window;
		abs().Cursor = Cursors.Default;
		abs().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		abs().ForeColor = SystemColors.WindowText;
		abs().f(A_0: false);
		abs().Location = new Point(228, 12);
		abs().Name = "TextBoxEndWave_5";
		abs().e(A_0: false);
		abs().RightToLeft = RightToLeft.No;
		abs().Size = new Size(85, 22);
		abs().TabIndex = 32;
		abs().TextAlign = HorizontalAlignment.Right;
		abt().AcceptsReturn = true;
		abt().BackColor = SystemColors.Window;
		abt().Cursor = Cursors.Default;
		abt().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		abt().ForeColor = SystemColors.WindowText;
		abt().f(A_0: false);
		abt().Location = new Point(331, 12);
		abt().MaxLength = 0;
		abt().Name = "TextBoxMinR_5";
		abt().e(A_0: false);
		abt().RightToLeft = RightToLeft.No;
		abt().Size = new Size(75, 22);
		abt().TabIndex = 33;
		abt().TextAlign = HorizontalAlignment.Right;
		abu().BackColor = SystemColors.Control;
		abu().BackgroundImage = Resources.x;
		abu().BackgroundImageLayout = ImageLayout.Center;
		abu().Cursor = Cursors.Default;
		abu().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		abu().ForeColor = SystemColors.ControlText;
		abu().Location = new Point(8, 14);
		abu().Name = "ButtonDeleteRegion_5";
		abu().RightToLeft = RightToLeft.No;
		abu().Size = new Size(18, 19);
		abu().TabIndex = 30;
		abu().TextAlign = ContentAlignment.BottomCenter;
		abu().UseVisualStyleBackColor = false;
		abv().AcceptsReturn = true;
		abv().BackColor = SystemColors.Window;
		abv().Cursor = Cursors.Default;
		abv().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		abv().ForeColor = SystemColors.WindowText;
		abv().f(A_0: false);
		abv().Location = new Point(128, 12);
		abv().MaxLength = 0;
		abv().Name = "TextBoxStartWave_5";
		abv().e(A_0: false);
		abv().RightToLeft = RightToLeft.No;
		abv().Size = new Size(85, 22);
		abv().TabIndex = 31;
		abv().TextAlign = HorizontalAlignment.Right;
		abw().BackColor = Color.Transparent;
		abw().Cursor = Cursors.Default;
		abw().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		abw().ForeColor = SystemColors.ControlText;
		abw().Location = new Point(40, 12);
		abw().Name = "LabelRegion_5";
		abw().RightToLeft = RightToLeft.No;
		abw().Size = new Size(73, 22);
		abw().TabIndex = 286;
		abw().Text = "R5";
		abw().TextAlign = ContentAlignment.MiddleCenter;
		abx().BackColor = Color.Transparent;
		abx().Controls.Add(aid());
		abx().Controls.Add(aby());
		abx().Controls.Add(abz());
		abx().Controls.Add(ab0());
		abx().Controls.Add(ab1());
		abx().Controls.Add(ab2());
		abx().Controls.Add(ab3());
		abx().Controls.Add(ab4());
		abx().Controls.Add(ab5());
		abx().Controls.Add(ab6());
		abx().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		abx().ForeColor = SystemColors.ControlText;
		abx().Location = new Point(37, 261);
		abx().Name = "GroupBoxRegion_6";
		abx().RightToLeft = RightToLeft.No;
		abx().Size = new Size(678, 42);
		abx().TabIndex = 349;
		abx().TabStop = false;
		aid().AutoSize = true;
		aid().Location = new Point(585, 18);
		aid().Name = "RadioButtonAvgReflA6";
		aid().Size = new Size(14, 13);
		aid().TabIndex = 297;
		aid().TabStop = true;
		aid().UseVisualStyleBackColor = true;
		aby().AutoSize = true;
		aby().Location = new Point(555, 18);
		aby().Name = "RadioButtonAvgReflT6";
		aby().Size = new Size(14, 13);
		aby().TabIndex = 8;
		aby().TabStop = true;
		aby().UseVisualStyleBackColor = true;
		abz().AutoSize = true;
		abz().Location = new Point(525, 18);
		abz().Name = "RadioButtonAvgReflR6";
		abz().Size = new Size(14, 13);
		abz().TabIndex = 7;
		abz().TabStop = true;
		abz().UseVisualStyleBackColor = true;
		ab0().Location = new Point(641, 14);
		ab0().Name = "CheckBoxRegionActive_6";
		ab0().Size = new Size(35, 22);
		ab0().TabIndex = 9;
		ab0().Text = " ";
		ab0().UseVisualStyleBackColor = true;
		ab1().AcceptsReturn = true;
		ab1().BackColor = SystemColors.Window;
		ab1().Cursor = Cursors.Default;
		ab1().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ab1().ForeColor = SystemColors.WindowText;
		ab1().f(A_0: false);
		ab1().Location = new Point(425, 12);
		ab1().MaxLength = 0;
		ab1().Name = "TextBoxMaxR_6";
		ab1().e(A_0: false);
		ab1().RightToLeft = RightToLeft.No;
		ab1().Size = new Size(75, 22);
		ab1().TabIndex = 41;
		ab1().TextAlign = HorizontalAlignment.Right;
		ab2().BackColor = SystemColors.Window;
		ab2().Cursor = Cursors.Default;
		ab2().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ab2().ForeColor = SystemColors.WindowText;
		ab2().f(A_0: false);
		ab2().Location = new Point(228, 12);
		ab2().Name = "TextBoxEndWave_6";
		ab2().e(A_0: false);
		ab2().RightToLeft = RightToLeft.No;
		ab2().Size = new Size(85, 22);
		ab2().TabIndex = 39;
		ab2().TextAlign = HorizontalAlignment.Right;
		ab3().AcceptsReturn = true;
		ab3().BackColor = SystemColors.Window;
		ab3().Cursor = Cursors.Default;
		ab3().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ab3().ForeColor = SystemColors.WindowText;
		ab3().f(A_0: false);
		ab3().Location = new Point(331, 12);
		ab3().MaxLength = 0;
		ab3().Name = "TextBoxMinR_6";
		ab3().e(A_0: false);
		ab3().RightToLeft = RightToLeft.No;
		ab3().Size = new Size(75, 22);
		ab3().TabIndex = 40;
		ab3().TextAlign = HorizontalAlignment.Right;
		ab4().BackColor = SystemColors.Control;
		ab4().BackgroundImage = Resources.x;
		ab4().BackgroundImageLayout = ImageLayout.Center;
		ab4().Cursor = Cursors.Default;
		ab4().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ab4().ForeColor = SystemColors.ControlText;
		ab4().Location = new Point(8, 14);
		ab4().Name = "ButtonDeleteRegion_6";
		ab4().RightToLeft = RightToLeft.No;
		ab4().Size = new Size(18, 19);
		ab4().TabIndex = 37;
		ab4().TextAlign = ContentAlignment.BottomCenter;
		ab4().UseVisualStyleBackColor = false;
		ab5().AcceptsReturn = true;
		ab5().BackColor = SystemColors.Window;
		ab5().Cursor = Cursors.Default;
		ab5().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ab5().ForeColor = SystemColors.WindowText;
		ab5().f(A_0: false);
		ab5().Location = new Point(128, 12);
		ab5().MaxLength = 0;
		ab5().Name = "TextBoxStartWave_6";
		ab5().e(A_0: false);
		ab5().RightToLeft = RightToLeft.No;
		ab5().Size = new Size(85, 22);
		ab5().TabIndex = 38;
		ab5().TextAlign = HorizontalAlignment.Right;
		ab6().BackColor = Color.Transparent;
		ab6().Cursor = Cursors.Default;
		ab6().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ab6().ForeColor = SystemColors.ControlText;
		ab6().Location = new Point(40, 12);
		ab6().Name = "LabelRegion_6";
		ab6().RightToLeft = RightToLeft.No;
		ab6().Size = new Size(73, 22);
		ab6().TabIndex = 296;
		ab6().Text = "R6";
		ab6().TextAlign = ContentAlignment.MiddleCenter;
		ab7().BackColor = SystemColors.Control;
		ab7().BackgroundImage = Resources.Insert;
		ab7().BackgroundImageLayout = ImageLayout.Center;
		ab7().Cursor = Cursors.Default;
		ab7().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ab7().ForeColor = SystemColors.ControlText;
		ab7().Location = new Point(5, 75);
		ab7().Name = "ButtonAddRegion_2";
		ab7().RightToLeft = RightToLeft.No;
		ab7().Size = new Size(24, 24);
		ab7().TabIndex = 340;
		ab7().TextAlign = ContentAlignment.BottomCenter;
		ab7().UseVisualStyleBackColor = false;
		ab8().BackColor = SystemColors.Control;
		ab8().BackgroundImage = Resources.Insert;
		ab8().BackgroundImageLayout = ImageLayout.Center;
		ab8().Cursor = Cursors.Default;
		ab8().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ab8().ForeColor = SystemColors.ControlText;
		ab8().Location = new Point(5, 119);
		ab8().Name = "ButtonAddRegion_3";
		ab8().RightToLeft = RightToLeft.No;
		ab8().Size = new Size(24, 24);
		ab8().TabIndex = 342;
		ab8().TextAlign = ContentAlignment.BottomCenter;
		ab8().UseVisualStyleBackColor = false;
		ab9().BackColor = SystemColors.Control;
		ab9().BackgroundImage = Resources.Insert;
		ab9().BackgroundImageLayout = ImageLayout.Center;
		ab9().Cursor = Cursors.Default;
		ab9().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ab9().ForeColor = SystemColors.ControlText;
		ab9().Location = new Point(5, 163);
		ab9().Name = "ButtonAddRegion_4";
		ab9().RightToLeft = RightToLeft.No;
		ab9().Size = new Size(24, 24);
		ab9().TabIndex = 344;
		ab9().TextAlign = ContentAlignment.BottomCenter;
		ab9().UseVisualStyleBackColor = false;
		aca().BackColor = SystemColors.Control;
		aca().BackgroundImage = Resources.Insert;
		aca().BackgroundImageLayout = ImageLayout.Center;
		aca().Cursor = Cursors.Default;
		aca().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		aca().ForeColor = SystemColors.ControlText;
		aca().Location = new Point(5, 207);
		aca().Name = "ButtonAddRegion_5";
		aca().RightToLeft = RightToLeft.No;
		aca().Size = new Size(24, 24);
		aca().TabIndex = 346;
		aca().TextAlign = ContentAlignment.BottomCenter;
		aca().UseVisualStyleBackColor = false;
		acb().BackColor = SystemColors.InactiveBorder;
		acb().Location = new Point(37, 30);
		acb().Name = "LabelSpecAnalysisAvgRHorizLine";
		acb().Size = new Size(648, 1);
		acb().TabIndex = 350;
		lq().Controls.Add(yl());
		lq().Location = new Point(4, 25);
		lq().Name = "TabPageMinMax";
		lq().Padding = new Padding(3);
		lq().Size = new Size(772, 366);
		lq().TabIndex = 1;
		lq().Text = "Min / Max";
		lq().UseVisualStyleBackColor = true;
		yl().AutoSize = true;
		yl().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		yl().ColumnCount = 1;
		yl().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		yl().Controls.Add(ym(), 0, 1);
		yl().Controls.Add(yn(), 0, 0);
		yl().Location = new Point(6, 6);
		yl().Name = "TableLayoutPanelMinMax";
		yl().RowCount = 2;
		yl().RowStyles.Add(new RowStyle(SizeType.Percent, 7.391304f));
		yl().RowStyles.Add(new RowStyle(SizeType.Percent, 92.6087f));
		yl().Size = new Size(762, 460);
		yl().TabIndex = 364;
		ym().AutoSize = true;
		ym().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ym().Controls.Add(aif());
		ym().Controls.Add(ys());
		ym().Controls.Add(lv());
		ym().Controls.Add(l4());
		ym().Controls.Add(lr());
		ym().Controls.Add(ls());
		ym().Controls.Add(lz());
		ym().Controls.Add(oy());
		ym().Controls.Add(l3());
		ym().Controls.Add(lt());
		ym().Controls.Add(l2());
		ym().Controls.Add(ox());
		ym().Controls.Add(mi());
		ym().Controls.Add(lu());
		ym().Controls.Add(l1());
		ym().Controls.Add(ow());
		ym().Controls.Add(mj());
		ym().Controls.Add(ov());
		ym().Controls.Add(l0());
		ym().Controls.Add(lw());
		ym().Controls.Add(mx());
		ym().Controls.Add(oe());
		ym().Controls.Add(nb());
		ym().Controls.Add(lx());
		ym().Controls.Add(ly());
		ym().Controls.Add(ns());
		ym().Controls.Add(oz());
		ym().Location = new Point(0, 33);
		ym().Margin = new Padding(0);
		ym().Name = "PanelMinMaxBottom";
		ym().Size = new Size(762, 309);
		ym().TabIndex = 366;
		aif().BackColor = Color.Transparent;
		aif().Cursor = Cursors.Default;
		aif().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aif().ForeColor = SystemColors.WindowText;
		aif().Location = new Point(677, 21);
		aif().Name = "LabelSpecAnalysisExTypeA";
		aif().RightToLeft = RightToLeft.No;
		aif().Size = new Size(25, 17);
		aif().TabIndex = 363;
		aif().Text = "A";
		aif().TextAlign = ContentAlignment.TopCenter;
		ys().AutoSize = true;
		ys().BackColor = Color.Transparent;
		ys().Cursor = Cursors.Default;
		ys().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ys().ForeColor = SystemColors.WindowText;
		ys().Location = new Point(256, 5);
		ys().Name = "LabelSpecAnalysisExHardLimits";
		ys().RightToLeft = RightToLeft.No;
		ys().Size = new Size(43, 32);
		ys().TabIndex = 362;
		ys().Text = "Hard\r\nLimits";
		ys().TextAlign = ContentAlignment.MiddleCenter;
		lv().BackColor = Color.Transparent;
		lv().Cursor = Cursors.Default;
		lv().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lv().ForeColor = SystemColors.WindowText;
		lv().Location = new Point(614, 5);
		lv().Name = "LabelSpecAnalysisExSpecType";
		lv().RightToLeft = RightToLeft.No;
		lv().Size = new Size(96, 17);
		lv().TabIndex = 358;
		lv().Text = "Spectrum Type";
		lv().TextAlign = ContentAlignment.TopCenter;
		l4().BackColor = Color.Transparent;
		l4().Controls.Add(yt());
		l4().Controls.Add(l5());
		l4().Controls.Add(l8());
		l4().Controls.Add(l9());
		l4().Controls.Add(ma());
		l4().Controls.Add(mb());
		l4().Controls.Add(mc());
		l4().Controls.Add(md());
		l4().Controls.Add(me());
		l4().Controls.Add(mf());
		l4().Controls.Add(mg());
		l4().Controls.Add(mh());
		l4().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		l4().ForeColor = SystemColors.ControlText;
		l4().Location = new Point(37, 41);
		l4().Name = "GroupBoxRegionEX_1";
		l4().RightToLeft = RightToLeft.No;
		l4().Size = new Size(720, 42);
		l4().TabIndex = 2;
		l4().TabStop = false;
		yt().Location = new Point(232, 14);
		yt().Name = "CheckBoxHardLimits_1";
		yt().Size = new Size(33, 22);
		yt().TabIndex = 112;
		yt().Text = " ";
		aei().SetToolTip(yt(), componentResourceManager.GetString("CheckBoxHardLimits_1.ToolTip"));
		yt().UseVisualStyleBackColor = true;
		l5().Controls.Add(aig());
		l5().Controls.Add(l6());
		l5().Controls.Add(l7());
		l5().Location = new Point(576, 14);
		l5().Name = "PanelSpecAnalysisEXType1";
		l5().Size = new Size(92, 21);
		l5().TabIndex = 111;
		aig().AutoSize = true;
		aig().Location = new Point(70, 4);
		aig().Name = "RadioButtonSpecAnalysisExA1";
		aig().Size = new Size(14, 13);
		aig().TabIndex = 12;
		aig().UseVisualStyleBackColor = true;
		l6().AutoSize = true;
		l6().Location = new Point(40, 4);
		l6().Name = "RadioButtonSpecAnalysisExT1";
		l6().Size = new Size(14, 13);
		l6().TabIndex = 11;
		l6().UseVisualStyleBackColor = true;
		l7().AutoSize = true;
		l7().Location = new Point(10, 4);
		l7().Name = "RadioButtonSpecAnalysisExR1";
		l7().Size = new Size(14, 13);
		l7().TabIndex = 10;
		l7().UseVisualStyleBackColor = true;
		l8().Location = new Point(527, 14);
		l8().Name = "CheckBoxHCCorr_1";
		l8().Size = new Size(33, 22);
		l8().TabIndex = 9;
		l8().Text = " ";
		l8().UseVisualStyleBackColor = true;
		l9().AutoSize = true;
		l9().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		l9().Location = new Point(409, 15);
		l9().Name = "RadioButtonMinEX_1";
		l9().Size = new Size(47, 20);
		l9().TabIndex = 7;
		l9().Text = "Min";
		l9().UseVisualStyleBackColor = true;
		ma().AutoSize = true;
		ma().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ma().Location = new Point(462, 15);
		ma().Name = "RadioButtonMaxEX_1";
		ma().Size = new Size(51, 20);
		ma().TabIndex = 8;
		ma().Text = "Max";
		ma().UseVisualStyleBackColor = true;
		mb().AcceptsReturn = true;
		mb().BackColor = SystemColors.Window;
		mb().Cursor = Cursors.Default;
		mb().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		mb().ForeColor = SystemColors.WindowText;
		mb().f(A_0: false);
		mb().Location = new Point(338, 12);
		mb().MaxLength = 0;
		mb().Name = "TextBoxMaxREX_1";
		mb().e(A_0: false);
		mb().RightToLeft = RightToLeft.No;
		mb().Size = new Size(55, 22);
		mb().TabIndex = 6;
		mb().TextAlign = HorizontalAlignment.Right;
		mc().AcceptsReturn = true;
		mc().BackColor = SystemColors.Window;
		mc().Cursor = Cursors.Default;
		mc().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		mc().ForeColor = SystemColors.WindowText;
		mc().f(A_0: false);
		mc().Location = new Point(269, 12);
		mc().MaxLength = 0;
		mc().Name = "TextBoxMinREX_1";
		mc().e(A_0: false);
		mc().RightToLeft = RightToLeft.No;
		mc().Size = new Size(55, 22);
		mc().TabIndex = 5;
		mc().TextAlign = HorizontalAlignment.Right;
		md().Location = new Point(691, 14);
		md().Name = "CheckBoxRegionActiveEX_1";
		md().Size = new Size(33, 22);
		md().TabIndex = 12;
		md().Text = " ";
		md().UseVisualStyleBackColor = true;
		me().BackColor = SystemColors.Window;
		me().Cursor = Cursors.Default;
		me().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		me().ForeColor = SystemColors.WindowText;
		me().f(A_0: false);
		me().Location = new Point(162, 12);
		me().Name = "TextBoxEndWaveEX_1";
		me().e(A_0: false);
		me().RightToLeft = RightToLeft.No;
		me().Size = new Size(55, 22);
		me().TabIndex = 4;
		me().TextAlign = HorizontalAlignment.Right;
		mf().BackColor = SystemColors.Control;
		mf().BackgroundImage = Resources.x;
		mf().BackgroundImageLayout = ImageLayout.Center;
		mf().Cursor = Cursors.Default;
		mf().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		mf().ForeColor = SystemColors.ControlText;
		mf().Location = new Point(8, 14);
		mf().Name = "ButtonDeleteRegionEX_1";
		mf().RightToLeft = RightToLeft.No;
		mf().Size = new Size(18, 19);
		mf().TabIndex = 2;
		mf().TextAlign = ContentAlignment.BottomCenter;
		mf().UseVisualStyleBackColor = true;
		mg().AcceptsReturn = true;
		mg().BackColor = SystemColors.Window;
		mg().Cursor = Cursors.Default;
		mg().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		mg().ForeColor = SystemColors.WindowText;
		mg().f(A_0: false);
		mg().Location = new Point(94, 12);
		mg().MaxLength = 0;
		mg().Name = "TextBoxStartWaveEX_1";
		mg().e(A_0: false);
		mg().RightToLeft = RightToLeft.No;
		mg().Size = new Size(55, 22);
		mg().TabIndex = 3;
		mg().Text = "1799.3";
		mg().TextAlign = HorizontalAlignment.Right;
		mh().BackColor = Color.Transparent;
		mh().Cursor = Cursors.Default;
		mh().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		mh().ForeColor = SystemColors.ControlText;
		mh().Location = new Point(40, 12);
		mh().Name = "Label58";
		mh().RightToLeft = RightToLeft.No;
		mh().Size = new Size(49, 22);
		mh().TabIndex = 106;
		mh().Text = "M1 ";
		mh().TextAlign = ContentAlignment.MiddleCenter;
		lr().BackColor = Color.Transparent;
		lr().Cursor = Cursors.Default;
		lr().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lr().ForeColor = SystemColors.WindowText;
		lr().Location = new Point(716, 21);
		lr().Name = "LabelSpecAnalysisExActive";
		lr().RightToLeft = RightToLeft.No;
		lr().Size = new Size(43, 17);
		lr().TabIndex = 353;
		lr().Text = "Active";
		lr().TextAlign = ContentAlignment.TopCenter;
		ls().BackColor = Color.Transparent;
		ls().Cursor = Cursors.Default;
		ls().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ls().ForeColor = SystemColors.WindowText;
		ls().Location = new Point(135, 5);
		ls().Name = "LabelSpecAnalysisExWaveLims";
		ls().RightToLeft = RightToLeft.No;
		ls().Size = new Size(120, 19);
		ls().TabIndex = 361;
		ls().Text = "Wavelength Limits";
		ls().TextAlign = ContentAlignment.TopCenter;
		lz().BackColor = Color.Transparent;
		lz().Cursor = Cursors.Default;
		lz().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lz().ForeColor = SystemColors.WindowText;
		lz().Location = new Point(303, 21);
		lz().Name = "LabelSpecAnalysisExMin";
		lz().RightToLeft = RightToLeft.No;
		lz().Size = new Size(62, 19);
		lz().TabIndex = 355;
		lz().Text = "Min (%)";
		lz().TextAlign = ContentAlignment.MiddleCenter;
		oy().BackColor = SystemColors.Control;
		oy().BackgroundImage = Resources.Insert;
		oy().BackgroundImageLayout = ImageLayout.Center;
		oy().Cursor = Cursors.Default;
		oy().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		oy().ForeColor = SystemColors.ControlText;
		oy().Location = new Point(5, 208);
		oy().Name = "ButtonAddRegionEX_5";
		oy().RightToLeft = RightToLeft.No;
		oy().Size = new Size(24, 24);
		oy().TabIndex = 41;
		oy().TextAlign = ContentAlignment.BottomCenter;
		oy().UseVisualStyleBackColor = true;
		l3().BackColor = Color.Transparent;
		l3().Cursor = Cursors.Default;
		l3().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		l3().ForeColor = SystemColors.WindowText;
		l3().Location = new Point(77, 21);
		l3().Name = "LabelSpecAnalysisExRegion";
		l3().RightToLeft = RightToLeft.No;
		l3().Size = new Size(49, 17);
		l3().TabIndex = 347;
		l3().Text = "Region";
		l3().TextAlign = ContentAlignment.TopCenter;
		lt().BackColor = Color.Transparent;
		lt().Cursor = Cursors.Default;
		lt().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lt().ForeColor = SystemColors.WindowText;
		lt().Location = new Point(647, 21);
		lt().Name = "LabelSpecAnalysisExTypeT";
		lt().RightToLeft = RightToLeft.No;
		lt().Size = new Size(25, 17);
		lt().TabIndex = 360;
		lt().Text = "T";
		lt().TextAlign = ContentAlignment.TopCenter;
		l2().BackColor = Color.Transparent;
		l2().Cursor = Cursors.Default;
		l2().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		l2().ForeColor = SystemColors.WindowText;
		l2().Location = new Point(139, 21);
		l2().Name = "LabelSpecAnalysisExStartWave";
		l2().RightToLeft = RightToLeft.No;
		l2().Size = new Size(43, 19);
		l2().TabIndex = 346;
		l2().Text = "Start";
		l2().TextAlign = ContentAlignment.TopCenter;
		ox().BackColor = SystemColors.Control;
		ox().BackgroundImage = Resources.Insert;
		ox().BackgroundImageLayout = ImageLayout.Center;
		ox().Cursor = Cursors.Default;
		ox().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ox().ForeColor = SystemColors.ControlText;
		ox().Location = new Point(5, 163);
		ox().Name = "ButtonAddRegionEX_4";
		ox().RightToLeft = RightToLeft.No;
		ox().Size = new Size(24, 24);
		ox().TabIndex = 31;
		ox().TextAlign = ContentAlignment.BottomCenter;
		ox().UseVisualStyleBackColor = true;
		mi().BackColor = SystemColors.Control;
		mi().BackgroundImage = Resources.Insert;
		mi().BackgroundImageLayout = ImageLayout.Center;
		mi().Cursor = Cursors.Default;
		mi().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		mi().ForeColor = SystemColors.ControlText;
		mi().Location = new Point(5, 31);
		mi().Name = "ButtonAddRegionEX_1";
		mi().RightToLeft = RightToLeft.No;
		mi().Size = new Size(24, 24);
		mi().TabIndex = 1;
		mi().TextAlign = ContentAlignment.BottomCenter;
		mi().UseVisualStyleBackColor = true;
		lu().BackColor = Color.Transparent;
		lu().Cursor = Cursors.Default;
		lu().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lu().ForeColor = SystemColors.WindowText;
		lu().Location = new Point(618, 21);
		lu().Name = "LabelSpecAnalysisExTypeR";
		lu().RightToLeft = RightToLeft.No;
		lu().Size = new Size(25, 17);
		lu().TabIndex = 359;
		lu().Text = "R";
		lu().TextAlign = ContentAlignment.TopCenter;
		l1().BackColor = Color.Transparent;
		l1().Cursor = Cursors.Default;
		l1().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		l1().ForeColor = SystemColors.WindowText;
		l1().Location = new Point(205, 21);
		l1().Name = "LabelSpecAnalysisExEndWave";
		l1().RightToLeft = RightToLeft.No;
		l1().Size = new Size(43, 19);
		l1().TabIndex = 343;
		l1().Text = "End";
		l1().TextAlign = ContentAlignment.TopCenter;
		ow().BackColor = SystemColors.Control;
		ow().BackgroundImage = Resources.Insert;
		ow().BackgroundImageLayout = ImageLayout.Center;
		ow().Cursor = Cursors.Default;
		ow().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ow().ForeColor = SystemColors.ControlText;
		ow().Location = new Point(5, 118);
		ow().Name = "ButtonAddRegionEX_3";
		ow().RightToLeft = RightToLeft.No;
		ow().Size = new Size(24, 24);
		ow().TabIndex = 21;
		ow().TextAlign = ContentAlignment.BottomCenter;
		ow().UseVisualStyleBackColor = true;
		mj().BackColor = Color.Transparent;
		mj().Controls.Add(yu());
		mj().Controls.Add(mk());
		mj().Controls.Add(mn());
		mj().Controls.Add(mo());
		mj().Controls.Add(mp());
		mj().Controls.Add(mq());
		mj().Controls.Add(mr());
		mj().Controls.Add(ms());
		mj().Controls.Add(mt());
		mj().Controls.Add(mu());
		mj().Controls.Add(mv());
		mj().Controls.Add(mw());
		mj().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		mj().ForeColor = SystemColors.ControlText;
		mj().Location = new Point(37, 85);
		mj().Name = "GroupBoxRegionEX_2";
		mj().RightToLeft = RightToLeft.No;
		mj().Size = new Size(720, 42);
		mj().TabIndex = 12;
		mj().TabStop = false;
		yu().Location = new Point(232, 14);
		yu().Name = "CheckBoxHardLimits_2";
		yu().Size = new Size(33, 22);
		yu().TabIndex = 113;
		yu().Text = " ";
		yu().UseVisualStyleBackColor = true;
		mk().Controls.Add(aih());
		mk().Controls.Add(ml());
		mk().Controls.Add(mm());
		mk().Location = new Point(576, 14);
		mk().Name = "PanelSpecAnalysisEXType2";
		mk().Size = new Size(92, 21);
		mk().TabIndex = 259;
		aih().AutoSize = true;
		aih().Location = new Point(70, 4);
		aih().Name = "RadioButtonSpecAnalysisExA2";
		aih().Size = new Size(14, 13);
		aih().TabIndex = 12;
		aih().TabStop = true;
		aih().UseVisualStyleBackColor = true;
		ml().AutoSize = true;
		ml().Location = new Point(40, 4);
		ml().Name = "RadioButtonSpecAnalysisExT2";
		ml().Size = new Size(14, 13);
		ml().TabIndex = 11;
		ml().TabStop = true;
		ml().UseVisualStyleBackColor = true;
		mm().AutoSize = true;
		mm().Location = new Point(10, 4);
		mm().Name = "RadioButtonSpecAnalysisExR2";
		mm().Size = new Size(14, 13);
		mm().TabIndex = 10;
		mm().TabStop = true;
		mm().UseVisualStyleBackColor = true;
		mn().AutoSize = true;
		mn().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		mn().Location = new Point(409, 15);
		mn().Name = "RadioButtonMinEX_2";
		mn().Size = new Size(47, 20);
		mn().TabIndex = 17;
		mn().TabStop = true;
		mn().Text = "Min";
		mn().UseVisualStyleBackColor = true;
		mo().AutoSize = true;
		mo().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		mo().Location = new Point(462, 15);
		mo().Name = "RadioButtonMaxEX_2";
		mo().Size = new Size(51, 20);
		mo().TabIndex = 18;
		mo().TabStop = true;
		mo().Text = "Max";
		mo().UseVisualStyleBackColor = true;
		mp().Location = new Point(527, 14);
		mp().Name = "CheckBoxHCCorr_2";
		mp().Size = new Size(33, 22);
		mp().TabIndex = 19;
		mp().Text = " ";
		mp().UseVisualStyleBackColor = true;
		mq().AcceptsReturn = true;
		mq().BackColor = SystemColors.Window;
		mq().Cursor = Cursors.Default;
		mq().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		mq().ForeColor = SystemColors.WindowText;
		mq().f(A_0: false);
		mq().Location = new Point(338, 12);
		mq().MaxLength = 0;
		mq().Name = "TextBoxMaxREX_2";
		mq().e(A_0: false);
		mq().RightToLeft = RightToLeft.No;
		mq().Size = new Size(55, 22);
		mq().TabIndex = 16;
		mq().TextAlign = HorizontalAlignment.Right;
		mr().AcceptsReturn = true;
		mr().BackColor = SystemColors.Window;
		mr().Cursor = Cursors.Default;
		mr().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		mr().ForeColor = SystemColors.WindowText;
		mr().f(A_0: false);
		mr().Location = new Point(269, 12);
		mr().MaxLength = 0;
		mr().Name = "TextBoxMinREX_2";
		mr().e(A_0: false);
		mr().RightToLeft = RightToLeft.No;
		mr().Size = new Size(55, 22);
		mr().TabIndex = 15;
		mr().TextAlign = HorizontalAlignment.Right;
		ms().Location = new Point(691, 14);
		ms().Name = "CheckBoxRegionActiveEX_2";
		ms().Size = new Size(33, 22);
		ms().TabIndex = 12;
		ms().Text = " ";
		ms().UseVisualStyleBackColor = true;
		mt().BackColor = SystemColors.Window;
		mt().Cursor = Cursors.Default;
		mt().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		mt().ForeColor = SystemColors.WindowText;
		mt().f(A_0: false);
		mt().Location = new Point(162, 12);
		mt().Name = "TextBoxEndWaveEX_2";
		mt().e(A_0: false);
		mt().RightToLeft = RightToLeft.No;
		mt().Size = new Size(55, 22);
		mt().TabIndex = 14;
		mt().TextAlign = HorizontalAlignment.Right;
		mu().BackColor = SystemColors.Control;
		mu().BackgroundImage = Resources.x;
		mu().BackgroundImageLayout = ImageLayout.Center;
		mu().Cursor = Cursors.Default;
		mu().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		mu().ForeColor = SystemColors.ControlText;
		mu().Location = new Point(8, 14);
		mu().Name = "ButtonDeleteRegionEX_2";
		mu().RightToLeft = RightToLeft.No;
		mu().Size = new Size(18, 19);
		mu().TabIndex = 12;
		mu().TextAlign = ContentAlignment.BottomCenter;
		mu().UseVisualStyleBackColor = true;
		mv().AcceptsReturn = true;
		mv().BackColor = SystemColors.Window;
		mv().Cursor = Cursors.Default;
		mv().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		mv().ForeColor = SystemColors.WindowText;
		mv().f(A_0: false);
		mv().Location = new Point(94, 12);
		mv().MaxLength = 0;
		mv().Name = "TextBoxStartWaveEX_2";
		mv().e(A_0: false);
		mv().RightToLeft = RightToLeft.No;
		mv().Size = new Size(55, 22);
		mv().TabIndex = 13;
		mv().TextAlign = HorizontalAlignment.Right;
		mw().BackColor = Color.Transparent;
		mw().Cursor = Cursors.Default;
		mw().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		mw().ForeColor = SystemColors.ControlText;
		mw().Location = new Point(40, 12);
		mw().Name = "Label59";
		mw().RightToLeft = RightToLeft.No;
		mw().Size = new Size(49, 22);
		mw().TabIndex = 256;
		mw().Text = "M2";
		mw().TextAlign = ContentAlignment.MiddleCenter;
		ov().BackColor = SystemColors.Control;
		ov().BackgroundImage = Resources.Insert;
		ov().BackgroundImageLayout = ImageLayout.Center;
		ov().Cursor = Cursors.Default;
		ov().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ov().ForeColor = SystemColors.ControlText;
		ov().Location = new Point(5, 76);
		ov().Name = "ButtonAddRegionEX_2";
		ov().RightToLeft = RightToLeft.No;
		ov().Size = new Size(24, 24);
		ov().TabIndex = 11;
		ov().TextAlign = ContentAlignment.BottomCenter;
		ov().UseVisualStyleBackColor = true;
		l0().BackColor = SystemColors.Control;
		l0().BackgroundImage = Resources.Insert;
		l0().BackgroundImageLayout = ImageLayout.Center;
		l0().Cursor = Cursors.Default;
		l0().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		l0().ForeColor = SystemColors.ControlText;
		l0().Location = new Point(5, 253);
		l0().Name = "ButtonAddRegionEX_6";
		l0().RightToLeft = RightToLeft.No;
		l0().Size = new Size(24, 24);
		l0().TabIndex = 51;
		l0().TextAlign = ContentAlignment.BottomCenter;
		l0().UseVisualStyleBackColor = true;
		lw().BackColor = Color.Transparent;
		lw().Cursor = Cursors.Default;
		lw().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lw().ForeColor = SystemColors.WindowText;
		lw().Location = new Point(539, 5);
		lw().Name = "LabelSpecAnalysisExHCCorr";
		lw().RightToLeft = RightToLeft.No;
		lw().Size = new Size(68, 36);
		lw().TabIndex = 357;
		lw().Text = "HC Correction";
		lw().TextAlign = ContentAlignment.TopCenter;
		mx().BackColor = Color.Transparent;
		mx().Controls.Add(yv());
		mx().Controls.Add(my());
		mx().Controls.Add(m1());
		mx().Controls.Add(m2());
		mx().Controls.Add(m3());
		mx().Controls.Add(m4());
		mx().Controls.Add(m5());
		mx().Controls.Add(m6());
		mx().Controls.Add(m7());
		mx().Controls.Add(m8());
		mx().Controls.Add(m9());
		mx().Controls.Add(na());
		mx().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		mx().ForeColor = SystemColors.ControlText;
		mx().Location = new Point(37, 129);
		mx().Name = "GroupBoxRegionEX_3";
		mx().RightToLeft = RightToLeft.No;
		mx().Size = new Size(720, 42);
		mx().TabIndex = 22;
		mx().TabStop = false;
		yv().Location = new Point(232, 14);
		yv().Name = "CheckBoxHardLimits_3";
		yv().Size = new Size(33, 22);
		yv().TabIndex = 260;
		yv().Text = " ";
		yv().UseVisualStyleBackColor = true;
		my().Controls.Add(aii());
		my().Controls.Add(mz());
		my().Controls.Add(m0());
		my().Location = new Point(576, 14);
		my().Name = "PanelSpecAnalysisEXType3";
		my().Size = new Size(92, 21);
		my().TabIndex = 269;
		aii().AutoSize = true;
		aii().Location = new Point(69, 4);
		aii().Name = "RadioButtonSpecAnalysisExA3";
		aii().Size = new Size(14, 13);
		aii().TabIndex = 12;
		aii().TabStop = true;
		aii().UseVisualStyleBackColor = true;
		mz().AutoSize = true;
		mz().Location = new Point(40, 4);
		mz().Name = "RadioButtonSpecAnalysisExT3";
		mz().Size = new Size(14, 13);
		mz().TabIndex = 11;
		mz().TabStop = true;
		mz().UseVisualStyleBackColor = true;
		m0().AutoSize = true;
		m0().Location = new Point(10, 4);
		m0().Name = "RadioButtonSpecAnalysisExR3";
		m0().Size = new Size(14, 13);
		m0().TabIndex = 1;
		m0().TabStop = true;
		m0().UseVisualStyleBackColor = true;
		m1().AutoSize = true;
		m1().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		m1().Location = new Point(409, 15);
		m1().Name = "RadioButtonMinEX_3";
		m1().Size = new Size(47, 20);
		m1().TabIndex = 27;
		m1().TabStop = true;
		m1().Text = "Min";
		m1().UseVisualStyleBackColor = true;
		m2().AutoSize = true;
		m2().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		m2().Location = new Point(462, 15);
		m2().Name = "RadioButtonMaxEX_3";
		m2().Size = new Size(51, 20);
		m2().TabIndex = 28;
		m2().TabStop = true;
		m2().Text = "Max";
		m2().UseVisualStyleBackColor = true;
		m3().Location = new Point(527, 14);
		m3().Name = "CheckBoxHCCorr_3";
		m3().Size = new Size(33, 22);
		m3().TabIndex = 29;
		m3().Text = " ";
		m3().UseVisualStyleBackColor = true;
		m4().AcceptsReturn = true;
		m4().BackColor = SystemColors.Window;
		m4().Cursor = Cursors.Default;
		m4().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		m4().ForeColor = SystemColors.WindowText;
		m4().f(A_0: false);
		m4().Location = new Point(338, 12);
		m4().MaxLength = 0;
		m4().Name = "TextBoxMaxREX_3";
		m4().e(A_0: false);
		m4().RightToLeft = RightToLeft.No;
		m4().Size = new Size(55, 22);
		m4().TabIndex = 26;
		m4().TextAlign = HorizontalAlignment.Right;
		m5().AcceptsReturn = true;
		m5().BackColor = SystemColors.Window;
		m5().Cursor = Cursors.Default;
		m5().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		m5().ForeColor = SystemColors.WindowText;
		m5().f(A_0: false);
		m5().Location = new Point(269, 12);
		m5().MaxLength = 0;
		m5().Name = "TextBoxMinREX_3";
		m5().e(A_0: false);
		m5().RightToLeft = RightToLeft.No;
		m5().Size = new Size(55, 22);
		m5().TabIndex = 25;
		m5().TextAlign = HorizontalAlignment.Right;
		m6().Location = new Point(691, 14);
		m6().Name = "CheckBoxRegionActiveEX_3";
		m6().Size = new Size(33, 22);
		m6().TabIndex = 12;
		m6().Text = " ";
		m6().UseVisualStyleBackColor = true;
		m7().BackColor = SystemColors.Window;
		m7().Cursor = Cursors.Default;
		m7().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		m7().ForeColor = SystemColors.WindowText;
		m7().f(A_0: false);
		m7().Location = new Point(162, 12);
		m7().Name = "TextBoxEndWaveEX_3";
		m7().e(A_0: false);
		m7().RightToLeft = RightToLeft.No;
		m7().Size = new Size(55, 22);
		m7().TabIndex = 24;
		m7().TextAlign = HorizontalAlignment.Right;
		m8().BackColor = SystemColors.Control;
		m8().BackgroundImage = Resources.x;
		m8().BackgroundImageLayout = ImageLayout.Center;
		m8().Cursor = Cursors.Default;
		m8().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		m8().ForeColor = SystemColors.ControlText;
		m8().Location = new Point(8, 14);
		m8().Name = "ButtonDeleteRegionEX_3";
		m8().RightToLeft = RightToLeft.No;
		m8().Size = new Size(18, 19);
		m8().TabIndex = 22;
		m8().TextAlign = ContentAlignment.BottomCenter;
		m8().UseVisualStyleBackColor = true;
		m9().AcceptsReturn = true;
		m9().BackColor = SystemColors.Window;
		m9().Cursor = Cursors.Default;
		m9().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		m9().ForeColor = SystemColors.WindowText;
		m9().f(A_0: false);
		m9().Location = new Point(94, 12);
		m9().MaxLength = 0;
		m9().Name = "TextBoxStartWaveEX_3";
		m9().e(A_0: false);
		m9().RightToLeft = RightToLeft.No;
		m9().Size = new Size(55, 22);
		m9().TabIndex = 23;
		m9().TextAlign = HorizontalAlignment.Right;
		na().BackColor = Color.Transparent;
		na().Cursor = Cursors.Default;
		na().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		na().ForeColor = SystemColors.ControlText;
		na().Location = new Point(40, 12);
		na().Name = "Label62";
		na().RightToLeft = RightToLeft.No;
		na().Size = new Size(49, 22);
		na().TabIndex = 266;
		na().Text = "M3";
		na().TextAlign = ContentAlignment.MiddleCenter;
		oe().BackColor = Color.Transparent;
		oe().Controls.Add(yy());
		oe().Controls.Add(oh());
		oe().Controls.Add(ol());
		oe().Controls.Add(om());
		oe().Controls.Add(on());
		oe().Controls.Add(oo());
		oe().Controls.Add(op());
		oe().Controls.Add(oq());
		oe().Controls.Add(or());
		oe().Controls.Add(os());
		oe().Controls.Add(ot());
		oe().Controls.Add(ou());
		oe().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		oe().ForeColor = SystemColors.ControlText;
		oe().Location = new Point(37, 264);
		oe().Name = "GroupBoxRegionEX_6";
		oe().RightToLeft = RightToLeft.No;
		oe().Size = new Size(720, 42);
		oe().TabIndex = 52;
		oe().TabStop = false;
		yy().Location = new Point(232, 14);
		yy().Name = "CheckBoxHardLimits_6";
		yy().Size = new Size(33, 22);
		yy().TabIndex = 290;
		yy().Text = " ";
		yy().UseVisualStyleBackColor = true;
		oh().Controls.Add(aij());
		oh().Controls.Add(oj());
		oh().Controls.Add(ok());
		oh().Location = new Point(576, 14);
		oh().Name = "PanelSpecAnalysisEXType6";
		oh().Size = new Size(92, 21);
		oh().TabIndex = 299;
		aij().AutoSize = true;
		aij().Location = new Point(70, 4);
		aij().Name = "RadioButtonSpecAnalysisExA6";
		aij().Size = new Size(14, 13);
		aij().TabIndex = 12;
		aij().TabStop = true;
		aij().UseVisualStyleBackColor = true;
		oj().AutoSize = true;
		oj().Location = new Point(40, 4);
		oj().Name = "RadioButtonSpecAnalysisExT6";
		oj().Size = new Size(14, 13);
		oj().TabIndex = 11;
		oj().TabStop = true;
		oj().UseVisualStyleBackColor = true;
		ok().AutoSize = true;
		ok().Location = new Point(10, 4);
		ok().Name = "RadioButtonSpecAnalysisExR6";
		ok().Size = new Size(14, 13);
		ok().TabIndex = 10;
		ok().TabStop = true;
		ok().UseVisualStyleBackColor = true;
		ol().AutoSize = true;
		ol().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ol().Location = new Point(409, 15);
		ol().Name = "RadioButtonMinEX_6";
		ol().Size = new Size(47, 20);
		ol().TabIndex = 57;
		ol().TabStop = true;
		ol().Text = "Min";
		ol().UseVisualStyleBackColor = true;
		om().AutoSize = true;
		om().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		om().Location = new Point(462, 15);
		om().Name = "RadioButtonMaxEX_6";
		om().Size = new Size(51, 20);
		om().TabIndex = 58;
		om().TabStop = true;
		om().Text = "Max";
		om().UseVisualStyleBackColor = true;
		on().Location = new Point(527, 14);
		on().Name = "CheckBoxHCCorr_6";
		on().Size = new Size(33, 22);
		on().TabIndex = 59;
		on().Text = " ";
		on().UseVisualStyleBackColor = true;
		oo().AcceptsReturn = true;
		oo().BackColor = SystemColors.Window;
		oo().Cursor = Cursors.Default;
		oo().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		oo().ForeColor = SystemColors.WindowText;
		oo().f(A_0: false);
		oo().Location = new Point(338, 12);
		oo().MaxLength = 0;
		oo().Name = "TextBoxMaxREX_6";
		oo().e(A_0: false);
		oo().RightToLeft = RightToLeft.No;
		oo().Size = new Size(55, 22);
		oo().TabIndex = 56;
		oo().TextAlign = HorizontalAlignment.Right;
		op().AcceptsReturn = true;
		op().BackColor = SystemColors.Window;
		op().Cursor = Cursors.Default;
		op().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		op().ForeColor = SystemColors.WindowText;
		op().f(A_0: false);
		op().Location = new Point(269, 12);
		op().MaxLength = 0;
		op().Name = "TextBoxMinREX_6";
		op().e(A_0: false);
		op().RightToLeft = RightToLeft.No;
		op().Size = new Size(55, 22);
		op().TabIndex = 55;
		op().TextAlign = HorizontalAlignment.Right;
		oq().Location = new Point(691, 14);
		oq().Name = "CheckBoxRegionActiveEX_6";
		oq().Size = new Size(33, 22);
		oq().TabIndex = 12;
		oq().Text = " ";
		oq().UseVisualStyleBackColor = true;
		or().BackColor = SystemColors.Window;
		or().Cursor = Cursors.Default;
		or().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		or().ForeColor = SystemColors.WindowText;
		or().f(A_0: false);
		or().Location = new Point(162, 12);
		or().Name = "TextBoxEndWaveEX_6";
		or().e(A_0: false);
		or().RightToLeft = RightToLeft.No;
		or().Size = new Size(55, 22);
		or().TabIndex = 54;
		or().TextAlign = HorizontalAlignment.Right;
		os().BackColor = SystemColors.Control;
		os().BackgroundImage = Resources.x;
		os().BackgroundImageLayout = ImageLayout.Center;
		os().Cursor = Cursors.Default;
		os().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		os().ForeColor = SystemColors.ControlText;
		os().Location = new Point(8, 14);
		os().Name = "ButtonDeleteRegionEX_6";
		os().RightToLeft = RightToLeft.No;
		os().Size = new Size(18, 19);
		os().TabIndex = 52;
		os().TextAlign = ContentAlignment.BottomCenter;
		os().UseVisualStyleBackColor = true;
		ot().AcceptsReturn = true;
		ot().BackColor = SystemColors.Window;
		ot().Cursor = Cursors.Default;
		ot().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ot().ForeColor = SystemColors.WindowText;
		ot().f(A_0: false);
		ot().Location = new Point(94, 12);
		ot().MaxLength = 0;
		ot().Name = "TextBoxStartWaveEX_6";
		ot().e(A_0: false);
		ot().RightToLeft = RightToLeft.No;
		ot().Size = new Size(55, 22);
		ot().TabIndex = 53;
		ot().TextAlign = HorizontalAlignment.Right;
		ou().BackColor = Color.Transparent;
		ou().Cursor = Cursors.Default;
		ou().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ou().ForeColor = SystemColors.ControlText;
		ou().Location = new Point(40, 12);
		ou().Name = "Label65";
		ou().RightToLeft = RightToLeft.No;
		ou().Size = new Size(49, 22);
		ou().TabIndex = 296;
		ou().Text = "M6";
		ou().TextAlign = ContentAlignment.MiddleCenter;
		nb().BackColor = Color.Transparent;
		nb().Controls.Add(yw());
		nb().Controls.Add(nc());
		nb().Controls.Add(nf());
		nb().Controls.Add(ng());
		nb().Controls.Add(nh());
		nb().Controls.Add(nl());
		nb().Controls.Add(nm());
		nb().Controls.Add(nn());
		nb().Controls.Add(no());
		nb().Controls.Add(np());
		nb().Controls.Add(nq());
		nb().Controls.Add(nr());
		nb().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		nb().ForeColor = SystemColors.ControlText;
		nb().Location = new Point(37, 174);
		nb().Name = "GroupBoxRegionEX_4";
		nb().RightToLeft = RightToLeft.No;
		nb().Size = new Size(720, 42);
		nb().TabIndex = 32;
		nb().TabStop = false;
		yw().Location = new Point(232, 14);
		yw().Name = "CheckBoxHardLimits_4";
		yw().Size = new Size(33, 22);
		yw().TabIndex = 270;
		yw().Text = " ";
		yw().UseVisualStyleBackColor = true;
		nc().Controls.Add(aik());
		nc().Controls.Add(nd());
		nc().Controls.Add(ne());
		nc().Location = new Point(576, 14);
		nc().Name = "PanelSpecAnalysisEXType4";
		nc().Size = new Size(92, 21);
		nc().TabIndex = 279;
		aik().AutoSize = true;
		aik().Location = new Point(70, 4);
		aik().Name = "RadioButtonSpecAnalysisExA4";
		aik().Size = new Size(14, 13);
		aik().TabIndex = 12;
		aik().TabStop = true;
		aik().UseVisualStyleBackColor = true;
		nd().AutoSize = true;
		nd().Location = new Point(40, 4);
		nd().Name = "RadioButtonSpecAnalysisExT4";
		nd().Size = new Size(14, 13);
		nd().TabIndex = 11;
		nd().TabStop = true;
		nd().UseVisualStyleBackColor = true;
		ne().AutoSize = true;
		ne().Location = new Point(10, 4);
		ne().Name = "RadioButtonSpecAnalysisExR4";
		ne().Size = new Size(14, 13);
		ne().TabIndex = 10;
		ne().TabStop = true;
		ne().UseVisualStyleBackColor = true;
		nf().AutoSize = true;
		nf().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		nf().Location = new Point(409, 15);
		nf().Name = "RadioButtonMinEX_4";
		nf().Size = new Size(47, 20);
		nf().TabIndex = 37;
		nf().TabStop = true;
		nf().Text = "Min";
		nf().UseVisualStyleBackColor = true;
		ng().AutoSize = true;
		ng().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ng().Location = new Point(462, 15);
		ng().Name = "RadioButtonMaxEX_4";
		ng().Size = new Size(51, 20);
		ng().TabIndex = 38;
		ng().TabStop = true;
		ng().Text = "Max";
		ng().UseVisualStyleBackColor = true;
		nh().Location = new Point(527, 14);
		nh().Name = "CheckBoxHCCorr_4";
		nh().Size = new Size(33, 22);
		nh().TabIndex = 39;
		nh().Text = " ";
		nh().UseVisualStyleBackColor = true;
		nl().AcceptsReturn = true;
		nl().BackColor = SystemColors.Window;
		nl().Cursor = Cursors.Default;
		nl().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		nl().ForeColor = SystemColors.WindowText;
		nl().f(A_0: false);
		nl().Location = new Point(338, 12);
		nl().MaxLength = 0;
		nl().Name = "TextBoxMaxREX_4";
		nl().e(A_0: false);
		nl().RightToLeft = RightToLeft.No;
		nl().Size = new Size(55, 22);
		nl().TabIndex = 36;
		nl().TextAlign = HorizontalAlignment.Right;
		nm().AcceptsReturn = true;
		nm().BackColor = SystemColors.Window;
		nm().Cursor = Cursors.Default;
		nm().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		nm().ForeColor = SystemColors.WindowText;
		nm().f(A_0: false);
		nm().Location = new Point(269, 12);
		nm().MaxLength = 0;
		nm().Name = "TextBoxMinREX_4";
		nm().e(A_0: false);
		nm().RightToLeft = RightToLeft.No;
		nm().Size = new Size(55, 22);
		nm().TabIndex = 35;
		nm().TextAlign = HorizontalAlignment.Right;
		nn().Location = new Point(691, 14);
		nn().Name = "CheckBoxRegionActiveEX_4";
		nn().Size = new Size(33, 22);
		nn().TabIndex = 12;
		nn().Text = " ";
		nn().UseVisualStyleBackColor = true;
		no().BackColor = SystemColors.Window;
		no().Cursor = Cursors.Default;
		no().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		no().ForeColor = SystemColors.WindowText;
		no().f(A_0: false);
		no().Location = new Point(162, 12);
		no().Name = "TextBoxEndWaveEX_4";
		no().e(A_0: false);
		no().RightToLeft = RightToLeft.No;
		no().Size = new Size(55, 22);
		no().TabIndex = 34;
		no().TextAlign = HorizontalAlignment.Right;
		np().BackColor = SystemColors.Control;
		np().BackgroundImage = Resources.x;
		np().BackgroundImageLayout = ImageLayout.Center;
		np().Cursor = Cursors.Default;
		np().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		np().ForeColor = SystemColors.ControlText;
		np().Location = new Point(8, 14);
		np().Name = "ButtonDeleteRegionEX_4";
		np().RightToLeft = RightToLeft.No;
		np().Size = new Size(18, 19);
		np().TabIndex = 32;
		np().TextAlign = ContentAlignment.BottomCenter;
		np().UseVisualStyleBackColor = true;
		nq().AcceptsReturn = true;
		nq().BackColor = SystemColors.Window;
		nq().Cursor = Cursors.Default;
		nq().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		nq().ForeColor = SystemColors.WindowText;
		nq().f(A_0: false);
		nq().Location = new Point(94, 12);
		nq().MaxLength = 0;
		nq().Name = "TextBoxStartWaveEX_4";
		nq().e(A_0: false);
		nq().RightToLeft = RightToLeft.No;
		nq().Size = new Size(55, 22);
		nq().TabIndex = 33;
		nq().TextAlign = HorizontalAlignment.Right;
		nr().BackColor = Color.Transparent;
		nr().Cursor = Cursors.Default;
		nr().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		nr().ForeColor = SystemColors.ControlText;
		nr().Location = new Point(40, 12);
		nr().Name = "Label63";
		nr().RightToLeft = RightToLeft.No;
		nr().Size = new Size(49, 22);
		nr().TabIndex = 276;
		nr().Text = "M4";
		nr().TextAlign = ContentAlignment.MiddleCenter;
		lx().BackColor = Color.Transparent;
		lx().Cursor = Cursors.Default;
		lx().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lx().ForeColor = SystemColors.WindowText;
		lx().Location = new Point(456, 5);
		lx().Name = "LabelSpecAnalysisExExType";
		lx().RightToLeft = RightToLeft.No;
		lx().Size = new Size(74, 36);
		lx().TabIndex = 356;
		lx().Text = "Extrema Type";
		lx().TextAlign = ContentAlignment.TopCenter;
		ly().BackColor = Color.Transparent;
		ly().Cursor = Cursors.Default;
		ly().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ly().ForeColor = SystemColors.WindowText;
		ly().Location = new Point(373, 21);
		ly().Name = "LabelSpecAnalysisExMax";
		ly().RightToLeft = RightToLeft.No;
		ly().Size = new Size(66, 19);
		ly().TabIndex = 354;
		ly().Text = "Max (%)";
		ly().TextAlign = ContentAlignment.MiddleCenter;
		ns().BackColor = Color.Transparent;
		ns().Controls.Add(yx());
		ns().Controls.Add(nt());
		ns().Controls.Add(nx());
		ns().Controls.Add(ny());
		ns().Controls.Add(nz());
		ns().Controls.Add(n0());
		ns().Controls.Add(n1());
		ns().Controls.Add(n3());
		ns().Controls.Add(n4());
		ns().Controls.Add(n8());
		ns().Controls.Add(oc());
		ns().Controls.Add(od());
		ns().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ns().ForeColor = SystemColors.ControlText;
		ns().Location = new Point(37, 219);
		ns().Name = "GroupBoxRegionEX_5";
		ns().RightToLeft = RightToLeft.No;
		ns().Size = new Size(720, 42);
		ns().TabIndex = 42;
		ns().TabStop = false;
		yx().Location = new Point(232, 14);
		yx().Name = "CheckBoxHardLimits_5";
		yx().Size = new Size(33, 22);
		yx().TabIndex = 280;
		yx().Text = " ";
		yx().UseVisualStyleBackColor = true;
		nt().Controls.Add(ail());
		nt().Controls.Add(nv());
		nt().Controls.Add(nw());
		nt().Location = new Point(576, 14);
		nt().Name = "PanelSpecAnalysisEXType5";
		nt().Size = new Size(92, 21);
		nt().TabIndex = 289;
		ail().AutoSize = true;
		ail().Location = new Point(70, 4);
		ail().Name = "RadioButtonSpecAnalysisExA5";
		ail().Size = new Size(14, 13);
		ail().TabIndex = 12;
		ail().TabStop = true;
		ail().UseVisualStyleBackColor = true;
		nv().AutoSize = true;
		nv().Location = new Point(40, 4);
		nv().Name = "RadioButtonSpecAnalysisExT5";
		nv().Size = new Size(14, 13);
		nv().TabIndex = 11;
		nv().TabStop = true;
		nv().UseVisualStyleBackColor = true;
		nw().AutoSize = true;
		nw().Location = new Point(10, 4);
		nw().Name = "RadioButtonSpecAnalysisExR5";
		nw().Size = new Size(14, 13);
		nw().TabIndex = 10;
		nw().TabStop = true;
		nw().UseVisualStyleBackColor = true;
		nx().AutoSize = true;
		nx().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		nx().Location = new Point(409, 15);
		nx().Name = "RadioButtonMinEX_5";
		nx().Size = new Size(47, 20);
		nx().TabIndex = 47;
		nx().TabStop = true;
		nx().Text = "Min";
		nx().UseVisualStyleBackColor = true;
		ny().AutoSize = true;
		ny().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ny().Location = new Point(462, 15);
		ny().Name = "RadioButtonMaxEX_5";
		ny().Size = new Size(51, 20);
		ny().TabIndex = 48;
		ny().TabStop = true;
		ny().Text = "Max";
		ny().UseVisualStyleBackColor = true;
		nz().Location = new Point(527, 14);
		nz().Name = "CheckBoxHCCorr_5";
		nz().Size = new Size(33, 22);
		nz().TabIndex = 49;
		nz().Text = " ";
		nz().UseVisualStyleBackColor = true;
		n0().AcceptsReturn = true;
		n0().BackColor = SystemColors.Window;
		n0().Cursor = Cursors.Default;
		n0().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		n0().ForeColor = SystemColors.WindowText;
		n0().f(A_0: false);
		n0().Location = new Point(338, 12);
		n0().MaxLength = 0;
		n0().Name = "TextBoxMaxREX_5";
		n0().e(A_0: false);
		n0().RightToLeft = RightToLeft.No;
		n0().Size = new Size(55, 22);
		n0().TabIndex = 46;
		n0().TextAlign = HorizontalAlignment.Right;
		n1().AcceptsReturn = true;
		n1().BackColor = SystemColors.Window;
		n1().Cursor = Cursors.Default;
		n1().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		n1().ForeColor = SystemColors.WindowText;
		n1().f(A_0: false);
		n1().Location = new Point(269, 12);
		n1().MaxLength = 0;
		n1().Name = "TextBoxMinREX_5";
		n1().e(A_0: false);
		n1().RightToLeft = RightToLeft.No;
		n1().Size = new Size(55, 22);
		n1().TabIndex = 45;
		n1().TextAlign = HorizontalAlignment.Right;
		n3().Location = new Point(691, 14);
		n3().Name = "CheckBoxRegionActiveEX_5";
		n3().Size = new Size(33, 22);
		n3().TabIndex = 12;
		n3().Text = " ";
		n3().UseVisualStyleBackColor = true;
		n4().BackColor = SystemColors.Window;
		n4().Cursor = Cursors.Default;
		n4().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		n4().ForeColor = SystemColors.WindowText;
		n4().f(A_0: false);
		n4().Location = new Point(162, 12);
		n4().Name = "TextBoxEndWaveEX_5";
		n4().e(A_0: false);
		n4().RightToLeft = RightToLeft.No;
		n4().Size = new Size(55, 22);
		n4().TabIndex = 44;
		n4().TextAlign = HorizontalAlignment.Right;
		n8().BackColor = SystemColors.Control;
		n8().BackgroundImage = Resources.x;
		n8().BackgroundImageLayout = ImageLayout.Center;
		n8().Cursor = Cursors.Default;
		n8().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		n8().ForeColor = SystemColors.ControlText;
		n8().Location = new Point(8, 14);
		n8().Name = "ButtonDeleteRegionEX_5";
		n8().RightToLeft = RightToLeft.No;
		n8().Size = new Size(18, 19);
		n8().TabIndex = 42;
		n8().TextAlign = ContentAlignment.BottomCenter;
		n8().UseVisualStyleBackColor = true;
		oc().AcceptsReturn = true;
		oc().BackColor = SystemColors.Window;
		oc().Cursor = Cursors.Default;
		oc().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		oc().ForeColor = SystemColors.WindowText;
		oc().f(A_0: false);
		oc().Location = new Point(94, 12);
		oc().MaxLength = 0;
		oc().Name = "TextBoxStartWaveEX_5";
		oc().e(A_0: false);
		oc().RightToLeft = RightToLeft.No;
		oc().Size = new Size(55, 22);
		oc().TabIndex = 43;
		oc().TextAlign = HorizontalAlignment.Right;
		od().BackColor = Color.Transparent;
		od().Cursor = Cursors.Default;
		od().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		od().ForeColor = SystemColors.ControlText;
		od().Location = new Point(40, 12);
		od().Name = "Label64";
		od().RightToLeft = RightToLeft.No;
		od().Size = new Size(49, 22);
		od().TabIndex = 286;
		od().Text = "M5";
		od().TextAlign = ContentAlignment.MiddleCenter;
		oz().BackColor = SystemColors.InactiveBorder;
		oz().Location = new Point(82, 30);
		oz().Name = "LabelSpecAnalysisExHorizLine";
		oz().Size = new Size(659, 1);
		oz().TabIndex = 341;
		yn().AutoSize = true;
		yn().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		yn().Controls.Add(yr());
		yn().Controls.Add(yo());
		yn().Controls.Add(yp());
		yn().Controls.Add(yq());
		yn().Location = new Point(3, 3);
		yn().Name = "PanelMinMaxTop";
		yn().Size = new Size(604, 27);
		yn().TabIndex = 366;
		yn().Visible = false;
		yr().BackgroundImage = Resources.DropDownImage;
		yr().BackgroundImageLayout = ImageLayout.Center;
		yr().Location = new Point(585, 3);
		yr().Margin = new Padding(0);
		yr().Name = "ButtonGetNFromExtremaSubstrateMat";
		yr().Size = new Size(19, 22);
		yr().TabIndex = 132;
		aei().SetToolTip(yr(), "Choose material from list");
		yr().UseVisualStyleBackColor = true;
		yo().AutoSize = true;
		yo().Location = new Point(257, 6);
		yo().Margin = new Padding(30, 0, 3, 0);
		yo().Name = "LabelSubstrateMaterial";
		yo().Size = new Size(118, 16);
		yo().TabIndex = 2;
		yo().Text = "Substrate material:";
		yp().AutoSize = true;
		yp().Location = new Point(4, 5);
		yp().Name = "CheckBoxCalculateNFromExtrema";
		yp().Size = new Size(172, 20);
		yp().TabIndex = 0;
		yp().Text = "Calculate n from extrema";
		yp().UseVisualStyleBackColor = true;
		yq().BackColor = SystemColors.Window;
		yq().Location = new Point(377, 3);
		yq().Margin = new Padding(3, 3, 0, 3);
		yq().Name = "TextBoxNFromExtremaSubstrateMat";
		yq().ReadOnly = true;
		yq().Size = new Size(208, 22);
		yq().TabIndex = 1;
		agc().Controls.Add(ahb());
		agc().Location = new Point(4, 25);
		agc().Name = "TabPageOptoValues";
		agc().Size = new Size(772, 366);
		agc().TabIndex = 3;
		agc().Text = "Opto Values";
		agc().UseVisualStyleBackColor = true;
		ahb().Anchor = AnchorStyles.None;
		ahb().AutoSize = true;
		ahb().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ahb().ColumnCount = 1;
		ahb().ColumnStyles.Add(new ColumnStyle());
		ahb().Controls.Add(ahc(), 0, 0);
		ahb().Controls.Add(ahd(), 0, 1);
		ahb().Location = new Point(137, 28);
		ahb().Name = "TLPOptoValues";
		ahb().RowCount = 2;
		ahb().RowStyles.Add(new RowStyle());
		ahb().RowStyles.Add(new RowStyle());
		ahb().Size = new Size(498, 319);
		ahb().TabIndex = 6;
		ahc().AutoSize = true;
		ahc().Controls.Add(age());
		ahc().Controls.Add(agn());
		ahc().Location = new Point(3, 3);
		ahc().Name = "PanelFPDip";
		ahc().Size = new Size(492, 175);
		ahc().TabIndex = 4;
		age().AutoSize = true;
		age().Location = new Point(16, 0);
		age().Name = "CheckBoxFPDip";
		age().Size = new Size(118, 20);
		age().TabIndex = 0;
		age().Text = "Fabry-Perot Dip";
		age().UseVisualStyleBackColor = true;
		agn().AutoSize = true;
		agn().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		agn().Controls.Add(aha());
		agn().Enabled = false;
		agn().Font = new Font("Arial", 6f, FontStyle.Regular, GraphicsUnit.Point, 0);
		agn().Location = new Point(3, 3);
		agn().Name = "GroupBoxFPDip";
		agn().Size = new Size(486, 169);
		agn().TabIndex = 2;
		agn().TabStop = false;
		aha().AutoSize = true;
		aha().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		aha().ColumnCount = 1;
		aha().ColumnStyles.Add(new ColumnStyle());
		aha().Controls.Add(agy(), 0, 2);
		aha().Controls.Add(ago(), 0, 0);
		aha().Controls.Add(agj(), 0, 1);
		aha().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aha().Location = new Point(13, 21);
		aha().Margin = new Padding(3, 3, 10, 3);
		aha().Name = "TLPFPDip";
		aha().RowCount = 3;
		aha().RowStyles.Add(new RowStyle());
		aha().RowStyles.Add(new RowStyle());
		aha().RowStyles.Add(new RowStyle());
		aha().Size = new Size(460, 132);
		aha().TabIndex = 4;
		agy().AutoSize = true;
		agy().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		agy().ColumnCount = 5;
		agy().ColumnStyles.Add(new ColumnStyle());
		agy().ColumnStyles.Add(new ColumnStyle());
		agy().ColumnStyles.Add(new ColumnStyle());
		agy().ColumnStyles.Add(new ColumnStyle());
		agy().ColumnStyles.Add(new ColumnStyle());
		agy().Controls.Add(ags(), 4, 0);
		agy().Controls.Add(agw(), 0, 0);
		agy().Controls.Add(agt(), 3, 0);
		agy().Controls.Add(agv(), 1, 0);
		agy().Controls.Add(agu(), 2, 0);
		agy().Location = new Point(3, 101);
		agy().Name = "TLPFPDipWaveLimits";
		agy().RowCount = 1;
		agy().RowStyles.Add(new RowStyle());
		agy().Size = new Size(373, 28);
		agy().TabIndex = 3;
		ags().Anchor = AnchorStyles.None;
		ags().AutoSize = true;
		ags().Location = new Point(344, 6);
		ags().Name = "LabelFPWaveUnits2";
		ags().Size = new Size(26, 16);
		ags().TabIndex = 7;
		ags().Text = "nm";
		agw().Anchor = AnchorStyles.None;
		agw().AutoSize = true;
		agw().Location = new Point(3, 4);
		agw().Name = "RadioButtonFPDipWavelenLimited";
		agw().Size = new Size(174, 20);
		agw().TabIndex = 3;
		agw().TabStop = true;
		agw().Text = "Locate minimum between";
		agw().UseVisualStyleBackColor = true;
		agt().Anchor = AnchorStyles.None;
		agt().Enabled = false;
		agt().f(A_0: false);
		agt().Location = new Point(292, 3);
		agt().Name = "TextBoxNumFPWaveMax";
		agt().e(A_0: false);
		agt().Size = new Size(46, 22);
		agt().TabIndex = 4;
		agt().TextAlign = HorizontalAlignment.Center;
		agv().Anchor = AnchorStyles.None;
		agv().Enabled = false;
		agv().f(A_0: false);
		agv().Location = new Point(183, 3);
		agv().Name = "TextBoxNumFPWaveMin";
		agv().e(A_0: false);
		agv().Size = new Size(46, 22);
		agv().TabIndex = 3;
		agv().TextAlign = HorizontalAlignment.Center;
		agu().Anchor = AnchorStyles.None;
		agu().AutoSize = true;
		agu().Location = new Point(235, 6);
		agu().Name = "LabelFPWaveUnits1";
		agu().Size = new Size(51, 16);
		agu().TabIndex = 6;
		agu().Text = "nm and";
		ago().AutoSize = true;
		ago().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ago().ColumnCount = 3;
		ago().ColumnStyles.Add(new ColumnStyle());
		ago().ColumnStyles.Add(new ColumnStyle());
		ago().ColumnStyles.Add(new ColumnStyle());
		ago().Controls.Add(agp(), 2, 0);
		ago().Controls.Add(agq(), 0, 0);
		ago().Controls.Add(agr(), 1, 0);
		ago().Location = new Point(3, 3);
		ago().Name = "TLPFPDipRefl1";
		ago().RowCount = 1;
		ago().RowStyles.Add(new RowStyle());
		ago().Size = new Size(454, 28);
		ago().TabIndex = 1;
		agp().Anchor = AnchorStyles.None;
		agp().AutoSize = true;
		agp().Location = new Point(355, 6);
		agp().Name = "LabelFPRUnits";
		agp().Size = new Size(96, 16);
		agp().TabIndex = 3;
		agp().Text = "% and greatest";
		agq().Anchor = AnchorStyles.None;
		agq().AutoSize = true;
		agq().Location = new Point(3, 4);
		agq().Name = "RadioButtonFPDipReflectanceLimited";
		agq().Size = new Size(294, 20);
		agq().TabIndex = 0;
		agq().TabStop = true;
		agq().Text = "Locate minimum between lowest wavelength >";
		agq().UseVisualStyleBackColor = true;
		agr().Anchor = AnchorStyles.None;
		agr().Enabled = false;
		agr().f(A_0: false);
		agr().Location = new Point(303, 3);
		agr().Name = "TextBoxNumFPRLowThreshold";
		agr().e(A_0: false);
		agr().Size = new Size(46, 22);
		agr().TabIndex = 1;
		agr().TextAlign = HorizontalAlignment.Center;
		agj().AutoSize = true;
		agj().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		agj().ColumnCount = 5;
		agj().ColumnStyles.Add(new ColumnStyle());
		agj().ColumnStyles.Add(new ColumnStyle());
		agj().ColumnStyles.Add(new ColumnStyle());
		agj().ColumnStyles.Add(new ColumnStyle());
		agj().ColumnStyles.Add(new ColumnStyle());
		agj().Controls.Add(agx(), 4, 0);
		agj().Controls.Add(agf(), 3, 0);
		agj().Controls.Add(agk(), 2, 0);
		agj().Controls.Add(agl(), 1, 0);
		agj().Controls.Add(agm(), 0, 0);
		agj().Location = new Point(3, 37);
		agj().Name = "TLPFPDipRefl2";
		agj().RowCount = 1;
		agj().RowStyles.Add(new RowStyle());
		agj().Size = new Size(445, 58);
		agj().TabIndex = 3;
		agx().Anchor = AnchorStyles.None;
		agx().AutoSize = true;
		agx().Location = new Point(374, 21);
		agx().Name = "LabelFPREnding";
		agx().Size = new Size(68, 16);
		agx().TabIndex = 6;
		agx().Text = "reflectivity.";
		agf().Anchor = AnchorStyles.None;
		agf().AutoSize = true;
		agf().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		agf().Controls.Add(agg());
		agf().Font = new Font("Arial", 6f, FontStyle.Regular, GraphicsUnit.Point, 0);
		agf().Location = new Point(184, 3);
		agf().Margin = new Padding(3, 3, 3, 6);
		agf().Name = "GroupBoxFPRType";
		agf().Padding = new Padding(3, 3, 3, 0);
		agf().Size = new Size(184, 49);
		agf().TabIndex = 4;
		agf().TabStop = false;
		agg().AutoSize = true;
		agg().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		agg().ColumnCount = 2;
		agg().ColumnStyles.Add(new ColumnStyle());
		agg().ColumnStyles.Add(new ColumnStyle());
		agg().Controls.Add(agh(), 1, 0);
		agg().Controls.Add(agi(), 0, 0);
		agg().Location = new Point(6, 13);
		agg().Margin = new Padding(3, 3, 3, 0);
		agg().Name = "TLPFPRType";
		agg().RowCount = 1;
		agg().RowStyles.Add(new RowStyle());
		agg().Size = new Size(172, 26);
		agg().TabIndex = 5;
		agh().Anchor = AnchorStyles.None;
		agh().AutoSize = true;
		agh().Enabled = false;
		agh().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		agh().Location = new Point(86, 3);
		agh().Name = "RadioButtonFPRRelative";
		agh().Size = new Size(83, 20);
		agh().TabIndex = 7;
		agh().TabStop = true;
		agh().Text = "Maximum";
		agh().UseVisualStyleBackColor = true;
		agi().Anchor = AnchorStyles.None;
		agi().AutoSize = true;
		agi().Enabled = false;
		agi().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		agi().Location = new Point(3, 3);
		agi().Name = "RadioButtonFPRAbsolute";
		agi().Size = new Size(77, 20);
		agi().TabIndex = 6;
		agi().TabStop = true;
		agi().Text = "Absolute";
		agi().UseVisualStyleBackColor = true;
		agk().Anchor = AnchorStyles.None;
		agk().AutoSize = true;
		agk().Location = new Point(144, 21);
		agk().Name = "LabelFPRHighUnits";
		agk().Size = new Size(34, 16);
		agk().TabIndex = 5;
		agk().Text = "% of";
		agl().Anchor = AnchorStyles.None;
		agl().Enabled = false;
		agl().f(A_0: false);
		agl().Location = new Point(92, 18);
		agl().Name = "TextBoxNumFPRHighThreshold";
		agl().e(A_0: false);
		agl().Size = new Size(46, 22);
		agl().TabIndex = 4;
		agl().TextAlign = HorizontalAlignment.Center;
		agm().Anchor = AnchorStyles.None;
		agm().AutoSize = true;
		agm().Location = new Point(3, 21);
		agm().Name = "LabelFPRHighPrefix";
		agm().Size = new Size(83, 16);
		agm().TabIndex = 4;
		agm().Text = "wavelength >";
		ahd().AutoSize = true;
		ahd().Controls.Add(agd());
		ahd().Controls.Add(agz());
		ahd().Location = new Point(3, 184);
		ahd().Name = "PanelDBRCenter";
		ahd().Size = new Size(412, 132);
		ahd().TabIndex = 5;
		agd().AutoSize = true;
		agd().Location = new Point(16, 7);
		agd().Name = "CheckBoxDBRCenter";
		agd().Size = new Size(165, 20);
		agd().TabIndex = 1;
		agd().Text = "Reflectivity Band Center";
		agd().UseVisualStyleBackColor = true;
		agz().AutoSize = true;
		agz().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		agz().Controls.Add(ag0());
		agz().Enabled = false;
		agz().Font = new Font("Arial", 6f, FontStyle.Regular, GraphicsUnit.Point, 0);
		agz().Location = new Point(3, 11);
		agz().Name = "GroupBoxDBRCenter";
		agz().Size = new Size(406, 118);
		agz().TabIndex = 3;
		agz().TabStop = false;
		ag0().AutoSize = true;
		ag0().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ag0().ColumnCount = 1;
		ag0().ColumnStyles.Add(new ColumnStyle());
		ag0().Controls.Add(ag1(), 0, 0);
		ag0().Controls.Add(ag2(), 0, 1);
		ag0().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ag0().Location = new Point(13, 22);
		ag0().Name = "TLPDBRCenter";
		ag0().RowCount = 2;
		ag0().RowStyles.Add(new RowStyle());
		ag0().RowStyles.Add(new RowStyle());
		ag0().Size = new Size(387, 80);
		ag0().TabIndex = 9;
		ag1().Anchor = AnchorStyles.None;
		ag1().AutoSize = true;
		ag1().Location = new Point(3, 0);
		ag1().Name = "LabelDBRPreamble";
		ag1().Size = new Size(381, 16);
		ag1().TabIndex = 8;
		ag1().Text = "Define mirror limits as first dips on either side of maximum below";
		ag2().AutoSize = true;
		ag2().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ag2().ColumnCount = 4;
		ag2().ColumnStyles.Add(new ColumnStyle());
		ag2().ColumnStyles.Add(new ColumnStyle());
		ag2().ColumnStyles.Add(new ColumnStyle());
		ag2().ColumnStyles.Add(new ColumnStyle());
		ag2().Controls.Add(ag9(), 2, 0);
		ag2().Controls.Add(ag3(), 3, 0);
		ag2().Controls.Add(ag4(), 1, 0);
		ag2().Controls.Add(ag5(), 0, 0);
		ag2().Location = new Point(3, 19);
		ag2().Name = "TLPDBRCenterParams";
		ag2().RowCount = 1;
		ag2().RowStyles.Add(new RowStyle());
		ag2().Size = new Size(358, 58);
		ag2().TabIndex = 0;
		ag9().AutoSize = true;
		ag9().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ag9().Controls.Add(ag6());
		ag9().Font = new Font("Arial", 6f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ag9().Location = new Point(95, 3);
		ag9().Margin = new Padding(3, 3, 3, 6);
		ag9().Name = "GroupBoxDBRLimitsType";
		ag9().Padding = new Padding(3, 3, 3, 0);
		ag9().Size = new Size(184, 49);
		ag9().TabIndex = 8;
		ag9().TabStop = false;
		ag6().AutoSize = true;
		ag6().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ag6().ColumnCount = 2;
		ag6().ColumnStyles.Add(new ColumnStyle());
		ag6().ColumnStyles.Add(new ColumnStyle());
		ag6().Controls.Add(ag7(), 1, 0);
		ag6().Controls.Add(ag8(), 0, 0);
		ag6().Location = new Point(6, 13);
		ag6().Margin = new Padding(3, 3, 3, 0);
		ag6().Name = "TLPDBRThreshType";
		ag6().RowCount = 1;
		ag6().RowStyles.Add(new RowStyle());
		ag6().Size = new Size(172, 26);
		ag6().TabIndex = 6;
		ag7().Anchor = AnchorStyles.None;
		ag7().AutoSize = true;
		ag7().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ag7().Location = new Point(86, 3);
		ag7().Name = "RadioButtonDBRThreshRelative";
		ag7().Size = new Size(83, 20);
		ag7().TabIndex = 7;
		ag7().TabStop = true;
		ag7().Text = "Maximum";
		ag7().UseVisualStyleBackColor = true;
		ag8().Anchor = AnchorStyles.None;
		ag8().AutoSize = true;
		ag8().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ag8().Location = new Point(3, 3);
		ag8().Name = "RadioButtonDBRThreshAbs";
		ag8().Size = new Size(77, 20);
		ag8().TabIndex = 6;
		ag8().TabStop = true;
		ag8().Text = "Absolute";
		ag8().UseVisualStyleBackColor = true;
		ag3().Anchor = AnchorStyles.None;
		ag3().AutoSize = true;
		ag3().Location = new Point(285, 21);
		ag3().Name = "LabelDBREnding";
		ag3().Size = new Size(70, 16);
		ag3().TabIndex = 7;
		ag3().Text = "Reflectivity";
		ag4().Anchor = AnchorStyles.None;
		ag4().AutoSize = true;
		ag4().Location = new Point(55, 21);
		ag4().Name = "LabelDBRThreshUnits";
		ag4().Size = new Size(34, 16);
		ag4().TabIndex = 6;
		ag4().Text = "% of";
		ag5().Anchor = AnchorStyles.None;
		ag5().f(A_0: false);
		ag5().Location = new Point(3, 18);
		ag5().Name = "TextBoxNumDBRThreshold";
		ag5().e(A_0: false);
		ag5().Size = new Size(46, 22);
		ag5().TabIndex = 4;
		ag5().TextAlign = HorizontalAlignment.Center;
		o0().Controls.Add(zv());
		o0().Controls.Add(o1());
		o0().Location = new Point(4, 25);
		o0().Name = "TabPagePreprocessing";
		o0().Padding = new Padding(3);
		o0().Size = new Size(772, 366);
		o0().TabIndex = 2;
		o0().Text = "Spectrum Preprocessing";
		o0().UseVisualStyleBackColor = true;
		zv().Controls.Add(zw());
		zv().Controls.Add(zx());
		zv().Controls.Add(zy());
		zv().Controls.Add(zz());
		zv().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		zv().Location = new Point(241, 90);
		zv().Name = "GroupBoxSmoothingPoints";
		zv().Size = new Size(226, 94);
		zv().TabIndex = 23;
		zv().TabStop = false;
		zv().Text = "Spectrum Smoothing";
		zw().BorderStyle = BorderStyle.FixedSingle;
		zw().Location = new Point(143, 53);
		zw().Name = "LabelSmoothingPtsTotal";
		zw().Size = new Size(52, 22);
		zw().TabIndex = 29;
		zw().Text = "7";
		zw().TextAlign = ContentAlignment.BottomLeft;
		zx().AutoSize = true;
		zx().Location = new Point(32, 57);
		zx().Name = "Label32";
		zx().Size = new Size(113, 16);
		zx().TabIndex = 28;
		zx().Text = "Full-width (points):";
		zy().AutoSize = true;
		zy().Location = new Point(27, 31);
		zy().Name = "Label50";
		zy().Size = new Size(116, 16);
		zy().TabIndex = 26;
		zy().Text = "Half-width (points):";
		zz().f(A_0: true);
		zz().Location = new Point(143, 28);
		zz().Name = "TextBoxNumericSmoothPtsHalfWid";
		zz().e(A_0: false);
		zz().Size = new Size(52, 22);
		zz().TabIndex = 25;
		o1().Controls.Add(o2());
		o1().Controls.Add(o3());
		o1().Controls.Add(o4());
		o1().Controls.Add(o5());
		o1().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		o1().Location = new Point(241, 121);
		o1().Name = "GroupBoxSpecAnalysisSpecPreprocess";
		o1().Size = new Size(226, 77);
		o1().TabIndex = 22;
		o1().TabStop = false;
		o1().Text = "Spectrum Preprocessing";
		o2().AutoSize = true;
		o2().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		o2().Location = new Point(9, 23);
		o2().Name = "LabelMeasSpecSmoothingLabel";
		o2().Size = new Size(199, 16);
		o2().TabIndex = 41;
		o2().Text = "Measured Spectrum Smoothing:";
		o2().TextAlign = ContentAlignment.MiddleRight;
		o3().AutoSize = true;
		o3().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		o3().Location = new Point(196, 47);
		o3().Name = "LabelSpecAnalysisSmoothingUnits";
		o3().Size = new Size(26, 16);
		o3().TabIndex = 39;
		o3().Text = "nm";
		o3().TextAlign = ContentAlignment.MiddleLeft;
		o4().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		o4().f(A_0: false);
		o4().Location = new Point(123, 44);
		o4().Name = "TextBoxSpecAnalysisSmoothing";
		o4().e(A_0: false);
		o4().Size = new Size(72, 22);
		o4().TabIndex = 40;
		o4().TextAlign = HorizontalAlignment.Right;
		o5().AutoSize = true;
		o5().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		o5().Location = new Point(3, 47);
		o5().Name = "LabelSmoothing";
		o5().Size = new Size(118, 16);
		o5().TabIndex = 38;
		o5().Text = "Optical Thickness:";
		o5().TextAlign = ContentAlignment.MiddleRight;
		o6().Image = global::d.th();
		o6().Location = new Point(691, 7);
		o6().Name = "ButtonDeleteGoldenCurve";
		o6().Size = new Size(24, 23);
		o6().TabIndex = 323;
		o6().UseVisualStyleBackColor = true;
		o7().AutoSize = true;
		o7().Location = new Point(212, 10);
		o7().Name = "LabelControlSpecLabel";
		o7().Size = new Size(107, 16);
		o7().TabIndex = 325;
		o7().Text = "Target Spectrum:";
		o8().BackColor = SystemColors.ButtonHighlight;
		o8().BorderStyle = BorderStyle.Fixed3D;
		o8().Location = new Point(325, 10);
		o8().Name = "LabelControlSpec";
		o8().Size = new Size(331, 20);
		o8().TabIndex = 321;
		o8().Text = "testaejgqasdf";
		o9().Image = Resources.DropDownImage;
		o9().Location = new Point(661, 7);
		o9().Name = "ButtonSelectTargetSpec";
		o9().Size = new Size(24, 23);
		o9().TabIndex = 322;
		o9().UseVisualStyleBackColor = true;
		d2().AutoScroll = true;
		d2().Controls.Add(pw());
		d2().Location = new Point(4, 25);
		d2().Name = "TabPageAcqSettings";
		d2().Size = new Size(779, 464);
		d2().TabIndex = 4;
		d2().Text = "Acquisition Settings";
		d2().UseVisualStyleBackColor = true;
		pw().AutoSize = true;
		pw().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		pw().Controls.Add(we());
		pw().Location = new Point(6, 3);
		pw().Name = "PanelAcqSettings";
		pw().Size = new Size(709, 759);
		pw().TabIndex = 74;
		we().AutoSize = true;
		we().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		we().ColumnCount = 1;
		we().ColumnStyles.Add(new ColumnStyle());
		we().Controls.Add(wj(), 0, 1);
		we().Controls.Add(wf(), 0, 0);
		we().Location = new Point(0, 0);
		we().Name = "TLPAcqSettings";
		we().RowCount = 2;
		we().RowStyles.Add(new RowStyle());
		we().RowStyles.Add(new RowStyle());
		we().Size = new Size(706, 756);
		we().TabIndex = 0;
		wj().AutoSize = true;
		wj().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		wj().ColumnCount = 2;
		wj().ColumnStyles.Add(new ColumnStyle());
		wj().ColumnStyles.Add(new ColumnStyle());
		wj().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
		wj().Controls.Add(yz(), 1, 0);
		wj().Controls.Add(w1(), 0, 0);
		wj().Location = new Point(3, 44);
		wj().Name = "TLPAcqTypeSubselect";
		wj().RowCount = 2;
		wj().RowStyles.Add(new RowStyle());
		wj().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		wj().Size = new Size(700, 709);
		wj().TabIndex = 75;
		yz().AutoSize = true;
		yz().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		yz().ColumnCount = 1;
		yz().ColumnStyles.Add(new ColumnStyle());
		yz().Controls.Add(x7(), 0, 1);
		yz().Controls.Add(wk(), 0, 4);
		yz().Controls.Add(zm(), 0, 3);
		yz().Controls.Add(ey(), 0, 0);
		yz().Controls.Add(wi(), 0, 2);
		yz().Dock = DockStyle.Fill;
		yz().Location = new Point(380, 3);
		yz().Name = "TLPAcqInputDetails";
		yz().RowCount = 5;
		yz().RowStyles.Add(new RowStyle());
		yz().RowStyles.Add(new RowStyle());
		yz().RowStyles.Add(new RowStyle());
		yz().RowStyles.Add(new RowStyle());
		yz().RowStyles.Add(new RowStyle());
		yz().Size = new Size(317, 683);
		yz().TabIndex = 75;
		x7().AutoSize = true;
		x7().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		x7().Controls.Add(x8());
		x7().Controls.Add(x9());
		x7().Dock = DockStyle.Fill;
		x7().Location = new Point(3, 170);
		x7().Name = "GroupBoxPDGainMode";
		x7().Size = new Size(311, 62);
		x7().TabIndex = 75;
		x7().TabStop = false;
		x7().Text = "Photodiode Gain";
		x7().Visible = false;
		x8().AutoSize = true;
		x8().Location = new Point(145, 21);
		x8().Name = "RadioButtonPDGainManual";
		x8().Size = new Size(68, 20);
		x8().TabIndex = 1;
		x8().TabStop = true;
		x8().Text = "Manual";
		x8().UseVisualStyleBackColor = true;
		x9().AutoSize = true;
		x9().Location = new Point(27, 21);
		x9().Name = "RadioButtonPDGainAuto";
		x9().Size = new Size(85, 20);
		x9().TabIndex = 0;
		x9().TabStop = true;
		x9().Text = "Automatic";
		x9().UseVisualStyleBackColor = true;
		wk().AutoSize = true;
		wk().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		wk().ColumnCount = 2;
		wk().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		wk().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		wk().Controls.Add(ex(), 0, 0);
		wk().Controls.Add(ew(), 1, 0);
		wk().Dock = DockStyle.Fill;
		wk().Location = new Point(3, 625);
		wk().Name = "TLPAcqAdvEtcButtons";
		wk().RowCount = 2;
		wk().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		wk().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		wk().Size = new Size(311, 55);
		wk().TabIndex = 75;
		ex().Anchor = AnchorStyles.None;
		ex().Cursor = Cursors.Default;
		ex().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ex().ForeColor = SystemColors.ControlText;
		ex().Location = new Point(31, 3);
		ex().Name = "ButtonAdvSettings";
		ex().Size = new Size(92, 29);
		ex().TabIndex = 72;
		ex().Text = "Advanced...";
		ew().Anchor = AnchorStyles.None;
		ew().Cursor = Cursors.Default;
		ew().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ew().ForeColor = SystemColors.ControlText;
		ew().Location = new Point(186, 3);
		ew().Name = "ButtonOpticsConfig";
		ew().Size = new Size(93, 29);
		ew().TabIndex = 73;
		ew().Text = "Optics...";
		zm().AutoSize = true;
		zm().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		zm().Controls.Add(ahj());
		zm().Controls.Add(zn());
		zm().Controls.Add(zo());
		zm().Controls.Add(zp());
		zm().Controls.Add(zq());
		zm().Controls.Add(af7());
		zm().Location = new Point(3, 370);
		zm().Name = "GroupBoxFocusSettings";
		zm().Size = new Size(311, 249);
		zm().TabIndex = 77;
		zm().TabStop = false;
		zm().Text = "Focus Settings";
		ahj().Controls.Add(ahk());
		ahj().Controls.Add(ahl());
		ahj().Controls.Add(ahm());
		ahj().Location = new Point(112, 205);
		ahj().Name = "PanelImageFocusOffset";
		ahj().Size = new Size(162, 23);
		ahj().TabIndex = 76;
		ahk().AutoSize = true;
		ahk().Enabled = false;
		ahk().Location = new Point(3, 3);
		ahk().Name = "LabelImageFocusZOffset";
		ahk().Size = new Size(54, 16);
		ahk().TabIndex = 14;
		ahk().Text = "Z offset:";
		ahk().Visible = false;
		ahl().Enabled = false;
		ahl().f(A_0: false);
		ahl().Location = new Point(59, 0);
		ahl().Name = "TextBoxNumericImageFocus";
		ahl().e(A_0: true);
		ahl().Size = new Size(36, 22);
		ahl().TabIndex = 16;
		ahl().Visible = false;
		ahm().AutoSize = true;
		ahm().Enabled = false;
		ahm().Location = new Point(101, 2);
		ahm().Name = "LabelImageFocusZUnit";
		ahm().Size = new Size(38, 16);
		ahm().TabIndex = 18;
		ahm().Text = "(mm)";
		ahm().Visible = false;
		zn().AutoSize = true;
		zn().Enabled = false;
		zn().Location = new Point(10, 205);
		zn().Name = "RadioButtonImageFocus";
		zn().Size = new Size(96, 20);
		zn().TabIndex = 4;
		zn().TabStop = true;
		zn().Text = "Image focus";
		zn().UseVisualStyleBackColor = true;
		zo().AutoSize = true;
		zo().Location = new Point(10, 64);
		zo().Name = "RadioButtonMaxSignal";
		zo().Size = new Size(89, 20);
		zo().TabIndex = 3;
		zo().TabStop = true;
		zo().Text = "Max signal";
		zo().UseVisualStyleBackColor = true;
		zp().AutoSize = true;
		zp().Location = new Point(10, 42);
		zp().Name = "RadioButtonGOF";
		zp().Size = new Size(54, 20);
		zp().TabIndex = 2;
		zp().TabStop = true;
		zp().Text = "GOF";
		zp().UseVisualStyleBackColor = true;
		zq().AutoSize = true;
		zq().BackColor = Color.White;
		zq().Location = new Point(5, 18);
		zq().Margin = new Padding(0);
		zq().Name = "CheckBoxAutoFocusOn";
		zq().Padding = new Padding(8, 3, 3, 3);
		zq().Size = new Size(127, 26);
		zq().TabIndex = 1;
		zq().Text = "Use AutoFocus";
		zq().UseVisualStyleBackColor = false;
		af7().AutoSize = true;
		af7().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		af7().Controls.Add(agb());
		af7().Location = new Point(5, 67);
		af7().Name = "GroupBoxMaxSignal";
		af7().Padding = new Padding(3, 3, 3, 0);
		af7().Size = new Size(300, 137);
		af7().TabIndex = 75;
		af7().TabStop = false;
		agb().AutoSize = true;
		agb().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		agb().ColumnCount = 6;
		agb().ColumnStyles.Add(new ColumnStyle());
		agb().ColumnStyles.Add(new ColumnStyle());
		agb().ColumnStyles.Add(new ColumnStyle());
		agb().ColumnStyles.Add(new ColumnStyle());
		agb().ColumnStyles.Add(new ColumnStyle());
		agb().ColumnStyles.Add(new ColumnStyle());
		agb().Controls.Add(ahe(), 0, 3);
		agb().Controls.Add(aga(), 0, 0);
		agb().Controls.Add(af8(), 2, 0);
		agb().Controls.Add(zr(), 3, 0);
		agb().Controls.Add(af9(), 1, 0);
		agb().Controls.Add(zu(), 3, 1);
		agb().Controls.Add(zt(), 4, 0);
		agb().Controls.Add(zs(), 5, 0);
		agb().Controls.Add(ahf(), 0, 2);
		agb().Controls.Add(ahg(), 2, 3);
		agb().Controls.Add(ahh(), 1, 3);
		agb().Controls.Add(ahi(), 4, 3);
		agb().Location = new Point(3, 22);
		agb().Name = "TableLayoutPanelSampThick";
		agb().RowCount = 4;
		agb().RowStyles.Add(new RowStyle());
		agb().RowStyles.Add(new RowStyle());
		agb().RowStyles.Add(new RowStyle());
		agb().RowStyles.Add(new RowStyle());
		agb().Size = new Size(291, 97);
		agb().TabIndex = 19;
		ahe().Anchor = AnchorStyles.Right;
		ahe().AutoSize = true;
		ahe().Location = new Point(5, 78);
		ahe().Margin = new Padding(0);
		ahe().Name = "LabelRangePct";
		ahe().Size = new Size(69, 16);
		ahe().TabIndex = 76;
		ahe().Text = "Range(%):";
		ahe().Visible = false;
		aga().Anchor = AnchorStyles.Left;
		aga().AutoSize = true;
		aga().Location = new Point(0, 3);
		aga().Margin = new Padding(0);
		aga().Name = "LabelSampThick";
		aga().Size = new Size(74, 16);
		aga().TabIndex = 14;
		aga().Text = "Smp Thick:";
		af8().Anchor = AnchorStyles.Left;
		af8().AutoSize = true;
		af8().Location = new Point(113, 3);
		af8().Margin = new Padding(0, 0, 6, 0);
		af8().Name = "LabelSampThickUnits";
		af8().Size = new Size(38, 16);
		af8().TabIndex = 18;
		af8().Text = "(mm)";
		zr().Anchor = AnchorStyles.Left;
		zr().AutoSize = true;
		zr().Location = new Point(160, 3);
		zr().Margin = new Padding(3, 0, 0, 0);
		zr().Name = "LabelMaxSignalZOffset";
		zr().Size = new Size(54, 16);
		zr().TabIndex = 13;
		zr().Text = "Z offset:";
		af9().Anchor = AnchorStyles.Left;
		af9().f(A_0: false);
		af9().Location = new Point(74, 0);
		af9().Margin = new Padding(0);
		af9().Name = "TextBoxNumericSampleThickness";
		af9().e(A_0: true);
		af9().Size = new Size(39, 22);
		af9().TabIndex = 16;
		ahn().SetToolTip(af9(), "Thickness of sample\r\nFocus Offset Calibration in Setup->Options->Wafer Map must be performed\r\nin order to calibrate the focus height of the stage or sample chuck base.");
		zu().Anchor = AnchorStyles.None;
		zu().AutoSize = true;
		zu().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		agb().SetColumnSpan(zu(), 3);
		zu().Cursor = Cursors.Default;
		zu().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		zu().ForeColor = SystemColors.ControlText;
		zu().Location = new Point(194, 22);
		zu().Margin = new Padding(3, 0, 3, 0);
		zu().Name = "ButtonUpdateMaxSignalZOffset";
		zu().Size = new Size(59, 26);
		zu().TabIndex = 74;
		zu().Text = "Update";
		aeh().SetToolTip(zu(), "Usage:\r\n-Start Acquire->Measure Continuously.\r\n-Use Goto dialog to move focus up and down to maximize GOF.\r\n-Stop Measure Continously.\r\n-Click Update button to automatically update Z Offset.");
		zt().Anchor = AnchorStyles.Left;
		zt().f(A_0: false);
		zt().Location = new Point(214, 0);
		zt().Margin = new Padding(0);
		zt().Name = "TextBoxNumericMaxSignal";
		zt().e(A_0: true);
		zt().Size = new Size(39, 22);
		zt().TabIndex = 15;
		ahn().SetToolTip(zt(), "Focus position offset between maximum signal and measurement spot");
		zs().AutoSize = true;
		zs().Location = new Point(253, 0);
		zs().Margin = new Padding(0);
		zs().Name = "LabelMaxSignalZUnit";
		zs().Size = new Size(38, 16);
		zs().TabIndex = 17;
		zs().Text = "(mm)";
		ahf().Anchor = AnchorStyles.None;
		ahf().AutoSize = true;
		agb().SetColumnSpan(ahf(), 5);
		ahf().Location = new Point(61, 48);
		ahf().Margin = new Padding(0);
		ahf().Name = "LabelReflectiveObjective";
		ahf().Padding = new Padding(3, 8, 3, 3);
		ahf().Size = new Size(130, 27);
		ahf().TabIndex = 75;
		ahf().Text = "Reflective Objective:";
		ahf().Visible = false;
		ahg().Anchor = AnchorStyles.Right;
		ahg().AutoSize = true;
		agb().SetColumnSpan(ahg(), 2);
		ahg().Location = new Point(127, 78);
		ahg().Margin = new Padding(0);
		ahg().Name = "LabelStepSizePct";
		ahg().Size = new Size(87, 16);
		ahg().TabIndex = 77;
		ahg().Text = "Step size(%):";
		ahg().Visible = false;
		ahh().Anchor = AnchorStyles.Left;
		ahh().f(A_0: false);
		ahh().Location = new Point(74, 75);
		ahh().Margin = new Padding(0);
		ahh().Name = "TextBoxNumericReflObjRangePct";
		ahh().e(A_0: false);
		ahh().Size = new Size(39, 22);
		ahh().TabIndex = 78;
		ahh().Visible = false;
		ahi().Anchor = AnchorStyles.Left;
		ahi().f(A_0: false);
		ahi().Location = new Point(214, 75);
		ahi().Margin = new Padding(0);
		ahi().Name = "TextBoxNumericReflObjStepPct";
		ahi().e(A_0: false);
		ahi().Size = new Size(39, 22);
		ahi().TabIndex = 79;
		ahi().Visible = false;
		ey().AutoSize = true;
		ey().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ey().Controls.Add(ez());
		ey().Controls.Add(e0());
		ey().Controls.Add(e1());
		ey().Controls.Add(e2());
		ey().Dock = DockStyle.Fill;
		ey().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ey().Location = new Point(3, 3);
		ey().Name = "GroupBoxSpectrometerType";
		ey().Size = new Size(311, 161);
		ey().TabIndex = 71;
		ey().TabStop = false;
		ey().Text = "Spectrometer Type";
		ez().AutoSize = true;
		ez().Location = new Point(26, 120);
		ez().Name = "RadioButtonBoth";
		ez().Size = new Size(269, 20);
		ez().TabIndex = 14;
		ez().TabStop = true;
		ez().Text = "Extended wavelength range (both specs)";
		ez().UseVisualStyleBackColor = true;
		e0().AutoSize = true;
		e0().Location = new Point(26, 90);
		e0().Name = "RadioButtonLong";
		e0().Size = new Size(215, 20);
		e0().TabIndex = 13;
		e0().TabStop = true;
		e0().Text = "Long wavelength (Spec #2 only)";
		e0().UseVisualStyleBackColor = true;
		e1().AutoSize = true;
		e1().Location = new Point(26, 60);
		e1().Name = "RadioButtonShort";
		e1().Size = new Size(216, 20);
		e1().TabIndex = 2;
		e1().TabStop = true;
		e1().Text = "Short wavelength (Spec #1 only)";
		e1().UseVisualStyleBackColor = true;
		e2().AutoSize = true;
		e2().ForeColor = SystemColors.ControlText;
		e2().Location = new Point(26, 30);
		e2().Name = "RadioButtonAnySpec";
		e2().Size = new Size(131, 20);
		e2().TabIndex = 1;
		e2().TabStop = true;
		e2().Text = "Any spectrometer";
		e2().UseVisualStyleBackColor = true;
		wi().AllowUserToAddRows = false;
		wi().AllowUserToDeleteRows = false;
		wi().AllowUserToResizeColumns = false;
		wi().AllowUserToResizeRows = false;
		wi().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
		wi().AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.False;
		wi().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		wi().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		wi().Columns.AddRange(ya(), yb(), yc(), yd());
		wi().Location = new Point(3, 238);
		wi().MultiSelect = false;
		wi().Name = "DataGridViewPDSettings";
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = SystemColors.Control;
		dataGridViewCellStyle2.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
		wi().RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
		wi().RowHeadersVisible = false;
		wi().ScrollBars = ScrollBars.Vertical;
		wi().Size = new Size(304, 126);
		wi().TabIndex = 5;
		ya().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
		ya().DefaultCellStyle = dataGridViewCellStyle3;
		ya().HeaderText = "Photodiode #";
		ya().Name = "DGVColumnPDName";
		ya().ReadOnly = true;
		ya().Resizable = DataGridViewTriState.False;
		ya().SortMode = DataGridViewColumnSortMode.NotSortable;
		yb().AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
		dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
		yb().DefaultCellStyle = dataGridViewCellStyle4;
		yb().HeaderText = "Wavelength (nm)";
		yb().Name = "DGVColumnPDWavelength";
		yb().Resizable = DataGridViewTriState.False;
		yb().SortMode = DataGridViewColumnSortMode.NotSortable;
		yb().Width = 111;
		yc().AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
		yc().HeaderText = "Active";
		yc().Name = "DGVColumnPDActive";
		yc().Resizable = DataGridViewTriState.False;
		yc().Width = 49;
		yd().AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
		yd().HeaderText = "Gain";
		yd().Name = "DGVColumnPDManualGain";
		yd().Resizable = DataGridViewTriState.False;
		yd().SortMode = DataGridViewColumnSortMode.NotSortable;
		yd().Width = 41;
		w1().AutoSize = true;
		w1().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		w1().ColumnCount = 1;
		w1().ColumnStyles.Add(new ColumnStyle());
		w1().Controls.Add(e3(), 0, 0);
		w1().Controls.Add(wl(), 0, 1);
		w1().Location = new Point(3, 3);
		w1().Name = "TableLayoutPanel5";
		w1().RowCount = 2;
		w1().RowStyles.Add(new RowStyle());
		w1().RowStyles.Add(new RowStyle());
		w1().Size = new Size(371, 495);
		w1().TabIndex = 76;
		e3().Controls.Add(e4());
		e3().Controls.Add(e5());
		e3().Controls.Add(e6());
		e3().Controls.Add(fa());
		e3().Controls.Add(fb());
		e3().Controls.Add(ft());
		e3().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e3().Location = new Point(3, 3);
		e3().Name = "GroupBoxMeasurementTiming";
		e3().Size = new Size(365, 313);
		e3().TabIndex = 70;
		e3().TabStop = false;
		e3().Text = "Measurement Timing";
		e4().AutoSize = true;
		e4().ForeColor = SystemColors.InfoText;
		e4().Location = new Point(26, 180);
		e4().Name = "RadioButtonFixedIntTime";
		e4().Size = new Size(201, 20);
		e4().TabIndex = 4;
		e4().TabStop = true;
		e4().Text = "Use manually set parameters";
		e4().UseVisualStyleBackColor = true;
		e5().AutoSize = true;
		e5().ForeColor = SystemColors.InfoText;
		e5().Location = new Point(25, 31);
		e5().Name = "RadioButtonRecommendedTime";
		e5().Size = new Size(228, 20);
		e5().TabIndex = 1;
		e5().TabStop = true;
		e5().Text = "Use recommended sampling time";
		e5().UseVisualStyleBackColor = true;
		e6().Controls.Add(e7());
		e6().Controls.Add(e8());
		e6().Controls.Add(e9());
		e6().Location = new Point(15, 32);
		e6().Name = "GroupBoxRecommended";
		e6().Size = new Size(327, 63);
		e6().TabIndex = 10;
		e6().TabStop = false;
		e7().AutoSize = true;
		e7().Location = new Point(284, 31);
		e7().Name = "Label33";
		e7().Size = new Size(34, 16);
		e7().TabIndex = 3;
		e7().Text = "(ms)";
		e8().AutoSize = true;
		e8().Location = new Point(8, 31);
		e8().Name = "Label34";
		e8().Size = new Size(191, 16);
		e8().TabIndex = 1;
		e8().Text = "Recommended sampling time:";
		e9().BackColor = SystemColors.Window;
		e9().BorderStyle = BorderStyle.FixedSingle;
		e9().Location = new Point(211, 29);
		e9().Name = "LabelRecommendedTime";
		e9().Size = new Size(72, 20);
		e9().TabIndex = 150;
		fa().AutoSize = true;
		fa().ForeColor = SystemColors.InfoText;
		fa().Location = new Point(26, 107);
		fa().Name = "RadioButtonMaxSamplingTime";
		fa().Size = new Size(197, 20);
		fa().TabIndex = 2;
		fa().TabStop = true;
		fa().Text = "Use maximum sampling time";
		fa().UseVisualStyleBackColor = true;
		fb().Controls.Add(fc());
		fb().Controls.Add(fr());
		fb().Controls.Add(fs());
		fb().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		fb().Location = new Point(14, 109);
		fb().Name = "GroupBoxMaxSampleTime";
		fb().Size = new Size(328, 57);
		fb().TabIndex = 2;
		fb().TabStop = false;
		fc().f(A_0: false);
		fc().Location = new Point(198, 25);
		fc().Name = "TextBoxMaxSamplingTime";
		fc().e(A_0: false);
		fc().Size = new Size(63, 22);
		fc().TabIndex = 3;
		fr().AutoSize = true;
		fr().Location = new Point(263, 27);
		fr().Name = "Label35";
		fr().Size = new Size(34, 16);
		fr().TabIndex = 2;
		fr().Text = "(ms)";
		fs().AutoSize = true;
		fs().Location = new Point(27, 28);
		fs().Name = "Label36";
		fs().Size = new Size(157, 16);
		fs().TabIndex = 1;
		fs().Text = "Maximum sampling time: ";
		ft().Controls.Add(fu());
		ft().Controls.Add(fv());
		ft().Controls.Add(fw());
		ft().Controls.Add(fz());
		ft().Controls.Add(f6());
		ft().Controls.Add(f7());
		ft().Controls.Add(f8());
		ft().Controls.Add(f9());
		ft().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ft().Location = new Point(15, 182);
		ft().Name = "GroupBoxFixedIntTime";
		ft().Size = new Size(327, 116);
		ft().TabIndex = 4;
		ft().TabStop = false;
		fu().AutoSize = true;
		fu().Location = new Point(257, 29);
		fu().Name = "LabelLong";
		fu().Size = new Size(38, 16);
		fu().TabIndex = 13;
		fu().Text = "Long";
		fu().Visible = false;
		fv().AutoSize = true;
		fv().Location = new Point(176, 29);
		fv().Name = "LabelShort";
		fv().Size = new Size(39, 16);
		fv().TabIndex = 12;
		fv().Text = "Short";
		fw().AutoSize = true;
		fw().Location = new Point(17, 84);
		fw().Name = "Label37";
		fw().Size = new Size(125, 16);
		fw().TabIndex = 11;
		fw().Text = "# Integration cycles:";
		fz().f(A_0: true);
		fz().Location = new Point(242, 81);
		fz().Name = "TextBoxNumSpectraLong";
		fz().e(A_0: false);
		fz().Size = new Size(68, 22);
		fz().TabIndex = 8;
		fz().Visible = false;
		f6().f(A_0: true);
		f6().Location = new Point(161, 81);
		f6().Name = "TextBoxNumSpectraShort";
		f6().e(A_0: false);
		f6().Size = new Size(68, 22);
		f6().TabIndex = 7;
		f7().f(A_0: false);
		f7().Location = new Point(242, 48);
		f7().Name = "TextBoxIntTimeLong";
		f7().e(A_0: false);
		f7().Size = new Size(68, 22);
		f7().TabIndex = 6;
		f7().Visible = false;
		f8().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f8().f(A_0: false);
		f8().Location = new Point(161, 48);
		f8().Name = "TextBoxIntTimeShort";
		f8().e(A_0: false);
		f8().Size = new Size(68, 22);
		f8().TabIndex = 5;
		f9().AutoSize = true;
		f9().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f9().Location = new Point(17, 51);
		f9().Name = "LabelIntegrationTime";
		f9().Size = new Size(130, 16);
		f9().TabIndex = 5;
		f9().Text = "Integration time (ms):";
		wl().Controls.Add(wm());
		wl().Controls.Add(wn());
		wl().Controls.Add(wu());
		wl().Controls.Add(wv());
		wl().Controls.Add(w0());
		wl().Location = new Point(3, 322);
		wl().Name = "GroupBoxPDSettings";
		wl().Size = new Size(298, 170);
		wl().TabIndex = 75;
		wl().TabStop = false;
		wl().Text = "Photodiode Data Processing";
		wm().AutoSize = true;
		wm().Location = new Point(33, 52);
		wm().Name = "CheckBoxPDMultiWafer";
		wm().Size = new Size(225, 20);
		wm().TabIndex = 7;
		wm().Text = "Use Multiwafer/Wobble Algorigthm";
		wm().UseVisualStyleBackColor = true;
		wn().Controls.Add(wo());
		wn().Controls.Add(wp());
		wn().Controls.Add(wq());
		wn().Controls.Add(wr());
		wn().Controls.Add(ws());
		wn().Location = new Point(24, 55);
		wn().Name = "GroupBox3";
		wn().Size = new Size(252, 91);
		wn().TabIndex = 8;
		wn().TabStop = false;
		wo().Enabled = false;
		wo().f(A_0: true);
		wo().Location = new Point(113, 56);
		wo().Name = "TextBoxNumPDNumWafers";
		wo().e(A_0: false);
		wo().Size = new Size(63, 22);
		wo().TabIndex = 11;
		wp().AutoSize = true;
		wp().Location = new Point(43, 59);
		wp().Name = "Label18";
		wp().Size = new Size(64, 16);
		wp().TabIndex = 10;
		wp().Text = "# wafers: ";
		wq().AutoSize = true;
		wq().Location = new Point(182, 25);
		wq().Name = "Label16";
		wq().Size = new Size(38, 16);
		wq().TabIndex = 9;
		wq().Text = "(rpm)";
		wr().Enabled = false;
		wr().f(A_0: false);
		wr().Location = new Point(113, 22);
		wr().Name = "TextBoxNumPDRotationSpeed";
		wr().e(A_0: false);
		wr().Size = new Size(63, 22);
		wr().TabIndex = 8;
		ws().AutoSize = true;
		ws().Location = new Point(6, 25);
		ws().Name = "Label15";
		ws().Size = new Size(105, 16);
		ws().TabIndex = 7;
		ws().Text = "Rotation Speed: ";
		wu().f(A_0: false);
		wu().Location = new Point(130, 21);
		wu().Name = "TextBoxNumPDSamplingTime";
		wu().e(A_0: false);
		wu().Size = new Size(63, 22);
		wu().TabIndex = 6;
		wv().AutoSize = true;
		wv().Location = new Point(195, 23);
		wv().Name = "Label13";
		wv().Size = new Size(23, 16);
		wv().TabIndex = 5;
		wv().Text = "(s)";
		w0().AutoSize = true;
		w0().Location = new Point(29, 24);
		w0().Name = "Label14";
		w0().Size = new Size(99, 16);
		w0().TabIndex = 4;
		w0().Text = "Sampling time: ";
		wf().Anchor = AnchorStyles.None;
		wf().AutoSize = true;
		wf().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		wf().ColumnCount = 2;
		wf().ColumnStyles.Add(new ColumnStyle());
		wf().ColumnStyles.Add(new ColumnStyle());
		wf().Controls.Add(wg(), 1, 0);
		wf().Controls.Add(wh(), 0, 0);
		wf().Location = new Point(234, 3);
		wf().Name = "TLPAcqInputMode";
		wf().RowCount = 1;
		wf().RowStyles.Add(new RowStyle());
		wf().Size = new Size(238, 35);
		wf().TabIndex = 75;
		wf().Visible = false;
		wg().Anchor = AnchorStyles.Left;
		wg().DropDownStyle = ComboBoxStyle.DropDownList;
		wg().FormattingEnabled = true;
		wg().Items.AddRange(new object[2] { "Spectrometer", "Photodiode" });
		wg().Location = new Point(85, 3);
		wg().Margin = new Padding(3, 3, 3, 8);
		wg().Name = "ComboBoxAcqInput";
		wg().Size = new Size(150, 24);
		wg().TabIndex = 77;
		wh().Anchor = AnchorStyles.Right;
		wh().AutoSize = true;
		wh().Location = new Point(3, 9);
		wh().Name = "LabelAcqInput";
		wh().Size = new Size(76, 16);
		wh().TabIndex = 76;
		wh().Text = "Input Mode:";
		ev().Controls.Add(px());
		ev().Location = new Point(4, 25);
		ev().Name = "TabPageDMAcqSettings";
		ev().Size = new Size(779, 464);
		ev().TabIndex = 5;
		ev().Text = "Acquisition Settings";
		ev().UseVisualStyleBackColor = true;
		px().AutoSize = true;
		px().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		px().Controls.Add(g6());
		px().Controls.Add(ga());
		px().Controls.Add(g3());
		px().Controls.Add(gb());
		px().Controls.Add(ge());
		px().Location = new Point(3, 3);
		px().Name = "PanelDMAcqSettings";
		px().Size = new Size(716, 412);
		px().TabIndex = 74;
		g6().Controls.Add(hc());
		g6().Controls.Add(hd());
		g6().Controls.Add(he());
		g6().Controls.Add(hk());
		g6().Controls.Add(hq());
		g6().Controls.Add(hu());
		g6().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		g6().Location = new Point(3, 3);
		g6().Name = "GroupBoxDMMeasurementTiming";
		g6().Size = new Size(365, 369);
		g6().TabIndex = 69;
		g6().TabStop = false;
		g6().Text = "Measurement Timing";
		hc().AutoSize = true;
		hc().ForeColor = SystemColors.InfoText;
		hc().Location = new Point(26, 180);
		hc().Name = "RadioButtonDMFixedIntTime";
		hc().Size = new Size(201, 20);
		hc().TabIndex = 4;
		hc().TabStop = true;
		hc().Text = "Use manually set parameters";
		hc().UseVisualStyleBackColor = true;
		hd().AutoSize = true;
		hd().ForeColor = SystemColors.InfoText;
		hd().Location = new Point(25, 23);
		hd().Name = "RadioButtonDMRecommendedTime";
		hd().Size = new Size(228, 20);
		hd().TabIndex = 1;
		hd().TabStop = true;
		hd().Text = "Use recommended sampling time";
		hd().UseVisualStyleBackColor = true;
		he().Controls.Add(hf());
		he().Controls.Add(hg());
		he().Controls.Add(hh());
		he().Location = new Point(13, 24);
		he().Name = "GroupBoxDMRecommended";
		he().Size = new Size(337, 63);
		he().TabIndex = 10;
		he().TabStop = false;
		hf().AutoSize = true;
		hf().Location = new Point(284, 31);
		hf().Name = "Label39";
		hf().Size = new Size(34, 16);
		hf().TabIndex = 3;
		hf().Text = "(ms)";
		hg().AutoSize = true;
		hg().Location = new Point(8, 31);
		hg().Name = "Label40";
		hg().Size = new Size(191, 16);
		hg().TabIndex = 1;
		hg().Text = "Recommended sampling time:";
		hh().BackColor = SystemColors.Window;
		hh().BorderStyle = BorderStyle.FixedSingle;
		hh().Location = new Point(211, 29);
		hh().Name = "LabelDMRecommendedTime";
		hh().Size = new Size(72, 20);
		hh().TabIndex = 150;
		hk().AutoSize = true;
		hk().ForeColor = SystemColors.InfoText;
		hk().Location = new Point(26, 103);
		hk().Name = "RadioButtonDMMaxSamplingTime";
		hk().Size = new Size(197, 20);
		hk().TabIndex = 2;
		hk().TabStop = true;
		hk().Text = "Use maximum sampling time";
		hk().UseVisualStyleBackColor = true;
		hq().Controls.Add(hr());
		hq().Controls.Add(hs());
		hq().Controls.Add(ht());
		hq().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		hq().Location = new Point(13, 105);
		hq().Name = "GroupBoxDMMaxSampleTime";
		hq().Size = new Size(337, 57);
		hq().TabIndex = 2;
		hq().TabStop = false;
		hr().f(A_0: false);
		hr().Location = new Point(198, 25);
		hr().Name = "TextBoxDMMaxSamplingTime";
		hr().e(A_0: false);
		hr().Size = new Size(63, 22);
		hr().TabIndex = 3;
		hs().AutoSize = true;
		hs().Location = new Point(263, 27);
		hs().Name = "Label41";
		hs().Size = new Size(34, 16);
		hs().TabIndex = 2;
		hs().Text = "(ms)";
		ht().AutoSize = true;
		ht().Location = new Point(27, 28);
		ht().Name = "Label42";
		ht().Size = new Size(157, 16);
		ht().TabIndex = 1;
		ht().Text = "Maximum sampling time: ";
		hu().Controls.Add(hv());
		hu().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		hu().Location = new Point(14, 182);
		hu().Name = "GroupBoxDMFixedIntTime";
		hu().Size = new Size(337, 155);
		hu().TabIndex = 4;
		hu().TabStop = false;
		hv().Controls.Add(hy());
		hv().Controls.Add(ig());
		hv().Controls.Add(ua());
		hv().Location = new Point(10, 23);
		hv().Name = "TabControlDMManualIntTime";
		hv().SelectedIndex = 0;
		hv().Size = new Size(317, 124);
		hv().TabIndex = 14;
		hy().Controls.Add(h8());
		hy().Controls.Add(h9());
		hy().Controls.Add(ia());
		hy().Controls.Add(ib());
		hy().Controls.Add(ic());
		hy().Controls.Add(id());
		hy().Controls.Add(ie());
		hy().Controls.Add(@if());
		hy().Location = new Point(4, 25);
		hy().Name = "TabPageR";
		hy().Padding = new Padding(3);
		hy().Size = new Size(309, 95);
		hy().TabIndex = 0;
		hy().Text = "Reflectance";
		hy().UseVisualStyleBackColor = true;
		h8().AutoSize = true;
		h8().Location = new Point(248, 9);
		h8().Name = "LabelDMRLong";
		h8().Size = new Size(38, 16);
		h8().TabIndex = 21;
		h8().Text = "Long";
		h8().Visible = false;
		h9().AutoSize = true;
		h9().Location = new Point(167, 9);
		h9().Name = "LabelDMRShort";
		h9().Size = new Size(39, 16);
		h9().TabIndex = 20;
		h9().Text = "Short";
		ia().AutoSize = true;
		ia().Location = new Point(8, 64);
		ia().Name = "Label43";
		ia().Size = new Size(125, 16);
		ia().TabIndex = 19;
		ia().Text = "# Integration cycles:";
		ib().f(A_0: true);
		ib().Location = new Point(233, 61);
		ib().Name = "TextBoxDMRNumSpectraLong";
		ib().e(A_0: false);
		ib().Size = new Size(68, 22);
		ib().TabIndex = 18;
		ib().Visible = false;
		ic().f(A_0: true);
		ic().Location = new Point(152, 61);
		ic().Name = "TextBoxDMRNumSpectraShort";
		ic().e(A_0: false);
		ic().Size = new Size(68, 22);
		ic().TabIndex = 17;
		id().f(A_0: false);
		id().Location = new Point(233, 28);
		id().Name = "TextBoxDMRIntTimeLong";
		id().e(A_0: false);
		id().Size = new Size(68, 22);
		id().TabIndex = 16;
		id().Visible = false;
		ie().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ie().f(A_0: false);
		ie().Location = new Point(152, 28);
		ie().Name = "TextBoxDMRIntTimeShort";
		ie().e(A_0: false);
		ie().Size = new Size(68, 22);
		ie().TabIndex = 14;
		@if().AutoSize = true;
		@if().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		@if().Location = new Point(8, 31);
		@if().Name = "Label44";
		@if().Size = new Size(130, 16);
		@if().TabIndex = 15;
		@if().Text = "Integration time (ms):";
		ig().Controls.Add(ih());
		ig().Controls.Add(ii());
		ig().Controls.Add(ij());
		ig().Controls.Add(ik());
		ig().Controls.Add(il());
		ig().Controls.Add(im());
		ig().Controls.Add(@in());
		ig().Controls.Add(io());
		ig().Location = new Point(4, 25);
		ig().Name = "TabPageT";
		ig().Padding = new Padding(3);
		ig().Size = new Size(309, 95);
		ig().TabIndex = 1;
		ig().Text = "Transmittance";
		ig().UseVisualStyleBackColor = true;
		ih().AutoSize = true;
		ih().Location = new Point(248, 9);
		ih().Name = "LabelDMTLong";
		ih().Size = new Size(38, 16);
		ih().TabIndex = 29;
		ih().Text = "Long";
		ih().Visible = false;
		ii().AutoSize = true;
		ii().Location = new Point(167, 9);
		ii().Name = "LabelDMTShort";
		ii().Size = new Size(39, 16);
		ii().TabIndex = 28;
		ii().Text = "Short";
		ij().AutoSize = true;
		ij().Location = new Point(8, 64);
		ij().Name = "Label45";
		ij().Size = new Size(125, 16);
		ij().TabIndex = 27;
		ij().Text = "# Integration cycles:";
		ik().AutoSize = true;
		ik().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ik().Location = new Point(8, 31);
		ik().Name = "Label47";
		ik().Size = new Size(130, 16);
		ik().TabIndex = 23;
		ik().Text = "Integration time (ms):";
		il().f(A_0: true);
		il().Location = new Point(233, 61);
		il().Name = "TextBoxDMTNumSpectraLong";
		il().e(A_0: false);
		il().Size = new Size(68, 22);
		il().TabIndex = 26;
		il().Visible = false;
		im().f(A_0: true);
		im().Location = new Point(152, 61);
		im().Name = "TextBoxDMTNumSpectraShort";
		im().e(A_0: false);
		im().Size = new Size(68, 22);
		im().TabIndex = 25;
		@in().f(A_0: false);
		@in().Location = new Point(233, 28);
		@in().Name = "TextBoxDMTIntTimeLong";
		@in().e(A_0: false);
		@in().Size = new Size(68, 22);
		@in().TabIndex = 24;
		@in().Visible = false;
		io().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		io().f(A_0: false);
		io().Location = new Point(152, 28);
		io().Name = "TextBoxDMTIntTimeShort";
		io().e(A_0: false);
		io().Size = new Size(68, 22);
		io().TabIndex = 22;
		ua().Controls.Add(ub());
		ua().Controls.Add(ue());
		ua().Controls.Add(um());
		ua().Controls.Add(uu());
		ua().Controls.Add(uv());
		ua().Controls.Add(uw());
		ua().Controls.Add(u6());
		ua().Controls.Add(u7());
		ua().Location = new Point(4, 25);
		ua().Name = "TabPageRAngle";
		ua().Padding = new Padding(3);
		ua().Size = new Size(309, 95);
		ua().TabIndex = 2;
		ua().Text = "Refl. @70 deg.";
		ua().UseVisualStyleBackColor = true;
		ub().AutoSize = true;
		ub().Location = new Point(248, 9);
		ub().Name = "LabelDMR2Long";
		ub().Size = new Size(38, 16);
		ub().TabIndex = 29;
		ub().Text = "Long";
		ub().Visible = false;
		ue().AutoSize = true;
		ue().Location = new Point(167, 9);
		ue().Name = "LabelDMR2Short";
		ue().Size = new Size(39, 16);
		ue().TabIndex = 28;
		ue().Text = "Short";
		um().AutoSize = true;
		um().Location = new Point(8, 64);
		um().Name = "Label8";
		um().Size = new Size(125, 16);
		um().TabIndex = 27;
		um().Text = "# Integration cycles:";
		uu().f(A_0: true);
		uu().Location = new Point(233, 61);
		uu().Name = "TextBoxDMR2NumSpectraLong";
		uu().e(A_0: false);
		uu().Size = new Size(68, 22);
		uu().TabIndex = 26;
		uu().Visible = false;
		uv().f(A_0: true);
		uv().Location = new Point(152, 61);
		uv().Name = "TextBoxDMR2NumSpectraShort";
		uv().e(A_0: false);
		uv().Size = new Size(68, 22);
		uv().TabIndex = 25;
		uw().f(A_0: false);
		uw().Location = new Point(233, 28);
		uw().Name = "TextBoxDMR2IntTimeLong";
		uw().e(A_0: false);
		uw().Size = new Size(68, 22);
		uw().TabIndex = 24;
		uw().Visible = false;
		u6().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		u6().f(A_0: false);
		u6().Location = new Point(152, 28);
		u6().Name = "TextBoxDMR2IntTimeShort";
		u6().e(A_0: false);
		u6().Size = new Size(68, 22);
		u6().TabIndex = 22;
		u7().AutoSize = true;
		u7().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		u7().Location = new Point(8, 31);
		u7().Name = "Label9";
		u7().Size = new Size(130, 16);
		u7().TabIndex = 23;
		u7().Text = "Integration time (ms):";
		ga().Cursor = Cursors.Default;
		ga().Enabled = false;
		ga().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ga().ForeColor = SystemColors.ControlText;
		ga().Location = new Point(561, 380);
		ga().Name = "ButtonDMOpticsConfig";
		ga().Size = new Size(101, 29);
		ga().TabIndex = 73;
		ga().Text = "Optics...";
		g3().Controls.Add(vl());
		g3().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		g3().Location = new Point(376, 3);
		g3().Name = "GroupBoxMeasType";
		g3().Size = new Size(335, 157);
		g3().TabIndex = 71;
		g3().TabStop = false;
		g3().Text = "Measurement Type";
		vl().ColumnCount = 1;
		vl().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		vl().Controls.Add(vm(), 0, 0);
		vl().Location = new Point(18, 25);
		vl().Name = "TableLayoutPanel2";
		vl().RowCount = 1;
		vl().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		vl().Size = new Size(197, 123);
		vl().TabIndex = 32;
		vm().Anchor = AnchorStyles.None;
		vm().AutoSize = true;
		vm().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		vm().ColumnCount = 1;
		vm().ColumnStyles.Add(new ColumnStyle());
		vm().Controls.Add(vk(), 0, 0);
		vm().Controls.Add(vg(), 0, 3);
		vm().Controls.Add(vi(), 0, 1);
		vm().Controls.Add(vh(), 0, 2);
		vm().Location = new Point(32, 9);
		vm().Name = "TableLayoutPanel1";
		vm().RowCount = 4;
		vm().RowStyles.Add(new RowStyle());
		vm().RowStyles.Add(new RowStyle());
		vm().RowStyles.Add(new RowStyle());
		vm().RowStyles.Add(new RowStyle());
		vm().Size = new Size(132, 104);
		vm().TabIndex = 31;
		vk().AutoSize = true;
		vk().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		vk().ForeColor = SystemColors.ControlText;
		vk().Location = new Point(3, 3);
		vk().Name = "CheckBoxMMeasAll";
		vk().Size = new Size(42, 20);
		vk().TabIndex = 30;
		vk().Text = "All";
		aeh().SetToolTip(vk(), "Analyze the reflectance at 0° data if it exists in the measured spectra. At least one check box must be selected.");
		vk().UseVisualStyleBackColor = true;
		vg().AutoSize = true;
		vg().Location = new Point(3, 81);
		vg().Name = "CheckBoxMMeasRAtAngle";
		vg().Size = new Size(120, 20);
		vg().TabIndex = 29;
		vg().Text = "Reflectance 70°";
		aeh().SetToolTip(vg(), "If selected, the reflectance at the specified angle will be acquired and included in the measured spectra.  At least one check box must be selected.");
		vg().UseVisualStyleBackColor = true;
		vi().AutoSize = true;
		vi().Location = new Point(3, 29);
		vi().Name = "CheckBoxMMeasR";
		vi().Size = new Size(113, 20);
		vi().TabIndex = 27;
		vi().Text = "Reflectance 0°";
		aeh().SetToolTip(vi(), "If selected, the reflectance at 0° will be acquired and included in the measured spectra. At least one check box must be selected.");
		vi().UseVisualStyleBackColor = true;
		vh().AutoSize = true;
		vh().Location = new Point(3, 55);
		vh().Name = "CheckBoxMMeasT";
		vh().Size = new Size(126, 20);
		vh().TabIndex = 28;
		vh().Text = "Transmittance 0°";
		aeh().SetToolTip(vh(), "If selected, the transmittance at 0° will be acquired and included in the measured spectra.  At least one check box must be selected.");
		vh().UseVisualStyleBackColor = true;
		gb().Cursor = Cursors.Default;
		gb().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		gb().ForeColor = SystemColors.ControlText;
		gb().Location = new Point(418, 380);
		gb().Name = "ButtonDMAdvSettings";
		gb().Size = new Size(101, 29);
		gb().TabIndex = 72;
		gb().Text = "Advanced...";
		ge().Controls.Add(gk());
		ge().Controls.Add(gl());
		ge().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ge().Location = new Point(378, 166);
		ge().Name = "GroupBoxDMSpectrometerType";
		ge().Size = new Size(335, 207);
		ge().TabIndex = 70;
		ge().TabStop = false;
		ge().Text = "Spectrometer Type";
		gk().AutoSize = true;
		gk().Location = new Point(42, 177);
		gk().Name = "CheckBoxDMAllSpecTypesSameAsR";
		gk().Size = new Size(252, 20);
		gk().TabIndex = 20;
		gk().Text = "All Spectrometers Have Same Config.";
		gk().UseVisualStyleBackColor = true;
		gl().Controls.Add(gm());
		gl().Controls.Add(gy());
		gl().Controls.Add(u8());
		gl().Location = new Point(15, 24);
		gl().Name = "TabControlDMSpecType";
		gl().SelectedIndex = 0;
		gl().Size = new Size(305, 144);
		gl().TabIndex = 15;
		gm().Controls.Add(gn());
		gm().Controls.Add(go());
		gm().Controls.Add(gp());
		gm().Controls.Add(gs());
		gm().Location = new Point(4, 25);
		gm().Name = "TabPageDMSpecTypeR";
		gm().Padding = new Padding(3);
		gm().Size = new Size(297, 115);
		gm().TabIndex = 0;
		gm().Text = "Reflectance";
		gm().UseVisualStyleBackColor = true;
		gn().AutoSize = true;
		gn().Location = new Point(7, 87);
		gn().Name = "RadioButtonDMRSpecTypeBoth";
		gn().Size = new Size(269, 20);
		gn().TabIndex = 18;
		gn().Text = "Extended wavelength range (both specs)";
		gn().UseVisualStyleBackColor = true;
		go().AutoSize = true;
		go().Location = new Point(7, 60);
		go().Name = "RadioButtonDMRSpecTypeLong";
		go().Size = new Size(213, 20);
		go().TabIndex = 17;
		go().Text = "Long wavelength (spec #2 only)";
		go().UseVisualStyleBackColor = true;
		gp().AutoSize = true;
		gp().Location = new Point(7, 33);
		gp().Name = "RadioButtonDMRSpecTypeShort";
		gp().Size = new Size(214, 20);
		gp().TabIndex = 16;
		gp().Text = "Short wavelength (spec #1 only)";
		gp().UseVisualStyleBackColor = true;
		gs().AutoSize = true;
		gs().Checked = true;
		gs().ForeColor = SystemColors.ControlText;
		gs().Location = new Point(7, 6);
		gs().Name = "RadioButtonDMRSpecTypeAny";
		gs().Size = new Size(131, 20);
		gs().TabIndex = 15;
		gs().TabStop = true;
		gs().Text = "Any spectrometer";
		gs().UseVisualStyleBackColor = true;
		gy().Controls.Add(gz());
		gy().Controls.Add(g0());
		gy().Controls.Add(g1());
		gy().Controls.Add(g2());
		gy().Location = new Point(4, 25);
		gy().Name = "TabPageDMSpecTypeT";
		gy().Padding = new Padding(3);
		gy().Size = new Size(297, 115);
		gy().TabIndex = 1;
		gy().Text = "Transmittance";
		gy().UseVisualStyleBackColor = true;
		gz().AutoSize = true;
		gz().Location = new Point(7, 87);
		gz().Name = "RadioButtonDMTSpecTypeBoth";
		gz().Size = new Size(269, 20);
		gz().TabIndex = 23;
		gz().Text = "Extended wavelength range (both specs)";
		gz().UseVisualStyleBackColor = true;
		g0().AutoSize = true;
		g0().Location = new Point(7, 60);
		g0().Name = "RadioButtonDMTSpecTypeLong";
		g0().Size = new Size(213, 20);
		g0().TabIndex = 22;
		g0().Text = "Long wavelength (spec #2 only)";
		g0().UseVisualStyleBackColor = true;
		g1().AutoSize = true;
		g1().Location = new Point(7, 33);
		g1().Name = "RadioButtonDMTSpecTypeShort";
		g1().Size = new Size(214, 20);
		g1().TabIndex = 21;
		g1().Text = "Short wavelength (spec #1 only)";
		g1().UseVisualStyleBackColor = true;
		g2().AutoSize = true;
		g2().Checked = true;
		g2().ForeColor = SystemColors.ControlText;
		g2().Location = new Point(7, 6);
		g2().Name = "RadioButtonDMTSpecTypeAny";
		g2().Size = new Size(131, 20);
		g2().TabIndex = 20;
		g2().TabStop = true;
		g2().Text = "Any spectrometer";
		g2().UseVisualStyleBackColor = true;
		u8().Controls.Add(u9());
		u8().Controls.Add(va());
		u8().Controls.Add(vb());
		u8().Controls.Add(vc());
		u8().Location = new Point(4, 25);
		u8().Name = "TabPageDMSpecTypeRAngle";
		u8().Padding = new Padding(3);
		u8().Size = new Size(297, 115);
		u8().TabIndex = 2;
		u8().Text = "Refl. @70 deg.";
		u8().UseVisualStyleBackColor = true;
		u9().AutoSize = true;
		u9().Location = new Point(7, 87);
		u9().Name = "RadioButtonDMR2SpecTypeBoth";
		u9().Size = new Size(269, 20);
		u9().TabIndex = 22;
		u9().Text = "Extended wavelength range (both specs)";
		u9().UseVisualStyleBackColor = true;
		va().AutoSize = true;
		va().Location = new Point(7, 60);
		va().Name = "RadioButtonDMR2SpecTypeLong";
		va().Size = new Size(213, 20);
		va().TabIndex = 21;
		va().Text = "Long wavelength (spec #2 only)";
		va().UseVisualStyleBackColor = true;
		vb().AutoSize = true;
		vb().Location = new Point(7, 33);
		vb().Name = "RadioButtonDMR2SpecTypeShort";
		vb().Size = new Size(214, 20);
		vb().TabIndex = 20;
		vb().Text = "Short wavelength (spec #1 only)";
		vb().UseVisualStyleBackColor = true;
		vc().AutoSize = true;
		vc().Checked = true;
		vc().ForeColor = SystemColors.ControlText;
		vc().Location = new Point(7, 6);
		vc().Name = "RadioButtonDMR2SpecTypeAny";
		vc().Size = new Size(131, 20);
		vc().TabIndex = 19;
		vc().TabStop = true;
		vc().Text = "Any spectrometer";
		vc().UseVisualStyleBackColor = true;
		qh().AutoScroll = true;
		qh().Controls.Add(qi());
		qh().Location = new Point(4, 25);
		qh().Name = "TabPageWaferMap";
		qh().Size = new Size(779, 464);
		qh().TabIndex = 6;
		qh().Text = "Wafer Map";
		qh().UseVisualStyleBackColor = true;
		qi().AutoSize = true;
		qi().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		qi().Controls.Add(y0());
		qi().Controls.Add(ahq());
		qi().Controls.Add(v7());
		qi().Controls.Add(tg());
		qi().Controls.Add(tb());
		qi().Controls.Add(r5());
		qi().Controls.Add(qq());
		qi().Location = new Point(3, 3);
		qi().Name = "PanelWaferMap";
		qi().Size = new Size(754, 487);
		qi().TabIndex = 2;
		y0().BackColor = Color.Transparent;
		y0().Controls.Add(zc());
		y0().Controls.Add(zf());
		y0().Controls.Add(zb());
		y0().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		y0().ForeColor = SystemColors.ControlText;
		y0().Location = new Point(3, 386);
		y0().Name = "GroupBoxCTMAutomaticPeakPositioning";
		y0().RightToLeft = RightToLeft.No;
		y0().Size = new Size(748, 98);
		y0().TabIndex = 25;
		y0().TabStop = false;
		y0().Text = "CTM Automatic Peak Positioning";
		y0().Visible = false;
		zc().Controls.Add(zd());
		zc().Controls.Add(ze());
		zc().Location = new Point(558, 19);
		zc().Name = "GroupBoxFrequency";
		zc().Size = new Size(148, 70);
		zc().TabIndex = 79;
		zc().TabStop = false;
		zc().Text = "Frequency";
		zd().AutoSize = true;
		zd().BackColor = Color.Transparent;
		zd().Cursor = Cursors.Default;
		zd().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		zd().ForeColor = SystemColors.ControlText;
		zd().Location = new Point(6, 42);
		zd().Name = "RadioButtonGOFFail";
		zd().RightToLeft = RightToLeft.No;
		zd().Size = new Size(136, 20);
		zd().TabIndex = 48;
		zd().TabStop = true;
		zd().Text = "First point/GOF fail";
		aef().SetToolTip(zd(), "Adjust lens height at first measurement location.\r\nIf GOF is less than Minimum Valid GOF then switch to adjusting lens height at each measurement location.");
		zd().UseVisualStyleBackColor = false;
		ze().AutoSize = true;
		ze().BackColor = Color.Transparent;
		ze().Cursor = Cursors.Default;
		ze().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ze().ForeColor = SystemColors.ControlText;
		ze().Location = new Point(6, 20);
		ze().Name = "RadioButtonEveryPoint";
		ze().RightToLeft = RightToLeft.No;
		ze().Size = new Size(90, 20);
		ze().TabIndex = 47;
		ze().TabStop = true;
		ze().Text = "Every point";
		aef().SetToolTip(ze(), "Adjust lens height at every measurement location");
		ze().UseVisualStyleBackColor = false;
		zf().Controls.Add(y8());
		zf().Controls.Add(y7());
		zf().Controls.Add(y6());
		zf().Controls.Add(y9());
		zf().Controls.Add(za());
		zf().Controls.Add(y5());
		zf().Location = new Point(204, 19);
		zf().Name = "GroupBoxPeakTarget";
		zf().Size = new Size(337, 70);
		zf().TabIndex = 78;
		zf().TabStop = false;
		zf().Text = "Target Peak(s)";
		y8().AutoSize = true;
		y8().BackColor = Color.Transparent;
		y8().Cursor = Cursors.Default;
		y8().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		y8().ForeColor = SystemColors.ControlText;
		y8().Location = new Point(6, 20);
		y8().Name = "RadioButtonFixed";
		y8().RightToLeft = RightToLeft.No;
		y8().Size = new Size(83, 20);
		y8().TabIndex = 46;
		y8().TabStop = true;
		y8().Text = "First fixed";
		aef().SetToolTip(y8(), "Position lens height so wavelength of peak corresponding\r\n to first detected surface is at specified wavelength");
		y8().UseVisualStyleBackColor = false;
		y7().BackColor = Color.Transparent;
		y7().Cursor = Cursors.Default;
		y7().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		y7().ForeColor = SystemColors.ControlText;
		y7().Location = new Point(6, 43);
		y7().Name = "RadioButtonCentered";
		y7().RightToLeft = RightToLeft.No;
		y7().Size = new Size(125, 23);
		y7().TabIndex = 47;
		y7().TabStop = true;
		y7().Text = "Centered";
		aef().SetToolTip(y7(), "Position lens height so peaks are\r\n centered in measured spectrum");
		y7().UseVisualStyleBackColor = false;
		y6().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		y6().f(A_0: false);
		y6().Location = new Point(93, 20);
		y6().Name = "TextBoxNumeric1stPeakTarget";
		y6().e(A_0: false);
		y6().Size = new Size(46, 22);
		y6().TabIndex = 48;
		y6().Text = "550";
		aef().SetToolTip(y6(), "Target wavelength for peak from top surface");
		y9().BackColor = Color.Transparent;
		y9().Cursor = Cursors.Default;
		y9().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		y9().ForeColor = SystemColors.ControlText;
		y9().Location = new Point(177, 31);
		y9().Name = "LabelNumRequiredPeaks";
		y9().RightToLeft = RightToLeft.No;
		y9().Size = new Size(118, 16);
		y9().TabIndex = 76;
		y9().Text = "#Required peaks:";
		y9().TextAlign = ContentAlignment.TopRight;
		za().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		za().Location = new Point(295, 29);
		za().Maximum = new decimal(new int[4] { 5, 0, 0, 0 });
		za().Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		za().Name = "NumericUpDownRequiredPeaks";
		za().Size = new Size(34, 22);
		za().TabIndex = 75;
		aef().SetToolTip(za(), componentResourceManager.GetString("NumericUpDownRequiredPeaks.ToolTip"));
		za().Value = new decimal(new int[4] { 1, 0, 0, 0 });
		y5().BackColor = Color.Transparent;
		y5().Cursor = Cursors.Default;
		y5().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		y5().ForeColor = SystemColors.WindowText;
		y5().Location = new Point(142, 22);
		y5().Name = "Label1stPeakTarget";
		y5().RightToLeft = RightToLeft.No;
		y5().Size = new Size(30, 17);
		y5().TabIndex = 49;
		y5().Text = "nm";
		zb().Controls.Add(y3());
		zb().Controls.Add(y2());
		zb().Controls.Add(y4());
		zb().Controls.Add(y1());
		zb().Location = new Point(7, 19);
		zb().Name = "GroupBoxMaxValues";
		zb().Size = new Size(179, 70);
		zb().TabIndex = 77;
		zb().TabStop = false;
		zb().Text = "Max Values (mm)";
		y3().BackColor = Color.Transparent;
		y3().Cursor = Cursors.Default;
		y3().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		y3().ForeColor = SystemColors.ControlText;
		y3().Location = new Point(48, 20);
		y3().Name = "LabelMaxWaferThickLabel";
		y3().RightToLeft = RightToLeft.No;
		y3().Size = new Size(76, 16);
		y3().TabIndex = 33;
		y3().Text = "Thickness:";
		y3().TextAlign = ContentAlignment.TopRight;
		y2().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		y2().f(A_0: false);
		y2().Location = new Point(128, 17);
		y2().Name = "TextBoxNumericMaxWaferThickness";
		y2().e(A_0: false);
		y2().Size = new Size(37, 22);
		y2().TabIndex = 34;
		y2().Text = "3.0";
		aef().SetToolTip(y2(), "Maximum thickness (mm) of the wafer\r\nSoftware will move lens this far up at the first measurement location when searching for sample surface\r\n(when automatically positioning the CTM peaks)");
		y4().BackColor = Color.Transparent;
		y4().Cursor = Cursors.Default;
		y4().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		y4().ForeColor = SystemColors.ControlText;
		y4().Location = new Point(10, 45);
		y4().Name = "LabelMaxHeightVarLabel";
		y4().RightToLeft = RightToLeft.No;
		y4().Size = new Size(114, 16);
		y4().TabIndex = 31;
		y4().Text = "Height variation:";
		y4().TextAlign = ContentAlignment.TopRight;
		y1().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		y1().f(A_0: false);
		y1().Location = new Point(128, 42);
		y1().Name = "TextBoxNumericMapMaxHeightVariation";
		y1().e(A_0: false);
		y1().Size = new Size(37, 22);
		y1().TabIndex = 36;
		y1().Text = "1.0";
		aef().SetToolTip(y1(), "Amount top surface height can vary among all measurement points (Max-Min)\r\nSoftware will move lens this far up from at subsequent measurement locations\r\n(when automatically positioning the CTM peaks)");
		ahq().Controls.Add(ahs());
		ahq().Controls.Add(aht());
		ahq().Controls.Add(ahu());
		ahq().Controls.Add(ahv());
		ahq().Controls.Add(ahw());
		ahq().Controls.Add(ahx());
		ahq().Controls.Add(ahy());
		ahq().Controls.Add(ahz());
		ahq().Controls.Add(ahr());
		ahq().Location = new Point(3, 183);
		ahq().Name = "GroupBox2";
		ahq().Size = new Size(254, 104);
		ahq().TabIndex = 26;
		ahq().TabStop = false;
		ahs().Enabled = false;
		ahs().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ahs().f(A_0: false);
		ahs().Location = new Point(166, 71);
		ahs().Name = "TBNOffsetMapOriginY";
		ahs().e(A_0: true);
		ahs().Size = new Size(50, 22);
		ahs().TabIndex = 80;
		ahs().Text = "0";
		aht().Enabled = false;
		aht().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aht().f(A_0: false);
		aht().Location = new Point(53, 71);
		aht().Name = "TBNOffsetMapOriginX";
		aht().e(A_0: true);
		aht().Size = new Size(50, 22);
		aht().TabIndex = 79;
		aht().Text = "0";
		ahu().AutoSize = true;
		ahu().BackColor = Color.Transparent;
		ahu().Cursor = Cursors.Default;
		ahu().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ahu().ForeColor = SystemColors.ControlText;
		ahu().Location = new Point(28, 74);
		ahu().Name = "Label4";
		ahu().RightToLeft = RightToLeft.No;
		ahu().Size = new Size(19, 16);
		ahu().TabIndex = 78;
		ahu().Text = "X:";
		ahu().TextAlign = ContentAlignment.TopRight;
		ahv().AutoSize = true;
		ahv().BackColor = Color.Transparent;
		ahv().Cursor = Cursors.Default;
		ahv().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ahv().ForeColor = SystemColors.ControlText;
		ahv().Location = new Point(140, 74);
		ahv().Name = "Label51";
		ahv().RightToLeft = RightToLeft.No;
		ahv().Size = new Size(20, 16);
		ahv().TabIndex = 77;
		ahv().Text = "Y:";
		ahv().TextAlign = ContentAlignment.TopRight;
		ahw().BackColor = Color.Transparent;
		ahw().Cursor = Cursors.Default;
		ahw().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ahw().ForeColor = SystemColors.WindowText;
		ahw().Location = new Point(104, 74);
		ahw().Name = "Label52";
		ahw().RightToLeft = RightToLeft.No;
		ahw().Size = new Size(30, 17);
		ahw().TabIndex = 76;
		ahw().Text = "mm";
		ahw().TextAlign = ContentAlignment.TopRight;
		ahx().BackColor = Color.Transparent;
		ahx().Cursor = Cursors.Default;
		ahx().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ahx().ForeColor = SystemColors.WindowText;
		ahx().Location = new Point(217, 74);
		ahx().Name = "Label53";
		ahx().RightToLeft = RightToLeft.No;
		ahx().Size = new Size(30, 17);
		ahx().TabIndex = 75;
		ahx().Text = "mm";
		ahx().TextAlign = ContentAlignment.TopRight;
		ahy().AutoSize = true;
		ahy().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ahy().Location = new Point(6, 52);
		ahy().Name = "RadioButtonOffsetAbsolute";
		ahy().Size = new Size(77, 20);
		ahy().TabIndex = 39;
		ahy().TabStop = true;
		ahy().Text = "Absolute";
		ahy().UseVisualStyleBackColor = true;
		ahz().AutoSize = true;
		ahz().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ahz().Location = new Point(6, 26);
		ahz().Name = "RadioButtonOffsetRelativeToStart";
		ahz().Size = new Size(171, 20);
		ahz().TabIndex = 38;
		ahz().TabStop = true;
		ahz().Text = "Relative to Start Location";
		ahz().UseVisualStyleBackColor = true;
		ahr().AutoSize = true;
		ahr().BackColor = SystemColors.Window;
		ahr().Cursor = Cursors.Default;
		ahr().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ahr().ForeColor = SystemColors.ControlText;
		ahr().Location = new Point(12, 0);
		ahr().Name = "CheckBoxOffsetMapOrigin";
		ahr().RightToLeft = RightToLeft.No;
		ahr().Size = new Size(137, 20);
		ahr().TabIndex = 37;
		ahr().Text = "Offset Map Origin";
		ahr().UseVisualStyleBackColor = false;
		v7().Controls.Add(v8());
		v7().Controls.Add(v9());
		v7().Controls.Add(wa());
		v7().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		v7().Location = new Point(464, 291);
		v7().Name = "GroupBoxFullWaferReference";
		v7().Size = new Size(286, 91);
		v7().TabIndex = 74;
		v7().TabStop = false;
		v7().Text = "Full Wafer Reference Mode";
		v8().AutoSize = true;
		v8().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		v8().Location = new Point(32, 66);
		v8().Name = "RadioFWROn";
		v8().Size = new Size(43, 20);
		v8().TabIndex = 2;
		v8().TabStop = true;
		v8().Text = "On";
		v8().UseVisualStyleBackColor = true;
		v9().AutoSize = true;
		v9().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		v9().Location = new Point(32, 42);
		v9().Name = "RadioFWROff";
		v9().Size = new Size(42, 20);
		v9().TabIndex = 1;
		v9().TabStop = true;
		v9().Text = "Off";
		v9().UseVisualStyleBackColor = true;
		wa().AutoSize = true;
		wa().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		wa().Location = new Point(32, 18);
		wa().Name = "RadioFWRAuto";
		wa().Size = new Size(85, 20);
		wa().TabIndex = 0;
		wa().TabStop = true;
		wa().Text = "Automatic";
		wa().UseVisualStyleBackColor = true;
		tg().BackColor = Color.Transparent;
		tg().Controls.Add(ts());
		tg().Controls.Add(tt());
		tg().Controls.Add(t5());
		tg().Controls.Add(th());
		tg().Controls.Add(ti());
		tg().Controls.Add(tp());
		tg().Controls.Add(tr());
		tg().Controls.Add(tj());
		tg().Controls.Add(tk());
		tg().Controls.Add(tl());
		tg().Controls.Add(tm());
		tg().Controls.Add(tn());
		tg().Controls.Add(to());
		tg().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		tg().ForeColor = SystemColors.ControlText;
		tg().Location = new Point(3, 291);
		tg().Name = "PatternAvoidanceFrame";
		tg().RightToLeft = RightToLeft.No;
		tg().Size = new Size(451, 91);
		tg().TabIndex = 73;
		tg().TabStop = false;
		ts().Enabled = false;
		ts().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ts().f(A_0: false);
		ts().Location = new Point(84, 55);
		ts().Name = "MapPatternSizeBox";
		ts().e(A_0: false);
		ts().Size = new Size(50, 22);
		ts().TabIndex = 74;
		ts().Text = "0";
		tt().Enabled = false;
		tt().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		tt().f(A_0: false);
		tt().Location = new Point(299, 55);
		tt().Name = "MapPatternSpacingBox";
		tt().e(A_0: false);
		tt().Size = new Size(49, 22);
		tt().TabIndex = 73;
		t5().Enabled = false;
		t5().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		t5().f(A_0: false);
		t5().Location = new Point(84, 25);
		t5().Name = "MapSpotSizeBox";
		t5().e(A_0: false);
		t5().Size = new Size(50, 22);
		t5().TabIndex = 72;
		t5().Text = "0";
		th().BackColor = Color.Transparent;
		th().Cursor = Cursors.Default;
		th().Enabled = false;
		th().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		th().ForeColor = SystemColors.ControlText;
		th().Location = new Point(185, 25);
		th().Name = "MapRectangularOption";
		th().RightToLeft = RightToLeft.No;
		th().Size = new Size(100, 23);
		th().TabIndex = 45;
		th().TabStop = true;
		th().Text = "Rectangular";
		th().UseVisualStyleBackColor = false;
		ti().BackColor = Color.Transparent;
		ti().Cursor = Cursors.Default;
		ti().Enabled = false;
		ti().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ti().ForeColor = SystemColors.ControlText;
		ti().Location = new Point(185, 54);
		ti().Name = "MapRadialOption";
		ti().RightToLeft = RightToLeft.No;
		ti().Size = new Size(76, 18);
		ti().TabIndex = 44;
		ti().TabStop = true;
		ti().Text = "Radial";
		ti().UseVisualStyleBackColor = false;
		tp().AutoSize = true;
		tp().BackColor = SystemColors.Window;
		tp().Cursor = Cursors.Default;
		tp().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		tp().ForeColor = SystemColors.ControlText;
		tp().Location = new Point(221, -3);
		tp().Name = "InvalidMeasRetryCheck";
		tp().RightToLeft = RightToLeft.No;
		tp().Size = new Size(148, 20);
		tp().TabIndex = 71;
		tp().Text = "Invalid Meas. Retry";
		tp().UseVisualStyleBackColor = false;
		tr().AutoSize = true;
		tr().BackColor = SystemColors.Window;
		tr().Cursor = Cursors.Default;
		tr().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		tr().ForeColor = SystemColors.ControlText;
		tr().Location = new Point(14, -3);
		tr().Name = "PatternAvoidCheck";
		tr().RightToLeft = RightToLeft.No;
		tr().Size = new Size(144, 20);
		tr().TabIndex = 70;
		tr().Text = "Pattern Avoidance";
		tr().UseVisualStyleBackColor = false;
		tj().BackColor = Color.Transparent;
		tj().Cursor = Cursors.Default;
		tj().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		tj().ForeColor = SystemColors.ControlText;
		tj().Location = new Point(9, 26);
		tj().Name = "_LabelCA_6";
		tj().RightToLeft = RightToLeft.No;
		tj().Size = new Size(74, 17);
		tj().TabIndex = 51;
		tj().Text = "Spot Size:";
		tj().TextAlign = ContentAlignment.TopRight;
		tk().BackColor = Color.Transparent;
		tk().Cursor = Cursors.Default;
		tk().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		tk().ForeColor = SystemColors.ControlText;
		tk().Location = new Point(0, 55);
		tk().Name = "_LabelCA_7";
		tk().RightToLeft = RightToLeft.No;
		tk().Size = new Size(84, 17);
		tk().TabIndex = 50;
		tk().Text = "Pattern Size:";
		tk().TextAlign = ContentAlignment.TopRight;
		tl().BackColor = Color.Transparent;
		tl().Cursor = Cursors.Default;
		tl().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		tl().ForeColor = SystemColors.ControlText;
		tl().Location = new Point(293, 27);
		tl().Name = "_LabelCA_17";
		tl().RightToLeft = RightToLeft.No;
		tl().Size = new Size(64, 20);
		tl().TabIndex = 49;
		tl().Text = "Spacing:";
		tl().TextAlign = ContentAlignment.TopRight;
		tm().BackColor = Color.Transparent;
		tm().Cursor = Cursors.Default;
		tm().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		tm().ForeColor = SystemColors.WindowText;
		tm().Location = new Point(349, 58);
		tm().Name = "MapPatternSpacingLabel";
		tm().RightToLeft = RightToLeft.No;
		tm().Size = new Size(54, 17);
		tm().TabIndex = 48;
		tm().Text = "degrees";
		tn().BackColor = Color.Transparent;
		tn().Cursor = Cursors.Default;
		tn().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		tn().ForeColor = SystemColors.WindowText;
		tn().Location = new Point(138, 26);
		tn().Name = "_LabelCA_8";
		tn().RightToLeft = RightToLeft.No;
		tn().Size = new Size(30, 17);
		tn().TabIndex = 47;
		tn().Text = "mm";
		tn().TextAlign = ContentAlignment.TopRight;
		to().BackColor = Color.Transparent;
		to().Cursor = Cursors.Default;
		to().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		to().ForeColor = SystemColors.WindowText;
		to().Location = new Point(138, 55);
		to().Name = "_LabelCA_9";
		to().RightToLeft = RightToLeft.No;
		to().Size = new Size(30, 17);
		to().TabIndex = 46;
		to().Text = "mm";
		to().TextAlign = ContentAlignment.TopRight;
		tb().BackColor = Color.Transparent;
		tb().Controls.Add(aim());
		tb().Controls.Add(tc());
		tb().Controls.Add(td());
		tb().Controls.Add(te());
		tb().Controls.Add(tf());
		tb().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		tb().ForeColor = SystemColors.ControlText;
		tb().Location = new Point(263, 186);
		tb().Name = "DataToSaveFrame";
		tb().RightToLeft = RightToLeft.No;
		tb().Size = new Size(191, 101);
		tb().TabIndex = 72;
		tb().TabStop = false;
		tb().Text = "Automatic Data Saving";
		aim().AutoSize = true;
		aim().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aim().Image = Resources.SettingImage;
		aim().Location = new Point(154, 15);
		aim().Name = "ButtonMapAutosaveSettings";
		aim().Size = new Size(30, 30);
		aim().TabIndex = 76;
		aim().UseVisualStyleBackColor = true;
		tc().AutoSize = true;
		tc().BackColor = Color.Transparent;
		tc().Cursor = Cursors.Default;
		tc().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		tc().ForeColor = SystemColors.ControlText;
		tc().Location = new Point(15, 72);
		tc().Name = "SaveSpectraCheckBox";
		tc().RightToLeft = RightToLeft.No;
		tc().Size = new Size(102, 20);
		tc().TabIndex = 75;
		tc().Text = "Save spectra";
		tc().UseVisualStyleBackColor = false;
		td().AutoSize = true;
		td().BackColor = Color.Transparent;
		td().Cursor = Cursors.Default;
		td().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		td().ForeColor = SystemColors.ControlText;
		td().Location = new Point(149, 67);
		td().Name = "SaveRunningCheckBox";
		td().RightToLeft = RightToLeft.No;
		td().Size = new Size(173, 20);
		td().TabIndex = 74;
		td().Text = "Save intermediate results";
		td().UseVisualStyleBackColor = false;
		td().Visible = false;
		te().AutoSize = true;
		te().BackColor = Color.Transparent;
		te().Cursor = Cursors.Default;
		te().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		te().ForeColor = SystemColors.ControlText;
		te().Location = new Point(15, 22);
		te().Name = "SaveResultsCheckBox";
		te().RightToLeft = RightToLeft.No;
		te().Size = new Size(127, 20);
		te().TabIndex = 73;
		te().Text = "Save map to disk";
		aef().SetToolTip(te(), "Automatically Save Wafer Map as the name specified in the WaferMap window (Map Info: File)");
		te().UseVisualStyleBackColor = false;
		tf().AutoSize = true;
		tf().BackColor = Color.Transparent;
		tf().Cursor = Cursors.Default;
		tf().Enabled = false;
		tf().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		tf().ForeColor = SystemColors.ControlText;
		tf().Location = new Point(15, 47);
		tf().Name = "chkAutoExport";
		tf().RightToLeft = RightToLeft.No;
		tf().Size = new Size(167, 20);
		tf().TabIndex = 72;
		tf().Text = "Export to custom format";
		tf().UseVisualStyleBackColor = false;
		r5().BackColor = Color.Transparent;
		r5().Controls.Add(zg());
		r5().Controls.Add(r6());
		r5().Controls.Add(r7());
		r5().Controls.Add(sg());
		r5().Controls.Add(s4());
		r5().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		r5().ForeColor = SystemColors.ControlText;
		r5().Location = new Point(464, 5);
		r5().Name = "DataToMapFrame";
		r5().RightToLeft = RightToLeft.No;
		r5().Size = new Size(286, 282);
		r5().TabIndex = 20;
		r5().TabStop = false;
		r5().Text = "Additional Parameters To Be Mapped";
		zg().BackColor = Color.Transparent;
		zg().Cursor = Cursors.Default;
		zg().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		zg().ForeColor = SystemColors.ControlText;
		zg().Location = new Point(24, 255);
		zg().Name = "CheckBoxReportFocusLensPos";
		zg().RightToLeft = RightToLeft.No;
		zg().Size = new Size(228, 21);
		zg().TabIndex = 36;
		zg().Text = "Focus Height";
		zg().UseVisualStyleBackColor = false;
		zg().Visible = false;
		r6().BackColor = Color.Transparent;
		r6().Cursor = Cursors.Default;
		r6().Enabled = false;
		r6().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		r6().ForeColor = SystemColors.ControlText;
		r6().Location = new Point(24, 51);
		r6().Name = "RefBandCheckBox";
		r6().RightToLeft = RightToLeft.No;
		r6().Size = new Size(178, 21);
		r6().TabIndex = 35;
		r6().Text = "Reflectivity band center";
		r6().UseVisualStyleBackColor = false;
		r7().BackColor = Color.Transparent;
		r7().Cursor = Cursors.Default;
		r7().Enabled = false;
		r7().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		r7().ForeColor = SystemColors.ControlText;
		r7().Location = new Point(24, 23);
		r7().Name = "FPDipCheckBox";
		r7().RightToLeft = RightToLeft.No;
		r7().Size = new Size(151, 21);
		r7().TabIndex = 34;
		r7().Text = "Fabry-Perot dip";
		r7().UseVisualStyleBackColor = false;
		sg().BackColor = Color.Transparent;
		sg().Controls.Add(t7());
		sg().Controls.Add(t8());
		sg().Controls.Add(t9());
		sg().Controls.Add(s3());
		sg().Controls.Add(sh());
		sg().Controls.Add(si());
		sg().Controls.Add(sr());
		sg().Controls.Add(ss());
		sg().Controls.Add(st());
		sg().Controls.Add(s2());
		sg().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		sg().ForeColor = SystemColors.ControlText;
		sg().Location = new Point(12, 82);
		sg().Name = "Frame4";
		sg().RightToLeft = RightToLeft.No;
		sg().Size = new Size(262, 137);
		sg().TabIndex = 24;
		sg().TabStop = false;
		t7().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		t7().f(A_0: false);
		t7().Location = new Point(173, 63);
		t7().Name = "AveReflEndWaveBox";
		t7().e(A_0: false);
		t7().Size = new Size(52, 22);
		t7().TabIndex = 35;
		t7().Text = "400";
		t8().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		t8().f(A_0: false);
		t8().Location = new Point(173, 100);
		t8().Name = "AveReflRefWaveBox";
		t8().e(A_0: false);
		t8().Size = new Size(52, 22);
		t8().TabIndex = 36;
		t9().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		t9().f(A_0: false);
		t9().Location = new Point(173, 26);
		t9().Name = "AveReflStartWaveBox";
		t9().e(A_0: false);
		t9().Size = new Size(52, 22);
		t9().TabIndex = 34;
		t9().Text = "400";
		s3().BackColor = SystemColors.Window;
		s3().Cursor = Cursors.Default;
		s3().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		s3().ForeColor = SystemColors.ControlText;
		s3().Location = new Point(12, -3);
		s3().Name = "AvgReflCheck";
		s3().RightToLeft = RightToLeft.No;
		s3().Size = new Size(193, 21);
		s3().TabIndex = 23;
		s3().Text = "Average reflectance ratio";
		s3().UseVisualStyleBackColor = false;
		sh().BackColor = Color.Transparent;
		sh().Cursor = Cursors.Default;
		sh().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		sh().ForeColor = SystemColors.ControlText;
		sh().Location = new Point(6, 29);
		sh().Name = "_LabelCA_0";
		sh().RightToLeft = RightToLeft.No;
		sh().Size = new Size(161, 16);
		sh().TabIndex = 33;
		sh().Text = "Starting wavelength:";
		sh().TextAlign = ContentAlignment.TopRight;
		si().BackColor = Color.Transparent;
		si().Cursor = Cursors.Default;
		si().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		si().ForeColor = SystemColors.WindowText;
		si().Location = new Point(228, 29);
		si().Name = "_LabelCA_3";
		si().RightToLeft = RightToLeft.No;
		si().Size = new Size(28, 17);
		si().TabIndex = 32;
		si().Text = "nm";
		sr().BackColor = Color.Transparent;
		sr().Cursor = Cursors.Default;
		sr().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		sr().ForeColor = SystemColors.ControlText;
		sr().Location = new Point(6, 66);
		sr().Name = "_LabelCA_1";
		sr().RightToLeft = RightToLeft.No;
		sr().Size = new Size(161, 16);
		sr().TabIndex = 31;
		sr().Text = "Ending wavelength:";
		sr().TextAlign = ContentAlignment.TopRight;
		ss().BackColor = Color.Transparent;
		ss().Cursor = Cursors.Default;
		ss().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ss().ForeColor = SystemColors.WindowText;
		ss().Location = new Point(228, 66);
		ss().Name = "_LabelCA_4";
		ss().RightToLeft = RightToLeft.No;
		ss().Size = new Size(28, 17);
		ss().TabIndex = 30;
		ss().Text = "nm";
		st().BackColor = Color.Transparent;
		st().Cursor = Cursors.Default;
		st().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		st().ForeColor = SystemColors.ControlText;
		st().Location = new Point(6, 103);
		st().Name = "_LabelCA_2";
		st().RightToLeft = RightToLeft.No;
		st().Size = new Size(161, 16);
		st().TabIndex = 29;
		st().Text = "Reference wavelength:";
		st().TextAlign = ContentAlignment.TopRight;
		s2().BackColor = Color.Transparent;
		s2().Cursor = Cursors.Default;
		s2().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		s2().ForeColor = SystemColors.WindowText;
		s2().Location = new Point(228, 103);
		s2().Name = "_LabelCA_5";
		s2().RightToLeft = RightToLeft.No;
		s2().Size = new Size(28, 17);
		s2().TabIndex = 28;
		s2().Text = "nm";
		s4().BackColor = Color.Transparent;
		s4().Cursor = Cursors.Default;
		s4().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		s4().ForeColor = SystemColors.ControlText;
		s4().Location = new Point(24, 229);
		s4().Name = "ckSolveForGOF";
		s4().RightToLeft = RightToLeft.No;
		s4().Size = new Size(228, 21);
		s4().TabIndex = 20;
		s4().Text = "GOF ( solve for Goodness Of Fit)";
		s4().UseVisualStyleBackColor = false;
		qq().BackColor = Color.Transparent;
		qq().Controls.Add(vn());
		qq().Controls.Add(aek());
		qq().Controls.Add(ad9());
		qq().Controls.Add(z0());
		qq().Controls.Add(qr());
		qq().Controls.Add(rf());
		qq().Controls.Add(rw());
		qq().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		qq().ForeColor = SystemColors.ControlText;
		qq().Location = new Point(3, 5);
		qq().Name = "MeasurementInfoFrame";
		qq().RightToLeft = RightToLeft.No;
		qq().Size = new Size(451, 178);
		qq().TabIndex = 1;
		qq().TabStop = false;
		qq().Text = "Measurement Configuration";
		vn().Controls.Add(vt());
		vn().Controls.Add(vs());
		vn().Controls.Add(vo());
		vn().Controls.Add(vp());
		vn().Controls.Add(vq());
		vn().Controls.Add(vr());
		vn().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		vn().Location = new Point(6, 15);
		vn().Name = "PanelRectangle";
		vn().Size = new Size(307, 28);
		vn().TabIndex = 36;
		vn().Visible = false;
		vt().AutoSize = true;
		vt().Location = new Point(97, 7);
		vt().Name = "LabelWidthUnit";
		vt().Size = new Size(30, 16);
		vt().TabIndex = 5;
		vt().Text = "mm";
		vs().AutoSize = true;
		vs().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		vs().Location = new Point(251, 7);
		vs().Name = "Label10";
		vs().Size = new Size(30, 16);
		vs().TabIndex = 4;
		vs().Text = "mm";
		vo().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		vo().f(A_0: false);
		vo().Location = new Point(205, 3);
		vo().Name = "TextBoxNumericHeight";
		vo().e(A_0: false);
		vo().Size = new Size(44, 22);
		vo().TabIndex = 3;
		vo().TextAlign = HorizontalAlignment.Center;
		vp().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		vp().f(A_0: false);
		vp().Location = new Point(51, 3);
		vp().Name = "TextBoxNumericWidth";
		vp().e(A_0: false);
		vp().Size = new Size(44, 22);
		vp().TabIndex = 2;
		vp().TextAlign = HorizontalAlignment.Center;
		vq().AutoSize = true;
		vq().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		vq().Location = new Point(157, 7);
		vq().Name = "Label6";
		vq().Size = new Size(50, 16);
		vq().TabIndex = 1;
		vq().Text = "Height:";
		vr().AutoSize = true;
		vr().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		vr().Location = new Point(6, 7);
		vr().Name = "Label5";
		vr().Size = new Size(45, 16);
		vr().TabIndex = 0;
		vr().Text = "Width:";
		aek().AutoSize = true;
		aek().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aek().Location = new Point(193, 147);
		aek().Name = "ButtonCassetteDisplay";
		aek().Size = new Size(122, 26);
		aek().TabIndex = 38;
		aek().Text = "Display Params...";
		aek().UseVisualStyleBackColor = true;
		aek().Visible = false;
		ad9().AutoSize = true;
		ad9().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ad9().ColumnCount = 1;
		ad9().ColumnStyles.Add(new ColumnStyle());
		ad9().Controls.Add(aea(), 0, 1);
		ad9().Controls.Add(qs(), 0, 0);
		ad9().Location = new Point(321, 14);
		ad9().Name = "TableLayoutPanelWaferDetails";
		ad9().RowCount = 2;
		ad9().RowStyles.Add(new RowStyle());
		ad9().RowStyles.Add(new RowStyle());
		ad9().Size = new Size(123, 198);
		ad9().TabIndex = 37;
		aea().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aea().Location = new Point(3, 166);
		aea().Name = "ButtonWaferDetails";
		aea().Size = new Size(117, 29);
		aea().TabIndex = 14;
		aea().Text = "Wafer Details ...";
		aea().UseVisualStyleBackColor = true;
		aea().Visible = false;
		qs().BackColor = Color.Transparent;
		qs().Controls.Add(re());
		qs().Controls.Add(z1());
		qs().Controls.Add(q0());
		qs().Controls.Add(q1());
		qs().Controls.Add(q2());
		qs().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		qs().ForeColor = SystemColors.ControlText;
		qs().Location = new Point(3, 3);
		qs().Name = "GroupBoxIndexing";
		qs().RightToLeft = RightToLeft.No;
		qs().Size = new Size(117, 157);
		qs().TabIndex = 11;
		qs().TabStop = false;
		qs().Text = "Indexing:";
		re().AutoSize = true;
		re().BackColor = SystemColors.Window;
		re().Cursor = Cursors.Default;
		re().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		re().ForeColor = SystemColors.ControlText;
		re().Location = new Point(16, 103);
		re().Name = "WaferIndexingOptionSquare";
		re().RightToLeft = RightToLeft.No;
		re().Size = new Size(88, 20);
		re().TabIndex = 12;
		re().TabStop = true;
		re().Text = "Rectangle";
		re().UseVisualStyleBackColor = false;
		z1().Controls.Add(z2());
		z1().Location = new Point(5, 107);
		z1().Margin = new Padding(0);
		z1().Name = "GroupBoxAdvancedRectanglar";
		z1().Padding = new Padding(0);
		z1().Size = new Size(108, 45);
		z1().TabIndex = 16;
		z1().TabStop = false;
		z2().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		z2().Location = new Point(9, 17);
		z2().Name = "ButtonAdvancedRectangular";
		z2().Size = new Size(90, 23);
		z2().TabIndex = 13;
		z2().Text = "Advanced...";
		z2().UseVisualStyleBackColor = true;
		q0().AutoSize = true;
		q0().BackColor = Color.Transparent;
		q0().Cursor = Cursors.Default;
		q0().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		q0().ForeColor = SystemColors.ControlText;
		q0().Location = new Point(16, 22);
		q0().Name = "WaferIndexingOptionFlat";
		q0().RightToLeft = RightToLeft.No;
		q0().Size = new Size(48, 20);
		q0().TabIndex = 15;
		q0().TabStop = true;
		q0().Text = "Flat";
		q0().UseVisualStyleBackColor = false;
		q1().AutoSize = true;
		q1().BackColor = Color.Transparent;
		q1().Cursor = Cursors.Default;
		q1().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		q1().ForeColor = SystemColors.ControlText;
		q1().Location = new Point(16, 49);
		q1().Name = "WaferIndexingOptionNotch";
		q1().RightToLeft = RightToLeft.No;
		q1().Size = new Size(60, 20);
		q1().TabIndex = 14;
		q1().TabStop = true;
		q1().Text = "Notch";
		q1().UseVisualStyleBackColor = false;
		q2().AutoSize = true;
		q2().BackColor = Color.Transparent;
		q2().Cursor = Cursors.Default;
		q2().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		q2().ForeColor = SystemColors.ControlText;
		q2().Location = new Point(16, 76);
		q2().Name = "WaferIndexingOptionNone";
		q2().RightToLeft = RightToLeft.No;
		q2().Size = new Size(56, 20);
		q2().TabIndex = 13;
		q2().TabStop = true;
		q2().Text = "None";
		q2().UseVisualStyleBackColor = false;
		z0().AutoSize = true;
		z0().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		z0().Location = new Point(15, 151);
		z0().Name = "CheckBoxMapAutoFocusInCenterOnly";
		z0().Size = new Size(172, 20);
		z0().TabIndex = 3;
		z0().Text = "AutoFocus in center only";
		z0().UseVisualStyleBackColor = true;
		z0().Visible = false;
		qr().BackColor = SystemColors.Window;
		qr().Cursor = Cursors.Default;
		qr().DropDownStyle = ComboBoxStyle.DropDownList;
		qr().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		qr().ForeColor = SystemColors.WindowText;
		qr().Location = new Point(147, 18);
		qr().Name = "WaferDiaList";
		qr().RightToLeft = RightToLeft.No;
		qr().Size = new Size(127, 24);
		qr().TabIndex = 16;
		rf().BackColor = Color.Transparent;
		rf().Controls.Add(t6());
		rf().Controls.Add(rg());
		rf().Controls.Add(rj());
		rf().Controls.Add(rk());
		rf().Controls.Add(rl());
		rf().Controls.Add(ru());
		rf().Controls.Add(rv());
		rf().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		rf().ForeColor = SystemColors.ControlText;
		rf().Location = new Point(6, 41);
		rf().Name = "fmeBlanketWaferOptions";
		rf().RightToLeft = RightToLeft.No;
		rf().Size = new Size(308, 103);
		rf().TabIndex = 2;
		rf().TabStop = false;
		t6().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		t6().f(A_0: false);
		t6().Location = new Point(141, 74);
		t6().Name = "EdgeExclusionBox";
		t6().e(A_0: false);
		t6().Size = new Size(95, 22);
		t6().TabIndex = 11;
		t6().Text = "0";
		rg().BackColor = SystemColors.Window;
		rg().Cursor = Cursors.Default;
		rg().DropDownStyle = ComboBoxStyle.DropDownList;
		rg().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		rg().ForeColor = SystemColors.WindowText;
		rg().Location = new Point(141, 43);
		rg().Name = "NumPointsList";
		rg().RightToLeft = RightToLeft.No;
		rg().Size = new Size(127, 24);
		rg().TabIndex = 5;
		rj().BackColor = SystemColors.Window;
		rj().Cursor = Cursors.Default;
		rj().DropDownStyle = ComboBoxStyle.DropDownList;
		rj().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		rj().ForeColor = SystemColors.WindowText;
		rj().Location = new Point(141, 13);
		rj().Name = "CoordSystemList";
		rj().RightToLeft = RightToLeft.No;
		rj().Size = new Size(127, 24);
		rj().TabIndex = 4;
		rk().BackColor = Color.Transparent;
		rk().Cursor = Cursors.Default;
		rk().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		rk().ForeColor = SystemColors.WindowText;
		rk().Location = new Point(235, 77);
		rk().Name = "EdgeExclusionUnitsLbl";
		rk().RightToLeft = RightToLeft.No;
		rk().Size = new Size(35, 17);
		rk().TabIndex = 10;
		rk().Text = "mm";
		rk().TextAlign = ContentAlignment.TopRight;
		rl().BackColor = Color.Transparent;
		rl().Cursor = Cursors.Default;
		rl().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		rl().ForeColor = SystemColors.WindowText;
		rl().Location = new Point(12, 77);
		rl().Name = "EdgeExclusionLabel";
		rl().RightToLeft = RightToLeft.No;
		rl().Size = new Size(116, 17);
		rl().TabIndex = 9;
		rl().Text = "Edge exclusion:";
		rl().TextAlign = ContentAlignment.TopRight;
		ru().BackColor = Color.Transparent;
		ru().Cursor = Cursors.Default;
		ru().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ru().ForeColor = SystemColors.WindowText;
		ru().Location = new Point(9, 20);
		ru().Name = "Label1";
		ru().RightToLeft = RightToLeft.No;
		ru().Size = new Size(129, 17);
		ru().TabIndex = 8;
		ru().Text = "Coordinate system:";
		ru().TextAlign = ContentAlignment.TopRight;
		rv().BackColor = Color.Transparent;
		rv().Cursor = Cursors.Default;
		rv().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		rv().ForeColor = SystemColors.WindowText;
		rv().Location = new Point(22, 46);
		rv().Name = "NumPtsListLabel";
		rv().RightToLeft = RightToLeft.No;
		rv().Size = new Size(113, 17);
		rv().TabIndex = 7;
		rv().Text = "Number of points:";
		rv().TextAlign = ContentAlignment.TopRight;
		rw().BackColor = Color.Transparent;
		rw().Cursor = Cursors.Default;
		rw().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		rw().ForeColor = SystemColors.WindowText;
		rw().Location = new Point(28, 21);
		rw().Name = "LblWaferDia";
		rw().RightToLeft = RightToLeft.No;
		rw().Size = new Size(113, 17);
		rw().TabIndex = 18;
		rw().Text = "Wafer Diameter:";
		rw().TextAlign = ContentAlignment.TopRight;
		w2().AutoScroll = true;
		w2().Controls.Add(w3());
		w2().Location = new Point(4, 25);
		w2().Name = "TabPageVsTimeAnalysisSettings";
		w2().Padding = new Padding(3);
		w2().Size = new Size(779, 464);
		w2().TabIndex = 7;
		w2().Text = "Vs Time Analysis Settings";
		w2().UseVisualStyleBackColor = true;
		w3().Controls.Add(w4());
		w3().Controls.Add(x4());
		w3().Location = new Point(0, 10);
		w3().Name = "PanelVsTimeAnalysisSettings";
		w3().Size = new Size(267, 370);
		w3().TabIndex = 0;
		w4().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		w4().ColumnCount = 1;
		w4().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		w4().Controls.Add(w5(), 0, 5);
		w4().Controls.Add(w9(), 0, 1);
		w4().Controls.Add(xc(), 0, 2);
		w4().Controls.Add(xj(), 0, 3);
		w4().Controls.Add(xk(), 0, 4);
		w4().Controls.Add(xl(), 0, 0);
		w4().Controls.Add(xp(), 0, 6);
		w4().Controls.Add(xt(), 0, 7);
		w4().Controls.Add(xx(), 0, 8);
		w4().Controls.Add(x1(), 0, 9);
		w4().Dock = DockStyle.Top;
		w4().Location = new Point(0, 28);
		w4().Name = "TLPDepAnalysis";
		w4().RowCount = 10;
		w4().RowStyles.Add(new RowStyle(SizeType.Absolute, 36f));
		w4().RowStyles.Add(new RowStyle(SizeType.Absolute, 36f));
		w4().RowStyles.Add(new RowStyle(SizeType.Absolute, 35f));
		w4().RowStyles.Add(new RowStyle(SizeType.Absolute, 31f));
		w4().RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
		w4().RowStyles.Add(new RowStyle(SizeType.Absolute, 34f));
		w4().RowStyles.Add(new RowStyle(SizeType.Absolute, 35f));
		w4().RowStyles.Add(new RowStyle(SizeType.Absolute, 35f));
		w4().RowStyles.Add(new RowStyle(SizeType.Absolute, 32f));
		w4().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		w4().Size = new Size(267, 330);
		w4().TabIndex = 3;
		w5().AutoSize = true;
		w5().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		w5().ColumnCount = 3;
		w5().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 121f));
		w5().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95f));
		w5().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45f));
		w5().Controls.Add(w6(), 0, 0);
		w5().Controls.Add(w7(), 1, 0);
		w5().Controls.Add(w8(), 2, 0);
		w5().Dock = DockStyle.Fill;
		w5().Location = new Point(3, 163);
		w5().Name = "TableLayoutPanel6";
		w5().RowCount = 1;
		w5().RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		w5().Size = new Size(261, 28);
		w5().TabIndex = 3;
		w6().Dock = DockStyle.Bottom;
		w6().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		w6().Location = new Point(3, 6);
		w6().Name = "Label17";
		w6().Size = new Size(115, 22);
		w6().TabIndex = 99;
		w6().Text = "Scaling";
		w7().DecimalPlaces = 3;
		w7().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		w7().Increment = new decimal(new int[4] { 1, 0, 0, 196608 });
		w7().Location = new Point(124, 3);
		w7().Name = "VIsSetBox";
		w7().Size = new Size(88, 22);
		w7().TabIndex = 103;
		w7().Value = new decimal(new int[4] { 1, 0, 0, 0 });
		w8().Checked = true;
		w8().CheckState = CheckState.Checked;
		w8().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		w8().Location = new Point(219, 3);
		w8().Name = "VIsFixCheck";
		w8().Padding = new Padding(12, 0, 0, 0);
		w8().Size = new Size(35, 22);
		w8().TabIndex = 108;
		w8().UseVisualStyleBackColor = true;
		w9().AutoSize = true;
		w9().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		w9().ColumnCount = 2;
		w9().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.62151f));
		w9().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.37849f));
		w9().Controls.Add(xa(), 1, 0);
		w9().Controls.Add(xb(), 0, 0);
		w9().Dock = DockStyle.Fill;
		w9().Location = new Point(3, 39);
		w9().Name = "TableLayoutPanel7";
		w9().RowCount = 1;
		w9().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		w9().Size = new Size(261, 30);
		w9().TabIndex = 3;
		xa().Dock = DockStyle.Bottom;
		xa().DropDownStyle = ComboBoxStyle.DropDownList;
		xa().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xa().Items.AddRange(new object[4] { "", "GaAs", "AlGaAs x<0.7", "AlAs" });
		xa().Location = new Point(119, 3);
		xa().Name = "VIMaterialList";
		xa().Size = new Size(139, 24);
		xa().TabIndex = 94;
		xb().Dock = DockStyle.Bottom;
		xb().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xb().ImeMode = ImeMode.NoControl;
		xb().Location = new Point(3, 8);
		xb().Name = "Label19";
		xb().Size = new Size(110, 22);
		xb().TabIndex = 93;
		xb().Text = "Material:";
		xc().AutoSize = true;
		xc().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		xc().ColumnCount = 4;
		xc().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.08065f));
		xc().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.56452f));
		xc().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.37097f));
		xc().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.17742f));
		xc().Controls.Add(xd(), 0, 0);
		xc().Controls.Add(xe(), 1, 0);
		xc().Controls.Add(xf(), 2, 0);
		xc().Controls.Add(xi(), 3, 0);
		xc().Dock = DockStyle.Fill;
		xc().Location = new Point(3, 75);
		xc().Name = "TableLayoutPanel8";
		xc().RowCount = 1;
		xc().RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		xc().Size = new Size(261, 29);
		xc().TabIndex = 4;
		xd().Dock = DockStyle.Bottom;
		xd().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xd().Location = new Point(3, 7);
		xd().Name = "Label20";
		xd().Size = new Size(86, 22);
		xd().TabIndex = 95;
		xd().Text = "Angle(deg):";
		xe().Dock = DockStyle.Bottom;
		xe().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xe().f(A_0: false);
		xe().Location = new Point(95, 4);
		xe().Name = "VIAngleBox";
		xe().e(A_0: false);
		xe().Size = new Size(48, 22);
		xe().TabIndex = 96;
		xe().Text = "0";
		xf().AutoSize = true;
		xf().Dock = DockStyle.Bottom;
		xf().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xf().Location = new Point(149, 6);
		xf().Name = "VITEOption";
		xf().Size = new Size(50, 20);
		xf().TabIndex = 97;
		xf().Text = "TE";
		xf().UseVisualStyleBackColor = true;
		xi().AutoSize = true;
		xi().Dock = DockStyle.Bottom;
		xi().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xi().Location = new Point(205, 6);
		xi().Name = "VITMOption";
		xi().Size = new Size(53, 20);
		xi().TabIndex = 98;
		xi().Text = "TM";
		xi().UseVisualStyleBackColor = true;
		xj().AutoSize = true;
		xj().Dock = DockStyle.Bottom;
		xj().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xj().Location = new Point(12, 115);
		xj().Margin = new Padding(12, 3, 3, 3);
		xj().Name = "GrowthRateOnlyCheck";
		xj().Size = new Size(252, 20);
		xj().TabIndex = 6;
		xj().Text = "Dep. Rate Only (n Required)";
		xj().UseVisualStyleBackColor = true;
		xk().AutoSize = true;
		xk().Dock = DockStyle.Bottom;
		xk().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xk().Location = new Point(3, 144);
		xk().Name = "Label21";
		xk().Size = new Size(261, 16);
		xk().TabIndex = 107;
		xk().Text = "Fix?";
		xk().TextAlign = ContentAlignment.MiddleRight;
		xl().AutoSize = true;
		xl().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		xl().ColumnCount = 3;
		xl().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.62151f));
		xl().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.4502f));
		xl().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.33871f));
		xl().Controls.Add(xm(), 0, 0);
		xl().Controls.Add(xn(), 1, 0);
		xl().Controls.Add(xo(), 2, 0);
		xl().Dock = DockStyle.Fill;
		xl().Location = new Point(3, 3);
		xl().Name = "TableLayoutPanel9";
		xl().RowCount = 1;
		xl().RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		xl().Size = new Size(261, 30);
		xl().TabIndex = 2;
		xm().Dock = DockStyle.Bottom;
		xm().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xm().ImeMode = ImeMode.NoControl;
		xm().Location = new Point(3, 8);
		xm().Name = "Label22";
		xm().Size = new Size(111, 22);
		xm().TabIndex = 90;
		xm().Text = "Temperature:";
		xn().Dock = DockStyle.Bottom;
		xn().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xn().f(A_0: false);
		xn().Location = new Point(120, 5);
		xn().Name = "VITempBox";
		xn().e(A_0: false);
		xn().Size = new Size(92, 22);
		xn().TabIndex = 92;
		xo().Dock = DockStyle.Bottom;
		xo().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xo().ImeMode = ImeMode.NoControl;
		xo().Location = new Point(218, 8);
		xo().Name = "Label23";
		xo().Size = new Size(40, 22);
		xo().TabIndex = 91;
		xo().Text = "C";
		xp().AutoSize = true;
		xp().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		xp().ColumnCount = 3;
		xp().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120f));
		xp().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96f));
		xp().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45f));
		xp().Controls.Add(xq(), 0, 0);
		xp().Controls.Add(xr(), 1, 0);
		xp().Controls.Add(xs(), 2, 0);
		xp().Dock = DockStyle.Bottom;
		xp().Location = new Point(3, 198);
		xp().Name = "TableLayoutPanel10";
		xp().RowCount = 1;
		xp().RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		xp().Size = new Size(261, 28);
		xp().TabIndex = 108;
		xq().Dock = DockStyle.Bottom;
		xq().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xq().Location = new Point(3, 6);
		xq().Name = "LabelGrowthRate";
		xq().Size = new Size(114, 22);
		xq().TabIndex = 100;
		xq().Text = "Rate(nm/s)";
		xr().DecimalPlaces = 3;
		xr().Enabled = false;
		xr().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xr().Increment = new decimal(new int[4] { 1, 0, 0, 196608 });
		xr().Location = new Point(123, 3);
		xr().Maximum = new decimal(new int[4] { 100000, 0, 0, 0 });
		xr().Name = "VIGSetBox";
		xr().Size = new Size(88, 22);
		xr().TabIndex = 104;
		xr().Value = new decimal(new int[4] { 1, 0, 0, 0 });
		xs().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xs().Location = new Point(219, 3);
		xs().Name = "VIGFixCheck";
		xs().Padding = new Padding(12, 0, 0, 0);
		xs().Size = new Size(35, 22);
		xs().TabIndex = 109;
		xs().UseVisualStyleBackColor = true;
		xt().AutoSize = true;
		xt().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		xt().ColumnCount = 3;
		xt().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120f));
		xt().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96f));
		xt().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45f));
		xt().Controls.Add(xu(), 0, 0);
		xt().Controls.Add(xv(), 2, 0);
		xt().Controls.Add(xw(), 1, 0);
		xt().Dock = DockStyle.Bottom;
		xt().Location = new Point(3, 233);
		xt().Name = "TableLayoutPanel11";
		xt().RowCount = 1;
		xt().RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		xt().Size = new Size(261, 28);
		xt().TabIndex = 109;
		xu().Dock = DockStyle.Bottom;
		xu().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xu().Location = new Point(3, 6);
		xu().Name = "Label24";
		xu().Size = new Size(114, 22);
		xu().TabIndex = 102;
		xu().Text = "n";
		xv().Location = new Point(219, 3);
		xv().Name = "VInFixCheck";
		xv().Padding = new Padding(12, 0, 0, 0);
		xv().Size = new Size(35, 22);
		xv().TabIndex = 110;
		xv().UseVisualStyleBackColor = true;
		xw().DecimalPlaces = 3;
		xw().Enabled = false;
		xw().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xw().Increment = new decimal(new int[4] { 1, 0, 0, 196608 });
		xw().Location = new Point(123, 3);
		xw().Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
		xw().Name = "VInSetBox";
		xw().Size = new Size(88, 22);
		xw().TabIndex = 105;
		xw().Value = new decimal(new int[4] { 1, 0, 0, 0 });
		xx().AutoSize = true;
		xx().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		xx().ColumnCount = 3;
		xx().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120f));
		xx().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96f));
		xx().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45f));
		xx().Controls.Add(xy(), 2, 0);
		xx().Controls.Add(xz(), 0, 0);
		xx().Controls.Add(x0(), 1, 0);
		xx().Dock = DockStyle.Bottom;
		xx().Location = new Point(3, 267);
		xx().Name = "TableLayoutPanel12";
		xx().RowCount = 1;
		xx().RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		xx().Size = new Size(261, 26);
		xx().TabIndex = 110;
		xy().Location = new Point(219, 3);
		xy().Name = "VIkFixCheck";
		xy().Padding = new Padding(12, 0, 0, 0);
		xy().Size = new Size(35, 20);
		xy().TabIndex = 111;
		xy().UseVisualStyleBackColor = true;
		xz().Dock = DockStyle.Bottom;
		xz().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		xz().Location = new Point(3, 4);
		xz().Name = "Label25";
		xz().Size = new Size(114, 22);
		xz().TabIndex = 101;
		xz().Text = "k";
		x0().DecimalPlaces = 3;
		x0().Enabled = false;
		x0().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x0().Increment = new decimal(new int[4] { 1, 0, 0, 196608 });
		x0().Location = new Point(123, 3);
		x0().Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
		x0().Name = "VIkSetBox";
		x0().Size = new Size(88, 22);
		x0().TabIndex = 106;
		x0().Value = new decimal(new int[4] { 1, 0, 0, 0 });
		x1().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		x1().ColumnCount = 2;
		x1().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.11765f));
		x1().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.88235f));
		x1().Controls.Add(x2(), 0, 0);
		x1().Controls.Add(x3(), 1, 0);
		x1().Dock = DockStyle.Bottom;
		x1().Location = new Point(3, 299);
		x1().Name = "TableLayoutPanel13";
		x1().RowCount = 1;
		x1().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		x1().Size = new Size(261, 28);
		x1().TabIndex = 111;
		x2().Dock = DockStyle.Bottom;
		x2().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x2().Location = new Point(3, 6);
		x2().Name = "Label46";
		x2().Size = new Size(135, 22);
		x2().TabIndex = 0;
		x2().Text = "Unit of growth rate:";
		x3().Dock = DockStyle.Bottom;
		x3().DropDownStyle = ComboBoxStyle.DropDownList;
		x3().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x3().FormattingEnabled = true;
		x3().Items.AddRange(new object[3] { "Å/s", "nm/s", "µm/h" });
		x3().Location = new Point(144, 3);
		x3().Name = "CBGrowthRateUnit";
		x3().Size = new Size(114, 24);
		x3().TabIndex = 1;
		x4().AutoSize = true;
		x4().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		x4().ColumnCount = 2;
		x4().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.04724f));
		x4().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.95275f));
		x4().Controls.Add(x5(), 1, 0);
		x4().Controls.Add(x6(), 0, 0);
		x4().Dock = DockStyle.Top;
		x4().Location = new Point(0, 0);
		x4().Name = "TLPVstAnalysis";
		x4().RowCount = 1;
		x4().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		x4().Size = new Size(267, 28);
		x4().TabIndex = 2;
		x5().Dock = DockStyle.Bottom;
		x5().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x5().f(A_0: false);
		x5().Location = new Point(195, 3);
		x5().Name = "nValueBox";
		x5().e(A_0: false);
		x5().Size = new Size(69, 22);
		x5().TabIndex = 5;
		x6().Dock = DockStyle.Bottom;
		x6().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x6().Location = new Point(3, 6);
		x6().Name = "Label48";
		x6().Size = new Size(186, 22);
		x6().TabIndex = 6;
		x6().Text = "Refractive index of the layer:";
		ye().AutoScroll = true;
		ye().Controls.Add(yk());
		ye().Location = new Point(4, 25);
		ye().Name = "TabPageSpectrumProcessing";
		ye().Padding = new Padding(3);
		ye().Size = new Size(779, 464);
		ye().TabIndex = 8;
		ye().Text = "Spectrum Processing";
		ye().UseVisualStyleBackColor = true;
		yk().Controls.Add(yj());
		yk().Controls.Add(yf());
		yk().Location = new Point(0, 10);
		yk().Name = "PanelSpectrumProcessing";
		yk().Size = new Size(379, 159);
		yk().TabIndex = 2;
		yj().AutoSize = true;
		yj().BackColor = Color.White;
		yj().Location = new Point(16, 9);
		yj().Margin = new Padding(0);
		yj().Name = "CheckBoxBacksideSubtraction";
		yj().Padding = new Padding(8, 3, 3, 3);
		yj().Size = new Size(162, 26);
		yj().TabIndex = 0;
		yj().Text = "Backside Subtraction";
		yj().UseVisualStyleBackColor = false;
		yf().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		yf().Controls.Add(yg());
		yf().Controls.Add(yh());
		yf().Controls.Add(yi());
		yf().Enabled = false;
		yf().Location = new Point(3, 15);
		yf().Name = "GroupBoxSpectrumProcessing";
		yf().Size = new Size(373, 136);
		yf().TabIndex = 1;
		yf().TabStop = false;
		yg().Anchor = AnchorStyles.None;
		yg().BackColor = SystemColors.Control;
		yg().BackgroundImage = Resources.DropDownImage;
		yg().BackgroundImageLayout = ImageLayout.Center;
		yg().Cursor = Cursors.Default;
		yg().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		yg().ForeColor = SystemColors.ControlText;
		yg().Location = new Point(296, 48);
		yg().Margin = new Padding(0, 3, 2, 3);
		yg().Name = "ButtonGetBacksideSubtractionMat";
		yg().RightToLeft = RightToLeft.No;
		yg().Size = new Size(19, 22);
		yg().TabIndex = 260;
		yg().TextAlign = ContentAlignment.BottomCenter;
		aej().SetToolTip(yg(), "Drop-down list of Materials");
		yg().UseVisualStyleBackColor = true;
		yh().AcceptsReturn = true;
		yh().Anchor = AnchorStyles.None;
		yh().BackColor = SystemColors.Window;
		yh().Cursor = Cursors.IBeam;
		yh().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		yh().ForeColor = SystemColors.WindowText;
		yh().Location = new Point(100, 48);
		yh().Margin = new Padding(2, 3, 0, 3);
		yh().MaxLength = 0;
		yh().Name = "TextBoxBacksideSubtractionSubstrate";
		yh().ReadOnly = true;
		yh().RightToLeft = RightToLeft.No;
		yh().Size = new Size(196, 22);
		yh().TabIndex = 259;
		yh().TabStop = false;
		yh().Text = "ITO fluoro surf- Pilkington.nnn";
		aej().SetToolTip(yh(), "Layer material - Click to open search dialog");
		yi().Anchor = AnchorStyles.None;
		yi().AutoSize = true;
		yi().BackColor = Color.Transparent;
		yi().Cursor = Cursors.Default;
		yi().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		yi().ForeColor = SystemColors.ControlText;
		yi().Location = new Point(30, 51);
		yi().Margin = new Padding(2, 0, 1, 0);
		yi().Name = "Label49";
		yi().RightToLeft = RightToLeft.No;
		yi().Size = new Size(68, 16);
		yi().TabIndex = 261;
		yi().Text = "Substrate:";
		yi().TextAlign = ContentAlignment.MiddleCenter;
		ael().Controls.Add(aen());
		ael().Location = new Point(4, 25);
		ael().Name = "TabPageMapLocations";
		ael().Padding = new Padding(3);
		ael().Size = new Size(779, 464);
		ael().TabIndex = 9;
		ael().Text = "Map Locations";
		ael().UseVisualStyleBackColor = true;
		aen().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		aen().Controls.Add(aeo());
		aen().Controls.Add(ae2());
		aen().Location = new Point(135, 60);
		aen().Name = "PanelMapLocations";
		aen().Size = new Size(458, 260);
		aen().TabIndex = 3;
		aeo().BackColor = Color.Transparent;
		aeo().Controls.Add(aep());
		aeo().Controls.Add(aeq());
		aeo().Controls.Add(aer());
		aeo().Controls.Add(aes());
		aeo().Controls.Add(aet());
		aeo().Controls.Add(aeu());
		aeo().Controls.Add(aev());
		aeo().Controls.Add(aew());
		aeo().Controls.Add(aex());
		aeo().Controls.Add(aey());
		aeo().Controls.Add(aez());
		aeo().Controls.Add(ae0());
		aeo().Controls.Add(ae1());
		aeo().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aeo().ForeColor = SystemColors.ControlText;
		aeo().Location = new Point(3, 165);
		aeo().Name = "PatternAvoidanceFrame1";
		aeo().RightToLeft = RightToLeft.No;
		aeo().Size = new Size(451, 91);
		aeo().TabIndex = 73;
		aeo().TabStop = false;
		aep().Enabled = false;
		aep().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aep().f(A_0: false);
		aep().Location = new Point(84, 55);
		aep().Name = "MapPatternSizeBox1";
		aep().e(A_0: false);
		aep().Size = new Size(50, 22);
		aep().TabIndex = 74;
		aep().Text = "0";
		aeq().Enabled = false;
		aeq().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aeq().f(A_0: false);
		aeq().Location = new Point(299, 55);
		aeq().Name = "MapPatternSpacingBox1";
		aeq().e(A_0: false);
		aeq().Size = new Size(49, 22);
		aeq().TabIndex = 73;
		aer().Enabled = false;
		aer().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aer().f(A_0: false);
		aer().Location = new Point(84, 25);
		aer().Name = "MapSpotSizeBox1";
		aer().e(A_0: false);
		aer().Size = new Size(53, 22);
		aer().TabIndex = 72;
		aer().Text = "0";
		aes().BackColor = Color.Transparent;
		aes().Cursor = Cursors.Default;
		aes().Enabled = false;
		aes().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aes().ForeColor = SystemColors.ControlText;
		aes().Location = new Point(185, 25);
		aes().Name = "MapRectangularOption1";
		aes().RightToLeft = RightToLeft.No;
		aes().Size = new Size(100, 23);
		aes().TabIndex = 45;
		aes().TabStop = true;
		aes().Text = "Rectangular";
		aes().UseVisualStyleBackColor = false;
		aet().BackColor = Color.Transparent;
		aet().Cursor = Cursors.Default;
		aet().Enabled = false;
		aet().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aet().ForeColor = SystemColors.ControlText;
		aet().Location = new Point(185, 54);
		aet().Name = "MapRadialOption1";
		aet().RightToLeft = RightToLeft.No;
		aet().Size = new Size(76, 18);
		aet().TabIndex = 44;
		aet().TabStop = true;
		aet().Text = "Radial";
		aet().UseVisualStyleBackColor = false;
		aeu().AutoSize = true;
		aeu().BackColor = SystemColors.Window;
		aeu().Cursor = Cursors.Default;
		aeu().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		aeu().ForeColor = SystemColors.ControlText;
		aeu().Location = new Point(221, -3);
		aeu().Name = "InvalidMeasRetryCheck1";
		aeu().RightToLeft = RightToLeft.No;
		aeu().Size = new Size(148, 20);
		aeu().TabIndex = 71;
		aeu().Text = "Invalid Meas. Retry";
		aeu().UseVisualStyleBackColor = false;
		aev().AutoSize = true;
		aev().BackColor = SystemColors.Window;
		aev().Cursor = Cursors.Default;
		aev().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		aev().ForeColor = SystemColors.ControlText;
		aev().Location = new Point(14, -3);
		aev().Name = "PatternAvoidCheck1";
		aev().RightToLeft = RightToLeft.No;
		aev().Size = new Size(144, 20);
		aev().TabIndex = 70;
		aev().Text = "Pattern Avoidance";
		aev().UseVisualStyleBackColor = false;
		aew().BackColor = Color.Transparent;
		aew().Cursor = Cursors.Default;
		aew().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aew().ForeColor = SystemColors.ControlText;
		aew().Location = new Point(9, 26);
		aew().Name = "Label55";
		aew().RightToLeft = RightToLeft.No;
		aew().Size = new Size(74, 17);
		aew().TabIndex = 51;
		aew().Text = "Spot Size:";
		aew().TextAlign = ContentAlignment.TopRight;
		aex().BackColor = Color.Transparent;
		aex().Cursor = Cursors.Default;
		aex().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aex().ForeColor = SystemColors.ControlText;
		aex().Location = new Point(0, 55);
		aex().Name = "Label56";
		aex().RightToLeft = RightToLeft.No;
		aex().Size = new Size(84, 17);
		aex().TabIndex = 50;
		aex().Text = "Pattern Size:";
		aex().TextAlign = ContentAlignment.TopRight;
		aey().BackColor = Color.Transparent;
		aey().Cursor = Cursors.Default;
		aey().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aey().ForeColor = SystemColors.ControlText;
		aey().Location = new Point(293, 27);
		aey().Name = "Label57";
		aey().RightToLeft = RightToLeft.No;
		aey().Size = new Size(64, 20);
		aey().TabIndex = 49;
		aey().Text = "Spacing:";
		aey().TextAlign = ContentAlignment.TopRight;
		aez().BackColor = Color.Transparent;
		aez().Cursor = Cursors.Default;
		aez().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aez().ForeColor = SystemColors.WindowText;
		aez().Location = new Point(349, 58);
		aez().Name = "MapPatternSpacingLabel1";
		aez().RightToLeft = RightToLeft.No;
		aez().Size = new Size(54, 17);
		aez().TabIndex = 48;
		aez().Text = "degrees";
		ae0().BackColor = Color.Transparent;
		ae0().Cursor = Cursors.Default;
		ae0().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae0().ForeColor = SystemColors.WindowText;
		ae0().Location = new Point(138, 26);
		ae0().Name = "Label61";
		ae0().RightToLeft = RightToLeft.No;
		ae0().Size = new Size(30, 17);
		ae0().TabIndex = 47;
		ae0().Text = "mm";
		ae0().TextAlign = ContentAlignment.TopRight;
		ae1().BackColor = Color.Transparent;
		ae1().Cursor = Cursors.Default;
		ae1().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae1().ForeColor = SystemColors.WindowText;
		ae1().Location = new Point(138, 55);
		ae1().Name = "Label66";
		ae1().RightToLeft = RightToLeft.No;
		ae1().Size = new Size(30, 17);
		ae1().TabIndex = 46;
		ae1().Text = "mm";
		ae1().TextAlign = ContentAlignment.TopRight;
		ae2().BackColor = Color.Transparent;
		ae2().Controls.Add(ae3());
		ae2().Controls.Add(afa());
		ae2().Controls.Add(afb());
		ae2().Controls.Add(afj());
		ae2().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ae2().ForeColor = SystemColors.ControlText;
		ae2().Location = new Point(3, 3);
		ae2().Name = "MeasurementInfoFrame1";
		ae2().RightToLeft = RightToLeft.No;
		ae2().Size = new Size(320, 151);
		ae2().TabIndex = 1;
		ae2().TabStop = false;
		ae2().Text = "Measurement Configuration";
		ae3().Controls.Add(ae4());
		ae3().Controls.Add(ae5());
		ae3().Controls.Add(ae6());
		ae3().Controls.Add(ae7());
		ae3().Controls.Add(ae8());
		ae3().Controls.Add(ae9());
		ae3().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae3().Location = new Point(6, 15);
		ae3().Name = "PanelRectangle1";
		ae3().Size = new Size(307, 28);
		ae3().TabIndex = 36;
		ae3().Visible = false;
		ae4().AutoSize = true;
		ae4().Location = new Point(97, 7);
		ae4().Name = "LabelWidthUnit1";
		ae4().Size = new Size(30, 16);
		ae4().TabIndex = 5;
		ae4().Text = "mm";
		ae5().AutoSize = true;
		ae5().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae5().Location = new Point(251, 7);
		ae5().Name = "Label74";
		ae5().Size = new Size(30, 16);
		ae5().TabIndex = 4;
		ae5().Text = "mm";
		ae6().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae6().f(A_0: false);
		ae6().Location = new Point(205, 3);
		ae6().Name = "TextBoxNumericHeight1";
		ae6().e(A_0: false);
		ae6().Size = new Size(44, 22);
		ae6().TabIndex = 3;
		ae6().TextAlign = HorizontalAlignment.Center;
		ae7().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae7().f(A_0: false);
		ae7().Location = new Point(51, 3);
		ae7().Name = "TextBoxNumericWidth1";
		ae7().e(A_0: false);
		ae7().Size = new Size(44, 22);
		ae7().TabIndex = 2;
		ae7().TextAlign = HorizontalAlignment.Center;
		ae8().AutoSize = true;
		ae8().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae8().Location = new Point(157, 7);
		ae8().Name = "Label75";
		ae8().Size = new Size(50, 16);
		ae8().TabIndex = 1;
		ae8().Text = "Height:";
		ae9().AutoSize = true;
		ae9().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae9().Location = new Point(6, 7);
		ae9().Name = "Label76";
		ae9().Size = new Size(45, 16);
		ae9().TabIndex = 0;
		ae9().Text = "Width:";
		afa().BackColor = SystemColors.Window;
		afa().Cursor = Cursors.Default;
		afa().DropDownStyle = ComboBoxStyle.DropDownList;
		afa().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afa().ForeColor = SystemColors.WindowText;
		afa().Location = new Point(147, 18);
		afa().Name = "WaferDiaList1";
		afa().RightToLeft = RightToLeft.No;
		afa().Size = new Size(127, 24);
		afa().TabIndex = 16;
		afb().BackColor = Color.Transparent;
		afb().Controls.Add(afc());
		afb().Controls.Add(afd());
		afb().Controls.Add(afe());
		afb().Controls.Add(aff());
		afb().Controls.Add(afg());
		afb().Controls.Add(afh());
		afb().Controls.Add(afi());
		afb().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afb().ForeColor = SystemColors.ControlText;
		afb().Location = new Point(6, 41);
		afb().Name = "fmeBlanketWaferOptions1";
		afb().RightToLeft = RightToLeft.No;
		afb().Size = new Size(308, 103);
		afb().TabIndex = 2;
		afb().TabStop = false;
		afc().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afc().f(A_0: false);
		afc().Location = new Point(141, 74);
		afc().Name = "EdgeExclusionBox1";
		afc().e(A_0: false);
		afc().Size = new Size(95, 22);
		afc().TabIndex = 11;
		afc().Text = "0";
		afd().BackColor = SystemColors.Window;
		afd().Cursor = Cursors.Default;
		afd().DropDownStyle = ComboBoxStyle.DropDownList;
		afd().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afd().ForeColor = SystemColors.WindowText;
		afd().Location = new Point(141, 43);
		afd().Name = "NumPointsList1";
		afd().RightToLeft = RightToLeft.No;
		afd().Size = new Size(127, 24);
		afd().TabIndex = 5;
		afe().BackColor = SystemColors.Window;
		afe().Cursor = Cursors.Default;
		afe().DropDownStyle = ComboBoxStyle.DropDownList;
		afe().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afe().ForeColor = SystemColors.WindowText;
		afe().Location = new Point(141, 13);
		afe().Name = "CoordSystemList1";
		afe().RightToLeft = RightToLeft.No;
		afe().Size = new Size(127, 24);
		afe().TabIndex = 4;
		aff().BackColor = Color.Transparent;
		aff().Cursor = Cursors.Default;
		aff().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aff().ForeColor = SystemColors.WindowText;
		aff().Location = new Point(235, 77);
		aff().Name = "EdgeExclusionUnitsLbl1";
		aff().RightToLeft = RightToLeft.No;
		aff().Size = new Size(35, 17);
		aff().TabIndex = 10;
		aff().Text = "mm";
		aff().TextAlign = ContentAlignment.TopRight;
		afg().BackColor = Color.Transparent;
		afg().Cursor = Cursors.Default;
		afg().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afg().ForeColor = SystemColors.WindowText;
		afg().Location = new Point(12, 77);
		afg().Name = "EdgeExclusionLabel1";
		afg().RightToLeft = RightToLeft.No;
		afg().Size = new Size(116, 17);
		afg().TabIndex = 9;
		afg().Text = "Edge exclusion:";
		afg().TextAlign = ContentAlignment.TopRight;
		afh().BackColor = Color.Transparent;
		afh().Cursor = Cursors.Default;
		afh().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afh().ForeColor = SystemColors.WindowText;
		afh().Location = new Point(9, 20);
		afh().Name = "Label79";
		afh().RightToLeft = RightToLeft.No;
		afh().Size = new Size(129, 17);
		afh().TabIndex = 8;
		afh().Text = "Coordinate system:";
		afh().TextAlign = ContentAlignment.TopRight;
		afi().BackColor = Color.Transparent;
		afi().Cursor = Cursors.Default;
		afi().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afi().ForeColor = SystemColors.WindowText;
		afi().Location = new Point(22, 46);
		afi().Name = "NumPtsListLabel1";
		afi().RightToLeft = RightToLeft.No;
		afi().Size = new Size(113, 17);
		afi().TabIndex = 7;
		afi().Text = "Number of points:";
		afi().TextAlign = ContentAlignment.TopRight;
		afj().BackColor = Color.Transparent;
		afj().Cursor = Cursors.Default;
		afj().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afj().ForeColor = SystemColors.WindowText;
		afj().Location = new Point(28, 21);
		afj().Name = "LblWaferDia1";
		afj().RightToLeft = RightToLeft.No;
		afj().Size = new Size(113, 17);
		afj().TabIndex = 18;
		afj().Text = "Wafer Diameter:";
		afj().TextAlign = ContentAlignment.TopRight;
		aem().Controls.Add(afk());
		aem().Location = new Point(4, 25);
		aem().Name = "TabPageWaferMapOptions";
		aem().Padding = new Padding(3);
		aem().Size = new Size(779, 464);
		aem().TabIndex = 10;
		aem().Text = "Wafer Map Options";
		aem().UseVisualStyleBackColor = true;
		afk().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		afk().Controls.Add(afl());
		afk().Controls.Add(afp());
		afk().Controls.Add(af3());
		afk().Location = new Point(76, 110);
		afk().Name = "PanelWaferMapOptions";
		afk().Size = new Size(627, 221);
		afk().TabIndex = 3;
		afl().BackColor = Color.Transparent;
		afl().Controls.Add(afm());
		afl().Controls.Add(afn());
		afl().Controls.Add(afo());
		afl().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		afl().ForeColor = SystemColors.ControlText;
		afl().Location = new Point(3, 72);
		afl().Name = "DataToSaveFrame2";
		afl().RightToLeft = RightToLeft.No;
		afl().Size = new Size(324, 78);
		afl().TabIndex = 72;
		afl().TabStop = false;
		afl().Text = "Automatic Data Saving";
		afm().AutoSize = true;
		afm().BackColor = Color.Transparent;
		afm().Cursor = Cursors.Default;
		afm().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afm().ForeColor = SystemColors.ControlText;
		afm().Location = new Point(196, 22);
		afm().Name = "SaveSpectraCheckBox2";
		afm().RightToLeft = RightToLeft.No;
		afm().Size = new Size(102, 20);
		afm().TabIndex = 75;
		afm().Text = "Save spectra";
		afm().UseVisualStyleBackColor = false;
		afn().AutoSize = true;
		afn().BackColor = Color.Transparent;
		afn().Cursor = Cursors.Default;
		afn().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afn().ForeColor = SystemColors.ControlText;
		afn().Location = new Point(15, 48);
		afn().Name = "SaveRunningCheckBox2";
		afn().RightToLeft = RightToLeft.No;
		afn().Size = new Size(173, 20);
		afn().TabIndex = 74;
		afn().Text = "Save intermediate results";
		afn().UseVisualStyleBackColor = false;
		afn().Visible = false;
		afo().AutoSize = true;
		afo().BackColor = Color.Transparent;
		afo().Cursor = Cursors.Default;
		afo().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afo().ForeColor = SystemColors.ControlText;
		afo().Location = new Point(15, 22);
		afo().Name = "SaveResultsCheckBox2";
		afo().RightToLeft = RightToLeft.No;
		afo().Size = new Size(127, 20);
		afo().TabIndex = 73;
		afo().Text = "Save map to disk";
		aef().SetToolTip(afo(), "Automatically Save Wafer Map as the name specified in the WaferMap window (Map Info: File)");
		afo().UseVisualStyleBackColor = false;
		afp().BackColor = Color.Transparent;
		afp().Controls.Add(afq());
		afp().Controls.Add(afr());
		afp().Controls.Add(af2());
		afp().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		afp().ForeColor = SystemColors.ControlText;
		afp().Location = new Point(333, 5);
		afp().Name = "DataToMapFrame2";
		afp().RightToLeft = RightToLeft.No;
		afp().Size = new Size(286, 208);
		afp().TabIndex = 20;
		afp().TabStop = false;
		afp().Text = "Additional Parameters To Be Mapped";
		afq().BackColor = Color.Transparent;
		afq().Cursor = Cursors.Default;
		afq().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afq().ForeColor = SystemColors.ControlText;
		afq().Location = new Point(24, 187);
		afq().Name = "CheckBoxReportFocusLensPos2";
		afq().RightToLeft = RightToLeft.No;
		afq().Size = new Size(228, 21);
		afq().TabIndex = 36;
		afq().Text = "Focus Height";
		afq().UseVisualStyleBackColor = false;
		afq().Visible = false;
		afr().BackColor = Color.Transparent;
		afr().Controls.Add(afs());
		afr().Controls.Add(aft());
		afr().Controls.Add(afu());
		afr().Controls.Add(afv());
		afr().Controls.Add(afw());
		afr().Controls.Add(afx());
		afr().Controls.Add(afy());
		afr().Controls.Add(afz());
		afr().Controls.Add(af0());
		afr().Controls.Add(af1());
		afr().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afr().ForeColor = SystemColors.ControlText;
		afr().Location = new Point(12, 23);
		afr().Name = "GroupBox11";
		afr().RightToLeft = RightToLeft.No;
		afr().Size = new Size(262, 137);
		afr().TabIndex = 24;
		afr().TabStop = false;
		afs().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afs().f(A_0: false);
		afs().Location = new Point(173, 63);
		afs().Name = "AveReflEndWaveBox2";
		afs().e(A_0: false);
		afs().Size = new Size(52, 22);
		afs().TabIndex = 35;
		afs().Text = "400";
		aft().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aft().f(A_0: false);
		aft().Location = new Point(173, 100);
		aft().Name = "AveReflRefWaveBox2";
		aft().e(A_0: false);
		aft().Size = new Size(52, 22);
		aft().TabIndex = 36;
		afu().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afu().f(A_0: false);
		afu().Location = new Point(173, 26);
		afu().Name = "AveReflStartWaveBox2";
		afu().e(A_0: false);
		afu().Size = new Size(52, 22);
		afu().TabIndex = 34;
		afu().Text = "400";
		afv().BackColor = SystemColors.Window;
		afv().Cursor = Cursors.Default;
		afv().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afv().ForeColor = SystemColors.ControlText;
		afv().Location = new Point(12, -3);
		afv().Name = "AvgReflCheck2";
		afv().RightToLeft = RightToLeft.No;
		afv().Size = new Size(193, 21);
		afv().TabIndex = 23;
		afv().Text = "Average reflectance ratio";
		afv().UseVisualStyleBackColor = false;
		afw().BackColor = Color.Transparent;
		afw().Cursor = Cursors.Default;
		afw().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afw().ForeColor = SystemColors.ControlText;
		afw().Location = new Point(6, 29);
		afw().Name = "Label72";
		afw().RightToLeft = RightToLeft.No;
		afw().Size = new Size(161, 16);
		afw().TabIndex = 33;
		afw().Text = "Starting wavelength:";
		afw().TextAlign = ContentAlignment.TopRight;
		afx().BackColor = Color.Transparent;
		afx().Cursor = Cursors.Default;
		afx().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afx().ForeColor = SystemColors.WindowText;
		afx().Location = new Point(228, 29);
		afx().Name = "Label77";
		afx().RightToLeft = RightToLeft.No;
		afx().Size = new Size(28, 17);
		afx().TabIndex = 32;
		afx().Text = "nm";
		afy().BackColor = Color.Transparent;
		afy().Cursor = Cursors.Default;
		afy().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afy().ForeColor = SystemColors.ControlText;
		afy().Location = new Point(6, 66);
		afy().Name = "Label78";
		afy().RightToLeft = RightToLeft.No;
		afy().Size = new Size(161, 16);
		afy().TabIndex = 31;
		afy().Text = "Ending wavelength:";
		afy().TextAlign = ContentAlignment.TopRight;
		afz().BackColor = Color.Transparent;
		afz().Cursor = Cursors.Default;
		afz().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		afz().ForeColor = SystemColors.WindowText;
		afz().Location = new Point(228, 66);
		afz().Name = "Label80";
		afz().RightToLeft = RightToLeft.No;
		afz().Size = new Size(28, 17);
		afz().TabIndex = 30;
		afz().Text = "nm";
		af0().BackColor = Color.Transparent;
		af0().Cursor = Cursors.Default;
		af0().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		af0().ForeColor = SystemColors.ControlText;
		af0().Location = new Point(6, 103);
		af0().Name = "Label82";
		af0().RightToLeft = RightToLeft.No;
		af0().Size = new Size(161, 16);
		af0().TabIndex = 29;
		af0().Text = "Reference wavelength:";
		af0().TextAlign = ContentAlignment.TopRight;
		af1().BackColor = Color.Transparent;
		af1().Cursor = Cursors.Default;
		af1().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		af1().ForeColor = SystemColors.WindowText;
		af1().Location = new Point(228, 103);
		af1().Name = "Label83";
		af1().RightToLeft = RightToLeft.No;
		af1().Size = new Size(28, 17);
		af1().TabIndex = 28;
		af1().Text = "nm";
		af2().BackColor = Color.Transparent;
		af2().Cursor = Cursors.Default;
		af2().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		af2().ForeColor = SystemColors.ControlText;
		af2().Location = new Point(24, 165);
		af2().Name = "ckSolveForGOF2";
		af2().RightToLeft = RightToLeft.No;
		af2().Size = new Size(228, 21);
		af2().TabIndex = 20;
		af2().Text = "GOF ( solve for Goodness Of Fit)";
		af2().UseVisualStyleBackColor = false;
		af3().BackColor = Color.Transparent;
		af3().Controls.Add(af4());
		af3().Controls.Add(af5());
		af3().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		af3().ForeColor = SystemColors.ControlText;
		af3().Location = new Point(3, 5);
		af3().Name = "MeasurementInfoFrame2";
		af3().RightToLeft = RightToLeft.No;
		af3().Size = new Size(324, 58);
		af3().TabIndex = 1;
		af3().TabStop = false;
		af3().Text = "Measurement Configuration";
		af4().AutoSize = true;
		af4().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		af4().Location = new Point(193, 22);
		af4().Name = "ButtonCassetteDisplay2";
		af4().Size = new Size(122, 26);
		af4().TabIndex = 38;
		af4().Text = "Display Params...";
		af4().UseVisualStyleBackColor = true;
		af4().Visible = false;
		af5().AutoSize = true;
		af5().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		af5().Location = new Point(15, 26);
		af5().Name = "CheckBoxMapAutoFocusInCenterOnly2";
		af5().Size = new Size(172, 20);
		af5().TabIndex = 3;
		af5().Text = "AutoFocus in center only";
		af5().UseVisualStyleBackColor = true;
		af5().Visible = false;
		k6().Name = "ContextMenuStripNK";
		k6().Size = new Size(61, 4);
		iq().AutoPopDelay = 15000;
		iq().InitialDelay = 500;
		iq().ReshowDelay = 100;
		zi().ContainerControl = this;
		aef().AutoPopDelay = 15000;
		aef().InitialDelay = 500;
		aef().ReshowDelay = 100;
		aeg().AutoPopDelay = 15000;
		aeg().InitialDelay = 500;
		aeg().ReshowDelay = 100;
		aeh().AutoPopDelay = 15000;
		aeh().InitialDelay = 500;
		aeh().ReshowDelay = 100;
		aei().AutoPopDelay = 15000;
		aei().InitialDelay = 500;
		aei().ReshowDelay = 100;
		aej().AutoPopDelay = 15000;
		aej().InitialDelay = 500;
		aej().ReshowDelay = 100;
		ahn().AutoPopDelay = 15000;
		ahn().InitialDelay = 500;
		ahn().ReshowDelay = 100;
		base.AcceptButton = b5();
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = SystemColors.Control;
		base.CancelButton = b6();
		base.CausesValidation = false;
		base.ClientSize = new Size(811, 636);
		base.Controls.Add(ca());
		Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Icon = Resources.EditRecipeIcon;
		base.Margin = new Padding(3, 4, 3, 4);
		base.MinimizeBox = false;
		base.Name = "DialogEditRecipe";
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Show;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Edit Recipe";
		b4().ResumeLayout(performLayout: false);
		ca().ResumeLayout(performLayout: false);
		ca().PerformLayout();
		k7().ResumeLayout(performLayout: false);
		k7().PerformLayout();
		cc().ResumeLayout(performLayout: false);
		cc().PerformLayout();
		py().ResumeLayout(performLayout: false);
		py().PerformLayout();
		cb().ResumeLayout(performLayout: false);
		cb().PerformLayout();
		ch().ResumeLayout(performLayout: false);
		ci().ResumeLayout(performLayout: false);
		ci().PerformLayout();
		cn().ResumeLayout(performLayout: false);
		cn().PerformLayout();
		@is().ResumeLayout(performLayout: false);
		@is().PerformLayout();
		((ISupportInitialize)k4()).EndInit();
		((ISupportInitialize)k5()).EndInit();
		((ISupportInitialize)k3()).EndInit();
		((ISupportInitialize)kt()).EndInit();
		((ISupportInitialize)kk()).EndInit();
		((ISupportInitialize)kg()).EndInit();
		((ISupportInitialize)j3()).EndInit();
		co().ResumeLayout(performLayout: false);
		zl().ResumeLayout(performLayout: false);
		zl().PerformLayout();
		cj().ResumeLayout(performLayout: false);
		cj().PerformLayout();
		li().ResumeLayout(performLayout: false);
		li().PerformLayout();
		lj().ResumeLayout(performLayout: false);
		k9().ResumeLayout(performLayout: false);
		k9().PerformLayout();
		lb().ResumeLayout(performLayout: false);
		lb().PerformLayout();
		ld().ResumeLayout(performLayout: false);
		ld().PerformLayout();
		k8().ResumeLayout(performLayout: false);
		c9().ResumeLayout(performLayout: false);
		dc().ResumeLayout(performLayout: false);
		dc().PerformLayout();
		cq().ResumeLayout(performLayout: false);
		cq().PerformLayout();
		cu().ResumeLayout(performLayout: false);
		cu().PerformLayout();
		cx().ResumeLayout(performLayout: false);
		cz().ResumeLayout(performLayout: false);
		cz().PerformLayout();
		dl().ResumeLayout(performLayout: false);
		dl().PerformLayout();
		vu().ResumeLayout(performLayout: false);
		vu().PerformLayout();
		lk().ResumeLayout(performLayout: false);
		lk().PerformLayout();
		ll().ResumeLayout(performLayout: false);
		ll().PerformLayout();
		pl().ResumeLayout(performLayout: false);
		pl().PerformLayout();
		dp().ResumeLayout(performLayout: false);
		dp().PerformLayout();
		ln().ResumeLayout(performLayout: false);
		ln().PerformLayout();
		lo().ResumeLayout(performLayout: false);
		lp().ResumeLayout(performLayout: false);
		lp().PerformLayout();
		z3().ResumeLayout(performLayout: false);
		z3().PerformLayout();
		aeb().ResumeLayout(performLayout: false);
		aho().ResumeLayout(performLayout: false);
		aho().PerformLayout();
		aec().ResumeLayout(performLayout: false);
		aec().PerformLayout();
		acc().ResumeLayout(performLayout: false);
		acc().PerformLayout();
		z7().ResumeLayout(performLayout: false);
		ado().ResumeLayout(performLayout: false);
		ado().PerformLayout();
		adz().ResumeLayout(performLayout: false);
		adz().PerformLayout();
		acg().ResumeLayout(performLayout: false);
		acg().PerformLayout();
		acr().ResumeLayout(performLayout: false);
		acr().PerformLayout();
		ac2().ResumeLayout(performLayout: false);
		ac2().PerformLayout();
		add().ResumeLayout(performLayout: false);
		add().PerformLayout();
		aai().ResumeLayout(performLayout: false);
		aai().PerformLayout();
		aat().ResumeLayout(performLayout: false);
		aat().PerformLayout();
		aa3().ResumeLayout(performLayout: false);
		aa3().PerformLayout();
		abd().ResumeLayout(performLayout: false);
		abd().PerformLayout();
		abn().ResumeLayout(performLayout: false);
		abn().PerformLayout();
		abx().ResumeLayout(performLayout: false);
		abx().PerformLayout();
		lq().ResumeLayout(performLayout: false);
		lq().PerformLayout();
		yl().ResumeLayout(performLayout: false);
		yl().PerformLayout();
		ym().ResumeLayout(performLayout: false);
		ym().PerformLayout();
		l4().ResumeLayout(performLayout: false);
		l4().PerformLayout();
		l5().ResumeLayout(performLayout: false);
		l5().PerformLayout();
		mj().ResumeLayout(performLayout: false);
		mj().PerformLayout();
		mk().ResumeLayout(performLayout: false);
		mk().PerformLayout();
		mx().ResumeLayout(performLayout: false);
		mx().PerformLayout();
		my().ResumeLayout(performLayout: false);
		my().PerformLayout();
		oe().ResumeLayout(performLayout: false);
		oe().PerformLayout();
		oh().ResumeLayout(performLayout: false);
		oh().PerformLayout();
		nb().ResumeLayout(performLayout: false);
		nb().PerformLayout();
		nc().ResumeLayout(performLayout: false);
		nc().PerformLayout();
		ns().ResumeLayout(performLayout: false);
		ns().PerformLayout();
		nt().ResumeLayout(performLayout: false);
		nt().PerformLayout();
		yn().ResumeLayout(performLayout: false);
		yn().PerformLayout();
		agc().ResumeLayout(performLayout: false);
		agc().PerformLayout();
		ahb().ResumeLayout(performLayout: false);
		ahb().PerformLayout();
		ahc().ResumeLayout(performLayout: false);
		ahc().PerformLayout();
		agn().ResumeLayout(performLayout: false);
		agn().PerformLayout();
		aha().ResumeLayout(performLayout: false);
		aha().PerformLayout();
		agy().ResumeLayout(performLayout: false);
		agy().PerformLayout();
		ago().ResumeLayout(performLayout: false);
		ago().PerformLayout();
		agj().ResumeLayout(performLayout: false);
		agj().PerformLayout();
		agf().ResumeLayout(performLayout: false);
		agf().PerformLayout();
		agg().ResumeLayout(performLayout: false);
		agg().PerformLayout();
		ahd().ResumeLayout(performLayout: false);
		ahd().PerformLayout();
		agz().ResumeLayout(performLayout: false);
		agz().PerformLayout();
		ag0().ResumeLayout(performLayout: false);
		ag0().PerformLayout();
		ag2().ResumeLayout(performLayout: false);
		ag2().PerformLayout();
		ag9().ResumeLayout(performLayout: false);
		ag9().PerformLayout();
		ag6().ResumeLayout(performLayout: false);
		ag6().PerformLayout();
		o0().ResumeLayout(performLayout: false);
		zv().ResumeLayout(performLayout: false);
		zv().PerformLayout();
		o1().ResumeLayout(performLayout: false);
		o1().PerformLayout();
		d2().ResumeLayout(performLayout: false);
		d2().PerformLayout();
		pw().ResumeLayout(performLayout: false);
		pw().PerformLayout();
		we().ResumeLayout(performLayout: false);
		we().PerformLayout();
		wj().ResumeLayout(performLayout: false);
		wj().PerformLayout();
		yz().ResumeLayout(performLayout: false);
		yz().PerformLayout();
		x7().ResumeLayout(performLayout: false);
		x7().PerformLayout();
		wk().ResumeLayout(performLayout: false);
		zm().ResumeLayout(performLayout: false);
		zm().PerformLayout();
		ahj().ResumeLayout(performLayout: false);
		ahj().PerformLayout();
		af7().ResumeLayout(performLayout: false);
		af7().PerformLayout();
		agb().ResumeLayout(performLayout: false);
		agb().PerformLayout();
		ey().ResumeLayout(performLayout: false);
		ey().PerformLayout();
		((ISupportInitialize)wi()).EndInit();
		w1().ResumeLayout(performLayout: false);
		e3().ResumeLayout(performLayout: false);
		e3().PerformLayout();
		e6().ResumeLayout(performLayout: false);
		e6().PerformLayout();
		fb().ResumeLayout(performLayout: false);
		fb().PerformLayout();
		ft().ResumeLayout(performLayout: false);
		ft().PerformLayout();
		wl().ResumeLayout(performLayout: false);
		wl().PerformLayout();
		wn().ResumeLayout(performLayout: false);
		wn().PerformLayout();
		wf().ResumeLayout(performLayout: false);
		wf().PerformLayout();
		ev().ResumeLayout(performLayout: false);
		ev().PerformLayout();
		px().ResumeLayout(performLayout: false);
		g6().ResumeLayout(performLayout: false);
		g6().PerformLayout();
		he().ResumeLayout(performLayout: false);
		he().PerformLayout();
		hq().ResumeLayout(performLayout: false);
		hq().PerformLayout();
		hu().ResumeLayout(performLayout: false);
		hv().ResumeLayout(performLayout: false);
		hy().ResumeLayout(performLayout: false);
		hy().PerformLayout();
		ig().ResumeLayout(performLayout: false);
		ig().PerformLayout();
		ua().ResumeLayout(performLayout: false);
		ua().PerformLayout();
		g3().ResumeLayout(performLayout: false);
		vl().ResumeLayout(performLayout: false);
		vl().PerformLayout();
		vm().ResumeLayout(performLayout: false);
		vm().PerformLayout();
		ge().ResumeLayout(performLayout: false);
		ge().PerformLayout();
		gl().ResumeLayout(performLayout: false);
		gm().ResumeLayout(performLayout: false);
		gm().PerformLayout();
		gy().ResumeLayout(performLayout: false);
		gy().PerformLayout();
		u8().ResumeLayout(performLayout: false);
		u8().PerformLayout();
		qh().ResumeLayout(performLayout: false);
		qh().PerformLayout();
		qi().ResumeLayout(performLayout: false);
		y0().ResumeLayout(performLayout: false);
		zc().ResumeLayout(performLayout: false);
		zc().PerformLayout();
		zf().ResumeLayout(performLayout: false);
		zf().PerformLayout();
		((ISupportInitialize)za()).EndInit();
		zb().ResumeLayout(performLayout: false);
		zb().PerformLayout();
		ahq().ResumeLayout(performLayout: false);
		ahq().PerformLayout();
		v7().ResumeLayout(performLayout: false);
		v7().PerformLayout();
		tg().ResumeLayout(performLayout: false);
		tg().PerformLayout();
		tb().ResumeLayout(performLayout: false);
		tb().PerformLayout();
		r5().ResumeLayout(performLayout: false);
		sg().ResumeLayout(performLayout: false);
		sg().PerformLayout();
		qq().ResumeLayout(performLayout: false);
		qq().PerformLayout();
		vn().ResumeLayout(performLayout: false);
		vn().PerformLayout();
		ad9().ResumeLayout(performLayout: false);
		qs().ResumeLayout(performLayout: false);
		qs().PerformLayout();
		z1().ResumeLayout(performLayout: false);
		rf().ResumeLayout(performLayout: false);
		rf().PerformLayout();
		w2().ResumeLayout(performLayout: false);
		w3().ResumeLayout(performLayout: false);
		w3().PerformLayout();
		w4().ResumeLayout(performLayout: false);
		w4().PerformLayout();
		w5().ResumeLayout(performLayout: false);
		((ISupportInitialize)w7()).EndInit();
		w9().ResumeLayout(performLayout: false);
		xc().ResumeLayout(performLayout: false);
		xc().PerformLayout();
		xl().ResumeLayout(performLayout: false);
		xl().PerformLayout();
		xp().ResumeLayout(performLayout: false);
		((ISupportInitialize)xr()).EndInit();
		xt().ResumeLayout(performLayout: false);
		((ISupportInitialize)xw()).EndInit();
		xx().ResumeLayout(performLayout: false);
		((ISupportInitialize)x0()).EndInit();
		x1().ResumeLayout(performLayout: false);
		x4().ResumeLayout(performLayout: false);
		x4().PerformLayout();
		ye().ResumeLayout(performLayout: false);
		yk().ResumeLayout(performLayout: false);
		yk().PerformLayout();
		yf().ResumeLayout(performLayout: false);
		yf().PerformLayout();
		ael().ResumeLayout(performLayout: false);
		aen().ResumeLayout(performLayout: false);
		aeo().ResumeLayout(performLayout: false);
		aeo().PerformLayout();
		ae2().ResumeLayout(performLayout: false);
		ae3().ResumeLayout(performLayout: false);
		ae3().PerformLayout();
		afb().ResumeLayout(performLayout: false);
		afb().PerformLayout();
		aem().ResumeLayout(performLayout: false);
		afk().ResumeLayout(performLayout: false);
		afl().ResumeLayout(performLayout: false);
		afl().PerformLayout();
		afp().ResumeLayout(performLayout: false);
		afr().ResumeLayout(performLayout: false);
		afr().PerformLayout();
		af3().ResumeLayout(performLayout: false);
		af3().PerformLayout();
		((ISupportInitialize)zi()).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel b4()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button b5()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = t;
		Button button = this.m_c;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_c = A_0;
		button = this.m_c;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button b6()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = v;
		Button button = this.m_d;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_d = A_0;
		button = this.m_d;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button b7()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = p;
		Button button = this.m_e;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_e = A_0;
		button = this.m_e;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b8()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b9()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ca()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel cb()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStrip cc()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolStrip A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton cd()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolStripButton A_0)
	{
		EventHandler value = n;
		ToolStripButton toolStripButton = this.m_k;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_k = A_0;
		toolStripButton = this.m_k;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton ce()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ToolStripButton A_0)
	{
		EventHandler value = m;
		ToolStripButton toolStripButton = this.m_l;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_l = A_0;
		toolStripButton = this.m_l;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton cf()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ToolStripButton A_0)
	{
		EventHandler value = l;
		ToolStripButton toolStripButton = this.m_m;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_m = A_0;
		toolStripButton = this.m_m;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton cg()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(ToolStripButton A_0)
	{
		EventHandler value = p;
		ToolStripButton toolStripButton = this.m_n;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_n = A_0;
		toolStripButton = this.m_n;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabControl ch()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TabControl A_0)
	{
		EventHandler value = c;
		EventHandler value2 = b;
		TabControl tabControl = this.m_o;
		if (tabControl != null)
		{
			tabControl.SelectedIndexChanged -= value;
			tabControl.Resize -= value2;
		}
		this.m_o = A_0;
		tabControl = this.m_o;
		if (tabControl != null)
		{
			tabControl.SelectedIndexChanged += value;
			tabControl.Resize += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage ci()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TabPage A_0)
	{
		LayoutEventHandler value = h;
		TabPage tabPage = this.m_p;
		if (tabPage != null)
		{
			tabPage.Layout -= value;
		}
		this.m_p = A_0;
		tabPage = this.m_p;
		if (tabPage != null)
		{
			tabPage.Layout += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage cj()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TabPage A_0)
	{
		EventHandler value = e1;
		LayoutEventHandler value2 = g;
		TabPage tabPage = this.m_q;
		if (tabPage != null)
		{
			tabPage.MouseEnter -= value;
			tabPage.Layout -= value2;
		}
		this.m_q = A_0;
		tabPage = this.m_q;
		if (tabPage != null)
		{
			tabPage.MouseEnter += value;
			tabPage.Layout += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ck()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Button A_0)
	{
		EventHandler value = w;
		Button button = r;
		if (button != null)
		{
			button.Click -= value;
		}
		r = A_0;
		button = r;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label cl()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c(Label A_0)
	{
		s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ComboBox cm()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a(ComboBox A_0)
	{
		EventHandler value = fw;
		ComboBox comboBox = this.m_t;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_t = A_0;
		comboBox = this.m_t;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel cn()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Panel A_0)
	{
		EventHandler value = fv;
		Panel panel = this.m_u;
		if (panel != null)
		{
			panel.MouseEnter -= value;
		}
		this.m_u = A_0;
		panel = this.m_u;
		if (panel != null)
		{
			panel.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel co()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TableLayoutPanel A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button cp()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Button A_0)
	{
		EventHandler value = fu;
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
	internal virtual GroupBox cq()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(GroupBox A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cr()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_y = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy cs()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(hy A_0)
	{
		EventHandler value = e0;
		hy hy2 = this.m_z;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_z = A_0;
		hy2 = this.m_z;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ct()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox cu()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(GroupBox A_0)
	{
		this.m_ab = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cv()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_ac = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox cw()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(CheckBox A_0)
	{
		EventHandler value = fr;
		CheckBox checkBox = this.m_ad;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_ad = A_0;
		checkBox = this.m_ad;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox cx()
	{
		return ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(GroupBox A_0)
	{
		ae = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox cy()
	{
		return this.m_af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c(CheckBox A_0)
	{
		this.m_af = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox cz()
	{
		return ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(GroupBox A_0)
	{
		ag = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy c0()
	{
		return ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c(hy A_0)
	{
		ah = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label c1()
	{
		return ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void g(Label A_0)
	{
		ai = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy c2()
	{
		return aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void d(hy A_0)
	{
		aj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy c3()
	{
		return ak;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void e(hy A_0)
	{
		ak = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label c4()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void h(Label A_0)
	{
		this.m_al = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c5()
	{
		return this.m_am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Label A_0)
	{
		this.m_am = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c6()
	{
		return this.m_an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Label A_0)
	{
		this.m_an = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c7()
	{
		return this.m_ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Label A_0)
	{
		this.m_ao = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox c8()
	{
		return ap;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(CheckBox A_0)
	{
		ap = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox c9()
	{
		return this.m_aq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void e(GroupBox A_0)
	{
		this.m_aq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton da()
	{
		return this.m_ar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(RadioButton A_0)
	{
		EventHandler value = e5;
		RadioButton radioButton = this.m_ar;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_ar = A_0;
		radioButton = this.m_ar;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton db()
	{
		return @as;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(RadioButton A_0)
	{
		EventHandler value = e4;
		RadioButton radioButton = @as;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		@as = A_0;
		radioButton = @as;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox dc()
	{
		return at;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void f(GroupBox A_0)
	{
		at = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy dd()
	{
		return au;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void f(hy A_0)
	{
		EventHandler value = e2;
		hy hy2 = au;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		au = A_0;
		hy2 = au;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy de()
	{
		return av;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void g(hy A_0)
	{
		EventHandler value = e3;
		hy hy2 = av;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		av = A_0;
		hy2 = av;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label df()
	{
		return aw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void l(Label A_0)
	{
		aw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label dg()
	{
		return ax;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void m(Label A_0)
	{
		ax = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label dh()
	{
		return ay;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void n(Label A_0)
	{
		ay = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label di()
	{
		return az;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void o(Label A_0)
	{
		az = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox dj()
	{
		return a0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void e(CheckBox A_0)
	{
		EventHandler value = fs;
		CheckBox checkBox = a0;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		a0 = A_0;
		checkBox = a0;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox dk()
	{
		return this.m_a1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void f(CheckBox A_0)
	{
		EventHandler value = ft;
		CheckBox checkBox = this.m_a1;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_a1 = A_0;
		checkBox = this.m_a1;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage dl()
	{
		return this.m_a2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TabPage A_0)
	{
		EventHandler value = ez;
		LayoutEventHandler value2 = f;
		TabPage tabPage = this.m_a2;
		if (tabPage != null)
		{
			tabPage.MouseEnter -= value;
			tabPage.Layout -= value2;
		}
		this.m_a2 = A_0;
		tabPage = this.m_a2;
		if (tabPage != null)
		{
			tabPage.MouseEnter += value;
			tabPage.Layout += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage dp()
	{
		return this.m_a3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TabPage A_0)
	{
		EventHandler value = cw;
		LayoutEventHandler value2 = e;
		TabPage tabPage = this.m_a3;
		if (tabPage != null)
		{
			tabPage.MouseEnter -= value;
			tabPage.Layout -= value2;
		}
		this.m_a3 = A_0;
		tabPage = this.m_a3;
		if (tabPage != null)
		{
			tabPage.MouseEnter += value;
			tabPage.Layout += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage d2()
	{
		return a4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TabPage A_0)
	{
		EventHandler value = b7;
		LayoutEventHandler value2 = c;
		TabPage tabPage = a4;
		if (tabPage != null)
		{
			tabPage.MouseEnter -= value;
			tabPage.Layout -= value2;
		}
		a4 = A_0;
		tabPage = a4;
		if (tabPage != null)
		{
			tabPage.MouseEnter += value;
			tabPage.Layout += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy d6()
	{
		return a5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void h(hy A_0)
	{
		EventHandler value = ew;
		EventHandler value2 = eh;
		hy hy2 = a5;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
			hy2.Validated -= value2;
		}
		a5 = A_0;
		hy2 = a5;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
			hy2.Validated += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy ef()
	{
		return a6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void i(hy A_0)
	{
		EventHandler value = ev;
		EventHandler value2 = eh;
		hy hy2 = a6;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
			hy2.Validated -= value2;
		}
		a6 = A_0;
		hy2 = a6;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
			hy2.Validated += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label eh()
	{
		return a7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void p(Label A_0)
	{
		a7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ep()
	{
		return a8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void q(Label A_0)
	{
		a8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label eq()
	{
		return a9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void t(Label A_0)
	{
		a9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label er()
	{
		return ba;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void u(Label A_0)
	{
		ba = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label es()
	{
		return bb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void v(Label A_0)
	{
		bb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label et()
	{
		return bc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void w(Label A_0)
	{
		bc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox eu()
	{
		return this.m_bd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void g(CheckBox A_0)
	{
		EventHandler value = ey;
		CheckBox checkBox = this.m_bd;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_bd = A_0;
		checkBox = this.m_bd;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage ev()
	{
		return this.m_be;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(TabPage A_0)
	{
		EventHandler value = b6;
		LayoutEventHandler value2 = b;
		TabPage tabPage = this.m_be;
		if (tabPage != null)
		{
			tabPage.MouseEnter -= value;
			tabPage.Layout -= value2;
		}
		this.m_be = A_0;
		tabPage = this.m_be;
		if (tabPage != null)
		{
			tabPage.MouseEnter += value;
			tabPage.Layout += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ew()
	{
		return this.m_bf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Button A_0)
	{
		EventHandler value = b4;
		Button button = this.m_bf;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_bf = A_0;
		button = this.m_bf;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ex()
	{
		return this.m_bg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Button A_0)
	{
		EventHandler value = b5;
		Button button = this.m_bg;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_bg = A_0;
		button = this.m_bg;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ey()
	{
		return this.m_bh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(GroupBox A_0)
	{
		EventHandler value = b7;
		GroupBox groupBox = this.m_bh;
		if (groupBox != null)
		{
			groupBox.MouseEnter -= value;
		}
		this.m_bh = A_0;
		groupBox = this.m_bh;
		if (groupBox != null)
		{
			groupBox.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ez()
	{
		return this.m_bi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(RadioButton A_0)
	{
		EventHandler value = bz;
		RadioButton radioButton = this.m_bi;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_bi = A_0;
		radioButton = this.m_bi;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton e0()
	{
		return this.m_bj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(RadioButton A_0)
	{
		EventHandler value = bw;
		RadioButton radioButton = this.m_bj;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_bj = A_0;
		radioButton = this.m_bj;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton e1()
	{
		return this.m_bk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(RadioButton A_0)
	{
		EventHandler value = bx;
		RadioButton radioButton = this.m_bk;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_bk = A_0;
		radioButton = this.m_bk;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton e2()
	{
		return this.m_bl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(RadioButton A_0)
	{
		EventHandler value = bz;
		RadioButton radioButton = this.m_bl;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_bl = A_0;
		radioButton = this.m_bl;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox e3()
	{
		return this.m_bm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(GroupBox A_0)
	{
		EventHandler value = b7;
		GroupBox groupBox = this.m_bm;
		if (groupBox != null)
		{
			groupBox.MouseEnter -= value;
		}
		this.m_bm = A_0;
		groupBox = this.m_bm;
		if (groupBox != null)
		{
			groupBox.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton e4()
	{
		return this.m_bn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(RadioButton A_0)
	{
		EventHandler value = b2;
		RadioButton radioButton = this.m_bn;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_bn = A_0;
		radioButton = this.m_bn;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton e5()
	{
		return this.m_bo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(RadioButton A_0)
	{
		EventHandler value = b0;
		RadioButton radioButton = this.m_bo;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_bo = A_0;
		radioButton = this.m_bo;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox e6()
	{
		return this.m_bp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(GroupBox A_0)
	{
		EventHandler value = b7;
		GroupBox groupBox = this.m_bp;
		if (groupBox != null)
		{
			groupBox.MouseEnter -= value;
		}
		this.m_bp = A_0;
		groupBox = this.m_bp;
		if (groupBox != null)
		{
			groupBox.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label e7()
	{
		return this.m_bq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(Label A_0)
	{
		this.m_bq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label e8()
	{
		return this.m_br;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(Label A_0)
	{
		this.m_br = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label e9()
	{
		return this.m_bs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(Label A_0)
	{
		this.m_bs = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton fa()
	{
		return this.m_bt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(RadioButton A_0)
	{
		EventHandler value = b1;
		RadioButton radioButton = this.m_bt;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_bt = A_0;
		radioButton = this.m_bt;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox fb()
	{
		return this.m_bu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(GroupBox A_0)
	{
		EventHandler value = b7;
		GroupBox groupBox = this.m_bu;
		if (groupBox != null)
		{
			groupBox.MouseEnter -= value;
		}
		this.m_bu = A_0;
		groupBox = this.m_bu;
		if (groupBox != null)
		{
			groupBox.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy fc()
	{
		return this.m_bv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(hy A_0)
	{
		EventHandler value = bp;
		hy hy2 = this.m_bv;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_bv = A_0;
		hy2 = this.m_bv;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label fr()
	{
		return this.m_bw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aa(Label A_0)
	{
		this.m_bw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label fs()
	{
		return this.m_bx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(Label A_0)
	{
		this.m_bx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ft()
	{
		return this.m_by;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(GroupBox A_0)
	{
		EventHandler value = b7;
		GroupBox groupBox = this.m_by;
		if (groupBox != null)
		{
			groupBox.MouseEnter -= value;
		}
		this.m_by = A_0;
		groupBox = this.m_by;
		if (groupBox != null)
		{
			groupBox.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label fu()
	{
		return this.m_bz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(Label A_0)
	{
		this.m_bz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label fv()
	{
		return this.m_b0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(Label A_0)
	{
		this.m_b0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label fw()
	{
		return this.m_b1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void af(Label A_0)
	{
		this.m_b1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy fz()
	{
		return this.m_b2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(hy A_0)
	{
		EventHandler value = bl;
		hy hy2 = this.m_b2;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_b2 = A_0;
		hy2 = this.m_b2;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy f6()
	{
		return this.m_b3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(hy A_0)
	{
		EventHandler value = bl;
		hy hy2 = this.m_b3;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_b3 = A_0;
		hy2 = this.m_b3;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy f7()
	{
		return this.m_b4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(hy A_0)
	{
		EventHandler value = bq;
		hy hy2 = this.m_b4;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_b4 = A_0;
		hy2 = this.m_b4;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy f8()
	{
		return this.m_b5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(hy A_0)
	{
		EventHandler value = bq;
		hy hy2 = this.m_b5;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_b5 = A_0;
		hy2 = this.m_b5;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label f9()
	{
		return this.m_b6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void al(Label A_0)
	{
		this.m_b6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ga()
	{
		return this.m_b7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Button A_0)
	{
		EventHandler value = b4;
		Button button = this.m_b7;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_b7 = A_0;
		button = this.m_b7;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button gb()
	{
		return this.m_b8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Button A_0)
	{
		EventHandler value = b5;
		Button button = this.m_b8;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_b8 = A_0;
		button = this.m_b8;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ge()
	{
		return this.m_b9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(GroupBox A_0)
	{
		EventHandler value = b6;
		GroupBox groupBox = this.m_b9;
		if (groupBox != null)
		{
			groupBox.MouseEnter -= value;
		}
		this.m_b9 = A_0;
		groupBox = this.m_b9;
		if (groupBox != null)
		{
			groupBox.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox gk()
	{
		return this.m_ca;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(CheckBox A_0)
	{
		EventHandler value = bv;
		CheckBox checkBox = this.m_ca;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_ca = A_0;
		checkBox = this.m_ca;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabControl gl()
	{
		return this.m_cb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TabControl A_0)
	{
		this.m_cb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage gm()
	{
		return this.m_cc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(TabPage A_0)
	{
		this.m_cc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton gn()
	{
		return this.m_cd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(RadioButton A_0)
	{
		EventHandler value = bz;
		RadioButton radioButton = this.m_cd;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_cd = A_0;
		radioButton = this.m_cd;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton go()
	{
		return this.m_ce;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(RadioButton A_0)
	{
		EventHandler value = bw;
		RadioButton radioButton = this.m_ce;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_ce = A_0;
		radioButton = this.m_ce;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton gp()
	{
		return this.m_cf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(RadioButton A_0)
	{
		EventHandler value = bx;
		RadioButton radioButton = this.m_cf;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_cf = A_0;
		radioButton = this.m_cf;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton gs()
	{
		return this.m_cg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(RadioButton A_0)
	{
		EventHandler value = bz;
		RadioButton radioButton = this.m_cg;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_cg = A_0;
		radioButton = this.m_cg;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage gy()
	{
		return this.m_ch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(TabPage A_0)
	{
		this.m_ch = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton gz()
	{
		return this.m_ci;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(RadioButton A_0)
	{
		EventHandler value = bz;
		RadioButton radioButton = this.m_ci;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_ci = A_0;
		radioButton = this.m_ci;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton g0()
	{
		return this.m_cj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(RadioButton A_0)
	{
		EventHandler value = bw;
		RadioButton radioButton = this.m_cj;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_cj = A_0;
		radioButton = this.m_cj;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton g1()
	{
		return this.m_ck;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(RadioButton A_0)
	{
		EventHandler value = bx;
		RadioButton radioButton = this.m_ck;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_ck = A_0;
		radioButton = this.m_ck;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton g2()
	{
		return this.m_cl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(RadioButton A_0)
	{
		EventHandler value = bz;
		RadioButton radioButton = this.m_cl;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_cl = A_0;
		radioButton = this.m_cl;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox g3()
	{
		return this.m_cm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(GroupBox A_0)
	{
		this.m_cm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox g6()
	{
		return this.m_cn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(GroupBox A_0)
	{
		EventHandler value = b6;
		GroupBox groupBox = this.m_cn;
		if (groupBox != null)
		{
			groupBox.MouseEnter -= value;
		}
		this.m_cn = A_0;
		groupBox = this.m_cn;
		if (groupBox != null)
		{
			groupBox.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton hc()
	{
		return this.m_co;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(RadioButton A_0)
	{
		EventHandler value = b2;
		RadioButton radioButton = this.m_co;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_co = A_0;
		radioButton = this.m_co;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton hd()
	{
		return this.m_cp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(RadioButton A_0)
	{
		EventHandler value = b0;
		RadioButton radioButton = this.m_cp;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_cp = A_0;
		radioButton = this.m_cp;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox he()
	{
		return this.m_cq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(GroupBox A_0)
	{
		EventHandler value = b6;
		GroupBox groupBox = this.m_cq;
		if (groupBox != null)
		{
			groupBox.MouseEnter -= value;
		}
		this.m_cq = A_0;
		groupBox = this.m_cq;
		if (groupBox != null)
		{
			groupBox.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label hf()
	{
		return this.m_cr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void am(Label A_0)
	{
		this.m_cr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label hg()
	{
		return this.m_cs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void an(Label A_0)
	{
		this.m_cs = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label hh()
	{
		return this.m_ct;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ao(Label A_0)
	{
		this.m_ct = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton hk()
	{
		return this.m_cu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(RadioButton A_0)
	{
		EventHandler value = b1;
		RadioButton radioButton = this.m_cu;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_cu = A_0;
		radioButton = this.m_cu;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox hq()
	{
		return this.m_cv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(GroupBox A_0)
	{
		EventHandler value = b6;
		GroupBox groupBox = this.m_cv;
		if (groupBox != null)
		{
			groupBox.MouseEnter -= value;
		}
		this.m_cv = A_0;
		groupBox = this.m_cv;
		if (groupBox != null)
		{
			groupBox.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy hr()
	{
		return this.m_cw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(hy A_0)
	{
		EventHandler value = bp;
		hy hy2 = this.m_cw;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_cw = A_0;
		hy2 = this.m_cw;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label hs()
	{
		return this.m_cx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aq(Label A_0)
	{
		this.m_cx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ht()
	{
		return this.m_cy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ar(Label A_0)
	{
		this.m_cy = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox hu()
	{
		return this.m_cz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(GroupBox A_0)
	{
		EventHandler value = b6;
		GroupBox groupBox = this.m_cz;
		if (groupBox != null)
		{
			groupBox.MouseEnter -= value;
		}
		this.m_cz = A_0;
		groupBox = this.m_cz;
		if (groupBox != null)
		{
			groupBox.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabControl hv()
	{
		return this.m_c0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TabControl A_0)
	{
		this.m_c0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage hy()
	{
		return this.m_c1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TabPage A_0)
	{
		this.m_c1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label h8()
	{
		return this.m_c2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a1(Label A_0)
	{
		this.m_c2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label h9()
	{
		return this.m_c3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a2(Label A_0)
	{
		this.m_c3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ia()
	{
		return this.m_c4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a3(Label A_0)
	{
		this.m_c4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ib()
	{
		return this.m_c5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(hy A_0)
	{
		EventHandler value = bl;
		hy hy2 = this.m_c5;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_c5 = A_0;
		hy2 = this.m_c5;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ic()
	{
		return this.m_c6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(hy A_0)
	{
		EventHandler value = bl;
		hy hy2 = this.m_c6;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_c6 = A_0;
		hy2 = this.m_c6;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy id()
	{
		return this.m_c7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(hy A_0)
	{
		EventHandler value = bq;
		hy hy2 = this.m_c7;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_c7 = A_0;
		hy2 = this.m_c7;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ie()
	{
		return this.m_c8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(hy A_0)
	{
		EventHandler value = bq;
		hy hy2 = this.m_c8;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_c8 = A_0;
		hy2 = this.m_c8;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label @if()
	{
		return this.m_c9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bd(Label A_0)
	{
		this.m_c9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage ig()
	{
		return this.m_da;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(TabPage A_0)
	{
		this.m_da = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ih()
	{
		return this.m_db;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void be(Label A_0)
	{
		this.m_db = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ii()
	{
		return this.m_dc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bf(Label A_0)
	{
		this.m_dc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ij()
	{
		return this.m_dd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bg(Label A_0)
	{
		this.m_dd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ik()
	{
		return this.m_de;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bh(Label A_0)
	{
		this.m_de = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy il()
	{
		return this.m_df;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(hy A_0)
	{
		EventHandler value = bl;
		hy hy2 = this.m_df;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_df = A_0;
		hy2 = this.m_df;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy im()
	{
		return this.m_dg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(hy A_0)
	{
		EventHandler value = bl;
		hy hy2 = this.m_dg;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_dg = A_0;
		hy2 = this.m_dg;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy @in()
	{
		return this.m_dh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(hy A_0)
	{
		EventHandler value = bq;
		hy hy2 = this.m_dh;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_dh = A_0;
		hy2 = this.m_dh;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy io()
	{
		return this.m_di;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(hy A_0)
	{
		EventHandler value = bq;
		hy hy2 = this.m_di;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_di = A_0;
		hy2 = this.m_di;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ip()
	{
		return this.m_dj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Button A_0)
	{
		EventHandler value = u;
		Button button = this.m_dj;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_dj = A_0;
		button = this.m_dj;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip iq()
	{
		return this.m_dk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolTip A_0)
	{
		this.m_dk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ir()
	{
		return this.m_dl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(CheckBox A_0)
	{
		EventHandler value = fc;
		CheckBox checkBox = this.m_dl;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_dl = A_0;
		checkBox = this.m_dl;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel @is()
	{
		return dm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TableLayoutPanel A_0)
	{
		EventHandler value = fv;
		TableLayoutPanel tableLayoutPanel = dm;
		if (tableLayoutPanel != null)
		{
			tableLayoutPanel.MouseEnter -= value;
		}
		dm = A_0;
		tableLayoutPanel = dm;
		if (tableLayoutPanel != null)
		{
			tableLayoutPanel.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button it()
	{
		return dn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void k(Button A_0)
	{
		EventHandler value = hf;
		Button button = dn;
		if (button != null)
		{
			button.Click -= value;
		}
		dn = A_0;
		button = dn;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button j1()
	{
		return @do;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void l(Button A_0)
	{
		EventHandler value = hg;
		Button button = @do;
		if (button != null)
		{
			button.Click -= value;
		}
		@do = A_0;
		button = @do;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual TextBox j2()
	{
		return this.m_dp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b(TextBox A_0)
	{
		EventHandler value = gn;
		TextBox textBox = this.m_dp;
		if (textBox != null)
		{
			textBox.Click -= value;
		}
		this.m_dp = A_0;
		textBox = this.m_dp;
		if (textBox != null)
		{
			textBox.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox j3()
	{
		return dq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(PictureBox A_0)
	{
		dq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label j4()
	{
		return dr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bi(Label A_0)
	{
		dr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label j5()
	{
		return ds;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bj(Label A_0)
	{
		ds = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button j6()
	{
		return dt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void m(Button A_0)
	{
		EventHandler value = hh;
		Button button = dt;
		if (button != null)
		{
			button.Click -= value;
		}
		dt = A_0;
		button = dt;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy j7()
	{
		return du;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void z(hy A_0)
	{
		EventHandler value = go;
		EventHandler value2 = gm;
		hy hy2 = du;
		if (hy2 != null)
		{
			hy2.Validated -= value;
			hy2.TextChanged -= value2;
		}
		du = A_0;
		hy2 = du;
		if (hy2 != null)
		{
			hy2.Validated += value;
			hy2.TextChanged += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy j8()
	{
		return dv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aa(hy A_0)
	{
		EventHandler value = go;
		EventHandler value2 = gl;
		hy hy2 = dv;
		if (hy2 != null)
		{
			hy2.Validated -= value;
			hy2.TextChanged -= value2;
		}
		dv = A_0;
		hy2 = dv;
		if (hy2 != null)
		{
			hy2.Validated += value;
			hy2.TextChanged += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label j9()
	{
		return dw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bk(Label A_0)
	{
		dw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ka()
	{
		return dx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bl(Label A_0)
	{
		dx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox kb()
	{
		return dy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void j(CheckBox A_0)
	{
		EventHandler value = hc;
		CheckBox checkBox = dy;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		dy = A_0;
		checkBox = dy;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label kc()
	{
		return dz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bm(Label A_0)
	{
		dz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy kd()
	{
		return d0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ab(hy A_0)
	{
		EventHandler value = go;
		EventHandler value2 = gk;
		CancelEventHandler value3 = a;
		hy hy2 = d0;
		if (hy2 != null)
		{
			hy2.Validated -= value;
			hy2.TextChanged -= value2;
			hy2.Validating -= value3;
		}
		d0 = A_0;
		hy2 = d0;
		if (hy2 != null)
		{
			hy2.Validated += value;
			hy2.TextChanged += value2;
			hy2.Validating += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ke()
	{
		return d1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bn(Label A_0)
	{
		d1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label kf()
	{
		return this.m_d2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bo(Label A_0)
	{
		this.m_d2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox kg()
	{
		return d3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(PictureBox A_0)
	{
		d3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox kh()
	{
		return d4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void k(CheckBox A_0)
	{
		EventHandler value = hd;
		CheckBox checkBox = d4;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		d4 = A_0;
		checkBox = d4;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ki()
	{
		return d5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bp(Label A_0)
	{
		d5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button kj()
	{
		return this.m_d6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void n(Button A_0)
	{
		EventHandler value = hf;
		Button button = this.m_d6;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_d6 = A_0;
		button = this.m_d6;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox kk()
	{
		return d7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(PictureBox A_0)
	{
		EventHandler value = g0;
		EventHandler value2 = gz;
		EventHandler value3 = gy;
		PictureBox pictureBox = d7;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter -= value;
			pictureBox.MouseLeave -= value2;
			pictureBox.Click -= value3;
		}
		d7 = A_0;
		pictureBox = d7;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter += value;
			pictureBox.MouseLeave += value2;
			pictureBox.Click += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label kl()
	{
		return d8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bq(Label A_0)
	{
		d8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox km()
	{
		return d9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void l(CheckBox A_0)
	{
		EventHandler value = g6;
		CheckBox checkBox = d9;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		d9 = A_0;
		checkBox = d9;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label kn()
	{
		return ea;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void br(Label A_0)
	{
		EventHandler value = g2;
		EventHandler value2 = j;
		EventHandler value3 = i;
		Label label = ea;
		if (label != null)
		{
			label.Click -= value;
			label.MouseEnter -= value2;
			label.MouseLeave -= value3;
		}
		ea = A_0;
		label = ea;
		if (label != null)
		{
			label.Click += value;
			label.MouseEnter += value2;
			label.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ko()
	{
		return eb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bs(Label A_0)
	{
		eb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy kp()
	{
		return ec;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ac(hy A_0)
	{
		EventHandler value = f8;
		EventHandler value2 = f7;
		hy hy2 = ec;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
			hy2.Validated -= value2;
		}
		ec = A_0;
		hy2 = ec;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
			hy2.Validated += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label kq()
	{
		return ed;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bt(Label A_0)
	{
		ed = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy kr()
	{
		return ee;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ad(hy A_0)
	{
		EventHandler value = ga;
		EventHandler value2 = f9;
		hy hy2 = ee;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
			hy2.Validated -= value2;
		}
		ee = A_0;
		hy2 = ee;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
			hy2.Validated += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ks()
	{
		return this.m_ef;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bu(Label A_0)
	{
		this.m_ef = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox kt()
	{
		return eg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(PictureBox A_0)
	{
		eg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ku()
	{
		return this.m_eh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bv(Label A_0)
	{
		this.m_eh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox kv()
	{
		return ei;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ComboBox A_0)
	{
		EventHandler value = go;
		EventHandler value2 = f6;
		ComboBox comboBox = ei;
		if (comboBox != null)
		{
			comboBox.Validated -= value;
			comboBox.SelectedIndexChanged -= value2;
		}
		ei = A_0;
		comboBox = ei;
		if (comboBox != null)
		{
			comboBox.Validated += value;
			comboBox.SelectedIndexChanged += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox kw()
	{
		return ej;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void m(CheckBox A_0)
	{
		EventHandler value = g3;
		CheckBox checkBox = ej;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		ej = A_0;
		checkBox = ej;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy kx()
	{
		return ek;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void af(hy A_0)
	{
		EventHandler value = ge;
		EventHandler value2 = gb;
		hy hy2 = ek;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
			hy2.Validated -= value2;
		}
		ek = A_0;
		hy2 = ek;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
			hy2.Validated += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ky()
	{
		return el;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bw(Label A_0)
	{
		el = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label kz()
	{
		return em;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bx(Label A_0)
	{
		EventHandler value = g1;
		EventHandler value2 = j;
		EventHandler value3 = i;
		Label label = em;
		if (label != null)
		{
			label.Click -= value;
			label.MouseEnter -= value2;
			label.MouseLeave -= value3;
		}
		em = A_0;
		label = em;
		if (label != null)
		{
			label.Click += value;
			label.MouseEnter += value2;
			label.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label k0()
	{
		return en;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void by(Label A_0)
	{
		en = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label k1()
	{
		return eo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bz(Label A_0)
	{
		eo = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label k2()
	{
		return this.m_ep;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b0(Label A_0)
	{
		this.m_ep = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox k3()
	{
		return this.m_eq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(PictureBox A_0)
	{
		EventHandler value = g0;
		EventHandler value2 = gz;
		EventHandler value3 = gs;
		PictureBox pictureBox = this.m_eq;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter -= value;
			pictureBox.MouseLeave -= value2;
			pictureBox.Click -= value3;
		}
		this.m_eq = A_0;
		pictureBox = this.m_eq;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter += value;
			pictureBox.MouseLeave += value2;
			pictureBox.Click += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox k4()
	{
		return this.m_er;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(PictureBox A_0)
	{
		EventHandler value = g0;
		EventHandler value2 = gz;
		EventHandler value3 = gp;
		PictureBox pictureBox = this.m_er;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter -= value;
			pictureBox.MouseLeave -= value2;
			pictureBox.Click -= value3;
		}
		this.m_er = A_0;
		pictureBox = this.m_er;
		if (pictureBox != null)
		{
			pictureBox.MouseEnter += value;
			pictureBox.MouseLeave += value2;
			pictureBox.Click += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox k5()
	{
		return this.m_es;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(PictureBox A_0)
	{
		this.m_es = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ContextMenuStrip k6()
	{
		return this.m_et;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ContextMenuStrip A_0)
	{
		ToolStripItemClickedEventHandler value = a;
		CancelEventHandler value2 = c;
		ContextMenuStrip contextMenuStrip = this.m_et;
		if (contextMenuStrip != null)
		{
			contextMenuStrip.ItemClicked -= value;
			contextMenuStrip.Opening -= value2;
		}
		this.m_et = A_0;
		contextMenuStrip = this.m_et;
		if (contextMenuStrip != null)
		{
			contextMenuStrip.ItemClicked += value;
			contextMenuStrip.Opening += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel k7()
	{
		return this.m_eu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(TableLayoutPanel A_0)
	{
		this.m_eu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox k8()
	{
		return this.m_ev;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(GroupBox A_0)
	{
		this.m_ev = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox k9()
	{
		return this.m_ew;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(GroupBox A_0)
	{
		this.m_ew = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton la()
	{
		return this.m_ex;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(RadioButton A_0)
	{
		EventHandler value = fa;
		RadioButton radioButton = this.m_ex;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_ex = A_0;
		radioButton = this.m_ex;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox lb()
	{
		return this.m_ey;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(GroupBox A_0)
	{
		this.m_ey = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton lc()
	{
		return this.m_ez;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(RadioButton A_0)
	{
		EventHandler value = fb;
		RadioButton radioButton = this.m_ez;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_ez = A_0;
		radioButton = this.m_ez;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ld()
	{
		return this.m_e0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(GroupBox A_0)
	{
		this.m_e0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label le()
	{
		return this.m_e1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b1(Label A_0)
	{
		this.m_e1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label lf()
	{
		return this.m_e2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b2(Label A_0)
	{
		this.m_e2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton lg()
	{
		return this.m_e3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(RadioButton A_0)
	{
		EventHandler value = fb;
		RadioButton radioButton = this.m_e3;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_e3 = A_0;
		radioButton = this.m_e3;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton lh()
	{
		return this.m_e4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(RadioButton A_0)
	{
		EventHandler value = fa;
		RadioButton radioButton = this.m_e4;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_e4 = A_0;
		radioButton = this.m_e4;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel li()
	{
		return this.m_e5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Panel A_0)
	{
		EventHandler value = e1;
		Panel panel = this.m_e5;
		if (panel != null)
		{
			panel.MouseEnter -= value;
		}
		this.m_e5 = A_0;
		panel = this.m_e5;
		if (panel != null)
		{
			panel.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel lj()
	{
		return this.m_e6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(TableLayoutPanel A_0)
	{
		this.m_e6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel lk()
	{
		return this.m_e7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Panel A_0)
	{
		EventHandler value = ez;
		Panel panel = this.m_e7;
		if (panel != null)
		{
			panel.MouseEnter -= value;
		}
		this.m_e7 = A_0;
		panel = this.m_e7;
		if (panel != null)
		{
			panel.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ll()
	{
		return this.m_e8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(TableLayoutPanel A_0)
	{
		EventHandler value = ez;
		TableLayoutPanel tableLayoutPanel = this.m_e8;
		if (tableLayoutPanel != null)
		{
			tableLayoutPanel.MouseEnter -= value;
		}
		this.m_e8 = A_0;
		tableLayoutPanel = this.m_e8;
		if (tableLayoutPanel != null)
		{
			tableLayoutPanel.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label lm()
	{
		return this.m_e9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b3(Label A_0)
	{
		this.m_e9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel ln()
	{
		return this.m_fa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Panel A_0)
	{
		EventHandler value = cw;
		Panel panel = this.m_fa;
		if (panel != null)
		{
			panel.MouseEnter -= value;
		}
		this.m_fa = A_0;
		panel = this.m_fa;
		if (panel != null)
		{
			panel.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabControl lo()
	{
		return this.m_fb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TabControl A_0)
	{
		EventHandler value = cw;
		TabControl tabControl = this.m_fb;
		if (tabControl != null)
		{
			tabControl.MouseEnter -= value;
		}
		this.m_fb = A_0;
		tabControl = this.m_fb;
		if (tabControl != null)
		{
			tabControl.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage lp()
	{
		return this.m_fc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(TabPage A_0)
	{
		this.m_fc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage lq()
	{
		return fd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(TabPage A_0)
	{
		fd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label lr()
	{
		return fe;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b4(Label A_0)
	{
		fe = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ls()
	{
		return ff;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b5(Label A_0)
	{
		ff = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label lt()
	{
		return fg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b6(Label A_0)
	{
		fg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label lu()
	{
		return fh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b7(Label A_0)
	{
		fh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label lv()
	{
		return fi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b8(Label A_0)
	{
		fi = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label lw()
	{
		return fj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b9(Label A_0)
	{
		fj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label lx()
	{
		return fk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ca(Label A_0)
	{
		fk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ly()
	{
		return fl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cb(Label A_0)
	{
		fl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label lz()
	{
		return fm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cc(Label A_0)
	{
		fm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button l0()
	{
		return fn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void o(Button A_0)
	{
		EventHandler value = dp;
		EventHandler value2 = dl;
		EventHandler value3 = dk;
		EventHandler value4 = dj;
		Button button = fn;
		if (button != null)
		{
			button.Click -= value;
			button.EnabledChanged -= value2;
			button.MouseEnter -= value3;
			button.MouseLeave -= value4;
		}
		fn = A_0;
		button = fn;
		if (button != null)
		{
			button.Click += value;
			button.EnabledChanged += value2;
			button.MouseEnter += value3;
			button.MouseLeave += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label l1()
	{
		return fo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cd(Label A_0)
	{
		fo = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label l2()
	{
		return fp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ce(Label A_0)
	{
		fp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label l3()
	{
		return fq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cf(Label A_0)
	{
		fq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox l4()
	{
		return this.m_fr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void x(GroupBox A_0)
	{
		this.m_fr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel l5()
	{
		return this.m_fs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Panel A_0)
	{
		this.m_fs = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton l6()
	{
		return this.m_ft;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aa(RadioButton A_0)
	{
		EventHandler value = c0;
		RadioButton radioButton = this.m_ft;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_ft = A_0;
		radioButton = this.m_ft;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton l7()
	{
		return this.m_fu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(RadioButton A_0)
	{
		EventHandler value = c1;
		RadioButton radioButton = this.m_fu;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_fu = A_0;
		radioButton = this.m_fu;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox l8()
	{
		return this.m_fv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(CheckBox A_0)
	{
		EventHandler value = db;
		CheckBox checkBox = this.m_fv;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_fv = A_0;
		checkBox = this.m_fv;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton l9()
	{
		return this.m_fw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(RadioButton A_0)
	{
		EventHandler value = cx;
		RadioButton radioButton = this.m_fw;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_fw = A_0;
		radioButton = this.m_fw;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ma()
	{
		return fx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(RadioButton A_0)
	{
		EventHandler value = cy;
		RadioButton radioButton = fx;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		fx = A_0;
		radioButton = fx;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy mb()
	{
		return fy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void al(hy A_0)
	{
		EventHandler value = cs;
		hy hy2 = fy;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		fy = A_0;
		hy2 = fy;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy mc()
	{
		return this.m_fz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void am(hy A_0)
	{
		EventHandler value = cq;
		hy hy2 = this.m_fz;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_fz = A_0;
		hy2 = this.m_fz;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox md()
	{
		return f0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(CheckBox A_0)
	{
		EventHandler value = c9;
		CheckBox checkBox = f0;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		f0 = A_0;
		checkBox = f0;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy me()
	{
		return f1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void an(hy A_0)
	{
		EventHandler value = cu;
		hy hy2 = f1;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		f1 = A_0;
		hy2 = f1;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button mf()
	{
		return f2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void p(Button A_0)
	{
		EventHandler value = dh;
		EventHandler value2 = dg;
		EventHandler value3 = df;
		Button button = f2;
		if (button != null)
		{
			button.Click -= value;
			button.MouseEnter -= value2;
			button.MouseLeave -= value3;
		}
		f2 = A_0;
		button = f2;
		if (button != null)
		{
			button.Click += value;
			button.MouseEnter += value2;
			button.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy mg()
	{
		return f3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ao(hy A_0)
	{
		EventHandler value = cn;
		hy hy2 = f3;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		f3 = A_0;
		hy2 = f3;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label mh()
	{
		return f4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cg(Label A_0)
	{
		f4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button mi()
	{
		return f5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void q(Button A_0)
	{
		EventHandler value = dp;
		EventHandler value2 = dl;
		EventHandler value3 = dk;
		EventHandler value4 = dj;
		Button button = f5;
		if (button != null)
		{
			button.Click -= value;
			button.EnabledChanged -= value2;
			button.MouseEnter -= value3;
			button.MouseLeave -= value4;
		}
		f5 = A_0;
		button = f5;
		if (button != null)
		{
			button.Click += value;
			button.EnabledChanged += value2;
			button.MouseEnter += value3;
			button.MouseLeave += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox mj()
	{
		return this.m_f6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void y(GroupBox A_0)
	{
		this.m_f6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel mk()
	{
		return this.m_f7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Panel A_0)
	{
		this.m_f7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ml()
	{
		return this.m_f8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void af(RadioButton A_0)
	{
		EventHandler value = c0;
		RadioButton radioButton = this.m_f8;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_f8 = A_0;
		radioButton = this.m_f8;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton mm()
	{
		return this.m_f9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void al(RadioButton A_0)
	{
		EventHandler value = c1;
		RadioButton radioButton = this.m_f9;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_f9 = A_0;
		radioButton = this.m_f9;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton mn()
	{
		return this.m_ga;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void am(RadioButton A_0)
	{
		EventHandler value = cx;
		RadioButton radioButton = this.m_ga;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_ga = A_0;
		radioButton = this.m_ga;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton mo()
	{
		return this.m_gb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void an(RadioButton A_0)
	{
		EventHandler value = cy;
		RadioButton radioButton = this.m_gb;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_gb = A_0;
		radioButton = this.m_gb;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox mp()
	{
		return gc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(CheckBox A_0)
	{
		EventHandler value = db;
		CheckBox checkBox = gc;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		gc = A_0;
		checkBox = gc;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy mq()
	{
		return gd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aq(hy A_0)
	{
		EventHandler value = cs;
		hy hy2 = gd;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		gd = A_0;
		hy2 = gd;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy mr()
	{
		return this.m_ge;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ar(hy A_0)
	{
		EventHandler value = cq;
		hy hy2 = this.m_ge;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_ge = A_0;
		hy2 = this.m_ge;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ms()
	{
		return gf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(CheckBox A_0)
	{
		EventHandler value = c9;
		CheckBox checkBox = gf;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		gf = A_0;
		checkBox = gf;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy mt()
	{
		return gg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a1(hy A_0)
	{
		EventHandler value = cu;
		hy hy2 = gg;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		gg = A_0;
		hy2 = gg;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button mu()
	{
		return gh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void t(Button A_0)
	{
		EventHandler value = dh;
		EventHandler value2 = dg;
		EventHandler value3 = df;
		Button button = gh;
		if (button != null)
		{
			button.Click -= value;
			button.MouseEnter -= value2;
			button.MouseLeave -= value3;
		}
		gh = A_0;
		button = gh;
		if (button != null)
		{
			button.Click += value;
			button.MouseEnter += value2;
			button.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy mv()
	{
		return gi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a2(hy A_0)
	{
		EventHandler value = cn;
		hy hy2 = gi;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		gi = A_0;
		hy2 = gi;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label mw()
	{
		return gj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ch(Label A_0)
	{
		gj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox mx()
	{
		return this.m_gk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void z(GroupBox A_0)
	{
		this.m_gk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel my()
	{
		return this.m_gl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Panel A_0)
	{
		this.m_gl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton mz()
	{
		return this.m_gm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ao(RadioButton A_0)
	{
		EventHandler value = c0;
		RadioButton radioButton = this.m_gm;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_gm = A_0;
		radioButton = this.m_gm;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton m0()
	{
		return this.m_gn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aq(RadioButton A_0)
	{
		EventHandler value = c1;
		RadioButton radioButton = this.m_gn;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_gn = A_0;
		radioButton = this.m_gn;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton m1()
	{
		return this.m_go;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ar(RadioButton A_0)
	{
		EventHandler value = cx;
		RadioButton radioButton = this.m_go;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_go = A_0;
		radioButton = this.m_go;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton m2()
	{
		return this.m_gp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a1(RadioButton A_0)
	{
		EventHandler value = cy;
		RadioButton radioButton = this.m_gp;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_gp = A_0;
		radioButton = this.m_gp;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox m3()
	{
		return gq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(CheckBox A_0)
	{
		EventHandler value = db;
		CheckBox checkBox = gq;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		gq = A_0;
		checkBox = gq;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy m4()
	{
		return gr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a3(hy A_0)
	{
		EventHandler value = cs;
		hy hy2 = gr;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		gr = A_0;
		hy2 = gr;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy m5()
	{
		return this.m_gs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bd(hy A_0)
	{
		EventHandler value = cq;
		hy hy2 = this.m_gs;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_gs = A_0;
		hy2 = this.m_gs;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox m6()
	{
		return gt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(CheckBox A_0)
	{
		EventHandler value = c9;
		CheckBox checkBox = gt;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		gt = A_0;
		checkBox = gt;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy m7()
	{
		return gu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void be(hy A_0)
	{
		EventHandler value = cu;
		hy hy2 = gu;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		gu = A_0;
		hy2 = gu;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button m8()
	{
		return gv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void u(Button A_0)
	{
		EventHandler value = dh;
		EventHandler value2 = dg;
		EventHandler value3 = df;
		Button button = gv;
		if (button != null)
		{
			button.Click -= value;
			button.MouseEnter -= value2;
			button.MouseLeave -= value3;
		}
		gv = A_0;
		button = gv;
		if (button != null)
		{
			button.Click += value;
			button.MouseEnter += value2;
			button.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy m9()
	{
		return gw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bf(hy A_0)
	{
		EventHandler value = cn;
		hy hy2 = gw;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		gw = A_0;
		hy2 = gw;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label na()
	{
		return gx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ci(Label A_0)
	{
		gx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox nb()
	{
		return this.m_gy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aa(GroupBox A_0)
	{
		this.m_gy = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel nc()
	{
		return this.m_gz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Panel A_0)
	{
		this.m_gz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton nd()
	{
		return this.m_g0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a2(RadioButton A_0)
	{
		EventHandler value = c0;
		RadioButton radioButton = this.m_g0;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_g0 = A_0;
		radioButton = this.m_g0;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ne()
	{
		return this.m_g1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a3(RadioButton A_0)
	{
		EventHandler value = c1;
		RadioButton radioButton = this.m_g1;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_g1 = A_0;
		radioButton = this.m_g1;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton nf()
	{
		return this.m_g2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bd(RadioButton A_0)
	{
		EventHandler value = cx;
		RadioButton radioButton = this.m_g2;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_g2 = A_0;
		radioButton = this.m_g2;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ng()
	{
		return this.m_g3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void be(RadioButton A_0)
	{
		EventHandler value = cy;
		RadioButton radioButton = this.m_g3;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_g3 = A_0;
		radioButton = this.m_g3;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox nh()
	{
		return g4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(CheckBox A_0)
	{
		EventHandler value = db;
		CheckBox checkBox = g4;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		g4 = A_0;
		checkBox = g4;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy nl()
	{
		return g5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bg(hy A_0)
	{
		EventHandler value = cs;
		hy hy2 = g5;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		g5 = A_0;
		hy2 = g5;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy nm()
	{
		return this.m_g6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bh(hy A_0)
	{
		EventHandler value = cq;
		hy hy2 = this.m_g6;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_g6 = A_0;
		hy2 = this.m_g6;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox nn()
	{
		return g7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(CheckBox A_0)
	{
		EventHandler value = c9;
		CheckBox checkBox = g7;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		g7 = A_0;
		checkBox = g7;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy no()
	{
		return g8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bi(hy A_0)
	{
		EventHandler value = cu;
		hy hy2 = g8;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		g8 = A_0;
		hy2 = g8;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button np()
	{
		return g9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void v(Button A_0)
	{
		EventHandler value = dh;
		EventHandler value2 = dg;
		EventHandler value3 = df;
		Button button = g9;
		if (button != null)
		{
			button.Click -= value;
			button.MouseEnter -= value2;
			button.MouseLeave -= value3;
		}
		g9 = A_0;
		button = g9;
		if (button != null)
		{
			button.Click += value;
			button.MouseEnter += value2;
			button.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy nq()
	{
		return ha;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bj(hy A_0)
	{
		EventHandler value = cn;
		hy hy2 = ha;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		ha = A_0;
		hy2 = ha;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label nr()
	{
		return hb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cj(Label A_0)
	{
		hb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox ns()
	{
		return this.m_hc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ab(GroupBox A_0)
	{
		this.m_hc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel nt()
	{
		return this.m_hd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Panel A_0)
	{
		this.m_hd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton nv()
	{
		return this.m_he;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bf(RadioButton A_0)
	{
		EventHandler value = c0;
		RadioButton radioButton = this.m_he;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_he = A_0;
		radioButton = this.m_he;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton nw()
	{
		return this.m_hf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bg(RadioButton A_0)
	{
		EventHandler value = c1;
		RadioButton radioButton = this.m_hf;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_hf = A_0;
		radioButton = this.m_hf;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton nx()
	{
		return this.m_hg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bh(RadioButton A_0)
	{
		EventHandler value = cx;
		RadioButton radioButton = this.m_hg;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_hg = A_0;
		radioButton = this.m_hg;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ny()
	{
		return this.m_hh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bi(RadioButton A_0)
	{
		EventHandler value = cy;
		RadioButton radioButton = this.m_hh;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_hh = A_0;
		radioButton = this.m_hh;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox nz()
	{
		return hi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(CheckBox A_0)
	{
		EventHandler value = db;
		CheckBox checkBox = hi;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		hi = A_0;
		checkBox = hi;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy n0()
	{
		return hj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bk(hy A_0)
	{
		EventHandler value = cs;
		hy hy2 = hj;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		hj = A_0;
		hy2 = hj;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy n1()
	{
		return this.m_hk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bl(hy A_0)
	{
		EventHandler value = cq;
		hy hy2 = this.m_hk;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_hk = A_0;
		hy2 = this.m_hk;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox n3()
	{
		return hl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(CheckBox A_0)
	{
		EventHandler value = c9;
		CheckBox checkBox = hl;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		hl = A_0;
		checkBox = hl;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy n4()
	{
		return hm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bm(hy A_0)
	{
		EventHandler value = cu;
		hy hy2 = hm;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		hm = A_0;
		hy2 = hm;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button n8()
	{
		return hn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void w(Button A_0)
	{
		EventHandler value = dh;
		EventHandler value2 = dg;
		EventHandler value3 = df;
		Button button = hn;
		if (button != null)
		{
			button.Click -= value;
			button.MouseEnter -= value2;
			button.MouseLeave -= value3;
		}
		hn = A_0;
		button = hn;
		if (button != null)
		{
			button.Click += value;
			button.MouseEnter += value2;
			button.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy oc()
	{
		return ho;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bn(hy A_0)
	{
		EventHandler value = cn;
		hy hy2 = ho;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		ho = A_0;
		hy2 = ho;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label od()
	{
		return hp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ck(Label A_0)
	{
		hp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox oe()
	{
		return this.m_hq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ac(GroupBox A_0)
	{
		this.m_hq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel oh()
	{
		return this.m_hr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Panel A_0)
	{
		this.m_hr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton oj()
	{
		return this.m_hs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bj(RadioButton A_0)
	{
		EventHandler value = c0;
		RadioButton radioButton = this.m_hs;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_hs = A_0;
		radioButton = this.m_hs;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ok()
	{
		return this.m_ht;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bk(RadioButton A_0)
	{
		EventHandler value = c1;
		RadioButton radioButton = this.m_ht;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_ht = A_0;
		radioButton = this.m_ht;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ol()
	{
		return this.m_hu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bl(RadioButton A_0)
	{
		EventHandler value = cx;
		RadioButton radioButton = this.m_hu;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_hu = A_0;
		radioButton = this.m_hu;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton om()
	{
		return this.m_hv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bm(RadioButton A_0)
	{
		EventHandler value = cy;
		RadioButton radioButton = this.m_hv;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_hv = A_0;
		radioButton = this.m_hv;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox on()
	{
		return hw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(CheckBox A_0)
	{
		EventHandler value = db;
		CheckBox checkBox = hw;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		hw = A_0;
		checkBox = hw;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy oo()
	{
		return hx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bo(hy A_0)
	{
		EventHandler value = cs;
		hy hy2 = hx;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		hx = A_0;
		hy2 = hx;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy op()
	{
		return this.m_hy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bp(hy A_0)
	{
		EventHandler value = cq;
		hy hy2 = this.m_hy;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_hy = A_0;
		hy2 = this.m_hy;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox oq()
	{
		return hz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aa(CheckBox A_0)
	{
		EventHandler value = c9;
		CheckBox checkBox = hz;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		hz = A_0;
		checkBox = hz;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy or()
	{
		return h0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bq(hy A_0)
	{
		EventHandler value = cu;
		hy hy2 = h0;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		h0 = A_0;
		hy2 = h0;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button os()
	{
		return h1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void x(Button A_0)
	{
		EventHandler value = dh;
		EventHandler value2 = dg;
		EventHandler value3 = df;
		Button button = h1;
		if (button != null)
		{
			button.Click -= value;
			button.MouseEnter -= value2;
			button.MouseLeave -= value3;
		}
		h1 = A_0;
		button = h1;
		if (button != null)
		{
			button.Click += value;
			button.MouseEnter += value2;
			button.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy ot()
	{
		return h2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void br(hy A_0)
	{
		EventHandler value = cn;
		hy hy2 = h2;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		h2 = A_0;
		hy2 = h2;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ou()
	{
		return h3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cl(Label A_0)
	{
		h3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ov()
	{
		return h4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void y(Button A_0)
	{
		EventHandler value = dp;
		EventHandler value2 = dl;
		EventHandler value3 = dk;
		EventHandler value4 = dj;
		Button button = h4;
		if (button != null)
		{
			button.Click -= value;
			button.EnabledChanged -= value2;
			button.MouseEnter -= value3;
			button.MouseLeave -= value4;
		}
		h4 = A_0;
		button = h4;
		if (button != null)
		{
			button.Click += value;
			button.EnabledChanged += value2;
			button.MouseEnter += value3;
			button.MouseLeave += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ow()
	{
		return h5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void z(Button A_0)
	{
		EventHandler value = dp;
		EventHandler value2 = dl;
		EventHandler value3 = dk;
		EventHandler value4 = dj;
		Button button = h5;
		if (button != null)
		{
			button.Click -= value;
			button.EnabledChanged -= value2;
			button.MouseEnter -= value3;
			button.MouseLeave -= value4;
		}
		h5 = A_0;
		button = h5;
		if (button != null)
		{
			button.Click += value;
			button.EnabledChanged += value2;
			button.MouseEnter += value3;
			button.MouseLeave += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ox()
	{
		return h6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aa(Button A_0)
	{
		EventHandler value = dp;
		EventHandler value2 = dl;
		EventHandler value3 = dk;
		EventHandler value4 = dj;
		Button button = h6;
		if (button != null)
		{
			button.Click -= value;
			button.EnabledChanged -= value2;
			button.MouseEnter -= value3;
			button.MouseLeave -= value4;
		}
		h6 = A_0;
		button = h6;
		if (button != null)
		{
			button.Click += value;
			button.EnabledChanged += value2;
			button.MouseEnter += value3;
			button.MouseLeave += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button oy()
	{
		return h7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ab(Button A_0)
	{
		EventHandler value = dp;
		EventHandler value2 = dl;
		EventHandler value3 = dk;
		EventHandler value4 = dj;
		Button button = h7;
		if (button != null)
		{
			button.Click -= value;
			button.EnabledChanged -= value2;
			button.MouseEnter -= value3;
			button.MouseLeave -= value4;
		}
		h7 = A_0;
		button = h7;
		if (button != null)
		{
			button.Click += value;
			button.EnabledChanged += value2;
			button.MouseEnter += value3;
			button.MouseLeave += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label oz()
	{
		return this.m_h8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cm(Label A_0)
	{
		this.m_h8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage o0()
	{
		return this.m_h9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(TabPage A_0)
	{
		this.m_h9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox o1()
	{
		return this.m_ia;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(GroupBox A_0)
	{
		this.m_ia = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label o2()
	{
		return this.m_ib;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cn(Label A_0)
	{
		this.m_ib = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label o3()
	{
		return this.m_ic;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void co(Label A_0)
	{
		this.m_ic = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy o4()
	{
		return this.m_id;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bs(hy A_0)
	{
		EventHandler value = cp;
		hy hy2 = this.m_id;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_id = A_0;
		hy2 = this.m_id;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label o5()
	{
		return this.m_ie;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cp(Label A_0)
	{
		this.m_ie = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button o6()
	{
		return this.m_if;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(Button A_0)
	{
		EventHandler value = dd;
		Button button = this.m_if;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_if = A_0;
		button = this.m_if;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label o7()
	{
		return this.m_ig;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cq(Label A_0)
	{
		this.m_ig = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label o8()
	{
		return this.m_ih;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cr(Label A_0)
	{
		this.m_ih = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button o9()
	{
		return this.m_ii;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(Button A_0)
	{
		EventHandler value = de;
		Button button = this.m_ii;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ii = A_0;
		button = this.m_ii;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel pl()
	{
		return this.m_ij;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TableLayoutPanel A_0)
	{
		this.m_ij = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy pm()
	{
		return this.m_ik;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bt(hy A_0)
	{
		EventHandler value = ef;
		hy hy2 = this.m_ik;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_ik = A_0;
		hy2 = this.m_ik;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label pn()
	{
		return this.m_il;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cs(Label A_0)
	{
		this.m_il = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel pw()
	{
		return this.m_im;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Panel A_0)
	{
		EventHandler value = b7;
		Panel panel = this.m_im;
		if (panel != null)
		{
			panel.MouseEnter -= value;
		}
		this.m_im = A_0;
		panel = this.m_im;
		if (panel != null)
		{
			panel.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel px()
	{
		return this.m_in;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(Panel A_0)
	{
		EventHandler value = b6;
		Panel panel = this.m_in;
		if (panel != null)
		{
			panel.MouseEnter -= value;
		}
		this.m_in = A_0;
		panel = this.m_in;
		if (panel != null)
		{
			panel.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel py()
	{
		return this.m_io;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(TableLayoutPanel A_0)
	{
		this.m_io = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label p6()
	{
		return this.m_ip;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ct(Label A_0)
	{
		this.m_ip = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label p7()
	{
		return this.m_iq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cu(Label A_0)
	{
		this.m_iq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label p8()
	{
		return this.m_ir;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cv(Label A_0)
	{
		this.m_ir = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label qg()
	{
		return this.m_is;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cw(Label A_0)
	{
		this.m_is = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage qh()
	{
		return this.m_it;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(TabPage A_0)
	{
		this.m_it = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel qi()
	{
		return iu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(Panel A_0)
	{
		iu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox qq()
	{
		return iv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void af(GroupBox A_0)
	{
		iv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ComboBox qr()
	{
		return iw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c(ComboBox A_0)
	{
		iw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox qs()
	{
		return ix;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void al(GroupBox A_0)
	{
		ix = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton q0()
	{
		return iy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bn(RadioButton A_0)
	{
		iy = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton q1()
	{
		return iz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bo(RadioButton A_0)
	{
		iz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton q2()
	{
		return i0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bp(RadioButton A_0)
	{
		i0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton re()
	{
		return i1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bq(RadioButton A_0)
	{
		i1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox rf()
	{
		return i2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void am(GroupBox A_0)
	{
		i2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ComboBox rg()
	{
		return i3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void d(ComboBox A_0)
	{
		i3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ComboBox rj()
	{
		return i4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void e(ComboBox A_0)
	{
		i4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label rk()
	{
		return i5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cx(Label A_0)
	{
		i5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label rl()
	{
		return i6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cy(Label A_0)
	{
		i6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ru()
	{
		return i7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cz(Label A_0)
	{
		i7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label rv()
	{
		return i8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c0(Label A_0)
	{
		i8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label rw()
	{
		return i9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c1(Label A_0)
	{
		i9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox r5()
	{
		return ja;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void an(GroupBox A_0)
	{
		ja = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox r6()
	{
		return jb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ab(CheckBox A_0)
	{
		jb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox r7()
	{
		return jc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ac(CheckBox A_0)
	{
		jc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox sg()
	{
		return jd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ao(GroupBox A_0)
	{
		jd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label sh()
	{
		return je;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c2(Label A_0)
	{
		je = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label si()
	{
		return jf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c3(Label A_0)
	{
		jf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label sr()
	{
		return jg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c4(Label A_0)
	{
		jg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ss()
	{
		return jh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c5(Label A_0)
	{
		jh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label st()
	{
		return ji;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c6(Label A_0)
	{
		ji = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label s2()
	{
		return jj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c7(Label A_0)
	{
		jj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox s3()
	{
		return jk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ad(CheckBox A_0)
	{
		jk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox s4()
	{
		return jl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void af(CheckBox A_0)
	{
		jl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox tb()
	{
		return jm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aq(GroupBox A_0)
	{
		jm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox tc()
	{
		return jn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void al(CheckBox A_0)
	{
		jn = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox td()
	{
		return jo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void am(CheckBox A_0)
	{
		jo = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox te()
	{
		return jp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void an(CheckBox A_0)
	{
		jp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox tf()
	{
		return jq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ao(CheckBox A_0)
	{
		jq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox tg()
	{
		return jr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ar(GroupBox A_0)
	{
		jr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton th()
	{
		return js;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void br(RadioButton A_0)
	{
		js = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton ti()
	{
		return jt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bs(RadioButton A_0)
	{
		jt = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label tj()
	{
		return ju;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c8(Label A_0)
	{
		ju = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label tk()
	{
		return jv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c9(Label A_0)
	{
		jv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label tl()
	{
		return jw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void da(Label A_0)
	{
		jw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label tm()
	{
		return jx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void db(Label A_0)
	{
		jx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label tn()
	{
		return jy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void dc(Label A_0)
	{
		jy = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label to()
	{
		return jz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void dd(Label A_0)
	{
		jz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox tp()
	{
		return j0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aq(CheckBox A_0)
	{
		j0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox tr()
	{
		return this.m_j1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ar(CheckBox A_0)
	{
		this.m_j1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ts()
	{
		return this.m_j2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bu(hy A_0)
	{
		this.m_j2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy tt()
	{
		return this.m_j3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bv(hy A_0)
	{
		this.m_j3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy t5()
	{
		return this.m_j4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bw(hy A_0)
	{
		this.m_j4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy t6()
	{
		return this.m_j5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bx(hy A_0)
	{
		this.m_j5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy t7()
	{
		return this.m_j6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void by(hy A_0)
	{
		this.m_j6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy t8()
	{
		return this.m_j7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bz(hy A_0)
	{
		this.m_j7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy t9()
	{
		return this.m_j8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b0(hy A_0)
	{
		this.m_j8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage ua()
	{
		return this.m_j9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(TabPage A_0)
	{
		this.m_j9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ub()
	{
		return this.m_ka;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void de(Label A_0)
	{
		this.m_ka = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ue()
	{
		return this.m_kb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void df(Label A_0)
	{
		this.m_kb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label um()
	{
		return this.m_kc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void dg(Label A_0)
	{
		this.m_kc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy uu()
	{
		return this.m_kd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b1(hy A_0)
	{
		EventHandler value = bl;
		hy hy2 = this.m_kd;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_kd = A_0;
		hy2 = this.m_kd;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy uv()
	{
		return this.m_ke;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b2(hy A_0)
	{
		EventHandler value = bl;
		hy hy2 = this.m_ke;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_ke = A_0;
		hy2 = this.m_ke;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy uw()
	{
		return this.m_kf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b3(hy A_0)
	{
		EventHandler value = bq;
		hy hy2 = this.m_kf;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_kf = A_0;
		hy2 = this.m_kf;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy u6()
	{
		return this.m_kg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b4(hy A_0)
	{
		EventHandler value = bq;
		hy hy2 = this.m_kg;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_kg = A_0;
		hy2 = this.m_kg;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label u7()
	{
		return this.m_kh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void dh(Label A_0)
	{
		this.m_kh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage u8()
	{
		return this.m_ki;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(TabPage A_0)
	{
		this.m_ki = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton u9()
	{
		return this.m_kj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bt(RadioButton A_0)
	{
		EventHandler value = bz;
		RadioButton radioButton = this.m_kj;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_kj = A_0;
		radioButton = this.m_kj;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton va()
	{
		return this.m_kk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bu(RadioButton A_0)
	{
		EventHandler value = bw;
		RadioButton radioButton = this.m_kk;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_kk = A_0;
		radioButton = this.m_kk;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton vb()
	{
		return this.m_kl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bv(RadioButton A_0)
	{
		EventHandler value = bx;
		RadioButton radioButton = this.m_kl;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_kl = A_0;
		radioButton = this.m_kl;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton vc()
	{
		return this.m_km;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bw(RadioButton A_0)
	{
		EventHandler value = bz;
		RadioButton radioButton = this.m_km;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_km = A_0;
		radioButton = this.m_km;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox vd()
	{
		return this.m_kn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a1(CheckBox A_0)
	{
		EventHandler value = e8;
		CheckBox checkBox = this.m_kn;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_kn = A_0;
		checkBox = this.m_kn;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ve()
	{
		return this.m_ko;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a2(CheckBox A_0)
	{
		EventHandler value = e6;
		CheckBox checkBox = this.m_ko;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_ko = A_0;
		checkBox = this.m_ko;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox vf()
	{
		return this.m_kp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a3(CheckBox A_0)
	{
		EventHandler value = e7;
		CheckBox checkBox = this.m_kp;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_kp = A_0;
		checkBox = this.m_kp;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox vg()
	{
		return this.m_kq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bd(CheckBox A_0)
	{
		EventHandler value = bt;
		CheckBox checkBox = this.m_kq;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_kq = A_0;
		checkBox = this.m_kq;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox vh()
	{
		return this.m_kr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void be(CheckBox A_0)
	{
		EventHandler value = bt;
		CheckBox checkBox = this.m_kr;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_kr = A_0;
		checkBox = this.m_kr;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox vi()
	{
		return this.m_ks;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bf(CheckBox A_0)
	{
		EventHandler value = bt;
		CheckBox checkBox = this.m_ks;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_ks = A_0;
		checkBox = this.m_ks;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox vj()
	{
		return this.m_kt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bg(CheckBox A_0)
	{
		EventHandler value = e9;
		CheckBox checkBox = this.m_kt;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_kt = A_0;
		checkBox = this.m_kt;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox vk()
	{
		return this.m_ku;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bh(CheckBox A_0)
	{
		EventHandler value = bu;
		CheckBox checkBox = this.m_ku;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_ku = A_0;
		checkBox = this.m_ku;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel vl()
	{
		return this.m_kv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(TableLayoutPanel A_0)
	{
		this.m_kv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel vm()
	{
		return this.m_kw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(TableLayoutPanel A_0)
	{
		this.m_kw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel vn()
	{
		return this.m_kx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(Panel A_0)
	{
		this.m_kx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy vo()
	{
		return this.m_ky;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b5(hy A_0)
	{
		this.m_ky = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy vp()
	{
		return this.m_kz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b6(hy A_0)
	{
		this.m_kz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label vq()
	{
		return this.m_k0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void di(Label A_0)
	{
		this.m_k0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label vr()
	{
		return this.m_k1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void dj(Label A_0)
	{
		this.m_k1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label vs()
	{
		return this.m_k2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void dk(Label A_0)
	{
		this.m_k2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label vt()
	{
		return this.m_k3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void dl(Label A_0)
	{
		this.m_k3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel vu()
	{
		return this.m_k4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(TableLayoutPanel A_0)
	{
		this.m_k4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox vv()
	{
		return this.m_k5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bi(CheckBox A_0)
	{
		EventHandler value = ex;
		CheckBox checkBox = this.m_k5;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_k5 = A_0;
		checkBox = this.m_k5;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label vw()
	{
		return this.m_k6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void dp(Label A_0)
	{
		this.m_k6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label vx()
	{
		return this.m_k7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d2(Label A_0)
	{
		this.m_k7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy vy()
	{
		return this.m_k8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b7(hy A_0)
	{
		EventHandler value = eu;
		hy hy2 = this.m_k8;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_k8 = A_0;
		hy2 = this.m_k8;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy vz()
	{
		return this.m_k9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b8(hy A_0)
	{
		EventHandler value = et;
		hy hy2 = this.m_k9;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_k9 = A_0;
		hy2 = this.m_k9;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy v0()
	{
		return this.m_la;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b9(hy A_0)
	{
		EventHandler value = es;
		hy hy2 = this.m_la;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_la = A_0;
		hy2 = this.m_la;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy v1()
	{
		return this.m_lb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ca(hy A_0)
	{
		EventHandler value = er;
		hy hy2 = this.m_lb;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_lb = A_0;
		hy2 = this.m_lb;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy v2()
	{
		return this.m_lc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cb(hy A_0)
	{
		EventHandler value = eq;
		hy hy2 = this.m_lc;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_lc = A_0;
		hy2 = this.m_lc;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy v3()
	{
		return this.m_ld;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cc(hy A_0)
	{
		EventHandler value = ep;
		hy hy2 = this.m_ld;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_ld = A_0;
		hy2 = this.m_ld;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label v4()
	{
		return this.m_le;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d6(Label A_0)
	{
		this.m_le = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label v5()
	{
		return this.m_lf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ef(Label A_0)
	{
		this.m_lf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label v6()
	{
		return this.m_lg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void eh(Label A_0)
	{
		this.m_lg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox v7()
	{
		return this.m_lh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a1(GroupBox A_0)
	{
		this.m_lh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton v8()
	{
		return this.m_li;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bx(RadioButton A_0)
	{
		this.m_li = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton v9()
	{
		return this.m_lj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void by(RadioButton A_0)
	{
		this.m_lj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton wa()
	{
		return this.m_lk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bz(RadioButton A_0)
	{
		this.m_lk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton wb()
	{
		return this.m_ll;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(ToolStripButton A_0)
	{
		EventHandler value = o;
		ToolStripButton toolStripButton = this.m_ll;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_ll = A_0;
		toolStripButton = this.m_ll;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripSeparator wc()
	{
		return this.m_lm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolStripSeparator A_0)
	{
		this.m_lm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button wd()
	{
		return this.m_ln;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void af(Button A_0)
	{
		EventHandler value = fu;
		Button button = this.m_ln;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ln = A_0;
		button = this.m_ln;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel we()
	{
		return this.m_lo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(TableLayoutPanel A_0)
	{
		this.m_lo = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel wf()
	{
		return this.m_lp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(TableLayoutPanel A_0)
	{
		this.m_lp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox wg()
	{
		return this.m_lq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(ComboBox A_0)
	{
		EventHandler value = br;
		ComboBox comboBox = this.m_lq;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_lq = A_0;
		comboBox = this.m_lq;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label wh()
	{
		return this.m_lr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ep(Label A_0)
	{
		this.m_lr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridView wi()
	{
		return this.m_ls;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridView A_0)
	{
		DataGridViewCellEventHandler value = a;
		EventHandler value2 = b3;
		DataGridView dataGridView = this.m_ls;
		if (dataGridView != null)
		{
			dataGridView.CellValueChanged -= value;
			dataGridView.Leave -= value2;
		}
		this.m_ls = A_0;
		dataGridView = this.m_ls;
		if (dataGridView != null)
		{
			dataGridView.CellValueChanged += value;
			dataGridView.Leave += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel wj()
	{
		return this.m_lt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(TableLayoutPanel A_0)
	{
		this.m_lt = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel wk()
	{
		return this.m_lu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(TableLayoutPanel A_0)
	{
		this.m_lu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox wl()
	{
		return this.m_lv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a2(GroupBox A_0)
	{
		this.m_lv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox wm()
	{
		return this.m_lw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bj(CheckBox A_0)
	{
		EventHandler value = bs;
		CheckBox checkBox = this.m_lw;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_lw = A_0;
		checkBox = this.m_lw;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox wn()
	{
		return this.m_lx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a3(GroupBox A_0)
	{
		this.m_lx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy wo()
	{
		return this.m_ly;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cd(hy A_0)
	{
		EventHandler value = bo;
		hy hy2 = this.m_ly;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_ly = A_0;
		hy2 = this.m_ly;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label wp()
	{
		return this.m_lz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void eq(Label A_0)
	{
		this.m_lz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label wq()
	{
		return this.m_l0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void er(Label A_0)
	{
		this.m_l0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy wr()
	{
		return this.m_l1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ce(hy A_0)
	{
		EventHandler value = bn;
		hy hy2 = this.m_l1;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_l1 = A_0;
		hy2 = this.m_l1;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ws()
	{
		return this.m_l2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void es(Label A_0)
	{
		this.m_l2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy wu()
	{
		return this.m_l3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cf(hy A_0)
	{
		EventHandler value = bm;
		hy hy2 = this.m_l3;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_l3 = A_0;
		hy2 = this.m_l3;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label wv()
	{
		return this.m_l4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void et(Label A_0)
	{
		this.m_l4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label w0()
	{
		return this.m_l5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void eu(Label A_0)
	{
		this.m_l5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel w1()
	{
		return this.m_l6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(TableLayoutPanel A_0)
	{
		this.m_l6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage w2()
	{
		return this.m_l7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(TabPage A_0)
	{
		LayoutEventHandler value = a;
		TabPage tabPage = this.m_l7;
		if (tabPage != null)
		{
			tabPage.Layout -= value;
		}
		this.m_l7 = A_0;
		tabPage = this.m_l7;
		if (tabPage != null)
		{
			tabPage.Layout += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel w3()
	{
		return this.m_l8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(Panel A_0)
	{
		this.m_l8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel w4()
	{
		return this.m_l9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(TableLayoutPanel A_0)
	{
		this.m_l9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel w5()
	{
		return this.m_ma;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(TableLayoutPanel A_0)
	{
		this.m_ma = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label w6()
	{
		return this.m_mb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ev(Label A_0)
	{
		this.m_mb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual NumericUpDown w7()
	{
		return this.m_mc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(NumericUpDown A_0)
	{
		EventHandler value = aa;
		NumericUpDown numericUpDown = this.m_mc;
		if (numericUpDown != null)
		{
			numericUpDown.ValueChanged -= value;
		}
		this.m_mc = A_0;
		numericUpDown = this.m_mc;
		if (numericUpDown != null)
		{
			numericUpDown.ValueChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox w8()
	{
		return this.m_md;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bk(CheckBox A_0)
	{
		EventHandler value = ao;
		CheckBox checkBox = this.m_md;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_md = A_0;
		checkBox = this.m_md;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel w9()
	{
		return this.m_me;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(TableLayoutPanel A_0)
	{
		this.m_me = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox xa()
	{
		return this.m_mf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(ComboBox A_0)
	{
		EventHandler value = af;
		ComboBox comboBox = this.m_mf;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_mf = A_0;
		comboBox = this.m_mf;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label xb()
	{
		return this.m_mg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ew(Label A_0)
	{
		this.m_mg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel xc()
	{
		return this.m_mh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(TableLayoutPanel A_0)
	{
		this.m_mh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label xd()
	{
		return this.m_mi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ex(Label A_0)
	{
		this.m_mi = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy xe()
	{
		return this.m_mj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cg(hy A_0)
	{
		EventHandler value = ac;
		hy hy2 = this.m_mj;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_mj = A_0;
		hy2 = this.m_mj;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton xf()
	{
		return this.m_mk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b0(RadioButton A_0)
	{
		EventHandler value = ab;
		RadioButton radioButton = this.m_mk;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_mk = A_0;
		radioButton = this.m_mk;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton xi()
	{
		return this.m_ml;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b1(RadioButton A_0)
	{
		this.m_ml = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox xj()
	{
		return this.m_mm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bl(CheckBox A_0)
	{
		EventHandler value = al;
		CheckBox checkBox = this.m_mm;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_mm = A_0;
		checkBox = this.m_mm;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label xk()
	{
		return this.m_mn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ey(Label A_0)
	{
		this.m_mn = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel xl()
	{
		return this.m_mo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(TableLayoutPanel A_0)
	{
		this.m_mo = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label xm()
	{
		return this.m_mp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ez(Label A_0)
	{
		this.m_mp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy xn()
	{
		return this.m_mq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ch(hy A_0)
	{
		EventHandler value = ad;
		hy hy2 = this.m_mq;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_mq = A_0;
		hy2 = this.m_mq;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label xo()
	{
		return this.m_mr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e0(Label A_0)
	{
		this.m_mr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel xp()
	{
		return this.m_ms;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(TableLayoutPanel A_0)
	{
		this.m_ms = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label xq()
	{
		return this.m_mt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e1(Label A_0)
	{
		this.m_mt = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual NumericUpDown xr()
	{
		return this.m_mu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(NumericUpDown A_0)
	{
		EventHandler value = z;
		NumericUpDown numericUpDown = this.m_mu;
		if (numericUpDown != null)
		{
			numericUpDown.ValueChanged -= value;
		}
		this.m_mu = A_0;
		numericUpDown = this.m_mu;
		if (numericUpDown != null)
		{
			numericUpDown.ValueChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox xs()
	{
		return this.m_mv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bm(CheckBox A_0)
	{
		EventHandler value = am;
		CheckBox checkBox = this.m_mv;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_mv = A_0;
		checkBox = this.m_mv;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel xt()
	{
		return this.m_mw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aa(TableLayoutPanel A_0)
	{
		this.m_mw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label xu()
	{
		return this.m_mx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e2(Label A_0)
	{
		this.m_mx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox xv()
	{
		return this.m_my;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bn(CheckBox A_0)
	{
		EventHandler value = aq;
		CheckBox checkBox = this.m_my;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_my = A_0;
		checkBox = this.m_my;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual NumericUpDown xw()
	{
		return this.m_mz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(NumericUpDown A_0)
	{
		EventHandler value = y;
		NumericUpDown numericUpDown = this.m_mz;
		if (numericUpDown != null)
		{
			numericUpDown.ValueChanged -= value;
		}
		this.m_mz = A_0;
		numericUpDown = this.m_mz;
		if (numericUpDown != null)
		{
			numericUpDown.ValueChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel xx()
	{
		return this.m_m0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(TableLayoutPanel A_0)
	{
		this.m_m0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox xy()
	{
		return this.m_m1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bo(CheckBox A_0)
	{
		EventHandler value = an;
		CheckBox checkBox = this.m_m1;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_m1 = A_0;
		checkBox = this.m_m1;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label xz()
	{
		return this.m_m2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e3(Label A_0)
	{
		this.m_m2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual NumericUpDown x0()
	{
		return this.m_m3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(NumericUpDown A_0)
	{
		EventHandler value = x;
		NumericUpDown numericUpDown = this.m_m3;
		if (numericUpDown != null)
		{
			numericUpDown.ValueChanged -= value;
		}
		this.m_m3 = A_0;
		numericUpDown = this.m_m3;
		if (numericUpDown != null)
		{
			numericUpDown.ValueChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel x1()
	{
		return this.m_m4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(TableLayoutPanel A_0)
	{
		this.m_m4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label x2()
	{
		return this.m_m5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e4(Label A_0)
	{
		this.m_m5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox x3()
	{
		return this.m_m6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(ComboBox A_0)
	{
		EventHandler value = ar;
		ComboBox comboBox = this.m_m6;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_m6 = A_0;
		comboBox = this.m_m6;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel x4()
	{
		return this.m_m7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(TableLayoutPanel A_0)
	{
		this.m_m7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy x5()
	{
		return this.m_m8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ci(hy A_0)
	{
		EventHandler value = a1;
		hy hy2 = this.m_m8;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_m8 = A_0;
		hy2 = this.m_m8;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label x6()
	{
		return this.m_m9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e5(Label A_0)
	{
		this.m_m9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox x7()
	{
		return this.m_na;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bd(GroupBox A_0)
	{
		this.m_na = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton x8()
	{
		return this.m_nb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b2(RadioButton A_0)
	{
		EventHandler value = by;
		RadioButton radioButton = this.m_nb;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_nb = A_0;
		radioButton = this.m_nb;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton x9()
	{
		return this.m_nc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b3(RadioButton A_0)
	{
		EventHandler value = by;
		RadioButton radioButton = this.m_nc;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_nc = A_0;
		radioButton = this.m_nc;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn ya()
	{
		return this.m_nd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridViewTextBoxColumn A_0)
	{
		this.m_nd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn yb()
	{
		return this.m_ne;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(DataGridViewTextBoxColumn A_0)
	{
		this.m_ne = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewCheckBoxColumn yc()
	{
		return this.m_nf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridViewCheckBoxColumn A_0)
	{
		this.m_nf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn yd()
	{
		return this.m_ng;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(DataGridViewTextBoxColumn A_0)
	{
		this.m_ng = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage ye()
	{
		return this.m_nh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(TabPage A_0)
	{
		EventHandler value = b8;
		LayoutEventHandler value2 = d;
		TabPage tabPage = this.m_nh;
		if (tabPage != null)
		{
			tabPage.MouseEnter -= value;
			tabPage.Layout -= value2;
		}
		this.m_nh = A_0;
		tabPage = this.m_nh;
		if (tabPage != null)
		{
			tabPage.MouseEnter += value;
			tabPage.Layout += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox yf()
	{
		return ni;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void be(GroupBox A_0)
	{
		ni = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button yg()
	{
		return nj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void al(Button A_0)
	{
		EventHandler value = hg;
		Button button = nj;
		if (button != null)
		{
			button.Click -= value;
		}
		nj = A_0;
		button = nj;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual TextBox yh()
	{
		return nk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c(TextBox A_0)
	{
		EventHandler value = gn;
		TextBox textBox = nk;
		if (textBox != null)
		{
			textBox.Click -= value;
		}
		nk = A_0;
		textBox = nk;
		if (textBox != null)
		{
			textBox.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label yi()
	{
		return this.m_nl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void e6(Label A_0)
	{
		this.m_nl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox yj()
	{
		return this.m_nm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bp(CheckBox A_0)
	{
		EventHandler value = b9;
		CheckBox checkBox = this.m_nm;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_nm = A_0;
		checkBox = this.m_nm;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel yk()
	{
		return this.m_nn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(Panel A_0)
	{
		EventHandler value = b8;
		Panel panel = this.m_nn;
		if (panel != null)
		{
			panel.MouseEnter -= value;
		}
		this.m_nn = A_0;
		panel = this.m_nn;
		if (panel != null)
		{
			panel.MouseEnter += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel yl()
	{
		return this.m_no;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void af(TableLayoutPanel A_0)
	{
		this.m_no = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel ym()
	{
		return this.m_np;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(Panel A_0)
	{
		this.m_np = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel yn()
	{
		return this.m_nq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(Panel A_0)
	{
		this.m_nq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label yo()
	{
		return this.m_nr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e7(Label A_0)
	{
		this.m_nr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox yp()
	{
		return this.m_ns;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bq(CheckBox A_0)
	{
		EventHandler value = dc;
		CheckBox checkBox = this.m_ns;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_ns = A_0;
		checkBox = this.m_ns;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox yq()
	{
		return this.m_nt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TextBox A_0)
	{
		EventHandler value = gn;
		TextBox textBox = this.m_nt;
		if (textBox != null)
		{
			textBox.Click -= value;
		}
		this.m_nt = A_0;
		textBox = this.m_nt;
		if (textBox != null)
		{
			textBox.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button yr()
	{
		return nu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void am(Button A_0)
	{
		EventHandler value = hg;
		Button button = nu;
		if (button != null)
		{
			button.Click -= value;
		}
		nu = A_0;
		button = nu;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ys()
	{
		return this.m_nv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void e8(Label A_0)
	{
		this.m_nv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox yt()
	{
		return this.m_nw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void br(CheckBox A_0)
	{
		EventHandler value = c8;
		CheckBox checkBox = this.m_nw;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_nw = A_0;
		checkBox = this.m_nw;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox yu()
	{
		return this.m_nx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bs(CheckBox A_0)
	{
		EventHandler value = c8;
		CheckBox checkBox = this.m_nx;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_nx = A_0;
		checkBox = this.m_nx;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox yv()
	{
		return this.m_ny;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bt(CheckBox A_0)
	{
		EventHandler value = c8;
		CheckBox checkBox = this.m_ny;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_ny = A_0;
		checkBox = this.m_ny;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox yw()
	{
		return this.m_nz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bu(CheckBox A_0)
	{
		EventHandler value = c8;
		CheckBox checkBox = this.m_nz;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_nz = A_0;
		checkBox = this.m_nz;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox yx()
	{
		return this.m_n0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bv(CheckBox A_0)
	{
		EventHandler value = c8;
		CheckBox checkBox = this.m_n0;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_n0 = A_0;
		checkBox = this.m_n0;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox yy()
	{
		return this.m_n1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bw(CheckBox A_0)
	{
		EventHandler value = c8;
		CheckBox checkBox = this.m_n1;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_n1 = A_0;
		checkBox = this.m_n1;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel yz()
	{
		return n2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void al(TableLayoutPanel A_0)
	{
		n2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox y0()
	{
		return this.m_n3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bf(GroupBox A_0)
	{
		this.m_n3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy y1()
	{
		return this.m_n4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cj(hy A_0)
	{
		this.m_n4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy y2()
	{
		return n5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ck(hy A_0)
	{
		n5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label y3()
	{
		return n6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void e9(Label A_0)
	{
		n6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label y4()
	{
		return n7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void fa(Label A_0)
	{
		n7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label y5()
	{
		return this.m_n8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void fb(Label A_0)
	{
		this.m_n8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy y6()
	{
		return n9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cl(hy A_0)
	{
		n9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton y7()
	{
		return oa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b4(RadioButton A_0)
	{
		oa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton y8()
	{
		return ob;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b5(RadioButton A_0)
	{
		ob = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label y9()
	{
		return this.m_oc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void fc(Label A_0)
	{
		this.m_oc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual NumericUpDown za()
	{
		return this.m_od;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(NumericUpDown A_0)
	{
		this.m_od = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox zb()
	{
		return this.m_oe;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bg(GroupBox A_0)
	{
		this.m_oe = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox zc()
	{
		return of;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bh(GroupBox A_0)
	{
		of = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton zd()
	{
		return og;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b6(RadioButton A_0)
	{
		og = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton ze()
	{
		return this.m_oh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b7(RadioButton A_0)
	{
		this.m_oh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox zf()
	{
		return oi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bi(GroupBox A_0)
	{
		oi = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox zg()
	{
		return this.m_oj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bx(CheckBox A_0)
	{
		this.m_oj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button zh()
	{
		return this.m_ok;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void an(Button A_0)
	{
		EventHandler value = he;
		Button button = this.m_ok;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ok = A_0;
		button = this.m_ok;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ErrorProvider zi()
	{
		return this.m_ol;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ErrorProvider A_0)
	{
		this.m_ol = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label zj()
	{
		return this.m_om;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void fr(Label A_0)
	{
		this.m_om = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy zk()
	{
		return this.m_on;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cm(hy A_0)
	{
		CancelEventHandler value = b;
		hy hy2 = this.m_on;
		if (hy2 != null)
		{
			hy2.Validating -= value;
		}
		this.m_on = A_0;
		hy2 = this.m_on;
		if (hy2 != null)
		{
			hy2.Validating += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel zl()
	{
		return this.m_oo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void am(TableLayoutPanel A_0)
	{
		this.m_oo = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox zm()
	{
		return this.m_op;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bj(GroupBox A_0)
	{
		this.m_op = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton zn()
	{
		return this.m_oq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b8(RadioButton A_0)
	{
		EventHandler value = bh;
		RadioButton radioButton = this.m_oq;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_oq = A_0;
		radioButton = this.m_oq;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton zo()
	{
		return this.m_or;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b9(RadioButton A_0)
	{
		EventHandler value = bi;
		RadioButton radioButton = this.m_or;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_or = A_0;
		radioButton = this.m_or;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton zp()
	{
		return this.m_os;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ca(RadioButton A_0)
	{
		EventHandler value = bj;
		RadioButton radioButton = this.m_os;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_os = A_0;
		radioButton = this.m_os;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox zq()
	{
		return this.m_ot;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void by(CheckBox A_0)
	{
		EventHandler value = bk;
		CheckBox checkBox = this.m_ot;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_ot = A_0;
		checkBox = this.m_ot;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label zr()
	{
		return this.m_ou;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void fs(Label A_0)
	{
		this.m_ou = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label zs()
	{
		return this.m_ov;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ft(Label A_0)
	{
		this.m_ov = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy zt()
	{
		return this.m_ow;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cn(hy A_0)
	{
		EventHandler value = bg;
		hy hy2 = this.m_ow;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_ow = A_0;
		hy2 = this.m_ow;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button zu()
	{
		return this.m_ox;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ao(Button A_0)
	{
		EventHandler value = a2;
		Button button = this.m_ox;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ox = A_0;
		button = this.m_ox;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox zv()
	{
		return this.m_oy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bk(GroupBox A_0)
	{
		this.m_oy = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label zw()
	{
		return this.m_oz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void fu(Label A_0)
	{
		this.m_oz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label zx()
	{
		return this.m_o0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void fv(Label A_0)
	{
		this.m_o0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label zy()
	{
		return this.m_o1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void fw(Label A_0)
	{
		this.m_o1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy zz()
	{
		return this.m_o2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void co(hy A_0)
	{
		EventHandler value = a;
		hy hy2 = this.m_o2;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_o2 = A_0;
		hy2 = this.m_o2;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox z0()
	{
		return this.m_o3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bz(CheckBox A_0)
	{
		this.m_o3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox z1()
	{
		return this.m_o4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bl(GroupBox A_0)
	{
		this.m_o4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button z2()
	{
		return this.m_o5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aq(Button A_0)
	{
		this.m_o5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel z3()
	{
		return this.m_o6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void an(TableLayoutPanel A_0)
	{
		this.m_o6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel z4()
	{
		return this.m_o7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(Panel A_0)
	{
		this.m_o7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox z5()
	{
		return this.m_o8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b0(CheckBox A_0)
	{
		EventHandler value = c7;
		CheckBox checkBox = this.m_o8;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_o8 = A_0;
		checkBox = this.m_o8;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox z6()
	{
		return this.m_o9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b1(CheckBox A_0)
	{
		EventHandler value = c7;
		CheckBox checkBox = this.m_o9;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_o9 = A_0;
		checkBox = this.m_o9;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel z7()
	{
		return pa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(Panel A_0)
	{
		pa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label z8()
	{
		return pb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void fz(Label A_0)
	{
		pb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label z9()
	{
		return pc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void f6(Label A_0)
	{
		pc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aaa()
	{
		return pd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void f7(Label A_0)
	{
		pd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aab()
	{
		return pe;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void f8(Label A_0)
	{
		pe = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button aac()
	{
		return pf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ar(Button A_0)
	{
		EventHandler value = d2;
		EventHandler value2 = dl;
		EventHandler value3 = dk;
		EventHandler value4 = dj;
		Button button = pf;
		if (button != null)
		{
			button.Click -= value;
			button.EnabledChanged -= value2;
			button.MouseEnter -= value3;
			button.MouseLeave -= value4;
		}
		pf = A_0;
		button = pf;
		if (button != null)
		{
			button.Click += value;
			button.EnabledChanged += value2;
			button.MouseEnter += value3;
			button.MouseLeave += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aad()
	{
		return pg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void f9(Label A_0)
	{
		pg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aae()
	{
		return ph;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ga(Label A_0)
	{
		ph = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aaf()
	{
		return pi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void gb(Label A_0)
	{
		pi = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aag()
	{
		return pj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ge(Label A_0)
	{
		pj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aah()
	{
		return pk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void gk(Label A_0)
	{
		pk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox aai()
	{
		return this.m_pl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bm(GroupBox A_0)
	{
		this.m_pl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton aaj()
	{
		return this.m_pm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cb(RadioButton A_0)
	{
		EventHandler value = c3;
		RadioButton radioButton = this.m_pm;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_pm = A_0;
		radioButton = this.m_pm;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton aak()
	{
		return this.m_pn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cc(RadioButton A_0)
	{
		EventHandler value = c4;
		RadioButton radioButton = this.m_pn;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_pn = A_0;
		radioButton = this.m_pn;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox aal()
	{
		return po;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b2(CheckBox A_0)
	{
		EventHandler value = da;
		CheckBox checkBox = po;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		po = A_0;
		checkBox = po;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy aam()
	{
		return pp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cp(hy A_0)
	{
		EventHandler value = ct;
		hy hy2 = pp;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		pp = A_0;
		hy2 = pp;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy aan()
	{
		return pq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cq(hy A_0)
	{
		EventHandler value = cv;
		hy hy2 = pq;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		pq = A_0;
		hy2 = pq;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button aao()
	{
		return pr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a1(Button A_0)
	{
		EventHandler value = di;
		EventHandler value2 = dg;
		EventHandler value3 = df;
		Button button = pr;
		if (button != null)
		{
			button.Click -= value;
			button.MouseEnter -= value2;
			button.MouseLeave -= value3;
		}
		pr = A_0;
		button = pr;
		if (button != null)
		{
			button.Click += value;
			button.MouseEnter += value2;
			button.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy aap()
	{
		return ps;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cr(hy A_0)
	{
		EventHandler value = cr;
		hy hy2 = ps;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		ps = A_0;
		hy2 = ps;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy aaq()
	{
		return pt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cs(hy A_0)
	{
		EventHandler value = co;
		hy hy2 = pt;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		pt = A_0;
		hy2 = pt;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aar()
	{
		return pu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void gl(Label A_0)
	{
		pu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button aas()
	{
		return pv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a2(Button A_0)
	{
		EventHandler value = d2;
		EventHandler value2 = dl;
		EventHandler value3 = dk;
		EventHandler value4 = dj;
		Button button = pv;
		if (button != null)
		{
			button.Click -= value;
			button.EnabledChanged -= value2;
			button.MouseEnter -= value3;
			button.MouseLeave -= value4;
		}
		pv = A_0;
		button = pv;
		if (button != null)
		{
			button.Click += value;
			button.EnabledChanged += value2;
			button.MouseEnter += value3;
			button.MouseLeave += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox aat()
	{
		return this.m_pw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bn(GroupBox A_0)
	{
		this.m_pw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton aau()
	{
		return this.m_px;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cd(RadioButton A_0)
	{
		EventHandler value = c3;
		RadioButton radioButton = this.m_px;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_px = A_0;
		radioButton = this.m_px;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton aav()
	{
		return this.m_py;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ce(RadioButton A_0)
	{
		EventHandler value = c4;
		RadioButton radioButton = this.m_py;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_py = A_0;
		radioButton = this.m_py;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox aaw()
	{
		return pz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b3(CheckBox A_0)
	{
		EventHandler value = da;
		CheckBox checkBox = pz;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		pz = A_0;
		checkBox = pz;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy aax()
	{
		return p0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ct(hy A_0)
	{
		EventHandler value = ct;
		hy hy2 = p0;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		p0 = A_0;
		hy2 = p0;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy aay()
	{
		return p1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cu(hy A_0)
	{
		EventHandler value = cv;
		hy hy2 = p1;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		p1 = A_0;
		hy2 = p1;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy aaz()
	{
		return p2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cv(hy A_0)
	{
		EventHandler value = cr;
		hy hy2 = p2;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		p2 = A_0;
		hy2 = p2;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button aa0()
	{
		return p3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a3(Button A_0)
	{
		EventHandler value = di;
		EventHandler value2 = dg;
		EventHandler value3 = df;
		Button button = p3;
		if (button != null)
		{
			button.Click -= value;
			button.MouseEnter -= value2;
			button.MouseLeave -= value3;
		}
		p3 = A_0;
		button = p3;
		if (button != null)
		{
			button.Click += value;
			button.MouseEnter += value2;
			button.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy aa1()
	{
		return p4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cw(hy A_0)
	{
		EventHandler value = co;
		hy hy2 = p4;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		p4 = A_0;
		hy2 = p4;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aa2()
	{
		return p5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void gm(Label A_0)
	{
		p5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox aa3()
	{
		return this.m_p6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bo(GroupBox A_0)
	{
		this.m_p6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton aa4()
	{
		return this.m_p7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cf(RadioButton A_0)
	{
		EventHandler value = c3;
		RadioButton radioButton = this.m_p7;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_p7 = A_0;
		radioButton = this.m_p7;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton aa5()
	{
		return this.m_p8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cg(RadioButton A_0)
	{
		EventHandler value = c4;
		RadioButton radioButton = this.m_p8;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_p8 = A_0;
		radioButton = this.m_p8;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox aa6()
	{
		return p9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b4(CheckBox A_0)
	{
		EventHandler value = da;
		CheckBox checkBox = p9;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		p9 = A_0;
		checkBox = p9;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy aa7()
	{
		return qa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cx(hy A_0)
	{
		EventHandler value = ct;
		hy hy2 = qa;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		qa = A_0;
		hy2 = qa;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy aa8()
	{
		return qb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cy(hy A_0)
	{
		EventHandler value = cv;
		hy hy2 = qb;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		qb = A_0;
		hy2 = qb;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy aa9()
	{
		return qc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cz(hy A_0)
	{
		EventHandler value = cr;
		hy hy2 = qc;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		qc = A_0;
		hy2 = qc;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button aba()
	{
		return qd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bd(Button A_0)
	{
		EventHandler value = di;
		EventHandler value2 = dg;
		EventHandler value3 = df;
		Button button = qd;
		if (button != null)
		{
			button.Click -= value;
			button.MouseEnter -= value2;
			button.MouseLeave -= value3;
		}
		qd = A_0;
		button = qd;
		if (button != null)
		{
			button.Click += value;
			button.MouseEnter += value2;
			button.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy abb()
	{
		return qe;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c0(hy A_0)
	{
		EventHandler value = co;
		hy hy2 = qe;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		qe = A_0;
		hy2 = qe;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label abc()
	{
		return qf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void gn(Label A_0)
	{
		qf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox abd()
	{
		return this.m_qg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bp(GroupBox A_0)
	{
		this.m_qg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton abe()
	{
		return this.m_qh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ch(RadioButton A_0)
	{
		EventHandler value = c3;
		RadioButton radioButton = this.m_qh;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_qh = A_0;
		radioButton = this.m_qh;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton abf()
	{
		return this.m_qi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ci(RadioButton A_0)
	{
		EventHandler value = c4;
		RadioButton radioButton = this.m_qi;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_qi = A_0;
		radioButton = this.m_qi;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox abg()
	{
		return qj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b5(CheckBox A_0)
	{
		EventHandler value = da;
		CheckBox checkBox = qj;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		qj = A_0;
		checkBox = qj;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy abh()
	{
		return qk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c1(hy A_0)
	{
		EventHandler value = ct;
		hy hy2 = qk;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		qk = A_0;
		hy2 = qk;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy abi()
	{
		return ql;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c2(hy A_0)
	{
		EventHandler value = cv;
		hy hy2 = ql;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		ql = A_0;
		hy2 = ql;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy abj()
	{
		return qm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c3(hy A_0)
	{
		EventHandler value = cr;
		hy hy2 = qm;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		qm = A_0;
		hy2 = qm;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button abk()
	{
		return qn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void be(Button A_0)
	{
		EventHandler value = di;
		EventHandler value2 = dg;
		EventHandler value3 = df;
		Button button = qn;
		if (button != null)
		{
			button.Click -= value;
			button.MouseEnter -= value2;
			button.MouseLeave -= value3;
		}
		qn = A_0;
		button = qn;
		if (button != null)
		{
			button.Click += value;
			button.MouseEnter += value2;
			button.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy abl()
	{
		return qo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c4(hy A_0)
	{
		EventHandler value = co;
		hy hy2 = qo;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		qo = A_0;
		hy2 = qo;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label abm()
	{
		return qp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void go(Label A_0)
	{
		qp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox abn()
	{
		return this.m_qq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bq(GroupBox A_0)
	{
		this.m_qq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton abo()
	{
		return this.m_qr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cj(RadioButton A_0)
	{
		EventHandler value = c3;
		RadioButton radioButton = this.m_qr;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_qr = A_0;
		radioButton = this.m_qr;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton abp()
	{
		return this.m_qs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ck(RadioButton A_0)
	{
		EventHandler value = c4;
		RadioButton radioButton = this.m_qs;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_qs = A_0;
		radioButton = this.m_qs;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox abq()
	{
		return qt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b6(CheckBox A_0)
	{
		EventHandler value = da;
		CheckBox checkBox = qt;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		qt = A_0;
		checkBox = qt;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy abr()
	{
		return qu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c5(hy A_0)
	{
		EventHandler value = ct;
		hy hy2 = qu;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		qu = A_0;
		hy2 = qu;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy abs()
	{
		return qv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c6(hy A_0)
	{
		EventHandler value = cv;
		hy hy2 = qv;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		qv = A_0;
		hy2 = qv;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy abt()
	{
		return qw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c7(hy A_0)
	{
		EventHandler value = cr;
		hy hy2 = qw;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		qw = A_0;
		hy2 = qw;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button abu()
	{
		return qx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bf(Button A_0)
	{
		EventHandler value = di;
		EventHandler value2 = dg;
		EventHandler value3 = df;
		Button button = qx;
		if (button != null)
		{
			button.Click -= value;
			button.MouseEnter -= value2;
			button.MouseLeave -= value3;
		}
		qx = A_0;
		button = qx;
		if (button != null)
		{
			button.Click += value;
			button.MouseEnter += value2;
			button.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy abv()
	{
		return qy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c8(hy A_0)
	{
		EventHandler value = co;
		hy hy2 = qy;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		qy = A_0;
		hy2 = qy;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label abw()
	{
		return qz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void gp(Label A_0)
	{
		qz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox abx()
	{
		return this.m_q0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void br(GroupBox A_0)
	{
		this.m_q0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton aby()
	{
		return this.m_q1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cl(RadioButton A_0)
	{
		EventHandler value = c3;
		RadioButton radioButton = this.m_q1;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_q1 = A_0;
		radioButton = this.m_q1;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton abz()
	{
		return this.m_q2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cm(RadioButton A_0)
	{
		EventHandler value = c4;
		RadioButton radioButton = this.m_q2;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_q2 = A_0;
		radioButton = this.m_q2;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ab0()
	{
		return q3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b7(CheckBox A_0)
	{
		EventHandler value = da;
		CheckBox checkBox = q3;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		q3 = A_0;
		checkBox = q3;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy ab1()
	{
		return q4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c9(hy A_0)
	{
		EventHandler value = ct;
		hy hy2 = q4;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		q4 = A_0;
		hy2 = q4;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy ab2()
	{
		return q5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void da(hy A_0)
	{
		EventHandler value = cv;
		hy hy2 = q5;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		q5 = A_0;
		hy2 = q5;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy ab3()
	{
		return q6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void db(hy A_0)
	{
		EventHandler value = cr;
		hy hy2 = q6;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		q6 = A_0;
		hy2 = q6;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ab4()
	{
		return q7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bg(Button A_0)
	{
		EventHandler value = di;
		EventHandler value2 = dg;
		EventHandler value3 = df;
		Button button = q7;
		if (button != null)
		{
			button.Click -= value;
			button.MouseEnter -= value2;
			button.MouseLeave -= value3;
		}
		q7 = A_0;
		button = q7;
		if (button != null)
		{
			button.Click += value;
			button.MouseEnter += value2;
			button.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy ab5()
	{
		return q8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void dc(hy A_0)
	{
		EventHandler value = co;
		hy hy2 = q8;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		q8 = A_0;
		hy2 = q8;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ab6()
	{
		return q9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void gs(Label A_0)
	{
		q9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ab7()
	{
		return ra;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bh(Button A_0)
	{
		EventHandler value = d2;
		EventHandler value2 = dl;
		EventHandler value3 = dk;
		EventHandler value4 = dj;
		Button button = ra;
		if (button != null)
		{
			button.Click -= value;
			button.EnabledChanged -= value2;
			button.MouseEnter -= value3;
			button.MouseLeave -= value4;
		}
		ra = A_0;
		button = ra;
		if (button != null)
		{
			button.Click += value;
			button.EnabledChanged += value2;
			button.MouseEnter += value3;
			button.MouseLeave += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ab8()
	{
		return rb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bi(Button A_0)
	{
		EventHandler value = d2;
		EventHandler value2 = dl;
		EventHandler value3 = dk;
		EventHandler value4 = dj;
		Button button = rb;
		if (button != null)
		{
			button.Click -= value;
			button.EnabledChanged -= value2;
			button.MouseEnter -= value3;
			button.MouseLeave -= value4;
		}
		rb = A_0;
		button = rb;
		if (button != null)
		{
			button.Click += value;
			button.EnabledChanged += value2;
			button.MouseEnter += value3;
			button.MouseLeave += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ab9()
	{
		return rc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bj(Button A_0)
	{
		EventHandler value = d2;
		EventHandler value2 = dl;
		EventHandler value3 = dk;
		EventHandler value4 = dj;
		Button button = rc;
		if (button != null)
		{
			button.Click -= value;
			button.EnabledChanged -= value2;
			button.MouseEnter -= value3;
			button.MouseLeave -= value4;
		}
		rc = A_0;
		button = rc;
		if (button != null)
		{
			button.Click += value;
			button.EnabledChanged += value2;
			button.MouseEnter += value3;
			button.MouseLeave += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button aca()
	{
		return rd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bk(Button A_0)
	{
		EventHandler value = d2;
		EventHandler value2 = dl;
		EventHandler value3 = dk;
		EventHandler value4 = dj;
		Button button = rd;
		if (button != null)
		{
			button.Click -= value;
			button.EnabledChanged -= value2;
			button.MouseEnter -= value3;
			button.MouseLeave -= value4;
		}
		rd = A_0;
		button = rd;
		if (button != null)
		{
			button.Click += value;
			button.EnabledChanged += value2;
			button.MouseEnter += value3;
			button.MouseLeave += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label acb()
	{
		return this.m_re;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void gy(Label A_0)
	{
		this.m_re = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox acc()
	{
		return this.m_rf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bs(GroupBox A_0)
	{
		this.m_rf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label acd()
	{
		return this.m_rg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void gz(Label A_0)
	{
		this.m_rg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ace()
	{
		return rh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b8(CheckBox A_0)
	{
		EventHandler value = c7;
		CheckBox checkBox = rh;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		rh = A_0;
		checkBox = rh;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button acf()
	{
		return ri;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bl(Button A_0)
	{
		EventHandler value = d2;
		EventHandler value2 = dl;
		EventHandler value3 = dk;
		EventHandler value4 = dj;
		Button button = ri;
		if (button != null)
		{
			button.Click -= value;
			button.EnabledChanged -= value2;
			button.MouseEnter -= value3;
			button.MouseLeave -= value4;
		}
		ri = A_0;
		button = ri;
		if (button != null)
		{
			button.Click += value;
			button.EnabledChanged += value2;
			button.MouseEnter += value3;
			button.MouseLeave += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox acg()
	{
		return this.m_rj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bt(GroupBox A_0)
	{
		this.m_rj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ach()
	{
		return this.m_rk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cn(RadioButton A_0)
	{
		EventHandler value = c3;
		RadioButton radioButton = this.m_rk;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_rk = A_0;
		radioButton = this.m_rk;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton aci()
	{
		return this.m_rl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void co(RadioButton A_0)
	{
		EventHandler value = c4;
		RadioButton radioButton = this.m_rl;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_rl = A_0;
		radioButton = this.m_rl;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox acj()
	{
		return rm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b9(CheckBox A_0)
	{
		EventHandler value = da;
		CheckBox checkBox = rm;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		rm = A_0;
		checkBox = rm;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy ack()
	{
		return rn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void dd(hy A_0)
	{
		EventHandler value = ct;
		hy hy2 = rn;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		rn = A_0;
		hy2 = rn;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy acl()
	{
		return ro;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void de(hy A_0)
	{
		EventHandler value = cv;
		hy hy2 = ro;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		ro = A_0;
		hy2 = ro;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy acm()
	{
		return rp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void df(hy A_0)
	{
		EventHandler value = cr;
		hy hy2 = rp;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		rp = A_0;
		hy2 = rp;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button acn()
	{
		return rq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bm(Button A_0)
	{
		EventHandler value = di;
		EventHandler value2 = dg;
		EventHandler value3 = df;
		Button button = rq;
		if (button != null)
		{
			button.Click -= value;
			button.MouseEnter -= value2;
			button.MouseLeave -= value3;
		}
		rq = A_0;
		button = rq;
		if (button != null)
		{
			button.Click += value;
			button.MouseEnter += value2;
			button.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy aco()
	{
		return rr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void dg(hy A_0)
	{
		EventHandler value = co;
		hy hy2 = rr;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		rr = A_0;
		hy2 = rr;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label acp()
	{
		return rs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void g0(Label A_0)
	{
		rs = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button acq()
	{
		return rt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bn(Button A_0)
	{
		EventHandler value = d2;
		EventHandler value2 = dl;
		EventHandler value3 = dk;
		EventHandler value4 = dj;
		Button button = rt;
		if (button != null)
		{
			button.Click -= value;
			button.EnabledChanged -= value2;
			button.MouseEnter -= value3;
			button.MouseLeave -= value4;
		}
		rt = A_0;
		button = rt;
		if (button != null)
		{
			button.Click += value;
			button.EnabledChanged += value2;
			button.MouseEnter += value3;
			button.MouseLeave += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox acr()
	{
		return this.m_ru;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bu(GroupBox A_0)
	{
		this.m_ru = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton acs()
	{
		return this.m_rv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cp(RadioButton A_0)
	{
		EventHandler value = c3;
		RadioButton radioButton = this.m_rv;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_rv = A_0;
		radioButton = this.m_rv;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton act()
	{
		return this.m_rw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cq(RadioButton A_0)
	{
		EventHandler value = c4;
		RadioButton radioButton = this.m_rw;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_rw = A_0;
		radioButton = this.m_rw;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox acu()
	{
		return rx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ca(CheckBox A_0)
	{
		EventHandler value = da;
		CheckBox checkBox = rx;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		rx = A_0;
		checkBox = rx;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy acv()
	{
		return ry;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void dh(hy A_0)
	{
		EventHandler value = ct;
		hy hy2 = ry;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		ry = A_0;
		hy2 = ry;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy acw()
	{
		return rz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void di(hy A_0)
	{
		EventHandler value = cv;
		hy hy2 = rz;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		rz = A_0;
		hy2 = rz;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy acx()
	{
		return r0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void dj(hy A_0)
	{
		EventHandler value = cr;
		hy hy2 = r0;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		r0 = A_0;
		hy2 = r0;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button acy()
	{
		return r1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bo(Button A_0)
	{
		EventHandler value = di;
		EventHandler value2 = dg;
		EventHandler value3 = df;
		Button button = r1;
		if (button != null)
		{
			button.Click -= value;
			button.MouseEnter -= value2;
			button.MouseLeave -= value3;
		}
		r1 = A_0;
		button = r1;
		if (button != null)
		{
			button.Click += value;
			button.MouseEnter += value2;
			button.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy acz()
	{
		return r2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void dk(hy A_0)
	{
		EventHandler value = co;
		hy hy2 = r2;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		r2 = A_0;
		hy2 = r2;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ac0()
	{
		return r3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void g1(Label A_0)
	{
		r3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ac1()
	{
		return r4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bp(Button A_0)
	{
		EventHandler value = d2;
		EventHandler value2 = dl;
		EventHandler value3 = dk;
		EventHandler value4 = dj;
		Button button = r4;
		if (button != null)
		{
			button.Click -= value;
			button.EnabledChanged -= value2;
			button.MouseEnter -= value3;
			button.MouseLeave -= value4;
		}
		r4 = A_0;
		button = r4;
		if (button != null)
		{
			button.Click += value;
			button.EnabledChanged += value2;
			button.MouseEnter += value3;
			button.MouseLeave += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox ac2()
	{
		return this.m_r5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bv(GroupBox A_0)
	{
		this.m_r5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ac3()
	{
		return this.m_r6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cr(RadioButton A_0)
	{
		EventHandler value = c3;
		RadioButton radioButton = this.m_r6;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_r6 = A_0;
		radioButton = this.m_r6;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ac4()
	{
		return this.m_r7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cs(RadioButton A_0)
	{
		EventHandler value = c4;
		RadioButton radioButton = this.m_r7;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_r7 = A_0;
		radioButton = this.m_r7;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ac5()
	{
		return r8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cb(CheckBox A_0)
	{
		EventHandler value = da;
		CheckBox checkBox = r8;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		r8 = A_0;
		checkBox = r8;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy ac6()
	{
		return r9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void dl(hy A_0)
	{
		EventHandler value = ct;
		hy hy2 = r9;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		r9 = A_0;
		hy2 = r9;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy ac7()
	{
		return sa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void dp(hy A_0)
	{
		EventHandler value = cv;
		hy hy2 = sa;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		sa = A_0;
		hy2 = sa;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy ac8()
	{
		return sb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void d2(hy A_0)
	{
		EventHandler value = cr;
		hy hy2 = sb;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		sb = A_0;
		hy2 = sb;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ac9()
	{
		return sc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bq(Button A_0)
	{
		EventHandler value = di;
		EventHandler value2 = dg;
		EventHandler value3 = df;
		Button button = sc;
		if (button != null)
		{
			button.Click -= value;
			button.MouseEnter -= value2;
			button.MouseLeave -= value3;
		}
		sc = A_0;
		button = sc;
		if (button != null)
		{
			button.Click += value;
			button.MouseEnter += value2;
			button.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy ada()
	{
		return sd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void d6(hy A_0)
	{
		EventHandler value = co;
		hy hy2 = sd;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		sd = A_0;
		hy2 = sd;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label adb()
	{
		return se;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void g2(Label A_0)
	{
		se = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button adc()
	{
		return sf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void br(Button A_0)
	{
		EventHandler value = d2;
		EventHandler value2 = dl;
		EventHandler value3 = dk;
		EventHandler value4 = dj;
		Button button = sf;
		if (button != null)
		{
			button.Click -= value;
			button.EnabledChanged -= value2;
			button.MouseEnter -= value3;
			button.MouseLeave -= value4;
		}
		sf = A_0;
		button = sf;
		if (button != null)
		{
			button.Click += value;
			button.EnabledChanged += value2;
			button.MouseEnter += value3;
			button.MouseLeave += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox add()
	{
		return this.m_sg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bw(GroupBox A_0)
	{
		this.m_sg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ade()
	{
		return this.m_sh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ct(RadioButton A_0)
	{
		EventHandler value = c3;
		RadioButton radioButton = this.m_sh;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_sh = A_0;
		radioButton = this.m_sh;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton adf()
	{
		return this.m_si;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cu(RadioButton A_0)
	{
		EventHandler value = c4;
		RadioButton radioButton = this.m_si;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_si = A_0;
		radioButton = this.m_si;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox adg()
	{
		return sj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cc(CheckBox A_0)
	{
		EventHandler value = da;
		CheckBox checkBox = sj;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		sj = A_0;
		checkBox = sj;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy adh()
	{
		return sk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ef(hy A_0)
	{
		EventHandler value = ct;
		hy hy2 = sk;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		sk = A_0;
		hy2 = sk;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy adi()
	{
		return sl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void eh(hy A_0)
	{
		EventHandler value = cv;
		hy hy2 = sl;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		sl = A_0;
		hy2 = sl;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy adj()
	{
		return sm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ep(hy A_0)
	{
		EventHandler value = cr;
		hy hy2 = sm;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		sm = A_0;
		hy2 = sm;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button adk()
	{
		return sn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bs(Button A_0)
	{
		EventHandler value = di;
		EventHandler value2 = dg;
		EventHandler value3 = df;
		Button button = sn;
		if (button != null)
		{
			button.Click -= value;
			button.MouseEnter -= value2;
			button.MouseLeave -= value3;
		}
		sn = A_0;
		button = sn;
		if (button != null)
		{
			button.Click += value;
			button.MouseEnter += value2;
			button.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy adl()
	{
		return so;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void eq(hy A_0)
	{
		EventHandler value = co;
		hy hy2 = so;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		so = A_0;
		hy2 = so;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label adm()
	{
		return sp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void g3(Label A_0)
	{
		sp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button adn()
	{
		return sq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bt(Button A_0)
	{
		EventHandler value = d2;
		EventHandler value2 = dl;
		EventHandler value3 = dk;
		EventHandler value4 = dj;
		Button button = sq;
		if (button != null)
		{
			button.Click -= value;
			button.EnabledChanged -= value2;
			button.MouseEnter -= value3;
			button.MouseLeave -= value4;
		}
		sq = A_0;
		button = sq;
		if (button != null)
		{
			button.Click += value;
			button.EnabledChanged += value2;
			button.MouseEnter += value3;
			button.MouseLeave += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox ado()
	{
		return this.m_sr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bx(GroupBox A_0)
	{
		this.m_sr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton adp()
	{
		return this.m_ss;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cv(RadioButton A_0)
	{
		EventHandler value = c3;
		RadioButton radioButton = this.m_ss;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_ss = A_0;
		radioButton = this.m_ss;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton adq()
	{
		return this.m_st;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cw(RadioButton A_0)
	{
		EventHandler value = c4;
		RadioButton radioButton = this.m_st;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_st = A_0;
		radioButton = this.m_st;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox adr()
	{
		return su;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cd(CheckBox A_0)
	{
		EventHandler value = da;
		CheckBox checkBox = su;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		su = A_0;
		checkBox = su;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy ads()
	{
		return sv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void er(hy A_0)
	{
		EventHandler value = ct;
		hy hy2 = sv;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		sv = A_0;
		hy2 = sv;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy adt()
	{
		return sw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void es(hy A_0)
	{
		EventHandler value = cv;
		hy hy2 = sw;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		sw = A_0;
		hy2 = sw;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy adu()
	{
		return sx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void et(hy A_0)
	{
		EventHandler value = cr;
		hy hy2 = sx;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		sx = A_0;
		hy2 = sx;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button adv()
	{
		return sy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bu(Button A_0)
	{
		EventHandler value = di;
		EventHandler value2 = dg;
		EventHandler value3 = df;
		Button button = sy;
		if (button != null)
		{
			button.Click -= value;
			button.MouseEnter -= value2;
			button.MouseLeave -= value3;
		}
		sy = A_0;
		button = sy;
		if (button != null)
		{
			button.Click += value;
			button.MouseEnter += value2;
			button.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy adw()
	{
		return sz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void eu(hy A_0)
	{
		EventHandler value = co;
		hy hy2 = sz;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		sz = A_0;
		hy2 = sz;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label adx()
	{
		return s0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void g6(Label A_0)
	{
		s0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ady()
	{
		return s1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bv(Button A_0)
	{
		EventHandler value = d2;
		EventHandler value2 = dl;
		EventHandler value3 = dk;
		EventHandler value4 = dj;
		Button button = s1;
		if (button != null)
		{
			button.Click -= value;
			button.EnabledChanged -= value2;
			button.MouseEnter -= value3;
			button.MouseLeave -= value4;
		}
		s1 = A_0;
		button = s1;
		if (button != null)
		{
			button.Click += value;
			button.EnabledChanged += value2;
			button.MouseEnter += value3;
			button.MouseLeave += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox adz()
	{
		return this.m_s2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void by(GroupBox A_0)
	{
		this.m_s2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ad0()
	{
		return this.m_s3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cx(RadioButton A_0)
	{
		EventHandler value = c3;
		RadioButton radioButton = this.m_s3;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_s3 = A_0;
		radioButton = this.m_s3;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ad1()
	{
		return this.m_s4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cy(RadioButton A_0)
	{
		EventHandler value = c4;
		RadioButton radioButton = this.m_s4;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_s4 = A_0;
		radioButton = this.m_s4;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ad2()
	{
		return s5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ce(CheckBox A_0)
	{
		EventHandler value = da;
		CheckBox checkBox = s5;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		s5 = A_0;
		checkBox = s5;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy ad3()
	{
		return s6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ev(hy A_0)
	{
		EventHandler value = ct;
		hy hy2 = s6;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		s6 = A_0;
		hy2 = s6;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy ad4()
	{
		return s7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ew(hy A_0)
	{
		EventHandler value = cv;
		hy hy2 = s7;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		s7 = A_0;
		hy2 = s7;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy ad5()
	{
		return s8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ex(hy A_0)
	{
		EventHandler value = cr;
		hy hy2 = s8;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		s8 = A_0;
		hy2 = s8;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ad6()
	{
		return s9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void bw(Button A_0)
	{
		EventHandler value = di;
		EventHandler value2 = dg;
		EventHandler value3 = df;
		Button button = s9;
		if (button != null)
		{
			button.Click -= value;
			button.MouseEnter -= value2;
			button.MouseLeave -= value3;
		}
		s9 = A_0;
		button = s9;
		if (button != null)
		{
			button.Click += value;
			button.MouseEnter += value2;
			button.MouseLeave += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy ad7()
	{
		return ta;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ey(hy A_0)
	{
		EventHandler value = co;
		hy hy2 = ta;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		ta = A_0;
		hy2 = ta;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ad8()
	{
		return this.m_tb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void hc(Label A_0)
	{
		this.m_tb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ad9()
	{
		return this.m_tc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ao(TableLayoutPanel A_0)
	{
		this.m_tc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button aea()
	{
		return this.m_td;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bx(Button A_0)
	{
		this.m_td = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel aeb()
	{
		return this.m_te;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aq(TableLayoutPanel A_0)
	{
		this.m_te = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox aec()
	{
		return this.m_tf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bz(GroupBox A_0)
	{
		this.m_tf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox aed()
	{
		return this.m_tg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cf(CheckBox A_0)
	{
		EventHandler value = c6;
		CheckBox checkBox = this.m_tg;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_tg = A_0;
		checkBox = this.m_tg;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip aee()
	{
		return this.m_th;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ToolTip A_0)
	{
		this.m_th = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip aef()
	{
		return this.m_ti;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ToolTip A_0)
	{
		this.m_ti = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip aeg()
	{
		return this.m_tj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(ToolTip A_0)
	{
		this.m_tj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip aeh()
	{
		return this.m_tk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(ToolTip A_0)
	{
		this.m_tk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip aei()
	{
		return this.m_tl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(ToolTip A_0)
	{
		this.m_tl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip aej()
	{
		return this.m_tm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(ToolTip A_0)
	{
		this.m_tm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button aek()
	{
		return this.m_tn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void by(Button A_0)
	{
		this.m_tn = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage ael()
	{
		return this.m_to;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(TabPage A_0)
	{
		this.m_to = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage aem()
	{
		return this.m_tp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(TabPage A_0)
	{
		this.m_tp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel aen()
	{
		return tq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(Panel A_0)
	{
		tq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox aeo()
	{
		return this.m_tr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b0(GroupBox A_0)
	{
		this.m_tr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy aep()
	{
		return this.m_ts;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ez(hy A_0)
	{
		this.m_ts = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy aeq()
	{
		return this.m_tt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e0(hy A_0)
	{
		this.m_tt = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy aer()
	{
		return tu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e1(hy A_0)
	{
		tu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton aes()
	{
		return tv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cz(RadioButton A_0)
	{
		tv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton aet()
	{
		return tw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c0(RadioButton A_0)
	{
		tw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox aeu()
	{
		return tx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cg(CheckBox A_0)
	{
		tx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox aev()
	{
		return ty;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ch(CheckBox A_0)
	{
		ty = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aew()
	{
		return tz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void hd(Label A_0)
	{
		tz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aex()
	{
		return t0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void he(Label A_0)
	{
		t0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aey()
	{
		return t1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void hf(Label A_0)
	{
		t1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aez()
	{
		return t2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void hg(Label A_0)
	{
		t2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ae0()
	{
		return t3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void hh(Label A_0)
	{
		t3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ae1()
	{
		return t4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void hk(Label A_0)
	{
		t4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox ae2()
	{
		return this.m_t5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b1(GroupBox A_0)
	{
		this.m_t5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel ae3()
	{
		return this.m_t6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(Panel A_0)
	{
		this.m_t6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ae4()
	{
		return this.m_t7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void hq(Label A_0)
	{
		this.m_t7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ae5()
	{
		return this.m_t8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void hr(Label A_0)
	{
		this.m_t8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ae6()
	{
		return this.m_t9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e2(hy A_0)
	{
		this.m_t9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ae7()
	{
		return this.m_ua;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e3(hy A_0)
	{
		this.m_ua = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ae8()
	{
		return this.m_ub;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void hs(Label A_0)
	{
		this.m_ub = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ae9()
	{
		return uc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ht(Label A_0)
	{
		uc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ComboBox afa()
	{
		return ud;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void i(ComboBox A_0)
	{
		ud = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox afb()
	{
		return this.m_ue;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b2(GroupBox A_0)
	{
		this.m_ue = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy afc()
	{
		return uf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e4(hy A_0)
	{
		uf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ComboBox afd()
	{
		return ug;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void j(ComboBox A_0)
	{
		ug = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ComboBox afe()
	{
		return uh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void k(ComboBox A_0)
	{
		uh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aff()
	{
		return ui;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void hu(Label A_0)
	{
		ui = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label afg()
	{
		return uj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void hv(Label A_0)
	{
		uj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label afh()
	{
		return uk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void hy(Label A_0)
	{
		uk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label afi()
	{
		return ul;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void h8(Label A_0)
	{
		ul = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label afj()
	{
		return this.m_um;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void h9(Label A_0)
	{
		this.m_um = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel afk()
	{
		return un;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(Panel A_0)
	{
		un = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox afl()
	{
		return uo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b3(GroupBox A_0)
	{
		uo = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox afm()
	{
		return up;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ci(CheckBox A_0)
	{
		up = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox afn()
	{
		return uq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cj(CheckBox A_0)
	{
		uq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox afo()
	{
		return ur;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ck(CheckBox A_0)
	{
		ur = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox afp()
	{
		return us;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b4(GroupBox A_0)
	{
		us = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox afq()
	{
		return ut;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cl(CheckBox A_0)
	{
		ut = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox afr()
	{
		return this.m_uu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b5(GroupBox A_0)
	{
		this.m_uu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy afs()
	{
		return this.m_uv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e5(hy A_0)
	{
		this.m_uv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy aft()
	{
		return this.m_uw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e6(hy A_0)
	{
		this.m_uw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy afu()
	{
		return ux;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e7(hy A_0)
	{
		ux = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox afv()
	{
		return uy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cm(CheckBox A_0)
	{
		uy = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label afw()
	{
		return uz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ia(Label A_0)
	{
		uz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label afx()
	{
		return u0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ib(Label A_0)
	{
		u0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label afy()
	{
		return u1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ic(Label A_0)
	{
		u1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label afz()
	{
		return u2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void id(Label A_0)
	{
		u2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label af0()
	{
		return u3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ie(Label A_0)
	{
		u3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label af1()
	{
		return u4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void @if(Label A_0)
	{
		u4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox af2()
	{
		return u5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cn(CheckBox A_0)
	{
		u5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox af3()
	{
		return this.m_u6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b6(GroupBox A_0)
	{
		this.m_u6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button af4()
	{
		return this.m_u7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bz(Button A_0)
	{
		this.m_u7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox af5()
	{
		return this.m_u8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void co(CheckBox A_0)
	{
		this.m_u8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button af6()
	{
		return this.m_u9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b0(Button A_0)
	{
		EventHandler value = q;
		Button button = this.m_u9;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_u9 = A_0;
		button = this.m_u9;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox af7()
	{
		return this.m_va;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b7(GroupBox A_0)
	{
		this.m_va = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label af8()
	{
		return this.m_vb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ig(Label A_0)
	{
		this.m_vb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy af9()
	{
		return this.m_vc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e8(hy A_0)
	{
		EventHandler value = be;
		hy hy2 = this.m_vc;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_vc = A_0;
		hy2 = this.m_vc;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aga()
	{
		return this.m_vd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ih(Label A_0)
	{
		this.m_vd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel agb()
	{
		return this.m_ve;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ar(TableLayoutPanel A_0)
	{
		this.m_ve = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage agc()
	{
		return this.m_vf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(TabPage A_0)
	{
		this.m_vf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox agd()
	{
		return this.m_vg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cp(CheckBox A_0)
	{
		EventHandler value = cl;
		CheckBox checkBox = this.m_vg;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_vg = A_0;
		checkBox = this.m_vg;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox age()
	{
		return this.m_vh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cq(CheckBox A_0)
	{
		EventHandler value = cm;
		CheckBox checkBox = this.m_vh;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_vh = A_0;
		checkBox = this.m_vh;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox agf()
	{
		return this.m_vi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b8(GroupBox A_0)
	{
		this.m_vi = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel agg()
	{
		return this.m_vj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a1(TableLayoutPanel A_0)
	{
		this.m_vj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton agh()
	{
		return this.m_vk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c1(RadioButton A_0)
	{
		EventHandler value = cf;
		RadioButton radioButton = this.m_vk;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_vk = A_0;
		radioButton = this.m_vk;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton agi()
	{
		return this.m_vl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c2(RadioButton A_0)
	{
		EventHandler value = cg;
		RadioButton radioButton = this.m_vl;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_vl = A_0;
		radioButton = this.m_vl;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel agj()
	{
		return this.m_vm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a2(TableLayoutPanel A_0)
	{
		this.m_vm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label agk()
	{
		return this.m_vn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ii(Label A_0)
	{
		this.m_vn = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy agl()
	{
		return this.m_vo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e9(hy A_0)
	{
		EventHandler value = ch;
		hy hy2 = this.m_vo;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_vo = A_0;
		hy2 = this.m_vo;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label agm()
	{
		return this.m_vp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ij(Label A_0)
	{
		this.m_vp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox agn()
	{
		return this.m_vq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b9(GroupBox A_0)
	{
		this.m_vq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ago()
	{
		return this.m_vr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a3(TableLayoutPanel A_0)
	{
		this.m_vr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label agp()
	{
		return this.m_vs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ik(Label A_0)
	{
		this.m_vs = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton agq()
	{
		return this.m_vt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c3(RadioButton A_0)
	{
		EventHandler value = ck;
		RadioButton radioButton = this.m_vt;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_vt = A_0;
		radioButton = this.m_vt;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy agr()
	{
		return this.m_vu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void fa(hy A_0)
	{
		EventHandler value = ci;
		hy hy2 = this.m_vu;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_vu = A_0;
		hy2 = this.m_vu;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ags()
	{
		return this.m_vv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void il(Label A_0)
	{
		this.m_vv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy agt()
	{
		return this.m_vw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void fb(hy A_0)
	{
		EventHandler value = cd;
		hy hy2 = this.m_vw;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_vw = A_0;
		hy2 = this.m_vw;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label agu()
	{
		return this.m_vx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void im(Label A_0)
	{
		this.m_vx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy agv()
	{
		return this.m_vy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void fc(hy A_0)
	{
		EventHandler value = ce;
		hy hy2 = this.m_vy;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_vy = A_0;
		hy2 = this.m_vy;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton agw()
	{
		return this.m_vz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c4(RadioButton A_0)
	{
		EventHandler value = cj;
		RadioButton radioButton = this.m_vz;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_vz = A_0;
		radioButton = this.m_vz;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label agx()
	{
		return this.m_v0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void @in(Label A_0)
	{
		this.m_v0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel agy()
	{
		return this.m_v1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bd(TableLayoutPanel A_0)
	{
		this.m_v1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox agz()
	{
		return this.m_v2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ca(GroupBox A_0)
	{
		this.m_v2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ag0()
	{
		return this.m_v3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void be(TableLayoutPanel A_0)
	{
		this.m_v3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ag1()
	{
		return this.m_v4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void io(Label A_0)
	{
		this.m_v4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ag2()
	{
		return this.m_v5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bf(TableLayoutPanel A_0)
	{
		this.m_v5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ag3()
	{
		return this.m_v6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ip(Label A_0)
	{
		this.m_v6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ag4()
	{
		return this.m_v7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void iq(Label A_0)
	{
		this.m_v7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ag5()
	{
		return this.m_v8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void fr(hy A_0)
	{
		EventHandler value = cc;
		hy hy2 = this.m_v8;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_v8 = A_0;
		hy2 = this.m_v8;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ag6()
	{
		return this.m_v9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bg(TableLayoutPanel A_0)
	{
		this.m_v9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ag7()
	{
		return this.m_wa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c5(RadioButton A_0)
	{
		EventHandler value = ca;
		RadioButton radioButton = this.m_wa;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_wa = A_0;
		radioButton = this.m_wa;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ag8()
	{
		return this.m_wb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c6(RadioButton A_0)
	{
		EventHandler value = cb;
		RadioButton radioButton = this.m_wb;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_wb = A_0;
		radioButton = this.m_wb;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ag9()
	{
		return this.m_wc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cb(GroupBox A_0)
	{
		this.m_wc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel aha()
	{
		return this.m_wd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bh(TableLayoutPanel A_0)
	{
		this.m_wd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ahb()
	{
		return this.m_we;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bi(TableLayoutPanel A_0)
	{
		this.m_we = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel ahc()
	{
		return this.m_wf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(Panel A_0)
	{
		this.m_wf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel ahd()
	{
		return this.m_wg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aa(Panel A_0)
	{
		this.m_wg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ahe()
	{
		return this.m_wh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ir(Label A_0)
	{
		this.m_wh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ahf()
	{
		return this.m_wi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void @is(Label A_0)
	{
		this.m_wi = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ahg()
	{
		return this.m_wj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void it(Label A_0)
	{
		this.m_wj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ahh()
	{
		return this.m_wk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void fs(hy A_0)
	{
		EventHandler value = bd;
		hy hy2 = this.m_wk;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_wk = A_0;
		hy2 = this.m_wk;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ahi()
	{
		return this.m_wl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ft(hy A_0)
	{
		EventHandler value = a3;
		hy hy2 = this.m_wl;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_wl = A_0;
		hy2 = this.m_wl;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel ahj()
	{
		return this.m_wm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(Panel A_0)
	{
		this.m_wm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ahk()
	{
		return this.m_wn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j1(Label A_0)
	{
		this.m_wn = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ahl()
	{
		return this.m_wo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void fu(hy A_0)
	{
		EventHandler value = bf;
		hy hy2 = this.m_wo;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_wo = A_0;
		hy2 = this.m_wo;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ahm()
	{
		return this.m_wp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j2(Label A_0)
	{
		this.m_wp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip ahn()
	{
		return this.m_wq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(ToolTip A_0)
	{
		this.m_wq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox aho()
	{
		return this.m_wr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cc(GroupBox A_0)
	{
		this.m_wr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ahp()
	{
		return this.m_ws;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cr(CheckBox A_0)
	{
		EventHandler value = c5;
		CheckBox checkBox = this.m_ws;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_ws = A_0;
		checkBox = this.m_ws;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ahq()
	{
		return wt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cd(GroupBox A_0)
	{
		wt = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox ahr()
	{
		return this.m_wu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void cs(CheckBox A_0)
	{
		this.m_wu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ahs()
	{
		return this.m_wv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void fv(hy A_0)
	{
		this.m_wv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy aht()
	{
		return ww;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void fw(hy A_0)
	{
		ww = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ahu()
	{
		return wx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void j3(Label A_0)
	{
		wx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ahv()
	{
		return wy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void j4(Label A_0)
	{
		wy = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ahw()
	{
		return wz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void j5(Label A_0)
	{
		wz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ahx()
	{
		return this.m_w0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void j6(Label A_0)
	{
		this.m_w0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ahy()
	{
		return this.m_w1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c7(RadioButton A_0)
	{
		this.m_w1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ahz()
	{
		return this.m_w2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c8(RadioButton A_0)
	{
		this.m_w2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ah0()
	{
		return this.m_w3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void fz(hy A_0)
	{
		EventHandler value = d6;
		hy hy2 = this.m_w3;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_w3 = A_0;
		hy2 = this.m_w3;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ah1()
	{
		return this.m_w4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j7(Label A_0)
	{
		this.m_w4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ah2()
	{
		return this.m_w5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c9(RadioButton A_0)
	{
		EventHandler value = c2;
		RadioButton radioButton = this.m_w5;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_w5 = A_0;
		radioButton = this.m_w5;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ah3()
	{
		return this.m_w6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void da(RadioButton A_0)
	{
		EventHandler value = c2;
		RadioButton radioButton = this.m_w6;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_w6 = A_0;
		radioButton = this.m_w6;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ah4()
	{
		return this.m_w7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void db(RadioButton A_0)
	{
		EventHandler value = c2;
		RadioButton radioButton = this.m_w7;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_w7 = A_0;
		radioButton = this.m_w7;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ah5()
	{
		return this.m_w8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void dc(RadioButton A_0)
	{
		EventHandler value = c2;
		RadioButton radioButton = this.m_w8;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_w8 = A_0;
		radioButton = this.m_w8;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ah6()
	{
		return this.m_w9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void dd(RadioButton A_0)
	{
		EventHandler value = c2;
		RadioButton radioButton = this.m_w9;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_w9 = A_0;
		radioButton = this.m_w9;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ah7()
	{
		return this.m_xa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void de(RadioButton A_0)
	{
		EventHandler value = c2;
		RadioButton radioButton = this.m_xa;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_xa = A_0;
		radioButton = this.m_xa;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ah8()
	{
		return this.m_xb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void df(RadioButton A_0)
	{
		EventHandler value = c2;
		RadioButton radioButton = this.m_xb;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_xb = A_0;
		radioButton = this.m_xb;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ah9()
	{
		return this.m_xc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void dg(RadioButton A_0)
	{
		EventHandler value = c2;
		RadioButton radioButton = this.m_xc;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_xc = A_0;
		radioButton = this.m_xc;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton aia()
	{
		return this.m_xd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void dh(RadioButton A_0)
	{
		EventHandler value = c2;
		RadioButton radioButton = this.m_xd;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_xd = A_0;
		radioButton = this.m_xd;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton aib()
	{
		return this.m_xe;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void di(RadioButton A_0)
	{
		EventHandler value = c2;
		RadioButton radioButton = this.m_xe;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_xe = A_0;
		radioButton = this.m_xe;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton aic()
	{
		return this.m_xf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void dj(RadioButton A_0)
	{
		EventHandler value = c2;
		RadioButton radioButton = this.m_xf;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_xf = A_0;
		radioButton = this.m_xf;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton aid()
	{
		return xg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void dk(RadioButton A_0)
	{
		EventHandler value = c2;
		RadioButton radioButton = xg;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		xg = A_0;
		radioButton = xg;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aie()
	{
		return xh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void j8(Label A_0)
	{
		xh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aif()
	{
		return this.m_xi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void j9(Label A_0)
	{
		this.m_xi = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton aig()
	{
		return this.m_xj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void dl(RadioButton A_0)
	{
		EventHandler value = cz;
		RadioButton radioButton = this.m_xj;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_xj = A_0;
		radioButton = this.m_xj;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton aih()
	{
		return this.m_xk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void dp(RadioButton A_0)
	{
		EventHandler value = cz;
		RadioButton radioButton = this.m_xk;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_xk = A_0;
		radioButton = this.m_xk;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton aii()
	{
		return this.m_xl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d2(RadioButton A_0)
	{
		EventHandler value = cz;
		RadioButton radioButton = this.m_xl;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_xl = A_0;
		radioButton = this.m_xl;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton aij()
	{
		return this.m_xm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d6(RadioButton A_0)
	{
		EventHandler value = cz;
		RadioButton radioButton = this.m_xm;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_xm = A_0;
		radioButton = this.m_xm;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton aik()
	{
		return this.m_xn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ef(RadioButton A_0)
	{
		EventHandler value = cz;
		RadioButton radioButton = this.m_xn;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_xn = A_0;
		radioButton = this.m_xn;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ail()
	{
		return this.m_xo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void eh(RadioButton A_0)
	{
		EventHandler value = cz;
		RadioButton radioButton = this.m_xo;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_xo = A_0;
		radioButton = this.m_xo;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button aim()
	{
		return this.m_xp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b1(Button A_0)
	{
		this.m_xp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.aa ain()
	{
		return this.m_aaw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.aa A_0)
	{
		r.d.b a_ = a;
		this.m_aaw?.e(a_);
		this.m_aaw = A_0;
		this.m_aaw?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer aio()
	{
		return this.m_abg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = a;
		System.Timers.Timer timer = this.m_abg;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		this.m_abg = A_0;
		timer = this.m_abg;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	public e8()
	{
		base.Load += k;
		this.m_xs = new Collection<Collection<Control>>();
		this.m_xt = new Collection<Control>();
		this.m_xu = new Collection<Label>();
		this.m_xv = new Collection<Label>();
		this.m_xw = new Collection<hy>();
		this.m_xx = new Collection<hy>();
		this.m_x1 = string.Empty;
		this.m_x8 = new Collection<hy>();
		this.m_x9 = new Collection<hy>();
		this.m_ya = new Collection<Button>();
		this.m_yb = new Collection<hy>();
		this.m_yc = new Collection<Label>();
		this.m_yd = new Collection<Button>();
		this.m_yf = new Collection<Collection<Control>>();
		this.m_yg = new Collection<Control>();
		this.m_yh = new Collection<Collection<Control>>();
		this.m_yi = new Collection<Label>();
		this.m_yk = new Collection<Collection<Control>>();
		this.m_yl = new Collection<Control>();
		this.m_yn = new Collection<Collection<Control>>();
		this.m_yo = new Collection<Control>();
		this.m_yp = new Collection<TextBox>();
		this.m_yq = new Collection<hy>();
		this.m_yr = new Collection<TableLayoutPanel>();
		this.m_ys = new Collection<Button>();
		this.m_yt = new Collection<hy>();
		this.m_yu = new Collection<CheckBox>();
		this.m_yv = new Collection<CheckBox>();
		this.m_yw = new Collection<CheckBox>();
		this.m_yx = new Collection<CheckBox>();
		this.m_yy = new Collection<hy>();
		this.m_yz = new Collection<Label>();
		this.m_y0 = new Collection<hy>();
		this.m_y1 = new Collection<ComboBox>();
		this.m_y2 = new Collection<Control>();
		this.m_zj = new r.d();
		this.m_zl = new Collection<Button>();
		this.m_zm = new Collection<Button>();
		this.m_zn = new Collection<Button>();
		this.m_zo = new Collection<Button>();
		this.m_zp = new Collection<CheckBox>();
		this.m_zq = new Collection<CheckBox>();
		this.m_zr = new Collection<CheckBox>();
		this.m_zs = new Collection<CheckBox>();
		this.m_zt = new Collection<GroupBox>();
		this.m_zu = new Collection<GroupBox>();
		this.m_zw = new Collection<hy>();
		this.m_zx = new Collection<hy>();
		this.m_zy = new Collection<hy>();
		this.m_zz = new Collection<hy>();
		this.m_z0 = new Collection<Panel>();
		this.m_z1 = new Collection<RadioButton>();
		this.m_z2 = new Collection<RadioButton>();
		this.m_z3 = new Collection<RadioButton>();
		this.m_z4 = new Collection<RadioButton>();
		this.m_z5 = new Collection<RadioButton>();
		this.m_z6 = new Collection<RadioButton>();
		this.m_z7 = new Collection<RadioButton>();
		this.m_z8 = new Collection<RadioButton>();
		this.m_aaa = new Collection<hy>();
		this.m_aab = new Collection<hy>();
		this.m_aac = new Collection<hy>();
		this.m_aad = new Collection<hy>();
		this.m_aag = string.Empty;
		a(new r.aa());
		this.m_aay = null;
		this.m_aaz = string.Empty;
		a(new System.Timers.Timer());
		try
		{
			bp();
			b3();
		}
		finally
		{
			bq();
		}
	}

	public e8(fz A_0)
		: this()
	{
		this.m_aaj = acc().Width;
		this.m_y5 = A_0;
		cm().Items.Clear();
		cm().Items.Add(global::h4.e(new h4(global::h4.a.a), A_1: true));
		cm().Items.Add(global::h4.e(new h4(global::h4.a.b), A_1: true));
		cm().Items.Add(global::h4.e(new h4(global::h4.a.c), A_1: true));
		cm().Items.Add(global::h4.e(new h4(global::h4.a.d), A_1: true));
		cm().Items.Add(global::h4.e(new h4(global::h4.a.e), A_1: true));
		cm().Items.Add(global::h4.e(new h4(global::h4.a.f), A_1: true));
		cm().Items.Add(global::h4.e(new h4(global::h4.a.g), A_1: true));
		cm().Items.Add(global::h4.e(new h4(global::h4.a.h), A_1: true));
		cm().Items.Add(global::h4.e(new h4(global::h4.a.i), A_1: true));
		global::h4.e(cm());
		ComboBox.ObjectCollection items = kv().Items;
		items.Clear();
		items.Add("None");
		items.Add("Grid");
		items.Add("FFT");
		_ = null;
		this.m_y2.Add(j6());
		this.m_y2.Add(j5());
		this.m_y2.Add(j2());
		this.m_y2.Add(j1());
		this.m_y2.Add(zl());
		this.m_y2.Add(j8());
		this.m_y2.Add(j7());
		this.m_y2.Add(kb());
		this.m_y2.Add(kd());
		this.m_y2.Add(kc());
		this.m_y2.Add(kh());
		this.m_y2.Add(kr());
		this.m_y2.Add(kq());
		this.m_y2.Add(kp());
		this.m_y2.Add(km());
		this.m_y2.Add(kv());
		this.m_y2.Add(kx());
		this.m_y2.Add(kw());
		string A_1 = "NumberLayerStacksRepeatToolTip";
		string caption = global::hu.a(ref A_1);
		aee().SetToolTip(zk(), caption);
		aee().SetToolTip(zj(), caption);
		b(this.m_y2);
		this.m_yd.Add(it());
		global::t.a(it(), Resources.Insert, Resources.InsertDisabled, Resources.InsertDarkGreen, this.m_y5, "DialogEditRecipe");
		this.m_yd.Add(kj());
		global::t.a(kj(), Resources.Insert, Resources.InsertDisabled, Resources.InsertDarkGreen, this.m_y5, "DialogEditRecipe");
		this.m_yg.Add(ka());
		this.m_yg.Add(j9());
		this.m_yg.Add(kf());
		this.m_yg.Add(ke());
		this.m_yg.Add(ki());
		this.m_ye = new bx(kk(), A_1: true);
		this.m_yo.Add(ko());
		this.m_yo.Add(kn());
		this.m_yo.Add(ku());
		this.m_ym = new bx(k3(), A_1: true);
		this.m_yl.Add(kz());
		this.m_yj = new bx(k4(), A_1: true);
		this.m_xt.Add(ep());
		this.m_xt.Add(eh());
		this.m_xt.Add(ef());
		this.m_xt.Add(d6());
		a(this.m_xt);
		this.m_zl.Add(aas());
		this.m_zl.Add(ab7());
		this.m_zl.Add(ab8());
		this.m_zl.Add(ab9());
		this.m_zl.Add(aca());
		this.m_zl.Add(aac());
		this.m_zl.Add(adc());
		this.m_zl.Add(ac1());
		this.m_zl.Add(acq());
		this.m_zl.Add(acf());
		this.m_zl.Add(ady());
		this.m_zl.Add(adn());
		this.m_zn.Add(aao());
		this.m_zn.Add(aa0());
		this.m_zn.Add(aba());
		this.m_zn.Add(abk());
		this.m_zn.Add(abu());
		this.m_zn.Add(ab4());
		this.m_zn.Add(adk());
		this.m_zn.Add(ac9());
		this.m_zn.Add(acy());
		this.m_zn.Add(acn());
		this.m_zn.Add(ad6());
		this.m_zn.Add(adv());
		this.m_zq.Add(aal());
		this.m_zq.Add(aaw());
		this.m_zq.Add(aa6());
		this.m_zq.Add(abg());
		this.m_zq.Add(abq());
		this.m_zq.Add(ab0());
		this.m_zq.Add(adg());
		this.m_zq.Add(ac5());
		this.m_zq.Add(acu());
		this.m_zq.Add(acj());
		this.m_zq.Add(ad2());
		this.m_zq.Add(adr());
		this.m_zt.Add(aai());
		this.m_zt.Add(aat());
		this.m_zt.Add(aa3());
		this.m_zt.Add(abd());
		this.m_zt.Add(abn());
		this.m_zt.Add(abx());
		this.m_zt.Add(add());
		this.m_zt.Add(ac2());
		this.m_zt.Add(acr());
		this.m_zt.Add(acg());
		this.m_zt.Add(adz());
		this.m_zt.Add(ado());
		this.m_zw.Add(aam());
		this.m_zw.Add(aax());
		this.m_zw.Add(aa7());
		this.m_zw.Add(abh());
		this.m_zw.Add(abr());
		this.m_zw.Add(ab1());
		this.m_zw.Add(adh());
		this.m_zw.Add(ac6());
		this.m_zw.Add(acv());
		this.m_zw.Add(ack());
		this.m_zw.Add(ad3());
		this.m_zw.Add(ads());
		this.m_zy.Add(aap());
		this.m_zy.Add(aaz());
		this.m_zy.Add(aa9());
		this.m_zy.Add(abj());
		this.m_zy.Add(abt());
		this.m_zy.Add(ab3());
		this.m_zy.Add(adj());
		this.m_zy.Add(ac8());
		this.m_zy.Add(acx());
		this.m_zy.Add(acm());
		this.m_zy.Add(ad5());
		this.m_zy.Add(adu());
		this.m_z1.Add(aak());
		this.m_z1.Add(aav());
		this.m_z1.Add(aa5());
		this.m_z1.Add(abf());
		this.m_z1.Add(abp());
		this.m_z1.Add(abz());
		this.m_z1.Add(adf());
		this.m_z1.Add(ac4());
		this.m_z1.Add(act());
		this.m_z1.Add(aci());
		this.m_z1.Add(ad1());
		this.m_z1.Add(adq());
		this.m_z2.Add(aaj());
		this.m_z2.Add(aau());
		this.m_z2.Add(aa4());
		this.m_z2.Add(abe());
		this.m_z2.Add(abo());
		this.m_z2.Add(aby());
		this.m_z2.Add(ade());
		this.m_z2.Add(ac3());
		this.m_z2.Add(acs());
		this.m_z2.Add(ach());
		this.m_z2.Add(ad0());
		this.m_z2.Add(adp());
		this.m_z3.Add(ah9());
		this.m_z3.Add(ah2());
		this.m_z3.Add(aia());
		this.m_z3.Add(aib());
		this.m_z3.Add(aic());
		this.m_z3.Add(aid());
		this.m_z3.Add(ah8());
		this.m_z3.Add(ah7());
		this.m_z3.Add(ah6());
		this.m_z3.Add(ah5());
		this.m_z3.Add(ah4());
		this.m_z3.Add(ah3());
		this.m_aac.Add(aaq());
		this.m_aac.Add(aa1());
		this.m_aac.Add(abb());
		this.m_aac.Add(abl());
		this.m_aac.Add(abv());
		this.m_aac.Add(ab5());
		this.m_aac.Add(adl());
		this.m_aac.Add(ada());
		this.m_aac.Add(acz());
		this.m_aac.Add(aco());
		this.m_aac.Add(ad7());
		this.m_aac.Add(adw());
		this.m_aaa.Add(aan());
		this.m_aaa.Add(aay());
		this.m_aaa.Add(aa8());
		this.m_aaa.Add(abi());
		this.m_aaa.Add(abs());
		this.m_aaa.Add(ab2());
		this.m_aaa.Add(adi());
		this.m_aaa.Add(ac7());
		this.m_aaa.Add(acw());
		this.m_aaa.Add(acl());
		this.m_aaa.Add(ad4());
		this.m_aaa.Add(adt());
		this.m_zm.Add(mi());
		this.m_zm.Add(ov());
		this.m_zm.Add(ow());
		this.m_zm.Add(ox());
		this.m_zm.Add(oy());
		this.m_zm.Add(l0());
		this.m_zo.Add(mf());
		this.m_zo.Add(mu());
		this.m_zo.Add(m8());
		this.m_zo.Add(np());
		this.m_zo.Add(n8());
		this.m_zo.Add(os());
		this.m_zp.Add(l8());
		this.m_zp.Add(mp());
		this.m_zp.Add(m3());
		this.m_zp.Add(nh());
		this.m_zp.Add(nz());
		this.m_zp.Add(on());
		this.m_zr.Add(md());
		this.m_zr.Add(ms());
		this.m_zr.Add(m6());
		this.m_zr.Add(nn());
		this.m_zr.Add(n3());
		this.m_zr.Add(oq());
		this.m_zs.Add(yt());
		this.m_zs.Add(yu());
		this.m_zs.Add(yv());
		this.m_zs.Add(yw());
		this.m_zs.Add(yx());
		this.m_zs.Add(yy());
		this.m_zu.Add(l4());
		this.m_zu.Add(mj());
		this.m_zu.Add(mx());
		this.m_zu.Add(nb());
		this.m_zu.Add(ns());
		this.m_zu.Add(oe());
		this.m_zx.Add(mb());
		this.m_zx.Add(mq());
		this.m_zx.Add(m4());
		this.m_zx.Add(nl());
		this.m_zx.Add(n0());
		this.m_zx.Add(oo());
		this.m_zz.Add(mc());
		this.m_zz.Add(mr());
		this.m_zz.Add(m5());
		this.m_zz.Add(nm());
		this.m_zz.Add(n1());
		this.m_zz.Add(op());
		this.m_z0.Add(l5());
		this.m_z0.Add(mk());
		this.m_z0.Add(my());
		this.m_z0.Add(nc());
		this.m_z0.Add(nt());
		this.m_z0.Add(oh());
		this.m_z4.Add(l7());
		this.m_z4.Add(mm());
		this.m_z4.Add(m0());
		this.m_z4.Add(ne());
		this.m_z4.Add(nw());
		this.m_z4.Add(ok());
		this.m_z5.Add(l6());
		this.m_z5.Add(ml());
		this.m_z5.Add(mz());
		this.m_z5.Add(nd());
		this.m_z5.Add(nv());
		this.m_z5.Add(oj());
		this.m_z6.Add(aig());
		this.m_z6.Add(aih());
		this.m_z6.Add(aii());
		this.m_z6.Add(aik());
		this.m_z6.Add(ail());
		this.m_z6.Add(aij());
		this.m_z7.Add(ma());
		this.m_z7.Add(mo());
		this.m_z7.Add(m2());
		this.m_z7.Add(ng());
		this.m_z7.Add(ny());
		this.m_z7.Add(om());
		this.m_z8.Add(l9());
		this.m_z8.Add(mn());
		this.m_z8.Add(m1());
		this.m_z8.Add(nf());
		this.m_z8.Add(nx());
		this.m_z8.Add(ol());
		this.m_aab.Add(me());
		this.m_aab.Add(mt());
		this.m_aab.Add(m7());
		this.m_aab.Add(no());
		this.m_aab.Add(n4());
		this.m_aab.Add(or());
		this.m_aad.Add(mg());
		this.m_aad.Add(mv());
		this.m_aad.Add(m9());
		this.m_aad.Add(nq());
		this.m_aad.Add(oc());
		this.m_aad.Add(ot());
		string toolTip = aei().GetToolTip(yt());
		aei().SetToolTip(yu(), toolTip);
		aei().SetToolTip(yv(), toolTip);
		aei().SetToolTip(yw(), toolTip);
		aei().SetToolTip(yx(), toolTip);
		aei().SetToolTip(yy(), toolTip);
	}

	public void a(hg A_0, bool A_1, gr A_2, string A_3, f1 A_4, gq A_5, object A_6, Guid A_7, ge A_8, ref d A_9, bool A_10, a A_11, bool A_12, e A_13, f A_14)
	{
		this.m_x6 = A_4;
		this.m_x7 = A_5;
		this.m_xq = RuntimeHelpers.GetObjectValue(A_6);
		this.m_xr = A_7;
		this.m_y3 = A_8;
		this.m_aah = A_11;
		this.m_aai = A_13;
		this.m_xz = A_1;
		this.m_aax = A_14;
		eo eo2 = A_0.dh();
		this.m_aam = eo2.ax(by());
		this.m_aan = eo2.az(by());
		this.m_aao = eo2.at(by(), global::e8.a.a(this.m_aah, A_0.d0()));
		this.m_aat = global::eo.at(this.m_x6.sm(this.m_xr), this.m_x6.sn(this.m_xr), by());
		this.m_aaq = eo2.a5(by());
		eo2 = null;
		this.m_aak = A_12;
		this.m_aal = A_9;
		if (global::e8.a.a(this.m_aah, A_0.d0()))
		{
			ref d reference = ref this.m_aal;
			reference.c = true;
			reference.a = true;
		}
		if (!Directory.Exists(global::i3.i()))
		{
			Directory.CreateDirectory(global::i3.i());
		}
		this.m_y7 = A_2;
		this.m_aae = this.m_x6.m2(this.m_xr, A_12, A_0.b8());
		this.m_zc = this.m_x6.tc(this.m_xr);
		this.m_x0 = this.m_x6.xh(this.m_xr);
		if (this.m_y7 != null)
		{
			bool flag = default(bool);
			if (this.m_abf == null)
			{
				this.m_abf = new iw(this.m_y7, h, e, d, f, g, a, this.m_a);
				flag = true;
			}
			else if (this.m_y7.sm())
			{
				h();
				flag = true;
			}
			if (flag)
			{
				gr obj = this.m_y7;
				ref Collection<string> a_ = ref this.m_abf.ag;
				string A_15 = "\\MostRecentLayerMaterials.fmslf";
				obj.m2(ref a_, global::gr.f.a, ref A_15);
				gr obj2 = this.m_y7;
				ref Collection<string> a_2 = ref this.m_abf.ah;
				A_15 = "\\MostRecentMediumMaterials.fmslf";
				obj2.m2(ref a_2, global::gr.f.a, ref A_15);
				gr obj3 = this.m_y7;
				ref Collection<string> a_3 = ref this.m_abf.ai;
				A_15 = "\\MostRecentSubstrateMaterials.fmslf";
				obj3.m2(ref a_3, global::gr.f.a, ref A_15);
			}
			this.m_abf.q(h, e, d, f, g, a, this.m_a);
		}
		A_0.ej();
		this.m_zd = A_0;
		this.m_x2 = b(this.m_zd);
		this.m_x3 = this.m_x2.ed().d5(this.m_x2.dh().aw(by()), by());
		this.m_x2.bu(ref this.m_x4);
		this.m_xy = A_3;
		this.m_x5 = DateTime.FromOADate(this.m_x2.cn());
		if (Operators.CompareString(this.m_x2.ci(), "DefaultRecipe", TextCompare: false) == 0)
		{
			if (A_1)
			{
				this.m_zi = ".fitra";
			}
			else
			{
				this.m_zi = Path.GetExtension(this.m_x2.c1());
			}
		}
		else
		{
			this.m_zi = Path.GetExtension(this.m_x2.c1());
		}
		if (this.m_aan)
		{
			if (!this.m_yl.Contains(ky()))
			{
				this.m_yl.Add(ky());
			}
		}
		else if (this.m_yl.Contains(ky()))
		{
			this.m_yl.Remove(ky());
		}
		if (!A_10 || this.m_x2.d0() != null)
		{
			if (this.m_x2.d0().c() != global::g2.a.c && this.m_x2.d0().c() != global::g2.a.b && !this.m_aah.b() && !this.m_z9)
			{
				c(A_0: false);
				this.m_z9 = true;
			}
			else if ((this.m_x2.d0().c() == global::g2.a.c || this.m_x2.d0().c() == global::g2.a.b || this.m_aah.b()) && this.m_z9)
			{
				c(A_0: true);
				this.m_z9 = false;
			}
			if ((this.m_x2.d0().c() == global::g2.a.c || this.m_x2.d0().c() == global::g2.a.b || this.m_aah.b()) && !this.m_zv)
			{
				b(A_0: false);
				this.m_zv = true;
			}
			else if (this.m_x2.d0().c() != global::g2.a.c && this.m_x2.d0().c() != global::g2.a.b && !this.m_aah.b() && this.m_zv)
			{
				b(A_0: true);
				this.m_zv = false;
			}
		}
		this.m_ze = this.m_x6.u8();
		this.m_zk = this.m_x6.tf(this.m_xr, !(this.m_xq is f4));
		this.m_zf = this.m_x6.un(this.m_xr);
		this.m_aa0 = this.m_x6.uo(this.m_xr);
		this.m_aa1 = this.m_x6.vb(this.m_xr);
		this.m_zg = this.m_zf != null && this.m_zf[0] >= 1;
		this.m_y8 = this.m_x6.ue();
		this.m_y9 = this.m_x6.tg(this.m_xr);
		this.m_za = this.m_x6.te(this.m_xr);
		this.m_zb = this.m_x6.td(this.m_xr);
		ip().Visible = A_0.dh().a1();
		this.m_abc = A_10;
		string text = null;
		if (this.m_x6.vm(this.m_xr))
		{
			this.m_aay = this.m_x6.va(this.m_xr);
			hv().TabPages.Clear();
			this.m_x2.b8().t();
			if (this.m_aay[0])
			{
				hv().TabPages.Add(hy());
			}
			else
			{
				vi().Visible = false;
			}
			if (this.m_aay[1])
			{
				hv().TabPages.Add(ig());
			}
			else
			{
				vh().Visible = false;
			}
			if (this.m_aay[2])
			{
				int num = this.m_x6.m2(this.m_xr, global::h.f.c);
				text = this.m_x6.vc(this.m_xr)[num].ToString("0");
				string A_15 = "ReflectanceAbbrevTitle";
				string obj4 = global::hu.a(ref A_15);
				A_15 = "MultiMeasAtAngleFmt";
				this.m_aaz = obj4 + string.Format(global::hu.a(ref A_15), text);
				ua().Text = this.m_aaz;
				hv().TabPages.Add(ua());
				CheckBox checkBox = vg();
				A_15 = "ReflectanceAtAngleFmt";
				checkBox.Text = string.Format(global::hu.a(ref A_15), text);
			}
			else
			{
				vg().Visible = false;
			}
		}
		hr hr2 = null;
		if (this.m_xq != null && this.m_xq is f4)
		{
			hr2 = ((f4)this.m_xq).h1();
		}
		if (hr2 != null && hr2.bm() != null && hr2.bm().Count > 0)
		{
			CheckBox checkBox2 = ve();
			string A_15 = "ReflectanceAtAngleFmt";
			checkBox2.Text = string.Format(global::hu.a(ref A_15), hr2.bm()[0].cu().m().ToString("0"));
		}
		else if (text != null)
		{
			CheckBox checkBox3 = ve();
			string A_15 = "ReflectanceAtAngleFmt";
			checkBox3.Text = string.Format(global::hu.a(ref A_15), text);
		}
		af6().Visible = this.m_x2.dh().a4(by());
		g(A_0: true);
		if (ch().TabPages.Contains(ci()))
		{
			a(kk(), this.m_ye.f(this.m_aal.a), this.m_yf, this.m_yg);
			a(k3(), this.m_ym.f(this.m_aal.b), this.m_yn, this.m_yo);
			a(this.m_yj.f(this.m_aal.c));
		}
		if (this.m_y4)
		{
			br();
		}
		switch (A_13)
		{
		case global::e8.e.b:
			ch().SelectedIndex = 0;
			break;
		}
		ShowDialog();
		if (this.m_y7 != null)
		{
			h();
		}
		if (base.DialogResult == DialogResult.OK)
		{
			A_9.a = this.m_ye.i() == global::bx.a.b;
			A_9.c = this.m_yj.i() == global::bx.a.b;
			A_9.b = this.m_ym.i() == global::bx.a.b;
		}
	}

	private void hh(object A_0, EventArgs A_1)
	{
		try
		{
			hi obj = this.m_x2.ed();
			obj.ev(this.m_ya.IndexOf((Button)A_0));
			if (obj.d5(this.m_x2.dh().aw(by()), by()))
			{
				a(A_0: true);
			}
			else
			{
				f(A_0: false);
				a3();
			}
			bd();
			_ = null;
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ButtonDeleteLayer_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void hg(object A_0, EventArgs A_1)
	{
		try
		{
			Button button = (Button)A_0;
			int num = this.m_ys.IndexOf(button);
			gc.a a10 = this.m_x2.ed().e1(num);
			if (this.m_ys.Contains(button))
			{
				num = this.m_ys.IndexOf(button);
				a10 = this.m_x2.ed().e1(num);
				this.m_y6 = this.m_yp[num].Text;
			}
			else
			{
				a10 = global::gc.a.c;
				if (button == yg())
				{
					num = -1;
					this.m_y6 = yh().Text;
				}
				else if (button == yr())
				{
					num = -2;
					this.m_y6 = yq().Text;
				}
			}
			string[] a_ = null;
			if (num > 0)
			{
				a_ = this.m_y3.a(num == checked(this.m_x2.ed().g6() + 1), this.m_x2.dh().a8());
			}
			iw.e a_2;
			iw.d a_3;
			if (a10 == global::gc.a.a || num < 0)
			{
				a_2 = ((num >= 0) ? global::iw.e.b : global::iw.e.a);
				a_3 = global::iw.d.b;
			}
			else
			{
				a_2 = global::iw.e.a;
				a_3 = global::iw.d.a;
			}
			this.m_abf.q(button, new Point(0, 0), a_3, a_2, a10, a_);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_4 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ButtonGetMaterial_Click; sender =", a_4);
			ProjectData.ClearProjectError();
		}
	}

	private void hf(object A_0, EventArgs A_1)
	{
		try
		{
			gc gc2 = new gc();
			gc2.af("Air");
			hi obj = this.m_x2.ed();
			obj.au(gc2, this.m_yd.IndexOf((Button)A_0));
			if (obj.d5(this.m_x2.dh().aw(by()), by()))
			{
				a(A_0: true);
			}
			else
			{
				f(A_0: false);
				a3();
			}
			bd();
			_ = null;
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ButtonInsertLayer_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void he(object A_0, EventArgs A_1)
	{
		bf obj = new bf();
		h4 h10 = this.m_x2.ca();
		h4 a_ = new h4(h10.e(), h10.f(), h10.g(), h10.h());
		h10 = null;
		fz a_2 = this.m_y5;
		f1 a_3 = this.m_x6;
		Point a_4 = global::i6.a(zh());
		hg hg2;
		h4 A_2 = (hg2 = this.m_x2).ca();
		obj.a(a_2, a_3, a_4, ref A_2);
		hg2.bu(A_2);
		if (obj.DialogResult == DialogResult.OK && global::h4.f(a_, this.m_x2.ca()))
		{
			bm();
			b2();
		}
	}

	private void hd(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				CheckBox checkBox = (CheckBox)A_0;
				this.m_x2.bu(this.m_yu.IndexOf(checkBox), 0).ao(checkBox.Checked);
				if (this.m_x2.ed().d5(this.m_x2.dh().aw(by()), by()))
				{
					f(A_0: false);
				}
				bd();
				_ = null;
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxSolveForGrading_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void hc(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				CheckBox checkBox = (CheckBox)A_0;
				int a_ = this.m_yv.IndexOf(checkBox);
				bool flag = checkBox.Checked;
				hi obj = this.m_x2.ed();
				gc gc2 = obj.et(a_);
				bool flag2 = gc2.aw() != 0.0 && flag;
				bool flag3 = gc2.ax() != 0.0 && flag;
				if (flag && !flag2 && !flag3)
				{
					flag2 = true;
				}
				if (gc2.ap() != flag2)
				{
					gc2.ai(flag2);
				}
				if (gc2.aq() != flag3)
				{
					gc2.ak(flag3);
				}
				gc2 = null;
				if (obj.d5(this.m_x2.dh().aw(by()), by()))
				{
					f(A_0: false);
				}
				else
				{
					a(checkBox);
					l(a_);
				}
				bd();
				_ = null;
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.CheckBoxSolveForNK_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxSolveForNK_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void g6(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				CheckBox checkBox = (CheckBox)A_0;
				int a_ = this.m_yw.IndexOf(checkBox);
				hi obj = this.m_x2.ed();
				obj.et(a_).ag(checkBox.Checked);
				bd();
				o();
				if (obj.d5(this.m_x2.dh().aw(by()), by()))
				{
					f(A_0: false);
					a3();
				}
				else
				{
					bj();
					j(a_);
					h(a_);
					c(a_);
				}
				_ = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.CheckBoxSolveForThickness_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxSolveForThickness_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void g3(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				CheckBox checkBox = (CheckBox)A_0;
				int a_ = this.m_yx.IndexOf(checkBox);
				this.m_x2.bu(a_, 0).aq(checkBox.Checked);
				if (this.m_x2.ed().d5(this.m_x2.dh().aw(by()), by()))
				{
					f(A_0: false);
				}
				bd();
				c(a_);
				_ = null;
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxSolveForNonuniformity_CheckedChanged", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void g2(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_x2.bw(!this.m_x2.co());
			int num = this.m_x2.b4(0);
			for (int num2 = 1; num2 <= num; num2 = checked(num2 + 1))
			{
				gc gc2 = this.m_x2.ed().et(num2);
				if (gc2.ai() == 0.0)
				{
					if (this.m_x2.co())
					{
						gc2.ak(1000.0);
					}
					else
					{
						gc2.ak(100.0);
					}
				}
				gc2 = null;
			}
			bk();
			l();
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.LabelThicknessRangeUnits_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void g1(object A_0, EventArgs A_1)
	{
		try
		{
			if (f())
			{
				return;
			}
			this.m_x2.bx(!this.m_x2.cp());
			int num = this.m_x2.b4(0);
			for (int num2 = 1; num2 <= num; num2 = checked(num2 + 1))
			{
				gc gc2 = this.m_x2.ed().et(num2);
				if (gc2.ai() == 0.0)
				{
					if (this.m_x2.cp())
					{
						gc2.af(0.01);
					}
					else
					{
						gc2.af(10.0);
					}
				}
				gc2 = null;
			}
			bl();
			l();
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.LabelNonuniformityUnits_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void h(object A_0, LayoutEventArgs A_1)
	{
		try
		{
			a(cn(), ci(), ref this.m_abi);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TabPageFilmstack_Layout", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, ToolStripItemClickedEventArgs A_1)
	{
		try
		{
			int num = this.m_yv.IndexOf((CheckBox)((ContextMenuStrip)A_0).SourceControl);
			this.m_x2.ed().et(num).ag(this.m_ze.j(A_1.ClickedItem.Text));
			a(this.m_yv[num]);
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ContextMenuStripNK_ItemClicked", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, CancelEventArgs A_1)
	{
		try
		{
			gc gc2 = this.m_x2.ed().et(this.m_yv.IndexOf((CheckBox)((ContextMenuStrip)A_0).SourceControl));
			string a_;
			try
			{
				a_ = gc2.af(this.m_ze, this.m_x2.dh(), this.m_aah.h());
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				a_ = null;
				this.m_y5.c(global::fz.b.a, "Invalid model in DialogEditRecipe.ContextMenuStripNK_Opening in recipe " + this.m_x2.c1() + " model is " + gc2.au());
				ProjectData.ClearProjectError();
			}
			this.m_ze.i(k6(), this.m_x2.dh(), this.m_aah.h(), A_3: false, a_);
			gc2 = null;
			A_1.Cancel = false;
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception a_2 = ex4;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.ContextMenuStripNK_Opening", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private bx a(PictureBox A_0)
	{
		bool flag = true;
		if (flag == (A_0 == kk()))
		{
			return this.m_ye;
		}
		if (flag == (A_0 == k4()))
		{
			return this.m_yj;
		}
		if (flag == (A_0 == k3()))
		{
			return this.m_ym;
		}
		return null;
	}

	private void g0(object A_0, EventArgs A_1)
	{
		try
		{
			a((PictureBox)A_0)?.g();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.OutlinePicturebox_MouseEnter", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void gz(object A_0, EventArgs A_1)
	{
		try
		{
			a((PictureBox)A_0)?.h();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.OutlinePicturebox_MouseLeave", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void gy(object A_0, EventArgs A_1)
	{
		try
		{
			a(kk(), global::bx.b.a, this.m_yf, this.m_yg);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.PictureBoxFSOutlineComposition_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void gs(object A_0, EventArgs A_1)
	{
		try
		{
			a(k3(), global::bx.b.a, this.m_yn, this.m_yo);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.PictureBoxFSOutlineThickness_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void gp(object A_0, EventArgs A_1)
	{
		try
		{
			a(global::bx.b.a);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.PictureBoxFSOutlineNonuniformity_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(bx.b A_0)
	{
		a(k4(), A_0, this.m_yk, this.m_yl);
		try
		{
			@is().SuspendLayout();
			if (this.m_yj.i() == global::bx.a.a)
			{
				k0().Text = "Nonuniformity";
			}
			else
			{
				k0().Text = "NU";
			}
		}
		finally
		{
			@is().ResumeLayout();
		}
	}

	private void a(PictureBox A_0, bx.b A_1, Collection<Collection<Control>> A_2, Collection<Control> A_3)
	{
		checked
		{
			try
			{
				@is().SuspendLayout();
				bx obj = a(A_0);
				obj.f(A_1);
				bool visible = obj.i() == global::bx.a.a;
				_ = null;
				int num = this.m_x2.ed().g6() + 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (num2 < A_2.Count)
					{
						a(num2, A_2[num2]);
					}
				}
				if (A_3 != null)
				{
					foreach (Control item in A_3)
					{
						if (item == ku())
						{
							bn();
						}
						else
						{
							item.Visible = visible;
						}
					}
				}
			}
			finally
			{
				@is().ResumeLayout();
			}
			br();
		}
	}

	private void go(object A_0, EventArgs A_1)
	{
		try
		{
			if (this.m_x2.ed().d5(this.m_x2.dh().aw(by()), by()))
			{
				f(A_0: false);
				a3();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.LayerParameterControl_Validated", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void gn(object A_0, EventArgs A_1)
	{
		try
		{
			TextBox textBox = (TextBox)A_0;
			this.m_y6 = textBox.Text;
			int a_ = default(int);
			if (this.m_yp.Contains(textBox))
			{
				if (Operators.CompareString(textBox.Text, "<Graded Interface>", TextCompare: false) == 0 || Operators.CompareString(textBox.Text, "<Roughness>", TextCompare: false) == 0)
				{
					return;
				}
				a_ = this.m_yp.IndexOf(textBox);
				this.m_abf.q(this.m_x2.ed().e1(a_));
			}
			else if (textBox == yh())
			{
				a_ = -1;
				this.m_abf.q(global::gc.a.c);
			}
			else if (textBox == yq())
			{
				a_ = -2;
				this.m_abf.q(global::gc.a.c);
			}
			if (this.m_y6.StartsWith("Generic, n="))
			{
				b(a_, this.m_y6.Substring("Generic, n=".Length));
			}
			else if (global::gd.l(this.m_y6))
			{
				a(textBox);
				if (!this.m_x2.ed().hq())
				{
					i();
				}
			}
			else
			{
				a(a_, this.m_y6);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxMaterial_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void gm(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				int num = this.m_x9.IndexOf(hy2);
				gc gc2 = this.m_x2.bu(num, 0);
				gc2.am(global::iz.e(hy2.Text));
				gc2.ak(this.m_yv[num].Checked && gc2.ax() > 0.0);
				gc2 = null;
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumDeltaK_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void gl(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				int num = this.m_x8.IndexOf(hy2);
				gc gc2 = this.m_x2.bu(num, 0);
				gc2.al(global::iz.e(hy2.Text));
				gc2.ai(this.m_yv[num].Checked && gc2.aw() > 0.0);
				gc2 = null;
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumDeltaN_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, CancelEventArgs A_1)
	{
		try
		{
			hy hy2 = (hy)A_0;
			int a_ = this.m_yq.IndexOf(hy2);
			this.m_x2.bu(a_, 0).af(Conversions.ToShort(hy2.Text));
			_ = null;
			i();
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumStackRepeats_TextChanged", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void gk(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				if (a(hy2))
				{
					this.m_x2.bu(this.m_yb.IndexOf(hy2), 0).ag(global::iz.e(hy2.Text) * 0.01);
					o();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumGrading_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, CancelEventArgs A_1)
	{
		try
		{
			hy a_ = (hy)A_0;
			if (!a(a_))
			{
				global::fe.b(this.m_y5, "Graded layer grading must be <=" + 100.0 + "%", global::i6.a(a_));
				A_1.Cancel = true;
			}
			else
			{
				A_1.Cancel = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxNumGrading_Validating", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void ge(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				double A_2 = default(double);
				a(hy2, ref A_2);
				this.m_x2.bu(this.m_yt.IndexOf(hy2), 0).af(A_2);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumNonuniformity_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void gb(object A_0, EventArgs A_1)
	{
		try
		{
			c(this.m_yt.IndexOf((hy)A_0));
			go(RuntimeHelpers.GetObjectValue(A_0), A_1);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxNumNonuniformity_Validated", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ga(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				int a_ = this.m_yy.IndexOf(hy2);
				hg hg2 = this.m_x2;
				hg2.bu(a_, 0).af(hg2.co(), hg2.cp(), hg2.ca().e(global::iz.e(hy2.Text)));
				hg2 = null;
				h(a_);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumThickness_TextChanged", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void f9(object A_0, EventArgs A_1)
	{
		try
		{
			c(this.m_yy.IndexOf((hy)A_0));
			hg hg2 = this.m_x2;
			if (hg2.ed().d5(hg2.dh().aw(by()), by()))
			{
				a(A_0: true);
			}
			hg2 = null;
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error in DialogEditRecipe.TextBoxNumThickness_Validated", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void f8(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				int a_ = this.m_y0.IndexOf(hy2);
				gc gc2 = this.m_x2.bu(a_, 0);
				double a_2 = ((!this.m_x2.co()) ? global::iz.e(hy2.Text) : ((gc2.ai() != 0.0) ? this.m_x2.ca().e(global::iz.e(hy2.Text) / gc2.ai() * 100.0) : this.m_x2.ca().e(global::iz.e(hy2.Text))));
				gc2.ak(a_2);
				gc2 = null;
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumThicknessRange_TextChanged", a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void f7(object A_0, EventArgs A_1)
	{
		try
		{
			c(this.m_y0.IndexOf((hy)A_0));
			go(RuntimeHelpers.GetObjectValue(A_0), A_1);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxNumThicknessRange_Validated", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void f6(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				ComboBox comboBox = (ComboBox)A_0;
				hi hi2 = this.m_x2.ed();
				if (comboBox.SelectedItem == "Grid")
				{
					hi2.ez(A_0: true);
					hi2.ey(A_0: false);
				}
				else if (comboBox.SelectedItem == "FFT")
				{
					hi2.ez(A_0: false);
					hi2.ey(A_0: true);
				}
				else
				{
					hi2.ez(A_0: false);
					hi2.ey(A_0: false);
				}
				hi2 = null;
				bj();
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ComboBoxThicknessRefine_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void fz(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.b1(Conversions.ToInteger(((ComboBox)A_0).SelectedItem));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ComboBoxSmoothingPoints_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b2()
	{
		f(A_0: true);
		a3();
		o();
	}

	private void fw(object A_0, EventArgs A_1)
	{
		try
		{
			global::h4.f(cm());
			if (bs())
			{
				return;
			}
			string text = cm().Text;
			h4.a a_;
			bool visible = default(bool);
			if (Operators.CompareString(text, global::h4.e(new h4(global::h4.a.a), A_1: true), TextCompare: false) == 0)
			{
				a_ = global::h4.a.a;
			}
			else if (Operators.CompareString(text, global::h4.e(new h4(global::h4.a.b), A_1: true), TextCompare: false) == 0)
			{
				a_ = global::h4.a.b;
			}
			else if (Operators.CompareString(text, global::h4.e(new h4(global::h4.a.c), A_1: true), TextCompare: false) == 0)
			{
				a_ = global::h4.a.c;
			}
			else if (Operators.CompareString(text, global::h4.e(new h4(global::h4.a.d), A_1: true), TextCompare: false) == 0)
			{
				a_ = global::h4.a.d;
			}
			else if (Operators.CompareString(text, global::h4.e(new h4(global::h4.a.e), A_1: true), TextCompare: false) == 0)
			{
				a_ = global::h4.a.e;
			}
			else if (Operators.CompareString(text, global::h4.e(new h4(global::h4.a.f), A_1: true), TextCompare: false) == 0)
			{
				a_ = global::h4.a.f;
			}
			else if (Operators.CompareString(text, global::h4.e(new h4(global::h4.a.g), A_1: true), TextCompare: false) == 0)
			{
				a_ = global::h4.a.g;
			}
			else if (Operators.CompareString(text, global::h4.e(new h4(global::h4.a.h), A_1: true), TextCompare: false) == 0)
			{
				a_ = global::h4.a.h;
			}
			else
			{
				if (Operators.CompareString(text.Substring(0, 8), global::h4.e(new h4(global::h4.a.i), A_1: true).Substring(0, 8), TextCompare: false) != 0)
				{
					throw new ax("Unknown unit code in DialogEditRecipe.cboUnit_SelectedIndexChanged");
				}
				a_ = global::h4.a.i;
				visible = true;
			}
			zh().Visible = visible;
			this.m_x2.ca().e(a_);
			b2();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.cboUnit_SelectedIndexChanged", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void fv(object A_0, EventArgs A_1)
	{
		try
		{
			a(cn(), ci());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.Filmstack_MouseEnter", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void fu(object A_0, EventArgs A_1)
	{
		try
		{
			hg obj = this.m_x2;
			bool a_ = obj.dh().a8();
			hi obj2 = obj.ed();
			_ = null;
			hi hi2 = obj2;
			cm obj3 = global::c.b().eh();
			fz a_2 = this.m_y5;
			f1 a_3 = this.m_x6;
			f4 a_4 = (f4)this.m_xq;
			bool a_5 = this.m_aam;
			bool a_6 = bt();
			bool a_7 = hi2.d7(this.m_aah.h()) && hi2.d8(this.m_aah.h());
			bool a_8 = global::e8.a.a(this.m_aah, this.m_x2.d0());
			hi hi3;
			double A_2 = (hi3 = hi2).gs();
			hi hi4;
			double A_3 = (hi4 = hi2).go();
			hi hi5;
			double A_4 = (hi5 = hi2).f6();
			hi hi6;
			bool A_5 = (hi6 = hi2).fv();
			hi hi7;
			bool A_6 = (hi7 = hi2).fw();
			hi hi8;
			double A_7 = (hi8 = hi2).fx();
			hi hi9;
			double A_8 = (hi9 = hi2).fy();
			hi hi10;
			int A_9 = (hi10 = hi2).gp();
			hg hg2;
			int A_10 = (hg2 = this.m_x2).dy();
			ref bool a_9 = ref hi2.c3;
			ref float a_10 = ref hi2.c6;
			hi hi11;
			hi.d A_11 = (hi11 = hi2).g1();
			hi hi12;
			float A_12 = (hi12 = hi2).g2();
			obj3.a(a_2, a_3, a_4, a_5, a_6, a_7, a_, a_8, ref A_2, ref A_3, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8, ref A_9, ref A_10, ref a_9, ref a_10, ref A_11, ref A_12);
			hi12.ei(A_12);
			hi11.au(A_11);
			hg2.b1(A_10);
			hi10.er(A_9);
			hi9.d9(A_8);
			hi8.d8(A_7);
			hi7.eo(A_6);
			hi6.en(A_5);
			hi5.ea(A_4);
			hi4.ei(A_3);
			hi3.el(A_2);
			hi2 = null;
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_11 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.AdvancedOptionsButton_Click", a_11);
			ProjectData.ClearProjectError();
		}
	}

	private void ft(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				if (dk().Checked)
				{
					dj().Checked = false;
				}
				this.m_x2.ed().ew(dk().Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.CheckBoxAccountForBacksideRefl_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxAccountForBacksideRefl_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void fs(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				if (dj().Checked)
				{
					dk().Checked = false;
				}
				this.m_x2.ed().ex(dj().Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.CheckBoxAccountForNonPlanarity_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxAccountForNonPlanarity_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void fr(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				try
				{
					bp();
					ir().Checked = cw().Checked;
				}
				finally
				{
					bq();
				}
				this.m_x2.ed().e7(cw().Checked);
				g();
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.CheckBoxLockIdenticalComposition_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxLockIdenticalComposition_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void fc(object A_0, EventArgs A_1)
	{
		try
		{
			if (bs())
			{
				return;
			}
			try
			{
				bp();
				cw().Checked = ir().Checked;
				this.m_x2.ed().e7(ir().Checked);
				g();
				o();
			}
			finally
			{
				bq();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.CheckBoxLockIdenticalThickness_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxLockIdenticalThickness_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void fb(object A_0, EventArgs A_1)
	{
		try
		{
			bo();
			if (!bs())
			{
				this.m_x2.ed().e1(lg().Checked);
				bi();
				bf();
				bj();
				a(this.m_x2.ed());
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.RadioButtonOptionsExactRobust_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonOptionsExactRobust_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void fa(object A_0, EventArgs A_1)
	{
		try
		{
			bo();
			if (!bs())
			{
				this.m_x2.ed().e2(lh().Checked);
				bg();
				bf();
				bj();
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.RadioButtonOptionsFFTSpectrumMatching_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonOptionsFFTSpectrumMatching_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void e9(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				if (vj().Checked)
				{
					vd().Checked = true;
					vf().Checked = true;
					ve().Checked = true;
				}
				else
				{
					vd().Checked = false;
					vf().Checked = false;
					ve().Checked = false;
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.CheckBoxAnalyzeAll_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxAnalyzeAll_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void b1()
	{
		try
		{
			bp();
			vj().Checked = vd().Checked && vf().Checked && ve().Checked;
		}
		finally
		{
			bq();
		}
	}

	private void e8(object A_0, EventArgs A_1)
	{
		try
		{
			if (bt() && vd().Checked)
			{
				vf().Checked = false;
				ve().Checked = false;
			}
			b1();
			if (!bs())
			{
				this.m_x2.ed().d9(0, vd().Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.CheckBoxReflectance_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxReflectance_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void e7(object A_0, EventArgs A_1)
	{
		try
		{
			if (bt() && vf().Checked)
			{
				vd().Checked = false;
				ve().Checked = false;
			}
			b1();
			if (!bs())
			{
				this.m_x2.ed().d8(0, vf().Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.CheckBoxTransmittance_CheckChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxTransmittance_CheckChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void e6(object A_0, EventArgs A_1)
	{
		try
		{
			b1();
			if (!bs())
			{
				this.m_x2.ed().d9(1, ve().Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.CheckBoxRAtAngle_CheckChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxRAtAngle_CheckChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void e5(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().el(da().Checked);
				bh();
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.RadioButtonOptionsFixedRange_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonOptionsFixedRange_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void e4(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().em(db().Checked);
				bh();
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.RadioButtonOptionsDisplayedData_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonOptionsDisplayedData_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void e3(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().d7(global::iz.e(de().Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.StartWavelenBox_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.StartWavelenBox_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void e2(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().d6(global::iz.e(dd().Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.EndWavelenBox_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.EndWavelenBox_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void e1(object A_0, EventArgs A_1)
	{
		try
		{
			a(li(), cj());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TabPageAnalysisOptions_MouseEnter", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void g(object A_0, LayoutEventArgs A_1)
	{
		try
		{
			a(li(), cj(), ref this.m_abj);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TabPageAnalysisOptions_Layout", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void e0(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.by((float)new h4(global::h4.a.c).e(global::iz.e(cs().Text)));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxSmoothingThickness_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxSmoothingThickness_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void ez(object A_0, EventArgs A_1)
	{
		try
		{
			a(lk(), dl());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.Alarms_MouseEnter", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ey(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().e3(eu().Checked);
				a3();
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxActivateAlarms_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ex(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().au(vv().Checked);
				if (vv().Checked && this.m_x2.ed().d7() != (a4.a)global::e.a().ShowSpectrumCoordOption)
				{
					this.m_x2.ed().hl();
					this.m_x2.ed().au(A_0: true);
					this.m_x2.ed().au((a4.a)global::e.a().ShowSpectrumCoordOption);
				}
				a3();
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxActivateAlarms_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void f(object A_0, LayoutEventArgs A_1)
	{
		try
		{
			a(lk(), dl(), ref this.m_abk);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TabPageAlarms_Layout", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ew(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				this.m_x2.bu(this.m_xx.IndexOf(hy2), 0).ai(this.m_x2.ca().e(global::iz.e(hy2.Text)));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumAlarmsMax_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ev(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				this.m_x2.bu(this.m_xw.IndexOf(hy2), 0).ah(this.m_x2.ca().e(global::iz.e(hy2.Text)));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumAlarmsMin_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void eu(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().d9(global::iz.d(vy().Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.txtNumColorCoord1Min_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void et(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().ea(global::iz.d(vz().Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.txtNumColorCoord1Max_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void es(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().eb(global::iz.d(v0().Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.txtNumColorCoord2Min_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void er(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().ec(global::iz.d(v1().Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.txtNumColorCoord2Max_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void eq(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().ed(global::iz.d(v2().Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.txtNumColorCoord3Min_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ep(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().ee(global::iz.d(v3().Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.txtNumColorCoord3Max_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void eh(object A_0, EventArgs A_1)
	{
		try
		{
			if (this.m_x2.ed().d5(this.m_x2.dh().aw(by()), by()))
			{
				a3();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumAlarmsMinOrMax_Validated", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ef(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().ej(global::iz.e(((hy)A_0).Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxNumGOFThreshold_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumGOFThreshold_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void d6(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().ek(global::iz.e(((hy)A_0).Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxNumFFTThreshold_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumFFTThreshold_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void d2(object A_0, EventArgs A_1)
	{
		try
		{
			int a_ = this.m_zl.IndexOf((Button)A_0);
			hi hi2 = this.m_x2.ed();
			if (hi2.e3() < 12)
			{
				hi2.ex(a_);
				ar();
				o();
			}
			hi2 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ButtonAddRegion_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void dp(object A_0, EventArgs A_1)
	{
		try
		{
			int a_ = this.m_zm.IndexOf((Button)A_0);
			hi hi2 = this.m_x2.ed();
			if (hi2.e9() < 6)
			{
				hi2.ez(a_);
				aq();
				o();
			}
			hi2 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ButtonAddRegionEx_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void dl(object A_0, EventArgs A_1)
	{
		try
		{
			Button button = (Button)A_0;
			if (button.Enabled)
			{
				button.BackgroundImage = Resources.Insert;
			}
			else
			{
				button.BackgroundImage = Resources.InsertDisabled;
			}
			button = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.ButtonAddRegion_EnabledChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void dk(object A_0, EventArgs A_1)
	{
		try
		{
			Button button = (Button)A_0;
			if (button.Enabled)
			{
				button.BackgroundImage = Resources.InsertDarkGreen;
			}
			button = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.ButtonAddRegion_MouseEnter", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void dj(object A_0, EventArgs A_1)
	{
		try
		{
			Button button = (Button)A_0;
			if (button.Enabled)
			{
				button.BackgroundImage = Resources.Insert;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.ButtonAddRegion_MouseLeave", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void di(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_x2.ed().ey(this.m_zn.IndexOf((Button)A_0));
			ar();
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ButtonDeleteRegion_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void dh(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_x2.ed().e0(this.m_zo.IndexOf((Button)A_0));
			aq();
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ButtonDeleteRegionEx_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void dg(object A_0, EventArgs A_1)
	{
		try
		{
			Button button = (Button)A_0;
			if (button.Enabled)
			{
				button.BackgroundImage = Resources.xDarkRed;
			}
			button = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.ButtonDeleteRegion_MouseEnter", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void df(object A_0, EventArgs A_1)
	{
		try
		{
			Button button = (Button)A_0;
			if (button.Enabled)
			{
				button.BackgroundImage = Resources.x;
			}
			button = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.ButtonDeleteRegion_MouseLeave", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void de(object A_0, EventArgs A_1)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = global::hr.t();
			openFileDialog.FilterIndex = global::e.a().LastUsedOpenSpectrumFilter;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				global::e.a().LastUsedOpenSpectrumFilter = openFileDialog.FilterIndex;
				this.m_x2.ed().d7(openFileDialog.FileName);
				o8().Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ButtonSelectTargetSpec_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void dd(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_x2.ed().d7("");
			o8().Text = "";
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ButtonDeleteGoldenCurve_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void dc(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().ea(yp().Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxCalculateNFromExtrema_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void db(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				CheckBox checkBox = (CheckBox)A_0;
				this.m_x2.ed().d5(this.m_zp.IndexOf(checkBox), checkBox.Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxHCCorr_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void da(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				CheckBox checkBox = (CheckBox)A_0;
				this.m_x2.ed().au(this.m_zq.IndexOf(checkBox), checkBox.Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxRegionActive_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c9(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				CheckBox checkBox = (CheckBox)A_0;
				this.m_x2.ed().d6(this.m_zr.IndexOf(checkBox), checkBox.Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxRegionActiveEx_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c8(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				CheckBox checkBox = (CheckBox)A_0;
				this.m_x2.ed().d7(this.m_zs.IndexOf(checkBox), checkBox.Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxHardLimits_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c7(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				CheckBox checkBox = (CheckBox)A_0;
				if (checkBox == z6())
				{
					this.m_x2.ed().eb(checkBox.Checked);
				}
				else if (checkBox == z5())
				{
					this.m_x2.ed().ec(checkBox.Checked);
				}
				else if (checkBox == ace())
				{
					this.m_x2.ed().ed(checkBox.Checked);
				}
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxSUV_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c6(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().ee(aed().Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxLuminousReflectance_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c5(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().ef(ahp().Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxLuminousReflectance_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c4(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				RadioButton radioButton = (RadioButton)A_0;
				if (radioButton.Checked)
				{
					this.m_x2.ed().au(this.m_z1.IndexOf(radioButton), global::hi.e.a);
					o();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonAvgReflR_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c3(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				RadioButton radioButton = (RadioButton)A_0;
				if (radioButton.Checked)
				{
					this.m_x2.ed().au(this.m_z2.IndexOf(radioButton), global::hi.e.b);
					o();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonAvgReflT_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c2(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				RadioButton radioButton = (RadioButton)A_0;
				if (radioButton.Checked)
				{
					this.m_x2.ed().au(this.m_z3.IndexOf(radioButton), global::hi.e.c);
					o();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonAvgReflA_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c1(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				RadioButton radioButton = (RadioButton)A_0;
				if (radioButton.Checked)
				{
					this.m_x2.ed().d5(this.m_z4.IndexOf(radioButton), global::hi.e.a);
					o();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonExR_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c0(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				RadioButton radioButton = (RadioButton)A_0;
				if (radioButton.Checked)
				{
					this.m_x2.ed().d5(this.m_z5.IndexOf(radioButton), global::hi.e.b);
					o();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonExT_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void cz(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				RadioButton radioButton = (RadioButton)A_0;
				if (radioButton.Checked)
				{
					this.m_x2.ed().d5(this.m_z6.IndexOf(radioButton), global::hi.e.c);
					o();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonExA_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void cy(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				RadioButton radioButton = (RadioButton)A_0;
				hi.b a_ = (radioButton.Checked ? global::hi.b.b : global::hi.b.a);
				this.m_x2.ed().au(this.m_z7.IndexOf(radioButton), a_);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonMaxEx_CheckedChanged", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void cx(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				RadioButton radioButton = (RadioButton)A_0;
				hi.b a_ = ((!radioButton.Checked) ? global::hi.b.b : global::hi.b.a);
				this.m_x2.ed().au(this.m_z8.IndexOf(radioButton), a_);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonMinEx_CheckedChanged", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void cw(object A_0, EventArgs A_1)
	{
		try
		{
			a(ln(), dp());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.SpectrumAnalysis_MouseEnter", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void e(object A_0, LayoutEventArgs A_1)
	{
		try
		{
			a(ln(), dp(), ref this.m_abl);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TabPageSpectrumAnalysis_Layout", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void cv(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				this.m_x2.ed().d5(this.m_aaa.IndexOf(hy2), global::iz.e(hy2.Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxEndWave_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxEndWave_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void cu(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				this.m_x2.ed().d9(this.m_aab.IndexOf(hy2), global::iz.e(hy2.Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxEndWaveEx_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxEndWaveEx_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void ct(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				this.m_x2.ed().d7(this.m_zw.IndexOf(hy2), a(global::iz.e(hy2.Text)));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxMaxR_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxMaxR_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void cs(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				this.m_x2.ed().eb(this.m_zx.IndexOf(hy2), a(global::iz.e(hy2.Text)));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxMaxREx_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxMaxREx_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void cr(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				this.m_x2.ed().d6(this.m_zy.IndexOf(hy2), a(global::iz.e(hy2.Text)));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxMinR_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxMinR_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void cq(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				this.m_x2.ed().ea(this.m_zz.IndexOf(hy2), a(global::iz.e(hy2.Text)));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxMinREx_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxMinREx_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void cp(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.by((float)new h4(global::h4.a.c).e(global::iz.e(((hy)A_0).Text)));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxSpecAnalysisSmoothing_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxSpecAnalysisSmoothing_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void co(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				this.m_x2.ed().au(this.m_aac.IndexOf(hy2), global::iz.e(hy2.Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxStartWave_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxStartWave_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void cn(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				this.m_x2.ed().d8(this.m_aad.IndexOf(hy2), global::iz.e(hy2.Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxStartWaveEx_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxStartWaveEx_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void cm(object A_0, EventArgs A_1)
	{
		try
		{
			agn().Enabled = age().Checked;
			if (!bs())
			{
				this.m_x2.ed().c9.r(age().Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxFPDip_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void cl(object A_0, EventArgs A_1)
	{
		try
		{
			agz().Enabled = agd().Checked;
			if (!bs())
			{
				this.m_x2.ed().c9.s(agd().Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxDBRCenter_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ck(object A_0, EventArgs A_1)
	{
		try
		{
			if (agq().Checked)
			{
				agw().Checked = false;
			}
			a2();
			if (!bs())
			{
				this.m_x2.ed().c9.o(!agq().Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonFPDipReflectanceLimited_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void cj(object A_0, EventArgs A_1)
	{
		try
		{
			if (agw().Checked)
			{
				agq().Checked = false;
			}
			a2();
			if (!bs())
			{
				this.m_x2.ed().c9.o(agw().Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonFPDipWavelenLimited_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ci(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().c9.a(global::iz.d(agr().Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumFPRLowThreshold_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ch(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().c9.h(global::iz.d(agl().Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumFPRHighThreshold_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void cg(object A_0, EventArgs A_1)
	{
		try
		{
			if (agi().Checked)
			{
				agh().Checked = false;
			}
			if (!bs())
			{
				this.m_x2.ed().c9.p(!agi().Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonFPRAbsolute_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void cf(object A_0, EventArgs A_1)
	{
		try
		{
			if (agh().Checked)
			{
				agi().Checked = false;
			}
			if (!bs())
			{
				this.m_x2.ed().c9.p(agh().Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonFPRRelative_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ce(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().c9.o(global::iz.d(agv().Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumFPWaveMin_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void cd(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().c9.p(global::iz.d(agt().Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumFPWaveMax_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void cc(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.ed().c9.q(global::iz.d(ag5().Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumDBRThreshold_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void cb(object A_0, EventArgs A_1)
	{
		try
		{
			if (ag8().Checked)
			{
				ag7().Checked = false;
			}
			if (!bs())
			{
				this.m_x2.ed().c9.q(!ag8().Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonDBRThreshAbs_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ca(object A_0, EventArgs A_1)
	{
		try
		{
			if (ag7().Checked)
			{
				ag8().Checked = false;
			}
			if (!bs())
			{
				this.m_x2.ed().c9.q(ag7().Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonDBRThreshRelative_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b0()
	{
		yf().Enabled = yj().Checked && !ch().TabPages.Contains(ci());
	}

	private void b9(object A_0, EventArgs A_1)
	{
		try
		{
			b0();
			if (!bs())
			{
				this.m_x2.b8(yj().CheckState == CheckState.Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxBacksideSubtraction_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b8(object A_0, EventArgs A_1)
	{
		try
		{
			a(yk(), ye());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.SpectrumProcessing_MouseEnter", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, LayoutEventArgs A_1)
	{
		try
		{
			a(yk(), ye(), ref this.m_abm);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TabPageSpectrumProcessing_Layout", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b7(object A_0, EventArgs A_1)
	{
		try
		{
			a(pw(), d2());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.AcqSettings_MouseEnter", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b6(object A_0, EventArgs A_1)
	{
		try
		{
			a(px(), ev());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.AcqSettingsDM_MouseEnter", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void bz()
	{
		gl().TabPages.Clear();
		if (gk().Checked)
		{
			TabPage tabPage = gm();
			string A_ = "SpectrometersHaveSameConfig";
			tabPage.Text = global::hu.a(ref A_);
			gl().TabPages.Add(gm());
			return;
		}
		if (this.m_aay[0])
		{
			TabPage tabPage2 = gm();
			string A_ = "ReflectanceTitle";
			tabPage2.Text = global::hu.a(ref A_);
			gl().TabPages.Add(gm());
		}
		if (this.m_aay[1])
		{
			gl().TabPages.Add(gy());
		}
		if (this.m_aay[2])
		{
			u8().Text = this.m_aaz;
			gl().TabPages.Add(u8());
		}
	}

	private void a(List<it> A_0, List<iv> A_1, List<iu> A_2, h.f[] A_3)
	{
		checked
		{
			foreach (iu item2 in A_2)
			{
				bool flag = false;
				int num = A_1.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					iv iv2 = A_1[num2];
					it item = new it(iv2.c());
					if (A_0.IndexOf(item) < 0)
					{
						continue;
					}
					int num3 = iv2.b.IndexOf(new iu(item2.c(), global::iu.a.a));
					List<string> list = ((num3 >= 0) ? iv2.b[num3].b : new List<string>());
					it it2 = A_0[A_0.IndexOf(item)];
					if (A_3 != null && A_3[it2.g()] == global::h.f.b)
					{
						if (!list.Contains("1"))
						{
							item2.b.Clear();
							break;
						}
					}
					else if (!flag)
					{
						foreach (string item3 in list)
						{
							if (!item2.b.Contains(item3))
							{
								item2.b.Add(item3);
							}
						}
						flag = true;
					}
					else
					{
						for (int num4 = item2.b.Count - 1; num4 >= 0; num4 += -1)
						{
							string current2 = item2.b[num4];
							if (!list.Contains(current2))
							{
								item2.b.Remove(current2);
							}
						}
					}
					it2 = null;
				}
			}
			for (int num5 = A_2.Count - 1; num5 >= 0; num5 += -1)
			{
				if (A_2[num5].b.Count == 0)
				{
					A_2.RemoveAt(num5);
				}
			}
		}
	}

	private void b5(object A_0, EventArgs A_1)
	{
		cl cl2 = null;
		try
		{
			List<it> list = null;
			List<iu> list2 = new List<iu>();
			bool A_2 = false;
			new List<string>();
			h h10 = this.m_x2.b8();
			int A_3 = default(int);
			bool flag = default(bool);
			if (c())
			{
				List<iv> list3 = this.m_x6.tf(this.m_xr);
				list = d();
				list2 = this.m_x6.m2(this.m_xr, list, list3);
				a(list, list3, list2, null);
			}
			else
			{
				List<iv> list3 = this.m_x6.uq(this.m_xr);
				list = this.m_x6.m2(this.m_xr, this.m_x2, this.m_aak, ref A_2, ref A_3);
				list2 = this.m_x6.m2(this.m_xr, list, list3);
				flag = this.m_x6.vm(this.m_xr);
				if (!flag || h10.a(this.m_aay) != global::h.e.c)
				{
					a(list, list3, list2, this.m_aa1);
				}
			}
			h.e a_ = global::h.e.a;
			bool a_2 = !ch().TabPages.Contains(ci()) && !ch().TabPages.Contains(cj()) && (!this.m_aak || !this.m_x2.b8().a(this.m_y9, !this.m_zg));
			if (flag)
			{
				a_ = this.m_x2.b8().a(this.m_aay);
			}
			g g10 = h10.a(global::h.a(flag, a_));
			if (this.m_x2.d0().c() == global::g2.a.b && !g10.c().StartsWith(global::ex.e()))
			{
				g10.c(global::ex.e() + g10.c());
			}
			cl2 = new cl(this.m_y5);
			cl obj = cl2;
			f1 a_3 = this.m_x6;
			List<iu> a_4 = list2;
			g2.a a_5 = this.m_x2.d0().c();
			List<it> a_6 = list;
			string a_7 = this.m_x0;
			bool a_8 = A_2;
			int a_9 = A_3;
			h.f[] a_10 = this.m_aa1;
			@is.a a_11 = b();
			h h11;
			float A_4 = (h11 = h10).at();
			h h12;
			string A_5 = (h12 = h10).@as();
			g g11;
			string A_6 = (g11 = g10).c();
			g g12;
			bool A_7 = (g12 = g10).d();
			hg hg2;
			float A_8 = (hg2 = this.m_x2).dx();
			h h13;
			bool A_9 = (h13 = this.m_x2.b8()).p();
			obj.a(a_3, a_4, a_5, a_6, a_7, a_8, a_9, a_10, a_2, a_11, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8, ref A_9);
			h13.a(A_9);
			hg2.by(A_8);
			g12.c(A_7);
			g11.c(A_6);
			h12.a(A_5);
			h11.a(A_4);
			h10 = null;
			if (cl2.DialogResult == DialogResult.OK)
			{
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_12 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ButtonAdvSettings_Click", a_12);
			ProjectData.ClearProjectError();
		}
		finally
		{
			cl2?.Close();
		}
	}

	private void b4(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				ff ff2 = new ff();
				int a_ = (int)Math.Round((double)base.Width * 0.5 - (double)ff2.Width * 0.5);
				int a_2 = (int)Math.Round((double)base.Height * 0.5 - (double)ff2.Height * 0.5);
				bool flag = global::e8.a.a(this.m_aah, this.m_x2.d0());
				TabPage selectedTab = ch().SelectedTab;
				bool a_3 = false;
				ff2.Location = global::i6.a(this, a_, a_2);
				ff2.a(this.m_x6, this.m_xr, this.m_x2.d0(), a_3, this.m_x2.d1(), this.m_y5);
				if (ff2.a9())
				{
					g2 obj = ff2.ba();
					hg hg2;
					g2 A_2 = (hg2 = this.m_x2).d0();
					obj.a(ref A_2);
					hg2.bu(A_2);
					o();
					g(flag != global::e8.a.a(this.m_aah, this.m_x2.d0()));
					if (ch().SelectedTab != selectedTab)
					{
						ch().SelectedTab = selectedTab;
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_4 = ex2;
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ButtonOpticsConfig_Click", a_4);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void a(object A_0, DataGridViewCellEventArgs A_1)
	{
		try
		{
			if (bs())
			{
				return;
			}
			object objectValue = RuntimeHelpers.GetObjectValue(wi().Rows[A_1.RowIndex].Cells[A_1.ColumnIndex].Value);
			string a_ = null;
			if (this.m_x2.b8().av())
			{
				if (A_1.ColumnIndex == wi().Columns.IndexOf(yb()))
				{
					if (objectValue != null)
					{
						a_ = objectValue.ToString();
					}
					this.m_x2.b8().au()[A_1.RowIndex].d = global::iz.d(a_);
				}
				else if (A_1.ColumnIndex == wi().Columns.IndexOf(yc()))
				{
					this.m_x2.b8().au()[A_1.RowIndex].a = Conversions.ToBoolean(objectValue);
				}
			}
			else if (A_1.ColumnIndex == wi().Columns.IndexOf(yb()))
			{
				if (objectValue != null)
				{
					a_ = objectValue.ToString();
				}
				this.m_x2.b8().a2()[A_1.RowIndex].d = global::iz.d(a_);
			}
			else if (A_1.ColumnIndex == wi().Columns.IndexOf(yc()))
			{
				this.m_x2.b8().a2()[A_1.RowIndex].a = Conversions.ToBoolean(objectValue);
			}
			else if (A_1.ColumnIndex == wi().Columns.IndexOf(yd()))
			{
				if (objectValue != null)
				{
					a_ = objectValue.ToString();
				}
				this.m_x2.b8().a2()[A_1.RowIndex].c = global::iz.d(a_);
			}
			_ = null;
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.DataGridViewPDSettings_CellValueChanged", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void b3(object A_0, EventArgs A_1)
	{
		try
		{
			wi().EndEdit();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.DataGridViewPDSettings_Leave", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b2(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				if (((RadioButton)A_0).Checked)
				{
					this.m_x2.b8().b(global::h.MeasurementTimingType.Manual);
				}
				am();
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.RadioButtonFixedIntTime_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonFixedIntTime_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void b1(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				if (((RadioButton)A_0).Checked)
				{
					this.m_x2.b8().b(global::h.MeasurementTimingType.Maximum);
				}
				am();
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.RadioButtonMaxSamplingTime_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonMaxSamplingTime_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void b0(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				if (((RadioButton)A_0).Checked)
				{
					this.m_x2.b8().b(global::h.MeasurementTimingType.Recommended);
				}
				am();
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.RadioButtonRecommendedTime_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonRecommendedTime_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void bz(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs() && ((RadioButton)A_0).Checked)
			{
				if (A_0 == e2() || A_0 == gs())
				{
					this.m_x2.b8().a(0).h(global::f.a.a);
				}
				else if (A_0 == ez() || A_0 == gn())
				{
					this.m_x2.b8().a(0).h(global::f.a.d);
				}
				else if (A_0 == g2())
				{
					this.m_x2.b8().a(1).h(global::f.a.a);
				}
				else if (A_0 == gz())
				{
					this.m_x2.b8().a(1).h(global::f.a.d);
				}
				else if (A_0 == vc())
				{
					this.m_x2.b8().a(2).h(global::f.a.a);
				}
				else if (A_0 == u9())
				{
					this.m_x2.b8().a(2).h(global::f.a.d);
				}
				am();
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.RadioButtonAnySpec_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonAnySpec_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void by(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs() && ((RadioButton)A_0).Checked)
			{
				this.m_x2.b8().r(A_0 == x8());
				x();
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.RadioButtonPDGainAutoManual_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonPDGainAutoManual_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void bx(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs() && ((RadioButton)A_0).Checked)
			{
				if (A_0 == e1() || A_0 == gp())
				{
					this.m_x2.b8().a(0).h(global::f.a.b);
				}
				else if (A_0 == g1())
				{
					this.m_x2.b8().a(1).h(global::f.a.b);
				}
				else if (A_0 == vb())
				{
					this.m_x2.b8().a(2).h(global::f.a.b);
				}
				am();
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.RadioButtonShort_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonShort_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void bw(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs() && ((RadioButton)A_0).Checked)
			{
				if (A_0 == e0() || A_0 == go())
				{
					this.m_x2.b8().a(0).h(global::f.a.c);
				}
				else if (A_0 == g0())
				{
					this.m_x2.b8().a(1).h(global::f.a.c);
				}
				else if (A_0 == va())
				{
					this.m_x2.b8().a(2).h(global::f.a.c);
				}
				am();
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.RadioButtonLong_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.RadioButtonLong_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void bv(object A_0, EventArgs A_1)
	{
		try
		{
			bz();
			if (!bs())
			{
				am();
				this.m_x2.b8().b(gk().Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.CheckBoxDMSpecTypeTSameAsR_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxDMSpecTypeTSameAsR_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void bu(object A_0, EventArgs A_1)
	{
		try
		{
			if (bs())
			{
				return;
			}
			if (vk().Checked)
			{
				if (vi().Enabled)
				{
					vi().Checked = true;
				}
				if (vh().Enabled)
				{
					vh().Checked = true;
				}
				if (vg().Enabled)
				{
					vg().Checked = true;
				}
			}
			else
			{
				vi().Checked = false;
				vh().Checked = false;
				vg().Checked = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.CheckBoxMMeasAll_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxMMeasAll_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void bt(object A_0, EventArgs A_1)
	{
		try
		{
			try
			{
				bp();
				vk().Checked = (!vi().Enabled || vi().Checked) && (!vh().Enabled || vh().Checked) && (!vg().Enabled || vg().Checked);
			}
			finally
			{
				bq();
			}
			if (!bs())
			{
				if ((vi().Checked || !vi().Enabled) && (vh().Checked || !vh().Enabled) && (vg().Checked || !vg().Enabled))
				{
					this.m_x2.b8().r(global::h.e.a);
				}
				else if (vi().Enabled && vi().Checked && vh().Enabled && vh().Checked)
				{
					this.m_x2.b8().r(global::h.e.e);
				}
				else if (vi().Enabled && vi().Checked && vg().Enabled && vg().Checked)
				{
					this.m_x2.b8().r(global::h.e.f);
				}
				else if (vh().Enabled && vh().Checked && vg().Enabled && vg().Checked)
				{
					this.m_x2.b8().r(global::h.e.g);
				}
				else if (vi().Enabled && vi().Checked)
				{
					this.m_x2.b8().r(global::h.e.b);
				}
				else if (vh().Enabled && vh().Checked)
				{
					this.m_x2.b8().r(global::h.e.c);
				}
				else if (vg().Enabled && vg().Checked)
				{
					this.m_x2.b8().r(global::h.e.d);
				}
				am();
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.CheckBoxMMeas_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxMMeas_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void bs(object A_0, EventArgs A_1)
	{
		try
		{
			wo().Enabled = wm().Checked;
			wr().Enabled = wm().Checked;
			if (!bs())
			{
				this.m_x2.b8().p(wm().Checked);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.CheckBoxPDMultiWafer_CheckedChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CheckBoxPDMultiWafer_CheckedChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void br(object A_0, EventArgs A_1)
	{
		try
		{
			bool flag = Operators.CompareString(wg().SelectedItem.ToString(), "Spectrometer", TextCompare: false) == 0;
			this.m_x2.b8().a(A_0: false, A_1: false, !flag);
			ey().Visible = flag && !this.m_aat;
			e3().Visible = flag;
			e(flag);
			wi().Visible = this.m_aak;
			wl().Visible = !flag;
			x7().Visible = !flag;
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.ComboBoxAcqInput_SelectedIndexChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ComboBoxAcqInput_SelectedIndexChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, LayoutEventArgs A_1)
	{
		try
		{
			a(pw(), d2(), ref this.m_abn);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TabPageAcqSettings_Layout", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, LayoutEventArgs A_1)
	{
		try
		{
			a(px(), ev(), ref this.m_abo);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TabPageDMAcqSettings_Layout", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void bq(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				if (A_0 == uw())
				{
					this.m_x2.b8().a(2).b(global::f.b.c, global::iz.e(hy2.Text));
				}
				else if (A_0 == u6())
				{
					this.m_x2.b8().a(2).b(global::f.b.b, global::iz.e(hy2.Text));
				}
				else if (A_0 == @in())
				{
					this.m_x2.b8().a(1).b(global::f.b.c, global::iz.e(hy2.Text));
				}
				else if (A_0 == io())
				{
					this.m_x2.b8().a(1).b(global::f.b.b, global::iz.e(hy2.Text));
				}
				else if (A_0 == f7() || A_0 == id())
				{
					this.m_x2.b8().a(0).b(global::f.b.c, global::iz.e(hy2.Text));
				}
				else
				{
					this.m_x2.b8().a(0).b(global::f.b.b, global::iz.e(hy2.Text));
				}
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxIntTime_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxIntTime_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void bp(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				this.m_x2.b8().a(global::iz.e(hy2.Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxMaxSamplingTime_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxMaxSamplingTime_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void bo(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.b8().b(global::iz.c(wo().Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxNumPDNumWafers_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumPDNumWafers_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void bn(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.b8().d(global::iz.d(wr().Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxNumPDRotationSpeed_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumPDRotationSpeed_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void bm(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.b8().b(global::iz.d(wu().Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxNumPDSamplingTime_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumPDSamplingTime_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void bl(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				hy hy2 = (hy)A_0;
				if (A_0 == uu())
				{
					this.m_x2.b8().a(2).b(global::f.b.c, global::iz.c(hy2.Text));
				}
				else if (A_0 == uv())
				{
					this.m_x2.b8().a(2).b(global::f.b.b, global::iz.c(hy2.Text));
				}
				else if (A_0 == il())
				{
					this.m_x2.b8().a(1).b(global::f.b.c, global::iz.c(hy2.Text));
				}
				else if (A_0 == im())
				{
					this.m_x2.b8().a(1).b(global::f.b.b, global::iz.c(hy2.Text));
				}
				else if (A_0 == fz() || A_0 == ib())
				{
					this.m_x2.b8().a(0).b(global::f.b.c, global::iz.c(hy2.Text));
				}
				else
				{
					this.m_x2.b8().a(0).b(global::f.b.b, global::iz.c(hy2.Text));
				}
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxNumSpectra_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumSpectra_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void bk(object A_0, EventArgs A_1)
	{
		this.m_x2.b8().d().a = zq().Checked;
		o();
	}

	private void bj(object A_0, EventArgs A_1)
	{
		this.m_x2.b8().d().i(global::h.d.a.a);
		o();
	}

	private void bi(object A_0, EventArgs A_1)
	{
		this.m_x2.b8().d().i(global::h.d.a.b);
		o();
	}

	private void bh(object A_0, EventArgs A_1)
	{
		this.m_x2.b8().d().i(global::h.d.a.c);
		o();
	}

	private void bg(object A_0, EventArgs A_1)
	{
		this.m_x2.b8().d().c = global::iz.d(zt().Text);
		o();
	}

	private void bf(object A_0, EventArgs A_1)
	{
		this.m_x2.b8().d().d = global::iz.d(ahl().Text);
		o();
	}

	private void be(object A_0, EventArgs A_1)
	{
		this.m_x2.b8().d().e = global::iz.d(af9().Text);
		o();
	}

	private void bd(object A_0, EventArgs A_1)
	{
		this.m_x2.b8().d().f = global::iz.d(ahh().Text);
		o();
	}

	private void a3(object A_0, EventArgs A_1)
	{
		this.m_x2.b8().d().g = global::iz.d(ahi().Text);
		o();
	}

	private void a2(object A_0, EventArgs A_1)
	{
	}

	private void a(r.d.a A_0)
	{
		if (base.InvokeRequired)
		{
			r.d.b method = a;
			BeginInvoke(method, A_0);
			return;
		}
		Cursor = Cursors.Default;
		r.aa.a a10 = (r.aa.a)A_0;
		if (a10.ay == global::r.aa.a.a.a)
		{
			zt().Text = a10.az.ToString("0.##");
			global::fe.b(this.m_y5, "Offset has been updated. Check file to verify accuracy:\r\n" + global::h.b(), "Information", global::i6.a(zu()));
		}
		else
		{
			global::fe.b(this.m_y5, ((r.d.a)a10).b, global::i6.a(zu()));
		}
		a10 = null;
	}

	private void a(object A_0, LayoutEventArgs A_1)
	{
		try
		{
			a(w3(), w2(), ref this.m_abp);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TabPageVsTimeAnalysisSettings_Layout", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a1(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.b9().b = global::iz.d(x5().Text);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.nValueBox_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ar(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.b9().a = t();
				bp();
				try
				{
					q();
				}
				finally
				{
					bq();
				}
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.CBGrowthRateUnit_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void aq(object A_0, EventArgs A_1)
	{
		try
		{
			if (bs())
			{
				return;
			}
			if (Operators.CompareString(xa().Text, "", TextCompare: false) != 0)
			{
				if (xv().Checked)
				{
					return;
				}
				bp();
				try
				{
					xv().Checked = true;
					ref fz a_ = ref this.m_y5;
					Point A_2 = global::i6.a(this);
					global::fe.b(ref a_, "Fixed n required when material specified.", ref A_2);
					return;
				}
				finally
				{
					bq();
				}
			}
			if (xv().Checked)
			{
				xw().Enabled = true;
			}
			else
			{
				xw().Enabled = false;
				if (xj().Checked)
				{
					xj().Checked = false;
					ref fz a_2 = ref this.m_y5;
					Point A_2 = global::i6.a(this);
					global::fe.b(ref a_2, "Growth Rate Only Option disabled.", ref A_2);
				}
			}
			this.m_x2.b9().n = xv().Checked;
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.VInFixCheck_Checked", a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void ao(object A_0, EventArgs A_1)
	{
		try
		{
			if (bs())
			{
				return;
			}
			if (Operators.CompareString(xa().Text, "", TextCompare: false) != 0)
			{
				if (!w8().Checked)
				{
					return;
				}
				bp();
				try
				{
					w8().Checked = false;
					ref fz a_ = ref this.m_y5;
					Point A_2 = global::i6.a(this);
					global::fe.b(ref a_, "Fix Scaling not valid when material specified.", ref A_2);
					return;
				}
				finally
				{
					bq();
				}
			}
			if (w8().Checked)
			{
				w7().Enabled = true;
				if (xj().Checked)
				{
					xj().Checked = false;
					ref fz a_2 = ref this.m_y5;
					Point A_2 = global::i6.a(this);
					global::fe.b(ref a_2, "Growth Rate Only Option disabled.", ref A_2);
				}
			}
			else
			{
				w7().Enabled = false;
			}
			this.m_x2.b9().j = w8().Checked;
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.VIsFixCheck_CheckedChanged", a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void an(object A_0, EventArgs A_1)
	{
		try
		{
			if (bs())
			{
				return;
			}
			if (Operators.CompareString(xa().Text, "", TextCompare: false) != 0)
			{
				if (xy().Checked)
				{
					bp();
					try
					{
						xy().Checked = false;
						ref fz a_ = ref this.m_y5;
						Point A_2 = global::i6.a(this);
						global::fe.b(ref a_, "Fix k not valid when material specified.", ref A_2);
						return;
					}
					finally
					{
						bq();
					}
				}
			}
			else
			{
				if (xy().Checked)
				{
					x0().Enabled = true;
				}
				else
				{
					x0().Enabled = false;
				}
				this.m_x2.b9().p = xy().Checked;
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.VIkFixCheck_CheckedChanged", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void am(object A_0, EventArgs A_1)
	{
		try
		{
			if (bs())
			{
				return;
			}
			if (Operators.CompareString(xa().Text, "", TextCompare: false) != 0)
			{
				if (!xs().Checked)
				{
					return;
				}
				bp();
				try
				{
					xs().Checked = false;
					ref fz a_ = ref this.m_y5;
					Point A_2 = global::i6.a(this);
					global::fe.b(ref a_, "Fix Rate not valid when material specified.", ref A_2);
					return;
				}
				finally
				{
					bq();
				}
			}
			if (xs().Checked)
			{
				xr().Enabled = true;
				if (xj().Checked)
				{
					xj().Checked = false;
					ref fz a_2 = ref this.m_y5;
					Point A_2 = global::i6.a(this);
					global::fe.b(ref a_2, "Growth Rate Only Option disabled.", ref A_2);
				}
			}
			else
			{
				xr().Enabled = false;
			}
			this.m_x2.b9().l = xs().Checked;
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.VIGFixCheck_CheckedChanged", a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void al(object A_0, EventArgs A_1)
	{
		try
		{
			if (bs())
			{
				return;
			}
			if (xj().Checked)
			{
				bp();
				try
				{
					a(A_0: true, A_1: false, A_2: false, A_3: false);
				}
				finally
				{
					bq();
				}
			}
			this.m_x2.b9().h = xj().Checked;
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.GrowthRateOnlyCheck_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void af(object A_0, EventArgs A_1)
	{
		try
		{
			xj().Enabled = xa().SelectedIndex == 0;
			if (bs())
			{
				return;
			}
			if (xj().Checked && xa().SelectedIndex > 0)
			{
				bp();
				try
				{
					xj().Checked = false;
					this.m_x2.b9().h = false;
				}
				finally
				{
					bq();
				}
				ref fz a_ = ref this.m_y5;
				Point A_2 = global::i6.a(this);
				global::fe.b(ref a_, "Growth Rate Only Option disabled.", ref A_2);
			}
			if (Operators.CompareString(xa().Text, "", TextCompare: false) != 0)
			{
				bp();
				try
				{
					a(A_0: true, A_1: false, A_2: false, A_3: false);
				}
				finally
				{
					bq();
				}
			}
			else
			{
				bp();
				try
				{
					a(A_0: false, A_1: false, A_2: true, A_3: false);
					w7().Value = 1m;
				}
				finally
				{
					bq();
				}
			}
			this.m_x2.b9().d = xa().SelectedIndex;
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.VIMaterialList_SelectedIndexChanged", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void ad(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.b9().c = global::iz.d(xn().Text);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.VITempBox_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ac(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.b9().e = global::iz.d(xe().Text);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.VIAngleBox_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ab(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.b9().f = xf().Checked;
				this.m_x2.b9().g = xi().Checked;
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.VITEOption_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void aa(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.b9().i = Convert.ToSingle(w7().Value);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.VIsSetBox_ValueChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void z(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.b9().k = global::jk.s(Convert.ToSingle(xr().Value), this.m_x2.b9().a);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.VIGSetBox_ValueChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void y(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.b9().m = Convert.ToSingle(xw().Value);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.VInSetBox_ValueChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void x(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				this.m_x2.b9().o = Convert.ToSingle(x0().Value);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.VIkSetBox_ValueChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void w(object A_0, EventArgs A_1)
	{
		try
		{
			if (e())
			{
				bool A_2 = false;
				a(ref A_2);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ButtonApply_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void v(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_x4.bu(this.m_y5, global::i6.a(b6()), this.m_xy, this.m_x6.xk(this.m_xr), A_4: true, global::e8.a.a(this.m_aah, this.m_x2.d0()), null, A_7: false, by());
			base.DialogResult = DialogResult.Cancel;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ButtonCancel_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void u(object A_0, EventArgs A_1)
	{
		try
		{
			hi A_2 = null;
			cu cu2 = null;
			if (cu2 == null || cu2.IsDisposed)
			{
				cu2 = new cu();
			}
			hi hi2 = this.m_x2.b3(this.m_x2.c2());
			hi2.au(ref A_2);
			cu2.aj(this.m_y5, hi2, this.m_x2.ca(), this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq));
			if (global::hi.d5(A_2, hi2))
			{
				hi2.ho();
				this.m_x2.b5(A_0: false);
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ButtonEditCorrCoef_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void t(object A_0, EventArgs A_1)
	{
		try
		{
			if (!e())
			{
				return;
			}
			bool A_2 = false;
			a(ref A_2);
			int num;
			if (this.m_abc)
			{
				if (this.m_x2.c9() || Operators.CompareString(this.m_x2.ci(), "DefaultRecipe", TextCompare: false) == 0)
				{
					num = (global::hg.bv(this.m_x2, this.m_x4) ? 1 : 0);
					if (num == 0)
					{
						goto IL_0068;
					}
				}
				else
				{
					num = 1;
				}
				SystemSounds.Exclamation.Play();
				goto IL_0068;
			}
			goto IL_00da;
			IL_0068:
			if (num == 0 || global::fe.b(ref this.m_y5, "Click Save to permanently save changes or Cancel to revert\r\n back to the original recipe and lose changes.", "UserQuery", "SaveString", "CancelString", global::i6.a(this)))
			{
				string text = this.m_x2.c1();
				if (Operators.CompareString(Path.GetExtension(text), ".rpe", TextCompare: false) == 0)
				{
					text = text.Substring(0, checked(text.Length - ".rpe".Length)) + ".fitrp";
				}
				a(text);
			}
			goto IL_00da;
			IL_00da:
			base.DialogResult = DialogResult.OK;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ButtonOK_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void q(object A_0, EventArgs A_1)
	{
		try
		{
			new z().a(this.m_y5, this.m_x6, this.m_x7, RuntimeHelpers.GetObjectValue(this.m_xq), this.m_x2, this.m_zi, this.m_xr, this.m_xz, this.m_y7, this.m_xy, this.m_y3, this.m_aal, this.m_aah, this.m_aak, this.m_aai, this.m_aax);
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), global::i6.a(af6()), "DialogEditRecipe.ButtonAdditionalRecipes_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void p(object A_0, EventArgs A_1)
	{
		try
		{
			int num;
			if (this.m_x2.c9() || Operators.CompareString(this.m_x2.ci(), "DefaultRecipe", TextCompare: false) == 0)
			{
				num = (global::hg.bv(this.m_x2, this.m_x4) ? 1 : 0);
				if (num == 0)
				{
					goto IL_0046;
				}
			}
			else
			{
				num = 1;
			}
			SystemSounds.Exclamation.Play();
			goto IL_0046;
			IL_0046:
			if (num != 0)
			{
				ref fz a_ = ref this.m_y5;
				string A_2 = "RecipeUnsavedPromptFmt3";
				if (!global::fe.b(ref a_, string.Format(global::hu.a(ref A_2), "Recipe".ToLower(), "\r\n", "Recipe".ToLower()), "RecipeLoadTitle", "OKString", "CancelString", bv()))
				{
					return;
				}
			}
			Point a_2 = ((A_0 != b7()) ? cc().PointToScreen(new Point(cg().Bounds.Left, cg().Bounds.Bottom)) : global::i6.a(b7()));
			List<string> a_3 = null;
			if (this.m_x7 != null && this.m_x7.k() && this.m_x7.g() && this.m_x7.h() <= global::gq.a.b)
			{
				a_3 = this.m_x7.l();
			}
			fk fk2 = new fk(this.m_y5, global::hg.b0(), this.m_x2.c1(), this.m_zi, global::fk.a.a, "DefaultRecipe", A_6: false, a_3);
			fk2.a(a_2);
			if (fk2.k())
			{
				return;
			}
			bool flag = global::e8.a.a(this.m_aah, this.m_x2.d0());
			TabPage selectedTab = ch().SelectedTab;
			if (this.m_x2.bu(fk2.q(), global::hg.b4(), this.m_zj, global::r.d.a.b.a, A_4: true, A_5: false, default(Point), null, this.m_x6.w9(this.m_xr), !this.m_x6.w6(this.m_xr), this.m_y5, this.m_x6.xk(this.m_xr), this.m_abc, A_13: false, null, A_15: false))
			{
				m();
				g(flag != global::e8.a.a(this.m_aah, this.m_x2.d0()));
				if (ch().SelectedTab != selectedTab)
				{
					ch().SelectedTab = selectedTab;
				}
			}
			else
			{
				global::fe.b(this.m_y5, "Unknown failure loading recipe:" + fk2.q(), bv());
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_4 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ButtonOpenRecipe_Click", a_4);
			ProjectData.ClearProjectError();
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		try
		{
			bool flag = this.m_x2.b5();
			bool flag2 = false;
			string A_2;
			if (Operators.CompareString(this.m_x2.ci(), "DefaultRecipe", TextCompare: false) == 0)
			{
				fz a_ = this.m_y5;
				A_2 = "RecipeCantDeleteDefaultFmt1";
				global::fe.b(a_, string.Format(global::hu.a(ref A_2), Strings.LCase("Recipe")), "RecipeCantDeleteTitle", bv());
				return;
			}
			if (Operators.CompareString(this.m_x2.c1(), this.m_zd.c1(), TextCompare: false) == 0)
			{
				flag2 = true;
			}
			SystemSounds.Exclamation.Play();
			ref fz a_2 = ref this.m_y5;
			A_2 = "RecipeDeletePromptFmt1";
			if (global::fe.b(ref a_2, string.Format(global::hu.a(ref A_2), this.m_x2.c1().Remove(0, global::hg.b0().Length)), "RecipeCantDeleteTitle", "OKString", "CancelString", bv()))
			{
				bool flag3 = global::e8.a.a(this.m_aah, this.m_x2.d0());
				TabPage selectedTab = ch().SelectedTab;
				string text = ((!flag) ? ".fitrp" : ".fitra");
				string path = this.m_x2.c1();
				this.m_x2.ec();
				global::c.e().FileSystem.DeleteFile(this.m_x2.c1());
				string directory = Path.GetDirectoryName(path) + "\\";
				ReadOnlyCollection<string> files = global::c.e().FileSystem.GetFiles(directory, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*" + text);
				if (files.Count > 0)
				{
					ref hg a_3 = ref this.m_x2;
					A_2 = files[0];
					global::hg.bu(ref a_3, ref A_2, global::hg.b4(), flag, this.m_zj, global::r.d.a.b.a, this.m_y5, A_7: false, default(Point), null, this.m_x6.w9(this.m_xr), !this.m_x6.w6(this.m_xr), this.m_x6.xk(this.m_xr), this.m_abc);
				}
				else
				{
					global::hg.bu(this.m_x2, global::hg.b4(), flag, this.m_zj, global::r.d.a.b.a, this.m_y5, this.m_x6.w9(this.m_xr), !this.m_x6.w6(this.m_xr), this.m_abc);
				}
				m();
				if (flag2)
				{
					this.m_x2.bu(ref this.m_zd);
					this.m_zd.bv(this.m_zj, A_1: false);
				}
				g(flag3 != global::e8.a.a(this.m_aah, this.m_x2.d0()));
				if (ch().SelectedTab != selectedTab)
				{
					ch().SelectedTab = selectedTab;
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_4 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ToolStripButtonDeleteFile_Click", a_4);
			ProjectData.ClearProjectError();
		}
	}

	private void n(object A_0, EventArgs A_1)
	{
		try
		{
			bool flag = global::e8.a.a(this.m_aah, this.m_x2.d0());
			TabPage selectedTab = ch().SelectedTab;
			g2 A_2 = null;
			this.m_x2.d0().a(ref A_2);
			global::hg.bu(this.m_x2, global::hg.b4(), this.m_x2.b5(), this.m_zj, global::r.d.a.b.a, this.m_y5, this.m_x6.w9(this.m_xr), !this.m_x6.w6(this.m_xr), this.m_abc);
			this.m_x2.bu(A_2);
			m();
			g(flag != global::e8.a.a(this.m_aah, this.m_x2.d0()));
			if (ch().SelectedTab != selectedTab)
			{
				ch().SelectedTab = selectedTab;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ToolStripButtonNew_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void m(object A_0, EventArgs A_1)
	{
		try
		{
			string text = "";
			if (f() || b(this.m_x2.ci()) || !e())
			{
				return;
			}
			string text2 = this.m_x2.c1();
			if (!text2.StartsWith(global::hg.bz(), StringComparison.CurrentCultureIgnoreCase))
			{
				fz a_ = this.m_y5;
				string A_2 = "RecipeInvalidSaveDirFmt2";
				global::fe.b(a_, string.Format(global::hu.a(ref A_2), text2, global::hg.bz()), bv());
				l(RuntimeHelpers.GetObjectValue(A_0), A_1);
				return;
			}
			if (Operators.CompareString(Path.GetExtension(text2), ".rpe", TextCompare: false) == 0)
			{
				text = ".fitrp";
				text2 = text2.Substring(0, checked(text2.Length - ".rpe".Length)) + text;
			}
			a(text2);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ToolStripButtonSave_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		try
		{
			if (f() || !e())
			{
				return;
			}
			string A_2 = null;
			if (a(this.m_y5, this.m_x2, bv(), ref A_2))
			{
				if (Operators.CompareString(A_2, this.m_x2.c1(), TextCompare: false) != 0)
				{
					this.m_x2.bv(this.m_xy, DateTime.Now);
				}
				a(A_2);
				b8().Text = Strings.Trim(Path.GetFileNameWithoutExtension(this.m_x2.c1()));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.ToolStripButtonSaveAs_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	public static bool a(fz A_0, hg A_1, Point A_2, ref string A_3)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.FileName = A_1.ci();
		string text;
		if (A_1.b5())
		{
			saveFileDialog.Filter = "Recipe Files (.fitra)|*.fitra";
			text = ".fitra";
		}
		else
		{
			saveFileDialog.Filter = "Recipe Files (.fitrp)|*.fitrp";
			text = ".fitrp";
		}
		string text2 = global::c.e().FileSystem.GetFileInfo(A_1.c1()).DirectoryName;
		if (!Directory.Exists(text2))
		{
			text2 = global::hg.bz();
			if (!Directory.Exists(text2))
			{
				Directory.CreateDirectory(text2);
			}
		}
		saveFileDialog.InitialDirectory = text2;
		if (saveFileDialog.ShowDialog() != DialogResult.OK)
		{
			return false;
		}
		if (a(A_0, Path.GetFileNameWithoutExtension(saveFileDialog.FileName), A_2))
		{
			return false;
		}
		string text3 = ((Operators.CompareString(Path.GetExtension(saveFileDialog.FileName).ToLower(), text, TextCompare: false) == 0) ? saveFileDialog.FileName : (saveFileDialog.FileName + text));
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text3);
		if (!Path.GetDirectoryName(text3).StartsWith(global::hg.bz(), StringComparison.CurrentCultureIgnoreCase))
		{
			string A_4 = "RecipeInvalidSaveDirFmt2";
			global::fe.b(A_0, string.Format(global::hu.a(ref A_4), fileNameWithoutExtension, global::hg.bz()), A_2);
			return false;
		}
		A_3 = text3;
		return true;
	}

	private void k(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				br();
				int num = global::i6.a(kj(), 0, kj().Height).Y - base.Top + base.Bottom - global::i6.a(ca(), 0, ch().Bottom).Y + 20;
				if (num < 0)
				{
					num = 0;
				}
				MinimumSize = new Size(cb().Width + py().Width + cb().Padding.Left + py().Padding.Right + ca().Padding.Left + ca().Padding.Right + base.Width - base.ClientSize.Width, num);
				base.Width = MaximumSize.Width;
				aio().AutoReset = false;
				aio().Interval = 1.0;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.DialogEditRecipe_Load", a_);
				ProjectData.ClearProjectError();
			}
			finally
			{
				this.m_y4 = true;
			}
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		try
		{
			Control control = (Control)A_0;
			control.BackColor = Color.FromKnownColor(KnownColor.HotTrack);
			if (a(control.BackColor))
			{
				control.ForeColor = Color.White;
			}
			else
			{
				control.ForeColor = Color.Black;
			}
			control = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.HighlightableControl_MouseEnter", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		try
		{
			Control obj = (Control)A_0;
			obj.BackColor = Color.Transparent;
			obj.ForeColor = Color.Black;
			_ = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.HighlightableControl_MouseLeave", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		try
		{
			fz a_ = this.m_y5;
			string A_2 = "AddNewMaterialPromptdddFmt1";
			global::fe.b(a_, string.Format(global::hu.a(ref A_2), Text), "Information", bv());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.MatMenuAddNewMaterial_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		try
		{
			ref fz a_ = ref this.m_y5;
			string A_2 = "ClearMRLQuestion";
			if (global::fe.b(ref a_, global::hu.a(ref A_2), "ClearMRL", "Yes", "No", bv()))
			{
				this.m_abf.ap();
				this.m_abf.z.Clear();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.MatMenuClearRecent_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
		{
			ContextMenuStrip contextMenuStrip = (ContextMenuStrip)((ToolStripMenuItem)A_0).Owner;
			int index = this.m_ys.IndexOf((Button)contextMenuStrip.SourceControl);
			a(this.m_yp[index]);
			i();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.MatMenuEditLayerStack_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(Control A_0, string A_1, bool A_2)
	{
		try
		{
			string a_ = ((!A_2 || global::gd.l(A_1)) ? A_1 : ("Stack: " + A_1));
			a(A_1: (A_0 != yr()) ? this.m_ys.IndexOf((Button)A_0) : (-2), A_0: global::hg.by(a_), A_2: A_2);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.MatMenuMatOrLayerStack_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			Button button = (Button)((ContextMenuStrip)((ToolStripMenuItem)A_0).Owner).SourceControl;
			int num = this.m_ys.IndexOf(button);
			string text;
			if (num < 0)
			{
				if (button == yg())
				{
					num = -1;
					text = yh().Text;
				}
				else
				{
					num = -2;
					text = yq().Text;
				}
			}
			else
			{
				text = this.m_yp[num].Text;
			}
			string a_ = ((!text.StartsWith("Generic, n=")) ? 1.5f.ToString() : text.Substring("Generic, n=".Length));
			b(num, a_);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.MatMenuEnterRefractiveIndex_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			a(this.m_ys.IndexOf((Button)((ContextMenuStrip)((ToolStripMenuItem)A_0).Owner).SourceControl), "");
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.MatMenuSearch_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, ElapsedEventArgs A_1)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new ElapsedEventHandler(a), A_0, A_1);
			}
			else if (ch() != null && ch().SelectedTab != null)
			{
				ch().SelectedTab.Refresh();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.ResizedRefreshTimer_Elapsed", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			if (ch().SelectedTab == ci())
			{
				@is().ResumeLayout(performLayout: false);
			}
			else if (this.m_abq == ci() || this.m_abq == null)
			{
				@is().SuspendLayout();
			}
			this.m_abq = ch().SelectedTab;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TabControlMain_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			if (this.m_y4)
			{
				aio().Start();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TabControlMain_Resize", a_);
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	private bool b(h.f A_0, int A_1)
	{
		bool num = this.m_zf[A_1] > 1;
		global::f f10 = this.m_x2.b8().a((int)A_0);
		if (num)
		{
			if (f10.b(this.m_aa0[A_1]) != global::f.a.a && f10.b(this.m_aa0[A_1]) != global::f.a.d)
			{
				return f10.b(this.m_aa0[A_1]) == global::f.a.c;
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	private bool a(h.f A_0)
	{
		h.e e10 = this.m_x2.b8().a(this.m_aay);
		return A_0 switch
		{
			global::h.f.a => e10 == global::h.e.a || e10 == global::h.e.b || e10 == global::h.e.f || e10 == global::h.e.e, 
			global::h.f.b => e10 == global::h.e.a || e10 == global::h.e.c || e10 == global::h.e.e || e10 == global::h.e.g, 
			global::h.f.c => e10 == global::h.e.a || e10 == global::h.e.d || e10 == global::h.e.f || e10 == global::h.e.g, 
			_ => throw new ArgumentOutOfRangeException("Invalid measTypeIdx"), 
		};
	}

	[SpecialName]
	private bool a(h.f A_0, int A_1)
	{
		global::f f10 = this.m_x2.b8().a((int)A_0);
		if (f10.b(this.m_aa0[A_1]) != global::f.a.a && f10.b(this.m_aa0[A_1]) != global::f.a.d)
		{
			return f10.b(this.m_aa0[A_1]) == global::f.a.b;
		}
		return true;
	}

	[SpecialName]
	private eo.a by()
	{
		if (this.m_aah != null)
		{
			return this.m_aah.h();
		}
		return null;
	}

	[SpecialName]
	private bool bx()
	{
		if (this.m_zf != null)
		{
			return this.m_zf.GetUpperBound(0) != 0;
		}
		return false;
	}

	[SpecialName]
	private bool bw()
	{
		if (this.m_zf[0] > 1)
		{
			if (!e2().Checked && !e0().Checked)
			{
				return ez().Checked;
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	private Point bv()
	{
		return global::i6.a(this);
	}

	[SpecialName]
	private bool bu()
	{
		if (!e2().Checked && !e1().Checked)
		{
			return ez().Checked;
		}
		return true;
	}

	[SpecialName]
	private bool bt()
	{
		return this.m_x2.ed().d5(by());
	}

	[SpecialName]
	private bool bs()
	{
		return this.m_aaf > 0;
	}

	private void a(Panel A_0, TabPage A_1, ref bool A_2)
	{
		int num = checked(A_1.ClientSize.Width - A_0.Width);
		if (!A_1.HorizontalScroll.Visible || num > 0)
		{
			int num2 = num / 2;
			if (num2 < 0)
			{
				num2 = 0;
			}
			A_0.Left = num2;
			A_2 = false;
		}
		else
		{
			if (!A_2)
			{
				A_0.Left = 0;
			}
			A_2 = true;
		}
	}

	private void g(bool A_0)
	{
		checked
		{
			try
			{
				bool flag = global::e8.a.a(this.m_aah, this.m_x2.d0());
				bp();
				if (!base.Visible || A_0)
				{
					TabControl.TabPageCollection tabPages = ch().TabPages;
					tabPages.Clear();
					bool flag2 = this.m_x2.b5() || this.m_aat || (!flag && !this.m_aan && !this.m_x2.dh().aw(by()));
					@is().ResumeLayout(performLayout: false);
					if (!flag2)
					{
						if (!this.m_aak)
						{
							tabPages.Add(ci());
						}
						if (!flag && !this.m_aak)
						{
							tabPages.Add(cj());
						}
						if (!this.m_aak)
						{
							tabPages.Add(dl());
						}
					}
					if (this.m_x2.b5() || this.m_aat || this.m_aak || this.m_aaq)
					{
						tabPages.Add(dp());
						TabControl.TabPageCollection tabPages2 = lo().TabPages;
						tabPages2.Clear();
						if (!this.m_aat && this.m_x2.b5())
						{
							tabPages2.Add(lq());
							tabPages2.Add(lp());
						}
						d(!this.m_aat && this.m_x2.b5());
						if (this.m_aaq && !this.m_aat && !this.m_aak)
						{
							tabPages2.Insert(0, agc());
						}
						if (this.m_aat || this.m_aak || this.m_x2.b5())
						{
							tabPages2.Add(o0());
						}
						tabPages2 = null;
						if (flag2 && (this.m_x2.b5() || this.m_aat))
						{
							yn().Visible = this.m_x2.dh().a2(by()) && !this.m_aat;
							if (global::e.a().ShowSpectrumColor && !lo().TabPages.Contains(dl()) && !this.m_aat)
							{
								_ = lo().Handle;
								lo().TabPages.Insert(2, dl());
							}
							if (this.m_aau != this.m_aah.a() || this.m_aav != this.m_aah.g())
							{
								if (this.m_aah.a() && this.m_aah.g())
								{
									acc().Width = this.m_aaj;
									aec().Width = aed().Width + aed().Margin.Left + aed().Margin.Right;
									aho().Width = ahp().Width + ahp().Margin.Left + ahp().Margin.Right;
								}
								else if (this.m_aah.a())
								{
									acc().Width = aai().Width;
								}
								else if (this.m_aah.g())
								{
									aec().Width = unchecked(aai().Width / 2) - aec().Margin.Left - aec().Margin.Right;
									aho().Width = aec().Width;
								}
								acc().Visible = this.m_aah.a();
								aec().Visible = this.m_aah.g();
								aho().Visible = this.m_aah.g();
								this.m_aau = this.m_aah.a();
								this.m_aav = this.m_aah.g();
							}
						}
					}
					n();
					bool flag3 = this.m_aat || this.m_aak;
					zv().Visible = flag3;
					o1().Visible = !flag3;
					if (this.m_aak)
					{
						tabPages.Add(w2());
					}
					if (this.m_x2.dh().br() && !this.m_aak)
					{
						tabPages.Add(ye());
					}
					if (this.m_zg || (this.m_aak && this.m_y9 && !this.m_aat))
					{
						if (bx())
						{
							tabPages.Add(ev());
						}
						else
						{
							tabPages.Add(d2());
						}
					}
					tabPages = null;
					if (this.m_x2.b5() && lo().TabCount > global::e.a().LastUsedSpecAnalysisTabIndex)
					{
						lo().SelectedIndex = global::e.a().LastUsedSpecAnalysisTabIndex;
					}
					bool flag4 = !this.m_aan || flag;
					if (flag4)
					{
						this.m_aal.a = true;
					}
					kk().Enabled = !flag4;
					if (flag)
					{
						this.m_aal.c = true;
					}
					k4().Enabled = !flag;
				}
				this.m_x1 = string.Empty;
				this.m_aag = string.Empty;
				p();
				if (this.m_zh != null && ch().TabPages.Contains(this.m_zh))
				{
					ch().SelectedIndex = ch().TabPages.IndexOf(this.m_zh);
				}
				else
				{
					ch().SelectedIndex = 0;
				}
			}
			finally
			{
				bq();
			}
		}
	}

	private void br()
	{
		checked
		{
			if (base.Width >= ci().Width)
			{
				TabPage selectedTab = ch().SelectedTab;
				int num = default(int);
				if (selectedTab == ci())
				{
					num = base.Width - ci().ClientSize.Width;
				}
				else if (selectedTab == cj())
				{
					num = base.Width - cj().ClientSize.Width;
				}
				else if (selectedTab == dp())
				{
					num = base.Width - dp().ClientSize.Width;
				}
				else if (selectedTab == d2())
				{
					num = base.Width - d2().ClientSize.Width;
				}
				else if (selectedTab == ev())
				{
					num = base.Width - ev().ClientSize.Width;
				}
				else if (selectedTab == qh())
				{
					num = base.Width - qh().ClientSize.Width;
				}
				else if (selectedTab == ael())
				{
					num = base.Width - ael().ClientSize.Width;
				}
				else if (selectedTab == aem())
				{
					num = base.Width - aem().ClientSize.Width;
				}
				Math.Max(ca().Width, num + 20 + aen().Width);
				int num2 = num + 20 + cn().Width;
				int num3 = num + 20 + li().Width;
				int num4 = num + 20 + ln().Width;
				int num5 = num + 20 + pw().Width;
				int num6 = num + 20 + px().Width;
				TabControl.TabPageCollection tabPages = ch().TabPages;
				int num7 = ca().Width;
				if (tabPages.Contains(ci()) && num7 < num2)
				{
					num7 = num2;
				}
				if (tabPages.Contains(cj()) && num7 < num3)
				{
					num7 = num3;
				}
				if (tabPages.Contains(dp()) && num7 < num4)
				{
					num7 = num4;
				}
				if (tabPages.Contains(d2()) && num7 < num5)
				{
					num7 = num5;
				}
				if (tabPages.Contains(ev()) && num7 < num6)
				{
					num7 = num6;
				}
				int num8 = default(int);
				if ((tabPages.Contains(qh()) || tabPages.Contains(ael()) || tabPages.Contains(aem())) && num7 < num8)
				{
					num7 = num8;
				}
				if (num7 > global::c.e().Screen.Bounds.Width)
				{
					num7 = global::c.e().Screen.Bounds.Width;
				}
				if (num7 < 0)
				{
					num7 = base.Width;
				}
				MaximumSize = new Size(num7, global::c.e().Screen.Bounds.Height);
			}
		}
	}

	private void bq()
	{
		checked
		{
			this.m_aaf--;
			if (this.m_aaf < 0)
			{
				this.m_aaf = 0;
			}
		}
	}

	private void bp()
	{
		checked
		{
			this.m_aaf++;
		}
	}

	private void b(Collection<Control> A_0)
	{
		Button button = (Button)A_0[this.m_y2.IndexOf(j6())];
		this.m_ya.Add(button);
		global::t.a(button, Resources.x, Resources.xGray, Resources.xDarkRed, this.m_y5, "DialogEditRecipe");
		this.m_yi.Add((Label)A_0[this.m_y2.IndexOf(j5())]);
		this.m_yp.Add((TextBox)A_0[this.m_y2.IndexOf(j2())]);
		this.m_ys.Add((Button)A_0[this.m_y2.IndexOf(j1())]);
		this.m_x8.Add((hy)A_0[this.m_y2.IndexOf(j8())]);
		this.m_x9.Add((hy)A_0[this.m_y2.IndexOf(j7())]);
		int index = this.m_y2.IndexOf(zl());
		Control control = A_0[index];
		this.m_yr.Add((TableLayoutPanel)control);
		int index2 = this.m_y2[index].Controls.IndexOf(zk());
		this.m_yq.Add((hy)control.Controls[index2]);
		this.m_yv.Add((CheckBox)A_0[this.m_y2.IndexOf(kb())]);
		this.m_yb.Add((hy)A_0[this.m_y2.IndexOf(kd())]);
		this.m_yc.Add((Label)A_0[this.m_y2.IndexOf(kc())]);
		this.m_yu.Add((CheckBox)A_0[this.m_y2.IndexOf(kh())]);
		this.m_yy.Add((hy)A_0[this.m_y2.IndexOf(kr())]);
		this.m_yz.Add((Label)A_0[this.m_y2.IndexOf(kq())]);
		this.m_y0.Add((hy)A_0[this.m_y2.IndexOf(kp())]);
		this.m_yw.Add((CheckBox)A_0[this.m_y2.IndexOf(km())]);
		this.m_y1.Add((ComboBox)A_0[this.m_y2.IndexOf(kv())]);
		this.m_yt.Add((hy)A_0[this.m_y2.IndexOf(kx())]);
		this.m_yx.Add((CheckBox)A_0[this.m_y2.IndexOf(kw())]);
		this.m_yh.Add(A_0);
		checked
		{
			if (A_0 != this.m_y2)
			{
				int index3 = this.m_yv.Count - 1;
				this.m_ya[index3].Click += hh;
				this.m_x8[index3].TextChanged += gl;
				this.m_x8[index3].Validated += go;
				this.m_x9[index3].TextChanged += gm;
				this.m_x9[index3].Validated += go;
				this.m_yq[index3].Validating += b;
				this.m_ys[index3].Click += hg;
				this.m_yp[index3].Click += gn;
				this.m_yv[index3].CheckedChanged += hc;
				this.m_yb[index3].TextChanged += gk;
				this.m_yb[index3].Validating += a;
				this.m_yb[index3].Validated += go;
				this.m_yu[index3].CheckedChanged += hd;
				this.m_yy[index3].TextChanged += ga;
				this.m_yy[index3].Validated += f9;
				this.m_y0[index3].TextChanged += f8;
				this.m_y0[index3].Validated += f7;
				this.m_yw[index3].CheckedChanged += g6;
				this.m_y1[index3].SelectedIndexChanged += f6;
				this.m_y1[index3].Validated += go;
				this.m_yt[index3].TextChanged += ge;
				this.m_yt[index3].Validated += gb;
				this.m_yx[index3].CheckedChanged += g3;
			}
			int index4 = this.m_ya.Count - 1;
			Collection<Control> collection = new Collection<Control>();
			collection.Add(this.m_x8[index4]);
			collection.Add(this.m_x9[index4]);
			collection.Add(this.m_yv[index4]);
			collection.Add(this.m_yb[index4]);
			collection.Add(this.m_yc[index4]);
			collection.Add(this.m_yu[index4]);
			this.m_yf.Add(collection);
			collection = new Collection<Control>();
			collection.Add(this.m_yz[index4]);
			collection.Add(this.m_y0[index4]);
			collection.Add(this.m_y1[index4]);
			this.m_yn.Add(collection);
			collection = new Collection<Control>();
			collection.Add(this.m_yt[index4]);
			collection.Add(this.m_yx[index4]);
			this.m_yk.Add(collection);
		}
	}

	private void a(int A_0, ref Collection<Control> A_1)
	{
		A_1 = new Collection<Control>();
		gc gc2 = this.m_x2.ed().et(A_0);
		bool flag = global::gd.l(gc2.ag());
		bool flag2 = Operators.CompareString(gc2.ag(), "<Roughness>", TextCompare: false) == 0;
		if (!flag2 && Operators.CompareString(gc2.ag(), "<Graded Interface>", TextCompare: false) != 0 && !flag)
		{
			if (!this.m_aan)
			{
				A_1.Add(this.m_yx[A_0]);
			}
			A_1.Add(this.m_yr[A_0]);
			@is().SetColumnSpan(this.m_yr[A_0], 1);
			return;
		}
		gc2 = null;
		A_1.Add(this.m_x8[A_0]);
		A_1.Add(this.m_x9[A_0]);
		A_1.Add(this.m_yv[A_0]);
		A_1.Add(this.m_yb[A_0]);
		A_1.Add(this.m_yc[A_0]);
		A_1.Add(this.m_yu[A_0]);
		A_1.Add(this.m_y1[A_0]);
		A_1.Add(this.m_yt[A_0]);
		A_1.Add(this.m_yx[A_0]);
		A_1.Add(this.m_yz[A_0]);
		A_1.Add(this.m_y0[A_0]);
		if (flag)
		{
			A_1.Add(this.m_yy[A_0]);
			A_1.Add(this.m_yw[A_0]);
			@is().SetColumnSpan(this.m_yr[A_0], checked(@is().ColumnCount - @is().GetColumn(this.m_yr[A_0])));
			return;
		}
		if (flag2)
		{
			if (!this.m_aam)
			{
				A_1.Add(this.m_yw[A_0]);
			}
		}
		else if (!this.m_aan)
		{
			A_1.Add(this.m_yw[A_0]);
		}
		A_1.Add(this.m_yr[A_0]);
		@is().SetColumnSpan(this.m_yr[A_0], 1);
	}

	private void bo()
	{
		cp().Enabled = lh().Checked || (la().Checked && !lg().Checked);
	}

	private void a(int A_0, Collection<Control> A_1)
	{
		Collection<Control> A_2 = null;
		a(A_0, ref A_2);
		foreach (Control item in A_1)
		{
			item.Visible = a(A_0, item, A_2);
		}
	}

	private void a(CheckBox A_0)
	{
		CheckBox checkBox = A_0;
		int num = this.m_yv.IndexOf(A_0);
		gc gc2 = this.m_x2.ed().et(num);
		string text = ((num != 0) ? "Measure NK" : "Measure N");
		try
		{
			text = text + " using " + gc2.af(this.m_ze, this.m_x2.dh(), by()) + " Model";
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_y5.c(global::fz.b.a, "Invalid nk model (" + gc2.au() + ") in DialogEditRecipe.UpdateFilmStackNKCheckboxTooltip. Typically this means that the model is no longer available.");
			ProjectData.ClearProjectError();
		}
		if (checkBox.Checked)
		{
			checkBox.ContextMenuStrip = k6();
			text += "\r\n(Right-click to change Model)";
		}
		else
		{
			checkBox.ContextMenuStrip = null;
		}
		aee().SetToolTip(A_0, text);
		checkBox = null;
	}

	private void bn()
	{
		ku().Visible = this.m_ym.i() == global::bx.a.a && !global::e8.a.a(this.m_aah, this.m_x2.d0());
	}

	private void bm()
	{
		string text = "";
		text = global::h4.e(this.m_x2.ca(), A_1: true);
		global::h4.f(cm());
		h4 h10 = this.m_x2.ca();
		string text2 = global::h4.e(new h4(global::h4.a.i, h10.f(), h10.g(), h10.h()), A_1: true);
		checked
		{
			if (Operators.CompareString(cm().Items[cm().Items.Count - 1].ToString(), text2, TextCompare: false) != 0)
			{
				cm().Items.RemoveAt(cm().Items.Count - 1);
				cm().Items.Add(text2);
				cm().SelectedIndex = cm().Items.Count - 1;
				global::h4.e(cm());
			}
			h10 = null;
			cm().SelectedIndex = cm().FindString(text);
			if (text.Contains("Custom: "))
			{
				zh().Visible = true;
			}
			else
			{
				zh().Visible = false;
			}
		}
	}

	private void f(bool A_0)
	{
		checked
		{
			try
			{
				bp();
				this.m_x2.ed();
				bool flag = global::e8.a.a(this.m_aah, this.m_x2.d0());
				bm();
				int num = this.m_x2.b4(0) + 2;
				int num2 = num - 1;
				bn();
				k0().Visible = !flag;
				k4().Visible = !flag;
				k5().Visible = !flag;
				wd().Visible = flag;
				@is().SuspendLayout();
				int num3 = @is().RowCount - 4 - 1;
				int num4 = 2 * num;
				if (num3 < num4)
				{
					@is().RowCount = num4 + 4 + 1;
					int num5 = num3 + 1;
					int num6 = num4;
					for (int num7 = num5; num7 <= num6; num7++)
					{
						@is().RowStyles.Add(new RowStyle());
					}
					int num8 = unchecked(num3 / 2);
					int num9 = num2;
					for (int num10 = num8; num10 <= num9; num10++)
					{
						Collection<Control> a_ = global::iz.a(this.m_y2, @is(), 4 + 2 * num10, aee());
						b(a_);
						Button button = global::iz.a(it());
						this.m_yd.Add(button);
						aee().SetToolTip(button, aee().GetToolTip(it()));
						global::t.a(button, Resources.Insert, Resources.InsertDisabled, Resources.InsertDarkGreen, this.m_y5, "DialogEditRecipe");
						button.Click += hf;
						@is().Controls.Add(button, 0, 4 + 2 * num10 + 1);
						@is().SetRowSpan(button, 2);
					}
				}
				int num11 = this.m_ya.Count - 1;
				bool enabled = num > 2;
				Collection<Control> A_1 = null;
				int num12 = num11;
				for (int num13 = 0; num13 <= num12; num13++)
				{
					bool flag2 = num13 < num;
					if (flag2)
					{
						a(num13, ref A_1);
					}
					foreach (Control item in this.m_yh[num13])
					{
						item.Visible = flag2 && a(num13, item, A_1);
					}
					this.m_yd[num13 + 1].Visible = flag2;
					if (flag2)
					{
						int num14 = num13;
						string text;
						if (num14 == 0)
						{
							string A_2 = "Medium";
							text = global::hu.a(ref A_2);
						}
						else if (num14 == num2)
						{
							string A_2 = "Substrate";
							text = global::hu.a(ref A_2);
						}
						else
						{
							text = num13.ToString();
						}
						this.m_yi[num13].Text = text;
						this.m_ya[num13].Enabled = enabled;
					}
				}
				ks().Text = "Nominal (" + global::h4.e(this.m_x2.ca(), false, false) + ")";
				bk();
				bl();
				bj();
				hi hi2 = this.m_x2.ed();
				int num15 = num2;
				for (int num16 = 0; num16 <= num15; num16++)
				{
					bool flag3 = !g(num16);
					gc gc2 = hi2.et(num16);
					this.m_yp[num16].Enabled = flag3;
					this.m_yp[num16].Text = global::hg.bz(gc2.ag());
					l(num16);
					this.m_yv[num16].Enabled = flag3 && this.m_aam;
					this.m_yv[num16].Checked = gc2.ah(this.m_aam) || gc2.aj(this.m_aam);
					a(this.m_yv[num16]);
					this.m_yb[num16].Enabled = flag3;
					this.m_yb[num16].Text = global::i6.a(100.0 * gc2.ak(), "0.0");
					this.m_yu[num16].Enabled = flag3 && this.m_aam;
					this.m_yu[num16].Checked = gc2.an(this.m_aam);
					this.m_yy[num16].Enabled = flag3;
					this.m_yy[num16].Text = global::hg.bu(1, gc2.ai(), this.m_x2.ca());
					e(num16);
					this.m_yw[num16].Enabled = flag3;
					this.m_yw[num16].Checked = gc2.af(this.m_aao);
					d(num16);
					this.m_yx[num16].Enabled = flag3;
					this.m_yx[num16].Checked = gc2.ap(this.m_aan);
					f(num16);
					this.m_ys[num16].Enabled = flag3;
					this.m_yq[num16].Text = gc2.ah().ToString();
					i(num16);
					gc2 = null;
				}
				hi2 = null;
				i();
				if (A_0)
				{
					@is().ResumeLayout();
					return;
				}
				@is().ResumeLayout(performLayout: false);
				@is().LayoutEngine.Layout(@is().Parent, new LayoutEventArgs(null, string.Empty));
			}
			finally
			{
				bq();
			}
		}
	}

	private void l(int A_0)
	{
		try
		{
			bp();
			gc gc2 = this.m_x2.ed().et(A_0);
			int num;
			int num2;
			if (!gc2.ah(this.m_aam))
			{
				num = (gc2.aj(this.m_aam) ? 1 : 0);
				if (num == 0)
				{
					num2 = 0;
					goto IL_0045;
				}
			}
			else
			{
				num = 1;
			}
			num2 = ((!g(A_0)) ? 1 : 0);
			goto IL_0045;
			IL_0045:
			bool flag = (byte)num2 != 0;
			bool num3 = this.m_x8[A_0].Enabled && !flag;
			this.m_x8[A_0].Enabled = flag;
			this.m_x9[A_0].Enabled = flag && A_0 > 0;
			if (num3)
			{
				@is().SuspendLayout();
				this.m_x8[A_0].BorderStyle = BorderStyle.None;
				this.m_x9[A_0].BorderStyle = BorderStyle.None;
				this.m_x8[A_0].BorderStyle = BorderStyle.Fixed3D;
				this.m_x9[A_0].BorderStyle = BorderStyle.Fixed3D;
				@is().ResumeLayout();
			}
			if (num != 0)
			{
				if (gc2.ah(this.m_aam))
				{
					this.m_x8[A_0].Text = gc2.aw().ToString();
				}
				else
				{
					this.m_x8[A_0].Text = 0.ToString();
				}
				if (gc2.aj(this.m_aam) && A_0 > 0)
				{
					this.m_x9[A_0].Text = gc2.ax().ToString();
				}
				else
				{
					this.m_x9[A_0].Text = 0.ToString();
				}
			}
			else
			{
				this.m_x8[A_0].Text = string.Empty;
				this.m_x9[A_0].Text = string.Empty;
			}
			gc2 = null;
		}
		finally
		{
			bq();
		}
	}

	private void k(int A_0)
	{
		try
		{
			bp();
			gc gc2 = this.m_x2.bu(A_0, 0);
			this.m_yt[A_0].Enabled = !g(A_0);
			if (this.m_x2.cp())
			{
				this.m_yt[A_0].Text = global::hg.bu(2, 100.0 * gc2.aj(), null);
			}
			else if (gc2.ai() == 0.0)
			{
				this.m_yt[A_0].Text = global::hg.bu(1, gc2.aj(), this.m_x2.ca());
			}
			else
			{
				this.m_yt[A_0].Text = global::hg.bu(1, gc2.aj() * gc2.ai(), this.m_x2.ca());
			}
			f(A_0);
			gc2 = null;
		}
		finally
		{
			bq();
		}
	}

	private void bl()
	{
		this.m_x2.ed();
		checked
		{
			int num = this.m_x2.b4(0) + 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				k(num2);
			}
			_ = null;
			string right = ((!this.m_x2.cp()) ? ("(" + global::h4.e(this.m_x2.ca(), false, false) + ")") : "(%)");
			if (Operators.CompareString(kz().Text, right, TextCompare: false) != 0)
			{
				kz().Text = right;
			}
		}
	}

	private void j(int A_0)
	{
		try
		{
			bp();
			gc gc2 = this.m_x2.bu(A_0, 0);
			if (this.m_y0[A_0].Enabled && !gc2.af(this.m_aao))
			{
				@is().SuspendLayout();
				this.m_y0[A_0].BorderStyle = BorderStyle.None;
				this.m_y0[A_0].BorderStyle = BorderStyle.Fixed3D;
				@is().ResumeLayout();
			}
			if (gc2.af(this.m_aao))
			{
				if (this.m_x2.co())
				{
					double a_ = ((gc2.ai() != 0.0) ? (gc2.ai() * 0.01 * gc2.av()) : gc2.av());
					this.m_y0[A_0].Text = global::hg.bu(1, a_, this.m_x2.ca());
				}
				else
				{
					this.m_y0[A_0].Text = global::hg.bu(2, gc2.av(), null);
				}
			}
			else
			{
				this.m_y0[A_0].Text = 0.ToString();
			}
			e(A_0);
			this.m_y0[A_0].Enabled = !g(A_0) && gc2.af(this.m_aao);
			gc2 = null;
		}
		finally
		{
			bq();
		}
	}

	private void bk()
	{
		this.m_x2.ed();
		checked
		{
			int num = this.m_x2.b4(0) + 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				j(num2);
			}
			_ = null;
			string right = ((!this.m_x2.co()) ? "(%)" : ("(" + global::h4.e(this.m_x2.ca(), false, false) + ")"));
			if (Operators.CompareString(kn().Text, right, TextCompare: false) != 0)
			{
				kn().Text = right;
			}
		}
	}

	private void bj()
	{
		try
		{
			bp();
			hi hi2 = this.m_x2.ed();
			bool flag = (hi2.gz() || hi2.d7(by())) && hi2.d8(by());
			int num = kv().Items.IndexOf("None");
			int selectedIndex = ((!flag && hi2.gx()) ? kv().Items.IndexOf("Grid") : ((flag || !hi2.gw()) ? num : kv().Items.IndexOf("FFT")));
			int num2 = hi2.g6();
			for (int num3 = 1; num3 <= num2; num3 = checked(num3 + 1))
			{
				gc gc2 = hi2.et(num3);
				this.m_y1[num3].Enabled = !g(num3) && !flag && gc2.af(this.m_aao);
				if (gc2.af(this.m_aao))
				{
					this.m_y1[num3].SelectedIndex = selectedIndex;
				}
				else
				{
					this.m_y1[num3].SelectedIndex = num;
				}
				gc2 = null;
			}
			hi2 = null;
		}
		finally
		{
			bq();
		}
	}

	private void a(string A_0, int A_1, bool A_2 = false)
	{
		string A_3 = string.Empty;
		checked
		{
			if (A_1 >= 0)
			{
				string text = null;
				hi hi2 = this.m_x2.ed();
				gc gc2 = hi2.et(A_1);
				bool flag = global::gd.l(gc2.ag()) != A_2 || A_2;
				gc2.af(A_0);
				if (A_1 == hi2.g6() + 1)
				{
					this.m_x2.eg();
					if (A_2)
					{
						this.m_x2.b8(A_0: false);
					}
					an();
				}
				bool flag2 = Operators.CompareString(A_0, "<Graded Interface>", TextCompare: false) != 0 && Operators.CompareString(A_0, "<Roughness>", TextCompare: false) != 0;
				A_3 = string.Empty;
				if (!A_2)
				{
					gc2.af(1);
					int num = default(int);
					if (flag2)
					{
						hd a_ = this.m_ze;
						eo a_2 = this.m_x2.dh();
						eo.a a_3 = by();
						string A_4 = null;
						string A_5 = null;
						bool A_6 = default(bool);
						num = global::jb.a(A_0, a_, a_2, a_3, ref A_3, ref A_4, ref A_5, ref A_6);
						if (num < 0)
						{
							A_5 = "ErrMatFileCorruptFmt";
							A_3 = string.Format(global::hu.a(ref A_5), A_0);
						}
						if (!string.IsNullOrEmpty(A_3))
						{
							global::cv.a(this.m_y5, A_3, this.m_ys[A_1]);
							return;
						}
						gc2.ag(this.m_ze.j(num, this.m_x2.dh(), by()));
						a(this.m_yv[A_1]);
					}
					if (num >= 0)
					{
						this.m_yp[A_1].Text = global::hg.bz(A_0);
						this.m_y7.m2(ref this.m_abf.z, this.m_y6, global::gr.f.a);
						this.m_y7.m2(ref this.m_abf.z, A_0, global::gr.f.a);
					}
					if (hi2.d5(this.m_x2.dh().aw(by()), by()))
					{
						a(A_0: true);
					}
				}
				else
				{
					this.m_yp[A_1].Text = A_0;
					bool flag3 = A_1 == this.m_x2.b4(0) + 1;
					this.m_y7.m2(ref this.m_abf.z, this.m_y6, global::gr.f.a, flag3);
					this.m_y7.m2(ref this.m_abf.z, A_0, global::gr.f.a, flag3);
					text = a(A_0, flag3);
					gd gd2 = new gd();
					gd2.n(text);
					this.m_yq[A_1].Text = this.m_x2.bu(A_1, 0).ah().ToString();
					int num2 = gd2.l().Count - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						if (global::jb.y(gd2.l()[num3].ag()))
						{
							string a_4 = gd2.l()[num3].ag();
							hd a_5 = this.m_ze;
							eo a_6 = this.m_x2.dh();
							eo.a a_7 = by();
							string A_5 = null;
							string A_4 = null;
							bool A_7 = false;
							int num = global::jb.a(a_4, a_5, a_6, a_7, ref A_3, ref A_5, ref A_4, ref A_7);
							if (num < 0)
							{
								A_3 = "A material file referenced in the layer stack is corrupted or missing";
								break;
							}
						}
					}
				}
				try
				{
					bool flag4 = true;
					@is().SuspendLayout();
					a(A_1, this.m_yh[A_1]);
					if (A_2)
					{
						flag4 = !hi2.hq();
					}
					if (flag4 && flag)
					{
						i();
					}
				}
				finally
				{
					@is().ResumeLayout();
				}
				bd();
				hi2 = null;
				i(A_1);
			}
			else
			{
				switch (A_1)
				{
				case -1:
					this.m_x2.cf(A_0);
					yh().Text = global::hg.bz(A_0);
					break;
				case -2:
					this.m_x2.ed().d6(A_0);
					yq().Text = global::hg.bz(A_0);
					break;
				}
				this.m_y7.m2(ref this.m_abf.z, this.m_y6, global::gr.f.a);
				this.m_y7.m2(ref this.m_abf.z, A_0, global::gr.f.a);
			}
			o();
			if (!string.IsNullOrEmpty(A_3))
			{
				global::cv.a(this.m_y5, A_3, this.m_ys[A_1]);
			}
		}
	}

	private void i(int A_0)
	{
		string text = this.m_yp[A_0].Text;
		string caption;
		if (Operators.CompareString(text, "<Graded Interface>", TextCompare: false) == 0 || Operators.CompareString(text, "<Roughness>", TextCompare: false) == 0)
		{
			caption = null;
		}
		else if (global::gd.l(text))
		{
			string A_1 = "LayerMatLayerStackToolTip";
			caption = global::hu.a(ref A_1);
		}
		else if (text.StartsWith("Generic, n="))
		{
			string A_1 = "LayerMatGenericIndexToolTip";
			caption = global::hu.a(ref A_1);
		}
		else
		{
			string A_1 = "LayerMatStandardLayerToolTip";
			caption = global::hu.a(ref A_1);
		}
		aee().SetToolTip(this.m_yp[A_0], caption);
	}

	private void bi()
	{
		bool flag = la().Checked && lc().Checked;
		dk().Enabled = flag;
		dj().Enabled = flag;
		cw().Enabled = flag;
		ir().Enabled = flag;
		Color foreColor = ((!flag) ? Color.FromKnownColor(KnownColor.InactiveCaptionText) : Color.Black);
		lf().ForeColor = foreColor;
		le().ForeColor = foreColor;
	}

	private void bh()
	{
		bool enabled = this.m_x2.ed().ft();
		de().Enabled = enabled;
		dd().Enabled = enabled;
	}

	private void bg()
	{
		bool enabled = la().Checked && la().Enabled;
		lc().Enabled = enabled;
		lg().Enabled = enabled;
		bi();
	}

	private bool b(hi A_0)
	{
		int num = 0;
		checked
		{
			int num2 = A_0.gm() - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (A_0.eq(num3) || A_0.ep(num3))
				{
					num++;
				}
				if (A_0.eq(num3) && A_0.ep(num3))
				{
					num++;
				}
			}
			return num > 1;
		}
	}

	private void bf()
	{
		this.m_x2.ed();
		if (bt() && (b(this.m_x2.ed()) || ve().Checked))
		{
			if (ve().Checked)
			{
				ve().Checked = false;
			}
			if (b(this.m_x2.ed()))
			{
				vf().Checked = false;
			}
			if (!vd().Checked && !vf().Checked)
			{
				vd().Checked = true;
			}
		}
		_ = null;
		be();
	}

	private void a(hi A_0)
	{
		hi hi2 = A_0;
		vf().Checked = hi2.ep(0) && (!hi2.d5(by()) || !hi2.eq(0));
		vd().Checked = hi2.eq(0);
		ve().Checked = hi2.gm() > 1 && hi2.eq(1);
		hi2 = null;
	}

	private void be()
	{
		vj().Enabled = !bt();
		ve().Enabled = !bt();
		if (!bt() || !ve().Checked)
		{
			return;
		}
		try
		{
			bp();
			ve().Checked = false;
			this.m_x2.ed().d9(1, A_1: false);
			if (!this.m_x2.ed().eq(0) && !this.m_x2.ed().ep(0))
			{
				this.m_x2.ed().d9(0, A_1: true);
				vd().Checked = true;
			}
			o();
		}
		finally
		{
			bq();
		}
	}

	private void bd()
	{
		hi hi2 = this.m_x2.ed();
		try
		{
			bp();
			bool flag = hi2.d8(by());
			bool flag2 = this.m_x2.dh().aw(by());
			k9().Visible = !flag2;
			if (!flag2)
			{
				lh().Enabled = flag;
				la().Enabled = flag;
				if (flag)
				{
					la().Checked = hi2.d6(by()) || !hi2.d7(by());
					lh().Checked = !la().Checked;
					lg().Checked = hi2.gz();
					lc().Checked = !lg().Checked;
				}
				else
				{
					la().Checked = true;
					lc().Checked = true;
				}
				dk().Checked = hi2.gu();
				dj().Checked = hi2.gv();
				ir().Checked = hi2.hf();
				cw().Checked = hi2.hf();
				bg();
			}
			cu().Visible = !flag2;
			a(this.m_x2.ed());
			be();
			db().Checked = hi2.fu();
			da().Checked = hi2.ft();
			bh();
			de().Text = global::i6.a(hi2.fs(), "#.000");
			dd().Text = global::i6.a(hi2.fr(), "#.000");
			cs().Text = global::hg.bu(1, this.m_x2.dx(), new h4(global::h4.a.c));
			cr().Text = global::h4.e(new h4(global::h4.a.c), false, false);
		}
		finally
		{
			bq();
		}
		hi2 = null;
	}

	private void a(Collection<Control> A_0)
	{
		this.m_xu.Add((Label)A_0[this.m_xt.IndexOf(ep())]);
		this.m_xv.Add((Label)A_0[this.m_xt.IndexOf(eh())]);
		this.m_xw.Add((hy)A_0[this.m_xt.IndexOf(ef())]);
		this.m_xx.Add((hy)A_0[this.m_xt.IndexOf(d6())]);
		this.m_xs.Add(A_0);
		if (A_0 != this.m_xt)
		{
			int index = checked(this.m_xu.Count - 1);
			this.m_xx[index].TextChanged += ew;
			this.m_xx[index].Validated += eh;
			this.m_xw[index].TextChanged += ev;
			this.m_xw[index].Validated += eh;
		}
	}

	private void h(int A_0)
	{
		try
		{
			bp();
			hi obj = this.m_x2.ed();
			bool flag = obj.g5();
			gc gc2 = obj.et(A_0);
			bool num = gc2.af(this.m_aao);
			bool enabled = num && flag && !g(A_0);
			if (num)
			{
				this.m_xw[A_0].Text = global::hg.bu(1, gc2.al(), this.m_x2.ca());
				this.m_xx[A_0].Text = global::hg.bu(1, gc2.am(), this.m_x2.ca());
			}
			else
			{
				this.m_xw[A_0].Text = null;
				this.m_xx[A_0].Text = null;
			}
			this.m_xv[A_0].Text = global::hg.bu(1, gc2.ai(), this.m_x2.ca());
			this.m_xw[A_0].Enabled = enabled;
			this.m_xx[A_0].Enabled = enabled;
			gc2 = null;
			_ = null;
		}
		finally
		{
			bq();
		}
	}

	private void a3()
	{
		hi hi2 = this.m_x2.ed();
		try
		{
			bp();
			try
			{
				ll().SuspendLayout();
				foreach (Control control in ll().Controls)
				{
					control.Visible = !this.m_x2.b5();
				}
				checked
				{
					if (!this.m_x2.b5())
					{
						int num = this.m_x2.b4(0) + 2;
						int num2 = num - 1;
						int row = ll().GetRow(this.m_xu[0]);
						int num3 = ll().RowCount - row;
						int num4 = num;
						if (num3 < num4)
						{
							ll().RowCount = num4 + row;
							int num5 = num3 + 1;
							int num6 = num4;
							for (int num7 = num5; num7 <= num6; num7++)
							{
								ll().RowStyles.Add(new RowStyle());
							}
							int num8 = num2;
							for (int num9 = num3; num9 <= num8; num9++)
							{
								Collection<Control> a_ = global::iz.a(this.m_xt, ll(), row + num9, aee());
								a(a_);
							}
						}
						int num10 = this.m_xu.Count - 1;
						for (int num11 = 0; num11 <= num10; num11++)
						{
							bool flag = num11 < num;
							foreach (Control item in this.m_xs[num11])
							{
								item.Visible = flag && a(num11, item);
							}
							if (flag)
							{
								int num12 = num11;
								string text;
								if (num12 == 0)
								{
									string A_ = "Medium";
									text = global::hu.a(ref A_);
								}
								else if (num12 == num2)
								{
									string A_ = "Substrate";
									text = global::hu.a(ref A_);
								}
								else
								{
									text = num11.ToString();
								}
								this.m_xu[num11].Text = text;
								h(num11);
							}
						}
						lm().Text = "Thickness Limits (" + global::h4.e(this.m_x2.ca(), false, false) + ")";
						pm().Text = hi2.gq().ToString();
						ah0().Text = hi2.gr().ToString();
						eu().Checked = this.m_x2.ed().g5();
					}
				}
				if (global::e.a().ShowSpectrumColor)
				{
					ll().RowStyles.Add(new RowStyle());
					ll().Controls.Add(vu(), 1, ll().RowCount);
					ll().SetColumnSpan(vu(), ll().ColumnCount);
					vu().Visible = !global::e8.a.a(this.m_aah, this.m_x2.d0());
					global::hg.bu((a4.a)global::e.a().ShowSpectrumCoordOption, v4(), v5(), v6());
					hi hi3 = this.m_x2.ed();
					vv().Checked = hi3.d5((a4.a)global::e.a().ShowSpectrumCoordOption);
					vy().Enabled = vv().Checked;
					vz().Enabled = vv().Checked;
					v0().Enabled = vv().Checked;
					v1().Enabled = vv().Checked;
					v2().Enabled = vv().Checked;
					v3().Enabled = vv().Checked;
					if (vv().Checked)
					{
						vy().Text = global::i6.a(hi3.em(), "0.00");
						vz().Text = global::i6.a(hi3.en(), "0.00");
						v0().Text = global::i6.a(hi3.eo(), "0.00");
						v1().Text = global::i6.a(hi3.ep(), "0.00");
						v2().Text = global::i6.a(hi3.eq(), "0.00");
						v3().Text = global::i6.a(hi3.er(), "0.00");
					}
					else
					{
						vy().Text = string.Empty;
						vz().Text = string.Empty;
						v0().Text = string.Empty;
						v1().Text = string.Empty;
						v2().Text = string.Empty;
						v3().Text = string.Empty;
					}
					hi3 = null;
				}
				else
				{
					vu().Visible = false;
				}
			}
			finally
			{
				ll().ResumeLayout();
			}
		}
		finally
		{
			bq();
		}
		hi2 = null;
	}

	private void a2()
	{
		bool flag = agq().Checked;
		agr().Enabled = flag;
		agl().Enabled = flag;
		agi().Enabled = flag;
		agh().Enabled = flag;
		agv().Enabled = !flag;
		agt().Enabled = !flag;
	}

	private void a1()
	{
		bool num = this.m_aat || this.m_aak;
		o8().Text = Path.GetFileNameWithoutExtension(this.m_x2.ed().e2());
		if (!num)
		{
			ar();
			aq();
			ao();
			o4().Text = global::hg.bu(1, this.m_x2.dx(), new h4(global::h4.a.c));
			o3().Text = global::h4.e(new h4(global::h4.a.c), false, false);
		}
		else
		{
			zz().Text = global::hg.bv(this.m_x2.dy()).ToString();
			zw().Text = this.m_x2.dy().ToString();
		}
	}

	private void ar()
	{
		bool flag = Conversions.ToBoolean(global::e.a().GraphMeasYLabelPercent[0]);
		if (flag)
		{
			aaf().Text = "Min R(%)";
			aad().Text = "Max R(%)";
		}
		else
		{
			aaf().Text = "Min R";
			aad().Text = "Max R";
		}
		try
		{
			bp();
			hi hi2 = this.m_x2.ed();
			z6().Checked = hi2.ex();
			z5().Checked = hi2.ey();
			ace().Checked = hi2.ez();
			aed().Checked = hi2.e0();
			ahp().Checked = hi2.e1();
			int num = 0;
			do
			{
				bool visible;
				if (num < hi2.e3())
				{
					visible = true;
					this.m_aac[num].Text = hi2.d5(num).ToString();
					this.m_aaa[num].Text = hi2.d6(num).ToString();
					if (flag)
					{
						this.m_zy[num].Text = Strings.Format(hi2.d7(num) * 100.0, "0.##");
						this.m_zw[num].Text = Strings.Format(hi2.d8(num) * 100.0, "0.##");
					}
					else
					{
						this.m_zy[num].Text = Strings.Format(hi2.d7(num), "0.####");
						this.m_zw[num].Text = Strings.Format(hi2.d8(num), "0.####");
					}
					this.m_zq[num].Checked = hi2.d9(num);
					switch (hi2.ea(num))
					{
					case global::hi.e.a:
						this.m_z1[num].Checked = true;
						break;
					case global::hi.e.b:
						this.m_z2[num].Checked = true;
						break;
					case global::hi.e.c:
						this.m_z3[num].Checked = true;
						break;
					}
				}
				else
				{
					visible = false;
				}
				this.m_zt[num].Visible = visible;
				bool flag2 = hi2.e3() < 12;
				Button button = this.m_zl[num];
				button.Visible = visible;
				if (button.Enabled != flag2)
				{
					button.Enabled = flag2;
				}
				button = null;
				num = checked(num + 1);
			}
			while (num <= 11);
			if (hi2.e3() == 0)
			{
				this.m_zl[0].Visible = true;
			}
			else if (hi2.e3() != 12)
			{
				this.m_zl[hi2.e3()].Visible = true;
			}
			hi2 = null;
		}
		finally
		{
			bq();
		}
	}

	private void aq()
	{
		try
		{
			bp();
			bool flag = Conversions.ToBoolean(global::e.a().GraphMeasYLabelPercent[0]);
			if (flag)
			{
				lz().Text = "Min R(%)";
				ly().Text = "Max R(%)";
			}
			else
			{
				lz().Text = "Min R";
				ly().Text = "Max R";
			}
			hi hi2 = this.m_x2.ed();
			int num = 0;
			do
			{
				bool visible;
				if (num < hi2.e9())
				{
					visible = true;
					this.m_aad[num].Text = hi2.ec(num).ToString();
					this.m_aab[num].Text = hi2.ed(num).ToString();
					if (flag)
					{
						this.m_zz[num].Text = Strings.Format(hi2.ee(num) * 100.0, "0.##");
						this.m_zx[num].Text = Strings.Format(hi2.ef(num) * 100.0, "0.##");
					}
					else
					{
						this.m_zz[num].Text = Strings.Format(hi2.ee(num), "0.####");
						this.m_zx[num].Text = Strings.Format(hi2.ef(num), "0.####");
					}
					if (hi2.eg(num) == global::hi.b.a)
					{
						this.m_z8[num].Checked = true;
					}
					else
					{
						this.m_z7[num].Checked = true;
					}
					this.m_zp[num].Checked = hi2.eh(num);
					this.m_zr[num].Checked = hi2.ei(num);
					this.m_zs[num].Checked = hi2.el(num);
					switch (hi2.ej(num))
					{
					case global::hi.e.a:
						this.m_z4[num].Checked = true;
						break;
					case global::hi.e.b:
						this.m_z5[num].Checked = true;
						break;
					case global::hi.e.c:
						this.m_z6[num].Checked = true;
						break;
					}
				}
				else
				{
					visible = false;
				}
				this.m_zu[num].Visible = visible;
				bool flag2 = hi2.e9() < 6;
				Button button = this.m_zm[num];
				button.Visible = visible;
				if (button.Enabled != flag2)
				{
					button.Enabled = flag2;
				}
				button = null;
				num = checked(num + 1);
			}
			while (num <= 5);
			if (hi2.e9() == 0)
			{
				this.m_zm[0].Visible = true;
			}
			else if (hi2.e9() != 6)
			{
				this.m_zm[hi2.e9()].Visible = true;
			}
			yp().Checked = hi2.au(by());
			yq().Text = hi2.ew();
			hi2 = null;
		}
		finally
		{
			bq();
		}
	}

	private void ao()
	{
		hi hi2 = this.m_x2.ed();
		age().Checked = hi2.c9 != null && hi2.c9.a(this.m_x2.dh(), by());
		agw().Checked = hi2.ea();
		agq().Checked = !hi2.ea();
		agr().Text = hi2.eb().ToString();
		agl().Text = hi2.ec().ToString();
		agh().Checked = hi2.ed();
		agi().Checked = !hi2.ed();
		agv().Text = hi2.ee().ToString();
		agt().Text = hi2.ef().ToString();
		agd().Checked = hi2.d5(this.m_x2.dh(), by());
		ag5().Text = hi2.eh().ToString();
		ag7().Checked = hi2.ei();
		ag8().Checked = !hi2.ei();
		hi2 = null;
	}

	private void an()
	{
		try
		{
			bp();
			yj().Checked = this.m_x2.d3();
			b0();
			yh().Text = global::hg.bz(this.m_x2.d4());
		}
		finally
		{
			bq();
		}
	}

	private void am()
	{
		if (this.m_zf == null)
		{
			return;
		}
		if (this.m_zf[0] <= 0)
		{
			e3().Enabled = false;
			g6().Enabled = false;
		}
		else if (bx())
		{
			g6().Enabled = true;
			a(hd(), hk(), hc(), he(), hq(), hu());
			int num = this.m_x6.m2(this.m_xr, global::h.f.a);
			if (num >= 0)
			{
				a(this.m_zf[num], h9(), h8(), id(), ib());
				a(gs(), gp(), go(), gn(), ie(), id(), ic(), ib(), num);
			}
			num = this.m_x6.m2(this.m_xr, global::h.f.b);
			if (num >= 0)
			{
				a(this.m_zf[num], ii(), ih(), @in(), il());
				if (gk().Checked)
				{
					io().Enabled = ie().Enabled;
					@in().Enabled = id().Enabled;
					im().Enabled = ic().Enabled;
					il().Enabled = ib().Enabled;
				}
				else
				{
					a(g2(), g1(), g0(), gz(), io(), @in(), im(), il(), num);
				}
			}
			num = this.m_x6.m2(this.m_xr, global::h.f.c);
			if (num >= 0)
			{
				a(this.m_zf[num], ue(), ub(), uw(), uu());
				if (gk().Checked)
				{
					u6().Enabled = ie().Enabled;
					uw().Enabled = id().Enabled;
					uv().Enabled = ic().Enabled;
					uu().Enabled = ib().Enabled;
				}
				else
				{
					a(vc(), vb(), va(), u9(), u6(), uw(), uv(), uu(), num);
				}
			}
		}
		else
		{
			e3().Enabled = true;
			a(this.m_zf[0], fv(), fu(), f7(), fz());
			a(e5(), fa(), e4(), e6(), fb(), ft());
			a(e2(), e1(), e0(), ez(), f8(), f7(), f6(), fz(), 0);
		}
	}

	private void al()
	{
		if (this.m_zf == null)
		{
			return;
		}
		if (bx())
		{
			bool enabled = false;
			int[] array = this.m_zf;
			for (int num = 0; num < array.Length; num = checked(num + 1))
			{
				if (array[num] == 2)
				{
					enabled = true;
				}
			}
			ge().Enabled = enabled;
			bz();
		}
		else if (this.m_zf[0] == 2)
		{
			ey().Enabled = true;
		}
		else
		{
			ey().Enabled = false;
		}
	}

	private void a(RadioButton A_0, RadioButton A_1, RadioButton A_2, RadioButton A_3, TextBox A_4, TextBox A_5, TextBox A_6, TextBox A_7, int A_8)
	{
		bool enabled = this.m_zf[A_8] == 1 || A_1.Checked || A_0.Checked || A_3.Checked;
		bool enabled2 = this.m_zf[A_8] == 2 && (A_2.Checked || A_0.Checked || A_3.Checked);
		A_4.Enabled = enabled;
		A_5.Enabled = enabled2;
		A_6.Enabled = enabled;
		A_7.Enabled = enabled2;
	}

	private void a(RadioButton A_0, RadioButton A_1, RadioButton A_2, GroupBox A_3, GroupBox A_4, GroupBox A_5)
	{
		bool flag = true;
		if (flag == A_0.Checked)
		{
			A_5.Enabled = false;
			A_4.Enabled = false;
			A_3.Enabled = true;
		}
		else if (flag == A_1.Checked)
		{
			A_5.Enabled = false;
			A_4.Enabled = true;
			A_3.Enabled = false;
		}
		else if (flag == A_2.Checked)
		{
			A_5.Enabled = true;
			A_4.Enabled = false;
			A_3.Enabled = false;
		}
	}

	[SpecialName]
	private RadioButton af()
	{
		if (bx())
		{
			return hd();
		}
		return e5();
	}

	[SpecialName]
	private RadioButton ad()
	{
		if (bx())
		{
			return hk();
		}
		return fa();
	}

	[SpecialName]
	private RadioButton ac()
	{
		if (bx())
		{
			return hc();
		}
		return e4();
	}

	[SpecialName]
	private hy ab()
	{
		if (bx())
		{
			return hr();
		}
		return fc();
	}

	private void a(ref RadioButton A_0, ref RadioButton A_1, ref RadioButton A_2, ref TextBox A_3)
	{
		if (bx())
		{
			A_0 = hd();
			A_1 = hk();
			A_2 = hc();
			A_3 = hr();
		}
		else
		{
			A_0 = e5();
			A_1 = fa();
			A_2 = e4();
			A_3 = fc();
		}
	}

	private void a(int A_0, Label A_1, Label A_2, TextBox A_3, TextBox A_4)
	{
		bool visible = (A_1.Visible = A_0 == 2);
		A_2.Visible = visible;
		A_3.Visible = visible;
		A_4.Visible = visible;
	}

	private void a(global::f A_0, TextBox A_1, TextBox A_2, TextBox A_3, TextBox A_4, RadioButton A_5, RadioButton A_6, RadioButton A_7, RadioButton A_8, int A_9)
	{
		global::f f10 = A_0;
		A_1.Text = Conversions.ToString(this.m_x6.m2(this.m_xr, global::h6.b.b, A_9, global::f.b.b, f10.b(global::f.b.b)));
		if (this.m_zf != null && this.m_zf[A_9] > 1)
		{
			A_2.Text = Conversions.ToString(this.m_x6.m2(this.m_xr, global::h6.b.b, A_9, global::f.b.c, f10.b(global::f.b.c)));
		}
		A_3.Text = Conversions.ToString(f10.h(global::f.b.b));
		A_4.Text = Conversions.ToString(f10.h(global::f.b.c));
		if (this.m_aa0[A_9])
		{
			A_5.Enabled = true;
			A_8.Enabled = true;
		}
		else
		{
			A_5.Enabled = false;
			A_8.Enabled = false;
		}
		switch (f10.b(this.m_aa0[A_9]))
		{
		case global::f.a.a:
			A_5.Checked = true;
			break;
		case global::f.a.b:
			A_6.Checked = true;
			break;
		case global::f.a.c:
			A_7.Checked = true;
			break;
		case global::f.a.d:
			A_8.Checked = true;
			break;
		}
		f10 = null;
	}

	private void aa()
	{
		if (!this.m_aay[0])
		{
			vi().Enabled = false;
		}
		if (!this.m_aay[1])
		{
			vh().Enabled = false;
		}
		if (!this.m_aay[2])
		{
			vg().Enabled = false;
		}
	}

	private bool z()
	{
		h h10 = this.m_x2.b8();
		if (h10.a(this.m_aay) == global::h.e.a)
		{
			return true;
		}
		if (h10.v() != this.m_aay[0])
		{
			return false;
		}
		if (h10.x() != this.m_aay[1])
		{
			return false;
		}
		if (h10.an() != this.m_aay[2])
		{
			return false;
		}
		return true;
	}

	private void y()
	{
		try
		{
			bp();
			h h10 = this.m_x2.b8();
			bool flag = !this.m_x6.m2(this.m_xr) && !this.m_aat;
			ew().Visible = flag;
			if (flag)
			{
				ew().Enabled = this.m_x6.vp(this.m_xr);
			}
			Label label;
			if (bx())
			{
				label = hh();
				if (this.m_aay[0])
				{
					a(h10.a(0), ie(), id(), ic(), ib(), gs(), gp(), go(), gn(), this.m_x6.m2(this.m_xr, global::h.f.a));
				}
				gk().Checked = h10.t();
				if (this.m_aay[1])
				{
					a(h10.a(1), io(), @in(), im(), il(), g2(), g1(), g0(), gz(), this.m_x6.m2(this.m_xr, global::h.f.b));
				}
				if (this.m_aay[2])
				{
					a(h10.a(2), u6(), uw(), uv(), uu(), vc(), vb(), va(), u9(), this.m_x6.m2(this.m_xr, global::h.f.c));
				}
				aa();
				h.e a_ = h10.a(this.m_aay);
				if (vi().Enabled && global::h.p(a_))
				{
					vi().Checked = true;
				}
				if (vh().Enabled && global::h.n(a_))
				{
					vh().Checked = true;
				}
				if (vg().Enabled && global::h.d(a_))
				{
					vg().Checked = true;
				}
			}
			else
			{
				label = e9();
				a(h10.a(0), f8(), f7(), f6(), fz(), e2(), e1(), e0(), ez(), 0);
			}
			RadioButton A_ = null;
			RadioButton A_2 = null;
			RadioButton A_3 = null;
			TextBox A_4 = null;
			a(ref A_, ref A_2, ref A_3, ref A_4);
			switch (h10.n(this.m_aat))
			{
			case global::h.MeasurementTimingType.Recommended:
				A_.Checked = true;
				break;
			case global::h.MeasurementTimingType.Maximum:
				A_2.Checked = true;
				break;
			case global::h.MeasurementTimingType.Manual:
				A_3.Checked = true;
				break;
			}
			if (global::e8.a.a(this.m_aah, this.m_x2.d0()))
			{
				label.Text = ">" + this.m_zk;
			}
			else if (this.m_zk <= 0.0)
			{
				label.Text = "Unknown";
			}
			else
			{
				label.Text = Conversions.ToString(checked((int)Math.Round(this.m_zk)));
			}
			A_4.Text = Conversions.ToString(h10.ar());
			ComboBox.ObjectCollection items = wg().Items;
			items.Clear();
			if (this.m_zg)
			{
				items.Add("Spectrometer");
			}
			if (this.m_aak && this.m_y9)
			{
				items.Add("Photodiode");
			}
			wf().Visible = items.Count > 1;
			if (items.Count > 1 && this.m_x2.b8().a(this.m_y9, !this.m_zg))
			{
				wg().SelectedIndex = 1;
			}
			else
			{
				wg().SelectedIndex = 0;
			}
			items = null;
			am();
			al();
			e(this.m_x2.b8().av());
			zm().Visible = false;
		}
		finally
		{
			bq();
		}
	}

	private void e(bool A_0)
	{
		h h10 = this.m_x2.b8();
		checked
		{
			if (h10.av())
			{
				bp();
				wi().Columns["DGVColumnPDName"].HeaderText = "Wavelength #";
				bq();
				wi().Rows.Clear();
				foreach (h.b item in h10.au())
				{
					wi().Rows.Add(wi().RowCount + 1, item.d.ToString(), item.a);
				}
			}
			else
			{
				wu().Text = h10.aw().ToString();
				wm().Checked = h10.ax();
				wo().Text = h10.ay().ToString();
				wr().Text = h10.az().ToString();
				if (h10.a0())
				{
					x8().Checked = true;
				}
				else
				{
					x9().Checked = true;
				}
				bp();
				wi().Columns["DGVColumnPDName"].HeaderText = "Photodiode #";
				bq();
				wi().Rows.Clear();
				foreach (h.a item2 in h10.a2())
				{
					wi().Rows.Add(wi().RowCount + 1, item2.d.ToString(), item2.a, item2.c);
				}
			}
			x();
			h10 = null;
		}
	}

	private void a(TextBox A_0, TextBox A_1, global::f.b A_2, global::f A_3)
	{
		double a_ = global::iz.e(A_0.Text);
		int a_2 = global::iz.c(A_1.Text);
		A_3.b(A_2, a_, a_2);
	}

	private void x()
	{
		h h10 = this.m_x2.b8();
		yd().Visible = !h10.av() && h10.a0();
		h10 = null;
	}

	private void a(RadioButton A_0, RadioButton A_1, RadioButton A_2, RadioButton A_3, global::f A_4)
	{
		bool flag = true;
		if (flag == A_0.Checked)
		{
			A_4.h(global::f.a.a);
		}
		else if (flag == A_1.Checked)
		{
			A_4.h(global::f.a.b);
		}
		else if (flag == A_2.Checked)
		{
			A_4.h(global::f.a.c);
		}
		else if (flag == A_3.Checked)
		{
			A_4.h(global::f.a.d);
		}
	}

	private void w()
	{
		ahf().Visible = this.m_aas;
		ahe().Visible = this.m_aas;
		ahh().Visible = this.m_aas;
		ahg().Visible = this.m_aas;
		ahi().Visible = this.m_aas;
	}

	private void v()
	{
		zp().Enabled = ch().Contains(ci());
		zo().Enabled = true;
		zn().Enabled = this.m_aap;
		zt().Enabled = true;
		ahl().Enabled = this.m_aap;
		af9().Enabled = this.m_aar;
		zr().Enabled = true;
		zs().Enabled = true;
		ahk().Enabled = this.m_aap;
		ahm().Enabled = this.m_aap;
		zu().Enabled = true;
	}

	private void u()
	{
		bp();
		try
		{
			x5().Text = Conversions.ToString(this.m_x2.b9().b);
			xn().Text = Conversions.ToString(this.m_x2.b9().c);
			xa().SelectedIndex = this.m_x2.b9().d;
			xe().Text = Conversions.ToString(this.m_x2.b9().e);
			xf().Checked = this.m_x2.b9().f;
			xi().Checked = this.m_x2.b9().g;
			xj().Checked = this.m_x2.b9().h;
			w7().Value = new decimal(this.m_x2.b9().i);
			xw().Value = new decimal((this.m_x2.b9().m > 0f) ? this.m_x2.b9().m : 0f);
			x0().Value = new decimal((this.m_x2.b9().o > 0f) ? this.m_x2.b9().o : 0f);
			w8().Checked = this.m_x2.b9().j;
			w7().Enabled = w8().Checked;
			xs().Checked = this.m_x2.b9().l;
			xr().Enabled = xs().Checked;
			xv().Checked = this.m_x2.b9().n;
			xw().Enabled = xv().Checked;
			xy().Checked = this.m_x2.b9().p;
			x0().Enabled = xy().Checked;
			switch (this.m_x2.b9().a)
			{
			case global::jk.a.a:
				x3().SelectedIndex = 0;
				break;
			case global::jk.a.b:
				x3().SelectedIndex = 1;
				break;
			case global::jk.a.c:
				x3().SelectedIndex = 2;
				break;
			}
			q();
		}
		finally
		{
			bq();
		}
	}

	[SpecialName]
	private jk.a t()
	{
		jk.a a10 = default(jk.a);
		return x3().SelectedIndex switch
		{
			0 => global::jk.a.a, 
			1 => global::jk.a.b, 
			2 => global::jk.a.c, 
			_ => a10, 
		};
	}

	private void q()
	{
		jk.a a10 = t();
		xr().Value = new decimal(global::jk.t(this.m_x2.b9().k, a10));
		xq().Text = "Rate(" + global::jk.r(a10) + ")";
	}

	private void p()
	{
		b8().Text = this.m_x2.ci();
		o();
		if (ch().TabPages.Contains(dp()))
		{
			a1();
		}
		if (ch().TabPages.Contains(ci()))
		{
			hi hi2 = this.m_x2.ed();
			if (hi2.d5(this.m_x2.dh().aw(by()), by()))
			{
				hi2.hm();
			}
			hi2 = null;
			f(A_0: false);
			bd();
		}
		if (ch().TabPages.Contains(w2()))
		{
			u();
		}
		TabControl.TabPageCollection tabPages = ch().TabPages;
		if (tabPages.Contains(ci()) || tabPages.Contains(dp()))
		{
			a3();
		}
		if (tabPages.Contains(ye()))
		{
			an();
		}
		tabPages = null;
		if (this.m_zg || this.m_y9)
		{
			y();
		}
	}

	private void o()
	{
		this.m_x2.ed().cq = true;
		if (global::hg.bv(this.m_x2, this.m_x4))
		{
			DateTime dateTime = (this.m_x5 = DateAndTime.Now);
			p8().Text = dateTime.ToShortDateString() + " " + dateTime.ToLongTimeString();
			qg().Text = this.m_xy;
			ce().Enabled = true;
			this.m_x2.fy = false;
		}
		else
		{
			p8().Text = Conversions.ToString(DateTime.FromOADate(this.m_x2.cn()));
			qg().Text = this.m_x2.cm();
			ce().Enabled = !this.m_x2.c9();
		}
		ck().Enabled = global::hg.bv(this.m_zd, this.m_x2);
	}

	private void d(bool A_0)
	{
		o7().Visible = A_0;
		o8().Visible = A_0;
		o9().Visible = A_0;
		o6().Visible = A_0;
	}

	private void n()
	{
		bool flag = this.m_aat || this.m_aak;
		o3().Visible = !flag;
		if (bx())
		{
			if (this.m_aat)
			{
				hu().Location = he().Location;
				hc().Location = hd().Location;
				hc().Checked = true;
				g6().Height = 210;
			}
			hq().Visible = !this.m_aat;
			hk().Visible = !this.m_aat;
			he().Visible = !this.m_aat;
			hd().Visible = !this.m_aat;
			g3().Visible = !this.m_aat;
			ge().Visible = !this.m_aat;
			gb().Visible = !this.m_aat;
			ga().Visible = !this.m_aat;
		}
		else
		{
			if (this.m_aat)
			{
				ft().Location = e6().Location;
				e4().Location = e5().Location;
				e4().Checked = true;
				e3().Height = 210;
			}
			fb().Visible = !this.m_aat;
			fa().Visible = !this.m_aat;
			e6().Visible = !this.m_aat;
			e5().Visible = !this.m_aat;
			ey().Visible = !this.m_aat;
			ex().Visible = !this.m_aat;
			ew().Visible = !this.m_aat;
		}
	}

	private hg b(hg A_0)
	{
		hg A_1 = new hg(A_0.dh(), A_0.cd());
		A_0.bu(ref A_1);
		hi hi2 = A_1.ed();
		int num = 0;
		checked
		{
			do
			{
				gc gc2 = hi2.et(num);
				if (gc2.an() > 0.0 || gc2.al(this.m_aam))
				{
					gc gc3 = new gc();
					gc3.af(A_1.co(), A_1: true, gc2.an());
					gc3.ag(gc2.al(this.m_aam));
					gc3.af("<Roughness>");
					_ = null;
					gc2.am(A_0: false);
					gc2.aj(0.0);
					hi2.au(gc3, num);
				}
				num++;
			}
			while (num <= hi2.g6() + 1);
			hi2 = null;
			return A_1;
		}
	}

	private hg a(hg A_0)
	{
		hg A_1 = new hg(A_0.dh(), A_0.cd());
		A_0.bu(ref A_1);
		hi hi2 = A_1.ed();
		checked
		{
			for (int num = 1; num < hi2.g6() + 1; num++)
			{
				gc gc2 = hi2.et(num);
				if (Operators.CompareString(gc2.ag(), "<Roughness>", TextCompare: false) == 0)
				{
					gc obj = hi2.et(num + 1);
					obj.aj(gc2.ai());
					obj.am(gc2.ao());
					hi2.ev(num);
				}
			}
			hi2 = null;
			return A_1;
		}
	}

	private void a(ref bool A_0)
	{
		A_0 = true;
		if (global::hg.bv(this.m_x2, this.m_x4))
		{
			this.m_x2.cb(this.m_xy);
			this.m_x2.bw(this.m_x5.ToOADate());
			this.m_x2.b5(A_0: false);
			this.m_x2.ca(Guid.NewGuid().ToString());
		}
		if (this.m_x2.ed().hq())
		{
			A_0 = false;
			return;
		}
		y();
		this.m_x2.bu(ref this.m_x4);
		bool flag = false;
		bool flag2 = false;
		flag2 = !global::hg.bu(this.m_x2.ed().cr, this.m_zd.ed().cr);
		hg hg2 = a(this.m_x2);
		if (global::hg.bv(hg2, this.m_zd) || flag2)
		{
			hg2.bu(ref this.m_zd);
			flag = true;
		}
		else
		{
			if (this.m_zg && !a())
			{
				flag = true;
			}
			if (this.m_zd.c9() != this.m_x2.c9())
			{
				flag = true;
			}
			this.m_zd.b5(this.m_x2.c9());
			this.m_zd.bz(this.m_x2.da());
			this.m_zd.b0(this.m_x2.db());
		}
		if (flag)
		{
			this.m_zd.bv(this.m_zj, A_1: false);
		}
		ck().Enabled = false;
	}

	private void m()
	{
		this.m_x6.p9(this.m_xr, this.m_x2, this.m_aak);
		this.m_x2 = b(this.m_x2);
		this.m_x5 = DateTime.FromOADate(this.m_x2.cn());
		this.m_x2.bu(ref this.m_x4);
		this.m_x3 = this.m_x2.ed().d5(this.m_x2.dh().aw(by()), by());
	}

	private void a(bool A_0, bool A_1, bool A_2, bool A_3)
	{
		xv().Checked = A_0;
		xw().Enabled = xv().Checked;
		this.m_x2.b9().n = xv().Checked;
		xy().Checked = A_1;
		x0().Enabled = xy().Checked;
		this.m_x2.b9().p = xy().Checked;
		w8().Checked = A_2;
		w7().Enabled = w8().Checked;
		this.m_x2.b9().j = w8().Checked;
		xs().Checked = A_3;
		xr().Enabled = xs().Checked;
		this.m_x2.b9().l = xs().Checked;
	}

	private void c(bool A_0)
	{
		int num = (A_0 ? 1 : (-1));
		TabPage tabPage = lp();
		checked
		{
			foreach (Control control in tabPage.Controls)
			{
				control.Left -= num * 56;
			}
			tabPage = null;
			int num2 = 0;
			do
			{
				this.m_zt[num2].Width += num * 2 * 56;
				this.m_zq[num2].Left += num * 2 * 56;
				this.m_z1[num2].Visible = A_0;
				this.m_z2[num2].Visible = A_0;
				this.m_z3[num2].Visible = A_0;
				num2++;
			}
			while (num2 <= 11);
			aab().Left += num * 2 * 56;
			acb().Width = this.m_zt[0].Width;
			aaa().Visible = A_0;
			z9().Visible = A_0;
			z8().Visible = A_0;
			aie().Visible = A_0;
			TabPage tabPage2 = lq();
			foreach (Control control2 in tabPage2.Controls)
			{
				control2.Left -= num * 51;
			}
			tabPage2 = null;
			int num3 = 0;
			do
			{
				this.m_zu[num3].Width += num * 2 * 51;
				this.m_zr[num3].Left += num * 2 * 51;
				this.m_z4[num3].Visible = A_0;
				this.m_z5[num3].Visible = A_0;
				this.m_z6[num3].Visible = A_0;
				this.m_z0[num3].Visible = A_0;
				num3++;
			}
			while (num3 <= 5);
			lr().Left += num * 2 * 51;
			oz().Width = this.m_zu[0].Width;
			lv().Visible = A_0;
			lu().Visible = A_0;
			lt().Visible = A_0;
			aif().Visible = A_0;
		}
	}

	private void b(bool A_0)
	{
		int num = (A_0 ? 1 : (-1));
		lw().Visible = A_0;
		int num2 = 0;
		checked
		{
			do
			{
				this.m_zp[num2].Visible = A_0;
				num2++;
			}
			while (num2 <= 5);
			TabPage tabPage = lq();
			foreach (Control control in tabPage.Controls)
			{
				control.Left -= num * 31;
			}
			tabPage = null;
			int num3 = 0;
			do
			{
				this.m_zu[num3].Width += num * 2 * 31;
				this.m_zr[num3].Left += num * 2 * 31;
				this.m_z0[num3].Left += num * 2 * 31;
				num3++;
			}
			while (num3 <= 5);
			lr().Left += num * 2 * 31;
			oz().Width = this.m_zu[0].Width;
			lv().Left += num * 2 * 31;
			lu().Left += num * 2 * 31;
			lt().Left += num * 2 * 31;
			aif().Left += num * 2 * 31;
		}
	}

	private bool a(int A_0, Control A_1)
	{
		if (A_0 <= 0 || A_0 >= checked(this.m_x2.b4(0) + 1))
		{
			if (A_1 is Label)
			{
				return this.m_xu.Contains((Label)A_1);
			}
			return false;
		}
		return true;
	}

	private bool g(int A_0)
	{
		hi hi2 = this.m_x2.ed();
		if (!hi2.d5(this.m_x2.dh().aw(by()), by()))
		{
			return false;
		}
		if (hi2.au(ref A_0) != 0)
		{
			return true;
		}
		return false;
	}

	private void a(TextBox A_0)
	{
		cv cv2 = new cv();
		string A_1 = null;
		string text = null;
		int num = this.m_yp.IndexOf(A_0);
		string a_ = null;
		bool flag = num == checked(this.m_x2.b4(0) + 1);
		bool flag2 = default(bool);
		if (global::gd.l(A_0.Text))
		{
			text = A_0.Text.Substring("Stack: ".Length);
			string text2 = a(A_0.Text, flag);
			if (string.IsNullOrEmpty(text2))
			{
				global::fe.b(A_1: (!flag) ? (text + " does not exist as a Layer LayerStack.\r\nThe first available Layer LayerStack will be displayed.") : (text + " does not exist as a Substrate LayerStack.\r\nThe first available Substrate LayerStack will be displayed."), A_0: this.m_y5, A_2: global::i6.a(A_0));
			}
			else
			{
				flag2 = Operators.CompareString(Path.GetExtension(text2).ToLower(), ".fibss", TextCompare: false) == 0 || Operators.CompareString(Path.GetExtension(text2).ToLower(), ".fibls", TextCompare: false) == 0;
				a_ = A_0.Text;
			}
		}
		if (this.m_x2.dh().a8() || !flag2)
		{
			cv2.a(this.m_y5, this.m_x6, (f4)this.m_xq, this.m_y7, this.m_y3, this.m_ze, flag, this.m_abf.ag, this.m_abf.ai, this.m_x2, a_, this.m_xy, ref A_1, bv(), by(), global::e8.a.a(this.m_aah, this.m_x2.d0()));
			Collection<string> collection = ((!flag) ? this.m_abf.ag : this.m_abf.ai);
			this.m_abf.z = collection;
			if (cv2.DialogResult == DialogResult.OK)
			{
				if (Operators.CompareString(A_1, A_0.Text, TextCompare: false) != 0)
				{
					a(A_1, num, A_2: true);
				}
				o();
			}
			bd();
		}
		else
		{
			fz a_2 = this.m_y5;
			string A_2 = "LayerStackEditDeniedFmt";
			global::fe.b(a_2, string.Format(global::hu.a(ref A_2), text), bv());
		}
	}

	private bool a(hy A_0)
	{
		return global::jf.c(global::iz.e(A_0.Text), 100.0);
	}

	private void a(hy A_0, ref double A_1)
	{
		double num = global::iz.e(A_0.Text);
		gc gc2 = this.m_x2.bu(this.m_yt.IndexOf(A_0), 0);
		if (this.m_x2.cp())
		{
			A_1 = num * 0.01;
		}
		else if (gc2.ai() != 0.0)
		{
			A_1 = this.m_x2.ca().e(num) / gc2.ai();
		}
		else
		{
			A_1 = 0.0;
		}
		gc2 = null;
	}

	private bool a(Control A_0)
	{
		if (A_0 is hy)
		{
			hy item = (hy)A_0;
			if (this.m_yb.Contains(item) || this.m_yy.Contains(item) || this.m_y0.Contains(item) || this.m_yt.Contains(item))
			{
				return true;
			}
		}
		if (A_0 is CheckBox)
		{
			CheckBox item2 = (CheckBox)A_0;
			if (this.m_yu.Contains(item2) || this.m_yw.Contains(item2) || this.m_yx.Contains(item2))
			{
				return true;
			}
		}
		if (A_0 is Label)
		{
			Label item3 = (Label)A_0;
			if (this.m_yz.Contains(item3) || this.m_yc.Contains(item3))
			{
				return true;
			}
		}
		if (A_0 is ComboBox)
		{
			ComboBox item4 = (ComboBox)A_0;
			if (this.m_y1.Contains(item4))
			{
				return true;
			}
		}
		return false;
	}

	private bool a(int A_0, Control A_1, Collection<Control> A_2)
	{
		if (this.m_ye.i() == global::bx.a.b && this.m_yf[A_0].Contains(A_1))
		{
			return false;
		}
		if (this.m_ym.i() == global::bx.a.b && this.m_yn[A_0].Contains(A_1))
		{
			return false;
		}
		checked
		{
			int index = this.m_yn[A_0].Count - 1;
			if (this.m_ym.i() == global::bx.a.a && global::e8.a.a(this.m_aah, this.m_x2.d0()) && this.m_yn[A_0].Contains(A_1) && this.m_yn[A_0][index] == A_1)
			{
				return false;
			}
			if (this.m_yj.i() == global::bx.a.b && this.m_yk[A_0].Contains(A_1))
			{
				return false;
			}
			if ((A_0 == 0 || A_0 == this.m_x2.b4(0) + 1) && a(A_1))
			{
				return false;
			}
			if (A_2 != null && A_2.Contains(A_1))
			{
				return false;
			}
			return true;
		}
	}

	private string a(string A_0, bool A_1)
	{
		if (A_1)
		{
			if (File.Exists(global::gd.i() + A_0.Substring("Stack: ".Length) + ".fibss"))
			{
				return A_0.Substring("Stack: ".Length) + ".fibss";
			}
			if (File.Exists(global::gd.i() + A_0.Substring("Stack: ".Length) + ".fitss"))
			{
				return A_0.Substring("Stack: ".Length) + ".fitss";
			}
		}
		else
		{
			if (File.Exists(global::gd.i() + A_0.Substring("Stack: ".Length) + ".fibls"))
			{
				return A_0.Substring("Stack: ".Length) + ".fibls";
			}
			if (File.Exists(global::gd.i() + A_0.Substring("Stack: ".Length) + ".fitls"))
			{
				return A_0.Substring("Stack: ".Length) + ".fitls";
			}
		}
		return null;
	}

	private void f(int A_0)
	{
		hy control = this.m_yt[A_0];
		if (!this.m_x2.dh().aw(by()))
		{
			string A_1 = null;
			string A_2 = string.Empty;
			if (global::gd.l(this.m_x2.bu(A_0, 0).ag()) || this.m_x2.bu(A_0, by(), global::e8.a.a(this.m_aah, this.m_x2.d0()), ref A_1, ref A_2))
			{
				zi().SetError(control, null);
			}
			else
			{
				zi().SetError(control, "Layer nonuniformity must be <=" + A_1 + " " + A_2);
			}
		}
		else
		{
			zi().SetError(control, null);
		}
	}

	private void e(int A_0)
	{
		hy control = this.m_y0[A_0];
		string A_1 = null;
		string A_2 = string.Empty;
		if (global::gd.l(this.m_x2.bu(A_0, 0).ag()) || this.m_x2.bw(A_0, by(), global::e8.a.a(this.m_aah, this.m_x2.d0()), ref A_1, ref A_2))
		{
			zi().SetError(control, null);
		}
		else
		{
			zi().SetError(control, "Thickness Range must be <=" + A_1 + " " + A_2);
		}
	}

	private void l()
	{
		this.m_x2.ed();
		int num = this.m_x2.b4(0);
		for (int num2 = 1; num2 <= num; num2 = checked(num2 + 1))
		{
			d(num2);
		}
		_ = null;
	}

	private void d(int A_0)
	{
		string A_1 = null;
		string A_2 = string.Empty;
		if (global::gd.l(this.m_x2.bu(A_0, 0).ag()) || this.m_x2.bv(A_0, by(), global::e8.a.a(this.m_aah, this.m_x2.d0()), ref A_1, ref A_2))
		{
			zi().SetError(this.m_yy[A_0], null);
		}
		else
		{
			zi().SetError(this.m_yy[A_0], "Thickness must be >=" + A_1 + " " + A_2);
		}
	}

	private void c(int A_0)
	{
		f(A_0);
		d(A_0);
		e(A_0);
	}

	private void k()
	{
		hi obj = this.m_x2.ed();
		bool enabled = obj.hr();
		checked
		{
			int num = obj.g6() + 2;
			for (int num2 = 0; num2 <= num; num2++)
			{
				this.m_yd[num2].Enabled = enabled;
			}
			_ = null;
		}
	}

	private bool b(int A_0)
	{
		return this.m_x2.bu(A_0, 0).ah() > 0;
	}

	private bool a(ref int A_0)
	{
		hi hi2 = this.m_x2.ed();
		int num = hi2.g6();
		checked
		{
			for (A_0 = 1; A_0 <= num; A_0++)
			{
				if (global::gd.l(hi2.et(A_0).ag()) && !b(A_0))
				{
					return true;
				}
			}
			hi2 = null;
			return false;
		}
	}

	private int j()
	{
		hg hg2 = this.m_x2;
		int num = hg2.b4(0);
		checked
		{
			int num4 = default(int);
			for (int num2 = 1; num2 <= num; num2++)
			{
				hi hi2 = hg2.ed();
				gc gc2 = hi2.et(num2);
				if (global::gd.l(gc2.ag()))
				{
					int num3 = gc2.ah();
					if (num3 > 1)
					{
						string a_ = gc2.ag().Substring("Stack: ".Length);
						num4 += (num3 - 1) * hi2.d5(a_, A_1: false);
					}
				}
				hi2 = null;
			}
			hg2 = null;
			return num4;
		}
	}

	private void i()
	{
		checked
		{
			int A_ = default(int);
			bool flag = this.m_x2.ed().d5(ref A_) && A_ - j() <= 100;
			hi hi2 = this.m_x2.ed();
			int num = hi2.g6();
			for (int num2 = 1; num2 <= num; num2++)
			{
				if (global::gd.l(hi2.et(num2).ag()))
				{
					hy hy2 = this.m_yq[num2];
					if (Conversions.ToShort(hy2.Text) == 0)
					{
						ErrorProvider errorProvider = zi();
						string A_2 = "RecipeInvalidZeroNumStack";
						errorProvider.SetError(hy2, global::hu.a(ref A_2));
					}
					else if (Conversions.ToShort(hy2.Text) > 1 && flag)
					{
						ErrorProvider errorProvider2 = zi();
						string A_2 = "RecipeInvalidNumLayersExceededFmt2";
						errorProvider2.SetError(hy2, string.Format(global::hu.a(ref A_2), A_.ToString(), 100.ToString()));
					}
					else
					{
						zi().SetError(hy2, null);
					}
				}
			}
			hi2 = null;
			k();
		}
	}

	private void h()
	{
		gr obj = this.m_y7;
		ref Collection<string> a_ = ref this.m_abf.ag;
		string A_ = "\\MostRecentLayerMaterials.fmslf";
		obj.m2(ref a_, ref A_);
		gr obj2 = this.m_y7;
		ref Collection<string> a_2 = ref this.m_abf.ah;
		A_ = "\\MostRecentMediumMaterials.fmslf";
		obj2.m2(ref a_2, ref A_);
		gr obj3 = this.m_y7;
		ref Collection<string> a_3 = ref this.m_abf.ai;
		A_ = "\\MostRecentSubstrateMaterials.fmslf";
		obj3.m2(ref a_3, ref A_);
	}

	private void g()
	{
		a(A_0: false);
	}

	private void a(bool A_0)
	{
		hi hi2 = this.m_x2.ed();
		bool flag = hi2.d5(this.m_x2.dh().aw(by()), by());
		if (this.m_x3 != flag || A_0)
		{
			if (flag)
			{
				hi2.hm();
			}
			else
			{
				hi2.hn();
			}
			f(A_0: false);
			a3();
			this.m_x3 = flag;
			hi2 = null;
		}
	}

	private void b(int A_0, string A_1)
	{
		string A_2 = string.Empty;
		global::cv.a(this.m_y5, this, A_1, ref A_2);
		if (!string.IsNullOrEmpty(A_2))
		{
			a(A_2, A_0);
		}
	}

	private void a(int A_0, string A_1)
	{
		dr obj = new dr();
		string A_2 = A_1;
		obj.a(this.m_y5, this.m_x6, (f4)this.m_xq, this.m_y7.so(), this.m_y7.sn(), this.m_x2.dh(), by(), ref A_2);
		if (obj.DialogResult == DialogResult.OK)
		{
			a(A_2, A_0);
		}
	}

	private bool b(string A_0)
	{
		return a(this.m_y5, A_0, bv());
	}

	public static bool a(fz A_0, string A_1, Point A_2)
	{
		if (Operators.CompareString(A_1, "DefaultRecipe", TextCompare: false) == 0)
		{
			string A_3 = "RecipeCantModifyFmt1";
			global::fe.b(A_0, string.Format(global::hu.a(ref A_3), "DefaultRecipe"), "RecipeDefault", A_2);
			return true;
		}
		return false;
	}

	private bool a(Color A_0)
	{
		return checked(A_0.R + A_0.G + A_0.B) < 384;
	}

	private double a(double A_0)
	{
		if (Conversions.ToBoolean(global::e.a().GraphMeasYLabelPercent[0]))
		{
			return A_0 * 0.01;
		}
		return A_0;
	}

	private void a(Panel A_0, TabPage A_1)
	{
		if (A_0.Height <= A_1.ClientSize.Height)
		{
			return;
		}
		if (base.ActiveControl != null)
		{
			Control control = base.ActiveControl.Parent;
			while (control != this && control != A_0)
			{
				control = control.Parent;
			}
			if (control == A_0)
			{
				return;
			}
		}
		int value = A_1.VerticalScroll.Value;
		A_0.Focus();
		A_1.VerticalScroll.Value = value;
	}

	private bool a(global::f A_0, int A_1, global::f.b A_2, ref string A_3)
	{
		global::f f10 = A_0;
		double num = this.m_x6.p9(this.m_xr, global::h6.b.b, A_1, A_2);
		double num2 = this.m_x6.m2(this.m_xr, global::h6.b.b, A_1, A_2);
		if (f10.b(A_2) < num || f10.b(A_2) > num2)
		{
			string A_4 = string.Empty;
			if (A_2 == global::f.b.b)
			{
				A_4 = "RecipeAcqSettingShortWaveIntTime";
			}
			if (A_2 == global::f.b.c)
			{
				A_4 = "RecipeAcqSettingLongWaveIntTime";
			}
			string A_5 = "ValuesBetweenFmt3";
			A_3 = string.Format(global::hu.a(ref A_5), global::hu.a(ref A_4), num, num2);
			return false;
		}
		if (f10.h(A_2) < 1 || f10.h(A_2) > 5000)
		{
			string A_6 = string.Empty;
			if (A_2 == global::f.b.b)
			{
				A_6 = "RecipeAcqSettingShortWaveNumCycles";
			}
			if (A_2 == global::f.b.c)
			{
				A_6 = "RecipeAcqSettingLongWaveNumCycles";
			}
			string A_5 = "InvalidValueFor1Between2And3Fmt3";
			A_3 = string.Format(global::hu.a(ref A_5), global::hu.a(ref A_6), 1, 5000);
			return false;
		}
		f10 = null;
		return true;
	}

	private bool d(ref string A_0)
	{
		checked
		{
			if (this.m_aak)
			{
				if (this.m_x2.b8().a0())
				{
					int upperBound = this.m_za.GetUpperBound(0);
					for (int num = 0; num <= upperBound; num++)
					{
						float a_ = this.m_x2.b8().a2()[num].c;
						if (global::jf.d(a_, this.m_za[num]) || global::jf.b(a_, this.m_zb[num]))
						{
							string A_1 = "ValuesBetweenFmt3";
							string format = global::hu.a(ref A_1);
							A_1 = "PhotodiodeGainFmt";
							A_0 = string.Format(format, string.Format(global::hu.a(ref A_1), (num + 1).ToString()), this.m_za[num].ToString(), Math.Floor(this.m_zb[num]).ToString());
							return false;
						}
					}
				}
				return true;
			}
			h h10 = this.m_x2.b8();
			switch (h10.n(this.m_aat))
			{
			case global::h.MeasurementTimingType.Maximum:
				if (h10.ar() < 1.0 || h10.ar() > 60000.0)
				{
					string A_1 = "ValuesBetweenFmt3";
					string format2 = global::hu.a(ref A_1);
					A_1 = "RecipeAcqSettingMaxSamplingTime";
					A_0 = string.Format(format2, global::hu.a(ref A_1), 1.0, 60000.0);
					return false;
				}
				break;
			case global::h.MeasurementTimingType.Manual:
				if (bx())
				{
					int num2 = this.m_zf.GetUpperBound(0) - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						h.f a_2 = this.m_aa1[num3];
						unchecked
						{
							if (a(a_2))
							{
								if (a(a_2, num3) && !a(h10.a((int)a_2), num3, global::f.b.b, ref A_0))
								{
									return false;
								}
								if (b(a_2, num3) && !a(h10.a((int)a_2), num3, global::f.b.c, ref A_0))
								{
									return false;
								}
							}
						}
					}
				}
				else
				{
					if (bu() && !a(h10.a(0), 0, global::f.b.b, ref A_0))
					{
						return false;
					}
					if (bw() && !a(h10.a(0), 0, global::f.b.c, ref A_0))
					{
						return false;
					}
				}
				break;
			}
			if (bx() && (!vi().Enabled || !vi().Checked) && (!vh().Enabled || !vh().Checked) && (!vg().Enabled || !vg().Checked))
			{
				A_0 = "Please select at least one Measurement Type.";
				return false;
			}
			if (this.m_aas)
			{
				h.d d10 = this.m_x2.b8().d();
				float num4 = 2f * d10.f / 100f;
				float num5 = 0.08f * d10.g / 100f;
				int num6 = default(int);
				if (!global::jf.e(num5, 0.0))
				{
					num6 = (int)Math.Round(num4 / num5) + 1;
				}
				if (global::jf.e(num5, 0.0) || num6 > 200)
				{
					A_0 = "The number of focus steps exceeds the maximum of " + 200.ToString("0") + " steps. Please reduce the Range(%) or increase the Step size(%).";
					return false;
				}
				if (num6 < 10)
				{
					A_0 = "The number of focus steps is below the minimum of " + 10.ToString("0") + " steps. Please increase the Range(%) or decrease the Step size(%).";
					return false;
				}
				d10 = null;
			}
			h10 = null;
			return true;
		}
	}

	private bool a(ref string A_0, ref int A_1)
	{
		int num = checked(this.m_x2.b4(0) + 1);
		hi hi2 = this.m_x2.ed();
		this.m_x2.ca();
		if (hi2.gq() < 0.0 || hi2.gq() > 1.0)
		{
			string A_2 = "ValuesBetweenFmt3";
			string format = global::hu.a(ref A_2);
			A_2 = "AlarmsMinValidGOFThreshold";
			A_0 = string.Format(format, global::hu.a(ref A_2), 0f, 1f);
			return false;
		}
		if (!hi2.g5() && !hi2.d5((a4.a)global::e.a().ShowSpectrumCoordOption))
		{
			return true;
		}
		checked
		{
			if (hi2.g5())
			{
				int num2 = num - 1;
				for (A_1 = 1; A_1 <= num2; A_1++)
				{
					gc gc2 = this.m_x2.bu(A_1, 0);
					if (gc2.af(this.m_aao) && gc2.am() <= gc2.al())
					{
						string A_2 = "ValueFor1MustBe2Than3";
						string format2 = global::hu.a(ref A_2);
						A_2 = "RecipeAlarmThicknessMaxFmt";
						string arg = string.Format(global::hu.a(ref A_2), A_1);
						A_2 = "RecipeAlarmThicknessMinFmt";
						A_0 = string.Format(format2, arg, ">", string.Format(global::hu.a(ref A_2), A_1));
						return false;
					}
					gc2 = null;
				}
			}
		}
		if (hi2.d5((a4.a)global::e.a().ShowSpectrumCoordOption))
		{
			hi hi3 = hi2;
			if (hi3.en() <= hi3.em())
			{
				string A_2 = "RecipeInvalidMinFmt";
				A_0 = string.Format(global::hu.a(ref A_2), v4().Text);
				return false;
			}
			if (hi3.ep() <= hi3.eo())
			{
				string A_2 = "RecipeInvalidMinFmt";
				A_0 = string.Format(global::hu.a(ref A_2), v5().Text);
				return false;
			}
			if (hi3.er() <= hi3.eq())
			{
				string A_2 = "RecipeInvalidMinFmt";
				A_0 = string.Format(global::hu.a(ref A_2), v6().Text);
				return false;
			}
			hi3 = null;
		}
		return true;
	}

	private bool c(ref string A_0)
	{
		hi obj = this.m_x2.ed();
		double num = obj.fs();
		double num2 = obj.fr();
		if (!b(ref A_0))
		{
			return false;
		}
		if (da().Checked)
		{
			if (num < 100.0 || num > 2000.0)
			{
				string A_1 = "ValuesBetweenFmt3";
				string format = global::hu.a(ref A_1);
				A_1 = "AnalysisStartWavelength";
				A_0 = string.Format(format, global::hu.a(ref A_1), (short)100, 2000f);
				return false;
			}
			if (num2 < 100.0 || num2 > 2000.0)
			{
				string A_1 = "ValuesBetweenFmt3";
				string format2 = global::hu.a(ref A_1);
				A_1 = "AnalysisEndWavelength";
				A_0 = string.Format(format2, global::hu.a(ref A_1), (short)100, 2000f);
				return false;
			}
			if (num2 <= num)
			{
				string A_1 = "ValuesBetweenFmt3";
				string format3 = global::hu.a(ref A_1);
				A_1 = "AnalysisEndWavelength";
				A_0 = string.Format(format3, global::hu.a(ref A_1), num, 2000f);
				return false;
			}
		}
		return true;
	}

	private bool f()
	{
		Control control = base.ActiveControl;
		try
		{
			base.ActiveControl = b5();
			if (base.ActiveControl != b5())
			{
				return true;
			}
		}
		finally
		{
			base.ActiveControl = control;
		}
		return false;
	}

	private bool a(ref string A_0, ref int A_1, ref TabPage A_2, ref TabPage A_3)
	{
		if ((ch().Contains(d2()) || ch().Contains(ev())) && !d(ref A_0))
		{
			if (bx())
			{
				A_2 = ev();
			}
			else
			{
				A_2 = d2();
			}
			return false;
		}
		if (ch().TabPages.Contains(cj()) && !c(ref A_0))
		{
			A_2 = cj();
			return false;
		}
		if (ch().TabPages.Contains(dl()) && !a(ref A_0, ref A_1))
		{
			A_2 = dl();
			return false;
		}
		if (ch().TabPages.Contains(dp()) && !a(ref A_0, ref A_3))
		{
			A_2 = dp();
			return false;
		}
		if (ch().TabPages.Contains(ye()) && !a(ref A_0))
		{
			A_2 = ye();
			return false;
		}
		if (this.m_x2.bu(by(), global::e8.a.a(this.m_aah, this.m_x2.d0()), ref A_1))
		{
			A_2 = ci();
			string A_4 = "RecipeInvalidDNUDConstraint";
			A_0 = global::hu.a(ref A_4);
			return false;
		}
		if (a(ref A_1))
		{
			A_2 = ci();
			string A_4 = "RecipeInvalidZeroNumStacksFmt";
			A_0 = string.Format(global::hu.a(ref A_4), A_1.ToString());
			return false;
		}
		int A_5 = default(int);
		if (this.m_x2.ed().d5(ref A_5))
		{
			A_2 = ci();
			string A_4 = "RecipeInvalidNumLayersExceededFmt2";
			A_0 = string.Format(global::hu.a(ref A_4), A_5.ToString(), 100.ToString());
			return false;
		}
		bool A_6 = default(bool);
		bool A_7 = default(bool);
		this.m_x2.bu(this.m_y5, bv(), this.m_xy, A_3: false, ref A_6, ref A_0, ref A_1, ref A_7, this.m_x6.xk(this.m_xr), A_9: true, global::e8.a.a(this.m_aah, this.m_x2.d0()), by());
		if (A_6)
		{
			try
			{
				bp();
				o();
				p();
			}
			finally
			{
				bq();
			}
		}
		if (!A_7)
		{
			A_2 = ci();
			return false;
		}
		hi hi2 = this.m_x2.ed();
		checked
		{
			int num = hi2.g6() + 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				gc gc2 = hi2.et(num2);
				string text = gc2.ag();
				if (global::gd.l(text))
				{
					if (num2 == 0)
					{
						A_2 = ci();
						A_0 = "A LayerStack cannot be used as the Medium.";
						return false;
					}
					if (num2 == hi2.g6() + 1)
					{
						if (string.IsNullOrEmpty(a(text, A_1: true)))
						{
							A_2 = ci();
							A_0 = text + " does not exist as a Substrate LayerStack.";
							return false;
						}
					}
					else if (string.IsNullOrEmpty(a(text, A_1: false)))
					{
						A_2 = ci();
						A_0 = text + " does not exist as a Layer LayerStack.";
						return false;
					}
				}
				bool flag = global::gd.l(text);
				bool flag2 = Operators.CompareString(text, "<Roughness>", TextCompare: false) == 0 || Operators.CompareString(text, "<Graded Interface>", TextCompare: false) == 0;
				if (hi2.g6() > num2)
				{
					text = hi2.et(num2 + 1).ag();
					bool flag3 = Operators.CompareString(text, "<Roughness>", TextCompare: false) == 0 || Operators.CompareString(text, "<Graded Interface>", TextCompare: false) == 0;
					if (flag2 && flag3)
					{
						A_2 = ci();
						string A_4 = "ErrRecipeInvalidAdjacentLayerTypes";
						A_0 = global::hu.a(ref A_4);
						return false;
					}
				}
				if ((num2 == 0 || num2 == hi2.g6() + 1) && flag2)
				{
					A_2 = ci();
					string A_4 = "ErrLayerInvalidType";
					A_0 = global::hu.a(ref A_4);
					return false;
				}
				if (!flag2 && !flag)
				{
					if (gc2.aw() == 0.0 && gc2.ax() == 0.0 && (gc2.ah(this.m_aam) || gc2.aj(this.m_aam)))
					{
						A_2 = ci();
						A_0 = "It is illegal to specify +/-n=0 and +/-k=0 if Measure NK is checked.";
						return false;
					}
					if (num2 > 0 && num2 < hi2.g6() + 1 && gc2.aj() > 1.0)
					{
						A_2 = ci();
						if (this.m_x2.cp())
						{
							A_0 = "Nonuniformity of layer " + num2 + " must be <=100%";
						}
						else
						{
							A_0 = "Nonuniformity of layer " + num2 + " must be <=" + global::hg.bu(global::hg.o.a, this.m_x2.ca(), gc2.ai(), global::e.a().DisplaySignificantDigits, new h4(global::h4.a.b), 0);
						}
						return false;
					}
				}
				if (num2 >= 1 && num2 <= hi2.g6() && !flag)
				{
					gc gc3 = gc2;
					if (gc3.av() <= 0.0 && gc3.af(this.m_aao))
					{
						A_2 = ci();
						A_0 = "Layer thickness range for layer " + num2 + " must be larger than 0.";
						return false;
					}
					gc3 = null;
				}
			}
			hi2 = null;
			return true;
		}
	}

	private bool e()
	{
		string A_ = null;
		TabPage A_2 = null;
		TabPage A_3 = null;
		int A_4 = default(int);
		if (!a(ref A_, ref A_4, ref A_2, ref A_3))
		{
			if (A_2 == dp())
			{
				lo().SelectedTab = A_3;
			}
			ch().SelectedTab = A_2;
			global::fe.b(this.m_y5, A_, bv());
			return false;
		}
		if (!vd().Checked && !vf().Checked && !ve().Checked)
		{
			vd().Checked = true;
		}
		return true;
	}

	private bool b(ref string A_0)
	{
		return global::hg.bu(this.m_x2.dx(), this.m_y8, ref A_0);
	}

	private bool a(ref string A_0, ref TabPage A_1)
	{
		float num = 0f;
		float num2 = 1f;
		if (Conversions.ToBoolean(global::e.a().GraphMeasYLabelPercent[0]))
		{
			num = 0f;
			num2 = 100f;
		}
		if (!b(ref A_0))
		{
			A_1 = o0();
			return false;
		}
		hi hi2 = this.m_x2.ed();
		A_1 = lp();
		checked
		{
			int num3 = hi2.e3() - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				if (hi2.d7(num4) < 0.0 || hi2.d7(num4) > 1.0)
				{
					string A_2 = "ValuesBetweenFmt3";
					string format = global::hu.a(ref A_2);
					A_2 = "RecipeSpectrumAnalysisRegionMinFmt";
					A_0 = string.Format(format, string.Format(global::hu.a(ref A_2), num4 + 1), num, num2);
					return false;
				}
				if (hi2.d8(num4) < 0.0 || hi2.d8(num4) > 1.0)
				{
					string A_2 = "ValuesBetweenFmt3";
					string format2 = global::hu.a(ref A_2);
					A_2 = "RecipeSpectrumAnalysisRegionMaxFmt";
					A_0 = string.Format(format2, string.Format(global::hu.a(ref A_2), num4 + 1), num, num2);
					return false;
				}
				if (hi2.d8(num4) <= hi2.d7(num4))
				{
					string A_2 = "ValueFor1MustBe2Than3";
					string format3 = global::hu.a(ref A_2);
					A_2 = "RecipeSpectrumAnalysisRegionMaxFmt";
					string arg = string.Format(global::hu.a(ref A_2), num4 + 1);
					A_2 = "RecipeSpectrumAnalysisRegionMinFmt";
					A_0 = string.Format(format3, arg, ">", string.Format(global::hu.a(ref A_2), num4 + 1));
					return false;
				}
				if (hi2.d5(num4) < 100.0 || hi2.d5(num4) > 2000.0)
				{
					string A_2 = "ValuesBetweenFmt3";
					string format4 = global::hu.a(ref A_2);
					A_2 = "RecipeSpectrumAnalysisStartWavelengthFmt";
					A_0 = string.Format(format4, string.Format(global::hu.a(ref A_2), num4 + 1), (short)100, 2000f);
					return false;
				}
				if (hi2.d6(num4) < 100.0 || hi2.d6(num4) > 2000.0)
				{
					string A_2 = "ValuesBetweenFmt3";
					string format5 = global::hu.a(ref A_2);
					A_2 = "RecipeSpectrumAnalysisEndWavelengthFmt";
					A_0 = string.Format(format5, string.Format(global::hu.a(ref A_2), num4 + 1), (short)100, 2000f);
					return false;
				}
				if (global::jf.d(hi2.d6(num4), hi2.d5(num4)))
				{
					string A_2 = "ValueFor1MustBe2Than3";
					string format6 = global::hu.a(ref A_2);
					A_2 = "RecipeSpectrumAnalysisEndWavelengthFmt";
					string arg2 = string.Format(global::hu.a(ref A_2), num4 + 1);
					A_2 = "RecipeSpectrumAnalysisStartWavelengthFmt";
					A_0 = string.Format(format6, arg2, ">=", string.Format(global::hu.a(ref A_2), num4 + 1));
					return false;
				}
			}
			A_1 = lq();
			int num5 = hi2.e9() - 1;
			for (int num6 = 0; num6 <= num5; num6++)
			{
				if (hi2.ee(num6) < 0.0 || hi2.ee(num6) > 1.0)
				{
					string A_2 = "ValuesBetweenFmt3";
					string format7 = global::hu.a(ref A_2);
					A_2 = "RecipeSpectrumAnalysisExtremaMinFmt";
					A_0 = string.Format(format7, string.Format(global::hu.a(ref A_2), num6 + 1), num, num2);
					return false;
				}
				if (hi2.ef(num6) < 0.0 || hi2.ef(num6) > 1.0)
				{
					string A_2 = "ValuesBetweenFmt3";
					string format8 = global::hu.a(ref A_2);
					A_2 = "RecipeSpectrumAnalysisExtremaMaxFmt";
					A_0 = string.Format(format8, string.Format(global::hu.a(ref A_2), num6 + 1), num, num2);
					return false;
				}
				if (hi2.ef(num6) <= hi2.ee(num6))
				{
					string A_2 = "ValueFor1MustBe2Than3";
					string format9 = global::hu.a(ref A_2);
					A_2 = "RecipeSpectrumAnalysisExtremaMaxFmt";
					string arg3 = string.Format(global::hu.a(ref A_2), num6 + 1);
					A_2 = "RecipeSpectrumAnalysisExtremaMinFmt";
					A_0 = string.Format(format9, arg3, ">", string.Format(global::hu.a(ref A_2), num6 + 1));
					return false;
				}
				if (hi2.ec(num6) < 100.0 || hi2.ec(num6) > 2000.0)
				{
					string A_2 = "ValuesBetweenFmt3";
					string format10 = global::hu.a(ref A_2);
					A_2 = "RecipeSpectrumAnalysisExtremaWaveMinFmt";
					A_0 = string.Format(format10, string.Format(global::hu.a(ref A_2), num6 + 1), (short)100, 2000f);
					return false;
				}
				if (hi2.ed(num6) < 100.0 || hi2.ed(num6) > 2000.0)
				{
					string A_2 = "ValuesBetweenFmt3";
					string format11 = global::hu.a(ref A_2);
					A_2 = "RecipeSpectrumAnalysisExtremaWaveMaxFmt";
					A_0 = string.Format(format11, string.Format(global::hu.a(ref A_2), num6 + 1), (short)100, 2000f);
					return false;
				}
				if (hi2.ed(num6) <= hi2.ec(num6))
				{
					string A_2 = "ValueFor1MustBe2Than3";
					string format12 = global::hu.a(ref A_2);
					A_2 = "RecipeSpectrumAnalysisExtremaWaveMaxFmt";
					string arg4 = string.Format(global::hu.a(ref A_2), num6 + 1);
					A_2 = "RecipeSpectrumAnalysisExtremaWaveMinFmt";
					A_0 = string.Format(format12, arg4, ">", string.Format(global::hu.a(ref A_2), num6 + 1));
					return false;
				}
			}
			hi2 = null;
			return true;
		}
	}

	private bool a(ref string A_0)
	{
		if (this.m_x2.d3())
		{
			string a_ = this.m_x2.d4();
			hd a_2 = this.m_ze;
			eo a_3 = this.m_x2.dh();
			eo.a a_4 = by();
			string A_1 = null;
			string A_2 = null;
			bool A_3 = false;
			if (0 > global::jb.a(a_, a_2, a_3, a_4, ref A_0, ref A_1, ref A_2, ref A_3))
			{
				A_0 = "Background R Substrate material is invalid. Please select a valid material.\r\nError message when attempting to validate material \"" + this.m_x2.d4() + "\" results in the following error:\r\n" + A_0;
				return false;
			}
		}
		return true;
	}

	private List<it> d()
	{
		List<it> list = new List<it>();
		List<h.a> list2 = this.m_x2.b8().a2();
		checked
		{
			foreach (it item in this.m_zc)
			{
				int num = list2.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (list2[num2].a && item.d.Contains(num2))
					{
						list.Add(item);
						break;
					}
				}
			}
			list2 = null;
			return list;
		}
	}

	private bool c()
	{
		if (this.m_aak)
		{
			return this.m_x2.b8().a(this.m_y9, !this.m_zg);
		}
		return false;
	}

	[SpecialName]
	private @is.a b()
	{
		if (c())
		{
			return global::@is.a.b;
		}
		return global::@is.a.a;
	}

	private bool a()
	{
		if (!Directory.Exists(global::@is.b()))
		{
			return false;
		}
		string text = this.m_x2.b8().@as();
		@is.a a10 = b();
		FileInfo[] files = new DirectoryInfo(global::@is.b()).GetFiles(global::@is.c(a10, text));
		List<it> list;
		int num;
		if (a10 == global::@is.a.a)
		{
			list = this.m_x6.m2(this.m_xr, this.m_x2, this.m_aak);
			num = this.m_x6.m2(this.m_xr, global::h.f.b);
		}
		else
		{
			list = d();
			num = -1;
		}
		foreach (it item in list)
		{
			bool flag = false;
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				if (Operators.CompareString(text, global::@is.b(fileInfo.Name, item.e()), TextCompare: false) == 0)
				{
					string left = ((a10 != global::@is.a.a || item.g() != num) ? this.m_x2.b8().a(global::h.g.a).c() : this.m_x2.b8().a(global::h.g.b).c());
					string right = ((a10 != global::@is.a.a) ? global::@in.m2(this.m_y5, fileInfo.FullName, global::g2.OpticsConfigSubmoduleTypes.ReflectanceProbe) : global::ip.m2(this.m_y5, fileInfo.FullName, global::g2.a(this.m_x2.d0().c(), this.m_aa1[item.g()])));
					if (Operators.CompareString(left, right, TextCompare: false) == 0)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				return false;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void a(string A_0)
	{
		string text = "";
		string a_ = "";
		hg hg2 = this.m_x2;
		text = hg2.cm();
		double a_2 = hg2.cn();
		if (global::hg.bv(this.m_x2, this.m_x4))
		{
			hg2.cb(this.m_xy);
			hg2.bw(this.m_x5.ToOADate());
			hg2.ca(Guid.NewGuid().ToString());
		}
		hg2 = null;
		this.m_x2 = a(this.m_x2);
		int num = this.m_x2.ch(A_0);
		this.m_x2 = b(this.m_x2);
		this.m_x2.cc(A_0);
		if (num == 0)
		{
			string text2 = Path.GetDirectoryName(A_0) + "\\" + Path.GetFileNameWithoutExtension(A_0) + ".rpe";
			try
			{
				if (global::c.e().FileSystem.FileExists(text2))
				{
					Microsoft.VisualBasic.FileSystem.Kill(text2);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				this.m_y5.c(global::fz.b.b, "Error trying to kill .rpe file", a_3);
				ProjectData.ClearProjectError();
			}
			this.m_x2.bu(ref this.m_x4);
			o();
		}
		else
		{
			hg obj = this.m_x2;
			obj.cb(text);
			obj.ca(a_);
			obj.bw(a_2);
			_ = null;
			fz a_4 = this.m_y5;
			string A_1 = "RecipeSaveErrFmt2";
			global::fe.b(a_4, string.Format(global::hu.a(ref A_1), "Recipe".ToLower(), A_0), "RecipeSaveTitle", bv());
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			if (!bs())
			{
				zw().Text = a(global::iz.c(((hy)A_0).Text)).ToString();
				this.m_x2.b1(global::iz.c(zw().Text));
				o();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (bs())
			{
				this.m_y5.c(global::fz.b.b, "Error inDialogEditRecipe.TextBoxNumericSmoothPtsHalfWid_TextChanged", ex3);
			}
			else
			{
				global::i5.a(this.m_y5, this.m_x6, RuntimeHelpers.GetObjectValue(this.m_xq), bv(), "DialogEditRecipe.TextBoxNumericSmoothPtsHalfWid_TextChanged", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private int a(int A_0)
	{
		return checked(A_0 * 2 + 1);
	}
}
