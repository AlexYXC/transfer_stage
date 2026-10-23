using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;

internal class el
{
	private string a;

	public Collection<em> b;

	public int c;

	private const int m_d = 1;

	[SpecialName]
	public string d()
	{
		return a;
	}

	[SpecialName]
	public void d(string A_0)
	{
		a = A_0;
	}

	public void d(BinaryReader A_0, fz A_1, eo A_2, hg.j A_3)
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
				int num2 = A_0.ReadInt32() - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					em em2 = new em();
					em2.f(A_0, A_1, A_2, A_3);
					b.Add(em2);
				}
				A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
				return;
			}
			throw new au("MeasReports maximum compatible block file version is " + 1 + " compatible version in file we are attempting to read is " + num);
		}
	}

	public void d(BinaryWriter A_0)
	{
		long position = A_0.BaseStream.Position;
		A_0.Write(position);
		A_0.Write(1);
		A_0.Write(1);
		A_0.Write(a);
		A_0.Write(b.Count);
		foreach (em item in b)
		{
			item.f(A_0);
		}
		long position2 = A_0.BaseStream.Position;
		A_0.BaseStream.Seek(position, SeekOrigin.Begin);
		A_0.Write(position2);
		A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
	}

	public void d(el A_0)
	{
		el el2 = A_0;
		el2.a = a;
		el2.b = new Collection<em>();
		checked
		{
			int num = b.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				em em2 = new em();
				b[num2].f(em2);
				el2.b.Add(em2);
			}
			el2.c = c;
			el2 = null;
		}
	}

	public el()
	{
		b = new Collection<em>();
		em em2 = new em();
		em2.f("A");
		b.Add(em2);
	}
}
