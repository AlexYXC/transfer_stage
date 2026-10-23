using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;

internal class en
{
	public hr a;

	public hc b;

	private bool c;

	private bool d;

	public string e;

	private string f;

	public string g;

	public Bitmap h;

	private const int m_i = 2;

	[SpecialName]
	public string j()
	{
		return f;
	}

	[SpecialName]
	public void i(string A_0)
	{
		f = A_0;
	}

	[SpecialName]
	public void i(bool A_0)
	{
		d = A_0;
		i();
	}

	[SpecialName]
	public bool k()
	{
		return d;
	}

	[SpecialName]
	public void j(bool A_0)
	{
		c = A_0;
		i();
		if (!A_0)
		{
			h = null;
		}
	}

	[SpecialName]
	public bool l()
	{
		return c;
	}

	public void i(BinaryReader A_0, fz A_1, eo A_2, hg.j A_3)
	{
		int num = 0;
		long offset = A_0.ReadInt64();
		A_0.ReadInt32();
		num = A_0.ReadInt32();
		if (num <= 2)
		{
			if (A_0.ReadBoolean())
			{
				if (a == null)
				{
					a = new hr(null);
				}
				a.l(ref A_0);
			}
			if (A_0.ReadBoolean())
			{
				if (b == null)
				{
					b = new hc();
				}
				b.cf(A_0, A_2, A_3);
				a = b.cn();
			}
			c = A_0.ReadBoolean();
			d = A_0.ReadBoolean();
			e = A_0.ReadString();
			f = A_0.ReadString();
			g = A_0.ReadString();
			if (A_0.ReadBoolean())
			{
				int count = A_0.ReadInt32();
				byte[] buffer = A_0.ReadBytes(count);
				MemoryStream stream = new MemoryStream(buffer);
				h = (Bitmap)Image.FromStream(stream);
			}
			else
			{
				h = null;
			}
			A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
			return;
		}
		throw new au("MeasReports maximum compatible block file version is " + 2 + " compatible version in file we are attempting to read is " + num);
	}

	public void i(BinaryWriter A_0)
	{
		long position = A_0.BaseStream.Position;
		A_0.Write(position);
		A_0.Write(2);
		A_0.Write(2);
		if (a != null && b == null)
		{
			A_0.Write(value: true);
			a.m(ref A_0);
		}
		else
		{
			A_0.Write(value: false);
		}
		if (b != null)
		{
			A_0.Write(value: true);
			b.cf(A_0);
		}
		else
		{
			A_0.Write(value: false);
		}
		A_0.Write(c);
		A_0.Write(d);
		if (e == null)
		{
			e = string.Empty;
		}
		A_0.Write(e);
		A_0.Write(f);
		A_0.Write(g);
		if (h != null && c)
		{
			A_0.Write(value: true);
			MemoryStream memoryStream = new MemoryStream();
			h.Save(memoryStream, ImageFormat.Png);
			byte[] buffer = memoryStream.GetBuffer();
			A_0.Write(buffer.Length);
			A_0.Write(buffer);
		}
		else
		{
			A_0.Write(value: false);
		}
		long position2 = A_0.BaseStream.Position;
		A_0.BaseStream.Seek(position, SeekOrigin.Begin);
		A_0.Write(position2);
		A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
	}

	private void i()
	{
		int num = g.IndexOf("<");
		if (num > 0)
		{
			g = g.Substring(0, checked(num - 1));
		}
		if (d && !c)
		{
			g += " <R>";
		}
		if (!d && c)
		{
			g += " <S>";
		}
		if (d && c)
		{
			g += " <R,S>";
		}
	}

	public void i(en A_0)
	{
		A_0.a = a;
		A_0.b = b;
		A_0.c = c;
		A_0.d = d;
		A_0.e = e;
		A_0.f = f;
		A_0.g = g;
		A_0.h = h;
		_ = null;
	}
}
