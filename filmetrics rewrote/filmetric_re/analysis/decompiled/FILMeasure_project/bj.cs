using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Filmetrics.My;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class bj : fj
{
	private new IContainer a;

	[CompilerGenerated]
	private new TableLayoutPanel m_b;

	[CompilerGenerated]
	private new Button m_c;

	[CompilerGenerated]
	private new Label m_d;

	[CompilerGenerated]
	private new TextBox m_e;

	[CompilerGenerated]
	private new TextBox m_f;

	[CompilerGenerated]
	private new Label m_g;

	[CompilerGenerated]
	private new Label m_h;

	[CompilerGenerated]
	private Label m_i;

	[CompilerGenerated]
	private TextBox m_j;

	[CompilerGenerated]
	private TextBox m_k;

	[CompilerGenerated]
	private Label m_l;

	[CompilerGenerated]
	private TextBox m;

	[CompilerGenerated]
	private Label n;

	[CompilerGenerated]
	private Label m_o;

	[CompilerGenerated]
	private Label m_p;

	[CompilerGenerated]
	private Label m_q;

	[CompilerGenerated]
	private TextBox m_r;

	[CompilerGenerated]
	private TableLayoutPanel m_s;

	[CompilerGenerated]
	private TableLayoutPanel m_t;

	[CompilerGenerated]
	private Label m_u;

	[CompilerGenerated]
	private Label m_v;

	[CompilerGenerated]
	private Label w;

	[CompilerGenerated]
	private ComboBox m_x;

	[CompilerGenerated]
	private Button m_y;

	[CompilerGenerated]
	private Label m_z;

	[CompilerGenerated]
	private Label m_aa;

	[CompilerGenerated]
	private Label m_ab;

	[CompilerGenerated]
	private Button m_ac;

	[CompilerGenerated]
	private TextBox m_ad;

	[CompilerGenerated]
	private Button m_ae;

	[CompilerGenerated]
	private TableLayoutPanel m_ag;

	[CompilerGenerated]
	private Label m_ah;

	[CompilerGenerated]
	private ComboBox m_ai;

	[CompilerGenerated]
	private ComboBox m_aj;

	[CompilerGenerated]
	private Label m_ak;

	[CompilerGenerated]
	private GroupBox m_al;

	[CompilerGenerated]
	private TextBox m_am;

	[CompilerGenerated]
	private Label m_an;

	[CompilerGenerated]
	private Label m_ao;

	[CompilerGenerated]
	private Label m_ap;

	[CompilerGenerated]
	private Label m_aq;

	[CompilerGenerated]
	private Label m_ar;

	[CompilerGenerated]
	private TableLayoutPanel m_as;

	[CompilerGenerated]
	private TableLayoutPanel m_at;

	[CompilerGenerated]
	private TextBox m_au;

	[CompilerGenerated]
	private TextBox m_av;

	[CompilerGenerated]
	private TextBox m_aw;

	[CompilerGenerated]
	private TextBox m_ax;

	[CompilerGenerated]
	private TextBox m_ay;

	[CompilerGenerated]
	private TextBox m_az;

	[CompilerGenerated]
	private TextBox m_a0;

	[CompilerGenerated]
	private TextBox m_a1;

	[CompilerGenerated]
	private TextBox m_a2;

	[CompilerGenerated]
	private TableLayoutPanel m_a3;

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
	private TextBox m_bf;

	[CompilerGenerated]
	private TextBox m_bg;

	[CompilerGenerated]
	private TextBox m_bh;

	[CompilerGenerated]
	private TextBox m_bi;

	[CompilerGenerated]
	private TextBox m_bj;

	[CompilerGenerated]
	private TextBox m_bk;

	[CompilerGenerated]
	private TextBox m_bl;

	[CompilerGenerated]
	private TextBox m_bm;

	[CompilerGenerated]
	private TextBox m_bn;

	[CompilerGenerated]
	private TextBox m_bo;

	[CompilerGenerated]
	private TextBox m_bp;

	[CompilerGenerated]
	private TextBox m_bq;

	[CompilerGenerated]
	private TextBox m_br;

	[CompilerGenerated]
	private TextBox m_bs;

	[CompilerGenerated]
	private TextBox m_bt;

	[CompilerGenerated]
	private TextBox m_bu;

	[CompilerGenerated]
	private TextBox m_bv;

	[CompilerGenerated]
	private TextBox m_bw;

	[CompilerGenerated]
	private TextBox m_bx;

	[CompilerGenerated]
	private TextBox m_by;

	[CompilerGenerated]
	private TextBox m_bz;

	[CompilerGenerated]
	private TextBox m_b0;

	[CompilerGenerated]
	private TextBox m_b1;

	[CompilerGenerated]
	private TextBox m_b2;

	[CompilerGenerated]
	private TextBox m_b3;

	[CompilerGenerated]
	private GroupBox m_b4;

	[CompilerGenerated]
	private TableLayoutPanel m_b5;

	[CompilerGenerated]
	private GroupBox m_b6;

	[CompilerGenerated]
	private GroupBox m_b7;

	[CompilerGenerated]
	private GroupBox m_b8;

	[CompilerGenerated]
	private GroupBox m_b9;

	[CompilerGenerated]
	private GroupBox m_ca;

	[CompilerGenerated]
	private Label m_cb;

	[CompilerGenerated]
	private Label m_cc;

	[CompilerGenerated]
	private ComboBox m_cd;

	[CompilerGenerated]
	private Label m_ce;

	[CompilerGenerated]
	private Button m_cf;

	[CompilerGenerated]
	private TextBox m_cg;

	[CompilerGenerated]
	private Label m_ch;

	[CompilerGenerated]
	private ToolTip m_ci;

	[CompilerGenerated]
	private CheckBox m_cj;

	private const string m_ck = "0170";

	private const string m_cl = "0232";

	private const string m_cm = "0370";

	private const string m_cn = "0300";

	private const string m_co = "0232";

	private const string m_cp = "0170";

	private const string m_cq = "0170";

	private const string m_cr = "0170";

	private const string m_cs = "0245";

	private const string m_ct = "0170";

	private const string m_cu = "0170";

	private const string m_cv = "0170";

	private const string m_cw = "0170";

	private const string m_cx = "0170";

	private const string m_cy = "0170";

	private const string m_cz = "0170";

	private const string m_c0 = "0170";

	private const string m_c1 = "0170";

	private const string m_c2 = "0170";

	public new const string c3 = "\\\\dc\\Engineering\\Shipping_Records\\";

	private new const string c4 = "\\\\dc\\Engineering\\Shipping_Records\\SW Certification\\QC Wafer Recipes\\";

	private new const string c5 = "\\\\dc\\Engineering\\Non-Vaulted Items\\060\\060-0006.xlsx";

	private new const string c6 = "QC Std Set #";

	private const int c7 = 3;

	private const int c8 = 4;

	private const int c9 = 5;

	private const int da = 6;

	private const int db = 7;

	private const int dc = 8;

	private const int dd = 9;

	private const int de = 10;

	private const int df = 11;

	private const int dg = 12;

	private const int dh = 13;

	private const int di = 14;

	private const int dj = 15;

	private const int dk = 16;

	private const int dl = 17;

	private const int dm = 18;

	private const int dn = 19;

	private const int @do = 20;

	private const int dp = 21;

	private const string dq = "\\\\dc\\Engineering\\Non-Vaulted Items\\060\\060-0094.xlsx";

	private const int dr = 1;

	private const int ds = 2;

	private const int dt = 3;

	private const int du = 4;

	private const int dv = 5;

	private const int dw = 6;

	private const int dx = 7;

	private const int dy = 8;

	private const int dz = 9;

	private const int d0 = 10;

	private const int d1 = 11;

	private const int d2 = 12;

	private const int d3 = 13;

	private const int d4 = 14;

	private const int d5 = 15;

	private const int d6 = 5;

	private const string d7 = "DialogQualityAssurance";

	private const int d8 = 10;

	private const string d9 = "QC";

	private const string ea = "Thickness Standard";

	private bool eb;

	private bool ec;

	private gg ed;

	private f1 ee;

	private f4 ef;

	private hs eg;

	private hs.a eh;

	private string ei;

	private Guid ej;

	private gr ek;

	private hg el;

	private r.d em;

	[CompilerGenerated]
	private r.d en;

	private string eo;

	private string ep;

	private string eq;

	private a9[] er;

	private bl es;

	private Collection<bk> et;

	private bk eu;

	private Collection<ip.d>[] ev;

	private Collection<ip.e>[] ew;

	private Collection<h6.c>[] ex;

	private Collection<h6.d>[] ey;

	private int ez;

	private bool e0;

	private bool e1;

	private Collection<float> e2;

	private Collection<string> e3;

	private bool e4;

	private int e5;

	private Collection<hc> e6;

	private r.d e7;

	private string e8;

	private string e9;

	private int fa;

	private bool fb;

	private string fc;

	private string fd;

	private string fe;

	private string ff;

	private string fg;

	private bool fh;

	private Microsoft.Office.Interop.Excel.Application fi;

	private bool fj;

	private string fk;

	private int fl;

	private byte fm;

	private bool fn;

	private short fo;

	[SpecialName]
	private string fp;

	[SpecialName]
	private string fq;

	[SpecialName]
	private string fr;

	[SpecialName]
	private string fs;

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && a != null)
			{
				a.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void r()
	{
		a = new Container();
		b(new TableLayoutPanel());
		au(new TextBox());
		ao(new Label());
		e(new ComboBox());
		an(new Label());
		r(new TextBox());
		q(new TextBox());
		q(new Label());
		s(new TextBox());
		r(new Label());
		p(new Label());
		k(new Label());
		o(new Label());
		l(new Label());
		t(new TextBox());
		b(new ComboBox());
		al(new Label());
		h(new TextBox());
		c(new Button());
		b(new Button());
		b(new Label());
		b(new TextBox());
		c(new TextBox());
		c(new Label());
		d(new Label());
		e(new Label());
		d(new TextBox());
		e(new TextBox());
		f(new Label());
		f(new TextBox());
		g(new Label());
		h(new Label());
		i(new Label());
		j(new Label());
		g(new TextBox());
		c(new TableLayoutPanel());
		d(new TableLayoutPanel());
		b(new CheckBox());
		e(new Button());
		d(new Button());
		e(new TableLayoutPanel());
		s(new Label());
		c(new ComboBox());
		d(new ComboBox());
		t(new Label());
		b(new GroupBox());
		i(new TextBox());
		u(new Label());
		v(new Label());
		x(new Label());
		y(new Label());
		z(new Label());
		f(new TableLayoutPanel());
		j(new TextBox());
		k(new TextBox());
		l(new TextBox());
		o(new TextBox());
		p(new TextBox());
		g(new TableLayoutPanel());
		f(new Button());
		h(new TableLayoutPanel());
		am(new Label());
		aa(new Label());
		ab(new Label());
		ac(new Label());
		ad(new Label());
		ae(new Label());
		af(new Label());
		ag(new Label());
		ah(new Label());
		ai(new Label());
		aj(new Label());
		ak(new Label());
		u(new TextBox());
		v(new TextBox());
		x(new TextBox());
		y(new TextBox());
		z(new TextBox());
		aa(new TextBox());
		ab(new TextBox());
		ac(new TextBox());
		ad(new TextBox());
		ae(new TextBox());
		af(new TextBox());
		ag(new TextBox());
		ah(new TextBox());
		ai(new TextBox());
		aj(new TextBox());
		ak(new TextBox());
		al(new TextBox());
		am(new TextBox());
		an(new TextBox());
		ao(new TextBox());
		ap(new TextBox());
		aq(new TextBox());
		ar(new TextBox());
		@as(new TextBox());
		at(new TextBox());
		c(new GroupBox());
		e(new GroupBox());
		f(new GroupBox());
		d(new GroupBox());
		i(new TableLayoutPanel());
		g(new GroupBox());
		h(new GroupBox());
		b(new ToolTip(a));
		s().SuspendLayout();
		al().SuspendLayout();
		am().SuspendLayout();
		a3().SuspendLayout();
		ba().SuspendLayout();
		bb().SuspendLayout();
		bl().SuspendLayout();
		cm().SuspendLayout();
		cp().SuspendLayout();
		cq().SuspendLayout();
		co().SuspendLayout();
		cn().SuspendLayout();
		cr().SuspendLayout();
		cs().SuspendLayout();
		SuspendLayout();
		s().AutoSize = true;
		s().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		s().ColumnCount = 2;
		s().ColumnStyles.Add(new ColumnStyle());
		s().ColumnStyles.Add(new ColumnStyle());
		s().Controls.Add(cy(), 1, 7);
		s().Controls.Add(cz(), 0, 7);
		s().Controls.Add(cv(), 1, 0);
		s().Controls.Add(cw(), 0, 0);
		s().Controls.Add(bi(), 1, 6);
		s().Controls.Add(bh(), 1, 4);
		s().Controls.Add(at(), 0, 6);
		s().Controls.Add(bj(), 1, 5);
		s().Controls.Add(au(), 0, 5);
		s().Controls.Add(@as(), 1, 2);
		s().Controls.Add(an(), 0, 4);
		s().Controls.Add(ap(), 0, 2);
		s().Controls.Add(ao(), 0, 3);
		s().Controls.Add(bk(), 1, 3);
		s().Controls.Add(aq(), 1, 1);
		s().Controls.Add(ct(), 0, 1);
		s().Controls.Add(aw(), 0, 8);
		s().Location = new Point(7, 21);
		s().Name = "TableLayoutPanelWafer";
		s().RowCount = 9;
		s().RowStyles.Add(new RowStyle());
		s().RowStyles.Add(new RowStyle());
		s().RowStyles.Add(new RowStyle());
		s().RowStyles.Add(new RowStyle());
		s().RowStyles.Add(new RowStyle());
		s().RowStyles.Add(new RowStyle());
		s().RowStyles.Add(new RowStyle());
		s().RowStyles.Add(new RowStyle());
		s().RowStyles.Add(new RowStyle());
		s().Size = new Size(342, 272);
		s().TabIndex = 0;
		cy().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		cy().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cy().Location = new Point(139, 193);
		cy().Name = "TextBoxReflectanceStd";
		cy().ReadOnly = true;
		cy().Size = new Size(200, 22);
		cy().TabIndex = 74;
		cy().TextAlign = HorizontalAlignment.Right;
		cz().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		cz().AutoSize = true;
		cz().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		cz().Location = new Point(3, 190);
		cz().Name = "LabelReflectanceStd";
		cz().Size = new Size(103, 28);
		cz().TabIndex = 74;
		cz().Text = "Reflectance Std";
		cz().TextAlign = ContentAlignment.MiddleLeft;
		cv().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		cv().DropDownStyle = ComboBoxStyle.DropDownList;
		cv().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cv().FormattingEnabled = true;
		cv().Location = new Point(139, 3);
		cv().Name = "ComboBoxType";
		cv().Size = new Size(200, 24);
		cv().TabIndex = 74;
		cw().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		cw().AutoSize = true;
		cw().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cw().Location = new Point(3, 0);
		cw().Name = "LabelStdType";
		cw().Size = new Size(40, 30);
		cw().TabIndex = 74;
		cw().Text = "Type";
		cw().TextAlign = ContentAlignment.MiddleLeft;
		bi().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bi().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bi().Location = new Point(139, 165);
		bi().Name = "TextBoxToleranceMax";
		bi().ReadOnly = true;
		bi().Size = new Size(200, 22);
		bi().TabIndex = 12;
		bi().TextAlign = HorizontalAlignment.Right;
		bh().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bh().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bh().Location = new Point(139, 109);
		bh().Name = "TextBoxTolerance";
		bh().ReadOnly = true;
		bh().Size = new Size(200, 22);
		bh().TabIndex = 10;
		bh().TextAlign = HorizontalAlignment.Right;
		at().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		at().AutoSize = true;
		at().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		at().Location = new Point(3, 162);
		at().Name = "LabelToleranceMaxLabel";
		at().Size = new Size(98, 28);
		at().TabIndex = 40;
		at().Text = "Max Tolerance";
		at().TextAlign = ContentAlignment.MiddleLeft;
		bj().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bj().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bj().Location = new Point(139, 137);
		bj().Name = "TextBoxToleranceMin";
		bj().ReadOnly = true;
		bj().Size = new Size(200, 22);
		bj().TabIndex = 11;
		bj().TextAlign = HorizontalAlignment.Right;
		au().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		au().AutoSize = true;
		au().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		au().Location = new Point(3, 134);
		au().Name = "LabelToleranceMinLabel";
		au().Size = new Size(94, 28);
		au().TabIndex = 39;
		au().Text = "Min Tolerance";
		au().TextAlign = ContentAlignment.MiddleLeft;
		@as().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		@as().AutoSize = true;
		@as().BackColor = SystemColors.Control;
		@as().BorderStyle = BorderStyle.Fixed3D;
		@as().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		@as().Location = new Point(139, 60);
		@as().Name = "LabelRecipe";
		@as().Size = new Size(200, 18);
		@as().TabIndex = 35;
		@as().Text = "Si Thickness Standard";
		@as().TextAlign = ContentAlignment.MiddleRight;
		an().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		an().AutoSize = true;
		an().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		an().Location = new Point(3, 106);
		an().Name = "LabelToleranceLabel";
		an().Size = new Size(130, 28);
		an().TabIndex = 33;
		an().Text = "Customer Tolerance";
		an().TextAlign = ContentAlignment.MiddleLeft;
		ap().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		ap().AutoSize = true;
		ap().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		ap().Location = new Point(3, 60);
		ap().Name = "LabelRecipeName";
		ap().Size = new Size(52, 18);
		ap().TabIndex = 31;
		ap().Text = "Recipe";
		ap().TextAlign = ContentAlignment.MiddleLeft;
		ao().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		ao().AutoSize = true;
		ao().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		ao().Location = new Point(3, 78);
		ao().Name = "LabelTargetThicknessLabel";
		ao().Size = new Size(113, 28);
		ao().TabIndex = 32;
		ao().Text = "Target Thickness";
		ao().TextAlign = ContentAlignment.MiddleLeft;
		bk().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bk().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bk().Location = new Point(139, 81);
		bk().Name = "TextBoxTargetThickness";
		bk().ReadOnly = true;
		bk().Size = new Size(200, 22);
		bk().TabIndex = 9;
		bk().TextAlign = HorizontalAlignment.Right;
		aq().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		aq().DropDownStyle = ComboBoxStyle.DropDownList;
		aq().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aq().FormattingEnabled = true;
		aq().Location = new Point(139, 33);
		aq().Name = "ComboBoxStandard";
		aq().Size = new Size(200, 24);
		aq().TabIndex = 8;
		ct().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		ct().AutoSize = true;
		ct().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ct().Location = new Point(3, 30);
		ct().Name = "LabelStandard";
		ct().Size = new Size(45, 30);
		ct().TabIndex = 73;
		ct().Text = "Name";
		ct().TextAlign = ContentAlignment.MiddleLeft;
		aw().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		s().SetColumnSpan(aw(), 2);
		aw().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		aw().Location = new Point(3, 221);
		aw().Multiline = true;
		aw().Name = "TextBoxNotes";
		aw().ReadOnly = true;
		aw().Size = new Size(336, 48);
		aw().TabIndex = 13;
		aw().Text = "*Notes: ";
		ar().Anchor = AnchorStyles.None;
		ar().Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		ar().Location = new Point(94, 3);
		ar().Name = "ButtonMeasure10Times";
		ar().Size = new Size(160, 31);
		ar().TabIndex = 21;
		ar().Text = "Measure 10 times";
		ar().UseVisualStyleBackColor = true;
		t().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		t().Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		t().Location = new Point(520, 3);
		t().Name = "ButtonGetSRPath";
		t().Size = new Size(109, 35);
		t().TabIndex = 1;
		t().Text = "Browse...";
		t().UseVisualStyleBackColor = true;
		u().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		u().AutoSize = true;
		u().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		u().ImageAlign = ContentAlignment.MiddleRight;
		u().Location = new Point(3, 158);
		u().Name = "LabelSystemSN";
		u().Size = new Size(79, 28);
		u().TabIndex = 2;
		u().Text = "System S/N";
		u().TextAlign = ContentAlignment.MiddleLeft;
		v().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		v().Location = new Point(118, 161);
		v().Name = "TextBoxSerialNumber";
		v().ReadOnly = true;
		v().Size = new Size(150, 22);
		v().TabIndex = 7;
		v().TextAlign = HorizontalAlignment.Right;
		x().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x().Location = new Point(118, 133);
		x().Name = "TextBoxSystem";
		x().ReadOnly = true;
		x().Size = new Size(150, 22);
		x().TabIndex = 6;
		x().TextAlign = HorizontalAlignment.Right;
		y().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		y().AutoSize = true;
		y().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		y().ImageAlign = ContentAlignment.MiddleRight;
		y().Location = new Point(3, 130);
		y().Name = "LabelSystem";
		y().Size = new Size(53, 28);
		y().TabIndex = 6;
		y().Text = "System";
		y().TextAlign = ContentAlignment.MiddleLeft;
		z().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		z().BackColor = SystemColors.Control;
		z().BorderStyle = BorderStyle.Fixed3D;
		z().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		z().ImageAlign = ContentAlignment.MiddleRight;
		z().Location = new Point(3, 0);
		z().Name = "LabelShippingRecordPath";
		z().Size = new Size(511, 41);
		z().TabIndex = 13;
		z().TextAlign = ContentAlignment.MiddleLeft;
		aa().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		aa().AutoSize = true;
		aa().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		aa().Location = new Point(3, 0);
		aa().Name = "LabelCustomerName";
		aa().Size = new Size(65, 28);
		aa().TabIndex = 14;
		aa().Text = "Customer";
		aa().TextAlign = ContentAlignment.MiddleLeft;
		ab().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ab().Location = new Point(118, 3);
		ab().Name = "TextBoxCustomer";
		ab().Size = new Size(150, 22);
		ab().TabIndex = 2;
		ab().TextAlign = HorizontalAlignment.Right;
		ac().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ac().Location = new Point(118, 31);
		ac().Name = "TextBoxCustomerPO";
		ac().Size = new Size(150, 22);
		ac().TabIndex = 3;
		ac().TextAlign = HorizontalAlignment.Right;
		ad().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		ad().AutoSize = true;
		ad().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		ad().Location = new Point(3, 28);
		ad().Name = "LabelCustomerPO";
		ad().Size = new Size(94, 28);
		ad().TabIndex = 16;
		ad().Text = "Customer PO#";
		ad().TextAlign = ContentAlignment.MiddleLeft;
		ae().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae().Location = new Point(118, 59);
		ae().Name = "TextBoxSO";
		ae().Size = new Size(150, 22);
		ae().TabIndex = 4;
		ae().TextAlign = HorizontalAlignment.Right;
		ag().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		ag().AutoSize = true;
		ag().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		ag().Location = new Point(3, 56);
		ag().Name = "LabelSO";
		ag().Size = new Size(37, 28);
		ag().TabIndex = 18;
		ag().Text = "SO #";
		ag().TextAlign = ContentAlignment.MiddleLeft;
		ah().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		ah().AutoSize = true;
		ah().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		ah().Location = new Point(3, 84);
		ah().Name = "LabelSWVersionLabel";
		ah().Size = new Size(109, 18);
		ah().TabIndex = 20;
		ah().Text = "Software Version";
		ah().TextAlign = ContentAlignment.MiddleLeft;
		ai().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		ai().AutoSize = true;
		ai().BorderStyle = BorderStyle.Fixed3D;
		ai().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		ai().Location = new Point(118, 84);
		ai().Name = "LabelSWVersion";
		ai().Size = new Size(150, 18);
		ai().TabIndex = 21;
		ai().Text = "7.3.4.0";
		ai().TextAlign = ContentAlignment.MiddleRight;
		aj().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		aj().AutoSize = true;
		aj().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		aj().Location = new Point(3, 102);
		aj().Name = "LabelTechician";
		aj().Size = new Size(96, 28);
		aj().TabIndex = 22;
		aj().Text = "QC Technician";
		aj().TextAlign = ContentAlignment.MiddleLeft;
		ak().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ak().Location = new Point(118, 105);
		ak().Name = "TextBoxTechnician";
		ak().Size = new Size(150, 22);
		ak().TabIndex = 5;
		ak().TextAlign = HorizontalAlignment.Right;
		al().AutoSize = true;
		al().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		al().ColumnCount = 2;
		al().ColumnStyles.Add(new ColumnStyle());
		al().ColumnStyles.Add(new ColumnStyle());
		al().Controls.Add(v(), 1, 6);
		al().Controls.Add(x(), 1, 5);
		al().Controls.Add(y(), 0, 5);
		al().Controls.Add(aa(), 0, 0);
		al().Controls.Add(u(), 0, 6);
		al().Controls.Add(ak(), 1, 4);
		al().Controls.Add(ad(), 0, 1);
		al().Controls.Add(ai(), 1, 3);
		al().Controls.Add(aj(), 0, 4);
		al().Controls.Add(ae(), 1, 2);
		al().Controls.Add(ag(), 0, 2);
		al().Controls.Add(ac(), 1, 1);
		al().Controls.Add(ah(), 0, 3);
		al().Controls.Add(ab(), 1, 0);
		al().Location = new Point(6, 30);
		al().Name = "TableLayoutPanelCustomerInfo";
		al().RowCount = 7;
		al().RowStyles.Add(new RowStyle());
		al().RowStyles.Add(new RowStyle());
		al().RowStyles.Add(new RowStyle());
		al().RowStyles.Add(new RowStyle());
		al().RowStyles.Add(new RowStyle());
		al().RowStyles.Add(new RowStyle());
		al().RowStyles.Add(new RowStyle());
		al().Size = new Size(271, 186);
		al().TabIndex = 24;
		am().AutoSize = true;
		am().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		am().ColumnCount = 2;
		am().ColumnStyles.Add(new ColumnStyle());
		am().ColumnStyles.Add(new ColumnStyle());
		am().Controls.Add(z(), 0, 0);
		am().Controls.Add(t(), 1, 0);
		am().Controls.Add(c1(), 0, 1);
		am().Location = new Point(6, 28);
		am().Name = "TableLayoutPanelSRPath";
		am().RowCount = 2;
		am().RowStyles.Add(new RowStyle());
		am().RowStyles.Add(new RowStyle());
		am().Size = new Size(632, 67);
		am().TabIndex = 26;
		c1().AutoSize = true;
		c1().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c1().Location = new Point(3, 44);
		c1().Name = "CheckBoxPreferMSPrintToPDF";
		c1().Size = new Size(193, 20);
		c1().TabIndex = 14;
		c1().Text = "Prefer Microsoft Print to PDF";
		c1().UseVisualStyleBackColor = true;
		ax().Anchor = AnchorStyles.None;
		cn().SetColumnSpan(ax(), 2);
		ax().Enabled = false;
		ax().Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		ax().Location = new Point(177, 862);
		ax().Name = "ButtonUpdateShippingRecord";
		ax().Size = new Size(295, 35);
		ax().TabIndex = 48;
		ax().Text = "Update Shipping Records and Close";
		ax().UseVisualStyleBackColor = true;
		av().Anchor = AnchorStyles.None;
		av().Enabled = false;
		av().Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		av().Location = new Point(94, 164);
		av().Name = "ButtonAcceptMeasurement";
		av().Size = new Size(160, 31);
		av().TabIndex = 22;
		av().Text = "Accept";
		av().UseVisualStyleBackColor = true;
		ay().Anchor = AnchorStyles.None;
		ay().AutoSize = true;
		ay().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ay().ColumnCount = 2;
		ay().ColumnStyles.Add(new ColumnStyle());
		ay().ColumnStyles.Add(new ColumnStyle());
		ay().Location = new Point(185, 83);
		ay().Name = "TLPSubsystemSelect";
		ay().RowCount = 1;
		ay().RowStyles.Add(new RowStyle());
		ay().Size = new Size(0, 0);
		ay().TabIndex = 32;
		ay().Visible = false;
		az().Anchor = AnchorStyles.Left | AnchorStyles.Right;
		az().AutoSize = true;
		az().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		az().Location = new Point(4, 7);
		az().Margin = new Padding(4, 0, 4, 0);
		az().Name = "Label9";
		az().Size = new Size(89, 16);
		az().TabIndex = 28;
		az().Text = "Subsystem";
		az().TextAlign = ContentAlignment.MiddleLeft;
		a0().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		a0().DropDownStyle = ComboBoxStyle.DropDownList;
		a0().DropDownWidth = 200;
		a0().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a0().FormattingEnabled = true;
		a0().Location = new Point(100, 3);
		a0().Name = "ComboBoxSubModule";
		a0().Size = new Size(174, 24);
		a0().TabIndex = 14;
		a1().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		a1().DropDownStyle = ComboBoxStyle.DropDownList;
		a1().DropDownWidth = 200;
		a1().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a1().FormattingEnabled = true;
		a1().Location = new Point(100, 33);
		a1().Name = "ComboBoxSpectrometer";
		a1().Size = new Size(174, 24);
		a1().TabIndex = 15;
		a2().Anchor = AnchorStyles.Left | AnchorStyles.Right;
		a2().AutoSize = true;
		a2().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a2().Location = new Point(4, 37);
		a2().Margin = new Padding(4, 0, 4, 0);
		a2().Name = "Label28";
		a2().Size = new Size(89, 16);
		a2().TabIndex = 33;
		a2().Text = "Spectrometer";
		a2().TextAlign = ContentAlignment.MiddleLeft;
		a3().Anchor = AnchorStyles.None;
		a3().Controls.Add(a4());
		a3().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		a3().Location = new Point(45, 77);
		a3().Name = "GroupMeasurementResult";
		a3().Size = new Size(258, 79);
		a3().TabIndex = 55;
		a3().TabStop = false;
		a4().Anchor = AnchorStyles.None;
		a4().BackColor = SystemColors.ButtonFace;
		a4().BorderStyle = BorderStyle.None;
		a4().Cursor = Cursors.Default;
		a4().Font = new System.Drawing.Font("Microsoft Sans Serif", 32f, FontStyle.Bold);
		a4().Location = new Point(7, 19);
		a4().Name = "TextBoxMeasThickness";
		a4().ReadOnly = true;
		a4().Size = new Size(245, 49);
		a4().TabIndex = 36;
		a4().TabStop = false;
		a4().TextAlign = HorizontalAlignment.Center;
		a5().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		a5().AutoSize = true;
		a5().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		a5().Location = new Point(3, 60);
		a5().Name = "Label4";
		a5().Size = new Size(91, 28);
		a5().TabIndex = 56;
		a5().Text = "Begin λ";
		a5().TextAlign = ContentAlignment.MiddleLeft;
		a6().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		a6().AutoSize = true;
		a6().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		a6().ImageAlign = ContentAlignment.MiddleRight;
		a6().Location = new Point(3, 88);
		a6().Name = "Label5";
		a6().Size = new Size(91, 28);
		a6().TabIndex = 57;
		a6().Text = "End λ";
		a6().TextAlign = ContentAlignment.MiddleLeft;
		a7().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		a7().AutoSize = true;
		a7().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		a7().ImageAlign = ContentAlignment.MiddleRight;
		a7().Location = new Point(3, 116);
		a7().Name = "Label6";
		a7().Size = new Size(91, 28);
		a7().TabIndex = 58;
		a7().Text = "Spec Dark";
		a7().TextAlign = ContentAlignment.MiddleLeft;
		a8().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		a8().AutoSize = true;
		a8().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		a8().ImageAlign = ContentAlignment.MiddleRight;
		a8().Location = new Point(3, 144);
		a8().Name = "Label7";
		a8().Size = new Size(91, 28);
		a8().TabIndex = 59;
		a8().Text = "Spec Peak";
		a8().TextAlign = ContentAlignment.MiddleLeft;
		a9().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		a9().AutoSize = true;
		a9().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		a9().ImageAlign = ContentAlignment.MiddleRight;
		a9().Location = new Point(3, 172);
		a9().Name = "LabelSpecIntTimeLabel";
		a9().Size = new Size(91, 28);
		a9().TabIndex = 60;
		a9().Text = "Int. Time";
		a9().TextAlign = ContentAlignment.MiddleLeft;
		ba().AutoSize = true;
		ba().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ba().ColumnCount = 2;
		ba().ColumnStyles.Add(new ColumnStyle());
		ba().ColumnStyles.Add(new ColumnStyle());
		ba().Controls.Add(a1(), 1, 1);
		ba().Controls.Add(a2(), 0, 1);
		ba().Controls.Add(a0(), 1, 0);
		ba().Controls.Add(az(), 0, 0);
		ba().Controls.Add(bc(), 1, 6);
		ba().Controls.Add(bd(), 1, 5);
		ba().Controls.Add(be(), 1, 4);
		ba().Controls.Add(bf(), 1, 3);
		ba().Controls.Add(bg(), 1, 2);
		ba().Controls.Add(a9(), 0, 6);
		ba().Controls.Add(a8(), 0, 5);
		ba().Controls.Add(a7(), 0, 4);
		ba().Controls.Add(a6(), 0, 3);
		ba().Controls.Add(a5(), 0, 2);
		ba().Dock = DockStyle.Fill;
		ba().Location = new Point(3, 18);
		ba().Name = "TableLayoutPanelSpectrometer";
		ba().RowCount = 7;
		ba().RowStyles.Add(new RowStyle());
		ba().RowStyles.Add(new RowStyle());
		ba().RowStyles.Add(new RowStyle());
		ba().RowStyles.Add(new RowStyle());
		ba().RowStyles.Add(new RowStyle());
		ba().RowStyles.Add(new RowStyle());
		ba().RowStyles.Add(new RowStyle());
		ba().Size = new Size(277, 200);
		ba().TabIndex = 67;
		bc().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bc().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bc().Location = new Point(100, 175);
		bc().Name = "TextBoxSpecIntTime";
		bc().ReadOnly = true;
		bc().Size = new Size(174, 22);
		bc().TabIndex = 20;
		bc().TextAlign = HorizontalAlignment.Right;
		bd().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bd().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bd().Location = new Point(100, 147);
		bd().Name = "TextBoxPeak";
		bd().ReadOnly = true;
		bd().Size = new Size(174, 22);
		bd().TabIndex = 19;
		bd().TextAlign = HorizontalAlignment.Right;
		be().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		be().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		be().Location = new Point(100, 119);
		be().Name = "TextBoxDark";
		be().ReadOnly = true;
		be().Size = new Size(174, 22);
		be().TabIndex = 18;
		be().TextAlign = HorizontalAlignment.Right;
		bf().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bf().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bf().Location = new Point(100, 91);
		bf().Name = "TextBoxEndWave";
		bf().ReadOnly = true;
		bf().Size = new Size(174, 22);
		bf().TabIndex = 17;
		bf().TextAlign = HorizontalAlignment.Right;
		bg().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bg().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bg().Location = new Point(100, 63);
		bg().Name = "TextBoxBeginWave";
		bg().ReadOnly = true;
		bg().Size = new Size(174, 22);
		bg().TabIndex = 16;
		bg().TextAlign = HorizontalAlignment.Right;
		bb().AutoSize = true;
		bb().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		bb().ColumnCount = 1;
		bb().ColumnStyles.Add(new ColumnStyle());
		bb().Controls.Add(cx(), 0, 1);
		bb().Controls.Add(ar(), 0, 0);
		bb().Controls.Add(av(), 0, 3);
		bb().Controls.Add(a3(), 0, 2);
		bb().Dock = DockStyle.Fill;
		bb().Location = new Point(3, 18);
		bb().Name = "TableLayoutPanelMeasure";
		bb().RowCount = 4;
		bb().RowStyles.Add(new RowStyle());
		bb().RowStyles.Add(new RowStyle());
		bb().RowStyles.Add(new RowStyle());
		bb().RowStyles.Add(new RowStyle());
		bb().Size = new Size(349, 200);
		bb().TabIndex = 68;
		cx().Anchor = AnchorStyles.None;
		cx().Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		cx().Location = new Point(94, 40);
		cx().Name = "ButtonBaseline";
		cx().Size = new Size(160, 31);
		cx().TabIndex = 56;
		cx().Text = "Baseline...";
		cx().UseVisualStyleBackColor = true;
		bl().AutoSize = true;
		bl().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		bl().ColumnCount = 6;
		bl().ColumnStyles.Add(new ColumnStyle());
		bl().ColumnStyles.Add(new ColumnStyle());
		bl().ColumnStyles.Add(new ColumnStyle());
		bl().ColumnStyles.Add(new ColumnStyle());
		bl().ColumnStyles.Add(new ColumnStyle());
		bl().ColumnStyles.Add(new ColumnStyle());
		bl().Controls.Add(cu(), 1, 0);
		bl().Controls.Add(bm(), 0, 6);
		bl().Controls.Add(bn(), 0, 4);
		bl().Controls.Add(bo(), 0, 3);
		bl().Controls.Add(bp(), 0, 1);
		bl().Controls.Add(bq(), 0, 2);
		bl().Controls.Add(br(), 0, 5);
		bl().Controls.Add(bs(), 1, 1);
		bl().Controls.Add(bt(), 2, 1);
		bl().Controls.Add(bu(), 3, 1);
		bl().Controls.Add(bv(), 4, 1);
		bl().Controls.Add(bw(), 5, 1);
		bl().Controls.Add(bx(), 1, 2);
		bl().Controls.Add(by(), 2, 2);
		bl().Controls.Add(bz(), 3, 2);
		bl().Controls.Add(b0(), 4, 2);
		bl().Controls.Add(b1(), 5, 2);
		bl().Controls.Add(b2(), 1, 3);
		bl().Controls.Add(b3(), 2, 3);
		bl().Controls.Add(b4(), 3, 3);
		bl().Controls.Add(b5(), 4, 3);
		bl().Controls.Add(b6(), 5, 3);
		bl().Controls.Add(b7(), 1, 4);
		bl().Controls.Add(b8(), 2, 4);
		bl().Controls.Add(b9(), 3, 4);
		bl().Controls.Add(ca(), 4, 4);
		bl().Controls.Add(cb(), 5, 4);
		bl().Controls.Add(cc(), 1, 5);
		bl().Controls.Add(cd(), 2, 5);
		bl().Controls.Add(ce(), 3, 5);
		bl().Controls.Add(cf(), 4, 5);
		bl().Controls.Add(cg(), 5, 5);
		bl().Controls.Add(ch(), 1, 6);
		bl().Controls.Add(ci(), 2, 6);
		bl().Controls.Add(cj(), 3, 6);
		bl().Controls.Add(ck(), 4, 6);
		bl().Controls.Add(cl(), 5, 6);
		bl().Dock = DockStyle.Fill;
		bl().Location = new Point(3, 18);
		bl().Name = "TableLayoutPanelResults";
		bl().RowCount = 7;
		bl().RowStyles.Add(new RowStyle());
		bl().RowStyles.Add(new RowStyle());
		bl().RowStyles.Add(new RowStyle());
		bl().RowStyles.Add(new RowStyle());
		bl().RowStyles.Add(new RowStyle());
		bl().RowStyles.Add(new RowStyle());
		bl().RowStyles.Add(new RowStyle());
		bl().Size = new Size(638, 172);
		bl().TabIndex = 28;
		cu().Anchor = AnchorStyles.None;
		cu().AutoSize = true;
		bl().SetColumnSpan(cu(), 5);
		cu().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		cu().ImageAlign = ContentAlignment.MiddleRight;
		cu().Location = new Point(297, 0);
		cu().Name = "LabelStandardHeading";
		cu().Size = new Size(103, 16);
		cu().TabIndex = 74;
		cu().Text = "Standard Name";
		cu().TextAlign = ContentAlignment.MiddleCenter;
		cu().Visible = false;
		bm().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bm().AutoSize = true;
		bm().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		bm().Location = new Point(3, 144);
		bm().Name = "LabelResultsSpec5";
		bm().Size = new Size(53, 28);
		bm().TabIndex = 69;
		bm().Text = "5";
		bm().TextAlign = ContentAlignment.MiddleCenter;
		bm().Visible = false;
		bn().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bn().AutoSize = true;
		bn().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		bn().Location = new Point(3, 88);
		bn().Name = "LabelResultsSpec3";
		bn().Size = new Size(53, 28);
		bn().TabIndex = 75;
		bn().Text = "3";
		bn().TextAlign = ContentAlignment.MiddleCenter;
		bn().Visible = false;
		bo().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bo().AutoSize = true;
		bo().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		bo().Location = new Point(3, 60);
		bo().Name = "LabelResultsSpec2";
		bo().Size = new Size(53, 28);
		bo().TabIndex = 25;
		bo().Text = "2";
		bo().TextAlign = ContentAlignment.MiddleCenter;
		bo().Visible = false;
		bp().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bp().AutoSize = true;
		bp().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		bp().Location = new Point(3, 16);
		bp().Name = "Label25";
		bp().Size = new Size(53, 16);
		bp().TabIndex = 24;
		bp().Text = "SpecID";
		bp().TextAlign = ContentAlignment.MiddleCenter;
		bq().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bq().AutoSize = true;
		bq().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		bq().Location = new Point(3, 32);
		bq().Name = "LabelResultsSpec1";
		bq().Size = new Size(53, 28);
		bq().TabIndex = 24;
		bq().Text = "1";
		bq().TextAlign = ContentAlignment.MiddleCenter;
		br().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		br().AutoSize = true;
		br().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		br().Location = new Point(3, 116);
		br().Name = "LabelResultsSpec4";
		br().Size = new Size(53, 28);
		br().TabIndex = 76;
		br().Text = "4";
		br().TextAlign = ContentAlignment.MiddleCenter;
		br().Visible = false;
		bs().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bs().AutoSize = true;
		bs().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		bs().ImageAlign = ContentAlignment.MiddleRight;
		bs().Location = new Point(62, 16);
		bs().Name = "LabelStandard1Label";
		bs().Size = new Size(98, 16);
		bs().TabIndex = 29;
		bs().Text = "Unmeasured";
		bs().TextAlign = ContentAlignment.MiddleCenter;
		bs().Visible = false;
		bt().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bt().AutoSize = true;
		bt().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		bt().ImageAlign = ContentAlignment.MiddleRight;
		bt().Location = new Point(166, 16);
		bt().Name = "LabelStandard2Label";
		bt().Size = new Size(98, 16);
		bt().TabIndex = 30;
		bt().Text = "Unmeasured";
		bt().TextAlign = ContentAlignment.MiddleCenter;
		bt().Visible = false;
		bu().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bu().AutoSize = true;
		bu().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		bu().ImageAlign = ContentAlignment.MiddleRight;
		bu().Location = new Point(270, 16);
		bu().Name = "LabelStandard3Label";
		bu().Size = new Size(98, 16);
		bu().TabIndex = 31;
		bu().Text = "Unmeasured";
		bu().TextAlign = ContentAlignment.MiddleCenter;
		bu().Visible = false;
		bv().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bv().AutoSize = true;
		bv().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		bv().ImageAlign = ContentAlignment.MiddleRight;
		bv().Location = new Point(374, 16);
		bv().Name = "LabelStandard4Label";
		bv().Size = new Size(98, 16);
		bv().TabIndex = 33;
		bv().Text = "Unmeasured";
		bv().TextAlign = ContentAlignment.MiddleCenter;
		bv().Visible = false;
		bw().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bw().AutoSize = true;
		bw().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		bw().ImageAlign = ContentAlignment.MiddleRight;
		bw().Location = new Point(478, 16);
		bw().Name = "LabelStandard5Label";
		bw().Size = new Size(157, 16);
		bw().TabIndex = 32;
		bw().Text = "Unmeasured";
		bw().TextAlign = ContentAlignment.MiddleCenter;
		bw().Visible = false;
		bx().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bx().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		bx().Location = new Point(62, 35);
		bx().Name = "TextBoxStandard1ResultSpec1";
		bx().ReadOnly = true;
		bx().Size = new Size(98, 22);
		bx().TabIndex = 23;
		bx().TextAlign = HorizontalAlignment.Center;
		bx().Visible = false;
		by().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		by().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		by().Location = new Point(166, 35);
		by().Name = "TextBoxStandard2ResultSpec1";
		by().ReadOnly = true;
		by().Size = new Size(98, 22);
		by().TabIndex = 24;
		by().TextAlign = HorizontalAlignment.Center;
		by().Visible = false;
		bz().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bz().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		bz().Location = new Point(270, 35);
		bz().Name = "TextBoxStandard3ResultSpec1";
		bz().ReadOnly = true;
		bz().Size = new Size(98, 22);
		bz().TabIndex = 25;
		bz().TextAlign = HorizontalAlignment.Center;
		bz().Visible = false;
		b0().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		b0().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		b0().Location = new Point(374, 35);
		b0().Name = "TextBoxStandard4ResultSpec1";
		b0().ReadOnly = true;
		b0().Size = new Size(98, 22);
		b0().TabIndex = 26;
		b0().TextAlign = HorizontalAlignment.Center;
		b0().Visible = false;
		b1().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		b1().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		b1().Location = new Point(478, 35);
		b1().Name = "TextBoxStandard5ResultSpec1";
		b1().ReadOnly = true;
		b1().Size = new Size(157, 22);
		b1().TabIndex = 27;
		b1().TextAlign = HorizontalAlignment.Center;
		b1().Visible = false;
		b2().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		b2().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		b2().Location = new Point(62, 63);
		b2().Name = "TextBoxStandard1ResultSpec2";
		b2().ReadOnly = true;
		b2().Size = new Size(98, 22);
		b2().TabIndex = 28;
		b2().TextAlign = HorizontalAlignment.Center;
		b2().Visible = false;
		b3().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		b3().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		b3().Location = new Point(166, 63);
		b3().Name = "TextBoxStandard2ResultSpec2";
		b3().ReadOnly = true;
		b3().Size = new Size(98, 22);
		b3().TabIndex = 29;
		b3().TextAlign = HorizontalAlignment.Center;
		b3().Visible = false;
		b4().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		b4().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		b4().Location = new Point(270, 63);
		b4().Name = "TextBoxStandard3ResultSpec2";
		b4().ReadOnly = true;
		b4().Size = new Size(98, 22);
		b4().TabIndex = 30;
		b4().TextAlign = HorizontalAlignment.Center;
		b4().Visible = false;
		b5().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		b5().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		b5().Location = new Point(374, 63);
		b5().Name = "TextBoxStandard4ResultSpec2";
		b5().ReadOnly = true;
		b5().Size = new Size(98, 22);
		b5().TabIndex = 31;
		b5().TextAlign = HorizontalAlignment.Center;
		b5().Visible = false;
		b6().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		b6().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		b6().Location = new Point(478, 63);
		b6().Name = "TextBoxStandard5ResultSpec2";
		b6().ReadOnly = true;
		b6().Size = new Size(157, 22);
		b6().TabIndex = 32;
		b6().TextAlign = HorizontalAlignment.Center;
		b6().Visible = false;
		b7().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		b7().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		b7().Location = new Point(62, 91);
		b7().Name = "TextBoxStandard1ResultSpec3";
		b7().ReadOnly = true;
		b7().Size = new Size(98, 22);
		b7().TabIndex = 33;
		b7().TextAlign = HorizontalAlignment.Center;
		b7().Visible = false;
		b8().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		b8().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		b8().Location = new Point(166, 91);
		b8().Name = "TextBoxStandard2ResultSpec3";
		b8().ReadOnly = true;
		b8().Size = new Size(98, 22);
		b8().TabIndex = 34;
		b8().TextAlign = HorizontalAlignment.Center;
		b8().Visible = false;
		b9().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		b9().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		b9().Location = new Point(270, 91);
		b9().Name = "TextBoxStandard3ResultSpec3";
		b9().ReadOnly = true;
		b9().Size = new Size(98, 22);
		b9().TabIndex = 35;
		b9().TextAlign = HorizontalAlignment.Center;
		b9().Visible = false;
		ca().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		ca().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		ca().Location = new Point(374, 91);
		ca().Name = "TextBoxStandard4ResultSpec3";
		ca().ReadOnly = true;
		ca().Size = new Size(98, 22);
		ca().TabIndex = 36;
		ca().TextAlign = HorizontalAlignment.Center;
		ca().Visible = false;
		cb().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		cb().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		cb().Location = new Point(478, 91);
		cb().Name = "TextBoxStandard5ResultSpec3";
		cb().ReadOnly = true;
		cb().Size = new Size(157, 22);
		cb().TabIndex = 37;
		cb().TextAlign = HorizontalAlignment.Center;
		cb().Visible = false;
		cc().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		cc().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		cc().Location = new Point(62, 119);
		cc().Name = "TextBoxStandard1ResultSpec4";
		cc().ReadOnly = true;
		cc().Size = new Size(98, 22);
		cc().TabIndex = 38;
		cc().TextAlign = HorizontalAlignment.Center;
		cc().Visible = false;
		cd().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		cd().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		cd().Location = new Point(166, 119);
		cd().Name = "TextBoxStandard2ResultSpec4";
		cd().ReadOnly = true;
		cd().Size = new Size(98, 22);
		cd().TabIndex = 39;
		cd().TextAlign = HorizontalAlignment.Center;
		cd().Visible = false;
		ce().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		ce().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		ce().Location = new Point(270, 119);
		ce().Name = "TextBoxStandard3ResultSpec4";
		ce().ReadOnly = true;
		ce().Size = new Size(98, 22);
		ce().TabIndex = 40;
		ce().TextAlign = HorizontalAlignment.Center;
		ce().Visible = false;
		cf().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		cf().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		cf().Location = new Point(374, 119);
		cf().Name = "TextBoxStandard4ResultSpec4";
		cf().ReadOnly = true;
		cf().Size = new Size(98, 22);
		cf().TabIndex = 41;
		cf().TextAlign = HorizontalAlignment.Center;
		cf().Visible = false;
		cg().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		cg().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		cg().Location = new Point(478, 119);
		cg().Name = "TextBoxStandard5ResultSpec4";
		cg().ReadOnly = true;
		cg().Size = new Size(157, 22);
		cg().TabIndex = 42;
		cg().TextAlign = HorizontalAlignment.Center;
		cg().Visible = false;
		ch().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		ch().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		ch().Location = new Point(62, 147);
		ch().Name = "TextBoxStandard1ResultSpec5";
		ch().ReadOnly = true;
		ch().Size = new Size(98, 22);
		ch().TabIndex = 43;
		ch().TextAlign = HorizontalAlignment.Center;
		ch().Visible = false;
		ci().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		ci().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		ci().Location = new Point(166, 147);
		ci().Name = "TextBoxStandard2ResultSpec5";
		ci().ReadOnly = true;
		ci().Size = new Size(98, 22);
		ci().TabIndex = 44;
		ci().TextAlign = HorizontalAlignment.Center;
		ci().Visible = false;
		cj().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		cj().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		cj().Location = new Point(270, 147);
		cj().Name = "TextBoxStandard3ResultSpec5";
		cj().ReadOnly = true;
		cj().Size = new Size(98, 22);
		cj().TabIndex = 45;
		cj().TextAlign = HorizontalAlignment.Center;
		cj().Visible = false;
		ck().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		ck().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		ck().Location = new Point(374, 147);
		ck().Name = "TextBoxStandard4ResultSpec5";
		ck().ReadOnly = true;
		ck().Size = new Size(98, 22);
		ck().TabIndex = 46;
		ck().TextAlign = HorizontalAlignment.Center;
		ck().Visible = false;
		cl().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		cl().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		cl().Location = new Point(478, 147);
		cl().Name = "TextBoxStandard5ResultSpec5";
		cl().ReadOnly = true;
		cl().Size = new Size(157, 22);
		cl().TabIndex = 47;
		cl().TextAlign = HorizontalAlignment.Center;
		cl().Visible = false;
		cm().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		cm().AutoSize = true;
		cm().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		cm().Controls.Add(al());
		cm().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
		cm().Location = new Point(3, 116);
		cm().Name = "GroupBoxSetup";
		cm().Size = new Size(283, 314);
		cm().TabIndex = 69;
		cm().TabStop = false;
		cm().Text = "Input System Data";
		cp().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		cp().AutoSize = true;
		cp().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		cp().Controls.Add(ba());
		cp().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
		cp().Location = new Point(3, 436);
		cp().Name = "GroupBoxSpectrometer";
		cp().Size = new Size(283, 221);
		cp().TabIndex = 70;
		cp().TabStop = false;
		cp().Text = "Select Spectrometer";
		cq().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		cq().AutoSize = true;
		cq().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		cq().Controls.Add(ay());
		cq().Controls.Add(s());
		cq().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
		cq().Location = new Point(292, 116);
		cq().Name = "GroupBoxWaferDetails";
		cq().Size = new Size(355, 314);
		cq().TabIndex = 71;
		cq().TabStop = false;
		cq().Text = "Select Standard to Measure";
		co().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		co().AutoSize = true;
		co().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		cn().SetColumnSpan(co(), 2);
		co().Controls.Add(bl());
		co().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
		co().Location = new Point(3, 663);
		co().Name = "GroupBoxSpecResults";
		co().Size = new Size(644, 193);
		co().TabIndex = 72;
		co().TabStop = false;
		co().Text = "Copy and Paste Results to Certification Sheet (measure up to 5 Standards)";
		cn().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		cn().AutoSize = true;
		cn().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		cn().ColumnCount = 2;
		cn().ColumnStyles.Add(new ColumnStyle());
		cn().ColumnStyles.Add(new ColumnStyle());
		cn().Controls.Add(ax(), 0, 4);
		cn().Controls.Add(co(), 0, 3);
		cn().Controls.Add(cp(), 0, 2);
		cn().Controls.Add(cr(), 1, 2);
		cn().Controls.Add(cq(), 1, 1);
		cn().Controls.Add(cm(), 0, 1);
		cn().Controls.Add(cs(), 0, 0);
		cn().Location = new Point(12, 12);
		cn().Name = "TableLayoutPanelMain";
		cn().RowCount = 5;
		cn().RowStyles.Add(new RowStyle());
		cn().RowStyles.Add(new RowStyle());
		cn().RowStyles.Add(new RowStyle());
		cn().RowStyles.Add(new RowStyle());
		cn().RowStyles.Add(new RowStyle());
		cn().Size = new Size(650, 900);
		cn().TabIndex = 73;
		cr().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		cr().AutoSize = true;
		cr().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		cr().Controls.Add(bb());
		cr().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
		cr().Location = new Point(292, 436);
		cr().Name = "GroupBoxMeasResult";
		cr().Size = new Size(355, 221);
		cr().TabIndex = 74;
		cr().TabStop = false;
		cr().Text = "Measure and Accept Passing Result";
		cs().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		cn().SetColumnSpan(cs(), 2);
		cs().Controls.Add(am());
		cs().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
		cs().Location = new Point(3, 3);
		cs().Name = "GroupBoxSetShippingRecsPath";
		cs().Size = new Size(644, 107);
		cs().TabIndex = 74;
		cs().TabStop = false;
		cs().Text = "Set Customer Shipping Records Path";
		c0().AutoPopDelay = 10000;
		c0().InitialDelay = 500;
		c0().ReshowDelay = 100;
		c0().ShowAlways = true;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.ClientSize = new Size(671, 906);
		base.ControlBox = true;
		base.Controls.Add(cn());
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogQualityAssurance";
		Text = "Measure Standards";
		s().ResumeLayout(performLayout: false);
		s().PerformLayout();
		al().ResumeLayout(performLayout: false);
		al().PerformLayout();
		am().ResumeLayout(performLayout: false);
		am().PerformLayout();
		a3().ResumeLayout(performLayout: false);
		a3().PerformLayout();
		ba().ResumeLayout(performLayout: false);
		ba().PerformLayout();
		bb().ResumeLayout(performLayout: false);
		bl().ResumeLayout(performLayout: false);
		bl().PerformLayout();
		cm().ResumeLayout(performLayout: false);
		cm().PerformLayout();
		cp().ResumeLayout(performLayout: false);
		cp().PerformLayout();
		cq().ResumeLayout(performLayout: false);
		cq().PerformLayout();
		co().ResumeLayout(performLayout: false);
		co().PerformLayout();
		cn().ResumeLayout(performLayout: false);
		cn().PerformLayout();
		cr().ResumeLayout(performLayout: false);
		cr().PerformLayout();
		cs().ResumeLayout(performLayout: false);
		cs().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel s()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button t()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = l;
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
	internal virtual Label u()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox v()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TextBox A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox x()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void c(TextBox A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label y()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void c(Label A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label z()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void d(Label A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aa()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void e(Label A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox ab()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void d(TextBox A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox ac()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void e(TextBox A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ad()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void f(Label A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox ae()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void f(TextBox A_0)
	{
		m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ag()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void g(Label A_0)
	{
		n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ah()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void h(Label A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ai()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Label A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aj()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Label A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox ak()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void g(TextBox A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel al()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void c(TableLayoutPanel A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel am()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void d(TableLayoutPanel A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label an()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Label A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ao()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(Label A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ap()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(Label A_0)
	{
		w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox aq()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ComboBox A_0)
	{
		EventHandler value = i;
		EventHandler value2 = e;
		ComboBox comboBox = this.m_x;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
			comboBox.DropDown -= value2;
		}
		this.m_x = A_0;
		comboBox = this.m_x;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
			comboBox.DropDown += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ar()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void c(Button A_0)
	{
		EventHandler value = k;
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
	internal virtual Label @as()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(Label A_0)
	{
		this.m_z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label at()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(Label A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label au()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(Label A_0)
	{
		this.m_ab = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button av()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void d(Button A_0)
	{
		EventHandler value = h;
		Button button = this.m_ac;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ac = A_0;
		button = this.m_ac;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox aw()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void h(TextBox A_0)
	{
		this.m_ad = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ax()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void e(Button A_0)
	{
		EventHandler value = c;
		Button button = this.m_ae;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ae = A_0;
		button = this.m_ae;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ay()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void e(TableLayoutPanel A_0)
	{
		this.m_ag = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label az()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(Label A_0)
	{
		this.m_ah = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox a0()
	{
		return this.m_ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void c(ComboBox A_0)
	{
		EventHandler value = e;
		EventHandler value2 = d;
		ComboBox comboBox = this.m_ai;
		if (comboBox != null)
		{
			comboBox.DropDown -= value;
			comboBox.SelectedIndexChanged -= value2;
		}
		this.m_ai = A_0;
		comboBox = this.m_ai;
		if (comboBox != null)
		{
			comboBox.DropDown += value;
			comboBox.SelectedIndexChanged += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox a1()
	{
		return this.m_aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void d(ComboBox A_0)
	{
		EventHandler value = g;
		EventHandler value2 = e;
		ComboBox comboBox = this.m_aj;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
			comboBox.DropDown -= value2;
		}
		this.m_aj = A_0;
		comboBox = this.m_aj;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
			comboBox.DropDown += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a2()
	{
		return this.m_ak;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(Label A_0)
	{
		this.m_ak = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox a3()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(GroupBox A_0)
	{
		this.m_al = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox a4()
	{
		return this.m_am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TextBox A_0)
	{
		this.m_am = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a5()
	{
		return this.m_an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(Label A_0)
	{
		this.m_an = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a6()
	{
		return this.m_ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(Label A_0)
	{
		this.m_ao = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a7()
	{
		return this.m_ap;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(Label A_0)
	{
		this.m_ap = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a8()
	{
		return this.m_aq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(Label A_0)
	{
		this.m_aq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a9()
	{
		return this.m_ar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(Label A_0)
	{
		this.m_ar = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ba()
	{
		return this.m_as;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void f(TableLayoutPanel A_0)
	{
		this.m_as = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel bb()
	{
		return this.m_at;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void g(TableLayoutPanel A_0)
	{
		this.m_at = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox bc()
	{
		return this.m_au;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(TextBox A_0)
	{
		this.m_au = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox bd()
	{
		return this.m_av;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(TextBox A_0)
	{
		this.m_av = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox be()
	{
		return this.m_aw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(TextBox A_0)
	{
		this.m_aw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox bf()
	{
		return this.m_ax;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(TextBox A_0)
	{
		this.m_ax = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox bg()
	{
		return this.m_ay;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(TextBox A_0)
	{
		this.m_ay = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox bh()
	{
		return this.m_az;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(TextBox A_0)
	{
		this.m_az = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox bi()
	{
		return this.m_a0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(TextBox A_0)
	{
		this.m_a0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox bj()
	{
		return this.m_a1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(TextBox A_0)
	{
		this.m_a1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox bk()
	{
		return this.m_a2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(TextBox A_0)
	{
		this.m_a2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel bl()
	{
		return this.m_a3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void h(TableLayoutPanel A_0)
	{
		this.m_a3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bm()
	{
		return this.m_a4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aa(Label A_0)
	{
		this.m_a4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bn()
	{
		return this.m_a5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(Label A_0)
	{
		this.m_a5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bo()
	{
		return this.m_a6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(Label A_0)
	{
		this.m_a6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bp()
	{
		return this.m_a7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(Label A_0)
	{
		this.m_a7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bq()
	{
		return this.m_a8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ae(Label A_0)
	{
		this.m_a8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label br()
	{
		return this.m_a9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void af(Label A_0)
	{
		this.m_a9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bs()
	{
		return this.m_ba;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ag(Label A_0)
	{
		this.m_ba = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bt()
	{
		return this.m_bb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ah(Label A_0)
	{
		this.m_bb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bu()
	{
		return this.m_bc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ai(Label A_0)
	{
		this.m_bc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bv()
	{
		return this.m_bd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aj(Label A_0)
	{
		this.m_bd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bw()
	{
		return this.m_be;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ak(Label A_0)
	{
		this.m_be = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox bx()
	{
		return this.m_bf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(TextBox A_0)
	{
		this.m_bf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox by()
	{
		return this.m_bg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(TextBox A_0)
	{
		this.m_bg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox bz()
	{
		return this.m_bh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(TextBox A_0)
	{
		this.m_bh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox b0()
	{
		return this.m_bi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(TextBox A_0)
	{
		this.m_bi = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox b1()
	{
		return this.m_bj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void z(TextBox A_0)
	{
		this.m_bj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox b2()
	{
		return this.m_bk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aa(TextBox A_0)
	{
		this.m_bk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox b3()
	{
		return this.m_bl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(TextBox A_0)
	{
		this.m_bl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox b4()
	{
		return this.m_bm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(TextBox A_0)
	{
		this.m_bm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox b5()
	{
		return this.m_bn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(TextBox A_0)
	{
		this.m_bn = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox b6()
	{
		return this.m_bo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ae(TextBox A_0)
	{
		this.m_bo = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox b7()
	{
		return this.m_bp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void af(TextBox A_0)
	{
		this.m_bp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox b8()
	{
		return this.m_bq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ag(TextBox A_0)
	{
		this.m_bq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox b9()
	{
		return this.m_br;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ah(TextBox A_0)
	{
		this.m_br = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox ca()
	{
		return this.m_bs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ai(TextBox A_0)
	{
		this.m_bs = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox cb()
	{
		return this.m_bt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aj(TextBox A_0)
	{
		this.m_bt = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox cc()
	{
		return this.m_bu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ak(TextBox A_0)
	{
		this.m_bu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox cd()
	{
		return this.m_bv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void al(TextBox A_0)
	{
		this.m_bv = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox ce()
	{
		return this.m_bw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void am(TextBox A_0)
	{
		this.m_bw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox cf()
	{
		return this.m_bx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void an(TextBox A_0)
	{
		this.m_bx = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox cg()
	{
		return this.m_by;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ao(TextBox A_0)
	{
		this.m_by = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox ch()
	{
		return this.m_bz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ap(TextBox A_0)
	{
		this.m_bz = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox ci()
	{
		return this.m_b0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aq(TextBox A_0)
	{
		this.m_b0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox cj()
	{
		return this.m_b1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ar(TextBox A_0)
	{
		this.m_b1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox ck()
	{
		return this.m_b2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void @as(TextBox A_0)
	{
		this.m_b2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox cl()
	{
		return this.m_b3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void at(TextBox A_0)
	{
		this.m_b3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox cm()
	{
		return this.m_b4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void c(GroupBox A_0)
	{
		this.m_b4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel cn()
	{
		return this.m_b5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TableLayoutPanel A_0)
	{
		this.m_b5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox co()
	{
		return this.m_b6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void d(GroupBox A_0)
	{
		this.m_b6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox cp()
	{
		return this.m_b7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void e(GroupBox A_0)
	{
		this.m_b7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox cq()
	{
		return this.m_b8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void f(GroupBox A_0)
	{
		this.m_b8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox cr()
	{
		return this.m_b9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void g(GroupBox A_0)
	{
		this.m_b9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox cs()
	{
		return this.m_ca;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void h(GroupBox A_0)
	{
		this.m_ca = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ct()
	{
		return this.m_cb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void al(Label A_0)
	{
		this.m_cb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cu()
	{
		return this.m_cc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void am(Label A_0)
	{
		this.m_cc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox cv()
	{
		return this.m_cd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void e(ComboBox A_0)
	{
		EventHandler value = f;
		EventHandler value2 = e;
		ComboBox comboBox = this.m_cd;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
			comboBox.DropDown -= value2;
		}
		this.m_cd = A_0;
		comboBox = this.m_cd;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
			comboBox.DropDown += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cw()
	{
		return this.m_ce;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void an(Label A_0)
	{
		this.m_ce = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button cx()
	{
		return this.m_cf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal new virtual void f(Button A_0)
	{
		EventHandler value = j;
		Button button = this.m_cf;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_cf = A_0;
		button = this.m_cf;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox cy()
	{
		return this.m_cg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void au(TextBox A_0)
	{
		this.m_cg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label cz()
	{
		return this.m_ch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ao(Label A_0)
	{
		this.m_ch = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip c0()
	{
		return this.m_ci;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ToolTip A_0)
	{
		this.m_ci = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox c1()
	{
		return this.m_cj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(CheckBox A_0)
	{
		EventHandler value = b;
		CheckBox checkBox = this.m_cj;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_cj = A_0;
		checkBox = this.m_cj;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d c2()
	{
		return en;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private new virtual void d(r.d A_0)
	{
		r.d.b a_ = b;
		en?.e(a_);
		en = A_0;
		en?.d(a_);
	}

	public void b(gg A_0, f1 A_1, f4 A_2, Guid A_3)
	{
		ed = A_0;
		ee = A_1;
		ef = A_2;
		ei = A_3.ToString();
		ej = A_3;
		ee.m2(ej, ref er);
		el = ee.wq(ej);
		fa = 0;
		e6 = new Collection<hc>();
		fi = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
		fi.Visible = false;
		fi.ScreenUpdating = false;
		fi.DisplayAlerts = false;
		e9 = i3.g() + "\\QC\\";
		if (Directory.Exists(e9))
		{
			foreach (string item in Directory.EnumerateFiles(e9))
			{
				File.Delete(item);
			}
			Directory.Delete(e9);
		}
		Directory.CreateDirectory(e9);
		ef.z(A_0: false);
		e7 = ee.v8(A_3);
		c(e7);
		MySettings mySettings = global::e.a();
		fj = mySettings.LastBatchAcqSaveSetting;
		fk = mySettings.LastBatchAcqSaveFilenamePath;
		fl = mySettings.LastBatchAcqQuantity;
		fm = mySettings.DisplaySignificantDigits;
		fn = mySettings.PrintActiveCurveOnly;
		fo = mySettings.GraphMeasUserDefinedMaxCurves;
		mySettings.LastBatchAcqSaveSetting = false;
		mySettings.LastBatchAcqSaveFilenamePath = string.Empty;
		mySettings.LastBatchAcqQuantity = 0;
		mySettings.PrintActiveCurveOnly = false;
		mySettings.GraphMeasUserDefinedMaxCurves = 1;
		c1().Checked = mySettings.PreferMicrosoftPrintToPDF;
		mySettings = null;
		ak().Text = global::e.a().QCTechnician;
		Version version = global::c.d().Info.Version;
		ai().Text = version.Major + "." + version.Minor + "." + version.Build;
		version = null;
		eq = ee.uu(A_3);
		x().Text = eq;
		ee.m2(A_3, ref eo, ref ep);
		v().Text = ep;
		if (!h())
		{
			global::fe.b(base.c, "Error importing QC Recipes", i6.a(this));
		}
		p();
		eb = true;
		q();
		if (!ec)
		{
			b(i6.a(A_0));
		}
		MySettings mySettings2 = global::e.a();
		mySettings2.LastBatchAcqSaveSetting = fj;
		mySettings2.LastBatchAcqSaveFilenamePath = fk;
		mySettings2.LastBatchAcqQuantity = fl;
		mySettings2.DisplaySignificantDigits = fm;
		mySettings2.PrintActiveCurveOnly = fn;
		mySettings2.GraphMeasUserDefinedMaxCurves = fo;
		_ = null;
	}

	public bj(fz A_0, hs A_1, gr A_2)
		: base(ref A_0)
	{
		base.FormClosing += b;
		em = new r.d();
		er = null;
		r();
		eg = A_1;
		eh = q;
		eg.b(eh);
		d(new r.d());
		ek = A_2;
	}

	public new void c(r.d.a A_0)
	{
		try
		{
			if (ee.tc())
			{
				return;
			}
			if (e4)
			{
				r.i.b b10 = (r.i.b)A_0;
				if (b10.ab == null)
				{
					throw new ApplicationException("MeasResult and CompositeMeasResult are both Nothing in DialogQualityAssurance.SpectrometerSpectrumCalculatedEventHandler.");
				}
				e6.Add(b10.ab);
			}
			if (e6.Count == 10)
			{
				e4 = false;
				if (base.InvokeRequired)
				{
					r.d.b method = c;
					Invoke(method, A_0);
				}
				else
				{
					l();
					e();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			c3().c(fz.b.b, "Exception Caught in DialogQualityAssurance.SpectrometerSpectrumCalculatedEventHandler", a_);
			if (A_0.a8() == global::r.d.a.b.a)
			{
				global::fe.b(base.c, "Error in DialogQualityAssurance.SpectrometerSpectrumCalculatedEventHandler", i6.a(this));
			}
			ProjectData.ClearProjectError();
		}
	}

	private void b(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				r.d.b method = b;
				BeginInvoke(method, A_0);
			}
			else
			{
				if (A_0.a != global::r.d.a.a.b || A_0.a8() != global::r.d.a.b.a)
				{
					return;
				}
				if (A_0 is r.g.a)
				{
					r.g.a a10 = (r.g.a)A_0;
					if (a10.j == global::r.g.a.a.a)
					{
						if (string.IsNullOrEmpty(((r.d.a)a10).b))
						{
							fz a_ = base.c;
							string A_1 = "ErrSingleMeas";
							global::fe.b(a_, hu.a(ref A_1), i6.a(this));
						}
						else
						{
							global::fe.b(base.c, ((r.d.a)a10).b, i6.a(this));
						}
						return;
					}
					r.g.a a11 = a10;
					bool a_2 = false;
					string text = global::r.g.a.a6(a11.j, a11.o, a11.k, a11.l, a11.p, a11.q, a11.r, a11.s, a_2, ee.ti(ej));
					a11 = null;
					if (!fh)
					{
						fh = true;
						global::fe.b(base.c, text, i6.a(this));
					}
					base.c.c(fz.b.b, "Error in mSingleMeasCompletionTask_TaskFinishedEvent", text);
				}
				else
				{
					global::fe.b(base.c, A_0.b, i6.a(this));
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			base.c.c(fz.b.b, "Error in mSingleMeasCompletionTask_TaskFinishedEvent", a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void q()
	{
		if (eb)
		{
			ee.m2(ej, ref er);
			e();
		}
	}

	private void p()
	{
		int upperBound = er.GetUpperBound(0);
		checked
		{
			ev = new Collection<ip.d>[upperBound + 1];
			ew = new Collection<ip.e>[upperBound + 1];
			ex = new Collection<h6.c>[upperBound + 1];
			ey = new Collection<h6.d>[upperBound + 1];
			o();
			ComboBox.ObjectCollection items = a0().Items;
			items.Clear();
			e5 = 0;
			int num = upperBound;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (er[num2].ab != global::h.f.a)
				{
					continue;
				}
				e5++;
				ev[num2] = new Collection<ip.d>();
				ew[num2] = new Collection<ip.e>();
				ex[num2] = new Collection<h6.c>();
				int num3 = (er[num2].o ? 1 : (er[num2].p ? (-1) : 0));
				int num4 = num3;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					ev[num2].Add(ee.sn(ej, num2, num5));
					ew[num2].Add(ee.so(ej, num2, num5));
					ez++;
				}
				ex[num2] = ((ce)ee).p9(ej, num2);
				ey[num2] = ee.qh(ej, num2);
				if (upperBound == 0)
				{
					ComboBox.ObjectCollection objectCollection = items;
					string A_ = "MultiMeasPrimaryTypeNameDefault";
					objectCollection.Add(hu.a(ref A_));
					a0().Enabled = false;
					continue;
				}
				switch (er[num2].ab)
				{
				case global::h.f.a:
				{
					ComboBox.ObjectCollection objectCollection4 = items;
					string A_ = "MultiMeasPrimaryTypeNameFmt";
					string format3 = hu.a(ref A_);
					A_ = "MultiMeasAtAngleFmt";
					objectCollection4.Add(string.Format(format3, string.Format(hu.a(ref A_), 0.0.ToString())));
					break;
				}
				case global::h.f.b:
				{
					ComboBox.ObjectCollection objectCollection3 = items;
					string A_ = "MultiMeasSecondaryTypeNameFmt";
					string format2 = hu.a(ref A_);
					A_ = "MultiMeasAtAngleFmt";
					objectCollection3.Add(string.Format(format2, string.Format(hu.a(ref A_), 0.0.ToString())));
					break;
				}
				case global::h.f.c:
				{
					ComboBox.ObjectCollection objectCollection2 = items;
					string A_ = "MultiMeasAdditionalTypeNameFmt";
					string format = hu.a(ref A_);
					A_ = "MultiMeasAtAngleFmt";
					objectCollection2.Add(string.Format(format, string.Format(hu.a(ref A_), er[num2].ac.ToString())));
					break;
				}
				}
			}
			a0().Enabled = e5 > 1;
			ay().Visible = items.Count > 1;
			items = null;
			bl().RowCount = ez + 1;
			fb = false;
			a0().SelectedIndex = 0;
			int num6 = ez;
			for (int num7 = 1; num7 <= num6; num7++)
			{
				switch (num7)
				{
				case 1:
					bq().Visible = true;
					break;
				case 2:
					bo().Visible = true;
					break;
				case 3:
					bn().Visible = true;
					break;
				case 4:
					br().Visible = true;
					break;
				case 5:
					bm().Visible = true;
					break;
				}
			}
			k();
		}
	}

	private void o()
	{
		ToolTip toolTip = c0();
		toolTip.ToolTipTitle = "Information";
		toolTip.SetToolTip(ax(), "Copies all of the files located in the temporary QC path to the path\rshown in the Customer Shipping Records Path listed above and closes this dialog.");
		toolTip.SetToolTip(av(), "Adds this measurement to the table of accepted measurements below.\rIt also writes the spectrum and, if a Thickness Standard, a pdf file to the temporary QC path.");
		toolTip.SetToolTip(cv(), "If Thickness Standard is listed here, you may attempt to\rre-measure the Thickness Standard measured during the QC process for the wall.\rIf not within the tolerance listed below QC must be redone.");
		toolTip.SetToolTip(bk(), "If measuring a Thickness Standard and the Target Thickness value does not match\rthe value listed on the Measurement Report, QC must be redone.");
		_ = null;
	}

	private new void c(r.d A_0)
	{
		if (A_0 != null)
		{
			A_0.d((r.d.b)c);
		}
		else
		{
			c3().c(fz.b.b, "Error in DialogQualityAssurance.AddSpectrumCalculatedHandler(): spectrumCalculatedCompletionTask is Nothing. ");
		}
	}

	private void b(r.d A_0)
	{
		if (A_0 != null)
		{
			A_0.e((r.d.b)c);
		}
		else
		{
			c3().c(fz.b.b, "Error in DialogQualityAssurance.RemoveSpectrumCalculatedHandler(): spectrumCalculatedCompletionTask is Nothing. ");
		}
	}

	private void l()
	{
		_ = a0().SelectedIndex;
		b();
		int count = e6.Count;
		double num = 0.0;
		checked
		{
			int num2 = count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				num += (double)e6[num3].di()[1];
			}
			num /= (double)count;
			a4().BorderStyle = BorderStyle.None;
			b(h4.e(1, num, eu.ay(), global::e.a().DisplaySignificantDigits, new h4(h4.a.b), A_5: true, 0));
			g(hg.bu(hg.o.a, eu.ay(), num, global::e.a().DisplaySignificantDigits, new h4(h4.a.b), 0));
			a4().Refresh();
		}
	}

	private new void g(string A_0)
	{
		Graphics graphics = CreateGraphics();
		a4().Font = new System.Drawing.Font("Microsoft Sans Serif", 36f, FontStyle.Bold, GraphicsUnit.Point, 0);
		System.Drawing.Font font = a4().Font;
		float num = graphics.MeasureString(A_0, font).Width;
		float num2 = a4().Font.Size;
		while (num > (float)a4().Width)
		{
			num2 -= 2f;
			a4().Font = new System.Drawing.Font("Microsoft Sans Serif", num2, FontStyle.Bold, GraphicsUnit.Point, 0);
			font = a4().Font;
			num = graphics.MeasureString(A_0, font).Width;
		}
		a4().Text = A_0;
	}

	private string b(Range A_0, int A_1, int A_2)
	{
		return RuntimeHelpers.GetObjectValue(((Range)A_0.Cells[A_1, A_2]).Value2)?.ToString().Trim();
	}

	private void b(double A_0)
	{
		Color lime = Color.Lime;
		Color red = Color.Red;
		bk bk2 = eu;
		if (Operators.CompareString(bk2.al(), "Thickness Standard", TextCompare: false) == 0)
		{
			float num = c(eu);
			if (num == -1f || (A_0 > (double)(num - bk2.aj()) && A_0 < (double)(num + bk2.aj())))
			{
				av().Enabled = true;
				a4().BackColor = lime;
			}
			else
			{
				if (num != -1f)
				{
					global::fe.b(base.c, "This system is not within " + bh().Text + " of " + bk().Text + ". QC will need to be redone.", "Information", i6.a(ar()));
					e0 = false;
					e1 = true;
					k();
				}
				av().Enabled = false;
				a4().BackColor = red;
			}
		}
		else if (A_0 > (double)bk2.ah() && A_0 < (double)bk2.ai())
		{
			av().Enabled = true;
			a4().BackColor = lime;
		}
		else
		{
			av().Enabled = true;
			a4().BackColor = red;
		}
		bk2 = null;
	}

	private void k()
	{
		Workbook workbook = null;
		checked
		{
			try
			{
				workbook = fi.Workbooks.Open("\\\\dc\\Engineering\\Non-Vaulted Items\\060\\060-0006.xlsx", 0, true, 5, "", "", false, XlPlatform.xlWindows, "", false, false, 0, false, true, RuntimeHelpers.GetObjectValue(Missing.Value));
				int num = 0;
				_ = cv().SelectedIndex;
				cv().Items.Clear();
				bool flag;
				do
				{
					Worksheet obj = (Worksheet)workbook.Worksheets[num + 1];
					num++;
					flag = obj.Name.StartsWith("QC Std Set #");
					if (flag)
					{
						cv().Items.Add("QC Set #" + Conversions.ToString(num));
					}
				}
				while (flag);
				e0 = !e1 && b(ep, ref e8);
				if (e0)
				{
					cv().Items.Add("Thickness Standards");
					if (!string.IsNullOrEmpty(e8))
					{
						e8 += "\\Pre-Shipment";
					}
					if (!Directory.Exists(e8))
					{
						Directory.CreateDirectory(e8);
					}
				}
				cv().SelectedIndex = 0;
				e1 = false;
				if (!string.IsNullOrEmpty(e8))
				{
					z().Text = e8;
				}
			}
			finally
			{
				if (workbook != null && fi.Workbooks.Count > 0)
				{
					workbook.Close(false, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				}
			}
		}
	}

	private bool b(string A_0, ref string A_1)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return false;
		}
		if (A_0.Length >= 4 && Operators.CompareString(Conversions.ToString(A_0[3]), "#", TextCompare: false) == 0)
		{
			return false;
		}
		if (Versioned.IsNumeric(A_0))
		{
			return false;
		}
		if (Operators.CompareString(A_0, "None", TextCompare: false) == 0)
		{
			global::fe.b(base.c, "Please update the system serial number prior to performing QC.", i6.a(t()));
			ec = true;
			return false;
		}
		string text = A_0.Substring(0, 2);
		string text2 = Conversions.ToString(A_0[2]);
		if (A_0.Length > 3 && Versioned.IsNumeric(text) && Operators.CompareString(text2, "A", TextCompare: false) >= 0 && Operators.CompareString(text2, "Z", TextCompare: false) <= 0)
		{
			A_1 = "\\\\dc\\Engineering\\Shipping_Records\\20" + text + "\\" + text + text2;
			if (!Directory.Exists(A_1))
			{
				A_1 = string.Empty;
				return false;
			}
		}
		if (string.IsNullOrEmpty(A_1))
		{
			return false;
		}
		DirectoryInfo[] directories = new DirectoryInfo(A_1).GetDirectories();
		bool flag = false;
		DirectoryInfo[] array = directories;
		foreach (DirectoryInfo directoryInfo in array)
		{
			if (directoryInfo.Name.Contains(A_0))
			{
				A_1 = directoryInfo.FullName;
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			A_1 = string.Empty;
			return false;
		}
		e(A_1);
		return f(A_1) && e2 != null && e2.Count > 0;
	}

	private new bool f(string A_0)
	{
		if (!global::c.e().FileSystem.DirectoryExists(A_0))
		{
			return false;
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(A_0);
		FileInfo[] files = directoryInfo.GetFiles("*.fmspe");
		FileInfo[] array = files;
		checked
		{
			for (int num = 0; num < array.Length; num++)
			{
				_ = array[num];
				FileInfo[] array2 = files;
				for (int num2 = 0; num2 < array2.Length; num2++)
				{
					if (array2[num2].Name.Contains("QC"))
					{
						return true;
					}
				}
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				f(directoryInfo2.FullName);
			}
			bool result = default(bool);
			return result;
		}
	}

	private new void e(string A_0)
	{
		checked
		{
			try
			{
				if (string.IsNullOrEmpty(A_0))
				{
					return;
				}
				if (e2 == null || e3 == null)
				{
					e2 = new Collection<float>();
					e3 = new Collection<string>();
				}
				else
				{
					if (e2 != null)
					{
						e2.Clear();
					}
					if (e3 != null)
					{
						e3.Clear();
					}
				}
				DirectoryInfo directoryInfo = new DirectoryInfo(A_0);
				string empty = string.Empty;
				FileInfo[] files = directoryInfo.GetFiles("*.fmspe");
				for (int num = 0; num < files.Length; num++)
				{
					string name = files[num].Name;
					if (name.Contains("Thickness Standard"))
					{
						int num2 = name.LastIndexOf("-") + 1;
						int num3 = name.LastIndexOf(" ");
						_ = string.Empty;
						empty = name.Substring(num2, num3 - num2);
						if (Versioned.IsNumeric(empty))
						{
							e2.Add(Conversions.ToSingle(empty));
							e3.Add(name.Substring(0, num2 - 2));
						}
					}
					name = null;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				ProjectData.ClearProjectError();
			}
		}
	}

	private new float c(bk A_0)
	{
		if (e3 == null)
		{
			return -1f;
		}
		int num = 0;
		foreach (string item in e3)
		{
			if (item.Contains("Thickness Standard " + A_0.af()))
			{
				return e2[num];
			}
			num = checked(num + 1);
			_ = null;
		}
		return -1f;
	}

	private void j()
	{
		et = new Collection<bk>();
		aq().Items.Clear();
		ComboBox comboBox = cv();
		if (comboBox.SelectedItem.ToString().Contains("Thickness Standard"))
		{
			i();
		}
		else
		{
			b(comboBox.SelectedIndex);
		}
		comboBox = null;
		aq().SelectedIndex = 0;
	}

	private void b(int A_0)
	{
		Workbook workbook = null;
		checked
		{
			try
			{
				bk bk2 = null;
				int num = 2;
				workbook = fi.Workbooks.Open("\\\\dc\\Engineering\\Non-Vaulted Items\\060\\060-0006.xlsx", 0, true, 5, "", "", false, XlPlatform.xlWindows, "", false, false, 0, false, true, RuntimeHelpers.GetObjectValue(Missing.Value));
				Range cells = ((Worksheet)workbook.Worksheets[A_0 + 1]).Cells;
				for (num = 2; !string.IsNullOrEmpty(b(cells, num, 1)); num++)
				{
					bk2 = new bk();
					bk obj = bk2;
					obj.af("QC");
					obj.ae(b(cells, num, 3));
					obj.ac(new h4(h4.e(b(cells, num, 4))));
					obj.ad(b(cells, num, 5));
					obj.ah(b(cells, num, 21));
					obj.ac(hg.b0(b(cells, num, 6)));
					obj.ac(Conversions.ToSingle(b(cells, num, 7)));
					obj.ad(Conversions.ToSingle(b(cells, num, 8)));
					obj.ae(Conversions.ToSingle(b(cells, num, 9)));
					obj.af(Conversions.ToSingle(b(cells, num, 10)));
					obj.ag(0.004f);
					obj.ad(hg.b0(b(cells, num, 11)));
					obj.ae(hg.b0(b(cells, num, 12)));
					obj.af(hg.b0(b(cells, num, 13)));
					obj.ag(hg.b0(b(cells, num, 14)));
					obj.ah(hg.b0(b(cells, num, 15)));
					obj.ai(hg.b0(b(cells, num, 16)));
					obj.aj(hg.b0(b(cells, num, 17)));
					obj.ak(hg.b0(b(cells, num, 18)));
					obj.al(hg.b0(b(cells, num, 19)));
					obj.ag(b(cells, num, 20));
					_ = null;
					et.Add(bk2);
					aq().Items.Add(bk2.af());
				}
			}
			finally
			{
				if (workbook != null && fi.Workbooks.Count > 0)
				{
					workbook.Close(false, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				}
			}
		}
	}

	private void i()
	{
		Workbook workbook = null;
		checked
		{
			try
			{
				bk bk2 = null;
				int num = 2;
				workbook = fi.Workbooks.Open("\\\\dc\\Engineering\\Non-Vaulted Items\\060\\060-0094.xlsx", 0, true, 5, "", "", false, XlPlatform.xlWindows, "", false, false, 0, false, true, RuntimeHelpers.GetObjectValue(Missing.Value));
				Range cells = ((Worksheet)workbook.Worksheets[1]).Cells;
				List<string> list = new List<string>();
				int.Parse(((Range)cells.Cells[1, 2]).Value2.ToString());
				for (num = 3; !string.IsNullOrEmpty(b(cells, num, 1)); num++)
				{
					bk2 = new bk();
					bk obj = bk2;
					obj.af("Thickness Standard");
					obj.ae(b(cells, num, 1));
					obj.ag(b(cells, num, 2));
					obj.ac(Conversions.ToByte(b(cells, num, 13)));
					obj.af(Conversions.ToSingle(b(cells, num, 14)));
					obj.ah(b(cells, num, 15));
					obj.ac(new h4(h4.e(b(cells, num, 3))));
					string text = b(cells, num, 12);
					list.Add(text);
					obj.ad(Path.GetFileName(text));
					obj.ac(!string.IsNullOrEmpty(b(cells, num, 4)));
					obj.ad(!string.IsNullOrEmpty(b(cells, num, 5)));
					obj.ae(!string.IsNullOrEmpty(b(cells, num, 6)));
					obj.af(!string.IsNullOrEmpty(b(cells, num, 7)));
					obj.ag(!string.IsNullOrEmpty(b(cells, num, 8)));
					obj.ah(!string.IsNullOrEmpty(b(cells, num, 9)));
					obj.ai(!string.IsNullOrEmpty(b(cells, num, 10)));
					obj.aj(!string.IsNullOrEmpty(b(cells, num, 11)));
					_ = null;
					if (d(bk2.af()))
					{
						et.Add(bk2);
						aq().Items.Add(bk2.af());
					}
				}
				fg = hg.b0() + "ThicknessStandards\\";
				if (!Directory.Exists(fg))
				{
					FileSystem.MkDir(fg);
				}
				int num2 = list.Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					string text = list[num3];
					string a_ = text;
					string a_2 = fg;
					fz a_3 = base.c;
					int A_ = 0;
					int A_2 = 0;
					int A_3 = 0;
					bool A_4 = false;
					hg.bu(a_, a_2, A_2: true, a_3, default(Point), ref A_, ref A_2, ref A_3, ref A_4, A_9: true);
				}
			}
			finally
			{
				if (workbook != null && fi.Workbooks.Count > 0)
				{
					workbook.Close(false, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				}
			}
		}
	}

	private new bool d(string A_0)
	{
		if (!e0 || e3 == null || e3.Count <= 0)
		{
			return true;
		}
		bool result = default(bool);
		using (IEnumerator<string> enumerator = e3.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				result = enumerator.Current.Contains(A_0);
				return result;
			}
		}
		return result;
	}

	private new bool h()
	{
		string[] array = i3.b("\\\\dc\\Engineering\\Shipping_Records\\SW Certification\\QC Wafer Recipes\\");
		ff = hg.b0() + "QCStandards\\";
		if (!Directory.Exists(ff))
		{
			FileSystem.MkDir(ff);
		}
		string[] array2 = array;
		foreach (string text in array2)
		{
			try
			{
				string a_ = ff;
				fz a_2 = base.c;
				int A_ = 0;
				int A_2 = 0;
				int A_3 = 0;
				bool A_4 = false;
				hg.bu(text, a_, A_2: true, a_2, default(Point), ref A_, ref A_2, ref A_3, ref A_4, A_9: true);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				base.c.c(fz.b.b, "Error in DialogQualityAssurance.ImportQCRecipes while importing recipe " + text, ex3);
				throw ex3;
			}
		}
		return true;
	}

	private void l(object A_0, EventArgs A_1)
	{
		try
		{
			string value = global::cx.a(base.c, this, ep, A_3: true, i6.a(this));
			if (!string.IsNullOrEmpty(value))
			{
				e8 = value;
				z().Text = e8;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(base.c, ee, ef, i6.a(this), "DialogQualityAssurance.ButtonGetSRPath_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		bool flag = false;
		hg hg2 = ee.wq(ej);
		try
		{
			hg hg3 = hg2;
			if (!fb || string.IsNullOrEmpty(fc) || hg3.b8().a(global::h.g.a).c() == null || Operators.CompareString(fc, hg3.b8().a(global::h.g.a).c(), TextCompare: false) != 0)
			{
				flag = g();
				if (!flag)
				{
					return;
				}
				fb = flag;
				fc = hg3.b8().a(global::h.g.a).c();
			}
			if (hg3.d0().c() == g2.a.b && flag)
			{
				Cursor = Cursors.WaitCursor;
				Thread.Sleep(5000);
				Cursor = Cursors.Arrow;
			}
			global::fe.b(base.c, "Place sample on the stage.", "Information", i6.a(ar()));
			if (ee.qh(ej) || ee.p9(ej))
			{
				bool A_2 = default(bool);
				ef.i(A_0: false, A_1: false, A_2: false, A_3: false, null, ref A_2, i6.a(ar()), this);
				if (!A_2)
				{
					return;
				}
			}
			fh = false;
			f();
			e4 = true;
			string A_3 = string.Empty;
			float A_4 = default(float);
			float A_5 = default(float);
			ef.j(ref A_4, ref A_5);
			if (hg3.d0().c() == g2.a.b)
			{
				ee.m2(ej, aq().Text.ToString(), ak().ToString(), "Contact Probe Measuring...", ref A_3, c2(), null, global::r.o.j, A_8: true, A_4, A_5, global::r.d.a.b.a, 10, null, A_14: false, A_15: false, A_16: false, 0);
			}
			else
			{
				int num = 0;
				do
				{
					int a_ = ((num != 0) ? 1 : 3);
					ee.m2(ej, aq().Text.ToString(), ak().ToString(), c2(), null, global::e.a().DisplaySignificantDigits, global::r.d.a.b.a, A_7: true, a_);
					num = checked(num + 1);
				}
				while (num <= 9);
			}
			hg3 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			i5.a(base.c, ee, ef, i6.a(this), "DialogQualityAssurance.ButtonMeasure10Times_Click", ex3.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		try
		{
			if (g())
			{
				fb = true;
				fc = ee.wq(ej).b8().a(global::h.g.a)
					.c();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			i5.a(base.c, ee, ef, i6.a(this), "DialogQualityAssurance.ButtonBaseline_Click", ex3.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private new bool g()
	{
		bool result;
		try
		{
			string A_ = null;
			if (ee.m2(ej, ref A_))
			{
				b(A_0: true);
				ee.m2(ej, global::r.d.a.b.a, A_2: false);
				bool A_2 = default(bool);
				f4.i(ee, ej, base.c, ef, ek, i6.a(this), ref A_2);
				b(A_0: false);
				eg.b();
				result = !A_2;
			}
			else
			{
				ref fz a_ = ref base.c;
				string a_2 = A_;
				Point A_3 = default(Point);
				global::fe.b(ref a_, a_2, ref A_3);
				result = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			i5.a(base.c, ee, ef, i6.a(this), "DialogQualityAssurance.DoBaseline", a_3);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private new void f()
	{
		e6.Clear();
		a4().Text = "";
		a4().BackColor = SystemColors.ButtonFace;
		av().Enabled = false;
	}

	private void i(object A_0, EventArgs A_1)
	{
		try
		{
			f();
			string empty = string.Empty;
			_ = string.Empty;
			bk bk2 = et[aq().SelectedIndex];
			string empty2 = string.Empty;
			float num = 0f;
			bk bk3 = bk2;
			string text = " " + h4.e(bk3.ay(), false, false).ToString();
			if (Operators.CompareString(bk3.al(), "Thickness Standard", TextCompare: false) == 0)
			{
				empty2 = fg;
				bk().Text = "N/A";
				bh().Text = "N/A";
				bi().Text = "N/A";
				bj().Text = "N/A";
				num = c(bk2);
				if (num > -1f)
				{
					bk().Text = hg.bu(hg.o.a, bk2.ay(), num, global::e.a().DisplaySignificantDigits, bk3.ay(), 0);
					bh().Text = bk3.aj() + text;
				}
				ct().Text = bk3.al();
			}
			else
			{
				empty2 = ff;
				bk().Text = hg.bu(hg.o.a, bk2.ay(), bk3.ag(), global::e.a().DisplaySignificantDigits, bk3.ay(), 0);
				bh().Text = bk3.aj() + text;
				bi().Text = hg.bu(hg.o.a, bk2.ay(), bk3.ai(), global::e.a().DisplaySignificantDigits, bk3.ay(), 0);
				bj().Text = hg.bu(hg.o.a, bk2.ay(), bk3.ah(), global::e.a().DisplaySignificantDigits, bk3.ay(), 0);
				ct().Text = bk3.al() + " Standard";
			}
			eu = bk2;
			global::e.a().DisplaySignificantDigits = bk3.an();
			if (string.IsNullOrEmpty(bk3.am()))
			{
				aw().Text = b(eu);
			}
			else
			{
				aw().Text = bk3.am() + "\r\n\r\n" + b(eu);
			}
			@as().Text = Path.GetFileNameWithoutExtension(bk3.ae());
			empty = empty2 + bk3.ae();
			hg.bu(ref el, ref empty, hg.b4(), A_3: false, em, global::r.d.a.b.a, base.c, A_7: false, default(Point), null, g2.b.a, A_11: true, null, A_13: false);
			g g10 = el.b8().a(global::h.g.a);
			_ = string.Empty;
			g10.c(eu.ao());
			g10.c(A_0: true);
			if (el.d0().c() == g2.a.i || el.d0().c() == g2.a.k || el.d0().c() == g2.a.b)
			{
				el.d0().y = false;
				el.d0().z = false;
				switch (el.d0().c())
				{
				case g2.a.i:
					el.d0().o(g2.a.h);
					break;
				case g2.a.k:
					el.d0().o(g2.a.j);
					break;
				case g2.a.b:
					el.d0().o(g2.a.c);
					break;
				}
			}
			if (string.IsNullOrEmpty(fc) || g10.c() == null || Operators.CompareString(fc, g10.c(), TextCompare: false) != 0)
			{
				fb = false;
			}
			el.cj(global::e.a().OperatorID);
			cy().Text = g10.c();
			g10 = null;
			b(A_0: false);
			bk3 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(base.c, ee, ef, i6.a(this), "DialogQualityAssurance.ComboBoxStandard_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(bool A_0)
	{
		int selectedIndex = a0().SelectedIndex;
		h h10 = el.b8();
		if (eu == null)
		{
			return;
		}
		double num;
		double num2;
		if (eu.ac() || A_0)
		{
			h10.a(a0().SelectedIndex).h(global::f.a.a);
			h10.r(global::h.e.b);
			a1().Enabled = false;
			num = ee.sm(ej, selectedIndex);
			num2 = ee.sn(ej, selectedIndex);
		}
		else
		{
			string left = a0().Text;
			string A_1 = "MultiMeasPrimaryTypeNameFmt";
			string format = hu.a(ref A_1);
			A_1 = "MultiMeasAtAngleFmt";
			if (Operators.CompareString(left, string.Format(format, string.Format(hu.a(ref A_1), 0.0.ToString())), TextCompare: false) == 0)
			{
				h10.r(global::h.e.b);
			}
			else
			{
				A_1 = "MultiMeasSecondaryTypeNameFmt";
				string format2 = hu.a(ref A_1);
				A_1 = "MultiMeasAtAngleFmt";
				if (Operators.CompareString(left, string.Format(format2, string.Format(hu.a(ref A_1), 0.0.ToString())), TextCompare: false) == 0)
				{
					h10.r(global::h.e.c);
				}
				else
				{
					A_1 = "MultiMeasAdditionalTypeNameFmt";
					string format3 = hu.a(ref A_1);
					A_1 = "MultiMeasAtAngleFmt";
					if (Operators.CompareString(left, string.Format(format3, string.Format(hu.a(ref A_1), er[a0().SelectedIndex].ac.ToString())), TextCompare: false) == 0)
					{
						h10.r(global::h.e.d);
					}
				}
			}
			a1().Enabled = er[selectedIndex].o;
			int a_ = b();
			if (ee.qh(ej, selectedIndex, b()) == global::f.b.b)
			{
				h10.a(a0().SelectedIndex).h(global::f.a.b);
			}
			else
			{
				h10.a(a0().SelectedIndex).h(global::f.a.c);
			}
			num = ee.sj(ej, selectedIndex, a_);
			num2 = ee.sm(ej, selectedIndex, a_);
		}
		h10 = null;
		el.bv(em, A_1: false);
		ef.i(el, A_1: true, global::r.d.a.b.a);
		fl obj = ef.bb();
		obj.gi().a2().am(num);
		obj.gi().a2().an(num2);
		obj.Invalidate();
		_ = null;
		bg().Text = hg.bu(hg.o.d, new h4(h4.a.b), num, global::e.a().DisplaySignificantDigits, new h4(h4.a.b), 0);
		bf().Text = hg.bu(hg.o.d, new h4(h4.a.b), num2, global::e.a().DisplaySignificantDigits, new h4(h4.a.b), 0);
	}

	private string b(bk A_0)
	{
		string text = "Compatible System Types: \r\n";
		int num = 0;
		checked
		{
			if (A_0.ap())
			{
				text += "UV ";
				num++;
			}
			if (A_0.aq())
			{
				if (num >= 1)
				{
					text += ": ";
				}
				text += "VIS ";
				num++;
			}
			if (A_0.ar())
			{
				if (num >= 1)
				{
					text += ": ";
				}
				text += "NIR ";
				num++;
			}
			if (A_0.@as())
			{
				if (num >= 1)
				{
					text += ": ";
				}
				text += "XT ";
				num++;
			}
			if (A_0.at())
			{
				if (num >= 1)
				{
					text += ": ";
				}
				text += "XXT ";
				num++;
			}
			if (A_0.au())
			{
				if (num >= 1)
				{
					text += ": ";
				}
				text += "EXR ";
				num++;
			}
			if (A_0.av())
			{
				if (num >= 1)
				{
					text += ": ";
				}
				text += "UVX ";
				num++;
			}
			if (A_0.aw())
			{
				if (num >= 1)
				{
					text += ": ";
				}
				text += "F40 ";
				num++;
			}
			if (A_0.ax())
			{
				if (num >= 1)
				{
					text += ": ";
				}
				text += "F42 ";
				num++;
			}
			_ = null;
			if (Operators.CompareString(text, "Compatible System Types: \r\n", TextCompare: false) == 0)
			{
				return string.Empty;
			}
			return text;
		}
	}

	private void b(object A_0, FormClosingEventArgs A_1)
	{
		try
		{
			global::e.a().QCTechnician = ak().Text;
			eg.c(eh);
			b(e7);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(base.c, ee, ef, i6.a(this), "DialogQualityAssurance.DialogQualityAssurance_FormClosing", a_);
			ProjectData.ClearProjectError();
		}
	}

	private new void h(object A_0, EventArgs A_1)
	{
		int selectedIndex = a0().SelectedIndex;
		int num = b();
		checked
		{
			int num2 = selectedIndex + num;
			bool flag = eu.ac() && er[selectedIndex].o;
			string text = eu.af();
			try
			{
				if (flag)
				{
					num2 = selectedIndex * 2;
				}
				bool flag3 = default(bool);
				while (true)
				{
					if (fa > 0)
					{
						bool flag2 = true;
						if (flag2 == (Operators.CompareString(bs().Text, text, TextCompare: false) == 0))
						{
							flag3 = Operators.CompareString(eu.al(), "QC", TextCompare: false) == 0 || c(text);
							if (!flag3)
							{
								text = b(text);
								continue;
							}
							bs().Visible = true;
							bs().Text = text;
							switch (num2)
							{
							case 0:
								if (flag)
								{
									bx().Visible = true;
									bx().Text = a4().Text;
									bq().Visible = true;
									bq().Text = ew[selectedIndex][0].a.ToString();
									b2().Visible = true;
									b2().Text = a4().Text;
									bo().Visible = true;
									bo().Text = ew[selectedIndex][1].a.ToString();
								}
								else
								{
									bx().Visible = true;
									bx().Text = a4().Text;
									bq().Visible = true;
									bq().Text = ew[selectedIndex][num].a.ToString();
								}
								break;
							case 1:
								b2().Visible = true;
								b2().Text = a4().Text;
								bo().Visible = true;
								bo().Text = ew[selectedIndex][num].a.ToString();
								break;
							case 2:
								if (flag)
								{
									b7().Visible = true;
									b7().Text = a4().Text;
									bn().Visible = true;
									bn().Text = ew[selectedIndex][0].a.ToString();
									cc().Visible = true;
									cc().Text = a4().Text;
									br().Visible = true;
									br().Text = ew[selectedIndex][1].a.ToString();
								}
								else
								{
									b7().Visible = true;
									b7().Text = a4().Text;
									bn().Visible = true;
									bn().Text = ew[selectedIndex][num].a.ToString();
								}
								break;
							case 3:
								cc().Visible = true;
								cc().Text = a4().Text;
								br().Visible = true;
								br().Text = ew[selectedIndex][num].a.ToString();
								break;
							case 4:
								ch().Visible = true;
								ch().Text = a4().Text;
								bm().Visible = true;
								bm().Text = ew[selectedIndex][num].a.ToString();
								break;
							}
							break;
						}
						if (flag2 == (Operators.CompareString(bt().Text, text, TextCompare: false) == 0 || Operators.CompareString(bt().Text, "Unmeasured", TextCompare: false) == 0))
						{
							if (Operators.CompareString(bt().Text, text, TextCompare: false) == 0)
							{
								flag3 = Operators.CompareString(eu.al(), "QC", TextCompare: false) == 0 || c(text);
								if (!flag3)
								{
									text = b(text);
									continue;
								}
							}
							bt().Visible = true;
							bt().Text = text;
							switch (num2)
							{
							case 0:
								if (flag)
								{
									by().Visible = true;
									by().Text = a4().Text;
									bq().Visible = true;
									bq().Text = ew[selectedIndex][0].a.ToString();
									b3().Visible = true;
									b3().Text = a4().Text;
									bo().Visible = true;
									bo().Text = ew[selectedIndex][1].a.ToString();
								}
								else
								{
									by().Visible = true;
									by().Text = a4().Text;
									bq().Visible = true;
									bq().Text = ew[selectedIndex][num].a.ToString();
								}
								break;
							case 1:
								b3().Visible = true;
								b3().Text = a4().Text;
								bo().Visible = true;
								bo().Text = ew[selectedIndex][num].a.ToString();
								break;
							case 2:
								if (flag)
								{
									b8().Visible = true;
									b8().Text = a4().Text;
									bn().Visible = true;
									bn().Text = ew[selectedIndex][0].a.ToString();
									cd().Visible = true;
									cd().Text = a4().Text;
									br().Visible = true;
									br().Text = ew[selectedIndex][1].a.ToString();
								}
								else
								{
									b8().Visible = true;
									b8().Text = a4().Text;
									bn().Visible = true;
									bn().Text = ew[selectedIndex][num].a.ToString();
								}
								break;
							case 3:
								cd().Visible = true;
								cd().Text = a4().Text;
								br().Visible = true;
								br().Text = ew[selectedIndex][num].a.ToString();
								break;
							case 4:
								ci().Visible = true;
								ci().Text = a4().Text;
								bm().Visible = true;
								bm().Text = ew[selectedIndex][num].a.ToString();
								break;
							}
							break;
						}
						if (flag2 == (Operators.CompareString(bu().Text, text, TextCompare: false) == 0 || Operators.CompareString(bu().Text, "Unmeasured", TextCompare: false) == 0))
						{
							if (Operators.CompareString(bu().Text, text, TextCompare: false) == 0)
							{
								flag3 = Operators.CompareString(eu.al(), "QC", TextCompare: false) == 0 || c(text);
								if (!flag3)
								{
									text = b(text);
									continue;
								}
							}
							bu().Visible = true;
							bu().Text = text;
							switch (num2)
							{
							case 0:
								if (flag)
								{
									bz().Visible = true;
									bz().Text = a4().Text;
									bq().Visible = true;
									bq().Text = ew[selectedIndex][0].a.ToString();
									b4().Visible = true;
									b4().Text = a4().Text;
									bo().Visible = true;
									bo().Text = ew[selectedIndex][1].a.ToString();
								}
								else
								{
									bz().Visible = true;
									bz().Text = a4().Text;
									bq().Visible = true;
									bq().Text = ew[selectedIndex][num].a.ToString();
								}
								break;
							case 1:
								b4().Visible = true;
								b4().Text = a4().Text;
								bo().Visible = true;
								bo().Text = ew[selectedIndex][num].a.ToString();
								break;
							case 2:
								if (flag)
								{
									b9().Visible = true;
									b9().Text = a4().Text;
									bn().Visible = true;
									bn().Text = ew[selectedIndex][0].a.ToString();
									ce().Visible = true;
									ce().Text = a4().Text;
									br().Visible = true;
									br().Text = ew[selectedIndex][1].a.ToString();
								}
								else
								{
									b9().Visible = true;
									b9().Text = a4().Text;
									bn().Visible = true;
									bn().Text = ew[selectedIndex][num].a.ToString();
								}
								break;
							case 3:
								ce().Visible = true;
								ce().Text = a4().Text;
								br().Visible = true;
								br().Text = ew[selectedIndex][num].a.ToString();
								break;
							case 4:
								ch().Visible = true;
								ch().Text = a4().Text;
								bm().Visible = true;
								bm().Text = ew[selectedIndex][num].a.ToString();
								break;
							}
							break;
						}
						if (flag2 == (Operators.CompareString(bv().Text, text, TextCompare: false) == 0 || Operators.CompareString(bv().Text, "Unmeasured", TextCompare: false) == 0))
						{
							if (Operators.CompareString(bv().Text, text, TextCompare: false) == 0)
							{
								flag3 = Operators.CompareString(eu.al(), "QC", TextCompare: false) == 0 || c(text);
								if (!flag3)
								{
									text = b(text);
									continue;
								}
							}
							bv().Visible = true;
							bv().Text = text;
							switch (num2)
							{
							case 0:
								if (flag)
								{
									b0().Visible = true;
									b0().Text = a4().Text;
									bq().Visible = true;
									bq().Text = ew[selectedIndex][0].a.ToString();
									b5().Visible = true;
									b5().Text = a4().Text;
									bo().Visible = true;
									bo().Text = ew[selectedIndex][1].a.ToString();
								}
								else
								{
									b0().Visible = true;
									b0().Text = a4().Text;
									bq().Visible = true;
									bq().Text = ew[selectedIndex][num].a.ToString();
								}
								break;
							case 1:
								b5().Visible = true;
								b5().Text = a4().Text;
								bo().Visible = true;
								bo().Text = ew[selectedIndex][num].a.ToString();
								break;
							case 2:
								if (flag)
								{
									ca().Visible = true;
									ca().Text = a4().Text;
									bn().Visible = true;
									bn().Text = ew[selectedIndex][0].a.ToString();
									cf().Visible = true;
									cf().Text = a4().Text;
									br().Visible = true;
									br().Text = ew[selectedIndex][1].a.ToString();
								}
								else
								{
									ca().Visible = true;
									ca().Text = a4().Text;
									bn().Visible = true;
									bn().Text = ew[selectedIndex][num].a.ToString();
								}
								break;
							case 3:
								cf().Visible = true;
								cf().Text = a4().Text;
								br().Visible = true;
								br().Text = ew[selectedIndex][num].a.ToString();
								break;
							case 4:
								ck().Visible = true;
								ck().Text = a4().Text;
								bm().Visible = true;
								bm().Text = ew[selectedIndex][num].a.ToString();
								break;
							}
							break;
						}
						if (flag2 == (Operators.CompareString(bw().Text, text, TextCompare: false) == 0 || Operators.CompareString(bw().Text, "Unmeasured", TextCompare: false) == 0))
						{
							if (Operators.CompareString(bw().Text, text, TextCompare: false) == 0)
							{
								flag3 = c(text);
								if (!flag3)
								{
									text = b(text);
									continue;
								}
							}
							bw().Visible = true;
							bw().Text = text;
							switch (num2)
							{
							case 0:
								if (flag)
								{
									b1().Visible = true;
									b1().Text = a4().Text;
									bq().Visible = true;
									bq().Text = ew[selectedIndex][0].a.ToString();
									b6().Visible = true;
									b6().Text = a4().Text;
									bo().Visible = true;
									bo().Text = ew[selectedIndex][1].a.ToString();
								}
								else
								{
									b1().Visible = true;
									b1().Text = a4().Text;
									bq().Visible = true;
									bq().Text = ew[selectedIndex][num].a.ToString();
								}
								break;
							case 1:
								b6().Visible = true;
								b6().Text = a4().Text;
								bo().Visible = true;
								bo().Text = ew[selectedIndex][num].a.ToString();
								break;
							case 2:
								if (flag)
								{
									cb().Visible = true;
									cb().Text = a4().Text;
									bn().Visible = true;
									bn().Text = ew[selectedIndex][0].a.ToString();
									cg().Visible = true;
									cg().Text = a4().Text;
									br().Visible = true;
									br().Text = ew[selectedIndex][1].a.ToString();
								}
								else
								{
									cb().Visible = true;
									cb().Text = a4().Text;
									bn().Visible = true;
									bn().Text = ew[selectedIndex][num].a.ToString();
								}
								break;
							case 3:
								cg().Visible = true;
								cg().Text = a4().Text;
								br().Visible = true;
								br().Text = ew[selectedIndex][num].a.ToString();
								break;
							case 4:
								cl().Visible = true;
								cl().Text = a4().Text;
								bm().Visible = true;
								bm().Text = ew[selectedIndex][num].a.ToString();
								break;
							}
							break;
						}
						global::fe.b(base.c, "Already measured 5 Standards. To measure additional Standards, click Update Shipping Records and Close then restart this process.", i6.a(av()));
						return;
					}
					bs().Visible = true;
					bs().Text = text;
					if (num2 == 0)
					{
						if (flag)
						{
							bx().Visible = true;
							bx().Text = a4().Text;
							bq().Visible = true;
							bq().Text = ew[selectedIndex][0].a.ToString();
							b2().Visible = true;
							b2().Text = a4().Text;
							bo().Visible = true;
							bo().Text = ew[selectedIndex][1].a.ToString();
						}
						else
						{
							bx().Visible = true;
							bx().Text = a4().Text;
							bq().Visible = true;
							bq().Text = ew[selectedIndex][num].a.ToString();
						}
					}
					else
					{
						b2().Visible = true;
						b2().Text = a4().Text;
						bo().Visible = true;
						bo().Text = ew[selectedIndex][num].a.ToString();
					}
					break;
				}
				cu().Visible = true;
				fa++;
				if (!e0 && !e1)
				{
					e0 = Operators.CompareString(eu.al(), "QC", TextCompare: false) == 0;
					cv().Items.Add("Thickness Standards");
				}
				if (e0)
				{
					if (e2 != null)
					{
						e2.Clear();
					}
					if (e3 != null)
					{
						e3.Clear();
					}
				}
				b(e6[1], text, flag3);
				av().Enabled = false;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(base.c, ee, ef, i6.a(this), "DialogQualityAssurance.ButtonAcceptMeasurement_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private new void g(object A_0, EventArgs A_1)
	{
		try
		{
			f();
			e();
			b(A_0: false);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(base.c, ee, ef, i6.a(this), "DialogQualityAssurance.ComboBoxSpectrometer_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private new void f(object A_0, EventArgs A_1)
	{
		try
		{
			j();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(base.c, ee, ef, i6.a(this), "DialogQualityAssurance.ComboBoxType_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private new void e(object A_0, EventArgs A_1)
	{
		ComboBox comboBox = (ComboBox)A_0;
		int num = comboBox.DropDownWidth;
		Graphics graphics = comboBox.CreateGraphics();
		_ = comboBox.Font;
		int num2 = ((comboBox.Items.Count > comboBox.MaxDropDownItems) ? SystemInformation.VerticalScrollBarWidth : 0);
		foreach (object item in ((ComboBox)A_0).Items)
		{
			string text = Conversions.ToString(item);
			int num3 = checked((int)Math.Round(graphics.MeasureString(text, Font).Width) + num2 + 15);
			if (num < num3)
			{
				num = num3;
			}
		}
		comboBox.DropDownWidth = num;
	}

	private void b(hc A_0, string A_1, bool A_2)
	{
		string text;
		if (Operators.CompareString(ct().Text, "Thickness Standard", TextCompare: false) == 0)
		{
			text = b(A_1, A_2);
			b(A_0, text);
		}
		else
		{
			text = cv().SelectedItem.ToString() + " Standard " + A_1 + " " + Conversions.ToString(eu.ag());
			if (a1().Enabled)
			{
				text = text + " " + a1().Text;
			}
		}
		ax().Enabled = true;
		hr hr2 = A_0.cn();
		hr obj = hr2;
		string A_3 = e9 + text + ".fmspe";
		obj.k(ref A_3, hr2.bz(), hr2.by());
		hr2 = null;
	}

	private new bool c(string A_0)
	{
		return global::fe.b(ref base.c, A_0 + " has already been measured. Click Yes to overwrite this previous measurement or No to add this as an additional measurement.", "Information", "Yes", "No", i6.a(this));
	}

	private string b(string A_0)
	{
		string text = A_0;
		string text2 = A_0;
		int num;
		if (text2.Contains("#"))
		{
			text = text2.Substring(0, text2.LastIndexOf("#"));
			num = checked(Conversions.ToInteger(text2.Substring(text2.LastIndexOf("#") + 1, 1)) + 1);
		}
		else
		{
			num = 2;
		}
		text2 = null;
		return text + " #" + num;
	}

	private string b(string A_0, bool A_1)
	{
		string text = "Thickness Standard " + A_0;
		DirectoryInfo directoryInfo = new DirectoryInfo(e9);
		bool flag = !A_0.Contains("#");
		FileInfo[] files = directoryInfo.GetFiles();
		for (int num = 0; num < files.Length; num = checked(num + 1))
		{
			FileInfo fileInfo = files[num];
			if (fileInfo.FullName.Contains(text) && (!flag || !fileInfo.FullName.Contains("#")))
			{
				if (A_1)
				{
					fileInfo.Delete();
				}
				else
				{
					text = b(A_0);
				}
			}
			fileInfo = null;
		}
		return text + " - " + a4().Text;
	}

	private void b(hc A_0, string A_1)
	{
		dd dd2 = new dd();
		int selectedIndex = a0().SelectedIndex;
		int index = b();
		f5.a a10;
		bool flag;
		if (ef.hq())
		{
			a10 = f5.a.c;
			flag = dd2.a(ref base.c, ref fp, ref fq, ref fr, ref fs) == DialogResult.OK;
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
		PrintDocument A_2 = new PrintDocument();
		bool A_3 = false;
		bool a_ = false;
		bool A_4 = false;
		string A_5 = null;
		string A_6 = null;
		string a_2 = e9 + A_1 + ".pdf";
		PrinterSettings printerSettings = A_2.PrinterSettings;
		if (c1().Checked)
		{
			printerSettings.PrinterName = "Microsoft Print to PDF";
			if (!printerSettings.IsValid)
			{
				printerSettings.PrinterName = "Adobe PDF";
				if (!printerSettings.IsValid)
				{
					global::fe.b(base.c, "Microsoft PDF printer not found.", i6.a(this));
					return;
				}
				jj.a(a_2);
			}
			else
			{
				f5.a(A_2, A_1, e9, ref A_3, ref A_4, ref A_5, ref A_6);
				if (!A_3)
				{
					return;
				}
				a_ = true;
			}
		}
		else
		{
			printerSettings.PrinterName = "Adobe PDF";
			if (!printerSettings.IsValid)
			{
				printerSettings.PrinterName = "Microsoft Print to PDF";
				if (!printerSettings.IsValid)
				{
					global::fe.b(base.c, "Adobe PDF Writer not found.", i6.a(this));
					return;
				}
				f5.a(A_2, A_1, e9, ref A_3, ref A_4, ref A_5, ref A_6);
				if (!A_3)
				{
					return;
				}
				a_ = true;
			}
			else
			{
				jj.a(a_2);
			}
		}
		printerSettings = null;
		PageSetupDialog pageSetupDialog = new PageSetupDialog();
		pageSetupDialog.PageSettings = A_2.DefaultPageSettings;
		if (el.bz((eo.a)null))
		{
			pageSetupDialog.PageSettings.Landscape = false;
		}
		else
		{
			pageSetupDialog.PageSettings.Landscape = true;
		}
		A_2.DefaultPageSettings = pageSetupDialog.PageSettings;
		f5 A_7 = new f5();
		f5 f10 = A_7;
		if (ef.i(ref A_7))
		{
			f10.a(ee.wq(ej));
			f10.a(ef.hb());
			if (a10 == f5.a.c)
			{
				f10.v(fp);
				f10.w(fq);
				f10.x(fr);
				f10.y(fs);
			}
			else
			{
				f10.a(A_0.cn().b9());
				f10.g(A_0.cn().ca());
			}
			f10.t("Thickness Standard");
			f10.u(ak().Text);
			f10.g(v().Text + ", " + ev[selectedIndex][index].a);
			f10.a(new f5.b("Thickness Standard\r\nSpecification:", 190f, 60f, 72f, 48f, A_5: true));
			Collection<hc> collection = new Collection<hc>();
			Collection<hr> collection2 = new Collection<hr>();
			collection.Add(A_0);
			collection2.Add(A_0.cn());
			f10.a(ref A_2, collection, collection2, a10, a_, A_4, A_5, A_6);
		}
		else
		{
			global::fe.b(base.c, "Error writing PDF to file.", i6.a(this));
		}
		f10 = null;
	}

	private new void e()
	{
		int selectedIndex = a0().SelectedIndex;
		int num = (int)ee.qh(ej, selectedIndex, b());
		a9 a10 = er[selectedIndex];
		if (a10.o)
		{
			if (num == 0)
			{
				be().Text = a10.j.ToString("0.0") + " counts";
				bd().Text = a10.l.ToString("0.0") + " counts";
				bc().Text = a10.d.ToString("0.00") + " ms";
			}
			else
			{
				be().Text = a10.w.ToString("0.0") + " counts";
				bd().Text = a10.y.ToString("0.0") + " counts";
				bc().Text = a10.q.ToString("0.00") + " ms";
			}
		}
		else
		{
			be().Text = a10.j.ToString("0.0") + " counts";
			bd().Text = a10.l.ToString("0.0") + " counts";
			bc().Text = a10.d.ToString("0.00") + " ms";
		}
		a10 = null;
	}

	private new void d(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				ComboBox comboBox = a1();
				comboBox.Items.Clear();
				int num = ev[a0().SelectedIndex].Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					ip.e e10 = ew[a0().SelectedIndex][num2];
					comboBox.Items.Add(e10.a + e10.b);
				}
				comboBox.SelectedIndex = 0;
				comboBox = null;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(base.c, ee, ef, i6.a(this), "DialogQualityAssurance.ComboBoxSubModule_SelectedIndexChanged", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private new void c(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (string.IsNullOrEmpty(e8))
				{
					t().PerformClick();
					if (string.IsNullOrEmpty(e8))
					{
						global::fe.b(base.c, "Please Browse... and select a path to Update.", i6.a(this));
						return;
					}
				}
				string[] files = Directory.GetFiles(e9);
				foreach (string text in files)
				{
					string destination = e8 + "\\" + Path.GetFileName(text);
					FileSystem.FileCopy(text, destination);
				}
				ee.tf(e8);
				int num2 = e5 - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (ev[num3] != null)
					{
						int num4 = ev[num3].Count - 1;
						for (int num5 = 0; num5 <= num4; num5++)
						{
							ip.m2(null, ev[num3][num5], base.c, e8, ee.wq(ej).dh().bn());
						}
						int num6 = ex[num3].Count - 1;
						for (int num7 = 0; num7 <= num6; num7++)
						{
							h5.m2(null, ex[num3][num7], base.c, e8);
						}
					}
				}
				Process.Start("explorer.exe", e8);
				Close();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(base.c, ee, ef, i6.a(this), "DialogQualityAssurance.ButtonUpdateShippingRecord_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private new string d()
	{
		int selectedIndex = a0().SelectedIndex;
		string source = string.Empty;
		string empty = string.Empty;
		string source2 = string.Empty;
		string text = string.Empty;
		string source3 = string.Empty;
		string empty2 = string.Empty;
		string text2 = ee.p9(ei, h6.b.b, selectedIndex, global::f.b.b);
		string text3 = string.Empty;
		if (er[selectedIndex].o)
		{
			text3 = ee.p9(ei, h6.b.b, selectedIndex, global::f.b.c);
		}
		string text4 = eq;
		if (text4.Contains("F20"))
		{
			if (text4.Contains("UVX"))
			{
				source2 = "\\\\dc\\Engineering\\Non-Vaulted Items\\050\\050-0236.doc";
				text = e8 + "\\050-0236.doc";
				source = "\\\\DC\\Engineering\\Shipping_Records\\SW Certification\\PTouch Labels\\\\F20-UVX-1.lbl";
				source3 = "\\\\DC\\Engineering\\Shipping_Records\\SW Certification\\PTouch Labels\\\\F20-UVX-2.lbl";
			}
			else if (text4.Contains("UV"))
			{
				source2 = "\\\\dc\\Engineering\\Non-Vaulted Items\\050\\050-0230.doc";
				text = e8 + "\\050-0230.doc";
				source = "\\\\DC\\Engineering\\Shipping_Records\\SW Certification\\PTouch Labels\\\\F20-UV.lbl";
			}
			else if (text4.Contains("NIR"))
			{
				source2 = "\\\\dc\\Engineering\\Non-Vaulted Items\\050\\050-0245.doc";
				text = e8 + "\\050-0245.doc";
				source = "\\\\DC\\Engineering\\Shipping_Records\\SW Certification\\PTouch Labels\\\\F20-NIR.lbl";
			}
			else if (text4.Contains("NSR"))
			{
				source2 = "\\\\dc\\Engineering\\Non-Vaulted Items\\050\\050-0317.doc";
				text = e8 + "\\050-0317.doc";
				source = "\\\\DC\\Engineering\\Shipping_Records\\SW Certification\\PTouch Labels\\\\F20-NSR.lbl";
			}
			else if (text4.Contains("HR"))
			{
				source2 = "\\\\dc\\Engineering\\Non-Vaulted Items\\050\\050-0295.doc";
				text = e8 + "\\050-0295.doc";
				source = "\\\\DC\\Engineering\\Shipping_Records\\SW Certification\\PTouch Labels\\\\F20-HR.lbl";
			}
			else if (text4.Contains("XXT"))
			{
				source2 = "\\\\dc\\Engineering\\Non-Vaulted Items\\050\\050-0330.doc";
				text = e8 + "\\050-0330.doc";
				source = "\\\\DC\\Engineering\\Shipping_Records\\SW Certification\\PTouch Labels\\\\F20-XXT.lbl";
			}
			else if (text4.Contains("XT"))
			{
				source2 = "\\\\dc\\Engineering\\Non-Vaulted Items\\050\\050-0246.doc";
				text = e8 + "\\050-0246.doc";
				source = "\\\\DC\\Engineering\\Shipping_Records\\SW Certification\\PTouch Labels\\\\F20-XT.lbl";
			}
			else if (text4.Contains("EXR"))
			{
				source2 = "\\\\dc\\Engineering\\Non-Vaulted Items\\050\\050-0235.doc";
				text = e8 + "\\050-0235.doc";
				source = "\\\\DC\\Engineering\\Shipping_Records\\SW Certification\\PTouch Labels\\\\F20-EXR-1.lbl";
				source3 = "\\\\DC\\Engineering\\Shipping_Records\\SW Certification\\PTouch Labels\\\\F20-EXR-2.lbl";
			}
			else
			{
				source2 = "\\\\dc\\Engineering\\Non-Vaulted Items\\050\\050-0229.doc";
				text = e8 + "\\050-0229.doc";
				source = "\\\\DC\\Engineering\\Shipping_Records\\SW Certification\\PTouch Labels\\\\F20.lbl";
			}
		}
		else if (!text4.Contains("F10") && !text4.Contains("F20") && !text4.Contains("F20") && !text4.Contains("F20") && !text4.Contains("F20"))
		{
			text4.Contains("F20");
		}
		text4 = null;
		empty = e8 + "\\" + text2 + ".lbl";
		FileSystem.FileCopy(source2, text);
		FileSystem.FileCopy(source, empty);
		if (er[selectedIndex].o)
		{
			empty2 = e8 + "\\" + text3 + ".lbl";
			FileSystem.FileCopy(source3, empty2);
		}
		return text;
	}

	private new List<int> c()
	{
		List<int> list = new List<int>();
		checked
		{
			int num = ew[a0().SelectedIndex].Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				list.Add(num2);
			}
			return list;
		}
	}

	private int b()
	{
		List<int> list = c();
		if (a1().SelectedIndex >= 0 && a1().SelectedIndex < list.Count)
		{
			return list[a1().SelectedIndex];
		}
		return 0;
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			global::e.a().PreferMicrosoftPrintToPDF = c1().Checked;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(base.c, ee, ef, i6.a(this), "DialogQualityAssurance.CheckBoxPreferMSPrintToPDF_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}
}
