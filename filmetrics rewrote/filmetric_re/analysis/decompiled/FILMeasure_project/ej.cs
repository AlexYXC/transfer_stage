using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class ej
{
	public enum a
	{
		a = 1,
		b,
		c,
		d
	}

	public enum b
	{
		a,
		b
	}

	private byte[] m_a;

	private int m_b;

	private int c;

	private Rectangle d;

	private b e;

	private int f;

	private float g;

	private float h;

	private const short i = 2;

	private const short j = 1;

	[SpecialName]
	public static int b()
	{
		return 1;
	}

	[SpecialName]
	public static int a()
	{
		return 4;
	}

	[SpecialName]
	public Image l()
	{
		MemoryStream memoryStream = new MemoryStream(this.m_a);
		Image result = Image.FromStream(memoryStream);
		memoryStream.Dispose();
		return result;
	}

	public void a(Image A_0, fz A_1)
	{
		if (A_0 == null)
		{
			this.m_a = null;
			this.m_b = 0;
			c = 0;
			return;
		}
		MemoryStream memoryStream = null;
		try
		{
			memoryStream = new MemoryStream();
			A_0.Save(memoryStream, ImageFormat.Jpeg);
			this.m_a = memoryStream.GetBuffer();
			this.m_b = A_0.Width;
			c = A_0.Height;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_a = null;
			this.m_b = 0;
			c = 0;
			A_1.c(fz.b.a, "Error in FIVideoImage.SetVideoImage", a_);
			ProjectData.ClearProjectError();
		}
		finally
		{
			memoryStream?.Dispose();
		}
	}

	[SpecialName]
	public int m()
	{
		return this.m_b;
	}

	[SpecialName]
	public int n()
	{
		return c;
	}

	[SpecialName]
	public bool o()
	{
		if (d.X == 0 && d.Y == 0 && d.Width == 0 && d.Height == 0)
		{
			return false;
		}
		return true;
	}

	[SpecialName]
	public Rectangle p()
	{
		return d;
	}

	[SpecialName]
	public void a(Rectangle A_0)
	{
		d = A_0;
	}

	[SpecialName]
	public b q()
	{
		return e;
	}

	[SpecialName]
	public void a(b A_0)
	{
		e = A_0;
	}

	[SpecialName]
	public int r()
	{
		return f;
	}

	[SpecialName]
	public void b(int A_0)
	{
		f = A_0;
	}

	[SpecialName]
	public float s()
	{
		return g;
	}

	[SpecialName]
	public void a(float A_0)
	{
		g = A_0;
	}

	[SpecialName]
	public float t()
	{
		return h;
	}

	[SpecialName]
	public void b(float A_0)
	{
		h = A_0;
	}

	public static void a(ej A_0, BinaryWriter A_1)
	{
		if (A_0 != null)
		{
			A_1.Write(value: true);
			A_0.a(A_1);
		}
		else
		{
			A_1.Write(value: false);
		}
	}

	public void a(BinaryWriter A_0)
	{
		long position = A_0.BaseStream.Position;
		A_0.Write(position);
		A_0.Write((short)2);
		A_0.Write((short)1);
		A_0.Write(f);
		A_0.Write(g);
		A_0.Write(h);
		A_0.Write(d.X);
		A_0.Write(d.Y);
		A_0.Write(d.Width);
		A_0.Write(d.Height);
		if (this.m_a == null)
		{
			A_0.Write(0);
		}
		else
		{
			A_0.Write(this.m_a.Length);
			A_0.Write(this.m_a);
		}
		A_0.Write((int)e);
		long position2 = A_0.BaseStream.Position;
		A_0.BaseStream.Seek(position, SeekOrigin.Begin);
		A_0.Write(position2);
		A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
	}

	public static ej a(BinaryReader A_0)
	{
		if (A_0.ReadBoolean())
		{
			ej obj = new ej();
			obj.b(A_0);
			return obj;
		}
		return null;
	}

	public void b(BinaryReader A_0)
	{
		long offset = A_0.ReadInt64();
		short num = A_0.ReadInt16();
		if (A_0.ReadInt16() > 2)
		{
			throw new ApplicationException("Incompatible File Format. Newer software version is required to read this file");
		}
		f = A_0.ReadInt32();
		g = A_0.ReadSingle();
		h = A_0.ReadSingle();
		d.X = A_0.ReadInt32();
		d.Y = A_0.ReadInt32();
		d.Width = A_0.ReadInt32();
		d.Height = A_0.ReadInt32();
		int num2 = A_0.ReadInt32();
		if (num2 > 0)
		{
			this.m_a = A_0.ReadBytes(num2);
			Image image = l();
			this.m_b = image.Width;
			c = image.Height;
			image = null;
		}
		else
		{
			this.m_a = null;
			this.m_b = 0;
			c = 0;
		}
		if (num >= 2)
		{
			e = (b)A_0.ReadInt32();
		}
		else
		{
			e = ej.b.a;
		}
		A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
	}

	public void a(Image A_0, Rectangle A_1, int A_2, float A_3, float A_4, b A_5, fz A_6)
	{
		a(A_0, A_6);
		d = A_1;
		f = A_2;
		g = A_3;
		h = A_4;
		e = A_5;
	}

	public static float a(int A_0)
	{
		return (a)A_0 switch
		{
			ej.a.a => 0.25f, 
			ej.a.b => 0.5f, 
			ej.a.c => 1f, 
			ej.a.d => 2f, 
			_ => 1f, 
		};
	}
}
