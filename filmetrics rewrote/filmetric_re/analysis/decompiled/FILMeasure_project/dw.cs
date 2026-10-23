using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Filmetrics.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class dw : Form
{
	private class a
	{
		private int m_a;

		public StringBuilder b;

		public byte[] c;

		public HttpWebRequest d;

		public HttpWebResponse e;

		public Stream f;

		public a()
		{
			m_a = 1024;
			c = new byte[checked(m_a + 1)];
			b = new StringBuilder("");
			d = null;
			f = null;
		}
	}

	private delegate void b();

	private delegate void c();

	private delegate void d(string A_0);

	private delegate void e();

	private IContainer m_a;

	[CompilerGenerated]
	private Label m_b;

	[CompilerGenerated]
	private hx m_c;

	[CompilerGenerated]
	private Label m_d;

	[CompilerGenerated]
	private hx m_e;

	[CompilerGenerated]
	private Label m_f;

	[CompilerGenerated]
	private TextBox m_g;

	[CompilerGenerated]
	private Button m_h;

	[CompilerGenerated]
	private GroupBox m_i;

	[CompilerGenerated]
	private GroupBox m_j;

	[CompilerGenerated]
	private hx m_k;

	[CompilerGenerated]
	private Label m_l;

	[CompilerGenerated]
	private Label m_m;

	[CompilerGenerated]
	private hx m_n;

	[CompilerGenerated]
	private Label m_o;

	[CompilerGenerated]
	private ToolTip m_p;

	[CompilerGenerated]
	private Button m_q;

	[CompilerGenerated]
	private Button m_r;

	[CompilerGenerated]
	private Button m_s;

	[CompilerGenerated]
	private hx m_t;

	[CompilerGenerated]
	private GroupBox m_u;

	[CompilerGenerated]
	private GroupBox m_v;

	[CompilerGenerated]
	private ComboBox m_w;

	[CompilerGenerated]
	private Label m_x;

	[CompilerGenerated]
	private Button m_y;

	[CompilerGenerated]
	private Label m_z;

	[CompilerGenerated]
	private Button m_aa;

	[CompilerGenerated]
	private Button m_ab;

	[CompilerGenerated]
	private ErrorProvider m_ac;

	private string m_ad;

	private Guid m_ae;

	private f1 m_af;

	private object m_ag;

	private bool m_ah;

	private fz m_ai;

	private bool[] m_aj;

	private h.f[] m_ak;

	private bool m_al;

	private bool m_am;

	public const string an = "\\TechSupport";

	public const string ao = "TSR Summary.txt";

	public const string ap = "CompInfo.txt";

	public const string aq = "Settings.txt";

	public const string ar = "Company name: ";

	public const string @as = "~Unknown~";

	public const string at = "User name: ";

	public const string au = "ActiveRecipe";

	public const string av = "Spectrum Graph Maximum Wavelength: ";

	public const string aw = "Spectrum Graph Minimum Wavelength: ";

	public const string ax = "ActiveSpec";

	public const string ay = "ModuleConfig.csv";

	private string az;

	private string a0;

	private string a1;

	private Collection<string> a2;

	private Collection<string> a3;

	private Collection<string> a4;

	private string a5;

	private string a6;

	private string a7;

	private string a8;

	private string a9;

	private string[] ba;

	private string bb;

	private dv.a bc;

	private const int bd = -8;

	private const int be = 8;

	private const int bf = 16;

	private const int bg = 4;

	public const string bh = ".fitsa";

	public const string bi = "Tech Support Archive (*.fitsa)|*.fitsa";

	private Collection<string> bj;

	private const string bk = "techsupportproviders.html";

	[CompilerGenerated]
	private b bl;

	private bool bm;

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
	private void m()
	{
		this.m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(dw));
		a(new Label());
		b(new Label());
		c(new Label());
		a(new TextBox());
		a(new Button());
		a(new GroupBox());
		f(new Button());
		g(new Button());
		h(new Label());
		d(new hx());
		f(new Label());
		a(new hx());
		b(new hx());
		b(new GroupBox());
		e(new hx());
		b(new Button());
		c(new hx());
		d(new Label());
		e(new Label());
		a(new ToolTip(this.m_a));
		e(new Button());
		c(new Button());
		d(new Button());
		c(new GroupBox());
		d(new GroupBox());
		a(new ComboBox());
		g(new Label());
		a(new ErrorProvider(this.m_a));
		u().SuspendLayout();
		v().SuspendLayout();
		ag().SuspendLayout();
		ah().SuspendLayout();
		((ISupportInitialize)ao()).BeginInit();
		SuspendLayout();
		n().AutoSize = true;
		n().Location = new Point(90, 24);
		n().Name = "LabelSummary";
		n().Size = new Size(68, 16);
		n().TabIndex = 1;
		n().Text = "Summary:";
		p().AutoSize = true;
		p().Location = new Point(27, 236);
		p().Name = "Label2";
		p().Size = new Size(131, 16);
		p().TabIndex = 4;
		p().Text = "Detailed description:";
		r().AutoSize = true;
		r().Location = new Point(15, 404);
		r().Name = "Label3";
		r().Size = new Size(144, 16);
		r().TabIndex = 6;
		r().Text = "Optional attachment(s):";
		s().Location = new Point(166, 401);
		s().Name = "TextBoxExtraFiles";
		s().ReadOnly = true;
		s().Size = new Size(436, 22);
		s().TabIndex = 5;
		s().TabStop = false;
		s().Text = "(Screenshot or other file)";
		t().Location = new Point(608, 400);
		t().Name = "ButtonBrowseForScreenshot";
		t().Size = new Size(76, 24);
		t().TabIndex = 4;
		t().Text = "Browse...";
		ab().SetToolTip(t(), "Browse for files to include in the support request");
		t().UseVisualStyleBackColor = true;
		u().Controls.Add(am());
		u().Controls.Add(an());
		u().Controls.Add(al());
		u().Controls.Add(z());
		u().Controls.Add(aa());
		u().Controls.Add(o());
		u().Controls.Add(t());
		u().Controls.Add(n());
		u().Controls.Add(s());
		u().Controls.Add(r());
		u().Controls.Add(p());
		u().Controls.Add(q());
		u().Location = new Point(12, 111);
		u().Name = "GroupBoxProblemDescription";
		u().Size = new Size(745, 432);
		u().TabIndex = 2;
		u().TabStop = false;
		u().Text = "Problem description";
		am().Location = new Point(688, 400);
		am().Name = "ButtonClearOptionalAttachments";
		am().Size = new Size(51, 24);
		am().TabIndex = 21;
		am().Text = "Clear";
		ab().SetToolTip(am(), "Detach optional attachment file(s)");
		am().UseVisualStyleBackColor = true;
		an().Location = new Point(166, 371);
		an().Name = "ButtonEditAutoAttachments";
		an().Size = new Size(80, 24);
		an().TabIndex = 20;
		an().Text = "Edit...";
		ab().SetToolTip(an(), "Enable/Disable automatic attachment of system information files");
		an().UseVisualStyleBackColor = true;
		al().AutoSize = true;
		al().Location = new Point(14, 375);
		al().Name = "Label1";
		al().Size = new Size(145, 16);
		al().TabIndex = 19;
		al().Text = "Automatic attachments:";
		z().AcceptsReturn = true;
		z().Location = new Point(166, 58);
		z().Multiline = true;
		z().Name = "TextBoxStepsToDuplicate";
		z().ScrollBars = ScrollBars.Vertical;
		z().Size = new Size(550, 169);
		z().TabIndex = 2;
		z().Text = "(If possible, please describe the steps required to duplicate the problem.  Otherwise, please tell us what actions immediately preceded the problem.)";
		z().e(A_0: false);
		aa().Location = new Point(27, 52);
		aa().Name = "Label9";
		aa().Size = new Size(133, 35);
		aa().TabIndex = 10;
		aa().Text = "Steps to duplicate:";
		aa().TextAlign = ContentAlignment.MiddleRight;
		o().Location = new Point(166, 21);
		o().Name = "TextBoxProblemSummary";
		o().Size = new Size(550, 22);
		o().TabIndex = 1;
		o().Text = "(e.g. Measurement Failure)";
		ab().SetToolTip(o(), "This will appear in the subject line of the E-mail message containing the support request");
		o().e(A_0: false);
		q().AcceptsReturn = true;
		q().Location = new Point(166, 233);
		q().Multiline = true;
		q().Name = "TextBoxDetails";
		q().ScrollBars = ScrollBars.Vertical;
		q().Size = new Size(550, 132);
		q().TabIndex = 3;
		q().Text = "(Please provide any details you think we may need to understand the problem.)";
		q().e(A_0: false);
		v().Controls.Add(af());
		v().Controls.Add(ac());
		v().Controls.Add(w());
		v().Controls.Add(x());
		v().Controls.Add(y());
		v().Location = new Point(12, 12);
		v().Name = "GroupBoxContactInfo";
		v().Size = new Size(745, 93);
		v().TabIndex = 1;
		v().TabStop = false;
		v().Text = "Contact information";
		af().Location = new Point(166, 24);
		af().Name = "TextBoxName";
		af().Size = new Size(550, 22);
		af().TabIndex = 1;
		ab().SetToolTip(af(), "Your first and last names");
		af().e(A_0: false);
		ac().Location = new Point(659, 54);
		ac().Name = "ButtonTestEmail";
		ac().Size = new Size(57, 24);
		ac().TabIndex = 9;
		ac().TabStop = false;
		ac().Text = "Test...";
		ab().SetToolTip(ac(), "Send a test message to your e-mail address to verify Internet connectivity");
		ac().UseVisualStyleBackColor = true;
		w().Location = new Point(166, 55);
		w().Name = "TextBoxEmailAddress";
		w().Size = new Size(475, 22);
		w().TabIndex = 4;
		ab().SetToolTip(w(), "Your email address");
		w().e(A_0: false);
		x().AutoSize = true;
		x().Location = new Point(115, 58);
		x().Name = "Label6";
		x().Size = new Size(49, 16);
		x().TabIndex = 12;
		x().Text = "E-mail:";
		y().AutoSize = true;
		y().Location = new Point(116, 27);
		y().Name = "Label5";
		y().Size = new Size(48, 16);
		y().TabIndex = 10;
		y().Text = "Name:";
		ab().AutoPopDelay = 5000;
		ab().InitialDelay = 1;
		ab().ReshowDelay = 1;
		ak().Enabled = false;
		ak().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ak().Location = new Point(403, 19);
		ak().Margin = new Padding(4);
		ak().Name = "ButtonSubmit";
		ak().Size = new Size(78, 28);
		ak().TabIndex = 15;
		ak().Text = "Submit";
		ab().SetToolTip(ak(), "Send support request to Filmetrics using Internet connection");
		ak().UseVisualStyleBackColor = true;
		ad().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ad().Location = new Point(19, 19);
		ad().Name = "ButtonCreateFile";
		ad().Size = new Size(196, 28);
		ad().TabIndex = 5;
		ad().Text = "Create E-mailable File...";
		ad().UseVisualStyleBackColor = true;
		ae().DialogResult = DialogResult.Cancel;
		ae().Location = new Point(350, 567);
		ae().Name = "ButtonClose";
		ae().Size = new Size(116, 27);
		ae().TabIndex = 12;
		ae().TabStop = false;
		ae().Text = "Close";
		ae().UseVisualStyleBackColor = true;
		ag().Controls.Add(ad());
		ag().Location = new Point(523, 548);
		ag().Name = "GroupBoxDisconnectedMethod";
		ag().Size = new Size(234, 57);
		ag().TabIndex = 15;
		ag().TabStop = false;
		ag().Text = "Internet-disconnected submission";
		ah().Controls.Add(ai());
		ah().Controls.Add(aj());
		ah().Controls.Add(ak());
		ah().Location = new Point(12, 548);
		ah().Name = "GroupBoxConnectedMethod";
		ah().Size = new Size(498, 57);
		ah().TabIndex = 16;
		ah().TabStop = false;
		ah().Text = "Internet-connected submission";
		ai().DropDownStyle = ComboBoxStyle.DropDownList;
		ai().Enabled = false;
		ai().FormattingEnabled = true;
		ai().Items.AddRange(new object[1] { "Updating..." });
		ai().Location = new Point(131, 21);
		ai().Name = "ComboBoxSupportProviders";
		ai().Size = new Size(259, 24);
		ai().TabIndex = 17;
		aj().AutoSize = true;
		aj().Location = new Point(17, 24);
		aj().Name = "Label15";
		aj().Size = new Size(111, 16);
		aj().TabIndex = 16;
		aj().Text = "Support provider:";
		ao().ContainerControl = this;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = SystemColors.Window;
		base.CancelButton = ae();
		base.ClientSize = new Size(769, 616);
		base.Controls.Add(ah());
		base.Controls.Add(ag());
		base.Controls.Add(ae());
		base.Controls.Add(v());
		base.Controls.Add(u());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogTechnicalSupport";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Request Technical Support";
		ab().SetToolTip(this, componentResourceManager.GetString("$this.ToolTip"));
		u().ResumeLayout(performLayout: false);
		u().PerformLayout();
		v().ResumeLayout(performLayout: false);
		v().PerformLayout();
		ag().ResumeLayout(performLayout: false);
		ah().ResumeLayout(performLayout: false);
		ah().PerformLayout();
		((ISupportInitialize)ao()).EndInit();
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label n()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx o()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hx A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label p()
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
	internal virtual hx q()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(hx A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label r()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox s()
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
	internal virtual Button t()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = h;
		Button button = this.m_h;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_h = A_0;
		button = this.m_h;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox u()
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
	internal virtual GroupBox v()
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
	internal virtual hx w()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(hx A_0)
	{
		EventHandler value = a;
		hx hx2 = this.m_k;
		if (hx2 != null)
		{
			hx2.TextChanged -= value;
		}
		this.m_k = A_0;
		hx2 = this.m_k;
		if (hx2 != null)
		{
			hx2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label x()
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
	internal virtual Label y()
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
	internal virtual hx z()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(hx A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aa()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip ab()
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
	internal virtual Button ac()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = c;
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
	internal virtual Button ad()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = f;
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
	internal virtual Button ae()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Button A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx af()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(hx A_0)
	{
		EventHandler value = b;
		hx hx2 = this.m_t;
		if (hx2 != null)
		{
			hx2.TextChanged -= value;
		}
		this.m_t = A_0;
		hx2 = this.m_t;
		if (hx2 != null)
		{
			hx2.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ag()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(GroupBox A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ah()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(GroupBox A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox ai()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aj()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Label A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ak()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Button A_0)
	{
		EventHandler value = d;
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
	internal virtual Label al()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Label A_0)
	{
		this.m_z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button am()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Button A_0)
	{
		EventHandler value = g;
		Button button = this.m_aa;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_aa = A_0;
		button = this.m_aa;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button an()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Button A_0)
	{
		EventHandler value = e;
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
	internal virtual ErrorProvider ao()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ErrorProvider A_0)
	{
		this.m_ac = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void b(b A_0)
	{
		b b10 = bl;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Combine(b11, A_0);
			b10 = Interlocked.CompareExchange(ref bl, value, b11);
		}
		while ((object)b10 != b11);
	}

	[SpecialName]
	[CompilerGenerated]
	private void a(b A_0)
	{
		b b10 = bl;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Remove(b11, A_0);
			b10 = Interlocked.CompareExchange(ref bl, value, b11);
		}
		while ((object)b10 != b11);
	}

	public dw()
	{
		this.m_am = false;
		bc = new dv.a();
		bj = new Collection<string>();
		bm = false;
		m();
	}

	public dw(fz A_0)
		: this()
	{
		this.m_ai = A_0;
	}

	private bool b(string A_0)
	{
		Collection<a5> a_ = new Collection<a5>();
		if (bc.j)
		{
			global::a5.f(a0, a_);
			if (!string.IsNullOrEmpty(az))
			{
				global::a5.f(az, a_);
			}
		}
		if (bc.a)
		{
			global::a5.f(a1, a_);
		}
		if (bc.g)
		{
			foreach (string item in a2)
			{
				global::a5.f(item, a_);
			}
		}
		if (bc.p)
		{
			global::a5.f(a5, a_);
		}
		if (bc.p)
		{
			global::a5.f(a6, a_);
		}
		if (bc.m)
		{
			global::a5.f(a8, a_);
		}
		if (bc.d)
		{
			global::a5.f(a9, a_);
		}
		if (ba != null && ba.GetUpperBound(0) >= 0)
		{
			long num = 0L;
			string[] array = ba;
			foreach (string text in array)
			{
				global::a5.f(text, a_);
				num = checked(num + new FileInfo(text).Length);
			}
			if (num > 3145728)
			{
				fe.b(this.m_ai, "Total size of extra files is " + i3.a(num).ToString("0.##") + "MB, Maximum permitted size is " + i3.a(num).ToString("0.##") + " MB.", i6.a(this));
				return false;
			}
		}
		if (bc.s)
		{
			global::a5.f(a7, a_);
		}
		if (bc.v)
		{
			foreach (string item2 in a3)
			{
				global::a5.f(item2, a_);
			}
		}
		if (bc.aa)
		{
			foreach (string item3 in a4)
			{
				global::a5.f(item3, a_);
			}
		}
		string text2 = bb + "\\TSR Summary.txt";
		StreamWriter streamWriter = new StreamWriter(text2);
		streamWriter.Write(e());
		streamWriter.Close();
		global::a5.f(text2, a_);
		if (!A_0.ToLower().EndsWith(".fitsa"))
		{
			A_0 += ".fitsa";
		}
		global::a5.d(A_0, a_);
		return true;
	}

	private void a(bool A_0)
	{
		v().Enabled = A_0;
		u().Enabled = A_0;
		ah().Enabled = A_0;
		ag().Enabled = A_0;
		Refresh();
	}

	private f a(h A_0, int A_1)
	{
		if (this.m_al && !A_0.t())
		{
			return A_0.a((int)this.m_ak[A_1]);
		}
		return A_0.a(0);
	}

	private string l()
	{
		int[] array = this.m_af.un(this.m_ae);
		bool[] a_ = this.m_af.uo(this.m_ae);
		int num = array?.GetUpperBound(0) ?? (-1);
		string text = "Hardware Settings:\r\n";
		hg hg2 = this.m_af.t0(this.m_ad);
		g2.a a_2 = this.m_af.u8(this.m_ae);
		text = text + "Optics Config: " + g2.n(a_2) + "\r\n";
		int num2 = num;
		checked
		{
			int A_ = default(int);
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (!a(num, hg2.b8(), num3))
				{
					continue;
				}
				text = text + "\r\n\r\nSubsystem Index: " + Conversions.ToString(num3) + "\r\n";
				f a_3 = a(hg2.b8(), num3);
				int num4 = array[num3] - 1;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					if (!a(a_3, array, a_, num3, num5))
					{
						continue;
					}
					bool flag;
					if (array[num3] > 1)
					{
						if (num5 == 0)
						{
							text += "\r\nShort Wavelength Spectrometer Data:\r\n";
							flag = true;
						}
						else
						{
							text += "\r\nLong Wavelength Spectrometer Data:\r\n";
							flag = false;
						}
					}
					else
					{
						text += "Spectrometer Data:\r\n";
						flag = true;
					}
					a9 a10 = new a9();
					this.m_af.m2(this.m_ae, num3, ref a10.d, ref a10.e, ref a10.q, ref a10.r, ref A_);
					a10.o = A_ == 2;
					this.m_af.m2(this.m_ae, num3, ref a10.f, ref a10.g, ref a10.s, ref a10.t, ref a10.h, ref a10.i, ref a10.u, ref a10.v, ref a10.j, ref a10.k, ref a10.w, ref a10.x, ref a10.l, ref a10.m, ref a10.y, ref a10.z, ref a10.n, ref a10.aa);
					double num6;
					int num7;
					float num8;
					float num9;
					double num10;
					if (flag)
					{
						num6 = a10.d;
						num7 = a10.e;
						num8 = a10.j;
						num9 = a10.l;
						num10 = a10.n;
					}
					else
					{
						num6 = a10.q;
						num7 = a10.r;
						num8 = a10.w;
						num9 = a10.y;
						num10 = a10.aa;
					}
					text = text + "IntTime: " + Conversions.ToString(num6) + "\r\n";
					text = text + "# Cycles: " + Conversions.ToString(num7) + "\r\n";
					int num11 = ((!flag) ? a10.s.GetUpperBound(0) : a10.f.GetUpperBound(0));
					int num12 = num11;
					for (int num13 = 0; num13 <= num12; num13++)
					{
						float num14 = ((!flag) ? a10.s[num13] : a10.f[num13]);
						text = text + "Reference Spectrum " + num13 + "Peak Intensity: " + Conversions.ToString(num14) + "\r\n";
					}
					text = text + "Background Spectrum Peak Intensity: " + Conversions.ToString(num8) + "\r\n";
					text = text + "Sample Spectrum Peak Intensity: " + Conversions.ToString(num9) + "\r\n";
					text = text + "Sample Spectrum Int. Time: " + Conversions.ToString(num10) + "\r\n";
					string text2 = ((num5 != 0) ? this.m_af.m2(this.m_ae, global::f.b.c, num3) : this.m_af.m2(this.m_ae, global::f.b.b, num3));
					text = text + "Reference material: \"" + text2 + "\"\r\n";
					a10 = null;
				}
			}
			return text;
		}
	}

	private void a(object A_0)
	{
		checked
		{
			try
			{
				try
				{
					bb = i3.o() + "\\TechSupport";
					if (Directory.Exists(bb))
					{
						Directory.Delete(bb, recursive: true);
					}
					Directory.CreateDirectory(bb);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex3 = ex2;
					this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport while attempting to update textboxes and create support directory.");
					ProjectData.ClearProjectError();
				}
				try
				{
					a0 = i7.c(string.Empty);
					string text = a0;
					if (this.m_af != null && this.m_af.uh(this.m_ae))
					{
						Collection<string> collection = this.m_af.ue(this.m_ae);
						if (collection.Count > 0)
						{
							az = i7.c(collection[0]);
							if (!File.Exists(az))
							{
								az = null;
							}
							if (!string.IsNullOrEmpty(az))
							{
								text = text + "\r\n" + az;
							}
						}
						collection = null;
					}
					bc.k = Path.GetFileName(a0);
					if (!string.IsNullOrEmpty(az))
					{
						ref string reference = ref bc.k;
						reference = reference + "; " + Path.GetFileName(az);
					}
					bc.l = text;
					bc.j = !string.IsNullOrEmpty(bc.k);
				}
				catch (Exception ex4)
				{
					ProjectData.SetProjectError(ex4);
					Exception ex5 = ex4;
					this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport while attempting to get system info file.");
					ProjectData.ClearProjectError();
				}
				BinaryWriter binaryWriter = null;
				BinaryReader binaryReader = null;
				try
				{
					binaryReader = new BinaryReader(File.OpenRead(this.m_ai.d()));
					a1 = this.m_ai.d();
					if (binaryReader.BaseStream.Length > 1000000)
					{
						long offset = binaryReader.BaseStream.Length - 1000000;
						binaryReader.BaseStream.Seek(offset, SeekOrigin.Begin);
						byte[] buffer = binaryReader.ReadBytes(1000002);
						string text2 = a1;
						a1 = bb + "\\Partial_" + text2.Substring(text2.LastIndexOf("\\") + 1);
						text2 = null;
						binaryWriter = new BinaryWriter(File.Open(a1, FileMode.Create, FileAccess.ReadWrite));
						binaryWriter.Write(buffer);
						binaryWriter.Close();
					}
					else
					{
						global::c.e().FileSystem.CopyFile(a1, bb + "\\" + Path.GetFileName(a1));
					}
					binaryReader.Close();
					bc.b = Path.GetFileName(a1);
					bc.c = a1;
					bc.a = !string.IsNullOrEmpty(bc.b);
				}
				catch (Exception ex6)
				{
					ProjectData.SetProjectError(ex6);
					Exception ex7 = ex6;
					this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport while attempting to get log file.");
					ProjectData.ClearProjectError();
				}
				finally
				{
					binaryWriter?.Close();
					binaryReader?.Close();
				}
				int[] array = null;
				hg hg2 = null;
				float[] a_ = null;
				h.f[] a_2 = null;
				int num = default(int);
				try
				{
					bc.h = string.Empty;
					if (this.m_af != null)
					{
						hg2 = this.m_af.t0(this.m_ad);
						a2 = new Collection<string>();
						string text = "";
						array = this.m_af.un(this.m_ae);
						a_2 = this.m_af.vb(this.m_ae);
						a_ = this.m_af.vc(this.m_ae);
						num = array?.GetUpperBound(0) ?? (-1);
						string text3 = "";
						bool[] a_3 = this.m_af.uo(this.m_ae);
						int num2 = num;
						for (int num3 = 0; num3 <= num2; num3++)
						{
							string text4 = a(num, a_2, a_, num3);
							if (!a(num, hg2.b8(), num3))
							{
								continue;
							}
							f a_4 = a(hg2.b8(), num3);
							int num4 = array[num3] - 1;
							for (int num5 = 0; num5 <= num4; num5++)
							{
								if (!a(a_4, array, a_3, num3, num5))
								{
									continue;
								}
								string text5 = a(array, num3, num5);
								f.b b10 = a(num5);
								int num6 = this.m_af.m2(this.m_ad, h6.b.b, num3, b10) - 1;
								if (this.m_af.s8(this.m_ae, this.m_ah) || this.m_af.s6(this.m_ae, this.m_ah))
								{
									if (this.m_af.wo(this.m_ae) && this.m_af.vb(this.m_ae)[num3] != global::h.f.b)
									{
										hr hr2 = this.m_af.m2(this.m_ad, num3, num5 == 0);
										string A_1 = bb + "\\SampleSpec" + text4 + text5 + ".fmspe";
										hr2.k(ref A_1, hr2.bz(), hr2.by());
										hr2 = null;
										if (!string.IsNullOrEmpty(bc.h))
										{
											bc.h += "\r\n";
											text += "\r\n";
										}
										bc.h += Path.GetFileName(A_1);
										text += A_1;
										a2.Add(A_1);
									}
									if (this.m_af.s8(this.m_ae, this.m_ah))
									{
										int num7 = num6;
										for (int num8 = 0; num8 <= num7; num8++)
										{
											text3 = a(num6, num8);
											hr hr3 = this.m_af.m2(this.m_ad, num3, num5 == 0, num8);
											string A_1 = bb + "\\RefSpec" + text4 + text5 + text3 + ".fmspe";
											hr3.k(ref A_1, hr3.bz(), hr3.by());
											hr3 = null;
											if (!string.IsNullOrEmpty(bc.h))
											{
												bc.h += "\r\n";
												text += "\r\n";
											}
											bc.h += Path.GetFileName(A_1);
											text += A_1;
											a2.Add(A_1);
										}
										if (hg2.d0().c() == g2.a.n && this.m_af.sm(this.m_ae, num3, b10))
										{
											hr hr4 = this.m_af.m2(this.m_ae, num3, num5 == 0);
											string A_1 = bb + "\\TransCurvedRSpec" + text4 + text5 + ".fmspe";
											hr4.k(ref A_1, hr4.bz(), hr4.by());
											hr4 = null;
											if (!string.IsNullOrEmpty(bc.h))
											{
												bc.h += "\r\n";
												text += "\r\n";
											}
											bc.h += Path.GetFileName(A_1);
											a2.Add(A_1);
											text += A_1;
										}
									}
									if (this.m_af.s6(this.m_ae, this.m_ah))
									{
										hr hr5 = this.m_af.qh(this.m_ad, num3, num5 == 0);
										string A_1 = bb + "\\BacSpec" + text4 + text5 + ".fmspe";
										hr5.k(ref A_1, hr5.bz(), hr5.by());
										hr5 = null;
										if (!string.IsNullOrEmpty(bc.h))
										{
											bc.h += "\r\n";
											text += "\r\n";
										}
										bc.h += Path.GetFileName(A_1);
										a2.Add(A_1);
										text += A_1;
									}
								}
								string text6 = this.m_af.m2(this.m_ad, num3, b10);
								if (File.Exists(text6))
								{
									string A_1 = bb + "\\PendingSample" + text4 + text5 + ".fmspe";
									File.Copy(text6, A_1);
									if (!string.IsNullOrEmpty(bc.h))
									{
										bc.h += "\r\n";
										text += "\r\n";
									}
									bc.h += Path.GetFileName(A_1);
									a2.Add(A_1);
									text += A_1;
								}
								int num9 = num6;
								for (int num10 = 0; num10 <= num9; num10++)
								{
									text3 = a(num6, num10);
									text6 = this.m_af.m2(this.m_ad, num3, b10, num10);
									if (File.Exists(text6))
									{
										string A_1 = bb + "\\PendingRef" + text4 + text5 + text3 + ".fmspe";
										File.Copy(text6, A_1);
										if (!string.IsNullOrEmpty(bc.h))
										{
											bc.h += "\r\n";
											text += "\r\n";
										}
										bc.h += Path.GetFileName(A_1);
										a2.Add(A_1);
										text += A_1;
									}
								}
								text6 = this.m_af.p9(this.m_ad, num3, b10);
								if (File.Exists(text6))
								{
									string A_1 = bb + "\\PendingBac" + text4 + text5 + ".fmspe";
									File.Copy(text6, A_1);
									if (!string.IsNullOrEmpty(bc.h))
									{
										bc.h += "\r\n";
										text += "\r\n";
									}
									bc.h += Path.GetFileName(A_1);
									a2.Add(A_1);
									text += A_1;
								}
								text6 = this.m_af.p9(this.m_ad, num3, num5 == 0);
								if (File.Exists(text6))
								{
									string A_1 = bb + "\\RefHist" + text4 + text5 + ".fitrh";
									File.Copy(text6, A_1);
									if (!string.IsNullOrEmpty(bc.h))
									{
										bc.h += "\r\n";
										text += "\r\n";
									}
									bc.h += Path.GetFileName(A_1);
									a2.Add(A_1);
									text += A_1;
								}
							}
						}
						bc.i = text;
						bc.g = !string.IsNullOrEmpty(bc.h);
					}
				}
				catch (Exception ex8)
				{
					ProjectData.SetProjectError(ex8);
					Exception ex9 = ex8;
					this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport while attempting to get baseline files.");
					ProjectData.ClearProjectError();
				}
				StreamWriter streamWriter = null;
				try
				{
					a5 = bb + "\\Settings.txt";
					streamWriter = new StreamWriter(a5);
					streamWriter.Write(j());
					streamWriter.Write("\r\n");
					streamWriter.Write(l());
					bc.q = Path.GetFileName(a5);
					bc.r = a5;
					bc.p = !string.IsNullOrEmpty(bc.q);
				}
				catch (Exception ex10)
				{
					ProjectData.SetProjectError(ex10);
					Exception ex11 = ex10;
					this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport while attempting to write settings file.");
					ProjectData.ClearProjectError();
				}
				finally
				{
					streamWriter?.Close();
				}
				if (this.m_af != null)
				{
					try
					{
						hr hr6 = null;
						if (this.m_ag != null && this.m_ag is hr)
						{
							hr6 = (hr)this.m_ag;
						}
						if (hr6 != null)
						{
							a8 = bb + "\\ActiveSpec (" + i3.g(hr6.b5()) + ").fmspe";
							string empty = string.Empty;
							hr hr7 = hr6;
							hr7.r(A_3: (hr7.bl() != null) ? hr7.bl().by() : string.Empty, A_0: ref a8, A_1: hr7.bz(), A_2: hr7.by(), A_4: null, A_5: null, A_6: false, A_7: false, A_8: false);
							hr7 = null;
							bc.n = Path.GetFileName(a8);
							bc.o = a8;
							bc.m = true;
						}
						else
						{
							bc.n = string.Empty;
							bc.o = string.Empty;
							bc.m = false;
						}
					}
					catch (Exception ex12)
					{
						ProjectData.SetProjectError(ex12);
						Exception ex13 = ex12;
						bc.n = string.Empty;
						bc.o = string.Empty;
						bc.m = false;
						this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport while attempting to get log file.");
						ProjectData.ClearProjectError();
					}
					try
					{
						if (this.m_af.uh(this.m_ae))
						{
							hg hg3 = this.m_af.t0(this.m_ad);
							hg A_2 = new hg(hg3.dh(), hg3.cd());
							hg3.bu(ref A_2);
							string text7 = bb + "\\ActiveRecipe (" + A_2.ci() + ")";
							string text8 = text7 + (string)Interaction.IIf(hg3.b5(), ".fitra", ".fitrp");
							if (A_2.ch(text7 + (string)Interaction.IIf(hg3.b5(), ".fitra", ".fitrp")) != 0)
							{
								fe.b(this.m_ai, "Failure attempting to save recipe to exported files directory. Operation aborted.", i6.a(ak()));
								return;
							}
							string[] a_5 = new string[1] { text8 };
							string[] A_3 = new string[0];
							hg.bu(this.m_ai, hg.g.a, bb, a_5, ref A_3, global::r.d.a.b.a, hg.b4());
							a9 = A_3[0];
							bc.e = Path.GetFileName(a9);
							bc.f = a9;
							bc.d = !string.IsNullOrEmpty(bc.e);
							hg3 = null;
						}
					}
					catch (Exception ex14)
					{
						ProjectData.SetProjectError(ex14);
						Exception ex15 = ex14;
						this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport while attempting to get active recipe.");
						ProjectData.ClearProjectError();
					}
				}
				try
				{
					a7 = bb + "\\CompInfo.txt";
					StreamWriter streamWriter2 = null;
					try
					{
						streamWriter2 = new StreamWriter(a7, append: false, Encoding.UTF8);
						streamWriter2.WriteLine("Operating System: ");
						streamWriter2.WriteLine("  Full Name: " + global::c.e().Info.OSFullName);
						streamWriter2.WriteLine("  Version: " + global::c.e().Info.OSVersion);
						streamWriter2.WriteLine("  64 bit OS?: " + jj.c());
						try
						{
							ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT LastBootUpTime FROM Win32_OperatingSystem WHERE Primary='true'");
							foreach (ManagementObject item2 in managementObjectSearcher.Get())
							{
								DateTime value = ManagementDateTimeConverter.ToDateTime(item2.Properties["LastBootUpTime"].Value.ToString());
								TimeSpan timeSpan = DateTime.Now.Subtract(value);
								int num11 = (int)Math.Round(Math.Floor(timeSpan.TotalDays));
								timeSpan = timeSpan.Subtract(TimeSpan.FromDays(num11));
								int num12 = (int)Math.Round(Math.Floor(timeSpan.TotalHours));
								timeSpan = timeSpan.Subtract(TimeSpan.FromHours(num12));
								int num13 = (int)Math.Round(Math.Floor(timeSpan.TotalMinutes));
								int num14 = (int)Math.Round(Math.Floor(timeSpan.Subtract(TimeSpan.FromMinutes(num13)).TotalSeconds));
								streamWriter2.WriteLine("  Time since system boot: " + num11.ToString().Trim() + " days, " + num12.ToString().Trim() + " hours, " + num13.ToString().Trim() + " minutes, " + num14.ToString().Trim() + " seconds.");
							}
						}
						catch (Exception ex16)
						{
							ProjectData.SetProjectError(ex16);
							Exception ex17 = ex16;
							streamWriter2.WriteLine("  Boot Time Query failed");
							ProjectData.ClearProjectError();
						}
						streamWriter2.WriteLine();
						streamWriter2.WriteLine("Memory: ");
						streamWriter2.WriteLine("  Physical Memory: " + i3.b((long)global::c.e().Info.TotalPhysicalMemory).ToString("0.00", CultureInfo.InvariantCulture) + "GB");
						streamWriter2.WriteLine("  Virtual Memory: " + i3.b((long)global::c.e().Info.TotalVirtualMemory).ToString("0.00", CultureInfo.InvariantCulture) + "GB");
						streamWriter2.WriteLine("  Memory Used by this process: " + i3.a(Environment.WorkingSet).ToString("0.0") + "MB");
						streamWriter2.WriteLine("  Available Physical Memory: " + i3.b((long)global::c.e().Info.AvailablePhysicalMemory).ToString("0.00", CultureInfo.InvariantCulture) + "GB");
						streamWriter2.WriteLine("  Available Virtual Memory: " + i3.b((long)global::c.e().Info.AvailableVirtualMemory).ToString("0.00", CultureInfo.InvariantCulture) + "GB");
						streamWriter2.WriteLine("  Process Running as 64 bit?: " + jj.b());
						streamWriter2.WriteLine();
						streamWriter2.WriteLine("Display: ");
						streamWriter2.WriteLine("  # Display screens: " + Conversions.ToString(Screen.AllScreens.Length));
						int num15 = Screen.AllScreens.Length - 1;
						for (int num16 = 0; num16 <= num15; num16++)
						{
							streamWriter2.WriteLine("  Screen #" + (num16 + 1).ToString().Trim() + " bounds: " + Screen.AllScreens[num16].Bounds.ToString());
							streamWriter2.WriteLine("    Bits per pixel: " + Screen.AllScreens[0].BitsPerPixel);
						}
						try
						{
							ManagementObjectSearcher managementObjectSearcher2 = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
							foreach (ManagementObject item3 in managementObjectSearcher2.Get())
							{
								streamWriter2.WriteLine("  Video Controller Name: " + item3["Name"].ToString());
								streamWriter2.WriteLine("  Video Controller Caption: " + item3["Caption"].ToString());
								streamWriter2.WriteLine("  Video Controller VideoModeDescription: " + item3["VideoModeDescription"].ToString());
								streamWriter2.WriteLine("  Video Controller Driver Version: " + item3["DriverVersion"].ToString());
								streamWriter2.WriteLine("  Video Controller Inf Filename: " + item3["InfFilename"].ToString());
							}
						}
						catch (Exception ex18)
						{
							ProjectData.SetProjectError(ex18);
							Exception ex19 = ex18;
							streamWriter2.WriteLine("  Video controller not detected");
							ProjectData.ClearProjectError();
						}
						streamWriter2.WriteLine();
						streamWriter2.WriteLine("Computer: ");
						streamWriter2.WriteLine("  Name: " + global::c.e().Name);
						try
						{
							streamWriter2.WriteLine("  Processor details:");
							ManagementObjectSearcher managementObjectSearcher3 = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
							foreach (ManagementObject item4 in managementObjectSearcher3.Get())
							{
								streamWriter2.WriteLine("    Name: " + item4["Name"].ToString());
								streamWriter2.WriteLine("    Caption: " + item4["Caption"].ToString());
								streamWriter2.WriteLine("    Max Clock Speed: " + (Conversions.ToSingle(item4["MaxClockSpeed"].ToString()) / 1000f).ToString(CultureInfo.InvariantCulture) + "GHz");
								streamWriter2.WriteLine("    # cores: " + item4["NumberOfCores"].ToString());
								streamWriter2.WriteLine("    # logical Processors: " + item4["NumberOfLogicalProcessors"].ToString());
							}
						}
						catch (Exception ex20)
						{
							ProjectData.SetProjectError(ex20);
							Exception ex21 = ex20;
							streamWriter2.WriteLine("    Processor details unavailable");
							ProjectData.ClearProjectError();
						}
						streamWriter2.WriteLine();
						try
						{
							streamWriter2.WriteLine("User account environment information: ");
							streamWriter2.WriteLine("  Running as Admin: " + jj.e.c());
							streamWriter2.WriteLine("  Can elevate to Admin: " + jj.e.b());
							streamWriter2.WriteLine("  UI Culture English Name: " + global::c.e().Info.InstalledUICulture.EnglishName);
							streamWriter2.WriteLine("  UI Culture Name: " + global::c.e().Info.InstalledUICulture.TwoLetterISOLanguageName);
							streamWriter2.WriteLine("  User Name: " + Environment.UserName);
							streamWriter2.WriteLine("  User Domain Name: " + Environment.UserDomainName);
							WindowsIdentity current = WindowsIdentity.GetCurrent();
							streamWriter2.WriteLine("    Account details: ");
							streamWriter2.WriteLine("    Name: " + current.Name);
							streamWriter2.WriteLine("    Anonymous?: " + Conversions.ToString(current.IsAnonymous));
							streamWriter2.WriteLine("    Authenticated?: " + Conversions.ToString(current.IsAuthenticated));
							streamWriter2.WriteLine("    System?: " + Conversions.ToString(current.IsSystem));
							streamWriter2.WriteLine("    Guest?: " + Conversions.ToString(current.IsGuest));
							streamWriter2.WriteLine("    Authentication type?: " + current.AuthenticationType);
							streamWriter2.WriteLine("    Impersonation level: " + current.ImpersonationLevel);
							streamWriter2.WriteLine("    SID: " + current.Owner.Translate(typeof(NTAccount)).ToString());
							streamWriter2.WriteLine("    Member of the following groups:");
							foreach (IdentityReference group in current.Groups)
							{
								streamWriter2.WriteLine("      " + group.Translate(typeof(NTAccount)).ToString());
							}
							current = null;
						}
						catch (Exception ex22)
						{
							ProjectData.SetProjectError(ex22);
							Exception ex23 = ex22;
							streamWriter2.WriteLine("    Remaining user account details are unavailable");
							ProjectData.ClearProjectError();
						}
						streamWriter2.WriteLine();
						streamWriter2.WriteLine("CLR Version: " + Environment.Version.ToString());
						streamWriter2.WriteLine();
						streamWriter2.WriteLine("Storage Details: ");
						streamWriter2.WriteLine("  Drive containing All Users folder: " + Path.GetPathRoot(global::c.e().FileSystem.SpecialDirectories.AllUsersApplicationData));
						try
						{
							ManagementObjectSearcher managementObjectSearcher4 = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");
							foreach (ManagementObject item5 in managementObjectSearcher4.Get())
							{
								if (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(item5["MediaType"])), "12", TextCompare: false) == 0)
								{
									streamWriter2.WriteLine("  Storage information: DeviceID = " + item5["DeviceID"].ToString() + ", Size = " + i3.b(Conversions.ToLong(item5["Size"].ToString())).ToString("0.0", CultureInfo.InvariantCulture) + " GB, FreeSpace=" + i3.b(Conversions.ToLong(item5["FreeSpace"].ToString())).ToString("0.0", CultureInfo.InvariantCulture) + " GB.");
								}
							}
						}
						catch (Exception ex24)
						{
							ProjectData.SetProjectError(ex24);
							Exception ex25 = ex24;
							streamWriter2.WriteLine("  Available disk space failed");
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception ex26)
					{
						ProjectData.SetProjectError(ex26);
						Exception ex27 = ex26;
						streamWriter2.WriteLine("**Error - some statement in compInfo section threw an exception");
						ProjectData.ClearProjectError();
					}
					finally
					{
						streamWriter2?.Close();
					}
					bc.t = Path.GetFileName(a7);
					bc.u = a7;
					bc.s = !string.IsNullOrEmpty(bc.t);
				}
				catch (Exception ex28)
				{
					ProjectData.SetProjectError(ex28);
					Exception ex29 = ex28;
					this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport while attempting to get computer info.");
					ProjectData.ClearProjectError();
				}
				try
				{
					string[] array2 = null;
					bool flag = false;
					string text9 = null;
					string text10 = null;
					string A_4 = null;
					Collection<Collection<string>> collection2 = new Collection<Collection<string>>();
					string A_5 = null;
					Collection<Guid> collection3;
					if (this.m_af != null)
					{
						collection3 = this.m_af.tj();
						foreach (Guid item6 in collection3)
						{
							Collection<string> item = this.m_af.ue(item6);
							collection2.Add(item);
						}
					}
					else
					{
						collection3 = new Collection<Guid>();
					}
					a3 = new Collection<string>();
					string text = string.Empty;
					int num17 = 0;
					bool A_6 = default(bool);
					i7.e A_7 = default(i7.e);
					bool flag3 = default(bool);
					do
					{
						array2 = ((num17 == 0) ? ((!Directory.Exists(global::a1.d())) ? new string[0] : Directory.GetFiles(global::a1.d())) : ((!Directory.Exists(global::a1.c())) ? new string[0] : Directory.GetFiles(global::a1.c())));
						string[] array3 = array2;
						foreach (string text11 in array3)
						{
							text10 = Path.GetFileName(text11);
							global::a2.a.c(text10, ref A_6, ref A_7, ref A_4);
							Guid guid = default(Guid);
							bool flag2;
							if (A_7 == i7.e.l)
							{
								flag2 = false;
							}
							else
							{
								flag3 = false;
								if (A_6 && Operators.CompareString(A_4, null, TextCompare: false) != 0)
								{
									flag2 = false;
									int num19 = collection3.Count - 1;
									for (int num20 = 0; num20 <= num19; num20++)
									{
										Collection<string> item = collection2[num20];
										foreach (string item7 in item)
										{
											if (Operators.CompareString(item7, A_4, TextCompare: false) == 0)
											{
												flag2 = true;
												guid = collection3[num20];
												break;
											}
										}
										if (flag2)
										{
											break;
										}
									}
								}
								else
								{
									flag2 = true;
								}
							}
							if (!A_6 || !flag2)
							{
								continue;
							}
							flag = true;
							if (!string.IsNullOrEmpty(bc.w))
							{
								bc.w += "\r\n";
								text += "\r\n";
								text9 += "\r\n";
							}
							else if (string.IsNullOrEmpty(text9))
							{
								text9 = "Date = " + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "\r\n";
							}
							bc.w += text10;
							a3.Add(text11);
							text += text11;
							string text12;
							if (flag3)
							{
								text12 = ((!((i7.b)this.m_af.u7()).c()) ? "No SASW license is fully valid" : "At least one SASW license is fully valid");
							}
							else
							{
								if (guid != default(Guid) && this.m_af != null)
								{
									this.m_af.m2(guid, ref A_4, ref A_5);
								}
								else
								{
									A_5 = null;
								}
								text12 = ((A_4 != null) ? global::a2.a.c(A_4, A_5, A_7).ToString() : global::a2.a.c(i7.e(), "SaSwSn", A_7).ToString());
							}
							text9 = text9 + Path.GetFileNameWithoutExtension(text10) + " valid = " + text12;
						}
						num17++;
					}
					while (num17 < 2);
					if (!string.IsNullOrEmpty(text9))
					{
						string text13 = bb + "\\LicRepData.fiblr";
						e3.a obj = new e3.a();
						obj.g = text9;
						obj.b(text13);
						_ = null;
						text = text + "\r\n" + text13;
						bc.w += "\r\nLicRepData.fiblr";
						a3.Add(text13);
					}
					bc.x = text;
					bc.v = flag;
					if (this.m_af.ui())
					{
						string text14 = i3.m() + "\\ZareDebug.txt";
						if (File.Exists(text14))
						{
							a3.Add(text14);
						}
						string text15 = i3.m() + "\\SolveInternDebug.txt";
						if (File.Exists(text15))
						{
							a3.Add(text15);
						}
					}
				}
				catch (Exception ex30)
				{
					ProjectData.SetProjectError(ex30);
					Exception ex31 = ex30;
					this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport while attempting to get license files.");
					ProjectData.ClearProjectError();
				}
				a6 = bb + "\\ModuleConfig.csv";
				StreamWriter streamWriter3 = null;
				try
				{
					streamWriter3 = new StreamWriter(a6, append: false, Encoding.UTF8);
					streamWriter3.Write("\"Device Name\",\"Module Name\",\"Module Guid\"\r\n");
					gz gz2 = this.m_af.ti();
					if (gz2 != null)
					{
						foreach (gy item8 in gz2.i())
						{
							foreach (ip.a item9 in item8.ak())
							{
								streamWriter3.Write("\"" + item9.w() + "\",\"" + item8.u() + "\",\"" + item8.x() + "\"\r\n");
							}
						}
						foreach (ip.a item10 in gz2.k())
						{
							streamWriter3.Write("\"" + item10.w() + "\",\"None\",\"None\"\r\n");
						}
						if (!string.IsNullOrEmpty(bc.q))
						{
							bc.q += "; ";
						}
						bc.q += Path.GetFileName(a6);
						bc.r = a5 + "\r\n" + a6;
						bc.p = !string.IsNullOrEmpty(bc.q);
					}
				}
				catch (Exception ex32)
				{
					ProjectData.SetProjectError(ex32);
					Exception ex33 = ex32;
					this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport while attempting to get measModuleConfig.");
					ProjectData.ClearProjectError();
				}
				finally
				{
					streamWriter3?.Close();
				}
				try
				{
					bc.ab = string.Empty;
					if (this.m_af != null)
					{
						bool[] a_6 = this.m_af.uo(this.m_ae);
						a4 = new Collection<string>();
						string text = string.Empty;
						int num21 = num;
						for (int num22 = 0; num22 <= num21; num22++)
						{
							string text4 = a(num, a_2, a_, num22);
							if (!a(num, hg2.b8(), num22))
							{
								continue;
							}
							f a_7 = a(hg2.b8(), num22);
							int num23 = array[num22] - 1;
							for (int num24 = 0; num24 <= num23; num24++)
							{
								if (!a(a_7, array, a_6, num22, num24))
								{
									continue;
								}
								string text5 = a(array, num22, num24);
								string text16 = this.m_af.sj(this.m_ae, num22, a(num24));
								if (File.Exists(text16))
								{
									string A_1 = bb + "\\WavelenCalDeltaDeltaLog" + text4 + text5 + Path.GetExtension(text16);
									File.Copy(text16, A_1);
									if (!string.IsNullOrEmpty(bc.ab))
									{
										bc.ab += "\r\n";
										text += "\r\n";
									}
									bc.ab += Path.GetFileName(A_1);
									a4.Add(A_1);
									text += A_1;
								}
							}
						}
						bc.ac = text;
						bc.aa = !string.IsNullOrEmpty(bc.ab);
					}
				}
				catch (Exception ex34)
				{
					ProjectData.SetProjectError(ex34);
					Exception ex35 = ex34;
					this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport while attempting to get wavelen cal log files.");
					ProjectData.ClearProjectError();
				}
				bl?.Invoke();
			}
			catch (Exception ex36)
			{
				ProjectData.SetProjectError(ex36);
				Exception a_8 = ex36;
				this.m_ai.c(fz.b.b, "Error attempting to update support providers in DialogTechnicalSupport.PopulateSupportFileMembers", a_8);
				ProjectData.ClearProjectError();
			}
		}
	}

	private string a(int A_0, h.f[] A_1, float[] A_2, int A_3)
	{
		string result = string.Empty;
		if (A_0 > 0)
		{
			result = "_";
			result = ((A_1[A_3] == global::h.f.a) ? (result + "R0") : ((A_1[A_3] != global::h.f.b) ? (result + "R" + A_2[A_3].ToString("0")) : (result + "T0")));
		}
		return result;
	}

	private string a(int[] A_0, int A_1, int A_2)
	{
		string empty = string.Empty;
		if (A_0[A_1] <= 1)
		{
			return string.Empty;
		}
		string text = ((A_2 != 0) ? "long" : "short");
		return "_" + text;
	}

	private f.b a(int A_0)
	{
		if (A_0 == 0)
		{
			return global::f.b.b;
		}
		return global::f.b.c;
	}

	[SpecialName]
	private string a(int A_0, int A_1)
	{
		if (A_0 > 0)
		{
			return "_" + A_1;
		}
		return "";
	}

	private void k()
	{
		if (!string.IsNullOrEmpty(af().Text))
		{
			base.ActiveControl = o();
		}
		else
		{
			base.ActiveControl = af();
		}
	}

	private string j()
	{
		MySettings mySettings = global::e.a();
		string result = string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("Software Settings:\r\n" + "Spectrum Graph Minimum Wavelength: " + mySettings.GraphMeasXMin[0].ToString(CultureInfo.InvariantCulture) + "\r\n", "Spectrum Graph Maximum Wavelength: ", mySettings.GraphMeasXMax[0].ToString(CultureInfo.InvariantCulture), "\r\n"), "Display # Significant Digits: ", Conversions.ToString(mySettings.DisplaySignificantDigits), "\r\n"), "GraphBackColor: ", fh.a((fh.a)mySettings.GraphBackColor), "\r\n"), "Spectrum Graph AutoscaleYMax: ", mySettings.GraphMeasAutoScaleYMax[0].ToString(CultureInfo.InvariantCulture), "\r\n"), "Spectrum Graph AutoscaleY2Max: ", mySettings.GraphMeasAutoScaleY2Max[0].ToString(CultureInfo.InvariantCulture), "\r\n"), "Spectrum Graph Show Grid: ", mySettings.GraphMeasShowGrid[0].ToString(CultureInfo.InvariantCulture), "\r\n"), "Spectrum Graph Max # Simultaneously Displayed Spectra: ", Conversions.ToString((int)mySettings.GraphMeasUserDefinedMaxCurves), "\r\n"), "Spectrum Graph Display in (%): ", mySettings.GraphMeasYLabelPercent[0].ToString(CultureInfo.InvariantCulture), "\r\n"), "LastOpenSaveExportTargetImportSourcePath: ", mySettings.LastOpenSaveExportTargetImportSourcePath, "\r\n"), "Refl ref Mat: \"", mySettings.LastUsedReflReferenceMaterial, "\"\r\n"), "Trans ref Mat: \"", mySettings.LastUsedTransReferenceMaterial, "\"\r\n"), "Display Color Result: ", mySettings.ShowSpectrumColor.ToString(CultureInfo.InvariantCulture), "\r\n"), "Selected Color Coord System: \"", global::a4.a((a4.a)mySettings.ShowSpectrumCoordOption), "\"\r\n"), "Fix Luminance: ", mySettings.SpectrumColorFixLuminance.ToString(CultureInfo.InvariantCulture), "\r\n"), "Illuminant: \"", global::a4.a((a4.c)mySettings.SpectrumColorIlluminant), "\"\r\n"), "Luminance Value: ", mySettings.SpectrumColorLumValue.ToString(CultureInfo.InvariantCulture), "\r\n"), "Color Observer: \"", global::a4.a((a4.b)mySettings.SpectrumColorObserver), "\"\r\n");
		mySettings = null;
		return result;
	}

	private bool a(f A_0, int[] A_1, bool[] A_2, int A_3, int A_4)
	{
		if (A_1[A_3] != 1 && (A_4 != 0 || A_0.b(A_2[A_3]) == global::f.a.c))
		{
			if (A_4 == 1)
			{
				return A_0.b(A_2[A_3]) != global::f.a.b;
			}
			return false;
		}
		return true;
	}

	private bool a(int A_0, h A_1, int A_2)
	{
		h.e a_ = A_1.a(this.m_aj);
		if (A_0 != 0 && (this.m_ak[A_2] != global::h.f.a || !global::h.p(a_)) && (this.m_ak[A_2] != global::h.f.b || !global::h.n(a_)))
		{
			if (this.m_ak[A_2] == global::h.f.c)
			{
				return global::h.d(a_);
			}
			return false;
		}
		return true;
	}

	private void i()
	{
		MySettings mySettings = global::e.a();
		mySettings.TechSupportUserName = af().Text;
		mySettings.TechSupportUserEmail = w().Text;
		_ = null;
	}

	private void h()
	{
		if (string.IsNullOrEmpty(af().Text.Trim()))
		{
			ao().SetError(af(), "Required");
		}
		else
		{
			ao().SetError(af(), null);
		}
		f();
	}

	private void g()
	{
		if (string.IsNullOrEmpty(w().Text.Trim()))
		{
			ao().SetError(w(), "Required");
		}
		else
		{
			bool flag = false;
			try
			{
				new MailAddress(w().Text, "TestAddr");
				flag = true;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				flag = false;
				ProjectData.ClearProjectError();
			}
			if (flag)
			{
				ao().SetError(w(), null);
			}
			else
			{
				ao().SetError(w(), "Invalid email address format");
			}
		}
		f();
	}

	private void f()
	{
		bool flag = string.IsNullOrEmpty(ao().GetError(af()));
		bool flag2 = string.IsNullOrEmpty(ao().GetError(w()));
		ac().Enabled = flag2;
		ak().Enabled = this.m_am && bm && flag && flag2;
		ad().Enabled = flag && flag2;
		if (flag && flag2)
		{
			ab().SetToolTip(v(), ab().GetToolTip(this));
		}
		else
		{
			ab().SetToolTip(v(), null);
		}
		an().Enabled = bm;
	}

	private string e()
	{
		return "Tech. Support Data: \r\nUser name: " + af().Text + "\r\nCompany name: ~Unknown~\r\nUser e-mail Address: " + w().Text + "\r\n\r\nProgram name: " + global::c.d().Info.ProductName + " v" + global::c.d().Info.Version.ToString() + "\r\n\r\nProblem Summary:\r\n" + o().Text + "\r\n\r\nSteps to Duplicate:\r\n" + z().Text + "\r\n\r\nProblem Details:\r\n" + q().Text;
	}

	private bool d()
	{
		if (string.IsNullOrEmpty(af().Text.Trim()))
		{
			fe.b(this.m_ai, "Missing required information: User Name", i6.a(ak()));
			return false;
		}
		return true;
	}

	private void a(object A_0, bool A_1)
	{
		if (A_1)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)A_0;
			if (httpWebRequest != null)
			{
				httpWebRequest.Abort();
				c();
			}
		}
	}

	private void c()
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new c(c));
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
			this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport.WebRequestFailed.", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b()
	{
		ai().Items.Clear();
		ai().Items.Add("Provider webpage access failure");
		ai().SelectedIndex = 0;
	}

	private void a(string A_0)
	{
		checked
		{
			try
			{
				if (base.InvokeRequired)
				{
					BeginInvoke(new d(a), A_0);
					return;
				}
				int num = 0;
				ai().Items.Clear();
				if (this.m_af != null && this.m_af.ut().a8())
				{
					ComboBox.ObjectCollection items = ai().Items;
					items.Add("FI Internal: Software Group");
					bj.Add("internalsupport@filmetrics.com");
					items.Add("FI Internal: Randy");
					bj.Add("geels@filmetrics.com");
					items.Add("FI Internal: Robert");
					bj.Add("robarr@filmetrics.com");
					items.Add("FI Internal: Guannan");
					bj.Add("gliu@filmetrics.com");
					_ = null;
				}
				num = A_0.IndexOf("<tr", StringComparison.OrdinalIgnoreCase) + 1;
				num = A_0.IndexOf("<tr", num, StringComparison.OrdinalIgnoreCase) + 1;
				do
				{
					num = A_0.IndexOf("<td", num, StringComparison.OrdinalIgnoreCase);
					num = A_0.IndexOf(">", num) + 1;
					string text = A_0.Substring(num);
					string text2 = text.Substring(0, text.IndexOf("</td>", StringComparison.OrdinalIgnoreCase)).Trim();
					text = null;
					num = A_0.IndexOf("<td", num, StringComparison.OrdinalIgnoreCase);
					num = A_0.IndexOf(">", num) + 1;
					string text3 = A_0.Substring(num);
					string text4 = text3.Substring(0, text3.IndexOf("</td>", StringComparison.OrdinalIgnoreCase)).Trim();
					text3 = null;
					num = A_0.IndexOf("<td", num, StringComparison.OrdinalIgnoreCase);
					num = A_0.IndexOf(">", num) + 1;
					string text5 = A_0.Substring(num);
					string text6 = text5.Substring(0, text5.IndexOf("</td>", StringComparison.OrdinalIgnoreCase)).Trim();
					text5 = null;
					int startIndex = text6.IndexOf("mailto:", StringComparison.OrdinalIgnoreCase) + "mailto:".Length;
					string text7 = text6.Substring(startIndex);
					text6 = text7.Substring(0, text7.IndexOf("\""));
					text7 = null;
					string text8 = text6;
					if (text8.Contains("?"))
					{
						text6 = text8.Substring(0, text8.IndexOf("?"));
					}
					text8 = null;
					ai().Items.Add(text2 + ": " + text4);
					bj.Add(text6);
				}
				while (A_0.Substring(num).Contains("<td"));
				ai().Items.Add("Specific Filmetrics Employee");
				bj.Add("");
				if (string.IsNullOrEmpty(global::e.a().TechSupportProvider))
				{
					ai().SelectedIndex = 0;
				}
				else
				{
					ai().SelectedItem = global::e.a().TechSupportProvider;
					if (ai().SelectedIndex == -1)
					{
						ai().SelectedIndex = 0;
					}
				}
				ai().Enabled = true;
				this.m_am = true;
				f();
				k();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport.WebRequestFailed.", a_);
				c();
				ProjectData.ClearProjectError();
			}
		}
	}

	private void b(IAsyncResult A_0)
	{
		try
		{
			a a10 = (a)A_0.AsyncState;
			HttpWebRequest httpWebRequest = a10.d;
			a10.e = (HttpWebResponse)httpWebRequest.EndGetResponse(A_0);
			(a10.f = a10.e.GetResponseStream()).BeginRead(a10.c, 0, 1024, a, a10);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport.WebRespCallback", a_);
			c();
			ProjectData.ClearProjectError();
		}
	}

	private void a(IAsyncResult A_0)
	{
		try
		{
			a a10 = (a)A_0.AsyncState;
			Stream stream = a10.f;
			int num = stream.EndRead(A_0);
			if (num > 0)
			{
				a10.b.Append(Encoding.ASCII.GetString(a10.c, 0, num));
				stream.BeginRead(a10.c, 0, 1024, a, a10);
			}
			else
			{
				stream.Close();
				a10.e.Close();
				a(a10.b.ToString());
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport.WebRespCallback", a_);
			c();
			ProjectData.ClearProjectError();
		}
	}

	public void a(f1 A_0, Guid A_1, object A_2, string A_3, bool A_4)
	{
		this.m_ag = RuntimeHelpers.GetObjectValue(A_2);
		this.m_ah = A_4;
		this.m_af = A_0;
		if (this.m_af != null)
		{
			if (this.m_ag == null && A_1 == default(Guid))
			{
				Collection<Guid> collection = this.m_af.tj();
				if (collection.Count > 0)
				{
					this.m_ae = collection[0];
				}
				collection = null;
			}
			else
			{
				this.m_ae = A_1;
				this.m_al = this.m_af.vm(this.m_ae);
				this.m_aj = this.m_af.va(this.m_ae);
				this.m_ak = this.m_af.vb(this.m_ae);
			}
			this.m_ad = A_1.ToString();
		}
		if (this.m_ai == null)
		{
			throw new Exception("Logger not supplied");
		}
		if (!string.IsNullOrEmpty(A_3))
		{
			o().Text = A_3;
		}
		try
		{
			MySettings mySettings = global::e.a();
			af().Text = mySettings.TechSupportUserName;
			w().Text = mySettings.TechSupportUserEmail;
			mySettings = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport while attempting to update textboxes and create support directory.");
			ProjectData.ClearProjectError();
		}
		b(a);
		ThreadPool.QueueUserWorkItem(a);
		ai().SelectedIndex = 0;
		k();
		h();
		g();
		ab().SetToolTip(v(), ab().GetToolTip(this));
		ab().SetToolTip(u(), ab().GetToolTip(this));
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.filmetrics.com/techsupportproviders.html");
			a a10 = new a();
			httpWebRequest.Proxy = new WebProxy();
			a10.d = httpWebRequest;
			ThreadPool.RegisterWaitForSingleObject(httpWebRequest.BeginGetResponse(b, a10).AsyncWaitHandle, a, httpWebRequest, 60000, executeOnlyOnce: true);
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception a_ = ex4;
			this.m_ai.c(fz.b.b, "Error attempting to update support providers in DialogTechnicalSupport.InitAndShow", a_);
			ProjectData.ClearProjectError();
		}
		ShowDialog();
	}

	private void h(object A_0, EventArgs A_1)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			string text = "";
			openFileDialog.Filter = "All Files (*.*)|*.*";
			openFileDialog.Multiselect = true;
			openFileDialog.InitialDirectory = i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
			if (openFileDialog.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}
			global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(openFileDialog.FileName);
			ba = openFileDialog.FileNames;
			s().Text = "";
			string[] array = ba;
			foreach (string text2 in array)
			{
				if (!string.IsNullOrEmpty(s().Text))
				{
					s().Text += "; ";
					text += "\r\n";
				}
				s().Text += Path.GetFileName(text2);
				text += text2;
			}
			ab().SetToolTip(s(), text);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_ai.c(fz.b.a, "Error in DialogTechnicalSupport.ButtonBrowseForScreenshot_Click", ex3);
			fe.b(this.m_ai, "Error in ButtonBrowseForScreenshot_Click. Error is: " + ex3.Message, "Information", i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		try
		{
			ba = null;
			s().Text = "";
			ab().SetToolTip(s(), "");
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ai.c(fz.b.a, "Error in DialogTechnicalSupport.ButtonClearOptionalAttachments_Click", a_);
			fe.b(this.m_ai, "Error in ButtonClearOptionalAttachments_Click. Error details have been logged.", i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
		{
			if (!d())
			{
				return;
			}
			i();
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.AddExtension = true;
			saveFileDialog.Filter = "Tech Support Archive (*.fitsa)|*.fitsa";
			saveFileDialog.InitialDirectory = i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
			saveFileDialog.OverwritePrompt = true;
			saveFileDialog.FileName = "Technical Support Request Data";
			string A_2 = "TechnicalSupportSaveDialogTitle";
			saveFileDialog.Title = hu.a(ref A_2);
			if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
			{
				global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(saveFileDialog.FileName);
				if (b(saveFileDialog.FileName))
				{
					fz a_ = this.m_ai;
					A_2 = "TechSupportFileEmailInstr";
					fe.b(a_, hu.a(ref A_2) + "\r\n\r\n" + saveFileDialog.FileName, "TechnicalSupportInstructions", i6.a(this));
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_ai.c(fz.b.a, "Error in DialogTechnicalSupport.ButtonCreateFile_Click", ex3);
			fe.b(this.m_ai, "Error in ButtonCreateFile_Click. Error is: " + ex3.Message, "Information", i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			new dv().a(this.m_ai, bc);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ai.c(fz.b.a, "Error in DialogTechnicalSupport.ButtonEditAutoAttachments_Click", a_);
			fe.b(this.m_ai, "Error in DialogTechnicalSupport.ButtonEditAutoAttachments_Click. Error details have been logged.", i6.a(this));
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		checked
		{
			int A_5 = default(int);
			try
			{
				Collection<string> collection = new Collection<string>();
				string A_2 = null;
				string A_3 = null;
				if (!d())
				{
					return;
				}
				a(A_0: false);
				Cursor = Cursors.WaitCursor;
				i();
				string text = bb + "\\TechSupportRequest Data.fitsa";
				if (!b(text))
				{
					return;
				}
				collection.Add(text);
				global::e.a().TechSupportProvider = ai().Text;
				DateTime A_4 = default(DateTime);
				jh.a(8, 16, -8, 4, ref A_2, ref A_3, ref A_4);
				string text2 = bj[ai().SelectedIndex];
				if (string.IsNullOrEmpty(text2))
				{
					fe fe2 = new fe(this.m_ai);
					fe.a a10 = new fe.a();
					a10.w("Enter Filmetrics recipient e-mail name (typically last name of person):");
					a10.x("Information");
					a10.y("OKString");
					a10.aa("CancelString");
					a10.w(MsgBoxStyle.OkCancel);
					a10.w(i6.a(this));
					a10.ad(global::e.a().TechSupportFIEmployee);
					a10.w(fe.b.a);
					_ = null;
					bool flag;
					do
					{
						flag = false;
						if (fe2.b(a10) == DialogResult.Cancel)
						{
							return;
						}
						text2 = a10.ag();
						if (text2.ToLower().EndsWith("filmetrics.com"))
						{
							text2 = text2.Substring(0, text2.Length - ("filmetrics.com".Length + 1));
						}
						if (text2.Contains("@"))
						{
							fe.b(this.m_ai, "Improper e-mail address. Filmetrics recipient e-mail address must be in the filmetrics.com domain", i6.a(this));
							flag = true;
						}
					}
					while (flag);
					global::e.a().TechSupportFIEmployee = text2;
					text2 += "@filmetrics.com";
				}
				MailAddress a_;
				try
				{
					a_ = new MailAddress(w().Text);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex3 = ex2;
					if (string.IsNullOrEmpty(w().Text.Trim()))
					{
						fe.b(this.m_ai, "Missing required information: e-mail address", i6.a(ak()));
						ProjectData.ClearProjectError();
					}
					else
					{
						fe.b(this.m_ai, "Please enter a valid e-mail address", i6.a(ak()));
						ProjectData.ClearProjectError();
					}
					return;
				}
				ja.a(text2, "Technical Support Request - " + o().Text, e(), collection, a_, w().Text, "", "TechSuppReq", ref A_5);
				fz a_2 = this.m_ai;
				string[] array = new string[5];
				string A_6 = "MessageSent";
				array[0] = hu.a(ref A_6);
				array[1] = "\r\n\r\n";
				array[2] = A_2;
				array[3] = "\r\n";
				array[4] = A_3;
				fe.b(a_2, string.Concat(array), "TechnicalSupportMessageSent", i6.a(this));
				Close();
			}
			catch (IOException ex4)
			{
				ProjectData.SetProjectError(ex4);
				IOException ex5 = ex4;
				fe.b(this.m_ai, "Error attempting to submit Support Request. Error is: " + ex5.Message + "\r\n", "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
			catch (Exception ex6)
			{
				ProjectData.SetProjectError(ex6);
				Exception ex7 = ex6;
				this.m_ai.c(fz.b.a, "Error in DialogTechnicalSupport.ButtonSubmit_Click", ex7);
				fe.b(this.m_ai, ja.a(ex7, A_5), "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
			finally
			{
				a(A_0: true);
				Cursor = Cursors.Default;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		checked
		{
			int A_2 = default(int);
			try
			{
				a(A_0: false);
				ja.a(w().Text, "Test Message", "This is a test message from Filmetrics Technical Support. If you've received this message your email address is correctly entered and " + global::c.d().Info.ProductName + " is successfully communicating with our mailserver.", null, null, "", "", "TechSuppTest", ref A_2);
				fe.b(this.m_ai, "Test message has been sent", "Information", i6.a(this));
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				this.m_ai.c(fz.b.a, "Error in DialogTechnicalSupport.ButtonTestEmail_Click", ex3);
				fe.b(this.m_ai, ja.a(ex3, A_2), "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
			finally
			{
				a(A_0: true);
			}
		}
	}

	private void a()
	{
		try
		{
			if (base.InvokeRequired)
			{
				RuntimeHelpers.GetObjectValue(Invoke(new e(a)));
				return;
			}
			bm = true;
			f();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport.SupportFileMembersPopulated_Done", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			h();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport.TextBoxName_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			g();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_ai.c(fz.b.b, "Error in DialogTechnicalSupport.TextBoxEmailAddress_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}
}
