using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class e4
{
	public enum a
	{
		a,
		b,
		c
	}

	public enum b
	{
		a,
		b
	}

	public enum c
	{
		a,
		b,
		c
	}

	public const string a = "Template";

	public const string b = "Templates";

	public const string c = ".fmtpe";

	public const string d = ".fmtpa";

	public const string e = ".fmtpm";

	public const string f = "LastTemplate.dat";

	public const string g = "DefaultTemplate";

	public const string h = "Filmetrics Template Files (.fmtpe)|*.fmtpe";

	public const string i = "Filmetrics Template Files (.fmtpa)|*.fmtpa";

	public const string j = "Template Files (.fmtpm)|*.fmtpm";

	public const string k = "\\TemplateImages\\";

	public const short l = -1;

	public const short m = -111;

	public const int n = 100;

	private const short o = 4;

	private const short p = 255;

	private const float q = 7f;

	private Brush r;

	private Brush s;

	private Brush t;

	private const short u = 3;

	private fz v;

	private b w;

	private bool x;

	private short y;

	private string z;

	private string m_aa;

	private float[] m_ab;

	private float[] m_ac;

	private PictureBox m_ad;

	private string m_ae;

	private double m_af;

	private string m_ag;

	private float[,] m_ah;

	private float[] m_ai;

	private bool[] m_aj;

	private short[,] m_ak;

	private short m_al;

	private bool m_am;

	private short m_an;

	private bool m_ao;

	private h4 m_ap;

	private string m_aq;

	private ew.a m_ar;

	private double m_as;

	private bool m_at;

	private short m_au;

	private double[,] m_av;

	private bool[,] m_aw;

	private short m_ax;

	private double[,] m_ay;

	private double[,] az;

	private bool[,] a0;

	private bool a1;

	private string a2;

	private float a3;

	private float a4;

	private float a5;

	private float a6;

	private float a7;

	private float a8;

	private Point[] a9;

	private int ba;

	private int bb;

	[SpecialName]
	private short bc;

	[SpecialName]
	private short bd;

	public static bool a(string A_0, ref string A_1)
	{
		BinaryReader binaryReader = null;
		try
		{
			if (!File.Exists(A_0))
			{
				A_1 = "";
				return false;
			}
			binaryReader = new BinaryReader(File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read));
			short num = binaryReader.ReadInt16();
			if (binaryReader.ReadInt16() > num)
			{
				return false;
			}
			string text = binaryReader.ReadString();
			text = binaryReader.ReadString();
			binaryReader.ReadDouble();
			if (!File.Exists(string.Concat(str1: A_1 = binaryReader.ReadString(), str0: hg.bz())))
			{
				return false;
			}
		}
		finally
		{
			binaryReader?.Close();
		}
		return true;
	}

	public void a(Graphics A_0)
	{
		this.m_ag = Guid.NewGuid().ToString();
		this.m_ae = "Unknown";
		this.m_af = DateAndTime.Now.ToOADate();
		this.m_an = 3;
		this.m_ao = false;
		this.m_ax = 0;
		this.m_au = 0;
		this.m_at = false;
		aa(A_0);
		ab(A_0);
		ay();
	}

	[SpecialName]
	public static string aa()
	{
		return i3.m() + "\\Templates";
	}

	[SpecialName]
	public static string b()
	{
		return i3.o() + "\\Templates";
	}

	[SpecialName]
	public string ab()
	{
		return z;
	}

	[SpecialName]
	public void a(string A_0)
	{
		z = A_0;
	}

	[SpecialName]
	public short ac()
	{
		return y;
	}

	[SpecialName]
	public void a(short A_0)
	{
		y = A_0;
	}

	[SpecialName]
	public short ad()
	{
		return this.m_al;
	}

	[SpecialName]
	public void b(short A_0)
	{
		this.m_al = A_0;
	}

	[SpecialName]
	public string ae()
	{
		return this.m_aa;
	}

	[SpecialName]
	public void b(string A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	public string af()
	{
		return this.m_ae;
	}

	[SpecialName]
	public void aa(string A_0)
	{
		this.m_ae = A_0;
	}

	[SpecialName]
	public double ag()
	{
		return this.m_af;
	}

	[SpecialName]
	public void a(double A_0)
	{
		this.m_af = A_0;
	}

	[SpecialName]
	public string ah()
	{
		return this.m_ag;
	}

	[SpecialName]
	public void ab(string A_0)
	{
		this.m_ag = A_0;
	}

	[SpecialName]
	public bool ai()
	{
		return this.m_am;
	}

	[SpecialName]
	public void a(bool A_0)
	{
		this.m_am = A_0;
	}

	[SpecialName]
	public short aj()
	{
		return this.m_an;
	}

	[SpecialName]
	public void aa(short A_0)
	{
		this.m_an = A_0;
	}

	[SpecialName]
	public bool ak()
	{
		return this.m_ao;
	}

	[SpecialName]
	public void b(bool A_0)
	{
		this.m_ao = A_0;
	}

	[SpecialName]
	public bool al()
	{
		return a1;
	}

	[SpecialName]
	public void aa(bool A_0)
	{
		a1 = A_0;
	}

	[SpecialName]
	public string am()
	{
		return a2;
	}

	[SpecialName]
	public void ac(string A_0)
	{
		a2 = A_0;
	}

	[SpecialName]
	public h4 an()
	{
		return this.m_ap;
	}

	[SpecialName]
	public bool ao()
	{
		return this.m_at;
	}

	[SpecialName]
	public void ab(bool A_0)
	{
		this.m_at = A_0;
	}

	[SpecialName]
	public short ap()
	{
		return this.m_au;
	}

	[SpecialName]
	public void ab(short A_0)
	{
		this.m_au = A_0;
	}

	[SpecialName]
	public short aq()
	{
		return this.m_ax;
	}

	[SpecialName]
	public void ac(short A_0)
	{
		this.m_ax = A_0;
	}

	[SpecialName]
	public void a(float A_0)
	{
		a6 = A_0;
	}

	[SpecialName]
	public void b(float A_0)
	{
		a5 = A_0;
	}

	[SpecialName]
	public ew.a ar()
	{
		return this.m_ar;
	}

	[SpecialName]
	public bool @as()
	{
		return x;
	}

	[SpecialName]
	public int at()
	{
		return ba;
	}

	[SpecialName]
	public void a(int A_0)
	{
		ba = A_0;
	}

	[SpecialName]
	public int au()
	{
		return bb;
	}

	[SpecialName]
	public void b(int A_0)
	{
		bb = A_0;
	}

	[SpecialName]
	public string av()
	{
		return this.m_aq;
	}

	[SpecialName]
	public double aw()
	{
		return this.m_as;
	}

	public void a(ref short A_0, ref int A_1, ref int A_2)
	{
		A_1 = a9[A_0].X;
		A_2 = a9[A_0].Y;
	}

	public void b(ref short A_0, ref int A_1, ref int A_2)
	{
		a9[A_0].X = A_1;
		a9[A_0].Y = A_2;
	}

	public void ad(short A_0)
	{
		checked
		{
			this.m_ab = new float[A_0 - 1 + 1];
			this.m_ac = new float[A_0 - 1 + 1];
			if (x)
			{
				af(A_0);
			}
			else
			{
				ae(A_0);
			}
		}
	}

	public void ae(short A_0)
	{
		checked
		{
			this.m_ah = new float[A_0 - 1 + 1, this.m_an - 1 + 1];
			this.m_ak = new short[A_0 - 1 + 1, this.m_an - 1 + 1];
			this.m_ai = new float[A_0 - 1 + 1];
			this.m_aj = new bool[A_0 - 1 + 1];
		}
	}

	public void af(short A_0)
	{
		checked
		{
			this.m_av = new double[A_0 - 1 + 1, this.m_au - 1 + 1];
			this.m_aw = new bool[A_0 - 1 + 1, this.m_au - 1 + 1];
			this.m_ay = new double[A_0 - 1 + 1, this.m_ax - 1 + 1];
			az = new double[A_0 - 1 + 1, this.m_ax - 1 + 1];
			a0 = new bool[A_0 - 1 + 1, this.m_ax - 1 + 1];
		}
	}

	public void a(short A_0, float A_1, float A_2)
	{
		A_1 = this.m_ab[A_0];
		A_2 = this.m_ac[A_0];
	}

	public void b(short A_0, float A_1, float A_2)
	{
		this.m_ab[A_0] = A_1;
		this.m_ac[A_0] = A_2;
	}

	public void a(ref short A_0, ref float[] A_1, short A_2)
	{
		checked
		{
			short num = (short)unchecked(A_2 - 1);
			for (short num2 = 0; num2 <= num; num2 = (short)unchecked(num2 + 1))
			{
				A_1[num2] = this.m_ah[A_0, num2];
			}
		}
	}

	public void a(short A_0, ref float[] A_1, ref short A_2)
	{
		A_2 = y;
		checked
		{
			A_1 = new float[A_2 - 1 + 1];
			short num = (short)unchecked(y - 1);
			short num3 = default(short);
			for (short num2 = 0; num2 <= num; num2 = (short)unchecked(num2 + 1))
			{
				if (this.m_ah[num2, A_0] != -1f)
				{
					A_1[num3] = this.m_ah[num2, A_0];
					num3 = (short)unchecked(num3 + 1);
				}
			}
			if (y != num3)
			{
				A_2 = num3;
				if (A_2 > 0)
				{
					A_1 = (float[])Utils.CopyArray(A_1, new float[A_2 - 1 + 1]);
				}
			}
		}
	}

	public float aa(int A_0)
	{
		return this.m_ai[A_0];
	}

	public bool a(float A_0, float A_1, double A_2, ref short A_3)
	{
		return a(A_0: false, A_0, A_1, A_2, ref A_3);
	}

	public bool b(float A_0, float A_1, double A_2, ref short A_3)
	{
		return a(A_0: true, A_0, A_1, A_2, ref A_3);
	}

	public bool a(bool A_0, float A_1, float A_2, double A_3, ref short A_4)
	{
		int try0000_dispatch = -1;
		checked
		{
			int num2 = default(int);
			bool result;
			int num = default(int);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
					{
						float num3 = 3.5f;
						ProjectData.ClearProjectError();
						num2 = 2;
						double num6;
						short num8;
						float num5;
						if (A_0)
						{
							if (y == 0)
							{
								A_4 = 0;
								result = false;
								goto end_IL_0000;
							}
							float num4 = Math.Abs(this.m_ab[0] + num3 - A_1);
							num5 = Math.Abs(this.m_ac[0] + num3 - A_2);
							num6 = Math.Sqrt(num4 * num4 + num5 * num5);
							A_4 = 0;
							if (y > 1)
							{
								short num7 = (short)unchecked(y - 1);
								for (num8 = 1; num8 <= num7; num8 = (short)unchecked(num8 + 1))
								{
									float num9 = Math.Abs(this.m_ab[num8] + num3 - A_1);
									num5 = Math.Abs(this.m_ac[num8] + num3 - A_2);
									double num10 = Math.Sqrt(num9 * num9 + num5 * num5);
									if (num10 < num6)
									{
										num6 = num10;
										A_4 = num8;
									}
								}
							}
							result = ((num6 <= A_3) ? true : false);
							goto end_IL_0000;
						}
						float num11 = Math.Abs((float)a9[0].X - A_1);
						num5 = Math.Abs((float)a9[0].Y - A_2);
						num6 = Math.Sqrt(num11 * num11 + num5 * num5);
						A_4 = 0;
						num8 = 1;
						do
						{
							float num12 = Math.Abs((float)a9[num8].X - A_1);
							num5 = Math.Abs((float)a9[num8].Y - A_2);
							double num10 = Math.Sqrt(num12 * num12 + num5 * num5);
							if (num10 < num6)
							{
								num6 = num10;
								A_4 = num8;
							}
							num8 = (short)unchecked(num8 + 1);
						}
						while (num8 <= 3);
						result = ((num6 <= A_3) ? true : false);
						goto end_IL_0000;
					}
					case 402:
						num = -1;
						switch (num2)
						{
						case 2:
							result = false;
							goto end_IL_0000;
						}
						break;
					}
				}
				catch (object obj) when ((obj is Exception) & (num2 != 0) & (num == 0))
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 402;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0000:
				break;
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public bool a(Graphics A_0, float A_1, float A_2)
	{
		checked
		{
			bool result;
			if (y < 255)
			{
				if (this.m_ab == null)
				{
					this.m_ab = new float[y + 1];
					this.m_ac = new float[y + 1];
				}
				else if (y > this.m_ab.GetUpperBound(0))
				{
					int num = this.m_ab.GetUpperBound(0) + 10;
					ref float[] reference = ref this.m_ab;
					reference = (float[])Utils.CopyArray(reference, new float[num + 1]);
					ref float[] reference2 = ref this.m_ac;
					reference2 = (float[])Utils.CopyArray(reference2, new float[num + 1]);
				}
				this.m_ab[y] = A_1;
				this.m_ac[y] = A_2;
				y = (short)unchecked(y + 1);
				result = true;
			}
			else
			{
				ref fz a_ = ref v;
				Point A_3 = new Point(0, 0);
				fe.b(ref a_, "Cannot add more points to this template.", ref A_3);
				result = false;
			}
			a(A_0, 1f, 1f, e4.c.a);
			return result;
		}
	}

	public void a(Graphics A_0, short A_1)
	{
		checked
		{
			if (y != 0)
			{
				short num = (short)unchecked(y - 2);
				for (short num2 = A_1; num2 <= num; num2 = (short)unchecked(num2 + 1))
				{
					this.m_ab[num2] = this.m_ab[num2 + 1];
					this.m_ac[num2] = this.m_ac[num2 + 1];
				}
				y = (short)unchecked(y - 1);
				a(A_0, 1f, 1f, e4.c.a);
			}
		}
	}

	public void b(Graphics A_0)
	{
		this.m_ab = new float[255];
		this.m_ac = new float[255];
		y = 0;
		a(A_0, 1f, 1f, e4.c.a);
	}

	public void a(hc A_0, bool A_1, bool A_2, eo.a A_3, bool A_4)
	{
		bool flag = false;
		if (A_1)
		{
			if (this.m_al >= y)
			{
				this.m_am = true;
				flag = true;
			}
		}
		else if (this.m_al > y)
		{
			flag = true;
		}
		if (flag)
		{
			return;
		}
		if (this.m_al == 0)
		{
			this.m_ar = A_0.cn().cm();
			this.m_aq = A_0.cn().cl().ToString() + ": " + A_0.cn().cn();
			this.m_as = A_0.cn().cb().ToOADate();
		}
		if ((A_0.ch() == cc.j.a) | (A_0.ch() == cc.j.b))
		{
			a(A_0, A_1, A_3, A_4);
			if (this.m_al == 0)
			{
				this.m_ap = A_0.cy().ca();
			}
		}
		else
		{
			a(A_0, A_1, A_2);
		}
		checked
		{
			if (A_1)
			{
				this.m_al = (short)unchecked(this.m_al + 1);
			}
		}
	}

	public void a(hc A_0, bool A_1, eo.a A_2, bool A_3)
	{
		checked
		{
			float[] array = new float[y + 1];
			hg hg2 = A_0.cy();
			eo.b a_ = hg2.dh().at(A_2, A_3);
			array = A_0.di();
			bool[] array2 = this.m_aj;
			short num = this.m_al;
			int[] A_4 = null;
			array2[num] = hg2.bu(ref array, ref A_4, A_2, A_3);
			hi hi2 = hg2.b3(A_0.cf());
			short num2 = this.m_an;
			for (short num3 = 1; num3 <= num2; num3 = (short)unchecked(num3 + 1))
			{
				if (hi2.eu(num3).af(a_))
				{
					if ((double)A_0.c2() >= A_0.cy().b3(A_0.cf()).gq())
					{
						this.m_ah[this.m_al, num3 - 1] = array[num3];
						if (this.m_aj[this.m_al])
						{
							this.m_ak[this.m_al, num3 - 1] = 2;
						}
						else
						{
							this.m_ak[this.m_al, num3 - 1] = 1;
						}
					}
					else
					{
						this.m_ah[this.m_al, num3 - 1] = -1f;
						this.m_ak[this.m_al, num3 - 1] = 2;
					}
				}
				else
				{
					this.m_ah[this.m_al, num3 - 1] = -111f;
					this.m_ak[this.m_al, num3 - 1] = 0;
				}
			}
			this.m_ai[this.m_al] = A_0.c2();
		}
	}

	public void a(hc A_0, bool A_1, bool A_2)
	{
		hi hi2 = A_0.cy().b3(A_0.cf());
		double num = 1.0;
		this.m_at = A_2;
		if (A_2)
		{
			num = 100.0;
		}
		checked
		{
			int num2 = A_0.cj() - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (hi2.d9(num3))
				{
					this.m_av[this.m_al, num3] = A_0.cq(num3) * num;
					if (A_0.cq(num3) > hi2.d8(num3) || (A_0.cq(num3) < hi2.d7(num3) && hi2.d7(num3) > 0.0))
					{
						this.m_aw[this.m_al, num3] = true;
					}
					else
					{
						this.m_aw[this.m_al, num3] = false;
					}
				}
			}
			int num4 = A_0.cl() - 1;
			for (int num3 = 0; num3 <= num4; num3++)
			{
				if (A_0.cy().b3(A_0.cf()).ei(num3))
				{
					this.m_ay[this.m_al, num3] = A_0.ck()[num3].e();
					az[this.m_al, num3] = A_0.ck()[num3].f();
					if ((double)A_0.ck()[num3].f() > hi2.ef(num3) || ((double)A_0.ck()[num3].f() < hi2.ee(num3) && hi2.ee(num3) > 0.0) || (double)A_0.ck()[num3].e() > hi2.ed(num3) || (double)A_0.ck()[num3].e() < hi2.ec(num3))
					{
						a0[this.m_al, num3] = true;
					}
					else
					{
						a0[this.m_al, num3] = false;
					}
				}
			}
		}
	}

	public void ax()
	{
		checked
		{
			if (this.m_al > 0)
			{
				this.m_al = (short)unchecked(this.m_al - 1);
				bc = this.m_al;
			}
			this.m_am = false;
		}
	}

	public void aa(Graphics A_0)
	{
		checked
		{
			a9[0].X = (int)Math.Round((double)A_0.VisibleClipBounds.Width * 0.25);
			a9[0].Y = (int)Math.Round((double)A_0.VisibleClipBounds.Height * 0.25);
			a9[1].X = (int)Math.Round((double)A_0.VisibleClipBounds.Width * 0.75);
			a9[1].Y = (int)Math.Round((double)A_0.VisibleClipBounds.Height * 0.25);
			a9[2].X = (int)Math.Round((double)A_0.VisibleClipBounds.Width * 0.75);
			a9[2].Y = (int)Math.Round((double)A_0.VisibleClipBounds.Height * 0.75);
			a9[3].X = (int)Math.Round((double)A_0.VisibleClipBounds.Width * 0.25);
			a9[3].Y = (int)Math.Round((double)A_0.VisibleClipBounds.Height * 0.75);
		}
	}

	public void ab(Graphics A_0)
	{
		checked
		{
			int num = (int)Math.Round(A_0.VisibleClipBounds.Width / 2f);
			int num2 = (int)Math.Round(A_0.VisibleClipBounds.Height / 2f);
			y = 2;
			a(A_0, (float)((double)num - (double)num / 4.0), num2);
			a(A_0, (float)((double)num + (double)num / 4.0), num2);
		}
	}

	public void a(Graphics A_0, short A_1, int A_2, int A_3)
	{
		a9[A_1].X = A_2;
		a9[A_1].Y = A_3;
		a(A_0, a3, a4, e4.c.a);
	}

	public void ay()
	{
		this.m_ah = new float[1, 1];
		this.m_ak = new short[1, 1];
		this.m_ai = new float[1];
		this.m_aj = new bool[1];
		this.m_av = new double[1, 1];
		this.m_aw = new bool[1, 1];
		this.m_ay = new double[1, 1];
		az = new double[1, 1];
		a0 = new bool[1, 1];
		y = 0;
		this.m_ai[0] = 0f;
		this.m_aj[0] = false;
		this.m_ah[0, 0] = 0f;
		this.m_ak[0, 0] = 0;
		this.m_av[0, 0] = 0.0;
		this.m_aw[0, 0] = false;
		this.m_ay[0, 0] = 0.0;
		az[0, 0] = 0.0;
		a0[0, 0] = false;
	}

	public void a(Graphics A_0, short A_1, float A_2, float A_3)
	{
		float num = 3.5f;
		this.m_ab[A_1] = A_2 - num;
		this.m_ac[A_1] = A_3 - num;
		a(A_0, a3, a4, e4.c.a);
	}

	public void a(Graphics A_0, float A_1 = 1f, float A_2 = 1f, c A_3 = e4.c.a)
	{
		Image image = null;
		if (a1)
		{
			image = Image.FromFile(a2);
		}
		checked
		{
			if (A_3 != e4.c.c)
			{
				A_0.Clear(SystemColors.Control);
				if (a1)
				{
					A_0.DrawImageUnscaled(image, 0, 0);
				}
				a3 = A_1;
				a4 = A_2;
			}
			else
			{
				if (image != null)
				{
					a5 = (float)((double)(at() - image.Width) / 2.0);
				}
				else
				{
					a5 = 0f;
				}
				if (a5 < 0f)
				{
					a5 = 0f;
				}
				a6 += 50f;
				a3 = 1f;
				a4 = 1f;
				if (a1)
				{
					A_0.DrawImageUnscaled(image, (int)Math.Round(a5), (int)Math.Round(a6));
				}
			}
			if (!a1)
			{
				aa(A_0, A_3);
			}
			if (x)
			{
				a(A_0, A_3);
			}
			else
			{
				b(A_0, A_3);
			}
		}
	}

	private void aa(Graphics A_0, c A_1 = e4.c.a)
	{
		Point[] array = new Point[4];
		float num;
		float num2;
		if (A_1 == e4.c.c)
		{
			num = a5;
			num2 = a6;
		}
		else
		{
			num = a7;
			num2 = a8;
		}
		short num3 = 0;
		checked
		{
			do
			{
				array[num3].X = (int)Math.Round((float)a9[num3].X * a3 + num);
				array[num3].Y = (int)Math.Round((float)a9[num3].Y * a4 + num2);
				num3 = (short)unchecked(num3 + 1);
			}
			while (num3 <= 3);
			A_0.DrawPolygon(Pens.Black, array);
		}
	}

	private void b(Graphics A_0, c A_1 = e4.c.a)
	{
		string text = "";
		string text2 = "";
		Font font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point);
		Font font2 = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point);
		Font font3 = new Font("Microsoft Sans Serif", 8f, FontStyle.Italic, GraphicsUnit.Point);
		Font font4 = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point);
		Font font5 = font;
		short a_ = global::e.a().DisplaySignificantDigits;
		if (y == 0)
		{
			return;
		}
		float num;
		float num2;
		if (A_1 == e4.c.c)
		{
			num = a5;
			num2 = a6;
		}
		else
		{
			num = a7;
			num2 = a8;
		}
		checked
		{
			short num3 = (short)unchecked(y - 1);
			RectangleF rect = default(RectangleF);
			float width = default(float);
			for (short num4 = 0; num4 <= num3; num4 = (short)unchecked(num4 + 1))
			{
				bool flag = false;
				float num5 = 7f;
				float num6 = (float)((double)num5 * 0.5);
				rect.X = (int)Math.Round(this.m_ab[num4] * a3 + num);
				rect.Y = (int)Math.Round(this.m_ac[num4] * a4 + num2);
				rect.Width = (int)Math.Round(num5);
				rect.Height = (int)Math.Round(num5);
				SizeF sizeF;
				if (this.m_al > 0 && num4 < this.m_al)
				{
					Brush brush = ((!this.m_ao) ? r : (this.m_aj[num4] ? t : s));
					A_0.FillEllipse(brush, rect);
					short num7 = (short)unchecked(this.m_an - 1);
					short num8;
					for (num8 = 0; num8 <= num7; num8 = (short)unchecked(num8 + 1))
					{
						if (this.m_ah[num4, num8] != -111f)
						{
							if (this.m_ah[num4, num8] != -1f)
							{
								text = hg.bu(hg.o.a, this.m_ap, this.m_ah[num4, num8], a_, new h4(h4.a.b), 0);
								flag = true;
							}
							num8 = (short)unchecked(num8 + 1);
							break;
						}
					}
					if (!flag)
					{
						font5 = font;
						sizeF = A_0.MeasureString("Invalid", font5);
						rect.X = (float)((double)(this.m_ab[num4] * a3 + num + num6) - (double)sizeF.Width * 0.5);
						rect.Y = this.m_ac[num4] * a4 + num2 + num5 + num6;
						rect.Width = sizeF.Width;
						rect.Height = sizeF.Height;
						A_0.FillRectangle(Brushes.White, rect);
						A_0.DrawString("Invalid", font5, Brushes.Black, rect.X, rect.Y);
					}
					else
					{
						if (this.m_ao)
						{
							if (this.m_ak[num4, num8 - 1] == 1)
							{
								font5 = font2;
							}
							else if (this.m_ak[num4, num8 - 1] == 2)
							{
								font5 = font3;
							}
						}
						else
						{
							font5 = font;
						}
						sizeF = A_0.MeasureString(text, font5);
						width = sizeF.Width;
						rect.X = (float)((double)(this.m_ab[num4] * a3 + num + num6) - (double)sizeF.Width * 0.5);
						rect.Y = this.m_ac[num4] * a4 + num2 + num5 + num6;
						rect.Width = width;
						rect.Height = sizeF.Height;
						A_0.FillRectangle(Brushes.White, rect);
						A_0.DrawString(text, font5, Brushes.Black, rect.X, rect.Y);
					}
					if (flag && this.m_an > 1 && num8 < this.m_an)
					{
						bool flag2 = false;
						short num9 = num8;
						short num10 = (short)unchecked(this.m_an - 1);
						for (num8 = num9; num8 <= num10; num8 = (short)unchecked(num8 + 1))
						{
							if (this.m_ah[num4, num8] != -111f)
							{
								flag2 = true;
								text2 = hg.bu(hg.o.a, this.m_ap, this.m_ah[num4, num8], a_, new h4(h4.a.b), 0);
								num8 = (short)unchecked(num8 + 1);
								break;
							}
						}
						if (flag2)
						{
							if (this.m_ao)
							{
								if (this.m_ak[num4, num8 - 1] == 1)
								{
									font5 = font2;
								}
								else if (this.m_ak[num4, num8 - 1] == 2)
								{
									font5 = font3;
								}
							}
							sizeF = A_0.MeasureString(text2, font5);
							float width2 = sizeF.Width;
							rect.Height = sizeF.Height;
							if (width >= width2)
							{
								rect.Width = width;
							}
							else
							{
								rect.Width = width2;
								rect.X = (float)((double)(this.m_ab[num4] * a3 + num + num6) - (double)rect.Width * 0.5);
								rect.Y = this.m_ac[num4] * a4 + num2 + num5 + num6;
								A_0.FillRectangle(Brushes.White, rect);
								A_0.DrawString(text, font5, Brushes.Black, rect.X, rect.Y);
							}
							rect.X = (float)((double)(this.m_ab[num4] * a3 + num + num6) - (double)rect.Width * 0.5);
							rect.Y = this.m_ac[num4] * a4 + num2 + num5 + num6 + rect.Height;
							A_0.FillRectangle(Brushes.White, rect);
							rect.X = (float)((double)(this.m_ab[num4] * a3 + num + num6) - (double)width2 * 0.5);
							A_0.DrawString(text2, font5, Brushes.Black, rect.X, rect.Y);
						}
					}
				}
				else
				{
					A_0.FillEllipse(r, rect);
				}
				font5 = font4;
				sizeF = A_0.MeasureString(Conversions.ToString(num4 + 1), font5);
				rect.X = (float)((double)(this.m_ab[num4] * a3 + num + num6) - (double)sizeF.Width * 0.5);
				rect.Width = sizeF.Width;
				rect.Y = (float)((double)(this.m_ac[num4] * a4 + num2) - (double)sizeF.Height * 0.85);
				rect.Height = (float)((double)sizeF.Height * 0.85);
				A_0.FillRectangle(Brushes.White, rect);
				rect.Y = (float)((double)(this.m_ac[num4] * a4 + num2 - sizeF.Height) + (double)num6 * 0.5);
				A_0.DrawString(Conversions.ToString(num4 + 1), font5, Brushes.Black, rect.X, rect.Y);
			}
		}
	}

	private void a(Graphics A_0, c A_1 = e4.c.a)
	{
		Font font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point);
		new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point);
		new Font("Microsoft Sans Serif", 8f, FontStyle.Italic, GraphicsUnit.Point);
		Font font2 = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point);
		Font font3 = font;
		short a_ = global::e.a().DisplaySignificantDigits;
		if (y == 0)
		{
			return;
		}
		string text = ((!this.m_at) ? "0.###" : "##.0");
		float num;
		float num2;
		if (A_1 == e4.c.c)
		{
			num = a5;
			num2 = a6;
		}
		else
		{
			num = a7;
			num2 = a8;
		}
		checked
		{
			short num3 = (short)unchecked(y - 1);
			RectangleF rect = default(RectangleF);
			for (short num4 = 0; num4 <= num3; num4 = (short)unchecked(num4 + 1))
			{
				float num5 = 7f;
				float num6 = (float)((double)num5 * 0.5);
				rect.X = (int)Math.Round(this.m_ab[num4] * a3 + num);
				rect.Y = (int)Math.Round(this.m_ac[num4] * a4 + num2);
				rect.Width = (int)Math.Round(num5);
				rect.Height = (int)Math.Round(num5);
				SizeF sizeF;
				if (this.m_al > 0 && num4 < this.m_al)
				{
					bool flag = false;
					string text2 = "R:";
					int num7 = (short)unchecked(this.m_au - 1);
					for (int num8 = 0; num8 <= num7; num8++)
					{
						if (this.m_aw[num4, num8])
						{
							flag = true;
						}
						text2 = text2 + " " + Conversions.ToString(num8 + 1) + ", " + this.m_av[num4, num8].ToString(text);
						if (num8 < (short)unchecked(this.m_au - 1))
						{
							text2 += ";";
						}
					}
					string text3 = "M:";
					int num9 = (short)unchecked(this.m_ax - 1);
					for (int num8 = 0; num8 <= num9; num8++)
					{
						if (a0[num4, num8])
						{
							flag = true;
						}
						text3 = text3 + " " + Conversions.ToString(num8 + 1) + ", " + hg.bu(hg.o.d, new h4(h4.a.b), this.m_ay[num4, num8], a_, new h4(h4.a.b), 0) + "," + az[num4, num8].ToString(text);
						if (num8 < (short)unchecked(this.m_ax - 1))
						{
							text3 += ";";
						}
					}
					Brush brush = ((!flag) ? s : t);
					A_0.FillEllipse(brush, rect);
					font3 = font;
					if (this.m_au > 0 && this.m_ax > 0)
					{
						float width = A_0.MeasureString(text2, font3).Width;
						sizeF = A_0.MeasureString(text3, font3);
						float width2 = sizeF.Width;
						if (width >= width2)
						{
							rect.Width = width;
							sizeF = A_0.MeasureString(text2, font3);
						}
						else
						{
							rect.Width = width2;
						}
						rect.X = (float)((double)(this.m_ab[num4] * a3 + num + num6) - (double)sizeF.Width * 0.5);
						rect.Y = this.m_ac[num4] * a4 + num2 + num5 + num6;
						rect.Height = sizeF.Height;
						A_0.FillRectangle(Brushes.White, rect);
						A_0.DrawString(text2, font3, Brushes.Black, rect.X, rect.Y);
						rect.Y += rect.Height;
						A_0.FillRectangle(Brushes.White, rect);
						A_0.DrawString(text3, font3, Brushes.Black, rect.X, rect.Y);
					}
					else
					{
						string text4 = "";
						if (this.m_au > 0)
						{
							text4 = text2;
						}
						else if (this.m_ax > 0)
						{
							text4 = text3;
						}
						sizeF = A_0.MeasureString(text4, font3);
						rect.X = (float)((double)(this.m_ab[num4] * a3 + num + num6) - (double)sizeF.Width * 0.5);
						rect.Y = this.m_ac[num4] * a4 + num2 + num5 + num6;
						rect.Width = sizeF.Width;
						rect.Height = sizeF.Height;
						A_0.FillRectangle(Brushes.White, rect);
						A_0.DrawString(text4, font3, Brushes.Black, rect.X, rect.Y);
					}
				}
				else
				{
					A_0.FillEllipse(r, rect);
				}
				font3 = font2;
				sizeF = A_0.MeasureString(Conversions.ToString(num4 + 1), font3);
				rect.X = (float)((double)(this.m_ab[num4] * a3 + num + num6) - (double)sizeF.Width * 0.5);
				rect.Width = sizeF.Width;
				rect.Y = (float)((double)(this.m_ac[num4] * a4 + num2) - (double)sizeF.Height * 0.85);
				rect.Height = (float)((double)sizeF.Height * 0.85);
				A_0.FillRectangle(Brushes.White, rect);
				rect.Y = (float)((double)(this.m_ac[num4] * a4 + num2 - sizeF.Height) + (double)num6 * 0.5);
				A_0.DrawString(Conversions.ToString(num4 + 1), font3, Brushes.Black, rect.X, rect.Y);
			}
		}
	}

	public bool a(string A_0, bool A_1, ref float A_2, ref float A_3, ref float A_4, ref float A_5, ref string A_6, ref string A_7, ref double A_8)
	{
		BinaryReader binaryReader = null;
		checked
		{
			bool result;
			try
			{
				if (!File.Exists(A_0))
				{
					result = false;
				}
				else
				{
					binaryReader = new BinaryReader(File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read));
					binaryReader.ReadInt16();
					if (binaryReader.ReadInt16() > 3)
					{
						Interaction.MsgBox("Cannot open choosen file. It is not compatible with current software.", MsgBoxStyle.OkOnly, "Warning");
						binaryReader.Close();
						result = false;
					}
					else
					{
						this.m_ag = binaryReader.ReadString();
						this.m_ae = binaryReader.ReadString();
						this.m_af = binaryReader.ReadDouble();
						this.m_aa = binaryReader.ReadString();
						A_7 = Path.GetFileNameWithoutExtension(this.m_aa);
						this.m_an = binaryReader.ReadInt16();
						this.m_ao = binaryReader.ReadBoolean();
						x = binaryReader.ReadBoolean();
						this.m_at = binaryReader.ReadBoolean();
						this.m_au = binaryReader.ReadInt16();
						this.m_ax = binaryReader.ReadInt16();
						short num = binaryReader.ReadInt16();
						a9 = new Point[num - 1 + 1];
						short num2 = (short)unchecked(num - 1);
						for (short num3 = 0; num3 <= num2; num3 = (short)unchecked(num3 + 1))
						{
							a9[num3].X = binaryReader.ReadInt32();
							a9[num3].Y = binaryReader.ReadInt32();
						}
						y = binaryReader.ReadInt16();
						this.m_ab = new float[y - 1 + 1];
						this.m_ac = new float[y - 1 + 1];
						short num4 = (short)unchecked(y - 1);
						for (short num3 = 0; num3 <= num4; num3 = (short)unchecked(num3 + 1))
						{
							this.m_ab[num3] = binaryReader.ReadSingle();
							this.m_ac[num3] = binaryReader.ReadSingle();
						}
						a1 = binaryReader.ReadBoolean();
						if (a1)
						{
							string text = binaryReader.ReadString();
							if (text.StartsWith("Templates"))
							{
								text = text.Substring("Templates".Length);
							}
							a2 = aa() + text;
						}
						if (A_1)
						{
							unchecked
							{
								this.m_ap.e((h4.a)binaryReader.ReadInt32());
								this.m_ar = (ew.a)binaryReader.ReadByte();
								this.m_aq = binaryReader.ReadString();
								this.m_as = binaryReader.ReadDouble();
							}
							if (x)
							{
								this.m_av = new double[y - 1 + 1, this.m_au - 1 + 1];
								this.m_aw = new bool[y - 1 + 1, this.m_au - 1 + 1];
								this.m_ay = new double[y - 1 + 1, this.m_ax - 1 + 1];
								az = new double[y - 1 + 1, this.m_ax - 1 + 1];
								a0 = new bool[y - 1 + 1, this.m_ax - 1 + 1];
								short num5 = (short)unchecked(y - 1);
								for (short num6 = 0; num6 <= num5; num6 = (short)unchecked(num6 + 1))
								{
									int num7 = (short)unchecked(this.m_au - 1);
									for (int num8 = 0; num8 <= num7; num8++)
									{
										this.m_av[num6, num8] = binaryReader.ReadSingle();
										this.m_aw[num6, num8] = binaryReader.ReadBoolean();
									}
									int num9 = (short)unchecked(this.m_ax - 1);
									for (int num10 = 0; num10 <= num9; num10++)
									{
										this.m_ay[num6, num10] = binaryReader.ReadSingle();
										az[num6, num10] = binaryReader.ReadSingle();
										a0[num6, num10] = binaryReader.ReadBoolean();
									}
								}
							}
							else
							{
								this.m_al = y;
								this.m_ai = new float[y - 1 + 1];
								this.m_aj = new bool[y - 1 + 1];
								this.m_ah = new float[y - 1 + 1, this.m_an - 1 + 1];
								this.m_ak = new short[y - 1 + 1, this.m_an - 1 + 1];
								short num11 = (short)unchecked(y - 1);
								for (short num6 = 0; num6 <= num11; num6 = (short)unchecked(num6 + 1))
								{
									this.m_ai[num6] = binaryReader.ReadSingle();
									this.m_aj[num6] = binaryReader.ReadBoolean();
									short num12 = (short)(this.m_an - 1);
									for (short num3 = 0; num3 <= num12; num3 = (short)unchecked(num3 + 1))
									{
										this.m_ah[num6, num3] = binaryReader.ReadSingle();
										this.m_ak[num6, num3] = binaryReader.ReadInt16();
									}
								}
							}
							A_2 = binaryReader.ReadSingle();
							A_3 = binaryReader.ReadSingle();
							A_4 = binaryReader.ReadSingle();
							A_5 = binaryReader.ReadSingle();
							A_8 = binaryReader.ReadDouble();
						}
						binaryReader.Close();
						z = A_0;
						result = true;
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				binaryReader.Close();
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public bool a(string A_0, bool A_1, float A_2, float A_3, float A_4, float A_5, double A_6)
	{
		BinaryWriter binaryWriter = null;
		if (File.Exists(A_0))
		{
			global::c.e().FileSystem.DeleteFile(A_0);
		}
		checked
		{
			bool result;
			try
			{
				binaryWriter = new BinaryWriter(File.Open(A_0, FileMode.Create));
				binaryWriter.Write((short)3);
				binaryWriter.Write((short)3);
				binaryWriter.Write(this.m_ag);
				binaryWriter.Write(this.m_ae);
				binaryWriter.Write(this.m_af);
				binaryWriter.Write(this.m_aa);
				binaryWriter.Write(this.m_an);
				binaryWriter.Write(this.m_ao);
				binaryWriter.Write(x);
				binaryWriter.Write(this.m_at);
				binaryWriter.Write(this.m_au);
				binaryWriter.Write(this.m_ax);
				binaryWriter.Write((short)4);
				short num = 0;
				do
				{
					binaryWriter.Write(a9[num].X);
					binaryWriter.Write(a9[num].Y);
					num = (short)unchecked(num + 1);
				}
				while (num <= 3);
				binaryWriter.Write(y);
				short num2 = (short)unchecked(y - 1);
				for (num = 0; num <= num2; num = (short)unchecked(num + 1))
				{
					binaryWriter.Write(this.m_ab[num]);
					binaryWriter.Write(this.m_ac[num]);
				}
				binaryWriter.Write(a1);
				if (a1)
				{
					string fileName = Path.GetFileName(a2);
					if (!Directory.Exists(aa() + "\\TemplateImages\\"))
					{
						Directory.CreateDirectory(aa() + "\\TemplateImages\\");
					}
					if (!File.Exists(aa() + "\\TemplateImages\\" + fileName))
					{
						FileSystem.FileCopy(a2, aa() + "\\TemplateImages\\" + fileName);
					}
					binaryWriter.Write("\\TemplateImages\\" + fileName);
				}
				if (A_1)
				{
					unchecked
					{
						binaryWriter.Write((int)this.m_ap.e());
						binaryWriter.Write((byte)this.m_ar);
						binaryWriter.Write(this.m_aq);
						binaryWriter.Write(this.m_as);
					}
					if (x)
					{
						short num3 = (short)unchecked(y - 1);
						for (short num4 = 0; num4 <= num3; num4 = (short)unchecked(num4 + 1))
						{
							int num5 = (short)unchecked(this.m_au - 1);
							for (int num6 = 0; num6 <= num5; num6++)
							{
								binaryWriter.Write(this.m_av[num4, num6]);
								binaryWriter.Write(this.m_aw[num4, num6]);
							}
							int num7 = (short)unchecked(this.m_ax - 1);
							for (int num8 = 0; num8 <= num7; num8++)
							{
								binaryWriter.Write(this.m_ay[num4, num8]);
								binaryWriter.Write(az[num4, num8]);
								binaryWriter.Write(a0[num4, num8]);
							}
						}
					}
					else
					{
						short num9 = (short)unchecked(y - 1);
						for (short num4 = 0; num4 <= num9; num4 = (short)unchecked(num4 + 1))
						{
							binaryWriter.Write(this.m_ai[num4]);
							binaryWriter.Write(this.m_aj[num4]);
							short num10 = (short)unchecked(this.m_an - 1);
							for (num = 0; num <= num10; num = (short)unchecked(num + 1))
							{
								binaryWriter.Write(this.m_ah[num4, num]);
								binaryWriter.Write(this.m_ak[num4, num]);
							}
						}
					}
					binaryWriter.Write(A_2);
					binaryWriter.Write(A_3);
					binaryWriter.Write(A_4);
					binaryWriter.Write(A_5);
					binaryWriter.Write(A_6);
				}
				binaryWriter.Close();
				result = true;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				binaryWriter.Close();
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public void ac(Graphics A_0)
	{
		Brush[] array = new Brush[2]
		{
			Brushes.Blue,
			Brushes.White
		};
		checked
		{
			if (this.m_al < y)
			{
				if (bd == 0)
				{
					bd = 1;
				}
				else
				{
					bd = 0;
				}
				RectangleF rect = default(RectangleF);
				rect.X = (int)Math.Round(this.m_ab[this.m_al] * a3 + a7);
				rect.Y = (int)Math.Round(this.m_ac[this.m_al] * a4 + a8);
				rect.Width = 7f;
				rect.Height = 7f;
				A_0.FillEllipse(array[bd], rect);
			}
		}
	}

	public e4(fz A_0, Graphics A_1, b A_2)
	{
		r = Brushes.Blue;
		s = Brushes.Lime;
		t = Brushes.Red;
		this.m_ap = new h4(h4.a.b);
		a9 = new Point[4];
		v = A_0;
		w = A_2;
		a5 = 0f;
		a6 = 0f;
		a7 = 0f;
		a8 = 0f;
		a(A_1);
	}

	public static void a()
	{
		if (!new DirectoryInfo(aa() + "\\").Exists)
		{
			global::c.e().FileSystem.CreateDirectory(aa() + "\\");
		}
	}
}
