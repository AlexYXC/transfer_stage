using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Filmetrics.FIMatFileDBService;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

internal class jb
{
	public enum a
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g
	}

	public enum b
	{
		a,
		b,
		c
	}

	public enum c
	{
		a = 1,
		b,
		c,
		d,
		e,
		f,
		g,
		h,
		i,
		j,
		k,
		l,
		m,
		n,
		o
	}

	public enum d : short
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
		j,
		k,
		l,
		m
	}

	public enum e : short
	{
		a,
		b,
		c,
		d,
		e
	}

	public enum f : short
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g
	}

	public enum g : short
	{
		a,
		b,
		c,
		d,
		e
	}

	private class h
	{
		public string a;

		public DateTime b;

		public string c;

		public h(string A_0, string A_1, DateTime A_2)
		{
			a = A_0;
			b = A_2;
			c = A_1;
		}
	}

	private class i
	{
		private f a;

		public string b;

		public string c;

		public List<string> d;

		[SpecialName]
		public f e()
		{
			return a;
		}

		public i(f A_0)
		{
			d = new List<string>();
			a = A_0;
		}
	}

	private class j
	{
		public string a;

		public string b;

		public g c;

		public string[] d;

		public List<i> e;

		public j()
		{
			e = new List<i>();
		}

		public i f(f A_0)
		{
			bool A_1 = false;
			return f(A_0, ref A_1);
		}

		public i f(f A_0, ref bool A_1)
		{
			i result = null;
			A_1 = false;
			foreach (i item in e)
			{
				if (item.e() == A_0)
				{
					A_1 = true;
					return item;
				}
				if (item.e() == jb.f.a)
				{
					result = item;
				}
			}
			return result;
		}

		public string f(string A_0, f A_1)
		{
			string text = "\t";
			string text2 = null;
			if (d != null && d.Length > 0)
			{
				text2 = d[0];
				int upperBound = d.GetUpperBound(0);
				for (int num = 1; num <= upperBound; num = checked(num + 1))
				{
					text2 = text2 + ", " + d[num];
				}
			}
			i i10 = f(A_1);
			string text3 = i10.b;
			string text4 = i10.c;
			if (text3 != null && !string.IsNullOrEmpty(text3))
			{
				text3 = text3.Replace("\r\n", " ").Replace("\t", string.Empty);
			}
			if (text4 != null && !string.IsNullOrEmpty(text4))
			{
				text4 = text4.Replace("\r\n", " ").Replace("\t", string.Empty);
			}
			string[] obj = new string[13]
			{
				A_0, text, a, text, b, text, text3, text, null, null,
				null, null, null
			};
			short num2 = (short)c;
			obj[8] = num2.ToString();
			obj[9] = text;
			obj[10] = text2;
			obj[11] = text;
			obj[12] = text4;
			string text5 = string.Concat(obj);
			if (i10.d == null)
			{
				text5 = text5 + text + "0";
			}
			else
			{
				text5 = text5 + text + i10.d.Count.ToString(CultureInfo.InvariantCulture);
				foreach (string item in i10.d)
				{
					string text6 = item;
					if (text6 != null && !string.IsNullOrEmpty(text6))
					{
						text6 = text6.Replace("\r\n", " ").Replace("\t", string.Empty);
					}
					text5 = text5 + text + text6;
				}
			}
			i10 = null;
			return text5;
		}
	}

	public class k
	{
		public fz a;

		public bool b;

		public bool c;

		public bool d;

		public bool e;

		public bool f;

		public LicenseLevel g;

		public string h;

		public eb.a i;

		public bool j;

		public eb.b k;

		public bool l;

		public Point m;

		public k(fz A_0, bool A_1, bool A_2, bool A_3, bool A_4, bool A_5, LicenseLevel A_6, string A_7, eb.a A_8, bool A_9, eb.b A_10, bool A_11, Point A_12)
		{
			a = A_0;
			b = A_1;
			c = A_2;
			d = A_3;
			e = A_4;
			f = A_5;
			g = A_6;
			h = A_7;
			i = A_8;
			j = A_9;
			k = A_10;
			l = A_11;
			m = A_12;
		}
	}

	private enum l
	{
		a,
		b,
		c,
		d
	}

	public const string a = ".fmrrr";

	public const string b = ".rrr";

	public const string c = ".ttt";

	public const string d = ".fmttt";

	public const string e = ".fitdr";

	public const string f = ".fibnx";

	public const string g = "Binary mixture File (*.fibnx)";

	public const string h = ".fitnx";

	public const string i = "Text mixture File (*.fitnx)";

	public const string j = ".fibnk";

	public const string k = "Binary n&k File (*.fibnk)";

	public const string l = ".fitnk";

	public const string m = "Text n&k File (*.fitnk)";

	public const string n = ".fmnnn";

	public const string o = "Binary n File (*.fmnnn)";

	public const string p = ".fmkkk";

	public const string q = ".mat";

	public const string r = "Woollam n&k File (*.mat)";

	public const string s = ".nnn";

	public const string t = "Text n File (*.nnn)";

	public const string u = ".kkk";

	public const string v = "All Filmetrics Material Files";

	public const string w = "All Filmetrics Unmixed Material Files";

	public const string x = "All Filmetrics RRR Files";

	public const string y = "Binary RRR File (*.fmrrr)";

	public const string z = "Text RRR File (*.rrr)";

	public const string aa = "Dual R File (*.fitdr)";

	public const string ab = "Air";

	public const float ac = 1.00027f;

	public const string ad = ".fivrq";

	public const string ae = "Generic, n=";

	public const string af = "Insulator";

	public const string ag = " <Universal>";

	public const int ah = 0;

	public const int ai = 10000;

	public const string aj = "#Public#";

	private const string m_ak = "~#^%*}{";

	private const string m_al = ",";

	private const int am = 16;

	public const int an = 102;

	public const int ao = 1836;

	private const string ap = "Material";

	private static string aq;

	private const double ar = 0.1;

	private const double @as = 50.0;

	private const double at = 0.0;

	private const double au = 50.0;

	public const int av = 20000;

	private const int aw = 3;

	private const int ax = 1;

	private const string ay = "File Information, ";

	private const int az = 1;

	private const int a0 = 1;

	private const string a1 = "yoRuOln*f&Xcd,pdR[a~{L!p='_W\\jJ:";

	private const string a2 = "s2CD?c-iTk=)*rDb";

	private const string a3 = "Synonym";

	private const string a4 = "Keyword";

	private const string a5 = "Similar Material";

	private const string a6 = "Data Source";

	private const string a7 = "Access Type";

	private const string a8 = "Unencrypted Min. Wave";

	private const string a9 = "Unencrypted Max. Wave";

	private const string ba = "Unencrypted Perm. Min. Wave";

	private const string bb = "Unencrypted Perm. Max. Wave";

	private const string bc = "Recommended Equip.";

	private const string bd = "Link HTML";

	private const string be = "\\MatWebDB\\";

	private const string bf = "Unencrypted\\";

	private const string bg = "Unencrypted with Permission\\";

	private const string bh = "Encrypted\\";

	private const string bi = "GraphData\\";

	private const string bj = "ReflCalcMatFiles\\";

	private const string bk = "Unreleased";

	private const string bl = "Unencrypted All";

	private const string bm = "Unencrypted All With Permission";

	private const string bn = "Encrypted Customer With Permission";

	private const string bo = "CustomerSpecific";

	private const string bp = "Invariant";

	private const string bq = "German";

	private const string br = "French";

	private const string bs = "Spanish";

	private const string bt = "Japanese";

	private const string bu = "Chinese";

	private const string bv = "Korean";

	public static string d(d A_0)
	{
		return A_0 switch
		{
			jb.d.a => "Synonym", 
			jb.d.b => "Keyword", 
			jb.d.c => "Similar Material", 
			jb.d.d => "Data Source", 
			jb.d.e => "Access Type", 
			jb.d.f => "Unencrypted Min. Wave", 
			jb.d.g => "Unencrypted Max. Wave", 
			jb.d.h => "Unencrypted Perm. Min. Wave", 
			jb.d.i => "Unencrypted Perm. Max. Wave", 
			jb.d.l => "Recommended Equip.", 
			jb.d.j => "Link HTML", 
			_ => throw new ApplicationException("Unknown attribute type in UtilMaterial.AttributeDescrFromType"), 
		};
	}

	public static d al(string A_0)
	{
		switch (jo.a(A_0))
		{
		case 2176743722u:
			if (Operators.CompareString(A_0, "Synonym", TextCompare: false) != 0)
			{
				break;
			}
			return jb.d.a;
		case 3454125988u:
			if (Operators.CompareString(A_0, "Keyword", TextCompare: false) != 0)
			{
				break;
			}
			return jb.d.b;
		case 853240935u:
			if (Operators.CompareString(A_0, "Similar Material", TextCompare: false) != 0)
			{
				break;
			}
			return jb.d.c;
		case 858938618u:
			if (Operators.CompareString(A_0, "Data Source", TextCompare: false) != 0)
			{
				break;
			}
			return jb.d.d;
		case 3671607417u:
			if (Operators.CompareString(A_0, "Access Type", TextCompare: false) != 0)
			{
				break;
			}
			return jb.d.e;
		case 1300900853u:
			if (Operators.CompareString(A_0, "Unencrypted Min. Wave", TextCompare: false) != 0)
			{
				break;
			}
			return jb.d.f;
		case 1739870895u:
			if (Operators.CompareString(A_0, "Unencrypted Max. Wave", TextCompare: false) != 0)
			{
				break;
			}
			return jb.d.g;
		case 2304908133u:
			if (Operators.CompareString(A_0, "Unencrypted Perm. Min. Wave", TextCompare: false) != 0)
			{
				break;
			}
			return jb.d.h;
		case 3694321087u:
			if (Operators.CompareString(A_0, "Unencrypted Perm. Max. Wave", TextCompare: false) != 0)
			{
				break;
			}
			return jb.d.i;
		case 1106258426u:
			if (Operators.CompareString(A_0, "Recommended Equip.", TextCompare: false) != 0)
			{
				break;
			}
			return jb.d.l;
		case 844152198u:
			if (Operators.CompareString(A_0, "Link HTML", TextCompare: false) != 0)
			{
				break;
			}
			return jb.d.j;
		}
		throw new ApplicationException("Unknown attribute description in UtilMaterial.AttributeTypeFromDescr");
	}

	public static string b(g A_0)
	{
		return A_0 switch
		{
			jb.g.a => "Unreleased", 
			jb.g.b => "Unencrypted All", 
			jb.g.c => "Unencrypted All With Permission", 
			jb.g.d => "Encrypted Customer With Permission", 
			jb.g.e => "CustomerSpecific", 
			_ => throw new ApplicationException("Unknown attribute type in UtilMaterial.AttributeAccessTypeValueDescrFromValue"), 
		};
	}

	public static g ak(string A_0)
	{
		bool A_1 = false;
		return a(A_0, A_1: true, ref A_1);
	}

	public static bool aj(string A_0)
	{
		bool A_1 = default(bool);
		a(A_0, A_1: false, ref A_1);
		return A_1;
	}

	private static g a(string A_0, bool A_1, ref bool A_2)
	{
		A_2 = true;
		switch (A_0)
		{
		case "Unreleased":
			return jb.g.a;
		case "Unencrypted All":
			return jb.g.b;
		case "Unencrypted All With Permission":
			return jb.g.c;
		case "Encrypted Customer With Permission":
			return jb.g.d;
		case "CustomerSpecific":
			return jb.g.e;
		default:
			if (A_1)
			{
				throw new ApplicationException("Unknown attribute description in UtilMaterial.AttributeAccessTypeValueFromValueDescr");
			}
			A_2 = false;
			return jb.g.a;
		}
	}

	public static bool c(d A_0)
	{
		if (A_0 != jb.d.g && A_0 != jb.d.f && A_0 != jb.d.i)
		{
			return A_0 == jb.d.h;
		}
		return true;
	}

	public static string b(f A_0)
	{
		return A_0 switch
		{
			jb.f.a => string.Empty, 
			jb.f.b => "DE", 
			jb.f.c => "FR", 
			jb.f.d => "ES", 
			jb.f.e => "JP", 
			jb.f.f => "ZH", 
			jb.f.g => "KO", 
			_ => throw new ApplicationException("Unknown culture attribute type in UtilMaterial.AttributeCultureCodeFromAttrCulture"), 
		};
	}

	public static string a(f A_0)
	{
		return A_0 switch
		{
			jb.f.a => "Invariant", 
			jb.f.b => "German", 
			jb.f.c => "French", 
			jb.f.d => "Spanish", 
			jb.f.e => "Japanese", 
			jb.f.f => "Chinese", 
			jb.f.g => "Korean", 
			_ => throw new ApplicationException("Unknown culture attribute type in UtilMaterial.AttributeCultureFromFIDescr"), 
		};
	}

	public static f ai(string A_0)
	{
		switch (jo.a(A_0))
		{
		case 1457557791u:
			if (Operators.CompareString(A_0, "Invariant", TextCompare: false) != 0)
			{
				break;
			}
			return jb.f.a;
		case 286263347u:
			if (Operators.CompareString(A_0, "German", TextCompare: false) != 0)
			{
				break;
			}
			return jb.f.b;
		case 2092788901u:
			if (Operators.CompareString(A_0, "French", TextCompare: false) != 0)
			{
				break;
			}
			return jb.f.c;
		case 3088679515u:
			if (Operators.CompareString(A_0, "Spanish", TextCompare: false) != 0)
			{
				break;
			}
			return jb.f.d;
		case 2483826186u:
			if (Operators.CompareString(A_0, "Japanese", TextCompare: false) != 0)
			{
				break;
			}
			return jb.f.e;
		case 2115103848u:
			if (Operators.CompareString(A_0, "Chinese", TextCompare: false) != 0)
			{
				break;
			}
			return jb.f.f;
		case 2909847329u:
			if (Operators.CompareString(A_0, "Korean", TextCompare: false) != 0)
			{
				break;
			}
			return jb.f.g;
		}
		throw new ApplicationException("Unknown culture description in UtilMaterial.AttributeCultureFromFIDescr");
	}

	public static bool b(d A_0)
	{
		if (A_0 != jb.d.d && A_0 != jb.d.b)
		{
			return A_0 == jb.d.j;
		}
		return true;
	}

	public static e a(d A_0)
	{
		return A_0 switch
		{
			jb.d.d => jb.e.b, 
			jb.d.b => jb.e.a, 
			jb.d.j => jb.e.c, 
			_ => throw new ApplicationException("Unknown StringAttrType in UtilMaterial.AttrLocalizedTypeFromType"), 
		};
	}

	public static d a(e A_0)
	{
		return A_0 switch
		{
			jb.e.b => jb.d.d, 
			jb.e.a => jb.d.b, 
			jb.e.c => jb.d.j, 
			_ => throw new ApplicationException("Unknown StringAttrLocalizedTypes in UtilMaterial.AttrTypeFromLocalizedType"), 
		};
	}

	public static f ah(string A_0)
	{
		return (f)short.Parse(A_0.Substring(0, A_0.IndexOf(",")));
	}

	public static e ag(string A_0)
	{
		string text = A_0.Substring(checked(A_0.IndexOf(",") + 1));
		return (e)short.Parse(text.Substring(0, text.IndexOf(",")));
	}

	public static string af(string A_0)
	{
		checked
		{
			string text = A_0.Substring(A_0.IndexOf(",") + 1);
			return text.Substring(text.IndexOf(",") + 1);
		}
	}

	public static string a(f A_0, e A_1, string A_2)
	{
		string[] array = new string[5];
		short num = (short)A_0;
		array[0] = num.ToString(CultureInfo.InvariantCulture);
		array[1] = ",";
		num = (short)A_1;
		array[2] = num.ToString(CultureInfo.InvariantCulture);
		array[3] = ",";
		array[4] = A_2;
		return string.Concat(array);
	}

	public static void a(eb.b A_0, string A_1, ref string A_2, ref c A_3, ref string A_4)
	{
		A_4 = "*" + A_1;
		switch (A_0)
		{
		case eb.b.a:
			switch (A_1.ToLower())
			{
			case ".fibnk":
				A_2 = "Binary n&k File (*.fibnk)";
				A_3 = jb.c.c;
				break;
			case ".fibnx":
				A_2 = "Binary mixture File (*.fibnx)";
				A_3 = jb.c.a;
				break;
			case ".fitnx":
				A_2 = "Text mixture File (*.fitnx)";
				A_3 = jb.c.b;
				break;
			case ".fitnk":
				A_2 = "Text n&k File (*.fitnk)";
				A_3 = jb.c.d;
				break;
			case ".fmnnn":
				A_2 = "Binary n File (*.fmnnn)";
				A_3 = jb.c.f;
				break;
			case ".nnn":
				A_2 = "Text n File (*.nnn)";
				A_3 = jb.c.g;
				break;
			default:
				throw new ApplicationException("Unknown file type");
			}
			break;
		case eb.b.b:
			switch (A_1.ToLower())
			{
			case ".fmrrr":
				A_2 = "Binary RRR File (*.fmrrr)";
				A_3 = jb.c.l;
				break;
			case ".rrr":
				A_2 = "Text RRR File (*.rrr)";
				A_3 = jb.c.m;
				break;
			case ".fitdr":
				A_2 = "Dual R File (*.fitdr)";
				A_3 = jb.c.o;
				break;
			default:
				throw new ApplicationException("Unknown file type");
			}
			break;
		case eb.b.c:
			throw new ApplicationException("Unknown file type");
		default:
			throw new ApplicationException("Unknown file type");
		}
	}

	public static b2 a(b A_0, bool A_1, bool A_2, bool A_3, string A_4)
	{
		b2 b10 = new b2();
		if (!string.IsNullOrEmpty(A_4))
		{
			string A_5 = null;
			string A_6 = null;
			c A_7 = default(c);
			a(eb.b.a, A_4, ref A_5, ref A_7, ref A_6);
			b10.a(A_5, A_6, (int)A_7);
			switch (A_4.ToLower())
			{
			case ".fibnk":
				b10.a("Binary n&k File (*.fibnk)", "*.fibnk", 3);
				break;
			case ".fibnx":
				b10.a("Binary mixture File (*.fibnx)", "*.fibnx", 1);
				break;
			case ".fitnx":
				b10.a("Text mixture File (*.fitnx)", "*.fitnx", 2);
				break;
			case ".fitnk":
				b10.a("Text n&k File (*.fitnk)", "*.fitnk", 4);
				break;
			case ".fmnnn":
				b10.a("Binary n File (*.fmnnn)", "*.fmnnn", 6);
				break;
			case ".nnn":
				b10.a("Text n File (*.nnn)", "*.nnn", 7);
				break;
			}
		}
		else
		{
			switch (A_0)
			{
			case jb.b.a:
				if (A_1)
				{
					b10.a("Text mixture File (*.fitnx)", "*.fitnx", 2);
					if (A_2)
					{
						b10.a("Binary mixture File (*.fibnx)", "*.fibnx", 1);
					}
					break;
				}
				if (A_3)
				{
					b10.a("Text n&k File (*.fitnk)", "*.fitnk", 4);
				}
				b10.a("Text n File (*.nnn)", "*.nnn", 7);
				if (A_2)
				{
					if (A_3)
					{
						b10.a("Binary n&k File (*.fibnk)", "*.fibnk", 3);
						b10.a("Woollam n&k File (*.mat)", "*.mat", 5);
					}
					b10.a("Binary n File (*.fmnnn)", "*.fmnnn", 6);
				}
				break;
			case jb.b.b:
				b10.a("Text k File (*.kkk)", "*.kkk", 9);
				if (A_2)
				{
					b10.a("Binary k File (*.fmkkk)", "*.fmkkk", 8);
				}
				break;
			default:
				throw new ArgumentOutOfRangeException("Invalid file family type");
			}
		}
		return b10;
	}

	public static string a(fz A_0, f1 A_1, f4 A_2, bool A_3, LicenseLevel A_4, bool A_5, bool A_6, bool A_7, bool A_8, bool A_9, string A_10, eb.b A_11, string A_12, bool A_13, bool A_14, Point A_15, ref eb.a A_16, ref bool A_17, ref bool A_18)
	{
		string A_19 = A_10;
		c4 c10 = null;
		SaveFileDialog saveFileDialog = null;
		b2 b10 = null;
		int num;
		if (i())
		{
			if (!A_8 && A_9)
			{
				num = ((!string.IsNullOrEmpty(A_12)) ? 1 : 0);
				if (num == 0)
				{
					goto IL_0034;
				}
			}
			else
			{
				num = 1;
			}
			c10 = new c4();
			goto IL_0086;
		}
		num = 0;
		goto IL_0034;
		IL_0034:
		saveFileDialog = new SaveFileDialog();
		A_17 = false;
		SaveFileDialog saveFileDialog2 = saveFileDialog;
		saveFileDialog2.Title = "Save Material File";
		saveFileDialog2.InitialDirectory = d();
		saveFileDialog2.FileName = A_10;
		b10 = a(jb.b.a, A_14, A_7, A_8, A_12);
		saveFileDialog2.Filter = b10.b();
		saveFileDialog2.OverwritePrompt = false;
		_ = null;
		A_16 = eb.a.a;
		goto IL_0086;
		IL_0086:
		if (num != 0)
		{
			if (A_3)
			{
				new dn().a(A_1.uf(), A_11, A_15);
			}
			c10.a(A_0, A_1, A_2, c4.a.b, A_7, A_8, A_14, A_9, A_1.uf(), A_4, A_11, A_14, A_3, A_12, A_13, ref A_19, ref A_16, ref A_17, A_5, A_6, ref A_18);
			if (c10.DialogResult == DialogResult.Cancel)
			{
				return "";
			}
		}
		else
		{
			k k2 = (k)(saveFileDialog.Tag = new k(A_0, A_9, A_5, A_6, A_1.ui(), A_1.ug(), A_4, A_1.uf(), A_16, A_3, A_11, A_18, A_15));
			saveFileDialog.FileOk += a;
			if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
			{
				return "";
			}
			int filterIndex = saveFileDialog.FilterIndex;
			A_19 = b10.a(saveFileDialog.FileName, filterIndex);
			A_18 = k2.l;
		}
		return A_19;
	}

	public static void a(object A_0, CancelEventArgs A_1)
	{
		SaveFileDialog saveFileDialog = (SaveFileDialog)A_0;
		k k2 = (k)saveFileDialog.Tag;
		if (a(k2.a, saveFileDialog.FileName, k2.b, k2.c, k2.d, k2.e, k2.f, k2.g, k2.h, k2.i, k2.j, k2.k, ref k2.l, k2.m))
		{
			A_1.Cancel = false;
		}
		else
		{
			A_1.Cancel = true;
		}
		k2 = null;
	}

	public static bool a(fz A_0, string A_1, bool A_2, bool A_3, bool A_4, bool A_5, bool A_6, LicenseLevel A_7, string A_8, eb.a A_9, bool A_10, eb.b A_11, ref bool A_12, Point A_13)
	{
		Collection<string> A_14 = null;
		bool flag = true;
		eb.a A_16 = default(eb.a);
		if (A_10)
		{
			dk dk2 = new dk();
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(A_1);
			LicenseLevel A_15 = LicenseLevel.Unlicensed;
			bool A_17 = default(bool);
			bool A_18 = default(bool);
			bool A_19 = default(bool);
			dk2.a(A_8, A_11, fileNameWithoutExtension, A_13, ref A_15, ref A_16, ref A_17, ref A_18, ref A_19, A_0);
			if (dk2.DialogResult != DialogResult.OK || !A_18)
			{
				if (A_19)
				{
					fe.b(A_0, "File save process aborted due to failure to communicate with Online Material Database Server.", A_13);
				}
				else if (dk2.DialogResult == DialogResult.Cancel)
				{
					fe.b(A_0, "File save process aborted due to cancelled Database Service Communications.", A_13);
				}
				else
				{
					fe.b(A_0, "File save process aborted due to rejection of Database Service query.", A_13);
				}
				return false;
			}
			flag = false;
			A_12 = A_17 && A_16 != eb.a.a && A_16 != eb.a.g;
		}
		else
		{
			A_12 = i() && i3.a(h() + "\\" + Path.GetFileName(A_1), d(A_11), ref A_14);
		}
		bool flag2 = string.Compare(Path.GetDirectoryName(A_1), d(), ignoreCase: true) == 0;
		bool flag3 = string.Compare(Path.GetDirectoryName(A_1), h(), ignoreCase: true) == 0;
		if (A_5 && !a(Path.GetFileNameWithoutExtension(A_1), A_0, A_13))
		{
			return false;
		}
		checked
		{
			if ((A_12 && (flag2 || flag3)) || i3.a(A_1, d(A_11), ref A_14))
			{
				SystemSounds.Exclamation.Play();
				string a_2;
				if (A_12 && (flag2 || flag3))
				{
					bool flag4 = default(bool);
					if (A_10)
					{
						flag4 = A_16 == eb.a.f && A_7 < LicenseLevel.ShippingReadWrite;
					}
					if (!A_6 || A_7 <= LicenseLevel.ReadOnly || flag || !A_10 || flag4)
					{
						string a_;
						if (flag3)
						{
							if (flag4)
							{
								string A_20 = "FileReplaceErrorMatDBShipping";
								a_ = hu.a(ref A_20);
							}
							else
							{
								string A_20 = "FileReplaceErrorMatDB";
								a_ = hu.a(ref A_20);
							}
						}
						else if (flag4)
						{
							string A_20 = "FileReplaceErrorMatDBDeleteShippingFmt";
							a_ = string.Format(hu.a(ref A_20), Path.GetFileNameWithoutExtension(A_1));
						}
						else if (A_10 || A_7 <= LicenseLevel.ReadOnly)
						{
							string A_20 = "FileReplaceErrorMatDBDeleteFmt";
							a_ = string.Format(hu.a(ref A_20), Path.GetFileNameWithoutExtension(A_1));
						}
						else
						{
							string A_20 = "FileReplaceErrorMatDBDeleteCommFailFmt";
							a_ = string.Format(hu.a(ref A_20), Path.GetFileNameWithoutExtension(A_1));
						}
						fe.b(A_0, a_, A_13);
						return false;
					}
					if (flag3)
					{
						string A_20 = "FileReplaceWarningMatDBFmt";
						a_2 = string.Format(hu.a(ref A_20), Path.GetFileNameWithoutExtension(A_1));
					}
					else
					{
						string A_20 = "FileReplaceWarningMatDBDeleteFmt";
						a_2 = string.Format(hu.a(ref A_20), Path.GetFileNameWithoutExtension(A_1));
					}
				}
				else
				{
					string text = "";
					string text2 = "";
					int num = A_14.Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						text += Path.GetFileName(A_14[num2]);
						if (num2 != A_14.Count - 1)
						{
							text += ", ";
						}
					}
					if (n(A_1))
					{
						text2 = Path.GetFileName(A_1);
					}
					else
					{
						string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(A_1);
						text2 = ((!A_3 || A_5) ? (fileNameWithoutExtension2 + i(A_1)) : (fileNameWithoutExtension2 + ".fmnnn"));
						if (A_2)
						{
							text2 = ((!A_4 || A_5) ? (text2 + ", " + fileNameWithoutExtension2 + g(A_1)) : (text2 + ", " + fileNameWithoutExtension2 + ".fmkkk"));
						}
					}
					if (A_14.Count > 1)
					{
						string A_20 = "FileReplaceWarningMultWithMultFmt2";
						a_2 = string.Format(hu.a(ref A_20), text, text2);
					}
					else if (Operators.CompareString(text.ToLower(), text2.ToLower(), TextCompare: false) == 0)
					{
						string A_20 = "OverwritePromptFmt1";
						a_2 = string.Format(hu.a(ref A_20), text2);
					}
					else
					{
						string A_20 = "FileReplaceWarningSingleWithMultFmt2";
						a_2 = string.Format(hu.a(ref A_20), text, text2);
					}
				}
				return fe.b(ref A_0, a_2, "Warning", "Yes", "No", A_13);
			}
			return true;
		}
	}

	public static string a(bool A_0)
	{
		if (A_0)
		{
			return "Material File (*.fibnk, *.fitnk, *.mat)|*.fibnk;*.fitnk;*.mat|Index File|*.nnn;*.fmnnn|k File|*.kkk;*.fmkkk";
		}
		return "Material File|*.fitnk|Index File|*.nnn|k File|*.kkk";
	}

	public static string m()
	{
		return "Reference File (*.rrr, *.fmrrr)|*.rrr;*.fmrrr";
	}

	public static string[] d(eb.b A_0)
	{
		return A_0 switch
		{
			eb.b.a => new string[8] { ".nnn", ".kkk", ".fmnnn", ".fmkkk", ".fitnk", ".fibnk", ".fibnx", ".fitnx" }, 
			eb.b.b => new string[3] { ".fmrrr", ".rrr", ".fitdr" }, 
			eb.b.c => new string[2] { ".fmttt", ".ttt" }, 
			_ => throw new ApplicationException("Unknown file type in UtilMaterial.MaterialFileExtensions"), 
		};
	}

	public static string[] c(eb.b A_0)
	{
		string[] array = d(A_0);
		int upperBound = array.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			array[num] = "*" + array[num];
		}
		return array;
	}

	public static bool ae(string A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		string text = A_0.ToLower();
		return text.EndsWith(".rrr") || text.EndsWith(".fmrrr");
	}

	public static bool ad(string A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		string text = A_0.ToLower();
		return text.EndsWith(".ttt") || text.EndsWith(".fmttt");
	}

	public static bool ac(string A_0)
	{
		return A_0?.ToLower().EndsWith(".fitdr") ?? false;
	}

	public static eb.b ab(string A_0)
	{
		if (n(A_0) || j(A_0) || k(A_0))
		{
			return eb.b.a;
		}
		if (ae(A_0) || ac(A_0))
		{
			return eb.b.b;
		}
		if (ad(A_0))
		{
			return eb.b.c;
		}
		throw new ApplicationException("Unknown file type");
	}

	public static string[] b(eb.b A_0)
	{
		return A_0 switch
		{
			eb.b.a => new string[6] { ".nnn", ".fmnnn", ".fitnk", ".fibnk", ".fibnx", ".fitnx" }, 
			eb.b.b => new string[3] { ".fmrrr", ".rrr", ".fitdr" }, 
			eb.b.c => new string[2] { ".fmttt", ".ttt" }, 
			_ => throw new ApplicationException("Unknown file type in UtilMaterial.MaterialFileBaseFileWildcardExtensions"), 
		};
	}

	public static string[] a(eb.b A_0)
	{
		string[] array = b(A_0);
		int upperBound = array.GetUpperBound(0);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			array[num] = "*" + array[num];
		}
		return array;
	}

	public static short a(string A_0, hd A_1, eo A_2, eo.a A_3, ref string A_4, ref string A_5, ref string A_6, ref bool A_7)
	{
		double[] A_8 = new double[2];
		double[] A_9 = new double[2] { 1.0, 2.0 };
		jc A_10 = null;
		double[] A_11 = null;
		int A_12 = checked(A_8.GetUpperBound(0) + 1);
		short A_13 = default(short);
		short[] A_14 = new short[0];
		double[] A_15 = new double[0];
		bool A_16 = false;
		bool A_17 = false;
		bool A_18 = false;
		int A_19 = 0;
		string A_20 = null;
		int A_21 = 0;
		d[] A_22 = null;
		string[] A_23 = null;
		bool A_24 = false;
		string A_25 = null;
		short A_26 = default(short);
		int A_27 = default(int);
		if (a(A_0, A_1: false, ref A_9, ref A_8, ref A_11, A_5: true, A_6: true, ref A_12, A_1, ref A_13, ref A_26, ref A_27, ref A_14, ref A_15, A_2, ref A_4, ref A_16, ref A_17, ref A_18, ref A_5, ref A_6, ref A_19, ref A_20, ref A_21, ref A_22, ref A_23, ref A_24, ref A_25, ref A_10, A_3) == jb.a.a)
		{
			A_7 = A_10 != null;
			return A_26;
		}
		return -1;
	}

	public static bool aa(string A_0)
	{
		return Operators.CompareString(Strings.LCase(A_0), "air", TextCompare: false) == 0;
	}

	public static bool z(string A_0)
	{
		return Operators.CompareString(Strings.Left(A_0, 11), "Generic, n=", TextCompare: false) == 0;
	}

	public static bool y(string A_0)
	{
		if (!aa(A_0) && !z(A_0))
		{
			return Operators.CompareString(A_0, "<Graded Interface>", TextCompare: false) != 0;
		}
		return false;
	}

	public static a a(string A_0, ref double[] A_1, ref double[] A_2, ref double[] A_3, ref int A_4)
	{
		short A_5 = 0;
		short A_6 = 0;
		int A_7 = 0;
		short[] A_8 = null;
		double[] A_9 = null;
		string A_10 = null;
		bool A_11 = false;
		bool A_12 = false;
		bool A_13 = false;
		string A_14 = null;
		string A_15 = null;
		int A_16 = 0;
		string A_17 = null;
		int A_18 = 0;
		d[] A_19 = null;
		string[] A_20 = null;
		bool A_21 = false;
		string A_22 = null;
		jc A_23 = null;
		return a(A_0, A_1: false, ref A_1, ref A_2, ref A_3, A_5: true, A_6: true, ref A_4, null, ref A_5, ref A_6, ref A_7, ref A_8, ref A_9, null, ref A_10, ref A_11, ref A_12, ref A_13, ref A_14, ref A_15, ref A_16, ref A_17, ref A_18, ref A_19, ref A_20, ref A_21, ref A_22, ref A_23, null);
	}

	public static a a(string A_0, bool A_1, ref double[,] A_2, ref double[,] A_3, int A_4, bool A_5, bool A_6, ref double[] A_7, ref int A_8, ref bool A_9, ref short[] A_10, hd A_11, ref short[] A_12, ref short[] A_13, ref int[] A_14, ref int A_15, bool A_16, short[] A_17, double[] A_18, eo A_19, ref string A_20, ref bool A_21, ref bool A_22, ref bool A_23, ref jc A_24, eo.a A_25)
	{
		bool A_26 = false;
		string A_27 = null;
		string A_28 = null;
		int A_29 = 0;
		string A_30 = null;
		int A_31 = 0;
		d[] A_32 = null;
		string[] A_33 = null;
		string A_34 = null;
		return a(A_0, A_1, ref A_2, ref A_3, A_4, A_5, A_6, ref A_7, ref A_8, ref A_9, ref A_10, A_11, ref A_12, ref A_13, ref A_14, ref A_15, A_16, A_17, A_18, A_19, ref A_20, ref A_21, ref A_22, ref A_23, ref A_26, ref A_27, ref A_28, ref A_29, ref A_30, ref A_31, ref A_32, ref A_33, ref A_34, ref A_24, A_25);
	}

	public static a a(string A_0, bool A_1, ref double[,] A_2, ref double[,] A_3, int A_4, bool A_5, bool A_6, ref double[] A_7, ref int A_8, ref bool A_9, ref short[] A_10, hd A_11, ref short[] A_12, ref short[] A_13, ref int[] A_14, ref int A_15, bool A_16, short[] A_17, double[] A_18, eo A_19, ref string A_20, ref bool A_21, ref bool A_22, ref bool A_23, ref bool A_24, ref string A_25, ref string A_26, ref int A_27, ref string A_28, ref int A_29, ref d[] A_30, ref string[] A_31, ref string A_32, ref jc A_33, eo.a A_34)
	{
		string text = "";
		string text2 = "";
		double[] A_35 = new double[1837];
		short[] A_36 = new short[1837];
		a result = jb.a.a;
		checked
		{
			try
			{
				A_24 = false;
				A_33 = null;
				A_32 = "";
				double[] A_37 = new double[20000];
				double[] A_38 = new double[20000];
				double[] A_39 = new double[20000];
				bool flag = false;
				if (A_0.StartsWith("Generic, n="))
				{
					A_9 = false;
				}
				else if (Operators.CompareString(Strings.LCase(A_0), "air", TextCompare: false) == 0)
				{
					flag = true;
					A_9 = false;
				}
				else
				{
					A_9 = true;
				}
				A_0 = x(A_0);
				float A_41 = default(float);
				bool flag2 = default(bool);
				if (!A_9 && !flag)
				{
					bool A_40 = default(bool);
					a(A_0, ref A_40, ref A_41, ref A_20);
					if (!A_40)
					{
						return jb.a.c;
					}
					text = "Insulator";
				}
				else
				{
					text = A_0;
					if (!A_0.Contains("."))
					{
						flag2 = false;
					}
					else
					{
						string text3 = A_0.ToLower();
						flag2 = text3.Contains("\\") || text3.EndsWith(".fmnnn") || text3.EndsWith(".fmkkk") || text3.EndsWith(".fitnk") || text3.EndsWith(".fibnk") || text3.EndsWith(".nnn") || text3.EndsWith(".kkk");
						text3 = null;
					}
				}
				short A_42 = 0;
				A_21 = false;
				A_25 = "";
				A_26 = "";
				A_29 = 0;
				A_30 = null;
				A_31 = null;
				if ((A_9 || A_5) && !flag)
				{
					string text4 = null;
					if (flag2)
					{
						text2 = text;
						text4 = text;
						if (!global::c.e().FileSystem.FileExists(text2))
						{
							string A_43 = "ErrMaterialFileMissing";
							A_20 = string.Format(hu.a(ref A_43), text);
							return jb.a.f;
						}
					}
					else if (A_1)
					{
						text4 = (string.IsNullOrEmpty(gf.d(text + ".fibnx")) ? null : (text + ".fibnx"));
					}
					else
					{
						text4 = a(new string[1] { text + ".fibnx" });
						if (string.IsNullOrEmpty(text4))
						{
							text4 = a(new string[1] { text + ".fitnx" });
						}
					}
					short A_47 = default(short);
					int A_48 = default(int);
					if (!string.IsNullOrEmpty(text4) && m(text4))
					{
						if (!A_5 || !A_6)
						{
							throw new am("Software error in UtilMaterial.GetnOrk - attempt to read only n or only k of mixture file");
						}
						b(text4, A_1, ref A_33, ref A_10[A_4], ref A_25, ref A_28, ref A_27, ref A_26, ref A_29, ref A_30, ref A_31);
						A_32 = text4;
						A_21 = true;
						A_24 = true;
						jc a_ = A_33;
						double[] a_2 = A_7;
						bool A_44 = false;
						float[] A_45 = null;
						bool A_46 = default(bool);
						a(null, A_1: true, a_, null, A_4: false, null, A_19, A_11, a_2, ref A_46, ref A_22, ref A_23, ref A_44, ref A_37, ref A_38, ref A_39, ref A_35, ref A_36, ref A_42, ref A_47, ref A_45, ref A_20, A_34);
						if (!A_46)
						{
							string obj = A_20;
							string A_43 = "ErrInvalidMaterialFileFormatFmt1";
							A_20 = obj + "\r\n" + string.Format(hu.a(ref A_43), text4);
							a result2 = default(a);
							return result2;
						}
						A_37 = A_33.c;
						A_48 = A_33.c.Length;
					}
					short A_49 = default(short);
					if (!A_24)
					{
						if (!flag2)
						{
							text4 = ((!A_1) ? a(new string[1] { text + ".fibnk" }) : (string.IsNullOrEmpty(gf.d(text + ".fibnk")) ? null : (text + ".fibnk")));
						}
						if (!string.IsNullOrEmpty(text4) && text4.ToLower().EndsWith(".fibnk"))
						{
							a result2 = a(text4, A_1, ref A_10[A_4], ref A_47, ref A_48, ref A_35, ref A_36, ref A_42, ref A_49, ref A_37, ref A_38, ref A_39, ref A_25, ref A_26, ref A_27, ref A_28, ref A_29, ref A_30, ref A_31);
							if (result2 != jb.a.a)
							{
								string A_43 = "ErrInvalidMaterialFileFormatFmt1";
								A_20 = string.Format(hu.a(ref A_43), text4);
								return result2;
							}
							A_22 = true;
							A_23 = true;
							A_32 = text4;
							if (!A_5 && !A_6)
							{
								A_38 = A_39;
								A_39 = null;
								A_21 = false;
							}
							else
							{
								A_21 = true;
							}
							A_24 = true;
						}
					}
					short A_50 = default(short);
					if (!A_24)
					{
						if (!flag2)
						{
							text2 = a(new string[1] { text + ".fitnk" });
						}
						if (!string.IsNullOrEmpty(text2) && text2.ToLower().EndsWith(".fitnk"))
						{
							a result2 = a(text2, A_11, ref A_10[A_4], ref A_47, ref A_50, ref A_48, ref A_35, ref A_36, ref A_42, ref A_37, ref A_38, ref A_39, ref A_20, ref A_25);
							if (result2 != jb.a.a)
							{
								string A_43 = "ErrInvalidMaterialFileFormatFmt1";
								A_20 = string.Format(hu.a(ref A_43), text2);
								return result2;
							}
							A_24 = true;
							A_22 = false;
							A_23 = false;
							A_32 = text2;
							if (!A_5 && !A_6)
							{
								A_38 = A_39;
								A_39 = null;
								A_21 = false;
							}
							else
							{
								A_21 = true;
							}
						}
					}
					if (!A_24)
					{
						if (!flag2)
						{
							text2 = ((!A_5) ? a(new string[1] { text + ".fmkkk" }) : a(new string[1] { text + ".fmnnn" }));
						}
						if (!string.IsNullOrEmpty(text2) && (text2.ToLower().EndsWith(".fmnnn") || text2.ToLower().EndsWith(".fmkkk")))
						{
							int A_51 = default(int);
							int A_52 = default(int);
							a result2 = a(text2, ref A_51, ref A_52, ref A_10[A_4], ref A_47, ref A_48, ref A_35, ref A_36, ref A_42, ref A_49, A_5, ref A_37, ref A_38);
							if (result2 != jb.a.a)
							{
								string A_43 = "ErrInvalidMaterialFileFormatFmt1";
								A_20 = string.Format(hu.a(ref A_43), text2);
								return result2;
							}
							A_24 = true;
							A_22 = true;
							A_32 = text2;
						}
					}
					if (!A_24)
					{
						if (!flag2)
						{
							text2 = ((!A_5) ? a(new string[1] { text + ".kkk" }) : a(new string[1] { text + ".nnn" }));
						}
						if (!string.IsNullOrEmpty(text2) && (text2.ToLower().EndsWith(".nnn") || text2.ToLower().EndsWith(".kkk")))
						{
							a result2 = a(text2, A_11, ref A_10[A_4], ref A_47, ref A_50, ref A_48, ref A_35, ref A_36, ref A_42, ref A_37, ref A_38, ref A_20);
							if (result2 != jb.a.a)
							{
								string A_43 = "ErrInvalidMaterialFileFormatFmt1";
								A_20 = string.Format(hu.a(ref A_43), text2);
								return result2;
							}
							A_24 = true;
							A_22 = false;
							A_32 = text2;
						}
					}
					if (!A_24)
					{
						if (!flag2)
						{
							text2 = a(new string[1] { text + ".mat" });
						}
						if (!string.IsNullOrEmpty(text2) && text2.ToLower().EndsWith(".mat"))
						{
							a result2 = a(text2, ref A_48, ref A_37, ref A_38, ref A_39, ref A_20);
							if (result2 != jb.a.a)
							{
								string A_43 = "ErrInvalidMaterialFileFormatFmt1";
								A_20 = string.Format(hu.a(ref A_43), text2);
								return result2;
							}
							A_10[A_4] = 4;
							A_42 = 0;
							A_24 = true;
							A_22 = false;
							A_23 = false;
							A_32 = text2;
							if (!A_5 && !A_6)
							{
								A_38 = A_39;
								A_39 = null;
								A_21 = false;
							}
							else
							{
								A_21 = true;
							}
						}
					}
					if (!A_24)
					{
						if (A_5)
						{
							if (A_1)
							{
								string A_43 = "ErrEncryptedMaterialFileMissing";
								A_20 = hu.a(ref A_43);
							}
							else
							{
								string A_43 = "ErrMaterialFileMissing";
								A_20 = string.Format(hu.a(ref A_43), text);
							}
							return jb.a.f;
						}
						A_48 = 1;
					}
					if (!A_9 & A_5)
					{
						int num;
						for (num = 0; (A_37[num] < 632.0) & (num < A_48); num++)
						{
						}
						int num2 = num;
						float num3;
						if (num2 == 0)
						{
							num3 = A_41 / (float)(Math.Abs(A_38[0]) + 1E-20);
						}
						else if (num2 == A_48)
						{
							num3 = A_41 / (float)(Math.Abs(A_38[A_48 - 1]) + 1E-20);
						}
						else
						{
							float num4 = (float)Math.Abs((A_37[num] - 632.0) / (A_37[num] - A_37[num - 1]));
							float num5 = (float)((double)num4 * A_38[num - 1] + (double)(1f - num4) * A_38[num]);
							num3 = (A_41 - 1f) / (float)((double)Math.Abs(num5 - 1f) + 1E-20);
						}
						int num6 = A_48 - 1;
						for (num = 0; num <= num6; num++)
						{
							A_38[num] = 1.0 + (A_38[num] - 1.0) * (double)num3;
						}
					}
					if (A_4 != -1)
					{
						if (A_7 == null)
						{
							A_7 = A_37;
							A_8 = A_48;
						}
						double[] A_53 = new double[A_8 - 1 + 1];
						jf.a(ref A_37, ref A_38, A_48, ref A_7, ref A_53, A_8);
						int num7 = A_8 - 1;
						for (int num = 0; num <= num7; num++)
						{
							A_2[A_4, num] = A_53[num];
						}
						if (A_21 && A_39 != null)
						{
							jf.a(ref A_37, ref A_39, A_48, ref A_7, ref A_53, A_8);
							int num8 = A_8 - 1;
							for (int num = 0; num <= num8; num++)
							{
								A_3[A_4, num] = A_53[num];
							}
						}
					}
					if ((A_42 > 0 || A_47 == 22) && (A_11 == null || A_11.k(A_47, A_19, A_34)))
					{
						A_12[A_4] = (short)A_15;
						A_13[A_4] = A_47;
						if (A_16)
						{
							for (int num9 = 0; num9 < A_42; num9++)
							{
								if (A_15 >= 1836)
								{
									break;
								}
								A_18[A_15] = A_35[num9];
								A_17[A_15] = A_36[num9];
								A_15++;
							}
						}
						A_50 = A_47;
						A_14[A_4] = 0;
					}
					else if (A_5)
					{
						switch (unchecked((gr.d)A_10[A_4]))
						{
						case gr.d.a:
							A_50 = 5;
							break;
						case gr.d.b:
							A_50 = 6;
							break;
						case gr.d.c:
						case gr.d.f:
							A_50 = 2;
							break;
						default:
							A_50 = 1;
							break;
						}
						short num10 = default(short);
						if (A_11 != null)
						{
							num10 = (short)A_11.j(A_50);
						}
						A_12[A_4] = (short)A_15;
						A_13[A_4] = 0;
						if (A_16)
						{
							int num11 = 0;
							do
							{
								A_18[A_15] = 0.0;
								A_17[A_15] = 1;
								A_15++;
								num11++;
							}
							while (num11 < num10 && A_15 < 1836);
						}
						A_14[A_4] = A_50;
					}
					if (A_15 >= 1836)
					{
						string A_43 = "ErrTooManyModelCoefficients";
						A_20 = hu.a(ref A_43);
						result = jb.a.b;
					}
				}
				if ((!A_9 && !A_5) || flag)
				{
					float num12 = 0f;
					if (flag & A_5)
					{
						num12 = 1.00027f;
					}
					if (A_4 != -1)
					{
						if (A_8 == 0)
						{
							A_8 = 1;
							A_7 = new double[1];
							A_7[0] = 632.8;
						}
						int num13 = A_8 - 1;
						for (int num = 0; num <= num13; num++)
						{
							A_2[A_4, num] = num12;
						}
						if (A_5 && A_6)
						{
							int num14 = A_8 - 1;
							for (int num = 0; num <= num14; num++)
							{
								A_3[A_4, num] = 0.0;
							}
							A_21 = true;
						}
					}
					if (flag)
					{
						A_9 = true;
					}
				}
			}
			catch (IOException ex2)
			{
				ProjectData.SetProjectError(ex2);
				IOException ex3 = ex2;
				A_20 = ex3.Message;
				result = jb.a.b;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex5 = ex4;
				string A_43 = "ErrGeneralMaterialFile";
				A_20 = hu.a(ref A_43);
				result = jb.a.b;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static a a(string A_0, bool A_1, ref double[] A_2, ref double[] A_3, ref double[] A_4, bool A_5, bool A_6, ref int A_7, hd A_8, ref short A_9, ref short A_10, ref int A_11, ref short[] A_12, ref double[] A_13, eo A_14, ref string A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref string A_19, ref string A_20, ref int A_21, ref string A_22, ref int A_23, ref d[] A_24, ref string[] A_25, ref bool A_26, ref string A_27, ref jc A_28, eo.a A_29)
	{
		double[,] A_30 = new double[1, 20001];
		double[,] A_31 = new double[1, 20001];
		short[] A_32 = new short[1];
		short[] A_33 = new short[1];
		short[] A_34 = new short[1];
		int[] A_35 = new int[1];
		double[] A_36 = null;
		if (A_13 == null || A_13.GetUpperBound(0) <= 0)
		{
			A_13 = new double[1837];
		}
		if (A_12 == null || A_12.GetUpperBound(0) <= 0)
		{
			A_12 = new short[1837];
		}
		A_26 = false;
		A_2 = null;
		A_11 = 0;
		bool A_37 = default(bool);
		bool A_38 = default(bool);
		a result = a(A_0, A_1, ref A_30, ref A_31, 0, A_5, A_6, ref A_36, ref A_7, ref A_37, ref A_32, A_8, ref A_33, ref A_34, ref A_35, ref A_11, A_16: true, A_12, A_13, A_14, ref A_15, ref A_38, ref A_16, ref A_17, ref A_18, ref A_19, ref A_20, ref A_21, ref A_22, ref A_23, ref A_24, ref A_25, ref A_27, ref A_28, A_29);
		checked
		{
			int num = A_7 - 1;
			if (A_3 == null || A_3.GetUpperBound(0) < num)
			{
				A_3 = new double[num + 1];
			}
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				A_3[num3] = A_30[0, num3];
			}
			if (A_38)
			{
				A_4 = new double[num + 1];
				int num4 = num;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					A_4[num5] = A_31[0, num5];
				}
			}
			else
			{
				A_4 = null;
			}
			if (A_11 > 0 || A_34[0] == 22)
			{
				if (A_35[0] > 0)
				{
					A_26 = true;
					A_10 = (short)A_35[0];
				}
				else
				{
					A_10 = A_34[0];
				}
			}
			else
			{
				A_10 = (short)A_35[0];
				A_26 = true;
			}
			A_9 = A_32[0];
			A_2 = A_36;
			return result;
		}
	}

	public static a a(string A_0, double[] A_1, double[] A_2, double[] A_3, short A_4, short A_5, short A_6, short A_7, double[] A_8, short[] A_9, string A_10, string A_11, int A_12, d[] A_13, string[] A_14, bool A_15)
	{
		a result = jb.a.a;
		string extension = Path.GetExtension(A_0);
		bool num = q(extension);
		bool flag = p(extension);
		checked
		{
			if (!num)
			{
				result = ((!flag) ? a(A_0, A_1, A_2, A_4, A_5, A_6, A_7, A_8, A_9, A_15) : ((Operators.CompareString(extension.ToLower(), ".mat", TextCompare: false) != 0) ? a(A_0, ref A_5, A_6, A_4, A_8, A_9, A_7, A_1, A_2, A_3, A_10, A_15) : a(A_0, A_4, A_1, A_2, A_3)));
			}
			else
			{
				if (!A_15)
				{
					A_7 = 0;
				}
				if (flag)
				{
					_ = new int[1];
					int[] array = new int[1];
					short[] array2 = new short[1];
					int num2 = A_12 - 1;
					new StringBuilder();
					StringBuilder stringBuilder = new StringBuilder();
					if (A_12 > 0)
					{
						_ = new int[num2 + 1];
						array = new int[num2 + 1];
						array2 = new short[num2 + 1];
						int num3 = num2;
						for (int num4 = 0; num4 <= num3; num4++)
						{
							string text = "~#^%*}{" + Convert.ToBase64String(new UTF8Encoding().GetBytes(A_14[num4].ToString()));
							array[num4] = text.Length;
							stringBuilder.Append(text);
							array2[num4] = unchecked((short)A_13[num4]);
						}
					}
					if (A_8.Length == 0)
					{
						A_8 = new double[1];
					}
					if (A_9.Length == 0)
					{
						A_9 = new short[1];
					}
					short a_ = A_5;
					ref double a_2 = ref A_1[0];
					ref double a_3 = ref A_2[0];
					ref double a_4 = ref A_3[0];
					ref double a_5 = ref A_8[0];
					ref short a_6 = ref A_9[0];
					short a_7 = A_7;
					ref short a_8 = ref array2[0];
					ref int a_9 = ref array[0];
					string A_16 = stringBuilder.ToString();
					if (f6.WriteFIBNKFile2(ref A_0, -1, a_, A_6, ref a_2, ref a_3, ref a_4, A_4, ref a_5, ref a_6, a_7, ref A_10, ref A_11, A_12, ref a_8, ref a_9, ref A_16) != 0)
					{
						result = jb.a.e;
					}
				}
				else if (j(extension))
				{
					if (f6.WriteFMNNNFile(ref A_0, -1, A_5, A_6, ref A_1[0], ref A_2[0], A_4, ref A_8[0], ref A_9[0], A_7) != 0)
					{
						result = jb.a.e;
					}
				}
				else if (f6.WriteFMKKKFile(ref A_0, -1, ref A_1[0], ref A_2[0], A_4) != 0)
				{
					result = jb.a.e;
				}
			}
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private static a a(string A_0, double[] A_1, double[] A_2, short A_3, short A_4, short A_5, short A_6, double[] A_7, short[] A_8, bool A_9)
	{
		bool flag = A_0.ToLower().EndsWith(".nnn");
		short num = 1;
		bool flag2 = false;
		a result = jb.a.a;
		checked
		{
			int num4 = default(int);
			try
			{
				if (flag && A_9)
				{
					num = 2;
					int num2 = A_6 - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						if (A_8[num3] == 0)
						{
							num = 3;
							break;
						}
					}
				}
				num4 = Microsoft.VisualBasic.FileSystem.FreeFile();
				Microsoft.VisualBasic.FileSystem.FileOpen(num4, A_0, OpenMode.Output);
				flag2 = true;
				if (num > 0)
				{
					Microsoft.VisualBasic.FileSystem.WriteLine(num4, "Version", num);
					Microsoft.VisualBasic.FileSystem.WriteLine(num4, "Material", A_4);
				}
				else if (flag)
				{
					Microsoft.VisualBasic.FileSystem.WriteLine(num4, "Wavelenth (nm), n");
				}
				else
				{
					Microsoft.VisualBasic.FileSystem.WriteLine(num4, "Wavelenth (nm), k");
				}
				int num5 = A_3 - 1;
				for (int num3 = 0; num3 <= num5; num3++)
				{
					Microsoft.VisualBasic.FileSystem.WriteLine(num4, A_1[num3], A_2[num3]);
				}
				if (num >= 2)
				{
					Microsoft.VisualBasic.FileSystem.PrintLine(num4, "");
					Microsoft.VisualBasic.FileSystem.WriteLine(num4, A_5);
					int num6 = A_6 - 1;
					for (int num3 = 0; num3 <= num6; num3++)
					{
						if (num == 2)
						{
							Microsoft.VisualBasic.FileSystem.WriteLine(num4, A_7[num3]);
						}
						else
						{
							Microsoft.VisualBasic.FileSystem.WriteLine(num4, A_7[num3], A_8[num3]);
						}
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				result = jb.a.b;
				ProjectData.ClearProjectError();
			}
			finally
			{
				if (flag2)
				{
					Microsoft.VisualBasic.FileSystem.FileClose(num4);
				}
			}
			return result;
		}
	}

	public static string a(string A_0, string A_1)
	{
		return a(A_0, m(A_1));
	}

	public static string a(string A_0, bool A_1)
	{
		if (A_1)
		{
			return A_0 + " <Universal>";
		}
		return A_0;
	}

	public static string x(string A_0)
	{
		if (A_0.EndsWith(" <Universal>"))
		{
			return A_0.Substring(0, checked(A_0.Length - " <Universal>".Length));
		}
		return A_0;
	}

	public static string l()
	{
		return i3.o() + "\\Material";
	}

	public static Collection<string> k()
	{
		Collection<string> collection = new Collection<string>();
		string text = d();
		string text2 = text + "\\" + f();
		if (Directory.Exists(text2))
		{
			collection.Add(text2);
		}
		if (Directory.Exists(text))
		{
			collection.Add(text);
		}
		return collection;
	}

	public static void j()
	{
		string path = h();
		if (!Directory.Exists(path))
		{
			Directory.CreateDirectory(path);
		}
	}

	public static bool i()
	{
		return Directory.Exists(h());
	}

	public static string h()
	{
		return d() + "\\" + f();
	}

	public static string g()
	{
		string text = h() + "\\Temp";
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		return text;
	}

	public static string f()
	{
		return "OMDB";
	}

	[SpecialName]
	public static string e()
	{
		return aq;
	}

	[SpecialName]
	public static void w(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0) && A_0.Length > 0 && A_0.EndsWith("\\"))
		{
			A_0 = A_0.Substring(0, checked(A_0.Length - 1));
		}
		aq = A_0;
	}

	public static string d()
	{
		return v(aq);
	}

	public static string v(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0) && Directory.Exists(A_0))
		{
			return A_0;
		}
		return i3.m() + "\\Material";
	}

	public static string u(string A_0)
	{
		return a(new string[3]
		{
			A_0 + ".rrr",
			A_0 + ".fmrrr",
			A_0 + ".fitdr"
		});
	}

	public static string a(string A_0, float A_1, bool A_2, bool A_3)
	{
		string empty = string.Empty;
		string empty2 = string.Empty;
		empty = ((!A_2) ? "_MIXED##" : ((!A_3) ? "_TE##" : "_TM##"));
		empty2 = A_0 + "##" + A_1.ToString("0.00", CultureInfo.InvariantCulture) + empty;
		return a(new string[3]
		{
			empty2 + ".rrr",
			empty2 + ".fmrrr",
			empty2 + ".fitdr"
		});
	}

	public static string t(string A_0)
	{
		return a(new string[2]
		{
			A_0 + ".ttt",
			A_0 + ".fmttt"
		});
	}

	public static string s(string A_0)
	{
		return a(new string[5]
		{
			A_0 + ".nnn",
			A_0 + ".fmnnn",
			A_0 + ".fitnk",
			A_0 + ".fibnk",
			A_0 + ".fibnx"
		});
	}

	public static string a(string[] A_0)
	{
		foreach (string item in k())
		{
			ReadOnlyCollection<string> files = global::c.e().FileSystem.GetFiles(item, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, A_0);
			if (files.Count > 0)
			{
				return files[0];
			}
		}
		return null;
	}

	public static a a(string A_0, bool A_1, ref short A_2, ref short A_3, ref int A_4, ref double[] A_5, ref short[] A_6, ref short A_7, ref short A_8, ref double[] A_9, ref double[] A_10, ref double[] A_11, ref string A_12, ref string A_13, ref int A_14, ref string A_15, ref int A_16, ref d[] A_17, ref string[] A_18)
	{
		int A_19 = 32;
		checked
		{
			short[] array = new short[A_19 - 1 + 1];
			int[] array2 = new int[A_19 - 1 + 1];
			string A_20 = null;
			a result = jb.a.a;
			try
			{
				byte[] A_21 = null;
				int A_22 = 20000;
				A_4 = 20000;
				A_12 = "";
				A_13 = "";
				if (A_9 == null || A_9.GetUpperBound(0) < A_22 - 1)
				{
					A_9 = new double[A_22 - 1 + 1];
				}
				if (A_10 == null || A_10.GetUpperBound(0) < A_22 - 1)
				{
					A_10 = new double[A_22 - 1 + 1];
				}
				if (A_11 == null || A_11.GetUpperBound(0) < A_22 - 1)
				{
					A_11 = new double[A_22 - 1 + 1];
				}
				if (A_5 == null || A_5.GetUpperBound(0) < 1836)
				{
					A_5 = new double[1837];
				}
				if (A_6 == null || A_6.GetUpperBound(0) < 1836)
				{
					A_6 = new short[1837];
				}
				int A_23 = 1836;
				f6.d d10;
				int A_25 = default(int);
				int A_26 = default(int);
				if (A_1)
				{
					string a_ = A_0;
					string A_24 = null;
					gf.a(a_, ref A_24, ref A_21);
					string a_2 = a(A_21, A_21.Length);
					a(ref A_9, a_2);
					d10 = f6.ParseFIBNKFileBuffer(ref A_21[0], (uint)A_21.Length, ref A_25, ref A_26, ref A_9[0], ref A_22, ref A_10[0], ref A_11[0], ref A_4, ref A_5[0], ref A_6[0], ref A_23, ref A_8, ref A_12, ref A_13, ref A_14, ref A_15, ref A_19, ref array[0], ref array2[0], ref A_20);
				}
				else
				{
					a(ref A_9, A_0);
					d10 = f6.ReadFIBNKFile3(ref A_0, ref A_25, ref A_26, ref A_9[0], ref A_22, ref A_10[0], ref A_11[0], ref A_4, ref A_5[0], ref A_6[0], ref A_23, ref A_8, ref A_12, ref A_13, ref A_14, ref A_15, ref A_19, ref array[0], ref array2[0], ref A_20);
				}
				if (d10 == f6.d.e)
				{
					A_9 = new double[A_22 - 1 + 1];
					A_10 = new double[A_4 - 1 + 1];
					A_11 = new double[A_4 - 1 + 1];
					if (A_1)
					{
						d10 = f6.ParseFIBNKFileBuffer(ref A_21[0], (uint)A_21.Length, ref A_25, ref A_26, ref A_9[0], ref A_22, ref A_10[0], ref A_11[0], ref A_4, ref A_5[0], ref A_6[0], ref A_23, ref A_8, ref A_12, ref A_13, ref A_14, ref A_15, ref A_19, ref array[0], ref array2[0], ref A_20);
					}
					else
					{
						a(ref A_9, A_0);
						d10 = f6.ReadFIBNKFile3(ref A_0, ref A_25, ref A_26, ref A_9[0], ref A_22, ref A_10[0], ref A_11[0], ref A_4, ref A_5[0], ref A_6[0], ref A_23, ref A_8, ref A_12, ref A_13, ref A_14, ref A_15, ref A_19, ref array[0], ref array2[0], ref A_20);
					}
				}
				if (d10 == f6.d.g)
				{
					array2 = new int[A_19 - 1 + 1];
					array = new short[A_19 - 1 + 1];
					if (A_1)
					{
						d10 = f6.ParseFIBNKFileBuffer(ref A_21[0], (uint)A_21.Length, ref A_25, ref A_26, ref A_9[0], ref A_22, ref A_10[0], ref A_11[0], ref A_4, ref A_5[0], ref A_6[0], ref A_23, ref A_8, ref A_12, ref A_13, ref A_14, ref A_15, ref A_19, ref array[0], ref array2[0], ref A_20);
					}
					else
					{
						a(ref A_9, A_0);
						d10 = f6.ReadFIBNKFile3(ref A_0, ref A_25, ref A_26, ref A_9[0], ref A_22, ref A_10[0], ref A_11[0], ref A_4, ref A_5[0], ref A_6[0], ref A_23, ref A_8, ref A_12, ref A_13, ref A_14, ref A_15, ref A_19, ref array[0], ref array2[0], ref A_20);
					}
				}
				if (d10 == f6.d.a)
				{
					A_2 = (short)A_25;
					A_3 = (short)A_26;
					A_7 = (short)A_23;
					A_16 = A_19;
					string text = null;
					UTF8Encoding uTF8Encoding = new UTF8Encoding();
					if (A_19 > 0)
					{
						int num = A_19 - 1;
						int num2 = 0;
						A_18 = new string[num + 1];
						A_17 = new d[num + 1];
						int num3 = num;
						for (int num4 = 0; num4 <= num3; num4++)
						{
							A_17[num4] = unchecked((d)array[num4]);
							int num5 = array2[num4];
							text = A_20.Substring(num2, num5);
							if (text.StartsWith("~#^%*}{"))
							{
								A_18[num4] = uTF8Encoding.GetString(Convert.FromBase64String(text.Substring("~#^%*}{".Length)));
							}
							else
							{
								A_18[num4] = text;
							}
							num2 += num5;
						}
					}
					else
					{
						A_17 = null;
						A_18 = null;
					}
				}
				else
				{
					result = jb.a.e;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				result = jb.a.b;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static a a(string A_0, StreamReader A_1, int A_2, hd A_3, ref short A_4, ref double[] A_5, ref short[] A_6, ref short A_7, ref string A_8)
	{
		checked
		{
			if (A_2 >= 2)
			{
				string value = A_1.ReadLine().Trim();
				A_4 = Conversions.ToShort(value);
				if (A_3 != null)
				{
					A_7 = (short)A_3.j(A_4);
				}
				A_5 = new double[A_7 - 1 + 1];
				for (int num = 0; num < A_7; num++)
				{
					value = A_1.ReadLine();
					int num2 = value.IndexOf(",");
					if (num2 > 0)
					{
						A_5[num] = Conversion.Val(value.Substring(0, num2));
						A_6[num] = (short)Math.Round(Conversion.Val(value.Substring(num2 + 1)));
						continue;
					}
					if (A_2 >= 3)
					{
						string A_9 = "ErrInvalidMaterialFileFormatFmt1";
						A_8 = string.Format(hu.a(ref A_9), A_0);
						return jb.a.d;
					}
					A_5[num] = Conversion.Val(value);
					A_6[num] = 1;
				}
			}
			else
			{
				A_7 = 0;
			}
			return jb.a.a;
		}
	}

	public static int r(string A_0)
	{
		StreamReader streamReader = null;
		try
		{
			streamReader = new StreamReader(A_0);
			StreamReader a_ = streamReader;
			int A_1 = 0;
			short A_2 = default(short);
			if (b(a_, ref A_1, ref A_2) != jb.a.a)
			{
				throw new au("Error attempting to get mat type from " + A_0);
			}
			return A_2;
		}
		finally
		{
			streamReader.Close();
		}
	}

	private static a b(StreamReader A_0, ref int A_1, ref short A_2)
	{
		string text = A_0.ReadLine();
		checked
		{
			if (text.ToLower().StartsWith("version"))
			{
				A_1 = Conversions.ToInteger(text.Substring(text.IndexOf(",") + 1));
				text = A_0.ReadLine();
				if (Conversions.ToInteger(text.Substring(text.IndexOf(",") + 1)) > 3)
				{
					return jb.a.g;
				}
			}
			else
			{
				A_1 = 0;
			}
			if (A_1 > 0)
			{
				text = A_0.ReadLine();
				A_2 = Conversions.ToShort(text.Substring(text.IndexOf(",") + 1));
			}
			else
			{
				A_2 = 4;
			}
			return jb.a.a;
		}
	}

	public static a a(string A_0, hd A_1, ref short A_2, ref short A_3, ref short A_4, ref int A_5, ref double[] A_6, ref short[] A_7, ref short A_8, ref double[] A_9, ref double[] A_10, ref double[] A_11, ref string A_12, ref string A_13)
	{
		string text = "";
		string text2 = "";
		string text3 = "";
		int upperBound = A_9.GetUpperBound(0);
		if (!global::c.e().FileSystem.FileExists(A_0))
		{
			return jb.a.f;
		}
		StreamReader streamReader = null;
		checked
		{
			try
			{
				streamReader = new StreamReader(new FileStream(A_0, FileMode.Open, FileAccess.Read, FileShare.Read));
				int A_14 = default(int);
				if (b(streamReader, ref A_14, ref A_2) != jb.a.a || streamReader.EndOfStream)
				{
					string A_15 = "ErrInvalidMaterialFileFormatFmt1";
					A_12 = string.Format(hu.a(ref A_15), A_0);
					return jb.a.d;
				}
				string text4;
				if (A_14 > 0)
				{
					text4 = streamReader.ReadLine();
					if (text4.Length > "File Information, ".Length)
					{
						A_13 = jg.c(text4.Substring("File Information, ".Length));
					}
					else
					{
						A_13 = string.Empty;
					}
				}
				else
				{
					A_13 = string.Empty;
				}
				text4 = streamReader.ReadLine();
				int num = 0;
				bool flag = false;
				do
				{
					text4 = streamReader.ReadLine().Trim();
					int num2 = text4.IndexOf(",");
					int num3 = text4.LastIndexOf(",");
					if (num2 > 0 && num3 > 0 && num2 != num3)
					{
						text = text4.Substring(0, num2).Trim();
						text2 = text4.Substring(num2 + 1, num3 - num2 - 1).Trim();
						text3 = text4.Substring(num3 + 1).Trim();
					}
					else
					{
						text = "";
						text2 = "";
						text3 = "";
					}
					if (Operators.CompareString(text, "", TextCompare: false) != 0 && Operators.CompareString(text2, "", TextCompare: false) != 0 && Operators.CompareString(text3, "", TextCompare: false) != 0)
					{
						A_9[num] = Conversion.Val(text);
						if (A_9[num] == 1.0)
						{
							string A_15 = "ErrInvalidMaterialFileFormatFmt1";
							A_12 = string.Format(hu.a(ref A_15), A_0);
							return jb.a.d;
						}
						A_10[num] = Conversion.Val(text2);
						A_11[num] = Conversion.Val(text3);
						num++;
					}
					else
					{
						flag = true;
					}
				}
				while (!streamReader.EndOfStream && num <= upperBound && !flag);
				A_5 = num;
				return a(A_0, streamReader, A_14, A_1, ref A_3, ref A_6, ref A_7, ref A_8, ref A_12);
			}
			finally
			{
				streamReader?.Close();
			}
		}
	}

	private static string c(double A_0)
	{
		return A_0.ToString("0.##", CultureInfo.InvariantCulture);
	}

	private static string b(double A_0)
	{
		return A_0.ToString("0.#####", CultureInfo.InvariantCulture);
	}

	private static string a(double A_0)
	{
		return ((float)A_0).ToString(CultureInfo.InvariantCulture);
	}

	public static a a(string A_0, ref short A_1, short A_2, int A_3, double[] A_4, short[] A_5, short A_6, double[] A_7, double[] A_8, double[] A_9, string A_10, bool A_11)
	{
		StreamWriter streamWriter = null;
		checked
		{
			int num = A_3 - 1;
			a result = jb.a.a;
			try
			{
				streamWriter = new StreamWriter(A_0, append: false);
				int num2 = 1;
				if (A_11)
				{
					num2 = 3;
				}
				streamWriter.WriteLine("Version, " + num2);
				streamWriter.WriteLine("Compat. Version, " + 1);
				streamWriter.WriteLine("Material Type, " + A_1);
				streamWriter.WriteLine("File Information, " + jg.d(A_10));
				streamWriter.WriteLine("Wavelength (nm), n, k");
				if (A_9 == null)
				{
					A_9 = new double[num + 1];
				}
				int num3 = num;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					streamWriter.WriteLine(c(A_7[num4]) + ", " + b(A_8[num4]) + ", " + a(A_9[num4]));
				}
				streamWriter.WriteLine();
				if (num2 > 1)
				{
					streamWriter.WriteLine(A_2);
					int num5 = A_6 - 1;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						streamWriter.WriteLine(A_4[num6].ToString(CultureInfo.InvariantCulture) + ", " + A_5[num6].ToString(CultureInfo.InvariantCulture));
					}
				}
				streamWriter.Close();
				streamWriter = null;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				result = jb.a.d;
				ProjectData.ClearProjectError();
			}
			finally
			{
				streamWriter?.Close();
			}
			return result;
		}
	}

	public static void b(string A_0, bool A_1, ref jc A_2, ref short A_3, ref string A_4, ref string A_5, ref int A_6, ref string A_7, ref int A_8, ref d[] A_9, ref string[] A_10)
	{
		if (A_0.ToLower().EndsWith(".fibnx"))
		{
			a(A_0, A_1, ref A_2, ref A_3, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8, ref A_9, ref A_10);
			return;
		}
		a(A_0, ref A_2, ref A_3, ref A_4);
		A_5 = string.Empty;
		A_6 = 0;
		A_7 = string.Empty;
		A_8 = 0;
		A_9 = null;
		A_10 = null;
	}

	public static void a(string A_0, short A_1, string[] A_2, float[] A_3, int[] A_4, bool[] A_5, bool A_6, int A_7, int A_8, float[] A_9, string A_10)
	{
		StreamWriter streamWriter = null;
		checked
		{
			try
			{
				int num = A_2.Length - 1;
				streamWriter = new StreamWriter(A_0, append: false, Encoding.UTF8);
				streamWriter.WriteLine("Version, " + 1.ToString(CultureInfo.InvariantCulture));
				streamWriter.WriteLine("Compat. Version, " + 1.ToString(CultureInfo.InvariantCulture));
				streamWriter.WriteLine("Material Type, " + A_1.ToString(CultureInfo.InvariantCulture));
				streamWriter.WriteLine("File Information, " + jg.d(A_10));
				streamWriter.Write("Materials");
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					streamWriter.Write(", \"" + A_2[num3] + "\"");
				}
				streamWriter.WriteLine();
				streamWriter.Write("Composition Fraction");
				int num4 = num - 1;
				int num5 = num4;
				for (int num3 = 0; num3 <= num5; num3++)
				{
					streamWriter.Write(", " + A_3[num3].ToString(CultureInfo.InvariantCulture));
				}
				streamWriter.WriteLine();
				streamWriter.Write("Composition Fraction is Fixed");
				int num6 = num4;
				for (int num3 = 0; num3 <= num6; num3++)
				{
					streamWriter.Write(", " + A_5[num3].ToString(CultureInfo.InvariantCulture));
				}
				streamWriter.WriteLine();
				streamWriter.Write("Num Grid Pts");
				int num7 = num4;
				for (int num3 = 0; num3 <= num7; num3++)
				{
					streamWriter.Write(", " + A_4[num3].ToString(CultureInfo.InvariantCulture));
				}
				streamWriter.WriteLine();
				streamWriter.WriteLine("Has Custom Model, " + A_6.ToString(CultureInfo.InvariantCulture));
				if (!A_6)
				{
					return;
				}
				streamWriter.WriteLine("ModelID, " + A_7.ToString(CultureInfo.InvariantCulture));
				streamWriter.WriteLine("ModelNumCoeffs, " + A_8.ToString(CultureInfo.InvariantCulture));
				int num8 = a(num4, A_5, A_4) - 1;
				int num9 = A_8 - 1;
				int num10 = 0;
				streamWriter.WriteLine("ModelCoeffs:");
				int num11 = num8;
				for (int num12 = 0; num12 <= num11; num12++)
				{
					int num13 = num9;
					for (int num14 = 0; num14 <= num13; num14++)
					{
						streamWriter.WriteLine("ModelCoeff, " + A_9[num10].ToString(CultureInfo.InvariantCulture));
						num10++;
					}
				}
			}
			finally
			{
				streamWriter?.Close();
			}
		}
	}

	public static void a(StreamReader A_0, ref int A_1, ref short A_2)
	{
		string text = A_0.ReadLine();
		checked
		{
			A_1 = int.Parse(text.Substring(text.IndexOf(",") + 1), CultureInfo.InvariantCulture);
			text = A_0.ReadLine();
			int.Parse(text.Substring(text.IndexOf(",") + 1), CultureInfo.InvariantCulture);
			text = A_0.ReadLine();
			A_2 = short.Parse(text.Substring(text.IndexOf(",") + 1), CultureInfo.InvariantCulture);
		}
	}

	public static void a(string A_0, ref jc A_1, ref short A_2, ref string A_3)
	{
		List<string> list = new List<string>();
		List<float> list2 = new List<float>();
		List<bool> list3 = new List<bool>();
		List<int> list4 = new List<int>();
		string A_4 = null;
		StreamReader streamReader = null;
		checked
		{
			try
			{
				streamReader = new StreamReader(File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read), Encoding.UTF8);
				int A_5 = default(int);
				a(streamReader, ref A_5, ref A_2);
				A_1 = new jc();
				jc jc2 = A_1;
				string text = streamReader.ReadLine();
				A_3 = jg.c(text.Substring("File Information, ".Length));
				text = streamReader.ReadLine() + "\r\n";
				int A_6 = 0;
				i3.a(ref A_6, text, ref A_4);
				while (A_6 < text.Length)
				{
					i3.a(ref A_6, text, ref A_4);
					list.Add(A_4);
				}
				text = streamReader.ReadLine() + "\r\n";
				A_6 = 0;
				i3.a(ref A_6, text, ref A_4);
				while (A_6 < text.Length)
				{
					i3.a(ref A_6, text, ref A_4);
					list2.Add(float.Parse(A_4, CultureInfo.InvariantCulture));
				}
				if (list.Count != list2.Count + 1)
				{
					throw new av("UtilMaterial.GetFITNXFile matList.Count <> compFracList.Count");
				}
				text = streamReader.ReadLine() + "\r\n";
				A_6 = 0;
				i3.a(ref A_6, text, ref A_4);
				while (A_6 < text.Length)
				{
					i3.a(ref A_6, text, ref A_4);
					list3.Add(bool.Parse(A_4));
				}
				if (list.Count != list3.Count + 1)
				{
					throw new av("UtilMaterial.GetFITNXFile matList.Count <> fixedList.Count");
				}
				jc2.j = list3.ToArray();
				text = streamReader.ReadLine() + "\r\n";
				A_6 = 0;
				i3.a(ref A_6, text, ref A_4);
				while (A_6 < text.Length)
				{
					i3.a(ref A_6, text, ref A_4);
					list4.Add(int.Parse(A_4, CultureInfo.InvariantCulture));
				}
				if (list.Count != list4.Count + 1)
				{
					throw new av("UtilMaterial.GetFITNXFile matList.Count <> numGridPtsList.Count");
				}
				jc2.i = list4.ToArray();
				text = streamReader.ReadLine();
				jc2.k = bool.Parse(text.Substring(text.IndexOf(",") + 1));
				if (jc2.k)
				{
					text = streamReader.ReadLine();
					jc2.l = short.Parse(text.Substring(text.IndexOf(",") + 1), CultureInfo.InvariantCulture);
					text = streamReader.ReadLine();
					jc2.m = int.Parse(text.Substring(text.IndexOf(",") + 1), CultureInfo.InvariantCulture);
					int num = a(list.Count - 2, jc2.j, jc2.i);
					int num2 = num - 1;
					int num3 = jc2.m - 1;
					int num4 = 0;
					text = streamReader.ReadLine();
					jc2.n = new float[num * jc2.m - 1 + 1];
					int num5 = num2;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						int num7 = num3;
						for (int num8 = 0; num8 <= num7; num8++)
						{
							text = streamReader.ReadLine();
							jc2.n[num4] = float.Parse(text.Substring(text.IndexOf(",") + 1), CultureInfo.InvariantCulture);
							num4++;
						}
					}
				}
				jc2.b = list.ToArray();
				jc2.h = list2.ToArray();
				jc2 = null;
			}
			finally
			{
				streamReader?.Close();
			}
		}
	}

	public static void a(int[] A_0, bool[] A_1, int[] A_2)
	{
		checked
		{
			int num = A_0.Length - 1;
			int num2 = num;
			bool flag = false;
			do
			{
				if (A_1[num2])
				{
					num2--;
					continue;
				}
				if (A_2[num2] < A_0[num2])
				{
					A_2[num2]++;
					flag = true;
					continue;
				}
				if (num2 == 0)
				{
					throw new ApplicationException("Software bug in UpdateMixtureModelGridPtCoeffsIfNeeded - current grid point array ran past end");
				}
				num2--;
			}
			while (!flag);
			if (A_2[num2] >= A_0[num2])
			{
				return;
			}
			int num3 = num2 + 1;
			int num4 = num;
			for (int num5 = num3; num5 <= num4; num5++)
			{
				if (!A_1[num2])
				{
					A_2[num5] = 1;
				}
			}
		}
	}

	public static int a(int A_0, bool[] A_1, int[] A_2)
	{
		int num = 1;
		checked
		{
			for (int num2 = A_0; num2 >= 0; num2 += -1)
			{
				if (!A_1[num2])
				{
					num *= A_2[num2] - 1;
					num++;
				}
			}
			if (num > 1)
			{
				num++;
			}
			return num;
		}
	}

	public static void a(string A_0, short A_1, string[] A_2, float[] A_3, int[] A_4, bool[] A_5, string A_6, bool A_7, int A_8, int A_9, float[] A_10, string A_11, int A_12, d[] A_13, string[] A_14)
	{
		BinaryWriter binaryWriter = null;
		checked
		{
			try
			{
				int num = A_2.Length - 1;
				ICryptoTransform a_ = new RijndaelManaged().CreateEncryptor(Encoding.ASCII.GetBytes("yoRuOln*f&Xcd,pdR[a~{L!p='_W\\jJ:"), Encoding.ASCII.GetBytes("s2CD?c-iTk=)*rDb"));
				binaryWriter = new BinaryWriter(File.Open(A_0, FileMode.Create));
				binaryWriter.Write(1);
				binaryWriter.Write(1);
				binaryWriter.Write(A_1);
				if (A_6 == null)
				{
					A_6 = string.Empty;
				}
				binaryWriter.Write(A_6);
				binaryWriter.Write(A_2.Length);
				dz.a(binaryWriter, a_, Path.GetFileName(A_0));
				int num2 = num;
				int num5 = default(int);
				for (int num3 = 0; num3 <= num2; num3++)
				{
					byte[] array = dz.a(binaryWriter, a_, A_2[num3]);
					foreach (byte b10 in array)
					{
						num5 += b10;
					}
				}
				int num6 = num - 1;
				int num7 = num6;
				for (int num3 = 0; num3 <= num7; num3++)
				{
					byte[] array2 = dz.a(binaryWriter, a_, A_3[num3]);
					foreach (byte b11 in array2)
					{
						num5 += b11;
					}
				}
				int num9 = num6;
				for (int num3 = 0; num3 <= num9; num3++)
				{
					byte[] array3 = dz.a(binaryWriter, a_, A_5[num3]);
					foreach (byte b12 in array3)
					{
						num5 += b12;
					}
				}
				int num11 = num6;
				for (int num3 = 0; num3 <= num11; num3++)
				{
					byte[] array4 = dz.a(binaryWriter, a_, A_4[num3]);
					foreach (byte b13 in array4)
					{
						num5 += b13;
					}
				}
				dz.a(binaryWriter, a_, num5);
				dz.a(binaryWriter, a_, A_7);
				if (A_7)
				{
					dz.a(binaryWriter, a_, A_8);
					dz.a(binaryWriter, a_, A_9);
					int num13 = a(num6, A_5, A_4) - 1;
					int num14 = A_9 - 1;
					int num15 = 0;
					int num16 = num13;
					for (int num17 = 0; num17 <= num16; num17++)
					{
						int num18 = num14;
						for (int num19 = 0; num19 <= num18; num19++)
						{
							dz.a(binaryWriter, a_, A_10[num15]);
							num15++;
						}
					}
				}
				dz.a(binaryWriter, a_, A_11);
				binaryWriter.Write(A_12);
				int num20 = A_12 - 1;
				int num21 = num20;
				for (int num22 = 0; num22 <= num21; num22++)
				{
					binaryWriter.Write(unchecked((int)A_13[num22]));
				}
				int num23 = num20;
				for (int num24 = 0; num24 <= num23; num24++)
				{
					dz.a(binaryWriter, a_, A_14[num24]);
				}
			}
			finally
			{
				binaryWriter?.Close();
			}
		}
	}

	public static void a(BinaryReader A_0, ref int A_1, ref short A_2)
	{
		A_1 = A_0.ReadInt32();
		int num = A_0.ReadInt32();
		if (num > 1)
		{
			throw new au("ReadFIBNXPreamble compatVer must be <=" + Conversions.ToString(1) + ", however current file compat ver is " + num);
		}
		A_2 = A_0.ReadInt16();
	}

	public static void a(string A_0, bool A_1, ref jc A_2, ref short A_3, ref string A_4, ref string A_5, ref int A_6, ref string A_7, ref int A_8, ref d[] A_9, ref string[] A_10)
	{
		BinaryReader binaryReader = null;
		checked
		{
			try
			{
				ICryptoTransform a_ = new RijndaelManaged().CreateDecryptor(Encoding.ASCII.GetBytes("yoRuOln*f&Xcd,pdR[a~{L!p='_W\\jJ:"), Encoding.ASCII.GetBytes("s2CD?c-iTk=)*rDb"));
				if (A_1)
				{
					byte[] A_11 = null;
					string fileName = Path.GetFileName(A_0);
					string A_12 = null;
					gf.a(fileName, ref A_12, ref A_11);
					binaryReader = new BinaryReader(new MemoryStream(A_11));
				}
				else
				{
					binaryReader = new BinaryReader(File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read));
				}
				int A_13 = default(int);
				a(binaryReader, ref A_13, ref A_3);
				A_2 = new jc();
				jc jc2 = A_2;
				jc2.a = true;
				jc2.o = A_1;
				A_4 = binaryReader.ReadString();
				int num = binaryReader.ReadInt32() - 1;
				A_5 = dz.e(binaryReader, a_);
				jc2.b = new string[num + 1];
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					jc2.b[num3] = dz.e(binaryReader, a_);
				}
				int num4 = num - 1;
				jc2.h = new float[num4 + 1];
				jc2.j = new bool[num4 + 1];
				jc2.i = new int[num4 + 1];
				int num5 = num4;
				for (int num3 = 0; num3 <= num5; num3++)
				{
					jc2.h[num3] = dz.c(binaryReader, a_);
				}
				int num6 = num4;
				for (int num3 = 0; num3 <= num6; num3++)
				{
					jc2.j[num3] = dz.a(binaryReader, a_);
				}
				int num7 = num4;
				for (int num3 = 0; num3 <= num7; num3++)
				{
					jc2.i[num3] = dz.b(binaryReader, a_);
				}
				A_6 = dz.b(binaryReader, a_);
				jc2.k = dz.a(binaryReader, a_);
				if (jc2.k)
				{
					jc2.l = dz.b(binaryReader, a_);
					jc2.m = dz.b(binaryReader, a_);
					int num8 = a(num4, jc2.j, jc2.i);
					int num9 = num8 - 1;
					int num10 = jc2.m - 1;
					int num11 = 0;
					jc2.n = new float[num8 * jc2.m - 1 + 1];
					int num12 = num9;
					for (int num13 = 0; num13 <= num12; num13++)
					{
						int num14 = num10;
						for (int num15 = 0; num15 <= num14; num15++)
						{
							jc2.n[num11] = dz.c(binaryReader, a_);
							num11++;
						}
					}
				}
				A_7 = dz.e(binaryReader, a_);
				A_8 = binaryReader.ReadInt32();
				int num16 = A_8 - 1;
				A_9 = new d[num16 + 1];
				int num17 = num16;
				for (int num18 = 0; num18 <= num17; num18++)
				{
					unchecked
					{
						A_9[num18] = (d)checked((short)binaryReader.ReadInt32());
					}
				}
				A_10 = new string[num16 + 1];
				int num19 = num16;
				for (int num20 = 0; num20 <= num19; num20++)
				{
					A_10[num20] = dz.e(binaryReader, a_);
				}
				jc2 = null;
			}
			finally
			{
				binaryReader?.Close();
			}
		}
	}

	public static bool a(bool[] A_0)
	{
		for (int num = 0; num < A_0.Length; num = checked(num + 1))
		{
			if (!A_0[num])
			{
				return false;
			}
		}
		return true;
	}

	public static int a(int[] A_0, int[] A_1, bool[] A_2)
	{
		int num = 1;
		int num2 = 1;
		checked
		{
			int num3 = A_0.Length - 1;
			int[] array = new int[num3 + 1];
			bool flag = false;
			int num4 = num3;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				if (!A_2[num5])
				{
					if (flag)
					{
						array[num5] = 1;
						continue;
					}
					array[num5] = A_0[num5];
					flag = A_0[num5] == A_1[num5];
				}
			}
			for (int num6 = num3; num6 >= 0; num6 += -1)
			{
				if (!A_2[num6])
				{
					num2 += num * (array[num6] - 1);
					num *= A_1[num6] - 1;
					num++;
				}
			}
			return num2;
		}
	}

	public static void a(int[] A_0, bool A_1, jc A_2, int[] A_3, bool A_4, float[] A_5, eo A_6, hd A_7, double[] A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref double[] A_13, ref double[] A_14, ref double[] A_15, ref double[] A_16, ref short[] A_17, ref short A_18, ref short A_19, ref float[] A_20, ref string A_21, eo.a A_22)
	{
		List<string> list = new List<string>();
		List<int> list2 = new List<int>();
		List<string> list3 = new List<string>();
		A_9 = false;
		checked
		{
			if (A_0 != null)
			{
				if (A_3.Length != A_0.Length)
				{
					throw new ApplicationException("currGridPt Length mismatch in GetMixtureData");
				}
				int num = A_0.Length - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (A_0[num2] < 1 || A_0[num2] > A_2.i[num2])
					{
						throw new ApplicationException("GridPtOverride out of bounds in GetMixtureData");
					}
				}
				A_3 = A_0;
			}
			bool num3 = A_1 || a(A_2.j);
			int num4 = A_2.b.Length - 2;
			if (num3 || !A_2.k || A_4 || A_5 != null)
			{
				int num5 = A_2.b.Length - 1;
				double[][] array = new double[num5 + 1][];
				double[][] array2 = new double[num5 + 1][];
				double[][] array3 = new double[num5 + 1][];
				int[] array4 = new int[num5 + 1];
				string A_23 = null;
				string A_24 = null;
				if (A_2.d == null)
				{
					bool flag = false;
					bool flag2 = false;
					bool flag3 = true;
					int num6 = num5;
					int A_42 = default(int);
					bool A_43 = default(bool);
					bool A_44 = default(bool);
					int A_45 = default(int);
					double num9 = default(double);
					int num10 = default(int);
					int A_37;
					for (int num7 = 0; num7 <= num6; num7++)
					{
						double[] A_25 = null;
						double[] A_26 = null;
						double[] A_27 = null;
						string a_ = A_2.b[num7];
						bool a_2 = A_2.o;
						short A_28 = 0;
						short A_29 = 0;
						int A_30 = 0;
						short[] A_31 = null;
						double[] A_32 = null;
						string A_33 = null;
						bool A_34 = false;
						string A_35 = null;
						string A_36 = null;
						A_37 = 0;
						d[] A_38 = null;
						string[] A_39 = null;
						bool A_40 = false;
						jc A_41 = null;
						if (a(a_, a_2, ref A_25, ref A_26, ref A_27, A_5: true, A_6: true, ref A_42, A_7, ref A_28, ref A_29, ref A_30, ref A_31, ref A_32, A_6, ref A_33, ref A_43, ref A_44, ref A_34, ref A_35, ref A_36, ref A_45, ref A_23, ref A_37, ref A_38, ref A_39, ref A_40, ref A_24, ref A_41, A_22) != jb.a.a)
						{
							A_21 = "Error attempting to read component index " + num7 + ", material name is: " + A_2.b[num7];
							return;
						}
						if (A_43)
						{
							flag = true;
						}
						if (A_44)
						{
							flag2 = true;
						}
						if (flag3)
						{
							if (A_43)
							{
								list.Add(A_23);
								list2.Add(A_45);
								list3.Add(Path.GetFileName(A_24));
							}
							else if (A_44)
							{
								flag3 = false;
							}
						}
						double num8 = A_25[A_42 - 1] - A_25[0];
						if (num9 < num8)
						{
							num9 = num8;
							num10 = num7;
						}
						array[num7] = A_25;
						array2[num7] = A_26;
						array3[num7] = A_27;
						array4[num7] = A_42;
					}
					double[][] array5 = new double[num5 + 1][];
					double[][] array6 = new double[num5 + 1][];
					int num11;
					if (A_8 != null)
					{
						A_13 = A_8;
						num11 = A_13.Length - 1;
					}
					else
					{
						A_13 = array[num10];
						num11 = array4[num10] - 1;
					}
					A_13 = (double[])Utils.CopyArray(A_13, new double[num11 + 1]);
					A_37 = num5;
					for (int num12 = 0; num12 <= A_37; num12++)
					{
						if (A_8 == null && num12 == num10)
						{
							array5[num12] = array2[num12];
							array6[num12] = array3[num12];
							continue;
						}
						double[] A_26 = new double[num11 + 1];
						jf.a(ref array[num12], ref array2[num12], array4[num12], ref A_13, ref A_26, num11 + 1);
						double[] A_27 = new double[num11 + 1];
						if (array3[num12] != null)
						{
							jf.a(ref array[num12], ref array3[num12], array4[num12], ref A_13, ref A_27, num11 + 1);
						}
						array5[num12] = A_26;
						array6[num12] = A_27;
					}
					A_2.d = array5;
					A_2.e = array6;
					A_2.c = A_13;
					A_2.f = flag;
					A_2.g = flag2;
				}
				A_20 = new float[num5 + 1];
				if ((!A_2.k && !A_1) || A_0 != null || A_5 != null)
				{
					float num13 = 1f;
					int num15 = default(int);
					if (A_5 == null)
					{
						int A_30 = num4;
						for (int num14 = 0; num14 <= A_30; num14++)
						{
							if (A_2.j[num14])
							{
								A_20[num14] = num13 * A_2.h[num14];
								num13 -= A_20[num14];
							}
							else if (A_3[num14] == 1)
							{
								num15++;
							}
						}
					}
					if (num13 < 0f)
					{
						num13 = 0f;
					}
					num13 -= (float)num15 * 0.0001f;
					int num16 = num4;
					for (int num17 = 0; num17 <= num16; num17++)
					{
						if (A_5 != null)
						{
							A_20[num17] = A_5[num17];
							num13 -= A_20[num17];
						}
						else if (!A_2.j[num17])
						{
							A_20[num17] = num13 * (float)(A_3[num17] - 1) / (float)(A_2.i[num17] - 1);
							if (A_20[num17] < 0.0001f)
							{
								A_20[num17] = 0.0001f;
							}
							num13 -= A_20[num17];
						}
					}
					A_20[num5] = num13;
				}
				else
				{
					float num18 = 1f;
					int num19 = num4;
					for (int num20 = 0; num20 <= num19; num20++)
					{
						A_20[num20] = A_2.h[num20];
						num18 -= A_2.h[num20];
					}
					if (num18 < 0f)
					{
						num18 = 0f;
					}
					A_20[num5] = num18;
				}
				if (A_2.k && A_2.n != null)
				{
					jc jc2 = A_2;
					A_18 = (short)jc2.m;
					int num21 = A_18 - 1;
					A_16 = new double[num21 + 1];
					A_17 = new short[num21 + 1];
					int num22 = num21;
					for (int num23 = 0; num23 <= num22; num23++)
					{
						A_16[num23] = jc2.n[num23];
						A_17[num23] = 1;
					}
					A_19 = (short)jc2.l;
					jc2 = null;
				}
				else
				{
					A_18 = (short)(num5 + 1);
					A_16 = new double[num5 + 1];
					A_17 = new short[num5 + 1];
					A_16[0] = num5;
					int num24 = num4;
					for (int num25 = 0; num25 <= num24; num25++)
					{
						A_16[1 + num25] = A_20[num25];
						A_17[1 + num25] = (short)unchecked(-(short)(0 - ((!A_2.j[num25]) ? 1 : 0)));
					}
					A_19 = 21;
				}
				if (A_13 == null)
				{
					A_13 = A_2.c;
				}
				int num26 = A_13.Length - 1;
				double[] array7 = new double[num26 + 1];
				double[] array8 = new double[num26 + 1];
				int num27 = num5;
				for (int num28 = 0; num28 <= num27; num28++)
				{
					double[] array9 = A_2.d[num28];
					double[] array10 = A_2.e[num28];
					float num29 = A_20[num28];
					int num30 = num26;
					for (int num31 = 0; num31 <= num30; num31++)
					{
						double num32 = array9[num31];
						double num33 = array10[num31];
						array7[num31] += (double)num29 * (num32 * num32 - num33 * num33);
						array8[num31] += (double)num29 * (2.0 * num32 * num33);
					}
				}
				A_14 = new double[num26 + 1];
				A_15 = new double[num26 + 1];
				int num34 = num26;
				for (int num35 = 0; num35 <= num34; num35++)
				{
					double num36 = array7[num35];
					double num37 = array8[num35];
					num37 = Math.Sqrt(num36 * num36 + num37 * num37);
					A_14[num35] = Math.Sqrt(0.5 * (num37 + num36));
					A_15[num35] = array8[num35] / (2.0 * A_14[num35]);
				}
				int num38 = num26;
				bool flag4 = default(bool);
				for (int num39 = 0; num39 <= num38; num39++)
				{
					if (A_15[num39] != 0.0)
					{
						flag4 = true;
						break;
					}
				}
				if (!flag4)
				{
					A_15 = null;
				}
				A_10 = A_2.f;
				A_11 = A_2.g;
				A_12 = A_2.s;
			}
			else
			{
				int num40 = a(A_3, A_2.i, A_2.j);
				int num41;
				if (A_8 != null)
				{
					num41 = A_8.Length - 1;
					A_13 = A_8;
				}
				else
				{
					num41 = 320;
					A_13 = new double[num41 + 1];
					int num42 = num41;
					for (int num43 = 0; num43 <= num42; num43++)
					{
						A_13[num43] = 200f + (float)(5 * num43);
					}
				}
				A_14 = new double[num41 + 1];
				A_15 = new double[num41 + 1];
				A_10 = false;
				A_11 = false;
				A_12 = true;
				int num44 = A_2.m - 1;
				int num45 = num40 * A_2.m;
				A_16 = new double[num44 + 1];
				A_17 = new short[num44 + 1];
				float[] array11 = new float[num44 + 1];
				int num46 = num44;
				for (int num47 = 0; num47 <= num46; num47++)
				{
					array11[num47] = A_2.n[num45 + num47];
					A_16[num47] = array11[num47];
					A_17[num47] = 1;
				}
				A_18 = (short)A_2.m;
				A_19 = (short)A_2.l;
				int num48 = num41;
				float A_46 = default(float);
				float A_47 = default(float);
				for (int num49 = 0; num49 <= num48; num49++)
				{
					f6.CalculateModelNK((short)A_2.l, (float)(A_13[num49] * 9.999999717180685E-10), ref array11[0], 1, 1, ref A_46, ref A_47);
					A_14[num49] = A_46;
					A_15[num49] = A_47;
				}
			}
			A_9 = true;
			if (A_12)
			{
				A_2.p = list.ToArray();
				A_2.r = list2.ToArray();
				A_2.q = list3.ToArray();
			}
			else
			{
				A_2.p = null;
				A_2.r = null;
				A_2.q = null;
			}
		}
	}

	public static a a(string A_0, int A_1, double[] A_2, double[] A_3, double[] A_4)
	{
		StreamWriter streamWriter = null;
		checked
		{
			int num = A_1 - 1;
			a result = jb.a.a;
			try
			{
				streamWriter = new StreamWriter(A_0, append: false);
				streamWriter.WriteLine("Data from Filmetrics software");
				streamWriter.WriteLine("nm");
				streamWriter.WriteLine("NK");
				if (A_4 == null)
				{
					A_4 = new double[num + 1];
				}
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					streamWriter.WriteLine(A_2[num3].ToString("0.##", CultureInfo.InvariantCulture) + "\t" + A_3[num3].ToString("0.#####", CultureInfo.InvariantCulture) + "\t" + ((float)A_4[num3]).ToString(CultureInfo.InvariantCulture));
				}
				streamWriter.Close();
				streamWriter = null;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				result = jb.a.d;
				ProjectData.ClearProjectError();
			}
			finally
			{
				streamWriter?.Close();
			}
			return result;
		}
	}

	public static a a(string A_0, ref int A_1, ref double[] A_2, ref double[] A_3, ref double[] A_4, ref string A_5)
	{
		string text = "";
		int upperBound = A_2.GetUpperBound(0);
		checked
		{
			if (global::c.e().FileSystem.FileExists(A_0))
			{
				StreamReader streamReader = new StreamReader(A_0);
				string text2 = streamReader.ReadLine();
				text2 = streamReader.ReadLine();
				text2 = streamReader.ReadLine();
				int num = 0;
				bool flag = false;
				do
				{
					text2 = streamReader.ReadLine().Trim();
					int num2 = text2.IndexOf("\t");
					int num3 = text2.LastIndexOf("\t");
					string text3;
					string text4;
					if (num2 > 0 && num3 > 0 && num2 != num3)
					{
						text = text2.Substring(0, num2).Trim();
						text3 = text2.Substring(num2 + 1, num3 - num2 - 1).Trim();
						text4 = text2.Substring(num3 + 1).Trim();
					}
					else
					{
						text = "";
						text3 = "";
						text4 = "";
					}
					if (Operators.CompareString(text, "", TextCompare: false) != 0 && Operators.CompareString(text3, "", TextCompare: false) != 0 && Operators.CompareString(text4, "", TextCompare: false) != 0)
					{
						A_2[num] = Conversion.Val(text);
						if (A_2[num] == 1.0)
						{
							string A_6 = "ErrInvalidMaterialFileFormatFmt1";
							A_5 = string.Format(hu.a(ref A_6), A_0);
							return jb.a.d;
						}
						A_3[num] = Conversion.Val(text3);
						A_4[num] = Conversion.Val(text4);
						num++;
					}
					else
					{
						flag = true;
					}
				}
				while (!streamReader.EndOfStream && num <= upperBound && !flag);
				A_1 = num;
				if (A_2[0] < 8.0)
				{
					int num4 = A_1 - 1;
					for (num = 0; num <= num4; num++)
					{
						A_2[num] *= 1000.0;
					}
				}
			}
			return jb.a.a;
		}
	}

	public static a a(string A_0, hd A_1, ref short A_2, ref short A_3, ref short A_4, ref int A_5, ref double[] A_6, ref short[] A_7, ref short A_8, ref double[] A_9, ref double[] A_10, ref string A_11)
	{
		string text = "";
		string text2 = "";
		int upperBound = A_9.GetUpperBound(0);
		checked
		{
			if (global::c.e().FileSystem.FileExists(A_0))
			{
				StreamReader streamReader = new StreamReader(A_0);
				string text3 = streamReader.ReadLine();
				int num = ((text3.ToLower().StartsWith("\"version") || text3.ToLower().StartsWith("version")) ? Conversions.ToInteger(text3.Substring(text3.IndexOf(",") + 1)) : 0);
				if (num > 0)
				{
					text3 = streamReader.ReadLine();
					A_2 = Conversions.ToShort(text3.Substring(text3.IndexOf(",") + 1));
				}
				else
				{
					A_2 = 4;
				}
				if (streamReader.EndOfStream)
				{
					string A_12 = "ErrInvalidMaterialFileFormatFmt1";
					A_11 = string.Format(hu.a(ref A_12), A_0);
					return jb.a.d;
				}
				int num2 = 0;
				bool flag = false;
				do
				{
					text3 = streamReader.ReadLine().Trim();
					int num3 = text3.IndexOf(",");
					if (num3 > 0)
					{
						text = text3.Substring(0, num3).Trim();
						text2 = text3.Substring(num3 + 1).Trim();
					}
					else
					{
						text = "";
						text2 = "";
					}
					if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2))
					{
						A_9[num2] = Conversion.Val(text);
						if (A_9[num2] == 1.0)
						{
							string A_12 = "ErrInvalidMaterialFileFormatFmt1";
							A_11 = string.Format(hu.a(ref A_12), A_0);
							return jb.a.d;
						}
						A_10[num2] = Conversion.Val(text2);
						num2++;
					}
					else
					{
						flag = true;
					}
				}
				while (!streamReader.EndOfStream && num2 <= upperBound && !flag);
				A_5 = num2;
				return a(A_0, streamReader, num, A_1, ref A_3, ref A_6, ref A_7, ref A_8, ref A_11);
			}
			return jb.a.a;
		}
	}

	public static a a(string A_0, ref int A_1, ref int A_2, ref short A_3, ref short A_4, ref int A_5, ref double[] A_6, ref short[] A_7, ref short A_8, ref short A_9, bool A_10, ref double[] A_11, ref double[] A_12)
	{
		a result = jb.a.a;
		checked
		{
			try
			{
				int A_13 = 20000;
				A_5 = 20000;
				if (A_10)
				{
					if (b(ref A_11, A_0) != -1)
					{
						int A_14 = 1836;
						int A_15 = default(int);
						int A_16 = default(int);
						int num = f6.ReadFMNNNFile(ref A_0, ref A_1, ref A_2, ref A_15, ref A_16, ref A_11[0], ref A_13, ref A_12[0], ref A_5, ref A_6[0], ref A_7[0], ref A_14, ref A_9);
						if (num == -4)
						{
							A_11 = (double[])Utils.CopyArray(A_11, new double[A_13 - 1 + 1]);
							A_12 = (double[])Utils.CopyArray(A_12, new double[A_5 - 1 + 1]);
							num = f6.ReadFMNNNFile(ref A_0, ref A_1, ref A_2, ref A_15, ref A_16, ref A_11[0], ref A_13, ref A_12[0], ref A_5, ref A_6[0], ref A_7[0], ref A_14, ref A_9);
						}
						if (num == 0)
						{
							A_3 = (short)A_15;
							A_4 = (short)A_16;
							A_8 = (short)A_14;
						}
						else
						{
							result = jb.a.e;
						}
					}
					else
					{
						result = jb.a.b;
					}
				}
				else if (b(ref A_11, A_0) != -1)
				{
					int num = f6.ReadFMKKKFile(ref A_0, ref A_1, ref A_2, ref A_11[0], ref A_13, ref A_12[0], ref A_5, ref A_9);
					if (num == -4)
					{
						A_11 = (double[])Utils.CopyArray(A_11, new double[A_13 - 1 + 1]);
						A_12 = (double[])Utils.CopyArray(A_12, new double[A_5 - 1 + 1]);
						num = f6.ReadFMKKKFile(ref A_0, ref A_1, ref A_2, ref A_11[0], ref A_13, ref A_12[0], ref A_5, ref A_9);
					}
					if (num != 0)
					{
						result = jb.a.e;
					}
				}
				else
				{
					result = jb.a.b;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				result = jb.a.b;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	private static string a(byte[] A_0, int A_1)
	{
		int num = 0;
		string text = string.Empty;
		checked
		{
			int num2 = ((A_1 - 23 + 1 <= 32) ? (A_1 - 1) : 54);
			int num3 = num2 - 23 - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				if (unchecked(num4 / 4 % 2) == 0)
				{
					byte b10 = A_0[23 + num4];
					if (b10 == 0)
					{
						b10 = 1;
					}
					text += Strings.Chr(b10);
					num++;
				}
			}
			return text;
		}
	}

	private static short b(ref double[] A_0, string A_1)
	{
		checked
		{
			short result;
			try
			{
				byte[] bytes = Encoding.GetEncoding(1252).GetBytes(A_1);
				A_0[0] = bytes[6] * 256;
				A_0[3] = bytes[5] * 256;
				A_0[4] = bytes[4] * 256;
				A_0[6] = bytes[3] * 256;
				A_0[8] = bytes[2] * 256;
				A_0[11] = bytes[1] * 256;
				A_0[14] = bytes[0] * 256;
				result = 0;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				result = -1;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	private static void a(ref double[] A_0, string A_1)
	{
		int[] array = new int[7] { 1, 13, 5, 11, 8, 6, 2 };
		byte[] bytes = Encoding.GetEncoding(1252).GetBytes(A_1);
		checked
		{
			int num = bytes.GetUpperBound(0) + 1;
			int num2 = ((num - 6 >= 7) ? (num - 6 - 1) : (num - 1));
			int num3 = 0;
			int num4 = num2;
			if (A_0 == null || A_0.GetUpperBound(0) < 13)
			{
				A_0 = new double[14];
			}
			do
			{
				A_0[array[num3]] = bytes[num4] * 256;
				num3++;
				num4 = ((num4 != 0) ? (num4 - 1) : num2);
			}
			while (num3 < 7);
		}
	}

	public static void a(string A_0, eb.b A_1)
	{
		a(A_0, A_1, null, "", "");
	}

	public static void a(string A_0, eb.b A_1, string A_2)
	{
		a(A_0, A_1, A_2, "", "");
	}

	public static void a(string A_0, eb.b A_1, string A_2, string A_3)
	{
		a(A_0, A_1, null, A_2, A_3);
	}

	private static void a(string A_0, eb.b A_1, string A_2, string A_3, string A_4)
	{
		Collection<string> A_5 = null;
		if (!i3.a(A_0, d(A_1), ref A_5))
		{
			return;
		}
		foreach (string item in A_5)
		{
			string text = Path.GetDirectoryName(A_0) + "\\" + item;
			if (Operators.CompareString(text.ToLower(), A_3.ToLower(), TextCompare: false) == 0 || Operators.CompareString(item.ToLower(), A_4.ToLower(), TextCompare: false) == 0)
			{
				continue;
			}
			if (!string.IsNullOrEmpty(A_2))
			{
				DateTime now = DateTime.Now;
				string text2 = A_2 + "\\" + Path.GetFileNameWithoutExtension(item) + " " + now.Year + "_" + now.Month + "_" + now.Day + "-" + now.Hour + "_" + now.Minute + "_" + now.Second + Path.GetExtension(item);
				if (!File.Exists(text2))
				{
					File.Copy(text, text2);
				}
			}
			FileInfo fileInfo = global::c.e().FileSystem.GetFileInfo(text);
			if ((fileInfo.Attributes & FileAttributes.ReadOnly) != 0)
			{
				File.SetAttributes(text, fileInfo.Attributes & ~FileAttributes.ReadOnly);
			}
			fileInfo = null;
			File.Delete(text);
		}
	}

	private static void a(string A_0, string A_1, bool A_2, Collection<string> A_3)
	{
		string text = Path.ChangeExtension(A_0, A_1);
		if (A_2)
		{
			text = a(new string[1] { Path.GetFileName(text) });
		}
		else if (!File.Exists(text))
		{
			return;
		}
		if (!string.IsNullOrEmpty(text) && !A_3.Contains(text))
		{
			A_3.Add(text);
		}
	}

	public static void a(string A_0, bool A_1, bool A_2, Collection<string> A_3)
	{
		if (!A_3.Contains(A_0))
		{
			A_3.Add(A_0);
		}
		string a_ = ((!A_1) ? A_0 : gf.c(Path.GetFileName(A_0)));
		if (j(a_))
		{
			a(a_, g(a_), A_2, A_3);
			a(a_, f(a_), A_2, A_3);
		}
		else if (k(a_))
		{
			a(a_, i(a_), A_2, A_3);
			a(a_, h(a_), A_2, A_3);
		}
		else
		{
			if (!m(a_))
			{
				return;
			}
			jc A_4 = null;
			string directory = null;
			if (!A_2)
			{
				directory = Path.GetDirectoryName(A_0);
			}
			short A_5 = 0;
			string A_6 = null;
			string A_7 = null;
			int A_8 = 0;
			string A_9 = null;
			int A_10 = 0;
			d[] A_11 = null;
			string[] A_12 = null;
			b(A_0, A_1, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8, ref A_9, ref A_10, ref A_11, ref A_12);
			A_12 = A_4.b;
			foreach (string text in A_12)
			{
				string[] array = new string[3]
				{
					text + ".fmnnn",
					text + ".fibnk",
					text + ".fitnk"
				};
				string text2;
				if (A_2)
				{
					text2 = a(array);
				}
				else
				{
					ReadOnlyCollection<string> files = global::c.e().FileSystem.GetFiles(directory, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, array);
					text2 = ((files.Count <= 0) ? string.Empty : files[0]);
				}
				if (!string.IsNullOrEmpty(text2))
				{
					a(text2, A_1, A_2, A_3);
				}
			}
		}
	}

	public static string c()
	{
		return "Material Files";
	}

	public static string b()
	{
		return "*.fmnnn;*.fmkkk;*.nnn;*.kkk;*.fibnk;*.fitnk;*.fibnx;*.fitnx";
	}

	public static bool q(string A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		string text = A_0.ToLower();
		return text.EndsWith(".fibnk") || text.EndsWith(".fmnnn") || text.EndsWith(".fmkkk") || text.EndsWith(".fibnx");
	}

	public static bool p(string A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		return o(A_0.ToLower());
	}

	private static bool o(string A_0)
	{
		if (!A_0.EndsWith(".fibnk") && !A_0.EndsWith(".fitnk"))
		{
			return A_0.EndsWith(".mat");
		}
		return true;
	}

	public static bool n(string A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		string a_ = A_0.ToLower();
		return o(a_) || l(a_);
	}

	public static bool m(string A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		return l(A_0.ToLower());
	}

	private static bool l(string A_0)
	{
		if (!A_0.EndsWith(".fibnx"))
		{
			return A_0.EndsWith(".fitnx");
		}
		return true;
	}

	public static bool k(string A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		string text = A_0.ToLower();
		return text.EndsWith(".fmkkk") || text.EndsWith(".kkk");
	}

	public static bool j(string A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		string text = A_0.ToLower();
		return text.EndsWith(".fmnnn") || text.EndsWith(".nnn");
	}

	public static string i(string A_0)
	{
		string text = A_0.ToLower();
		if (text.EndsWith(".nnn") || text.EndsWith(".kkk"))
		{
			return ".nnn";
		}
		if (text.EndsWith(".fmnnn") || text.EndsWith(".fmkkk"))
		{
			return ".fmnnn";
		}
		throw new ApplicationException("Error - Material file type is unknown");
	}

	public static string h(string A_0)
	{
		string text = A_0.ToLower();
		if (text.EndsWith(".nnn") || text.EndsWith(".kkk"))
		{
			return ".fmnnn";
		}
		if (text.EndsWith(".fmnnn") || text.EndsWith(".fmkkk"))
		{
			return ".nnn";
		}
		throw new ApplicationException("Error - Material file type is unknown");
	}

	public static string g(string A_0)
	{
		string text = A_0.ToLower();
		if (text.EndsWith(".nnn") || text.EndsWith(".kkk"))
		{
			return ".kkk";
		}
		if (text.EndsWith(".fmnnn") || text.EndsWith(".fmkkk"))
		{
			return ".fmkkk";
		}
		throw new ApplicationException("Error - Material file type is unknown");
	}

	public static string f(string A_0)
	{
		string text = A_0.ToLower();
		if (text.EndsWith(".nnn") || text.EndsWith(".kkk"))
		{
			return ".fmkkk";
		}
		if (text.EndsWith(".fmnnn") || text.EndsWith(".fmkkk"))
		{
			return ".kkk";
		}
		throw new ApplicationException("Error - Material file type is unknown");
	}

	public static bool e(string A_0)
	{
		Collection<string> collection = k();
		foreach (string item in collection)
		{
			if (A_0.StartsWith(item, StringComparison.CurrentCultureIgnoreCase))
			{
				return true;
			}
		}
		return false;
	}

	public static bool d(string A_0)
	{
		if (!n(A_0) && !j(A_0))
		{
			return k(A_0);
		}
		return true;
	}

	public static int c(string A_0)
	{
		string extension = Path.GetExtension(A_0.ToLower());
		uint num = jo.a(extension);
		if (num <= 707207476)
		{
			if (num <= 263973468)
			{
				if (num != 255097902)
				{
					if (num == 263973468 && Operators.CompareString(extension, ".kkk", TextCompare: false) == 0)
					{
						goto IL_010b;
					}
				}
				else if (Operators.CompareString(extension, ".fmnnn", TextCompare: false) == 0)
				{
					goto IL_0117;
				}
			}
			else
			{
				switch (num)
				{
				case 489098429u:
					if (Operators.CompareString(extension, ".fibnk", TextCompare: false) != 0)
					{
						break;
					}
					return 5;
				case 707207476u:
					if (Operators.CompareString(extension, ".fibnx", TextCompare: false) != 0)
					{
						break;
					}
					return 6;
				}
			}
		}
		else if (num <= 3078725555u)
		{
			if (num != 769286741)
			{
				if (num == 3078725555u && Operators.CompareString(extension, ".fitnk", TextCompare: false) == 0)
				{
					return 2;
				}
			}
			else if (Operators.CompareString(extension, ".nnn", TextCompare: false) == 0)
			{
				goto IL_010b;
			}
		}
		else if (num != 3363945078u)
		{
			if (num == 3424194151u && Operators.CompareString(extension, ".fmkkk", TextCompare: false) == 0)
			{
				goto IL_0117;
			}
		}
		else if (Operators.CompareString(extension, ".fitnx", TextCompare: false) == 0)
		{
			return 3;
		}
		throw new ApplicationException("Unknown material file type");
		IL_010b:
		return 1;
		IL_0117:
		return 4;
	}

	public static void a(string A_0, fz A_1, StreamWriter A_2)
	{
		string fileName = Path.GetFileName(A_0);
		string text = i3.m() + "\\Material\\";
		bool flag = default(bool);
		if (File.Exists(text + fileName))
		{
			FileInfo fileInfo = new FileInfo(A_0);
			FileInfo fileInfo2 = new FileInfo(text);
			if (i3.a(fileInfo2.LastWriteTimeUtc, fileInfo.LastWriteTimeUtc))
			{
				flag = DateTime.Compare(fileInfo2.LastWriteTimeUtc, fileInfo.LastWriteTimeUtc) < 0;
			}
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			string text2 = text + fileName;
			global::c.e().FileSystem.CopyFile(A_0, text2, overwrite: true);
			A_2.WriteLine(text2);
		}
	}

	public static void a(string A_0, ref bool A_1, ref float A_2, ref string A_3)
	{
		int length = "Generic, n=".Length;
		if (float.TryParse(A_0.Substring(length), NumberStyles.Float, CultureInfo.InvariantCulture, out A_2))
		{
			if ((double)A_2 < 0.1 || (double)A_2 > 50.0)
			{
				string A_4 = "RefractiveIndex";
				string arg = hu.a(ref A_4);
				float num = 0.1f;
				float num2 = 50f;
				A_4 = "InvalidValueFor1Between2And3Fmt3";
				A_3 = string.Format(hu.a(ref A_4), arg, num, num2);
				A_1 = false;
			}
			else
			{
				A_1 = true;
			}
		}
		else
		{
			string arg = A_0.Substring(length);
			float num = float.MinValue;
			float num2 = float.MaxValue;
			string A_4 = "InvalidValueFor1Between2And3Fmt3";
			A_3 = string.Format(hu.a(ref A_4), arg, num, num2);
			A_1 = false;
		}
	}

	public static void a(ref fl A_0, hc A_1, int A_2, bool A_3, je A_4, fz A_5, eo.a A_6)
	{
		bool flag = false;
		bool flag2 = false;
		string A_7 = "CurveTypeOpticalConstant";
		string a_ = hu.a(ref A_7);
		A_0.g1();
		hc hc2 = A_1;
		gc obj = hc2.cy().bv(A_2, 0);
		bool a_2 = hc2.cy().dh().ax(A_6);
		flag = obj.ah(a_2) && hc2.ek() > 0;
		flag2 = obj.aj(a_2) && hc2.em() > 0;
		A_0.s(ey.a8());
		if (flag & flag2)
		{
			A_0.o(ey.ab(), ey.aa(), hr.af(hr.b.h));
		}
		else if (flag)
		{
			fl obj2 = A_0;
			A_7 = "LayerN";
			string a_3 = hu.a(ref A_7);
			A_7 = "LayerNAbbrev";
			obj2.o(a_3, hu.a(ref A_7), hr.af(hr.b.h));
		}
		else
		{
			fl obj3 = A_0;
			A_7 = "LayerK";
			string a_4 = hu.a(ref A_7);
			A_7 = "LayerKAbbrev";
			obj3.o(a_4, hu.a(ref A_7), hr.af(hr.b.i));
		}
		bool A_8 = false;
		if (flag)
		{
			ch ch2 = hc2.cy(A_2);
			if (ch2.bk())
			{
				if (!string.IsNullOrEmpty(ch2.am()))
				{
					string text = "";
					eo eo2 = A_1.cy().dh();
					if (eo2.a8())
					{
						text = eo2.a9();
					}
					else if (eo2.a3())
					{
						text = eo2.ba();
					}
					eo2 = null;
					if (A_1.cy().dh().a8() || A_1.cy().dh().a3())
					{
						bool flag3 = A_4.b(ch2.am(), ch2.ao());
						if (!flag3 && !string.IsNullOrEmpty(text))
						{
							new dp().a(text, ch2.am(), ch2.ao(), ch2.ap(), i6.a(A_0), "Obtaining permission to view initial guess nk data...", A_5, ref A_8);
							if (A_8)
							{
								A_4.a(ch2.am(), ch2.ao());
							}
						}
						else
						{
							A_8 = flag3;
						}
					}
					else if (File.Exists(Path.ChangeExtension(d() + "\\" + ch2.ap(), ".fivrq")))
					{
						string text2 = ch2.am();
						int num = ch2.ao();
						string a_5 = ch2.ap();
						dg obj4 = new dg();
						eo eo3 = A_1.cy().dh();
						obj4.a(eo3.ba(), eo3.bd(), eo3.be(), eo3.bf(), text2, num, a_5, i6.a(A_0), "Obtaining permission to view initial guess nk data...", ref A_8);
						if (A_8)
						{
							A_4.a(text2, num);
						}
						eo3 = null;
					}
				}
			}
			else
			{
				A_8 = true;
			}
			ch2 = null;
			if (A_8)
			{
				fl obj5 = A_0;
				double[] a_6 = hc2.cy(A_2).cz();
				double[] a_7 = hc2.cy(A_2).c0();
				int a_8 = hc2.cy(A_2).c2();
				long a_9 = hc2.cn().b9();
				long a_10 = hc2.cn().ca();
				A_7 = "CurveNameWithInitialGuess_n_Fmt1";
				obj5.p(a_6, a_7, a_8, a_9, a_10, 0.0, string.Format(hu.a(ref A_7), hc2.cn().b5()), a_, A_8: true, A_9: false, A_10: false, Color.Blue);
			}
			fl obj6 = A_0;
			double[] a_11 = hc2.cz(A_2).cz();
			double[] a_12 = hc2.cz(A_2).c0();
			int a_13 = hc2.cz(A_2).c2();
			long a_14 = checked(hc2.cn().b9() + 1);
			long a_15 = hc2.cn().ca();
			A_7 = "CurveNameWithCalculated_n_Fmt1";
			obj6.o(a_11, a_12, a_13, a_14, a_15, 0.0, string.Format(hu.a(ref A_7), hc2.cn().b5()), a_, A_8: true, A_9: false, A_10: false, Color.Red);
		}
		int num2;
		if (flag2)
		{
			if (A_8 || !flag)
			{
				if (!hc2.c0(A_2).bk())
				{
					num2 = 1;
					goto IL_03cc;
				}
				if (flag)
				{
					num2 = (hc2.cy(A_2).bk() ? 1 : 0);
					if (num2 != 0)
					{
						goto IL_03cc;
					}
				}
				else
				{
					num2 = 0;
				}
			}
			else
			{
				num2 = 0;
			}
			goto IL_04c0;
		}
		goto IL_05b9;
		IL_03cc:
		if (flag)
		{
			fl obj7 = A_0;
			double[] a_16 = hc2.c0(A_2).cz();
			double[] a_17 = hc2.c0(A_2).c0();
			int a_18 = hc2.c0(A_2).c2();
			long a_19 = checked(hc2.cn().b9() + 2);
			long a_20 = hc2.cn().ca();
			A_7 = "CurveNameWithInitialGuess_k_Fmt1";
			obj7.o(a_16, a_17, a_18, a_19, a_20, 0.0, string.Format(hu.a(ref A_7), hc2.cn().b5()), a_, A_8: true, A_9: false, A_10: false, Color.Navy);
		}
		else
		{
			fl obj8 = A_0;
			double[] a_21 = hc2.c0(A_2).cz();
			double[] a_22 = hc2.c0(A_2).c0();
			int a_23 = hc2.c0(A_2).c2();
			long a_24 = hc2.cn().b9();
			long a_25 = hc2.cn().ca();
			A_7 = "CurveNameWithInitialGuess_k_Fmt1";
			obj8.p(a_21, a_22, a_23, a_24, a_25, 0.0, string.Format(hu.a(ref A_7), hc2.cn().b5()), a_, A_8: true, A_9: false, A_10: false, Color.Navy);
		}
		goto IL_04c0;
		IL_05b9:
		hc2 = null;
		return;
		IL_04c0:
		checked
		{
			if (num2 != 0 || flag)
			{
				fl obj9 = A_0;
				double[] a_26 = hc2.c1(A_2).cz();
				double[] a_27 = hc2.c1(A_2).c0();
				int a_28 = hc2.c1(A_2).c2();
				long a_29 = hc2.cn().b9() + 3;
				long a_30 = hc2.cn().ca();
				A_7 = "CurveNameWithCalculated_k_Fmt1";
				obj9.o(a_26, a_27, a_28, a_29, a_30, 0.0, string.Format(hu.a(ref A_7), hc2.cn().b5()), a_, A_8: true, A_9: false, A_10: false, Color.Brown);
			}
			else
			{
				fl obj10 = A_0;
				double[] a_31 = hc2.c1(A_2).cz();
				double[] a_32 = hc2.c1(A_2).c0();
				int a_33 = hc2.c1(A_2).c2();
				long a_34 = hc2.cn().b9() + 3;
				long a_35 = hc2.cn().ca();
				A_7 = "CurveNameWithCalculated_k_Fmt1";
				obj10.p(a_31, a_32, a_33, a_34, a_35, 0.0, string.Format(hu.a(ref A_7), hc2.cn().b5()), a_, A_8: true, A_9: true, A_10: false, Color.Brown);
			}
			goto IL_05b9;
		}
	}

	public static void a(Collection<a5> A_0, int A_1, int A_2)
	{
		string text = d();
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		if (!Directory.Exists(i3.g()))
		{
			Directory.CreateDirectory(i3.g());
		}
		for (int num = A_1; num <= A_2; num = checked(num + 1))
		{
			a5 a10 = A_0[num];
			if (gd.k(Path.GetExtension(a10.d())))
			{
				a10.f(global::c.e().FileSystem.SpecialDirectories.Temp + "\\" + Path.GetFileName(a10.d()));
			}
			else if (Operators.CompareString(Path.GetExtension(a10.d()), ".pat", TextCompare: false) == 0)
			{
				a10.f(i3.g() + "\\" + Path.GetFileName(a10.d()));
			}
			else
			{
				string text2 = Path.GetDirectoryName(s(Path.GetFileNameWithoutExtension(a10.d())));
				if (string.IsNullOrEmpty(text2))
				{
					text2 = text;
				}
				a10.f(text2 + "\\" + Path.GetFileName(a10.d()));
			}
			a10 = null;
		}
	}

	[SpecialName]
	public static string a()
	{
		return global::e.a().TechSupportFilesRootPath + "\\MatWebDB\\";
	}

	public static bool b(string A_0)
	{
		string text = A_0.ToLower();
		if (!text.StartsWith("schott"))
		{
			return text.StartsWith("ohara");
		}
		return true;
	}

	public static void a(eo A_0, hd A_1, fz A_2)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(h());
		string text = "\t";
		string text2 = global::e.a().TechSupportFilesRootPath + "\\MatWebDB\\";
		if (!Directory.Exists(text2))
		{
			Directory.CreateDirectory(text2);
		}
		if (Directory.Exists(text2 + "Encrypted\\"))
		{
			global::c.e().FileSystem.DeleteDirectory(text2 + "Encrypted\\", DeleteDirectoryOption.DeleteAllContents);
		}
		if (Directory.Exists(text2 + "Encrypted\\GraphData\\"))
		{
			global::c.e().FileSystem.DeleteDirectory(text2 + "Encrypted\\GraphData\\", DeleteDirectoryOption.DeleteAllContents);
		}
		if (Directory.Exists(text2 + "Unencrypted\\"))
		{
			global::c.e().FileSystem.DeleteDirectory(text2 + "Unencrypted\\", DeleteDirectoryOption.DeleteAllContents);
		}
		if (Directory.Exists(text2 + "Unencrypted\\GraphData\\"))
		{
			global::c.e().FileSystem.DeleteDirectory(text2 + "Unencrypted\\GraphData\\", DeleteDirectoryOption.DeleteAllContents);
		}
		if (Directory.Exists(text2 + "Unencrypted with Permission\\"))
		{
			global::c.e().FileSystem.DeleteDirectory(text2 + "Unencrypted with Permission\\", DeleteDirectoryOption.DeleteAllContents);
		}
		if (Directory.Exists(text2 + "Unencrypted with Permission\\GraphData\\"))
		{
			global::c.e().FileSystem.DeleteDirectory(text2 + "Unencrypted with Permission\\GraphData\\", DeleteDirectoryOption.DeleteAllContents);
		}
		if (Directory.Exists(text2 + "ReflCalcMatFiles\\"))
		{
			global::c.e().FileSystem.DeleteDirectory(text2 + "ReflCalcMatFiles\\", DeleteDirectoryOption.DeleteAllContents);
		}
		Directory.CreateDirectory(text2 + "ReflCalcMatFiles\\");
		string text3 = null;
		string text4 = text2 + "Synonyms-All.csv";
		string path = text2 + "Synonyms-Added.csv";
		string path2 = text2 + "Synonyms-Deleted.csv";
		try
		{
			if (File.Exists(text4))
			{
				int num = 0;
				do
				{
					num = checked(num + 1);
					text3 = text2 + "Synonyms-All-" + num.ToString().Trim() + ".csv";
				}
				while (File.Exists(text3));
				global::c.e().FileSystem.RenameFile(text4, Path.GetFileName(text3));
			}
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			if (File.Exists(path2))
			{
				File.Delete(path2);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			fe.b(A_2, "Unable to update website material folder due to error. Error is " + ex3.ToString(), new Point(0, 0));
			ProjectData.ClearProjectError();
			return;
		}
		string value = "Material Filename" + text + "n@632nm" + text + "k@632nm" + text + d(jb.d.d) + text + d(jb.d.e) + text + "Synonyms" + text + "Public Info" + text + "# Links";
		FileInfo[] files = directoryInfo.GetFiles("*.*", System.IO.SearchOption.TopDirectoryOnly);
		List<TextWriter> list = new List<TextWriter>();
		StreamWriter streamWriter = null;
		StreamWriter streamWriter2 = null;
		StreamWriter streamWriter3 = null;
		try
		{
			f f10 = (f)checked((short)Enum.GetValues(typeof(f)).GetUpperBound(0));
			for (f f11 = jb.f.a; f11 <= f10; f11++)
			{
				list.Add(new StreamWriter(File.Open(text2 + "Summary" + b(f11) + ".txt", FileMode.Create), Encoding.UTF8));
				list[(int)f11].WriteLine(value);
			}
			j j2 = null;
			Collection<eb.c> A_3 = null;
			List<h> list2 = new List<h>();
			DateTime A_4 = DateTime.MinValue;
			DateTime A_5 = DateTime.MinValue;
			LicenseLevel A_6 = LicenseLevel.Unlicensed;
			d9.a(eb.b.a, ref A_4, ref A_5, ref A_6, ref A_3);
			FileInfo[] array = files;
			bool A_7 = default(bool);
			bool A_8 = default(bool);
			bool A_9 = default(bool);
			bool A_10 = default(bool);
			bool A_11 = default(bool);
			bool A_12 = default(bool);
			bool A_13 = default(bool);
			foreach (FileInfo fileInfo in array)
			{
				if (!d(fileInfo.Name) || Path.GetFileNameWithoutExtension(fileInfo.Name).ToLower().EndsWith("#Public#".ToLower()))
				{
					continue;
				}
				bool flag = false;
				eb.a a10 = d9.a(A_3, Path.GetFileNameWithoutExtension(fileInfo.Name));
				if (a10 != eb.a.b && a10 != eb.a.c && a10 != eb.a.a)
				{
					j2 = new j();
					if (string.Compare(Path.GetFileNameWithoutExtension(fileInfo.Name), "Insulator", ignoreCase: true) != 0)
					{
						a(fileInfo, A_0, A_1, j2, ref A_7, ref A_8, ref A_9, ref A_10, ref A_11, ref A_12, ref A_13, list2);
						if (A_13)
						{
							flag = true;
							f f12 = (f)checked((short)Enum.GetValues(typeof(f)).GetUpperBound(0));
							for (f f13 = jb.f.a; f13 <= f12; f13++)
							{
								list[(int)f13].WriteLine(j2.f(fileInfo.Name, f13));
							}
						}
					}
					else
					{
						j2.c = jb.g.b;
						flag = true;
					}
				}
				if (!flag)
				{
					continue;
				}
				string text5 = a(fileInfo.FullName);
				bool flag2 = File.Exists(text5);
				if (!b(fileInfo.Name) && (j2.c == jb.g.b || flag2))
				{
					if (flag2)
					{
						File.Copy(text5, text2 + "ReflCalcMatFiles\\" + Path.GetFileName(text5).Replace(" #Public#", ""));
					}
					else
					{
						File.Copy(fileInfo.FullName, text2 + "ReflCalcMatFiles\\" + fileInfo.Name);
					}
				}
			}
			checked
			{
				int num3 = list2.Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					int num5 = list2.Count - 1;
					int num6 = num4;
					for (int num7 = num5; num7 >= num6; num7 += -1)
					{
						if (DateTime.Compare(list2[num4].b, list2[num7].b) > 0)
						{
							h value2 = list2[num4];
							list2[num4] = list2[num7];
							list2[num7] = value2;
						}
					}
				}
				streamWriter = new StreamWriter(File.Open(text4, FileMode.Create), Encoding.ASCII);
				streamWriter.WriteLine("\"Synonym\",\"File Date\",\"Mat File Name\"");
				foreach (h item in list2)
				{
					streamWriter.WriteLine("\"" + item.a.Replace("\"", "\"\"") + "\"," + item.b.ToString("g") + ",\"" + item.c.Replace("\"", "\"\"") + "\"");
					h current = null;
				}
				if (string.IsNullOrEmpty(text3))
				{
					return;
				}
				string a_ = File.ReadAllText(text3, Encoding.ASCII) + "\r\n";
				List<string> list3 = new List<string>();
				string A_14 = null;
				int A_15 = default(int);
				i3.a(ref A_15, a_);
				bool A_16 = default(bool);
				do
				{
					i3.a(ref A_15, a_, ref A_14, A_3: true, ref A_16);
					if (!A_16)
					{
						list3.Add(A_14.Replace("\"\"", "\""));
						i3.a(ref A_15, a_);
					}
				}
				while (!A_16);
				List<string> list4 = new List<string>();
				List<string> list5 = new List<string>();
				foreach (h item2 in list2)
				{
					bool flag3 = false;
					foreach (string item3 in list3)
					{
						if (item2.a.Equals(item3, StringComparison.CurrentCultureIgnoreCase))
						{
							flag3 = true;
							break;
						}
					}
					if (!flag3)
					{
						list4.Add(item2.a);
					}
				}
				foreach (string item4 in list3)
				{
					bool flag3 = false;
					foreach (h item5 in list2)
					{
						if (item5.a.Equals(item4, StringComparison.CurrentCultureIgnoreCase))
						{
							flag3 = true;
							break;
						}
					}
					if (!flag3)
					{
						list5.Add(item4);
					}
				}
				if (list4.Count > 0)
				{
					list4.Sort();
					streamWriter2 = new StreamWriter(File.Open(path, FileMode.Create), Encoding.ASCII);
					foreach (string item6 in list4)
					{
						streamWriter2.WriteLine("\"" + item6.Replace("\"", "\"\"") + "\"");
					}
				}
				if (list5.Count <= 0)
				{
					return;
				}
				list5.Sort();
				streamWriter3 = new StreamWriter(File.Open(path2, FileMode.Create), Encoding.ASCII);
				foreach (string item7 in list5)
				{
					streamWriter3.WriteLine("\"" + item7.Replace("\"", "\"\"") + "\"");
				}
			}
		}
		finally
		{
			f f14 = (f)checked((short)Enum.GetValues(typeof(f)).GetUpperBound(0));
			for (f f15 = jb.f.a; f15 <= f14; f15++)
			{
				if (list[(int)f15] != null)
				{
					list[(int)f15].Close();
				}
			}
			streamWriter?.Close();
			streamWriter2?.Close();
			streamWriter3?.Close();
		}
	}

	private static void a(string A_0, string A_1, DateTime A_2, List<h> A_3)
	{
		bool flag = false;
		foreach (h item in A_3)
		{
			if (item.a.Equals(A_0, StringComparison.CurrentCultureIgnoreCase))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			A_3.Add(new h(A_0, A_1, A_2));
		}
	}

	public static string a(string A_0)
	{
		string fileName = Path.GetFileName(A_0);
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
		return A_0.Substring(0, checked(A_0.Length - fileName.Length)) + fileNameWithoutExtension + " #Public#.fibnk";
	}

	private static void a(FileInfo A_0, eo A_1, hd A_2, j A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, List<h> A_11)
	{
		double[] A_12 = null;
		double[] A_13 = null;
		double[] A_14 = null;
		string A_15 = null;
		string[] A_16 = null;
		d[] A_17 = null;
		A_10 = false;
		double[] A_18 = null;
		double[] A_19 = null;
		double[] A_20 = null;
		string A_21 = null;
		string[] A_22 = null;
		d[] A_23 = null;
		string text = a(A_0.FullName);
		string fileName = Path.GetFileName(A_0.FullName);
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
		short A_24 = 0;
		short A_25 = 0;
		int A_26 = 0;
		short[] A_27 = null;
		double[] A_28 = null;
		string A_29 = null;
		bool A_30 = false;
		bool A_31 = false;
		bool A_32 = false;
		string A_33 = null;
		int A_34 = 0;
		string A_35 = null;
		bool A_36 = false;
		string A_37 = null;
		jc A_38 = null;
		int A_39 = default(int);
		int A_40 = default(int);
		bool flag = default(bool);
		if (a(text, A_1: false, ref A_18, ref A_19, ref A_20, A_5: true, A_6: true, ref A_39, A_2, ref A_24, ref A_25, ref A_26, ref A_27, ref A_28, A_1, ref A_29, ref A_30, ref A_31, ref A_32, ref A_21, ref A_33, ref A_34, ref A_35, ref A_40, ref A_23, ref A_22, ref A_36, ref A_37, ref A_38, null) == jb.a.a)
		{
			flag = true;
			File.GetLastWriteTimeUtc(text);
		}
		string fullName = A_0.FullName;
		A_25 = 0;
		A_24 = 0;
		A_34 = 0;
		A_27 = null;
		A_28 = null;
		A_37 = null;
		A_36 = false;
		A_32 = false;
		A_31 = false;
		A_35 = null;
		A_26 = 0;
		A_33 = null;
		A_30 = false;
		A_29 = null;
		A_38 = null;
		int A_41 = default(int);
		int A_42 = default(int);
		a(fullName, A_1: false, ref A_12, ref A_13, ref A_14, A_5: true, A_6: true, ref A_41, A_2, ref A_25, ref A_24, ref A_34, ref A_27, ref A_28, A_1, ref A_37, ref A_36, ref A_32, ref A_31, ref A_15, ref A_35, ref A_26, ref A_33, ref A_42, ref A_17, ref A_16, ref A_30, ref A_29, ref A_38, null);
		if (A_41 <= 0)
		{
			return;
		}
		double A_43 = default(double);
		double A_44 = default(double);
		if (flag)
		{
			a(A_39, A_18, A_19, A_20, ref A_43, ref A_44);
		}
		else
		{
			a(A_41, A_12, A_13, A_14, ref A_43, ref A_44);
		}
		string a_ = global::e.a().TechSupportFilesRootPath + "\\MatWebDB\\";
		string empty = string.Empty;
		int num = -1;
		int num2 = -1;
		int num3 = -1;
		int num4 = -1;
		int num5 = -1;
		int num6 = -1;
		string text2;
		string text3;
		checked
		{
			if (A_17 != null)
			{
				A_26 = A_17.Length - 1;
				for (int num7 = 0; num7 <= A_26; num7++)
				{
					switch (A_17[num7])
					{
					case jb.d.e:
						num = num7;
						break;
					case jb.d.d:
						num2 = num7;
						break;
					case jb.d.g:
						num3 = num7;
						break;
					case jb.d.f:
						num4 = num7;
						break;
					case jb.d.i:
						num5 = num7;
						break;
					case jb.d.h:
						num6 = num7;
						break;
					case jb.d.m:
						A_15 = A_16[num7];
						break;
					}
				}
			}
			text2 = string.Empty;
			if (flag)
			{
				num2 = -1;
				if (A_23 != null)
				{
					A_34 = A_23.Length - 1;
					for (int num8 = 0; num8 <= A_34; num8++)
					{
						switch (A_23[num8])
						{
						case jb.d.d:
							num2 = num8;
							break;
						case jb.d.m:
							A_21 = A_22[num8];
							break;
						}
					}
				}
				if (!string.IsNullOrEmpty(A_21.Trim()))
				{
					text2 = A_21.Trim();
				}
			}
			else
			{
				text2 = A_15;
			}
			text3 = ((num2 == -1) ? "Filmetrics Composite" : ((!flag) ? A_16[num2] : A_22[num2]));
		}
		g g10 = (flag ? jb.g.b : ((g)((num != -1) ? checked((short)Conversions.ToInteger(A_16[num])) : 3)));
		string a_2 = ((num4 != -1) ? A_16[num4] : 0.ToString(CultureInfo.InvariantCulture));
		string a_3 = ((num3 != -1) ? A_16[num3] : 10000.ToString(CultureInfo.InvariantCulture));
		string a_4 = ((num6 != -1) ? A_16[num6] : 0.ToString(CultureInfo.InvariantCulture));
		string a_5 = ((num5 != -1) ? A_16[num5] : 10000.ToString(CultureInfo.InvariantCulture));
		A_3.a = b(A_43);
		A_3.b = a(A_44);
		A_3.e = new List<i>();
		i i10 = new i(jb.f.a);
		A_3.e.Add(i10);
		i10.b = text3;
		i10.c = text2;
		A_3.c = g10;
		if (g10 == jb.g.e || g10 == jb.g.a)
		{
			return;
		}
		a(fileNameWithoutExtension, fileName, A_0.LastWriteTimeUtc, A_11);
		checked
		{
			if (A_17 != null)
			{
				List<string> list = new List<string>();
				if (flag)
				{
					int num9 = A_40 - 1;
					for (int num10 = 0; num10 <= num9; num10++)
					{
						if (A_23[num10] == jb.d.j)
						{
							i10.d.Add(A_22[num10]);
						}
					}
				}
				else
				{
					int num11 = A_42 - 1;
					for (int num12 = 0; num12 <= num11; num12++)
					{
						if (A_17[num12] == jb.d.j)
						{
							i10.d.Add(A_16[num12]);
						}
					}
				}
				int num13 = A_42 - 1;
				for (int num14 = 0; num14 <= num13; num14++)
				{
					if (A_17[num14] == jb.d.a)
					{
						list.Add(A_16[num14]);
					}
				}
				if (list.Count > 0)
				{
					A_3.d = list.ToArray();
				}
				else
				{
					A_3.d = null;
				}
			}
			else
			{
				A_3.d = null;
			}
			if (A_3.d != null)
			{
				string[] array = A_3.d;
				for (int num15 = 0; num15 < array.Length; num15++)
				{
					a(array[num15], fileName, A_0.LastWriteTimeUtc, A_11);
				}
			}
		}
		f f10 = (f)checked((short)Enum.GetValues(typeof(f)).GetUpperBound(0));
		for (f f11 = jb.f.a; f11 <= f10; f11++)
		{
			if (f11 == jb.f.a)
			{
				continue;
			}
			i i11 = new i(f11);
			checked
			{
				if (flag)
				{
					int num16 = A_40 - 1;
					for (int num17 = 0; num17 <= num16; num17++)
					{
						if (A_23[num17] != jb.d.k || ah(A_22[num17]) != f11)
						{
							continue;
						}
						switch (ag(A_22[num17]))
						{
						case jb.e.b:
							i11.b = af(A_22[num17]);
							break;
						case jb.e.d:
							if (string.IsNullOrEmpty(i11.c))
							{
								i11.c = af(A_22[num17]);
							}
							break;
						case jb.e.c:
							i11.d.Add(af(A_22[num17]));
							break;
						case jb.e.e:
							i11.c = af(A_22[num17]);
							break;
						}
					}
				}
				else
				{
					int num18 = A_42 - 1;
					for (int num19 = 0; num19 <= num18; num19++)
					{
						if (A_17[num19] != jb.d.k || ah(A_16[num19]) != f11)
						{
							continue;
						}
						switch (ag(A_16[num19]))
						{
						case jb.e.b:
							i11.b = af(A_16[num19]);
							break;
						case jb.e.d:
							if (string.IsNullOrEmpty(i11.c))
							{
								i11.c = af(A_16[num19]);
							}
							break;
						case jb.e.c:
							i11.d.Add(af(A_16[num19]));
							break;
						case jb.e.e:
							i11.c = af(A_16[num19]);
							break;
						}
					}
				}
				i i12 = i11;
				if (string.IsNullOrEmpty(i12.c))
				{
					i12.c = i10.c;
				}
				if (string.IsNullOrEmpty(i12.b))
				{
					i12.b = i10.b;
				}
				if (i12.d.Count == 0)
				{
					i12.d = i10.d;
				}
				i12 = null;
				A_3.e.Add(i11);
			}
		}
		if (g10 == jb.g.b || flag)
		{
			if (flag)
			{
				a(jb.g.b, empty, A_0, 0.ToString(CultureInfo.InvariantCulture), 10000.ToString(CultureInfo.InvariantCulture), A_18, A_19, A_20, A_39, a_, ref A_4, ref A_7);
			}
			else
			{
				a(jb.g.b, empty, A_0, a_2, a_3, A_12, A_13, A_14, A_41, a_, ref A_4, ref A_7);
			}
		}
		if (g10 == jb.g.c || g10 == jb.g.b || flag)
		{
			if (flag)
			{
				a(jb.g.c, empty, A_0, 0.ToString(CultureInfo.InvariantCulture), 10000.ToString(CultureInfo.InvariantCulture), A_18, A_19, A_20, A_39, a_, ref A_5, ref A_8);
			}
			else
			{
				a(jb.g.c, empty, A_0, a_4, a_5, A_12, A_13, A_14, A_41, a_, ref A_5, ref A_8);
			}
		}
		a(jb.g.d, empty, A_0, null, null, A_12, A_13, A_14, A_41, a_, ref A_6, ref A_9);
		A_10 = true;
	}

	private static void a(g A_0, string A_1, FileInfo A_2, string A_3, string A_4, double[] A_5, double[] A_6, double[] A_7, int A_8, string A_9, ref bool A_10, ref bool A_11)
	{
		string text = "\t";
		string value = "Wavelength(nm)" + text + "n" + text + "k";
		A_1 = A_0 switch
		{
			jb.g.b => A_9 + "Unencrypted\\", 
			jb.g.c => A_9 + "Unencrypted with Permission\\", 
			jb.g.d => A_9 + "Encrypted\\", 
			_ => throw new ax("accessType"), 
		};
		if (!A_10 && !Directory.Exists(A_1))
		{
			Directory.CreateDirectory(A_1);
		}
		A_10 = true;
		string text2 = A_1 + "GraphData\\";
		if (!A_11 && !Directory.Exists(text2))
		{
			Directory.CreateDirectory(text2);
		}
		A_11 = true;
		List<float> list = new List<float>();
		List<float> list2 = new List<float>();
		List<float> list3 = new List<float>();
		bool flag = A_0 != jb.g.b;
		bool flag2 = false;
		checked
		{
			TextWriter textWriter;
			if (A_0 == jb.g.d)
			{
				A_1 += A_2.Name;
				File.Copy(A_2.FullName, A_1);
				int num = A_8 - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					list.Add((float)A_5[num2]);
					list2.Add((float)A_6[num2]);
					if (A_7[num2] > 0.0)
					{
						flag2 = true;
					}
					list3.Add((float)A_7[num2]);
				}
			}
			else
			{
				A_1 = A_1 + Path.GetFileNameWithoutExtension(A_2.Name) + ".txt";
				double num3 = double.Parse(A_3, CultureInfo.InvariantCulture);
				double num4 = double.Parse(A_4, CultureInfo.InvariantCulture);
				int A_12 = default(int);
				l l2 = b(num3, A_5, A_8, ref A_12);
				int A_13 = default(int);
				l l3 = a(num4, A_5, A_8, ref A_13);
				if (l2 == jb.l.d || l3 == jb.l.d)
				{
					return;
				}
				textWriter = new StreamWriter(File.Open(A_1, FileMode.Create), Encoding.UTF8);
				try
				{
					textWriter.WriteLine(value);
					if (l2 == jb.l.a)
					{
						double num5 = a(A_12, A_6, num3, A_5);
						double num6 = a(A_12, A_7, num3, A_5);
						textWriter.WriteLine(c(num3) + text + b(num5) + text + a(num6));
						list.Add((float)num3);
						list2.Add((float)num5);
						if (num6 > 0.0)
						{
							flag2 = true;
						}
						list3.Add((float)num6);
					}
					if (l2 == jb.l.c)
					{
						A_12 = 0;
					}
					int num7 = ((l3 != jb.l.c) ? A_13 : (A_8 - 1));
					int num8 = A_12;
					int num9 = num7;
					for (int num10 = num8; num10 <= num9; num10++)
					{
						textWriter.WriteLine(c(A_5[num10]) + text + b(A_6[num10]) + text + a(A_7[num10]));
						list.Add((float)A_5[num10]);
						list2.Add((float)A_6[num10]);
						if (A_7[num10] > 0.0)
						{
							flag2 = true;
						}
						list3.Add((float)A_7[num10]);
					}
					if (l3 == jb.l.a)
					{
						double num11 = a(A_13 + 1, A_6, num4, A_5);
						double num12 = a(A_13 + 1, A_7, num4, A_5);
						textWriter.WriteLine(c(num4) + text + b(num11) + text + a(num12));
						list.Add((float)num4);
						list2.Add((float)num11);
						if (num12 > 0.0)
						{
							flag2 = true;
						}
						list3.Add((float)num12);
					}
				}
				finally
				{
					textWriter.Close();
				}
			}
			if (flag)
			{
				double num13 = double.MaxValue;
				double num14 = double.MinValue;
				double num15 = double.MaxValue;
				double num16 = double.MinValue;
				int num17 = list.Count - 1;
				for (int num18 = 0; num18 <= num17; num18++)
				{
					if (flag2)
					{
						if ((double)list3[num18] > num16)
						{
							num16 = list3[num18];
						}
						if ((double)list3[num18] < num15)
						{
							num15 = list3[num18];
						}
					}
					if ((double)list2[num18] > num14)
					{
						num14 = list2[num18];
					}
					if ((double)list2[num18] < num13)
					{
						num13 = list2[num18];
					}
				}
				Random random = new Random();
				double num19 = 1.0 + 0.1 * random.NextDouble();
				double num20 = 1.0 + 0.1 * random.NextDouble();
				double num21 = num14 - num13;
				double num22 = default(double);
				if (flag2)
				{
					num22 = num16 - num15;
				}
				int num23 = list.Count - 1;
				for (int num24 = 0; num24 <= num23; num24++)
				{
					if (flag2)
					{
						list3[num24] = (float)Math.Log((double)list3[num24] - num15 + num22 * num20);
					}
					list2[num24] = (float)Math.Log((double)list2[num24] - num13 + num21 * num19);
				}
			}
			textWriter = new StreamWriter(File.Open(text2 + Path.GetFileNameWithoutExtension(A_1) + ".n.txt", FileMode.Create), Encoding.UTF8);
			try
			{
				textWriter.WriteLine("Wavelength (nm)" + text + "n");
				int num25 = list.Count - 1;
				for (int num26 = 0; num26 <= num25; num26++)
				{
					textWriter.WriteLine(list[num26].ToString(CultureInfo.InvariantCulture) + text + list2[num26].ToString(CultureInfo.InvariantCulture));
				}
			}
			finally
			{
				textWriter.Close();
			}
			if (!flag2)
			{
				return;
			}
			textWriter = new StreamWriter(File.Open(text2 + Path.GetFileNameWithoutExtension(A_1) + ".k.txt", FileMode.Create), Encoding.UTF8);
			try
			{
				textWriter.WriteLine("Wavelength (nm)" + text + "k");
				int num27 = list.Count - 1;
				for (int num28 = 0; num28 <= num27; num28++)
				{
					textWriter.WriteLine(list[num28].ToString(CultureInfo.InvariantCulture) + text + list3[num28].ToString(CultureInfo.InvariantCulture));
				}
			}
			finally
			{
				textWriter.Close();
			}
		}
	}

	private static l b(double A_0, double[] A_1, int A_2, ref int A_3)
	{
		if (jf.d(A_0, A_1[0]))
		{
			return jb.l.c;
		}
		checked
		{
			if (jf.b(A_0, A_1[A_2 - 1]))
			{
				return jb.l.d;
			}
			int num = A_2 - 1;
			for (A_3 = 0; A_3 <= num; A_3++)
			{
				if (jf.e(A_0, A_1[A_3]))
				{
					return jb.l.b;
				}
				if (jf.b(A_1[A_3], A_0))
				{
					return jb.l.a;
				}
			}
			return jb.l.a;
		}
	}

	private static l a(double A_0, double[] A_1, int A_2, ref int A_3)
	{
		if (jf.d(A_0, A_1[0]))
		{
			return jb.l.d;
		}
		checked
		{
			if (jf.b(A_0, A_1[A_2 - 1]))
			{
				return jb.l.c;
			}
			int num = A_2 - 1;
			for (A_3 = num; A_3 >= 0; A_3 += -1)
			{
				if (jf.e(A_0, A_1[A_3]))
				{
					return jb.l.b;
				}
				if (jf.d(A_1[A_3], A_0))
				{
					return jb.l.a;
				}
			}
			return jb.l.a;
		}
	}

	private static double a(int A_0, double[] A_1, double A_2, double[] A_3)
	{
		return checked((A_1[A_0] - A_1[A_0 - 1]) * (A_2 - A_3[A_0 - 1]) / (A_3[A_0] - A_3[A_0 - 1]) + A_1[A_0 - 1]);
	}

	private static void a(int A_0, double[] A_1, double[] A_2, double[] A_3, ref double A_4, ref double A_5)
	{
		double[] A_6 = new double[1] { 632.8 };
		checked
		{
			int num = A_6.GetUpperBound(0) + 1;
			double[] A_7 = new double[num - 1 + 1];
			if (A_0 > 0)
			{
				jf.a(ref A_1, ref A_2, A_0, ref A_6, ref A_7, num);
				A_4 = A_7[0];
				if (A_3 != null)
				{
					jf.a(ref A_1, ref A_3, A_0, ref A_6, ref A_7, num);
					A_5 = A_7[0];
				}
			}
		}
	}

	public static bool a(string A_0, fz A_1, Point A_2)
	{
		string pattern = "^[A-Z]+([a-zA-z0-9]|\\s\\-\\s+[A-Z]+[a-zA-z0-9])+$";
		bool flag = Regex.IsMatch(A_0, pattern);
		if (!flag)
		{
			return fe.b(ref A_1, "Filmetrics material name format violation.\r\nExample valid Material name: SiO2 - CustomerA\r\n\r\nValid material names must have the following format:\r\n-First character is uppercase English letter (A-Z),\r\n-Subsequent characters alphanumeric (A-Z, a-z, 0-9)\r\n-Hyphen character must be surrounded by spaces if it is present (eg. SiO2 - CustomerA)\r\n\r\nDo you want to override the warning and save anyway?\r\n", "Warning", "Yes", "No", A_2);
		}
		return flag;
	}

	private static string a(g A_0)
	{
		int num = (int)A_0;
		return num + "-" + b(A_0);
	}

	public static string a(eb.a A_0)
	{
		switch (A_0)
		{
		case eb.a.a:
		case eb.a.b:
		case eb.a.e:
		case eb.a.g:
			return a(jb.g.a);
		case eb.a.c:
			return a(jb.g.e);
		case eb.a.d:
		case eb.a.f:
			return a(jb.g.d);
		default:
			throw new ax("Invalid argument in OMDBMapToWebDBLevel");
		}
	}
}
