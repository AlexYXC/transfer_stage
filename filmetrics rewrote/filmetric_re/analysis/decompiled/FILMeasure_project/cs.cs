using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class cs : Form
{
	public enum a
	{
		a,
		b,
		c
	}

	private delegate void b();

	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private fl m_c;

	[CompilerGenerated]
	private ComboBox m_d;

	[CompilerGenerated]
	private Label m_e;

	[CompilerGenerated]
	private Label m_f;

	[CompilerGenerated]
	private Label m_g;

	[CompilerGenerated]
	private Button m_h;

	private Collection<g2.OpticsConfigSubmoduleTypes> m_i;

	private Collection<double[]> j;

	private Collection<DateTime[]> k;

	private int[] l;

	private fz m;

	private f1 n;

	private f4 o;

	private string p;

	private a q;

	public cs()
	{
		base.FormClosing += a;
		b();
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
	private void b()
	{
		a(new Button());
		a(new ComboBox());
		a(new Label());
		b(new Label());
		c(new Label());
		a(new fl());
		b(new Button());
		SuspendLayout();
		c().Anchor = AnchorStyles.Bottom;
		c().DialogResult = DialogResult.OK;
		c().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c().Location = new Point(239, 435);
		c().Margin = new Padding(4);
		c().Name = "ButtonClose";
		c().Size = new Size(89, 28);
		c().TabIndex = 0;
		c().Text = "Close";
		e().Anchor = AnchorStyles.Top;
		e().FormattingEnabled = true;
		e().Location = new Point(224, 16);
		e().Name = "ComboBoxOpticsConfig";
		e().Size = new Size(208, 24);
		e().TabIndex = 2;
		f().Anchor = AnchorStyles.Top;
		f().AutoSize = true;
		f().Location = new Point(88, 19);
		f().Name = "LabelOpticsConfig";
		f().Size = new Size(130, 16);
		f().TabIndex = 3;
		f().Text = "Optics Configuration:";
		g().Anchor = AnchorStyles.Bottom;
		g().Location = new Point(118, 392);
		g().Name = "LabelElapsedTimeStartDate";
		g().Size = new Size(345, 16);
		g().TabIndex = 4;
		g().Text = "LabelElapsedTimeStartDate";
		g().TextAlign = ContentAlignment.MiddleCenter;
		h().Anchor = AnchorStyles.Bottom;
		h().Location = new Point(118, 408);
		h().Name = "LabelGraphXAxisStartDate";
		h().Size = new Size(345, 23);
		h().TabIndex = 5;
		h().Text = "LabelGraphXAxisStartDate";
		h().TextAlign = ContentAlignment.MiddleCenter;
		d().o((gq)null);
		d().AllowDrop = true;
		d().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		d().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		d().BackColor = Color.Transparent;
		d().BackgroundImageLayout = ImageLayout.None;
		d().w(A_0: false);
		d().al(A_0: true);
		d().x(A_0: false);
		d().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d().y(A_0: false);
		d().z(A_0: false);
		d().aa(A_0: false);
		d().ab(A_0: false);
		d().Location = new Point(13, 43);
		d().o((fz)null);
		d().Margin = new Padding(4);
		d().ad(A_0: false);
		d().Name = "FiControlGraphHistory";
		d().q("SiO2 on Si Spectrum taken 01/31/2007 12:34 PM ");
		d().q(1);
		d().t(A_0: false);
		d().ae(A_0: false);
		d().af(A_0: false);
		d().ag(A_0: false);
		d().Size = new Size(554, 345);
		d().TabIndex = 1;
		d().o((fu)null);
		d().aj(A_0: false);
		d().ai(A_0: false);
		d().s((string)null);
		i().Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		i().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		i().Location = new Point(12, 436);
		i().Name = "ButtonViewFile";
		i().Size = new Size(138, 28);
		i().TabIndex = 6;
		i().Text = "View File...";
		i().UseVisualStyleBackColor = true;
		base.AcceptButton = c();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(580, 476);
		base.Controls.Add(i());
		base.Controls.Add(h());
		base.Controls.Add(g());
		base.Controls.Add(f());
		base.Controls.Add(e());
		base.Controls.Add(d());
		base.Controls.Add(c());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Margin = new Padding(4);
		base.MinimizeBox = false;
		base.Name = "DialogDiagnosticsBaselineHist";
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Show;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Baseline Reference Signal Intensity History";
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button c()
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
	internal virtual fl d()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(fl A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox e()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
	{
		EventHandler value = b;
		ComboBox comboBox = this.m_d;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_d = A_0;
		comboBox = this.m_d;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label f()
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
	internal virtual Label g()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label h()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button i()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = a;
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

	public void a(fz A_0, f1 A_1, f4 A_2, Collection<double[]> A_3, Collection<DateTime[]> A_4, int[] A_5, g2.OpticsConfigSubmoduleTypes A_6, string A_7)
	{
		n = A_1;
		o = A_2;
		fv fv2 = new fv(new fr());
		fl obj = d();
		obj.ae(A_0: false);
		obj.af(A_0: false);
		obj.o(fv2);
		obj.o(A_0);
		obj.gi().am(A_0: true);
		obj.gi().a2().am(0.0);
		obj.gi().a2().an(1.0);
		obj.gi().@as(A_0: true);
		obj.gi().am(4f);
		obj.o("Peak Raw Signal (Counts/ms·%)", "Peak Signal", A_2: false);
		obj.ag(A_0: true);
		obj.y(A_0: true);
		_ = null;
		fv2.a2().am(a);
		j = A_3;
		k = A_4;
		l = A_5;
		m = A_0;
		p = A_7;
		this.m_i = new Collection<g2.OpticsConfigSubmoduleTypes>();
		int upperBound = A_5.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (A_5[num] > 0)
			{
				g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = (g2.OpticsConfigSubmoduleTypes)num;
				e().Items.Add(g2.o(opticsConfigSubmoduleTypes));
				this.m_i.Add(opticsConfigSubmoduleTypes);
			}
		}
		if (this.m_i.Contains(A_6))
		{
			e().SelectedIndex = this.m_i.IndexOf(A_6);
		}
		else
		{
			e().SelectedIndex = 0;
		}
		ShowDialog();
	}

	private void a()
	{
		if (base.InvokeRequired)
		{
			Invoke(new b(a));
		}
		else
		{
			if (e().SelectedIndex < 0)
			{
				return;
			}
			g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_i[e().SelectedIndex];
			DateTime value2 = default(DateTime);
			checked
			{
				int num = l[unchecked((int)opticsConfigSubmoduleTypes)] - 1;
				double[] array = new double[num + 1];
				DateTime[] array2 = k[unchecked((int)opticsConfigSubmoduleTypes)];
				DateTime value = array2[0];
				string text = "";
				fr fr2 = d().gi().a2();
				DateTime dateTime = default(DateTime);
				switch (q)
				{
				case cs.a.a:
					value2 = value.AddMinutes(fr2.ap());
					dateTime = value.AddMinutes(fr2.aq());
					break;
				case cs.a.b:
					value2 = value.AddHours(fr2.ap());
					dateTime = value.AddHours(fr2.aq());
					break;
				case cs.a.c:
					value2 = value.AddDays(fr2.ap());
					dateTime = value.AddDays(fr2.aq());
					break;
				}
				TimeSpan timeSpan = dateTime.Subtract(value2);
				if (timeSpan.TotalMinutes < 60.0)
				{
					int num2 = num;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						array[num3] = array2[num3].Subtract(value).TotalMinutes;
					}
					text = "Minutes";
					if (q != cs.a.a)
					{
						fr2.am(value2.Subtract(array2[0]).TotalMinutes);
						fr2.an(dateTime.Subtract(array2[0]).TotalMinutes);
					}
					q = cs.a.a;
				}
				else if (timeSpan.TotalHours < 24.0)
				{
					int num4 = num;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						array[num5] = array2[num5].Subtract(value).TotalHours;
					}
					text = "Hours";
					if (q != cs.a.b)
					{
						fr2.am(value2.Subtract(array2[0]).TotalHours);
						fr2.an(dateTime.Subtract(array2[0]).TotalHours);
					}
					q = cs.a.b;
				}
				else
				{
					int num6 = num;
					for (int num7 = 0; num7 <= num6; num7++)
					{
						array[num7] = array2[num7].Subtract(value).TotalDays;
					}
					text = "Days";
					if (q != cs.a.c)
					{
						fr2.am(value2.Subtract(array2[0]).TotalDays);
						fr2.an(dateTime.Subtract(array2[0]).TotalDays);
					}
					q = cs.a.c;
				}
				fr2 = null;
				d().p(array, j[unchecked((int)opticsConfigSubmoduleTypes)], num + 1, 0L, 0L, 0.0, "Baseline Reference Peak Signal", "PeakSignal", A_8: false, A_9: false);
				d().s("Elapsed Time (" + text + ")");
			}
			g().Text = "First baseline: " + k[(int)opticsConfigSubmoduleTypes][0].ToLocalTime().ToString();
			h().Text = "Graph x-Axis start: " + value2.ToLocalTime().ToString();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = this.m_i[e().SelectedIndex];
			int num;
			checked
			{
				num = l[unchecked((int)opticsConfigSubmoduleTypes)] - 1;
			}
			DateTime[] array = k[(int)opticsConfigSubmoduleTypes];
			DateTime value = array[0];
			TimeSpan timeSpan = array[num].Subtract(value);
			d().g1();
			fr fr2 = d().gi().a2();
			double num2;
			if (timeSpan.TotalMinutes < 60.0)
			{
				num2 = ((timeSpan.TotalMinutes != 0.0) ? (timeSpan.TotalMinutes * 1.100000023841858) : 1.0);
				q = cs.a.a;
			}
			else if (timeSpan.TotalHours < 24.0)
			{
				num2 = timeSpan.TotalHours * 1.100000023841858;
				q = cs.a.b;
			}
			else
			{
				num2 = timeSpan.TotalDays * 1.100000023841858;
				q = cs.a.c;
			}
			if (num2 != fr2.aq() || fr2.ap() != 0.0)
			{
				fr2.am(0.0);
				fr2.an(num2);
			}
			else
			{
				a();
			}
			fr2 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(m, n, o, i6.a(e()), "DialogDiagnosticsBaselineHist.ComboBoxOpticsConfig_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			string a_ = File.ReadAllText(p);
			new dy().a(a_, p, A_2: true);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(m, n, o, i6.a(i()), "DialogDiagnosticsBaselineHist.ButtonViewFile_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		d().o((fu)null);
	}
}
