using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class hd
{
	public enum a
	{
		a = 0,
		b = 1,
		c = 2,
		d = 3,
		e = 4,
		f = 5,
		g = 6,
		h = 7,
		i = 8,
		j = 9,
		k = 10,
		l = 14,
		m = 18,
		n = 19,
		o = 20,
		p = 21,
		q = 22,
		r = 23,
		s = 24,
		t = 25,
		u = 26,
		v = 27,
		w = 28
	}

	public const int a = 40;

	public const int b = 40;

	public const int c = 80;

	public const string d = "Poly Silicon";

	public const string e = "Polysilicon";

	private int f;

	private int[] g;

	private string[] h;

	private string[,] m_i;

	private bool[] m_j;

	private int[] m_k;

	public hd()
	{
		g = new int[29];
		h = new string[29];
		this.m_i = new string[29, 41];
		this.m_j = new bool[29];
		this.m_k = new int[29];
		f = 0;
		short num = 1;
		checked
		{
			short A_2 = default(short);
			short A_3 = default(short);
			short A_4 = default(short);
			short A_5 = default(short);
			do
			{
				h[num] = new string(' ', 80);
				short A_ = (short)h[num].Length;
				f6.ReportModelInfo2(num, ref h[num], ref A_, ref A_2, ref A_3, ref A_4, ref A_5);
				this.m_j[num] = A_3 != 0;
				g[num] = A_2;
				this.m_k[num] = A_4;
				h[num] = h[num].Substring(0, A_);
				if (A_5 != 0)
				{
					short num2 = (short)(g[num] - 1);
					for (short num3 = 0; num3 <= num2; num3 = (short)unchecked(num3 + 1))
					{
						this.m_i[num, num3] = new string(' ', 40);
						A_ = (short)this.m_i[num, num3].Length;
						f6.ReportModelParamName(num, num3, ref this.m_i[num, num3], ref A_);
						if (Operators.CompareString(h[num], "Cauchy", TextCompare: false) == 0)
						{
							switch (num3)
							{
							case 1:
								this.m_i[num, num3] = "n B (" + Conversions.ToString(Strings.Chr(181)) + "m^2)";
								break;
							case 2:
								this.m_i[num, num3] = "n C (" + Conversions.ToString(Strings.Chr(181)) + "m^4)";
								break;
							case 4:
								this.m_i[num, num3] = "k B (" + Conversions.ToString(Strings.Chr(181)) + "m^2)";
								break;
							case 5:
								this.m_i[num, num3] = "k C (" + Conversions.ToString(Strings.Chr(181)) + "m^4)";
								break;
							default:
								this.m_i[num, num3] = this.m_i[num, num3].Substring(0, A_);
								break;
							}
						}
						else if (Operators.CompareString(h[num], "Sellmeier", TextCompare: false) == 0 && num3 >= 3)
						{
							this.m_i[num, num3] = "C" + b3.a(num3 - 2) + " (" + Conversions.ToString(Strings.Chr(181)) + "m^2)";
						}
						else
						{
							this.m_i[num, num3] = this.m_i[num, num3].Substring(0, A_);
						}
					}
					f++;
				}
				num = (short)unchecked(num + 1);
			}
			while (f < 28 && A_5 != 0);
		}
	}

	[SpecialName]
	public string i(int A_0, eo A_1, eo.a A_2)
	{
		string text = j(A_0, A_1, A_2);
		if (Operators.CompareString(text, "Poly Silicon", TextCompare: false) == 0)
		{
			text = "Polysilicon";
		}
		return text;
	}

	public string j(string A_0)
	{
		if (Operators.CompareString(A_0, "Polysilicon", TextCompare: false) == 0)
		{
			return "Poly Silicon";
		}
		return A_0;
	}

	[SpecialName]
	public string j(int A_0, eo A_1, eo.a A_2)
	{
		if (k(A_0, A_1, A_2))
		{
			return h[A_0];
		}
		return h[2];
	}

	[SpecialName]
	public int i()
	{
		return f;
	}

	[SpecialName]
	public int j(int A_0)
	{
		return g[A_0];
	}

	[SpecialName]
	public string j(int A_0, int A_1)
	{
		return this.m_i[A_0, A_1];
	}

	public static bool i(int A_0, int A_1)
	{
		if (A_0 == A_1)
		{
			return true;
		}
		if (A_0 == 14)
		{
			return A_1 == 8;
		}
		return false;
	}

	public static bool i(int A_0)
	{
		if (A_0 != 22)
		{
			return A_0 == 25;
		}
		return true;
	}

	[SpecialName]
	public int k(int A_0)
	{
		int num = 1;
		do
		{
			if (A_0 == this.m_k[num])
			{
				return num;
			}
			num = checked(num + 1);
		}
		while (num <= f);
		return 0;
	}

	[SpecialName]
	public bool k(int A_0, eo A_1, eo.a A_2)
	{
		if ((this.m_j[A_0] || A_1.a8()) && (A_0 == 2 || (A_1.ax(A_2) && !A_1.ay(A_2))) && A_0 != 0 && !h[A_0].StartsWith("Obsolete"))
		{
			return true;
		}
		return false;
	}

	[SpecialName]
	public bool i(int A_0, eo A_1, eo.a A_2, bool A_3)
	{
		if (k(A_0, A_1, A_2))
		{
			if (!A_1.a8() && A_3 && A_0 != 2 && A_0 != 27)
			{
				return A_0 == 20;
			}
			return true;
		}
		return false;
	}

	public void i(ComboBox A_0, eo A_1, eo.a A_2, bool A_3, bool A_4 = false)
	{
		int[] array = new int[29];
		string[] array2 = new string[29];
		A_0.Items.Clear();
		int num = 0;
		array[num] = 0;
		array2[num] = "";
		checked
		{
			num++;
			int num2 = f;
			for (num = 1; num <= num2; num++)
			{
				array[num] = num;
				array2[num] = i(num, A_1, A_2);
			}
			int num3 = i();
			for (num = 0; num <= num3; num++)
			{
				int num4 = k(num - 1);
				if (k(num4, A_1, A_2) && i(num4, A_1, A_2, A_4) && (num4 != 21 || A_3))
				{
					A_0.Items.Add(new iz.a(array2[num4], array[num4]));
				}
			}
		}
	}

	public void i(ContextMenuStrip A_0, eo A_1, eo.a A_2, bool A_3, string A_4, bool A_5 = false)
	{
		int[] array = new int[29];
		string[] array2 = new string[29];
		A_0.Items.Clear();
		int num = 0;
		array[num] = 0;
		array2[num] = "";
		checked
		{
			num++;
			int num2 = f;
			for (num = 1; num <= num2; num++)
			{
				array[num] = num;
				array2[num] = i(num, A_1, A_2);
			}
			List<string> list = new List<string>();
			int num3 = i();
			for (num = 0; num <= num3; num++)
			{
				int num4 = k(num - 1);
				if (!k(num4, A_1, A_2) || (!A_1.a8() && num4 != 2 && A_5) || (num4 == 21 && !A_3))
				{
					continue;
				}
				if (this.m_j[num4])
				{
					A_0.Items.Add(array2[num4]);
					if (string.Compare(array2[num4], A_4, ignoreCase: true) == 0)
					{
						((ToolStripMenuItem)A_0.Items[A_0.Items.Count - 1]).Checked = true;
					}
				}
				else
				{
					list.Add(array2[num4]);
				}
			}
			if (list.Count <= 0)
			{
				return;
			}
			A_0.Items.Add("-");
			foreach (string item in list)
			{
				A_0.Items.Add(item);
				if (string.Compare(item, A_4, ignoreCase: true) == 0)
				{
					((ToolStripMenuItem)A_0.Items[A_0.Items.Count - 1]).Checked = true;
				}
			}
		}
	}

	public virtual void i(ref ListBox A_0, eo A_1, eo.a A_2, bool A_3 = false)
	{
		int[] array = new int[29];
		string[] array2 = new string[29];
		int num = 0;
		array[num] = 0;
		array2[num] = "";
		checked
		{
			num++;
			int num2 = f;
			for (num = 1; num <= num2; num++)
			{
				array[num] = num;
				array2[num] = i(num, A_1, A_2);
			}
			int num3 = i();
			for (num = 0; num <= num3; num++)
			{
				int num4 = k(num - 1);
				if (k(num4, A_1, A_2) & (A_1.a8() | (num4 == 2) | !A_3))
				{
					A_0.Items.Add(new iz.a(array2[num4], array[num4]));
				}
			}
		}
	}

	public a i(string A_0, eo A_1, eo.a A_2)
	{
		a a10 = (a)i(A_0);
		if (Operators.CompareString(A_0, "Polysilicon", TextCompare: false) == 0)
		{
			A_0 = "Poly Silicon";
		}
		if ((!this.m_j[(int)a10] && !A_1.a8()) || (A_1.ay(A_2) && a10 != hd.a.c))
		{
			a10 = (a)i("Cauchy");
			if (a10 < hd.a.a)
			{
				a10 = hd.a.c;
			}
		}
		return a10;
	}

	private int i(string A_0)
	{
		int num;
		for (num = 0; (num < f) & (Operators.CompareString(h[num], A_0, TextCompare: false) != 0); num = checked(num + 1))
		{
		}
		if (Operators.CompareString(h[num], A_0, TextCompare: false) == 0)
		{
			return num;
		}
		return -1;
	}
}
