using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

internal class iw
{
	public delegate void a(Control A_0, string A_1, bool A_2);

	private enum b
	{
		a,
		b,
		c
	}

	public enum c
	{
		a,
		b
	}

	public enum d
	{
		a,
		b
	}

	public enum e
	{
		a,
		b
	}

	public const int a = 34;

	private int m_b;

	private gr m_c;

	private bool m_d;

	[CompilerGenerated]
	private ContextMenuStrip m_e;

	private Control f;

	public int g;

	[CompilerGenerated]
	private ToolStripMenuItem h;

	[CompilerGenerated]
	private ToolStripMenuItem i;

	[CompilerGenerated]
	private ToolStripMenuItem j;

	[CompilerGenerated]
	private ToolStripMenuItem k;

	[CompilerGenerated]
	private ToolStripMenuItem l;

	[CompilerGenerated]
	private ToolStripMenuItem m;

	[CompilerGenerated]
	private ToolStripMenuItem n;

	[CompilerGenerated]
	private ToolStripMenuItem o;

	[CompilerGenerated]
	private ToolStripMenuItem p;

	[CompilerGenerated]
	private ToolStripMenuItem m_q;

	[CompilerGenerated]
	private ToolStripMenuItem m_r;

	[CompilerGenerated]
	private ToolStripMenuItem m_s;

	[CompilerGenerated]
	private ToolStripMenuItem m_t;

	private ToolStripSeparator m_u;

	private ToolStripSeparator m_v;

	private ToolStripMenuItem m_w;

	private ToolStripSeparator m_x;

	private ToolStripSeparator m_y;

	public Collection<string> z;

	public ToolStripMenuItem[] aa;

	public ToolStripMenuItem[] ab;

	public ToolStripMenuItem[] ac;

	public ToolStripMenuItem[] ad;

	public ToolStripMenuItem[] ae;

	public ToolStripMenuItem[] af;

	public Collection<string> ag;

	public Collection<string> ah;

	public Collection<string> ai;

	[CompilerGenerated]
	private a m_aj;

	[SpecialName]
	[CompilerGenerated]
	public virtual ContextMenuStrip r()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void q(ContextMenuStrip A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ToolStripMenuItem s()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void q(ToolStripMenuItem A_0)
	{
		h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ToolStripMenuItem t()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void r(ToolStripMenuItem A_0)
	{
		i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ToolStripMenuItem u()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void s(ToolStripMenuItem A_0)
	{
		j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ToolStripMenuItem v()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void t(ToolStripMenuItem A_0)
	{
		k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ToolStripMenuItem w()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void u(ToolStripMenuItem A_0)
	{
		l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ToolStripMenuItem x()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void v(ToolStripMenuItem A_0)
	{
		m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ToolStripMenuItem y()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void w(ToolStripMenuItem A_0)
	{
		n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ToolStripMenuItem aj()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void x(ToolStripMenuItem A_0)
	{
		o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ToolStripMenuItem ak()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void y(ToolStripMenuItem A_0)
	{
		p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ToolStripMenuItem al()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aj(ToolStripMenuItem A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ToolStripMenuItem am()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ak(ToolStripMenuItem A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ToolStripMenuItem an()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void al(ToolStripMenuItem A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual ToolStripMenuItem ao()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void am(ToolStripMenuItem A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void q(a A_0)
	{
		a a10 = this.m_aj;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Combine(a11, A_0);
			a10 = Interlocked.CompareExchange(ref this.m_aj, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void r(a A_0)
	{
		a a10 = this.m_aj;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Remove(a11, A_0);
			a10 = Interlocked.CompareExchange(ref this.m_aj, value, a11);
		}
		while ((object)a10 != a11);
	}

	public iw(gr A_0, EventHandler A_1, EventHandler A_2, EventHandler A_3, EventHandler A_4, EventHandler A_5, a A_6, IContainer A_7)
	{
		this.m_c = A_0;
		q(A_1, A_2, A_3, A_4, A_5, A_6, A_7);
	}

	public void q(EventHandler A_0, EventHandler A_1, EventHandler A_2, EventHandler A_3, EventHandler A_4, a A_5, IContainer A_6)
	{
		if (this.m_c.sm() || !this.m_d || this.m_b != q())
		{
			this.m_b = q();
			q(new ContextMenuStrip(A_6));
			w(new ToolStripMenuItem("Air"));
			y().Tag = false;
			u(new ToolStripMenuItem("Photoresist"));
			q(new ToolStripMenuItem("Dielectric"));
			v(new ToolStripMenuItem("Semiconductor"));
			r(new ToolStripMenuItem("Metal"));
			s(new ToolStripMenuItem("Other"));
			t(new ToolStripMenuItem("LayerStack"));
			this.m_u = new ToolStripSeparator();
			this.m_v = new ToolStripSeparator();
			this.m_w = new ToolStripMenuItem("Clear Recent Materials");
			string A_7 = "AddNewMaterial";
			ak(new ToolStripMenuItem(hu.a(ref A_7)));
			A_7 = "EnterRefractiveIndex";
			al(new ToolStripMenuItem(hu.a(ref A_7)));
			am(new ToolStripMenuItem("Search..."));
			x(new ToolStripMenuItem("Edit Layer Stack..."));
			this.m_x = new ToolStripSeparator();
			aj(new ToolStripMenuItem("<Roughness>"));
			y(new ToolStripMenuItem("<Graded Interface>"));
			this.m_y = new ToolStripSeparator();
			r().Name = "ContextMenuStrip1";
			r().Size = new Size(61, 4);
			r().Items.AddRange(new ToolStripItem[20]
			{
				this.m_u,
				an(),
				ao(),
				new ToolStripSeparator(),
				y(),
				w(),
				s(),
				x(),
				t(),
				u(),
				v(),
				new ToolStripSeparator(),
				aj(),
				this.m_x,
				al(),
				ak(),
				this.m_y,
				am(),
				this.m_v,
				this.m_w
			});
			string[] A_8 = null;
			string[] A_9 = null;
			string[] A_10 = null;
			string[] A_11 = null;
			string[] A_12 = null;
			short A_13 = default(short);
			short A_14 = default(short);
			short A_15 = default(short);
			short A_16 = default(short);
			short A_17 = default(short);
			this.m_c.m2(ref A_8, ref A_13, ref A_9, ref A_14, ref A_10, ref A_15, ref A_11, ref A_16, ref A_12, ref A_17);
			t().Visible = A_8.Length > 0;
			x().Visible = A_9.Length > 0;
			s().Visible = A_10.Length > 0;
			w().Visible = A_11.Length > 0;
			u().Visible = A_12.Length > 0;
			q(A_8, t(), A_2: false);
			q(A_9, x(), A_2: false);
			q(A_10, s(), A_2: false);
			q(A_11, w(), A_2: false);
			q(A_12, u(), A_2: false);
			this.m_d = true;
			g = 0;
			q(A_5);
			am().Click += A_0;
			an().Click += A_1;
			ao().Click += A_2;
			aj().Click += A_3;
			this.m_w.Click += A_4;
			ak().Tag = false;
			ak().Click += q;
			al().Tag = false;
			al().Click += q;
			y().Click += q;
		}
	}

	private int q()
	{
		Form form = global::c.d().OpenForms[0];
		return checked(34 * Screen.FromPoint(new Point(form.Location.X + unchecked(form.Width / 2), form.Location.Y + unchecked(form.Height / 2))).WorkingArea.Height) / 800;
	}

	public void q(string[] A_0, ToolStripMenuItem A_1, bool A_2)
	{
		int num = A_0.Length / this.m_b;
		if (A_0.Length % this.m_b == 0)
		{
			num = checked(num - 1);
		}
		string a_ = null;
		string A_3 = null;
		string A_4 = null;
		string text = null;
		checked
		{
			if (num > 0)
			{
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
					toolStripMenuItem.Name = A_1.Text + " Alpha " + num3;
					if (num3 > 0)
					{
						a_ = A_4;
					}
					int num4 = num3 * this.m_b;
					int num5;
					if (num3 < num)
					{
						num5 = (num3 + 1) * this.m_b - 1;
						text = A_0[num5 + 1];
					}
					else
					{
						num5 = A_0.Length - 1;
						text = null;
					}
					q(a_, A_0[num4], A_0[num5], text, ref A_3, ref A_4);
					toolStripMenuItem.Text = A_3 + " :: " + A_4;
					A_1.DropDownItems.Add(toolStripMenuItem);
					int num6 = num5;
					for (int num7 = num4; num7 <= num6; num7++)
					{
						ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
						toolStripMenuItem2.Name = A_0[num7];
						toolStripMenuItem2.Text = A_0[num7];
						toolStripMenuItem2.Tag = A_2;
						toolStripMenuItem2.Click += q;
						toolStripMenuItem.DropDownItems.Add(toolStripMenuItem2);
					}
				}
			}
			else
			{
				A_1.DropDownItems.Clear();
				int num8 = A_0.Length - 1;
				for (int num9 = 0; num9 <= num8; num9++)
				{
					ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
					toolStripMenuItem3.Name = A_0[num9];
					toolStripMenuItem3.Text = A_0[num9];
					toolStripMenuItem3.Tag = A_2;
					toolStripMenuItem3.Click += q;
					A_1.DropDownItems.Add(toolStripMenuItem3);
				}
			}
		}
	}

	public void q(gc.a A_0, c A_1)
	{
		if (z == null)
		{
			return;
		}
		ap();
		int num = 0;
		checked
		{
			for (int num2 = z.Count - 1; num2 >= 0; num2 += -1)
			{
				if (A_1 != iw.c.a || (!gd.l(z[num2]) && !z[num2].Contains("<Roughness>")))
				{
					ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
					toolStripMenuItem.Text = hg.bz(z[num2]);
					toolStripMenuItem.Tag = gd.l(toolStripMenuItem.Text);
					toolStripMenuItem.Click += q;
					r().Items.Insert(0, toolStripMenuItem);
					num++;
				}
			}
			this.m_u.Visible = num > 0;
			if (num > 0)
			{
				switch (A_0)
				{
				case gc.a.b:
				{
					ToolStripMenuItem toolStripMenuItem4 = this.m_w;
					string A_2 = "ClearMRLLddd";
					toolStripMenuItem4.Text = hu.a(ref A_2);
					break;
				}
				case gc.a.a:
				{
					ToolStripMenuItem toolStripMenuItem3 = this.m_w;
					string A_2 = "ClearMRMLddd";
					toolStripMenuItem3.Text = hu.a(ref A_2);
					break;
				}
				case gc.a.c:
				{
					ToolStripMenuItem toolStripMenuItem2 = this.m_w;
					string A_2 = "ClearMRSLddd";
					toolStripMenuItem2.Text = hu.a(ref A_2);
					break;
				}
				default:
					throw new ax("UtilBuildMaterialMenus.BuildMostRecentMatMenu");
				}
			}
			this.m_v.Visible = num > 0;
			this.m_w.Visible = num > 0;
			g = num;
		}
	}

	public void ap()
	{
		checked
		{
			if (g > 0)
			{
				int num = g - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					r().Items.RemoveAt(0);
				}
				g = 0;
				this.m_u.Visible = false;
				this.m_w.Visible = false;
				this.m_v.Visible = false;
			}
		}
	}

	private void q(object A_0, EventArgs A_1)
	{
		ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)A_0;
		this.m_aj?.Invoke(f, toolStripMenuItem.Text, Conversions.ToBoolean(toolStripMenuItem.Tag));
	}

	public void q(gc.a A_0)
	{
		switch (A_0)
		{
		case gc.a.a:
			z = ah;
			break;
		case gc.a.b:
			z = ag;
			break;
		case gc.a.c:
			z = ai;
			break;
		default:
			throw new ax("Invalid layer type in UtilBuildMaterialMenus.UpdateRecentAndCurrentMatRelatedItems");
		}
	}

	public void q(Control A_0, Point A_1, d A_2, e A_3, gc.a A_4, string[] A_5)
	{
		q(A_4);
		c a_;
		if (A_5 == null)
		{
			a_ = iw.c.a;
		}
		else
		{
			a_ = iw.c.b;
			q(A_5, v(), A_2: true);
		}
		q(A_4, a_);
		if (A_3 == iw.e.a)
		{
			if (t().HasDropDownItems)
			{
				t().Visible = true;
			}
			if (x().HasDropDownItems)
			{
				x().Visible = true;
			}
		}
		else
		{
			t().Visible = false;
			x().Visible = false;
		}
		v().Visible = A_2 == iw.d.a && A_5 != null && A_5.Length > 0;
		aj().Visible = A_2 == iw.d.a;
		this.m_x.Visible = aj().Visible;
		bool flag = A_4 == gc.a.b;
		al().Visible = flag && A_2 == iw.d.a;
		ak().Visible = flag;
		this.m_y.Visible = flag;
		f = A_0;
		r().Show(A_0, A_1);
	}

	private string q(string A_0, int A_1, int A_2)
	{
		string text = A_0;
		checked
		{
			for (int num = A_1; num <= A_2; num++)
			{
				if (Operators.CompareString(Conversions.ToString(A_0[num]), " ", TextCompare: false) != 0 && Operators.CompareString(Conversions.ToString(A_0[num]), "-", TextCompare: false) != 0 && A_2 >= num)
				{
					text = A_0.Substring(0, num + 1);
					break;
				}
			}
			if (text.Length == 1)
			{
				text = text.ToUpper();
			}
			return text;
		}
	}

	private void q(string A_0, string A_1, string A_2, string A_3, ref string A_4, ref string A_5)
	{
		int num = 0;
		checked
		{
			int num2 = A_1.Length - 1;
			int num3 = A_2.Length - 1;
			if (!string.IsNullOrEmpty(A_0))
			{
				int num4 = A_0.Length - 1;
				for (num = 0; num <= num4 && string.Compare(Conversions.ToString(A_0[num]), Conversions.ToString(A_1[num]), ignoreCase: true) == 0; num++)
				{
				}
			}
			A_4 = q(A_1, num, num2);
			if (Operators.CompareString(A_1, A_2, TextCompare: false) != 0)
			{
				int num5 = num2;
				for (num = 0; num <= num5 && string.Compare(Conversions.ToString(A_1[num]), Conversions.ToString(A_2[num]), ignoreCase: true) == 0; num++)
				{
				}
				if (!string.IsNullOrEmpty(A_3))
				{
					int num6 = num3;
					int num7;
					for (num7 = 0; num7 <= num6 && string.Compare(Conversions.ToString(A_2[num7]), Conversions.ToString(A_3[num7]), ignoreCase: true) == 0; num7++)
					{
					}
					if (num7 > num)
					{
						num = num7;
					}
				}
			}
			A_5 = q(A_2, num, num3);
		}
	}
}
