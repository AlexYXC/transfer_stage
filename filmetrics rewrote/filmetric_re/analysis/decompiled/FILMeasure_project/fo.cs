using System.Collections.Generic;
using System.IO;

internal class fo
{
	public int a;

	public List<string> b;

	public List<string> c;

	public List<List<string>> d;

	public string e;

	private const int m_f = 1;

	private const int g = 1;

	public void f(StreamWriter A_0)
	{
		A_0.WriteLine(b.Count);
		checked
		{
			int num = b.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				A_0.WriteLine(b[num2]);
			}
			A_0.WriteLine(c.Count);
			int num3 = c.Count - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				A_0.WriteLine(c[num4]);
			}
			A_0.WriteLine(d.Count);
			int num5 = d.Count - 1;
			for (int num6 = 0; num6 <= num5; num6++)
			{
				A_0.WriteLine(d[num6].Count);
				int num7 = d[num6].Count - 1;
				for (int num8 = 0; num8 <= num7; num8++)
				{
					A_0.WriteLine(d[num6][num8]);
				}
			}
		}
	}

	public void f(StreamReader A_0)
	{
		checked
		{
			int num = iz.c(A_0.ReadLine()) - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				a = num2;
				b.Add(A_0.ReadLine().Trim());
			}
			int num3 = iz.c(A_0.ReadLine()) - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				c.Add(A_0.ReadLine().Trim());
			}
			int num5 = iz.c(A_0.ReadLine()) - 1;
			for (int num6 = 0; num6 <= num5; num6++)
			{
				d.Add(new List<string>());
				int num7 = iz.c(A_0.ReadLine()) - 1;
				for (int num8 = 0; num8 <= num7; num8++)
				{
					d[num6].Add(A_0.ReadLine().Trim());
				}
			}
		}
	}

	public void f(string A_0)
	{
		if (!b.Contains(A_0))
		{
			b.Add(A_0);
		}
		if (!c.Contains(A_0))
		{
			c.Add(A_0);
		}
		if (d == null)
		{
			return;
		}
		if (d.Count == 0)
		{
			d.Add(new List<string>());
		}
		checked
		{
			int num = d.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (!d[num2].Contains(A_0))
				{
					d[num2].Add(A_0);
				}
			}
		}
	}

	public void f()
	{
		b.Clear();
		c.Clear();
		checked
		{
			if (d != null && d.Count > 0)
			{
				int num = d.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					d[num2].Clear();
				}
			}
		}
	}

	public void f(int A_0, bool A_1, int A_2, string A_3)
	{
		if (A_1)
		{
			if (c.Contains(A_3))
			{
				c.Remove(A_3);
			}
		}
		else if (A_2 == -1)
		{
			if (b.Contains(A_3))
			{
				b.Remove(A_3);
			}
		}
		else if (d != null && d.Count > 0 && d[A_2].Contains(A_3))
		{
			d[A_2].Remove(A_3);
		}
	}

	public fo()
	{
		b = new List<string>();
		c = new List<string>();
		d = new List<List<string>>();
	}

	public fo(int A_0, string A_1)
	{
		b = new List<string>();
		c = new List<string>();
		d = new List<List<string>>();
		a = A_0;
		e = A_1;
	}
}
