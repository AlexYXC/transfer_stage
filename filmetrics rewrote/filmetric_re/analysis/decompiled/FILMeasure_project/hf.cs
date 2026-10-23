using System;
using System.Runtime.CompilerServices;

internal class hf
{
	public bool a;

	public float b;

	public float c;

	public float d;

	[SpecialName]
	public float g()
	{
		if (jf.e(checked((int)Math.Round(c * 10f)), c * 10f))
		{
			return c;
		}
		return (float)(Math.Floor(c * 10f) / 10.0);
	}

	[SpecialName]
	public float h()
	{
		if (jf.e(checked((int)Math.Round(d * 10f)), d * 10f))
		{
			return d;
		}
		return (float)(Math.Floor(d * 10f) / 10.0);
	}
}
