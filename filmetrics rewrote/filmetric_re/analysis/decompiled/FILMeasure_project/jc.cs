internal class jc
{
	public bool a;

	public string[] b;

	public double[] c;

	public double[][] d;

	public double[][] e;

	public bool f;

	public bool g;

	public float[] h;

	public int[] i;

	public bool[] j;

	public bool k;

	public int l;

	public int m;

	public float[] n;

	public bool o;

	public string[] p;

	public string[] q;

	public int[] r;

	public bool s;

	public bool t()
	{
		bool[] array = j;
		for (int num = 0; num < array.Length; num = checked(num + 1))
		{
			if (!array[num])
			{
				return false;
			}
		}
		return true;
	}
}
