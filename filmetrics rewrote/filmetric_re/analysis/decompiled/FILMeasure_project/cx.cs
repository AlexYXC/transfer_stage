using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Forms;
using FIUsbIntLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class cx : Form
{
	private class a
	{
		public string a;

		public string b;

		public string c;

		public bool d;

		public a(string A_0, string A_1, string A_2)
		{
			a = A_0;
			b = A_1;
			c = A_2;
			d = false;
		}

		public a(string A_0)
		{
			a = A_0;
			d = true;
		}

		public override string ToString()
		{
			return a;
		}
	}

	private delegate void b();

	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private Label m_c;

	[CompilerGenerated]
	private TableLayoutPanel m_d;

	[CompilerGenerated]
	private TabControl m_e;

	[CompilerGenerated]
	private TableLayoutPanel m_f;

	[CompilerGenerated]
	private ComboBox m_g;

	[CompilerGenerated]
	private GroupBox m_h;

	[CompilerGenerated]
	private hy m_i;

	[CompilerGenerated]
	private hy m_j;

	[CompilerGenerated]
	private Label m_k;

	[CompilerGenerated]
	private Label m_l;

	[CompilerGenerated]
	private CheckBox m_m;

	[CompilerGenerated]
	private ComboBox m_n;

	[CompilerGenerated]
	private Label m_o;

	[CompilerGenerated]
	private Label m_p;

	[CompilerGenerated]
	private Label m_q;

	[CompilerGenerated]
	private GroupBox m_r;

	[CompilerGenerated]
	private hy m_s;

	[CompilerGenerated]
	private hy m_t;

	[CompilerGenerated]
	private hy m_u;

	[CompilerGenerated]
	private Label m_v;

	[CompilerGenerated]
	private Label m_w;

	[CompilerGenerated]
	private Label m_x;

	[CompilerGenerated]
	private TableLayoutPanel m_y;

	[CompilerGenerated]
	private TableLayoutPanel m_z;

	[CompilerGenerated]
	private TabPage m_aa;

	[CompilerGenerated]
	private Button m_ab;

	[CompilerGenerated]
	private Label m_ac;

	[CompilerGenerated]
	private hx m_ad;

	[CompilerGenerated]
	private Label m_ae;

	[CompilerGenerated]
	private Label m_af;

	[CompilerGenerated]
	private TextBox m_ag;

	[CompilerGenerated]
	private TextBox m_ah;

	[CompilerGenerated]
	private TableLayoutPanel m_ai;

	[CompilerGenerated]
	private TableLayoutPanel m_aj;

	[CompilerGenerated]
	private GroupBox m_ak;

	[CompilerGenerated]
	private Button m_al;

	[CompilerGenerated]
	private ComboBox m_am;

	[CompilerGenerated]
	private Label m_an;

	[CompilerGenerated]
	private TabPage m_ao;

	[CompilerGenerated]
	private TableLayoutPanel m_ap;

	[CompilerGenerated]
	private hy m_aq;

	[CompilerGenerated]
	private Label m_ar;

	[CompilerGenerated]
	private CheckBox m_as;

	[CompilerGenerated]
	private TabControl m_at;

	[CompilerGenerated]
	private TabPage m_au;

	[CompilerGenerated]
	private TableLayoutPanel m_av;

	[CompilerGenerated]
	private Label m_aw;

	[CompilerGenerated]
	private Label m_ax;

	[CompilerGenerated]
	private TabPage m_ay;

	[CompilerGenerated]
	private hy m_az;

	[CompilerGenerated]
	private hy m_a0;

	[CompilerGenerated]
	private Button m_a1;

	[CompilerGenerated]
	private TableLayoutPanel m_a2;

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
	private Label m_a8;

	[CompilerGenerated]
	private Label m_a9;

	[CompilerGenerated]
	private TableLayoutPanel m_ba;

	[CompilerGenerated]
	private hy m_bb;

	[CompilerGenerated]
	private Label m_bc;

	[CompilerGenerated]
	private Label m_bd;

	[CompilerGenerated]
	private TableLayoutPanel m_be;

	[CompilerGenerated]
	private hy m_bf;

	[CompilerGenerated]
	private Label m_bg;

	[CompilerGenerated]
	private hy m_bh;

	[CompilerGenerated]
	private hy m_bi;

	[CompilerGenerated]
	private hy m_bj;

	[CompilerGenerated]
	private hy m_bk;

	[CompilerGenerated]
	private hy m_bl;

	[CompilerGenerated]
	private hy m_bm;

	[CompilerGenerated]
	private hy m_bn;

	[CompilerGenerated]
	private hy m_bo;

	[CompilerGenerated]
	private hy m_bp;

	[CompilerGenerated]
	private hy m_bq;

	[CompilerGenerated]
	private Button m_br;

	[CompilerGenerated]
	private Button m_bs;

	[CompilerGenerated]
	private GroupBox m_bt;

	[CompilerGenerated]
	private TableLayoutPanel m_bu;

	[CompilerGenerated]
	private Button m_bv;

	[CompilerGenerated]
	private Label m_bw;

	[CompilerGenerated]
	private hy m_bx;

	[CompilerGenerated]
	private GroupBox m_by;

	[CompilerGenerated]
	private TableLayoutPanel m_bz;

	[CompilerGenerated]
	private hy m_b0;

	[CompilerGenerated]
	private hy m_b1;

	[CompilerGenerated]
	private Label m_b2;

	[CompilerGenerated]
	private Label m_b3;

	[CompilerGenerated]
	private Button m_b4;

	[CompilerGenerated]
	private Label m_b5;

	[CompilerGenerated]
	private hy m_b6;

	[CompilerGenerated]
	private TableLayoutPanel m_b7;

	[CompilerGenerated]
	private hy m_b8;

	[CompilerGenerated]
	private hy m_b9;

	[CompilerGenerated]
	private Button m_ca;

	[CompilerGenerated]
	private Label m_cb;

	[CompilerGenerated]
	private Label m_cc;

	[CompilerGenerated]
	private GroupBox m_cd;

	[CompilerGenerated]
	private TableLayoutPanel m_ce;

	[CompilerGenerated]
	private ComboBox m_cf;

	[CompilerGenerated]
	private ComboBox m_cg;

	[CompilerGenerated]
	private Label m_ch;

	[CompilerGenerated]
	private Label m_ci;

	[CompilerGenerated]
	private Label m_cj;

	[CompilerGenerated]
	private Label m_ck;

	[CompilerGenerated]
	private ComboBox m_cl;

	[CompilerGenerated]
	private ComboBox m_cm;

	[CompilerGenerated]
	private Label m_cn;

	[CompilerGenerated]
	private Label m_co;

	[CompilerGenerated]
	private ComboBox m_cp;

	[CompilerGenerated]
	private Label m_cq;

	[CompilerGenerated]
	private Button m_cr;

	[CompilerGenerated]
	private Label m_cs;

	[CompilerGenerated]
	private Label m_ct;

	[CompilerGenerated]
	private CheckBox m_cu;

	[CompilerGenerated]
	private CheckBox m_cv;

	[CompilerGenerated]
	private CheckBox m_cw;

	[CompilerGenerated]
	private CheckBox m_cx;

	[CompilerGenerated]
	private CheckBox m_cy;

	[CompilerGenerated]
	private Label m_cz;

	[CompilerGenerated]
	private Label m_c0;

	[CompilerGenerated]
	private Label m_c1;

	[CompilerGenerated]
	private TableLayoutPanel m_c2;

	[CompilerGenerated]
	private CheckBox m_c3;

	[CompilerGenerated]
	private hy m_c4;

	[CompilerGenerated]
	private Label m_c5;

	[CompilerGenerated]
	private CheckBox m_c6;

	[CompilerGenerated]
	private CheckBox m_c7;

	[CompilerGenerated]
	private CheckBox m_c8;

	[CompilerGenerated]
	private CheckBox m_c9;

	[CompilerGenerated]
	private CheckBox m_da;

	[CompilerGenerated]
	private CheckBox m_db;

	[CompilerGenerated]
	private CheckBox m_dc;

	[CompilerGenerated]
	private CheckBox m_dd;

	[CompilerGenerated]
	private CheckBox m_de;

	[CompilerGenerated]
	private CheckBox m_df;

	[CompilerGenerated]
	private CheckBox m_dg;

	[CompilerGenerated]
	private CheckBox m_dh;

	[CompilerGenerated]
	private Label m_di;

	[CompilerGenerated]
	private hy m_dj;

	[CompilerGenerated]
	private Label m_dk;

	[CompilerGenerated]
	private ComboBox m_dl;

	[CompilerGenerated]
	private TableLayoutPanel m_dm;

	[CompilerGenerated]
	private TableLayoutPanel m_dn;

	[CompilerGenerated]
	private CheckBox m_do;

	[CompilerGenerated]
	private TableLayoutPanel m_dp;

	[CompilerGenerated]
	private Label m_dq;

	[CompilerGenerated]
	private TextBox m_dr;

	[CompilerGenerated]
	private TextBox m_ds;

	[CompilerGenerated]
	private Label m_dt;

	[CompilerGenerated]
	private Label m_du;

	[CompilerGenerated]
	private hx m_dv;

	[CompilerGenerated]
	private TableLayoutPanel m_dw;

	[CompilerGenerated]
	private TableLayoutPanel m_dx;

	[CompilerGenerated]
	private TableLayoutPanel m_dy;

	[CompilerGenerated]
	private Label m_dz;

	[CompilerGenerated]
	private ComboBox m_d0;

	[CompilerGenerated]
	private TableLayoutPanel m_d1;

	[CompilerGenerated]
	private Label m_d2;

	[CompilerGenerated]
	private Button m_d3;

	[CompilerGenerated]
	private Button m_d4;

	[CompilerGenerated]
	private Label m_d5;

	[CompilerGenerated]
	private Label m_d6;

	[CompilerGenerated]
	private Label m_d7;

	[CompilerGenerated]
	private CheckBox m_d8;

	[CompilerGenerated]
	private CheckBox m_d9;

	[CompilerGenerated]
	private Label m_ea;

	[CompilerGenerated]
	private hy m_eb;

	[CompilerGenerated]
	private Label m_ec;

	[CompilerGenerated]
	private Label m_ed;

	[CompilerGenerated]
	private Label m_ee;

	[CompilerGenerated]
	private hy m_ef;

	[CompilerGenerated]
	private CheckBox m_eg;

	[CompilerGenerated]
	private TableLayoutPanel m_eh;

	[CompilerGenerated]
	private CheckBox m_ei;

	[CompilerGenerated]
	private hx m_ej;

	[CompilerGenerated]
	private Label m_ek;

	[CompilerGenerated]
	private TableLayoutPanel m_el;

	[CompilerGenerated]
	private Label m_em;

	[CompilerGenerated]
	private Label m_en;

	[CompilerGenerated]
	private Label m_eo;

	[CompilerGenerated]
	private hy m_ep;

	[CompilerGenerated]
	private hy m_eq;

	[CompilerGenerated]
	private Button m_er;

	[CompilerGenerated]
	private CheckBox m_es;

	[CompilerGenerated]
	private Button m_et;

	[CompilerGenerated]
	private Button m_eu;

	[CompilerGenerated]
	private TableLayoutPanel m_ev;

	[CompilerGenerated]
	private CheckBox m_ew;

	[CompilerGenerated]
	private TabPage m_ex;

	[CompilerGenerated]
	private TableLayoutPanel m_ey;

	[CompilerGenerated]
	private Button m_ez;

	[CompilerGenerated]
	private ComboBox m_e0;

	[CompilerGenerated]
	private Label m_e1;

	[CompilerGenerated]
	private TableLayoutPanel m_e2;

	[CompilerGenerated]
	private Label m_e3;

	[CompilerGenerated]
	private TextBox m_e4;

	[CompilerGenerated]
	private TextBox m_e5;

	[CompilerGenerated]
	private Label m_e6;

	[CompilerGenerated]
	private Label m_e7;

	[CompilerGenerated]
	private hx m_e8;

	[CompilerGenerated]
	private GroupBox m_e9;

	[CompilerGenerated]
	private TableLayoutPanel m_fa;

	[CompilerGenerated]
	private Label m_fb;

	[CompilerGenerated]
	private TableLayoutPanel m_fc;

	[CompilerGenerated]
	private CheckBox m_fd;

	[CompilerGenerated]
	private hy m_fe;

	[CompilerGenerated]
	private Label m_ff;

	[CompilerGenerated]
	private TabPage m_fg;

	[CompilerGenerated]
	private TableLayoutPanel m_fh;

	[CompilerGenerated]
	private ListBox m_fi;

	[CompilerGenerated]
	private Label m_fj;

	[CompilerGenerated]
	private ComboBox m_fk;

	[CompilerGenerated]
	private ListBox m_fl;

	[CompilerGenerated]
	private TableLayoutPanel m_fm;

	[CompilerGenerated]
	private Button m_fn;

	[CompilerGenerated]
	private Button m_fo;

	[CompilerGenerated]
	private GroupBox m_fp;

	[CompilerGenerated]
	private GroupBox m_fq;

	[CompilerGenerated]
	private TableLayoutPanel m_fr;

	[CompilerGenerated]
	private TableLayoutPanel m_fs;

	[CompilerGenerated]
	private Button m_ft;

	[CompilerGenerated]
	private ToolTip m_fu;

	[CompilerGenerated]
	private TableLayoutPanel m_fv;

	[CompilerGenerated]
	private Button m_fw;

	[CompilerGenerated]
	private hy m_fx;

	[CompilerGenerated]
	private hy m_fy;

	[CompilerGenerated]
	private Label m_fz;

	[CompilerGenerated]
	private Label m_f0;

	[CompilerGenerated]
	private hy m_f1;

	[CompilerGenerated]
	private Label m_f2;

	[CompilerGenerated]
	private Label m_f3;

	[CompilerGenerated]
	private ComboBox m_f4;

	[CompilerGenerated]
	private TabControl m_f5;

	[CompilerGenerated]
	private TabPage m_f6;

	[CompilerGenerated]
	private TabPage m_f7;

	[CompilerGenerated]
	private TableLayoutPanel m_f8;

	[CompilerGenerated]
	private Label m_f9;

	[CompilerGenerated]
	private Label m_ga;

	[CompilerGenerated]
	private Label m_gb;

	[CompilerGenerated]
	private hy m_gc;

	[CompilerGenerated]
	private hy m_gd;

	[CompilerGenerated]
	private hy m_ge;

	[CompilerGenerated]
	private GroupBox m_gf;

	[CompilerGenerated]
	private TableLayoutPanel m_gg;

	[CompilerGenerated]
	private Label m_gh;

	[CompilerGenerated]
	private Label m_gi;

	[CompilerGenerated]
	private Label m_gj;

	[CompilerGenerated]
	private hy m_gk;

	[CompilerGenerated]
	private hy m_gl;

	[CompilerGenerated]
	private hy m_gm;

	[CompilerGenerated]
	private Label m_gn;

	[CompilerGenerated]
	private Label m_go;

	[CompilerGenerated]
	private Label m_gp;

	[CompilerGenerated]
	private hy m_gq;

	[CompilerGenerated]
	private hy m_gr;

	[CompilerGenerated]
	private hy m_gs;

	[CompilerGenerated]
	private TableLayoutPanel m_gt;

	[CompilerGenerated]
	private Label m_gu;

	[CompilerGenerated]
	private TableLayoutPanel m_gv;

	[CompilerGenerated]
	private TableLayoutPanel m_gw;

	[CompilerGenerated]
	private Label m_gx;

	[CompilerGenerated]
	private Label m_gy;

	[CompilerGenerated]
	private hy m_gz;

	[CompilerGenerated]
	private hy m_g0;

	[CompilerGenerated]
	private Label m_g1;

	[CompilerGenerated]
	private hy m_g2;

	[CompilerGenerated]
	private Label m_g3;

	[CompilerGenerated]
	private CheckBox m_g4;

	[CompilerGenerated]
	private CheckBox m_g5;

	[CompilerGenerated]
	private Label m_g6;

	[CompilerGenerated]
	private TableLayoutPanel m_g7;

	[CompilerGenerated]
	private Button m_g8;

	[CompilerGenerated]
	private GroupBox m_g9;

	[CompilerGenerated]
	private TableLayoutPanel m_ha;

	[CompilerGenerated]
	private hy m_hb;

	[CompilerGenerated]
	private Label m_hc;

	[CompilerGenerated]
	private hy m_hd;

	[CompilerGenerated]
	private Label m_he;

	[CompilerGenerated]
	private hy m_hf;

	[CompilerGenerated]
	private Label m_hg;

	[CompilerGenerated]
	private CheckBox m_hh;

	[CompilerGenerated]
	private TableLayoutPanel m_hi;

	[CompilerGenerated]
	private Label m_hj;

	[CompilerGenerated]
	private CheckBox m_hk;

	[CompilerGenerated]
	private ComboBox m_hl;

	[CompilerGenerated]
	private TableLayoutPanel m_hm;

	[CompilerGenerated]
	private Button m_hn;

	[CompilerGenerated]
	private Label m_ho;

	[CompilerGenerated]
	private Label m_hp;

	[CompilerGenerated]
	private CheckBox m_hq;

	[CompilerGenerated]
	private Label m_hr;

	[CompilerGenerated]
	private TableLayoutPanel m_hs;

	[CompilerGenerated]
	private hy m_ht;

	[CompilerGenerated]
	private Label m_hu;

	[CompilerGenerated]
	private CheckBox m_hv;

	[CompilerGenerated]
	private Label m_hw;

	[CompilerGenerated]
	private ComboBox m_hx;

	[CompilerGenerated]
	private CheckBox m_hy;

	[CompilerGenerated]
	private TabControl m_hz;

	[CompilerGenerated]
	private TabPage m_h0;

	[CompilerGenerated]
	private TableLayoutPanel m_h1;

	[CompilerGenerated]
	private TabPage m_h2;

	[CompilerGenerated]
	private Button m_h3;

	[CompilerGenerated]
	private hy m_h4;

	[CompilerGenerated]
	private Label m_h5;

	[CompilerGenerated]
	private TableLayoutPanel m_h6;

	[CompilerGenerated]
	private hy m_h7;

	[CompilerGenerated]
	private Label m_h8;

	[CompilerGenerated]
	private hy m_h9;

	[CompilerGenerated]
	private Label m_ia;

	[CompilerGenerated]
	private hy m_ib;

	[CompilerGenerated]
	private Label m_ic;

	[CompilerGenerated]
	private Label m_id;

	[CompilerGenerated]
	private hy m_ie;

	[CompilerGenerated]
	private CheckBox m_if;

	[CompilerGenerated]
	private TabPage m_ig;

	[CompilerGenerated]
	private TableLayoutPanel m_ih;

	[CompilerGenerated]
	private hy m_ii;

	[CompilerGenerated]
	private Label m_ij;

	[CompilerGenerated]
	private Label m_ik;

	[CompilerGenerated]
	private hy m_il;

	[CompilerGenerated]
	private GroupBox m_im;

	[CompilerGenerated]
	private TableLayoutPanel m_in;

	[CompilerGenerated]
	private CheckBox m_io;

	[CompilerGenerated]
	private hy m_ip;

	[CompilerGenerated]
	private Label m_iq;

	[CompilerGenerated]
	private Button m_ir;

	[CompilerGenerated]
	private CheckBox m_is;

	[CompilerGenerated]
	private hy m_it;

	[CompilerGenerated]
	private Label m_iu;

	[CompilerGenerated]
	private hy m_iv;

	[CompilerGenerated]
	private Label m_iw;

	[CompilerGenerated]
	private Button m_ix;

	[CompilerGenerated]
	private System.Windows.Forms.Timer m_iy;

	[CompilerGenerated]
	private CheckBox m_iz;

	[CompilerGenerated]
	private CheckBox m_i0;

	[CompilerGenerated]
	private CheckBox m_i1;

	[CompilerGenerated]
	private GroupBox m_i2;

	[CompilerGenerated]
	private RadioButton m_i3;

	[CompilerGenerated]
	private RadioButton m_i4;

	[CompilerGenerated]
	private TableLayoutPanel m_i5;

	[CompilerGenerated]
	private hy m_i6;

	[CompilerGenerated]
	private Label m_i7;

	[CompilerGenerated]
	private hy m_i8;

	[CompilerGenerated]
	private Label m_i9;

	[CompilerGenerated]
	private hy m_ja;

	[CompilerGenerated]
	private hy m_jb;

	[CompilerGenerated]
	private hy m_jc;

	[CompilerGenerated]
	private hy m_jd;

	[CompilerGenerated]
	private hy m_je;

	[CompilerGenerated]
	private Label m_jf;

	[CompilerGenerated]
	private Label m_jg;

	[CompilerGenerated]
	private Label m_jh;

	[CompilerGenerated]
	private Label m_ji;

	[CompilerGenerated]
	private Label m_jj;

	[CompilerGenerated]
	private Label m_jk;

	[CompilerGenerated]
	private hy m_jl;

	[CompilerGenerated]
	private hy m_jm;

	[CompilerGenerated]
	private Label m_jn;

	[CompilerGenerated]
	private CheckBox m_jo;

	[CompilerGenerated]
	private Panel m_jp;

	[CompilerGenerated]
	private RadioButton m_jq;

	[CompilerGenerated]
	private RadioButton m_jr;

	[CompilerGenerated]
	private TableLayoutPanel m_js;

	[CompilerGenerated]
	private Button m_jt;

	[CompilerGenerated]
	private CheckBox m_ju;

	[CompilerGenerated]
	private CheckBox m_jv;

	[CompilerGenerated]
	private CheckBox m_jw;

	[CompilerGenerated]
	private CheckBox m_jx;

	[CompilerGenerated]
	private Panel m_jy;

	[CompilerGenerated]
	private Panel m_jz;

	[CompilerGenerated]
	private Button m_j0;

	[CompilerGenerated]
	private hy m_j1;

	[CompilerGenerated]
	private Label m_j2;

	[CompilerGenerated]
	private TableLayoutPanel m_j3;

	[CompilerGenerated]
	private GroupBox m_j4;

	[CompilerGenerated]
	private TableLayoutPanel m_j5;

	[CompilerGenerated]
	private Label m_j6;

	[CompilerGenerated]
	private hy m_j7;

	[CompilerGenerated]
	private Label m_j8;

	[CompilerGenerated]
	private hy m_j9;

	[CompilerGenerated]
	private hy m_ka;

	[CompilerGenerated]
	private hy m_kb;

	[CompilerGenerated]
	private Label m_kc;

	[CompilerGenerated]
	private Label m_kd;

	[CompilerGenerated]
	private hy m_ke;

	[CompilerGenerated]
	private hy m_kf;

	[CompilerGenerated]
	private Label m_kg;

	[CompilerGenerated]
	private Label m_kh;

	[CompilerGenerated]
	private CheckBox m_ki;

	[CompilerGenerated]
	private CheckBox m_kj;

	[CompilerGenerated]
	private CheckBox m_kk;

	[CompilerGenerated]
	private Label m_kl;

	[CompilerGenerated]
	private Button m_km;

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
	private CheckBox m_kv;

	[CompilerGenerated]
	private Label m_kw;

	[CompilerGenerated]
	private ComboBox m_kx;

	[CompilerGenerated]
	private Label m_ky;

	[CompilerGenerated]
	private CheckBox m_kz;

	[CompilerGenerated]
	private CheckBox m_k0;

	[CompilerGenerated]
	private Button m_k1;

	[CompilerGenerated]
	private CheckBox m_k2;

	[CompilerGenerated]
	private GroupBox m_k3;

	[CompilerGenerated]
	private TableLayoutPanel m_k4;

	[CompilerGenerated]
	private hy m_k5;

	[CompilerGenerated]
	private Label m_k6;

	[CompilerGenerated]
	private CheckBox m_k7;

	[CompilerGenerated]
	private Button m_k8;

	[CompilerGenerated]
	private GroupBox m_k9;

	[CompilerGenerated]
	private TableLayoutPanel m_la;

	[CompilerGenerated]
	private hy m_lb;

	[CompilerGenerated]
	private Label m_lc;

	private fz m_ld;

	private f1 m_le;

	private f4 m_lf;

	private string m_lg;

	private Guid m_lh;

	private bool m_li;

	private bool m_lj;

	private bool m_lk;

	private Collection<ip.d>[] m_ll;

	private Collection<ip.d>[] m_lm;

	private Collection<ip.e>[] m_ln;

	private Collection<h6.c>[] m_lo;

	private Collection<h6.d>[] m_lp;

	private Collection<@in.b> m_lq;

	private Collection<@in.c> m_lr;

	private string[] m_ls;

	private bool m_lt;

	private DateTime m_lu;

	private int m_lv;

	private Collection<ia> m_lw;

	private Collection<cf> m_lx;

	[CompilerGenerated]
	private r.d m_ly;

	[CompilerGenerated]
	private r.d m_lz;

	[CompilerGenerated]
	private r.d m_l0;

	[CompilerGenerated]
	private r.d m_l1;

	[CompilerGenerated]
	private r.d m_l2;

	[CompilerGenerated]
	private r.d m_l3;

	[CompilerGenerated]
	private r.d m_l4;

	[CompilerGenerated]
	private r.d m_l5;

	[CompilerGenerated]
	private r.d m_l6;

	[CompilerGenerated]
	private r.d m_l7;

	[CompilerGenerated]
	private r.d m_l8;

	[CompilerGenerated]
	private r.d m_l9;

	[CompilerGenerated]
	private r.d m_ma;

	[CompilerGenerated]
	private r.d m_mb;

	[CompilerGenerated]
	private r.d m_mc;

	[CompilerGenerated]
	private r.d m_md;

	[CompilerGenerated]
	private r.d m_me;

	[CompilerGenerated]
	private r.d m_mf;

	[CompilerGenerated]
	private r.d m_mg;

	[CompilerGenerated]
	private System.Timers.Timer m_mh;

	[CompilerGenerated]
	private System.Timers.Timer m_mi;

	[CompilerGenerated]
	private r.d m_mj;

	[CompilerGenerated]
	private r.c m_mk;

	private const string m_ml = "Unknown";

	private const string m_mm = "Corrupt";

	private const string m_mn = "DialogFirmwareSetting";

	private const string m_mo = "Measure";

	private const string m_mp = "Analyze...";

	private int m_mq;

	private int m_mr;

	private float m_ms;

	private float m_mt;

	private float m_mu;

	private float m_mv;

	private float m_mw;

	private float m_mx;

	private float m_my;

	private float m_mz;

	private float m_m0;

	private float m_m1;

	private float m2;

	private float[] m3;

	private bool m4;

	private bool m5;

	private ip.g m6;

	private r.c m7;

	private c1 m8;

	private bool m9;

	private bool na;

	private bool nb;

	private bool nc;

	private int nd;

	private int ne;

	private float nf;

	private DateTime ng;

	private bool nh;

	private bool ni;

	private bool nj;

	private bool nk;

	private bool nl;

	private bool nm;

	private a9[] nn;

	private string no;

	private const float np = 8f;

	private const float nq = 12f;

	public cx()
	{
		base.Shown += h;
		a(new r.d());
		b(new r.d());
		c(new r.d());
		d(new r.d());
		e(new r.d());
		f(new r.d());
		g(new r.d());
		h(new r.d());
		j(new r.d());
		k(new r.d());
		l(new r.d());
		m(new r.d());
		n(new r.d());
		o(new r.d());
		p(new r.d());
		q(new r.d());
		r(new r.d());
		s(new r.d());
		t(new r.d());
		a(new r.c());
		m7 = new r.c();
		no = "164";
		ak();
	}

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
	private void ak()
	{
		this.m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(cx));
		a(new Button());
		a(new Label());
		a(new TableLayoutPanel());
		ay(new TableLayoutPanel());
		z(new Button());
		b(new TableLayoutPanel());
		a(new ComboBox());
		a(new TabControl());
		b(new TabPage());
		b(new Panel());
		az(new TableLayoutPanel());
		t(new TableLayoutPanel());
		y(new TableLayoutPanel());
		a6(new CheckBox());
		at(new CheckBox());
		ai(new CheckBox());
		ag(new CheckBox());
		b7(new Label());
		af(new CheckBox());
		b4(new Label());
		ad(new CheckBox());
		b0(new Label());
		bv(new Label());
		c(new hx());
		a7(new Label());
		ar(new TableLayoutPanel());
		v(new Button());
		b5(new Label());
		b6(new Label());
		ao(new CheckBox());
		w(new TableLayoutPanel());
		n(new ComboBox());
		az(new Label());
		k(new Button());
		a0(new Label());
		a1(new Label());
		a2(new Label());
		l(new Button());
		r(new TableLayoutPanel());
		a9(new CheckBox());
		a8(new CheckBox());
		a4(new CheckBox());
		a0(new CheckBox());
		a3(new CheckBox());
		ay(new CheckBox());
		a2(new CheckBox());
		aw(new CheckBox());
		a1(new CheckBox());
		c0(new Label());
		an(new CheckBox());
		av(new hy());
		by(new Label());
		u(new CheckBox());
		ar(new Label());
		aq(new Label());
		d(new CheckBox());
		t(new CheckBox());
		f(new CheckBox());
		e(new CheckBox());
		l(new CheckBox());
		g(new CheckBox());
		m(new CheckBox());
		q(new CheckBox());
		s(new CheckBox());
		r(new CheckBox());
		j(new CheckBox());
		a8(new Label());
		a9(new Label());
		ba(new Label());
		ae(new hy());
		af(new hy());
		aa(new CheckBox());
		bz(new Label());
		ac(new CheckBox());
		ah(new CheckBox());
		aq(new CheckBox());
		ar(new CheckBox());
		aq(new TableLayoutPanel());
		ap(new Label());
		c(new CheckBox());
		p(new CheckBox());
		k(new CheckBox());
		o(new CheckBox());
		n(new CheckBox());
		az(new CheckBox());
		i(new CheckBox());
		am(new CheckBox());
		ax(new CheckBox());
		al(new CheckBox());
		z(new CheckBox());
		@as(new CheckBox());
		ab(new Button());
		au(new CheckBox());
		av(new CheckBox());
		a(new Panel());
		c(new RadioButton());
		d(new RadioButton());
		ae(new CheckBox());
		p(new ComboBox());
		c2(new Label());
		a7(new CheckBox());
		ac(new Button());
		p(new TableLayoutPanel());
		h(new CheckBox());
		aa(new hy());
		@as(new Label());
		s(new TableLayoutPanel());
		av(new Label());
		c(new TextBox());
		d(new TextBox());
		aw(new Label());
		ax(new Label());
		b(new hx());
		q(new TableLayoutPanel());
		@as(new TableLayoutPanel());
		az(new hy());
		b8(new Label());
		ai(new Label());
		e(new ComboBox());
		am(new Label());
		h(new ComboBox());
		ak(new Label());
		g(new ComboBox());
		i(new ComboBox());
		al(new Label());
		ag(new Label());
		d(new ComboBox());
		f(new ComboBox());
		ah(new Label());
		aj(new Label());
		u(new TableLayoutPanel());
		ao(new Label());
		an(new Label());
		j(new Button());
		x(new TableLayoutPanel());
		ci(new Label());
		y(new CheckBox());
		ab(new hy());
		x(new CheckBox());
		ad(new hy());
		a6(new Label());
		ac(new hy());
		a3(new Label());
		at(new Label());
		au(new Label());
		a4(new Label());
		a5(new Label());
		v(new CheckBox());
		w(new CheckBox());
		a8(new hy());
		z(new TableLayoutPanel());
		o(new Button());
		n(new Button());
		m(new Button());
		v(new TableLayoutPanel());
		ay(new Label());
		j(new ComboBox());
		c1(new Label());
		a(new TabPage());
		c(new Panel());
		f(new TableLayoutPanel());
		ao(new TableLayoutPanel());
		a5(new CheckBox());
		k(new GroupBox());
		ap(new TableLayoutPanel());
		aa(new Button());
		bj(new hy());
		aw(new hy());
		ct(new Label());
		b1(new Label());
		u(new Button());
		ax(new hy());
		b2(new Label());
		ay(new hy());
		b3(new Label());
		a(new GroupBox());
		a(new CheckBox());
		d(new TableLayoutPanel());
		a(new hy());
		b(new Label());
		b(new ComboBox());
		f(new Label());
		c(new Label());
		b(new hy());
		e(new Label());
		d(new Label());
		ap(new CheckBox());
		b(new TabControl());
		c(new TabPage());
		h(new TableLayoutPanel());
		g(new hy());
		h(new hy());
		o(new Label());
		p(new Label());
		d(new Button());
		d(new TabPage());
		i(new TableLayoutPanel());
		f(new Button());
		k(new TableLayoutPanel());
		j(new hy());
		z(new Label());
		k(new hy());
		l(new hy());
		m(new hy());
		n(new hy());
		o(new hy());
		p(new hy());
		q(new hy());
		r(new hy());
		s(new hy());
		t(new hy());
		e(new Button());
		j(new TableLayoutPanel());
		i(new hy());
		x(new Label());
		y(new Label());
		q(new Label());
		r(new Label());
		s(new Label());
		t(new Label());
		u(new Label());
		v(new Label());
		w(new Label());
		o(new TableLayoutPanel());
		o(new GroupBox());
		a1(new TableLayoutPanel());
		bq(new hy());
		c3(new Label());
		n(new GroupBox());
		a0(new TableLayoutPanel());
		bl(new hy());
		cu(new Label());
		bk(new hy());
		cv(new Label());
		l(new GroupBox());
		aw(new TableLayoutPanel());
		ak(new CheckBox());
		a7(new hy());
		ch(new Label());
		x(new Button());
		d(new GroupBox());
		l(new TableLayoutPanel());
		g(new Button());
		aa(new Label());
		u(new hy());
		e(new GroupBox());
		m(new TableLayoutPanel());
		v(new hy());
		w(new hy());
		ab(new Label());
		ac(new Label());
		h(new Button());
		ad(new Label());
		x(new hy());
		j(new GroupBox());
		ak(new TableLayoutPanel());
		bp(new Label());
		bq(new Label());
		br(new Label());
		an(new hy());
		ao(new hy());
		ap(new hy());
		f(new GroupBox());
		n(new TableLayoutPanel());
		y(new hy());
		z(new hy());
		i(new Button());
		ae(new Label());
		af(new Label());
		b(new Button());
		c(new ComboBox());
		m(new Label());
		e(new TableLayoutPanel());
		j(new Label());
		b(new TextBox());
		a(new TextBox());
		l(new Label());
		k(new Label());
		a(new hx());
		b(new GroupBox());
		c(new TableLayoutPanel());
		ad(new Button());
		w(new Button());
		o(new ComboBox());
		d(new TabControl());
		i(new TabPage());
		at(new TableLayoutPanel());
		bm(new hy());
		bn(new hy());
		cw(new Label());
		cx(new Label());
		a0(new hy());
		ca(new Label());
		c(new hy());
		i(new Label());
		e(new hy());
		g(new Label());
		h(new Label());
		d(new hy());
		j(new TabPage());
		au(new TableLayoutPanel());
		bo(new hy());
		bp(new hy());
		cy(new Label());
		cz(new Label());
		a1(new hy());
		cb(new Label());
		a2(new hy());
		cc(new Label());
		a3(new hy());
		cd(new Label());
		ce(new Label());
		a4(new hy());
		aj(new CheckBox());
		c(new GroupBox());
		al(new TableLayoutPanel());
		c(new Button());
		c(new TabControl());
		g(new TabPage());
		ax(new TableLayoutPanel());
		ba(new hy());
		ck(new Label());
		bb(new hy());
		cl(new Label());
		bc(new hy());
		bd(new hy());
		be(new hy());
		bf(new hy());
		bg(new hy());
		cm(new Label());
		cn(new Label());
		co(new Label());
		cp(new Label());
		cq(new Label());
		cr(new Label());
		bh(new hy());
		bi(new hy());
		cs(new Label());
		k(new TabPage());
		av(new TableLayoutPanel());
		y(new Button());
		a9(new hy());
		cj(new Label());
		a5(new hy());
		cf(new Label());
		cg(new Label());
		a6(new hy());
		h(new TabPage());
		am(new TableLayoutPanel());
		an(new TableLayoutPanel());
		bw(new Label());
		bx(new Label());
		at(new hy());
		au(new hy());
		aj(new TableLayoutPanel());
		bm(new Label());
		bn(new Label());
		bo(new Label());
		ak(new hy());
		al(new hy());
		am(new hy());
		bs(new Label());
		bt(new Label());
		bu(new Label());
		aq(new hy());
		ar(new hy());
		@as(new hy());
		m(new GroupBox());
		a(new RadioButton());
		b(new RadioButton());
		g(new TableLayoutPanel());
		b(new CheckBox());
		f(new hy());
		n(new Label());
		f(new TabPage());
		ae(new TableLayoutPanel());
		h(new GroupBox());
		ai(new TableLayoutPanel());
		t(new Button());
		b(new ListBox());
		i(new GroupBox());
		ag(new TableLayoutPanel());
		a(new ListBox());
		af(new TableLayoutPanel());
		s(new Button());
		r(new Button());
		q(new Button());
		ah(new TableLayoutPanel());
		bh(new Label());
		l(new ComboBox());
		e(new TabPage());
		aa(new TableLayoutPanel());
		p(new Button());
		k(new ComboBox());
		bb(new Label());
		ab(new TableLayoutPanel());
		bc(new Label());
		e(new TextBox());
		f(new TextBox());
		bd(new Label());
		be(new Label());
		d(new hx());
		g(new GroupBox());
		ac(new TableLayoutPanel());
		m(new ComboBox());
		bl(new Label());
		ah(new hy());
		ai(new hy());
		bi(new Label());
		bj(new Label());
		aj(new hy());
		bk(new Label());
		bf(new Label());
		ad(new TableLayoutPanel());
		ab(new CheckBox());
		ag(new hy());
		bg(new Label());
		b9(new Label());
		a(new ToolTip(this.m_a));
		a(new System.Windows.Forms.Timer(this.m_a));
		p(new GroupBox());
		a2(new TableLayoutPanel());
		br(new hy());
		c4(new Label());
		an().SuspendLayout();
		ks().SuspendLayout();
		ap().SuspendLayout();
		ao().SuspendLayout();
		bo().SuspendLayout();
		ky().SuspendLayout();
		k3().SuspendLayout();
		ew().SuspendLayout();
		fl().SuspendLayout();
		im().SuspendLayout();
		e1().SuspendLayout();
		en().SuspendLayout();
		ii().SuspendLayout();
		kp().SuspendLayout();
		d2().SuspendLayout();
		ep().SuspendLayout();
		em().SuspendLayout();
		@is().SuspendLayout();
		ex().SuspendLayout();
		fh().SuspendLayout();
		fv().SuspendLayout();
		ey().SuspendLayout();
		ba().SuspendLayout();
		kz().SuspendLayout();
		bj().SuspendLayout();
		h7().SuspendLayout();
		h9().SuspendLayout();
		ia().SuspendLayout();
		ar().SuspendLayout();
		a9().SuspendLayout();
		bt().SuspendLayout();
		bu().SuspendLayout();
		bv().SuspendLayout();
		by().SuspendLayout();
		b2().SuspendLayout();
		ce().SuspendLayout();
		ca().SuspendLayout();
		de().SuspendLayout();
		l3().SuspendLayout();
		l4().SuspendLayout();
		k4().SuspendLayout();
		k5().SuspendLayout();
		jm().SuspendLayout();
		jn().SuspendLayout();
		ct().SuspendLayout();
		cu().SuspendLayout();
		cy().SuspendLayout();
		cz().SuspendLayout();
		hf().SuspendLayout();
		hg().SuspendLayout();
		dd().SuspendLayout();
		c7().SuspendLayout();
		bi().SuspendLayout();
		a1().SuspendLayout();
		a8().SuspendLayout();
		iz().SuspendLayout();
		i0().SuspendLayout();
		i1().SuspendLayout();
		i2().SuspendLayout();
		i6().SuspendLayout();
		bk().SuspendLayout();
		ht().SuspendLayout();
		g5().SuspendLayout();
		g6().SuspendLayout();
		j5().SuspendLayout();
		jg().SuspendLayout();
		jh().SuspendLayout();
		g7().SuspendLayout();
		hv().SuspendLayout();
		hw().SuspendLayout();
		g8().SuspendLayout();
		j2().SuspendLayout();
		bp().SuspendLayout();
		gg().SuspendLayout();
		gh().SuspendLayout();
		gp().SuspendLayout();
		gv().SuspendLayout();
		gq().SuspendLayout();
		gr().SuspendLayout();
		gm().SuspendLayout();
		gs().SuspendLayout();
		fx().SuspendLayout();
		fy().SuspendLayout();
		f2().SuspendLayout();
		f9().SuspendLayout();
		ga().SuspendLayout();
		gc().SuspendLayout();
		l9().SuspendLayout();
		ma().SuspendLayout();
		SuspendLayout();
		al().Anchor = AnchorStyles.None;
		al().AutoSize = true;
		al().DialogResult = DialogResult.OK;
		al().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		al().Location = new Point(420, 3);
		al().Name = "ButtonClose";
		al().Size = new Size(60, 28);
		al().TabIndex = 12;
		al().Text = "Close";
		am().Anchor = AnchorStyles.Left | AnchorStyles.Right;
		am().AutoSize = true;
		am().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		am().Location = new Point(4, 7);
		am().Margin = new Padding(4, 0, 4, 0);
		am().Name = "Label9";
		am().Size = new Size(78, 16);
		am().TabIndex = 28;
		am().Text = "Subsystem:";
		am().TextAlign = ContentAlignment.MiddleRight;
		an().AutoSize = true;
		an().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		an().ColumnCount = 1;
		an().ColumnStyles.Add(new ColumnStyle());
		an().Controls.Add(ks(), 0, 3);
		an().Controls.Add(ap(), 0, 0);
		an().Controls.Add(ao(), 0, 1);
		an().Controls.Add(iw(), 0, 2);
		an().Location = new Point(6, 6);
		an().Name = "TableLayoutPanelOuter";
		an().RowCount = 4;
		an().RowStyles.Add(new RowStyle());
		an().RowStyles.Add(new RowStyle());
		an().RowStyles.Add(new RowStyle());
		an().RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
		an().Size = new Size(906, 998);
		an().TabIndex = 30;
		ks().AutoSize = true;
		ks().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ks().ColumnCount = 3;
		ks().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333f));
		ks().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333f));
		ks().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333f));
		ks().Controls.Add(kt(), 0, 0);
		ks().Controls.Add(al(), 1, 0);
		ks().Dock = DockStyle.Fill;
		ks().Location = new Point(3, 961);
		ks().Name = "TableLayoutPanel1";
		ks().RowCount = 1;
		ks().RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		ks().Size = new Size(900, 34);
		ks().TabIndex = 31;
		kt().Anchor = AnchorStyles.None;
		kt().AutoSize = true;
		kt().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		kt().Location = new Point(79, 3);
		kt().Name = "ButtonInit1021Copy";
		kt().Size = new Size(141, 28);
		kt().TabIndex = 13;
		kt().Text = "Motor Firmware...";
		kt().Visible = false;
		ap().Anchor = AnchorStyles.None;
		ap().AutoSize = true;
		ap().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ap().ColumnCount = 2;
		ap().ColumnStyles.Add(new ColumnStyle());
		ap().ColumnStyles.Add(new ColumnStyle());
		ap().Controls.Add(am(), 0, 0);
		ap().Controls.Add(aq(), 1, 0);
		ap().Location = new Point(297, 3);
		ap().Name = "TLPSubsystemSelect";
		ap().RowCount = 1;
		ap().RowStyles.Add(new RowStyle());
		ap().Size = new Size(312, 30);
		ap().TabIndex = 0;
		ap().Visible = false;
		aq().Anchor = AnchorStyles.Left;
		aq().DropDownStyle = ComboBoxStyle.DropDownList;
		aq().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aq().FormattingEnabled = true;
		aq().Location = new Point(89, 3);
		aq().Name = "ComboBoxSubModule";
		aq().Size = new Size(220, 24);
		aq().TabIndex = 29;
		ao().Controls.Add(bo());
		ao().Controls.Add(ba());
		ao().Controls.Add(gg());
		ao().Controls.Add(fx());
		ao().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ao().Location = new Point(3, 39);
		ao().Name = "TabControlSpecOrController";
		ao().SelectedIndex = 0;
		ao().Size = new Size(900, 900);
		ao().TabIndex = 30;
		bo().Controls.Add(ky());
		bo().Location = new Point(4, 25);
		bo().Name = "TabPageController";
		bo().Size = new Size(892, 871);
		bo().TabIndex = 1;
		bo().Text = "Controller";
		bo().UseVisualStyleBackColor = true;
		ky().AutoSize = true;
		ky().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ky().Controls.Add(k3());
		ky().Location = new Point(0, 0);
		ky().Name = "PanelControllerPage";
		ky().Size = new Size(908, 951);
		ky().TabIndex = 0;
		k3().AutoSize = true;
		k3().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		k3().ColumnCount = 1;
		k3().ColumnStyles.Add(new ColumnStyle());
		k3().Controls.Add(ew(), 0, 1);
		k3().Controls.Add(ey(), 0, 0);
		k3().Location = new Point(0, 0);
		k3().Name = "TLPControllerOverall";
		k3().RowCount = 2;
		k3().RowStyles.Add(new RowStyle());
		k3().RowStyles.Add(new RowStyle());
		k3().Size = new Size(905, 948);
		k3().TabIndex = 47;
		ew().AutoSize = true;
		ew().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ew().ColumnCount = 2;
		ew().ColumnStyles.Add(new ColumnStyle());
		ew().ColumnStyles.Add(new ColumnStyle());
		ew().Controls.Add(fl(), 0, 3);
		ew().Controls.Add(e1(), 1, 4);
		ew().Controls.Add(en(), 1, 0);
		ew().Controls.Add(d2(), 1, 5);
		ew().Controls.Add(ep(), 0, 0);
		ew().Controls.Add(em(), 0, 2);
		ew().Controls.Add(ex(), 0, 1);
		ew().Controls.Add(fh(), 0, 4);
		ew().Controls.Add(fv(), 0, 5);
		ew().Location = new Point(3, 39);
		ew().Name = "TLPController";
		ew().RowCount = 6;
		ew().RowStyles.Add(new RowStyle());
		ew().RowStyles.Add(new RowStyle());
		ew().RowStyles.Add(new RowStyle());
		ew().RowStyles.Add(new RowStyle());
		ew().RowStyles.Add(new RowStyle());
		ew().RowStyles.Add(new RowStyle());
		ew().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		ew().Size = new Size(899, 906);
		ew().TabIndex = 45;
		fl().Anchor = AnchorStyles.None;
		fl().AutoSize = true;
		fl().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		fl().ColumnCount = 2;
		fl().ColumnStyles.Add(new ColumnStyle());
		fl().ColumnStyles.Add(new ColumnStyle());
		fl().Controls.Add(lz(), 1, 6);
		fl().Controls.Add(kx(), 1, 5);
		fl().Controls.Add(iy(), 1, 3);
		fl().Controls.Add(iq(), 1, 8);
		fl().Controls.Add(ir(), 0, 8);
		fl().Controls.Add(ik(), 1, 7);
		fl().Controls.Add(ij(), 0, 7);
		fl().Controls.Add(h5(), 1, 2);
		fl().Controls.Add(h6(), 0, 2);
		fl().Controls.Add(hu(), 0, 0);
		fl().Controls.Add(fj(), 1, 1);
		fl().Controls.Add(fk(), 0, 1);
		fl().Controls.Add(im(), 0, 9);
		fl().Controls.Add(j1(), 1, 4);
		fl().Location = new Point(42, 390);
		fl().Name = "TLPHardwareDetails";
		fl().RowCount = 10;
		fl().RowStyles.Add(new RowStyle());
		fl().RowStyles.Add(new RowStyle());
		fl().RowStyles.Add(new RowStyle());
		fl().RowStyles.Add(new RowStyle());
		fl().RowStyles.Add(new RowStyle());
		fl().RowStyles.Add(new RowStyle());
		fl().RowStyles.Add(new RowStyle());
		fl().RowStyles.Add(new RowStyle());
		fl().RowStyles.Add(new RowStyle());
		fl().RowStyles.Add(new RowStyle());
		fl().Size = new Size(320, 264);
		fl().TabIndex = 31;
		lz().Anchor = AnchorStyles.Left;
		lz().AutoSize = true;
		lz().Location = new Point(162, 151);
		lz().Name = "CheckBoxLowPowerLSSoftPowerup";
		lz().Size = new Size(108, 20);
		lz().TabIndex = 58;
		lz().Text = "Soft power up";
		gu().SetToolTip(lz(), "All new systems should have this setting turned on.\r\nWe added it so that we would only use it on new systems\r\nbecause the soft power up function cannot be thoroughly\r\ntested on all old systems.");
		lz().UseVisualStyleBackColor = true;
		kx().Anchor = AnchorStyles.Left;
		kx().AutoSize = true;
		kx().Location = new Point(162, 125);
		kx().Name = "CheckBoxNeonOnly";
		kx().Size = new Size(90, 20);
		kx().TabIndex = 57;
		kx().Text = "Neon Only";
		kx().UseVisualStyleBackColor = true;
		iy().AutoSize = true;
		iy().Location = new Point(162, 73);
		iy().Name = "CheckBoxDisableHighVoltage";
		iy().Size = new Size(155, 20);
		iy().TabIndex = 55;
		iy().Text = "Disable High Voltage";
		iy().UseVisualStyleBackColor = true;
		iq().AutoSize = true;
		iq().Location = new Point(162, 203);
		iq().Name = "CheckBoxRealTimeClock";
		iq().Size = new Size(73, 20);
		iq().TabIndex = 53;
		iq().Text = "Present";
		iq().UseVisualStyleBackColor = true;
		ir().Anchor = AnchorStyles.Right;
		ir().AutoSize = true;
		ir().Location = new Point(6, 205);
		ir().Name = "LabelRTC";
		ir().Size = new Size(150, 16);
		ir().TabIndex = 34;
		ir().Text = "Real Time Clock (RTC):";
		ik().AutoSize = true;
		ik().Location = new Point(162, 177);
		ik().Name = "CheckBoxFan";
		ik().Size = new Size(73, 20);
		ik().TabIndex = 52;
		ik().Text = "Present";
		ik().UseVisualStyleBackColor = true;
		ij().Anchor = AnchorStyles.Right;
		ij().AutoSize = true;
		ij().Location = new Point(9, 179);
		ij().Name = "LabelSWControlledFan";
		ij().Size = new Size(147, 16);
		ij().TabIndex = 33;
		ij().Text = "Software-controlled fan:";
		h5().AutoSize = true;
		h5().Location = new Point(162, 47);
		h5().Name = "CheckBoxLowPowLSRequired";
		h5().Size = new Size(83, 20);
		h5().TabIndex = 51;
		h5().Text = "Required";
		h5().UseVisualStyleBackColor = true;
		h6().Anchor = AnchorStyles.Right;
		h6().AutoSize = true;
		h6().Location = new Point(3, 75);
		h6().Name = "LabelLowPowLS";
		fl().SetRowSpan(h6(), 3);
		h6().Size = new Size(153, 16);
		h6().TabIndex = 32;
		h6().Text = "Low Power Light Source:";
		hu().Anchor = AnchorStyles.Left;
		hu().AutoSize = true;
		hu().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		hu().Location = new Point(3, 0);
		hu().Name = "Label79";
		hu().Size = new Size(132, 16);
		hu().TabIndex = 44;
		hu().Text = "Hardware Details:";
		fj().Anchor = AnchorStyles.Left;
		fj().Location = new Point(159, 19);
		fj().Margin = new Padding(0, 3, 3, 3);
		fj().Name = "TextBoxParentSN";
		fj().Size = new Size(107, 22);
		fj().TabIndex = 31;
		fj().e(A_0: false);
		fk().Anchor = AnchorStyles.Right;
		fk().AutoSize = true;
		fk().Location = new Point(17, 22);
		fk().Name = "LabelParentSN";
		fk().Size = new Size(139, 16);
		fk().TabIndex = 31;
		fk().Text = "Parent Serial Number:";
		im().Anchor = AnchorStyles.None;
		im().AutoSize = true;
		im().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		im().ColumnCount = 3;
		fl().SetColumnSpan(im(), 2);
		im().ColumnStyles.Add(new ColumnStyle());
		im().ColumnStyles.Add(new ColumnStyle());
		im().ColumnStyles.Add(new ColumnStyle());
		im().Controls.Add(@in(), 2, 0);
		im().Controls.Add(io(), 1, 0);
		im().Controls.Add(ip(), 0, 0);
		im().Location = new Point(51, 229);
		im().Name = "TableLayoutPanelRTC";
		im().RowCount = 1;
		im().RowStyles.Add(new RowStyle());
		im().Size = new Size(217, 32);
		im().TabIndex = 31;
		@in().Anchor = AnchorStyles.None;
		@in().AutoSize = true;
		@in().Location = new Point(151, 3);
		@in().Name = "ButtonUpdateRealTimeClock";
		@in().Size = new Size(63, 26);
		@in().TabIndex = 32;
		@in().Text = "Update";
		@in().UseVisualStyleBackColor = true;
		io().Anchor = AnchorStyles.Right;
		io().AutoSize = true;
		io().BorderStyle = BorderStyle.FixedSingle;
		io().Location = new Point(80, 7);
		io().Name = "LabelRTCDate";
		io().Size = new Size(65, 18);
		io().TabIndex = 36;
		io().Text = "Unknown";
		ip().Anchor = AnchorStyles.Right;
		ip().AutoSize = true;
		ip().Location = new Point(3, 8);
		ip().Name = "LabelRTCDateLabel";
		ip().Size = new Size(71, 16);
		ip().TabIndex = 35;
		ip().Text = "RTC Date:";
		j1().Anchor = AnchorStyles.Left;
		j1().AutoSize = true;
		j1().Location = new Point(162, 99);
		j1().Name = "CheckBoxIRSourceOnly";
		j1().Size = new Size(116, 20);
		j1().TabIndex = 56;
		j1().Text = "IR Source Only";
		j1().UseVisualStyleBackColor = true;
		e1().Anchor = AnchorStyles.None;
		e1().AutoSize = true;
		e1().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		e1().ColumnCount = 3;
		e1().ColumnStyles.Add(new ColumnStyle());
		e1().ColumnStyles.Add(new ColumnStyle());
		e1().ColumnStyles.Add(new ColumnStyle());
		e1().Controls.Add(il(), 1, 2);
		e1().Controls.Add(e2(), 0, 0);
		e1().Controls.Add(e3(), 2, 1);
		e1().Controls.Add(e5(), 0, 2);
		e1().Controls.Add(e6(), 0, 1);
		e1().Controls.Add(e7(), 1, 1);
		e1().Controls.Add(e4(), 2, 2);
		e1().Location = new Point(515, 748);
		e1().Name = "TLPHubEEPROM";
		e1().RowCount = 3;
		e1().RowStyles.Add(new RowStyle());
		e1().RowStyles.Add(new RowStyle());
		e1().RowStyles.Add(new RowStyle());
		e1().Size = new Size(272, 86);
		e1().TabIndex = 50;
		il().Anchor = AnchorStyles.None;
		il().DropDownStyle = ComboBoxStyle.DropDownList;
		il().Enabled = false;
		il().FormattingEnabled = true;
		il().Location = new Point(57, 59);
		il().Name = "ComboBoxHubType";
		il().Size = new Size(143, 24);
		il().TabIndex = 31;
		e2().Anchor = AnchorStyles.Left;
		e2().AutoSize = true;
		e1().SetColumnSpan(e2(), 3);
		e2().Location = new Point(3, 0);
		e2().Name = "Label47";
		e2().Padding = new Padding(0, 6, 0, 0);
		e2().Size = new Size(94, 22);
		e2().TabIndex = 44;
		e2().Text = "Hub EEPROM";
		e3().Anchor = AnchorStyles.None;
		e3().AutoSize = true;
		e3().Location = new Point(209, 25);
		e3().Name = "ButtonCheckForHubEEPROM";
		e3().Size = new Size(56, 26);
		e3().TabIndex = 46;
		e3().Text = "Check";
		e3().UseVisualStyleBackColor = true;
		e5().Anchor = AnchorStyles.Right;
		e5().AutoSize = true;
		e5().Location = new Point(9, 62);
		e5().Name = "Label62";
		e5().Size = new Size(42, 16);
		e5().TabIndex = 51;
		e5().Text = "Write:";
		e6().Anchor = AnchorStyles.Right;
		e6().AutoSize = true;
		e6().Location = new Point(3, 30);
		e6().Name = "Label61";
		e6().Size = new Size(48, 16);
		e6().TabIndex = 48;
		e6().Text = "Status:";
		e7().Anchor = AnchorStyles.None;
		e7().AutoSize = true;
		e7().Location = new Point(97, 30);
		e7().Name = "LabelHubEEPROMStatus";
		e7().Size = new Size(63, 16);
		e7().TabIndex = 49;
		e7().Text = "Unknown";
		e4().Anchor = AnchorStyles.None;
		e4().AutoSize = true;
		e4().Enabled = false;
		e4().Location = new Point(206, 57);
		e4().Name = "ButtonWriteHubEEPROM";
		e4().Size = new Size(63, 26);
		e4().TabIndex = 47;
		e4().Text = "Update";
		e4().UseVisualStyleBackColor = true;
		en().AutoSize = true;
		en().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		en().ColumnCount = 3;
		en().ColumnStyles.Add(new ColumnStyle());
		en().ColumnStyles.Add(new ColumnStyle());
		en().ColumnStyles.Add(new ColumnStyle());
		en().Controls.Add(l7(), 1, 8);
		en().Controls.Add(l2(), 0, 8);
		en().Controls.Add(lu(), 1, 22);
		en().Controls.Add(lq(), 0, 21);
		en().Controls.Add(lt(), 0, 22);
		en().Controls.Add(lo(), 1, 20);
		en().Controls.Add(ls(), 2, 21);
		en().Controls.Add(lk(), 0, 20);
		en().Controls.Add(lr(), 1, 21);
		en().Controls.Add(ll(), 0, 19);
		en().Controls.Add(j0(), 0, 14);
		en().Controls.Add(h2(), 1, 13);
		en().Controls.Add(h1(), 0, 13);
		en().Controls.Add(eo(), 1, 5);
		en().Controls.Add(d1(), 0, 0);
		en().Controls.Add(d0(), 0, 9);
		en().Controls.Add(dv(), 1, 3);
		en().Controls.Add(eh(), 0, 1);
		en().Controls.Add(dx(), 0, 3);
		en().Controls.Add(dw(), 1, 2);
		en().Controls.Add(d9(), 1, 1);
		en().Controls.Add(dy(), 0, 2);
		en().Controls.Add(ea(), 0, 4);
		en().Controls.Add(ee(), 1, 4);
		en().Controls.Add(eg(), 0, 10);
		en().Controls.Add(ef(), 1, 10);
		en().Controls.Add(d7(), 0, 5);
		en().Controls.Add(fm(), 0, 16);
		en().Controls.Add(fn(), 0, 17);
		en().Controls.Add(fo(), 0, 18);
		en().Controls.Add(fp(), 1, 17);
		en().Controls.Add(fq(), 1, 18);
		en().Controls.Add(fw(), 0, 6);
		en().Controls.Add(h3(), 0, 11);
		en().Controls.Add(h4(), 1, 6);
		en().Controls.Add(iv(), 1, 14);
		en().Controls.Add(ku(), 0, 15);
		en().Controls.Add(kv(), 1, 15);
		en().Controls.Add(ii(), 0, 23);
		en().Controls.Add(lp(), 2, 1);
		en().Controls.Add(d6(), 2, 2);
		en().Controls.Add(jz(), 2, 3);
		en().Controls.Add(ln(), 2, 4);
		en().Controls.Add(js(), 2, 5);
		en().Controls.Add(fs(), 2, 6);
		en().Controls.Add(kw(), 2, 14);
		en().Controls.Add(lm(), 2, 20);
		en().Controls.Add(li(), 2, 15);
		en().Controls.Add(lj(), 2, 22);
		en().Controls.Add(kp(), 0, 7);
		en().Controls.Add(lx(), 1, 12);
		en().Controls.Add(ly(), 0, 12);
		en().Controls.Add(l0(), 2, 7);
		en().Controls.Add(l1(), 2, 17);
		en().Location = new Point(407, 3);
		en().Name = "TLPConOptions";
		en().RowCount = 24;
		ew().SetRowSpan(en(), 4);
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().RowStyles.Add(new RowStyle());
		en().Size = new Size(489, 731);
		en().TabIndex = 31;
		l7().AutoSize = true;
		l7().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		l7().Location = new Point(156, 204);
		l7().Name = "CheckBoxPermitAutoWavelenCal";
		l7().Size = new Size(178, 20);
		l7().TabIndex = 62;
		l7().Text = "Permit Auto Wavelen Cal.";
		l7().UseVisualStyleBackColor = true;
		l2().AutoSize = true;
		l2().Location = new Point(3, 204);
		l2().Name = "CheckBoxMotionInterlock";
		l2().Size = new Size(120, 20);
		l2().TabIndex = 77;
		l2().Text = "Motion interlock";
		l2().UseVisualStyleBackColor = true;
		lu().Anchor = AnchorStyles.Left;
		lu().AutoSize = true;
		lu().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lu().Location = new Point(156, 568);
		lu().Name = "CheckBoxHasDetailedF6XSettings";
		lu().Size = new Size(183, 20);
		lu().TabIndex = 73;
		lu().Text = "Has Detailed F6X Settings";
		lu().UseVisualStyleBackColor = true;
		lq().Anchor = AnchorStyles.Left;
		lq().AutoSize = true;
		lq().Location = new Point(3, 534);
		lq().Name = "CheckBoxHasInletVacuumValve";
		lq().Size = new Size(141, 20);
		lq().TabIndex = 69;
		lq().Text = "Inlet Vacuum Valve";
		lq().UseVisualStyleBackColor = true;
		lt().Anchor = AnchorStyles.Left;
		lt().AutoSize = true;
		lt().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lt().Location = new Point(3, 560);
		lt().Name = "CheckBoxHasSpecForNotchFlatFind";
		lt().Size = new Size(126, 36);
		lt().TabIndex = 72;
		lt().Text = "Spectrometer for\r\nNotch/Flat Find";
		lt().UseVisualStyleBackColor = true;
		lo().Anchor = AnchorStyles.Left;
		lo().AutoSize = true;
		lo().Location = new Point(156, 505);
		lo().Name = "CheckBoxHasPrealigner";
		lo().Size = new Size(89, 20);
		lo().TabIndex = 68;
		lo().Text = "Prealigner";
		lo().UseVisualStyleBackColor = true;
		ls().Anchor = AnchorStyles.Left;
		ls().AutoSize = true;
		ls().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ls().Location = new Point(345, 534);
		ls().Name = "CheckBoxHasLED";
		ls().Size = new Size(53, 20);
		ls().TabIndex = 71;
		ls().Text = "LED";
		ls().UseVisualStyleBackColor = true;
		lk().Anchor = AnchorStyles.Left;
		lk().AutoSize = true;
		lk().Location = new Point(3, 505);
		lk().Name = "CheckBoxCassetteReader";
		lk().Size = new Size(128, 20);
		lk().TabIndex = 67;
		lk().Text = "Barcode Reader";
		lk().UseVisualStyleBackColor = true;
		lr().Anchor = AnchorStyles.Left;
		lr().AutoSize = true;
		lr().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lr().Location = new Point(156, 534);
		lr().Name = "CheckBoxHasKnifeEdge";
		lr().Size = new Size(92, 20);
		lr().TabIndex = 70;
		lr().Text = "Knife Edge";
		lr().UseVisualStyleBackColor = true;
		ll().AutoSize = true;
		ll().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ll().Location = new Point(3, 483);
		ll().Name = "LabelF60Options";
		ll().Size = new Size(94, 16);
		ll().TabIndex = 58;
		ll().Text = "F60 Options:";
		ll().Visible = false;
		j0().AutoSize = true;
		j0().Location = new Point(3, 362);
		j0().Name = "CheckBoxMicropositioner";
		j0().Size = new Size(119, 20);
		j0().TabIndex = 32;
		j0().Text = "Micropositioner";
		j0().UseVisualStyleBackColor = true;
		j0().Visible = false;
		h2().Anchor = AnchorStyles.Left;
		h2().f(A_0: false);
		h2().Location = new Point(156, 334);
		h2().Name = "TextNumLimitCenterDist";
		h2().e(A_0: false);
		h2().Size = new Size(101, 22);
		h2().TabIndex = 46;
		h2().Text = "0";
		h2().Visible = false;
		h1().Anchor = AnchorStyles.Right;
		h1().AutoSize = true;
		h1().Location = new Point(17, 337);
		h1().Name = "LabelLimitCenterDistance";
		h1().Size = new Size(133, 16);
		h1().TabIndex = 45;
		h1().Text = "Limit-center distance:";
		h1().Visible = false;
		eo().AutoSize = true;
		eo().Location = new Point(156, 123);
		eo().Name = "CheckBoxNKCauchy";
		eo().Size = new Size(121, 20);
		eo().TabIndex = 33;
		eo().Text = "NK Cauchy only";
		eo().UseVisualStyleBackColor = true;
		d1().AutoSize = true;
		d1().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		d1().Location = new Point(3, 0);
		d1().Name = "Label56";
		d1().Size = new Size(129, 16);
		d1().TabIndex = 43;
		d1().Text = "Common Options:";
		d0().AutoSize = true;
		d0().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		d0().Location = new Point(3, 227);
		d0().Name = "Label57";
		d0().Padding = new Padding(0, 6, 0, 0);
		d0().Size = new Size(94, 22);
		d0().TabIndex = 44;
		d0().Text = "F30 Options:";
		dv().AutoSize = true;
		dv().Location = new Point(156, 71);
		dv().Name = "CheckBoxF40UV";
		dv().Size = new Size(129, 20);
		dv().TabIndex = 49;
		dv().Text = "F40 UV spectrum";
		dv().UseVisualStyleBackColor = true;
		eh().AutoSize = true;
		eh().Location = new Point(3, 19);
		eh().Name = "CheckBoxLayerAttr";
		eh().Size = new Size(147, 20);
		eh().TabIndex = 27;
		eh().Text = "LayerAttr (thickness)";
		eh().UseVisualStyleBackColor = true;
		dx().AutoSize = true;
		dx().Location = new Point(3, 71);
		dx().Name = "CheckBoxCorr";
		dx().Size = new Size(92, 20);
		dx().TabIndex = 47;
		dx().Text = "Correlation";
		dx().UseVisualStyleBackColor = true;
		dw().AutoSize = true;
		dw().Location = new Point(156, 45);
		dw().Name = "CheckBoxF40Full";
		dw().Size = new Size(126, 20);
		dw().TabIndex = 48;
		dw().Text = "F40 full spectrum";
		dw().UseVisualStyleBackColor = true;
		d9().AutoSize = true;
		d9().Location = new Point(156, 19);
		d9().Name = "CheckBoxHighNAOptics";
		d9().Size = new Size(116, 20);
		d9().TabIndex = 37;
		d9().Text = "High NA optics";
		d9().UseVisualStyleBackColor = true;
		dy().AutoSize = true;
		dy().Location = new Point(3, 45);
		dy().Name = "CheckBoxFFT";
		dy().Size = new Size(139, 20);
		dy().TabIndex = 46;
		dy().Text = "FFT thickness only";
		dy().UseVisualStyleBackColor = true;
		ea().AutoSize = true;
		ea().Location = new Point(3, 97);
		ea().Name = "CheckBoxAR";
		ea().Size = new Size(145, 20);
		ea().TabIndex = 36;
		ea().Text = "AR (Spec. analysis)";
		ea().UseVisualStyleBackColor = true;
		ee().AutoSize = true;
		ee().Location = new Point(156, 97);
		ee().Name = "CheckBoxNK";
		ee().Size = new Size(96, 20);
		ee().TabIndex = 30;
		ee().Text = "Activate NK";
		ee().UseVisualStyleBackColor = true;
		eg().AutoSize = true;
		eg().Location = new Point(3, 252);
		eg().Name = "CheckBoxVsTime";
		eg().Size = new Size(74, 20);
		eg().TabIndex = 28;
		eg().Text = "VsTime";
		eg().UseVisualStyleBackColor = true;
		ef().AutoSize = true;
		ef().Location = new Point(156, 252);
		ef().Name = "CheckBoxVI";
		ef().Size = new Size(118, 20);
		ef().TabIndex = 29;
		ef().Text = "Virtual Interface";
		ef().UseVisualStyleBackColor = true;
		d7().AutoSize = true;
		d7().Location = new Point(3, 123);
		d7().Name = "CheckBoxColor";
		d7().Size = new Size(59, 20);
		d7().TabIndex = 39;
		d7().Text = "Color";
		d7().UseVisualStyleBackColor = true;
		fm().AutoSize = true;
		fm().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		fm().Location = new Point(3, 411);
		fm().Name = "LabelF50XYOptions";
		fm().Size = new Size(117, 16);
		fm().TabIndex = 51;
		fm().Text = "F50 XY Options:";
		fm().Visible = false;
		fn().AutoSize = true;
		fn().Location = new Point(10, 432);
		fn().Margin = new Padding(10, 5, 3, 0);
		fn().Name = "LabelXLimitToZeroOffset";
		fn().Size = new Size(128, 16);
		fn().TabIndex = 52;
		fn().Text = "XLimitToZeroOffset :";
		fn().Visible = false;
		fo().AutoSize = true;
		fo().Location = new Point(10, 460);
		fo().Margin = new Padding(10, 5, 3, 0);
		fo().Name = "LabelYLimitToZeroOffset";
		fo().Size = new Size(129, 16);
		fo().TabIndex = 53;
		fo().Text = "YLimitToZeroOffset :";
		fo().Visible = false;
		fp().f(A_0: false);
		fp().Location = new Point(156, 430);
		fp().Name = "txtNumericXOffset";
		fp().e(A_0: true);
		fp().Size = new Size(100, 22);
		fp().TabIndex = 54;
		fp().Text = "0";
		fp().Visible = false;
		fq().f(A_0: false);
		fq().Location = new Point(156, 458);
		fq().Name = "txtNumericYOffset";
		fq().e(A_0: false);
		fq().Size = new Size(100, 22);
		fq().TabIndex = 55;
		fq().Text = "0";
		fq().Visible = false;
		fw().AutoSize = true;
		fw().Location = new Point(3, 149);
		fw().Name = "CheckBoxProhibitNonCTMOptics";
		fw().Size = new Size(123, 20);
		fw().TabIndex = 56;
		fw().Text = "CTM optics only";
		fw().UseVisualStyleBackColor = true;
		h3().AutoSize = true;
		h3().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		h3().Location = new Point(3, 275);
		h3().Name = "LabelF50Options";
		h3().Size = new Size(94, 16);
		h3().TabIndex = 57;
		h3().Text = "F50 Options:";
		h3().Visible = false;
		h4().AutoSize = true;
		h4().Location = new Point(156, 149);
		h4().Name = "CheckBoxCalcNFromExtrema";
		h4().Size = new Size(118, 20);
		h4().TabIndex = 58;
		h4().Text = "N from Extrema";
		h4().UseVisualStyleBackColor = true;
		iv().AutoSize = true;
		iv().Location = new Point(156, 362);
		iv().Name = "CheckBoxStageIsThetaY";
		iv().Size = new Size(110, 20);
		iv().TabIndex = 46;
		iv().Text = "ThetaY Stage";
		iv().UseVisualStyleBackColor = true;
		iv().Visible = false;
		ku().AutoSize = true;
		ku().Location = new Point(3, 388);
		ku().Name = "CheckBoxHasPatternRec";
		ku().Size = new Size(100, 20);
		ku().TabIndex = 64;
		ku().Text = "Pattern Rec.";
		ku().UseVisualStyleBackColor = true;
		kv().AutoSize = true;
		kv().Location = new Point(156, 388);
		kv().Name = "CheckBoxHasNotchFlatFind";
		kv().Size = new Size(91, 20);
		kv().TabIndex = 65;
		kv().Text = "Notch Find";
		kv().UseVisualStyleBackColor = true;
		ii().AutoSize = true;
		ii().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ii().ColumnCount = 2;
		en().SetColumnSpan(ii(), 2);
		ii().ColumnStyles.Add(new ColumnStyle());
		ii().ColumnStyles.Add(new ColumnStyle());
		ii().Controls.Add(dz(), 0, 0);
		ii().Controls.Add(du(), 0, 4);
		ii().Controls.Add(ed(), 0, 1);
		ii().Controls.Add(d8(), 1, 1);
		ii().Controls.Add(ec(), 0, 2);
		ii().Controls.Add(eb(), 0, 3);
		ii().Location = new Point(3, 602);
		ii().Name = "TableLayoutPanelObsoleteOptions";
		ii().RowCount = 6;
		ii().RowStyles.Add(new RowStyle());
		ii().RowStyles.Add(new RowStyle());
		ii().RowStyles.Add(new RowStyle());
		ii().RowStyles.Add(new RowStyle());
		ii().RowStyles.Add(new RowStyle());
		ii().RowStyles.Add(new RowStyle());
		ii().Size = new Size(245, 126);
		ii().TabIndex = 59;
		ii().Visible = false;
		dz().AutoSize = true;
		ii().SetColumnSpan(dz(), 2);
		dz().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		dz().Location = new Point(3, 0);
		dz().Name = "Label58";
		dz().Padding = new Padding(0, 6, 0, 0);
		dz().Size = new Size(132, 22);
		dz().TabIndex = 45;
		dz().Text = "Obsolete Options:";
		du().AutoSize = true;
		du().Location = new Point(3, 103);
		du().Name = "CheckBoxDVD";
		du().Size = new Size(56, 20);
		du().TabIndex = 50;
		du().Text = "DVD";
		du().UseVisualStyleBackColor = true;
		ed().AutoSize = true;
		ed().Location = new Point(3, 25);
		ed().Name = "CheckBoxJESave";
		ed().Size = new Size(124, 20);
		ed().TabIndex = 33;
		ed().Text = "Jim Elman Save";
		ed().UseVisualStyleBackColor = true;
		d8().AutoSize = true;
		d8().Location = new Point(154, 25);
		d8().Name = "CheckBoxMultiLayer";
		d8().Size = new Size(88, 20);
		d8().TabIndex = 38;
		d8().Text = "MultiLayer";
		d8().UseVisualStyleBackColor = true;
		ec().AutoSize = true;
		ec().Location = new Point(3, 51);
		ec().Name = "CheckBoxSpecDep";
		ec().Size = new Size(145, 20);
		ec().TabIndex = 34;
		ec().Text = "Spectral Deposition";
		ec().UseVisualStyleBackColor = true;
		eb().AutoSize = true;
		eb().Location = new Point(3, 77);
		eb().Name = "CheckBoxFilter";
		eb().Size = new Size(56, 20);
		eb().TabIndex = 35;
		eb().Text = "Filter";
		eb().UseVisualStyleBackColor = true;
		lp().AutoSize = true;
		lp().Location = new Point(345, 19);
		lp().Name = "CheckBoxAdditionalRecipes";
		lp().Size = new Size(141, 20);
		lp().TabIndex = 63;
		lp().Text = "Additional Recipes";
		lp().UseVisualStyleBackColor = true;
		d6().AutoSize = true;
		d6().Location = new Point(345, 45);
		d6().Name = "CheckBoxOptoValues";
		d6().Size = new Size(101, 20);
		d6().TabIndex = 40;
		d6().Text = "Opto Values";
		d6().UseVisualStyleBackColor = true;
		jz().AutoSize = true;
		jz().Location = new Point(345, 71);
		jz().Name = "CheckBox2AxisBackplane";
		jz().Size = new Size(131, 20);
		jz().TabIndex = 62;
		jz().Text = "2-Axis Backplane";
		jz().UseVisualStyleBackColor = true;
		ln().AutoSize = true;
		ln().Location = new Point(345, 97);
		ln().Name = "CheckBoxCompositeRecipe";
		ln().Size = new Size(113, 20);
		ln().TabIndex = 61;
		ln().Text = "Comp. Recipe";
		ln().UseVisualStyleBackColor = true;
		js().AutoSize = true;
		js().Location = new Point(345, 123);
		js().Name = "CheckBoxNoOptics";
		js().Size = new Size(86, 20);
		js().TabIndex = 60;
		js().Text = "No Optics";
		js().UseVisualStyleBackColor = true;
		fs().AutoSize = true;
		fs().Location = new Point(345, 149);
		fs().Name = "CheckBoxXYStage";
		fs().Size = new Size(83, 20);
		fs().TabIndex = 61;
		fs().Text = "XY Stage";
		fs().UseVisualStyleBackColor = true;
		kw().AutoSize = true;
		kw().Location = new Point(345, 362);
		kw().Name = "CheckBoxPermit200mmWaferAdapter";
		kw().Size = new Size(121, 20);
		kw().TabIndex = 66;
		kw().Text = "200mm Adapter";
		kw().UseVisualStyleBackColor = true;
		lm().Anchor = AnchorStyles.None;
		lm().AutoSize = true;
		lm().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		lm().Location = new Point(367, 502);
		lm().Name = "ButtonLightTower";
		lm().Size = new Size(96, 26);
		lm().TabIndex = 52;
		lm().Text = "Light Tower...";
		lm().UseVisualStyleBackColor = true;
		li().Anchor = AnchorStyles.Left;
		li().AutoSize = true;
		li().Location = new Point(345, 388);
		li().Name = "CheckBoxMotorizedTurret";
		li().Size = new Size(124, 20);
		li().TabIndex = 66;
		li().Text = "Motorized Turret";
		li().UseVisualStyleBackColor = true;
		lj().Anchor = AnchorStyles.Left;
		lj().AutoSize = true;
		lj().Location = new Point(345, 568);
		lj().Name = "CheckBoxTipTiltFocus";
		lj().Size = new Size(109, 20);
		lj().TabIndex = 66;
		lj().Text = "Tip/Tilt Focus";
		lj().UseVisualStyleBackColor = true;
		kp().AutoSize = true;
		kp().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		en().SetColumnSpan(kp(), 2);
		kp().Controls.Add(kq());
		kp().Controls.Add(kr());
		kp().Controls.Add(ih());
		kp().Location = new Point(3, 175);
		kp().Name = "PanelZStage";
		kp().Size = new Size(281, 23);
		kp().TabIndex = 63;
		kq().AutoSize = true;
		kq().Checked = true;
		kq().Enabled = false;
		kq().Location = new Point(164, -1);
		kq().Name = "RadioButtonZStageNonAuto";
		kq().Size = new Size(114, 20);
		kq().TabIndex = 1;
		kq().TabStop = true;
		kq().Text = "Non-motorized";
		kq().UseVisualStyleBackColor = true;
		kr().AutoSize = true;
		kr().Enabled = false;
		kr().Location = new Point(75, -1);
		kr().Name = "RadioButtonZStageAuto";
		kr().Size = new Size(85, 20);
		kr().TabIndex = 0;
		kr().Text = "Motorized";
		kr().UseVisualStyleBackColor = true;
		ih().AutoSize = true;
		ih().Location = new Point(0, 0);
		ih().Name = "CheckBoxHasZStage";
		ih().Size = new Size(75, 20);
		ih().TabIndex = 31;
		ih().Text = "Z-Stage";
		ih().UseVisualStyleBackColor = true;
		lx().Anchor = AnchorStyles.Left;
		lx().DropDownStyle = ComboBoxStyle.DropDownList;
		lx().FormattingEnabled = true;
		lx().Items.AddRange(new object[2] { "Legacy", "Hiwin" });
		lx().Location = new Point(156, 300);
		lx().Name = "ComboBoxLinearActuatorType";
		lx().Size = new Size(96, 24);
		lx().TabIndex = 74;
		ly().Anchor = AnchorStyles.Right;
		ly().AutoSize = true;
		ly().Location = new Point(22, 303);
		ly().Name = "LabelLinearActuatorType";
		ly().Size = new Size(128, 16);
		ly().TabIndex = 75;
		ly().Text = "Linear actuator type:";
		ly().Visible = false;
		l0().AutoSize = true;
		l0().Location = new Point(345, 175);
		l0().Name = "CheckBoxZStageHasType2Motor";
		l0().Size = new Size(118, 20);
		l0().TabIndex = 76;
		l0().Text = "Type-2 Z Motor";
		l0().UseVisualStyleBackColor = true;
		l1().Anchor = AnchorStyles.None;
		l1().AutoSize = true;
		l1().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		l1().Location = new Point(359, 442);
		l1().Name = "ButtonCalibXYOffsets";
		en().SetRowSpan(l1(), 2);
		l1().Size = new Size(113, 26);
		l1().TabIndex = 77;
		l1().Text = "Calib XY Offsets";
		l1().UseVisualStyleBackColor = true;
		d2().Anchor = AnchorStyles.None;
		d2().AutoSize = true;
		d2().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		d2().ColumnCount = 2;
		d2().ColumnStyles.Add(new ColumnStyle());
		d2().ColumnStyles.Add(new ColumnStyle());
		d2().Controls.Add(d3(), 0, 1);
		d2().Controls.Add(d4(), 1, 0);
		d2().Controls.Add(d5(), 0, 0);
		d2().Location = new Point(563, 849);
		d2().Name = "TLPConFWRev";
		d2().RowCount = 2;
		d2().RowStyles.Add(new RowStyle());
		d2().RowStyles.Add(new RowStyle());
		d2().Size = new Size(177, 54);
		d2().TabIndex = 41;
		d3().Anchor = AnchorStyles.None;
		d3().AutoSize = true;
		d2().SetColumnSpan(d3(), 2);
		d3().Location = new Point(3, 31);
		d3().Name = "CheckBoxConFWUpdate";
		d3().Size = new Size(171, 20);
		d3().TabIndex = 37;
		d3().Text = "Update revision to latest";
		d3().UseVisualStyleBackColor = true;
		d4().Anchor = AnchorStyles.Left;
		d4().f(A_0: true);
		d4().Location = new Point(121, 3);
		d4().Margin = new Padding(0, 3, 3, 3);
		d4().Name = "TextBoxNumConFWRev";
		d4().e(A_0: false);
		d4().Size = new Size(35, 22);
		d4().TabIndex = 31;
		d5().Anchor = AnchorStyles.Right;
		d5().AutoSize = true;
		d5().Location = new Point(3, 6);
		d5().Margin = new Padding(3, 0, 2, 0);
		d5().Name = "Label55";
		d5().Size = new Size(116, 16);
		d5().TabIndex = 31;
		d5().Text = "Firmware revision:";
		ep().Anchor = AnchorStyles.None;
		ep().AutoSize = true;
		ep().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ep().ColumnCount = 4;
		ep().ColumnStyles.Add(new ColumnStyle());
		ep().ColumnStyles.Add(new ColumnStyle());
		ep().ColumnStyles.Add(new ColumnStyle());
		ep().ColumnStyles.Add(new ColumnStyle());
		ep().Controls.Add(eq(), 0, 0);
		ep().Controls.Add(er(), 3, 1);
		ep().Controls.Add(es(), 3, 0);
		ep().Controls.Add(et(), 2, 1);
		ep().Controls.Add(eu(), 2, 0);
		ep().Controls.Add(ev(), 1, 0);
		ep().Location = new Point(25, 3);
		ep().Name = "TLPConSNTimeDate";
		ep().RowCount = 2;
		ep().RowStyles.Add(new RowStyle());
		ep().RowStyles.Add(new RowStyle());
		ep().Size = new Size(354, 56);
		ep().TabIndex = 32;
		eq().Anchor = AnchorStyles.Right;
		eq().AutoSize = true;
		eq().Location = new Point(3, 20);
		eq().Margin = new Padding(3, 0, 2, 0);
		eq().Name = "Label45";
		ep().SetRowSpan(eq(), 2);
		eq().Size = new Size(94, 16);
		eq().TabIndex = 0;
		eq().Text = "Serial number:";
		er().Anchor = AnchorStyles.Left;
		er().Location = new Point(256, 31);
		er().Margin = new Padding(0, 3, 3, 3);
		er().Name = "TextBoxConTime";
		er().ReadOnly = true;
		er().Size = new Size(95, 22);
		er().TabIndex = 5;
		es().Anchor = AnchorStyles.Left;
		es().Location = new Point(256, 3);
		es().Margin = new Padding(0, 3, 3, 3);
		es().Name = "TextBoxConDate";
		es().ReadOnly = true;
		es().Size = new Size(95, 22);
		es().TabIndex = 4;
		et().Anchor = AnchorStyles.Right;
		et().AutoSize = true;
		et().Location = new Point(212, 34);
		et().Margin = new Padding(3, 0, 2, 0);
		et().Name = "Label59";
		et().Size = new Size(42, 16);
		et().TabIndex = 3;
		et().Text = "Time:";
		eu().Anchor = AnchorStyles.Right;
		eu().AutoSize = true;
		eu().Location = new Point(214, 6);
		eu().Margin = new Padding(3, 0, 2, 0);
		eu().Name = "Label60";
		eu().Size = new Size(40, 16);
		eu().TabIndex = 2;
		eu().Text = "Date:";
		ev().Anchor = AnchorStyles.Left;
		ev().Location = new Point(99, 17);
		ev().Margin = new Padding(0, 3, 3, 3);
		ev().Name = "TextBoxConSerialNum";
		ep().SetRowSpan(ev(), 2);
		ev().Size = new Size(107, 22);
		ev().TabIndex = 1;
		ev().e(A_0: false);
		em().Anchor = AnchorStyles.None;
		em().AutoSize = true;
		em().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		em().ColumnCount = 2;
		em().ColumnStyles.Add(new ColumnStyle());
		em().ColumnStyles.Add(new ColumnStyle());
		em().Controls.Add(@is(), 0, 4);
		em().Controls.Add(dq(), 0, 0);
		em().Controls.Add(dp(), 1, 0);
		em().Controls.Add(dn(), 0, 1);
		em().Controls.Add(dm(), 1, 1);
		em().Controls.Add(el(), 1, 6);
		em().Controls.Add(@do(), 0, 2);
		em().Controls.Add(dh(), 0, 6);
		em().Controls.Add(df(), 1, 5);
		em().Controls.Add(dl(), 1, 2);
		em().Controls.Add(di(), 0, 5);
		em().Controls.Add(dk(), 0, 3);
		em().Location = new Point(44, 103);
		em().Name = "TLPConSysCombos";
		em().RowCount = 7;
		em().RowStyles.Add(new RowStyle());
		em().RowStyles.Add(new RowStyle());
		em().RowStyles.Add(new RowStyle());
		em().RowStyles.Add(new RowStyle());
		em().RowStyles.Add(new RowStyle());
		em().RowStyles.Add(new RowStyle());
		em().RowStyles.Add(new RowStyle());
		em().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		em().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		em().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		em().Size = new Size(316, 202);
		em().TabIndex = 43;
		@is().Anchor = AnchorStyles.None;
		@is().AutoSize = true;
		@is().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		@is().ColumnCount = 4;
		em().SetColumnSpan(@is(), 2);
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().ColumnStyles.Add(new ColumnStyle());
		@is().Controls.Add(it(), 3, 0);
		@is().Controls.Add(iu(), 2, 0);
		@is().Controls.Add(dj(), 0, 0);
		@is().Controls.Add(dg(), 1, 0);
		@is().Location = new Point(16, 109);
		@is().Name = "TableLayoutPanel28";
		@is().RowCount = 1;
		@is().RowStyles.Add(new RowStyle());
		@is().Size = new Size(283, 30);
		@is().TabIndex = 31;
		it().f(A_0: true);
		it().Location = new Point(196, 3);
		it().Name = "TextBoxNumRefMatID";
		it().e(A_0: false);
		it().Size = new Size(84, 22);
		it().TabIndex = 49;
		it().Visible = false;
		iu().Anchor = AnchorStyles.Right;
		iu().AutoSize = true;
		iu().Location = new Point(166, 7);
		iu().Name = "LabelRefMatID";
		iu().Size = new Size(24, 16);
		iu().TabIndex = 31;
		iu().Text = "ID:";
		iu().Visible = false;
		dj().Anchor = AnchorStyles.Right;
		dj().AutoSize = true;
		dj().Location = new Point(3, 7);
		dj().Name = "LabelRefMat";
		dj().Size = new Size(60, 16);
		dj().TabIndex = 18;
		dj().Text = "Ref Mat.:";
		dg().Anchor = AnchorStyles.None;
		dg().DropDownStyle = ComboBoxStyle.DropDownList;
		dg().FormattingEnabled = true;
		dg().Location = new Point(69, 3);
		dg().Name = "ComboBoxConRefMat";
		dg().Size = new Size(91, 24);
		dg().TabIndex = 21;
		dq().Anchor = AnchorStyles.Right;
		dq().AutoSize = true;
		dq().Location = new Point(16, 7);
		dq().Name = "Label42";
		dq().Size = new Size(91, 16);
		dq().TabIndex = 5;
		dq().Text = "System Type:";
		dp().Anchor = AnchorStyles.None;
		dp().DropDownStyle = ComboBoxStyle.DropDownList;
		dp().FormattingEnabled = true;
		dp().Location = new Point(145, 3);
		dp().Name = "ComboBoxConSystemType";
		dp().Size = new Size(135, 24);
		dp().TabIndex = 6;
		dn().Anchor = AnchorStyles.Right;
		dn().AutoSize = true;
		dn().Location = new Point(66, 37);
		dn().Name = "Label44";
		dn().Size = new Size(41, 16);
		dn().TabIndex = 8;
		dn().Text = "OEM:";
		dm().Anchor = AnchorStyles.None;
		dm().DropDownStyle = ComboBoxStyle.DropDownList;
		dm().FormattingEnabled = true;
		dm().Location = new Point(123, 33);
		dm().Name = "ComboBoxConOem";
		dm().Size = new Size(180, 24);
		dm().TabIndex = 9;
		el().Anchor = AnchorStyles.None;
		el().DropDownStyle = ComboBoxStyle.DropDownList;
		el().FormattingEnabled = true;
		el().Location = new Point(121, 175);
		el().Name = "ComboBoxConOpticsConfig";
		el().Size = new Size(184, 24);
		el().TabIndex = 23;
		@do().Anchor = AnchorStyles.Right;
		@do().AutoSize = true;
		@do().Location = new Point(40, 67);
		@do().Name = "Label43";
		@do().Size = new Size(67, 16);
		@do().TabIndex = 7;
		@do().Text = "SubType:";
		dh().Anchor = AnchorStyles.Right;
		dh().AutoSize = true;
		dh().Location = new Point(17, 179);
		dh().Name = "LabelOpticsConfig";
		dh().Size = new Size(90, 16);
		dh().TabIndex = 20;
		dh().Text = "Optics Config:";
		df().Anchor = AnchorStyles.None;
		df().DropDownStyle = ComboBoxStyle.DropDownList;
		df().FormattingEnabled = true;
		df().Location = new Point(121, 145);
		df().Name = "ComboBoxConDefNumDispCurves";
		df().Size = new Size(184, 24);
		df().TabIndex = 22;
		dl().Anchor = AnchorStyles.None;
		dl().DropDownStyle = ComboBoxStyle.DropDownList;
		dl().FormattingEnabled = true;
		dl().Location = new Point(113, 63);
		dl().Name = "ComboBoxConSubType";
		dl().Size = new Size(200, 24);
		dl().TabIndex = 10;
		di().Anchor = AnchorStyles.Right;
		di().AutoSize = true;
		di().Location = new Point(10, 149);
		di().Name = "LabelNumDispCurves";
		di().Size = new Size(97, 16);
		di().TabIndex = 19;
		di().Text = "# Disp. Curves:";
		dk().Anchor = AnchorStyles.Right;
		dk().AutoSize = true;
		dk().Location = new Point(3, 90);
		dk().Name = "LabelDefaultSettings";
		dk().Size = new Size(104, 16);
		dk().TabIndex = 17;
		dk().Text = "Default Settings:";
		ex().Anchor = AnchorStyles.None;
		ex().AutoSize = true;
		ex().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ex().ColumnCount = 3;
		ex().ColumnStyles.Add(new ColumnStyle());
		ex().ColumnStyles.Add(new ColumnStyle());
		ex().ColumnStyles.Add(new ColumnStyle());
		ex().Controls.Add(dt(), 0, 0);
		ex().Controls.Add(ds(), 1, 0);
		ex().Controls.Add(dr(), 2, 0);
		ex().Location = new Point(99, 65);
		ex().Name = "TLPConMfgDate";
		ex().RowCount = 1;
		ex().RowStyles.Add(new RowStyle());
		ex().Size = new Size(205, 32);
		ex().TabIndex = 44;
		dt().Anchor = AnchorStyles.None;
		dt().AutoSize = true;
		dt().Location = new Point(3, 8);
		dt().Name = "LabelConMfrDate";
		dt().Size = new Size(61, 16);
		dt().TabIndex = 2;
		dt().Text = "Mfr Date:";
		ds().Anchor = AnchorStyles.None;
		ds().AutoSize = true;
		ds().BorderStyle = BorderStyle.Fixed3D;
		ds().Location = new Point(70, 7);
		ds().Name = "LabelConMfrDateBox";
		ds().Size = new Size(63, 18);
		ds().TabIndex = 3;
		ds().Text = "Mfr Date:";
		dr().Anchor = AnchorStyles.None;
		dr().AutoSize = true;
		dr().Location = new Point(139, 3);
		dr().Name = "ButtonConUpdateMfrDate";
		dr().Size = new Size(63, 26);
		dr().TabIndex = 4;
		dr().Text = "Update";
		dr().UseVisualStyleBackColor = true;
		fh().AutoSize = true;
		fh().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		fh().ColumnCount = 6;
		fh().ColumnStyles.Add(new ColumnStyle());
		fh().ColumnStyles.Add(new ColumnStyle());
		fh().ColumnStyles.Add(new ColumnStyle());
		fh().ColumnStyles.Add(new ColumnStyle());
		fh().ColumnStyles.Add(new ColumnStyle());
		fh().ColumnStyles.Add(new ColumnStyle());
		fh().Controls.Add(ju(), 0, 3);
		fh().Controls.Add(fi(), 3, 3);
		fh().Controls.Add(ej(), 1, 1);
		fh().Controls.Add(fg(), 3, 2);
		fh().Controls.Add(ff(), 1, 2);
		fh().Controls.Add(fe(), 0, 2);
		fh().Controls.Add(fb(), 4, 1);
		fh().Controls.Add(fa(), 3, 1);
		fh().Controls.Add(ei(), 2, 1);
		fh().Controls.Add(ek(), 0, 0);
		fh().Controls.Add(fc(), 3, 0);
		fh().Controls.Add(fd(), 0, 1);
		fh().Controls.Add(e8(), 5, 3);
		fh().Controls.Add(e9(), 5, 2);
		fh().Controls.Add(jt(), 1, 3);
		fh().Location = new Point(3, 740);
		fh().Name = "TLPSubsystems";
		fh().RowCount = 4;
		fh().RowStyles.Add(new RowStyle());
		fh().RowStyles.Add(new RowStyle());
		fh().RowStyles.Add(new RowStyle());
		fh().RowStyles.Add(new RowStyle());
		fh().Size = new Size(381, 103);
		fh().TabIndex = 52;
		ju().Anchor = AnchorStyles.Left;
		ju().AutoSize = true;
		ju().Location = new Point(9, 81);
		ju().Margin = new Padding(9, 0, 3, 0);
		ju().Name = "Label96";
		ju().Size = new Size(83, 16);
		ju().TabIndex = 56;
		ju().Text = "# controllers:";
		fi().AutoSize = true;
		fh().SetColumnSpan(fi(), 2);
		fi().Location = new Point(175, 78);
		fi().Margin = new Padding(20, 3, 3, 3);
		fi().Name = "CheckBoxMeasTypeIsTransmittance";
		fi().Size = new Size(112, 20);
		fi().TabIndex = 53;
		fi().Text = "Transmittance";
		fi().UseVisualStyleBackColor = true;
		ej().Anchor = AnchorStyles.None;
		ej().f(A_0: true);
		ej().Location = new Point(98, 22);
		ej().Name = "TextBoxNumConSubsystemIdx";
		ej().e(A_0: false);
		ej().Size = new Size(14, 22);
		ej().TabIndex = 25;
		fg().AutoSize = true;
		fh().SetColumnSpan(fg(), 2);
		fg().Location = new Point(175, 50);
		fg().Margin = new Padding(20, 3, 3, 3);
		fg().Name = "CheckBoxMeasTypeKnown";
		fg().Size = new Size(113, 20);
		fg().TabIndex = 52;
		fg().Text = "Type is known";
		fg().UseVisualStyleBackColor = true;
		ff().Anchor = AnchorStyles.None;
		ff().f(A_0: true);
		ff().Location = new Point(98, 50);
		ff().Name = "TextBoxNumSubsystemsInBox";
		ff().e(A_0: false);
		ff().Size = new Size(14, 22);
		ff().TabIndex = 52;
		fe().Anchor = AnchorStyles.Left;
		fe().AutoSize = true;
		fe().Location = new Point(9, 53);
		fe().Margin = new Padding(9, 0, 3, 0);
		fe().Name = "Label65";
		fe().Size = new Size(56, 16);
		fe().TabIndex = 54;
		fe().Text = "# in box:";
		fb().f(A_0: false);
		fb().Location = new Point(227, 22);
		fb().Name = "TextBoxNumericMeasAngle";
		fb().e(A_0: false);
		fb().Size = new Size(49, 22);
		fb().TabIndex = 48;
		fa().Anchor = AnchorStyles.Left;
		fa().AutoSize = true;
		fa().Location = new Point(175, 25);
		fa().Margin = new Padding(20, 0, 3, 0);
		fa().Name = "Label63";
		fa().Size = new Size(46, 16);
		fa().TabIndex = 47;
		fa().Text = "Angle:";
		ei().Anchor = AnchorStyles.None;
		ei().AutoSize = true;
		ei().Location = new Point(118, 25);
		ei().Name = "LabelSubsystemRange";
		ei().Size = new Size(34, 16);
		ei().TabIndex = 26;
		ei().Text = "(0-1)";
		ek().AutoSize = true;
		fh().SetColumnSpan(ek(), 3);
		ek().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ek().Location = new Point(3, 0);
		ek().Margin = new Padding(3, 0, 3, 3);
		ek().Name = "Label52";
		ek().Size = new Size(88, 16);
		ek().TabIndex = 24;
		ek().Text = "Subsystem:";
		fc().AutoSize = true;
		fh().SetColumnSpan(fc(), 3);
		fc().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		fc().Location = new Point(158, 0);
		fc().Margin = new Padding(3, 0, 3, 3);
		fc().Name = "Label53";
		fc().Size = new Size(185, 16);
		fc().TabIndex = 52;
		fc().Text = "Subsystem Measurement:";
		fd().Anchor = AnchorStyles.Left;
		fd().AutoSize = true;
		fd().Location = new Point(9, 25);
		fd().Margin = new Padding(9, 0, 3, 0);
		fd().Name = "Label64";
		fd().Size = new Size(43, 16);
		fd().TabIndex = 53;
		fd().Text = "Index:";
		e8().AutoSize = true;
		e8().Location = new Point(294, 78);
		e8().Name = "CheckBoxTMPolarized";
		e8().Size = new Size(47, 20);
		e8().TabIndex = 47;
		e8().Text = "TM";
		e8().UseVisualStyleBackColor = true;
		e9().AutoSize = true;
		e9().Location = new Point(294, 50);
		e9().Name = "CheckBoxMeasPolarized";
		e9().Size = new Size(84, 20);
		e9().TabIndex = 46;
		e9().Text = "Polarized";
		e9().UseVisualStyleBackColor = true;
		jt().Anchor = AnchorStyles.None;
		jt().f(A_0: true);
		jt().Location = new Point(98, 78);
		jt().Name = "TextBoxNumControllersInSubsystem";
		jt().e(A_0: false);
		jt().Size = new Size(14, 22);
		jt().TabIndex = 55;
		fv().Anchor = AnchorStyles.None;
		fv().AutoSize = true;
		fv().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		fv().ColumnCount = 3;
		fv().ColumnStyles.Add(new ColumnStyle());
		fv().ColumnStyles.Add(new ColumnStyle());
		fv().ColumnStyles.Add(new ColumnStyle());
		fv().Controls.Add(fu(), 0, 0);
		fv().Controls.Add(ft(), 2, 0);
		fv().Controls.Add(fr(), 1, 0);
		fv().Location = new Point(3, 858);
		fv().Name = "TableLayoutPanel14";
		fv().RowCount = 1;
		fv().RowStyles.Add(new RowStyle());
		fv().Size = new Size(398, 36);
		fv().TabIndex = 53;
		fu().Anchor = AnchorStyles.None;
		fu().AutoSize = true;
		fu().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		fu().Location = new Point(3, 3);
		fu().Name = "btnFindMirror";
		fu().Size = new Size(114, 30);
		fu().TabIndex = 44;
		fu().Text = "Find Mirror";
		fu().UseVisualStyleBackColor = true;
		ft().Anchor = AnchorStyles.None;
		ft().AutoSize = true;
		ft().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ft().Location = new Point(254, 3);
		ft().Name = "ButtonInit1021";
		ft().Size = new Size(141, 30);
		ft().TabIndex = 45;
		ft().Text = "Motor Firmware...";
		ft().UseVisualStyleBackColor = true;
		ft().Visible = false;
		fr().Anchor = AnchorStyles.None;
		fr().AutoSize = true;
		fr().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		fr().Location = new Point(123, 3);
		fr().Name = "ButtonConWriteFW";
		fr().Size = new Size(125, 30);
		fr().TabIndex = 43;
		fr().Text = "Write Firmware";
		fr().UseVisualStyleBackColor = true;
		ey().Anchor = AnchorStyles.None;
		ey().AutoSize = true;
		ey().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ey().ColumnCount = 3;
		ey().ColumnStyles.Add(new ColumnStyle());
		ey().ColumnStyles.Add(new ColumnStyle());
		ey().ColumnStyles.Add(new ColumnStyle());
		ey().Controls.Add(ez(), 0, 0);
		ey().Controls.Add(e0(), 1, 0);
		ey().Controls.Add(lw(), 2, 0);
		ey().Location = new Point(267, 3);
		ey().Name = "TableLayoutPanel21";
		ey().RowCount = 1;
		ey().RowStyles.Add(new RowStyle());
		ey().Size = new Size(371, 30);
		ey().TabIndex = 46;
		ez().Anchor = AnchorStyles.Right;
		ez().AutoSize = true;
		ez().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ez().Location = new Point(4, 7);
		ez().Margin = new Padding(4, 0, 4, 0);
		ez().Name = "Label46";
		ez().Size = new Size(68, 16);
		ez().TabIndex = 31;
		ez().Text = "Controller:";
		ez().TextAlign = ContentAlignment.MiddleCenter;
		e0().Anchor = AnchorStyles.Left;
		e0().DropDownStyle = ComboBoxStyle.DropDownList;
		e0().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e0().FormattingEnabled = true;
		e0().Location = new Point(79, 3);
		e0().Name = "ComboBoxController";
		e0().Size = new Size(220, 24);
		e0().TabIndex = 31;
		lw().Anchor = AnchorStyles.None;
		lw().AutoSize = true;
		lw().Location = new Point(305, 7);
		lw().Name = "LabelStageSN";
		lw().Size = new Size(63, 16);
		lw().TabIndex = 32;
		lw().Text = "StageSN";
		lw().Visible = false;
		ba().Controls.Add(kz());
		ba().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ba().Location = new Point(4, 25);
		ba().Name = "TabPageSpectrometer";
		ba().Padding = new Padding(3);
		ba().Size = new Size(892, 871);
		ba().TabIndex = 0;
		ba().Text = "Spectrometer";
		ba().UseVisualStyleBackColor = true;
		kz().AutoSize = true;
		kz().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		kz().Controls.Add(bj());
		kz().Location = new Point(0, 0);
		kz().Margin = new Padding(0);
		kz().Name = "PanelSpectrometerPage";
		kz().Size = new Size(737, 870);
		kz().TabIndex = 0;
		bj().AutoSize = true;
		bj().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		bj().ColumnCount = 3;
		bj().ColumnStyles.Add(new ColumnStyle());
		bj().ColumnStyles.Add(new ColumnStyle());
		bj().ColumnStyles.Add(new ColumnStyle());
		bj().Controls.Add(h7(), 1, 2);
		bj().Controls.Add(de(), 2, 2);
		bj().Controls.Add(bb(), 0, 4);
		bj().Controls.Add(bm(), 1, 0);
		bj().Controls.Add(bn(), 0, 0);
		bj().Controls.Add(bi(), 0, 1);
		bj().Controls.Add(a1(), 0, 2);
		bj().Controls.Add(bk(), 0, 3);
		bj().Controls.Add(bp(), 2, 4);
		bj().Location = new Point(3, 3);
		bj().Name = "TLPSpectrometer";
		bj().RowCount = 5;
		bj().RowStyles.Add(new RowStyle());
		bj().RowStyles.Add(new RowStyle());
		bj().RowStyles.Add(new RowStyle());
		bj().RowStyles.Add(new RowStyle());
		bj().RowStyles.Add(new RowStyle());
		bj().Size = new Size(731, 864);
		bj().TabIndex = 0;
		h7().AutoSize = true;
		h7().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		h7().ColumnCount = 1;
		h7().ColumnStyles.Add(new ColumnStyle());
		h7().Controls.Add(lv(), 0, 3);
		h7().Controls.Add(h9(), 0, 2);
		h7().Controls.Add(ar(), 0, 0);
		h7().Controls.Add(bt(), 0, 1);
		h7().Controls.Add(l9(), 0, 4);
		h7().Location = new Point(277, 95);
		h7().Name = "TableLayoutPanel24";
		h7().RowCount = 5;
		bj().SetRowSpan(h7(), 2);
		h7().RowStyles.Add(new RowStyle());
		h7().RowStyles.Add(new RowStyle());
		h7().RowStyles.Add(new RowStyle());
		h7().RowStyles.Add(new RowStyle());
		h7().RowStyles.Add(new RowStyle());
		h7().Size = new Size(226, 681);
		h7().TabIndex = 31;
		lv().Anchor = AnchorStyles.None;
		lv().AutoSize = true;
		lv().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lv().Location = new Point(39, 603);
		lv().Name = "CheckBoxNotchFlatFindOnly";
		lv().Size = new Size(147, 20);
		lv().TabIndex = 32;
		lv().Text = "Notch/Flat Find Only";
		lv().UseVisualStyleBackColor = true;
		h9().Anchor = AnchorStyles.None;
		h9().AutoSize = true;
		h9().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		h9().Controls.Add(ia());
		h9().Location = new Point(11, 400);
		h9().Name = "GroupBoxNeonCal";
		h9().Size = new Size(203, 197);
		h9().TabIndex = 31;
		h9().TabStop = false;
		h9().Text = "Neon Calibration";
		h9().Visible = false;
		ia().AutoSize = true;
		ia().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ia().ColumnCount = 2;
		ia().ColumnStyles.Add(new ColumnStyle());
		ia().ColumnStyles.Add(new ColumnStyle());
		ia().Controls.Add(k0(), 0, 1);
		ia().Controls.Add(k1(), 1, 0);
		ia().Controls.Add(ib(), 1, 4);
		ia().Controls.Add(k2(), 0, 0);
		ia().Controls.Add(ic(), 0, 4);
		ia().Controls.Add(h8(), 0, 5);
		ia().Controls.Add(id(), 1, 3);
		ia().Controls.Add(ie(), 0, 3);
		ia().Controls.Add(@if(), 1, 2);
		ia().Controls.Add(ig(), 0, 2);
		ia().Dock = DockStyle.Fill;
		ia().Location = new Point(3, 18);
		ia().Name = "TLPNeon";
		ia().RowCount = 6;
		ia().RowStyles.Add(new RowStyle());
		ia().RowStyles.Add(new RowStyle());
		ia().RowStyles.Add(new RowStyle());
		ia().RowStyles.Add(new RowStyle());
		ia().RowStyles.Add(new RowStyle());
		ia().RowStyles.Add(new RowStyle());
		ia().Size = new Size(197, 176);
		ia().TabIndex = 0;
		k0().Anchor = AnchorStyles.None;
		k0().AutoSize = true;
		k0().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ia().SetColumnSpan(k0(), 2);
		k0().Enabled = false;
		k0().Location = new Point(18, 31);
		k0().Name = "ButtonCalPeaksDelete";
		k0().Size = new Size(161, 26);
		k0().TabIndex = 32;
		k0().Text = "Delete Neon Calibration";
		gu().SetToolTip(k0(), "Copies the value in the Wavlen delta TextBox into\r\nthe Wavelen Offset TextBox. You should do this if\r\nyou know that the wavelength calibration was accurate\r\nbefore you clicked Neon Calibration.");
		k0().UseVisualStyleBackColor = true;
		k1().Anchor = AnchorStyles.Left;
		k1().f(A_0: false);
		k1().Location = new Point(107, 3);
		k1().Margin = new Padding(0, 3, 3, 3);
		k1().Name = "TextBoxNumCalPeaksOffset";
		k1().e(A_0: true);
		k1().Size = new Size(87, 22);
		k1().TabIndex = 32;
		gu().SetToolTip(k1(), componentResourceManager.GetString("TextBoxNumCalPeaksOffset.ToolTip"));
		ib().Anchor = AnchorStyles.Left;
		ib().f(A_0: false);
		ib().Location = new Point(107, 119);
		ib().Margin = new Padding(0, 3, 3, 3);
		ib().Name = "TextBoxNumCalPeaksRightWidth";
		ib().e(A_0: false);
		ib().ReadOnly = true;
		ib().Size = new Size(87, 22);
		ib().TabIndex = 34;
		k2().Anchor = AnchorStyles.Right;
		k2().AutoSize = true;
		k2().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		k2().Location = new Point(3, 6);
		k2().Margin = new Padding(3, 0, 2, 0);
		k2().Name = "Label66";
		k2().Size = new Size(102, 16);
		k2().TabIndex = 33;
		k2().Text = "Wavelen Offset:";
		ic().Anchor = AnchorStyles.Right;
		ic().AutoSize = true;
		ic().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ic().Location = new Point(30, 122);
		ic().Margin = new Padding(3, 0, 2, 0);
		ic().Name = "Label68";
		ic().Size = new Size(75, 16);
		ic().TabIndex = 34;
		ic().Text = "Right width:";
		h8().Anchor = AnchorStyles.None;
		h8().AutoSize = true;
		h8().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ia().SetColumnSpan(h8(), 2);
		h8().Location = new Point(39, 147);
		h8().Name = "ButtonCalibrateNeon";
		h8().Size = new Size(118, 26);
		h8().TabIndex = 7;
		h8().Text = "Neon Calibration";
		h8().UseVisualStyleBackColor = true;
		h8().Visible = false;
		id().Anchor = AnchorStyles.Left;
		id().f(A_0: false);
		id().Location = new Point(107, 91);
		id().Margin = new Padding(0, 3, 3, 3);
		id().Name = "TextBoxNumCalPeaksLeftWidth";
		id().e(A_0: false);
		id().ReadOnly = true;
		id().Size = new Size(87, 22);
		id().TabIndex = 33;
		ie().Anchor = AnchorStyles.Right;
		ie().AutoSize = true;
		ie().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ie().Location = new Point(40, 94);
		ie().Margin = new Padding(3, 0, 2, 0);
		ie().Name = "Label67";
		ie().Size = new Size(65, 16);
		ie().TabIndex = 33;
		ie().Text = "Left width:";
		@if().Anchor = AnchorStyles.Left;
		@if().f(A_0: false);
		@if().Location = new Point(107, 63);
		@if().Margin = new Padding(0, 3, 3, 3);
		@if().Name = "TextBoxNumCalPeaksDelta";
		@if().e(A_0: false);
		@if().ReadOnly = true;
		@if().Size = new Size(87, 22);
		@if().TabIndex = 32;
		ig().Anchor = AnchorStyles.Right;
		ig().AutoSize = true;
		ig().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ig().Location = new Point(5, 66);
		ig().Margin = new Padding(3, 0, 2, 0);
		ig().Name = "Label54";
		ig().Size = new Size(100, 16);
		ig().TabIndex = 32;
		ig().Text = "Wavelen Delta:";
		ar().Anchor = AnchorStyles.None;
		ar().AutoSize = true;
		ar().Controls.Add(aw());
		ar().Controls.Add(a9());
		ar().Location = new Point(9, 3);
		ar().Name = "GroupBoxWaveRange";
		ar().Size = new Size(207, 133);
		ar().TabIndex = 5;
		ar().TabStop = false;
		aw().AutoSize = true;
		aw().BackColor = SystemColors.ControlLightLight;
		aw().Enabled = false;
		aw().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aw().ForeColor = SystemColors.ControlText;
		aw().Location = new Point(9, 0);
		aw().Name = "CheckBoxRestrictWavelengthRange";
		aw().Size = new Size(181, 20);
		aw().TabIndex = 4;
		aw().Text = "Restrict wavelength range";
		aw().UseVisualStyleBackColor = false;
		a9().AutoSize = true;
		a9().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		a9().ColumnCount = 3;
		a9().ColumnStyles.Add(new ColumnStyle());
		a9().ColumnStyles.Add(new ColumnStyle());
		a9().ColumnStyles.Add(new ColumnStyle());
		a9().Controls.Add(@as(), 1, 2);
		a9().Controls.Add(au(), 2, 2);
		a9().Controls.Add(ax(), 1, 0);
		a9().Controls.Add(a0(), 0, 0);
		a9().Controls.Add(av(), 2, 1);
		a9().Controls.Add(at(), 1, 1);
		a9().Controls.Add(az(), 0, 1);
		a9().Controls.Add(ay(), 0, 2);
		a9().Controls.Add(ko(), 0, 3);
		a9().Dock = DockStyle.Fill;
		a9().Location = new Point(3, 18);
		a9().Name = "TableLayoutPanel7";
		a9().RowCount = 4;
		a9().RowStyles.Add(new RowStyle());
		a9().RowStyles.Add(new RowStyle());
		a9().RowStyles.Add(new RowStyle());
		a9().RowStyles.Add(new RowStyle());
		a9().Size = new Size(201, 112);
		a9().TabIndex = 0;
		@as().Anchor = AnchorStyles.Left;
		@as().f(A_0: false);
		@as().Location = new Point(57, 61);
		@as().Margin = new Padding(0, 3, 0, 3);
		@as().Name = "TextBoxEndWaveLength";
		@as().e(A_0: false);
		@as().Size = new Size(105, 22);
		@as().TabIndex = 6;
		au().Anchor = AnchorStyles.Left;
		au().AutoSize = true;
		au().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		au().Location = new Point(164, 64);
		au().Margin = new Padding(2, 0, 3, 0);
		au().Name = "Label8";
		au().Size = new Size(26, 16);
		au().TabIndex = 7;
		au().Text = "nm";
		ax().Anchor = AnchorStyles.Left;
		a9().SetColumnSpan(ax(), 2);
		ax().DropDownStyle = ComboBoxStyle.DropDownList;
		ax().FormattingEnabled = true;
		ax().Location = new Point(57, 3);
		ax().Margin = new Padding(0, 3, 3, 3);
		ax().Name = "ComboBoxWavelengthRange";
		ax().Size = new Size(136, 24);
		ax().TabIndex = 4;
		a0().Anchor = AnchorStyles.Right;
		a0().AutoSize = true;
		a0().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a0().Location = new Point(3, 7);
		a0().Margin = new Padding(3, 0, 2, 0);
		a0().Name = "Label4";
		a0().Size = new Size(52, 16);
		a0().TabIndex = 0;
		a0().Text = "Range:";
		av().Anchor = AnchorStyles.Left;
		av().AutoSize = true;
		av().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		av().Location = new Point(164, 36);
		av().Margin = new Padding(2, 0, 3, 0);
		av().Name = "Label7";
		av().Size = new Size(26, 16);
		av().TabIndex = 6;
		av().Text = "nm";
		at().Anchor = AnchorStyles.Left;
		at().f(A_0: false);
		at().Location = new Point(57, 33);
		at().Margin = new Padding(0, 3, 0, 3);
		at().Name = "TextBoxStartWaveLen";
		at().e(A_0: false);
		at().Size = new Size(105, 22);
		at().TabIndex = 5;
		az().Anchor = AnchorStyles.Right;
		az().AutoSize = true;
		az().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		az().Location = new Point(17, 36);
		az().Margin = new Padding(3, 0, 2, 0);
		az().Name = "Label5";
		az().Size = new Size(38, 16);
		az().TabIndex = 1;
		az().Text = "Start:";
		ay().Anchor = AnchorStyles.Right;
		ay().AutoSize = true;
		ay().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ay().Location = new Point(20, 64);
		ay().Margin = new Padding(3, 0, 2, 0);
		ay().Name = "Label6";
		ay().Size = new Size(35, 16);
		ay().TabIndex = 2;
		ay().Text = "End:";
		ko().AutoSize = true;
		a9().SetColumnSpan(ko(), 3);
		ko().Enabled = false;
		ko().Location = new Point(3, 89);
		ko().Name = "CheckBoxExtraRangeForTempComp";
		ko().Size = new Size(195, 20);
		ko().TabIndex = 8;
		ko().Text = "Temperature Compensation";
		gu().SetToolTip(ko(), componentResourceManager.GetString("CheckBoxExtraRangeForTempComp.ToolTip"));
		ko().UseVisualStyleBackColor = true;
		bt().Anchor = AnchorStyles.None;
		bt().Controls.Add(bu());
		bt().Controls.Add(by());
		bt().Location = new Point(3, 142);
		bt().Name = "TabControlLinearity";
		bt().SelectedIndex = 0;
		bt().Size = new Size(220, 252);
		bt().TabIndex = 6;
		bt().Visible = false;
		bu().Controls.Add(bv());
		bu().Location = new Point(4, 25);
		bu().Name = "TabPageLinV1";
		bu().Padding = new Padding(3);
		bu().Size = new Size(212, 223);
		bu().TabIndex = 0;
		bu().Text = "Linearity v1";
		bu().UseVisualStyleBackColor = true;
		bv().Anchor = AnchorStyles.None;
		bv().AutoSize = true;
		bv().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		bv().ColumnCount = 2;
		bv().ColumnStyles.Add(new ColumnStyle());
		bv().ColumnStyles.Add(new ColumnStyle());
		bv().Controls.Add(bz(), 1, 1);
		bv().Controls.Add(b0(), 1, 0);
		bv().Controls.Add(bw(), 0, 0);
		bv().Controls.Add(bx(), 0, 1);
		bv().Controls.Add(b1(), 0, 2);
		bv().Location = new Point(28, 35);
		bv().Name = "TableLayoutPanel3";
		bv().RowCount = 3;
		bv().RowStyles.Add(new RowStyle());
		bv().RowStyles.Add(new RowStyle());
		bv().RowStyles.Add(new RowStyle());
		bv().Size = new Size(158, 85);
		bv().TabIndex = 0;
		bz().Anchor = AnchorStyles.Left;
		bz().f(A_0: false);
		bz().Location = new Point(68, 31);
		bz().Margin = new Padding(0, 3, 3, 3);
		bz().Name = "TextBoxNumLinSlope";
		bz().e(A_0: false);
		bz().Size = new Size(87, 22);
		bz().TabIndex = 31;
		b0().Anchor = AnchorStyles.Left;
		b0().f(A_0: false);
		b0().Location = new Point(68, 3);
		b0().Margin = new Padding(0, 3, 3, 3);
		b0().Name = "TextBoxNumLinIntercept";
		b0().e(A_0: false);
		b0().Size = new Size(87, 22);
		b0().TabIndex = 31;
		bw().Anchor = AnchorStyles.None;
		bw().AutoSize = true;
		bw().Location = new Point(3, 6);
		bw().Name = "Label19";
		bw().Size = new Size(62, 16);
		bw().TabIndex = 0;
		bw().Text = "Intercept:";
		bx().Anchor = AnchorStyles.None;
		bx().AutoSize = true;
		bx().Location = new Point(10, 34);
		bx().Name = "Label20";
		bx().Size = new Size(47, 16);
		bx().TabIndex = 1;
		bx().Text = "Slope:";
		b1().Anchor = AnchorStyles.None;
		bv().SetColumnSpan(b1(), 2);
		b1().Location = new Point(41, 59);
		b1().Name = "ButtonMeasLinearityV1";
		b1().Size = new Size(75, 23);
		b1().TabIndex = 2;
		b1().Text = "Measure...";
		b1().UseVisualStyleBackColor = true;
		by().Controls.Add(b2());
		by().Location = new Point(4, 25);
		by().Name = "TabPageLinV2";
		by().Padding = new Padding(3);
		by().Size = new Size(212, 223);
		by().TabIndex = 1;
		by().Text = "Linearity v2";
		by().UseVisualStyleBackColor = true;
		b2().AutoSize = true;
		b2().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		b2().ColumnCount = 3;
		b2().ColumnStyles.Add(new ColumnStyle());
		b2().ColumnStyles.Add(new ColumnStyle());
		b2().ColumnStyles.Add(new ColumnStyle());
		b2().Controls.Add(cs(), 2, 7);
		b2().Controls.Add(ce(), 2, 6);
		b2().Controls.Add(ch(), 2, 5);
		b2().Controls.Add(ci(), 2, 4);
		b2().Controls.Add(cj(), 2, 3);
		b2().Controls.Add(ck(), 2, 2);
		b2().Controls.Add(cl(), 2, 1);
		b2().Controls.Add(cm(), 1, 5);
		b2().Controls.Add(cn(), 1, 4);
		b2().Controls.Add(co(), 1, 3);
		b2().Controls.Add(cp(), 1, 2);
		b2().Controls.Add(cq(), 1, 1);
		b2().Controls.Add(cr(), 1, 7);
		b2().Controls.Add(ca(), 0, 6);
		b2().Controls.Add(b3(), 0, 5);
		b2().Controls.Add(b4(), 0, 4);
		b2().Controls.Add(b5(), 0, 3);
		b2().Controls.Add(b6(), 0, 2);
		b2().Controls.Add(b7(), 0, 1);
		b2().Controls.Add(b8(), 2, 0);
		b2().Controls.Add(b9(), 1, 0);
		b2().Location = new Point(0, 0);
		b2().Name = "TableLayoutPanel4";
		b2().RowCount = 8;
		b2().RowStyles.Add(new RowStyle());
		b2().RowStyles.Add(new RowStyle());
		b2().RowStyles.Add(new RowStyle());
		b2().RowStyles.Add(new RowStyle());
		b2().RowStyles.Add(new RowStyle());
		b2().RowStyles.Add(new RowStyle());
		b2().RowStyles.Add(new RowStyle());
		b2().RowStyles.Add(new RowStyle());
		b2().Size = new Size(220, 222);
		b2().TabIndex = 0;
		cs().Anchor = AnchorStyles.None;
		cs().AutoSize = true;
		cs().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		cs().Location = new Point(133, 193);
		cs().Name = "ButtonMeasLinV2T2";
		cs().Size = new Size(80, 26);
		cs().TabIndex = 38;
		cs().Text = "Measure...";
		cs().UseVisualStyleBackColor = true;
		ce().Anchor = AnchorStyles.None;
		ce().AutoSize = true;
		ce().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ce().ColumnCount = 2;
		ce().ColumnStyles.Add(new ColumnStyle());
		ce().ColumnStyles.Add(new ColumnStyle());
		ce().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
		ce().Controls.Add(cf(), 0, 0);
		ce().Controls.Add(cg(), 1, 0);
		ce().Location = new Point(139, 159);
		ce().Name = "TableLayoutPanel9";
		ce().RowCount = 1;
		ce().RowStyles.Add(new RowStyle());
		ce().Size = new Size(68, 28);
		ce().TabIndex = 32;
		cf().Anchor = AnchorStyles.Left;
		cf().f(A_0: false);
		cf().Location = new Point(0, 3);
		cf().Margin = new Padding(0, 3, 3, 3);
		cf().Name = "TextBoxLinV2T2";
		cf().e(A_0: false);
		cf().Size = new Size(39, 22);
		cf().TabIndex = 12;
		cg().Anchor = AnchorStyles.Right;
		cg().AutoSize = true;
		cg().Location = new Point(45, 6);
		cg().Margin = new Padding(3, 0, 2, 0);
		cg().Name = "Label34";
		cg().Size = new Size(21, 16);
		cg().TabIndex = 35;
		cg().Text = "°C";
		ch().Anchor = AnchorStyles.Left;
		ch().f(A_0: false);
		ch().Location = new Point(126, 131);
		ch().Margin = new Padding(0, 3, 3, 3);
		ch().Name = "TextBoxLinV2C4T2";
		ch().e(A_0: true);
		ch().Size = new Size(91, 22);
		ch().TabIndex = 11;
		ci().Anchor = AnchorStyles.Left;
		ci().f(A_0: false);
		ci().Location = new Point(126, 103);
		ci().Margin = new Padding(0, 3, 3, 3);
		ci().Name = "TextBoxLinV2C3T2";
		ci().e(A_0: true);
		ci().Size = new Size(91, 22);
		ci().TabIndex = 10;
		cj().Anchor = AnchorStyles.Left;
		cj().f(A_0: false);
		cj().Location = new Point(126, 75);
		cj().Margin = new Padding(0, 3, 3, 3);
		cj().Name = "TextBoxLinV2C2T2";
		cj().e(A_0: true);
		cj().Size = new Size(91, 22);
		cj().TabIndex = 9;
		ck().Anchor = AnchorStyles.Left;
		ck().f(A_0: false);
		ck().Location = new Point(126, 47);
		ck().Margin = new Padding(0, 3, 3, 3);
		ck().Name = "TextBoxLinV2C1T2";
		ck().e(A_0: true);
		ck().Size = new Size(91, 22);
		ck().TabIndex = 8;
		cl().Anchor = AnchorStyles.Left;
		cl().f(A_0: false);
		cl().Location = new Point(126, 19);
		cl().Margin = new Padding(0, 3, 3, 3);
		cl().Name = "TextBoxLinV2C0T2";
		cl().e(A_0: true);
		cl().Size = new Size(91, 22);
		cl().TabIndex = 7;
		cm().Anchor = AnchorStyles.Left;
		cm().f(A_0: false);
		cm().Location = new Point(29, 131);
		cm().Margin = new Padding(0, 3, 3, 3);
		cm().Name = "TextBoxLinV2C4T1";
		cm().e(A_0: true);
		cm().Size = new Size(91, 22);
		cm().TabIndex = 5;
		cn().Anchor = AnchorStyles.Left;
		cn().f(A_0: false);
		cn().Location = new Point(29, 103);
		cn().Margin = new Padding(0, 3, 3, 3);
		cn().Name = "TextBoxLinV2C3T1";
		cn().e(A_0: true);
		cn().Size = new Size(91, 22);
		cn().TabIndex = 4;
		co().Anchor = AnchorStyles.Left;
		co().f(A_0: false);
		co().Location = new Point(29, 75);
		co().Margin = new Padding(0, 3, 3, 3);
		co().Name = "TextBoxLinV2C2T1";
		co().e(A_0: true);
		co().Size = new Size(91, 22);
		co().TabIndex = 3;
		cp().Anchor = AnchorStyles.Left;
		cp().f(A_0: false);
		cp().Location = new Point(29, 47);
		cp().Margin = new Padding(0, 3, 3, 3);
		cp().Name = "TextBoxLinV2C1T1";
		cp().e(A_0: true);
		cp().Size = new Size(91, 22);
		cp().TabIndex = 2;
		cq().Anchor = AnchorStyles.Left;
		cq().f(A_0: false);
		cq().Location = new Point(29, 19);
		cq().Margin = new Padding(0, 3, 3, 3);
		cq().Name = "TextBoxLinV2C0T1";
		cq().e(A_0: true);
		cq().Size = new Size(91, 22);
		cq().TabIndex = 1;
		cr().Anchor = AnchorStyles.None;
		cr().AutoSize = true;
		cr().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		cr().Location = new Point(37, 193);
		cr().Name = "ButtonMeasLinV2T1";
		cr().Size = new Size(80, 26);
		cr().TabIndex = 37;
		cr().Text = "Measure...";
		cr().UseVisualStyleBackColor = true;
		ca().Anchor = AnchorStyles.None;
		ca().AutoSize = true;
		ca().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ca().ColumnCount = 3;
		b2().SetColumnSpan(ca(), 2);
		ca().ColumnStyles.Add(new ColumnStyle());
		ca().ColumnStyles.Add(new ColumnStyle());
		ca().ColumnStyles.Add(new ColumnStyle());
		ca().Controls.Add(cb(), 1, 0);
		ca().Controls.Add(cc(), 0, 0);
		ca().Controls.Add(cd(), 2, 0);
		ca().Location = new Point(3, 159);
		ca().Name = "TableLayoutPanel8";
		ca().RowCount = 1;
		ca().RowStyles.Add(new RowStyle());
		ca().Size = new Size(120, 28);
		ca().TabIndex = 31;
		cb().Anchor = AnchorStyles.Left;
		cb().f(A_0: false);
		cb().Location = new Point(52, 3);
		cb().Margin = new Padding(0, 3, 3, 3);
		cb().Name = "TextBoxLinV2T1";
		cb().e(A_0: false);
		cb().Size = new Size(39, 22);
		cb().TabIndex = 6;
		cc().Anchor = AnchorStyles.Right;
		cc().AutoSize = true;
		cc().Location = new Point(3, 6);
		cc().Margin = new Padding(3, 0, 2, 0);
		cc().Name = "Label31";
		cc().Size = new Size(47, 16);
		cc().TabIndex = 34;
		cc().Text = "Temp:";
		cd().Anchor = AnchorStyles.Right;
		cd().AutoSize = true;
		cd().Location = new Point(97, 6);
		cd().Margin = new Padding(3, 0, 2, 0);
		cd().Name = "Label32";
		cd().Size = new Size(21, 16);
		cd().TabIndex = 35;
		cd().Text = "°C";
		b3().Anchor = AnchorStyles.Right;
		b3().AutoSize = true;
		b3().Location = new Point(3, 134);
		b3().Margin = new Padding(3, 0, 2, 0);
		b3().Name = "Label30";
		b3().Size = new Size(24, 16);
		b3().TabIndex = 33;
		b3().Text = "C4";
		b4().Anchor = AnchorStyles.Right;
		b4().AutoSize = true;
		b4().Location = new Point(3, 106);
		b4().Margin = new Padding(3, 0, 2, 0);
		b4().Name = "Label29";
		b4().Size = new Size(24, 16);
		b4().TabIndex = 33;
		b4().Text = "C3";
		b5().Anchor = AnchorStyles.Right;
		b5().AutoSize = true;
		b5().Location = new Point(3, 78);
		b5().Margin = new Padding(3, 0, 2, 0);
		b5().Name = "Label27";
		b5().Size = new Size(24, 16);
		b5().TabIndex = 33;
		b5().Text = "C2";
		b6().Anchor = AnchorStyles.Right;
		b6().AutoSize = true;
		b6().Location = new Point(3, 50);
		b6().Margin = new Padding(3, 0, 2, 0);
		b6().Name = "Label26";
		b6().Size = new Size(24, 16);
		b6().TabIndex = 33;
		b6().Text = "C1";
		b7().Anchor = AnchorStyles.Right;
		b7().AutoSize = true;
		b7().Location = new Point(3, 22);
		b7().Margin = new Padding(3, 0, 2, 0);
		b7().Name = "Label25";
		b7().Size = new Size(24, 16);
		b7().TabIndex = 32;
		b7().Text = "C0";
		b8().Anchor = AnchorStyles.None;
		b8().AutoSize = true;
		b8().Location = new Point(134, 0);
		b8().Margin = new Padding(3, 0, 2, 0);
		b8().Name = "Label24";
		b8().Size = new Size(79, 16);
		b8().TabIndex = 32;
		b8().Text = "Coeffs @T2";
		b9().Anchor = AnchorStyles.None;
		b9().AutoSize = true;
		b9().Location = new Point(38, 0);
		b9().Margin = new Padding(3, 0, 2, 0);
		b9().Name = "Label23";
		b9().Size = new Size(79, 16);
		b9().TabIndex = 31;
		b9().Text = "Coeffs @T1";
		de().AutoSize = true;
		de().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		de().ColumnCount = 1;
		de().ColumnStyles.Add(new ColumnStyle());
		de().Controls.Add(l3(), 0, 6);
		de().Controls.Add(k4(), 0, 5);
		de().Controls.Add(jm(), 0, 4);
		de().Controls.Add(ct(), 0, 1);
		de().Controls.Add(cy(), 0, 2);
		de().Controls.Add(hf(), 0, 0);
		de().Controls.Add(dd(), 0, 3);
		de().Location = new Point(509, 95);
		de().Name = "TableLayoutPanel13";
		de().RowCount = 7;
		bj().SetRowSpan(de(), 2);
		de().RowStyles.Add(new RowStyle());
		de().RowStyles.Add(new RowStyle());
		de().RowStyles.Add(new RowStyle());
		de().RowStyles.Add(new RowStyle());
		de().RowStyles.Add(new RowStyle());
		de().RowStyles.Add(new RowStyle());
		de().RowStyles.Add(new RowStyle());
		de().Size = new Size(219, 706);
		de().TabIndex = 9;
		l3().Anchor = AnchorStyles.Top;
		l3().AutoSize = true;
		l3().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		l3().Controls.Add(l4());
		l3().Location = new Point(22, 654);
		l3().Name = "GroupBoxBaselineLinearity";
		l3().Size = new Size(175, 49);
		l3().TabIndex = 33;
		l3().TabStop = false;
		l3().Text = "Baseline Linearity";
		l3().Visible = false;
		l4().AutoSize = true;
		l4().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		l4().ColumnCount = 2;
		l4().ColumnStyles.Add(new ColumnStyle());
		l4().ColumnStyles.Add(new ColumnStyle());
		l4().Controls.Add(l5(), 1, 0);
		l4().Controls.Add(l6(), 0, 0);
		l4().Dock = DockStyle.Fill;
		l4().Location = new Point(3, 18);
		l4().Name = "TableLayoutPanel2";
		l4().RowCount = 1;
		l4().RowStyles.Add(new RowStyle());
		l4().RowStyles.Add(new RowStyle(SizeType.Absolute, 28f));
		l4().Size = new Size(169, 28);
		l4().TabIndex = 31;
		l5().Anchor = AnchorStyles.Left;
		l5().f(A_0: false);
		l5().Location = new Point(76, 3);
		l5().Margin = new Padding(0, 3, 3, 3);
		l5().Name = "TextBoxNumericBaselineLinearityAmplitude";
		l5().e(A_0: false);
		l5().Size = new Size(90, 22);
		l5().TabIndex = 33;
		l6().Anchor = AnchorStyles.Right;
		l6().AutoSize = true;
		l6().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		l6().Location = new Point(3, 6);
		l6().Margin = new Padding(3, 0, 2, 0);
		l6().Name = "Label105";
		l6().Size = new Size(71, 16);
		l6().TabIndex = 33;
		l6().Text = "Amplitude:";
		k4().Anchor = AnchorStyles.Top;
		k4().AutoSize = true;
		k4().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		k4().Controls.Add(k5());
		k4().Location = new Point(22, 571);
		k4().Name = "GroupBoxNotchSharpen";
		k4().Size = new Size(175, 77);
		k4().TabIndex = 32;
		k4().TabStop = false;
		k4().Text = "Notch Sharpen";
		k4().Visible = false;
		k5().AutoSize = true;
		k5().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		k5().ColumnCount = 2;
		k5().ColumnStyles.Add(new ColumnStyle());
		k5().ColumnStyles.Add(new ColumnStyle());
		k5().Controls.Add(k9(), 1, 1);
		k5().Controls.Add(k6(), 0, 1);
		k5().Controls.Add(k7(), 1, 0);
		k5().Controls.Add(k8(), 0, 0);
		k5().Dock = DockStyle.Fill;
		k5().Location = new Point(3, 18);
		k5().Name = "TableLayoutPanel20";
		k5().RowCount = 2;
		k5().RowStyles.Add(new RowStyle());
		k5().RowStyles.Add(new RowStyle());
		k5().Size = new Size(169, 56);
		k5().TabIndex = 31;
		k9().Anchor = AnchorStyles.Left;
		k9().f(A_0: false);
		k9().Location = new Point(76, 31);
		k9().Margin = new Padding(0, 3, 3, 3);
		k9().Name = "TextBoxNumericNotchSharpenInterval";
		k9().e(A_0: false);
		k9().Size = new Size(90, 22);
		k9().TabIndex = 35;
		k6().Anchor = AnchorStyles.Right;
		k6().AutoSize = true;
		k6().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		k6().Location = new Point(20, 34);
		k6().Margin = new Padding(3, 0, 2, 0);
		k6().Name = "Label84";
		k6().Size = new Size(54, 16);
		k6().TabIndex = 34;
		k6().Text = "Interval:";
		k7().Anchor = AnchorStyles.Left;
		k7().f(A_0: false);
		k7().Location = new Point(76, 3);
		k7().Margin = new Padding(0, 3, 3, 3);
		k7().Name = "TextBoxNumericNotchSharpenAmplitude";
		k7().e(A_0: false);
		k7().Size = new Size(90, 22);
		k7().TabIndex = 33;
		k8().Anchor = AnchorStyles.Right;
		k8().AutoSize = true;
		k8().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		k8().Location = new Point(3, 6);
		k8().Margin = new Padding(3, 0, 2, 0);
		k8().Name = "Label80";
		k8().Size = new Size(71, 16);
		k8().TabIndex = 33;
		k8().Text = "Amplitude:";
		jm().Anchor = AnchorStyles.Top;
		jm().AutoSize = true;
		jm().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		jm().Controls.Add(jn());
		jm().Location = new Point(8, 458);
		jm().Name = "GroupBoxTECCalib";
		jm().Size = new Size(203, 107);
		jm().TabIndex = 31;
		jm().TabStop = false;
		jm().Text = "TEC Supply Pot";
		jm().Visible = false;
		jn().AutoSize = true;
		jn().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		jn().ColumnCount = 2;
		jn().ColumnStyles.Add(new ColumnStyle());
		jn().ColumnStyles.Add(new ColumnStyle());
		jn().Controls.Add(jo(), 0, 1);
		jn().Controls.Add(jp(), 1, 0);
		jn().Controls.Add(jq(), 0, 0);
		jn().Controls.Add(jr(), 0, 2);
		jn().Dock = DockStyle.Fill;
		jn().Location = new Point(3, 18);
		jn().Name = "TableLayoutPanel32";
		jn().RowCount = 3;
		jn().RowStyles.Add(new RowStyle());
		jn().RowStyles.Add(new RowStyle());
		jn().RowStyles.Add(new RowStyle());
		jn().Size = new Size(197, 86);
		jn().TabIndex = 31;
		jo().Anchor = AnchorStyles.None;
		jo().AutoSize = true;
		jn().SetColumnSpan(jo(), 2);
		jo().Location = new Point(47, 31);
		jo().Name = "CheckBoxTECSupplyPotRIsCalibrated";
		jo().Size = new Size(102, 20);
		jo().TabIndex = 31;
		jo().Text = "Is Calibrated";
		jo().UseVisualStyleBackColor = true;
		jp().Anchor = AnchorStyles.Left;
		jp().f(A_0: false);
		jp().Location = new Point(104, 3);
		jp().Margin = new Padding(0, 3, 3, 3);
		jp().Name = "TextBoxNumTECSupplyMaxR";
		jp().e(A_0: false);
		jp().Size = new Size(90, 22);
		jp().TabIndex = 33;
		jq().Anchor = AnchorStyles.Right;
		jq().AutoSize = true;
		jq().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		jq().Location = new Point(3, 6);
		jq().Margin = new Padding(3, 0, 2, 0);
		jq().Name = "Label97";
		jq().Size = new Size(99, 16);
		jq().TabIndex = 33;
		jq().Text = "RMax (kOhms):";
		jr().Anchor = AnchorStyles.None;
		jr().AutoSize = true;
		jr().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		jn().SetColumnSpan(jr(), 2);
		jr().Location = new Point(62, 57);
		jr().Name = "ButtonCalibrateTECSupplyPotR";
		jr().Size = new Size(72, 26);
		jr().TabIndex = 38;
		jr().Text = "Calibrate";
		jr().UseVisualStyleBackColor = true;
		ct().Anchor = AnchorStyles.Top;
		ct().AutoSize = true;
		ct().Controls.Add(cu());
		ct().Location = new Point(39, 113);
		ct().Name = "GroupBoxADGain";
		ct().Size = new Size(140, 81);
		ct().TabIndex = 7;
		ct().TabStop = false;
		ct().Text = "A/D Gain Setting";
		ct().Visible = false;
		cu().AutoSize = true;
		cu().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		cu().ColumnCount = 2;
		cu().ColumnStyles.Add(new ColumnStyle());
		cu().ColumnStyles.Add(new ColumnStyle());
		cu().Controls.Add(cv(), 0, 1);
		cu().Controls.Add(cw(), 0, 0);
		cu().Controls.Add(cx(), 1, 0);
		cu().Dock = DockStyle.Fill;
		cu().Location = new Point(3, 18);
		cu().Name = "TableLayoutPanel10";
		cu().RowCount = 2;
		cu().RowStyles.Add(new RowStyle());
		cu().RowStyles.Add(new RowStyle());
		cu().Size = new Size(134, 60);
		cu().TabIndex = 0;
		cv().Anchor = AnchorStyles.None;
		cv().AutoSize = true;
		cv().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		cu().SetColumnSpan(cv(), 2);
		cv().Location = new Point(11, 31);
		cv().Name = "ButtonCalibrateGain";
		cv().Size = new Size(112, 26);
		cv().TabIndex = 37;
		cv().Text = "Calibrate Gain...";
		cv().UseVisualStyleBackColor = true;
		cw().Anchor = AnchorStyles.Right;
		cw().AutoSize = true;
		cw().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cw().Location = new Point(3, 6);
		cw().Margin = new Padding(3, 0, 2, 0);
		cw().Name = "Label33";
		cw().Size = new Size(39, 16);
		cw().TabIndex = 31;
		cw().Text = "Gain:";
		cx().Anchor = AnchorStyles.Left;
		cx().f(A_0: true);
		cx().Location = new Point(44, 3);
		cx().Margin = new Padding(0, 3, 3, 3);
		cx().Name = "TextBoxADGainRegSet";
		cx().e(A_0: false);
		cx().Size = new Size(87, 22);
		cx().TabIndex = 32;
		cy().Anchor = AnchorStyles.Top;
		cy().AutoSize = true;
		cy().Controls.Add(cz());
		cy().Location = new Point(3, 200);
		cy().Name = "GroupBoxADOffset";
		cy().Size = new Size(213, 137);
		cy().TabIndex = 8;
		cy().TabStop = false;
		cy().Text = "A/D Offset Settings";
		cy().Visible = false;
		cz().AutoSize = true;
		cz().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		cz().ColumnCount = 2;
		cz().ColumnStyles.Add(new ColumnStyle());
		cz().ColumnStyles.Add(new ColumnStyle());
		cz().Controls.Add(c0(), 1, 2);
		cz().Controls.Add(c1(), 1, 1);
		cz().Controls.Add(c2(), 0, 2);
		cz().Controls.Add(c3(), 0, 1);
		cz().Controls.Add(c4(), 0, 3);
		cz().Controls.Add(c5(), 0, 0);
		cz().Controls.Add(c6(), 1, 0);
		cz().Dock = DockStyle.Fill;
		cz().Location = new Point(3, 18);
		cz().Name = "TableLayoutPanel11";
		cz().RowCount = 4;
		cz().RowStyles.Add(new RowStyle());
		cz().RowStyles.Add(new RowStyle());
		cz().RowStyles.Add(new RowStyle());
		cz().RowStyles.Add(new RowStyle());
		cz().Size = new Size(207, 116);
		cz().TabIndex = 0;
		c0().Anchor = AnchorStyles.Left;
		c0().f(A_0: true);
		c0().Location = new Point(117, 59);
		c0().Margin = new Padding(0, 3, 3, 3);
		c0().Name = "TextBoxADSWOffsetOdd";
		c0().e(A_0: false);
		c0().ReadOnly = true;
		c0().Size = new Size(87, 22);
		c0().TabIndex = 3;
		c1().Anchor = AnchorStyles.Left;
		c1().f(A_0: true);
		c1().Location = new Point(117, 31);
		c1().Margin = new Padding(0, 3, 3, 3);
		c1().Name = "TextBoxADSWOffsetEven";
		c1().e(A_0: false);
		c1().ReadOnly = true;
		c1().Size = new Size(87, 22);
		c1().TabIndex = 2;
		c2().Anchor = AnchorStyles.Right;
		c2().AutoSize = true;
		c2().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c2().Location = new Point(8, 62);
		c2().Margin = new Padding(3, 0, 2, 0);
		c2().Name = "Label37";
		c2().Size = new Size(107, 16);
		c2().TabIndex = 32;
		c2().Text = "SW Offset (Odd):";
		c3().Anchor = AnchorStyles.Right;
		c3().AutoSize = true;
		c3().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c3().Location = new Point(3, 34);
		c3().Margin = new Padding(3, 0, 2, 0);
		c3().Name = "Label36";
		c3().Size = new Size(112, 16);
		c3().TabIndex = 32;
		c3().Text = "SW Offset (Even):";
		c4().Anchor = AnchorStyles.None;
		c4().AutoSize = true;
		c4().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		cz().SetColumnSpan(c4(), 2);
		c4().Location = new Point(41, 87);
		c4().Name = "ButtonCalibrateADOffsets";
		c4().Size = new Size(125, 26);
		c4().TabIndex = 37;
		c4().Text = "Calibrate Offsets...";
		c4().UseVisualStyleBackColor = true;
		c5().Anchor = AnchorStyles.Right;
		c5().AutoSize = true;
		c5().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c5().Location = new Point(48, 6);
		c5().Margin = new Padding(3, 0, 2, 0);
		c5().Name = "Label35";
		c5().Size = new Size(67, 16);
		c5().TabIndex = 31;
		c5().Text = "Hw Offset:";
		c6().Anchor = AnchorStyles.Left;
		c6().f(A_0: true);
		c6().Location = new Point(117, 3);
		c6().Margin = new Padding(0, 3, 3, 3);
		c6().Name = "TextBoxADHWOffset";
		c6().e(A_0: false);
		c6().ReadOnly = true;
		c6().Size = new Size(87, 22);
		c6().TabIndex = 1;
		hf().Controls.Add(hg());
		hf().Location = new Point(3, 3);
		hf().Name = "GroupBoxWaveRes";
		hf().Size = new Size(210, 104);
		hf().TabIndex = 10;
		hf().TabStop = false;
		hf().Text = "Wavelength Resolution";
		hf().Visible = false;
		hg().ColumnCount = 2;
		hg().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		hg().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		hg().Controls.Add(hh(), 0, 0);
		hg().Controls.Add(hi(), 0, 1);
		hg().Controls.Add(hj(), 0, 2);
		hg().Controls.Add(hk(), 1, 0);
		hg().Controls.Add(hl(), 1, 1);
		hg().Controls.Add(hm(), 1, 2);
		hg().Location = new Point(6, 18);
		hg().Name = "TableLayoutPanel22";
		hg().RowCount = 3;
		hg().RowStyles.Add(new RowStyle());
		hg().RowStyles.Add(new RowStyle());
		hg().RowStyles.Add(new RowStyle());
		hg().Size = new Size(204, 86);
		hg().TabIndex = 0;
		hh().Anchor = AnchorStyles.Right;
		hh().AutoSize = true;
		hh().Location = new Point(24, 6);
		hh().Name = "Label73";
		hh().Size = new Size(75, 16);
		hh().TabIndex = 0;
		hh().Text = "Resolution:";
		hi().Anchor = AnchorStyles.Right;
		hi().AutoSize = true;
		hi().Location = new Point(49, 34);
		hi().Name = "Label74";
		hi().Size = new Size(50, 16);
		hi().TabIndex = 1;
		hi().Text = "Slope: ";
		hj().Anchor = AnchorStyles.Right;
		hj().AutoSize = true;
		hj().Location = new Point(9, 63);
		hj().Name = "Label75";
		hj().Size = new Size(90, 16);
		hj().TabIndex = 2;
		hj().Text = "RefWaveLen:";
		hk().Anchor = AnchorStyles.Left;
		hk().f(A_0: false);
		hk().Location = new Point(105, 3);
		hk().Name = "txtNumWaveLenResolution";
		hk().e(A_0: false);
		hk().Size = new Size(95, 22);
		hk().TabIndex = 3;
		hk().Text = "0";
		hl().Anchor = AnchorStyles.Left;
		hl().f(A_0: false);
		hl().Location = new Point(105, 31);
		hl().Name = "txtNumWaveLenResolutionSlope";
		hl().e(A_0: true);
		hl().Size = new Size(95, 22);
		hl().TabIndex = 4;
		hl().Text = "0";
		hm().Anchor = AnchorStyles.Left;
		hm().f(A_0: false);
		hm().Location = new Point(105, 60);
		hm().Name = "txtNumRefWaveLen";
		hm().e(A_0: false);
		hm().Size = new Size(95, 22);
		hm().TabIndex = 5;
		hm().Text = "0";
		dd().Anchor = AnchorStyles.Top;
		dd().AutoSize = true;
		dd().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		dd().Controls.Add(c7());
		dd().Location = new Point(45, 343);
		dd().Name = "GroupBox3";
		dd().Size = new Size(129, 109);
		dd().TabIndex = 9;
		dd().TabStop = false;
		dd().Text = "DC Voltages";
		dd().Visible = false;
		c7().AutoSize = true;
		c7().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		c7().ColumnCount = 2;
		c7().ColumnStyles.Add(new ColumnStyle());
		c7().ColumnStyles.Add(new ColumnStyle());
		c7().Controls.Add(c8(), 1, 1);
		c7().Controls.Add(c9(), 1, 0);
		c7().Controls.Add(da(), 0, 2);
		c7().Controls.Add(db(), 0, 1);
		c7().Controls.Add(dc(), 0, 0);
		c7().Dock = DockStyle.Fill;
		c7().Location = new Point(3, 18);
		c7().Name = "TableLayoutPanel12";
		c7().RowCount = 3;
		c7().RowStyles.Add(new RowStyle());
		c7().RowStyles.Add(new RowStyle());
		c7().RowStyles.Add(new RowStyle());
		c7().Size = new Size(123, 88);
		c7().TabIndex = 31;
		c8().Anchor = AnchorStyles.Left;
		c8().f(A_0: true);
		c8().Location = new Point(72, 31);
		c8().Margin = new Padding(0, 3, 3, 3);
		c8().Name = "TextBoxDCVoltagePot2";
		c8().e(A_0: false);
		c8().Size = new Size(40, 22);
		c8().TabIndex = 34;
		c8().Text = "255";
		c9().Anchor = AnchorStyles.Left;
		c9().f(A_0: true);
		c9().Location = new Point(72, 3);
		c9().Margin = new Padding(0, 3, 3, 3);
		c9().Name = "TextBoxDCVoltagePot1";
		c9().e(A_0: false);
		c9().Size = new Size(40, 22);
		c9().TabIndex = 33;
		c9().Text = "255";
		da().Anchor = AnchorStyles.None;
		da().AutoSize = true;
		da().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		c7().SetColumnSpan(da(), 2);
		da().Location = new Point(3, 59);
		da().Name = "ButtonSetDCVoltages";
		da().Size = new Size(117, 26);
		da().TabIndex = 38;
		da().Text = "Set DC Voltages";
		da().UseVisualStyleBackColor = true;
		db().Anchor = AnchorStyles.Right;
		db().AutoSize = true;
		db().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		db().Location = new Point(3, 34);
		db().Margin = new Padding(3, 0, 2, 0);
		db().Name = "Label39";
		db().Size = new Size(67, 16);
		db().TabIndex = 33;
		db().Text = "Hw Offset:";
		dc().Anchor = AnchorStyles.Right;
		dc().AutoSize = true;
		dc().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dc().Location = new Point(3, 6);
		dc().Margin = new Padding(3, 0, 2, 0);
		dc().Name = "Label38";
		dc().Size = new Size(67, 16);
		dc().TabIndex = 33;
		dc().Text = "Hw Offset:";
		bb().Anchor = AnchorStyles.None;
		bb().AutoSize = true;
		bj().SetColumnSpan(bb(), 2);
		bb().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bb().Location = new Point(190, 819);
		bb().Name = "ButtonUpdate";
		bb().Size = new Size(125, 30);
		bb().TabIndex = 10;
		bb().Text = "Write Firmware";
		bb().UseVisualStyleBackColor = true;
		bm().Anchor = AnchorStyles.Left;
		bm().DropDownStyle = ComboBoxStyle.DropDownList;
		bm().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bm().FormattingEnabled = true;
		bm().Location = new Point(277, 3);
		bm().Name = "ComboBoxSpectrometer";
		bm().Size = new Size(220, 24);
		bm().TabIndex = 30;
		bn().Anchor = AnchorStyles.Right;
		bn().AutoSize = true;
		bn().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bn().Location = new Point(178, 7);
		bn().Margin = new Padding(4, 0, 4, 0);
		bn().Name = "Label28";
		bn().Size = new Size(92, 16);
		bn().TabIndex = 29;
		bn().Text = "Spectrometer:";
		bn().TextAlign = ContentAlignment.MiddleCenter;
		bi().Anchor = AnchorStyles.None;
		bi().AutoSize = true;
		bi().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		bi().ColumnCount = 4;
		bj().SetColumnSpan(bi(), 2);
		bi().ColumnStyles.Add(new ColumnStyle());
		bi().ColumnStyles.Add(new ColumnStyle());
		bi().ColumnStyles.Add(new ColumnStyle());
		bi().ColumnStyles.Add(new ColumnStyle());
		bi().Controls.Add(bc(), 0, 0);
		bi().Controls.Add(bh(), 3, 1);
		bi().Controls.Add(bg(), 3, 0);
		bi().Controls.Add(bf(), 2, 1);
		bi().Controls.Add(be(), 2, 0);
		bi().Controls.Add(bd(), 1, 0);
		bi().Location = new Point(76, 33);
		bi().Name = "TableLayoutPanel5";
		bi().RowCount = 2;
		bi().RowStyles.Add(new RowStyle());
		bi().RowStyles.Add(new RowStyle());
		bi().Size = new Size(354, 56);
		bi().TabIndex = 1;
		bc().Anchor = AnchorStyles.Right;
		bc().AutoSize = true;
		bc().Location = new Point(3, 20);
		bc().Margin = new Padding(3, 0, 2, 0);
		bc().Name = "Label15";
		bi().SetRowSpan(bc(), 2);
		bc().Size = new Size(94, 16);
		bc().TabIndex = 0;
		bc().Text = "Serial number:";
		bh().Anchor = AnchorStyles.Left;
		bh().Location = new Point(256, 31);
		bh().Margin = new Padding(0, 3, 3, 3);
		bh().Name = "TextBoxTime";
		bh().ReadOnly = true;
		bh().Size = new Size(95, 22);
		bh().TabIndex = 5;
		bg().Anchor = AnchorStyles.Left;
		bg().Location = new Point(256, 3);
		bg().Margin = new Padding(0, 3, 3, 3);
		bg().Name = "TextBoxDate";
		bg().ReadOnly = true;
		bg().Size = new Size(95, 22);
		bg().TabIndex = 4;
		bf().Anchor = AnchorStyles.Right;
		bf().AutoSize = true;
		bf().Location = new Point(212, 34);
		bf().Margin = new Padding(3, 0, 2, 0);
		bf().Name = "Label17";
		bf().Size = new Size(42, 16);
		bf().TabIndex = 3;
		bf().Text = "Time:";
		be().Anchor = AnchorStyles.Right;
		be().AutoSize = true;
		be().Location = new Point(214, 6);
		be().Margin = new Padding(3, 0, 2, 0);
		be().Name = "Label16";
		be().Size = new Size(40, 16);
		be().TabIndex = 2;
		be().Text = "Date:";
		bd().Anchor = AnchorStyles.Left;
		bd().Location = new Point(99, 17);
		bd().Margin = new Padding(0, 3, 3, 3);
		bd().Name = "TextBoxSerialNum";
		bd().ReadOnly = true;
		bi().SetRowSpan(bd(), 2);
		bd().Size = new Size(107, 22);
		bd().TabIndex = 1;
		bd().e(A_0: false);
		a1().AutoSize = true;
		a1().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		a1().Controls.Add(a8());
		a1().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a1().Location = new Point(3, 95);
		a1().Name = "GroupBoxCalibration";
		a1().Size = new Size(268, 312);
		a1().TabIndex = 2;
		a1().TabStop = false;
		a1().Text = "Wavelength Calibration";
		a8().AutoSize = true;
		a8().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		a8().ColumnCount = 2;
		a8().ColumnStyles.Add(new ColumnStyle());
		a8().ColumnStyles.Add(new ColumnStyle());
		a8().Controls.Add(l8(), 0, 0);
		a8().Controls.Add(i3(), 1, 2);
		a8().Controls.Add(ix(), 0, 2);
		a8().Controls.Add(iz(), 0, 1);
		a8().Controls.Add(jf(), 0, 3);
		a8().Dock = DockStyle.Fill;
		a8().Location = new Point(3, 18);
		a8().Name = "TableLayoutPanel6";
		a8().RowCount = 4;
		a8().RowStyles.Add(new RowStyle());
		a8().RowStyles.Add(new RowStyle());
		a8().RowStyles.Add(new RowStyle());
		a8().RowStyles.Add(new RowStyle());
		a8().Size = new Size(262, 291);
		a8().TabIndex = 0;
		l8().Anchor = AnchorStyles.None;
		l8().AutoSize = true;
		l8().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		a8().SetColumnSpan(l8(), 2);
		l8().Location = new Point(64, 2);
		l8().Margin = new Padding(3, 2, 3, 3);
		l8().Name = "ButtonShiftWavelengths";
		l8().Size = new Size(134, 26);
		l8().TabIndex = 31;
		l8().Text = "Shift Wavelengths...";
		l8().UseVisualStyleBackColor = true;
		i3().Anchor = AnchorStyles.None;
		i3().AutoSize = true;
		i3().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		i3().Location = new Point(179, 236);
		i3().Margin = new Padding(3, 2, 3, 3);
		i3().Name = "ButtonMeasCalibParams";
		i3().Size = new Size(80, 26);
		i3().TabIndex = 4;
		i3().Text = "Measure...";
		i3().UseVisualStyleBackColor = true;
		ix().DropDownStyle = ComboBoxStyle.DropDownList;
		ix().FormattingEnabled = true;
		ix().Location = new Point(3, 237);
		ix().Name = "ComboBoxCalibFile";
		ix().Size = new Size(170, 24);
		ix().TabIndex = 5;
		a8().SetColumnSpan(iz(), 2);
		iz().Controls.Add(i0());
		iz().Controls.Add(i2());
		iz().ItemSize = new Size(122, 21);
		iz().Location = new Point(3, 34);
		iz().Name = "TabControlWavCal";
		iz().SelectedIndex = 0;
		iz().Size = new Size(249, 197);
		iz().SizeMode = TabSizeMode.Fixed;
		iz().TabIndex = 31;
		i0().Controls.Add(i1());
		i0().Location = new Point(4, 25);
		i0().Name = "WavCal1";
		i0().Padding = new Padding(3);
		i0().Size = new Size(241, 168);
		i0().TabIndex = 0;
		i0().Text = "#1";
		i0().UseVisualStyleBackColor = true;
		i1().AutoSize = true;
		i1().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		i1().ColumnCount = 2;
		i1().ColumnStyles.Add(new ColumnStyle());
		i1().ColumnStyles.Add(new ColumnStyle());
		i1().Controls.Add(la(), 1, 4);
		i1().Controls.Add(lb(), 1, 3);
		i1().Controls.Add(lc(), 0, 4);
		i1().Controls.Add(ld(), 0, 3);
		i1().Controls.Add(i4(), 1, 5);
		i1().Controls.Add(i5(), 0, 5);
		i1().Controls.Add(a2(), 1, 2);
		i1().Controls.Add(a7(), 0, 0);
		i1().Controls.Add(a4(), 1, 0);
		i1().Controls.Add(a5(), 0, 2);
		i1().Controls.Add(a6(), 0, 1);
		i1().Controls.Add(a3(), 1, 1);
		i1().Location = new Point(0, 0);
		i1().Name = "TableLayoutPanel25";
		i1().RowCount = 6;
		i1().RowStyles.Add(new RowStyle());
		i1().RowStyles.Add(new RowStyle());
		i1().RowStyles.Add(new RowStyle());
		i1().RowStyles.Add(new RowStyle());
		i1().RowStyles.Add(new RowStyle());
		i1().RowStyles.Add(new RowStyle());
		i1().Size = new Size(241, 168);
		i1().TabIndex = 0;
		la().Anchor = AnchorStyles.Left;
		la().f(A_0: false);
		la().Location = new Point(148, 115);
		la().Margin = new Padding(0, 3, 3, 3);
		la().Name = "TextBoxFourth";
		la().e(A_0: true);
		la().Size = new Size(90, 22);
		la().TabIndex = 32;
		lb().Anchor = AnchorStyles.Left;
		lb().f(A_0: false);
		lb().Location = new Point(148, 87);
		lb().Margin = new Padding(0, 3, 3, 3);
		lb().Name = "TextBoxThird";
		lb().e(A_0: true);
		lb().Size = new Size(90, 22);
		lb().TabIndex = 31;
		lc().Anchor = AnchorStyles.Right;
		lc().AutoSize = true;
		lc().Location = new Point(23, 118);
		lc().Margin = new Padding(3, 0, 2, 0);
		lc().Name = "Label100";
		lc().Size = new Size(123, 16);
		lc().TabIndex = 31;
		lc().Text = "Fourth (nm^4/pixel):";
		ld().Anchor = AnchorStyles.Right;
		ld().AutoSize = true;
		ld().Location = new Point(29, 90);
		ld().Margin = new Padding(3, 0, 2, 0);
		ld().Name = "Label99";
		ld().Size = new Size(117, 16);
		ld().TabIndex = 31;
		ld().Text = "Third (nm^3/pixel):";
		i4().Anchor = AnchorStyles.Left;
		i4().f(A_0: false);
		i4().Location = new Point(148, 143);
		i4().Margin = new Padding(0, 3, 3, 3);
		i4().Name = "TextBoxNumWavCalTemp1";
		i4().e(A_0: false);
		i4().Size = new Size(90, 22);
		i4().TabIndex = 5;
		i5().Anchor = AnchorStyles.Right;
		i5().AutoSize = true;
		i5().Location = new Point(37, 146);
		i5().Margin = new Padding(3, 0, 2, 0);
		i5().Name = "Label85";
		i5().Size = new Size(109, 16);
		i5().TabIndex = 4;
		i5().Text = "Temperature (C):";
		a2().Anchor = AnchorStyles.Left;
		a2().f(A_0: false);
		a2().Location = new Point(148, 59);
		a2().Margin = new Padding(0, 3, 3, 3);
		a2().Name = "TextBoxCurvature";
		a2().e(A_0: true);
		a2().Size = new Size(90, 22);
		a2().TabIndex = 3;
		a7().Anchor = AnchorStyles.Right;
		a7().AutoSize = true;
		a7().Location = new Point(72, 6);
		a7().Margin = new Padding(3, 0, 2, 0);
		a7().Name = "Label1";
		a7().Size = new Size(74, 16);
		a7().TabIndex = 0;
		a7().Text = "Offset (nm):";
		a4().Anchor = AnchorStyles.Left;
		a4().f(A_0: false);
		a4().Location = new Point(148, 3);
		a4().Margin = new Padding(0, 3, 3, 3);
		a4().Name = "TextBoxOffset";
		a4().e(A_0: false);
		a4().Size = new Size(90, 22);
		a4().TabIndex = 1;
		a5().Anchor = AnchorStyles.Right;
		a5().AutoSize = true;
		a5().Location = new Point(3, 62);
		a5().Margin = new Padding(3, 0, 2, 0);
		a5().Name = "Label3";
		a5().Size = new Size(143, 16);
		a5().TabIndex = 2;
		a5().Text = "Curvature (nm^2/pixel):";
		a6().Anchor = AnchorStyles.Right;
		a6().AutoSize = true;
		a6().Location = new Point(38, 34);
		a6().Margin = new Padding(3, 0, 2, 0);
		a6().Name = "Label2";
		a6().Size = new Size(108, 16);
		a6().TabIndex = 1;
		a6().Text = "Slope (nm/pixel):";
		a3().Anchor = AnchorStyles.Left;
		a3().f(A_0: false);
		a3().Location = new Point(148, 31);
		a3().Margin = new Padding(0, 3, 3, 3);
		a3().Name = "TextBoxSlope";
		a3().e(A_0: false);
		a3().Size = new Size(90, 22);
		a3().TabIndex = 2;
		i2().Controls.Add(i6());
		i2().Location = new Point(4, 25);
		i2().Name = "WavCal2";
		i2().Padding = new Padding(3);
		i2().Size = new Size(241, 168);
		i2().TabIndex = 1;
		i2().Text = "#2";
		i2().UseVisualStyleBackColor = true;
		i6().AutoSize = true;
		i6().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		i6().ColumnCount = 2;
		i6().ColumnStyles.Add(new ColumnStyle());
		i6().ColumnStyles.Add(new ColumnStyle());
		i6().Controls.Add(le(), 1, 4);
		i6().Controls.Add(lf(), 1, 3);
		i6().Controls.Add(lg(), 0, 4);
		i6().Controls.Add(lh(), 0, 3);
		i6().Controls.Add(i7(), 1, 5);
		i6().Controls.Add(i8(), 0, 5);
		i6().Controls.Add(i9(), 1, 2);
		i6().Controls.Add(ja(), 0, 0);
		i6().Controls.Add(jb(), 1, 0);
		i6().Controls.Add(jc(), 0, 2);
		i6().Controls.Add(jd(), 0, 1);
		i6().Controls.Add(je(), 1, 1);
		i6().Location = new Point(0, 0);
		i6().Name = "TableLayoutPanel30";
		i6().RowCount = 6;
		i6().RowStyles.Add(new RowStyle());
		i6().RowStyles.Add(new RowStyle());
		i6().RowStyles.Add(new RowStyle());
		i6().RowStyles.Add(new RowStyle());
		i6().RowStyles.Add(new RowStyle());
		i6().RowStyles.Add(new RowStyle());
		i6().Size = new Size(241, 168);
		i6().TabIndex = 31;
		le().Anchor = AnchorStyles.Left;
		le().f(A_0: false);
		le().Location = new Point(148, 115);
		le().Margin = new Padding(0, 3, 3, 3);
		le().Name = "TextBoxFourth2";
		le().e(A_0: true);
		le().Size = new Size(90, 22);
		le().TabIndex = 33;
		lf().Anchor = AnchorStyles.Left;
		lf().f(A_0: false);
		lf().Location = new Point(148, 87);
		lf().Margin = new Padding(0, 3, 3, 3);
		lf().Name = "TextBoxThird2";
		lf().e(A_0: true);
		lf().Size = new Size(90, 22);
		lf().TabIndex = 32;
		lg().Anchor = AnchorStyles.Right;
		lg().AutoSize = true;
		lg().Location = new Point(23, 118);
		lg().Margin = new Padding(3, 0, 2, 0);
		lg().Name = "Label102";
		lg().Size = new Size(123, 16);
		lg().TabIndex = 32;
		lg().Text = "Fourth (nm^4/pixel):";
		lh().Anchor = AnchorStyles.Right;
		lh().AutoSize = true;
		lh().Location = new Point(29, 90);
		lh().Margin = new Padding(3, 0, 2, 0);
		lh().Name = "Label101";
		lh().Size = new Size(117, 16);
		lh().TabIndex = 32;
		lh().Text = "Third (nm^3/pixel):";
		i7().Anchor = AnchorStyles.Left;
		i7().f(A_0: false);
		i7().Location = new Point(148, 143);
		i7().Margin = new Padding(0, 3, 3, 3);
		i7().Name = "TextBoxNumWavCalTemp2";
		i7().e(A_0: true);
		i7().Size = new Size(90, 22);
		i7().TabIndex = 5;
		i8().Anchor = AnchorStyles.Right;
		i8().AutoSize = true;
		i8().Location = new Point(37, 146);
		i8().Margin = new Padding(3, 0, 2, 0);
		i8().Name = "Label86";
		i8().Size = new Size(109, 16);
		i8().TabIndex = 4;
		i8().Text = "Temperature (C):";
		i9().Anchor = AnchorStyles.Left;
		i9().f(A_0: false);
		i9().Location = new Point(148, 59);
		i9().Margin = new Padding(0, 3, 3, 3);
		i9().Name = "TextBoxCurvature2";
		i9().e(A_0: true);
		i9().Size = new Size(90, 22);
		i9().TabIndex = 3;
		ja().Anchor = AnchorStyles.Right;
		ja().AutoSize = true;
		ja().Location = new Point(72, 6);
		ja().Margin = new Padding(3, 0, 2, 0);
		ja().Name = "Label87";
		ja().Size = new Size(74, 16);
		ja().TabIndex = 0;
		ja().Text = "Offset (nm):";
		jb().Anchor = AnchorStyles.Left;
		jb().f(A_0: false);
		jb().Location = new Point(148, 3);
		jb().Margin = new Padding(0, 3, 3, 3);
		jb().Name = "TextBoxOffset2";
		jb().e(A_0: false);
		jb().Size = new Size(90, 22);
		jb().TabIndex = 1;
		jc().Anchor = AnchorStyles.Right;
		jc().AutoSize = true;
		jc().Location = new Point(3, 62);
		jc().Margin = new Padding(3, 0, 2, 0);
		jc().Name = "Label88";
		jc().Size = new Size(143, 16);
		jc().TabIndex = 2;
		jc().Text = "Curvature (nm^2/pixel):";
		jd().Anchor = AnchorStyles.Right;
		jd().AutoSize = true;
		jd().Location = new Point(38, 34);
		jd().Margin = new Padding(3, 0, 2, 0);
		jd().Name = "Label93";
		jd().Size = new Size(108, 16);
		jd().TabIndex = 1;
		jd().Text = "Slope (nm/pixel):";
		je().Anchor = AnchorStyles.Left;
		je().f(A_0: false);
		je().Location = new Point(148, 31);
		je().Margin = new Padding(0, 3, 3, 3);
		je().Name = "TextBoxSlope2";
		je().e(A_0: false);
		je().Size = new Size(90, 22);
		je().TabIndex = 2;
		jf().Anchor = AnchorStyles.Left;
		jf().AutoSize = true;
		a8().SetColumnSpan(jf(), 2);
		jf().Location = new Point(3, 268);
		jf().Name = "CheckBoxCalibParamsFromFile";
		jf().Size = new Size(159, 20);
		jf().TabIndex = 32;
		jf().Text = "Use spectrum from file";
		jf().UseVisualStyleBackColor = true;
		bk().Controls.Add(ht());
		bk().Location = new Point(3, 413);
		bk().Name = "GroupBoxScatter";
		bk().Size = new Size(261, 350);
		bk().TabIndex = 3;
		bk().TabStop = false;
		bk().Text = "Stray Light";
		bk().Visible = false;
		ht().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ht().ColumnCount = 1;
		ht().ColumnStyles.Add(new ColumnStyle());
		ht().Controls.Add(bl(), 0, 2);
		ht().Controls.Add(g5(), 0, 1);
		ht().Controls.Add(j2(), 0, 0);
		ht().Dock = DockStyle.Fill;
		ht().Location = new Point(3, 18);
		ht().Name = "TableLayoutPanel23";
		ht().RowCount = 3;
		ht().RowStyles.Add(new RowStyle());
		ht().RowStyles.Add(new RowStyle());
		ht().RowStyles.Add(new RowStyle());
		ht().Size = new Size(255, 329);
		ht().TabIndex = 0;
		bl().Anchor = AnchorStyles.None;
		bl().AutoSize = true;
		bl().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		bl().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bl().Location = new Point(87, 297);
		bl().Name = "ButtonMeasureDCScatter";
		bl().Size = new Size(80, 26);
		bl().TabIndex = 36;
		bl().Text = "Measure...";
		bl().UseVisualStyleBackColor = true;
		g5().Controls.Add(g6());
		g5().Controls.Add(jg());
		g5().Controls.Add(g7());
		g5().Dock = DockStyle.Fill;
		g5().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		g5().ItemSize = new Size(118, 21);
		g5().Location = new Point(3, 49);
		g5().Name = "TabControlScatter";
		g5().SelectedIndex = 0;
		g5().Size = new Size(249, 240);
		g5().SizeMode = TabSizeMode.Fixed;
		g5().TabIndex = 31;
		g6().Controls.Add(j5());
		g6().Location = new Point(4, 25);
		g6().Name = "TabPageScattered";
		g6().Padding = new Padding(3);
		g6().Size = new Size(241, 211);
		g6().TabIndex = 0;
		g6().Text = "Scattered";
		g6().UseVisualStyleBackColor = true;
		j5().AllowDrop = true;
		j5().AutoScroll = true;
		j5().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		j5().ColumnCount = 2;
		j5().ColumnStyles.Add(new ColumnStyle());
		j5().ColumnStyles.Add(new ColumnStyle());
		j5().Controls.Add(j6(), 1, 2);
		j5().Controls.Add(j7(), 0, 2);
		j5().Controls.Add(j8(), 1, 1);
		j5().Controls.Add(j9(), 0, 1);
		j5().Controls.Add(ka(), 1, 8);
		j5().Controls.Add(kb(), 1, 7);
		j5().Controls.Add(kc(), 1, 6);
		j5().Controls.Add(kd(), 1, 5);
		j5().Controls.Add(ke(), 1, 4);
		j5().Controls.Add(kf(), 0, 8);
		j5().Controls.Add(kg(), 0, 7);
		j5().Controls.Add(kh(), 0, 6);
		j5().Controls.Add(ki(), 0, 5);
		j5().Controls.Add(kj(), 0, 4);
		j5().Controls.Add(kk(), 0, 3);
		j5().Controls.Add(kl(), 1, 3);
		j5().Controls.Add(km(), 1, 0);
		j5().Controls.Add(kn(), 0, 0);
		j5().Location = new Point(3, 3);
		j5().MaximumSize = new Size(250, 300);
		j5().Name = "TableLayoutPanelScattered";
		j5().RowCount = 9;
		j5().RowStyles.Add(new RowStyle());
		j5().RowStyles.Add(new RowStyle());
		j5().RowStyles.Add(new RowStyle());
		j5().RowStyles.Add(new RowStyle());
		j5().RowStyles.Add(new RowStyle());
		j5().RowStyles.Add(new RowStyle());
		j5().RowStyles.Add(new RowStyle());
		j5().RowStyles.Add(new RowStyle());
		j5().RowStyles.Add(new RowStyle());
		j5().Size = new Size(235, 210);
		j5().TabIndex = 1;
		j6().Anchor = AnchorStyles.Left;
		j6().f(A_0: false);
		j6().Location = new Point(123, 59);
		j6().Margin = new Padding(0, 3, 3, 3);
		j6().Name = "TextBoxScatterTransEndWave";
		j6().e(A_0: false);
		j6().Size = new Size(85, 22);
		j6().TabIndex = 3;
		j7().Anchor = AnchorStyles.Right;
		j7().AutoSize = true;
		j7().Location = new Point(9, 62);
		j7().Margin = new Padding(3, 0, 2, 0);
		j7().Name = "Label41";
		j7().Size = new Size(112, 16);
		j7().TabIndex = 32;
		j7().Text = "Trans End Wave:";
		j8().Anchor = AnchorStyles.Left;
		j8().f(A_0: false);
		j8().Location = new Point(123, 31);
		j8().Margin = new Padding(0, 3, 3, 3);
		j8().Name = "TextBoxScatterTransStartWave";
		j8().e(A_0: false);
		j8().Size = new Size(85, 22);
		j8().TabIndex = 2;
		j9().Anchor = AnchorStyles.Right;
		j9().AutoSize = true;
		j9().Location = new Point(6, 34);
		j9().Margin = new Padding(3, 0, 2, 0);
		j9().Name = "Label40";
		j9().Size = new Size(115, 16);
		j9().TabIndex = 31;
		j9().Text = "Trans Start Wave:";
		ka().Anchor = AnchorStyles.Left;
		ka().f(A_0: true);
		ka().Location = new Point(123, 227);
		ka().Margin = new Padding(0, 3, 3, 3);
		ka().Name = "TextBoxShortNarrowNumPts";
		ka().e(A_0: false);
		ka().Size = new Size(85, 22);
		ka().TabIndex = 9;
		kb().Anchor = AnchorStyles.Left;
		kb().f(A_0: false);
		kb().Location = new Point(123, 199);
		kb().Margin = new Padding(0, 3, 3, 3);
		kb().Name = "TextBoxShortNarrowCoeff";
		kb().e(A_0: false);
		kb().Size = new Size(85, 22);
		kb().TabIndex = 8;
		kc().Anchor = AnchorStyles.Left;
		kc().f(A_0: true);
		kc().Location = new Point(123, 171);
		kc().Margin = new Padding(0, 3, 3, 3);
		kc().Name = "TextBoxShortBroadNumPts";
		kc().e(A_0: false);
		kc().Size = new Size(85, 22);
		kc().TabIndex = 7;
		kd().Anchor = AnchorStyles.Left;
		kd().f(A_0: false);
		kd().Location = new Point(123, 143);
		kd().Margin = new Padding(0, 3, 3, 3);
		kd().Name = "TextBoxShortBroadIntercept";
		kd().e(A_0: false);
		kd().Size = new Size(85, 22);
		kd().TabIndex = 6;
		ke().Anchor = AnchorStyles.Left;
		ke().f(A_0: false);
		ke().Location = new Point(123, 115);
		ke().Margin = new Padding(0, 3, 3, 3);
		ke().Name = "TextBoxShortBroadSlope";
		ke().e(A_0: false);
		ke().Size = new Size(85, 22);
		ke().TabIndex = 5;
		kf().Anchor = AnchorStyles.Right;
		kf().AutoSize = true;
		kf().Location = new Point(5, 230);
		kf().Margin = new Padding(3, 0, 2, 0);
		kf().Name = "Label14";
		kf().Size = new Size(116, 16);
		kf().TabIndex = 34;
		kf().Text = "Short narrow # pts:";
		kg().Anchor = AnchorStyles.Right;
		kg().AutoSize = true;
		kg().Location = new Point(4, 202);
		kg().Margin = new Padding(3, 0, 2, 0);
		kg().Name = "Label13";
		kg().Size = new Size(117, 16);
		kg().TabIndex = 33;
		kg().Text = "Short narrow coeff:";
		kh().Anchor = AnchorStyles.Right;
		kh().AutoSize = true;
		kh().Location = new Point(12, 174);
		kh().Margin = new Padding(3, 0, 2, 0);
		kh().Name = "Label12";
		kh().Size = new Size(109, 16);
		kh().TabIndex = 33;
		kh().Text = "Short board #pts:";
		ki().Anchor = AnchorStyles.Right;
		ki().AutoSize = true;
		ki().Location = new Point(6, 146);
		ki().Margin = new Padding(3, 0, 2, 0);
		ki().Name = "Label11";
		ki().Size = new Size(115, 16);
		ki().TabIndex = 32;
		ki().Text = "Short board intcpt:";
		kj().Anchor = AnchorStyles.Right;
		kj().AutoSize = true;
		kj().Location = new Point(3, 118);
		kj().Margin = new Padding(3, 0, 2, 0);
		kj().Name = "Label10";
		kj().Size = new Size(118, 16);
		kj().TabIndex = 31;
		kj().Text = "Short board slope:";
		kk().Anchor = AnchorStyles.Right;
		kk().AutoSize = true;
		kk().Location = new Point(10, 90);
		kk().Margin = new Padding(3, 0, 2, 0);
		kk().Name = "Label22";
		kk().Size = new Size(111, 16);
		kk().TabIndex = 1;
		kk().Text = "Long wavelenths:";
		kl().Anchor = AnchorStyles.Left;
		kl().f(A_0: false);
		kl().Location = new Point(123, 87);
		kl().Margin = new Padding(0, 3, 3, 3);
		kl().Name = "TextBoxLongScatter";
		kl().e(A_0: false);
		kl().Size = new Size(85, 22);
		kl().TabIndex = 4;
		km().Anchor = AnchorStyles.Left;
		km().f(A_0: false);
		km().Location = new Point(123, 3);
		km().Margin = new Padding(0, 3, 3, 3);
		km().Name = "TextBoxShortScatter";
		km().e(A_0: false);
		km().Size = new Size(85, 22);
		km().TabIndex = 1;
		kn().Anchor = AnchorStyles.Right;
		kn().AutoSize = true;
		kn().Location = new Point(9, 6);
		kn().Margin = new Padding(3, 0, 2, 0);
		kn().Name = "Label21";
		kn().Size = new Size(112, 16);
		kn().TabIndex = 0;
		kn().Text = "Short wavelenths:";
		jg().Controls.Add(jh());
		jg().Location = new Point(4, 25);
		jg().Name = "TabPageScatteredLED";
		jg().Padding = new Padding(3);
		jg().Size = new Size(241, 211);
		jg().TabIndex = 2;
		jg().Text = "Scattered (LED)";
		jg().UseVisualStyleBackColor = true;
		jh().AutoSize = true;
		jh().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		jh().ColumnCount = 2;
		jh().ColumnStyles.Add(new ColumnStyle());
		jh().ColumnStyles.Add(new ColumnStyle());
		jh().Controls.Add(jx(), 0, 3);
		jh().Controls.Add(jv(), 1, 2);
		jh().Controls.Add(jw(), 0, 2);
		jh().Controls.Add(ji(), 1, 0);
		jh().Controls.Add(jj(), 0, 1);
		jh().Controls.Add(jk(), 0, 0);
		jh().Controls.Add(jl(), 1, 1);
		jh().Dock = DockStyle.Top;
		jh().Location = new Point(3, 3);
		jh().Name = "TableLayoutPanel31";
		jh().RowCount = 4;
		jh().RowStyles.Add(new RowStyle());
		jh().RowStyles.Add(new RowStyle());
		jh().RowStyles.Add(new RowStyle());
		jh().RowStyles.Add(new RowStyle());
		jh().Size = new Size(235, 116);
		jh().TabIndex = 0;
		jx().Anchor = AnchorStyles.None;
		jx().AutoSize = true;
		jx().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		jh().SetColumnSpan(jx(), 2);
		jx().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		jx().Location = new Point(78, 87);
		jx().Name = "ButtonOptimizeLEDEfficiencyAndOffset";
		jx().Size = new Size(79, 26);
		jx().TabIndex = 37;
		jx().Text = "Optimize...";
		jx().UseVisualStyleBackColor = true;
		jv().Anchor = AnchorStyles.Left;
		jv().f(A_0: false);
		jv().Location = new Point(123, 59);
		jv().Margin = new Padding(0, 3, 3, 3);
		jv().Name = "TextBoxNumericLEDScatterLongWLOffsetCoeff";
		jv().e(A_0: true);
		jv().Size = new Size(87, 22);
		jv().TabIndex = 5;
		jw().Anchor = AnchorStyles.Right;
		jw().AutoSize = true;
		jw().Location = new Point(3, 62);
		jw().Name = "Label98";
		jw().Size = new Size(117, 16);
		jw().TabIndex = 34;
		jw().Text = "Long Wave Offset:";
		ji().Anchor = AnchorStyles.Left;
		ji().f(A_0: false);
		ji().Location = new Point(123, 3);
		ji().Margin = new Padding(0, 3, 3, 3);
		ji().Name = "TextBoxNumericMaxScattCoeff";
		ji().e(A_0: false);
		ji().ReadOnly = true;
		ji().Size = new Size(87, 22);
		ji().TabIndex = 33;
		jj().Anchor = AnchorStyles.Right;
		jj().AutoSize = true;
		jj().Location = new Point(7, 34);
		jj().Name = "Label95";
		jj().Size = new Size(113, 16);
		jj().TabIndex = 5;
		jj().Text = "Scatter Efficiency:";
		jk().Anchor = AnchorStyles.Right;
		jk().AutoSize = true;
		jk().Location = new Point(50, 6);
		jk().Name = "Label94";
		jk().Size = new Size(70, 16);
		jk().TabIndex = 1;
		jk().Text = "Max Coeff:";
		jl().Anchor = AnchorStyles.Left;
		jl().f(A_0: false);
		jl().Location = new Point(123, 31);
		jl().Margin = new Padding(0, 3, 3, 3);
		jl().Name = "TextBoxNumericScatterEfficiency";
		jl().e(A_0: true);
		jl().Size = new Size(87, 22);
		jl().TabIndex = 4;
		g7().Controls.Add(hv());
		g7().Location = new Point(4, 25);
		g7().Name = "TabPage2ndOrder";
		g7().Padding = new Padding(3);
		g7().Size = new Size(241, 211);
		g7().TabIndex = 1;
		g7().Text = "2nd Order";
		g7().UseVisualStyleBackColor = true;
		hv().AutoScroll = true;
		hv().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		hv().ColumnCount = 1;
		hv().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		hv().Controls.Add(hw(), 0, 1);
		hv().Controls.Add(g8(), 0, 0);
		hv().Dock = DockStyle.Top;
		hv().Location = new Point(3, 3);
		hv().Name = "TableLayoutPanel2ndOrder";
		hv().RowCount = 2;
		hv().RowStyles.Add(new RowStyle());
		hv().RowStyles.Add(new RowStyle());
		hv().Size = new Size(235, 215);
		hv().TabIndex = 1;
		hw().Anchor = AnchorStyles.None;
		hw().AutoSize = true;
		hw().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		hw().ColumnCount = 2;
		hw().ColumnStyles.Add(new ColumnStyle());
		hw().ColumnStyles.Add(new ColumnStyle());
		hw().Controls.Add(hx(), 0, 0);
		hw().Controls.Add(hy(), 0, 1);
		hw().Controls.Add(hz(), 1, 0);
		hw().Controls.Add(h0(), 1, 1);
		hw().Location = new Point(17, 177);
		hw().Name = "TLP2ndOrderGen2";
		hw().RowCount = 2;
		hw().RowStyles.Add(new RowStyle());
		hw().RowStyles.Add(new RowStyle());
		hw().Size = new Size(200, 56);
		hw().TabIndex = 1;
		hx().Anchor = AnchorStyles.None;
		hx().AutoSize = true;
		hx().Location = new Point(6, 6);
		hx().Name = "Label81";
		hx().Size = new Size(92, 16);
		hx().TabIndex = 0;
		hx().Text = "NumOfPoints: ";
		hy().Anchor = AnchorStyles.None;
		hy().AutoSize = true;
		hy().Location = new Point(3, 34);
		hy().Name = "Label82";
		hy().Size = new Size(98, 16);
		hy().TabIndex = 1;
		hy().Text = "AverageValue:";
		hz().Anchor = AnchorStyles.None;
		hz().f(A_0: false);
		hz().Location = new Point(107, 3);
		hz().Name = "txtNumericNumOfPoints";
		hz().e(A_0: false);
		hz().ReadOnly = true;
		hz().Size = new Size(90, 22);
		hz().TabIndex = 2;
		h0().Anchor = AnchorStyles.None;
		h0().f(A_0: false);
		h0().Location = new Point(107, 31);
		h0().Name = "txtNumericAverageValue";
		h0().e(A_0: false);
		h0().ReadOnly = true;
		h0().Size = new Size(90, 22);
		h0().TabIndex = 3;
		g8().Anchor = AnchorStyles.Left;
		g8().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		g8().ColumnCount = 2;
		g8().ColumnStyles.Add(new ColumnStyle());
		g8().ColumnStyles.Add(new ColumnStyle());
		g8().Controls.Add(g9(), 0, 0);
		g8().Controls.Add(ha(), 0, 1);
		g8().Controls.Add(hb(), 0, 2);
		g8().Controls.Add(hc(), 1, 0);
		g8().Controls.Add(hd(), 1, 1);
		g8().Controls.Add(he(), 1, 2);
		g8().Controls.Add(hn(), 0, 3);
		g8().Controls.Add(ho(), 0, 4);
		g8().Controls.Add(hp(), 0, 5);
		g8().Controls.Add(hq(), 1, 3);
		g8().Controls.Add(hr(), 1, 4);
		g8().Controls.Add(hs(), 1, 5);
		g8().Location = new Point(3, 3);
		g8().Name = "TLP2ndOrderGen1";
		g8().RowCount = 6;
		g8().RowStyles.Add(new RowStyle());
		g8().RowStyles.Add(new RowStyle());
		g8().RowStyles.Add(new RowStyle());
		g8().RowStyles.Add(new RowStyle());
		g8().RowStyles.Add(new RowStyle());
		g8().RowStyles.Add(new RowStyle());
		g8().Size = new Size(202, 168);
		g8().TabIndex = 0;
		g9().Anchor = AnchorStyles.Right;
		g9().AutoSize = true;
		g9().Location = new Point(26, 6);
		g9().Name = "Label69";
		g9().Size = new Size(80, 16);
		g9().TabIndex = 0;
		g9().Text = "Ratio Offset:";
		ha().Anchor = AnchorStyles.Right;
		ha().AutoSize = true;
		ha().Location = new Point(24, 34);
		ha().Name = "Label71";
		ha().Size = new Size(82, 16);
		ha().TabIndex = 1;
		ha().Text = "Ratio Slope:";
		hb().Anchor = AnchorStyles.Right;
		hb().AutoSize = true;
		hb().Location = new Point(3, 62);
		hb().Name = "Label72";
		hb().Size = new Size(103, 16);
		hb().TabIndex = 2;
		hb().Text = "Ratio Curvature:";
		hc().Anchor = AnchorStyles.Left;
		hc().f(A_0: false);
		hc().Location = new Point(112, 3);
		hc().Name = "txtNum2ndOrderCoeff0";
		hc().e(A_0: true);
		hc().Size = new Size(87, 22);
		hc().TabIndex = 3;
		hd().Anchor = AnchorStyles.Left;
		hd().f(A_0: false);
		hd().Location = new Point(112, 31);
		hd().Name = "txtNum2ndOrderCoeff1";
		hd().e(A_0: true);
		hd().Size = new Size(87, 22);
		hd().TabIndex = 4;
		he().Anchor = AnchorStyles.Left;
		he().f(A_0: false);
		he().Location = new Point(112, 59);
		he().Name = "txtNum2ndOrderCoeff2";
		he().e(A_0: true);
		he().Size = new Size(87, 22);
		he().TabIndex = 5;
		hn().Anchor = AnchorStyles.Right;
		hn().AutoSize = true;
		hn().Location = new Point(34, 90);
		hn().Name = "Label76";
		hn().Size = new Size(72, 16);
		hn().TabIndex = 6;
		hn().Text = "Sine Ampl:";
		ho().Anchor = AnchorStyles.Right;
		ho().AutoSize = true;
		ho().Location = new Point(23, 118);
		ho().Name = "Label77";
		ho().Size = new Size(83, 16);
		ho().TabIndex = 7;
		ho().Text = "Sine Phase :";
		hp().Anchor = AnchorStyles.Right;
		hp().AutoSize = true;
		hp().Location = new Point(34, 146);
		hp().Name = "Label78";
		hp().Size = new Size(72, 16);
		hp().TabIndex = 8;
		hp().Text = "Sine Freq :";
		hq().f(A_0: false);
		hq().Location = new Point(112, 87);
		hq().Name = "txtNum2ndOrderCoeff3";
		hq().e(A_0: true);
		hq().Size = new Size(87, 22);
		hq().TabIndex = 9;
		hr().f(A_0: false);
		hr().Location = new Point(112, 115);
		hr().Name = "txtNum2ndOrderCoeff4";
		hr().e(A_0: true);
		hr().Size = new Size(87, 22);
		hr().TabIndex = 10;
		hs().f(A_0: false);
		hs().Location = new Point(112, 143);
		hs().Name = "txtNum2ndOrderCoeff5";
		hs().e(A_0: true);
		hs().Size = new Size(87, 22);
		hs().TabIndex = 11;
		j2().Anchor = AnchorStyles.None;
		j2().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		j2().Controls.Add(j3());
		j2().Controls.Add(j4());
		j2().Location = new Point(9, 3);
		j2().Name = "GroupScatterMethod";
		j2().Size = new Size(236, 40);
		j2().TabIndex = 37;
		j2().TabStop = false;
		j2().Text = "Method";
		j3().AutoSize = true;
		j3().Location = new Point(116, 15);
		j3().Name = "RadioButtonLEDs";
		j3().Size = new Size(94, 20);
		j3().TabIndex = 1;
		j3().TabStop = true;
		j3().Text = "Scatter Box";
		j3().UseVisualStyleBackColor = true;
		j4().AutoSize = true;
		j4().Location = new Point(32, 15);
		j4().Name = "RadioButtonFilters";
		j4().Size = new Size(70, 20);
		j4().TabIndex = 0;
		j4().TabStop = true;
		j4().Text = "Manual";
		j4().UseVisualStyleBackColor = true;
		bp().Anchor = AnchorStyles.None;
		bp().AutoSize = true;
		bp().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		bp().ColumnCount = 2;
		bp().ColumnStyles.Add(new ColumnStyle());
		bp().ColumnStyles.Add(new ColumnStyle());
		bp().Controls.Add(bs(), 0, 1);
		bp().Controls.Add(bq(), 1, 0);
		bp().Controls.Add(br(), 0, 0);
		bp().Location = new Point(530, 807);
		bp().Name = "TLPFirmwareRev";
		bp().RowCount = 2;
		bp().RowStyles.Add(new RowStyle());
		bp().RowStyles.Add(new RowStyle());
		bp().Size = new Size(177, 54);
		bp().TabIndex = 11;
		bp().Visible = false;
		bs().Anchor = AnchorStyles.None;
		bs().AutoSize = true;
		bp().SetColumnSpan(bs(), 2);
		bs().Location = new Point(3, 31);
		bs().Name = "CheckBoxUpdateRevLevel";
		bs().Size = new Size(171, 20);
		bs().TabIndex = 37;
		bs().Text = "Update revision to latest";
		bs().UseVisualStyleBackColor = true;
		bq().Anchor = AnchorStyles.Left;
		bq().f(A_0: true);
		bq().Location = new Point(121, 3);
		bq().Margin = new Padding(0, 3, 3, 3);
		bq().Name = "TextBoxNumFirmwareRev";
		bq().e(A_0: false);
		bq().Size = new Size(35, 22);
		bq().TabIndex = 31;
		br().Anchor = AnchorStyles.Right;
		br().AutoSize = true;
		br().Location = new Point(3, 6);
		br().Margin = new Padding(3, 0, 2, 0);
		br().Name = "Label18";
		br().Size = new Size(116, 16);
		br().TabIndex = 31;
		br().Text = "Firmware revision:";
		gg().Controls.Add(gh());
		gg().Location = new Point(4, 25);
		gg().Name = "TabPageMemBlocks";
		gg().Padding = new Padding(3);
		gg().Size = new Size(892, 871);
		gg().TabIndex = 3;
		gg().Text = "MemBlocks";
		gg().UseVisualStyleBackColor = true;
		gh().AutoSize = true;
		gh().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		gh().ColumnCount = 1;
		gh().ColumnStyles.Add(new ColumnStyle());
		gh().Controls.Add(gp(), 0, 1);
		gh().Controls.Add(gq(), 0, 2);
		gh().Controls.Add(gs(), 0, 0);
		gh().Location = new Point(0, 0);
		gh().Name = "TableLayoutPanel15";
		gh().RowCount = 3;
		gh().RowStyles.Add(new RowStyle());
		gh().RowStyles.Add(new RowStyle());
		gh().RowStyles.Add(new RowStyle());
		gh().Size = new Size(438, 501);
		gh().TabIndex = 0;
		gp().Anchor = AnchorStyles.Top;
		gp().AutoSize = true;
		gp().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		gp().Controls.Add(gv());
		gp().Location = new Point(3, 39);
		gp().Name = "GroupBoxCurrentMemBlocks";
		gp().Size = new Size(432, 200);
		gp().TabIndex = 37;
		gp().TabStop = false;
		gp().Text = "Current Memory Blocks";
		gv().AutoSize = true;
		gv().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		gv().ColumnCount = 1;
		gv().ColumnStyles.Add(new ColumnStyle());
		gv().Controls.Add(gw(), 0, 1);
		gv().Controls.Add(gl(), 0, 0);
		gv().Location = new Point(20, 21);
		gv().Name = "TableLayoutPanel19";
		gv().RowCount = 2;
		gv().RowStyles.Add(new RowStyle());
		gv().RowStyles.Add(new RowStyle());
		gv().Size = new Size(406, 158);
		gv().TabIndex = 35;
		gw().Anchor = AnchorStyles.None;
		gw().AutoSize = true;
		gw().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		gw().Location = new Point(165, 125);
		gw().Name = "ButtonClearExistingMemBlocks";
		gw().Size = new Size(75, 30);
		gw().TabIndex = 35;
		gw().Text = "Clear";
		gu().SetToolTip(gw(), "Erase all of the current memory blocks.");
		gw().UseVisualStyleBackColor = true;
		gl().FormattingEnabled = true;
		gl().HorizontalScrollbar = true;
		gl().ItemHeight = 16;
		gl().Location = new Point(3, 3);
		gl().Name = "ListBoxCurrentMemBlocks";
		gl().SelectionMode = SelectionMode.None;
		gl().Size = new Size(400, 116);
		gl().TabIndex = 34;
		gq().Anchor = AnchorStyles.Top;
		gq().AutoSize = true;
		gq().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		gq().Controls.Add(gr());
		gq().Location = new Point(5, 245);
		gq().Name = "GroupBoxNewMemBlocks";
		gq().Size = new Size(427, 253);
		gq().TabIndex = 38;
		gq().TabStop = false;
		gq().Text = "New CTM Cal Memory Blocks";
		gq().Visible = false;
		gr().AutoSize = true;
		gr().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		gr().ColumnCount = 1;
		gr().ColumnStyles.Add(new ColumnStyle());
		gr().Controls.Add(gi(), 0, 0);
		gr().Controls.Add(gm(), 0, 1);
		gr().Location = new Point(15, 36);
		gr().Name = "TableLayoutPanel17";
		gr().RowCount = 2;
		gr().RowStyles.Add(new RowStyle());
		gr().RowStyles.Add(new RowStyle());
		gr().Size = new Size(406, 196);
		gr().TabIndex = 0;
		gi().FormattingEnabled = true;
		gi().ItemHeight = 16;
		gi().Location = new Point(3, 3);
		gi().Name = "ListBoxNewMemBlocks";
		gi().Size = new Size(400, 148);
		gi().TabIndex = 35;
		gm().Anchor = AnchorStyles.None;
		gm().AutoSize = true;
		gm().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		gm().ColumnCount = 3;
		gm().ColumnStyles.Add(new ColumnStyle());
		gm().ColumnStyles.Add(new ColumnStyle());
		gm().ColumnStyles.Add(new ColumnStyle());
		gm().ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
		gm().Controls.Add(gt(), 0, 0);
		gm().Controls.Add(go(), 0, 0);
		gm().Controls.Add(gn(), 2, 0);
		gm().Location = new Point(71, 157);
		gm().Name = "TableLayoutPanel16";
		gm().RowCount = 1;
		gm().RowStyles.Add(new RowStyle());
		gm().Size = new Size(263, 36);
		gm().TabIndex = 36;
		gt().Anchor = AnchorStyles.None;
		gt().AutoSize = true;
		gt().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		gt().Location = new Point(94, 3);
		gt().Name = "ButtonClearNewMemBlocks";
		gt().Size = new Size(75, 30);
		gt().TabIndex = 5;
		gt().Text = "Clear";
		gu().SetToolTip(gt(), "Clear the list of CTM Cal files\r\nselected for writing to memory.");
		gt().UseVisualStyleBackColor = true;
		go().Anchor = AnchorStyles.None;
		go().AutoSize = true;
		go().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		go().Location = new Point(3, 3);
		go().Margin = new Padding(3, 3, 13, 3);
		go().Name = "ButtonAddNewMemBlocks";
		go().Size = new Size(75, 30);
		go().TabIndex = 3;
		go().Text = "Add...";
		gu().SetToolTip(go(), "Browse to select CTM Cal files to\r\nbe written to memory blocks.");
		go().UseVisualStyleBackColor = true;
		gn().Anchor = AnchorStyles.None;
		gn().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		gn().Location = new Point(185, 3);
		gn().Margin = new Padding(13, 3, 3, 3);
		gn().Name = "ButtonWriteNewMemBlocks";
		gn().Size = new Size(75, 30);
		gn().TabIndex = 4;
		gn().Text = "Write";
		gu().SetToolTip(gn(), "Write selected CTM Cal files to memory.\r\nNote: current Non-CTM Cal memory\r\nblocks will be preserved while current\r\nCTM Cal memory blocks will be overwritten.");
		gn().UseVisualStyleBackColor = true;
		gs().Anchor = AnchorStyles.None;
		gs().AutoSize = true;
		gs().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		gs().ColumnCount = 2;
		gs().ColumnStyles.Add(new ColumnStyle());
		gs().ColumnStyles.Add(new ColumnStyle());
		gs().Controls.Add(gj(), 0, 0);
		gs().Controls.Add(gk(), 1, 0);
		gs().Location = new Point(56, 3);
		gs().Name = "TableLayoutPanel18";
		gs().RowCount = 1;
		gs().RowStyles.Add(new RowStyle());
		gs().Size = new Size(326, 30);
		gs().TabIndex = 39;
		gj().Anchor = AnchorStyles.Right;
		gj().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		gj().Location = new Point(4, 7);
		gj().Margin = new Padding(4, 0, 4, 0);
		gj().Name = "Label48";
		gj().Size = new Size(92, 16);
		gj().TabIndex = 30;
		gj().Text = "Spectrometer:";
		gj().TextAlign = ContentAlignment.MiddleCenter;
		gk().Anchor = AnchorStyles.Left;
		gk().DropDownStyle = ComboBoxStyle.DropDownList;
		gk().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		gk().FormattingEnabled = true;
		gk().Location = new Point(103, 3);
		gk().Name = "ComboBoxMemBlockSpectrometers";
		gk().Size = new Size(220, 24);
		gk().TabIndex = 31;
		fx().Controls.Add(fy());
		fx().Location = new Point(4, 25);
		fx().Name = "TabPagePhotodiodeLed";
		fx().Padding = new Padding(3);
		fx().Size = new Size(892, 871);
		fx().TabIndex = 2;
		fx().Text = "Photodiode/LED";
		fx().UseVisualStyleBackColor = true;
		fy().AutoSize = true;
		fy().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		fy().ColumnCount = 3;
		fy().ColumnStyles.Add(new ColumnStyle());
		fy().ColumnStyles.Add(new ColumnStyle());
		fy().ColumnStyles.Add(new ColumnStyle());
		fy().Controls.Add(fz(), 0, 4);
		fy().Controls.Add(f0(), 1, 0);
		fy().Controls.Add(f1(), 0, 0);
		fy().Controls.Add(f2(), 0, 1);
		fy().Controls.Add(f9(), 0, 2);
		fy().Controls.Add(gc(), 2, 4);
		fy().Location = new Point(0, 0);
		fy().Name = "TLPPhotodiodeLed";
		fy().RowCount = 5;
		fy().RowStyles.Add(new RowStyle());
		fy().RowStyles.Add(new RowStyle());
		fy().RowStyles.Add(new RowStyle());
		fy().RowStyles.Add(new RowStyle());
		fy().RowStyles.Add(new RowStyle());
		fy().Size = new Size(645, 309);
		fy().TabIndex = 1;
		fz().Anchor = AnchorStyles.None;
		fz().AutoSize = true;
		fy().SetColumnSpan(fz(), 2);
		fz().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		fz().Location = new Point(168, 264);
		fz().Name = "ButtonPhotodiodeWriteFW";
		fz().Size = new Size(125, 30);
		fz().TabIndex = 10;
		fz().Text = "Write Firmware";
		fz().UseVisualStyleBackColor = true;
		f0().Anchor = AnchorStyles.Left;
		f0().DropDownStyle = ComboBoxStyle.DropDownList;
		f0().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f0().FormattingEnabled = true;
		f0().Location = new Point(239, 3);
		f0().Name = "ComboBoxPhotodiode";
		f0().Size = new Size(220, 24);
		f0().TabIndex = 30;
		f1().Anchor = AnchorStyles.Right;
		f1().AutoSize = true;
		f1().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f1().Location = new Point(121, 7);
		f1().Margin = new Padding(4, 0, 4, 0);
		f1().Name = "Label83";
		f1().Size = new Size(111, 16);
		f1().TabIndex = 29;
		f1().Text = "Photodiode/LED:";
		f1().TextAlign = ContentAlignment.MiddleCenter;
		f2().Anchor = AnchorStyles.None;
		f2().AutoSize = true;
		f2().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		f2().ColumnCount = 4;
		fy().SetColumnSpan(f2(), 2);
		f2().ColumnStyles.Add(new ColumnStyle());
		f2().ColumnStyles.Add(new ColumnStyle());
		f2().ColumnStyles.Add(new ColumnStyle());
		f2().ColumnStyles.Add(new ColumnStyle());
		f2().Controls.Add(f3(), 0, 0);
		f2().Controls.Add(f4(), 3, 1);
		f2().Controls.Add(f5(), 3, 0);
		f2().Controls.Add(f6(), 2, 1);
		f2().Controls.Add(f7(), 2, 0);
		f2().Controls.Add(f8(), 1, 0);
		f2().Location = new Point(54, 33);
		f2().Name = "TableLayoutPanel26";
		f2().RowCount = 2;
		f2().RowStyles.Add(new RowStyle());
		f2().RowStyles.Add(new RowStyle());
		f2().Size = new Size(354, 56);
		f2().TabIndex = 1;
		f3().Anchor = AnchorStyles.Right;
		f3().AutoSize = true;
		f3().Location = new Point(3, 20);
		f3().Margin = new Padding(3, 0, 2, 0);
		f3().Name = "Label89";
		f2().SetRowSpan(f3(), 2);
		f3().Size = new Size(94, 16);
		f3().TabIndex = 0;
		f3().Text = "Serial number:";
		f4().Anchor = AnchorStyles.Left;
		f4().Location = new Point(256, 31);
		f4().Margin = new Padding(0, 3, 3, 3);
		f4().Name = "TextBoxPhotodiodeTime";
		f4().ReadOnly = true;
		f4().Size = new Size(95, 22);
		f4().TabIndex = 5;
		f5().Anchor = AnchorStyles.Left;
		f5().Location = new Point(256, 3);
		f5().Margin = new Padding(0, 3, 3, 3);
		f5().Name = "TextBoxPhotodiodeDate";
		f5().ReadOnly = true;
		f5().Size = new Size(95, 22);
		f5().TabIndex = 4;
		f6().Anchor = AnchorStyles.Right;
		f6().AutoSize = true;
		f6().Location = new Point(212, 34);
		f6().Margin = new Padding(3, 0, 2, 0);
		f6().Name = "Label90";
		f6().Size = new Size(42, 16);
		f6().TabIndex = 3;
		f6().Text = "Time:";
		f7().Anchor = AnchorStyles.Right;
		f7().AutoSize = true;
		f7().Location = new Point(214, 6);
		f7().Margin = new Padding(3, 0, 2, 0);
		f7().Name = "Label91";
		f7().Size = new Size(40, 16);
		f7().TabIndex = 2;
		f7().Text = "Date:";
		f8().Anchor = AnchorStyles.Left;
		f8().Location = new Point(99, 17);
		f8().Margin = new Padding(0, 3, 3, 3);
		f8().Name = "TextBoxPhotodiodeSN";
		f8().ReadOnly = true;
		f2().SetRowSpan(f8(), 2);
		f8().Size = new Size(107, 22);
		f8().TabIndex = 1;
		f8().e(A_0: false);
		f9().AutoSize = true;
		f9().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		f9().Controls.Add(ga());
		f9().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f9().Location = new Point(3, 95);
		f9().Name = "GroupBox7";
		f9().Size = new Size(230, 151);
		f9().TabIndex = 2;
		f9().TabStop = false;
		f9().Text = "Hardware Configuration";
		ga().AutoSize = true;
		ga().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ga().ColumnCount = 3;
		ga().ColumnStyles.Add(new ColumnStyle());
		ga().ColumnStyles.Add(new ColumnStyle());
		ga().ColumnStyles.Add(new ColumnStyle());
		ga().Controls.Add(g4(), 1, 0);
		ga().Controls.Add(g3(), 0, 1);
		ga().Controls.Add(gx(), 1, 4);
		ga().Controls.Add(gy(), 1, 3);
		ga().Controls.Add(gz(), 0, 4);
		ga().Controls.Add(g0(), 0, 3);
		ga().Controls.Add(g1(), 1, 2);
		ga().Controls.Add(g2(), 0, 2);
		ga().Controls.Add(gb(), 0, 0);
		ga().Dock = DockStyle.Fill;
		ga().Location = new Point(3, 18);
		ga().Name = "TableLayoutPanel27";
		ga().RowCount = 5;
		ga().RowStyles.Add(new RowStyle());
		ga().RowStyles.Add(new RowStyle());
		ga().RowStyles.Add(new RowStyle());
		ga().RowStyles.Add(new RowStyle());
		ga().RowStyles.Add(new RowStyle());
		ga().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		ga().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		ga().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		ga().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		ga().Size = new Size(224, 130);
		ga().TabIndex = 0;
		g4().DropDownStyle = ComboBoxStyle.DropDownList;
		g4().FormattingEnabled = true;
		g4().Location = new Point(137, 3);
		g4().Name = "ComboBoxPDNumPDs";
		g4().Size = new Size(40, 24);
		g4().TabIndex = 31;
		g3().Anchor = AnchorStyles.None;
		g3().AutoSize = true;
		ga().SetColumnSpan(g3(), 2);
		g3().Location = new Point(32, 30);
		g3().Margin = new Padding(3, 0, 2, 0);
		g3().Name = "Label70";
		g3().Size = new Size(160, 16);
		g3().TabIndex = 32;
		g3().Text = "Photodiode Wavelengths";
		gx().Anchor = AnchorStyles.Left;
		gx().f(A_0: false);
		gx().Location = new Point(134, 105);
		gx().Margin = new Padding(0, 3, 3, 3);
		gx().Name = "TextBoxNumPD3Wavelen";
		gx().e(A_0: false);
		gx().Size = new Size(87, 22);
		gx().TabIndex = 32;
		gy().Anchor = AnchorStyles.Left;
		gy().f(A_0: false);
		gy().Location = new Point(134, 77);
		gy().Margin = new Padding(0, 3, 3, 3);
		gy().Name = "TextBoxNumPD2Wavelen";
		gy().e(A_0: false);
		gy().Size = new Size(87, 22);
		gy().TabIndex = 32;
		gz().Anchor = AnchorStyles.Right;
		gz().AutoSize = true;
		gz().Location = new Point(107, 108);
		gz().Margin = new Padding(3, 0, 2, 0);
		gz().Name = "Label51";
		gz().Size = new Size(25, 16);
		gz().TabIndex = 32;
		gz().Text = "#3:";
		g0().Anchor = AnchorStyles.Right;
		g0().AutoSize = true;
		g0().Location = new Point(107, 80);
		g0().Margin = new Padding(3, 0, 2, 0);
		g0().Name = "Label50";
		g0().Size = new Size(25, 16);
		g0().TabIndex = 32;
		g0().Text = "#2:";
		g1().Anchor = AnchorStyles.Left;
		g1().f(A_0: false);
		g1().Location = new Point(134, 49);
		g1().Margin = new Padding(0, 3, 3, 3);
		g1().Name = "TextBoxNumPD1Wavelen";
		g1().e(A_0: false);
		g1().Size = new Size(87, 22);
		g1().TabIndex = 31;
		g2().Anchor = AnchorStyles.Right;
		g2().AutoSize = true;
		g2().Location = new Point(107, 52);
		g2().Margin = new Padding(3, 0, 2, 0);
		g2().Name = "Label49";
		g2().Size = new Size(25, 16);
		g2().TabIndex = 31;
		g2().Text = "#1:";
		gb().Anchor = AnchorStyles.Right;
		gb().AutoSize = true;
		gb().Location = new Point(3, 7);
		gb().Margin = new Padding(3, 0, 2, 0);
		gb().Name = "Label92";
		gb().Size = new Size(129, 16);
		gb().TabIndex = 0;
		gb().Text = "# Photodiode inputs:";
		gc().Anchor = AnchorStyles.None;
		gc().AutoSize = true;
		gc().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		gc().ColumnCount = 2;
		gc().ColumnStyles.Add(new ColumnStyle());
		gc().ColumnStyles.Add(new ColumnStyle());
		gc().Controls.Add(gd(), 0, 1);
		gc().Controls.Add(ge(), 1, 0);
		gc().Controls.Add(gf(), 0, 0);
		gc().Location = new Point(465, 252);
		gc().Name = "TableLayoutPanel29";
		gc().RowCount = 2;
		gc().RowStyles.Add(new RowStyle());
		gc().RowStyles.Add(new RowStyle());
		gc().Size = new Size(177, 54);
		gc().TabIndex = 11;
		gd().Anchor = AnchorStyles.None;
		gd().AutoSize = true;
		gc().SetColumnSpan(gd(), 2);
		gd().Location = new Point(3, 31);
		gd().Name = "CheckBoxPhotodiodeUpdateRev";
		gd().Size = new Size(171, 20);
		gd().TabIndex = 37;
		gd().Text = "Update revision to latest";
		gd().UseVisualStyleBackColor = true;
		ge().Anchor = AnchorStyles.Left;
		ge().f(A_0: true);
		ge().Location = new Point(121, 3);
		ge().Margin = new Padding(0, 3, 3, 3);
		ge().Name = "TextBoxPhotodiodeFWRev";
		ge().e(A_0: false);
		ge().Size = new Size(35, 22);
		ge().TabIndex = 31;
		gf().Anchor = AnchorStyles.Right;
		gf().AutoSize = true;
		gf().Location = new Point(3, 6);
		gf().Margin = new Padding(3, 0, 2, 0);
		gf().Name = "Label104";
		gf().Size = new Size(116, 16);
		gf().TabIndex = 31;
		gf().Text = "Firmware revision:";
		iw().Anchor = AnchorStyles.None;
		iw().AutoSize = true;
		iw().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		iw().Location = new Point(353, 942);
		iw().Name = "LabelNoHardware";
		iw().Size = new Size(200, 16);
		iw().TabIndex = 31;
		iw().Text = "(No Hardware in this subsystem)";
		iw().Visible = false;
		gu().AutoPopDelay = 15000;
		gu().InitialDelay = 500;
		gu().ReshowDelay = 100;
		jy().Interval = 40;
		l9().Anchor = AnchorStyles.None;
		l9().AutoSize = true;
		l9().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		l9().Controls.Add(ma());
		l9().Location = new Point(4, 629);
		l9().Name = "GroupBox1";
		l9().Size = new Size(217, 49);
		l9().TabIndex = 33;
		l9().TabStop = false;
		l9().Text = "SS-TransCurved";
		ma().AutoSize = true;
		ma().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ma().ColumnCount = 2;
		ma().ColumnStyles.Add(new ColumnStyle());
		ma().ColumnStyles.Add(new ColumnStyle());
		ma().Controls.Add(mb(), 1, 0);
		ma().Controls.Add(mc(), 0, 0);
		ma().Dock = DockStyle.Fill;
		ma().Location = new Point(3, 18);
		ma().Name = "TableLayoutPanel33";
		ma().RowCount = 1;
		ma().RowStyles.Add(new RowStyle());
		ma().RowStyles.Add(new RowStyle(SizeType.Absolute, 28f));
		ma().Size = new Size(211, 28);
		ma().TabIndex = 32;
		mb().Anchor = AnchorStyles.Left;
		mb().f(A_0: false);
		mb().Location = new Point(118, 3);
		mb().Margin = new Padding(0, 3, 3, 3);
		mb().Name = "TBNTransCurvedCorrection";
		mb().e(A_0: false);
		mb().Size = new Size(90, 22);
		mb().TabIndex = 33;
		mc().Anchor = AnchorStyles.Right;
		mc().AutoSize = true;
		mc().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		mc().Location = new Point(3, 6);
		mc().Margin = new Padding(3, 0, 2, 0);
		mc().Name = "Label103";
		mc().Size = new Size(113, 16);
		mc().TabIndex = 33;
		mc().Text = "Correction Factor:";
		base.AcceptButton = al();
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoScroll = true;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = al();
		base.ClientSize = new Size(1109, 688);
		base.Controls.Add(an());
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogFirmwareSetting";
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.Manual;
		Text = " Spectrometer Wavelength Calibration";
		an().ResumeLayout(performLayout: false);
		an().PerformLayout();
		ks().ResumeLayout(performLayout: false);
		ks().PerformLayout();
		ap().ResumeLayout(performLayout: false);
		ap().PerformLayout();
		ao().ResumeLayout(performLayout: false);
		bo().ResumeLayout(performLayout: false);
		bo().PerformLayout();
		ky().ResumeLayout(performLayout: false);
		ky().PerformLayout();
		k3().ResumeLayout(performLayout: false);
		k3().PerformLayout();
		ew().ResumeLayout(performLayout: false);
		ew().PerformLayout();
		fl().ResumeLayout(performLayout: false);
		fl().PerformLayout();
		im().ResumeLayout(performLayout: false);
		im().PerformLayout();
		e1().ResumeLayout(performLayout: false);
		e1().PerformLayout();
		en().ResumeLayout(performLayout: false);
		en().PerformLayout();
		ii().ResumeLayout(performLayout: false);
		ii().PerformLayout();
		kp().ResumeLayout(performLayout: false);
		kp().PerformLayout();
		d2().ResumeLayout(performLayout: false);
		d2().PerformLayout();
		ep().ResumeLayout(performLayout: false);
		ep().PerformLayout();
		em().ResumeLayout(performLayout: false);
		em().PerformLayout();
		@is().ResumeLayout(performLayout: false);
		@is().PerformLayout();
		ex().ResumeLayout(performLayout: false);
		ex().PerformLayout();
		fh().ResumeLayout(performLayout: false);
		fh().PerformLayout();
		fv().ResumeLayout(performLayout: false);
		fv().PerformLayout();
		ey().ResumeLayout(performLayout: false);
		ey().PerformLayout();
		ba().ResumeLayout(performLayout: false);
		ba().PerformLayout();
		kz().ResumeLayout(performLayout: false);
		kz().PerformLayout();
		bj().ResumeLayout(performLayout: false);
		bj().PerformLayout();
		h7().ResumeLayout(performLayout: false);
		h7().PerformLayout();
		h9().ResumeLayout(performLayout: false);
		h9().PerformLayout();
		ia().ResumeLayout(performLayout: false);
		ia().PerformLayout();
		ar().ResumeLayout(performLayout: false);
		ar().PerformLayout();
		a9().ResumeLayout(performLayout: false);
		a9().PerformLayout();
		bt().ResumeLayout(performLayout: false);
		bu().ResumeLayout(performLayout: false);
		bu().PerformLayout();
		bv().ResumeLayout(performLayout: false);
		bv().PerformLayout();
		by().ResumeLayout(performLayout: false);
		by().PerformLayout();
		b2().ResumeLayout(performLayout: false);
		b2().PerformLayout();
		ce().ResumeLayout(performLayout: false);
		ce().PerformLayout();
		ca().ResumeLayout(performLayout: false);
		ca().PerformLayout();
		de().ResumeLayout(performLayout: false);
		de().PerformLayout();
		l3().ResumeLayout(performLayout: false);
		l3().PerformLayout();
		l4().ResumeLayout(performLayout: false);
		l4().PerformLayout();
		k4().ResumeLayout(performLayout: false);
		k4().PerformLayout();
		k5().ResumeLayout(performLayout: false);
		k5().PerformLayout();
		jm().ResumeLayout(performLayout: false);
		jm().PerformLayout();
		jn().ResumeLayout(performLayout: false);
		jn().PerformLayout();
		ct().ResumeLayout(performLayout: false);
		ct().PerformLayout();
		cu().ResumeLayout(performLayout: false);
		cu().PerformLayout();
		cy().ResumeLayout(performLayout: false);
		cy().PerformLayout();
		cz().ResumeLayout(performLayout: false);
		cz().PerformLayout();
		hf().ResumeLayout(performLayout: false);
		hg().ResumeLayout(performLayout: false);
		hg().PerformLayout();
		dd().ResumeLayout(performLayout: false);
		dd().PerformLayout();
		c7().ResumeLayout(performLayout: false);
		c7().PerformLayout();
		bi().ResumeLayout(performLayout: false);
		bi().PerformLayout();
		a1().ResumeLayout(performLayout: false);
		a1().PerformLayout();
		a8().ResumeLayout(performLayout: false);
		a8().PerformLayout();
		iz().ResumeLayout(performLayout: false);
		i0().ResumeLayout(performLayout: false);
		i0().PerformLayout();
		i1().ResumeLayout(performLayout: false);
		i1().PerformLayout();
		i2().ResumeLayout(performLayout: false);
		i2().PerformLayout();
		i6().ResumeLayout(performLayout: false);
		i6().PerformLayout();
		bk().ResumeLayout(performLayout: false);
		ht().ResumeLayout(performLayout: false);
		ht().PerformLayout();
		g5().ResumeLayout(performLayout: false);
		g6().ResumeLayout(performLayout: false);
		j5().ResumeLayout(performLayout: false);
		j5().PerformLayout();
		jg().ResumeLayout(performLayout: false);
		jg().PerformLayout();
		jh().ResumeLayout(performLayout: false);
		jh().PerformLayout();
		g7().ResumeLayout(performLayout: false);
		hv().ResumeLayout(performLayout: false);
		hv().PerformLayout();
		hw().ResumeLayout(performLayout: false);
		hw().PerformLayout();
		g8().ResumeLayout(performLayout: false);
		g8().PerformLayout();
		j2().ResumeLayout(performLayout: false);
		j2().PerformLayout();
		bp().ResumeLayout(performLayout: false);
		bp().PerformLayout();
		gg().ResumeLayout(performLayout: false);
		gg().PerformLayout();
		gh().ResumeLayout(performLayout: false);
		gh().PerformLayout();
		gp().ResumeLayout(performLayout: false);
		gp().PerformLayout();
		gv().ResumeLayout(performLayout: false);
		gv().PerformLayout();
		gq().ResumeLayout(performLayout: false);
		gq().PerformLayout();
		gr().ResumeLayout(performLayout: false);
		gr().PerformLayout();
		gm().ResumeLayout(performLayout: false);
		gm().PerformLayout();
		gs().ResumeLayout(performLayout: false);
		fx().ResumeLayout(performLayout: false);
		fx().PerformLayout();
		fy().ResumeLayout(performLayout: false);
		fy().PerformLayout();
		f2().ResumeLayout(performLayout: false);
		f2().PerformLayout();
		f9().ResumeLayout(performLayout: false);
		f9().PerformLayout();
		ga().ResumeLayout(performLayout: false);
		ga().PerformLayout();
		gc().ResumeLayout(performLayout: false);
		gc().PerformLayout();
		l9().ResumeLayout(performLayout: false);
		l9().PerformLayout();
		ma().ResumeLayout(performLayout: false);
		ma().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button al()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label am()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel an()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabControl ao()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TabControl A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ap()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox aq()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
	{
		EventHandler value = q;
		ComboBox comboBox = this.m_g;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_g = A_0;
		comboBox = this.m_g;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ar()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(GroupBox A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy @as()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hy A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy at()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(hy A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label au()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label av()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox aw()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(CheckBox A_0)
	{
		EventHandler value = ah;
		CheckBox checkBox = this.m_m;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_m = A_0;
		checkBox = this.m_m;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox ax()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ComboBox A_0)
	{
		EventHandler value = z;
		ComboBox comboBox = this.m_n;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_n = A_0;
		comboBox = this.m_n;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ay()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label az()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a0()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox a1()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(GroupBox A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy a2()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(hy A_0)
	{
		EventHandler value = f;
		hy hy2 = this.m_s;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_s = A_0;
		hy2 = this.m_s;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy a3()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(hy A_0)
	{
		EventHandler value = f;
		hy hy2 = this.m_t;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_t = A_0;
		hy2 = this.m_t;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy a4()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(hy A_0)
	{
		EventHandler value = f;
		hy hy2 = this.m_u;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_u = A_0;
		hy2 = this.m_u;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a5()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Label A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a6()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Label A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a7()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Label A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel a8()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
	{
		this.m_y = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel a9()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TableLayoutPanel A_0)
	{
		this.m_z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage ba()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TabPage A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button bb()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = al;
		Button button = this.m_ab;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ab = A_0;
		button = this.m_ab;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bc()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Label A_0)
	{
		this.m_ac = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx bd()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hx A_0)
	{
		this.m_ad = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label be()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Label A_0)
	{
		this.m_ae = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bf()
	{
		return this.m_af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(Label A_0)
	{
		this.m_af = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox bg()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TextBox A_0)
	{
		this.m_ag = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox bh()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TextBox A_0)
	{
		this.m_ah = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel bi()
	{
		return this.m_ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TableLayoutPanel A_0)
	{
		this.m_ai = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel bj()
	{
		return this.m_aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(TableLayoutPanel A_0)
	{
		this.m_aj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox bk()
	{
		return this.m_ak;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(GroupBox A_0)
	{
		this.m_ak = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button bl()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = an;
		Button button = this.m_al;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_al = A_0;
		button = this.m_al;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox bm()
	{
		return this.m_am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ComboBox A_0)
	{
		EventHandler value = s;
		ComboBox comboBox = this.m_am;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_am = A_0;
		comboBox = this.m_am;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bn()
	{
		return this.m_an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(Label A_0)
	{
		this.m_an = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage bo()
	{
		return this.m_ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TabPage A_0)
	{
		this.m_ao = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel bp()
	{
		return this.m_ap;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(TableLayoutPanel A_0)
	{
		this.m_ap = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy bq()
	{
		return this.m_aq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(hy A_0)
	{
		EventHandler value = e;
		hy hy2 = this.m_aq;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_aq = A_0;
		hy2 = this.m_aq;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label br()
	{
		return this.m_ar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(Label A_0)
	{
		this.m_ar = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox bs()
	{
		return this.m_as;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(CheckBox A_0)
	{
		EventHandler value = ab;
		CheckBox checkBox = this.m_as;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_as = A_0;
		checkBox = this.m_as;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabControl bt()
	{
		return this.m_at;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TabControl A_0)
	{
		this.m_at = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage bu()
	{
		return this.m_au;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TabPage A_0)
	{
		this.m_au = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel bv()
	{
		return this.m_av;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(TableLayoutPanel A_0)
	{
		this.m_av = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bw()
	{
		return this.m_aw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(Label A_0)
	{
		this.m_aw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bx()
	{
		return this.m_ax;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(Label A_0)
	{
		this.m_ax = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage by()
	{
		return this.m_ay;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TabPage A_0)
	{
		this.m_ay = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy bz()
	{
		return this.m_az;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(hy A_0)
	{
		this.m_az = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy b0()
	{
		return this.m_a0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(hy A_0)
	{
		this.m_a0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button b1()
	{
		return this.m_a1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Button A_0)
	{
		this.m_a1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel b2()
	{
		return this.m_a2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TableLayoutPanel A_0)
	{
		this.m_a2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b3()
	{
		return this.m_a3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(Label A_0)
	{
		this.m_a3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b4()
	{
		return this.m_a4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(Label A_0)
	{
		this.m_a4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b5()
	{
		return this.m_a5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(Label A_0)
	{
		this.m_a5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b6()
	{
		return this.m_a6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(Label A_0)
	{
		this.m_a6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b7()
	{
		return this.m_a7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(Label A_0)
	{
		this.m_a7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b8()
	{
		return this.m_a8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(Label A_0)
	{
		this.m_a8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b9()
	{
		return this.m_a9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(Label A_0)
	{
		this.m_a9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ca()
	{
		return this.m_ba;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(TableLayoutPanel A_0)
	{
		this.m_ba = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy cb()
	{
		return this.m_bb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(hy A_0)
	{
		this.m_bb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cc()
	{
		return this.m_bc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(Label A_0)
	{
		this.m_bc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cd()
	{
		return this.m_bd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(Label A_0)
	{
		this.m_bd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ce()
	{
		return this.m_be;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(TableLayoutPanel A_0)
	{
		this.m_be = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy cf()
	{
		return this.m_bf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(hy A_0)
	{
		this.m_bf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cg()
	{
		return this.m_bg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(Label A_0)
	{
		this.m_bg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ch()
	{
		return this.m_bh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(hy A_0)
	{
		this.m_bh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ci()
	{
		return this.m_bi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(hy A_0)
	{
		this.m_bi = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy cj()
	{
		return this.m_bj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(hy A_0)
	{
		this.m_bj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ck()
	{
		return this.m_bk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(hy A_0)
	{
		this.m_bk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy cl()
	{
		return this.m_bl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(hy A_0)
	{
		this.m_bl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy cm()
	{
		return this.m_bm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(hy A_0)
	{
		this.m_bm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy cn()
	{
		return this.m_bn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(hy A_0)
	{
		this.m_bn = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy co()
	{
		return this.m_bo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(hy A_0)
	{
		this.m_bo = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy cp()
	{
		return this.m_bp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(hy A_0)
	{
		this.m_bp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy cq()
	{
		return this.m_bq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(hy A_0)
	{
		this.m_bq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button cr()
	{
		return this.m_br;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Button A_0)
	{
		EventHandler value = ao;
		Button button = this.m_br;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_br = A_0;
		button = this.m_br;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button cs()
	{
		return this.m_bs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Button A_0)
	{
		EventHandler value = ao;
		Button button = this.m_bs;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_bs = A_0;
		button = this.m_bs;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ct()
	{
		return this.m_bt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(GroupBox A_0)
	{
		this.m_bt = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel cu()
	{
		return this.m_bu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(TableLayoutPanel A_0)
	{
		this.m_bu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button cv()
	{
		return this.m_bv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Button A_0)
	{
		EventHandler value = ax;
		Button button = this.m_bv;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_bv = A_0;
		button = this.m_bv;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cw()
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
	internal virtual hy cx()
	{
		return this.m_bx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(hy A_0)
	{
		this.m_bx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox cy()
	{
		return this.m_by;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(GroupBox A_0)
	{
		this.m_by = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel cz()
	{
		return this.m_bz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(TableLayoutPanel A_0)
	{
		this.m_bz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy c0()
	{
		return this.m_b0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(hy A_0)
	{
		this.m_b0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy c1()
	{
		return this.m_b1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(hy A_0)
	{
		this.m_b1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c2()
	{
		return this.m_b2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(Label A_0)
	{
		this.m_b2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c3()
	{
		return this.m_b3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(Label A_0)
	{
		this.m_b3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button c4()
	{
		return this.m_b4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Button A_0)
	{
		EventHandler value = av;
		Button button = this.m_b4;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_b4 = A_0;
		button = this.m_b4;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c5()
	{
		return this.m_b5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(Label A_0)
	{
		this.m_b5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy c6()
	{
		return this.m_b6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(hy A_0)
	{
		this.m_b6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel c7()
	{
		return this.m_b7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(TableLayoutPanel A_0)
	{
		this.m_b7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy c8()
	{
		return this.m_b8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(hy A_0)
	{
		this.m_b8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy c9()
	{
		return this.m_b9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(hy A_0)
	{
		this.m_b9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button da()
	{
		return this.m_ca;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Button A_0)
	{
		this.m_ca = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label db()
	{
		return this.m_cb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ae(Label A_0)
	{
		this.m_cb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label dc()
	{
		return this.m_cc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void af(Label A_0)
	{
		this.m_cc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox dd()
	{
		return this.m_cd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(GroupBox A_0)
	{
		this.m_cd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel de()
	{
		return this.m_ce;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(TableLayoutPanel A_0)
	{
		this.m_ce = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox df()
	{
		return this.m_cf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(ComboBox A_0)
	{
		this.m_cf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox dg()
	{
		return this.m_cg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(ComboBox A_0)
	{
		EventHandler value = y;
		ComboBox comboBox = this.m_cg;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_cg = A_0;
		comboBox = this.m_cg;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label dh()
	{
		return this.m_ch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ag(Label A_0)
	{
		this.m_ch = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label di()
	{
		return this.m_ci;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ah(Label A_0)
	{
		this.m_ci = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label dj()
	{
		return this.m_cj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ai(Label A_0)
	{
		this.m_cj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label dk()
	{
		return this.m_ck;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aj(Label A_0)
	{
		this.m_ck = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox dl()
	{
		return this.m_cl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(ComboBox A_0)
	{
		EventHandler value = w;
		ComboBox comboBox = this.m_cl;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_cl = A_0;
		comboBox = this.m_cl;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox dm()
	{
		return this.m_cm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(ComboBox A_0)
	{
		EventHandler value = u;
		ComboBox comboBox = this.m_cm;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_cm = A_0;
		comboBox = this.m_cm;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label dn()
	{
		return this.m_cn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ak(Label A_0)
	{
		this.m_cn = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label @do()
	{
		return this.m_co;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void al(Label A_0)
	{
		this.m_co = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox dp()
	{
		return this.m_cp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(ComboBox A_0)
	{
		EventHandler value = v;
		ComboBox comboBox = this.m_cp;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_cp = A_0;
		comboBox = this.m_cp;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label dq()
	{
		return this.m_cq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void am(Label A_0)
	{
		this.m_cq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button dr()
	{
		return this.m_cr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Button A_0)
	{
		EventHandler value = aq;
		Button button = this.m_cr;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_cr = A_0;
		button = this.m_cr;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ds()
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
	internal virtual Label dt()
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
	internal virtual CheckBox du()
	{
		return this.m_cu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(CheckBox A_0)
	{
		this.m_cu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox dv()
	{
		return this.m_cv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(CheckBox A_0)
	{
		this.m_cv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox dw()
	{
		return this.m_cw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(CheckBox A_0)
	{
		this.m_cw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox dx()
	{
		return this.m_cx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(CheckBox A_0)
	{
		this.m_cx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox dy()
	{
		return this.m_cy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(CheckBox A_0)
	{
		EventHandler value = ac;
		CheckBox checkBox = this.m_cy;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_cy = A_0;
		checkBox = this.m_cy;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label dz()
	{
		return this.m_cz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ap(Label A_0)
	{
		this.m_cz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label d0()
	{
		return this.m_c0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aq(Label A_0)
	{
		this.m_c0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label d1()
	{
		return this.m_c1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ar(Label A_0)
	{
		this.m_c1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel d2()
	{
		return this.m_c2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(TableLayoutPanel A_0)
	{
		this.m_c2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox d3()
	{
		return this.m_c3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(CheckBox A_0)
	{
		this.m_c3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy d4()
	{
		return this.m_c4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aa(hy A_0)
	{
		this.m_c4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label d5()
	{
		return this.m_c5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void @as(Label A_0)
	{
		this.m_c5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox d6()
	{
		return this.m_c6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(CheckBox A_0)
	{
		this.m_c6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox d7()
	{
		return this.m_c7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(CheckBox A_0)
	{
		this.m_c7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox d8()
	{
		return this.m_c8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(CheckBox A_0)
	{
		this.m_c8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox d9()
	{
		return this.m_c9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(CheckBox A_0)
	{
		this.m_c9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ea()
	{
		return this.m_da;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(CheckBox A_0)
	{
		this.m_da = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox eb()
	{
		return this.m_db;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(CheckBox A_0)
	{
		this.m_db = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ec()
	{
		return this.m_dc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(CheckBox A_0)
	{
		this.m_dc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ed()
	{
		return this.m_dd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(CheckBox A_0)
	{
		this.m_dd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ee()
	{
		return this.m_de;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(CheckBox A_0)
	{
		this.m_de = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ef()
	{
		return this.m_df;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(CheckBox A_0)
	{
		this.m_df = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox eg()
	{
		return this.m_dg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(CheckBox A_0)
	{
		this.m_dg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox eh()
	{
		return this.m_dh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(CheckBox A_0)
	{
		EventHandler value = ad;
		CheckBox checkBox = this.m_dh;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_dh = A_0;
		checkBox = this.m_dh;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ei()
	{
		return this.m_di;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void at(Label A_0)
	{
		this.m_di = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ej()
	{
		return this.m_dj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(hy A_0)
	{
		this.m_dj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ek()
	{
		return this.m_dk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void au(Label A_0)
	{
		this.m_dk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox el()
	{
		return this.m_dl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(ComboBox A_0)
	{
		EventHandler value = x;
		ComboBox comboBox = this.m_dl;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_dl = A_0;
		comboBox = this.m_dl;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel em()
	{
		return this.m_dm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(TableLayoutPanel A_0)
	{
		this.m_dm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel en()
	{
		return this.m_dn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(TableLayoutPanel A_0)
	{
		this.m_dn = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox eo()
	{
		return this.m_do;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(CheckBox A_0)
	{
		this.m_do = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ep()
	{
		return this.m_dp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(TableLayoutPanel A_0)
	{
		this.m_dp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label eq()
	{
		return this.m_dq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void av(Label A_0)
	{
		this.m_dq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox er()
	{
		return this.m_dr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TextBox A_0)
	{
		this.m_dr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox es()
	{
		return this.m_ds;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TextBox A_0)
	{
		this.m_ds = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label et()
	{
		return this.m_dt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aw(Label A_0)
	{
		this.m_dt = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label eu()
	{
		return this.m_du;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ax(Label A_0)
	{
		this.m_du = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx ev()
	{
		return this.m_dv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(hx A_0)
	{
		this.m_dv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ew()
	{
		return this.m_dw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(TableLayoutPanel A_0)
	{
		this.m_dw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ex()
	{
		return this.m_dx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(TableLayoutPanel A_0)
	{
		this.m_dx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ey()
	{
		return this.m_dy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(TableLayoutPanel A_0)
	{
		this.m_dy = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ez()
	{
		return this.m_dz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ay(Label A_0)
	{
		this.m_dz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox e0()
	{
		return this.m_d0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(ComboBox A_0)
	{
		EventHandler value = t;
		ComboBox comboBox = this.m_d0;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_d0 = A_0;
		comboBox = this.m_d0;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel e1()
	{
		return this.m_d1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(TableLayoutPanel A_0)
	{
		this.m_d1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label e2()
	{
		return this.m_d2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void az(Label A_0)
	{
		this.m_d2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button e3()
	{
		return this.m_d3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Button A_0)
	{
		EventHandler value = ar;
		Button button = this.m_d3;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_d3 = A_0;
		button = this.m_d3;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button e4()
	{
		return this.m_d4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(Button A_0)
	{
		EventHandler value = ai;
		Button button = this.m_d4;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_d4 = A_0;
		button = this.m_d4;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label e5()
	{
		return this.m_d5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a0(Label A_0)
	{
		this.m_d5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label e6()
	{
		return this.m_d6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a1(Label A_0)
	{
		this.m_d6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label e7()
	{
		return this.m_d7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a2(Label A_0)
	{
		this.m_d7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox e8()
	{
		return this.m_d8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(CheckBox A_0)
	{
		this.m_d8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox e9()
	{
		return this.m_d9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(CheckBox A_0)
	{
		this.m_d9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label fa()
	{
		return this.m_ea;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a3(Label A_0)
	{
		this.m_ea = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy fb()
	{
		return this.m_eb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(hy A_0)
	{
		this.m_eb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label fc()
	{
		return this.m_ec;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a4(Label A_0)
	{
		this.m_ec = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label fd()
	{
		return this.m_ed;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a5(Label A_0)
	{
		this.m_ed = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label fe()
	{
		return this.m_ee;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a6(Label A_0)
	{
		this.m_ee = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ff()
	{
		return this.m_ef;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(hy A_0)
	{
		this.m_ef = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox fg()
	{
		return this.m_eg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(CheckBox A_0)
	{
		this.m_eg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel fh()
	{
		return this.m_eh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(TableLayoutPanel A_0)
	{
		this.m_eh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox fi()
	{
		return this.m_ei;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(CheckBox A_0)
	{
		this.m_ei = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx fj()
	{
		return this.m_ej;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(hx A_0)
	{
		this.m_ej = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label fk()
	{
		return this.m_ek;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a7(Label A_0)
	{
		this.m_ek = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel fl()
	{
		return this.m_el;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(TableLayoutPanel A_0)
	{
		this.m_el = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label fm()
	{
		return this.m_em;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a8(Label A_0)
	{
		this.m_em = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label fn()
	{
		return this.m_en;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a9(Label A_0)
	{
		this.m_en = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label fo()
	{
		return this.m_eo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ba(Label A_0)
	{
		this.m_eo = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy fp()
	{
		return this.m_ep;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ae(hy A_0)
	{
		this.m_ep = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy fq()
	{
		return this.m_eq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void af(hy A_0)
	{
		this.m_eq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button fr()
	{
		return this.m_er;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(Button A_0)
	{
		EventHandler value = ap;
		Button button = this.m_er;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_er = A_0;
		button = this.m_er;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox fs()
	{
		return this.m_es;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(CheckBox A_0)
	{
		this.m_es = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ft()
	{
		return this.m_et;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(Button A_0)
	{
		this.m_et = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button fu()
	{
		return this.m_eu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(Button A_0)
	{
		EventHandler value = g;
		Button button = this.m_eu;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_eu = A_0;
		button = this.m_eu;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel fv()
	{
		return this.m_ev;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(TableLayoutPanel A_0)
	{
		this.m_ev = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox fw()
	{
		return this.m_ew;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aa(CheckBox A_0)
	{
		this.m_ew = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage fx()
	{
		return this.m_ex;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TabPage A_0)
	{
		this.m_ex = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel fy()
	{
		return this.m_ey;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aa(TableLayoutPanel A_0)
	{
		this.m_ey = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button fz()
	{
		return this.m_ez;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(Button A_0)
	{
		EventHandler value = am;
		Button button = this.m_ez;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ez = A_0;
		button = this.m_ez;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox f0()
	{
		return this.m_e0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(ComboBox A_0)
	{
		EventHandler value = o;
		ComboBox comboBox = this.m_e0;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_e0 = A_0;
		comboBox = this.m_e0;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label f1()
	{
		return this.m_e1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bb(Label A_0)
	{
		this.m_e1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel f2()
	{
		return this.m_e2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(TableLayoutPanel A_0)
	{
		this.m_e2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label f3()
	{
		return this.m_e3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bc(Label A_0)
	{
		this.m_e3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox f4()
	{
		return this.m_e4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TextBox A_0)
	{
		this.m_e4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox f5()
	{
		return this.m_e5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(TextBox A_0)
	{
		this.m_e5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label f6()
	{
		return this.m_e6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bd(Label A_0)
	{
		this.m_e6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label f7()
	{
		return this.m_e7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void be(Label A_0)
	{
		this.m_e7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx f8()
	{
		return this.m_e8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(hx A_0)
	{
		this.m_e8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox f9()
	{
		return this.m_e9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(GroupBox A_0)
	{
		this.m_e9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ga()
	{
		return this.m_fa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(TableLayoutPanel A_0)
	{
		this.m_fa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label gb()
	{
		return this.m_fb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bf(Label A_0)
	{
		this.m_fb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel gc()
	{
		return this.m_fc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(TableLayoutPanel A_0)
	{
		this.m_fc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox gd()
	{
		return this.m_fd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(CheckBox A_0)
	{
		EventHandler value = aa;
		CheckBox checkBox = this.m_fd;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_fd = A_0;
		checkBox = this.m_fd;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ge()
	{
		return this.m_fe;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ag(hy A_0)
	{
		this.m_fe = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label gf()
	{
		return this.m_ff;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bg(Label A_0)
	{
		this.m_ff = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage gg()
	{
		return this.m_fg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(TabPage A_0)
	{
		this.m_fg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel gh()
	{
		return this.m_fh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ae(TableLayoutPanel A_0)
	{
		this.m_fh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ListBox gi()
	{
		return this.m_fi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ListBox A_0)
	{
		this.m_fi = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label gj()
	{
		return this.m_fj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bh(Label A_0)
	{
		this.m_fj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox gk()
	{
		return this.m_fk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(ComboBox A_0)
	{
		EventHandler value = r;
		ComboBox comboBox = this.m_fk;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_fk = A_0;
		comboBox = this.m_fk;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ListBox gl()
	{
		return this.m_fl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ListBox A_0)
	{
		this.m_fl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel gm()
	{
		return this.m_fm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void af(TableLayoutPanel A_0)
	{
		this.m_fm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button gn()
	{
		return this.m_fn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(Button A_0)
	{
		EventHandler value = i;
		Button button = this.m_fn;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_fn = A_0;
		button = this.m_fn;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button go()
	{
		return this.m_fo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(Button A_0)
	{
		EventHandler value = m;
		Button button = this.m_fo;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_fo = A_0;
		button = this.m_fo;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox gp()
	{
		return this.m_fp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(GroupBox A_0)
	{
		this.m_fp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox gq()
	{
		return this.m_fq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(GroupBox A_0)
	{
		this.m_fq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel gr()
	{
		return this.m_fr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ag(TableLayoutPanel A_0)
	{
		this.m_fr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel gs()
	{
		return this.m_fs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ah(TableLayoutPanel A_0)
	{
		this.m_fs = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button gt()
	{
		return this.m_ft;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(Button A_0)
	{
		EventHandler value = l;
		Button button = this.m_ft;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ft = A_0;
		button = this.m_ft;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip gu()
	{
		return this.m_fu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolTip A_0)
	{
		this.m_fu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel gv()
	{
		return this.m_fv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ai(TableLayoutPanel A_0)
	{
		this.m_fv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button gw()
	{
		return this.m_fw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(Button A_0)
	{
		EventHandler value = n;
		Button button = this.m_fw;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_fw = A_0;
		button = this.m_fw;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy gx()
	{
		return this.m_fx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ah(hy A_0)
	{
		this.m_fx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy gy()
	{
		return this.m_fy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ai(hy A_0)
	{
		this.m_fy = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label gz()
	{
		return this.m_fz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bi(Label A_0)
	{
		this.m_fz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label g0()
	{
		return this.m_f0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bj(Label A_0)
	{
		this.m_f0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy g1()
	{
		return this.m_f1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aj(hy A_0)
	{
		this.m_f1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label g2()
	{
		return this.m_f2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bk(Label A_0)
	{
		this.m_f2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label g3()
	{
		return this.m_f3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bl(Label A_0)
	{
		this.m_f3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox g4()
	{
		return this.m_f4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(ComboBox A_0)
	{
		EventHandler value = p;
		ComboBox comboBox = this.m_f4;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_f4 = A_0;
		comboBox = this.m_f4;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabControl g5()
	{
		return this.m_f5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TabControl A_0)
	{
		EventHandler value = d;
		TabControl tabControl = this.m_f5;
		if (tabControl != null)
		{
			tabControl.SelectedIndexChanged -= value;
		}
		this.m_f5 = A_0;
		tabControl = this.m_f5;
		if (tabControl != null)
		{
			tabControl.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage g6()
	{
		return this.m_f6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(TabPage A_0)
	{
		this.m_f6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage g7()
	{
		return this.m_f7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(TabPage A_0)
	{
		this.m_f7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel g8()
	{
		return this.m_f8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aj(TableLayoutPanel A_0)
	{
		this.m_f8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label g9()
	{
		return this.m_f9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bm(Label A_0)
	{
		this.m_f9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ha()
	{
		return this.m_ga;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bn(Label A_0)
	{
		this.m_ga = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label hb()
	{
		return this.m_gb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bo(Label A_0)
	{
		this.m_gb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy hc()
	{
		return this.m_gc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ak(hy A_0)
	{
		this.m_gc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy hd()
	{
		return this.m_gd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void al(hy A_0)
	{
		this.m_gd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy he()
	{
		return this.m_ge;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void am(hy A_0)
	{
		this.m_ge = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox hf()
	{
		return this.m_gf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(GroupBox A_0)
	{
		this.m_gf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel hg()
	{
		return this.m_gg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ak(TableLayoutPanel A_0)
	{
		this.m_gg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label hh()
	{
		return this.m_gh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bp(Label A_0)
	{
		this.m_gh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label hi()
	{
		return this.m_gi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bq(Label A_0)
	{
		this.m_gi = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label hj()
	{
		return this.m_gj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void br(Label A_0)
	{
		this.m_gj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy hk()
	{
		return this.m_gk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void an(hy A_0)
	{
		this.m_gk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy hl()
	{
		return this.m_gl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ao(hy A_0)
	{
		this.m_gl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy hm()
	{
		return this.m_gm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ap(hy A_0)
	{
		this.m_gm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label hn()
	{
		return this.m_gn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bs(Label A_0)
	{
		this.m_gn = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ho()
	{
		return this.m_go;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bt(Label A_0)
	{
		this.m_go = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label hp()
	{
		return this.m_gp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bu(Label A_0)
	{
		this.m_gp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy hq()
	{
		return this.m_gq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aq(hy A_0)
	{
		this.m_gq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy hr()
	{
		return this.m_gr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ar(hy A_0)
	{
		this.m_gr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy hs()
	{
		return this.m_gs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void @as(hy A_0)
	{
		this.m_gs = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ht()
	{
		return this.m_gt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void al(TableLayoutPanel A_0)
	{
		this.m_gt = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label hu()
	{
		return this.m_gu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bv(Label A_0)
	{
		this.m_gu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel hv()
	{
		return this.m_gv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void am(TableLayoutPanel A_0)
	{
		this.m_gv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel hw()
	{
		return this.m_gw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void an(TableLayoutPanel A_0)
	{
		this.m_gw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label hx()
	{
		return this.m_gx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bw(Label A_0)
	{
		this.m_gx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label hy()
	{
		return this.m_gy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bx(Label A_0)
	{
		this.m_gy = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy hz()
	{
		return this.m_gz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void at(hy A_0)
	{
		this.m_gz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy h0()
	{
		return this.m_g0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void au(hy A_0)
	{
		this.m_g0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label h1()
	{
		return this.m_g1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void by(Label A_0)
	{
		this.m_g1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy h2()
	{
		return this.m_g2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void av(hy A_0)
	{
		this.m_g2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label h3()
	{
		return this.m_g3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bz(Label A_0)
	{
		this.m_g3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox h4()
	{
		return this.m_g4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(CheckBox A_0)
	{
		this.m_g4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox h5()
	{
		return this.m_g5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(CheckBox A_0)
	{
		this.m_g5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label h6()
	{
		return this.m_g6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b0(Label A_0)
	{
		this.m_g6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel h7()
	{
		return this.m_g7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ao(TableLayoutPanel A_0)
	{
		this.m_g7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button h8()
	{
		return this.m_g8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(Button A_0)
	{
		EventHandler value = au;
		Button button = this.m_g8;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_g8 = A_0;
		button = this.m_g8;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox h9()
	{
		return this.m_g9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(GroupBox A_0)
	{
		this.m_g9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ia()
	{
		return this.m_ha;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ap(TableLayoutPanel A_0)
	{
		this.m_ha = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ib()
	{
		return this.m_hb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aw(hy A_0)
	{
		this.m_hb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ic()
	{
		return this.m_hc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b1(Label A_0)
	{
		this.m_hc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy id()
	{
		return this.m_hd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ax(hy A_0)
	{
		this.m_hd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ie()
	{
		return this.m_he;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b2(Label A_0)
	{
		this.m_he = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy @if()
	{
		return this.m_hf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ay(hy A_0)
	{
		this.m_hf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ig()
	{
		return this.m_hg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b3(Label A_0)
	{
		this.m_hg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ih()
	{
		return this.m_hh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ae(CheckBox A_0)
	{
		EventHandler value = ag;
		CheckBox checkBox = this.m_hh;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_hh = A_0;
		checkBox = this.m_hh;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ii()
	{
		return this.m_hi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aq(TableLayoutPanel A_0)
	{
		this.m_hi = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ij()
	{
		return this.m_hj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b4(Label A_0)
	{
		this.m_hj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ik()
	{
		return this.m_hk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void af(CheckBox A_0)
	{
		this.m_hk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox il()
	{
		return this.m_hl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(ComboBox A_0)
	{
		this.m_hl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel im()
	{
		return this.m_hm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ar(TableLayoutPanel A_0)
	{
		this.m_hm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button @in()
	{
		return this.m_hn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(Button A_0)
	{
		EventHandler value = j;
		Button button = this.m_hn;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_hn = A_0;
		button = this.m_hn;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label io()
	{
		return this.m_ho;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b5(Label A_0)
	{
		this.m_ho = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ip()
	{
		return this.m_hp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b6(Label A_0)
	{
		this.m_hp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox iq()
	{
		return this.m_hq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ag(CheckBox A_0)
	{
		this.m_hq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ir()
	{
		return this.m_hr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b7(Label A_0)
	{
		this.m_hr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel @is()
	{
		return this.m_hs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void @as(TableLayoutPanel A_0)
	{
		this.m_hs = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy it()
	{
		return this.m_ht;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void az(hy A_0)
	{
		this.m_ht = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label iu()
	{
		return this.m_hu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b8(Label A_0)
	{
		this.m_hu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox iv()
	{
		return this.m_hv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ah(CheckBox A_0)
	{
		this.m_hv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label iw()
	{
		return this.m_hw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b9(Label A_0)
	{
		this.m_hw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox ix()
	{
		return this.m_hx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(ComboBox A_0)
	{
		this.m_hx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox iy()
	{
		return this.m_hy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ai(CheckBox A_0)
	{
		this.m_hy = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabControl iz()
	{
		return this.m_hz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TabControl A_0)
	{
		this.m_hz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage i0()
	{
		return this.m_h0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TabPage A_0)
	{
		this.m_h0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel i1()
	{
		return this.m_h1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void at(TableLayoutPanel A_0)
	{
		this.m_h1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage i2()
	{
		return this.m_h2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(TabPage A_0)
	{
		this.m_h2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button i3()
	{
		return this.m_h3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(Button A_0)
	{
		EventHandler value = k;
		Button button = this.m_h3;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_h3 = A_0;
		button = this.m_h3;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy i4()
	{
		return this.m_h4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a0(hy A_0)
	{
		this.m_h4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label i5()
	{
		return this.m_h5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ca(Label A_0)
	{
		this.m_h5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel i6()
	{
		return this.m_h6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void au(TableLayoutPanel A_0)
	{
		this.m_h6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy i7()
	{
		return this.m_h7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a1(hy A_0)
	{
		this.m_h7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label i8()
	{
		return this.m_h8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cb(Label A_0)
	{
		this.m_h8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy i9()
	{
		return this.m_h9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a2(hy A_0)
	{
		this.m_h9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ja()
	{
		return this.m_ia;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cc(Label A_0)
	{
		this.m_ia = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy jb()
	{
		return this.m_ib;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a3(hy A_0)
	{
		this.m_ib = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label jc()
	{
		return this.m_ic;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cd(Label A_0)
	{
		this.m_ic = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label jd()
	{
		return this.m_id;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ce(Label A_0)
	{
		this.m_id = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy je()
	{
		return this.m_ie;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a4(hy A_0)
	{
		this.m_ie = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox jf()
	{
		return this.m_if;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aj(CheckBox A_0)
	{
		EventHandler value = aj;
		CheckBox checkBox = this.m_if;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_if = A_0;
		checkBox = this.m_if;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage jg()
	{
		return this.m_ig;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(TabPage A_0)
	{
		this.m_ig = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel jh()
	{
		return this.m_ih;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void av(TableLayoutPanel A_0)
	{
		this.m_ih = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ji()
	{
		return this.m_ii;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a5(hy A_0)
	{
		this.m_ii = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label jj()
	{
		return this.m_ij;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cf(Label A_0)
	{
		this.m_ij = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label jk()
	{
		return this.m_ik;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cg(Label A_0)
	{
		this.m_ik = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy jl()
	{
		return this.m_il;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a6(hy A_0)
	{
		this.m_il = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox jm()
	{
		return this.m_im;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(GroupBox A_0)
	{
		this.m_im = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel jn()
	{
		return this.m_in;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aw(TableLayoutPanel A_0)
	{
		this.m_in = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox jo()
	{
		return this.m_io;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ak(CheckBox A_0)
	{
		this.m_io = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy jp()
	{
		return this.m_ip;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a7(hy A_0)
	{
		this.m_ip = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label jq()
	{
		return this.m_iq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ch(Label A_0)
	{
		this.m_iq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button jr()
	{
		return this.m_ir;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(Button A_0)
	{
		EventHandler value = at;
		Button button = this.m_ir;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ir = A_0;
		button = this.m_ir;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox js()
	{
		return this.m_is;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void al(CheckBox A_0)
	{
		this.m_is = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy jt()
	{
		return this.m_it;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a8(hy A_0)
	{
		this.m_it = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ju()
	{
		return this.m_iu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ci(Label A_0)
	{
		this.m_iu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy jv()
	{
		return this.m_iv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a9(hy A_0)
	{
		this.m_iv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label jw()
	{
		return this.m_iw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cj(Label A_0)
	{
		this.m_iw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button jx()
	{
		return this.m_ix;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(Button A_0)
	{
		EventHandler value = ak;
		Button button = this.m_ix;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ix = A_0;
		button = this.m_ix;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual System.Windows.Forms.Timer jy()
	{
		return this.m_iy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(System.Windows.Forms.Timer A_0)
	{
		EventHandler value = b;
		System.Windows.Forms.Timer timer = this.m_iy;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		this.m_iy = A_0;
		timer = this.m_iy;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox jz()
	{
		return this.m_iz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void am(CheckBox A_0)
	{
		this.m_iz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox j0()
	{
		return this.m_i0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void an(CheckBox A_0)
	{
		this.m_i0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox j1()
	{
		return this.m_i1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ao(CheckBox A_0)
	{
		this.m_i1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox j2()
	{
		return this.m_i2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(GroupBox A_0)
	{
		this.m_i2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton j3()
	{
		return this.m_i3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(RadioButton A_0)
	{
		EventHandler value = c;
		RadioButton radioButton = this.m_i3;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_i3 = A_0;
		radioButton = this.m_i3;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton j4()
	{
		return this.m_i4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(RadioButton A_0)
	{
		EventHandler value = c;
		RadioButton radioButton = this.m_i4;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_i4 = A_0;
		radioButton = this.m_i4;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel j5()
	{
		return this.m_i5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ax(TableLayoutPanel A_0)
	{
		this.m_i5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy j6()
	{
		return this.m_i6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ba(hy A_0)
	{
		this.m_i6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label j7()
	{
		return this.m_i7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ck(Label A_0)
	{
		this.m_i7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy j8()
	{
		return this.m_i8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bb(hy A_0)
	{
		this.m_i8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label j9()
	{
		return this.m_i9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cl(Label A_0)
	{
		this.m_i9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ka()
	{
		return this.m_ja;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bc(hy A_0)
	{
		this.m_ja = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy kb()
	{
		return this.m_jb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bd(hy A_0)
	{
		this.m_jb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy kc()
	{
		return this.m_jc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void be(hy A_0)
	{
		this.m_jc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy kd()
	{
		return this.m_jd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bf(hy A_0)
	{
		this.m_jd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ke()
	{
		return this.m_je;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bg(hy A_0)
	{
		this.m_je = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label kf()
	{
		return this.m_jf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cm(Label A_0)
	{
		this.m_jf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label kg()
	{
		return this.m_jg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cn(Label A_0)
	{
		this.m_jg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label kh()
	{
		return this.m_jh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void co(Label A_0)
	{
		this.m_jh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ki()
	{
		return this.m_ji;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cp(Label A_0)
	{
		this.m_ji = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label kj()
	{
		return this.m_jj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cq(Label A_0)
	{
		this.m_jj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label kk()
	{
		return this.m_jk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cr(Label A_0)
	{
		this.m_jk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy kl()
	{
		return this.m_jl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bh(hy A_0)
	{
		this.m_jl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy km()
	{
		return this.m_jm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bi(hy A_0)
	{
		this.m_jm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label kn()
	{
		return this.m_jn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cs(Label A_0)
	{
		this.m_jn = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ko()
	{
		return this.m_jo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ap(CheckBox A_0)
	{
		this.m_jo = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel kp()
	{
		return this.m_jp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Panel A_0)
	{
		this.m_jp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton kq()
	{
		return this.m_jq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(RadioButton A_0)
	{
		EventHandler value = ae;
		RadioButton radioButton = this.m_jq;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_jq = A_0;
		radioButton = this.m_jq;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton kr()
	{
		return this.m_jr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(RadioButton A_0)
	{
		EventHandler value = af;
		RadioButton radioButton = this.m_jr;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_jr = A_0;
		radioButton = this.m_jr;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ks()
	{
		return this.m_js;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ay(TableLayoutPanel A_0)
	{
		this.m_js = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button kt()
	{
		return this.m_jt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(Button A_0)
	{
		this.m_jt = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ku()
	{
		return this.m_ju;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aq(CheckBox A_0)
	{
		this.m_ju = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox kv()
	{
		return this.m_jv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ar(CheckBox A_0)
	{
		this.m_jv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox kw()
	{
		return this.m_jw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void @as(CheckBox A_0)
	{
		this.m_jw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox kx()
	{
		return this.m_jx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void at(CheckBox A_0)
	{
		this.m_jx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel ky()
	{
		return this.m_jy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Panel A_0)
	{
		this.m_jy = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel kz()
	{
		return this.m_jz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Panel A_0)
	{
		this.m_jz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button k0()
	{
		return this.m_j0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aa(Button A_0)
	{
		EventHandler value = @as;
		Button button = this.m_j0;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_j0 = A_0;
		button = this.m_j0;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy k1()
	{
		return this.m_j1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bj(hy A_0)
	{
		this.m_j1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label k2()
	{
		return this.m_j2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ct(Label A_0)
	{
		this.m_j2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel k3()
	{
		return this.m_j3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void az(TableLayoutPanel A_0)
	{
		this.m_j3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox k4()
	{
		return this.m_j4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(GroupBox A_0)
	{
		this.m_j4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel k5()
	{
		return this.m_j5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a0(TableLayoutPanel A_0)
	{
		this.m_j5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label k6()
	{
		return this.m_j6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cu(Label A_0)
	{
		this.m_j6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy k7()
	{
		return this.m_j7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bk(hy A_0)
	{
		this.m_j7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label k8()
	{
		return this.m_j8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cv(Label A_0)
	{
		this.m_j8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy k9()
	{
		return this.m_j9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bl(hy A_0)
	{
		this.m_j9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy la()
	{
		return this.m_ka;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bm(hy A_0)
	{
		this.m_ka = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy lb()
	{
		return this.m_kb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bn(hy A_0)
	{
		this.m_kb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label lc()
	{
		return this.m_kc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cw(Label A_0)
	{
		this.m_kc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ld()
	{
		return this.m_kd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cx(Label A_0)
	{
		this.m_kd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy le()
	{
		return this.m_ke;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bo(hy A_0)
	{
		this.m_ke = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy lf()
	{
		return this.m_kf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bp(hy A_0)
	{
		this.m_kf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label lg()
	{
		return this.m_kg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cy(Label A_0)
	{
		this.m_kg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label lh()
	{
		return this.m_kh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void cz(Label A_0)
	{
		this.m_kh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox li()
	{
		return this.m_ki;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void au(CheckBox A_0)
	{
		this.m_ki = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox lj()
	{
		return this.m_kj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void av(CheckBox A_0)
	{
		this.m_kj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox lk()
	{
		return this.m_kk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aw(CheckBox A_0)
	{
		this.m_kk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ll()
	{
		return this.m_kl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c0(Label A_0)
	{
		this.m_kl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button lm()
	{
		return this.m_km;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(Button A_0)
	{
		this.m_km = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ln()
	{
		return this.m_kn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ax(CheckBox A_0)
	{
		this.m_kn = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox lo()
	{
		return this.m_ko;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ay(CheckBox A_0)
	{
		this.m_ko = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox lp()
	{
		return this.m_kp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void az(CheckBox A_0)
	{
		this.m_kp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox lq()
	{
		return this.m_kq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a0(CheckBox A_0)
	{
		this.m_kq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox lr()
	{
		return this.m_kr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a1(CheckBox A_0)
	{
		this.m_kr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ls()
	{
		return this.m_ks;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a2(CheckBox A_0)
	{
		this.m_ks = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox lt()
	{
		return this.m_kt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a3(CheckBox A_0)
	{
		this.m_kt = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox lu()
	{
		return this.m_ku;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a4(CheckBox A_0)
	{
		this.m_ku = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox lv()
	{
		return this.m_kv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a5(CheckBox A_0)
	{
		this.m_kv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label lw()
	{
		return this.m_kw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c1(Label A_0)
	{
		this.m_kw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox lx()
	{
		return this.m_kx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(ComboBox A_0)
	{
		this.m_kx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ly()
	{
		return this.m_ky;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c2(Label A_0)
	{
		this.m_ky = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox lz()
	{
		return this.m_kz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a6(CheckBox A_0)
	{
		this.m_kz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox l0()
	{
		return this.m_k0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a7(CheckBox A_0)
	{
		this.m_k0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button l1()
	{
		return this.m_k1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(Button A_0)
	{
		EventHandler value = aw;
		Button button = this.m_k1;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_k1 = A_0;
		button = this.m_k1;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox l2()
	{
		return this.m_k2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a8(CheckBox A_0)
	{
		this.m_k2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox l3()
	{
		return this.m_k3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(GroupBox A_0)
	{
		this.m_k3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel l4()
	{
		return this.m_k4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a1(TableLayoutPanel A_0)
	{
		this.m_k4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy l5()
	{
		return this.m_k5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bq(hy A_0)
	{
		this.m_k5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label l6()
	{
		return this.m_k6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c3(Label A_0)
	{
		this.m_k6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox l7()
	{
		return this.m_k7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a9(CheckBox A_0)
	{
		this.m_k7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button l8()
	{
		return this.m_k8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(Button A_0)
	{
		EventHandler value = a;
		Button button = this.m_k8;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_k8 = A_0;
		button = this.m_k8;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox l9()
	{
		return this.m_k9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(GroupBox A_0)
	{
		this.m_k9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ma()
	{
		return this.m_la;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a2(TableLayoutPanel A_0)
	{
		this.m_la = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy mb()
	{
		return this.m_lb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void br(hy A_0)
	{
		this.m_lb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label mc()
	{
		return this.m_lc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c4(Label A_0)
	{
		this.m_lc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d md()
	{
		return this.m_ly;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		r.d.b a_ = g;
		this.m_ly?.e(a_);
		this.m_ly = A_0;
		this.m_ly?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d me()
	{
		return this.m_lz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void b(r.d A_0)
	{
		r.d.b a_ = e;
		this.m_lz?.e(a_);
		this.m_lz = A_0;
		this.m_lz?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d mf()
	{
		return this.m_l0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void c(r.d A_0)
	{
		r.d.b a_ = f;
		this.m_l0?.e(a_);
		this.m_l0 = A_0;
		this.m_l0?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d mg()
	{
		return this.m_l1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void d(r.d A_0)
	{
		r.d.b a_ = r;
		this.m_l1?.e(a_);
		this.m_l1 = A_0;
		this.m_l1?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d mh()
	{
		return this.m_l2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void e(r.d A_0)
	{
		r.d.b a_ = q;
		this.m_l2?.e(a_);
		this.m_l2 = A_0;
		this.m_l2?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d mi()
	{
		return this.m_l3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void f(r.d A_0)
	{
		r.d.b a_ = m;
		this.m_l3?.e(a_);
		this.m_l3 = A_0;
		this.m_l3?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d mj()
	{
		return this.m_l4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void g(r.d A_0)
	{
		r.d.b a_ = i;
		this.m_l4?.e(a_);
		this.m_l4 = A_0;
		this.m_l4?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d mk()
	{
		return this.m_l5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void h(r.d A_0)
	{
		r.d.b a_ = h;
		this.m_l5?.e(a_);
		this.m_l5 = A_0;
		this.m_l5?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d ml()
	{
		return this.m_l6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void i(r.d A_0)
	{
		r.d.b a_ = d;
		this.m_l6?.e(a_);
		this.m_l6 = A_0;
		this.m_l6?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d mm()
	{
		return this.m_l7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void j(r.d A_0)
	{
		r.d.b a_ = c;
		this.m_l7?.e(a_);
		this.m_l7 = A_0;
		this.m_l7?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d mn()
	{
		return this.m_l8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void k(r.d A_0)
	{
		r.d.b a_ = a;
		this.m_l8?.e(a_);
		this.m_l8 = A_0;
		this.m_l8?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d mo()
	{
		return this.m_l9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void l(r.d A_0)
	{
		r.d.b a_ = b;
		this.m_l9?.e(a_);
		this.m_l9 = A_0;
		this.m_l9?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d mp()
	{
		return this.m_ma;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void m(r.d A_0)
	{
		r.d.b a_ = l;
		this.m_ma?.e(a_);
		this.m_ma = A_0;
		this.m_ma?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d mq()
	{
		return this.m_mb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void n(r.d A_0)
	{
		this.m_mb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d mr()
	{
		return this.m_mc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void o(r.d A_0)
	{
		r.d.b a_ = p;
		this.m_mc?.e(a_);
		this.m_mc = A_0;
		this.m_mc?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d ms()
	{
		return this.m_md;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void p(r.d A_0)
	{
		r.d.b a_ = n;
		this.m_md?.e(a_);
		this.m_md = A_0;
		this.m_md?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d mt()
	{
		return this.m_me;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void q(r.d A_0)
	{
		r.d.b a_ = j;
		this.m_me?.e(a_);
		this.m_me = A_0;
		this.m_me?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d mu()
	{
		return this.m_mf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void r(r.d A_0)
	{
		r.d.b a_ = k;
		this.m_mf?.e(a_);
		this.m_mf = A_0;
		this.m_mf?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d mv()
	{
		return this.m_mg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void s(r.d A_0)
	{
		r.d.b a_ = o;
		this.m_mg?.e(a_);
		this.m_mg = A_0;
		this.m_mg?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer mw()
	{
		return this.m_mh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = a;
		System.Timers.Timer timer = this.m_mh;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		this.m_mh = A_0;
		timer = this.m_mh;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer mx()
	{
		return this.m_mi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void b(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = b;
		System.Timers.Timer timer = this.m_mi;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		this.m_mi = A_0;
		timer = this.m_mi;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d my()
	{
		return this.m_mj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void t(r.d A_0)
	{
		r.d.b a_ = s;
		this.m_mj?.e(a_);
		this.m_mj = A_0;
		this.m_mj?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.c mz()
	{
		return this.m_mk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.c A_0)
	{
		r.c.b a_ = a;
		this.m_mk?.u(a_);
		this.m_mk = A_0;
		this.m_mk?.t(a_);
	}

	public void a(fz A_0, f1 A_1, Guid A_2, f4 A_3, a9[] A_4, Form A_5, Point A_6, ref bool A_7)
	{
		this.m_ld = A_0;
		this.m_le = A_1;
		this.m_lf = A_3;
		this.m_lg = A_2.ToString();
		this.m_lh = A_2;
		this.m_mq = this.m_le.xi(this.m_lh);
		this.m_mr = this.m_le.xj(this.m_lh);
		this.m_lj = this.m_le.ul();
		this.m_lk = this.m_le.um();
		this.m_li = this.m_lj || this.m_lk;
		nn = A_4;
		base.Owner = A_5;
		int upperBound = A_4.GetUpperBound(0);
		checked
		{
			this.m_ll = new Collection<ip.d>[upperBound + 1];
			this.m_lm = new Collection<ip.d>[upperBound + 1];
			this.m_ln = new Collection<ip.e>[upperBound + 1];
			this.m_lo = new Collection<h6.c>[upperBound + 1];
			this.m_lp = new Collection<h6.d>[upperBound + 1];
			this.m_ls = new string[upperBound + 1];
			m9 = this.m_le.ww(this.m_lh);
			int num = upperBound;
			for (int num2 = 0; num2 <= num; num2++)
			{
				this.m_ll[num2] = new Collection<ip.d>();
				this.m_lm[num2] = new Collection<ip.d>();
				this.m_ln[num2] = new Collection<ip.e>();
				this.m_ls[num2] = this.m_le.sj(this.m_lh, num2);
				int num3 = (A_4[num2].o ? 1 : (A_4[num2].p ? (-1) : 0));
				int num4 = num3;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					this.m_ll[num2].Add(this.m_le.sn(this.m_lh, num2, num5));
					this.m_lm[num2].Add(this.m_le.sn(this.m_lh, num2, num5));
					this.m_ln[num2].Add(this.m_le.so(this.m_lh, num2, num5));
				}
				this.m_lo[num2] = ((ce)this.m_le).p9(this.m_lh, num2);
				this.m_lp[num2] = this.m_le.qh(this.m_lh, num2);
				b(num2);
			}
			this.m_lq = this.m_le.uf(this.m_lh);
			this.m_lr = this.m_le.ug(this.m_lh);
			ComboBox.ObjectCollection items = aq().Items;
			items.Clear();
			if (upperBound == 0)
			{
				ComboBox.ObjectCollection objectCollection = items;
				string A_8 = "MultiMeasPrimaryTypeNameDefault";
				objectCollection.Add(global::hu.a(ref A_8));
			}
			else
			{
				int num6 = upperBound;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					switch (A_4[num7].ab)
					{
					case global::h.f.a:
					{
						ComboBox.ObjectCollection objectCollection4 = items;
						string A_8 = "MultiMeasPrimaryTypeNameFmt";
						string format3 = global::hu.a(ref A_8);
						A_8 = "MultiMeasAtAngleFmt";
						objectCollection4.Add(string.Format(format3, string.Format(global::hu.a(ref A_8), 0.0.ToString())));
						break;
					}
					case global::h.f.b:
					{
						ComboBox.ObjectCollection objectCollection3 = items;
						string A_8 = "MultiMeasSecondaryTypeNameFmt";
						string format2 = global::hu.a(ref A_8);
						A_8 = "MultiMeasAtAngleFmt";
						objectCollection3.Add(string.Format(format2, string.Format(global::hu.a(ref A_8), 0.0.ToString())));
						break;
					}
					case global::h.f.c:
					{
						ComboBox.ObjectCollection objectCollection2 = items;
						string A_8 = "MultiMeasAdditionalTypeNameFmt";
						string format = global::hu.a(ref A_8);
						A_8 = "MultiMeasAtAngleFmt";
						objectCollection2.Add(string.Format(format, string.Format(global::hu.a(ref A_8), A_4[num7].ac.ToString())));
						break;
					}
					}
				}
			}
			ap().Visible = items.Count > 1;
			items = null;
			aq().SelectedIndex = 0;
			m7.t(b);
			global::i6.a(A_6, this);
			try
			{
				ShowDialog();
			}
			finally
			{
				if (!m4)
				{
					this.m_le.m2(this.m_lh, this.m_lm, mv());
				}
			}
			if (!m4)
			{
				this.m_le.m2(this.m_lh, new r.d());
			}
			A_7 = m4;
			z();
		}
	}

	[SpecialName]
	private bool aj()
	{
		return this.m_ll[aq().SelectedIndex][m()].e;
	}

	[SpecialName]
	private bool ai()
	{
		return this.m_lq[f0().SelectedIndex].e;
	}

	[SpecialName]
	private bool ah()
	{
		return this.m_lv > 0;
	}

	private void ag()
	{
		ac();
		try
		{
			d8().Checked = false;
			eh().Checked = false;
			ee().Checked = false;
			eo().Checked = false;
			ln().Checked = false;
			lp().Checked = false;
			ed().Checked = false;
			ec().Checked = false;
			eb().Checked = false;
			d7().Checked = false;
			d6().Checked = false;
			du().Checked = false;
			dy().Checked = false;
			dx().Checked = false;
			dw().Checked = false;
			eg().Checked = false;
			ef().Checked = false;
			d9().Checked = false;
			ea().Checked = false;
			dv().Checked = false;
			e9().Checked = false;
			e8().Checked = false;
			fg().Checked = false;
			fi().Checked = false;
			fb().Text = "0";
			ff().Text = "1";
			jt().Text = "1";
			fw().Checked = false;
			g(A_0: false);
			f(A_0: false);
			h4().Checked = false;
			h5().Checked = false;
			iy().Checked = false;
			j1().Checked = false;
			kx().Checked = false;
			lz().Checked = false;
			l0().Checked = false;
			l2().Checked = false;
			l7().Checked = true;
			ik().Checked = false;
			iq().Checked = false;
			fs().Checked = false;
			ih().Checked = false;
			kq().Checked = true;
			js().Checked = false;
			j0().Checked = false;
			kv().Checked = false;
			ku().Checked = false;
			nh = false;
			ni = false;
			nj = false;
			nk = false;
			nl = false;
			nm = false;
			lj().Checked = false;
			li().Checked = false;
			lk().Checked = false;
			lo().Checked = false;
			lx().SelectedIndex = -1;
		}
		finally
		{
			ad();
		}
	}

	[SpecialName]
	private void g(bool A_0)
	{
		h3().Visible = A_0;
		h1().Visible = A_0;
		h2().Visible = A_0;
		iv().Visible = A_0;
		j0().Visible = A_0;
		ku().Visible = A_0;
		kv().Visible = A_0;
		kw().Visible = A_0;
		li().Visible = A_0;
		ly().Visible = A_0;
		lx().Visible = A_0;
	}

	[SpecialName]
	private void f(bool A_0)
	{
		ll().Visible = A_0;
		lk().Visible = A_0;
		lo().Visible = A_0;
		lm().Visible = A_0;
		lj().Visible = A_0;
		ls().Visible = A_0;
		lr().Visible = A_0;
		lt().Visible = A_0;
		lu().Visible = A_0;
	}

	[SpecialName]
	private void e(bool A_0)
	{
		fm().Visible = A_0;
		fn().Visible = A_0;
		fo().Visible = A_0;
		fp().Visible = A_0;
		fq().Visible = A_0;
		l1().Visible = A_0;
	}

	private void b(int A_0)
	{
		checked
		{
			int num = this.m_lo[A_0].Count - 1;
			int num3 = default(int);
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (Operators.CompareString(this.m_lo[A_0][num2].b, this.m_ls[A_0], TextCompare: false) == 0)
				{
					num3 = num2;
					break;
				}
			}
			if (num3 != 0)
			{
				h6.d value = this.m_lp[A_0][0];
				h6.c value2 = this.m_lo[A_0][0];
				this.m_lp[A_0][0] = this.m_lp[A_0][num3];
				this.m_lo[A_0][0] = this.m_lo[A_0][num3];
				this.m_lp[A_0][num3] = value;
				this.m_lo[A_0][num3] = value2;
			}
		}
	}

	private void af()
	{
		ComboBox comboBox = il();
		this.m_le.m2(this.m_lh, n().b8, aq().SelectedIndex, m(), global::im.a(comboBox.SelectedItem.ToString()), ms(), global::r.d.a.b.a);
		comboBox = null;
	}

	private void ae()
	{
		this.m_le.m2(this.m_lh, n().b8, aq().SelectedIndex, m(), mr(), global::r.d.a.b.a);
	}

	private void d(bool A_0)
	{
		bool flag = this.m_ll[aq().SelectedIndex][gk().SelectedIndex].e;
		gq().Visible = flag;
		gw().Enabled = flag;
		go().Enabled = A_0;
		gt().Enabled = A_0 && this.m_lx.Count > 0;
		gn().Enabled = A_0 && this.m_lx.Count > 0;
		gk().Enabled = A_0;
	}

	private void a(bool A_0, bool A_1, bool A_2)
	{
		int selectedIndex = aq().SelectedIndex;
		int index = m();
		a1().Enabled = A_0;
		bb().Enabled = A_0;
		Color backColor = ((!A_0 || !this.m_li) ? SystemColors.ButtonFace : SystemColors.Window);
		bd().ReadOnly = !A_0 || !this.m_li;
		bd().BackColor = backColor;
		aw().Enabled = A_0 && this.m_li;
		bool flag = this.m_li || A_2;
		bk().Visible = flag;
		bt().Visible = flag;
		bp().Visible = flag;
		ct().Visible = flag && (this.m_ln[selectedIndex][index].e || this.m_ln[selectedIndex][index].d);
		cy().Visible = flag && this.m_ln[selectedIndex][index].c;
		h9().Visible = flag;
		hf().Visible = flag;
		bk().Enabled = A_0;
		b(A_0);
		a(A_0, bq(), bs(), this.m_ll[selectedIndex][index].g);
		a(A_0, A_1);
		cx().Enabled = A_0;
		cy().Enabled = A_0;
		cv().Enabled = A_0;
		h8().Enabled = A_0;
		lv().Enabled = A_0;
	}

	private void c(bool A_0)
	{
		bool enabled = A_0 && ih().Checked;
		kr().Enabled = enabled;
		kq().Enabled = enabled;
		l0().Enabled = enabled;
	}

	private void a(bool A_0, hy A_1, CheckBox A_2, int A_3)
	{
		A_1.Enabled = A_0 && !A_2.Checked;
		if (A_2.Checked)
		{
			A_1.Text = A_3.ToString();
		}
	}

	private void b(bool A_0)
	{
		if (ax().SelectedItem != null)
		{
			bool flag = A_0 && aw().Checked;
			bool enabled = flag && ((a)ax().SelectedItem).d;
			ax().Enabled = flag;
			at().Enabled = enabled;
			@as().Enabled = enabled;
			ko().Enabled = flag;
		}
	}

	private void a(string A_0, h6.c A_1)
	{
		global::h5.m2(A_0, A_1, this.m_ld, null);
	}

	private void a(string A_0, @in.b A_1)
	{
		@in.b b10 = A_1;
		string text = A_0 + "(Photodiode/LED S/N:" + b10.a + "): ";
		text = text + "# Photodiodes=" + b10.b9.ToString(CultureInfo.InvariantCulture) + ", ";
		text = text + "#1 Wavelen=" + b10.ca[0].ToString(CultureInfo.InvariantCulture) + ", ";
		if (b10.ca.Count > 1)
		{
			text = text + "#2 Wavelen=" + b10.ca[1].ToString(CultureInfo.InvariantCulture) + ", ";
			if (b10.ca.Count > 2)
			{
				text = text + "#3 Wavelen=" + b10.ca[2].ToString(CultureInfo.InvariantCulture) + ", ";
			}
		}
		text = text + "Update Firmware to latest rev=" + b10.h + ", ";
		text = text + "Firmware Rev=" + b10.f + ", ";
		this.m_ld.c(global::fz.b.a, text);
		b10 = null;
	}

	private void a(string A_0, ip.d A_1)
	{
		global::ip.m2(A_0, A_1, this.m_ld, null, this.m_le.t0(this.m_lg).dh().bn());
	}

	private void a(ref h6.c A_0, int A_1, string A_2, bool A_3, int A_4, bool A_5, bool A_6)
	{
		A_0 = new h6.c();
		h6.c c10 = A_0;
		c10.aa = ea().Checked;
		c10.t = d7().Checked;
		c10.b4 = A_5;
		c10.b2 = A_3;
		c10.b6 = A_6;
		c10.br = checked((byte)((iz.a)df().SelectedItem).b);
		c10.bs = (FMOpticConfigEnums)((iz.a)el().SelectedItem).b;
		c10.bp = (FMRefMatEnums)((iz.a)dg().SelectedItem).b;
		c10.bq = global::iz.c(it().Text);
		c10.v = du().Checked;
		c10.ac = dw().Checked;
		c10.ab = d9().Checked;
		c10.ad = dv().Checked;
		c10.w = dy().Checked;
		c10.s = eb().Checked;
		c10.a = ev().Text.Trim();
		c10.j = fj().Text.Trim();
		c10.q = ed().Checked;
		c10.m = eh().Checked;
		c10.bw = global::iz.d(fb().Text);
		c10.k = this.m_lu;
		c10.n = d8().Checked;
		c10.o = ee().Checked;
		c10.p = eo().Checked;
		c10.ag = fw().Checked;
		c10.@as = h4().Checked;
		c10.at = ln().Checked;
		c10.bf = lp().Checked;
		c10.au = ih().Checked && kr().Checked;
		c10.av = ih().Checked && kq().Checked;
		c10.a1 = ku().Checked;
		c10.a2 = kv().Checked;
		c10.a3 = kw().Checked;
		c10.aw = iv().Checked;
		c10.ax = js().Checked;
		c10.ay = fs().Checked;
		c10.a4 = nh;
		c10.a5 = ni;
		c10.a6 = nj;
		c10.a7 = nk;
		c10.a8 = nl;
		c10.a9 = nm;
		c10.ba = lk().Checked;
		c10.ah = h5().Checked;
		c10.ai = iy().Checked;
		c10.aj = j1().Checked;
		c10.ak = kx().Checked;
		c10.al = lz().Checked;
		c10.an = ih().Checked && l0().Checked;
		c10.am = l2().Checked;
		c10.bl = l7().Checked;
		c10.ao = ik().Checked;
		c10.aq = iq().Checked;
		checked
		{
			c10.bn = (byte)((iz.a)dm().SelectedItem).b;
			c10.u = d6().Checked;
			c10.b5 = A_4;
			c10.r = ec().Checked;
			c10.b3 = A_1;
			c10.bt = global::iz.a(ej().Text);
			c10.by = fi().Checked;
			c10.bx = fg().Checked;
			c10.bz = e9().Checked;
			c10.b0 = e8().Checked;
			c10.bo = (byte)((iz.a)dl().SelectedItem).b;
		}
		c10.bm = (FMLegacyAllSystemTypes)((iz.a)dp().SelectedItem).b;
		c10.bu = global::iz.a(ff().Text);
		if (c10.bu == 0)
		{
			c10.bu = 1;
		}
		c10.bv = global::iz.a(jt().Text);
		c10.h = d3().Checked;
		if (!c10.h)
		{
			c10.f = global::iz.a(d4().Text);
		}
		c10.x = dx().Checked;
		c10.z = ef().Checked;
		c10.y = eg().Checked;
		c10.ae = global::iz.d(fp().Text);
		c10.af = global::iz.d(fq().Text);
		c10.l = global::iz.d(h2().Text);
		c10.b = A_2;
		c10.az = jz().Checked;
		c10.a0 = j0().Checked;
		c10.bc = li().Checked;
		c10.bb = lj().Checked;
		c10.bd = lo().Checked;
		c10.be = lq().Checked;
		c10.bg = ls().Checked;
		c10.bh = lr().Checked;
		c10.bi = lt().Checked;
		c10.bj = lu().Checked;
		if (lx().SelectedIndex == 1)
		{
			c10.bk = global::h6.LinearActuatorType.Hiwin;
		}
		else
		{
			c10.bk = global::h6.LinearActuatorType.Legacy;
		}
		c10 = null;
	}

	private void a(ref @in.b A_0)
	{
		A_0 = new @in.b();
		@in.b obj = A_0;
		obj.a = f8().Text.Trim();
		obj.f = global::iz.a(ge().Text);
		obj.h = gd().Checked;
		obj.b9 = checked((byte)(g4().SelectedIndex + 1));
		obj.ca.Add(global::iz.d(g1().Text));
		obj.ca.Add(global::iz.d(gy().Text));
		obj.ca.Add(global::iz.d(gx().Text));
		_ = null;
	}

	private void d(ip.f A_0)
	{
		A_0.b = global::iz.d(km().Text);
		A_0.d = global::iz.d(j8().Text);
		A_0.e = global::iz.d(j6().Text);
		A_0.c = global::iz.d(kl().Text);
		A_0.h = global::iz.c(kc().Text);
		A_0.f = global::iz.d(ke().Text);
		A_0.g = global::iz.d(kd().Text);
		A_0.j = global::iz.c(ka().Text);
		A_0.i = global::iz.d(kb().Text);
		A_0.k[0] = global::iz.d(hc().Text);
		A_0.k[1] = global::iz.d(hd().Text);
		A_0.k[2] = global::iz.d(he().Text);
		A_0.k[3] = global::iz.d(hq().Text);
		A_0.k[4] = global::iz.d(hr().Text);
		A_0.k[5] = global::iz.d(hs().Text);
		A_0.m = global::iz.b(hz().Text);
		_ = null;
	}

	private void a(ref ip.g A_0)
	{
		if (m6 != null)
		{
			A_0 = m6;
		}
		ip.g obj = A_0;
		obj.h = global::iz.d(jl().Text);
		obj.i = global::iz.d(jv().Text);
		_ = null;
	}

	private void a(ref ip.d A_0, ref bool A_1)
	{
		A_0 = new ip.d();
		ip.d d10 = A_0;
		int selectedIndex = aq().SelectedIndex;
		int index = m();
		bool flag = nn[selectedIndex].ab == global::h.f.a;
		string text = string.Empty;
		string text2 = string.Empty;
		d10.cb = global::iz.d(a4().Text);
		d10.cc = global::iz.d(a3().Text);
		d10.cd = global::iz.d(a2().Text);
		d10.ce = global::iz.d(lb().Text);
		d10.cf = global::iz.d(la().Text);
		d10.cg = global::iz.d(i4().Text);
		d10.ch = global::iz.d(jb().Text);
		d10.ci = global::iz.d(je().Text);
		d10.cj = global::iz.d(i9().Text);
		d10.ck = global::iz.d(lf().Text);
		d10.cl = global::iz.d(le().Text);
		d10.cm = global::iz.d(i7().Text);
		double[] A_2 = null;
		ip.d d11 = this.m_ll[selectedIndex][index];
		int a_ = d11.cp;
		float a_2 = d10.cb;
		float a_3 = d10.cc;
		float a_4 = d10.cd;
		float a_5 = d10.ce;
		float a_6 = d10.cf;
		double[] A_3 = null;
		global::ip.m2(a_, a_2, a_3, a_4, a_5, a_6, ref A_2, ref A_3);
		if (A_2[0] < -3000.0)
		{
			global::fe.b(this.m_ld, string.Format("Wavelength calibration coefficients #{0} are invalid.", "1"), global::i6.a(bb()));
			A_1 = true;
			return;
		}
		checked
		{
			if (A_2[A_2.Length - 1] > 3000.0)
			{
				global::fe.b(this.m_ld, string.Format("Wavelength calibration coefficients #{0} are invalid.", "1"), global::i6.a(bb()));
				A_1 = true;
				return;
			}
			int a_7 = d11.cp;
			float a_8 = d10.ch;
			float a_9 = d10.ci;
			float a_10 = d10.cj;
			float a_11 = d10.ck;
			float a_12 = d10.cl;
			A_3 = null;
			global::ip.m2(a_7, a_8, a_9, a_10, a_11, a_12, ref A_2, ref A_3);
			if (A_2[0] < -3000.0)
			{
				global::fe.b(this.m_ld, string.Format("Wavelength calibration coefficients #{0} are invalid.", "2"), global::i6.a(bb()));
				A_1 = true;
				return;
			}
			if (A_2[A_2.Length - 1] > 3000.0)
			{
				global::fe.b(this.m_ld, string.Format("Wavelength calibration coefficients #{0} are invalid.", "2"), global::i6.a(bb()));
				A_1 = true;
				return;
			}
			d(d10.cu);
			a(ref d10.c7);
			bool flag2 = ((g5().SelectedTab != jg()) ? c(d10.cu) : b(d10.c7));
			bool flag3 = default(bool);
			if (this.m_ln[selectedIndex][index].h == FMUSBDeviceType.FIUSB2DeviceSpecLC && g5().TabPages.Contains(g7()) && (!global::jf.e(d10.cb, this.m_ms) || !global::jf.e(d10.cc, this.m_mt) || !global::jf.e(d10.cd, this.m_mu) || !global::jf.e(d10.ce, this.m_mv) || !global::jf.e(d10.cf, this.m_mw)))
			{
				if (!flag2)
				{
					flag3 = true;
					A_1 = !global::fe.b(ref this.m_ld, "Wavelength Calibration changed: Stray light will be reset \r\n\r\nClick OK to confirm and write firmware.", "Warning", "OKString", "CancelString", global::i6.a(bb()));
					if (A_1)
					{
						return;
					}
				}
				this.m_ld.c(global::fz.b.b, $"the Offset is {A_0.cb} and the original offset is {this.m_ms}\r\nthe slope is {A_0.cc} and the original slope is {this.m_mt}\r\nthe curvature is {A_0.cd} and the original curvature is {this.m_mu}\r\nthe third is {A_0.ce} and the original third is {this.m_mv}\r\nthe fourth is {A_0.cf} and the original fourth is {this.m_mw}\r\n");
			}
			d10.cn = global::iz.d(at().Text);
			d10.co = global::iz.d(@as().Text);
			d10.cq = aw().Checked;
			d10.cs = lv().Checked;
			d10.cr = ko().Checked;
			d10.ct = this.m_li;
			if (d10.ct)
			{
				d10.a = bd().Text.Trim();
				d10.h = bs().Checked;
				if (!d10.h)
				{
					d10.f = global::iz.a(bq().Text);
				}
				d10.cw = global::iz.d(bz().Text);
				d10.cx = global::iz.d(b0().Text);
				if (string.IsNullOrEmpty(bz().Text.Trim()) && string.IsNullOrEmpty(b0().Text.Trim()))
				{
					d10.cv = 2;
					ip.l obj = d10.cy;
					ip.k obj2 = obj.a;
					obj2.b[0] = global::iz.d(cq().Text);
					obj2.b[1] = global::iz.d(cp().Text);
					obj2.b[2] = global::iz.d(co().Text);
					obj2.b[3] = global::iz.d(cn().Text);
					obj2.b[4] = global::iz.d(cm().Text);
					obj2.c = global::iz.d(cb().Text);
					_ = null;
					ip.k obj3 = obj.b;
					obj3.b[0] = global::iz.d(cl().Text);
					obj3.b[1] = global::iz.d(ck().Text);
					obj3.b[2] = global::iz.d(cj().Text);
					obj3.b[3] = global::iz.d(ci().Text);
					obj3.b[4] = global::iz.d(ch().Text);
					obj3.c = global::iz.d(cf().Text);
					_ = null;
					_ = null;
				}
				else
				{
					d10.cv = 1;
				}
				d10.cz = global::iz.b(cx().Text);
				bool flag4 = default(bool);
				if (d10.cz != this.m_ll[selectedIndex][index].cz)
				{
					if (d10.cv == 2)
					{
						ip.l l2 = d10.cy;
						if (!a(l2.a, l2.b))
						{
							ip.k obj4 = l2.a;
							obj4.b[0] = 1f;
							obj4.b[1] = 0f;
							obj4.b[2] = 0f;
							obj4.b[3] = 0f;
							obj4.b[4] = 0f;
							obj4.c = 0f;
							_ = null;
							ip.k obj5 = l2.b;
							obj5.b[0] = 1f;
							obj5.b[1] = 0f;
							obj5.b[2] = 0f;
							obj5.b[3] = 0f;
							obj5.b[4] = 0f;
							obj5.c = 0f;
							_ = null;
							flag4 = true;
						}
						l2 = null;
					}
					else if (d10.cw != 0f && d10.cx != 0f)
					{
						d10.cw = 0f;
						d10.cx = 0f;
						flag4 = true;
					}
				}
				bool flag5 = default(bool);
				if (flag4)
				{
					text2 += "Gain Setting changed - Nonlinearity has been reset.";
					text += "Gain Setting changed: Nonlinearity will be reset.";
					flag5 = true;
				}
				if (flag5)
				{
					A_1 = !global::fe.b(ref this.m_ld, text + "\r\n\r\nClick OK to confirm and write firmware.", "Warning", "OKString", "CancelString", global::i6.a(bb()));
					if (A_1)
					{
						return;
					}
				}
				if (!string.IsNullOrEmpty(text2))
				{
					this.m_ld.c(global::fz.b.b, text2);
				}
				if (flag3)
				{
					a(ref A_0, this.m_ln[selectedIndex][index]);
				}
				d10.c0 = global::iz.b(c6().Text);
				d10.c1 = global::iz.b(c1().Text);
				d10.c2 = global::iz.b(c0().Text);
				d10.c3 = global::iz.d(hk().Text);
				d10.c4 = global::iz.d(hl().Text);
				d10.c5 = global::iz.d(hm().Text);
				d10.c9 = jo().Checked;
				d10.da = global::iz.d(jp().Text);
				d10.db = global::iz.d(k7().Text);
				d10.dc = global::iz.d(k9().Text);
				d10.c6.z = global::iz.d(k1().Text);
				if (flag)
				{
					d10.dd = global::iz.d(l5().Text);
				}
				else
				{
					d10.de = global::iz.d(l5().Text);
				}
				d10.df = global::iz.d(mb().Text);
			}
			d10 = null;
		}
	}

	private bool a(ip.k A_0, ip.k A_1)
	{
		ip.k a_ = new ip.k();
		if (global::ip.k.d(A_0, a_) || global::ip.k.d(A_1, a_))
		{
			return false;
		}
		return true;
	}

	private bool b(ip.g A_0)
	{
		if (global::jf.b(A_0.g, 0.0))
		{
			return false;
		}
		return true;
	}

	private bool c(ip.f A_0)
	{
		ip.f a_ = new ip.f();
		if (global::ip.f.o(A_0, a_))
		{
			return false;
		}
		return true;
	}

	private void a(ref ip.d A_0, ip.e A_1)
	{
		ip.d d10 = A_0;
		if (d10.cu != null)
		{
			d10.cu = null;
		}
		if (d10.c7 != null)
		{
			d10.c7 = null;
		}
		d10.cu = new ip.f();
		d10.c7 = new ip.g();
		a(A_0, A_1);
		a(d10.cu, d10.c7);
		d10 = null;
	}

	private void ad()
	{
		checked
		{
			this.m_lv--;
			if (this.m_lv < 0)
			{
				this.m_lv = 0;
			}
		}
	}

	private void ac()
	{
		checked
		{
			this.m_lv++;
		}
	}

	private void a(bool A_0)
	{
		dk().Visible = A_0;
		dj().Visible = A_0;
		di().Visible = A_0;
		dh().Visible = A_0;
		dg().Visible = A_0;
		df().Visible = A_0;
		el().Visible = A_0;
		en().Visible = A_0;
		fh().Visible = A_0;
		e1().Visible = A_0;
		fk().Visible = !A_0;
		fj().Visible = !A_0;
		h5().Visible = A_0;
		h6().Visible = A_0;
		iy().Visible = A_0;
		j1().Visible = A_0;
		kx().Visible = A_0;
		lz().Visible = A_0;
		ij().Visible = A_0;
		ik().Visible = A_0;
		ir().Visible = A_0;
		iq().Visible = A_0;
		im().Visible = A_0;
	}

	public static string a(fz A_0, IWin32Window A_1, string A_2, bool A_3, Point A_4)
	{
		string text = null;
		if (A_3 || (A_2.Length > 3 && Versioned.IsNumeric(A_2.Substring(0, 2)) && Operators.CompareString(Conversions.ToString(A_2[2]), "A", TextCompare: false) >= 0 && Operators.CompareString(Conversions.ToString(A_2[2]), "Z", TextCompare: false) <= 0))
		{
			string text2 = global::e.a().LastShippingRecPath;
			if (!string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(A_2) && A_2.Length > 0 && !text2.Contains("\\" + A_2))
			{
				text2 = null;
			}
			if (string.IsNullOrEmpty(text2))
			{
				if (!string.IsNullOrEmpty(A_2) && A_2.Length >= 4 && Operators.CompareString(Conversions.ToString(A_2[3]), "#", TextCompare: false) == 0)
				{
					text2 = "\\\\dc\\Engineering\\Shipping_Records\\Internal\\";
				}
				else
				{
					text2 = "\\\\dc\\Engineering\\Shipping_Records\\" + DateTime.Now.Year + "\\";
					if (!Directory.Exists(text2))
					{
						text2 = "\\\\dc\\Engineering\\Shipping_Records\\";
					}
				}
				if (!Directory.Exists(text2))
				{
					return null;
				}
			}
			ay ay2 = new ay();
			ay2.h("Select Logging Folder (normally inside Shipping_Records)");
			ay2.g(text2);
			bool flag;
			string text3;
			do
			{
				flag = false;
				if (ay2.g(A_1) == DialogResult.Cancel)
				{
					text3 = null;
					continue;
				}
				text3 = ay2.f();
				if (!string.IsNullOrEmpty(A_2) && (text3 == null || !text3.Contains("\\" + A_2)))
				{
					flag = !global::fe.b(ref A_0, "Selected path is not inside of a folder named " + A_2 + ".\r\n\r\nAre you sure you wish to write the firmware log file into the path shown below?\r\n" + text3 + "\\", "Warning", A_3: true, "Yes", "Choose Different Folder", A_4);
					if (flag)
					{
						ay2.g(text3);
					}
				}
			}
			while (flag);
			text = text3;
			global::e.a().LastShippingRecPath = text;
		}
		return text;
	}

	private void ab()
	{
		a(new System.Timers.Timer());
		System.Timers.Timer timer = mw();
		timer.Interval = 1000.0;
		timer.Start();
		_ = null;
	}

	private void aa()
	{
		b(new System.Timers.Timer());
		System.Timers.Timer timer = mx();
		timer.Interval = 1000.0;
		timer.Start();
		_ = null;
	}

	private void z()
	{
		if (mw() != null)
		{
			mw().Stop();
			a((System.Timers.Timer)null);
		}
	}

	private void y()
	{
		if (mx() != null)
		{
			mx().Stop();
			b((System.Timers.Timer)null);
		}
	}

	private void x()
	{
		z();
		y();
	}

	private bool a(float A_0)
	{
		if (!(A_0 < 8f))
		{
			return A_0 > 12f;
		}
		return true;
	}

	private void a(float A_0, Point A_1)
	{
		global::fe.b(this.m_ld, "Malfunction: Proposed value for TEC Supply Pot is: " + A_0.ToString("0.00") + "\r\nValue must be between " + 8f + " and " + 12f + ".", A_1);
	}

	public bool m0()
	{
		if (dp().Items == null || dp().Items.Count == 0 || dp().SelectedIndex < 0)
		{
			return true;
		}
		FMLegacyAllSystemTypes fMLegacyAllSystemTypes = (FMLegacyAllSystemTypes)((iz.a)dp().SelectedItem).b;
		return fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeF42 || fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeF42Oxford || fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeF80SS;
	}

	private void a(short A_0)
	{
		cx().Text = A_0.ToString();
	}

	private void a(int A_0, int A_1, int A_2)
	{
		c6().Text = A_0.ToString();
		c1().Text = A_1.ToString();
		c0().Text = A_2.ToString();
	}

	private void w()
	{
		if (jf().Checked)
		{
			i3().Text = "Analyze...";
		}
		else
		{
			i3().Text = "Measure";
		}
	}

	private void v()
	{
		FMLegacyAllSystemTypes a_ = ((dl().SelectedIndex < 0) ? FMLegacyAllSystemTypes.kTypeF10 : ((FMLegacyAllSystemTypes)((iz.a)dl().SelectedItem).b));
		dp().Items.Clear();
		if (this.m_lp[aq().SelectedIndex][e0().SelectedIndex].b)
		{
			if (this.m_lj)
			{
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeS3), 35));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF2), 32));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF3), 33));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF10), 7));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF20), 1));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF30), 2));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF40), 3));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF40NSR), 27));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF20_F40), 20));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF50_300B), 19));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF50_450B), 25));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF60), 37));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF70), 8));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF80SS), 21));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF32), 26));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF37), 24));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF42), 22));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF42Oxford), 23));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeSpecial), 6));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypePARTS), 28));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF50XY_510), 29));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF50XY_10), 31));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeUVSource), 30));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeOpticalAcc), 36));
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeHnl), 38));
			}
			else if (this.m_lk)
			{
				dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeUVSource), 30));
			}
		}
		else if (this.m_lj)
		{
			dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF10), 7));
			dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF20), 1));
			dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF30), 2));
			dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF40), 3));
			dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF20_F40), 20));
			dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF50_200), 4));
			dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF50_300), 9));
			dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF50XY_200), 17));
			dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF50_200B), 18));
			dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF50_300B), 19));
			dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF50_450B), 25));
			dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF50XY_450), 12));
			dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF80SS), 21));
			dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF42), 22));
			dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeF42Oxford), 23));
			dp().Items.Add(new iz.a(global::h6.p9(FMLegacyAllSystemTypes.kTypeSpecial), 6));
		}
		if (dm().SelectedItem != null && ((iz.a)dm().SelectedItem).b == 3 && global::iz.a(dp(), 38) >= 0)
		{
			global::iz.b(dp(), 38);
		}
		else
		{
			global::iz.b(dp(), (int)a_);
		}
	}

	private void u()
	{
		ComboBox comboBox = dm();
		ew.a a10 = (ew.a)((comboBox.Items.Count > 0) ? checked((byte)((iz.a)comboBox.SelectedItem).b) : 0);
		ComboBox.ObjectCollection items = comboBox.Items;
		items.Clear();
		items.Add(new iz.a(global::ew.a(global::ew.a.a), 0));
		items.Add(new iz.a(global::ew.a(global::ew.a.b), 1));
		items.Add(new iz.a(global::ew.a(global::ew.a.c), 2));
		items.Add(new iz.a(global::ew.a(global::ew.a.d), 3));
		_ = null;
		comboBox = null;
		if (dp().SelectedItem != null && ((iz.a)dp().SelectedItem).b == 38 && global::iz.a(dm(), 3) >= 0)
		{
			global::iz.b(dm(), 3);
			return;
		}
		if (a10 == global::ew.a.d)
		{
			a10 = global::ew.a.a;
		}
		global::iz.b(dm(), (int)a10);
	}

	private void t()
	{
		ComboBox.ObjectCollection items = df().Items;
		items.Clear();
		short num = 1;
		checked
		{
			do
			{
				items.Add(new iz.a(num.ToString(), num));
				num = (short)unchecked(num + 1);
			}
			while (num <= 10);
			items = null;
		}
	}

	private void s()
	{
		ComboBox.ObjectCollection items = el().Items;
		items.Clear();
		items.Add(new iz.a(global::g2.c(FMOpticConfigEnums.kFMOpticConfigRPStage), 1));
		items.Add(new iz.a(global::g2.c(FMOpticConfigEnums.kFMOpticConfigTransStage), 2));
		items.Add(new iz.a(global::g2.c(FMOpticConfigEnums.kFMOpticConfigCP), 3));
		items.Add(new iz.a(global::g2.c(FMOpticConfigEnums.kFMOpticConfigCPAutoBase), 4));
		items.Add(new iz.a(global::g2.c(FMOpticConfigEnums.kFMOpticConfigCS), 5));
		items.Add(new iz.a(global::g2.c(FMOpticConfigEnums.kFMOpticConfigCSAutoBase), 6));
		items.Add(new iz.a(global::g2.c(FMOpticConfigEnums.kFMOpticConfigMicroscopeR), 7));
		items.Add(new iz.a(global::g2.c(FMOpticConfigEnums.kFMOpticConfigMicroscopeT), 8));
		items.Add(new iz.a(global::g2.c(FMOpticConfigEnums.kFMOpticConfigCTMProbe), 9));
		items.Add(new iz.a(global::g2.c(FMOpticConfigEnums.kFMOpticConfigTransCurved), 10));
		_ = null;
	}

	private void r()
	{
		ComboBox.ObjectCollection items = dg().Items;
		items.Clear();
		items.Add(new iz.a(global::h6.m2(FMRefMatEnums.kRefMatSi), 1));
		items.Add(new iz.a(global::h6.m2(FMRefMatEnums.kRefMatBk7), 2));
		items.Add(new iz.a(global::h6.m2(FMRefMatEnums.kRefMatFusedSilica2Sided), 3));
		items.Add(new iz.a(global::h6.m2(FMRefMatEnums.kRefMatALREF), 5));
		_ = null;
	}

	private void q()
	{
		ComboBox.ObjectCollection items = dl().Items;
		items.Clear();
		if (dp().SelectedItem != null)
		{
			items.Add(new iz.a("Base", 0));
			FMLegacyAllSystemTypes fMLegacyAllSystemTypes = (FMLegacyAllSystemTypes)((iz.a)dp().SelectedItem).b;
			switch (fMLegacyAllSystemTypes)
			{
			case FMLegacyAllSystemTypes.kTypeF10:
				items.Add(new iz.a("F10-AR", 1));
				items.Add(new iz.a("F10-HC", 4));
				items.Add(new iz.a("F10-PA", 2));
				items.Add(new iz.a("F10-PV", 5));
				items.Add(new iz.a("F10-VC", 3));
				items.Add(new iz.a("F10-RT", 6));
				items.Add(new iz.a("F10-ARc", 7));
				items.Add(new iz.a("F10-RTA", 8));
				break;
			case FMLegacyAllSystemTypes.kTypeF20:
				items.Add(new iz.a("F20-HC", 1));
				items.Add(new iz.a("F20e", 2));
				break;
			case FMLegacyAllSystemTypes.kTypeF3:
				items.Add(new iz.a("F3-CP", 1));
				items.Add(new iz.a("F3-CS", 2));
				items.Add(new iz.a("F3-sX", 3));
				break;
			case FMLegacyAllSystemTypes.kTypeF50_300B:
				items.Add(new iz.a("F54", 1));
				items.Add(new iz.a("F57", 2));
				items.Add(new iz.a("F50-sX", 3));
				items.Add(new iz.a("F50XYRT_300", 4));
				break;
			case FMLegacyAllSystemTypes.kTypeF60:
				items.RemoveAt(0);
				items.Add(new iz.a("F64-t", 1));
				items.Add(new iz.a("F64-c", 2));
				items.Add(new iz.a("F60-t", 3));
				items.Add(new iz.a("F60-c", 4));
				break;
			case FMLegacyAllSystemTypes.kTypeUVSource:
				items.Add(new iz.a("DT-2", 1));
				break;
			case FMLegacyAllSystemTypes.kTypeHnl:
				items.RemoveAt(0);
				items.Add(new iz.a("HST-DB566", 1));
				break;
			case FMLegacyAllSystemTypes.kTypeOpticalAcc:
				items.RemoveAt(0);
				items.Add(new iz.a("Fiber On/Off Switch, 2 Channel", 1));
				items.Add(new iz.a("XY10 Stage", 3));
				break;
			}
			items = null;
			if (fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeUVSource)
			{
				dl().SelectedIndex = 1;
			}
			else
			{
				dl().SelectedIndex = 0;
			}
		}
	}

	public void m1()
	{
		int selectedIndex = aq().SelectedIndex;
		int selectedIndex2 = e0().SelectedIndex;
		v();
		u();
		t();
		s();
		r();
		e1().Visible = this.m_lp[selectedIndex][selectedIndex2].b;
		h6.c c10 = this.m_lo[selectedIndex][selectedIndex2];
		d4().Text = c10.f.ToString();
		d3().Checked = c10.h;
		d3().Enabled = !c10.i && c10.g > c10.f;
		fr().Enabled = c10.e;
		fu().Enabled = c10.e;
		d2().Enabled = c10.e;
		ex().Enabled = c10.e && this.m_li;
		en().Enabled = c10.e;
		ep().Enabled = c10.e;
		em().Enabled = c10.e;
		fh().Enabled = c10.e;
		ev().Enabled = c10.e;
		fl().Enabled = c10.e;
		im().Enabled = c10.e;
		fj().Enabled = c10.e;
		h2().Enabled = c10.e;
		if (c10.i)
		{
			es().Text = "Corrupt";
			er().Text = "Corrupt";
		}
		else
		{
			es().Text = c10.d.ToString("d");
			er().Text = c10.d.ToString("T");
		}
		ev().Text = c10.a;
		ev().ReadOnly = !this.m_li;
		h5().Checked = c10.ah;
		iy().Checked = c10.ai;
		j1().Checked = c10.aj;
		kx().Checked = c10.ak;
		lz().Checked = c10.al;
		l2().Checked = c10.am;
		l7().Checked = c10.bl;
		l0().Checked = c10.an;
		ik().Checked = c10.ao;
		iq().Checked = c10.aq;
		fj().Text = c10.j;
		this.m_lu = c10.k;
		ds().Text = this.m_lu.ToString();
		h2().Text = c10.l.ToString();
		d9().Checked = c10.ab;
		List<int> list = o();
		if (list.Count == 1 && this.m_ln[selectedIndex][list[0]].m)
		{
			dw().Text = "F40 IR Spectrum";
		}
		dw().Checked = c10.ac;
		dv().Checked = c10.ad;
		dx().Checked = c10.x;
		ea().Checked = c10.aa;
		ee().Checked = c10.o;
		eo().Checked = c10.p;
		fw().Checked = c10.ag;
		h4().Checked = c10.@as;
		ln().Checked = c10.at;
		lp().Checked = c10.bf;
		if (c10.au || c10.av)
		{
			ih().Checked = true;
			kr().Checked = c10.au;
		}
		else
		{
			ih().Checked = false;
		}
		iv().Checked = c10.aw;
		js().Checked = c10.ax;
		fs().Checked = c10.ay;
		lk().Checked = c10.ba;
		lo().Checked = c10.bd;
		lq().Checked = c10.be;
		ls().Checked = c10.bg;
		lr().Checked = c10.bh;
		lt().Checked = c10.bi;
		lu().Checked = c10.bj;
		if (c10.bk == global::h6.LinearActuatorType.Hiwin)
		{
			lx().SelectedIndex = 1;
		}
		else
		{
			lx().SelectedIndex = 0;
		}
		nh = c10.a4;
		ni = c10.a5;
		nj = c10.a6;
		nk = c10.a7;
		nl = c10.a8;
		nm = c10.a9;
		j0().Checked = c10.a0;
		lj().Checked = c10.bb;
		li().Checked = c10.bc;
		ku().Checked = c10.a1;
		kv().Checked = c10.a2;
		kw().Checked = c10.a3;
		d7().Checked = c10.t;
		eg().Checked = c10.y;
		ef().Checked = c10.z;
		ed().Checked = c10.q;
		d8().Checked = c10.n;
		ec().Checked = c10.r;
		eb().Checked = c10.s;
		d6().Checked = c10.u;
		du().Checked = c10.v;
		fp().Text = c10.ae.ToString("0.0000");
		fq().Text = c10.af.ToString("0.0000");
		try
		{
			ac();
			dy().Checked = c10.w;
			eh().Checked = c10.m;
			if (global::iz.a(dp(), (int)c10.bm) >= 0)
			{
				global::iz.b(dp(), (int)c10.bm);
			}
			else if (this.m_lj)
			{
				global::iz.b(dp(), 7);
			}
			else
			{
				dp().SelectedIndex = -1;
				a(A_0: false);
				fu().Visible = false;
			}
			if (global::iz.a(dm(), c10.bn) >= 0)
			{
				global::iz.b(dm(), c10.bn);
			}
			else
			{
				global::iz.b(dm(), 0);
			}
			if (global::iz.a(dl(), c10.bo) >= 0)
			{
				global::iz.b(dl(), c10.bo);
			}
			else
			{
				global::iz.b(dl(), 0);
			}
			if (global::iz.a(dg(), (int)c10.bp) >= 0)
			{
				global::iz.b(dg(), (int)c10.bp);
			}
			else
			{
				global::iz.b(dg(), 1);
			}
			if (global::iz.a(df(), c10.br) >= 0)
			{
				global::iz.b(df(), c10.br);
			}
			else
			{
				global::iz.b(df(), 1);
			}
			if (global::iz.a(el(), (int)c10.bs) >= 0)
			{
				global::iz.b(el(), (int)c10.bs);
			}
			else
			{
				global::iz.b(el(), 1);
			}
		}
		finally
		{
			ad();
		}
		it().Text = c10.bq.ToString();
		ej().Text = c10.bt.ToString();
		fb().Text = c10.bw.ToString();
		ff().Text = c10.bu.ToString();
		jt().Text = c10.bv.ToString();
		fg().Checked = c10.bx;
		fi().Checked = c10.by;
		e9().Checked = c10.bz;
		e8().Checked = c10.b0;
		jz().Checked = c10.az;
		bool visible = this.m_li || c10.b7;
		ew().Visible = visible;
		c10 = null;
		f();
	}

	private void a(ip.m.a A_0, ip.k A_1)
	{
		ip.k k2 = A_1;
		if (A_0 == global::ip.m.a.a)
		{
			cq().Text = k2.b[0].ToString();
			cp().Text = k2.b[1].ToString();
			co().Text = k2.b[2].ToString();
			cn().Text = k2.b[3].ToString();
			cm().Text = k2.b[4].ToString();
			if (k2.c != 0f)
			{
				cb().Text = k2.c.ToString();
			}
			else
			{
				cb().Text = "Unknown";
			}
		}
		else
		{
			cl().Text = k2.b[0].ToString();
			ck().Text = k2.b[1].ToString();
			cj().Text = k2.b[2].ToString();
			ci().Text = k2.b[3].ToString();
			ch().Text = k2.b[4].ToString();
			cf().Text = k2.c.ToString();
			if (k2.c != 0f)
			{
				cf().Text = k2.c.ToString();
			}
			else
			{
				cf().Text = "Unknown";
			}
		}
		k2 = null;
	}

	private void a(bool A_0, bool A_1)
	{
		bool flag = false;
		ip.d d10 = this.m_ll[aq().SelectedIndex][m()];
		bool flag2 = (!bt().TabPages.Contains(by()) || (flag && !d10.i && d10.cv == 1)) && A_0;
		d10 = null;
		b0().Enabled = flag2;
		bz().Enabled = flag2;
		b1().Visible = flag2;
		cq().Enabled = A_0;
		cp().Enabled = A_0;
		co().Enabled = A_0;
		cn().Enabled = A_0;
		cm().Enabled = A_0;
		cb().Enabled = A_0;
		cr().Enabled = A_0;
		ip.e e10 = this.m_ln[aq().SelectedIndex][m()];
		bool enabled = A_0 && e10.p && A_1 && e10.q;
		e10 = null;
		cl().Enabled = enabled;
		ck().Enabled = enabled;
		cj().Enabled = enabled;
		ci().Enabled = enabled;
		ch().Enabled = enabled;
		cf().Enabled = enabled;
		cs().Enabled = enabled;
	}

	private void b(ip.d A_0, ip.e A_1)
	{
		bool flag = A_0.cv == 1;
		if (flag && !bt().TabPages.Contains(bu()))
		{
			bt().TabPages.Insert(0, bu());
		}
		else if (!flag && bt().TabPages.Contains(bu()))
		{
			bt().TabPages.Remove(bu());
		}
		bool flag2 = A_1.f;
		if (flag2 && !bt().TabPages.Contains(by()))
		{
			bt().TabPages.Insert(0, by());
		}
		else if (!flag2 && bt().TabPages.Contains(by()))
		{
			bt().TabPages.Remove(by());
		}
	}

	private void a(bool A_0, float A_1)
	{
		jo().Checked = A_0;
		jp().Text = A_1.ToString();
	}

	private bool b(ip.f A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		return A_0.k[0] != 0f || A_0.k[1] != 0f || A_0.k[2] != 0f || A_0.m > 0;
	}

	private bool a(ip.e A_0)
	{
		if (A_0.h != FMUSBDeviceType.FIUSB2DeviceSpecLC && A_0.h != FMUSBDeviceType.FIUSB2DeviceSpecUvVis2 && A_0.h != FMUSBDeviceType.FIUSB2DeviceSpecNIR2)
		{
			return A_0.h == FMUSBDeviceType.FIUSB2DeviceSpecTCNIR;
		}
		return true;
	}

	private bool a(ip.f A_0)
	{
		if ((double)A_0.b == 0.0 && (double)A_0.c == 0.0 && (double)A_0.f == 0.0)
		{
			return (double)A_0.i == 0.0;
		}
		return false;
	}

	private void p()
	{
		ji().Text = "0.0";
		jl().Text = 1.0.ToString("0.0#####");
		jv().Text = "0.0";
	}

	private void a(ip.d A_0, ip.e A_1)
	{
		ip.d d10 = A_0;
		bool flag = a(A_1);
		j2().Visible = flag;
		if (flag)
		{
			j5().AutoScroll = true;
			hv().AutoScroll = true;
			if (d10.cu == null || a(d10.cu) || (d10.c8 && d10.c7 != null))
			{
				j3().Checked = true;
			}
			else
			{
				j4().Checked = true;
			}
		}
		else
		{
			j5().AutoScroll = false;
			j5().AutoSize = true;
			hv().AutoScroll = false;
			hv().AutoSize = true;
			g5().Height = 290;
			j4().Checked = true;
		}
		d10 = null;
	}

	private void a(ip.f A_0, ip.g A_1)
	{
		if (A_0 != null)
		{
			ip.f f10 = A_0;
			bool flag = default(bool);
			if ((f10.k[0] == 0f && f10.k[1] == 0f && f10.k[2] == 0f) || f10.m > 0)
			{
				flag = true;
			}
			km().Text = f10.b.ToString();
			j8().Text = f10.d.ToString();
			j6().Text = f10.e.ToString();
			kl().Text = f10.c.ToString();
			kc().Text = f10.h.ToString();
			kd().Text = f10.g.ToString();
			ke().Text = f10.f.ToString();
			ka().Text = f10.j.ToString();
			kb().Text = f10.i.ToString();
			if (flag)
			{
				g8().Visible = false;
				hw().Visible = true;
				hz().Text = f10.m.ToString();
				h0().Text = f10.n.ToString();
			}
			else
			{
				g8().Visible = true;
				hw().Visible = false;
				hc().Text = f10.k[0].ToString();
				hd().Text = f10.k[1].ToString();
				he().Text = f10.k[2].ToString();
				hq().Text = f10.k[3].ToString();
				hr().Text = f10.k[4].ToString();
				hs().Text = f10.k[5].ToString();
			}
			f10 = null;
		}
		if (A_1 != null)
		{
			ip.g g10 = A_1;
			ji().Text = g10.g.ToString("0.0####E-00");
			jl().Text = ((float)g10.h).ToString("0.0#####");
			jv().Text = g10.i.ToString("0.0####E-00");
			m6 = A_1;
			g10 = null;
		}
		else
		{
			p();
		}
		if (b(A_0))
		{
			if (!g5().TabPages.Contains(g7()))
			{
				g5().TabPages.Add(g7());
			}
		}
		else if (g5().TabPages.Contains(g7()))
		{
			g5().TabPages.Remove(g7());
		}
		a(m6);
	}

	private List<int> o()
	{
		int selectedIndex = aq().SelectedIndex;
		string right = this.m_lo[selectedIndex][e0().SelectedIndex].b;
		List<int> list = new List<int>();
		checked
		{
			int num = this.m_ln[selectedIndex].Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (Operators.CompareString(this.m_ln[selectedIndex][num2].t, right, TextCompare: false) == 0)
				{
					list.Add(num2);
				}
			}
			return list;
		}
	}

	private h6.c n()
	{
		return this.m_lo[aq().SelectedIndex][e0().SelectedIndex];
	}

	private int m()
	{
		List<int> list = o();
		if (bm().SelectedIndex >= 0 && bm().SelectedIndex < list.Count)
		{
			return list[bm().SelectedIndex];
		}
		return 0;
	}

	private int l()
	{
		List<int> list = o();
		if (bm().SelectedIndex >= 0 && gk().SelectedIndex < list.Count)
		{
			return list[gk().SelectedIndex];
		}
		return 0;
	}

	private bool k()
	{
		int selectedIndex = aq().SelectedIndex;
		List<int> list = o();
		if (list.Count == 1)
		{
			return this.m_ln[selectedIndex][list[0]].l;
		}
		return false;
	}

	private bool j()
	{
		int selectedIndex = aq().SelectedIndex;
		List<int> list = o();
		if (list.Count == 1)
		{
			return this.m_ln[selectedIndex][list[0]].i;
		}
		return false;
	}

	private void i()
	{
		int selectedIndex = aq().SelectedIndex;
		int index = m();
		int selectedIndex2 = e0().SelectedIndex;
		ip.e e10 = this.m_ln[selectedIndex][index];
		ip.d d10 = this.m_ll[selectedIndex][index];
		h6.c c10 = this.m_lo[selectedIndex][selectedIndex2];
		ComboBox comboBox = ax();
		comboBox.Items.Clear();
		if (e10.i)
		{
			comboBox.Items.Add(new a("UV-Vis", "190", "1100"));
		}
		if (e10.j)
		{
			if (e10.k)
			{
				comboBox.Items.Add(new a("Vis+", "380", "1100"));
			}
			else
			{
				comboBox.Items.Add(new a("Vis", "380", "1050"));
			}
		}
		if (e10.i)
		{
			comboBox.Items.Add(new a("UV-Vis (old)", "200", "1100"));
		}
		comboBox.Items.Add(new a("Custom"));
		bool flag = default(bool);
		foreach (a item in comboBox.Items)
		{
			if (global::jf.e(Conversions.ToSingle(item.b), d10.cn) && global::jf.e(Conversions.ToSingle(item.c), d10.co))
			{
				ax().SelectedItem = item;
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			comboBox.SelectedIndex = checked(comboBox.Items.Count - 1);
		}
		comboBox = null;
		if (e10.n)
		{
			ar().Visible = true;
		}
		else
		{
			ar().Visible = false;
		}
		this.m_ms = d10.cb;
		this.m_mt = d10.cc;
		this.m_mu = d10.cd;
		this.m_mv = d10.ce;
		this.m_mw = d10.cf;
		this.m_mx = d10.cg;
		this.m_my = d10.ch;
		this.m_mz = d10.ci;
		this.m_m0 = d10.cj;
		this.m_m1 = d10.ck;
		m2 = d10.cl;
		b(d10, e10);
		ip.d d11 = d10;
		a(d11.e, d11.cy.a.b[0] != 0f, c10.b7);
		bd().Text = d11.a;
		ac();
		try
		{
			a4().Text = d11.cb.ToString();
			a3().Text = d11.cc.ToString();
			a2().Text = d11.cd.ToString();
			lb().Text = d11.ce.ToString();
			la().Text = d11.cf.ToString();
			i4().Text = d11.cg.ToString();
			aw().Checked = d11.cq;
			ko().Checked = d11.cr;
		}
		finally
		{
			ad();
		}
		lv().Checked = d11.cs;
		jb().Text = d11.ch.ToString();
		je().Text = d11.ci.ToString();
		i9().Text = d11.cj.ToString();
		lf().Text = d11.ck.ToString();
		le().Text = d11.cl.ToString();
		i7().Text = d11.cm.ToString();
		at().Text = d11.cn.ToString();
		@as().Text = d11.co.ToString();
		bg().Text = d11.d.ToString("d");
		bh().Text = d11.d.ToString("T");
		bq().Text = d11.f.ToString();
		bs().Checked = d11.h;
		bs().Enabled = !d11.i && d11.g > d11.f;
		hk().Text = d11.c3.ToString();
		hl().Text = d11.c4.ToString();
		hm().Text = d11.c5.ToString();
		a(d10, e10);
		a(d11.cu, d11.c7);
		m3 = null;
		switch (d11.cv)
		{
		case 1:
			b0().Text = d11.cx.ToString();
			bz().Text = d11.cw.ToString();
			cq().Text = string.Empty;
			cp().Text = string.Empty;
			co().Text = string.Empty;
			cn().Text = string.Empty;
			cm().Text = string.Empty;
			cb().Text = "Unknown";
			cl().Text = string.Empty;
			ck().Text = string.Empty;
			cj().Text = string.Empty;
			ci().Text = string.Empty;
			ch().Text = string.Empty;
			cf().Text = "Unknown";
			break;
		case 2:
		{
			b0().Text = string.Empty;
			bz().Text = string.Empty;
			ip.l l2 = d11.cy;
			a(global::ip.m.a.a, l2.a);
			a(global::ip.m.a.b, l2.b);
			l2 = null;
			break;
		}
		}
		a(d11.cz);
		a(d11.c0, d11.c1, d11.c2);
		h6.c c11 = c10;
		h8().Visible = global::h6.m2(e10.r, c11.ai, c11.bl);
		c11 = null;
		a(d11.c6);
		jm().Visible = e10.s;
		a(d11.c9, d11.da);
		k4().Visible = e10.h == FMUSBDeviceType.FIUSB2DeviceSpecLC;
		if (e10.h == FMUSBDeviceType.FIUSB2DeviceSpecLC && d11.i)
		{
			k7().Text = "28";
			k9().Text = "2";
		}
		else
		{
			k7().Text = d11.db.ToString();
			k9().Text = d11.dc.ToString();
		}
		l3().Visible = this.m_le.ui();
		if (nn[selectedIndex].ab == global::h.f.a)
		{
			gu().SetToolTip(l5(), "In Sept. 2017, an issue was observed in F2 (aRTie) systems: AlRef measured after a baseline on Si is about 0.5% too low.\r\n This may correspond to changes made in the optics with the introduction of new parabolic mirrors and\r\n may indicate an error in the formula used to correct the non-linearity and/or in the method of \r\n determining the correction coefficients. This amplitude factor determines the amount of correction\r\n that will result when the baseline linearity correction is calibrated. For systems built in September\r\n 2017 or later this factor should be ~ 0.85. For systems built earlier, calibrations were taken\r\n using a value of 1. For F10-RT systems, the value of 1.0 seems to work.");
			l5().Text = d11.dd.ToString();
		}
		else
		{
			gu().SetToolTip(l5(), "In Oct. 2017, an issue was observed in F2 (aRTie) systems: Al2O3 measured after a baseline on Si is about 0.5% too high.\r\n We found we had not accounted for additional transmitted light reflected off the sample and then off the reference.\r\n After accounting for this extra light, we found that the correction results in transmittance spectra \r\n that is ~ 0.7% low. This amplitude factor allows tuning the amount of correction to apply. For systems built\r\n in September2017 or later this factor should be ~ 0.368. For systems built earlier, corrections were made\r\n using a value of 0. For F10-RT systems, the value of 0 seems to work.");
			l5().Text = d11.de.ToString();
		}
		mb().Text = d11.df.ToString();
		d11 = null;
		h();
		f();
	}

	private void h()
	{
		string path = global::ip.j.ah();
		(new char[1])[0] = '_';
		string text = this.m_ln[aq().SelectedIndex][m()].a.ToLower();
		if (Operators.CompareString(text, global::ip.m2(FMUSBDeviceType.FIUSB2DeviceSpecUvVis2).ToLower(), TextCompare: false) == 0)
		{
			text = "uvvis2spd";
		}
		ComboBox comboBox = ix();
		comboBox.Items.Clear();
		if (Directory.Exists(path))
		{
			foreach (string item in Directory.EnumerateFiles(path))
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(item);
				if (Operators.CompareString(Path.GetExtension(item).ToLower(), ".csv", TextCompare: false) == 0 && fileNameWithoutExtension.ToLower().Contains(text))
				{
					ix().Items.Add(fileNameWithoutExtension);
				}
			}
		}
		if (comboBox.Items.Count > 0)
		{
			comboBox.SelectedItem = RuntimeHelpers.GetObjectValue(comboBox.Items[0]);
			comboBox.Enabled = true;
			i3().Enabled = true;
		}
		else
		{
			comboBox.Enabled = false;
			i3().Enabled = false;
		}
		comboBox = null;
		w();
	}

	private void g()
	{
		if (!AutoSize)
		{
			base.Width = checked(ao().Width + 2 * ao().Left + base.Width - base.ClientSize.Width);
		}
	}

	private void f()
	{
		if (ao().TabPages.Contains(ba()))
		{
			bj().PerformLayout();
		}
		checked
		{
			int num = ((!ao().TabPages.Contains(ba()) || kz().Width <= ky().Width) ? (ky().Width + ky().Left) : (kz().Width + kz().Left));
			num += 10;
			int num2 = ((!ao().TabPages.Contains(ba()) || kz().Height <= ky().Height) ? (ky().Height + ky().Top) : (kz().Height + kz().Top));
			num2 += 28;
			if (ao().TabPages.Contains(fx()))
			{
				if (fy().Width + fy().Left > num)
				{
					num = fy().Width + fy().Left;
				}
				if (fy().Height + fy().Top > num2)
				{
					num2 = fy().Height + fy().Top;
				}
			}
			ao().ClientSize = new Size(num, num2);
			g();
			if (!this.m_lt)
			{
				return;
			}
			_ = Screen.AllScreens[global::i6.a(base.Left, base.Top)];
			Rectangle workingArea = Screen.AllScreens[global::i6.a(base.Left, base.Top)].WorkingArea;
			if (AutoSize)
			{
				int num3 = base.Height;
				if (base.Height > workingArea.Height)
				{
					AutoSize = false;
					base.SizeGripStyle = SizeGripStyle.Auto;
					base.Height = workingArea.Height;
					g();
					MaximumSize = new Size(base.Width + 25, num3);
				}
			}
			else if (an().Height + base.Height - base.ClientSize.Height < workingArea.Height)
			{
				AutoSize = true;
			}
		}
	}

	private void e()
	{
		int selectedIndex = aq().SelectedIndex;
		int a_ = l();
		this.m_le.qh(this.m_lh, n().b8, selectedIndex, a_, mm());
	}

	private void d()
	{
		e();
		this.m_lx = new Collection<cf>();
		gi().Items.Clear();
	}

	private void c()
	{
		int selectedIndex = f0().SelectedIndex;
		@in.b b10 = this.m_lq[selectedIndex];
		string empty = string.Empty;
		@in.b b11 = b10;
		Color backColor = ((!b11.e) ? SystemColors.ButtonFace : SystemColors.Window);
		g4().Items.Clear();
		int num = 1;
		checked
		{
			do
			{
				g4().Items.Add(num.ToString());
				num++;
			}
			while (num <= 3);
			g4().SelectedIndex = b10.b9 - 1;
			_ = null;
			g4().Enabled = b11.e;
			fz().Enabled = b11.e;
			f8().ReadOnly = !b11.e;
			f8().BackColor = backColor;
			f8().Text = b11.a;
			f5().Text = b11.d.ToString("d");
			f4().Text = b11.d.ToString("T");
			g4().SelectedText = b11.b9.ToString();
			int num2 = b11.ca.Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				empty = b11.ca[num3].ToString();
				switch (num3)
				{
				case 0:
					g1().Text = empty;
					break;
				case 1:
					gy().Text = empty;
					break;
				default:
					gx().Text = empty;
					break;
				}
			}
			ge().Text = b11.f.ToString();
			gd().Checked = b11.h;
			gd().Enabled = !b11.i && b11.g > b11.f;
			a(b11.e, ge(), gd(), this.m_lq[f0().SelectedIndex].g);
			b11 = null;
			f();
		}
	}

	public void a(ip.n A_0)
	{
		ip.n n2 = A_0;
		k1().Text = n2.z.ToString();
		k0().Enabled = n2.ab != 0f || n2.ac != 0f || n2.aa != 0f || n2.z != 0f;
		@if().Text = n2.aa.ToString();
		id().Text = n2.ab.ToString();
		ib().Text = n2.ac.ToString();
		n2 = null;
	}

	private void a(ip.g A_0)
	{
		if (g5().TabPages.Contains(jg()))
		{
			if (global::iz.a(bq().Text) >= this.m_mq)
			{
				jl().Enabled = true;
				ji().Enabled = true;
			}
			else
			{
				jl().Enabled = false;
				ji().Enabled = false;
			}
			jv().Enabled = global::iz.a(bq().Text) >= this.m_mr;
		}
		if (this.m_ln[aq().SelectedIndex][m()].h == FMUSBDeviceType.FIUSB2DeviceSpecLC && (!global::jf.e(this.m_ms, global::iz.d(a4().Text)) || !global::jf.e(this.m_mt, global::iz.d(a3().Text)) || !global::jf.e(this.m_mu, global::iz.d(a2().Text)) || !global::jf.e(this.m_mv, global::iz.d(lb().Text)) || !global::jf.e(this.m_mw, global::iz.d(la().Text))))
		{
			bl().Enabled = false;
			gu().SetToolTip(g5(), "The wavelength calibration coefficients must be written to firmware before dc scatter can be calibrated.");
			return;
		}
		string text = string.Empty;
		if (g5().TabPages.Contains(jg()) && g5().SelectedTab == jg())
		{
			if (global::iz.a(bq().Text) >= this.m_mq && m9)
			{
				bl().Enabled = true;
			}
			else
			{
				bl().Enabled = false;
				text = "To measure and update firmware with the LED Scatter Calibration, a scatter calibration system\r\n must be connected and the firmware revision must be >= " + this.m_mq + ".";
			}
			if (global::iz.a(bq().Text) >= this.m_mr && m9 && A_0 != null && !b(A_0))
			{
				jx().Enabled = true;
			}
			else
			{
				jx().Enabled = false;
				if (!string.IsNullOrEmpty(text))
				{
					text += "\r\n\r\n";
				}
				text = text + "To optimize LED Scatter Offset the firmware revision must be >= " + this.m_mr + ".";
			}
		}
		else
		{
			bl().Enabled = true;
		}
		gu().SetToolTip(g5(), text);
	}

	private void b(r.c A_0, bool A_1)
	{
		if (base.InvokeRequired)
		{
			BeginInvoke(new r.c.b(b), A_0, A_1);
			return;
		}
		try
		{
			if (m8 != null)
			{
				r.c c10 = A_0;
				lock (jy())
				{
					nd = c10.v();
					ne = c10.w();
					ng = c10.x();
					nf = c10.y();
				}
				m8.a(c10.u());
				if (nd < 1)
				{
					m8.b(checked((int)Math.Round(c10.t())));
				}
				if (A_1)
				{
					bool a_ = global::fe.b(ref this.m_ld, c10.ad(), c10.ae(), c10.af(), c10.ag(), global::i6.a(m8));
					c10.t(a_);
				}
				c10 = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			this.m_ld.c(global::fz.b.b, "Exception in LongStepProcessStatusChanged(). ", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void ax(object A_0, EventArgs A_1)
	{
		try
		{
			ip.p p2 = new ip.p();
			p2.a = aq().SelectedIndex;
			p2.b = m();
			p2.c = n().b8;
			FMUSBDeviceType fMUSBDeviceType = this.m_ln[p2.a][p2.b].h;
			if (fMUSBDeviceType == FMUSBDeviceType.FIUSB2DeviceSpecLC || fMUSBDeviceType == FMUSBDeviceType.FIUSB2DeviceSpecNIR2 || fMUSBDeviceType == FMUSBDeviceType.FIUSB2DeviceSpecUvVis2 || fMUSBDeviceType == FMUSBDeviceType.FIUSB2DeviceSpecTCNIR)
			{
				bc obj = new bc();
				short A_2 = default(short);
				obj.a(A_3: (fMUSBDeviceType != FMUSBDeviceType.FIUSB2DeviceSpecUvVis2) ? this.m_ln[p2.a][p2.b].g : ((float)this.m_ll[p2.a][p2.b].cz), A_0: this.m_lh, A_1: fMUSBDeviceType, A_2: p2, A_4: this.m_le, A_5: this.m_ld, A_6: ref A_2);
				if (obj.DialogResult != DialogResult.Cancel)
				{
					a(A_2);
				}
			}
			else if (global::fe.b(ref this.m_ld, "Place BK7 Reference sample on the stage.", "FirmwareADGainCalTitle", "OKString", "CancelString", global::i6.a(ct())))
			{
				base.Enabled = false;
				Cursor = Cursors.WaitCursor;
				this.m_le.p9(this.m_lh, p2, global::r.d.a.b.a, mj());
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonCalibrateGain_Click", a_);
			base.Enabled = true;
			Cursor = Cursors.Default;
			ProjectData.ClearProjectError();
		}
	}

	private void aw(object A_0, EventArgs A_1)
	{
	}

	private void s(r.d.a A_0)
	{
	}

	private void a(r.c A_0, bool A_1)
	{
	}

	private void av(object A_0, EventArgs A_1)
	{
		try
		{
			ip.q q2 = new ip.q();
			q2.a = aq().SelectedIndex;
			q2.b = m();
			q2.c = n().b8;
			if (this.m_ln[q2.a][q2.b].c && global::fe.b(ref this.m_ld, "Spectrometer input must be blocked so that no light reaches detector.", "FirmwareADOffsetCalTitle", "OKString", "CancelString", global::i6.a(ct())))
			{
				base.Enabled = false;
				Cursor = Cursors.WaitCursor;
				this.m_le.qh(this.m_lh, q2, global::r.d.a.b.a, mk());
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonCalibrateADOffsets_Click", a_);
			base.Enabled = true;
			Cursor = Cursors.Default;
			ProjectData.ClearProjectError();
		}
	}

	private void au(object A_0, EventArgs A_1)
	{
		try
		{
			base.Enabled = false;
			h8().Cursor = Cursors.WaitCursor;
			this.m_le.m2(this.m_lh, n().b8, aq().SelectedIndex, m(), global::iz.d(k1().Text), mp());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			h8().Cursor = Cursors.Default;
			base.Enabled = true;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonCalibrateNeon_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void at(object A_0, EventArgs A_1)
	{
		try
		{
			int selectedIndex = aq().SelectedIndex;
			int a_ = m();
			base.Enabled = false;
			jr().Cursor = Cursors.WaitCursor;
			m8 = new c1();
			this.m_le.p9(this.m_lh, n().b8, selectedIndex, a_, mu());
			aa();
			m8.a(300);
			m8.a(A_0: true);
			m8.b("Initializing...");
			if (m8.DialogResult == DialogResult.Cancel)
			{
				this.m_le.m2(this.m_lh, n().b8, selectedIndex, a_);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			h8().Cursor = Cursors.Default;
			base.Enabled = true;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonCalibrateTECSupplyPotR", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void b()
	{
		k1().Text = "0";
		@if().Text = "0";
		id().Text = "0";
		ib().Text = "0";
		k0().Enabled = false;
		this.m_le.m2(this.m_lh, n().b8, aq().SelectedIndex, m(), mq());
	}

	private void @as(object A_0, EventArgs A_1)
	{
		try
		{
			b();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonCalPeaksDelete_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ar(object A_0, EventArgs A_1)
	{
		try
		{
			base.Enabled = false;
			e3().Cursor = Cursors.WaitCursor;
			ae();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			base.Enabled = true;
			e3().Cursor = Cursors.Default;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonCheckForHubEEPROM_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void aq(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_lu = DateAndTime.Now;
			ds().Text = this.m_lu.ToString();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonConUpdateMfrDate_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ap(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				h6.c A_2 = null;
				int selectedIndex = aq().SelectedIndex;
				int selectedIndex2 = e0().SelectedIndex;
				h6.b b10 = n().b8;
				na = false;
				nb = false;
				h6.c c10 = this.m_lo[selectedIndex][selectedIndex2];
				a(ref A_2, c10.b3, c10.b, c10.b2, c10.b5, c10.b4, c10.b6);
				c10 = null;
				int num = this.m_lo[selectedIndex][selectedIndex2].g;
				if (!A_2.h && A_2.f > num)
				{
					global::fe.b(this.m_ld, "Highest allowable firmware revision level is: " + num, global::i6.a(fr()));
					return;
				}
				if (!A_2.b6 && b10 == global::h6.b.b && A_2.bm != FMLegacyAllSystemTypes.kTypeOpticalAcc)
				{
					int num2 = e0().Items.Count;
					foreach (h6.c item in this.m_lo[selectedIndex])
					{
						if (item.b6)
						{
							num2--;
						}
						else if (item.b8 == global::h6.b.c)
						{
							num2--;
						}
					}
					if (num2 != A_2.bv)
					{
						global::fe.b(this.m_ld, "The value entered for # contrlrs must match the number of controllers present in the\r\ncurrently selected subsystem (number of items displayed in the Controller combo box).", global::i6.a(fr()));
						return;
					}
					na = num2 > 1;
				}
				base.Enabled = false;
				fr().Cursor = Cursors.WaitCursor;
				a("Controller Firmware before update", this.m_lo[selectedIndex][selectedIndex2]);
				x();
				if (this.m_li)
				{
					A_2.c = a(this.m_ld, this, A_2.a, A_3: false, global::i6.a(this));
				}
				this.m_le.m2(this.m_lg, A_2, b10, selectedIndex, md());
				if (na && b10 == global::h6.b.b)
				{
					int num3 = e0().Items.Count - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						if (num4 != selectedIndex2 && this.m_lo[selectedIndex][num4].b2 && this.m_lo[selectedIndex][num4].b8 == global::h6.b.b)
						{
							h6.c A_3 = new h6.c();
							this.m_lo[selectedIndex][num4].dg(ref A_3);
							A_3.dg(A_2);
							A_3.c = A_2.c;
							a("Other Controller Firmware before update", this.m_lo[selectedIndex][num4]);
							this.m_le.m2(this.m_lg, A_3, global::h6.b.b, selectedIndex, md());
						}
					}
				}
				m4 = true;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonConWriteFW_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ao(object A_0, EventArgs A_1)
	{
		try
		{
			base.Enabled = false;
			Cursor = Cursors.WaitCursor;
			ip.m m2 = new ip.m();
			((ip.h)m2).a = aq().SelectedIndex;
			m2.b = m();
			m2.c = n().b8;
			if (A_0 == cr())
			{
				m2.x = global::ip.m.a.a;
			}
			else
			{
				m2.x = global::ip.m.a.b;
			}
			this.m_le.m2(this.m_lh, m2, global::r.d.a.b.a, mi());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonMeasLinV2T1_Click", a_);
			base.Enabled = true;
			Cursor = Cursors.Default;
			ProjectData.ClearProjectError();
		}
	}

	private void an(object A_0, EventArgs A_1)
	{
		try
		{
			base.Enabled = false;
			Cursor = Cursors.WaitCursor;
			bool flag = (nc = g5().SelectedTab == jg());
			ip.i i10 = new ip.i();
			i10.f = flag;
			if (flag)
			{
				p();
				d(i10.d);
				a(ref i10.e);
			}
			else
			{
				a(ref i10.e);
			}
			i10.a = aq().SelectedIndex;
			i10.b = m();
			i10.c = n().b8;
			if (flag)
			{
				if (Interaction.MsgBox("Insert fiber from the LED source into the Spectrometer Input. Click OK to Continue.", MsgBoxStyle.OkCancel) == MsgBoxResult.Cancel)
				{
					global::fe.b(this.m_ld, "Operation canceled", global::i6.a(bl()));
					base.Enabled = true;
					Cursor = Cursors.Default;
					return;
				}
				m8 = new c1();
			}
			this.m_le.m2(this.m_lh, i10, flag, A_3: false, global::r.d.a.b.a, mg(), m7);
			if (flag)
			{
				lock (m7)
				{
					m7.a = false;
				}
				m8.a(100);
				m8.a(A_0: true);
				m8.b("Initializing...");
				lock (m7)
				{
					m7.a = true;
					return;
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonMeasureDCScatter_Click", a_);
			base.Enabled = true;
			Cursor = Cursors.Default;
			ProjectData.ClearProjectError();
		}
	}

	private void am(object A_0, EventArgs A_1)
	{
		try
		{
			@in.b A_2 = null;
			int selectedIndex = f0().SelectedIndex;
			a(ref A_2);
			int num = this.m_lq[selectedIndex].g;
			if (!A_2.h && A_2.f > num)
			{
				global::fe.b(this.m_ld, "Highest allowable firmware revision level is: " + num, global::i6.a(fz()));
				return;
			}
			base.Enabled = false;
			fz().Cursor = Cursors.WaitCursor;
			a("Photodiode firmware settings before update", this.m_lq[selectedIndex]);
			this.m_le.m2(this.m_lg, A_2, selectedIndex, mf());
			m4 = true;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonPhotodiodeWriteFW_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void al(object A_0, EventArgs A_1)
	{
		try
		{
			ip.d A_2 = null;
			int selectedIndex = aq().SelectedIndex;
			int num = m();
			bool flag = this.m_ln[selectedIndex][num].s;
			bool A_3 = default(bool);
			a(ref A_2, ref A_3);
			if (A_3)
			{
				return;
			}
			if (flag && a(A_2.da))
			{
				a(A_2.da, global::i6.a(bb()));
				return;
			}
			if (m3 != null)
			{
				A_2.cu.l = m3;
			}
			A_2.c8 = g5().SelectedTab == jg();
			int num2 = this.m_ll[selectedIndex][num].g;
			if (!A_2.h && A_2.f > num2)
			{
				global::fe.b(this.m_ld, "Highest allowable firmware revision level is: " + num2, global::i6.a(bb()));
				return;
			}
			base.Enabled = false;
			bb().Cursor = Cursors.WaitCursor;
			x();
			if (this.m_li)
			{
				A_2.c = a(this.m_ld, this, n().a, A_3: false, global::i6.a(this));
			}
			a("Wavelength calibration firmware settings before update", this.m_lm[selectedIndex][num]);
			this.m_le.m2(this.m_lg, A_2, n().b8, selectedIndex, num, me());
			m4 = true;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonUpdate_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ak(object A_0, EventArgs A_1)
	{
		try
		{
			if (!global::fe.b(ref this.m_ld, "This operation will not execute the full LED scatter calibration but will only\r\n optimize the LED efficiency and offset coefficients. The full LED scatter calibration\r\n can be executed by clicking the Measure button.\r\n\r\nClick OK to continue with the efficiency and offset optimization or\r\nClick Cancel to return to the main firmware settings dialog", "Information", "OKString", "CancelString", global::i6.a(this)))
			{
				return;
			}
			base.Enabled = false;
			Cursor = Cursors.WaitCursor;
			nc = false;
			ip.i i10 = new ip.i();
			d(i10.d);
			a(ref i10.e);
			i10.a = aq().SelectedIndex;
			i10.b = m();
			i10.c = n().b8;
			m8 = new c1();
			lock (m7)
			{
				m7.a = false;
			}
			m8.a(100);
			m8.a(A_0: true);
			jy().Start();
			this.m_le.m2(this.m_lh, i10, A_2: true, A_3: true, global::r.d.a.b.a, mg(), m7);
			m8.b("Initializing...");
			lock (m7)
			{
				m7.a = true;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			jy().Stop();
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonOptimizeLEDEfficiencyAndOffset_Click", a_);
			base.Enabled = true;
			Cursor = Cursors.Default;
			ProjectData.ClearProjectError();
		}
	}

	private void aj(object A_0, EventArgs A_1)
	{
		w();
	}

	private void ai(object A_0, EventArgs A_1)
	{
		try
		{
			base.Enabled = false;
			e3().Cursor = Cursors.WaitCursor;
			af();
			ae();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			base.Enabled = true;
			e3().Cursor = Cursors.Default;
			m5 = false;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonWriteHubEEPROM_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ah(object A_0, EventArgs A_1)
	{
		try
		{
			b(aj());
			if (!ah() && aw().Checked)
			{
				ko().Checked = true;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.CheckBoxRestrictWavelengthRange_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ag(object A_0, EventArgs A_1)
	{
		try
		{
			c(n().e);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.CheckBoxHasZStage_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void af(object A_0, EventArgs A_1)
	{
		kq().Checked = !kr().Checked;
	}

	private void ae(object A_0, EventArgs A_1)
	{
		kr().Checked = !kq().Checked;
	}

	private void ad(object A_0, EventArgs A_1)
	{
		try
		{
			if (ah() || m0())
			{
				return;
			}
			if (eh().Checked)
			{
				if (!dy().Checked)
				{
					ac();
					try
					{
						dy().Checked = true;
						global::fe.b(this.m_ld, "Current system type does not allow LayerAttr without FFT.\r\nFFT checkbox has been automatically checked.", "Information", global::i6.a(eh()));
						return;
					}
					finally
					{
						ad();
					}
				}
			}
			else if (dy().Checked)
			{
				dy().Checked = false;
				global::fe.b(this.m_ld, "Current system type does not allow LayerAttr without FFT.\r\nFFT checkbox has been automatically unchecked.", "Information", global::i6.a(eh()));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Exception in DialogFirmwareSetting.CheckBoxLayerAttr_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ac(object A_0, EventArgs A_1)
	{
		try
		{
			if (!ah() && eh().Checked && !dy().Checked && !m0())
			{
				ac();
				try
				{
					eh().Checked = false;
					global::fe.b(this.m_ld, "Current system type does not allow LayerAttr without FFT.\r\nLayerAttr checkbox has been automatically unchecked.", "Information", global::i6.a(eh()));
					return;
				}
				finally
				{
					ad();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Exception in DialogFirmwareSetting.CheckBoxFFT_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ab(object A_0, EventArgs A_1)
	{
		try
		{
			a(aj(), bq(), bs(), this.m_ll[aq().SelectedIndex][m()].g);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.CheckBoxUpdateRevLevel_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void aa(object A_0, EventArgs A_1)
	{
		try
		{
			a(ai(), ge(), gd(), this.m_lq[f0().SelectedIndex].g);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.CheckBoxPhotodiodeUpdateRev_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void z(object A_0, EventArgs A_1)
	{
		try
		{
			a a10 = (a)ax().SelectedItem;
			if (!a10.d)
			{
				at().Text = a10.b;
				@as().Text = a10.c;
			}
			a10 = null;
			b(aj());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ComboBoxWavelengthRange_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void y(object A_0, EventArgs A_1)
	{
		try
		{
			bool visible = ((iz.a)dg().Items[dg().SelectedIndex]).b == 5;
			iu().Visible = visible;
			it().Visible = visible;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ComboBoxConRefMat_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void x(object A_0, EventArgs A_1)
	{
		try
		{
			if (ah())
			{
				return;
			}
			if (h5().Checked && j())
			{
				FMOpticConfigEnums fMOpticConfigEnums = (FMOpticConfigEnums)((iz.a)el().SelectedItem).b;
				if (fMOpticConfigEnums == FMOpticConfigEnums.kFMOpticConfigCP || fMOpticConfigEnums == FMOpticConfigEnums.kFMOpticConfigCPAutoBase || fMOpticConfigEnums == FMOpticConfigEnums.kFMOpticConfigCS || fMOpticConfigEnums == FMOpticConfigEnums.kFMOpticConfigCSAutoBase)
				{
					kx().Checked = true;
				}
				else
				{
					kx().Checked = false;
				}
			}
			else
			{
				kx().Checked = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ComboBoxConOpticsConfig_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void w(object A_0, EventArgs A_1)
	{
		try
		{
			FMLegacyAllSystemTypes fMLegacyAllSystemTypes = (FMLegacyAllSystemTypes)((iz.a)dp().SelectedItem).b;
			int num = ((iz.a)dl().SelectedItem).b;
			if (fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeF37)
			{
				ei().Text = "(0-6)";
				ej().Enabled = true;
			}
			else if (fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeF32)
			{
				ei().Text = "(0-3)";
				ej().Enabled = true;
			}
			else if (fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeF10)
			{
				switch (num)
				{
				case 3:
				case 6:
					ei().Text = "(0-1)";
					ej().Enabled = true;
					break;
				case 8:
					ei().Text = "(0-2)";
					ej().Enabled = true;
					break;
				default:
					ei().Text = "(0-0)";
					ej().Enabled = false;
					break;
				}
			}
			else if (fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypePARTS)
			{
				ei().Text = "(0-2)";
				ej().Enabled = true;
			}
			else if (fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeF2)
			{
				ei().Text = "(0-1)";
				ej().Enabled = true;
			}
			else if (fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeF50_300B && num == 4)
			{
				ei().Text = "(0-1)";
				ej().Enabled = true;
			}
			else
			{
				ei().Text = "(0-0)";
				ej().Enabled = false;
			}
			if (ah())
			{
				return;
			}
			global::iz.b(df(), 1);
			global::iz.b(dg(), 1);
			global::iz.b(el(), 1);
			ej().Text = "0";
			ac();
			try
			{
				switch (fMLegacyAllSystemTypes)
				{
				case FMLegacyAllSystemTypes.kTypeF10:
					ag();
					switch ((FMF10Subtypes)num)
					{
					case FMF10Subtypes.kFMF10SubtypeAR:
						global::iz.b(df(), 3);
						global::iz.b(dg(), 2);
						global::iz.b(el(), 4);
						ea().Checked = true;
						d7().Checked = true;
						l7().Checked = false;
						break;
					case FMF10Subtypes.kFMF10SubtypePA:
						global::iz.b(df(), 1);
						global::iz.b(dg(), 2);
						global::iz.b(el(), 6);
						dy().Checked = true;
						break;
					case FMF10Subtypes.kFMF10SubtypeVC:
						global::iz.b(df(), 1);
						global::iz.b(dg(), 3);
						global::iz.b(el(), 1);
						d7().Checked = true;
						ea().Checked = true;
						ff().Text = "2";
						break;
					case FMF10Subtypes.kFMF10SubtypeRT:
						global::iz.b(df(), 1);
						global::iz.b(dg(), 3);
						global::iz.b(el(), 1);
						d7().Checked = true;
						ea().Checked = true;
						ff().Text = "2";
						break;
					case FMF10Subtypes.kFMF10SubtypeHC:
						global::iz.b(df(), 1);
						global::iz.b(dg(), 2);
						global::iz.b(el(), 4);
						eh().Checked = true;
						dy().Checked = true;
						ee().Checked = true;
						l7().Checked = false;
						break;
					case FMF10Subtypes.kFMF10SubtypePV:
						global::iz.b(df(), 1);
						global::iz.b(dg(), 2);
						global::iz.b(el(), 1);
						eh().Checked = true;
						dy().Checked = true;
						ee().Checked = true;
						break;
					case FMF10Subtypes.kFMF10SubtypeARc:
						global::iz.b(df(), 3);
						global::iz.b(dg(), 2);
						h5().Checked = true;
						global::iz.b(el(), 4);
						ea().Checked = true;
						d7().Checked = true;
						ik().Checked = true;
						break;
					case FMF10Subtypes.kFMF10SubtypeRTA:
						global::iz.b(df(), 1);
						global::iz.b(dg(), 2);
						global::iz.b(el(), 1);
						eh().Checked = true;
						dy().Checked = true;
						ee().Checked = true;
						ff().Text = "3";
						break;
					default:
						l7().Checked = false;
						break;
					}
					break;
				case FMLegacyAllSystemTypes.kTypeF20:
				{
					ag();
					eh().Checked = true;
					dy().Checked = true;
					if (num == 2)
					{
						eo().Checked = true;
					}
					else
					{
						ee().Checked = true;
					}
					FMF20Subtypes fMF20Subtypes = (FMF20Subtypes)num;
					if (fMF20Subtypes == FMF20Subtypes.kFMF20SubtypeHC)
					{
						global::iz.b(df(), 1);
						global::iz.b(dg(), 2);
						global::iz.b(el(), 4);
					}
					else
					{
						global::iz.b(df(), 1);
						global::iz.b(dg(), 1);
						global::iz.b(el(), 1);
					}
					break;
				}
				case FMLegacyAllSystemTypes.kTypeF37:
				case FMLegacyAllSystemTypes.kTypeF32:
					ag();
					eh().Checked = true;
					dy().Checked = true;
					ee().Checked = true;
					global::iz.b(df(), 1);
					global::iz.b(dg(), 2);
					global::iz.b(el(), 1);
					if (fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeF32)
					{
						ff().Text = "4";
					}
					else
					{
						ff().Text = "7";
					}
					break;
				case FMLegacyAllSystemTypes.kTypeF40:
				case FMLegacyAllSystemTypes.kTypeF40NSR:
					ag();
					ih().Checked = true;
					kq().Checked = true;
					eh().Checked = true;
					dy().Checked = true;
					ee().Checked = true;
					global::iz.b(df(), 1);
					global::iz.b(dg(), 1);
					global::iz.b(el(), 7);
					break;
				case FMLegacyAllSystemTypes.kTypePARTS:
					ag();
					global::iz.b(df(), 1);
					global::iz.b(dg(), 2);
					global::iz.b(el(), 1);
					eh().Checked = true;
					dy().Checked = true;
					ee().Checked = true;
					ff().Text = "3";
					break;
				case FMLegacyAllSystemTypes.kTypeF70:
					ag();
					fw().Checked = true;
					global::iz.b(df(), 1);
					global::iz.b(dg(), 2);
					global::iz.b(el(), 9);
					break;
				case FMLegacyAllSystemTypes.kTypeF2:
					ag();
					global::iz.b(df(), 1);
					global::iz.b(dg(), 5);
					global::iz.b(el(), 1);
					d7().Checked = true;
					ea().Checked = true;
					ik().Checked = true;
					iq().Checked = n().ap;
					ff().Text = "2";
					break;
				case FMLegacyAllSystemTypes.kTypeF3:
				{
					ag();
					i7.a a10 = (i7.a)num;
					if (a10 == global::i7.a.d)
					{
						ih().Checked = true;
						kq().Checked = true;
					}
					else
					{
						global::iz.b(df(), 3);
						global::iz.b(dg(), 2);
					}
					h5().Checked = true;
					switch (a10)
					{
					case global::i7.a.b:
						global::iz.b(el(), 4);
						break;
					case global::i7.a.c:
						global::iz.b(el(), 6);
						break;
					}
					ik().Checked = !k();
					break;
				}
				case FMLegacyAllSystemTypes.kTypeF50_300B:
					ag();
					eh().Checked = true;
					dy().Checked = true;
					ee().Checked = true;
					global::iz.b(df(), 1);
					if (string.IsNullOrEmpty(h2().Text) || Operators.CompareString(h2().Text, "0", TextCompare: false) == 0)
					{
						h2().Text = no;
					}
					kr().Checked = true;
					switch ((FMF50Subtypes)num)
					{
					case FMF50Subtypes.kFMF50SubtypeF54:
						g(A_0: true);
						e(A_0: false);
						global::iz.b(dg(), 1);
						global::iz.b(el(), 7);
						ih().Checked = true;
						break;
					case FMF50Subtypes.kFMF50SubtypeF57:
						g(A_0: true);
						e(A_0: false);
						ag();
						fw().Checked = true;
						global::iz.b(dg(), 2);
						global::iz.b(el(), 9);
						ih().Checked = true;
						break;
					case FMF50Subtypes.kFMF50SubtypeF50sX:
						g(A_0: true);
						e(A_0: false);
						h5().Checked = true;
						ih().Checked = true;
						ik().Checked = !k();
						break;
					case FMF50Subtypes.kFMF50SubtypeF50XYRT_300:
						g(A_0: false);
						e(A_0: true);
						l2().Checked = true;
						ea().Checked = true;
						d7().Checked = true;
						break;
					default:
						g(A_0: true);
						e(A_0: false);
						break;
					}
					lx().SelectedIndex = 1;
					break;
				case FMLegacyAllSystemTypes.kTypeF60:
					ag();
					eh().Checked = true;
					dy().Checked = true;
					ee().Checked = true;
					g(A_0: true);
					f(A_0: true);
					kv().Checked = true;
					global::iz.b(dg(), 1);
					if (string.IsNullOrEmpty(h2().Text) || Operators.CompareString(h2().Text, "0", TextCompare: false) == 0)
					{
						h2().Text = no;
					}
					kr().Checked = true;
					switch ((FMF60Subtypes)num)
					{
					case FMF60Subtypes.kFMF60SubtypeF64t:
					case FMF60Subtypes.kFMF60SubtypeF64c:
						global::iz.b(el(), 7);
						ih().Checked = false;
						j0().Checked = true;
						ku().Checked = true;
						d9().Checked = true;
						lj().Checked = true;
						li().Checked = true;
						ls().Checked = true;
						lr().Checked = true;
						lu().Checked = true;
						break;
					case FMF60Subtypes.kFMF60SubtypeF60t:
					case FMF60Subtypes.kFMF60SubtypeF60c:
						ih().Checked = false;
						j0().Checked = false;
						ku().Checked = false;
						d9().Checked = false;
						lj().Checked = false;
						li().Checked = false;
						ls().Checked = false;
						lr().Checked = false;
						lu().Checked = true;
						break;
					}
					break;
				case FMLegacyAllSystemTypes.kTypeS3:
					ag();
					js().Checked = true;
					break;
				}
				if (!js().Checked && h5().Checked && (k() || (fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeF3 && num == 3) || (fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeF50_300B && num == 3)))
				{
					j1().Checked = true;
					iy().Checked = true;
				}
				int selectedIndex = aq().SelectedIndex;
				int index = m();
				if (h5().Checked && this.m_ln[selectedIndex][index].o)
				{
					lz().Checked = true;
				}
			}
			finally
			{
				ad();
			}
			f();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ComboBoxConSubType_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void v(object A_0, EventArgs A_1)
	{
		try
		{
			FMLegacyAllSystemTypes fMLegacyAllSystemTypes = (FMLegacyAllSystemTypes)((iz.a)dp().SelectedItem).b;
			if (!ah())
			{
				ag();
				ac();
				try
				{
					switch (fMLegacyAllSystemTypes)
					{
					case FMLegacyAllSystemTypes.kTypeF30:
						eh().Checked = true;
						eg().Checked = true;
						ef().Checked = true;
						dy().Checked = true;
						ee().Checked = true;
						break;
					case FMLegacyAllSystemTypes.kTypeF20_F40:
						eh().Checked = true;
						dy().Checked = true;
						ee().Checked = true;
						d9().Checked = true;
						break;
					case FMLegacyAllSystemTypes.kTypeF42:
					case FMLegacyAllSystemTypes.kTypeF42Oxford:
						eh().Checked = true;
						break;
					case FMLegacyAllSystemTypes.kTypeF50_200:
					case FMLegacyAllSystemTypes.kTypeF50_300:
					case FMLegacyAllSystemTypes.kTypeF50XY_450:
					case FMLegacyAllSystemTypes.kTypeF50XY_200:
					case FMLegacyAllSystemTypes.kTypeF50_200B:
					case FMLegacyAllSystemTypes.kTypeF50_300B:
					case FMLegacyAllSystemTypes.kTypeF50_450B:
					case FMLegacyAllSystemTypes.kTypeF50XY_510:
					case FMLegacyAllSystemTypes.kTypeF50XY_10:
					case FMLegacyAllSystemTypes.kTypeF60:
						eh().Checked = true;
						dy().Checked = true;
						switch (fMLegacyAllSystemTypes)
						{
						case FMLegacyAllSystemTypes.kTypeF50_200B:
						case FMLegacyAllSystemTypes.kTypeF50_300B:
						case FMLegacyAllSystemTypes.kTypeF50_450B:
						case FMLegacyAllSystemTypes.kTypeF50XY_510:
						case FMLegacyAllSystemTypes.kTypeF50XY_10:
						case FMLegacyAllSystemTypes.kTypeF60:
							ee().Checked = true;
							break;
						}
						break;
					case FMLegacyAllSystemTypes.kTypeF2:
						h5().Checked = true;
						break;
					case FMLegacyAllSystemTypes.kTypeF80SS:
						eh().Checked = true;
						break;
					}
				}
				finally
				{
					ad();
				}
			}
			switch (fMLegacyAllSystemTypes)
			{
			case FMLegacyAllSystemTypes.kTypeF50_200:
			case FMLegacyAllSystemTypes.kTypeF50_300:
			case FMLegacyAllSystemTypes.kTypeF50_200B:
			case FMLegacyAllSystemTypes.kTypeF50_300B:
			case FMLegacyAllSystemTypes.kTypeF50_450B:
			case FMLegacyAllSystemTypes.kTypeF60:
				g(A_0: true);
				f(fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeF60);
				if (fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeF50_300B)
				{
					int selectedIndex = aq().SelectedIndex;
					int selectedIndex2 = e0().SelectedIndex;
					if (this.m_lo[selectedIndex][selectedIndex2].bo == 4)
					{
						g(A_0: false);
						e(A_0: true);
					}
					else
					{
						g(A_0: true);
						e(A_0: false);
					}
					f(A_0: false);
				}
				else
				{
					g(A_0: true);
					f(fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeF60);
				}
				break;
			case FMLegacyAllSystemTypes.kTypeF50XY_450:
			case FMLegacyAllSystemTypes.kTypeF50XY_200:
			case FMLegacyAllSystemTypes.kTypeF50XY_510:
			case FMLegacyAllSystemTypes.kTypeF50XY_10:
				e(A_0: true);
				break;
			}
			a(global::h6.e.k(fMLegacyAllSystemTypes));
			fu().Visible = fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeF50XY_510;
			if (!ah())
			{
				u();
			}
			q();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ComboBoxConSystemType_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void u(object A_0, EventArgs A_1)
	{
		try
		{
			if (ah())
			{
				return;
			}
			bool flag = dm().SelectedItem != null && ((iz.a)dm().SelectedItem).b == 3;
			bool flag2 = dp().SelectedItem != null && ((iz.a)dp().SelectedItem).b == 38;
			if (flag != flag2)
			{
				ac();
				try
				{
					if (flag)
					{
						global::iz.b(dp(), 38);
					}
					else
					{
						global::iz.b(dp(), 33);
					}
				}
				finally
				{
					ad();
				}
			}
			if (dp().SelectedItem != null && ((iz.a)dp().SelectedItem).b == 38)
			{
				global::iz.a(dm(), 3);
				_ = 0;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ComboBoxConOem_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void t(object A_0, EventArgs A_1)
	{
		try
		{
			z();
			m1();
			ae();
			a(aq().SelectedIndex);
			if (n().ap)
			{
				ab();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ComboBoxController_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void s(object A_0, EventArgs A_1)
	{
		try
		{
			i();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ComboBoxSpectrometer_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void r(object A_0, EventArgs A_1)
	{
		try
		{
			d();
			d(A_0: true);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ComboBoxMemBlockSpectrometers_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(int A_0)
	{
		string right = this.m_lo[A_0][e0().SelectedIndex].b;
		ComboBox comboBox = bm();
		comboBox.Items.Clear();
		checked
		{
			int num = this.m_ll[aq().SelectedIndex].Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				ip.e e10 = this.m_ln[A_0][num2];
				if (Operators.CompareString(e10.t, right, TextCompare: false) == 0)
				{
					comboBox.Items.Add(e10.a + e10.b);
				}
			}
			if (this.m_lj)
			{
				if (comboBox.Items.Count > 0)
				{
					TabControl.TabPageCollection tabPages = ao().TabPages;
					if (!tabPages.Contains(ba()))
					{
						tabPages.Insert(1, ba());
					}
					tabPages = null;
					comboBox.SelectedIndex = 0;
				}
				else
				{
					TabControl.TabPageCollection tabPages2 = ao().TabPages;
					if (tabPages2.Contains(ba()))
					{
						tabPages2.Remove(ba());
					}
					tabPages2 = null;
				}
			}
			else
			{
				TabControl.TabPageCollection tabPages3 = ao().TabPages;
				if (tabPages3.Contains(ba()))
				{
					tabPages3.Remove(ba());
				}
				tabPages3 = null;
			}
			comboBox = null;
			ComboBox comboBox2 = gk();
			comboBox2.Items.Clear();
			int num3 = this.m_ll[aq().SelectedIndex].Count - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				ip.e e10 = this.m_ln[A_0][num4];
				if (Operators.CompareString(e10.t, right, TextCompare: false) == 0)
				{
					comboBox2.Items.Add(e10.a + e10.b);
				}
			}
			if (this.m_lj)
			{
				if (comboBox2.Items.Count > 0)
				{
					TabControl.TabPageCollection tabPages4 = ao().TabPages;
					if (!tabPages4.Contains(gg()))
					{
						tabPages4.Insert(1, gg());
					}
					tabPages4 = null;
					comboBox2.SelectedIndex = 0;
				}
				else
				{
					TabControl.TabPageCollection tabPages5 = ao().TabPages;
					if (tabPages5.Contains(gg()))
					{
						tabPages5.Remove(gg());
					}
					tabPages5 = null;
				}
			}
			else
			{
				TabControl.TabPageCollection tabPages6 = ao().TabPages;
				if (tabPages6.Contains(gg()))
				{
					tabPages6.Remove(gg());
				}
				tabPages6 = null;
			}
			comboBox2 = null;
		}
	}

	private void q(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				int selectedIndex = aq().SelectedIndex;
				ComboBox comboBox = e0();
				comboBox.Items.Clear();
				int num = this.m_lo[selectedIndex].Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					string text = this.m_lp[selectedIndex][num2].a;
					h6.c c10 = this.m_lo[selectedIndex][num2];
					if (this.m_lo[selectedIndex].Count > 1)
					{
						if (c10.b6)
						{
							text = text + " (" + global::h6.p9(c10.bm) + ")";
						}
						else
						{
							foreach (ip.e item in this.m_ln[selectedIndex])
							{
								if (Operators.CompareString(item.t, c10.b, TextCompare: false) == 0)
								{
									text = ((c10.b8 != global::h6.b.c) ? (text + " (" + item.a + item.b + ")") : (text + " (Notch/Flat Find)"));
								}
							}
						}
					}
					comboBox.Items.Add(text);
				}
				bool flag = comboBox.Items.Count > 0;
				ao().Visible = flag;
				iw().Visible = !flag;
				if (flag)
				{
					comboBox.SelectedIndex = 0;
				}
				comboBox = null;
				ComboBox comboBox2 = f0();
				comboBox2.Items.Clear();
				int num3 = this.m_lq.Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					comboBox2.Items.Add(this.m_lr[num4].a);
				}
				if (this.m_lj)
				{
					if (comboBox2.Items.Count > 0)
					{
						TabControl.TabPageCollection tabPages = ao().TabPages;
						if (!tabPages.Contains(fx()))
						{
							tabPages.Add(fx());
						}
						tabPages = null;
						comboBox2.SelectedIndex = 0;
					}
					else
					{
						TabControl.TabPageCollection tabPages2 = ao().TabPages;
						if (tabPages2.Contains(fx()))
						{
							tabPages2.Remove(fx());
						}
						tabPages2 = null;
					}
				}
				else
				{
					TabControl.TabPageCollection tabPages3 = ao().TabPages;
					if (tabPages3.Contains(fx()))
					{
						tabPages3.Remove(fx());
					}
					tabPages3 = null;
				}
				comboBox2 = null;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ComboBoxSubModule_SelectedIndexChanged", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void p(object A_0, EventArgs A_1)
	{
		try
		{
			int num = checked(g4().SelectedIndex + 1);
			gy().Visible = num > 1;
			gx().Visible = num > 2;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.ComboBoxPDNumPDs_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		try
		{
			c();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ComboBoxPhotodiode_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void n(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_le.sj(this.m_lh, n().b8, aq().SelectedIndex, l(), mo());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonClearExistingMemBlocks_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void m(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				this.m_le.t0(this.m_lg).dh().a8();
				int num = 0;
				openFileDialog.Filter = "Filmetrics CTM Files (*.fictm)|*.fictm";
				openFileDialog.Multiselect = true;
				openFileDialog.InitialDirectory = global::i3.d(global::i3.o() + "\\Optics\\");
				if (openFileDialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				string empty = string.Empty;
				string[] fileNames = openFileDialog.FileNames;
				foreach (string text in fileNames)
				{
					cf cf2 = new cf();
					string A_2 = string.Empty;
					if (cf2.l(text, ref A_2) == global::cf.b.a && cf2.w().a9())
					{
						int num3 = this.m_lx.Count - 1;
						for (int num4 = 0; num4 <= num3; num4++)
						{
							if (!global::cf.m(this.m_lx[num4], cf2))
							{
								this.m_lx.RemoveAt(num4);
								gi().Items.RemoveAt(num4);
								break;
							}
						}
						this.m_lx.Add(cf2);
						empty = num.ToString("0") + ": " + global::ia.h(global::h8.c) + ", " + cf2.n() + ", " + cf2.s().ToString();
						gi().Items.Add(empty);
						num++;
						d(A_0: true);
					}
					else if (!string.IsNullOrEmpty(A_2))
					{
						this.m_ld.c(global::fz.b.a, "\"" + text + "\": " + A_2);
						global::fe.b(this.m_ld, "Unable to write " + text + ". A newer software version is required to write this file to memory.", "Outdated software version", global::i6.a(gq()));
					}
					else
					{
						global::fe.b(this.m_ld, "\"" + text + "\" is not compatible for writing to memory.\r\nResave using latest version or select another CTM cal file.", "Invalid CTM File", global::i6.a(gq()));
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonAddNewMemBlocks_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_lx.Clear();
			gi().Items.Clear();
			d(A_0: true);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonClearNewMemBlocks_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		try
		{
			base.Enabled = false;
			Cursor = Cursors.WaitCursor;
			b();
			ip.j j2 = new ip.j();
			j2.a = aq().SelectedIndex;
			j2.b = m();
			j2.c = n().b8;
			j2.g = (string)ix().SelectedItem;
			j2.h = iz().SelectedTab == i2();
			_ = null;
			if (jf().Checked)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				ip.e e10 = this.m_ln[j2.a][j2.b];
				bool flag = global::ip.j.ai(e10.h, j2.g);
				OpenFileDialog openFileDialog2 = openFileDialog;
				openFileDialog2.Filter = global::hr.af(A_0: false);
				openFileDialog2.Multiselect = false;
				openFileDialog2.InitialDirectory = global::i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
				if (flag)
				{
					openFileDialog2.Title = "Short integration time spectrum";
				}
				if (openFileDialog2.ShowDialog() != DialogResult.OK)
				{
					base.Enabled = true;
					Cursor = Cursors.Default;
					return;
				}
				global::e.a().LastUsedOpenSpectrumFilter = openFileDialog2.FilterIndex;
				global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(openFileDialog2.FileName);
				j2.i = this.m_le.m2(openFileDialog2.FileName, null, null);
				if (j2.i.cr())
				{
					global::fe.b(this.m_ld, "Spectrum is saturated - cannot be used for calibration", global::i6.a(i3()));
					base.Enabled = true;
					Cursor = Cursors.Default;
					return;
				}
				if (j2.i.br()[0].aa() != e10.h)
				{
					global::fe.b(this.m_ld, "Invalid spectrometer type. You can only open spectra that are for the type of spectrometer on this tab.", global::i6.a(i3()));
					base.Enabled = true;
					Cursor = Cursors.Default;
					return;
				}
				if (flag)
				{
					new OpenFileDialog();
					openFileDialog2.Filter = global::hr.af(A_0: false);
					openFileDialog2.Multiselect = false;
					openFileDialog2.InitialDirectory = global::i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
					openFileDialog2.Title = "Long integration time spectrum";
					if (openFileDialog2.ShowDialog() != DialogResult.OK)
					{
						base.Enabled = true;
						Cursor = Cursors.Default;
						return;
					}
					global::e.a().LastUsedOpenSpectrumFilter = openFileDialog2.FilterIndex;
					global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(openFileDialog2.FileName);
					j2.j = this.m_le.m2(openFileDialog2.FileName, null, null);
					if (j2.j.br()[0].aa() != e10.h)
					{
						global::fe.b(this.m_ld, "Invalid spectrometer type. You can only open spectra that are for the type of spectrometer on this tab.", global::i6.a(i3()));
						base.Enabled = true;
						Cursor = Cursors.Default;
						return;
					}
				}
				openFileDialog2 = null;
			}
			this.m_le.m2(this.m_lh, j2, global::r.d.a.b.a, mh());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			base.Enabled = true;
			Cursor = Cursors.Default;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSettingButtonMeasCalibParams_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		try
		{
			int selectedIndex = aq().SelectedIndex;
			int a_ = m();
			h6.c c10 = n();
			this.m_le.m2(this.m_lh, c10.b8, selectedIndex, a_, c10, mt(), global::r.d.a.b.a);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonWriteNewMemBlocks_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		try
		{
			Cursor = Cursors.WaitCursor;
			d(A_0: false);
			this.m_le.m2(this.m_lh, n().b8, aq().SelectedIndex, gk().SelectedIndex, this.m_lx, A_5: false, mn());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonWriteNewMemBlocks_Click", a_);
			d(A_0: true);
			Cursor = Cursors.Default;
			ProjectData.ClearProjectError();
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		this.m_lt = true;
		f();
	}

	private void r(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new r.d.b(r), A_0);
				return;
			}
			bool flag = nc;
			bool flag2 = false;
			try
			{
				r.d.a a10 = A_0;
				if (a10.a != global::r.d.a.a.a)
				{
					flag = false;
					jy().Stop();
				}
				if (m8 != null && !flag)
				{
					m7.a = false;
					m8.i();
					m8.Dispose();
					m8 = null;
				}
				ip.i i10 = (ip.i)A_0.d;
				ip.g g10 = i10.e;
				flag2 = !i10.f;
				if (a10.a != global::r.d.a.a.a)
				{
					if (a10.a8() == global::r.d.a.b.a)
					{
						global::fe.b(this.m_ld, a10.b, global::i6.a(bl()), this);
					}
					return;
				}
				ip.f f10 = i10.d;
				if (g10 != null && !global::jf.e(g10.g, 0.0))
				{
					m6 = g10;
				}
				a(f10, g10);
				if (f10.l != null)
				{
					m3 = f10.l;
				}
				if (flag)
				{
					nc = false;
					ip.i i11 = new ip.i();
					i11.d = f10;
					i11.e = g10;
					i11.a = aq().SelectedIndex;
					i11.b = m();
					i11.c = n().b8;
					jy().Start();
					this.m_le.m2(this.m_lh, i11, A_2: true, A_3: true, global::r.d.a.b.a, mg(), m7);
				}
				else
				{
					jy().Stop();
					if (a10.a8() == global::r.d.a.b.a)
					{
						SystemSounds.Exclamation.Play();
						global::fe.b(this.m_ld, "Scatter calibration completed.", "Information", global::i6.a(bl()), this);
					}
				}
				a10 = null;
			}
			finally
			{
				if (!flag || flag2)
				{
					base.Enabled = true;
					Cursor = Cursors.Default;
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mDCScatterCompletionTask_TaskFinishedEvent", a_);
			jy().Stop();
			ProjectData.ClearProjectError();
		}
	}

	private void q(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new r.d.b(q), A_0);
				return;
			}
			try
			{
				r.d.a a10 = A_0;
				if (a10.a != global::r.d.a.a.a)
				{
					global::fe.b(this.m_ld, "Failure: " + a10.b, global::i6.a(i3()));
					return;
				}
				if (!string.IsNullOrEmpty(a10.b))
				{
					ref fz a_ = ref this.m_ld;
					string a_2 = a10.b;
					Point A_1 = global::i6.a(i3());
					global::fe.b(ref a_, a_2, ref A_1);
				}
				a10 = null;
				ip.j j2 = (ip.j)A_0.d;
				hy hy2;
				hy hy3;
				hy hy4;
				hy hy5;
				hy hy6;
				hy hy7;
				if (iz().SelectedTab == i0())
				{
					hy2 = a4();
					hy3 = a3();
					hy4 = a2();
					hy5 = lb();
					hy6 = la();
					hy7 = i4();
				}
				else
				{
					hy2 = jb();
					hy3 = je();
					hy4 = i9();
					hy5 = lf();
					hy6 = le();
					hy7 = i7();
				}
				ac();
				try
				{
					hy2.Text = j2.k.ToString();
					hy3.Text = j2.l.ToString();
					hy4.Text = j2.m.ToString();
					hy5.Text = j2.n.ToString();
					hy6.Text = j2.o.ToString();
					if (j2.p != 0f)
					{
						hy7.Text = j2.p.ToString();
					}
				}
				finally
				{
					ad();
				}
				if (iz().SelectedTab == i0() && j2.s && j2.t && this.m_my != 0f && this.m_mz != 0f)
				{
					jb().Text = (this.m_my + j2.r).ToString();
				}
				SystemSounds.Exclamation.Play();
				string text = "Wavelength calibration has been updated.\r\n";
				if (j2.s)
				{
					text = text + "Calibration shift=" + j2.q + " nm\r\n";
				}
				if (j2.t)
				{
					text = text + "Temperature change=" + Conversions.ToString(j2.u) + " deg. C";
				}
				text = text + "Peak Width at left edge of spectrum=" + j2.v + " nm\r\nPeak Width at right edge of spectrum=" + j2.w + " nm";
				global::fe.b(this.m_ld, text, "Information", global::i6.a(i3()));
				j2 = null;
			}
			finally
			{
				base.Enabled = true;
				Cursor = Cursors.Default;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mFindPeaksCompletionTask_TaskFinishedEvent", a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void p(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new r.d.b(p), A_0);
			}
			else
			{
				if (!base.IsHandleCreated)
				{
					return;
				}
				try
				{
					r.g.a a10 = (r.g.a)A_0;
					if (((r.d.a)a10).a == global::r.d.a.a.a)
					{
						im.b b10 = (im.b)a10.d;
						e7().Text = b10.a;
						e4().Enabled = b10.b;
						il().Enabled = b10.b;
						if (b10.b)
						{
							il().Items.Clear();
							foreach (object value in Enum.GetValues(typeof(im.a)))
							{
								im.a a11 = (im.a)Conversions.ToInteger(value);
								if (a11 != global::im.a.a)
								{
									il().Items.Add(global::im.a(a11));
								}
							}
							if (b10.c != global::im.a.a)
							{
								il().SelectedItem = global::im.a(b10.c);
							}
							else
							{
								il().SelectedIndex = -1;
							}
						}
					}
					else
					{
						e7().Text = "Error";
						il().Items.Clear();
						il().Enabled = false;
						e4().Enabled = false;
					}
					a10 = null;
				}
				finally
				{
					base.Enabled = true;
					e3().Cursor = Cursors.Default;
				}
				if (m5)
				{
					global::fe.b(this.m_ld, "Hub memory has been updated. Disconnect Gray/White I2C cable before continuing.", "Information", global::i6.a(e4()));
					m5 = false;
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mHubStatusUpdateTask_TaskFinishedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void o(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new r.d.b(o), A_0);
				return;
			}
			if (((r.d.a)(r.g.a)A_0).a != global::r.d.a.a.a)
			{
				this.m_ld.c(global::fz.b.b, "mUpdateScatterLEDCompletionTask failure");
			}
			_ = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mUpdateScatterLEDCompletionTask_TaskFinishedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void n(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				m5 = true;
				BeginInvoke(new r.d.b(n), A_0);
				return;
			}
			try
			{
				if (((r.d.a)(r.g.a)A_0).a != global::r.d.a.a.a)
				{
					e7().Text = "Error";
					il().Enabled = false;
					e4().Enabled = false;
				}
				_ = null;
			}
			finally
			{
				base.Enabled = true;
				e3().Cursor = Cursors.Default;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mHubWriteTask_TaskFinishedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void m(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new r.d.b(m), A_0);
				return;
			}
			try
			{
				r.d.a a10 = A_0;
				if (a10.a != global::r.d.a.a.a)
				{
					if (a10.a8() == global::r.d.a.b.a)
					{
						global::fe.b(this.m_ld, a10.b, global::i6.a(bl()));
					}
					return;
				}
				b0().Text = string.Empty;
				bz().Text = string.Empty;
				ip.m m2 = (ip.m)A_0.d;
				a(m2.x, m2.y);
				ip.e e10 = this.m_ln[aq().SelectedIndex][m()];
				if (m2.x == global::ip.m.a.a && e10.p && !e10.q)
				{
					a(global::ip.m.a.b, m2.y);
				}
				ip.d d10 = new ip.d();
				a(d10, e10);
				a(new ip.f(), new ip.g());
				bl().Enabled = false;
				a(A_0: true, m2.y.c != 0f);
				d10.cv = 2;
				b(d10, e10);
				m2 = null;
				if (a10.a8() == global::r.d.a.b.a)
				{
					SystemSounds.Exclamation.Play();
					global::fe.b(this.m_ld, "Linearity calibration successfully completed. Note: You must click Write Firmware, exit the software, and then scattered light calibration must be redone.", "Information", global::i6.a(this));
				}
				a10 = null;
			}
			finally
			{
				base.Enabled = true;
				Cursor = Cursors.Default;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mLinV2T1CompletionTask_TaskFinishedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void l(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new r.d.b(l), A_0);
				return;
			}
			try
			{
				if (A_0.a == global::r.d.a.a.a)
				{
					SystemSounds.Exclamation.Play();
					ip.n a_ = (ip.n)A_0.d;
					a(a_);
					this.m_ll[aq().SelectedIndex][m()].c6 = a_;
					global::fe.b(this.m_ld, "Neon calibration updated", "Information", global::i6.a(h8()));
				}
				else
				{
					global::fe.b(this.m_ld, "Neon calibration failed", global::i6.a(h8()));
				}
			}
			finally
			{
				base.Enabled = true;
				h8().Cursor = Cursors.Default;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mNeonCalTask_TaskFinishedEvent", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void k(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				y();
				Invoke(new r.d.b(k), A_0);
				return;
			}
			m8.i();
			try
			{
				if (A_0.a == global::r.d.a.a.a)
				{
					SystemSounds.Exclamation.Play();
					float num = Conversions.ToSingle(A_0.d);
					if (a(num))
					{
						a(num, global::i6.a(jr()));
						return;
					}
					a(A_0: true, num);
					global::fe.b(this.m_ld, "TECSupplyPotMaxR calibration updated", "Information", global::i6.a(gn()));
				}
				else
				{
					global::fe.b(this.m_ld, "TECSupplyPotMaxR calibration failed", global::i6.a(gn()));
				}
			}
			finally
			{
				base.Enabled = true;
				jr().Cursor = Cursors.Default;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mTECSupplyPotRCalTask_TaskFinishedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, ElapsedEventArgs A_1)
	{
		try
		{
			if (base.InvokeRequired)
			{
				mx().Enabled = false;
				Invoke(new ElapsedEventHandler(b), A_0, A_1);
				return;
			}
			int num = checked(m8.c().Value + 1);
			if (num > m8.c().Maximum)
			{
				num = m8.c().Maximum;
			}
			m8.b(num);
			bool A_2 = default(bool);
			float A_3 = default(float);
			float A_4 = default(float);
			bool A_5 = default(bool);
			float A_6 = default(float);
			this.m_le.m2(this.m_lh, n().b8, aq().SelectedIndex, m(), ref A_2, ref A_3, ref A_4, ref A_5, ref A_6);
			string text;
			if (A_2)
			{
				text = "DeltaT= " + A_3.ToString("0.00") + " °C, Det. T= " + A_4.ToString("0.00") + " °C";
				if (A_5)
				{
					text = text + "\r\nDet. T Slope= " + (A_6 * 2f).ToString("0.00") + " °C/min";
				}
			}
			else
			{
				text = "Waiting for initial reading...";
			}
			m8.a(text);
			mx().Enabled = true;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mTECCirCalUpdateTimer_Elapsed", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a()
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new b(a));
				return;
			}
			DateTime now = DateTime.Now;
			h6.c c10 = n();
			if (c10.aq)
			{
				now = now.AddSeconds(c10.ar);
				io().Text = now.ToString("MMM dd, yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
			}
			else
			{
				io().Text = "Unknown";
			}
			c10 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.UpdateRealTimeClockDisplayDelegate", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, ElapsedEventArgs A_1)
	{
		try
		{
			a();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mRealTimeClockTimeUpdateTimer_Elapsed", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void j(r.d.a A_0)
	{
		try
		{
			if (A_0.a == global::r.d.a.a.a)
			{
				this.m_lo[0][0].ar = 0.0;
			}
			else
			{
				this.m_ld.c(global::fz.b.b, "Error attempting to update real time clock");
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mRealTimeClockUpdateTask_TaskFinishedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void i(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new r.d.b(i), A_0);
				return;
			}
			try
			{
				r.d.a a10 = A_0;
				if (a10.a != global::r.d.a.a.a)
				{
					if (a10.a8() == global::r.d.a.b.a)
					{
						global::fe.b(this.m_ld, a10.b, global::i6.a(ct()));
					}
					return;
				}
				a(((ip.p)A_0.d).ad);
				if (a10.a8() == global::r.d.a.b.a)
				{
					SystemSounds.Exclamation.Play();
					global::fe.b(this.m_ld, "Gain calibration completed.", "Information", global::i6.a(ct()));
				}
				a10 = null;
			}
			finally
			{
				base.Enabled = true;
				Cursor = Cursors.Default;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mVGAGainCompletionTask_TaskFinishedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void h(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new r.d.b(h), A_0);
				return;
			}
			try
			{
				r.d.a a10 = A_0;
				if (a10.a != global::r.d.a.a.a)
				{
					if (a10.a8() == global::r.d.a.b.a)
					{
						global::fe.b(this.m_ld, a10.b, global::i6.a(cy()));
					}
					return;
				}
				ip.q q2 = (ip.q)A_0.d;
				a(q2.ae, q2.af, q2.ag);
				if (a10.a8() == global::r.d.a.b.a)
				{
					SystemSounds.Exclamation.Play();
					global::fe.b(this.m_ld, "Offset calibration completed.", "Information", global::i6.a(cy()));
				}
				a10 = null;
			}
			finally
			{
				base.Enabled = true;
				Cursor = Cursors.Default;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mADOffsetCompletionTask_TaskFinishedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void g(r.d.a A_0)
	{
		checked
		{
			try
			{
				if (base.InvokeRequired)
				{
					BeginInvoke(new r.d.b(g), A_0);
					return;
				}
				try
				{
					r.g.a a10 = (r.g.a)A_0;
					if (((r.d.a)a10).a == global::r.d.a.a.a)
					{
						int selectedIndex = aq().SelectedIndex;
						int selectedIndex2 = e0().SelectedIndex;
						if (!nb)
						{
							h6.c c10 = ((ce)this.m_le).p9(this.m_lh, selectedIndex)[selectedIndex2];
							a("Controller firmware settings after update", c10);
							this.m_lo[selectedIndex][selectedIndex2] = c10;
							m1();
						}
						else if (na)
						{
							int num = e0().Items.Count - 1;
							for (int num2 = 0; num2 <= num; num2++)
							{
								if (num2 != selectedIndex2 && this.m_lo[selectedIndex][num2].b2)
								{
									h6.c c10 = ((ce)this.m_le).p9(this.m_lh, selectedIndex)[num2];
									a("Other Controller firmware settings after update", c10);
									this.m_lo[selectedIndex][num2] = c10;
								}
							}
						}
					}
					if ((!na || nb) && a10.a8() == global::r.d.a.b.a)
					{
						if (((r.d.a)a10).a == global::r.d.a.a.a)
						{
							SystemSounds.Exclamation.Play();
							global::fe.b(this.m_ld, "Controller Firmware successfully updated", "Information", global::i6.a(fr()), this);
							base.DialogResult = DialogResult.OK;
							this.m_le.tf("");
							this.m_le.m2(global::r.d.a.b.a);
						}
						else
						{
							global::fe.b(this.m_ld, "Controller Firmware update procedure failed", global::i6.a(fr()));
						}
					}
					a10 = null;
				}
				finally
				{
					if (nb)
					{
						base.Enabled = true;
						fr().Cursor = Cursors.Default;
					}
					nb = true;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mWriteControllerCompletionTask_TaskFinishedEvent", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void f(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new r.d.b(f), A_0);
				return;
			}
			try
			{
				r.x.a a10 = (r.x.a)A_0;
				if (((r.d.a)a10).a == global::r.d.a.a.a)
				{
					int selectedIndex = f0().SelectedIndex;
					@in.b b10 = this.m_le.uf(this.m_lh)[selectedIndex];
					a("Photodiode firmware settings after update", b10);
					this.m_lq[selectedIndex] = b10;
					c();
				}
				if (a10.a8() == global::r.d.a.b.a)
				{
					if (((r.d.a)a10).a == global::r.d.a.a.a)
					{
						SystemSounds.Exclamation.Play();
						global::fe.b(this.m_ld, "PhotodiodeLed Firmware successfully updated", "Information", global::i6.a(fz()));
						base.DialogResult = DialogResult.OK;
						this.m_le.m2(global::r.d.a.b.a);
					}
					else
					{
						global::fe.b(this.m_ld, "PhotodiodeLed Firmware update procedure failed", global::i6.a(fz()));
					}
				}
				a10 = null;
			}
			finally
			{
				base.Enabled = true;
				fz().Cursor = Cursors.Default;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mWritePhotodiodeCompletionTask_TaskFinishedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void e(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new r.d.b(e), A_0);
				return;
			}
			try
			{
				r.g.a a10 = (r.g.a)A_0;
				if (((r.d.a)a10).a == global::r.d.a.a.a)
				{
					int selectedIndex = aq().SelectedIndex;
					int num = m();
					m6 = null;
					ip.d d10 = null;
					ip.d d11 = null;
					if (n().b8 != global::h6.b.b)
					{
						global::fe.b(this.m_ld, "Error: Unknown spectrometer type.", global::i6.a(bb()));
						return;
					}
					d10 = this.m_le.sn(this.m_lh, selectedIndex, num);
					d11 = this.m_le.sn(this.m_lh, selectedIndex, num);
					a("Wavelength calibration firmware settings after update", d10);
					this.m_ll[selectedIndex][num] = d10;
					this.m_lm[selectedIndex][num] = d11;
					i();
					float A_1 = 0f;
					int a_ = this.m_ln[selectedIndex][num].u;
					string a_2 = this.m_ln[selectedIndex][num].h.ToString();
					ip.d d12 = d10;
					global::ip.m2(d12.cg, d12.cb, d12.cc, d12.cd, d12.ce, d12.cf, d12.cm, d12.ch, d12.ci, d12.cj, d12.ck, d12.cl, d12.i, a_, "WriteFirmware", d12.a.ToString(), a_2, null, ref A_1);
					d12 = null;
				}
				if (a10.a8() == global::r.d.a.b.a)
				{
					if (((r.d.a)a10).a == global::r.d.a.a.a)
					{
						SystemSounds.Exclamation.Play();
						global::fe.b(this.m_ld, "Spectrometer Firmware successfully updated", "Information", global::i6.a(bb()));
						base.DialogResult = DialogResult.OK;
						this.m_le.m2(global::r.d.a.b.a);
					}
				}
				else
				{
					global::fe.b(this.m_ld, "Spectrometer Firmware update procedure failed", global::i6.a(bb()));
				}
				a10 = null;
			}
			finally
			{
				base.Enabled = true;
				bb().Cursor = Cursors.Default;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mWriteSpecCompletionTask_TaskFinishedEvent", a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
	}

	private void d(r.d.a A_0)
	{
	}

	private void c(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new r.d.b(c), A_0);
				return;
			}
			gl().Items.Clear();
			r.g.a a10 = (r.g.a)A_0;
			if (((r.d.a)a10).a == global::r.d.a.a.a)
			{
				this.m_lw = (Collection<ia>)a10.d;
				string empty = string.Empty;
				int num = 0;
				foreach (ia item in this.m_lw)
				{
					empty = num.ToString("0") + ": " + global::ia.h(item, A_1: true);
					gl().Items.Add(empty);
					num = checked(num + 1);
				}
			}
			else
			{
				this.m_ld.c(global::fz.b.b, "Failure reading memory blocks.", Environment.StackTrace);
				gl().Items.Add("Failure reading memory blocks!");
			}
			a10 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mReadMemBlockHeadersTask_TaskFinishedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new r.d.b(b), A_0);
				return;
			}
			r.g.a a10 = (r.g.a)A_0;
			if (((r.d.a)a10).a == global::r.d.a.a.a)
			{
				e();
			}
			if (a10.a8() == global::r.d.a.b.a)
			{
				if (((r.d.a)a10).a == global::r.d.a.a.a)
				{
					SystemSounds.Exclamation.Play();
					global::fe.b(this.m_ld, "Spectrometer memory blocks successfully cleared", "Information", global::i6.a(gn()));
				}
				else
				{
					global::fe.b(this.m_ld, "Spectrometer clear memory blocks procedure failed", global::i6.a(gn()));
				}
			}
			a10 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mClearMemBlocksTask_TaskFinishedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new r.d.b(a), A_0);
				return;
			}
			try
			{
				r.g.a a10 = (r.g.a)A_0;
				if (((r.d.a)a10).a == global::r.d.a.a.a)
				{
					d();
				}
				if (a10.a8() == global::r.d.a.b.a)
				{
					if (((r.d.a)a10).a == global::r.d.a.a.a)
					{
						SystemSounds.Exclamation.Play();
						global::fe.b(this.m_ld, "Spectrometer memory blocks successfully updated", "Information", global::i6.a(gn()));
					}
					else
					{
						global::fe.b(this.m_ld, "Spectrometer memory blocks update procedure failed", global::i6.a(gn()));
					}
				}
				a10 = null;
			}
			finally
			{
				d(A_0: true);
				Cursor = Cursors.Default;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ld.c(global::fz.b.b, "Error in DialogFirmwareSetting.mUpdateCTMCalMemBlocksTask_TaskFinishedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
		{
			if (!ah())
			{
				a(m6);
				int selectedIndex = aq().SelectedIndex;
				int index = m();
				ip.d d10 = this.m_ll[selectedIndex][index];
				if (d10.cg != 0f && d10.cb != 0f && d10.cc != 0f && d10.ch != 0f && d10.ci != 0f)
				{
					float a_ = global::iz.d(a4().Text);
					float a_2 = global::iz.d(a3().Text);
					float a_3 = global::iz.d(a2().Text);
					float a_4 = global::iz.d(lb().Text);
					float a_5 = global::iz.d(la().Text);
					int a_6 = this.m_ln[selectedIndex][index].u;
					int a_7 = ((!aw().Checked) ? global::ip.m2(d10.cb, d10.cc, d10.cd, d10.ce, d10.cf, a_6) : global::ip.m2(d10.cb, d10.cc, d10.cd, d10.ce, d10.cf, a_6, global::iz.d(at().Text), global::iz.d(@as().Text)));
					jb().Text = (d10.ch + global::ip.m2(a_7, a_, a_2, a_3, a_4, a_5, d10.cb, d10.cc, d10.cd, d10.ce, d10.cf)).ToString();
				}
				d10 = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_8 = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.TextBoxWavelenCalCoeff_TextChanged", a_8);
			ProjectData.ClearProjectError();
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			a(m6);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.TextBoxNumFirmwareRev_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			a(m6);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.TabControlScatter_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		if (j3().Checked)
		{
			if (!g5().TabPages.Contains(jg()))
			{
				g5().TabPages.Add(jg());
			}
			if (g5().TabPages.Contains(g6()))
			{
				g5().TabPages.Remove(g6());
			}
		}
		else
		{
			if (!g5().TabPages.Contains(g6()))
			{
				g5().TabPages.Add(g6());
			}
			if (g5().TabPages.Contains(jg()))
			{
				g5().TabPages.Remove(jg());
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				float num = 0f;
				lock (jy())
				{
					if (nd > 0)
					{
						if (ne > 0)
						{
							float num2 = (float)(100.0 / (double)nd);
							float num3 = (float)DateAndTime.Now.Subtract(ng).TotalSeconds;
							num = num2 * (float)(ne - 1) + num2 * (1f - (float)Math.Exp(-Math.PI * (double)num3 / (double)nf));
						}
						m8.c().Value = (int)Math.Round(num);
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				this.m_ld.c(global::fz.b.b, "Error encountered in DialogFirmwareSetting.TimerScatterProgress_Tick. Error is: " + ex3.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			string A_2 = "0";
			int index = m();
			int selectedIndex = aq().SelectedIndex;
			if (global::fe.b(this.m_ld, "Enter amount to shift wavelengths in nm\r\n(base offset = " + Conversions.ToString(this.m_ll[selectedIndex][index].cb) + " nm)", "WavelengthShift", global::i6.a(l8()), ref A_2))
			{
				float num = global::iz.d(A_2);
				ip.d d10 = this.m_ll[selectedIndex][index];
				a4().Text = (d10.cb + num).ToString();
				if (d10.c6.ab != 0f && d10.c6.ac != 0f)
				{
					k1().Text = (d10.c6.aa + d10.c6.z - num).ToString();
					@if().Text = "0";
				}
				d10 = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			global::i5.a(this.m_ld, this.m_le, this.m_lf, global::i6.a(this), "DialogFirmwareSetting.ButtonShiftWavelengths_Click", a_);
			ProjectData.ClearProjectError();
		}
	}
}
