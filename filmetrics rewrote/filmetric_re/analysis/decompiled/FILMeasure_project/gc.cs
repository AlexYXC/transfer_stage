using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

internal class gc
{
	public enum a
	{
		a,
		b,
		c
	}

	public delegate void b();

	private string m_a;

	private double m_b;

	private double c;

	private double d;

	private double e;

	private bool f;

	private bool g;

	private bool h;

	private bool i;

	private bool j;

	private bool k;

	private string l;

	private double m;

	private double n;

	private double o;

	private double p;

	private double q;

	private bool r;

	private short s;

	private const short t = 3;

	private const short u = 1;

	public bool v;

	public bool w;

	public gb x;

	public const string y = "<Graded>";

	public const string z = "<Graded Interface>";

	public const string aa = "<Roughness>";

	[CompilerGenerated]
	private b ab;

	[SpecialName]
	[CompilerGenerated]
	public void af(b A_0)
	{
		b b10 = ab;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Combine(b11, A_0);
			b10 = Interlocked.CompareExchange(ref ab, value, b11);
		}
		while ((object)b10 != b11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void ag(b A_0)
	{
		b b10 = ab;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Remove(b11, A_0);
			b10 = Interlocked.CompareExchange(ref ab, value, b11);
		}
		while ((object)b10 != b11);
	}

	[SpecialName]
	public static bool ag(gc A_0, gc A_1)
	{
		switch (ix.a(A_0, A_1))
		{
		case ix.a.a:
			return false;
		case ix.a.b:
			return true;
		default:
		{
			gc gc2 = A_0;
			if (Operators.CompareString(gc2.ag(), A_1.ag(), TextCompare: false) != 0)
			{
				return true;
			}
			if (gc2.ai() != A_1.ai())
			{
				return true;
			}
			if (gc2.aj() != A_1.aj())
			{
				return true;
			}
			if (gc2.ak() != A_1.ak())
			{
				return true;
			}
			if (gc2.an() != A_1.an())
			{
				return true;
			}
			if (gc2.av() != A_1.av())
			{
				return true;
			}
			if (gc2.aw() != A_1.aw())
			{
				return true;
			}
			if (gc2.ax() != A_1.ax())
			{
				return true;
			}
			if ((gc2.ap() || gc2.aq()) && Operators.CompareString(gc2.l, A_1.l, TextCompare: false) != 0)
			{
				return true;
			}
			if (gc2.ao() != A_1.ao())
			{
				return true;
			}
			if (gc2.at() != A_1.at())
			{
				return true;
			}
			if (gc2.ar() != A_1.ar())
			{
				return true;
			}
			if (gc2.ap() != A_1.ap())
			{
				return true;
			}
			if (gc2.@as() != A_1.@as())
			{
				return true;
			}
			if (gc2.aq() != A_1.aq())
			{
				return true;
			}
			if (gc2.al() != A_1.al())
			{
				return true;
			}
			if (gc2.am() != A_1.am())
			{
				return true;
			}
			if (gc2.af() != A_1.af())
			{
				return true;
			}
			if (gc2.w != A_1.w)
			{
				return true;
			}
			if (gb.f(gc2.x, A_1.x))
			{
				return true;
			}
			if (gd.l(gc2.ag()) && gc2.ah() != A_1.ah())
			{
				return true;
			}
			gc2 = null;
			return false;
		}
		}
	}

	[SpecialName]
	public static bool af(gc A_0, gc A_1)
	{
		return !ag(A_0, A_1);
	}

	public bool af(gc A_0)
	{
		return af(this, A_0);
	}

	[SpecialName]
	public bool af()
	{
		return r;
	}

	[SpecialName]
	public void af(bool A_0)
	{
		r = A_0;
	}

	[SpecialName]
	public string ag()
	{
		return this.m_a;
	}

	[SpecialName]
	public void af(string A_0)
	{
		string right = this.m_a;
		this.m_a = A_0;
		if (Operators.CompareString(A_0, right, TextCompare: false) != 0)
		{
			ab?.Invoke();
		}
	}

	[SpecialName]
	public short ah()
	{
		return s;
	}

	[SpecialName]
	public void af(short A_0)
	{
		s = A_0;
	}

	public void ah(b A_0)
	{
		af(A_0);
	}

	[SpecialName]
	public double ai()
	{
		return this.m_b;
	}

	public void af(bool A_0, double A_1, ref double A_2)
	{
		if (A_0)
		{
			return;
		}
		if (A_1 == 0.0)
		{
			if (this.m_b != 0.0)
			{
				A_2 *= this.m_b;
			}
		}
		else if (this.m_b == 0.0)
		{
			A_2 /= A_1;
		}
		else
		{
			A_2 *= this.m_b / A_1;
		}
	}

	public void ag(bool A_0, double A_1, ref double A_2)
	{
		if (!A_0)
		{
			return;
		}
		if (A_1 == 0.0)
		{
			if (this.m_b != 0.0)
			{
				A_2 *= this.m_b * 0.01;
			}
		}
		else if (this.m_b == 0.0)
		{
			A_2 /= A_1 * 0.01;
		}
		else
		{
			A_2 *= this.m_b / A_1;
		}
	}

	public void af(bool A_0, bool A_1, double A_2)
	{
		ag(A_0, A_2, ref m);
		af(A_1, A_2, ref d);
		this.m_b = A_2;
	}

	[SpecialName]
	public double aj()
	{
		return d;
	}

	[SpecialName]
	public void af(double A_0)
	{
		d = A_0;
	}

	[SpecialName]
	public double ak()
	{
		return c;
	}

	[SpecialName]
	public void ag(double A_0)
	{
		c = A_0;
	}

	[SpecialName]
	public double al()
	{
		return p;
	}

	[SpecialName]
	public void ah(double A_0)
	{
		p = A_0;
	}

	[SpecialName]
	public double am()
	{
		return q;
	}

	[SpecialName]
	public void ai(double A_0)
	{
		q = A_0;
	}

	[SpecialName]
	public double an()
	{
		return e;
	}

	[SpecialName]
	public void aj(double A_0)
	{
		e = A_0;
	}

	[SpecialName]
	public bool af(eo.b A_0)
	{
		bool flag = Operators.CompareString(this.m_a, "<Graded Interface>", TextCompare: false) == 0 || Operators.CompareString(this.m_a, "<Graded>", TextCompare: false) == 0;
		bool flag2 = Operators.CompareString(this.m_a, "<Roughness>", TextCompare: false) == 0;
		if (f)
		{
			if ((!flag || !A_0.f()) && (!flag2 || !A_0.e()) && (flag || flag2 || (!A_0.f() && !A_0.g())))
			{
				return A_0.h();
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	public bool ao()
	{
		return f;
	}

	[SpecialName]
	public void ag(bool A_0)
	{
		f = A_0;
	}

	[SpecialName]
	public bool ah(bool A_0)
	{
		if (g)
		{
			return A_0;
		}
		return false;
	}

	[SpecialName]
	public bool ap()
	{
		return g;
	}

	[SpecialName]
	public void ai(bool A_0)
	{
		g = A_0;
	}

	[SpecialName]
	public bool aj(bool A_0)
	{
		if (h)
		{
			return A_0;
		}
		return false;
	}

	[SpecialName]
	public bool aq()
	{
		return h;
	}

	[SpecialName]
	public void ak(bool A_0)
	{
		h = A_0;
	}

	[SpecialName]
	public bool al(bool A_0)
	{
		if (i)
		{
			return A_0;
		}
		return false;
	}

	[SpecialName]
	public bool ar()
	{
		return i;
	}

	[SpecialName]
	public void am(bool A_0)
	{
		i = A_0;
	}

	[SpecialName]
	public bool an(bool A_0)
	{
		return k;
	}

	[SpecialName]
	public bool @as()
	{
		return k;
	}

	[SpecialName]
	public void ao(bool A_0)
	{
		k = A_0;
	}

	[SpecialName]
	public bool ap(bool A_0)
	{
		if (j)
		{
			return A_0;
		}
		return false;
	}

	[SpecialName]
	public bool at()
	{
		return j;
	}

	[SpecialName]
	public void aq(bool A_0)
	{
		j = A_0;
	}

	[SpecialName]
	public string af(hd A_0, eo A_1, eo.a A_2)
	{
		return A_0.i((int)ag(A_0, A_1, A_2), A_1, A_2);
	}

	[SpecialName]
	public hd.a ag(hd A_0, eo A_1, eo.a A_2)
	{
		return A_0.i(l, A_1, A_2);
	}

	[SpecialName]
	public string au()
	{
		return l;
	}

	[SpecialName]
	public void ag(string A_0)
	{
		l = A_0;
	}

	[SpecialName]
	public double av()
	{
		return m;
	}

	[SpecialName]
	public void ak(double A_0)
	{
		m = A_0;
	}

	[SpecialName]
	public double aw()
	{
		return n;
	}

	[SpecialName]
	public void al(double A_0)
	{
		n = A_0;
	}

	[SpecialName]
	public double ax()
	{
		return o;
	}

	[SpecialName]
	public void am(double A_0)
	{
		o = A_0;
	}

	public void af(ref gc A_0)
	{
		A_0 = null;
		A_0 = new gc();
		gc obj = A_0;
		obj.af(this.m_a);
		obj.m_b = this.m_b;
		obj.aj(e);
		obj.ag(c);
		obj.af(d);
		obj.ag(ao());
		obj.aq(j);
		obj.ai(g);
		obj.ao(k);
		obj.ak(h);
		obj.am(i);
		obj.ag(l);
		obj.ak(m);
		obj.al(n);
		obj.am(o);
		obj.ah(p);
		obj.ai(q);
		obj.v = v;
		obj.w = w;
		if (x != null)
		{
			x.e(ref A_0.x);
		}
		else
		{
			A_0.x = null;
		}
		obj.af(s);
		_ = null;
	}

	public void af([Optional][DefaultParameterValue("SiO2")] ref string A_0)
	{
		this.m_a = A_0;
		this.m_b = 1.0;
		e = 0.0;
		f = false;
		m = 95.0;
		n = 10.0;
		o = 10.0;
		l = "Cauchy";
		p = 0.0;
		q = 1.0;
		v = false;
		w = false;
		s = 1;
	}

	public gc()
	{
		try
		{
			string A_ = "SiO2";
			af(ref A_);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	public void af(BinaryWriter A_0)
	{
		long position = A_0.BaseStream.Position;
		A_0.Write(position);
		A_0.Write((short)3);
		A_0.Write((short)1);
		A_0.Write(ag());
		A_0.Write(this.m_b);
		A_0.Write(e);
		A_0.Write(f);
		A_0.Write(g);
		A_0.Write(h);
		A_0.Write(i);
		A_0.Write(m);
		A_0.Write(n);
		A_0.Write(l);
		A_0.Write(c);
		A_0.Write(k);
		A_0.Write(d);
		A_0.Write(j);
		A_0.Write(x != null);
		if (x != null)
		{
			A_0.Write(x.a);
			A_0.Write(x.b);
			A_0.Write(x.c);
			A_0.Write(x.d);
		}
		long position2 = A_0.BaseStream.Position;
		A_0.BaseStream.Seek(position, SeekOrigin.Begin);
		A_0.Write(position2);
		A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
	}

	public void af(BinaryReader A_0)
	{
		short num = 0;
		short num2 = 0;
		long offset = A_0.ReadInt64();
		num = A_0.ReadInt16();
		num2 = A_0.ReadInt16();
		if (num2 > 3)
		{
			throw new Exception("Incompatible Layer File Format. Newer software version is required to read this file. FileVer=" + num + ", CompatVer=" + num2);
		}
		af(A_0.ReadString());
		this.m_b = A_0.ReadDouble();
		e = A_0.ReadDouble();
		f = A_0.ReadBoolean();
		g = A_0.ReadBoolean();
		h = A_0.ReadBoolean();
		i = A_0.ReadBoolean();
		m = A_0.ReadDouble();
		n = A_0.ReadDouble();
		l = A_0.ReadString();
		if (num >= 2)
		{
			c = A_0.ReadDouble();
			k = A_0.ReadBoolean();
			d = A_0.ReadDouble();
			j = A_0.ReadBoolean();
		}
		if (num >= 3 && A_0.ReadBoolean())
		{
			x = new gb();
			x.a = A_0.ReadDouble();
			x.b = A_0.ReadDouble();
			x.c = A_0.ReadDouble();
			x.d = A_0.ReadDouble();
		}
		A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
	}

	public void af(BinaryWriter A_0, ICryptoTransform A_1)
	{
		long position = A_0.BaseStream.Position;
		A_0.Write(position);
		A_0.Write((short)3);
		A_0.Write((short)1);
		dz.a(A_0, A_1, ag());
		dz.a(A_0, A_1, this.m_b);
		dz.a(A_0, A_1, e);
		dz.a(A_0, A_1, f);
		dz.a(A_0, A_1, g);
		dz.a(A_0, A_1, h);
		dz.a(A_0, A_1, i);
		dz.a(A_0, A_1, m);
		dz.a(A_0, A_1, n);
		dz.a(A_0, A_1, l);
		dz.a(A_0, A_1, w);
		dz.a(A_0, A_1, c);
		dz.a(A_0, A_1, k);
		dz.a(A_0, A_1, d);
		dz.a(A_0, A_1, j);
		long position2 = A_0.BaseStream.Position;
		A_0.BaseStream.Seek(position, SeekOrigin.Begin);
		A_0.Write(position2);
		A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
	}

	public void af(BinaryReader A_0, ICryptoTransform A_1)
	{
		short num = 0;
		short num2 = 0;
		long offset = A_0.ReadInt64();
		num = A_0.ReadInt16();
		num2 = A_0.ReadInt16();
		if (num2 > 3)
		{
			throw new Exception("Incompatible LayerEnc File Format. Newer software version is required to read this file. FileVer=" + num + ", CompatVer=" + num2);
		}
		af(dz.e(A_0, A_1));
		this.m_b = dz.d(A_0, A_1);
		e = dz.d(A_0, A_1);
		f = dz.a(A_0, A_1);
		g = dz.a(A_0, A_1);
		h = dz.a(A_0, A_1);
		i = dz.a(A_0, A_1);
		m = dz.d(A_0, A_1);
		n = dz.d(A_0, A_1);
		l = dz.e(A_0, A_1);
		w = dz.a(A_0, A_1);
		if (num >= 2)
		{
			c = dz.d(A_0, A_1);
			k = dz.a(A_0, A_1);
			d = dz.d(A_0, A_1);
			j = dz.a(A_0, A_1);
		}
		A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
	}
}
