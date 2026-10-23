using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal abstract class es
{
	protected string a;

	public abstract void ad(es A_0);

	[SpecialName]
	public string al()
	{
		return a;
	}

	[SpecialName]
	public void t(string A_0)
	{
		a = A_0;
	}

	public abstract void aa(BinaryReader A_0);

	public abstract void x(BinaryWriter A_0);

	public abstract void ab(BinaryReader A_0);

	public abstract void y(BinaryWriter A_0);

	public abstract void ac(BinaryReader A_0, int A_1);

	protected abstract void z(BinaryWriter A_0);

	public static string u(string[] A_0, string A_1, int A_2)
	{
		int num = 1;
		if (t(A_0, A_1, A_2))
		{
			for (; t(A_0, A_1 + b3.a(num), A_2); num = checked(num + 1))
			{
			}
			return A_1 + b3.a(num);
		}
		return A_1;
	}

	public static bool t(string[] A_0, string A_1, int A_2)
	{
		int upperBound = A_0.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (num != A_2 && Operators.CompareString(A_0[num], A_1, TextCompare: false) == 0)
			{
				return true;
			}
		}
		return false;
	}
}
