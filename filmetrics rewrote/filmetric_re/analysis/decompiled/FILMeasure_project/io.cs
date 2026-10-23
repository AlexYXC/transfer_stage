using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using FIUsbIntLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal abstract class io : h6
{
	public new delegate string a(fz A_0, string A_1, g2.OpticsConfigSubmoduleTypes A_2);

	private new enum b
	{
		a,
		b
	}

	protected new bool m2;

	protected bool nf;

	protected bool ng;

	protected string ou;

	protected string p4;

	protected bool p5;

	public const string p6 = ".fitrh";

	protected const string p7 = "_RefHist.fitrh";

	private const int p8 = 1;

	private new const int p9 = 1;

	public io(f0.a A_0, FIUsbController A_1, fz A_2)
		: base(A_0, A_1, A_2)
	{
	}

	public io(f0.a A_0, string A_1, fz A_2)
		: base(A_0, A_1, A_2)
	{
	}

	protected abstract double a9(r.c A_0, r.d.a.b A_1, bool A_2);

	protected abstract float ba(double A_0, r.c A_1, r.d.a.b A_2, ref bool A_3);

	[SpecialName]
	protected abstract @is.a a8();

	public abstract a bb();

	[SpecialName]
	public string yk()
	{
		return ou;
	}

	[SpecialName]
	public bool yl()
	{
		return p5;
	}

	public iv sn(g2.OpticsConfigSubmoduleTypes A_0)
	{
		FileInfo[] files = new DirectoryInfo(@is.b()).GetFiles(@is.b(a8(), ma));
		iv iv2 = new iv(ma);
		FileInfo[] array = files;
		foreach (FileInfo fileInfo in array)
		{
			string text = bb()(ab8(), fileInfo.FullName, A_0);
			if (!string.IsNullOrEmpty(text))
			{
				iu item = new iu(@is.b(fileInfo.Name, ma));
				int num2 = iv2.b.IndexOf(item);
				if (num2 < 0)
				{
					iv2.b.Add(item);
					num2 = checked(iv2.b.Count - 1);
				}
				List<string> list = iv2.b[num2].b;
				if (!list.Contains(text))
				{
					list.Add(text);
				}
				list = null;
			}
		}
		return iv2;
	}

	public void ym()
	{
		this.m2 = true;
	}

	[SpecialName]
	public bool yn()
	{
		return nf;
	}

	[SpecialName]
	public string yo()
	{
		return Path.Combine(@is.b(), @is.c(@is.a.e) + ma + @is.f(@is.a.e));
	}

	protected bool m2(float A_0, float A_1, g2.OpticsConfigSubmoduleTypes A_2, ref double A_3, ref DateTime A_4, ref double A_5)
	{
		return m2(0, A_0, A_1, A_2, ref A_3, ref A_4, ref A_5);
	}

	protected bool m2(int A_0, float A_1, float A_2, g2.OpticsConfigSubmoduleTypes A_3, ref double A_4, ref DateTime A_5, ref double A_6)
	{
		Collection<double[]> A_7 = null;
		Collection<DateTime[]> A_8 = null;
		int[] A_9 = new int[0];
		Collection<bool[]> A_10 = null;
		double num = 0.0;
		A_6 = 1.0;
		string text = ti(A_0);
		try
		{
			m2(text, ref A_7, ref A_8, ref A_9, ref A_10, A_5: true);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			A_9 = null;
			ab8().c(fz.b.a, "Error in USBSpectralDevice.ReadReferenceHistory", a_);
			if (File.Exists(text))
			{
				string directoryName = Path.GetDirectoryName(text);
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
				string extension = Path.GetExtension(text);
				int num2 = default(int);
				string text2;
				do
				{
					num2 = checked(num2 + 1);
					text2 = Path.Combine(directoryName, fileNameWithoutExtension) + "_Bad" + num2 + extension;
				}
				while (File.Exists(text2));
				try
				{
					File.Move(text, text2);
					ab8().c(fz.b.a, "Corrupted RefHist file detected. File has been renamed as " + text2);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ab8().c(fz.b.a, "Error in USBSpectralDevice.ReadReferenceHistory, attempting to rename " + text + " as " + text2, a_);
					ProjectData.ClearProjectError();
				}
			}
			ProjectData.ClearProjectError();
		}
		if (A_9 == null || A_9.Length <= (int)A_3 || A_9[(int)A_3] == 0)
		{
			return true;
		}
		bool[] array = A_10[(int)A_3];
		int num3;
		checked
		{
			num3 = A_9[unchecked((int)A_3)] - 1;
		}
		double[] array2 = A_7[(int)A_3];
		DateTime[] array3 = A_8[(int)A_3];
		A_6 = (double)A_2 / array2[num3];
		if (this.m2)
		{
			return true;
		}
		for (int num4 = num3; num4 >= 0; num4 = checked(num4 + -1))
		{
			if (num < array2[num4])
			{
				num = array2[num4];
				A_4 = (double)A_2 / num;
				A_5 = array3[num4];
			}
			if (array[num4])
			{
				break;
			}
		}
		return A_4 >= (double)A_1;
	}

	public static void m2(string A_0, ref Collection<double[]> A_1, ref Collection<DateTime[]> A_2, ref int[] A_3, ref Collection<bool[]> A_4)
	{
		m2(A_0, ref A_1, ref A_2, ref A_3, ref A_4, A_5: false);
	}

	public static void m2(string A_0, ref Collection<double[]> A_1, ref Collection<DateTime[]> A_2, ref int[] A_3, ref Collection<bool[]> A_4, bool A_5)
	{
		StreamReader streamReader = null;
		StreamWriter streamWriter = null;
		checked
		{
			try
			{
				string A_6 = "";
				string A_7 = "";
				DateTime[] array = new DateTime[11];
				double[] array2 = new double[11];
				int[] array3 = new int[11];
				int[] array4 = new int[11];
				bool flag = false;
				string A_8 = "";
				Collection<string[]> collection = null;
				string A_9 = "";
				Collection<double[]> collection2 = null;
				Collection<double[]> collection3 = null;
				Collection<double[]> collection4 = null;
				Collection<double[]> collection5 = null;
				DateTime t2 = new DateTime(1990, 1, 1);
				A_1 = new Collection<double[]>();
				A_2 = new Collection<DateTime[]>();
				A_4 = new Collection<bool[]>();
				A_3 = new int[11];
				if (A_5)
				{
					collection = new Collection<string[]>();
					collection3 = new Collection<double[]>();
					collection2 = new Collection<double[]>();
					collection4 = new Collection<double[]>();
					collection5 = new Collection<double[]>();
				}
				bool flag2 = default(bool);
				if (File.Exists(A_0))
				{
					streamReader = new StreamReader(A_0, Encoding.ASCII);
					A_6 = streamReader.ReadLine();
					int.Parse(A_6.Substring(A_6.IndexOf(",") + 1), CultureInfo.InvariantCulture);
					A_6 = streamReader.ReadLine();
					if (int.Parse(A_6.Substring(A_6.IndexOf(",") + 1), CultureInfo.InvariantCulture) > 1)
					{
						return;
					}
					streamReader.ReadLine();
					int num = default(int);
					do
					{
						string a_ = streamReader.ReadLine() + "\r\n";
						int A_10 = 0;
						i3.a(ref A_10, a_, ref A_6);
						i3.a(ref A_10, a_, ref A_7);
						i3.a(ref A_10, a_, ref A_6);
						g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = g2.a(A_6.Trim());
						DateTime dateTime = DateTime.FromOADate(double.Parse(A_7, CultureInfo.InvariantCulture));
						if (opticsConfigSubmoduleTypes >= g2.OpticsConfigSubmoduleTypes.ReflectanceProbe && unchecked(A_3[(int)opticsConfigSubmoduleTypes] == 0 || DateTime.Compare(array[(int)opticsConfigSubmoduleTypes], dateTime) != 0) && DateTime.Compare(dateTime, t2) > 0)
						{
							A_3[unchecked((int)opticsConfigSubmoduleTypes)]++;
							array[unchecked((int)opticsConfigSubmoduleTypes)] = dateTime;
						}
						num++;
					}
					while (!streamReader.EndOfStream);
					streamReader.Close();
					flag2 = A_5 && num > 5000;
				}
				else
				{
					flag = true;
				}
				int num2 = 0;
				do
				{
					if (A_3[num2] > 0)
					{
						double[] item = new double[A_3[num2] - 1 + 1];
						DateTime[] item2 = new DateTime[A_3[num2] - 1 + 1];
						bool[] item3 = new bool[A_3[num2] - 1 + 1];
						A_1.Add(item);
						A_2.Add(item2);
						A_4.Add(item3);
						if (flag2)
						{
							string[] item4 = new string[A_3[num2] - 1 + 1];
							collection.Add(item4);
							item = new double[A_3[num2] - 1 + 1];
							collection3.Add(item);
							item = new double[A_3[num2] - 1 + 1];
							collection2.Add(item);
							item = new double[A_3[num2] - 1 + 1];
							collection4.Add(item);
							item = new double[A_3[num2] - 1 + 1];
							collection5.Add(item);
						}
					}
					else
					{
						A_1.Add(null);
						A_2.Add(null);
						A_4.Add(null);
						if (flag2)
						{
							collection.Add(null);
							collection3.Add(null);
							collection2.Add(null);
							collection4.Add(null);
							collection5.Add(null);
						}
					}
					num2++;
				}
				while (num2 <= 10);
				if (flag)
				{
					return;
				}
				streamReader = new StreamReader(A_0, Encoding.ASCII);
				streamReader.ReadLine();
				streamReader.ReadLine();
				streamReader.ReadLine();
				array = new DateTime[11];
				A_3 = new int[11];
				do
				{
					string a_ = streamReader.ReadLine() + "\r\n";
					int A_10 = 0;
					i3.a(ref A_10, a_, ref A_6);
					i3.a(ref A_10, a_, ref A_7);
					i3.a(ref A_10, a_, ref A_6);
					g2.OpticsConfigSubmoduleTypes opticsConfigSubmoduleTypes = g2.a(A_6.Trim());
					DateTime dateTime = DateTime.FromOADate(double.Parse(A_7, CultureInfo.InvariantCulture));
					if (opticsConfigSubmoduleTypes < g2.OpticsConfigSubmoduleTypes.ReflectanceProbe || (A_3[unchecked((int)opticsConfigSubmoduleTypes)] != 0 && DateTime.Compare(A_2[unchecked((int)opticsConfigSubmoduleTypes)][A_3[unchecked((int)opticsConfigSubmoduleTypes)] - 1], dateTime) == 0) || DateTime.Compare(dateTime, t2) <= 0)
					{
						continue;
					}
					i3.a(ref A_10, a_, ref A_8);
					i3.a(ref A_10, a_, ref A_6);
					double num3 = double.Parse(A_6, CultureInfo.InvariantCulture);
					i3.a(ref A_10, a_, ref A_9);
					i3.a(ref A_10, a_, ref A_6);
					double num4 = double.Parse(A_6, CultureInfo.InvariantCulture);
					i3.a(ref A_10, a_, ref A_6);
					double num5 = double.Parse(A_6, CultureInfo.InvariantCulture);
					unchecked
					{
						if (num5 > 0.0 && num4 > 0.0)
						{
							A_1[(int)opticsConfigSubmoduleTypes][A_3[(int)opticsConfigSubmoduleTypes]] = num3 / (num5 * num4);
						}
						else
						{
							A_1[(int)opticsConfigSubmoduleTypes][A_3[(int)opticsConfigSubmoduleTypes]] = 0.0;
						}
						A_2[(int)opticsConfigSubmoduleTypes][A_3[(int)opticsConfigSubmoduleTypes]] = dateTime;
						i3.a(ref A_10, a_, ref A_6);
						A_4[(int)opticsConfigSubmoduleTypes][A_3[(int)opticsConfigSubmoduleTypes]] = int.Parse(A_6, CultureInfo.InvariantCulture) != 0;
						if (flag2)
						{
							if (A_4[(int)opticsConfigSubmoduleTypes][A_3[(int)opticsConfigSubmoduleTypes]])
							{
								array2[(int)opticsConfigSubmoduleTypes] = A_1[(int)opticsConfigSubmoduleTypes][A_3[(int)opticsConfigSubmoduleTypes]];
								array3[(int)opticsConfigSubmoduleTypes] = A_3[(int)opticsConfigSubmoduleTypes];
								array4[(int)opticsConfigSubmoduleTypes] = A_3[(int)opticsConfigSubmoduleTypes];
							}
							else if (A_1[(int)opticsConfigSubmoduleTypes][A_3[(int)opticsConfigSubmoduleTypes]] > array2[(int)opticsConfigSubmoduleTypes])
							{
								array2[(int)opticsConfigSubmoduleTypes] = A_1[(int)opticsConfigSubmoduleTypes][A_3[(int)opticsConfigSubmoduleTypes]];
								array3[(int)opticsConfigSubmoduleTypes] = A_3[(int)opticsConfigSubmoduleTypes];
							}
							collection[(int)opticsConfigSubmoduleTypes][A_3[(int)opticsConfigSubmoduleTypes]] = A_8;
							collection3[(int)opticsConfigSubmoduleTypes][A_3[(int)opticsConfigSubmoduleTypes]] = num3;
							collection2[(int)opticsConfigSubmoduleTypes][A_3[(int)opticsConfigSubmoduleTypes]] = double.Parse(A_9, CultureInfo.InvariantCulture);
							collection4[(int)opticsConfigSubmoduleTypes][A_3[(int)opticsConfigSubmoduleTypes]] = num4;
							collection5[(int)opticsConfigSubmoduleTypes][A_3[(int)opticsConfigSubmoduleTypes]] = num5;
						}
					}
					A_3[unchecked((int)opticsConfigSubmoduleTypes)]++;
				}
				while (!streamReader.EndOfStream);
				streamReader.Close();
				if (!flag2)
				{
					return;
				}
				DateTime t3 = DateTime.Now.AddMonths(-60);
				string text = A_0 + "temp";
				streamWriter = new StreamWriter(text, append: false, Encoding.ASCII);
				m2(streamWriter);
				int num6 = 0;
				int num8 = default(int);
				int num9 = default(int);
				do
				{
					DateTime[] array5 = A_2[num6];
					string[] array6 = collection[num6];
					double[] array7 = collection3[num6];
					double[] array8 = collection2[num6];
					double[] array9 = collection4[num6];
					double[] array10 = collection5[num6];
					bool[] array11 = A_4[num6];
					int num7 = A_3[num6] - 1;
					if (num7 >= 100)
					{
						unchecked
						{
							num8 = A_3[num6] / checked(A_3[num6] - 100);
						}
						num9 = num8 + 1;
					}
					int num10 = num7;
					for (int num11 = 0; num11 <= num10; num11++)
					{
						if (num11 > num7 - 100 || (unchecked(num11 % num9) != num8 && DateTime.Compare(array5[num11], t3) > 0) || array4[num6] == num11 || array3[num6] == num11)
						{
							m2(streamWriter, array5[num11].ToLocalTime(), unchecked((g2.OpticsConfigSubmoduleTypes)num6), array6[num11], array7[num11], array8[num11], array9[num11], array10[num11], array11[num11]);
						}
					}
					num6++;
				}
				while (num6 <= 10);
				streamWriter.Close();
				File.Delete(A_0);
				global::c.e().FileSystem.RenameFile(text, Path.GetFileName(A_0));
			}
			finally
			{
				streamReader?.Close();
				streamWriter?.Close();
			}
		}
	}

	[SpecialName]
	public string yp()
	{
		return ti(0);
	}

	[SpecialName]
	public string ti(int A_0)
	{
		string text = string.Empty;
		if (A_0 > 0)
		{
			text = "-" + A_0.ToString().Trim();
		}
		return @is.b() + ma + text + "_RefHist.fitrh";
	}

	[SpecialName]
	public string yq()
	{
		return ma;
	}

	public virtual string bc()
	{
		return m2(abu(), abv());
	}

	private static string m2(FMRefMatEnums A_0, int A_1)
	{
		return A_0 switch
		{
			FMRefMatEnums.kRefMatBk7 => "BK7", 
			FMRefMatEnums.kRefMatSi => "Si", 
			FMRefMatEnums.kRefMatFusedSilica2Sided => "Fused Silica (2-sided)", 
			FMRefMatEnums.kRefMatALREF => "ALREF-" + A_1.ToString().Trim(), 
			_ => "Si", 
		};
	}

	public static string m2(fz A_0, @is.a A_1, string A_2, g2.OpticsConfigSubmoduleTypes A_3)
	{
		return A_1 switch
		{
			@is.a.a => ip.m2(A_0, A_2, A_3), 
			@is.a.b => @in.m2(A_0, A_2, A_3), 
			_ => null, 
		};
	}

	public string yr()
	{
		return @is.b() + @is.c(@is.a.d) + ma + @is.f(@is.a.d);
	}

	public string ys()
	{
		return @is.c(a8()) + ma + "_";
	}

	public string tj(int A_0)
	{
		return @is.b() + ys() + A_0 + @is.e(a8());
	}

	public string m2(string A_0, string A_1, g2.OpticsConfigSubmoduleTypes A_2, a A_3, ref bool A_4, ref bool A_5)
	{
		string text = "";
		string text2 = @is.b();
		DirectoryInfo directoryInfo = new DirectoryInfo(text2);
		string text3 = "";
		string text4 = text2 + @is.c(a8()) + ma;
		string text5 = "";
		List<int> list = new List<int>();
		bool flag = false;
		int num = int.MaxValue;
		bool flag2 = false;
		if (string.IsNullOrEmpty(A_0))
		{
			text3 = @is.b(a8(), ma);
		}
		else
		{
			text3 = @is.b(a8(), ma, A_0);
			text4 = text4 + "_" + A_0;
		}
		A_5 = false;
		checked
		{
			if (Directory.Exists(text2))
			{
				FileInfo[] files = directoryInfo.GetFiles(text3);
				if (files.GetUpperBound(0) >= 0)
				{
					A_4 = false;
					if (string.IsNullOrEmpty(A_1))
					{
						A_1 = bc();
					}
					List<FileInfo> list2 = new List<FileInfo>();
					int num2 = files.Length - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						string name = files[num3].Name;
						int num4 = name.LastIndexOf("_");
						if (num4 >= 0)
						{
							if (num4 - (name.IndexOf(ma) + Strings.Len(ma)) >= 0)
							{
								string text6 = name.Substring(num4 + 1, name.LastIndexOf(".") - num4 - 1);
								if (int.TryParse(text6, out var _) && Operators.CompareString(text6.ToString(), text6, TextCompare: false) == 0)
								{
									list2.Add(files[num3]);
								}
							}
							else if (Operators.CompareString(name.ToLower(), Path.GetFileNameWithoutExtension(text3.Substring(text3.Length - 1)).ToLower(), TextCompare: false) == 0)
							{
								list2.Add(files[num3]);
							}
						}
						name = null;
					}
					foreach (FileInfo item in list2)
					{
						text5 = @is.b(item.FullName, ma);
						if (Operators.CompareString(text5, A_0, TextCompare: false) != 0 && Operators.CompareString(text5, "<Default>", TextCompare: false) != 0)
						{
							continue;
						}
						text = A_3(ab8(), item.FullName, A_2);
						string right = ((A_2 != g2.OpticsConfigSubmoduleTypes.Transmittance || abb() <= 0) ? A_1 : "1");
						if (!string.IsNullOrEmpty(text) && Operators.CompareString(text, right, TextCompare: false) == 0)
						{
							text4 = item.FullName;
							A_4 = true;
							break;
						}
						if (string.IsNullOrEmpty(text))
						{
							flag = true;
							string name2 = item.Name;
							int num4 = name2.LastIndexOf("_");
							if (num4 - (name2.IndexOf(ma) + Strings.Len(ma)) >= 0)
							{
								int num5 = Conversions.ToInteger(name2.Substring(num4 + 1, name2.LastIndexOf(".") - num4 - 1));
								if (num > num5)
								{
									num = num5;
									flag2 = true;
								}
							}
							name2 = null;
						}
						else
						{
							string name3 = item.Name;
							int num4 = name3.LastIndexOf("_");
							if (num4 - (name3.IndexOf(ma) + Strings.Len(ma)) >= 0)
							{
								list.Add(Conversions.ToInteger(name3.Substring(num4 + 1, name3.LastIndexOf(".") - num4 - 1)));
							}
							else
							{
								list.Add(-1);
							}
							name3 = null;
						}
					}
				}
			}
			if (!A_4)
			{
				if (flag)
				{
					if (flag2)
					{
						text4 = text4 + "_" + num.ToString(CultureInfo.InvariantCulture);
					}
					text4 += @is.f(a8());
					A_5 = true;
				}
				else
				{
					int num6 = 0;
					if (list.Count > 0)
					{
						list.Sort();
						if (list[0] == -1)
						{
							list.RemoveAt(0);
						}
						for (int num7 = list.Count - 1; num6 <= num7 && list[num6] == num6; num6++)
						{
						}
					}
					text4 = text4 + "_" + num6.ToString(CultureInfo.InvariantCulture) + @is.f(a8());
				}
			}
			return text4;
		}
	}

	private static void m2(h5 A_0, b A_1, byte A_2, ushort A_3, int A_4)
	{
		if (A_1 == b.a)
		{
			int num = A_0.p9(A_3);
			if (num != 0)
			{
				throw new ai("Failure attempting to set lamp setpoint to " + A_3 + ". ErrCode=" + num);
			}
		}
		else
		{
			int num = A_0.p9(A_2, A_3);
			if (num != 0)
			{
				throw new ai("Failure attempting to set LED(" + A_2 + ") setpoint to " + A_3 + ". ErrCode=" + num);
			}
		}
		if (A_4 > 0)
		{
			Thread.Sleep(A_4);
		}
	}

	private static void m2(h5 A_0, b A_1, byte A_2, int A_3)
	{
		FIUsbController fIUsbController = A_0.abk();
		if (A_1 == b.a)
		{
			if (fIUsbController.LampSetpointIsKnown == 0 || fIUsbController.LampSetpoint != fIUsbController.MaxLampSetpoint)
			{
				m2(A_0, A_1, A_2, fIUsbController.MaxLampSetpoint, A_3);
			}
		}
		else if (((IFIUsbController)fIUsbController).get_LsLEDSetpointIsKnown(A_2) == 0 || ((IFIUsbController)fIUsbController).get_LsLEDSetpoint(A_2) != ((IFIUsbController)fIUsbController).get_LsMaxLEDSetpoint(A_2))
		{
			m2(A_0, A_1, A_2, ((IFIUsbController)fIUsbController).get_LsMaxLEDSetpoint(A_2), A_3);
		}
		fIUsbController = null;
	}

	private static ushort m2(h5 A_0, b A_1, byte A_2)
	{
		FIUsbController fIUsbController = A_0.abk();
		if (A_1 == b.a)
		{
			return fIUsbController.MaxLampSetpoint;
		}
		return ((IFIUsbController)fIUsbController).get_LsMaxLEDSetpoint(A_2);
	}

	public bool m2(h5 A_0, r.c A_1, r.d.a.b A_2)
	{
		bool result;
		if (!A_0.s3())
		{
			result = false;
		}
		else
		{
			double a_ = a9(A_1, A_2, A_2: true);
			bool A_3 = default(bool);
			float num = ba(a_, A_1, A_2, ref A_3);
			if (num < 500f)
			{
				result = false;
			}
			else
			{
				int num2 = A_0.qh(A_0: false);
				if (num2 != 0)
				{
					throw new ai("Failure attempting to turn light source off in CheckIfLightIsFromInternalSource. Error code=" + num2);
				}
				Thread.Sleep(1500);
				float num3 = ba(a_, A_1, A_2, ref A_3);
				result = (num - num3) / num > 0.5f;
				num2 = A_0.qh(A_0: true);
				Thread.Sleep(500);
			}
		}
		return result;
	}

	public void m2(h5 A_0, r.c A_1, bool A_2, r.d.a.b A_3, ref bool A_4)
	{
		A_4 = false;
		if (!A_2 && !A_0.s6())
		{
			return;
		}
		checked
		{
			byte b10 = (byte)unchecked((uint)(A_0.td() - 1));
			ushort[] array = new ushort[b10 + 1];
			string text = null;
			int num = b10 + 2;
			int[] array2 = new int[num + 1];
			int[] array3 = new int[num + 1];
			int[] array4 = new int[num + 1];
			ushort[] array5 = new ushort[b10 + 1];
			ushort lampSetpoint = default(ushort);
			try
			{
				lampSetpoint = A_0.abk().LampSetpoint;
				A_1.t(60f, A_3);
				string A_5 = "LightSourceAdjusting";
				A_1.t(hu.a(ref A_5));
				bool a_ = false;
				array4[0] = (int)Math.Round((float)(1 + m2(A_0, b.a, 0)) * 0.1f);
				int num2 = array4[0];
				array2[0] = 0;
				array3[0] = num2;
				array2[1] = num2;
				byte b11 = b10;
				byte b12 = 0;
				while (unchecked((uint)b12 <= (uint)b11))
				{
					array5[b12] = ((IFIUsbController)A_0.abk()).get_LsLEDSetpoint(b12);
					m2(A_0, b.b, b12, 0, 0);
					array4[b12 + 1] = (int)Math.Round((float)(1 + m2(A_0, b.b, b12)) * 0.1f);
					num2 += array4[b12 + 1];
					array3[b12 + 1] = num2;
					array2[b12 + 2] = num2;
					b12 = (byte)unchecked((uint)(b12 + 1));
				}
				array4[num] = 60;
				num2 = (array3[num] = num2 + array4[num]);
				b b13 = b.a;
				int a_2 = 500;
				int a_3 = 1000;
				b12 = 0;
				int num3 = 0;
				double a_4 = default(double);
				bool A_6 = default(bool);
				float num15 = default(float);
				float num18 = default(float);
				bool A_7 = default(bool);
				float num19 = default(float);
				ushort num20 = default(ushort);
				int num21 = default(int);
				ushort num22 = default(ushort);
				ushort a_5 = default(ushort);
				do
				{
					bool flag = false;
					bool flag2 = false;
					ushort num4 = 0;
					float num5 = 0f;
					bool flag3 = false;
					ushort num6 = 0;
					float num7 = 0f;
					bool flag4 = false;
					float num8 = 0f;
					ushort num9 = 0;
					ushort num10 = m2(A_0, b13, b12);
					m2(A_0, b13, b12, a_3);
					if (b13 == b.b)
					{
						Thread.Sleep(500);
					}
					ushort num11 = m2(A_0, b13, b12);
					ushort num12 = (ushort)Math.Round(0.1f * (float)unchecked((int)num11));
					ushort num13 = num12;
					float num14;
					float num16;
					float num17;
					bool flag5;
					bool flag6;
					if (b13 == b.a)
					{
						a_4 = a9(A_1, A_3, A_2: false);
						num14 = ba(a_4, A_1, A_3, ref A_6);
						num15 = num14;
						num16 = 0.95f * num14;
						num17 = 0.2f * num14;
						flag5 = true;
						flag6 = false;
					}
					else
					{
						num16 = ((b12 != 1) ? num15 : (0.9f * num15));
						num14 = ba(a_4, A_1, A_3, ref A_6);
						num17 = 0.2f * num14;
						flag5 = num14 > num16;
						flag6 = !flag5;
					}
					bool flag7 = false;
					while (!flag7)
					{
						if (A_1.a)
						{
							return;
						}
						bool flag9;
						if (unchecked((uint)num10 > (uint)num13))
						{
							if (flag5)
							{
								num10 = (ushort)unchecked((uint)(num10 - num13));
							}
							else
							{
								num10 = (ushort)unchecked((uint)(num10 + num13));
								if (unchecked((uint)num10 > (uint)num11))
								{
									num10 = num11;
								}
							}
							m2(A_0, b13, b12, num10, a_2);
							num18 = ba(a_4, A_1, A_3, ref A_7);
							if (num18 < 0.97f * num14 && (!flag || num18 > num5))
							{
								flag = true;
								num5 = num18;
								num4 = num10;
							}
							if (!flag3 && num18 < num16)
							{
								flag3 = true;
								num6 = num10;
								num7 = num18;
							}
							bool flag8;
							if (!flag4)
							{
								if (flag && !flag2 && num18 < 0.8f * num14)
								{
									flag2 = true;
									num19 = num18;
									num20 = num10;
								}
								flag8 = num18 > num17;
								if (num18 > 0.1f * num14 && num18 < num17)
								{
									flag4 = true;
									num8 = num18;
									num9 = num10;
									flag8 = false;
									if (flag6)
									{
										num10 = num11;
										num18 = num14;
										flag5 = false;
									}
									else
									{
										num10 = num6;
										num18 = num7;
										flag5 = true;
										num13 = num12;
									}
								}
							}
							else
							{
								flag8 = num18 > num16;
							}
							if (!flag8 && num10 == num11)
							{
								flag7 = true;
								break;
							}
							flag9 = flag5 != flag8;
							flag5 = flag8;
							if (flag8)
							{
							}
						}
						else
						{
							flag9 = true;
						}
						if (flag9)
						{
							if (num13 > 1)
							{
								num13 = (ushort)unchecked((uint)num13 / 2u);
								if (num13 < 1)
								{
									num13 = 1;
								}
							}
							else
							{
								flag7 = true;
							}
						}
						num21++;
						A_1.t(100f * (float)(array2[num3] + num21) / (float)num2);
					}
					unchecked
					{
						string text2 = ((!flag4 || !(num5 > num8) || A_6) ? "Unknown" : ((100f * num14 / (num5 - num8) * (float)(int)checked((ushort)unchecked((uint)(num4 - num9))) / (float)(int)num11).ToString("0.0") + "%"));
						string text3 = "Inten @ Max Setpoint(100%)=" + num14.ToString("0.0", CultureInfo.InvariantCulture) + Interaction.IIf(A_6, " (Saturated)", string.Empty).ToString() + ", Inten @ max changed setpoint(" + (100f * (float)(int)num4 / (float)(int)num11).ToString("0.0", CultureInfo.InvariantCulture) + "%)=" + num5.ToString("0.0", CultureInfo.InvariantCulture) + ", Inten @ target setpoint(" + (100f * (float)(int)num10 / (float)(int)num11).ToString("0.0", CultureInfo.InvariantCulture) + "%)=" + num18.ToString("0.0", CultureInfo.InvariantCulture) + ", Inten @ midscale setpoint(" + (100f * (float)(int)num20 / (float)(int)num11).ToString("0.0", CultureInfo.InvariantCulture) + "%)=" + num19.ToString("0.0", CultureInfo.InvariantCulture) + ", Inten @ func. test setpoint(" + (100f * (float)(int)num9 / (float)(int)num11).ToString("0.0", CultureInfo.InvariantCulture) + "%)=" + num8.ToString("0.0", CultureInfo.InvariantCulture) + ". Usable control range=" + text2 + ".";
						if (b13 == b.a)
						{
							if (!flag4 || !flag || (double)(int)checked((ushort)unchecked((uint)(num4 - num9))) < 0.1 * (double)(int)num11)
							{
								a_ = true;
								if (!string.IsNullOrEmpty(text))
								{
									text += "\r\n";
								}
								text += "Lamp control circuit malfunction.";
								ab8().c(fz.b.a, "Light Source lamp control circuit malfunction. " + text3 + ". Lamp will be operated open-loop at max output.");
								num10 = num11;
							}
							else
							{
								ab8().c(fz.b.a, "Light Source lamp control circuit test passed. " + text3 + ". Lamp will be operated in closed loop at " + (100f * (float)(int)num10 / (float)(int)num11).ToString("0.0", CultureInfo.InvariantCulture) + " %.");
								num15 = num18;
								checked
								{
									num22 = (ushort)Math.Round(Math.Max(unchecked((float)(int)num9 - (float)(int)checked((ushort)unchecked((uint)(num20 - num9))) * num8 / (num19 - num8)), 0.0));
								}
								ab8().c(fz.b.a, "Light Source estimated lamp zero setpoint=" + (100f * (float)(int)num22 / (float)(int)num11).ToString("0.0", CultureInfo.InvariantCulture) + "%");
							}
							a_5 = num10;
							m2(A_0, b.a, 0, 0, a_2);
							b13 = b.b;
							a_2 = 1;
							a_3 = 300;
						}
						else
						{
							if ((double)(int)checked((ushort)unchecked((uint)(num4 - num9))) < 0.4000000059604645 * (double)(int)num11 && !A_6)
							{
								a_ = true;
								if (!string.IsNullOrEmpty(text))
								{
									text += "\r\n";
								}
								text = text + "LED(" + b12 + ") control circuit malfunction.";
								ab8().c(fz.b.a, "Light Source LED(" + b12 + ") control circuit malfunction. " + text3 + ". LED will be operated at max output.");
								num10 = num11;
							}
							else
							{
								ab8().c(fz.b.a, "Light Source LED(" + b12 + ") control circuit test passed. " + text3 + ". LED will be operated in closed loop at " + (100f * (float)(int)num10 / (float)(int)num11).ToString("0.0", CultureInfo.InvariantCulture) + " %.");
							}
							array[b12] = num10;
							if ((uint)b12 < (uint)b10)
							{
								m2(A_0, b.b, b12, 0, a_2);
							}
							checked
							{
								b12 = (byte)unchecked((uint)(b12 + 1));
							}
						}
					}
					num3++;
					num21 = 0;
				}
				while (unchecked((uint)b12 <= (uint)b10));
				A_0.m2(a_5, array);
				A_1.t(100f * (float)(array2[num3] + num21) / (float)array3[num3]);
				A_5 = "LightSourceStabilizationDelay";
				A_1.t(hu.a(ref A_5));
				int num23 = 1;
				do
				{
					if (A_1.a)
					{
						return;
					}
					Thread.Sleep(1000);
					num21++;
					A_1.t(100f * (float)(array2[num3] + num21) / (float)array3[num3]);
					num23++;
				}
				while (num23 <= 60);
				A_1.z();
				bool flag10 = A_0.tg() && global::e.a().LightSourceAutoStandby;
				A_0.m2(a_5, num22, array, !flag10, A_4: true, a_, text);
				A_0.p9(flag10);
				A_4 = true;
			}
			finally
			{
				if (!A_4)
				{
					A_0.m2(lampSetpoint, array5);
				}
			}
		}
	}

	protected static void m2(StreamWriter A_0, DateTime A_1, g2.OpticsConfigSubmoduleTypes A_2, string A_3, double A_4, double A_5, double A_6, double A_7, bool A_8)
	{
		A_0.Write(A_1.ToString() + ", ");
		A_0.Write(A_1.ToUniversalTime().ToOADate().ToString(CultureInfo.InvariantCulture) + ", ");
		A_0.Write(g2.o(A_2) + ", ");
		A_0.Write("\"" + A_3 + "\", ");
		A_0.Write(A_4.ToString("0.0", CultureInfo.InvariantCulture) + ", ");
		A_0.Write(A_5.ToString("0.0", CultureInfo.InvariantCulture) + ", ");
		A_0.Write(A_6.ToString("0.00", CultureInfo.InvariantCulture) + ", ");
		A_0.Write(A_7.ToString(CultureInfo.InvariantCulture) + ", ");
		A_0.WriteLine((0 - (A_8 ? 1 : 0)).ToString());
	}

	protected static void m2(StreamWriter A_0)
	{
		A_0.WriteLine("Version, " + 1);
		A_0.WriteLine("Compatible Version, " + 1);
		A_0.WriteLine("Ref Date/Time Local, Ref Date/Time UTC, OpticsConfig, RefMat, Peak Raw Signal, Peak Raw Signal Wavelen (nm), Ref R at Peak Wavelen (%), Tint (ms), Ignore Previous");
	}
}
