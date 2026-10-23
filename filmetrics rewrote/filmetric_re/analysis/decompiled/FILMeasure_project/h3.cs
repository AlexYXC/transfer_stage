using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class h3
{
	public enum a
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g,
		h,
		i
	}

	public enum b
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g,
		h,
		i,
		j
	}

	public enum c
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g
	}

	public enum d
	{
		a,
		b,
		c,
		d,
		e
	}

	public enum e
	{
		a,
		b,
		c,
		d
	}

	public enum f
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g,
		h
	}

	public const short a = 9;

	public const byte b = 1;

	public const byte c = 0;

	public const byte d = 2;

	public const byte e = 100;

	public const byte f = 101;

	public const byte g = 1;

	public const byte h = 2;

	public const byte i = 3;

	public const byte j = 4;

	public const byte k = 5;

	public const byte l = 6;

	public const byte m = 7;

	public const byte n = 8;

	public const byte o = 9;

	public const byte p = 10;

	public static int q;

	public static string a(byte A_0)
	{
		return A_0 switch
		{
			101 => "COMMAND_LOADED_TMCL_EEPROM", 
			1 => "WRONG_CHECKSUM", 
			2 => "INVALID_COMMAND", 
			3 => "WRONG_TYPE", 
			4 => "INVALID_VALUE", 
			5 => "CONFIG_EEPROM_LOCKED", 
			6 => "COMMAND_NOT_AVAILABLE", 
			7 => "NOT_A_MOTOR_PORT", 
			8 => "INVALID_RESPONS", 
			9 => "Response TIMEOUT", 
			_ => "Unknown Error", 
		};
	}

	public static void a(byte A_0, byte A_1, byte A_2, int A_3, ref byte[] A_4, byte A_5 = 0)
	{
		A_4 = new byte[9];
		A_4[0] = A_0;
		A_4[1] = A_1;
		A_4[2] = A_2;
		A_4[3] = A_5;
		a(A_3, A_4, 7, 4);
		A_4[8] = a(ref A_4);
	}

	public static byte a(object A_0, ref int A_1)
	{
		byte[] array = null;
		array = (byte[])A_0;
		if (array == null || array.GetUpperBound(0) != 8)
		{
			return 8;
		}
		short num = 0;
		short num2 = 0;
		checked
		{
			do
			{
				num = (short)unchecked(num + array[num2]);
				num2 = (short)unchecked(num2 + 1);
			}
			while (num2 <= 7);
			if (unchecked(num % 256) != array[8])
			{
				return 1;
			}
			if (unchecked((uint)array[4]) > 127u)
			{
				A_1 = -((unchecked((byte)(~array[7])) & 0xFF) + 256 * ((unchecked((byte)(~array[6])) & 0xFF) + 256 * ((unchecked((byte)(~array[5])) & 0xFF) + 256 * (unchecked((byte)(~array[4])) & 0xFF)))) - 1;
			}
			else
			{
				A_1 = array[7] + 256 * (array[6] + 256 * (array[5] + 256 * array[4]));
			}
			return array[2];
		}
	}

	public static void a(int A_0, byte[] A_1, int A_2, int A_3)
	{
		checked
		{
			if (A_0 < 0)
			{
				A_0 &= 0x7FFFFFFF;
				int num = A_3 + 1;
				for (int num2 = A_2; num2 >= num; num2 += -1)
				{
					A_1[num2] = (byte)unchecked(A_0 % 256);
					A_0 = unchecked(A_0 / 256);
				}
				A_1[A_3] = (byte)(A_0 | 0x80);
			}
			else
			{
				for (int num2 = A_2; num2 >= A_3; num2 += -1)
				{
					A_1[num2] = (byte)unchecked(A_0 % 256);
					A_0 = unchecked(A_0 / 256);
				}
			}
		}
	}

	public static byte a(ref byte[] A_0)
	{
		short num = 0;
		short num2 = 0;
		checked
		{
			do
			{
				num = (short)unchecked(num + A_0[num2]);
				num2 = (short)unchecked(num2 + 1);
			}
			while (num2 <= 7);
			return (byte)unchecked(num % 256);
		}
	}
}
