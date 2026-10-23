using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using FIUsbIntLib;
using Filmetrics.FIMatFileDBService;
using Filmetrics.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;

[DesignerGenerated]
internal class gg : Form
{
	private class a
	{
		public long a;

		public long b;

		public long c;

		public b2 d;
	}

	internal class b
	{
		private f1 a;

		private global::r.d m_b;

		private hd c;

		public b(f1 A_0, global::r.d A_1, hd A_2)
		{
			a = A_0;
			m_b = A_1;
			c = A_2;
		}

		[SpecialName]
		public f1 d()
		{
			return a;
		}

		[SpecialName]
		public global::r.d e()
		{
			return m_b;
		}

		[SpecialName]
		public hd f()
		{
			return c;
		}
	}

	public class c
	{
		public delegate void a();

		[CompilerGenerated]
		private a m_a;

		[SpecialName]
		[CompilerGenerated]
		public void b(a A_0)
		{
			a a10 = this.m_a;
			a a11;
			do
			{
				a11 = a10;
				a value = (a)Delegate.Combine(a11, A_0);
				a10 = Interlocked.CompareExchange(ref this.m_a, value, a11);
			}
			while ((object)a10 != a11);
		}

		[SpecialName]
		[CompilerGenerated]
		public void c(a A_0)
		{
			a a10 = this.m_a;
			a a11;
			do
			{
				a11 = a10;
				a value = (a)Delegate.Remove(a11, A_0);
				a10 = Interlocked.CompareExchange(ref this.m_a, value, a11);
			}
			while ((object)a10 != a11);
		}

		public void b()
		{
			this.m_a?.Invoke();
		}
	}

	public delegate void d(b A_0, bool A_1, string A_2, gr A_3);

	private delegate void e(string A_0);

	private delegate void f(Guid A_0);

	public delegate void g(object A_0, ElapsedEventArgs A_1);

	public delegate void h(FormClosingEventArgs A_0);

	private delegate void i(ReadOnlyCollection<string> A_0, ix.b A_1, ix.b A_2, ix.b A_3);

	private delegate Guid j(ix.b A_0);

	private delegate Guid k(ix.b A_0);

	private delegate bool l();

	private delegate bool m();

	private delegate bool n();

	private delegate f4 o(Guid A_0);

	private delegate f4 p();

	private delegate f3 q();

	private delegate bool r();

	public delegate void s(object A_0, ElapsedEventArgs A_1);

	private delegate void t(string A_0, string A_1, string A_2, bool A_3);

	private IContainer m_a;

	[CompilerGenerated]
	private MenuStrip m_b;

	[CompilerGenerated]
	private ToolStripMenuItem m_c;

	[CompilerGenerated]
	private ToolStripMenuItem m_d;

	[CompilerGenerated]
	private ToolStripMenuItem m_e;

	[CompilerGenerated]
	private ToolStripMenuItem m_f;

	[CompilerGenerated]
	private ToolStripMenuItem m_g;

	[CompilerGenerated]
	private fw m_h;

	[CompilerGenerated]
	private ImageList m_i;

	[CompilerGenerated]
	private ToolStripMenuItem m_j;

	[CompilerGenerated]
	private ToolStripMenuItem m_k;

	[CompilerGenerated]
	private ToolStripMenuItem m_l;

	[CompilerGenerated]
	private ToolStripMenuItem m_m;

	[CompilerGenerated]
	private ToolStripMenuItem m_n;

	[CompilerGenerated]
	private ToolStripMenuItem m_o;

	[CompilerGenerated]
	private ToolStripMenuItem m_p;

	[CompilerGenerated]
	private ToolStripMenuItem m_q;

	[CompilerGenerated]
	private ToolStripSeparator m_r;

	[CompilerGenerated]
	private ToolStripMenuItem m_s;

	[CompilerGenerated]
	private ToolStripMenuItem m_t;

	[CompilerGenerated]
	private PrintDocument m_u;

	[CompilerGenerated]
	private PageSetupDialog m_v;

	[CompilerGenerated]
	private PrintDialog m_w;

	[CompilerGenerated]
	private ToolStripMenuItem m_x;

	[CompilerGenerated]
	private ToolStripMenuItem m_y;

	[CompilerGenerated]
	private ToolStripMenuItem m_z;

	[CompilerGenerated]
	private ToolStripMenuItem m_aa;

	[CompilerGenerated]
	private ToolStripMenuItem m_ab;

	[CompilerGenerated]
	private ToolStripMenuItem m_ac;

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
	private ToolStripMenuItem m_aj;

	[CompilerGenerated]
	private ToolStripMenuItem m_ak;

	[CompilerGenerated]
	private ToolStripMenuItem m_al;

	[CompilerGenerated]
	private ToolStripMenuItem m_am;

	[CompilerGenerated]
	private ToolStripMenuItem m_an;

	[CompilerGenerated]
	private ToolStripMenuItem m_ao;

	[CompilerGenerated]
	private ToolStripSeparator m_ap;

	[CompilerGenerated]
	private ToolStripSeparator m_aq;

	[CompilerGenerated]
	private ToolStripMenuItem m_ar;

	[CompilerGenerated]
	private ToolStrip m_as;

	[CompilerGenerated]
	private ToolStripButton m_at;

	[CompilerGenerated]
	private ToolStripButton m_au;

	[CompilerGenerated]
	private ToolStripSeparator m_av;

	[CompilerGenerated]
	private ToolStripButton m_aw;

	[CompilerGenerated]
	private ToolTip m_ax;

	[CompilerGenerated]
	private ToolStripButton m_ay;

	[CompilerGenerated]
	private ToolStripButton m_az;

	[CompilerGenerated]
	private ToolStripMenuItem m_a0;

	[CompilerGenerated]
	private ToolStripMenuItem m_a1;

	[CompilerGenerated]
	private ToolStripMenuItem m_a2;

	[CompilerGenerated]
	private ToolStripMenuItem m_a3;

	[CompilerGenerated]
	private System.Windows.Forms.Timer m_a4;

	[CompilerGenerated]
	private ToolStripMenuItem m_a5;

	[CompilerGenerated]
	private Label m_a6;

	[CompilerGenerated]
	private Label m_a7;

	[CompilerGenerated]
	private ToolStripMenuItem m_a8;

	[CompilerGenerated]
	private ToolStripMenuItem m_a9;

	[CompilerGenerated]
	private ToolStripSeparator m_ba;

	[CompilerGenerated]
	private ToolStripMenuItem m_bb;

	[CompilerGenerated]
	private ToolStripMenuItem m_bc;

	[CompilerGenerated]
	private ToolStripMenuItem m_bd;

	[CompilerGenerated]
	private ToolStripMenuItem m_be;

	[CompilerGenerated]
	private ToolStripMenuItem m_bf;

	[CompilerGenerated]
	private ToolStripMenuItem m_bg;

	[CompilerGenerated]
	private ToolStripMenuItem m_bh;

	[CompilerGenerated]
	private ToolStripMenuItem m_bi;

	[CompilerGenerated]
	private ToolStripMenuItem m_bj;

	[CompilerGenerated]
	private ToolStripMenuItem m_bk;

	[CompilerGenerated]
	private ToolStripMenuItem m_bl;

	[CompilerGenerated]
	private ToolStripMenuItem m_bm;

	[CompilerGenerated]
	private ToolStrip m_bn;

	[CompilerGenerated]
	private ToolStripButton m_bo;

	[CompilerGenerated]
	private ToolStripButton m_bp;

	[CompilerGenerated]
	private ToolStripButton m_bq;

	[CompilerGenerated]
	private ToolStripButton m_br;

	[CompilerGenerated]
	private ToolStripButton m_bs;

	[CompilerGenerated]
	private ToolStripButton m_bt;

	[CompilerGenerated]
	private ToolStripComboBox m_bu;

	[CompilerGenerated]
	private ToolStripComboBox m_bv;

	[CompilerGenerated]
	private ToolStripSeparator m_bw;

	[CompilerGenerated]
	private ToolStripLabel m_bx;

	[CompilerGenerated]
	private ToolStripLabel m_by;

	[CompilerGenerated]
	private ToolStripSeparator m_bz;

	[CompilerGenerated]
	private ToolStripSeparator m_b0;

	[CompilerGenerated]
	private ToolStripLabel m_b1;

	[CompilerGenerated]
	private ToolStripButton m_b2;

	[CompilerGenerated]
	private ToolStripButton m_b3;

	[CompilerGenerated]
	private ToolStripComboBox m_b4;

	[CompilerGenerated]
	private ToolStripSeparator m_b5;

	[CompilerGenerated]
	private ToolStripButton m_b6;

	[CompilerGenerated]
	private ToolStripButton m_b7;

	[CompilerGenerated]
	private ToolStripMenuItem m_b8;

	[CompilerGenerated]
	private ToolStripMenuItem m_b9;

	[CompilerGenerated]
	private ToolStripMenuItem m_ca;

	[CompilerGenerated]
	private ToolStripMenuItem m_cb;

	[CompilerGenerated]
	private ToolStripMenuItem m_cc;

	[CompilerGenerated]
	private TableLayoutPanel m_cd;

	[CompilerGenerated]
	private TableLayoutPanel m_ce;

	[CompilerGenerated]
	private ToolStripMenuItem m_cf;

	[CompilerGenerated]
	private ToolStripSeparator m_cg;

	[CompilerGenerated]
	private ToolStripMenuItem m_ch;

	[CompilerGenerated]
	private ToolStripMenuItem m_ci;

	[CompilerGenerated]
	private ToolStripMenuItem m_cj;

	[CompilerGenerated]
	private ToolStripMenuItem m_ck;

	[CompilerGenerated]
	private ToolStripMenuItem m_cl;

	[CompilerGenerated]
	private ToolStripMenuItem m_cm;

	[CompilerGenerated]
	private ToolStripMenuItem m_cn;

	[CompilerGenerated]
	private ToolStripMenuItem m_co;

	[CompilerGenerated]
	private ToolStripMenuItem m_cp;

	[CompilerGenerated]
	private ToolStripMenuItem m_cq;

	[CompilerGenerated]
	private ToolStripMenuItem m_cr;

	[CompilerGenerated]
	private ToolStripMenuItem m_cs;

	[CompilerGenerated]
	private ToolStripMenuItem m_ct;

	[CompilerGenerated]
	private Button m_cu;

	[CompilerGenerated]
	private ToolStripSeparator m_cv;

	[CompilerGenerated]
	private ToolStripMenuItem m_cw;

	[CompilerGenerated]
	private ToolStripMenuItem m_cx;

	[CompilerGenerated]
	private ToolStripMenuItem m_cy;

	[CompilerGenerated]
	private ToolStripSeparator m_cz;

	[CompilerGenerated]
	private ToolStripMenuItem m_c0;

	internal const int c1 = 13369376;

	private f1 m_c2;

	private fz m_c3;

	private gr m_c4;

	private ge m_c5;

	private Collection m_c6;

	private bool m_c7;

	private bool m_c8;

	private fe m_c9;

	private fe.a m_da;

	protected fj db;

	private hs m_dc;

	private hs dd;

	private hd de;

	private Collection<go> m_df;

	private Collection<gn> m_dg;

	[CompilerGenerated]
	private System.Timers.Timer m_dh;

	private DateTime m_di;

	private gh m_dj;

	[CompilerGenerated]
	private global::r.d m_dk;

	[CompilerGenerated]
	private global::r.d m_dl;

	[CompilerGenerated]
	private global::i m_dm;

	private bool m_dn;

	private je m_do;

	private bool m_dp;

	private bool m_dq;

	private c1 m_dr;

	private bool m_ds;

	private const string m_dt = "MainForm.";

	private bool m_du;

	private bool m_dv;

	private c m_dw;

	[CompilerGenerated]
	private global::r.d m_dx;

	[CompilerGenerated]
	private global::r.d m_dy;

	[CompilerGenerated]
	private System.Timers.Timer m_dz;

	[CompilerGenerated]
	private global::r.d m_d0;

	[CompilerGenerated]
	private global::r.d m_d1;

	private int m_d2;

	private int m_d3;

	private gq m_d4;

	private const int m_d5 = 30;

	private const int m_d6 = 2;

	[CompilerGenerated]
	private global::r.d m_d7;

	private d m_d8;

	[CompilerGenerated]
	private global::r.d m_d9;

	private bool m_ea;

	private Exception m_eb;

	private bool m_ec;

	private global::l m_ed;

	private bool m_ee;

	private d1 m_ef;

	private d1 m_eg;

	private int m_eh;

	private TabPage m_ei;

	[CompilerGenerated]
	private c5 m_ej;

	private int m_ek;

	private fm m_el;

	private bool m_em;

	private bool m_en;

	private gl m_eo;

	private bool m_ep;

	private string eq;

	private string er;

	private string es;

	private string et;

	private string eu;

	private string ev;

	private string ew;

	private FileSystemWatcher ex;

	[CompilerGenerated]
	private bool ey;

	private bool ez;

	[CompilerGenerated]
	private h e0;

	private const int e1 = 1;

	private const int e2 = 2;

	private const int e3 = 3;

	private const string e4 = ".jpg";

	private const string e5 = ".png";

	private const string e6 = ".bmp";

	private const float e7 = 1.25f;

	private const float e8 = 0.75f;

	[SpecialName]
	private bool e9;

	[SpecialName]
	private string fa;

	[SpecialName]
	private string fb;

	[SpecialName]
	private string fc;

	[SpecialName]
	private string fd;

	[SpecialName]
	private string fe;

	[SpecialName]
	private bool ff;

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
	private void ak()
	{
		this.m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(gg));
		b(new MenuStrip());
		b(new ToolStripMenuItem());
		i(new ToolStripMenuItem());
		a3(new ToolStripMenuItem());
		a4(new ToolStripMenuItem());
		ah(new ToolStripMenuItem());
		ao(new ToolStripMenuItem());
		a8(new ToolStripMenuItem());
		a9(new ToolStripMenuItem());
		ba(new ToolStripMenuItem());
		bj(new ToolStripMenuItem());
		w(new ToolStripMenuItem());
		ad(new ToolStripMenuItem());
		ab(new ToolStripMenuItem());
		a0(new ToolStripMenuItem());
		ac(new ToolStripMenuItem());
		aq(new ToolStripMenuItem());
		al(new ToolStripMenuItem());
		am(new ToolStripMenuItem());
		bb(new ToolStripMenuItem());
		c(new ToolStripSeparator());
		h(new ToolStripMenuItem());
		a5(new ToolStripMenuItem());
		z(new ToolStripMenuItem());
		r(new ToolStripMenuItem());
		ae(new ToolStripMenuItem());
		af(new ToolStripMenuItem());
		aj(new ToolStripMenuItem());
		ai(new ToolStripMenuItem());
		a1(new ToolStripMenuItem());
		ar(new ToolStripMenuItem());
		ag(new ToolStripMenuItem());
		b(new ToolStripSeparator());
		o(new ToolStripMenuItem());
		p(new ToolStripMenuItem());
		d(new ToolStripSeparator());
		y(new ToolStripMenuItem());
		c(new ToolStripMenuItem());
		t(new ToolStripMenuItem());
		@as(new ToolStripMenuItem());
		at(new ToolStripMenuItem());
		au(new ToolStripMenuItem());
		a2(new ToolStripMenuItem());
		a6(new ToolStripMenuItem());
		d(new ToolStripMenuItem());
		g(new ToolStripMenuItem());
		m(new ToolStripMenuItem());
		s(new ToolStripMenuItem());
		q(new ToolStripMenuItem());
		ak(new ToolStripMenuItem());
		f(new ToolStripSeparator());
		ap(new ToolStripMenuItem());
		an(new ToolStripMenuItem());
		l(new ToolStripSeparator());
		bl(new ToolStripMenuItem());
		bm(new ToolStripMenuItem());
		bn(new ToolStripMenuItem());
		m(new ToolStripSeparator());
		bc(new ToolStripMenuItem());
		bd(new ToolStripMenuItem());
		be(new ToolStripMenuItem());
		bf(new ToolStripMenuItem());
		bg(new ToolStripMenuItem());
		bh(new ToolStripMenuItem());
		bi(new ToolStripMenuItem());
		bk(new ToolStripMenuItem());
		e(new ToolStripMenuItem());
		k(new ToolStripMenuItem());
		j(new ToolStripMenuItem());
		v(new ToolStripMenuItem());
		u(new ToolStripMenuItem());
		av(new ToolStripMenuItem());
		aw(new ToolStripMenuItem());
		ax(new ToolStripMenuItem());
		ay(new ToolStripMenuItem());
		az(new ToolStripMenuItem());
		f(new ToolStripMenuItem());
		a7(new ToolStripMenuItem());
		k(new ToolStripSeparator());
		x(new ToolStripMenuItem());
		aa(new ToolStripMenuItem());
		l(new ToolStripMenuItem());
		n(new ToolStripMenuItem());
		b(new ImageList(this.m_a));
		b(new PrintDocument());
		b(new PageSetupDialog());
		b(new PrintDialog());
		b(new ToolStrip());
		b(new ToolStripButton());
		e(new ToolStripButton());
		c(new ToolStripButton());
		e(new ToolStripSeparator());
		d(new ToolStripButton());
		f(new ToolStripButton());
		b(new ToolTip(this.m_a));
		b(new Label());
		c(new Label());
		c(new ToolStrip());
		j(new ToolStripSeparator());
		o(new ToolStripButton());
		p(new ToolStripButton());
		g(new ToolStripSeparator());
		b(new ToolStripLabel());
		g(new ToolStripButton());
		k(new ToolStripButton());
		b(new ToolStripComboBox());
		h(new ToolStripSeparator());
		c(new ToolStripLabel());
		h(new ToolStripButton());
		l(new ToolStripButton());
		c(new ToolStripComboBox());
		i(new ToolStripSeparator());
		d(new ToolStripLabel());
		m(new ToolStripButton());
		n(new ToolStripButton());
		d(new ToolStripComboBox());
		i(new ToolStripButton());
		j(new ToolStripButton());
		b(new TableLayoutPanel());
		c(new TableLayoutPanel());
		b(new Button());
		b(new System.Windows.Forms.Timer(this.m_a));
		b(new fw());
		bo(new ToolStripMenuItem());
		al().SuspendLayout();
		bs().SuspendLayout();
		cn().SuspendLayout();
		df().SuspendLayout();
		dg().SuspendLayout();
		SuspendLayout();
		componentResourceManager.ApplyResources(al(), "MenuStrip1");
		al().Items.AddRange(new ToolStripItem[5]
		{
			am(),
			an(),
			ao(),
			ap(),
			aq()
		});
		al().Name = "MenuStrip1";
		am().DropDownItems.AddRange(new ToolStripItem[18]
		{
			av(),
			c9(),
			da(),
			bo(),
			b8(),
			dj(),
			bd(),
			bp(),
			au(),
			db(),
			bg(),
			a8(),
			bl(),
			a1(),
			a2(),
			a3(),
			bq(),
			bf()
		});
		am().Name = "FileToolStripMenuItem";
		componentResourceManager.ApplyResources(am(), "FileToolStripMenuItem");
		av().Name = "OpenSpectrumOrVsTimeFileToolStripMenuItem";
		componentResourceManager.ApplyResources(av(), "OpenSpectrumOrVsTimeFileToolStripMenuItem");
		c9().Name = "OpenWaferMapToolStripMenuItem";
		componentResourceManager.ApplyResources(c9(), "OpenWaferMapToolStripMenuItem");
		da().Name = "OpenDifferenceMapToolStripMenuItem";
		componentResourceManager.ApplyResources(da(), "OpenDifferenceMapToolStripMenuItem");
		bo().Name = "OpenMeasuredTemplateToolStripMenuItem";
		componentResourceManager.ApplyResources(bo(), "OpenMeasuredTemplateToolStripMenuItem");
		b8().Name = "OpenHistoryToolStripMenuItem";
		componentResourceManager.ApplyResources(b8(), "OpenHistoryToolStripMenuItem");
		dj().DropDownItems.AddRange(new ToolStripItem[3]
		{
			dk(),
			dl(),
			du()
		});
		dj().Name = "ViewToolStripMenuItem";
		componentResourceManager.ApplyResources(dj(), "ViewToolStripMenuItem");
		dk().Name = "MapResultsFolderToolStripMenuItem";
		componentResourceManager.ApplyResources(dk(), "MapResultsFolderToolStripMenuItem");
		dl().Name = "SolverReportFolderToolStripMenuItem";
		componentResourceManager.ApplyResources(dl(), "SolverReportFolderToolStripMenuItem");
		du().Name = "LogFileToolStripMenuItem";
		componentResourceManager.ApplyResources(du(), "LogFileToolStripMenuItem");
		bd().DropDownItems.AddRange(new ToolStripItem[8]
		{
			bk(),
			bi(),
			cl(),
			bj(),
			cb(),
			b2(),
			b3(),
			dm()
		});
		bd().Name = "ToolStripMenuItemFileImport";
		componentResourceManager.ApplyResources(bd(), "ToolStripMenuItemFileImport");
		bk().Name = "ToolStripMenuItemFileImportRecipe";
		componentResourceManager.ApplyResources(bk(), "ToolStripMenuItemFileImportRecipe");
		bi().Name = "ToolStripMenuItemFileImportMaterial";
		componentResourceManager.ApplyResources(bi(), "ToolStripMenuItemFileImportMaterial");
		cl().Name = "LayerStackImportToolStripMenuItem";
		componentResourceManager.ApplyResources(cl(), "LayerStackImportToolStripMenuItem");
		bj().Name = "ToolStripMenuItemFileImportLicense";
		componentResourceManager.ApplyResources(bj(), "ToolStripMenuItemFileImportLicense");
		cb().Name = "ToolStripMenuItemFileImportBaseline";
		componentResourceManager.ApplyResources(cb(), "ToolStripMenuItemFileImportBaseline");
		b2().Name = "ToolStripMenuItemFileImportTechSupportArchive";
		componentResourceManager.ApplyResources(b2(), "ToolStripMenuItemFileImportTechSupportArchive");
		b3().Name = "ToolStripMenuItemFileImportTechSupportSettings";
		componentResourceManager.ApplyResources(b3(), "ToolStripMenuItemFileImportTechSupportSettings");
		dm().Name = "ImportOpticsToolStripMenuItem";
		componentResourceManager.ApplyResources(dm(), "ImportOpticsToolStripMenuItem");
		bp().Name = "ToolStripSeparator2";
		componentResourceManager.ApplyResources(bp(), "ToolStripSeparator2");
		au().Name = "SaveSpectrumOrVsTimeFileToolStripMenuItem";
		componentResourceManager.ApplyResources(au(), "SaveSpectrumOrVsTimeFileToolStripMenuItem");
		db().Name = "SaveWaferMapToolStripMenuItem";
		componentResourceManager.ApplyResources(db(), "SaveWaferMapToolStripMenuItem");
		bg().Name = "SaveNkToolStripMenuItem";
		componentResourceManager.ApplyResources(bg(), "SaveNkToolStripMenuItem");
		a8().Name = "PrintScreenToolStripMenuItem";
		componentResourceManager.ApplyResources(a8(), "PrintScreenToolStripMenuItem");
		bl().DropDownItems.AddRange(new ToolStripItem[6]
		{
			bm(),
			b0(),
			br(),
			cm(),
			cc(),
			bn()
		});
		bl().Name = "ToolStripMenuItemFileExport";
		componentResourceManager.ApplyResources(bl(), "ToolStripMenuItemFileExport");
		bm().Name = "ToolStripMenuItemFileExportRecipe";
		componentResourceManager.ApplyResources(bm(), "ToolStripMenuItemFileExportRecipe");
		b0().Name = "ToolStripMenuItemFileExportRecipeAsRpe";
		componentResourceManager.ApplyResources(b0(), "ToolStripMenuItemFileExportRecipeAsRpe");
		br().Name = "ToolStripMenuItemFileExportMaterial";
		componentResourceManager.ApplyResources(br(), "ToolStripMenuItemFileExportMaterial");
		cm().Name = "LayerStackExportToolStripMenuItem";
		componentResourceManager.ApplyResources(cm(), "LayerStackExportToolStripMenuItem");
		cc().Name = "ToolStripMenuItemFileExportBaseline";
		componentResourceManager.ApplyResources(cc(), "ToolStripMenuItemFileExportBaseline");
		bn().Name = "ToolStripMenuItemFileExportSystemInfo";
		componentResourceManager.ApplyResources(bn(), "ToolStripMenuItemFileExportSystemInfo");
		a1().Name = "ToolStripSeparator1";
		componentResourceManager.ApplyResources(a1(), "ToolStripSeparator1");
		a2().Name = "PageSetupToolStripMenuItem";
		componentResourceManager.ApplyResources(a2(), "PageSetupToolStripMenuItem");
		a3().Name = "PrintToolStripMenuItem";
		componentResourceManager.ApplyResources(a3(), "PrintToolStripMenuItem");
		bq().Name = "ToolStripSeparator3";
		componentResourceManager.ApplyResources(bq(), "ToolStripSeparator3");
		bf().Name = "ExitToolStripMenuItem";
		componentResourceManager.ApplyResources(bf(), "ExitToolStripMenuItem");
		an().DropDownItems.AddRange(new ToolStripItem[4]
		{
			ba(),
			cd(),
			c8(),
			dc()
		});
		an().Name = "EditToolStripMenuItem";
		componentResourceManager.ApplyResources(an(), "EditToolStripMenuItem");
		ba().Name = "MaterialLibraryToolStripMenuItem";
		componentResourceManager.ApplyResources(ba(), "MaterialLibraryToolStripMenuItem");
		cd().DropDownItems.AddRange(new ToolStripItem[2]
		{
			ce(),
			cf()
		});
		cd().Name = "ToolStripMenuItemEditOMDB";
		componentResourceManager.ApplyResources(cd(), "ToolStripMenuItemEditOMDB");
		ce().Name = "ToolStripMenuItemEditOMDBNK";
		componentResourceManager.ApplyResources(ce(), "ToolStripMenuItemEditOMDBNK");
		cf().Name = "ToolStripMenuItemEditOMDBRRR";
		componentResourceManager.ApplyResources(cf(), "ToolStripMenuItemEditOMDBRRR");
		c8().Name = "BuildORIDMaterialFolderToolStripMenuItem";
		componentResourceManager.ApplyResources(c8(), "BuildORIDMaterialFolderToolStripMenuItem");
		dc().Name = "MapPatternToolStripMenuItem";
		componentResourceManager.ApplyResources(dc(), "MapPatternToolStripMenuItem");
		ao().DropDownItems.AddRange(new ToolStripItem[14]
		{
			at(),
			az(),
			a9(),
			a7(),
			b1(),
			ca(),
			b9(),
			b5(),
			dx(),
			dy(),
			d1(),
			dn(),
			dt(),
			dv()
		});
		ao().Name = "SetupToolStripMenuItem";
		componentResourceManager.ApplyResources(ao(), "SetupToolStripMenuItem");
		at().Name = "DataAcqToolStripMenuItem";
		componentResourceManager.ApplyResources(at(), "DataAcqToolStripMenuItem");
		az().Name = "OpticsConfigurationToolStripMenuItem";
		componentResourceManager.ApplyResources(az(), "OpticsConfigurationToolStripMenuItem");
		a9().Name = "DisplayToolStripMenuItem";
		componentResourceManager.ApplyResources(a9(), "DisplayToolStripMenuItem");
		a7().Name = "MeasModulesConfigurationToolStripMenuItem";
		componentResourceManager.ApplyResources(a7(), "MeasModulesConfigurationToolStripMenuItem");
		b1().Name = "RawSignalToolStripMenuItem";
		componentResourceManager.ApplyResources(b1(), "RawSignalToolStripMenuItem");
		ca().Name = "ToolStripMenuItem2";
		componentResourceManager.ApplyResources(ca(), "ToolStripMenuItem2");
		b9().Name = "AccessControlToolStripMenuItem";
		componentResourceManager.ApplyResources(b9(), "AccessControlToolStripMenuItem");
		b5().Name = "OptionsToolStripMenuItem";
		componentResourceManager.ApplyResources(b5(), "OptionsToolStripMenuItem");
		dx().Name = "ToolStripSeparatorActionsTop";
		componentResourceManager.ApplyResources(dx(), "ToolStripSeparatorActionsTop");
		dy().DropDownItems.AddRange(new ToolStripItem[2]
		{
			dz(),
			d0()
		});
		dy().Name = "ToolStripMenuItemMoveTo";
		componentResourceManager.ApplyResources(dy(), "ToolStripMenuItemMoveTo");
		dz().Name = "HCTToolStripMenuItem";
		componentResourceManager.ApplyResources(dz(), "HCTToolStripMenuItem");
		d0().Name = "UnloadToolStripMenuItem";
		componentResourceManager.ApplyResources(d0(), "UnloadToolStripMenuItem");
		d1().Name = "ToolStripSeparatorActionsBottom";
		componentResourceManager.ApplyResources(d1(), "ToolStripSeparatorActionsBottom");
		dn().DropDownItems.AddRange(new ToolStripItem[6]
		{
			@do(),
			dp(),
			dq(),
			dr(),
			ds(),
			d2()
		});
		dn().Name = "QualityAssuranceToolStripMenuItem";
		componentResourceManager.ApplyResources(dn(), "QualityAssuranceToolStripMenuItem");
		@do().Name = "MeasureQCWaferToolStripMenuItem";
		componentResourceManager.ApplyResources(@do(), "MeasureQCWaferToolStripMenuItem");
		dp().Name = "CreateUSBStickToolStripMenuItem";
		componentResourceManager.ApplyResources(dp(), "CreateUSBStickToolStripMenuItem");
		dq().Name = "LSDT2TestingToolStripMenuItem";
		componentResourceManager.ApplyResources(dq(), "LSDT2TestingToolStripMenuItem");
		dr().Name = "DualFiberShutterTestingToolStripMenuItem";
		componentResourceManager.ApplyResources(dr(), "DualFiberShutterTestingToolStripMenuItem");
		ds().Name = "LightTowerTestingToolStripMenuItem";
		componentResourceManager.ApplyResources(ds(), "LightTowerTestingToolStripMenuItem");
		dt().Name = "ProgramWaferHandlingStationsToolStripMenuItem";
		componentResourceManager.ApplyResources(dt(), "ProgramWaferHandlingStationsToolStripMenuItem");
		dv().Name = "ServiceMaintenanceToolStripMenuItem";
		componentResourceManager.ApplyResources(dv(), "ServiceMaintenanceToolStripMenuItem");
		ap().DropDownItems.AddRange(new ToolStripItem[5]
		{
			ax(),
			aw(),
			bc(),
			bb(),
			cg()
		});
		ap().Name = "AcquireToolStripMenuItem";
		componentResourceManager.ApplyResources(ap(), "AcquireToolStripMenuItem");
		ax().Name = "DoSingleAcquireToolStripMenuItem";
		componentResourceManager.ApplyResources(ax(), "DoSingleAcquireToolStripMenuItem");
		aw().Name = "StartContinuousAcquireToolStripMenuItem";
		componentResourceManager.ApplyResources(aw(), "StartContinuousAcquireToolStripMenuItem");
		bc().Name = "SingleMeasureToolStripMenuItem";
		componentResourceManager.ApplyResources(bc(), "SingleMeasureToolStripMenuItem");
		bb().Name = "ContinuousMeasureToolStripMenuItem";
		componentResourceManager.ApplyResources(bb(), "ContinuousMeasureToolStripMenuItem");
		cg().DropDownItems.AddRange(new ToolStripItem[4]
		{
			ch(),
			ci(),
			cj(),
			ck()
		});
		cg().Name = "BatchToolStripMenuItem";
		componentResourceManager.ApplyResources(cg(), "BatchToolStripMenuItem");
		ch().Name = "BatchAcquireToolStripMenuItem";
		componentResourceManager.ApplyResources(ch(), "BatchAcquireToolStripMenuItem");
		ci().Name = "BatchMeasureToolStripMenuItem";
		componentResourceManager.ApplyResources(ci(), "BatchMeasureToolStripMenuItem");
		cj().Name = "BatchAnalyzeSpectraToolStripMenuItem";
		componentResourceManager.ApplyResources(cj(), "BatchAnalyzeSpectraToolStripMenuItem");
		ck().Name = "BatchAnalyzeAllSpectraInFolderToolStripMenuItem";
		componentResourceManager.ApplyResources(ck(), "BatchAnalyzeAllSpectraInFolderToolStripMenuItem");
		aq().DropDownItems.AddRange(new ToolStripItem[5]
		{
			dh(),
			di(),
			be(),
			bh(),
			ay()
		});
		aq().Name = "HelpToolStripMenuItem";
		componentResourceManager.ApplyResources(aq(), "HelpToolStripMenuItem");
		dh().Name = "UserManualToolStripMenuItem";
		componentResourceManager.ApplyResources(dh(), "UserManualToolStripMenuItem");
		di().Name = "ToolStripMenuItemHelpDiv1";
		componentResourceManager.ApplyResources(di(), "ToolStripMenuItemHelpDiv1");
		be().Name = "DiagnosticsStripMenuItem";
		componentResourceManager.ApplyResources(be(), "DiagnosticsStripMenuItem");
		bh().Name = "SupportToolStripMenuItem";
		componentResourceManager.ApplyResources(bh(), "SupportToolStripMenuItem");
		ay().Name = "AboutToolStripMenuItem";
		componentResourceManager.ApplyResources(ay(), "AboutToolStripMenuItem");
		a0().Name = "MeasurementModulesToolStripMenuItem";
		componentResourceManager.ApplyResources(a0(), "MeasurementModulesToolStripMenuItem");
		@as().ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
		@as().TransparentColor = Color.Transparent;
		@as().Images.SetKeyName(0, "BlankImageLabel.bmp");
		@as().Images.SetKeyName(1, "TabMeasModuleIcon.bmp");
		@as().Images.SetKeyName(2, "Ok.png");
		a5().Document = a4();
		a6().AllowPrintToFile = false;
		a6().Document = a4();
		a6().UseEXDialog = true;
		componentResourceManager.ApplyResources(bs(), "ToolStrip1");
		bs().GripStyle = ToolStripGripStyle.Hidden;
		bs().Items.AddRange(new ToolStripItem[6]
		{
			bt(),
			by(),
			bu(),
			bv(),
			bw(),
			bz()
		});
		bs().Name = "ToolStrip1";
		bs().RenderMode = ToolStripRenderMode.System;
		bt().DisplayStyle = ToolStripItemDisplayStyle.Image;
		componentResourceManager.ApplyResources(bt(), "OpenToolStripButton");
		bt().Name = "OpenToolStripButton";
		by().DisplayStyle = ToolStripItemDisplayStyle.Image;
		componentResourceManager.ApplyResources(by(), "SaveToolStripButton");
		by().Name = "SaveToolStripButton";
		bu().DisplayStyle = ToolStripItemDisplayStyle.Image;
		componentResourceManager.ApplyResources(bu(), "PrintToolStripButton");
		bu().Name = "PrintToolStripButton";
		bv().Name = "toolStripSeparator";
		componentResourceManager.ApplyResources(bv(), "toolStripSeparator");
		bw().DisplayStyle = ToolStripItemDisplayStyle.Image;
		componentResourceManager.ApplyResources(bw(), "ToolStripButtonClearGraph");
		bw().Name = "ToolStripButtonClearGraph";
		bz().DisplayStyle = ToolStripItemDisplayStyle.Image;
		componentResourceManager.ApplyResources(bz(), "ToolStripButtonSaveScreen");
		bz().Name = "ToolStripButtonSaveScreen";
		componentResourceManager.ApplyResources(b6(), "LabelMeasureDelay");
		b6().BackColor = SystemColors.Control;
		b6().Name = "LabelMeasureDelay";
		componentResourceManager.ApplyResources(b7(), "LabelMeasureDelayLbl");
		b7().Name = "LabelMeasureDelayLbl";
		componentResourceManager.ApplyResources(cn(), "ToolStripMeasReport");
		cn().GripStyle = ToolStripGripStyle.Hidden;
		cn().Items.AddRange(new ToolStripItem[20]
		{
			c5(),
			c6(),
			c7(),
			cw(),
			cx(),
			co(),
			cs(),
			cu(),
			cz(),
			cy(),
			cp(),
			ct(),
			cv(),
			c0(),
			c1(),
			c2(),
			c3(),
			c4(),
			cq(),
			cr()
		});
		cn().Name = "ToolStripMeasReport";
		cn().RenderMode = ToolStripRenderMode.System;
		c5().Name = "ToolStripSeparator7";
		componentResourceManager.ApplyResources(c5(), "ToolStripSeparator7");
		c6().DisplayStyle = ToolStripItemDisplayStyle.Text;
		componentResourceManager.ApplyResources(c6(), "ToolStripButtonEdit");
		c6().Name = "ToolStripButtonEdit";
		componentResourceManager.ApplyResources(c7(), "ToolStripButtonClose");
		c7().DisplayStyle = ToolStripItemDisplayStyle.Image;
		c7().Image = Resources.xGray;
		c7().Margin = new Padding(0);
		c7().Name = "ToolStripButtonClose";
		cw().Name = "ToolStripSeparator4";
		componentResourceManager.ApplyResources(cw(), "ToolStripSeparator4");
		componentResourceManager.ApplyResources(cx(), "ToolStripLabel1");
		cx().Name = "ToolStripLabel1";
		co().DisplayStyle = ToolStripItemDisplayStyle.Image;
		componentResourceManager.ApplyResources(co(), "ToolStripButtonSampleF");
		co().Image = Resources.PlusGray;
		co().Name = "ToolStripButtonSampleF";
		cs().DisplayStyle = ToolStripItemDisplayStyle.Image;
		componentResourceManager.ApplyResources(cs(), "ToolStripButtonSampleB");
		cs().Image = Resources.MinusGray;
		cs().Name = "ToolStripButtonSampleB";
		cu().DropDownStyle = ComboBoxStyle.DropDownList;
		cu().DropDownWidth = 200;
		componentResourceManager.ApplyResources(cu(), "ToolStripComboSample");
		cu().Name = "ToolStripComboSample";
		cz().Name = "ToolStripSeparator5";
		componentResourceManager.ApplyResources(cz(), "ToolStripSeparator5");
		componentResourceManager.ApplyResources(cy(), "ToolStripLabel2");
		cy().Name = "ToolStripLabel2";
		cp().DisplayStyle = ToolStripItemDisplayStyle.Image;
		componentResourceManager.ApplyResources(cp(), "ToolStripButtonLocF");
		cp().Image = Resources.PlusGray;
		cp().Name = "ToolStripButtonLocF";
		ct().DisplayStyle = ToolStripItemDisplayStyle.Image;
		componentResourceManager.ApplyResources(ct(), "ToolStripButtonLocB");
		ct().Image = Resources.MinusGray;
		ct().Name = "ToolStripButtonLocB";
		cv().DropDownStyle = ComboBoxStyle.DropDownList;
		componentResourceManager.ApplyResources(cv(), "ToolStripComboLoc");
		cv().Name = "ToolStripComboLoc";
		c0().Name = "ToolStripSeparator6";
		componentResourceManager.ApplyResources(c0(), "ToolStripSeparator6");
		componentResourceManager.ApplyResources(c1(), "ToolStripLabel3");
		c1().Name = "ToolStripLabel3";
		c2().DisplayStyle = ToolStripItemDisplayStyle.Image;
		componentResourceManager.ApplyResources(c2(), "ToolStripButtonSpecF");
		c2().Image = Resources.PlusGray;
		c2().Name = "ToolStripButtonSpecF";
		c3().DisplayStyle = ToolStripItemDisplayStyle.Image;
		componentResourceManager.ApplyResources(c3(), "ToolStripButtonSpecB");
		c3().Image = Resources.MinusGray;
		c3().Name = "ToolStripButtonSpecB";
		c4().DropDownStyle = ComboBoxStyle.DropDownList;
		componentResourceManager.ApplyResources(c4(), "ToolStripComboSpec");
		c4().Name = "ToolStripComboSpec";
		cq().CheckOnClick = true;
		cq().DisplayStyle = ToolStripItemDisplayStyle.Text;
		componentResourceManager.ApplyResources(cq(), "ToolStripButtonMarkResult");
		cq().Name = "ToolStripButtonMarkResult";
		cr().CheckOnClick = true;
		cr().DisplayStyle = ToolStripItemDisplayStyle.Text;
		componentResourceManager.ApplyResources(cr(), "ToolStripButtonMarkSS");
		cr().Name = "ToolStripButtonMarkSS";
		componentResourceManager.ApplyResources(df(), "TLPDelayStatus");
		df().Controls.Add(b6(), 1, 0);
		df().Controls.Add(b7(), 0, 0);
		df().Name = "TLPDelayStatus";
		componentResourceManager.ApplyResources(dg(), "TLPTopControls");
		dg().Controls.Add(cn(), 0, 0);
		dg().Controls.Add(df(), 1, 0);
		dg().Controls.Add(dw(), 2, 0);
		dg().Name = "TLPTopControls";
		componentResourceManager.ApplyResources(dw(), "ButtonGEMState");
		dw().Name = "ButtonGEMState";
		dw().UseVisualStyleBackColor = true;
		b4().Interval = 1;
		ar().a(fw.a.a);
		ar().ImageList = @as();
		componentResourceManager.ApplyResources(ar(), "CustomTabMainform");
		ar().Name = "CustomTabMainform";
		ar().SelectedIndex = 0;
		ar().SizeMode = TabSizeMode.Fixed;
		d2().Name = "StageTestToolStripMenuItem";
		componentResourceManager.ApplyResources(d2(), "StageTestToolStripMenuItem");
		componentResourceManager.ApplyResources(this, "$this");
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(ar());
		base.Controls.Add(bs());
		base.Controls.Add(dg());
		base.Controls.Add(al());
		base.MainMenuStrip = al();
		base.Name = "MainForm";
		al().ResumeLayout(performLayout: false);
		al().PerformLayout();
		bs().ResumeLayout(performLayout: false);
		bs().PerformLayout();
		cn().ResumeLayout(performLayout: false);
		cn().PerformLayout();
		df().ResumeLayout(performLayout: false);
		df().PerformLayout();
		dg().ResumeLayout(performLayout: false);
		dg().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual MenuStrip al()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(MenuStrip A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem am()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ToolStripMenuItem A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem an()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ToolStripMenuItem A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem ao()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(ToolStripMenuItem A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem ap()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(ToolStripMenuItem A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem aq()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(ToolStripMenuItem A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual fw ar()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(fw A_0)
	{
		EventHandler value = ax;
		fw fw2 = this.m_h;
		if (fw2 != null)
		{
			fw2.SelectedIndexChanged -= value;
		}
		this.m_h = A_0;
		fw2 = this.m_h;
		if (fw2 != null)
		{
			fw2.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ImageList @as()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ImageList A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem at()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(ToolStripMenuItem A_0)
	{
		EventHandler value = ba;
		ToolStripMenuItem toolStripMenuItem = this.m_j;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_j = A_0;
		toolStripMenuItem = this.m_j;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem au()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(ToolStripMenuItem A_0)
	{
		EventHandler value = a7;
		ToolStripMenuItem toolStripMenuItem = this.m_k;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_k = A_0;
		toolStripMenuItem = this.m_k;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem av()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(ToolStripMenuItem A_0)
	{
		EventHandler value = a9;
		ToolStripMenuItem toolStripMenuItem = this.m_l;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_l = A_0;
		toolStripMenuItem = this.m_l;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	public gg()
	{
		base.Activated += bo;
		base.Deactivate += bn;
		base.Load += bm;
		base.Resize += bl;
		base.FormClosing += b;
		base.Shown += f;
		base.ResizeBegin += e;
		base.ResizeEnd += d;
		c(new global::r.d());
		b(new global::i());
		this.m_do = new je();
		d(new global::r.d());
		f(new global::r.d());
		g(new global::r.d());
		this.m_d2 = 0;
		this.m_d3 = 0;
		this.m_eo = new gl();
		ak();
		cn().Visible = false;
		SystemEvents.PowerModeChanged += b;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem aw()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(ToolStripMenuItem A_0)
	{
		EventHandler value = bj;
		ToolStripMenuItem toolStripMenuItem = this.m_m;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_m = A_0;
		toolStripMenuItem = this.m_m;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem ax()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(ToolStripMenuItem A_0)
	{
		EventHandler value = bk;
		ToolStripMenuItem toolStripMenuItem = this.m_n;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_n = A_0;
		toolStripMenuItem = this.m_n;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem ay()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(ToolStripMenuItem A_0)
	{
		EventHandler value = a6;
		ToolStripMenuItem toolStripMenuItem = this.m_o;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_o = A_0;
		toolStripMenuItem = this.m_o;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem az()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(ToolStripMenuItem A_0)
	{
		EventHandler value = a5;
		ToolStripMenuItem toolStripMenuItem = this.m_p;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_p = A_0;
		toolStripMenuItem = this.m_p;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem a0()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(ToolStripMenuItem A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripSeparator a1()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ToolStripSeparator A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem a2()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(ToolStripMenuItem A_0)
	{
		EventHandler value = a4;
		ToolStripMenuItem toolStripMenuItem = this.m_s;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_s = A_0;
		toolStripMenuItem = this.m_s;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem a3()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(ToolStripMenuItem A_0)
	{
		EventHandler value = a3;
		ToolStripMenuItem toolStripMenuItem = this.m_t;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_t = A_0;
		toolStripMenuItem = this.m_t;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PrintDocument a4()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(PrintDocument A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PageSetupDialog a5()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(PageSetupDialog A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PrintDialog a6()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(PrintDialog A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem a7()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(ToolStripMenuItem A_0)
	{
		EventHandler value = a1;
		ToolStripMenuItem toolStripMenuItem = this.m_x;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_x = A_0;
		toolStripMenuItem = this.m_x;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem a8()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(ToolStripMenuItem A_0)
	{
		EventHandler value = a0;
		ToolStripMenuItem toolStripMenuItem = this.m_y;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_y = A_0;
		toolStripMenuItem = this.m_y;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem a9()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(ToolStripMenuItem A_0)
	{
		EventHandler value = az;
		ToolStripMenuItem toolStripMenuItem = this.m_z;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_z = A_0;
		toolStripMenuItem = this.m_z;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem ba()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(ToolStripMenuItem A_0)
	{
		EventHandler value = ay;
		ToolStripMenuItem toolStripMenuItem = this.m_aa;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_aa = A_0;
		toolStripMenuItem = this.m_aa;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem bb()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(ToolStripMenuItem A_0)
	{
		EventHandler value = bh;
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
	internal virtual ToolStripMenuItem bc()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(ToolStripMenuItem A_0)
	{
		EventHandler value = bi;
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
	internal virtual ToolStripMenuItem bd()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(ToolStripMenuItem A_0)
	{
		this.m_ad = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem be()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(ToolStripMenuItem A_0)
	{
		EventHandler value = aw;
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
	internal virtual ToolStripMenuItem bf()
	{
		return this.m_af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(ToolStripMenuItem A_0)
	{
		EventHandler value = av;
		ToolStripMenuItem toolStripMenuItem = this.m_af;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_af = A_0;
		toolStripMenuItem = this.m_af;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem bg()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(ToolStripMenuItem A_0)
	{
		EventHandler value = au;
		ToolStripMenuItem toolStripMenuItem = this.m_ag;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_ag = A_0;
		toolStripMenuItem = this.m_ag;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem bh()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aa(ToolStripMenuItem A_0)
	{
		EventHandler value = at;
		ToolStripMenuItem toolStripMenuItem = this.m_ah;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_ah = A_0;
		toolStripMenuItem = this.m_ah;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem bi()
	{
		return this.m_ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(ToolStripMenuItem A_0)
	{
		EventHandler value = aq;
		ToolStripMenuItem toolStripMenuItem = this.m_ai;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_ai = A_0;
		toolStripMenuItem = this.m_ai;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem bj()
	{
		return this.m_aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(ToolStripMenuItem A_0)
	{
		EventHandler value = @as;
		ToolStripMenuItem toolStripMenuItem = this.m_aj;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_aj = A_0;
		toolStripMenuItem = this.m_aj;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem bk()
	{
		return this.m_ak;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(ToolStripMenuItem A_0)
	{
		EventHandler value = ap;
		ToolStripMenuItem toolStripMenuItem = this.m_ak;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_ak = A_0;
		toolStripMenuItem = this.m_ak;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem bl()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ae(ToolStripMenuItem A_0)
	{
		this.m_al = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem bm()
	{
		return this.m_am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void af(ToolStripMenuItem A_0)
	{
		EventHandler value = ao;
		ToolStripMenuItem toolStripMenuItem = this.m_am;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_am = A_0;
		toolStripMenuItem = this.m_am;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem bn()
	{
		return this.m_an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ag(ToolStripMenuItem A_0)
	{
		EventHandler value = am;
		ToolStripMenuItem toolStripMenuItem = this.m_an;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_an = A_0;
		toolStripMenuItem = this.m_an;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem bo()
	{
		return this.m_ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ah(ToolStripMenuItem A_0)
	{
		EventHandler value = al;
		ToolStripMenuItem toolStripMenuItem = this.m_ao;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_ao = A_0;
		toolStripMenuItem = this.m_ao;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripSeparator bp()
	{
		return this.m_ap;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ToolStripSeparator A_0)
	{
		this.m_ap = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripSeparator bq()
	{
		return this.m_aq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(ToolStripSeparator A_0)
	{
		this.m_aq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem br()
	{
		return this.m_ar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ai(ToolStripMenuItem A_0)
	{
		EventHandler value = an;
		ToolStripMenuItem toolStripMenuItem = this.m_ar;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_ar = A_0;
		toolStripMenuItem = this.m_ar;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStrip bs()
	{
		return this.m_as;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ToolStrip A_0)
	{
		this.m_as = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton bt()
	{
		return this.m_at;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ToolStripButton A_0)
	{
		EventHandler value = a9;
		ToolStripButton toolStripButton = this.m_at;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_at = A_0;
		toolStripButton = this.m_at;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton bu()
	{
		return this.m_au;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ToolStripButton A_0)
	{
		EventHandler value = a3;
		ToolStripButton toolStripButton = this.m_au;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_au = A_0;
		toolStripButton = this.m_au;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripSeparator bv()
	{
		return this.m_av;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(ToolStripSeparator A_0)
	{
		this.m_av = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton bw()
	{
		return this.m_aw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(ToolStripButton A_0)
	{
		EventHandler value = ak;
		ToolStripButton toolStripButton = this.m_aw;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_aw = A_0;
		toolStripButton = this.m_aw;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip bx()
	{
		return this.m_ax;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ToolTip A_0)
	{
		this.m_ax = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton by()
	{
		return this.m_ay;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(ToolStripButton A_0)
	{
		EventHandler value = a7;
		ToolStripButton toolStripButton = this.m_ay;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_ay = A_0;
		toolStripButton = this.m_ay;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton bz()
	{
		return this.m_az;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(ToolStripButton A_0)
	{
		EventHandler value = a0;
		ToolStripButton toolStripButton = this.m_az;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_az = A_0;
		toolStripButton = this.m_az;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem b0()
	{
		return this.m_a0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aj(ToolStripMenuItem A_0)
	{
		EventHandler value = aj;
		ToolStripMenuItem toolStripMenuItem = this.m_a0;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_a0 = A_0;
		toolStripMenuItem = this.m_a0;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem b1()
	{
		return this.m_a1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ak(ToolStripMenuItem A_0)
	{
		EventHandler value = ai;
		ToolStripMenuItem toolStripMenuItem = this.m_a1;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_a1 = A_0;
		toolStripMenuItem = this.m_a1;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem b2()
	{
		return this.m_a2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void al(ToolStripMenuItem A_0)
	{
		EventHandler value = ah;
		ToolStripMenuItem toolStripMenuItem = this.m_a2;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_a2 = A_0;
		toolStripMenuItem = this.m_a2;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem b3()
	{
		return this.m_a3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void am(ToolStripMenuItem A_0)
	{
		EventHandler value = ag;
		ToolStripMenuItem toolStripMenuItem = this.m_a3;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_a3 = A_0;
		toolStripMenuItem = this.m_a3;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual System.Windows.Forms.Timer b4()
	{
		return this.m_a4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(System.Windows.Forms.Timer A_0)
	{
		EventHandler value = a2;
		System.Windows.Forms.Timer timer = this.m_a4;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		this.m_a4 = A_0;
		timer = this.m_a4;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem b5()
	{
		return this.m_a5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void an(ToolStripMenuItem A_0)
	{
		EventHandler value = af;
		ToolStripMenuItem toolStripMenuItem = this.m_a5;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_a5 = A_0;
		toolStripMenuItem = this.m_a5;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
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
	internal virtual void b(Label A_0)
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
	internal virtual void c(Label A_0)
	{
		this.m_a7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem b8()
	{
		return this.m_a8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ao(ToolStripMenuItem A_0)
	{
		EventHandler value = ad;
		ToolStripMenuItem toolStripMenuItem = this.m_a8;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_a8 = A_0;
		toolStripMenuItem = this.m_a8;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem b9()
	{
		return this.m_a9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ap(ToolStripMenuItem A_0)
	{
		EventHandler value = ae;
		ToolStripMenuItem toolStripMenuItem = this.m_a9;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_a9 = A_0;
		toolStripMenuItem = this.m_a9;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripSeparator ca()
	{
		return this.m_ba;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(ToolStripSeparator A_0)
	{
		this.m_ba = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem cb()
	{
		return this.m_bb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aq(ToolStripMenuItem A_0)
	{
		EventHandler value = ab;
		ToolStripMenuItem toolStripMenuItem = this.m_bb;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_bb = A_0;
		toolStripMenuItem = this.m_bb;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem cc()
	{
		return this.m_bc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ar(ToolStripMenuItem A_0)
	{
		EventHandler value = aa;
		ToolStripMenuItem toolStripMenuItem = this.m_bc;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_bc = A_0;
		toolStripMenuItem = this.m_bc;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem cd()
	{
		return this.m_bd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void @as(ToolStripMenuItem A_0)
	{
		this.m_bd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem ce()
	{
		return this.m_be;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void at(ToolStripMenuItem A_0)
	{
		EventHandler value = z;
		ToolStripMenuItem toolStripMenuItem = this.m_be;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_be = A_0;
		toolStripMenuItem = this.m_be;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem cf()
	{
		return this.m_bf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void au(ToolStripMenuItem A_0)
	{
		EventHandler value = z;
		ToolStripMenuItem toolStripMenuItem = this.m_bf;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_bf = A_0;
		toolStripMenuItem = this.m_bf;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem cg()
	{
		return this.m_bg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void av(ToolStripMenuItem A_0)
	{
		this.m_bg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem ch()
	{
		return this.m_bh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aw(ToolStripMenuItem A_0)
	{
		EventHandler value = bg;
		ToolStripMenuItem toolStripMenuItem = this.m_bh;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_bh = A_0;
		toolStripMenuItem = this.m_bh;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem ci()
	{
		return this.m_bi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ax(ToolStripMenuItem A_0)
	{
		EventHandler value = bf;
		ToolStripMenuItem toolStripMenuItem = this.m_bi;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_bi = A_0;
		toolStripMenuItem = this.m_bi;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem cj()
	{
		return this.m_bj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ay(ToolStripMenuItem A_0)
	{
		EventHandler value = be;
		ToolStripMenuItem toolStripMenuItem = this.m_bj;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_bj = A_0;
		toolStripMenuItem = this.m_bj;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem ck()
	{
		return this.m_bk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void az(ToolStripMenuItem A_0)
	{
		EventHandler value = bd;
		ToolStripMenuItem toolStripMenuItem = this.m_bk;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_bk = A_0;
		toolStripMenuItem = this.m_bk;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem cl()
	{
		return this.m_bl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a0(ToolStripMenuItem A_0)
	{
		EventHandler value = y;
		ToolStripMenuItem toolStripMenuItem = this.m_bl;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_bl = A_0;
		toolStripMenuItem = this.m_bl;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem cm()
	{
		return this.m_bm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a1(ToolStripMenuItem A_0)
	{
		EventHandler value = x;
		ToolStripMenuItem toolStripMenuItem = this.m_bm;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_bm = A_0;
		toolStripMenuItem = this.m_bm;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStrip cn()
	{
		return this.m_bn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ToolStrip A_0)
	{
		this.m_bn = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton co()
	{
		return this.m_bo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(ToolStripButton A_0)
	{
		EventHandler value = u;
		ToolStripButton toolStripButton = this.m_bo;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_bo = A_0;
		toolStripButton = this.m_bo;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton cp()
	{
		return this.m_bp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(ToolStripButton A_0)
	{
		EventHandler value = s;
		ToolStripButton toolStripButton = this.m_bp;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_bp = A_0;
		toolStripButton = this.m_bp;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton cq()
	{
		return this.m_bq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(ToolStripButton A_0)
	{
		EventHandler value = o;
		ToolStripButton toolStripButton = this.m_bq;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_bq = A_0;
		toolStripButton = this.m_bq;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton cr()
	{
		return this.m_br;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(ToolStripButton A_0)
	{
		EventHandler value = n;
		ToolStripButton toolStripButton = this.m_br;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_br = A_0;
		toolStripButton = this.m_br;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton cs()
	{
		return this.m_bs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(ToolStripButton A_0)
	{
		EventHandler value = t;
		ToolStripButton toolStripButton = this.m_bs;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_bs = A_0;
		toolStripButton = this.m_bs;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton ct()
	{
		return this.m_bt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(ToolStripButton A_0)
	{
		EventHandler value = r;
		ToolStripButton toolStripButton = this.m_bt;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_bt = A_0;
		toolStripButton = this.m_bt;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripComboBox cu()
	{
		return this.m_bu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ToolStripComboBox A_0)
	{
		EventHandler value = m;
		ToolStripComboBox toolStripComboBox = this.m_bu;
		if (toolStripComboBox != null)
		{
			toolStripComboBox.SelectedIndexChanged -= value;
		}
		this.m_bu = A_0;
		toolStripComboBox = this.m_bu;
		if (toolStripComboBox != null)
		{
			toolStripComboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripComboBox cv()
	{
		return this.m_bv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ToolStripComboBox A_0)
	{
		EventHandler value = l;
		ToolStripComboBox toolStripComboBox = this.m_bv;
		if (toolStripComboBox != null)
		{
			toolStripComboBox.SelectedIndexChanged -= value;
		}
		this.m_bv = A_0;
		toolStripComboBox = this.m_bv;
		if (toolStripComboBox != null)
		{
			toolStripComboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripSeparator cw()
	{
		return this.m_bw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(ToolStripSeparator A_0)
	{
		this.m_bw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripLabel cx()
	{
		return this.m_bx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ToolStripLabel A_0)
	{
		this.m_bx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripLabel cy()
	{
		return this.m_by;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ToolStripLabel A_0)
	{
		this.m_by = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripSeparator cz()
	{
		return this.m_bz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(ToolStripSeparator A_0)
	{
		this.m_bz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripSeparator c0()
	{
		return this.m_b0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(ToolStripSeparator A_0)
	{
		this.m_b0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripLabel c1()
	{
		return this.m_b1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(ToolStripLabel A_0)
	{
		this.m_b1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton c2()
	{
		return this.m_b2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(ToolStripButton A_0)
	{
		EventHandler value = q;
		ToolStripButton toolStripButton = this.m_b2;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_b2 = A_0;
		toolStripButton = this.m_b2;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton c3()
	{
		return this.m_b3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(ToolStripButton A_0)
	{
		EventHandler value = p;
		ToolStripButton toolStripButton = this.m_b3;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_b3 = A_0;
		toolStripButton = this.m_b3;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripComboBox c4()
	{
		return this.m_b4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(ToolStripComboBox A_0)
	{
		EventHandler value = k;
		ToolStripComboBox toolStripComboBox = this.m_b4;
		if (toolStripComboBox != null)
		{
			toolStripComboBox.SelectedIndexChanged -= value;
		}
		this.m_b4 = A_0;
		toolStripComboBox = this.m_b4;
		if (toolStripComboBox != null)
		{
			toolStripComboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripSeparator c5()
	{
		return this.m_b5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(ToolStripSeparator A_0)
	{
		this.m_b5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton c6()
	{
		return this.m_b6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(ToolStripButton A_0)
	{
		EventHandler value = w;
		ToolStripButton toolStripButton = this.m_b6;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_b6 = A_0;
		toolStripButton = this.m_b6;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton c7()
	{
		return this.m_b7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(ToolStripButton A_0)
	{
		EventHandler value = v;
		ToolStripButton toolStripButton = this.m_b7;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_b7 = A_0;
		toolStripButton = this.m_b7;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem c8()
	{
		return this.m_b8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a2(ToolStripMenuItem A_0)
	{
		EventHandler value = j;
		ToolStripMenuItem toolStripMenuItem = this.m_b8;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_b8 = A_0;
		toolStripMenuItem = this.m_b8;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem c9()
	{
		return this.m_b9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a3(ToolStripMenuItem A_0)
	{
		EventHandler value = a9;
		ToolStripMenuItem toolStripMenuItem = this.m_b9;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_b9 = A_0;
		toolStripMenuItem = this.m_b9;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem da()
	{
		return this.m_ca;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a4(ToolStripMenuItem A_0)
	{
		this.m_ca = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem db()
	{
		return this.m_cb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a5(ToolStripMenuItem A_0)
	{
		EventHandler value = a8;
		ToolStripMenuItem toolStripMenuItem = this.m_cb;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_cb = A_0;
		toolStripMenuItem = this.m_cb;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem dc()
	{
		return this.m_cc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a6(ToolStripMenuItem A_0)
	{
		this.m_cc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel df()
	{
		return this.m_cd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_cd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel dg()
	{
		return this.m_ce;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
	{
		this.m_ce = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem dh()
	{
		return this.m_cf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a7(ToolStripMenuItem A_0)
	{
		EventHandler value = i;
		ToolStripMenuItem toolStripMenuItem = this.m_cf;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_cf = A_0;
		toolStripMenuItem = this.m_cf;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripSeparator di()
	{
		return this.m_cg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(ToolStripSeparator A_0)
	{
		this.m_cg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem dj()
	{
		return this.m_ch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a8(ToolStripMenuItem A_0)
	{
		this.m_ch = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem dk()
	{
		return this.m_ci;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a9(ToolStripMenuItem A_0)
	{
		this.m_ci = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem dl()
	{
		return this.m_cj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ba(ToolStripMenuItem A_0)
	{
		EventHandler value = h;
		ToolStripMenuItem toolStripMenuItem = this.m_cj;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_cj = A_0;
		toolStripMenuItem = this.m_cj;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem dm()
	{
		return this.m_ck;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bb(ToolStripMenuItem A_0)
	{
		EventHandler value = ar;
		ToolStripMenuItem toolStripMenuItem = this.m_ck;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_ck = A_0;
		toolStripMenuItem = this.m_ck;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem dn()
	{
		return this.m_cl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bc(ToolStripMenuItem A_0)
	{
		this.m_cl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem @do()
	{
		return this.m_cm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bd(ToolStripMenuItem A_0)
	{
		EventHandler value = c;
		ToolStripMenuItem toolStripMenuItem = this.m_cm;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_cm = A_0;
		toolStripMenuItem = this.m_cm;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem dp()
	{
		return this.m_cn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void be(ToolStripMenuItem A_0)
	{
		this.m_cn = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem dq()
	{
		return this.m_co;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bf(ToolStripMenuItem A_0)
	{
		EventHandler value = bc;
		ToolStripMenuItem toolStripMenuItem = this.m_co;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_co = A_0;
		toolStripMenuItem = this.m_co;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem dr()
	{
		return this.m_cp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bg(ToolStripMenuItem A_0)
	{
		EventHandler value = bb;
		ToolStripMenuItem toolStripMenuItem = this.m_cp;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_cp = A_0;
		toolStripMenuItem = this.m_cp;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem ds()
	{
		return this.m_cq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bh(ToolStripMenuItem A_0)
	{
		this.m_cq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem dt()
	{
		return this.m_cr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bi(ToolStripMenuItem A_0)
	{
		this.m_cr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem du()
	{
		return this.m_cs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bj(ToolStripMenuItem A_0)
	{
		EventHandler value = g;
		ToolStripMenuItem toolStripMenuItem = this.m_cs;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_cs = A_0;
		toolStripMenuItem = this.m_cs;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem dv()
	{
		return this.m_ct;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bk(ToolStripMenuItem A_0)
	{
		this.m_ct = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button dw()
	{
		return this.m_cu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		this.m_cu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripSeparator dx()
	{
		return this.m_cv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(ToolStripSeparator A_0)
	{
		this.m_cv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem dy()
	{
		return this.m_cw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bl(ToolStripMenuItem A_0)
	{
		this.m_cw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem dz()
	{
		return this.m_cx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bm(ToolStripMenuItem A_0)
	{
		this.m_cx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem d0()
	{
		return this.m_cy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bn(ToolStripMenuItem A_0)
	{
		this.m_cy = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripSeparator d1()
	{
		return this.m_cz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(ToolStripSeparator A_0)
	{
		this.m_cz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem d2()
	{
		return this.m_c0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void bo(ToolStripMenuItem A_0)
	{
		EventHandler value = b;
		ToolStripMenuItem toolStripMenuItem = this.m_c0;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_c0 = A_0;
		toolStripMenuItem = this.m_c0;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool MoveWindow(IntPtr A_0, int A_1, int A_2, int A_3, int A_4, bool A_5);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr FindWindow(string A_0, string A_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "FindWindow", SetLastError = true)]
	private static extern IntPtr b(string A_0, IntPtr A_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "FindWindow", SetLastError = true)]
	private static extern IntPtr b(IntPtr A_0, string A_1);

	[DllImport("GDI32.DLL", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool BitBlt(IntPtr A_0, int A_1, int A_2, int A_3, int A_4, IntPtr A_5, int A_6, int A_7, int A_8);

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer d3()
	{
		return this.m_dh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void b(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = b;
		System.Timers.Timer timer = this.m_dh;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		this.m_dh = A_0;
		timer = this.m_dh;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d d4()
	{
		return this.m_dk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void b(global::r.d A_0)
	{
		global::r.d.b a_ = d;
		this.m_dk?.e(a_);
		this.m_dk = A_0;
		this.m_dk?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d d5()
	{
		return this.m_dl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void c(global::r.d A_0)
	{
		global::r.d.b a_ = c;
		this.m_dl?.e(a_);
		this.m_dl = A_0;
		this.m_dl?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::i d6()
	{
		return this.m_dm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void b(global::i A_0)
	{
		global::i.a a_ = n;
		this.m_dm?.c(a_);
		this.m_dm = A_0;
		this.m_dm?.b(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d d7()
	{
		return this.m_dx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void d(global::r.d A_0)
	{
		this.m_dx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d d8()
	{
		return this.m_dy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void e(global::r.d A_0)
	{
		this.m_dy = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer d9()
	{
		return this.m_dz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void c(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = c;
		System.Timers.Timer timer = this.m_dz;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		this.m_dz = A_0;
		timer = this.m_dz;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d ea()
	{
		return this.m_d0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void f(global::r.d A_0)
	{
		this.m_d0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d eb()
	{
		return this.m_d1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void g(global::r.d A_0)
	{
		global::r.d.b a_ = b;
		this.m_d1?.e(a_);
		this.m_d1 = A_0;
		this.m_d1?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d ec()
	{
		return this.m_d7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void h(global::r.d A_0)
	{
		global::r.d.b a_ = f;
		this.m_d7?.e(a_);
		this.m_d7 = A_0;
		this.m_d7?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual global::r.d ed()
	{
		return this.m_d9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void i(global::r.d A_0)
	{
		global::r.d.b a_ = e;
		this.m_d9?.e(a_);
		this.m_d9 = A_0;
		this.m_d9?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual c5 ee()
	{
		return this.m_ej;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void b(c5 A_0)
	{
		this.m_ej = A_0;
	}

	[SpecialName]
	private bool aj()
	{
		return this.m_ek > 0;
	}

	private void ai()
	{
		checked
		{
			this.m_ek++;
		}
	}

	private void ah()
	{
		checked
		{
			this.m_ek--;
		}
	}

	public void b(d A_0, ref bool A_1)
	{
		if (global::c.d().t())
		{
			global::c.d().ab();
			this.m_d8 = A_0;
			this.m_dn = true;
			Show();
		}
		else
		{
			b a_ = new b(null, ec(), null);
			A_0(a_, A_1: false, "Hardware access denied - Only one program may access measurement system hardware.", null);
			A_1 = true;
		}
	}

	private void ag()
	{
		if (this.m_eh > -1)
		{
			ar().SelectedIndex = this.m_eh;
		}
	}

	public void c(string A_0)
	{
		if (base.InvokeRequired)
		{
			e method = c;
			Invoke(method, A_0);
			return;
		}
		foreach (TabPage tabPage in ar().TabPages)
		{
			foreach (Control control in tabPage.Controls)
			{
				if (control is f4 && Operators.CompareString(((f4)control).hb(), A_0, TextCompare: false) == 0)
				{
					ar().SelectTab(tabPage);
					return;
				}
			}
		}
	}

	public void ef()
	{
		foreach (TabPage tabPage in ar().TabPages)
		{
			foreach (Control control in tabPage.Controls)
			{
				if (control is f3 && control != o())
				{
					((f3)control).by();
					return;
				}
			}
		}
	}

	public void b(Guid A_0)
	{
		if (base.InvokeRequired)
		{
			Invoke(new f(b), A_0);
			return;
		}
		foreach (TabPage tabPage in ar().TabPages)
		{
			foreach (Control control in tabPage.Controls)
			{
				if (control is d6 && ((d6)control).bu() == A_0)
				{
					ar().SelectTab(tabPage);
					return;
				}
			}
		}
	}

	private void b(ref long A_0)
	{
		if (A_0 == 0L)
		{
			ae();
		}
		else
		{
			af();
		}
	}

	private void af()
	{
		try
		{
			if ((o() == null) & this.m_c2.ui())
			{
				EventArgs a_ = new EventArgs();
				this.m_eh = ar().TabPages.Count;
				ar().TabPages.Insert(this.m_eh, this.m_ei);
				((f3)this.m_ei.Controls[0]).a(this.m_dg);
				bl(this, a_);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			this.m_c3.c(fz.b.b, "Exception caught in AddPrecisionTabIfNotPresent(). ", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void ae()
	{
		try
		{
			if ((o() != null) & this.m_c2.ui())
			{
				EventArgs a_ = new EventArgs();
				this.m_eh = -1;
				ar().TabPages.Remove(this.m_ei);
				((f3)this.m_ei.Controls[0]).bv();
				bl(this, a_);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			this.m_c3.c(fz.b.b, "Exception caught in RemovePrecisionTabIfPresent(). ", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void bo(object A_0, EventArgs A_1)
	{
		if (this.m_ec)
		{
			return;
		}
		try
		{
			if (ex == null)
			{
				ex = new FileSystemWatcher(i3.g(), "*.fiwan");
				ex.Created += b;
				ex.EnableRaisingEvents = true;
			}
			f4 f10 = null;
			foreach (TabPage tabPage in ar().TabPages)
			{
				foreach (Control control in tabPage.Controls)
				{
					if (control is f4)
					{
						f10 = (f4)control;
						if (f10.hr())
						{
							tabPage.Select();
							f10.hs();
							return;
						}
					}
				}
			}
			this.m_du = false;
			ad();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			if (this.m_c3 != null)
			{
				this.m_c3.c(fz.b.b, "Exception caught in MainForm_Activated(). ", a_);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void bn(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_du = true;
			ad();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			if (this.m_c3 != null)
			{
				this.m_c3.c(fz.b.b, "Exception caught in MainForm_Deactivate(). ", a_);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, FileSystemEventArgs A_1)
	{
		try
		{
			if (base.InvokeRequired)
			{
				ex.EnableRaisingEvents = false;
				ex.Dispose();
				ex = null;
				FileSystemEventHandler method = b;
				BeginInvoke(method, A_0, A_1);
				return;
			}
			if (this.m_ec)
			{
				if (ev != null)
				{
					File.Delete(ev);
					ev = null;
				}
				return;
			}
			foreach (TabPage tabPage in ar().TabPages)
			{
				if (tabPage.Controls.Count > 0 && tabPage.Controls[0] is f4)
				{
					((f4)tabPage.Controls[0]).h7();
				}
			}
			this.m_c2.tb();
			if (ev != null)
			{
				File.Delete(ev);
				ev = null;
			}
			string A_2 = null;
			string A_3 = null;
			i3.a(A_1.FullPath, ref A_2, ref A_3);
			global::fe.b(this.m_c3, "Another instance was created by user " + A_2 + "\\" + A_3 + ".\r\nAs a result, current instance has to release all hardware.", "Information", i6.a(this));
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c3.c(fz.b.b, "MainForm..mWaitingAccountFileWatcher_Created", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ad()
	{
		if (this.m_c3 == null || ar() == null || ar().SelectedTab == null)
		{
			return;
		}
		Guid guid = default(Guid);
		if (ar().SelectedTab.Controls[0] is f4)
		{
			guid = ((f4)ar().SelectedTab.Controls[0]).hc();
		}
		foreach (TabPage tabPage in ar().TabPages)
		{
			object obj = tabPage.Controls[0];
			if (obj is f4)
			{
				f4 f10 = (f4)obj;
				if (!this.m_du && f10.hc() == guid)
				{
					f10.hy();
				}
				else
				{
					f10.hz();
				}
				f10 = null;
			}
		}
	}

	private static void b(StringCollection A_0, StringCollection A_1)
	{
		for (int num = A_0.Count; num < A_1.Count; num = checked(num + 1))
		{
			A_0.Add(A_1[num]);
		}
	}

	public static void b(bool A_0, bool A_1)
	{
		Version version = new Version(global::e.a().LastAssyVer);
		Version version2 = Assembly.GetExecutingAssembly().GetName().Version;
		if (version2 != version && global::e.a().Upgraded)
		{
			global::e.a().Reset();
		}
		if (!global::e.a().Upgraded || A_1)
		{
			StringCollection a_ = global::e.a().GraphMeasXMin;
			StringCollection a_2 = global::e.a().GraphMeasXMax;
			StringCollection a_3 = global::e.a().GraphMeasAutoScaleXMax;
			StringCollection a_4 = global::e.a().GraphMeasAutoScaleXMin;
			StringCollection a_5 = global::e.a().GraphMeasShowGrid;
			StringCollection a_6 = global::e.a().GraphMeasYLabelPercent;
			StringCollection a_7 = global::e.a().GraphMeasYMin;
			StringCollection a_8 = global::e.a().GraphMeasYMax;
			StringCollection a_9 = global::e.a().GraphMeasY2Min;
			StringCollection a_10 = global::e.a().GraphMeasY2Max;
			StringCollection a_11 = global::e.a().GraphMeasDotSize;
			StringCollection a_12 = global::e.a().GraphMeasAutoScaleYMax;
			StringCollection a_13 = global::e.a().GraphMeasAutoScaleYMin;
			StringCollection a_14 = global::e.a().GraphMeasAutoScaleY2Max;
			StringCollection a_15 = global::e.a().GraphMeasAutoScaleY2Min;
			StringCollection a_16 = global::e.a().GraphMeasCursorShowXValue;
			StringCollection a_17 = global::e.a().GraphMeasCursorShowVertLine;
			StringCollection a_18 = global::e.a().GraphMeasCursorShowDot;
			if (!A_1 && (f1.fz.f() || A_0))
			{
				f2 obj = f1.fz;
				bool A_2 = false;
				obj.c(ref A_2);
			}
			global::e.a().Upgrade();
			b(global::e.a().GraphMeasXMin, a_);
			b(global::e.a().GraphMeasXMax, a_2);
			b(global::e.a().GraphMeasAutoScaleXMax, a_3);
			b(global::e.a().GraphMeasAutoScaleXMin, a_4);
			b(global::e.a().GraphMeasShowGrid, a_5);
			b(global::e.a().GraphMeasYLabelPercent, a_6);
			b(global::e.a().GraphMeasYMin, a_7);
			b(global::e.a().GraphMeasYMax, a_8);
			b(global::e.a().GraphMeasY2Min, a_9);
			b(global::e.a().GraphMeasY2Max, a_10);
			b(global::e.a().GraphMeasDotSize, a_11);
			b(global::e.a().GraphMeasAutoScaleYMax, a_12);
			b(global::e.a().GraphMeasAutoScaleYMin, a_13);
			b(global::e.a().GraphMeasAutoScaleY2Max, a_14);
			b(global::e.a().GraphMeasAutoScaleY2Min, a_15);
			b(global::e.a().GraphMeasCursorShowXValue, a_16);
			b(global::e.a().GraphMeasCursorShowVertLine, a_17);
			b(global::e.a().GraphMeasCursorShowDot, a_18);
			if (global::e.a().Upgraded)
			{
				global::e.a().ShowSpectrumColorDefaultHasBeenSet = true;
			}
			if (global::e.a().SpectrumColorLumValue < 10f)
			{
				global::e.a().SpectrumColorLumValue = 10f;
			}
			global::e.a().Upgraded = true;
			global::e.a().LastAssyVer = version2.ToString();
			global::e.a().Save();
			if (f1.fz.f() || global::e.a().ShareSettingsWithSelectedUsers)
			{
				f2 obj2 = f1.fz;
				bool A_2 = false;
				obj2.d(ref A_2);
			}
		}
		else
		{
			global::e.a().LastAssyVer = version2.ToString();
		}
	}

	private void bm(object A_0, EventArgs A_1)
	{
		string A_2 = "";
		try
		{
			et = Environment.UserDomainName;
			eu = Environment.UserName;
			ev = i3.f(et, eu);
			ew = i3.e(et, eu);
			File.Delete(ev);
			b(ref this.m_ep, ref eq, ref er, ref es);
			if (this.m_ep)
			{
				File.Delete(eq);
			}
			if (!File.Exists(ev))
			{
				i3.d(ev, et, eu);
			}
			string A_3 = null;
			this.m_c2 = new f1(ref this.m_c3, ref A_3);
			global::c.d().c(this.m_c3);
			if (!this.m_dn && !string.IsNullOrEmpty(A_3))
			{
				dy obj = new dy();
				SystemSounds.Exclamation.Play();
				A_3 = "Note: The problems noted below will not cause software malfunctions.\r\n\r\nWarning(s) are as follows:\r\n" + A_3;
				A_3 = Strings.Replace(A_3, "\\", "\\\\");
				obj.a(A_3, "Compatibility Warning", A_2: false);
			}
			b(new global::r.d());
			this.m_dj = new gh();
			h(new global::r.d());
			i(new global::r.d());
			this.m_df = new Collection<go>();
			this.m_df.Insert(0, new go(go.a.a));
			this.m_df.Insert(1, new go(go.a.b));
			this.m_df.Insert(2, new go(go.a.c));
			this.m_df.Insert(3, new go(go.a.d));
			this.m_df.Insert(4, new go(go.a.e));
			this.m_df.Insert(5, new go(go.a.f));
			this.m_dg = new Collection<gn>();
			this.m_dg.Insert(0, new gn(this.m_df[0], gn.a.a));
			this.m_dg.Insert(1, new gn(this.m_df[1], gn.a.b));
			this.m_dg.Insert(2, new gn(this.m_df[0], gn.a.c));
			this.m_dg.Insert(3, new gn(this.m_df[2], gn.a.d));
			this.m_dg.Insert(4, new gn(this.m_df[3], gn.a.e));
			this.m_dg.Insert(5, new gn(this.m_df[4], gn.a.f));
			gt a_ = null;
			Text = global::c.d().Info.Title;
			ay().Text = string.Format(ay().Text, global::c.d().Info.Title);
			cn().Left = checked(base.ClientRectangle.Width - cn().Width);
			this.m_d4 = new gq();
			this.m_d4.m();
			string A_4;
			if (this.m_d4.j() != null && !this.m_dn)
			{
				this.m_c3.c(fz.b.a, "Failure attempting to start up access control", this.m_d4.j());
				fz a_2 = this.m_c3;
				A_4 = "ErrAccessControlStartup";
				global::fe.b(a_2, hu.a(ref A_4), i6.a(this));
			}
			global::r.d.a.b a_3 = (this.m_dn ? global::r.d.a.b.b : global::r.d.a.b.a);
			if (global::c.d().x())
			{
				if (!string.IsNullOrEmpty(global::c.d().w()))
				{
					Text = Text.Replace("FIL", global::c.d().w());
				}
			}
			else
			{
				Text = Text.Replace("FIL", "  ");
			}
			global::r.c a_4 = null;
			f1 obj2 = this.m_c2;
			A_4 = "SystemInitialization";
			if (obj2.m2(a_, hu.a(ref A_4), ref A_2, ec(), a_4, a_3) != global::ce.ErrPublic.None)
			{
				Interaction.MsgBox("Error Initializing the Application! Error is: " + A_2);
			}
			this.m_c6 = new Collection();
			PageSettings defaultPageSettings = a4().DefaultPageSettings;
			if (!global::e.a().PaperOrientationUpgraded)
			{
				global::e.a().PaperOrientationLandscape = defaultPageSettings.Landscape;
				global::e.a().PaperOrientationUpgraded = true;
			}
			defaultPageSettings.Landscape = global::e.a().PaperOrientationLandscape;
			defaultPageSettings.Margins.Left = 15;
			defaultPageSettings.Margins.Right = 15;
			defaultPageSettings.Margins.Top = 15;
			defaultPageSettings.Margins.Bottom = 15;
			defaultPageSettings = null;
			this.m_el = new fm();
			if (global::eq.a != null)
			{
				global::eq.a.Close();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_ea = true;
			this.m_eb = ex3;
			ProjectData.ClearProjectError();
		}
	}

	private void b(ref bool A_0, ref string A_1, ref string A_2, ref string A_3)
	{
		A_0 = false;
		A_1 = null;
		A_2 = null;
		A_3 = null;
		IEnumerable<string> enumerable = Directory.EnumerateFiles(i3.g(), "*.fiaan");
		foreach (string item in enumerable)
		{
			bool flag = false;
			try
			{
				if (!File.Exists(ew))
				{
					i3.d(ew, et, eu);
				}
				flag = true;
				bool flag2 = false;
				int num = 0;
				do
				{
					Thread.Sleep(200);
					if (!File.Exists(item))
					{
						flag2 = true;
						break;
					}
					num = checked(num + 1);
				}
				while (num <= 9);
				if (!flag2)
				{
					A_0 = true;
					A_1 = item;
					i3.a(item, ref A_2, ref A_3);
				}
				else
				{
					Thread.Sleep(2000);
				}
			}
			finally
			{
				if (flag)
				{
					File.Delete(ew);
				}
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public bool eg()
	{
		return ey;
	}

	[SpecialName]
	[CompilerGenerated]
	public void c(bool A_0)
	{
		ey = A_0;
	}

	public void f(global::r.d.a A_0)
	{
		Collection<gu.a> A_1 = null;
		f4 f10 = null;
		bool flag = false;
		ew.a a10 = global::ew.a.a;
		string text = null;
		global::r.e.a.a a11 = null;
		string a_ = null;
		string text2 = "Hardware or firmware problem exists.\r\nSoftware is running in a special mode because InternalFirmware license is present.\r\nA user without both Internal and InternalFirmware licenses would receive an error message at startup instead.\r\n\r\n";
		checked
		{
			bool a_2 = default(bool);
			try
			{
				if (base.InvokeRequired)
				{
					global::r.d.b method = f;
					BeginInvoke(method, A_0);
				}
				else
				{
					if (!base.IsHandleCreated)
					{
						return;
					}
					ez = false;
					ix.b b10 = new ix.b();
					ix.b b11 = new ix.b();
					this.m_en = false;
					if (this.m_c2.u2())
					{
						this.m_c2.u6();
					}
					global::r.e.a a12 = (global::r.e.a)A_0;
					bool flag2 = default(bool);
					bool flag3 = default(bool);
					if (a12.d != null)
					{
						a11 = (global::r.e.a.a)a12.d;
						text = string.Empty;
						int num = a11.a.Count - 1;
						for (int num2 = 0; num2 <= num; num2++)
						{
							global::r.e.a.b b12 = a11.a[num2];
							switch (b12)
							{
							case global::r.e.a.b.l:
								a_2 = true;
								if (!string.IsNullOrEmpty(text))
								{
									text += "\r\n\r\n";
								}
								text += global::r.e.a.a6(b12, this.m_c2.ul());
								break;
							case global::r.e.a.b.m:
								if (!string.IsNullOrEmpty(text))
								{
									text += "\r\n\r\n";
								}
								text += a11.b[num2];
								break;
							case global::r.e.a.b.ak:
							case global::r.e.a.b.al:
							case global::r.e.a.b.am:
								if (!string.IsNullOrEmpty(text))
								{
									text += "\r\n\r\n";
								}
								text += global::r.e.a.a6(b12, this.m_c2.ul());
								text = text + "\r\n\r\n" + a11.b[num2];
								break;
							case global::r.e.a.b.an:
								if (this.m_c2.ul())
								{
									if (!string.IsNullOrEmpty(text))
									{
										text += "\r\n\r\n";
									}
									text += a11.b[num2];
								}
								else
								{
									flag2 = true;
								}
								break;
							case global::r.e.a.b.ao:
							case global::r.e.a.b.ap:
							case global::r.e.a.b.aq:
								if (!string.IsNullOrEmpty(text))
								{
									text += "\r\n\r\n";
								}
								text += global::r.e.a.a6(b12, this.m_c2.ul());
								text = text + "\r\n\r\n" + a11.b[num2];
								break;
							default:
								if (!string.IsNullOrEmpty(text))
								{
									text += "\r\n\r\n";
								}
								text += global::r.e.a.a6(b12, this.m_c2.ul());
								break;
							}
						}
						if (!string.IsNullOrEmpty(text))
						{
							flag3 = true;
						}
					}
					a12 = null;
					if (A_0.a == global::r.d.a.a.a)
					{
						if (ar().SelectedIndex == -1)
						{
							string A_2 = null;
							flag = true;
							this.m_c4 = new gr(this.m_c3, this.m_c2.ug(), this.m_c2.ui(), this.m_c2.u8(), ref A_2);
							this.m_c5 = new ge();
							if (!this.m_dn && !string.IsNullOrEmpty(A_2) && this.m_c2.ui())
							{
								dy obj = new dy();
								SystemSounds.Exclamation.Play();
								A_2 = A_2.Replace("\\", "\\\\");
								A_2 = "Note: This warning dialog is only displayed for Filmetrics Internal Users. The problems noted below will not cause software malfunctions. Rather, this warning message is an indication that there are conflicts among the multiple files in the material library.\r\n\r\nWarning(s) are as follows:\r\n" + A_2;
								obj.a(A_2, "Material Library Warnings", A_2: false);
							}
						}
						if (this.m_dc == null)
						{
							this.m_dc = new hs();
							this.m_dc.b(v);
						}
						f3 f11 = p();
						bool flag4 = default(bool);
						bool flag5 = default(bool);
						while (!flag4)
						{
							foreach (TabPage tabPage14 in ar().TabPages)
							{
								if (tabPage14 == ar().SelectedTab && !flag5)
								{
									continue;
								}
								Control control = tabPage14.Controls[0];
								if (control is f4)
								{
									f4 f12 = (f4)control;
									f12.j((ce.a)b);
									f12.j((f4.e)d);
									f12.j((f4.i)b);
									f12.j((f4.j)b);
									f12.j((f4.k)b);
									f12.j((f4.l)b);
									if (f12.hg() != null)
									{
										f12.hg().m(b);
									}
									f12.i(f11.b1());
									f12.i(f11.b2());
									f12.i(f11.b0());
									f12.g9();
									f12 = null;
									ar().TabPages.Remove(tabPage14);
								}
								else if (control is by)
								{
									((by)control).b8();
									_ = null;
									ar().TabPages.Remove(tabPage14);
								}
								else if (control is d6)
								{
									((d6)control).bt();
									_ = null;
									ar().TabPages.Remove(tabPage14);
								}
							}
							if (flag5)
							{
								flag4 = true;
							}
							else
							{
								flag5 = true;
							}
						}
						this.m_c6.Clear();
						if (this.m_c2.m2(ref A_1) == global::ce.ErrPublic.None)
						{
							if (A_1.Count <= 0)
							{
								ref fz a_3 = ref this.m_c3;
								string A_3 = "ErrConfiguration";
								if (global::fe.b(ref a_3, hu.a(ref A_3), "ErrorTitle", "RestoreDefaultConfig", "ExitWithNoChanges", i6.a(this)))
								{
									this.m_c2.t9();
								}
								Close();
								return;
							}
							bool flag6 = false;
							bool flag8 = default(bool);
							int num5 = default(int);
							ew.a a_4 = default(ew.a);
							foreach (gu.a item in A_1)
							{
								bool flag7 = false;
								foreach (TabPage tabPage15 in ar().TabPages)
								{
									Control control2 = tabPage15.Controls[0];
									if (control2 is f4)
									{
										flag8 = true;
										f10 = (f4)control2;
										if (f10.hc() == item.a)
										{
											tabPage15.Text = item.c;
											flag7 = true;
											break;
										}
									}
								}
								if (!flag7)
								{
									gy obj2 = this.m_c2.t7(item.a.ToString());
									bool flag9 = obj2.ak().Count > 0 && this.m_c2.ub(item.a);
									bool flag10 = obj2.aj().Count > 0 && this.m_c2.uc(item.a);
									_ = null;
									if (flag9 || (!flag10 && (this.m_c2.ui() || this.m_c2.um())))
									{
										TabPage tabPage3;
										unchecked
										{
											if (!flag6)
											{
												ew.a a13 = this.m_c2.qh(item.a.ToString());
												if (global::e.a().OemSettingsCode != (int)a13 && a13 == global::ew.a.c)
												{
													global::e.a().DisplaySignificantDigits = 3;
													global::e.a().BaselineRemindTimeMinutes = 720f;
													global::e.a().OemSettingsCode = (int)a13;
													global::e.a().UserSuppliedReflectance = 1.0;
													global::e.a().SampleReflOption = 2;
												}
												flag6 = true;
											}
											flag8 = true;
											f10 = new f4(item.a, this.m_c2, this.m_c3, this.m_dc, this.m_dg, this.m_c4, this.m_c5, this.m_c2.qh(item.a.ToString()), this.m_dj, this.m_d4, this.m_c2.t7(item.a.ToString()).ah(), this.m_do, this.m_el, d6(), this.m_eo);
											tabPage3 = new TabPage();
											tabPage3.Text = item.c;
											tabPage3.Controls.Add(f10);
										}
										if (p() == null)
										{
											ar().TabPages.Insert(ar().TabPages.Count, tabPage3);
										}
										else
										{
											ar().TabPages.Insert(ar().TabPages.Count - 1, tabPage3);
										}
										f10.z(this.m_c2.v4(item.a));
										f10.ab(this.m_c2.v8(item.a));
										f10.aa(this.m_c2.wb(item.a));
										this.m_c6.Add(f10.hu(), item.a.ToString());
										f10.i((f4.e)d);
										f10.i((ce.a)b);
										f10.i((f4.i)b);
										f10.i((f4.j)b);
										f10.i((f4.k)b);
										f10.i((f4.l)b);
										fl fl2 = f10.hi();
										bool flag11 = false;
										hg hg2 = this.m_c2.wq(item.a);
										if (hg2.cb())
										{
											int num3 = hg2.dz();
											for (int num4 = 1; num4 <= num3; num4++)
											{
												if (hg2.b3(num4).fu() && hg2.cj() != 0.0 && hg2.ck() != 0.0)
												{
													flag11 = true;
													break;
												}
											}
										}
										hg2 = null;
										fr fr2 = fl2.gi().a2();
										if (!flag11 && this.m_c2.uy() < this.m_c2.u0() && (fr2.ap() < Math.Floor(this.m_c2.uy()) || fr2.aq() > Math.Ceiling(this.m_c2.u0()) || jf.a((float)fr2.ap(), (float)fr2.aq())))
										{
											fr2.am(this.m_c2.uy());
											fr2.an(this.m_c2.u0());
										}
										fr2 = null;
									}
									else
									{
										f10 = null;
									}
									if (item.d.c() || item.d.d())
									{
										by obj3 = new by(item.a, this.m_c2, this.m_c3, this.m_dc, this.m_dg, a_4, this.m_d4, this.m_el);
										obj3.g(this.m_c2.v4(item.a));
										TabPage tabPage4 = new TabPage();
										obj3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
										tabPage4.Text = "Vs Time";
										tabPage4.Controls.Add(obj3);
										_ = null;
										if (f10 != null)
										{
											num5 = 1;
										}
										if (p() == null)
										{
											ar().TabPages.Insert(ar().TabPages.Count - num5, tabPage4);
										}
										else
										{
											ar().TabPages.Insert(ar().TabPages.Count - 1 - num5, tabPage4);
										}
									}
								}
								ez = ez || this.m_c2.tj(item.a);
							}
							this.m_c2.p9(global::r.d.a.b.a);
							Collection<TabPage> collection = new Collection<TabPage>();
							foreach (TabPage tabPage16 in ar().TabPages)
							{
								if (tabPage16.Controls[0] is d6)
								{
									collection.Add(tabPage16);
								}
							}
							foreach (gx item2 in this.m_c2.th())
							{
								d6 d10 = null;
								foreach (TabPage tabPage17 in ar().TabPages)
								{
									Control control3 = tabPage17.Controls[0];
									if (control3 is d6)
									{
										d6 d11 = (d6)control3;
										if (d11.bu() == item2.n())
										{
											d10 = d11;
											collection.Remove(tabPage17);
											d11.bt();
											break;
										}
									}
								}
								if (d10 != null)
								{
									continue;
								}
								TabPage tabPage7 = new TabPage();
								f4 a_5 = c(item2.o[0]);
								d10 = new d6(item2.n(), this.m_c2, this.m_c3, a_5, this.m_dc, this.m_c4, this.m_c2.qh(item2.o[0].ToString()), this.m_d4, bx());
								MinimumSize = new Size(1022, 833);
								tabPage7.Text = item2.q;
								tabPage7.Controls.Add(d10);
								d10.Dock = DockStyle.Fill;
								int num6 = ar().TabPages.Count - 1;
								for (int num7 = 0; num7 <= num6; num7++)
								{
									Control control4 = ar().TabPages[num7].Controls[0];
									if (control4 is f4 && ((f4)control4).hc() == item2.o[0])
									{
										ar().TabPages.Insert(num7, tabPage7);
										break;
									}
								}
								ce.a a_6 = b;
								d10.c(a_6);
								f4.e a_7 = c;
								d10.c(a_7);
							}
							if (ar().TabCount > 0)
							{
								bool flag12 = default(bool);
								if (ar().TabPages[0].Controls[0] is f4)
								{
									a10 = this.m_c2.qh(((f4)ar().TabPages[0].Controls[0]).hb());
									flag12 = true;
								}
								int num8 = ar().TabCount - 1;
								for (int num9 = 1; num9 <= num8; num9++)
								{
									if (!(ar().TabPages[num9].Controls[0] is f4))
									{
										continue;
									}
									f4 f13 = (f4)ar().TabPages[num9].Controls[0];
									if (this.m_c2.uh(f13.hc()))
									{
										a_4 = this.m_c2.qh(((f4)ar().TabPages[num9].Controls[0]).hb());
										if (flag12)
										{
											if (a_4 < a10)
											{
												a10 = a_4;
											}
										}
										else
										{
											a10 = a_4;
											flag12 = true;
										}
									}
									f13 = null;
								}
							}
							if (global::c.d().x())
							{
								if (global::c.d().v() != a10)
								{
									Text = Text.Replace(global::c.d().w(), global::a.c(a10));
								}
							}
							else if (Text.Contains("   "))
							{
								Text = Text.Replace("   ", " " + global::a.c(a10));
							}
							else
							{
								Text = Text.Replace("  ", global::a.c(a10));
							}
							global::c.d().j(a10);
							f3 f14 = p();
							if (f14 == null && flag8)
							{
								this.m_dw = new c();
								this.m_dw.b(e);
								f14 = new f3(ref this.m_c3, this.m_c2, this.m_dg, a10, this.m_dj, this.m_d4, A_6: true, this.m_do, this.m_dw);
								f3 obj4 = f14;
								string A_3 = "HistoryPanelName";
								obj4.Name = hu.a(ref A_3);
								f14.c(this.m_c2.wq(eh()).bz((eo.a)null));
								f14.b(this.m_c2.wq(eh()).by((eo.a)null));
								TabPage tabPage8 = new TabPage();
								A_3 = "HistoryPanelName";
								tabPage8.Text = hu.a(ref A_3);
								tabPage8.Controls.Add(f14);
								ar().TabPages.Insert(ar().TabPages.Count, tabPage8);
							}
							if (f14 != null)
							{
								foreach (TabPage tabPage18 in ar().TabPages)
								{
									if (!(tabPage18.Controls[0] is f4))
									{
										continue;
									}
									f4 f15 = (f4)tabPage18.Controls[0];
									if (f15 != null)
									{
										f15.j(f14.b1());
										f15.j(f14.b2());
										if (this.m_c2.uj())
										{
											f15.j(f14.b0());
										}
										f15.m(f14.bx());
									}
								}
								f14.b5();
								foreach (gu.a item3 in A_1)
								{
									f14.b(this.m_c2.v8(item3.a));
								}
								if (o() == null && this.m_ei == null)
								{
									f3 f16 = new f3(ref this.m_c3, this.m_c2, this.m_dg, a10, this.m_dj, this.m_d4, A_6: false, this.m_do, new c());
									string A_3 = "PrecisionResultsPanelName";
									f16.Name = hu.a(ref A_3);
									foreach (gu.a item4 in A_1)
									{
										f16.b(this.m_c2.v9(item4.a));
									}
									f16.c(this.m_c2.wq(eh()).bz((eo.a)null));
									f16.b(this.m_c2.wq(eh()).by((eo.a)null));
									this.m_ei = new TabPage();
									TabPage tabPage10 = this.m_ei;
									A_3 = "PrecisionResultsPanelName";
									tabPage10.Text = hu.a(ref A_3);
									this.m_ei.Controls.Add(f16);
									this.m_ef = new d1();
									this.m_ef.e(ag);
									this.m_eg = new d1();
									this.m_eg.e((d1.b)b);
									f16.a(this.m_eg);
									foreach (TabPage tabPage19 in ar().TabPages)
									{
										if (tabPage19.Controls[0] is f4)
										{
											f4 f17 = (f4)tabPage19.Controls[0];
											if (f17 != null)
											{
												f17.j(f16.b1());
												f17.j(f16.b2());
												f17.i(f16.bw());
												f17.j(this.m_ef);
												f17.k(this.m_eg);
												f17.l(this.m_eg);
											}
										}
									}
								}
							}
							this.m_en = true;
							ar().SelectedIndex = 0;
							Collection<TabPage> collection2 = new Collection<TabPage>();
							Guid guid = default(Guid);
							foreach (TabPage tabPage20 in ar().TabPages)
							{
								Control control5 = tabPage20.Controls[0];
								bool flag13 = false;
								if (control5 is f4)
								{
									flag13 = true;
									guid = ((f4)control5).hc();
								}
								if (!flag13)
								{
									continue;
								}
								bool flag14 = false;
								foreach (gu.a item5 in A_1)
								{
									if (guid == item5.a)
									{
										flag14 = true;
										break;
									}
								}
								if (!flag14)
								{
									collection2.Add(tabPage20);
									this.m_c6.Remove(guid.ToString());
								}
							}
							foreach (TabPage item6 in collection2)
							{
								ar().TabPages.Remove(item6);
							}
							foreach (TabPage item7 in collection)
							{
								ar().TabPages.Remove(item7);
							}
							if (flag)
							{
								if (ar().SelectedIndex == 0)
								{
									ax(ar(), new EventArgs());
								}
								else
								{
									ar().SelectedIndex = 0;
								}
								if (!eg())
								{
									base.WindowState = FormWindowState.Maximized;
								}
								this.m_dc.b();
								de = this.m_c2.u8();
								this.m_c2.tf("");
								if (this.m_d8 != null)
								{
									b a_8 = new b(this.m_c2, ec(), de);
									this.m_d8(a_8, a_2, null, this.m_c4);
								}
							}
						}
						else
						{
							string text3 = "Exiting Software due to error or no systems connected (GetMeasModuleInfoList Error).";
							if (!string.IsNullOrEmpty(A_0.b))
							{
								text3 = text3 + "\r\n" + A_0.b;
							}
							this.m_c3.c(fz.b.a, text3);
							if (this.m_dn)
							{
								if (this.m_d8 != null)
								{
									b a_9 = new b(this.m_c2, ec(), de);
									this.m_d8(a_9, a_2, text3, this.m_c4);
								}
							}
							else
							{
								i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.SystemInitializationFinished(1)", text3);
								new bn().a("An error has occurred during software initialization.\r\nIf this error happens repeatedly, you may wish to consider\r\nreverting the settings.", A_1: true);
							}
							Close();
						}
						if (flag3 && A_0.a8() == global::r.d.a.b.a)
						{
							ref fz a_10 = ref this.m_c3;
							string a_11 = text;
							Point A_4 = i6.a(this);
							global::fe.b(ref a_10, a_11, ref A_4);
						}
						if (this.m_c2.tf() || (this.m_c2.tg() && this.m_c2.ui() && this.m_c2.ul()))
						{
							ref fz a_12 = ref this.m_c3;
							string a_13 = text2 + "Error is:\r\n" + global::r.e.a.a6(this.m_c2.te(), this.m_c2.ul());
							Point A_4 = i6.a(this);
							global::fe.b(ref a_12, a_13, ref A_4);
						}
						if (!this.m_dn && flag2 && A_0.a8() == global::r.d.a.b.a)
						{
							i5.a(this.m_c3, this.m_c2, i6.a(this), "MainForm.SystemInitializationFinished(3)", null, a_, null);
						}
						if (this.m_c2.u2() && !this.m_c2.u3())
						{
							string text4 = global::c.d().Info.DirectoryPath + "\\ExampleSpectra\\";
							if (global::c.e().FileSystem.DirectoryExists(text4))
							{
								FileInfo[] files = new DirectoryInfo(text4).GetFiles();
								f4 f18 = el();
								if (files.GetLength(0) > 0)
								{
									f18.j(files[0].FullName, this.m_c2.sn(f18.hb()), global::r.d.a.b.a);
								}
							}
						}
						if (!this.m_dn)
						{
							Collection<hg> collection3 = new Collection<hg>();
							foreach (TabPage tabPage21 in ar().TabPages)
							{
								if (tabPage21.Controls[0] is f4)
								{
									Guid a_14 = ((f4)tabPage21.Controls[0]).hc();
									hg hg3 = this.m_c2.wq(a_14);
									if (!collection3.Contains(hg3))
									{
										hg3.bu(this.m_c3, i6.a(this), global::e.a().OperatorID, this.m_c2.xk(a_14), A_4: false, A_5: false, d4(), A_7: true, null);
										collection3.Add(hg3);
									}
								}
							}
							if (!this.m_ds)
							{
								if (global::c.d().CommandLineArgs.Count == 0)
								{
									j();
								}
								else if (global::a.q())
								{
									this.m_ds = true;
								}
								else
								{
									b(global::c.d().CommandLineArgs, null, b10, b11);
									this.m_ds = true;
								}
							}
							if (ez && !this.m_dn)
							{
								ac();
							}
							else
							{
								ab();
							}
						}
						if (!b10.a && !b11.a && this.m_d4.g())
						{
							ci obj5 = new ci();
							obj5.AcceptButton = obj5.ac();
							bool A_5 = default(bool);
							obj5.p(this.m_c3, this.m_c2, this.m_d4, ref A_5);
							if (A_5)
							{
								Close();
							}
							else
							{
								this.m_dc.b();
							}
						}
						global::j.a((global::j.a)b);
						global::j.b((global::j.a)b);
						global::j.a((global::j.b)b);
						global::j.b((global::j.b)b);
						global::j.a((global::j.c)b);
						global::j.b((global::j.c)b);
						this.m_c2.s4();
						cd().Visible = this.m_c2.ug();
						c8().Visible = this.m_c2.ui();
						a7().Visible = this.m_c2.us() || (this.m_c2.ui() && !this.m_c2.u2());
						if (this.m_c2.ui() && Directory.Exists(i3.h()))
						{
							string[] files2 = Directory.GetFiles(i3.h(), "*.chm");
							int num10 = files2.Length - 1;
							for (int num11 = 0; num11 <= num10; num11++)
							{
								string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(files2[num11]);
								ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(fileNameWithoutExtension);
								toolStripMenuItem.Name = fileNameWithoutExtension;
								toolStripMenuItem.Click += ac;
								dh().DropDownItems.Add(toolStripMenuItem);
							}
						}
						else if (dh().DropDownItems.Count > 0)
						{
							ToolStripItemCollection dropDownItems = dh().DropDownItems;
							for (int num12 = dropDownItems.Count - 1; num12 >= 0; num12 += -1)
							{
								dropDownItems[num12].Click -= ac;
								dropDownItems.RemoveAt(num12);
							}
							dropDownItems = null;
						}
						c();
						cb().Visible = true;
						dm().Visible = true;
						if (this.m_dr != null)
						{
							this.m_dr.i();
							this.m_dr.Dispose();
							this.m_dr = null;
						}
						bool flag15 = false;
						List<Guid> A_6 = null;
						List<string> A_7 = null;
						this.m_c2.m2(ref A_6, ref A_7);
						flag15 = A_6 != null && A_6.Count > 0;
						this.m_d2 = 0;
						this.m_d3 = 0;
						if (flag15)
						{
							int num13 = A_6.Count - 1;
							for (int num14 = 0; num14 <= num13; num14++)
							{
								Guid a_15 = A_6[num14];
								a9[] A_8 = null;
								this.m_c2.m2(a_15, ref A_8);
								int num15 = A_8.Length - 1;
								for (int num16 = 0; num16 <= num15; num16++)
								{
									Collection<h6.c> collection4 = ((ce)this.m_c2).p9(a_15, num16);
									int num17 = collection4.Count - 1;
									for (int num18 = 0; num18 <= num17; num18++)
									{
										collection4[num18].a = A_7[num14];
										this.m_d2++;
										this.m_c2.m2(a_15.ToString(), collection4[num18], h6.b.b, num16, eb());
									}
								}
							}
						}
						this.m_dp = true;
						if (!flag15 && (b10.a || b11.a))
						{
							b(b10.a, b11.a, A_2: false, 0f, global::r.d.a.b.a);
						}
						if (!b10.a)
						{
							bl(this, new EventArgs());
						}
						return;
					}
					global::r.e.a a14 = (global::r.e.a)A_0;
					if (a14.g == global::r.e.a.b.a)
					{
						string text5 = "Exiting Software due to error or no systems connected (2)";
						if (!string.IsNullOrEmpty(A_0.b))
						{
							text5 = text5 + "\r\n" + A_0.b;
						}
						if (this.m_dn)
						{
							if (this.m_d8 != null)
							{
								b a_16 = new b(this.m_c2, ec(), de);
								this.m_d8(a_16, a_2, text5, this.m_c4);
							}
						}
						else
						{
							i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.SystemInitializationFinished(2)", text5);
							new bn().a("An error has occurred during software initialization.\r\nIf this error happens repeatedly, you may wish to consider\r\nreverting the settings.", A_1: true);
						}
					}
					else
					{
						string text6 = a14.a6(this.m_c2.ul());
						if (!string.IsNullOrEmpty(((global::r.d.a)a14).b))
						{
							text6 = text6 + "\r\n\r\n" + ((global::r.d.a)a14).b;
						}
						if (this.m_dn)
						{
							if (this.m_d8 != null)
							{
								b a_17 = new b(this.m_c2, ec(), de);
								string text7 = "Exiting Software due to error or no systems connected (3)";
								if (!string.IsNullOrEmpty(text6))
								{
									text7 = text7 + "\r\n" + text6;
								}
								this.m_d8(a_17, a_2, text7, this.m_c4);
							}
						}
						else
						{
							bool flag16 = default(bool);
							if (a14.g == global::r.e.a.b.ae || a14.g == global::r.e.a.b.af || flag16)
							{
								global::fe.b(this.m_c3, text6, i6.a(this));
								new bn().a("An error has occurred during software initialization.\r\nIf this error happens repeatedly, you may wish to consider\r\nreverting the settings.", A_1: true);
							}
							else
							{
								i5.a(this.m_c3, this.m_c2, i6.a(this), "MainForm.SystemInitializationFinished(5)", null, text6, null);
							}
							this.m_dv = a14.g != global::r.e.a.b.a;
						}
					}
					this.m_c3.c(fz.b.a, "Exiting software due to error or no systems connected (deviceInitEventArgs.InitializationResult<>Success).");
					Close();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_18 = ex2;
				if (this.m_dn)
				{
					if (this.m_d8 != null)
					{
						b a_19 = new b(this.m_c2, ec(), de);
						this.m_d8(a_19, a_2, "Unable to run due to error", this.m_c4);
					}
				}
				else
				{
					i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.SystemInitializationFinished", a_18);
					new bn().a("An error has occurred during software initialization.\r\nIf this error happens repeatedly, you may wish to consider\r\nreverting the settings.", A_1: true);
				}
				Close();
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ac()
	{
		if (d9() == null)
		{
			c(new System.Timers.Timer());
			d9().AutoReset = false;
			aa();
			d9().Start();
		}
	}

	private void ab()
	{
		if (d9() != null)
		{
			d9().Stop();
			d9().Dispose();
			c((System.Timers.Timer)null);
		}
	}

	private void aa()
	{
		if (d9() != null)
		{
			double interval = 60000.0 * global::e.a().LightSourceAutoStandbyDelayMinutes;
			d9().Interval = interval;
		}
	}

	private void z()
	{
		try
		{
			if (!Directory.Exists(global::a1.d()))
			{
				StreamReader streamReader = new StreamReader(i7.c(null, i3.n()));
				string value = streamReader.ReadToEnd();
				streamReader.Close();
				if (!Directory.Exists(i3.o()))
				{
					Directory.CreateDirectory(i3.o());
				}
				StreamWriter streamWriter = new StreamWriter(i7.c(null));
				streamWriter.WriteLine(value);
				streamWriter.Close();
				i3.a(i7.h(), global::a1.d());
			}
			if (!Directory.Exists(i3.c()))
			{
				Directory.CreateDirectory(i3.c());
				i3.a(i7.g(), global::a1.c());
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0)
	{
		this.m_c2.t7();
		((ix.b)A_0).a = true;
	}

	private void b(object A_0, PowerModeChangedEventArgs A_1)
	{
		switch (A_1.Mode)
		{
		case PowerModes.Resume:
		{
			bt obj = new bt();
			ix.b a_ = new ix.b();
			ThreadPool.QueueUserWorkItem(b, a_);
			string A_2 = "WaitRestartTitle";
			string a_2 = hu.a(ref A_2);
			A_2 = "WaitRestartMessage";
			obj.a(a_2, hu.a(ref A_2), this.m_c2.t6(), a_);
			break;
		}
		case PowerModes.Suspend:
			this.m_c2.t8();
			break;
		case PowerModes.StatusChange:
			break;
		}
	}

	private void c(object A_0, ElapsedEventArgs A_1)
	{
		checked
		{
			try
			{
				if (this.m_c2.tc())
				{
					return;
				}
				if (base.InvokeRequired)
				{
					Invoke(new g(c), A_0, A_1);
					return;
				}
				if (!base.IsHandleCreated)
				{
					this.m_c3.c(fz.b.b, "Attempted mLightSourceStandbyTimer_Elapsed before handle created-Aborted", Environment.StackTrace);
					return;
				}
				List<float> list = new List<float>();
				List<Guid> list2 = new List<Guid>();
				foreach (Guid item in this.m_c2.tj())
				{
					if (this.m_c2.tj(item))
					{
						list.Add(this.m_c2.t5(item));
						list2.Add(item);
						if (this.m_c2.wq(item).d0().c() == g2.a.b)
						{
							this.m_c2.u2(item);
						}
					}
				}
				try
				{
					int num = list2.Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						this.m_c2.m2(list2[num2], list[num2] / 2f, A_2: true, d5(), global::r.d.a.b.a);
					}
					ab obj = new ab();
					obj.Owner = this;
					obj.a(this.m_c3, this.m_c2);
				}
				finally
				{
					int num3 = list2.Count - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						this.m_c2.m2(list2[num4], list[num4], A_2: false, d5(), global::r.d.a.b.a);
					}
				}
				foreach (Guid item2 in list2)
				{
					if (this.m_c2.u9(item2).c() == g2.a.b && this.m_c2.u1(item2) != global::ce.ErrPublic.None)
					{
						this.m_c3.c(fz.b.b, "Error in mLightSourceStandbyTimer_Elapsed in call to AutoMeasureRandT.");
					}
				}
				aa();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_c3.c(fz.b.b, "Exception caught in mLightSourceStandbyTimer_Elapsed", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void y()
	{
		checked
		{
			if (w())
			{
				dg().Left = base.ClientSize.Width - dg().Width;
			}
			else
			{
				dg().Left = base.ClientSize.Width - dg().Width - 75;
			}
		}
	}

	private void bl(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (this.m_c2 != null && this.m_c2.tc())
				{
					return;
				}
				_ = base.WindowState;
				_ = base.Width;
				_ = base.Height;
				if (base.WindowState == FormWindowState.Minimized)
				{
					return;
				}
				SuspendLayout();
				y();
				x();
				fw fw2 = ar();
				fw2.Height = base.ClientSize.Height - fw2.Top;
				fw2.Width = base.ClientSize.Width;
				foreach (TabPage tabPage in fw2.TabPages)
				{
					foreach (Control control in tabPage.Controls)
					{
						if (control is f4)
						{
							((f4)control).i(tabPage.ClientRectangle.Width, tabPage.ClientRectangle.Height);
						}
						else if (control is by)
						{
							((by)control).a(tabPage.ClientRectangle.Width, tabPage.ClientRectangle.Height);
						}
					}
				}
				p()?.a(fw2.TabPages[fw2.TabCount - 1].ClientRectangle.Width, fw2.TabPages[fw2.TabCount - 1].ClientRectangle.Height);
				o()?.a(fw2.Width, fw2.Height);
				fw2 = null;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.MainForm_Resize", a_);
				ProjectData.ClearProjectError();
			}
			finally
			{
				fw fw3 = ar();
				if (fw3.TabCount > 0 && fw3.ItemSize.Width != unchecked(fw3.ClientSize.Width / fw3.TabCount) - 2)
				{
					fw3.ItemSize = new Size(unchecked(fw3.ClientSize.Width / fw3.TabCount) - 2, fw3.ItemSize.Height);
				}
				fw3 = null;
				ResumeLayout(performLayout: true);
			}
		}
	}

	private Size x()
	{
		foreach (TabPage tabPage in ar().TabPages)
		{
			if (tabPage == ar().SelectedTab)
			{
				return tabPage.Controls[0].MinimumSize;
			}
		}
		return MinimumSize;
	}

	private int b(int A_0, int A_1, bool A_2, double A_3, int A_4)
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

	[SpecialName]
	[CompilerGenerated]
	public void b(h A_0)
	{
		h h10 = e0;
		h h11;
		do
		{
			h11 = h10;
			h value = (h)Delegate.Combine(h11, A_0);
			h10 = Interlocked.CompareExchange(ref e0, value, h11);
		}
		while ((object)h10 != h11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void c(h A_0)
	{
		h h10 = e0;
		h h11;
		do
		{
			h11 = h10;
			h value = (h)Delegate.Remove(h11, A_0);
			h10 = Interlocked.CompareExchange(ref e0, value, h11);
		}
		while ((object)h10 != h11);
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void b(object A_0, FormClosingEventArgs A_1)
	{
		try
		{
			this.m_ec = true;
			if (!e9)
			{
				e0?.Invoke(A_1);
				if (A_1.Cancel)
				{
					return;
				}
			}
			if (this.m_c2 != null)
			{
				if (this.m_c2.tc() || !this.m_dp || this.m_c2.m2(this.m_dq, gq.g(this.m_d4)))
				{
					e9 = true;
					if (!this.m_c2.tc())
					{
						this.m_c2.s8();
						this.m_c3.c(fz.b.a, "Starting shutdown process");
						global::e.a().Save();
						if (f1.fz.f() || global::e.a().ShareSettingsWithSelectedUsers)
						{
							f1.fz.j();
						}
						this.m_di = DateTime.Now;
					}
					if (DateAndTime.Now.Subtract(this.m_di).TotalSeconds < 2.0)
					{
						if (d9() != null)
						{
							ab();
						}
						if (ar().TabPages.Count > 0)
						{
							foreach (TabPage tabPage in ar().TabPages)
							{
								if (tabPage.Controls.Count <= 0)
								{
									continue;
								}
								if (tabPage.Controls[0] is f4)
								{
									f4 f10 = (f4)tabPage.Controls[0];
									if (f10.hj())
									{
										A_1.Cancel = true;
										b(new System.Timers.Timer(2.0));
										d3().AutoReset = false;
										d3().Start();
										return;
									}
									f10.h6();
								}
								else if (tabPage.Controls[0] is f3)
								{
									((f3)tabPage.Controls[0]).b3();
								}
							}
						}
						if (!this.m_dn && global::e.a().PromptForDisconnectOK && !this.m_dv && !this.m_c2.u1())
						{
							fz a_ = this.m_c3;
							string A_2 = "PromptDisconnectOKFmt";
							string a_2 = string.Format(hu.a(ref A_2), global::c.d().Info.Title);
							Point a_3 = i6.a(this);
							A_2 = "DontRemindMeAgain";
							bool A_3 = default(bool);
							global::fe.b(a_, a_2, "Information", null, a_3, A_5: false, null, null, hu.a(ref A_2), ref A_3);
							global::e.a().PromptForDisconnectOK = !A_3;
						}
						this.m_c2.tb();
						A_1.Cancel = false;
					}
					else
					{
						ProjectData.EndApp();
					}
				}
				else
				{
					A_1.Cancel = true;
				}
			}
			if (!A_1.Cancel && ev != null)
			{
				File.Delete(ev);
				ev = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_4 = ex2;
			this.m_c3.c(fz.b.b, "Exception caught in MainForm_FormClosing(). ", a_4);
			ProjectData.ClearProjectError();
		}
	}

	private bool w()
	{
		if (this.m_c2 != null)
		{
			return this.m_c2.uj();
		}
		return false;
	}

	private void v()
	{
		bool flag = false;
		bool flag2 = false;
		try
		{
			if (base.InvokeRequired)
			{
				hs.a method = v;
				BeginInvoke(method);
			}
			else
			{
				if (!base.IsHandleCreated)
				{
					return;
				}
				f4 f10 = el();
				f10?.v(A_0: true);
				by obj = u();
				bool flag3 = obj != null;
				string text = null;
				bool flag4 = f10 != null;
				Collection<Guid> collection = null;
				bool flag5 = false;
				d6 d10 = null;
				bool flag6 = !this.m_c2.u2();
				bool enabled = false;
				Guid guid = default(Guid);
				bool flag7 = default(bool);
				bool flag8 = default(bool);
				Guid a_ = default(Guid);
				if (flag4)
				{
					guid = f10.hc();
					text = guid.ToString();
					flag7 = this.m_c2.sj(guid, A_1: false);
				}
				else if (flag3)
				{
					guid = obj.ca();
					text = guid.ToString();
				}
				else
				{
					d10 = t();
					flag8 = d10 != null;
					if (flag8)
					{
						a_ = d10.bu();
						collection = this.m_c2.ua(d10.bu()).o;
						if (collection.Count > 0)
						{
							flag7 = true;
							foreach (Guid item in collection)
							{
								flag7 = flag7 && this.m_c2.sj(item, A_1: false);
								if (!flag7)
								{
									break;
								}
							}
						}
					}
				}
				if (guid == Guid.Empty)
				{
					return;
				}
				if (flag4 && flag7)
				{
					aw().Enabled = true;
					ax().Enabled = true;
					bb().Enabled = true;
					bc().Enabled = true;
					flag2 = false;
				}
				else
				{
					aw().Enabled = false;
					ax().Enabled = false;
					bb().Enabled = false;
					bc().Enabled = flag8 && this.m_c2.v1(a_) && !this.m_c2.vx(a_) && !this.m_c2.u7(a_);
					flag2 = true;
				}
				bool flag9 = default(bool);
				if (flag4 || flag8 || flag5)
				{
					if (flag4 || flag5)
					{
						flag9 = this.m_c2.v2(guid);
					}
					else if (collection.Count > 0)
					{
						flag9 = true;
						foreach (Guid item2 in collection)
						{
							flag9 = flag9 && this.m_c2.v2(item2);
							if (!flag9)
							{
								break;
							}
						}
					}
					if (flag9)
					{
						if (flag4 || flag5)
						{
							flag = this.m_c2.m2(guid, A_1: false);
						}
						else if (collection.Count > 0)
						{
							flag = true;
							foreach (Guid item3 in collection)
							{
								flag = flag && this.m_c2.m2(item3, A_1: false);
							}
						}
					}
				}
				if (flag4 && flag9)
				{
					if (!flag2)
					{
						bb().Enabled = flag;
						bc().Enabled = flag;
					}
					((f4.f)this.m_c6[text])(flag);
				}
				else
				{
					ax().Enabled = false;
					if (!flag8)
					{
						bc().Enabled = false;
					}
					cn().Visible = w();
					if (flag4)
					{
						f4 f11 = f10;
						if (f11.hw())
						{
							aw().Enabled = false;
						}
						if (f11.hx() || f11.hv())
						{
							bb().Enabled = false;
						}
						f11 = null;
						((f4.f)this.m_c6[text])(A_0: false);
					}
				}
				ch().Enabled = ax().Enabled || flag7;
				ci().Enabled = flag;
				if (flag4)
				{
					az().Visible = !this.m_c2.m2(guid) && this.m_c2.ui() && !this.m_c2.sm(guid);
					if (this.m_c2.vp(guid))
					{
						if (!this.m_c2.m2(guid))
						{
							az().Enabled = true;
						}
					}
					else
					{
						az().Enabled = false;
					}
				}
				else
				{
					az().Enabled = false;
				}
				hg hg2 = null;
				if (flag4 && this.m_c2.u7(guid) && !f10.hq() && flag6)
				{
					hg2 = this.m_c2.t0(text);
					bo().Visible = !hg2.b5();
					bo().Enabled = !hg2.b5();
				}
				else
				{
					bo().Visible = false;
					bo().Enabled = false;
				}
				if (hg2 != null)
				{
					hg2.dh();
					if (!hg2.b5() && !this.m_c2.m2(l()))
					{
						an().Visible = false;
					}
					_ = null;
				}
				bool flag10 = default(bool);
				if (flag4 || flag3)
				{
					flag10 = this.m_c2.vj(guid);
				}
				eo obj2 = this.m_c2.ut();
				bool flag11 = this.m_c2.ul();
				bool flag12 = obj2.bv();
				if (flag4)
				{
					f4 f12 = f10;
					if (f12.bb().fg() > 0)
					{
						au().Enabled = flag6 || this.m_c2.u3();
					}
					else
					{
						au().Enabled = false;
					}
					bg().Visible = f12.ha();
					aw().Checked = f12.hx();
					bb().Checked = f12.hw();
					if (hg2 == null)
					{
						hg2 = this.m_c2.t0(text);
					}
					cj().Enabled = !bb().Checked && !aw().Checked && !hg2.ei() && !this.m_c2.sm(guid);
					f12 = null;
					b1().Enabled = flag10 && !bb().Checked && !aw().Checked && (!this.m_c2.te(text) || hg2.d0().c() == g2.a.b);
				}
				else
				{
					if (flag8)
					{
						au().Enabled = d10.bi().fg() > 0 && (flag6 || this.m_c2.u3());
					}
					else
					{
						au().Enabled = false;
					}
					bg().Visible = false;
					b1().Enabled = false;
					cj().Enabled = false;
				}
				dq().Enabled = b1().Enabled && flag4 && (this.m_c2.t0(guid) || flag12);
				dr().Visible = flag11;
				dr().Enabled = flag4 && this.m_c2.tl(guid);
				ck().Enabled = cj().Enabled;
				cg().Enabled = ch().Enabled || ci().Enabled || cj().Enabled || ck().Enabled;
				if (flag3)
				{
					by obj3 = obj;
					au().Enabled = obj3.l().fg() > 0 && (flag6 || this.m_c2.u3());
					obj3 = null;
				}
				bool flag13 = false;
				if (!this.m_d4.g() || (this.m_d4.g() && this.m_d4.h() >= gq.a.c))
				{
					flag13 = true;
				}
				ap().Visible = flag13;
				an().Visible = flag13;
				b5().Enabled = flag13;
				bw().Enabled = flag4 || (flag8 && !this.m_c2.vx(t().bu())) || flag3;
				bm().Enabled = flag6 || this.m_c2.u3();
				b0().Enabled = bm().Enabled;
				br().Enabled = bm().Enabled;
				cm().Enabled = bm().Enabled;
				av().Enabled = flag4 || flag3 || (flag8 && !this.m_c2.vx(d10.bu()));
				a2().Enabled = flag4 || flag3;
				bool flag14 = ek();
				a3().Enabled = flag4 || flag3 || flag14;
				bt().Enabled = av().Enabled;
				by().Enabled = au().Enabled;
				@do().Visible = flag11;
				bu().Enabled = a3().Enabled;
				string A_ = null;
				if (flag4 || flag3)
				{
					ToolStripMenuItem toolStripMenuItem = at();
					toolStripMenuItem.Visible = flag10 && !this.m_c2.wq(guid).d0().n();
					toolStripMenuItem.Enabled = (flag4 && this.m_c2.m2(guid, ref A_)) || (flag3 && !this.m_c2.s6(text));
					if (toolStripMenuItem.Enabled || string.IsNullOrEmpty(A_))
					{
						toolStripMenuItem.ToolTipText = null;
					}
					else
					{
						toolStripMenuItem.ToolTipText = "Menu disabled because: \r\n" + A_;
					}
					eo.a a_2 = null;
					if (flag4)
					{
						a_2 = f10.h2();
					}
					if (global::eo.at(this.m_c2.sm(guid), this.m_c2.sn(guid), a_2))
					{
						toolStripMenuItem.Text = global::ey.g() + "...";
					}
					else
					{
						toolStripMenuItem.Text = global::ey.f() + "...";
					}
					toolStripMenuItem = null;
					@do().Enabled = flag10;
					d2().Enabled = enabled;
					ds().Visible = false;
					dv().Visible = false;
				}
				else
				{
					at().Enabled = false;
					@do().Enabled = false;
					ds().Enabled = false;
					dv().Enabled = false;
					d2().Enabled = false;
				}
				dt().Visible = false;
				be().Enabled = flag4 || flag3;
				dn().Visible = (flag4 || flag3) && (flag11 || flag12);
				dp().Visible = false;
				bool visible = obj2.bi();
				b2().Visible = visible;
				b3().Visible = visible;
				if (flag8)
				{
					av().Text = string.Format(global::ey.ag(), global::ey.ae());
					au().Text = string.Format(global::ey.af(), global::ey.ae());
				}
				else if (flag4)
				{
					av().Text = string.Format(global::ey.ag(), global::ey.ad());
					au().Text = string.Format(global::ey.af(), global::ey.ac());
				}
				else if (flag3)
				{
					av().Text = "Open Vs Time File...";
					au().Text = "Save Vs Time File...";
				}
				by().ToolTipText = au().Text;
				bt().ToolTipText = av().Text;
				cl().Text = string.Format(global::ey.c());
				cm().Text = string.Format(global::ey.c());
				cb().Text = string.Format(global::ey.b());
				cc().Text = string.Format(global::ey.b());
				dm().Text = string.Format(global::ey.a());
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			this.m_c3.c(fz.b.b, "Error in MainformGUIUpdateHandler", a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void bk(object A_0, EventArgs A_1)
	{
		try
		{
			f4 f10 = el();
			bool A_2 = default(bool);
			f10.i(A_0: false, i6.a(this), ref A_2);
			if (A_2)
			{
				f10.ht();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c3.c(fz.b.b, "Exception in DoSingleAcquireToolStripMenuItem_Click(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void bj(object A_0, EventArgs A_1)
	{
		try
		{
			f4 f10 = el();
			bool A_2 = default(bool);
			f10.i(A_0: false, i6.a(this), ref A_2);
			if (A_2)
			{
				f10.i(A_0: true, A_1: false, h6.b.b);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c3.c(fz.b.b, "Exception in StartContinuousAcquireToolStripMenuItem_Click(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void bi(object A_0, EventArgs A_1)
	{
		try
		{
			f4 f10 = el();
			if (f10 != null)
			{
				bool A_2 = default(bool);
				f10.i(A_0: false, i6.a(this), ref A_2);
				if (A_2)
				{
					f10.w(A_0: false);
				}
			}
			else
			{
				t()?.by();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c3.c(fz.b.b, "Exception in SingleMeasureToolStripMenuItem_Click(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void bh(object A_0, EventArgs A_1)
	{
		try
		{
			f4 f10 = el();
			if (this.m_c2.p9(f10.hc(), this.m_c2.wq(f10.hc())))
			{
				fz a_ = this.m_c3;
				string A_2 = "AdditionalRecipeSpecRangeConflict";
				global::fe.b(a_, hu.a(ref A_2), i6.a(f10));
				return;
			}
			bool A_3 = default(bool);
			f10.i(A_0: false, i6.a(this), ref A_3);
			if (A_3)
			{
				f10.x(A_0: true);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			this.m_c3.c(fz.b.b, "Exception in ContinuousMeasureToolStripMenuItem_Click(). ", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void bg(object A_0, EventArgs A_1)
	{
		f4 a_ = null;
		try
		{
			a_ = el();
			b(A_0: true);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_c3, this.m_c2, a_, i6.a(this), "MainForm.BatchAcquireToolStripMenuItem_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void bf(object A_0, EventArgs A_1)
	{
		f4 f10 = null;
		try
		{
			f10 = el();
			if (this.m_c2.p9(f10.hc(), this.m_c2.wq(f10.hc())))
			{
				fz a_ = this.m_c3;
				string A_2 = "AdditionalRecipeSpecRangeConflict";
				global::fe.b(a_, hu.a(ref A_2), i6.a(f10));
			}
			else
			{
				b(A_0: false);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_c3, this.m_c2, f10, i6.a(this), "MainForm.BatchMeasureToolStripMenuItem_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void b(bool A_0)
	{
		f4 f10 = null;
		f10 = el();
		if (f10 != null && !A_0 && this.m_c2.u7(f10.hc()))
		{
			fz a_ = this.m_c3;
			string A_1 = "BatchMeasureAutoMeasureError";
			global::fe.b(a_, hu.a(ref A_1), i6.a(this));
			return;
		}
		d6 d10 = null;
		Guid a_2;
		if (f10 == null)
		{
			d10 = t();
			a_2 = d10.bu();
		}
		else
		{
			a_2 = f10.hc();
		}
		cn obj = new cn();
		obj.a(this.m_c3, this.m_c2, f10, a_2, A_0);
		if (obj.DialogResult != DialogResult.OK)
		{
			return;
		}
		if (f10 != null)
		{
			if (A_0)
			{
				f10.j(0);
			}
			else
			{
				f10.k(0);
			}
			return;
		}
		int num = 1;
		foreach (Guid item in this.m_c2.ua(d10.bu()).o)
		{
			if (A_0)
			{
				c(item).j(num);
			}
			else
			{
				c(item).k(num);
			}
			num = checked(num + 1);
		}
	}

	private void be(object A_0, EventArgs A_1)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			string A_2 = "BatchAnalysisSelectFilesTitle";
			openFileDialog.Title = hu.a(ref A_2);
			openFileDialog.InitialDirectory = i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
			if (this.m_c2.u2())
			{
				f1 f10 = this.m_c2;
				openFileDialog.Filter = hr.t(f10.u3(), f10.u4(), this.m_c2.ui() || this.m_c2.uq());
				f10 = null;
			}
			else
			{
				openFileDialog.Filter = hr.af(this.m_c2.ui() || this.m_c2.uq());
			}
			openFileDialog.FilterIndex = global::e.a().LastUsedOpenSpectrumFilter;
			openFileDialog.Multiselect = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(openFileDialog.FileName);
				el().i(openFileDialog.FileNames);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c3, this.m_c2, null, i6.a(this), "MainForm.BatchAnalyzeToolStripMenuItem_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void bd(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				ay ay2 = new ay();
				ay2.g(i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath));
				ay obj = ay2;
				string A_2 = "BatchAnalysisFolderSelectPrompt";
				obj.h(hu.a(ref A_2));
				if (ay2.g(this) != DialogResult.OK)
				{
					return;
				}
				global::e.a().LastOpenSaveExportTargetImportSourcePath = ay2.f();
				string[] wildcards;
				if (this.m_c2.u2())
				{
					f1 f10 = this.m_c2;
					wildcards = hr.r(f10.u3(), f10.u4(), this.m_c2.ui());
					f10 = null;
				}
				else
				{
					wildcards = hr.t(this.m_c2.ui());
				}
				ReadOnlyCollection<string> files = global::c.e().FileSystem.GetFiles(ay2.f(), Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, wildcards);
				if (files.Count == 0)
				{
					fz a_ = this.m_c3;
					A_2 = "ErrFilesNotFoundFmt2";
					global::fe.b(a_, string.Format(hu.a(ref A_2), global::ey.ai(), ay2.f()), i6.a(this));
					return;
				}
				ay2 = null;
				int num = files.Count - 1;
				string[] array = new string[num + 1];
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					array[num3] = files[num3];
				}
				el().i(array);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				i5.a(this.m_c3, this.m_c2, null, i6.a(this), "MainForm.BatchAnalyzeAllSpectraInFolderToolStripMenuItem_Click", a_2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void bc(object A_0, EventArgs A_1)
	{
		f4 a_ = null;
		try
		{
			br obj = new br();
			a_ = el();
			obj.a(this.m_c3, this.m_c2, a_);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_c3, this.m_c2, a_, i6.a(this), "MainForm.LSDT2TestingToolStripMenuItem_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void bb(object A_0, EventArgs A_1)
	{
		f4 a_ = null;
		try
		{
			be obj = new be();
			a_ = el();
			obj.a(this.m_c3, this.m_c2, a_);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_c3, this.m_c2, a_, i6.a(this), "MainForm.DualFiberShutterTestingToolStripMenuItem_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void c(Guid A_0, string A_1, bool A_2)
	{
		try
		{
			b(A_0, A_1, A_2);
			this.m_c2.m2(A_0, A_1, A_2);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c3.c(fz.b.b, "Exception caught in SystemSampleIdChangedHandler(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	public void d(Guid A_0, string A_1, bool A_2)
	{
		try
		{
			Guid A_3 = default(Guid);
			if (this.m_c2.m2(A_0, ref A_3))
			{
				b(A_3, A_1, A_2);
				bool flag = false;
				{
					foreach (TabPage tabPage in ar().TabPages)
					{
						foreach (Control control in tabPage.Controls)
						{
							if (!(control is d6))
							{
								continue;
							}
							d6 d10 = (d6)control;
							if (d10.bu() == A_3)
							{
								if (A_2)
								{
									d10.ak().Text = A_1;
								}
								else
								{
									d10.ai().Text = A_1;
								}
								flag = true;
								break;
							}
							d10 = null;
						}
						if (flag)
						{
							break;
						}
					}
					return;
				}
			}
			this.m_c2.m2(A_0, A_1, A_2);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c3.c(fz.b.b, "Exception caught in MeasModuleSampleIdChangedHandler(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(Guid A_0, string A_1, bool A_2)
	{
		gx gx2 = this.m_c2.ua(A_0);
		foreach (Guid item in gx2.o)
		{
			e(item, A_1, A_2);
		}
	}

	public void e(Guid A_0, string A_1, bool A_2)
	{
		bool flag = false;
		foreach (TabPage tabPage in ar().TabPages)
		{
			foreach (Control control in tabPage.Controls)
			{
				if (!(control is f4))
				{
					continue;
				}
				f4 f10 = (f4)control;
				if (f10.hc() == A_0)
				{
					if (A_2)
					{
						f10.ex().Text = A_1;
					}
					else
					{
						f10.ev().Text = A_1;
					}
					flag = true;
					break;
				}
				f10 = null;
			}
			if (flag)
			{
				break;
			}
		}
	}

	private void b(Guid A_0, bool A_1, global::r.c A_2, string A_3, object A_4)
	{
		try
		{
			if (base.InvokeRequired)
			{
				ce.a method = b;
				BeginInvoke(method, A_0, A_1, A_2, A_3, A_4);
				return;
			}
			f4 f10 = el();
			bool flag = false;
			bool num = f10 != null && f10.hc() == A_0;
			object obj = f10;
			Guid guid = default(Guid);
			if (num)
			{
				guid = f10.hc();
			}
			Guid guid2 = default(Guid);
			if (!num)
			{
				Guid A_5 = default(Guid);
				if (f10 != null && this.m_c2.m2(f10.hc(), ref A_5) && A_5 == A_0 && this.m_c2.vx(A_5))
				{
					guid2 = A_0;
					obj = f10;
				}
				else
				{
					d6 d10 = t();
					obj = d10;
					if (d10 == null)
					{
						Control control = ar().TabPages[0].Controls[0];
						if (control is f4)
						{
							guid2 = ((f4)control).hc();
						}
						else if (control is d6)
						{
							guid2 = ((d6)control).bu();
						}
					}
					else
					{
						guid2 = d10.bu();
					}
					flag = true;
				}
			}
			else
			{
				guid2 = guid;
			}
			double num2 = A_2.ab() * (100f - A_2.t()) / 100f;
			if (guid2 == A_0 && num2 >= 0.0)
			{
				if (A_1)
				{
					b6().Text = num2.ToString("0.0");
					b6().Refresh();
					if (Operators.CompareString(b7().Text, A_3, TextCompare: false) != 0 && A_4 == obj)
					{
						b7().Text = A_3;
						b7().Refresh();
						df().ResumeLayout(performLayout: true);
						dg().ResumeLayout(performLayout: true);
					}
				}
				df().Visible = A_1;
				y();
			}
			else if (flag)
			{
				df().Visible = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c3.c(fz.b.b, "Exception caught in DelayStatusChangedHandler(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	public void b(ReadOnlyCollection<string> A_0)
	{
		b(A_0, null, null, null);
	}

	public void b(ReadOnlyCollection<string> A_0, ix.b A_1, ix.b A_2, ix.b A_3)
	{
		if (base.InvokeRequired)
		{
			bool flag = false;
			foreach (string item in A_0)
			{
				if (Operators.CompareString(Path.GetExtension(item.ToLower()), global::a2.a.b1(), TextCompare: false) != 0)
				{
					flag = true;
					break;
				}
			}
			do
			{
				if (!this.m_dp && flag)
				{
					Thread.Sleep(100);
					continue;
				}
				BeginInvoke(new i(b), A_0, A_1, A_2, A_3);
				break;
			}
			while (this.m_c2 == null || !this.m_c2.tc());
			return;
		}
		if (A_1 != null)
		{
			A_1.a = false;
		}
		if (A_0.Count <= 0)
		{
			return;
		}
		checked
		{
			try
			{
				List<string> list = new List<string>();
				bool A_4 = default(bool);
				bool A_5 = default(bool);
				bool A_6 = default(bool);
				foreach (string item2 in A_0)
				{
					if (hr.r(Path.GetExtension(item2)))
					{
						list.Add(item2);
					}
					else if (Operators.CompareString(Path.GetExtension(item2).ToLower(), ".fitsa", TextCompare: false) == 0 && this.m_c2.ut().bi())
					{
						if (b(this.m_c2.wq(eh())))
						{
							b(item2);
						}
					}
					else if (Operators.CompareString(Path.GetExtension(item2.ToLower()), global::a2.a.b1(), TextCompare: false) == 0)
					{
						global::a2.a.c(item2, ref A_4, ref A_5, ref A_6);
						string A_7;
						if (A_4)
						{
							fz a_ = this.m_c3;
							A_7 = "ImportLicenseDuplicateCompletionFmt";
							global::fe.b(a_, string.Format(hu.a(ref A_7), Path.GetFileName(item2)), "Information", i6.a(this));
							continue;
						}
						fz a_2 = this.m_c3;
						A_7 = "ImportLicenseCompletionPromptFmt2";
						global::fe.b(a_2, string.Format(hu.a(ref A_7), Path.GetFileName(item2), global::c.d().Info.Title), "Information", i6.a(this));
						if (A_1 != null)
						{
							A_1.a = true;
						}
					}
					else if (Operators.CompareString(Path.GetExtension(item2.ToLower()), ".fitrh", TextCompare: false) == 0)
					{
						d(item2);
					}
					else if (Operators.CompareString(Path.GetExtension(item2.ToLower()), ".fibhi", TextCompare: false) == 0 && ar().TabCount > 0)
					{
						ar().SelectedTab = q();
						p().b(item2, A_1: true);
					}
				}
				if (list.Count > 0)
				{
					fz a_3 = this.m_c3;
					int count = list.Count;
					string A_7 = "SpectrumSingularString";
					string a_4 = hu.a(ref A_7);
					A_7 = "SpectrumPluralString";
					global::d7.a(a_3, count, a_4, hu.a(ref A_7), i6.a(this));
					foreach (string item3 in list)
					{
						f4 f10 = el();
						if (f10 == null)
						{
							f10 = s();
						}
						f4 f11 = f10;
						f11.j(item3, this.m_c2.sn(f11.hb()), global::r.d.a.b.a);
						f11 = null;
						int num = ar().TabPages.Count - 1;
						for (int num2 = 0; num2 <= num; num2++)
						{
							if (ar().TabPages[num2].Controls[0] == f10)
							{
								ar().SelectedIndex = num2;
								break;
							}
						}
					}
				}
				if (A_5)
				{
					if (A_2 == null)
					{
						b(A_0: true, A_1: false, A_2: false, 0f, global::r.d.a.b.a);
					}
					else
					{
						A_2.a = true;
					}
				}
				else if (A_6)
				{
					if (A_3 == null)
					{
						b(A_0: false, A_1: true, A_2: false, 0f, global::r.d.a.b.a);
					}
					else
					{
						A_3.a = true;
					}
				}
				else
				{
					this.m_dc.b();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				if (!this.m_dn)
				{
					i5.a(this.m_c3, this.m_c2, null, i6.a(this), "MainForm.ProcessCommandLineArgs", "Error attempting to process command line argument.\r\n\r\n" + ex3.Message);
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private bool b(hg A_0)
	{
		if (!A_0.c9() && Operators.CompareString(A_0.ci(), "DefaultRecipe", TextCompare: false) != 0)
		{
			ref fz a_ = ref this.m_c3;
			string A_1 = "RecipeUnsavedPromptFmt3";
			if (!global::fe.b(ref a_, string.Format(hu.a(ref A_1), Strings.LCase("Recipe"), "\r\n", Strings.LCase("Recipe")), "RecipeLoadTitle", "OKString", "CancelString", i6.a(this)))
			{
				return false;
			}
		}
		return true;
	}

	private void ba(object A_0, EventArgs A_1)
	{
		try
		{
			f4 f10 = el();
			by obj = u();
			Guid a_ = default(Guid);
			if (f10 != null)
			{
				a_ = f10.hc();
			}
			else if (obj != null)
			{
				a_ = obj.ca();
			}
			fc obj2 = new fc();
			obj2.Location = checked(new Point(base.Left + 30, base.Top + 30));
			obj2.a(ref this.m_c2, f10, a_, obj != null, this.m_c4, ref this.m_c3);
			v();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.DataAcqToolStripMenuItem_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void a9(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				f4 f10 = el();
				if (f10 != null)
				{
					f10.h0();
				}
				else
				{
					d6 d10 = t();
					if (d10 != null)
					{
						d10.bw();
					}
					else
					{
						u()?.cc();
					}
				}
				this.m_dc.b();
			}
			catch (av av2)
			{
				ProjectData.SetProjectError(av2);
				av av3 = av2;
				SystemSounds.Exclamation.Play();
				fz a_ = this.m_c3;
				string A_2 = "ErrorMessageFileCorrupt";
				global::fe.b(a_, hu.a(ref A_2), "ErrorTitle", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
			catch (aw aw2)
			{
				ProjectData.SetProjectError(aw2);
				aw aw3 = aw2;
				SystemSounds.Exclamation.Play();
				string a_2;
				if (this.m_c2.u2())
				{
					gt gt2 = this.m_c2.wu(el().hc());
					if (!gt2.aw())
					{
						string A_2 = "ErrorMessageInvalidFileOpenTypeSASWFmt";
						a_2 = string.Format(hu.a(ref A_2), "*.fmdmo");
					}
					else if (!gt2.ax())
					{
						string A_2 = "ErrorMessageInvalidFileOpenTypeSASWFmt";
						a_2 = string.Format(hu.a(ref A_2), "*.fmspe, *..fmdmo, *..fmcsp");
					}
					else
					{
						string A_2 = "ErrorMessageInvalidFileOpenTypeSASWFmt";
						a_2 = string.Format(hu.a(ref A_2), "*.fmspe, *.fmdmo, *.fmcsp, *.spe, *.csp");
					}
					gt2 = null;
				}
				else
				{
					string A_2 = "ErrorMessageInvalidFileOpenTypeSASWFmt";
					a_2 = string.Format(hu.a(ref A_2), "Unknown");
				}
				global::fe.b(this.m_c3, a_2, "ErrorTitle", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
			catch (au au2)
			{
				ProjectData.SetProjectError(au2);
				au au3 = au2;
				global::fe.b(this.m_c3, au3.Message, new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.OpenSpectrumOrVsTimeFileToolStripMenuItem_Click", a_3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void a8(object A_0, EventArgs A_1)
	{
	}

	private void a7(object A_0, EventArgs A_1)
	{
		try
		{
			f4 f10 = el();
			if (f10 != null)
			{
				fl fl2 = f10.bb();
				f10.k(fl2.gi(), fl2.e7(), fl2.e8());
				fl2 = null;
				return;
			}
			d6 d10 = t();
			if (d10 != null)
			{
				d10.bx();
			}
			else
			{
				u()?.a(null, 0L, 0L);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.SaveSpectrumToolStripMenuItem_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	public void d(string A_0)
	{
		try
		{
			cs cs2 = new cs();
			Collection<double[]> A_1 = null;
			Collection<DateTime[]> A_2 = null;
			int[] A_3 = new int[0];
			Collection<bool[]> A_4 = null;
			io.m2(A_0, ref A_1, ref A_2, ref A_3, ref A_4);
			cs2.StartPosition = FormStartPosition.CenterScreen;
			cs2.a(this.m_c3, this.m_c2, el(), A_1, A_2, A_3, g2.OpticsConfigSubmoduleTypes.ReflectanceProbe, A_0);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.OpenReferenceHistory", a_);
			ProjectData.ClearProjectError();
		}
	}

	public Guid eh()
	{
		return b((ix.b)null);
	}

	public Guid b(ix.b A_0)
	{
		Guid result;
		try
		{
			if (base.InvokeRequired)
			{
				j method = b;
				object objectValue = RuntimeHelpers.GetObjectValue(Invoke(method, A_0));
				return (objectValue != null) ? ((Guid)objectValue) : default(Guid);
			}
			if (A_0 != null)
			{
				A_0.a = false;
			}
			f4 f10 = el();
			if (f10 != null)
			{
				return f10.hc();
			}
			by obj = u();
			if (obj != null)
			{
				return obj.ca();
			}
			if (A_0 != null)
			{
				A_0.a = true;
			}
			result = default(Guid);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (A_0 != null)
			{
				A_0.a = true;
			}
			result = default(Guid);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public Guid c(ix.b A_0)
	{
		if (base.InvokeRequired)
		{
			k method = c;
			object objectValue = RuntimeHelpers.GetObjectValue(Invoke(method, A_0));
			return (objectValue != null) ? ((Guid)objectValue) : default(Guid);
		}
		d6 d10 = t();
		if (d10 == null)
		{
			f4 f10 = el();
			Guid result;
			if (f10 != null)
			{
				Guid A_1 = default(Guid);
				if (this.m_c2.m2(f10.hc(), ref A_1))
				{
					if (A_0 != null)
					{
						A_0.a = false;
					}
					return A_1;
				}
				if (A_0 != null)
				{
					A_0.a = true;
				}
				result = default(Guid);
			}
			else
			{
				if (A_0 != null)
				{
					A_0.a = true;
				}
				result = default(Guid);
			}
			return result;
		}
		if (A_0 != null)
		{
			A_0.a = false;
		}
		return d10.bu();
	}

	public bool ei()
	{
		if (base.InvokeRequired)
		{
			return Conversions.ToBoolean(Invoke(new l(ei)));
		}
		return el() != null;
	}

	public bool ej()
	{
		if (base.InvokeRequired)
		{
			m method = ej;
			return Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Invoke(method)));
		}
		return t() != null;
	}

	public bool ek()
	{
		if (base.InvokeRequired)
		{
			n method = ek;
			return Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Invoke(method)));
		}
		return em() != null;
	}

	public f4 c(Guid A_0)
	{
		if (base.InvokeRequired)
		{
			return (f4)Invoke(new o(c), A_0);
		}
		foreach (TabPage tabPage in ar().TabPages)
		{
			if (tabPage.Controls[0] is f4)
			{
				f4 f10 = (f4)tabPage.Controls[0];
				if (f10.hc() == A_0)
				{
					return f10;
				}
			}
		}
		return null;
	}

	public void b(f4 A_0)
	{
		if (A_0 == null)
		{
			return;
		}
		foreach (TabPage tabPage in ar().TabPages)
		{
			if (tabPage.Controls[0] is f4 && (f4)tabPage.Controls[0] == A_0)
			{
				ar().SelectedTab = tabPage;
			}
		}
	}

	public f4 el()
	{
		if (base.InvokeRequired)
		{
			return (f4)Invoke(new p(el));
		}
		int selectedIndex = ar().SelectedIndex;
		if (ar().TabPages.Count > 0 && ar().TabPages[selectedIndex].Controls.Count > 0 && ar().TabPages[selectedIndex].Controls[0] is f4)
		{
			return (f4)ar().TabPages[selectedIndex].Controls[0];
		}
		return null;
	}

	public f3 em()
	{
		if (base.InvokeRequired)
		{
			return (f3)Invoke(new q(em));
		}
		int selectedIndex = ar().SelectedIndex;
		if (ar().TabPages.Count > 0 && ar().TabPages[selectedIndex].Controls.Count > 0 && ar().TabPages[selectedIndex].Controls[0] is f3)
		{
			return (f3)ar().TabPages[selectedIndex].Controls[0];
		}
		return null;
	}

	public bool en()
	{
		if (base.InvokeRequired)
		{
			return Conversions.ToBoolean(Invoke(new r(en)));
		}
		return u() != null;
	}

	[SpecialName]
	public gq eo()
	{
		return this.m_d4;
	}

	private by u()
	{
		int selectedIndex = ar().SelectedIndex;
		if (ar().TabPages.Count > 0 && ar().TabPages[selectedIndex].Controls[0] is by)
		{
			return (by)ar().TabPages[selectedIndex].Controls[0];
		}
		return null;
	}

	private d6 t()
	{
		int selectedIndex = ar().SelectedIndex;
		if (ar().TabPages.Count > 0 && ar().TabPages[selectedIndex].Controls[0] is d6)
		{
			return (d6)ar().TabPages[selectedIndex].Controls[0];
		}
		return null;
	}

	private f4 s()
	{
		TabPage tabPage = r();
		if (tabPage != null)
		{
			return (f4)tabPage.Controls[0];
		}
		return null;
	}

	private TabPage r()
	{
		foreach (TabPage tabPage in ar().TabPages)
		{
			if (tabPage.Controls[0] is f4)
			{
				return tabPage;
			}
		}
		return null;
	}

	private TabPage q()
	{
		foreach (TabPage tabPage in ar().TabPages)
		{
			foreach (Control control in tabPage.Controls)
			{
				string name = control.Name;
				string A_ = "HistoryPanelName";
				if (Operators.CompareString(name, hu.a(ref A_), TextCompare: false) == 0)
				{
					return tabPage;
				}
			}
		}
		return null;
	}

	private f3 p()
	{
		TabPage tabPage = q();
		if (tabPage == null)
		{
			return null;
		}
		TabPage tabPage2 = tabPage;
		foreach (Control control in tabPage2.Controls)
		{
			if (control is f3)
			{
				return (f3)control;
			}
		}
		tabPage2 = null;
		return null;
	}

	private f3 o()
	{
		f3 result = null;
		try
		{
			foreach (TabPage tabPage in ar().TabPages)
			{
				foreach (Control control in tabPage.Controls)
				{
					if (control is f3)
					{
						string name = control.Name;
						string A_ = "PrecisionResultsPanelName";
						if (Operators.CompareString(name, hu.a(ref A_), TextCompare: false) == 0)
						{
							result = (f3)control;
							return result;
						}
					}
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c3.c(fz.b.b, "Exception caught in GetPrecisionResultsPanel(). ", a_);
			result = null;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void a6(object A_0, EventArgs A_1)
	{
		try
		{
			new e5(this.m_c3, this.m_c2).b(this, this.m_c2);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.AboutToolStripMenuItem_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a5(object A_0, EventArgs A_1)
	{
		try
		{
			Guid guid = el().hc();
			g2 A_2 = this.m_c2.u9(guid);
			hg hg2 = this.m_c2.wq(guid);
			_ = string.Empty;
			ff ff2 = new ff();
			ff2.Location = checked(new Point(base.Left + 30, base.Top + 30));
			bool a_ = default(bool);
			ff2.a(this.m_c2, guid, A_2, a_, hg.b.a, this.m_c3);
			if (ff2.a9())
			{
				ff2.ba().a(ref A_2);
				hg2.bu(d4(), true, true);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			this.m_c3.c(fz.b.b, "Exception in OpticsConfigurationToolStripMenuItem_Click(). ", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void a4(object A_0, EventArgs A_1)
	{
		a5().PageSettings = a4().DefaultPageSettings;
		_ = null;
		try
		{
			if (a5().ShowDialog() == DialogResult.OK)
			{
				a4().DefaultPageSettings = a5().PageSettings;
				global::e.a().PaperOrientationLandscape = a4().DefaultPageSettings.Landscape;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c3.c(fz.b.b, "Exception in PageSetupToolStripMenuItem_Click(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a3(object A_0, EventArgs A_1)
	{
		b4().Start();
	}

	private void a2(object A_0, EventArgs A_1)
	{
		b4().Stop();
		try
		{
			ep();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.TimerPrinter_Tick", a_);
			ProjectData.ClearProjectError();
		}
	}

	public void ep()
	{
		dd dd2 = new dd();
		f4 f10 = el();
		if (f10 != null)
		{
			f5.a a10;
			bool flag;
			if (this.m_c2.sj(l()) & f10.hq())
			{
				a10 = f5.a.c;
				flag = dd2.a(ref this.m_c3, ref fa, ref fb, ref fc, ref fd) == DialogResult.OK;
			}
			else if (global::eo.at(this.m_c2.sm(f10.hc()), this.m_c2.sn(f10.hc()), l()))
			{
				a10 = f5.a.e;
				flag = true;
			}
			else
			{
				a10 = f5.a.a;
				flag = true;
			}
			if (!flag)
			{
				return;
			}
			b((PrintDocument)null);
			b(new PrintDocument());
			if (this.m_c2.ui())
			{
				PrinterSettings printerSettings = a6().PrinterSettings;
				a6().Document.DefaultPageSettings.Landscape = !this.m_c2.wq(eh()).bz((eo.a)null);
				printerSettings.PrinterName = "Adobe PDF";
				if (!printerSettings.IsValid)
				{
					printerSettings.PrinterName = "Microsoft Print to PDF";
					if (!printerSettings.IsValid)
					{
						global::fe.b(this.m_c3, "Adobe PDF Writer not found.", i6.a(this));
						return;
					}
				}
				a4().DefaultPageSettings = printerSettings.DefaultPageSettings;
				printerSettings = null;
			}
			if (Operators.CompareString(a6().PrinterSettings.PrinterName, "Adobe PDF", TextCompare: false) == 0)
			{
				a6().PrinterSettings.PrintFileName = f10.hd();
				if (this.m_c2.ul())
				{
					jj.b("\\\\dc\\Engineering\\Shipping_Records\\" + DateAndTime.Now.Year);
				}
				else
				{
					jj.b(global::e.a().LastOpenSaveExportTargetImportSourcePath);
				}
			}
			if (a6().ShowDialog() != DialogResult.OK)
			{
				return;
			}
			b(a6().Document);
			a4().PrinterSettings = a6().PrinterSettings;
			bool a_ = false;
			string A_ = null;
			string A_2 = null;
			if (f10.h1() != null)
			{
				a4().DocumentName = f10.h1().b5();
			}
			else
			{
				a4().DocumentName = null;
			}
			string printerName = a4().PrinterSettings.PrinterName;
			bool A_4 = default(bool);
			if (Operators.CompareString(printerName, "Microsoft XPS Document Writer", TextCompare: false) == 0)
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				b2 b10 = new b2();
				b10.a("Microsoft XPS Document (*.xps)", "*.xps", 1);
				saveFileDialog.Filter = b10.b();
				saveFileDialog.InitialDirectory = i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
				saveFileDialog.FileName = a4().DocumentName;
				_ = null;
				if (saveFileDialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				PrinterSettings printerSettings2 = a4().PrinterSettings;
				printerSettings2.PrintFileName = saveFileDialog.FileName;
				printerSettings2.PrintToFile = true;
				_ = null;
			}
			else if (Operators.CompareString(printerName, "Microsoft Print to PDF", TextCompare: false) == 0)
			{
				bool A_3 = default(bool);
				f5.a(a4(), a4().DocumentName, i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath), ref A_3, ref A_4, ref A_, ref A_2);
				if (!A_3)
				{
					return;
				}
				a_ = true;
			}
			f5 A_5 = new f5();
			if (f10.i(ref A_5))
			{
				A_5.a(this.m_c2.wq(eh()));
				A_5.a(f10.hb());
				if (a10 == f5.a.c)
				{
					A_5.v(fa);
					A_5.w(fb);
					A_5.x(fc);
					A_5.y(fd);
				}
				else
				{
					A_5.a(f10.bb().e7());
					A_5.g(f10.bb().e8());
				}
				f5 obj = A_5;
				PrintDocument A_6 = a4();
				obj.a(ref A_6, f10.he(), f10.hf(), a10, a_, A_4, A_, A_2);
				b(A_6);
			}
			else
			{
				Interaction.MsgBox("Error while printing - No valid spectrum.");
			}
		}
		else if (ek() && a6().ShowDialog() == DialogResult.OK)
		{
			b(a6().Document);
			a4().PrinterSettings = a6().PrinterSettings;
			a4().DocumentName = "History";
			f5 A_5 = new f5();
			em().a(ref A_5);
			f5.a a10 = f5.a.f;
			f5 obj2 = A_5;
			PrintDocument A_6 = a4();
			obj2.a(ref A_6, null, null, a10, null, A_5: false, A_6: false, null, null);
			b(A_6);
		}
	}

	private void a1(object A_0, EventArgs A_1)
	{
		try
		{
			fi fi2 = new fi();
			gz gz2 = this.m_c2.ti();
			foreach (Guid item in this.m_c2.tj())
			{
				if (this.m_c2.wq(item).d0().c() == g2.a.b)
				{
					throw new ApplicationException("Functionality has not yet been implemented for R and T autobaseline");
				}
			}
			g1 a_ = gz2.g();
			fi2.a(this.m_c3, this.m_c2, gz2, this.m_c2.ut());
			if (fi2.DialogResult != DialogResult.OK || !g1.d(gz2.g(), a_))
			{
				return;
			}
			foreach (gy item2 in gz2.i())
			{
				this.m_c2.p9(item2.x(), item2.u());
			}
			global::r.d.a a10 = new global::r.e.a(global::r.d.a.b.a, 0L);
			a10.a = global::r.d.a.a.a;
			this.m_c2.sm(a10);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.MeasModulesConfigurationToolStripMenuItem_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, CancelEventArgs A_1)
	{
		checked
		{
			try
			{
				SaveFileDialog saveFileDialog = (SaveFileDialog)A_0;
				a a10 = (a)saveFileDialog.Tag;
				int num = a10.d.a(saveFileDialog.FilterIndex);
				int A_2 = num;
				a a11 = a10;
				switch (A_2)
				{
				case 1:
					if ((float)a11.a > (float)a11.c * 0.75f || (float)a11.a > (float)a11.b * 0.75f)
					{
						if (a11.c < a11.b)
						{
							b(a11.a, ".jpg", a11.c, ".bmp", 3, ref A_2);
						}
						else
						{
							b(a11.a, ".jpg", a11.b, ".png", 2, ref A_2);
						}
					}
					break;
				case 2:
					if ((float)a11.b > (float)a11.c * 1.25f || (float)a11.b * 0.75f > (float)a11.a)
					{
						if (a11.c < a11.a)
						{
							c(a11.b, ".png", a11.c, ".bmp", 3, ref A_2);
						}
						else
						{
							c(a11.b, ".png", a11.a, ".jpg", 1, ref A_2);
						}
					}
					break;
				case 3:
					if ((float)a11.c > (float)a11.b * 1.25f || (float)a11.c * 0.75f > (float)a11.a)
					{
						if (a11.b < a11.a)
						{
							c(a11.c, ".bmp", a11.b, ".png", 2, ref A_2);
						}
						else
						{
							c(a11.c, ".bmp", a11.a, ".jpg", 1, ref A_2);
						}
					}
					break;
				}
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(a10.d.a(saveFileDialog.FileName, a10.d.c(num) + 1));
				saveFileDialog.FilterIndex = a10.d.c(A_2) + 1;
				string path = (saveFileDialog.FileName = a10.d.a(Path.GetDirectoryName(saveFileDialog.FileName) + "\\" + fileNameWithoutExtension, a10.d.c(A_2) + 1));
				if (File.Exists(path))
				{
					SystemSounds.Exclamation.Play();
					ref fz a_ = ref this.m_c3;
					string A_3 = "OverwritePromptFmt1";
					A_1.Cancel = !global::fe.b(ref a_, string.Format(hu.a(ref A_3), Path.GetFileName(path)), "Warning", "Yes", "No", i6.a(this));
				}
				a11 = null;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.ScreenShotFileOk", a_2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void c(long A_0, string A_1, long A_2, string A_3, int A_4, ref int A_5)
	{
		SystemSounds.Exclamation.Play();
		ref fz a_ = ref this.m_c3;
		string A_6 = "SmallerFileTypePromptFmt5";
		if (global::fe.b(ref a_, string.Format(hu.a(ref A_6), A_3, ((double)checked(A_2 * 100) / (double)A_0).ToString("#.#"), A_1, (A_2 / 1024).ToString(), (A_0 / 1024).ToString()), "Information", "Yes", "No", i6.a(this)))
		{
			A_5 = A_4;
		}
	}

	private void b(long A_0, string A_1, long A_2, string A_3, int A_4, ref int A_5)
	{
		SystemSounds.Exclamation.Play();
		ref fz a_ = ref this.m_c3;
		string A_6 = "BetterFileTypePromptFmt5";
		if (global::fe.b(ref a_, string.Format(hu.a(ref A_6), A_3, ((double)checked(A_2 * 100) / (double)A_0).ToString("#.#"), A_1, (A_2 / 1024).ToString(), (A_0 / 1024).ToString()), "Information", "Yes", "No", i6.a(this)))
		{
			A_5 = A_4;
		}
	}

	[DllImport("gdi32.dll")]
	private static extern bool DeleteObject(IntPtr A_0);

	private void a0(object A_0, EventArgs A_1)
	{
		SaveFileDialog saveFileDialog = null;
		Image image = null;
		Bitmap A_2 = null;
		checked
		{
			try
			{
				b2 b10 = new b2();
				b10.a("JPEG File (*.jpg)", "*.jpg", 1);
				b10.a("Portable Network Graphics File (*.png)", "*.png", 2);
				b10.a("Bitmap File (*.bmp)", "*.bmp", 3);
				bool A_3 = default(bool);
				b(ref A_2, ref A_3);
				if (A_3)
				{
					return;
				}
				string text = i3.g();
				string text2 = text + "\\ss.bin";
				IntPtr hbitmap = A_2.GetHbitmap();
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				image = Image.FromHbitmap(hbitmap);
				DeleteObject(hbitmap);
				int filterIndex = global::e.a().LastSaveScreenshotFileTypeIdx;
				image.Save(text2, ImageFormat.Jpeg);
				long length = new FileInfo(text2).Length;
				image.Save(text2, ImageFormat.Png);
				long length2 = new FileInfo(text2).Length;
				image.Save(text2, ImageFormat.Bmp);
				long length3 = new FileInfo(text2).Length;
				File.Delete(text2);
				a a10 = new a();
				a10.a = length;
				a10.b = length2;
				a10.c = length3;
				a10.d = b10;
				_ = null;
				saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = b10.b();
				saveFileDialog.InitialDirectory = i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
				saveFileDialog.FileOk += b;
				saveFileDialog.Tag = a10;
				saveFileDialog.OverwritePrompt = false;
				int num = global::e.a().LastSaveScreenshotFileTypeIdx - 1;
				if (num == b10.c(3))
				{
					if (jf.b(length3, (float)length2 * 1.25f) && (float)length2 * 0.75f < (float)length)
					{
						filterIndex = b10.c(2) + 1;
					}
					else if (jf.b(length3, (float)length * 1.25f))
					{
						filterIndex = b10.c(1) + 1;
					}
				}
				else if (num == b10.c(1))
				{
					if (jf.b(length, (float)length3 * 0.75f) && length3 < length2)
					{
						filterIndex = b10.c(3) + 1;
					}
					else if (jf.b(length, (float)length2 * 0.75f))
					{
						filterIndex = b10.c(2) + 1;
					}
				}
				else if (num == b10.c(2))
				{
					if (jf.b(length2, (float)length3 * 1.25f) && (float)length3 * 0.75f < (float)length)
					{
						filterIndex = b10.c(3) + 1;
					}
					else if (jf.b((float)length2 * 0.75f, length))
					{
						filterIndex = b10.c(1) + 1;
					}
				}
				saveFileDialog.FilterIndex = filterIndex;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					int num2 = b10.a(saveFileDialog.FilterIndex);
					global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(saveFileDialog.FileName);
					global::e.a().LastSaveScreenshotFileTypeIdx = b10.c(num2) + 1;
					string filename = b10.a(saveFileDialog.FileName, b10.c(num2) + 1);
					switch (num2)
					{
					case 1:
						image.Save(filename, ImageFormat.Jpeg);
						break;
					case 2:
						image.Save(filename, ImageFormat.Png);
						break;
					case 3:
						image.Save(filename, ImageFormat.Bmp);
						break;
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.PrintScreenToolStripMenuItem_Click", a_);
				ProjectData.ClearProjectError();
			}
			finally
			{
				if (saveFileDialog != null)
				{
					saveFileDialog.FileOk -= b;
				}
				if (image != null)
				{
					image.Dispose();
					image = null;
				}
				if (A_2 != null)
				{
					A_2.Dispose();
					A_2 = null;
				}
			}
		}
	}

	private void b(ref Bitmap A_0, ref bool A_1)
	{
		f4 f10 = el();
		d6 obj = t();
		bool flag = f10 != null;
		bool flag2 = obj != null;
		bool flag3 = flag && global::e.a().FICPMMMeasDetailsIsCollapsed;
		checked
		{
			try
			{
				Graphics graphics = null;
				Point point = default(Point);
				Control control = ((!global::e.a().ScreenShotIncludesMenuBar) ? ((Control)ar()) : ((Control)this));
				if (flag3)
				{
					f10.eo().Visible = false;
				}
				control.Refresh();
				Graphics graphics2 = control.CreateGraphics();
				Rectangle targetBounds;
				if (global::e.a().ScreenShotIncludesMenuBar)
				{
					point = base.Location;
					A_0 = new Bitmap(control.Width, control.Height, graphics2);
					targetBounds = new Rectangle(0, 0, control.Width, control.Height);
				}
				else
				{
					point = i6.a(control, 0, 0);
					A_0 = new Bitmap(control.ClientSize.Width, control.ClientSize.Height, graphics2);
					targetBounds = new Rectangle(0, 0, control.ClientSize.Width, control.ClientSize.Height);
				}
				control.DrawToBitmap(A_0, targetBounds);
				A_1 = false;
				Graphics graphics3 = Graphics.FromImage(A_0);
				IntPtr hdc = graphics3.GetHdc();
				IntPtr hdc2 = default(IntPtr);
				if (flag)
				{
					f4 f11 = f10;
					if (!flag3)
					{
						graphics = f10.eo().CreateGraphics();
						hdc2 = graphics.GetHdc();
						Point point2 = f11.eo().PointToScreen(f11.eo().ClientRectangle.Location);
						BitBlt(hdc, point2.X - point.X, point2.Y - point.Y, f11.eo().ClientSize.Width, f11.eo().ClientSize.Height, hdc2, 0, 0, 13369376);
					}
					if (f11.h5())
					{
						Graphics graphics4 = f11.br().CreateGraphics();
						IntPtr hdc3 = graphics4.GetHdc();
						Point point2 = f11.br().PointToScreen(f11.br().ClientRectangle.Location);
						BitBlt(hdc, point2.X - point.X, point2.Y - point.Y, f11.br().ClientSize.Width, f11.br().ClientSize.Height, hdc3, 0, 0, 13369376);
						if (graphics4 != null)
						{
							graphics4.ReleaseHdc(hdc3);
							graphics4.Dispose();
						}
					}
					f11 = null;
				}
				else if (!flag2 && ek())
				{
					f3 f12 = (f3)ar().TabPages[ar().TabPages.Count - 1].Controls[0];
					if (f12.bf().SelectedIndex == 0)
					{
						graphics = f12.at().CreateGraphics();
						hdc2 = graphics.GetHdc();
						Point point3 = f12.at().PointToScreen(f12.at().ClientRectangle.Location);
						BitBlt(hdc, point3.X - point.X, point3.Y - point.Y, f12.at().ClientSize.Width, f12.at().ClientSize.Height, hdc2, 0, 0, 13369376);
					}
					f12 = null;
				}
				if (graphics != null)
				{
					graphics.ReleaseHdc(hdc2);
					graphics.Dispose();
				}
				graphics3.ReleaseHdc(hdc);
				graphics2.Dispose();
				graphics3.Dispose();
			}
			finally
			{
				if (flag3)
				{
					f10.eo().Visible = true;
				}
			}
		}
	}

	private bool b(y A_0, a4.a A_1, bool A_2)
	{
		if (A_0.b)
		{
			foreach (x item in A_0.a)
			{
				if (item.a.b == A_1 || (item.a.b == global::a4.a.d && A_2))
				{
					return true;
				}
			}
		}
		return false;
	}

	private void az(object A_0, EventArgs A_1)
	{
		fh fh2 = new fh();
		try
		{
			short a_ = global::e.a().GraphMeasUserDefinedMaxCurves;
			fh2.Location = checked(new Point(base.Left + 30, base.Top + 30));
			bool num = global::e.a().SpectrumColorFixLuminance;
			float num2 = global::e.a().SpectrumColorLumValue;
			bool flag = global::e.a().ShowSpectrumColor;
			short num3 = global::e.a().ShowSpectrumCoordOption;
			bool flag2 = global::e.a().AlwayShowSpectrumCoordXYZ;
			short num4 = global::e.a().SpectrumColorObserver;
			short num5 = global::e.a().SpectrumColorIlluminant;
			bool flag3 = b(this.m_c2.u5().j(), (a4.a)num3, flag2);
			bool flag4 = global::e.a().RestrictColorWavelength;
			float num6 = global::e.a().ColorWavelengthLowerLimitNm;
			float num7 = global::e.a().ColorWavelengthUpperLimitNm;
			f4 f10 = el();
			fh2.a(this.m_c3, this.m_c2, a_, this.m_el, this.m_c2.sm(l()) && (f10 == null || !f10.hp()), f10 != null && this.m_c2.xa(f10.hc()));
			this.m_c2.u5().k();
			bl(this, new EventArgs());
			this.m_dc.b();
			bl(this, new EventArgs());
			bool flag5 = b(this.m_c2.u5().j(), (a4.a)global::e.a().ShowSpectrumCoordOption, global::e.a().AlwayShowSpectrumCoordXYZ);
			bool flag6 = num != global::e.a().SpectrumColorFixLuminance || num2 != global::e.a().SpectrumColorLumValue || flag != global::e.a().ShowSpectrumColor || num3 != global::e.a().ShowSpectrumCoordOption || flag2 != global::e.a().AlwayShowSpectrumCoordXYZ || num4 != global::e.a().SpectrumColorObserver || num5 != global::e.a().SpectrumColorIlluminant || flag3 != flag5 || flag4 != global::e.a().RestrictColorWavelength || num6 != global::e.a().ColorWavelengthLowerLimitNm || num7 != global::e.a().ColorWavelengthUpperLimitNm;
			foreach (TabPage tabPage in ar().TabPages)
			{
				Control.ControlCollection controls = tabPage.Controls;
				if (controls[0] is f4 && flag6)
				{
					((f4)controls[0]).i(global::r.d.a.b.a);
				}
				controls = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.DisplayToolStripMenuItem_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void ay(object A_0, EventArgs A_1)
	{
		try
		{
			f4 f10 = el();
			hr a_ = null;
			if (f10 == null)
			{
				f10 = s();
			}
			if (f10 != null)
			{
				a_ = f10.h1();
			}
			e7 obj = new e7();
			float a_2 = this.m_c2.uy();
			float a_3 = this.m_c2.u0();
			Guid a_4 = f10?.hc() ?? u().ca();
			obj.a(this.m_c3, this.m_c2, f10, ref de, this.m_c2.ut(), l(), this.m_c2.wu(a_4) == null, a_2, a_3, this.m_c2.qh(a_4.ToString()), a_);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_5 = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.MaterialLibraryToolStripMenuItem_Click", a_5);
			ProjectData.ClearProjectError();
		}
	}

	private void ax(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (!this.m_en || ar().TabCount <= 0)
				{
					return;
				}
				f3 f10 = p();
				f3 f11 = o();
				object obj = ar().SelectedTab.Controls[0];
				foreach (TabPage tabPage in ar().TabPages)
				{
					if (tabPage.Controls[0] is f4)
					{
						((f4)tabPage.Controls[0]).t(tabPage.Controls[0] != obj);
					}
					else if (tabPage.Controls[0] is d6)
					{
						((d6)tabPage.Controls[0]).c(tabPage.Controls[0] != obj);
					}
				}
				Rectangle clientRectangle = ar().SelectedTab.ClientRectangle;
				bool flag = default(bool);
				if (f10 != null && Operators.CompareString(ar().SelectedTab.Text, f10.Name, TextCompare: false) == 0)
				{
					f10.a(A_0: true);
					f11?.a(A_0: false);
					f3 obj2 = (f3)obj;
					obj2.a(clientRectangle.Width, clientRectangle.Height);
					obj2.bu();
					_ = null;
				}
				else if (f11 != null && Operators.CompareString(ar().SelectedTab.Text, f11.Name, TextCompare: false) == 0)
				{
					f10?.a(A_0: false);
					f11.a(A_0: true);
					f3 obj3 = (f3)obj;
					obj3.a(clientRectangle.Width, clientRectangle.Height);
					obj3.bu();
					_ = null;
				}
				else
				{
					f10?.a(A_0: false);
					f11?.a(A_0: false);
					if (obj is f4)
					{
						f4 obj4 = (f4)obj;
						obj4.i(clientRectangle.Width, clientRectangle.Height);
						obj4.hl();
						_ = null;
						if (!this.m_c2.u9())
						{
							bool A_2 = default(bool);
							b(RuntimeHelpers.GetObjectValue(obj), ref A_2);
							if (A_2 && global::e.a().ShowWarningSwitchingMeasureTabs)
							{
								flag = true;
							}
						}
					}
					else if (obj is by)
					{
						((by)obj).a(clientRectangle.Width, clientRectangle.Height);
					}
				}
				h();
				this.m_dc.b();
				fw fw2 = ar();
				if (fw2.TabCount > 0 && fw2.ItemSize.Width != unchecked(fw2.ClientSize.Width / fw2.TabCount) - 2)
				{
					fw2.ItemSize = new Size(unchecked(fw2.ClientSize.Width / fw2.TabCount) - 2, fw2.ItemSize.Height);
				}
				fw2 = null;
				ad();
				if (flag)
				{
					b(A_0: false, null);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_c3.c(fz.b.b, "Exception in CustomTabMainform_SelectedIndexChanged(). ", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void b(object A_0, ref bool A_1)
	{
		A_1 = false;
		if (this.m_c2.u9())
		{
			return;
		}
		bool A_2 = default(bool);
		foreach (TabPage tabPage in ar().TabPages)
		{
			if (tabPage.Controls[0] is f4 && tabPage.Controls[0] != A_0)
			{
				((f4)tabPage.Controls[0]).k(ref A_2);
				A_1 = A_1 || A_2;
			}
		}
	}

	public void b(bool A_0, string A_1)
	{
		string arg;
		if (A_0)
		{
			arg = A_1;
		}
		else
		{
			db obj = new db();
			arg = obj.cr().Text;
			obj.Dispose();
		}
		fz a_ = this.m_c3;
		string A_2 = "WarnVideoStoppedFmt";
		string a_2 = string.Format(hu.a(ref A_2), arg);
		Point a_3 = i6.a(this);
		A_2 = "DontWarnMeAgain";
		bool A_3 = default(bool);
		global::fe.b(a_, a_2, "Warning", null, a_3, A_5: true, null, null, hu.a(ref A_2), ref A_3);
		if (global::e.a().ShowWarningSwitchingMeasureTabs != !A_3)
		{
			global::e.a().ShowWarningSwitchingMeasureTabs = !A_3;
		}
	}

	private void aw(object A_0, EventArgs A_1)
	{
		try
		{
			Guid guid = eh();
			global::h.MeasurementTimingType a_ = this.m_c2.wq(guid).b8().n(this.m_c2.sm(guid));
			cr obj = new cr(this.m_c3);
			a9[] A_2 = null;
			this.m_c2.m2(guid, ref A_2);
			obj.a(a_, A_2, this.m_c2, guid, el(), this.m_c4);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.DiagnosticsStripMenuItem_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void av(object A_0, EventArgs A_1)
	{
		try
		{
			Close();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.ExitToolStripMenuItem_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void au(object A_0, EventArgs A_1)
	{
		try
		{
			f4 obj = el();
			fl fl2 = obj.bb();
			obj.i(fl2.e7(), fl2.e8());
			fl2 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.SaveNkToolStripMenuItem_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, ElapsedEventArgs A_1)
	{
		if (base.InvokeRequired)
		{
			s method = b;
			BeginInvoke(method, A_0, A_1);
		}
		else
		{
			Close();
		}
	}

	private void at(object A_0, EventArgs A_1)
	{
		try
		{
			dw obj = new dw(this.m_c3);
			f4 f10 = el();
			by obj2 = u();
			Guid a_ = default(Guid);
			if (f10 == null)
			{
				if (obj2 == null)
				{
					f10 = s();
					if (f10 != null)
					{
						a_ = f10.hc();
					}
				}
				else
				{
					a_ = obj2.ca();
				}
			}
			else
			{
				a_ = f10.hc();
			}
			obj.a(this.m_c2, a_, f10?.h1(), null, obj2 != null);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.SupportToolStripMenuItem_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void @as(object A_0, EventArgs A_1)
	{
		try
		{
			string A_2 = null;
			string[] A_3 = null;
			string[] A_4 = null;
			string a_ = i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
			i7 obj = global::a2.a;
			string A_5 = "ImportLicenseFileTitle";
			bool A_6 = default(bool);
			bool A_7 = default(bool);
			bool A_8 = default(bool);
			obj.c(hu.a(ref A_5), a_, i7.f(), ref A_6, ref A_2, ref A_3, ref A_4, ref A_7, ref A_8);
			if (!A_6)
			{
				global::e.a().LastOpenSaveExportTargetImportSourcePath = A_2;
				if (A_3 != null && A_3.Length > 0)
				{
					i8.b(A_3, this.m_c3, i6.a(this));
				}
				if (A_4 != null && A_4.Length > 0)
				{
					i8.a(A_4, this.m_c3, i6.a(this));
					b(A_7, A_8, A_2: false, 0f, global::r.d.a.b.a);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.ToolStripMenuItemFileImportLicense_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void ar(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				b2 b10 = new b2();
				el();
				string A_2 = "ImportOpticFileTitle";
				openFileDialog.Title = hu.a(ref A_2);
				openFileDialog.InitialDirectory = i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
				b10.a("Optic Files", "*.fictm;*.fimic;*.fimpr", 0);
				b10.a("FILMeasure 4 Objectives", "*.dat", 0);
				openFileDialog.Filter = b10.b();
				openFileDialog.Multiselect = true;
				if (openFileDialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(openFileDialog.FileName);
				string text = i3.o() + "\\Optics\\";
				List<string> list = new List<string>();
				string[] fileNames = openFileDialog.FileNames;
				foreach (string text2 in fileNames)
				{
					string fileName = Path.GetFileName(text2);
					if (File.Exists(text + fileName))
					{
						ref fz a_ = ref this.m_c3;
						A_2 = "OverwritePromptFmt1";
						if (global::fe.b(ref a_, string.Format(hu.a(ref A_2), fileName), "ImportOpticFileTitle", "Yes", "No", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2))))
						{
							list.Add(text2);
						}
					}
					else
					{
						list.Add(text2);
					}
				}
				string A_3 = null;
				this.m_c2.m2(list.ToArray(), global::e.a().OperatorID, global::r.d.a.b.a, ref A_3);
				if (string.IsNullOrEmpty(A_3))
				{
					A_3 = "Import Optic Configuration files finished";
				}
				global::fe.b(this.m_c3, A_3, "ImportOpticFileTitle", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.ImportOpticsToolStripMenuItem_Click", a_2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void aq(object A_0, EventArgs A_1)
	{
		try
		{
			string text = jb.d();
			OpenFileDialog openFileDialog = new OpenFileDialog();
			b2 b10 = new b2();
			string A_2 = "ImportMaterialFileTitle";
			openFileDialog.Title = hu.a(ref A_2);
			openFileDialog.InitialDirectory = i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
			b10.a(jb.c(), jb.b(), 0);
			b10.a(global::ex.h(), global::ex.g(), 1);
			openFileDialog.Filter = b10.b();
			openFileDialog.Multiselect = true;
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(openFileDialog.FileName);
			if (!Directory.Exists(text))
			{
				Microsoft.VisualBasic.FileSystem.MkDir(text);
			}
			Collection<string> collection = new Collection<string>();
			string[] fileNames = openFileDialog.FileNames;
			for (int num = 0; num < fileNames.Length; num = checked(num + 1))
			{
				jb.a(fileNames[num], A_1: false, A_2: false, collection);
			}
			foreach (string item in collection)
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(item);
				string text2 = text + "\\" + Path.GetFileName(item);
				string text3;
				if (jb.d(text2))
				{
					if (jb.n(item))
					{
						A_2 = "MaterialLCase";
						text3 = hu.a(ref A_2);
					}
					else if (jb.j(item))
					{
						A_2 = "RefractiveIndex";
						text3 = hu.a(ref A_2);
					}
					else
					{
						A_2 = "ExtinctionCoefficient";
						text3 = hu.a(ref A_2);
					}
				}
				else
				{
					if (!global::ex.g(text2))
					{
						throw new ApplicationException("Selected file type is not a material file");
					}
					A_2 = "MaterialReferenceFileName";
					text3 = hu.a(ref A_2);
				}
				bool flag = false;
				if (File.Exists(text2))
				{
					SystemSounds.Exclamation.Play();
					ref fz a_ = ref this.m_c3;
					A_2 = "FileReplaceWarningMsgMatFmt2";
					flag = global::fe.b(ref a_, string.Format(hu.a(ref A_2), text3, fileNameWithoutExtension), "ImportMaterialFileTitle", "Yes", "No", i6.a(this));
				}
				else
				{
					Collection<string> collection2 = new Collection<string>();
					Collection<string> collection3 = new Collection<string>();
					Collection<string> collection4 = new Collection<string>();
					if (jb.d(text2))
					{
						bool flag2;
						bool flag3;
						if (jb.n(text2))
						{
							flag2 = true;
							flag3 = true;
						}
						else
						{
							flag2 = jb.j(text2);
							flag3 = !flag2;
						}
						collection2.Add(Path.ChangeExtension(text2, ".fibnk"));
						collection4.Add(jb.h() + "\\" + Path.ChangeExtension(Path.GetFileName(text2), ".fibnk"));
						collection3.Add(Path.ChangeExtension(text2, ".fitnk"));
						if (flag2)
						{
							collection2.Add(Path.ChangeExtension(text2, ".fmnnn"));
							collection4.Add(jb.h() + "\\" + Path.ChangeExtension(Path.GetFileName(text2), ".fmnnn"));
							collection4.Add(jb.h() + "\\" + Path.ChangeExtension(Path.GetFileName(text2), ".nnn"));
							collection3.Add(Path.ChangeExtension(text2, ".nnn"));
						}
						if (flag3)
						{
							collection2.Add(Path.ChangeExtension(text2, ".fmkkk"));
							collection3.Add(Path.ChangeExtension(text2, ".kkk"));
						}
					}
					else if (global::ex.g(text2))
					{
						if (jb.ae(text2) || jb.ac(Path.GetFileName(text2)))
						{
							collection3.Add(Path.ChangeExtension(text2, ".rrr"));
							collection2.Add(Path.ChangeExtension(text2, ".fmrrr"));
							collection2.Add(Path.ChangeExtension(text2, ".fitdr"));
							collection4.Add(jb.h() + "\\" + Path.ChangeExtension(Path.GetFileName(text2), ".rrr"));
							collection4.Add(jb.h() + "\\" + Path.ChangeExtension(Path.GetFileName(text2), ".fmrrr"));
							collection4.Add(jb.h() + "\\" + Path.ChangeExtension(Path.GetFileName(text2), ".fitdr"));
						}
						else if (jb.ad(text2))
						{
							collection3.Add(Path.ChangeExtension(text2, ".ttt"));
							collection2.Add(Path.ChangeExtension(text2, ".fmttt"));
							collection4.Add(jb.h() + "\\" + Path.ChangeExtension(Path.GetFileName(text2), ".ttt"));
							collection4.Add(jb.h() + "\\" + Path.ChangeExtension(Path.GetFileName(text2), ".fmttt"));
						}
					}
					bool flag4 = false;
					foreach (string item2 in collection2)
					{
						if (File.Exists(item2))
						{
							flag4 = true;
							break;
						}
					}
					bool flag5 = false;
					foreach (string item3 in collection3)
					{
						if (File.Exists(item3))
						{
							flag5 = true;
							break;
						}
					}
					bool flag6 = false;
					foreach (string item4 in collection4)
					{
						if (File.Exists(item4))
						{
							flag6 = true;
							break;
						}
					}
					if (flag6)
					{
						flag = false;
						global::fe.b(this.m_c3, "A " + text3 + " with the name " + Path.GetFileNameWithoutExtension(text2) + " exists in the Online Materials Database.\r\nAltering the database by importing a file is not permitted.\r\n\r\nFile cannot be imported.\r\n\r\nYou must change the name of the file before you will be permitted to import it.", i6.a(this));
					}
					else if (flag4 || flag5)
					{
						string a_2;
						if (flag4)
						{
							A_2 = "FileReplaceWarningMsgOfficialMatFmt2";
							a_2 = string.Format(hu.a(ref A_2), text3, fileNameWithoutExtension);
						}
						else
						{
							A_2 = "FileReplaceWarningMsgMatFmt2";
							a_2 = string.Format(hu.a(ref A_2), text3, fileNameWithoutExtension);
						}
						SystemSounds.Exclamation.Play();
						if (global::fe.b(ref this.m_c3, a_2, "ImportMaterialFileTitle", "Yes", "No", i6.a(this)))
						{
							foreach (string item5 in collection2)
							{
								if (File.Exists(item5) && Operators.CompareString(item5.ToLower(), text2.ToLower(), TextCompare: false) != 0)
								{
									File.Delete(item5);
								}
							}
							foreach (string item6 in collection3)
							{
								if (File.Exists(item6) && Operators.CompareString(item6.ToLower(), text2.ToLower(), TextCompare: false) != 0)
								{
									File.Delete(item6);
								}
							}
							flag = true;
						}
					}
					else
					{
						flag = true;
					}
				}
				if (flag && Operators.CompareString(item.ToLower(), text2.ToLower(), TextCompare: false) != 0)
				{
					File.Copy(item, text2, overwrite: true);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.ToolStripMenuItemFileImportMaterial_Click", a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void ap(object A_0, EventArgs A_1)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		checked
		{
			try
			{
				string A_2 = "ImportRecipeFileTitle";
				openFileDialog.Title = hu.a(ref A_2);
				openFileDialog.InitialDirectory = i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
				openFileDialog.Filter = "Recipe Files |*.fitrp;*.fitra;*.rpe;*.fibra;*.fibrp";
				openFileDialog.Multiselect = true;
				if (openFileDialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(openFileDialog.FileName);
				ay ay2 = new ay();
				ay2.g(i3.d(hg.bz()));
				ay obj = ay2;
				A_2 = "RecipeFolderDescriptionImport";
				obj.h(hu.a(ref A_2));
				if (ay2.g(this) != DialogResult.OK)
				{
					return;
				}
				string text = ay2.f();
				if (!text.StartsWith(hg.bz(), StringComparison.CurrentCultureIgnoreCase))
				{
					fz a_ = this.m_c3;
					A_2 = "RecipeImportTargetInvalidPathFmt";
					global::fe.b(a_, string.Format(hu.a(ref A_2), hg.bz()), i6.a(this));
					return;
				}
				ay2 = null;
				bool A_3 = false;
				string obj2 = hg.bz();
				obj2.Substring(obj2.LastIndexOf("\\") + 1);
				_ = null;
				string[] fileNames = openFileDialog.FileNames;
				int A_4 = default(int);
				int A_5 = default(int);
				int A_6 = default(int);
				for (int num = 0; num < fileNames.Length; num++)
				{
					hg.bu(fileNames[num], text, A_2: false, this.m_c3, new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)), ref A_4, ref A_5, ref A_6, ref A_3, A_9: false);
				}
				if (A_3 && this.m_c2.ui())
				{
					gf.a();
				}
				eo eo2 = this.m_c2.ut();
				string text2 = null;
				string text3 = null;
				if (A_5 > 0 && eo2.a0(null) && !this.m_c2.m2(null))
				{
					text2 = "Thickness measurement";
					if (A_5 > 1)
					{
						text3 = "s";
					}
				}
				else if (A_6 > 0 && !eo2.a0(null))
				{
					text2 = "Spectrum Analysis";
					if (A_6 > 1)
					{
						text3 = "s";
					}
				}
				if (!string.IsNullOrEmpty(text2))
				{
					string text4 = "Restart software with suitable system connected or with suitable license file installed";
					ref fz a_2 = ref this.m_c3;
					string a_3 = text2 + " recipes cannot be edited or used in the current software configuration.\r\nImported " + text2 + " recipe" + text3 + " will not appear in the recipe list.\r\n" + text4 + " to edit or use imported " + text2 + " recipe" + text3 + ".";
					Point A_7 = i6.a(this);
					global::fe.b(ref a_2, a_3, ref A_7);
				}
				eo2 = null;
				if (openFileDialog.FileNames.GetUpperBound(0) + 1 > A_4)
				{
					fz a_4 = this.m_c3;
					A_2 = "RecipeImportCompleteMessage";
					global::fe.b(a_4, hu.a(ref A_2), "Information", i6.a(this));
				}
				else
				{
					fz a_5 = this.m_c3;
					A_2 = "RecipeImportNoneImported";
					global::fe.b(a_5, hu.a(ref A_2), "Information", i6.a(this));
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_6 = ex2;
				i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.ToolStripMenuItemFileImportRecipe_Click", a_6);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ao(object A_0, EventArgs A_1)
	{
		try
		{
			b(hg.g.a, global::r.d.a.b.a);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.ToolStripMenuItemFileExportRecipe_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void an(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				string[] A_2 = null;
				string A_4;
				if (Directory.Exists(jb.h()))
				{
					LicenseLevel A_3 = default(LicenseLevel);
					bool a_ = global::d9.a(this.m_c3, this.m_c2.uf(), i6.a(this), ref A_3);
					c4 obj = new c4();
					fz a_2 = this.m_c3;
					f1 a_3 = this.m_c2;
					f4 a_4 = el();
					string a_5 = this.m_c2.uf();
					LicenseLevel a_6 = A_3;
					bool a_7 = this.m_c2.un();
					A_4 = null;
					eb.a A_5 = global::eb.a.a;
					bool A_6 = false;
					bool A_7 = false;
					obj.a(a_2, a_3, a_4, global::c4.a.d, A_4: true, A_5: true, A_6: true, A_7: false, a_5, a_6, global::eb.b.a, A_11: false, a_, null, a_7, ref A_4, ref A_5, ref A_6, ref A_2, A_19: false, A_20: false, ref A_7);
					if (obj.DialogResult == DialogResult.Cancel)
					{
						return;
					}
				}
				else
				{
					OpenFileDialog openFileDialog = new OpenFileDialog();
					b2 b10 = new b2();
					A_4 = "ExportMaterialFilesFileDialogTitle";
					openFileDialog.Title = hu.a(ref A_4);
					openFileDialog.InitialDirectory = i3.d(jb.d());
					b10.a(jb.c(), jb.b(), 0);
					b10.a(global::ex.h(), global::ex.g(), 1);
					openFileDialog.Filter = b10.b();
					openFileDialog.Multiselect = true;
					if (openFileDialog.ShowDialog() == DialogResult.Cancel)
					{
						return;
					}
					A_2 = openFileDialog.FileNames;
				}
				string empty = string.Empty;
				ay ay2 = new ay();
				ay2.g(i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath));
				ay obj2 = ay2;
				A_4 = "MaterialFolderDescription";
				obj2.h(hu.a(ref A_4));
				if (ay2.g(this) != DialogResult.OK)
				{
					return;
				}
				global::e.a().LastOpenSaveExportTargetImportSourcePath = ay2.f();
				string text = ay2.f();
				ay2 = null;
				Collection<string> collection = new Collection<string>();
				bool a_8 = jb.e(A_2[0]);
				string[] array = A_2;
				for (int num = 0; num < array.Length; num++)
				{
					jb.a(array[num], A_1: false, a_8, collection);
				}
				foreach (string item in collection)
				{
					string fileName = Path.GetFileName(item);
					empty = text + "\\" + fileName;
					if (File.Exists(empty))
					{
						SystemSounds.Exclamation.Play();
						ref fz a_9 = ref this.m_c3;
						A_4 = "FileExportWarningMsgFmt";
						if (!global::fe.b(ref a_9, string.Format(hu.a(ref A_4), fileName), "ExportMaterialFileTitle", "Yes", "No", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2))))
						{
							continue;
						}
					}
					global::c.e().FileSystem.CopyFile(item, empty, overwrite: true);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_10 = ex2;
				i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.ToolStripMenuItemFileExportMaterial_Click", a_10);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void am(object A_0, EventArgs A_1)
	{
		ay ay2 = new ay();
		ay2.g(i3.d(i3.b()));
		ay obj = ay2;
		string A_2 = "SystemInfoFolderDescription";
		obj.h(hu.a(ref A_2));
		if (ay2.g(this) == DialogResult.OK)
		{
			string a_ = ay2.f();
			ay2 = null;
			this.m_c2.tf(a_);
		}
	}

	private void al(object A_0, EventArgs A_1)
	{
		global::e4.aa();
		OpenFileDialog openFileDialog = new OpenFileDialog();
		el();
		try
		{
			openFileDialog.Title = "Open Template File";
			string empty = string.Empty;
			openFileDialog.InitialDirectory = i3.d(fe);
			openFileDialog.Filter = "Template Files (.fmtpm)|*.fmtpm";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				fe = Path.GetDirectoryName(openFileDialog.FileName);
				empty = openFileDialog.FileName;
				new f8(this.m_c3).v(empty);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.OpenMeasuredTemplateToolStripMenuItem_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void e(global::r.d.a A_0)
	{
		checked
		{
			try
			{
				if (base.InvokeRequired)
				{
					global::r.d.b method = e;
					BeginInvoke(method, A_0);
				}
				else if (A_0.a != global::r.d.a.a.a)
				{
					global::fe.b(this.m_c3, "Error attempting to update MeasModuleSettings configuration", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_c3.c(fz.b.b, "Exception caught in MainForm.MeasModuleSettingsUpdatedFinishedHandler()", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ak(object A_0, EventArgs A_1)
	{
		try
		{
			f4 f10 = el();
			d6 d10 = t();
			by obj = u();
			if (f10 != null)
			{
				f10.h3();
			}
			else if (d10 != null)
			{
				d10.bv();
			}
			else
			{
				obj?.a(0L, 0L);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.ToolStripButtonClearGraph_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void aj(object A_0, EventArgs A_1)
	{
		try
		{
			b(hg.g.b, global::r.d.a.b.a);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.ToolStripMenuItemFileExportRecipeAsRpe_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(hg.g A_0, global::r.d.a.b A_1)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		ix.b b10 = new ix.b();
		Guid a_ = c(b10);
		ix.b b11 = new ix.b();
		if (b10.a)
		{
			a_ = b(b11);
		}
		hg hg2 = null;
		if (!b10.a || !b11.a)
		{
			hg2 = this.m_c2.wq(a_);
		}
		Collection<Guid> collection = this.m_c2.tj();
		if (hg2 == null && this.m_c2.tl().Count == 1)
		{
			bool flag = true;
			Guid A_2 = default(Guid);
			foreach (Guid item in collection)
			{
				if (!this.m_c2.m2(item, ref A_2))
				{
					flag = false;
					return;
				}
			}
			if (flag)
			{
				hg2 = this.m_c2.wq(A_2);
			}
		}
		if (hg2 == null && collection.Count == 1)
		{
			hg2 = this.m_c2.wq(collection[0]);
		}
		bool flag2 = this.m_c2.sj((eo.a)null);
		bool flag3 = !flag2 || this.m_c2.m2(l());
		if (!flag3)
		{
			foreach (Guid item2 in collection)
			{
				if (this.m_c2.uz(item2))
				{
					flag3 = true;
					break;
				}
			}
		}
		string a_3;
		string A_3;
		if (hg2 != null)
		{
			hg hg3 = hg2;
			if (!hg3.c9())
			{
				ref fz a_2 = ref this.m_c3;
				A_3 = "RecipeExportNotSavedWarning";
				if (!global::fe.b(ref a_2, hu.a(ref A_3), "Warning", "ContinueWithoutSaving", "CancelString", i6.a(this)))
				{
					return;
				}
			}
			a_3 = hg3.c1().Substring(0, hg3.c1().LastIndexOf("\\"));
			hg3 = null;
		}
		else
		{
			a_3 = hg.bz();
		}
		A_3 = "RecipeDialogTitle";
		openFileDialog.Title = hu.a(ref A_3);
		openFileDialog.InitialDirectory = i3.d(a_3);
		b2 b12 = new b2();
		checked
		{
			if (A_0 == hg.g.a)
			{
				if (flag3)
				{
					hg.bu(b12, !flag2);
				}
				if (flag2)
				{
					hg.bv(b12, !flag3);
				}
				if (flag2 && flag3)
				{
					hg.bu(b12);
				}
				openFileDialog.Filter = b12.b();
				if (hg2 == null)
				{
					if (b12.c(2) >= 0)
					{
						openFileDialog.FilterIndex = b12.c(2) + 1;
					}
				}
				else if (hg2.b5())
				{
					openFileDialog.FilterIndex = b12.c(1) + 1;
				}
				else
				{
					openFileDialog.FilterIndex = b12.c(0) + 1;
				}
			}
			else
			{
				openFileDialog.Filter = "Recipe Files (.fitrp)|*.fitrp";
			}
			openFileDialog.Multiselect = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				ay ay2 = new ay();
				ay2.g(i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath));
				ay obj = ay2;
				A_3 = "RecipeFolderDescription";
				obj.h(hu.a(ref A_3));
				if (ay2.g(this) == DialogResult.OK)
				{
					global::e.a().LastOpenSaveExportTargetImportSourcePath = ay2.f();
					string a_4 = ay2.f();
					ay2 = null;
					hg.bu(this.m_c3, A_0, a_4, openFileDialog.FileNames, i6.a(this), A_1, hg.b4());
				}
			}
		}
	}

	private void ai(object A_0, EventArgs A_1)
	{
		try
		{
			f4 f10 = el();
			f10.hb();
			de obj = new de();
			by obj2 = u();
			obj.Location = i6.a(f10.eq(), 0, 0);
			obj.a(this.m_c2, f10, this.m_dg[0], this.m_dc, this.m_c3, this.m_d4, obj2 != null);
			bl(this, new EventArgs());
			this.m_dc.b();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c3.c(fz.b.b, "Exception in RawSignalToolStripMenuItem_Click(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(string A_0)
	{
		Collection<a5> collection = global::a5.d(A_0);
		string text = i3.o() + "\\TechSupport";
		string text2 = "";
		if (Directory.Exists(text))
		{
			try
			{
				Directory.Delete(text, recursive: true);
			}
			catch (UnauthorizedAccessException ex2)
			{
				ProjectData.SetProjectError(ex2);
				UnauthorizedAccessException ex3 = ex2;
				throw new UnauthorizedAccessException("Attempt to delete tempTechSupportDir denied.\r\nRoot error regarding dir " + text + ".\r\nRoot error message is: " + ex3.Message + "\r\nOne possible cause of this error is if temp files were created while running process as Administrator.\r\nTypical cure for this problem is to use Windows Explorer to delete " + text);
			}
		}
		Directory.CreateDirectory(text);
		checked
		{
			global::a5.d(collection, 0, collection.Count - 1, text);
			int num = collection.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				global::a5.d(collection[num2]);
			}
			StreamReader streamReader = new StreamReader(text + "\\TSR Summary.txt");
			string text3 = null;
			string text4 = null;
			try
			{
				do
				{
					string text5 = streamReader.ReadLine();
					if (text5.StartsWith("Company name: "))
					{
						text3 = text5.Substring("Company name: ".Length);
					}
					else if (text5.StartsWith("User name: "))
					{
						text4 = text5.Substring("User name: ".Length).Trim();
						text4 = i3.g(text4);
					}
				}
				while (!streamReader.EndOfStream);
			}
			finally
			{
				streamReader.Close();
			}
			string text6 = ((!string.IsNullOrEmpty(text3) && Operators.CompareString(text3.Trim(), "~Unknown~", TextCompare: false) != 0) ? text3 : (string.IsNullOrEmpty(text4) ? "Unknown" : text4));
			DateTime dateTime = collection[collection.Count - 1].g().ToLocalTime();
			text6 = text6 + " " + dateTime.Year.ToString("00") + "_" + dateTime.Month.ToString("00") + "_" + dateTime.Day.ToString("00") + " " + dateTime.Hour.ToString("00") + "_" + dateTime.Minute.ToString("00") + "_" + dateTime.Second.ToString("00");
			text6 = i3.g(text6);
			bool flag = Directory.Exists(global::e.a().TechSupportFilesRootPath);
			if (!flag)
			{
				try
				{
					Directory.CreateDirectory(global::e.a().TechSupportFilesRootPath);
					flag = true;
				}
				catch (Exception ex4)
				{
					ProjectData.SetProjectError(ex4);
					Exception ex5 = ex4;
					flag = false;
					ProjectData.ClearProjectError();
				}
			}
			if (!flag)
			{
				ay ay2 = new ay();
				ay2.g(i3.d(global::c.e().FileSystem.SpecialDirectories.MyDocuments));
				ay obj = ay2;
				string A_1 = "TechSupportArchiveTargetFolderImport";
				obj.h(hu.a(ref A_1));
				if (ay2.g(this) != DialogResult.OK)
				{
					return;
				}
				global::e.a().TechSupportFilesRootPath = ay2.f();
				ay2 = null;
			}
			string text7 = global::e.a().TechSupportFilesRootPath + "\\" + text6;
			if (Directory.Exists(text7))
			{
				Directory.Delete(text7, recursive: true);
			}
			Directory.CreateDirectory(text7);
			global::c.e().FileSystem.CopyDirectory(text, text7);
			int num3 = 0;
			ReadOnlyCollection<string> files = global::c.e().FileSystem.GetFiles(text7);
			bool flag2 = false;
			ReadOnlyCollection<string> readOnlyCollection = files;
			while (num3 < readOnlyCollection.Count && !flag2)
			{
				if (readOnlyCollection[num3].Contains("ActiveRecipe"))
				{
					flag2 = true;
				}
				else
				{
					num3++;
				}
			}
			readOnlyCollection = null;
			if (flag2)
			{
				string path = global::e.a().TechSupportRecipesRootPath;
				flag = Directory.Exists(path);
				if (!flag)
				{
					try
					{
						Directory.CreateDirectory(path);
						flag = true;
					}
					catch (Exception ex6)
					{
						ProjectData.SetProjectError(ex6);
						Exception ex7 = ex6;
						flag = false;
						ProjectData.ClearProjectError();
					}
				}
				if (!flag)
				{
					ay ay3 = new ay();
					ay3.g(i3.d(hg.bz()));
					ay obj2 = ay3;
					string A_1 = "TechSupportRecipeTargetFolderImport";
					obj2.h(hu.a(ref A_1));
					if (ay3.g(this) != DialogResult.OK)
					{
						return;
					}
					if (!ay3.f().ToLower().StartsWith(hg.bz().ToLower()))
					{
						global::fe.b(this.m_c3, "Imported Recipes must be stored within" + hg.bz(), i6.a(this));
						return;
					}
					global::e.a().TechSupportRecipesRootPath = ay3.f();
					ay3 = null;
				}
				text2 = global::e.a().TechSupportRecipesRootPath + "\\" + text6;
				if (Directory.Exists(text2))
				{
					Directory.Delete(text2, recursive: true);
				}
				Directory.CreateDirectory(text2);
				string fileName = Path.GetFileName(files[num3]);
				int num4 = fileName.IndexOf("(") + 1;
				string text8 = fileName.Substring(num4, fileName.LastIndexOf(")") - num4);
				fileName = null;
				bool A_2 = false;
				hg.bu(this.m_c3, files[num3], text2, A_3: false, ref A_2, A_5: true);
				if (A_2 && this.m_c2.ui())
				{
					gf.a();
				}
				ReadOnlyCollection<string> files2 = global::c.e().FileSystem.GetFiles(text2);
				global::c.e().FileSystem.RenameFile(files2[0], text8 + Path.GetExtension(files2[0]));
				files2 = null;
			}
			else
			{
				ref fz a_ = ref this.m_c3;
				Point A_3 = i6.a(this);
				global::fe.b(ref a_, "User did not supply active recipe. User-supplied recipe will not be loaded.", ref A_3);
			}
			string text9 = text + "\\Settings.txt";
			if (global::c.e().FileSystem.FileExists(text9))
			{
				StreamReader streamReader2 = new StreamReader(text9);
				bool flag3 = false;
				float num5 = default(float);
				float num6 = default(float);
				do
				{
					string text5 = streamReader2.ReadLine();
					if (text5.StartsWith("Spectrum Graph Minimum Wavelength: "))
					{
						num5 = (float)Conversion.Val(text5.Substring("Spectrum Graph Minimum Wavelength: ".Length));
						text5 = streamReader2.ReadLine();
						num6 = (float)Conversion.Val(text5.Substring("Spectrum Graph Maximum Wavelength: ".Length));
						flag3 = true;
					}
				}
				while (!flag3);
				streamReader2.Close();
				this.m_df[0].am(num5);
				this.m_df[0].an(num6);
			}
			else
			{
				ref fz a_2 = ref this.m_c3;
				Point A_3 = i6.a(this);
				global::fe.b(ref a_2, "User did not supply settings. Wavelength range of graph cannot be set to match user's settings.", ref A_3);
			}
			int num7 = 0;
			string text10 = string.Empty;
			string text11 = null;
			ReadOnlyCollection<string> files3;
			for (files3 = global::c.e().FileSystem.GetFiles(text); num7 < files3.Count && !files3[num7].Contains("ActiveSpec"); num7++)
			{
			}
			if (num7 < files3.Count)
			{
				text10 = files3[num7];
			}
			int num8;
			for (num8 = 0; num8 < files3.Count && !files3[num8].Contains("LicRepData.fiblr"); num8++)
			{
			}
			if (num8 < files3.Count)
			{
				text11 = files3[num8];
			}
			files3 = null;
			if (!string.IsNullOrEmpty(text10) && global::c.e().FileSystem.FileExists(text10))
			{
				f4 f10 = el();
				long a_3 = this.m_c2.sn(f10.hb());
				string obj3 = text10;
				string text12 = obj3.Substring(obj3.LastIndexOf("\\") + 1);
				_ = null;
				string obj4 = text12;
				text12 = obj4.Substring(obj4.IndexOf("(") + 1);
				_ = null;
				string text13 = text12;
				text12 = text13.Substring(0, text13.IndexOf(")"));
				text13 = null;
				f10.i(text10, "TSR " + text6 + " (" + text12 + ")", a_3, global::r.d.a.b.a);
				f10 = null;
			}
			else
			{
				ref fz a_4 = ref this.m_c3;
				Point A_3 = i6.a(this);
				global::fe.b(ref a_4, "User did not supply spectrum. Unable to load spectrum from user.", ref A_3);
			}
			if (flag2)
			{
				Guid a_5 = eh();
				ReadOnlyCollection<string> files4 = global::c.e().FileSystem.GetFiles(text2);
				bool flag4 = this.m_c2.ut().a0(l());
				if (files4[0].ToLower().EndsWith(".fitra"))
				{
					if (!flag4)
					{
						global::fe.b(this.m_c3, "Imported recipe can only be opened in Spectrum Analysis mode.\r\nCurrent license permissions do not allow Spectrum Analysis mode to be active.", i6.a(this));
						return;
					}
					f4 f11 = el();
					if (f11.dm().SelectedTab != f11.dn())
					{
						f11.dm().SelectedTab = f11.dn();
					}
					f11 = null;
					this.m_c2.wq(a_5).bu(files4[0], hg.b4(), d4(), global::r.d.a.b.a, A_4: false, A_5: true, i6.a(this), global::e.a().OperatorID, this.m_c2.w9(a_5), !this.m_c2.w6(a_5), this.m_c3, this.m_c2.xk(a_5), A_12: false, A_13: false, null, A_15: false);
				}
				else
				{
					if (flag4 && !this.m_c2.m2(l()))
					{
						global::fe.b(this.m_c3, "Imported recipe can only be opened in Thickness Measurement mode.\r\nCurrent license permissions do not allow Thickness Measurement mode to be active.", i6.a(this));
						return;
					}
					f4 f12 = el();
					if (f12.dm().SelectedTab == f12.dn())
					{
						f12.dm().SelectedTab = f12.dr();
					}
					f12 = null;
					this.m_c2.wq(a_5).bu(files4[0], hg.b4(), d4(), global::r.d.a.b.a, A_4: true, A_5: true, i6.a(this), global::e.a().OperatorID, this.m_c2.w9(a_5), !this.m_c2.w6(a_5), this.m_c3, this.m_c2.xk(a_5), A_12: false, A_13: false, null, A_15: false);
				}
				files4 = null;
			}
			if (!string.IsNullOrEmpty(text11) && global::c.e().FileSystem.FileExists(text11))
			{
				e3.a a10 = new e3.a();
				a10.a(text11);
				File.WriteAllText(text7 + "\\" + Path.ChangeExtension(Path.GetFileName(text11), ".txt"), a10.g);
				a10 = null;
			}
			if (!global::e.a().TechSupportOpenFolderInExplorer)
			{
				return;
			}
			Process process = Process.Start(new ProcessStartInfo("explorer")
			{
				Arguments = "\"" + text7 + "\""
			});
			try
			{
				process.WaitForInputIdle(4000);
			}
			catch (InvalidOperationException ex8)
			{
				ProjectData.SetProjectError(ex8);
				InvalidOperationException ex9 = ex8;
				ProjectData.ClearProjectError();
			}
			IntPtr intPtr;
			int num11 = default(int);
			do
			{
				string text14 = text7.Substring(text7.LastIndexOf("\\") + 1);
				intPtr = b(default(IntPtr), text14);
				if (intPtr == IntPtr.Zero)
				{
					int num9 = text14.Length;
					do
					{
						intPtr = b(default(IntPtr), text14.Substring(0, num9));
						num9--;
					}
					while (!(intPtr != IntPtr.Zero) && num9 >= 1);
				}
				if (intPtr == IntPtr.Zero)
				{
					int num10 = text7.Length;
					do
					{
						intPtr = b(default(IntPtr), text7.Substring(0, num10));
						num10--;
					}
					while (!(intPtr != IntPtr.Zero) && num10 >= 1);
				}
				if (intPtr == IntPtr.Zero)
				{
					Thread.Sleep(700);
				}
				num11++;
			}
			while (intPtr == IntPtr.Zero && num11 < 3);
			if (intPtr != IntPtr.Zero)
			{
				Thread.Sleep(500);
				Rectangle bounds = Screen.AllScreens[i6.a(base.Left, base.Top)].Bounds;
				int num12 = 250;
				MoveWindow(intPtr, 0, 0, num12, bounds.Height - 1, A_5: true);
				base.WindowState = FormWindowState.Normal;
				base.Left = num12;
				base.Top = 0;
				base.Width = bounds.Width - num12;
				base.Height = bounds.Height - 1;
				Activate();
			}
		}
	}

	private void ah(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (ar().TabPages[ar().SelectedIndex].Controls[0] is d6)
				{
					ar().SelectedIndex++;
				}
				else if (!(ar().TabPages[ar().SelectedIndex].Controls[0] is f4))
				{
					ar().SelectedTab = r();
				}
				hg a_ = this.m_c2.wq(eh());
				if (b(a_))
				{
					OpenFileDialog openFileDialog = new OpenFileDialog();
					openFileDialog.CheckFileExists = true;
					openFileDialog.Multiselect = false;
					openFileDialog.Filter = "Tech Support Archive (*.fitsa)|*.fitsa";
					openFileDialog.InitialDirectory = i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
					if (openFileDialog.ShowDialog() != DialogResult.Cancel)
					{
						global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(openFileDialog.FileName);
						b(openFileDialog.FileName);
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				this.m_c3.c(fz.b.a, "Error in MainForm.ToolStripMenuItemFileImportTechSupportArchive_Click", ex3);
				global::fe.b(this.m_c3, "Error in ToolStripMenuItemFileImportTechSupportArchive_Click. Error is: " + ex3.Message, "ErrorTitle", i6.a(this));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ag(object A_0, EventArgs A_1)
	{
		try
		{
			new dx().a(this.m_c3);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_c3.c(fz.b.a, "Error in MainForm.ToolStripMenuItemFileImportTechSupportSettings_Click", ex3);
			global::fe.b(this.m_c3, "Error in ToolStripMenuItemFileImportTechSupportSettings_Click. Error is: " + ex3.Message, "ErrorTitle", i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void d(global::r.d.a A_0)
	{
		checked
		{
			try
			{
				if (base.InvokeRequired)
				{
					global::r.d.b method = d;
					BeginInvoke(method, A_0);
				}
				else if (A_0.a != global::r.d.a.a.a)
				{
					global::fe.b(this.m_c3, "Error attempting to update recipe", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_c3.c(fz.b.b, "Exception caught in MainForm.RecipeChangedFinishedHandler()", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void c(global::r.d.a A_0)
	{
		if (A_0.a != global::r.d.a.a.a)
		{
			this.m_c3.c(fz.b.b, "Error in mSetLightSourceMasterDriveTaskCompletion_TaskFinishedEvent, " + A_0.b);
		}
	}

	private void n()
	{
		aa();
	}

	[SpecialName]
	private string m()
	{
		return global::c.d().Info.DirectoryPath + "\\" + global::c.d().Info.AssemblyName + ".exe";
	}

	[SpecialName]
	private eo.a l()
	{
		f4 f10 = el();
		if (f10 == null)
		{
			f10 = s();
		}
		return f10?.h2();
	}

	private void k()
	{
		string a_ = m();
		string text = global::a2.a.b1();
		string a_2 = text.Substring(1);
		string A_ = text.Substring(1) + " File";
		b(a_2, a_, ref A_, global::c.d().Info.DirectoryPath + "\\Icons\\fmlic.ico");
		text = null;
	}

	private void j()
	{
		string a_ = m();
		string text = ".spe";
		string a_2 = text.Substring(1);
		string A_ = text.Substring(1) + " File";
		b(a_2, a_, ref A_, global::c.d().Info.DirectoryPath + "\\Icons\\spe.ico");
		text = null;
		string text2 = ".fmspe";
		string a_3 = text2.Substring(1);
		A_ = text2.Substring(1) + " File";
		b(a_3, a_, ref A_, global::c.d().Info.DirectoryPath + "\\Icons\\spe.ico");
		text2 = null;
		string text3 = ".csp";
		string a_4 = text3.Substring(1);
		A_ = text3.Substring(1) + " File";
		b(a_4, a_, ref A_, global::c.d().Info.DirectoryPath + "\\Icons\\csp.ico");
		text3 = null;
		string text4 = ".fmcsp";
		string a_5 = text4.Substring(1);
		A_ = text4.Substring(1) + " File";
		b(a_5, a_, ref A_, global::c.d().Info.DirectoryPath + "\\Icons\\csp.ico");
		text4 = null;
		if (this.m_c2.ut().bi())
		{
			string text5 = ".fitsa";
			string a_6 = text5.Substring(1);
			A_ = text5.Substring(1) + " File";
			b(a_6, a_, ref A_, global::c.d().Info.DirectoryPath + "\\Icons\\fitsa.ico");
			text5 = null;
			string text6 = ".fitrh";
			string a_7 = text6.Substring(1);
			A_ = text6.Substring(1) + " File";
			b(a_7, a_, ref A_, global::c.d().Info.DirectoryPath + "\\Icons\\fitrh.ico");
			text6 = null;
		}
		k();
		string text7 = ".fibhi";
		string a_8 = text7.Substring(1);
		A_ = text7.Substring(1) + " File";
		b(a_8, a_, ref A_, global::c.d().Info.DirectoryPath + "\\Icons\\fitrh.ico");
		text7 = null;
		string text8 = ".fictm";
		string a_9 = text8.Substring(1);
		A_ = text8.Substring(1) + " File";
		b(a_9, a_, ref A_, global::c.d().Info.DirectoryPath + "\\Icons\\Settings.ico");
		text8 = null;
		string text9 = ".fimic";
		string a_10 = text9.Substring(1);
		A_ = text9.Substring(1) + " File";
		b(a_10, a_, ref A_, global::c.d().Info.DirectoryPath + "\\Icons\\Settings.ico");
		text9 = null;
	}

	private void b(string A_0, string A_1, ref string A_2, string A_3)
	{
		string A_4 = "";
		if (!jj.a(A_2, ref A_4))
		{
			jj.a(A_0, A_1, A_2, A_3);
		}
		else if (!A_4.ToLower().StartsWith(A_1.ToLower()))
		{
			jj.b(A_0, A_2);
			jj.a(A_0, A_1, A_2, A_3);
		}
	}

	private void af(object A_0, EventArgs A_1)
	{
		try
		{
			db db2 = new db();
			global::r.d A_2 = null;
			f4 f10 = el();
			bool flag = f10 != null;
			db2.Location = checked(new Point(base.Left + 30, base.Top + 30));
			bool flag2 = global::e.a().ShowOpticsAndSpecStatus;
			bool flag3;
			float A_4 = default(float);
			bool A_5 = default(bool);
			try
			{
				db2.dg();
				IntPtr A_3 = default(IntPtr);
				bool a_ = default(bool);
				if (flag)
				{
					f10.i(ref A_3, ref A_2);
					a_ = f10.h5();
				}
				flag3 = global::e.a().ShowOpticsAndSpecStatus;
				db2.Owner = this;
				db2.a(this.m_c3, this.m_c2, this.m_ed, eh(), this, f10, A_3, A_2, a_, p(), ref A_4, ref A_5);
				A_2?.e((global::r.d.b)db2.c);
			}
			finally
			{
				db2.dh();
			}
			if (!this.m_dn && ez && global::e.a().LightSourceAutoStandby == (d9() == null))
			{
				if (d9() == null)
				{
					ac();
				}
				else
				{
					ab();
				}
			}
			if (global::e.a().ShowOpticsAndSpecStatus != flag2)
			{
				OnResize(new EventArgs());
			}
			if (global::e.a().ShowOpticsAndSpecStatus != flag3)
			{
				this.m_dc.b();
			}
			db2.Dispose();
			b(A_5, A_4 > 0f, A_4 > 0f, A_4, global::r.d.a.b.a);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_c3.c(fz.b.a, "Error in MainForm.OptionsToolStripMenuItem_Click", ex3);
			global::fe.b(this.m_c3, "Error in OptionsToolStripMenuItem_Click. Error is: " + ex3.Message, "ErrorTitle", i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void b(bool A_0, bool A_1, bool A_2, float A_3, global::r.d.a.b A_4)
	{
		if (A_0)
		{
			global::c.d().ad();
			global::c.d().ac();
			while (global::c.d().ad())
			{
				Thread.Sleep(1);
			}
			string path = i3.g();
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			File.WriteAllText(global::c.d().aa(), "");
			Close();
			Application.Restart();
		}
		else if (A_1)
		{
			if (!A_2)
			{
				this.m_c2.m2(A_4);
				A_3 = this.m_c2.p9();
			}
			if (A_3 > 0f)
			{
				this.m_dr = new c1();
				c1 obj = this.m_dr;
				float a_ = A_3;
				string A_5 = "ReinitializingMsg";
				obj.a(a_, hu.a(ref A_5));
			}
		}
	}

	private void ae(object A_0, EventArgs A_1)
	{
		try
		{
			bool A_2 = default(bool);
			new ci().p(this.m_c3, this.m_c2, this.m_d4, ref A_2);
			if (A_2)
			{
				Close();
			}
			else
			{
				this.m_dc.b();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_c3.c(fz.b.a, "Error in MainForm.AccessControlToolStripMenuItem_Click", ex3);
			global::fe.b(this.m_c3, "Error in AccessControlToolStripMenuItem_Click. Error is: " + ex3.Message, i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void ad(object A_0, EventArgs A_1)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = i3.d(global::e.a().LastSaveHistPath);
			openFileDialog.Filter = "History Files (*.fibhi)|*.fibhi";
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			global::e.a().LastSaveHistPath = Path.GetDirectoryName(openFileDialog.FileName);
			global::e.a().LastUsedOpenHistoryFilter = 2;
			if (ar().TabCount <= 0)
			{
				return;
			}
			f3 f10 = p();
			if (f10 != null)
			{
				string left = ar().SelectedTab.Text;
				string A_2 = "PrecisionResultsPanelName";
				if (Operators.CompareString(left, hu.a(ref A_2), TextCompare: false) != 0)
				{
					ar().SelectedTab = q();
					f10.b(openFileDialog.FileName, A_1: true);
					return;
				}
			}
			f3 f11 = o();
			if (f11 != null && Operators.CompareString(ar().SelectedTab.Text, f11.Name, TextCompare: false) == 0)
			{
				f11.b(openFileDialog.FileName, A_1: true);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_c3.c(fz.b.b, "Exception caught in OpenHistoryToolStripMenuItem_Click", ex3);
			global::fe.b(this.m_c3, "Error in OpenHistoryToolStripMenuItem_Click. Error is: " + ex3.Message, i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void ac(object A_0, EventArgs A_1)
	{
		string name = ((ToolStripMenuItem)A_0).Name;
		Process.Start(i3.h() + "\\" + name + ".chm");
	}

	private void b(global::j.d A_0)
	{
		try
		{
			if (!this.m_ee)
			{
				if (base.InvokeRequired)
				{
					Invoke(new global::j.c(b), A_0);
				}
				else
				{
					SystemSounds.Exclamation.Play();
					A_0.b = !global::fe.b(ref this.m_c3, A_0.a, "Information", "OKString", "CancelString", i6.a(this));
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c3.c(fz.b.b, "Exception caught in AutoUpdateElevationRequestHandler", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(string A_0, string A_1, string A_2, bool A_3)
	{
		try
		{
			if (this.m_ee || this.m_c2.tc())
			{
				return;
			}
			if (base.InvokeRequired)
			{
				t method = b;
				try
				{
					Invoke(method, A_0, A_1, A_2, A_3);
					return;
				}
				catch (ObjectDisposedException ex2)
				{
					ProjectData.SetProjectError(ex2);
					ObjectDisposedException ex3 = ex2;
					ProjectData.ClearProjectError();
					return;
				}
			}
			if (A_3 && (this.m_du || !A_3 || Operators.CompareString(A_2, global::e.a().AutoUpdateLastPromptVer, TextCompare: false) == 0))
			{
				return;
			}
			try
			{
				this.m_ee = true;
				SystemSounds.Exclamation.Play();
				ref fz a_ = ref this.m_c3;
				string A_4 = "AutoUpdatePrompt";
				if (!global::fe.b(ref a_, hu.a(ref A_4), "SoftwareUpdateTitle", "UpdateString", "UpdateLaterString", i6.a(this)))
				{
					return;
				}
				string text = "\"" + Assembly.GetExecutingAssembly().Location + "\"";
				string text2 = i3.o() + "\\InstallUpdate\\FIAutoUpdater.exe";
				if (File.Exists(text2))
				{
					FileAttributes attributes = File.GetAttributes(text2);
					if ((attributes & FileAttributes.ReadOnly) != 0)
					{
						File.SetAttributes(text2, attributes & ~FileAttributes.ReadOnly);
					}
					global::c.e().FileSystem.DeleteFile(text2);
				}
				global::c.e().FileSystem.CopyFile(Application.StartupPath + "\\FIAutoUpdater.exe", text2);
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				A_1 = A_1.TrimEnd('\\');
				A_1 = A_1.Replace("\"", "\\\"");
				processStartInfo.FileName = text2;
				processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
				processStartInfo.Arguments = "\"" + A_0 + "\" \"" + A_1 + "\" " + text;
				Process.Start(processStartInfo);
				Close();
			}
			finally
			{
				this.m_ee = false;
				global::e.a().AutoUpdateLastPromptVer = A_2;
				global::e.a().AutoUpdateLastReminderDateTime = DateTime.Now;
			}
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception ex5 = ex4;
			this.m_c3.c(fz.b.b, "Exception caught in AutoUpdateHandler", ex5);
			global::fe.b(this.m_c3, "Error in AutoUpdateHandler. Error is: " + ex5.Message, i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void b(global::l A_0)
	{
		this.m_ed = A_0;
	}

	private void ab(object A_0, EventArgs A_1)
	{
		try
		{
			ay ay2 = new ay();
			ay2.g(i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath));
			ay obj = ay2;
			string A_2 = "ImportBaselineFromFolderTitle";
			obj.h(hu.a(ref A_2));
			if (ay2.g(this) == DialogResult.OK)
			{
				global::e.a().LastOpenSaveExportTargetImportSourcePath = ay2.f();
				string text = ay2.f();
				ay2 = null;
				cz cz2 = new cz();
				cz2.a(this.m_c3, text, this.m_c2, eh(), A_4: true, en(), i6.a(this));
				if (cz2.DialogResult == DialogResult.OK)
				{
					cz2.a(text);
				}
				cz2.Close();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.ToolStripMenuItemFileImportBaseline_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void aa(object A_0, EventArgs A_1)
	{
		try
		{
			cz cz2 = new cz();
			cz2.a(this.m_c3, string.Empty, this.m_c2, eh(), A_4: false, en(), i6.a(this));
			if (cz2.DialogResult != DialogResult.Cancel)
			{
				ay ay2 = new ay();
				ay2.g(i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath));
				ay2.h("Please select folder to export baseline file(s) to");
				if (ay2.g(this) == DialogResult.OK)
				{
					global::e.a().LastOpenSaveExportTargetImportSourcePath = ay2.f();
					string a_ = ay2.f();
					ay2 = null;
					cz2.a(a_);
					cz2.Close();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.ToolStripMenuItemFileExportBaseline_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void z(object A_0, EventArgs A_1)
	{
		try
		{
			c4 obj = new c4();
			LicenseLevel A_2 = default(LicenseLevel);
			bool a_ = global::d9.a(this.m_c3, this.m_c2.uf(), i6.a(this), ref A_2);
			eb.b b10;
			if (A_0 == ce())
			{
				b10 = global::eb.b.a;
			}
			else
			{
				if (A_0 != cf())
				{
					throw new ApplicationException("Unknown OMDB file type");
				}
				b10 = global::eb.b.b;
			}
			fz a_2 = this.m_c3;
			f1 a_3 = this.m_c2;
			f4 a_4 = el();
			string a_5 = this.m_c2.uf();
			LicenseLevel a_6 = A_2;
			eb.b a_7 = b10;
			bool a_8 = this.m_c2.un();
			string A_3 = null;
			eb.a A_4 = global::eb.a.a;
			bool A_5 = false;
			bool A_6 = false;
			obj.a(a_2, a_3, a_4, global::c4.a.c, A_4: true, A_5: true, A_6: true, A_7: false, a_5, a_6, a_7, A_11: false, a_, null, a_8, ref A_3, ref A_4, ref A_5, A_18: false, A_19: false, ref A_6);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_9 = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.ToolStripMenuItemEditOMDB_Click", a_9);
			ProjectData.ClearProjectError();
		}
	}

	private void y(object A_0, EventArgs A_1)
	{
		try
		{
			string text = gd.i();
			OpenFileDialog openFileDialog = new OpenFileDialog();
			new b2();
			string A_2 = "ImportLayerStackFileTitle";
			openFileDialog.Title = hu.a(ref A_2);
			openFileDialog.InitialDirectory = i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
			openFileDialog.Filter = "LayerStack |*.fibbl;*.fibtl;*.fibbs;*.fibts";
			openFileDialog.Multiselect = true;
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(openFileDialog.FileName);
			if (!Directory.Exists(text))
			{
				global::c.e().FileSystem.CreateDirectory(text);
			}
			bool A_3 = false;
			string[] fileNames = openFileDialog.FileNames;
			foreach (string text2 in fileNames)
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text2);
				string fileName = Path.GetFileName(text2);
				if (File.Exists(gd.i() + fileName))
				{
					SystemSounds.Exclamation.Play();
					ref fz a_ = ref this.m_c3;
					A_2 = "FileReplaceWarningMsgLayerStackFmt";
					if (global::fe.b(ref a_, string.Format(hu.a(ref A_2), fileNameWithoutExtension), "ImportLayerStackFile", "Yes", "No", i6.a(this)))
					{
						gf.a(this.m_c3, text2, gd.i(), A_3: true, ref A_3);
					}
				}
				else
				{
					gf.a(this.m_c3, text2, gd.i(), A_3: true, ref A_3);
				}
			}
			if (A_3 && this.m_c2.ui())
			{
				gf.a();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.LayerStackImportToolStripMenuItem_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void x(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				string a_ = gd.i();
				OpenFileDialog openFileDialog = new OpenFileDialog();
				string A_2 = "LayerstackDialogTitle";
				openFileDialog.Title = hu.a(ref A_2);
				openFileDialog.InitialDirectory = i3.d(a_);
				openFileDialog.Filter = "LayerStack |*.fibls;*.fitls;*.fibss;*.fitss";
				openFileDialog.Multiselect = true;
				if (openFileDialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				ay ay2 = new ay();
				ay2.g(i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath));
				ay obj = ay2;
				A_2 = "LayerstackFolderDescription";
				obj.h(hu.a(ref A_2));
				if (ay2.g(this) != DialogResult.OK)
				{
					return;
				}
				global::e.a().LastOpenSaveExportTargetImportSourcePath = ay2.f();
				string text = ay2.f();
				ay2 = null;
				string[] fileNames = openFileDialog.FileNames;
				foreach (string text2 in fileNames)
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text2);
					string text3 = Path.GetExtension(text2).ToLower();
					string text4 = string.Empty;
					switch (text3)
					{
					case ".fibls":
						text4 = ".fibbl";
						break;
					case ".fitls":
						text4 = ".fibtl";
						break;
					case ".fibss":
						text4 = ".fibbs";
						break;
					case ".fitss":
						text4 = ".fibts";
						break;
					}
					string text5 = text + "\\" + fileNameWithoutExtension + text4;
					if (File.Exists(text5))
					{
						SystemSounds.Exclamation.Play();
						ref fz a_2 = ref this.m_c3;
						A_2 = "FileExportWarningMsgFmt";
						if (!global::fe.b(ref a_2, string.Format(hu.a(ref A_2), fileNameWithoutExtension), "ExportLayerstackFileTitle", "Yes", "No", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2))))
						{
							continue;
						}
					}
					gf.a(text2, text5);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.LayerStackExportToolStripMenuItem1_Click", a_3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private f4 c(ek A_0)
	{
		f4 f10 = null;
		foreach (TabPage tabPage in ar().TabPages)
		{
			if (tabPage.Controls[0] is f4)
			{
				f10 = (f4)tabPage.Controls[0];
				if (f10.hg() == A_0)
				{
					break;
				}
			}
		}
		return f10;
	}

	private void w(object A_0, EventArgs A_1)
	{
		f4 f10 = null;
		c5.b a_ = null;
		try
		{
			f10 = el();
			a_ = b;
			b(new c5());
			ek ek2 = null;
			ek ek3;
			if (f10 == null)
			{
				ek3 = p().bz();
				f4 f11 = ((ek3 != null) ? c(ek3) : s());
				if (f11 == null)
				{
					throw new Exception("Can not find valid measurement report.");
				}
				c5 obj = ee();
				fz a_2 = this.m_c3;
				f1 a_3 = this.m_c2;
				f4 a_4 = f10;
				gh a_5 = this.m_dj;
				string a_6 = f11.hb();
				f4 f12;
				ek A_2 = (f12 = f11).hg();
				obj.c(a_2, a_3, a_4, a_5, a_6, ref A_2);
				f12.i(A_2);
				if (ee().DialogResult == DialogResult.OK)
				{
					ek2 = f11.hg();
					b(ek2);
					global::c6.a();
					e();
				}
			}
			else
			{
				ek3 = f10.hg();
				ee().c(a_);
				ee().c(f10.i);
				c5 obj2 = ee();
				fz a_7 = this.m_c3;
				f1 a_8 = this.m_c2;
				f4 a_9 = f10;
				gh a_10 = this.m_dj;
				string a_11 = f10.hb();
				f4 f12;
				ek A_2 = (f12 = f10).hg();
				obj2.c(a_7, a_8, a_9, a_10, a_11, ref A_2);
				f12.i(A_2);
				if (ee().DialogResult == DialogResult.OK)
				{
					ek2 = f10.hg();
					if (ek3 == null)
					{
						f10.h3();
					}
					i();
					b(ek2);
					global::c6.a();
				}
			}
			if (ek3 != ek2 && ek2 != null)
			{
				ek3?.m(b);
				ek2.l(b);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_12 = ex2;
			i5.a(this.m_c3, this.m_c2, null, i6.a(this), "MainForm.ToolStripButtonEdit_Click", a_12);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (f10 != null)
			{
				ee().d(a_);
				ee().d(f10.i);
			}
		}
	}

	private void b(ek A_0, en A_1)
	{
		foreach (TabPage tabPage in ar().TabPages)
		{
			if (tabPage.Controls[0] is f4)
			{
				if (((f4)tabPage.Controls[0]).hg() == A_0)
				{
					TabPage selectedTab = ar().SelectedTab;
					ar().SelectedTab = tabPage;
					b(A_1);
					ar().SelectedTab = selectedTab;
					break;
				}
				_ = null;
			}
		}
	}

	private void b(en A_0)
	{
		f4 f10 = el();
		Bitmap A_1 = null;
		bool flag = default(bool);
		try
		{
			cn().Visible = false;
			f10.y(A_0: false);
			if (f10.bs().SelectedTab == f10.bt())
			{
				flag = true;
				f10.bs().SelectedTab = f10.bu();
			}
			bool A_2 = default(bool);
			b(ref A_1, ref A_2);
			if (A_2)
			{
				return;
			}
			A_0.h = A_1;
		}
		finally
		{
			f10.y(A_0: true);
			cn().Visible = true;
			if (flag)
			{
				f10.bs().SelectedTab = f10.bt();
			}
		}
		f10 = null;
	}

	private void i()
	{
		f4 obj = el();
		int num = obj.hg().l();
		cu().Items.Clear();
		ek ek2 = obj.hg();
		if (ek2.c != null)
		{
			foreach (el item in ek2.c)
			{
				cu().Items.Add(item.d());
			}
			if (cu().Items.Count > 0)
			{
				if (num < 0 || num > checked(cu().Items.Count - 1))
				{
					cu().SelectedIndex = 0;
				}
				else
				{
					cu().SelectedIndex = num;
				}
			}
		}
		ek2 = null;
		d();
		e();
	}

	private void h()
	{
		if (!this.m_c2.uj())
		{
			return;
		}
		f4 f10 = el();
		_ = ar().SelectedTab.Controls[0];
		if (f10 != null && f10.hg() != null)
		{
			ek A_ = null;
			el el2 = null;
			em em2 = null;
			hc a_ = f10.hg().g;
			List<ek> A_2 = null;
			int A_3 = default(int);
			int A_4 = default(int);
			int A_5 = default(int);
			f10.i(a_, ref A_, ref A_3, ref A_4, ref A_5, ref A_2);
			if (A_ != null)
			{
				ai();
				try
				{
					cu().Items.Clear();
					foreach (el item in A_.c)
					{
						cu().Items.Add(item.d());
					}
					cu().SelectedIndex = A_3;
					el2 = A_.c[A_3];
					cv().Items.Clear();
					foreach (em item2 in el2.b)
					{
						cv().Items.Add(item2.f());
					}
					cv().SelectedIndex = A_4;
					em2 = el2.b[A_4];
					c4().Items.Clear();
					foreach (en item3 in em2.b)
					{
						c4().Items.Add(item3.g);
					}
					c4().SelectedIndex = A_5;
				}
				finally
				{
					ah();
				}
				d();
				e();
			}
			else
			{
				i();
			}
		}
		else
		{
			cu().Items.Clear();
			cv().Items.Clear();
			c4().Items.Clear();
			d();
			e();
		}
	}

	private void b(ek A_0)
	{
		f3 f10 = p();
		Collection<el> collection = A_0.c;
		if (f10 == null)
		{
			return;
		}
		foreach (el item in collection)
		{
			foreach (em item2 in item.b)
			{
				foreach (en item3 in item2.b)
				{
					hc a_ = item3.b;
					bool A_1 = false;
					f10.a(a_, A_1: false, A_2: false, A_3: false, ref A_1, A_5: true);
				}
			}
		}
	}

	private void v(object A_0, EventArgs A_1)
	{
		try
		{
			if (!global::e.a().ReportDontPromptBeforeClose)
			{
				ref fz a_ = ref this.m_c3;
				Point a_2 = i6.a(this);
				string A_2 = "DontAskMeThisAgain";
				bool A_3 = default(bool);
				if (!global::fe.b(ref a_, "Are you sure you want to close the report, losing any unsaved data?", "ReportCloseWarningTitle", "Yes", "No", a_2, hu.a(ref A_2), ref A_3))
				{
					return;
				}
				global::e.a().ReportDontPromptBeforeClose = A_3;
			}
			f4 f10 = el();
			if (f10 == null)
			{
				f10 = c(p().bz());
			}
			f10.hg().m(b);
			f10.i((ek)null);
			cu().Items.Clear();
			cv().Items.Clear();
			c4().Items.Clear();
			d();
			e();
			global::c6.a();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			i5.a(this.m_c3, this.m_c2, null, i6.a(this), "MainForm.ToolStripButtonClose_Click", a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void g()
	{
		try
		{
			ai();
			if (c4().Items.Count > 0)
			{
				c4().SelectedIndex = 0;
			}
			cv().SelectedIndex = 0;
		}
		finally
		{
			ah();
		}
	}

	private void u(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				g();
				if (cu().SelectedIndex < cu().Items.Count - 1)
				{
					cu().SelectedIndex++;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_c3, this.m_c2, null, i6.a(this), "MainForm.ToolStripButtonSampleF_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void t(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				g();
				if (cu().SelectedIndex > 0)
				{
					cu().SelectedIndex--;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_c3, this.m_c2, null, i6.a(this), "MainForm.ToolStripButtonSampleB_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void f()
	{
		try
		{
			ai();
			ToolStripComboBox toolStripComboBox = c4();
			if (toolStripComboBox.Items.Count > 0)
			{
				toolStripComboBox.SelectedIndex = 0;
			}
			toolStripComboBox = null;
		}
		finally
		{
			ah();
		}
	}

	private void s(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				f();
				if (cv().SelectedIndex < cv().Items.Count - 1)
				{
					cv().SelectedIndex++;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_c3, this.m_c2, null, i6.a(this), "MainForm.ToolStripButtonLocF_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void r(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				f();
				if (cv().SelectedIndex > 0)
				{
					cv().SelectedIndex--;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_c3, this.m_c2, null, i6.a(this), "MainForm.ToolStripButtonLocB_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void q(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (c4().SelectedIndex < c4().Items.Count - 1)
				{
					c4().SelectedIndex++;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_c3, this.m_c2, null, i6.a(this), "MainForm.ToolStripButtonSpecF_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void p(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (c4().SelectedIndex > 0)
				{
					c4().SelectedIndex--;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_c3, this.m_c2, null, i6.a(this), "MainForm.ToolStripButtonSpecB_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				int selectedIndex = c4().SelectedIndex;
				if (selectedIndex == -1 || cv().SelectedIndex == -1 || cu().SelectedIndex == -1)
				{
					cq().Checked = false;
					return;
				}
				em em2 = el().hg().c[cu().SelectedIndex].b[cv().SelectedIndex];
				en en2 = em2.b[selectedIndex];
				bool flag = default(bool);
				if (cq().Checked)
				{
					if (!em2.i())
					{
						if (!global::e.a().ReportDontPromptBeforeMarkOverwrite)
						{
							ref fz a_ = ref this.m_c3;
							Point a_2 = i6.a(this);
							string A_2 = "DontAskMeThisAgain";
							bool A_3 = default(bool);
							if (!global::fe.b(ref a_, "Only one Result per location may be Marked.\r\nAre you sure you want to Mark this Result, thereby unMarking the previously Marked Result?", "ReportMarkOverwritePromptTitle", "Yes", "No", a_2, hu.a(ref A_2), ref A_3))
							{
								cq().Checked = false;
								return;
							}
							flag = true;
							global::e.a().ReportDontPromptBeforeMarkOverwrite = A_3;
						}
						em2.j();
					}
					en2.i(cq().Checked);
				}
				else
				{
					en2.i(A_0: false);
				}
				try
				{
					ai();
					if (flag)
					{
						c4().Items.Clear();
						int num = em2.b.Count - 1;
						for (int num2 = 0; num2 <= num; num2++)
						{
							c4().Items.Insert(num2, em2.b[num2].g);
						}
					}
					else
					{
						c4().Items.RemoveAt(selectedIndex);
						c4().Items.Insert(selectedIndex, en2.g);
					}
					c4().SelectedIndex = selectedIndex;
				}
				finally
				{
					ah();
				}
				global::c6.a();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				i5.a(this.m_c3, this.m_c2, null, i6.a(this), "MainForm.ToolStripButtonMarkResult_Click", a_3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void n(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				int selectedIndex = c4().SelectedIndex;
				if (selectedIndex == -1 || cv().SelectedIndex == -1 || cu().SelectedIndex == -1)
				{
					cr().Checked = false;
					return;
				}
				em em2 = el().hg().c[cu().SelectedIndex].b[cv().SelectedIndex];
				en en2 = em2.b[selectedIndex];
				bool flag = default(bool);
				if (cr().Checked)
				{
					if (!em2.g())
					{
						if (!global::e.a().ReportDontPromptBeforeMarkOverwrite)
						{
							ref fz a_ = ref this.m_c3;
							Point a_2 = i6.a(this);
							string A_2 = "DontAskMeThisAgain";
							bool A_3 = default(bool);
							if (!global::fe.b(ref a_, "Only one ScreenShot per location may be Marked.\r\nAre you sure you want to Mark this Result for a ScreenShot, thereby unMarking the Result previously Marked for a ScreenShot?", "ReportMarkOverwritePromptTitle", "Yes", "No", a_2, hu.a(ref A_2), ref A_3))
							{
								cr().Checked = false;
								return;
							}
							flag = true;
							global::e.a().ReportDontPromptBeforeMarkOverwrite = A_3;
						}
						em2.h();
					}
					en2.j(cr().Checked);
					b(em2.b[selectedIndex]);
				}
				else
				{
					en2.j(A_0: false);
				}
				try
				{
					ai();
					if (flag)
					{
						c4().Items.Clear();
						int num = em2.b.Count - 1;
						for (int num2 = 0; num2 <= num; num2++)
						{
							c4().Items.Insert(num2, em2.b[num2].g);
						}
					}
					else
					{
						c4().Items.RemoveAt(selectedIndex);
						c4().Items.Insert(selectedIndex, en2.g);
					}
					c4().SelectedIndex = selectedIndex;
				}
				finally
				{
					ah();
				}
				global::c6.a();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				i5.a(this.m_c3, this.m_c2, null, i6.a(this), "MainForm.ToolStripButtonMarkSS_Click", a_3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void m(object A_0, EventArgs A_1)
	{
		try
		{
			if (aj())
			{
				return;
			}
			f4 f10 = el();
			if (f10 == null)
			{
				return;
			}
			int num = f10.hg().m();
			int selectedIndex = cu().SelectedIndex;
			cv().Items.Clear();
			f10.hg().l(selectedIndex);
			foreach (em item in f10.hg().c[selectedIndex].b)
			{
				cv().Items.Add(item.f());
			}
			if (cv().Items.Count > 0)
			{
				if (num < 0 || num > checked(cv().Items.Count - 1))
				{
					cv().SelectedIndex = 0;
				}
				else
				{
					cv().SelectedIndex = num;
				}
			}
			d();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c3, this.m_c2, null, i6.a(this), "MainForm.ToolStripComboSample_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		try
		{
			if (aj())
			{
				return;
			}
			f4 f10 = el();
			if (f10 == null)
			{
				return;
			}
			int A_2 = default(int);
			if (f10.hg().g == null)
			{
				A_2 = f10.hg().n();
			}
			else
			{
				hc a_ = f10.hg().g;
				ek A_3 = null;
				int A_4 = 0;
				int A_5 = 0;
				List<ek> A_6 = null;
				f10.i(a_, ref A_3, ref A_4, ref A_5, ref A_2, ref A_6);
			}
			int selectedIndex = cu().SelectedIndex;
			c4().Items.Clear();
			f10.hg().m(cv().SelectedIndex);
			foreach (en item in f10.hg().c[selectedIndex].b[cv().SelectedIndex].b)
			{
				c4().Items.Add(item.g);
			}
			if (c4().Items.Count > 0)
			{
				c4().SelectedIndex = 0;
			}
			else
			{
				f10.z(A_0: false);
				f10.hg().g = null;
			}
			if (c4().Items.Count > 0)
			{
				if (A_2 < 0 || A_2 > checked(c4().Items.Count - 1))
				{
					c4().SelectedIndex = 0;
				}
				else
				{
					c4().SelectedIndex = A_2;
				}
			}
			d();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_c3, this.m_c2, null, i6.a(this), "MainForm.ToolStripComboLoc_SelectedIndexChanged", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		try
		{
			d();
			f4 f10 = el();
			if (f10 != null)
			{
				en en2 = f10.hg().c[cu().SelectedIndex].b[cv().SelectedIndex].b[c4().SelectedIndex];
				f10.hg().g = en2.b;
				f10.hg().n(c4().SelectedIndex);
				f10.i(en2, eh(), A_2: false);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c3, this.m_c2, null, i6.a(this), "MainForm.ToolStripComboSpec_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(string A_0, f4 A_1)
	{
		if (base.InvokeRequired)
		{
			BeginInvoke(new f4.i(b), A_0, A_1);
			return;
		}
		try
		{
			ai();
			if (A_1 == el())
			{
				c4().Items.Add(A_0);
				c4().SelectedIndex = checked(c4().Items.Count - 1);
			}
		}
		finally
		{
			ah();
		}
	}

	private void b(int A_0, f4 A_1)
	{
		if (base.InvokeRequired)
		{
			BeginInvoke(new f4.j(b), A_0, A_1);
			return;
		}
		try
		{
			ai();
			if (A_1 == el())
			{
				c4().SelectedIndex = A_0;
			}
		}
		finally
		{
			ah();
		}
	}

	private void e()
	{
		f4 f10 = el();
		Control control = ar().SelectedTab.Controls[0];
		bool flag = default(bool);
		bool flag2 = default(bool);
		if (control is f3)
		{
			flag = ((f3)control).bz() != null;
			flag2 = flag;
			if (!flag)
			{
				flag = this.m_c2.tj().Count == 1;
			}
			_ = null;
		}
		else if (f10 != null)
		{
			flag2 = f10.hg() != null;
			flag = true;
		}
		c6().Enabled = flag;
		c7().Enabled = flag2;
		if (flag2)
		{
			c7().Image = Resources.xDarkRed;
		}
		else
		{
			c7().Image = Resources.xGray;
		}
	}

	private void b(ToolStripButton A_0, ToolStripButton A_1, ToolStripComboBox A_2, bool A_3)
	{
		A_2.Enabled = A_3 && A_2.Items.Count >= 2;
		A_0.Enabled = A_3 && A_2.Items.Count >= 2 && A_2.SelectedIndex != checked(A_2.Items.Count - 1);
		if (A_0.Enabled)
		{
			A_0.Image = Resources.Plus;
		}
		else
		{
			A_0.Image = Resources.PlusGray;
		}
		A_1.Enabled = A_3 && A_2.Items.Count >= 2 && A_2.SelectedIndex != 0;
		if (A_1.Enabled)
		{
			A_1.Image = Resources.Minus;
		}
		else
		{
			A_1.Image = Resources.MinusGray;
		}
	}

	private void d()
	{
		f4 f10 = el();
		b(co(), cs(), cu(), f10 != null);
		b(cp(), ct(), cv(), f10 != null);
		b(c2(), c3(), c4(), f10 != null);
		bool flag = f10 != null && c4().Items.Count > 0;
		cq().Enabled = flag;
		cr().Enabled = flag;
		if (flag)
		{
			em em2 = f10.hg().c[cu().SelectedIndex].b[cv().SelectedIndex];
			if (em2.b.Count > 0)
			{
				en en2 = em2.b[c4().SelectedIndex];
				cq().Checked = en2.k();
				cr().Checked = en2.l();
				en2 = null;
			}
			else
			{
				cq().Checked = false;
				cr().Checked = false;
			}
		}
		else
		{
			cq().Checked = false;
			cr().Checked = false;
		}
	}

	private void b(int A_0, int A_1, int A_2, ek A_3)
	{
		el().i(A_3);
		cu().SelectedIndex = A_0;
		cv().SelectedIndex = A_1;
		c4().SelectedIndex = A_2;
	}

	private void b(double A_0, bool A_1, bool A_2)
	{
		if (A_2)
		{
			jj.a(base.Handle, 15);
		}
		jj.a(base.Handle, jj.c.a, 0uL, 0uL);
		if (A_2 && A_0 > 5.0 && !A_1)
		{
			SystemSounds.Exclamation.Play();
		}
	}

	private void b(ulong A_0, ulong A_1)
	{
		jj.a(base.Handle, jj.c.c, A_0, A_1);
	}

	private void c()
	{
		bool flag = this.m_c2.ui();
		bool visible = flag;
		bool visible2 = this.m_c2.ui();
		dl().Visible = flag;
		dj().Visible = visible;
		du().Visible = visible2;
	}

	private void j(object A_0, EventArgs A_1)
	{
		try
		{
			c1 c10 = new c1();
			try
			{
				c10.d("Building ORID Material Folders");
				jb.a(this.m_c2.ut(), this.m_c2.u8(), this.m_c3);
				global::fe.b(this.m_c3, "ORID material folder update process is finished. Folders are located in:\r\n" + jb.a(), "Information", i6.a(this));
			}
			finally
			{
				c10.i();
				c10.Dispose();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c3, this.m_c2, null, i6.a(this), "MainForm.UpdateWebSiteMaterialFolderToolStripMenuItem_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		try
		{
			if (dh().DropDownItems.Count > 0)
			{
				return;
			}
			Guid guid = eh();
			if (guid == default(Guid))
			{
				guid = s().hc();
			}
			FMLegacyAllSystemTypes A_2 = default(FMLegacyAllSystemTypes);
			int A_3 = default(int);
			this.m_c2.m2(guid, ref A_2, ref A_3);
			string text = null;
			string text2 = h6.p9(A_2);
			if (A_3 != 0)
			{
				switch (A_2)
				{
				case FMLegacyAllSystemTypes.kTypeF10:
					switch ((FMF10Subtypes)A_3)
					{
					case FMF10Subtypes.kFMF10SubtypeAR:
						text = text2 + "-AR";
						break;
					case FMF10Subtypes.kFMF10SubtypeHC:
						text = text2 + "-HC";
						break;
					case FMF10Subtypes.kFMF10SubtypePA:
					case FMF10Subtypes.kFMF10SubtypePV:
						text = h6.p9(FMLegacyAllSystemTypes.kTypeF20);
						break;
					case FMF10Subtypes.kFMF10SubtypeVC:
						text = text2 + "-RT";
						break;
					case FMF10Subtypes.kFMF10SubtypeRT:
						text = text2 + "-RT";
						break;
					case FMF10Subtypes.kFMF10SubtypeARc:
						text = "F3";
						break;
					case FMF10Subtypes.kFMF10SubtypeRTA:
						text = text2 + "-RTA";
						break;
					}
					break;
				case FMLegacyAllSystemTypes.kTypeF3:
					switch ((i7.a)A_3)
					{
					case i7.a.a:
						text = "F3";
						break;
					case i7.a.b:
					case i7.a.c:
						text = "F20";
						break;
					case i7.a.d:
						text = "F3-sX";
						break;
					}
					break;
				case FMLegacyAllSystemTypes.kTypeF50_300B:
					switch ((FMF50Subtypes)A_3)
					{
					case FMF50Subtypes.kFMF50SubtypeF54:
						text = "F54";
						break;
					case FMF50Subtypes.kFMF50SubtypeF57:
						text = "F57";
						break;
					case FMF50Subtypes.kFMF50SubtypeF50sX:
						text = "F50";
						break;
					case FMF50Subtypes.kFMF50SubtypeF50XYRT_300:
						text = "F50-XY-RT";
						break;
					}
					break;
				case FMLegacyAllSystemTypes.kTypeF60:
					switch ((FMF60Subtypes)A_3)
					{
					case FMF60Subtypes.kFMF60SubtypeF60t:
					case FMF60Subtypes.kFMF60SubtypeF60c:
						text = "F60";
						break;
					case FMF60Subtypes.kFMF60SubtypeF64t:
					case FMF60Subtypes.kFMF60SubtypeF64c:
						text = "F64";
						break;
					}
					break;
				}
			}
			else
			{
				switch (A_2)
				{
				case FMLegacyAllSystemTypes.kTypeF10:
					text2 = "F20";
					break;
				case FMLegacyAllSystemTypes.kTypeF20_F40:
				case FMLegacyAllSystemTypes.kTypeF40NSR:
					text2 = "F40";
					break;
				case FMLegacyAllSystemTypes.kTypeF37:
				case FMLegacyAllSystemTypes.kTypeF32:
					text2 = "F20";
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
					text2 = "F50";
					break;
				case FMLegacyAllSystemTypes.kTypePARTS:
					text2 = "F10-RTA";
					break;
				}
				text = text2;
			}
			string text3 = null;
			string text4 = i3.h() + "\\";
			string text5 = Path.GetDirectoryName(Application.ExecutablePath) + "\\Help\\";
			bool flag = default(bool);
			if (!string.IsNullOrEmpty(text))
			{
				text3 = text4 + text + ".chm";
				if (!File.Exists(text3))
				{
					text3 = text5 + text + ".chm";
				}
				flag = File.Exists(text3);
			}
			bool flag2 = default(bool);
			if (!flag)
			{
				string[] array = null;
				if (Directory.Exists(text4))
				{
					array = Directory.GetFiles(text4, "*.chm");
				}
				if ((array == null || array.Length <= 0) && Directory.Exists(text5))
				{
					array = Directory.GetFiles(text5, "*.chm");
				}
				if (array != null)
				{
					int num = checked(array.Length - 1);
					int num2 = 0;
					if (num2 <= num)
					{
						text3 = array[num2].ToString();
						flag = true;
						flag2 = true;
					}
				}
			}
			if (flag)
			{
				if (flag2 && !ff)
				{
					ff = true;
					ref fz a_ = ref this.m_c3;
					string A_4 = "SubstituteUserManualWarningFmt2";
					string a_2 = string.Format(hu.a(ref A_4), text, Path.GetFileNameWithoutExtension(text3));
					Point A_5 = i6.a(this);
					global::fe.b(ref a_, a_2, ref A_5);
					this.m_c3.c(fz.b.a, "Help file " + text + " not found, displaying substitute file " + text3);
				}
				Process.Start(text3);
			}
			else
			{
				this.m_c3.c(fz.b.a, "Missing help file. Expected help file name is: " + text);
				global::fe.b(this.m_c3, "Sorry, no user manual available for current equipment type", i6.a(this));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.UserManualToolStripMenuItem", a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo("explorer");
			string text = f6.a();
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			processStartInfo.Arguments = "\"" + text + "\"";
			Process.Start(processStartInfo);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.SolverReportFolderToolStripMenuItem_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		try
		{
			Interaction.Shell("Notepad.exe " + this.m_c3.d(), AppWinStyle.NormalFocus);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.LogFileToolStripMenuItem_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(global::r.d.a A_0)
	{
		checked
		{
			try
			{
				if (base.InvokeRequired)
				{
					BeginInvoke(new global::r.d.b(b), A_0);
				}
				else if (this.m_d2 != 0)
				{
					this.m_d3++;
					if (this.m_d3 == this.m_d2)
					{
						this.m_d2 = 0;
						b(A_0: false, A_1: true, A_2: false, 0f, global::r.d.a.b.a);
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_c3.c(fz.b.b, "Exception in MainForm.CustomRTStandardsBaselineCompletionTask_TaskFinishedEvent()", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		if (this.m_ea)
		{
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.MainForm_Shown", this.m_eb);
			new bn().a("An error has occurred during software startup.\r\nIf this error happens repeatedly, you may wish to consider reverting\r\nthe settings.", A_1: true);
			this.m_ea = false;
			Close();
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		SuspendLayout();
	}

	private void d(object A_0, EventArgs A_1)
	{
		b();
		ResumeLayout(performLayout: false);
	}

	private void b()
	{
		f4 f10 = null;
		el()?.hh();
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			new bj(this.m_c3, this.m_dc, this.m_c4).b(this, this.m_c2, el(), eh());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c3, this.m_c2, el(), i6.a(this), "MainForm.MeasureQCWaferToolStripMenuItem_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
	}

	private void b(Guid A_0, bool A_1, bool A_2, bool A_3, string A_4)
	{
	}

	private void b(Guid A_0, bool A_1)
	{
	}
}
