using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal abstract class fu : fp
{
	private bool r;

	private float s;

	private bool t;

	private fr u;

	private ft v;

	private fs w;

	[SpecialName]
	public bool ao()
	{
		return v.az();
	}

	[SpecialName]
	public void am(bool A_0)
	{
		v.@as(A_0);
	}

	[SpecialName]
	public bool ap()
	{
		return v.ay();
	}

	[SpecialName]
	public void an(bool A_0)
	{
		v.ar(A_0);
	}

	[SpecialName]
	public bool aq()
	{
		return w.az();
	}

	[SpecialName]
	public void ao(bool A_0)
	{
		w.@as(A_0);
	}

	[SpecialName]
	public bool ar()
	{
		return w.ay();
	}

	[SpecialName]
	public void ap(bool A_0)
	{
		w.ar(A_0);
	}

	[SpecialName]
	public bool @as()
	{
		return r;
	}

	[SpecialName]
	public void aq(bool A_0)
	{
		bool flag = false;
		if (A_0 != r)
		{
			flag = true;
		}
		r = A_0;
		if (flag)
		{
			a7();
		}
	}

	[SpecialName]
	public bool at()
	{
		return v.am();
	}

	[SpecialName]
	public void ar(bool A_0)
	{
		v.am(A_0);
	}

	[SpecialName]
	public float au()
	{
		return s;
	}

	[SpecialName]
	public void am(float A_0)
	{
		bool flag = false;
		if (A_0 != s)
		{
			flag = true;
		}
		s = A_0;
		if (flag)
		{
			a7();
		}
	}

	[SpecialName]
	public bool av()
	{
		return t;
	}

	[SpecialName]
	public void @as(bool A_0)
	{
		bool flag = false;
		if (A_0 != t)
		{
			flag = true;
		}
		t = A_0;
		if (flag)
		{
			a7();
		}
	}

	[SpecialName]
	public double aw()
	{
		double A_ = double.MaxValue;
		v.am(ref A_);
		return A_;
	}

	[SpecialName]
	public double ax()
	{
		double A_ = double.MinValue;
		v.an(ref A_);
		return A_;
	}

	[SpecialName]
	public double ay()
	{
		double A_ = double.MaxValue;
		w.am(ref A_);
		return A_;
	}

	[SpecialName]
	public double az()
	{
		double A_ = double.MinValue;
		w.an(ref A_);
		return A_;
	}

	[SpecialName]
	public double a0()
	{
		return v.aw();
	}

	[SpecialName]
	public void am(double A_0)
	{
		v.ao(A_0);
	}

	[SpecialName]
	public double at(bool A_0 = false)
	{
		return v.ax();
	}

	[SpecialName]
	public void am([Optional][DefaultParameterValue(false)] bool A_0, double A_1)
	{
		v.ap(A_1);
	}

	[SpecialName]
	public double a1()
	{
		return w.aw();
	}

	[SpecialName]
	public void an(double A_0)
	{
		w.ao(A_0);
	}

	[SpecialName]
	public double au(bool A_0 = false)
	{
		return w.ax();
	}

	[SpecialName]
	public void an([Optional][DefaultParameterValue(false)] bool A_0, double A_1)
	{
		w.ap(A_1);
	}

	[SpecialName]
	public fr a2()
	{
		return u;
	}

	[SpecialName]
	public ft a3()
	{
		return v;
	}

	[SpecialName]
	public fs a4()
	{
		return w;
	}

	public fu(fr A_0)
	{
		v = new ft();
		w = new fs();
		u = A_0;
		an();
	}

	public fu(fr A_0, ft A_1, fs A_2)
	{
		v = new ft();
		w = new fs();
		u = A_0;
		v = A_1;
		w = A_2;
		an();
	}

	private void an()
	{
		u.am(am);
		v.am((a)am);
		w.am((a)am);
	}

	public void a5()
	{
		if (ao())
		{
			v.an();
		}
		if (aq())
		{
			w.an();
		}
	}

	private void am()
	{
		a7();
	}
}
