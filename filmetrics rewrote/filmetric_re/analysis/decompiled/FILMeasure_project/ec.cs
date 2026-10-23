using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

internal class ec
{
	public const string a = "077A16A2615CD2D784B5FA3A0221B724147E0DDA30A4542EEE58B1DD7C468389D6A31622AF8FC3451D389BAF1FB6F335379EEE31E2FFB4780193E626418060D0";

	public const string b = "q978u-h+sp=FRaBE";

	public static string c(bool A_0, string A_1, int A_2, int A_3)
	{
		HMACSHA1 hMACSHA = new HMACSHA1();
		hMACSHA.Key = ei.a("077A16A2615CD2D784B5FA3A0221B724147E0DDA30A4542EEE58B1DD7C468389D6A31622AF8FC3451D389BAF1FB6F335379EEE31E2FFB4780193E626418060D0");
		if (A_0)
		{
			return Convert.ToBase64String(hMACSHA.ComputeHash(Encoding.Unicode.GetBytes(A_1 + A_2.ToString(CultureInfo.InvariantCulture) + A_3.ToString(CultureInfo.InvariantCulture) + "q978u-h+sp=FRaBE")));
		}
		return Convert.ToBase64String(hMACSHA.ComputeHash(Encoding.Unicode.GetBytes(DateTime.Now.Ticks.ToString())));
	}

	public static string b(bool A_0, string A_1, int A_2, int A_3)
	{
		HMACSHA1 hMACSHA = new HMACSHA1();
		hMACSHA.Key = ei.a("077A16A2615CD2D784B5FA3A0221B724147E0DDA30A4542EEE58B1DD7C468389D6A31622AF8FC3451D389BAF1FB6F335379EEE31E2FFB4780193E626418060D0");
		if (A_0)
		{
			return Convert.ToBase64String(hMACSHA.ComputeHash(Encoding.Unicode.GetBytes(A_2.ToString(CultureInfo.InvariantCulture) + A_1 + A_3.ToString(CultureInfo.InvariantCulture) + "q978u-h+sp=FRaBE")));
		}
		return Convert.ToBase64String(hMACSHA.ComputeHash(Encoding.Unicode.GetBytes(DateTime.Now.Ticks.ToString())));
	}

	public static string a(bool A_0, string A_1, int A_2, int A_3)
	{
		HMACSHA1 hMACSHA = new HMACSHA1();
		hMACSHA.Key = ei.a("077A16A2615CD2D784B5FA3A0221B724147E0DDA30A4542EEE58B1DD7C468389D6A31622AF8FC3451D389BAF1FB6F335379EEE31E2FFB4780193E626418060D0");
		if (A_0)
		{
			return Convert.ToBase64String(hMACSHA.ComputeHash(Encoding.Unicode.GetBytes(A_2.ToString(CultureInfo.InvariantCulture) + A_1 + A_3.ToString(CultureInfo.InvariantCulture) + "q978u-h+sp=FRaBE")));
		}
		return Convert.ToBase64String(hMACSHA.ComputeHash(Encoding.Unicode.GetBytes(DateTime.Now.Ticks.ToString())));
	}

	public static string a(int A_0)
	{
		return Convert.ToBase64String(new HMACSHA1
		{
			Key = ei.a("077A16A2615CD2D784B5FA3A0221B724147E0DDA30A4542EEE58B1DD7C468389D6A31622AF8FC3451D389BAF1FB6F335379EEE31E2FFB4780193E626418060D0")
		}.ComputeHash(Encoding.Unicode.GetBytes(A_0.ToString(CultureInfo.InvariantCulture) + "q978u-h+sp=FRaBE")));
	}
}
