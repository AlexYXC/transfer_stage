using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;

internal class em
{
	private string a;

	public Collection<en> b;

	public int c;

	public int d;

	public int e;

	private const int m_f = 1;

	public em()
	{
		a = string.Empty;
		b = new Collection<en>();
		c = 1;
	}

	[SpecialName]
	public string f()
	{
		return a;
	}

	[SpecialName]
	public void f(string A_0)
	{
		a = A_0;
	}

	public bool f(long A_0, ref int A_1)
	{
		checked
		{
			int num = b.Count - 1;
			for (A_1 = 0; A_1 <= num; A_1++)
			{
				if (b[A_1].a.b9() == A_0)
				{
					return true;
				}
				_ = null;
			}
			return false;
		}
	}

	public void f(BinaryReader A_0, fz A_1, eo A_2, hg.j A_3)
	{
		int num = 0;
		long offset = A_0.ReadInt64();
		A_0.ReadInt32();
		num = A_0.ReadInt32();
		checked
		{
			if (num <= 1)
			{
				a = A_0.ReadString();
				c = A_0.ReadInt32();
				int num2 = A_0.ReadInt32() - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					en en2 = new en();
					en2.i(A_0, A_1, A_2, A_3);
					b.Add(en2);
				}
				A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
				return;
			}
			throw new au("MeasReports maximum compatible block file version is " + 1 + " compatible version in file we are attempting to read is " + num);
		}
	}

	public void f(BinaryWriter A_0)
	{
		long position = A_0.BaseStream.Position;
		A_0.Write(position);
		A_0.Write(1);
		A_0.Write(1);
		A_0.Write(a);
		A_0.Write(c);
		A_0.Write(b.Count);
		foreach (en item in b)
		{
			item.i(A_0);
		}
		long position2 = A_0.BaseStream.Position;
		A_0.BaseStream.Seek(position, SeekOrigin.Begin);
		A_0.Write(position2);
		A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
	}

	public bool g()
	{
		foreach (en item in b)
		{
			if (item.l())
			{
				return false;
			}
		}
		return true;
	}

	public void h()
	{
		foreach (en item in b)
		{
			if (item.l())
			{
				item.j(A_0: false);
			}
		}
	}

	public bool i()
	{
		foreach (en item in b)
		{
			if (item.k())
			{
				return false;
			}
		}
		return true;
	}

	public void j()
	{
		foreach (en item in b)
		{
			if (item.k())
			{
				item.i(A_0: false);
			}
		}
	}

	public void k()
	{
		checked
		{
			int num2 = default(int);
			foreach (en item in b)
			{
				int num = item.g.LastIndexOf("-");
				num2 = Math.Max(num2, iz.c(item.g.Substring(num + 1)));
			}
			if (c > num2 + 1)
			{
				c = num2 + 1;
			}
		}
	}

	public void f(em A_0)
	{
		em em2 = A_0;
		em2.a = a;
		em2.b = new Collection<en>();
		checked
		{
			int num = b.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				en en2 = new en();
				b[num2].i(en2);
				em2.b.Add(en2);
			}
			em2.c = c;
			em2.d = d;
			em2.e = e;
			em2 = null;
		}
	}
}
