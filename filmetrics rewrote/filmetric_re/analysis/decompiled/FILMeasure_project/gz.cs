using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using FIUsbIntLib;
using Microsoft.VisualBasic.CompilerServices;

internal class gz
{
	public enum a
	{
		a,
		b,
		c
	}

	private Collection<gy> m_a;

	private Collection<ip.a> b;

	private Collection<h5.a> c;

	private Collection<@in.a> d;

	private Collection<gx> e;

	private fz m_f;

	public const string g = "MeasModConfig.bin";

	private const int m_h = 19;

	public gz(fz A_0, bool A_1)
	{
		this.m_a = new Collection<gy>();
		b = new Collection<ip.a>();
		c = new Collection<h5.a>();
		d = new Collection<@in.a>();
		e = new Collection<gx>();
		this.m_f = A_0;
		if (A_1)
		{
			f();
		}
	}

	public g1 g()
	{
		g1 g10 = new g1();
		foreach (gy item in this.m_a)
		{
			g10.a.Add(item.s());
		}
		foreach (ip.a item2 in b)
		{
			g10.b.Add(item2);
		}
		foreach (@in.a item3 in d)
		{
			g10.b.Add(item3);
		}
		foreach (h5.a item4 in c)
		{
			g10.b.Add(item4);
		}
		return g10;
	}

	private FMUSBDeviceType f(int A_0, BinaryReader A_1, float A_2, float A_3)
	{
		if (A_0 >= 14)
		{
			return (FMUSBDeviceType)A_1.ReadInt32();
		}
		if (A_2 > 0f && A_3 > 1200f)
		{
			return FMUSBDeviceType.FIUSB2DeviceSpecNIR2;
		}
		return FMUSBDeviceType.FIUSB2DeviceSpecLC;
	}

	private void f()
	{
		BinaryReader binaryReader = null;
		checked
		{
			try
			{
				if (!File.Exists(i3.o() + "\\MeasModConfig.bin"))
				{
					return;
				}
				binaryReader = new BinaryReader(new FileStream(i3.o() + "\\MeasModConfig.bin", FileMode.Open, FileAccess.Read));
				int num = binaryReader.ReadInt32();
				int num2 = binaryReader.ReadInt32();
				if (num2 < 4 || num2 > 19)
				{
					return;
				}
				int num3 = binaryReader.ReadInt32() - 1;
				int num5;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					gu.a.a a10 = unchecked((gu.a.a)binaryReader.ReadInt32());
					string text = binaryReader.ReadString();
					Guid a_ = new Guid(text);
					string text2 = binaryReader.ReadString();
					string left = text2;
					string A_ = "MeasurePanelName";
					if (Operators.CompareString(left, hu.a(ref A_), TextCompare: false) == 0)
					{
						text2 = string.Empty;
					}
					gy gy2 = new gy(this.m_f, a10, a_, text2);
					gy2.s(new g2());
					if (gy2.w().a(binaryReader) != 0)
					{
						this.m_a.Clear();
						return;
					}
					bool a_2 = binaryReader.ReadBoolean();
					string text3 = binaryReader.ReadString();
					if (Operators.CompareString(text3, "", TextCompare: false) == 0 || !text3.ToLower().EndsWith(".fitrp"))
					{
						text3 = "\\DefaultRecipe.fitrp";
					}
					gy2.s(A_0: false);
					gy2.u(text3);
					text3 = binaryReader.ReadString();
					if (Operators.CompareString(text3, "", TextCompare: false) == 0 || !text3.ToLower().EndsWith(".fitra"))
					{
						text3 = "\\DefaultRecipe.fitra";
					}
					gy2.s(A_0: true);
					gy2.u(text3);
					gy2.s(a_2);
					string text4 = binaryReader.ReadString();
					if (Operators.CompareString(text4, "", TextCompare: false) == 0)
					{
						text4 = "\\DefaultTemplate.fmtpe";
					}
					gy2.u(A_0: false);
					gy2.w(text4);
					text4 = binaryReader.ReadString();
					if (Operators.CompareString(text4, "", TextCompare: false) == 0)
					{
						text4 = "\\DefaultTemplate.fmtpa";
					}
					gy2.u(A_0: true);
					gy2.w(text4);
					gy2.u(a_2);
					gy2.v(binaryReader.ReadBoolean());
					if (binaryReader.ReadBoolean())
					{
						gy2.s(new gt(binaryReader));
					}
					if (num >= 6)
					{
						gy2.x(binaryReader.ReadString());
					}
					if (num >= 9)
					{
						gy2.t(binaryReader.ReadString());
					}
					num5 = binaryReader.ReadInt32();
					if (a10 == gu.a.a.a)
					{
						int num6 = num5 - 1;
						for (int num7 = 0; num7 <= num6; num7++)
						{
							binaryReader.ReadString();
							FMLegacyAllSystemTypes a_3 = unchecked((FMLegacyAllSystemTypes)binaryReader.ReadInt32());
							string a_4 = binaryReader.ReadString();
							string a_5 = binaryReader.ReadString();
							string a_6 = binaryReader.ReadString();
							string a_7 = binaryReader.ReadString();
							float num8 = binaryReader.ReadSingle();
							float num9 = binaryReader.ReadSingle();
							int a_8 = binaryReader.ReadInt32();
							FMUSBDeviceType a_9 = f(num2, binaryReader, num8, num9);
							bool a_10 = num >= 19 && binaryReader.ReadBoolean();
							ip.a a_11 = new ip.a(a_3, a_5, a_4, a_6, a_7, num8, num9, a_8, a_9, a_10);
							gy2.s(a_11, gy2.ak().Count);
						}
						if (num >= 11)
						{
							gy2.v(binaryReader.ReadString());
							gy2.t(binaryReader.ReadBoolean());
						}
						if (num >= 12 && binaryReader.ReadBoolean())
						{
							gy2.s(f(binaryReader));
						}
						if (num >= 13)
						{
							num5 = binaryReader.ReadInt32();
							int num10 = num5 - 1;
							for (int num7 = 0; num7 <= num10; num7++)
							{
								gy2.s(g(binaryReader), gy2.aj().Count);
							}
						}
						if (num >= 17)
						{
							num5 = binaryReader.ReadInt32();
							int num11 = num5;
							for (int num7 = 1; num7 <= num11; num7++)
							{
								gy2.s(f(binaryReader));
							}
						}
						this.m_a.Add(gy2);
						continue;
					}
					throw new Exception("Unknown device type");
				}
				num5 = binaryReader.ReadInt32();
				if (num5 > 0)
				{
					int num12 = num5 - 1;
					for (int num7 = 0; num7 <= num12; num7++)
					{
						binaryReader.ReadString();
						FMLegacyAllSystemTypes a_3 = unchecked((FMLegacyAllSystemTypes)binaryReader.ReadInt32());
						string a_4 = binaryReader.ReadString();
						string a_5 = binaryReader.ReadString();
						string a_6 = binaryReader.ReadString();
						string a_7 = binaryReader.ReadString();
						float num8 = binaryReader.ReadSingle();
						float num9 = binaryReader.ReadSingle();
						int a_8 = binaryReader.ReadInt32();
						FMUSBDeviceType a_9 = f(num2, binaryReader, num8, num9);
						bool a_10 = num >= 19 && binaryReader.ReadBoolean();
						ip.a a_11 = new ip.a(a_3, a_5, a_4, a_6, a_7, num8, num9, a_8, a_9, a_10);
						b.Add(a_11);
					}
				}
				if (num >= 7)
				{
					int num13 = binaryReader.ReadInt32();
					for (int num14 = 1; num14 <= num13; num14++)
					{
						string text = binaryReader.ReadString();
						gx gx2 = new gx(new Guid(text));
						gx2.q = binaryReader.ReadString();
						int num15 = binaryReader.ReadInt32();
						for (int num16 = 1; num16 <= num15; num16++)
						{
							gx2.o.Add(new Guid(binaryReader.ReadString()));
							if (num >= 9)
							{
								gx2.p.Add(binaryReader.ReadInt32());
							}
							else
							{
								gx2.p.Add(-1);
							}
						}
						if (num >= 8)
						{
							gx2.ab = binaryReader.ReadBoolean();
							gx2.ac = binaryReader.ReadString();
						}
						e.Add(gx2);
					}
				}
				if (num >= 12)
				{
					num5 = binaryReader.ReadInt32();
					if (num5 > 0)
					{
						int num17 = num5 - 1;
						for (int num7 = 0; num7 <= num17; num7++)
						{
							c.Add(f(binaryReader));
						}
					}
				}
				if (num >= 13)
				{
					num5 = binaryReader.ReadInt32();
					int num18 = num5 - 1;
					for (int num7 = 0; num7 <= num18; num7++)
					{
						d.Add(g(binaryReader));
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_12 = ex2;
				this.m_f.c(fz.b.a, "Error attempting to read MeasModConfig.bin file.", a_12);
				this.m_a.Clear();
				b.Clear();
				ProjectData.ClearProjectError();
			}
			finally
			{
				binaryReader?.Close();
			}
		}
	}

	private @in.a g(BinaryReader A_0)
	{
		FMLegacyAllSystemTypes a_ = (FMLegacyAllSystemTypes)A_0.ReadInt32();
		string a_2 = A_0.ReadString();
		string a_3 = A_0.ReadString();
		string a_4 = A_0.ReadString();
		string a_5 = A_0.ReadString();
		int a_6 = A_0.ReadInt32();
		return new @in.a(a_, a_3, a_2, a_4, a_5, a_6);
	}

	private h5.a f(BinaryReader A_0)
	{
		string a_ = A_0.ReadString();
		string a_2 = A_0.ReadString();
		FMLegacyAllSystemTypes a_3 = (FMLegacyAllSystemTypes)A_0.ReadInt32();
		byte a_4 = A_0.ReadByte();
		return new h5.a(a_, a_2, a_3, a_4);
	}

	private void f(BinaryWriter A_0, h5.a A_1)
	{
		A_0.Write(A_1.e());
		A_0.Write(A_1.f());
		A_0.Write((int)A_1.g());
		A_0.Write(A_1.h());
	}

	public a h()
	{
		a result = gz.a.a;
		BinaryWriter binaryWriter = null;
		try
		{
			binaryWriter = new BinaryWriter(new FileStream(i3.o() + "\\MeasModConfig.bin", FileMode.Create));
			binaryWriter.Write(19);
			binaryWriter.Write(18);
			binaryWriter.Write(this.m_a.Count);
			foreach (gy item in this.m_a)
			{
				binaryWriter.Write((int)item.t());
				binaryWriter.Write(item.x());
				binaryWriter.Write(item.u());
				item.w().a(binaryWriter);
				bool flag = item.z();
				binaryWriter.Write(flag);
				item.s(A_0: false);
				if (item.aa() == null)
				{
					item.u("\\DefaultRecipe.fitrp");
				}
				binaryWriter.Write(item.aa());
				item.s(A_0: true);
				if (item.aa() == null)
				{
					item.u("\\DefaultRecipe.fitra");
				}
				binaryWriter.Write(item.aa());
				item.s(flag);
				bool a_ = item.ae();
				item.u(A_0: false);
				if (item.af() == null)
				{
					item.w("\\DefaultTemplate.fmtpe");
				}
				binaryWriter.Write(item.af());
				item.u(A_0: true);
				if (item.af() == null)
				{
					item.w("\\DefaultTemplate.fmtpa");
				}
				binaryWriter.Write(item.af());
				item.u(a_);
				binaryWriter.Write(item.ag());
				if (item.ad() == null)
				{
					binaryWriter.Write(value: false);
				}
				else
				{
					binaryWriter.Write(value: true);
					item.ad().ac(binaryWriter);
				}
				if (item.ah() == null)
				{
					binaryWriter.Write(string.Empty);
				}
				else
				{
					binaryWriter.Write(item.ah());
				}
				if (string.IsNullOrEmpty(item.v()))
				{
					binaryWriter.Write(string.Empty);
				}
				else
				{
					binaryWriter.Write(item.v());
				}
				binaryWriter.Write(item.ak().Count);
				foreach (ip.a item2 in item.ak())
				{
					binaryWriter.Write(default(Guid).ToString());
					binaryWriter.Write((int)item2.l());
					binaryWriter.Write(item2.m());
					binaryWriter.Write(item2.n());
					binaryWriter.Write(item2.o());
					binaryWriter.Write(item2.p());
					binaryWriter.Write(item2.q());
					binaryWriter.Write(item2.r());
					binaryWriter.Write(item2.s());
					binaryWriter.Write((int)item2.t());
					binaryWriter.Write(item2.v());
				}
				if (item.ab() == null)
				{
					item.v(he.s());
				}
				binaryWriter.Write(item.ab());
				binaryWriter.Write(item.ac());
				if (item.ai().Count > 0)
				{
					binaryWriter.Write(value: true);
					f(binaryWriter, item.ai()[0]);
				}
				else
				{
					binaryWriter.Write(value: false);
				}
				if (item.aj() != null)
				{
					binaryWriter.Write(item.aj().Count);
					foreach (@in.a item3 in item.aj())
					{
						f(binaryWriter, item3);
					}
				}
				else
				{
					binaryWriter.Write(0);
				}
				checked
				{
					if (item.ai().Count > 1)
					{
						binaryWriter.Write(item.ai().Count - 1);
						int num = item.ai().Count - 1;
						for (int num2 = 1; num2 <= num; num2++)
						{
							f(binaryWriter, item.ai()[num2]);
						}
					}
					else
					{
						binaryWriter.Write(0);
					}
				}
			}
			binaryWriter.Write(b.Count);
			foreach (ip.a item4 in b)
			{
				binaryWriter.Write(default(Guid).ToString());
				binaryWriter.Write((int)item4.l());
				binaryWriter.Write(item4.m());
				binaryWriter.Write(item4.n());
				binaryWriter.Write(item4.o());
				binaryWriter.Write(item4.p());
				binaryWriter.Write(item4.q());
				binaryWriter.Write(item4.r());
				binaryWriter.Write(item4.s());
				binaryWriter.Write((int)item4.t());
				binaryWriter.Write(item4.v());
			}
			binaryWriter.Write(e.Count);
			checked
			{
				foreach (gx item5 in e)
				{
					binaryWriter.Write(item5.n().ToString());
					binaryWriter.Write(item5.q);
					binaryWriter.Write(item5.o.Count);
					int num3 = item5.o.Count - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						binaryWriter.Write(item5.o[num4].ToString());
						binaryWriter.Write(item5.p[num4]);
					}
					binaryWriter.Write(item5.ab);
					if (item5.ac == null)
					{
						item5.ac = string.Empty;
					}
					binaryWriter.Write(item5.ac);
				}
				binaryWriter.Write(c.Count);
				foreach (h5.a item6 in c)
				{
					f(binaryWriter, item6);
				}
				binaryWriter.Write(d.Count);
				foreach (@in.a item7 in d)
				{
					f(binaryWriter, item7);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			result = gz.a.b;
			ProjectData.ClearProjectError();
		}
		finally
		{
			binaryWriter?.Close();
		}
		return result;
	}

	public void f(BinaryWriter A_0, @in.a A_1)
	{
		@in.a a10 = A_1;
		A_0.Write((int)a10.l());
		A_0.Write(a10.j());
		A_0.Write(a10.k());
		A_0.Write(a10.g());
		A_0.Write(a10.h());
		A_0.Write(a10.i());
		a10 = null;
	}

	[SpecialName]
	public Collection<gy> i()
	{
		return this.m_a;
	}

	[SpecialName]
	public Collection<gx> j()
	{
		return e;
	}

	[SpecialName]
	public Collection<ip.a> k()
	{
		return b;
	}

	[SpecialName]
	public Collection<h5.a> l()
	{
		return c;
	}

	[SpecialName]
	public Collection<@in.a> m()
	{
		return d;
	}

	public a f(gy A_0, int A_1)
	{
		a result = gz.a.a;
		try
		{
			this.m_a.Insert(A_1, A_0);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			result = gz.a.b;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void f(gy A_0)
	{
		g(A_0);
		this.m_a.Remove(A_0);
	}

	public gy f(string A_0)
	{
		foreach (gy item in this.m_a)
		{
			if (Operators.CompareString(item.x(), A_0, TextCompare: false) == 0)
			{
				return item;
			}
		}
		return null;
	}

	public void f(gy A_0, ip.a A_1)
	{
		b.Remove(A_1);
		A_0.s(A_1, A_0.ak().Count);
	}

	public void g(gy A_0, int A_1)
	{
		ip.a item = A_0.ak()[A_1];
		A_0.t(A_1);
		if (!b.Contains(item))
		{
			b.Add(item);
		}
	}

	public void f(gy A_0, @in.a A_1)
	{
		d.Remove(A_1);
		A_0.s(A_1, A_0.ak().Count);
	}

	public void h(gy A_0, int A_1)
	{
		@in.a item = A_0.aj()[A_1];
		A_0.s(A_1);
		if (!d.Contains(item))
		{
			d.Add(item);
		}
	}

	public void g(gy A_0)
	{
		checked
		{
			if (A_0.ak().Count > 0)
			{
				for (int num = A_0.ak().Count - 1; num >= 0; num += -1)
				{
					g(A_0, num);
				}
			}
			for (int num2 = A_0.ai().Count - 1; num2 >= 0; num2 += -1)
			{
				i(A_0, num2);
			}
		}
	}

	public void f(gy A_0, h5.a A_1)
	{
		c.Remove(A_1);
		A_0.s(A_1);
	}

	public void i(gy A_0, int A_1)
	{
		h5.a item = A_0.ai()[A_1];
		A_0.u(A_1);
		if (!c.Contains(item))
		{
			c.Add(item);
		}
	}

	public void f(ip A_0, g7 A_1, ref bool A_2)
	{
		gy A_3 = null;
		A_2 = f(A_0, A_1, ref A_3);
		if (!A_2 && A_3 != null && Operators.CompareString(A_3.x(), A_1.zj(), TextCompare: false) == 0 && A_3.ak() != null && A_3.ak().Count > 0 && A_1.qh(A_0))
		{
			A_3.s(new ip.a(A_0));
			A_2 = true;
		}
	}

	public bool f(ip A_0, gu A_1)
	{
		gy A_2 = null;
		return f(A_0, A_1, ref A_2);
	}

	public static bool f(ip.a A_0, ip A_1, ref bool A_2)
	{
		ip.a a10 = A_0;
		if (Operators.CompareString(a10.n(), A_1.yq(), TextCompare: false) == 0 && Operators.CompareString(a10.p(), A_1.abk().SerialNumber, TextCompare: false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(a10.p(), A_1.abk().SerialNumber, TextCompare: false) == 0 && (ip.m2(a10.q(), a10.r(), A_1.vu(), A_1.vv(), Operators.CompareString(a10.p(), A_1.abn(), TextCompare: false) == 0) || A_1.abk().FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF2 || (a10.q() == 0f && A_1.vu() == 0f)))
		{
			A_2 = true;
		}
		else if (Operators.CompareString(a10.o(), A_1.abk().FriendlySN, TextCompare: false) == 0)
		{
			if ((A_1.abk().FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF10 && (A_1.abk().FWSystemSubtype == 3 || A_1.abk().FWSystemSubtype == 6 || A_1.abk().FWSystemSubtype == 8)) || A_1.abk().FWInstTypeCode == 28 || A_1.abk().FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF2 || A_1.abk().FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF60 || (A_1.abk().FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF50_300B && A_1.abk().FWSystemSubtype == 4))
			{
				A_2 = true;
			}
			else if (a10.t() != A_1.wr().h && ip.m2(a10.q(), a10.r(), A_1.vu(), A_1.vv(), A_4: false))
			{
				A_2 = true;
			}
		}
		a10 = null;
		return false;
	}

	private bool f(ip A_0, gu A_1, ref gy A_2)
	{
		A_2 = null;
		foreach (ip.a item in k())
		{
			if (Operators.CompareString(A_0.yq(), item.n(), TextCompare: false) == 0)
			{
				return false;
			}
		}
		bool A_3 = default(bool);
		foreach (gy item2 in this.m_a)
		{
			if (Operators.CompareString(A_1.zj(), item2.x(), TextCompare: false) != 0)
			{
				continue;
			}
			foreach (ip.a item3 in item2.ak())
			{
				if (f(item3, A_0, ref A_3))
				{
					return true;
				}
				if (A_3)
				{
					A_2 = item2;
				}
			}
			foreach (@in.a item4 in item2.aj())
			{
				if (Operators.CompareString(item4.h(), A_0.abk().SerialNumber, TextCompare: false) == 0)
				{
					A_2 = item2;
					break;
				}
				_ = null;
			}
		}
		return false;
	}

	public void f(@in A_0, g7 A_1, ref bool A_2)
	{
		gy A_3 = null;
		A_2 = f(A_0, A_1, ref A_3);
		if (!A_2 && A_3 != null && Operators.CompareString(A_3.x(), A_1.zj(), TextCompare: false) == 0)
		{
			A_3.s(new @in.a(A_0));
			A_2 = true;
		}
	}

	public bool f(@in A_0, gu A_1)
	{
		gy A_2 = null;
		return f(A_0, A_1, ref A_2);
	}

	private bool f(@in A_0, gu A_1, ref gy A_2)
	{
		A_2 = null;
		foreach (@in.a item in m())
		{
			if (Operators.CompareString(A_0.yq(), item.k(), TextCompare: false) == 0)
			{
				return false;
			}
		}
		foreach (gy item2 in this.m_a)
		{
			if (Operators.CompareString(A_1.zj(), item2.x(), TextCompare: false) != 0)
			{
				continue;
			}
			foreach (@in.a item3 in item2.aj())
			{
				if (Operators.CompareString(item3.k(), A_0.yq(), TextCompare: false) == 0)
				{
					return true;
				}
				if (Operators.CompareString(item3.h(), A_0.abk().SerialNumber, TextCompare: false) == 0)
				{
					A_2 = item2;
				}
				@in.a current3 = null;
			}
			foreach (ip.a item4 in item2.ak())
			{
				if (Operators.CompareString(item4.p(), A_0.abk().SerialNumber, TextCompare: false) == 0)
				{
					A_2 = item2;
					break;
				}
				_ = null;
			}
		}
		return false;
	}

	public bool f(gt A_0, gu A_1)
	{
		bool result = false;
		foreach (gy item in this.m_a)
		{
			if (gt.ac(A_1.zc(), A_0))
			{
				result = true;
				break;
			}
		}
		return result;
	}

	public static bool f(h5.a A_0, h5 A_1, ref bool A_2)
	{
		h5.a a10 = A_0;
		if (Operators.CompareString(a10.f(), A_1.abk().SerialNumber, TextCompare: false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(a10.e(), A_1.abk().ParentSerialNumber, TextCompare: false) == 0)
		{
			A_2 = true;
		}
		a10 = null;
		return false;
	}

	public void f(h5 A_0, g7 A_1, ref bool A_2)
	{
		gy A_3 = null;
		A_2 = f(A_0, A_1, ref A_3);
		if (!A_2 && A_3 != null && Operators.CompareString(A_3.x(), A_1.zj(), TextCompare: false) == 0)
		{
			A_3.s(new h5.a(A_0.abk()));
			A_2 = true;
		}
	}

	public void g(h5 A_0, g7 A_1, ref bool A_2)
	{
		if (!A_1.vl().Contains(A_0.abk().ParentSerialNumber))
		{
			return;
		}
		foreach (gy item in this.m_a)
		{
			if (Operators.CompareString(A_1.zj(), item.x(), TextCompare: false) == 0)
			{
				item.s(new h5.a(A_0.abk()));
				A_2 = true;
				break;
			}
		}
	}

	public void h(h5 A_0, g7 A_1, ref bool A_2)
	{
		if (!A_0.abq())
		{
			return;
		}
		foreach (gy item in this.m_a)
		{
			if (item.ak().Count <= 0)
			{
				continue;
			}
			foreach (ip.a item2 in item.ak())
			{
				FMLegacyAllSystemTypes fMLegacyAllSystemTypes = A_0.b();
				if ((fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeUVSource || fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeHnl) && ip.qh(item2.t()))
				{
					A_2 = true;
					item.s(new h5.a(A_0.abk()));
					return;
				}
			}
		}
	}

	public void i(h5 A_0, g7 A_1, ref bool A_2)
	{
		if (!A_0.abq())
		{
			return;
		}
		foreach (gy item in this.m_a)
		{
			if (item.ak().Count > 0)
			{
				A_2 = true;
				item.s(new h5.a(A_0.abk()));
				break;
			}
		}
	}

	public bool f(h5 A_0, gu A_1)
	{
		gy A_2 = null;
		return f(A_0, A_1, ref A_2);
	}

	public bool f(h5 A_0, gu A_1, ref gy A_2)
	{
		foreach (h5.a item in c)
		{
			if (Operators.CompareString(A_0.abk().SerialNumber, item.f(), TextCompare: false) == 0)
			{
				return false;
			}
		}
		foreach (gy item2 in this.m_a)
		{
			if (Operators.CompareString(A_1.zj(), item2.x(), TextCompare: false) != 0 || item2.ai().Count <= 0)
			{
				continue;
			}
			bool A_3 = false;
			foreach (h5.a item3 in item2.ai())
			{
				if (f(item3, A_0, ref A_3))
				{
					return true;
				}
				if (A_3)
				{
					A_2 = item2;
				}
			}
		}
		return false;
	}
}
