using System.Collections.Generic;
using System.Runtime.CompilerServices;

internal class hz
{
	private List<object> a;

	public hz()
	{
		a = new List<object>();
	}

	public void b(object A_0)
	{
		a.Add(RuntimeHelpers.GetObjectValue(A_0));
	}

	public void c(object A_0)
	{
		a.Remove(RuntimeHelpers.GetObjectValue(A_0));
	}

	[SpecialName]
	public bool b()
	{
		return a.Count == 0;
	}
}
