using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class i0
{
	private bool m_a;

	private TextBox m_b;

	private bool m_c;

	public i0(ref TextBox A_0)
	{
		this.m_b = A_0;
		A_0.Enter += a;
		A_0.KeyDown += b;
		A_0.KeyUp += a;
		A_0.MouseDown += c;
		A_0.MouseUp += b;
		A_0.MouseMove += a;
	}

	[SpecialName]
	private TextBox b(object A_0)
	{
		return this.m_b;
	}

	private void a(object A_0)
	{
		TextBox textBox = b(RuntimeHelpers.GetObjectValue(A_0));
		if (textBox.SelectionLength != textBox.Text.Length)
		{
			textBox.SelectAll();
		}
		textBox = null;
	}

	private void a(object A_0, EventArgs A_1)
	{
		a(RuntimeHelpers.GetObjectValue(A_0));
		this.m_a = true;
	}

	private void b(object A_0, KeyEventArgs A_1)
	{
		this.m_a = false;
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		this.m_a = false;
	}

	private void c(object A_0, MouseEventArgs A_1)
	{
		this.m_c = true;
		if (this.m_a)
		{
			a(RuntimeHelpers.GetObjectValue(A_0));
		}
	}

	private void b(object A_0, MouseEventArgs A_1)
	{
		this.m_c = false;
		if (this.m_a)
		{
			a(RuntimeHelpers.GetObjectValue(A_0));
		}
		this.m_a = false;
	}

	private void a(object A_0, MouseEventArgs A_1)
	{
		if (this.m_c && this.m_a)
		{
			a(RuntimeHelpers.GetObjectValue(A_0));
		}
	}

	public static void a(PictureBox A_0, HScrollBar A_1, VScrollBar A_2, Panel A_3)
	{
		PictureBox pictureBox = A_0;
		checked
		{
			if ((pictureBox.Left < 0) & (pictureBox.Left + pictureBox.Width < A_2.Left + A_2.Width))
			{
				pictureBox.Left = 0;
			}
			if ((pictureBox.Top < 0) & (pictureBox.Top + pictureBox.Height < A_1.Top + A_1.Height))
			{
				pictureBox.Top = 0;
			}
			if (pictureBox.Left + pictureBox.Width > A_2.Left + A_2.Width)
			{
				A_1.Visible = true;
			}
			else
			{
				A_1.Visible = false;
			}
			if (pictureBox.Top + pictureBox.Height > A_1.Top + A_1.Height)
			{
				A_2.Visible = true;
			}
			else
			{
				A_2.Visible = false;
			}
			if ((A_1.Visible & !A_2.Visible) && pictureBox.Top + pictureBox.Height > A_1.Top)
			{
				A_2.Visible = true;
			}
			if ((A_2.Visible & !A_1.Visible) && pictureBox.Left + pictureBox.Width > A_2.Left)
			{
				A_1.Visible = true;
			}
			if (A_2.Visible & A_1.Visible)
			{
				A_3.Visible = true;
				A_2.Height = A_1.Top - A_2.Top;
				A_1.Width = A_2.Left - A_1.Left;
			}
			else
			{
				A_3.Visible = false;
				A_2.Height = A_1.Top - A_2.Top + A_1.Height;
				A_1.Width = A_2.Left - A_1.Left + A_2.Width;
			}
			VScrollBar vScrollBar = A_2;
			if (vScrollBar.Visible)
			{
				vScrollBar.Maximum = A_0.Height - A_1.Top - 1;
				int num = A_1.Top - 10;
				vScrollBar.Maximum += num;
				vScrollBar.LargeChange = num;
				if (!A_1.Visible)
				{
					vScrollBar.Maximum += A_1.Height;
					vScrollBar.LargeChange += A_1.Height;
				}
				if (A_0.Left != -A_1.Value)
				{
					ScrollEventArgs a_ = new ScrollEventArgs(ScrollEventType.EndScroll, A_1.Value, A_1.Value, ScrollOrientation.HorizontalScroll);
					a(A_0, a_);
				}
			}
			vScrollBar = null;
			HScrollBar hScrollBar = A_1;
			if (hScrollBar.Visible)
			{
				hScrollBar.Maximum = A_0.Width - A_2.Left - 1;
				int num = A_2.Left - 10;
				hScrollBar.Maximum += num;
				hScrollBar.LargeChange = num;
				if (!A_2.Visible)
				{
					hScrollBar.Maximum += A_2.Width;
					hScrollBar.LargeChange += A_2.Width;
				}
				if (A_0.Top != -A_2.Value)
				{
					ScrollEventArgs a_2 = new ScrollEventArgs(ScrollEventType.EndScroll, A_2.Value, A_2.Value, ScrollOrientation.VerticalScroll);
					b(A_0, a_2);
				}
			}
			hScrollBar = null;
			pictureBox = null;
		}
	}

	public static void b(PictureBox A_0, ScrollEventArgs A_1)
	{
		A_0.Top = checked(-A_1.NewValue);
	}

	public static void a(PictureBox A_0, ScrollEventArgs A_1)
	{
		A_0.Left = checked(-A_1.NewValue);
	}
}
