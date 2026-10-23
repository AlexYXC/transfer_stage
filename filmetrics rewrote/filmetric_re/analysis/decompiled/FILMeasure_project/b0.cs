using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using FIUsbIntLib;
using Filmetrics.TmcmControllerEnums;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class b0 : f0
{
	public new enum a
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
		k,
		l,
		m
	}

	internal new class b
	{
		private string a;

		private string m_b;

		private int c;

		private bool d;

		public b(b0 A_0)
			: this(A_0.sj(), A_0.qh(), (int)A_0.b(), A_0.f != null)
		{
		}

		public b(string A_0, string A_1, int A_2, bool A_3)
		{
			a = A_1;
			m_b = A_0;
			c = A_2;
			d = A_3;
		}

		[SpecialName]
		public string f()
		{
			return m_b;
		}

		[SpecialName]
		public void f(string A_0)
		{
			m_b = A_0;
		}

		[SpecialName]
		public string g()
		{
			return a;
		}

		[SpecialName]
		public void g(string A_0)
		{
			a = A_0;
		}

		[SpecialName]
		public int h()
		{
			return c;
		}

		[SpecialName]
		public void f(int A_0)
		{
			c = A_0;
		}

		[SpecialName]
		public string i()
		{
			if (d)
			{
				return h6.p9((FMLegacyAllSystemTypes)c);
			}
			return h0.l((h0.c)checked((byte)c));
		}

		public string j()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(i());
			stringBuilder.Append(" - ");
			stringBuilder.Append(m_b);
			stringBuilder.Append(", Fiber Mux");
			return stringBuilder.ToString();
		}

		[SpecialName]
		public bool k()
		{
			return d;
		}

		public void f(b A_0)
		{
			A_0.f(c);
			A_0.f(m_b);
			A_0.g(a);
			A_0.d = d;
		}
	}

	private new h5 m_a;

	private FIUsbController f;

	private FMLegacyAllSystemTypes g;

	private byte h;

	private bool i;

	private int j;

	private bool k;

	private DateTime l;

	private float m;

	private int n;

	private h1 o;

	private const short p = 0;

	public const short q = 1;

	private const short r = 8;

	private const short s = 16;

	private const short t = 800;

	private const short u = 400;

	private const float v = 1f;

	private const float w = 25.4f;

	private const float x = 10f;

	private const float y = 10f;

	private const float z = 300f;

	private const float aa = (float)Math.PI * 18f;

	private const float ab = (float)Math.PI * 20f;

	private const float ac = (float)Math.PI * 4f;

	public const int ad = 35;

	public const float ae = (float)Math.PI / 180f;

	public const float af = -0.34906584f;

	private const float ag = (float)Math.PI * 2f;

	public const float ah = 1.5f;

	public const string ai = "\\FiberMuxData";

	private const string aj = "\\fibermux_";

	private const string ak = ".fimux";

	private const int al = 1;

	private string am;

	private string an;

	private int ao;

	private double[] ap;

	private double[] aq;

	private static bool ar;

	private const float @as = 100f;

	public const float at = 0.9f;

	public const float au = 85.5f;

	[SpecialName]
	private bool av;

	[SpecialName]
	public override FMLegacyAllSystemTypes b()
	{
		return g;
	}

	[SpecialName]
	public override byte c()
	{
		return h;
	}

	[SpecialName]
	public string qh()
	{
		return am;
	}

	[SpecialName]
	public void m2(string A_0)
	{
		am = A_0;
	}

	[SpecialName]
	public string sj()
	{
		return an;
	}

	[SpecialName]
	public void p9(string A_0)
	{
		an = A_0;
	}

	[SpecialName]
	public string sm()
	{
		if (f != null)
		{
			return h6.p9(g);
		}
		return null;
	}

	[SpecialName]
	public int sn()
	{
		return j;
	}

	[SpecialName]
	public void m2(int A_0)
	{
		j = A_0;
	}

	[SpecialName]
	public bool so()
	{
		return k;
	}

	[SpecialName]
	public void m2(bool A_0)
	{
		k = A_0;
	}

	[SpecialName]
	public bool st()
	{
		return i;
	}

	[SpecialName]
	public short s3()
	{
		return 0;
	}

	[SpecialName]
	public h1 s4()
	{
		return o;
	}

	[SpecialName]
	public short s6()
	{
		return 8;
	}

	[SpecialName]
	public int s8()
	{
		return ao;
	}

	[SpecialName]
	public double[] tb()
	{
		if (ap == null)
		{
			return null;
		}
		double[] array = new double[checked(ap.Length - 1 + 1)];
		ap.CopyTo(array, 0);
		return array;
	}

	[SpecialName]
	public double[] tc()
	{
		if (aq == null)
		{
			return null;
		}
		double[] array = new double[checked(aq.Length - 1 + 1)];
		aq.CopyTo(array, 0);
		return array;
	}

	[SpecialName]
	public void m2(double[] A_0)
	{
		aq = A_0;
	}

	private a m2(string A_0, bool A_1)
	{
		string A_2 = null;
		l = DateAndTime.Now;
		h0 h10 = new h0();
		bool A_3 = default(bool);
		if (h10.l(1, ref A_3, A_0, A_1, h0.h.a, InterlockInput.None, DIN6Version.PostMotionStop, h0.g.c, A_8: false, A_9: false, h0.c.a, ref A_2) != h0.a.a)
		{
			ab8().c(fz.b.a, "Initialization error InitializingMotorController in FIFiberMuxDevice.Init");
			ab8().c(fz.b.a, A_2);
			return b0.a.b;
		}
		if (A_3)
		{
			return b0.a.c;
		}
		o = new h1();
		h1 h11 = o;
		if (h11.i(h10, 1, A_2: true, A_0) != h1.PublicErrors.None)
		{
			ab8().c(fz.b.a, "Initialization error InitializingRotaryMotor in FIFiberMuxDevice.Init");
			return b0.a.e;
		}
		if (h11.i(s6()) != h1.PublicErrors.None)
		{
			ab8().c(fz.b.a, "Initialization error InitializingRotaryMotor in FIFiberMuxDevice.Init");
			return b0.a.f;
		}
		if (h11.n(A_0: false) != h1.PublicErrors.None)
		{
			ab8().c(fz.b.a, "Initialization error SettingRotarySoftStopFlag in FIFiberMuxDevice.Init");
			return b0.a.g;
		}
		h11.i(800, 1f, -0.34906584f, A_3: false);
		if (h11.q())
		{
			h11.i(h3.f.f);
		}
		else
		{
			h11.i(80);
		}
		h11 = null;
		if (h10.l(A_0: true) != h0.a.a)
		{
			ab8().c(fz.b.a, "Initialization error EnergizingMotors in FIFiberMuxDevice.Init");
			return b0.a.h;
		}
		a result = default(a);
		return result;
	}

	protected override FIDeviceErr d()
	{
		ft = true;
		return FIDeviceErr.None;
	}

	public a p9(string A_0, bool A_1)
	{
		a a10 = b0.a.a;
		a10 = m2(A_0, A_1);
		i = a10 == b0.a.a;
		return a10;
	}

	public b0(h5 A_0, fz A_1, ref a A_2)
		: base(f0.a.g, A_1)
	{
		g = (FMLegacyAllSystemTypes)0;
		this.m_a = A_0;
		f = this.m_a.abk();
		g = (FMLegacyAllSystemTypes)f.FWInstTypeCode;
		h = f.FWSystemSubtype;
		an = f.FriendlySN;
		am = f.SerialNumber;
		if (!ar)
		{
			m2();
			ar = true;
		}
		A_2 = p9("", A_1: false);
		_ = A_2;
	}

	~b0()
	{
		o = null;
		base.Finalize();
	}

	private void m2(int A_0, double[] A_1)
	{
		ao = A_0;
		ap = A_1;
		p9();
	}

	private void p9()
	{
		string text = i3.o() + "\\FiberMuxData";
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		string path = text + "\\fibermux_" + am + ".fimux";
		BinaryWriter binaryWriter = null;
		checked
		{
			try
			{
				binaryWriter = new BinaryWriter(new FileStream(path, FileMode.Create));
				binaryWriter.Write(1);
				binaryWriter.Write(1);
				binaryWriter.Write(ao);
				int num = ao - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					binaryWriter.Write(ap[num2]);
				}
			}
			finally
			{
				binaryWriter?.Close();
			}
		}
	}

	private bz m2(ref string A_0)
	{
		BinaryReader binaryReader = null;
		string text = i3.o() + "\\FiberMuxData\\fibermux_" + am + ".fimux";
		checked
		{
			bz result;
			try
			{
				A_0 = string.Empty;
				if (!File.Exists(text))
				{
					A_0 = "FiberMuxFile " + text + " is missing.";
					result = bz.c;
				}
				else
				{
					binaryReader = new BinaryReader(new FileStream(text, FileMode.Open, FileAccess.Read));
					binaryReader.ReadInt32();
					int num = binaryReader.ReadInt32();
					if (num > 1)
					{
						A_0 = "The compatible FiberMux compatible version is " + num + ", this software version only understands calibration block versions <=" + 1;
						result = bz.b;
					}
					else
					{
						ao = binaryReader.ReadInt32();
						ap = new double[ao - 1 + 1];
						int num2 = ao - 1;
						for (int num3 = 0; num3 <= num2; num3++)
						{
							ap[num3] = binaryReader.ReadDouble();
						}
						result = bz.a;
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				A_0 = "Error reading " + text;
				result = bz.d;
				ProjectData.ClearProjectError();
			}
			finally
			{
				binaryReader?.Close();
			}
			return result;
		}
	}

	private void m2()
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (Operators.CompareString(process.ProcessName, "FISerBuffMult", TextCompare: false) == 0)
			{
				process.Kill();
				break;
			}
		}
	}

	public h1.PublicErrors td()
	{
		h1.PublicErrors num = tf();
		if (num != h1.PublicErrors.None)
		{
			ab8().c(fz.b.b, "Exception caught in USBStageDevice.SetMappingStageAccelerationAndVelocity() setting standard rot acceleration and velocity. ");
		}
		return num;
	}

	public int m2(ref float A_0)
	{
		return (int)o.k(ref A_0);
	}

	public h1.PublicErrors m2(double A_0, ref string A_1)
	{
		bool flag = false;
		flag = true;
		if (o.i(A_0, A_1: false) != h1.PublicErrors.None)
		{
			A_1 = "RotateFiberMuxToAnglePosition: error start moving rotary motor to angle " + Conversions.ToString(A_0) + " radians.";
			return h1.PublicErrors.Failure;
		}
		if (flag && o.af() != h1.PublicErrors.None)
		{
			A_1 = "RotateFiberMuxToAnglePosition: error finish moving rotary motor to angle " + Conversions.ToString(A_0) + " radians.";
			return h1.PublicErrors.Failure;
		}
		return h1.PublicErrors.None;
	}

	public int m2(int A_0, ref string A_1)
	{
		A_1 = string.Empty;
		if (A_0 < ao)
		{
			return (int)m2(ap[A_0], ref A_1);
		}
		A_1 = "Requested angle index is out of the range of currently defined indices";
		return -11;
	}

	public int p9(double A_0, ref string A_1)
	{
		if (o.i(A_0, A_1: false) != h1.PublicErrors.None)
		{
			A_1 = "RotateFiberMuxToAnglePosition: error start moving rotary motor to angle " + Conversions.ToString(A_0) + " radians.";
			return 1;
		}
		return 0;
	}

	public void m2(ref string A_0, ref bool A_1)
	{
		if (o.af() != h1.PublicErrors.None)
		{
			A_0 = "Failed attempting to mRotaryMotor.WaitToFinishMove in FinishMoveStageTo";
			throw new at(A_0);
		}
	}

	public void m2(ref float A_0, ref float A_1)
	{
		p9(ref A_0, ref A_1);
	}

	public void m2(ref float A_0, ref float A_1, ref float A_2, ref float A_3)
	{
		A_1 = (float)Math.PI * 20f;
		A_0 = (float)Math.PI * 4f;
		A_3 = A_1;
		A_2 = 0.04f;
		if (A_3 / A_2 > 100f)
		{
			A_3 = A_2 * 100f;
		}
	}

	public bool m2(bool A_0, ref string A_1, ref bool A_2)
	{
		bool result;
		if (av && A_0)
		{
			result = true;
		}
		else
		{
			try
			{
				if (tf() != h1.PublicErrors.None)
				{
					A_2 = false;
					A_1 = "Failed attempting to SetStandardRotAccelerationAndVelocity in FindHome";
					throw new at(A_1);
				}
				if (s4().k(0.0) != h1.PublicErrors.None)
				{
					A_2 = false;
					A_1 = "Failed attempting to RotaryMotor.SetCurrentPosition in FindHome";
					throw new at(A_1);
				}
				bool A_3 = false;
				if (s4().i(A_0: true, ref A_3) != h1.PublicErrors.None)
				{
					A_2 = false;
					A_1 = "Failed attempting to RotaryMotor.GetLimitSwitchAsserted in FindHome";
					throw new at(A_1);
				}
				if (A_3)
				{
					m2(-0.34906584f, ref A_1, ref A_2, A_3: true);
				}
				float A_4 = default(float);
				float A_5 = default(float);
				float A_6 = default(float);
				float A_7 = default(float);
				m2(ref A_4, ref A_5, ref A_6, ref A_7);
				if (s4().i(0.9f, 85.5f, ref A_1, ref A_2) != h1.PublicErrors.None)
				{
					A_2 = false;
					A_1 = "Failed attempting to RotaryMotor.StartMoveTowardLimit in FindHome";
					throw new at(A_1);
				}
				if (s4().i(A_4, A_6, A_5, A_7, A_4: true, A_5: true, ref A_1, ref A_2) != h1.PublicErrors.None)
				{
					A_2 = false;
					A_1 = "Hardware failure: Stage rotary limit switch is always triggered.";
					throw new at(A_1);
				}
				if (tf() != h1.PublicErrors.None)
				{
					A_2 = false;
					A_1 = "Failed attempting to SetStandardRotAccelerationAndVelocity in FindHome";
					throw new at(A_1);
				}
				av = true;
				result = true;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				ab8().c(fz.b.b, A_1, a_);
				result = false;
				ProjectData.ClearProjectError();
			}
		}
		return result;
	}

	public override void e()
	{
		try
		{
			o.ah();
			if (this.m_a != null && f.ShutdownWasCalled == 0)
			{
				int num = f.Shutdown();
				if (num != 0)
				{
					ab8().c(fz.b.b, "Error attempting to shut down USB Controller. Error code is:" + num);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			m2();
			ProjectData.ClearProjectError();
		}
	}

	public void te()
	{
		if (o.i(A_0: true, A_1: true) < h1.PublicErrors.None)
		{
			throw new at("Fail attempt to mRotaryMotor.DisableLimitSwitch in EnableLimitSwitches");
		}
	}

	public void p9(ref float A_0, ref float A_1)
	{
		A_0 = (float)Math.PI * 4f;
		A_1 = (float)Math.PI * 20f;
	}

	public h1.PublicErrors tf()
	{
		float A_ = default(float);
		float A_2 = default(float);
		p9(ref A_, ref A_2);
		return m2(A_, A_2);
	}

	public h1.PublicErrors m2(float A_0, float A_1)
	{
		return o.i((double)A_0, (double)A_1);
	}

	public void m2(float A_0, ref string A_1, ref bool A_2, bool A_3)
	{
		if (o.n((double)A_0) == h1.PublicErrors.None)
		{
			if (A_3 && o.af() != h1.PublicErrors.None)
			{
				A_2 = false;
				A_1 = "Error waiting for completion of incremental rotary move.";
				throw new at(A_1);
			}
			return;
		}
		A_2 = false;
		A_1 = "Error attempting execution of incremental rotary move.";
		throw new at(A_1);
	}

	public void p9(ref string A_0, ref bool A_1)
	{
		o.i(ref A_0, ref A_1);
	}

	public void qh(ref string A_0, ref bool A_1)
	{
		p9(ref A_0, ref A_1);
	}

	public void m2(bool A_0, bool A_1, ref string A_2, ref bool A_3)
	{
		if (m2((float)(A_1 ? 0.1 : 0.01), (float)Math.PI * 18f) != h1.PublicErrors.None)
		{
			A_2 = "Fail attempt to SetRotaryMotorAccelerationAndVelocity in MaxRotaryMoveStart.";
			throw new at(A_2);
		}
		if (A_0)
		{
			m2((float)Math.PI * 2f, ref A_2, ref A_3, A_3: false);
		}
		else
		{
			m2((float)Math.PI * -2f, ref A_2, ref A_3, A_3: false);
		}
	}

	public void m2(bool A_0, float A_1, ref string A_2, ref bool A_3)
	{
		if (tf() != h1.PublicErrors.None)
		{
			A_2 = "Fail attempt to SetStandardRotAccelerationAndVelocity in MaxRotaryMoveStart.";
			throw new at(A_2);
		}
		if (A_0)
		{
			m2(A_1, ref A_2, ref A_3, A_3: false);
		}
		else
		{
			m2(0f - A_1, ref A_2, ref A_3, A_3: false);
		}
	}

	public void tg()
	{
		ap = aq;
		aq = null;
		p9(ao, ap);
	}

	public void p9(int A_0, double[] A_1)
	{
		m2(A_0, A_1);
	}

	public bz p9(ref string A_0)
	{
		return m2(ref A_0);
	}
}
