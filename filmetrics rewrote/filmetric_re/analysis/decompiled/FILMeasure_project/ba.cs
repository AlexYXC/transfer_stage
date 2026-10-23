using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class ba : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private Label m_c;

	[CompilerGenerated]
	private Label m_d;

	[CompilerGenerated]
	private Label m_e;

	[CompilerGenerated]
	private Button m_f;

	[CompilerGenerated]
	private ToolTip m_g;

	[CompilerGenerated]
	private Button m_h;

	[CompilerGenerated]
	private ComboBox m_i;

	[CompilerGenerated]
	private Label m_j;

	[CompilerGenerated]
	private Panel m_k;

	private string m_l;

	private fz m_m;

	private f1 n;

	private Guid o;

	private Collection<ip.d> p;

	private Collection<ip.e> q;

	private a9[] r;

	private gr s;

	[CompilerGenerated]
	private r.d t;

	private f4 u;

	private hg v;

	private int w;

	private h.f x;

	private bool y;

	private const string z = "DialogBaselineLinearity.";

	public ba()
	{
		base.FormClosing += a;
		p = new Collection<ip.d>();
		q = new Collection<ip.e>();
		a(new r.d());
		b();
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
	private void b()
	{
		this.m_a = new Container();
		a(new Button());
		a(new Label());
		b(new Label());
		c(new Label());
		b(new Button());
		a(new ToolTip(this.m_a));
		c(new Button());
		a(new ComboBox());
		d(new Label());
		a(new Panel());
		l().SuspendLayout();
		SuspendLayout();
		c().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		c().DialogResult = DialogResult.Cancel;
		c().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c().Location = new Point(111, 236);
		c().Margin = new Padding(4);
		c().Name = "ButtonClose";
		c().Size = new Size(89, 28);
		c().TabIndex = 0;
		c().Text = "Close";
		d().AutoSize = true;
		d().Location = new Point(10, 54);
		d().Name = "Label1";
		d().Size = new Size(258, 16);
		d().TabIndex = 1;
		d().Text = "Select calibration file, then click Calibrate...";
		e().AutoSize = true;
		e().BorderStyle = BorderStyle.FixedSingle;
		e().Location = new Point(116, 87);
		e().Name = "LabelCalFilename";
		e().Size = new Size(65, 18);
		e().TabIndex = 2;
		e().Text = "Unknown";
		f().AutoSize = true;
		f().Location = new Point(10, 87);
		f().Name = "Label3";
		f().Size = new Size(100, 16);
		f().TabIndex = 3;
		f().Text = "Calibration File:";
		g().BackColor = SystemColors.Window;
		g().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		g().Location = new Point(99, 118);
		g().Margin = new Padding(4);
		g().Name = "ButtonBrowse";
		g().Size = new Size(89, 28);
		g().TabIndex = 4;
		g().Text = "Browse...";
		g().UseVisualStyleBackColor = true;
		i().AutoSize = true;
		i().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		i().Location = new Point(96, 174);
		i().Name = "ButtonCalibrate";
		i().Size = new Size(94, 30);
		i().TabIndex = 5;
		i().Text = "Calibrate...";
		i().UseVisualStyleBackColor = true;
		j().DropDownStyle = ComboBoxStyle.DropDownList;
		j().FormattingEnabled = true;
		j().Location = new Point(108, 9);
		j().Name = "ComboBoxSpectrometer";
		j().Size = new Size(168, 24);
		j().TabIndex = 6;
		k().AutoSize = true;
		k().Location = new Point(10, 12);
		k().Name = "Label2";
		k().Size = new Size(92, 16);
		k().TabIndex = 7;
		k().Text = "Spectrometer:";
		l().BackColor = SystemColors.Window;
		l().BorderStyle = BorderStyle.FixedSingle;
		l().Controls.Add(k());
		l().Controls.Add(d());
		l().Controls.Add(j());
		l().Controls.Add(e());
		l().Controls.Add(i());
		l().Controls.Add(f());
		l().Controls.Add(g());
		l().Location = new Point(12, 12);
		l().Name = "Panel1";
		l().Size = new Size(288, 216);
		l().TabIndex = 8;
		base.AcceptButton = c();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = c();
		base.ClientSize = new Size(311, 270);
		base.Controls.Add(l());
		base.Controls.Add(c());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogBaselineLinearity";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Baseline Linearity Calibration";
		l().ResumeLayout(performLayout: false);
		l().PerformLayout();
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button c()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = d;
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
	internal virtual Label d()
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
	internal virtual Label e()
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
	internal virtual Label f()
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
	internal virtual Button g()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = c;
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
	internal virtual ToolTip h()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolTip A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button i()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = b;
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
	internal virtual ComboBox j()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
	{
		EventHandler value = a;
		ComboBox comboBox = this.m_i;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_i = A_0;
		comboBox = this.m_i;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label k()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel l()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Panel A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d m()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		r.d.b a_ = a;
		t?.e(a_);
		t = A_0;
		t?.d(a_);
	}

	public void a(fz A_0, f1 A_1, f4 A_2, Guid A_3, a9[] A_4, int A_5, gr A_6)
	{
		this.m_m = A_0;
		n = A_1;
		o = A_3;
		w = A_5;
		u = A_2;
		s = A_6;
		r = A_4;
		x = n.vb(o)[A_5];
		hg hg2 = n.wq(o);
		v = new hg(hg2.dh(), hg2.cd());
		hg2.bu(ref v);
		if (u.hx())
		{
			u.i(A_0: false, A_1: false, h6.b.b);
			y = true;
		}
		int num = (r[w].o ? 1 : (r[w].p ? (-1) : 0));
		int num2 = num;
		for (int num3 = 0; num3 <= num2; num3 = checked(num3 + 1))
		{
			p.Add(n.sn(o, A_5, num3));
			q.Add(n.so(o, A_5, num3));
		}
		ComboBox comboBox = j();
		comboBox.Items.Clear();
		if (q.Count > 1)
		{
			comboBox.Items.Add("Short Wavelength Spectrometer");
			comboBox.Items.Add("Long WavelengthSpectrometer");
		}
		else
		{
			comboBox.Items.Add("Primary Spectrometer");
		}
		comboBox.SelectedIndex = 0;
		comboBox = null;
		ShowDialog();
	}

	private void d(object A_0, EventArgs A_1)
	{
		base.DialogResult = DialogResult.OK;
		Close();
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = global::e.a().LastOpenSaveExportTargetImportSourcePath;
			openFileDialog.Filter = jb.m();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				global::e.a().LastUsedOpenMaterialIndex = openFileDialog.FilterIndex;
				this.m_l = openFileDialog.FileName;
				openFileDialog = null;
				global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(this.m_l);
				e().Text = Path.GetFileName(this.m_l);
				h().SetToolTip(e(), this.m_l);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_m, n, null, i6.a(g()), "DialogBaselineLinearity.ButtonBrowse_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a()
	{
		hg A_ = n.wq(o);
		v.bu(ref A_);
		A_.bv(new r.d(), A_1: true);
		if (A_.d0().c() == g2.a.b && n.u1(o) != ce.ErrPublic.None)
		{
			this.m_m.c(fz.b.b, "Error in DialogBaselineLinearity. in call to mBaselineLinUpdateCompletionTask_TaskFinishedEvent.");
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				f.b b10 = ((j().SelectedIndex != 0) ? global::f.b.c : global::f.b.b);
				int num = -1;
				int num2 = r.Length - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (r[num3].ab == global::h.f.b)
					{
						num = num3;
					}
				}
				base.Enabled = false;
				hg hg2 = n.wq(o);
				bool num4 = hg2.d0().c() == g2.a.b;
				ix.b b11 = new ix.b();
				double A_2 = default(double);
				double A_3 = default(double);
				unchecked
				{
					if (num4)
					{
						n.u2(o);
						hg2.b8().b(global::h.MeasurementTimingType.Manual);
						if (j().SelectedIndex == 0)
						{
							hg2.b8().a((int)x).h(global::f.a.b);
							A_2 = ((num < 0) ? 1.5 : r[num].d);
							n.m2(o, global::h.f.a, global::f.b.b, ref A_3);
							int num5 = r[w].e;
						}
						else
						{
							hg2.b8().a((int)x).h(global::f.a.c);
							A_2 = ((num < 0) ? 1.5 : r[num].q);
							n.m2(o, global::h.f.a, global::f.b.c, ref A_3);
							int num5 = r[w].r;
						}
						if (A_3 == 0.0)
						{
							fe.b(this.m_m, "Integration time is not valid. Please take a baseline prior to doing the baseline linearity calibration.", i6.a(this));
							a();
							base.Enabled = true;
							return;
						}
					}
					else
					{
						if (b10 == global::f.b.b)
						{
							hg2.b8().a(0).h(global::f.a.b);
							if (num >= 0)
							{
								hg2.b8().a(1).h(global::f.a.b);
							}
						}
						else
						{
							hg2.b8().a(0).h(global::f.a.c);
							if (num >= 0)
							{
								hg2.b8().a(1).h(global::f.a.c);
							}
						}
						bool A_4 = default(bool);
						n.m2(o, hg2.b8(), "Si", A_3: false, global::r.d.a.b.a, ref A_4);
						if (A_4)
						{
							fe.b(this.m_m, "Si reference file is missing or corrupted.", i6.a(this));
							a();
							base.Enabled = true;
							return;
						}
						hg2.b8().a(global::h.g.a).f();
						hg2.b8().b(global::h.MeasurementTimingType.Recommended);
						hg2.bv(new r.d(), A_1: true);
						fe.b(this.m_m, "Place an Si reference standard on the stage:\r\n\r\n1) Follow prompts to take a first baseline which will automatically\r\n    establish the integration times for the baseline linearity calibration.\r\n2) Follow prompts to take a second baseline using Si as the Reference standard\r\n3) Follow prompt to calibrate the baseline linearity on the ALREF standard.\r\n4) Follow prompts to do a final baseline using the current recipe.", "Information", i6.a(this), A_4: true, this);
						n.m2(o, s, u, i6.a(this), b11, A_5: true, global::r.d.a.b.a, new ix.b(), new ix.e());
						if (b11.a)
						{
							a();
							base.Enabled = true;
							return;
						}
						if (hg2.d0().c() == g2.a.b)
						{
							n.u2(o);
						}
						hg2.b8().b(global::h.MeasurementTimingType.Manual);
						int A_8 = default(int);
						if (j().SelectedIndex == 0)
						{
							double A_5;
							int A_7;
							int A_6;
							if (num >= 0)
							{
								f1 obj = n;
								Guid a_ = o;
								A_5 = 0.0;
								A_6 = 0;
								A_7 = 0;
								obj.m2(a_, 1, ref A_2, ref A_8, ref A_5, ref A_6, ref A_7);
							}
							else
							{
								A_2 = 1.5;
							}
							f1 obj2 = n;
							Guid a_2 = o;
							A_5 = 0.0;
							A_7 = 0;
							A_6 = 0;
							int num5 = default(int);
							obj2.m2(a_2, 0, ref A_3, ref num5, ref A_5, ref A_7, ref A_6);
						}
						else
						{
							double A_5;
							int A_7;
							int A_6;
							if (num >= 0)
							{
								f1 obj3 = n;
								Guid a_3 = o;
								A_5 = 0.0;
								A_6 = 0;
								A_7 = 0;
								obj3.m2(a_3, 1, ref A_5, ref A_6, ref A_2, ref A_8, ref A_7);
							}
							else
							{
								A_2 = 1.5;
							}
							f1 obj4 = n;
							Guid a_4 = o;
							A_5 = 0.0;
							A_7 = 0;
							A_6 = 0;
							obj4.m2(a_4, 0, ref A_5, ref A_7, ref A_3, ref A_8, ref A_6);
						}
						if (A_3 == 0.0)
						{
							fe.b(this.m_m, "Integration time is not valid. Please take a baseline prior to doing the baseline linearity calibration.", i6.a(this));
							a();
							base.Enabled = true;
							return;
						}
					}
					hg2.b8().a(0).b(b10, A_3 / 3.0);
				}
				hg2.b8().a(0).b(b10, (int)Math.Round(30000.0 / A_3));
				hg2.b8().a(1).b(b10, A_2);
				hg2.b8().a(1).b(b10, (int)Math.Round(5000.0 / A_2));
				hg2.bv(new r.d(), A_1: true);
				n.m2(o, s, u, i6.a(this), b11, A_5: true, global::r.d.a.b.a, new ix.b(), new ix.e());
				if (b11.a)
				{
					a();
					base.Enabled = true;
					return;
				}
				if (hg2.d0().c() == g2.a.b)
				{
					n.u2(o);
				}
				fe.b(this.m_m, "Place Al Reference on Stage", "Information", i6.a(this), A_4: true, this);
				n.m2(o, this.m_l, h6.b.b, 0, b10, m(), global::r.d.a.b.a);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_5 = ex2;
				a();
				base.Enabled = true;
				i5.a(this.m_m, n, null, i6.a(g()), "DialogBaselineLinearity.ButtonCalibrate_Click", a_5);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void a(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				BeginInvoke(new r.d.b(a), A_0);
			}
			else if (base.IsHandleCreated)
			{
				a();
				base.Enabled = true;
				if (A_0.a != global::r.d.a.a.a)
				{
					fe.b(this.m_m, "Calibration has failed.", i6.a(this));
					return;
				}
				fe.b(this.m_m, "Calibration completed. Please perform a final baseline to prepare system for measurements.", "Information", i6.a(this));
				ix.b a_ = new ix.b();
				n.m2(o, s, u, i6.a(this), a_, A_5: false, global::r.d.a.b.a, new ix.b(), new ix.e());
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(this.m_m, n, null, i6.a(g()), "DialogBaselineLinearity.mBaselineLinUpdateCompletionTask_TaskFinishedEvent", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		try
		{
			if (y)
			{
				u.i(A_0: false, A_1: false, h6.b.b);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_m.c(fz.b.b, "Error in DialogBaselineLinearity. in call to DialogBaselineLinearity_FormClosing.", a_);
			ProjectData.ClearProjectError();
		}
	}
}
