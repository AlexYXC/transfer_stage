using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class dv : Form
{
	public class a
	{
		public bool a;

		public string b;

		public string c;

		public bool d;

		public string e;

		public string f;

		public bool g;

		public string h;

		public string i;

		public bool j;

		public string k;

		public string l;

		public bool m;

		public string n;

		public string o;

		public bool p;

		public string q;

		public string r;

		public bool s;

		public string t;

		public string u;

		public bool v;

		public string w;

		public string x;

		public string y;

		public string z;

		public bool aa;

		public string ab;

		public string ac;
	}

	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private GroupBox m_c;

	[CompilerGenerated]
	private LinkLabel m_d;

	[CompilerGenerated]
	private TextBox m_e;

	[CompilerGenerated]
	private CheckBox m_f;

	[CompilerGenerated]
	private TextBox m_g;

	[CompilerGenerated]
	private CheckBox m_h;

	[CompilerGenerated]
	private TextBox m_i;

	[CompilerGenerated]
	private CheckBox m_j;

	[CompilerGenerated]
	private TextBox m_k;

	[CompilerGenerated]
	private TextBox m_l;

	[CompilerGenerated]
	private CheckBox m_m;

	[CompilerGenerated]
	private TextBox m_n;

	[CompilerGenerated]
	private CheckBox m_o;

	[CompilerGenerated]
	private CheckBox m_p;

	[CompilerGenerated]
	private ToolTip m_q;

	[CompilerGenerated]
	private Button m_r;

	[CompilerGenerated]
	private TextBox m_s;

	[CompilerGenerated]
	private CheckBox m_t;

	[CompilerGenerated]
	private TextBox m_u;

	[CompilerGenerated]
	private CheckBox m_v;

	[CompilerGenerated]
	private TextBox m_w;

	[CompilerGenerated]
	private CheckBox m_x;

	private fz y;

	private a z;

	public dv()
	{
		base.Load += a;
		a();
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
	private void a()
	{
		this.m_a = new Container();
		a(new Button());
		a(new GroupBox());
		h(new TextBox());
		h(new CheckBox());
		g(new TextBox());
		g(new CheckBox());
		a(new LinkLabel());
		a(new TextBox());
		a(new CheckBox());
		b(new TextBox());
		b(new CheckBox());
		c(new TextBox());
		c(new CheckBox());
		d(new TextBox());
		e(new TextBox());
		d(new CheckBox());
		f(new TextBox());
		e(new CheckBox());
		f(new CheckBox());
		a(new ToolTip(this.m_a));
		b(new Button());
		i(new TextBox());
		i(new CheckBox());
		c().SuspendLayout();
		SuspendLayout();
		b().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		b().DialogResult = DialogResult.OK;
		b().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b().Location = new Point(181, 413);
		b().Margin = new Padding(4);
		b().Name = "ButtonOK";
		b().Size = new Size(89, 28);
		b().TabIndex = 0;
		b().Text = "OK";
		c().Controls.Add(w());
		c().Controls.Add(x());
		c().Controls.Add(u());
		c().Controls.Add(v());
		c().Controls.Add(s());
		c().Controls.Add(t());
		c().Controls.Add(d());
		c().Controls.Add(e());
		c().Controls.Add(f());
		c().Controls.Add(g());
		c().Controls.Add(h());
		c().Controls.Add(i());
		c().Controls.Add(j());
		c().Controls.Add(k());
		c().Controls.Add(l());
		c().Controls.Add(m());
		c().Controls.Add(n());
		c().Controls.Add(o());
		c().Controls.Add(p());
		c().Location = new Point(12, 12);
		c().Name = "GroupBoxFiles";
		c().Size = new Size(520, 387);
		c().TabIndex = 4;
		c().TabStop = false;
		c().Text = "Attached Files";
		u().Location = new Point(26, 313);
		u().Multiline = true;
		u().Name = "TextBoxLicenseFiles";
		u().ReadOnly = true;
		u().ScrollBars = ScrollBars.Vertical;
		u().Size = new Size(471, 59);
		u().TabIndex = 33;
		u().TabStop = false;
		u().Text = "License1\r\nLicense2\r\nLicense3";
		v().AutoSize = true;
		v().Checked = true;
		v().CheckState = CheckState.Checked;
		v().Location = new Point(11, 291);
		v().Name = "CheckBoxLicenseFiles";
		v().Size = new Size(106, 20);
		v().TabIndex = 32;
		v().Text = "License Files";
		v().UseVisualStyleBackColor = true;
		s().Location = new Point(301, 227);
		s().Name = "TextBoxComputerInfo";
		s().ReadOnly = true;
		s().Size = new Size(196, 22);
		s().TabIndex = 31;
		s().TabStop = false;
		s().Text = "CompInfo.txt";
		t().AutoSize = true;
		t().Checked = true;
		t().CheckState = CheckState.Checked;
		t().Location = new Point(286, 205);
		t().Name = "CheckBoxCompInfo";
		t().Size = new Size(153, 20);
		t().TabIndex = 30;
		t().Text = "Computer Information";
		t().UseVisualStyleBackColor = true;
		d().AutoSize = true;
		d().Location = new Point(194, 19);
		d().Name = "LinkLabelWhatIsAttachedFiles";
		d().Size = new Size(132, 16);
		d().TabIndex = 29;
		d().TabStop = true;
		d().Text = "What are these files?";
		e().Location = new Point(301, 177);
		e().Name = "TextBoxFileSettings";
		e().ReadOnly = true;
		e().Size = new Size(196, 22);
		e().TabIndex = 28;
		e().TabStop = false;
		e().Text = "Settings.txt";
		f().AutoSize = true;
		f().Checked = true;
		f().CheckState = CheckState.Checked;
		f().Location = new Point(286, 155);
		f().Name = "CheckBoxFileSettings";
		f().Size = new Size(75, 20);
		f().TabIndex = 27;
		f().Text = "Settings";
		f().UseVisualStyleBackColor = true;
		g().Location = new Point(26, 67);
		g().Name = "TextBoxFileActiveSpectrum";
		g().ReadOnly = true;
		g().Size = new Size(236, 22);
		g().TabIndex = 26;
		g().TabStop = false;
		g().Text = "ActiveSpec.fmspe";
		h().AutoSize = true;
		h().Checked = true;
		h().CheckState = CheckState.Checked;
		h().Location = new Point(11, 45);
		h().Name = "CheckBoxFileCurrentSpectrum";
		h().Size = new Size(129, 20);
		h().TabIndex = 4;
		h().Text = "Current Spectrum";
		h().UseVisualStyleBackColor = true;
		i().Location = new Point(26, 203);
		i().Multiline = true;
		i().Name = "TextBoxFileBaselineSpectra";
		i().ReadOnly = true;
		i().ScrollBars = ScrollBars.Vertical;
		i().Size = new Size(236, 75);
		i().TabIndex = 24;
		i().TabStop = false;
		i().Text = "Reference-R.fmspe\r\nBackground-R.fmspe\r\nReference-T.fmspe\r\nBackground-T.fmspe";
		j().AutoSize = true;
		j().Checked = true;
		j().CheckState = CheckState.Checked;
		j().Location = new Point(11, 181);
		j().Name = "CheckBoxFileBaselineSpectra";
		j().Size = new Size(112, 20);
		j().TabIndex = 3;
		j().Text = "Baseline Data";
		j().UseVisualStyleBackColor = true;
		k().Location = new Point(301, 67);
		k().Name = "TextBoxFileSystemInfo";
		k().ReadOnly = true;
		k().Size = new Size(196, 22);
		k().TabIndex = 22;
		k().TabStop = false;
		k().Text = "SystemInfo.txt";
		l().Location = new Point(301, 122);
		l().Name = "TextBoxFileLog";
		l().ReadOnly = true;
		l().Size = new Size(196, 22);
		l().TabIndex = 21;
		l().TabStop = false;
		l().Text = "2007-09.log";
		m().AutoSize = true;
		m().Checked = true;
		m().CheckState = CheckState.Checked;
		m().Location = new Point(286, 100);
		m().Name = "CheckBoxFileLog";
		m().Size = new Size(158, 20);
		m().TabIndex = 2;
		m().Text = "<ProgName> Log File";
		m().UseVisualStyleBackColor = true;
		n().Location = new Point(26, 137);
		n().Name = "TextBoxFileRecipe";
		n().ReadOnly = true;
		n().Size = new Size(236, 22);
		n().TabIndex = 20;
		n().TabStop = false;
		o().AutoSize = true;
		o().Checked = true;
		o().CheckState = CheckState.Checked;
		o().Location = new Point(11, 115);
		o().Name = "CheckBoxFileRecipe";
		o().Size = new Size(203, 20);
		o().TabIndex = 5;
		o().Text = "Current Recipe+Material Files";
		o().UseVisualStyleBackColor = true;
		p().AutoSize = true;
		p().Checked = true;
		p().CheckState = CheckState.Checked;
		p().Location = new Point(286, 45);
		p().Name = "CheckBoxFileSystemInfo";
		p().Size = new Size(225, 20);
		p().TabIndex = 1;
		p().Text = "Measurement System Information";
		p().UseVisualStyleBackColor = true;
		q().AutoPopDelay = 5000;
		q().InitialDelay = 1;
		q().ReshowDelay = 1;
		r().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		r().DialogResult = DialogResult.Cancel;
		r().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		r().Location = new Point(278, 413);
		r().Margin = new Padding(4);
		r().Name = "ButtonCancel";
		r().Size = new Size(89, 28);
		r().TabIndex = 5;
		r().Text = "Cancel";
		w().Location = new Point(301, 277);
		w().Name = "TextBoxWavelenCalLogs";
		w().ReadOnly = true;
		w().Size = new Size(196, 22);
		w().TabIndex = 35;
		w().TabStop = false;
		w().Text = "DeltaDeltaLog.csv";
		x().AutoSize = true;
		x().Checked = true;
		x().CheckState = CheckState.Checked;
		x().Location = new Point(286, 255);
		x().Name = "CheckBoxWavelenCalLogs";
		x().Size = new Size(199, 20);
		x().TabIndex = 34;
		x().Text = "Wavelength Calibration Logs";
		x().UseVisualStyleBackColor = true;
		base.AcceptButton = b();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = r();
		base.ClientSize = new Size(548, 455);
		base.Controls.Add(r());
		base.Controls.Add(b());
		base.Controls.Add(c());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogSupportFiles";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Technical Support Files";
		c().ResumeLayout(performLayout: false);
		c().PerformLayout();
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button b()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = b;
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
	internal virtual GroupBox c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(GroupBox A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual LinkLabel d()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(LinkLabel A_0)
	{
		LinkLabelLinkClickedEventHandler value = a;
		LinkLabel linkLabel = this.m_d;
		if (linkLabel != null)
		{
			linkLabel.LinkClicked -= value;
		}
		this.m_d = A_0;
		linkLabel = this.m_d;
		if (linkLabel != null)
		{
			linkLabel.LinkClicked += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox e()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TextBox A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox f()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(CheckBox A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox g()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TextBox A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox h()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(CheckBox A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox i()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TextBox A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox j()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(CheckBox A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox k()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TextBox A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox l()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TextBox A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox m()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(CheckBox A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox n()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(TextBox A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox o()
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
	internal virtual CheckBox p()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(CheckBox A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip q()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolTip A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button r()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox s()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(TextBox A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox t()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(CheckBox A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox u()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(TextBox A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox v()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(CheckBox A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox w()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TextBox A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox x()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(CheckBox A_0)
	{
		this.m_x = A_0;
	}

	public void a(fz A_0, a A_1)
	{
		y = A_0;
		z = A_1;
		a a10 = z;
		a(l(), m(), a10.b, a10.c, a10.a);
		a(n(), o(), a10.e, a10.f, a10.d);
		a(i(), j(), a10.h, a10.i, a10.g);
		a(k(), p(), a10.k, a10.l, a10.j);
		a(g(), h(), a10.n, a10.o, a10.m);
		a(e(), f(), a10.q, a10.r, a10.p);
		a(s(), t(), a10.t, a10.u, a10.s);
		a(u(), v(), a10.w, a10.x, a10.v);
		a(w(), x(), a10.ab, a10.ac, a10.aa);
		ShowDialog();
		a10 = null;
	}

	private void a(TextBox A_0, CheckBox A_1, string A_2, string A_3, bool A_4)
	{
		A_1.Checked = A_4;
		A_1.Enabled = !string.IsNullOrEmpty(A_2);
		A_0.Text = A_2;
		A_0.Enabled = !string.IsNullOrEmpty(A_2);
		q().SetToolTip(A_0, A_3);
	}

	private void a(object A_0, LinkLabelLinkClickedEventArgs A_1)
	{
		try
		{
			fz a_ = y;
			string A_2 = "TechSupportAttachedFilesWhatIs";
			fe.b(a_, hu.a(ref A_2), "Information", i6.a(d()));
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			y.c(fz.b.b, "Error in DialogSupportFiles.LinkLabelWhatIsAttachedFiles_LinkClicked.", a_2);
			fe.b(y, "Error in DialogSupportFiles.LinkLabelWhatIsAttachedFiles_LinkClicked. Error has been logged.", i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			a obj = z;
			obj.g = j().Checked;
			obj.m = h().Checked;
			obj.a = m().Checked;
			obj.d = o().Checked;
			obj.p = f().Checked;
			obj.j = p().Checked;
			obj.s = t().Checked;
			obj.v = v().Checked;
			obj.aa = x().Checked;
			_ = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			y.c(fz.b.b, "Error in DialogSupportFiles.ButtonOK_Click.", a_);
			fe.b(y, "Error in DialogSupportFiles.ButtonOK_Click. Error has been logged.", i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		CheckBox checkBox = m();
		string A_2 = "TechSupportSoftwareLogFileNameFmt";
		checkBox.Text = string.Format(hu.a(ref A_2), global::c.d().Info.ProductName);
		ToolTip toolTip = q();
		CheckBox control = f();
		A_2 = "TechSupportSettingsTooltipFmt";
		toolTip.SetToolTip(control, string.Format(hu.a(ref A_2), global::c.d().Info.ProductName));
	}
}
