using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;

internal class cb
{
	protected he a;

	protected float b;

	protected Collection<hc> c;

	protected Collection<string> d;

	protected Collection<string> e;

	protected const int f = 1;

	[SpecialName]
	public int g()
	{
		return c.Count;
	}

	[SpecialName]
	public Collection<hc> h()
	{
		return c;
	}

	[SpecialName]
	public Collection<string> i()
	{
		return d;
	}

	[SpecialName]
	public Collection<string> j()
	{
		return e;
	}

	[SpecialName]
	public he k()
	{
		return a;
	}

	[SpecialName]
	public void g(he A_0)
	{
		a = A_0;
	}

	[SpecialName]
	public float l()
	{
		return b;
	}

	[SpecialName]
	public void g(float A_0)
	{
		b = A_0;
	}

	public cb()
	{
		c = new Collection<hc>();
		d = new Collection<string>();
		e = new Collection<string>();
	}

	public void g(hc A_0)
	{
		c.Add(A_0);
		d.Add(A_0.ep());
		e.Add(A_0.ca);
	}

	public void m()
	{
		c.Clear();
		d.Clear();
		e.Clear();
	}

	public void g(BinaryReader A_0)
	{
		int num = 0;
		int num2 = 0;
		long offset = A_0.ReadInt64();
		num2 = A_0.ReadInt32();
		num = A_0.ReadInt32();
		if (num <= 1)
		{
			g(A_0, num2);
			A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
			return;
		}
		throw new au("CompositeMeasResults maximum compatible block file version is " + 1 + " compatible version in file we are attempting to read is " + num);
	}

	public void g(BinaryWriter A_0)
	{
		long position = A_0.BaseStream.Position;
		A_0.Write(position);
		A_0.Write(1);
		A_0.Write(1);
		h(A_0);
		long position2 = A_0.BaseStream.Position;
		A_0.BaseStream.Seek(position, SeekOrigin.Begin);
		A_0.Write(position2);
		A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
	}

	public void g(BinaryReader A_0, int A_1)
	{
		a = new he(string.Empty, string.Empty, "");
		a.s(A_0);
		b = A_0.ReadSingle();
		g(ref d, A_0);
		g(ref e, A_0);
		A_0.ReadInt32();
	}

	protected void h(BinaryWriter A_0)
	{
		a.s(A_0);
		A_0.Write(b);
		g(d, A_0);
		g(e, A_0);
		A_0.Write(d.Count);
	}

	protected void g(Collection<string> A_0, BinaryWriter A_1)
	{
		if (A_0 != null && A_0.Count > 0)
		{
			A_1.Write(A_0.Count);
			{
				foreach (string item in A_0)
				{
					A_1.Write(item);
				}
				return;
			}
		}
		A_1.Write(0);
	}

	protected void g(ref Collection<string> A_0, BinaryReader A_1)
	{
		int num = A_1.ReadInt32();
		checked
		{
			if (num > 0)
			{
				if (A_0 == null)
				{
					A_0 = new Collection<string>();
				}
				else
				{
					A_0.Clear();
				}
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					A_0.Add(A_1.ReadString());
				}
			}
			else
			{
				A_0 = null;
			}
		}
	}
}
