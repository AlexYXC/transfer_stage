using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Filmetrics.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class by : UserControl
{
	private enum a
	{
		a,
		b,
		c,
		d
	}

	private delegate void b(r.d A_0, bool A_1, r.d.a.b A_2);

	private IContainer m_a;

	[CompilerGenerated]
	private GroupBox m_b;

	[CompilerGenerated]
	private Label m_c;

	[CompilerGenerated]
	private Label m_d;

	[CompilerGenerated]
	private Label m_e;

	[CompilerGenerated]
	private PictureBox m_f;

	[CompilerGenerated]
	private fl m_g;

	[CompilerGenerated]
	private GroupBox m_h;

	[CompilerGenerated]
	private Label m_i;

	[CompilerGenerated]
	private Label m_j;

	[CompilerGenerated]
	private hx m_k;

	[CompilerGenerated]
	private hx m_l;

	[CompilerGenerated]
	private fl m_m;

	[CompilerGenerated]
	private Label m_n;

	[CompilerGenerated]
	private Label m_o;

	[CompilerGenerated]
	private ToolTip m_p;

	[CompilerGenerated]
	private ContextMenuStrip m_q;

	[CompilerGenerated]
	private ToolStripMenuItem m_r;

	[CompilerGenerated]
	private TableLayoutPanel m_s;

	[CompilerGenerated]
	private TableLayoutPanel m_t;

	[CompilerGenerated]
	private TableLayoutPanel m_u;

	[CompilerGenerated]
	private TableLayoutPanel m_v;

	[CompilerGenerated]
	private Label m_w;

	[CompilerGenerated]
	private TableLayoutPanel m_x;

	[CompilerGenerated]
	private ContextMenuStrip m_y;

	[CompilerGenerated]
	private ToolStripMenuItem m_z;

	[CompilerGenerated]
	private OpenFileDialog m_aa;

	[CompilerGenerated]
	private ComboBox m_ab;

	[CompilerGenerated]
	private TabControl m_ac;

	[CompilerGenerated]
	private TabPage m_ad;

	[CompilerGenerated]
	private TabPage m_ae;

	[CompilerGenerated]
	private Button m_af;

	[CompilerGenerated]
	private Button m_ag;

	[CompilerGenerated]
	private Label m_ah;

	[CompilerGenerated]
	private Label m_ai;

	[CompilerGenerated]
	private Label m_aj;

	[CompilerGenerated]
	private Label m_ak;

	[CompilerGenerated]
	private Label m_al;

	[CompilerGenerated]
	private Label m_am;

	[CompilerGenerated]
	private Button m_an;

	[CompilerGenerated]
	private Button m_ao;

	[CompilerGenerated]
	private Button m_ap;

	[CompilerGenerated]
	private Label m_aq;

	[CompilerGenerated]
	private Label m_ar;

	[CompilerGenerated]
	private Label m_as;

	[CompilerGenerated]
	private Label m_at;

	[CompilerGenerated]
	private Label m_au;

	[CompilerGenerated]
	private Label m_av;

	[CompilerGenerated]
	private Label m_aw;

	[CompilerGenerated]
	private Label m_ax;

	[CompilerGenerated]
	private Label m_ay;

	[CompilerGenerated]
	private Label m_az;

	[CompilerGenerated]
	private Label m_a0;

	[CompilerGenerated]
	private hy m_a1;

	[CompilerGenerated]
	private hy m_a2;

	[CompilerGenerated]
	private hy m_a3;

	[CompilerGenerated]
	private hy m_a4;

	[CompilerGenerated]
	private hy m_a5;

	[CompilerGenerated]
	private hy m_a6;

	[CompilerGenerated]
	private hy m_a7;

	[CompilerGenerated]
	private hy m_a8;

	[CompilerGenerated]
	private GroupBox m_a9;

	[CompilerGenerated]
	private GroupBox m_ba;

	[CompilerGenerated]
	private GroupBox m_bb;

	[CompilerGenerated]
	private Button m_bc;

	[CompilerGenerated]
	private Button m_bd;

	[CompilerGenerated]
	private SaveFileDialog m_be;

	[CompilerGenerated]
	private GroupBox m_bf;

	[CompilerGenerated]
	private Label m_bg;

	[CompilerGenerated]
	private Label m_bh;

	[CompilerGenerated]
	private Label m_bi;

	[CompilerGenerated]
	private Label m_bj;

	[CompilerGenerated]
	private SaveFileDialog m_bk;

	[CompilerGenerated]
	private Label m_bl;

	[CompilerGenerated]
	private GroupBox m_bm;

	[CompilerGenerated]
	private GroupBox m_bn;

	[CompilerGenerated]
	private TextBox m_bo;

	[CompilerGenerated]
	private TextBox m_bp;

	[CompilerGenerated]
	private Label m_bq;

	[CompilerGenerated]
	private Label m_br;

	[CompilerGenerated]
	private Label m_bs;

	[CompilerGenerated]
	private Label m_bt;

	public const bool bu = false;

	private const int m_bv = 2;

	private const int m_bw = 7;

	private const int m_bx = 8;

	private const string m_by = "VsTime";

	private const string bz = "FIControlPanelVsTime";

	private double b0;

	private double b1;

	private ReadOnlyCollection<float> m_b2;

	private ReadOnlyCollection<float> m_b3;

	private f1 m_b4;

	private Guid m_b5;

	private object m_b6;

	private int m_b7;

	private fz m_b8;

	private gq m_b9;

	private fl m_ca;

	private hs m_cb;

	private e9 m_cc;

	private r.l m_cd;

	[CompilerGenerated]
	private r.d m_ce;

	[CompilerGenerated]
	private r.d m_cf;

	[CompilerGenerated]
	private r.d cg;

	[CompilerGenerated]
	private r.d ch;

	[CompilerGenerated]
	private r.d ci;

	[CompilerGenerated]
	private r.d cj;

	private jl.e ck;

	private jl.g cl;

	private jl.i cm;

	private hg cn;

	private jk.a co;

	private jl cp;

	[SpecialName]
	private object cq;

	[SpecialName]
	private StaticLocalInitFlag cr;

	[SpecialName]
	private jl.c cs;

	[SpecialName]
	private bool ct;

	[SpecialName]
	private IAsyncResult cu;

	[SpecialName]
	private StaticLocalInitFlag cv;

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
	private void f()
	{
		this.m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(by));
		a(new GroupBox());
		c(new TableLayoutPanel());
		d(new TableLayoutPanel());
		c(new Label());
		h(new Label());
		e(new TableLayoutPanel());
		g(new Label());
		a(new Label());
		f(new Label());
		b(new Label());
		b(new GroupBox());
		a(new TableLayoutPanel());
		e(new Label());
		d(new Label());
		a(new PictureBox());
		a(new ToolTip(this.m_a));
		a(new ContextMenuStrip(this.m_a));
		a(new ToolStripMenuItem());
		b(new TableLayoutPanel());
		b(new ContextMenuStrip(this.m_a));
		b(new ToolStripMenuItem());
		a(new OpenFileDialog());
		a(new ComboBox());
		a(new TabControl());
		a(new TabPage());
		h(new GroupBox());
		a(new TextBox());
		b(new TextBox());
		ae(new Label());
		af(new Label());
		ag(new Label());
		ah(new Label());
		g(new GroupBox());
		ad(new Label());
		j(new Label());
		i(new Label());
		f(new Button());
		e(new GroupBox());
		r(new Label());
		a(new Button());
		b(new Button());
		k(new Label());
		l(new Label());
		n(new Label());
		m(new Label());
		b(new TabPage());
		f(new GroupBox());
		ab(new Label());
		ac(new Label());
		aa(new Label());
		z(new Label());
		o(new Label());
		p(new Label());
		g(new Button());
		c(new GroupBox());
		s(new Label());
		t(new Label());
		u(new Label());
		v(new Label());
		w(new Label());
		x(new Label());
		y(new Label());
		d(new GroupBox());
		c(new Button());
		q(new Label());
		e(new Button());
		d(new Button());
		a(new SaveFileDialog());
		b(new SaveFileDialog());
		a(new hx());
		b(new hx());
		a(new hy());
		b(new hy());
		c(new hy());
		d(new hy());
		e(new hy());
		f(new hy());
		g(new hy());
		h(new hy());
		c(new fl());
		b(new fl());
		g().SuspendLayout();
		z().SuspendLayout();
		aa().SuspendLayout();
		ac().SuspendLayout();
		m().SuspendLayout();
		x().SuspendLayout();
		((ISupportInitialize)k()).BeginInit();
		v().SuspendLayout();
		y().SuspendLayout();
		ad().SuspendLayout();
		ah().SuspendLayout();
		ai().SuspendLayout();
		bs().SuspendLayout();
		br().SuspendLayout();
		bg().SuspendLayout();
		aj().SuspendLayout();
		bk().SuspendLayout();
		be().SuspendLayout();
		bf().SuspendLayout();
		SuspendLayout();
		componentResourceManager.ApplyResources(g(), "GroupMeasSetup");
		g().Controls.Add(z());
		g().Name = "GroupMeasSetup";
		g().TabStop = false;
		componentResourceManager.ApplyResources(z(), "TableLayoutPanelCursorOuter");
		z().Controls.Add(aa(), 0, 0);
		z().Controls.Add(ac(), 0, 1);
		z().Name = "TableLayoutPanelCursorOuter";
		componentResourceManager.ApplyResources(aa(), "TableLayoutPanelCursorWavelength");
		aa().Controls.Add(j(), 1, 0);
		aa().Controls.Add(ab(), 0, 0);
		aa().Name = "TableLayoutPanelCursorWavelength";
		componentResourceManager.ApplyResources(j(), "LabelCursorX");
		j().BorderStyle = BorderStyle.Fixed3D;
		j().Name = "LabelCursorX";
		componentResourceManager.ApplyResources(ab(), "LabelCursorXTitle");
		ab().Name = "LabelCursorXTitle";
		componentResourceManager.ApplyResources(ac(), "TableLayoutPanelRefTransValues");
		ac().Controls.Add(t(), 3, 0);
		ac().Controls.Add(h(), 1, 0);
		ac().Controls.Add(s(), 2, 0);
		ac().Controls.Add(i(), 0, 0);
		ac().Name = "TableLayoutPanelRefTransValues";
		componentResourceManager.ApplyResources(t(), "LabelCursorY2");
		t().BorderStyle = BorderStyle.Fixed3D;
		t().Name = "LabelCursorY2";
		componentResourceManager.ApplyResources(h(), "LabelCursorY");
		h().BorderStyle = BorderStyle.Fixed3D;
		h().Name = "LabelCursorY";
		componentResourceManager.ApplyResources(s(), "LabelCursorY2Title");
		s().Name = "LabelCursorY2Title";
		componentResourceManager.ApplyResources(i(), "LabelCursorYTitle");
		i().Name = "LabelCursorYTitle";
		componentResourceManager.ApplyResources(m(), "GroupSampleInfo");
		m().Controls.Add(x());
		m().Name = "GroupSampleInfo";
		m().TabStop = false;
		componentResourceManager.ApplyResources(x(), "TableLayoutPanelUserInfo");
		x().Controls.Add(o(), 0, 0);
		x().Controls.Add(p(), 1, 1);
		x().Controls.Add(n(), 0, 1);
		x().Controls.Add(q(), 1, 0);
		x().Name = "TableLayoutPanelUserInfo";
		componentResourceManager.ApplyResources(o(), "LabelMeasSampleId");
		o().Name = "LabelMeasSampleId";
		componentResourceManager.ApplyResources(n(), "LabelMeasOperatorId");
		n().Name = "LabelMeasOperatorId";
		componentResourceManager.ApplyResources(k(), "PictureBoxLogo");
		k().Image = Resources.FilmLogoLrg;
		k().Name = "PictureBoxLogo";
		k().TabStop = false;
		v().Items.AddRange(new ToolStripItem[1] { w() });
		v().Name = "ContextMenuStripForImage";
		componentResourceManager.ApplyResources(v(), "ContextMenuStripForImage");
		w().Name = "ToolStripMenuItemSaveImage";
		componentResourceManager.ApplyResources(w(), "ToolStripMenuItemSaveImage");
		componentResourceManager.ApplyResources(y(), "TableLayoutPanelMeasInfo");
		y().Controls.Add(m(), 0, 0);
		y().Controls.Add(g(), 1, 0);
		y().Name = "TableLayoutPanelMeasInfo";
		ad().Items.AddRange(new ToolStripItem[1] { ae() });
		ad().Name = "NewCompositeContextMenuStrip";
		componentResourceManager.ApplyResources(ad(), "SelectRecipeRightClickContextMenuStrip");
		ae().Alignment = ToolStripItemAlignment.Right;
		ae().Name = "NewCompositeRecipeToolStripMenuItem";
		componentResourceManager.ApplyResources(ae(), "NewCompositeRecipeToolStripMenuItem");
		af().FileName = "OpenFileDialog1";
		ag().DropDownStyle = ComboBoxStyle.DropDownList;
		componentResourceManager.ApplyResources(ag(), "VILayerList");
		ag().Name = "VILayerList";
		componentResourceManager.ApplyResources(ah(), "TabControlMode");
		ah().Controls.Add(ai());
		ah().Controls.Add(aj());
		ah().Multiline = true;
		ah().Name = "TabControlMode";
		ah().SelectedIndex = 0;
		ai().Controls.Add(bs());
		ai().Controls.Add(br());
		ai().Controls.Add(bh());
		ai().Controls.Add(bg());
		ai().Controls.Add(a6());
		ai().Controls.Add(a7());
		ai().Controls.Add(a8());
		ai().Controls.Add(ao());
		ai().Controls.Add(ap());
		ai().Controls.Add(ar());
		ai().Controls.Add(aq());
		componentResourceManager.ApplyResources(ai(), "TabPageRvsT");
		ai().Name = "TabPageRvsT";
		ai().UseVisualStyleBackColor = true;
		bs().Controls.Add(bt());
		bs().Controls.Add(bu());
		bs().Controls.Add(bv());
		bs().Controls.Add(bw());
		bs().Controls.Add(bx());
		bs().Controls.Add(by());
		componentResourceManager.ApplyResources(bs(), "GroupBox6");
		bs().Name = "GroupBox6";
		bs().TabStop = false;
		bt().BackColor = SystemColors.Window;
		componentResourceManager.ApplyResources(bt(), "TResultBox");
		bt().Name = "TResultBox";
		bt().ReadOnly = true;
		bu().BackColor = SystemColors.Window;
		componentResourceManager.ApplyResources(bu(), "GResultBox");
		bu().Name = "GResultBox";
		bu().ReadOnly = true;
		componentResourceManager.ApplyResources(bv(), "TResultLabel");
		bv().Name = "TResultLabel";
		componentResourceManager.ApplyResources(bw(), "Label3");
		bw().Name = "Label3";
		componentResourceManager.ApplyResources(bx(), "GResultLabel");
		bx().Name = "GResultLabel";
		componentResourceManager.ApplyResources(by(), "Label2");
		by().Name = "Label2";
		br().Controls.Add(bq());
		br().Controls.Add(an());
		br().Controls.Add(am());
		componentResourceManager.ApplyResources(br(), "GroupBox1");
		br().Name = "GroupBox1";
		br().TabStop = false;
		bq().BackColor = SystemColors.Window;
		bq().BorderStyle = BorderStyle.Fixed3D;
		componentResourceManager.ApplyResources(bq(), "MvsTBox1");
		bq().Name = "MvsTBox1";
		componentResourceManager.ApplyResources(an(), "Label4");
		an().Name = "Label4";
		componentResourceManager.ApplyResources(am(), "Label1");
		am().ForeColor = Color.Black;
		am().Name = "Label1";
		componentResourceManager.ApplyResources(bh(), "EditRecipeRVsT");
		bh().Name = "EditRecipeRVsT";
		bh().UseVisualStyleBackColor = true;
		bg().Controls.Add(ay());
		bg().Controls.Add(ak());
		bg().Controls.Add(al());
		componentResourceManager.ApplyResources(bg(), "GroupBox4");
		bg().Name = "GroupBox4";
		bg().TabStop = false;
		componentResourceManager.ApplyResources(ay(), "LabelStandAlone");
		ay().Name = "LabelStandAlone";
		componentResourceManager.ApplyResources(ak(), "VsTimeStopButton");
		ak().Name = "VsTimeStopButton";
		ak().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(al(), "VsTimeStartButton");
		al().Name = "VsTimeStartButton";
		al().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ao(), "MvsTLabel7");
		ao().Name = "MvsTLabel7";
		componentResourceManager.ApplyResources(ap(), "LabelCA31");
		ap().Name = "LabelCA31";
		componentResourceManager.ApplyResources(ar(), "LabelCA30");
		ar().Name = "LabelCA30";
		componentResourceManager.ApplyResources(aq(), "MvsTLabel6");
		aq().Name = "MvsTLabel6";
		aj().Controls.Add(bk());
		aj().Controls.Add(bi());
		aj().Controls.Add(be());
		aj().Controls.Add(bf());
		componentResourceManager.ApplyResources(aj(), "TabPageDepRateNK");
		aj().Name = "TabPageDepRateNK";
		aj().UseVisualStyleBackColor = true;
		bk().Controls.Add(bn());
		bk().Controls.Add(bo());
		bk().Controls.Add(bm());
		bk().Controls.Add(bl());
		bk().Controls.Add(av());
		bk().Controls.Add(aw());
		componentResourceManager.ApplyResources(bk(), "GroupBox5");
		bk().Name = "GroupBox5";
		bk().TabStop = false;
		componentResourceManager.ApplyResources(bn(), "Label9");
		bn().Name = "Label9";
		bo().BackColor = SystemColors.Window;
		bo().BorderStyle = BorderStyle.Fixed3D;
		componentResourceManager.ApplyResources(bo(), "LabelTemperature");
		bo().Name = "LabelTemperature";
		componentResourceManager.ApplyResources(bm(), "Label8");
		bm().Name = "Label8";
		bl().BackColor = SystemColors.Window;
		bl().BorderStyle = BorderStyle.Fixed3D;
		componentResourceManager.ApplyResources(bl(), "LabelWavelength");
		bl().Name = "LabelWavelength";
		componentResourceManager.ApplyResources(av(), "Label16");
		av().Name = "Label16";
		componentResourceManager.ApplyResources(aw(), "Label15");
		aw().Name = "Label15";
		componentResourceManager.ApplyResources(bi(), "EditRecipeDepRateNK");
		bi().Name = "EditRecipeDepRateNK";
		bi().UseVisualStyleBackColor = true;
		be().Controls.Add(a9());
		be().Controls.Add(ba());
		be().Controls.Add(bb());
		be().Controls.Add(bc());
		be().Controls.Add(bd());
		be().Controls.Add(az());
		be().Controls.Add(a0());
		be().Controls.Add(a1());
		be().Controls.Add(a2());
		be().Controls.Add(a3());
		be().Controls.Add(a4());
		be().Controls.Add(a5());
		componentResourceManager.ApplyResources(be(), "GroupBox3");
		be().Name = "GroupBox3";
		be().TabStop = false;
		componentResourceManager.ApplyResources(az(), "TUnitLabel");
		az().Name = "TUnitLabel";
		componentResourceManager.ApplyResources(a0(), "GUnitLabel");
		a0().Name = "GUnitLabel";
		componentResourceManager.ApplyResources(a1(), "Label24");
		a1().Name = "Label24";
		componentResourceManager.ApplyResources(a2(), "Label23");
		a2().Name = "Label23";
		componentResourceManager.ApplyResources(a3(), "Label22");
		a3().Name = "Label22";
		componentResourceManager.ApplyResources(a4(), "Label21");
		a4().Name = "Label21";
		componentResourceManager.ApplyResources(a5(), "Label20");
		a5().Name = "Label20";
		bf().Controls.Add(@as());
		bf().Controls.Add(ag());
		bf().Controls.Add(ax());
		bf().Controls.Add(au());
		bf().Controls.Add(at());
		componentResourceManager.ApplyResources(bf(), "GroupBox2");
		bf().Name = "GroupBox2";
		bf().TabStop = false;
		componentResourceManager.ApplyResources(@as(), "DoFitButton");
		@as().Name = "DoFitButton";
		@as().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ax(), "Label19");
		ax().Name = "Label19";
		componentResourceManager.ApplyResources(au(), "TakeDataButton");
		au().Name = "TakeDataButton";
		au().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(at(), "StopDataButton");
		at().Name = "StopDataButton";
		at().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(p(), "TextBoxOperatorId");
		p().Name = "TextBoxOperatorId";
		componentResourceManager.ApplyResources(q(), "SampleBox");
		q().Name = "SampleBox";
		componentResourceManager.ApplyResources(a6(), "AixtronStop");
		a6().f(A_0: false);
		a6().Name = "AixtronStop";
		a6().e(A_0: false);
		componentResourceManager.ApplyResources(a7(), "AixtronStart");
		a7().f(A_0: false);
		a7().Name = "AixtronStart";
		a7().e(A_0: false);
		componentResourceManager.ApplyResources(a8(), "ExtremaBox");
		a8().f(A_0: false);
		a8().Name = "ExtremaBox";
		a8().e(A_0: false);
		a8().ReadOnly = true;
		componentResourceManager.ApplyResources(a9(), "TBNx");
		a9().f(A_0: false);
		a9().Name = "TBNx";
		a9().e(A_0: false);
		a9().ReadOnly = true;
		componentResourceManager.ApplyResources(ba(), "TBNk");
		ba().f(A_0: false);
		ba().Name = "TBNk";
		ba().e(A_0: false);
		ba().ReadOnly = true;
		componentResourceManager.ApplyResources(bb(), "TBNn");
		bb().f(A_0: false);
		bb().Name = "TBNn";
		bb().e(A_0: false);
		bb().ReadOnly = true;
		componentResourceManager.ApplyResources(bc(), "TBNThickness");
		bc().f(A_0: false);
		bc().Name = "TBNThickness";
		bc().e(A_0: false);
		bc().ReadOnly = true;
		componentResourceManager.ApplyResources(bd(), "TBNGrowthRate");
		bd().f(A_0: false);
		bd().Name = "TBNGrowthRate";
		bd().e(A_0: false);
		bd().ReadOnly = true;
		r().o((gq)null);
		r().v(A_0: false);
		r().AllowDrop = true;
		r().u(A_0: false);
		componentResourceManager.ApplyResources(r(), "GraphMeasIndex");
		r().BackColor = Color.Transparent;
		r().w(A_0: false);
		r().al(A_0: true);
		r().x(A_0: false);
		r().r("Right-click activates/deactivates Cursor");
		r().y(A_0: true);
		r().z(A_0: false);
		r().aa(A_0: false);
		r().ab(A_0: false);
		r().o((fz)null);
		r().ad(A_0: false);
		r().Name = "GraphMeasIndex";
		r().q("SiO2 on Si Spectrum taken 01/31/2007 12:34 PM ");
		r().q(1);
		r().t(A_0: false);
		r().am(A_0: false);
		r().t((string)null);
		r().an(A_0: true);
		r().ae(A_0: false);
		r().af(A_0: false);
		r().ag(A_0: true);
		r().o((fu)null);
		r().aj(A_0: false);
		r().ai(A_0: true);
		r().s((string)null);
		l().o((gq)null);
		l().v(A_0: false);
		l().AllowDrop = true;
		l().u(A_0: false);
		componentResourceManager.ApplyResources(l(), "GraphMeasThickness");
		l().BackColor = Color.Transparent;
		l().w(A_0: false);
		l().al(A_0: true);
		l().x(A_0: false);
		l().r("");
		l().y(A_0: true);
		l().z(A_0: false);
		l().aa(A_0: false);
		l().ab(A_0: false);
		l().o((fz)null);
		l().ad(A_0: false);
		l().Name = "GraphMeasThickness";
		l().q("SiO2 on Si Spectrum taken 01/31/2007 12:34 PM ");
		l().q(1);
		l().t(A_0: false);
		l().am(A_0: false);
		l().t((string)null);
		l().an(A_0: true);
		l().ae(A_0: false);
		l().af(A_0: false);
		l().ag(A_0: true);
		l().o((fu)null);
		l().aj(A_0: false);
		l().ai(A_0: true);
		l().s("");
		componentResourceManager.ApplyResources(this, "$this");
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = SystemColors.ButtonFace;
		base.Controls.Add(y());
		base.Controls.Add(ah());
		base.Controls.Add(k());
		base.Controls.Add(r());
		base.Controls.Add(l());
		DoubleBuffered = true;
		base.Name = "FIControlPanelVsTime";
		g().ResumeLayout(performLayout: false);
		g().PerformLayout();
		z().ResumeLayout(performLayout: false);
		z().PerformLayout();
		aa().ResumeLayout(performLayout: false);
		aa().PerformLayout();
		ac().ResumeLayout(performLayout: false);
		ac().PerformLayout();
		m().ResumeLayout(performLayout: false);
		m().PerformLayout();
		x().ResumeLayout(performLayout: false);
		x().PerformLayout();
		((ISupportInitialize)k()).EndInit();
		v().ResumeLayout(performLayout: false);
		y().ResumeLayout(performLayout: false);
		y().PerformLayout();
		ad().ResumeLayout(performLayout: false);
		ah().ResumeLayout(performLayout: false);
		ai().ResumeLayout(performLayout: false);
		ai().PerformLayout();
		bs().ResumeLayout(performLayout: false);
		bs().PerformLayout();
		br().ResumeLayout(performLayout: false);
		br().PerformLayout();
		bg().ResumeLayout(performLayout: false);
		aj().ResumeLayout(performLayout: false);
		bk().ResumeLayout(performLayout: false);
		bk().PerformLayout();
		be().ResumeLayout(performLayout: false);
		be().PerformLayout();
		bf().ResumeLayout(performLayout: false);
		bf().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox g()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(GroupBox A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label h()
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
	internal virtual Label i()
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
	internal virtual Label j()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox k()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(PictureBox A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual fl l()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(fl A_0)
	{
		fl.d a_ = d;
		fl.e a_2 = a;
		fl.s a_3 = a;
		fl.ad a_4 = c;
		fl.ad a_5 = cd;
		fl fl2 = this.m_g;
		if (fl2 != null)
		{
			fl2.p(a_);
			fl2.p(a_2);
			fl2.p(a_3);
			fl2.p(a_4);
			fl2.p(a_5);
		}
		this.m_g = A_0;
		fl2 = this.m_g;
		if (fl2 != null)
		{
			fl2.o(a_);
			fl2.o(a_2);
			fl2.o(a_3);
			fl2.o(a_4);
			fl2.o(a_5);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox m()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(GroupBox A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label n()
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
	internal virtual Label o()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx p()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hx A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx q()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(hx A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual fl r()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(fl A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label s()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label t()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Label A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip u()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolTip A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ContextMenuStrip v()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ContextMenuStrip A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem w()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolStripMenuItem A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel x()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel y()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel z()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel aa()
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
	internal virtual Label ab()
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
	internal virtual TableLayoutPanel ac()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TableLayoutPanel A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ContextMenuStrip ad()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ContextMenuStrip A_0)
	{
		this.m_y = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem ae()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ToolStripMenuItem A_0)
	{
		this.m_z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual OpenFileDialog af()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(OpenFileDialog A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox ag()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
	{
		EventHandler value = g;
		ComboBox comboBox = this.m_ab;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_ab = A_0;
		comboBox = this.m_ab;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabControl ah()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TabControl A_0)
	{
		EventHandler value = d;
		TabControl tabControl = this.m_ac;
		if (tabControl != null)
		{
			tabControl.SelectedIndexChanged -= value;
		}
		this.m_ac = A_0;
		tabControl = this.m_ac;
		if (tabControl != null)
		{
			tabControl.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage ai()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TabPage A_0)
	{
		this.m_ad = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage aj()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TabPage A_0)
	{
		this.m_ae = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ak()
	{
		return this.m_af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = a;
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
	internal virtual Button al()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = b;
		Button button = this.m_ag;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ag = A_0;
		button = this.m_ag;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label am()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Label A_0)
	{
		this.m_ah = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label an()
	{
		return this.m_ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Label A_0)
	{
		this.m_ai = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ao()
	{
		return this.m_aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Label A_0)
	{
		this.m_aj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ap()
	{
		return this.m_ak;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(Label A_0)
	{
		this.m_ak = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aq()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(Label A_0)
	{
		this.m_al = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ar()
	{
		return this.m_am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(Label A_0)
	{
		this.m_am = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button @as()
	{
		return this.m_an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = h;
		Button button = this.m_an;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_an = A_0;
		button = this.m_an;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button at()
	{
		return this.m_ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Button A_0)
	{
		EventHandler value = a;
		Button button = this.m_ao;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ao = A_0;
		button = this.m_ao;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button au()
	{
		return this.m_ap;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Button A_0)
	{
		EventHandler value = b;
		Button button = this.m_ap;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ap = A_0;
		button = this.m_ap;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label av()
	{
		return this.m_aq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(Label A_0)
	{
		this.m_aq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aw()
	{
		return this.m_ar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(Label A_0)
	{
		this.m_ar = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ax()
	{
		return this.m_as;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void q(Label A_0)
	{
		this.m_as = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ay()
	{
		return this.m_at;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void r(Label A_0)
	{
		this.m_at = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label az()
	{
		return this.m_au;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(Label A_0)
	{
		EventHandler value = c;
		Label label = this.m_au;
		if (label != null)
		{
			label.Click -= value;
		}
		this.m_au = A_0;
		label = this.m_au;
		if (label != null)
		{
			label.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a0()
	{
		return this.m_av;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void t(Label A_0)
	{
		EventHandler value = c;
		Label label = this.m_av;
		if (label != null)
		{
			label.Click -= value;
		}
		this.m_av = A_0;
		label = this.m_av;
		if (label != null)
		{
			label.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a1()
	{
		return this.m_aw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void u(Label A_0)
	{
		this.m_aw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a2()
	{
		return this.m_ax;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void v(Label A_0)
	{
		this.m_ax = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a3()
	{
		return this.m_ay;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void w(Label A_0)
	{
		this.m_ay = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a4()
	{
		return this.m_az;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void x(Label A_0)
	{
		this.m_az = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a5()
	{
		return this.m_a0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void y(Label A_0)
	{
		this.m_a0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy a6()
	{
		return this.m_a1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hy A_0)
	{
		this.m_a1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy a7()
	{
		return this.m_a2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(hy A_0)
	{
		this.m_a2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy a8()
	{
		return this.m_a3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(hy A_0)
	{
		this.m_a3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy a9()
	{
		return this.m_a4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(hy A_0)
	{
		this.m_a4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy ba()
	{
		return this.m_a5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(hy A_0)
	{
		this.m_a5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy bb()
	{
		return this.m_a6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(hy A_0)
	{
		this.m_a6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy bc()
	{
		return this.m_a7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(hy A_0)
	{
		this.m_a7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy bd()
	{
		return this.m_a8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(hy A_0)
	{
		this.m_a8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox be()
	{
		return this.m_a9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(GroupBox A_0)
	{
		this.m_a9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox bf()
	{
		return this.m_ba;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(GroupBox A_0)
	{
		this.m_ba = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox bg()
	{
		return this.m_bb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(GroupBox A_0)
	{
		this.m_bb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button bh()
	{
		return this.m_bc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Button A_0)
	{
		EventHandler value = f;
		Button button = this.m_bc;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_bc = A_0;
		button = this.m_bc;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button bi()
	{
		return this.m_bd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Button A_0)
	{
		EventHandler value = e;
		Button button = this.m_bd;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_bd = A_0;
		button = this.m_bd;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual SaveFileDialog bj()
	{
		return this.m_be;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(SaveFileDialog A_0)
	{
		this.m_be = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox bk()
	{
		return this.m_bf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(GroupBox A_0)
	{
		this.m_bf = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bl()
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
	internal virtual Label bm()
	{
		return this.m_bh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aa(Label A_0)
	{
		this.m_bh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bn()
	{
		return this.m_bi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ab(Label A_0)
	{
		this.m_bi = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bo()
	{
		return this.m_bj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ac(Label A_0)
	{
		this.m_bj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual SaveFileDialog bp()
	{
		return this.m_bk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(SaveFileDialog A_0)
	{
		this.m_bk = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bq()
	{
		return this.m_bl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(Label A_0)
	{
		this.m_bl = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox br()
	{
		return this.m_bm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(GroupBox A_0)
	{
		this.m_bm = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox bs()
	{
		return this.m_bn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(GroupBox A_0)
	{
		this.m_bn = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox bt()
	{
		return this.m_bo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TextBox A_0)
	{
		this.m_bo = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox bu()
	{
		return this.m_bp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TextBox A_0)
	{
		this.m_bp = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bv()
	{
		return this.m_bq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ae(Label A_0)
	{
		EventHandler value = c;
		Label label = this.m_bq;
		if (label != null)
		{
			label.Click -= value;
		}
		this.m_bq = A_0;
		label = this.m_bq;
		if (label != null)
		{
			label.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bw()
	{
		return this.m_br;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void af(Label A_0)
	{
		this.m_br = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bx()
	{
		return this.m_bs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ag(Label A_0)
	{
		EventHandler value = c;
		Label label = this.m_bs;
		if (label != null)
		{
			label.Click -= value;
		}
		this.m_bs = A_0;
		label = this.m_bs;
		if (label != null)
		{
			label.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label by()
	{
		return this.m_bt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ah(Label A_0)
	{
		this.m_bt = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d b2()
	{
		return this.m_ce;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		r.d.b a_ = a;
		this.m_ce?.e(a_);
		this.m_ce = A_0;
		this.m_ce?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d b3()
	{
		return this.m_cf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void b(r.d A_0)
	{
		r.d.b a_ = b;
		this.m_cf?.e(a_);
		this.m_cf = A_0;
		this.m_cf?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d b4()
	{
		return cg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void c(r.d A_0)
	{
		r.d.b a_ = d;
		cg?.e(a_);
		cg = A_0;
		cg?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d b5()
	{
		return ch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void d(r.d A_0)
	{
		r.d.b a_ = c;
		ch?.e(a_);
		ch = A_0;
		ch?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d b6()
	{
		return ci;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void e(r.d A_0)
	{
		r.d.b a_ = c;
		ci?.e(a_);
		ci = A_0;
		ci?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d b7()
	{
		return cj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void f(r.d A_0)
	{
		r.d.b a_ = c;
		cj?.e(a_);
		cj = A_0;
		cj?.d(a_);
	}

	[DllImport("fmparerf.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short ParseERFwT([MarshalAs(UnmanagedType.VBByRefStr)] ref string A_0, ref double A_1, ref double A_2);

	[DllImport("fm_via.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short AAdvisor(ref float A_0, ref float A_1, short A_2, ref short A_3, ref float A_4, ref float A_5, ref float A_6, ref float A_7, ref short A_8, ref float A_9);

	[DllImport("fm_via.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short AGetRSubstrate(ref float A_0, float A_1, float A_2, float A_3);

	public by()
	{
		this.m_cd = new r.l();
		a(new r.d());
		b(new r.d());
		c(new r.d());
		d(new r.d());
		e(new r.d());
		f(new r.d());
		f();
	}

	public by(Guid A_0, f1 A_1, fz A_2, hs A_3, Collection<gn> A_4, ew.a A_5, gq A_6, fm A_7)
		: this()
	{
		this.m_b8 = A_2;
		this.m_b4 = A_1;
		this.m_b5 = A_0;
		this.m_cb = A_3;
		this.m_b6 = RuntimeHelpers.GetObjectValue(new object());
		fl obj = l();
		obj.ae(A_0: true);
		obj.af(A_0: true);
		obj.ga = false;
		obj.gb = false;
		obj.z(A_0: false);
		obj.aa(A_0: true);
		obj.ab(A_0: true);
		obj.o(A_4[5]);
		obj.o(this.m_b8);
		obj.ac(j());
		obj.ae(h());
		obj.af(i());
		obj.ag(t());
		obj.ah(s());
		obj.o(this.m_b9);
		obj.o(A_7);
		obj.v(A_0: true);
		obj.u(A_0: true);
		string A_8 = "GraphVsTimeToolTip";
		obj.r(hu.a(ref A_8));
		obj.ah(A_0: true);
		obj.an(A_0: false);
		_ = null;
		fl obj2 = r();
		obj2.ae(A_0: true);
		obj2.af(A_0: true);
		obj2.z(A_0: false);
		obj2.aa(A_0: false);
		obj2.ab(A_0: false);
		obj2.ga = false;
		obj2.o(A_4[0]);
		obj2.o(this.m_b8);
		obj2.ac(j());
		obj2.ae(h());
		obj2.af(i());
		obj2.ag(t());
		obj2.ah(s());
		obj2.o(this.m_b9);
		obj2.ek = true;
		obj2.x(A_0: true);
		obj2.o(A_7);
		obj2.an(A_0: true);
		_ = null;
		this.m_cc = new e9(A_2);
		hs.a a_ = a;
		this.m_cb.b(a_);
		fl.p a_2 = a;
		l().o(a_2);
		fl.r a_3 = a;
		l().o(a_3);
		fl.v a_4 = a;
		l().o(a_4);
		r().o(a_4);
		fl.w a_5 = a;
		l().o(a_5);
		r().o(a_5);
		this.m_b4.m2(this.m_b5, a, ref ck);
		this.m_b4.m2(this.m_b5, a, ref cl);
		this.m_b4.m2(this.m_b5, a, ref cm);
		cn = this.m_b4.wq(this.m_b5);
		cn.bu(a, a);
		this.m_b4.wc(this.m_b5).d((r.d.b)e);
		this.m_cd.m = b2();
		e();
	}

	public void b8()
	{
		this.m_cb.c(a);
		cn.bv(a, a);
		this.m_cc.b();
		this.m_cc = null;
		ck(a);
		cl(a);
		cm(a);
	}

	[SpecialName]
	public string b9()
	{
		string text = q().Text;
		if (string.IsNullOrEmpty(text))
		{
			string A_ = "Unknown";
			text = hu.a(ref A_);
		}
		return text;
	}

	private void e()
	{
		if (r().fg() == 0)
		{
			gp.a(l(), hr.t(this.m_b4.s4(this.m_b5), 0f), A_2: true);
		}
		if (r().fg() == 0)
		{
			gp.a(fl.h.a, r(), this.m_b4.s4(this.m_b5), A_3: true);
		}
	}

	private void a(fl A_0)
	{
		a(A_0, A_1: false);
	}

	private void a(fl A_0, bool A_1)
	{
		if (A_0 == null)
		{
			A_0 = l();
		}
		bool flag = A_0 != this.m_ca;
		bool flag2 = Operators.CompareString(A_0.gj(), ab().Text, TextCompare: false) != 0 || Operators.CompareString(A_0.r(0), i().Text, TextCompare: false) != 0 || Operators.CompareString(A_0.r(1), s().Text, TextCompare: false) != 0;
		if (flag || flag2)
		{
			this.m_ca = A_0;
			A_0.g9();
		}
		if (A_0.go())
		{
			if (h().Left == j().Left || A_1 || flag || !s().Visible)
			{
				ab().Text = A_0.gj() + ":";
				s().Visible = true;
				t().Visible = true;
			}
		}
		else if (h().Left != j().Left || h().Width != j().Width || A_1 || flag)
		{
			ab().Text = A_0.gj() + ":";
			s().Visible = false;
			t().Visible = false;
		}
	}

	private void a(fl A_0, bool A_1, ref bool A_2)
	{
		if (A_1)
		{
			if (A_0 == l())
			{
				if (r().gt())
				{
					r().g5();
				}
			}
			else if (A_0 == r() && l().gt())
			{
				l().g5();
			}
			a(A_0);
			A_2 = false;
		}
		else if (A_0 == l())
		{
			A_2 = r().Visible && r().gt();
		}
		else if (A_0 == r())
		{
			A_2 = l().Visible && l().gt();
		}
	}

	private void d()
	{
		try
		{
			cf();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_b8, this.m_b4, null, i6.a(this), "FIControlPanelVsTime.GraphMeasThickness_F30LeftMouseUp", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(PointF A_0)
	{
		try
		{
			if (ah().SelectedTab == ai() && l().fg() != 0)
			{
				a8().Text = this.m_b4.m2(this.m_b5, A_0.X, A_0.Y, l().e7()).ToString("0.0");
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_b8, this.m_b4, null, i6.a(this), "FIControlPanelVsTime.GraphMeasThickness_LeftMouseClick", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		try
		{
			cf();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_b8, this.m_b4, null, i6.a(this), "FIControlPanelVsTime.DoFitButton_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private float a(float A_0, float A_1)
	{
		float num = (float)(1163.6746 - 1223.7016 * (double)A_0 + 482.2186 * (double)A_0 * (double)A_0 - 84.29636 * (double)A_0 * (double)A_0 * (double)A_0 + 5.511113 * (double)A_0 * (double)A_0 * (double)A_0 * (double)A_0);
		float num2 = (float)((double)(A_0 - 3f) * 0.0007018 * (double)(580f - A_1));
		return num + num2;
	}

	private void g(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (ag().SelectedIndex == 0)
				{
					bo().Text = this.m_b2[0].ToString();
					fr obj = l().gi().a2();
					obj.am(0.0);
					obj.an(this.m_b3[ag().Items.Count - 1]);
					_ = null;
				}
				else if (ag().SelectedIndex > 0)
				{
					bo().Text = this.m_b2[ag().SelectedIndex].ToString();
					fr obj2 = l().gi().a2();
					obj2.am(this.m_b3[ag().SelectedIndex - 1]);
					obj2.an(this.m_b3[ag().SelectedIndex]);
					_ = null;
				}
				else
				{
					this.m_b4.p9(this.m_b5, new r.d(), global::r.d.a.b.a);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_b8, this.m_b4, null, i6.a(this), "FIControlPanelVsTime.VILayerList_SelectedIndexChanged", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_cc.a(this.m_b4, this.m_b9, this.m_b5, A_3: false, p().Text, null, null, null, new e8.a(A_0: false, A_1: false, A_2: false, A_3: false, A_4: true, this.m_b5.ToString(), A_6: false, A_7: false, null, A_9: false), A_9: true, e8.f.a);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_cc.c();
			i5.a(this.m_b8, this.m_b4, null, i6.a(this), "FIControlPanelVsTime.EditRecipeRVsT_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_cc.a(this.m_b4, this.m_b9, this.m_b5, A_3: false, p().Text, null, null, null, new e8.a(A_0: false, A_1: false, A_2: false, A_3: false, A_4: true, this.m_b5.ToString(), A_6: false, A_7: false, null, A_9: false), A_9: true, e8.f.a);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_b8, this.m_b4, null, i6.a(this), "FIControlPanelVsTime.EditRecipeDepRateNK_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(long A_0, long A_1, r.d.a.b A_2)
	{
		try
		{
			string text = i6.a(this.m_b4.p9(this.m_b5, A_0), "0.0");
			bl().Text = text;
			bq().Text = text;
			if (ah().SelectedTab == ai())
			{
				cf();
			}
			else if (ah().SelectedTab == aj() && this.m_b4.st(this.m_b5))
			{
				cf();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_b8, this.m_b4, null, i6.a(this), "FIControlPanelVsTime.ActiveCurveChangedInGraphMeasThicknessHandler", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			if (ah().SelectedTab == ai())
			{
				if (l().fr())
				{
					cf();
				}
				else
				{
					this.m_b4.p9(this.m_b5, new r.d(), global::r.d.a.b.a);
				}
			}
			else if (l().fr())
			{
				cf();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_b8, this.m_b4, null, i6.a(this), "FIControlPanelVsTime.TabControlMode_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			hg hg2 = this.m_b4.wq(this.m_b5);
			jk.a a10 = hg2.b9().a;
			switch (a10)
			{
			case jk.a.a:
				a10 = jk.a.b;
				break;
			case jk.a.b:
				a10 = jk.a.c;
				break;
			case jk.a.c:
				a10 = jk.a.a;
				break;
			}
			hg2.b9().a = a10;
			hg2.b5(A_0: false);
			hg2.bv(global::e.a().OperatorID, DateTime.Now);
			hg2.bv(b3(), A_1: false);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_b8, this.m_b4, null, i6.a(this), "FIControlPanelVsTime.GorTResultLabel_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	public Guid ca()
	{
		return this.m_b5;
	}

	[SpecialName]
	public jn cb()
	{
		return this.m_b4.s3(this.m_b5);
	}

	public void cc()
	{
		af().Title = "Open File";
		af().Filter = "Vs Time Files|*.vst;*.fivst|Comma-separated Files|*.csv|Emcore Run Files|*.erf|Text Files|*.txt|All Files|*.*";
		af().FileName = "";
		af().CheckFileExists = true;
		af().ShowReadOnly = false;
		af().InitialDirectory = i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
		if (af().ShowDialog() == DialogResult.OK)
		{
			global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(af().FileName);
			this.m_b4.m2(this.m_b5, af().FileName, b5(), global::r.d.a.b.a);
		}
	}

	public void a(fu A_0, long A_1, long A_2)
	{
		b2 b10 = new b2();
		b10.a("FI Vs Time File (*.fivst)", "*.fivst", 1);
		b10.a("Legacy Vs Time File (*.vst)", "*.vst", 4);
		b10.a("Separated File (*.csv)", "*.csv", 3);
		b10.a("Text File (*.txt)", "*.txt", 2);
		bj().Title = "Save Data to File";
		bj().Filter = b10.b();
		bj().InitialDirectory = i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
		if (bj().ShowDialog() != DialogResult.OK)
		{
			return;
		}
		string text = b10.a(bj().FileName, bj().FilterIndex);
		global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(text);
		checked
		{
			int A_3 = default(int);
			if (b10.a(bj().FilterIndex) == 4)
			{
				if (this.m_b4.s3(this.m_b5).f.Count > 1)
				{
					ez ez2 = new ez();
					List<string> list = new List<string>();
					ReadOnlyCollection<float> readOnlyCollection = this.m_b4.s8(this.m_b5);
					string a_ = this.m_b4.s6(this.m_b5);
					int num = readOnlyCollection.Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						list.Add(a(num2, readOnlyCollection, a_));
					}
					ez2.a(list, this.m_b4.m2(this.m_b5, l().e7()), ref A_3);
					if (ez2.DialogResult != DialogResult.OK)
					{
						return;
					}
				}
				else
				{
					A_3 = 0;
				}
			}
			this.m_b4.m2(this.m_b5, text, A_3);
		}
	}

	private void a(object A_0, long A_1, long A_2)
	{
		a(A_1, A_2);
	}

	public void a(long A_0, long A_1)
	{
		checked
		{
			if (global::e.a().ConfirmBeforeClearingGraph)
			{
				Point point = i6.a(l());
				point.Y -= unchecked(l().Height / 2);
				ref fz a_ = ref this.m_b8;
				string A_2 = "ConfirmBeforeVsTimeDeleteQuery";
				string a_2 = hu.a(ref A_2);
				Point a_3 = point;
				A_2 = "DontAskMeThisAgain";
				bool A_3 = default(bool);
				if (!fe.b(ref a_, a_2, "ConfirmBeforeDeleteTitle", "Yes", "No", a_3, hu.a(ref A_2), ref A_3))
				{
					return;
				}
				global::e.a().ConfirmBeforeClearingGraph = !A_3;
			}
			if (this.m_b4.wq(this.m_b5).b8().av())
			{
				r().g1();
			}
			this.m_b4.m2(this.m_b5, b6(), global::r.d.a.b.a);
		}
	}

	private void c()
	{
		this.m_b4.p9(this.m_b5, new r.d(), global::r.d.a.b.a);
	}

	public void cd()
	{
		bd().Text = string.Empty;
		bc().Text = string.Empty;
		ba().Text = string.Empty;
		bb().Text = string.Empty;
		a9().Text = string.Empty;
		bu().Text = string.Empty;
		bt().Text = string.Empty;
	}

	public void ce()
	{
		cd();
		bl().Text = string.Empty;
		bq().Text = string.Empty;
		q().Text = string.Empty;
	}

	private void a(r.d A_0, bool A_1, r.d.a.b A_2)
	{
		if (base.InvokeRequired)
		{
			Invoke(new b(a), A_0, A_1, A_2);
		}
		else if (A_1)
		{
			this.m_b4.p9(this.m_b5, new r.d(), A_2);
		}
		else
		{
			cf();
		}
	}

	private void a(hg A_0)
	{
		cn.bv(a, a);
		cn = A_0;
		cn.bu(a, a);
	}

	public void a(int A_0, int A_1)
	{
		base.Width = A_0;
		base.Height = A_1;
		b();
	}

	private void b()
	{
		checked
		{
			int num = ah().Bottom - m().Bottom - 10;
			int num2 = 1;
			bool flag = !this.m_b4.tb(this.m_b5);
			if (flag)
			{
				num2++;
				num = unchecked(num / 2);
			}
			l().Top = m().Bottom + 10;
			l().Height = num;
			l().Width = ah().Location.X - 7;
			r().Visible = flag;
			if (flag)
			{
				r().Top = m().Bottom + 10 + num;
				r().Height = num;
				r().Width = ah().Location.X - 7;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_b4.m2(this.m_b5, b9(), global::e.a().OperatorID, b4(), this.m_cd, global::r.d.a.b.a, 0);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_b8, this.m_b4, null, i6.a(this), "FIControlPanelVsTime.VsTimeStartButton_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_cd.q(A_0: true);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_b8, this.m_b4, null, i6.a(this), "FIControlPanelVsTime.VsTimeStopButton_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d(r.d.a A_0)
	{
		if (A_0.a == global::r.d.a.a.b && A_0.a8() == global::r.d.a.b.a)
		{
			if (base.InvokeRequired)
			{
				Invoke(new r.d.b(d), A_0);
			}
			else
			{
				fz a_ = this.m_b8;
				string A_1 = "ErrVsTimeAcq";
				fe.b(a_, hu.a(ref A_1), i6.a(this));
			}
		}
		else
		{
			this.m_cb.b();
		}
	}

	private string a(int A_0, ReadOnlyCollection<float> A_1, string A_2)
	{
		return A_2 + "-" + A_1[A_0];
	}

	private void b(jl.c A_0)
	{
		checked
		{
			try
			{
				double[] A_1 = null;
				fl fl2 = l();
				bool flag = A_0.b == null || fl2.fg() != A_0.b.Count;
				if (!flag)
				{
					int num = A_0.b.Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						if (!fl2.o(A_0.c[num2], A_0.e[num2]))
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					fl2.g1();
					fl2.v(A_0: false);
					fl2.fs();
					this.m_cb.b();
				}
				fl2 = null;
				if (A_0.b == null)
				{
					return;
				}
				int num3 = A_0.b.Count - 1;
				int num6 = default(int);
				int num7 = default(int);
				for (int num4 = 0; num4 <= num3; num4++)
				{
					int num5 = l().p(A_0.c[num4], A_0.e[num4]);
					if (num5 != num6 || A_1 == null)
					{
						num7 = A_0.a.Count - num5 - 1;
						A_1 = new double[num7 + 1];
						int num8 = A_0.a.Count - 1;
						for (int num9 = num5; num9 <= num8; num9++)
						{
							A_1[num9 - num5] = A_0.a[num9];
						}
						num6 = num5;
					}
					double[] A_2 = new double[num7 + 1];
					ReadOnlyCollection<float> readOnlyCollection = A_0.b[num4];
					int num10 = A_0.a.Count - 1;
					for (int num11 = num5; num11 <= num10; num11++)
					{
						A_2[num11 - num5] = readOnlyCollection[num11];
					}
					readOnlyCollection = null;
					if ((double)A_0.a[A_0.a.Count - 1] > l().gi().a2().aq() - 10.0)
					{
						fr fr2;
						(fr2 = l().gi().a2()).an(fr2.aq() + 40.0);
					}
					l().o(ref A_1, ref A_2, num7 + 1, A_0.c[num4], A_0.e[num4], 0.0, a(num4, A_0.f, A_0.d), "VsTime", A_8: false, jl.o(A_0.g));
					l().o(jl.m(A_0.g), jl.l(A_0.g), jl.o(A_0.g));
				}
				l().v(A_0: true);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				if (A_0.h == global::r.d.a.b.a)
				{
					i5.a(this.m_b8, this.m_b4, null, i6.a(this), "FIControlPanelVsTime.DataChangedHandler", ex3);
				}
				else
				{
					this.m_b8.c(fz.b.b, "Error in FIControlPanelVsTime.DataChangedHandler.", ex3);
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private void a(jl.c A_0)
	{
		if (cr == null)
		{
			Interlocked.CompareExchange(ref cr, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(cr, ref lockTaken);
			if (cr.State == 0)
			{
				cr.State = 2;
				cq = RuntimeHelpers.GetObjectValue(new object());
			}
			else if (cr.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			cr.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(cr);
			}
		}
		if (base.InvokeRequired)
		{
			try
			{
				Monitor.Enter(RuntimeHelpers.GetObjectValue(cq));
				if (cs != null)
				{
					cs = A_0;
				}
				else
				{
					BeginInvoke(new jl.d(a), A_0);
				}
				return;
			}
			finally
			{
				Monitor.Exit(RuntimeHelpers.GetObjectValue(cq));
			}
		}
		b(A_0);
		jl.c c10 = null;
		try
		{
			Monitor.Enter(RuntimeHelpers.GetObjectValue(cq));
			if (cs != null)
			{
				c10 = cs;
				cs = null;
			}
		}
		finally
		{
			Monitor.Exit(RuntimeHelpers.GetObjectValue(cq));
		}
		if (c10 != null)
		{
			b(c10);
		}
	}

	public void a(int A_0, ReadOnlyCollection<float> A_1, ReadOnlyCollection<float> A_2, r.d.a.b A_3)
	{
		if (base.InvokeRequired)
		{
			Invoke(new jl.f(a), A_0, A_1, A_2, A_3);
			return;
		}
		checked
		{
			try
			{
				this.m_b2 = A_2;
				this.m_b3 = A_1;
				ag().Items.Clear();
				ag().Items.Add("All Layers");
				int num = A_0 - 1;
				for (int num2 = 1; num2 <= num; num2++)
				{
					ag().Items.Add("Layer " + num2);
				}
				ag().SelectedIndex = 0;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				if (A_3 == global::r.d.a.b.a)
				{
					i5.a(this.m_b8, this.m_b4, null, i6.a(this), "FIControlPanelVsTime.LayersChangedHandler", ex3);
				}
				else
				{
					this.m_b8.c(fz.b.b, "Error in FIControlPanelVsTime.LayersChangedHandler", ex3);
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public void a(ReadOnlyCollection<float> A_0, ReadOnlyCollection<float> A_1, long A_2, long A_3, float A_4, jm A_5, string A_6, hg A_7, bool A_8, r.d.a.b A_9)
	{
		if (base.InvokeRequired)
		{
			if (!ct || A_1 == null)
			{
				ct = true;
				BeginInvoke(new jl.h(a), A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9);
			}
			return;
		}
		ct = false;
		checked
		{
			try
			{
				if (A_1 == null)
				{
					cd();
					l().g2();
					return;
				}
				int count = A_0.Count;
				int num = count - 1;
				double[] array = new double[num + 1];
				double[] array2 = new double[num + 1];
				string text = i6.a(this.m_b4.p9(this.m_b5, A_2), "0.0");
				bl().Text = text;
				bq().Text = text;
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					array[num3] = A_0[num3];
					array2[num3] = A_1[num3];
				}
				l().o(array, array2, count, 0L, 0L, A_7.cl(), A_6, "VsTime", A_8: false, A_9: false);
				jk.a a10 = A_7.b9().a;
				string text2 = jk.r(a10);
				jm jm2 = A_5;
				float num4 = (l().ft().a - l().ft().b) * (float)(jm2.f() + 1) / (float)jm2.f();
				jm2 = null;
				if (A_8)
				{
					if (A_7.b9().h || A_7.b9().n)
					{
						bb().Font = new Font(bb().Font, FontStyle.Regular);
					}
					else
					{
						bb().Font = new Font(bb().Font, FontStyle.Bold);
					}
					bb().Text = A_5.g().ToString("#0.0000");
					if (A_7.b9().p)
					{
						ba().Font = new Font(ba().Font, FontStyle.Regular);
					}
					else
					{
						ba().Font = new Font(ba().Font, FontStyle.Bold);
					}
					ba().Text = A_5.h().ToString("#0.0000");
					if (A_7.b9().l)
					{
						bd().Font = new Font(bd().Font, FontStyle.Regular);
					}
					else
					{
						bd().Font = new Font(bd().Font, FontStyle.Bold);
					}
					bd().Text = jk.r(A_5.i(), a10);
					bc().Text = hg.bu(1, A_5.i() * num4, h4.e(a10), global::e.a().DisplaySignificantDigits);
					a9().Text = string.Empty;
				}
				else
				{
					bx().Text = text2;
					bv().Text = h4.e(h4.e(a10), false, false);
					if (A_5 != null)
					{
						jm jm3 = A_5;
						bu().Text = jk.r(jm3.i(), a10);
						bt().Text = hg.bu(1, jm3.i() * num4, h4.e(a10), global::e.a().DisplaySignificantDigits);
						jm3 = null;
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				if (A_9 == global::r.d.a.b.a)
				{
					i5.a(this.m_b8, this.m_b4, null, i6.a(this), "FIControlPanelVsTime.AnalysisChangedHandler", ex3);
				}
				else
				{
					this.m_b8.c(fz.b.b, "Error in FIControlPanelVsTime.AnalysisChangedHandler.", ex3);
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public void cf()
	{
		jf.a a10 = null;
		if (l().fr())
		{
			fl.z z2 = l().ft();
			a10 = new jf.a(z2.b, z2.a, z2.d, z2.c);
		}
		if (ah().SelectedTab == ai())
		{
			if (a10 != null)
			{
				this.m_b4.m2(this.m_b5, a10, l().e7(), b7(), global::r.d.a.b.a);
			}
		}
		else if (l().fq())
		{
			if (a10 == null)
			{
				fu fu2 = l().gi();
				a10 = new jf.a((float)fu2.a2().ap(), (float)fu2.a2().aq(), (float)fu2.a0(), (float)fu2.at(false));
				fu2 = null;
			}
			this.m_b4.m2(this.m_b5, a10, l().e7(), A_3: false, b7(), global::r.d.a.b.a);
		}
	}

	public void e(r.d.a A_0)
	{
		if (base.InvokeRequired)
		{
			Invoke(new r.d.b(e), A_0);
		}
		else if (base.IsHandleCreated)
		{
			this.m_cb.b();
		}
	}

	private void a()
	{
		if (base.InvokeRequired)
		{
			Invoke(new hs.a(a));
		}
		else
		{
			if (!base.IsHandleCreated)
			{
				return;
			}
			try
			{
				bool flag = this.m_b4.m2(this.m_b5, A_1: true);
				al().Enabled = flag && this.m_b4.sj(this.m_b5, A_1: true) && !this.m_cd.l;
				ak().Enabled = this.m_cd.l;
				au().Enabled = al().Enabled;
				at().Visible = ak().Enabled;
				au().Visible = !ak().Enabled;
				b();
				e();
				jk.a a10 = this.m_b4.wq(this.m_b5).b9().a;
				if (a10 != co)
				{
					bx().Text = jk.r(a10);
					bv().Text = h4.e(h4.e(a10), false, false);
					a0().Text = bx().Text;
					az().Text = bv().Text;
					co = a10;
				}
				bi().Enabled = !this.m_cd.l;
				bh().Enabled = !this.m_cd.l;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_b8.c(fz.b.b, "Exception caught in FIControlPanelVsTime.PanelGUIUpdateHandler. ", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void c(r.d.a A_0)
	{
		if (base.InvokeRequired)
		{
			Invoke(new r.d.b(c), A_0);
			return;
		}
		try
		{
			if (A_0.a == global::r.d.a.a.b)
			{
				fe.b(this.m_b8, A_0.b, i6.a(this));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (A_0.a8() == global::r.d.a.b.a)
			{
				i5.a(this.m_b8, this.m_b4, null, i6.a(this), "mOpenFileCompl_TaskFinishedEvent", ex3);
			}
			else
			{
				this.m_b8.c(fz.b.b, "Error in mOpenFileCompl_TaskFinishedEvent", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void b(r.d.a A_0)
	{
		if (base.InvokeRequired)
		{
			Invoke(new r.d.b(c), A_0);
			return;
		}
		try
		{
			if (A_0.a == global::r.d.a.a.b)
			{
				fe.b(this.m_b8, A_0.b, i6.a(this));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (A_0.a8() == global::r.d.a.b.a)
			{
				i5.a(this.m_b8, this.m_b4, null, i6.a(this), "mRecipeChangedTaskCompl_TaskFinishedEvent", ex3);
			}
			else
			{
				this.m_b8.c(fz.b.b, "Error in FIControlPanelVsTime.mRecipeChangedTaskCompl_TaskFinishedEvent", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.d.a A_0)
	{
		if (base.InvokeRequired)
		{
			Invoke(new r.d.b(a), A_0);
			return;
		}
		try
		{
			this.m_cb.b();
			if (A_0.a == global::r.d.a.a.b)
			{
				fe.b(this.m_b8, A_0.b, i6.a(this));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (A_0.a8() == global::r.d.a.b.a)
			{
				i5.a(this.m_b8, this.m_b4, null, i6.a(this), "mAcqDataTerminatorCompletion_TaskFinishedEvent", ex3);
			}
			else
			{
				this.m_b8.c(fz.b.b, "Error in FIControlPanelVsTime.mAcqDataTerminatorCompletion_TaskFinishedEvent", ex3);
			}
			ProjectData.ClearProjectError();
		}
	}

	public void g(r.d A_0)
	{
		if (A_0 != null)
		{
			A_0.d((r.d.b)f);
		}
		else
		{
			this.m_b8.c(fz.b.b, "Error in FIControlPanelVsTime.AddSpectrumAcquiredHandler(): spectrumAcquiredCompletionTask is Nothing. ");
		}
	}

	private void a(IAsyncResult A_0)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		EndInvoke(A_0);
		stopwatch.Stop();
		if (stopwatch.ElapsedMilliseconds > 0)
		{
			Thread.Sleep(80);
		}
	}

	public void f(r.d.a A_0)
	{
		if (cv == null)
		{
			Interlocked.CompareExchange(ref cv, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(cv, ref lockTaken);
			if (cv.State == 0)
			{
				cv.State = 2;
				cu = null;
			}
			else if (cv.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			cv.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(cv);
			}
		}
		checked
		{
			try
			{
				if (this.m_b4.tc())
				{
					return;
				}
				r.h.a a10 = (r.h.a)A_0;
				if (((r.d.a)a10).a == global::r.d.a.a.a && !a10.x)
				{
					return;
				}
				if (base.InvokeRequired)
				{
					if (cu != null)
					{
						if (!Monitor.TryEnter(RuntimeHelpers.GetObjectValue(this.m_b6), 1000))
						{
							return;
						}
						try
						{
							this.m_b7++;
							a(cu);
							l().er.WaitOne(1000, exitContext: false);
						}
						finally
						{
							this.m_b7--;
							Monitor.Exit(RuntimeHelpers.GetObjectValue(this.m_b6));
						}
					}
					r.d.b method = f;
					cu = BeginInvoke(method, A_0);
				}
				else if (!base.IsHandleCreated)
				{
					this.m_b8.c(fz.b.b, "Attempt to SpectrometerSpectrumAcquiredEventHandler before handle created-Aborted", Environment.StackTrace);
				}
				else if (a10.x)
				{
					r().g1();
					d7.a(this.m_b4, r(), a10.w, fh.b.a, hr.b.c);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_b8.c(fz.b.b, "Exception Thrown", a_);
				ProjectData.ClearProjectError();
			}
		}
	}
}
