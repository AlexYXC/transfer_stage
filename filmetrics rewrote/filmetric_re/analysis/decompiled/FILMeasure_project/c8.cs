using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class c8 : Form
{
	private IContainer a;

	[CompilerGenerated]
	private Button b;

	[CompilerGenerated]
	private ComboBox c;

	[CompilerGenerated]
	private Button d;

	[CompilerGenerated]
	private Button e;

	[CompilerGenerated]
	private Label m_f;

	[CompilerGenerated]
	private Button m_g;

	[CompilerGenerated]
	private Button m_h;

	[CompilerGenerated]
	private GroupBox m_i;

	[CompilerGenerated]
	private GroupBox m_j;

	[CompilerGenerated]
	private ToolTip m_k;

	private Collection<eu> m_l;

	private fz m_m;

	public c8()
	{
		base.FormClosing += f;
		g();
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
	private void g()
	{
		a = new Container();
		f(new Button());
		f(new ComboBox());
		g(new Button());
		h(new Button());
		f(new Label());
		i(new Button());
		j(new Button());
		f(new GroupBox());
		g(new GroupBox());
		f(new ToolTip(a));
		o().SuspendLayout();
		p().SuspendLayout();
		SuspendLayout();
		h().Cursor = Cursors.Default;
		h().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		h().Location = new Point(180, 34);
		h().Margin = new Padding(4, 4, 4, 4);
		h().Name = "btMicroDelete";
		h().RightToLeft = RightToLeft.No;
		h().Size = new Size(140, 37);
		h().TabIndex = 8;
		h().Text = "Delete...";
		q().SetToolTip(h(), "Delete selected microscope");
		h().UseVisualStyleBackColor = true;
		i().BackColor = SystemColors.Window;
		i().Cursor = Cursors.Default;
		i().DropDownStyle = ComboBoxStyle.DropDownList;
		i().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		i().ForeColor = SystemColors.WindowText;
		i().Location = new Point(165, 19);
		i().Margin = new Padding(4, 4, 4, 4);
		i().Name = "cboMicroList";
		i().RightToLeft = RightToLeft.No;
		i().Size = new Size(216, 24);
		i().TabIndex = 10;
		j().BackColor = SystemColors.ButtonFace;
		j().Cursor = Cursors.Default;
		j().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		j().Location = new Point(20, 34);
		j().Margin = new Padding(4, 4, 4, 4);
		j().Name = "btMicroAdd";
		j().RightToLeft = RightToLeft.No;
		j().Size = new Size(140, 37);
		j().TabIndex = 6;
		j().Text = "Add";
		q().SetToolTip(j(), "Create new microscope");
		j().UseVisualStyleBackColor = true;
		k().Cursor = Cursors.Default;
		k().DialogResult = DialogResult.Cancel;
		k().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		k().Location = new Point(160, 275);
		k().Margin = new Padding(4, 4, 4, 4);
		k().Name = "ButtonClose";
		k().RightToLeft = RightToLeft.No;
		k().Size = new Size(97, 34);
		k().TabIndex = 8;
		k().Text = "Close";
		k().UseVisualStyleBackColor = true;
		l().AutoSize = true;
		l().BackColor = SystemColors.Control;
		l().Cursor = Cursors.Default;
		l().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		l().ForeColor = SystemColors.ControlText;
		l().Location = new Point(38, 22);
		l().Margin = new Padding(4, 0, 4, 0);
		l().Name = "LabelName";
		l().RightToLeft = RightToLeft.No;
		l().Size = new Size(125, 16);
		l().TabIndex = 11;
		l().Text = "Microscope Name: ";
		m().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		m().Location = new Point(20, 34);
		m().Margin = new Padding(4, 4, 4, 4);
		m().Name = "btMicroRename";
		m().Size = new Size(140, 37);
		m().TabIndex = 12;
		m().Text = "Rename";
		q().SetToolTip(m(), "Rename selected microscope");
		m().UseVisualStyleBackColor = true;
		n().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		n().Location = new Point(180, 34);
		n().Margin = new Padding(4, 4, 4, 4);
		n().Name = "btMicroCopy";
		n().Size = new Size(140, 37);
		n().TabIndex = 13;
		n().Text = "Copy";
		q().SetToolTip(n(), "Copy selected microscope to new microscope");
		n().UseVisualStyleBackColor = true;
		o().Controls.Add(j());
		o().Controls.Add(n());
		o().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		o().Location = new Point(35, 54);
		o().Margin = new Padding(4, 4, 4, 4);
		o().Name = "GroupBox1";
		o().Padding = new Padding(4, 4, 4, 4);
		o().Size = new Size(346, 95);
		o().TabIndex = 14;
		o().TabStop = false;
		o().Text = "Create New Microscope";
		p().Controls.Add(m());
		p().Controls.Add(h());
		p().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		p().Location = new Point(35, 162);
		p().Margin = new Padding(4, 4, 4, 4);
		p().Name = "GroupBox2";
		p().Padding = new Padding(4, 4, 4, 4);
		p().Size = new Size(346, 95);
		p().TabIndex = 15;
		p().TabStop = false;
		p().Text = "Modify Existing Microscope";
		base.AcceptButton = k();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = k();
		base.ClientSize = new Size(417, 325);
		base.Controls.Add(p());
		base.Controls.Add(o());
		base.Controls.Add(i());
		base.Controls.Add(k());
		base.Controls.Add(l());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4, 4, 4, 4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogMicroSelection";
		base.ShowInTaskbar = false;
		Text = "Microscopes";
		o().ResumeLayout(performLayout: false);
		p().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button h()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void f(Button A_0)
	{
		EventHandler value = g;
		Button button = b;
		if (button != null)
		{
			button.Click -= value;
		}
		b = A_0;
		button = b;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ComboBox i()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void f(ComboBox A_0)
	{
		c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button j()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void g(Button A_0)
	{
		EventHandler value = i;
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
	public virtual Button k()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void h(Button A_0)
	{
		EventHandler value = f;
		Button button = e;
		if (button != null)
		{
			button.Click -= value;
		}
		e = A_0;
		button = e;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label l()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void f(Label A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button m()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Button A_0)
	{
		EventHandler value = j;
		Button button = this.m_g;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_g = A_0;
		button = this.m_g;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button n()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Button A_0)
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
	internal virtual GroupBox o()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(GroupBox A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox p()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(GroupBox A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip q()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(ToolTip A_0)
	{
		this.m_k = A_0;
	}

	public void f(fz A_0, ref Collection<eu> A_1, ref int A_2)
	{
		this.m_l = A_1;
		f(A_2);
		f();
		ShowDialog();
		A_2 = i().SelectedIndex;
	}

	private void f()
	{
		if (this.m_l.Count == 0)
		{
			n().Enabled = false;
			h().Enabled = false;
			m().Enabled = false;
			i().Enabled = false;
		}
		else
		{
			n().Enabled = true;
			h().Enabled = true;
			m().Enabled = true;
			i().Enabled = true;
		}
	}

	private void f(int A_0)
	{
		i().Items.Clear();
		checked
		{
			if (this.m_l.Count > 0)
			{
				int num = this.m_l.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					i().Items.Add(this.m_l[num2].i());
				}
				if (A_0 >= 0 && A_0 < this.m_l.Count)
				{
					i().SelectedIndex = A_0;
				}
				else
				{
					i().SelectedIndex = 0;
				}
			}
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		new fe(this.m_m);
		fe.a a10 = new fe.a();
		string empty = string.Empty;
		eu eu2 = this.m_l[i().SelectedIndex];
		fe obj = new fe(this.m_m);
		a10 = new fe.a();
		fe.a obj2 = a10;
		string A_2 = "MicroscopeRenamePrompt";
		obj2.w(hu.a(ref A_2));
		a10.x("MicroscopeRename");
		a10.w(MsgBoxStyle.OkCancel);
		a10.ad(i().Text);
		a10.w(fe.b.a);
		a10.w(this);
		checked
		{
			if (obj.b(a10) == DialogResult.OK)
			{
				empty = a10.ag();
				if (f(empty))
				{
					fz a_ = this.m_m;
					A_2 = "MicroscopeRenameFailure";
					fe.b(a_, hu.a(ref A_2), new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				}
				else
				{
					eu2.f(eu2.i(), empty);
					f(i().SelectedIndex);
				}
			}
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		eu eu2 = new eu();
		int num = 0;
		bool flag;
		do
		{
			eu2.h("New Microscope");
			if (num > 0)
			{
				eu eu3;
				(eu3 = eu2).h(eu3.i() + num);
			}
			flag = false;
			foreach (eu item in this.m_l)
			{
				if (string.Compare(item.i(), eu2.i(), StringComparison.OrdinalIgnoreCase) == 0)
				{
					flag = true;
					num = checked(num + 1);
					break;
				}
			}
		}
		while (flag);
		this.m_l.Add(eu2);
		eu2.f();
		f(i().Items.Count);
	}

	private void h(object A_0, EventArgs A_1)
	{
		eu eu2 = new eu();
		eu2.h(g(i().Text));
		this.m_l[i().SelectedIndex].f(eu2);
		this.m_l.Add(eu2);
		eu2.f();
		f(i().Items.Count);
	}

	private void g(object A_0, EventArgs A_1)
	{
		eu eu2 = this.m_l[i().SelectedIndex];
		ref fz a_ = ref this.m_m;
		string A_2 = "MicroscopeDeletePromptFmt1";
		if (fe.b(ref a_, string.Format(hu.a(ref A_2), eu2.i()), "MicroscopeDeleteTitle", "Yes", "No", new Point(base.Width / 2, base.Height / 2)))
		{
			eu2.g(eu2.i());
			this.m_l.RemoveAt(i().SelectedIndex);
		}
		f(checked(i().SelectedIndex - 1));
	}

	private void f(object A_0, EventArgs A_1)
	{
		Hide();
	}

	private string g(string A_0)
	{
		int num = 2;
		if (f("Copy of " + A_0))
		{
			while (f("Copy (" + num + ") of " + A_0))
			{
				num = checked(num + 1);
			}
			return "Copy (" + num + ") of " + A_0;
		}
		return "Copy of " + A_0;
	}

	private bool f(string A_0)
	{
		checked
		{
			int num = this.m_l.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (string.Compare(this.m_l[num2].i(), A_0, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return true;
				}
			}
			return false;
		}
	}

	private void f(object A_0, FormClosingEventArgs A_1)
	{
		try
		{
			if (this.m_l.Count == 0)
			{
				eu eu2 = new eu();
				this.m_l.Add(eu2);
				eu2.f();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_m.c(fz.b.b, "Error in DialogMicroSelection_FormClosing", a_);
			ProjectData.ClearProjectError();
		}
	}
}
