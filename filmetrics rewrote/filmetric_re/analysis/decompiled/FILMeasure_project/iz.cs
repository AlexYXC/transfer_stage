using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class iz
{
	internal class a
	{
		public string a;

		public int b;

		public a(string A_0, int A_1)
		{
			a = A_0;
			b = A_1;
		}

		public override string ToString()
		{
			return a;
		}
	}

	public enum b
	{
		a,
		b,
		c
	}

	public static void b(ComboBox A_0, int A_1)
	{
		A_0.SelectedIndex = a(A_0, A_1);
	}

	public static int a(ComboBox A_0, int A_1)
	{
		int num = 0;
		bool flag = true;
		while (num < A_0.Items.Count && flag)
		{
			if (((a)A_0.Items[num]).b == A_1)
			{
				flag = false;
			}
			else
			{
				num = checked(num + 1);
			}
		}
		if (num >= A_0.Items.Count)
		{
			return -1;
		}
		return num;
	}

	public static int a(ListBox A_0, int A_1)
	{
		int num = 0;
		bool flag = true;
		while (num < A_0.Items.Count && flag)
		{
			if (((a)A_0.Items[num]).b == A_1)
			{
				flag = false;
			}
			else
			{
				num = checked(num + 1);
			}
		}
		if (num >= A_0.Items.Count)
		{
			return -1;
		}
		return num;
	}

	public static bool b(ComboBox A_0)
	{
		int num = 0;
		foreach (a item in A_0.Items)
		{
			int width = TextRenderer.MeasureText(item.a, A_0.Font).Width;
			if (width > num)
			{
				num = width;
			}
		}
		A_0.ClientSize = new Size(checked(num + 20), A_0.ClientSize.Height);
		bool result = default(bool);
		return result;
	}

	public static void a(Control A_0, string A_1, b A_2)
	{
		Graphics graphics = A_0.CreateGraphics();
		string text = "";
		int width = graphics.MeasureString(A_1, A_0.Font).ToSize().Width;
		checked
		{
			if (width + 5 > A_0.ClientSize.Width)
			{
				int width2 = graphics.MeasureString("...", A_0.Font).ToSize().Width;
				int num = (int)Math.Round(Conversion.Int((double)(A_1.Length * (A_0.ClientSize.Width - 5 - width2)) / (double)width));
				if (num < 0)
				{
					num = 0;
				}
				int length = A_1.Length;
				string text2 = A_1;
				switch (A_2)
				{
				case iz.b.a:
				case iz.b.c:
				{
					int width3;
					do
					{
						width3 = graphics.MeasureString("..." + text2.Substring(length - num, num), A_0.Font).ToSize().Width;
						num++;
					}
					while (width3 + 5 < A_0.ClientSize.Width);
					do
					{
						num--;
						width3 = graphics.MeasureString("..." + text2.Substring(length - num, num), A_0.Font).ToSize().Width;
					}
					while ((width3 + 5 > A_0.ClientSize.Width) & (num > 0));
					text = ((A_2 != iz.b.c) ? ("..." + text2.Substring(length - num, num).Trim()) : (text2.Substring(0, num).Trim() + "..."));
					break;
				}
				case iz.b.b:
				{
					num = unchecked(num / 2);
					int width3;
					do
					{
						width3 = graphics.MeasureString(text2.Substring(0, num) + "..." + text2.Substring(length - num, num), A_0.Font).ToSize().Width;
						num++;
					}
					while (width3 + 5 < A_0.ClientSize.Width);
					do
					{
						num--;
						width3 = graphics.MeasureString(text2.Substring(0, num) + "..." + text2.Substring(length - num, num), A_0.Font).ToSize().Width;
					}
					while ((width3 + 5 > A_0.ClientSize.Width) & (num > 0));
					text = text2.Substring(0, num).Trim() + "..." + text2.Substring(length - num, num).Trim();
					break;
				}
				}
				text2 = null;
			}
			else
			{
				text = A_1;
			}
			A_0.Text = text;
			graphics.Dispose();
		}
	}

	public static void a(Control A_0, string A_1)
	{
		Graphics graphics = A_0.CreateGraphics();
		checked
		{
			A_0.Width = graphics.MeasureString(A_1, A_0.Font).ToSize().Width + 5;
			A_0.Height = graphics.MeasureString(A_1, A_0.Font).ToSize().Height + 5;
			graphics.Dispose();
		}
	}

	public static double e(string A_0)
	{
		if (double.TryParse(A_0, out var result))
		{
			return Conversions.ToDouble(result.ToString());
		}
		return 0.0;
	}

	public static float d(string A_0)
	{
		if (float.TryParse(A_0, out var result))
		{
			return Conversions.ToSingle(result.ToString());
		}
		if (double.TryParse(A_0, out var result2))
		{
			if (result2 > 3.4028234663852886E+38)
			{
				return float.MaxValue;
			}
			if (result2 < -3.4028234663852886E+38)
			{
				return float.MinValue;
			}
			return 0f;
		}
		return 0f;
	}

	public static int c(string A_0)
	{
		if (int.TryParse(A_0, out var result))
		{
			return result;
		}
		if (double.TryParse(A_0, out var result2))
		{
			if (result2 > 2147483647.0)
			{
				return int.MaxValue;
			}
			if (result2 < -2147483648.0)
			{
				return int.MinValue;
			}
			return 0;
		}
		return 0;
	}

	public static short b(string A_0)
	{
		if (short.TryParse(A_0, out var result))
		{
			return result;
		}
		if (double.TryParse(A_0, out var result2))
		{
			if (result2 > 32767.0)
			{
				return short.MaxValue;
			}
			if (result2 < -32768.0)
			{
				return short.MinValue;
			}
			return 0;
		}
		return 0;
	}

	public static byte a(string A_0)
	{
		if (byte.TryParse(A_0, out var result))
		{
			return result;
		}
		if (double.TryParse(A_0, out var result2))
		{
			if (result2 > 255.0)
			{
				return byte.MaxValue;
			}
			_ = 0.0;
			return 0;
		}
		return 0;
	}

	public static Control a(Control A_0)
	{
		if (A_0 is Button)
		{
			return a((Button)A_0);
		}
		if (A_0 is CheckBox)
		{
			return a((CheckBox)A_0);
		}
		if (A_0 is ComboBox)
		{
			return a((ComboBox)A_0);
		}
		if (A_0 is Label)
		{
			return a((Label)A_0);
		}
		if (A_0 is TableLayoutPanel)
		{
			return a((TableLayoutPanel)A_0);
		}
		if (A_0 is hy)
		{
			return a((hy)A_0);
		}
		if (A_0 is TextBox)
		{
			return a((TextBox)A_0);
		}
		if (A_0 is RadioButton)
		{
			return a((RadioButton)A_0);
		}
		throw new ax("UtilControls.Clone is not supported for supplied control type");
	}

	private static void a(Control A_0, Control A_1)
	{
		Control control = A_0;
		A_1.Anchor = control.Anchor;
		A_1.BackColor = control.BackColor;
		A_1.BackgroundImage = control.BackgroundImage;
		A_1.BackgroundImageLayout = control.BackgroundImageLayout;
		A_1.Enabled = control.Enabled;
		A_1.Font = control.Font;
		A_1.ForeColor = control.ForeColor;
		A_1.Margin = control.Margin;
		A_1.Padding = control.Padding;
		A_1.Size = control.Size;
		A_1.TabIndex = control.TabIndex;
		A_1.TabStop = control.TabStop;
		A_1.Text = control.Text;
		A_1.AutoSize = control.AutoSize;
		control = null;
	}

	private static void a(ButtonBase A_0, ButtonBase A_1)
	{
		a((Control)A_0, (Control)A_1);
		ButtonBase buttonBase = A_0;
		A_1.FlatStyle = buttonBase.FlatStyle;
		A_1.Image = buttonBase.Image;
		A_1.ImageAlign = buttonBase.ImageAlign;
		A_1.TextAlign = buttonBase.TextAlign;
		A_1.TextImageRelation = buttonBase.TextImageRelation;
		A_1.UseCompatibleTextRendering = buttonBase.UseCompatibleTextRendering;
		A_1.UseVisualStyleBackColor = buttonBase.UseVisualStyleBackColor;
		buttonBase = null;
	}

	private static void a(RadioButton A_0, RadioButton A_1)
	{
		a((ButtonBase)A_0, (ButtonBase)A_1);
		RadioButton radioButton = A_0;
		A_1.AutoCheck = radioButton.AutoCheck;
		radioButton = null;
	}

	private static void a(TextBox A_0, TextBox A_1)
	{
		a((Control)A_0, (Control)A_1);
		TextBox textBox = A_0;
		A_1.AcceptsReturn = textBox.AcceptsReturn;
		A_1.AcceptsTab = textBox.AcceptsTab;
		A_1.BorderStyle = textBox.BorderStyle;
		A_1.CausesValidation = textBox.CausesValidation;
		A_1.CharacterCasing = textBox.CharacterCasing;
		A_1.Multiline = textBox.Multiline;
		A_1.PasswordChar = textBox.PasswordChar;
		A_1.ReadOnly = textBox.ReadOnly;
		A_1.TextAlign = textBox.TextAlign;
		A_1.UseSystemPasswordChar = textBox.UseSystemPasswordChar;
		A_1.WordWrap = textBox.WordWrap;
		textBox = null;
	}

	public static Button a(Button A_0)
	{
		Button button = new Button();
		a(A_0, button);
		Button button2 = A_0;
		button.AutoSizeMode = button2.AutoSizeMode;
		button2 = null;
		return button;
	}

	public static CheckBox a(CheckBox A_0)
	{
		CheckBox checkBox = new CheckBox();
		a(A_0, checkBox);
		CheckBox checkBox2 = A_0;
		checkBox.Appearance = checkBox2.Appearance;
		checkBox.AutoCheck = checkBox2.AutoCheck;
		checkBox.CheckAlign = checkBox2.CheckAlign;
		checkBox.CheckState = checkBox2.CheckState;
		checkBox.ThreeState = checkBox2.ThreeState;
		checkBox2 = null;
		return checkBox;
	}

	public static ComboBox a(ComboBox A_0)
	{
		ComboBox comboBox = new ComboBox();
		a(A_0, comboBox);
		ComboBox comboBox2 = A_0;
		comboBox.DropDownStyle = comboBox2.DropDownStyle;
		comboBox.DropDownHeight = comboBox2.DropDownHeight;
		comboBox.DropDownWidth = comboBox2.DropDownWidth;
		comboBox.FlatStyle = comboBox2.FlatStyle;
		foreach (object item in comboBox2.Items)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(item);
			comboBox.Items.Add(RuntimeHelpers.GetObjectValue(objectValue));
		}
		comboBox.SelectedIndex = comboBox2.SelectedIndex;
		comboBox2 = null;
		return comboBox;
	}

	public static Label a(Label A_0)
	{
		Label label = new Label();
		a(A_0, label);
		Label label2 = A_0;
		label.BorderStyle = label2.BorderStyle;
		label.FlatStyle = label2.FlatStyle;
		label.Image = label2.Image;
		label.ImageAlign = label2.ImageAlign;
		label.MinimumSize = label2.MinimumSize;
		label.TextAlign = label2.TextAlign;
		label.UseCompatibleTextRendering = label2.UseCompatibleTextRendering;
		label2 = null;
		return label;
	}

	public static RadioButton a(RadioButton A_0)
	{
		RadioButton radioButton = new RadioButton();
		a(A_0, radioButton);
		return radioButton;
	}

	public static TextBox a(TextBox A_0)
	{
		TextBox textBox = new TextBox();
		a(A_0, textBox);
		return textBox;
	}

	public static hy a(hy A_0)
	{
		hy hy2 = new hy();
		a(A_0, hy2);
		hy hy3 = A_0;
		hy2.e(hy3.f());
		hy2.f(hy3.g());
		hy3 = null;
		return hy2;
	}

	public static TableLayoutPanel a(TableLayoutPanel A_0)
	{
		TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
		checked
		{
			try
			{
				tableLayoutPanel.SuspendLayout();
				TableLayoutPanel tableLayoutPanel2 = A_0;
				tableLayoutPanel.GrowStyle = tableLayoutPanel2.GrowStyle;
				if (tableLayoutPanel2.GrowStyle == TableLayoutPanelGrowStyle.AddColumns || tableLayoutPanel2.GrowStyle == TableLayoutPanelGrowStyle.FixedSize)
				{
					tableLayoutPanel.RowCount = tableLayoutPanel2.RowCount;
					int num = A_0.RowCount - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						tableLayoutPanel.RowStyles.Add(new RowStyle());
					}
					tableLayoutPanel.ColumnCount = 1;
					tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
				}
				if (tableLayoutPanel2.GrowStyle == TableLayoutPanelGrowStyle.AddRows || tableLayoutPanel2.GrowStyle == TableLayoutPanelGrowStyle.FixedSize)
				{
					tableLayoutPanel.ColumnCount = tableLayoutPanel2.ColumnCount;
					int num3 = A_0.ColumnCount - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
					}
					tableLayoutPanel.RowCount = 1;
					tableLayoutPanel.RowStyles.Add(new RowStyle());
				}
				tableLayoutPanel2 = null;
				foreach (Control control3 in A_0.Controls)
				{
					TableLayoutPanelCellPosition cellPosition = A_0.GetCellPosition(control3);
					Control control2 = a(control3);
					tableLayoutPanel.Controls.Add(control2, cellPosition.Column, cellPosition.Row);
					tableLayoutPanel.SetColumnSpan(control2, A_0.GetColumnSpan(control3));
				}
				tableLayoutPanel.Margin = A_0.Margin;
				tableLayoutPanel.Padding = A_0.Padding;
				tableLayoutPanel.Size = A_0.Size;
				int num5 = A_0.ColumnCount - 1;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					ColumnStyle columnStyle = A_0.ColumnStyles[num6];
					tableLayoutPanel.ColumnStyles[num6].Width = columnStyle.Width;
					tableLayoutPanel.ColumnStyles[num6].SizeType = columnStyle.SizeType;
					columnStyle = null;
				}
				int num7 = A_0.RowCount - 1;
				for (int num8 = 0; num8 <= num7; num8++)
				{
					RowStyle rowStyle = A_0.RowStyles[num8];
					tableLayoutPanel.RowStyles[num8].Height = rowStyle.Height;
					tableLayoutPanel.RowStyles[num8].SizeType = rowStyle.SizeType;
					rowStyle = null;
				}
				tableLayoutPanel.AutoSize = A_0.AutoSize;
				tableLayoutPanel.AutoSizeMode = A_0.AutoSizeMode;
				return tableLayoutPanel;
			}
			finally
			{
				tableLayoutPanel.ResumeLayout();
			}
		}
	}

	public static Collection<Control> a(Collection<Control> A_0, TableLayoutPanel A_1, int A_2, ToolTip A_3)
	{
		Collection<Control> collection = new Collection<Control>();
		checked
		{
			foreach (Control item in A_0)
			{
				Control control = a(item);
				collection.Add(control);
				if (A_3 != null)
				{
					string toolTip = A_3.GetToolTip(item);
					if (!string.IsNullOrEmpty(toolTip))
					{
						A_3.SetToolTip(control, toolTip);
					}
					if (control is TableLayoutPanel)
					{
						int num = item.Controls.Count - 1;
						for (int num2 = 0; num2 <= num; num2++)
						{
							toolTip = A_3.GetToolTip(item.Controls[num2]);
							if (!string.IsNullOrEmpty(toolTip))
							{
								A_3.SetToolTip(control.Controls[num2], toolTip);
							}
						}
					}
				}
				A_1.Controls.Add(control, A_1.GetColumn(item), A_2);
				A_1.SetRowSpan(control, A_1.GetRowSpan(item));
				A_1.SetColumnSpan(control, A_1.GetColumnSpan(item));
			}
			return collection;
		}
	}
}
