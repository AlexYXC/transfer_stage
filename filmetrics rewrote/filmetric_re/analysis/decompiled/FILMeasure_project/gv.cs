using System.Runtime.CompilerServices;

internal class gv
{
	private bool a;

	private bool b;

	[SpecialName]
	public bool c()
	{
		return a;
	}

	[SpecialName]
	public bool d()
	{
		return b;
	}

	public void c(bool A_0, bool A_1)
	{
		a = A_0;
		b = A_1;
	}
}
