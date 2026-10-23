using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class bf : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Label m_b;

	[CompilerGenerated]
	private Label m_c;

	[CompilerGenerated]
	private Label m_d;

	[CompilerGenerated]
	private hy m_e;

	[CompilerGenerated]
	private Button m_f;

	[CompilerGenerated]
	private Button m_g;

	[CompilerGenerated]
	private hx m_h;

	[CompilerGenerated]
	private hx m_i;

	[CompilerGenerated]
	private ToolTip m_j;

	private fz k;

	private f1 l;

	public bf()
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
		this.m_a = new Container();
		a(new Label());
		b(new Label());
		c(new Label());
		a(new Button());
		b(new Button());
		a(new ToolTip(this.m_a));
		b(new hx());
		a(new hx());
		a(new hy());
		SuspendLayout();
		b().AutoSize = true;
		b().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b().Location = new Point(17, 19);
		b().Margin = new Padding(13, 12, 0, 0);
		b().Name = "LabelName";
		b().Size = new Size(48, 16);
		b().TabIndex = 0;
		b().Text = "Name:";
		c().AutoSize = true;
		c().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c().Location = new Point(17, 51);
		c().Margin = new Padding(13, 12, 0, 0);
		c().Name = "LabelAbbrName";
		c().Size = new Size(125, 16);
		c().TabIndex = 1;
		c().Text = "Abbreviated Name:";
		d().AutoSize = true;
		d().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d().Location = new Point(49, 83);
		d().Margin = new Padding(13, 12, 0, 0);
		d().Name = "LabelCoefficient";
		d().Size = new Size(73, 16);
		d().TabIndex = 2;
		d().Text = "Coefficient:";
		f().AutoSize = true;
		f().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f().Location = new Point(49, 119);
		f().Margin = new Padding(4);
		f().Name = "ButtonOK";
		f().Size = new Size(68, 30);
		f().TabIndex = 6;
		f().Text = "OK";
		f().UseVisualStyleBackColor = true;
		g().AutoSize = true;
		g().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		g().DialogResult = DialogResult.Cancel;
		g().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		g().Location = new Point(125, 119);
		g().Margin = new Padding(4);
		g().Name = "ButtonCancel";
		g().Size = new Size(68, 30);
		g().TabIndex = 7;
		g().Text = "Cancel";
		g().UseVisualStyleBackColor = true;
		i().Location = new Point(145, 48);
		i().Name = "TbAbbrName";
		i().Size = new Size(48, 22);
		i().TabIndex = 9;
		j().SetToolTip(i(), "Abbreviated string to describe units.\r\nUsed wherever measured thicknesses are displayed.");
		h().Location = new Point(68, 16);
		h().Name = "TbName";
		h().Size = new Size(125, 22);
		h().TabIndex = 8;
		j().SetToolTip(h(), "User-entered string for name of units.");
		e().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e().f(A_0: false);
		e().Location = new Point(125, 80);
		e().Margin = new Padding(4, 4, 10, 4);
		e().Name = "TbnCoefficient";
		e().e(A_0: false);
		e().Size = new Size(68, 22);
		e().TabIndex = 5;
		j().SetToolTip(e(), "Coefficient to convert from Custom units to nm.\r\nUnits of coefficient are nm/<custom unit>.");
		base.AcceptButton = f();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = g();
		base.ClientSize = new Size(205, 159);
		base.Controls.Add(i());
		base.Controls.Add(h());
		base.Controls.Add(g());
		base.Controls.Add(f());
		base.Controls.Add(e());
		base.Controls.Add(d());
		base.Controls.Add(c());
		base.Controls.Add(b());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogEditCustomUnit";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.Manual;
		Text = "Edit Custom Units";
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b()
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
	internal virtual Label c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
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
	internal virtual void c(Label A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy e()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hy A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button f()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = a;
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
	internal virtual Button g()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx h()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hx A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hx i()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(hx A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip j()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolTip A_0)
	{
		this.m_j = A_0;
	}

	public void a(fz A_0, f1 A_1, Point A_2, ref h4 A_3)
	{
		k = A_0;
		l = A_1;
		h4 h10 = A_3;
		h().Text = h10.f();
		i().Text = h10.g();
		e().Text = h10.h().ToString();
		h10 = null;
		i6.a(A_2, this);
		ShowDialog();
		if (base.DialogResult == DialogResult.OK)
		{
			h4 obj = A_3;
			obj.f(h().Text);
			obj.g(i().Text);
			obj.e(iz.d(e().Text));
			_ = null;
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			string left = h().Text.Trim().ToLower();
			string left2 = i().Text.Trim().ToLower();
			float num = iz.d(e().Text);
			foreach (object value in Enum.GetValues(typeof(h4.a)))
			{
				h4.a a10 = (h4.a)Conversions.ToInteger(value);
				h4 h10 = new h4(a10);
				if (a10 != h4.a.i)
				{
					bool flag = Operators.CompareString(left, h10.i().ToLower(), TextCompare: false) == 0 || Operators.CompareString(left, h10.j().ToLower(), TextCompare: false) == 0;
					bool flag2 = Operators.CompareString(left2, h10.e(false, false).ToLower(), TextCompare: false) == 0;
					bool flag3 = jf.e(num, h10.n());
					if ((flag || flag2) && !flag3)
					{
						fe.b(A_1: ((!flag) ? i().Text : h().Text) + " is reserved and cannot be used as a custom unit", A_0: k, A_2: i6.a(this));
						return;
					}
				}
			}
			if (num <= 0f)
			{
				fe.b(k, "Coefficient must be >0", i6.a(this));
			}
			else
			{
				base.DialogResult = DialogResult.OK;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(k, l, null, i6.a(this), "DialogEditCustomUnit.ButtonOK_Click", a_);
			ProjectData.ClearProjectError();
		}
	}
}
