using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class hy : i2
{
	private IContainer c;

	private i0 d;

	private bool m_e;

	private bool m_f;

	private bool m_g;

	private bool h;

	[DebuggerStepThrough]
	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (ContextMenuStrip != null)
			{
				ContextMenuStrip.Dispose();
			}
			if (c != null)
			{
				c.Dispose();
			}
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void e()
	{
		c = new Container();
	}

	public hy()
	{
		base.KeyDown += e;
		base.KeyPress += e;
		base.MouseDown += e;
		e();
		i1.a(this);
		TextBox A_ = this;
		d = new i0(ref A_);
	}

	public override bool a5(string A_0)
	{
		string numberDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
		string text = null;
		if (this.m_g)
		{
			text = "-?";
		}
		text = ((!h) ? (text + "(\\d+\\" + numberDecimalSeparator + "?\\d*([eE](-|\\+)?\\d*)?|\\d*\\" + numberDecimalSeparator + "?\\d+([eE](-|\\+)?\\d*)?|\\d+([eE](-|\\+)?\\d*)?|\\" + numberDecimalSeparator + "|\\d*)") : (text + "\\d*"));
		return Operators.CompareString(Regex.Match(A_0, text).ToString(), A_0, TextCompare: false) != 0;
	}

	private void e(object A_0, KeyEventArgs A_1)
	{
		checked
		{
			try
			{
				string numberDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
				bool flag = Operators.CompareString(numberDecimalSeparator, ",", TextCompare: false) == 0;
				bool flag2 = Operators.CompareString(numberDecimalSeparator, ".", TextCompare: false) != 0;
				Keys keys;
				if (Operators.CompareString(numberDecimalSeparator, ".", TextCompare: false) == 0)
				{
					keys = Keys.OemPeriod;
				}
				else
				{
					if (!flag)
					{
						throw new Exception("Unknown decimal separator. Decimal separator is '" + numberDecimalSeparator + "'");
					}
					keys = Keys.Oemcomma;
				}
				this.m_e = false;
				this.m_f = A_1.KeyCode == Keys.Decimal && flag2;
				if (A_1.Control && (A_1.KeyCode == Keys.A || A_1.KeyCode == Keys.C || A_1.KeyCode == Keys.Z))
				{
					return;
				}
				if ((A_1.KeyCode < Keys.D0 || A_1.KeyCode > Keys.D9 || A_1.Shift) && (A_1.KeyCode < Keys.NumPad0 || A_1.KeyCode > Keys.NumPad9 || (Control.IsKeyLocked(Keys.NumLock) && A_1.Shift) || !Control.IsKeyLocked(Keys.NumLock)) && (!A_1.Control || (A_1.KeyCode != Keys.V && A_1.KeyCode != Keys.X)) && A_1.KeyCode != Keys.Back && A_1.KeyCode != Keys.Delete && (h || (A_1.KeyCode != Keys.Decimal && A_1.KeyCode != keys && A_1.KeyCode != Keys.E && (A_1.Shift || A_1.KeyCode != Keys.OemMinus) && A_1.KeyCode != Keys.Subtract && (!A_1.Shift || A_1.KeyCode != Keys.Oemplus) && A_1.KeyCode != Keys.Add)) && (!this.m_g || !h || (A_1.KeyCode != Keys.OemMinus && A_1.KeyCode != Keys.Subtract)))
				{
					this.m_e = true;
					return;
				}
				if (A_1.Shift && (A_1.KeyCode == Keys.OemPeriod || A_1.KeyCode == Keys.Oemcomma))
				{
					this.m_e = true;
					return;
				}
				TypeConverter converter = TypeDescriptor.GetConverter(A_1.KeyCode.GetType());
				string text = null;
				if (A_1.KeyCode == Keys.Back || A_1.KeyCode == Keys.Delete)
				{
					if (SelectionLength > 0)
					{
						text = i1.a((TextBox)this);
					}
					else if (A_1.KeyCode == Keys.Back)
					{
						string text2 = Text;
						if (base.SelectionStart > 0)
						{
							text = text2.Substring(0, base.SelectionStart - 1);
						}
						text += text2.Substring(base.SelectionStart);
						text2 = null;
					}
					else if (A_1.KeyCode == Keys.Delete)
					{
						string text3 = Text;
						text = text3.Substring(0, base.SelectionStart);
						if (base.SelectionStart + 1 < TextLength)
						{
							text += text3.Substring(base.SelectionStart + 1);
						}
						text3 = null;
					}
				}
				else if (A_1.Control)
				{
					if (A_1.KeyCode == Keys.V)
					{
						text = i1.b(this);
					}
					else if (A_1.KeyCode == Keys.X)
					{
						text = i1.a((TextBox)this);
					}
				}
				else
				{
					char c10;
					if (A_1.KeyCode == Keys.Decimal || A_1.KeyCode == keys)
					{
						c10 = numberDecimalSeparator[0];
					}
					else if (A_1.KeyCode == Keys.Subtract || A_1.KeyCode == Keys.OemMinus)
					{
						c10 = '-';
					}
					else if (A_1.KeyCode == Keys.Add || A_1.KeyCode == Keys.Oemplus)
					{
						c10 = '+';
					}
					else if (A_1.KeyCode == Keys.E)
					{
						c10 = 'e';
					}
					else
					{
						string obj = converter.ConvertToString(A_1.KeyCode);
						c10 = obj.Substring(obj.Length - 1)[0];
						_ = null;
					}
					string text4 = Text;
					text = text4.Substring(0, base.SelectionStart) + Conversions.ToString(c10) + text4.Substring(base.SelectionStart + SelectionLength);
					text4 = null;
				}
				this.m_e = a5(text);
				if (this.m_e)
				{
					A_1.Handled = true;
					SystemSounds.Exclamation.Play();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void e(object A_0, KeyPressEventArgs A_1)
	{
		try
		{
			if (this.m_e)
			{
				A_1.Handled = true;
			}
			else if (this.m_f)
			{
				A_1.KeyChar = Conversions.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
			}
			else if (A_1.KeyChar == 'e')
			{
				A_1.KeyChar = 'E';
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	private void e(object A_0, MouseEventArgs A_1)
	{
		try
		{
			if (ContextMenuStrip == null)
			{
				i1.a(this);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	public bool f()
	{
		return this.m_g;
	}

	[SpecialName]
	public void e(bool A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	public bool g()
	{
		return h;
	}

	[SpecialName]
	public void f(bool A_0)
	{
		h = A_0;
	}
}
