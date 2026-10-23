using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class cv : Form
{
	private enum a
	{
		a,
		b,
		c
	}

	private enum b
	{
		a = 1,
		b,
		c,
		d
	}

	private IContainer m_a;

	[CompilerGenerated]
	private TextBox m_b;

	[CompilerGenerated]
	private ToolTip m_c;

	[CompilerGenerated]
	private Panel m_d;

	[CompilerGenerated]
	private Label e;

	[CompilerGenerated]
	private Label m_f;

	[CompilerGenerated]
	private ComboBox m_g;

	[CompilerGenerated]
	private Label m_h;

	[CompilerGenerated]
	private Label m_i;

	[CompilerGenerated]
	private Label m_j;

	[CompilerGenerated]
	private Label m_k;

	[CompilerGenerated]
	private Label l;

	[CompilerGenerated]
	private Label m;

	[CompilerGenerated]
	private Label n;

	[CompilerGenerated]
	private Label m_o;

	[CompilerGenerated]
	private GroupBox m_p;

	[CompilerGenerated]
	private Button m_q;

	[CompilerGenerated]
	private Button m_r;

	[CompilerGenerated]
	private Button m_s;

	[CompilerGenerated]
	private Button m_t;

	[CompilerGenerated]
	private Button u;

	[CompilerGenerated]
	private VScrollBar v;

	[CompilerGenerated]
	private Button w;

	[CompilerGenerated]
	private Label x;

	[CompilerGenerated]
	private Label y;

	[CompilerGenerated]
	private Label z;

	[CompilerGenerated]
	private Label aa;

	[CompilerGenerated]
	private Label ab;

	[CompilerGenerated]
	private GroupBox m_ac;

	[CompilerGenerated]
	private hy m_ad;

	[CompilerGenerated]
	private hy m_ae;

	[CompilerGenerated]
	private hy af;

	[CompilerGenerated]
	private CheckBox m_ag;

	[CompilerGenerated]
	private Label ah;

	[CompilerGenerated]
	private CheckBox ai;

	[CompilerGenerated]
	private CheckBox m_aj;

	[CompilerGenerated]
	private ComboBox ak;

	[CompilerGenerated]
	private CheckBox m_al;

	[CompilerGenerated]
	private hy am;

	[CompilerGenerated]
	private Button an;

	[CompilerGenerated]
	private Button ao;

	[CompilerGenerated]
	private TextBox ap;

	[CompilerGenerated]
	private Label aq;

	[CompilerGenerated]
	private Button ar;

	[CompilerGenerated]
	private GroupBox m_as;

	[CompilerGenerated]
	private hy m_at;

	[CompilerGenerated]
	private hy m_au;

	[CompilerGenerated]
	private hy m_av;

	[CompilerGenerated]
	private Label m_aw;

	[CompilerGenerated]
	private ComboBox ax;

	[CompilerGenerated]
	private CheckBox m_ay;

	[CompilerGenerated]
	private hy az;

	[CompilerGenerated]
	private CheckBox a0;

	[CompilerGenerated]
	private CheckBox a1;

	[CompilerGenerated]
	private CheckBox a2;

	[CompilerGenerated]
	private Button a3;

	[CompilerGenerated]
	private Button a4;

	[CompilerGenerated]
	private TextBox a5;

	[CompilerGenerated]
	private Label a6;

	[CompilerGenerated]
	private GroupBox m_a7;

	[CompilerGenerated]
	private hy m_a8;

	[CompilerGenerated]
	private hy m_a9;

	[CompilerGenerated]
	private hy ba;

	[CompilerGenerated]
	private CheckBox m_bb;

	[CompilerGenerated]
	private Label bc;

	[CompilerGenerated]
	private CheckBox m_bd;

	[CompilerGenerated]
	private ComboBox be;

	[CompilerGenerated]
	private CheckBox bf;

	[CompilerGenerated]
	private CheckBox m_bg;

	[CompilerGenerated]
	private hy bh;

	[CompilerGenerated]
	private Button bi;

	[CompilerGenerated]
	private Button bj;

	[CompilerGenerated]
	private TextBox bk;

	[CompilerGenerated]
	private Label bl;

	[CompilerGenerated]
	private GroupBox m_bm;

	[CompilerGenerated]
	private hy m_bn;

	[CompilerGenerated]
	private hy m_bo;

	[CompilerGenerated]
	private hy bp;

	[CompilerGenerated]
	private CheckBox m_bq;

	[CompilerGenerated]
	private Label br;

	[CompilerGenerated]
	private CheckBox m_bs;

	[CompilerGenerated]
	private ComboBox bt;

	[CompilerGenerated]
	private CheckBox bu;

	[CompilerGenerated]
	private CheckBox m_bv;

	[CompilerGenerated]
	private hy bw;

	[CompilerGenerated]
	private Button bx;

	[CompilerGenerated]
	private Button by;

	[CompilerGenerated]
	private TextBox bz;

	[CompilerGenerated]
	private Label b0;

	[CompilerGenerated]
	private GroupBox m_b1;

	[CompilerGenerated]
	private hy m_b2;

	[CompilerGenerated]
	private hy m_b3;

	[CompilerGenerated]
	private hy b4;

	[CompilerGenerated]
	private CheckBox m_b5;

	[CompilerGenerated]
	private Label b6;

	[CompilerGenerated]
	private CheckBox m_b7;

	[CompilerGenerated]
	private ComboBox b8;

	[CompilerGenerated]
	private CheckBox b9;

	[CompilerGenerated]
	private CheckBox m_ca;

	[CompilerGenerated]
	private hy cb;

	[CompilerGenerated]
	private Button cc;

	[CompilerGenerated]
	private Button cd;

	[CompilerGenerated]
	private TextBox ce;

	[CompilerGenerated]
	private Label cf;

	[CompilerGenerated]
	private GroupBox m_cg;

	[CompilerGenerated]
	private hy m_ch;

	[CompilerGenerated]
	private hy m_ci;

	[CompilerGenerated]
	private hy cj;

	[CompilerGenerated]
	private CheckBox m_ck;

	[CompilerGenerated]
	private Label cl;

	[CompilerGenerated]
	private CheckBox cm;

	[CompilerGenerated]
	private CheckBox m_cn;

	[CompilerGenerated]
	private ComboBox co;

	[CompilerGenerated]
	private CheckBox m_cp;

	[CompilerGenerated]
	private hy cq;

	[CompilerGenerated]
	private Button cr;

	[CompilerGenerated]
	private Button cs;

	[CompilerGenerated]
	private TextBox ct;

	[CompilerGenerated]
	private Label cu;

	[CompilerGenerated]
	private Button m_cv;

	[CompilerGenerated]
	private Button cw;

	[CompilerGenerated]
	private Button cx;

	[CompilerGenerated]
	private Button cy;

	[CompilerGenerated]
	private Button cz;

	[CompilerGenerated]
	private Label m_c0;

	[CompilerGenerated]
	private Label m_c1;

	[CompilerGenerated]
	private CheckBox m_c2;

	[CompilerGenerated]
	private CheckBox m_c3;

	[CompilerGenerated]
	private CheckBox m_c4;

	[CompilerGenerated]
	private CheckBox m_c5;

	[CompilerGenerated]
	private CheckBox m_c6;

	[CompilerGenerated]
	private CheckBox m_c7;

	[CompilerGenerated]
	private Label c8;

	[CompilerGenerated]
	private Label m_c9;

	private const int m_da = 5;

	private const int m_db = 6;

	private gr m_dc;

	private ge m_dd;

	private hd m_de;

	private hg m_df;

	private hg m_dg;

	private DateTime m_dh;

	private string m_di;

	private int m_dj;

	private int m_dk;

	private int m_dl;

	private int m_dm;

	private int m_dn;

	private bool m_do;

	private short m_dp;

	private h4 m_dq;

	private fz m_dr;

	private const string m_ds = "DialogEditLayerStack";

	private string m_dt;

	private gd m_du;

	private gd m_dv;

	private const string m_dw = "\\MostRecentLayerMaterials.fmslf";

	private const string m_dx = "\\MostRecentMediumMaterials.fmslf";

	private const string m_dy = "\\MostRecentSubstrateMaterials.fmslf";

	private const string m_dz = "DropDown";

	private Collection<TextBox> m_d0;

	private Collection<hy> m_d1;

	private Collection<hy> m_d2;

	private Collection<hy> m_d3;

	private Collection<hy> m_d4;

	private Collection<hy> m_d5;

	private Collection<CheckBox> m_d6;

	private Collection<CheckBox> m_d7;

	private Collection<CheckBox> m_d8;

	private Collection<CheckBox> m_d9;

	private Collection<Button> m_ea;

	private Collection<Button> m_eb;

	private Collection<Button> m_ec;

	private Collection<ComboBox> m_ed;

	private Collection<Label> m_ee;

	private Collection<CheckBox> m_ef;

	private Collection<Label> m_eg;

	private Collection<GroupBox> m_eh;

	private iw m_ei;

	private gc.a m_ej;

	private string m_ek;

	private string m_el;

	private string m_em;

	[CompilerGenerated]
	private r.d m_en;

	private f1 m_eo;

	private f4 m_ep;

	private hg m_eq;

	private bool m_er;

	private string m_es;

	private Collection<string> m_et;

	private Collection<string> m_eu;

	private b2 m_ev;

	private eo.a m_ew;

	private bool m_ex;

	private eo.b m_ey;

	[SpecialName]
	private bool m_ez;

	[SpecialName]
	private StaticLocalInitFlag m_e0;

	public cv()
	{
		this.m_dj = 1;
		this.m_d0 = new Collection<TextBox>();
		this.m_d1 = new Collection<hy>();
		this.m_d2 = new Collection<hy>();
		this.m_d3 = new Collection<hy>();
		this.m_d4 = new Collection<hy>();
		this.m_d5 = new Collection<hy>();
		this.m_d6 = new Collection<CheckBox>();
		this.m_d7 = new Collection<CheckBox>();
		this.m_d8 = new Collection<CheckBox>();
		this.m_d9 = new Collection<CheckBox>();
		this.m_ea = new Collection<Button>();
		this.m_eb = new Collection<Button>();
		this.m_ec = new Collection<Button>();
		this.m_ed = new Collection<ComboBox>();
		this.m_ee = new Collection<Label>();
		this.m_ef = new Collection<CheckBox>();
		this.m_eg = new Collection<Label>();
		this.m_eh = new Collection<GroupBox>();
		this.m_el = string.Empty;
		this.m_em = string.Empty;
		this.m_ev = new b2();
		o();
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
	private void o()
	{
		this.m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(cv));
		a(new ToolTip(this.m_a));
		a(new Panel());
		a8(new Label());
		a9(new Label());
		a7(new Label());
		a(new Label());
		b(new Label());
		a(new ComboBox());
		c(new Label());
		d(new Label());
		f(new Label());
		g(new Label());
		h(new Label());
		i(new Label());
		j(new Label());
		k(new Label());
		a(new GroupBox());
		a(new Button());
		b(new Button());
		c(new Button());
		d(new Button());
		f(new Button());
		a(new VScrollBar());
		g(new Button());
		o(new Label());
		p(new Label());
		q(new Label());
		r(new Label());
		s(new Label());
		b(new GroupBox());
		au(new CheckBox());
		a(new CheckBox());
		t(new Label());
		b(new CheckBox());
		c(new CheckBox());
		b(new ComboBox());
		d(new CheckBox());
		h(new Button());
		i(new Button());
		b(new TextBox());
		ac(new Label());
		j(new Button());
		c(new GroupBox());
		av(new CheckBox());
		ad(new Label());
		c(new ComboBox());
		f(new CheckBox());
		g(new CheckBox());
		h(new CheckBox());
		i(new CheckBox());
		k(new Button());
		o(new Button());
		c(new TextBox());
		ae(new Label());
		d(new GroupBox());
		aw(new CheckBox());
		j(new CheckBox());
		ag(new Label());
		k(new CheckBox());
		d(new ComboBox());
		o(new CheckBox());
		p(new CheckBox());
		p(new Button());
		q(new Button());
		d(new TextBox());
		aj(new Label());
		f(new GroupBox());
		ay(new CheckBox());
		q(new CheckBox());
		al(new Label());
		r(new CheckBox());
		f(new ComboBox());
		s(new CheckBox());
		t(new CheckBox());
		r(new Button());
		s(new Button());
		f(new TextBox());
		@as(new Label());
		g(new GroupBox());
		a7(new CheckBox());
		ac(new CheckBox());
		at(new Label());
		ad(new CheckBox());
		g(new ComboBox());
		ae(new CheckBox());
		ag(new CheckBox());
		t(new Button());
		ac(new Button());
		g(new TextBox());
		au(new Label());
		h(new GroupBox());
		a8(new CheckBox());
		aj(new CheckBox());
		av(new Label());
		al(new CheckBox());
		@as(new CheckBox());
		h(new ComboBox());
		at(new CheckBox());
		ad(new Button());
		ae(new Button());
		h(new TextBox());
		aw(new Label());
		ag(new Button());
		aj(new Button());
		al(new Button());
		@as(new Button());
		at(new Button());
		ay(new Label());
		a(new hy());
		b(new hy());
		c(new hy());
		d(new hy());
		f(new hy());
		g(new hy());
		h(new hy());
		i(new hy());
		j(new hy());
		k(new hy());
		o(new hy());
		p(new hy());
		q(new hy());
		r(new hy());
		s(new hy());
		t(new hy());
		ac(new hy());
		ad(new hy());
		ae(new hy());
		ag(new hy());
		aj(new hy());
		al(new hy());
		@as(new hy());
		at(new hy());
		r().SuspendLayout();
		av().SuspendLayout();
		bs().SuspendLayout();
		c2().SuspendLayout();
		di().SuspendLayout();
		dx().SuspendLayout();
		ec().SuspendLayout();
		er().SuspendLayout();
		SuspendLayout();
		r().AutoScroll = true;
		r().Controls.Add(fj());
		r().Controls.Add(fk());
		r().Controls.Add(fc());
		r().Controls.Add(s());
		r().Controls.Add(t());
		r().Controls.Add(ac());
		r().Controls.Add(ad());
		r().Controls.Add(ae());
		r().Controls.Add(ag());
		r().Controls.Add(aj());
		r().Controls.Add(al());
		r().Controls.Add(@as());
		r().Controls.Add(at());
		r().Controls.Add(au());
		r().Controls.Add(av());
		r().Controls.Add(a8());
		r().Controls.Add(a9());
		r().Controls.Add(bb());
		r().Controls.Add(bd());
		r().Controls.Add(bg());
		r().Controls.Add(bm());
		r().Controls.Add(bn());
		r().Controls.Add(bo());
		r().Controls.Add(bq());
		r().Controls.Add(bs());
		r().Controls.Add(c1());
		r().Controls.Add(c2());
		r().Controls.Add(di());
		r().Controls.Add(dx());
		r().Controls.Add(ec());
		r().Controls.Add(er());
		r().Controls.Add(e6());
		r().Controls.Add(e7());
		r().Controls.Add(e8());
		r().Controls.Add(e9());
		r().Controls.Add(fa());
		r().Controls.Add(fb());
		r().Dock = DockStyle.Fill;
		r().Location = new Point(0, 0);
		r().Name = "Panel1";
		r().Size = new Size(1015, 535);
		r().TabIndex = 0;
		fj().BackColor = SystemColors.ButtonHighlight;
		fj().BorderStyle = BorderStyle.Fixed3D;
		fj().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		fj().Location = new Point(483, 39);
		fj().Name = "LabelFileFormatBox";
		fj().Size = new Size(123, 22);
		fj().TabIndex = 350;
		fj().Text = "Unknown";
		fj().TextAlign = ContentAlignment.MiddleLeft;
		fj().Visible = false;
		fk().AutoSize = true;
		fk().BackColor = Color.Transparent;
		fk().Cursor = Cursors.Default;
		fk().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		fk().ForeColor = SystemColors.ControlText;
		fk().Location = new Point(399, 42);
		fk().Name = "LabelFileFormat";
		fk().RightToLeft = RightToLeft.No;
		fk().Size = new Size(78, 16);
		fk().TabIndex = 349;
		fk().Text = "File Format:";
		fk().Visible = false;
		fc().AutoSize = true;
		fc().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		fc().Location = new Point(948, 83);
		fc().Name = "HideLabel";
		fc().Size = new Size(34, 16);
		fc().TabIndex = 348;
		fc().Text = "Hide";
		fc().Visible = false;
		s().BackColor = SystemColors.Window;
		s().BorderStyle = BorderStyle.Fixed3D;
		s().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		s().Location = new Point(143, 41);
		s().Name = "LabelUnit";
		s().Size = new Size(194, 21);
		s().TabIndex = 347;
		t().AutoSize = true;
		t().BackColor = Color.Transparent;
		t().Cursor = Cursors.Default;
		t().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		t().ForeColor = SystemColors.WindowText;
		t().Location = new Point(854, 83);
		t().Name = "Label7";
		t().RightToLeft = RightToLeft.No;
		t().Size = new Size(78, 16);
		t().TabIndex = 339;
		t().Text = "Index Model";
		t().TextAlign = ContentAlignment.TopCenter;
		ac().DropDownStyle = ComboBoxStyle.DropDownList;
		ac().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ac().FormattingEnabled = true;
		ac().Location = new Point(143, 8);
		ac().Name = "ComboLayerStackName";
		ac().Size = new Size(194, 24);
		ac().TabIndex = 346;
		ad().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ad().Location = new Point(15, 11);
		ad().Name = "Label8";
		ad().Size = new Size(122, 16);
		ad().TabIndex = 345;
		ad().Text = "Layer Stack Name:";
		ae().BackColor = SystemColors.ButtonHighlight;
		ae().BorderStyle = BorderStyle.Fixed3D;
		ae().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae().Location = new Point(454, 8);
		ae().Name = "LabelAuthor";
		ae().Size = new Size(152, 22);
		ae().TabIndex = 344;
		ae().Text = "User Name";
		ae().TextAlign = ContentAlignment.MiddleLeft;
		ag().BackColor = SystemColors.ButtonHighlight;
		ag().BorderStyle = BorderStyle.Fixed3D;
		ag().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ag().Location = new Point(720, 8);
		ag().Name = "LabelModDate";
		ag().Size = new Size(152, 22);
		ag().TabIndex = 343;
		ag().Text = "Mod. Date:";
		ag().TextAlign = ContentAlignment.MiddleLeft;
		aj().AutoSize = true;
		aj().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aj().Location = new Point(623, 11);
		aj().Name = "Label9";
		aj().Size = new Size(91, 16);
		aj().TabIndex = 342;
		aj().Text = "Last Modified:";
		al().AutoSize = true;
		al().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		al().Location = new Point(399, 11);
		al().Name = "Label10";
		al().Size = new Size(49, 16);
		al().TabIndex = 341;
		al().Text = "Author:";
		@as().BackColor = Color.Transparent;
		@as().Cursor = Cursors.Default;
		@as().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		@as().ForeColor = SystemColors.ControlText;
		@as().Location = new Point(92, 42);
		@as().Name = "Label14";
		@as().RightToLeft = RightToLeft.No;
		@as().Size = new Size(45, 20);
		@as().TabIndex = 340;
		@as().Text = "Units:";
		at().AutoSize = true;
		at().BackColor = Color.Transparent;
		at().Cursor = Cursors.Default;
		at().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		at().ForeColor = SystemColors.WindowText;
		at().Location = new Point(656, 83);
		at().Name = "LabelConstraintsThickness";
		at().RightToLeft = RightToLeft.No;
		at().Size = new Size(99, 16);
		at().TabIndex = 338;
		at().Text = "+/- %Thickness";
		at().TextAlign = ContentAlignment.TopCenter;
		au().AutoSize = true;
		au().BackColor = Color.Transparent;
		au().Cursor = Cursors.Default;
		au().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		au().ForeColor = SystemColors.WindowText;
		au().Location = new Point(780, 83);
		au().Name = "LabelConstraintsN";
		au().RightToLeft = RightToLeft.No;
		au().Size = new Size(46, 16);
		au().TabIndex = 314;
		au().Text = "+/- n/k";
		au().TextAlign = ContentAlignment.TopCenter;
		av().Controls.Add(aw());
		av().Controls.Add(ay());
		av().Controls.Add(a7());
		av().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		av().Location = new Point(9, 411);
		av().Name = "GroupFileOperations";
		av().Size = new Size(977, 67);
		av().TabIndex = 335;
		av().TabStop = false;
		av().Text = "Layer Stack";
		aw().Cursor = Cursors.Default;
		aw().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aw().ForeColor = SystemColors.ControlText;
		aw().Location = new Point(20, 23);
		aw().Name = "ButtonSave";
		aw().Size = new Size(124, 33);
		aw().TabIndex = 69;
		aw().Text = "Save";
		ay().Cursor = Cursors.Default;
		ay().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ay().ForeColor = SystemColors.ControlText;
		ay().Location = new Point(156, 23);
		ay().Name = "ButtonSaveAs";
		ay().Size = new Size(124, 33);
		ay().TabIndex = 67;
		ay().Text = "Save As New...";
		a7().Cursor = Cursors.Default;
		a7().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a7().ForeColor = SystemColors.ControlText;
		a7().Location = new Point(302, 23);
		a7().Name = "ButtonDelete";
		a7().Size = new Size(109, 33);
		a7().TabIndex = 68;
		a7().Text = "Delete...";
		a8().Cursor = Cursors.Default;
		a8().DialogResult = DialogResult.Cancel;
		a8().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a8().ForeColor = SystemColors.ControlText;
		a8().Location = new Point(845, 489);
		a8().Name = "ButtonCancel";
		a8().Size = new Size(114, 36);
		a8().TabIndex = 337;
		a8().Text = "Cancel";
		a9().Cursor = Cursors.Default;
		a9().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a9().ForeColor = SystemColors.ControlText;
		a9().Location = new Point(718, 489);
		a9().Name = "ButtonOK";
		a9().Size = new Size(111, 36);
		a9().TabIndex = 336;
		a9().Text = "OK";
		bb().Cursor = Cursors.Default;
		bb().LargeChange = 1;
		bb().Location = new Point(990, 109);
		bb().Maximum = 32767;
		bb().Name = "VscrollLayerStack";
		bb().Size = new Size(20, 278);
		bb().TabIndex = 334;
		bb().TabStop = true;
		bd().BackColor = SystemColors.Control;
		bd().Cursor = Cursors.Default;
		bd().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bd().ForeColor = SystemColors.ControlText;
		bd().Image = (Image)componentResourceManager.GetObject("_btnInsertLayer_0.Image");
		bd().Location = new Point(9, 90);
		bd().Name = "_btnInsertLayer_0";
		bd().RightToLeft = RightToLeft.No;
		bd().Size = new Size(24, 27);
		bd().TabIndex = 316;
		bd().TextAlign = ContentAlignment.BottomCenter;
		bd().UseVisualStyleBackColor = false;
		bg().AutoSize = true;
		bg().BackColor = Color.Transparent;
		bg().Cursor = Cursors.Default;
		bg().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bg().ForeColor = SystemColors.WindowText;
		bg().Location = new Point(539, 83);
		bg().Name = "LabelFilmStackMeasure";
		bg().RightToLeft = RightToLeft.No;
		bg().Size = new Size(62, 16);
		bg().TabIndex = 322;
		bg().Text = " Measure";
		bg().TextAlign = ContentAlignment.MiddleCenter;
		bm().AutoSize = true;
		bm().BackColor = Color.Transparent;
		bm().Cursor = Cursors.Default;
		bm().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bm().ForeColor = SystemColors.WindowText;
		bm().Location = new Point(315, 83);
		bm().Name = "LabelFilmStackThickness";
		bm().RightToLeft = RightToLeft.No;
		bm().Size = new Size(82, 16);
		bm().TabIndex = 323;
		bm().Text = "Thickness(d)";
		bm().TextAlign = ContentAlignment.TopCenter;
		bn().AutoSize = true;
		bn().BackColor = Color.Transparent;
		bn().Cursor = Cursors.Default;
		bn().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bn().ForeColor = SystemColors.WindowText;
		bn().Location = new Point(414, 83);
		bn().Name = "LabelFilmStackRoughness";
		bn().RightToLeft = RightToLeft.No;
		bn().Size = new Size(85, 16);
		bn().TabIndex = 327;
		bn().Text = "Roughness(r)";
		bn().TextAlign = ContentAlignment.TopCenter;
		bo().AutoSize = true;
		bo().BackColor = Color.Transparent;
		bo().Cursor = Cursors.Default;
		bo().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bo().ForeColor = SystemColors.WindowText;
		bo().Location = new Point(206, 83);
		bo().Name = "LabelFilmStackMaterial";
		bo().RightToLeft = RightToLeft.No;
		bo().Size = new Size(54, 16);
		bo().TabIndex = 332;
		bo().Text = "Material";
		bo().TextAlign = ContentAlignment.MiddleCenter;
		bq().AutoSize = true;
		bq().BackColor = Color.Transparent;
		bq().Cursor = Cursors.Default;
		bq().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bq().Location = new Point(103, 83);
		bq().Name = "LabelFilmStackLayer";
		bq().RightToLeft = RightToLeft.No;
		bq().Size = new Size(40, 16);
		bq().TabIndex = 333;
		bq().Text = "Layer";
		bq().TextAlign = ContentAlignment.TopCenter;
		bs().BackColor = Color.Transparent;
		bs().Controls.Add(fd());
		bs().Controls.Add(bv());
		bs().Controls.Add(b1());
		bs().Controls.Add(b2());
		bs().Controls.Add(b3());
		bs().Controls.Add(b5());
		bs().Controls.Add(b7());
		bs().Controls.Add(ca());
		bs().Controls.Add(cg());
		bs().Controls.Add(ch());
		bs().Controls.Add(ci());
		bs().Controls.Add(ck());
		bs().Controls.Add(cn());
		bs().Controls.Add(cp());
		bs().Controls.Add(c0());
		bs().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bs().ForeColor = SystemColors.ControlText;
		bs().Location = new Point(41, 102);
		bs().Name = "_FrameLayer_0";
		bs().RightToLeft = RightToLeft.No;
		bs().Size = new Size(945, 45);
		bs().TabIndex = 317;
		bs().TabStop = false;
		fd().AutoSize = true;
		fd().Location = new Point(916, 20);
		fd().Name = "_hideCheck_0";
		fd().Size = new Size(15, 14);
		fd().TabIndex = 321;
		fd().UseVisualStyleBackColor = true;
		fd().Visible = false;
		b3().BackColor = Color.Transparent;
		b3().Cursor = Cursors.Default;
		b3().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b3().ForeColor = SystemColors.ControlText;
		b3().Location = new Point(588, 16);
		b3().Name = "_rCheck_0";
		b3().RightToLeft = RightToLeft.No;
		b3().Size = new Size(33, 22);
		b3().TabIndex = 317;
		b3().Text = "r";
		b3().UseVisualStyleBackColor = false;
		b3().Visible = false;
		b5().AutoSize = true;
		b5().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		b5().Location = new Point(705, 18);
		b5().Name = "Label1";
		b5().Size = new Size(18, 16);
		b5().TabIndex = 110;
		b5().Text = "%";
		b7().BackColor = Color.Transparent;
		b7().Cursor = Cursors.Default;
		b7().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b7().ForeColor = SystemColors.ControlText;
		b7().Location = new Point(548, 16);
		b7().Name = "_kCheck_0";
		b7().RightToLeft = RightToLeft.No;
		b7().Size = new Size(33, 22);
		b7().TabIndex = 316;
		b7().Text = "k";
		b7().UseVisualStyleBackColor = false;
		b7().Visible = false;
		ca().BackColor = Color.Transparent;
		ca().Cursor = Cursors.Default;
		ca().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ca().ForeColor = SystemColors.ControlText;
		ca().Location = new Point(508, 16);
		ca().Name = "_nCheck_0";
		ca().RightToLeft = RightToLeft.No;
		ca().Size = new Size(33, 22);
		ca().TabIndex = 314;
		ca().Text = "n";
		ca().UseVisualStyleBackColor = false;
		ca().Visible = false;
		cg().DropDownStyle = ComboBoxStyle.DropDownList;
		cg().DropDownWidth = 180;
		cg().Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cg().FormattingEnabled = true;
		cg().Location = new Point(809, 15);
		cg().Name = "ComboBoxnkModel0";
		cg().Size = new Size(90, 23);
		cg().TabIndex = 109;
		ch().BackColor = Color.Transparent;
		ch().Cursor = Cursors.Default;
		ch().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ch().ForeColor = SystemColors.ControlText;
		ch().Location = new Point(470, 16);
		ch().Name = "_dCheck_0";
		ch().RightToLeft = RightToLeft.No;
		ch().Size = new Size(33, 22);
		ch().TabIndex = 315;
		ch().Text = "d";
		ch().UseVisualStyleBackColor = false;
		ck().BackColor = SystemColors.Control;
		ck().Cursor = Cursors.Default;
		ck().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ck().ForeColor = SystemColors.ControlText;
		ck().Image = (Image)componentResourceManager.GetObject("_MatButton_0.Image");
		ck().Location = new Point(247, 16);
		ck().Name = "_MatButton_0";
		ck().RightToLeft = RightToLeft.No;
		ck().Size = new Size(17, 20);
		ck().TabIndex = 7;
		ck().TextAlign = ContentAlignment.BottomCenter;
		ck().UseVisualStyleBackColor = false;
		cn().BackColor = SystemColors.Control;
		cn().Cursor = Cursors.Default;
		cn().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		cn().ForeColor = SystemColors.ControlText;
		cn().Image = (Image)componentResourceManager.GetObject("_btnDeleteLayer_0.Image");
		cn().Location = new Point(8, 12);
		cn().Name = "_btnDeleteLayer_0";
		cn().RightToLeft = RightToLeft.No;
		cn().Size = new Size(25, 24);
		cn().TabIndex = 5;
		cn().TextAlign = ContentAlignment.BottomCenter;
		cn().UseVisualStyleBackColor = false;
		cp().AcceptsReturn = true;
		cp().BackColor = SystemColors.Window;
		cp().Cursor = Cursors.IBeam;
		cp().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		cp().ForeColor = SystemColors.WindowText;
		cp().Location = new Point(128, 15);
		cp().MaxLength = 0;
		cp().Name = "_MatBox_0";
		cp().ReadOnly = true;
		cp().RightToLeft = RightToLeft.No;
		cp().Size = new Size(137, 22);
		cp().TabIndex = 6;
		cp().TabStop = false;
		c0().BackColor = Color.Transparent;
		c0().Cursor = Cursors.Default;
		c0().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c0().ForeColor = SystemColors.ControlText;
		c0().Location = new Point(40, 12);
		c0().Name = "_RegionLabel_0";
		c0().RightToLeft = RightToLeft.No;
		c0().Size = new Size(81, 22);
		c0().TabIndex = 106;
		c0().Text = "Layer 0";
		c0().TextAlign = ContentAlignment.MiddleCenter;
		c1().BackColor = SystemColors.Control;
		c1().Cursor = Cursors.Default;
		c1().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		c1().ForeColor = SystemColors.ControlText;
		c1().Image = (Image)componentResourceManager.GetObject("_btnInsertLayer_1.Image");
		c1().Location = new Point(9, 138);
		c1().Name = "_btnInsertLayer_1";
		c1().RightToLeft = RightToLeft.No;
		c1().Size = new Size(24, 27);
		c1().TabIndex = 318;
		c1().TextAlign = ContentAlignment.BottomCenter;
		c1().UseVisualStyleBackColor = false;
		c2().BackColor = Color.Transparent;
		c2().Controls.Add(fe());
		c2().Controls.Add(c3());
		c2().Controls.Add(c4());
		c2().Controls.Add(c5());
		c2().Controls.Add(c6());
		c2().Controls.Add(c7());
		c2().Controls.Add(c9());
		c2().Controls.Add(da());
		c2().Controls.Add(db());
		c2().Controls.Add(dc());
		c2().Controls.Add(dd());
		c2().Controls.Add(de());
		c2().Controls.Add(df());
		c2().Controls.Add(dg());
		c2().Controls.Add(dh());
		c2().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c2().ForeColor = SystemColors.ControlText;
		c2().Location = new Point(41, 150);
		c2().Name = "_FrameLayer_1";
		c2().RightToLeft = RightToLeft.No;
		c2().Size = new Size(945, 45);
		c2().TabIndex = 319;
		c2().TabStop = false;
		fe().AutoSize = true;
		fe().Location = new Point(916, 20);
		fe().Name = "_hideCheck_1";
		fe().Size = new Size(15, 14);
		fe().TabIndex = 322;
		fe().UseVisualStyleBackColor = true;
		fe().Visible = false;
		c6().AutoSize = true;
		c6().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		c6().Location = new Point(705, 18);
		c6().Name = "Label2";
		c6().Size = new Size(18, 16);
		c6().TabIndex = 260;
		c6().Text = "%";
		c7().DropDownStyle = ComboBoxStyle.DropDownList;
		c7().DropDownWidth = 180;
		c7().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c7().FormattingEnabled = true;
		c7().Location = new Point(809, 15);
		c7().Name = "ComboBoxnkModel1";
		c7().Size = new Size(90, 24);
		c7().TabIndex = 259;
		c9().BackColor = Color.Transparent;
		c9().Cursor = Cursors.Default;
		c9().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c9().ForeColor = SystemColors.ControlText;
		c9().Location = new Point(508, 16);
		c9().Name = "_nCheck_1";
		c9().RightToLeft = RightToLeft.No;
		c9().Size = new Size(33, 22);
		c9().TabIndex = 21;
		c9().Text = "n";
		c9().UseVisualStyleBackColor = false;
		c9().Visible = false;
		db().BackColor = Color.Transparent;
		db().Cursor = Cursors.Default;
		db().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		db().ForeColor = SystemColors.ControlText;
		db().Location = new Point(588, 16);
		db().Name = "_rCheck_1";
		db().RightToLeft = RightToLeft.No;
		db().Size = new Size(33, 22);
		db().TabIndex = 23;
		db().Text = "r";
		db().UseVisualStyleBackColor = false;
		db().Visible = false;
		dc().BackColor = Color.Transparent;
		dc().Cursor = Cursors.Default;
		dc().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dc().ForeColor = SystemColors.ControlText;
		dc().Location = new Point(548, 16);
		dc().Name = "_kCheck_1";
		dc().RightToLeft = RightToLeft.No;
		dc().Size = new Size(33, 22);
		dc().TabIndex = 22;
		dc().Text = "k";
		dc().UseVisualStyleBackColor = false;
		dc().Visible = false;
		dd().BackColor = Color.Transparent;
		dd().Cursor = Cursors.Default;
		dd().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dd().ForeColor = SystemColors.ControlText;
		dd().Location = new Point(470, 16);
		dd().Name = "_dCheck_1";
		dd().RightToLeft = RightToLeft.No;
		dd().Size = new Size(33, 22);
		dd().TabIndex = 20;
		dd().Text = "d";
		dd().UseVisualStyleBackColor = false;
		de().BackColor = SystemColors.Control;
		de().Cursor = Cursors.Default;
		de().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		de().ForeColor = SystemColors.ControlText;
		de().Image = (Image)componentResourceManager.GetObject("_MatButton_1.Image");
		de().Location = new Point(247, 16);
		de().Name = "_MatButton_1";
		de().RightToLeft = RightToLeft.No;
		de().Size = new Size(17, 20);
		de().TabIndex = 17;
		de().TextAlign = ContentAlignment.BottomCenter;
		de().UseVisualStyleBackColor = false;
		df().BackColor = SystemColors.Control;
		df().Cursor = Cursors.Default;
		df().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		df().ForeColor = SystemColors.ControlText;
		df().Image = (Image)componentResourceManager.GetObject("_btnDeleteLayer_1.Image");
		df().Location = new Point(8, 12);
		df().Name = "_btnDeleteLayer_1";
		df().RightToLeft = RightToLeft.No;
		df().Size = new Size(25, 24);
		df().TabIndex = 15;
		df().TextAlign = ContentAlignment.BottomCenter;
		df().UseVisualStyleBackColor = false;
		dg().AcceptsReturn = true;
		dg().BackColor = SystemColors.Window;
		dg().Cursor = Cursors.IBeam;
		dg().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		dg().ForeColor = SystemColors.WindowText;
		dg().Location = new Point(128, 15);
		dg().MaxLength = 0;
		dg().Name = "_MatBox_1";
		dg().ReadOnly = true;
		dg().RightToLeft = RightToLeft.No;
		dg().Size = new Size(137, 22);
		dg().TabIndex = 16;
		dg().TabStop = false;
		dh().BackColor = Color.Transparent;
		dh().Cursor = Cursors.Default;
		dh().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dh().ForeColor = SystemColors.ControlText;
		dh().Location = new Point(40, 12);
		dh().Name = "_RegionLabel_1";
		dh().RightToLeft = RightToLeft.No;
		dh().Size = new Size(81, 22);
		dh().TabIndex = 256;
		dh().Text = "Layer 1";
		dh().TextAlign = ContentAlignment.MiddleCenter;
		di().BackColor = Color.Transparent;
		di().Controls.Add(ff());
		di().Controls.Add(dj());
		di().Controls.Add(dk());
		di().Controls.Add(dl());
		di().Controls.Add(dm());
		di().Controls.Add(dn());
		di().Controls.Add(@do());
		di().Controls.Add(dp());
		di().Controls.Add(dq());
		di().Controls.Add(dr());
		di().Controls.Add(ds());
		di().Controls.Add(dt());
		di().Controls.Add(du());
		di().Controls.Add(dv());
		di().Controls.Add(dw());
		di().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		di().ForeColor = SystemColors.ControlText;
		di().Location = new Point(41, 198);
		di().Name = "_FrameLayer_2";
		di().RightToLeft = RightToLeft.No;
		di().Size = new Size(945, 45);
		di().TabIndex = 321;
		di().TabStop = false;
		ff().AutoSize = true;
		ff().Location = new Point(916, 20);
		ff().Name = "_hideCheck_2";
		ff().Size = new Size(15, 14);
		ff().TabIndex = 322;
		ff().UseVisualStyleBackColor = true;
		ff().Visible = false;
		dm().BackColor = Color.Transparent;
		dm().Cursor = Cursors.Default;
		dm().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dm().ForeColor = SystemColors.ControlText;
		dm().Location = new Point(470, 16);
		dm().Name = "_dCheck_2";
		dm().RightToLeft = RightToLeft.No;
		dm().Size = new Size(33, 22);
		dm().TabIndex = 69;
		dm().Text = "d";
		dm().UseVisualStyleBackColor = false;
		dn().AutoSize = true;
		dn().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		dn().Location = new Point(705, 18);
		dn().Name = "Label3";
		dn().Size = new Size(18, 16);
		dn().TabIndex = 270;
		dn().Text = "%";
		@do().BackColor = Color.Transparent;
		@do().Cursor = Cursors.Default;
		@do().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		@do().ForeColor = SystemColors.ControlText;
		@do().Location = new Point(508, 16);
		@do().Name = "_nCheck_2";
		@do().RightToLeft = RightToLeft.No;
		@do().Size = new Size(33, 22);
		@do().TabIndex = 70;
		@do().Text = "n";
		@do().UseVisualStyleBackColor = false;
		@do().Visible = false;
		dp().DropDownStyle = ComboBoxStyle.DropDownList;
		dp().DropDownWidth = 180;
		dp().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dp().FormattingEnabled = true;
		dp().Location = new Point(809, 15);
		dp().Name = "ComboBoxnkModel2";
		dp().Size = new Size(90, 24);
		dp().TabIndex = 269;
		dq().BackColor = Color.Transparent;
		dq().Cursor = Cursors.Default;
		dq().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dq().ForeColor = SystemColors.ControlText;
		dq().Location = new Point(548, 16);
		dq().Name = "_kCheck_2";
		dq().RightToLeft = RightToLeft.No;
		dq().Size = new Size(33, 22);
		dq().TabIndex = 71;
		dq().Text = "k";
		dq().UseVisualStyleBackColor = false;
		dq().Visible = false;
		dr().BackColor = Color.Transparent;
		dr().Cursor = Cursors.Default;
		dr().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dr().ForeColor = SystemColors.ControlText;
		dr().Location = new Point(588, 16);
		dr().Name = "_rCheck_2";
		dr().RightToLeft = RightToLeft.No;
		dr().Size = new Size(33, 22);
		dr().TabIndex = 72;
		dr().Text = "r";
		dr().UseVisualStyleBackColor = false;
		dr().Visible = false;
		dt().BackColor = SystemColors.Control;
		dt().Cursor = Cursors.Default;
		dt().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dt().ForeColor = SystemColors.ControlText;
		dt().Image = (Image)componentResourceManager.GetObject("_MatButton_2.Image");
		dt().Location = new Point(247, 16);
		dt().Name = "_MatButton_2";
		dt().RightToLeft = RightToLeft.No;
		dt().Size = new Size(17, 20);
		dt().TabIndex = 27;
		dt().TextAlign = ContentAlignment.BottomCenter;
		dt().UseVisualStyleBackColor = false;
		du().BackColor = Color.Transparent;
		du().Cursor = Cursors.Default;
		du().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		du().ForeColor = SystemColors.ControlText;
		du().Image = (Image)componentResourceManager.GetObject("_btnDeleteLayer_2.Image");
		du().Location = new Point(8, 12);
		du().Name = "_btnDeleteLayer_2";
		du().RightToLeft = RightToLeft.No;
		du().Size = new Size(25, 24);
		du().TabIndex = 25;
		du().TextAlign = ContentAlignment.BottomCenter;
		du().UseVisualStyleBackColor = false;
		dv().AcceptsReturn = true;
		dv().BackColor = SystemColors.Window;
		dv().Cursor = Cursors.IBeam;
		dv().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		dv().ForeColor = SystemColors.WindowText;
		dv().Location = new Point(128, 15);
		dv().MaxLength = 0;
		dv().Name = "_MatBox_2";
		dv().ReadOnly = true;
		dv().RightToLeft = RightToLeft.No;
		dv().Size = new Size(137, 22);
		dv().TabIndex = 26;
		dv().TabStop = false;
		dw().BackColor = Color.Transparent;
		dw().Cursor = Cursors.Default;
		dw().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dw().ForeColor = SystemColors.ControlText;
		dw().Location = new Point(40, 12);
		dw().Name = "_RegionLabel_2";
		dw().RightToLeft = RightToLeft.No;
		dw().Size = new Size(81, 22);
		dw().TabIndex = 266;
		dw().Text = "Layer 2";
		dw().TextAlign = ContentAlignment.MiddleCenter;
		dx().BackColor = Color.Transparent;
		dx().Controls.Add(fg());
		dx().Controls.Add(dy());
		dx().Controls.Add(dz());
		dx().Controls.Add(d0());
		dx().Controls.Add(d1());
		dx().Controls.Add(d2());
		dx().Controls.Add(d3());
		dx().Controls.Add(d4());
		dx().Controls.Add(d5());
		dx().Controls.Add(d6());
		dx().Controls.Add(d7());
		dx().Controls.Add(d8());
		dx().Controls.Add(d9());
		dx().Controls.Add(ea());
		dx().Controls.Add(eb());
		dx().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dx().ForeColor = SystemColors.ControlText;
		dx().Location = new Point(41, 246);
		dx().Name = "_FrameLayer_3";
		dx().RightToLeft = RightToLeft.No;
		dx().Size = new Size(945, 45);
		dx().TabIndex = 325;
		dx().TabStop = false;
		fg().AutoSize = true;
		fg().Location = new Point(916, 20);
		fg().Name = "_hideCheck_3";
		fg().Size = new Size(15, 14);
		fg().TabIndex = 322;
		fg().UseVisualStyleBackColor = true;
		fg().Visible = false;
		d1().BackColor = Color.Transparent;
		d1().Cursor = Cursors.Default;
		d1().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d1().ForeColor = SystemColors.ControlText;
		d1().Location = new Point(470, 16);
		d1().Name = "_dCheck_3";
		d1().RightToLeft = RightToLeft.No;
		d1().Size = new Size(33, 22);
		d1().TabIndex = 69;
		d1().Text = "d";
		d1().UseVisualStyleBackColor = false;
		d2().AutoSize = true;
		d2().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		d2().Location = new Point(705, 18);
		d2().Name = "Label4";
		d2().Size = new Size(18, 16);
		d2().TabIndex = 280;
		d2().Text = "%";
		d3().BackColor = Color.Transparent;
		d3().Cursor = Cursors.Default;
		d3().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d3().ForeColor = SystemColors.ControlText;
		d3().Location = new Point(508, 16);
		d3().Name = "_nCheck_3";
		d3().RightToLeft = RightToLeft.No;
		d3().Size = new Size(33, 22);
		d3().TabIndex = 70;
		d3().Text = "n";
		d3().UseVisualStyleBackColor = false;
		d3().Visible = false;
		d4().DropDownStyle = ComboBoxStyle.DropDownList;
		d4().DropDownWidth = 180;
		d4().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d4().FormattingEnabled = true;
		d4().Location = new Point(809, 15);
		d4().Name = "ComboBoxnkModel3";
		d4().Size = new Size(90, 24);
		d4().TabIndex = 279;
		d5().BackColor = Color.Transparent;
		d5().Cursor = Cursors.Default;
		d5().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d5().ForeColor = SystemColors.ControlText;
		d5().Location = new Point(548, 16);
		d5().Name = "_kCheck_3";
		d5().RightToLeft = RightToLeft.No;
		d5().Size = new Size(33, 22);
		d5().TabIndex = 71;
		d5().Text = "k";
		d5().UseVisualStyleBackColor = false;
		d5().Visible = false;
		d6().BackColor = Color.Transparent;
		d6().Cursor = Cursors.Default;
		d6().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d6().ForeColor = SystemColors.ControlText;
		d6().Location = new Point(588, 16);
		d6().Name = "_rCheck_3";
		d6().RightToLeft = RightToLeft.No;
		d6().Size = new Size(33, 22);
		d6().TabIndex = 72;
		d6().Text = "r";
		d6().UseVisualStyleBackColor = false;
		d6().Visible = false;
		d8().BackColor = SystemColors.Control;
		d8().Cursor = Cursors.Default;
		d8().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d8().ForeColor = SystemColors.ControlText;
		d8().Image = (Image)componentResourceManager.GetObject("_MatButton_3.Image");
		d8().Location = new Point(247, 16);
		d8().Name = "_MatButton_3";
		d8().RightToLeft = RightToLeft.No;
		d8().Size = new Size(17, 20);
		d8().TabIndex = 37;
		d8().TextAlign = ContentAlignment.BottomCenter;
		d8().UseVisualStyleBackColor = false;
		d9().BackColor = SystemColors.Control;
		d9().Cursor = Cursors.Default;
		d9().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		d9().ForeColor = SystemColors.ControlText;
		d9().Image = (Image)componentResourceManager.GetObject("_btnDeleteLayer_3.Image");
		d9().Location = new Point(8, 12);
		d9().Name = "_btnDeleteLayer_3";
		d9().RightToLeft = RightToLeft.No;
		d9().Size = new Size(25, 24);
		d9().TabIndex = 35;
		d9().TextAlign = ContentAlignment.BottomCenter;
		d9().UseVisualStyleBackColor = false;
		ea().AcceptsReturn = true;
		ea().BackColor = SystemColors.Window;
		ea().Cursor = Cursors.IBeam;
		ea().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ea().ForeColor = SystemColors.WindowText;
		ea().Location = new Point(128, 15);
		ea().MaxLength = 0;
		ea().Name = "_MatBox_3";
		ea().ReadOnly = true;
		ea().RightToLeft = RightToLeft.No;
		ea().Size = new Size(137, 22);
		ea().TabIndex = 36;
		ea().TabStop = false;
		eb().BackColor = Color.Transparent;
		eb().Cursor = Cursors.Default;
		eb().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		eb().ForeColor = SystemColors.ControlText;
		eb().Location = new Point(40, 12);
		eb().Name = "_RegionLabel_3";
		eb().RightToLeft = RightToLeft.No;
		eb().Size = new Size(81, 22);
		eb().TabIndex = 276;
		eb().Text = "Layer 3";
		eb().TextAlign = ContentAlignment.MiddleCenter;
		ec().BackColor = Color.Transparent;
		ec().Controls.Add(fh());
		ec().Controls.Add(ed());
		ec().Controls.Add(ee());
		ec().Controls.Add(ef());
		ec().Controls.Add(eg());
		ec().Controls.Add(eh());
		ec().Controls.Add(ei());
		ec().Controls.Add(ej());
		ec().Controls.Add(ek());
		ec().Controls.Add(el());
		ec().Controls.Add(em());
		ec().Controls.Add(en());
		ec().Controls.Add(eo());
		ec().Controls.Add(ep());
		ec().Controls.Add(eq());
		ec().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ec().ForeColor = SystemColors.ControlText;
		ec().Location = new Point(41, 294);
		ec().Name = "_FrameLayer_4";
		ec().RightToLeft = RightToLeft.No;
		ec().Size = new Size(945, 45);
		ec().TabIndex = 328;
		ec().TabStop = false;
		fh().AutoSize = true;
		fh().Location = new Point(916, 20);
		fh().Name = "_hideCheck_4";
		fh().Size = new Size(15, 14);
		fh().TabIndex = 322;
		fh().UseVisualStyleBackColor = true;
		fh().Visible = false;
		eg().BackColor = Color.Transparent;
		eg().Cursor = Cursors.Default;
		eg().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		eg().ForeColor = SystemColors.ControlText;
		eg().Location = new Point(470, 16);
		eg().Name = "_dCheck_4";
		eg().RightToLeft = RightToLeft.No;
		eg().Size = new Size(33, 22);
		eg().TabIndex = 69;
		eg().Text = "d";
		eg().UseVisualStyleBackColor = false;
		eh().AutoSize = true;
		eh().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		eh().Location = new Point(705, 18);
		eh().Name = "Label5";
		eh().Size = new Size(18, 16);
		eh().TabIndex = 290;
		eh().Text = "%";
		ei().BackColor = Color.Transparent;
		ei().Cursor = Cursors.Default;
		ei().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ei().ForeColor = SystemColors.ControlText;
		ei().Location = new Point(508, 16);
		ei().Name = "_nCheck_4";
		ei().RightToLeft = RightToLeft.No;
		ei().Size = new Size(33, 22);
		ei().TabIndex = 70;
		ei().Text = "n";
		ei().UseVisualStyleBackColor = false;
		ei().Visible = false;
		ej().DropDownStyle = ComboBoxStyle.DropDownList;
		ej().DropDownWidth = 180;
		ej().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ej().FormattingEnabled = true;
		ej().Location = new Point(809, 15);
		ej().Name = "ComboBoxnkModel4";
		ej().Size = new Size(90, 24);
		ej().TabIndex = 289;
		ek().BackColor = Color.Transparent;
		ek().Cursor = Cursors.Default;
		ek().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ek().ForeColor = SystemColors.ControlText;
		ek().Location = new Point(548, 16);
		ek().Name = "_kCheck_4";
		ek().RightToLeft = RightToLeft.No;
		ek().Size = new Size(33, 22);
		ek().TabIndex = 71;
		ek().Text = "k";
		ek().UseVisualStyleBackColor = false;
		ek().Visible = false;
		el().BackColor = Color.Transparent;
		el().Cursor = Cursors.Default;
		el().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		el().ForeColor = SystemColors.ControlText;
		el().Location = new Point(588, 16);
		el().Name = "_rCheck_4";
		el().RightToLeft = RightToLeft.No;
		el().Size = new Size(33, 22);
		el().TabIndex = 72;
		el().Text = "r";
		el().UseVisualStyleBackColor = false;
		el().Visible = false;
		en().BackColor = SystemColors.Control;
		en().Cursor = Cursors.Default;
		en().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		en().ForeColor = SystemColors.ControlText;
		en().Image = (Image)componentResourceManager.GetObject("_MatButton_4.Image");
		en().Location = new Point(247, 16);
		en().Name = "_MatButton_4";
		en().RightToLeft = RightToLeft.No;
		en().Size = new Size(17, 20);
		en().TabIndex = 47;
		en().TextAlign = ContentAlignment.BottomCenter;
		en().UseVisualStyleBackColor = false;
		eo().BackColor = SystemColors.Control;
		eo().Cursor = Cursors.Default;
		eo().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		eo().ForeColor = SystemColors.ControlText;
		eo().Image = (Image)componentResourceManager.GetObject("_btnDeleteLayer_4.Image");
		eo().Location = new Point(8, 12);
		eo().Name = "_btnDeleteLayer_4";
		eo().RightToLeft = RightToLeft.No;
		eo().Size = new Size(25, 24);
		eo().TabIndex = 45;
		eo().TextAlign = ContentAlignment.BottomCenter;
		eo().UseVisualStyleBackColor = false;
		ep().AcceptsReturn = true;
		ep().BackColor = SystemColors.Window;
		ep().Cursor = Cursors.IBeam;
		ep().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ep().ForeColor = SystemColors.WindowText;
		ep().Location = new Point(128, 15);
		ep().MaxLength = 0;
		ep().Name = "_MatBox_4";
		ep().ReadOnly = true;
		ep().RightToLeft = RightToLeft.No;
		ep().Size = new Size(137, 22);
		ep().TabIndex = 46;
		ep().TabStop = false;
		eq().BackColor = Color.Transparent;
		eq().Cursor = Cursors.Default;
		eq().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		eq().ForeColor = SystemColors.ControlText;
		eq().Location = new Point(40, 12);
		eq().Name = "_RegionLabel_4";
		eq().RightToLeft = RightToLeft.No;
		eq().Size = new Size(81, 22);
		eq().TabIndex = 286;
		eq().Text = "Layer 4";
		eq().TextAlign = ContentAlignment.MiddleCenter;
		er().BackColor = Color.Transparent;
		er().Controls.Add(fi());
		er().Controls.Add(es());
		er().Controls.Add(et());
		er().Controls.Add(eu());
		er().Controls.Add(ev());
		er().Controls.Add(ew());
		er().Controls.Add(ex());
		er().Controls.Add(ey());
		er().Controls.Add(ez());
		er().Controls.Add(e0());
		er().Controls.Add(e1());
		er().Controls.Add(e2());
		er().Controls.Add(e3());
		er().Controls.Add(e4());
		er().Controls.Add(e5());
		er().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		er().ForeColor = SystemColors.ControlText;
		er().Location = new Point(41, 342);
		er().Name = "_FrameLayer_5";
		er().RightToLeft = RightToLeft.No;
		er().Size = new Size(945, 45);
		er().TabIndex = 330;
		er().TabStop = false;
		fi().AutoSize = true;
		fi().Location = new Point(916, 20);
		fi().Name = "_hideCheck_5";
		fi().Size = new Size(15, 14);
		fi().TabIndex = 322;
		fi().UseVisualStyleBackColor = true;
		fi().Visible = false;
		ev().BackColor = Color.Transparent;
		ev().Cursor = Cursors.Default;
		ev().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ev().ForeColor = SystemColors.ControlText;
		ev().Location = new Point(470, 16);
		ev().Name = "_dCheck_5";
		ev().RightToLeft = RightToLeft.No;
		ev().Size = new Size(33, 22);
		ev().TabIndex = 69;
		ev().Text = "d";
		ev().UseVisualStyleBackColor = false;
		ew().AutoSize = true;
		ew().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ew().Location = new Point(705, 18);
		ew().Name = "Label6";
		ew().Size = new Size(18, 16);
		ew().TabIndex = 300;
		ew().Text = "%";
		ex().BackColor = Color.Transparent;
		ex().Cursor = Cursors.Default;
		ex().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ex().ForeColor = SystemColors.ControlText;
		ex().Location = new Point(508, 16);
		ex().Name = "_nCheck_5";
		ex().RightToLeft = RightToLeft.No;
		ex().Size = new Size(33, 22);
		ex().TabIndex = 70;
		ex().Text = "n";
		ex().UseVisualStyleBackColor = false;
		ex().Visible = false;
		ey().BackColor = Color.Transparent;
		ey().Cursor = Cursors.Default;
		ey().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ey().ForeColor = SystemColors.ControlText;
		ey().Location = new Point(548, 16);
		ey().Name = "_kCheck_5";
		ey().RightToLeft = RightToLeft.No;
		ey().Size = new Size(33, 22);
		ey().TabIndex = 71;
		ey().Text = "k";
		ey().UseVisualStyleBackColor = false;
		ey().Visible = false;
		ez().DropDownStyle = ComboBoxStyle.DropDownList;
		ez().DropDownWidth = 180;
		ez().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ez().FormattingEnabled = true;
		ez().Location = new Point(809, 15);
		ez().Name = "ComboBoxnkModel5";
		ez().Size = new Size(90, 24);
		ez().TabIndex = 299;
		e0().BackColor = Color.Transparent;
		e0().Cursor = Cursors.Default;
		e0().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e0().ForeColor = SystemColors.ControlText;
		e0().Location = new Point(588, 16);
		e0().Name = "_rCheck_5";
		e0().RightToLeft = RightToLeft.No;
		e0().Size = new Size(33, 22);
		e0().TabIndex = 72;
		e0().Text = "r";
		e0().UseVisualStyleBackColor = false;
		e0().Visible = false;
		e2().BackColor = SystemColors.Control;
		e2().Cursor = Cursors.Default;
		e2().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e2().ForeColor = SystemColors.ControlText;
		e2().Image = (Image)componentResourceManager.GetObject("_MatButton_5.Image");
		e2().Location = new Point(247, 16);
		e2().Name = "_MatButton_5";
		e2().RightToLeft = RightToLeft.No;
		e2().Size = new Size(17, 20);
		e2().TabIndex = 57;
		e2().TextAlign = ContentAlignment.BottomCenter;
		e2().UseVisualStyleBackColor = false;
		e3().BackColor = SystemColors.Control;
		e3().Cursor = Cursors.Default;
		e3().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		e3().ForeColor = SystemColors.ControlText;
		e3().Image = (Image)componentResourceManager.GetObject("_btnDeleteLayer_5.Image");
		e3().Location = new Point(8, 12);
		e3().Name = "_btnDeleteLayer_5";
		e3().RightToLeft = RightToLeft.No;
		e3().Size = new Size(25, 24);
		e3().TabIndex = 55;
		e3().TextAlign = ContentAlignment.BottomCenter;
		e3().UseVisualStyleBackColor = false;
		e4().AcceptsReturn = true;
		e4().BackColor = SystemColors.Window;
		e4().Cursor = Cursors.IBeam;
		e4().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		e4().ForeColor = SystemColors.WindowText;
		e4().Location = new Point(128, 15);
		e4().MaxLength = 0;
		e4().Name = "_MatBox_5";
		e4().ReadOnly = true;
		e4().RightToLeft = RightToLeft.No;
		e4().Size = new Size(137, 22);
		e4().TabIndex = 56;
		e4().TabStop = false;
		e5().BackColor = Color.Transparent;
		e5().Cursor = Cursors.Default;
		e5().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e5().ForeColor = SystemColors.ControlText;
		e5().Location = new Point(40, 12);
		e5().Name = "_RegionLabel_5";
		e5().RightToLeft = RightToLeft.No;
		e5().Size = new Size(81, 22);
		e5().TabIndex = 296;
		e5().Text = "Substrate";
		e5().TextAlign = ContentAlignment.MiddleCenter;
		e6().BackColor = SystemColors.Control;
		e6().Cursor = Cursors.Default;
		e6().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		e6().ForeColor = SystemColors.ControlText;
		e6().Image = (Image)componentResourceManager.GetObject("_btnInsertLayer_2.Image");
		e6().Location = new Point(9, 186);
		e6().Name = "_btnInsertLayer_2";
		e6().RightToLeft = RightToLeft.No;
		e6().Size = new Size(24, 27);
		e6().TabIndex = 320;
		e6().TextAlign = ContentAlignment.BottomCenter;
		e6().UseVisualStyleBackColor = false;
		e7().BackColor = SystemColors.Control;
		e7().Cursor = Cursors.Default;
		e7().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		e7().ForeColor = SystemColors.ControlText;
		e7().Image = (Image)componentResourceManager.GetObject("_btnInsertLayer_3.Image");
		e7().Location = new Point(9, 234);
		e7().Name = "_btnInsertLayer_3";
		e7().RightToLeft = RightToLeft.No;
		e7().Size = new Size(24, 27);
		e7().TabIndex = 324;
		e7().TextAlign = ContentAlignment.BottomCenter;
		e7().UseVisualStyleBackColor = false;
		e8().BackColor = SystemColors.Control;
		e8().Cursor = Cursors.Default;
		e8().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		e8().ForeColor = SystemColors.ControlText;
		e8().Image = (Image)componentResourceManager.GetObject("_btnInsertLayer_4.Image");
		e8().Location = new Point(9, 282);
		e8().Name = "_btnInsertLayer_4";
		e8().RightToLeft = RightToLeft.No;
		e8().Size = new Size(24, 27);
		e8().TabIndex = 326;
		e8().TextAlign = ContentAlignment.BottomCenter;
		e8().UseVisualStyleBackColor = false;
		e9().BackColor = SystemColors.Control;
		e9().Cursor = Cursors.Default;
		e9().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		e9().ForeColor = SystemColors.ControlText;
		e9().Image = (Image)componentResourceManager.GetObject("_btnInsertLayer_5.Image");
		e9().Location = new Point(9, 330);
		e9().Name = "_btnInsertLayer_5";
		e9().RightToLeft = RightToLeft.No;
		e9().Size = new Size(24, 27);
		e9().TabIndex = 329;
		e9().TextAlign = ContentAlignment.BottomCenter;
		e9().UseVisualStyleBackColor = false;
		fa().BackColor = SystemColors.Control;
		fa().Cursor = Cursors.Default;
		fa().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		fa().ForeColor = SystemColors.ControlText;
		fa().Image = (Image)componentResourceManager.GetObject("_btnInsertLayer_6.Image");
		fa().Location = new Point(9, 378);
		fa().Name = "_btnInsertLayer_6";
		fa().RightToLeft = RightToLeft.No;
		fa().Size = new Size(24, 27);
		fa().TabIndex = 331;
		fa().TextAlign = ContentAlignment.BottomCenter;
		fa().UseVisualStyleBackColor = false;
		fb().BackColor = SystemColors.InactiveBorder;
		fb().Location = new Point(41, 91);
		fb().Name = "Line1";
		fb().Size = new Size(950, 4);
		fb().TabIndex = 315;
		bv().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bv().f(A_0: false);
		bv().Location = new Point(737, 15);
		bv().Name = "_NBox_0";
		bv().e(A_0: false);
		bv().Size = new Size(58, 22);
		bv().TabIndex = 320;
		bv().TextAlign = HorizontalAlignment.Right;
		b1().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		b1().f(A_0: false);
		b1().Location = new Point(381, 15);
		b1().Name = "_RText_0";
		b1().e(A_0: false);
		b1().Size = new Size(65, 22);
		b1().TabIndex = 319;
		b1().TextAlign = HorizontalAlignment.Right;
		b2().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		b2().f(A_0: false);
		b2().Location = new Point(276, 15);
		b2().Name = "_dText_0";
		b2().e(A_0: false);
		b2().Size = new Size(85, 22);
		b2().TabIndex = 318;
		b2().TextAlign = HorizontalAlignment.Right;
		ci().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ci().f(A_0: false);
		ci().Location = new Point(633, 15);
		ci().Name = "_TBox_0";
		ci().e(A_0: false);
		ci().Size = new Size(71, 22);
		ci().TabIndex = 107;
		ci().TextAlign = HorizontalAlignment.Right;
		c3().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		c3().f(A_0: false);
		c3().Location = new Point(737, 15);
		c3().Name = "_NBox_1";
		c3().e(A_0: false);
		c3().Size = new Size(58, 22);
		c3().TabIndex = 321;
		c3().TextAlign = HorizontalAlignment.Right;
		c4().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		c4().f(A_0: false);
		c4().Location = new Point(381, 15);
		c4().Name = "_RText_1";
		c4().e(A_0: false);
		c4().Size = new Size(65, 22);
		c4().TabIndex = 262;
		c4().TextAlign = HorizontalAlignment.Right;
		c5().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		c5().f(A_0: false);
		c5().Location = new Point(276, 15);
		c5().Name = "_dText_1";
		c5().e(A_0: false);
		c5().Size = new Size(85, 22);
		c5().TabIndex = 261;
		c5().TextAlign = HorizontalAlignment.Right;
		da().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		da().f(A_0: false);
		da().Location = new Point(633, 15);
		da().Name = "_TBox_1";
		da().e(A_0: false);
		da().Size = new Size(71, 22);
		da().TabIndex = 257;
		da().TextAlign = HorizontalAlignment.Right;
		dj().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		dj().f(A_0: false);
		dj().Location = new Point(737, 15);
		dj().Name = "_NBox_2";
		dj().e(A_0: false);
		dj().Size = new Size(58, 22);
		dj().TabIndex = 321;
		dj().TextAlign = HorizontalAlignment.Right;
		dk().AcceptsReturn = true;
		dk().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		dk().f(A_0: false);
		dk().Location = new Point(381, 15);
		dk().Name = "_RText_2";
		dk().e(A_0: false);
		dk().Size = new Size(65, 22);
		dk().TabIndex = 272;
		dk().TextAlign = HorizontalAlignment.Right;
		dl().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		dl().f(A_0: false);
		dl().Location = new Point(276, 15);
		dl().Name = "_dText_2";
		dl().e(A_0: false);
		dl().Size = new Size(85, 22);
		dl().TabIndex = 271;
		dl().TextAlign = HorizontalAlignment.Right;
		ds().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ds().f(A_0: false);
		ds().Location = new Point(633, 15);
		ds().Name = "_TBox_2";
		ds().e(A_0: false);
		ds().Size = new Size(71, 22);
		ds().TabIndex = 267;
		ds().TextAlign = HorizontalAlignment.Right;
		dy().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		dy().f(A_0: false);
		dy().Location = new Point(737, 15);
		dy().Name = "_NBox_3";
		dy().e(A_0: false);
		dy().Size = new Size(58, 22);
		dy().TabIndex = 321;
		dy().TextAlign = HorizontalAlignment.Right;
		dz().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		dz().f(A_0: false);
		dz().Location = new Point(381, 15);
		dz().Name = "_RText_3";
		dz().e(A_0: false);
		dz().Size = new Size(65, 22);
		dz().TabIndex = 282;
		dz().TextAlign = HorizontalAlignment.Right;
		d0().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		d0().f(A_0: false);
		d0().Location = new Point(276, 15);
		d0().Name = "_dText_3";
		d0().e(A_0: false);
		d0().Size = new Size(85, 22);
		d0().TabIndex = 281;
		d0().TextAlign = HorizontalAlignment.Right;
		d7().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		d7().f(A_0: false);
		d7().Location = new Point(633, 15);
		d7().Name = "_TBox_3";
		d7().e(A_0: false);
		d7().Size = new Size(71, 22);
		d7().TabIndex = 277;
		d7().TextAlign = HorizontalAlignment.Right;
		ed().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ed().f(A_0: false);
		ed().Location = new Point(737, 15);
		ed().Name = "_NBox_4";
		ed().e(A_0: false);
		ed().Size = new Size(58, 22);
		ed().TabIndex = 321;
		ed().TextAlign = HorizontalAlignment.Right;
		ee().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ee().f(A_0: false);
		ee().Location = new Point(381, 15);
		ee().Name = "_RText_4";
		ee().e(A_0: false);
		ee().Size = new Size(65, 22);
		ee().TabIndex = 292;
		ee().TextAlign = HorizontalAlignment.Right;
		ef().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ef().f(A_0: false);
		ef().Location = new Point(276, 15);
		ef().Name = "_dText_4";
		ef().e(A_0: false);
		ef().Size = new Size(85, 22);
		ef().TabIndex = 291;
		ef().TextAlign = HorizontalAlignment.Right;
		em().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		em().f(A_0: false);
		em().Location = new Point(633, 15);
		em().Name = "_TBox_4";
		em().e(A_0: false);
		em().Size = new Size(71, 22);
		em().TabIndex = 287;
		em().TextAlign = HorizontalAlignment.Right;
		es().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		es().f(A_0: false);
		es().Location = new Point(737, 15);
		es().Name = "_NBox_5";
		es().e(A_0: false);
		es().Size = new Size(58, 22);
		es().TabIndex = 321;
		es().TextAlign = HorizontalAlignment.Right;
		et().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		et().f(A_0: false);
		et().Location = new Point(381, 15);
		et().Name = "_RText_5";
		et().e(A_0: false);
		et().Size = new Size(65, 22);
		et().TabIndex = 302;
		et().TextAlign = HorizontalAlignment.Right;
		eu().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		eu().f(A_0: false);
		eu().Location = new Point(276, 15);
		eu().Name = "_dText_5";
		eu().e(A_0: false);
		eu().Size = new Size(85, 22);
		eu().TabIndex = 301;
		eu().TextAlign = HorizontalAlignment.Right;
		e1().Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		e1().f(A_0: false);
		e1().Location = new Point(633, 15);
		e1().Name = "_TBox_5";
		e1().e(A_0: false);
		e1().Size = new Size(71, 22);
		e1().TabIndex = 297;
		e1().TextAlign = HorizontalAlignment.Right;
		base.AcceptButton = a9();
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = a8();
		base.ClientSize = new Size(1015, 535);
		base.Controls.Add(r());
		base.MaximizeBox = false;
		MaximumSize = new Size(1050, 600);
		base.MinimizeBox = false;
		MinimumSize = new Size(640, 480);
		base.Name = "DialogEditLayerStack";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Edit Layer Stack";
		r().ResumeLayout(performLayout: false);
		r().PerformLayout();
		av().ResumeLayout(performLayout: false);
		bs().ResumeLayout(performLayout: false);
		bs().PerformLayout();
		c2().ResumeLayout(performLayout: false);
		c2().PerformLayout();
		di().ResumeLayout(performLayout: false);
		di().PerformLayout();
		dx().ResumeLayout(performLayout: false);
		dx().PerformLayout();
		ec().ResumeLayout(performLayout: false);
		ec().PerformLayout();
		er().ResumeLayout(performLayout: false);
		er().PerformLayout();
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox p()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TextBox A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip q()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolTip A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel r()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Panel A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label s()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label t()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b(Label A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox ac()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
	{
		EventHandler value = ad;
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
	internal virtual Label ad()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ae()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ag()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aj()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Label A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label al()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Label A_0)
	{
		l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label @as()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void i(Label A_0)
	{
		m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label at()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void j(Label A_0)
	{
		n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label au()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void k(Label A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox av()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(GroupBox A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button aw()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = g;
		Button button = this.m_q;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_q = A_0;
		button = this.m_q;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ay()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = au;
		Button button = this.m_r;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_r = A_0;
		button = this.m_r;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button a7()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = at;
		Button button = this.m_s;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_s = A_0;
		button = this.m_s;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button a8()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Button A_0)
	{
		EventHandler value = al;
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
	internal virtual Button a9()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Button A_0)
	{
		EventHandler value = @as;
		Button button = u;
		if (button != null)
		{
			button.Click -= value;
		}
		u = A_0;
		button = u;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual VScrollBar bb()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a(VScrollBar A_0)
	{
		EventHandler value = ae;
		VScrollBar vScrollBar = v;
		if (vScrollBar != null)
		{
			vScrollBar.ValueChanged -= value;
		}
		v = A_0;
		vScrollBar = v;
		if (vScrollBar != null)
		{
			vScrollBar.ValueChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button bd()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void g(Button A_0)
	{
		EventHandler value = aj;
		Button button = w;
		if (button != null)
		{
			button.Click -= value;
		}
		w = A_0;
		button = w;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label bg()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void o(Label A_0)
	{
		x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label bm()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void p(Label A_0)
	{
		y = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label bn()
	{
		return z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void q(Label A_0)
	{
		z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label bo()
	{
		return aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void r(Label A_0)
	{
		aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label bq()
	{
		return ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void s(Label A_0)
	{
		ab = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox bs()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b(GroupBox A_0)
	{
		this.m_ac = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy bv()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hy A_0)
	{
		EventHandler value = r;
		hy hy2 = this.m_ad;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_ad = A_0;
		hy2 = this.m_ad;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy b1()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(hy A_0)
	{
		EventHandler value = t;
		hy hy2 = this.m_ae;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_ae = A_0;
		hy2 = this.m_ae;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy b2()
	{
		return af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(hy A_0)
	{
		EventHandler value = ac;
		hy hy2 = af;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		af = A_0;
		hy2 = af;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox b3()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a(CheckBox A_0)
	{
		EventHandler value = k;
		CheckBox checkBox = this.m_ag;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_ag = A_0;
		checkBox = this.m_ag;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b5()
	{
		return ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(Label A_0)
	{
		ah = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox b7()
	{
		return ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b(CheckBox A_0)
	{
		EventHandler value = o;
		CheckBox checkBox = ai;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		ai = A_0;
		checkBox = ai;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox ca()
	{
		return this.m_aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c(CheckBox A_0)
	{
		EventHandler value = p;
		CheckBox checkBox = this.m_aj;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_aj = A_0;
		checkBox = this.m_aj;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox cg()
	{
		return ak;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ComboBox A_0)
	{
		EventHandler value = j;
		ComboBox comboBox = ak;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		ak = A_0;
		comboBox = ak;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox ch()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void d(CheckBox A_0)
	{
		EventHandler value = q;
		CheckBox checkBox = this.m_al;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_al = A_0;
		checkBox = this.m_al;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ci()
	{
		return am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(hy A_0)
	{
		EventHandler value = s;
		hy hy2 = am;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		am = A_0;
		hy2 = am;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ck()
	{
		return an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void h(Button A_0)
	{
		EventHandler value = av;
		Button button = an;
		if (button != null)
		{
			button.Click -= value;
		}
		an = A_0;
		button = an;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button cn()
	{
		return ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void i(Button A_0)
	{
		EventHandler value = ag;
		Button button = ao;
		if (button != null)
		{
			button.Click -= value;
		}
		ao = A_0;
		button = ao;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual TextBox cp()
	{
		return ap;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b(TextBox A_0)
	{
		EventHandler value = i;
		EventHandler value2 = h;
		TextBox textBox = ap;
		if (textBox != null)
		{
			textBox.Click -= value;
			textBox.TextChanged -= value2;
		}
		ap = A_0;
		textBox = ap;
		if (textBox != null)
		{
			textBox.Click += value;
			textBox.TextChanged += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label c0()
	{
		return aq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ac(Label A_0)
	{
		aq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button c1()
	{
		return ar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void j(Button A_0)
	{
		EventHandler value = aj;
		Button button = ar;
		if (button != null)
		{
			button.Click -= value;
		}
		ar = A_0;
		button = ar;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox c2()
	{
		return this.m_as;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c(GroupBox A_0)
	{
		this.m_as = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy c3()
	{
		return this.m_at;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(hy A_0)
	{
		EventHandler value = r;
		hy hy2 = this.m_at;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_at = A_0;
		hy2 = this.m_at;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy c4()
	{
		return this.m_au;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(hy A_0)
	{
		EventHandler value = t;
		hy hy2 = this.m_au;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_au = A_0;
		hy2 = this.m_au;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy c5()
	{
		return this.m_av;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(hy A_0)
	{
		EventHandler value = ac;
		hy hy2 = this.m_av;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_av = A_0;
		hy2 = this.m_av;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c6()
	{
		return this.m_aw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(Label A_0)
	{
		this.m_aw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox c7()
	{
		return ax;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ComboBox A_0)
	{
		EventHandler value = j;
		ComboBox comboBox = ax;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		ax = A_0;
		comboBox = ax;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox c9()
	{
		return this.m_ay;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void f(CheckBox A_0)
	{
		EventHandler value = p;
		CheckBox checkBox = this.m_ay;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_ay = A_0;
		checkBox = this.m_ay;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy da()
	{
		return az;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(hy A_0)
	{
		EventHandler value = s;
		hy hy2 = az;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		az = A_0;
		hy2 = az;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox db()
	{
		return a0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void g(CheckBox A_0)
	{
		EventHandler value = k;
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
	public virtual CheckBox dc()
	{
		return a1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void h(CheckBox A_0)
	{
		EventHandler value = o;
		CheckBox checkBox = a1;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		a1 = A_0;
		checkBox = a1;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox dd()
	{
		return a2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void i(CheckBox A_0)
	{
		EventHandler value = q;
		CheckBox checkBox = a2;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		a2 = A_0;
		checkBox = a2;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button de()
	{
		return a3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void k(Button A_0)
	{
		EventHandler value = av;
		Button button = a3;
		if (button != null)
		{
			button.Click -= value;
		}
		a3 = A_0;
		button = a3;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button df()
	{
		return a4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void o(Button A_0)
	{
		EventHandler value = ag;
		Button button = a4;
		if (button != null)
		{
			button.Click -= value;
		}
		a4 = A_0;
		button = a4;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual TextBox dg()
	{
		return a5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c(TextBox A_0)
	{
		EventHandler value = i;
		EventHandler value2 = h;
		TextBox textBox = a5;
		if (textBox != null)
		{
			textBox.Click -= value;
			textBox.TextChanged -= value2;
		}
		a5 = A_0;
		textBox = a5;
		if (textBox != null)
		{
			textBox.Click += value;
			textBox.TextChanged += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label dh()
	{
		return a6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ae(Label A_0)
	{
		a6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox di()
	{
		return this.m_a7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void d(GroupBox A_0)
	{
		this.m_a7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy dj()
	{
		return this.m_a8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(hy A_0)
	{
		EventHandler value = r;
		hy hy2 = this.m_a8;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_a8 = A_0;
		hy2 = this.m_a8;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy dk()
	{
		return this.m_a9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(hy A_0)
	{
		EventHandler value = t;
		hy hy2 = this.m_a9;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_a9 = A_0;
		hy2 = this.m_a9;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy dl()
	{
		return ba;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(hy A_0)
	{
		EventHandler value = ac;
		hy hy2 = ba;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		ba = A_0;
		hy2 = ba;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox dm()
	{
		return this.m_bb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void j(CheckBox A_0)
	{
		EventHandler value = q;
		CheckBox checkBox = this.m_bb;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_bb = A_0;
		checkBox = this.m_bb;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label dn()
	{
		return bc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ag(Label A_0)
	{
		bc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox @do()
	{
		return this.m_bd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void k(CheckBox A_0)
	{
		EventHandler value = p;
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
	internal virtual ComboBox dp()
	{
		return be;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(ComboBox A_0)
	{
		EventHandler value = j;
		ComboBox comboBox = be;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		be = A_0;
		comboBox = be;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox dq()
	{
		return bf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void o(CheckBox A_0)
	{
		EventHandler value = o;
		CheckBox checkBox = bf;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		bf = A_0;
		checkBox = bf;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox dr()
	{
		return this.m_bg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void p(CheckBox A_0)
	{
		EventHandler value = k;
		CheckBox checkBox = this.m_bg;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_bg = A_0;
		checkBox = this.m_bg;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ds()
	{
		return bh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(hy A_0)
	{
		EventHandler value = s;
		hy hy2 = bh;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		bh = A_0;
		hy2 = bh;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button dt()
	{
		return bi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void p(Button A_0)
	{
		EventHandler value = av;
		Button button = bi;
		if (button != null)
		{
			button.Click -= value;
		}
		bi = A_0;
		button = bi;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button du()
	{
		return bj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void q(Button A_0)
	{
		EventHandler value = ag;
		Button button = bj;
		if (button != null)
		{
			button.Click -= value;
		}
		bj = A_0;
		button = bj;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual TextBox dv()
	{
		return bk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void d(TextBox A_0)
	{
		EventHandler value = i;
		EventHandler value2 = h;
		TextBox textBox = bk;
		if (textBox != null)
		{
			textBox.Click -= value;
			textBox.TextChanged -= value2;
		}
		bk = A_0;
		textBox = bk;
		if (textBox != null)
		{
			textBox.Click += value;
			textBox.TextChanged += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label dw()
	{
		return bl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aj(Label A_0)
	{
		bl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox dx()
	{
		return this.m_bm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void f(GroupBox A_0)
	{
		this.m_bm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy dy()
	{
		return this.m_bn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(hy A_0)
	{
		EventHandler value = r;
		hy hy2 = this.m_bn;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_bn = A_0;
		hy2 = this.m_bn;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy dz()
	{
		return this.m_bo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(hy A_0)
	{
		EventHandler value = t;
		hy hy2 = this.m_bo;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_bo = A_0;
		hy2 = this.m_bo;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy d0()
	{
		return bp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(hy A_0)
	{
		EventHandler value = ac;
		hy hy2 = bp;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		bp = A_0;
		hy2 = bp;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox d1()
	{
		return this.m_bq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void q(CheckBox A_0)
	{
		EventHandler value = q;
		CheckBox checkBox = this.m_bq;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_bq = A_0;
		checkBox = this.m_bq;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label d2()
	{
		return br;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void al(Label A_0)
	{
		br = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox d3()
	{
		return this.m_bs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void r(CheckBox A_0)
	{
		EventHandler value = p;
		CheckBox checkBox = this.m_bs;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_bs = A_0;
		checkBox = this.m_bs;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox d4()
	{
		return bt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(ComboBox A_0)
	{
		EventHandler value = j;
		ComboBox comboBox = bt;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		bt = A_0;
		comboBox = bt;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox d5()
	{
		return bu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void s(CheckBox A_0)
	{
		EventHandler value = o;
		CheckBox checkBox = bu;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		bu = A_0;
		checkBox = bu;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox d6()
	{
		return this.m_bv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void t(CheckBox A_0)
	{
		EventHandler value = k;
		CheckBox checkBox = this.m_bv;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_bv = A_0;
		checkBox = this.m_bv;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy d7()
	{
		return bw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(hy A_0)
	{
		EventHandler value = s;
		hy hy2 = bw;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		bw = A_0;
		hy2 = bw;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button d8()
	{
		return bx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void r(Button A_0)
	{
		EventHandler value = av;
		Button button = bx;
		if (button != null)
		{
			button.Click -= value;
		}
		bx = A_0;
		button = bx;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button d9()
	{
		return by;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void s(Button A_0)
	{
		EventHandler value = ag;
		Button button = by;
		if (button != null)
		{
			button.Click -= value;
		}
		by = A_0;
		button = by;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual TextBox ea()
	{
		return bz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void f(TextBox A_0)
	{
		EventHandler value = i;
		EventHandler value2 = h;
		TextBox textBox = bz;
		if (textBox != null)
		{
			textBox.Click -= value;
			textBox.TextChanged -= value2;
		}
		bz = A_0;
		textBox = bz;
		if (textBox != null)
		{
			textBox.Click += value;
			textBox.TextChanged += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label eb()
	{
		return b0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void @as(Label A_0)
	{
		b0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox ec()
	{
		return this.m_b1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void g(GroupBox A_0)
	{
		this.m_b1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ed()
	{
		return this.m_b2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(hy A_0)
	{
		EventHandler value = r;
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
	internal virtual hy ee()
	{
		return this.m_b3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(hy A_0)
	{
		EventHandler value = t;
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
	internal virtual hy ef()
	{
		return b4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ae(hy A_0)
	{
		EventHandler value = ac;
		hy hy2 = b4;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		b4 = A_0;
		hy2 = b4;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox eg()
	{
		return this.m_b5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ac(CheckBox A_0)
	{
		EventHandler value = q;
		CheckBox checkBox = this.m_b5;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_b5 = A_0;
		checkBox = this.m_b5;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label eh()
	{
		return b6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void at(Label A_0)
	{
		b6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox ei()
	{
		return this.m_b7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ad(CheckBox A_0)
	{
		EventHandler value = p;
		CheckBox checkBox = this.m_b7;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_b7 = A_0;
		checkBox = this.m_b7;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox ej()
	{
		return b8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(ComboBox A_0)
	{
		EventHandler value = j;
		ComboBox comboBox = b8;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		b8 = A_0;
		comboBox = b8;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox ek()
	{
		return b9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ae(CheckBox A_0)
	{
		EventHandler value = o;
		CheckBox checkBox = b9;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		b9 = A_0;
		checkBox = b9;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox el()
	{
		return this.m_ca;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ag(CheckBox A_0)
	{
		EventHandler value = k;
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
	internal virtual hy em()
	{
		return cb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ag(hy A_0)
	{
		EventHandler value = s;
		hy hy2 = cb;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		cb = A_0;
		hy2 = cb;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button en()
	{
		return cc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void t(Button A_0)
	{
		EventHandler value = av;
		Button button = cc;
		if (button != null)
		{
			button.Click -= value;
		}
		cc = A_0;
		button = cc;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button eo()
	{
		return cd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ac(Button A_0)
	{
		EventHandler value = ag;
		Button button = cd;
		if (button != null)
		{
			button.Click -= value;
		}
		cd = A_0;
		button = cd;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual TextBox ep()
	{
		return ce;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void g(TextBox A_0)
	{
		EventHandler value = i;
		EventHandler value2 = h;
		TextBox textBox = ce;
		if (textBox != null)
		{
			textBox.Click -= value;
			textBox.TextChanged -= value2;
		}
		ce = A_0;
		textBox = ce;
		if (textBox != null)
		{
			textBox.Click += value;
			textBox.TextChanged += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label eq()
	{
		return cf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void au(Label A_0)
	{
		cf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox er()
	{
		return this.m_cg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void h(GroupBox A_0)
	{
		this.m_cg = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy es()
	{
		return this.m_ch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aj(hy A_0)
	{
		EventHandler value = r;
		hy hy2 = this.m_ch;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_ch = A_0;
		hy2 = this.m_ch;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy et()
	{
		return this.m_ci;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void al(hy A_0)
	{
		EventHandler value = t;
		hy hy2 = this.m_ci;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_ci = A_0;
		hy2 = this.m_ci;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy eu()
	{
		return cj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void @as(hy A_0)
	{
		EventHandler value = ac;
		hy hy2 = cj;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		cj = A_0;
		hy2 = cj;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox ev()
	{
		return this.m_ck;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aj(CheckBox A_0)
	{
		EventHandler value = q;
		CheckBox checkBox = this.m_ck;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_ck = A_0;
		checkBox = this.m_ck;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ew()
	{
		return cl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void av(Label A_0)
	{
		cl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox ex()
	{
		return cm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void al(CheckBox A_0)
	{
		EventHandler value = p;
		CheckBox checkBox = cm;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		cm = A_0;
		checkBox = cm;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox ey()
	{
		return this.m_cn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void @as(CheckBox A_0)
	{
		EventHandler value = o;
		CheckBox checkBox = this.m_cn;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_cn = A_0;
		checkBox = this.m_cn;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox ez()
	{
		return co;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(ComboBox A_0)
	{
		EventHandler value = j;
		ComboBox comboBox = co;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		co = A_0;
		comboBox = co;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox e0()
	{
		return this.m_cp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void at(CheckBox A_0)
	{
		EventHandler value = k;
		CheckBox checkBox = this.m_cp;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_cp = A_0;
		checkBox = this.m_cp;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy e1()
	{
		return cq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void at(hy A_0)
	{
		EventHandler value = s;
		hy hy2 = cq;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		cq = A_0;
		hy2 = cq;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button e2()
	{
		return cr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ad(Button A_0)
	{
		EventHandler value = av;
		Button button = cr;
		if (button != null)
		{
			button.Click -= value;
		}
		cr = A_0;
		button = cr;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button e3()
	{
		return cs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ae(Button A_0)
	{
		EventHandler value = ag;
		Button button = cs;
		if (button != null)
		{
			button.Click -= value;
		}
		cs = A_0;
		button = cs;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual TextBox e4()
	{
		return ct;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void h(TextBox A_0)
	{
		EventHandler value = i;
		EventHandler value2 = h;
		TextBox textBox = ct;
		if (textBox != null)
		{
			textBox.Click -= value;
			textBox.TextChanged -= value2;
		}
		ct = A_0;
		textBox = ct;
		if (textBox != null)
		{
			textBox.Click += value;
			textBox.TextChanged += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label e5()
	{
		return cu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aw(Label A_0)
	{
		cu = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button e6()
	{
		return m_cv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ag(Button A_0)
	{
		EventHandler value = aj;
		Button button = m_cv;
		if (button != null)
		{
			button.Click -= value;
		}
		m_cv = A_0;
		button = m_cv;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button e7()
	{
		return cw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aj(Button A_0)
	{
		EventHandler value = aj;
		Button button = cw;
		if (button != null)
		{
			button.Click -= value;
		}
		cw = A_0;
		button = cw;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button e8()
	{
		return cx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void al(Button A_0)
	{
		EventHandler value = aj;
		Button button = cx;
		if (button != null)
		{
			button.Click -= value;
		}
		cx = A_0;
		button = cx;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button e9()
	{
		return cy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void @as(Button A_0)
	{
		EventHandler value = aj;
		Button button = cy;
		if (button != null)
		{
			button.Click -= value;
		}
		cy = A_0;
		button = cy;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button fa()
	{
		return cz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void at(Button A_0)
	{
		EventHandler value = aj;
		Button button = cz;
		if (button != null)
		{
			button.Click -= value;
		}
		cz = A_0;
		button = cz;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label fb()
	{
		return this.m_c0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ay(Label A_0)
	{
		this.m_c0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label fc()
	{
		return this.m_c1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a7(Label A_0)
	{
		this.m_c1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox fd()
	{
		return this.m_c2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void au(CheckBox A_0)
	{
		EventHandler value = a;
		CheckBox checkBox = this.m_c2;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_c2 = A_0;
		checkBox = this.m_c2;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox fe()
	{
		return this.m_c3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void av(CheckBox A_0)
	{
		EventHandler value = a;
		CheckBox checkBox = this.m_c3;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_c3 = A_0;
		checkBox = this.m_c3;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ff()
	{
		return this.m_c4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aw(CheckBox A_0)
	{
		EventHandler value = a;
		CheckBox checkBox = this.m_c4;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_c4 = A_0;
		checkBox = this.m_c4;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox fg()
	{
		return this.m_c5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ay(CheckBox A_0)
	{
		EventHandler value = a;
		CheckBox checkBox = this.m_c5;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_c5 = A_0;
		checkBox = this.m_c5;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox fh()
	{
		return this.m_c6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a7(CheckBox A_0)
	{
		EventHandler value = a;
		CheckBox checkBox = this.m_c6;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_c6 = A_0;
		checkBox = this.m_c6;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox fi()
	{
		return this.m_c7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a8(CheckBox A_0)
	{
		EventHandler value = a;
		CheckBox checkBox = this.m_c7;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_c7 = A_0;
		checkBox = this.m_c7;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label fj()
	{
		return c8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a8(Label A_0)
	{
		c8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label fk()
	{
		return this.m_c9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a9(Label A_0)
	{
		this.m_c9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d fl()
	{
		return this.m_en;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		this.m_en = A_0;
	}

	public void a(fz A_0, f1 A_1, f4 A_2, gr A_3, ge A_4, hd A_5, bool A_6, Collection<string> A_7, Collection<string> A_8, hg A_9, string A_10, string A_11, ref string A_12, Point A_13, eo.a A_14, bool A_15)
	{
		bool flag = A_9.dh().a8();
		this.m_dr = A_0;
		this.m_eo = A_1;
		this.m_ep = A_2;
		this.m_dc = A_3;
		this.m_ei = new iw(this.m_dc, f, c, b, null, d, a, this.m_a);
		this.m_dd = A_4;
		this.m_de = A_5;
		this.m_eq = A_9;
		k();
		this.m_df = A_9;
		this.m_dq = this.m_df.ca();
		this.m_df.ed();
		this.m_er = A_6;
		this.m_es = A_10;
		this.m_et = A_7;
		this.m_eu = A_8;
		this.m_di = A_11;
		this.m_ew = A_14;
		eo eo2 = A_9.dh();
		this.m_ex = eo2.ax(A_14);
		this.m_ey = eo2.at(A_14, A_15);
		eo2 = null;
		a(flag);
		string text = null;
		string text2 = null;
		if (!string.IsNullOrEmpty(A_10) && gd.l(A_10))
		{
			text2 = A_10.Substring("Stack: ".Length);
			if (a(text2, this.m_er, flag))
			{
				text = text2;
			}
		}
		if (string.IsNullOrEmpty(text))
		{
			string[] array = this.m_dd.a(A_6, flag);
			if (array.Length > 0 && string.IsNullOrEmpty(text2))
			{
				text = array[0];
			}
		}
		if (string.IsNullOrEmpty(text))
		{
			if (!string.IsNullOrEmpty(text2))
			{
				fz a_ = this.m_dr;
				string A_16 = "LayerStackMissingFileFmt";
				global::fe.b(a_, string.Format(hu.a(ref A_16), text2), i6.a(this));
			}
			this.m_dv = gd.i(this.m_er, this.m_di, this.m_de, A_9.dh(), this.m_ew);
			text = this.m_dv.n();
		}
		else
		{
			this.m_dv = new gd();
		}
		b(text);
		this.m_dh = this.m_dv.a;
		if (this.m_er)
		{
			this.m_ei.ai = A_8;
			this.m_ei.ag = A_7;
			this.m_ej = gc.a.c;
		}
		else
		{
			this.m_ei.ag = A_7;
			this.m_ej = gc.a.b;
		}
		c();
		s().Text = h4.e(this.m_df.ca(), A_1: true);
		i6.a(A_13, this);
		ShowDialog();
		A_12 = this.m_es;
	}

	private void b(string A_0)
	{
		string[] array = this.m_dd.a(this.m_er, this.m_df.dh().a8());
		checked
		{
			int num = array.Length - 1;
			ac().Items.Clear();
			if (array.Length > 0)
			{
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					ac().Items.Add(array[num3]);
				}
			}
			bool flag = false;
			string[] array2 = array;
			for (int num4 = 0; num4 < array2.Length; num4++)
			{
				if (string.Compare(array2[num4], A_0, ignoreCase: true) == 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				if (Operators.CompareString(A_0, "Default Layer Stack", TextCompare: false) != 0 && Operators.CompareString(A_0, "Default Substrate Layer Stack", TextCompare: false) != 0)
				{
					fz a_ = this.m_dr;
					string A_1 = "LayerStackMissingFileFmt";
					global::fe.b(a_, string.Format(hu.a(ref A_1), A_0), i6.a(this));
					this.m_du = gd.i(this.m_er, this.m_di, this.m_de, this.m_eq.dh(), this.m_ew);
				}
				ac().Items.Add(A_0);
			}
			ac().Text = A_0;
		}
	}

	private bool a(string A_0, bool A_1, bool A_2)
	{
		string[] array = (A_2 ? ((!A_1) ? this.m_dd.b() : this.m_dd.c()) : ((!A_1) ? this.m_dd.d() : this.m_dd.e()));
		string[] array2 = array;
		for (int num = 0; num < array2.Length; num = checked(num + 1))
		{
			if (string.Compare(array2[num], A_0, ignoreCase: true) == 0)
			{
				return true;
			}
		}
		return false;
	}

	private void k()
	{
		this.m_ea.Add(ck());
		this.m_ea.Add(de());
		this.m_ea.Add(dt());
		this.m_ea.Add(d8());
		this.m_ea.Add(en());
		this.m_ea.Add(e2());
		this.m_d0.Add(cp());
		this.m_d0.Add(dg());
		this.m_d0.Add(dv());
		this.m_d0.Add(ea());
		this.m_d0.Add(ep());
		this.m_d0.Add(e4());
		this.m_d1.Add(b2());
		this.m_d1.Add(c5());
		this.m_d1.Add(dl());
		this.m_d1.Add(d0());
		this.m_d1.Add(ef());
		this.m_d1.Add(eu());
		this.m_d2.Add(b1());
		this.m_d2.Add(c4());
		this.m_d2.Add(dk());
		this.m_d2.Add(dz());
		this.m_d2.Add(ee());
		this.m_d2.Add(et());
		this.m_d3.Add(ci());
		this.m_d3.Add(da());
		this.m_d3.Add(ds());
		this.m_d3.Add(d7());
		this.m_d3.Add(em());
		this.m_d3.Add(e1());
		this.m_d4.Add(bv());
		this.m_d4.Add(c3());
		this.m_d4.Add(dj());
		this.m_d4.Add(dy());
		this.m_d4.Add(ed());
		this.m_d4.Add(es());
		this.m_d6.Add(ch());
		this.m_d6.Add(dd());
		this.m_d6.Add(dm());
		this.m_d6.Add(d1());
		this.m_d6.Add(eg());
		this.m_d6.Add(ev());
		this.m_d7.Add(ca());
		this.m_d7.Add(c9());
		this.m_d7.Add(@do());
		this.m_d7.Add(d3());
		this.m_d7.Add(ei());
		this.m_d7.Add(ex());
		this.m_d8.Add(b7());
		this.m_d8.Add(dc());
		this.m_d8.Add(dq());
		this.m_d8.Add(d5());
		this.m_d8.Add(ek());
		this.m_d8.Add(ey());
		this.m_d9.Add(b3());
		this.m_d9.Add(db());
		this.m_d9.Add(dr());
		this.m_d9.Add(d6());
		this.m_d9.Add(el());
		this.m_d9.Add(e0());
		this.m_ec.Add(bd());
		this.m_ec.Add(c1());
		this.m_ec.Add(e6());
		this.m_ec.Add(e7());
		this.m_ec.Add(e8());
		this.m_ec.Add(e9());
		this.m_ec.Add(fa());
		this.m_eb.Add(cn());
		this.m_eb.Add(df());
		this.m_eb.Add(du());
		this.m_eb.Add(d9());
		this.m_eb.Add(eo());
		this.m_eb.Add(e3());
		this.m_ed.Add(cg());
		this.m_ed.Add(c7());
		this.m_ed.Add(dp());
		this.m_ed.Add(d4());
		this.m_ed.Add(ej());
		this.m_ed.Add(ez());
		this.m_eg.Add(c0());
		this.m_eg.Add(dh());
		this.m_eg.Add(dw());
		this.m_eg.Add(eb());
		this.m_eg.Add(eq());
		this.m_eg.Add(e5());
		this.m_eh.Add(bs());
		this.m_eh.Add(c2());
		this.m_eh.Add(di());
		this.m_eh.Add(dx());
		this.m_eh.Add(ec());
		this.m_eh.Add(er());
		this.m_ee.Add(b5());
		this.m_ee.Add(c6());
		this.m_ee.Add(dn());
		this.m_ee.Add(d2());
		this.m_ee.Add(eh());
		this.m_ee.Add(ew());
		this.m_ef.Add(fd());
		this.m_ef.Add(fe());
		this.m_ef.Add(ff());
		this.m_ef.Add(fg());
		this.m_ef.Add(fh());
		this.m_ef.Add(fi());
	}

	private void a(string A_0, short A_1, ref string A_2)
	{
		string A_3 = string.Empty;
		string A_4 = string.Empty;
		int num = default(int);
		if (Operators.CompareString(A_0, "<Graded Interface>", TextCompare: false) != 0)
		{
			bool A_5 = default(bool);
			num = jb.a(A_0, this.m_de, this.m_df.dh(), this.m_ew, ref A_2, ref A_3, ref A_4, ref A_5);
			if (num >= 0)
			{
				this.m_de.i(this.m_ed[A_1], this.m_df.dh(), this.m_ew, A_5);
			}
		}
		if (num >= 0)
		{
			this.m_d0[A_1].Text = hg.bz(A_0);
			this.m_du.l()[checked(A_1 + this.m_dj)].af(A_0);
			iz.b(this.m_ed[this.m_dp], num);
			this.m_dc.m2(ref this.m_ei.z, this.m_dt, gr.f.a);
			this.m_dc.m2(ref this.m_ei.z, A_0, gr.f.a);
			g();
		}
		else
		{
			string A_6 = "ErrMatFileCorruptFmt";
			A_2 = string.Format(hu.a(ref A_6), A_0);
		}
	}

	private void av(object A_0, EventArgs A_1)
	{
		Button item = (Button)A_0;
		iw iw2 = this.m_ei;
		checked
		{
			this.m_dp = (short)this.m_ea.IndexOf(item);
			gc.a a10;
			if (this.m_dj + this.m_dp == this.m_dn - 1 && this.m_er)
			{
				a10 = gc.a.c;
				iw2.z = this.m_eu;
			}
			else
			{
				a10 = gc.a.b;
				iw2.z = this.m_et;
			}
			this.m_dt = this.m_d0[this.m_dp].Text;
			iw2.q(a10, iw.c.a);
			iw2.q((Button)A_0, new Point(0, 0), iw.d.b, iw.e.a, a10, null);
			iw2 = null;
		}
	}

	private void j()
	{
		int num = checked(this.m_dj + this.m_dp);
		if (num == 0)
		{
			this.m_ei.z = this.m_ei.ah;
			this.m_ek = "\\MostRecentMediumMaterials.fmslf";
			this.m_ej = gc.a.a;
		}
		else if (num == this.m_dm)
		{
			this.m_ei.z = this.m_ei.ai;
			this.m_ek = "\\MostRecentSubstrateMaterials.fmslf";
			this.m_ej = gc.a.c;
		}
		else
		{
			this.m_ei.z = this.m_ei.ag;
			this.m_ek = "\\MostRecentLayerMaterials.fmslf";
			this.m_ej = gc.a.b;
		}
	}

	private void a(string A_0, bool A_1)
	{
		try
		{
			string A_2 = "AddNewMaterial";
			if (Operators.CompareString(A_0, hu.a(ref A_2), TextCompare: false) == 0)
			{
				fz a_ = this.m_dr;
				A_2 = "AddNewMaterialPromptdddFmt1";
				global::fe.b(a_, string.Format(hu.a(ref A_2), Text), "Information", f());
				return;
			}
			A_2 = "EnterRefractiveIndex";
			if (Operators.CompareString(A_0, hu.a(ref A_2), TextCompare: false) == 0)
			{
				string a_2 = ((!this.m_d0[this.m_dp].Text.StartsWith("Generic, n=")) ? 1.5f.ToString() : this.m_d0[this.m_dp].Text.Substring("Generic, n=".Length));
				a(a_2);
				return;
			}
			if (Operators.CompareString(A_0, "Search...", TextCompare: false) == 0)
			{
				a(this.m_dp, string.Empty);
				return;
			}
			string A_3 = string.Empty;
			a(A_0, this.m_dp, ref A_3);
			if (!string.IsNullOrEmpty(A_3))
			{
				a(this.m_dr, A_3, this.m_ea[this.m_dp]);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			i5.a(this.m_dr, this.m_eo, this.m_ep, f(), "DialogEditLayerStack. MenuClickHandler; sender=" + A_0, a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void i()
	{
		bool flag = false;
		bool flag2 = this.m_do;
		this.m_dn = this.m_du.l().Count;
		if (this.m_df.b5())
		{
			return;
		}
		this.m_do = true;
		if (this.m_dn > 6)
		{
			flag = true;
		}
		VScrollBar vScrollBar = bb();
		vScrollBar.Visible = flag;
		checked
		{
			if (flag)
			{
				vScrollBar.Maximum = this.m_dn - 1;
				vScrollBar.Minimum = 0;
				vScrollBar.SmallChange = 1;
				vScrollBar.LargeChange = 6;
			}
			vScrollBar = null;
			a(this.m_dn);
			bb().Value = this.m_dl;
			int num = Math.Min(this.m_du.l().Count, this.m_ed.Count) - 1;
			bool A_ = default(bool);
			for (int num2 = 0; num2 <= num; num2++)
			{
				gc gc2 = this.m_du.l()[this.m_dj + num2];
				if (Operators.CompareString(gc2.ag(), "<Graded Interface>", TextCompare: false) == 0 || gc2.ag().StartsWith("Generic, n="))
				{
					A_ = false;
				}
				else
				{
					string a_ = gc2.ag();
					hd a_2 = this.m_de;
					eo a_3 = this.m_df.dh();
					eo.a a_4 = this.m_ew;
					string A_2 = null;
					string A_3 = null;
					string A_4 = null;
					jb.a(a_, a_2, a_3, a_4, ref A_2, ref A_3, ref A_4, ref A_);
				}
				this.m_de.i(this.m_ed[num2], this.m_df.dh(), this.m_ew, A_);
				gc2 = null;
			}
			a(this.m_dj, this.m_dk, this.m_dn);
			if (this.m_dn <= 6)
			{
				int num3 = this.m_dn;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					this.m_ec[num4].Visible = true;
				}
				if (this.m_er)
				{
					this.m_ec[this.m_dn].Visible = false;
				}
				for (int num5 = this.m_dn + 1; num5 <= 6; num5++)
				{
					this.m_ec[num5].Visible = false;
				}
			}
			else
			{
				int num4 = 0;
				do
				{
					this.m_ec[num4].Visible = true;
					num4++;
				}
				while (num4 <= 6);
			}
			h();
			if (flag && this.m_er)
			{
				this.m_ec[this.m_ec.Count - 1].Visible = false;
			}
			this.m_do = flag2;
		}
	}

	private void a(int A_0)
	{
		checked
		{
			if (this.m_dn > 6)
			{
				if (this.m_dl + 6 >= this.m_dn)
				{
					this.m_dk = A_0;
					this.m_dj = A_0 - 6;
				}
				else
				{
					this.m_dj = this.m_dl;
					this.m_dk = this.m_dj + 6;
				}
			}
			else
			{
				this.m_dj = 0;
				this.m_dk = A_0;
			}
		}
	}

	private void a(int A_0, int A_1, int A_2)
	{
		checked
		{
			int num = A_1 - A_0;
			string empty = string.Empty;
			bool visible = this.m_df.dh().ax(this.m_ew);
			this.m_do = true;
			int num2 = num - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (num3 <= num)
				{
					int num4 = num3 + A_0;
					gc obj = this.m_du.l()[num4];
					this.m_d7[num3].Visible = visible;
					this.m_d8[num3].Visible = visible;
					this.m_d9[num3].Visible = visible;
					gc gc2 = obj;
					if (this.m_er && num3 + A_0 == A_2 - 1)
					{
						this.m_eg[num3].Text = "Substrate";
						this.m_d1[num3].Visible = false;
						this.m_d6[num3].Checked = false;
						this.m_d6[num3].Visible = false;
						this.m_d3[num3].Visible = false;
						this.m_ee[num3].Visible = false;
						this.m_d4[num3].Enabled = this.m_d7[num3].Checked;
					}
					else
					{
						this.m_eg[num3].Text = (num4 + 1).ToString();
						this.m_d1[num3].Visible = true;
						this.m_d6[num3].Visible = true;
						this.m_d3[num3].Visible = true;
						this.m_ee[num3].Visible = true;
						this.m_d4[num3].Enabled = true;
					}
					this.m_d0[num3].Text = hg.bz(gc2.ag());
					if (!string.IsNullOrEmpty(empty) && !this.m_em.Contains(empty))
					{
						ref string reference = ref this.m_em;
						reference = reference + empty + "\r\n";
					}
					if (gc2.ai() > 0.0)
					{
						this.m_d1[num3].Text = hg.bu(1, gc2.ai(), this.m_dq);
					}
					else
					{
						this.m_d1[num3].Text = string.Empty;
					}
					this.m_d2[num3].Visible = true;
					this.m_d2[num3].Text = hg.bu(1, gc2.an(), this.m_dq);
					this.m_d6[num3].Checked = gc2.af(this.m_ey);
					this.m_d7[num3].Checked = gc2.ah(this.m_ex);
					this.m_d8[num3].Checked = gc2.aj(this.m_ex);
					this.m_d9[num3].Checked = gc2.al(this.m_ex);
					this.m_d3[num3].Text = gc2.av().ToString();
					this.m_d3[num3].Enabled = gc2.af(this.m_ey);
					this.m_d4[num3].Text = gc2.aw().ToString();
					this.m_d4[num3].Enabled = gc2.ah(this.m_ex);
					try
					{
						this.m_ed[num3].Text = gc2.af(this.m_de, this.m_df.dh(), this.m_ew);
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2);
						Exception ex3 = ex2;
						this.m_ed[num3].SelectedIndex = 0;
						ProjectData.ClearProjectError();
					}
					this.m_ed[num3].Enabled = gc2.ah(this.m_ex) || gc2.aj(this.m_ex);
					this.m_ef[num3].Checked = gc2.w;
					if (num < 2)
					{
						this.m_eb[num3].Visible = false;
					}
					else
					{
						this.m_eb[num3].Visible = true;
					}
					gc2 = null;
				}
				this.m_eh[num3].Visible = num3 < num;
			}
			for (int num5 = num; num5 <= 5; num5++)
			{
				this.m_eh[num5].Visible = false;
			}
			if (!string.IsNullOrEmpty(this.m_em) && Operators.CompareString(this.m_em, this.m_el, TextCompare: false) != 0)
			{
				this.m_el = this.m_em;
				a(this.m_dr, this.m_el, this);
			}
			this.m_do = false;
		}
	}

	private void h()
	{
		bool enabled = this.m_du.l().Count < 100;
		short num = 0;
		checked
		{
			do
			{
				this.m_ec[num].Enabled = enabled;
				num = (short)unchecked(num + 1);
			}
			while (num <= 6);
		}
	}

	private void a(bool A_0, string A_1, ref bool A_2)
	{
		A_2 = false;
		string text2;
		string path;
		if (A_0)
		{
			foreach (gc item in this.m_du.l())
			{
				string text = jb.x(item.ag());
				if (jb.y(text) && string.IsNullOrEmpty(jb.a(new string[2]
				{
					text + ".fibnk",
					text + ".fibnx"
				})))
				{
					global::fe.b(this.m_dr, "Invalid material. '" + item.ag() + "' may not be used in an Encrypted layer stack because it is based on a material file of an unacceptable type.\r\nEncrypted LayerStack files must contain only material files of type *.fibnk", i6.a(ay()));
					return;
				}
			}
			if (this.m_er)
			{
				text2 = gd.i() + A_1 + ".fibss";
				path = Path.ChangeExtension(text2, ".fitss");
			}
			else
			{
				text2 = gd.i() + A_1 + ".fibls";
				path = Path.ChangeExtension(text2, ".fitls");
			}
		}
		else if (this.m_er)
		{
			text2 = gd.i() + A_1 + ".fitss";
			path = Path.ChangeExtension(text2, ".fibss");
		}
		else
		{
			text2 = gd.i() + A_1 + ".fitls";
			path = Path.ChangeExtension(text2, ".fibls");
		}
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		a(text2, ref A_2);
	}

	private void a(string A_0, ref bool A_1)
	{
		A_1 = false;
		checked
		{
			int num = 100 - this.m_du.l().Count - 1;
			if (!this.m_du.k() && b())
			{
				fz a_ = this.m_dr;
				string A_2 = "LayerStackSaveUnencryptedHideError";
				global::fe.b(a_, hu.a(ref A_2), i6.a(this));
				return;
			}
			gd gd2 = this.m_du;
			if (gd.k(this.m_du, this.m_dv))
			{
				gd2.e = Guid.NewGuid();
				gd2.b = this.m_di;
				gd2.a = this.m_dh;
				gd2.d = true;
				gd2.m(A_0);
				gd2.i(ref this.m_dv);
				if (this.m_du.k())
				{
					Collection<string> collection = new Collection<string>();
					foreach (gc item in this.m_du.l())
					{
						string text = jb.x(item.ag());
						if (!jb.y(text))
						{
							continue;
						}
						jb.a(jb.a(new string[2]
						{
							text + ".fibnk",
							text + ".fibnx"
						}), A_1: false, A_2: true, collection);
						foreach (string item2 in collection)
						{
							gf.e(item2);
						}
					}
					int num2 = num;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						gf.a(num3);
					}
				}
				g();
			}
			gd2 = null;
			A_1 = true;
		}
	}

	private void au(object A_0, EventArgs A_1)
	{
		try
		{
			if (!a())
			{
				return;
			}
			bool flag = this.m_du.k();
			string text = this.m_du.n();
			bool flag2 = this.m_eq.dh().a8();
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			int filterIndex = -1;
			SaveFileDialog saveFileDialog2 = saveFileDialog;
			saveFileDialog2.OverwritePrompt = false;
			saveFileDialog2.Filter = this.m_ev.b();
			if (this.m_er)
			{
				int filterIndex2 = this.m_ev.c(3);
				if (flag2)
				{
					filterIndex = this.m_ev.c(4);
				}
				if (flag2 && flag)
				{
					saveFileDialog2.FilterIndex = filterIndex;
				}
				else
				{
					saveFileDialog2.FilterIndex = filterIndex2;
				}
			}
			else
			{
				int filterIndex2 = this.m_ev.c(1);
				if (flag2)
				{
					filterIndex = this.m_ev.c(2);
				}
				if (flag2 && flag)
				{
					saveFileDialog2.FilterIndex = filterIndex;
				}
				else
				{
					saveFileDialog2.FilterIndex = filterIndex2;
				}
			}
			saveFileDialog2.InitialDirectory = gd.i();
			saveFileDialog2.FileOk += a;
			if (saveFileDialog2.ShowDialog() == DialogResult.OK)
			{
				string text2 = this.m_ev.a(saveFileDialog.FileName, saveFileDialog.FilterIndex);
				bool flag3 = (this.m_er && text2.EndsWith(".fibss", StringComparison.CurrentCultureIgnoreCase)) || (!this.m_er && text2.EndsWith(".fibls", StringComparison.CurrentCultureIgnoreCase));
				text = Path.GetFileNameWithoutExtension(text2);
				if (!flag3 && b())
				{
					fz a_ = this.m_dr;
					string A_2 = "LayerStackSaveUnencryptedHideError";
					global::fe.b(a_, hu.a(ref A_2), i6.a(this));
					return;
				}
				this.m_du.c = text2;
				bool A_3 = default(bool);
				a(flag3, text, ref A_3);
				if (A_3)
				{
					b(text);
				}
			}
			saveFileDialog2 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.ButtonSaveAs_Click; sender=" + ((Control)A_0).Name, a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void a(bool A_0)
	{
		this.m_ev.a();
		if (A_0)
		{
			if (this.m_er)
			{
				this.m_ev.a("Encrypted Substrate LayerStack (*.fibss)", "*.fibss", 4);
				this.m_ev.a("Substrate LayerStack (*.fitss)", "*.fitss", 3);
			}
			else
			{
				this.m_ev.a("Encrypted LayerStack (*.fibls)", "*.fibls", 2);
				this.m_ev.a("LayerStack (*.fitls)", "*.fitls", 1);
			}
		}
		else if (this.m_er)
		{
			this.m_ev.a("Substrate LayerStack (*.fitss)", "*.fitss", 3);
		}
		else
		{
			this.m_ev.a("LayerStack (*.fitls)", "*.fitls", 1);
		}
	}

	private void a(object A_0, CancelEventArgs A_1)
	{
		string text = string.Empty;
		bool flag = this.m_eq.dh().a8();
		SaveFileDialog saveFileDialog = (SaveFileDialog)A_0;
		A_1.Cancel = true;
		bool flag2 = flag && saveFileDialog.FilterIndex == 1;
		try
		{
			string text2 = this.m_ev.a(saveFileDialog.FileName, saveFileDialog.FilterIndex);
			string strB = gd.i() + Path.GetFileName(text2);
			if (string.Compare(text2, strB, ignoreCase: true) != 0)
			{
				global::fe.b(this.m_dr, "LayerStack files must be saved in the LayerStack folder.", i6.a(a9()));
				return;
			}
			try
			{
				text = Path.GetFileNameWithoutExtension(text2);
			}
			catch (ArgumentException ex2)
			{
				ProjectData.SetProjectError(ex2);
				ArgumentException ex3 = ex2;
				global::fe.b(this.m_dr, ex3.Message + " Filenames may not contain any of the following characters: \\ : / ? * \" < > |", i6.a(a9()));
				ProjectData.ClearProjectError();
			}
			string path = (this.m_er ? ((!flag2) ? Path.ChangeExtension(text2, ".fibss") : Path.ChangeExtension(text2, ".fitss")) : ((!flag2) ? Path.ChangeExtension(text2, ".fibls") : Path.ChangeExtension(text2, ".fitls")));
			if (string.Compare(text, "Default Substrate Layer Stack", ignoreCase: true) == 0 || string.Compare(text, "Default Layer Stack", ignoreCase: true) == 0)
			{
				fz a_ = this.m_dr;
				string A_2 = "LayerStackNameReservedFmt";
				global::fe.b(a_, string.Format(hu.a(ref A_2), text), i6.a(this));
				return;
			}
			if (File.Exists(text2))
			{
				ref fz a_2 = ref this.m_dr;
				string A_2 = "FileReplaceWarningMsgLayerStackFmt";
				if (!global::fe.b(ref a_2, string.Format(hu.a(ref A_2), Path.GetFileNameWithoutExtension(text2)), "Warning", "Yes", "No", i6.a(this)))
				{
					return;
				}
			}
			else if (File.Exists(path) && !flag2)
			{
				if (flag)
				{
					ref fz a_3 = ref this.m_dr;
					string A_2 = "LayerStackInternalReplaceEnMsgFmt1";
					if (!global::fe.b(ref a_3, string.Format(hu.a(ref A_2), Path.GetFileNameWithoutExtension(text2)), "Warning", "Yes", "No", i6.a(this)))
					{
						return;
					}
				}
				else
				{
					ref fz a_4 = ref this.m_dr;
					string A_2 = "LayerStackNonInternalReplaceEnMsgFmt1";
					if (!global::fe.b(ref a_4, string.Format(hu.a(ref A_2), Path.GetFileNameWithoutExtension(text2)), "Warning", "Yes", "No", i6.a(this)))
					{
						return;
					}
				}
			}
			else if (File.Exists(path) && flag2)
			{
				ref fz a_5 = ref this.m_dr;
				string A_2 = "LayerStackInternalReplaceNonEnMsgFmt1";
				if (!global::fe.b(ref a_5, string.Format(hu.a(ref A_2), Path.GetFileNameWithoutExtension(text2)), "Warning", "Yes", "No", i6.a(this)))
				{
					return;
				}
			}
			A_1.Cancel = false;
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception a_6 = ex4;
			i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(a9()), "DialogEditLayerStack.ValidateFilenameAndPath", a_6);
			ProjectData.ClearProjectError();
		}
	}

	private void at(object A_0, EventArgs A_1)
	{
		try
		{
			Operators.CompareString(this.m_du.c, this.m_dv.c, TextCompare: false);
			SystemSounds.Exclamation.Play();
			ref fz a_ = ref this.m_dr;
			string A_2 = "RecipeDeletePromptFmt1";
			if (global::fe.b(ref a_, string.Format(hu.a(ref A_2), this.m_du.c), "LayerStackDeleteTitle", "OKString", "CancelString", i6.a(this)))
			{
				if (File.Exists(gd.i() + this.m_du.c))
				{
					global::c.e().FileSystem.DeleteFile(gd.i() + this.m_du.c);
				}
				string[] array = this.m_dd.a(this.m_er, this.m_df.dh().a8());
				string a_2 = string.Empty;
				if (array.Length > 0)
				{
					string a_3 = (this.m_er ? ((!File.Exists(gd.i() + array[0] + ".fibss")) ? (array[0] + ".fitss") : (array[0] + ".fibls")) : ((!File.Exists(gd.i() + array[0] + ".fibls")) ? (array[0] + ".fitls") : (array[0] + ".fibls")));
					this.m_du = new gd();
					this.m_du.n(a_3);
					this.m_du.i(ref this.m_dv);
					a_2 = array[0];
				}
				b(a_2);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_4 = ex2;
			i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.ButtonDelete_Click; sender=" + ((Control)A_0).Name, a_4);
			ProjectData.ClearProjectError();
		}
	}

	private void @as(object A_0, EventArgs A_1)
	{
		try
		{
			if (!a())
			{
				return;
			}
			bool flag = default(bool);
			if (gd.k(this.m_du, this.m_dv))
			{
				if (Operators.CompareString(this.m_du.c, this.m_dv.c, TextCompare: false) == 0 && !this.m_du.d)
				{
					ref fz a_ = ref this.m_dr;
					string A_2 = "LayerStackChanged";
					flag = (global::fe.b(ref a_, hu.a(ref A_2), "Warning", "Yes", "No", f()) ? true : false);
				}
				else if (Operators.CompareString(this.m_du.c, this.m_dv.c, TextCompare: false) != 0)
				{
					flag = true;
				}
			}
			if (flag)
			{
				string a_2 = gd.i() + this.m_du.c;
				bool A_3 = false;
				a(a_2, ref A_3);
			}
			this.m_es = "Stack: " + ac().Text;
			base.DialogResult = DialogResult.OK;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.ButtonOK_Click" + ((Control)A_0).Name, a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void al(object A_0, EventArgs A_1)
	{
		try
		{
			Close();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.ButtonCancel_Click" + ((Control)A_0).Name, a_);
			ProjectData.ClearProjectError();
		}
	}

	private void aj(object A_0, EventArgs A_1)
	{
		checked
		{
			short num = default(short);
			try
			{
				Button item = (Button)A_0;
				num = (short)this.m_ec.IndexOf(item);
				if (this.m_du.l().Count < 100)
				{
					int a_ = this.m_dj + num;
					gc a_2 = new gc();
					this.m_du.i(a_2, a_);
					i();
					if (num == 6)
					{
						bb().Value++;
					}
					g();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditRecipe.btnInsertLayer_Click; button #=" + num, a_3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ag(object A_0, EventArgs A_1)
	{
		checked
		{
			short num = default(short);
			try
			{
				Button item = (Button)A_0;
				num = (short)this.m_eb.IndexOf(item);
				int a_ = this.m_dj + num;
				this.m_du.i(a_);
				i();
				g();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.btnDeleteLayer_Click; button #=" + num, a_2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void g()
	{
		if (gd.k(this.m_du, this.m_dv))
		{
			DateTime dateTime = (this.m_dh = DateAndTime.Now);
			ag().Text = dateTime.ToShortDateString() + " " + dateTime.ToLongTimeString();
			ae().Text = this.m_di;
			aw().Enabled = Operators.CompareString(ac().Text, "Default Substrate Layer Stack", TextCompare: false) != 0 && Operators.CompareString(ac().Text, "Default Layer Stack", TextCompare: false) != 0;
			this.m_du.d = false;
		}
		else
		{
			ag().Text = this.m_dv.a.ToString();
			ae().Text = this.m_du.b;
			this.m_du.d = true;
			aw().Enabled = false;
		}
		a9().Enabled = Operators.CompareString(ac().Text, "Default Substrate Layer Stack", TextCompare: false) != 0 && Operators.CompareString(ac().Text, "Default Layer Stack", TextCompare: false) != 0;
	}

	private void ae(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_dl = bb().Value;
			if (!this.m_do)
			{
				i();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.VscrollLayerStack_ValueChanged; sender=" + ((Control)A_0).Name, a_);
			ProjectData.ClearProjectError();
		}
	}

	private void ad(object A_0, EventArgs A_1)
	{
		if (this.m_e0 == null)
		{
			Interlocked.CompareExchange(ref this.m_e0, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(this.m_e0, ref lockTaken);
			if (this.m_e0.State == 0)
			{
				this.m_e0.State = 2;
				this.m_ez = false;
			}
			else if (this.m_e0.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			this.m_e0.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(this.m_e0);
			}
		}
		try
		{
			if (this.m_ez)
			{
				return;
			}
			if (this.m_du != null && !this.m_du.d && !global::fe.b(ref this.m_dr, "Current LayerStack is not saved. Do you want to load '" + ac().Text + "' and lose changes to '" + this.m_du.n() + "'?", "Warning", "Yes", "No", i6.a(ac())))
			{
				this.m_ez = true;
				try
				{
					ac().Text = this.m_du.n();
					return;
				}
				finally
				{
					this.m_ez = false;
				}
			}
			string text = null;
			string text2 = ac().Text;
			bool flag = this.m_df.dh().a8();
			if (Operators.CompareString(text2, "Default Substrate Layer Stack", TextCompare: false) != 0 && Operators.CompareString(text2, "Default Layer Stack", TextCompare: false) != 0)
			{
				if (a(text2, this.m_er, flag))
				{
					if (flag)
					{
						if (this.m_er)
						{
							text = gd.i() + text2 + ".fitss";
							text = ((!File.Exists(text)) ? (text2 + ".fibss") : (text2 + ".fitss"));
						}
						else
						{
							text = gd.i() + text2 + ".fitls";
							text = ((!File.Exists(text)) ? (text2 + ".fibls") : (text2 + ".fitls"));
						}
					}
					else
					{
						if (this.m_er)
						{
							text = text2 + ".fitss";
						}
						if (!this.m_er)
						{
							text = text2 + ".fitls";
						}
					}
					if (this.m_du == null)
					{
						this.m_du = new gd();
					}
					if (Operators.CompareString(this.m_du.c, text, TextCompare: false) != 0)
					{
						this.m_du.n(text);
						this.m_du.d = true;
						this.m_du.i(ref this.m_dv);
					}
					ComboBox.ObjectCollection items = ac().Items;
					if (items.Contains("Default Substrate Layer Stack"))
					{
						items.Remove("Default Substrate Layer Stack");
					}
					if (items.Contains("Default Layer Stack"))
					{
						items.Remove("Default Layer Stack");
					}
					items = null;
				}
				else
				{
					fz a_ = this.m_dr;
					string A_2 = "LayerStackMissingFileFmt";
					global::fe.b(a_, string.Format(hu.a(ref A_2), text2), i6.a(this));
					ComboBox.ObjectCollection items2 = ac().Items;
					if (items2.Contains(text2))
					{
						items2.Remove(text2);
					}
					items2 = null;
					this.m_du = gd.i(this.m_er, this.m_di, this.m_de, this.m_eq.dh(), this.m_ew);
					this.m_du.i(ref this.m_dv);
					b(this.m_du.n());
				}
				if (this.m_du.k())
				{
					fj().Text = "Encrypted";
				}
				else
				{
					fj().Text = "Not Encrypted";
				}
			}
			else
			{
				this.m_du = gd.i(this.m_er, this.m_di, this.m_de, this.m_eq.dh(), this.m_ew);
				this.m_du.i(ref this.m_dv);
				fj().Text = "Unknown";
			}
			this.m_dh = this.m_du.a;
			ae().Text = this.m_du.b;
			ag().Text = this.m_du.a.ToString();
			g();
			i();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.ComboLayerStackName_SelectedIndexChanged", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private double a(hy A_0, Collection<hy> A_1, ref int A_2, ref int A_3)
	{
		checked
		{
			A_2 = (short)A_1.IndexOf(A_0);
			A_3 = this.m_dj + A_2;
			return iz.e(A_0.Text);
		}
	}

	private void ac(object A_0, EventArgs A_1)
	{
		int A_2 = default(int);
		try
		{
			int A_3 = default(int);
			double a_ = a((hy)A_0, this.m_d1, ref A_2, ref A_3);
			this.m_du.l()[A_3].af(A_0: false, A_1: true, this.m_dq.e(a_));
			g();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.dText_TextChanged; sender=box #" + A_2, a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void t(object A_0, EventArgs A_1)
	{
		int A_2 = default(int);
		try
		{
			int A_3 = default(int);
			double a_ = a((hy)A_0, this.m_d2, ref A_2, ref A_3);
			this.m_du.l()[A_3].aj(this.m_dq.e(a_));
			g();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.rText_TextChanged; sender=box #" + A_2, a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void s(object A_0, EventArgs A_1)
	{
		int A_2 = default(int);
		try
		{
			int A_3 = default(int);
			double a_ = a((hy)A_0, this.m_d3, ref A_2, ref A_3);
			this.m_du.l()[A_3].ak(a_);
			g();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.tText_TextChanged; sender=box #" + A_2, a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void r(object A_0, EventArgs A_1)
	{
		int A_2 = default(int);
		try
		{
			int A_3 = default(int);
			double a_ = a((hy)A_0, this.m_d4, ref A_2, ref A_3);
			this.m_du.l()[A_3].al(a_);
			this.m_du.l()[A_3].am(a_);
			g();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.nText_TextChanged; sender=box #" + A_2, a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void q(object A_0, EventArgs A_1)
	{
		checked
		{
			int num = default(int);
			try
			{
				CheckBox checkBox = (CheckBox)A_0;
				num = (short)this.m_d6.IndexOf(checkBox);
				int index = this.m_dj + num;
				this.m_du.l()[index].ag(checkBox.Checked);
				this.m_d3[num].Enabled = checkBox.Checked;
				g();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.dCheck_CheckedChanged; sender=box #" + num, a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void p(object A_0, EventArgs A_1)
	{
		checked
		{
			int num = default(int);
			try
			{
				CheckBox checkBox = (CheckBox)A_0;
				num = (short)this.m_d7.IndexOf(checkBox);
				int index = this.m_dj + num;
				this.m_du.l()[index].ai(checkBox.Checked);
				bool enabled = checkBox.Checked || this.m_d8[num].Checked;
				this.m_d4[num].Enabled = enabled;
				this.m_ed[num].Enabled = enabled;
				g();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.nCheck_CheckedChanged; sender=box #" + num, a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		checked
		{
			int num = default(int);
			try
			{
				CheckBox checkBox = (CheckBox)A_0;
				num = (short)this.m_d8.IndexOf(checkBox);
				int index = this.m_dj + num;
				this.m_du.l()[index].ak(checkBox.Checked);
				bool enabled = checkBox.Checked || this.m_d7[num].Checked;
				this.m_d4[num].Enabled = enabled;
				this.m_ed[num].Enabled = enabled;
				g();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.kCheck_CheckedChanged; sender=box #" + num, a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		checked
		{
			int num = default(int);
			try
			{
				CheckBox checkBox = (CheckBox)A_0;
				num = (short)this.m_d9.IndexOf(checkBox);
				int index = this.m_dj + num;
				this.m_du.l()[index].am(checkBox.Checked);
				g();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.rCheck_CheckedChanged; sender=box #" + num, a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		checked
		{
			int num = default(int);
			try
			{
				ComboBox comboBox = (ComboBox)A_0;
				num = (short)this.m_ed.IndexOf(comboBox);
				int index = this.m_dj + num;
				this.m_du.l()[index].ag(comboBox.Text);
				g();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_dr, this.m_eo, this.m_ep, f(), "DialogEditLayerStack.ComboboxnkModel_SelectedIndexChanged; sender=box #" + num, a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		try
		{
			TextBox textBox = (TextBox)A_0;
			if (Operators.CompareString(textBox.Text, "<Graded Interface>", TextCompare: false) != 0)
			{
				this.m_dp = checked((short)this.m_d0.IndexOf(textBox));
				this.m_dt = this.m_d0[this.m_dp].Text;
				j();
				if (textBox.Text.StartsWith("Generic, n="))
				{
					a(textBox.Text.Substring("Generic, n=".Length));
					return;
				}
				string a_ = textBox.Text;
				a(this.m_dp, a_);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.MatBox_Click, sender = box#" + this.m_dp, a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		checked
		{
			int num = default(int);
			try
			{
				TextBox textBox = (TextBox)A_0;
				num = (short)this.m_d0.IndexOf(textBox);
				int index = this.m_dj + num;
				this.m_du.l()[index].af(textBox.Text);
				g();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.MatBox_TextChanged; sender = box#" + num, a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	[SpecialName]
	private Point f()
	{
		checked
		{
			return new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2));
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		try
		{
			if (a())
			{
				string a_ = gd.i() + this.m_du.c;
				bool A_2 = false;
				a(a_, ref A_2);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.ButtonSave_Click; sender=" + ((Control)A_0).Name, a_2);
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	private Point d()
	{
		return i6.a(this);
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
		{
			fz a_ = this.m_dr;
			string A_2 = "AddNewMaterialPromptdddFmt1";
			global::fe.b(a_, string.Format(hu.a(ref A_2), Text), "Information", d());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_dr, this.m_eo, this.m_ep, d(), "DialogEditLayerStack.AddNewMaterial_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			ref fz a_ = ref this.m_dr;
			string A_2 = "ClearMRLQuestion";
			if (global::fe.b(ref a_, hu.a(ref A_2), "ClearMRL", "Yes", "No", d()))
			{
				this.m_ei.ap();
				this.m_ei.z.Clear();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_dr, this.m_eo, this.m_ep, d(), "DialogEditLayerStack.ClearRecentMatMenu_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void a(Control A_0, string A_1, bool A_2)
	{
		try
		{
			string A_3 = string.Empty;
			a(hg.by(A_1), this.m_dp, ref A_3);
			if (!string.IsNullOrEmpty(A_3))
			{
				a(this.m_dr, A_3, this.m_ea[this.m_dp]);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_dr, this.m_eo, this.m_ep, d(), "DialogEditLayerStack.MatMenuMatOrLayerStack_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			string a_ = ((!this.m_d0[this.m_dp].Text.StartsWith("Generic, n=")) ? 1.5f.ToString() : this.m_d0[this.m_dp].Text.Substring("Generic, n=".Length));
			a(a_);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_dr, this.m_eo, this.m_ep, d(), "DialogEditLayerStack.EnterRefractiveIndex_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			a(checked((short)(this.m_dj + this.m_dp)), "");
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_dr, this.m_eo, this.m_ep, d(), "DialogEditLayerStack.Search_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(string A_0)
	{
		string A_1 = string.Empty;
		a(this.m_dr, this, A_0, ref A_1);
		if (!string.IsNullOrEmpty(A_1))
		{
			string A_2 = string.Empty;
			a(A_1, this.m_dp, ref A_2);
			if (!string.IsNullOrEmpty(A_2))
			{
				a(this.m_dr, A_2, this.m_ea[this.m_dp]);
			}
		}
	}

	public static void a(fz A_0, Form A_1, string A_2, ref string A_3)
	{
		fe fe2 = null;
		try
		{
			_ = string.Empty;
			fe2 = new fe(A_0);
			fe.a a10 = new fe.a();
			fe.a obj = a10;
			string A_4 = "FilmstackEnterNValuePrompt";
			obj.w(hu.a(ref A_4));
			a10.x("FilmstackEnterNValueTitle");
			a10.w(A_1);
			a10.w(global::fe.b.a);
			a10.w(1.0);
			a10.x(10.0);
			a10.ad(A_2);
			a10.w(MsgBoxStyle.OkCancel);
			A_3 = string.Empty;
			if (fe2.b(a10) == DialogResult.OK)
			{
				double num = iz.e(a10.ag());
				if ((num >= a10.ai()) & (num <= a10.aj()))
				{
					A_3 = hg.by("Generic, n=" + a10.ag());
					return;
				}
				A_4 = "RecipeInvalidRefractiveIndexFmt2";
				string a_ = string.Format(hu.a(ref A_4), a10.ai(), a10.aj());
				A_4 = "Information";
				global::fe.b(A_0, a_, hu.a(ref A_4), i6.a(A_1));
			}
		}
		finally
		{
			fe2.Close();
			fe2 = null;
			fe.a a10 = null;
		}
	}

	public static void a(fz A_0, string A_1, Control A_2)
	{
		global::fe.b(A_0, A_1, i6.a(A_2));
	}

	private void a(short A_0, string A_1)
	{
		dr obj = new dr();
		string A_2 = A_1;
		obj.a(this.m_dr, this.m_eo, this.m_ep, this.m_dc.so(), this.m_dc.sn(), this.m_df.dh(), this.m_ew, ref A_2);
		if (obj.DialogResult == DialogResult.OK)
		{
			string A_3 = string.Empty;
			a(A_2, A_0, ref A_3);
			if (!string.IsNullOrEmpty(A_3))
			{
				a(this.m_dr, A_3, this.m_ea[this.m_dp]);
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				CheckBox checkBox = (CheckBox)A_0;
				int num = (short)this.m_ef.IndexOf(checkBox);
				int index = this.m_dj + num;
				this.m_du.l()[index].w = checkBox.Checked;
				g();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_dr, this.m_eo, this.m_ep, i6.a(this), "DialogEditLayerStack.HideResultCheck_CheckedChanged; sender=" + ((Control)A_0).Name, a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void c()
	{
		checked
		{
			int num = this.m_ef.Count - 1;
			bool flag = this.m_df.dh().a8();
			if (!flag)
			{
				fb().Size = new Size(910, fb().Height);
			}
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				this.m_ef[num3].Visible = flag;
				if (!flag)
				{
					this.m_eh[num3].Size = new Size(908, this.m_eh[num3].Height);
					bb().Location = new Point(950, bb().Top);
				}
			}
			fc().Visible = flag;
			fk().Visible = flag;
			fj().Visible = flag;
		}
	}

	private bool b()
	{
		foreach (gc item in this.m_du.l())
		{
			if (item.w)
			{
				return true;
			}
		}
		return false;
	}

	private bool a()
	{
		string A_ = null;
		checked
		{
			int A_2 = default(int);
			if (!a(ref A_, ref A_2))
			{
				if (A_2 + 5 > this.m_dn - 1)
				{
					this.m_dk = this.m_dn - 1;
					this.m_dj = this.m_dk - 5;
					if (this.m_dj < 0)
					{
						this.m_dj = 0;
					}
				}
				else
				{
					this.m_dj = A_2;
					this.m_dk = this.m_dj + 5;
				}
				this.m_dl = this.m_dj;
				i();
				global::fe.b(this.m_dr, A_, f());
				return false;
			}
			return true;
		}
	}

	private bool a(ref string A_0, ref int A_1)
	{
		checked
		{
			int num = this.m_du.l().Count - 1;
			for (A_1 = 0; A_1 <= num; A_1++)
			{
				gc gc2 = this.m_du.l()[A_1];
				gc gc3 = gc2;
				if (gc3.af(this.m_ey) && (gc3.av() < 1.0 || gc3.av() > 100.0))
				{
					string A_2 = "ValuesBetweenFmt3";
					string format = hu.a(ref A_2);
					A_2 = "RecipeThicknessConstraintFmt";
					A_0 = string.Format(format, string.Format(hu.a(ref A_2), (A_1 + 1).ToString()), 1f, 100f);
					return false;
				}
				if (gc3.ah(this.m_ex) && gc3.aw() <= 0.0)
				{
					string A_2 = "ValueFor1MustBe2Than3";
					string format2 = hu.a(ref A_2);
					A_2 = "RecipeNConstraintFmt";
					A_0 = string.Format(format2, string.Format(hu.a(ref A_2), (A_1 + 1).ToString()), ">", 0f);
					return false;
				}
				if (gc3.aj(this.m_ex) && gc3.ax() <= 0.0)
				{
					string A_2 = "ValueFor1MustBe2Than3";
					string format3 = hu.a(ref A_2);
					A_2 = "RecipeKConstraintFmt";
					A_0 = string.Format(format3, string.Format(hu.a(ref A_2), (A_1 + 1).ToString()), ">", 0f);
					return false;
				}
				bool flag = Operators.CompareString(gc2.ag(), "<Roughness>", TextCompare: false) == 0 || Operators.CompareString(gc2.ag(), "<Graded Interface>", TextCompare: false) == 0;
				if (this.m_du.l().Count - 1 > A_1)
				{
					string left = this.m_du.l()[A_1 + 1].ag();
					bool flag2 = Operators.CompareString(left, "<Roughness>", TextCompare: false) == 0 || Operators.CompareString(left, "<Graded Interface>", TextCompare: false) == 0;
					if (flag && flag2)
					{
						string A_2 = "ErrRecipeInvalidAdjacentLayerTypes";
						A_0 = hu.a(ref A_2);
						return false;
					}
				}
				if (this.m_du.m() && A_1 == this.m_du.l().Count - 1 && (Operators.CompareString(gc2.ag(), "<Roughness>", TextCompare: false) == 0 || Operators.CompareString(gc2.ag(), "<Graded Interface>", TextCompare: false) == 0))
				{
					string A_2 = "ErrLayerInvalidType";
					A_0 = hu.a(ref A_2);
					return false;
				}
				gc3 = null;
			}
			return true;
		}
	}
}
