using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class cf
{
	public enum a
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g,
		h,
		i
	}

	internal enum b
	{
		a,
		b
	}

	internal class c
	{
		private double a;

		private List<double> b;

		private List<double> m_c;

		private List<double> d;

		private List<double> e;

		private List<double> f;

		private List<double> g;

		private short h;

		private List<double> i;

		private List<double> j;

		private List<double> k;

		private List<double> l;

		private List<double> m;

		private List<double> n;

		private List<double> o;

		private bool p;

		private double q;

		private double r;

		private double s;

		private List<double> t;

		private bool u;

		private bool v;

		private bool w;

		private double x;

		public const double y = 450.0;

		public const double z = 1000.0;

		private const int aa = 5;

		private const int ab = 2;

		private const int ac = 3;

		private const int ad = 2;

		private const short ae = 13;

		[SpecialName]
		public static bool aq(c A_0, c A_1)
		{
			checked
			{
				switch (ix.a(A_0, A_1))
				{
				case ix.a.a:
					return false;
				case ix.a.b:
					return true;
				default:
				{
					c c10 = A_0;
					if (!jf.e(c10.ap(), A_1.ap()))
					{
						return true;
					}
					if (c10.aq() != A_1.aq())
					{
						return true;
					}
					if (c10.bb() != A_1.bb())
					{
						return true;
					}
					if (c10.ar() != A_1.ar())
					{
						return true;
					}
					int num = c10.ar() - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						if (!jf.e(c10.ap(num2), A_1.ap(num2)))
						{
							return true;
						}
					}
					if (c10.au() != A_1.au())
					{
						return true;
					}
					int num3 = c10.au() - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						if (!jf.e(c10.@as(num4), A_1.@as(num4)))
						{
							return true;
						}
					}
					if (c10.ax() != A_1.ax())
					{
						return true;
					}
					int num5 = c10.ax() - 1;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						if (!jf.e(c10.at(num6), A_1.at(num6)))
						{
							return true;
						}
					}
					int num7 = c10.bb() - 1;
					for (int num8 = 0; num8 <= num7; num8++)
					{
						if (!jf.e(c10.ax(num8), A_1.ax(num8)))
						{
							return true;
						}
						if (!jf.e(c10.ay(num8), A_1.ay(num8)))
						{
							return true;
						}
						if (!jf.e(c10.a2(num8), A_1.a2(num8)))
						{
							return true;
						}
					}
					if (c10.@as() != A_1.@as())
					{
						return true;
					}
					int num9 = c10.@as() - 1;
					for (int num10 = 0; num10 <= num9; num10++)
					{
						if (!jf.e(c10.aq(num10), A_1.aq(num10)))
						{
							return true;
						}
					}
					if (!jf.e(c10.bc(), A_1.bc()))
					{
						return true;
					}
					if (!jf.e(c10.bd(), A_1.bd()))
					{
						return true;
					}
					if (!jf.e(c10.be(), A_1.be()))
					{
						return true;
					}
					if (c10.at() != A_1.at())
					{
						return true;
					}
					int num11 = c10.at() - 1;
					for (int num12 = 0; num12 <= num11; num12++)
					{
						if (!jf.e(c10.ar(num12), A_1.ar(num12)))
						{
							return true;
						}
					}
					if (c10.av() != A_1.av())
					{
						return true;
					}
					if (c10.ba())
					{
						int num13 = c10.av() - 1;
						for (int num14 = 0; num14 <= num13; num14++)
						{
							if (!jf.e(c10.aw(num14), A_1.aw(num14)))
							{
								return true;
							}
						}
					}
					if (c10.a2() != A_1.a2())
					{
						return true;
					}
					if (c10.ay() != A_1.ay())
					{
						return true;
					}
					if (c10.a5())
					{
						int num15 = c10.a2() - 1;
						for (int num16 = 0; num16 <= num15; num16++)
						{
							if (!jf.e(c10.au(num16), A_1.au(num16)))
							{
								return true;
							}
						}
						if (c10.a3() != A_1.a3())
						{
							return true;
						}
						int num17 = c10.a3() - 1;
						for (int num18 = 0; num18 <= num17; num18++)
						{
							if (!jf.e(c10.av(num18), A_1.av(num18)))
							{
								return true;
							}
						}
					}
					if (c10.az() != A_1.az())
					{
						return true;
					}
					if (c10.a0() != A_1.a0())
					{
						return true;
					}
					if (c10.w != A_1.w)
					{
						return true;
					}
					if (!jf.e(c10.bf(), A_1.bf()))
					{
						return true;
					}
					c10 = null;
					return false;
				}
				}
			}
		}

		[SpecialName]
		public static bool ap(c A_0, c A_1)
		{
			return !aq(A_0, A_1);
		}

		public bool ap(c A_0)
		{
			return ap(this, A_0);
		}

		[SpecialName]
		public double ap()
		{
			return a;
		}

		[SpecialName]
		public void ap(double A_0)
		{
			a = A_0;
		}

		[SpecialName]
		public short aq()
		{
			return h;
		}

		[SpecialName]
		public void ap(short A_0)
		{
			h = A_0;
		}

		[SpecialName]
		public double ap(int A_0)
		{
			return i[A_0];
		}

		[SpecialName]
		public double aq(int A_0)
		{
			return j[A_0];
		}

		[SpecialName]
		public double ar(int A_0)
		{
			return k[A_0];
		}

		[SpecialName]
		public int ar()
		{
			return i.Count;
		}

		[SpecialName]
		public int @as()
		{
			return j.Count;
		}

		[SpecialName]
		public int at()
		{
			return k.Count;
		}

		[SpecialName]
		public double @as(int A_0)
		{
			return l[A_0];
		}

		[SpecialName]
		public int au()
		{
			return l.Count;
		}

		[SpecialName]
		public double at(int A_0)
		{
			return m[A_0];
		}

		[SpecialName]
		public double au(int A_0)
		{
			return n[A_0];
		}

		[SpecialName]
		public double av(int A_0)
		{
			return o[A_0];
		}

		[SpecialName]
		public double aw(int A_0)
		{
			return t[A_0];
		}

		[SpecialName]
		public int av()
		{
			return t.Count;
		}

		public void aq(double A_0)
		{
			l.Add(A_0);
		}

		public void ar(double A_0)
		{
			m.Add(A_0);
		}

		public void @as(double A_0)
		{
			n.Add(A_0);
		}

		public void at(double A_0)
		{
			o.Add(A_0);
		}

		public void au(double A_0)
		{
			k.Add(A_0);
		}

		public void av(double A_0)
		{
			t.Add(A_0);
		}

		public void aw()
		{
			t.Clear();
		}

		[SpecialName]
		public int ax()
		{
			return m.Count;
		}

		[SpecialName]
		public bool ay()
		{
			return p;
		}

		[SpecialName]
		public void ap(bool A_0)
		{
			p = A_0;
		}

		[SpecialName]
		public bool az()
		{
			return u;
		}

		[SpecialName]
		public void aq(bool A_0)
		{
			u = A_0;
		}

		[SpecialName]
		public bool a0()
		{
			return v;
		}

		[SpecialName]
		public void ar(bool A_0)
		{
			v = A_0;
		}

		[SpecialName]
		public bool a1()
		{
			return w;
		}

		[SpecialName]
		public void @as(bool A_0)
		{
			w = A_0;
		}

		[SpecialName]
		public bool ar(a A_0)
		{
			if (w)
			{
				return !jf.e(aq(A_0), 0f);
			}
			return false;
		}

		[SpecialName]
		public int a2()
		{
			return n.Count;
		}

		[SpecialName]
		public int a3()
		{
			return o.Count;
		}

		[SpecialName]
		public bool a4()
		{
			return ax() > 0;
		}

		[SpecialName]
		public bool a5()
		{
			if (a2() > 0)
			{
				return a3() > 0;
			}
			return false;
		}

		[SpecialName]
		public bool a6()
		{
			if (e != null)
			{
				return e.Count > 0;
			}
			return false;
		}

		[SpecialName]
		public bool a7()
		{
			if (f != null && f.Count > 0 && g != null)
			{
				return g.Count > 0;
			}
			return false;
		}

		[SpecialName]
		public bool a8()
		{
			if (j != null)
			{
				return j.Count > 0;
			}
			return false;
		}

		[SpecialName]
		public bool a9()
		{
			if (k != null)
			{
				return k.Count > 0;
			}
			return false;
		}

		[SpecialName]
		public bool ba()
		{
			if (t != null)
			{
				return t.Count > 0;
			}
			return false;
		}

		[SpecialName]
		public int bb()
		{
			return m_c.Count;
		}

		[SpecialName]
		public double ax(int A_0)
		{
			return b[A_0];
		}

		[SpecialName]
		public double ay(int A_0)
		{
			return d[A_0];
		}

		[SpecialName]
		public double az(int A_0)
		{
			return e[A_0];
		}

		[SpecialName]
		public double a0(int A_0)
		{
			return f[A_0];
		}

		[SpecialName]
		public double a1(int A_0)
		{
			return g[A_0];
		}

		[SpecialName]
		public double a2(int A_0)
		{
			return m_c[A_0];
		}

		[SpecialName]
		public double bc()
		{
			return q;
		}

		[SpecialName]
		public double bd()
		{
			return r;
		}

		[SpecialName]
		public double be()
		{
			return s;
		}

		[SpecialName]
		public double bf()
		{
			return x;
		}

		[SpecialName]
		public void aw(double A_0)
		{
			x = A_0;
		}

		public static double aq(a A_0)
		{
			return A_0 switch
			{
				cf.a.b => 3128.0, 
				cf.a.e => 3200.0, 
				cf.a.d => 5750.5, 
				cf.a.f => 4730.0, 
				cf.a.g => 4850.0, 
				cf.a.c => 7500.0, 
				cf.a.i => 2394.0, 
				cf.a.h => 4325.0, 
				_ => 0.0, 
			};
		}

		public static double ap(a A_0)
		{
			return A_0 switch
			{
				cf.a.b => 5523.0, 
				cf.a.e => 6950.0, 
				cf.a.d => 13730.0, 
				cf.a.f => 13160.0, 
				cf.a.g => 21000.0, 
				cf.a.c => 21678.0, 
				cf.a.i => 7149.0, 
				cf.a.h => 9305.0, 
				_ => 0.0, 
			};
		}

		public void ap(double A_0, double A_1, double A_2)
		{
			q = A_0;
			r = A_1;
			s = A_2;
		}

		public void bg()
		{
			m_c.Clear();
			d.Clear();
			b.Clear();
			e.Clear();
			i.Clear();
			l.Clear();
			m.Clear();
			j.Clear();
			k.Clear();
			t.Clear();
			f.Clear();
			g.Clear();
			n.Clear();
			o.Clear();
		}

		public void ap(double A_0, double A_1, double A_2, double A_3, double A_4)
		{
			b.Add(A_0);
			d.Add(A_1);
			m_c.Add(A_2);
			e.Add(A_3 + A_4);
			f.Add(A_3);
			g.Add(A_4);
		}

		public void aq(double A_0, double A_1, double A_2)
		{
			b.Add(A_0);
			d.Add(A_1);
			m_c.Add(A_2);
		}

		public void bh()
		{
			checked
			{
				double[] array = new double[h + 1];
				jf.a(b.ToArray(), m_c.ToArray(), m_c.Count, h, array);
				i.Clear();
				int num = h;
				for (int num2 = 0; num2 <= num; num2++)
				{
					i.Add(array[num2]);
				}
			}
		}

		public void bi()
		{
			double[] array = new double[3];
			checked
			{
				int num = m_c.Count - 1;
				double[] array2 = new double[num + 1];
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					array2[num3] = 1.0 / b[num3];
				}
				jf.a(array2, m_c.ToArray(), m_c.Count, (short)2, array);
				j.Clear();
				int num4 = 0;
				do
				{
					j.Add(array[num4]);
					num4++;
				}
				while (num4 <= 2);
			}
		}

		public void bj()
		{
			double[] array = new double[4];
			checked
			{
				int num = m_c.Count - 1;
				double[] array2 = new double[num + 1];
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					array2[num3] = 1.0 / b[num3];
				}
				jf.a(array2, m_c.ToArray(), m_c.Count, (short)3, array);
				k.Clear();
				int num4 = 0;
				do
				{
					k.Add(array[num4]);
					num4++;
				}
				while (num4 <= 3);
			}
		}

		public void bk()
		{
			checked
			{
				double[] array = new double[h + 1];
				jf.a(b.ToArray(), d.ToArray(), d.Count, h, array);
				l.Clear();
				int num = h;
				for (int num2 = 0; num2 <= num; num2++)
				{
					l.Add(array[num2]);
				}
			}
		}

		public void bl()
		{
			checked
			{
				double[] array = new double[h + 1];
				double[] a_ = b.ToArray();
				m.Clear();
				n.Clear();
				o.Clear();
				jf.a(a_, e.ToArray(), e.Count, h, array);
				int num = h;
				for (int num2 = 0; num2 <= num; num2++)
				{
					m.Add(array[num2]);
				}
				if (a7())
				{
					array = new double[h + 1];
					jf.a(a_, f.ToArray(), f.Count, h, array);
					int num3 = h;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						n.Add(array[num4]);
					}
					array = new double[h + 1];
					jf.a(a_, g.ToArray(), g.Count, h, array);
					int num5 = h;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						o.Add(array[num6]);
					}
				}
			}
		}

		public double ax(double A_0)
		{
			return ap(A_0, i, h);
		}

		public double ay(double A_0)
		{
			return (ap(1.0 / A_0, j, 2) + (A_0 - q) * r) * s;
		}

		public double az(double A_0)
		{
			return (ap(1.0 / A_0, k, 3) + (A_0 - q) * r) * s;
		}

		public double a0(double A_0)
		{
			return ap(A_0, t, 2);
		}

		public double ap(double A_0, a A_1)
		{
			double num = a5(A_0);
			return Math.Atan2(x * aq(A_1), ap(A_1) + num);
		}

		public double ap(double A_0, a A_1, double A_2)
		{
			if (ar(A_1) || ba())
			{
				double num = ((!ar(A_1)) ? a0(A_2) : ap(A_0, A_1));
				double num2 = Math.Sin(num);
				return num2 * num2;
			}
			return 0.0;
		}

		public double a1(double A_0)
		{
			return ap(A_0, l, h);
		}

		public double a2(double A_0)
		{
			return ap(A_0, m, h);
		}

		public double a3(double A_0)
		{
			return ap(A_0, n, h);
		}

		public double a4(double A_0)
		{
			return ap(A_0, o, h);
		}

		private double ap(double A_0, List<double> A_1, int A_2)
		{
			double num = A_1[A_2];
			do
			{
				A_2 = checked(A_2 - 1);
				num = A_0 * num + A_1[A_2];
			}
			while (A_2 != 0);
			return num;
		}

		public double a5(double A_0)
		{
			if (az())
			{
				if (a9())
				{
					return az(A_0);
				}
				return ay(A_0);
			}
			return a6(A_0);
		}

		public double a6(double A_0)
		{
			checked
			{
				int num = bb() - 1;
				double result = double.NaN;
				if (A_0 < b[0] || A_0 > b[num])
				{
					if (a9())
					{
						return az(A_0);
					}
					if (a8())
					{
						return ay(A_0);
					}
					return result;
				}
				int num2 = num;
				for (int num3 = 1; num3 <= num2; num3++)
				{
					if ((b[num3 - 1] - A_0) * (b[num3] - A_0) <= 0.0)
					{
						if (num3 - 2 >= 0 && num3 + 1 <= num)
						{
							double num4 = Math.Abs(b[num3] - b[num3 - 1]);
							double num5 = Math.Abs(A_0 - b[num3 - 1]) / num4;
							result = (1.0 - num5) * jf.a(b[num3 - 2], m_c[num3 - 2], b[num3 - 1], m_c[num3 - 1], b[num3], m_c[num3], A_0) + num5 * jf.a(b[num3 - 1], m_c[num3 - 1], b[num3], m_c[num3], b[num3 + 1], m_c[num3 + 1], A_0);
						}
						else if (num3 - 2 >= 0)
						{
							result = jf.a(b[num3 - 2], m_c[num3 - 2], b[num3 - 1], m_c[num3 - 1], b[num3], m_c[num3], A_0);
						}
						else if (num3 + 1 <= num)
						{
							result = jf.a(b[num3 - 1], m_c[num3 - 1], b[num3], m_c[num3], b[num3 + 1], m_c[num3 + 1], A_0);
						}
						else
						{
							double num6 = (m_c[num3] - m_c[num3 - 1]) / (b[num3] - b[num3 - 1]);
							result = m_c[num3] + num6 * (A_0 - b[num3]);
						}
						result = (result + (A_0 - q) * r) * s;
						break;
					}
				}
				return result;
			}
		}

		public bool bm()
		{
			double num = a6(a);
			if (double.IsNaN(num))
			{
				return false;
			}
			i[0] -= num;
			checked
			{
				int num2 = bb() - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					m_c[num3] -= num;
				}
				return true;
			}
		}

		public void ap(BinaryWriter A_0, bool A_1)
		{
			int count = m_c.Count;
			checked
			{
				int num = count - 1;
				long position = default(long);
				if (A_1)
				{
					A_0.Write((short)1);
					A_0.Write((short)1);
				}
				else
				{
					A_0.Write((short)13);
					A_0.Write((short)13);
					position = A_0.BaseStream.Position;
					A_0.Write(position);
				}
				A_0.Write(h);
				int num2 = h;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					A_0.Write(i[num3]);
				}
				A_0.Write(count);
				int num4 = num;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					A_0.Write(b[num5]);
				}
				int num6 = num;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					A_0.Write(m_c[num7]);
				}
				int num8 = num;
				for (int num9 = 0; num9 <= num8; num9++)
				{
					A_0.Write(d[num9]);
				}
				if (A_1)
				{
					return;
				}
				A_0.Write(h);
				int num10 = h;
				for (int num11 = 0; num11 <= num10; num11++)
				{
					A_0.Write(l[num11]);
				}
				A_0.Write(h);
				int num12 = h;
				for (int num13 = 0; num13 <= num12; num13++)
				{
					A_0.Write(m[num13]);
				}
				int num14 = 0;
				do
				{
					A_0.Write(j[num14]);
					num14++;
				}
				while (num14 <= 2);
				A_0.Write(q);
				A_0.Write(r);
				A_0.Write(s);
				if (a9())
				{
					A_0.Write(value: true);
					int num15 = 0;
					do
					{
						A_0.Write(k[num15]);
						num15++;
					}
					while (num15 <= 3);
				}
				else
				{
					A_0.Write(value: false);
				}
				if (ba())
				{
					A_0.Write(value: true);
					int num16 = 0;
					do
					{
						A_0.Write(t[num16]);
						num16++;
					}
					while (num16 <= 2);
				}
				else
				{
					A_0.Write(value: false);
				}
				A_0.Write(p);
				if (a5())
				{
					A_0.Write(value: true);
					A_0.Write(h);
					int num17 = h;
					for (int num18 = 0; num18 <= num17; num18++)
					{
						A_0.Write(n[num18]);
						A_0.Write(o[num18]);
					}
				}
				else
				{
					A_0.Write(value: false);
				}
				A_0.Write(u);
				A_0.Write(v);
				A_0.Write(w);
				A_0.Write(x);
				long position2 = A_0.BaseStream.Position;
				A_0.BaseStream.Seek(position, SeekOrigin.Begin);
				A_0.Write(position2);
				A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
			}
		}

		public b ap(BinaryReader A_0, ref string A_1)
		{
			A_1 = string.Empty;
			bg();
			short num = A_0.ReadInt16();
			short num2 = A_0.ReadInt16();
			if (num2 > 13)
			{
				A_1 = "CTM calibration block compatible version is " + b3.a(num2) + ", this software version only understands calibration block versions <=" + b3.a((short)13);
				return cf.b.b;
			}
			long offset = default(long);
			if (num > 7)
			{
				offset = A_0.ReadInt64();
			}
			h = A_0.ReadInt16();
			int num3 = h;
			checked
			{
				for (int num4 = 0; num4 <= num3; num4++)
				{
					i.Add(A_0.ReadDouble());
				}
				int num5 = A_0.ReadInt32() - 1;
				int num6 = num5;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					b.Add(A_0.ReadDouble());
				}
				int num8 = num5;
				for (int num9 = 0; num9 <= num8; num9++)
				{
					m_c.Add(A_0.ReadDouble());
				}
				int num10 = num5;
				for (int num11 = 0; num11 <= num10; num11++)
				{
					d.Add(A_0.ReadDouble());
				}
				if (num > 1)
				{
					h = A_0.ReadInt16();
					int num12 = h;
					for (int num13 = 0; num13 <= num12; num13++)
					{
						l.Add(A_0.ReadDouble());
					}
					h = A_0.ReadInt16();
					int num14 = h;
					for (int num15 = 0; num15 <= num14; num15++)
					{
						m.Add(A_0.ReadDouble());
					}
				}
				if (num > 2)
				{
					int num16 = 0;
					do
					{
						j.Add(A_0.ReadDouble());
						num16++;
					}
					while (num16 <= 2);
					q = A_0.ReadDouble();
					r = A_0.ReadDouble();
					s = A_0.ReadDouble();
				}
				else
				{
					bi();
				}
				if (num > 3 && A_0.ReadBoolean())
				{
					int num17 = 0;
					do
					{
						k.Add(A_0.ReadDouble());
						num17++;
					}
					while (num17 <= 3);
				}
				if (num > 4 && A_0.ReadBoolean())
				{
					int num18 = 0;
					do
					{
						t.Add(A_0.ReadDouble());
						num18++;
					}
					while (num18 <= 2);
				}
				if (num > 5)
				{
					p = A_0.ReadBoolean();
					if (A_0.ReadBoolean())
					{
						h = A_0.ReadInt16();
						int num19 = h;
						for (int num20 = 0; num20 <= num19; num20++)
						{
							n.Add(A_0.ReadDouble());
							o.Add(A_0.ReadDouble());
						}
					}
				}
				if (num > 6)
				{
					u = A_0.ReadBoolean();
					v = A_0.ReadBoolean();
				}
				if (num > 8)
				{
					w = A_0.ReadBoolean();
					x = A_0.ReadDouble();
				}
				if (num > 7)
				{
					A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
				}
				return cf.b.a;
			}
		}

		public c()
		{
			b = new List<double>();
			m_c = new List<double>();
			d = new List<double>();
			e = new List<double>();
			f = new List<double>();
			g = new List<double>();
			i = new List<double>();
			j = new List<double>();
			k = new List<double>();
			l = new List<double>();
			m = new List<double>();
			n = new List<double>();
			o = new List<double>();
			t = new List<double>();
			a = 450.0;
			h = 5;
			q = 450.0;
			r = 0.0;
			s = 1.0;
			p = false;
			u = true;
			v = false;
			w = false;
			x = 1.0;
		}
	}

	private string m_a;

	private a m_b;

	private c m_c;

	private bool d;

	private double e;

	private double f;

	private DateTime g;

	public const string h = "CTM_";

	public const string i = ".fictm";

	public const string j = "Filmetrics CTM Files (*.fictm)|*.fictm";

	public const double k = 450.0;

	public const double l = 920.0;

	public const double m = 930.0;

	public const double n = 1750.0;

	public const double o = 427.0;

	public const double p = 710.0;

	private const short m_q = 4;

	private const double m_r = 500.0;

	public const double s = 800.0;

	private const double m_t = 1050.0;

	public const double u = 1500.0;

	private const string m_v = "Unknown";

	private const string m_w = "VIS-0.1mm";

	private const string x = "VIS-0.4mm";

	private const string y = "NIR-0.6mm";

	private const string z = "VIS-1mm Prototype";

	private const string aa = "VIS-0.3mm";

	private const string ab = "VIS-1mm";

	private const string ac = "VIS-2.4mm";

	private const string ad = "VIS-9mm";

	private const string ae = "NIR-0.4mm";

	private const string af = "VIS-1mm RevB";

	public static string l()
	{
		return "\\Optics\\";
	}

	public static bool l(double[] A_0, double[] A_1, int A_2, double A_3, bool A_4, ref double A_5, ref double A_6, ref double A_7, ref double A_8)
	{
		checked
		{
			int num = A_0.Length - 1;
			List<double> list = new List<double>();
			List<double> list2 = new List<double>();
			A_5 = 0.0;
			A_6 = 0.0;
			A_7 = 0.0;
			A_8 = 0.0;
			int num2 = A_2;
			do
			{
				num2--;
			}
			while (num2 >= 0 && !(A_1[num2] < A_3));
			int num3 = num2 + 1;
			if (num2 >= 0 || A_4)
			{
				if (num2 >= 0)
				{
					double num4 = (A_1[num3] - A_1[num2]) / (A_0[num3] - A_0[num2]);
					A_7 = A_0[num3] + (A_3 - A_1[num3]) / num4;
				}
				else
				{
					A_7 = A_0[num3];
				}
				list.Add(A_7);
				list2.Add(0.0);
				if (num2 >= 0)
				{
					list.Add(A_7);
					list2.Add(A_3);
				}
				num2 = A_2;
				do
				{
					num2++;
				}
				while (num2 <= num && !(A_1[num2] < A_3));
				int num5 = num2 - 1;
				if (num2 <= num || A_4)
				{
					int num6 = num5;
					for (int num7 = num3; num7 <= num6; num7++)
					{
						list.Add(A_0[num7]);
						list2.Add(A_1[num7]);
					}
					if (num2 <= num)
					{
						double num4 = (A_1[num5] - A_1[num2]) / (A_0[num5] - A_0[num2]);
						A_8 = A_0[num5] + (A_3 - A_1[num5]) / num4;
					}
					else
					{
						A_8 = A_0[num5];
					}
					A_6 = A_8 - A_7;
					if (num2 <= num)
					{
						list.Add(A_8);
						list2.Add(A_3);
					}
					list.Add(A_8);
					list2.Add(0.0);
					list.Add(A_7);
					list2.Add(0.0);
					int num8 = list.Count - 2;
					double num9 = 0.0;
					int num10 = num8;
					for (int num11 = 0; num11 <= num10; num11++)
					{
						double num12 = list[num11 + 1] * list2[num11] - list[num11] * list2[num11 + 1];
						num9 += num12;
						A_5 += (list[num11] + list[num11 + 1]) * num12;
					}
					num9 /= 2.0;
					A_5 /= 6.0 * num9;
					return true;
				}
			}
			return false;
		}
	}

	private static void l(int A_0, int[] A_1, int[] A_2, List<int> A_3, ref Collection<int[]> A_4)
	{
		A_4 = new Collection<int[]>();
		checked
		{
			int num = A_0 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				int num3 = A_2[A_1[num2]];
				int[] item = new int[2]
				{
					A_3[num3],
					A_3[num3 + 1]
				};
				A_4.Add(item);
			}
		}
	}

	private static bool l(int A_0, Collection<int[]> A_1)
	{
		foreach (int[] item in A_1)
		{
			if (A_0 >= item[0] && A_0 <= item[1])
			{
				return true;
			}
		}
		return false;
	}

	public static void l(double[] A_0, double[] A_1, int A_2, List<int> A_3, ref double[] A_4, ref double[] A_5, ref double[] A_6, ref double[] A_7, ref double A_8, ref double A_9, ref bool A_10)
	{
		List<int> A_11 = new List<int>();
		List<int> A_12 = new List<int>();
		List<double> A_13 = new List<double>();
		double num = double.MinValue;
		A_9 = double.MaxValue;
		checked
		{
			_ = A_2 * 2 + 1 - 1;
			jf.a(A_1, 0.0, A_3, ref A_11, ref A_12, ref A_13);
			int num2 = A_1.Length - 1;
			int num3 = num2;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				if (A_1[num4] > num)
				{
					num = A_1[num4];
				}
				if (A_1[num4] < A_9)
				{
					A_9 = A_1[num4];
				}
			}
			double num5 = 0.0;
			double num6 = num;
			double num7 = (num6 - num5) / 2.0;
			int num8 = 0;
			double num9 = num6;
			double num10 = num5;
			bool flag = false;
			int count = A_13.Count;
			do
			{
				jf.a(A_1, num7, A_3, ref A_11, ref A_12, ref A_13);
				num8++;
				flag = A_11.Count == A_2 || num8 >= 20;
				if (flag)
				{
					continue;
				}
				if (count < A_2)
				{
					if (A_11.Count < A_2)
					{
						num9 = num7;
					}
					else
					{
						num10 = num7;
					}
				}
				else if (A_11.Count > A_2)
				{
					num10 = num7;
				}
				else
				{
					num9 = num7;
				}
				count = A_11.Count;
				num7 = ((A_11.Count >= A_2) ? ((num9 + num7) / 2.0) : ((num7 + num10) / 2.0));
			}
			while (!flag);
			double[] array = new double[A_13.Count - 1 + 1];
			int num11 = A_13.Count - 1;
			for (int num12 = 0; num12 <= num11; num12++)
			{
				array[num12] = A_13[num12] - (A_1[A_12[num12]] + A_1[A_12[num12 + 1]]) / 2.0;
			}
			double[] array2 = new double[array.Length - 1 + 1];
			array.CopyTo(array2, 0);
			int[] array3 = new int[array.Length - 1 + 1];
			int num13 = array.Length - 1;
			for (int num14 = 0; num14 <= num13; num14++)
			{
				array3[num14] = num14;
			}
			Array.Sort(array2, array3);
			Array.Reverse(array2);
			Array.Reverse(array3);
			int num15 = 0;
			int num16 = ((A_11.Count < A_2) ? (A_11.Count - 1) : (A_2 - 1));
			double[] array4 = new double[num16 + 1];
			double[] array5 = new double[num16 + 1];
			double[] array6 = new double[num16 + 1];
			double[] array7 = new double[num16 + 1];
			double[] array8 = new double[num16 + 1];
			int[] array9 = new int[num16 + 1];
			int[] array10 = new int[num16 + 1];
			int num17 = num16;
			double A_16 = default(double);
			double A_17 = default(double);
			for (int num18 = 0; num18 <= num17; num18++)
			{
				int num19 = array3[num18];
				int num20 = A_11[num19];
				double num21 = Math.Max(A_1[A_12[num19]], A_1[A_12[num19 + 1]]);
				double num22 = 0.5 * (A_1[A_12[num19]] + A_1[A_12[num19 + 1]]);
				double num23 = A_1[num20] - num21;
				double num24 = Math.Max(0.5 * num23, 0.5 * num7);
				double a_ = num21 + num24;
				double A_14 = 0.0;
				double A_15 = 0.0;
				if (l(A_0, A_1, num20, a_, A_4: false, ref A_16, ref A_17, ref A_14, ref A_15))
				{
					array6[num18] = A_1[num20] - num22;
					array4[num18] = array6[num18] * A_17;
					array5[num18] = A_16;
					array7[num18] = A_17;
					array8[num18] = num23 * 0.75;
					array9[num18] = num18;
					array10[num18] = num19;
				}
			}
			num7 = 2.0 * array4[num16];
			if (num16 + 1 > A_2)
			{
				int num25 = A_2 - 1;
				for (int num26 = 0; num26 <= num25 && array4[num26] > num7; num26++)
				{
					num15++;
					array9[num26] = num26;
				}
				if (num15 == A_2)
				{
					num7 = array4[A_2 - 1] / 2.0;
					int num27 = num16 - 1;
					for (int num28 = A_2; num28 <= num27 && array4[num28] > num7; num28++)
					{
						num15++;
						array9[num28] = num28;
					}
				}
			}
			else
			{
				num15 = num16 + 1;
			}
			if (num15 > A_2)
			{
				num15 = A_2;
				A_10 = true;
			}
			int num29 = num15 - 1;
			A_4 = new double[num29 + 1];
			A_5 = new double[num29 + 1];
			A_7 = new double[num29 + 1];
			A_6 = new double[num29 + 1];
			int num30 = num29;
			for (int num31 = 0; num31 <= num30; num31++)
			{
				A_4[num31] = array5[array9[num31]];
				A_5[num31] = array6[array9[num31]];
				A_7[num31] = array7[array9[num31]];
				A_6[num31] = array8[array9[num31]];
			}
			A_8 = 0.0;
			int num32 = 0;
			Collection<int[]> A_18 = null;
			l(num15, array9, array10, A_12, ref A_18);
			int num33 = num2;
			for (int num34 = 0; num34 <= num33; num34++)
			{
				if (!l(num34, A_18))
				{
					A_8 += A_1[num34];
					num32++;
				}
			}
			if (num32 > 1)
			{
				A_8 /= num32;
			}
			else
			{
				A_8 = Math.Min(A_1[0], A_1[num2]);
			}
			if (Math.Abs(A_8) < 1E-06)
			{
				A_8 = 1E-06 * A_8 / Math.Abs(A_8);
			}
			double[] array11 = new double[A_4.Length - 1 + 1];
			double[] array12 = new double[A_4.Length - 1 + 1];
			A_4.CopyTo(array11, 0);
			A_4.CopyTo(array12, 0);
			Array.Sort(A_4, A_5);
			Array.Sort(array11, A_7);
			Array.Sort(array12, A_6);
		}
	}

	public static void l(double[] A_0, double[] A_1, int A_2, ref double[] A_3, ref double[] A_4)
	{
		checked
		{
			int num = A_0.Length - 1;
			double num2 = double.MaxValue;
			double num3 = double.MinValue;
			List<int> list = new List<int>();
			List<double> list2 = new List<double>();
			int num4 = 0;
			new List<double>();
			new List<double>();
			int num5 = -1;
			int num6 = A_2 * 2 - 1;
			int num7 = 1;
			do
			{
				if (A_1[num7] > A_1[num7 - 1] && A_1[num7] > A_1[num7 + 1])
				{
					if (A_1[num7] > num3)
					{
						num3 = A_1[num7];
					}
					if (A_1[num7] < num2)
					{
						num2 = A_1[num7];
					}
					if (list.Count > 0)
					{
						num5 = list[list.Count - 1];
					}
					if (list.Count > 0 && num7 - num5 < 3)
					{
						if (A_1[num7] > A_1[num5])
						{
							list2.RemoveAt(list.Count - 1);
							list.RemoveAt(list.Count - 1);
							list.Add(num7);
							list2.Add(A_1[num7]);
							num7 += 2;
						}
						else
						{
							num7++;
						}
					}
					else
					{
						list.Add(num7);
						list2.Add(A_1[num7]);
						num7 += 2;
					}
				}
				else
				{
					num7++;
				}
			}
			while (num7 < num);
			double num8 = num3 - num2;
			int[] array = list.ToArray();
			Array.Sort(list2.ToArray(), array);
			Array.Reverse(array);
			List<int> list3 = new List<int>();
			int num9 = array.Length - 1;
			bool flag = false;
			int num10 = num9;
			int num13 = default(int);
			int num14 = default(int);
			int item = default(int);
			double num17 = default(double);
			for (int num11 = 0; num11 <= num10; num11++)
			{
				int num12 = array[num11];
				if (!flag || num12 > num13 || num12 < num14)
				{
					double num15 = double.MinValue;
					flag = false;
					int num16 = num12;
					do
					{
						if (A_1[num16] > num15)
						{
							item = num16;
							num15 = A_1[num16];
							num17 = (num15 - num2) * 0.75;
						}
						num16--;
					}
					while (num16 >= 0 && !(A_1[num16] < num17));
					if (num16 >= 0)
					{
						num14 = num16 + 1;
						num16 = num12;
						do
						{
							if (A_1[num16] > num15)
							{
								item = num16;
								num15 = A_1[num16];
								num17 = (num15 - num2) * 0.75;
							}
							num16++;
						}
						while (num16 <= num && !(A_1[num16] < num17));
						if (num16 <= num)
						{
							num13 = num16 - 1;
							if (list3.IndexOf(item) < 0)
							{
								list3.Add(item);
							}
							flag = true;
						}
						else
						{
							flag = false;
						}
					}
				}
				if (list3.Count > num6)
				{
					break;
				}
			}
			if (list3.Count <= num6)
			{
				num4 = ((list3.Count < A_2) ? list3.Count : A_2);
			}
			else
			{
				int num18 = A_2 - 1;
				for (int num19 = 0; num19 <= num18; num19++)
				{
					if (A_1[list3[num19]] - num2 > 2.5 * (A_1[list3[num6]] - num2) && A_1[list3[num19]] - num2 > num8 * 0.05)
					{
						num4++;
					}
				}
			}
			int num20 = num4 - 1;
			A_3 = new double[num20 + 1];
			A_4 = new double[num20 + 1];
			int num21 = num20;
			double A_8 = default(double);
			for (int num22 = 0; num22 <= num21; num22++)
			{
				int num23 = list3[num22];
				double a_ = 0.65 * A_1[num23];
				double A_5 = 0.0;
				double A_6 = 0.0;
				double A_7 = 0.0;
				if (l(A_0, A_1, num23, a_, A_4: false, ref A_8, ref A_5, ref A_6, ref A_7))
				{
					A_3[num22] = A_8;
					A_4[num22] = A_1[num23];
				}
			}
			Array.Sort(A_3, A_4);
		}
	}

	[SpecialName]
	public string m()
	{
		return "CTM_" + this.m_a + ".fictm";
	}

	[SpecialName]
	public string n()
	{
		return this.m_a;
	}

	[SpecialName]
	public void m(string A_0)
	{
		this.m_a = A_0;
	}

	[SpecialName]
	public a o()
	{
		return this.m_b;
	}

	[SpecialName]
	public void m(a A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	public bool p()
	{
		return d;
	}

	[SpecialName]
	public void l(bool A_0)
	{
		d = A_0;
	}

	[SpecialName]
	public double q()
	{
		return e;
	}

	[SpecialName]
	public void l(double A_0)
	{
		e = A_0;
	}

	[SpecialName]
	public double r()
	{
		return f;
	}

	[SpecialName]
	public void m(double A_0)
	{
		f = A_0;
	}

	[SpecialName]
	public DateTime s()
	{
		return g;
	}

	[SpecialName]
	public void l(DateTime A_0)
	{
		g = A_0;
	}

	[SpecialName]
	public bool t()
	{
		if (this.m_b != cf.a.h)
		{
			return this.m_b == cf.a.c;
		}
		return true;
	}

	[SpecialName]
	public double u()
	{
		if (t())
		{
			return 1050.0;
		}
		return 500.0;
	}

	[SpecialName]
	public double v()
	{
		if (t())
		{
			return 1500.0;
		}
		return 800.0;
	}

	public static string l(a A_0)
	{
		return A_0 switch
		{
			cf.a.a => "Unknown", 
			cf.a.b => "VIS-0.1mm", 
			cf.a.c => "NIR-0.6mm", 
			cf.a.d => "VIS-1mm", 
			cf.a.e => "VIS-0.3mm", 
			cf.a.f => "VIS-2.4mm", 
			cf.a.g => "VIS-9mm", 
			cf.a.h => "NIR-0.4mm", 
			cf.a.i => "VIS-1mm RevB", 
			_ => "Unknown", 
		};
	}

	public static a l(string A_0)
	{
		uint num = jo.a(A_0);
		if (num <= 2674886674u)
		{
			if (num <= 1466936023)
			{
				switch (num)
				{
				case 1466936023u:
					if (Operators.CompareString(A_0, "VIS-0.1mm", TextCompare: false) != 0)
					{
						break;
					}
					return cf.a.b;
				case 840213873u:
					if (Operators.CompareString(A_0, "VIS-9mm", TextCompare: false) != 0)
					{
						break;
					}
					return cf.a.g;
				}
			}
			else if (num != 1529166911)
			{
				switch (num)
				{
				case 1766744806u:
					if (Operators.CompareString(A_0, "VIS-2.4mm", TextCompare: false) != 0)
					{
						break;
					}
					return cf.a.f;
				case 2674886674u:
					if (Operators.CompareString(A_0, "VIS-1mm RevB", TextCompare: false) != 0)
					{
						break;
					}
					return cf.a.i;
				}
			}
			else if (Operators.CompareString(A_0, "VIS-1mm Prototype", TextCompare: false) == 0)
			{
				goto IL_015b;
			}
		}
		else if (num <= 3100823081u)
		{
			if (num != 2724749129u)
			{
				if (num == 3100823081u && Operators.CompareString(A_0, "VIS-1mm", TextCompare: false) == 0)
				{
					goto IL_015b;
				}
			}
			else if (Operators.CompareString(A_0, "VIS-0.3mm", TextCompare: false) == 0)
			{
				return cf.a.e;
			}
		}
		else
		{
			switch (num)
			{
			case 3424652889u:
				if (Operators.CompareString(A_0, "Unknown", TextCompare: false) != 0)
				{
					break;
				}
				return cf.a.a;
			case 3907690349u:
				if (Operators.CompareString(A_0, "NIR-0.6mm", TextCompare: false) != 0)
				{
					break;
				}
				return cf.a.c;
			case 3191880763u:
				if (Operators.CompareString(A_0, "NIR-0.4mm", TextCompare: false) != 0)
				{
					break;
				}
				return cf.a.h;
			}
		}
		return cf.a.a;
		IL_015b:
		return cf.a.d;
	}

	[SpecialName]
	public c w()
	{
		return this.m_c;
	}

	[SpecialName]
	public void l(c A_0)
	{
		this.m_c = A_0;
	}

	public void n(string A_0)
	{
		BinaryWriter binaryWriter = new BinaryWriter(File.Open(A_0, FileMode.Create));
		try
		{
			l(binaryWriter);
		}
		finally
		{
			binaryWriter.Close();
		}
	}

	public b l(string A_0, ref string A_1)
	{
		BinaryReader binaryReader = new BinaryReader(File.Open(A_0, FileMode.Open));
		try
		{
			return l(binaryReader, ref A_1);
		}
		finally
		{
			binaryReader.Close();
		}
	}

	public void l(BinaryWriter A_0)
	{
		l(A_0, 4, A_2: false);
	}

	public void l(BinaryWriter A_0, short A_1, bool A_2)
	{
		if (A_1 < 4)
		{
			A_0.Write(A_1);
			if (A_1 <= 4)
			{
				A_0.Write(A_1);
			}
			else
			{
				A_0.Write((short)4);
			}
		}
		else
		{
			A_0.Write((short)4);
			A_0.Write((short)4);
		}
		long position = A_0.BaseStream.Position;
		A_0.Write(position);
		A_0.Write(this.m_a);
		A_0.Write(l(this.m_b));
		this.m_c.ap(A_0, A_2);
		if (A_1 > 1)
		{
			A_0.Write(d);
			A_0.Write(e);
			A_0.Write(f);
			A_0.Write(checked((short)this.m_b));
			A_0.Write(g.ToOADate());
		}
		long position2 = A_0.BaseStream.Position;
		A_0.BaseStream.Seek(position, SeekOrigin.Begin);
		A_0.Write(position2);
		A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
	}

	public b l(BinaryReader A_0, ref string A_1)
	{
		A_1 = string.Empty;
		g = DateTime.FromOADate(0.0);
		short num = A_0.ReadInt16();
		short num2 = A_0.ReadInt16();
		long offset = A_0.ReadInt64();
		if (num2 > 4)
		{
			A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
			A_1 = "CTM binary file compatible version is " + b3.a(num2) + ", this software version only understands file versions <=" + b3.a((short)4);
			return cf.b.b;
		}
		this.m_a = A_0.ReadString();
		string a_ = A_0.ReadString();
		if (this.m_c.ap(A_0, ref A_1) == cf.b.b)
		{
			A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
			return cf.b.b;
		}
		if (num > 1)
		{
			d = A_0.ReadBoolean();
			e = A_0.ReadDouble();
			f = A_0.ReadDouble();
			this.m_b = (a)A_0.ReadInt16();
			if (num > 2)
			{
				g = DateTime.FromOADate(A_0.ReadDouble());
			}
		}
		else
		{
			this.m_b = l(a_);
		}
		A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
		return cf.b.a;
	}

	public void l(cf A_0)
	{
		cf cf2 = A_0;
		cf2.m(n());
		cf2.m(o());
		cf2.w().ap(w().ap());
		cf2.w().ap(w().aq());
		cf2.w().bg();
		checked
		{
			int num = w().bb() - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				cf2.w().aq(w().ax(num2), w().ay(num2), w().a2(num2));
			}
			cf2.w().bh();
			cf2.w().bk();
			if (w().a4())
			{
				int num3 = w().ax() - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					cf2.w().ar(w().at(num4));
				}
			}
			cf2.w().ap(w().ay());
			if (w().a5())
			{
				int num5 = w().a2() - 1;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					cf2.w().@as(w().au(num6));
				}
				int num7 = w().a3() - 1;
				for (int num8 = 0; num8 <= num7; num8++)
				{
					cf2.w().at(w().av(num8));
				}
			}
			cf2.w().bi();
			if (w().a9())
			{
				int num9 = w().at() - 1;
				for (int num10 = 0; num10 <= num9; num10++)
				{
					cf2.w().au(w().ar(num10));
				}
			}
			cf2.w().ap(w().bc(), w().bd(), w().be());
			if (w().ba())
			{
				int num11 = w().av() - 1;
				for (int num12 = 0; num12 <= num11; num12++)
				{
					cf2.w().av(w().aw(num12));
				}
			}
			cf2.w().aq(w().az());
			cf2.w().ar(w().a0());
			cf2.w().@as(w().a1());
			cf2.w().aw(w().bf());
			cf2.l(p());
			cf2.l(q());
			cf2.m(r());
			cf2.l(s());
			cf2 = null;
		}
	}

	[SpecialName]
	public static bool n(cf A_0, cf A_1)
	{
		switch (ix.a(A_0, A_1))
		{
		case ix.a.a:
			return false;
		case ix.a.b:
			return true;
		default:
		{
			cf cf2 = A_0;
			if (Operators.CompareString(cf2.n(), A_1.n(), TextCompare: false) != 0)
			{
				return true;
			}
			if (cf2.o() != A_1.o())
			{
				return true;
			}
			if (cf2.p() != A_1.p())
			{
				return true;
			}
			if (!jf.e(cf2.q(), A_1.q()))
			{
				return true;
			}
			if (!jf.e(cf2.r(), A_1.r()))
			{
				return true;
			}
			if (cf.c.aq(cf2.w(), A_1.w()))
			{
				return true;
			}
			if (DateTime.Compare(cf2.s(), A_1.s()) != 0)
			{
				return true;
			}
			cf2 = null;
			return false;
		}
		}
	}

	public static bool m(cf A_0, cf A_1)
	{
		return Operators.CompareString(A_0.n(), A_1.n(), TextCompare: false) != 0;
	}

	[SpecialName]
	public static bool l(cf A_0, cf A_1)
	{
		return !n(A_0, A_1);
	}

	public bool m(cf A_0)
	{
		return l(this, A_0);
	}

	public cf()
	{
		this.m_c = new c();
		l("Unknown", cf.a.a);
	}

	public cf(string A_0, a A_1)
	{
		this.m_c = new c();
		l(A_0, A_1);
	}

	private void l(string A_0, a A_1)
	{
		this.m_a = A_0;
		this.m_b = A_1;
		if (t())
		{
			l(930.0);
			m(1750.0);
		}
		else
		{
			l(450.0);
			m(920.0);
		}
		d = false;
	}
}
