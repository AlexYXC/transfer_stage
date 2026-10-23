using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class c2 : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private TableLayoutPanel m_b;

	[CompilerGenerated]
	private Label m_c;

	[CompilerGenerated]
	private Label m_d;

	[CompilerGenerated]
	private RadioButton m_e;

	[CompilerGenerated]
	private RadioButton m_f;

	[CompilerGenerated]
	private RadioButton m_g;

	[CompilerGenerated]
	private RadioButton m_h;

	[CompilerGenerated]
	private RadioButton m_i;

	[CompilerGenerated]
	private Label m_j;

	[CompilerGenerated]
	private Button m_k;

	[CompilerGenerated]
	private Button m_l;

	[CompilerGenerated]
	private TableLayoutPanel m_m;

	[CompilerGenerated]
	private TableLayoutPanel m_n;

	[CompilerGenerated]
	private Label m_o;

	[CompilerGenerated]
	private Label m_p;

	private fz q;

	private f1 r;

	private f4 s;

	private Collection<string> t;

	private bool[] u;

	private Collection<string> v;

	private Collection<eb.a> w;

	private eb.a x;

	public c2()
	{
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
		b(new RadioButton());
		c(new RadioButton());
		d(new RadioButton());
		e(new RadioButton());
		c(new Label());
		a(new Label());
		b(new Label());
		a(new RadioButton());
		a(new Button());
		b(new Button());
		b(new TableLayoutPanel());
		c(new TableLayoutPanel());
		e(new Label());
		d(new Label());
		b().SuspendLayout();
		m().SuspendLayout();
		n().SuspendLayout();
		SuspendLayout();
		b().AutoSize = true;
		b().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		b().ColumnCount = 2;
		b().ColumnStyles.Add(new ColumnStyle());
		b().ColumnStyles.Add(new ColumnStyle());
		b().Controls.Add(o(), 1, 0);
		b().Controls.Add(p(), 0, 0);
		b().Controls.Add(f(), 0, 7);
		b().Controls.Add(g(), 0, 6);
		b().Controls.Add(h(), 0, 5);
		b().Controls.Add(i(), 0, 4);
		b().Controls.Add(j(), 0, 2);
		b().Controls.Add(e(), 0, 3);
		b().Controls.Add(d(), 0, 1);
		b().Controls.Add(c(), 1, 1);
		b().Location = new Point(11, 11);
		b().Name = "TableLayoutPanel1";
		b().RowCount = 8;
		b().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		b().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		b().RowStyles.Add(new RowStyle());
		b().RowStyles.Add(new RowStyle());
		b().RowStyles.Add(new RowStyle());
		b().RowStyles.Add(new RowStyle());
		b().RowStyles.Add(new RowStyle());
		b().RowStyles.Add(new RowStyle());
		b().Size = new Size(268, 196);
		b().TabIndex = 0;
		f().AutoSize = true;
		f().Location = new Point(3, 173);
		f().Name = "RadioButtonShipping";
		f().Size = new Size(79, 20);
		f().TabIndex = 2;
		f().TabStop = true;
		f().Text = "Shipping";
		f().UseVisualStyleBackColor = true;
		g().AutoSize = true;
		g().Location = new Point(3, 147);
		g().Name = "RadioButtonReleased";
		g().Size = new Size(86, 20);
		g().TabIndex = 2;
		g().TabStop = true;
		g().Text = "Released";
		g().UseVisualStyleBackColor = true;
		h().AutoSize = true;
		h().Location = new Point(3, 121);
		h().Name = "RadioButtonCustomer";
		h().Size = new Size(83, 20);
		h().TabIndex = 2;
		h().TabStop = true;
		h().Text = "Customer";
		h().UseVisualStyleBackColor = true;
		i().AutoSize = true;
		i().Location = new Point(3, 95);
		i().Name = "RadioButtonUnreleased";
		i().Size = new Size(97, 20);
		i().TabIndex = 2;
		i().TabStop = true;
		i().Text = "Unreleased";
		i().UseVisualStyleBackColor = true;
		j().AutoSize = true;
		j().Location = new Point(0, 50);
		j().Margin = new Padding(0, 10, 3, 0);
		j().Name = "Label2";
		j().Size = new Size(129, 16);
		j().TabIndex = 2;
		j().Text = "New Release Level:";
		c().AutoSize = true;
		c().BorderStyle = BorderStyle.Fixed3D;
		c().Location = new Point(146, 20);
		c().Margin = new Padding(0, 0, 3, 0);
		c().Name = "LabelCurrentLevel";
		c().Size = new Size(119, 18);
		c().TabIndex = 1;
		c().Text = "LabelCurrentLevel";
		d().AutoSize = true;
		d().Location = new Point(0, 20);
		d().Margin = new Padding(0, 0, 2, 0);
		d().Name = "Label1";
		d().Size = new Size(144, 16);
		d().TabIndex = 1;
		d().Text = "Current Release Level:";
		e().AutoSize = true;
		e().Location = new Point(3, 69);
		e().Name = "RadioButtonLocal";
		e().Size = new Size(59, 20);
		e().TabIndex = 1;
		e().TabStop = true;
		e().Text = "Local";
		e().UseVisualStyleBackColor = true;
		k().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		k().Location = new Point(3, 8);
		k().Name = "ButtonOK";
		k().Size = new Size(89, 28);
		k().TabIndex = 1;
		k().Text = "OK";
		k().UseVisualStyleBackColor = true;
		l().DialogResult = DialogResult.Cancel;
		l().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		l().Location = new Point(98, 8);
		l().Name = "ButtonCancel";
		l().Size = new Size(89, 28);
		l().TabIndex = 2;
		l().Text = "Cancel";
		l().UseVisualStyleBackColor = true;
		m().AutoSize = true;
		m().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		m().ColumnCount = 1;
		m().ColumnStyles.Add(new ColumnStyle());
		m().Controls.Add(n(), 0, 1);
		m().Controls.Add(b(), 0, 0);
		m().Location = new Point(0, 0);
		m().Name = "TableLayoutPanel2";
		m().Padding = new Padding(8);
		m().RowCount = 2;
		m().RowStyles.Add(new RowStyle());
		m().RowStyles.Add(new RowStyle());
		m().Size = new Size(290, 263);
		m().TabIndex = 3;
		n().Anchor = AnchorStyles.None;
		n().AutoSize = true;
		n().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		n().ColumnCount = 2;
		n().ColumnStyles.Add(new ColumnStyle());
		n().ColumnStyles.Add(new ColumnStyle());
		n().Controls.Add(k(), 0, 0);
		n().Controls.Add(l(), 1, 0);
		n().Location = new Point(50, 213);
		n().Name = "TableLayoutPanel3";
		n().Padding = new Padding(0, 5, 0, 0);
		n().RowCount = 1;
		n().RowStyles.Add(new RowStyle());
		n().Size = new Size(190, 39);
		n().TabIndex = 4;
		p().Anchor = AnchorStyles.Right;
		p().AutoSize = true;
		p().Location = new Point(77, 2);
		p().Margin = new Padding(3, 0, 2, 0);
		p().Name = "Label3";
		p().Size = new Size(67, 16);
		p().TabIndex = 4;
		p().Text = "Filename:";
		o().AutoSize = true;
		o().BorderStyle = BorderStyle.Fixed3D;
		o().Location = new Point(146, 0);
		o().Margin = new Padding(0, 0, 3, 0);
		o().Name = "LabelFilename";
		o().Size = new Size(100, 18);
		o().TabIndex = 4;
		o().Text = "LabelFilename";
		base.AcceptButton = k();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = l();
		base.ClientSize = new Size(298, 294);
		base.Controls.Add(m());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogMatDBChangeReleaseLevel";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "OMBD File Release Level";
		b().ResumeLayout(performLayout: false);
		b().PerformLayout();
		m().ResumeLayout(performLayout: false);
		m().PerformLayout();
		n().ResumeLayout(performLayout: false);
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
	internal virtual Label c()
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
	internal virtual Label d()
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
	internal virtual RadioButton e()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(RadioButton A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton f()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(RadioButton A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton g()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(RadioButton A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton h()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(RadioButton A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton i()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(RadioButton A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label j()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button k()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = a;
		Button button = this.m_k;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_k = A_0;
		button = this.m_k;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button l()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel m()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel n()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label o()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label p()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_p = A_0;
	}

	public void a(fz A_0, f1 A_1, f4 A_2, Collection<string> A_3, bool[] A_4, Collection<string> A_5, Collection<eb.a> A_6, ref eb.a A_7)
	{
		bool flag = true;
		eb.a a10 = A_6[0];
		q = A_0;
		r = A_1;
		s = A_2;
		t = A_3;
		u = A_4;
		v = A_5;
		w = A_6;
		foreach (eb.a item in A_6)
		{
			if (item != a10)
			{
				flag = false;
				break;
			}
		}
		if (A_3.Count == 1)
		{
			o().Text = A_3[0];
		}
		else
		{
			o().Text = "<Multiple Files>";
		}
		if (flag)
		{
			c().Text = eb.a(a10);
			switch (a10)
			{
			case eb.a.a:
				e().Checked = true;
				break;
			case eb.a.c:
				h().Checked = true;
				break;
			case eb.a.b:
				i().Checked = true;
				break;
			case eb.a.d:
				g().Checked = true;
				break;
			case eb.a.f:
				f().Checked = true;
				break;
			}
		}
		else
		{
			c().Text = "<Multiple Levels>";
		}
		ShowDialog();
		if (base.DialogResult != DialogResult.Cancel)
		{
			A_7 = x;
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				bool A_2 = false;
				bool flag = false;
				bool flag2 = false;
				string a_ = "";
				if (t.Count > 1)
				{
					a_ = "Apply to all files";
				}
				if (e().Checked)
				{
					x = eb.a.a;
				}
				else if (h().Checked)
				{
					x = eb.a.c;
				}
				else if (i().Checked)
				{
					x = eb.a.b;
				}
				else if (g().Checked)
				{
					x = eb.a.d;
				}
				else if (f().Checked)
				{
					x = eb.a.f;
				}
				int num = t.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (x == eb.a.a)
					{
						bool flag3;
						if (w[num2] != eb.a.a)
						{
							if (!flag && !flag2)
							{
								flag3 = fe.b(ref q, "Are you sure you want to delete " + t[num2] + " from the database, saving\r\nit as a Local file instead?", "Warning", "Yes", "No", i6.a(k()), a_, ref A_2);
								if (A_2)
								{
									if (flag3)
									{
										flag = true;
									}
									else
									{
										flag2 = true;
									}
								}
							}
							else
							{
								flag3 = flag;
							}
						}
						else
						{
							flag3 = true;
						}
						u[num2] = flag3;
					}
					else
					{
						u[num2] = true;
					}
				}
				base.DialogResult = DialogResult.OK;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				i5.a(q, r, s, i6.a(k()), "DialogMaterialsDatabase.ButtonOK_Click", a_2);
				ProjectData.ClearProjectError();
			}
		}
	}
}
