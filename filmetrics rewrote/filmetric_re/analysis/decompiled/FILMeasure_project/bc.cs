using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using FIUsbIntLib;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class bc : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private TableLayoutPanel m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Label m_d;

	[CompilerGenerated]
	private Label m_e;

	[CompilerGenerated]
	private Label m_f;

	[CompilerGenerated]
	private Label m_g;

	[CompilerGenerated]
	private Label m_h;

	[CompilerGenerated]
	private TableLayoutPanel m_i;

	[CompilerGenerated]
	private Button m_j;

	[CompilerGenerated]
	private System.Windows.Forms.Timer m_k;

	[CompilerGenerated]
	private ProgressBar m_l;

	private f1 m_m;

	private fz n;

	private hg o;

	private bool p;

	private bool q;

	private hg r;

	private Guid s;

	private h.f[] t;

	private r.l u;

	private r.d v;

	private short w;

	[CompilerGenerated]
	private r.d x;

	private const string y = "DialogCalibrateADGain";

	private float z;

	private float aa;

	private ip.p ab;

	private FMUSBDeviceType ac;

	[SpecialName]
	private bool ad;

	[SpecialName]
	private StaticLocalInitFlag ae;

	public bc()
	{
		base.FormClosing += a;
		u = new r.l();
		v = new r.d();
		a(new r.d());
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
		a(new TableLayoutPanel());
		a(new Button());
		b(new Button());
		a(new Label());
		b(new Label());
		c(new Label());
		d(new Label());
		e(new Label());
		b(new TableLayoutPanel());
		a(new ProgressBar());
		a(new System.Windows.Forms.Timer(this.m_a));
		b().SuspendLayout();
		i().SuspendLayout();
		SuspendLayout();
		b().Anchor = AnchorStyles.Bottom;
		b().AutoSize = true;
		b().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		b().ColumnCount = 2;
		i().SetColumnSpan(b(), 2);
		b().ColumnStyles.Add(new ColumnStyle());
		b().ColumnStyles.Add(new ColumnStyle());
		b().Controls.Add(c(), 1, 0);
		b().Controls.Add(j(), 0, 0);
		b().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b().Location = new Point(4, 152);
		b().Margin = new Padding(4, 14, 4, 4);
		b().Name = "TableLayoutPanel1";
		b().RowCount = 1;
		b().RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		b().Size = new Size(201, 38);
		b().TabIndex = 0;
		c().Anchor = AnchorStyles.None;
		c().AutoSize = true;
		c().DialogResult = DialogResult.Cancel;
		c().Location = new Point(129, 4);
		c().Margin = new Padding(4);
		c().Name = "ButtonCancel";
		c().Size = new Size(68, 30);
		c().TabIndex = 1;
		c().Text = "Cancel";
		j().Anchor = AnchorStyles.None;
		j().AutoSize = true;
		j().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		j().Enabled = false;
		j().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		j().Location = new Point(3, 4);
		j().Name = "ButtonDoCal";
		j().Size = new Size(119, 30);
		j().TabIndex = 6;
		j().Text = "Do Calibration";
		j().UseVisualStyleBackColor = true;
		d().Anchor = AnchorStyles.Left;
		d().AutoSize = true;
		i().SetColumnSpan(d(), 2);
		d().Location = new Point(3, 5);
		d().Margin = new Padding(3, 5, 3, 5);
		d().Name = "LabelInstructions";
		d().Size = new Size(108, 16);
		d().TabIndex = 1;
		d().Text = "LabelInstructions";
		e().Anchor = AnchorStyles.Right;
		e().AutoSize = true;
		e().Location = new Point(3, 31);
		e().Margin = new Padding(3, 5, 3, 5);
		e().Name = "Label1";
		e().Size = new Size(104, 16);
		e().TabIndex = 2;
		e().Text = "Current Intensity:";
		f().Anchor = AnchorStyles.Left;
		f().AutoSize = true;
		f().BorderStyle = BorderStyle.FixedSingle;
		f().Location = new Point(113, 30);
		f().MinimumSize = new Size(50, 2);
		f().Name = "LabelPeakInten";
		f().Size = new Size(50, 18);
		f().TabIndex = 3;
		g().AutoSize = true;
		i().SetColumnSpan(g(), 2);
		g().Location = new Point(3, 83);
		g().Margin = new Padding(3, 5, 3, 5);
		g().Name = "LabelTargetRange";
		g().Size = new Size(92, 16);
		g().TabIndex = 4;
		g().Text = "Target Range";
		h().AutoSize = true;
		i().SetColumnSpan(h(), 2);
		h().Location = new Point(3, 57);
		h().Margin = new Padding(3, 5, 3, 5);
		h().Name = "LabelTargetIntensity";
		h().Size = new Size(96, 16);
		h().TabIndex = 5;
		h().Text = "TargetIntensity";
		i().AutoSize = true;
		i().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		i().ColumnCount = 2;
		i().ColumnStyles.Add(new ColumnStyle());
		i().ColumnStyles.Add(new ColumnStyle());
		i().Controls.Add(l(), 0, 4);
		i().Controls.Add(d(), 0, 0);
		i().Controls.Add(e(), 0, 1);
		i().Controls.Add(g(), 0, 3);
		i().Controls.Add(h(), 0, 2);
		i().Controls.Add(f(), 1, 1);
		i().Controls.Add(b(), 0, 5);
		i().Location = new Point(10, 10);
		i().Margin = new Padding(13);
		i().Name = "TableLayoutPanel2";
		i().RowCount = 6;
		i().RowStyles.Add(new RowStyle());
		i().RowStyles.Add(new RowStyle());
		i().RowStyles.Add(new RowStyle());
		i().RowStyles.Add(new RowStyle());
		i().RowStyles.Add(new RowStyle());
		i().RowStyles.Add(new RowStyle());
		i().Size = new Size(209, 194);
		i().TabIndex = 7;
		i().SetColumnSpan(l(), 2);
		l().Dock = DockStyle.Fill;
		l().Location = new Point(3, 107);
		l().Name = "ProgressBarStatus";
		l().Size = new Size(203, 28);
		l().TabIndex = 8;
		k().Interval = 500;
		base.AcceptButton = j();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = c();
		base.ClientSize = new Size(228, 215);
		base.Controls.Add(i());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogCalibrateADGain";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Calibrate Spectrometer AD Gain";
		b().ResumeLayout(performLayout: false);
		b().PerformLayout();
		i().ResumeLayout(performLayout: false);
		i().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel b()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label d()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label e()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label f()
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
	internal virtual Label g()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label h()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel i()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button j()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = b;
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
	internal virtual System.Windows.Forms.Timer k()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(System.Windows.Forms.Timer A_0)
	{
		EventHandler value = a;
		System.Windows.Forms.Timer timer = this.m_k;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		this.m_k = A_0;
		timer = this.m_k;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ProgressBar l()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ProgressBar A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d m()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		r.d.b a_ = a;
		x?.e(a_);
		x = A_0;
		x?.d(a_);
	}

	public void a(Guid A_0, FMUSBDeviceType A_1, ip.p A_2, float A_3, f1 A_4, fz A_5, ref short A_6)
	{
		string text = null;
		ac = A_1;
		this.m_m = A_4;
		s = A_0;
		n = A_5;
		r = A_4.wq(A_0);
		r.bu(ref o);
		t = this.m_m.vb(A_0);
		u.m = v;
		p = this.m_m.so(A_0, A_1: false);
		q = this.m_m.sn(A_0, A_1: false);
		ab = A_2;
		l().Maximum = 100;
		l().Value = 0;
		h.f f10 = t[A_2.a];
		double a_ = default(double);
		switch (A_1)
		{
		case FMUSBDeviceType.FIUSB2DeviceSpecNIR2:
		case FMUSBDeviceType.FIUSB2DeviceSpecTCNIR:
			text = "Si Reference wafer";
			a_ = 20.0;
			break;
		case FMUSBDeviceType.FIUSB2DeviceSpecLC:
		case FMUSBDeviceType.FIUSB2DeviceSpecUvVis2:
			text = "BK7 reference";
			a_ = ((A_1 != FMUSBDeviceType.FIUSB2DeviceSpecUvVis2) ? this.m_m.p9(A_0, A_2.c, A_2.a, this.m_m.qh(A_0, A_2.a, A_2.b)) : 2.25);
			break;
		}
		d().Text = "Spectrometer input must be connected to SS-1 stage with\r\nonly a tungsten-halogen or incandescent light on,\r\nRP1 connected, and " + text + " on stage.\r\nAdjust the light intensity without using color filters.";
		this.m_m.v4(A_0).d((r.d.b)b);
		f f11 = r.b8().a((int)t[A_2.a]);
		if (this.m_m.qh(A_0, A_2.a, A_2.b) == global::f.b.b)
		{
			f11.b(global::f.b.b, a_);
			f11.b(global::f.b.b, 10);
			f11.h(global::f.a.b);
		}
		else
		{
			f11.h(global::f.a.c);
			f11.b(global::f.b.c, a_);
			f11.b(global::f.b.c, 10);
		}
		switch (f10)
		{
		case global::h.f.a:
			r.b8().r(global::h.e.b);
			break;
		case global::h.f.b:
			r.b8().r(global::h.e.c);
			break;
		case global::h.f.c:
			r.b8().r(global::h.e.d);
			break;
		}
		f11 = null;
		r.b8().b(global::h.MeasurementTimingType.Manual);
		r.bv(new r.d(), A_1: true);
		this.m_m.m2(A_0, A_1: false, A_2: false, A_3: false, A_4: false, new r.d(), global::r.d.a.b.a);
		f1 obj = this.m_m;
		string A_7 = null;
		obj.m2(A_0, null, null, null, ref A_7, new r.d(), u, global::r.d.a.b.a, 1, null);
		if (A_1 == FMUSBDeviceType.FIUSB2DeviceSpecUvVis2)
		{
			float num = (float)Math.Pow(10.0, 0.0353 * (double)A_3 / 20.0);
			z = 600f * num;
			aa = 1050f * num;
		}
		else
		{
			z = 250f * A_3;
			aa = 500f * A_3;
		}
		h().Text = "Target Peak Intensity = " + (0.5 * (double)(aa + z)).ToString("####");
		g().Text = "Peak intensity must be between " + z.ToString("####") + " and " + aa.ToString("####");
		ShowDialog();
		A_6 = w;
	}

	public void b(r.d.a A_0)
	{
		checked
		{
			try
			{
				if (this.m_m.tc())
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
					Thread.Sleep(150);
					BeginInvoke(new r.d.b(b), A_0);
				}
				else
				{
					if (!base.IsHandleCreated)
					{
						return;
					}
					double num = double.MinValue;
					double[] array = a10.w.c0();
					int num2 = array.Length - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						if (array[num3] > num)
						{
							num = array[num3];
						}
					}
					f().Text = num.ToString("#");
					bool num4 = !j().Enabled;
					j().Enabled = num >= (double)z && num <= (double)aa && !u.q();
					if (num4)
					{
						base.ActiveControl = j();
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				n.c(fz.b.b, "Exception caught in DialogCalibrateADGain.SpectrometerSpectrumAcquiredEventHandler", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			u.q(A_0: true);
			new ip.p();
			c().Enabled = false;
			Cursor = Cursors.WaitCursor;
			k().Enabled = true;
			if (ac == FMUSBDeviceType.FIUSB2DeviceSpecUvVis2)
			{
				this.m_m.p9(s, ab, global::r.d.a.b.a, m());
			}
			else
			{
				this.m_m.m2(s, ab, global::r.d.a.b.a, m());
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			Cursor = Cursors.Default;
			i5.a(n, this.m_m, null, i6.a(this), "DialogCalibrateADGain.ButtonDoCal_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		try
		{
			u.q(A_0: true);
			o.bu(ref r);
			r.bv(new r.d(), A_1: true);
			this.m_m.m2(s, p, q, A_3: false, A_4: false, new r.d(), global::r.d.a.b.a);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(n, this.m_m, null, i6.a(this), "DialogCalibrateADGain.DialogCalibrateADGain_FormClosing", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.d.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new r.d.b(a), A_0);
				return;
			}
			try
			{
				lock (k())
				{
					k().Enabled = false;
					l().Value = 100;
				}
				r.d.a a10 = A_0;
				if (a10.a != global::r.d.a.a.a)
				{
					if (a10.a8() == global::r.d.a.b.a)
					{
						fe.b(n, a10.b, i6.a(this));
					}
					u = new r.l();
					f1 obj = this.m_m;
					Guid a_ = s;
					string A_1 = null;
					obj.m2(a_, null, null, null, ref A_1, new r.d(), u, global::r.d.a.b.a, 1, null);
				}
				else
				{
					w = ((ip.p)A_0.d).ad;
					if (a10.a8() == global::r.d.a.b.a)
					{
						SystemSounds.Exclamation.Play();
						fe.b(n, "Gain calibration completed.", "Information", i6.a(this));
						base.DialogResult = DialogResult.OK;
					}
					a10 = null;
				}
			}
			finally
			{
				base.Enabled = true;
				Cursor = Cursors.Default;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(n, this.m_m, null, i6.a(this), "DialogCalibrateADGain.mPGAGainCompletionTask_TaskFinishedEvent", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		if (ae == null)
		{
			Interlocked.CompareExchange(ref ae, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(ae, ref lockTaken);
			if (ae.State == 0)
			{
				ae.State = 2;
				ad = false;
			}
			else if (ae.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			ae.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(ae);
			}
		}
		checked
		{
			lock (k())
			{
				if (!k().Enabled)
				{
					return;
				}
				k().Enabled = false;
				try
				{
					if (!ad)
					{
						l().Value = (int)Math.Round(this.m_m.m2(s, ab.a, ab.b));
					}
					else
					{
						l().Value++;
					}
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception a_ = ex2;
					if (!ad)
					{
						n.c(fz.b.b, "DialogCalibrateADGain.TimerProgress_Tick", a_);
					}
					ad = true;
					ProjectData.ClearProjectError();
				}
				finally
				{
					k().Enabled = true;
				}
			}
		}
	}
}
