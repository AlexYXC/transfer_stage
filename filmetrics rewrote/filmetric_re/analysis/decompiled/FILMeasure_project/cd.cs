using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

internal class cd
{
	protected class a
	{
		protected int a;

		public List<float> b;

		public a(int A_0)
		{
			b = new List<float>();
			a = A_0;
		}

		[SpecialName]
		public int c()
		{
			return a;
		}
	}

	public class b
	{
		public int a;

		public int b;

		public b(int A_0, int A_1)
		{
			a = A_0;
			b = A_1;
		}
	}

	protected hg a;

	protected Collection<a> b;

	protected List<b> c;

	protected List<r.g.a> d;

	protected bool e;

	protected a4.a f;

	protected bool g;

	public long h;

	public cd(fz A_0, hg A_1, long A_2, bool A_3, a4.a A_4, bool A_5, bool A_6, bool A_7)
	{
		this.b = new Collection<a>();
		c = new List<b>();
		d = new List<r.g.a>();
		this.a = new hg(A_1.dh(), A_1.cd());
		A_1.bu(ref this.a);
		hc obj = cc.cf(this.a, A_3, A_6);
		obj.cf(A_0: true, A_4, A_5, A_7);
		e = A_3;
		this.f = A_4;
		this.g = A_5;
		int[] array = obj.er();
		foreach (int a_ in array)
		{
			this.b.Add(new a(a_));
		}
		if (A_2 < long.MaxValue)
		{
			h = checked(A_2 + 1);
		}
		else
		{
			h = 0L;
		}
	}

	[SpecialName]
	public hg f()
	{
		return this.a;
	}

	[SpecialName]
	public bool g()
	{
		return e;
	}

	[SpecialName]
	public a4.a i()
	{
		return this.f;
	}

	[SpecialName]
	public bool j()
	{
		return this.g;
	}

	[SpecialName]
	public int k()
	{
		return this.b[0].b.Count;
	}

	public Collection<int> l()
	{
		checked
		{
			int num = this.b.Count - 1;
			Collection<int> collection = new Collection<int>();
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				collection.Add(this.b[num3].c());
			}
			return collection;
		}
	}

	public Collection<float[]> f(int A_0)
	{
		Collection<float[]> collection = new Collection<float[]>();
		checked
		{
			foreach (a item in this.b)
			{
				lock (item.b)
				{
					List<float> list = item.b;
					int num = list.Count - 1;
					if (num > A_0)
					{
						num = A_0;
					}
					float[] array = new float[num + 1];
					int num2 = num;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						array[num3] = list[num3];
					}
					collection.Add(array);
					list = null;
				}
			}
			return collection;
		}
	}

	public b[] m()
	{
		lock (c)
		{
			return c.ToArray();
		}
	}

	public r.g.a[] n()
	{
		lock (d)
		{
			return d.ToArray();
		}
	}

	public double[] f(int A_0, int A_1, int A_2)
	{
		checked
		{
			foreach (a item in this.b)
			{
				if (item.c() == A_0)
				{
					int num = item.b.Count - 1;
					if (num > A_2)
					{
						num = A_2;
					}
					double[] array = new double[num - A_1 + 1];
					List<float> list = item.b;
					int num2 = num;
					for (int num3 = A_1; num3 <= num2; num3++)
					{
						array[num3 - A_1] = list[num3];
					}
					return array;
				}
			}
			return null;
		}
	}

	public Collection<float[]> g(int A_0)
	{
		Collection<float[]> collection = new Collection<float[]>();
		foreach (a item2 in this.b)
		{
			lock (item2.b)
			{
				List<float> list = item2.b;
				if (list.Count > 0)
				{
					float[] item = new float[1] { list[A_0] };
					collection.Add(item);
				}
				else
				{
					collection.Add(null);
				}
				list = null;
			}
		}
		return collection;
	}

	public bool f(int A_0, int A_1)
	{
		hi hi2 = this.a.ed();
		if (!hi2.g5())
		{
			return false;
		}
		foreach (a item in this.b)
		{
			if (!cc.cj(item.c()) || cc.ch(item.c()) != cc.m.a)
			{
				continue;
			}
			gc obj = hi2.eu(cc.cf(item.c()));
			float num = (float)obj.al();
			float num2 = (float)obj.am();
			_ = null;
			for (int num3 = A_0; num3 <= A_1; num3 = checked(num3 + 1))
			{
				float num4 = item.b[num3];
				if (num4 < num || num4 > num2)
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool g(int A_0, int A_1)
	{
		hi obj = this.a.ed();
		float num = (float)obj.gq();
		bool flag = this.a.bz((eo.a)null);
		float num2 = (float)obj.gr();
		checked
		{
			foreach (a item in this.b)
			{
				if (!cc.cl(item.c()))
				{
					continue;
				}
				if (cc.cg(item.c()) == cc.k.a)
				{
					for (int num3 = A_0; num3 <= A_1; num3++)
					{
						if (item.b[num3] < num)
						{
							return true;
						}
					}
				}
				else
				{
					if (!flag || cc.cg(item.c()) != cc.k.k)
					{
						continue;
					}
					for (int num4 = A_0; num4 <= A_1; num4++)
					{
						if (item.b[num4] < num2)
						{
							return true;
						}
					}
				}
			}
			return false;
		}
	}

	public r.g.a i(int A_0)
	{
		bool flag = false;
		r.g.a result = null;
		checked
		{
			lock (c)
			{
				int num = c.Count - 1;
				while (!flag && num >= 0)
				{
					b b10 = c[num];
					if (b10.a == A_0)
					{
						flag = true;
						lock (d)
						{
							result = d[b10.b];
						}
					}
					else
					{
						if (b10.a < A_0)
						{
							break;
						}
						num--;
					}
					b10 = null;
				}
			}
			return result;
		}
	}

	public void f(int A_0, ref r.g.a A_1, ref int A_2)
	{
		bool flag = false;
		checked
		{
			lock (c)
			{
				int num = c.Count - 1;
				while (!flag && num >= 0)
				{
					b b10 = c[num];
					if (b10.a <= A_0)
					{
						flag = true;
						lock (d)
						{
							A_1 = d[b10.b];
						}
						A_2 = b10.a;
					}
					else
					{
						num--;
					}
					b10 = null;
				}
			}
			if (!flag)
			{
				A_1 = null;
			}
		}
	}

	public void f(hc A_0, r.g.a A_1)
	{
		hi hi2 = A_0.cy().b3(A_0.cf());
		int num = hi2.g7();
		bool a_ = A_0.cy().dh().ax(null);
		bool a_2 = A_0.cy().dh().az(null);
		eo.b a_3 = A_0.cy().dh().at(null, A_0.cy().d0().q());
		int num2 = A_0.cy().dz();
		checked
		{
			int A_2 = default(int);
			int A_3;
			for (int num3 = 1; num3 <= num2; num3++)
			{
				hi2 = A_0.cy().b3(num3);
				float[] array = A_0.di();
				float[] array2 = A_0.@do();
				float[] array3 = A_0.dm();
				float[] array4 = A_0.dn();
				float[] array5 = A_0.dp();
				float[] array6 = A_0.dq();
				float[] array7 = A_0.dj();
				float[] array8 = A_0.dl();
				int num4 = 21000 * (num3 - 1);
				f(num4 + 0, A_0.c2(), ref A_2);
				f(num4 + 10, (float)A_0.c3(), ref A_2);
				int num5 = 0;
				int num6 = num + 1;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					bool flag = false;
					bool flag2 = false;
					int num8 = ((num7 != num + 1) ? (num4 + 1000 + 20 * num7) : (num4 + 1000 + 19980));
					gc gc2 = hi2.eu(num7);
					if (num7 <= num && gc2.af(a_3))
					{
						if (array == null || num7 > array.GetUpperBound(0))
						{
							int a_4 = num8 + 0;
							A_3 = 0;
							f(a_4, -1f, ref A_3);
						}
						else
						{
							int a_5 = num8 + 0;
							float a_6 = array[num7];
							A_3 = 0;
							f(a_5, a_6, ref A_3);
						}
					}
					if (gc2.ah(a_))
					{
						flag = true;
						if (array3 == null || num7 > array3.GetUpperBound(0))
						{
							int a_7 = num8 + 1;
							A_3 = 0;
							f(a_7, -1f, ref A_3);
						}
						else
						{
							int a_8 = num8 + 1;
							float a_9 = array3[num7];
							A_3 = 0;
							f(a_8, a_9, ref A_3);
						}
					}
					if (gc2.aj(a_))
					{
						flag2 = true;
						if (array4 == null || num7 > array4.GetUpperBound(0))
						{
							int a_10 = num8 + 2;
							A_3 = 0;
							f(a_10, -1f, ref A_3);
						}
						else
						{
							int a_11 = num8 + 2;
							float a_12 = array4[num7];
							A_3 = 0;
							f(a_11, a_12, ref A_3);
						}
					}
					if (flag)
					{
						if (A_0.ej()[num5].af() == hd.a.k)
						{
							if (array5 == null || num7 > array5.GetUpperBound(0))
							{
								int a_13 = num8 + 6;
								A_3 = 0;
								f(a_13, 0f, ref A_3);
							}
							else
							{
								int a_14 = num8 + 6;
								float a_15 = array5[num7];
								A_3 = 0;
								f(a_14, a_15, ref A_3);
							}
						}
						else if (A_0.ej()[num5].af() == hd.a.n)
						{
							if (array6 == null || num7 > array6.GetUpperBound(0))
							{
								int a_16 = num8 + 7;
								A_3 = 0;
								f(a_16, 0f, ref A_3);
							}
							else
							{
								int a_17 = num8 + 7;
								float a_18 = array6[num7];
								A_3 = 0;
								f(a_17, a_18, ref A_3);
							}
						}
					}
					if (gc2.al(a_))
					{
						if (array2 == null || num7 > array2.GetUpperBound(0))
						{
							int a_19 = num8 + 3;
							A_3 = 0;
							f(a_19, -1f, ref A_3);
						}
						else
						{
							int a_20 = num8 + 3;
							float a_21 = array2[num7];
							A_3 = 0;
							f(a_20, a_21, ref A_3);
						}
					}
					if (num7 <= num && gc2.ap(a_2))
					{
						if (array7 == null || num7 > array7.GetUpperBound(0))
						{
							int a_22 = num8 + 4;
							A_3 = 0;
							f(a_22, 0f, ref A_3);
						}
						else
						{
							int a_23 = num8 + 4;
							float a_24 = array7[num7];
							A_3 = 0;
							f(a_23, a_24, ref A_3);
						}
					}
					if (num7 <= num && gc2.an(a_))
					{
						if (array8 == null || num7 > array8.GetUpperBound(0))
						{
							int a_25 = num8 + 5;
							A_3 = 0;
							f(a_25, 0f, ref A_3);
						}
						else
						{
							int a_26 = num8 + 5;
							float a_27 = array8[num7] * 100f;
							A_3 = 0;
							f(a_26, a_27, ref A_3);
						}
					}
					if (flag || flag2)
					{
						num5++;
					}
					gc2 = null;
				}
			}
			if (e)
			{
				if (A_0.co().e() == null || A_0.co().e().Count < 1)
				{
					if (this.f != a4.a.d)
					{
						switch (this.f)
						{
						case a4.a.a:
							A_3 = 0;
							f(38, 0f, ref A_3);
							A_3 = 0;
							f(39, 0f, ref A_3);
							A_3 = 0;
							f(40, 0f, ref A_3);
							break;
						case a4.a.c:
							A_3 = 0;
							f(38, 0f, ref A_3);
							A_3 = 0;
							f(43, 0f, ref A_3);
							A_3 = 0;
							f(44, 0f, ref A_3);
							break;
						case a4.a.b:
							A_3 = 0;
							f(38, 0f, ref A_3);
							A_3 = 0;
							f(41, 0f, ref A_3);
							A_3 = 0;
							f(42, 0f, ref A_3);
							break;
						}
					}
					if (this.g || this.f == a4.a.d)
					{
						A_3 = 0;
						f(35, 0f, ref A_3);
						A_3 = 0;
						f(36, 0f, ref A_3);
						A_3 = 0;
						f(37, 0f, ref A_3);
					}
				}
				else
				{
					foreach (cc.d item in A_0.co().e())
					{
						if (this.f == item.h() && item.h() != a4.a.d)
						{
							switch (this.f)
							{
							case a4.a.a:
							{
								float a_34 = item.k();
								A_3 = 0;
								f(38, a_34, ref A_3);
								float a_35 = item.l();
								A_3 = 0;
								f(39, a_35, ref A_3);
								float a_36 = item.m();
								A_3 = 0;
								f(40, a_36, ref A_3);
								break;
							}
							case a4.a.c:
							{
								float a_31 = item.k();
								A_3 = 0;
								f(38, a_31, ref A_3);
								float a_32 = item.l();
								A_3 = 0;
								f(43, a_32, ref A_3);
								float a_33 = item.m();
								A_3 = 0;
								f(44, a_33, ref A_3);
								break;
							}
							case a4.a.b:
							{
								float a_28 = item.k();
								A_3 = 0;
								f(38, a_28, ref A_3);
								float a_29 = item.l();
								A_3 = 0;
								f(41, a_29, ref A_3);
								float a_30 = item.m();
								A_3 = 0;
								f(42, a_30, ref A_3);
								break;
							}
							}
						}
						if ((this.g || this.f == a4.a.d) && item.h() == a4.a.d)
						{
							float a_37 = item.k();
							A_3 = 0;
							f(35, a_37, ref A_3);
							float a_38 = item.l();
							A_3 = 0;
							f(36, a_38, ref A_3);
							float a_39 = item.m();
							A_3 = 0;
							f(37, a_39, ref A_3);
						}
					}
				}
			}
			A_3 = A_0.cj() - 1;
			int A_4;
			for (int num9 = 0; num9 <= A_3; num9++)
			{
				if (A_0.cy().ed().d9(num9))
				{
					switch (num9)
					{
					case 0:
					{
						float a_51 = A_0.ci()[num9];
						A_4 = 0;
						f(11, a_51, ref A_4);
						break;
					}
					case 1:
					{
						float a_50 = A_0.ci()[num9];
						A_4 = 0;
						f(12, a_50, ref A_4);
						break;
					}
					case 2:
					{
						float a_49 = A_0.ci()[num9];
						A_4 = 0;
						f(13, a_49, ref A_4);
						break;
					}
					case 3:
					{
						float a_48 = A_0.ci()[num9];
						A_4 = 0;
						f(14, a_48, ref A_4);
						break;
					}
					case 4:
					{
						float a_47 = A_0.ci()[num9];
						A_4 = 0;
						f(15, a_47, ref A_4);
						break;
					}
					case 5:
					{
						float a_46 = A_0.ci()[num9];
						A_4 = 0;
						f(16, a_46, ref A_4);
						break;
					}
					case 6:
					{
						float a_45 = A_0.ci()[num9];
						A_4 = 0;
						f(17, a_45, ref A_4);
						break;
					}
					case 7:
					{
						float a_44 = A_0.ci()[num9];
						A_4 = 0;
						f(18, a_44, ref A_4);
						break;
					}
					case 8:
					{
						float a_43 = A_0.ci()[num9];
						A_4 = 0;
						f(19, a_43, ref A_4);
						break;
					}
					case 9:
					{
						float a_42 = A_0.ci()[num9];
						A_4 = 0;
						f(20, a_42, ref A_4);
						break;
					}
					case 10:
					{
						float a_41 = A_0.ci()[num9];
						A_4 = 0;
						f(21, a_41, ref A_4);
						break;
					}
					case 11:
					{
						float a_40 = A_0.ci()[num9];
						A_4 = 0;
						f(22, a_40, ref A_4);
						break;
					}
					}
				}
			}
			A_4 = A_0.cl() - 1;
			int A_5;
			for (int num10 = 0; num10 <= A_4; num10++)
			{
				if (A_0.cy().ed().ei(num10))
				{
					switch (num10)
					{
					case 0:
					{
						float a_62 = A_0.ck()[num10].a;
						A_5 = 0;
						f(23, a_62, ref A_5);
						float a_63 = A_0.ck()[num10].b;
						A_5 = 0;
						f(24, a_63, ref A_5);
						break;
					}
					case 1:
					{
						float a_60 = A_0.ck()[num10].a;
						A_5 = 0;
						f(25, a_60, ref A_5);
						float a_61 = A_0.ck()[num10].b;
						A_5 = 0;
						f(26, a_61, ref A_5);
						break;
					}
					case 2:
					{
						float a_58 = A_0.ck()[num10].a;
						A_5 = 0;
						f(27, a_58, ref A_5);
						float a_59 = A_0.ck()[num10].b;
						A_5 = 0;
						f(28, a_59, ref A_5);
						break;
					}
					case 3:
					{
						float a_56 = A_0.ck()[num10].a;
						A_5 = 0;
						f(29, a_56, ref A_5);
						float a_57 = A_0.ck()[num10].b;
						A_5 = 0;
						f(30, a_57, ref A_5);
						break;
					}
					case 4:
					{
						float a_54 = A_0.ck()[num10].a;
						A_5 = 0;
						f(31, a_54, ref A_5);
						float a_55 = A_0.ck()[num10].b;
						A_5 = 0;
						f(32, a_55, ref A_5);
						break;
					}
					case 5:
					{
						float a_52 = A_0.ck()[num10].a;
						A_5 = 0;
						f(33, a_52, ref A_5);
						float a_53 = A_0.ck()[num10].b;
						A_5 = 0;
						f(34, a_53, ref A_5);
						break;
					}
					}
				}
			}
			if (A_0.ea() != null)
			{
				float a_64 = A_0.ea().a;
				A_5 = 0;
				f(58, a_64, ref A_5);
			}
			if (A_0.eb() != null)
			{
				float a_65 = A_0.eb().a;
				A_5 = 0;
				f(65, a_65, ref A_5);
			}
			if (string.IsNullOrEmpty(((r.d.a)A_1).b) && ((r.d.a)A_1).a == r.d.a.a.a && A_1.j == r.g.a.a.a)
			{
				return;
			}
			bool flag3 = false;
			A_5 = d.Count - 1;
			int num11;
			for (num11 = 0; num11 <= A_5; num11++)
			{
				if (A_1.Equals(d[num11]))
				{
					flag3 = true;
					break;
				}
			}
			if (!flag3)
			{
				lock (d)
				{
					d.Add(A_1);
				}
			}
			lock (c)
			{
				c.Add(new b(this.b[A_2].b.Count - 1, num11));
			}
			((r.d.a)A_1).a = r.d.a.a.a;
		}
	}

	protected void f(int A_0, float A_1, ref int A_2)
	{
		A_2 = 0;
		checked
		{
			while (this.b[A_2].c() != A_0)
			{
				A_2++;
			}
			this.b[A_2].b.Add(A_1);
		}
	}
}
