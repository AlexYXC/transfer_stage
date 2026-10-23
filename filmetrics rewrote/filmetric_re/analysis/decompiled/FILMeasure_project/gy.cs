using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class gy
{
	private gu.a.a a;

	private Guid b;

	private string c;

	private bool d;

	private string[] e;

	private string f;

	private bool g;

	private bool h;

	private string[] i;

	private bool j;

	private Collection<ip.a> k;

	private Collection<@in.a> l;

	private gt m;

	private g2 n;

	private fz o;

	private string p;

	private string q;

	private List<h5.a> r;

	private hg m_s;

	public gy(fz A_0, g7 A_1)
		: this(A_0, gu.a.a.a, new Guid(A_1.zj()), A_1.zl())
	{
	}

	public gy(fz A_0, gu.a.a A_1, Guid A_2, string A_3)
	{
		e = new string[2] { "\\.fitrp", "\\.fitra" };
		i = new string[2] { "\\DefaultTemplate.fmtpe", "\\DefaultTemplate.fmtpa" };
		j = false;
		k = new Collection<ip.a>();
		l = new Collection<@in.a>();
		n = new g2();
		p = string.Empty;
		r = new List<h5.a>();
		o = A_0;
		a = A_1;
		b = new Guid(A_2.ToString());
		c = A_3;
	}

	public gy(fz A_0, gu.a.a A_1, Guid A_2, string A_3, string A_4)
		: this(A_0, A_1, A_2, A_3)
	{
		p = A_4;
	}

	public g0 s()
	{
		g0 g10 = new g0();
		g10.a = c;
		g10.b = b;
		foreach (ip.a item in k)
		{
			g10.c.Add(item);
		}
		foreach (h5.a item2 in r)
		{
			g10.c.Add(item2);
		}
		return g10;
	}

	[SpecialName]
	public gu.a.a t()
	{
		return a;
	}

	[SpecialName]
	public string u()
	{
		return c;
	}

	[SpecialName]
	public void s(string A_0)
	{
		c = A_0;
	}

	[SpecialName]
	public string v()
	{
		return q;
	}

	[SpecialName]
	public void t(string A_0)
	{
		q = A_0;
	}

	[SpecialName]
	public g2 w()
	{
		return n;
	}

	[SpecialName]
	public void s(g2 A_0)
	{
		n = A_0;
	}

	[SpecialName]
	public string x()
	{
		return b.ToString();
	}

	[SpecialName]
	public Guid y()
	{
		return b;
	}

	[SpecialName]
	public bool z()
	{
		return d;
	}

	[SpecialName]
	public void s(bool A_0)
	{
		d = A_0;
	}

	[SpecialName]
	public string aa()
	{
		if (d)
		{
			return e[1];
		}
		return e[0];
	}

	[SpecialName]
	public void u(string A_0)
	{
		if (d)
		{
			e[1] = A_0;
		}
		else
		{
			e[0] = A_0;
		}
	}

	[SpecialName]
	public string ab()
	{
		return f;
	}

	[SpecialName]
	public void v(string A_0)
	{
		f = A_0;
	}

	[SpecialName]
	public bool ac()
	{
		return g;
	}

	[SpecialName]
	public void t(bool A_0)
	{
		g = A_0;
	}

	[SpecialName]
	public gt ad()
	{
		return m;
	}

	[SpecialName]
	public void s(gt A_0)
	{
		m = A_0;
	}

	[SpecialName]
	public bool ae()
	{
		return h;
	}

	[SpecialName]
	public void u(bool A_0)
	{
		h = A_0;
	}

	[SpecialName]
	public string af()
	{
		if (h)
		{
			return i[1];
		}
		return i[0];
	}

	[SpecialName]
	public void w(string A_0)
	{
		if (h)
		{
			i[1] = A_0;
		}
		else
		{
			i[0] = A_0;
		}
	}

	[SpecialName]
	public bool ag()
	{
		return j;
	}

	[SpecialName]
	public void v(bool A_0)
	{
		j = A_0;
	}

	[SpecialName]
	public string ah()
	{
		return p;
	}

	[SpecialName]
	public void x(string A_0)
	{
		p = A_0;
	}

	public void s(@in.a A_0, int A_1)
	{
		try
		{
			l.Insert(A_1, A_0);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (A_0 != null)
			{
				throw new Exception("Error adding photodiode/LED " + A_0.m() + " at index " + A_1 + ". Error is: " + ex3.Message);
			}
			throw new Exception("Error adding photodiode/LED at index " + A_1 + ". Error is: " + ex3.Message);
		}
	}

	public void s(@in.a A_0)
	{
		try
		{
			l.Add(A_0);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (A_0 != null)
			{
				throw new Exception("Error adding photodiode/LED " + A_0.m() + ". Error is: " + ex3.Message);
			}
			throw new Exception("Error adding photodiode/LED. Error is: " + ex3.Message);
		}
	}

	public void s(int A_0)
	{
		try
		{
			l.RemoveAt(A_0);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			throw new Exception("Error removing photodiode/LED at index " + A_0 + ". Error is: " + ex3.Message);
		}
	}

	public void s(ip.a A_0, int A_1)
	{
		try
		{
			k.Insert(A_1, A_0);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (A_0 != null)
			{
				throw new Exception("Error adding spectrometer " + A_0.w() + " at index " + A_1 + ". Error is: " + ex3.Message);
			}
			throw new Exception("Error adding spectrometer at index " + A_1 + ". Error is: " + ex3.Message);
		}
	}

	public void s(ip.a A_0)
	{
		try
		{
			k.Add(A_0);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (A_0 != null)
			{
				throw new Exception("Error adding spectrometer " + A_0.w() + ". Error is: " + ex3.Message);
			}
			throw new Exception("Error adding spectrometer. Error is: " + ex3.Message);
		}
	}

	public void t(hg A_0)
	{
		this.m_s = A_0;
		this.m_s.bu(s, s);
	}

	public void s(r.d A_0, bool A_1, r.d.a.b A_2)
	{
		hg hg2 = this.m_s;
		s(hg2.b5());
		checked
		{
			try
			{
				u("\\" + hg2.b6());
			}
			catch (DirectoryNotFoundException ex2)
			{
				ProjectData.SetProjectError(ex2);
				DirectoryNotFoundException ex3 = ex2;
				int num = Strings.InStr(hg2.c1(), "\\Recipes\\");
				int num2 = ((!z()) ? ".fitrp".Length : ".fitra".Length);
				if (num > 0 && hg2.c1().Length > num + "Recipes".Length + 2 + num2)
				{
					u("\\" + hg2.c1().Substring(num + "Recipes".Length + 1));
				}
				else if (z())
				{
					u("\\.fitra");
				}
				else
				{
					u("\\.fitrp");
				}
				ProjectData.ClearProjectError();
			}
			hg2 = null;
		}
	}

	private void s(hg A_0)
	{
		this.m_s.bv(s, s);
		this.m_s = A_0;
		this.m_s.bu(s, s);
	}

	public void t(int A_0)
	{
		try
		{
			k.RemoveAt(A_0);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			throw new Exception("Error removing spectrometer at index " + A_0 + ". Error is: " + ex3.Message);
		}
	}

	public void s(h5.a A_0)
	{
		r.Add(A_0);
	}

	public void u(int A_0)
	{
		r.RemoveAt(A_0);
	}

	[SpecialName]
	public List<h5.a> ai()
	{
		return r;
	}

	[SpecialName]
	public Collection<@in.a> aj()
	{
		return l;
	}

	[SpecialName]
	public Collection<ip.a> ak()
	{
		return k;
	}

	~gy()
	{
		base.Finalize();
	}
}
