using System;
using System.IO;
using System.Runtime.CompilerServices;
using FIUsbIntLib;

internal class hp
{
	private hq a;

	private int b;

	private int c;

	private int d;

	private long e;

	private float f;

	private float g;

	private float h;

	private string i;

	private double j;

	private FMUSBDeviceType k;

	private float l;

	private bool m;

	private bool n;

	private bool o;

	private float p;

	private const short m_q = 2;

	[SpecialName]
	public hq q()
	{
		return a;
	}

	[SpecialName]
	public void q(hq A_0)
	{
		a = A_0;
	}

	[SpecialName]
	public int r()
	{
		return b;
	}

	[SpecialName]
	public int s()
	{
		return c;
	}

	[SpecialName]
	public void q(int A_0)
	{
		c = A_0;
	}

	[SpecialName]
	public int t()
	{
		return d;
	}

	[SpecialName]
	public long u()
	{
		return e;
	}

	[SpecialName]
	public float v()
	{
		return f;
	}

	[SpecialName]
	public float w()
	{
		return g;
	}

	[SpecialName]
	public float x()
	{
		return h;
	}

	[SpecialName]
	public string y()
	{
		return i;
	}

	[SpecialName]
	public double z()
	{
		return j;
	}

	[SpecialName]
	public void q(double A_0)
	{
		j = A_0;
	}

	[SpecialName]
	public FMUSBDeviceType aa()
	{
		return k;
	}

	[SpecialName]
	public float ab()
	{
		return l;
	}

	[SpecialName]
	public void q(float A_0)
	{
		l = A_0;
	}

	[SpecialName]
	public bool ac()
	{
		return m;
	}

	[SpecialName]
	public void q(bool A_0)
	{
		m = A_0;
	}

	[SpecialName]
	public bool ad()
	{
		return n;
	}

	[SpecialName]
	public void r(bool A_0)
	{
		n = A_0;
	}

	[SpecialName]
	public bool ae()
	{
		return o;
	}

	[SpecialName]
	public void s(bool A_0)
	{
		o = A_0;
	}

	[SpecialName]
	public float af()
	{
		return p;
	}

	[SpecialName]
	public void r(float A_0)
	{
		p = A_0;
	}

	public hp()
	{
		n = false;
		o = false;
		a = new hq();
	}

	public hp(int A_0, int A_1, long A_2, float A_3, float A_4, float A_5, string A_6, FMUSBDeviceType A_7)
	{
		n = false;
		o = false;
		b = A_0;
		d = A_1;
		e = A_2;
		f = A_3;
		g = A_4;
		h = A_5;
		a = new hq();
		i = A_6;
		k = A_7;
	}

	public hp ag()
	{
		return (hp)MemberwiseClone();
	}

	public void q(BinaryWriter A_0)
	{
		long position = A_0.BaseStream.Position;
		A_0.Write(position);
		A_0.Write((short)2);
		A_0.Write((short)1);
		a.f(A_0);
		A_0.Write(b);
		A_0.Write(c);
		A_0.Write(d);
		A_0.Write(e);
		A_0.Write(f);
		A_0.Write(g);
		A_0.Write(h);
		A_0.Write(i);
		A_0.Write(j);
		A_0.Write((int)k);
		A_0.Write(l);
		A_0.Write(m);
		A_0.Write(n);
		A_0.Write(o);
		A_0.Write(p);
		long position2 = A_0.BaseStream.Position;
		A_0.BaseStream.Seek(position, SeekOrigin.Begin);
		A_0.Write(position2);
		A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
	}

	public void q(BinaryReader A_0)
	{
		long offset = A_0.ReadInt64();
		short num = A_0.ReadInt16();
		if (A_0.ReadInt16() > 2)
		{
			throw new ApplicationException("Incompatible File Format. Newer software version is required to read this file");
		}
		a.f(A_0);
		b = A_0.ReadInt32();
		c = A_0.ReadInt32();
		d = A_0.ReadInt32();
		e = A_0.ReadInt64();
		f = A_0.ReadSingle();
		g = A_0.ReadSingle();
		h = A_0.ReadSingle();
		i = A_0.ReadString();
		j = A_0.ReadDouble();
		k = (FMUSBDeviceType)A_0.ReadInt32();
		if (num >= 2)
		{
			l = A_0.ReadSingle();
			m = A_0.ReadBoolean();
			n = A_0.ReadBoolean();
			o = A_0.ReadBoolean();
			p = A_0.ReadSingle();
		}
		A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
	}
}
