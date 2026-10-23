using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

internal class @if
{
	private ushort a;

	private ia b;

	protected ushort c;

	protected ushort d;

	protected void e(BinaryWriter A_0)
	{
		checked
		{
			A_0.Write((ushort)unchecked((uint)(a - 2)));
			A_0.Write(unchecked((byte)b.a));
			A_0.Write((byte)b.b.Length);
			A_0.Write(Encoding.ASCII.GetBytes(b.b));
			A_0.Write(b.c.ToOADate());
		}
	}

	protected void e(BinaryReader A_0)
	{
		b.a = (h8)A_0.ReadByte();
		byte count = A_0.ReadByte();
		byte[] bytes = A_0.ReadBytes(count);
		b.b = new string(Encoding.ASCII.GetChars(bytes));
		b.c = DateTime.FromOADate(A_0.ReadDouble());
	}

	protected void f(BinaryWriter A_0)
	{
		checked
		{
			c = (ushort)A_0.BaseStream.Length;
			ushort num = (ushort)unchecked((uint)(a - c));
			d = (ushort)unchecked((uint)(num - 2));
			A_0.Write(num);
		}
	}

	[SpecialName]
	public ushort f()
	{
		checked
		{
			return (ushort)unchecked((uint)(c + 2));
		}
	}

	[SpecialName]
	public ushort g()
	{
		return c;
	}

	[SpecialName]
	public ushort h()
	{
		return d;
	}

	[SpecialName]
	public ushort i()
	{
		checked
		{
			return (ushort)unchecked((uint)(a - c));
		}
	}

	public @if()
	{
		b = new ia();
	}

	public @if(ushort A_0, h8 A_1, string A_2, DateTime A_3)
	{
		b = new ia();
		a = A_0;
		b.a = A_1;
		b.b = A_2;
		b.c = A_3;
	}
}
