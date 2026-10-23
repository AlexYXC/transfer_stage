using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using FIUsbIntLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

internal class i7 : a1
{
	public new enum a
	{
		a,
		b,
		c,
		d
	}

	public new class b : a6
	{
		private new string a;

		private string b;

		[SpecialName]
		public void c(string A_0)
		{
			a = A_0;
		}

		[SpecialName]
		public void d(string A_0)
		{
			if (A_0 == null || A_0.Length != 40)
			{
				string A_1 = DateAndTime.Now.Subtract(new TimeSpan(10000000L)).ToString();
				b = hh.b(ref A_1);
			}
			else
			{
				b = A_0;
			}
		}

		public override double[] b4(double[] A_0)
		{
			if (A_0 == null)
			{
				return null;
			}
			string text = a;
			int upperBound = A_0.GetUpperBound(0);
			double num = double.MinValue;
			double num2 = double.MaxValue;
			checked
			{
				double[] array = new double[upperBound + 1];
				Random random = new Random(Convert.ToInt32(text.Substring(0, 5), 16));
				int num3 = 1;
				do
				{
					random = new Random(Convert.ToInt32(text.Substring(num3 * 5, 5), 16) + unchecked(random.Next() / 1000000));
					num3++;
				}
				while (num3 <= 7);
				int num4 = upperBound;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					if (num < A_0[num5])
					{
						num = A_0[num5];
					}
					if (num2 > A_0[num5])
					{
						num2 = A_0[num5];
					}
				}
				int num6 = (base.a = ((!(num - num2 < 10.0)) ? 5000 : 10));
				int num7 = unchecked(num6 / 2);
				int num8 = upperBound;
				for (int num9 = 0; num9 <= num8; num9++)
				{
					array[num9] = A_0[num9] + (double)num7 - (double)num6 * ((double)random.Next() / 2147483647.0);
				}
				return array;
			}
		}

		public override double[] b5(double[] A_0)
		{
			if (A_0 == null)
			{
				return null;
			}
			string text = b;
			int upperBound = A_0.GetUpperBound(0);
			int num = base.a;
			checked
			{
				double[] array = new double[upperBound + 1];
				Random random = new Random(Convert.ToInt32(text.Substring(0, 5), 16));
				int num2 = 1;
				do
				{
					random = new Random(Convert.ToInt32(text.Substring(num2 * 5, 5), 16) + unchecked(random.Next() / 1000000));
					num2++;
				}
				while (num2 <= 7);
				int num3 = unchecked(num / 2);
				int num4 = upperBound;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					array[num5] = A_0[num5] - ((double)num3 - (double)num * ((double)random.Next() / 2147483647.0));
				}
				return array;
			}
		}

		public bool c()
		{
			return Operators.CompareString(a, b, TextCompare: false) == 0;
		}
	}

	public new class c : a0
	{
		public FMLegacyAllSystemTypes f;

		public byte g;

		public bool h;

		public bool i;

		public bool j;

		public short k;

		public bool l;

		public bool m;

		public bool n;

		public bool o;

		public bool p;

		public bool q;

		public bool r;

		public bool s;

		public bool t;

		public bool u;

		public bool v;

		public bool w;

		public bool x;

		public bool y;

		public bool z;

		public c()
		{
			f = FMLegacyAllSystemTypes.kTypeF10;
		}

		public c(FMLegacyAllSystemTypes A_0, string A_1, ew.a A_2, bool A_3, bool A_4, bool A_5, bool A_6, bool A_7, bool A_8, short A_9, bool A_10, bool A_11, bool A_12, bool A_13, bool A_14, bool A_15, bool A_16, bool A_17, bool A_18, bool A_19, bool A_20, bool A_21)
		{
			f = A_0;
			b = A_1;
			ac();
			a = A_2;
			h = A_3;
			i = A_4;
			l = A_5;
			m = A_7;
			n = A_10;
			o = A_6;
			j = A_8;
			k = A_9;
			r = A_11;
			s = A_12;
			p = A_13;
			q = A_14;
			t = A_15;
			u = A_16;
			c = false;
			d = false;
			v = A_17;
			w = A_18;
			x = A_19;
			y = A_20;
			z = A_21;
		}

		private void ac()
		{
			g = 0;
			if (!b7().Contains("-"))
			{
				return;
			}
			switch (f)
			{
			case FMLegacyAllSystemTypes.kTypeF10:
				if (b.Substring(b7().IndexOf("-")).StartsWith("-ARc"))
				{
					g = 7;
					break;
				}
				switch (b.Substring(b7().IndexOf("-"), 3))
				{
				case "-AR":
					g = 1;
					break;
				case "-PA":
					g = 2;
					break;
				case "-VC":
					g = 3;
					break;
				case "-RT":
					g = 6;
					break;
				}
				break;
			case FMLegacyAllSystemTypes.kTypeF20:
			{
				string left = b.Substring(b7().IndexOf("-"), 3);
				if (Operators.CompareString(left, "-HC", TextCompare: false) == 0)
				{
					g = 1;
				}
				break;
			}
			}
		}

		public override a0 b6(bool A_0, string A_1)
		{
			return new c(f, b7() + A_1, a, h && !A_0, i && !A_0, l && !A_0, o && !A_0, m && !A_0, j && !A_0, k, n && !A_0, r && !A_0, s && !A_0, p && !A_0, q && !A_0, t, u, v && !A_0, w && !A_0, x && !A_0, y && !A_0, z && !A_0)
			{
				c = c,
				d = d
			};
		}

		[SpecialName]
		public int ad()
		{
			return (int)f;
		}

		[SpecialName]
		public override string b7()
		{
			return b;
		}

		[SpecialName]
		public override void b8(string A_0)
		{
			b = A_0;
			ac();
		}

		public static int ac(bool A_0)
		{
			checked
			{
				return -unchecked(0 - (A_0 ? 1 : 0));
			}
		}
	}

	private new class d
	{
		internal class a
		{
			public const int a = 128;

			public const int b = 128;

			public const int c = 128;

			public const int d = 256;

			public const int e = 128;

			public const int f = 256;

			public const int g = 8;

			public const int h = 32;

			public const int i = 111;

			public const int j = 0;
		}

		internal class b
		{
			public const int a = 1;

			public const int b = 6;

			public const int c = 9;

			public const int d = 15;

			public const int e = 23;

			public const int f = 24;

			public const int g = 28;
		}

		internal struct c
		{
			public IntPtr a;

			public int b;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string c;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 132)]
			public string d;

			public int e;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public byte[] f;

			public int g;

			public int h;

			public int i;

			public IntPtr j;

			public d k;

			public d l;

			public d m;

			public bool n;

			public d o;

			public d p;

			public int q;

			public int r;
		}

		internal struct d
		{
			public IntPtr a;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string b;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string c;

			public int d;
		}

		[DllImport("Iphlpapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetAdaptersInfo(byte[] A_0, ref int A_1);

		[DllImport("Kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "CopyMemory", SetLastError = true)]
		public static extern void a(ref c A_0, byte[] A_1, int A_2);

		[DllImport("Kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "CopyMemory", SetLastError = true)]
		public static extern void a(ref c A_0, IntPtr A_1, int A_2);
	}

	public enum e
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
		o,
		p,
		q,
		r,
		s,
		t,
		u,
		v,
		w,
		x,
		y,
		z,
		aa,
		ab,
		ac,
		ad,
		ae,
		af,
		ag,
		ah,
		ai,
		aj,
		ak,
		al,
		am,
		an,
		ao,
		ap,
		aq,
		ar,
		@as,
		at,
		au,
		av,
		aw,
		ax,
		ay,
		az,
		a0,
		a1,
		a2,
		a3,
		a4,
		a5,
		a6,
		a7,
		a8,
		a9,
		ba,
		bb,
		bc,
		bd,
		be,
		bf,
		bg,
		bh,
		bi,
		bj,
		bk,
		bl
	}

	public new const string a = "-AR";

	public new const string b = "-ARc";

	public new const string c = "-PA";

	public new const string d = "-VC";

	public const string e = "-HC";

	public new const string f = "-PV";

	public new const string g = "-RT";

	public const string h = "-RTA";

	public const string i = "e";

	public const int j = 3;

	public const string k = "9D8D5257448D417BB62132EF3AA33070";

	private new const string l = "S3";

	private new const string m = "F2";

	private const string n = "F3";

	private const string o = "F10";

	private const string p = "F20";

	private const string q = "F30";

	private const string r = "F20_F40";

	private const string s = "F40";

	private const string t = "F40-NSR";

	private const string u = "PARTS";

	private const string v = "F70";

	public static string[] w = new string[75]
	{
		"", "HiRes2DThicknessMapping", "HiRes1DLineScan", "CustomExport", "PorousSi", "FFT", "NKActive", "Internal", "AutoReference", "F40Optics",
		"AR (SpectrumAnalysis)", "DisableMeasThickness", "SASW", "Color", "Thickness", "TechSupport", "AutoUpdate", "Correlation", "EndUser", "EndUserVerified",
		"MaterialView", "PrecisionSimWithoutMeas", "PrecisionSimulation", "F40UVOptics", "MatFileDB", "SystemChannel", "LicenseConfig", "SpectrumFilesExtraFormats", "ForceChinese", "ForceJapanese",
		"ForceGerman", "ForceFrench", "ForceEnglish", "InternalFirmware", "F40IROptics", "MapReportUniformityRelativeToMaxMin", "MapRepeat", "NKCauchyOnly", "ForceEnableNonMicroscopeOptics", "VsTime",
		"VirtualInterface", "ProhibitNonCTMOptics", "ZStage", "BacksideRSubtraction", "CalcNFromExtrema", "CompositeRecipe", "MeasChannelsConfig", "DisableSpectrumAnalysis", "NoOptics", "XYStage",
		"DefinitelyHas2AxisBackplane", "ZStageUniversal", "Micropositioner", "CompositeRecipeEx", "NonMotorizedZStage", "NonMotorizedZStageUniversal", "PatternRec", "NotchFlatFind", "Permit200mmWaferAdapter", "ExternalFirmware",
		"MotorizedObjectiveTurret", "MotorizedTipTiltFocus", "LightTower", "CassetteBarcodeReader", "Prealigner", "AdditionalRecipes", "OptoValues", "InternalThickness", "DiagnosticsLightSource", "MotionInterlock",
		"PermitAutoWavelengthCalib", "UVSourceFirmware", "ReportGenerator", "CustomPrintedLogo", "UpdateSerialNumber"
	};

	public const string x = "SaSwSn";

	public const string y = "_off";

	public const int z = 11;

	private const string aa = "Enduser";

	private const int ab = 1;

	private const string ac = "6B9F9E07AC07D167DB5DA2261F2F3EF61BDE3361216ACDE49BBACFCE89D9CDDF32E63A63A9A3D9FE5BAFBBA6369AA04CC46C5D64BB3E3A8137E1AF247BD52C56";

	public const int ad = 40;

	public const string ae = "Version: ";

	public const int af = 9;

	public const int ag = 10;

	public const int ah = 11;

	public const int ai = 12;

	private const int aj = 7;

	public new static string c(FMLegacyAllSystemTypes A_0)
	{
		return A_0 switch
		{
			FMLegacyAllSystemTypes.kTypeS3 => "S3", 
			FMLegacyAllSystemTypes.kTypeF2 => "F2", 
			FMLegacyAllSystemTypes.kTypeF3 => "F3", 
			FMLegacyAllSystemTypes.kTypeF10 => "F10", 
			FMLegacyAllSystemTypes.kTypeF20 => "F20", 
			FMLegacyAllSystemTypes.kTypeF30 => "F30", 
			FMLegacyAllSystemTypes.kTypeF20_F40 => "F20_F40", 
			FMLegacyAllSystemTypes.kTypeF40 => "F40", 
			FMLegacyAllSystemTypes.kTypeF40NSR => "F40-NSR", 
			FMLegacyAllSystemTypes.kTypePARTS => "PARTS", 
			FMLegacyAllSystemTypes.kTypeF70 => "F70", 
			_ => throw new Exception("Unknown System Type"), 
		};
	}

	private static int e(int A_0)
	{
		return A_0 switch
		{
			1 => 1, 
			2 => 2, 
			3 => 2, 
			4 => 2, 
			5 => 2, 
			6 => 2, 
			7 => 2, 
			8 => 2, 
			9 => 2, 
			10 => 2, 
			11 => 2, 
			_ => throw new Exception("Incompatible file version"), 
		};
	}

	private new static int d(int A_0)
	{
		return A_0 switch
		{
			2 => 1, 
			3 => 2, 
			4 => 3, 
			5 => 4, 
			6 => 5, 
			7 => 6, 
			8 => 7, 
			9 => 8, 
			10 => 9, 
			11 => 10, 
			12 => 11, 
			13 => 12, 
			_ => -1, 
		};
	}

	public override int bf(string A_0)
	{
		string text = A_0.ToLower();
		int num = text.IndexOf("_");
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		int upperBound = w.GetUpperBound(0);
		for (int num2 = 1; num2 <= upperBound; num2 = checked(num2 + 1))
		{
			if (Operators.CompareString(text, w[num2].ToLower(), TextCompare: false) == 0)
			{
				return num2;
			}
		}
		throw new ax("Unknown license type");
	}

	public new static bool d(e A_0)
	{
		return A_0 switch
		{
			i7.e.l => true, 
			i7.e.p => true, 
			i7.e.ab => true, 
			i7.e.af => true, 
			i7.e.ae => true, 
			i7.e.ad => true, 
			i7.e.ac => true, 
			i7.e.g => true, 
			i7.e.aw => true, 
			_ => false, 
		};
	}

	public new static bool c(e A_0)
	{
		if (A_0 == i7.e.a6)
		{
			return false;
		}
		return true;
	}

	public override string bg(int A_0)
	{
		if (A_0 == 7 || A_0 == 19)
		{
			return a1.c();
		}
		return a1.d();
	}

	public static string h()
	{
		return i3.n() + "\\Licenses\\";
	}

	public static string g()
	{
		return i3.j() + "\\Licenses\\";
	}

	public static string f()
	{
		return "License File|*.fmlic";
	}

	public override bool bh(int A_0, bool A_1)
	{
		if (bu().Contains(A_0))
		{
			return true;
		}
		if (A_1 && A_0 == 66)
		{
			return true;
		}
		return false;
	}

	public override int bi(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return 4;
		}
		return 5;
	}

	public override bool bj(int A_0)
	{
		return A_0 >= 5;
	}

	public override bool bk(int A_0)
	{
		if (A_0 != 7)
		{
			return A_0 == 19;
		}
		return true;
	}

	public override bool bl(int A_0)
	{
		return A_0 == 74;
	}

	public override void bm(int A_0, string A_1, ref bool A_2)
	{
		A_2 = false;
		checked
		{
			if (bk(A_0))
			{
				if (string.IsNullOrEmpty(A_1))
				{
					Interaction.MsgBox("Please enter a user name", MsgBoxStyle.OkOnly, "Error - Missing User Name");
					return;
				}
				string[] array = A_1.Split('.');
				int num = array.Length - 1;
				if (A_0 == 7 && (num != 1 || string.IsNullOrEmpty(array[0]) || string.IsNullOrEmpty(array[1])))
				{
					Interaction.MsgBox("Please enter name formatted as First.Last", MsgBoxStyle.OkOnly, "Error - Incorrect Name Format");
					return;
				}
				if (A_0 == 19 && (num != 2 || string.IsNullOrEmpty(array[0]) || string.IsNullOrEmpty(array[1]) || string.IsNullOrEmpty(array[2])))
				{
					Interaction.MsgBox("Please enter name formatted as First.Last.Company", MsgBoxStyle.OkOnly, "Error - Incorrect Name Format");
					return;
				}
				int num2 = A_1.Length - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (Operators.CompareString(A_1.Substring(num3, 1), ".", TextCompare: false) != 0 && !char.IsLetterOrDigit(A_1, num3))
					{
						Interaction.MsgBox("Only alphanumeric characters and '.' are valid in User Name", MsgBoxStyle.OkOnly, "Error - Invalid Characters In Name");
						return;
					}
				}
			}
			A_2 = true;
		}
	}

	public override bool bn(int A_0)
	{
		if (A_0 != 7 && A_0 != 15 && A_0 != 19 && A_0 != 20 && A_0 != 24 && A_0 != 71)
		{
			return A_0 == 74;
		}
		return true;
	}

	public override bool bo(int A_0, string A_1)
	{
		if (A_0 == 44)
		{
			return Operators.CompareString(A_1, "Software Only", TextCompare: false) == 0;
		}
		return false;
	}

	public override bool bp(int A_0)
	{
		return A_0 == 16;
	}

	public override bool bq(int A_0)
	{
		return A_0 == 25;
	}

	public new static string c(string A_0, string A_1 = "")
	{
		string text = ((!string.IsNullOrEmpty(A_1)) ? (A_1 + "\\SystemInfo") : (i3.o() + "\\SystemInfo"));
		string text2 = ".txt";
		if (A_0 != null && A_0.Length > 0)
		{
			return text + "_" + A_0 + text2;
		}
		return text + text2;
	}

	public bool e(e A_0)
	{
		int A_1 = 0;
		string A_2 = null;
		string[] A_3 = null;
		return c(null, null, (int)A_0, A_3: false, ref A_1, ref A_2, ref A_3);
	}

	public new bool c(e A_0, bool A_1)
	{
		int A_2 = 0;
		string A_3 = null;
		string[] A_4 = null;
		return c(null, null, (int)A_0, A_1, ref A_2, ref A_3, ref A_4);
	}

	public new bool c(string A_0, string A_1, e A_2)
	{
		int A_3 = 0;
		string A_4 = null;
		string[] A_5 = null;
		return c(A_0, A_1, A_2, ref A_3, ref A_4, ref A_5);
	}

	public new bool c(string A_0, string A_1, e A_2, ref string A_3)
	{
		int A_4 = 0;
		string[] A_5 = null;
		return c(A_0, A_1, A_2, ref A_4, ref A_3, ref A_5);
	}

	public new bool c(string A_0, string A_1, e A_2, ref int A_3)
	{
		string A_4 = null;
		string[] A_5 = null;
		return c(A_0, A_1, A_2, ref A_3, ref A_4, ref A_5);
	}

	public new bool c(string A_0, e A_1, ref string A_2, ref string[] A_3)
	{
		int A_4 = 0;
		return c(A_0, "SaSwSn", A_1, ref A_4, ref A_2, ref A_3);
	}

	public new bool c(string A_0, e A_1, ref string[] A_2)
	{
		int A_3 = 0;
		string A_4 = null;
		return c(A_0, "SaSwSn", A_1, ref A_3, ref A_4, ref A_2);
	}

	public new bool c(string A_0, string A_1, e A_2, ref int A_3, ref string A_4, ref string[] A_5)
	{
		return c(A_0, A_1, (int)A_2, A_3: false, ref A_3, ref A_4, ref A_5);
	}

	public new static bool c(string A_0, string[] A_1, e A_2)
	{
		if (A_1 == null)
		{
			return false;
		}
		foreach (string a_ in A_1)
		{
			if (!c(A_2, A_0, a_))
			{
				return false;
			}
		}
		return true;
	}

	public new bool c(string A_0, ref string[] A_1)
	{
		StreamReader streamReader = null;
		string text = br(12);
		List<string> list = new List<string>();
		string text2 = bg(12);
		bool result = false;
		A_1 = null;
		if (!Directory.Exists(text2))
		{
			return false;
		}
		ReadOnlyCollection<string> files = global::c.e().FileSystem.GetFiles(text2, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, text + b1(), text + "_?" + b1());
		if (files.Count == 0)
		{
			return false;
		}
		checked
		{
			int num = files.Count - 1;
			list = new List<string>();
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				string path = files[num3];
				try
				{
					streamReader = new StreamReader(path);
					if ((int)Math.Round(Conversion.Val(streamReader.ReadLine())) > d(11))
					{
						return false;
					}
					string text3 = streamReader.ReadLine();
					if (c(i7.e.l, A_0, text3))
					{
						result = true;
						list.Add(text3);
					}
				}
				finally
				{
					if (streamReader != null)
					{
						streamReader.Close();
						streamReader = null;
					}
				}
			}
			A_1 = list.ToArray();
			return result;
		}
	}

	public new static bool c(e A_0, string A_1, string A_2)
	{
		int num = (int)A_0;
		string A_3 = A_1 + num.ToString(CultureInfo.InvariantCulture);
		string left = hh.b(ref A_3);
		if (string.IsNullOrEmpty(A_2) || A_2.Length < 40)
		{
			return false;
		}
		return Operators.CompareString(left, A_2.Substring(0, 40), TextCompare: false) == 0;
	}

	public Collection<c> i()
	{
		StreamReader streamReader = null;
		Collection<c> collection = new Collection<c>();
		string text = bg(12) + br(12) + b1();
		if (!global::c.e().FileSystem.FileExists(text))
		{
			collection.Add(new c());
			return collection;
		}
		checked
		{
			try
			{
				streamReader = new StreamReader(text);
				int num = (int)Math.Round(Conversion.Val(streamReader.ReadLine()));
				if (num > d(11))
				{
					collection.Add(new c());
					return collection;
				}
				string A_ = streamReader.ReadLine().Substring(40);
				string right = streamReader.ReadLine();
				int num2 = Conversions.ToInteger(streamReader.ReadLine());
				for (int num3 = 1; num3 <= num2; num3++)
				{
					c c10 = new c();
					c c11 = c10;
					string text2 = streamReader.ReadLine();
					A_ += text2;
					unchecked
					{
						c11.f = (FMLegacyAllSystemTypes)checked((int)Math.Round(Conversion.Val(text2)));
						text2 = streamReader.ReadLine();
						A_ = text2 + A_;
						c11.a = (ew.a)checked((byte)Math.Round(Conversion.Val(text2)));
						text2 = streamReader.ReadLine();
						A_ += text2;
						c11.h = Conversion.Val(text2) != 0.0;
						text2 = streamReader.ReadLine();
						A_ = text2 + A_;
						c11.i = Conversion.Val(text2) != 0.0;
						text2 = streamReader.ReadLine();
						A_ += text2;
						c11.l = Conversion.Val(text2) != 0.0;
						text2 = streamReader.ReadLine();
						A_ = text2 + A_;
						c11.m = Conversion.Val(text2) != 0.0;
						text2 = streamReader.ReadLine();
						A_ += text2;
						c11.o = Conversion.Val(text2) != 0.0;
						text2 = streamReader.ReadLine();
						A_ = text2 + A_;
						c11.b8(text2);
						text2 = streamReader.ReadLine();
						A_ += text2;
						c11.j = Conversion.Val(text2) != 0.0;
						text2 = streamReader.ReadLine();
						A_ = text2 + A_;
					}
					c11.k = (short)Math.Round(Conversion.Val(text2));
					text2 = streamReader.ReadLine();
					A_ += text2;
					c11.c = Conversion.Val(text2) != 0.0;
					text2 = streamReader.ReadLine();
					A_ = text2 + A_;
					c11.d = Conversion.Val(text2) != 0.0;
					c11.h = j();
					if (num >= 3)
					{
						text2 = streamReader.ReadLine();
						A_ += text2;
						c11.n = Conversion.Val(text2) != 0.0;
						text2 = streamReader.ReadLine();
						A_ = text2 + A_;
						c11.r = Conversion.Val(text2) != 0.0;
						text2 = streamReader.ReadLine();
						A_ += text2;
						c11.s = Conversion.Val(text2) != 0.0;
					}
					if (num >= 4)
					{
						text2 = streamReader.ReadLine();
						A_ = text2 + A_;
						c11.p = Conversion.Val(text2) != 0.0;
						text2 = streamReader.ReadLine();
						A_ += text2;
						c11.q = Conversion.Val(text2) != 0.0;
					}
					if (num >= 5)
					{
						text2 = streamReader.ReadLine();
						A_ = text2 + A_;
						c11.t = Conversion.Val(text2) != 0.0;
						text2 = streamReader.ReadLine();
						A_ += text2;
						c11.u = Conversion.Val(text2) != 0.0;
					}
					if (num >= 6)
					{
						text2 = streamReader.ReadLine();
						A_ = text2 + A_;
						c11.v = Conversion.Val(text2) != 0.0;
					}
					if (num >= 7)
					{
						text2 = streamReader.ReadLine();
						A_ = text2 + A_;
						c11.w = Conversion.Val(text2) != 0.0;
					}
					if (num >= 8)
					{
						text2 = streamReader.ReadLine();
						A_ = text2 + A_;
						c11.x = Conversion.Val(text2) != 0.0;
					}
					if (num >= 9)
					{
						text2 = streamReader.ReadLine();
						A_ = text2 + A_;
						c11.y = Conversion.Val(text2) != 0.0;
					}
					if (num >= 10)
					{
						text2 = streamReader.ReadLine();
						A_ += text2;
						c11.z = Conversion.Val(text2) != 0.0;
					}
					c11 = null;
					collection.Add(c10);
				}
				if (Operators.CompareString(hh.b(ref A_), right, TextCompare: false) == 0)
				{
					return collection;
				}
				collection.Clear();
				collection.Add(new c());
				return collection;
			}
			finally
			{
				streamReader?.Close();
			}
		}
	}

	public override string br(int A_0)
	{
		return w[A_0];
	}

	public override List<int> bs()
	{
		return new List<int> { 7, 15, 16, 19, 20, 24, 44, 71 };
	}

	public override List<int> bt()
	{
		return new List<int>
		{
			5, 14, 6, 37, 11, 10, 13, 39, 40, 9,
			34, 23, 1, 2, 3, 8, 25, 22, 21, 42,
			44, 46, 50, 53, 54, 56, 57, 59, 62, 63,
			66, 56, 69, 70, 74
		};
	}

	public override List<int> bu()
	{
		return new List<int>
		{
			17, 26, 27, 33, 20, 28, 32, 30, 29, 35,
			38, 36, 41, 43, 47, 67, 51, 55, 60, 61,
			49, 52, 65, 68, 72, 73
		};
	}

	public override string bv()
	{
		return "SaSwSn";
	}

	public override List<int> bw(int A_0)
	{
		List<int> list = new List<int>();
		switch ((e)A_0)
		{
		case i7.e.p:
			list.Add(1);
			list.Add(2);
			list.Add(3);
			break;
		case i7.e.y:
		{
			int num = 1;
			do
			{
				list.Add(num);
				num = checked(num + 1);
			}
			while (num <= 7);
			break;
		}
		}
		return list;
	}

	public override List<string> bx(int A_0)
	{
		List<string> list = new List<string>();
		switch ((e)A_0)
		{
		case i7.e.p:
			list.Add("Alpha");
			list.Add("Beta");
			list.Add("Release");
			break;
		case i7.e.y:
		{
			int num = 1;
			do
			{
				list.Add(num.ToString());
				num = checked(num + 1);
			}
			while (num <= 7);
			break;
		}
		}
		return list;
	}

	public override string by(int A_0)
	{
		return (e)A_0 switch
		{
			i7.e.p => "Auto Update Level:", 
			i7.e.y => "Channel #:", 
			_ => throw new ApplicationException("Unknown license type for purposes of determining level label"), 
		};
	}

	public override string bz(int A_0)
	{
		return (e)A_0 switch
		{
			i7.e.g => "User Name:", 
			i7.e.y => "Sys. Name:", 
			i7.e.bl => "New Serial Number:", 
			_ => throw new ApplicationException("Unknown license type for purposes of determining string label"), 
		};
	}

	public override string b0(int A_0)
	{
		return (e)A_0 switch
		{
			i7.e.g => "(First.Last)", 
			i7.e.s => "(First.Last.Company)", 
			i7.e.y => "(Example: F37)", 
			i7.e.bl => "(Example: 18M027)", 
			_ => throw new ApplicationException("Unknown license type for purposes of determining name format"), 
		};
	}

	public override string b1()
	{
		return ".fmlic";
	}

	public override void b2(int A_0, string A_1, string A_2, ref string A_3, ref string A_4)
	{
		if (A_0 == 59 || A_0 == 74)
		{
			A_3 = "9D8D5257448D417BB62132EF3AA33070";
			A_4 = i3.g(A_1);
		}
		else
		{
			A_3 = A_2;
			A_4 = A_2;
		}
	}

	public override void b3(ref string A_0, int A_1, string A_2, string A_3, string A_4, ref bool A_5, ref string A_6)
	{
		if (A_1 == 59 || A_1 == 74)
		{
			A_0 = A_0 + "_" + i3.g(A_2);
			A_6 = "9D8D5257448D417BB62132EF3AA33070";
			return;
		}
		if (A_1 != 7 && A_1 != 15 && A_1 != 16 && A_1 != 18 && A_1 != 19 && A_1 != 20 && A_1 != 24 && A_1 != 71 && (A_1 != 44 || Operators.CompareString(A_4, "Software Only", TextCompare: false) != 0))
		{
			A_0 = A_0 + "_" + A_3;
		}
		else
		{
			A_5 = true;
		}
		A_6 = A_3;
	}

	public new void c(string A_0, ref bool A_1, ref e A_2, ref string A_3)
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(A_0);
		A_3 = null;
		A_1 = false;
		foreach (object value in Enum.GetValues(typeof(e)))
		{
			e e10 = (e)Conversions.ToInteger(value);
			if (!A_0.StartsWith(w[(int)e10]))
			{
				continue;
			}
			int length = w[(int)e10].Length;
			A_2 = e10;
			checked
			{
				if (fileNameWithoutExtension.Length > length && Operators.CompareString(Conversions.ToString(fileNameWithoutExtension[length]), "_", TextCompare: false) == 0 && fileNameWithoutExtension.Length - length == 33)
				{
					A_3 = fileNameWithoutExtension.Substring(length + 1);
				}
				if (Operators.CompareString(A_3, null, TextCompare: false) == 0 && string.Compare(Path.GetFileNameWithoutExtension(A_0), br(unchecked((int)e10)), ignoreCase: true) != 0)
				{
					if (fileNameWithoutExtension.Length > length + 1 && Operators.CompareString(Conversions.ToString(fileNameWithoutExtension[length]), "_", TextCompare: false) == 0)
					{
						string text = Conversions.ToString(fileNameWithoutExtension[length + 1]);
						int result = 0;
						if (int.TryParse(text, out result))
						{
							A_1 = true;
							break;
						}
					}
					A_1 = false;
				}
				else
				{
					A_1 = true;
				}
				break;
			}
		}
	}

	public new void c(string A_0, string A_1, string A_2, ref bool A_3, ref string A_4, ref string[] A_5, ref string[] A_6, ref bool A_7, ref bool A_8)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Title = A_0;
		openFileDialog.InitialDirectory = A_1;
		openFileDialog.Filter = A_2;
		openFileDialog.Multiselect = true;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			A_3 = false;
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			string[] fileNames = openFileDialog.FileNames;
			bool A_9 = default(bool);
			foreach (string text in fileNames)
			{
				A_4 = Path.GetDirectoryName(text);
				c(text, ref A_9, ref A_7, ref A_8);
				if (A_9)
				{
					list.Add(Path.GetFileNameWithoutExtension(text));
				}
				else
				{
					list2.Add(Path.GetFileNameWithoutExtension(text));
				}
			}
			A_5 = list.ToArray();
			A_6 = list2.ToArray();
		}
		else
		{
			A_5 = new string[0];
			A_3 = true;
		}
		openFileDialog = null;
	}

	public new void c(string A_0, ref bool A_1, ref bool A_2, ref bool A_3)
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(A_0);
		string text = base.c(fileNameWithoutExtension);
		string text2 = fileNameWithoutExtension + b1();
		string file = text + text2;
		string text3 = File.ReadAllText(A_0).Replace("\r\n", "\n");
		string text4 = text3.Replace("\n", "\r\n");
		int num = 10;
		int num2 = 0;
		string text5;
		string text6;
		bool flag2 = default(bool);
		bool flag3;
		bool flag4 = default(bool);
		bool flag5;
		do
		{
			text5 = ((num2 != 0) ? (fileNameWithoutExtension + "_" + num2 + b1()) : (fileNameWithoutExtension + b1()));
			text6 = text + text5;
			bool flag = File.Exists(text6);
			if (num2 == 0)
			{
				flag2 = flag;
			}
			if (flag)
			{
				string left = File.ReadAllText(text6);
				flag3 = Operators.CompareString(left, text4, TextCompare: false) != 0;
				flag4 = Operators.CompareString(left, text3, TextCompare: false) == 0;
			}
			else
			{
				flag3 = true;
			}
			flag5 = flag && flag3 && !flag4;
			if (flag5)
			{
				num2 = checked(num2 + 1);
				if (num2 == num)
				{
					throw new Exception("Attempt to import license '" + fileNameWithoutExtension + "' failed because " + num + " already exist.");
				}
			}
		}
		while (flag5);
		if (flag3)
		{
			if (flag4)
			{
				global::c.e().FileSystem.DeleteFile(text6);
			}
			if (flag2 && !flag4)
			{
				global::c.e().FileSystem.RenameFile(file, text5);
			}
			i3.c(A_0, base.c(Path.GetFileNameWithoutExtension(A_0)), text4);
			A_1 = false;
		}
		else if (num2 > 0)
		{
			string text7 = text5 + "~";
			global::c.e().FileSystem.RenameFile(file, text7);
			global::c.e().FileSystem.RenameFile(text + text5, text2);
			global::c.e().FileSystem.RenameFile(text + text7, text5);
			A_1 = false;
		}
		else
		{
			A_1 = true;
		}
		if (!A_1)
		{
			e a_ = (e)bf(Path.GetFileNameWithoutExtension(A_0));
			if (d(a_))
			{
				A_2 = true;
				A_3 = false;
			}
			else if (!A_2)
			{
				A_3 = A_3 || c(a_);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public new static void c(string A_0, ref bool A_1, ref string A_2, ref string A_3, ref string A_4, ref string A_5, ref string A_6, ref int A_7, ref string A_8, ref int A_9, ref bool A_10)
	{
		int num = Microsoft.VisualBasic.FileSystem.FreeFile();
		string Value = "";
		string Value2 = "";
		try
		{
			A_1 = false;
			A_2 = Path.GetDirectoryName(A_0);
			Microsoft.VisualBasic.FileSystem.FileOpen(num, A_0, OpenMode.Input);
			Microsoft.VisualBasic.FileSystem.Input(num, ref Value);
			int num2 = default(int);
			if (Operators.CompareString(Value, "Version: ", TextCompare: false) == 0)
			{
				Microsoft.VisualBasic.FileSystem.Input(num, ref Value2);
				num2 = int.Parse(Value2);
				Microsoft.VisualBasic.FileSystem.Input(num, ref Value);
				Microsoft.VisualBasic.FileSystem.Input(num, ref Value2);
				if (int.Parse(Value2) > 11)
				{
					Interaction.MsgBox("Unknown SystemInfo file format - Aborting.");
					return;
				}
				Microsoft.VisualBasic.FileSystem.Input(num, ref Value);
				Microsoft.VisualBasic.FileSystem.Input(num, ref Value);
				Microsoft.VisualBasic.FileSystem.Input(num, ref A_5);
			}
			Microsoft.VisualBasic.FileSystem.Input(num, ref Value);
			Microsoft.VisualBasic.FileSystem.Input(num, ref Value2);
			Microsoft.VisualBasic.FileSystem.Input(num, ref Value);
			Microsoft.VisualBasic.FileSystem.Input(num, ref A_3);
			Microsoft.VisualBasic.FileSystem.Input(num, ref Value);
			Microsoft.VisualBasic.FileSystem.Input(num, ref A_4);
			Microsoft.VisualBasic.FileSystem.Input(num, ref Value);
			Microsoft.VisualBasic.FileSystem.Input(num, ref A_8);
			A_7 = Conversions.ToInteger(A_8.Substring(0, 1));
			Microsoft.VisualBasic.FileSystem.Input(num, ref Value);
			A_10 = Value.StartsWith("FilmProfAnalyze");
			Microsoft.VisualBasic.FileSystem.Input(num, ref Value2);
			Microsoft.VisualBasic.FileSystem.Input(num, ref Value);
			Microsoft.VisualBasic.FileSystem.Input(num, ref Value2);
			if (!A_10)
			{
				Microsoft.VisualBasic.FileSystem.Input(num, ref Value);
				Microsoft.VisualBasic.FileSystem.Input(num, ref Value2);
			}
			Microsoft.VisualBasic.FileSystem.Input(num, ref Value);
			Microsoft.VisualBasic.FileSystem.Input(num, ref A_6);
			if (num2 >= 3)
			{
				Microsoft.VisualBasic.FileSystem.Input(num, ref Value);
				Microsoft.VisualBasic.FileSystem.Input(num, ref Value2);
				A_9 = int.Parse(Value2);
			}
			else
			{
				A_9 = d(2);
			}
		}
		finally
		{
			Microsoft.VisualBasic.FileSystem.FileClose(num);
		}
		A_1 = true;
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private new static void c(string A_0, string A_1, string A_2, string A_3, string A_4, string A_5, string A_6, string A_7, string A_8, string A_9)
	{
		int num = Microsoft.VisualBasic.FileSystem.FreeFile();
		Microsoft.VisualBasic.FileSystem.FileOpen(num, A_0, OpenMode.Output);
		try
		{
			Microsoft.VisualBasic.FileSystem.WriteLine(num, "Version: ", 11);
			Microsoft.VisualBasic.FileSystem.WriteLine(num, "Compatible version: ", e(11));
			Microsoft.VisualBasic.FileSystem.WriteLine(num, "System Information File");
			Microsoft.VisualBasic.FileSystem.WriteLine(num, "Site code: ", A_2);
			Microsoft.VisualBasic.FileSystem.WriteLine(num, "Last Run Date: ", A_1);
			Microsoft.VisualBasic.FileSystem.WriteLine(num, "System GUID: ", A_3);
			Microsoft.VisualBasic.FileSystem.WriteLine(num, "System Serial Number: ", A_4);
			Microsoft.VisualBasic.FileSystem.WriteLine(num, "Program File Version: ", A_5);
			Microsoft.VisualBasic.FileSystem.WriteLine(num, "FMImage File Version: ", A_6);
			Microsoft.VisualBasic.FileSystem.WriteLine(num, "FMSolve File Version: ", A_7);
			Microsoft.VisualBasic.FileSystem.WriteLine(num, "FMUSBInt File Version: ", A_8);
			Microsoft.VisualBasic.FileSystem.WriteLine(num, "System ID: ", c());
			Microsoft.VisualBasic.FileSystem.WriteLine(num, "SASWLicenseFileVer: ", d(11));
		}
		finally
		{
			Microsoft.VisualBasic.FileSystem.FileClose(num);
		}
	}

	public new static void c(int A_0, int A_1, int A_2, int A_3, string A_4, Collection<string> A_5, Collection<string> A_6, string A_7, string A_8 = "")
	{
		string a_ = DateTime.Now.ToString("G", CultureInfo.InvariantCulture);
		Version version = global::c.d().Info.Version;
		string a_2 = version.Major + "." + version.Minor + "." + version.Build + "." + version.Revision;
		version = null;
		short A_9 = default(short);
		short A_10 = default(short);
		short A_11 = default(short);
		short A_12 = default(short);
		global::b1.FIImageVer(ref A_9, ref A_10, ref A_11, ref A_12);
		string a_3 = Conversions.ToString((int)A_9) + "." + Conversions.ToString((int)A_10) + "." + Conversions.ToString((int)A_11) + "." + Conversions.ToString((int)A_12);
		string a_4 = Conversions.ToString(A_0) + "." + Conversions.ToString(A_1) + "." + Conversions.ToString(A_2) + "." + Conversions.ToString(A_3);
		short num = (short)((A_5 == null) ? (-1) : checked((short)unchecked(checked((short)A_5.Count) - 1)));
		string a_5 = c();
		if (num >= 0)
		{
			Collection<string> collection = new Collection<string>();
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3 = checked(num3 + 1))
			{
				string text = A_5[num3];
				if (!collection.Contains(text))
				{
					collection.Add(text);
					string a_6 = ((!string.IsNullOrEmpty(A_8)) ? c(text, A_8) : c(text));
					c(a_6, a_, A_7, text, A_6[num3], a_2, a_3, A_4, a_4, a_5);
				}
			}
		}
		else
		{
			c(c(null, ""), a_, A_7, "No USB Systems", "Software Only", a_2, a_3, A_4, a_4, a_5);
		}
	}

	public static string e()
	{
		string text = c(null, "");
		string text2 = null;
		checked
		{
			if (global::c.e().FileSystem.FileExists(text))
			{
				try
				{
					StreamReader streamReader = null;
					try
					{
						streamReader = new StreamReader(text);
						if (streamReader.ReadLine().ToLowerInvariant().Contains("version"))
						{
							string text3 = streamReader.ReadLine();
							if ((int)Math.Round(Conversion.Val(text3.Substring(text3.IndexOf(",") + 1))) <= 11)
							{
								streamReader.ReadLine();
								string text4 = streamReader.ReadLine();
								text2 = text4.Substring(text4.IndexOf(",") + 2);
								text2 = text2.Substring(0, text2.Length - 1);
							}
						}
					}
					finally
					{
						streamReader?.Close();
					}
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex3 = ex2;
					text2 = null;
					ProjectData.ClearProjectError();
				}
			}
			if (string.IsNullOrEmpty(text2))
			{
				return string.Join(string.Empty, Guid.NewGuid().ToString().Split('-')).ToUpper();
			}
			return text2;
		}
	}

	public new void c(ref string A_0, ref string A_1, ref string A_2, ref string A_3)
	{
		string text = bg(18) + "Enduser" + b1();
		A_0 = "";
		A_1 = "";
		A_2 = "";
		A_3 = "";
		if (!global::c.e().FileSystem.FileExists(text))
		{
			return;
		}
		StreamReader streamReader = null;
		try
		{
			HMACSHA1 hMACSHA = new HMACSHA1();
			hMACSHA.Key = ei.a("6B9F9E07AC07D167DB5DA2261F2F3EF61BDE3361216ACDE49BBACFCE89D9CDDF32E63A63A9A3D9FE5BAFBBA6369AA04CC46C5D64BB3E3A8137E1AF247BD52C56");
			streamReader = new StreamReader(text, Encoding.UTF8);
			int.Parse(streamReader.ReadLine());
			if (int.Parse(streamReader.ReadLine()) <= 1)
			{
				string text2 = streamReader.ReadLine();
				string text3 = streamReader.ReadLine();
				string text4 = streamReader.ReadLine();
				string text5 = streamReader.ReadLine();
				string left = streamReader.ReadLine();
				string right = Convert.ToBase64String(hMACSHA.ComputeHash(Encoding.Unicode.GetBytes(text2 + text3 + text4 + text5)));
				if (Operators.CompareString(left, right, TextCompare: false) == 0)
				{
					A_0 = text2;
					A_1 = text3;
					A_2 = text4;
					A_3 = text5;
				}
			}
		}
		finally
		{
			streamReader?.Close();
		}
	}

	public new void c(string A_0, string A_1, string A_2, string A_3)
	{
		string path = bg(18) + "Enduser" + b1();
		StreamWriter streamWriter = null;
		try
		{
			HMACSHA1 hMACSHA = new HMACSHA1();
			if (!Directory.Exists(bg(18)))
			{
				Microsoft.VisualBasic.FileSystem.MkDir(bg(18));
			}
			hMACSHA.Key = ei.a("6B9F9E07AC07D167DB5DA2261F2F3EF61BDE3361216ACDE49BBACFCE89D9CDDF32E63A63A9A3D9FE5BAFBBA6369AA04CC46C5D64BB3E3A8137E1AF247BD52C56");
			streamWriter = new StreamWriter(path, append: false, Encoding.UTF8);
			streamWriter.WriteLine(1);
			streamWriter.WriteLine(1);
			streamWriter.WriteLine(A_0);
			streamWriter.WriteLine(A_1);
			streamWriter.WriteLine(A_2);
			streamWriter.WriteLine(A_3);
			string value = Convert.ToBase64String(hMACSHA.ComputeHash(Encoding.Unicode.GetBytes(A_0 + A_1 + A_2 + A_3)));
			streamWriter.WriteLine(value);
		}
		finally
		{
			streamWriter?.Close();
		}
	}

	public new static string[] d()
	{
		List<string> list = new List<string>();
		string[] result;
		try
		{
			string text = "t";
			text = "p" + text;
			text += "e";
			text = "a" + text;
			text += "r";
			text = "d" + text;
			text += "C";
			text = "A" + text;
			text += "o";
			text = "k" + text;
			text += "n";
			text = "r" + text;
			text += "f";
			text = "o" + text;
			text += "i";
			text = "w" + text;
			text += "g";
			text = "t" + text;
			text += "u";
			text = "e" + text;
			text += "r";
			text = "N" + text;
			text += "a";
			text = "_" + text;
			text += "t";
			text = "2" + text;
			text += "i";
			text = "3" + text;
			text += "o";
			text = "n" + text;
			text += "n";
			text = "i" + text;
			text = "W" + text;
			text = "SELECT * FROM " + text + " WHERE ";
			text += "M";
			text += "A";
			text += "C";
			text += "A";
			text += "d";
			text += "d";
			text += "ress > 0";
			string text2 = "d";
			text2 = "d" + text2;
			text2 += "r";
			text2 = "A" + text2;
			text2 += "e";
			text2 = "C" + text2;
			text2 += "s";
			text2 = "A" + text2;
			text2 += "s";
			text2 = "M" + text2;
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(text);
			foreach (ManagementObject item2 in managementObjectSearcher.Get())
			{
				string item = string.Join("", item2[text2].ToString().Split(':'));
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			int A_ = default(int);
			int adaptersInfo = i7.d.GetAdaptersInfo(null, ref A_);
			if ((adaptersInfo != 0 && adaptersInfo != 111) || A_ == 0)
			{
				result = null;
				ProjectData.ClearProjectError();
				goto IL_03cf;
			}
			byte[] array = new byte[checked(A_ - 1 + 1)];
			if (i7.d.GetAdaptersInfo(array, ref A_) != 0)
			{
				result = null;
				ProjectData.ClearProjectError();
				goto IL_03cf;
			}
			d.c A_2 = default(d.c);
			i7.d.a(ref A_2, array, Marshal.SizeOf((object)A_2));
			IntPtr intPtr = default(IntPtr);
			do
			{
				if (A_2.h == 6)
				{
					string item = c(A_2.f);
					if (!list.Contains(item))
					{
						list.Add(item);
					}
				}
				intPtr = A_2.a;
				if (intPtr.ToInt32() != 0)
				{
					i7.d.a(ref A_2, intPtr, Marshal.SizeOf((object)A_2));
				}
			}
			while (intPtr.ToInt32() != 0);
			ProjectData.ClearProjectError();
		}
		result = list.ToArray();
		goto IL_03cf;
		IL_03cf:
		return result;
	}

	private new static string c(byte[] A_0)
	{
		string text = null;
		int num = 0;
		do
		{
			string text2 = ((num <= Information.UBound(A_0)) ? Conversion.Hex(A_0[num]) : "00");
			if (Strings.Len(text2) < 2)
			{
				text2 = "0" + text2;
			}
			text += text2;
			num = checked(num + 1);
		}
		while (num <= 5);
		return text;
	}

	public new static string c()
	{
		string text = string.Empty;
		string empty = string.Empty;
		string[] array = d();
		int num = 0;
		int num2 = 0;
		VBMath.Randomize();
		checked
		{
			do
			{
				int num3 = 1 + (int)Math.Round(VBMath.Rnd() * 10f);
				string text2 = Conversion.Hex(num3);
				string text3 = Conversion.Hex(VBMath.Rnd() * 15f);
				if (array != null && array.GetUpperBound(0) >= num2)
				{
					string A_ = array[num2].Substring(num3) + array[num2].Substring(0, num3);
					empty = c(ref A_);
				}
				else
				{
					empty = c(num3);
				}
				text = text + empty.Substring(0, 3) + text2 + text3 + empty.Substring(3);
				num2++;
				if (array != null && array.GetUpperBound(0) < num2)
				{
					num2 = 0;
				}
				num++;
			}
			while (num < 5);
			return text;
		}
	}

	private new static string c(int A_0)
	{
		string text = string.Empty;
		int num = 1;
		do
		{
			text += Conversion.Hex(VBMath.Rnd() * 15f);
			num = checked(num + 1);
		}
		while (num <= 12);
		string A_1 = text.Substring(A_0) + text.Substring(0, A_0);
		return c(ref A_1);
	}

	public new static string c(string A_0, e A_1, ref int A_2)
	{
		string[] a_ = new string[1] { A_0 };
		int A_3 = 0;
		return c(a_, A_1, ref A_3, ref A_2);
	}

	public new static string c(string[] A_0, e A_1, ref int A_2, ref int A_3)
	{
		if (A_0 == null)
		{
			string A_4 = DateAndTime.Now.ToString();
			return hh.b(ref A_4);
		}
		string[] array = new string[5];
		int[] array2 = new int[5];
		string[] array3 = new string[5];
		string[] array4 = new string[5];
		string empty = string.Empty;
		string text = null;
		bool flag = false;
		array = d();
		VBMath.Randomize();
		int num = ((array != null && array.Length >= 1) ? array.Length : 0);
		checked
		{
			A_3 = (int)Math.Round(VBMath.Rnd() * (float)(num - 1));
			if (A_0.Length > 0)
			{
				A_2 = (int)Math.Round(VBMath.Rnd() * (float)(A_0.Length - 1));
			}
			int num2 = A_0.Length - 1;
			int num5 = default(int);
			string A_4;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				string text2 = A_0[num3];
				int num4 = 0;
				do
				{
					if (A_0 == null)
					{
						array2[num4] = 0;
						array4[num4] = "";
					}
					else
					{
						if (text2.Length < 40 + num4 * 42 + 42)
						{
							break;
						}
						string text3 = text2.Substring(40 + num4 * 42, 42);
						array3[num4] = text3.Substring(5, 2);
						array2[num4] = Convert.ToInt32(array3[num4].Substring(0, 1), 16);
						array4[num4] = text3.Substring(0, 5) + text3.Substring(7);
					}
					num5++;
					num4++;
				}
				while (num4 <= 4);
				int num6 = 0;
				flag = false;
				while (!flag && num6 < num)
				{
					int num7 = num5 - 1;
					for (num4 = 0; num4 <= num7 && array2[num4] <= array[num6].Length; num4++)
					{
						if (array != null && array.GetUpperBound(0) >= num6)
						{
							A_4 = array[num6].Substring(array2[num4]) + array[num6].Substring(0, array2[num4]);
							empty = c(ref A_4);
						}
						else
						{
							empty = c(array2[num4]);
						}
						A_4 = empty.Substring(0, 9) + Conversion.Hex(unchecked((int)A_1)) + empty.Substring(9);
						text = hh.b(ref A_4);
						if (Operators.CompareString(array4[num4], text, TextCompare: false) == 0)
						{
							A_3 = num4;
							flag = true;
							break;
						}
					}
					if (flag)
					{
						A_2 = num3;
						return text;
					}
					num6++;
				}
			}
			A_4 = DateAndTime.Now.ToString();
			return hh.b(ref A_4);
		}
	}

	public new static string c(string A_0, int A_1)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return null;
		}
		checked
		{
			if (A_0.Length < 40 + A_1 * 42 + 42)
			{
				return "";
			}
			string text = A_0.Substring(40 + A_1 * 42, 42);
			return text.Substring(0, 5) + text.Substring(7);
		}
	}

	public new static string c(ref string A_0)
	{
		string text = "";
		checked
		{
			try
			{
				text = A_0;
				int num = text.Length - 1;
				int num2 = 0;
				int num3 = num;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					num2 = (int)Math.Round((double)num2 + Conversion.Val("&H" + Strings.Mid(text, num4 + 1, 1)));
				}
				string text2 = Conversion.Hex(num2);
				if (Strings.Len(text2) < 4)
				{
					text2 = new string('0', 4 - Strings.Len(text2)) + text2;
				}
				int num5 = num;
				for (int num4 = 0; num4 <= num5; num4++)
				{
					if ((unchecked(num4 % 3) == 0) & (num4 > 0))
					{
						text = Strings.Left(text, num4 - 3) + Strings.Mid(text, num4 + 1, 1) + Strings.Mid(text, num4 - 3 + 2, 2) + Strings.Mid(text, num4 - 3 + 1, 1) + Strings.Mid(text, num4 + 2);
					}
				}
				string str = text;
				text = Strings.Left(str, 1);
				int num6 = num;
				for (int num4 = 1; num4 <= num6; num4++)
				{
					text += Strings.Right(Conversion.Hex((long)Math.Round(Conversion.Val("&H" + Strings.Mid(str, num4, 1))) ^ (long)Math.Round(Conversion.Val("&H" + Strings.Mid(str, num4 + 1, 1)))), 1);
				}
				text = Strings.Mid(text2, 4, 1) + Strings.Mid(text, 1, 2) + Strings.Mid(text2, 3, 1) + Strings.Mid(text, 3, 5) + Strings.Mid(text2, 2, 1) + Strings.Mid(text, 8, 4) + Strings.Mid(text2, 1, 1) + Strings.Mid(text, 12);
				text = Strings.Left(text, 22);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				text = "";
				ProjectData.ClearProjectError();
			}
			return text;
		}
	}

	[SpecialName]
	public bool j()
	{
		if (!File.Exists(a1.d() + "CorrOn.dat"))
		{
			return File.Exists(bg(17) + w[17] + b1());
		}
		return true;
	}

	[SpecialName]
	public bool k()
	{
		return File.Exists(bg(26) + w[26] + b1());
	}
}
