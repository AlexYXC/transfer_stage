using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

internal class t
{
	private fz m_a;

	private string m_b;

	private Image m_c;

	private Image d;

	private Image e;

	private Button f;

	public static void a(Button A_0, Image A_1, Image A_2, Image A_3, fz A_4, string A_5)
	{
		t t2 = new t();
		t2.m_a = A_4;
		t2.m_b = A_5;
		t2.d = A_1;
		t2.m_c = A_2;
		t2.e = A_3;
		if (A_2 != null)
		{
			A_0.EnabledChanged += t2.c;
		}
		if (A_3 != null)
		{
			A_0.MouseEnter += t2.b;
			A_0.MouseLeave += t2.a;
		}
		t2 = null;
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			Button button = (Button)A_0;
			if (button.Enabled)
			{
				button.BackgroundImage = d;
			}
			else
			{
				button.BackgroundImage = this.m_c;
			}
			button = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_a.c(fz.b.b, "Error in" + this.m_b + ".Button_EnabledChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			Button button = (Button)A_0;
			if (button.Enabled)
			{
				button.BackgroundImage = e;
			}
			button = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_a.c(fz.b.b, "Error in" + this.m_b + ".ButtonDeleteLayer_MouseEnter", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			Button button = (Button)A_0;
			if (button.Enabled)
			{
				button.BackgroundImage = d;
			}
			button = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_a.c(fz.b.b, "Error in" + this.m_b + ".ButtonDeleteLayer_MouseLeave", a_);
			ProjectData.ClearProjectError();
		}
	}
}
