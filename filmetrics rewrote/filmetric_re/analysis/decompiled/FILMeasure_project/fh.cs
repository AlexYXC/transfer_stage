using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class fh : Form
{
	public enum a : short
	{
		a,
		b
	}

	public enum b
	{
		a,
		b,
		c
	}

	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private GroupBox m_d;

	[CompilerGenerated]
	private Label m_e;

	[CompilerGenerated]
	private hy m_f;

	[CompilerGenerated]
	private GroupBox m_g;

	[CompilerGenerated]
	private RadioButton m_h;

	[CompilerGenerated]
	private RadioButton m_i;

	[CompilerGenerated]
	private RadioButton m_j;

	[CompilerGenerated]
	private hy m_k;

	[CompilerGenerated]
	private CheckBox m_l;

	[CompilerGenerated]
	private GroupBox m_m;

	[CompilerGenerated]
	private RadioButton m_n;

	[CompilerGenerated]
	private RadioButton m_o;

	[CompilerGenerated]
	private RadioButton m_p;

	[CompilerGenerated]
	private RadioButton m_q;

	[CompilerGenerated]
	private GroupBox m_r;

	[CompilerGenerated]
	private RadioButton m_s;

	[CompilerGenerated]
	private RadioButton m_t;

	[CompilerGenerated]
	private GroupBox m_u;

	[CompilerGenerated]
	private ComboBox m_v;

	[CompilerGenerated]
	private GroupBox m_w;

	[CompilerGenerated]
	private GroupBox m_x;

	[CompilerGenerated]
	private ComboBox m_y;

	[CompilerGenerated]
	private Label m_z;

	[CompilerGenerated]
	private CheckBox m_aa;

	[CompilerGenerated]
	private TableLayoutPanel m_ab;

	[CompilerGenerated]
	private TableLayoutPanel m_ac;

	[CompilerGenerated]
	private CheckBox m_ad;

	[CompilerGenerated]
	private GroupBox m_ae;

	[CompilerGenerated]
	private CheckBox m_af;

	[CompilerGenerated]
	private CheckBox m_ag;

	[CompilerGenerated]
	private CheckBox m_ah;

	[CompilerGenerated]
	private CheckBox m_ai;

	[CompilerGenerated]
	private CheckBox m_aj;

	[CompilerGenerated]
	private CheckBox m_ak;

	[CompilerGenerated]
	private GroupBox m_al;

	[CompilerGenerated]
	private ComboBox m_am;

	[CompilerGenerated]
	private ToolTip m_an;

	[CompilerGenerated]
	private CheckBox m_ao;

	[CompilerGenerated]
	private CheckBox m_ap;

	[CompilerGenerated]
	private Button m_aq;

	[CompilerGenerated]
	private GroupBox m_ar;

	[CompilerGenerated]
	private CheckBox m_as;

	[CompilerGenerated]
	private Label m_at;

	[CompilerGenerated]
	private Label m_au;

	[CompilerGenerated]
	private hy m_av;

	[CompilerGenerated]
	private hy m_aw;

	[CompilerGenerated]
	private Label m_ax;

	[CompilerGenerated]
	private Label m_ay;

	[CompilerGenerated]
	private CheckBox m_az;

	private bool m_a0;

	private bool m_a1;

	private a4.a m_a2;

	private bool m_a3;

	private fm m_a4;

	private fz m_a5;

	private f1 m_a6;

	private bool m_a7;

	private float a8;

	private bool a9;

	private float ba;

	private float bb;

	private int bc;

	private bool bd;

	public const float be = 10f;

	private const string bf = "DialogSetupDisplay";

	public fh()
	{
		base.Load += f;
		i();
	}

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
	private void i()
	{
		this.m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fh));
		a(new Button());
		b(new Button());
		a(new GroupBox());
		k(new CheckBox());
		a(new hy());
		a(new Label());
		b(new GroupBox());
		j(new GroupBox());
		e(new Label());
		f(new Label());
		c(new hy());
		d(new hy());
		c(new Label());
		d(new Label());
		l(new CheckBox());
		c(new Button());
		f(new GroupBox());
		b(new CheckBox());
		g(new RadioButton());
		c(new RadioButton());
		b(new RadioButton());
		a(new RadioButton());
		f(new RadioButton());
		e(new GroupBox());
		a(new ComboBox());
		b(new hy());
		d(new GroupBox());
		h(new RadioButton());
		i(new RadioButton());
		a(new CheckBox());
		c(new GroupBox());
		c(new CheckBox());
		d(new RadioButton());
		e(new RadioButton());
		g(new GroupBox());
		b(new ComboBox());
		b(new Label());
		a(new TableLayoutPanel());
		i(new GroupBox());
		c(new ComboBox());
		b(new TableLayoutPanel());
		h(new GroupBox());
		m(new CheckBox());
		j(new CheckBox());
		e(new CheckBox());
		f(new CheckBox());
		g(new CheckBox());
		h(new CheckBox());
		i(new CheckBox());
		d(new CheckBox());
		a(new ToolTip(this.m_a));
		l().SuspendLayout();
		o().SuspendLayout();
		az().SuspendLayout();
		ae().SuspendLayout();
		ac().SuspendLayout();
		z().SuspendLayout();
		u().SuspendLayout();
		af().SuspendLayout();
		aj().SuspendLayout();
		at().SuspendLayout();
		ak().SuspendLayout();
		am().SuspendLayout();
		SuspendLayout();
		componentResourceManager.ApplyResources(j(), "ButtonOK");
		j().Name = "ButtonOK";
		av().SetToolTip(j(), componentResourceManager.GetString("ButtonOK.ToolTip"));
		j().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(k(), "ButtonCancel");
		k().DialogResult = DialogResult.Cancel;
		k().Name = "ButtonCancel";
		av().SetToolTip(k(), componentResourceManager.GetString("ButtonCancel.ToolTip"));
		k().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(l(), "GroupMaxNumSpectra");
		l().Controls.Add(ax());
		l().Controls.Add(n());
		l().Controls.Add(m());
		l().Name = "GroupMaxNumSpectra";
		l().TabStop = false;
		av().SetToolTip(l(), componentResourceManager.GetString("GroupMaxNumSpectra.ToolTip"));
		componentResourceManager.ApplyResources(ax(), "CheckBoxDualGraphs");
		ax().Name = "CheckBoxDualGraphs";
		av().SetToolTip(ax(), componentResourceManager.GetString("CheckBoxDualGraphs.ToolTip"));
		ax().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(n(), "TextBoxNumSpectra");
		n().f(A_0: true);
		n().Name = "TextBoxNumSpectra";
		n().e(A_0: false);
		av().SetToolTip(n(), componentResourceManager.GetString("TextBoxNumSpectra.ToolTip"));
		componentResourceManager.ApplyResources(m(), "LabelNumSpectra");
		m().Name = "LabelNumSpectra";
		av().SetToolTip(m(), componentResourceManager.GetString("LabelNumSpectra.ToolTip"));
		componentResourceManager.ApplyResources(o(), "GroupBoxSpectrumColor");
		o().Controls.Add(az());
		o().Controls.Add(ay());
		o().Controls.Add(ae());
		o().Controls.Add(ac());
		o().Controls.Add(s());
		o().Controls.Add(z());
		o().Controls.Add(t());
		o().Name = "GroupBoxSpectrumColor";
		aj().SetRowSpan(o(), 4);
		o().TabStop = false;
		av().SetToolTip(o(), componentResourceManager.GetString("GroupBoxSpectrumColor.ToolTip"));
		componentResourceManager.ApplyResources(az(), "GroupBoxRestrictWavelength");
		az().Controls.Add(a5());
		az().Controls.Add(a6());
		az().Controls.Add(a3());
		az().Controls.Add(a4());
		az().Controls.Add(a1());
		az().Controls.Add(a2());
		az().Controls.Add(a0());
		az().Name = "GroupBoxRestrictWavelength";
		az().TabStop = false;
		av().SetToolTip(az(), componentResourceManager.GetString("GroupBoxRestrictWavelength.ToolTip"));
		componentResourceManager.ApplyResources(a5(), "Label5");
		a5().Name = "Label5";
		av().SetToolTip(a5(), componentResourceManager.GetString("Label5.ToolTip"));
		componentResourceManager.ApplyResources(a6(), "Label4");
		a6().Name = "Label4";
		av().SetToolTip(a6(), componentResourceManager.GetString("Label4.ToolTip"));
		componentResourceManager.ApplyResources(a3(), "TBNColorWavelengthUpperLimit");
		a3().f(A_0: false);
		a3().Name = "TBNColorWavelengthUpperLimit";
		a3().e(A_0: false);
		av().SetToolTip(a3(), componentResourceManager.GetString("TBNColorWavelengthUpperLimit.ToolTip"));
		componentResourceManager.ApplyResources(a4(), "TBNColorWavelengthLowerLimit");
		a4().f(A_0: false);
		a4().Name = "TBNColorWavelengthLowerLimit";
		a4().e(A_0: false);
		av().SetToolTip(a4(), componentResourceManager.GetString("TBNColorWavelengthLowerLimit.ToolTip"));
		componentResourceManager.ApplyResources(a1(), "Label3");
		a1().Name = "Label3";
		av().SetToolTip(a1(), componentResourceManager.GetString("Label3.ToolTip"));
		componentResourceManager.ApplyResources(a2(), "Label2");
		a2().Name = "Label2";
		av().SetToolTip(a2(), componentResourceManager.GetString("Label2.ToolTip"));
		componentResourceManager.ApplyResources(a0(), "CheckBoxRestrictColorWavelength");
		a0().Name = "CheckBoxRestrictColorWavelength";
		av().SetToolTip(a0(), componentResourceManager.GetString("CheckBoxRestrictColorWavelength.ToolTip"));
		a0().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ay(), "ButtonCorrelation");
		ay().Name = "ButtonCorrelation";
		av().SetToolTip(ay(), componentResourceManager.GetString("ButtonCorrelation.ToolTip"));
		ay().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ae(), "GroupColorSpace");
		ae().Controls.Add(ai());
		ae().Controls.Add(y());
		ae().Controls.Add(r());
		ae().Controls.Add(q());
		ae().Controls.Add(p());
		ae().Controls.Add(x());
		ae().Name = "GroupColorSpace";
		ae().TabStop = false;
		av().SetToolTip(ae(), componentResourceManager.GetString("GroupColorSpace.ToolTip"));
		componentResourceManager.ApplyResources(ai(), "ChkAlwaysShowXYZ");
		ai().Name = "ChkAlwaysShowXYZ";
		av().SetToolTip(ai(), componentResourceManager.GetString("ChkAlwaysShowXYZ.ToolTip"));
		ai().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(y(), "RadioColorCoordxyz");
		y().Name = "RadioColorCoordxyz";
		y().TabStop = true;
		av().SetToolTip(y(), componentResourceManager.GetString("RadioColorCoordxyz.ToolTip"));
		y().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(r(), "RadioColorCoordab");
		r().Name = "RadioColorCoordab";
		r().TabStop = true;
		av().SetToolTip(r(), componentResourceManager.GetString("RadioColorCoordab.ToolTip"));
		r().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(q(), "RadioColorCoorduv");
		q().Name = "RadioColorCoorduv";
		q().TabStop = true;
		av().SetToolTip(q(), componentResourceManager.GetString("RadioColorCoorduv.ToolTip"));
		q().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(p(), "RadioHideSpectrumColor");
		p().Name = "RadioHideSpectrumColor";
		p().TabStop = true;
		av().SetToolTip(p(), componentResourceManager.GetString("RadioHideSpectrumColor.ToolTip"));
		p().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(x(), "RadioColorCoordch");
		x().Name = "RadioColorCoordch";
		x().TabStop = true;
		av().SetToolTip(x(), componentResourceManager.GetString("RadioColorCoordch.ToolTip"));
		x().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ac(), "GroupColorIlluminant");
		ac().Controls.Add(ad());
		ac().Name = "GroupColorIlluminant";
		ac().TabStop = false;
		av().SetToolTip(ac(), componentResourceManager.GetString("GroupColorIlluminant.ToolTip"));
		componentResourceManager.ApplyResources(ad(), "ComboIllumTypes");
		ad().DropDownStyle = ComboBoxStyle.DropDownList;
		ad().FormattingEnabled = true;
		ad().Name = "ComboIllumTypes";
		av().SetToolTip(ad(), componentResourceManager.GetString("ComboIllumTypes.ToolTip"));
		componentResourceManager.ApplyResources(s(), "TextBoxFixLuminance");
		s().f(A_0: false);
		s().Name = "TextBoxFixLuminance";
		s().e(A_0: false);
		av().SetToolTip(s(), componentResourceManager.GetString("TextBoxFixLuminance.ToolTip"));
		componentResourceManager.ApplyResources(z(), "GroupColorAngle");
		z().Controls.Add(aa());
		z().Controls.Add(ab());
		z().Name = "GroupColorAngle";
		z().TabStop = false;
		av().SetToolTip(z(), componentResourceManager.GetString("GroupColorAngle.ToolTip"));
		componentResourceManager.ApplyResources(aa(), "RadioObserver10");
		aa().Name = "RadioObserver10";
		aa().TabStop = true;
		av().SetToolTip(aa(), componentResourceManager.GetString("RadioObserver10.ToolTip"));
		aa().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ab(), "RadioObserver2");
		ab().Name = "RadioObserver2";
		ab().TabStop = true;
		av().SetToolTip(ab(), componentResourceManager.GetString("RadioObserver2.ToolTip"));
		ab().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(t(), "CheckBoxFixLuminance");
		t().Name = "CheckBoxFixLuminance";
		av().SetToolTip(t(), componentResourceManager.GetString("CheckBoxFixLuminance.ToolTip"));
		t().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(u(), "GroupGraphColor");
		u().Controls.Add(al());
		u().Controls.Add(v());
		u().Controls.Add(w());
		u().Name = "GroupGraphColor";
		u().TabStop = false;
		av().SetToolTip(u(), componentResourceManager.GetString("GroupGraphColor.ToolTip"));
		componentResourceManager.ApplyResources(al(), "chkAutoPosition");
		al().Name = "chkAutoPosition";
		av().SetToolTip(al(), componentResourceManager.GetString("chkAutoPosition.ToolTip"));
		al().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(v(), "RadioGraphWhite");
		v().Name = "RadioGraphWhite";
		v().TabStop = true;
		av().SetToolTip(v(), componentResourceManager.GetString("RadioGraphWhite.ToolTip"));
		v().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(w(), "RadioGraphBlack");
		w().Name = "RadioGraphBlack";
		w().TabStop = true;
		av().SetToolTip(w(), componentResourceManager.GetString("RadioGraphBlack.ToolTip"));
		w().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(af(), "GroupBox1");
		af().Controls.Add(ag());
		af().Controls.Add(ah());
		af().Name = "GroupBox1";
		af().TabStop = false;
		av().SetToolTip(af(), componentResourceManager.GetString("GroupBox1.ToolTip"));
		componentResourceManager.ApplyResources(ag(), "ComboBoxSigDigits");
		ag().DropDownStyle = ComboBoxStyle.DropDownList;
		ag().FormattingEnabled = true;
		ag().Items.AddRange(new object[7]
		{
			componentResourceManager.GetString("ComboBoxSigDigits.Items"),
			componentResourceManager.GetString("ComboBoxSigDigits.Items1"),
			componentResourceManager.GetString("ComboBoxSigDigits.Items2"),
			componentResourceManager.GetString("ComboBoxSigDigits.Items3"),
			componentResourceManager.GetString("ComboBoxSigDigits.Items4"),
			componentResourceManager.GetString("ComboBoxSigDigits.Items5"),
			componentResourceManager.GetString("ComboBoxSigDigits.Items6")
		});
		ag().Name = "ComboBoxSigDigits";
		av().SetToolTip(ag(), componentResourceManager.GetString("ComboBoxSigDigits.ToolTip"));
		componentResourceManager.ApplyResources(ah(), "Label1");
		ah().Name = "Label1";
		av().SetToolTip(ah(), componentResourceManager.GetString("Label1.ToolTip"));
		componentResourceManager.ApplyResources(aj(), "TableLayoutPanel1");
		aj().Controls.Add(at(), 1, 1);
		aj().Controls.Add(ak(), 0, 4);
		aj().Controls.Add(af(), 1, 3);
		aj().Controls.Add(o(), 0, 0);
		aj().Controls.Add(u(), 1, 2);
		aj().Controls.Add(l(), 1, 0);
		aj().Controls.Add(am(), 2, 0);
		aj().Name = "TableLayoutPanel1";
		av().SetToolTip(aj(), componentResourceManager.GetString("TableLayoutPanel1.ToolTip"));
		componentResourceManager.ApplyResources(at(), "GroupBoxSpectraTransform");
		at().Controls.Add(au());
		at().Name = "GroupBoxSpectraTransform";
		at().TabStop = false;
		av().SetToolTip(at(), componentResourceManager.GetString("GroupBoxSpectraTransform.ToolTip"));
		componentResourceManager.ApplyResources(au(), "ComboBoxSpectrumCalcs");
		au().DropDownStyle = ComboBoxStyle.DropDownList;
		au().FormattingEnabled = true;
		au().Name = "ComboBoxSpectrumCalcs";
		av().SetToolTip(au(), componentResourceManager.GetString("ComboBoxSpectrumCalcs.ToolTip"));
		componentResourceManager.ApplyResources(ak(), "TableLayoutPanel2");
		aj().SetColumnSpan(ak(), 3);
		ak().Controls.Add(j(), 0, 0);
		ak().Controls.Add(k(), 1, 0);
		ak().Name = "TableLayoutPanel2";
		av().SetToolTip(ak(), componentResourceManager.GetString("TableLayoutPanel2.ToolTip"));
		componentResourceManager.ApplyResources(am(), "GroupBoxControlsDisplayed");
		am().Controls.Add(a7());
		am().Controls.Add(aw());
		am().Controls.Add(ao());
		am().Controls.Add(ap());
		am().Controls.Add(aq());
		am().Controls.Add(ar());
		am().Controls.Add(@as());
		am().Controls.Add(an());
		am().Name = "GroupBoxControlsDisplayed";
		aj().SetRowSpan(am(), 4);
		am().TabStop = false;
		av().SetToolTip(am(), componentResourceManager.GetString("GroupBoxControlsDisplayed.ToolTip"));
		componentResourceManager.ApplyResources(a7(), "CheckBoxShowOpticsConfig");
		a7().Name = "CheckBoxShowOpticsConfig";
		av().SetToolTip(a7(), componentResourceManager.GetString("CheckBoxShowOpticsConfig.ToolTip"));
		a7().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(aw(), "CheckBoxSampleInfo");
		aw().Name = "CheckBoxSampleInfo";
		av().SetToolTip(aw(), componentResourceManager.GetString("CheckBoxSampleInfo.ToolTip"));
		aw().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ao(), "CheckBoxDisplayTemplate");
		ao().Name = "CheckBoxDisplayTemplate";
		av().SetToolTip(ao(), componentResourceManager.GetString("CheckBoxDisplayTemplate.ToolTip"));
		ao().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ap(), "CheckBoxDisplayMeasResults");
		ap().Name = "CheckBoxDisplayMeasResults";
		av().SetToolTip(ap(), componentResourceManager.GetString("CheckBoxDisplayMeasResults.ToolTip"));
		ap().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(aq(), "CheckBoxDisplayTransmittanceColor");
		aq().Name = "CheckBoxDisplayTransmittanceColor";
		av().SetToolTip(aq(), componentResourceManager.GetString("CheckBoxDisplayTransmittanceColor.ToolTip"));
		aq().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ar(), "CheckBoxDisplaySpectrumColor");
		ar().Name = "CheckBoxDisplaySpectrumColor";
		av().SetToolTip(ar(), componentResourceManager.GetString("CheckBoxDisplaySpectrumColor.ToolTip"));
		ar().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(@as(), "CheckBoxDisplayRecipe");
		@as().Name = "CheckBoxDisplayRecipe";
		av().SetToolTip(@as(), componentResourceManager.GetString("CheckBoxDisplayRecipe.ToolTip"));
		@as().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(an(), "CheckBoxDisplayMeasStatus");
		an().Name = "CheckBoxDisplayMeasStatus";
		av().SetToolTip(an(), componentResourceManager.GetString("CheckBoxDisplayMeasStatus.ToolTip"));
		an().UseVisualStyleBackColor = true;
		av().AutoPopDelay = 15000;
		av().InitialDelay = 500;
		av().ReshowDelay = 100;
		base.AcceptButton = j();
		componentResourceManager.ApplyResources(this, "$this");
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = k();
		base.Controls.Add(aj());
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogSetupDisplay";
		base.ShowInTaskbar = false;
		av().SetToolTip(this, componentResourceManager.GetString("$this.ToolTip"));
		l().ResumeLayout(performLayout: false);
		l().PerformLayout();
		o().ResumeLayout(performLayout: false);
		o().PerformLayout();
		az().ResumeLayout(performLayout: false);
		az().PerformLayout();
		ae().ResumeLayout(performLayout: false);
		ae().PerformLayout();
		ac().ResumeLayout(performLayout: false);
		z().ResumeLayout(performLayout: false);
		z().PerformLayout();
		u().ResumeLayout(performLayout: false);
		af().ResumeLayout(performLayout: false);
		af().PerformLayout();
		aj().ResumeLayout(performLayout: false);
		aj().PerformLayout();
		at().ResumeLayout(performLayout: false);
		ak().ResumeLayout(performLayout: false);
		am().ResumeLayout(performLayout: false);
		am().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button j()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = n;
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
	internal virtual Button k()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = m;
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
	internal virtual GroupBox l()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(GroupBox A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label m()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy n()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hy A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox o()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(GroupBox A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton p()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(RadioButton A_0)
	{
		EventHandler value = l;
		RadioButton radioButton = this.m_h;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_h = A_0;
		radioButton = this.m_h;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton q()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(RadioButton A_0)
	{
		EventHandler value = j;
		RadioButton radioButton = this.m_i;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_i = A_0;
		radioButton = this.m_i;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton r()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(RadioButton A_0)
	{
		EventHandler value = k;
		RadioButton radioButton = this.m_j;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_j = A_0;
		radioButton = this.m_j;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy s()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(hy A_0)
	{
		EventHandler value = a;
		hy hy2 = this.m_k;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_k = A_0;
		hy2 = this.m_k;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox t()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(CheckBox A_0)
	{
		EventHandler value = i;
		CheckBox checkBox = this.m_l;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_l = A_0;
		checkBox = this.m_l;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox u()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(GroupBox A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton v()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(RadioButton A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton w()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(RadioButton A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton x()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(RadioButton A_0)
	{
		EventHandler value = h;
		RadioButton radioButton = this.m_p;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_p = A_0;
		radioButton = this.m_p;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton y()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(RadioButton A_0)
	{
		EventHandler value = g;
		RadioButton radioButton = this.m_q;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_q = A_0;
		radioButton = this.m_q;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox z()
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
	internal virtual RadioButton aa()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(RadioButton A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ab()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(RadioButton A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ac()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(GroupBox A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox ad()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ae()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(GroupBox A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox af()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(GroupBox A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox ag()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ComboBox A_0)
	{
		this.m_y = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ah()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ai()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(CheckBox A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel aj()
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
	internal virtual TableLayoutPanel ak()
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
	internal virtual CheckBox al()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(CheckBox A_0)
	{
		this.m_ad = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox am()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(GroupBox A_0)
	{
		this.m_ae = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox an()
	{
		return this.m_af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(CheckBox A_0)
	{
		this.m_af = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ao()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(CheckBox A_0)
	{
		this.m_ag = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ap()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(CheckBox A_0)
	{
		this.m_ah = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox aq()
	{
		return this.m_ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(CheckBox A_0)
	{
		this.m_ai = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ar()
	{
		return this.m_aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(CheckBox A_0)
	{
		this.m_aj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox @as()
	{
		return this.m_ak;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(CheckBox A_0)
	{
		this.m_ak = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox at()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(GroupBox A_0)
	{
		this.m_al = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox au()
	{
		return this.m_am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ComboBox A_0)
	{
		this.m_am = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip av()
	{
		return this.m_an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolTip A_0)
	{
		this.m_an = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox aw()
	{
		return this.m_ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(CheckBox A_0)
	{
		this.m_ao = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ax()
	{
		return this.m_ap;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(CheckBox A_0)
	{
		this.m_ap = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ay()
	{
		return this.m_aq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = e;
		Button button = this.m_aq;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_aq = A_0;
		button = this.m_aq;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox az()
	{
		return this.m_ar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(GroupBox A_0)
	{
		this.m_ar = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox a0()
	{
		return this.m_as;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(CheckBox A_0)
	{
		EventHandler value = d;
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
	internal virtual Label a1()
	{
		return this.m_at;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_at = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a2()
	{
		return this.m_au;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_au = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy a3()
	{
		return this.m_av;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(hy A_0)
	{
		EventHandler value = b;
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
	internal virtual hy a4()
	{
		return this.m_aw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(hy A_0)
	{
		EventHandler value = c;
		hy hy2 = this.m_aw;
		if (hy2 != null)
		{
			hy2.TextChanged -= value;
		}
		this.m_aw = A_0;
		hy2 = this.m_aw;
		if (hy2 != null)
		{
			hy2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a5()
	{
		return this.m_ax;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_ax = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a6()
	{
		return this.m_ay;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_ay = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox a7()
	{
		return this.m_az;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(CheckBox A_0)
	{
		this.m_az = A_0;
	}

	public static string a(b A_0)
	{
		return A_0 switch
		{
			fh.b.a => "None", 
			fh.b.b => "Sum (R + T)", 
			fh.b.c => "Absorptance (1 - R - T)", 
			_ => null, 
		};
	}

	public static string a(a A_0)
	{
		return A_0 switch
		{
			fh.a.a => "White", 
			fh.a.b => "Black", 
			_ => "Unknown", 
		};
	}

	public void a(fz A_0, f1 A_1, short A_2, fm A_3, bool A_4, bool A_5)
	{
		this.m_a5 = A_0;
		this.m_a6 = A_1;
		o().Visible = A_4;
		ao().Enabled = A_5;
		this.m_a0 = global::e.a().ShowSpectrumColor;
		this.m_a1 = this.m_a0;
		this.m_a2 = (a4.a)global::e.a().ShowSpectrumCoordOption;
		this.m_a4 = A_3;
		bd = this.m_a6.ui();
		foreach (object value in Enum.GetValues(typeof(a4.c)))
		{
			a4.c c10 = (a4.c)Conversions.ToShort(value);
			ad().Items.Add(new iz.a(global::a4.a(c10), (int)c10));
		}
		iz.b(ad(), global::e.a().SpectrumColorIlluminant);
		if (this.m_a0)
		{
			if (this.m_a2 == global::a4.a.a)
			{
				r().Checked = true;
			}
			else if (this.m_a2 == global::a4.a.b)
			{
				q().Checked = true;
			}
			else if (this.m_a2 == global::a4.a.c)
			{
				x().Checked = true;
			}
			else
			{
				y().Checked = true;
			}
			ai().Checked = global::e.a().AlwayShowSpectrumCoordXYZ;
		}
		else
		{
			p().Checked = true;
		}
		n().Text = Conversions.ToString((int)A_2);
		this.m_a7 = global::e.a().SpectrumColorFixLuminance;
		a8 = ((global::e.a().SpectrumColorLumValue >= 10f) ? global::e.a().SpectrumColorLumValue : 10f);
		a();
		e();
		a9 = global::e.a().RestrictColorWavelength;
		ba = global::e.a().ColorWavelengthLowerLimitNm;
		bb = global::e.a().ColorWavelengthUpperLimitNm;
		f();
		g();
		if (global::e.a().GraphBackColor == 0)
		{
			v().Checked = true;
		}
		else
		{
			w().Checked = true;
		}
		if (global::e.a().SpectrumColorObserver == 0)
		{
			ab().Checked = true;
		}
		else
		{
			aa().Checked = true;
		}
		ComboBox comboBox = ag();
		ComboBox.ObjectCollection items;
		checked
		{
			comboBox.SelectedIndex = global::e.a().DisplaySignificantDigits - Conversions.ToInteger(comboBox.Items[0]);
			comboBox = null;
			al().Checked = global::e.a().AutoPositionLegends;
			this.m_a3 = global::e.a().AutoPositionLegends;
			aw().Checked = global::e.a().DisplaySampleInfoControls;
			an().Checked = global::e.a().DisplayMeasStatusControls;
			@as().Checked = global::e.a().DisplayRecipeControls;
			ar().Checked = global::e.a().DisplaySpectrumColorControls;
			aq().Checked = global::e.a().DisplayTransmittanceColorControls;
			ap().Checked = global::e.a().DisplayMeasResultsControls;
			ao().Checked = global::e.a().DisplayTemplateControls;
			bool flag = false;
			if (bd)
			{
				a7().Checked = global::e.a().ShowOpticsAndSpecStatus;
				a7().Visible = true;
				flag = true;
			}
			if (!flag)
			{
				am().Height -= a7().Location.Y - ao().Location.Y;
			}
			items = au().Items;
		}
		foreach (object value2 in Enum.GetValues(typeof(b)))
		{
			b a_ = (b)Conversions.ToInteger(value2);
			items.Add(a(a_));
		}
		items = null;
		au().SelectedIndex = global::e.a().DisplayedSpectrumTransformation;
		ax().Checked = global::e.a().DualSpectrumGraphs;
		ay().Visible = this.m_a6.ud();
		ShowDialog();
	}

	private void h()
	{
		a();
		f();
	}

	private void g()
	{
		try
		{
			c();
			if (a0().Checked)
			{
				a4().Text = Conversions.ToString(ba);
				a3().Text = Conversions.ToString(bb);
			}
			else
			{
				a4().Text = string.Empty;
				a3().Text = string.Empty;
			}
		}
		finally
		{
			d();
		}
	}

	private void f()
	{
		try
		{
			c();
			a0().Enabled = this.m_a0;
			a0().Checked = a9 && this.m_a0;
			az().Enabled = this.m_a0;
			g();
		}
		finally
		{
			d();
		}
	}

	private void e()
	{
		try
		{
			c();
			if (t().Checked)
			{
				s().Text = a8.ToString();
			}
			else
			{
				s().Text = string.Empty;
			}
		}
		finally
		{
			d();
		}
	}

	private void d()
	{
		checked
		{
			bc--;
			if (bc < 0)
			{
				bc = 0;
			}
		}
	}

	private void c()
	{
		checked
		{
			bc++;
		}
	}

	[SpecialName]
	private bool b()
	{
		return bc > 0;
	}

	private void n(object A_0, EventArgs A_1)
	{
		if (!short.TryParse(n().Text, out var result))
		{
			result = 0;
		}
		if (t().Checked && (a8 < 10f || a8 > 100f))
		{
			fe.b(this.m_a5, "Luminance >= " + 10f + " and luminance <= 100. Please enter a valid value.", i6.a(this));
			return;
		}
		if (a0().Checked && ba >= bb)
		{
			fe.b(this.m_a5, "Upper limit must be larger than lower limit.", i6.a(this));
			return;
		}
		if ((result < 1) | (result > 10))
		{
			fe.b(this.m_a5, "Please enter a valid value for # of spectra to display in the graph: (1-" + (short)10 + ")", i6.a(this));
			return;
		}
		global::e.a().GraphMeasUserDefinedMaxCurves = result;
		global::e.a().SpectrumColorFixLuminance = this.m_a7;
		global::e.a().SpectrumColorLumValue = a8;
		global::e.a().ShowSpectrumColor = this.m_a0;
		checked
		{
			global::e.a().ShowSpectrumCoordOption = (short)this.m_a2;
			global::e.a().AlwayShowSpectrumCoordXYZ = ai().Checked;
			if (aa().Checked)
			{
				global::e.a().SpectrumColorObserver = 1;
			}
			else
			{
				global::e.a().SpectrumColorObserver = 0;
			}
			global::e.a().SpectrumColorIlluminant = (short)((iz.a)ad().SelectedItem).b;
			if (w().Checked)
			{
				global::e.a().GraphBackColor = 1;
			}
			else
			{
				global::e.a().GraphBackColor = 0;
			}
			global::e.a().DisplaySignificantDigits = (byte)(ag().SelectedIndex + Conversions.ToInteger(ag().Items[0]));
			global::e.a().AutoPositionLegends = al().Checked;
			if (al().Checked != this.m_a3)
			{
				this.m_a4.b();
			}
			global::e.a().DisplaySampleInfoControls = aw().Checked;
			global::e.a().DisplayMeasStatusControls = an().Checked;
			global::e.a().DisplayRecipeControls = @as().Checked;
			global::e.a().DisplaySpectrumColorControls = ar().Checked;
			global::e.a().DisplayTransmittanceColorControls = aq().Checked;
			global::e.a().DisplayMeasResultsControls = ap().Checked;
			global::e.a().DisplayTemplateControls = ao().Checked;
			global::e.a().DisplayedSpectrumTransformation = au().SelectedIndex;
			global::e.a().DualSpectrumGraphs = ax().Checked;
			global::e.a().RestrictColorWavelength = a9;
			global::e.a().ColorWavelengthLowerLimitNm = ba;
			global::e.a().ColorWavelengthUpperLimitNm = bb;
			if (bd)
			{
				global::e.a().ShowOpticsAndSpecStatus = a7().Checked;
			}
			global::e.a().Save();
			f1.fz.h();
			if (f1.fz.f() || global::e.a().ShareSettingsWithSelectedUsers)
			{
				f1.fz.j();
			}
			Close();
		}
	}

	private void m(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void l(object A_0, EventArgs A_1)
	{
		if (p().Checked)
		{
			this.m_a0 = false;
			h();
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		if (r().Checked)
		{
			this.m_a2 = global::a4.a.a;
			this.m_a0 = true;
			h();
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		if (q().Checked)
		{
			this.m_a2 = global::a4.a.b;
			this.m_a0 = true;
			h();
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		if (t().Checked && t().Enabled)
		{
			s().Enabled = true;
		}
		else
		{
			s().Enabled = false;
		}
		if (!b())
		{
			this.m_a7 = t().Checked;
			e();
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		if (x().Checked)
		{
			this.m_a2 = global::a4.a.c;
			this.m_a0 = true;
			h();
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		if (y().Checked)
		{
			this.m_a2 = global::a4.a.d;
			this.m_a0 = true;
			h();
		}
	}

	private void a()
	{
		try
		{
			c();
			t().Enabled = this.m_a0;
			t().Checked = this.m_a0 && this.m_a7;
			ar().Enabled = this.m_a0;
			aq().Enabled = this.m_a0;
			e();
		}
		finally
		{
			d();
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		t().Text = string.Format(t().Text, 10f.ToString());
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			new aa().a(this.m_a5, this.m_a6, this.m_a2, ai().Checked, this.m_a6.u5().j());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_a5, this.m_a6, null, i6.a(this), "DialogSetupDisplay.ButtonCorrelation_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			if (a0().Checked)
			{
				a4().Enabled = true;
				a3().Enabled = true;
			}
			else
			{
				a4().Enabled = false;
				a3().Enabled = false;
			}
			if (!b())
			{
				a9 = a0().Checked;
				g();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_a5, this.m_a6, null, i6.a(this), "DialogSetupDisplay.CheckBoxRestrictColorWavelength_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			if (!b())
			{
				ba = iz.d(a4().Text);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_a5, this.m_a6, null, i6.a(this), "DialogSetupDisplay.TBNColorWavelengthLowerLimit_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			if (!b())
			{
				bb = iz.d(a3().Text);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_a5, this.m_a6, null, i6.a(this), "DialogSetupDisplay.TBNColorWavelengthUpperLimit_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			if (!b() && !float.TryParse(s().Text, out a8))
			{
				a8 = 1f;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_a5, this.m_a6, null, i6.a(this), "DialogSetupDisplay.TextBoxFixLuminance_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}
}
