using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using FIUsbIntLib;
using Microsoft.VisualBasic.CompilerServices;

internal class h5 : h6
{
	internal new class a
	{
		private string m_a;

		private string b;

		private FMLegacyAllSystemTypes c;

		private byte d;

		public a(FIUsbController A_0)
			: this(A_0.FriendlySN, A_0.SerialNumber, A_0.FWInstTypeCodeAsEnum, A_0.FWSystemSubtype)
		{
		}

		public a(string A_0, string A_1, FMLegacyAllSystemTypes A_2, byte A_3)
		{
			m_a = A_0;
			b = A_1;
			c = A_2;
			d = A_3;
		}

		[SpecialName]
		public string e()
		{
			return m_a;
		}

		[SpecialName]
		public void e(string A_0)
		{
			m_a = A_0;
		}

		[SpecialName]
		public string f()
		{
			return b;
		}

		[SpecialName]
		public void f(string A_0)
		{
			b = A_0;
		}

		[SpecialName]
		public FMLegacyAllSystemTypes g()
		{
			return c;
		}

		[SpecialName]
		public void e(FMLegacyAllSystemTypes A_0)
		{
			c = A_0;
		}

		[SpecialName]
		public byte h()
		{
			return d;
		}

		[SpecialName]
		public void e(byte A_0)
		{
			d = A_0;
		}

		public string i()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(h6.m2(c, d));
			stringBuilder.Append(" - ");
			stringBuilder.Append(m_a);
			return stringBuilder.ToString();
		}
	}

	private ushort ij;

	private ushort i3;

	public const byte ji = 3;

	private ushort[] jk;

	private DateTime jp;

	private bool k3;

	private bool lc;

	private string ld;

	private float ln;

	private bool lw;

	private const int lx = 1209600;

	private const int ly = 4;

	public h5(FIUsbController A_0, fz A_1)
		: base(f0.a.b, A_0, A_1)
	{
		jk = new ushort[3];
		ln = 1f;
		lw = false;
		m2(A_0: true);
	}

	public h5(string A_0, fz A_1, bool A_2)
		: base(f0.a.b, A_0, A_1)
	{
		jk = new ushort[3];
		ln = 1f;
		lw = false;
		m2(A_2);
	}

	protected override int a6(string A_0)
	{
		int lErrCode = default(int);
		abk().Connect(0, A_0, ref lErrCode);
		return lErrCode;
	}

	[SpecialName]
	protected override bool a7()
	{
		return abk().FWCorrupt != 0;
	}

	private new void m2(bool A_0)
	{
		bool A_1 = default(bool);
		m2(ref A_1);
		if (!A_1 || abk().HasLowPowerLightSource == 0)
		{
			return;
		}
		if (!A_0 && !aby() && !abz())
		{
			string text = ((!k3) ? "Untested." : ((!lc) ? "Tested OK." : ("Fail. Failure info=" + ld)));
			ab8().c(fz.b.a, "Low power light source detected; light source circuitry test state=" + text);
			ab8().c(fz.b.a, "Lamp setpoint=" + (100f * (float)(int)ij / (float)(int)abk().MaxLampSetpoint).ToString("0.0", CultureInfo.InvariantCulture) + "%.");
			ab8().c(fz.b.a, "Lamp estimated zero setpoint=" + (100f * (float)(int)i3 / (float)(int)abk().MaxLampSetpoint).ToString("0.0", CultureInfo.InvariantCulture) + "%.");
			byte b10 = 0;
			do
			{
				ab8().c(fz.b.a, "LED(" + b10 + ") setpoint=" + (100f * (float)(int)jk[b10] / (float)(int)((IFIUsbController)abk()).get_LsMaxLEDSetpoint(b10)).ToString("0.0", CultureInfo.InvariantCulture) + "%.");
				checked
				{
					b10 = (byte)unchecked((uint)(b10 + 1));
				}
			}
			while ((uint)b10 <= 2u);
			ab8().c(fz.b.a, "Light Source MasterDriveLevelFrac=" + ln.ToString("0.000", CultureInfo.InvariantCulture));
		}
		te();
		sj();
	}

	public void sj()
	{
		if (m2(ln))
		{
			if (global::e.a().LightSourceAutoStandby && tg())
			{
				float num = ((abk().FWOemCode != 2 || k3) ? st() : 0f);
				float a_ = ((!zm()) ? (num / 2f) : 0f);
				m2(a_, A_1: true, A_2: false);
				m2(num, A_1: false, A_2: false);
			}
			else
			{
				float a_ = ((!zm()) ? st() : 0f);
				m2(a_, A_1: true, A_2: false);
			}
		}
		lw = true;
	}

	public bool m2(float A_0)
	{
		int num = abk().LsGetPowerOnLampSetpoint(out var value);
		if (num != 0)
		{
			throw new ai("Error attempting to get lamp power-on setpoint. ErrCode=" + num);
		}
		bool flag = global::e.a().LightSourceAutoStandby && tg();
		checked
		{
			if (flag)
			{
				if (zm())
				{
					if (value != 0)
					{
						return true;
					}
				}
				else if (value != (ushort)Math.Round((float)unchecked((int)ij) * A_0 / 2f))
				{
					return true;
				}
			}
			else if (value != ij)
			{
				return true;
			}
			byte b10 = 0;
			do
			{
				num = abk().LsGetPowerOnLedSetpoint(b10, out value);
				if (num != 0)
				{
					throw new ai("Error attempting to get light source LED(" + b10 + ") power-on setpoint. ErrCode=" + num);
				}
				if (flag)
				{
					if (zm())
					{
						if (value != 0)
						{
							return true;
						}
					}
					else if (value != (ushort)Math.Round((float)unchecked((int)jk[b10]) * A_0 / 2f))
					{
						return true;
					}
				}
				else if (value != jk[b10])
				{
					return true;
				}
				b10 = (byte)unchecked((uint)(b10 + 1));
			}
			while (unchecked((uint)b10) <= 2u);
			return false;
		}
	}

	[SpecialName]
	public bool sm()
	{
		return lc;
	}

	[SpecialName]
	public string sn()
	{
		return ld;
	}

	[SpecialName]
	public bool so()
	{
		return k3;
	}

	[SpecialName]
	public float st()
	{
		if (aby())
		{
			if (abk().LightSourcePowerIsOn != 0)
			{
				return 100f;
			}
			return 0f;
		}
		return ln * 100f;
	}

	[SpecialName]
	public bool s3()
	{
		if (abk().LightSourcePowerIsOn != 0)
		{
			return ln > 0f;
		}
		return false;
	}

	[SpecialName]
	public bool s4()
	{
		if (abk().HasLowPowerLightSource != 0)
		{
			return jp.Ticks == 0;
		}
		return false;
	}

	[SpecialName]
	public bool s6()
	{
		if (abk().HasLowPowerLightSource != 0 && tc())
		{
			return DateTime.Now.Subtract(jp).TotalSeconds > 1209600.0;
		}
		return false;
	}

	[SpecialName]
	public float s8()
	{
		return 336f;
	}

	[SpecialName]
	public float tb()
	{
		return (float)((1209600.0 - DateTime.Now.Subtract(jp).TotalSeconds) / 3600.0);
	}

	[SpecialName]
	public bool tc()
	{
		if (!aby())
		{
			return !abz();
		}
		return false;
	}

	[SpecialName]
	public byte td()
	{
		return 3;
	}

	[SpecialName]
	private string qh()
	{
		return m2(abk().SerialNumber);
	}

	[SpecialName]
	public static string m2(string A_0)
	{
		return @is.b() + @is.c(@is.a.c) + A_0 + @is.f(@is.a.c);
	}

	private void m2(ref bool A_0)
	{
		BinaryReader binaryReader = null;
		try
		{
			A_0 = false;
			if (abk() == null)
			{
				return;
			}
			string path = qh();
			if (!File.Exists(path))
			{
				p9();
				return;
			}
			binaryReader = new BinaryReader(File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read));
			int num = binaryReader.ReadInt32();
			if (binaryReader.ReadInt32() > 4)
			{
				return;
			}
			ij = binaryReader.ReadUInt16();
			jp = new DateTime(binaryReader.ReadInt64());
			if (num > 1)
			{
				int num2 = 0;
				do
				{
					jk[num2] = binaryReader.ReadUInt16();
					num2 = checked(num2 + 1);
				}
				while (num2 <= 2);
			}
			if (num > 2)
			{
				i3 = binaryReader.ReadUInt16();
				k3 = binaryReader.ReadBoolean();
				lc = binaryReader.ReadBoolean();
				ld = binaryReader.ReadString();
			}
			if (num > 3)
			{
				ln = binaryReader.ReadSingle();
			}
			A_0 = true;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ab8().c(fz.b.b, "Exception caught in USBControllerDevice.ReadSettingsFile(). Exception is: ", a_);
			p9();
			ProjectData.ClearProjectError();
		}
		finally
		{
			binaryReader?.Close();
		}
	}

	private void p9()
	{
		ij = abk().MaxLampSetpoint;
		jp = new DateTime(0L);
		byte b10 = 0;
		do
		{
			jk[b10] = ((IFIUsbController)abk()).get_LsMaxLEDSetpoint(b10);
			checked
			{
				b10 = (byte)unchecked((uint)(b10 + 1));
			}
		}
		while ((uint)b10 <= 2u);
		if ((abk().FWInstTypeCodeAsEnum != FMLegacyAllSystemTypes.kTypeF3 || !abk().FriendlySN.Contains("ScattCal_")) && (abk().FWOemCode != 2 || aby()))
		{
			p9(0, 256);
			if (abk().FWInstTypeCodeAsEnum != FMLegacyAllSystemTypes.kTypeF3)
			{
				p9(192);
				p9(1, 102);
				p9(2, 205);
			}
			else
			{
				p9(205);
				p9(1, 154);
				p9(2, 256);
			}
		}
	}

	public void p9(bool A_0)
	{
		if (A_0 || zm())
		{
			float num = st();
			float a_ = ((!zm()) ? (num / 2f) : 0f);
			m2(a_, A_1: true, A_2: false);
			m2(num, A_1: false, A_2: false);
		}
	}

	public void m2(float A_0, bool A_1, bool A_2)
	{
		float num = (float)(0.01 * (double)A_0);
		if (aby())
		{
			int num2 = ((!((double)num < 0.5)) ? abk().SetLightSourcePowerOnState(1) : abk().SetLightSourcePowerOnState(0));
			if (num2 != 0)
			{
				throw new ai("Error attempting to set light on off in MasterLevel. ErrCode=" + num2);
			}
			num = 1f;
			ij = abk().MaxLampSetpoint;
			jk[0] = ((IFIUsbController)abk()).get_LsMaxLEDSetpoint((byte)0);
		}
		if (abk().FWOemCode == 2 && !lw && !aby())
		{
			ln = 0f;
		}
		else
		{
			ln = num;
		}
		te();
		if (A_1)
		{
			tf();
		}
		if (A_2)
		{
			m2();
		}
	}

	public int qh(bool A_0)
	{
		bool flag = false;
		float a_ = default(float);
		if (zm() && A_0)
		{
			a_ = st();
			flag = true;
			m2(0f, A_1: false, A_2: false);
		}
		int num = abk().SetLightSourcePowerOnState(0 - (A_0 ? 1 : 0));
		if (num != 0)
		{
			return num;
		}
		if (flag)
		{
			m2(a_, A_1: false, A_2: false);
		}
		int result = default(int);
		return result;
	}

	public void te()
	{
		m2(ij, jk);
	}

	public void m2(ushort A_0, ushort[] A_1)
	{
		checked
		{
			int num = p9((ushort)Math.Round((float)unchecked((int)A_0) * ln));
			if (num != 0)
			{
				throw new ai("Error attempting to set light source lamp setpoint. ErrCode=" + num);
			}
			byte b10 = 0;
			do
			{
				num = p9(b10, (ushort)Math.Round((float)unchecked((int)A_1[b10]) * ln));
				if (num != 0)
				{
					throw new ai("Error attempting to set light source LED(" + b10 + ") setpoint. ErrCode=" + num);
				}
				b10 = (byte)unchecked((uint)(b10 + 1));
			}
			while (unchecked((uint)b10) <= 2u);
		}
	}

	public void tf()
	{
		abk().LsUpdatePowerOnLampSetpoint();
		byte b10 = 0;
		do
		{
			abk().LsUpdatePowerOnLedSetpoint(b10);
			checked
			{
				b10 = (byte)unchecked((uint)(b10 + 1));
			}
		}
		while ((uint)b10 <= 2u);
	}

	public int m2(ushort A_0)
	{
		ij = A_0;
		int num = p9(A_0);
		if (num != 0)
		{
			return num;
		}
		if (!zm() && !global::e.a().LightSourceAutoStandby)
		{
			num = abk().LsUpdatePowerOnLampSetpoint();
		}
		m2();
		return 0;
	}

	public int p9(ushort A_0)
	{
		int num5;
		if (zm())
		{
			ushort num = (ushort)((abk().LampSetpointIsKnown != 0) ? abk().LampSetpoint : 0);
			if ((uint)A_0 > (uint)num)
			{
				checked
				{
					ushort num2 = (ushort)Math.Round((double)unchecked((int)abk().MaxLampSetpoint) / 50.0);
					int millisecondsTimeout = 120;
					int num3 = (int)Math.Round(Math.Floor(unchecked((double)(int)checked((ushort)unchecked((uint)(A_0 - num))) / (double)(int)num2)));
					for (int num4 = 1; num4 <= num3; num4++)
					{
						num = (ushort)unchecked((uint)(num + num2));
						num5 = abk().SetLampSetpoint(num);
						if (num5 != 0)
						{
							return num5;
						}
						Thread.Sleep(millisecondsTimeout);
					}
				}
			}
		}
		num5 = abk().SetLampSetpoint(A_0);
		if (num5 != 0)
		{
			return num5;
		}
		int result = default(int);
		return result;
	}

	public int m2(byte A_0, ushort A_1)
	{
		jk[A_0] = A_1;
		p9(A_0, A_1);
		if (!zm() && !global::e.a().LightSourceAutoStandby)
		{
			abk().LsUpdatePowerOnLedSetpoint(A_0);
		}
		m2();
		return 0;
	}

	public int p9(byte A_0, ushort A_1)
	{
		int num5;
		if (zm())
		{
			ushort num = (ushort)((((IFIUsbController)abk()).get_LsLEDSetpointIsKnown(A_0) != 0) ? ((IFIUsbController)abk()).get_LsLEDSetpoint(A_0) : 0);
			if ((uint)A_1 > (uint)num)
			{
				checked
				{
					ushort num2 = (ushort)Math.Round((double)unchecked((int)((IFIUsbController)abk()).get_LsMaxLEDSetpoint(A_0)) / 50.0);
					int millisecondsTimeout = 20;
					int num3 = (int)Math.Round(Math.Floor(unchecked((double)(int)checked((ushort)unchecked((uint)(A_1 - num))) / (double)(int)num2)));
					for (int num4 = 1; num4 <= num3; num4++)
					{
						num = (ushort)unchecked((uint)(num + num2));
						num5 = abk().LsSetLEDSetpoint(A_0, A_1);
						if (num5 != 0)
						{
							return num5;
						}
						Thread.Sleep(millisecondsTimeout);
					}
				}
			}
		}
		num5 = abk().LsSetLEDSetpoint(A_0, A_1);
		if (num5 != 0)
		{
			return num5;
		}
		int result = default(int);
		return result;
	}

	[SpecialName]
	public bool tg()
	{
		if (!h6.p9(abk()))
		{
			return !h6.qh(abk());
		}
		return false;
	}

	public void m2(ushort A_0, ushort A_1, ushort[] A_2, bool A_3, bool A_4, bool A_5, string A_6)
	{
		ij = A_0;
		i3 = A_1;
		jp = DateTime.Now;
		byte b10 = 0;
		do
		{
			jk[b10] = A_2[b10];
			checked
			{
				b10 = (byte)unchecked((uint)(b10 + 1));
			}
		}
		while ((uint)b10 <= 2u);
		if (A_3)
		{
			tf();
		}
		k3 = true;
		lc = A_5;
		ld = A_6;
		if (A_4)
		{
			m2();
		}
	}

	private void m2()
	{
		BinaryWriter binaryWriter = null;
		try
		{
			string text = null;
			if (abk() != null)
			{
				text = qh();
				string directoryName = Path.GetDirectoryName(text);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				binaryWriter = new BinaryWriter(File.Open(text, FileMode.Create));
				binaryWriter.Write(4);
				binaryWriter.Write(1);
				binaryWriter.Write(ij);
				binaryWriter.Write(jp.Ticks);
				int num = 0;
				do
				{
					binaryWriter.Write(jk[num]);
					num = checked(num + 1);
				}
				while (num <= 2);
				binaryWriter.Write(i3);
				binaryWriter.Write(k3);
				binaryWriter.Write(lc);
				if (ld == null)
				{
					ld = string.Empty;
				}
				binaryWriter.Write(ld);
				binaryWriter.Write(ln);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ab8().c(fz.b.b, "Error in USBControllerDevice.WriteSettingsFile", a_);
			ProjectData.ClearProjectError();
		}
		finally
		{
			binaryWriter?.Close();
		}
	}

	public static void m2(string A_0, c A_1, fz A_2, string A_3)
	{
		string text = ((!string.IsNullOrEmpty(A_3)) ? "\r\n" : ", ");
		c c10 = A_1;
		string text2 = A_0 + "(Controller S/N:" + c10.a + "): ";
		if (!string.IsNullOrEmpty(A_3))
		{
			text2 += text;
		}
		text2 = text2 + "AROption=" + c10.aa.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "ColorOption=" + c10.t.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "DvdOption=" + c10.v.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "F40FullSpectrum=" + c10.ac.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "F40Optics=" + c10.ab.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "F40UVSpectrum=" + c10.ad.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "FFTThicknessOnly=" + c10.w.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "FilterOption=" + c10.s.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "JMESave=" + c10.q.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "LayerAttr=" + c10.m.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "MultiLayer=" + c10.n.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "NKActive=" + c10.o.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "NKCauchyOnly=" + c10.p.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "PermitCompositeRecipeEx=" + c10.at.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "OptoValues=" + c10.u.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "SpecDep=" + c10.r.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "NKCauchyOnly=" + c10.x.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "VIOption=" + c10.z.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "VsTimeOption=" + c10.y.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "LimitCenterDistance=" + c10.l.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "XYStageExpected=" + c10.ay.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "HasMotorizedZStage=" + c10.au.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "HasNonMotorizedZStage=" + c10.av.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "StageIsThetaY=" + c10.aw.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "NoOptics=" + c10.ax.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "F50XY_XLimitToZeroOffset=" + c10.ae.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "F50XY_YLimitToZeroOffset=" + c10.af.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "ProhibitNonCTMOptics=" + c10.ag.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "CalcNFromExtrema=" + c10.@as.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "LowPowerLSRequired=" + c10.ah.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "DisableHighVoltage=" + c10.ai.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "IRSourceOnly=" + c10.aj.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "NeonOnly=" + c10.ak.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "LowPowerLightSourceSoftPowerUp=" + c10.al.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "ZStageHasType2Motor=" + c10.an.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "MotionInterlockExists=" + c10.am.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "SWControlledFanPresent=" + c10.ao.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "DefinitelyHas2AxisBackPlane=" + c10.az.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "HasMicropositioner=" + c10.a0.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "HasMotorizedObjectiveTurret=" + c10.bc.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "HasTipTiltFocus=" + c10.bb.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "HasPatternRecognition=" + c10.a1.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "HasNotchFlatFind=" + c10.a2.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "HasLightTower=" + c10.a4.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "LightTowerHasRed=" + c10.a5.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "LightTowerHasAmber=" + c10.a6.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "LightTowerHasGreen=" + c10.a7.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "LightTowerHasBlue=" + c10.a8.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "LightTowerHasWhite=" + c10.a9.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "HasCassetteBarcodeReader=" + c10.ba.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "HasPrealigner=" + c10.bd.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "HasInletVacuumValve=" + c10.be.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "Permit200mmWaferAdapter=" + c10.a3.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "PermitAdditionalRecipes=" + c10.bf.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "HasLED=" + c10.bg.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "HasKnifeEdge=" + c10.bh.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "HasSpectrometerForNotchFlatFind=" + c10.bi.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "HasDetailedF6XSettings=" + c10.bj.ToString(CultureInfo.InvariantCulture);
		text2 = text2 + "LinearActuatorType=" + c10.bk.ToString() + text;
		text2 = text2 + "PermitAutoWavelengthCalib=" + c10.bl.ToString(CultureInfo.InvariantCulture);
		if (string.IsNullOrEmpty(A_3))
		{
			A_2.c(fz.b.a, text2);
			text2 = null;
		}
		else
		{
			text2 += text;
		}
		text2 += "Additional settings: ";
		if (!string.IsNullOrEmpty(A_3))
		{
			text2 += text;
		}
		text2 = text2 + "SystemType=" + h6.m2(c10.bm, c10.bo, null, c10.aa) + text;
		text2 = text2 + "IsCorrupt=" + c10.i.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "DefaultNumDispCurves=" + c10.br + text;
		text2 = text2 + "DefaultOpticsConfig=" + g2.c(c10.bs) + text;
		text2 = text2 + "DefaultRefMat=" + h6.m2(c10.bp) + text;
		text2 = text2 + "SubsystemIdx=" + c10.bt.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "TotalSubSystemsInBox=" + c10.bu.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "NumControllersInSubsystem=" + c10.bv.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "MeasurementAngle=" + c10.bw.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "SubsystemsMeasTypeKnown=" + c10.bx.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "SubsystemIsTransmittance=" + c10.by.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "SubsystemPolarized=" + c10.bz.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "SubsystemPolarizationIsTM=" + c10.b0.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "MfrDate=" + c10.k.ToString(CultureInfo.InvariantCulture) + text;
		text2 = text2 + "OemCode=" + ew.a((ew.a)c10.bn) + text;
		text2 = text2 + "Update Firmware to latest rev=" + c10.h + text;
		text2 = text2 + "Firmware Rev=" + c10.f;
		if (string.IsNullOrEmpty(A_3))
		{
			A_2.c(fz.b.a, text2);
		}
		else
		{
			File.WriteAllText(Path.Combine(A_3, "Contrllr FW-" + A_1.a + " (" + A_1.b + ").txt"), text2);
		}
		c10 = null;
	}
}
