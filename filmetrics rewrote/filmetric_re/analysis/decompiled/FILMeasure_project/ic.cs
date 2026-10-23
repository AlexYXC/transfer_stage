using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class ic
{
	private byte a;

	private byte m_b;

	private float c;

	private float d;

	private float e;

	private ushort f;

	private float[] g;

	private float[] h;

	private byte i;

	private float[] j;

	private float[] k;

	private byte l;

	private float[] m;

	private float n;

	private float o;

	private float p;

	private byte q;

	private float[] r;

	private byte s;

	private byte t;

	private float[] u;

	private float[] v;

	private byte w;

	private byte x;

	private byte y;

	private float z;

	private const byte aa = 5;

	public void b(BinaryWriter A_0)
	{
		checked
		{
			int num = f - 1;
			A_0.Write((byte)5);
			A_0.Write((byte)5);
			A_0.Write(a);
			A_0.Write(this.m_b);
			A_0.Write(c);
			A_0.Write(d);
			A_0.Write(f);
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				A_0.Write(g[num3]);
			}
			int num4 = num;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				A_0.Write(h[num5]);
			}
			A_0.Write(i);
			int num6 = i;
			for (int num7 = 0; num7 <= num6; num7++)
			{
				A_0.Write(j[num7]);
			}
			int num8 = i;
			for (int num9 = 0; num9 <= num8; num9++)
			{
				A_0.Write(k[num9]);
			}
			A_0.Write(l);
			int num10 = l;
			for (int num11 = 0; num11 <= num10; num11++)
			{
				A_0.Write(m[num11]);
			}
			A_0.Write(n);
			A_0.Write(o);
			A_0.Write(p);
			A_0.Write(q);
			if (q > 0)
			{
				int num12 = q;
				for (int num13 = 0; num13 <= num12; num13++)
				{
					A_0.Write(r[num13]);
				}
			}
			A_0.Write(s);
			A_0.Write(t);
			if (t != 0)
			{
				int num14 = i;
				for (int num15 = 0; num15 <= num14; num15++)
				{
					A_0.Write(u[num15]);
					A_0.Write(v[num15]);
				}
			}
			A_0.Write(w);
			A_0.Write(x);
			A_0.Write(y);
			A_0.Write(z);
		}
	}

	public h7 b(byte[] A_0, ref string A_1)
	{
		MemoryStream input = new MemoryStream(A_0);
		BinaryReader a_ = new BinaryReader(input);
		return b(a_, ref A_1);
	}

	public h7 b(BinaryReader A_0, ref string A_1)
	{
		byte b10 = A_0.ReadByte();
		byte b11 = A_0.ReadByte();
		A_1 = null;
		if ((uint)b11 > 5u)
		{
			A_1 = "CTM firmware compatible version is " + b11 + ", this software version only understands file versions <=" + (byte)5;
			return h7.b;
		}
		a = A_0.ReadByte();
		this.m_b = A_0.ReadByte();
		c = A_0.ReadSingle();
		d = A_0.ReadSingle();
		f = A_0.ReadUInt16();
		checked
		{
			int num = f - 1;
			g = new float[num + 1];
			h = new float[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				g[num3] = A_0.ReadSingle();
			}
			int num4 = num;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				h[num5] = A_0.ReadSingle();
			}
			i = A_0.ReadByte();
			j = new float[i + 1];
			k = new float[i + 1];
			int num6 = i;
			for (int num7 = 0; num7 <= num6; num7++)
			{
				j[num7] = A_0.ReadSingle();
			}
			int num8 = i;
			for (int num9 = 0; num9 <= num8; num9++)
			{
				k[num9] = A_0.ReadSingle();
			}
			l = A_0.ReadByte();
			m = new float[l + 1];
			int num10 = l;
			for (int num11 = 0; num11 <= num10; num11++)
			{
				m[num11] = A_0.ReadSingle();
			}
			n = A_0.ReadSingle();
			o = A_0.ReadSingle();
			p = A_0.ReadSingle();
			if (b10 > 1)
			{
				q = A_0.ReadByte();
				if (q > 0)
				{
					r = new float[q + 1];
					int num12 = q;
					for (int num13 = 0; num13 <= num12; num13++)
					{
						r[num13] = A_0.ReadSingle();
					}
				}
			}
			if (b10 > 2)
			{
				s = A_0.ReadByte();
				t = A_0.ReadByte();
				if (t != 0)
				{
					u = new float[i + 1];
					v = new float[i + 1];
					int num14 = i;
					for (int num15 = 0; num15 <= num14; num15++)
					{
						u[num15] = A_0.ReadSingle();
						v[num15] = A_0.ReadSingle();
					}
				}
			}
			if (b10 > 3)
			{
				w = A_0.ReadByte();
				x = A_0.ReadByte();
			}
			if (b10 > 4)
			{
				y = A_0.ReadByte();
				z = A_0.ReadSingle();
			}
			return h7.a;
		}
	}

	[SpecialName]
	public cf b(string A_0, DateTime A_1)
	{
		cf cf2 = new cf(A_0, (cf.a)a);
		cf2.l(A_1);
		cf2.l(c);
		cf2.m(d);
		cf2.l(this.m_b != 0);
		cf2.w().bg();
		checked
		{
			int num = f - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				cf2.w().aq(h[num2], 0.0, g[num2]);
			}
			cf2.w().bh();
			if (i == cf2.w().aq())
			{
				int num3 = i;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					cf2.w().ar(k[num4]);
					cf2.w().aq(j[num4]);
				}
				cf2.w().bi();
			}
			cf2.w().ap(n, o, p);
			int num5 = l;
			for (int num6 = 0; num6 <= num5; num6++)
			{
				cf2.w().au(m[num6]);
			}
			if (q > 0)
			{
				int num7 = q;
				for (int num8 = 0; num8 <= num7; num8++)
				{
					cf2.w().av(r[num8]);
				}
			}
			cf2.w().ap(s != 0);
			if (t != 0 && i == cf2.w().aq())
			{
				int num9 = i;
				for (int num10 = 0; num10 <= num9; num10++)
				{
					cf2.w().@as(u[num10]);
					cf2.w().at(v[num10]);
				}
			}
			cf2.w().aq(w != 0);
			cf2.w().ar(x != 0);
			cf2.w().@as(y != 0);
			cf2.w().aw(z);
			return cf2;
		}
	}

	public ic()
	{
		w = byte.MaxValue;
	}

	public ic(cf A_0)
	{
		a = checked((byte)A_0.o());
		this.m_b = (byte)(0u - (A_0.p() ? 1u : 0u));
		c = (float)A_0.q();
		d = (float)A_0.r();
		e = (float)A_0.w().ap();
		checked
		{
			f = (ushort)A_0.w().bb();
			int num = f - 1;
			g = new float[num + 1];
			h = new float[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				g[num3] = (float)A_0.w().a2(num3);
				h[num3] = (float)A_0.w().ax(num3);
			}
			i = (byte)A_0.w().aq();
			j = new float[i + 1];
			k = new float[i + 1];
			int num4 = i;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				j[num5] = (float)A_0.w().@as(num5);
				k[num5] = (float)A_0.w().at(num5);
			}
			l = (byte)(A_0.w().at() - 1);
			m = new float[l + 1];
			int num6 = l;
			for (int num7 = 0; num7 <= num6; num7++)
			{
				m[num7] = (float)A_0.w().ar(num7);
			}
			n = (float)A_0.w().bc();
			o = (float)A_0.w().bd();
			p = (float)A_0.w().be();
			if (A_0.w().ba())
			{
				q = (byte)(A_0.w().av() - 1);
				r = new float[q + 1];
				int num8 = q;
				for (int num9 = 0; num9 <= num8; num9++)
				{
					r[num9] = (float)A_0.w().aw(num9);
				}
			}
			else
			{
				q = 0;
			}
		}
		s = (byte)(0u - (A_0.w().ay() ? 1u : 0u));
		t = (byte)(0u - (A_0.w().a5() ? 1u : 0u));
		checked
		{
			if (A_0.w().a5())
			{
				u = new float[i + 1];
				v = new float[i + 1];
				int num10 = i;
				for (int num11 = 0; num11 <= num10; num11++)
				{
					u[num11] = (float)A_0.w().au(num11);
					v[num11] = (float)A_0.w().av(num11);
				}
			}
		}
		w = (byte)(0u - (A_0.w().az() ? 1u : 0u));
		x = (byte)(0u - (A_0.w().a0() ? 1u : 0u));
		y = (byte)(0u - (A_0.w().a1() ? 1u : 0u));
		z = (int)checked((byte)Math.Round(A_0.w().bf()));
	}
}
