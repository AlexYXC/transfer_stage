using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using FIUsbIntLib;
using Microsoft.VisualBasic.CompilerServices;

internal class @in : io
{
	public new class a
	{
		private string m_a;

		private string b;

		private string c;

		private string d;

		private int e;

		private FMLegacyAllSystemTypes f;

		public a(@in A_0)
			: this(A_0.b(), A_0.yq(), A_0.td(), A_0.abo(), A_0.abk().SerialNumber, A_0.tb())
		{
		}

		public a(FMLegacyAllSystemTypes A_0, string A_1, string A_2, string A_3, string A_4, int A_5)
		{
			f = A_0;
			c = A_2;
			d = A_1;
			m_a = A_3;
			b = A_4;
			e = A_5;
		}

		[SpecialName]
		public string g()
		{
			return m_a;
		}

		[SpecialName]
		public void g(string A_0)
		{
			m_a = A_0;
		}

		[SpecialName]
		public string h()
		{
			return b;
		}

		[SpecialName]
		public void h(string A_0)
		{
			b = A_0;
		}

		[SpecialName]
		public int i()
		{
			return e;
		}

		[SpecialName]
		public void g(int A_0)
		{
			e = A_0;
		}

		[SpecialName]
		public string j()
		{
			return c;
		}

		[SpecialName]
		public void i(string A_0)
		{
			c = A_0;
		}

		[SpecialName]
		public string k()
		{
			return d;
		}

		[SpecialName]
		public void j(string A_0)
		{
			d = A_0;
		}

		[SpecialName]
		public FMLegacyAllSystemTypes l()
		{
			return f;
		}

		[SpecialName]
		public void g(FMLegacyAllSystemTypes A_0)
		{
			f = A_0;
		}

		public string m()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(h6.p9(f));
			stringBuilder.Append(" - ");
			stringBuilder.Append(m_a);
			stringBuilder.Append(", Photodiode/LED #");
			stringBuilder.Append(checked(e + 1));
			return stringBuilder.ToString();
		}

		public void g(a A_0)
		{
			A_0.g(f);
			A_0.i(c);
			A_0.j(d);
			A_0.g(m_a);
			A_0.h(b);
			A_0.g(e);
		}
	}

	public new class b : h6.a
	{
		public byte b9;

		public List<float> ca;

		public b()
		{
			ca = new List<float>();
		}
	}

	public new class c
	{
		public string a;

		public bool b;
	}

	public new class d
	{
		private bool a;

		private bool b;

		public d c(ref bool A_0, ref bool A_1)
		{
			d obj = c();
			obj.d(ref A_0, ref A_1);
			return obj;
		}

		[SpecialName]
		public bool d()
		{
			return b;
		}

		[SpecialName]
		public bool e()
		{
			return a;
		}

		private d c()
		{
			return (d)MemberwiseClone();
		}

		protected void d(ref bool A_0, ref bool A_1)
		{
			a = A_0;
			b = A_1;
		}
	}

	private new class e
	{
		private int m_a;

		private int m_b;

		private double c;

		private bool d;

		private int m_e;

		private ushort[] f;

		private int g;

		private const float h = 0.85f;

		private const int i = 2;

		public float j;

		public bool k;

		public bool l;

		public DateTime m;

		public ushort n;

		public ushort o;

		public int p;

		public e(int A_0, bool A_1, int A_2)
		{
			this.m_a = A_0;
			d = A_1;
			m_e = A_2;
			f = new ushort[checked(A_2 - 1 + 1)];
		}

		public e(BinaryReader A_0)
		{
			a(ref A_0);
		}

		public void a(ushort[] A_0, int A_1, float A_2, bool A_3, ushort A_4)
		{
			checked
			{
				if (this.m_b == 0)
				{
					m = DateTime.Now;
					n = A_4;
					o = A_4;
					j = A_2;
					k = A_3;
				}
				else
				{
					int num = o + 1;
					if (num > 65535)
					{
						num = 0;
					}
					if (num != A_4)
					{
						if (A_4 < num)
						{
							p += 65535 - num + 1 + A_4;
						}
						else
						{
							p += A_4 - num;
						}
					}
					o = A_4;
				}
				if (d)
				{
					int num2 = -1;
					bool flag = default(bool);
					if (m_e >= A_1)
					{
						if (g + A_1 >= m_e)
						{
							flag = true;
							num2 = m_e - g - 1;
						}
					}
					else
					{
						flag = true;
						num2 = unchecked(checked(A_1 + g) / checked(m_e * m_e)) - g - 1;
					}
					if (flag)
					{
						int num3 = g - 1;
						float num5 = default(float);
						for (int num4 = 0; num4 <= num3; num4++)
						{
							num5 += (float)unchecked((int)f[num4]);
						}
						int num6 = m_e - g - 1;
						for (int num4 = 0; num4 <= num6; num4++)
						{
							num5 += (float)unchecked((int)A_0[num4]);
						}
						int num7 = m_e - g;
						int num8 = A_1 - m_e;
						int num9 = m_e;
						for (int num4 = num7; ((num9 >> 31) ^ num4) <= ((num9 >> 31) ^ num8); num4 += num9)
						{
							float num10 = 0f;
							int num11 = num4;
							int num12 = num4 + m_e - 1;
							for (int num13 = num11; num13 <= num12; num13++)
							{
								num10 += (float)unchecked((int)A_0[num13]);
							}
							if (num10 > num5)
							{
								num5 = num10;
							}
						}
						num5 *= 0.85f / (float)m_e;
						int num14 = g - 1;
						for (int num4 = 0; num4 <= num14; num4++)
						{
							if ((float)unchecked((int)f[num4]) > num5)
							{
								c += unchecked((int)f[num4]);
								this.m_b++;
							}
						}
						int num15 = num2;
						for (int num4 = 0; num4 <= num15; num4++)
						{
							if ((float)unchecked((int)A_0[num4]) > num5)
							{
								c += unchecked((int)A_0[num4]);
								this.m_b++;
							}
						}
						g = 0;
					}
					int num16 = A_1 - (num2 + 1);
					Array.Copy(A_0, num2 + 1, f, g, num16);
					g += num16;
				}
				else
				{
					int num17 = A_1 - 1;
					for (int num18 = 0; num18 <= num17; num18++)
					{
						c += unchecked((int)A_0[num18]);
					}
					this.m_b += A_1;
				}
			}
		}

		public void a()
		{
			c = 0.0;
			this.m_b = 0;
			l = false;
		}

		public float b()
		{
			return (float)(c / (double)this.m_b) * (4096f / (float)checked(this.m_a + 1));
		}

		public void a(ref BinaryReader A_0)
		{
			long offset = A_0.ReadInt64();
			int num = A_0.ReadInt32();
			int num2 = A_0.ReadInt32();
			if (num2 <= 2)
			{
				this.m_b = A_0.ReadInt32();
				c = A_0.ReadDouble();
				j = A_0.ReadSingle();
				m = new DateTime(A_0.ReadInt64());
				this.m_a = A_0.ReadInt32();
				if (num >= 2)
				{
					k = A_0.ReadBoolean();
				}
				A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
				return;
			}
			throw new au("AccumData maximum compatible block file version is " + 2 + " compatible version in file we are attempting to read is " + num2);
		}

		public void a(ref BinaryWriter A_0)
		{
			long position = A_0.BaseStream.Position;
			int value = 1;
			A_0.Write(position);
			A_0.Write(2);
			A_0.Write(value);
			A_0.Write(this.m_b);
			A_0.Write(c);
			A_0.Write(j);
			A_0.Write(m.Ticks);
			A_0.Write(this.m_a);
			A_0.Write(k);
			long position2 = A_0.BaseStream.Position;
			A_0.BaseStream.Seek(position, SeekOrigin.Begin);
			A_0.Write(position2);
			A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
		}
	}

	public class f
	{
		public DateTime a;

		public float[] b;
	}

	private new e[] m_m2;

	private new int nf;

	private new string ng;

	private new ushort[][] ou;

	private int o2;

	private int pb;

	private DateTime pd;

	private float[] pf;

	private FIUsbPdLed ph;

	private bool pi;

	private float[] pk;

	private DateTime pm;

	private e[] pn;

	private string po;

	private e[] pp;

	private float[] pq;

	private float[] pr;

	private float[] ps;

	private e[] pt;

	private e[] pu;

	private string pv;

	private e[] pw;

	private float[] px;

	private float[] py;

	private float[] pz;

	private e[] p0;

	private float[] p1;

	private const int p2 = 3;

	private const int p3 = 2;

	private new const int p4 = 1;

	[CompilerGenerated]
	private new int p5;

	[CompilerGenerated]
	private new bool p6;

	public @in(FIUsbController A_0, int A_1, fz A_2)
		: base(f0.a.f, A_0, A_2)
	{
		ou = new ushort[3][];
		nf = A_1;
		s4();
	}

	public @in(string A_0, int A_1, fz A_2)
		: base(f0.a.f, A_0, A_2)
	{
		ou = new ushort[3][];
		nf = A_1;
		s4();
	}

	[SpecialName]
	private float sm(int A_0)
	{
		return 0f;
	}

	[SpecialName]
	private byte st()
	{
		return checked((byte)(tg() - 1));
	}

	private void so()
	{
		if (pq == null)
		{
			pq = new float[checked(st() + 1)];
		}
	}

	private void sn()
	{
		if (pn == null)
		{
			pn = new e[checked(st() + 1)];
		}
	}

	private void sm()
	{
		checked
		{
			if (pp == null)
			{
				pp = new e[st() + 1];
				ps = new float[st() + 1];
			}
		}
	}

	private void sj()
	{
		if (pt == null)
		{
			pt = new e[checked(st() + 1)];
		}
	}

	private void sj(int A_0)
	{
		if (pn != null && pn[A_0] != null && ph.GainsAreEqual(checked((byte)A_0), pp[A_0].j, pn[A_0].j) == 0)
		{
			pn[A_0] = null;
		}
	}

	private void qh(int A_0)
	{
		if (pp != null && pp[A_0] != null && ph.GainsAreEqual(checked((byte)A_0), pt[A_0].j, pp[A_0].j) == 0 && pt[A_0].j < pp[A_0].j)
		{
			pp[A_0] = null;
		}
	}

	private void p9(int A_0)
	{
		if (pp != null && pp[A_0] != null && pn != null && pn[A_0] != null)
		{
			so();
			pq[A_0] = pp[A_0].b() - pn[A_0].b();
		}
	}

	private void qh()
	{
		if (py == null || p0 == null || pw == null || pu == null)
		{
			p1 = null;
			return;
		}
		checked
		{
			if (p1 == null || p1.Length != tg())
			{
				p1 = new float[st() + 1];
			}
			byte b10 = st();
			byte b11 = 0;
			while (unchecked((uint)b11 <= (uint)b10))
			{
				if (((IFIUsbPdLed)ph).get_ChannelIsActive(b11) != 0 && p0 != null && p0[b11] != null && py != null && py[b11] != 0f && pu != null && pu[b11] != null && pw != null && pw[b11] != null)
				{
					float num = p9();
					float num2 = p0[b11].j / pw[b11].j;
					float num3 = (pu[b11].b() - num) * num2;
					float num4 = py[b11];
					if (num4 <= 0f)
					{
						num4 = 1f;
					}
					p1[b11] = num4 * (p0[b11].b() - num - num3) / (px[b11] * num2);
				}
				b11 = (byte)unchecked((uint)(b11 + 1));
			}
		}
	}

	private float p9()
	{
		return 0f;
	}

	private new void m2(string A_0)
	{
		if (Operators.CompareString(pv, A_0, TextCompare: false) != 0)
		{
			pu = null;
			pv = A_0;
			pw = null;
			px = null;
			py = null;
			pz = null;
			p0 = null;
			p1 = null;
		}
	}

	private void qh(int A_0, DateTime A_1)
	{
		if (p9(A_1))
		{
			bool flag = pn == null;
			if (pu != null && pu[A_0] != null && (flag || pn[A_0] == null))
			{
				sn();
				pn[A_0] = pu[A_0];
			}
		}
	}

	private void p9(int A_0, DateTime A_1)
	{
		if (p9(A_1) && pw != null && pw[A_0] != null && (pp == null || pp[A_0] == null))
		{
			sm();
			pp[A_0] = pw[A_0];
			ps[A_0] = pz[A_0];
			if (px != null && px[A_0] != 0f)
			{
				so();
				pq[A_0] = px[A_0];
			}
		}
	}

	private new void m2(int A_0, DateTime A_1)
	{
		if (p9(A_1) && p0 != null && p0[A_0] != null && (pt == null || pt[A_0] == null))
		{
			sj();
			pt[A_0] = p0[A_0];
		}
	}

	public bool s3()
	{
		BinaryWriter A_ = null;
		string empty = string.Empty;
		checked
		{
			bool result;
			try
			{
				if (ph == null)
				{
					result = false;
				}
				else
				{
					string a_ = base.ou;
					string a_2 = pv;
					io.a a_3 = bb();
					bool A_2 = false;
					bool A_3 = false;
					empty = m2(a_, a_2, g2.OpticsConfigSubmoduleTypes.ReflectanceProbe, a_3, ref A_2, ref A_3);
					string directoryName = Path.GetDirectoryName(empty);
					if (!Directory.Exists(directoryName))
					{
						Directory.CreateDirectory(directoryName);
					}
					A_ = new BinaryWriter(File.Open(empty, FileMode.Create));
					A_.Write(1);
					A_.Write(1);
					if (pv == null)
					{
						pv = string.Empty;
					}
					A_.Write(pv);
					A_.Write(pd.Ticks);
					if (pu == null)
					{
						A_.Write(-1);
					}
					else
					{
						A_.Write(pu.Length);
						int num = pu.Length - 1;
						for (int num2 = 0; num2 <= num; num2++)
						{
							if (pu[num2] == null)
							{
								A_.Write(value: false);
								continue;
							}
							A_.Write(value: true);
							pu[num2].a(ref A_);
						}
					}
					if (pw == null)
					{
						A_.Write(-1);
					}
					else
					{
						A_.Write(pw.Length);
						int num3 = pw.Length - 1;
						for (int num2 = 0; num2 <= num3; num2++)
						{
							if (pw[num2] == null)
							{
								A_.Write(value: false);
								continue;
							}
							A_.Write(value: true);
							pw[num2].a(ref A_);
						}
					}
					if (px == null)
					{
						A_.Write(-1);
					}
					else
					{
						A_.Write(px.Length);
						int num4 = px.Length - 1;
						for (int num2 = 0; num2 <= num4; num2++)
						{
							A_.Write(px[num2]);
						}
					}
					if (py == null)
					{
						A_.Write(-1);
					}
					else
					{
						A_.Write(py.Length);
						int num5 = py.Length - 1;
						for (int num2 = 0; num2 <= num5; num2++)
						{
							A_.Write(py[num2]);
						}
					}
					if (pz == null)
					{
						A_.Write(-1);
					}
					else
					{
						A_.Write(pz.Length);
						int num6 = pz.Length - 1;
						for (int num2 = 0; num2 <= num6; num2++)
						{
							A_.Write(pz[num2]);
						}
					}
					if (p0 == null)
					{
						A_.Write(-1);
					}
					else
					{
						A_.Write(p0.Length);
						int num7 = p0.Length - 1;
						for (int num2 = 0; num2 <= num7; num2++)
						{
							if (p0[num2] == null)
							{
								A_.Write(value: false);
								continue;
							}
							A_.Write(value: true);
							p0[num2].a(ref A_);
						}
					}
					if (p1 == null)
					{
						A_.Write(-1);
					}
					else
					{
						A_.Write(p1.Length);
						int num8 = p1.Length - 1;
						for (int num2 = 0; num2 <= num8; num2++)
						{
							A_.Write(p1[num2]);
						}
					}
					base.p4 = empty;
					result = true;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_4 = ex2;
				ab8().c(fz.b.b, "Error in USBPhotodiodeLedDevice.WriteSettingsFile", a_4);
				result = false;
				ProjectData.ClearProjectError();
			}
			finally
			{
				A_?.Close();
			}
			return result;
		}
	}

	private new void m2()
	{
		pu = null;
		pv = string.Empty;
		pw = null;
		px = null;
		py = null;
		pz = null;
		p0 = null;
		p1 = null;
		pd = new DateTime(0L);
		base.p5 = true;
	}

	private new void m2(string A_0, string A_1, ref bool A_2)
	{
		BinaryReader binaryReader = null;
		checked
		{
			bool flag = default(bool);
			try
			{
				if (ph == null)
				{
					return;
				}
				bool A_3 = false;
				bool A_4 = false;
				string text = m2(A_0, A_1, g2.OpticsConfigSubmoduleTypes.ReflectanceProbe, bb(), ref A_3, ref A_4);
				if (A_3 || A_4)
				{
					if (Operators.CompareString(base.p4, text, TextCompare: false) == 0)
					{
						A_2 = true;
						return;
					}
					A_2 = false;
					binaryReader = new BinaryReader(File.Open(text, FileMode.Open, FileAccess.Read, FileShare.Read));
					binaryReader.ReadInt32();
					if (binaryReader.ReadInt32() > 1)
					{
						m2();
						return;
					}
					pv = binaryReader.ReadString();
					pd = new DateTime(binaryReader.ReadInt64());
					int num = binaryReader.ReadInt32();
					if (num == -1)
					{
						pu = null;
					}
					else
					{
						pu = new e[num - 1 + 1];
						int num2 = num - 1;
						for (int num3 = 0; num3 <= num2; num3++)
						{
							if (binaryReader.ReadBoolean())
							{
								pu[num3] = new e(binaryReader);
							}
						}
					}
					num = binaryReader.ReadInt32();
					if (num == -1)
					{
						pw = null;
					}
					else
					{
						pw = new e[num - 1 + 1];
						int num4 = num - 1;
						for (int num3 = 0; num3 <= num4; num3++)
						{
							if (binaryReader.ReadBoolean())
							{
								pw[num3] = new e(binaryReader);
							}
						}
					}
					num = binaryReader.ReadInt32();
					if (num == -1)
					{
						px = null;
					}
					else
					{
						px = new float[num - 1 + 1];
						int num5 = num - 1;
						for (int num3 = 0; num3 <= num5; num3++)
						{
							px[num3] = binaryReader.ReadSingle();
						}
					}
					num = binaryReader.ReadInt32();
					if (num == -1)
					{
						py = null;
					}
					else
					{
						py = new float[num - 1 + 1];
						int num6 = num - 1;
						for (int num3 = 0; num3 <= num6; num3++)
						{
							py[num3] = binaryReader.ReadSingle();
						}
					}
					num = binaryReader.ReadInt32();
					if (num == -1)
					{
						pz = null;
					}
					else
					{
						pz = new float[num - 1 + 1];
						int num7 = num - 1;
						for (int num3 = 0; num3 <= num7; num3++)
						{
							pz[num3] = binaryReader.ReadSingle();
						}
					}
					num = binaryReader.ReadInt32();
					if (num == -1)
					{
						p0 = null;
					}
					else
					{
						p0 = new e[num - 1 + 1];
						int num8 = num - 1;
						for (int num3 = 0; num3 <= num8; num3++)
						{
							if (binaryReader.ReadBoolean())
							{
								p0[num3] = new e(binaryReader);
							}
						}
					}
					num = binaryReader.ReadInt32();
					if (num == -1)
					{
						p1 = null;
					}
					else
					{
						p1 = new float[num - 1 + 1];
						int num9 = num - 1;
						for (int num3 = 0; num3 <= num9; num3++)
						{
							p1[num3] = binaryReader.ReadSingle();
						}
					}
					base.p4 = text;
					base.ou = A_0;
				}
				else
				{
					A_2 = false;
					base.p4 = text;
					base.ou = A_0;
					m2();
					pv = A_1;
					flag = true;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				ab8().c(fz.b.b, "Exception caught in USBPdLedDevice.ReadSettingsFile(). Exception is: ", a_);
				m2();
				ProjectData.ClearProjectError();
			}
			finally
			{
				if (binaryReader != null)
				{
					binaryReader.Close();
					base.p5 = false;
				}
				if (flag)
				{
					s3();
				}
			}
		}
	}

	protected override int a6(string A_0)
	{
		return ph.Connect(0, A_0, 0);
	}

	[SpecialName]
	protected override @is.a a8()
	{
		return @is.a.b;
	}

	protected override double a9(r.c A_0, r.d.a.b A_1, bool A_2)
	{
		return 0.0;
	}

	[SpecialName]
	protected override bool a7()
	{
		return ph.FWCorrupt != 0;
	}

	protected override float ba(double A_0, r.c A_1, r.d.a.b A_2, ref bool A_3)
	{
		return 0f;
	}

	protected FIDeviceErr s4()
	{
		FIDeviceErr result = FIDeviceErr.None;
		checked
		{
			try
			{
				ph = (FIUsbPdLed)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("313516E5-F1DA-431C-A946-7241096C4AB5")));
				int num = (mb = ph.Connect(0, abn(), (byte)(nf + 1)));
				switch (num)
				{
				case -108:
				case 0:
					if (ph.FWCorrupt != 0)
					{
						ab8().c(fz.b.a, "Failure in InitializeDevice(). USB Photodiode/LED Firmware corrupt", Environment.StackTrace);
					}
					ng = ph.FriendlySN;
					if (ph.FWCorrupt != 0)
					{
						ma = Guid.NewGuid().ToString("N");
					}
					else
					{
						ma = ph.SerialNumber;
					}
					ft = true;
					break;
				default:
					ab8().c(fz.b.a, "Failure in USBPdLedDevice.InitializeDevice(). Failure to connect to USB Photodiode/LED device. Error is: " + Conversions.ToString(num), Environment.StackTrace);
					result = FIDeviceErr.USBInitError;
					break;
				case -105:
					break;
				}
				int num2 = ph.FWNumPhotodiodes - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					ou[num3] = new ushort[ph.SamplesPerSampleBlock - 1 + 1];
				}
				bool A_ = false;
				p9(null, null, ref A_);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				result = FIDeviceErr.Generic;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	[SpecialName]
	public List<float> s6()
	{
		List<float> list = new List<float>();
		byte b10 = st();
		byte b11 = 0;
		while ((uint)b11 <= (uint)b10)
		{
			if (((IFIUsbPdLed)ph).get_ChannelIsActive(b11) != 0)
			{
				list.Add(pf[b11]);
			}
			checked
			{
				b11 = (byte)unchecked((uint)(b11 + 1));
			}
		}
		return list;
	}

	[SpecialName]
	public DateTime sn(int A_0)
	{
		return pu[A_0].m;
	}

	[SpecialName]
	public bool so(int A_0)
	{
		if (pu != null)
		{
			return pu[A_0] != null;
		}
		return false;
	}

	[SpecialName]
	public float st(int A_0)
	{
		return ((IFIUsbPdLed)ph).get_FWPDWavelength(checked((byte)A_0));
	}

	[SpecialName]
	public List<float> s8()
	{
		List<float> list = new List<float>();
		checked
		{
			byte b10 = (byte)(ph.FWNumPhotodiodes - 1);
			byte b11 = 0;
			while (unchecked((uint)b11 <= (uint)b10))
			{
				list.Add(((IFIUsbPdLed)ph).get_FWPDWavelength(b11));
				b11 = (byte)unchecked((uint)(b11 + 1));
			}
			return list;
		}
	}

	[SpecialName]
	public int tb()
	{
		return nf;
	}

	[SpecialName]
	[CompilerGenerated]
	public int tc()
	{
		return p5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void s3(int A_0)
	{
		p5 = A_0;
	}

	[SpecialName]
	public string td()
	{
		return ng;
	}

	private new float m2(int A_0)
	{
		if (pi)
		{
			return pk[A_0];
		}
		return pw[A_0].j;
	}

	public bool s4(int A_0)
	{
		if (!pi && !s6(A_0))
		{
			return false;
		}
		return so(A_0) && ph.GainsAreEqual(checked((byte)A_0), m2(A_0), pu[A_0].j) != 0;
	}

	public bool s6(int A_0)
	{
		if (tg(A_0) && pw[A_0].k == pi)
		{
			return ph.GainsAreEqual(checked((byte)A_0), m2(A_0), pw[A_0].j) != 0;
		}
		return false;
	}

	[SpecialName]
	public float s8(int A_0)
	{
		return ((IFIUsbPdLed)ph).get_GainMax(checked((byte)A_0));
	}

	[SpecialName]
	public List<float> te()
	{
		List<float> list = new List<float>();
		int num = st();
		checked
		{
			for (int num2 = 0; num2 <= num; num2++)
			{
				list.Add(((IFIUsbPdLed)ph).get_GainMax((byte)num2));
			}
			return list;
		}
	}

	[SpecialName]
	public List<float> tf()
	{
		List<float> list = new List<float>();
		int num = st();
		checked
		{
			for (int num2 = 0; num2 <= num; num2++)
			{
				list.Add(((IFIUsbPdLed)ph).get_GainMin((byte)num2));
			}
			return list;
		}
	}

	[SpecialName]
	public new void m2(DateTime A_0)
	{
		pd = A_0;
	}

	[SpecialName]
	public byte tg()
	{
		return ph.FWNumPhotodiodes;
	}

	[SpecialName]
	public int th()
	{
		byte b10 = st();
		byte b11 = 0;
		int num = default(int);
		while ((uint)b11 <= (uint)b10)
		{
			checked
			{
				if (((IFIUsbPdLed)ph).get_ChannelIsActive(b11) != 0)
				{
					num++;
				}
				b11 = (byte)unchecked((uint)(b11 + 1));
			}
		}
		return num;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool ti()
	{
		return p6;
	}

	[SpecialName]
	[CompilerGenerated]
	public new void m2(bool A_0)
	{
		p6 = A_0;
	}

	[SpecialName]
	public bool tb(int A_0)
	{
		if (pn != null)
		{
			return pn[A_0] != null;
		}
		return false;
	}

	[SpecialName]
	public bool tc(int A_0)
	{
		if (pp != null)
		{
			return pp[A_0] != null;
		}
		return false;
	}

	[SpecialName]
	public string tj()
	{
		return po;
	}

	[SpecialName]
	public float td(int A_0)
	{
		return pt[A_0].j;
	}

	[SpecialName]
	public bool te(int A_0)
	{
		if (pt != null)
		{
			return pt[A_0] != null;
		}
		return false;
	}

	[SpecialName]
	public bool p9(DateTime A_0)
	{
		return DateTime.Compare(pd, A_0) == 0;
	}

	[SpecialName]
	public DateTime tf(int A_0)
	{
		return pw[A_0].m;
	}

	[SpecialName]
	public bool tg(int A_0)
	{
		if (pw != null)
		{
			return pw[A_0] != null;
		}
		return false;
	}

	[SpecialName]
	public string tl()
	{
		return pv;
	}

	[SpecialName]
	public float th(int A_0)
	{
		return pz[A_0];
	}

	public new int m2(float A_0, float A_1, List<float> A_2, bool A_3, float A_4, float A_5, ref bool A_6, ref bool A_7)
	{
		float num = (A_0 + A_1) / 2f;
		A_6 = true;
		byte b10 = 0;
		do
		{
			if (((IFIUsbPdLed)ph).get_ChannelIsActive(b10) != 0)
			{
				float num2 = ((!A_3) ? this.m_m2[b10].b() : m2(b10, this.m_m2[b10].b(), A_4, A_5));
				if (num2 < A_0 || num2 > A_1)
				{
					if (!(num2 < A_0))
					{
						A_7 = true;
						return 0;
					}
					float num3;
					if (num2 <= 0f)
					{
						num3 = ((IFIUsbPdLed)ph).get_Gain(b10) * 10f;
					}
					else
					{
						num3 = ((IFIUsbPdLed)ph).get_Gain(b10) * num / num2;
						if (num3 > ((IFIUsbPdLed)ph).get_Gain(b10) * 10f)
						{
							num3 = ((IFIUsbPdLed)ph).get_Gain(b10) * 10f;
						}
					}
					if (num3 > A_2[b10])
					{
						num3 = A_2[b10];
					}
					if (num3 > ((IFIUsbPdLed)ph).get_GainMax(b10))
					{
						num3 = ((IFIUsbPdLed)ph).get_GainMax(b10);
					}
					if (ph.GainsAreEqual(b10, ((IFIUsbPdLed)ph).get_Gain(b10), num3) == 0)
					{
						A_6 = false;
						int num4 = ph.SetGain(b10, num3);
						if (num4 != 0)
						{
							return num4;
						}
					}
				}
			}
			checked
			{
				b10 = (byte)unchecked((uint)(b10 + 1));
			}
		}
		while ((uint)b10 <= 2u);
		return 0;
	}

	public void t0()
	{
		if (string.IsNullOrEmpty(po))
		{
			po = pv;
		}
		checked
		{
			if (pr != null && (py == null || py.Length != tg()))
			{
				py = new float[st() + 1];
			}
			if (ps != null && (pz == null || pz.Length != tg()))
			{
				pz = new float[st() + 1];
			}
			if (pn != null && (pu == null || pu.Length != tg()))
			{
				pu = new e[st() + 1];
			}
			if (pp != null && (pw == null || pw.Length != tg()))
			{
				pw = new e[st() + 1];
			}
			if (pq != null && (px == null || px.Length != tg()))
			{
				px = new float[st() + 1];
			}
			if (pt != null && (p0 == null || p0.Length != tg()))
			{
				p0 = new e[st() + 1];
			}
			byte b10 = 0;
			do
			{
				if (((IFIUsbPdLed)ph).get_ChannelIsActive(b10) != 0)
				{
					if (pr != null)
					{
						py[b10] = pr[b10];
					}
					if (ps != null)
					{
						pz[b10] = ps[b10];
					}
					if (pn != null)
					{
						pu[b10] = pn[b10];
					}
					if (pp != null)
					{
						pw[b10] = pp[b10];
					}
					if (pq != null)
					{
						px[b10] = pq[b10];
					}
					if (p0 != null && pt != null)
					{
						p0[b10] = pt[b10];
					}
				}
				b10 = (byte)unchecked((uint)(b10 + 1));
			}
			while (unchecked((uint)b10) <= 2u);
			pv = tj();
			pd = pm;
			if (pw != null)
			{
				qh();
			}
			if (!s3())
			{
				s3();
			}
			byte b11 = st();
			byte b12 = 0;
			while (unchecked((uint)b12 <= (uint)b11))
			{
				if (pw != null && pw[b12] != null && base.nf && ((IFIUsbPdLed)ph).get_ChannelIsActive(b12) != 0)
				{
					StreamWriter streamWriter = null;
					try
					{
						string path = ti(b12);
						string directoryName = Path.GetDirectoryName(path);
						if (!Directory.Exists(directoryName))
						{
							Directory.CreateDirectory(directoryName);
						}
						bool num = !File.Exists(path);
						streamWriter = new StreamWriter(path, append: true, Encoding.ASCII);
						if (num)
						{
							io.m2(streamWriter);
						}
						e e10 = pw[b12];
						io.m2(streamWriter, e10.m, g2.OpticsConfigSubmoduleTypes.ReflectanceProbe, jg.f(pv), e10.b(), pz[b12], 100f * py[b12], e10.j, base.m2);
						e10 = null;
					}
					finally
					{
						streamWriter?.Close();
					}
				}
				b12 = (byte)unchecked((uint)(b12 + 1));
			}
			t5();
		}
	}

	public void t5()
	{
		pt = null;
		pp = null;
		pq = null;
		po = null;
		pr = null;
		ps = null;
		pn = null;
		m2(A_0: false);
		base.nf = false;
		base.ng = false;
	}

	public b t6()
	{
		b b10 = new b();
		b b11 = b10;
		b11.a = ph.FriendlySN;
		b11.g = ph.FWDevSpecificHighestCompatRevLev;
		b11.i = ph.FWCorrupt != 0;
		if (!b11.i)
		{
			b11.d = ph.FWLastUpdate;
		}
		b11.f = ph.FWDevSpecificRevNum;
		b11.h = b11.i;
		b11.e = ph.FWWriteEnabled != 0;
		b11.b9 = ph.FWNumPhotodiodes;
		checked
		{
			byte b12 = (byte)(ph.FWNumPhotodiodes - 1);
			byte b13 = 0;
			while (unchecked((uint)b13 <= (uint)b12))
			{
				b11.ca.Add(((IFIUsbPdLed)ph).get_FWPDWavelength(b13));
				b13 = (byte)unchecked((uint)(b13 + 1));
			}
			b11 = null;
			return b10;
		}
	}

	public c t7()
	{
		c obj = new c();
		obj.b = true;
		obj.a = "Photodiode/LED";
		ref string reference = ref obj.a;
		reference = reference + ph.DeviceRevLevel.ToString().Trim() + "@" + checked(nf + 1).ToString().Trim();
		_ = null;
		return obj;
	}

	public new void m2(DateTime A_0, bool A_1)
	{
		checked
		{
			pn = new e[st() + 1];
			byte b10 = st();
			byte b11 = 0;
			while (unchecked((uint)b11 <= (uint)b10))
			{
				if (!ti())
				{
					m2(b11, A_0);
					p9(b11, A_0);
				}
				qh(b11, A_0);
				if (((IFIUsbPdLed)ph).get_ChannelIsActive(b11) != 0)
				{
					sn();
					pn[b11] = this.m_m2[b11];
					base.ng = true;
					if (A_1 || pq == null || pq[b11] == 0f)
					{
						p9(b11);
					}
				}
				b11 = (byte)unchecked((uint)(b11 + 1));
			}
			pm = A_0;
		}
	}

	public void qh(DateTime A_0)
	{
		byte b10 = st();
		byte b11 = 0;
		while ((uint)b11 <= (uint)b10)
		{
			if (!ti())
			{
				m2(b11, A_0);
				qh(b11, A_0);
			}
			p9(b11, A_0);
			if (((IFIUsbPdLed)ph).get_ChannelIsActive(b11) != 0)
			{
				sm();
				pp[b11] = this.m_m2[b11];
				ps[b11] = pf[b11];
				base.nf = true;
				if (ti())
				{
					sj(b11);
				}
				p9(b11);
			}
			checked
			{
				b11 = (byte)unchecked((uint)(b11 + 1));
			}
		}
		pm = A_0;
	}

	public void sj(DateTime A_0)
	{
		byte b10 = st();
		byte b11 = 0;
		while ((uint)b11 <= (uint)b10)
		{
			m2(b11, A_0);
			if (((IFIUsbPdLed)ph).get_ChannelIsActive(b11) != 0)
			{
				sj();
				pt[b11] = this.m_m2[b11];
				qh(b11);
			}
			checked
			{
				b11 = (byte)unchecked((uint)(b11 + 1));
			}
		}
	}

	public new float m2(int A_0, float A_1, float A_2, float A_3)
	{
		if (!te(A_0))
		{
			float num = 1f + A_3 / 100f;
			float num2 = sm(A_0);
			float num3 = A_1 * 0.01f;
			if (num3 < 10f)
			{
				num3 = 10f;
			}
			float num6 = default(float);
			if (p1 != null && p1[A_0] != 0f)
			{
				float num4 = A_1 - num2;
				if (num4 > num3)
				{
					float num5 = ((!(A_2 > 0f)) ? p1[A_0] : A_2);
					num6 = num4 * num5 / pr[A_0] * num + num2;
				}
			}
			if (num6 > A_1)
			{
				return num6;
			}
			return A_1;
		}
		return A_1;
	}

	public new bool m2(float A_0, ref double A_1, ref DateTime A_2, ref double A_3)
	{
		byte b10 = 0;
		do
		{
			checked
			{
				if (((IFIUsbPdLed)ph).get_ChannelIsActive(b10) == 0)
				{
					b10 = (byte)unchecked((uint)(b10 + 1));
					continue;
				}
				float a_ = ((!tc(b10)) ? 0f : (pp[b10].b() / (100f * pr[b10] * pp[b10].j)));
				return m2(b10, A_0, a_, g2.OpticsConfigSubmoduleTypes.ReflectanceProbe, ref A_1, ref A_2, ref A_3);
			}
		}
		while ((uint)b10 <= 2u);
		return false;
	}

	public override io.a bb()
	{
		return m2;
	}

	public void p9(string A_0, string A_1, ref bool A_2)
	{
		m2(A_0, A_1, ref A_2);
	}

	public new static string m2(fz A_0, string A_1, g2.OpticsConfigSubmoduleTypes A_2)
	{
		BinaryReader binaryReader = null;
		try
		{
			binaryReader = new BinaryReader(File.Open(A_1, FileMode.Open, FileAccess.Read, FileShare.Read));
			binaryReader.ReadInt32();
			if (binaryReader.ReadInt32() > 1)
			{
				return string.Empty;
			}
			return binaryReader.ReadString();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			A_0.c(fz.b.b, "Exception caught in USBPdLedDevice.ReadRefMatFromSettingsFile(). Exception is: ", a_);
			ProjectData.ClearProjectError();
		}
		finally
		{
			binaryReader?.Close();
		}
		return string.Empty;
	}

	public new int m2(ref bool A_0)
	{
		if (pb == 0)
		{
			A_0 = false;
			return 0;
		}
		ushort[] array = new ushort[1];
		byte[] array2 = new byte[3];
		int num = ph.RetrieveAcquiredData(1, ou[0], ou[1], ou[2], array, array2);
		checked
		{
			pb--;
			if (num != 0)
			{
				return num;
			}
			if (o2 > 0)
			{
				num = ph.TriggerAcquisition(1);
				if (num != 0)
				{
					return num;
				}
				pb++;
				o2--;
			}
			byte b10 = st();
			byte b11 = 0;
			while (unchecked((uint)b11 <= (uint)b10))
			{
				if (((IFIUsbPdLed)ph).get_ChannelIsActive(b11) != 0)
				{
					this.m_m2[b11].a(ou[b11], ph.SamplesPerSampleBlock, ((IFIUsbPdLed)ph).get_Gain(b11), pi, array[0]);
					if (array2[b11] != 0)
					{
						this.m_m2[b11].l = true;
					}
				}
				b11 = (byte)unchecked((uint)(b11 + 1));
			}
			A_0 = true;
			return 0;
		}
	}

	public new f m2(bool A_0, bool A_1)
	{
		f f10 = null;
		int num = 0;
		byte b10 = st();
		byte b11 = 0;
		checked
		{
			while (unchecked((uint)b11 <= (uint)b10))
			{
				if (((IFIUsbPdLed)ph).get_ChannelIsActive(b11) != 0)
				{
					if (f10 == null)
					{
						f10 = new f();
						f10.a = this.m_m2[b11].m;
					}
					num++;
				}
				b11 = (byte)unchecked((uint)(b11 + 1));
			}
			if (num > 0)
			{
				float[] array = new float[num - 1 + 1];
				num = 0;
				byte b12 = st();
				byte b13 = 0;
				while (unchecked((uint)b13 <= (uint)b12))
				{
					if (((IFIUsbPdLed)ph).get_ChannelIsActive(b13) != 0)
					{
						array[num] = this.m_m2[b13].b();
						if (A_1)
						{
							array[num] -= pu[b13].b();
						}
						if (A_0)
						{
							float num2 = ((!A_1) ? pw[b13].b() : px[b13]);
							array[num] *= py[b13] / num2;
						}
						num++;
					}
					b13 = (byte)unchecked((uint)(b13 + 1));
				}
				f10.b = array;
			}
			return f10;
		}
	}

	public int t8()
	{
		return ph.SamplesPerSampleBlock;
	}

	public double t9()
	{
		return ph.SamplingFrequency;
	}

	public new int m2(List<h.a> A_0, bool A_1)
	{
		checked
		{
			if (A_0 == null || A_0.Count < tc() + tg())
			{
				return 0;
			}
			int[] array = new int[3];
			pk = new float[3];
			pf = new float[st() + 1];
			int num = st();
			for (int num2 = 0; num2 <= num; num2++)
			{
				h.a a10 = A_0[tc() + num2];
				array[num2] = unchecked(0 - (a10.a ? 1 : 0));
				pf[num2] = a10.d;
				pk[num2] = a10.c;
				a10 = null;
			}
			pi = A_1;
			int num3 = 0;
			byte b10 = st();
			byte b11 = 0;
			while (unchecked((uint)b11 <= (uint)b10))
			{
				if (A_1)
				{
					num3 = ph.SetGain(b11, pk[b11]);
				}
				else if (pw != null && pw[b11] != null)
				{
					num3 = ph.SetGain(b11, pw[b11].j);
				}
				if (num3 != 0)
				{
					return num3;
				}
				b11 = (byte)unchecked((uint)(b11 + 1));
			}
			return ph.SetActiveChannels(array[0], array[1], array[2]);
		}
	}

	public int ua()
	{
		byte b10 = st();
		byte b11 = 0;
		while ((uint)b11 <= (uint)b10)
		{
			if (((IFIUsbPdLed)ph).get_ChannelIsActive(b11) != 0)
			{
				int num = ph.SetGain(b11, ((IFIUsbPdLed)ph).get_GainMin(b11));
				if (num != 0)
				{
					return num;
				}
			}
			checked
			{
				b11 = (byte)unchecked((uint)(b11 + 1));
			}
		}
		return 0;
	}

	public new void m2(string A_0, ref bool A_1)
	{
		ex ex2 = new ex();
		double[] array = new double[1];
		double[] A_2 = null;
		if (Operators.CompareString(po, A_0, TextCompare: false) != 0)
		{
			pp = null;
			po = A_0;
		}
		float result = default(float);
		if (ex2.e(A_0, ex.a.a, 0f, A_3: false, A_4: false))
		{
			A_1 = false;
		}
		else
		{
			ex2 = null;
			A_1 = !float.TryParse(A_0, NumberStyles.Any, CultureInfo.InvariantCulture, out result);
			if (A_1 && !string.IsNullOrEmpty(A_0))
			{
				ab8().c(fz.b.a, "Error attempting to read reference material file " + A_0 + ". File may be missing or corrupted.");
			}
			if (result <= 0f)
			{
				result = 1f;
			}
		}
		checked
		{
			pr = new float[st() + 1];
			int num = st();
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (ex2 == null)
				{
					pr[num2] = result;
					continue;
				}
				array[0] = pf[num2];
				if (ex2.e(array, 1, ref A_2))
				{
					pr[num2] = (float)A_2[0];
				}
				else
				{
					pr[num2] = 1f;
				}
			}
		}
	}

	public new int m2(int A_0, bool A_1, int A_2)
	{
		checked
		{
			int num = ph.MaxNumSampleBlocksInBuffer - pb;
			int num2;
			if (A_0 > num)
			{
				num2 = num;
				o2 += A_0 - num2;
			}
			else
			{
				num2 = A_0;
			}
			pb += num2;
			this.m_m2 = new e[st() + 1];
			byte b10 = 0;
			do
			{
				if (((IFIUsbPdLed)ph).get_ChannelIsActive(b10) != 0)
				{
					this.m_m2[b10] = new e(ph.MaxADValue, A_1, A_2);
				}
				b10 = (byte)unchecked((uint)(b10 + 1));
			}
			while (unchecked((uint)b10) <= 2u);
			return ph.TriggerAcquisition((short)num2);
		}
	}

	public new int m2(b A_0)
	{
		FIUsbPdLed fIUsbPdLed = ph;
		fIUsbPdLed.FWLastUpdate = DateTime.Now;
		string serialNumber = fIUsbPdLed.SerialNumber;
		fIUsbPdLed.SerialNumber = Guid.NewGuid().ToString("N");
		string friendlySN = fIUsbPdLed.FriendlySN;
		fIUsbPdLed.FriendlySN = A_0.a;
		fIUsbPdLed.FWRevNum = A_0.f;
		checked
		{
			fIUsbPdLed.FWUpdateRevLevel = -unchecked(0 - (A_0.h ? 1 : 0));
			fIUsbPdLed.FWNumPhotodiodes = A_0.b9;
			byte b10 = 0;
			do
			{
				((IFIUsbPdLed)fIUsbPdLed).set_FWPDWavelength(b10, A_0.ca[b10]);
				b10 = (byte)unchecked((uint)(b10 + 1));
			}
			while (unchecked((uint)b10) <= 2u);
			int result = fIUsbPdLed.WriteFirmware();
			File.WriteAllText(@is.b() + fIUsbPdLed.SerialNumber + " Old SN.txt", "Previous Guid: " + serialNumber + "\r\nPrevious SN: " + friendlySN, Encoding.UTF8);
			fIUsbPdLed = null;
			return result;
		}
	}
}
