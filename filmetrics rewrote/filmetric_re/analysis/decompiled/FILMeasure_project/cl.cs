using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class cl : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private GroupBox m_d;

	[CompilerGenerated]
	private LinkLabel m_e;

	[CompilerGenerated]
	private Button m_f;

	[CompilerGenerated]
	private ComboBox m_g;

	[CompilerGenerated]
	private GroupBox m_h;

	[CompilerGenerated]
	private hy m_i;

	[CompilerGenerated]
	private Label m_j;

	[CompilerGenerated]
	private Label m_k;

	[CompilerGenerated]
	private Label m_l;

	[CompilerGenerated]
	private Label m_m;

	[CompilerGenerated]
	private ComboBox m_n;

	[CompilerGenerated]
	private LinkLabel m_o;

	[CompilerGenerated]
	private TableLayoutPanel m_p;

	[CompilerGenerated]
	private TableLayoutPanel m_q;

	[CompilerGenerated]
	private GroupBox m_r;

	[CompilerGenerated]
	private Label m_s;

	[CompilerGenerated]
	private hy m_t;

	[CompilerGenerated]
	private Label m_u;

	[CompilerGenerated]
	private CheckBox m_v;

	private fz m_w;

	private float m_x;

	private List<iu> m_y;

	private string m_z;

	private string m_aa;

	private bool m_ab;

	private string ac;

	private g2.a ad;

	private List<it> ae;

	private bool af;

	private int ag;

	private h.f[] ah;

	private @is.a ai;

	private bool aj;

	private f1 ak;

	private int al;

	private const string am = "DialogAdvancedAcqSettings.";

	private const string an = "-";

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
	private void g()
	{
		a(new Button());
		b(new Button());
		a(new GroupBox());
		a(new CheckBox());
		b(new LinkLabel());
		b(new ComboBox());
		c(new Label());
		d(new Label());
		a(new LinkLabel());
		c(new Button());
		a(new ComboBox());
		b(new GroupBox());
		a(new hy());
		a(new Label());
		b(new Label());
		a(new TableLayoutPanel());
		b(new TableLayoutPanel());
		c(new GroupBox());
		e(new Label());
		b(new hy());
		f(new Label());
		j().SuspendLayout();
		n().SuspendLayout();
		v().SuspendLayout();
		w().SuspendLayout();
		x().SuspendLayout();
		SuspendLayout();
		h().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		h().Cursor = Cursors.Default;
		h().DialogResult = DialogResult.Cancel;
		h().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		h().ForeColor = SystemColors.ControlText;
		h().Location = new Point(109, 3);
		h().Name = "ButtonCancel";
		h().Size = new Size(100, 30);
		h().TabIndex = 3;
		h().Text = "Cancel";
		i().Anchor = AnchorStyles.None;
		i().Cursor = Cursors.Default;
		i().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		i().ForeColor = SystemColors.ControlText;
		i().Location = new Point(3, 3);
		i().Name = "ButtonOK";
		i().Size = new Size(100, 30);
		i().TabIndex = 2;
		i().Text = "OK";
		j().Controls.Add(ab());
		j().Controls.Add(u());
		j().Controls.Add(t());
		j().Controls.Add(r());
		j().Controls.Add(s());
		j().Controls.Add(k());
		j().Controls.Add(l());
		j().Controls.Add(m());
		j().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		j().Location = new Point(3, 3);
		j().Name = "GroupBoxStoreBaseline";
		j().Size = new Size(456, 150);
		j().TabIndex = 0;
		j().TabStop = false;
		j().Text = "Baseline Settings";
		ab().AutoSize = true;
		ab().Location = new Point(8, -2);
		ab().Name = "CheckBoxStoreBaselineSettingsInRecipe";
		ab().Size = new Size(224, 20);
		ab().TabIndex = 94;
		ab().Text = "Store Baseline settings in Recipe";
		ab().UseVisualStyleBackColor = true;
		u().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		u().Location = new Point(13, 106);
		u().Name = "LinkLabelRefMat";
		u().Size = new Size(142, 23);
		u().TabIndex = 93;
		u().TabStop = true;
		u().Text = "Reflectance Standard:";
		u().TextAlign = ContentAlignment.MiddleRight;
		t().DropDownStyle = ComboBoxStyle.DropDownList;
		t().Enabled = false;
		t().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		t().FormattingEnabled = true;
		t().Location = new Point(156, 105);
		t().Name = "ComboBoxRefMats";
		t().Size = new Size(165, 24);
		t().TabIndex = 1;
		r().BackColor = SystemColors.ButtonHighlight;
		r().BorderStyle = BorderStyle.Fixed3D;
		r().Location = new Point(156, 32);
		r().Name = "LabelOpticsConfig";
		r().Size = new Size(250, 23);
		r().TabIndex = 92;
		r().Text = "ContactProbeHandheld AutoBaseline";
		r().TextAlign = ContentAlignment.MiddleCenter;
		s().AutoSize = true;
		s().Location = new Point(24, 35);
		s().Name = "Label4";
		s().Size = new Size(130, 16);
		s().TabIndex = 91;
		s().Text = "Optics Configuration:";
		k().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		k().Location = new Point(42, 75);
		k().Name = "LinkLabelNamedBaseline";
		k().Size = new Size(113, 23);
		k().TabIndex = 86;
		k().TabStop = true;
		k().Text = "Baseline Name:";
		k().TextAlign = ContentAlignment.MiddleRight;
		l().Enabled = false;
		l().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		l().Location = new Point(337, 78);
		l().Name = "ButtonDeleteStoredBaseline";
		l().Size = new Size(91, 46);
		l().TabIndex = 2;
		l().Text = "Delete";
		l().UseVisualStyleBackColor = true;
		m().Enabled = false;
		m().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		m().FormattingEnabled = true;
		m().Location = new Point(156, 75);
		m().Name = "ComboBoxStoredBaselines";
		m().Size = new Size(165, 24);
		m().TabIndex = 0;
		n().Controls.Add(o());
		n().Controls.Add(p());
		n().Controls.Add(q());
		n().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		n().Location = new Point(3, 159);
		n().Name = "GroupBox1";
		n().Size = new Size(456, 87);
		n().TabIndex = 1;
		n().TabStop = false;
		n().Text = "Continuous Measure Settings";
		o().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		o().f(A_0: false);
		o().Location = new Point(271, 40);
		o().Name = "TextBoxMeasureDelay";
		o().e(A_0: false);
		o().Size = new Size(71, 22);
		o().TabIndex = 0;
		o().TextAlign = HorizontalAlignment.Right;
		p().AutoSize = true;
		p().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		p().Location = new Point(346, 43);
		p().Name = "Label2";
		p().Size = new Size(60, 16);
		p().TabIndex = 83;
		p().Text = "seconds";
		q().AutoSize = true;
		q().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		q().Location = new Point(32, 43);
		q().Name = "LabelMeasureDelay";
		q().Size = new Size(237, 16);
		q().TabIndex = 82;
		q().Text = "Continuous Measure sampling interval:";
		v().AutoSize = true;
		v().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		v().ColumnCount = 1;
		v().ColumnStyles.Add(new ColumnStyle());
		v().Controls.Add(w(), 0, 3);
		v().Controls.Add(j(), 0, 0);
		v().Controls.Add(n(), 0, 1);
		v().Controls.Add(x(), 0, 2);
		v().Location = new Point(13, 12);
		v().Name = "TableLayoutPanel1";
		v().RowCount = 4;
		v().RowStyles.Add(new RowStyle());
		v().RowStyles.Add(new RowStyle());
		v().RowStyles.Add(new RowStyle());
		v().RowStyles.Add(new RowStyle());
		v().Size = new Size(462, 360);
		v().TabIndex = 4;
		w().Anchor = AnchorStyles.None;
		w().ColumnCount = 2;
		w().ColumnStyles.Add(new ColumnStyle());
		w().ColumnStyles.Add(new ColumnStyle());
		w().Controls.Add(i(), 0, 0);
		w().Controls.Add(h(), 1, 0);
		w().Location = new Point(126, 321);
		w().Name = "TableLayoutPanel2";
		w().RowCount = 1;
		w().RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		w().Size = new Size(210, 36);
		w().TabIndex = 5;
		x().Controls.Add(y());
		x().Controls.Add(z());
		x().Controls.Add(aa());
		x().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x().Location = new Point(3, 252);
		x().Name = "GroupBoxSmoothing";
		x().Size = new Size(456, 63);
		x().TabIndex = 2;
		x().TabStop = false;
		x().Text = "Smoothing ";
		y().AutoSize = true;
		y().Location = new Point(228, 29);
		y().Name = "LabelSmoothingUnits";
		y().Size = new Size(26, 16);
		y().TabIndex = 2;
		y().Text = "nm";
		z().f(A_0: false);
		z().Location = new Point(143, 25);
		z().Name = "txtSmoothingThickness";
		z().e(A_0: false);
		z().Size = new Size(83, 22);
		z().TabIndex = 1;
		z().TextAlign = HorizontalAlignment.Right;
		aa().AutoSize = true;
		aa().Location = new Point(24, 28);
		aa().Name = "Label1";
		aa().Size = new Size(112, 16);
		aa().TabIndex = 0;
		aa().Text = "Optical thickness:";
		base.AcceptButton = i();
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = h();
		base.ClientSize = new Size(488, 380);
		base.Controls.Add(v());
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogAdvancedAcqSettings";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Advanced Acquisition Settings";
		j().ResumeLayout(performLayout: false);
		j().PerformLayout();
		n().ResumeLayout(performLayout: false);
		n().PerformLayout();
		v().ResumeLayout(performLayout: false);
		w().ResumeLayout(performLayout: false);
		x().ResumeLayout(performLayout: false);
		x().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button h()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button i()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = f;
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
	internal virtual GroupBox j()
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
	internal virtual LinkLabel k()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(LinkLabel A_0)
	{
		LinkLabelLinkClickedEventHandler value = b;
		LinkLabel linkLabel = this.m_e;
		if (linkLabel != null)
		{
			linkLabel.LinkClicked -= value;
		}
		this.m_e = A_0;
		linkLabel = this.m_e;
		if (linkLabel != null)
		{
			linkLabel.LinkClicked += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button l()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = e;
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
	internal virtual ComboBox m()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
	{
		EventHandler value = c;
		EventHandler value2 = b;
		ComboBox comboBox = this.m_g;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
			comboBox.TextChanged -= value2;
		}
		this.m_g = A_0;
		comboBox = this.m_g;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
			comboBox.TextChanged += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox n()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(GroupBox A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy o()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hy A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label p()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label q()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label r()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label s()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox t()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ComboBox A_0)
	{
		EventHandler value = a;
		ComboBox comboBox = this.m_n;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_n = A_0;
		comboBox = this.m_n;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual LinkLabel u()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(LinkLabel A_0)
	{
		LinkLabelLinkClickedEventHandler value = a;
		LinkLabel linkLabel = this.m_o;
		if (linkLabel != null)
		{
			linkLabel.LinkClicked -= value;
		}
		this.m_o = A_0;
		linkLabel = this.m_o;
		if (linkLabel != null)
		{
			linkLabel.LinkClicked += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel v()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel w()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox x()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(GroupBox A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label y()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy z()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(hy A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aa()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox ab()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(CheckBox A_0)
	{
		EventHandler value = d;
		CheckBox checkBox = this.m_v;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_v = A_0;
		checkBox = this.m_v;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		string A_2 = "";
		try
		{
			if (a(ref A_2))
			{
				this.m_x = iz.d(o().Text);
				if (!d())
				{
					ComboBox comboBox = m();
					if (Operators.CompareString(comboBox.Text, "<Default>", TextCompare: false) == 0)
					{
						this.m_z = "";
					}
					else
					{
						this.m_z = comboBox.Text;
					}
					comboBox = null;
					ComboBox comboBox2 = t();
					if (Operators.CompareString(comboBox2.Text, "<Default>", TextCompare: false) == 0)
					{
						this.m_aa = ac;
						this.m_ab = false;
					}
					else
					{
						this.m_aa = comboBox2.Text;
						this.m_ab = true;
					}
					if (ad == g2.a.b)
					{
						this.m_aa = ex.e() + this.m_aa;
					}
					comboBox2 = null;
				}
				aj = !ab().Checked;
				base.DialogResult = DialogResult.OK;
			}
			else
			{
				fe.b(this.m_w, A_2, i6.a(i()));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_w.c(fz.b.a, " Error in DialogAdvancedAcqSettings.ButtonOK_Click", a_);
			fe.b(this.m_w, " Error in DialogAdvancedAcqSettings.ButtonOK_Click", i6.a(i()));
			ProjectData.ClearProjectError();
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			if (m().Text.Trim().Length <= 0)
			{
				return;
			}
			string text = m().Text;
			if (Operators.CompareString(text, "<Default>", TextCompare: false) == 0)
			{
				fe.b(this.m_w, "Default stored baseline cannot be deleted", i6.a(l()));
				return;
			}
			FileInfo[] files = new DirectoryInfo(@is.b()).GetFiles(@is.c(ai, text));
			string left;
			foreach (it item in ae)
			{
				int num = item.g();
				left = ((ai != @is.a.a || ag != num || af) ? t().Text : "1");
				FileInfo[] array = files;
				foreach (FileInfo fileInfo in array)
				{
					if (Operators.CompareString(text, @is.b(fileInfo.Name, item.e()), TextCompare: false) == 0 && Operators.CompareString(left, io.m2(this.m_w, ai, fileInfo.FullName, g2.a(ad, ah[num])), TextCompare: false) == 0)
					{
						fileInfo.Delete();
					}
				}
			}
			left = t().Text;
			int num3 = this.m_y.IndexOf(new iu(text));
			if (Operators.CompareString(left, "1", TextCompare: false) == 0 && (ad == g2.a.c || ad == g2.a.b))
			{
				if (num3 >= 0)
				{
					c(text);
				}
				else
				{
					c(m(), null);
				}
				return;
			}
			List<string> list = this.m_y[num3].b;
			if (list.Contains(left))
			{
				list.Remove(left);
			}
			if (list.Count == 1)
			{
				c(text);
				c(m(), null);
			}
			else
			{
				e();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_w.c(fz.b.a, "Error in DialogAdvancedAcqSettings.ButtonDeleteStoredBaseline_Click", a_);
			fe.b(this.m_w, "Error in DialogAdvancedAcqSettings.ButtonDeleteStoredBaseline_Click", i6.a(i()));
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			bool enabled = ab().Checked;
			t().Enabled = enabled;
			m().Enabled = enabled;
			l().Enabled = enabled;
			if (!a())
			{
				e();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_w, ak, null, i6.a(ab()), "DialogAdvancedAcqSettings.CheckBoxStoreBaselineSettingsInRecipe_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		if (a())
		{
			return;
		}
		try
		{
			this.m_z = m().Text;
			ComboBox comboBox = t();
			if (ab().Checked)
			{
				comboBox.Items.Clear();
				if (af)
				{
					comboBox.Items.Add("1");
					comboBox.SelectedIndex = 0;
					comboBox.Enabled = false;
				}
				else
				{
					int num = this.m_y.IndexOf(new iu(m().Text));
					if (num >= 0)
					{
						List<string> list = this.m_y[num].b;
						foreach (string item in list)
						{
							if (ad == g2.a.b && item.StartsWith(ex.e()))
							{
								comboBox.Items.Add(item.Substring(ex.e().Length));
							}
							else
							{
								comboBox.Items.Add(item);
							}
						}
					}
					else
					{
						comboBox.Items.Add("<Default>");
					}
					if (ad == g2.a.b && this.m_aa.StartsWith(ex.e()))
					{
						comboBox.SelectedIndex = a(this.m_aa.Substring(ex.e().Length));
					}
					else
					{
						comboBox.SelectedIndex = a(this.m_aa);
					}
				}
			}
			else
			{
				comboBox.Items.Clear();
			}
			comboBox = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_w.c(fz.b.a, " Error in DialogAdvancedAcqSettings.ComboBoxStoredBaselines_SelectedIndexChanged", a_);
			fe.b(this.m_w, " Error in DialogAdvancedAcqSettings.ComboBoxStoredBaselines_SelectedIndexChanged", i6.a(i()));
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			if (!a())
			{
				c(m(), null);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_w.c(fz.b.a, " Error in DialogAdvancedAcqSettings.ComboBoxStoredBaselines_TextChanged", a_);
			fe.b(this.m_w, " Error in DialogAdvancedAcqSettings.ComboBoxStoredBaselines_TextChanged", i6.a(i()));
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			if (Operators.CompareString(t().Text, "<Default>", TextCompare: false) == 0)
			{
				l().Enabled = false;
			}
			else if (f())
			{
				l().Enabled = true;
			}
			else
			{
				l().Enabled = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_w.c(fz.b.a, " Error in DialogAdvancedAcqSettings.ComboBoxRefMats_SelectedIndexChanged", a_);
			fe.b(this.m_w, " Error in DialogAdvancedAcqSettings.ComboBoxRefMats_SelectedIndexChanged", i6.a(i()));
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, LinkLabelLinkClickedEventArgs A_1)
	{
		try
		{
			fz a_ = this.m_w;
			string A_2 = "NamedBaselineWhatIs";
			fe.b(a_, hu.a(ref A_2), "Information", i6.a(k()));
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			this.m_w.c(fz.b.a, " Error in DialogAdvancedAcqSettings.LinkLabelNamedBaseline_LinkClicked", a_2);
			fe.b(this.m_w, " Error in DialogAdvancedAcqSettings.LinkLabelNamedBaseline_LinkClicked", i6.a(i()));
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, LinkLabelLinkClickedEventArgs A_1)
	{
		try
		{
			fz a_ = this.m_w;
			string A_2 = "NamedBaselineRefMatWhatIs";
			fe.b(a_, hu.a(ref A_2), "Information", i6.a(k()));
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			this.m_w.c(fz.b.a, " Error in DialogAdvancedAcqSettings.LinkLabelRefMat_LinkClicked", a_2);
			fe.b(this.m_w, " Error in DialogAdvancedAcqSettings.LinkLabelRefMat_LinkClicked", i6.a(i()));
			ProjectData.ClearProjectError();
		}
	}

	private void c(string A_0)
	{
		ComboBox comboBox = m();
		comboBox.DataSource = null;
		this.m_y.Remove(new iu(A_0));
		comboBox.DataSource = this.m_y;
		comboBox.SelectedIndex = 0;
		_ = null;
	}

	private bool f()
	{
		string text = m().Text;
		string left = t().Text;
		_ = string.Empty;
		bool result = false;
		DirectoryInfo directoryInfo = new DirectoryInfo(@is.b());
		Operators.CompareString(text, "<Default>", TextCompare: false);
		FileInfo[] files = directoryInfo.GetFiles(@is.c(ai, text));
		g2.OpticsConfigSubmoduleTypes a_ = default(g2.OpticsConfigSubmoduleTypes);
		if (ah != null)
		{
			a_ = g2.a(ad, ah[0]);
		}
		foreach (it item in ae)
		{
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				if (Operators.CompareString(text, @is.b(fileInfo.Name, item.e()), TextCompare: false) == 0 && Operators.CompareString(left, io.m2(this.m_w, ai, fileInfo.FullName, a_), TextCompare: false) == 0)
				{
					result = true;
					break;
				}
			}
		}
		return result;
	}

	private bool a(ref string A_0)
	{
		if (!float.TryParse(o().Text, out var result))
		{
			string A_1 = "InvalidEntryFmt";
			A_0 = string.Format(hu.a(ref A_1), q().Text);
			return false;
		}
		if (result < 0f || (double)result > 604800.0)
		{
			string A_1 = "ValuesBetweenFmt3";
			A_0 = string.Format(hu.a(ref A_1), q().Text, 0, 604800.0);
			return false;
		}
		if (!d() && ab().Checked && m().SelectedIndex == -1)
		{
			string text = i3.g(m().Text);
			if (!text.Equals(m().Text))
			{
				string A_1 = "InvalidFileCharsFmt2";
				A_0 = string.Format(hu.a(ref A_1), m().Text, text);
				m().Text = text;
				return false;
			}
		}
		return true;
	}

	private void e()
	{
		ComboBox comboBox = m();
		if (ab().Checked)
		{
			b();
			try
			{
				comboBox.DataSource = null;
				comboBox.Items.Clear();
				comboBox.DataSource = this.m_y;
			}
			finally
			{
				c();
			}
			int num = b(this.m_z);
			if (comboBox.SelectedIndex != num)
			{
				comboBox.SelectedIndex = num;
			}
			else
			{
				c(m(), null);
			}
			if (num == -1)
			{
				m().Text = this.m_z;
			}
		}
		else
		{
			b();
			try
			{
				comboBox.DataSource = null;
				comboBox.Items.Clear();
			}
			finally
			{
				c();
			}
		}
		comboBox = null;
	}

	private int b(string A_0)
	{
		ComboBox comboBox = m();
		if (string.IsNullOrEmpty(A_0))
		{
			return comboBox.FindStringExact("<Default>");
		}
		return comboBox.FindStringExact(A_0);
	}

	private int a(string A_0)
	{
		int num = 0;
		ComboBox comboBox = t();
		num = ((!this.m_ab) ? (-1) : ((!string.IsNullOrEmpty(A_0) && Operators.CompareString(A_0, "<Default>", TextCompare: false) != 0) ? comboBox.FindStringExact(A_0) : comboBox.FindStringExact(ac)));
		if (num == -1)
		{
			num = comboBox.FindStringExact("<Default>");
		}
		comboBox = null;
		return num;
	}

	private bool d()
	{
		if (g2.j(ad))
		{
			return ad != g2.a.b;
		}
		return false;
	}

	private void c()
	{
		checked
		{
			al--;
			if (al < 0)
			{
				al = 0;
			}
		}
	}

	private void b()
	{
		checked
		{
			al++;
		}
	}

	[SpecialName]
	private bool a()
	{
		return al > 0;
	}

	public void a(f1 A_0, List<iu> A_1, g2.a A_2, List<it> A_3, string A_4, bool A_5, int A_6, h.f[] A_7, bool A_8, @is.a A_9, ref float A_10, ref string A_11, ref string A_12, ref bool A_13, ref float A_14, ref bool A_15)
	{
		ak = A_0;
		aj = A_15;
		this.m_x = A_10;
		ad = A_2;
		o().Text = Conversions.ToString(this.m_x);
		r().Text = g2.n(ad);
		this.m_z = A_11;
		ai = A_9;
		this.m_aa = A_12;
		this.m_ab = A_13;
		ag = A_6;
		ah = A_7;
		if (d() || g2.a(ad))
		{
			j().Enabled = false;
		}
		else
		{
			this.m_y = A_1;
			ae = A_3;
			ab().Checked = !aj;
			if (ad == g2.a.b && A_4.StartsWith(ex.e()))
			{
				ac = A_4.Substring(ex.e().Length);
			}
			else
			{
				ac = A_4;
			}
			af = A_5;
			e();
		}
		x().Visible = A_8;
		if (A_8)
		{
			z().Text = hg.bu(1, A_14, new h4(h4.a.c));
			y().Text = h4.e(new h4(h4.a.c), false, false);
		}
		ShowDialog();
		if (base.DialogResult == DialogResult.OK)
		{
			A_10 = this.m_x;
			A_11 = this.m_z;
			A_12 = this.m_aa;
			A_13 = this.m_ab;
			A_15 = aj;
			if (A_8)
			{
				A_14 = (float)new h4(h4.a.c).e(iz.e(z().Text));
			}
		}
	}

	public cl()
	{
		g();
	}

	public cl(fz A_0)
		: this()
	{
		this.m_w = A_0;
	}
}
