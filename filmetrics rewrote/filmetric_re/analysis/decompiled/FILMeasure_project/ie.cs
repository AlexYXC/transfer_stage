using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

internal class ie
{
	private h9 a;

	private int b;

	private ushort c;

	private float m_d;

	private ushort[] m_e;

	private ushort m_f;

	private float m_g;

	private float m_h;

	private float m_i;

	private float j;

	private float k;

	private double[] l;

	private float m;

	private float n;

	private byte o;

	private byte p;

	private string q;

	private ushort r;

	private ushort s;

	private ushort t;

	private ushort[] u;

	private const byte v = 3;

	private const double w = 3E-07;

	public const double x = 420.0;

	public const double y = 450.0;

	public void d(BinaryWriter A_0)
	{
		A_0.Write((byte)3);
		A_0.Write((byte)1);
		A_0.Write(this.m_g);
		A_0.Write(this.m_h);
		A_0.Write(this.m_i);
		A_0.Write(o);
		A_0.Write(p);
		A_0.Write(Encoding.ASCII.GetBytes(q));
		A_0.Write(m);
		A_0.Write(n);
		A_0.Write(c);
		A_0.Write(this.m_f);
		A_0.Write(this.m_d);
		checked
		{
			int num = c - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				A_0.Write(this.m_e[num2]);
			}
			A_0.Write(r);
			if (r > 0)
			{
				A_0.Write(s);
				A_0.Write(t);
				int num3 = s - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					A_0.Write(u[num4]);
				}
			}
			A_0.Write(j);
			A_0.Write(k);
		}
	}

	public void d(byte[] A_0)
	{
		MemoryStream input = new MemoryStream(A_0);
		BinaryReader a_ = new BinaryReader(input);
		string A_1 = null;
		d(a_, ref A_1);
	}

	public h7 d(BinaryReader A_0, ref string A_1)
	{
		byte b10 = A_0.ReadByte();
		byte b11 = A_0.ReadByte();
		A_1 = null;
		if ((uint)b11 > 3u)
		{
			A_1 = "SpecSplineInterpArray firmware compatible version is " + b11 + ", this software version only understands file versions <=" + (byte)3;
			return h7.b;
		}
		this.m_g = A_0.ReadSingle();
		this.m_h = A_0.ReadSingle();
		this.m_i = A_0.ReadSingle();
		o = A_0.ReadByte();
		p = A_0.ReadByte();
		byte[] bytes = A_0.ReadBytes(p);
		q = new string(Encoding.ASCII.GetChars(bytes));
		m = A_0.ReadSingle();
		n = A_0.ReadSingle();
		c = A_0.ReadUInt16();
		this.m_f = A_0.ReadUInt16();
		this.m_d = A_0.ReadSingle();
		checked
		{
			this.m_e = new ushort[c - 1 + 1];
			int num = c - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				this.m_e[num2] = A_0.ReadUInt16();
			}
			if (b10 > 1)
			{
				r = A_0.ReadUInt16();
				if (r > 0)
				{
					s = A_0.ReadUInt16();
					t = A_0.ReadUInt16();
					u = new ushort[s - 1 + 1];
					int num3 = s - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						u[num4] = A_0.ReadUInt16();
					}
				}
			}
			else
			{
				r = 0;
			}
			if (b10 > 2)
			{
				j = A_0.ReadSingle();
				k = A_0.ReadSingle();
			}
			d();
			return h7.a;
		}
	}

	[SpecialName]
	public string e()
	{
		return a switch
		{
			h9.a => string.Empty, 
			h9.b => Conversions.ToString(o), 
			_ => string.Empty, 
		};
	}

	[SpecialName]
	public h9 f()
	{
		return a;
	}

	[SpecialName]
	public string g()
	{
		return q;
	}

	public double[] h()
	{
		checked
		{
			double[] array = new double[c - 1 + 1];
			double[] array2 = new double[c - 1 + 1];
			int num = b - 1;
			double[] A_ = null;
			double num2 = 65535f / this.m_d;
			int num3 = c - 2;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				array2[num4] = l[num4 * this.m_f];
				array[num4] = (double)unchecked((int)this.m_e[num4]) / num2;
			}
			array2[c - 1] = l[num];
			array[c - 1] = (double)unchecked((int)this.m_e[checked(c - 1)]) / num2;
			double[] A_2 = new double[c - 1 + 1];
			jf.a(array2, array, c, m, n, ref A_2);
			jf.a(array2, array, A_2, c, l, ref A_, b);
			if (r > 0)
			{
				double[] array3 = iy.a(r, num2, s, t, u);
				double num5 = 30.0;
				int num6 = r - 1;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					double num8 = ((!(l[num7] < 420.0)) ? ((450.0 - l[num7]) / num5) : 1.0);
					A_[num7] = num8 * array3[num7] + (1.0 - num8) * A_[num7];
				}
			}
			int num9 = num;
			for (int num10 = 0; num10 <= num9; num10++)
			{
				if (A_[num10] < 3E-07)
				{
					A_[num10] = 3E-07;
				}
			}
			return A_;
		}
	}

	private void d()
	{
		checked
		{
			int num = b - 1;
			if (l == null || l.Length != b)
			{
				l = new double[num + 1];
			}
			if (j == 0f && k == 0f)
			{
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					l[num3] = this.m_g + (this.m_h + this.m_i * (float)num3) * (float)num3;
				}
			}
			else
			{
				int num4 = num;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					l[num5] = (double)this.m_g + ((double)this.m_h + ((double)this.m_i + ((double)j + (double)k * (double)num5) * (double)num5) * (double)num5) * (double)num5;
				}
			}
		}
	}

	public double[] i()
	{
		return l;
	}

	public ie(h9 A_0, int A_1)
	{
		a = A_0;
		b = A_1;
	}

	public ie(h9 A_0, g2.OpticsConfigSubmoduleTypes A_1, string A_2, float A_3, float A_4, float A_5, float A_6, float A_7, double[] A_8, int A_9, int A_10, double A_11, double A_12, int A_13, int A_14)
	{
		a = A_0;
		checked
		{
			o = (byte)A_1;
			if (string.IsNullOrEmpty(A_2))
			{
				q = string.Empty;
				p = 0;
			}
			else
			{
				q = A_2;
				p = (byte)A_2.Length;
			}
			this.m_f = (ushort)A_10;
			b = A_9;
			this.m_g = A_3;
			this.m_h = A_4;
			this.m_i = A_5;
			j = A_6;
			k = A_7;
			m = (float)A_11;
			n = (float)A_12;
			int num = b - 1;
			c = (ushort)(unchecked(checked(b + this.m_f - 2) / this.m_f) + 1);
			this.m_e = new ushort[c - 1 + 1];
			this.m_d = float.MinValue;
			d();
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (A_8[num3] < 3E-07)
				{
					A_8[num3] = 3E-07;
				}
				if (A_8[num3] > (double)this.m_d)
				{
					this.m_d = (float)A_8[num3];
				}
			}
			double num4 = 65535f / this.m_d;
			int num5 = c - 2;
			for (int num6 = 0; num6 <= num5; num6++)
			{
				this.m_e[num6] = (ushort)Math.Round(num4 * A_8[num6 * this.m_f]);
			}
			this.m_e[c - 1] = (ushort)Math.Round(num4 * A_8[num]);
			r = (ushort)A_13;
			if (r > 0)
			{
				t = (ushort)A_14;
				iy.a(r, A_8, t, num4, ref s, ref u);
			}
		}
	}
}
