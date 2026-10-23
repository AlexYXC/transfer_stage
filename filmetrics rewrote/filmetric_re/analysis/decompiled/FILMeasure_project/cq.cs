using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Filmetrics.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class cq : Form
{
	public enum a
	{
		a,
		b,
		c,
		d
	}

	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private Button m_e;

	[CompilerGenerated]
	private Panel m_f;

	[CompilerGenerated]
	private GroupBox m_g;

	[CompilerGenerated]
	private Label m_h;

	[CompilerGenerated]
	private Label m_i;

	[CompilerGenerated]
	private GroupBox m_j;

	[CompilerGenerated]
	private PictureBox m_k;

	[CompilerGenerated]
	private Button m_l;

	[CompilerGenerated]
	private Label m_m;

	[CompilerGenerated]
	private Panel m_n;

	[CompilerGenerated]
	private GroupBox m_o;

	[CompilerGenerated]
	private Label m_p;

	[CompilerGenerated]
	private Label m_q;

	[CompilerGenerated]
	private GroupBox m_r;

	[CompilerGenerated]
	private Label m_s;

	[CompilerGenerated]
	private PictureBox m_t;

	[CompilerGenerated]
	private Button m_u;

	[CompilerGenerated]
	private Label m_v;

	[CompilerGenerated]
	private Panel m_w;

	[CompilerGenerated]
	private GroupBox m_x;

	[CompilerGenerated]
	private Label m_y;

	[CompilerGenerated]
	private Label m_z;

	[CompilerGenerated]
	private GroupBox m_aa;

	[CompilerGenerated]
	private PictureBox m_ab;

	[CompilerGenerated]
	private Button m_ac;

	[CompilerGenerated]
	private Label m_ad;

	[CompilerGenerated]
	private TableLayoutPanel m_ae;

	[CompilerGenerated]
	private TableLayoutPanel m_af;

	[CompilerGenerated]
	private ProgressBar m_ag;

	[CompilerGenerated]
	private TableLayoutPanel m_ah;

	[CompilerGenerated]
	private TableLayoutPanel m_ai;

	[CompilerGenerated]
	private TableLayoutPanel m_aj;

	[CompilerGenerated]
	private TableLayoutPanel m_ak;

	[CompilerGenerated]
	private TableLayoutPanel m_al;

	[CompilerGenerated]
	private TableLayoutPanel m_am;

	[CompilerGenerated]
	private TableLayoutPanel m_an;

	[CompilerGenerated]
	private ProgressBar m_ao;

	[CompilerGenerated]
	private Timer m_ap;

	[CompilerGenerated]
	private Timer m_aq;

	private Guid m_ar;

	private a m_as;

	private f1 m_at;

	private f4 m_au;

	private h m_av;

	private bool m_aw;

	private int m_ax;

	private List<Panel> m_ay;

	private fz az;

	private bool a0;

	private bool a1;

	private bool a2;

	private bool a3;

	private bool a4;

	private bool a5;

	private bool a6;

	private int a7;

	private DateTime a8;

	private r.l a9;

	private r.c ba;

	private c1 bb;

	private c1 bc;

	private Point bd;

	private bool be;

	[CompilerGenerated]
	private r.d bf;

	[CompilerGenerated]
	private r.d bg;

	[CompilerGenerated]
	private r.d bh;

	[CompilerGenerated]
	private r.d bi;

	[CompilerGenerated]
	private r.d bj;

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
	private void d()
	{
		this.m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(cq));
		a(new Button());
		b(new Button());
		c(new Button());
		d(new Button());
		a(new Panel());
		a(new GroupBox());
		a(new TableLayoutPanel());
		b(new TableLayoutPanel());
		b(new Label());
		a(new Label());
		a(new ProgressBar());
		b(new GroupBox());
		a(new PictureBox());
		e(new Button());
		c(new Label());
		b(new Panel());
		c(new GroupBox());
		c(new TableLayoutPanel());
		d(new TableLayoutPanel());
		d(new Label());
		e(new Label());
		d(new GroupBox());
		f(new Label());
		b(new PictureBox());
		f(new Button());
		g(new Label());
		c(new Panel());
		e(new GroupBox());
		e(new TableLayoutPanel());
		f(new TableLayoutPanel());
		b(new ProgressBar());
		h(new Label());
		i(new Label());
		f(new GroupBox());
		c(new PictureBox());
		g(new Button());
		j(new Label());
		g(new TableLayoutPanel());
		h(new TableLayoutPanel());
		i(new TableLayoutPanel());
		a(new Timer(this.m_a));
		b(new Timer(this.m_a));
		i().SuspendLayout();
		j().SuspendLayout();
		ah().SuspendLayout();
		ai().SuspendLayout();
		m().SuspendLayout();
		((ISupportInitialize)n()).BeginInit();
		q().SuspendLayout();
		r().SuspendLayout();
		ak().SuspendLayout();
		al().SuspendLayout();
		u().SuspendLayout();
		((ISupportInitialize)w()).BeginInit();
		z().SuspendLayout();
		aa().SuspendLayout();
		am().SuspendLayout();
		an().SuspendLayout();
		ad().SuspendLayout();
		((ISupportInitialize)ae()).BeginInit();
		ao().SuspendLayout();
		ap().SuspendLayout();
		aq().SuspendLayout();
		SuspendLayout();
		componentResourceManager.ApplyResources(e(), "ButtonRecoverBaseline");
		e().Name = "ButtonRecoverBaseline";
		e().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(f(), "ButtonPrev");
		f().Name = "ButtonPrev";
		f().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(g(), "ButtonCancel");
		g().Cursor = Cursors.Default;
		g().DialogResult = DialogResult.Cancel;
		g().Name = "ButtonCancel";
		g().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(h(), "ButtonNext");
		h().Name = "ButtonNext";
		h().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(i(), "PanelBackground");
		i().Controls.Add(j());
		i().Name = "PanelBackground";
		j().Controls.Add(ah());
		j().Controls.Add(m());
		componentResourceManager.ApplyResources(j(), "GroupBoxBackgroundOuter");
		j().Name = "GroupBoxBackgroundOuter";
		j().TabStop = false;
		componentResourceManager.ApplyResources(ah(), "TableLayoutPanelBackStatus");
		ah().Controls.Add(ai(), 0, 0);
		ah().Name = "TableLayoutPanelBackStatus";
		componentResourceManager.ApplyResources(ai(), "TableLayoutPanel6");
		ai().Controls.Add(l(), 0, 0);
		ai().Controls.Add(k(), 1, 0);
		ai().Controls.Add(aj(), 2, 0);
		ai().Name = "TableLayoutPanel6";
		componentResourceManager.ApplyResources(l(), "LabelBackStatusLabel");
		l().Name = "LabelBackStatusLabel";
		componentResourceManager.ApplyResources(k(), "LabelBackStatus");
		k().BorderStyle = BorderStyle.Fixed3D;
		k().Name = "LabelBackStatus";
		componentResourceManager.ApplyResources(aj(), "ProgressBarBackground");
		aj().Name = "ProgressBarBackground";
		m().Controls.Add(n());
		m().Controls.Add(o());
		m().Controls.Add(p());
		componentResourceManager.ApplyResources(m(), "GroupBoxBackground");
		m().Name = "GroupBoxBackground";
		m().TabStop = false;
		n().Image = Resources.CTMBack;
		componentResourceManager.ApplyResources(n(), "PictureBoxBaselineBack");
		n().Name = "PictureBoxBaselineBack";
		n().TabStop = false;
		componentResourceManager.ApplyResources(o(), "ButtonAcquireBackground");
		o().Name = "ButtonAcquireBackground";
		o().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(p(), "LabelBackMessage");
		p().Name = "LabelBackMessage";
		componentResourceManager.ApplyResources(q(), "PanelPositionPeak");
		q().Controls.Add(r());
		q().Name = "PanelPositionPeak";
		r().Controls.Add(ak());
		r().Controls.Add(u());
		componentResourceManager.ApplyResources(r(), "GroupBoxPositionOuter");
		r().Name = "GroupBoxPositionOuter";
		r().TabStop = false;
		componentResourceManager.ApplyResources(ak(), "TableLayoutPanelPPStatus");
		ak().Controls.Add(al(), 0, 0);
		ak().Name = "TableLayoutPanelPPStatus";
		componentResourceManager.ApplyResources(al(), "TableLayoutPanel8");
		al().Controls.Add(s(), 1, 0);
		al().Controls.Add(t(), 0, 0);
		al().Name = "TableLayoutPanel8";
		componentResourceManager.ApplyResources(s(), "LabelPositionStatus");
		s().BorderStyle = BorderStyle.Fixed3D;
		s().Name = "LabelPositionStatus";
		componentResourceManager.ApplyResources(t(), "LabelPositionStatusLabel");
		t().Name = "LabelPositionStatusLabel";
		u().Controls.Add(v());
		u().Controls.Add(w());
		u().Controls.Add(x());
		u().Controls.Add(y());
		componentResourceManager.ApplyResources(u(), "GroupBoxPosition");
		u().Name = "GroupBoxPosition";
		u().TabStop = false;
		componentResourceManager.ApplyResources(v(), "Label3");
		v().BackColor = SystemColors.Window;
		v().Name = "Label3";
		w().Image = Resources.CTMBack;
		componentResourceManager.ApplyResources(w(), "PictureBoxBaselineCenterPeaks");
		w().Name = "PictureBoxBaselineCenterPeaks";
		w().TabStop = false;
		componentResourceManager.ApplyResources(x(), "ButtonPositionStartStopAcquire");
		x().Name = "ButtonPositionStartStopAcquire";
		x().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(y(), "LabelPositionMessage");
		y().Name = "LabelPositionMessage";
		componentResourceManager.ApplyResources(z(), "PanelReference");
		z().Controls.Add(aa());
		z().Name = "PanelReference";
		aa().Controls.Add(am());
		aa().Controls.Add(ad());
		componentResourceManager.ApplyResources(aa(), "GroupBoxReferenceOuter");
		aa().Name = "GroupBoxReferenceOuter";
		aa().TabStop = false;
		componentResourceManager.ApplyResources(am(), "TableLayoutPanelRefStatus");
		am().Controls.Add(an(), 0, 0);
		am().Name = "TableLayoutPanelRefStatus";
		componentResourceManager.ApplyResources(an(), "TableLayoutPanel10");
		an().Controls.Add(ar(), 2, 0);
		an().Controls.Add(ab(), 1, 0);
		an().Controls.Add(ac(), 0, 0);
		an().Name = "TableLayoutPanel10";
		componentResourceManager.ApplyResources(ar(), "ProgressBarReference");
		ar().Maximum = 25000;
		ar().Name = "ProgressBarReference";
		componentResourceManager.ApplyResources(ab(), "LabelRefStatus");
		ab().BorderStyle = BorderStyle.Fixed3D;
		ab().Name = "LabelRefStatus";
		componentResourceManager.ApplyResources(ac(), "LabelRefStatusLabel");
		ac().Name = "LabelRefStatusLabel";
		ad().Controls.Add(ae());
		ad().Controls.Add(af());
		ad().Controls.Add(ag());
		componentResourceManager.ApplyResources(ad(), "GroupBoxReference");
		ad().Name = "GroupBoxReference";
		ad().TabStop = false;
		ae().Image = Resources.CTMBack;
		componentResourceManager.ApplyResources(ae(), "PictureBoxBaselineRef");
		ae().Name = "PictureBoxBaselineRef";
		ae().TabStop = false;
		componentResourceManager.ApplyResources(af(), "ButtonAcquireReference");
		af().Name = "ButtonAcquireReference";
		af().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ag(), "LabelRefMessage");
		ag().Name = "LabelRefMessage";
		componentResourceManager.ApplyResources(ao(), "TableLayoutPanel1");
		ao().Controls.Add(ap(), 0, 3);
		ao().Controls.Add(z(), 0, 2);
		ao().Controls.Add(i(), 0, 0);
		ao().Controls.Add(q(), 0, 1);
		ao().Name = "TableLayoutPanel1";
		componentResourceManager.ApplyResources(ap(), "TableLayoutPanelControls");
		ap().Controls.Add(e(), 0, 0);
		ap().Controls.Add(aq(), 1, 0);
		ap().Controls.Add(g(), 2, 0);
		ap().Name = "TableLayoutPanelControls";
		componentResourceManager.ApplyResources(aq(), "TableLayoutPanel2");
		aq().Controls.Add(f(), 0, 0);
		aq().Controls.Add(h(), 1, 0);
		aq().Name = "TableLayoutPanel2";
		componentResourceManager.ApplyResources(this, "$this");
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = g();
		base.Controls.Add(ao());
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogCTMBaselineSetup";
		base.ShowInTaskbar = false;
		i().ResumeLayout(performLayout: false);
		j().ResumeLayout(performLayout: false);
		ah().ResumeLayout(performLayout: false);
		ah().PerformLayout();
		ai().ResumeLayout(performLayout: false);
		ai().PerformLayout();
		m().ResumeLayout(performLayout: false);
		m().PerformLayout();
		((ISupportInitialize)n()).EndInit();
		q().ResumeLayout(performLayout: false);
		r().ResumeLayout(performLayout: false);
		ak().ResumeLayout(performLayout: false);
		ak().PerformLayout();
		al().ResumeLayout(performLayout: false);
		al().PerformLayout();
		u().ResumeLayout(performLayout: false);
		u().PerformLayout();
		((ISupportInitialize)w()).EndInit();
		z().ResumeLayout(performLayout: false);
		aa().ResumeLayout(performLayout: false);
		am().ResumeLayout(performLayout: false);
		am().PerformLayout();
		an().ResumeLayout(performLayout: false);
		an().PerformLayout();
		ad().ResumeLayout(performLayout: false);
		((ISupportInitialize)ae()).EndInit();
		ao().ResumeLayout(performLayout: false);
		ao().PerformLayout();
		ap().ResumeLayout(performLayout: false);
		aq().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button e()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = c;
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
	internal virtual Button f()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = g;
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
	internal virtual Button g()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button h()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Button A_0)
	{
		EventHandler value = h;
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
	internal virtual Panel i()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Panel A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox j()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(GroupBox A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label k()
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
	internal virtual Label l()
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
	internal virtual GroupBox m()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(GroupBox A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox n()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(PictureBox A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button o()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Button A_0)
	{
		EventHandler value = e;
		Button button = this.m_l;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_l = A_0;
		button = this.m_l;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label p()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel q()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Panel A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox r()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(GroupBox A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label s()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label t()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox u()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(GroupBox A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label v()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox w()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(PictureBox A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button x()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Button A_0)
	{
		EventHandler value = f;
		Button button = this.m_u;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_u = A_0;
		button = this.m_u;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label y()
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
	internal virtual Panel z()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Panel A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox aa()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(GroupBox A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ab()
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
	internal virtual Label ac()
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
	internal virtual GroupBox ad()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(GroupBox A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox ae()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(PictureBox A_0)
	{
		this.m_ab = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button af()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Button A_0)
	{
		EventHandler value = d;
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
	internal virtual Label ag()
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
	internal virtual TableLayoutPanel ah()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_ae = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ai()
	{
		return this.m_af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_af = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ProgressBar aj()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ProgressBar A_0)
	{
		this.m_ag = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ak()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
	{
		this.m_ah = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel al()
	{
		return this.m_ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TableLayoutPanel A_0)
	{
		this.m_ai = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel am()
	{
		return this.m_aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TableLayoutPanel A_0)
	{
		this.m_aj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel an()
	{
		return this.m_ak;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(TableLayoutPanel A_0)
	{
		this.m_ak = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ao()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(TableLayoutPanel A_0)
	{
		this.m_al = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ap()
	{
		return this.m_am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(TableLayoutPanel A_0)
	{
		this.m_am = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel aq()
	{
		return this.m_an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TableLayoutPanel A_0)
	{
		this.m_an = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ProgressBar ar()
	{
		return this.m_ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ProgressBar A_0)
	{
		this.m_ao = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer @as()
	{
		return this.m_ap;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Timer A_0)
	{
		EventHandler value = b;
		Timer timer = this.m_ap;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		this.m_ap = A_0;
		timer = this.m_ap;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer at()
	{
		return this.m_aq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Timer A_0)
	{
		EventHandler value = a;
		Timer timer = this.m_aq;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		this.m_aq = A_0;
		timer = this.m_aq;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d au()
	{
		return bf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		r.d.b a_ = d;
		bf?.e(a_);
		bf = A_0;
		bf?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d av()
	{
		return bg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void b(r.d A_0)
	{
		r.d.b a_ = c;
		bg?.e(a_);
		bg = A_0;
		bg?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d aw()
	{
		return bh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void c(r.d A_0)
	{
		r.d.b a_ = b;
		bh?.e(a_);
		bh = A_0;
		bh?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d ax()
	{
		return bi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void d(r.d A_0)
	{
		r.d.b a_ = a;
		bi?.e(a_);
		bi = A_0;
		bi?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d ay()
	{
		return bj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void e(r.d A_0)
	{
		bj = A_0;
	}

	public cq(fz A_0)
	{
		base.FormClosing += a;
		e(new r.d());
		d();
		az = A_0;
		a9 = new r.l();
		a1 = false;
		a0 = false;
		a2 = false;
		a3 = false;
		a4 = false;
		a5 = false;
		a6 = false;
		ba = new r.c();
		a(new r.d());
		b(new r.d());
		c(new r.d());
		d(new r.d());
	}

	public void a(a A_0, f1 A_1, f4 A_2, Guid A_3, Point A_4)
	{
		this.m_ar = A_3;
		this.m_as = A_0;
		this.m_at = A_1;
		this.m_au = A_2;
		bd = A_4;
		hg hg2 = this.m_at.wq(this.m_ar);
		this.m_av = hg2.b8();
		this.m_at.ub(this.m_ar);
		int num = this.m_at.m2(this.m_ar, global::h.f.a);
		bool a_ = this.m_at.uo(this.m_ar)[num];
		if (this.m_at.un(this.m_ar)[0] > 1 && (this.m_av.a(0).b(a_) == global::f.a.a || this.m_av.a(0).b(a_) == global::f.a.d))
		{
			a7 = 2;
		}
		else
		{
			a7 = 1;
		}
		b();
		this.m_ax = 0;
		this.m_ay = new List<Panel>();
		switch (A_0)
		{
		case cq.a.b:
		{
			this.m_ay.Add(i());
			GroupBox groupBox5 = j();
			string A_5 = "BaselineSetupSteps";
			groupBox5.Text = string.Format(hu.a(ref A_5), 1, 1);
			Label label5 = p();
			A_5 = "BaselineCTMBackgroundLabel";
			label5.Text = hu.a(ref A_5);
			Button button = o();
			A_5 = "BaselineCTMAcquireBackground";
			button.Text = hu.a(ref A_5);
			GroupBox groupBox6 = m();
			A_5 = "BaselineCTMAcquireBackground";
			groupBox6.Text = hu.a(ref A_5);
			Button button2 = e();
			A_5 = "RecoverLastBaseline";
			button2.Text = hu.a(ref A_5);
			Button button3 = g();
			A_5 = "CancelString";
			button3.Text = hu.a(ref A_5);
			Label label6 = l();
			A_5 = "Status";
			label6.Text = hu.a(ref A_5);
			break;
		}
		case cq.a.a:
		{
			this.m_ay.Add(z());
			GroupBox groupBox4 = aa();
			string A_5 = "BaselineSetupSteps";
			groupBox4.Text = string.Format(hu.a(ref A_5), 1, 1);
			Label label4 = ag();
			A_5 = "BaselineCTMReferenceLabel";
			label4.Text = hu.a(ref A_5);
			break;
		}
		case cq.a.c:
		{
			this.m_ay.Add(q());
			GroupBox groupBox3 = r();
			string A_5 = "BaselineSetupSteps";
			groupBox3.Text = string.Format(hu.a(ref A_5), 1, 1);
			Label label3 = y();
			A_5 = "BaselineCTMPositionLabel";
			label3.Text = hu.a(ref A_5);
			break;
		}
		case cq.a.d:
		{
			GroupBox groupBox = aa();
			string A_5 = "BaselineSetupSteps";
			groupBox.Text = string.Format(hu.a(ref A_5), 1, 2);
			GroupBox groupBox2 = j();
			A_5 = "BaselineSetupSteps";
			groupBox2.Text = string.Format(hu.a(ref A_5), 2, 2);
			this.m_ay.Add(z());
			this.m_ay.Add(i());
			Label label = ag();
			A_5 = "BaselineCTMReferenceLabel";
			label.Text = hu.a(ref A_5);
			Label label2 = p();
			A_5 = "BaselineCTMReferenceDarkLabel";
			label2.Text = hu.a(ref A_5);
			break;
		}
		}
		ba.t(b);
		ba.v(a);
		ba.t((r.c.b)a);
		a(this.m_ax);
		ShowDialog();
	}

	private void a(int A_0)
	{
		foreach (Panel item in this.m_ay)
		{
			item.Visible = false;
		}
		this.m_ay[A_0].Visible = true;
		a4 = false;
		checked
		{
			f().Enabled = A_0 > 0 && A_0 < this.m_ay.Count - 1;
			bool flag = true;
			if (flag == (this.m_ay[A_0] == z()))
			{
				if (this.m_ax == this.m_ay.Count - 1)
				{
					Button button = h();
					string A_1 = "WizardFinish";
					button.Text = hu.a(ref A_1);
					a6 = true;
				}
				else
				{
					Button button2 = h();
					string A_1 = "WizardNext";
					button2.Text = hu.a(ref A_1);
					a6 = false;
				}
				base.ActiveControl = af();
				h().Enabled = this.m_at.m2(this.m_ar, 0, "0", A_3: false) || a3;
				if (h().Enabled)
				{
					Label label = k();
					string A_1 = "BaselineStatusComplete";
					label.Text = hu.a(ref A_1);
				}
				else
				{
					Label label2 = k();
					string A_1 = "BaselineStatusIncomplete";
					label2.Text = hu.a(ref A_1);
				}
			}
			else if (flag == (this.m_ay[A_0] == i()))
			{
				a6 = true;
				base.ActiveControl = o();
				if (this.m_ax == this.m_ay.Count - 1)
				{
					Button button3 = h();
					string A_1 = "WizardFinish";
					button3.Text = hu.a(ref A_1);
				}
				else
				{
					Button button4 = h();
					string A_1 = "WizardNext";
					button4.Text = hu.a(ref A_1);
				}
				if (this.m_ay.Count > 0)
				{
					h().Enabled = false;
				}
				else
				{
					h().Enabled = this.m_at.td(this.m_ar, A_1: false) || a2;
				}
				if (h().Enabled)
				{
					Label label3 = k();
					string A_1 = "BaselineStatusComplete";
					label3.Text = hu.a(ref A_1);
				}
				else
				{
					Label label4 = k();
					string A_1 = "BaselineStatusIncomplete";
					label4.Text = hu.a(ref A_1);
				}
			}
			else if (flag == (this.m_ay[A_0] == q()))
			{
				a6 = false;
				Button button5 = h();
				string A_1 = "WizardFinish";
				button5.Text = hu.a(ref A_1);
				base.ActiveControl = x();
				if (a5)
				{
					h().Enabled = true;
					Label label5 = s();
					A_1 = "BaselineStatusComplete";
					label5.Text = hu.a(ref A_1);
				}
				else
				{
					h().Enabled = false;
					Label label6 = s();
					A_1 = "BaselineStatusIncomplete";
					label6.Text = hu.a(ref A_1);
				}
			}
			if (this.m_as != cq.a.b)
			{
				e().Visible = false;
				return;
			}
			e().Visible = true;
			b();
		}
	}

	private void a(ref bool A_0, bool A_1, int A_2, bool A_3, bool A_4)
	{
		A_0 = false;
		if (this.m_as != cq.a.d)
		{
			return;
		}
		bool A_5 = false;
		string A_6 = string.Empty;
		this.m_at.m2(this.m_ar, ref A_5, A_3, A_4, ref A_6);
		if (A_5)
		{
			fz a_ = az;
			string A_7 = "BaselineRefBacTooSimilarFmt";
			fe.b(a_, string.Format(hu.a(ref A_7), A_6), i6.a(this), base.TopMost);
			A_0 = true;
			if (A_1)
			{
				this.m_at.so(this.m_ar, A_2);
			}
			else
			{
				this.m_at.wl(this.m_ar);
			}
		}
	}

	private void c()
	{
		hg hg2 = this.m_at.wq(this.m_ar);
		bool flag = false;
		if (this.m_as != cq.a.c)
		{
			h obj = hg2.b8();
			string text = this.m_at.m2(this.m_ar, global::h.f.a, A_2: false);
			g g10 = obj.a(global::h.g.a);
			if (Operators.CompareString(g10.c(), text, TextCompare: false) != 0 || !g10.d())
			{
				g10.c(text);
				g10.c(A_0: true);
				flag = true;
			}
			g10 = null;
			_ = null;
			if (flag)
			{
				hg2.cj(hg2.cm());
			}
		}
		if (this.m_ay[this.m_ax] == i())
		{
			g().Enabled = false;
			base.ControlBox = false;
			h().Enabled = false;
			f().Enabled = false;
			o().Enabled = false;
			e().Enabled = false;
			Cursor = Cursors.WaitCursor;
		}
		this.m_at.m2(this.m_ar, A_1: true, A_2: true, aw(), A_4: false, global::r.d.a.b.a);
	}

	private void b()
	{
		e().Visible = true;
		bool A_ = default(bool);
		if (!this.m_at.m2(this.m_ar, A_1: false, ref A_) & A_)
		{
			e().Enabled = true;
		}
		else
		{
			e().Enabled = false;
		}
	}

	public void a(bool A_0)
	{
		bool A_1 = default(bool);
		bool flag = this.m_at.m2(this.m_ar, A_1: false, ref A_1);
		if (A_1 && !flag)
		{
			bool flag2;
			if (A_0)
			{
				flag2 = true;
			}
			else
			{
				fe obj = new fe(az);
				fe.a a10 = new fe.a();
				string A_2 = "StoredBaselinePresentFmt1";
				a10.w(string.Format(hu.a(ref A_2), this.m_at.st(this.m_ar, A_1: false).ToString()));
				a10.w(MsgBoxStyle.OkCancel);
				a10.x("Information");
				a10.y("Yes");
				a10.aa("No");
				a10.w(this);
				flag2 = obj.b(a10) == DialogResult.OK;
			}
			if (flag2)
			{
				this.m_at.m2(this.m_ar, global::r.d.a.b.a, A_2: false);
			}
			else
			{
				A_1 = false;
			}
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
			try
			{
				Cursor = Cursors.Default;
				aj().Visible = false;
				k().Visible = true;
				at().Stop();
				Button button = o();
				string A_1 = "BaselineCTMAcquireBackground";
				button.Text = hu.a(ref A_1);
				if (A_0.a != global::r.d.a.a.a)
				{
					r.g.a a10 = (r.g.a)A_0;
					if (a10.j == global::r.g.a.a.a)
					{
						fz a_ = az;
						A_1 = "ErrBackgroundProc";
						fe.b(a_, hu.a(ref A_1), i6.a(this));
					}
					else
					{
						string a_2 = a10.a6();
						fe.b(az, a_2, i6.a(this));
						_ = null;
					}
				}
				if (ba != null && ba.a)
				{
					ba.a = false;
				}
				o().Enabled = true;
				if (this.m_at.td(this.m_ar, A_1: false))
				{
					if (this.m_as == cq.a.d)
					{
						bool A_2 = default(bool);
						a(ref A_2, A_1: false, 0, A_3: true, A_4: false);
						if (!A_2)
						{
							Label label = k();
							A_1 = "BaselineStatusComplete";
							label.Text = hu.a(ref A_1);
							h().Enabled = true;
							base.ActiveControl = h();
							this.m_at.wl(this.m_ar);
						}
						else
						{
							Label label2 = k();
							A_1 = "BaselineStatusIncomplete";
							label2.Text = hu.a(ref A_1);
							h().Enabled = false;
						}
					}
					else
					{
						Label label3 = k();
						A_1 = "BaselineStatusComplete";
						label3.Text = hu.a(ref A_1);
						base.ActiveControl = h();
						h().Enabled = true;
					}
				}
				else
				{
					Label label4 = k();
					A_1 = "BaselineStatusIncomplete";
					label4.Text = hu.a(ref A_1);
					h().Enabled = false;
				}
				a0 = false;
				f().Enabled = this.m_ax > 0 && this.m_ax < checked(this.m_ay.Count - 1);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				i5.a(az, this.m_at, this.m_au, i6.a(o()), "DialogBaselineSetup.MeasBaselineTakeBackgroundFinishedHandler Loc#1", a_3);
				base.ActiveControl = o();
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception a_4 = ex3;
			i5.a(az, this.m_at, this.m_au, i6.a(o()), "DialogBaselineSetup.MeasBaselineTakeBackgroundFinishedHandler Loc#2", a_4);
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
				return;
			}
			try
			{
				Cursor = Cursors.Default;
				g().Enabled = true;
				base.ControlBox = true;
				@as().Stop();
				ar().Visible = false;
				ab().Visible = true;
				af().Enabled = true;
				if (A_0.a != global::r.d.a.a.a)
				{
					r.g.a a10 = (r.g.a)A_0;
					if (a10.j == global::r.g.a.a.a)
					{
						fz a_ = az;
						string A_1 = "ErrReferenceProc";
						fe.b(a_, hu.a(ref A_1), i6.a(this));
					}
					else
					{
						string a_2 = a10.a6();
						fe.b(az, a_2, i6.a(this));
						_ = null;
					}
				}
				if (this.m_at.m2(this.m_ar, 0, "0", A_3: false))
				{
					Label label = ab();
					string A_1 = "BaselineStatusComplete";
					label.Text = hu.a(ref A_1);
					h().Enabled = true;
					base.ActiveControl = h();
					f().Enabled = this.m_ax > 0 && this.m_ax < checked(this.m_ay.Count - 1);
				}
				else
				{
					Label label2 = ab();
					string A_1 = "BaselineStatusIncomplete";
					label2.Text = hu.a(ref A_1);
					h().Enabled = false;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				i5.a(az, this.m_at, this.m_au, i6.a(o()), "DialogBaselineSetup.MeasBaselineTakeReferenceFinishedHandler Loc#1", a_3);
				base.ActiveControl = af();
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception a_4 = ex3;
			i5.a(az, this.m_at, this.m_au, i6.a(o()), "DialogBaselineSetup.MeasBaselineTakeReferenceFinishedHandler Loc#2", a_4);
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
				fe.b(az, "Error attempting to commit pending baseline data", i6.a(this));
				return;
			}
			if (this.m_ay[this.m_ax] == i())
			{
				Cursor = Cursors.Default;
				g().Enabled = true;
				base.ControlBox = true;
				o().Enabled = true;
			}
			a4 = true;
			a2 = true;
			h().Enabled = true;
			h(this, new EventArgs());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(az, this.m_at, this.m_au, i6.a(h()), "DialogCTMBaselineSetup.SetupTaskFinishedHandler", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (a6 && !a4)
				{
					string left = h().Text;
					string A_2 = "WizardFinish";
					if (Operators.CompareString(left, hu.a(ref A_2), TextCompare: false) != 0)
					{
						string left2 = h().Text;
						A_2 = "WizardNext";
						if (Operators.CompareString(left2, hu.a(ref A_2), TextCompare: false) != 0 || this.m_ax != this.m_ay.Count - 2 || this.m_ay[this.m_ax] != i())
						{
							goto IL_0086;
						}
					}
					c();
					return;
				}
				goto IL_0086;
				IL_0086:
				this.m_ax++;
				if (this.m_ax < this.m_ay.Count)
				{
					a(this.m_ax);
					return;
				}
				base.DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(az, this.m_at, this.m_au, i6.a(h()), "DialogCTMBaselineSetup.ButtonNext_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				this.m_ax--;
				a(this.m_ax);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(az, this.m_at, this.m_au, i6.a(f()), "DialogCTMBaselineSetup.ButtonPrev_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_au.i(A_0: false, A_1: false, h6.b.b);
			if (!a1)
			{
				Button button = x();
				string A_2 = "BaselineCTMStopAcquire";
				button.Text = hu.a(ref A_2);
				h().Enabled = false;
				a1 = true;
			}
			else
			{
				Button button2 = x();
				string A_2 = "BaselineCTMStartAcquire";
				button2.Text = hu.a(ref A_2);
				h().Enabled = true;
				a1 = false;
				a5 = true;
				Label label = s();
				A_2 = "BaselineStatusComplete";
				label.Text = hu.a(ref A_2);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(fz.b.b, "Exception in ButtonPositionStartStopAcquire_Click(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		bool flag = false;
		try
		{
			bool flag2 = false;
			if (this.m_at.m2(this.m_ar, 0, "0", A_3: false))
			{
				flag = true;
			}
			h().Enabled = false;
			f().Enabled = false;
			Cursor = Cursors.WaitCursor;
			if (this.m_av.n(this.m_at.sm(this.m_ar)) == global::h.MeasurementTimingType.Manual || flag)
			{
				if (flag)
				{
					aj().Value = 0;
					aj().Maximum = 25000;
					aj().Visible = true;
					k().Visible = false;
					a8 = DateAndTime.Now;
					at().Start();
				}
				o().Enabled = false;
			}
			else
			{
				o().Enabled = true;
				if (a0)
				{
					flag2 = true;
					ba.a = true;
					o().Enabled = false;
				}
				else
				{
					aj().Value = 0;
					aj().Maximum = 100;
					ba.a = false;
					Button button = o();
					string A_2 = "BaselineCTMCancelAcquire";
					button.Text = hu.a(ref A_2);
					a0 = true;
				}
			}
			if (!flag2)
			{
				this.m_at.m2(this.m_ar, au(), A_2: true, global::r.d.a.b.a, !flag, ba);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(az, this.m_at, this.m_au, i6.a(f()), "DialogCTMBaselineSetup.ButtonAcquireBackground_Click", a_);
			Cursor = Cursors.Default;
			o().Enabled = true;
			ba.a = true;
			if (flag)
			{
				aj().Visible = false;
				k().Visible = true;
				at().Stop();
			}
			Button button2 = o();
			string A_2 = "BaselineCTMAcquireBackground";
			button2.Text = hu.a(ref A_2);
			a0 = false;
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			g().Enabled = false;
			base.ControlBox = false;
			ar().Visible = true;
			ab().Visible = false;
			ar().Value = 0;
			@as().Start();
			h().Enabled = false;
			f().Enabled = false;
			af().Enabled = false;
			e().Enabled = false;
			Cursor = Cursors.WaitCursor;
			bool A_2 = default(bool);
			this.m_at.m2(this.m_ar, "0", A_2: false, global::r.d.a.b.a, ref A_2);
			a8 = DateAndTime.Now;
			this.m_at.m2(this.m_ar, av(), 0.0, A_3: true, global::r.d.a.b.a, 0);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(az, this.m_at, this.m_au, i6.a(f()), "DialogCTMBaselineSetup.ButtonAcquireBackground_Click", a_);
			Cursor = Cursors.Default;
			g().Enabled = true;
			base.ControlBox = true;
			@as().Stop();
			ar().Visible = false;
			ab().Visible = true;
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
				fe.b(az, "Error attempting to deallocate pending baseline data", i6.a(this));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(az, this.m_at, this.m_au, i6.a(h()), "DialogCTMBaselineSetup.DeallocatePendingDataTaskComplHandler", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			a(A_0: false);
			bool A_2 = default(bool);
			if (this.m_at.m2(this.m_ar, A_1: false, ref A_2))
			{
				base.DialogResult = DialogResult.OK;
			}
			else
			{
				b();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(az, this.m_at, this.m_au, i6.a(e()), "DialogCTMBaselineSetup.ButtonRecoverBaseline_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(r.c A_0)
	{
		if (base.InvokeRequired)
		{
			BeginInvoke(new r.c.a(b), A_0);
			return;
		}
		try
		{
			aj().Visible = true;
			k().Visible = false;
			Refresh();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(fz.b.b, "Exception in AcquireProcessStarting(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.c A_0, bool A_1)
	{
		if (base.InvokeRequired)
		{
			BeginInvoke(new r.c.b(a), A_0, A_1);
			return;
		}
		try
		{
			aj().Value = checked((int)Math.Round(A_0.t()));
			Refresh();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(fz.b.b, "Exception in AcquireProcessStatusChanged(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.c A_0)
	{
		if (base.InvokeRequired)
		{
			BeginInvoke(new r.c.a(a), A_0);
			return;
		}
		try
		{
			aj().Visible = false;
			k().Visible = true;
			Refresh();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			az.c(fz.b.b, "Exception in AcquireProcessFinished(). ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		if (a1)
		{
			a9.q(A_0: true);
		}
		else if (a0)
		{
			ba.a = true;
		}
		this.m_at.m2(this.m_ar, A_1: false, ax(), global::r.d.a.b.a);
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			double num = DateAndTime.Now.Subtract(a8).TotalMilliseconds / (double)a7;
			if (num < (double)ar().Maximum)
			{
				ar().Value = checked((int)Math.Round(num));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			double num = DateAndTime.Now.Subtract(a8).TotalMilliseconds / (double)a7;
			if (num < (double)aj().Maximum)
			{
				aj().Value = checked((int)Math.Round(num));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	private void a(bool A_0, string A_1, string A_2)
	{
	}

	private void a()
	{
	}
}
