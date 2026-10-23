using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class eg : Form
{
	private IContainer a;

	public ToolTip b;

	[CompilerGenerated]
	private Button c;

	[CompilerGenerated]
	private Button d;

	[CompilerGenerated]
	private GroupBox e;

	[CompilerGenerated]
	private ComboBox f;

	[CompilerGenerated]
	private Button g;

	[CompilerGenerated]
	private RadioButton h;

	[CompilerGenerated]
	private RadioButton i;

	[CompilerGenerated]
	private Label j;

	[CompilerGenerated]
	private Label k;

	[CompilerGenerated]
	private GroupBox l;

	[CompilerGenerated]
	private Label m_m;

	[CompilerGenerated]
	private Label n;

	[CompilerGenerated]
	private Button m_o;

	[CompilerGenerated]
	private TableLayoutPanel m_p;

	[CompilerGenerated]
	private Panel q;

	[CompilerGenerated]
	private GroupBox r;

	[CompilerGenerated]
	private Button m_s;

	private const string m_t = "DialogObjectiveSelection";

	private eu m_u;

	private eu m_v;

	private fz m_w;

	private f1 m_x;

	private f4 m_y;

	private string m_z;

	private Guid m_aa;

	private gr m_ab;

	private bool m_ac;

	[DebuggerNonUserCode]
	protected override void Dispose(bool Disposing)
	{
		if (Disposing && a != null)
		{
			a.Dispose();
		}
		base.Dispose(Disposing);
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button s()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void m(Button A_0)
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
	public virtual Button t()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void o(Button A_0)
	{
		EventHandler value = o;
		Button button = d;
		if (button != null)
		{
			button.Click -= value;
		}
		d = A_0;
		button = d;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox u()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void m(GroupBox A_0)
	{
		e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ComboBox v()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void m(ComboBox A_0)
	{
		f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button w()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void p(Button A_0)
	{
		EventHandler value = s;
		Button button = g;
		if (button != null)
		{
			button.Click -= value;
		}
		g = A_0;
		button = g;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton x()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void m(RadioButton A_0)
	{
		h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton y()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void o(RadioButton A_0)
	{
		i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label z()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void m(Label A_0)
	{
		j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aa()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void o(Label A_0)
	{
		k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox ab()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void o(GroupBox A_0)
	{
		l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ac()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void p(Label A_0)
	{
		this.m_m = A_0;
	}

	[DebuggerStepThrough]
	private void p()
	{
		a = new Container();
		b = new ToolTip(a);
		m(new GroupBox());
		m(new Button());
		o(new Button());
		m(new ComboBox());
		o(new GroupBox());
		s(new Label());
		p(new Button());
		m(new RadioButton());
		o(new RadioButton());
		m(new Label());
		o(new Label());
		p(new Label());
		s(new Button());
		m(new TableLayoutPanel());
		p(new GroupBox());
		t(new Button());
		m(new Panel());
		u().SuspendLayout();
		ab().SuspendLayout();
		af().SuspendLayout();
		ah().SuspendLayout();
		ag().SuspendLayout();
		SuspendLayout();
		u().Anchor = AnchorStyles.None;
		u().Controls.Add(s());
		u().Controls.Add(t());
		u().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		u().Location = new Point(9, 43);
		u().Name = "FrameExistingObj";
		u().RightToLeft = RightToLeft.No;
		u().Size = new Size(289, 65);
		u().TabIndex = 7;
		u().TabStop = false;
		u().Text = "Existing Objective";
		s().Cursor = Cursors.Default;
		s().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		s().Location = new Point(155, 27);
		s().Name = "ButtonEdit";
		s().RightToLeft = RightToLeft.No;
		s().Size = new Size(105, 32);
		s().TabIndex = 9;
		s().Text = "Edit...";
		s().UseVisualStyleBackColor = true;
		t().Cursor = Cursors.Default;
		t().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		t().Location = new Point(36, 27);
		t().Name = "ButtonDelete";
		t().RightToLeft = RightToLeft.No;
		t().Size = new Size(105, 32);
		t().TabIndex = 8;
		t().Text = "Delete";
		t().UseVisualStyleBackColor = true;
		v().BackColor = SystemColors.Window;
		v().Cursor = Cursors.Default;
		v().DropDownStyle = ComboBoxStyle.DropDownList;
		v().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		v().ForeColor = SystemColors.WindowText;
		v().Location = new Point(123, 4);
		v().Name = "ComboName";
		v().RightToLeft = RightToLeft.No;
		v().Size = new Size(169, 24);
		v().TabIndex = 4;
		ab().Anchor = AnchorStyles.None;
		ab().Controls.Add(ad());
		ab().Controls.Add(w());
		ab().Controls.Add(x());
		ab().Controls.Add(y());
		ab().Controls.Add(z());
		ab().Controls.Add(aa());
		ab().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ab().Location = new Point(9, 114);
		ab().Name = "FrameCreateNewObj";
		ab().RightToLeft = RightToLeft.No;
		ab().Size = new Size(289, 111);
		ab().TabIndex = 1;
		ab().TabStop = false;
		ab().Text = "Create New Objective";
		ad().AutoSize = true;
		ad().Location = new Point(207, 26);
		ad().Name = "Label3";
		ad().Size = new Size(12, 16);
		ad().TabIndex = 12;
		ad().Text = "/";
		w().BackColor = SystemColors.ButtonFace;
		w().Cursor = Cursors.Default;
		w().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		w().Location = new Point(155, 75);
		w().Name = "ButtonAdd";
		w().RightToLeft = RightToLeft.No;
		w().Size = new Size(105, 32);
		w().TabIndex = 6;
		w().Text = "Add...";
		w().TextAlign = ContentAlignment.TopCenter;
		w().UseVisualStyleBackColor = true;
		x().BackColor = SystemColors.Control;
		x().Cursor = Cursors.Default;
		x().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		x().ForeColor = SystemColors.ControlText;
		x().Location = new Point(145, 25);
		x().Name = "OptionBefore";
		x().RightToLeft = RightToLeft.No;
		x().Size = new Size(65, 17);
		x().TabIndex = 3;
		x().TabStop = true;
		x().Text = "before/";
		x().UseVisualStyleBackColor = false;
		y().BackColor = SystemColors.Control;
		y().Checked = true;
		y().Cursor = Cursors.Default;
		y().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		y().ForeColor = SystemColors.ControlText;
		y().Location = new Point(225, 26);
		y().Name = "OptionAfter";
		y().RightToLeft = RightToLeft.No;
		y().Size = new Size(58, 17);
		y().TabIndex = 2;
		y().TabStop = true;
		y().Text = "after";
		y().UseVisualStyleBackColor = false;
		z().BackColor = SystemColors.Control;
		z().Cursor = Cursors.Default;
		z().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		z().ForeColor = SystemColors.ControlText;
		z().Location = new Point(6, 55);
		z().Name = "Label2";
		z().RightToLeft = RightToLeft.No;
		z().Size = new Size(177, 17);
		z().TabIndex = 11;
		z().Text = "currently selected objective.";
		aa().BackColor = SystemColors.Control;
		aa().Cursor = Cursors.Default;
		aa().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aa().ForeColor = SystemColors.ControlText;
		aa().Location = new Point(6, 26);
		aa().Name = "Label1";
		aa().RightToLeft = RightToLeft.No;
		aa().Size = new Size(133, 17);
		aa().TabIndex = 10;
		aa().Text = "Insert new objective ";
		ac().BackColor = SystemColors.Control;
		ac().Cursor = Cursors.Default;
		ac().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ac().ForeColor = SystemColors.ControlText;
		ac().Location = new Point(3, 7);
		ac().Name = "LabelName";
		ac().RightToLeft = RightToLeft.No;
		ac().Size = new Size(114, 17);
		ac().TabIndex = 5;
		ac().Text = "Objective Name: ";
		ae().Anchor = AnchorStyles.Right;
		ae().Cursor = Cursors.Default;
		ae().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae().Location = new Point(224, 294);
		ae().Margin = new Padding(3, 3, 10, 3);
		ae().Name = "ButtonClose";
		ae().RightToLeft = RightToLeft.No;
		ae().Size = new Size(73, 28);
		ae().TabIndex = 8;
		ae().Text = "Close";
		ae().UseVisualStyleBackColor = true;
		af().AutoSize = true;
		af().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		af().ColumnCount = 1;
		af().ColumnStyles.Add(new ColumnStyle());
		af().Controls.Add(ah(), 0, 3);
		af().Controls.Add(ag(), 0, 0);
		af().Controls.Add(ae(), 0, 4);
		af().Controls.Add(u(), 0, 1);
		af().Controls.Add(ab(), 0, 2);
		af().Location = new Point(7, 7);
		af().Name = "TableLayoutPanel1";
		af().RowCount = 5;
		af().RowStyles.Add(new RowStyle());
		af().RowStyles.Add(new RowStyle());
		af().RowStyles.Add(new RowStyle());
		af().RowStyles.Add(new RowStyle());
		af().RowStyles.Add(new RowStyle());
		af().Size = new Size(307, 325);
		af().TabIndex = 9;
		ah().Anchor = AnchorStyles.None;
		ah().Controls.Add(ai());
		ah().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ah().Location = new Point(9, 231);
		ah().Name = "GroupBoxTurret";
		ah().RightToLeft = RightToLeft.No;
		ah().Size = new Size(289, 57);
		ah().TabIndex = 10;
		ah().TabStop = false;
		ah().Text = "Motorized Turret Configuration";
		ah().Visible = false;
		ai().Cursor = Cursors.Default;
		ai().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ai().Location = new Point(91, 21);
		ai().Name = "ButtonEditTurret";
		ai().RightToLeft = RightToLeft.No;
		ai().Size = new Size(105, 32);
		ai().TabIndex = 11;
		ai().Text = "Edit...";
		ai().UseVisualStyleBackColor = true;
		ag().Anchor = AnchorStyles.None;
		ag().Controls.Add(ac());
		ag().Controls.Add(v());
		ag().Location = new Point(3, 3);
		ag().Name = "PanelObjectiveName";
		ag().Size = new Size(301, 34);
		ag().TabIndex = 10;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		BackColor = SystemColors.Control;
		base.ClientSize = new Size(354, 365);
		base.Controls.Add(af());
		Cursor = Cursors.Default;
		Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Location = new Point(3, 29);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogObjectiveSelection";
		RightToLeft = RightToLeft.No;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.Manual;
		Text = "Add/Edit/Delete";
		u().ResumeLayout(performLayout: false);
		ab().ResumeLayout(performLayout: false);
		ab().PerformLayout();
		af().ResumeLayout(performLayout: false);
		ah().ResumeLayout(performLayout: false);
		ag().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ad()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(Label A_0)
	{
		n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ae()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void s(Button A_0)
	{
		EventHandler value = m;
		Button button = this.m_o;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_o = A_0;
		button = this.m_o;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel af()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(TableLayoutPanel A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel ag()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(Panel A_0)
	{
		q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox ah()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void p(GroupBox A_0)
	{
		r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ai()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void t(Button A_0)
	{
		this.m_s = A_0;
	}

	public eg(fz A_0)
	{
		p();
		this.m_w = A_0;
	}

	public void m(f1 A_0, f4 A_1, Guid A_2, gr A_3, ref eu A_4, ref int A_5, string A_6, Point A_7)
	{
		this.m_x = A_0;
		this.m_y = A_1;
		this.m_z = A_2.ToString();
		this.m_aa = A_2;
		this.m_ab = A_3;
		Text = A_6;
		this.m_u = A_4;
		this.m_v = new eu();
		this.m_u.f(this.m_v);
		this.m_v.h(this.m_u.i());
		m(A_5);
		m();
		i6.a(A_7, this);
		ShowDialog();
		A_5 = v().SelectedIndex;
	}

	private void s(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				es es2 = new et();
				int num;
				if (this.m_u.l().Count > 0)
				{
					if (x().Checked)
					{
						es2.t(es.u(this.m_u.k(), es2.al(), -1));
						this.m_u.l().Insert(v().SelectedIndex, es2);
						num = v().SelectedIndex;
					}
					else
					{
						this.m_u.l().Insert(v().SelectedIndex + 1, es2);
						num = v().SelectedIndex + 1;
					}
				}
				else
				{
					this.m_u.l().Add(es2);
					num = 0;
				}
				ef obj = new ef(this.m_w);
				List<short> a_ = null;
				obj.i(this.m_x, this.m_y, this.m_aa, this.m_ab, (et)es2, num, this.m_u.k(), this.m_ac, a_, i6.a(this));
				if (obj.DialogResult == DialogResult.OK)
				{
					m(num);
					o();
				}
				else
				{
					this.m_u.l().RemoveAt(num);
					es2 = null;
				}
				obj.Dispose();
				m();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				i5.a(this.m_w, this.m_x, this, i6.a(this), "DialogObjectiveSelectionButtonAdd_Click", a_2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void p(object A_0, EventArgs A_1)
	{
		try
		{
			es es2 = null;
			int selectedIndex = v().SelectedIndex;
			es2 = this.m_u.l()[selectedIndex];
			es es3 = new et();
			es2.ad(es3);
			ef obj = new ef(this.m_w);
			obj.i(this.m_x, this.m_y, this.m_aa, this.m_ab, (et)es2, selectedIndex, this.m_u.k(), A_7: false, null, i6.a(this));
			if (obj.DialogResult == DialogResult.OK)
			{
				m(selectedIndex);
			}
			else
			{
				es3.ad(es2);
			}
			obj.Dispose();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_w, this.m_x, this, i6.a(this), "DialogObjectiveSelectionButtonEdit_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_u.l().RemoveAt(v().SelectedIndex);
			m();
			m(v().SelectedIndex);
			o();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_w, this.m_x, this, i6.a(this), "DialogObjectiveSelectionButtonDelete_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void o()
	{
	}

	private void m(int A_0)
	{
		v().Items.Clear();
		if (this.m_u.k() == null)
		{
			return;
		}
		string[] array = this.m_u.k();
		foreach (string item in array)
		{
			v().Items.Add(item);
		}
		if (this.m_u.k().Length > 0)
		{
			if ((A_0 >= 0) & (A_0 < this.m_u.k().Length))
			{
				v().SelectedIndex = A_0;
			}
			else
			{
				v().SelectedIndex = 0;
			}
		}
	}

	private void m()
	{
		if (this.m_u.k() == null)
		{
			t().Enabled = false;
			s().Enabled = false;
		}
		else
		{
			t().Enabled = true;
			s().Enabled = true;
		}
	}

	private void m(object A_0, EventArgs A_1)
	{
		try
		{
			if (eu.g(this.m_u, this.m_v))
			{
				this.m_u.f();
			}
			base.DialogResult = DialogResult.OK;
			Close();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_w, this.m_x, this, i6.a(this), "DialogObjectiveSelectionButtonClose_Click", a_);
			ProjectData.ClearProjectError();
		}
	}
}
