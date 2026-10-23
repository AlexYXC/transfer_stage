using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class bi : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private TableLayoutPanel m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private Label m_e;

	[CompilerGenerated]
	private TableLayoutPanel m_f;

	[CompilerGenerated]
	private TableLayoutPanel m_g;

	[CompilerGenerated]
	private Label m_h;

	[CompilerGenerated]
	private Label m_i;

	[CompilerGenerated]
	private ProgressBar m_j;

	private bool m_k;

	private fz m_l;

	private f1 m;

	private Guid n;

	private bool o;

	private bool p;

	[CompilerGenerated]
	private r.c q;

	[CompilerGenerated]
	private r.d r;

	private const string s = "DialogLightSourceAdjust";

	private const int t = 10000;

	public bi()
	{
		c(new r.c());
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
		a(new TableLayoutPanel());
		a(new Button());
		b(new Button());
		a(new Label());
		b(new TableLayoutPanel());
		c(new TableLayoutPanel());
		b(new Label());
		c(new Label());
		a(new ProgressBar());
		b().SuspendLayout();
		f().SuspendLayout();
		g().SuspendLayout();
		SuspendLayout();
		b().Anchor = AnchorStyles.None;
		b().AutoSize = true;
		b().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		b().ColumnCount = 1;
		b().ColumnStyles.Add(new ColumnStyle());
		b().Controls.Add(c(), 0, 0);
		b().Location = new Point(52, 110);
		b().Margin = new Padding(4);
		b().Name = "TableLayoutPanel1";
		b().RowCount = 1;
		b().RowStyles.Add(new RowStyle());
		b().Size = new Size(142, 38);
		b().TabIndex = 0;
		c().Anchor = AnchorStyles.None;
		c().AutoSize = true;
		c().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c().Location = new Point(4, 4);
		c().Margin = new Padding(4);
		c().Name = "ButtonStart";
		c().Size = new Size(134, 30);
		c().TabIndex = 0;
		c().Text = "Do Adjustment";
		d().Anchor = AnchorStyles.None;
		d().DialogResult = DialogResult.Cancel;
		d().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d().Location = new Point(78, 164);
		d().Margin = new Padding(4, 12, 4, 4);
		d().Name = "ButtonClose";
		d().Size = new Size(89, 28);
		d().TabIndex = 1;
		d().Text = "Cancel";
		e().AutoSize = true;
		e().Location = new Point(3, 0);
		e().Name = "LabelNotice";
		e().Size = new Size(233, 48);
		e().TabIndex = 1;
		e().Text = "This is a block of text\r\nthat tells the user that the light\r\nsource needs to be adjusted and why.";
		f().AutoSize = true;
		f().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		f().ColumnCount = 1;
		f().ColumnStyles.Add(new ColumnStyle());
		f().Controls.Add(g(), 0, 1);
		f().Controls.Add(d(), 0, 4);
		f().Controls.Add(b(), 0, 3);
		f().Controls.Add(e(), 0, 0);
		f().Controls.Add(j(), 0, 2);
		f().Location = new Point(12, 12);
		f().Name = "TableLayoutPanel2";
		f().RowCount = 5;
		f().RowStyles.Add(new RowStyle());
		f().RowStyles.Add(new RowStyle());
		f().RowStyles.Add(new RowStyle());
		f().RowStyles.Add(new RowStyle());
		f().RowStyles.Add(new RowStyle());
		f().Size = new Size(246, 196);
		f().TabIndex = 2;
		g().Anchor = AnchorStyles.None;
		g().AutoSize = true;
		g().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		g().ColumnCount = 2;
		g().ColumnStyles.Add(new ColumnStyle());
		g().ColumnStyles.Add(new ColumnStyle());
		g().Controls.Add(h(), 1, 0);
		g().Controls.Add(i(), 0, 0);
		g().Location = new Point(55, 61);
		g().Margin = new Padding(3, 13, 3, 3);
		g().Name = "TableLayoutPanel3";
		g().RowCount = 1;
		g().RowStyles.Add(new RowStyle());
		g().Size = new Size(135, 16);
		g().TabIndex = 3;
		h().Anchor = AnchorStyles.None;
		h().AutoSize = true;
		h().Location = new Point(57, 0);
		h().Name = "LabelStatus";
		h().Size = new Size(75, 16);
		h().TabIndex = 5;
		h().Text = "Not Started";
		i().Anchor = AnchorStyles.None;
		i().AutoSize = true;
		i().Location = new Point(3, 0);
		i().Name = "LabelStatusLabel";
		i().Size = new Size(48, 16);
		i().TabIndex = 4;
		i().Text = "Status:";
		j().Anchor = AnchorStyles.None;
		j().Location = new Point(3, 83);
		j().Name = "ProgressBarThe";
		j().Size = new Size(240, 20);
		j().TabIndex = 2;
		base.AcceptButton = c();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = d();
		base.ClientSize = new Size(265, 221);
		base.Controls.Add(f());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogLightSourceAdjust";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Light Source Adjustment";
		b().ResumeLayout(performLayout: false);
		b().PerformLayout();
		f().ResumeLayout(performLayout: false);
		f().PerformLayout();
		g().ResumeLayout(performLayout: false);
		g().PerformLayout();
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
		EventHandler value = a;
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
	internal virtual Button d()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
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
	internal virtual void a(Label A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel f()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel g()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
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
	internal virtual void b(Label A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label i()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ProgressBar j()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ProgressBar A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.c k()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void c(r.c A_0)
	{
		r.c.a a_ = b;
		r.c.b a_2 = a;
		r.c.a a_3 = a;
		r.c c10 = q;
		if (c10 != null)
		{
			c10.u(a_);
			c10.u(a_2);
			c10.w(a_3);
		}
		q = A_0;
		c10 = q;
		if (c10 != null)
		{
			c10.t(a_);
			c10.t(a_2);
			c10.v(a_3);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d l()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		r.d.b a_ = a;
		r?.e(a_);
		r = A_0;
		r?.d(a_);
	}

	public void a(fz A_0, f1 A_1, Guid A_2, string A_3, ref bool A_4)
	{
		this.m_l = A_0;
		m = A_1;
		n = A_2;
		string A_5 = "LightSourceAdjustment";
		Text = hu.a(ref A_5);
		Label label = i();
		A_5 = "Status";
		label.Text = hu.a(ref A_5);
		Button button = c();
		A_5 = "DoAdjustment";
		button.Text = hu.a(ref A_5);
		Button button2 = d();
		A_5 = "CancelString";
		button2.Text = hu.a(ref A_5);
		Label label2 = h();
		A_5 = "NotStarted";
		label2.Text = hu.a(ref A_5);
		j().Maximum = 10000;
		if (m.t7(n))
		{
			Label label3 = e();
			A_5 = "LightSourceSetPointInstructionsFmt1";
			label3.Text = string.Format(hu.a(ref A_5), A_3);
		}
		else
		{
			o = true;
			Button button3 = d();
			A_5 = "Skip";
			button3.Text = hu.a(ref A_5);
			Label label4 = e();
			A_5 = "LightSourcePeriodicSetPointInstructionsFmt1";
			label4.Text = string.Format(hu.a(ref A_5), A_3);
		}
		ShowDialog();
		A_4 = !p && o;
	}

	private void a(bool A_0)
	{
		base.ControlBox = A_0;
		d().Enabled = A_0;
		if (A_0)
		{
			base.CancelButton = d();
		}
		else
		{
			base.CancelButton = null;
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		string left = c().Text;
		string A_2 = "Abort";
		if (Operators.CompareString(left, hu.a(ref A_2), TextCompare: false) == 0)
		{
			k().a = true;
			return;
		}
		Button button = c();
		A_2 = "Abort";
		button.Text = hu.a(ref A_2);
		a(A_0: false);
		m.m2(n, k(), l(), global::r.d.a.b.a);
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
			string A_1;
			if (A_0.a == global::r.d.a.a.a)
			{
				Label label = h();
				A_1 = "Completed";
				label.Text = hu.a(ref A_1);
				c().Visible = false;
				Button button = d();
				A_1 = "Close";
				button.Text = hu.a(ref A_1);
				p = true;
			}
			else if (k().a)
			{
				Label label2 = h();
				A_1 = "Aborted";
				label2.Text = hu.a(ref A_1);
			}
			else
			{
				Label label3 = h();
				A_1 = "Failed";
				label3.Text = hu.a(ref A_1);
			}
			Button button2 = c();
			A_1 = "DoAdjustment";
			button2.Text = hu.a(ref A_1);
			j().Visible = false;
			k().a = false;
			a(A_0: true);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_l.c(fz.b.b, "Error in DialogLightSourceAdjustmCompletionTask_TaskFinishedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(r.c A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new r.c.a(b), A_0);
			}
			else
			{
				j().Visible = true;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_l.c(fz.b.b, "Error in DialogLightSourceAdjustmStatus_LongStepStartingEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.c A_0, bool A_1)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new r.c.b(a), A_0, A_1);
			}
			else
			{
				j().Value = checked((int)Math.Round(0.01 * (double)A_0.t() * 10000.0));
				h().Text = k().u();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_l.c(fz.b.b, "Error in DialogLightSourceAdjustmStatus_StatusChangedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.c A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new r.c.a(a), A_0);
			}
			else
			{
				j().Visible = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_l.c(fz.b.b, "Error in DialogLightSourceAdjustmStatus_LongStepFinishedEvent", a_);
			ProjectData.ClearProjectError();
		}
	}
}
