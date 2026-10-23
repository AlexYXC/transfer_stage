using System.Net;
using System.Runtime.CompilerServices;

internal class bv
{
	private string a;

	private HttpWebRequest b;

	private bool c;

	public bv(string A_0, HttpWebRequest A_1, bool A_2)
	{
		a = A_0;
		b = A_1;
		c = A_2;
	}

	[SpecialName]
	public string d()
	{
		return a;
	}

	[SpecialName]
	public HttpWebRequest e()
	{
		return b;
	}

	[SpecialName]
	public bool f()
	{
		return c;
	}
}
