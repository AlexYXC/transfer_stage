using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class a8 : Form
{
	private IContainer a;

	[CompilerGenerated]
	private TableLayoutPanel b;

	[CompilerGenerated]
	private Button c;

	[CompilerGenerated]
	private Button d;

	[CompilerGenerated]
	private GroupBox e;

	[CompilerGenerated]
	private RadioButton f;

	[CompilerGenerated]
	private RadioButton g;

	[CompilerGenerated]
	private GroupBox h;

	[CompilerGenerated]
	private hy i;

	[CompilerGenerated]
	private hy j;

	[CompilerGenerated]
	private Label k;

	[CompilerGenerated]
	private Label l;

	[CompilerGenerated]
	private Label m;

	[CompilerGenerated]
	private Label m_n;

	private float m_o;

	private float m_p;

	private float m_q;

	private float m_r;

	private f1 m_s;

	private fz m_t;

	private f4 m_u;

	private const string m_v = "DialogAdvancedCalibObjective";

	public a8()
	{
		o();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && a != null)
			{
				a.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void o()
	{
		n(new TableLayoutPanel());
		n(new Button());
		o(new Button());
		n(new GroupBox());
		n(new RadioButton());
		o(new RadioButton());
		o(new GroupBox());
		n(new hy());
		o(new hy());
		n(new Label());
		o(new Label());
		p(new Label());
		q(new Label());
		p().SuspendLayout();
		s().SuspendLayout();
		v().SuspendLayout();
		SuspendLayout();
		p().Anchor = AnchorStyles.None;
		p().AutoSize = true;
		p().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		p().ColumnCount = 2;
		p().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		p().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		p().Controls.Add(q(), 0, 0);
		p().Controls.Add(r(), 1, 0);
		p().Location = new Point(35, 177);
		p().Name = "TableLayoutPanel3";
		p().RowCount = 1;
		p().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		p().Size = new Size(146, 39);
		p().TabIndex = 10;
		q().Anchor = AnchorStyles.Right;
		q().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		q().Location = new Point(3, 3);
		q().Name = "OK_Button";
		q().Size = new Size(67, 33);
		q().TabIndex = 10;
		q().Text = "&OK";
		r().Anchor = AnchorStyles.Left;
		r().DialogResult = DialogResult.Cancel;
		r().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		r().Location = new Point(76, 3);
		r().Name = "Cancel_Button";
		r().Size = new Size(67, 33);
		r().TabIndex = 11;
		r().Text = "&Cancel";
		s().BackColor = Color.Transparent;
		s().Controls.Add(t());
		s().Controls.Add(u());
		s().Controls.Add(v());
		s().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		s().ForeColor = Color.DimGray;
		s().Location = new Point(12, 12);
		s().Name = "RangeFrame";
		s().RightToLeft = RightToLeft.No;
		s().Size = new Size(185, 147);
		s().TabIndex = 21;
		s().TabStop = false;
		s().Text = "Wavelength Range";
		t().BackColor = Color.Transparent;
		t().Cursor = Cursors.Default;
		t().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		t().ForeColor = SystemColors.ControlText;
		t().Location = new Point(26, 43);
		t().Name = "RadioButtonWaveRangeRestricted";
		t().RightToLeft = RightToLeft.No;
		t().Size = new Size(100, 26);
		t().TabIndex = 2;
		t().TabStop = true;
		t().Text = "Restricted";
		t().UseVisualStyleBackColor = false;
		u().BackColor = Color.Transparent;
		u().Cursor = Cursors.Default;
		u().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		u().ForeColor = SystemColors.ControlText;
		u().Location = new Point(26, 22);
		u().Name = "RadioButtonWaveRangeAuto";
		u().RightToLeft = RightToLeft.No;
		u().Size = new Size(119, 19);
		u().TabIndex = 1;
		u().TabStop = true;
		u().Text = "Auto";
		u().UseVisualStyleBackColor = false;
		v().BackColor = Color.Transparent;
		v().Controls.Add(w());
		v().Controls.Add(x());
		v().Controls.Add(y());
		v().Controls.Add(z());
		v().Controls.Add(aa());
		v().Controls.Add(ab());
		v().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		v().ForeColor = SystemColors.ControlText;
		v().Location = new Point(17, 49);
		v().Name = "WavelengthLimitsFrame";
		v().RightToLeft = RightToLeft.No;
		v().Size = new Size(151, 83);
		v().TabIndex = 2;
		v().TabStop = false;
		w().AcceptsReturn = true;
		w().BackColor = SystemColors.Window;
		w().Cursor = Cursors.IBeam;
		w().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		w().ForeColor = SystemColors.WindowText;
		w().f(A_0: false);
		w().Location = new Point(55, 47);
		w().MaxLength = 0;
		w().Name = "EndWavelenBox";
		w().e(A_0: false);
		w().RightToLeft = RightToLeft.No;
		w().Size = new Size(57, 22);
		w().TabIndex = 4;
		w().Text = "850";
		w().TextAlign = HorizontalAlignment.Center;
		x().AcceptsReturn = true;
		x().BackColor = SystemColors.Window;
		x().Cursor = Cursors.IBeam;
		x().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x().ForeColor = SystemColors.WindowText;
		x().f(A_0: false);
		x().Location = new Point(55, 20);
		x().MaxLength = 0;
		x().Name = "StartWavelenBox";
		x().e(A_0: false);
		x().RightToLeft = RightToLeft.No;
		x().Size = new Size(57, 22);
		x().TabIndex = 3;
		x().Text = "400";
		x().TextAlign = HorizontalAlignment.Center;
		y().AutoSize = true;
		y().BackColor = Color.Transparent;
		y().Cursor = Cursors.Default;
		y().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		y().ForeColor = SystemColors.ControlText;
		y().Location = new Point(32, 50);
		y().Name = "Label27";
		y().RightToLeft = RightToLeft.No;
		y().Size = new Size(21, 16);
		y().TabIndex = 67;
		y().Text = "To";
		y().TextAlign = ContentAlignment.MiddleRight;
		z().BackColor = Color.Transparent;
		z().Cursor = Cursors.Default;
		z().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		z().ForeColor = SystemColors.ControlText;
		z().Location = new Point(115, 49);
		z().Name = "Label28";
		z().RightToLeft = RightToLeft.No;
		z().Size = new Size(26, 17);
		z().TabIndex = 66;
		z().Text = "nm";
		aa().BackColor = Color.Transparent;
		aa().Cursor = Cursors.Default;
		aa().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aa().ForeColor = SystemColors.ControlText;
		aa().Location = new Point(115, 23);
		aa().Name = "Label29";
		aa().RightToLeft = RightToLeft.No;
		aa().Size = new Size(26, 17);
		aa().TabIndex = 65;
		aa().Text = "nm";
		ab().AutoSize = true;
		ab().BackColor = Color.Transparent;
		ab().Cursor = Cursors.Default;
		ab().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ab().ForeColor = SystemColors.ControlText;
		ab().Location = new Point(15, 23);
		ab().Name = "Label31";
		ab().RightToLeft = RightToLeft.No;
		ab().Size = new Size(38, 16);
		ab().TabIndex = 64;
		ab().Text = "From";
		ab().TextAlign = ContentAlignment.MiddleRight;
		base.AcceptButton = q();
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = r();
		base.ClientSize = new Size(217, 228);
		base.Controls.Add(s());
		base.Controls.Add(p());
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogAdvancedCalibObjective";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Advanced Ojective Calibration";
		p().ResumeLayout(performLayout: false);
		s().ResumeLayout(performLayout: false);
		v().ResumeLayout(performLayout: false);
		v().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual TableLayoutPanel p()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void n(TableLayoutPanel A_0)
	{
		b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button q()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void n(Button A_0)
	{
		EventHandler value = p;
		Button button = c;
		if (button != null)
		{
			button.Click -= value;
		}
		c = A_0;
		button = c;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button r()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void o(Button A_0)
	{
		d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox s()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void n(GroupBox A_0)
	{
		e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton t()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void n(RadioButton A_0)
	{
		EventHandler value = n;
		RadioButton radioButton = f;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		f = A_0;
		radioButton = f;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton u()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void o(RadioButton A_0)
	{
		EventHandler value = o;
		RadioButton radioButton = g;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		g = A_0;
		radioButton = g;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox v()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void o(GroupBox A_0)
	{
		h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy w()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void n(hy A_0)
	{
		i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual hy x()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void o(hy A_0)
	{
		j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label y()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void n(Label A_0)
	{
		k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label z()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void o(Label A_0)
	{
		l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aa()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void p(Label A_0)
	{
		m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ab()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void q(Label A_0)
	{
		this.m_n = A_0;
	}

	public void n(et A_0, ref bool A_1, fz A_2, f1 A_3, f4 A_4)
	{
		this.m_t = A_2;
		this.m_s = A_3;
		this.m_u = A_4;
		double A_5 = default(double);
		double A_6 = default(double);
		this.m_s.m2(this.m_u.hc(), 0, ref A_5, ref A_6);
		float A_7 = default(float);
		float A_8 = default(float);
		bool A_9 = default(bool);
		A_0.t(A_5, A_6, ref A_7, ref A_8, ref A_9);
		if (A_9)
		{
			this.m_o = 1000f;
			this.m_p = 1600f;
		}
		else
		{
			this.m_o = 470f;
			this.m_p = 750f;
		}
		if (n(A_0.x(), A_0.y()))
		{
			A_1 = false;
			x().Text = i6.a(this.m_o, "#.###");
			w().Text = i6.a(this.m_p, "#.###");
		}
		else
		{
			A_1 = A_0.x() != this.m_o || A_0.y() != this.m_p;
			x().Text = i6.a(A_0.x(), "#.###");
			w().Text = i6.a(A_0.y(), "#.###");
		}
		if (A_1)
		{
			t().Select();
		}
		else
		{
			u().Select();
		}
		ShowDialog();
		if (base.DialogResult == DialogResult.OK)
		{
			A_1 = t().Checked;
			if (A_1)
			{
				A_0.x(this.m_q);
				A_0.y(this.m_r);
			}
		}
	}

	private void n()
	{
		bool enabled = t().Checked;
		x().Enabled = enabled;
		w().Enabled = enabled;
	}

	private bool n(float A_0, float A_1)
	{
		if (!(A_0 < this.m_o) && !(A_1 > this.m_p))
		{
			return A_0 >= A_1;
		}
		return true;
	}

	private void p(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_q = iz.d(x().Text);
			this.m_r = iz.d(w().Text);
			if (t().Checked && n(this.m_q, this.m_r))
			{
				string A_2 = "ValuesBetweenFmt3";
				string format = hu.a(ref A_2);
				A_2 = "RestrictedWavelengthRange";
				string a_ = string.Format(format, hu.a(ref A_2), this.m_o, this.m_p);
				ref fz a_2 = ref this.m_t;
				Point A_3 = i6.a(this);
				fe.b(ref a_2, a_, ref A_3);
			}
			else
			{
				base.DialogResult = DialogResult.OK;
				Close();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			i5.a(this.m_t, this.m_s, this.m_u, i6.a(q()), "DialogAdvancedCalibObjective", a_3);
			ProjectData.ClearProjectError();
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		try
		{
			t().Checked = !u().Checked;
			n();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_t, this.m_s, this.m_u, i6.a(q()), "DialogAdvancedCalibObjective", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void n(object A_0, EventArgs A_1)
	{
		try
		{
			u().Checked = !t().Checked;
			n();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_t, this.m_s, this.m_u, i6.a(q()), "DialogAdvancedCalibObjective", a_);
			ProjectData.ClearProjectError();
		}
	}
}
