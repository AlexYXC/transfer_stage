using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class h4
{
	public enum a
	{
		a = 1,
		b,
		c,
		d,
		e,
		f,
		g,
		h,
		i
	}

	public const string a = "A";

	public const string b = "Å";

	public const string c = "Angstroms";

	public const string d = "Angstrom";

	public const string e = "nm";

	public const string f = "Nanometers";

	public const string g = "Nanometer";

	public const string h = "um";

	public const string i = "µm";

	public const string j = "μm";

	public const string k = "Microns";

	public const string l = "Micron";

	public const string m = "kA";

	public const string n = "kÅ";

	public const string o = "KiloAngstroms";

	public const string p = "KiloAngstrom";

	public const string q = "mils";

	public const string r = "mils";

	public const string s = "Mils";

	public const string t = "Mil";

	public const string u = "uin";

	public const string v = "µin";

	public const string w = "MicroInches";

	public const string x = "MicroInch";

	public const string y = "mm";

	public const string z = "Millimeters";

	public const string aa = "Millimeter";

	public const string ab = "in";

	public const string ac = "″";

	public const string ad = "Inches";

	public const string ae = "Inch";

	public const string af = "Custom: ";

	private a ag;

	private string ah;

	private string ai;

	private float aj;

	public h4(a A_0)
		: this(A_0, "Custom", "Cstm", 1f)
	{
	}

	public h4(a A_0, string A_1, string A_2, float A_3)
	{
		ag = A_0;
		ah = A_1;
		ai = A_2;
		aj = A_3;
	}

	public void e(ref h4 A_0)
	{
		if (A_0 == null)
		{
			A_0 = new h4(h4.a.b);
		}
		h4 obj = A_0;
		obj.ag = ag;
		obj.ah = ah;
		obj.ai = ai;
		obj.aj = aj;
		_ = null;
	}

	[SpecialName]
	public static bool f(h4 A_0, h4 A_1)
	{
		switch (ix.a(A_0, A_1))
		{
		case ix.a.a:
			return false;
		case ix.a.b:
			return true;
		default:
		{
			h4 h10 = A_0;
			if (h10.e() != A_1.e())
			{
				return true;
			}
			if (Operators.CompareString(h10.f(), A_1.f(), TextCompare: false) != 0)
			{
				return true;
			}
			if (Operators.CompareString(h10.g(), A_1.g(), TextCompare: false) != 0)
			{
				return true;
			}
			if (h10.h() != A_1.h())
			{
				return true;
			}
			h10 = null;
			return false;
		}
		}
	}

	[SpecialName]
	public static bool e(h4 A_0, h4 A_1)
	{
		return !f(A_0, A_1);
	}

	public bool l(h4 A_0)
	{
		return e(this, A_0);
	}

	[SpecialName]
	public a e()
	{
		return ag;
	}

	[SpecialName]
	public void e(a A_0)
	{
		if ((A_0 >= h4.a.a) & ((int)A_0 <= Enum.GetValues(typeof(a)).Length))
		{
			ag = A_0;
		}
		else
		{
			ag = h4.a.b;
		}
	}

	[SpecialName]
	public string f()
	{
		return ah;
	}

	[SpecialName]
	public void f(string A_0)
	{
		ah = A_0;
	}

	[SpecialName]
	public string g()
	{
		return ai;
	}

	[SpecialName]
	public void g(string A_0)
	{
		ai = A_0;
	}

	[SpecialName]
	public float h()
	{
		return aj;
	}

	[SpecialName]
	public void e(float A_0)
	{
		aj = A_0;
	}

	public string i()
	{
		return k(this);
	}

	public static string k(h4 A_0)
	{
		if (A_0 == null)
		{
			A_0 = new h4(h4.a.b);
		}
		return A_0.ag switch
		{
			h4.a.a => "Angstroms", 
			h4.a.b => "Nanometers", 
			h4.a.c => "Microns", 
			h4.a.d => "KiloAngstroms", 
			h4.a.e => "MicroInches", 
			h4.a.f => "Mils", 
			h4.a.g => "Millimeters", 
			h4.a.h => "Inches", 
			h4.a.i => "Custom: " + A_0.ah, 
			_ => throw new ax("Unknown units type"), 
		};
	}

	public string j()
	{
		return j(this);
	}

	public static string j(h4 A_0)
	{
		if (A_0 == null)
		{
			A_0 = new h4(h4.a.b);
		}
		return A_0.ag switch
		{
			h4.a.a => "Angstrom", 
			h4.a.b => "Nanometer", 
			h4.a.c => "Micron", 
			h4.a.d => "KiloAngstrom", 
			h4.a.e => "MicroInch", 
			h4.a.f => "Mil", 
			h4.a.g => "Millimeter", 
			h4.a.h => "Inch", 
			_ => throw new ax("Invalid Unit type in GetUnitSingularName"), 
		};
	}

	public string e(bool A_0 = false, bool A_1 = false)
	{
		return e(this, A_0, A_1);
	}

	public static string e(h4 A_0, bool A_1 = false, bool A_2 = false)
	{
		string text = null;
		if (A_0 == null)
		{
			A_0 = new h4(h4.a.b);
		}
		if (A_1)
		{
			text = k(A_0);
		}
		string text2;
		switch (A_0.ag)
		{
		case h4.a.a:
			text2 = "Å";
			break;
		case h4.a.b:
			text2 = "nm";
			break;
		case h4.a.c:
			text2 = "µm";
			break;
		case h4.a.d:
			text2 = "kÅ";
			break;
		case h4.a.e:
			text2 = "µin";
			break;
		case h4.a.f:
			return "mils";
		case h4.a.g:
			text2 = "mm";
			break;
		case h4.a.h:
			text2 = ((!A_1) ? ((!A_2) ? "in" : "″") : "in");
			break;
		case h4.a.i:
			text2 = A_0.ai;
			break;
		default:
			throw new ax("Invalid UnitDisplayString");
		}
		if (A_1)
		{
			return text + " (" + text2 + ")";
		}
		return text2;
	}

	public int k()
	{
		return i(this);
	}

	public static int i(h4 A_0)
	{
		if (A_0 == null)
		{
			A_0 = new h4(h4.a.b);
		}
		switch (A_0.ag)
		{
		case h4.a.a:
			return 1;
		case h4.a.b:
			return 2;
		case h4.a.c:
			return 5;
		case h4.a.d:
			return 4;
		case h4.a.e:
			return 3;
		case h4.a.f:
			return 6;
		case h4.a.g:
			return 8;
		case h4.a.h:
			return 9;
		case h4.a.i:
		{
			double num = A_0.h();
			if (num < 1.0)
			{
				return 0;
			}
			return checked(2 + (int)Math.Round(Math.Log10(num)));
		}
		default:
		{
			int result = default(int);
			return result;
		}
		}
	}

	public string l()
	{
		return h(this);
	}

	public static string h(h4 A_0)
	{
		if (A_0 == null)
		{
			A_0 = new h4(h4.a.b);
		}
		return A_0.ag switch
		{
			h4.a.a => "A", 
			h4.a.b => "nm", 
			h4.a.c => "um", 
			h4.a.d => "kA", 
			h4.a.e => "uin", 
			h4.a.f => "mils", 
			h4.a.g => "mm", 
			h4.a.h => "in", 
			h4.a.i => A_0.ai, 
			_ => string.Empty, 
		};
	}

	public double e(double A_0)
	{
		return Math.Round(A_0 * g(this) * 100.0) * 0.01;
	}

	public double m()
	{
		return g(this);
	}

	public static double g(h4 A_0)
	{
		return A_0.e() switch
		{
			h4.a.a => 0.1, 
			h4.a.b => 1.0, 
			h4.a.c => 1000.0, 
			h4.a.d => 100.0, 
			h4.a.e => 25.4, 
			h4.a.f => 25400.0, 
			h4.a.g => 1000000.0, 
			h4.a.h => 25400000.0, 
			h4.a.i => A_0.h(), 
			_ => 1.0, 
		};
	}

	public double n()
	{
		return f(this);
	}

	public static double f(h4 A_0)
	{
		if (A_0 == null)
		{
			A_0 = new h4(h4.a.b);
		}
		return A_0.ag switch
		{
			h4.a.a => 10.0, 
			h4.a.b => 1.0, 
			h4.a.c => 0.001, 
			h4.a.d => 0.01, 
			h4.a.e => 0.03937007874015748, 
			h4.a.f => 3.937007874015748E-05, 
			h4.a.g => 1E-06, 
			h4.a.h => 3.937007874015748E-08, 
			h4.a.i => 1f / A_0.h(), 
			_ => 1.0, 
		};
	}

	public static string e(h4 A_0)
	{
		if (A_0 == null)
		{
			A_0 = new h4(h4.a.b);
		}
		if (A_0.ag == h4.a.h)
		{
			return string.Empty;
		}
		return " ";
	}

	public double e(int A_0, double A_1)
	{
		return e(A_0, A_1, this);
	}

	public static double e(int A_0, double A_1, h4 A_2)
	{
		return e(A_0, A_1, A_2, 0, new h4(h4.a.b), A_5: true, 0);
	}

	public static double e(int A_0, double A_1, h4 A_2, short A_3, h4 A_4, bool A_5 = false, short A_6 = 0)
	{
		A_1 = A_4.e(A_1);
		checked
		{
			switch (A_0)
			{
			case 1:
			{
				double num2 = f(A_2);
				int num3 = i(A_2) + A_6;
				if (A_5)
				{
					if (num3 > 15)
					{
						num3 = 15;
					}
					return Math.Round(A_1 * num2, num3);
				}
				int num4 = default(int);
				if (A_1 > 0.0)
				{
					num4 = A_3 - (int)Math.Round(Math.Truncate(Math.Log10(Math.Abs(A_1) * num2))) - 1;
				}
				int a_ = ((num4 <= num3) ? A_3 : (A_3 - (num4 - num3)));
				return jf.a(A_1 * num2, a_);
			}
			case 2:
			{
				if (A_5)
				{
					return A_1;
				}
				double num = Math.Pow(10.0, A_6);
				return jf.a(Conversion.Int(1000.0 * num * A_1 + 0.5) * 0.001 / num, A_3);
			}
			default:
				return A_1;
			}
		}
	}

	public static a e(string A_0)
	{
		if (Operators.CompareString(A_0, "", TextCompare: false) == 0)
		{
			return h4.a.b;
		}
		uint num = jo.a(A_0);
		if (num <= 1613635087)
		{
			if (num <= 1094220446)
			{
				if (num != 400464207)
				{
					if (num != 1074472704)
					{
						if (num == 1094220446 && Operators.CompareString(A_0, "in", TextCompare: false) == 0)
						{
							return h4.a.h;
						}
					}
					else if (Operators.CompareString(A_0, "Å", TextCompare: false) == 0)
					{
						goto IL_01da;
					}
				}
				else if (Operators.CompareString(A_0, "µin", TextCompare: false) == 0)
				{
					goto IL_01ea;
				}
			}
			else if (num != 1388828431)
			{
				if (num != 1604572423)
				{
					if (num == 1613635087 && Operators.CompareString(A_0, "mm", TextCompare: false) == 0)
					{
						return h4.a.g;
					}
				}
				else if (Operators.CompareString(A_0, "µm", TextCompare: false) == 0)
				{
					goto IL_01e2;
				}
			}
			else if (Operators.CompareString(A_0, "uin", TextCompare: false) == 0)
			{
				goto IL_01ea;
			}
		}
		else if (num <= 1714686626)
		{
			if (num != 1614179540)
			{
				if (num != 1615018183)
				{
					if (num == 1714686626 && Operators.CompareString(A_0, "μm", TextCompare: false) == 0)
					{
						goto IL_01e2;
					}
				}
				else if (Operators.CompareString(A_0, "um", TextCompare: false) == 0)
				{
					goto IL_01e2;
				}
			}
			else if (Operators.CompareString(A_0, "nm", TextCompare: false) == 0)
			{
				return h4.a.b;
			}
		}
		else if (num <= 2156817930u)
		{
			if (num != 1748841777)
			{
				if (num == 2156817930u && Operators.CompareString(A_0, "mils", TextCompare: false) == 0)
				{
					return h4.a.f;
				}
			}
			else if (Operators.CompareString(A_0, "kA", TextCompare: false) == 0)
			{
				goto IL_01e6;
			}
		}
		else if (num != 3289118412u)
		{
			if (num == 3963384317u && Operators.CompareString(A_0, "kÅ", TextCompare: false) == 0)
			{
				goto IL_01e6;
			}
		}
		else if (Operators.CompareString(A_0, "A", TextCompare: false) == 0)
		{
			goto IL_01da;
		}
		if (A_0.Length > "Custom: ".Length && Operators.CompareString(A_0.Substring(0, "Custom: ".Length), "Custom: ", TextCompare: false) == 0)
		{
			return h4.a.i;
		}
		throw new ax("Invalid argument in Recipe.GetUnitCode. Supplied strUnitCode=" + A_0);
		IL_01e2:
		return h4.a.c;
		IL_01da:
		return h4.a.a;
		IL_01ea:
		return h4.a.e;
		IL_01e6:
		return h4.a.d;
	}

	public static void f(ComboBox A_0)
	{
		checked
		{
			if (A_0.SelectedItem != null)
			{
				Graphics graphics = A_0.CreateGraphics();
				try
				{
					int num = A_0.Width - A_0.ClientRectangle.Width;
					A_0.Width = jg.a(graphics, A_0.SelectedItem.ToString(), A_0.Font) + num + 23;
				}
				finally
				{
					graphics.Dispose();
				}
			}
		}
	}

	public static void e(ComboBox A_0)
	{
		Graphics graphics = A_0.CreateGraphics();
		int num2 = default(int);
		try
		{
			foreach (object item in A_0.Items)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(item);
				int num = jg.a(graphics, objectValue.ToString(), A_0.Font);
				if (num > num2)
				{
					num2 = num;
				}
			}
		}
		finally
		{
			graphics.Dispose();
		}
		int width = A_0.Width;
		A_0.Width = 20;
		A_0.DropDownWidth = num2;
		A_0.Width = width;
	}

	public void e(ref string A_0)
	{
		string[] obj = new string[6]
		{
			A_0,
			"UnitsMode(",
			jg.f(l()),
			"),",
			null,
			null
		};
		int num = (int)ag;
		obj[4] = num.ToString();
		obj[5] = "\r\n";
		A_0 = string.Concat(obj);
		A_0 = A_0 + "CustomUnitName, " + jg.f(ah) + "\r\n";
		A_0 = A_0 + "CustomUnitNameAbbr, " + jg.f(ai) + "\r\n";
		A_0 = A_0 + "CustomUnitNanometersPerCustomUnit," + Conversion.Str(aj) + "\r\n";
	}

	public static h4 e(ref int A_0, string A_1)
	{
		h4 obj = new h4(h4.a.b);
		string A_2 = string.Empty;
		i3.a(ref A_0, A_1, ref A_2);
		h4 h10 = obj;
		if (Versioned.IsNumeric(A_2))
		{
			h10.ag = (a)Conversions.ToInteger(A_2);
		}
		else
		{
			h10.ag = e(Strings.Trim(A_2));
		}
		i3.a(ref A_0, A_1, ref A_2);
		i3.a(ref A_0, A_1, ref A_2);
		h10.ah = jg.e(A_2);
		i3.a(ref A_0, A_1, ref A_2);
		i3.a(ref A_0, A_1, ref A_2);
		h10.ai = jg.e(A_2);
		i3.a(ref A_0, A_1, ref A_2);
		i3.a(ref A_0, A_1, ref A_2);
		h10.aj = Conversions.ToSingle(A_2);
		h10 = null;
		return obj;
	}

	public void e(BinaryWriter A_0)
	{
		A_0.Write((int)ag);
		A_0.Write(ah);
		A_0.Write(ai);
		A_0.Write(aj);
	}

	public static h4 e(BinaryReader A_0)
	{
		h4 obj = new h4(h4.a.b);
		obj.ag = (a)A_0.ReadInt32();
		obj.ah = A_0.ReadString();
		obj.ai = A_0.ReadString();
		obj.aj = A_0.ReadSingle();
		_ = null;
		return obj;
	}

	public static h4 e(jk.a A_0)
	{
		h4 h10 = new h4(h4.a.b);
		switch (A_0)
		{
		case jk.a.a:
			h10.e(h4.a.a);
			break;
		case jk.a.b:
			h10.e(h4.a.b);
			break;
		case jk.a.c:
			h10.e(h4.a.c);
			break;
		}
		return h10;
	}
}
