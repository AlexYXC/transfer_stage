using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class fx
{
	private Color a;

	private double b;

	private double c;

	private bool d;

	private fx e;

	private Collection<fx> f;

	private float g;

	private int h;

	private int i;

	private bool j;

	private fl k;

	private int l;

	private double[] m;

	private double[] n;

	private float o;

	private float p;

	private long m_q;

	public fl.g r;

	public double s;

	private const short m_t = 10;

	[CompilerGenerated]
	private List<string> m_u;

	[CompilerGenerated]
	private bool m_v;

	[CompilerGenerated]
	private bool m_w;

	[SpecialName]
	public Color q()
	{
		return a;
	}

	[SpecialName]
	public void q(Color A_0)
	{
		a = A_0;
	}

	[SpecialName]
	public bool t()
	{
		return d;
	}

	[SpecialName]
	public void q(bool A_0)
	{
		d = A_0;
		if (d)
		{
			o = 0.25f;
		}
		else
		{
			o = 1f;
		}
	}

	[SpecialName]
	public float u()
	{
		return g;
	}

	[SpecialName]
	public void t(float A_0)
	{
		g = A_0;
	}

	[SpecialName]
	public float v()
	{
		return p;
	}

	[SpecialName]
	public void u(float A_0)
	{
		p = A_0;
	}

	[SpecialName]
	public double w()
	{
		return b;
	}

	[SpecialName]
	public void q(double A_0)
	{
		b = A_0;
	}

	[SpecialName]
	public double x()
	{
		return c;
	}

	[SpecialName]
	public void t(double A_0)
	{
		c = A_0;
	}

	[SpecialName]
	public double y()
	{
		if (l > 0)
		{
			return m[checked(l - 1)];
		}
		return 0.0;
	}

	[SpecialName]
	public double z()
	{
		return m[0];
	}

	[SpecialName]
	public int aa()
	{
		return l;
	}

	[SpecialName]
	public bool ab()
	{
		return j;
	}

	[SpecialName]
	public void t(bool A_0)
	{
		j = A_0;
	}

	[SpecialName]
	public long ac()
	{
		return this.m_q;
	}

	[SpecialName]
	public void q(long A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public List<string> ad()
	{
		return this.m_u;
	}

	[SpecialName]
	[CompilerGenerated]
	public void q(List<string> A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool ae()
	{
		return this.m_v;
	}

	[SpecialName]
	[CompilerGenerated]
	public void u(bool A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool af()
	{
		return this.m_w;
	}

	[SpecialName]
	[CompilerGenerated]
	public void v(bool A_0)
	{
		this.m_w = A_0;
	}

	public fx()
	{
		q(new List<string>());
		l = 0;
		m = new double[2];
		n = new double[2];
		j = true;
		p = 4f;
		d = true;
	}

	public fx(fl.g A_0)
		: this()
	{
		r = A_0;
	}

	~fx()
	{
		k = null;
		base.Finalize();
	}

	public void ag()
	{
		h = 0;
		i = checked(l - 1);
	}

	public void q(ref double[] A_0, ref double[] A_1, int A_2, ref fl A_3)
	{
		checked
		{
			int num = l + A_2 - 1;
			if (A_2 <= 0)
			{
				return;
			}
			double num2;
			double num3;
			if (l == 0)
			{
				m = A_0;
				n = A_1;
				num2 = A_1[0];
				num3 = A_1[0];
				int num4 = num;
				for (int num5 = 1; num5 <= num4; num5++)
				{
					if (n[num5] > num2)
					{
						num2 = n[num5];
					}
					else if (n[num5] < num3)
					{
						num3 = n[num5];
					}
				}
			}
			else
			{
				num2 = b;
				num3 = c;
				if (Information.UBound(m) < l + A_2)
				{
					ref double[] reference = ref m;
					reference = (double[])Utils.CopyArray(reference, new double[l + A_2 + 10 + 1]);
					ref double[] reference2 = ref n;
					reference2 = (double[])Utils.CopyArray(reference2, new double[l + A_2 + 10 + 1]);
				}
				int num6 = l;
				int num7 = num;
				for (int num5 = num6; num5 <= num7; num5++)
				{
					int num8 = num5 - l;
					m[num5] = A_0[num8];
					n[num5] = A_1[num8];
					if (n[num5] > num2)
					{
						num2 = n[num5];
					}
					else if (n[num5] < num3)
					{
						num3 = n[num5];
					}
				}
			}
			b = num2;
			c = num3;
			l += A_2;
			k = A_3;
			i = l - 1;
			k.g6();
		}
	}

	public void q(double[] A_0, double[] A_1, int A_2, ref fl A_3)
	{
		l = 0;
		if (A_2 > 0)
		{
			q(ref A_0, ref A_1, A_2, ref A_3);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public void q(ref string A_0, [Optional][DefaultParameterValue(false)] ref bool A_1)
	{
		int num = FileSystem.FreeFile();
		FileSystem.FileOpen(num, A_0, OpenMode.Output);
		FileSystem.WriteLine(num, "X-Axis", "Y-Axis");
		checked
		{
			int num2 = l - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				FileSystem.WriteLine(num, m[num3], n[num3]);
			}
			FileSystem.FileClose(num);
		}
	}

	public double q(double A_0, double A_1)
	{
		if (l == 0)
		{
			return b;
		}
		checked
		{
			if ((A_0 < m[0]) & (A_1 > m[l - 1]))
			{
				return b;
			}
			int num = l - 1;
			double num3 = default(double);
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (((m[num2] >= A_0) & (m[num2] <= A_1)) && n[num2] >= num3)
				{
					num3 = n[num2];
				}
			}
			return num3;
		}
	}

	public double t(double A_0, double A_1)
	{
		if (l == 0)
		{
			return c;
		}
		checked
		{
			if ((A_0 < m[0]) & (A_1 > m[l - 1]))
			{
				return c;
			}
			double num = double.MaxValue;
			int num2 = l - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (((m[num3] >= A_0) & (m[num3] <= A_1)) && n[num3] < num)
				{
					num = n[num3];
				}
			}
			return num;
		}
	}

	public double q(int A_0)
	{
		return m[A_0];
	}

	public double t(int A_0)
	{
		return n[A_0];
	}

	public void q(double A_0, double A_1, ref int A_2, ref int A_3)
	{
		checked
		{
			int num = m.Length - 1;
			if (A_0 > m[num] || A_0 < m[0])
			{
				if (A_0 > m[num])
				{
					A_2 = num + 1;
				}
				if (A_0 < m[0])
				{
					A_2 = -1;
				}
			}
			else
			{
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (m[num3] >= A_0)
					{
						A_2 = num3;
						break;
					}
				}
			}
			if (A_1 > m[num] || A_1 < m[0])
			{
				if (A_1 > m[num])
				{
					A_3 = num + 1;
				}
				if (A_1 < m[0])
				{
					A_3 = -1;
				}
				return;
			}
			int num4 = num;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				if (m[num5] >= A_1)
				{
					A_3 = num5;
					break;
				}
			}
		}
	}

	public bool q(int A_0, int A_1, double A_2, double A_3)
	{
		if (A_0 == -1 && A_1 == -1)
		{
			return false;
		}
		checked
		{
			if (A_0 > n.Length - 1 && A_1 > n.Length - 1)
			{
				return false;
			}
			if (A_1 > n.Length - 1)
			{
				A_1 = n.Length - 1;
			}
			if (A_0 == -1)
			{
				A_0 = 0;
			}
			int num = A_0;
			int num2 = A_1;
			for (int num3 = num; num3 <= num2; num3++)
			{
				if (n[num3] > A_3 && n[num3] < A_2)
				{
					return true;
				}
			}
			return false;
		}
	}

	[SpecialName]
	public fx ah()
	{
		return e;
	}

	[SpecialName]
	public void q(fx A_0)
	{
		e = A_0;
	}

	[SpecialName]
	public Collection<fx> ai()
	{
		return f;
	}

	public void aj()
	{
		f.Clear();
	}

	public void t(fx A_0)
	{
		if (f == null)
		{
			f = new Collection<fx>();
		}
		f.Add(A_0);
	}

	public void q(Keys A_0, ref double A_1)
	{
		float num = g;
		checked
		{
			switch (A_0)
			{
			case Keys.Left:
				num = (float)(int)Math.Round(num / o) * o - o;
				break;
			case Keys.Right:
				num = (float)(int)Math.Round(num / o) * o + o;
				break;
			case Keys.Up:
				num = (float)(int)Math.Round(num / p) * p + p;
				break;
			case Keys.Down:
				num = (float)(int)Math.Round(num / p) * p - p;
				break;
			}
			if (num < 0f)
			{
				num = 0f;
			}
			else if (num > (float)(l - 1))
			{
				num = l - 1;
			}
			A_1 = q(num);
			if (A_1 < k.gi().a2().ap())
			{
				u(k.gi().a2().ap());
				A_1 = k.gi().a2().ap();
			}
			else if (A_1 > k.gi().a2().aq())
			{
				u(k.gi().a2().aq());
				A_1 = k.gi().a2().aq();
			}
			else
			{
				g = num;
			}
		}
	}

	public double ak()
	{
		if (g < 0f)
		{
			return n[0];
		}
		checked
		{
			if (g >= (float)(l - 1))
			{
				return n[l - 1];
			}
			double num = n[(int)Math.Round(Conversion.Int(g))];
			double num2 = n[(int)Math.Round(Conversion.Int(g) + 1f)];
			return num + (num2 - num) * (double)(g - Conversion.Int(g));
		}
	}

	private double q(float A_0)
	{
		if (A_0 < 0f)
		{
			return m[0];
		}
		checked
		{
			if (A_0 >= (float)(l - 1))
			{
				return m[l - 1];
			}
			double num = m[(int)Math.Round(Conversion.Int(A_0))];
			double num2 = m[(int)Math.Round(Conversion.Int(A_0 + 1f))];
			return num + (num2 - num) * (double)(A_0 - Conversion.Int(A_0));
		}
	}

	public void q(ref double A_0, float A_1, float A_2)
	{
		checked
		{
			if (g > (float)(l - 1))
			{
				g = l - 1;
				A_0 = q(g);
			}
			if (jf.d(q(g), A_1))
			{
				while ((q(g) < (double)A_1) & (g < (float)(l - 1)))
				{
					g++;
				}
				A_0 = q(g);
			}
			if (jf.b(q(g), A_2))
			{
				while ((q(g) > (double)A_2) & (g > 0f))
				{
					g--;
				}
				A_0 = q(g);
			}
			if (g < 0f)
			{
				g = 0f;
			}
		}
	}

	public void u(double A_0)
	{
		int num = 0;
		checked
		{
			int num2 = l - 1;
			if (A_0 <= m[0])
			{
				g = 0f;
				return;
			}
			if (A_0 >= m[l - 1])
			{
				g = l - 1;
				return;
			}
			int num3 = default(int);
			while (num2 >= num)
			{
				num3 = (int)Math.Round((double)(num + num2) / 2.0);
				if (A_0 < m[num3])
				{
					num2 = num3 - 1;
					continue;
				}
				if (!(A_0 > m[num3]))
				{
					break;
				}
				num = num3 + 1;
			}
			double num4 = ((m[num3] == A_0) ? 0.0 : ((!(m[num3] < A_0)) ? ((A_0 - m[num3]) / (m[num3] - m[num3 - 1])) : ((A_0 - m[num3]) / (m[num3 + 1] - m[num3]))));
			g = (float)((double)num3 + num4);
		}
	}

	public List<fn> q(string A_0, int A_1, bool A_2)
	{
		List<fn> list = new List<fn>();
		fn fn2 = new fn();
		fn2.k(A_0);
		fn2.k(A_1);
		fn2.n(A_2);
		fn2.k(A_0: true);
		fn2.l(A_0: false);
		fn2.m(A_0: false);
		fn2.l(-1);
		fn2.k(ad());
		fn2.o(ae());
		fn2.p(af());
		list.Add(fn2);
		if (ah() != null)
		{
			fn fn3 = new fn();
			fn3.k(A_0);
			fn3.k(A_1);
			fn3.n(A_2);
			fn3.k(A_0: false);
			fn3.l(A_0: true);
			fn3.m(A_0: false);
			fn3.l(-1);
			fn3.k(ah().ad());
			fn3.o(ah().ae());
			fn3.p(af());
			list.Add(fn3);
		}
		checked
		{
			if (ai() != null && ai().Count > 0)
			{
				int num = ai().Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					fn fn4 = new fn();
					fn4.k(A_0);
					fn4.k(A_1);
					fn4.n(A_2);
					fn4.k(A_0: false);
					fn4.l(A_0: false);
					fn4.m(A_0: true);
					fn4.l(num2);
					fn4.k(f[num2].ad());
					fn4.o(f[num2].ae());
					fn4.p(af());
					list.Add(fn4);
				}
			}
			return list;
		}
	}

	public void q(Graphics A_0)
	{
		q(A_0, A_1: false, default(Color), r);
	}

	public void q(Graphics A_0, Color A_1)
	{
		q(A_0, A_1: true, A_1, r);
	}

	public void q(Graphics A_0, fl.g A_1)
	{
		q(A_0, A_1: false, default(Color), A_1);
	}

	public void q(Graphics A_0, Color A_1, fl.g A_2)
	{
		q(A_0, A_1: true, A_1, A_2);
	}

	private void q(Graphics A_0, bool A_1, Color A_2, fl.g A_3)
	{
		if (k != null)
		{
			if (A_1)
			{
				k.o(ref m, ref n, h, i, d, A_2, A_0, A_3);
			}
			else
			{
				k.o(ref m, ref n, h, i, d, a, A_0, A_3);
			}
			h = i;
		}
	}
}
