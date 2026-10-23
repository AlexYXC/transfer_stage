using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class b5
{
	private Collection<a4.d> a;

	private a4.a b;

	private bool c;

	private y d;

	private r.d e;

	private const float f = 365f;

	private const float m_g = 825f;

	private b6 m_h;

	private b7 m_i;

	public b5(fz A_0)
	{
		d = new y();
		e = new r.d();
		a = new Collection<a4.d>();
		d.c(A_0);
	}

	[SpecialName]
	public Collection<a4.d> g()
	{
		return a;
	}

	[SpecialName]
	public a4.a h()
	{
		return b;
	}

	[SpecialName]
	public bool i()
	{
		return c;
	}

	[SpecialName]
	public y j()
	{
		return d;
	}

	public void k()
	{
		short num = global::e.a().SpectrumColorObserver;
		short num2 = global::e.a().SpectrumColorIlluminant;
		b = (a4.a)global::e.a().ShowSpectrumCoordOption;
		c = global::e.a().AlwayShowSpectrumCoordXYZ;
		a.Clear();
		if (!global::e.a().ShowSpectrumColor)
		{
			return;
		}
		a4.d d10 = new a4.d();
		d10.a = a4.a.a;
		d10.b = (a4.b)num;
		d10.c = (a4.c)num2;
		a.Add(d10);
		d10 = new a4.d();
		d10.a = a4.a.c;
		d10.b = (a4.b)num;
		d10.c = (a4.c)num2;
		if (b == a4.a.c)
		{
			a.Insert(0, d10);
		}
		else
		{
			a.Add(d10);
		}
		if (b == a4.a.d || c)
		{
			d10 = new a4.d();
			d10.a = a4.a.d;
			d10.b = (a4.b)num;
			d10.c = (a4.c)num2;
			if (b == a4.a.d)
			{
				a.Insert(0, d10);
			}
			else
			{
				a.Add(d10);
			}
		}
		if (b == a4.a.b)
		{
			d10 = new a4.d();
			d10.a = a4.a.b;
			d10.b = (a4.b)num;
			d10.c = (a4.c)num2;
			a.Insert(0, d10);
		}
		e.d(default(Guid), null);
	}

	public static bool g(hr A_0)
	{
		checked
		{
			double num;
			double num2;
			if (global::e.a().RestrictColorWavelength)
			{
				num = Math.Max(A_0.cz()[0], global::e.a().ColorWavelengthLowerLimitNm);
				num2 = Math.Min(A_0.cz()[A_0.c2() - 1], global::e.a().ColorWavelengthUpperLimitNm);
			}
			else
			{
				num = A_0.cz()[0];
				num2 = A_0.cz()[A_0.c2() - 1];
			}
			if (A_0.ah() && num <= 825.0)
			{
				return num2 >= 365.0;
			}
			return false;
		}
	}

	public r.d l()
	{
		return e;
	}

	[SpecialName]
	public b6 m()
	{
		return this.m_h;
	}

	[SpecialName]
	public b7 n()
	{
		return this.m_i;
	}

	public void o()
	{
		this.m_h = new b6();
		try
		{
			this.m_h.e();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_h = null;
			throw ex3;
		}
		this.m_i = new b7();
		try
		{
			this.m_i.e();
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception ex5 = ex4;
			this.m_i = null;
			throw ex5;
		}
	}
}
