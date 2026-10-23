using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[CompilerGenerated]
internal sealed class jo
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 3)]
	private struct a
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 28)]
	private struct b
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 32)]
	private struct c
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 36)]
	private struct d
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 152)]
	private struct e
	{
	}

	internal static readonly long a/* Not supported: data(00 00 01 00 01 00 01 00) */;

	internal static readonly d b/* Not supported: data(00 05 00 00 00 04 00 00 C0 03 00 00 00 03 00 00 D0 02 00 00 80 02 00 00 E0 01 00 00 40 01 00 00 F0 00 00 00) */;

	internal static readonly e c/* Not supported: data(EC 51 B8 1E 85 EB E9 3F E1 7A 14 AE 47 E1 EA 3F D7 A3 70 3D 0A D7 EB 3F CD CC CC CC CC CC EC 3F C3 F5 28 5C 8F C2 ED 3F B8 1E 85 EB 51 B8 EE 3F AE 47 E1 7A 14 AE EF 3F 52 B8 1E 85 EB 51 F0 3F CD CC CC CC CC CC F0 3F 48 E1 7A 14 AE 47 F1 3F C3 F5 28 5C 8F C2 F1 3F 3D 0A D7 A3 70 3D F2 3F B8 1E 85 EB 51 B8 F2 3F 33 33 33 33 33 33 F3 3F AE 47 E1 7A 14 AE F3 3F 29 5C 8F C2 F5 28 F4 3F A4 70 3D 0A D7 A3 F4 3F 1F 85 EB 51 B8 1E F5 3F 9A 99 99 99 99 99 F5 3F) */;

	internal static readonly a d/* Not supported: data(05 71 34) */;

	internal static readonly b e/* Not supported: data(01 00 00 00 0D 00 00 00 05 00 00 00 0B 00 00 00 08 00 00 00 06 00 00 00 02 00 00 00) */;

	internal static readonly c f/* Not supported: data(48 AF BC 9A F2 D7 7A 3E F1 68 E3 88 B5 F8 E4 3E FC A9 F1 D2 4D 62 50 3F 48 AF BC 9A F2 D7 7A 3E) */;

	internal static uint a(string A_0)
	{
		uint num = 2166136261u;
		if (A_0 != null)
		{
			for (int num2 = 0; num2 < A_0.Length; num2++)
			{
				num = (A_0[num2] ^ num) * 16777619;
			}
		}
		return num;
	}
}
