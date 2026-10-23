using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

internal class ea
{
	public enum a
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g,
		h,
		i,
		j
	}

	public const string a = "80D0411D189F5E1E0D70023BCD40B35BCC180BD3EE158C78BFE131D9B5DDA36D4E9013A41117655135952088DF972B60DFED4410108587F97264C04603DC4AF5";

	public const string b = "3{:XORsE@f<8vB$O";

	public const string c = "6'hr5Q2z?uz,wV[\\";

	public static string a(string A_0, string A_1, a A_2, eb.b A_3)
	{
		return a(A_0, A_1, A_2, A_3, null);
	}

	public static string a(string A_0, string A_1, a A_2, eb.b A_3, string A_4)
	{
		HMACSHA1 obj = new HMACSHA1
		{
			Key = ei.a("80D0411D189F5E1E0D70023BCD40B35BCC180BD3EE158C78BFE131D9B5DDA36D4E9013A41117655135952088DF972B60DFED4410108587F97264C04603DC4AF5")
		};
		Encoding unicode = Encoding.Unicode;
		string[] obj2 = new string[6] { A_1, "3{:XORsE@f<8vB$O", A_0, null, null, null };
		int num = (int)A_2;
		obj2[3] = num.ToString(CultureInfo.InvariantCulture);
		num = (int)A_3;
		obj2[4] = num.ToString(CultureInfo.InvariantCulture);
		obj2[5] = A_4;
		return Convert.ToBase64String(obj.ComputeHash(unicode.GetBytes(string.Concat(obj2))));
	}

	public static string a(string A_0, string A_1, bool A_2)
	{
		HMACSHA1 hMACSHA = new HMACSHA1();
		hMACSHA.Key = ei.a("80D0411D189F5E1E0D70023BCD40B35BCC180BD3EE158C78BFE131D9B5DDA36D4E9013A41117655135952088DF972B60DFED4410108587F97264C04603DC4AF5");
		if (A_2)
		{
			return Convert.ToBase64String(hMACSHA.ComputeHash(Encoding.Unicode.GetBytes(A_1 + A_0 + "6'hr5Q2z?uz,wV[\\")));
		}
		return Convert.ToBase64String(hMACSHA.ComputeHash(Encoding.Unicode.GetBytes(A_0 + A_1 + "6'hr5Q2z?uz,wV[\\")));
	}

	public static string a(DateTime A_0)
	{
		return Convert.ToBase64String(new HMACSHA1
		{
			Key = ei.a("80D0411D189F5E1E0D70023BCD40B35BCC180BD3EE158C78BFE131D9B5DDA36D4E9013A41117655135952088DF972B60DFED4410108587F97264C04603DC4AF5")
		}.ComputeHash(Encoding.Unicode.GetBytes(checked((int)Math.Round(A_0.Subtract(new DateTime(2009, 8, 1)).TotalMinutes)).ToString(CultureInfo.InvariantCulture) + "3{:XORsE@f<8vB$O")));
	}
}
