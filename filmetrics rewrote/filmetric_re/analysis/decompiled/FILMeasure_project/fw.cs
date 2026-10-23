using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[ToolboxBitmap(typeof(TabControl))]
internal class fw : TabControl
{
	public enum a
	{
		a,
		b
	}

	private IContainer m_a;

	[CompilerGenerated]
	private Timer b;

	private a m_c;

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer c()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Timer A_0)
	{
		EventHandler value = a;
		Timer timer = b;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		b = A_0;
		timer = b;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	[SpecialName]
	public a d()
	{
		return this.m_c;
	}

	[SpecialName]
	public void a(a A_0)
	{
		this.m_c = A_0;
		if (!this.m_c.Equals(fw.a.b))
		{
			base.ItemSize = new Size(0, 0);
			base.Padding = new Point(6, 3);
			SetStyle(ControlStyles.UserPaint, value: false);
		}
	}

	public fw()
	{
		this.m_c = fw.a.b;
		SetStyle(ControlStyles.SupportsTransparentBackColor, value: true);
		SetStyle(ControlStyles.OptimizedDoubleBuffer, value: true);
		SetStyle(ControlStyles.ResizeRedraw, value: true);
		base.ResizeRedraw = true;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		checked
		{
			if (base.TabCount > 0)
			{
				int num = base.TabCount - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					a(e, num2);
				}
			}
		}
	}

	protected override void OnMouseHover(EventArgs e)
	{
		base.OnMouseHover(e);
	}

	private void a(PaintEventArgs A_0, int A_1)
	{
		a(A_0.Graphics, A_1);
		c(A_0.Graphics, A_1);
	}

	private void c(Graphics A_0, int A_1)
	{
		Image image = null;
		if (base.TabPages[A_1].ImageIndex > -1 && base.ImageList != null)
		{
			image = base.ImageList.Images[base.TabPages[A_1].ImageIndex];
		}
		else if (base.TabPages[A_1].ImageKey.Trim().Length > 0 && base.ImageList != null)
		{
			image = base.ImageList.Images[base.TabPages[A_1].ImageKey];
		}
		checked
		{
			if (image != null)
			{
				Rectangle tabRect = GetTabRect(A_1);
				A_0.DrawImage(image, tabRect.Right - tabRect.Height - 4, 4, tabRect.Height - 2, tabRect.Height - 2);
			}
		}
	}

	public void a(Graphics A_0, int A_1, int A_2)
	{
		Image image = null;
		image = base.ImageList.Images[A_1];
		checked
		{
			if (image != null)
			{
				Rectangle tabRect = GetTabRect(A_2);
				A_0.DrawImage(base.ImageList.Images[base.ImageList.Images.Count - 1], tabRect.Right - tabRect.Width + 4, 4, tabRect.Height - 2, tabRect.Height - 2);
				A_0.DrawImage(image, tabRect.Right - tabRect.Width + 4, 4, tabRect.Height - 2, tabRect.Height - 2);
			}
		}
	}

	private void a(Graphics A_0, int A_1)
	{
		Rectangle tabRect = GetTabRect(A_1);
		checked
		{
			Rectangle rectangle = new Rectangle(tabRect.Left + 8, tabRect.Top + 1, tabRect.Width - 6, tabRect.Height);
			if (A_1 == 0)
			{
				rectangle = new Rectangle(tabRect.Left + tabRect.Height, tabRect.Top + 1, tabRect.Width - tabRect.Height, tabRect.Height);
			}
			string text = base.TabPages[A_1].Text;
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Near;
			stringFormat.LineAlignment = StringAlignment.Center;
			stringFormat.Trimming = StringTrimming.EllipsisCharacter;
			Brush brush = null;
			brush = (base.TabPages[A_1].Enabled ? SystemBrushes.ControlText : SystemBrushes.ControlDark);
			Font font = Font;
			if (A_1 == base.SelectedIndex)
			{
				font = new Font(Font, FontStyle.Bold);
				if (A_1 == 0)
				{
					rectangle = new Rectangle(tabRect.Left + tabRect.Height, tabRect.Top + 1, tabRect.Width - tabRect.Height + 5, tabRect.Height);
				}
			}
			A_0.DrawString(text, font, brush, rectangle, stringFormat);
		}
	}

	private void a()
	{
		this.m_a = new Container();
		a(new Timer(this.m_a));
		SuspendLayout();
		c().Enabled = true;
		c().Interval = 500;
		ResumeLayout(performLayout: false);
	}

	private void a(object A_0, EventArgs A_1)
	{
	}
}
