using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FIUsbIntLib;
using Filmetrics.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class e6 : Form
{
	private class a
	{
		public bool a;

		public bool b;

		public bool c;

		public bool d;

		public a(bool A_0, bool A_1, bool A_2, bool A_3)
		{
			a = A_0;
			b = A_1;
			c = A_2;
			d = A_3;
		}
	}

	public enum b
	{
		a,
		b,
		c,
		d,
		e
	}

	private enum c
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g,
		h
	}

	private enum d
	{
		a,
		b
	}

	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private ToolTip m_e;

	[CompilerGenerated]
	private Button m_f;

	[CompilerGenerated]
	private Button m_g;

	[CompilerGenerated]
	private Label m_h;

	[CompilerGenerated]
	private Label m_i;

	[CompilerGenerated]
	private Button m_j;

	[CompilerGenerated]
	private Label m_k;

	[CompilerGenerated]
	private Label m_l;

	[CompilerGenerated]
	private Label m_m;

	[CompilerGenerated]
	private Button m_n;

	[CompilerGenerated]
	private Button m_o;

	[CompilerGenerated]
	private Label m_p;

	[CompilerGenerated]
	private Button m_q;

	[CompilerGenerated]
	private PictureBox m_r;

	[CompilerGenerated]
	private PictureBox m_s;

	[CompilerGenerated]
	private PictureBox m_t;

	[CompilerGenerated]
	private Label m_u;

	[CompilerGenerated]
	private Label m_v;

	[CompilerGenerated]
	private Label m_w;

	[CompilerGenerated]
	private ProgressBar m_x;

	[CompilerGenerated]
	private Timer m_y;

	[CompilerGenerated]
	private LinkLabel m_z;

	[CompilerGenerated]
	private TabPage m_aa;

	[CompilerGenerated]
	private TableLayoutPanel m_ab;

	[CompilerGenerated]
	private TableLayoutPanel m_ac;

	[CompilerGenerated]
	private Label m_ad;

	[CompilerGenerated]
	private TabPage m_ae;

	[CompilerGenerated]
	private TableLayoutPanel m_af;

	[CompilerGenerated]
	private TableLayoutPanel m_ag;

	[CompilerGenerated]
	private ProgressBar m_ah;

	[CompilerGenerated]
	private Label m_ai;

	[CompilerGenerated]
	private Label m_aj;

	[CompilerGenerated]
	private TabPage m_ak;

	[CompilerGenerated]
	private TableLayoutPanel m_al;

	[CompilerGenerated]
	private TableLayoutPanel m_am;

	[CompilerGenerated]
	private Label m_an;

	[CompilerGenerated]
	private ProgressBar m_ao;

	[CompilerGenerated]
	private Label m_ap;

	[CompilerGenerated]
	private TableLayoutPanel m_aq;

	[CompilerGenerated]
	private TableLayoutPanel m_ar;

	[CompilerGenerated]
	private GroupBox m_as;

	[CompilerGenerated]
	private GroupBox m_at;

	[CompilerGenerated]
	private GroupBox m_au;

	[CompilerGenerated]
	private TableLayoutPanel m_av;

	[CompilerGenerated]
	private TableLayoutPanel m_aw;

	[CompilerGenerated]
	private Panel m_ax;

	[CompilerGenerated]
	private TableLayoutPanel m_ay;

	[CompilerGenerated]
	private TableLayoutPanel m_az;

	[CompilerGenerated]
	private TableLayoutPanel m_a0;

	[CompilerGenerated]
	private TableLayoutPanel m_a1;

	[CompilerGenerated]
	private TableLayoutPanel m_a2;

	[CompilerGenerated]
	private TableLayoutPanel m_a3;

	[CompilerGenerated]
	private TabControl m_a4;

	[CompilerGenerated]
	private Button m_a5;

	[CompilerGenerated]
	private TabPage m_a6;

	[CompilerGenerated]
	private Label m_a7;

	private gr m_a8;

	private f1 m_a9;

	private f4 m_ba;

	private Guid m_bb;

	private bool m_bc;

	private fz m_bd;

	private c m_be;

	private b m_bf;

	private bool m_bg;

	private bool[] m_bh;

	private bool m_bi;

	private bool m_bj;

	private fg.a bk;

	private float[] bl;

	private bool m_bm;

	private bool m_bn;

	private bool m_bo;

	private float m_bp;

	private g2.a m_bq;

	private h m_br;

	private hg m_bs;

	private string m_bt;

	private bool m_bu;

	private string m_bv;

	private bool m_bw;

	private int m_bx;

	private int m_by;

	private int m_bz;

	private int m_b0;

	private int m_b1;

	private int m_b2;

	private bool m_b3;

	private bool m_b4;

	private Collection<string> b5;

	private Collection<string> b6;

	private string b7;

	private g2.c b8;

	private gr.f b9;

	private FMLegacyAllSystemTypes ca;

	private FMF10Subtypes cb;

	private bool cc;

	private bool cd;

	private const string ce = "\\MostRecentReflRefMaterials.fmslf";

	private const string cf = "\\MostRecentTransRefMaterials.fmslf";

	[CompilerGenerated]
	private ContextMenuStrip cg;

	[CompilerGenerated]
	private r.d ch;

	[CompilerGenerated]
	private r.d ci;

	[CompilerGenerated]
	private r.d cj;

	[CompilerGenerated]
	private r.d ck;

	[CompilerGenerated]
	private r.d cl;

	[CompilerGenerated]
	private r.d cm;

	[CompilerGenerated]
	private r.d cn;

	[CompilerGenerated]
	private r.d co;

	[CompilerGenerated]
	private r.d cp;

	[CompilerGenerated]
	private r.d cq;

	[CompilerGenerated]
	private r.d cr;

	private Point cs;

	private Point ct;

	private Point cu;

	[CompilerGenerated]
	private r.c cv;

	private int cw;

	private int cx;

	private float cy;

	private DateTime cz;

	private bool c0;

	private bool c1;

	private bool c2;

	private double c3;

	private a c4;

	private bool c5;

	private bool c6;

	private bool c7;

	private bool c8;

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
	private void q()
	{
		this.m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(e6));
		a(new Button());
		b(new Button());
		c(new Button());
		a(new ToolTip(this.m_a));
		i(new Button());
		g(new TableLayoutPanel());
		h(new TableLayoutPanel());
		j(new Button());
		a(new TabControl());
		b(new TabPage());
		b(new GroupBox());
		p(new TableLayoutPanel());
		l(new TableLayoutPanel());
		e(new Button());
		d(new Button());
		a(new TableLayoutPanel());
		b(new TableLayoutPanel());
		j(new Label());
		a(new ProgressBar());
		b(new Label());
		g(new Label());
		a(new PictureBox());
		a(new Label());
		c(new TabPage());
		a(new GroupBox());
		n(new TableLayoutPanel());
		o(new TableLayoutPanel());
		k(new TableLayoutPanel());
		i(new Label());
		g(new Button());
		j(new TableLayoutPanel());
		d(new Label());
		a(new Panel());
		f(new Button());
		c(new Label());
		a(new LinkLabel());
		c(new TableLayoutPanel());
		d(new TableLayoutPanel());
		b(new ProgressBar());
		k(new Label());
		l(new Label());
		h(new Label());
		e(new Label());
		b(new PictureBox());
		d(new TabPage());
		c(new GroupBox());
		m(new TableLayoutPanel());
		i(new TableLayoutPanel());
		h(new Button());
		e(new TableLayoutPanel());
		f(new TableLayoutPanel());
		m(new Label());
		c(new ProgressBar());
		n(new Label());
		f(new Label());
		c(new PictureBox());
		e(new TabPage());
		o(new Label());
		a(new Timer(this.m_a));
		a6().SuspendLayout();
		a7().SuspendLayout();
		bm().SuspendLayout();
		aq().SuspendLayout();
		a9().SuspendLayout();
		bj().SuspendLayout();
		bf().SuspendLayout();
		ar().SuspendLayout();
		@as().SuspendLayout();
		((ISupportInitialize)ah()).BeginInit();
		au().SuspendLayout();
		a8().SuspendLayout();
		bh().SuspendLayout();
		bi().SuspendLayout();
		be().SuspendLayout();
		bc().SuspendLayout();
		bd().SuspendLayout();
		av().SuspendLayout();
		aw().SuspendLayout();
		((ISupportInitialize)ai()).BeginInit();
		a0().SuspendLayout();
		ba().SuspendLayout();
		bg().SuspendLayout();
		bb().SuspendLayout();
		a1().SuspendLayout();
		a2().SuspendLayout();
		((ISupportInitialize)aj()).BeginInit();
		bo().SuspendLayout();
		SuspendLayout();
		componentResourceManager.ApplyResources(r(), "ButtonNext");
		r().Name = "ButtonNext";
		r().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(s(), "ButtonCancel");
		s().Cursor = Cursors.Default;
		s().DialogResult = DialogResult.Cancel;
		s().Name = "ButtonCancel";
		s().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(t(), "ButtonPrev");
		t().Name = "ButtonPrev";
		t().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ag(), "ButtonRecoverBaseline");
		ag().Name = "ButtonRecoverBaseline";
		ag().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(a6(), "TableLayoutPanelBaseline");
		a6().Controls.Add(a7(), 1, 1);
		a6().Controls.Add(s(), 2, 1);
		a6().Controls.Add(ag(), 0, 1);
		a6().Controls.Add(bm(), 0, 0);
		a6().Name = "TableLayoutPanelBaseline";
		componentResourceManager.ApplyResources(a7(), "TableLayoutPanel2");
		a7().Controls.Add(bn(), 2, 0);
		a7().Controls.Add(t(), 0, 0);
		a7().Controls.Add(r(), 1, 0);
		a7().Name = "TableLayoutPanel2";
		componentResourceManager.ApplyResources(bn(), "ButtonCancelCentered");
		bn().Cursor = Cursors.Default;
		bn().DialogResult = DialogResult.Cancel;
		bn().Name = "ButtonCancelCentered";
		bn().UseVisualStyleBackColor = true;
		a6().SetColumnSpan(bm(), 3);
		bm().Controls.Add(aq());
		bm().Controls.Add(au());
		bm().Controls.Add(a0());
		bm().Controls.Add(bo());
		componentResourceManager.ApplyResources(bm(), "TabControlBaseline");
		bm().Name = "TabControlBaseline";
		bm().SelectedIndex = 0;
		bm().SizeMode = TabSizeMode.Fixed;
		aq().Controls.Add(a9());
		aq().Controls.Add(ar());
		aq().Controls.Add(ak());
		aq().Controls.Add(ah());
		aq().Controls.Add(x());
		componentResourceManager.ApplyResources(aq(), "TabPageSampleReflectance");
		aq().Name = "TabPageSampleReflectance";
		aq().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(a9(), "GroupBoxSampleRefl");
		a9().Controls.Add(bj());
		a9().Name = "GroupBoxSampleRefl";
		a9().TabStop = false;
		componentResourceManager.ApplyResources(bj(), "TableLayoutPanel9");
		bj().Controls.Add(bf(), 0, 0);
		bj().Name = "TableLayoutPanel9";
		componentResourceManager.ApplyResources(bf(), "TableLayoutPanel5");
		bf().Controls.Add(w(), 0, 0);
		bf().Controls.Add(v(), 1, 0);
		bf().Name = "TableLayoutPanel5";
		componentResourceManager.ApplyResources(w(), "ButtonAcquireRefl");
		w().Name = "ButtonAcquireRefl";
		w().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(v(), "ButtonOverride");
		v().Name = "ButtonOverride";
		v().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ar(), "TableLayoutPanelSampleOuter");
		ar().Controls.Add(@as(), 0, 0);
		ar().Name = "TableLayoutPanelSampleOuter";
		componentResourceManager.ApplyResources(@as(), "TableLayoutPanelSampleInner");
		@as().Controls.Add(at(), 0, 0);
		@as().Controls.Add(an(), 2, 0);
		@as().Controls.Add(y(), 1, 0);
		@as().Name = "TableLayoutPanelSampleInner";
		componentResourceManager.ApplyResources(at(), "Label2");
		at().Name = "Label2";
		componentResourceManager.ApplyResources(an(), "ProgressBarSampleRefl");
		an().Name = "ProgressBarSampleRefl";
		componentResourceManager.ApplyResources(y(), "LabelReflStatus");
		y().BorderStyle = BorderStyle.Fixed3D;
		y().Name = "LabelReflStatus";
		componentResourceManager.ApplyResources(ak(), "LabelSample");
		ak().BackColor = SystemColors.Window;
		ak().Name = "LabelSample";
		ah().Image = Resources.MSBack;
		componentResourceManager.ApplyResources(ah(), "PictureBoxBaselineSample");
		ah().Name = "PictureBoxBaselineSample";
		ah().TabStop = false;
		componentResourceManager.ApplyResources(x(), "LabelReflMessage");
		x().Name = "LabelReflMessage";
		au().Controls.Add(a8());
		au().Controls.Add(ap());
		au().Controls.Add(av());
		au().Controls.Add(al());
		au().Controls.Add(ac());
		au().Controls.Add(ai());
		componentResourceManager.ApplyResources(au(), "TabPageReference");
		au().Name = "TabPageReference";
		au().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(a8(), "GroupBoxReference");
		a8().Controls.Add(bh());
		a8().Name = "GroupBoxReference";
		a8().TabStop = false;
		componentResourceManager.ApplyResources(bh(), "TableLayoutPanel8");
		bh().Controls.Add(bi(), 0, 0);
		bh().Name = "TableLayoutPanel8";
		componentResourceManager.ApplyResources(bi(), "TableLayoutPanel7");
		bi().Controls.Add(be(), 0, 1);
		bi().Controls.Add(bc(), 0, 0);
		bi().Name = "TableLayoutPanel7";
		componentResourceManager.ApplyResources(be(), "TableLayoutPanel4");
		be().Controls.Add(am(), 1, 0);
		be().Controls.Add(ad(), 0, 0);
		be().Name = "TableLayoutPanel4";
		componentResourceManager.ApplyResources(am(), "LabelCurrentRefMat");
		am().Name = "LabelCurrentRefMat";
		componentResourceManager.ApplyResources(ad(), "ButtonRefAcquire");
		ad().Name = "ButtonRefAcquire";
		ad().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bc(), "TableLayoutPanel3");
		bc().Controls.Add(ab(), 0, 0);
		bc().Controls.Add(bd(), 1, 0);
		bc().Name = "TableLayoutPanel3";
		componentResourceManager.ApplyResources(ab(), "LabelReferenceMat");
		ab().Name = "LabelReferenceMat";
		componentResourceManager.ApplyResources(bd(), "Panel1");
		bd().Controls.Add(z());
		bd().Controls.Add(aa());
		bd().Name = "Panel1";
		z().BackColor = SystemColors.Window;
		componentResourceManager.ApplyResources(z(), "ButtonRefMatSelect");
		z().Name = "ButtonRefMatSelect";
		z().UseVisualStyleBackColor = false;
		aa().BackColor = SystemColors.Window;
		aa().BorderStyle = BorderStyle.FixedSingle;
		componentResourceManager.ApplyResources(aa(), "LabelRefMatSelected");
		aa().Name = "LabelRefMatSelected";
		componentResourceManager.ApplyResources(ap(), "LinkWarmupDetails");
		ap().Name = "LinkWarmupDetails";
		ap().TabStop = true;
		componentResourceManager.ApplyResources(av(), "TableLayoutPanelReferenceOuter");
		av().Controls.Add(aw(), 0, 0);
		av().Name = "TableLayoutPanelReferenceOuter";
		componentResourceManager.ApplyResources(aw(), "TableLayoutPanelReferenceInner");
		aw().Controls.Add(ax(), 2, 0);
		aw().Controls.Add(ay(), 1, 0);
		aw().Controls.Add(az(), 0, 0);
		aw().Name = "TableLayoutPanelReferenceInner";
		componentResourceManager.ApplyResources(ax(), "ProgressBarReference");
		ax().Name = "ProgressBarReference";
		componentResourceManager.ApplyResources(ay(), "LabelRefStatus");
		ay().BorderStyle = BorderStyle.Fixed3D;
		ay().Name = "LabelRefStatus";
		componentResourceManager.ApplyResources(az(), "Label5");
		az().Name = "Label5";
		componentResourceManager.ApplyResources(al(), "LabelReference");
		al().BackColor = SystemColors.Window;
		al().Name = "LabelReference";
		componentResourceManager.ApplyResources(ac(), "LabelRefMessage");
		ac().Name = "LabelRefMessage";
		ai().Image = Resources.ContactStageRef_Si;
		componentResourceManager.ApplyResources(ai(), "PictureBoxReference");
		ai().Name = "PictureBoxReference";
		ai().TabStop = false;
		a0().Controls.Add(ba());
		a0().Controls.Add(a1());
		a0().Controls.Add(af());
		a0().Controls.Add(aj());
		componentResourceManager.ApplyResources(a0(), "TabPageBackground");
		a0().Name = "TabPageBackground";
		a0().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ba(), "GroupBoxBackground");
		ba().Controls.Add(bg());
		ba().Name = "GroupBoxBackground";
		ba().TabStop = false;
		componentResourceManager.ApplyResources(bg(), "TableLayoutPanel6");
		bg().Controls.Add(bb(), 0, 0);
		bg().Name = "TableLayoutPanel6";
		componentResourceManager.ApplyResources(bb(), "TableLayoutPanel1");
		bb().Controls.Add(ae(), 0, 0);
		bb().Name = "TableLayoutPanel1";
		componentResourceManager.ApplyResources(ae(), "ButtonAcquireDark");
		ae().Name = "ButtonAcquireDark";
		ae().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(a1(), "TableLayoutPanelBackgroundOuter");
		a1().Controls.Add(a2(), 0, 0);
		a1().Name = "TableLayoutPanelBackgroundOuter";
		componentResourceManager.ApplyResources(a2(), "TableLayoutPanelBackgroundInner");
		a2().Controls.Add(a3(), 1, 0);
		a2().Controls.Add(a4(), 2, 0);
		a2().Controls.Add(a5(), 0, 0);
		a2().Name = "TableLayoutPanelBackgroundInner";
		componentResourceManager.ApplyResources(a3(), "LabelDarkStatus");
		a3().BorderStyle = BorderStyle.Fixed3D;
		a3().Name = "LabelDarkStatus";
		componentResourceManager.ApplyResources(a4(), "ProgressBarBackground");
		a4().Name = "ProgressBarBackground";
		componentResourceManager.ApplyResources(a5(), "Label7");
		a5().Name = "Label7";
		componentResourceManager.ApplyResources(af(), "LabelBackMessage");
		af().Name = "LabelBackMessage";
		aj().Image = Resources.ContactStageRef_Si;
		componentResourceManager.ApplyResources(aj(), "PictureBoxBackGround");
		aj().Name = "PictureBoxBackGround";
		aj().TabStop = false;
		bo().Controls.Add(bp());
		componentResourceManager.ApplyResources(bo(), "TabPageFinish");
		bo().Name = "TabPageFinish";
		bo().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(bp(), "LabelBaselineComplete");
		bp().Name = "LabelBaselineComplete";
		ao().Enabled = true;
		ao().Interval = 40;
		componentResourceManager.ApplyResources(this, "$this");
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = s();
		base.ControlBox = false;
		base.Controls.Add(a6());
		DoubleBuffered = true;
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Name = "DialogBaselineSetup";
		base.ShowInTaskbar = false;
		a6().ResumeLayout(performLayout: false);
		a6().PerformLayout();
		a7().ResumeLayout(performLayout: false);
		bm().ResumeLayout(performLayout: false);
		aq().ResumeLayout(performLayout: false);
		aq().PerformLayout();
		a9().ResumeLayout(performLayout: false);
		bj().ResumeLayout(performLayout: false);
		bj().PerformLayout();
		bf().ResumeLayout(performLayout: false);
		bf().PerformLayout();
		ar().ResumeLayout(performLayout: false);
		ar().PerformLayout();
		@as().ResumeLayout(performLayout: false);
		@as().PerformLayout();
		((ISupportInitialize)ah()).EndInit();
		au().ResumeLayout(performLayout: false);
		au().PerformLayout();
		a8().ResumeLayout(performLayout: false);
		bh().ResumeLayout(performLayout: false);
		bh().PerformLayout();
		bi().ResumeLayout(performLayout: false);
		bi().PerformLayout();
		be().ResumeLayout(performLayout: false);
		be().PerformLayout();
		bc().ResumeLayout(performLayout: false);
		bc().PerformLayout();
		bd().ResumeLayout(performLayout: false);
		av().ResumeLayout(performLayout: false);
		av().PerformLayout();
		aw().ResumeLayout(performLayout: false);
		aw().PerformLayout();
		((ISupportInitialize)ai()).EndInit();
		a0().ResumeLayout(performLayout: false);
		ba().ResumeLayout(performLayout: false);
		bg().ResumeLayout(performLayout: false);
		bg().PerformLayout();
		bb().ResumeLayout(performLayout: false);
		bb().PerformLayout();
		a1().ResumeLayout(performLayout: false);
		a1().PerformLayout();
		a2().ResumeLayout(performLayout: false);
		a2().PerformLayout();
		((ISupportInitialize)aj()).EndInit();
		bo().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button r()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = m;
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
	internal virtual Button s()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = k;
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
	internal virtual Button t()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = l;
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
	internal virtual ToolTip u()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolTip A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button v()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Button A_0)
	{
		EventHandler value = b;
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
	internal virtual Button w()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Button A_0)
	{
		EventHandler value = d;
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
	internal virtual Label x()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label y()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button z()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Button A_0)
	{
		EventHandler value = h;
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
	internal virtual Label aa()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ab()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ac()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ad()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Button A_0)
	{
		EventHandler value = g;
		Button button = this.m_n;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_n = A_0;
		button = this.m_n;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ae()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Button A_0)
	{
		EventHandler value = f;
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
	internal virtual Label af()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ag()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Button A_0)
	{
		EventHandler value = e;
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
	internal virtual PictureBox ah()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(PictureBox A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox ai()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(PictureBox A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox aj()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(PictureBox A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ak()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Label A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label al()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Label A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label am()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Label A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ProgressBar an()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ProgressBar A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer ao()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Timer A_0)
	{
		EventHandler value = a;
		Timer timer = this.m_y;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		this.m_y = A_0;
		timer = this.m_y;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual LinkLabel ap()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(LinkLabel A_0)
	{
		LinkLabelLinkClickedEventHandler value = a;
		LinkLabel linkLabel = this.m_z;
		if (linkLabel != null)
		{
			linkLabel.LinkClicked -= value;
		}
		this.m_z = A_0;
		linkLabel = this.m_z;
		if (linkLabel != null)
		{
			linkLabel.LinkClicked += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage aq()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TabPage A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ar()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_ab = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel @as()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_ac = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label at()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Label A_0)
	{
		this.m_ad = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage au()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TabPage A_0)
	{
		this.m_ae = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel av()
	{
		return this.m_af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
	{
		this.m_af = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel aw()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TableLayoutPanel A_0)
	{
		this.m_ag = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ProgressBar ax()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ProgressBar A_0)
	{
		this.m_ah = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ay()
	{
		return this.m_ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Label A_0)
	{
		this.m_ai = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label az()
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
	internal virtual TabPage a0()
	{
		return this.m_ak;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TabPage A_0)
	{
		this.m_ak = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel a1()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TableLayoutPanel A_0)
	{
		this.m_al = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel a2()
	{
		return this.m_am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(TableLayoutPanel A_0)
	{
		this.m_am = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a3()
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
	internal virtual ProgressBar a4()
	{
		return this.m_ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ProgressBar A_0)
	{
		this.m_ao = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a5()
	{
		return this.m_ap;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(Label A_0)
	{
		this.m_ap = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel a6()
	{
		return this.m_aq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(TableLayoutPanel A_0)
	{
		this.m_aq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel a7()
	{
		return this.m_ar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(TableLayoutPanel A_0)
	{
		this.m_ar = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox a8()
	{
		return this.m_as;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(GroupBox A_0)
	{
		this.m_as = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox a9()
	{
		return this.m_at;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(GroupBox A_0)
	{
		this.m_at = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ba()
	{
		return this.m_au;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(GroupBox A_0)
	{
		this.m_au = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel bb()
	{
		return this.m_av;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TableLayoutPanel A_0)
	{
		this.m_av = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel bc()
	{
		return this.m_aw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(TableLayoutPanel A_0)
	{
		this.m_aw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel bd()
	{
		return this.m_ax;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Panel A_0)
	{
		this.m_ax = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel be()
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
	internal virtual TableLayoutPanel bf()
	{
		return this.m_az;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(TableLayoutPanel A_0)
	{
		this.m_az = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel bg()
	{
		return this.m_a0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(TableLayoutPanel A_0)
	{
		this.m_a0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel bh()
	{
		return this.m_a1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(TableLayoutPanel A_0)
	{
		this.m_a1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel bi()
	{
		return this.m_a2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(TableLayoutPanel A_0)
	{
		this.m_a2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel bj()
	{
		return this.m_a3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void p(TableLayoutPanel A_0)
	{
		this.m_a3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabControl bm()
	{
		return this.m_a4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TabControl A_0)
	{
		this.m_a4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button bn()
	{
		return this.m_a5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Button A_0)
	{
		EventHandler value = k;
		Button button = this.m_a5;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_a5 = A_0;
		button = this.m_a5;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage bo()
	{
		return this.m_a6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TabPage A_0)
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
	internal virtual void o(Label A_0)
	{
		this.m_a7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual ContextMenuStrip bq()
	{
		return cg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(ContextMenuStrip A_0)
	{
		ToolStripItemClickedEventHandler value = a;
		EventHandler value2 = c;
		ContextMenuStrip contextMenuStrip = cg;
		if (contextMenuStrip != null)
		{
			contextMenuStrip.ItemClicked -= value;
			contextMenuStrip.LostFocus -= value2;
		}
		cg = A_0;
		contextMenuStrip = cg;
		if (contextMenuStrip != null)
		{
			contextMenuStrip.ItemClicked += value;
			contextMenuStrip.LostFocus += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d br()
	{
		return ch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		r.d.b a_ = j;
		ch?.e(a_);
		ch = A_0;
		ch?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d bs()
	{
		return ci;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void b(r.d A_0)
	{
		r.d.b a_ = i;
		ci?.e(a_);
		ci = A_0;
		ci?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d bt()
	{
		return cj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void c(r.d A_0)
	{
		r.d.b a_ = e;
		cj?.e(a_);
		cj = A_0;
		cj?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d bu()
	{
		return ck;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void d(r.d A_0)
	{
		r.d.b a_ = l;
		ck?.e(a_);
		ck = A_0;
		ck?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d bv()
	{
		return cl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void e(r.d A_0)
	{
		r.d.b a_ = k;
		cl?.e(a_);
		cl = A_0;
		cl?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d bw()
	{
		return cm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void f(r.d A_0)
	{
		r.d.b a_ = d;
		cm?.e(a_);
		cm = A_0;
		cm?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d bx()
	{
		return cn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void g(r.d A_0)
	{
		r.d.b a_ = b;
		cn?.e(a_);
		cn = A_0;
		cn?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d by()
	{
		return co;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void h(r.d A_0)
	{
		r.d.b a_ = c;
		co?.e(a_);
		co = A_0;
		co?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d bz()
	{
		return cp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void i(r.d A_0)
	{
		r.d.b a_ = g;
		cp?.e(a_);
		cp = A_0;
		cp?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d b0()
	{
		return cq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void j(r.d A_0)
	{
		r.d.b a_ = f;
		cq?.e(a_);
		cq = A_0;
		cq?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d b1()
	{
		return cr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void k(r.d A_0)
	{
		r.d.b a_ = a;
		cr?.e(a_);
		cr = A_0;
		cr?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.c b2()
	{
		return cv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.c A_0)
	{
		r.c.b a_ = a;
		cv?.u(a_);
		cv = A_0;
		cv?.t(a_);
	}

	public e6(fz A_0)
	{
		base.FormClosing += a;
		bl = new float[checked(Enum.GetValues(typeof(h.h)).GetUpperBound(0) + 1)];
		this.m_bm = false;
		this.m_bn = false;
		this.m_b3 = false;
		this.m_b4 = false;
		k(new r.d());
		q();
		a(new ContextMenuStrip(this.m_a));
		a(new r.d());
		b(new r.d());
		c(new r.d());
		d(new r.d());
		e(new r.d());
		f(new r.d());
		g(new r.d());
		h(new r.d());
		i(new r.d());
		j(new r.d());
		this.m_bd = A_0;
		b5 = new Collection<string>();
		cs = new Point(al().Location.X, al().Location.Y);
		ct = new Point(ak().Location.X, ak().Location.Y);
		cu = new Point(ac().Location.X, ac().Location.Y);
		a(new r.c());
	}

	private void p()
	{
		au().Enabled = true;
		f(A_0: true);
		ax().Visible = false;
		ay().Visible = true;
		ao().Stop();
		Cursor = Cursors.Default;
	}

	private void d(bool A_0)
	{
		a4().Visible = false;
		a3().Visible = true;
		ao().Stop();
		t().Enabled = A_0;
		a0().Enabled = true;
		f(A_0: true);
		Cursor = Cursors.Default;
	}

	private void a(r.c A_0, bool A_1)
	{
		lock (ao())
		{
			cw = b2().v();
			cx = b2().w();
			cz = b2().x();
			cy = b2().y();
		}
	}

	private void l(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				r.d.b method = l;
				BeginInvoke(method, A_0);
				return;
			}
			try
			{
				if (A_0.a == global::r.d.a.a.a)
				{
					Label label = ay();
					string A_1 = "BaselineStatusComplete";
					label.Text = hu.a(ref A_1);
					r().Enabled = true;
					this.m_b3 = true;
					this.m_b4 = false;
					m(this, new EventArgs());
				}
				else
				{
					r.g.a a10 = (r.g.a)A_0;
					fe.b(this.m_bd, a10.a6(), i6.a(this), base.TopMost);
					this.m_a9.so(this.m_bb, 0);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(ad()), "DialogBaselineSetup.MeasBaselineTakeAutoRefBK7SpecFinishedHandler Loc#1", a_);
				ProjectData.ClearProjectError();
			}
			finally
			{
				p();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception a_2 = ex3;
			p();
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(ad()), "DialogBaselineSetup.MeasBaselineTakeAutoRefBK7SpecFinishedHandler Loc#2", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void k(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				r.d.b method = k;
				BeginInvoke(method, A_0);
				return;
			}
			try
			{
				bool flag = false;
				float[] A_1 = null;
				float[] A_2 = null;
				float[] A_3 = null;
				float[] A_4 = null;
				int[] A_5 = null;
				int[] A_6 = null;
				string empty = string.Empty;
				a4().Visible = false;
				a3().Visible = true;
				ao().Stop();
				int num = (this.m_bg ? checked(this.m_a9.uj(this.m_bb) - 1) : 0);
				this.m_a9.m2(this.m_bb, 0, 0, 50, ref A_1, ref A_2, ref A_5, ref A_6);
				this.m_a9.m2(this.m_bb, 0, 50, A_5, A_6, ref A_3, ref A_4);
				int[] array = this.m_a9.un(this.m_bb);
				float num2 = ((!g2.k(this.m_bq)) ? 1.15f : 1.4f);
				bool[] array2 = this.m_a9.uo(this.m_bb);
				h.f[] array3 = this.m_a9.vb(this.m_bb);
				int num3 = num;
				bool flag2 = default(bool);
				bool flag3 = default(bool);
				for (int num4 = 0; num4 <= num3; num4 = checked(num4 + 1))
				{
					float[] array4;
					float[] array5;
					if (array[num4] > 1)
					{
						if (this.m_br.a((int)array3[num4]).b(array2[num4]) == global::f.a.b)
						{
							array4 = A_1;
							array5 = A_3;
						}
						else
						{
							array4 = A_2;
							array5 = A_4;
						}
					}
					else
					{
						array4 = A_1;
						array5 = A_3;
					}
					flag2 = array4[num4] <= 0f || array5[num4] <= 0f || array4[num4] / array5[num4] < num2;
					if (flag2)
					{
						if (!this.m_bg)
						{
							break;
						}
						Collection<gu.a> A_7 = null;
						Guid guid = this.m_a9.ua(this.m_bb).o[num4];
						this.m_a9.m2(ref A_7);
						foreach (gu.a item in A_7)
						{
							if (item.a == guid)
							{
								empty = item.c;
								break;
							}
						}
						break;
					}
					flag3 = array4[num4] / array5[num4] > 4f;
					if (flag3)
					{
						break;
					}
				}
				if (flag2)
				{
					fz a_ = this.m_bd;
					string A_8 = "BaselineRefBacTooSimilarFmt";
					fe.b(a_, string.Format(hu.a(ref A_8), empty), i6.a(this), base.TopMost);
				}
				else if (flag3)
				{
					fz a_2 = this.m_bd;
					string A_8 = "AutoBaselineRefBacRatioTooLargeFmt1";
					fe.b(a_2, string.Format(hu.a(ref A_8), 4f.ToString()), i6.a(this), base.TopMost);
				}
				else
				{
					flag = true;
				}
				if (A_0.a == global::r.d.a.a.a)
				{
					if (flag)
					{
						Label label = a3();
						string A_8 = "BaselineStatusComplete";
						label.Text = hu.a(ref A_8);
						r().Enabled = true;
						this.m_b4 = true;
						bool A_9 = default(bool);
						a(A_0: true, A_1: false, ref A_9);
						if (this.m_bz <= 2 && !A_9)
						{
							m(this, new EventArgs());
							return;
						}
						if (A_9)
						{
							r().Visible = true;
							t().Visible = true;
						}
						base.ActiveControl = r();
					}
					else
					{
						Label label2 = a3();
						string A_8 = "BaselineStatusIncomplete";
						label2.Text = hu.a(ref A_8);
						this.m_b4 = false;
						base.ActiveControl = ae();
					}
				}
				else if (flag)
				{
					r.g.a a10 = (r.g.a)A_0;
					if (a10.j == global::r.g.a.a.a)
					{
						string A_8 = "BaselineStatusFailed";
						Interaction.MsgBox(hu.a(ref A_8), MsgBoxStyle.OkOnly, Application.CompanyName);
					}
					else
					{
						fe.b(this.m_bd, a10.a6(), i6.a(this), base.TopMost);
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(ae()), "DialogBaselineSetup.MeasBaselineTakeAutoRefFiberTipSpecFinishedHandler Loc#1", a_3);
				ProjectData.ClearProjectError();
			}
			finally
			{
				d(A_0: true);
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception a_4 = ex3;
			d(A_0: true);
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(ae()), "DialogBaselineSetup.MeasBaselineTakeAutoRefFiberTipSpecFinishedHandler Loc#2", a_4);
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	public bool b3()
	{
		return this.m_bo;
	}

	[SpecialName]
	public void e(bool A_0)
	{
		this.m_bo = A_0;
	}

	[SpecialName]
	public bool b4()
	{
		if (s().Enabled)
		{
			return bn().Enabled;
		}
		return false;
	}

	[SpecialName]
	public void f(bool A_0)
	{
		s().Enabled = A_0;
		bn().Enabled = A_0;
	}

	private bool o()
	{
		if (ca != FMLegacyAllSystemTypes.kTypeF3)
		{
			if (ca == FMLegacyAllSystemTypes.kTypeF10)
			{
				return cb == FMF10Subtypes.kFMF10SubtypeARc;
			}
			return false;
		}
		return true;
	}

	private bool c(string A_0)
	{
		foreach (string item in b6)
		{
			if (string.Compare(item, A_0, ignoreCase: true) == 0)
			{
				return true;
			}
		}
		return false;
	}

	public void a(b A_0, gr A_1, f1 A_2, f4 A_3, Guid A_4, bool A_5)
	{
		this.m_bg = false;
		this.m_ba = A_3;
		a(A_0, A_1, A_2, A_3: true, A_4, A_5, A_6: false);
	}

	public void a(b A_0, gr A_1, f1 A_2, Guid A_3)
	{
		this.m_bg = true;
		a(A_0, A_1, A_2, A_3: true, A_3, A_5: false, A_6: false);
	}

	public void b(b A_0, gr A_1, f1 A_2, f4 A_3, Guid A_4, bool A_5)
	{
		this.m_ba = A_3;
		a(A_0, A_1, A_2, A_3: false, A_4, A_5, A_6: true);
	}

	public void c(b A_0, gr A_1, f1 A_2, f4 A_3, Guid A_4, bool A_5)
	{
		this.m_ba = A_3;
		a(A_0, A_1, A_2, A_3: false, A_4, A_5, A_6: false);
	}

	private void a(b A_0, gr A_1, f1 A_2, f4 A_3, Guid A_4, bool A_5, bool A_6)
	{
		this.m_bg = false;
		this.m_ba = A_3;
		a(A_0, A_1, A_2, A_3: false, A_4, A_5, A_6);
	}

	public void b(b A_0, gr A_1, f1 A_2, Guid A_3)
	{
		this.m_bg = true;
		a(A_0, A_1, A_2, A_3: false, A_3, A_5: false, A_6: false);
	}

	private void a(b A_0, gr A_1, f1 A_2, bool A_3, Guid A_4, bool A_5, bool A_6)
	{
		this.m_bb = A_4;
		this.m_a9 = A_2;
		this.m_a9.m2(this.m_bb, ref this.m_bt, ref this.m_bu, ref this.m_bv);
		this.m_bc = A_5;
		c0 = eo.at(this.m_a9.sm(this.m_bb), this.m_a9.sn(this.m_bb), null);
		bk = (fg.a)global::e.a().SampleReflOption;
		bl[0] = (float)global::e.a().UserSuppliedReflectance;
		bl[1] = (float)global::e.a().UserSuppliedReferenceAngle1;
		if (!Directory.Exists(i3.i()))
		{
			Directory.CreateDirectory(i3.i());
		}
		i3.a(i3.o(), i3.i(), "\\MostRecentReflRefMaterials.fmslf".Substring(1));
		i3.a(i3.o(), i3.i(), "\\MostRecentTransRefMaterials.fmslf".Substring(1));
		this.m_bf = A_0;
		this.m_bh = this.m_a9.va(this.m_bb);
		if (this.m_bh != null)
		{
			this.m_bi = this.m_bh[0];
			this.m_bj = this.m_bh[1];
		}
		int A_7 = default(int);
		this.m_a9.m2(this.m_bb, ref ca, ref A_7);
		cb = (FMF10Subtypes)A_7;
		c7 = this.m_a9.vk(this.m_bb);
		hg hg2 = this.m_a9.wq(this.m_bb);
		bool flag = A_3 && A_2.wp(this.m_bb);
		this.m_bp = this.m_a9.xg(this.m_bb);
		this.m_bq = hg2.d0().c();
		if (this.m_bq == g2.a.b && this.m_bi)
		{
			cc = this.m_a9.vt(this.m_bb) || !this.m_bj;
		}
		bool a_ = this.m_bq == g2.a.c || this.m_bq == g2.a.b;
		bool flag2 = this.m_a9.vl(this.m_bb);
		if (flag)
		{
			bk = fg.a.b;
			f1 f10;
			Guid a_2;
			(f10 = this.m_a9).m2(a_2 = this.m_bb, f10.xg(a_2) + 30f);
		}
		this.m_bs = hg2;
		this.m_br = hg2.b8();
		if (this.m_a9.uj(this.m_bb) == 0)
		{
			c2 = this.m_a9.qh(this.m_bb);
		}
		this.m_a8 = A_1;
		i();
		this.m_a8.m2(0);
		b8 = g2.l(this.m_bq);
		h.e e10 = default(h.e);
		if (b8 == g2.c.c)
		{
			e10 = ((this.m_bq != g2.a.b || !this.m_bi || !this.m_bj) ? this.m_br.a(this.m_bh) : global::h.e.a);
		}
		if (this.m_bq == g2.a.c)
		{
			this.m_bm = global::h.p(e10);
			this.m_bn = global::h.d(e10);
		}
		else
		{
			this.m_bm = true;
			this.m_bn = false;
		}
		if (b8 == g2.c.a || (b8 == g2.c.c && e10 != global::h.e.c))
		{
			bool a_3 = b8 == g2.c.a || !global::h.d(e10);
			bool a_4 = b8 == g2.c.c && !global::h.p(e10);
			int num = this.m_a9.m2(this.m_bb, global::h.f.c);
			float a_5 = default(float);
			bool a_6 = default(bool);
			bool a_7 = default(bool);
			if (num >= 0)
			{
				a_5 = this.m_a9.vc(this.m_bb)[num];
				a_6 = this.m_a9.vd(this.m_bb)[num];
				a_7 = this.m_a9.ve(this.m_bb)[num];
			}
			b7 = "\\MostRecentReflRefMaterials.fmslf";
			b9 = gr.f.b;
			this.m_a8.m2(ref b5, gr.f.b, ref b7);
			gr obj = this.m_a8;
			ref Collection<string> a_8 = ref b5;
			ref Collection<string> a_9 = ref b6;
			ContextMenuStrip A_8 = bq();
			obj.m2(ref a_8, ref a_9, ref A_8, a_3, a_4, a_5, a_6, a_7, j);
			a(A_8);
		}
		else
		{
			b7 = "\\MostRecentTransRefMaterials.fmslf";
			b9 = gr.f.c;
			this.m_a8.m2(ref b5, gr.f.c, ref b7);
			gr obj2 = this.m_a8;
			Collection<string> a_10 = b5;
			ref Collection<string> a_11 = ref b6;
			ContextMenuStrip A_8 = bq();
			obj2.m2(a_10, ref a_11, ref A_8, A_3: true, A_4: false, 0f, A_6: false, A_7: false, j);
			a(A_8);
		}
		l();
		string text = "";
		bool flag3 = false;
		if ((flag2 || !this.m_bi) && e10 == global::h.e.c)
		{
			text = "1";
			cd = false;
		}
		else if (this.m_bq == g2.a.n)
		{
			text = "1";
			cd = false;
		}
		else
		{
			global::h.a(a_, e10);
			if (this.m_bu && !string.IsNullOrEmpty(this.m_bt) && Operators.CompareString(this.m_bt, "0", TextCompare: false) != 0)
			{
				text = this.m_bt;
				if (this.m_bq == g2.a.b && text.StartsWith(ex.e()))
				{
					text = text.Substring(ex.e().Length);
				}
			}
			else
			{
				text = m();
				flag3 = true;
			}
			cd = true;
		}
		if (float.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out var result))
		{
			b(result.ToString());
		}
		else
		{
			bool flag4 = c(text);
			if (!flag3 && !flag4)
			{
				text = m();
				flag3 = true;
				flag4 = c(text);
			}
			if (!flag4 && flag3 && text.StartsWith("ALREF-"))
			{
				foreach (string item in b6)
				{
					if (item.StartsWith("ALREF-"))
					{
						text = item;
						flag4 = true;
						break;
					}
				}
			}
			if (!flag4)
			{
				text = "Si";
				flag4 = c(text);
			}
			if (!flag4)
			{
				if (b6.Count > 0)
				{
					text = b6[0];
				}
				if (!c(text))
				{
					text = "1";
				}
			}
			b(text);
		}
		c();
		bool flag5 = this.m_bc && this.m_a9.tb(this.m_bb);
		bool flag6 = this.m_a9.vn(this.m_bb);
		this.m_bw = ((this.m_bf == e6.b.c && this.m_bq != g2.a.b) || this.m_bf == e6.b.a || this.m_bf == e6.b.e) && ((flag5 && !this.m_br.a0()) || (!flag5 && (this.m_br.n() || c1) && !flag6 && ((b8 != g2.c.c && b8 != g2.c.b) || (b8 == g2.c.c && global::h.b(e10)))));
		this.m_b0 = 1;
		checked
		{
			switch (this.m_bf)
			{
			case e6.b.c:
			{
				string A_9 = "BaselineTitleRefAndDark";
				Text = hu.a(ref A_9);
				this.m_bo = true;
				bool num2 = (flag2 && global::h.p(e10)) || ((flag2 || b8 == g2.c.c) && global::h.n(e10) && global::h.d(e10));
				this.m_bz = 2;
				this.m_b2 = 2;
				if (num2)
				{
					this.m_bz++;
				}
				if (this.m_bw)
				{
					this.m_bz++;
					this.m_b2++;
				}
				if (cc && this.m_bj)
				{
					this.m_bz--;
				}
				this.m_b1 = this.m_b2;
				this.m_b2 += this.m_bx - 1;
				this.m_by = this.m_bz;
				this.m_bz += this.m_bx - 1;
				if (this.m_bw)
				{
					if (flag && !c2)
					{
						this.m_b0++;
						b(ref this.m_be, ref this.m_b0, e6.c.b);
						base.ActiveControl = ad();
						break;
					}
					a(ref this.m_be, ref this.m_b0, A_2: false, !c2);
					if (this.m_b0 == 1)
					{
						base.ActiveControl = w();
					}
				}
				else
				{
					b(ref this.m_be, ref this.m_b0, e6.c.b);
					base.ActiveControl = ad();
				}
				break;
			}
			case e6.b.a:
			{
				string A_9 = "BaselineTitleRefOnly";
				Text = hu.a(ref A_9);
				if (this.m_bw)
				{
					this.m_bz = 2;
					a(ref this.m_be, ref this.m_b0, A_2: false, c2);
					if (this.m_b0 == 1)
					{
						base.ActiveControl = w();
					}
				}
				else
				{
					this.m_bz = 1;
					b(ref this.m_be, ref this.m_b0, e6.c.e);
					base.ActiveControl = ad();
				}
				this.m_by = this.m_bz;
				this.m_bz += this.m_bx - 1;
				break;
			}
			case e6.b.b:
			{
				string A_9 = "BaselineTitleDarkOnly";
				Text = hu.a(ref A_9);
				this.m_bz = 1;
				this.m_b2 = 1;
				a(ref this.m_be, ref this.m_b0, e6.c.c);
				base.ActiveControl = ae();
				break;
			}
			case e6.b.d:
			{
				string A_9 = "BaselineTitleAutoRef";
				Text = hu.a(ref A_9);
				this.m_bz = 2;
				a(ref this.m_be, ref this.m_b0);
				base.ActiveControl = ad();
				break;
			}
			case e6.b.e:
			{
				string A_9 = "BaselineTitleRefOnly";
				Text = hu.a(ref A_9);
				if (this.m_bw)
				{
					this.m_bz = 2;
					a(ref this.m_be, ref this.m_b0, A_2: false, !c2);
					if (this.m_b0 == 1)
					{
						base.ActiveControl = w();
					}
				}
				else
				{
					this.m_bz = 1;
					b(ref this.m_be, ref this.m_b0, e6.c.e);
					base.ActiveControl = ad();
				}
				this.m_by = this.m_bz;
				this.m_bz += this.m_bx - 1;
				break;
			}
			}
			r().Visible = n();
			if (this.m_bq == g2.a.b)
			{
				this.m_a9.u2(this.m_bb);
			}
			if (!g2.j(this.m_bq) && !string.IsNullOrEmpty(this.m_bv))
			{
				Text = Text + " - " + this.m_bv;
			}
			if (A_6)
			{
				base.TopMost = true;
				base.TopMost = false;
				base.TopMost = true;
			}
			ShowDialog();
		}
	}

	private bool n()
	{
		if (this.m_bz <= 2 && (this.m_bz != 2 || !this.m_bw))
		{
			return this.m_be == e6.c.h;
		}
		return true;
	}

	private string m()
	{
		string text = this.m_a9.xh(this.m_bb);
		if (text.StartsWith(ex.e()))
		{
			text = text.Substring(ex.e().Length);
		}
		return text;
	}

	private void c(bool A_0)
	{
		if (this.m_bz <= 2 && !A_0)
		{
			s().Visible = false;
			bn().Visible = true;
		}
		else
		{
			s().Visible = true;
			bn().Visible = false;
		}
	}

	private void l()
	{
		foreach (ToolStripItem item in bq().Items)
		{
			if (item is ToolStripButton)
			{
				((ToolStripButton)item).Click += i;
			}
		}
	}

	private void k()
	{
		if (c2)
		{
			bool A_ = default(bool);
			this.m_ba.i(A_0: true, A_1: false, A_2: false, c5, null, ref A_, i6.a(this), this);
			if (!A_)
			{
				Cursor = Cursors.Default;
				try
				{
					r().Enabled = c4.a;
					ag().Enabled = c4.b;
					f(c4.c);
					aq().Enabled = c4.d;
					return;
				}
				finally
				{
					c4 = null;
				}
			}
		}
		this.m_a9.m2(this.m_bb, bt(), this.m_bc, global::r.d.a.b.a, b2(), i6.a(this));
	}

	private void j()
	{
		fg fg2 = new fg();
		fg.a a10 = bk;
		double a_ = bl[0];
		double a_2 = bl[1];
		float a_3 = this.m_a9.xg(this.m_bb);
		string a_4 = string.Empty;
		if (this.m_bq == g2.a.c && this.m_bn)
		{
			int num = this.m_a9.m2(this.m_bb, global::h.f.c);
			string arg = this.m_a9.vc(this.m_bb)[num].ToString("0");
			string A_ = "ReflectanceAbbrevTitle";
			string obj = hu.a(ref A_);
			A_ = "MultiMeasAtAngleFmt";
			a_4 = obj + string.Format(hu.a(ref A_), arg);
		}
		if (base.TopMost)
		{
			fg2.TopMost = true;
			fg2.TopMost = false;
			fg2.TopMost = true;
		}
		fg2.a(this.m_bd, this.m_a9, this.m_bb, this.m_bm, this.m_bn, a_4, ref bk, ref bl[0], ref bl[1]);
		if (bk != a10 || (this.m_bm && !jf.e(a_, bl[0])) || (this.m_bn && !jf.e(a_2, bl[1])) || !jf.e(a_3, this.m_a9.xg(this.m_bb)))
		{
			this.m_a9.m2(this.m_bb, this.m_bc, bx(), global::r.d.a.b.a);
		}
		else
		{
			b(A_0: true);
		}
	}

	private void i()
	{
		foreach (ToolStripItem item in bq().Items)
		{
			if (item is ToolStripButton)
			{
				((ToolStripButton)item).Click -= i;
			}
		}
	}

	private void m(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (this.m_b0 < this.m_bz)
				{
					this.m_b0++;
				}
				a(ref this.m_be, e6.d.a, ref this.m_b0);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(r()), "DialogBaselineSetup.ButtonNext_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (this.m_be != e6.c.h)
				{
					this.m_b0--;
				}
				a(ref this.m_be, e6.d.b, ref this.m_b0);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(t()), "DialogBaselineSetup.ButtonPrev_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_a9.m2(this.m_bb, this.m_bp);
			this.m_a9.m2(this.m_bb, this.m_bc, by(), global::r.d.a.b.a);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(s()), "DialogBaselineSetup.ButtonCancel_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)A_0;
		if (toolStripMenuItem.DropDownItems.Count == 0)
		{
			if (float.TryParse(toolStripMenuItem.Text, out var result))
			{
				b(result.ToString());
				this.m_a8.m2(ref b5, result.ToString(CultureInfo.InvariantCulture), b9);
			}
			else
			{
				b(toolStripMenuItem.Text);
				this.m_a8.m2(ref b5, toolStripMenuItem.Text, b9);
			}
			b(ref this.m_be, ref this.m_b0, this.m_be);
			this.m_a8.m2(ref b5, ref b7);
		}
	}

	private void b(string A_0)
	{
		this.m_bx = ex.e(A_0);
		aa().Text = A_0;
		checked
		{
			this.m_bz = this.m_by + this.m_bx - 1;
			this.m_b2 = this.m_b1 + this.m_bx - 1;
			d();
		}
	}

	private void a(object A_0, ToolStripItemClickedEventArgs A_1)
	{
		try
		{
			ToolStripItem clickedItem = A_1.ClickedItem;
			if (clickedItem is ToolStripMenuItem)
			{
				j(clickedItem, null);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(z()), "DialogBaselineSetup.mReflOrTransReferenceMenuStrip_ItemClicked", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		try
		{
			ToolStripButton toolStripButton = (ToolStripButton)A_0;
			string left = toolStripButton.Text;
			string A_2 = "ClearMRLddd";
			if (Operators.CompareString(left, hu.a(ref A_2), TextCompare: false) == 0)
			{
				A_2 = "ClearMRLQuestion";
				string prompt = hu.a(ref A_2);
				A_2 = "ClearMRL";
				if (Interaction.MsgBox(prompt, MsgBoxStyle.YesNo, hu.a(ref A_2)) == MsgBoxResult.Yes)
				{
					gr obj = this.m_a8;
					ContextMenuStrip A_3 = bq();
					obj.m2(ref A_3);
					a(A_3);
					this.m_a8.m2(0);
					b5.Clear();
				}
				return;
			}
			string left2 = toolStripButton.Text;
			A_2 = "EnterConstant";
			if (Operators.CompareString(left2, hu.a(ref A_2), TextCompare: false) != 0)
			{
				return;
			}
			fe fe2 = new fe(this.m_bd);
			fe.a a10 = new fe.a();
			A_2 = "ReferenceEnterConstant";
			a10.w(hu.a(ref A_2));
			a10.x("ReferenceEnterConstantTitle");
			a10.w(this);
			a10.w(fe.b.a);
			a10.w(0.0);
			a10.x(double.MaxValue);
			fe2.TopMost = base.TopMost;
			if (fe2.b(a10) == DialogResult.OK)
			{
				double.TryParse(a10.ag(), out var result);
				if ((result > a10.ai()) & (result <= a10.aj()))
				{
					b(result.ToString());
					this.m_a8.m2(ref b5, result.ToString(CultureInfo.InvariantCulture), b9);
					this.m_a8.m2(ref b5, ref b7);
				}
				else
				{
					b(Conversions.ToString(1));
					A_2 = "ReferenceInvalidConstantValue";
					string prompt2 = string.Format(hu.a(ref A_2));
					A_2 = "Information";
					Interaction.MsgBox(prompt2, MsgBoxStyle.OkOnly, hu.a(ref A_2));
				}
				b(ref this.m_be, ref this.m_b0, this.m_be);
			}
			fe2.c4();
			fe2 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(z()), "DialogBaselineSetup.TheToolStripButton_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				i();
				gr obj = this.m_a8;
				Collection<string> a_ = b5;
				gr.f a_2 = b9;
				ContextMenuStrip A_2 = bq();
				obj.m2(a_, a_2, A_2: true, ref A_2);
				a(A_2);
				l();
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
				toolStripMenuItem.Text = "This is to make the menu strip size properly.";
				bq().Items.Insert(bq().Items.Count, toolStripMenuItem);
				bq().Items.RemoveAt(bq().Items.Count - 1);
				Point position = new Point
				{
					X = -1,
					Y = aa().Height - 1
				};
				bq().Show(aa(), position);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(z()), "DialogBaselineSetup.ButtonRefMatSelect_Click", a_3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void a(ref c A_0, d A_1, ref int A_2)
	{
		checked
		{
			switch (A_0)
			{
			case e6.c.a:
				if (A_1 == e6.d.a)
				{
					if (this.m_bf == e6.b.a || this.m_bf == e6.b.e)
					{
						b(ref A_0, ref A_2, e6.c.e);
					}
					else
					{
						b(ref A_0, ref A_2, e6.c.b);
					}
					if (r().Enabled)
					{
						base.ActiveControl = r();
					}
					else
					{
						base.ActiveControl = ad();
					}
					break;
				}
				throw new am("Attempt to change state other than next when current state is TakeReflectance");
			case e6.c.b:
				if (A_1 == e6.d.a)
				{
					if (this.m_bx == 1 || b(A_2 - 1) + 1 == this.m_bx)
					{
						a(ref A_0, ref A_2, e6.c.c);
						if (r().Enabled)
						{
							base.ActiveControl = r();
						}
						else
						{
							base.ActiveControl = ae();
						}
					}
					else
					{
						b(ref A_0, ref A_2, e6.c.b);
						if (r().Enabled)
						{
							base.ActiveControl = r();
						}
						else
						{
							base.ActiveControl = ad();
						}
					}
				}
				else if (b(A_2 + 1) == 0)
				{
					a(ref A_0, ref A_2, A_1 != e6.d.a, A_3: true);
					base.ActiveControl = r();
				}
				else
				{
					b(ref A_0, ref A_2, e6.c.b);
					if (r().Enabled)
					{
						base.ActiveControl = r();
					}
					else
					{
						base.ActiveControl = ad();
					}
				}
				break;
			case e6.c.c:
			case e6.c.d:
				if (A_1 == e6.d.a)
				{
					h.e e10 = default(h.e);
					if (this.m_bq == g2.a.c)
					{
						e10 = this.m_br.a(this.m_bh);
					}
					else if (this.m_bq == g2.a.b)
					{
						e10 = ((!this.m_bi || !this.m_bj) ? this.m_br.a(this.m_bh) : global::h.e.a);
					}
					if (this.m_bq != g2.a.c && this.m_bq != g2.a.b)
					{
						if (this.m_bq == g2.a.e || this.m_bf == e6.b.b)
						{
							e();
						}
						else
						{
							b(ref A_0, ref A_2);
						}
					}
					else if ((!global::h.p(e10) && (e10 == global::h.e.c || e10 == global::h.e.d)) || A_0 == e6.c.d || (A_0 == e6.c.c && cc))
					{
						e();
					}
					else if (A_0 == e6.c.c)
					{
						a(ref A_0, ref A_2, e6.c.d);
					}
					else
					{
						b(ref A_0, ref A_2);
					}
					if (r().Enabled)
					{
						base.ActiveControl = r();
					}
					else
					{
						base.ActiveControl = ae();
					}
				}
				else
				{
					if (A_0 == e6.c.d)
					{
						a(ref A_0, ref A_2, e6.c.c);
					}
					else
					{
						b(ref A_0, ref A_2, e6.c.b);
					}
					base.ActiveControl = r();
				}
				break;
			case e6.c.e:
				if (A_1 == e6.d.a)
				{
					e();
					break;
				}
				a(ref A_0, ref A_2, A_1 != e6.d.a, A_3: true);
				base.ActiveControl = r();
				break;
			case e6.c.f:
				if (A_1 == e6.d.a)
				{
					a(ref A_0, A_2);
					if (r().Enabled)
					{
						base.ActiveControl = r();
					}
					else
					{
						base.ActiveControl = ae();
					}
				}
				break;
			case e6.c.g:
				if (A_1 == e6.d.a)
				{
					e();
					break;
				}
				a(ref A_0, ref A_2);
				base.ActiveControl = r();
				break;
			case e6.c.h:
				if (A_1 == e6.d.a)
				{
					e();
					break;
				}
				if (this.m_bq != g2.a.c && this.m_bq != g2.a.b)
				{
					a(ref A_0, ref A_2, e6.c.c);
				}
				else
				{
					a(ref A_0, ref A_2, e6.c.d);
				}
				base.ActiveControl = r();
				break;
			default:
				base.DialogResult = DialogResult.Cancel;
				throw new ArgumentOutOfRangeException("Invalid state in DialogBaselineSetup");
			}
		}
	}

	private void h()
	{
		if (this.m_bq == g2.a.b)
		{
			ah().Image = Resources.F2Empty;
		}
		else
		{
			ah().Image = Resources.F10VCEmpty;
		}
		ak().Location = new Point(ct.X, checked(ct.Y + 20));
		Label label = ak();
		string A_ = "SampleHere";
		label.Text = hu.a(ref A_);
		ak().Visible = true;
		Label label2 = x();
		A_ = "BaselineReflLabelStage";
		label2.Text = hu.a(ref A_);
	}

	private void g()
	{
		TabControl tabControl = bm();
		tabControl.ItemSize = new Size(checked(tabControl.ClientSize.Width - 6), tabControl.ItemSize.Height);
		tabControl = null;
	}

	private void a(TabPage A_0)
	{
		bm().TabPages.Clear();
		bm().TabPages.Add(A_0);
		g();
	}

	private void a(ref c A_0, ref int A_1, bool A_2, bool A_3)
	{
		checked
		{
			try
			{
				c c10 = A_0;
				a6().SuspendLayout();
				a(aq());
				b(!A_2 && A_3);
				if (A_0 != c10)
				{
					return;
				}
				Button button = r();
				string A_4 = "WizardNext";
				button.Text = hu.a(ref A_4);
				TabPage tabPage = aq();
				string obj = a(A_1);
				A_4 = "TakeSampleReflectance";
				tabPage.Text = obj + ": " + hu.a(ref A_4);
				if (A_1 == 1)
				{
					t().Enabled = false;
				}
				if (this.m_bf == e6.b.a && !this.m_bc)
				{
					ag().Visible = false;
					c(A_0: false);
				}
				else
				{
					c();
				}
				w().Enabled = bk == fg.a.a;
				switch (this.m_bq)
				{
				case g2.a.d:
				{
					if (this.m_a9.vr(this.m_bb))
					{
						h();
						break;
					}
					ah().Image = Resources.StageBack;
					ak().Location = new Point(ct.X, ct.Y + 10);
					Label label3 = ak();
					A_4 = "SampleHere";
					label3.Text = hu.a(ref A_4);
					ak().Visible = true;
					Label label4 = x();
					A_4 = "BaselineReflLabelStage";
					label4.Text = hu.a(ref A_4);
					break;
				}
				case g2.a.f:
				{
					ah().Image = Resources.MSEmpty;
					ak().Location = new Point(ct.X, ct.Y + 40);
					Label label5 = ak();
					A_4 = "SampleHere";
					label5.Text = hu.a(ref A_4);
					ak().Visible = true;
					Label label6 = x();
					A_4 = "BaselineReflLabelMS";
					label6.Text = hu.a(ref A_4);
					break;
				}
				case g2.a.b:
				case g2.a.c:
					h();
					break;
				case g2.a.h:
					if (o())
					{
						ah().Image = Resources.F3CPSample;
						Label label7 = x();
						A_4 = "BaselineReflLabelIntegratedCP";
						label7.Text = hu.a(ref A_4);
					}
					else
					{
						ah().Image = Resources.ContactProbeSample;
						Label label8 = x();
						A_4 = "BaselineReflLabelCP";
						label8.Text = hu.a(ref A_4);
					}
					ak().Visible = false;
					break;
				case g2.a.j:
				{
					if (o())
					{
						ah().Image = Resources.F3CSSample;
					}
					else
					{
						ah().Image = Resources.ContactStageRef_BK7;
					}
					Label label = ak();
					A_4 = "SampleHere";
					label.Text = hu.a(ref A_4);
					ak().Visible = true;
					Label label2 = x();
					A_4 = "BaselineReflLabelCS";
					label2.Text = hu.a(ref A_4);
					break;
				}
				default:
					throw new ar("Unknown or unhandled optics configuration type: SetStateTakeReflectance");
				}
			}
			finally
			{
				a6().ResumeLayout();
				a6().Refresh();
			}
			A_0 = e6.c.a;
		}
	}

	private int b(int A_0)
	{
		checked
		{
			if (this.m_bw)
			{
				return A_0 - 2;
			}
			return A_0 - 1;
		}
	}

	private int a(int A_0, int A_1)
	{
		int num = b(A_0);
		checked
		{
			if (this.m_bx > 1)
			{
				if (num == 0)
				{
					return A_1;
				}
				int num2 = 1;
				int num3 = this.m_bx - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (num4 != A_1)
					{
						if (num == num2)
						{
							return num4;
						}
						num2++;
					}
				}
				int result = default(int);
				return result;
			}
			return 0;
		}
	}

	private void b(ref c A_0, ref int A_1, c A_2)
	{
		try
		{
			a6().SuspendLayout();
			a(au());
			if (this.m_bq == g2.a.e || this.m_bq == g2.a.g || this.m_bq == g2.a.n || (this.m_bq == g2.a.b && !this.m_bi) || (this.m_bq == g2.a.c && !this.m_br.v()))
			{
				TabPage tabPage = au();
				string obj = a(A_1);
				string A_3 = "TakeTransmittanceStandard";
				tabPage.Text = obj + ": " + hu.a(ref A_3);
			}
			else
			{
				TabPage tabPage2 = au();
				string obj2 = a(A_1);
				string A_3 = "TakeReflectanceStandard";
				tabPage2.Text = obj2 + ": " + hu.a(ref A_3);
			}
			int a_ = this.m_a9.tc(this.m_bb, this.m_bc);
			if (this.m_bq == g2.a.b && this.m_bi)
			{
				r().Enabled = this.m_a9.p9(this.m_bb, aa().Text);
			}
			else
			{
				r().Enabled = this.m_a9.m2(this.m_bb, a(A_1, a_), aa().Text, this.m_bc);
			}
			if (r().Enabled)
			{
				Label label = ay();
				string A_3 = "BaselineStatusComplete";
				label.Text = hu.a(ref A_3);
			}
			else
			{
				Label label2 = ay();
				string A_3 = "BaselineStatusIncomplete";
				label2.Text = hu.a(ref A_3);
			}
			d();
			t().Enabled = A_1 > 1;
			t().Visible = this.m_bz > 2;
			r().Visible = n();
			z().Enabled = cd && b(A_1) == 0;
			if (this.m_bf == e6.b.a || (this.m_bf == e6.b.e && A_1 > 1))
			{
				t().Visible = true;
				Button button = r();
				string A_3 = "WizardFinish";
				button.Text = hu.a(ref A_3);
				ag().Visible = false;
				c(A_0: false);
			}
			else
			{
				Button button2 = r();
				string A_3 = "WizardNext";
				button2.Text = hu.a(ref A_3);
				this.m_a9.p9(this.m_bb, this.m_bc, A_2: true);
				c();
			}
			a(A_0: true, A_2);
			A_0 = A_2;
		}
		finally
		{
			a6().ResumeLayout();
			a6().Refresh();
		}
	}

	private void b(ref c A_0, ref int A_1)
	{
		try
		{
			a6().SuspendLayout();
			a(bo());
			r().Enabled = true;
			t().Enabled = A_1 > 1;
			t().Visible = this.m_bz > 1;
			this.m_be = e6.c.h;
			r().Visible = n();
			Button button = r();
			string A_2 = "WizardFinish";
			button.Text = hu.a(ref A_2);
			c(A_0: false);
		}
		finally
		{
			a6().ResumeLayout();
			a6().Refresh();
		}
	}

	private void f()
	{
		checked
		{
			if (this.m_bq == g2.a.b)
			{
				al().Location = new Point(cs.X, cs.Y + 27);
				Label label = al();
				string A_ = "ReferenceHere";
				label.Text = hu.a(ref A_);
				string text = aa().Text.ToUpper();
				if (Operators.CompareString(text, "SI", TextCompare: false) == 0)
				{
					al().Visible = false;
					ai().Image = Resources.F2SiRef;
				}
				else if (Operators.CompareString(text, "BK7", TextCompare: false) == 0)
				{
					al().Visible = false;
					ai().Image = Resources.F2BK7Ref;
				}
				else if (text.Length >= 6 && Operators.CompareString(text.Substring(0, 6), "ALREF-", TextCompare: false) == 0)
				{
					al().Visible = false;
					ai().Image = Resources.F2AlRef;
				}
				else
				{
					ai().Image = Resources.F2Empty;
					al().Visible = true;
				}
				Label label2 = ab();
				A_ = "BaselineReflectanceStandard";
				label2.Text = hu.a(ref A_);
				Button button = ad();
				A_ = "TakeReflectanceStandard";
				button.Text = hu.a(ref A_);
				ap().Visible = false;
			}
			else
			{
				ap().Visible = true;
				if (Operators.CompareString(aa().Text.ToUpper(), "FUSED SILICA (2-SIDED)", TextCompare: false) == 0)
				{
					ai().Image = Resources.F10VCRef_FusedSilica;
					al().Visible = false;
					return;
				}
				if (Operators.CompareString(aa().Text.ToUpper(), "AL2O3 (2-SIDED)", TextCompare: false) == 0)
				{
					ai().Image = Resources.F10VCRef_Al2O3;
					al().Visible = false;
					return;
				}
				ai().Image = Resources.F10VCEmpty;
				al().Location = new Point(cs.X, cs.Y + 20);
				Label label3 = al();
				string A_ = "ReferenceHere";
				label3.Text = hu.a(ref A_);
				al().Visible = true;
			}
		}
	}

	private void a(bool A_0, c A_1)
	{
		checked
		{
			switch (this.m_bq)
			{
			case g2.a.d:
				if (this.m_a9.vr(this.m_bb))
				{
					if (A_0)
					{
						Label label14 = ac();
						string A_2 = "BaselineRefLabelF10VC";
						label14.Text = hu.a(ref A_2);
					}
					f();
					break;
				}
				if (Operators.CompareString(aa().Text.ToUpper(), "SI", TextCompare: false) == 0)
				{
					ai().Image = Resources.StageRef_Si;
					al().Visible = false;
				}
				else
				{
					ai().Image = Resources.StageBack;
					al().Location = new Point(cs.X, cs.Y + 10);
					Label label15 = al();
					string A_2 = "ReferenceHere";
					label15.Text = hu.a(ref A_2);
					al().Visible = true;
				}
				if (A_0)
				{
					Label label16 = ac();
					string A_2 = "BaselineRefLabelStage";
					label16.Text = hu.a(ref A_2);
				}
				break;
			case g2.a.e:
				if (c7)
				{
					string A_2;
					if (A_0)
					{
						Label label2 = ac();
						A_2 = "BaselineTransOnlyRefLabelStage";
						label2.Text = hu.a(ref A_2);
					}
					Button button = ad();
					A_2 = "TakeTransmittanceStandard";
					button.Text = hu.a(ref A_2);
					Label label3 = ab();
					A_2 = "BaselineTransmittanceStandard";
					label3.Text = hu.a(ref A_2);
					ai().Image = Resources.F10VCEmpty;
					al().Visible = false;
					break;
				}
				ai().Image = Resources.TransStageRef;
				if (Operators.CompareString(aa().Text.ToUpper(), "1", TextCompare: false) == 0)
				{
					al().Visible = false;
					if (A_0)
					{
						Label label4 = ac();
						string A_2 = "BaselineRefLabelTransEmpty";
						label4.Text = hu.a(ref A_2);
					}
				}
				else
				{
					al().Location = new Point(cs.X, cs.Y + 10);
					Label label5 = al();
					string A_2 = "ReferenceHere";
					label5.Text = hu.a(ref A_2);
					al().Visible = true;
					if (A_0)
					{
						Label label6 = ac();
						A_2 = "BaselineRefLabelTrans";
						label6.Text = hu.a(ref A_2);
					}
				}
				if (A_0)
				{
					Button button2 = ad();
					string A_2 = "TakeTransmittanceStandard";
					button2.Text = hu.a(ref A_2);
					Label label7 = ab();
					A_2 = "BaselineTransmittanceStandard";
					label7.Text = hu.a(ref A_2);
				}
				break;
			case g2.a.n:
				ai().Image = Resources.SSTransCurvedEmpty;
				al().Visible = false;
				if (A_0)
				{
					Label label28 = ac();
					string A_2 = "BaselineRefLabelTransEmpty";
					label28.Text = hu.a(ref A_2);
				}
				if (A_0)
				{
					Button button6 = ad();
					string A_2 = "TakeTransmittanceStandard";
					button6.Text = hu.a(ref A_2);
					Label label29 = ab();
					A_2 = "BaselineTransmittanceStandard";
					label29.Text = hu.a(ref A_2);
				}
				break;
			case g2.a.f:
				if (Operators.CompareString(aa().Text.ToUpper(), "SI", TextCompare: false) == 0)
				{
					ai().Image = Resources.MSRef;
					al().Visible = false;
				}
				else
				{
					ai().Image = Resources.MSEmpty;
					al().Location = new Point(cs.X, cs.Y + 40);
					Label label30 = al();
					string A_2 = "ReferenceHere";
					label30.Text = hu.a(ref A_2);
					al().Visible = true;
				}
				if (A_0)
				{
					Label label31 = ac();
					string A_2 = "BaselineRefLabelMS";
					label31.Text = hu.a(ref A_2);
				}
				break;
			case g2.a.g:
				ai().Image = Resources.MSEmpty;
				if (Operators.CompareString(aa().Text.ToUpper(), "1", TextCompare: false) == 0)
				{
					al().Visible = false;
					if (A_0)
					{
						Label label10 = ac();
						string A_2 = "BaselineRefLabelTransEmpty";
						label10.Text = hu.a(ref A_2);
					}
				}
				else
				{
					al().Location = new Point(cs.X, cs.Y + 40);
					Label label11 = al();
					string A_2 = "ReferenceHere";
					label11.Text = hu.a(ref A_2);
					al().Visible = true;
					if (A_0)
					{
						Label label12 = ac();
						A_2 = "BaselineRefLabelMSTrans";
						label12.Text = hu.a(ref A_2);
					}
				}
				if (A_0)
				{
					Button button3 = ad();
					string A_2 = "TakeTransmittanceStandard";
					button3.Text = hu.a(ref A_2);
					Label label13 = ab();
					A_2 = "BaselineTransmittanceStandard";
					label13.Text = hu.a(ref A_2);
				}
				break;
			case g2.a.h:
				if (o())
				{
					ai().Image = Resources.F3CPRef_BK7;
					if (A_0)
					{
						Label label32 = ac();
						string A_2 = "BaselineRefLabelIntegratedCP";
						label32.Text = hu.a(ref A_2);
					}
				}
				else
				{
					ai().Image = Resources.ContactProbeRef_BK7;
					if (A_0)
					{
						Label label33 = ac();
						string A_2 = "BaselineRefLabelCP";
						label33.Text = hu.a(ref A_2);
					}
				}
				al().Visible = false;
				break;
			case g2.a.j:
				if (Operators.CompareString(aa().Text.ToUpper(), "BK7", TextCompare: false) == 0)
				{
					if (o())
					{
						ai().Image = Resources.F3CSRef_BK7;
					}
					else
					{
						ai().Image = Resources.ContactStageRef_BK7;
					}
					al().Visible = false;
				}
				else if (Operators.CompareString(aa().Text.ToUpper(), "SI", TextCompare: false) == 0)
				{
					if (o())
					{
						ai().Image = Resources.F3CSRef_Si;
					}
					else
					{
						ai().Image = Resources.ContactStageRef_Si;
					}
					al().Visible = false;
				}
				else
				{
					if (o())
					{
						ai().Image = Resources.F3CSRef_BK7;
					}
					else
					{
						ai().Image = Resources.ContactStageRef_BK7;
					}
					Label label8 = al();
					string A_2 = "ReferenceHere";
					label8.Text = hu.a(ref A_2);
					al().Visible = true;
				}
				if (A_0)
				{
					Label label9 = ac();
					string A_2 = "BaselineRefLabelCS";
					label9.Text = hu.a(ref A_2);
				}
				break;
			case g2.a.b:
			case g2.a.c:
				if (this.m_bq == g2.a.c && this.m_br.a(this.m_bh) == global::h.e.c)
				{
					string A_2;
					if (A_0)
					{
						Label label17 = ac();
						A_2 = "BaselineTransOnlyRefLabelStage";
						label17.Text = hu.a(ref A_2);
					}
					Button button4 = ad();
					A_2 = "TakeTransmittanceStandard";
					button4.Text = hu.a(ref A_2);
					Label label18 = ab();
					A_2 = "BaselineTransmittanceStandard";
					label18.Text = hu.a(ref A_2);
					ai().Image = Resources.F10VCEmpty;
					al().Visible = false;
				}
				else if (this.m_bq == g2.a.b)
				{
					ag().Visible = false;
					c(A_0: false);
					if (A_1 == e6.c.b)
					{
						string A_2;
						if (this.m_bi)
						{
							if (A_0)
							{
								Label label19 = ac();
								A_2 = "BaselineRefLabelF2";
								label19.Text = hu.a(ref A_2);
							}
							f();
							break;
						}
						if (Operators.CompareString(aa().Text.ToUpper(), "1", TextCompare: false) == 0)
						{
							al().Visible = false;
							if (A_0)
							{
								Label label20 = ac();
								A_2 = "BaselineRefLabelTransEmptyF2";
								label20.Text = hu.a(ref A_2);
							}
						}
						else
						{
							Label label21 = al();
							A_2 = "ReferenceHere";
							label21.Text = hu.a(ref A_2);
							al().Location = new Point(cs.X, cs.Y + 27);
							al().Visible = true;
							if (A_0)
							{
								Label label22 = ac();
								A_2 = "BaselineRefLabelTransF2";
								label22.Text = hu.a(ref A_2);
							}
						}
						Button button5 = ad();
						A_2 = "TakeTransmittanceStandard";
						button5.Text = hu.a(ref A_2);
						Label label23 = ab();
						A_2 = "BaselineTransmittanceStandard";
						label23.Text = hu.a(ref A_2);
						ai().Image = Resources.F2Empty;
						ap().Visible = false;
					}
					else
					{
						if (A_0)
						{
							Label label24 = ac();
							string A_2 = "BaselineRefLabelF2";
							label24.Text = hu.a(ref A_2);
						}
						ai().Image = Resources.F2Empty;
						al().Visible = false;
					}
				}
				else
				{
					if (A_0)
					{
						Label label25 = ac();
						string A_2 = "BaselineRefLabelF10VC";
						label25.Text = hu.a(ref A_2);
					}
					if (A_1 == e6.c.b)
					{
						f();
						break;
					}
					ai().Image = Resources.F10VCEmpty;
					al().Visible = false;
				}
				break;
			case g2.a.i:
				if (o())
				{
					ai().Image = Resources.F3CPRef_BK7;
					if (A_0)
					{
						Label label26 = ac();
						string A_2 = "BaselineAutoRefIntegratedCPPrompt";
						label26.Text = hu.a(ref A_2);
					}
				}
				else
				{
					ai().Image = Resources.ContactProbeRef_BK7;
					if (A_0)
					{
						Label label27 = ac();
						string A_2 = "BaselineAutoRefCPPrompt";
						label27.Text = hu.a(ref A_2);
					}
				}
				al().Visible = false;
				break;
			case g2.a.k:
				if (A_0)
				{
					Label label = ac();
					string A_2 = "BaselineAutoRefCSPrompt";
					label.Text = hu.a(ref A_2);
				}
				if (o())
				{
					ai().Image = Resources.F3CSRef_BK7;
				}
				else
				{
					ai().Image = Resources.ContactStageRef_BK7;
				}
				al().Visible = false;
				break;
			default:
				throw new ar("Unknown or unhandled optics configuration type: SetStateTakeReference");
			}
			g();
		}
	}

	private void a(ref c A_0, ref int A_1, c A_2)
	{
		try
		{
			a6().SuspendLayout();
			a(a0());
			d(A_0: true);
			r().Visible = n();
			h.e a_ = default(h.e);
			if (this.m_bq == g2.a.c)
			{
				a_ = this.m_br.a(this.m_bh);
			}
			else if (this.m_bq == g2.a.b)
			{
				a_ = ((!this.m_bi || !this.m_bj) ? this.m_br.a(this.m_bh) : global::h.e.a);
			}
			if (A_2 == e6.c.d || (cc && A_2 == e6.c.c) || (this.m_bq != g2.a.c && this.m_bq != g2.a.b) || (!global::h.p(a_) && (!global::h.n(a_) || !global::h.d(a_))) || this.m_bf == e6.b.b)
			{
				bool flag = (this.m_bq == g2.a.c || this.m_bq == g2.a.b) && global::h.n(a_) && global::h.b(a_);
				r().Enabled = this.m_a9.td(this.m_bb, this.m_bc) && (!flag || this.m_a9.wm(this.m_bb));
				if (A_0 == e6.c.h)
				{
					Button button = r();
					string A_3 = "WizardNext";
					button.Text = hu.a(ref A_3);
				}
			}
			else
			{
				r().Enabled = this.m_a9.wn(this.m_bb) && this.m_a9.qh(this.m_bb, "1");
				Button button2 = r();
				string A_3 = "WizardNext";
				button2.Text = hu.a(ref A_3);
			}
			if (!c0 && this.m_bf == e6.b.b)
			{
				ag().Visible = false;
				c(A_0: false);
			}
			else
			{
				c();
			}
			if (r().Enabled)
			{
				Label label = a3();
				string A_3 = "BaselineStatusComplete";
				label.Text = hu.a(ref A_3);
			}
			else
			{
				Label label2 = a3();
				string A_3 = "BaselineStatusIncomplete";
				label2.Text = hu.a(ref A_3);
			}
			t().Enabled = A_1 > 1;
			t().Visible = this.m_bz > 2;
			a(A_2, a(A_1));
		}
		finally
		{
			a6().ResumeLayout();
			a6().Refresh();
		}
		A_0 = A_2;
	}

	private string a(int A_0)
	{
		string text = null;
		string A_1;
		if (hu.a("BaselineSetupSteps") == 1)
		{
			A_1 = "BaselineSetupSteps";
			return string.Format(hu.a(ref A_1), A_0);
		}
		A_1 = "BaselineSetupSteps";
		return string.Format(hu.a(ref A_1), A_0, this.m_bz);
	}

	private void a(string A_0)
	{
		if (this.m_bq == g2.a.b && this.m_bi)
		{
			Label label = af();
			string A_1 = "BaselineBacLabelF2";
			label.Text = hu.a(ref A_1);
			TabPage tabPage = a0();
			A_1 = "BaselineDarkButtonF2";
			tabPage.Text = A_0 + ": " + hu.a(ref A_1);
			Button button = ae();
			A_1 = "BaselineDarkButtonF2";
			button.Text = hu.a(ref A_1);
			aj().Image = Resources.F2Back;
		}
		else if (this.m_bq == g2.a.b)
		{
			Button button2 = ae();
			string A_1 = "BaselineBacLightBlocked";
			button2.Text = hu.a(ref A_1);
			Label label2 = af();
			A_1 = "BaselineBacLabelTransDark";
			label2.Text = hu.a(ref A_1);
			TabPage tabPage2 = a0();
			A_1 = "BaselineBacLightBlocked";
			tabPage2.Text = A_0 + ": " + hu.a(ref A_1);
			aj().Image = Resources.F2Back;
		}
		else
		{
			Button button3 = ae();
			string A_1 = "TakeDark";
			button3.Text = hu.a(ref A_1);
			Label label3 = af();
			A_1 = "BaselineBacLabelTransAndRefl";
			label3.Text = hu.a(ref A_1);
			TabPage tabPage3 = a0();
			A_1 = "BackgroundLightDeflected";
			tabPage3.Text = A_0 + ": " + hu.a(ref A_1);
			aj().Image = Resources.F10VCBack;
		}
		g();
	}

	private void a(c A_0, string A_1)
	{
		switch (this.m_bq)
		{
		case g2.a.d:
		{
			if (this.m_a9.vr(this.m_bb))
			{
				a(A_1);
				break;
			}
			Label label4 = af();
			string A_2 = "BaselineBacLabelStage";
			label4.Text = hu.a(ref A_2);
			TabPage tabPage2 = a0();
			A_2 = "TakeBackground";
			tabPage2.Text = A_1 + ": " + hu.a(ref A_2);
			aj().Image = Resources.StageBack;
			break;
		}
		case g2.a.h:
		{
			TabPage tabPage3 = a0();
			string A_2 = "TakeBackground";
			tabPage3.Text = A_1 + ": " + hu.a(ref A_2);
			if (o())
			{
				Label label7 = af();
				A_2 = "BaselineBacLabelIntegratedCP";
				label7.Text = hu.a(ref A_2);
				aj().Image = Resources.F3CPBack;
			}
			else
			{
				Label label8 = af();
				A_2 = "BaselineBacLabelCP";
				label8.Text = hu.a(ref A_2);
				aj().Image = Resources.ContactProbeBack;
			}
			break;
		}
		case g2.a.b:
		case g2.a.c:
		case g2.a.j:
			if (A_0 == e6.c.c)
			{
				if (this.m_bq == g2.a.c && this.m_br.a(this.m_bh) == global::h.e.c)
				{
					a(A_1);
				}
				else if (this.m_bq == g2.a.j)
				{
					TabPage tabPage4 = a0();
					string A_2 = "BackgroundNoSample";
					tabPage4.Text = A_1 + ": " + hu.a(ref A_2);
					Button button = ae();
					A_2 = "AcquireBackground";
					button.Text = hu.a(ref A_2);
					if (o())
					{
						aj().Image = Resources.F3CSBack;
						Label label9 = af();
						A_2 = "BaselineBacLabelIntegratedCS";
						label9.Text = hu.a(ref A_2);
					}
					else
					{
						aj().Image = Resources.ContactStageBack;
						Label label10 = af();
						A_2 = "BaselineBacLabelStage";
						label10.Text = hu.a(ref A_2);
					}
				}
				else if (this.m_bq == g2.a.b)
				{
					if (this.m_bi)
					{
						Label label11 = af();
						string A_2 = "BaselineBackLabelStageF2";
						label11.Text = hu.a(ref A_2);
						aj().Image = Resources.F2Empty;
						TabPage tabPage5 = a0();
						A_2 = "TakeBackground";
						tabPage5.Text = A_1 + ": " + hu.a(ref A_2);
						Button button2 = ae();
						A_2 = "TakeBackground";
						button2.Text = hu.a(ref A_2);
					}
					else
					{
						a(A_1);
					}
				}
				else
				{
					Label label12 = af();
					string A_2 = "BaselineBacLabelStage";
					label12.Text = hu.a(ref A_2);
					TabPage tabPage6 = a0();
					A_2 = "BackgroundNoSample";
					tabPage6.Text = A_1 + ": " + hu.a(ref A_2);
					Button button3 = ae();
					A_2 = "AcquireBackground";
					button3.Text = hu.a(ref A_2);
					aj().Image = Resources.F10VCEmpty;
				}
			}
			else
			{
				a(A_1);
			}
			break;
		case g2.a.e:
		{
			if (c7)
			{
				a(A_1);
				break;
			}
			Label label3 = af();
			string A_2 = "BaselineBacLabelTrans";
			label3.Text = hu.a(ref A_2);
			TabPage tabPage = a0();
			A_2 = "TakeBackground";
			tabPage.Text = A_1 + ": " + hu.a(ref A_2);
			aj().Image = Resources.ContactStageRef_BK7;
			break;
		}
		case g2.a.n:
		{
			Label label14 = af();
			string A_2 = "BaselineBacLabelTrans";
			label14.Text = hu.a(ref A_2);
			TabPage tabPage8 = a0();
			A_2 = "TakeBackground";
			tabPage8.Text = A_1 + ": " + hu.a(ref A_2);
			aj().Image = Resources.SSTransCurvedBack;
			break;
		}
		case g2.a.f:
		case g2.a.g:
		{
			Label label13 = af();
			string A_2 = "BaselineBacLabelMS";
			label13.Text = hu.a(ref A_2);
			TabPage tabPage7 = a0();
			A_2 = "TakeBackground";
			tabPage7.Text = A_1 + ": " + hu.a(ref A_2);
			aj().Image = Resources.MSBack;
			break;
		}
		case g2.a.i:
			if (o())
			{
				aj().Image = Resources.F3CPBack;
				Label label5 = af();
				string A_2 = "BaselineBacLabelIntegratedCP";
				label5.Text = hu.a(ref A_2);
			}
			else
			{
				aj().Image = Resources.ContactProbeBack;
				Label label6 = af();
				string A_2 = "FiberTipPrompt";
				label6.Text = hu.a(ref A_2);
			}
			break;
		case g2.a.k:
			if (o())
			{
				aj().Image = Resources.F3CSBack;
				Label label = af();
				string A_2 = "BaselineBacLabelIntegratedCS";
				label.Text = hu.a(ref A_2);
			}
			else
			{
				aj().Image = Resources.ContactStageBack;
				Label label2 = af();
				string A_2 = "BaselineBacLabelStage";
				label2.Text = hu.a(ref A_2);
			}
			break;
		default:
			throw new ar("Unknown or unhandled optics configuration type: SetBackgroundGUIDetails");
		}
		g();
	}

	private void e()
	{
		bool flag = false;
		bool flag2 = false;
		if (this.m_bf == e6.b.b)
		{
			flag = this.m_a9.so(this.m_bb, this.m_bc);
			flag2 = true;
		}
		else if (this.m_bf == e6.b.a)
		{
			flag = true;
			flag2 = this.m_a9.sn(this.m_bb, this.m_bc);
		}
		else
		{
			flag = true;
			flag2 = true;
		}
		if (this.m_bq == g2.a.n && this.m_bf == e6.b.a)
		{
			base.DialogResult = DialogResult.OK;
		}
		else
		{
			this.m_a9.m2(this.m_bb, flag, flag2, bw(), this.m_bc, global::r.d.a.b.a);
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		try
		{
			if (!c8 && this.m_b0 == 1 && a(this.m_b0, this.m_a9.tc(this.m_bb, this.m_bc)) == 0 && this.m_a9.t6(this.m_bb))
			{
				bi obj = new bi();
				fz a_ = this.m_bd;
				f1 a_2 = this.m_a9;
				Guid a_3 = this.m_bb;
				string A_2 = "ReflectanceStandardLabel";
				obj.a(a_, a_2, a_3, hu.a(ref A_2), ref c8);
				return;
			}
			bool enabled = r().Enabled;
			bool enabled2 = ag().Enabled;
			bool enabled3 = t().Enabled;
			bool a_4 = b4();
			bool enabled4 = au().Enabled;
			Cursor = Cursors.WaitCursor;
			ax().Value = 0;
			r().Enabled = false;
			ag().Enabled = false;
			t().Enabled = false;
			f(A_0: false);
			au().Enabled = false;
			if (c2)
			{
				bool flag = false;
				bool A_3 = default(bool);
				this.m_ba.i(A_0: false, A_1: true, flag, A_3: false, null, ref A_3, i6.a(ad()), this);
				if (A_3 && flag)
				{
					this.m_ba.i(A_0: false, A_1: true, A_2: false, A_3: false, null, ref A_3, i6.a(ad()), this);
				}
				if (!A_3)
				{
					Cursor = Cursors.Default;
					r().Enabled = enabled;
					ag().Enabled = enabled2;
					t().Enabled = enabled3;
					f(a_4);
					au().Enabled = enabled4;
					return;
				}
			}
			ax().Visible = true;
			ay().Visible = false;
			cw = 0;
			ao().Start();
			bool A_4 = default(bool);
			if (this.m_be == e6.c.f)
			{
				this.m_a9.m2(this.m_bb, "BK7", this.m_bc, global::r.d.a.b.a, ref A_4);
				if (A_4)
				{
					fz a_5 = this.m_bd;
					string A_2 = "BaselineErrBadRefMatFmt";
					fe.b(a_5, string.Format(hu.a(ref A_2), "BK7"), i6.a(ad()), base.TopMost);
				}
				else
				{
					f(A_0: false);
					this.m_a9.m2(this.m_bb, bu(), global::r.d.a.b.a, b2());
				}
				return;
			}
			string empty = string.Empty;
			empty = ((!float.TryParse(aa().Text, out var result)) ? aa().Text : result.ToString(CultureInfo.InvariantCulture));
			h h10 = null;
			if (this.m_bq == g2.a.b)
			{
				h10 = new h(this.m_a9.wq(this.m_bb).dh());
				this.m_br.a(ref h10);
				if (this.m_bi && this.m_bj)
				{
					h10.r(global::h.e.a);
				}
				else
				{
					h10.r(h10.a(this.m_bh));
				}
			}
			else
			{
				h10 = this.m_br;
			}
			this.m_a9.m2(this.m_bb, h10, empty, this.m_bc, global::r.d.a.b.a, ref A_4);
			if (A_4)
			{
				fz a_6 = this.m_bd;
				string A_2 = "BaselineErrBadRefMatFmt";
				fe.b(a_6, string.Format(hu.a(ref A_2), empty), i6.a(ad()), base.TopMost);
				p();
				b(ref this.m_be, ref this.m_b0, this.m_be);
			}
			else
			{
				bool a_7 = (this.m_br.n() ? true : false);
				f(A_0: false);
				this.m_a9.m2(this.m_bb, br(), bl, a_7, global::r.d.a.b.a, a(this.m_b0, this.m_a9.tc(this.m_bb, this.m_bc)), this.m_bc, b2(), i6.a(ad()), A_9: false);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			string A_2 = "ErrSettingMatSpecFmt1";
			string a_8 = string.Format(hu.a(ref A_2), aa().Text);
			this.m_bd.c(fz.b.b, a_8, ex3);
			p();
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(ad()), "DialogBaselineSetup.ButtonRefAcquire_Click", ex3);
			b(ref this.m_be, ref this.m_b0, this.m_be);
			ProjectData.ClearProjectError();
		}
	}

	private void j(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				r.d.b method = j;
				BeginInvoke(method, A_0);
				return;
			}
			try
			{
				ao().Stop();
				ax().Visible = false;
				ay().Visible = true;
				b(ref this.m_be, ref this.m_b0, this.m_be);
				if (A_0.a == global::r.d.a.a.a)
				{
					if (this.m_bq != g2.a.b)
					{
						bool A_1 = default(bool);
						a(ref A_1, A_1: true, b(this.m_b0), A_3: true, A_4: true);
						if (A_1)
						{
							return;
						}
					}
					bool A_2 = default(bool);
					a(A_0: true, A_1: false, ref A_2);
					Label label = ay();
					string A_3 = "BaselineStatusComplete";
					label.Text = hu.a(ref A_3);
					if (this.m_bf != e6.b.e && !A_2)
					{
						m(this, new EventArgs());
					}
					else
					{
						if (A_2)
						{
							r().Visible = true;
						}
						base.ActiveControl = r();
					}
					if (!string.IsNullOrEmpty(A_0.b))
					{
						ref fz a_ = ref this.m_bd;
						string a_2 = A_0.b;
						Point A_4 = i6.a(this);
						fe.b(ref a_, a_2, ref A_4, base.TopMost);
					}
				}
				else if (A_0 is r.g.a)
				{
					r.g.a a10 = (r.g.a)A_0;
					if (a10.j == global::r.g.a.a.a)
					{
						if (string.IsNullOrEmpty(((r.d.a)a10).b))
						{
							fz a_3 = this.m_bd;
							string A_3 = "ErrReferenceProc";
							fe.b(a_3, hu.a(ref A_3), i6.a(this), base.TopMost);
						}
						else
						{
							fe.b(this.m_bd, ((r.d.a)a10).b, i6.a(this), base.TopMost);
						}
					}
					else
					{
						fe.b(this.m_bd, a10.a6(), i6.a(this), base.TopMost);
					}
				}
				else
				{
					fz a_4 = this.m_bd;
					string A_3 = "ErrReferenceProc";
					fe.b(a_4, hu.a(ref A_3), i6.a(this), base.TopMost);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_5 = ex2;
				i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(ad()), "DialogBaselineSetup.MeasBaselineTakeReferenceFinishedHandler Loc #1", a_5);
				t().Enabled = this.m_b0 > 1;
				ProjectData.ClearProjectError();
			}
			finally
			{
				p();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception a_6 = ex3;
			t().Enabled = this.m_b0 > 1;
			p();
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(ad()), "DialogBaselineSetup.MeasBaselineTakeReferenceFinishedHandler Loc #2", a_6);
			ProjectData.ClearProjectError();
		}
	}

	private void a(ref c A_0, ref int A_1)
	{
		try
		{
			a6().SuspendLayout();
			a(au());
			t().Visible = false;
			r().Visible = n();
			r().Enabled = this.m_b3;
			Button button = r();
			string A_2 = "WizardNext";
			button.Text = hu.a(ref A_2);
			TabPage tabPage = au();
			string obj = a(A_1);
			A_2 = "BaselineAutoRefRefSpectrum";
			tabPage.Text = obj + ": " + hu.a(ref A_2);
			ab().Visible = false;
			aa().Visible = false;
			z().Visible = false;
			ag().Visible = false;
			c(A_0: false);
			A_0 = e6.c.f;
			a(A_0: true, A_0);
		}
		finally
		{
			a6().ResumeLayout();
			a6().Refresh();
		}
	}

	private void a(ref c A_0, int A_1)
	{
		try
		{
			a6().SuspendLayout();
			a(a0());
			TabPage tabPage = a0();
			string obj = a(A_1);
			string A_2 = "FiberTipSpectrum";
			tabPage.Text = obj + ": " + hu.a(ref A_2);
			t().Visible = this.m_bz > 2;
			t().Enabled = true;
			r().Enabled = this.m_b4;
			Button button = r();
			A_2 = "WizardFinish";
			button.Text = hu.a(ref A_2);
			ag().Visible = false;
			c(A_0: false);
			if (A_1 == 1)
			{
				t().Visible = false;
			}
			A_0 = e6.c.g;
			a(A_0, a(A_1));
		}
		finally
		{
			a6().ResumeLayout();
			a6().Refresh();
		}
	}

	private void a(bool A_0, bool A_1, ref bool A_2)
	{
		string A_3 = "";
		string A_4 = "";
		A_2 = false;
		bool A_5 = default(bool);
		this.m_a9.m2(this.m_bb, global::e.a().ReferenceMinIntenWRTHist * 0.01f, global::e.a().ReferenceMaxIntenWRTHist * 0.01f, A_0, A_1, a(this.m_b0, this.m_a9.tc(this.m_bb, this.m_bc)), this.m_bc, ref A_5, ref A_3, ref A_4);
		string text = null;
		if (!A_5)
		{
			string A_6 = "Reset";
			string arg = hu.a(ref A_6);
			if (A_3.Length > 1)
			{
				A_3 = A_3.Substring(0, 1).ToUpper() + A_3.Substring(1);
			}
			if (this.m_bq == g2.a.b)
			{
				A_6 = "ReferenceLowIntensityWarningClosedSystemFmt2";
				text = string.Format(hu.a(ref A_6), A_3, global::e.a().ReferenceMinIntenWRTHist.ToString());
			}
			else if (o())
			{
				A_6 = "ReferenceLowIntensityWarningClosedSystemCPFmt2";
				text = string.Format(hu.a(ref A_6), A_3, global::e.a().ReferenceMinIntenWRTHist.ToString());
			}
			else
			{
				A_6 = "ReferenceLowIntensityWarningFmt3";
				text = string.Format(hu.a(ref A_6), A_3, arg, global::e.a().ReferenceMinIntenWRTHist.ToString());
			}
			fz a_ = this.m_bd;
			string a_2 = text;
			A_6 = "ReferenceLowIntensityAddlTitle";
			string a_3 = hu.a(ref A_6);
			A_6 = "ReferenceResetButtonDescrip";
			bool A_7 = default(bool);
			fe.b(a_, a_2, a_3, hu.a(ref A_6), i6.a(this), ref A_7, base.TopMost);
			if (A_7)
			{
				this.m_a9.u4(this.m_bb);
			}
			A_2 = true;
		}
		else if (!string.IsNullOrEmpty(A_4))
		{
			A_4 = A_4.Substring(0, 1).ToUpper() + A_4.Substring(1);
			string A_6;
			if (this.m_bq == g2.a.b)
			{
				A_6 = "ReferenceHighIntensityWarningClosedSystemFmt";
				text = string.Format(hu.a(ref A_6), A_4);
			}
			else if (o())
			{
				A_6 = "ReferenceHighIntensityWarningClosedSystemCPFmt";
				text = string.Format(hu.a(ref A_6), A_4);
			}
			else
			{
				A_6 = "ReferenceHighIntensityWarningFmt";
				text = string.Format(hu.a(ref A_6), A_4);
			}
			ref fz a_4 = ref this.m_bd;
			string a_5 = text;
			A_6 = "ReferenceHighIntensityAddlTitle";
			string a_6 = hu.a(ref A_6);
			Point A_8 = i6.a(this);
			fe.b(ref a_4, a_5, a_6, ref A_8);
			A_2 = true;
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
		{
			Cursor = Cursors.WaitCursor;
			a4().Value = 0;
			a4().Visible = true;
			a3().Visible = false;
			cw = 0;
			ao().Start();
			r().Enabled = false;
			ag().Enabled = false;
			t().Enabled = false;
			f(A_0: false);
			a0().Enabled = false;
			if (this.m_be == e6.c.g)
			{
				f(A_0: false);
				this.m_a9.p9(this.m_bb, bv(), global::r.d.a.b.a, b2());
				return;
			}
			bool a_ = (this.m_br.n() ? true : false);
			if (this.m_b2 == this.m_b0 && (this.m_bz != this.m_b0 || cc))
			{
				this.m_a9.m2(this.m_bb, bs(), this.m_bo, a_, global::r.d.a.b.a, b2());
			}
			else
			{
				this.m_a9.p9(this.m_bb, bs(), this.m_bo, this.m_bc, global::r.d.a.b.a, b2());
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			d(this.m_b0 > 1);
			ag().Enabled = false;
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(ae()), "DialogBaselineSetup.ButtonAcquireDark_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void i(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				r.d.b method = i;
				BeginInvoke(method, A_0);
				return;
			}
			try
			{
				h(A_0);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(ae()), "DialogBaselineSetup.MeasBaselineTakeBackgroundFinishedHandler Loc#1", a_);
				base.ActiveControl = ae();
				ProjectData.ClearProjectError();
			}
			finally
			{
				t().Enabled = this.m_b0 > 1;
				a0().Enabled = true;
				f(A_0: true);
				Cursor = Cursors.Default;
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception a_2 = ex3;
			t().Enabled = this.m_b0 > 1;
			a0().Enabled = true;
			f(A_0: true);
			Cursor = Cursors.Default;
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(ae()), "DialogBaselineSetup.MeasBaselineTakeBackgroundFinishedHandler Loc#2", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void h(r.d.a A_0)
	{
		a4().Visible = false;
		a3().Visible = true;
		ao().Stop();
		if (A_0.a == global::r.d.a.a.a)
		{
			bool A_1 = default(bool);
			a(ref A_1, A_1: false, 0, this.m_b0 == this.m_b2, this.m_b0 != this.m_b2);
			bool num = !A_1;
			h.e e10 = default(h.e);
			if (this.m_bq == g2.a.c)
			{
				e10 = this.m_br.a(this.m_bh);
			}
			else if (this.m_bq == g2.a.b)
			{
				e10 = ((!this.m_bi || !this.m_bj) ? this.m_br.a(this.m_bh) : global::h.e.a);
			}
			bool A_2 = default(bool);
			if ((this.m_bq == g2.a.c || this.m_bq == g2.a.b) && this.m_b0 == this.m_b2 && e10 != global::h.e.c && e10 != global::h.e.d)
			{
				a(A_0: false, A_1: true, ref A_2);
			}
			if (num)
			{
				Label label = a3();
				string A_3 = "BaselineStatusComplete";
				label.Text = hu.a(ref A_3);
				r().Enabled = true;
				if ((this.m_b0 != this.m_bz || this.m_bz <= 2) && !A_2)
				{
					m(this, new EventArgs());
					return;
				}
				if (A_2)
				{
					r().Visible = true;
					if (this.m_bz > 2)
					{
						t().Visible = true;
					}
					if (this.m_b0 == this.m_bz)
					{
						Button button = r();
						A_3 = "WizardFinish";
						button.Text = hu.a(ref A_3);
					}
				}
				else
				{
					b(ref this.m_be, ref this.m_b0);
				}
				base.ActiveControl = r();
			}
			else
			{
				Label label2 = a3();
				string A_3 = "BaselineStatusIncomplete";
				label2.Text = hu.a(ref A_3);
				base.ActiveControl = ae();
			}
			return;
		}
		r.g.a a10 = (r.g.a)A_0;
		if (a10.j == global::r.g.a.a.a)
		{
			if (string.IsNullOrEmpty(((r.d.a)a10).b))
			{
				fz a_ = this.m_bd;
				string A_3 = "ErrBackgroundProc";
				fe.b(a_, hu.a(ref A_3), i6.a(this), base.TopMost);
			}
			else
			{
				fe.b(this.m_bd, ((r.d.a)a10).b, i6.a(this), base.TopMost);
			}
		}
		else
		{
			fe.b(this.m_bd, a10.a6(), i6.a(this), base.TopMost);
			if (a10.j == global::r.g.a.a.s)
			{
				l(this, new EventArgs());
			}
		}
	}

	private void a(ref bool A_0, bool A_1, int A_2, bool A_3, bool A_4)
	{
		A_0 = false;
		if (this.m_bf != e6.b.c)
		{
			return;
		}
		bool A_5 = false;
		string A_6 = string.Empty;
		this.m_a9.m2(this.m_bb, ref A_5, A_3, A_4, ref A_6);
		if (A_5)
		{
			fz a_ = this.m_bd;
			string A_7 = "BaselineRefBacTooSimilarFmt";
			fe.b(a_, string.Format(hu.a(ref A_7), A_6), i6.a(this), base.TopMost);
			A_0 = true;
			if (A_1)
			{
				this.m_a9.so(this.m_bb, A_2);
			}
			else
			{
				this.m_a9.wl(this.m_bb);
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			g(A_0: false);
			bool A_2 = default(bool);
			if (this.m_a9.m2(this.m_bb, this.m_bc, ref A_2))
			{
				base.DialogResult = DialogResult.OK;
			}
			else
			{
				c();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(ag()), "DialogBaselineSetup.ButtonRecoverBaseline_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d()
	{
		au().Text = a(this.m_b0) + au().Text.Substring(au().Text.IndexOf(":"));
		if (this.m_bx > 1)
		{
			am().Visible = true;
			string a_ = jb.a(new string[1] { aa().Text + ".fitdr" });
			string[] A_ = null;
			float A_2 = 0f;
			float A_3 = 0f;
			bool A_4 = default(bool);
			ex.e(a_, ref A_, ref A_2, ref A_3, ref A_4);
			int a_2 = (A_4 ? 1 : 0);
			Label label = am();
			string A_5 = "BaselineMultiRefLabelFmt";
			label.Text = string.Format(hu.a(ref A_5), A_[a(this.m_b0, a_2)]);
			ad().Left = 190;
		}
		else
		{
			am().Visible = false;
			ad().Left = aa().Left;
		}
	}

	public void g(bool A_0)
	{
		bool A_1 = default(bool);
		bool flag = this.m_a9.m2(this.m_bb, this.m_bc, ref A_1);
		if (!A_1 || flag)
		{
			return;
		}
		bool flag2;
		if (A_0)
		{
			flag2 = true;
		}
		else
		{
			string A_2 = "StoredBaselinePresentFmt1";
			string a_ = string.Format(hu.a(ref A_2), this.m_a9.st(this.m_bb, this.m_bc).ToString());
			if (c0)
			{
				A_2 = "StoredBackgroundPresentFmt1";
				a_ = string.Format(hu.a(ref A_2), this.m_a9.st(this.m_bb, this.m_bc).ToString());
			}
			fe fe2 = new fe(this.m_bd);
			fe.a a10 = new fe.a();
			a10.w(a_);
			a10.w(MsgBoxStyle.OkCancel);
			a10.x("Information");
			a10.y("Yes");
			a10.aa("No");
			a10.w(this);
			if (base.TopMost)
			{
				fe2.TopMost = true;
			}
			flag2 = fe2.b(a10) == DialogResult.OK;
		}
		if (flag2)
		{
			this.m_a9.m2(this.m_bb, global::r.d.a.b.a, this.m_bc);
		}
		else
		{
			A_1 = false;
		}
	}

	private void c()
	{
		bool A_ = default(bool);
		if (!this.m_a9.m2(this.m_bb, this.m_bc, ref A_) & A_ & (this.m_bf != e6.b.d))
		{
			ag().Visible = true;
			ag().Enabled = true;
			c(A_0: true);
		}
		else
		{
			ag().Visible = false;
			ag().Enabled = false;
			c(A_0: false);
		}
	}

	private void b(bool A_0)
	{
		an().Visible = false;
		y().Visible = true;
		ao().Stop();
		if (bk == fg.a.a)
		{
			w().Enabled = true;
			bl[0] = 0f;
			bl[1] = 0f;
			r().Enabled = this.m_a9.te(this.m_bb, this.m_bc);
			if (r().Enabled)
			{
				Label label = y();
				string A_1 = "BaselineStatusComplete";
				label.Text = hu.a(ref A_1);
			}
			else
			{
				Label label2 = y();
				string A_1 = "BaselineStatusIncomplete";
				label2.Text = hu.a(ref A_1);
			}
			return;
		}
		w().Enabled = false;
		switch (bk)
		{
		case fg.a.b:
		{
			Label label5 = y();
			string A_1 = "ReflOptionLastRefl";
			label5.Text = hu.a(ref A_1);
			bl[0] = 0f;
			bl[1] = 0f;
			break;
		}
		case fg.a.c:
		{
			Label label4 = y();
			string A_1 = "ReflOptionUserSupplied";
			label4.Text = hu.a(ref A_1);
			break;
		}
		case fg.a.d:
		{
			Label label3 = y();
			string A_1 = "ReflOptionUseRecipe";
			label3.Text = hu.a(ref A_1);
			bl[0] = 0f;
			bl[1] = 0f;
			break;
		}
		}
		if (A_0)
		{
			m(this, new EventArgs());
		}
		else
		{
			r().Enabled = true;
		}
	}

	private void b()
	{
		Cursor = Cursors.WaitCursor;
		r().Enabled = false;
		ag().Enabled = false;
		f(A_0: false);
		aq().Enabled = false;
	}

	private void a()
	{
		aq().Enabled = true;
		f(A_0: true);
		an().Visible = false;
		y().Visible = true;
		ao().Stop();
		Cursor = Cursors.Default;
	}

	private void a(bool A_0)
	{
		if (!c8 && A_0 && this.m_a9.t6(this.m_bb))
		{
			bi obj = new bi();
			fz a_ = this.m_bd;
			f1 a_2 = this.m_a9;
			Guid a_3 = this.m_bb;
			string A_1 = "SampleIdAbbrev";
			obj.a(a_, a_2, a_3, hu.a(ref A_1), ref c8);
		}
		else
		{
			an().Value = 0;
			an().Visible = true;
			y().Visible = false;
			cw = 0;
			ao().Start();
			b();
			k();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			c4 = new a(r().Enabled, ag().Enabled, b4(), aq().Enabled);
			if (!c8 && this.m_a9.t6(this.m_bb) && this.m_a9.t8(this.m_bb))
			{
				b();
				this.m_a9.p9(this.m_bb, null, b1(), global::r.d.a.b.a);
			}
			else
			{
				a(A_0: true);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(w()), "DialogBaselineSetup.ButtonAcquireRefl_Click", a_);
			a();
			ProjectData.ClearProjectError();
		}
	}

	private void g(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				r.d.b method = g;
				BeginInvoke(method, A_0);
			}
			else if (A_0.a == global::r.d.a.a.a)
			{
				k();
			}
			else
			{
				a();
				fe.b(this.m_bd, "Error during call to AcquireReflEmptyWaferMapFinishedHandler.", i6.a(this), base.TopMost);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			a();
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(w()), "DialogBaselineSetup.AcquireReflEmptyWaferMapFinishedHandler", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void f(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				r.d.b method = f;
				BeginInvoke(method, A_0);
			}
			else if (A_0.a == global::r.d.a.a.a)
			{
				j();
			}
			else
			{
				a();
				fe.b(this.m_bd, "Error during call to OverrideEmptyWaferMapFinishedHandler.", i6.a(this), base.TopMost);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			a();
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(w()), "DialogBaselineSetup.OverrideEmptyWaferMapFinishedHandler", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void e(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				r.d.b method = e;
				BeginInvoke(method, A_0);
				return;
			}
			try
			{
				if (this.m_bf == e6.b.c)
				{
					c();
				}
				b(A_0: true);
				if (A_0.a == global::r.d.a.a.a)
				{
					m(this, new EventArgs());
				}
				else if (A_0 is r.g.a)
				{
					r.g.a a10 = (r.g.a)A_0;
					if (a10.j == global::r.g.a.a.a)
					{
						if (string.IsNullOrEmpty(((r.d.a)a10).b))
						{
							fz a_ = this.m_bd;
							string A_1 = "ErrSampleSensitivityProc";
							fe.b(a_, hu.a(ref A_1), i6.a(this), base.TopMost);
						}
						else
						{
							fe.b(this.m_bd, ((r.d.a)a10).b, i6.a(this), base.TopMost);
						}
					}
					else
					{
						fe.b(this.m_bd, a10.a6(), i6.a(this), base.TopMost);
					}
				}
				else
				{
					fz a_2 = this.m_bd;
					string A_1 = "ErrSampleSensitivityProc";
					fe.b(a_2, hu.a(ref A_1), i6.a(this), base.TopMost);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(w()), "DialogBaselineSetup.MeasBaselineTakeSampleSensitivityFinishedHandler Loc #1", a_3);
				ProjectData.ClearProjectError();
			}
			finally
			{
				a();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception a_4 = ex3;
			a();
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(w()), "DialogBaselineSetup.MeasBaselineTakeSampleSensitivityFinishedHandler Loc #2", a_4);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		bq().Hide();
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			j();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(v()), "DialogBaselineSetup.ButtonOverride_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				r.d.b method = d;
				BeginInvoke(method, A_0);
				return;
			}
			if (A_0.a != global::r.d.a.a.a)
			{
				fe.b(this.m_bd, "Error attempting to commit pending baseline data", i6.a(this), base.TopMost);
				return;
			}
			if (global::e.a().SampleReflOption != (int)bk)
			{
				global::e.a().SampleReflOption = (int)bk;
			}
			if (global::e.a().UserSuppliedReflectance != (double)bl[0])
			{
				global::e.a().UserSuppliedReflectance = bl[0];
			}
			if (global::e.a().UserSuppliedReferenceAngle1 != (double)bl[1])
			{
				global::e.a().UserSuppliedReferenceAngle1 = bl[1];
			}
			base.DialogResult = DialogResult.OK;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(r()), "DialogBaselineSetup.SetupTaskFinishedHandler", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				r.d.b method = c;
				BeginInvoke(method, A_0);
			}
			else if (A_0.a != global::r.d.a.a.a)
			{
				fe.b(this.m_bd, "Error attempting to deallocate pending baseline data", i6.a(this));
			}
			else
			{
				base.DialogResult = DialogResult.Cancel;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(r()), "DialogBaselineSetup.CancelTaskFinishedHandler", a_);
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
				return;
			}
			if (A_0.a != global::r.d.a.a.a)
			{
				fe.b(this.m_bd, "Error attempting to deallocate pending baseline data", i6.a(this), base.TopMost);
			}
			b(A_0.a == global::r.d.a.a.a);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(r()), "DialogBaselineSetup.OverrideTaskFinishedHandler", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				r.d.b method = a;
				BeginInvoke(method, A_0);
			}
			else if (A_0.a != global::r.d.a.a.a)
			{
				fe.b(this.m_bd, "Error attempting to test source of illumination light", i6.a(this), base.TopMost);
				b(A_0: false);
			}
			else
			{
				a();
				a(Conversions.ToBoolean(A_0.d));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(r()), "DialogBaselineSetup.CheckLightFromInternalSourceFinishedHandler", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, LinkLabelLinkClickedEventArgs A_1)
	{
		try
		{
			fz a_ = this.m_bd;
			string A_2 = "BaselineLampWarmupDetails";
			fe.b(a_, hu.a(ref A_2), "Information", i6.a(ap()), base.TopMost);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(r()), "DialogBaselineSetup.LinkWarmupDetails_LinkClicked", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		try
		{
			if (this.m_bq == g2.a.b && this.m_a9.u1(this.m_bb) != global::ce.ErrPublic.None)
			{
				this.m_bd.c(fz.b.b, "Error in DialogBaselineSetup.RawSignal_ButtonClose_Click in call to StartAutoBaselineAcqRandT.");
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_bd, this.m_a9, this.m_ba, i6.a(r()), "DialogBaselineSetup.DialogBaselineSetup_FormClosing", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				float num = 0f;
				lock (ao())
				{
					if (cw > 0 && cx > 0)
					{
						float num2 = (float)(100.0 / (double)cw);
						float num3 = (float)DateAndTime.Now.Subtract(cz).TotalSeconds;
						num = num2 * (float)(cx - 1) + num2 * (1f - (float)Math.Exp(-Math.PI * (double)num3 / (double)cy));
					}
				}
				switch (this.m_be)
				{
				case e6.c.a:
					an().Value = (int)Math.Round(num);
					break;
				case e6.c.b:
				case e6.c.e:
				case e6.c.f:
					ax().Value = (int)Math.Round(num);
					break;
				case e6.c.c:
				case e6.c.d:
				case e6.c.g:
					a4().Value = (int)Math.Round(num);
					break;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				this.m_bd.c(fz.b.b, "Error encountered in DialogBaselineSetup.TimerBaselineProgress. Error is: " + ex3.Message);
				ProjectData.ClearProjectError();
			}
		}
	}
}
