using System;

internal class ia
{
	public h8 a;

	public string b;

	public DateTime c;

	public ushort d;

	public ushort e;

	public ushort f;

	public ushort g;

	private const string m_h = "Generic String";

	private const string i = "CTM Ref";

	private const string j = "CTM Cal";

	private const string k = "PersistSpec";

	private const string l = "SpecLin";

	private const string m = "OrigTIntTime";

	public static string h(ia A_0, bool A_1)
	{
		string empty = string.Empty;
		empty = h(A_0.a) + ", ";
		if (A_1 || A_0.a != h8.b)
		{
			empty = empty + A_0.b + ", ";
		}
		if (A_0.a == h8.c)
		{
			return empty + A_0.c.ToLocalTime().ToString();
		}
		return empty + A_0.c.ToString();
	}

	public static string h(h8 A_0)
	{
		return A_0 switch
		{
			h8.a => "Generic String", 
			h8.b => "CTM Ref", 
			h8.c => "CTM Cal", 
			h8.d => "PersistSpec", 
			h8.e => "SpecLin", 
			h8.f => "OrigTIntTime", 
			_ => "None", 
		};
	}

	public ia()
	{
		a = default(h8);
	}
}
