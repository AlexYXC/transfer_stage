using System;
using FIUsbIntLib;
using Microsoft.VisualBasic.CompilerServices;

internal class im
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
		i,
		j
	}

	public class b
	{
		public string a;

		public bool b;

		public a c;
	}

	private static byte[] i()
	{
		return new byte[16]
		{
			109, 17, 19, 1, 1, 0, 91, 176, 0, 8,
			8, 0, 50, 0, 50, 4
		};
	}

	private static byte[] h()
	{
		return new byte[16]
		{
			109, 17, 3, 1, 1, 0, 123, 176, 0, 0,
			0, 0, 50, 0, 50, 4
		};
	}

	private static byte[] g()
	{
		return new byte[16]
		{
			109, 17, 3, 1, 1, 0, 91, 176, 0, 0,
			0, 0, 50, 0, 50, 4
		};
	}

	private static byte[] f()
	{
		byte[] array = new byte[256];
		array[0] = 109;
		array[1] = 17;
		array[2] = 2;
		array[3] = 1;
		array[4] = 1;
		array[5] = 0;
		array[6] = 27;
		array[7] = 176;
		array[8] = 2;
		array[9] = 0;
		array[10] = 0;
		array[11] = 0;
		array[12] = 0;
		array[13] = 34;
		array[14] = 0;
		array[15] = 34;
		array[16] = 32;
		array[17] = 4;
		array[18] = 9;
		array[19] = 10;
		array[20] = 0;
		array[21] = 0;
		array[22] = 70;
		array[23] = 0;
		array[24] = 105;
		array[25] = 0;
		array[26] = 108;
		array[27] = 0;
		array[28] = 109;
		array[29] = 0;
		array[30] = 101;
		array[31] = 0;
		array[32] = 116;
		array[33] = 0;
		array[34] = 114;
		array[35] = 0;
		array[36] = 105;
		array[37] = 0;
		array[38] = 99;
		array[39] = 0;
		array[40] = 115;
		array[41] = 0;
		array[208] = 0;
		array[246] = 0;
		array[247] = 0;
		array[248] = 0;
		array[250] = 1;
		array[251] = 1;
		array[252] = 0;
		array[253] = 0;
		array[254] = 0;
		return array;
	}

	private static byte[] e()
	{
		byte[] array = new byte[256];
		array[0] = 109;
		array[1] = 17;
		array[2] = 35;
		array[3] = 1;
		array[4] = 1;
		array[5] = 0;
		array[6] = 27;
		array[7] = 184;
		array[8] = 3;
		array[9] = 2;
		array[10] = 0;
		array[11] = 0;
		array[12] = 0;
		array[13] = 50;
		array[14] = 0;
		array[15] = 50;
		array[16] = 32;
		array[17] = 4;
		array[18] = 9;
		array[19] = 14;
		array[20] = 10;
		array[21] = 0;
		array[22] = 70;
		array[23] = 0;
		array[24] = 105;
		array[25] = 0;
		array[26] = 108;
		array[27] = 0;
		array[28] = 109;
		array[29] = 0;
		array[30] = 101;
		array[31] = 0;
		array[32] = 116;
		array[33] = 0;
		array[34] = 114;
		array[35] = 0;
		array[36] = 105;
		array[37] = 0;
		array[38] = 99;
		array[39] = 0;
		array[40] = 115;
		array[41] = 0;
		array[42] = 32;
		array[43] = 0;
		array[44] = 73;
		array[45] = 0;
		array[46] = 110;
		array[47] = 0;
		array[48] = 99;
		array[49] = 0;
		array[84] = 51;
		array[85] = 0;
		array[86] = 45;
		array[87] = 0;
		array[88] = 80;
		array[89] = 0;
		array[90] = 111;
		array[91] = 0;
		array[92] = 114;
		array[93] = 0;
		array[94] = 116;
		array[95] = 0;
		array[96] = 32;
		array[97] = 0;
		array[98] = 72;
		array[99] = 0;
		array[100] = 117;
		array[101] = 0;
		array[102] = 98;
		array[103] = 0;
		array[246] = 0;
		array[247] = 0;
		array[248] = 0;
		array[250] = 8;
		array[251] = 0;
		array[252] = 0;
		array[253] = 0;
		array[254] = 0;
		return array;
	}

	private static byte[] d()
	{
		return new byte[256]
		{
			109, 17, 51, 1, 1, 0, 155, 56, 1, 8,
			0, 0, 0, 50, 0, 50, 32, 4, 9, 14,
			13, 0, 70, 0, 105, 0, 108, 0, 109, 0,
			101, 0, 116, 0, 114, 0, 105, 0, 99, 0,
			115, 0, 32, 0, 73, 0, 110, 0, 99, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 51, 0, 45, 0, 80, 0,
			111, 0, 114, 0, 116, 0, 32, 0, 72, 0,
			117, 0, 98, 0, 43, 0, 86, 0, 73, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			7, 0, 0, 0, 0, 0
		};
	}

	private static byte[] c()
	{
		byte[] array = new byte[256];
		array[0] = 109;
		array[1] = 17;
		array[2] = 7;
		array[3] = 1;
		array[4] = 1;
		array[5] = 0;
		array[6] = 27;
		array[7] = 176;
		array[8] = 2;
		array[9] = 0;
		array[10] = 0;
		array[11] = 0;
		array[12] = 0;
		array[13] = 250;
		array[14] = 0;
		array[15] = 250;
		array[16] = 32;
		array[17] = 4;
		array[18] = 9;
		array[19] = 14;
		array[20] = 10;
		array[21] = 0;
		array[22] = 70;
		array[23] = 0;
		array[24] = 105;
		array[25] = 0;
		array[26] = 108;
		array[27] = 0;
		array[28] = 109;
		array[29] = 0;
		array[30] = 101;
		array[31] = 0;
		array[32] = 116;
		array[33] = 0;
		array[34] = 114;
		array[35] = 0;
		array[36] = 105;
		array[37] = 0;
		array[38] = 99;
		array[39] = 0;
		array[40] = 115;
		array[41] = 0;
		array[42] = 32;
		array[43] = 0;
		array[44] = 73;
		array[45] = 0;
		array[46] = 110;
		array[47] = 0;
		array[48] = 99;
		array[49] = 0;
		array[84] = 55;
		array[85] = 0;
		array[86] = 45;
		array[87] = 0;
		array[88] = 80;
		array[89] = 0;
		array[90] = 111;
		array[91] = 0;
		array[92] = 114;
		array[93] = 0;
		array[94] = 116;
		array[95] = 0;
		array[96] = 32;
		array[97] = 0;
		array[96] = 72;
		array[97] = 0;
		array[96] = 117;
		array[97] = 0;
		array[96] = 98;
		array[97] = 0;
		array[246] = 0;
		array[247] = 0;
		array[248] = 0;
		array[250] = 53;
		array[251] = 0;
		array[252] = 0;
		array[253] = 0;
		array[254] = 0;
		return array;
	}

	private static byte[] b()
	{
		byte[] array = new byte[256];
		array[0] = 109;
		array[1] = 17;
		array[2] = 6;
		array[3] = 1;
		array[4] = 1;
		array[5] = 0;
		array[6] = 27;
		array[7] = 176;
		array[8] = 2;
		array[9] = 0;
		array[10] = 128;
		array[11] = 128;
		array[12] = 0;
		array[13] = 250;
		array[14] = 0;
		array[15] = 250;
		array[16] = 32;
		array[17] = 4;
		array[18] = 9;
		array[19] = 14;
		array[20] = 10;
		array[21] = 0;
		array[22] = 70;
		array[23] = 0;
		array[24] = 105;
		array[25] = 0;
		array[26] = 108;
		array[27] = 0;
		array[28] = 109;
		array[29] = 0;
		array[30] = 101;
		array[31] = 0;
		array[32] = 116;
		array[33] = 0;
		array[34] = 114;
		array[35] = 0;
		array[36] = 105;
		array[37] = 0;
		array[38] = 99;
		array[39] = 0;
		array[40] = 115;
		array[41] = 0;
		array[42] = 32;
		array[43] = 0;
		array[44] = 73;
		array[45] = 0;
		array[46] = 110;
		array[47] = 0;
		array[48] = 99;
		array[49] = 0;
		array[84] = 55;
		array[85] = 0;
		array[86] = 45;
		array[87] = 0;
		array[88] = 80;
		array[89] = 0;
		array[90] = 111;
		array[91] = 0;
		array[92] = 114;
		array[93] = 0;
		array[94] = 116;
		array[95] = 0;
		array[96] = 32;
		array[97] = 0;
		array[96] = 72;
		array[97] = 0;
		array[96] = 117;
		array[97] = 0;
		array[96] = 98;
		array[97] = 0;
		array[246] = 0;
		array[247] = 0;
		array[248] = 0;
		array[250] = 53;
		array[251] = 0;
		array[252] = 0;
		array[253] = 0;
		array[254] = 0;
		return array;
	}

	private static byte[] a()
	{
		byte[] array = new byte[256];
		array[0] = 85;
		array[1] = 109;
		array[2] = 17;
		array[3] = 4;
		array[4] = 1;
		array[5] = 176;
		array[6] = 0;
		array[7] = 130;
		array[8] = 15;
		array[9] = 0;
		array[10] = 34;
		array[11] = 152;
		array[12] = 0;
		array[13] = 0;
		array[14] = 0;
		array[15] = 0;
		byte[] array2 = Guid.NewGuid().ToByteArray();
		int num = 0;
		checked
		{
			do
			{
				array[16 + num] = array2[num];
				num++;
			}
			while (num <= 15);
			array[32] = 9;
			array[33] = 4;
			array[34] = 0;
			array[35] = 32;
			array[36] = 36;
			array[80] = 70;
			array[81] = 0;
			array[82] = 105;
			array[83] = 0;
			array[84] = 108;
			array[85] = 0;
			array[86] = 109;
			array[87] = 0;
			array[88] = 101;
			array[89] = 0;
			array[90] = 116;
			array[91] = 0;
			array[92] = 114;
			array[93] = 0;
			array[94] = 116;
			array[95] = 0;
			array[96] = 114;
			array[97] = 0;
			array[98] = 105;
			array[99] = 0;
			array[100] = 99;
			array[101] = 0;
			array[102] = 115;
			array[103] = 0;
			array[104] = 32;
			array[105] = 0;
			array[106] = 73;
			array[107] = 0;
			array[108] = 110;
			array[109] = 0;
			array[110] = 99;
			array[111] = 0;
			array[144] = 52;
			array[145] = 0;
			array[146] = 45;
			array[147] = 0;
			array[148] = 80;
			array[149] = 0;
			array[150] = 111;
			array[151] = 0;
			array[152] = 114;
			array[153] = 0;
			array[154] = 116;
			array[155] = 0;
			array[156] = 32;
			array[157] = 0;
			array[158] = 85;
			array[159] = 0;
			array[160] = 83;
			array[161] = 0;
			array[162] = 66;
			array[163] = 0;
			array[164] = 32;
			array[165] = 0;
			array[166] = 51;
			array[167] = 0;
			array[168] = 46;
			array[169] = 0;
			array[170] = 48;
			array[171] = 0;
			array[172] = 32;
			array[173] = 0;
			array[174] = 72;
			array[175] = 0;
			array[176] = 117;
			array[177] = 0;
			array[178] = 98;
			array[179] = 0;
			array[240] = 0;
			array[240] = 0;
			array[248] = 0;
			return array;
		}
	}

	private static bool a(byte[] A_0, byte[] A_1)
	{
		checked
		{
			int num = A_0.Length - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (A_0[num2] != A_1[num2])
				{
					return false;
				}
			}
			return true;
		}
	}

	public static string a(a A_0)
	{
		return A_0 switch
		{
			im.a.b => "USBController", 
			im.a.c => "F2", 
			im.a.d => "F42", 
			im.a.e => "HubOnly", 
			im.a.f => "Hub7Port+RS485", 
			im.a.g => "Hub7Port-NoRS485", 
			im.a.h => "UVLightSource2", 
			im.a.j => "VI Table", 
			im.a.i => "Hub4Port-OptProf", 
			_ => "Unknown", 
		};
	}

	public static a a(string A_0)
	{
		foreach (object value in Enum.GetValues(typeof(a)))
		{
			a a10 = (a)Conversions.ToInteger(value);
			if (Operators.CompareString(a(a10), A_0, TextCompare: false) == 0)
			{
				return a10;
			}
		}
		throw new ax("Unknown hub type");
	}

	public static b a(FIUsbController A_0)
	{
		b b10 = new b();
		byte[] array = new byte[256];
		int lErrCode = default(int);
		A_0?.ReadFromEEPROM(0, 80, 256, 0, ref array[0], ref lErrCode);
		if (A_0 == null || lErrCode != 0)
		{
			b10.a = "Missing";
			return b10;
		}
		b10.b = true;
		if (a(g(), array))
		{
			b10.c = im.a.b;
		}
		else if (a(c(), array))
		{
			b10.c = im.a.f;
		}
		else if (a(b(), array))
		{
			b10.c = im.a.g;
		}
		else if (a(f(), array))
		{
			b10.c = im.a.c;
		}
		else if (a(e(), array))
		{
			b10.c = im.a.h;
		}
		else if (a(d(), array))
		{
			b10.c = im.a.j;
		}
		else if (a(h(), array))
		{
			b10.c = im.a.d;
		}
		else if (a(i(), array))
		{
			b10.c = im.a.e;
		}
		else if (a(a(), array))
		{
			b10.c = im.a.i;
		}
		else
		{
			b10.c = im.a.a;
		}
		b10.a = a(b10.c);
		return b10;
	}

	public static void a(FIUsbController A_0, a A_1)
	{
		byte[] array = A_1 switch
		{
			im.a.c => f(), 
			im.a.h => e(), 
			im.a.j => d(), 
			im.a.f => c(), 
			im.a.g => b(), 
			im.a.b => g(), 
			im.a.d => h(), 
			im.a.e => i(), 
			im.a.i => a(), 
			_ => throw new ax("Invalid hub type"), 
		};
		int lErrCode = default(int);
		A_0.WriteToEEPROM(0, 80, checked((short)array.Length), 0, ref array[0], ref lErrCode);
		if (lErrCode != 0)
		{
			throw new ai("Hub Eeprom Write Failure. Error code=" + lErrCode);
		}
	}
}
