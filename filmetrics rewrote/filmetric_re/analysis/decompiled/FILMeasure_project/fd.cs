using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class fd : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private ComboBox m_b;

	[CompilerGenerated]
	private DataGridView m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private Button m_e;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_f;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_g;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_h;

	private string[,] m_i;

	private double[] j;

	private short k;

	private bool l;

	private bool m;

	private hd n;

	private e7 o;

	private fz p;

	private f1 q;

	private eo r;

	private double[] s;

	private double[] t;

	private double[] u;

	private int v;

	private bool w;

	private bool x;

	private int y;

	private const short z = 10;

	private const float aa = 1E-12f;

	private const float ab = 1E-24f;

	private const float ac = 1E+12f;

	private const float ad = 1E+24f;

	private const float ae = 9.999999E-09f;

	private const float af = 9.999998E-17f;

	private const string ag = "DialogMmodelInfo";

	public fd()
	{
		base.Activated += c;
		base.FormClosing += a;
		this.m_i = new string[17, 3];
		b();
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
	private void b()
	{
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		a(new ComboBox());
		a(new DataGridView());
		a(new Button());
		b(new Button());
		a(new DataGridViewTextBoxColumn());
		b(new DataGridViewTextBoxColumn());
		c(new DataGridViewTextBoxColumn());
		((ISupportInitialize)d()).BeginInit();
		SuspendLayout();
		c().DropDownStyle = ComboBoxStyle.DropDownList;
		c().FormattingEnabled = true;
		c().Location = new Point(147, 12);
		c().Name = "ComboModel";
		c().Size = new Size(160, 24);
		c().TabIndex = 0;
		d().AllowUserToAddRows = false;
		d().AllowUserToDeleteRows = false;
		d().AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		d().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		d().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		d().Columns.AddRange(g(), h(), i());
		d().Location = new Point(12, 52);
		d().Name = "DBGrid1";
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
		d().RowsDefaultCellStyle = dataGridViewCellStyle2;
		d().Size = new Size(415, 164);
		d().TabIndex = 1;
		e().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e().Location = new Point(227, 225);
		e().Name = "ButtonOk";
		e().Size = new Size(90, 35);
		e().TabIndex = 2;
		e().Text = "OK";
		e().UseVisualStyleBackColor = true;
		f().DialogResult = DialogResult.Cancel;
		f().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f().Location = new Point(337, 226);
		f().Name = "ButtonCancel";
		f().Size = new Size(90, 35);
		f().TabIndex = 3;
		f().Text = "Cancel";
		f().UseVisualStyleBackColor = true;
		g().HeaderText = "Coefficient";
		g().Name = "ModelCoefficient";
		g().ReadOnly = true;
		g().Width = 115;
		h().HeaderText = "Value";
		h().Name = "ModelValue";
		h().Width = 115;
		i().HeaderText = "Adjustable";
		i().Name = "ModelAdjustable";
		i().Width = 115;
		base.AcceptButton = e();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = f();
		base.ClientSize = new Size(439, 268);
		base.Controls.Add(f());
		base.Controls.Add(e());
		base.Controls.Add(d());
		base.Controls.Add(c());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogModelInfo";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Custom Model Information";
		((ISupportInitialize)d()).EndInit();
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox c()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
	{
		EventHandler value = a;
		ComboBox comboBox = this.m_b;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_b = A_0;
		comboBox = this.m_b;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridView d()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridView A_0)
	{
		DataGridViewCellEventHandler value = a;
		DataGridView dataGridView = this.m_c;
		if (dataGridView != null)
		{
			dataGridView.CellValueChanged -= value;
		}
		this.m_c = A_0;
		dataGridView = this.m_c;
		if (dataGridView != null)
		{
			dataGridView.CellValueChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button e()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = b;
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
	internal virtual Button f()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn g()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridViewTextBoxColumn A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn h()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(DataGridViewTextBoxColumn A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn i()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(DataGridViewTextBoxColumn A_0)
	{
		this.m_h = A_0;
	}

	public void a(hd A_0, eo A_1, eo.a A_2)
	{
		n = A_0;
		r = A_1;
		n.i(c(), A_1, A_2, A_3: false, A_4: true);
	}

	public void a(e7 A_0, fz A_1, f1 A_2, double[] A_3, int A_4, double[] A_5, double[] A_6)
	{
		o = A_0;
		p = A_1;
		q = A_2;
		s = A_3;
		v = A_4;
		t = A_5;
		u = A_6;
		DataGridView dataGridView = d();
		dataGridView.AutoSize = false;
		dataGridView.AllowUserToAddRows = false;
		dataGridView.AllowUserToDeleteRows = false;
		dataGridView.AllowUserToResizeRows = false;
		dataGridView.AllowUserToResizeColumns = false;
		dataGridView.AllowUserToOrderColumns = false;
		dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
		dataGridView.MultiSelect = false;
		dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
		dataGridView.ReadOnly = w;
		dataGridView.Enabled = !w;
		_ = null;
		c().Enabled = !w;
		base.ActiveControl = e();
		d().CurrentCell = null;
		ShowDialog();
	}

	private void c(object A_0, EventArgs A_1)
	{
		short[] A_2 = new short[1];
		if (!l)
		{
			a(ref j, ref A_2);
			k = checked((short)((iz.a)c().Items[c().SelectedIndex]).b);
			if (w)
			{
				d().ClearSelection();
			}
			l = true;
		}
	}

	public void a(ref short A_0, ref int A_1, ref double[] A_2, ref short[] A_3, [Optional][DefaultParameterValue(false)] ref bool A_4, bool A_5 = false)
	{
		m = false;
		w = A_5;
		checked
		{
			int num = c().Items.Count - 1;
			int selectedIndex = default(int);
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (((iz.a)c().Items[num2]).b == A_0)
				{
					selectedIndex = num2;
					break;
				}
			}
			c().SelectedIndex = selectedIndex;
			m = true;
			x = A_0 != 25;
			int num3 = A_1 - 1;
			for (int num2 = 0; num2 <= num3; num2++)
			{
				if ((A_0 == 2) & A_4)
				{
					if ((num2 == 1) | (num2 == 4))
					{
						this.m_i[num2, 1] = Conversions.ToString((float)(A_2[num2] * 999999995904.0));
					}
					else if ((num2 == 2) | (num2 == 5))
					{
						this.m_i[num2, 1] = Conversions.ToString((float)(A_2[num2] * 1.0000000138484279E+24));
					}
					else
					{
						this.m_i[num2, 1] = Conversions.ToString((float)A_2[num2]);
					}
				}
				else if (A_0 == 27 && A_4 && num2 >= 3)
				{
					this.m_i[num2, 1] = Conversions.ToString((float)(A_2[num2] * 999999995904.0));
				}
				else if (A_0 == 10 || A_0 == 20)
				{
					if (num2 == 0)
					{
						if (A_2[num2] <= 1.0)
						{
							this.m_i[num2, 1] = Conversions.ToString((float)(A_2[num2] * 100.0));
						}
						else
						{
							this.m_i[num2, 1] = Conversions.ToString((float)A_2[num2]);
						}
					}
				}
				else
				{
					this.m_i[num2, 1] = Conversions.ToString((float)A_2[num2]);
				}
				if (x)
				{
					this.m_i[num2, 2] = Conversions.ToString(unchecked((int)A_3[num2]));
				}
				else
				{
					this.m_i[num2, 2] = Conversions.ToString(0);
				}
			}
			y = A_1;
			int num4 = A_1 - 1;
			for (int num2 = 0; num2 <= num4; num2++)
			{
				this.m_i[num2, 0] = n.j(A_0, num2);
			}
			if (A_0 == 20)
			{
				this.m_i[0, 0] += " (%)";
			}
			a(A_1);
		}
	}

	private void a(int A_0)
	{
		d().Rows.Clear();
		checked
		{
			if (A_0 > 0)
			{
				DataGridView dataGridView = d();
				dataGridView.Rows.Add(A_0);
				int num = A_0 - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					string[] values = new string[3]
					{
						this.m_i[num2, 0],
						this.m_i[num2, 1],
						this.m_i[num2, 2]
					};
					dataGridView.Rows[num2].SetValues(values);
				}
				dataGridView = null;
			}
			d().Columns[2].ReadOnly = !x;
			if (x)
			{
				d().Columns[2].DefaultCellStyle.BackColor = SystemColors.Window;
			}
			else
			{
				d().Columns[2].DefaultCellStyle.BackColor = SystemColors.InactiveBorder;
			}
		}
	}

	private void a()
	{
		double[] A_ = new double[1];
		short[] A_2 = new short[1];
		a(ref A_, ref A_2);
		checked
		{
			short num = (short)(Information.UBound(A_) + 1);
			short num2 = (short)((iz.a)c().Items[c().SelectedIndex]).b;
			switch (num2)
			{
			case 2:
				A_[1] *= 9.999999960041972E-13;
				A_[2] *= 1.0000000195414814E-24;
				A_[4] *= 9.999999960041972E-13;
				A_[5] *= 1.0000000195414814E-24;
				break;
			case 27:
				A_[3] *= 9.999999960041972E-13;
				A_[4] *= 9.999999960041972E-13;
				A_[5] *= 9.999999960041972E-13;
				break;
			case 10:
			case 20:
				A_[0] *= 0.01;
				break;
			}
			if (num2 == 20)
			{
				int num3 = v - 1;
				double num4 = A_[0];
				double num5 = 1.0 - num4;
				double[] array = new double[num3 + 1];
				double[] array2 = new double[num3 + 1];
				int num6 = num3;
				double num9 = default(double);
				bool flag = default(bool);
				for (int num7 = 0; num7 <= num6; num7++)
				{
					double num8 = t[num7];
					if (u != null)
					{
						num9 = u[num7];
					}
					double num10 = num4 * (num8 * num8 - num9 * num9) + num5;
					double num11 = num4 * (2.0 * num8 * num9);
					double num12 = Math.Sqrt(num10 * num10 + num11 * num11);
					array[num7] = Math.Sqrt(0.5 * (num12 + num10));
					array2[num7] = Math.Sqrt(0.5 * (num12 - num10));
					if (array2[num7] != 0.0)
					{
						flag = true;
					}
				}
				if (!flag)
				{
					array2 = null;
				}
				o.b(s, v, array, array2);
			}
			else
			{
				double[,] A_3 = new double[233 + 1, 2];
				double[,] A_4 = new double[233 + 1, 2];
				float[] array3 = new float[num - 1 + 1];
				short num13 = (short)(num - 1);
				short num14;
				for (num14 = 0; num14 <= num13; num14 = (short)unchecked(num14 + 1))
				{
					array3[num14] = (float)A_[num14];
				}
				num14 = 0;
				float num15 = 180f;
				float A_5 = default(float);
				float A_6 = default(float);
				do
				{
					f6.CalculateModelNK(num2, num15 * 1E-09f, ref array3[0], 1, 1, ref A_5, ref A_6);
					A_3[num14, 0] = num15;
					A_3[num14, 1] = A_5;
					A_4[num14, 0] = num15;
					A_4[num14, 1] = A_6;
					num14++;
					num15 += 10f;
				}
				while (num15 <= 2500f);
				o.a(num14, ref A_3, ref A_4);
			}
			o.a(r.a8(), A_1: true);
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		l = false;
	}

	private void b(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				double[] A_2 = new double[1];
				short[] A_3 = new short[1];
				a(ref A_2, ref A_3);
				int num = Information.UBound(A_2) + 1;
				short A_4 = (short)((iz.a)c().Items[c().SelectedIndex]).b;
				if (A_4 == 2 && ((A_2[1] > 1.0) | (A_2[2] > 1.0) | (A_2[4] > 1.0) | (A_2[5] > 1.0)))
				{
					ref fz a_ = ref p;
					Point A_5 = i6.a(this);
					fe.b(ref a_, "The coefficients appear to be in units of Angstroms. Coefficients have been automatically converted to units of microns.", ref A_5);
					A_2[1] *= 9.99999905104687E-09;
					A_2[2] *= 9.999998183390365E-17;
					A_2[4] *= 9.99999905104687E-09;
					A_2[5] *= 9.999998183390365E-17;
					int A_6 = (short)num;
					bool A_7 = false;
					a(ref A_4, ref A_6, ref A_2, ref A_3, ref A_7);
				}
				short A_8 = (short)num;
				if (a(ref A_2, ref A_8, ref A_4))
				{
					switch (A_4)
					{
					case 2:
						A_2[1] *= 9.999999960041972E-13;
						A_2[2] *= 1.0000000195414814E-24;
						A_2[4] *= 9.999999960041972E-13;
						A_2[5] *= 1.0000000195414814E-24;
						break;
					case 27:
						A_2[3] *= 9.999999960041972E-13;
						A_2[4] *= 9.999999960041972E-13;
						A_2[5] *= 9.999999960041972E-13;
						break;
					case 10:
						if (A_2[0] >= 1.0)
						{
							A_2[0] *= 0.01;
						}
						break;
					}
					o.a(ref A_2, ref A_3, ref y, ref A_4);
					if (A_4 != 22 && A_4 != 25)
					{
						fe obj = new fe(p);
						fe.a a10 = new fe.a();
						a10.w("Would you like to calculate and save n & k values vs. wavelength using the model?\r\n\r\n(Note: Yes - replace any existing n and k data with new data computed using the model\r\n           No - remember the new model coefficients, but leave the n and k vs wavelength data unchanged)");
						a10.x("NumberOfSpectra");
						a10.w(MsgBoxStyle.YesNo);
						a10.y("Yes");
						a10.aa("No");
						a10.w(this);
						if (obj.b(a10) == DialogResult.OK)
						{
							a();
							if (A_4 == 20)
							{
								A_2[0] = 1.0;
							}
						}
					}
				}
				l = false;
				Hide();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				i5.a(p, q, null, i6.a(this), "DialogMmodelInfo.ButtonOk_Click", a_2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void a(ref double[] A_0, ref short[] A_1)
	{
		checked
		{
			A_0 = new double[y - 1 + 1];
			A_1 = new short[y - 1 + 1];
			int num = y - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (!double.TryParse(this.m_i[num2, 1], out A_0[num2]))
				{
					A_0[num2] = Conversions.ToDouble(this.m_i[num2, 1]);
				}
				if (!short.TryParse(this.m_i[num2, 2], out A_1[num2]))
				{
					A_1[num2] = Conversions.ToShort(this.m_i[num2, 2]);
				}
			}
		}
	}

	private bool a(ref double[] A_0, ref short A_1, ref short A_2)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool result = default(bool);
		int num = default(int);
		int num3 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					num2 = 1;
					result = false;
					goto IL_0004;
				case 202:
					{
						num = num2;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num + 1;
						num = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0004;
						case 3:
							goto IL_000b;
						case 4:
							goto IL_0023;
						case 6:
							goto IL_0029;
						case 7:
							goto IL_0030;
						case 8:
							goto IL_003c;
						case 10:
							goto IL_0042;
						case 11:
							goto IL_0050;
						case 12:
							goto end_IL_0000_2;
						case 14:
							goto IL_006a;
						default:
							goto end_IL_0000;
						case 5:
						case 9:
						case 13:
						case 15:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_006a:
					num2 = 14;
					num5 = checked(num5 + 1);
					goto IL_0073;
					IL_0004:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_000b;
					IL_000b:
					num2 = 3;
					if (Information.UBound(j) != Information.UBound(A_0))
					{
						goto IL_0023;
					}
					goto IL_0029;
					IL_0023:
					num2 = 4;
					result = true;
					goto end_IL_0000_3;
					IL_0029:
					ProjectData.ClearProjectError();
					num3 = 0;
					goto IL_0030;
					IL_0030:
					num2 = 7;
					if (A_2 != k)
					{
						goto IL_003c;
					}
					goto IL_0042;
					IL_003c:
					num2 = 8;
					result = true;
					goto end_IL_0000_3;
					IL_0042:
					num2 = 10;
					num6 = checked(A_1 - 1);
					num5 = 0;
					goto IL_0073;
					IL_0073:
					if (num5 > num6)
					{
						goto end_IL_0000_3;
					}
					goto IL_0050;
					IL_0050:
					num2 = 11;
					if (j[num5] != A_0[num5])
					{
						break;
					}
					goto IL_006a;
					end_IL_0000_2:
					break;
				}
				num2 = 12;
				result = true;
				break;
				end_IL_0000:;
			}
			catch (object obj) when ((obj is Exception) & (num3 != 0) & (num == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 202;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void a(object A_0, EventArgs A_1)
	{
		double[] A_2 = new double[17];
		short[] A_3 = new short[17];
		checked
		{
			if (m & (c().SelectedIndex != -1))
			{
				short num = 0;
				do
				{
					double.TryParse(this.m_i[num, 1], out A_2[num]);
					short.TryParse(this.m_i[num, 2], out A_3[num]);
					this.m_i[num, 0] = "";
					this.m_i[num, 1] = "";
					this.m_i[num, 2] = "1";
					num = (short)unchecked(num + 1);
				}
				while (num <= 15);
				short A_4 = (short)((iz.a)c().Items[c().SelectedIndex]).b;
				int A_5 = (short)n.j(A_4);
				bool A_6 = false;
				a(ref A_4, ref A_5, ref A_2, ref A_3, ref A_6);
			}
		}
	}

	private void a(object A_0, DataGridViewCellEventArgs A_1)
	{
		if ((A_1.RowIndex >= 0) & (A_1.ColumnIndex >= 0))
		{
			int rowIndex = A_1.RowIndex;
			int columnIndex = A_1.ColumnIndex;
			string text = d().Rows[rowIndex].Cells[columnIndex].Value.ToString();
			this.m_i[rowIndex, columnIndex] = text;
		}
	}
}
