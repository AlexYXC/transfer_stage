using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

internal class gd
{
	public DateTime a;

	public string b;

	public string c;

	public bool d;

	public Guid e;

	public const string f = ".fibls";

	public const string g = ".fitls";

	public const string h = ".fibss";

	public const string i = ".fitss";

	public const string j = ".fibbl";

	public const string k = ".fibtl";

	public const string l = ".fibbs";

	public const string m = ".fibts";

	private const string m_n = "\\LayerStacks\\";

	public const string o = "Stack: ";

	public const string p = "Default Layer Stack";

	public const string q = "Default Substrate Layer Stack";

	public const string r = "Encrypted Layer Stack File (*.fibls)";

	public const string s = "LayerStack File (*.fitls)";

	public const string t = "*.fibls";

	public const string u = "*.fitls";

	public const string v = "Encrypted Substrate Stack File (*.fibss)";

	public const string w = "Substrate Stack File (*.fitss)";

	public const string x = "*.fibss";

	public const string y = "*.fitss";

	public const string z = "LayerStack |*.fibls;*.fitls;*.fibss;*.fitss";

	public const string aa = "LayerStack |*.fibbl;*.fibtl;*.fibbs;*.fibts";

	public static string[] ab = new string[2] { "*.fibls", "*.fitls" };

	public static string[] ac = new string[2] { "*.fibss", "*.fitss" };

	public const string ad = "T7XxeC6nlV0QUvBflF73Sh6m5KTapH8j";

	public const string ae = "EbV8n5b16PE4c04b";

	private bool af;

	private Collection<gc> ag;

	private bool ah;

	private const int ai = 1;

	public gd()
	{
		ag = new Collection<gc>();
	}

	[SpecialName]
	public bool k()
	{
		return af;
	}

	[SpecialName]
	public Collection<gc> l()
	{
		return ag;
	}

	[SpecialName]
	public bool m()
	{
		return ah;
	}

	public static bool l(string A_0)
	{
		return A_0.StartsWith("Stack: ");
	}

	[SpecialName]
	public static string i()
	{
		return i3.m() + "\\LayerStacks\\";
	}

	[SpecialName]
	public string n()
	{
		return Path.GetFileNameWithoutExtension(c);
	}

	private void l(string A_0, bool A_1)
	{
		e = Guid.NewGuid();
		a = DateTime.Now;
		b = A_0;
		af = false;
		ah = A_1;
		c = string.Empty;
		l().Clear();
		d = false;
		if (A_1)
		{
			c = "Default Substrate Layer Stack.fitss";
		}
		else
		{
			c = "Default Layer Stack.fitls";
		}
	}

	public void m(string A_0)
	{
		BinaryWriter binaryWriter = new BinaryWriter(File.Open(A_0, FileMode.Create));
		try
		{
			string extension = Path.GetExtension(A_0);
			af = string.Compare(extension, ".fibls", ignoreCase: true) == 0 || string.Compare(extension, ".fibss", ignoreCase: true) == 0;
			ah = string.Compare(extension, ".fibss", ignoreCase: true) == 0 || string.Compare(extension, ".fitss", ignoreCase: true) == 0;
			c = Path.GetFileName(A_0);
			i(binaryWriter);
		}
		finally
		{
			binaryWriter.Close();
		}
	}

	public void i(BinaryWriter A_0)
	{
		A_0.Write(b3.a(e));
		A_0.Write(1);
		A_0.Write(1);
		A_0.Write(a.ToOADate());
		A_0.Write(af);
		A_0.Write(ah);
		A_0.Write(c);
		A_0.Write(l().Count);
		if (b == null)
		{
			b = string.Empty;
		}
		if (af)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			ICryptoTransform a_ = rijndaelManaged.CreateEncryptor(Encoding.ASCII.GetBytes("T7XxeC6nlV0QUvBflF73Sh6m5KTapH8j"), Encoding.ASCII.GetBytes("EbV8n5b16PE4c04b"));
			dz.a(A_0, a_, b);
			foreach (gc item in l())
			{
				item.af(A_0, a_);
			}
			rijndaelManaged.Clear();
		}
		else
		{
			A_0.Write(b);
			foreach (gc item2 in l())
			{
				item2.af(A_0);
			}
		}
		d = true;
	}

	public void n(string A_0)
	{
		BinaryReader binaryReader = null;
		string extension = Path.GetExtension(A_0);
		try
		{
			binaryReader = ((!Path.IsPathRooted(A_0)) ? new BinaryReader(File.Open(i() + A_0, FileMode.Open, FileAccess.Read)) : new BinaryReader(File.Open(A_0, FileMode.Open, FileAccess.Read)));
			bool a_ = string.Compare(extension, ".fibls", ignoreCase: true) == 0 || string.Compare(extension, ".fibss", ignoreCase: true) == 0;
			i(binaryReader, A_1: true, a_);
		}
		finally
		{
			binaryReader?.Close();
		}
		c = Path.GetFileName(A_0);
		ah = string.Compare(extension, ".fibss", ignoreCase: true) == 0 || string.Compare(extension, ".fitss", ignoreCase: true) == 0;
	}

	public void i(BinaryReader A_0)
	{
		i(A_0, A_1: false, A_2: false);
	}

	public void i(BinaryReader A_0, bool A_1, bool A_2)
	{
		e = new Guid(A_0.ReadString());
		A_0.ReadInt32();
		int num = A_0.ReadInt32();
		if (1 < num)
		{
			return;
		}
		a = DateTime.FromOADate(A_0.ReadDouble());
		af = A_0.ReadBoolean();
		if (A_1 && A_2 != af)
		{
			throw new av("LayerStack read failed - file corruption - mismatch between file extension & encrypted flag");
		}
		ah = A_0.ReadBoolean();
		c = A_0.ReadString();
		checked
		{
			int num2 = A_0.ReadInt32() - 1;
			l().Clear();
			if (af)
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				ICryptoTransform a_ = rijndaelManaged.CreateDecryptor(Encoding.ASCII.GetBytes("T7XxeC6nlV0QUvBflF73Sh6m5KTapH8j"), Encoding.ASCII.GetBytes("EbV8n5b16PE4c04b"));
				b = dz.e(A_0, a_);
				int num3 = num2;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					gc gc2 = new gc();
					gc2.af(A_0, a_);
					l().Add(gc2);
				}
				rijndaelManaged.Clear();
			}
			else
			{
				b = A_0.ReadString();
				int num5 = num2;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					gc gc3 = new gc();
					gc3.af(A_0);
					l().Add(gc3);
				}
			}
		}
	}

	internal void i(ref gd A_0)
	{
		if (A_0 == null)
		{
			A_0 = new gd();
		}
		gd gd2 = A_0;
		gd2.e = e;
		gd2.a = a;
		gd2.b = b;
		gd2.af = af;
		gd2.c = c;
		gd2.ah = ah;
		gd2.d = d;
		gd2.l().Clear();
		checked
		{
			int num = l().Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				gc A_1 = new gc();
				ag[num2].af(ref A_1);
				gd2.l().Add(A_1);
			}
			gd2 = null;
		}
	}

	public void i(gc A_0, int A_1)
	{
		l().Insert(A_1, A_0);
	}

	public void i(int A_0)
	{
		l().RemoveAt(A_0);
	}

	[SpecialName]
	public static bool k(gd A_0, gd A_1)
	{
		checked
		{
			switch (ix.a(A_0, A_1))
			{
			case ix.a.a:
				return false;
			case ix.a.b:
				return true;
			default:
			{
				gd gd2 = A_0;
				if (gd2.e != A_1.e)
				{
					return true;
				}
				if (DateTime.Compare(gd2.a, A_1.a) != 0)
				{
					return true;
				}
				if (Operators.CompareString(gd2.b, A_1.b, TextCompare: false) != 0)
				{
					return true;
				}
				if (gd2.k() != A_1.k())
				{
					return true;
				}
				if (string.Compare(gd2.c, A_1.c, ignoreCase: true) != 0)
				{
					return true;
				}
				if (gd2.m() != A_1.m())
				{
					return true;
				}
				if (gd2.l().Count != A_1.l().Count)
				{
					return true;
				}
				int num = gd2.l().Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (gc.ag(gd2.l()[num2], A_1.l()[num2]))
					{
						return true;
					}
				}
				gd2 = null;
				return false;
			}
			}
		}
	}

	[SpecialName]
	public static bool i(gd A_0, gd A_1)
	{
		return !k(A_0, A_1);
	}

	public static gd i(bool A_0, string A_1, hd A_2, eo A_3, eo.a A_4)
	{
		gd obj = new gd();
		obj.l(A_1, A_0);
		gc gc2 = new gc();
		gc gc3 = gc2;
		if (A_0)
		{
			gc3.af("Si");
		}
		else
		{
			gc3.af("SiO2");
		}
		gc3.af(A_0: false, A_1: true, 1.0);
		gc3.ak(95.0);
		gc3.al(10.0);
		gc3.am(10.0);
		string a_ = gc3.ag();
		string A_5 = null;
		string A_6 = null;
		string A_7 = null;
		bool A_8 = false;
		int a_2 = jb.a(a_, A_2, A_3, A_4, ref A_5, ref A_6, ref A_7, ref A_8);
		gc3.ag(A_2.j(a_2, A_3, A_4));
		gc3 = null;
		obj.l().Add(gc2);
		return obj;
	}

	public static bool k(string A_0)
	{
		string text = A_0.ToLower();
		switch (text)
		{
		default:
			return Operators.CompareString(text, ".fibts", TextCompare: false) == 0;
		case ".fibbl":
		case ".fibbs":
		case ".fibtl":
			return true;
		}
	}

	public static bool i(string A_0)
	{
		string text = A_0.ToLower();
		switch (text)
		{
		default:
			return Operators.CompareString(text, ".fitss", TextCompare: false) == 0;
		case ".fibls":
		case ".fibss":
		case ".fitls":
			return true;
		}
	}

	public static Guid i(string A_0, bool A_1, ref bool A_2)
	{
		string text = k(A_0, A_1);
		if (text == null)
		{
			A_2 = false;
			return default(Guid);
		}
		A_2 = true;
		BinaryReader binaryReader = new BinaryReader(File.Open(text, FileMode.Open));
		Guid result;
		try
		{
			result = new Guid(binaryReader.ReadString());
		}
		finally
		{
			binaryReader.Close();
		}
		return result;
	}

	public static string k(string A_0, bool A_1)
	{
		if (A_1)
		{
			string text = i() + A_0 + ".fibss";
			if (File.Exists(text))
			{
				return text;
			}
			text = i() + A_0 + ".fitss";
			if (File.Exists(text))
			{
				return text;
			}
		}
		else
		{
			string text = i() + A_0 + ".fibls";
			if (File.Exists(text))
			{
				return text;
			}
			text = i() + A_0 + ".fitls";
			if (File.Exists(text))
			{
				return text;
			}
		}
		return null;
	}

	public static bool i(string A_0, bool A_1)
	{
		if (A_1)
		{
			if (File.Exists(i() + A_0 + ".fibss"))
			{
				return true;
			}
			if (File.Exists(i() + A_0 + ".fitss"))
			{
				return true;
			}
		}
		else
		{
			if (File.Exists(i() + A_0 + ".fibls"))
			{
				return true;
			}
			if (File.Exists(i() + A_0 + ".fitls"))
			{
				return true;
			}
		}
		return false;
	}
}
