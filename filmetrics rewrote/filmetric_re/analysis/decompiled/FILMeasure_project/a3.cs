using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class a3 : Button
{
	public enum a
	{
		a,
		b
	}

	private int m_a;

	[CompilerGenerated]
	private ImageList b;

	private IContainer m_c;

	private a m_d;

	[SpecialName]
	[CompilerGenerated]
	internal virtual ImageList c()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ImageList A_0)
	{
		b = A_0;
	}

	public a3(int A_0, a A_1)
	{
		a();
		this.m_a = A_0;
		this.m_d = A_1;
		Font = new Font("Arial", 12f, FontStyle.Bold);
	}

	[SpecialName]
	public int d()
	{
		return this.m_a;
	}

	protected override void OnPaint(PaintEventArgs pevent)
	{
		base.OnPaint(pevent);
		Graphics graphics = pevent.Graphics;
		_ = Brushes.Black;
		_ = new PointF[5];
		_ = base.ClientRectangle;
		if (this.m_d == a3.a.a)
		{
			Image image = c().Images[0];
			graphics.DrawImage(image, new Point(2, 2));
		}
		else
		{
			Image image2 = c().Images[1];
			graphics.DrawImage(image2, new Point(2, 2));
		}
	}

	private void a()
	{
		this.m_c = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(a3));
		a(new ImageList(this.m_c));
		SuspendLayout();
		c().ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
		c().TransparentColor = Color.Transparent;
		c().Images.SetKeyName(0, "AddColumn4.ico");
		c().Images.SetKeyName(1, "minus4.ico");
		c().Images.SetKeyName(2, "minus3.ico");
		c().Images.SetKeyName(3, "AddColumn3.ico");
		c().Images.SetKeyName(4, "AddColumn2.ico");
		c().Images.SetKeyName(5, "minus2.ico");
		c().Images.SetKeyName(6, "minus.ico");
		c().Images.SetKeyName(7, "AddColumn1.ico");
		c().Images.SetKeyName(8, "delete_16xBW.ico");
		c().Images.SetKeyName(9, "AddColumn.ico");
		c().Images.SetKeyName(10, "ArrowDown1BW.ico");
		c().Images.SetKeyName(11, "ArrowDown.ico");
		c().Images.SetKeyName(12, "delete_16x.ico");
		c().Images.SetKeyName(13, "ArrowDownbw.ico");
		ResumeLayout(performLayout: false);
	}
}
