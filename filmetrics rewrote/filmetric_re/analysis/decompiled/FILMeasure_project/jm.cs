using System.Runtime.CompilerServices;

internal class jm
{
	public float[] a;

	[CompilerGenerated]
	private int b;

	public jm()
	{
		a = new float[9];
	}

	[SpecialName]
	[CompilerGenerated]
	public int f()
	{
		return b;
	}

	[SpecialName]
	[CompilerGenerated]
	public void f(int A_0)
	{
		b = A_0;
	}

	[SpecialName]
	public float g()
	{
		return a[2];
	}

	[SpecialName]
	public float h()
	{
		return a[3];
	}

	[SpecialName]
	public float i()
	{
		return a[4];
	}
}
