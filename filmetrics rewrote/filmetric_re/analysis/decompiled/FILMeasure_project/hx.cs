using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class hx : i2
{
	public class a
	{
		public Keys a;

		public bool b;

		public bool c;
	}

	public delegate void b(object A_0, a A_1);

	private IContainer m_a;

	private i0 m_b;

	private bool c;

	private bool d;

	private char[] m_e;

	[CompilerGenerated]
	private b m_f;

	private bool g;

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (ContextMenuStrip != null)
			{
				ContextMenuStrip.Dispose();
			}
			if (this.m_a != null)
			{
				this.m_a.Dispose();
			}
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void e()
	{
		this.m_a = new Container();
	}

	[SpecialName]
	[CompilerGenerated]
	public void e(b A_0)
	{
		b b10 = this.m_f;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Combine(b11, A_0);
			b10 = Interlocked.CompareExchange(ref this.m_f, value, b11);
		}
		while ((object)b10 != b11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void f(b A_0)
	{
		b b10 = this.m_f;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Remove(b11, A_0);
			b10 = Interlocked.CompareExchange(ref this.m_f, value, b11);
		}
		while ((object)b10 != b11);
	}

	public hx()
	{
		base.KeyDown += e;
		base.KeyPress += e;
		base.MouseDown += e;
		this.m_e = Path.GetInvalidFileNameChars();
		e();
		i1.a(this);
		TextBox A_ = this;
		this.m_b = new i0(ref A_);
	}

	protected virtual void e(a A_0)
	{
		this.m_f?.Invoke(this, A_0);
	}

	protected override bool IsInputKey(Keys keyData)
	{
		a a10 = new a();
		a10.a = keyData;
		e(a10);
		if (a10.c)
		{
			return a10.b;
		}
		return base.IsInputKey(keyData);
	}

	[SpecialName]
	public bool f()
	{
		return d;
	}

	[SpecialName]
	public void e(bool A_0)
	{
		d = A_0;
	}

	private void e(object A_0, KeyEventArgs A_1)
	{
		try
		{
			c = A_1.KeyCode == Keys.Decimal && Operators.CompareString(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator, ".", TextCompare: false) != 0;
			if (!d)
			{
				return;
			}
			g = false;
			if (A_1.Control && A_1.KeyCode == Keys.V)
			{
				g = a5(global::c.e().Clipboard.GetText());
				return;
			}
			Keys keyCode = A_1.KeyCode;
			if (keyCode == Keys.OemQuestion || keyCode == Keys.OemPipe || keyCode == Keys.Multiply || keyCode == Keys.Divide)
			{
				g = true;
			}
			if (A_1.Shift && (keyCode == Keys.D8 || keyCode == Keys.Oemcomma || keyCode == Keys.OemPeriod || keyCode == Keys.OemSemicolon || keyCode == Keys.OemQuestion || keyCode == Keys.OemQuotes))
			{
				g = true;
			}
			if (g)
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

	private void e(object A_0, KeyPressEventArgs A_1)
	{
		try
		{
			if (g)
			{
				A_1.Handled = true;
			}
			else if (c)
			{
				A_1.KeyChar = Conversions.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
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

	public override bool a5(string A_0)
	{
		checked
		{
			if (d)
			{
				int num = this.m_e.Length - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					for (int num3 = A_0.Length - 1; num3 >= 0; num3 += -1)
					{
						if (A_0[num3] == this.m_e[num2])
						{
							return true;
						}
					}
				}
			}
			return false;
		}
	}
}
