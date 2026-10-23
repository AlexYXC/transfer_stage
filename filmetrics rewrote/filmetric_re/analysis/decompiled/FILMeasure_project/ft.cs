using System.Runtime.CompilerServices;

internal class ft : fs
{
	private bool q;

	[SpecialName]
	public bool am()
	{
		return q;
	}

	[SpecialName]
	public void am(bool A_0)
	{
		if (A_0 != q)
		{
			q = A_0;
			a7();
		}
	}
}
