using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class fy
{
	public enum a
	{
		a = 1,
		b
	}

	protected double[] j;

	private double[] m_k;

	private double[] m_l;

	protected double[] m;

	protected a6 n;

	private a6 o;

	private const int p = 1;

	private const int q = 1;

	private const int m_r = 2;

	private const int s = 4;

	protected fy t;

	protected Collection<fy> u;

	protected string v;

	protected string w;

	protected const char x = '\t';

	protected const string y = "uR";

	protected const string z = "uT";

	protected const string aa = "pR";

	protected const string ab = "sR";

	protected const string ac = "nm";

	protected const string ad = "0";

	protected const string ae = " @";

	protected const string af = " deg ";

	protected const string ag = " polarized";

	public const string ah = "tm";

	public const string ai = "te";

	public const string al = "mixed";

	protected bool am;

	protected string ao;

	protected string ap;

	protected bool aq;

	protected bool ar;

	protected double @as;

	protected double at;

	protected double au;

	protected double av;

	public const string aw = "Comma Separated Values (*.csv)|*.csvText Files (*.txt)|*.txt";

	protected void r(string A_0, ref string A_1, ref string A_2)
	{
		A_1 = string.Empty;
		A_2 = string.Empty;
		int num = A_0.IndexOf(" @");
		int num2 = A_0.IndexOf(" deg ");
		checked
		{
			if (num >= 0 && num2 >= 0 && num2 >= num + " @".Length)
			{
				A_1 = A_0.Substring(num + " @".Length, num2 - num - " @".Length);
			}
			int num3 = A_0.IndexOf(" deg ");
			int num4 = A_0.IndexOf(" polarized");
			if (num3 >= 0 && num4 >= 0 && num4 >= num3 + " @".Length)
			{
				A_2 = A_0.Substring(num3 + " deg ".Length, num4 - num3 - " deg ".Length);
			}
		}
	}

	protected virtual int ai(int A_0)
	{
		if (A_0 == 1)
		{
			return 1;
		}
		return 1;
	}

	protected virtual void av(ref BinaryWriter A_0, int A_1, bool A_2)
	{
		m(ref A_0);
	}

	protected virtual void a4(ref BinaryReader A_0, int A_1, bool A_2)
	{
		l(ref A_0);
	}

	protected void r(ref StreamWriter A_0, string A_1, ref string A_2, string A_3, bool A_4, ref CultureInfo A_5)
	{
		ar(ref A_0, j, c0(), c2(), A_1, ref A_2, A_3, A_4, ref A_5);
	}

	protected virtual void ar(ref StreamWriter A_0, double[] A_1, double[] A_2, int A_3, string A_4, ref string A_5, string A_6, bool A_7, ref CultureInfo A_8)
	{
	}

	private void r(StreamWriter A_0, string A_1, string A_2, string A_3, bool A_4, bool A_5, bool A_6)
	{
		r(A_0, j, c0(), c2(), A_1, A_2, A_3, A_4, A_5, A_6);
	}

	private double r(double A_0, bool A_1)
	{
		double num = Math.Pow(10.0, Math.Floor(Math.Log10(A_0)));
		double num2 = A_0 / num;
		if (A_1)
		{
			if (num2 > 5.0)
			{
				return 5.0 * num;
			}
			if (num2 > 2.0)
			{
				return 2.0 * num;
			}
			if (num2 > 1.0)
			{
				return num;
			}
			return 0.5 * num;
		}
		if (num2 > 5.0)
		{
			return 10.0 * num;
		}
		if (num2 > 2.0)
		{
			return 5.0 * num;
		}
		if (num2 > 1.0)
		{
			return 2.0 * num;
		}
		return num;
	}

	private void r(bool A_0, double[] A_1, int A_2, double A_3, double A_4, double A_5, ref double[] A_6)
	{
		checked
		{
			int num = A_2 - 1;
			double[] array = new double[3];
			double num2 = 1.0 / A_5;
			int num3 = 0;
			do
			{
				array[num3] = double.MaxValue;
				num3++;
			}
			while (num3 <= 2);
			int num4 = num;
			for (int num5 = 1; num5 <= num4; num5++)
			{
				double num6 = A_1[num5] - A_1[num5 - 1];
				int num7 = 0;
				do
				{
					if (num6 < array[num7])
					{
						int num8 = num7;
						for (int num9 = 1; num9 >= num8; num9 += -1)
						{
							array[num9 + 1] = array[num9];
						}
						array[num7] = num6;
						break;
					}
					num7++;
				}
				while (num7 <= 2);
			}
			double a_ = double.MaxValue;
			int num10 = 2;
			do
			{
				if (array[num10] < double.MaxValue)
				{
					a_ = array[num10];
					break;
				}
				num10 += -1;
			}
			while (num10 >= 0);
			double num11 = r(a_, A_0);
			int num12 = (int)Math.Round(Math.Ceiling((A_1[num] - A_1[0]) / num11));
			A_6 = new double[num12 + 1];
			int num13 = 0;
			bool flag = A_3 > 0.0;
			bool flag2 = A_4 > 0.0;
			double num14 = Conversion.Int(A_1[0] * A_5 + 0.5) * num2;
			double num15 = Conversion.Int(A_1[num] * A_5 + 0.5) * num2;
			double num16 = Conversion.Int(A_3 * A_5 + 0.5) * num2;
			double num17 = Conversion.Int(A_4 * A_5 + 0.5) * num2;
			if (flag || flag2)
			{
				if (flag && flag2)
				{
					double num18 = Math.Floor(A_1[0]);
					double num19 = Math.Ceiling(A_1[num]);
					double num20 = num11;
					bool flag3 = num20 >= 0.0;
					for (double num21 = num18; flag3 ? (num21 <= num19) : (num21 >= num19); num21 += num20)
					{
						double num22 = Conversion.Int(num21 * A_5 + 0.5) * num2;
						if (num22 >= num14 && num22 >= num16 && num22 <= num15 && num22 <= num17)
						{
							A_6[num13] = num22;
							num13++;
						}
					}
				}
				else if (flag)
				{
					double num23 = Math.Floor(A_1[0]);
					double num24 = Math.Ceiling(A_1[num]);
					double num25 = num11;
					bool flag4 = num25 >= 0.0;
					for (double num21 = num23; flag4 ? (num21 <= num24) : (num21 >= num24); num21 += num25)
					{
						double num22 = Conversion.Int(num21 * A_5 + 0.5) * num2;
						if (num22 >= num14 && num22 >= num16 && num22 <= num15)
						{
							A_6[num13] = num22;
							num13++;
						}
					}
				}
				else
				{
					double num26 = Math.Floor(A_1[0]);
					double num27 = Math.Ceiling(A_1[num]);
					double num28 = num11;
					bool flag5 = num28 >= 0.0;
					for (double num21 = num26; flag5 ? (num21 <= num27) : (num21 >= num27); num21 += num28)
					{
						double num22 = Conversion.Int(num21 * A_5 + 0.5) * num2;
						if (num22 >= num14 && num22 <= num15 && num22 <= num17)
						{
							A_6[num13] = num22;
							num13++;
						}
					}
				}
			}
			else
			{
				double num29 = Math.Floor(A_1[0]);
				double num30 = Math.Ceiling(A_1[num]);
				double num31 = num11;
				bool flag6 = num31 >= 0.0;
				for (double num21 = num29; flag6 ? (num21 <= num30) : (num21 >= num30); num21 += num31)
				{
					double num22 = Conversion.Int(num21 * A_5 + 0.5) * num2;
					if (num22 >= num14 && num22 <= num15)
					{
						A_6[num13] = num22;
						num13++;
					}
				}
			}
			A_6 = (double[])Utils.CopyArray(A_6, new double[num13 - 1 + 1]);
		}
	}

	protected virtual bool ap(string A_0)
	{
		return true;
	}

	protected virtual CultureInfo aq(string A_0)
	{
		return CultureInfo.CurrentCulture;
	}

	protected virtual void @as(StreamWriter A_0, string A_1, double[] A_2, double[] A_3, int A_4, string A_5, string A_6, bool A_7, CultureInfo A_8)
	{
		double num = 1.0 / this.@as;
		double num2 = 1.0 / this.at;
		A_0.WriteLine("\"" + A_5 + "\"" + v + "\"" + A_6 + "\"");
		checked
		{
			if (A_7 && this.aq)
			{
				int num3 = A_4 - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					A_0.WriteLine(b3.a(Conversion.Int(A_2[num4] * this.@as + 0.5) * num, A_8) + v + b3.a(100.0 * Conversion.Int(A_3[num4] * this.at + 0.5) * num2, A_8));
				}
			}
			else
			{
				int num5 = A_4 - 1;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					A_0.WriteLine(b3.a(Conversion.Int(A_2[num6] * this.@as + 0.5) * num, A_8) + v + b3.a(Conversion.Int(A_3[num6] * this.at + 0.5) * num2, A_8));
				}
			}
		}
	}

	protected void r(StreamWriter A_0, double[] A_1, double[] A_2, int A_3, string A_4, string A_5, string A_6, bool A_7, bool A_8, bool A_9)
	{
		CultureInfo A_10 = aq(A_6);
		checked
		{
			int num = A_3 - 1;
			double[] A_11 = null;
			double[] array = null;
			int num2;
			if (A_8 && ap(A_6))
			{
				r(A_9, A_1, A_3, this.au, this.av, this.@as, ref A_11);
				if (A_11.Length > 1)
				{
					num2 = A_11.Length;
					array = new double[num2 - 1 + 1];
					double[] A_12 = new double[num + 1];
					double a_ = (A_2[1] - A_2[0]) / (A_1[1] - A_1[0]);
					double a_2 = (A_2[num] - A_2[num - 1]) / (A_1[num] - A_1[num - 1]);
					jf.a(A_1, A_2, A_3, a_, a_2, ref A_12);
					jf.a(A_1, A_2, A_12, A_3, A_4: false, A_11, ref array, num2, A_8: true);
				}
				else
				{
					A_11 = A_1;
					array = A_2;
					num2 = A_3;
				}
			}
			else
			{
				A_11 = A_1;
				array = A_2;
				num2 = A_3;
			}
			ar(ref A_0, A_11, array, num2, A_4, ref A_5, A_6, A_7, ref A_10);
			@as(A_0, A_6, A_11, array, num2, A_4, A_5, A_7, A_10);
		}
	}

	protected void t(BinaryWriter A_0, bool A_1)
	{
		double[] array = c0();
		checked
		{
			int num = c2() - 1;
			A_0.Write(c2());
			if (A_1)
			{
				if (this.ar)
				{
					double num2 = ((j[0] != 0.0) ? (1.0 / j[0]) : 1.0);
					double num3 = ((array[0] != 0.0) ? (1.0 / array[0]) : 1.0);
					A_0.Write((float)j[0]);
					A_0.Write((float)array[0]);
					int num4 = num;
					for (int num5 = 1; num5 <= num4; num5++)
					{
						A_0.Write((float)(j[num5] * num2));
						A_0.Write((float)(array[num5] * num3));
					}
				}
				else
				{
					int num6 = num;
					for (int num7 = 0; num7 <= num6; num7++)
					{
						A_0.Write((float)j[num7]);
						A_0.Write((float)array[num7]);
					}
				}
			}
			else
			{
				int num8 = num;
				for (int num9 = 0; num9 <= num8; num9++)
				{
					A_0.Write(j[num9]);
					A_0.Write(array[num9]);
				}
			}
		}
	}

	protected void r(double[] A_0, int A_1, BinaryWriter A_2, bool A_3)
	{
		checked
		{
			int num = A_1 - 1;
			A_2.Write(A_1);
			if (A_3)
			{
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					A_2.Write((float)A_0[num3]);
				}
			}
			else
			{
				int num4 = num;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					A_2.Write(A_0[num5]);
				}
			}
		}
	}

	protected void r(BinaryReader A_0, bool A_1, bool A_2, ref double[] A_3)
	{
		checked
		{
			int num = A_0.ReadInt32() - 1;
			if (num >= 0)
			{
				j = new double[num + 1];
				A_3 = new double[num + 1];
				if (A_1)
				{
					if (this.ar && A_2)
					{
						j[0] = A_0.ReadSingle();
						A_3[0] = A_0.ReadSingle();
						double num2 = ((j[0] != 0.0) ? j[0] : 1.0);
						double num3 = ((A_3[0] != 0.0) ? A_3[0] : 1.0);
						int num4 = num;
						for (int num5 = 1; num5 <= num4; num5++)
						{
							j[num5] = (double)A_0.ReadSingle() * num2;
							A_3[num5] = (double)A_0.ReadSingle() * num3;
						}
					}
					else
					{
						int num6 = num;
						for (int num5 = 0; num5 <= num6; num5++)
						{
							j[num5] = A_0.ReadSingle();
							A_3[num5] = A_0.ReadSingle();
						}
					}
				}
				else
				{
					int num7 = num;
					for (int num5 = 0; num5 <= num7; num5++)
					{
						j[num5] = A_0.ReadDouble();
						A_3[num5] = A_0.ReadDouble();
					}
				}
			}
			af(A_3);
		}
	}

	protected void r(ref double[] A_0, ref int A_1, BinaryReader A_2, bool A_3)
	{
		A_1 = A_2.ReadInt32();
		checked
		{
			int num = A_1 - 1;
			if (num >= 0)
			{
				A_0 = new double[num + 1];
				if (A_3)
				{
					int num2 = num;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						A_0[num3] = A_2.ReadSingle();
					}
				}
				else
				{
					int num4 = num;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						A_0[num5] = A_2.ReadDouble();
					}
				}
			}
			else
			{
				A_0 = null;
			}
		}
	}

	[SpecialName]
	protected virtual int aj()
	{
		return 1;
	}

	[SpecialName]
	protected virtual int ak()
	{
		return 1;
	}

	protected virtual fy a1()
	{
		return new fy();
	}

	public void cx()
	{
		if (u == null)
		{
			u = new Collection<fy>();
		}
		else
		{
			u.Clear();
		}
	}

	public void r(fy A_0)
	{
		if (u == null)
		{
			u = new Collection<fy>();
		}
		u.Add(A_0);
	}

	public void r(fy A_0, int A_1)
	{
		u[A_1] = A_0;
	}

	public virtual void ag(ref string A_0, string A_1)
	{
		BinaryReader A_2 = null;
		checked
		{
			try
			{
				A_2 = new BinaryReader(File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read));
				int num = A_2.ReadInt32();
				int num2 = A_2.ReadInt32();
				if (num2 > aj())
				{
					throw new au("Newer software version required in order to read this file. CompatibleVersion=" + b3.a(num2) + ", MaxUnderstoodFileVersion=" + b3.a(aj()));
				}
				ax(ref A_2, num);
				r(A_2, A_1: false, A_2: false, ref this.m);
				if (az(num))
				{
					if (A_2.ReadBoolean())
					{
						if (this.t == null)
						{
							this.t = a1();
						}
						this.t.a4(ref A_2, num, A_2: false);
					}
					if (a0(num))
					{
						int num3 = A_2.ReadInt32();
						if (num3 > 0)
						{
							cx();
							int num4 = num3 - 1;
							for (int num5 = 0; num5 <= num4; num5++)
							{
								fy fy2 = a1();
								fy2.a4(ref A_2, num, A_2: false);
								if (A_2.ReadBoolean() && fy2.t == null)
								{
									fy2.t = a1();
									fy2.t.a4(ref A_2, num, A_2: false);
								}
								r(fy2);
							}
						}
						else
						{
							u = null;
						}
					}
				}
				ay();
			}
			finally
			{
				A_2?.Close();
				this.m = null;
			}
		}
	}

	public virtual void l(ref BinaryReader A_0)
	{
		long offset = A_0.ReadInt64();
		int num = A_0.ReadInt32();
		int num2 = A_0.ReadInt32();
		checked
		{
			if (num2 <= 4)
			{
				bool flag = num == 2;
				if (num2 >= 3)
				{
					flag = A_0.ReadBoolean();
				}
				BinaryReader a_ = A_0;
				bool a_2 = flag;
				double[] A_1 = null;
				r(a_, A_1: true, a_2, ref A_1);
				if (az(num))
				{
					if (A_0.ReadBoolean())
					{
						if (this.t == null)
						{
							this.t = a1();
						}
						this.t.a4(ref A_0, num, A_2: true);
					}
					if (a0(num))
					{
						int num3 = A_0.ReadInt32();
						if (num3 > 0)
						{
							cx();
							int num4 = num3 - 1;
							for (int num5 = 0; num5 <= num4; num5++)
							{
								fy fy2 = a1();
								fy2.a4(ref A_0, num, A_2: true);
								if (A_0.ReadBoolean() && fy2.t == null)
								{
									fy2.t = a1();
									fy2.t.a4(ref A_0, num, A_2: true);
								}
								r(fy2);
							}
						}
						else
						{
							u = null;
						}
					}
				}
				A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
				return;
			}
			throw new au("DataXY maximum compatible block file version is " + b3.a(4) + " compatible version in file we are attempting to read is " + b3.a(num2));
		}
	}

	public virtual void m(ref BinaryWriter A_0)
	{
		long position = A_0.BaseStream.Position;
		int value = 3;
		A_0.Write(position);
		A_0.Write(4);
		A_0.Write(value);
		A_0.Write(this.ar);
		t(A_0, A_1: true);
		bool flag = this.t != null;
		A_0.Write(flag);
		if (flag)
		{
			this.t.av(ref A_0, aj(), A_2: true);
		}
		checked
		{
			if (u != null && u.Count > 0)
			{
				A_0.Write(u.Count);
				int num = u.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					u[num2].av(ref A_0, aj(), A_2: true);
					if (u[num2].t != null)
					{
						u[num2].t.av(ref A_0, aj(), A_2: true);
					}
				}
			}
			else
			{
				A_0.Write(0);
			}
			long position2 = A_0.BaseStream.Position;
			A_0.BaseStream.Seek(position, SeekOrigin.Begin);
			A_0.Write(position2);
			A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
		}
	}

	protected virtual void ax(ref BinaryReader A_0, int A_1)
	{
	}

	protected virtual void ay()
	{
	}

	protected virtual bool az(int A_0)
	{
		return A_0 >= 3;
	}

	protected virtual bool a0(int A_0)
	{
		return A_0 >= 4;
	}

	public void r(ref string A_0)
	{
		StreamReader A_1 = null;
		bool flag = false;
		bool A_2 = false;
		double[] array = null;
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		checked
		{
			try
			{
				A_1 = new StreamReader(File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read));
				a2(ref A_1, this.am, ref A_2, invariantCulture);
				int num = 0;
				j = new double[256];
				array = new double[256];
				while (!A_1.EndOfStream & !flag)
				{
					if (num > j.GetUpperBound(0))
					{
						ref double[] reference = ref j;
						reference = (double[])Utils.CopyArray(reference, new double[num - 1 + 128 + 1]);
						array = (double[])Utils.CopyArray(array, new double[num - 1 + 128 + 1]);
					}
					string text = A_1.ReadLine();
					if (text.Split('\t').Length >= 4)
					{
						if (!double.TryParse(text.Split('\t')[1], NumberStyles.Float, invariantCulture, out j[num]))
						{
							flag = true;
						}
						else if (!double.TryParse(text.Split('\t')[3], NumberStyles.Float, invariantCulture, out array[num]))
						{
							flag = true;
						}
						else
						{
							num++;
						}
					}
				}
				if (num > 0)
				{
					ref double[] reference2 = ref j;
					reference2 = (double[])Utils.CopyArray(reference2, new double[num - 1 + 1]);
					array = (double[])Utils.CopyArray(array, new double[num - 1 + 1]);
				}
				af(array);
			}
			finally
			{
				A_1?.Close();
			}
		}
	}

	public virtual void r(ref string A_0, CultureInfo A_1)
	{
		StreamReader A_2 = null;
		bool flag = false;
		bool A_3 = false;
		double[] array = null;
		checked
		{
			try
			{
				am(A_0);
				A_2 = new StreamReader(File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read));
				a2(ref A_2, this.am, ref A_3, A_1);
				int num = 0;
				j = new double[256];
				array = new double[256];
				while (!A_2.EndOfStream & !flag)
				{
					if (num > j.GetUpperBound(0))
					{
						ref double[] reference = ref j;
						reference = (double[])Utils.CopyArray(reference, new double[num - 1 + 128 + 1]);
						array = (double[])Utils.CopyArray(array, new double[num - 1 + 128 + 1]);
					}
					string text = A_2.ReadLine();
					int num2 = text.IndexOf(w);
					if (num2 > 0)
					{
						if (!double.TryParse(text.Substring(0, num2), NumberStyles.Float, A_1, out j[num]))
						{
							flag = true;
						}
						else if (!double.TryParse(text.Substring(num2 + 1), NumberStyles.Float, A_1, out array[num]))
						{
							flag = true;
						}
						else
						{
							num++;
						}
					}
				}
				if (num > 0)
				{
					ref double[] reference2 = ref j;
					reference2 = (double[])Utils.CopyArray(reference2, new double[num - 1 + 1]);
					array = (double[])Utils.CopyArray(array, new double[num - 1 + 1]);
				}
				if (A_3)
				{
					int num3 = num - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						array[num4] /= 100.0;
					}
				}
				a3(array);
				int num5 = num - 1;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					j[num6] = (float)j[num6];
					array[num6] = (float)array[num6];
				}
				af(array);
			}
			finally
			{
				A_2?.Close();
			}
		}
	}

	protected virtual void a2(ref StreamReader A_0, bool A_1, ref bool A_2, CultureInfo A_3)
	{
	}

	protected virtual void a3(double[] A_0)
	{
	}

	protected virtual fy an()
	{
		return this;
	}

	protected virtual void al(string A_0)
	{
		this.ao = A_0;
		this.ap = Path.GetFileNameWithoutExtension(A_0) + "2" + Path.GetExtension(A_0).ToLower();
		cy();
		bool flag = default(bool);
		if (string.IsNullOrEmpty(A_0))
		{
			string empty = string.Empty;
			this.am = false;
		}
		else
		{
			string empty = Path.GetExtension(A_0).ToLower();
			flag = Operators.CompareString(empty, ".csv", TextCompare: false) == 0;
			this.am = flag || Operators.CompareString(empty, ".txt", TextCompare: false) == 0;
		}
		if (this.am)
		{
			v = Conversions.ToString(i3.h(A_0));
			if (flag)
			{
				v += " ";
			}
			this.aq = false;
		}
	}

	protected void cy()
	{
		this.@as = 100.0;
		this.at = 1000000.0;
	}

	protected virtual void am(string A_0)
	{
	}

	public virtual void k(ref string A_0, string A_1, string A_2)
	{
		r(ref A_0, A_1, A_2, string.Empty, null, null, A_6: false, A_7: false, A_8: false);
	}

	public virtual void r(ref string A_0, string A_1, string A_2, string A_3, Collection<string> A_4, Collection<string> A_5, bool A_6, bool A_7, bool A_8)
	{
		fy fy2 = an();
		fy2.al(A_0);
		if (fy2.t != null)
		{
			fy2.t.al(fy2.ap);
		}
		checked
		{
			if (fy2.u != null && fy2.u.Count > 0)
			{
				int num = fy2.u.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					fy2.u[num2].al(A_0);
					if (fy2.u[num2].t != null)
					{
						fy2.u[num2].t.al(fy2.ap);
					}
				}
			}
			fy2.ao(A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8);
			fy2 = null;
		}
	}

	protected virtual void ao(string A_0, string A_1, string A_2, Collection<string> A_3, Collection<string> A_4, bool A_5, bool A_6, bool A_7)
	{
		checked
		{
			if (this.am)
			{
				StreamWriter streamWriter = null;
				try
				{
					streamWriter = new StreamWriter(File.Open(this.ao, FileMode.Create));
					r(streamWriter, A_0, A_1, Path.GetExtension(this.ao).ToLower(), A_5, A_6, A_7);
				}
				finally
				{
					streamWriter.Close();
				}
				if (this.t != null)
				{
					try
					{
						streamWriter = new StreamWriter(File.Open(this.ap, FileMode.Create));
						this.t.r(streamWriter, A_0, A_2, Path.GetExtension(this.ap).ToLower(), A_5, A_6, A_7);
					}
					finally
					{
						streamWriter.Close();
					}
				}
				if (u == null || u.Count <= 0)
				{
					return;
				}
				string empty = string.Empty;
				string empty2 = string.Empty;
				int num = u.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					try
					{
						empty = Path.GetDirectoryName(this.ao) + "\\" + Path.GetFileNameWithoutExtension(this.ao) + b3.a(num2 + 1) + Path.GetExtension(this.ao);
						streamWriter = new StreamWriter(File.Open(empty, FileMode.Create));
						u[num2].r(streamWriter, A_0, A_3[num2], Path.GetExtension(empty).ToLower(), A_5, A_6, A_7);
					}
					finally
					{
						streamWriter.Close();
					}
					if (u[num2].t != null)
					{
						try
						{
							empty2 = Path.GetDirectoryName(this.ao) + "\\" + Path.GetFileNameWithoutExtension(this.ap) + b3.a(num2 + 1) + Path.GetExtension(this.ap);
							streamWriter = new StreamWriter(File.Open(this.ap, FileMode.Create));
							u[num2].t.r(streamWriter, A_0, A_4[num2], Path.GetExtension(empty2).ToLower(), A_5, A_6, A_7);
						}
						finally
						{
							streamWriter.Close();
						}
					}
				}
				return;
			}
			BinaryWriter A_8 = null;
			try
			{
				A_8 = new BinaryWriter(File.Open(this.ao, FileMode.Create));
				A_8.Write(aj());
				A_8.Write(ai(aj()));
				at(ref A_8, aj());
				t(A_8, A_1: false);
				if (this.t != null)
				{
					A_8.Write(value: true);
					this.t.av(ref A_8, aj(), A_2: false);
				}
				else
				{
					A_8.Write(value: false);
				}
				if (u != null && u.Count > 0)
				{
					A_8.Write(u.Count);
					int num3 = u.Count - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						u[num4].av(ref A_8, aj(), A_2: false);
						if (u[num4].t != null)
						{
							A_8.Write(value: true);
							u[num4].t.av(ref A_8, aj(), A_2: false);
						}
						else
						{
							A_8.Write(value: false);
						}
					}
				}
				else
				{
					A_8.Write(0);
				}
				A_8?.Close();
			}
			finally
			{
				A_8?.Close();
			}
		}
	}

	protected virtual void at(ref BinaryWriter A_0, int A_1)
	{
	}

	protected virtual void au(ref StreamWriter A_0, int A_1)
	{
	}

	protected void r(ref StreamWriter A_0)
	{
		aw(ref A_0, j, c0(), c2());
	}

	protected virtual void aw(ref StreamWriter A_0, double[] A_1, double[] A_2, int A_3)
	{
	}

	public void af(double[] A_0, double[] A_1, int A_2)
	{
		ref double[] a_ = ref j;
		double[] A_3 = c0();
		jf.a(ref a_, ref A_3, c2(), ref A_0, ref A_1, A_2);
		af(A_3);
	}

	[SpecialName]
	public double[] cz()
	{
		return j;
	}

	[SpecialName]
	public void t(double[] A_0)
	{
		j = A_0;
	}

	[SpecialName]
	public double[] c0()
	{
		if (this.m_l == null)
		{
			this.m_l = n.b5(this.m_k);
		}
		return this.m_l;
	}

	[SpecialName]
	public void af(double[] A_0)
	{
		this.m_k = n.b4(A_0);
		this.m_l = null;
	}

	[SpecialName]
	public a6 c1()
	{
		return n;
	}

	[SpecialName]
	public void r(a6 A_0)
	{
		n = A_0;
	}

	[SpecialName]
	public int c2()
	{
		return j.Length;
	}

	[SpecialName]
	public fy c3()
	{
		return this.t;
	}

	[SpecialName]
	public void t(fy A_0)
	{
		this.t = A_0;
	}

	[SpecialName]
	public Collection<fy> c4()
	{
		return u;
	}

	public fy()
		: this(new double[1], new double[1])
	{
	}

	public fy(double[] A_0, double[] A_1)
	{
		o = new a6();
		v = ", ";
		w = ",";
		this.am = true;
		this.aq = false;
		this.ar = false;
		n = o;
		j = A_0;
		af(A_1);
	}
}
