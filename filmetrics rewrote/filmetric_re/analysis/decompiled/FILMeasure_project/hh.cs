using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class hh
{
	private struct a
	{
		[VBFixedArray(4)]
		public byte[] a;

		public a(int A_0)
		{
			this = default(a);
			a = new byte[checked(A_0 + 1)];
		}
	}

	public static string b(ref string A_0)
	{
		byte[] bytes = new ASCIIEncoding().GetBytes(A_0);
		byte[] array = new SHA1CryptoServiceProvider().ComputeHash(bytes);
		string text = "";
		int num = Information.UBound(array);
		for (int num2 = 0; num2 <= num; num2 = checked(num2 + 1))
		{
			text += a(ref array[num2]);
		}
		return text;
	}

	public static string a(ref string A_0)
	{
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		byte[] bytes = aSCIIEncoding.GetBytes(A_0);
		byte[] bytes2 = new SHA1CryptoServiceProvider().ComputeHash(bytes);
		return aSCIIEncoding.GetString(bytes2);
	}

	private static string a(ref byte A_0)
	{
		string text = Conversion.Hex(A_0);
		if (Strings.Len(text) < 2)
		{
			text = "0" + text;
		}
		return text;
	}

	private static a d(ref a A_0, ref a A_1)
	{
		int try0000_dispatch = -1;
		checked
		{
			int num2 = default(int);
			a result = default(a);
			int num = default(int);
			int num3 = default(int);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						num2 = 1;
						result = new a(4);
						goto IL_0009;
					case 1801:
						{
							num = num2;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num + 1);
							num = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0009;
							case 3:
								goto IL_0010;
							case 4:
								goto IL_002c;
							case 5:
								goto IL_003e;
							case 6:
								goto IL_004a;
							case 7:
								goto IL_006c;
							case 8:
								goto IL_008b;
							case 9:
								goto IL_009d;
							case 10:
								goto IL_00aa;
							case 11:
								goto IL_00cd;
							case 12:
								goto IL_00ed;
							case 13:
								goto IL_0100;
							case 14:
								goto IL_010d;
							case 15:
								goto IL_0130;
							case 16:
								goto IL_0150;
							case 17:
								goto IL_0163;
							case 18:
								goto IL_0170;
							case 20:
								goto IL_0198;
							case 21:
								goto IL_01b5;
							case 22:
								goto IL_01c8;
							case 23:
								goto IL_01d5;
							case 25:
								goto IL_01fd;
							case 26:
								goto IL_021a;
							case 27:
								goto IL_022d;
							case 28:
								goto IL_023a;
							case 29:
								goto IL_025d;
							case 30:
								goto IL_027d;
							case 31:
								goto IL_0290;
							case 32:
								goto IL_029d;
							case 34:
								goto IL_02c5;
							case 35:
								goto IL_02e2;
							case 36:
								goto IL_02f5;
							case 37:
								goto IL_0302;
							case 39:
								goto IL_032a;
							case 40:
								goto IL_0347;
							case 41:
								goto IL_035a;
							case 42:
								goto IL_0367;
							case 43:
								goto IL_038a;
							case 44:
								goto IL_03aa;
							case 45:
								goto IL_03bd;
							case 46:
								goto IL_03ca;
							case 47:
								goto IL_03ed;
							case 48:
								goto IL_040d;
							case 49:
								goto IL_0420;
							case 50:
								goto IL_042d;
							case 52:
								goto IL_0455;
							case 53:
								goto IL_0472;
							case 54:
								goto IL_0485;
							case 55:
								goto IL_0492;
							case 57:
								goto IL_04ba;
							case 58:
								goto IL_04d7;
							case 59:
								goto IL_04ea;
							case 60:
								goto IL_04f7;
							case 61:
								goto IL_051a;
							case 62:
								goto IL_053a;
							case 63:
								goto IL_054d;
							case 64:
								goto IL_055a;
							case 66:
								goto IL_057f;
							case 67:
								goto IL_059c;
							case 68:
								goto IL_05ac;
							case 69:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 19:
							case 24:
							case 33:
							case 38:
							case 51:
							case 56:
							case 65:
							case 70:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_05ac:
						num2 = 68;
						Information.Err().Clear();
						break;
						IL_0009:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0010;
						IL_0010:
						num2 = 3;
						result.a[1] = (byte)unchecked((uint)(A_0.a[1] + A_1.a[1]));
						goto IL_002c;
						IL_002c:
						num2 = 4;
						if (Information.Err().Number == 6)
						{
							goto IL_003e;
						}
						goto IL_032a;
						IL_003e:
						num2 = 5;
						Information.Err().Clear();
						goto IL_004a;
						IL_004a:
						num2 = 6;
						result.a[1] = (byte)(A_0.a[1] + A_1.a[1] - 256);
						goto IL_006c;
						IL_006c:
						num2 = 7;
						result.a[2] = (byte)((byte)unchecked((uint)(A_0.a[2] + A_1.a[2])) + 1);
						goto IL_008b;
						IL_008b:
						num2 = 8;
						if (Information.Err().Number == 6)
						{
							goto IL_009d;
						}
						goto IL_01fd;
						IL_009d:
						num2 = 9;
						Information.Err().Clear();
						goto IL_00aa;
						IL_00aa:
						num2 = 10;
						result.a[2] = (byte)(A_0.a[2] + A_1.a[2] - 255);
						goto IL_00cd;
						IL_00cd:
						num2 = 11;
						result.a[3] = (byte)((byte)unchecked((uint)(A_0.a[3] + A_1.a[3])) + 1);
						goto IL_00ed;
						IL_00ed:
						num2 = 12;
						if (Information.Err().Number == 6)
						{
							goto IL_0100;
						}
						goto IL_0198;
						IL_0100:
						num2 = 13;
						Information.Err().Clear();
						goto IL_010d;
						IL_010d:
						num2 = 14;
						result.a[3] = (byte)(A_0.a[3] + A_1.a[3] - 255);
						goto IL_0130;
						IL_0130:
						num2 = 15;
						result.a[4] = (byte)((byte)unchecked((uint)(A_0.a[4] + A_1.a[4])) + 1);
						goto IL_0150;
						IL_0150:
						num2 = 16;
						if (Information.Err().Number != 6)
						{
							goto end_IL_0000_3;
						}
						goto IL_0163;
						IL_0163:
						num2 = 17;
						Information.Err().Clear();
						goto IL_0170;
						IL_0170:
						num2 = 18;
						result.a[4] = (byte)(A_0.a[4] + A_1.a[4] - 255);
						goto end_IL_0000_3;
						IL_0198:
						num2 = 20;
						result.a[4] = (byte)unchecked((uint)(A_0.a[4] + A_1.a[4]));
						goto IL_01b5;
						IL_01b5:
						num2 = 21;
						if (Information.Err().Number != 6)
						{
							goto end_IL_0000_3;
						}
						goto IL_01c8;
						IL_01c8:
						num2 = 22;
						Information.Err().Clear();
						goto IL_01d5;
						IL_01d5:
						num2 = 23;
						result.a[4] = (byte)(A_0.a[4] + A_1.a[4] - 256);
						goto end_IL_0000_3;
						IL_01fd:
						num2 = 25;
						result.a[3] = (byte)unchecked((uint)(A_0.a[3] + A_1.a[3]));
						goto IL_021a;
						IL_021a:
						num2 = 26;
						if (Information.Err().Number == 6)
						{
							goto IL_022d;
						}
						goto IL_02c5;
						IL_022d:
						num2 = 27;
						Information.Err().Clear();
						goto IL_023a;
						IL_023a:
						num2 = 28;
						result.a[3] = (byte)(A_0.a[3] + A_1.a[3] - 256);
						goto IL_025d;
						IL_025d:
						num2 = 29;
						result.a[4] = (byte)((byte)unchecked((uint)(A_0.a[4] + A_1.a[4])) + 1);
						goto IL_027d;
						IL_027d:
						num2 = 30;
						if (Information.Err().Number != 6)
						{
							goto end_IL_0000_3;
						}
						goto IL_0290;
						IL_0290:
						num2 = 31;
						Information.Err().Clear();
						goto IL_029d;
						IL_029d:
						num2 = 32;
						result.a[4] = (byte)(A_0.a[4] + A_1.a[4] - 255);
						goto end_IL_0000_3;
						IL_02c5:
						num2 = 34;
						result.a[4] = (byte)unchecked((uint)(A_0.a[4] + A_1.a[4]));
						goto IL_02e2;
						IL_02e2:
						num2 = 35;
						if (Information.Err().Number != 6)
						{
							goto end_IL_0000_3;
						}
						goto IL_02f5;
						IL_02f5:
						num2 = 36;
						Information.Err().Clear();
						goto IL_0302;
						IL_0302:
						num2 = 37;
						result.a[4] = (byte)(A_0.a[4] + A_1.a[4] - 256);
						goto end_IL_0000_3;
						IL_032a:
						num2 = 39;
						result.a[2] = (byte)unchecked((uint)(A_0.a[2] + A_1.a[2]));
						goto IL_0347;
						IL_0347:
						num2 = 40;
						if (Information.Err().Number == 6)
						{
							goto IL_035a;
						}
						goto IL_04ba;
						IL_035a:
						num2 = 41;
						Information.Err().Clear();
						goto IL_0367;
						IL_0367:
						num2 = 42;
						result.a[2] = (byte)(A_0.a[2] + A_1.a[2] - 256);
						goto IL_038a;
						IL_038a:
						num2 = 43;
						result.a[3] = (byte)((byte)unchecked((uint)(A_0.a[3] + A_1.a[3])) + 1);
						goto IL_03aa;
						IL_03aa:
						num2 = 44;
						if (Information.Err().Number == 6)
						{
							goto IL_03bd;
						}
						goto IL_0455;
						IL_03bd:
						num2 = 45;
						Information.Err().Clear();
						goto IL_03ca;
						IL_03ca:
						num2 = 46;
						result.a[3] = (byte)(A_0.a[3] + A_1.a[3] - 255);
						goto IL_03ed;
						IL_03ed:
						num2 = 47;
						result.a[4] = (byte)((byte)unchecked((uint)(A_0.a[4] + A_1.a[4])) + 1);
						goto IL_040d;
						IL_040d:
						num2 = 48;
						if (Information.Err().Number != 6)
						{
							goto end_IL_0000_3;
						}
						goto IL_0420;
						IL_0420:
						num2 = 49;
						Information.Err().Clear();
						goto IL_042d;
						IL_042d:
						num2 = 50;
						result.a[4] = (byte)(A_0.a[4] + A_1.a[4] - 255);
						goto end_IL_0000_3;
						IL_0455:
						num2 = 52;
						result.a[4] = (byte)unchecked((uint)(A_0.a[4] + A_1.a[4]));
						goto IL_0472;
						IL_0472:
						num2 = 53;
						if (Information.Err().Number != 6)
						{
							goto end_IL_0000_3;
						}
						goto IL_0485;
						IL_0485:
						num2 = 54;
						Information.Err().Clear();
						goto IL_0492;
						IL_0492:
						num2 = 55;
						result.a[4] = (byte)(A_0.a[4] + A_1.a[4] - 256);
						goto end_IL_0000_3;
						IL_04ba:
						num2 = 57;
						result.a[3] = (byte)unchecked((uint)(A_0.a[3] + A_1.a[3]));
						goto IL_04d7;
						IL_04d7:
						num2 = 58;
						if (Information.Err().Number == 6)
						{
							goto IL_04ea;
						}
						goto IL_057f;
						IL_04ea:
						num2 = 59;
						Information.Err().Clear();
						goto IL_04f7;
						IL_04f7:
						num2 = 60;
						result.a[3] = (byte)(A_0.a[3] + A_1.a[3] - 256);
						goto IL_051a;
						IL_051a:
						num2 = 61;
						result.a[4] = (byte)((byte)unchecked((uint)(A_0.a[4] + A_1.a[4])) + 1);
						goto IL_053a;
						IL_053a:
						num2 = 62;
						if (Information.Err().Number != 6)
						{
							goto end_IL_0000_3;
						}
						goto IL_054d;
						IL_054d:
						num2 = 63;
						Information.Err().Clear();
						goto IL_055a;
						IL_055a:
						num2 = 64;
						result.a[4] = (byte)(A_0.a[4] + A_1.a[4] - 255);
						goto end_IL_0000_3;
						IL_057f:
						num2 = 66;
						result.a[4] = (byte)unchecked((uint)(A_0.a[4] + A_1.a[4]));
						goto IL_059c;
						IL_059c:
						num2 = 67;
						if (Information.Err().Number != 6)
						{
							goto end_IL_0000_3;
						}
						goto IL_05ac;
						end_IL_0000_2:
						break;
					}
					num2 = 69;
					result.a[4] = (byte)(A_0.a[4] + A_1.a[4] - 256);
					break;
					end_IL_0000:;
				}
				catch (object obj) when ((obj is Exception) & (num3 != 0) & (num == 0))
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 1801;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0000_3:
				break;
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	private static a c(ref a A_0, ref a A_1)
	{
		a result = new a(4);
		short num = 1;
		do
		{
			result.a[num] = (byte)(A_0.a[num] | A_1.a[num]);
			checked
			{
				num = (short)unchecked(num + 1);
			}
		}
		while (num <= 4);
		return result;
	}

	private static a a(ref a A_0)
	{
		a result = new a(4);
		short num = 1;
		do
		{
			result.a[num] = (byte)(~A_0.a[num]);
			checked
			{
				num = (short)unchecked(num + 1);
			}
		}
		while (num <= 4);
		return result;
	}

	private static a b(ref a A_0, ref a A_1)
	{
		a result = new a(4);
		short num = 1;
		do
		{
			result.a[num] = (byte)(A_0.a[num] & A_1.a[num]);
			checked
			{
				num = (short)unchecked(num + 1);
			}
		}
		while (num <= 4);
		return result;
	}

	private static a a(ref a A_0, ref a A_1)
	{
		a result = new a(4);
		short num = 1;
		do
		{
			result.a[num] = (byte)(A_0.a[num] ^ A_1.a[num]);
			checked
			{
				num = (short)unchecked(num + 1);
			}
		}
		while (num <= 4);
		return result;
	}

	private static a a(ref a A_0, ref short A_1)
	{
		a result = new a(4);
		a a10 = new a(4);
		a10.a[1] = A_0.a[1];
		a10.a[2] = A_0.a[2];
		a10.a[3] = A_0.a[3];
		a10.a[4] = A_0.a[4];
		short num = A_1;
		checked
		{
			for (short num2 = 1; num2 <= num; num2 = (short)unchecked(num2 + 1))
			{
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				if (a10.a[1] >= 128)
				{
					a10.a[1] = (byte)unchecked((uint)(a10.a[1] - 128));
					flag2 = true;
				}
				a10.a[1] = (byte)unchecked((uint)(a10.a[1] * 2));
				if (a10.a[2] >= 128)
				{
					a10.a[2] = (byte)unchecked((uint)(a10.a[2] - 128));
					flag3 = true;
				}
				a10.a[2] = (byte)unchecked((uint)(a10.a[2] * 2));
				if (a10.a[3] >= 128)
				{
					a10.a[3] = (byte)unchecked((uint)(a10.a[3] - 128));
					flag4 = true;
				}
				a10.a[3] = (byte)unchecked((uint)(a10.a[3] * 2));
				if (a10.a[4] >= 128)
				{
					a10.a[4] = (byte)unchecked((uint)(a10.a[4] - 128));
					flag = true;
				}
				a10.a[4] = (byte)unchecked((uint)(a10.a[4] * 2));
				if (flag2)
				{
					a10.a[2] = (byte)unchecked((uint)(a10.a[2] + 1));
				}
				if (flag3)
				{
					a10.a[3] = (byte)unchecked((uint)(a10.a[3] + 1));
				}
				if (flag4)
				{
					a10.a[4] = (byte)unchecked((uint)(a10.a[4] + 1));
				}
				if (flag)
				{
					a10.a[1] = (byte)unchecked((uint)(a10.a[1] + 1));
				}
			}
			short num3 = 1;
			do
			{
				result.a[num3] = a10.a[num3];
				num3 = (short)unchecked(num3 + 1);
			}
			while (num3 <= 4);
			return result;
		}
	}

	public static long a()
	{
		string A_ = "abc";
		if (Operators.CompareString(b(ref A_), "A9993E364706816ABA3E25717850C26C9CD0D89D", TextCompare: false) != 0)
		{
			return -1L;
		}
		long result = default(long);
		return result;
	}
}
