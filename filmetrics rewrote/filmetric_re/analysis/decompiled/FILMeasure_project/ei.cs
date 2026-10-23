using System;

internal class ei
{
	public static byte[] a(string A_0)
	{
		checked
		{
			int num = unchecked(A_0.Length / 2) - 1;
			byte[] array = new byte[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				array[num3] = Convert.ToByte(A_0.Substring(num3 * 2, 2), 16);
			}
			return array;
		}
	}
}
