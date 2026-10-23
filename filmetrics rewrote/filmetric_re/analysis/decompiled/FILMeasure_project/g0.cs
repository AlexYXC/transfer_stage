using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class g0
{
	public string a;

	public Guid b;

	public List<object> c;

	public g0()
	{
		c = new List<object>();
	}

	public static bool d(List<object> A_0, List<object> A_1)
	{
		List<object> list = new List<object>(A_0);
		List<object> list2 = new List<object>(A_1);
		checked
		{
			for (int num = list.Count - 1; num >= 0; num += -1)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(list[num]);
				foreach (object item in list2)
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(item);
					if (objectValue is ip.a)
					{
						if (objectValue2 is ip.a)
						{
							ip.a obj = (ip.a)objectValue;
							if (Operators.CompareString(Right: ((ip.a)objectValue2).n(), Left: obj.n(), TextCompare: false) == 0)
							{
								list.RemoveAt(num);
								list2.Remove(RuntimeHelpers.GetObjectValue(objectValue2));
								break;
							}
						}
					}
					else if (objectValue is h5.a && objectValue2 is h5.a)
					{
						h5.a obj2 = (h5.a)objectValue;
						if (Operators.CompareString(Right: ((h5.a)objectValue2).f(), Left: obj2.f(), TextCompare: false) == 0)
						{
							list.RemoveAt(num);
							list2.Remove(RuntimeHelpers.GetObjectValue(objectValue2));
							break;
						}
					}
				}
			}
			if (list.Count == 0)
			{
				return list2.Count == 0;
			}
			return false;
		}
	}

	[SpecialName]
	public static bool e(g0 A_0, g0 A_1)
	{
		switch (ix.a(A_0, A_1))
		{
		case ix.a.a:
			return false;
		case ix.a.b:
			return true;
		default:
			if (Operators.CompareString(A_0.a, A_1.a, TextCompare: false) != 0)
			{
				return true;
			}
			if (A_0.b != A_1.b)
			{
				return true;
			}
			return !d(A_0.c, A_1.c);
		}
	}

	[SpecialName]
	public static bool d(g0 A_0, g0 A_1)
	{
		return !e(A_0, A_1);
	}
}
