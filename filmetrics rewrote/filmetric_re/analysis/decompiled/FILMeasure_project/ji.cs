using System;
using System.Drawing;

internal class ji
{
	public class a
	{
		public bool a;
	}

	public class b
	{
		public Point a;
	}

	public static a[] a<a>(a[] A_0, int A_1, int A_2)
	{
		a[] array = new a[checked(A_2 - 1 + 1)];
		Array.Copy(A_0, A_1, array, 0, A_2);
		return array;
	}
}
