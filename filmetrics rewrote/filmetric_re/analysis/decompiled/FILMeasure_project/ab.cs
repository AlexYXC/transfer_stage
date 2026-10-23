using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class ab : Form
{
	private enum a
	{
		a,
		b,
		c,
		d,
		e
	}

	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private Label m_c;

	[CompilerGenerated]
	private ComboBox m_d;

	[CompilerGenerated]
	private Label m_e;

	[CompilerGenerated]
	private TableLayoutPanel m_f;

	[CompilerGenerated]
	private TableLayoutPanel m_g;

	[CompilerGenerated]
	private ToolTip m_h;

	private fz i;

	private f1 j;

	private const string k = "DialogLightSourceStandby.";

	public static string l = "Standby mode delay can be selected here and\r\n also in the {0} dialog.\r\n\r\nAutomatic switching to Standby mode may be disabled\r\n by selecting Never from the list.\r\n\r\nIf Standby mode is not disabled, then the software will\r\n automatically switch the light source to standby when\r\n you exit the software.\r\n\r\nThe Standby mode timer is reset whenever a new spectrum\r\n is acquired or loaded.\r\n";

	public ab()
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
		a(new Button());
		a(new Label());
		c(new ComboBox());
		b(new Label());
		a(new TableLayoutPanel());
		b(new TableLayoutPanel());
		a(new ToolTip(this.m_a));
		f().SuspendLayout();
		g().SuspendLayout();
		SuspendLayout();
		b().Anchor = AnchorStyles.None;
		b().AutoSize = true;
		b().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		b().BackColor = Color.Transparent;
		b().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b().Location = new Point(196, 92);
		b().Margin = new Padding(4, 12, 4, 4);
		b().Name = "OK_Button";
		b().Size = new Size(108, 30);
		b().TabIndex = 0;
		b().Text = "Exit Standby";
		h().SetToolTip(b(), "Return light source to full power and\r\n update the Standby mode delay setting.");
		b().UseVisualStyleBackColor = false;
		c().Anchor = AnchorStyles.None;
		c().AutoSize = true;
		c().Location = new Point(4, 0);
		c().Margin = new Padding(4, 0, 4, 12);
		c().Name = "Label1";
		c().Size = new Size(493, 32);
		c().TabIndex = 1;
		c().Text = "Light source is in Standby mode.\r\nStandby mode reduces the light source output power in order to extend the lifetime.";
		c().TextAlign = ContentAlignment.TopCenter;
		d().Anchor = AnchorStyles.None;
		d().DropDownStyle = ComboBoxStyle.DropDownList;
		d().FormattingEnabled = true;
		d().Location = new Point(271, 3);
		d().Name = "ComboBoxDelay";
		d().Size = new Size(204, 24);
		d().TabIndex = 2;
		e().Anchor = AnchorStyles.None;
		e().AutoSize = true;
		e().Location = new Point(3, 7);
		e().Name = "Label2";
		e().Size = new Size(262, 16);
		e().TabIndex = 3;
		e().Text = "When Idle, automatically switch to Standby:";
		f().AutoSize = true;
		f().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		f().ColumnCount = 2;
		f().ColumnStyles.Add(new ColumnStyle());
		f().ColumnStyles.Add(new ColumnStyle());
		f().Controls.Add(e(), 0, 0);
		f().Controls.Add(d(), 1, 0);
		f().Location = new Point(3, 47);
		f().Name = "TableLayoutPanel1";
		f().RowCount = 1;
		f().RowStyles.Add(new RowStyle());
		f().Size = new Size(478, 30);
		f().TabIndex = 4;
		g().AutoSize = true;
		g().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		g().ColumnCount = 1;
		g().ColumnStyles.Add(new ColumnStyle());
		g().Controls.Add(c(), 0, 0);
		g().Controls.Add(b(), 0, 2);
		g().Controls.Add(f(), 0, 1);
		g().Location = new Point(12, 12);
		g().Margin = new Padding(3, 3, 12, 12);
		g().Name = "TableLayoutPanel2";
		g().RowCount = 3;
		g().RowStyles.Add(new RowStyle());
		g().RowStyles.Add(new RowStyle());
		g().RowStyles.Add(new RowStyle());
		g().Size = new Size(501, 126);
		g().TabIndex = 5;
		base.AcceptButton = b();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		BackColor = SystemColors.Window;
		base.ClientSize = new Size(526, 148);
		base.ControlBox = false;
		base.Controls.Add(g());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogLightSourceStandby";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Light Source Standby";
		f().ResumeLayout(performLayout: false);
		f().PerformLayout();
		g().ResumeLayout(performLayout: false);
		g().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button b()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = a;
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
	internal virtual ComboBox d()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ComboBox A_0)
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
	internal virtual TableLayoutPanel f()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
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
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip h()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolTip A_0)
	{
		this.m_h = A_0;
	}

	public static void b(ComboBox A_0)
	{
		A_0.Items.Add(new iz.a("After 1 Hour", 0));
		A_0.Items.Add(new iz.a("After 2 Hours", 1));
		A_0.Items.Add(new iz.a("After 4 Hours", 2));
		A_0.Items.Add(new iz.a("After 8 Hours", 3));
		A_0.Items.Add(new iz.a("Never", 4));
		if (global::e.a().LightSourceAutoStandby)
		{
			if (global::e.a().LightSourceAutoStandbyDelayMinutes < 90.0)
			{
				iz.b(A_0, 0);
			}
			else if (global::e.a().LightSourceAutoStandbyDelayMinutes < 180.0)
			{
				iz.b(A_0, 1);
			}
			else if (global::e.a().LightSourceAutoStandbyDelayMinutes < 360.0)
			{
				iz.b(A_0, 2);
			}
			else
			{
				iz.b(A_0, 3);
			}
		}
		else
		{
			iz.b(A_0, 4);
		}
	}

	public static void a(ComboBox A_0)
	{
		a a10 = (a)((iz.a)A_0.SelectedItem).b;
		if (a10 == ab.a.e)
		{
			global::e.a().LightSourceAutoStandby = false;
			return;
		}
		global::e.a().LightSourceAutoStandby = true;
		switch (a10)
		{
		case ab.a.a:
			global::e.a().LightSourceAutoStandbyDelayMinutes = 60.0;
			break;
		case ab.a.b:
			global::e.a().LightSourceAutoStandbyDelayMinutes = 120.0;
			break;
		case ab.a.c:
			global::e.a().LightSourceAutoStandbyDelayMinutes = 240.0;
			break;
		case ab.a.d:
			global::e.a().LightSourceAutoStandbyDelayMinutes = 480.0;
			break;
		}
	}

	public void a(fz A_0, f1 A_1)
	{
		i = A_0;
		j = A_1;
		b(d());
		h().SetToolTip(d(), string.Format(l, "Setup->Options"));
		ShowDialog();
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			a(d());
			base.DialogResult = DialogResult.OK;
			Close();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(i, j, null, i6.a(b()), "DialogLightSourceStandby.OK_Button_Click", a_);
			ProjectData.ClearProjectError();
		}
	}
}
