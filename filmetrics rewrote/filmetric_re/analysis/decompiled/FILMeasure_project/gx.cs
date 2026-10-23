using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Timers;
using Microsoft.VisualBasic.CompilerServices;

internal class gx
{
	public delegate void a(gx A_0);

	public delegate void b(Guid A_0, float A_1, int[] A_2, string[] A_3, int[] A_4, Collection<Collection<float[]>> A_5, string A_6);

	private Guid m_a;

	[CompilerGenerated]
	private System.Timers.Timer m_b;

	private const int c = 50;

	private string d;

	private int e;

	private float[] f;

	private string g;

	private int[] h;

	private int[] i;

	private string[] m_j;

	private int[] m_k;

	private DateTime m_l;

	private bool m_m;

	private const int m_n = 1;

	public Collection<Guid> o;

	public Collection<int> p;

	public string q;

	public Collection<g7> r;

	public r.d s;

	public r.d t;

	public r.l u;

	public r.c v;

	[CompilerGenerated]
	private r.f m_w;

	public bool x;

	public bool y;

	public bool z;

	public string aa;

	public bool ab;

	public string ac;

	public Collection<float> ad;

	[CompilerGenerated]
	private a m_ae;

	[CompilerGenerated]
	private a m_af;

	[CompilerGenerated]
	private a m_ag;

	[CompilerGenerated]
	private b m_ah;

	public AutoResetEvent ai;

	public AutoResetEvent aj;

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer k()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void j(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = j;
		System.Timers.Timer timer = this.m_b;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		this.m_b = A_0;
		timer = this.m_b;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual r.f l()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void j(r.f A_0)
	{
		r.d.b a_ = j;
		this.m_w?.e(a_);
		this.m_w = A_0;
		this.m_w?.d(a_);
	}

	[SpecialName]
	[CompilerGenerated]
	public void j(a A_0)
	{
		a a10 = this.m_ae;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Combine(a11, A_0);
			a10 = Interlocked.CompareExchange(ref this.m_ae, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void k(a A_0)
	{
		a a10 = this.m_ae;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Remove(a11, A_0);
			a10 = Interlocked.CompareExchange(ref this.m_ae, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void l(a A_0)
	{
		a a10 = this.m_af;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Combine(a11, A_0);
			a10 = Interlocked.CompareExchange(ref this.m_af, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void m(a A_0)
	{
		a a10 = this.m_af;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Remove(a11, A_0);
			a10 = Interlocked.CompareExchange(ref this.m_af, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void n(a A_0)
	{
		a a10 = this.m_ag;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Combine(a11, A_0);
			a10 = Interlocked.CompareExchange(ref this.m_ag, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void w(a A_0)
	{
		a a10 = this.m_ag;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Remove(a11, A_0);
			a10 = Interlocked.CompareExchange(ref this.m_ag, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void j(b A_0)
	{
		b b10 = this.m_ah;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Combine(b11, A_0);
			b10 = Interlocked.CompareExchange(ref this.m_ah, value, b11);
		}
		while ((object)b10 != b11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void k(b A_0)
	{
		b b10 = this.m_ah;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Remove(b11, A_0);
			b10 = Interlocked.CompareExchange(ref this.m_ah, value, b11);
		}
		while ((object)b10 != b11);
	}

	public gx(r.d.b A_0, r.d.b A_1, a A_2, a A_3, a A_4)
	{
		j(new System.Timers.Timer());
		o = new Collection<Guid>();
		p = new Collection<int>();
		s = new r.d();
		t = new r.d();
		u = new r.l();
		v = new r.c();
		j(new r.f());
		ad = new Collection<float>();
		ai = new AutoResetEvent(initialState: false);
		aj = new AutoResetEvent(initialState: false);
		this.m_a = Guid.NewGuid();
		j();
		j(A_0, A_1, A_2, A_3, A_4);
	}

	public gx(Guid A_0)
	{
		j(new System.Timers.Timer());
		o = new Collection<Guid>();
		p = new Collection<int>();
		s = new r.d();
		t = new r.d();
		u = new r.l();
		v = new r.c();
		j(new r.f());
		ad = new Collection<float>();
		ai = new AutoResetEvent(initialState: false);
		aj = new AutoResetEvent(initialState: false);
		this.m_a = A_0;
		j();
	}

	private void j()
	{
		q = string.Empty;
		u.m = new r.d();
	}

	[SpecialName]
	public string m()
	{
		return g;
	}

	[SpecialName]
	public Guid n()
	{
		return this.m_a;
	}

	[SpecialName]
	public DateTime w()
	{
		return this.m_l;
	}

	[SpecialName]
	public void j(DateTime A_0)
	{
		this.m_m = true;
		this.m_l = A_0;
	}

	[SpecialName]
	public bool ae()
	{
		return this.m_m;
	}

	public void j(r.d.b A_0, r.d.b A_1, a A_2, a A_3, a A_4)
	{
		if (A_0 != null)
		{
			u.m.d(A_0);
		}
		if (A_1 != null)
		{
			t.d(A_1);
		}
		if (A_2 != null)
		{
			j(A_2);
		}
		if (A_3 != null)
		{
			l(A_3);
		}
		if (A_4 != null)
		{
			n(A_4);
		}
		k().Interval = 50.0;
		k().AutoReset = true;
	}

	public void af()
	{
		k().Start();
	}

	public static bool j(string A_0, ref string A_1)
	{
		int num = 0;
		string path;
		do
		{
			path = i3.c(A_0, DateTime.Now);
			path = Path.GetDirectoryName(path) + "\\" + Path.GetFileNameWithoutExtension(path) + "_" + num + Path.GetExtension(path);
			num = checked(num + 1);
		}
		while (File.Exists(path));
		bool flag = default(bool);
		bool result;
		try
		{
			File.WriteAllText(path, "Test");
			flag = true;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			A_1 = "AutoSave file is invalid. Error is: " + ex3.Message;
			result = false;
			ProjectData.ClearProjectError();
			goto IL_009b;
		}
		finally
		{
			if (flag)
			{
				File.Delete(path);
			}
		}
		result = true;
		goto IL_009b;
		IL_009b:
		return result;
	}

	public void ag()
	{
		this.m_m = false;
	}

	public gx ah()
	{
		gx gx2 = new gx(this.m_a);
		gx gx3 = gx2;
		gx3.q = q;
		checked
		{
			int num = o.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				gx3.o.Add(o[num2]);
				gx3.p.Add(p[num2]);
			}
			gx3.ab = ab;
			gx3.ac = ac;
			gx3 = null;
			return gx2;
		}
	}

	public void j(hg A_0, bool A_1, a4.a A_2, bool A_3, bool A_4, bool A_5)
	{
		hc hc2 = cc.cf(A_0, A_1, A_4);
		hc2.cf(A_0: true, A_2, A_3, A_5);
		this.m_k = hc2.er();
		checked
		{
			e = r.Count - 1;
			j(this.m_k, ref h);
			int num = h.Length - 1;
			i = new int[num + 1];
			this.m_j = new string[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				i[num3] = this.m_k[h[num3]];
				this.m_j[num3] = cc.cg(i[num3], A_1: true, new h4(h4.a.b), A_3: false);
			}
		}
	}

	public void j(fz A_0, hg A_1)
	{
		g = string.Empty;
		d = Conversions.ToString(i3.h(aa));
		StreamWriter streamWriter = null;
		try
		{
			streamWriter = new StreamWriter(aa, append: false, Encoding.UTF8);
			j(streamWriter, d, e, this.m_k, A_1.ca(), h, ref f);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			g = "Failure attempting to initialize AutoSave file with path=" + aa + ".\r\nError is:" + ex3.Message;
			A_0.c(fz.b.a, g, ex3);
			ProjectData.ClearProjectError();
		}
		finally
		{
			streamWriter?.Close();
		}
	}

	public void j(float A_0, Collection<Collection<float[]>> A_1, string A_2)
	{
		this.m_ah?.Invoke(this.m_a, A_0, i, this.m_j, h, A_1, A_2);
	}

	public static void j(Collection<int> A_0, string[] A_1, ref int[] A_2, ref int[] A_3, ref string[] A_4)
	{
		checked
		{
			int num = A_0.Count - 1;
			if (num >= 0)
			{
				A_2 = new int[num + 1];
				A_3 = new int[num + 1];
				List<string> list = new List<string>();
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					bool flag = false;
					string text = A_1[A_0[num3]];
					A_2[num3] = A_0[num3];
					int num4 = list.Count - 1;
					int num5;
					for (num5 = 0; num5 <= num4; num5++)
					{
						if (Operators.CompareString(list[num5], text, TextCompare: false) == 0)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						list.Add(text);
					}
					A_3[num3] = num5;
				}
				A_4 = list.ToArray();
			}
			else
			{
				A_2 = null;
				A_3 = null;
				A_4 = null;
			}
		}
	}

	public static void j(ref string A_0, int A_1, r.g.a A_2)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			A_0 += "; ";
		}
		A_0 += string.Format(ey.al(), checked(A_1 + 1).ToString(), A_2.a6().Replace("\r", " ").Replace("\n", string.Empty));
	}

	public static void j(Collection<cd.b[]> A_0, Collection<r.g.a[]> A_1, ref Collection<int> A_2, ref string[] A_3)
	{
		if (A_0 == null || A_1 == null)
		{
			return;
		}
		checked
		{
			int num = A_0.Count - 1;
			int num2 = num;
			int num5 = default(int);
			for (int num3 = 0; num3 <= num2; num3++)
			{
				cd.b[] array = A_0[num3];
				if (array != null)
				{
					int num4 = array.Length - 1;
					if (num4 >= 0 && num5 < array[num4].a)
					{
						num5 = array[num4].a;
					}
				}
			}
			A_3 = new string[num5 + 1];
			int num6 = num;
			for (int num7 = 0; num7 <= num6; num7++)
			{
				cd.b[] array = A_0[num7];
				r.g.a[] array2 = A_1[num7];
				if (array == null || array2 == null)
				{
					continue;
				}
				cd.b[] array3 = array;
				foreach (cd.b b10 in array3)
				{
					string A_4 = A_3[b10.a];
					if (string.IsNullOrEmpty(A_4))
					{
						A_2.Add(b10.a);
					}
					j(ref A_4, num7, array2[b10.b]);
					A_3[b10.a] = A_4;
				}
			}
		}
	}

	public static string j(Collection<r.g.a> A_0)
	{
		checked
		{
			int num = A_0.Count - 1;
			string A_1 = string.Empty;
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				r.g.a a10 = A_0[num3];
				if (a10 != null)
				{
					j(ref A_1, num3, a10);
				}
			}
			return A_1;
		}
	}

	public static void j(string A_0, ref double[] A_1, ref int[] A_2, ref h4 A_3, ref Collection<Collection<double[]>> A_4, ref int[] A_5, ref int[] A_6, ref string[] A_7)
	{
		string text = Conversions.ToString(i3.h(A_0));
		string a_ = File.ReadAllText(A_0, Encoding.UTF8) + "\r\n";
		string empty = string.Empty;
		int num = 0;
		int A_8 = default(int);
		empty = i3.a(ref A_8, a_);
		string[] array = empty.Split(text.ToCharArray()[0]);
		if (array.Length <= 1)
		{
			throw new au("Delimiter used in file is incompatible with current culture. Files saved as *.txt or *.csv are written in a culture-dependent format. Such files cannot be opened on a computer running with a different culture.");
		}
		int.Parse(array[1]);
		i3.a(ref A_8, a_, ref empty, A_3: false, text);
		i3.a(ref A_8, a_, ref empty, A_3: false, text);
		int num2 = int.Parse(empty);
		if (num2 > 1)
		{
			throw new au("Monitored Data *.txt maximum compatible file version is " + 1 + " compatible version in file we are attempting to read is " + num2);
		}
		i3.a(ref A_8, a_, ref empty, A_3: false, text);
		i3.a(ref A_8, a_, ref empty, A_3: false, text);
		if (Operators.CompareString(empty, Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator, TextCompare: false) != 0)
		{
			throw new au("Delimiter used in file is incompatible with current culture. Files saved as *.txt or *.csv are written in a culture-dependent format. Such files cannot be opened on a computer running with a different culture.");
		}
		i3.a(ref A_8, a_, ref empty, A_3: false, text);
		i3.a(ref A_8, a_, ref empty, A_3: false, text);
		A_3 = new h4((h4.a)int.Parse(empty));
		i3.a(ref A_8, a_, ref empty, A_3: false, text);
		i3.a(ref A_8, a_, ref empty, A_3: false, text);
		int num3 = int.Parse(empty);
		checked
		{
			int num4 = num3 - 1;
			string[] array2 = i3.a(ref A_8, a_).Split(text.ToCharArray()[0]);
			int num5 = unchecked(checked(array2.Length - 1) / num3) - 1;
			A_2 = new int[num5 + 1];
			int num6 = num5;
			for (int num7 = 0; num7 <= num6; num7++)
			{
				A_2[num7] = int.Parse(array2[1 + num7 * num3]);
			}
			i3.a(ref A_8, a_);
			i3.a(ref A_8, a_);
			num = A_8;
			int num8 = -2;
			do
			{
				empty = i3.a(ref A_8, a_);
				num8++;
			}
			while (!string.IsNullOrEmpty(empty));
			A_8 = num;
			A_1 = new double[num8 + 1];
			A_4 = new Collection<Collection<double[]>>();
			int num9 = num4;
			for (int num10 = 0; num10 <= num9; num10++)
			{
				Collection<double[]> collection = new Collection<double[]>();
				int num11 = num5;
				for (int num12 = 0; num12 <= num11; num12++)
				{
					double[] item = new double[num8 + 1];
					collection.Add(item);
				}
				A_4.Add(collection);
			}
			string[] array3 = new string[num8 + 1];
			int num13 = num8;
			for (int num14 = 0; num14 <= num13; num14++)
			{
				i3.a(ref A_8, a_, ref empty, A_3: false, text);
				A_1[num14] = float.Parse(empty);
				int num15 = num5;
				for (int num16 = 0; num16 <= num15; num16++)
				{
					int num17 = num4;
					for (int num18 = 0; num18 <= num17; num18++)
					{
						i3.a(ref A_8, a_, ref empty, A_3: false, text);
						A_4[num18][num16][num14] = float.Parse(empty);
					}
				}
				i3.a(ref A_8, a_, ref array3[num14], A_3: false, text);
			}
			int num19 = num5;
			for (int num20 = 0; num20 <= num19; num20++)
			{
				if (!cc.cn(A_2[num20]) || A_3.e() == h4.a.b)
				{
					continue;
				}
				double num21 = 1.0 / h4.f(A_3);
				int num22 = num4;
				for (int num23 = 0; num23 <= num22; num23++)
				{
					double[] array4 = A_4[num23][num20];
					double[] array5 = new double[num8 + 1];
					int num24 = num8;
					for (int num25 = 0; num25 <= num24; num25++)
					{
						array5[num25] = array4[num25] * num21;
					}
					A_4[num23][num20] = array5;
				}
			}
			Collection<int> collection2 = new Collection<int>();
			int num26 = num8;
			for (int num27 = 0; num27 <= num26; num27++)
			{
				if (!string.IsNullOrEmpty(array3[num27]))
				{
					collection2.Add(num27);
				}
			}
			j(collection2, array3, ref A_5, ref A_6, ref A_7);
		}
	}

	public void ak()
	{
		k().Stop();
	}

	public void k(r.d.a A_0)
	{
		ai.Reset();
		aj.Set();
	}

	public static void j(StreamWriter A_0, string A_1, float A_2, int A_3, int[] A_4, float[] A_5, int A_6, int A_7, Collection<Collection<float[]>> A_8, string A_9)
	{
		StreamWriter streamWriter = A_0;
		streamWriter.Write(A_2.ToString("0.00") + A_1);
		checked
		{
			for (int num = 0; num <= A_3; num++)
			{
				int index = A_4[num];
				for (int num2 = 0; num2 <= A_6; num2++)
				{
					streamWriter.Write(A_8[num2][index][A_7] * A_5[num] + A_1);
				}
			}
			if (string.IsNullOrEmpty(A_9))
			{
				streamWriter.WriteLine();
			}
			else
			{
				streamWriter.WriteLine("\"" + A_9 + "\"");
			}
			streamWriter = null;
		}
	}

	public void j(fz A_0, float A_1, Collection<Collection<float[]>> A_2, string A_3)
	{
		if (!string.IsNullOrEmpty(g))
		{
			return;
		}
		StreamWriter streamWriter = null;
		try
		{
			streamWriter = new StreamWriter(aa, append: true, Encoding.UTF8);
			j(streamWriter, d, A_1, checked(h.Length - 1), h, f, e, 0, A_2, A_3);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			g = "Failure attempting to write datapoint to file with path=" + aa + ".\r\nError is: " + ex3.Message;
			A_0.c(fz.b.a, g, ex3);
			ProjectData.ClearProjectError();
		}
		finally
		{
			streamWriter?.Close();
		}
	}

	public static void j(string A_0, float[] A_1, Collection<Collection<float[]>> A_2, int[] A_3, h4 A_4, int[] A_5, int[] A_6, string[] A_7)
	{
		string a_ = Conversions.ToString(i3.h(A_0));
		StreamWriter streamWriter = null;
		checked
		{
			int num = A_2.Count - 1;
			int num2 = A_1.Length - 1;
			int[] A_8 = null;
			float[] A_9 = null;
			int num3 = ((A_5 != null) ? (A_5.Length - 1) : (-1));
			try
			{
				streamWriter = new StreamWriter(A_0, append: false, Encoding.UTF8);
				j(A_3, ref A_8);
				j(streamWriter, a_, num, A_3, A_4, A_8, ref A_9);
				int a_2 = A_8.Length - 1;
				int num4 = 0;
				int num5 = num2;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					string a_3;
					if (num4 <= num3 && A_5[num4] == num6)
					{
						a_3 = A_7[A_6[num4]];
						num4++;
					}
					else
					{
						a_3 = string.Empty;
					}
					j(streamWriter, a_, A_1[num6], a_2, A_8, A_9, num, num6, A_2, a_3);
				}
			}
			finally
			{
				streamWriter?.Close();
			}
		}
	}

	public static void j(StreamWriter A_0, string A_1, int A_2, int[] A_3, h4 A_4, int[] A_5, ref float[] A_6)
	{
		checked
		{
			int num = A_5.Length - 1;
			A_6 = new float[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				int num4 = A_5[num3];
				if (cc.cn(A_3[num4]) && A_4.e() != h4.a.b)
				{
					A_6[num3] = (float)h4.f(A_4);
				}
				else
				{
					A_6[num3] = 1f;
				}
			}
			StreamWriter streamWriter = A_0;
			streamWriter.WriteLine("\"Version:\"" + A_1 + 1);
			streamWriter.WriteLine("\"Compatible Version:\"" + A_1 + 1);
			streamWriter.WriteLine("\"Decimal Separator:\"" + A_1 + "\"" + Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator + "\"");
			streamWriter.WriteLine("\"Thickness Units Code:\"" + A_1 + unchecked((int)A_4.e()));
			streamWriter.WriteLine("\"# Channels:\"" + A_1 + (A_2 + 1));
			streamWriter.Write("\"Parameter ID:\"" + A_1);
			int num5 = num;
			for (int num6 = 0; num6 <= num5; num6++)
			{
				for (int num7 = 0; num7 <= A_2; num7++)
				{
					streamWriter.Write(A_3[A_5[num6]]);
					if (num6 == num && num7 == A_2)
					{
						streamWriter.WriteLine();
					}
					else
					{
						streamWriter.Write(A_1);
					}
				}
			}
			streamWriter.Write("\"Parameter Name:\"" + A_1);
			int num8 = num;
			for (int num9 = 0; num9 <= num8; num9++)
			{
				for (int num10 = 0; num10 <= A_2; num10++)
				{
					streamWriter.Write("\"" + cc.cg(A_3[A_5[num9]], A_1: true, A_4, A_3: true) + "\"");
					if (num9 == num && num10 == A_2)
					{
						streamWriter.WriteLine();
					}
					else
					{
						streamWriter.Write(A_1);
					}
				}
			}
			streamWriter.Write("\"Elapsed Time (s)\"" + A_1);
			int num11 = num;
			for (int num12 = 0; num12 <= num11; num12++)
			{
				for (int num13 = 0; num13 <= A_2; num13++)
				{
					streamWriter.Write("\"Channel " + (num13 + 1) + "\"" + A_1);
				}
			}
			streamWriter.WriteLine("\"Error or Event Message\"");
			streamWriter = null;
		}
	}

	private static void j(int[] A_0, ref int[] A_1)
	{
		List<int> list = new List<int>();
		checked
		{
			int num = A_0.Length - 1;
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				list.Add(num3);
			}
			for (int num4 = num; num4 >= 0; num4 += -1)
			{
				int a_ = A_0[list[num4]];
				if (!cc.cj(a_) && (!cc.cl(a_) || cc.cg(a_) != cc.k.a) && !cc.ck(a_))
				{
					list.RemoveAt(num4);
				}
			}
			int num5 = list.Count - 1;
			A_1 = list.ToArray();
			int num6 = num5 - 1;
			for (int num7 = 0; num7 <= num6; num7++)
			{
				int num8 = num5 - 1;
				int num9 = num7;
				for (int num10 = num8; num10 >= num9; num10 += -1)
				{
					if (!cc.cj(A_0[A_1[num10]]) && cc.cj(A_0[A_1[num10 + 1]]))
					{
						int num11 = A_1[num10];
						A_1[num10] = A_1[num10 + 1];
						A_1[num10 + 1] = num11;
					}
				}
			}
		}
	}

	private void j(object A_0, ElapsedEventArgs A_1)
	{
		try
		{
			k().Stop();
			this.m_ae?.Invoke(this);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
		finally
		{
			k().Start();
		}
	}

	private void j(r.d.a A_0)
	{
		byte b10 = 1;
		byte b11 = 2;
		byte b12 = 0;
		r.g.a a10 = (r.g.a)A_0;
		if (((r.d.a)a10).a != global::r.d.a.a.a)
		{
			if (a10.d != null && a10.d is NullReferenceException)
			{
				k().Enabled = false;
			}
			return;
		}
		bool flag = (a10.t & b10) == b12;
		y = (a10.t & b11) == b12;
		a10 = null;
		bool num = !x && flag;
		bool flag2 = x && !flag;
		x = flag;
		if (num)
		{
			this.m_af?.Invoke(this);
		}
		else if (flag2)
		{
			this.m_ag?.Invoke(this);
		}
		ai.Set();
	}
}
