using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Filmetrics;
using Microsoft.VisualBasic.CompilerServices;

internal class eo
{
	public class a
	{
		public enum a : byte
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
			k
		}

		public bool a;

		public bool b;

		public bool c;

		public bool d;

		public bool e;

		public bool f;

		public bool g;

		public float h;

		public bool i;

		public bool j;

		public string k;

		public bool l;

		public bool m;

		public bool n;

		public AutoUpdateLicenseDetails.AutoUpdateLevel o;

		public string p;

		public string q;

		public bool r;

		public bool s;

		public bool t;

		public bool u;

		public bool v;

		public bool w;

		public bool x;

		public bool y;

		public bool z;

		public bool aa;

		public bool ab;

		public bool ac;

		public bool ad;

		public bool ae;

		public bool af;

		public bool ag;

		public bool ah;

		public bool ai;

		public bool aj;

		public bool ak;

		public bool al;

		public bool am;

		private string an;

		private dz.a m_ao;

		private const string m_ap = "4X2WJGDVp1rt2GL26p7JzPcI2V5NG1Tm";

		private const string m_aq = "Bctw6o9E70bL1SQ0";

		private const string ar = "4X2WJGDVp1rt2GL26p7JzPcI";

		private const string @as = "Bctw6o9E70bL1SQ0";

		private const int at = 2;

		private const int au = 2;

		[SpecialName]
		public static eo.a ap(eo.a A_0, eo.a A_1)
		{
			if (A_0 == null || A_1 == null)
			{
				return null;
			}
			eo.a a10;
			eo.a result = (a10 = new eo.a());
			a10.a = A_0.a & A_1.a;
			a10.b = A_0.b & A_1.b;
			a10.c = A_0.c & A_1.c;
			a10.d = A_0.d & A_1.d;
			a10.e = A_0.e & A_1.e;
			a10.f = A_0.f & A_1.f;
			a10.ad = A_0.ad & A_1.ad;
			if (A_0.h < A_1.h)
			{
				a10.h = A_0.h;
			}
			else
			{
				a10.h = A_1.h;
			}
			a10.ah = A_0.ah & A_1.ah;
			a10.ae = A_0.ae & A_1.ae;
			a10.ai = A_0.ai & A_1.ai;
			a10.aj = A_0.aj & A_1.aj;
			a10.al = A_0.al & A_1.al;
			a10.am = A_0.am & A_1.am;
			a10 = null;
			return result;
		}

		[SpecialName]
		public static eo.a ao(eo.a A_0, eo.a A_1)
		{
			if (A_0 == null)
			{
				return A_1;
			}
			if (A_1 == null)
			{
				return A_0;
			}
			eo.a a10;
			eo.a result = (a10 = new eo.a());
			a10.a = A_0.a | A_1.a;
			a10.b = A_0.b | A_1.b;
			a10.c = A_0.c | A_1.c;
			a10.d = A_0.d | A_1.d;
			a10.e = A_0.e | A_1.e;
			a10.f = A_0.f | A_1.f;
			a10.ad = A_0.ad | A_1.ad;
			if (!((A_0.h < A_1.h) | (a10.h == A_1.h)))
			{
				a10.h = A_0.h;
			}
			a10.ah = A_0.ah | A_1.ah;
			a10.ae = A_0.ae | A_1.ae;
			a10.ai = A_0.ai | A_1.ai;
			a10.aj = A_0.aj | A_1.aj;
			a10.al = A_0.al | A_1.al;
			a10.am = A_0.am | A_1.am;
			a10 = null;
			return result;
		}

		public static eo.a ao(BinaryReader A_0)
		{
			eo.a a10 = new eo.a();
			i3.a(A_0, a10.ao, "Permissions", 2);
			return a10;
		}

		public bool ap(double[] A_0, double[] A_1, int A_2)
		{
			checked
			{
				bool result;
				try
				{
					ICryptoTransform a_ = null;
					switch (this.m_ao)
					{
					case dz.a.a:
						a_ = new RijndaelManaged().CreateDecryptor(Encoding.ASCII.GetBytes("4X2WJGDVp1rt2GL26p7JzPcI2V5NG1Tm"), Encoding.ASCII.GetBytes("Bctw6o9E70bL1SQ0"));
						break;
					case dz.a.b:
						a_ = new TripleDESCryptoServiceProvider().CreateDecryptor(Encoding.ASCII.GetBytes("4X2WJGDVp1rt2GL26p7JzPcI"), Encoding.ASCII.GetBytes("Bctw6o9E70bL1SQ0"));
						break;
					}
					string text = dz.c(Convert.FromBase64String(an), a_);
					string A_3 = null;
					int A_4 = default(int);
					i3.a(ref A_4, text, ref A_3);
					int num = int.Parse(A_3);
					List<a> list = ao();
					int num2 = num - 1;
					int num3 = 0;
					while (true)
					{
						if (num3 <= num2)
						{
							i3.a(ref A_4, text, ref A_3);
							unchecked
							{
								a item = (a)checked((byte)int.Parse(A_3));
								if (!list.Contains(item))
								{
									result = false;
									break;
								}
								list.Remove(item);
							}
							num3++;
							continue;
						}
						if (list.Count > 0)
						{
							result = false;
							break;
						}
						i3.a(ref A_4, text, ref A_3);
						int num4 = int.Parse(A_3);
						int[] array = new int[num4 - 1 + 1];
						int num5 = num4 - 1;
						for (int num6 = 0; num6 <= num5; num6++)
						{
							i3.a(ref A_4, text, ref A_3);
							array[num6] = int.Parse(A_3);
						}
						result = Operators.CompareString(text, ao(array, A_0, A_1, A_2), TextCompare: false) == 0;
						break;
					}
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
		}

		[SpecialName]
		public bool aq()
		{
			if (!f && !d && !this.a)
			{
				return e;
			}
			return true;
		}

		public void ao(BinaryWriter A_0, double[] A_1, double[] A_2, int A_3)
		{
			an = ao(A_1, A_2, A_3);
			this.m_ao = dz.a.b;
			i3.a(A_0, ao, 2, 2);
		}

		private string ao(double[] A_0, double[] A_1, int A_2)
		{
			Random random = new Random();
			checked
			{
				int num = (int)Math.Round(5.0 + (double)random.Next() / 2147483647.0 * 5.0);
				if (num > A_2)
				{
					num = A_2;
				}
				int[] array = new int[num - 1 + 1];
				int num2 = num - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					array[num3] = (int)Math.Round((double)random.Next() / 2147483647.0 * (double)(A_2 - 1));
				}
				string a_ = ao(array, A_0, A_1, A_2);
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
				ICryptoTransform a_2 = tripleDESCryptoServiceProvider.CreateEncryptor(Encoding.ASCII.GetBytes("4X2WJGDVp1rt2GL26p7JzPcI"), Encoding.ASCII.GetBytes("Bctw6o9E70bL1SQ0"));
				string result = Convert.ToBase64String(dz.a(a_, a_2));
				tripleDESCryptoServiceProvider.Clear();
				return result;
			}
		}

		private string ao(int[] A_0, double[] A_1, double[] A_2, int A_3)
		{
			double num = 0.01;
			double num2 = 0.01;
			string text = null;
			List<a> list = ao();
			text = list.Count.ToString(CultureInfo.InvariantCulture) + ",";
			foreach (a item in list)
			{
				string text2 = text;
				int num3 = (int)item;
				text = text2 + num3 + ",";
			}
			text = text + Conversions.ToString(A_0.Length) + ",";
			checked
			{
				int num3 = A_0.Length - 1;
				double num5 = default(double);
				for (int num4 = 0; num4 <= num3; num4++)
				{
					text = text + A_0[num4].ToString(CultureInfo.InvariantCulture) + ",";
					num5 += Math.Floor(A_1[A_0[num4]] * 100.0 + 0.5) * num + Math.Floor(A_2[A_0[num4]] * 100.0 + 0.5) * num2;
				}
				return text + Math.Round(num5, 4).ToString(CultureInfo.InvariantCulture);
			}
		}

		private static eo.a ap()
		{
			eo.a a10 = new eo.a();
			eo.a a11 = a10;
			foreach (object value in Enum.GetValues(typeof(a)))
			{
				a a_ = (a)Conversions.ToByte(value);
				a11.ao(a_);
			}
			a11 = null;
			return a10;
		}

		private List<a> ao()
		{
			List<a> list;
			List<a> result = (list = new List<a>());
			if (this.a)
			{
				list.Add(eo.a.a.a);
			}
			if (b)
			{
				list.Add(eo.a.a.b);
			}
			if (c)
			{
				list.Add(eo.a.a.c);
			}
			if (d)
			{
				list.Add(eo.a.a.d);
			}
			if (e)
			{
				list.Add(eo.a.a.e);
			}
			if (f)
			{
				list.Add(eo.a.a.f);
			}
			if (ad)
			{
				list.Add(eo.a.a.g);
			}
			if (ah)
			{
				list.Add(eo.a.a.h);
			}
			if (ae)
			{
				list.Add(eo.a.a.i);
			}
			if (ai)
			{
				list.Add(eo.a.a.j);
			}
			if (aj)
			{
				list.Add(eo.a.a.k);
			}
			list = null;
			return result;
		}

		private void ao(BinaryReader A_0, int A_1)
		{
			int num = checked(A_0.ReadInt32() - 1);
			for (int num2 = 0; num2 <= num; num2 = checked(num2 + 1))
			{
				ao((a)A_0.ReadByte());
			}
			h = A_0.ReadSingle();
			an = A_0.ReadString();
			if (A_1 > 1)
			{
				this.m_ao = (dz.a)A_0.ReadInt32();
			}
			else
			{
				this.m_ao = dz.a.a;
			}
		}

		private void ao(a A_0)
		{
			switch (A_0)
			{
			case eo.a.a.g:
				ad = true;
				break;
			case eo.a.a.f:
				f = true;
				break;
			case eo.a.a.a:
				this.a = true;
				break;
			case eo.a.a.c:
				c = true;
				break;
			case eo.a.a.b:
				b = true;
				break;
			case eo.a.a.e:
				e = true;
				break;
			case eo.a.a.d:
				d = true;
				break;
			case eo.a.a.h:
				ah = true;
				break;
			case eo.a.a.i:
				ae = true;
				break;
			case eo.a.a.j:
				ai = true;
				break;
			case eo.a.a.k:
				aj = true;
				break;
			}
		}

		private void ao(BinaryWriter A_0)
		{
			List<a> list = ao();
			A_0.Write(list.Count);
			foreach (a item in list)
			{
				A_0.Write((byte)item);
			}
			A_0.Write(h);
			A_0.Write(an);
			A_0.Write((int)this.m_ao);
		}
	}

	public class b
	{
		private bool a;

		private bool m_b;

		private bool c;

		private bool d;

		public b(eo A_0, a A_1, bool A_2)
		{
			a = A_0.ax(A_1);
			m_b = A_0.az(A_1);
			c = A_0.av(A_1);
			d = A_2;
		}

		public b(bool A_0, bool A_1, bool A_2, bool A_3)
		{
			a = A_2;
			m_b = A_0;
			c = A_1;
			d = A_3;
		}

		[SpecialName]
		public bool e()
		{
			return a;
		}

		[SpecialName]
		public bool f()
		{
			return m_b;
		}

		[SpecialName]
		public bool g()
		{
			return c;
		}

		[SpecialName]
		public bool h()
		{
			return d;
		}
	}

	private a m_a;

	private a m_b;

	private string c;

	private bool d;

	private string e;

	private string f;

	private string g;

	public const float h = 100000000f;

	private a av()
	{
		a obj = new a();
		obj.a = this.m_a.a;
		obj.b = this.m_a.b;
		obj.c = this.m_a.c;
		obj.d = this.m_a.d;
		obj.e = this.m_a.e;
		obj.f = this.m_a.f;
		obj.ad = this.m_a.ad;
		obj.h = this.m_a.h;
		obj.ah = this.m_a.ah;
		obj.ae = this.m_a.ae;
		obj.ai = this.m_a.ai;
		obj.aj = this.m_a.aj;
		_ = null;
		return obj;
	}

	[SpecialName]
	public a aw()
	{
		return this.m_b;
	}

	public void at(a A_0)
	{
		this.m_a = A_0;
		if (!string.IsNullOrEmpty(A_0.q))
		{
			c = A_0.q;
			d = true;
		}
		this.m_b = av();
	}

	public b at(a A_0, bool A_1)
	{
		return new b(this, A_0, A_1);
	}

	public static a at()
	{
		a obj = new a
		{
			a = true
		};
		obj.a = true;
		obj.b = true;
		obj.d = true;
		obj.e = true;
		obj.f = true;
		obj.g = true;
		obj.h = 100000000f;
		obj.i = true;
		obj.l = true;
		obj.m = true;
		obj.n = true;
		obj.o = AutoUpdateLicenseDetails.AutoUpdateLevel.Alpha;
		obj.k = string.Empty;
		obj.p = null;
		obj.q = string.Empty;
		obj.r = false;
		obj.s = true;
		obj.t = true;
		obj.u = true;
		obj.v = true;
		obj.w = true;
		obj.j = false;
		obj.x = false;
		obj.y = false;
		obj.c = false;
		obj.z = false;
		obj.aa = false;
		obj.ab = false;
		obj.ac = true;
		obj.ad = true;
		obj.ae = true;
		obj.af = false;
		obj.ah = false;
		obj.ak = true;
		obj.al = true;
		obj.am = true;
		_ = null;
		return obj;
	}

	public void ax()
	{
		global::a2.a.c(ref c, ref e, ref f, ref g);
	}

	[SpecialName]
	public AutoUpdateLicenseDetails.AutoUpdateLevel ay()
	{
		if (this.m_a != null)
		{
			return this.m_a.o;
		}
		return AutoUpdateLicenseDetails.AutoUpdateLevel.Release;
	}

	[SpecialName]
	public float az()
	{
		if (this.m_a != null)
		{
			return this.m_a.h;
		}
		return 100000000f;
	}

	[SpecialName]
	public bool a0()
	{
		if (this.m_a != null)
		{
			return this.m_a.n;
		}
		return false;
	}

	[SpecialName]
	public bool a1()
	{
		if (this.m_a != null)
		{
			return this.m_a.g;
		}
		return false;
	}

	[SpecialName]
	public bool av(a A_0)
	{
		if (this.m_a == null || !this.m_a.a)
		{
			return A_0?.a ?? false;
		}
		return true;
	}

	[SpecialName]
	public bool aw(a A_0)
	{
		if (av(A_0))
		{
			return !az(A_0);
		}
		return false;
	}

	[SpecialName]
	public bool a2()
	{
		if (this.m_a != null)
		{
			return this.m_a.v;
		}
		return false;
	}

	[SpecialName]
	public bool a3()
	{
		if (this.m_a != null && this.m_a.r)
		{
			return d;
		}
		return false;
	}

	[SpecialName]
	public bool ax(a A_0)
	{
		if (this.m_a == null || !this.m_a.b)
		{
			return A_0?.b ?? false;
		}
		return true;
	}

	[SpecialName]
	public bool ay(a A_0)
	{
		if (this.m_a == null || !this.m_a.c)
		{
			return A_0?.c ?? false;
		}
		return true;
	}

	[SpecialName]
	public bool az(a A_0)
	{
		if (this.m_a == null || !this.m_a.d)
		{
			return A_0?.d ?? false;
		}
		return true;
	}

	[SpecialName]
	public bool a4()
	{
		if (this.m_a != null)
		{
			return this.m_a.z;
		}
		return false;
	}

	[SpecialName]
	public bool a5()
	{
		if (this.m_a != null)
		{
			return this.m_a.af;
		}
		return false;
	}

	[SpecialName]
	public bool a6()
	{
		if (this.m_a != null)
		{
			return this.m_a.aa;
		}
		return false;
	}

	[SpecialName]
	public bool a0(a A_0)
	{
		if (this.m_a == null || !this.m_a.e)
		{
			return A_0?.e ?? false;
		}
		return true;
	}

	[SpecialName]
	public bool a1(a A_0)
	{
		if (this.m_a == null || !this.m_a.aq())
		{
			return A_0?.aq() ?? false;
		}
		return true;
	}

	[SpecialName]
	public bool a7()
	{
		if (this.m_a != null)
		{
			return this.m_a.f;
		}
		return false;
	}

	[SpecialName]
	public bool a8()
	{
		if (this.m_a != null)
		{
			return this.m_a.i;
		}
		return false;
	}

	[SpecialName]
	public string a9()
	{
		if (this.m_a != null)
		{
			return this.m_a.k;
		}
		return string.Empty;
	}

	[SpecialName]
	public string ba()
	{
		return c;
	}

	[SpecialName]
	public string bb()
	{
		if (a8())
		{
			return this.m_a.k;
		}
		if (d)
		{
			return c;
		}
		return string.Empty;
	}

	[SpecialName]
	public bool bc()
	{
		return d;
	}

	[SpecialName]
	public string bd()
	{
		return e;
	}

	[SpecialName]
	public string be()
	{
		return f;
	}

	[SpecialName]
	public string bf()
	{
		return g;
	}

	[SpecialName]
	public string bg()
	{
		if (this.m_a != null)
		{
			return this.m_a.p;
		}
		return string.Empty;
	}

	[SpecialName]
	public bool bh()
	{
		if (this.m_a != null)
		{
			return this.m_a.l;
		}
		return false;
	}

	[SpecialName]
	public bool bi()
	{
		if (this.m_a != null)
		{
			return this.m_a.m;
		}
		return false;
	}

	[SpecialName]
	public bool bj()
	{
		if (this.m_a != null)
		{
			return this.m_a.s;
		}
		return false;
	}

	[SpecialName]
	public bool bk()
	{
		if (this.m_a != null)
		{
			return this.m_a.t;
		}
		return false;
	}

	[SpecialName]
	public bool bl()
	{
		if (this.m_a != null)
		{
			return this.m_a.u;
		}
		return false;
	}

	[SpecialName]
	public bool bm()
	{
		if (this.m_a != null)
		{
			return this.m_a.w;
		}
		return false;
	}

	[SpecialName]
	public bool bn()
	{
		if (this.m_a != null)
		{
			return this.m_a.j;
		}
		return false;
	}

	[SpecialName]
	public bool bo()
	{
		if (this.m_a != null)
		{
			return this.m_a.x;
		}
		return false;
	}

	[SpecialName]
	public bool bp()
	{
		if (this.m_a != null)
		{
			return this.m_a.y;
		}
		return false;
	}

	[SpecialName]
	public bool bq()
	{
		if (this.m_a != null)
		{
			return this.m_a.ab;
		}
		return false;
	}

	[SpecialName]
	public bool br()
	{
		if (this.m_a != null)
		{
			return this.m_a.ac;
		}
		return false;
	}

	[SpecialName]
	public bool a2(a A_0)
	{
		if (this.m_a == null || !this.m_a.ad)
		{
			return A_0?.ad ?? false;
		}
		return true;
	}

	[SpecialName]
	public bool a3(a A_0)
	{
		if (this.m_a == null || !this.m_a.ae)
		{
			return A_0?.ae ?? false;
		}
		return true;
	}

	[SpecialName]
	public bool a4(a A_0)
	{
		if (this.m_a == null || !this.m_a.ai)
		{
			return A_0?.ai ?? false;
		}
		return true;
	}

	[SpecialName]
	public bool a5(a A_0)
	{
		if (this.m_a == null || !this.m_a.aj)
		{
			return A_0?.aj ?? false;
		}
		return true;
	}

	[SpecialName]
	public bool bs()
	{
		if (this.m_a != null)
		{
			return this.m_a.al;
		}
		return false;
	}

	[SpecialName]
	public bool bt()
	{
		if (this.m_a != null)
		{
			return this.m_a.am;
		}
		return false;
	}

	[SpecialName]
	public bool bu()
	{
		if (this.m_a != null)
		{
			return this.m_a.ag;
		}
		return false;
	}

	[SpecialName]
	public static bool at(bool A_0, bool A_1, a A_2)
	{
		return A_2?.ah ?? (A_0 || A_1);
	}

	[SpecialName]
	public bool bv()
	{
		if (this.m_a != null)
		{
			return this.m_a.ak;
		}
		return false;
	}
}
