using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class ex
{
	public enum a
	{
		a,
		b
	}

	private bool m_a;

	private bool b;

	private double c;

	private string d;

	private double[] m_e;

	private double[] m_f;

	private int m_g;

	private const short m_h = 2;

	public const string i = "FiberTip";

	public const string j = "FiberTipPending";

	public const string k = "BK7";

	public const string l = "Si";

	public const string m = "ALREF-";

	public const string n = "0";

	private const string o = "_";

	public static string h()
	{
		return "Reference Files";
	}

	public static string g()
	{
		return "*.rrr;*.ttt;*.fmrrr;*.fmttt;*.fitdr";
	}

	public static string l(string A_0)
	{
		return "FiberTipPending_" + A_0;
	}

	public static string f()
	{
		return "FiberTipPending_";
	}

	public static string k(string A_0)
	{
		return "FiberTipPending_" + A_0;
	}

	public static string f(string A_0, string A_1)
	{
		return A_0 + "_" + A_1;
	}

	public static string j(string A_0)
	{
		return "FiberTip_" + A_0;
	}

	public static string e()
	{
		return "FiberTip_";
	}

	public static string i(string A_0)
	{
		return "FiberTip_" + A_0;
	}

	public static string e(string A_0, string A_1)
	{
		return A_0 + "_" + A_1;
	}

	public static bool h(string A_0)
	{
		string text = Path.GetFileNameWithoutExtension(A_0).ToLower();
		if (string.Compare(text, "FiberTip", ignoreCase: true) != 0 && string.Compare(text, "FiberTipPending", ignoreCase: true) != 0 && !text.StartsWith(e().ToLower()))
		{
			return !text.StartsWith(f().ToLower());
		}
		return false;
	}

	public static bool g(string A_0)
	{
		if (!jb.ae(A_0) && !jb.ad(A_0))
		{
			return jb.ac(A_0);
		}
		return true;
	}

	public static int f(string A_0)
	{
		return Path.GetExtension(A_0.ToLower()) switch
		{
			".rrr" => 1, 
			".fmrrr" => 2, 
			".fitdr" => 3, 
			_ => throw new ApplicationException("Unknown Reference Refl file type"), 
		};
	}

	public ex()
	{
		this.m_a = false;
		b = false;
		c = 0.0;
		d = "";
		this.m_g = 0;
	}

	public bool e(string A_0, a A_1, float A_2, bool A_3, bool A_4)
	{
		bool flag = false;
		if (A_1 == ex.a.a)
		{
			string A_5 = ((!jf.e(A_2, 0.0) || A_3) ? jb.a(A_0, A_2, A_3, A_4) : jb.u(A_0));
			if (!string.IsNullOrEmpty(A_5))
			{
				if (A_5.ToLower().EndsWith(".fmrrr"))
				{
					flag = n(A_5);
				}
				else if (A_5.ToLower().EndsWith(".rrr"))
				{
					flag = e(ref A_5);
				}
			}
		}
		else
		{
			string A_5 = jb.t(A_0);
			if (!string.IsNullOrEmpty(A_5))
			{
				if (A_5.ToLower().EndsWith(".fmttt"))
				{
					flag = n(A_5);
				}
				else if (A_5.ToLower().EndsWith(".ttt"))
				{
					flag = e(ref A_5);
				}
			}
		}
		if (!flag)
		{
			float num = (float)Conversion.Val(A_0);
			if (num <= 0f)
			{
				num = 1f;
			}
			this.m_e = new double[1];
			this.m_f = new double[1];
			this.m_e[0] = num;
			this.m_f[0] = 1.0;
			this.m_g = 1;
		}
		return flag;
	}

	public ex(string A_0, bool A_1, bool A_2, double A_3, int A_4, double[] A_5, double[] A_6)
	{
		this.m_a = A_1;
		b = A_2;
		c = A_3;
		d = Guid.NewGuid().ToString();
		this.m_g = A_4;
		this.m_f = A_5;
		this.m_e = A_6;
		e(jb.d() + "\\" + A_0 + ".fmrrr", A_1: true);
	}

	[SpecialName]
	public bool i()
	{
		return this.m_a;
	}

	[SpecialName]
	public void e(bool A_0)
	{
		this.m_a = A_0;
	}

	[SpecialName]
	public bool j()
	{
		return b;
	}

	[SpecialName]
	public void f(bool A_0)
	{
		b = A_0;
	}

	[SpecialName]
	public double k()
	{
		return c;
	}

	[SpecialName]
	public void e(double A_0)
	{
		c = A_0;
	}

	[SpecialName]
	public string l()
	{
		return d;
	}

	[SpecialName]
	public void m(string A_0)
	{
		d = A_0;
	}

	public bool n(string A_0)
	{
		int num = 0;
		bool flag = true;
		checked
		{
			try
			{
				byte[] array = global::c.e().FileSystem.ReadAllBytes(A_0);
				short num2 = BitConverter.ToInt16(array, num);
				num += 2;
				int num3 = BitConverter.ToInt32(array, num);
				num += 4;
				int num4;
				if (num2 > 1)
				{
					num++;
					num4 = 1;
				}
				else
				{
					num4 = 2;
				}
				d = Encoding.ASCII.GetString(array, num, num3);
				num += num3;
				this.m_a = BitConverter.ToBoolean(array, num);
				num += num4;
				b = BitConverter.ToBoolean(array, num);
				num += num4;
				c = BitConverter.ToDouble(array, num);
				num += 8;
				this.m_g = BitConverter.ToInt32(array, num);
				num += 4;
				this.m_f = new double[this.m_g - 1 + 1];
				this.m_e = new double[this.m_g - 1 + 1];
				int num5 = this.m_g - 1;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					this.m_f[num6] = BitConverter.ToDouble(array, num);
					num += 8;
				}
				int num7 = this.m_g - 1;
				for (int num8 = 0; num8 <= num7; num8++)
				{
					this.m_e[num8] = BitConverter.ToDouble(array, num);
					num += 8;
				}
				flag = true;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}
	}

	public bool e(ref string A_0)
	{
		StreamReader streamReader = null;
		long num = 0L;
		bool flag = false;
		bool result = true;
		checked
		{
			try
			{
				streamReader = new StreamReader(File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read));
				string text = streamReader.ReadLine();
				int num2 = 0;
				num = streamReader.BaseStream.Position;
				this.m_f = new double[256];
				this.m_e = new double[256];
				while (!streamReader.EndOfStream & !flag)
				{
					if (num2 > this.m_e.GetUpperBound(0))
					{
						ref double[] reference = ref this.m_f;
						reference = (double[])Utils.CopyArray(reference, new double[num2 - 1 + 128 + 1]);
						ref double[] reference2 = ref this.m_e;
						reference2 = (double[])Utils.CopyArray(reference2, new double[num2 - 1 + 128 + 1]);
					}
					text = streamReader.ReadLine();
					int num3 = text.IndexOf(",");
					if (num3 > 0)
					{
						if (!double.TryParse(text.Substring(0, num3), NumberStyles.Float, CultureInfo.InvariantCulture, out this.m_f[num2]))
						{
							flag = true;
							continue;
						}
						if (!double.TryParse(text.Substring(num3 + 1), NumberStyles.Float, CultureInfo.InvariantCulture, out this.m_e[num2]))
						{
							flag = true;
							continue;
						}
						num2++;
						num = streamReader.BaseStream.Position;
					}
				}
				if (!streamReader.EndOfStream & flag)
				{
					streamReader.BaseStream.Seek(num, SeekOrigin.Begin);
				}
				this.m_g = num2;
				result = true;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				result = false;
				ProjectData.ClearProjectError();
			}
			finally
			{
				streamReader?.Close();
			}
			return result;
		}
	}

	public bool e(string A_0, bool A_1)
	{
		BinaryWriter binaryWriter = null;
		bool result = true;
		checked
		{
			try
			{
				binaryWriter = ((!A_1) ? new BinaryWriter(File.Open(A_0, FileMode.CreateNew)) : new BinaryWriter(File.Open(A_0, FileMode.Create)));
				binaryWriter.Write((short)2);
				binaryWriter.Write(Strings.Len(d));
				binaryWriter.Write(d);
				binaryWriter.Write(this.m_a);
				binaryWriter.Write(b);
				binaryWriter.Write(c);
				binaryWriter.Write(this.m_g);
				int num = this.m_g - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					binaryWriter.Write(this.m_f[num2]);
				}
				int num3 = this.m_g - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					binaryWriter.Write(this.m_e[num4]);
				}
				result = true;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				result = false;
				ProjectData.ClearProjectError();
			}
			finally
			{
				binaryWriter.Close();
			}
			return result;
		}
	}

	public bool e(double[] A_0, int A_1, ref double[] A_2)
	{
		bool result = true;
		try
		{
			A_2 = new double[checked(A_1 - 1 + 1)];
			jf.a(ref this.m_f, ref this.m_e, this.m_g, ref A_0, ref A_2, A_1);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool e(int A_0, ref double A_1)
	{
		bool result;
		try
		{
			A_1 = this.m_e[A_0];
			result = true;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool e(ref double[] A_0)
	{
		bool result;
		try
		{
			A_0 = this.m_e;
			result = true;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static int e(string A_0)
	{
		if (!string.IsNullOrEmpty(jb.a(new string[1] { A_0 + ".fitdr" })))
		{
			return 2;
		}
		return 1;
	}

	public static void e(string A_0, ref string[] A_1, ref float A_2, ref float A_3, ref bool A_4)
	{
		string a_ = File.ReadAllText(A_0) + "\r\n";
		int A_5 = 0;
		string A_6 = "";
		A_1 = new string[2];
		i3.a(ref A_5, a_, ref A_6);
		i3.a(ref A_5, a_, ref A_6);
		int.Parse(A_6, CultureInfo.InvariantCulture);
		i3.a(ref A_5, a_, ref A_6);
		i3.a(ref A_5, a_, ref A_6);
		int.Parse(A_6, CultureInfo.InvariantCulture);
		i3.a(ref A_5, a_, ref A_6);
		i3.a(ref A_5, a_, ref A_1[0]);
		i3.a(ref A_5, a_, ref A_6);
		i3.a(ref A_5, a_, ref A_1[1]);
		i3.a(ref A_5, a_, ref A_6);
		i3.a(ref A_5, a_, ref A_6);
		A_2 = float.Parse(A_6, CultureInfo.InvariantCulture);
		i3.a(ref A_5, a_, ref A_6);
		i3.a(ref A_5, a_, ref A_6);
		A_3 = float.Parse(A_6, CultureInfo.InvariantCulture);
		i3.a(ref A_5, a_, ref A_6);
		i3.a(ref A_5, a_, ref A_6);
		A_4 = int.Parse(A_6, CultureInfo.InvariantCulture) > 0;
	}

	public static string e(string A_0, int A_1)
	{
		string text = jb.a(new string[1] { A_0 + ".fitdr" });
		if (!string.IsNullOrEmpty(text))
		{
			string[] A_2 = null;
			float A_3 = 0f;
			float A_4 = 0f;
			bool A_5 = false;
			e(text, ref A_2, ref A_3, ref A_4, ref A_5);
			return A_2[A_1];
		}
		return A_0;
	}
}
