using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Filmetrics.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

[DesignerGenerated]
internal class db : Form
{
	public delegate void a();

	public delegate void b();

	private delegate void c(l A_0);

	private delegate void d(object A_0, ElapsedEventArgs A_1);

	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private CheckBox m_d;

	[CompilerGenerated]
	private CheckBox m_e;

	[CompilerGenerated]
	private Button m_f;

	[CompilerGenerated]
	private TextBox m_g;

	[CompilerGenerated]
	private CheckBox m_h;

	[CompilerGenerated]
	private GroupBox m_i;

	[CompilerGenerated]
	private Label m_j;

	[CompilerGenerated]
	private TabControl m_k;

	[CompilerGenerated]
	private TabPage m_l;

	[CompilerGenerated]
	private TabPage m_m;

	[CompilerGenerated]
	private CheckBox m_n;

	[CompilerGenerated]
	private CheckBox m_o;

	[CompilerGenerated]
	private TabPage m_p;

	[CompilerGenerated]
	private Label m_q;

	[CompilerGenerated]
	private Label m_r;

	[CompilerGenerated]
	private Label m_s;

	[CompilerGenerated]
	private Button m_t;

	[CompilerGenerated]
	private Label m_u;

	[CompilerGenerated]
	private Label m_v;

	[CompilerGenerated]
	private Label m_w;

	[CompilerGenerated]
	private hy m_x;

	[CompilerGenerated]
	private Label m_y;

	[CompilerGenerated]
	private Label m_z;

	[CompilerGenerated]
	private Label m_aa;

	[CompilerGenerated]
	private Label m_ab;

	[CompilerGenerated]
	private Label m_ac;

	[CompilerGenerated]
	private RichTextBox m_ad;

	[CompilerGenerated]
	private ToolTip m_ae;

	[CompilerGenerated]
	private GroupBox m_af;

	[CompilerGenerated]
	private Label m_ag;

	[CompilerGenerated]
	private hy m_ah;

	[CompilerGenerated]
	private Label m_ai;

	[CompilerGenerated]
	private Label m_aj;

	[CompilerGenerated]
	private hy m_ak;

	[CompilerGenerated]
	private Label m_al;

	[CompilerGenerated]
	private ComboBox m_am;

	[CompilerGenerated]
	private Label m_an;

	[CompilerGenerated]
	private TabPage m_ao;

	[CompilerGenerated]
	private Label m_ap;

	[CompilerGenerated]
	private CheckedListBox m_aq;

	[CompilerGenerated]
	private Button m_ar;

	[CompilerGenerated]
	private Label m_as;

	[CompilerGenerated]
	private TabPage m_at;

	[CompilerGenerated]
	private Button m_au;

	[CompilerGenerated]
	private TextBox m_av;

	[CompilerGenerated]
	private Label m_aw;

	[CompilerGenerated]
	private CheckBox m_ax;

	[CompilerGenerated]
	private CheckBox m_ay;

	[CompilerGenerated]
	private CheckBox m_az;

	[CompilerGenerated]
	private GroupBox m_a0;

	[CompilerGenerated]
	private CheckBox m_a1;

	[CompilerGenerated]
	private CheckBox m_a2;

	[CompilerGenerated]
	private Button m_a3;

	[CompilerGenerated]
	private CheckBox m_a4;

	[CompilerGenerated]
	private CheckBox m_a5;

	[CompilerGenerated]
	private TabPage m_a6;

	[CompilerGenerated]
	private Label m_a7;

	[CompilerGenerated]
	private RadioButton m_a8;

	[CompilerGenerated]
	private RadioButton m_a9;

	[CompilerGenerated]
	private CheckBox m_ba;

	[CompilerGenerated]
	private RadioButton m_bb;

	[CompilerGenerated]
	private GroupBox m_bc;

	[CompilerGenerated]
	private Label m_bd;

	[CompilerGenerated]
	private hy m_be;

	[CompilerGenerated]
	private Label m_bf;

	[CompilerGenerated]
	private hy m_bg;

	[CompilerGenerated]
	private Label m_bh;

	[CompilerGenerated]
	private Label m_bi;

	[CompilerGenerated]
	private hy m_bj;

	[CompilerGenerated]
	private CheckBox m_bk;

	[CompilerGenerated]
	private Label m_bl;

	[CompilerGenerated]
	private CheckBox m_bm;

	[CompilerGenerated]
	private TableLayoutPanel m_bn;

	[CompilerGenerated]
	private TableLayoutPanel m_bo;

	[CompilerGenerated]
	private TableLayoutPanel m_bp;

	[CompilerGenerated]
	private TableLayoutPanel m_bq;

	[CompilerGenerated]
	private CheckBox m_br;

	[CompilerGenerated]
	private TableLayoutPanel m_bs;

	[CompilerGenerated]
	private Button m_bt;

	[CompilerGenerated]
	private CheckBox m_bu;

	[CompilerGenerated]
	private GroupBox m_bv;

	[CompilerGenerated]
	private Label m_bw;

	[CompilerGenerated]
	private TextBox m_bx;

	[CompilerGenerated]
	private Button m_by;

	[CompilerGenerated]
	private Label m_bz;

	[CompilerGenerated]
	private Label m_b0;

	[CompilerGenerated]
	private hy m_b1;

	[CompilerGenerated]
	private CheckBox m_b2;

	[CompilerGenerated]
	private TableLayoutPanel m_b3;

	[CompilerGenerated]
	private Panel m_b4;

	[CompilerGenerated]
	private GroupBox m_b5;

	[CompilerGenerated]
	private CheckBox m_b6;

	[CompilerGenerated]
	private RadioButton m_b7;

	[CompilerGenerated]
	private RadioButton m_b8;

	[CompilerGenerated]
	private CheckBox m_b9;

	[CompilerGenerated]
	private CheckBox m_ca;

	[CompilerGenerated]
	private Button m_cb;

	[CompilerGenerated]
	private TableLayoutPanel m_cc;

	[CompilerGenerated]
	private TableLayoutPanel m_cd;

	[CompilerGenerated]
	private CheckBox m_ce;

	[CompilerGenerated]
	private CheckBox m_cf;

	[CompilerGenerated]
	private Button m_cg;

	[CompilerGenerated]
	private CheckBox m_ch;

	[CompilerGenerated]
	private CheckBox m_ci;

	[CompilerGenerated]
	private TableLayoutPanel m_cj;

	[CompilerGenerated]
	private Button m_ck;

	[CompilerGenerated]
	private Label m_cl;

	[CompilerGenerated]
	private Button m_cm;

	[CompilerGenerated]
	private TextBox m_cn;

	[CompilerGenerated]
	private GroupBox m_co;

	[CompilerGenerated]
	private TableLayoutPanel m_cp;

	[CompilerGenerated]
	private Label m_cq;

	[CompilerGenerated]
	private ComboBox m_cr;

	[CompilerGenerated]
	private TableLayoutPanel m_cs;

	[CompilerGenerated]
	private TextBox m_ct;

	[CompilerGenerated]
	private Label m_cu;

	[CompilerGenerated]
	private Button m_cv;

	[CompilerGenerated]
	private Button m_cw;

	[CompilerGenerated]
	private CheckBox m_cx;

	[CompilerGenerated]
	private ToolTip m_cy;

	[CompilerGenerated]
	private TableLayoutPanel m_cz;

	[CompilerGenerated]
	private Label m_c0;

	[CompilerGenerated]
	private Button m_c1;

	[CompilerGenerated]
	private Button m_c2;

	[CompilerGenerated]
	private hx m_c3;

	private const string m_c4 = "DialogOptionSettings.";

	private const string m_c5 = "_????????????????????????????????";

	private const int m_c6 = 1500;

	[CompilerGenerated]
	private System.Timers.Timer m_c7;

	private fz m_c8;

	private l m_c9;

	private f1 m_da;

	private Guid m_db;

	private gy m_dc;

	private IntPtr m_dd;

	private r.d m_de;

	private r.d m_df;

	private gg m_dg;

	private f4 m_dh;

	private f3 m_di;

	[CompilerGenerated]
	private r.d m_dj;

	private bool dk;

	private bool dl;

	private Collection<i7.e> dm;

	private Collection<bool> dn;

	private Collection<string> @do;

	private string dp;

	private bool dq;

	private bool dr;

	private bool ds;

	private float dt;

	private bool du;

	private f.c dv;

	private string dw;

	private bool dx;

	private string dy;

	[CompilerGenerated]
	private static a dz;

	[CompilerGenerated]
	private static b d0;

	private bool d1;

	public db()
	{
		this.m_df = new r.d();
		dm = new Collection<i7.e>();
		dn = new Collection<bool>();
		@do = new Collection<string>();
		k();
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
	private void k()
	{
		this.m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(db));
		c(new CheckBox());
		a(new GroupBox());
		a(new Label());
		a(new CheckBox());
		a(new TextBox());
		b(new CheckBox());
		c(new Button());
		a(new Button());
		b(new Button());
		a(new TabControl());
		b(new TabPage());
		b(new TableLayoutPanel());
		k(new TableLayoutPanel());
		e(new TextBox());
		af(new Label());
		n(new Button());
		o(new Button());
		g(new GroupBox());
		j(new TableLayoutPanel());
		ae(new Label());
		b(new ComboBox());
		c(new TableLayoutPanel());
		x(new Label());
		w(new Label());
		e(new hy());
		h(new TableLayoutPanel());
		w(new CheckBox());
		v(new CheckBox());
		g(new TableLayoutPanel());
		t(new CheckBox());
		j(new Button());
		u(new CheckBox());
		e(new TableLayoutPanel());
		h(new Button());
		l(new CheckBox());
		d(new CheckBox());
		d(new TableLayoutPanel());
		y(new CheckBox());
		x(new CheckBox());
		q(new Label());
		a(new ComboBox());
		k(new CheckBox());
		h(new CheckBox());
		a(new TableLayoutPanel());
		z(new Label());
		f(new hy());
		y(new Label());
		b(new GroupBox());
		m(new Label());
		b(new hy());
		n(new Label());
		o(new Label());
		c(new hy());
		p(new Label());
		n(new CheckBox());
		e(new CheckBox());
		f(new GroupBox());
		s(new CheckBox());
		d(new RadioButton());
		e(new RadioButton());
		o(new CheckBox());
		g(new Button());
		i(new TableLayoutPanel());
		d(new TextBox());
		ad(new Label());
		l(new Button());
		m(new Button());
		z(new CheckBox());
		l(new TableLayoutPanel());
		p(new Button());
		q(new Button());
		ag(new Label());
		a(new hx());
		a(new TabPage());
		f(new TableLayoutPanel());
		a(new Panel());
		p(new CheckBox());
		e(new GroupBox());
		q(new CheckBox());
		r(new CheckBox());
		g(new hy());
		ab(new Label());
		ac(new Label());
		aa(new Label());
		c(new TextBox());
		i(new Button());
		c(new GroupBox());
		i(new CheckBox());
		j(new CheckBox());
		f(new TabPage());
		m(new CheckBox());
		d(new GroupBox());
		d(new hy());
		v(new Label());
		u(new Label());
		c(new RadioButton());
		b(new RadioButton());
		a(new RadioButton());
		c(new TabPage());
		a(new RichTextBox());
		l(new Label());
		k(new Label());
		h(new Label());
		i(new Label());
		j(new Label());
		f(new Label());
		g(new Label());
		e(new Label());
		d(new Button());
		b(new Label());
		c(new Label());
		d(new Label());
		a(new hy());
		d(new TabPage());
		k(new Button());
		s(new Label());
		e(new Button());
		a(new CheckedListBox());
		r(new Label());
		e(new TabPage());
		g(new CheckBox());
		f(new CheckBox());
		f(new Button());
		b(new TextBox());
		t(new Label());
		a(new ToolTip(this.m_a));
		b(new ToolTip(this.m_a));
		s().SuspendLayout();
		u().SuspendLayout();
		w().SuspendLayout();
		by().SuspendLayout();
		c2().SuspendLayout();
		cy().SuspendLayout();
		cz().SuspendLayout();
		bz().SuspendLayout();
		cn().SuspendLayout();
		cm().SuspendLayout();
		b2().SuspendLayout();
		b0().SuspendLayout();
		bx().SuspendLayout();
		ap().SuspendLayout();
		cf().SuspendLayout();
		ct().SuspendLayout();
		c9().SuspendLayout();
		v().SuspendLayout();
		cd().SuspendLayout();
		ce().SuspendLayout();
		b5().SuspendLayout();
		ba().SuspendLayout();
		bg().SuspendLayout();
		bm().SuspendLayout();
		z().SuspendLayout();
		ay().SuspendLayout();
		a3().SuspendLayout();
		SuspendLayout();
		componentResourceManager.ApplyResources(r(), "ChkBoxAutoSave");
		r().Name = "ChkBoxAutoSave";
		ao().SetToolTip(r(), componentResourceManager.GetString("ChkBoxAutoSave.ToolTip"));
		c8().SetToolTip(r(), componentResourceManager.GetString("ChkBoxAutoSave.ToolTip1"));
		r().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(s(), "GroupBox2");
		s().Controls.Add(t());
		s().Controls.Add(n());
		s().Controls.Add(q());
		s().Controls.Add(o());
		s().Controls.Add(p());
		s().Name = "GroupBox2";
		s().TabStop = false;
		ao().SetToolTip(s(), componentResourceManager.GetString("GroupBox2.ToolTip"));
		c8().SetToolTip(s(), componentResourceManager.GetString("GroupBox2.ToolTip1"));
		componentResourceManager.ApplyResources(t(), "Label1");
		t().Name = "Label1";
		ao().SetToolTip(t(), componentResourceManager.GetString("Label1.ToolTip"));
		c8().SetToolTip(t(), componentResourceManager.GetString("Label1.ToolTip1"));
		componentResourceManager.ApplyResources(n(), "ChkConfirmSaving");
		n().Name = "ChkConfirmSaving";
		ao().SetToolTip(n(), componentResourceManager.GetString("ChkConfirmSaving.ToolTip"));
		c8().SetToolTip(n(), componentResourceManager.GetString("ChkConfirmSaving.ToolTip1"));
		n().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(q(), "TextBoxFilePath");
		q().Name = "TextBoxFilePath";
		c8().SetToolTip(q(), componentResourceManager.GetString("TextBoxFilePath.ToolTip"));
		ao().SetToolTip(q(), componentResourceManager.GetString("TextBoxFilePath.ToolTip1"));
		componentResourceManager.ApplyResources(o(), "ChkBoxSaveOnce");
		o().Name = "ChkBoxSaveOnce";
		ao().SetToolTip(o(), componentResourceManager.GetString("ChkBoxSaveOnce.ToolTip"));
		c8().SetToolTip(o(), componentResourceManager.GetString("ChkBoxSaveOnce.ToolTip1"));
		o().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(p(), "ButtonBrowse");
		p().Name = "ButtonBrowse";
		ao().SetToolTip(p(), componentResourceManager.GetString("ButtonBrowse.ToolTip"));
		c8().SetToolTip(p(), componentResourceManager.GetString("ButtonBrowse.ToolTip1"));
		p().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(l(), "ButtonOK");
		l().Name = "ButtonOK";
		ao().SetToolTip(l(), componentResourceManager.GetString("ButtonOK.ToolTip"));
		c8().SetToolTip(l(), componentResourceManager.GetString("ButtonOK.ToolTip1"));
		l().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(m(), "ButtonCancel");
		m().DialogResult = DialogResult.Cancel;
		m().Name = "ButtonCancel";
		ao().SetToolTip(m(), componentResourceManager.GetString("ButtonCancel.ToolTip"));
		c8().SetToolTip(m(), componentResourceManager.GetString("ButtonCancel.ToolTip1"));
		m().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(u(), "TabControlMain");
		u().Controls.Add(w());
		u().Controls.Add(v());
		u().Controls.Add(bg());
		u().Controls.Add(z());
		u().Controls.Add(ay());
		u().Controls.Add(a3());
		u().Name = "TabControlMain";
		u().SelectedIndex = 0;
		ao().SetToolTip(u(), componentResourceManager.GetString("TabControlMain.ToolTip"));
		c8().SetToolTip(u(), componentResourceManager.GetString("TabControlMain.ToolTip1"));
		componentResourceManager.ApplyResources(w(), "TabPageGeneral");
		w().Controls.Add(by());
		w().Name = "TabPageGeneral";
		c8().SetToolTip(w(), componentResourceManager.GetString("TabPageGeneral.ToolTip"));
		ao().SetToolTip(w(), componentResourceManager.GetString("TabPageGeneral.ToolTip1"));
		w().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(by(), "TableLayoutPanel3");
		by().Controls.Add(c2(), 0, 16);
		by().Controls.Add(cy(), 0, 12);
		by().Controls.Add(cn(), 0, 2);
		by().Controls.Add(cm(), 0, 14);
		by().Controls.Add(b2(), 0, 5);
		by().Controls.Add(x(), 0, 1);
		by().Controls.Add(b0(), 0, 9);
		by().Controls.Add(be(), 0, 3);
		by().Controls.Add(a9(), 0, 11);
		by().Controls.Add(bx(), 0, 7);
		by().Controls.Add(ap(), 0, 10);
		by().Controls.Add(bu(), 0, 6);
		by().Controls.Add(y(), 0, 0);
		by().Controls.Add(cf(), 0, 13);
		by().Controls.Add(bw(), 0, 17);
		by().Controls.Add(bd(), 0, 18);
		by().Controls.Add(ct(), 0, 15);
		by().Controls.Add(c7(), 0, 8);
		by().Controls.Add(c9(), 0, 4);
		by().Name = "TableLayoutPanel3";
		ao().SetToolTip(by(), componentResourceManager.GetString("TableLayoutPanel3.ToolTip"));
		c8().SetToolTip(by(), componentResourceManager.GetString("TableLayoutPanel3.ToolTip1"));
		componentResourceManager.ApplyResources(c2(), "TableLayoutPanel11");
		c2().Controls.Add(c3(), 1, 0);
		c2().Controls.Add(c4(), 0, 0);
		c2().Controls.Add(c5(), 3, 0);
		c2().Controls.Add(c6(), 2, 0);
		c2().Name = "TableLayoutPanel11";
		ao().SetToolTip(c2(), componentResourceManager.GetString("TableLayoutPanel11.ToolTip"));
		c8().SetToolTip(c2(), componentResourceManager.GetString("TableLayoutPanel11.ToolTip1"));
		componentResourceManager.ApplyResources(c3(), "TextBoxCustomMaterialPath");
		c3().Name = "TextBoxCustomMaterialPath";
		c8().SetToolTip(c3(), componentResourceManager.GetString("TextBoxCustomMaterialPath.ToolTip"));
		ao().SetToolTip(c3(), componentResourceManager.GetString("TextBoxCustomMaterialPath.ToolTip1"));
		componentResourceManager.ApplyResources(c4(), "Label23");
		c4().Name = "Label23";
		ao().SetToolTip(c4(), componentResourceManager.GetString("Label23.ToolTip"));
		c8().SetToolTip(c4(), componentResourceManager.GetString("Label23.ToolTip1"));
		componentResourceManager.ApplyResources(c5(), "ButtonCustomMaterialPathReset");
		c5().Name = "ButtonCustomMaterialPathReset";
		ao().SetToolTip(c5(), componentResourceManager.GetString("ButtonCustomMaterialPathReset.ToolTip"));
		c8().SetToolTip(c5(), componentResourceManager.GetString("ButtonCustomMaterialPathReset.ToolTip1"));
		c5().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(c6(), "ButtonCustomMaterialPathBrowse");
		c6().Name = "ButtonCustomMaterialPathBrowse";
		ao().SetToolTip(c6(), componentResourceManager.GetString("ButtonCustomMaterialPathBrowse.ToolTip"));
		c8().SetToolTip(c6(), componentResourceManager.GetString("ButtonCustomMaterialPathBrowse.ToolTip1"));
		c6().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(cy(), "GroupBoxLowPowerLightSource");
		cy().Controls.Add(cz());
		cy().Controls.Add(bz());
		cy().Name = "GroupBoxLowPowerLightSource";
		cy().TabStop = false;
		ao().SetToolTip(cy(), componentResourceManager.GetString("GroupBoxLowPowerLightSource.ToolTip"));
		c8().SetToolTip(cy(), componentResourceManager.GetString("GroupBoxLowPowerLightSource.ToolTip1"));
		componentResourceManager.ApplyResources(cz(), "TableLayoutPanel10");
		cz().Controls.Add(c0(), 0, 0);
		cz().Controls.Add(c1(), 1, 0);
		cz().Name = "TableLayoutPanel10";
		ao().SetToolTip(cz(), componentResourceManager.GetString("TableLayoutPanel10.ToolTip"));
		c8().SetToolTip(cz(), componentResourceManager.GetString("TableLayoutPanel10.ToolTip1"));
		componentResourceManager.ApplyResources(c0(), "Label22");
		c0().Name = "Label22";
		ao().SetToolTip(c0(), componentResourceManager.GetString("Label22.ToolTip"));
		c8().SetToolTip(c0(), componentResourceManager.GetString("Label22.ToolTip1"));
		componentResourceManager.ApplyResources(c1(), "ComboBoxLightSourceStandbyDelay");
		c1().DropDownStyle = ComboBoxStyle.DropDownList;
		c1().FormattingEnabled = true;
		c1().Name = "ComboBoxLightSourceStandbyDelay";
		ao().SetToolTip(c1(), componentResourceManager.GetString("ComboBoxLightSourceStandbyDelay.ToolTip"));
		c8().SetToolTip(c1(), componentResourceManager.GetString("ComboBoxLightSourceStandbyDelay.ToolTip1"));
		componentResourceManager.ApplyResources(bz(), "TableLayoutPanel4");
		bz().Controls.Add(br(), 0, 0);
		bz().Controls.Add(bp(), 2, 0);
		bz().Controls.Add(bq(), 1, 0);
		bz().Name = "TableLayoutPanel4";
		ao().SetToolTip(bz(), componentResourceManager.GetString("TableLayoutPanel4.ToolTip"));
		c8().SetToolTip(bz(), componentResourceManager.GetString("TableLayoutPanel4.ToolTip1"));
		componentResourceManager.ApplyResources(br(), "LabelLightSourceMasterDriveLevel");
		br().Name = "LabelLightSourceMasterDriveLevel";
		ao().SetToolTip(br(), componentResourceManager.GetString("LabelLightSourceMasterDriveLevel.ToolTip"));
		c8().SetToolTip(br(), componentResourceManager.GetString("LabelLightSourceMasterDriveLevel.ToolTip1"));
		componentResourceManager.ApplyResources(bp(), "LabelLightSourceMasterLevelUnits");
		bp().Name = "LabelLightSourceMasterLevelUnits";
		ao().SetToolTip(bp(), componentResourceManager.GetString("LabelLightSourceMasterLevelUnits.ToolTip"));
		c8().SetToolTip(bp(), componentResourceManager.GetString("LabelLightSourceMasterLevelUnits.ToolTip1"));
		componentResourceManager.ApplyResources(bq(), "TextBoxNumLightSourceMasterLevel");
		bq().f(A_0: false);
		bq().Name = "TextBoxNumLightSourceMasterLevel";
		bq().e(A_0: false);
		ao().SetToolTip(bq(), componentResourceManager.GetString("TextBoxNumLightSourceMasterLevel.ToolTip"));
		c8().SetToolTip(bq(), componentResourceManager.GetString("TextBoxNumLightSourceMasterLevel.ToolTip1"));
		componentResourceManager.ApplyResources(cn(), "TableLayoutPanel7");
		cn().Controls.Add(cp(), 0, 1);
		cn().Controls.Add(co(), 0, 0);
		cn().Name = "TableLayoutPanel7";
		ao().SetToolTip(cn(), componentResourceManager.GetString("TableLayoutPanel7.ToolTip"));
		c8().SetToolTip(cn(), componentResourceManager.GetString("TableLayoutPanel7.ToolTip1"));
		componentResourceManager.ApplyResources(cp(), "CheckBoxConfirmBeforeAutoIncreaseGraphMaxCurves");
		cp().Name = "CheckBoxConfirmBeforeAutoIncreaseGraphMaxCurves";
		ao().SetToolTip(cp(), componentResourceManager.GetString("CheckBoxConfirmBeforeAutoIncreaseGraphMaxCurves.ToolTip"));
		c8().SetToolTip(cp(), componentResourceManager.GetString("CheckBoxConfirmBeforeAutoIncreaseGraphMaxCurves.ToolTip1"));
		cp().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(co(), "CheckBoxAutoIncreaseGraphMaxCurves");
		co().Name = "CheckBoxAutoIncreaseGraphMaxCurves";
		ao().SetToolTip(co(), componentResourceManager.GetString("CheckBoxAutoIncreaseGraphMaxCurves.ToolTip"));
		c8().SetToolTip(co(), componentResourceManager.GetString("CheckBoxAutoIncreaseGraphMaxCurves.ToolTip1"));
		co().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(cm(), "TableLayoutPanel8");
		cm().Controls.Add(cj(), 0, 1);
		cm().Controls.Add(cl(), 1, 0);
		cm().Controls.Add(ck(), 0, 0);
		cm().Name = "TableLayoutPanel8";
		ao().SetToolTip(cm(), componentResourceManager.GetString("TableLayoutPanel8.ToolTip"));
		c8().SetToolTip(cm(), componentResourceManager.GetString("TableLayoutPanel8.ToolTip1"));
		componentResourceManager.ApplyResources(cj(), "CheckBoxShareSettingsWithSelectedUsers");
		cj().Name = "CheckBoxShareSettingsWithSelectedUsers";
		ao().SetToolTip(cj(), componentResourceManager.GetString("CheckBoxShareSettingsWithSelectedUsers.ToolTip"));
		c8().SetToolTip(cj(), componentResourceManager.GetString("CheckBoxShareSettingsWithSelectedUsers.ToolTip1"));
		cj().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(cl(), "ButtonSharedSettingsFolderBrowse");
		cl().Name = "ButtonSharedSettingsFolderBrowse";
		cm().SetRowSpan(cl(), 2);
		ao().SetToolTip(cl(), componentResourceManager.GetString("ButtonSharedSettingsFolderBrowse.ToolTip"));
		c8().SetToolTip(cl(), componentResourceManager.GetString("ButtonSharedSettingsFolderBrowse.ToolTip1"));
		cl().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ck(), "CheckBoxShareSettingsWithAllUsers");
		ck().Name = "CheckBoxShareSettingsWithAllUsers";
		ao().SetToolTip(ck(), componentResourceManager.GetString("CheckBoxShareSettingsWithAllUsers.ToolTip"));
		c8().SetToolTip(ck(), componentResourceManager.GetString("CheckBoxShareSettingsWithAllUsers.ToolTip1"));
		ck().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(b2(), "TableLayoutPanel5");
		b2().Controls.Add(b3(), 1, 0);
		b2().Controls.Add(bf(), 0, 0);
		b2().Name = "TableLayoutPanel5";
		ao().SetToolTip(b2(), componentResourceManager.GetString("TableLayoutPanel5.ToolTip"));
		c8().SetToolTip(b2(), componentResourceManager.GetString("TableLayoutPanel5.ToolTip1"));
		componentResourceManager.ApplyResources(b3(), "ButtonEditHistoryColumns");
		b3().Name = "ButtonEditHistoryColumns";
		ao().SetToolTip(b3(), componentResourceManager.GetString("ButtonEditHistoryColumns.ToolTip"));
		c8().SetToolTip(b3(), componentResourceManager.GetString("ButtonEditHistoryColumns.ToolTip1"));
		b3().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bf(), "CheckBoxConfirmBeforeDeleteHistory");
		bf().Name = "CheckBoxConfirmBeforeDeleteHistory";
		ao().SetToolTip(bf(), componentResourceManager.GetString("CheckBoxConfirmBeforeDeleteHistory.ToolTip"));
		c8().SetToolTip(bf(), componentResourceManager.GetString("CheckBoxConfirmBeforeDeleteHistory.ToolTip1"));
		bf().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(x(), "CheckBoxConfirmBeforeClearingGraph");
		x().Name = "CheckBoxConfirmBeforeClearingGraph";
		ao().SetToolTip(x(), componentResourceManager.GetString("CheckBoxConfirmBeforeClearingGraph.ToolTip"));
		c8().SetToolTip(x(), componentResourceManager.GetString("CheckBoxConfirmBeforeClearingGraph.ToolTip1"));
		x().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(b0(), "TableLayoutPanel2");
		b0().Controls.Add(cs(), 0, 2);
		b0().Controls.Add(cr(), 0, 1);
		b0().Controls.Add(ax(), 0, 0);
		b0().Controls.Add(aw(), 1, 0);
		b0().Name = "TableLayoutPanel2";
		ao().SetToolTip(b0(), componentResourceManager.GetString("TableLayoutPanel2.ToolTip"));
		c8().SetToolTip(b0(), componentResourceManager.GetString("TableLayoutPanel2.ToolTip1"));
		componentResourceManager.ApplyResources(cs(), "CheckBoxDetectGrayImage");
		b0().SetColumnSpan(cs(), 2);
		cs().Name = "CheckBoxDetectGrayImage";
		ao().SetToolTip(cs(), componentResourceManager.GetString("CheckBoxDetectGrayImage.ToolTip"));
		c8().SetToolTip(cs(), componentResourceManager.GetString("CheckBoxDetectGrayImage.ToolTip1"));
		cs().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(cr(), "CheckBoxShowWarningSwitchingMeasureTabs");
		b0().SetColumnSpan(cr(), 2);
		cr().Name = "CheckBoxShowWarningSwitchingMeasureTabs";
		ao().SetToolTip(cr(), componentResourceManager.GetString("CheckBoxShowWarningSwitchingMeasureTabs.ToolTip"));
		c8().SetToolTip(cr(), componentResourceManager.GetString("CheckBoxShowWarningSwitchingMeasureTabs.ToolTip1"));
		cr().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ax(), "LabelSelectedCamera");
		ax().Name = "LabelSelectedCamera";
		ao().SetToolTip(ax(), componentResourceManager.GetString("LabelSelectedCamera.ToolTip"));
		c8().SetToolTip(ax(), componentResourceManager.GetString("LabelSelectedCamera.ToolTip1"));
		componentResourceManager.ApplyResources(aw(), "CbSelectedCamera");
		aw().DropDownStyle = ComboBoxStyle.DropDownList;
		aw().FormattingEnabled = true;
		aw().Name = "CbSelectedCamera";
		ao().SetToolTip(aw(), componentResourceManager.GetString("CbSelectedCamera.ToolTip"));
		c8().SetToolTip(aw(), componentResourceManager.GetString("CbSelectedCamera.ToolTip1"));
		componentResourceManager.ApplyResources(be(), "CheckBoxPrintActiveCurveOnly");
		be().Name = "CheckBoxPrintActiveCurveOnly";
		ao().SetToolTip(be(), componentResourceManager.GetString("CheckBoxPrintActiveCurveOnly.ToolTip"));
		c8().SetToolTip(be(), componentResourceManager.GetString("CheckBoxPrintActiveCurveOnly.ToolTip1"));
		be().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(a9(), "CheckBoxSASWPromptForConfiguration");
		a9().Name = "CheckBoxSASWPromptForConfiguration";
		ao().SetToolTip(a9(), componentResourceManager.GetString("CheckBoxSASWPromptForConfiguration.ToolTip"));
		c8().SetToolTip(a9(), componentResourceManager.GetString("CheckBoxSASWPromptForConfiguration.ToolTip1"));
		a9().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bx(), "TableLayoutPanel1");
		bx().Controls.Add(bv(), 2, 0);
		bx().Controls.Add(bt(), 1, 0);
		bx().Controls.Add(bs(), 0, 0);
		bx().Name = "TableLayoutPanel1";
		ao().SetToolTip(bx(), componentResourceManager.GetString("TableLayoutPanel1.ToolTip"));
		c8().SetToolTip(bx(), componentResourceManager.GetString("TableLayoutPanel1.ToolTip1"));
		componentResourceManager.ApplyResources(bv(), "Label17");
		bv().Name = "Label17";
		ao().SetToolTip(bv(), componentResourceManager.GetString("Label17.ToolTip"));
		c8().SetToolTip(bv(), componentResourceManager.GetString("Label17.ToolTip1"));
		componentResourceManager.ApplyResources(bt(), "TextBoxNumericBaselineReminderInterval");
		bt().f(A_0: false);
		bt().Name = "TextBoxNumericBaselineReminderInterval";
		bt().e(A_0: false);
		ao().SetToolTip(bt(), componentResourceManager.GetString("TextBoxNumericBaselineReminderInterval.ToolTip"));
		c8().SetToolTip(bt(), componentResourceManager.GetString("TextBoxNumericBaselineReminderInterval.ToolTip1"));
		componentResourceManager.ApplyResources(bs(), "LabelBaselineReminderInterval");
		bs().Name = "LabelBaselineReminderInterval";
		ao().SetToolTip(bs(), componentResourceManager.GetString("LabelBaselineReminderInterval.ToolTip"));
		c8().SetToolTip(bs(), componentResourceManager.GetString("LabelBaselineReminderInterval.ToolTip1"));
		componentResourceManager.ApplyResources(ap(), "GroupBoxRefSignalThresholds");
		ap().Controls.Add(aq());
		ap().Controls.Add(ar());
		ap().Controls.Add(@as());
		ap().Controls.Add(at());
		ap().Controls.Add(au());
		ap().Controls.Add(av());
		ap().Name = "GroupBoxRefSignalThresholds";
		ap().TabStop = false;
		ao().SetToolTip(ap(), componentResourceManager.GetString("GroupBoxRefSignalThresholds.ToolTip"));
		c8().SetToolTip(ap(), componentResourceManager.GetString("GroupBoxRefSignalThresholds.ToolTip1"));
		componentResourceManager.ApplyResources(aq(), "Label11");
		aq().Name = "Label11";
		ao().SetToolTip(aq(), componentResourceManager.GetString("Label11.ToolTip"));
		c8().SetToolTip(aq(), componentResourceManager.GetString("Label11.ToolTip1"));
		componentResourceManager.ApplyResources(ar(), "TextBoxMaxRefIntenWRTHist");
		ar().f(A_0: false);
		ar().Name = "TextBoxMaxRefIntenWRTHist";
		ar().e(A_0: false);
		ao().SetToolTip(ar(), componentResourceManager.GetString("TextBoxMaxRefIntenWRTHist.ToolTip"));
		c8().SetToolTip(ar(), componentResourceManager.GetString("TextBoxMaxRefIntenWRTHist.ToolTip1"));
		componentResourceManager.ApplyResources(@as(), "Label12");
		@as().Name = "Label12";
		ao().SetToolTip(@as(), componentResourceManager.GetString("Label12.ToolTip"));
		c8().SetToolTip(@as(), componentResourceManager.GetString("Label12.ToolTip1"));
		componentResourceManager.ApplyResources(at(), "Label10");
		at().Name = "Label10";
		ao().SetToolTip(at(), componentResourceManager.GetString("Label10.ToolTip"));
		c8().SetToolTip(at(), componentResourceManager.GetString("Label10.ToolTip1"));
		componentResourceManager.ApplyResources(au(), "TextBoxMinRefIntenWRTHist");
		au().f(A_0: false);
		au().Name = "TextBoxMinRefIntenWRTHist";
		au().e(A_0: false);
		ao().SetToolTip(au(), componentResourceManager.GetString("TextBoxMinRefIntenWRTHist.ToolTip"));
		c8().SetToolTip(au(), componentResourceManager.GetString("TextBoxMinRefIntenWRTHist.ToolTip1"));
		componentResourceManager.ApplyResources(av(), "Label9");
		av().Name = "Label9";
		ao().SetToolTip(av(), componentResourceManager.GetString("Label9.ToolTip"));
		c8().SetToolTip(av(), componentResourceManager.GetString("Label9.ToolTip1"));
		componentResourceManager.ApplyResources(bu(), "CheckBoxPromptForBaselineReminder");
		bu().Name = "CheckBoxPromptForBaselineReminder";
		ao().SetToolTip(bu(), componentResourceManager.GetString("CheckBoxPromptForBaselineReminder.ToolTip"));
		c8().SetToolTip(bu(), componentResourceManager.GetString("CheckBoxPromptForBaselineReminder.ToolTip1"));
		bu().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(y(), "CheckBoxScreenShotIncludesMenubar");
		y().Name = "CheckBoxScreenShotIncludesMenubar";
		ao().SetToolTip(y(), componentResourceManager.GetString("CheckBoxScreenShotIncludesMenubar.ToolTip"));
		c8().SetToolTip(y(), componentResourceManager.GetString("CheckBoxScreenShotIncludesMenubar.ToolTip1"));
		y().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(cf(), "GroupBoxUSDPS");
		cf().Controls.Add(cg());
		cf().Controls.Add(ch());
		cf().Controls.Add(ci());
		cf().Name = "GroupBoxUSDPS";
		cf().TabStop = false;
		ao().SetToolTip(cf(), componentResourceManager.GetString("GroupBoxUSDPS.ToolTip"));
		c8().SetToolTip(cf(), componentResourceManager.GetString("GroupBoxUSDPS.ToolTip1"));
		componentResourceManager.ApplyResources(cg(), "CheckBoxUSDPS");
		cg().BackColor = SystemColors.Window;
		cg().Name = "CheckBoxUSDPS";
		ao().SetToolTip(cg(), componentResourceManager.GetString("CheckBoxUSDPS.ToolTip"));
		c8().SetToolTip(cg(), componentResourceManager.GetString("CheckBoxUSDPS.ToolTip1"));
		cg().UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(ch(), "RadioButtonFineSpacing");
		ch().Name = "RadioButtonFineSpacing";
		ao().SetToolTip(ch(), componentResourceManager.GetString("RadioButtonFineSpacing.ToolTip"));
		c8().SetToolTip(ch(), componentResourceManager.GetString("RadioButtonFineSpacing.ToolTip1"));
		ch().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ci(), "RadioButtonStandardSpacing");
		ci().Checked = true;
		ci().Name = "RadioButtonStandardSpacing";
		ci().TabStop = true;
		ao().SetToolTip(ci(), componentResourceManager.GetString("RadioButtonStandardSpacing.ToolTip"));
		c8().SetToolTip(ci(), componentResourceManager.GetString("RadioButtonStandardSpacing.ToolTip1"));
		ci().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bw(), "CheckboxPromptForDisconnectOK");
		bw().Name = "CheckboxPromptForDisconnectOK";
		ao().SetToolTip(bw(), componentResourceManager.GetString("CheckboxPromptForDisconnectOK.ToolTip"));
		c8().SetToolTip(bw(), componentResourceManager.GetString("CheckboxPromptForDisconnectOK.ToolTip1"));
		bw().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bd(), "ButtonRestoreSettings");
		bd().Name = "ButtonRestoreSettings";
		ao().SetToolTip(bd(), componentResourceManager.GetString("ButtonRestoreSettings.ToolTip"));
		c8().SetToolTip(bd(), componentResourceManager.GetString("ButtonRestoreSettings.ToolTip1"));
		bd().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ct(), "TableLayoutPanel9");
		ct().Controls.Add(cx(), 1, 0);
		ct().Controls.Add(cv(), 0, 0);
		ct().Controls.Add(cu(), 3, 0);
		ct().Controls.Add(cw(), 2, 0);
		ct().Name = "TableLayoutPanel9";
		ao().SetToolTip(ct(), componentResourceManager.GetString("TableLayoutPanel9.ToolTip"));
		c8().SetToolTip(ct(), componentResourceManager.GetString("TableLayoutPanel9.ToolTip1"));
		componentResourceManager.ApplyResources(cx(), "TextBoxCustomRecipePath");
		cx().Name = "TextBoxCustomRecipePath";
		c8().SetToolTip(cx(), componentResourceManager.GetString("TextBoxCustomRecipePath.ToolTip"));
		ao().SetToolTip(cx(), componentResourceManager.GetString("TextBoxCustomRecipePath.ToolTip1"));
		componentResourceManager.ApplyResources(cv(), "Label21");
		cv().Name = "Label21";
		ao().SetToolTip(cv(), componentResourceManager.GetString("Label21.ToolTip"));
		c8().SetToolTip(cv(), componentResourceManager.GetString("Label21.ToolTip1"));
		componentResourceManager.ApplyResources(cu(), "ButtonCustomRecipePathReset");
		cu().Name = "ButtonCustomRecipePathReset";
		ao().SetToolTip(cu(), componentResourceManager.GetString("ButtonCustomRecipePathReset.ToolTip"));
		c8().SetToolTip(cu(), componentResourceManager.GetString("ButtonCustomRecipePathReset.ToolTip1"));
		cu().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(cw(), "ButtonCustomRecipePathBrowse");
		cw().Name = "ButtonCustomRecipePathBrowse";
		ao().SetToolTip(cw(), componentResourceManager.GetString("ButtonCustomRecipePathBrowse.ToolTip"));
		c8().SetToolTip(cw(), componentResourceManager.GetString("ButtonCustomRecipePathBrowse.ToolTip1"));
		cw().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(c7(), "CheckBoxForceBaselineIfIntervalExceeded");
		c7().Name = "CheckBoxForceBaselineIfIntervalExceeded";
		ao().SetToolTip(c7(), componentResourceManager.GetString("CheckBoxForceBaselineIfIntervalExceeded.ToolTip"));
		c8().SetToolTip(c7(), componentResourceManager.GetString("CheckBoxForceBaselineIfIntervalExceeded.ToolTip1"));
		c7().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(c9(), "TLPCustomPrintedLogo");
		c9().Controls.Add(db(), 3, 0);
		c9().Controls.Add(dc(), 2, 0);
		c9().Controls.Add(da(), 0, 0);
		c9().Controls.Add(dd(), 1, 0);
		c9().Name = "TLPCustomPrintedLogo";
		ao().SetToolTip(c9(), componentResourceManager.GetString("TLPCustomPrintedLogo.ToolTip"));
		c8().SetToolTip(c9(), componentResourceManager.GetString("TLPCustomPrintedLogo.ToolTip1"));
		componentResourceManager.ApplyResources(db(), "ButtonClearCustomPrintedLogo");
		db().Name = "ButtonClearCustomPrintedLogo";
		ao().SetToolTip(db(), componentResourceManager.GetString("ButtonClearCustomPrintedLogo.ToolTip"));
		c8().SetToolTip(db(), componentResourceManager.GetString("ButtonClearCustomPrintedLogo.ToolTip1"));
		db().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(dc(), "ButtonSelectCustomPrintedLogo");
		dc().Name = "ButtonSelectCustomPrintedLogo";
		ao().SetToolTip(dc(), componentResourceManager.GetString("ButtonSelectCustomPrintedLogo.ToolTip"));
		c8().SetToolTip(dc(), componentResourceManager.GetString("ButtonSelectCustomPrintedLogo.ToolTip1"));
		dc().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(da(), "Label24");
		da().Name = "Label24";
		ao().SetToolTip(da(), componentResourceManager.GetString("Label24.ToolTip"));
		c8().SetToolTip(da(), componentResourceManager.GetString("Label24.ToolTip1"));
		componentResourceManager.ApplyResources(dd(), "TBACustomPrintedLogoFileName");
		dd().Name = "TBACustomPrintedLogoFileName";
		dd().ReadOnly = true;
		ao().SetToolTip(dd(), componentResourceManager.GetString("TBACustomPrintedLogoFileName.ToolTip"));
		c8().SetToolTip(dd(), componentResourceManager.GetString("TBACustomPrintedLogoFileName.ToolTip1"));
		dd().e(A_0: false);
		componentResourceManager.ApplyResources(v(), "TabPageDataRecording");
		v().Controls.Add(cd());
		v().Name = "TabPageDataRecording";
		c8().SetToolTip(v(), componentResourceManager.GetString("TabPageDataRecording.ToolTip"));
		ao().SetToolTip(v(), componentResourceManager.GetString("TabPageDataRecording.ToolTip1"));
		v().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(cd(), "TableLayoutPanel6");
		cd().Controls.Add(ce(), 0, 0);
		cd().Controls.Add(b1(), 0, 3);
		cd().Controls.Add(b5(), 0, 2);
		cd().Controls.Add(ba(), 0, 1);
		cd().Name = "TableLayoutPanel6";
		ao().SetToolTip(cd(), componentResourceManager.GetString("TableLayoutPanel6.ToolTip"));
		c8().SetToolTip(cd(), componentResourceManager.GetString("TableLayoutPanel6.ToolTip1"));
		componentResourceManager.ApplyResources(ce(), "Panel1");
		ce().Controls.Add(r());
		ce().Controls.Add(s());
		ce().Name = "Panel1";
		c8().SetToolTip(ce(), componentResourceManager.GetString("Panel1.ToolTip"));
		ao().SetToolTip(ce(), componentResourceManager.GetString("Panel1.ToolTip1"));
		componentResourceManager.ApplyResources(b1(), "CheckBoxContactProbeTemplateMode");
		b1().Name = "CheckBoxContactProbeTemplateMode";
		ao().SetToolTip(b1(), componentResourceManager.GetString("CheckBoxContactProbeTemplateMode.ToolTip"));
		c8().SetToolTip(b1(), componentResourceManager.GetString("CheckBoxContactProbeTemplateMode.ToolTip1"));
		b1().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(b5(), "GroupBoxAutoArchiveHistory");
		b5().Controls.Add(b4());
		b5().Controls.Add(cc());
		b5().Controls.Add(cb());
		b5().Controls.Add(b9());
		b5().Controls.Add(ca());
		b5().Controls.Add(b6());
		b5().Controls.Add(b7());
		b5().Controls.Add(b8());
		b5().Name = "GroupBoxAutoArchiveHistory";
		b5().TabStop = false;
		ao().SetToolTip(b5(), componentResourceManager.GetString("GroupBoxAutoArchiveHistory.ToolTip"));
		c8().SetToolTip(b5(), componentResourceManager.GetString("GroupBoxAutoArchiveHistory.ToolTip1"));
		componentResourceManager.ApplyResources(b4(), "CheckBoxAutoArchiveHistory");
		b4().BackColor = SystemColors.Window;
		b4().Name = "CheckBoxAutoArchiveHistory";
		ao().SetToolTip(b4(), componentResourceManager.GetString("CheckBoxAutoArchiveHistory.ToolTip"));
		c8().SetToolTip(b4(), componentResourceManager.GetString("CheckBoxAutoArchiveHistory.ToolTip1"));
		b4().UseVisualStyleBackColor = false;
		componentResourceManager.ApplyResources(cc(), "CheckBoxClearHistoryOnArchive");
		cc().Name = "CheckBoxClearHistoryOnArchive";
		ao().SetToolTip(cc(), componentResourceManager.GetString("CheckBoxClearHistoryOnArchive.ToolTip"));
		c8().SetToolTip(cc(), componentResourceManager.GetString("CheckBoxClearHistoryOnArchive.ToolTip1"));
		cc().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(cb(), "TextBoxNumericHistoryArchiveMaxDiskSpace");
		cb().f(A_0: true);
		cb().Name = "TextBoxNumericHistoryArchiveMaxDiskSpace";
		cb().e(A_0: false);
		ao().SetToolTip(cb(), componentResourceManager.GetString("TextBoxNumericHistoryArchiveMaxDiskSpace.ToolTip"));
		c8().SetToolTip(cb(), componentResourceManager.GetString("TextBoxNumericHistoryArchiveMaxDiskSpace.ToolTip1"));
		componentResourceManager.ApplyResources(b9(), "Label20");
		b9().Name = "Label20";
		ao().SetToolTip(b9(), componentResourceManager.GetString("Label20.ToolTip"));
		c8().SetToolTip(b9(), componentResourceManager.GetString("Label20.ToolTip1"));
		componentResourceManager.ApplyResources(ca(), "Label19");
		ca().Name = "Label19";
		ao().SetToolTip(ca(), componentResourceManager.GetString("Label19.ToolTip"));
		c8().SetToolTip(ca(), componentResourceManager.GetString("Label19.ToolTip1"));
		componentResourceManager.ApplyResources(b6(), "Label18");
		b6().Name = "Label18";
		ao().SetToolTip(b6(), componentResourceManager.GetString("Label18.ToolTip"));
		c8().SetToolTip(b6(), componentResourceManager.GetString("Label18.ToolTip1"));
		componentResourceManager.ApplyResources(b7(), "TextBoxHistoryArchivePath");
		b7().Name = "TextBoxHistoryArchivePath";
		c8().SetToolTip(b7(), componentResourceManager.GetString("TextBoxHistoryArchivePath.ToolTip"));
		ao().SetToolTip(b7(), componentResourceManager.GetString("TextBoxHistoryArchivePath.ToolTip1"));
		componentResourceManager.ApplyResources(b8(), "ButtonGetHistoryArchivePath");
		b8().Name = "ButtonGetHistoryArchivePath";
		ao().SetToolTip(b8(), componentResourceManager.GetString("ButtonGetHistoryArchivePath.ToolTip"));
		c8().SetToolTip(b8(), componentResourceManager.GetString("ButtonGetHistoryArchivePath.ToolTip1"));
		b8().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ba(), "GroupBox1");
		ba().Controls.Add(bb());
		ba().Controls.Add(bc());
		ba().Name = "GroupBox1";
		ba().TabStop = false;
		ao().SetToolTip(ba(), componentResourceManager.GetString("GroupBox1.ToolTip"));
		c8().SetToolTip(ba(), componentResourceManager.GetString("GroupBox1.ToolTip1"));
		componentResourceManager.ApplyResources(bb(), "ChkBoxAddContMeasToHistory");
		bb().Name = "ChkBoxAddContMeasToHistory";
		ao().SetToolTip(bb(), componentResourceManager.GetString("ChkBoxAddContMeasToHistory.ToolTip"));
		c8().SetToolTip(bb(), componentResourceManager.GetString("ChkBoxAddContMeasToHistory.ToolTip1"));
		bb().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bc(), "ChkBoxChkBoxPromptAddContMeasToHistory");
		bc().Name = "ChkBoxChkBoxPromptAddContMeasToHistory";
		ao().SetToolTip(bc(), componentResourceManager.GetString("ChkBoxChkBoxPromptAddContMeasToHistory.ToolTip"));
		c8().SetToolTip(bc(), componentResourceManager.GetString("ChkBoxChkBoxPromptAddContMeasToHistory.ToolTip1"));
		bc().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bg(), "TabPageCalibration");
		bg().Controls.Add(bk());
		bg().Controls.Add(bm());
		bg().Name = "TabPageCalibration";
		c8().SetToolTip(bg(), componentResourceManager.GetString("TabPageCalibration.ToolTip"));
		ao().SetToolTip(bg(), componentResourceManager.GetString("TabPageCalibration.ToolTip1"));
		bg().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bk(), "CheckBoxWavelenCalEnable");
		bk().Name = "CheckBoxWavelenCalEnable";
		ao().SetToolTip(bk(), componentResourceManager.GetString("CheckBoxWavelenCalEnable.ToolTip"));
		c8().SetToolTip(bk(), componentResourceManager.GetString("CheckBoxWavelenCalEnable.ToolTip1"));
		bk().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bm(), "GroupBoxWavelenCal");
		bm().Controls.Add(bo());
		bm().Controls.Add(bn());
		bm().Controls.Add(bh());
		bm().Controls.Add(bl());
		bm().Controls.Add(bj());
		bm().Controls.Add(bi());
		bm().Name = "GroupBoxWavelenCal";
		bm().TabStop = false;
		ao().SetToolTip(bm(), componentResourceManager.GetString("GroupBoxWavelenCal.ToolTip"));
		c8().SetToolTip(bm(), componentResourceManager.GetString("GroupBoxWavelenCal.ToolTip1"));
		componentResourceManager.ApplyResources(bo(), "TextBoxNumWavelenCalPeriod");
		bo().f(A_0: false);
		bo().Name = "TextBoxNumWavelenCalPeriod";
		bo().e(A_0: false);
		ao().SetToolTip(bo(), componentResourceManager.GetString("TextBoxNumWavelenCalPeriod.ToolTip"));
		c8().SetToolTip(bo(), componentResourceManager.GetString("TextBoxNumWavelenCalPeriod.ToolTip1"));
		componentResourceManager.ApplyResources(bn(), "LabelWavelenCalFreq");
		bn().Name = "LabelWavelenCalFreq";
		ao().SetToolTip(bn(), componentResourceManager.GetString("LabelWavelenCalFreq.ToolTip"));
		c8().SetToolTip(bn(), componentResourceManager.GetString("LabelWavelenCalFreq.ToolTip1"));
		componentResourceManager.ApplyResources(bh(), "Label13");
		bh().Name = "Label13";
		ao().SetToolTip(bh(), componentResourceManager.GetString("Label13.ToolTip"));
		c8().SetToolTip(bh(), componentResourceManager.GetString("Label13.ToolTip1"));
		componentResourceManager.ApplyResources(bl(), "RadioButtonWavelenCalEveryMeas");
		bl().Name = "RadioButtonWavelenCalEveryMeas";
		bl().TabStop = true;
		ao().SetToolTip(bl(), componentResourceManager.GetString("RadioButtonWavelenCalEveryMeas.ToolTip"));
		c8().SetToolTip(bl(), componentResourceManager.GetString("RadioButtonWavelenCalEveryMeas.ToolTip1"));
		bl().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bj(), "RadioButtonWavelenCalStartup");
		bj().Name = "RadioButtonWavelenCalStartup";
		bj().TabStop = true;
		ao().SetToolTip(bj(), componentResourceManager.GetString("RadioButtonWavelenCalStartup.ToolTip"));
		c8().SetToolTip(bj(), componentResourceManager.GetString("RadioButtonWavelenCalStartup.ToolTip1"));
		bj().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bi(), "RadioButtonWavelenCalPeriodic");
		bi().Name = "RadioButtonWavelenCalPeriodic";
		bi().TabStop = true;
		ao().SetToolTip(bi(), componentResourceManager.GetString("RadioButtonWavelenCalPeriodic.ToolTip"));
		c8().SetToolTip(bi(), componentResourceManager.GetString("RadioButtonWavelenCalPeriodic.ToolTip1"));
		bi().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(z(), "TabPageSoftwareUpdate");
		z().Controls.Add(an());
		z().Controls.Add(am());
		z().Controls.Add(al());
		z().Controls.Add(ai());
		z().Controls.Add(aj());
		z().Controls.Add(ak());
		z().Controls.Add(af());
		z().Controls.Add(ag());
		z().Controls.Add(ae());
		z().Controls.Add(ad());
		z().Controls.Add(aa());
		z().Controls.Add(ab());
		z().Controls.Add(ac());
		z().Controls.Add(ah());
		z().Name = "TabPageSoftwareUpdate";
		c8().SetToolTip(z(), componentResourceManager.GetString("TabPageSoftwareUpdate.ToolTip"));
		ao().SetToolTip(z(), componentResourceManager.GetString("TabPageSoftwareUpdate.ToolTip1"));
		z().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(an(), "RichTextBoxNotes");
		an().Name = "RichTextBoxNotes";
		c8().SetToolTip(an(), componentResourceManager.GetString("RichTextBoxNotes.ToolTip"));
		ao().SetToolTip(an(), componentResourceManager.GetString("RichTextBoxNotes.ToolTip1"));
		componentResourceManager.ApplyResources(am(), "LabelSoftwareUpdateStatus");
		am().BorderStyle = BorderStyle.FixedSingle;
		am().Name = "LabelSoftwareUpdateStatus";
		ao().SetToolTip(am(), componentResourceManager.GetString("LabelSoftwareUpdateStatus.ToolTip"));
		c8().SetToolTip(am(), componentResourceManager.GetString("LabelSoftwareUpdateStatus.ToolTip1"));
		componentResourceManager.ApplyResources(al(), "LabelNewVersion");
		al().BorderStyle = BorderStyle.FixedSingle;
		al().Name = "LabelNewVersion";
		ao().SetToolTip(al(), componentResourceManager.GetString("LabelNewVersion.ToolTip"));
		c8().SetToolTip(al(), componentResourceManager.GetString("LabelNewVersion.ToolTip1"));
		componentResourceManager.ApplyResources(ai(), "LabelCurrentVersion");
		ai().BorderStyle = BorderStyle.FixedSingle;
		ai().Name = "LabelCurrentVersion";
		ao().SetToolTip(ai(), componentResourceManager.GetString("LabelCurrentVersion.ToolTip"));
		c8().SetToolTip(ai(), componentResourceManager.GetString("LabelCurrentVersion.ToolTip1"));
		componentResourceManager.ApplyResources(aj(), "LabelLicenseLevel");
		aj().BorderStyle = BorderStyle.FixedSingle;
		aj().Name = "LabelLicenseLevel";
		ao().SetToolTip(aj(), componentResourceManager.GetString("LabelLicenseLevel.ToolTip"));
		c8().SetToolTip(aj(), componentResourceManager.GetString("LabelLicenseLevel.ToolTip1"));
		componentResourceManager.ApplyResources(ak(), "Label8");
		ak().Name = "Label8";
		ao().SetToolTip(ak(), componentResourceManager.GetString("Label8.ToolTip"));
		c8().SetToolTip(ak(), componentResourceManager.GetString("Label8.ToolTip1"));
		componentResourceManager.ApplyResources(af(), "Label7");
		af().Name = "Label7";
		ao().SetToolTip(af(), componentResourceManager.GetString("Label7.ToolTip"));
		c8().SetToolTip(af(), componentResourceManager.GetString("Label7.ToolTip1"));
		componentResourceManager.ApplyResources(ag(), "Label6");
		ag().Name = "Label6";
		ao().SetToolTip(ag(), componentResourceManager.GetString("Label6.ToolTip"));
		c8().SetToolTip(ag(), componentResourceManager.GetString("Label6.ToolTip1"));
		componentResourceManager.ApplyResources(ae(), "Label5");
		ae().Name = "Label5";
		ao().SetToolTip(ae(), componentResourceManager.GetString("Label5.ToolTip"));
		c8().SetToolTip(ae(), componentResourceManager.GetString("Label5.ToolTip1"));
		componentResourceManager.ApplyResources(ad(), "InstallButton");
		ad().Name = "InstallButton";
		ao().SetToolTip(ad(), componentResourceManager.GetString("InstallButton.ToolTip"));
		c8().SetToolTip(ad(), componentResourceManager.GetString("InstallButton.ToolTip1"));
		ad().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(aa(), "Label4");
		aa().Name = "Label4";
		ao().SetToolTip(aa(), componentResourceManager.GetString("Label4.ToolTip"));
		c8().SetToolTip(aa(), componentResourceManager.GetString("Label4.ToolTip1"));
		componentResourceManager.ApplyResources(ab(), "Label3");
		ab().Name = "Label3";
		ao().SetToolTip(ab(), componentResourceManager.GetString("Label3.ToolTip"));
		c8().SetToolTip(ab(), componentResourceManager.GetString("Label3.ToolTip1"));
		componentResourceManager.ApplyResources(ac(), "Label2");
		ac().Name = "Label2";
		ao().SetToolTip(ac(), componentResourceManager.GetString("Label2.ToolTip"));
		c8().SetToolTip(ac(), componentResourceManager.GetString("Label2.ToolTip1"));
		componentResourceManager.ApplyResources(ah(), "TextBoxNumericReminderPeriod");
		ah().f(A_0: false);
		ah().Name = "TextBoxNumericReminderPeriod";
		ah().e(A_0: false);
		ao().SetToolTip(ah(), componentResourceManager.GetString("TextBoxNumericReminderPeriod.ToolTip"));
		c8().SetToolTip(ah(), componentResourceManager.GetString("TextBoxNumericReminderPeriod.ToolTip1"));
		componentResourceManager.ApplyResources(ay(), "TabPageLicenses");
		ay().Controls.Add(cq());
		ay().Controls.Add(a2());
		ay().Controls.Add(a1());
		ay().Controls.Add(a0());
		ay().Controls.Add(az());
		ay().Name = "TabPageLicenses";
		c8().SetToolTip(ay(), componentResourceManager.GetString("TabPageLicenses.ToolTip"));
		ao().SetToolTip(ay(), componentResourceManager.GetString("TabPageLicenses.ToolTip1"));
		ay().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(cq(), "ButtonRestore");
		cq().Name = "ButtonRestore";
		ao().SetToolTip(cq(), componentResourceManager.GetString("ButtonRestore.ToolTip"));
		c8().SetToolTip(cq(), componentResourceManager.GetString("ButtonRestore.ToolTip1"));
		cq().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(a2(), "Label15");
		a2().Name = "Label15";
		ao().SetToolTip(a2(), componentResourceManager.GetString("Label15.ToolTip"));
		c8().SetToolTip(a2(), componentResourceManager.GetString("Label15.ToolTip1"));
		componentResourceManager.ApplyResources(a1(), "ButtonDeleteConfigLicensesLicense");
		a1().Name = "ButtonDeleteConfigLicensesLicense";
		ao().SetToolTip(a1(), componentResourceManager.GetString("ButtonDeleteConfigLicensesLicense.ToolTip"));
		c8().SetToolTip(a1(), componentResourceManager.GetString("ButtonDeleteConfigLicensesLicense.ToolTip1"));
		a1().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(a0(), "CheckedListBoxLicenses");
		a0().CheckOnClick = true;
		a0().FormattingEnabled = true;
		a0().Name = "CheckedListBoxLicenses";
		ao().SetToolTip(a0(), componentResourceManager.GetString("CheckedListBoxLicenses.ToolTip"));
		c8().SetToolTip(a0(), componentResourceManager.GetString("CheckedListBoxLicenses.ToolTip1"));
		componentResourceManager.ApplyResources(az(), "Label14");
		az().Name = "Label14";
		ao().SetToolTip(az(), componentResourceManager.GetString("Label14.ToolTip"));
		c8().SetToolTip(az(), componentResourceManager.GetString("Label14.ToolTip1"));
		componentResourceManager.ApplyResources(a3(), "TabPageMeasReport");
		a3().Controls.Add(a8());
		a3().Controls.Add(a7());
		a3().Controls.Add(a4());
		a3().Controls.Add(a5());
		a3().Controls.Add(a6());
		a3().Name = "TabPageMeasReport";
		c8().SetToolTip(a3(), componentResourceManager.GetString("TabPageMeasReport.ToolTip"));
		ao().SetToolTip(a3(), componentResourceManager.GetString("TabPageMeasReport.ToolTip1"));
		a3().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(a8(), "CheckBoxReportPromptBeforeClose");
		a8().Name = "CheckBoxReportPromptBeforeClose";
		ao().SetToolTip(a8(), componentResourceManager.GetString("CheckBoxReportPromptBeforeClose.ToolTip"));
		c8().SetToolTip(a8(), componentResourceManager.GetString("CheckBoxReportPromptBeforeClose.ToolTip1"));
		a8().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(a7(), "CheckBoxPromptBeforeOverwriteMark");
		a7().Name = "CheckBoxPromptBeforeOverwriteMark";
		ao().SetToolTip(a7(), componentResourceManager.GetString("CheckBoxPromptBeforeOverwriteMark.ToolTip"));
		c8().SetToolTip(a7(), componentResourceManager.GetString("CheckBoxPromptBeforeOverwriteMark.ToolTip1"));
		a7().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(a4(), "ButtonInternalBrowse");
		a4().Name = "ButtonInternalBrowse";
		ao().SetToolTip(a4(), componentResourceManager.GetString("ButtonInternalBrowse.ToolTip"));
		c8().SetToolTip(a4(), componentResourceManager.GetString("ButtonInternalBrowse.ToolTip1"));
		a4().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(a5(), "TextBoxReportPath");
		a5().Name = "TextBoxReportPath";
		c8().SetToolTip(a5(), componentResourceManager.GetString("TextBoxReportPath.ToolTip"));
		ao().SetToolTip(a5(), componentResourceManager.GetString("TextBoxReportPath.ToolTip1"));
		componentResourceManager.ApplyResources(a6(), "Label16");
		a6().Name = "Label16";
		ao().SetToolTip(a6(), componentResourceManager.GetString("Label16.ToolTip"));
		c8().SetToolTip(a6(), componentResourceManager.GetString("Label16.ToolTip1"));
		ao().AutoPopDelay = 5000;
		ao().InitialDelay = 500;
		ao().ReshowDelay = 100;
		c8().AutoPopDelay = 10000;
		c8().InitialDelay = 500;
		c8().ReshowDelay = 100;
		base.AcceptButton = l();
		componentResourceManager.ApplyResources(this, "$this");
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = m();
		base.Controls.Add(u());
		base.Controls.Add(m());
		base.Controls.Add(l());
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogOptionSettings";
		base.ShowInTaskbar = false;
		c8().SetToolTip(this, componentResourceManager.GetString("$this.ToolTip"));
		ao().SetToolTip(this, componentResourceManager.GetString("$this.ToolTip1"));
		s().ResumeLayout(performLayout: false);
		s().PerformLayout();
		u().ResumeLayout(performLayout: false);
		w().ResumeLayout(performLayout: false);
		w().PerformLayout();
		by().ResumeLayout(performLayout: false);
		by().PerformLayout();
		c2().ResumeLayout(performLayout: false);
		c2().PerformLayout();
		cy().ResumeLayout(performLayout: false);
		cy().PerformLayout();
		cz().ResumeLayout(performLayout: false);
		cz().PerformLayout();
		bz().ResumeLayout(performLayout: false);
		bz().PerformLayout();
		cn().ResumeLayout(performLayout: false);
		cn().PerformLayout();
		cm().ResumeLayout(performLayout: false);
		cm().PerformLayout();
		b2().ResumeLayout(performLayout: false);
		b2().PerformLayout();
		b0().ResumeLayout(performLayout: false);
		b0().PerformLayout();
		bx().ResumeLayout(performLayout: false);
		bx().PerformLayout();
		ap().ResumeLayout(performLayout: false);
		ap().PerformLayout();
		cf().ResumeLayout(performLayout: false);
		cf().PerformLayout();
		ct().ResumeLayout(performLayout: false);
		ct().PerformLayout();
		c9().ResumeLayout(performLayout: false);
		c9().PerformLayout();
		v().ResumeLayout(performLayout: false);
		cd().ResumeLayout(performLayout: false);
		cd().PerformLayout();
		ce().ResumeLayout(performLayout: false);
		ce().PerformLayout();
		b5().ResumeLayout(performLayout: false);
		b5().PerformLayout();
		ba().ResumeLayout(performLayout: false);
		ba().PerformLayout();
		bg().ResumeLayout(performLayout: false);
		bg().PerformLayout();
		bm().ResumeLayout(performLayout: false);
		bm().PerformLayout();
		z().ResumeLayout(performLayout: false);
		z().PerformLayout();
		ay().ResumeLayout(performLayout: false);
		ay().PerformLayout();
		a3().ResumeLayout(performLayout: false);
		a3().PerformLayout();
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button l()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = y;
		Button button = this.m_b;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_b = A_0;
		button = this.m_b;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button m()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = x;
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
	internal virtual CheckBox n()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(CheckBox A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox o()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(CheckBox A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button p()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = z;
		Button button = this.m_f;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_f = A_0;
		button = this.m_f;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox q()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TextBox A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox r()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(CheckBox A_0)
	{
		EventHandler value = w;
		CheckBox checkBox = this.m_h;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_h = A_0;
		checkBox = this.m_h;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox s()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(GroupBox A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label t()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabControl u()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TabControl A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage v()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TabPage A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage w()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TabPage A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox x()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(CheckBox A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox y()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(CheckBox A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage z()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TabPage A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aa()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ab()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ac()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ad()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Button A_0)
	{
		EventHandler value = v;
		Button button = this.m_t;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_t = A_0;
		button = this.m_t;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ae()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label af()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ag()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Label A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ah()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hy A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ai()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Label A_0)
	{
		this.m_y = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aj()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Label A_0)
	{
		this.m_z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ak()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Label A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label al()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Label A_0)
	{
		this.m_ab = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label am()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(Label A_0)
	{
		this.m_ac = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RichTextBox an()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(RichTextBox A_0)
	{
		MouseEventHandler value = a;
		RichTextBox richTextBox = this.m_ad;
		if (richTextBox != null)
		{
			richTextBox.MouseDoubleClick -= value;
		}
		this.m_ad = A_0;
		richTextBox = this.m_ad;
		if (richTextBox != null)
		{
			richTextBox.MouseDoubleClick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip ao()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolTip A_0)
	{
		this.m_ae = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ap()
	{
		return this.m_af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(GroupBox A_0)
	{
		this.m_af = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aq()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(Label A_0)
	{
		this.m_ag = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ar()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(hy A_0)
	{
		this.m_ah = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label @as()
	{
		return this.m_ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(Label A_0)
	{
		this.m_ai = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label at()
	{
		return this.m_aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(Label A_0)
	{
		this.m_aj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy au()
	{
		return this.m_ak;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(hy A_0)
	{
		this.m_ak = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label av()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(Label A_0)
	{
		this.m_al = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox aw()
	{
		return this.m_am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
	{
		this.m_am = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ax()
	{
		return this.m_an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(Label A_0)
	{
		this.m_an = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage ay()
	{
		return this.m_ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TabPage A_0)
	{
		this.m_ao = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label az()
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
	internal virtual CheckedListBox a0()
	{
		return this.m_aq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(CheckedListBox A_0)
	{
		this.m_aq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button a1()
	{
		return this.m_ar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Button A_0)
	{
		EventHandler value = u;
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
	internal virtual Label a2()
	{
		return this.m_as;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(Label A_0)
	{
		this.m_as = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage a3()
	{
		return this.m_at;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TabPage A_0)
	{
		this.m_at = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button a4()
	{
		return this.m_au;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Button A_0)
	{
		EventHandler value = t;
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
	internal virtual TextBox a5()
	{
		return this.m_av;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TextBox A_0)
	{
		this.m_av = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a6()
	{
		return this.m_aw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(Label A_0)
	{
		this.m_aw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox a7()
	{
		return this.m_ax;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(CheckBox A_0)
	{
		this.m_ax = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox a8()
	{
		return this.m_ay;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(CheckBox A_0)
	{
		this.m_ay = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox a9()
	{
		return this.m_az;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(CheckBox A_0)
	{
		this.m_az = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ba()
	{
		return this.m_a0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(GroupBox A_0)
	{
		this.m_a0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox bb()
	{
		return this.m_a1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(CheckBox A_0)
	{
		this.m_a1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox bc()
	{
		return this.m_a2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(CheckBox A_0)
	{
		this.m_a2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button bd()
	{
		return this.m_a3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Button A_0)
	{
		EventHandler value = r;
		Button button = this.m_a3;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_a3 = A_0;
		button = this.m_a3;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox be()
	{
		return this.m_a4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(CheckBox A_0)
	{
		this.m_a4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox bf()
	{
		return this.m_a5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(CheckBox A_0)
	{
		this.m_a5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage bg()
	{
		return this.m_a6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(TabPage A_0)
	{
		this.m_a6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bh()
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
	internal virtual RadioButton bi()
	{
		return this.m_a8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(RadioButton A_0)
	{
		EventHandler value = q;
		RadioButton radioButton = this.m_a8;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_a8 = A_0;
		radioButton = this.m_a8;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton bj()
	{
		return this.m_a9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(RadioButton A_0)
	{
		this.m_a9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox bk()
	{
		return this.m_ba;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(CheckBox A_0)
	{
		EventHandler value = p;
		CheckBox checkBox = this.m_ba;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_ba = A_0;
		checkBox = this.m_ba;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton bl()
	{
		return this.m_bb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(RadioButton A_0)
	{
		this.m_bb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox bm()
	{
		return this.m_bc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(GroupBox A_0)
	{
		this.m_bc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bn()
	{
		return this.m_bd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(Label A_0)
	{
		this.m_bd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy bo()
	{
		return this.m_be;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(hy A_0)
	{
		this.m_be = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bp()
	{
		return this.m_bf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(Label A_0)
	{
		this.m_bf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy bq()
	{
		return this.m_bg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(hy A_0)
	{
		this.m_bg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label br()
	{
		return this.m_bh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(Label A_0)
	{
		this.m_bh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bs()
	{
		return this.m_bi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(Label A_0)
	{
		this.m_bi = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy bt()
	{
		return this.m_bj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(hy A_0)
	{
		this.m_bj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox bu()
	{
		return this.m_bk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(CheckBox A_0)
	{
		this.m_bk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bv()
	{
		return this.m_bl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(Label A_0)
	{
		this.m_bl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox bw()
	{
		return this.m_bm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(CheckBox A_0)
	{
		this.m_bm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel bx()
	{
		return this.m_bn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_bn = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel by()
	{
		return this.m_bo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_bo = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel bz()
	{
		return this.m_bp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
	{
		this.m_bp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel b0()
	{
		return this.m_bq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TableLayoutPanel A_0)
	{
		this.m_bq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox b1()
	{
		return this.m_br;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(CheckBox A_0)
	{
		this.m_br = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel b2()
	{
		return this.m_bs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TableLayoutPanel A_0)
	{
		this.m_bs = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button b3()
	{
		return this.m_bt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Button A_0)
	{
		EventHandler value = s;
		Button button = this.m_bt;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_bt = A_0;
		button = this.m_bt;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox b4()
	{
		return this.m_bu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(CheckBox A_0)
	{
		EventHandler value = n;
		CheckBox checkBox = this.m_bu;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_bu = A_0;
		checkBox = this.m_bu;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox b5()
	{
		return this.m_bv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(GroupBox A_0)
	{
		this.m_bv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b6()
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
	internal virtual TextBox b7()
	{
		return this.m_bx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TextBox A_0)
	{
		this.m_bx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button b8()
	{
		return this.m_by;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Button A_0)
	{
		EventHandler value = o;
		Button button = this.m_by;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_by = A_0;
		button = this.m_by;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b9()
	{
		return this.m_bz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(Label A_0)
	{
		this.m_bz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ca()
	{
		return this.m_b0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(Label A_0)
	{
		this.m_b0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy cb()
	{
		return this.m_b1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(hy A_0)
	{
		this.m_b1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox cc()
	{
		return this.m_b2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(CheckBox A_0)
	{
		this.m_b2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel cd()
	{
		return this.m_b3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(TableLayoutPanel A_0)
	{
		this.m_b3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel ce()
	{
		return this.m_b4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Panel A_0)
	{
		this.m_b4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox cf()
	{
		return this.m_b5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(GroupBox A_0)
	{
		this.m_b5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox cg()
	{
		return this.m_b6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(CheckBox A_0)
	{
		EventHandler value = m;
		CheckBox checkBox = this.m_b6;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_b6 = A_0;
		checkBox = this.m_b6;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ch()
	{
		return this.m_b7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(RadioButton A_0)
	{
		this.m_b7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ci()
	{
		return this.m_b8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(RadioButton A_0)
	{
		this.m_b8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox cj()
	{
		return this.m_b9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(CheckBox A_0)
	{
		EventHandler value = j;
		CheckBox checkBox = this.m_b9;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_b9 = A_0;
		checkBox = this.m_b9;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ck()
	{
		return this.m_ca;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(CheckBox A_0)
	{
		EventHandler value = l;
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
	internal virtual Button cl()
	{
		return this.m_cb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Button A_0)
	{
		EventHandler value = k;
		Button button = this.m_cb;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_cb = A_0;
		button = this.m_cb;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel cm()
	{
		return this.m_cc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(TableLayoutPanel A_0)
	{
		this.m_cc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel cn()
	{
		return this.m_cd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(TableLayoutPanel A_0)
	{
		this.m_cd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox co()
	{
		return this.m_ce;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(CheckBox A_0)
	{
		EventHandler value = i;
		CheckBox checkBox = this.m_ce;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_ce = A_0;
		checkBox = this.m_ce;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox cp()
	{
		return this.m_cf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(CheckBox A_0)
	{
		EventHandler value = h;
		CheckBox checkBox = this.m_cf;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_cf = A_0;
		checkBox = this.m_cf;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button cq()
	{
		return this.m_cg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Button A_0)
	{
		this.m_cg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox cr()
	{
		return this.m_ch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(CheckBox A_0)
	{
		this.m_ch = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox cs()
	{
		return this.m_ci;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(CheckBox A_0)
	{
		this.m_ci = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ct()
	{
		return this.m_cj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TableLayoutPanel A_0)
	{
		this.m_cj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button cu()
	{
		return this.m_ck;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(Button A_0)
	{
		EventHandler value = f;
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
	internal virtual Label cv()
	{
		return this.m_cl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(Label A_0)
	{
		this.m_cl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button cw()
	{
		return this.m_cm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(Button A_0)
	{
		EventHandler value = g;
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
	internal virtual TextBox cx()
	{
		return this.m_cn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TextBox A_0)
	{
		this.m_cn = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox cy()
	{
		return this.m_co;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(GroupBox A_0)
	{
		this.m_co = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel cz()
	{
		return this.m_cp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(TableLayoutPanel A_0)
	{
		this.m_cp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c0()
	{
		return this.m_cq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ae(Label A_0)
	{
		this.m_cq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox c1()
	{
		return this.m_cr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ComboBox A_0)
	{
		this.m_cr = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel c2()
	{
		return this.m_cs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(TableLayoutPanel A_0)
	{
		this.m_cs = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox c3()
	{
		return this.m_ct;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TextBox A_0)
	{
		this.m_ct = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c4()
	{
		return this.m_cu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void af(Label A_0)
	{
		this.m_cu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button c5()
	{
		return this.m_cv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(Button A_0)
	{
		EventHandler value = d;
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
	internal virtual Button c6()
	{
		return this.m_cw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(Button A_0)
	{
		EventHandler value = e;
		Button button = this.m_cw;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_cw = A_0;
		button = this.m_cw;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox c7()
	{
		return this.m_cx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(CheckBox A_0)
	{
		EventHandler value = c;
		CheckBox checkBox = this.m_cx;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_cx = A_0;
		checkBox = this.m_cx;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip c8()
	{
		return this.m_cy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ToolTip A_0)
	{
		this.m_cy = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel c9()
	{
		return this.m_cz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(TableLayoutPanel A_0)
	{
		this.m_cz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label da()
	{
		return this.m_c0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ag(Label A_0)
	{
		this.m_c0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button db()
	{
		return this.m_c1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(Button A_0)
	{
		EventHandler value = a;
		Button button = this.m_c1;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_c1 = A_0;
		button = this.m_c1;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button dc()
	{
		return this.m_c2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(Button A_0)
	{
		EventHandler value = b;
		Button button = this.m_c2;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_c2 = A_0;
		button = this.m_c2;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx dd()
	{
		return this.m_c3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hx A_0)
	{
		this.m_c3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer de()
	{
		return this.m_c7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = a;
		System.Timers.Timer timer = this.m_c7;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		this.m_c7 = A_0;
		timer = this.m_c7;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d df()
	{
		return this.m_dj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		r.d.b a_ = a;
		this.m_dj?.e(a_);
		this.m_dj = A_0;
		this.m_dj?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	public static void b(a A_0)
	{
		a a10 = dz;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Combine(a11, A_0);
			a10 = Interlocked.CompareExchange(ref dz, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public static void a(a A_0)
	{
		a a10 = dz;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Remove(a11, A_0);
			a10 = Interlocked.CompareExchange(ref dz, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public static void b(b A_0)
	{
		b b10 = d0;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Combine(b11, A_0);
			b10 = Interlocked.CompareExchange(ref d0, value, b11);
		}
		while ((object)b10 != b11);
	}

	[SpecialName]
	[CompilerGenerated]
	public static void a(b A_0)
	{
		b b10 = d0;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Remove(b11, A_0);
			b10 = Interlocked.CompareExchange(ref d0, value, b11);
		}
		while ((object)b10 != b11);
	}

	public void dg()
	{
		global::j.b(a);
	}

	public void dh()
	{
		global::j.a(a);
	}

	private void a(l A_0)
	{
		if (base.InvokeRequired)
		{
			c method = a;
			BeginInvoke(method, A_0);
			return;
		}
		try
		{
			this.m_c9 = A_0;
			c();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c8.c(fz.b.b, "Exception caught in DialogOptionSettings.AutoUpdateMenuItemEnableHandler", a_);
			ProjectData.ClearProjectError();
		}
	}

	public void a(fz A_0, f1 A_1, l A_2, Guid A_3, gg A_4, f4 A_5, IntPtr A_6, r.d A_7, bool A_8, f3 A_9, ref float A_10, ref bool A_11)
	{
		this.m_c8 = A_0;
		this.m_c9 = A_2;
		this.m_da = A_1;
		this.m_db = A_3;
		this.m_dd = A_6;
		this.m_de = A_7;
		dk = A_8;
		this.m_dg = A_4;
		this.m_dh = A_5;
		this.m_di = A_9;
		dv = this.m_da.sn();
		if (this.m_de != null)
		{
			this.m_de.d((r.d.b)c);
		}
		this.m_df.d((r.d.b)b);
		MySettings mySettings = global::e.a();
		r().Checked = mySettings.AutoAppendResults;
		q().Text = mySettings.AutoAppendResultsPath;
		o().Checked = mySettings.SaveOncePerSpectrum;
		n().Checked = mySettings.ConfirmBeforeSaving;
		x().Checked = mySettings.ConfirmBeforeClearingGraph;
		y().Checked = mySettings.ScreenShotIncludesMenuBar;
		au().Text = mySettings.ReferenceMinIntenWRTHist.ToString();
		ar().Text = mySettings.ReferenceMaxIntenWRTHist.ToString();
		bb().Checked = mySettings.ContMeasAddAllToHist;
		bc().Checked = mySettings.ContMeasPromptUserReAddToHistInclusion;
		be().Checked = mySettings.PrintActiveCurveOnly;
		if (this.m_da.uk())
		{
			dy = mySettings.CustomPrintedLogoFullPath;
			if (!string.IsNullOrEmpty(dy))
			{
				dd().Text = Path.GetFileName(dy);
			}
		}
		else
		{
			c9().Visible = false;
		}
		bf().Checked = mySettings.HistoryConfirmBeforeDelete;
		bu().Checked = mySettings.PromptForBaselineReminder;
		bt().Text = (mySettings.BaselineRemindTimeMinutes / 60f).ToString();
		c7().Checked = mySettings.ForceBaselineIfIntervalExceeded;
		bw().Checked = mySettings.PromptForDisconnectOK;
		bw().Visible = true;
		b4().Checked = mySettings.HistoryArchiveAutomatically;
		b7().Text = mySettings.HistoryAutoSavePath;
		cb().Text = mySettings.HistoryArchiveMaxDiskSpaceMB.ToString();
		cc().Checked = mySettings.HistoryArchiveClearAfterWrite;
		cg().Checked = mySettings.UniformSpectrumDataPointSpacing;
		ch().Checked = mySettings.UniformSpectrumDataFinePointSpacing;
		cj().Checked = mySettings.ShareSettingsWithSelectedUsers;
		ck().Checked = f1.fz.f();
		dw = f1.fz.g();
		ao().SetToolTip(cl(), "Location to store program settings shared by multiple users.\r\nCurrent Folder: " + f1.fz.g());
		co().Checked = global::e.a().AutoIncreaseGraphMaxCurves;
		dx = global::e.a().ConfirmBeforeAutoIncreaseGraphMaxCurves;
		d();
		cr().Checked = mySettings.ShowWarningSwitchingMeasureTabs;
		cs().Checked = mySettings.DetectGrayImageFromCamera;
		cx().Text = mySettings.CustomRecipePath;
		b();
		c3().Text = mySettings.CustomMaterialPath;
		a();
		mySettings = null;
		bs().Text = string.Format(bs().Text, 540f.ToString());
		string text = string.Empty;
		switch (dv)
		{
		case global::f.c.c:
		{
			string A_12 = "BaselineBackgroundReminder";
			text = hu.a(ref A_12);
			break;
		}
		case global::f.c.a:
		{
			string A_12 = "BaselineReminder";
			text = hu.a(ref A_12);
			break;
		}
		case global::f.c.b:
		{
			string A_12 = "BackgroundReminder";
			text = hu.a(ref A_12);
			break;
		}
		}
		bu().Text = text;
		if (this.m_da.ub())
		{
			g();
			c();
		}
		else
		{
			u().TabPages.Remove(z());
		}
		if (this.m_da.uc())
		{
			i7.e[] array = (i7.e[])Enum.GetValues(typeof(i7.e));
			foreach (i7.e e10 in array)
			{
				if (e10 != i7.e.z)
				{
					string a_ = global::a2.a.bg((int)e10);
					string a_2 = global::a2.a.br((int)e10);
					a(a_, a_2, e10, string.Empty);
					a(a_, a_2, e10, "_off");
				}
			}
		}
		else
		{
			u().TabPages.Remove(ay());
		}
		if (this.m_da.uj())
		{
			DateTime minValue = DateTime.MinValue;
			ref string a_3 = ref dp;
			string A_12 = null;
			global::c5.c(null, minValue, ref a_3, ref A_12);
			a5().Text = dp;
			MySettings mySettings2 = global::e.a();
			a7().Checked = !mySettings2.ReportDontPromptBeforeMarkOverwrite;
			a8().Checked = !mySettings2.ReportDontPromptBeforeClose;
			mySettings2 = null;
		}
		else
		{
			u().TabPages.Remove(a3());
		}
		aw().Items.Clear();
		if (this.m_dh != null)
		{
			aw().Items.Add("None");
			List<string> list = d4.a(this.m_c8);
			if (list.Count > 0)
			{
				foreach (string item in list)
				{
					aw().Items.Add(item);
				}
				gz gz2 = this.m_da.ti();
				foreach (gy item2 in gz2.i())
				{
					if (item2.y() == this.m_db)
					{
						this.m_dc = item2;
						break;
					}
				}
				if (this.m_dc != null && string.IsNullOrEmpty(this.m_dc.ah()))
				{
					aw().SelectedIndex = 1;
				}
				else
				{
					aw().SelectedItem = this.m_dc.ah();
				}
			}
			else
			{
				aw().SelectedIndex = 0;
			}
			dq = this.m_da.st();
			if (this.m_da.u7(this.m_db) && !this.m_dh.hq() && !this.m_da.u2())
			{
				b1().Enabled = this.m_da.wq(this.m_db).d0().m();
			}
			else
			{
				b1().Enabled = false;
			}
		}
		else
		{
			aw().Enabled = false;
			b1().Enabled = false;
		}
		b1().Checked = b1().Enabled && this.m_da.xa(this.m_db);
		dr = this.m_db != Guid.Empty && this.m_da.ti(this.m_db);
		if (dr)
		{
			cy().Visible = true;
			bq().Text = i6.a(this.m_da.t5(this.m_db), "0.0");
			ds = this.m_da.tj(this.m_db);
			if (ds)
			{
				c1().Enabled = true;
				global::ab.b(c1());
				ao().SetToolTip(c1(), string.Format(global::ab.l, "Light Source Standby"));
			}
			else
			{
				c1().Enabled = false;
			}
		}
		if (!dq)
		{
			u().TabPages.Remove(bg());
		}
		else
		{
			bk().Checked = global::e.a().WavelenCalEnable;
			switch ((g6.a)global::e.a().WavelenCalMode)
			{
			case g6.a.b:
				bl().Checked = true;
				break;
			case g6.a.a:
				bi().Checked = true;
				break;
			case g6.a.c:
				bj().Checked = true;
				break;
			}
			bo().Text = global::e.a().WavelenCalPeriodMinutes.ToString();
		}
		if (this.m_dg.eo() != null)
		{
			c7().Enabled = this.m_dg.eo().h() >= gq.a.c;
		}
		ShowDialog();
		A_10 = dt;
		A_11 = du;
	}

	private void z(object A_0, EventArgs A_1)
	{
		try
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "MeasResult Log Files (.csv)|*.csv";
			saveFileDialog.InitialDirectory = i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
			saveFileDialog.OverwritePrompt = false;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(saveFileDialog.FileName);
				q().Text = saveFileDialog.FileName;
			}
			saveFileDialog = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(p()), "DialogOptionSettings.ButtonBrowse_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void y(object A_0, EventArgs A_1)
	{
		bool flag = true;
		try
		{
			base.Enabled = false;
			if (this.m_dc != null)
			{
				string a_ = this.m_db.ToString();
				if (Operators.CompareString(this.m_dc.ah(), aw().Text, TextCompare: false) != 0)
				{
					bool num = this.m_da.t6(a_) != null;
					bool flag2 = Operators.CompareString(aw().Text, "None", TextCompare: false) != 0;
					if (num)
					{
						this.m_dh.h8()?.Close();
						this.m_da.p9(a_, flag2 ? null : this.m_df, global::r.d.a.b.a);
					}
					if (flag2)
					{
						a(new System.Timers.Timer(1500.0));
						de().AutoReset = false;
						de().Start();
						d1 = false;
						this.m_da.m2(a_, this.m_dd, this.m_de, global::r.d.a.b.a, aw().Text);
						flag = false;
						if (dk)
						{
							while (!d1 || this.m_da.va())
							{
								Thread.Sleep(100);
							}
							if (!this.m_da.u9())
							{
								bool A_2 = false;
								this.m_dg.b(this.m_dh, ref A_2);
								if (A_2)
								{
									this.m_dg.b(A_0: true, cr().Text);
								}
							}
							this.m_da.m2(a_, global::e.a().VideoShowSpot, null, global::r.d.a.b.a);
						}
					}
				}
			}
			if (flag && j())
			{
				dj();
				if (df() == null)
				{
					Close();
				}
			}
			else
			{
				base.Enabled = true;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(l()), "DialogOptionSettings.ButtonOK_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void x(object A_0, EventArgs A_1)
	{
		try
		{
			Close();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(m()), "DialogOptionSettings.ButtonCancel_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void w(object A_0, EventArgs A_1)
	{
		try
		{
			g();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(r()), "DialogOptionSettings.ChkBoxAutoSave_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private bool j()
	{
		float A_ = default(float);
		if (!a(ref A_))
		{
			fe.b(this.m_c8, "Invalid " + bs().Text, "Warning", i6.a(bd()));
			bt().Text = 540f.ToString();
			base.ActiveControl = bt();
			return false;
		}
		if (!float.TryParse(au().Text, out var result) || result > 100f)
		{
			fz a_ = this.m_c8;
			string A_2 = "InvalidValueFor1Between2And3Fmt3";
			fe.b(a_, string.Format(hu.a(ref A_2), "Reflectance Standard highest recorded intensity threshold", 0, 100f), "Warning", i6.a(bd()));
			au().Text = global::e.a().ReferenceMinIntenWRTHist.ToString();
			base.ActiveControl = au();
			return false;
		}
		if (!float.TryParse(ar().Text, out result) || result < 100f || result > 10000f)
		{
			fz a_2 = this.m_c8;
			string A_2 = "InvalidValueFor1Between2And3Fmt3";
			fe.b(a_2, string.Format(hu.a(ref A_2), "Reflectance Standard previous measurement threshold", 100f, 10000f), "Warning", i6.a(bd()));
			ar().Text = global::e.a().ReferenceMaxIntenWRTHist.ToString();
			base.ActiveControl = ar();
			return false;
		}
		global::e.a();
		if (r().Checked)
		{
			if (string.IsNullOrEmpty(q().Text))
			{
				fe.b(this.m_c8, "Please provide a valid path when Automatically appending results to file.", i6.a(r()));
				return false;
			}
			if (!i3.e(q().Text))
			{
				fe.b(this.m_c8, q().Text + " cannot be written. Please verify the path existence and that you have write permissions.", i6.a(r()));
				return false;
			}
		}
		if (b4().Checked)
		{
			if (string.IsNullOrEmpty(b7().Text))
			{
				fe.b(this.m_c8, "Please provide a valid path when Automatically archiving History data.", i6.a(b7()));
				base.ActiveControl = b7();
				return false;
			}
			if (!i3.e(b7().Text + "\\test.txt"))
			{
				fe.b(this.m_c8, b7().Text + "\\ cannot be written. Please verify the path existence and that you have write permissions.", i6.a(r()));
				return false;
			}
			int num = iz.c(cb().Text);
			double num2 = i3.a(b7().Text, A_1: false);
			if (num <= 5)
			{
				fe.b(this.m_c8, "Minimum Disk Space for Archive must be greater than " + Conversions.ToString(5) + ".", i6.a(r()));
				return false;
			}
			if (num2 > (double)num)
			{
				int num3 = checked((int)Math.Round(num2 - (double)num));
				if (!fe.b(ref this.m_c8, Conversions.ToString(num3) + " MB will be deleted from the disk.\r\n\r\nAre you sure you want to delete Archived History Data?", "Warning", "Yes", "No", i6.a(cb())))
				{
					cb().Text = global::e.a().HistoryArchiveMaxDiskSpaceMB.ToString();
					base.ActiveControl = cb();
					return false;
				}
				f3.a(b7().Text, num);
			}
		}
		bool num4 = ck().Checked || cj().Checked;
		bool flag = f1.fz.f() || global::e.a().ShareSettingsWithSelectedUsers;
		if (num4 && ((!flag && f1.fz.i()) || f1.fz.c(dw)) && !fe.b(ref this.m_c8, "Software must be restarted in order to update from global settings. If you continue, you will lose any unsaved work.", "Warning", "OKString", "CancelString", i6.a(this)))
		{
			return false;
		}
		_ = null;
		return true;
	}

	private bool a(ref float A_0)
	{
		float num = iz.d(bt().Text);
		if (num > 540f)
		{
			return false;
		}
		A_0 = num * 60f;
		return true;
	}

	private void a(string A_0, string A_1, i7.e A_2, string A_3)
	{
		bool flag = string.IsNullOrEmpty(A_3);
		if (!Directory.Exists(A_0))
		{
			return;
		}
		ReadOnlyCollection<string> files = global::c.e().FileSystem.GetFiles(A_0, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, A_1 + A_3 + global::a2.a.b1(), A_1 + "_?" + A_3 + global::a2.a.b1());
		ReadOnlyCollection<string> readOnlyCollection = ((A_2 != i7.e.a6) ? global::c.e().FileSystem.GetFiles(A_0, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, A_1 + "_????????????????????????????????" + A_3 + global::a2.a.b1()) : global::c.e().FileSystem.GetFiles(A_0, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, A_1 + "_*" + A_3 + global::a2.a.b1()));
		Guid A_5 = default(Guid);
		foreach (string item in readOnlyCollection)
		{
			if (Path.GetFileNameWithoutExtension(item).Substring(A_1.Length).Length >= "_????????????????????????????????".Length || A_2 == i7.e.a6)
			{
				string A_4 = Path.GetFileNameWithoutExtension(item);
				string a_ = checked((A_2 != i7.e.a6) ? A_4.Substring(A_1.Length + 1, "_????????????????????????????????".Length - 1) : A_4.Substring(A_1.Length + 1, A_4.Length - (A_3.Length + A_1.Length + 1)));
				if (this.m_da.m2(a_, ref A_5) && !a(flag, A_2, ref A_4))
				{
					dm.Add(A_2);
					@do.Add(A_4);
					dn.Add(flag);
					a0().Items.Add(A_1 + " for " + this.m_da.uu(A_5) + " S/N=" + ((ce)this.m_da).p9(A_5, 0, 0), flag);
				}
			}
		}
		foreach (string item2 in files)
		{
			string A_4 = Path.GetFileNameWithoutExtension(item2);
			if (!a(flag, A_2, ref A_4))
			{
				dm.Add(A_2);
				@do.Add(A_4);
				dn.Add(flag);
				a0().Items.Add(A_4, flag);
			}
		}
	}

	private bool a(bool A_0, i7.e A_1, ref string A_2)
	{
		checked
		{
			if (!A_0)
			{
				string text = A_2.Substring(0, A_2.Length - "_off".Length);
				int num = dm.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (dm[num2] == A_1 && dn[num2] && string.Compare(@do[num2], text, ignoreCase: true) == 0)
					{
						return true;
					}
				}
				A_2 = text;
			}
			return false;
		}
	}

	private void i()
	{
		bool enabled = b4().Checked;
		cb().Enabled = enabled;
		b7().Enabled = enabled;
		b8().Enabled = enabled;
	}

	private void h()
	{
		bool enabled = cg().Checked;
		ci().Enabled = enabled;
		ch().Enabled = enabled;
	}

	private void g()
	{
		bool enabled = r().Checked;
		o().Enabled = enabled;
		n().Enabled = enabled;
		q().Enabled = enabled;
		p().Enabled = enabled;
	}

	private void f()
	{
		cl().Enabled = ck().Checked || cj().Checked;
	}

	private void e()
	{
		if (this.m_c9.o())
		{
			am().Text = "Info Comm. Failure";
			return;
		}
		if (this.m_c9.p())
		{
			am().Text = "File Comm. Failure";
			return;
		}
		switch (this.m_c9.l())
		{
		case global::l.a.a:
			am().Text = "Initializing...";
			break;
		case global::l.a.b:
			am().Text = "Downloading Info...";
			break;
		case global::l.a.d:
			am().Text = "New Info Downloaded";
			break;
		case global::l.a.e:
			am().Text = "Downloading...";
			break;
		case global::l.a.i:
			am().Text = "Next check at " + this.m_c9.m().TimeOfDay.ToString().Substring(0, 8);
			break;
		case global::l.a.h:
			am().Text = "Extracting...";
			break;
		case global::l.a.c:
			am().Text = "Info Comm. Failure";
			break;
		case global::l.a.f:
			am().Text = "File Comm. Failure";
			break;
		case global::l.a.g:
			am().Text = "FI Int. User Fail";
			break;
		default:
			am().Text = "No update available";
			break;
		}
	}

	private void d()
	{
		if (co().Checked)
		{
			cp().Checked = dx;
		}
		else
		{
			cp().Checked = false;
		}
	}

	private void c()
	{
		Version version = Assembly.GetExecutingAssembly().GetName().Version;
		ai().Text = version.ToString();
		ah().Text = global::e.a().AutoUpdateReminderPeriod.ToString();
		if (this.m_c9 == null)
		{
			al().Text = "";
			am().Text = "Unknown";
			aj().Text = "";
			an().Text = "Update thread not running\r\nSee log file for error information";
			ad().Enabled = false;
			return;
		}
		aj().Text = this.m_c9.n();
		Version version2 = new Version(this.m_c9.i());
		if (Operators.CompareString(this.m_c9.i(), "0.0.0.0", TextCompare: false) == 0)
		{
			al().Text = ai().Text;
		}
		else
		{
			al().Text = this.m_c9.i();
		}
		if (this.m_c9.j().StartsWith("{\\rtf"))
		{
			an().Rtf = this.m_c9.j();
		}
		else
		{
			an().Text = this.m_c9.j();
		}
		if (version2 > version && this.m_c9.k())
		{
			am().Text = "Ready to install";
		}
		else
		{
			e();
		}
		ad().Enabled = this.m_c9.k();
	}

	private void v(object A_0, EventArgs A_1)
	{
		global::j.a();
	}

	private void a(object A_0, MouseEventArgs A_1)
	{
		try
		{
			new dy().a(this.m_c9.j(), "Software Update Release Notes", A_2: true);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(an()), "DialogOptionSettings.RichTextBoxNotes_MouseDoubleClick", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void u(object A_0, EventArgs A_1)
	{
		try
		{
			bool flag = default(bool);
			foreach (object checkedIndex in a0().CheckedIndices)
			{
				int index = Conversions.ToInteger(checkedIndex);
				if (dm[index] == i7.e.g)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				fe.b(this.m_c8, "Existence of an enabled Internal License automatically results in creation of a ConfigLicenses license.\r\nIn order to delete your ConfigLicenses license you will need to disable your Internal license.", i6.a(a1()));
			}
			else
			{
				if (!fe.b(ref this.m_c8, "Deleting the ConfigLicenses license will cause the Licenses tab to become hidden.\r\nYou will need to re-import an Internal license or ConfigLicenses license in order to cause this tab to reappear.\r\n\r\nAre you sure you want to delete your ConfigLicenses license?", "Warning", "Yes", "No", i6.a(a1())))
				{
					return;
				}
				string text = global::a2.a.br(26);
				ReadOnlyCollection<string> files = global::c.e().FileSystem.GetFiles(global::a2.a.bg(26), Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, text + global::a2.a.b1(), text + "_?" + global::a2.a.b1());
				{
					foreach (string item in files)
					{
						File.Delete(item);
					}
					return;
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(a1()), "DialogOptionSettings.ButtonDeleteConfigLicensesLicense_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	public void b(r.d.a A_0)
	{
		if (base.InvokeRequired)
		{
			BeginInvoke(new r.d.b(b), A_0);
		}
		else
		{
			this.m_da.p9(global::r.d.a.b.a);
		}
	}

	public void c(r.d.a A_0)
	{
		try
		{
			de().Stop();
			if (base.InvokeRequired)
			{
				this.m_da.p9(global::r.d.a.b.a);
				d1 = true;
				BeginInvoke(new r.d.b(c), A_0);
			}
			else if (A_0 != null && A_0.a == global::r.d.a.a.b)
			{
				if (!string.IsNullOrEmpty(A_0.b))
				{
					fe.b(this.m_c8, "Error attempting to reinitialize camera:\n" + A_0.b, i6.a(this));
				}
				else
				{
					fe.b(this.m_c8, "Error attempting to reinitialize camera", i6.a(this));
				}
				base.Enabled = true;
			}
			else
			{
				dj();
				Close();
				de().Close();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c8.c(fz.b.b, "Error in DialogOptionSettings.AllocateCameraTaskCompletionHandler.", a_);
			ProjectData.ClearProjectError();
		}
	}

	public void di()
	{
		dt = this.m_da.p9();
		this.m_da.m2(global::r.d.a.b.a);
	}

	public void dj()
	{
		MySettings mySettings = global::e.a();
		mySettings.AutoAppendResults = r().Checked;
		mySettings.AutoAppendResultsPath = q().Text;
		mySettings.SaveOncePerSpectrum = o().Checked;
		mySettings.ConfirmBeforeSaving = n().Checked;
		mySettings.ConfirmBeforeClearingGraph = x().Checked;
		mySettings.PrintActiveCurveOnly = be().Checked;
		if (this.m_da.uk())
		{
			mySettings.CustomPrintedLogoFullPath = dy;
		}
		mySettings.ScreenShotIncludesMenuBar = y().Checked;
		mySettings.AutoUpdateReminderPeriod = iz.e(ah().Text);
		mySettings.ReferenceMinIntenWRTHist = iz.d(au().Text);
		mySettings.ReferenceMaxIntenWRTHist = iz.d(ar().Text);
		if (this.m_da.uj())
		{
			if (Operators.CompareString(dp, a5().Text, TextCompare: false) != 0)
			{
				mySettings.ReportOutputPath = a5().Text;
			}
			mySettings.ReportDontPromptBeforeMarkOverwrite = !a7().Checked;
			mySettings.ReportDontPromptBeforeClose = !a8().Checked;
		}
		mySettings.ContMeasAddAllToHist = bb().Checked;
		mySettings.ContMeasPromptUserReAddToHistInclusion = bc().Checked;
		if (bf().Checked != mySettings.HistoryConfirmBeforeDelete)
		{
			mySettings.HistoryConfirmBeforeDelete = bf().Checked;
			dz?.Invoke();
		}
		float A_ = default(float);
		if (a(ref A_) && (bu().Checked != mySettings.PromptForBaselineReminder || mySettings.BaselineRemindTimeMinutes != A_ || c7().Checked != mySettings.ForceBaselineIfIntervalExceeded))
		{
			mySettings.BaselineRemindTimeMinutes = A_;
			mySettings.ForceBaselineIfIntervalExceeded = c7().Checked;
			mySettings.PromptForBaselineReminder = bu().Checked;
			d0?.Invoke();
		}
		mySettings.PromptForDisconnectOK = bw().Checked;
		mySettings.HistoryArchiveMaxDiskSpaceMB = iz.c(cb().Text);
		mySettings.HistoryArchiveAutomatically = b4().Checked;
		mySettings.HistoryAutoSavePath = b7().Text;
		mySettings.HistoryArchiveClearAfterWrite = cc().Checked;
		mySettings.UniformSpectrumDataPointSpacing = cg().Checked;
		mySettings.UniformSpectrumDataFinePointSpacing = ch().Checked;
		mySettings.AutoIncreaseGraphMaxCurves = co().Checked;
		mySettings.ConfirmBeforeAutoIncreaseGraphMaxCurves = dx;
		mySettings.ShowWarningSwitchingMeasureTabs = cr().Checked;
		mySettings.DetectGrayImageFromCamera = cs().Checked;
		mySettings.CustomRecipePath = cx().Text;
		hg.bw(cx().Text);
		mySettings.CustomMaterialPath = c3().Text;
		jb.w(c3().Text);
		mySettings = null;
		int num = checked(dm.Count - 1);
		bool flag2 = default(bool);
		Guid A_2 = default(Guid);
		for (int num2 = 0; num2 <= num; num2 = checked(num2 + 1))
		{
			bool flag = a0().CheckedIndices.Contains(num2);
			if (dn[num2] == flag)
			{
				continue;
			}
			if (!du)
			{
				if (i7.d(dm[num2]))
				{
					du = true;
					flag2 = false;
				}
				else
				{
					flag2 = flag2 || i7.c(dm[num2]);
				}
			}
			i7.e e10 = dm[num2];
			string text = @do[num2];
			string text2;
			string text3;
			if (flag)
			{
				text2 = global::a2.a.bg((int)e10) + text + "_off" + global::a2.a.b1();
				text3 = text + global::a2.a.b1();
			}
			else
			{
				text2 = global::a2.a.bg((int)e10) + text + global::a2.a.b1();
				text3 = text + "_off" + global::a2.a.b1();
				if (e10 == i7.e.y)
				{
					string text4 = global::a2.a.br(25);
					string a_ = checked(Path.GetFileName(text2).Substring(text4.Length + 1, "_????????????????????????????????".Length - 1));
					this.m_da.m2(a_, ref A_2);
					this.m_da.ut(A_2);
				}
			}
			string path = Path.GetDirectoryName(text2) + "\\" + text3;
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			global::c.e().FileSystem.RenameFile(text2, text3);
		}
		bool A_4 = default(bool);
		bool flag3 = default(bool);
		if (ck().Checked || cj().Checked)
		{
			if (Operators.CompareString(dw, f1.fz.g(), TextCompare: false) != 0)
			{
				bool A_3 = default(bool);
				f1.fz.c(dw, ref A_3, ref A_4);
				du = du || A_3;
				flag3 = A_3;
			}
			if (!flag3 && !global::e.a().ShareSettingsWithSelectedUsers && !f1.fz.f())
			{
				flag3 = f1.fz.i();
				du = du || flag3;
			}
		}
		f1.fz.c(ck().Checked, ref A_4);
		if (cj().Checked && !global::e.a().ShareSettingsWithSelectedUsers)
		{
			f1.fz.d(ref A_4);
		}
		global::e.a().ShareSettingsWithSelectedUsers = cj().Checked;
		if (flag3)
		{
			global::e.a().Reload();
		}
		if (A_4)
		{
			global::e.a().Upgraded = false;
			du = true;
		}
		if (!du && !flag2 && this.m_da.uc() != global::a2.a.e(i7.e.z))
		{
			flag2 = true;
		}
		if (dq)
		{
			global::e.a().WavelenCalEnable = bk().Checked;
			if (bl().Checked)
			{
				global::e.a().WavelenCalMode = 1;
			}
			else if (bi().Checked)
			{
				global::e.a().WavelenCalMode = 0;
			}
			else if (bj().Checked)
			{
				global::e.a().WavelenCalMode = 2;
			}
			global::e.a().WavelenCalPeriodMinutes = iz.d(bo().Text);
			g6 a_2 = new g6();
			foreach (Guid item in this.m_da.tj())
			{
				if (g6.e(this.m_da.t9(item), a_2))
				{
					this.m_da.m2(item, a_2, global::r.d.a.b.a);
				}
			}
		}
		if (dr)
		{
			if (ds)
			{
				global::ab.a(c1());
			}
			a(new r.d());
			this.m_da.m2(this.m_db, iz.d(bq().Text), A_2: false, df(), global::r.d.a.b.a);
		}
		if (this.m_dh != null)
		{
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			if (b1().Checked && !this.m_da.xa(this.m_db))
			{
				flag4 = true;
				flag5 = true;
			}
			else if (!b1().Checked && this.m_da.xa(this.m_db))
			{
				flag4 = false;
				flag5 = true;
			}
			if (flag5)
			{
				if (flag4 && !this.m_da.wq(this.m_db).c9())
				{
					ref fz a_3 = ref this.m_c8;
					string A_5 = "RecipeUnsavedPromptFmt3";
					if (!fe.b(ref a_3, string.Format(hu.a(ref A_5), Strings.LCase("Recipe"), "\r\n", "Recipe".ToLower()), "RecipeLoadTitle", "OKString", "CancelString", new Point(base.Width / 2, base.Height / 2)))
					{
						goto IL_086c;
					}
				}
				if (flag4)
				{
					this.m_da.p9(this.m_db, global::r.d.a.b.a);
				}
				else
				{
					this.m_da.xb(this.m_db);
				}
				Rectangle clientRectangle = this.m_dh.ClientRectangle;
				this.m_dh.i(clientRectangle.Width, clientRectangle.Height);
				this.m_dh.u(flag4);
			}
		}
		goto IL_086c;
		IL_086c:
		if (flag2)
		{
			if (df() == null)
			{
				di();
			}
			else
			{
				dl = true;
			}
		}
	}

	private void t(object A_0, EventArgs A_1)
	{
		try
		{
			ay ay2 = new ay();
			ay2.g(i3.d(global::e.a().ReportOutputPath));
			ay2.h("Set Measurement Report Folder");
			if (ay2.g(this) == DialogResult.OK)
			{
				a5().Text = ay2.f();
				ay2 = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(a4()), "DialogOptionSettings.ButtonInternalBrowse_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void s(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_di.a(i6.a(b3(), 0, 0));
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(a4()), "DialogOptionSettings.ButtonEditHistoryColumns_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void r(object A_0, EventArgs A_1)
	{
		try
		{
			bn obj = new bn();
			obj.Text = "Revert Settings";
			obj.a("This option may be used if you have encountered an error.\r\nIf an error happens repeatedly, you may wish to consider\r\nreverting the settings.", A_1: false);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(bd()), "DialogOptionSettings.ButtonInternalBrowse_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, ElapsedEventArgs A_1)
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new d(a), A_0, A_1);
			}
			else
			{
				dj();
				Close();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c8.c(fz.b.b, "Error in DialogOptionSettings.mCloseTimer_Elapsed", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void q(object A_0, EventArgs A_1)
	{
		try
		{
			bo().Enabled = bi().Checked;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(bi()), "DialogOptionSettings.RadioButtonWavelenCalPeriodic_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void p(object A_0, EventArgs A_1)
	{
		try
		{
			bm().Enabled = bk().Checked;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(bk()), "DialogOptionSettings.CheckBoxWavelenCalEnable_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new r.d.b(a), A_0);
				return;
			}
			if (A_0 != null && A_0.a == global::r.d.a.a.b)
			{
				if (!string.IsNullOrEmpty(A_0.b))
				{
					fe.b(this.m_c8, A_0.b, i6.a(this));
				}
				else
				{
					fe.b(this.m_c8, "Error attempting to set lightsource level in DialogOptionSettings.mLightSourceCompletionTask_TaskFinishedEvent", i6.a(this));
				}
				return;
			}
			Close();
			if (dl)
			{
				di();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c8.c(fz.b.b, "Error in DialogOptionSettings.mLightSourceCompletionTask_TaskFinishedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		try
		{
			ay obj = new ay();
			string empty = string.Empty;
			empty = "\\FIHistoryMeas";
			ay ay2 = obj;
			if (string.IsNullOrEmpty(global::e.a().HistoryAutoSavePath))
			{
				ay2.g(i3.d(i3.b() + empty));
			}
			else
			{
				ay2.g(i3.d(global::e.a().HistoryAutoSavePath));
			}
			ay2.h("Set History Automatic Archive Folder");
			if (ay2.g(this) == DialogResult.OK)
			{
				b7().Text = ay2.f();
				ay2 = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(a4()), "DialogOptionSettings.ButtonGetHistoryArchivePath_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void n(object A_0, EventArgs A_1)
	{
		try
		{
			i();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(b4()), "DialogOptionSettings.CheckBoxAutoArchiveHistory_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void m(object A_0, EventArgs A_1)
	{
		try
		{
			h();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(cg()), "DialogOptionSettings.CheckBoxUSDPS_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		try
		{
			if (ck().Checked)
			{
				cj().Checked = false;
			}
			else
			{
				cj().Checked = global::e.a().ShareSettingsWithSelectedUsers;
			}
			cj().Enabled = !ck().Checked;
			f();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c8.c(fz.b.b, "Error in DialogOptionSettings.CheckBoxShareSettingsWithAllUsers_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		try
		{
			ay ay2 = new ay();
			ay2.g(dw);
			if (ay2.g(this) == DialogResult.OK)
			{
				dw = ay2.f();
				ay2 = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(cl()), "DialogOptionSettings.ButtonSharedSettingsFolderBrowse_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		try
		{
			f();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c8.c(fz.b.b, "Error in DialogOptionSettings.CheckBoxShareSettingsWithSelectedUsers_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		try
		{
			cp().Enabled = co().Checked;
			d();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c8.c(fz.b.b, "Error in DialogOptionSettings.CheckBoxAutoIncreaseMaxNumDisplayedCurves_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		try
		{
			if (co().Checked)
			{
				dx = cp().Checked;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_c8.c(fz.b.b, "Error in DialogOptionSettings.CheckBoxConfirmBeforeAutoIncreaseGraphMaxCurves_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(TextBox A_0, string A_1)
	{
		string text = A_0.Text;
		if (string.IsNullOrEmpty(text) || !Directory.Exists(text))
		{
			text = A_1;
		}
		ay ay2 = new ay();
		ay2.g(text);
		if (ay2.g(this) == DialogResult.OK)
		{
			A_0.Text = ay2.f();
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		try
		{
			a(cx(), hg.bv((string)null));
			b();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(cl()), "DialogOptionSettings.ButtonCustomRecipePathBrowse_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
		{
			cx().Text = null;
			b();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(cl()), "DialogOptionSettings.ButtonCustomRecipePathReset_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b()
	{
		ao().SetToolTip(cx(), "Current Recipes path is:\r\n" + hg.bv(cx().Text));
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			a(c3(), jb.v(null));
			a();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(cl()), "DialogOptionSettings.ButtonCustomMaterialPathBrowse_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			c3().Text = null;
			a();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(cl()), "DialogOptionSettings.ButtonCustomMaterialPathReset_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			if (c7().Checked)
			{
				bu().Checked = true;
				bu().Enabled = false;
			}
			else
			{
				bu().Enabled = true;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(c7()), "DialogOptionSettings.CheckBoxForceBaselineIfIntervalExceeded_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a()
	{
		ao().SetToolTip(c3(), "Current Material path is:\r\n" + jb.v(c3().Text));
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = false;
			openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
			if (!string.IsNullOrEmpty(dy))
			{
				string directoryName = Path.GetDirectoryName(dy);
				openFileDialog.InitialDirectory = directoryName;
			}
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				dy = openFileDialog.FileName;
				dd().Text = Path.GetFileName(openFileDialog.FileName);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(dc()), "DialogOptionSettings.ButtonSelectCustomPrintedLogo_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			dy = null;
			dd().Text = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_c8, this.m_da, null, i6.a(db()), "DialogOptionSettings.ButtonClearCustomPrintedLogo_Click", a_);
			ProjectData.ClearProjectError();
		}
	}
}
