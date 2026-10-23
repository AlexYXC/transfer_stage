using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class bs : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private PictureBox m_b;

	private const string m_c = "DialogVideo";

	private const string m_d = "Live Video";

	private const string m_e = "Live Video (Paused)";

	private fz f;

	private f1 g;

	private Guid h;

	private r.l i;

	[CompilerGenerated]
	private r.d j;

	private d4.a k;

	public bs()
	{
		base.FormClosing += a;
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
		a(new PictureBox());
		((ISupportInitialize)b()).BeginInit();
		SuspendLayout();
		b().BackColor = SystemColors.ButtonShadow;
		b().BackgroundImageLayout = ImageLayout.None;
		b().Dock = DockStyle.Fill;
		b().ImeMode = ImeMode.NoControl;
		b().Location = new Point(0, 0);
		b().Name = "PictureBoxImage";
		b().Size = new Size(618, 430);
		b().SizeMode = PictureBoxSizeMode.Zoom;
		b().TabIndex = 77;
		b().TabStop = false;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(618, 430);
		base.Controls.Add(b());
		base.Name = "DialogVideo";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "(set programmatically)";
		((ISupportInitialize)b()).EndInit();
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox b()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(PictureBox A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d c()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		r.d.b a_ = a;
		j?.e(a_);
		j = A_0;
		j?.d(a_);
	}

	public void a(fz A_0, f1 A_1, Guid A_2)
	{
		f = A_0;
		g = A_1;
		h = A_2;
		a(new r.d());
		i = new r.l();
		i.m = c();
		i.q(A_0: false);
		Text = "Live Video";
		k = g.t6(h.ToString());
		g.m2(h, A_1: false, i, r.d.a.b.a);
		Show();
	}

	public void d()
	{
		i.q(A_0: true);
		Text = "Live Video (Paused)";
	}

	public void e()
	{
		if (i.q())
		{
			i = new r.l();
			i.m = c();
			Text = "Live Video";
			g.m2(h, A_1: false, i, r.d.a.b.a);
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		try
		{
			a((r.d)null);
			if (i != null)
			{
				i.q(A_0: true);
				if (b().Image != null)
				{
					b().Image.Dispose();
					b().Image = null;
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(f, g, null, i6.a(this), "DialogVideo.DialogVideo_FormClosing", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(r.d.a A_0)
	{
		try
		{
			if (i.q())
			{
				return;
			}
			if (base.InvokeRequired)
			{
				r.d.b method = a;
				BeginInvoke(method, A_0);
			}
			else
			{
				if (!base.IsHandleCreated)
				{
					return;
				}
				Bitmap bitmap = (Bitmap)A_0.d;
				if (bitmap == null)
				{
					return;
				}
				if (global::e.a().VideoShowSpot)
				{
					d4.a a10 = k;
					if (a10.o())
					{
						f4.i(bitmap, a10.w());
					}
					a10 = null;
				}
				PictureBox pictureBox = b();
				if (pictureBox.Image != null)
				{
					pictureBox.Image.Dispose();
					pictureBox.Image = null;
				}
				pictureBox.Image = bitmap;
				pictureBox = null;
			}
		}
		catch (ObjectDisposedException ex2)
		{
			ProjectData.SetProjectError(ex2);
			ObjectDisposedException ex3 = ex2;
			ProjectData.ClearProjectError();
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception a_ = ex4;
			f.c(fz.b.b, "Error in DialogVideo.VideoUpdateEventHandler", a_);
			ProjectData.ClearProjectError();
		}
	}
}
