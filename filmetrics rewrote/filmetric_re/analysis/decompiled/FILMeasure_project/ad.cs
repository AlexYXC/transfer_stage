using System.Runtime.CompilerServices;

internal class ad
{
	private int a;

	public ad()
	{
		a = 0;
	}

	public void b()
	{
		checked
		{
			a++;
		}
	}

	public void c()
	{
		checked
		{
			if (a > 0)
			{
				a--;
			}
		}
	}

	[SpecialName]
	public bool d()
	{
		return a > 0;
	}
}
