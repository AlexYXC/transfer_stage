using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class et : es
{
	private float b;

	private float c;

	private float d;

	private float e;

	private float f;

	private float g;

	private float h;

	private bool i;

	private bool j;

	private bool k;

	private float l;

	private bool m;

	private float n;

	private float o;

	private double p;

	private ev q;

	private short r;

	private double s;

	private new float m_t;

	private new const int m_u = 8;

	private const int m_v = 8;

	public const float w = 470f;

	public new const float x = 750f;

	public new const float y = 720f;

	public new const float z = 1000f;

	public new const float aa = 1600f;

	public new const float ab = 6000f;

	public new const float ac = 850f;

	public new const float ad = 1f;

	public const float ae = 1.515f;

	public et()
	{
		a = "New Objective";
		b = 0.14f;
		c = 0.14f;
		d = 0.14f;
		e = 0f;
		f = 470f;
		g = 750f;
		h = 720f;
		i = true;
		j = false;
		k = false;
		m = false;
		l = 1f;
		n = 0f;
		o = 0f;
		p = 0.0;
		r = 0;
		s = 0.0;
		this.m_t = 0f;
	}

	public void t(double A_0, double A_1, ref float A_2, ref float A_3, ref bool A_4)
	{
		A_4 = false;
		if (470.0 >= A_0 && 750.0 <= A_1)
		{
			A_2 = 470f;
			A_3 = 750f;
			return;
		}
		A_4 = A_0 >= 850.0;
		if (A_4)
		{
			A_2 = 1000f;
			A_3 = 1600f;
		}
	}

	[SpecialName]
	public float t()
	{
		return b;
	}

	[SpecialName]
	public void t(float A_0)
	{
		b = A_0;
	}

	[SpecialName]
	public float u()
	{
		return c;
	}

	[SpecialName]
	public void u(float A_0)
	{
		c = A_0;
	}

	[SpecialName]
	public float v()
	{
		return d;
	}

	[SpecialName]
	public void v(float A_0)
	{
		d = A_0;
	}

	[SpecialName]
	public float w()
	{
		return e;
	}

	[SpecialName]
	public void w(float A_0)
	{
		e = A_0;
	}

	[SpecialName]
	public float x()
	{
		return f;
	}

	[SpecialName]
	public void x(float A_0)
	{
		f = A_0;
	}

	[SpecialName]
	public float y()
	{
		return g;
	}

	[SpecialName]
	public void y(float A_0)
	{
		g = A_0;
	}

	[SpecialName]
	public float z()
	{
		return h;
	}

	[SpecialName]
	public void z(float A_0)
	{
		h = A_0;
	}

	[SpecialName]
	public bool aa()
	{
		return i;
	}

	[SpecialName]
	public void t(bool A_0)
	{
		i = A_0;
	}

	[SpecialName]
	public bool ab()
	{
		return j;
	}

	[SpecialName]
	public void u(bool A_0)
	{
		j = A_0;
	}

	[SpecialName]
	public bool ac()
	{
		return k;
	}

	[SpecialName]
	public void v(bool A_0)
	{
		k = A_0;
	}

	[SpecialName]
	public bool ad()
	{
		return m;
	}

	[SpecialName]
	public void w(bool A_0)
	{
		m = A_0;
	}

	[SpecialName]
	public float ae()
	{
		return l;
	}

	[SpecialName]
	public void aa(float A_0)
	{
		l = A_0;
	}

	[SpecialName]
	public float af()
	{
		return n;
	}

	[SpecialName]
	public void ab(float A_0)
	{
		n = A_0;
	}

	[SpecialName]
	public float ag()
	{
		return o;
	}

	[SpecialName]
	public void ac(float A_0)
	{
		o = A_0;
	}

	[SpecialName]
	public double ah()
	{
		return p;
	}

	[SpecialName]
	public void t(double A_0)
	{
		p = A_0;
	}

	[SpecialName]
	public ev ai()
	{
		return q;
	}

	[SpecialName]
	public void t(ev A_0)
	{
		q = A_0;
	}

	[SpecialName]
	public double aj()
	{
		return s;
	}

	[SpecialName]
	public void u(double A_0)
	{
		s = A_0;
	}

	[SpecialName]
	public float ak()
	{
		return this.m_t;
	}

	[SpecialName]
	public void ad(float A_0)
	{
		this.m_t = A_0;
	}

	public override void x(BinaryWriter A_0)
	{
		A_0.Write(al());
		A_0.Write(t());
		A_0.Write(u());
		A_0.Write(v());
		A_0.Write(x());
		A_0.Write(y());
		A_0.Write(z());
		A_0.Write(aa());
		A_0.Write(ab());
	}

	public override void y(BinaryWriter A_0)
	{
		i3.a(A_0, z, 8, 8);
	}

	protected override void z(BinaryWriter A_0)
	{
		x(A_0);
		A_0.Write(ac());
		A_0.Write(ae());
		A_0.Write(e);
		A_0.Write(af());
		A_0.Write(ag());
		A_0.Write(ah());
		A_0.Write(r);
		A_0.Write(s);
		A_0.Write(this.m_t);
		A_0.Write(m);
	}

	public override void aa(BinaryReader A_0)
	{
		a = A_0.ReadString();
		t(A_0.ReadSingle());
		u(A_0.ReadSingle());
		v(A_0.ReadSingle());
		f = A_0.ReadSingle();
		g = A_0.ReadSingle();
		h = A_0.ReadSingle();
		i = A_0.ReadBoolean();
		j = A_0.ReadBoolean();
	}

	public override void ab(BinaryReader A_0)
	{
		i3.a(A_0, ac, "ObjectiveF40", 8);
	}

	public override void ac(BinaryReader A_0, int A_1)
	{
		aa(A_0);
		if (A_1 > 1)
		{
			k = A_0.ReadBoolean();
			l = A_0.ReadSingle();
		}
		else
		{
			k = false;
			l = 1f;
		}
		if (A_1 > 2)
		{
			e = A_0.ReadSingle();
		}
		if (A_1 > 3)
		{
			n = A_0.ReadSingle();
			o = A_0.ReadSingle();
			p = A_0.ReadDouble();
		}
		if (A_1 > 4)
		{
			r = A_0.ReadInt16();
		}
		if (A_1 > 5)
		{
			s = A_0.ReadDouble();
		}
		if (A_1 > 6)
		{
			this.m_t = A_0.ReadSingle();
		}
		if (A_1 > 7)
		{
			m = A_0.ReadBoolean();
		}
	}

	public override void ad(es A_0)
	{
		et obj = (et)A_0;
		obj.t(al());
		obj.t(t());
		obj.u(u());
		obj.v(v());
		obj.w(w());
		obj.x(x());
		obj.y(y());
		obj.z(z());
		obj.t(aa());
		obj.u(ab());
		obj.v(ac());
		obj.aa(ae());
		obj.w(ad());
		obj.ab(af());
		obj.ac(ag());
		obj.t(ah());
		obj.t(ai());
		obj.r = r;
		obj.s = s;
		obj.m_t = this.m_t;
		_ = null;
	}

	[SpecialName]
	public static bool u(et A_0, et A_1)
	{
		switch (ix.a(A_0, A_1))
		{
		case ix.a.a:
			return false;
		case ix.a.b:
			return true;
		default:
		{
			et et2 = A_0;
			if (Operators.CompareString(et2.al(), A_1.al(), TextCompare: false) != 0)
			{
				return true;
			}
			if (et2.t() != A_1.t())
			{
				return true;
			}
			if (et2.u() != A_1.u())
			{
				return true;
			}
			if (et2.v() != A_1.v())
			{
				return true;
			}
			if (et2.w() != A_1.w())
			{
				return true;
			}
			if (et2.x() != A_1.x())
			{
				return true;
			}
			if (et2.y() != A_1.y())
			{
				return true;
			}
			if (et2.z() != A_1.z())
			{
				return true;
			}
			if (et2.aa() != A_1.aa())
			{
				return true;
			}
			if (et2.ab() != A_1.ab())
			{
				return true;
			}
			if (et2.ac() != A_1.ac())
			{
				return true;
			}
			if (et2.ae() != A_1.ae())
			{
				return true;
			}
			if (et2.ad() != A_1.ad())
			{
				return true;
			}
			if (et2.af() != A_1.af())
			{
				return true;
			}
			if (et2.ag() != A_1.ag())
			{
				return true;
			}
			if (et2.ah() != A_1.ah())
			{
				return true;
			}
			if (ev.m(et2.ai(), A_1.ai()))
			{
				return true;
			}
			if (et2.r != A_1.r)
			{
				return true;
			}
			if (et2.s != A_1.s)
			{
				return true;
			}
			if (et2.m_t != A_1.m_t)
			{
				return true;
			}
			et2 = null;
			return false;
		}
		}
	}

	[SpecialName]
	public static bool t(et A_0, et A_1)
	{
		return !u(A_0, A_1);
	}

	public bool t(et A_0)
	{
		return t(this, A_0);
	}
}
