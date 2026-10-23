using System;
using System.Security.Cryptography;
using System.Text;

internal class eh
{
	public const string a = "9872E312E26141D48396F4D912D8E14E8521ED1B05659744420C24AC60DC6D4F653273F25112C55EF914A8AB2FB805A8F3E80DC45FD243DFA4D0889384ABF4AA";

	public const string b = "pAc5p8a!refre4a3";

	public static string a(bool A_0, string A_1)
	{
		HMACSHA1 hMACSHA = new HMACSHA1();
		hMACSHA.Key = ei.a("077A16A2615CD2D784B5FA3A0221B724147E0DDA30A4542EEE58B1DD7C468389D6A31622AF8FC3451D389BAF1FB6F335379EEE31E2FFB4780193E626418060D0");
		if (A_0)
		{
			return Convert.ToBase64String(hMACSHA.ComputeHash(Encoding.Unicode.GetBytes(A_1 + "pAc5p8a!refre4a3")));
		}
		return Convert.ToBase64String(hMACSHA.ComputeHash(Encoding.Unicode.GetBytes(DateTime.Now.Ticks.ToString())));
	}
}
