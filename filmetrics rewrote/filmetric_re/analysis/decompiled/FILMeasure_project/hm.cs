using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class hm
{
	private float a;

	private float b;

	private float c;

	private float d;

	private es e;

	private cf f;

	private hl g;

	private string h;

	private string m_i;

	private string m_j;

	public hm i()
	{
		return (hm)MemberwiseClone();
	}

	public hm i(float A_0)
	{
		hm obj = i();
		obj.m(A_0);
		return obj;
	}

	public hm j(float A_0)
	{
		hm obj = i();
		obj.n(A_0);
		return obj;
	}

	public hm k(float A_0)
	{
		hm obj = i();
		obj.o(A_0);
		return obj;
	}

	public hm l(float A_0)
	{
		hm obj = i();
		obj.p(A_0);
		return obj;
	}

	public hm i(hl A_0)
	{
		hm obj = i();
		obj.j(A_0);
		return obj;
	}

	public hm i(es A_0)
	{
		hm obj = i();
		es a_ = null;
		if (A_0 is et)
		{
			a_ = new et();
		}
		else if (A_0 != null)
		{
			throw new ArgumentException("Unknown objective type");
		}
		if (A_0 == null)
		{
			a_ = null;
		}
		else
		{
			A_0.ad(a_);
		}
		obj.j(a_);
		return obj;
	}

	public hm i(cf A_0)
	{
		hm obj = i();
		obj.j(A_0);
		return obj;
	}

	[SpecialName]
	public float j()
	{
		return a;
	}

	protected void m(float A_0)
	{
		a = A_0;
	}

	[SpecialName]
	public float k()
	{
		return b;
	}

	protected void n(float A_0)
	{
		b = A_0;
	}

	[SpecialName]
	public float l()
	{
		return c;
	}

	protected void o(float A_0)
	{
		c = A_0;
	}

	[SpecialName]
	public float m()
	{
		return d;
	}

	protected void p(float A_0)
	{
		d = A_0;
	}

	[SpecialName]
	public hl n()
	{
		return g;
	}

	protected void j(hl A_0)
	{
		g = A_0;
	}

	[SpecialName]
	public string o()
	{
		return g switch
		{
			hl.b => this.m_i, 
			hl.a => h, 
			hl.c => this.m_j, 
			_ => this.m_i, 
		};
	}

	public hl i(string A_0)
	{
		if (Operators.CompareString(A_0, h, TextCompare: false) == 0)
		{
			return hl.a;
		}
		if (Operators.CompareString(A_0, this.m_j, TextCompare: false) == 0)
		{
			return hl.c;
		}
		return hl.b;
	}

	[SpecialName]
	public es p()
	{
		return e;
	}

	protected void j(es A_0)
	{
		e = A_0;
	}

	[SpecialName]
	public cf q()
	{
		return f;
	}

	protected void j(cf A_0)
	{
		f = A_0;
	}

	public hm()
	{
		h = "tm";
		this.m_i = "te";
		this.m_j = "mixed";
		g = hl.b;
	}
}
