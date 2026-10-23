using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class jg
{
	private class a
	{
		public string a;

		public int b;

		public int c;

		public a(string A_0)
		{
			a = A_0;
		}
	}

	private static Regex m_a;

	private static Regex m_b;

	private static string m_c;

	private static Regex m_d;

	private static Regex m_e;

	private const string m_f = "$%*FIv2";

	private const float g = 0.0001f;

	private const float h = 1E-15f;

	static jg()
	{
		jg.m_a = new Regex("([^0-9]*)([0-9]+\\.[0-9]+\\.[0-9]+)");
		jg.m_b = new Regex("([^0-9]*)([0-9]+)");
		jg.m_c = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
		jg.m_d = new Regex("([^0-9]*[^0-9\\(\\x20\\t]-|[^0-9]*[^0-9\\" + jg.m_c + "\\-]|)(-?[0-9]+\\" + jg.m_c + "?[0-9]*|-?\\" + jg.m_c + "[0-9]+)");
		jg.m_e = new Regex("([^0-9]*[^0-9\\(\\x20\\t]-|[^0-9]*[^0-9\\" + jg.m_c + "\\-]|[-]|)(-?[0-9]+\\" + jg.m_c + "?[0-9]*|-?\\" + jg.m_c + "[0-9]+)");
	}

	public static int a(Graphics A_0, string A_1, Font A_2)
	{
		if (string.IsNullOrEmpty(A_1))
		{
			return 0;
		}
		StringFormat stringFormat = new StringFormat();
		RectangleF layoutRect = new RectangleF(0f, 0f, 1000f, 1000f);
		CharacterRange[] measurableCharacterRanges = new CharacterRange[1]
		{
			new CharacterRange(0, A_1.Length)
		};
		stringFormat.SetMeasurableCharacterRanges(measurableCharacterRanges);
		return checked((int)Math.Round(A_0.MeasureCharacterRanges(A_1, A_2, layoutRect, stringFormat)[0].GetBounds(A_0).Right + 1f));
	}

	private static Match a(a A_0)
	{
		a a10 = A_0;
		Match match = jg.m_a.Match(a10.a, a10.b);
		if (match.Success)
		{
			a10.c = 3;
		}
		checked
		{
			Match match2;
			if (a10.c <= 0)
			{
				match2 = ((a10.b != 0) ? jg.m_e.Match(a10.a, a10.b) : jg.m_d.Match(a10.a, a10.b));
			}
			else
			{
				match2 = jg.m_b.Match(a10.a, a10.b);
				if (match2.Groups[2].Index < match.Groups[2].Index)
				{
					match2 = jg.m_d.Match(a10.a, a10.b);
				}
				else
				{
					a10.c--;
				}
			}
			if (match2.Success)
			{
				a10.b = match2.Index + match2.Length;
			}
			a10 = null;
			return match2;
		}
	}

	public static int a(string A_0, string A_1)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			if (string.IsNullOrEmpty(A_1))
			{
				return string.CompareOrdinal(A_0, A_1);
			}
			return -1;
		}
		if (string.IsNullOrEmpty(A_1))
		{
			return 1;
		}
		string strA = A_0;
		string strB = A_1;
		int result = 0;
		a a_ = new a(A_0);
		a a_2 = new a(A_1);
		Match match = a(a_);
		Match match2 = a(a_2);
		checked
		{
			bool flag = default(bool);
			while (match.Success && match2.Success)
			{
				string value = match.Groups[1].Value;
				string value2 = match2.Groups[1].Value;
				int num = string.CompareOrdinal(value, value2);
				if (num != 0)
				{
					int length = value.Length;
					int length2 = value2.Length;
					if (length == length2)
					{
						return num;
					}
					int num2 = ((length <= length2) ? length : length2);
					if (num2 > 0)
					{
						num = string.CompareOrdinal(value.Substring(0, num2), value2.Substring(0, num2));
						if (num != 0)
						{
							return num;
						}
					}
					if (value.Length > value2.Length)
					{
						if (Operators.CompareString(Conversions.ToString(value[value2.Length]), "0", TextCompare: false) < 0)
						{
							return -1;
						}
						return 1;
					}
					if (Operators.CompareString(Conversions.ToString(value2[value.Length]), "0", TextCompare: false) < 0)
					{
						return 1;
					}
					return -1;
				}
				double num3 = double.Parse(match.Groups[2].Value) - double.Parse(match2.Groups[2].Value);
				if (num3 != 0.0)
				{
					if (num3 < 0.0)
					{
						return -1;
					}
					return 1;
				}
				if (!flag)
				{
					string value3 = match.Groups[2].Value;
					int length3 = value3.Length;
					string value4 = match2.Groups[2].Value;
					int length4 = value4.Length;
					flag = length3 != length4;
					if (flag)
					{
						int num4 = value3.IndexOf(jg.m_c);
						int num5 = ((num4 < 0) ? length3 : num4);
						int num6 = value4.IndexOf(jg.m_c);
						int num7 = ((num6 < 0) ? length4 : num6);
						result = ((num5 > num7) ? 1 : ((num5 >= num7) ? ((num4 >= 0) ? ((num6 < 0) ? 1 : ((value3.Length - num4 >= value4.Length - num6) ? 1 : (-1))) : (-1)) : (-1)));
					}
				}
				strA = A_0.Substring(match.Groups[2].Index + match.Groups[2].Length);
				strB = A_1.Substring(match2.Groups[2].Index + match2.Groups[2].Length);
				match = a(a_);
				match2 = a(a_2);
			}
			if (match.Success)
			{
				return string.CompareOrdinal(match.Groups[1].Value + "0", strB);
			}
			if (match2.Success)
			{
				return string.CompareOrdinal(strA, match2.Groups[1].Value + "0");
			}
			int num8 = string.CompareOrdinal(strA, strB);
			if (num8 == 0)
			{
				return result;
			}
			return num8;
		}
	}

	public static void a(string[] A_0)
	{
		Array.Sort(A_0, a);
	}

	public static string f(string A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		if (A_0.Contains("~'"))
		{
			return b("$%*FIv2" + A_0, "\"", "'");
		}
		return A_0.Replace("~", "~~").Replace("\"", "~'");
	}

	public static string e(string A_0)
	{
		if (A_0.StartsWith("$%*FIv2"))
		{
			return a(A_0.Substring("$%*FIv2".Length), "\"", "'");
		}
		A_0.Replace("~'", "\"");
		A_0.Replace("~~", "~");
		return A_0;
	}

	public static string b(string A_0, string A_1, string A_2)
	{
		string newValue = "~" + A_2;
		if (A_1.StartsWith(" "))
		{
			throw new ax("aString function argument charsToReplace cannot start with <space>");
		}
		if (A_1.Contains("~ "))
		{
			throw new ax("aString function argument charsToReplace cannot contain ~<space>");
		}
		if (A_2.StartsWith(" "))
		{
			throw new ax("aString function argument replacementChars cannot start with <space>");
		}
		if (A_2.Contains("~ "))
		{
			throw new ax("aString function argument replacementChars cannot contain ~<space>");
		}
		return A_0.Replace("~", "~ ").Replace(A_1, newValue);
	}

	public static string d(string A_0)
	{
		return b(b(A_0, "\r", "Cr"), "\n", "Lf");
	}

	public static string c(string A_0)
	{
		return a(a(A_0, "\n", "Lf"), "\r", "Cr");
	}

	public static string a(string A_0, string A_1, string A_2)
	{
		string oldValue = "~" + A_2;
		return A_0.Replace(oldValue, A_1).Replace("~ ", "~");
	}

	public static bool b(string A_0)
	{
		return Regex.IsMatch(A_0, "\\b\\d+(\\.\\d+)?\\b");
	}

	public static string a(float A_0)
	{
		return a(a(b3.a(A_0), A_0));
	}

	public static string a(double A_0)
	{
		return a(a(b3.a(A_0), A_0));
	}

	private static string a(string A_0, double A_1)
	{
		checked
		{
			if (A_1 < 9.999999747378752E-05 && A_1 >= 1.0000000036274937E-15)
			{
				int num = A_0.ToLower().LastIndexOf("e");
				int totalWidth = (int)Math.Round(Conversion.Val(A_0.Substring(num + 2))) - 1;
				string text = "";
				text = text.PadRight(totalWidth, '0');
				text = A_0.Substring(0, 1) + "." + text + A_0.Substring(1, num - 1);
				return a(text);
			}
			return a(A_0);
		}
	}

	private static string a(string A_0)
	{
		if (A_0.Trim().Trim('-').StartsWith("0"))
		{
			int num = A_0.IndexOf("0");
			return A_0.Substring(0, num) + A_0.Substring(checked(num + 1));
		}
		return A_0;
	}

	public static string a(short A_0)
	{
		checked
		{
			short num = (short)unchecked(A_0 / 100);
			short num2 = (short)unchecked(A_0 % 100 / 10);
			short num3 = (short)unchecked(A_0 % 10);
			if (num3 == 0)
			{
				return Strings.Trim(Conversion.Str(num)) + "." + Strings.Trim(Conversion.Str(num2));
			}
			return Strings.Trim(Conversion.Str(num)) + "." + Strings.Trim(Conversion.Str(num2)) + "." + Strings.Trim(Conversion.Str(num3));
		}
	}
}
