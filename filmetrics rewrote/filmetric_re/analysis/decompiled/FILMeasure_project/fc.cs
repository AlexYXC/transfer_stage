using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class fc : Form
{
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
	private Button m_f;

	[CompilerGenerated]
	private CheckBox m_g;

	[CompilerGenerated]
	private CheckBox m_h;

	[CompilerGenerated]
	private Button m_i;

	[CompilerGenerated]
	private TableLayoutPanel m_j;

	[CompilerGenerated]
	private TableLayoutPanel m_k;

	private DialogResult m_l;

	private f1 m_m;

	private f4 m_n;

	private Guid o;

	private string p;

	private fz q;

	private gr r;

	private bool s;

	private bool t;

	private bool u;

	private bool v;

	[CompilerGenerated]
	private r.d w;

	public fc()
	{
		c();
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
	private void c()
	{
		a(new Button());
		b(new Button());
		c(new Button());
		f(new Button());
		b(new CheckBox());
		a(new CheckBox());
		d(new Button());
		e(new Button());
		a(new TableLayoutPanel());
		b(new TableLayoutPanel());
		l().SuspendLayout();
		m().SuspendLayout();
		SuspendLayout();
		d().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		d().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d().Location = new Point(13, 8);
		d().Margin = new Padding(13, 8, 13, 3);
		d().Name = "ButtonOk";
		d().Size = new Size(90, 35);
		d().TabIndex = 0;
		d().Text = "OK";
		d().UseVisualStyleBackColor = true;
		e().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		e().DialogResult = DialogResult.Cancel;
		e().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e().Location = new Point(129, 8);
		e().Margin = new Padding(13, 8, 13, 3);
		e().Name = "ButtonCancel";
		e().Size = new Size(90, 35);
		e().TabIndex = 1;
		e().Text = "Cancel";
		e().UseVisualStyleBackColor = true;
		f().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		f().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f().Location = new Point(245, 8);
		f().Margin = new Padding(13, 8, 13, 3);
		f().Name = "ButtonApply";
		f().Size = new Size(90, 35);
		f().TabIndex = 2;
		f().Text = "Apply";
		f().UseVisualStyleBackColor = true;
		k().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		k().Location = new Point(403, 3);
		k().Margin = new Padding(15, 3, 15, 3);
		k().Name = "ButtonSetCTMCenterPeaks";
		k().Size = new Size(90, 31);
		k().TabIndex = 3;
		k().Text = "Center Peaks...";
		k().UseVisualStyleBackColor = true;
		k().Visible = false;
		j().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		j().AutoSize = true;
		j().Font = new Font("Arial", 9.75f);
		j().Location = new Point(212, 40);
		j().Margin = new Padding(30, 3, 3, 3);
		j().Name = "CheckBoxUseDark";
		j().Size = new Size(173, 20);
		j().TabIndex = 5;
		j().Text = "Subtract Background";
		j().UseVisualStyleBackColor = true;
		i().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		i().AutoSize = true;
		i().Font = new Font("Arial", 9.75f);
		i().Location = new Point(30, 40);
		i().Margin = new Padding(30, 3, 3, 3);
		i().Name = "CheckBoxUseReference";
		i().Size = new Size(149, 20);
		i().TabIndex = 4;
		i().Text = "Use Standard";
		i().UseVisualStyleBackColor = true;
		g().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		g().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		g().Location = new Point(15, 3);
		g().Margin = new Padding(15, 3, 15, 3);
		g().Name = "ButtonReference";
		g().Size = new Size(152, 31);
		g().TabIndex = 1;
		g().Text = "Take Standard...";
		g().UseVisualStyleBackColor = true;
		h().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		h().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		h().Location = new Point(197, 3);
		h().Margin = new Padding(15, 3, 15, 3);
		h().Name = "ButtonDark";
		h().Size = new Size(176, 31);
		h().TabIndex = 2;
		h().Text = "Take Background...";
		h().UseVisualStyleBackColor = true;
		l().Anchor = AnchorStyles.Top;
		l().AutoSize = true;
		l().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		l().ColumnCount = 3;
		m().SetColumnSpan(l(), 3);
		l().ColumnStyles.Add(new ColumnStyle());
		l().ColumnStyles.Add(new ColumnStyle());
		l().ColumnStyles.Add(new ColumnStyle());
		l().Controls.Add(d(), 0, 0);
		l().Controls.Add(e(), 1, 0);
		l().Controls.Add(f(), 2, 0);
		l().Location = new Point(80, 66);
		l().Name = "TableLayoutPanel3";
		l().RowCount = 1;
		l().RowStyles.Add(new RowStyle());
		l().Size = new Size(348, 46);
		l().TabIndex = 7;
		m().AutoSize = true;
		m().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		m().ColumnCount = 3;
		m().ColumnStyles.Add(new ColumnStyle());
		m().ColumnStyles.Add(new ColumnStyle());
		m().ColumnStyles.Add(new ColumnStyle());
		m().Controls.Add(k(), 2, 0);
		m().Controls.Add(l(), 0, 2);
		m().Controls.Add(g(), 0, 0);
		m().Controls.Add(j(), 1, 1);
		m().Controls.Add(i(), 0, 1);
		m().Controls.Add(h(), 1, 0);
		m().Location = new Point(12, 12);
		m().Name = "TableLayoutPanel4";
		m().RowCount = 3;
		m().RowStyles.Add(new RowStyle());
		m().RowStyles.Add(new RowStyle());
		m().RowStyles.Add(new RowStyle());
		m().Size = new Size(508, 115);
		m().TabIndex = 7;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = e();
		base.ClientSize = new Size(530, 138);
		base.Controls.Add(m());
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogHWSetup";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.Manual;
		Text = "Standard/Background";
		l().ResumeLayout(performLayout: false);
		m().ResumeLayout(performLayout: false);
		m().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button d()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = f;
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
	internal virtual Button e()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = e;
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
	internal virtual Button f()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = d;
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
	internal virtual Button g()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Button A_0)
	{
		EventHandler value = b;
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
	internal virtual Button h()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Button A_0)
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
	internal virtual CheckBox i()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(CheckBox A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox j()
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
	internal virtual Button k()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Button A_0)
	{
		EventHandler value = a;
		Button button = this.m_i;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_i = A_0;
		button = this.m_i;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel l()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel m()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d n()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		r.d.b a_ = a;
		w?.e(a_);
		w = A_0;
		w?.d(a_);
	}

	public DialogResult a(ref f1 A_0, f4 A_1, Guid A_2, bool A_3, gr A_4, ref fz A_5)
	{
		bool flag = A_0.wv(A_2);
		bool flag2 = A_0.vl(A_2);
		o = A_2;
		p = A_2.ToString();
		this.m_m = A_0;
		this.m_n = A_1;
		r = A_4;
		q = A_5;
		t = this.m_m.wq(o).d0().q();
		u = A_3;
		v = A_0.sm(o);
		a(new r.d());
		b();
		s = false;
		if (t)
		{
			g().Visible = true;
			i().Visible = true;
			k().Visible = !this.m_m.s4(p).p();
		}
		if (this.m_m.u6(o))
		{
			j().Visible = false;
			i().Visible = false;
		}
		if (v)
		{
			g().Visible = false;
			i().Visible = false;
			k().Visible = false;
			Text = ey.g();
		}
		g().Enabled = flag && !flag2;
		ShowDialog();
		return this.m_l;
	}

	public static DialogResult a(f1 A_0, fz A_1, Guid A_2, Point A_3)
	{
		cq obj = new cq(A_1);
		cq.a a_ = cq.a.d;
		obj.a(a_, A_0, null, A_2, A_3);
		return obj.DialogResult;
	}

	private bool a(bool A_0, bool A_1, h A_2)
	{
		if (!A_0)
		{
			return false;
		}
		if (this.m_m.u6(o))
		{
			return false;
		}
		int[] array = this.m_m.un(o);
		bool a_ = array != null && array[0] > 0;
		bool flag = ((!u || !A_2.a(this.m_m.tg(o), a_)) ? (A_2.n(this.m_m.sm(o)) == global::h.MeasurementTimingType.Manual) : A_2.a0());
		bool flag2 = this.m_m.wq(o).d0().c() != g2.a.n || this.m_m.wk(o);
		bool flag3 = this.m_m.s8(o, u) && this.m_m.s3(o, u);
		return (flag || flag3 || this.m_m.u8(o) == g2.a.m || this.m_m.wj(o)) && !A_1 && flag2;
	}

	private void b()
	{
		bool flag = this.m_m.wv(o);
		h a_ = this.m_m.t0(p).b8();
		bool a_2 = this.m_m.vl(o);
		if (this.m_m.s6(o, u) && this.m_m.s4(o, u))
		{
			j().Enabled = flag;
			j().Checked = this.m_m.sn(o, u);
		}
		else
		{
			j().Enabled = false;
			j().Checked = false;
		}
		if (this.m_m.s8(o, u) && this.m_m.s3(o, u))
		{
			i().Enabled = flag;
			i().Checked = this.m_m.so(o, u);
		}
		else
		{
			i().Enabled = false;
			i().Checked = false;
		}
		if (t)
		{
			k().Enabled = flag && this.m_m.s6(o, u);
		}
		h().Enabled = a(flag, a_2, a_);
	}

	private void a()
	{
		this.m_m.m2(o, i().Checked, j().Checked, u, A_4: false, n(), global::r.d.a.b.a);
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
		{
			a();
			this.m_l = DialogResult.OK;
			Close();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(q, this.m_m, this.m_n, i6.a(this), "DialogHWSetup.ButtonOk_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		s = false;
		this.m_l = DialogResult.Cancel;
		Close();
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			a();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(q, this.m_m, this.m_n, i6.a(this), "DialogHWSetup.ButtonApply_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			a();
			if (t)
			{
				new cq(q).a(cq.a.b, this.m_m, this.m_n, o, i6.a(this));
			}
			else
			{
				e6 obj = new e6(q);
				obj.e(s);
				obj.c(e6.b.b, r, this.m_m, this.m_n, o, u);
			}
			b();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(q, this.m_m, this.m_n, i6.a(this), "DialogHWSetup.ButtonDark_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			a();
			if (t)
			{
				if (a(this.m_m, q, o, i6.a(this)) != DialogResult.Cancel)
				{
					s = true;
				}
			}
			else
			{
				this.m_m.m2(o, 0f);
				e6 e10 = new e6(q);
				if (this.m_m.u6(o))
				{
					e10.c(e6.b.d, r, this.m_m, this.m_n, o, u);
					if (e10.DialogResult != DialogResult.Cancel)
					{
						s = true;
					}
				}
				else
				{
					e10.c(e6.b.a, r, this.m_m, this.m_n, o, u);
					if (e10.DialogResult != DialogResult.Cancel)
					{
						s = true;
					}
				}
				e10.Dispose();
			}
			b();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(q, this.m_m, this.m_n, i6.a(this), "DialogHWSetup.ButtonReference_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			new cq(q).a(cq.a.c, this.m_m, this.m_n, o, i6.a(this));
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(q, this.m_m, this.m_n, i6.a(this), "DialogHWSetup.ButtonSetCTMCenterPeaks_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.d.a A_0)
	{
		if (base.InvokeRequired)
		{
			r.d.b method = a;
			BeginInvoke(method, A_0);
			return;
		}
		checked
		{
			try
			{
				if (A_0.a != global::r.d.a.a.a)
				{
					fe.b(q, "Error attempting to update UseRefAndBacSettings", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(q, this.m_m, this.m_n, i6.a(this), "DialogHWSetup.UseRefAndBacSettingsUpdatedFinishedHandler", a_);
				ProjectData.ClearProjectError();
			}
		}
	}
}
