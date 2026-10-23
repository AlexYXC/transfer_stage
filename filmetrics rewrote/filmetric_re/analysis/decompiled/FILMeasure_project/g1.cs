using System.Collections.Generic;
using System.Runtime.CompilerServices;

internal class g1
{
	public List<g0> a;

	public List<object> b;

	public g1()
	{
		a = new List<g0>();
		b = new List<object>();
	}

	[SpecialName]
	public static bool d(g1 A_0, g1 A_1)
	{
		checked
		{
			switch (ix.a(A_0, A_1))
			{
			case ix.a.a:
				return false;
			case ix.a.b:
				return true;
			default:
			{
				List<g0> list = new List<g0>(A_0.a);
				List<g0> list2 = new List<g0>(A_1.a);
				for (int num = list.Count - 1; num >= 0; num += -1)
				{
					g0 a_ = list[num];
					foreach (g0 item in list2)
					{
						if (g0.d(a_, item))
						{
							list.RemoveAt(num);
							list2.Remove(item);
							break;
						}
					}
				}
				if (list.Count > 0 || list.Count != list2.Count)
				{
					return true;
				}
				return !g0.d(A_0.b, A_1.b);
			}
			}
		}
	}

	[SpecialName]
	public static bool c(g1 A_0, g1 A_1)
	{
		return !d(A_0, A_1);
	}
}
