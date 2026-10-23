using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FIUsbIntLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal abstract class h6 : f0
{
	public new class a
	{
		public string a;

		public string b;

		public string c;

		public DateTime d;

		public bool e;

		public byte f;

		public int g;

		public bool h;

		public bool i;
	}

	public new enum b
	{
		a = -1,
		b,
		c
	}

	public new class c : a
	{
		public string j;

		public DateTime k;

		public float l;

		public bool m;

		public bool n;

		public bool o;

		public bool p;

		public bool q;

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

		public float ae;

		public float af;

		public bool ag;

		public bool ah;

		public bool ai;

		public bool aj;

		public bool ak;

		public bool al;

		public bool am;

		public bool an;

		public bool ao;

		public bool ap;

		public bool aq;

		public double ar;

		public bool @as;

		public bool at;

		public bool au;

		public bool av;

		public bool aw;

		public bool ax;

		public bool ay;

		public bool az;

		public bool a0;

		public bool a1;

		public bool a2;

		public bool a3;

		public bool a4;

		public bool a5;

		public bool a6;

		public bool a7;

		public bool a8;

		public bool a9;

		public bool ba;

		public bool bb;

		public bool bc;

		public bool bd;

		public bool be;

		public bool bf;

		public bool bg;

		public bool bh;

		public bool bi;

		public bool bj;

		public LinearActuatorType bk;

		public bool bl;

		public FMLegacyAllSystemTypes bm;

		public byte bn;

		public byte bo;

		public FMRefMatEnums bp;

		public int bq;

		public byte br;

		public FMOpticConfigEnums bs;

		public byte bt;

		public byte bu;

		public byte bv;

		public float bw;

		public bool bx;

		public bool by;

		public bool bz;

		public bool b0;

		public bool b1;

		public bool b2;

		public int b3;

		public bool b4;

		public int b5;

		public bool b6;

		public bool b7;

		public b b8;

		public static bool dg(c A_0, c A_1, ref string A_2)
		{
			A_2 = null;
			c c10 = A_0;
			if (c10.l != A_1.l)
			{
				A_2 = "LimitCenterDistance setting for the two controllers are not equal.";
				return true;
			}
			if (c10.m != A_1.m)
			{
				A_2 = "LayerAttr setting for the two controllers are not equal.";
				return true;
			}
			if (c10.ab != A_1.ab)
			{
				A_2 = "F40Optics setting for the two controllers are not equal.";
				return true;
			}
			if (c10.w != A_1.w)
			{
				A_2 = "FFTThicknessOnly setting for the two controllers are not equal.";
				return true;
			}
			if (c10.ac != A_1.ac)
			{
				A_2 = "F40FullSpectrum setting for the two controllers are not equal.";
				return true;
			}
			if (c10.x != A_1.x)
			{
				A_2 = "UseCorrelation setting for the two controllers are not equal.";
				return true;
			}
			if (c10.aa != A_1.aa)
			{
				A_2 = "AROption setting for the two controllers are not equal.";
				return true;
			}
			if (c10.ax != A_1.ax)
			{
				A_2 = "NoOptics setting for the two controllers are not equal.";
			}
			if (c10.o != A_1.o)
			{
				A_2 = "NKActive setting for the two controllers are not equal.";
				return true;
			}
			if (c10.p != A_1.p)
			{
				A_2 = "NKCauchyOnly setting for the two controllers are not equal.";
				return true;
			}
			if (c10.at != A_1.at)
			{
				A_2 = "PermitCompositeRecipeEx setting for the two controllers are not equal.";
				return true;
			}
			if (c10.bf != A_1.bf)
			{
				A_2 = "PermitAdditionalRecipes setting for the two controllers are not equal.";
				return true;
			}
			if (c10.ag != A_1.ag)
			{
				A_2 = "ProhibitNonCTMOptics setting for the two controllers are not equal.";
				return true;
			}
			if (c10.@as != A_1.@as)
			{
				A_2 = "CalcNFromExtrema setting for the two controllers are not equal.";
				return true;
			}
			if (c10.ay != A_1.ay)
			{
				A_2 = "XYStageExpected setting for the two controllers are not equal.";
			}
			if (c10.au != A_1.au)
			{
				A_2 = "HasMotorizedZStage setting for the two controllers are not equal.";
				return true;
			}
			if (c10.av != A_1.av)
			{
				A_2 = "HasNonMotorizedZStage setting for the two controllers are not equal.";
				return true;
			}
			if (c10.a1 != A_1.a1)
			{
				A_2 = "HasPatternRecognition setting for the two controllers are not equal.";
				return true;
			}
			if (c10.a2 != A_1.a2)
			{
				A_2 = "HasNotchFlatFind setting for the two controllers are not equal.";
				return true;
			}
			if (c10.a4 != A_1.a4)
			{
				A_2 = "HasLightTower setting for the two controllers are not equal.";
			}
			if (c10.a5 != A_1.a5)
			{
				A_2 = "LightTowerHasRed setting for the two controllers are not equal.";
			}
			if (c10.a6 != A_1.a6)
			{
				A_2 = "LightTowerHasAmber setting for the two controllers are not equal.";
			}
			if (c10.a7 != A_1.a7)
			{
				A_2 = "LightTowerHasGreen setting for the two controllers are not equal.";
			}
			if (c10.a8 != A_1.a8)
			{
				A_2 = "LightTowerHasBlue setting for the two controllers are not equal.";
			}
			if (c10.a9 != A_1.a9)
			{
				A_2 = "LightTowerHasWhite setting for the two controllers are not equal.";
			}
			if (c10.ba != A_1.ba)
			{
				A_2 = "HasCassetteBarcodeReader setting for the two controllers are not equal.";
			}
			if (c10.bd != A_1.bd)
			{
				A_2 = "HasPrealigner setting for the two controllers are not equal.";
			}
			if (c10.be != A_1.be)
			{
				A_2 = "HasInletVacuumValve setting for the two controllers are not equal.";
			}
			if (c10.bg != A_1.bg)
			{
				A_2 = "HasInletVacuumValve setting for the two controllers are not equal.";
			}
			if (c10.bh != A_1.bh)
			{
				A_2 = "HasInletVacuumValve setting for the two controllers are not equal.";
			}
			if (c10.bl != A_1.bl)
			{
				A_2 = "PermitNeonCalibration setting for the two controllers are not equal.";
			}
			if (c10.bi != A_1.bi)
			{
				A_2 = "HasInletVacuumValve setting for the two controllers are not equal.";
			}
			if (c10.bj != A_1.bj)
			{
				A_2 = "HasInletVacuumValve setting for the two controllers are not equal.";
			}
			if (c10.bk != A_1.bk)
			{
				A_2 = "LinearActuatorType setting for the two controllers are not equal.";
			}
			if (c10.a3 != A_1.a3)
			{
				A_2 = "Permit200mmWaferAdapter setting for the two controllers are not equal.";
				return true;
			}
			if (c10.aw != A_1.aw)
			{
				A_2 = "StageIsThetaY setting for the two controllers are not equal.";
				return true;
			}
			if (c10.t != A_1.t)
			{
				A_2 = "ColorOption setting for the two controllers are not equal.";
				return true;
			}
			if (c10.y != A_1.y)
			{
				A_2 = "VsTimeOption setting for the two controllers are not equal.";
				return true;
			}
			if (c10.z != A_1.z)
			{
				A_2 = "VIOption setting for the two controllers are not equal.";
				return true;
			}
			if (c10.q != A_1.q)
			{
				A_2 = "JMESave setting for the two controllers are not equal.";
				return true;
			}
			if (c10.n != A_1.n)
			{
				A_2 = "MultiLayer setting for the two controllers are not equal.";
				return true;
			}
			if (c10.r != A_1.r)
			{
				A_2 = "SpecDep setting for the two controllers are not equal.";
				return true;
			}
			if (c10.s != A_1.s)
			{
				A_2 = "FilterOption setting for the two controllers are not equal.";
				return true;
			}
			if (c10.u != A_1.u)
			{
				A_2 = "OptoValues setting for the two controllers are not equal.";
				return true;
			}
			if (c10.v != A_1.v)
			{
				A_2 = "DvdOption setting for the two controllers are not equal.";
				return true;
			}
			if (c10.ae != A_1.ae)
			{
				A_2 = "F50XY_XLimitToZeroOffset setting for the two controllers are not equal.";
				return true;
			}
			if (c10.af != A_1.af)
			{
				A_2 = "F50XY_YLimitToZeroOffset setting for the two controllers are not equal.";
				return true;
			}
			if (c10.bm != A_1.bm)
			{
				A_2 = "SystemType setting for the two controllers are not equal.";
				return true;
			}
			if (c10.bn != A_1.bn)
			{
				A_2 = "OemCode setting for the two controllers are not equal.";
				return true;
			}
			if (c10.bo != A_1.bo)
			{
				A_2 = "SystemSubType setting for the two controllers are not equal.";
				return true;
			}
			if (c10.bp != A_1.bp)
			{
				A_2 = "DefaultRefMat setting for the two controllers are not equal.";
				return true;
			}
			if (c10.bq != A_1.bq)
			{
				A_2 = "DefaultRefMatID setting for the two controllers are not equal.";
				return true;
			}
			if (c10.br != A_1.br)
			{
				A_2 = "DefaultNumDispCurves setting for the two controllers are not equal.";
				return true;
			}
			if (c10.bs != A_1.bs)
			{
				A_2 = "DefaultOpticsConfig setting for the two controllers are not equal.";
				return true;
			}
			if (c10.bz != A_1.bz)
			{
				A_2 = "SubsystemPolarized setting for the two controllers are not equal.";
				return true;
			}
			if (c10.b0 != A_1.b0)
			{
				A_2 = "SubsystemTMPolarized setting for the two controllers are not equal.";
				return true;
			}
			if (c10.bx != A_1.bx)
			{
				A_2 = "SubsystemMeasTypeKnown setting for the two controllers are not equal.";
				return true;
			}
			if (c10.by != A_1.by)
			{
				A_2 = "SubsystemIsTransmittance setting for the two controllers are not equal.";
				return true;
			}
			if (c10.bt != A_1.bt)
			{
				A_2 = "SubsystemIdx setting for the two controllers are not equal.";
				return true;
			}
			if (c10.bu != A_1.bu)
			{
				A_2 = "TotalSubsystemsInBox setting for the two controllers are not equal.";
				return true;
			}
			if (c10.bv != A_1.bv)
			{
				A_2 = "NumControllersInSubsystem setting for the two controllers are not equal.";
				return true;
			}
			if (c10.bw != A_1.bw)
			{
				A_2 = "MeasurementAngle setting for the two controllers are not equal.";
				return true;
			}
			if (c10.az != A_1.az)
			{
				A_2 = "DefinitelyHas2AxisBackPlane setting for the two controllers are not equal.";
				return true;
			}
			if (c10.a0 != A_1.a0)
			{
				A_2 = "HasMicropositioner setting for the two controllers are not equal.";
				return true;
			}
			if (c10.bb != A_1.bb)
			{
				A_2 = "HasTipTiltFocus setting for the two controllers are not equal.";
			}
			if (c10.bc != A_1.bc)
			{
				A_2 = "HasMotorizedObjectiveTurret setting for the two controllers are not equal.";
			}
			c10 = null;
			return false;
		}

		public void dg(ref c A_0)
		{
			A_0 = null;
			A_0 = new c();
			c obj = A_0;
			obj.a = a;
			obj.d = d;
			obj.e = e;
			obj.f = f;
			obj.g = g;
			obj.h = h;
			obj.i = i;
			obj.j = j;
			obj.k = k;
			obj.b = b;
			obj.l = l;
			obj.m = m;
			obj.ab = ab;
			obj.ad = ad;
			obj.w = w;
			obj.ac = ac;
			obj.ax = ax;
			obj.x = x;
			obj.aa = aa;
			obj.o = o;
			obj.p = p;
			obj.at = at;
			obj.ag = ag;
			obj.bf = bf;
			obj.ah = ah;
			obj.ai = ai;
			obj.aj = aj;
			obj.ak = ak;
			obj.al = al;
			obj.an = an;
			obj.am = am;
			obj.ao = ao;
			obj.ap = ap;
			obj.aq = aq;
			obj.ar = ar;
			obj.@as = @as;
			obj.ay = ay;
			obj.au = au;
			obj.av = av;
			obj.a1 = a1;
			obj.a2 = a2;
			obj.a4 = a4;
			obj.a5 = a5;
			obj.a6 = a6;
			obj.a7 = a7;
			obj.a8 = a8;
			obj.a9 = a9;
			obj.ba = ba;
			obj.bd = bd;
			obj.be = be;
			obj.bg = bg;
			obj.bh = bh;
			obj.bl = bl;
			obj.bi = bi;
			obj.bj = bj;
			obj.bk = bk;
			obj.a3 = a3;
			obj.aw = aw;
			obj.t = t;
			obj.y = y;
			obj.z = z;
			obj.q = q;
			obj.n = n;
			obj.r = r;
			obj.s = s;
			obj.u = u;
			obj.v = obj.v;
			obj.ae = ae;
			obj.af = af;
			obj.bm = bm;
			obj.bn = bn;
			obj.bo = bo;
			obj.bp = bp;
			obj.bq = bq;
			obj.br = br;
			obj.bs = bs;
			obj.bz = bz;
			obj.b0 = b0;
			obj.bx = bx;
			obj.by = by;
			obj.bt = bt;
			obj.bu = bu;
			obj.bv = bv;
			obj.bw = bw;
			obj.b2 = b2;
			obj.b3 = b3;
			obj.b4 = b4;
			obj.b5 = b5;
			obj.b6 = b6;
			obj.az = az;
			obj.a0 = a0;
			obj.bb = bb;
			obj.bc = bc;
			_ = null;
		}

		public void dg(c A_0)
		{
			c c10 = A_0;
			if (l != c10.l)
			{
				l = c10.l;
			}
			if (m != c10.m)
			{
				m = c10.m;
			}
			if (ab != c10.ab)
			{
				ab = c10.ab;
			}
			if (w != c10.w)
			{
				w = c10.w;
			}
			if (ac != c10.ac)
			{
				ac = c10.ac;
			}
			if (ax != c10.ax)
			{
				ax = c10.ax;
			}
			if (x != c10.x)
			{
				x = c10.x;
			}
			if (aa != c10.aa)
			{
				aa = c10.aa;
			}
			if (o != c10.o)
			{
				o = c10.o;
			}
			if (p != c10.p)
			{
				p = c10.p;
			}
			if (ag != c10.ag)
			{
				ag = c10.ag;
			}
			if (@as != c10.@as)
			{
				@as = c10.@as;
			}
			if (at != c10.at)
			{
				at = c10.at;
			}
			if (bf != c10.bf)
			{
				bf = c10.bf;
			}
			if (ay != c10.ay)
			{
				ay = c10.ay;
			}
			if (au != c10.au)
			{
				au = c10.au;
			}
			if (av != c10.av)
			{
				av = c10.av;
			}
			if (a1 != c10.a1)
			{
				a1 = c10.a1;
			}
			if (a2 != c10.a2)
			{
				a2 = c10.a2;
			}
			if (a4 != c10.a4)
			{
				a4 = c10.a4;
			}
			if (a5 != c10.a5)
			{
				a5 = c10.a5;
			}
			if (a6 != c10.a6)
			{
				a6 = c10.a6;
			}
			if (a7 != c10.a7)
			{
				a7 = c10.a7;
			}
			if (a8 != c10.a8)
			{
				a8 = c10.a8;
			}
			if (a9 != c10.a9)
			{
				a9 = c10.a9;
			}
			if (ba != c10.ba)
			{
				ba = c10.ba;
			}
			if (bd != c10.bd)
			{
				bd = c10.bd;
			}
			if (be != c10.be)
			{
				be = c10.be;
			}
			if (bg != c10.bg)
			{
				bg = c10.bg;
			}
			if (bh != c10.bh)
			{
				bh = c10.bh;
			}
			if (bi != c10.bi)
			{
				bi = c10.bi;
			}
			if (bk != c10.bk)
			{
				bk = c10.bk;
			}
			if (bl != c10.bl)
			{
				bl = c10.bl;
			}
			if (bj != c10.bj)
			{
				bj = c10.bj;
			}
			if (a3 != c10.a3)
			{
				a3 = c10.a3;
			}
			if (aw != c10.aw)
			{
				aw = c10.aw;
			}
			if (t != c10.t)
			{
				t = c10.t;
			}
			if (y != c10.y)
			{
				y = c10.y;
			}
			if (z != c10.z)
			{
				z = c10.z;
			}
			if (q != c10.q)
			{
				q = c10.q;
			}
			if (n != c10.n)
			{
				n = c10.n;
			}
			if (r != c10.r)
			{
				r = c10.r;
			}
			if (s != c10.s)
			{
				s = c10.s;
			}
			if (u != c10.u)
			{
				u = c10.u;
			}
			if (v != c10.v)
			{
				v = c10.v;
			}
			if (ae != c10.ae)
			{
				ae = c10.ae;
			}
			if (af != c10.af)
			{
				af = c10.af;
			}
			if (bm != c10.bm)
			{
				bm = c10.bm;
			}
			if (bn != c10.bn)
			{
				bn = c10.bn;
			}
			if (bo != c10.bo)
			{
				bo = c10.bo;
			}
			if (bp != c10.bp)
			{
				bp = c10.bp;
			}
			if (bq != c10.bq)
			{
				bq = c10.bq;
			}
			if (br != c10.br)
			{
				br = c10.br;
			}
			if (bs != c10.bs)
			{
				bs = c10.bs;
			}
			if (bz != c10.bz)
			{
				bz = c10.bz;
			}
			if (b0 != c10.b0)
			{
				b0 = c10.b0;
			}
			if (bx != c10.bx)
			{
				bx = c10.bx;
			}
			if (by != c10.by)
			{
				by = c10.by;
			}
			if (bt != c10.bt)
			{
				bt = c10.bt;
			}
			if (bu != c10.bu)
			{
				bu = c10.bu;
			}
			if (bv != c10.bv)
			{
				bv = c10.bv;
			}
			if (bw != c10.bw)
			{
				bw = c10.bw;
			}
			if (az != c10.az)
			{
				az = c10.az;
			}
			if (a0 != c10.a0)
			{
				a0 = c10.a0;
			}
			if (bc != c10.bc)
			{
				bc = c10.bc;
			}
			if (bb != c10.bb)
			{
				bb = c10.bb;
			}
			c10 = null;
		}
	}

	public new class d
	{
		public string a;

		public bool b;
	}

	public enum InternalFWLicenseRequiredReason
	{
		NoConnectedDevices,
		DeviceValidationFailure,
		ControllerValidationFailure,
		AccessoryOnly,
		MissingLightSource,
		MissingSubSystem,
		ConflictingSubSystems,
		ControllerWithMissingDevices,
		InitializingMotorController,
		MotorBaudRateModified,
		TestingDOUTToDINConnection,
		InitializeLinearMotor,
		SettingLinearMicrostepResolution,
		SettingLinearSoftStopFlag,
		InitializingRotaryMotor,
		SettingRotaryMicrostepResolution,
		SettingRotarySoftStopFlag,
		InitializingZMotor,
		SettingZMicrostepResolution,
		SettingZSoftStopFlag,
		InitializingYMotor,
		SettingYMicrostepResolution,
		SettingYSoftStopFlag,
		InitializingXMotor,
		SettingXMicrostepResolution,
		SettingXSoftStopFlag,
		EnergizingMotors,
		USBFirmwareNeedsUpdate,
		MisProgrammedMinIntTime,
		InitializingWaferHandler,
		InitializingPrealigner,
		InsufficientVacuum,
		MissingHardware,
		NotchFlatFindSpectrometerNotFound,
		NotchFlatFindSpectrometerUnexpected,
		NotchFlatFindSpectrometerOrphan,
		MisprogrammedControllerSN
	}

	public enum LinearActuatorType : byte
	{
		Legacy,
		Hiwin,
		Reserved1,
		Reserved2
	}

	public new class e
	{
		public int a;

		public string b;

		public string c;

		public byte d;

		public int e;

		public string f;

		public FMLegacyAllSystemTypes g;

		public byte h;

		public bool i;

		public bool k()
		{
			return k(g);
		}

		public static bool k(FMLegacyAllSystemTypes A_0)
		{
			if (A_0 != FMLegacyAllSystemTypes.kTypeUVSource && A_0 != FMLegacyAllSystemTypes.kTypeHnl)
			{
				return A_0 != FMLegacyAllSystemTypes.kTypeOpticalAcc;
			}
			return false;
		}

		public bool l()
		{
			if (g != FMLegacyAllSystemTypes.kTypeUVSource && g != FMLegacyAllSystemTypes.kTypeHnl)
			{
				return g != FMLegacyAllSystemTypes.kTypeOpticalAcc;
			}
			return false;
		}

		[SpecialName]
		public byte m()
		{
			if (l())
			{
				return d;
			}
			return 0;
		}

		[SpecialName]
		public void k(byte A_0)
		{
			d = A_0;
		}
	}

	private FIUsbController ij;

	private string l0;

	private string l1;

	private int l3;

	private int l4;

	private string l5;

	public const string l6 = "ScattCal_";

	public const string l7 = "ScattCal_1";

	public const string l8 = "ScattCal_2";

	public const string l9 = "ScattCal_3";

	protected string ma;

	protected int mb;

	protected int mc;

	protected string md;

	private const string me = "Unknown";

	private const string mf = "F20";

	private const string mg = "F30";

	private const string mh = "F40";

	private const string mi = "F50-200";

	private const string mj = "F76";

	private const string mk = "Special";

	private const string ml = "F10";

	private const string mm = "F70";

	private const string mn = "F50-300";

	private const string mo = "F75";

	private const string mp = "F50XY-450";

	private const string mq = "F80Off-200";

	private const string mr = "F80On-200";

	private const string ms = "F80Off-300";

	private const string mt = "F80On-300";

	private const string mu = "F50XY-200";

	private const string mv = "F50-200 Rev. B";

	private const string mw = "F50-300 Rev. B";

	private const string mx = "F50-450 Rev. B";

	private const string my = "F20_F40";

	private const string mz = "F80";

	private const string m0 = "F42";

	private const string m1 = "Oxford OSP";

	private new const string m_m2 = "F32";

	private const string m3 = "F37";

	private const string m4 = "F40-NSR";

	private const string m5 = "PARTS";

	private const string m6 = "F50-XY-510";

	private const string m7 = "F50-XY-10";

	private const string m8 = "UV Source";

	private const string m9 = "F2";

	private const string na = "F3";

	private const string nb = "S3";

	private const string nc = "Optical Accessory";

	private const string nd = "F60 Class";

	private const string ne = "Heraeus Device";

	private const byte nf = 128;

	private const byte ng = 64;

	private const byte nh = 32;

	private const byte ni = 16;

	private const byte nj = 8;

	private const byte nk = 4;

	private const byte nl = 2;

	private const byte nm = 1;

	private const byte nn = 128;

	private const byte no = 64;

	private const byte np = 32;

	private const byte nq = 16;

	private const byte nr = 8;

	private const byte ns = 4;

	private const byte nt = 3;

	private const byte nu = 128;

	private const byte nv = 64;

	private const byte nw = 32;

	private const byte nx = 16;

	private const byte ny = 8;

	private const byte nz = 4;

	private const byte n0 = 2;

	private const byte n1 = 1;

	private const byte n2 = 128;

	private const byte n3 = 64;

	private const byte n4 = 32;

	private const byte n5 = 16;

	private const byte n6 = 8;

	private const byte n7 = 4;

	private const byte n8 = 2;

	private const byte n9 = 1;

	private const byte oa = 128;

	private const byte ob = 64;

	private const byte oc = 32;

	private const byte od = 16;

	private const byte oe = 8;

	private const byte of = 4;

	private const byte og = 2;

	private const byte oh = 1;

	private const byte oi = 128;

	private const byte oj = 64;

	private const byte ok = 32;

	private const byte ol = 16;

	private const byte om = 8;

	private const byte on = 4;

	private const byte oo = 2;

	private const byte op = 1;

	private const byte oq = 128;

	private const byte or = 64;

	private const byte os = 32;

	private const byte ot = 16;

	private const byte ou = 8;

	private const byte ov = 4;

	private const byte ow = 2;

	private const byte ox = 1;

	private const byte oy = 128;

	private const byte oz = 64;

	private const byte o0 = 32;

	private const byte o1 = 16;

	private const byte o2 = 8;

	private const byte o3 = 4;

	private const byte o4 = 2;

	private const byte o5 = 1;

	private const byte o6 = 2;

	private const byte o7 = 1;

	private const float o8 = 30000f;

	[SpecialName]
	private bool o9;

	[SpecialName]
	private bool pa;

	[SpecialName]
	private bool pb;

	[SpecialName]
	private bool pc;

	[SpecialName]
	private bool pd;

	[SpecialName]
	private bool pe;

	[SpecialName]
	private bool pf;

	[SpecialName]
	private bool pg;

	[SpecialName]
	private bool ph;

	[SpecialName]
	private bool pi;

	[SpecialName]
	private bool pj;

	[SpecialName]
	private bool pk;

	[SpecialName]
	private bool pl;

	[SpecialName]
	private bool pm;

	[SpecialName]
	private bool pn;

	[SpecialName]
	private bool po;

	[SpecialName]
	private bool pp;

	[SpecialName]
	private bool pq;

	[SpecialName]
	private bool pr;

	[SpecialName]
	private bool ps;

	[SpecialName]
	private bool pt;

	[SpecialName]
	private bool pu;

	[SpecialName]
	private bool pv;

	[SpecialName]
	private bool pw;

	[SpecialName]
	private bool px;

	[SpecialName]
	private bool py;

	[SpecialName]
	private bool pz;

	[SpecialName]
	private bool p0;

	[SpecialName]
	private bool p1;

	[SpecialName]
	private bool p2;

	[SpecialName]
	private bool p3;

	[SpecialName]
	private bool p4;

	[SpecialName]
	private bool p5;

	[SpecialName]
	private bool p6;

	[SpecialName]
	private bool p7;

	[SpecialName]
	private bool p8;

	[SpecialName]
	private bool m_p9;

	[SpecialName]
	private bool qa;

	[SpecialName]
	private bool qb;

	[SpecialName]
	private bool qc;

	[SpecialName]
	private bool qd;

	[SpecialName]
	private bool qe;

	[SpecialName]
	public bool yt()
	{
		return (t5(1) & 0x80) == 128;
	}

	[SpecialName]
	public bool yu()
	{
		return (t5(1) & 0x40) == 64;
	}

	[SpecialName]
	public bool yv()
	{
		if (a2.a.c(abn(), abo(), i7.e.k))
		{
			return false;
		}
		if (yu())
		{
			return true;
		}
		return a2.a.c(abn(), abo(), i7.e.n);
	}

	[SpecialName]
	public bool yw()
	{
		if (y6())
		{
			return true;
		}
		return a2.a.c(abn(), abo(), i7.e.am);
	}

	[SpecialName]
	public bool yx()
	{
		return a2.a.c(abn(), abo(), i7.e.at);
	}

	[SpecialName]
	public bool yy()
	{
		if (y7())
		{
			return true;
		}
		return a2.a.c(abn(), abo(), i7.e.an);
	}

	[SpecialName]
	public bool yz()
	{
		return (t5(1) & 0x10) == 16;
	}

	[SpecialName]
	public bool y0()
	{
		return (t5(1) & 8) == 8;
	}

	[SpecialName]
	public bool y1()
	{
		return (t5(1) & 4) == 4;
	}

	[SpecialName]
	public bool y2()
	{
		return (t5(1) & 1) == 1;
	}

	[SpecialName]
	public bool y3()
	{
		return (t5(2) & 0x80) == 128;
	}

	[SpecialName]
	public bool y4()
	{
		return (t5(2) & 0x10) == 16;
	}

	[SpecialName]
	public bool y5()
	{
		return (t5(3) & 0x20) == 32;
	}

	[SpecialName]
	public bool y6()
	{
		return (t5(2) & 8) == 8;
	}

	[SpecialName]
	public bool y7()
	{
		return (t5(2) & 4) == 4;
	}

	[SpecialName]
	public int y8()
	{
		return t5(2) & 3;
	}

	[SpecialName]
	public bool y9()
	{
		return (t5(1) & 0x20) == 32;
	}

	[SpecialName]
	public bool za()
	{
		return (t5(3) & 0x10) == 16;
	}

	[SpecialName]
	public bool zb()
	{
		if (y9())
		{
			return true;
		}
		if (za())
		{
			return true;
		}
		if (DateTime.Compare(ij.FWLastUpdate, new DateTime(633015648010000000L)) <= 0)
		{
			switch (ij.FWInstTypeCodeAsEnum)
			{
			case FMLegacyAllSystemTypes.kTypeF20:
			case FMLegacyAllSystemTypes.kTypeF30:
			case FMLegacyAllSystemTypes.kTypeF50_200B:
			case FMLegacyAllSystemTypes.kTypeF50_300B:
			case FMLegacyAllSystemTypes.kTypeF50_450B:
				return true;
			}
		}
		return a2.a.c(abn(), abo(), i7.e.f);
	}

	[SpecialName]
	public bool zc()
	{
		if (za())
		{
			return true;
		}
		return a2.a.c(abn(), abo(), i7.e.ak);
	}

	[SpecialName]
	public bool zd()
	{
		return a2.a.c(abn(), abo(), i7.e.al);
	}

	[SpecialName]
	public bool ze()
	{
		return (t5(3) & 8) == 8;
	}

	[SpecialName]
	public bool zf()
	{
		return (t5(2) & 0x40) == 64;
	}

	[SpecialName]
	public bool zg()
	{
		if (zf())
		{
			return true;
		}
		FMLegacyAllSystemTypes fWInstTypeCodeAsEnum = ij.FWInstTypeCodeAsEnum;
		if (fWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF20 || fWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF20_F40 || fWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF30 || fWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF32 || fWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF37 || fWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF40 || fWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF40NSR || fWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF50_200 || fWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF50_200B || fWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF50_300 || fWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF50_300B || fWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF50_450B || fWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF50XY_10 || fWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF50XY_200 || fWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF50XY_450 || fWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF50XY_510 || fWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypePARTS)
		{
			return true;
		}
		return a2.a.c(abn(), abo(), i7.e.e);
	}

	[SpecialName]
	public bool zh()
	{
		return (t5(3) & 0x40) != 0;
	}

	[SpecialName]
	public bool zi()
	{
		if (a2.a.e(i7.e.au))
		{
			return false;
		}
		if (zh())
		{
			return true;
		}
		return a2.a.c(abn(), abo(), i7.e.j);
	}

	[SpecialName]
	public bool zj()
	{
		return (t5(3) & 2) != 0;
	}

	[SpecialName]
	public bool zk()
	{
		if (o9)
		{
			return pa;
		}
		pa = zj() || a2.a.c(abn(), abo(), i7.e.ar);
		o9 = true;
		return pa;
	}

	[SpecialName]
	public bool zl()
	{
		return (t5(9) & 0x40) != 0;
	}

	[SpecialName]
	public bool zm()
	{
		return (t5(9) & 0x20) != 0;
	}

	[SpecialName]
	public bool zn()
	{
		return (t5(3) & 1) != 0;
	}

	[SpecialName]
	public bool zo()
	{
		if (pb)
		{
			return pc;
		}
		pc = zn() || a2.a.c(abn(), abo(), i7.e.ap) || a2.a.c((string)null, (string)null, i7.e.ay);
		pb = true;
		return pc;
	}

	[SpecialName]
	public bool zp()
	{
		return (t5(6) & 0x20) != 0;
	}

	[SpecialName]
	public bool zq()
	{
		if (pd)
		{
			return pe;
		}
		pe = zp() || a2.a.c(abn(), abo(), i7.e.a1) || a2.a.c((string)null, (string)null, i7.e.a2);
		pd = true;
		return pe;
	}

	[SpecialName]
	public bool zr()
	{
		return (t5(6) & 0x40) != 0;
	}

	[SpecialName]
	public bool zs()
	{
		if (pf)
		{
			return pg;
		}
		pg = zr() || a2.a.c(abn(), abo(), i7.e.a3);
		pf = true;
		return pg;
	}

	[SpecialName]
	public bool zt()
	{
		return (t5(6) & 0x80) != 0;
	}

	[SpecialName]
	public bool zu()
	{
		if (ph)
		{
			return pi;
		}
		pi = zt() || a2.a.c(abn(), abo(), i7.e.a4);
		ph = true;
		return pi;
	}

	[SpecialName]
	private bool sj()
	{
		return (t5(7) & 1) != 0;
	}

	[SpecialName]
	public bool zv()
	{
		if (pj)
		{
			return pk;
		}
		pk = sj() || a2.a.c(abn(), abo(), i7.e.a5);
		pj = true;
		return pk;
	}

	[SpecialName]
	public bool zw()
	{
		return (t5(5) & 2) != 0;
	}

	[SpecialName]
	public bool zx()
	{
		return (t5(5) & 1) != 0;
	}

	[SpecialName]
	public bool zy()
	{
		if (pl)
		{
			return pm;
		}
		pm = zx() || a2.a.c(abn(), abo(), i7.e.av);
		pl = true;
		return pm;
	}

	[SpecialName]
	public bool zz()
	{
		return (t5(6) & 2) != 0;
	}

	[SpecialName]
	public bool z0()
	{
		if (pn)
		{
			return po;
		}
		po = zz() || a2.a.c(abn(), abo(), i7.e.ax);
		pn = true;
		return po;
	}

	[SpecialName]
	public bool z1()
	{
		return (t5(6) & 1) != 0;
	}

	[SpecialName]
	public bool z2()
	{
		if (pp)
		{
			return pq;
		}
		pq = z1() || a2.a.c((string)null, (string)null, i7.e.aw);
		pp = true;
		return pq;
	}

	[SpecialName]
	public bool z3()
	{
		return (t5(6) & 4) != 0;
	}

	[SpecialName]
	public bool z4()
	{
		if (pr)
		{
			return ps;
		}
		ps = z3() || a2.a.c((string)null, (string)null, i7.e.az);
		pr = true;
		return ps;
	}

	[SpecialName]
	public bool z5()
	{
		return (t5(9) & 0x80) != 0;
	}

	[SpecialName]
	public bool z6()
	{
		if (pt)
		{
			return pu;
		}
		pu = z5() || a2.a.c(abn(), abo(), i7.e.bg);
		pt = true;
		return pu;
	}

	[SpecialName]
	private bool qh()
	{
		return (t5(10) & 2) != 0;
	}

	[SpecialName]
	private bool p9()
	{
		return (t5(10) & 1) != 0;
	}

	[SpecialName]
	public bool z7()
	{
		return m2(ab0(), abx(), qh());
	}

	public static bool m2(bool A_0, bool A_1, bool A_2)
	{
		if (A_0)
		{
			if (A_1)
			{
				return A_2;
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	public bool z8()
	{
		if (pv)
		{
			return pw;
		}
		pw = !abx() || (qh() && (!p9() || a2.a.c(abn(), abo(), i7.e.bh)));
		pv = true;
		return pw;
	}

	[SpecialName]
	public bool z9()
	{
		return (t5(7) & 4) != 0;
	}

	[SpecialName]
	public bool aaa()
	{
		if (px)
		{
			return py;
		}
		py = z9() || a2.a.c((string)null, (string)null, i7.e.a7);
		px = true;
		return py;
	}

	[SpecialName]
	public bool aab()
	{
		return (t5(7) & 8) != 0;
	}

	[SpecialName]
	public bool aac()
	{
		if (pz)
		{
			return p0;
		}
		p0 = aab() || a2.a.c((string)null, (string)null, i7.e.a8);
		pz = true;
		return p0;
	}

	[SpecialName]
	public bool aad()
	{
		return (t5(1) & 2) != 0;
	}

	[SpecialName]
	public bool aae()
	{
		return (t5(7) & 0x20) != 0;
	}

	[SpecialName]
	public bool aaf()
	{
		if (p1)
		{
			return p2;
		}
		p2 = aae() || a2.a.c(abn(), abo(), i7.e.ba);
		p1 = true;
		return p2;
	}

	[SpecialName]
	public bool aag()
	{
		return (t5(7) & 0x10) != 0;
	}

	[SpecialName]
	public bool aah()
	{
		if (p3)
		{
			return p4;
		}
		p4 = aag() || a2.a.c((string)null, (string)null, i7.e.a9);
		p3 = true;
		return p4;
	}

	[SpecialName]
	public bool aai()
	{
		return (t5(8) & 1) != 0;
	}

	[SpecialName]
	public bool aaj()
	{
		return (t5(8) & 2) != 0;
	}

	[SpecialName]
	public bool aak()
	{
		return (t5(8) & 4) != 0;
	}

	[SpecialName]
	public bool aal()
	{
		return (t5(8) & 8) != 0;
	}

	[SpecialName]
	public bool aam()
	{
		return (t5(8) & 0x10) != 0;
	}

	[SpecialName]
	public bool aan()
	{
		return (t5(8) & 0x20) != 0;
	}

	[SpecialName]
	public bool aao()
	{
		if (p5)
		{
			return p6;
		}
		p6 = aan() || a2.a.c((string)null, (string)null, i7.e.bb);
		p5 = true;
		return p6;
	}

	[SpecialName]
	public bool aap()
	{
		return (t5(8) & 0x40) != 0;
	}

	[SpecialName]
	public bool aaq()
	{
		if (p7)
		{
			return p8;
		}
		p8 = aap();
		p7 = true;
		return p8;
	}

	[SpecialName]
	public bool aar()
	{
		return (t5(8) & 0x80) != 0;
	}

	[SpecialName]
	public bool aas()
	{
		if (this.m_p9)
		{
			return qa;
		}
		qa = aar() || (!aax() && b() == FMLegacyAllSystemTypes.kTypeF60);
		this.m_p9 = true;
		return qa;
	}

	[SpecialName]
	public bool aat()
	{
		return (t5(9) & 1) != 0;
	}

	[SpecialName]
	public bool aau()
	{
		if (qb)
		{
			return qc;
		}
		qc = aat() || (!aax() && b() == FMLegacyAllSystemTypes.kTypeF60);
		qb = true;
		return qc;
	}

	[SpecialName]
	public bool aav()
	{
		return (t5(9) & 2) != 0;
	}

	[SpecialName]
	public bool aaw()
	{
		if (qd)
		{
			return qe;
		}
		qe = aav();
		qd = true;
		return qe;
	}

	[SpecialName]
	public bool aax()
	{
		return (t5(9) & 4) != 0;
	}

	[SpecialName]
	public LinearActuatorType aay()
	{
		int num = t5(9) & 8;
		byte b10 = (byte)(t5(9) & 0x10);
		return (LinearActuatorType)((uint)checked((byte)unchecked((uint)(num + b10))) >> 3);
	}

	[SpecialName]
	public bool aaz()
	{
		if (aad() || (zi() && DateTime.Compare(ij.FWMfrDate, new DateTime(2008, 6, 23)) < 0))
		{
			return true;
		}
		return a2.a.c(abn(), abo(), i7.e.m);
	}

	[SpecialName]
	public bool aa0()
	{
		return a2.a.c(abn(), abo(), i7.e.v);
	}

	[SpecialName]
	public bool aa1()
	{
		return (t5(7) & 0x40) != 0;
	}

	[SpecialName]
	public bool aa2()
	{
		if (aa1())
		{
			return true;
		}
		return a2.a.c(abn(), abo(), i7.e.a0);
	}

	[SpecialName]
	public bool aa3()
	{
		return (t5(7) & 0x80) != 0;
	}

	[SpecialName]
	public bool aa4()
	{
		if (aa3())
		{
			return true;
		}
		return a2.a.e(i7.e.bc);
	}

	[SpecialName]
	public bool aa5()
	{
		if (y2())
		{
			return true;
		}
		return a2.a.c(abn(), abo(), i7.e.bd);
	}

	[SpecialName]
	public bool aa6()
	{
		return a2.a.c(abn(), abo(), i7.e.u);
	}

	[SpecialName]
	public float aa7()
	{
		return 30000f;
	}

	[SpecialName]
	public float aa8()
	{
		return 100000000f;
	}

	[SpecialName]
	public bool aa9()
	{
		return (t5(2) & 0x20) == 32;
	}

	[SpecialName]
	public bool aba()
	{
		if (aa9())
		{
			return true;
		}
		return a2.a.j();
	}

	[SpecialName]
	public int abb()
	{
		return l3;
	}

	[SpecialName]
	public int abc()
	{
		return l4;
	}

	[SpecialName]
	public string abd()
	{
		return l5;
	}

	[SpecialName]
	public bool abe()
	{
		return (t5(3) & 0x80) == 128;
	}

	[SpecialName]
	public bool abf()
	{
		return (t5(5) & 0x80) == 128;
	}

	[SpecialName]
	public bool abg()
	{
		return (t5(5) & 0x40) == 64;
	}

	[SpecialName]
	public float abh()
	{
		return ij.FWMeasurementAngle;
	}

	[SpecialName]
	public bool abi()
	{
		return (t5(5) & 0x20) == 32;
	}

	[SpecialName]
	public bool abj()
	{
		return (t5(5) & 0x10) == 16;
	}

	protected void tl(int A_0)
	{
		l3 = A_0;
	}

	protected void t0(int A_0)
	{
		l4 = A_0;
	}

	protected void qh(string A_0)
	{
		l5 = A_0;
	}

	public static FIDeviceErr m2(Collection<f0> A_0, Collection<f0> A_1, fz A_2, ref bool A_3, ref InternalFWLicenseRequiredReason A_4, ref bool A_5, ref string A_6, r.c A_7)
	{
		byte A_8 = default(byte);
		return m2(A_0, A_1, ref A_8, A_2, ref A_3, ref A_4, ref A_5, A_7: false, ref A_6, A_7, A_10: false);
	}

	public static FIDeviceErr m2(ref byte A_0, fz A_1)
	{
		bool A_2 = false;
		InternalFWLicenseRequiredReason A_3 = InternalFWLicenseRequiredReason.NoConnectedDevices;
		bool A_4 = false;
		string A_5 = null;
		return m2(null, null, ref A_0, A_1, ref A_2, ref A_3, ref A_4, A_7: true, ref A_5, null, A_10: false);
	}

	public static FIDeviceErr m2(ref Collection<h6> A_0, ref Collection<h6> A_1, ref byte A_2, fz A_3, bool A_4, ref bool A_5, ref InternalFWLicenseRequiredReason A_6, ref bool A_7, ref string A_8)
	{
		Collection<f0> collection = new Collection<f0>();
		switch (m2(null, collection, ref A_2, A_3, ref A_5, ref A_6, ref A_7, A_4, ref A_8, null, A_10: true))
		{
		case FIDeviceErr.USBFirmwareNeedsUpdate:
			return FIDeviceErr.USBFirmwareNeedsUpdate;
		case FIDeviceErr.USBDeviceHardwareFailure:
			return FIDeviceErr.USBDeviceHardwareFailure;
		default:
			A_0 = new Collection<h6>();
			A_1 = new Collection<h6>();
			foreach (h6 item in collection)
			{
				if (item is h5)
				{
					A_1.Add(item);
				}
				else
				{
					A_0.Add(item);
				}
			}
			return FIDeviceErr.None;
		}
	}

	private static FIDeviceErr m2(fz A_0, ref FMusbEnum A_1, ref Collection<e> A_2, ref List<e> A_3)
	{
		string left = null;
		bool flag;
		FMUSBIntErr eErrCode = default(FMUSBIntErr);
		FMUSBDeviceType eDeviceType = default(FMUSBDeviceType);
		byte ucDeviceRevLevel = default(byte);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		do
		{
			flag = false;
			A_1 = (FMusbEnum)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("BB8E1A15-4E65-45FA-9DE6-876792487AF7")));
			A_2 = new Collection<e>();
			byte b10 = 0;
			do
			{
				e e10 = new e();
				e e11 = e10;
				e11.a = b10;
				FMusbEnum obj = A_1;
				byte lControllerIdx = b10;
				ref string deviceSN = ref e11.b;
				ref string deviceFriendlySN = ref e11.c;
				e e12;
				byte ucSubsystemIdx = (e12 = e11).m();
				obj.EnumerateController2(lControllerIdx, ref eErrCode, ref deviceSN, ref deviceFriendlySN, ref eDeviceType, ref ucDeviceRevLevel, ref ucSubsystemIdx, ref e11.g, ref e11.h);
				e12.k(ucSubsystemIdx);
				int num;
				switch (eErrCode)
				{
				case FMUSBIntErr.kFMUSBIntErrControllerFWOutOfDate:
					return FIDeviceErr.USBFirmwareNeedsUpdate;
				default:
					num = (m2(eErrCode) ? 1 : 0);
					break;
				case FMUSBIntErr.kFMUSBIntErrNoErr:
					num = 0;
					break;
				}
				bool flag2 = (byte)num != 0;
				checked
				{
					if (eErrCode == FMUSBIntErr.kFMUSBIntErrNoErr || flag2)
					{
						if (flag2)
						{
							e11.i = true;
						}
						if (m2(e11.g))
						{
							if (A_3 == null)
							{
								A_3 = new List<e>();
							}
							A_3.Add(e10);
						}
						else
						{
							A_2.Add(e10);
						}
						b10 = (byte)unchecked((uint)(b10 + 1));
						flag3 = false;
						flag = false;
						if (flag4 && Operators.CompareString(left, e10.b, TextCompare: false) == 0)
						{
							flag4 = false;
						}
					}
					else if (eErrCode != FMUSBIntErr.kFMUSBIntErrFailedToOpenDevice)
					{
						if (flag3)
						{
							A_0.c(fz.b.a, "Failure to build USBSubSystem List. Error=" + eErrCode, Environment.StackTrace);
							return FIDeviceErr.USBEnumError;
						}
						if (eErrCode == FMUSBIntErr.kFMUSBIntErrControllerFWOutOfDateFWFlushSupported || eErrCode == FMUSBIntErr.kFMUSBIntErrControllerBareFWOutOfDateFWFlushSupported)
						{
							if (eErrCode == FMUSBIntErr.kFMUSBIntErrControllerBareFWOutOfDateFWFlushSupported)
							{
								Process process = new Process();
								if (Environment.Is64BitOperatingSystem)
								{
									process.StartInfo.FileName = "\\\\DC\\Server2\\Shares\\Programmer\\Read Only\\Released Versions\\USBPortDriver\\Install Bare Drivers64.bat";
								}
								else
								{
									process.StartInfo.FileName = "\\\\DC\\Server2\\Shares\\Programmer\\Read Only\\Released Versions\\USBPortDriver\\Install Bare Drivers32.bat";
								}
								if (!File.Exists(process.StartInfo.FileName))
								{
									A_0.c(fz.b.a, "Bare USB Driver is out of date, but batch file to update it is not available.");
									return FIDeviceErr.USBFirmwareNeedsUpdate;
								}
								c1 obj2 = new c1();
								obj2.a(A_0: false);
								obj2.TopMost = true;
								obj2.d("Updating drivers, please wait...");
								_ = null;
								process.StartInfo.UseShellExecute = false;
								process.Start();
								process.WaitForExit();
								obj2.Hide();
								obj2.Dispose();
								process = null;
							}
							left = e10.b;
							flag4 = true;
						}
						A_1.ResetMicro(b10);
						flag3 = true;
						flag = true;
					}
					e11 = null;
				}
			}
			while (eErrCode == FMUSBIntErr.kFMUSBIntErrNoErr);
			if (flag || flag4)
			{
				A_1.Close();
				A_1 = null;
			}
		}
		while (flag || flag4);
		return FIDeviceErr.None;
	}

	private static FIDeviceErr m2(Collection<f0> A_0, Collection<f0> A_1, ref byte A_2, fz A_3, ref bool A_4, ref InternalFWLicenseRequiredReason A_5, ref bool A_6, bool A_7, ref string A_8, r.c A_9, bool A_10)
	{
		FMusbEnum A_11 = null;
		Collection<e> A_12 = null;
		FIDeviceErr fIDeviceErr = FIDeviceErr.None;
		List<e> A_13 = null;
		checked
		{
			try
			{
				m2(A_3, ref A_11, ref A_12, ref A_13);
				A_2 = (byte)A_12.Count;
				if (A_2 == 0)
				{
					if (A_13 == null)
					{
						return FIDeviceErr.None;
					}
					A_12.Add(A_13[0]);
					A_2 = (byte)unchecked((uint)(A_2 + 1));
					A_4 = true;
					if (A_13[0].i)
					{
						A_5 = InternalFWLicenseRequiredReason.MissingHardware;
					}
					else
					{
						A_5 = InternalFWLicenseRequiredReason.AccessoryOnly;
					}
				}
				else if (A_13 != null)
				{
					foreach (e item in A_13)
					{
						if (item.i)
						{
							A_4 = true;
							A_5 = InternalFWLicenseRequiredReason.MissingHardware;
						}
						A_12.Add(item);
					}
				}
				foreach (e item2 in A_12)
				{
					if (item2.k() && ((FIUsbController)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("8E8A4047-8CAE-4A66-911B-B669635F33A5")))).ConnectAndSetDeviceAddresses(item2.b) != 0)
					{
						A_3.c(fz.b.b, "Failed to reconnect to controller in USBDevice.EnumerateAndInitializeDevices");
						return FIDeviceErr.USBEnumError;
					}
				}
				A_1?.Clear();
				bool flag = default(bool);
				int num;
				for (num = 0; num < A_12.Count; num++)
				{
					e e10 = A_12[num];
					if (e10.l())
					{
						string text = e10.c;
						if (e10.m() == 0)
						{
							e10.f = e10.b;
						}
						else
						{
							int num2 = 0;
							while (!flag && num2 < A_12.Count)
							{
								if (num2 != num && A_12[num2].m() == 0 && Operators.CompareString(A_12[num2].c, e10.c, TextCompare: false) == 0)
								{
									e10.f = A_12[num2].b;
									break;
								}
								num2++;
							}
						}
					}
					else
					{
						e10.f = e10.b;
					}
					e10 = null;
				}
				List<string> list = new List<string>();
				List<List<int>> list2 = new List<List<int>>();
				num = 0;
				while (num <= A_12.Count - 1)
				{
					e e11 = A_12[num];
					if (e11.l() && e11.m() > 0)
					{
						int num3 = e11.m() - 1;
						string text2 = e11.c;
						FMLegacyAllSystemTypes fMLegacyAllSystemTypes = e11.g;
						int num4 = list.IndexOf(text2);
						if (num4 < 0)
						{
							list.Add(text2);
							list2.Add(new List<int>());
							num4 = list.Count - 1;
						}
						do
						{
							bool flag2 = false;
							foreach (e item3 in A_12)
							{
								if (Operators.CompareString(item3.c, text2, TextCompare: false) == 0 && item3.g == fMLegacyAllSystemTypes)
								{
									if (item3.e < e11.m())
									{
										item3.e = e11.m();
									}
									if (item3.m() == num3)
									{
										flag2 = true;
									}
								}
							}
							if (!flag2)
							{
								if (!list2[num4].Contains(num3))
								{
									list2[num4].Add(num3);
									if (A_10)
									{
										A_3.c(fz.b.a, "Missing subsystem Index " + Conversions.ToString(num3) + " for SN " + e11.c);
									}
								}
								if (list2[num4].Count > 1 || (fMLegacyAllSystemTypes != FMLegacyAllSystemTypes.kTypeF32 && fMLegacyAllSystemTypes != FMLegacyAllSystemTypes.kTypeF37))
								{
									A_4 = true;
									A_5 = InternalFWLicenseRequiredReason.MissingSubSystem;
								}
							}
							num3--;
						}
						while (num3 >= 0);
					}
					e11 = null;
					if (A_0 != null && A_1 != null)
					{
						bool flag3 = false;
						foreach (h6 item4 in A_0)
						{
							if (Operators.CompareString(item4.abk().SerialNumber, A_12[num].b, TextCompare: false) == 0)
							{
								A_1.Add(item4);
								flag3 = true;
								break;
							}
						}
						if (flag3)
						{
							A_12.RemoveAt(num);
						}
						else
						{
							num++;
						}
					}
					else
					{
						num++;
					}
				}
				if (A_1 != null)
				{
					List<List<FMUSBDeviceType>> list3 = new List<List<FMUSBDeviceType>>();
					bool flag4 = false;
					int index = -1;
					FMUSBIntErr eErrCode = default(FMUSBIntErr);
					FMUSBDeviceType eDeviceType = default(FMUSBDeviceType);
					do
					{
						if (flag4)
						{
							A_12.RemoveAt(index);
							A_2 = (byte)A_12.Count;
							if (A_2 == 0)
							{
								return FIDeviceErr.None;
							}
							flag4 = false;
							index = -1;
						}
						int num5 = A_12.Count - 1;
						for (num = 0; num <= num5; num++)
						{
							List<FMUSBDeviceType> list4 = new List<FMUSBDeviceType>();
							list3.Add(list4);
							if (!A_12[num].k())
							{
								continue;
							}
							int num6 = 0;
							while (true)
							{
								FMusbEnum fMusbEnum = A_11;
								int lControllerIdx = A_12[num].a;
								int lDeviceIdx = num6 + 1;
								string deviceSN = null;
								string deviceFriendlySN = null;
								byte ucDeviceRevLevel = 0;
								fMusbEnum.EnumerateDevice(lControllerIdx, lDeviceIdx, ref eErrCode, ref deviceSN, ref deviceFriendlySN, ref eDeviceType, ref ucDeviceRevLevel);
								if (eErrCode == FMUSBIntErr.kFMUSBIntErrNoErr)
								{
									if (eDeviceType == FMUSBDeviceType.FIUSB2DeviceOptProf)
									{
										break;
									}
									list4.Add(eDeviceType);
								}
								num6++;
								if (eErrCode == FMUSBIntErr.kFMUSBIntErrNoErr)
								{
									continue;
								}
								goto IL_04ca;
							}
							list3.RemoveAt(list3.Count - 1);
							flag4 = true;
							index = num;
							break;
							IL_04ca:;
						}
					}
					while (flag4);
					Collection<h6> collection = null;
					Collection<ip>[] array = new Collection<ip>[A_12.Count - 1 + 1];
					List<h5> list5 = new List<h5>();
					Collection<Collection<h6>> collection2 = new Collection<Collection<h6>>();
					int num7 = A_12.Count - 1;
					int A_15 = default(int);
					int A_16 = default(int);
					b0.a A_17 = default(b0.a);
					for (num = 0; num <= num7; num++)
					{
						h5 h11 = new h5(A_12[num].b, A_3, A_7);
						list5.Add(h11);
						FIUsbController fIUsbController = h11.abk();
						collection = new Collection<h6>();
						collection2.Add(collection);
						array[num] = new Collection<ip>();
						int num8 = list3[num].Count - 1;
						for (int num6 = 0; num6 <= num8; num6++)
						{
							FMUSBDeviceType fMUSBDeviceType = list3[num][num6];
							h6 h12;
							int num9;
							if (fMUSBDeviceType == FMUSBDeviceType.FIUSB2DevicePDLED)
							{
								h12 = new @in(fIUsbController, num6, A_3);
							}
							else
							{
								ip ip2 = new ip(fIUsbController, num6, A_3);
								h12 = ip2;
								bool flag5 = m2();
								string deviceFriendlySN = null;
								bool A_14 = false;
								ip2.m2(ref A_15, ref deviceFriendlySN, ref A_14, ref A_16);
								A_8 = ip2.be();
								if (A_16 != 0)
								{
									return FIDeviceErr.USBDeviceHardwareFailure;
								}
								if (A_15 != 0)
								{
									A_3.c(fz.b.a, "Spectrometer configuration failure. Error code=" + Conversions.ToString(A_15) + ", most likely cause of error is some type of hardware failure.");
								}
								else
								{
									if (flag5 || (!ip2.x4() && ip2.w9() != 0))
									{
										ip2.so(A_0: true);
										if (flag5 && ip2.w9() == -127)
										{
											A_3.c(fz.b.b, "Error in USBDevice.EnumerateAndInitializeDevices in second call to TestTakeSpectrum, Error = " + ip2.w9());
										}
									}
									if (m2(ip2))
									{
										A_6 = true;
										A_5 = InternalFWLicenseRequiredReason.MisProgrammedMinIntTime;
										A_3.c(fz.b.b, "The minimum integration time is incorrect.");
									}
								}
								if (h12.ab6())
								{
									if (ip2.xv())
									{
										num9 = ip2.tg(A_0: true);
										if (num9 != 0)
										{
											A_3.c(fz.b.a, "Error attempting to set initial value of GPIO output bit from spectrometer. Error code=" + Conversions.ToString(num9));
										}
									}
									array[num].Add(ip2);
								}
							}
							num9 = fIUsbController.WriteGenIO(byte.MaxValue);
							if (num9 != 0)
							{
								A_3.c(fz.b.a, "Error attempting to set initial value of GPIO output bits of controller. Error code=" + Conversions.ToString(num9));
							}
							if (h12.ab6())
							{
								h12.t0(A_12[num].e);
								if ((h12.abk().FWInstTypeCode == 7 && (h12.abk().FWSystemSubtype == 3 || h12.abk().FWSystemSubtype == 6 || h12.abk().FWSystemSubtype == 8)) || h12.abk().FWInstTypeCode == 28 || (h12.abk().FWInstTypeCode == 19 && h12.abk().FWSystemSubtype == 4))
								{
									h12.tl(A_12[num].e);
								}
								else if (h12.abk().FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF2 && (!h12.abi() || h12.abb() != 0))
								{
									h12.tl(1);
								}
								h12.qh(A_12[num].f);
								A_1.Add(h12);
								collection.Add(h12);
							}
						}
						bool a_ = false;
						if (collection.Count == 2)
						{
							if (collection[0] is ip && collection[1] is ip)
							{
								ip ip3 = (ip)collection[0];
								ip ip4 = (ip)collection[1];
								a_ = ip.m2(ip3.vu(), ip3.vv(), ip4.vu(), ip4.vv(), Operators.CompareString(ip3.abn(), ip4.abn(), TextCompare: false) == 0);
							}
							else
							{
								a_ = false;
							}
						}
						else if (collection.Count == 1)
						{
							a_ = collection[0].abk().FWSubsysNumControllers == 2;
						}
						else if (collection.Count == 0)
						{
							if (h6.e.k(fIUsbController.FWInstTypeCodeAsEnum) && !A_4 && !fIUsbController.FriendlySN.EndsWith("ScattCal_1") && !fIUsbController.FriendlySN.EndsWith("ScattCal_2") && !fIUsbController.FriendlySN.EndsWith("ScattCal_3"))
							{
								A_4 = true;
								A_5 = InternalFWLicenseRequiredReason.NoConnectedDevices;
							}
							A_1.Add(new h5(A_12[num].b, A_3, A_7));
						}
						if (collection.Count > 0 && collection[0].abw() && !collection[0].ab0())
						{
							A_4 = true;
							A_5 = InternalFWLicenseRequiredReason.MissingLightSource;
						}
						int num10 = collection.Count - 1;
						for (int num6 = 0; num6 <= num10; num6++)
						{
							if (collection[num6] is ip)
							{
								ip obj = (ip)collection[num6];
								bool a_2 = fIUsbController.FWInstTypeCodeAsEnum == FMLegacyAllSystemTypes.kTypeF20_F40 && collection.Count == 2 && num6 == 1;
								obj.qh(a_, a_2);
								_ = null;
							}
						}
						if (!fIUsbController.FriendlySN.EndsWith("ScattCal_1"))
						{
							continue;
						}
						e e12 = A_12[num];
						b0 b10 = null;
						if (!A_7)
						{
							h11 = new h5(e12.b, A_3, A_7);
							b10 = new b0(h11, A_3, ref A_17);
							if (A_17 != b0.a.a)
							{
								A_4 = true;
								A_5 = m2(A_17);
								b10 = null;
								return FIDeviceErr.None;
							}
							A_1.Add(b10);
						}
						e12 = null;
					}
					bool flag6 = false;
					int num11 = A_12.Count - 1;
					bool flag7 = default(bool);
					bool flag8 = default(bool);
					bool flag9 = default(bool);
					for (num = 0; num <= num11; num++)
					{
						e obj2 = A_12[num];
						string text = obj2.c;
						int num12 = obj2.m();
						_ = null;
						int num13 = A_12.Count - 1;
						for (int num14 = 0; num14 <= num13; num14++)
						{
							if (num14 != num)
							{
								e e13 = A_12[num14];
								if (Operators.CompareString(e13.c, text, TextCompare: false) == 0 && e13.m() == num12 && array[num].Count > 0 && array[num14].Count > 0)
								{
									foreach (ip item5 in array[num])
									{
										if (item5.wr().l)
										{
											flag7 = true;
										}
										foreach (ip item6 in array[num14])
										{
											if (item6.wr().l)
											{
												flag8 = true;
											}
											if (item5.wr().h == item6.wr().h)
											{
												flag9 = true;
												break;
											}
										}
										if (flag9)
										{
											break;
										}
									}
									if (flag7 && !flag8)
									{
										e e14 = A_12[num];
										e14.f = A_12[num14].f;
										foreach (ip item7 in array[num])
										{
											item7.qh(e14.f);
										}
										e14 = null;
									}
									else if (flag8 && !flag7)
									{
										e e15 = A_12[num14];
										e15.f = A_12[num].f;
										foreach (ip item8 in array[num14])
										{
											item8.qh(e15.f);
										}
										e15 = null;
									}
								}
								e13 = null;
							}
							if (flag9)
							{
								break;
							}
						}
						if (flag9)
						{
							break;
						}
					}
					if (flag6)
					{
						A_4 = true;
						InternalFWLicenseRequiredReason internalFWLicenseRequiredReason = default(InternalFWLicenseRequiredReason);
						A_5 = internalFWLicenseRequiredReason;
						if (A_10)
						{
							A_3.c(fz.b.a, "Notch/flat find spectrometer related conflict detected. Error code = " + A_5);
						}
					}
					else if (flag9)
					{
						A_4 = true;
						A_5 = InternalFWLicenseRequiredReason.ConflictingSubSystems;
						if (A_10)
						{
							A_3.c(fz.b.a, "Software has detected duplicate subsystems - more than one subsystem with same serial number and subsystem index. Firmware must be reprogrammed.");
						}
					}
				}
				fIDeviceErr = FIDeviceErr.None;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				A_3.c(fz.b.b, ex3.ToString());
				fIDeviceErr = FIDeviceErr.Generic;
				ProjectData.ClearProjectError();
			}
			return fIDeviceErr;
		}
	}

	private static bool m2(FMUSBIntErr A_0)
	{
		if (A_0 != FMUSBIntErr.kFMUSBIntErrMissingLSOnTimer)
		{
			return A_0 == FMUSBIntErr.kFMUSBIntErrMissingSecondaryLSOnTimer;
		}
		return true;
	}

	private static bool m2(ip A_0)
	{
		ip ip2 = A_0;
		if (ip2.xs() == FMUSBDeviceType.FIUSB2DeviceSpecLC && ip2.ij.FWMfrDate.CompareTo(new DateTime(634982112000000000L)) > 0 && ip2.ij.FWMfrDate.CompareTo(new DateTime(635078016000000000L)) < 0 && !ip2.abw())
		{
			return jf.e(ip2.vm(), 1.36f);
		}
		ip2 = null;
		return false;
	}

	public static string p9(FMLegacyAllSystemTypes A_0)
	{
		string result = "Unknown";
		switch (A_0)
		{
		case FMLegacyAllSystemTypes.kTypeF20:
			result = "F20";
			break;
		case FMLegacyAllSystemTypes.kTypeF30:
			result = "F30";
			break;
		case FMLegacyAllSystemTypes.kTypeF40:
			result = "F40";
			break;
		case FMLegacyAllSystemTypes.kTypeF50_200:
			result = "F50-200";
			break;
		case FMLegacyAllSystemTypes.kTypeF76:
			result = "F76";
			break;
		case FMLegacyAllSystemTypes.kTypeSpecial:
			result = "Special";
			break;
		case FMLegacyAllSystemTypes.kTypeF10:
			result = "F10";
			break;
		case FMLegacyAllSystemTypes.kTypeF70:
			result = "F70";
			break;
		case FMLegacyAllSystemTypes.kTypeF50_300:
			result = "F50-300";
			break;
		case FMLegacyAllSystemTypes.kTypeF75:
			result = "F75";
			break;
		case FMLegacyAllSystemTypes.kTypeF50XY_450:
			result = "F50XY-450";
			break;
		case FMLegacyAllSystemTypes.kTypeF80OffTool200:
			result = "F80Off-200";
			break;
		case FMLegacyAllSystemTypes.kTypeF80OnTool200:
			result = "F80On-200";
			break;
		case FMLegacyAllSystemTypes.kTypeF80OffTool300:
			result = "F80Off-300";
			break;
		case FMLegacyAllSystemTypes.kTypeF80OnTool300:
			result = "F80On-300";
			break;
		case FMLegacyAllSystemTypes.kTypeF50XY_200:
			result = "F50XY-200";
			break;
		case FMLegacyAllSystemTypes.kTypeF50_200B:
			result = "F50-200 Rev. B";
			break;
		case FMLegacyAllSystemTypes.kTypeF50_300B:
			result = "F50-300 Rev. B";
			break;
		case FMLegacyAllSystemTypes.kTypeF20_F40:
			result = "F20_F40";
			break;
		case FMLegacyAllSystemTypes.kTypeF80SS:
			result = "F80";
			break;
		case FMLegacyAllSystemTypes.kTypeF42:
			result = "F42";
			break;
		case FMLegacyAllSystemTypes.kTypeF42Oxford:
			result = "Oxford OSP";
			break;
		case FMLegacyAllSystemTypes.kTypeF32:
			result = "F32";
			break;
		case FMLegacyAllSystemTypes.kTypeF37:
			result = "F37";
			break;
		case FMLegacyAllSystemTypes.kTypeF40NSR:
			result = "F40-NSR";
			break;
		case FMLegacyAllSystemTypes.kTypePARTS:
			result = "PARTS";
			break;
		case FMLegacyAllSystemTypes.kTypeF50XY_510:
			result = "F50-XY-510";
			break;
		case FMLegacyAllSystemTypes.kTypeF50XY_10:
			result = "F50-XY-10";
			break;
		case FMLegacyAllSystemTypes.kTypeUVSource:
			result = "UV Source";
			break;
		case FMLegacyAllSystemTypes.kTypeF50_450B:
			result = "F50-450 Rev. B";
			break;
		case FMLegacyAllSystemTypes.kTypeF2:
			result = "F2";
			break;
		case FMLegacyAllSystemTypes.kTypeF3:
			result = "F3";
			break;
		case FMLegacyAllSystemTypes.kTypeS3:
			result = "S3";
			break;
		case FMLegacyAllSystemTypes.kTypeOpticalAcc:
			result = "Optical Accessory";
			break;
		case FMLegacyAllSystemTypes.kTypeF60:
			result = "F60 Class";
			break;
		case FMLegacyAllSystemTypes.kTypeHnl:
			result = "Heraeus Device";
			break;
		}
		return result;
	}

	public static string m2(FMLegacyAllSystemTypes A_0, byte A_1)
	{
		return m2(A_0, A_1, p9(A_0), A_3: false);
	}

	public static string m2(FMLegacyAllSystemTypes A_0, byte A_1, string A_2, bool A_3)
	{
		string text = p9(A_0);
		switch (A_0)
		{
		case FMLegacyAllSystemTypes.kTypeS3:
			text = p9(FMLegacyAllSystemTypes.kTypeS3);
			break;
		case FMLegacyAllSystemTypes.kTypeF2:
			if (!string.IsNullOrEmpty(A_2) && A_2.StartsWith("aRTie"))
			{
				text = "aRTie";
			}
			break;
		case FMLegacyAllSystemTypes.kTypeF3:
			switch ((i7.a)A_1)
			{
			case i7.a.b:
				text += "-CP";
				break;
			case i7.a.c:
				text += "-CS";
				break;
			case i7.a.d:
				text += "-sX";
				break;
			}
			break;
		case FMLegacyAllSystemTypes.kTypeF10:
			switch ((FMF10Subtypes)A_1)
			{
			case FMF10Subtypes.kFMF10SubtypeAR:
				text += "-AR";
				break;
			case FMF10Subtypes.kFMF10SubtypePA:
				text += "-PA";
				break;
			case FMF10Subtypes.kFMF10SubtypeVC:
				text += "-VC";
				break;
			case FMF10Subtypes.kFMF10SubtypeRT:
				text += "-RT";
				break;
			case FMF10Subtypes.kFMF10SubtypeHC:
				text += "-HC";
				break;
			case FMF10Subtypes.kFMF10SubtypePV:
				text += "-PV";
				break;
			case FMF10Subtypes.kFMF10SubtypeARc:
				text += "-ARc";
				break;
			case FMF10Subtypes.kFMF10SubtypeRTA:
				text += "-RTA";
				break;
			default:
				if (A_3)
				{
					text += "-AR";
				}
				break;
			}
			break;
		case FMLegacyAllSystemTypes.kTypeF20:
			switch ((FMF20Subtypes)A_1)
			{
			case FMF20Subtypes.kFMF20SubtypeHC:
				text += "-HC";
				break;
			case FMF20Subtypes.kFMF20SubtypeE:
				text += "e";
				break;
			}
			break;
		case FMLegacyAllSystemTypes.kTypeF32:
			text = "F32";
			break;
		case FMLegacyAllSystemTypes.kTypeF37:
			text = "F37";
			break;
		case FMLegacyAllSystemTypes.kTypePARTS:
			text = "PARTS";
			break;
		case FMLegacyAllSystemTypes.kTypeF50_300B:
			switch ((FMF50Subtypes)A_1)
			{
			case FMF50Subtypes.kFMF50SubtypeF54:
				text = "F54";
				break;
			case FMF50Subtypes.kFMF50SubtypeF57:
				text = "F57";
				break;
			case FMF50Subtypes.kFMF50SubtypeF50sX:
				text = "F50-sX";
				break;
			case FMF50Subtypes.kFMF50SubtypeF50XYRT_300:
				text = "F50XYRT_300";
				break;
			}
			break;
		case FMLegacyAllSystemTypes.kTypeF60:
			switch ((FMF60Subtypes)A_1)
			{
			case FMF60Subtypes.kFMF60SubtypeF64t:
				text = "F64-t";
				break;
			case FMF60Subtypes.kFMF60SubtypeF64c:
				text = "F64-c";
				break;
			case FMF60Subtypes.kFMF60SubtypeF60t:
				text = "F60-t";
				break;
			case FMF60Subtypes.kFMF60SubtypeF60c:
				text = "F60-c";
				break;
			}
			break;
		case FMLegacyAllSystemTypes.kTypeOpticalAcc:
			switch ((FMOpticalAccSubTypes)A_1)
			{
			case FMOpticalAccSubTypes.kFMOpticalAccSubtypeFiberSwitchDual:
				text = "DualFiberSwitch";
				break;
			case FMOpticalAccSubTypes.kFMOpticalAccSubtypeXY10:
				text = "XY10Stage";
				break;
			}
			break;
		}
		return text;
	}

	private static InternalFWLicenseRequiredReason m2(b0.a A_0)
	{
		InternalFWLicenseRequiredReason internalFWLicenseRequiredReason = default(InternalFWLicenseRequiredReason);
		return A_0 switch
		{
			b0.a.b => InternalFWLicenseRequiredReason.InitializingMotorController, 
			b0.a.c => InternalFWLicenseRequiredReason.MotorBaudRateModified, 
			b0.a.d => InternalFWLicenseRequiredReason.TestingDOUTToDINConnection, 
			b0.a.e => InternalFWLicenseRequiredReason.InitializingRotaryMotor, 
			b0.a.f => InternalFWLicenseRequiredReason.SettingRotaryMicrostepResolution, 
			b0.a.g => InternalFWLicenseRequiredReason.SettingRotarySoftStopFlag, 
			b0.a.h => InternalFWLicenseRequiredReason.EnergizingMotors, 
			_ => internalFWLicenseRequiredReason, 
		};
	}

	private static bool m2()
	{
		Process[] processesByName = Process.GetProcessesByName(global::a.k());
		Process currentProcess = Process.GetCurrentProcess();
		bool result = false;
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			if (process.Id != currentProcess.Id)
			{
				try
				{
					process.Kill();
					result = true;
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex3 = ex2;
					ProjectData.ClearProjectError();
				}
			}
		}
		currentProcess = null;
		return result;
	}

	private static bool m2(double A_0, string A_1, byte[] A_2)
	{
		byte[] array = new byte[4];
		byte[] array2 = new byte[4];
		checked
		{
			array[0] = (byte)Math.Round(Conversion.Int(A_0 * 256.0) % 256.0);
			array[1] = (byte)Math.Round(Conversion.Int(A_0) % 256.0);
			array[2] = (byte)Math.Round(Conversion.Int(A_0 * 256.0 * 256.0 * 256.0 - Conversion.Int(A_0) * 256.0 * 256.0 * 256.0) % 256.0);
			array[3] = (byte)Math.Round(Conversion.Int(A_0 * 256.0 * 256.0 - Conversion.Int(A_0) * 256.0 * 256.0) % 256.0);
			if (A_1 != null && A_1.Length >= 4)
			{
				array2[2] = (byte)Strings.Asc(Strings.Mid(A_1, 1, 1));
				array2[0] = (byte)Strings.Asc(Strings.Mid(A_1, 2, 1));
				array2[3] = (byte)Strings.Asc(Strings.Mid(A_1, 3, 1));
				array2[1] = (byte)Strings.Asc(Strings.Mid(A_1, 4, 1));
				unchecked
				{
					array2[3] = (byte)(array2[3] ^ array[2]);
					array2[0] = (byte)(array2[0] ^ array[3]);
					array2[2] = (byte)(array2[2] ^ array[0]);
					array2[1] = (byte)(array2[1] ^ array[1]);
					if (array2[0] == A_2[0] && array2[1] == A_2[1] && array2[2] == A_2[2] && array2[3] == A_2[3])
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	public void m2(ref int A_0, ref string A_1, ref bool A_2, ref int A_3)
	{
		A_0 = mb;
		A_1 = ma;
		A_2 = a7();
		A_3 = mc;
	}

	[SpecialName]
	protected abstract bool a7();

	public static FIDeviceErr m2(fz A_0, ref bool A_1, ref InternalFWLicenseRequiredReason A_2, ref bool A_3, ref string A_4)
	{
		byte[] array = new byte[4];
		string text = string.Empty;
		FIDeviceErr result;
		try
		{
			Collection<h6> A_5 = null;
			Collection<h6> A_6 = null;
			byte A_7 = default(byte);
			switch (m2(ref A_5, ref A_6, ref A_7, A_0, A_4: true, ref A_1, ref A_2, ref A_3, ref A_4))
			{
			case FIDeviceErr.USBFirmwareNeedsUpdate:
				result = FIDeviceErr.None;
				break;
			case FIDeviceErr.USBDeviceHardwareFailure:
				result = FIDeviceErr.USBDeviceHardwareFailure;
				break;
			case FIDeviceErr.None:
				if (A_7 > 0)
				{
					A_1 = false;
					FIUsbController fIUsbController;
					if (A_5.Count > 0)
					{
						fIUsbController = A_5[0].abk();
						int lErrCode = default(int);
						fIUsbController.Connect(1, string.Empty, ref lErrCode);
						h6 obj = A_5[0];
						string A_8 = null;
						bool A_9 = default(bool);
						int A_10 = default(int);
						obj.m2(ref lErrCode, ref A_8, ref A_9, ref A_10);
						if (lErrCode == 0 && !A_9)
						{
							text = A_8;
						}
						_ = null;
						if (lErrCode != 0 || string.IsNullOrEmpty(text))
						{
							A_2 = InternalFWLicenseRequiredReason.DeviceValidationFailure;
							A_1 = true;
						}
					}
					else
					{
						fIUsbController = A_6[0].abk();
					}
					double num = DateAndTime.Now.ToOADate();
					if (!A_1 && fIUsbController.ValSafe(num, array) == 0 && m2(num, text, array))
					{
						result = FIDeviceErr.None;
						break;
					}
					if (!A_1)
					{
						if (A_5.Count == 0)
						{
							A_2 = InternalFWLicenseRequiredReason.ControllerWithMissingDevices;
						}
						else
						{
							A_2 = InternalFWLicenseRequiredReason.DeviceValidationFailure;
						}
						A_1 = true;
					}
					text = fIUsbController.SerialNumber;
					if (string.IsNullOrEmpty(text))
					{
						result = FIDeviceErr.USBCorruptedDevice;
						break;
					}
					FIUsbController fIUsbController2 = fIUsbController;
					if (fIUsbController2.eControllerType == FMUSBDeviceType.FMUSBDeviceController && fIUsbController2.FWCodeMajorVer <= 1 && fIUsbController2.FWCodeMinorVer < 10)
					{
						result = FIDeviceErr.USBInitError;
						break;
					}
					fIUsbController2 = null;
					if (fIUsbController.ValConSafe(num, array) == 0)
					{
						if (m2(num, text, array))
						{
							result = FIDeviceErr.None;
							break;
						}
						A_2 = InternalFWLicenseRequiredReason.ControllerValidationFailure;
						result = FIDeviceErr.USBCorruptedDevice;
					}
					else
					{
						result = FIDeviceErr.USBInitError;
					}
				}
				else
				{
					result = FIDeviceErr.USBNoDevices;
				}
				break;
			default:
				result = FIDeviceErr.USBEnumError;
				break;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			A_0?.c(fz.b.b, "Exception caught in USBDevice.TestForValidDevice(). ", a_);
			result = FIDeviceErr.Generic;
			ProjectData.ClearProjectError();
		}
		finally
		{
			int lErrCode2 = default(int);
			((FIUsbController)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("8E8A4047-8CAE-4A66-911B-B669635F33A5")))).Connect(1, string.Empty, ref lErrCode2);
		}
		return result;
	}

	public static FIDeviceErr m2(ref short A_0, ref short A_1, ref short A_2, ref short A_3, fz A_4)
	{
		FIDeviceErr result;
		try
		{
			FMusbEnum fMusbEnum = (FMusbEnum)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("BB8E1A15-4E65-45FA-9DE6-876792487AF7")));
			fMusbEnum.GetVersion(ref A_0, ref A_1, ref A_2, ref A_3);
			bool flag = false;
			if (A_0 < 1)
			{
				flag = true;
			}
			else if (A_0 == 1)
			{
				if (A_1 < 0)
				{
					flag = true;
				}
				else if (A_1 == 0 && A_2 < 113)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (A_4 != null)
				{
					string A_5 = "FIUSBIntVersionErrFmt2";
					string a_ = string.Format(hu.a(ref A_5), (short)1 + "." + (short)0 + "." + (short)113, A_0 + "." + A_1 + "." + A_2);
					A_4.c(fz.b.a, a_);
				}
				result = FIDeviceErr.FIUsbIntTooOld;
				goto IL_0187;
			}
			if (fMusbEnum.XPVer != 0 && !jj.a())
			{
				A_4.c(fz.b.a, "FIUsbInt XP version is installed, but OS is not XP");
				result = FIDeviceErr.FIUsbIntXPVerError;
				goto IL_0187;
			}
		}
		catch (COMException ex2)
		{
			ProjectData.SetProjectError(ex2);
			COMException a_2 = ex2;
			A_4?.c(fz.b.b, "COM Exception caught in USBDevice.CheckUSBIntVer(). ", a_2);
			result = FIDeviceErr.FIUsbIntCOMError;
			ProjectData.ClearProjectError();
			goto IL_0187;
		}
		catch (FileNotFoundException ex3)
		{
			ProjectData.SetProjectError(ex3);
			FileNotFoundException a_3 = ex3;
			A_4?.c(fz.b.b, "COM Exception caught in USBDevice.CheckUSBIntVer(). ", a_3);
			result = FIDeviceErr.FIUsbIntFileNotFoundError;
			ProjectData.ClearProjectError();
			goto IL_0187;
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception a_4 = ex4;
			A_4?.c(fz.b.b, "Exception caught in USBDevice.CheckUSBIntVer(). ", a_4);
			result = FIDeviceErr.Generic;
			ProjectData.ClearProjectError();
			goto IL_0187;
		}
		result = FIDeviceErr.None;
		goto IL_0187;
		IL_0187:
		return result;
	}

	public h6(f0.a A_0, FIUsbController A_1, fz A_2)
		: base(A_0, A_2)
	{
		l0 = A_1.SerialNumber;
		ij = A_1;
		sm(A_1.FriendlySN);
	}

	public h6(f0.a A_0, string A_1, fz A_2)
		: base(A_0, A_2)
	{
		l0 = A_1;
		d();
	}

	protected override FIDeviceErr d()
	{
		FIDeviceErr result = FIDeviceErr.None;
		try
		{
			long num = 0L;
			int lErrCode = default(int);
			do
			{
				ij = (FIUsbController)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("8E8A4047-8CAE-4A66-911B-B669635F33A5")));
				ij.Connect(0, abn(), ref lErrCode);
				mb = lErrCode;
				if (lErrCode != 0 && lErrCode != -108 && !m2((FMUSBIntErr)lErrCode))
				{
					bd();
					if (mc != 0)
					{
						ab8().c(fz.b.a, "Hardware failure in connected device. Failure is:" + be());
					}
					else
					{
						ab8().c(fz.b.a, "Failure in InitializeDevice(). Failure to connect to Controller. Error is: " + Conversions.ToString(lErrCode), Environment.StackTrace);
					}
					return FIDeviceErr.None;
				}
				num = checked(num + 1);
			}
			while (ij.FWCorrupt != 0 && num < 2);
			if (ij.FWCorrupt != 0)
			{
				ab8().c(fz.b.a, "Failure in InitializeDevice(). Controller Firmware corrupt");
			}
			sm(ij.FriendlySN);
			l0 = ij.SerialNumber;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			result = FIDeviceErr.Generic;
			ab8().c(fz.b.b, "Exception caught in USBDevice.InitializeDevice(). Exception is: " + ex3.Message);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void sj(string A_0)
	{
		l0 = A_0;
		a6(A_0);
	}

	protected abstract int a6(string A_0);

	public override void e()
	{
		if (ij != null && ij.ShutdownWasCalled == 0)
		{
			int num = ij.Shutdown();
			if (num != 0)
			{
				ab8().c(fz.b.b, "Error attempting to shut down USB Controller. Error code is:" + num);
			}
		}
	}

	public void m2(ref short A_0, ref short A_1, ref short A_2, ref short A_3)
	{
		((FMusbEnum)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("BB8E1A15-4E65-45FA-9DE6-876792487AF7")))).GetVersion(ref A_0, ref A_1, ref A_2, ref A_3);
	}

	[SpecialName]
	public FIUsbController abk()
	{
		return ij;
	}

	public c abl()
	{
		c c10 = new c();
		c c11 = c10;
		c11.g = ij.FWHighestCompatRevLev;
		c11.i = ij.FWCorrupt != 0;
		c11.e = ij.FWWriteEnabled != 0;
		c11.h = c11.i;
		if (c11.i)
		{
			c11.a = "None";
			return c10;
		}
		c11.a = ij.FriendlySN;
		c11.b = ij.SerialNumber;
		c11.j = ij.ParentSerialNumber;
		c11.d = ij.FWLastUpdate;
		c11.f = ij.FWRevNum;
		c11.k = ij.FWMfrDate;
		c11.l = ij.FWLimCenDist;
		c11.m = yu();
		c11.ab = abe();
		c11.ad = y5();
		c11.w = zf();
		c11.ac = y4();
		c11.x = aa9();
		c11.aa = zh();
		c11.o = y9();
		c11.p = za();
		c11.ag = ze();
		c11.ah = abw();
		c11.ai = !qh() && abx();
		c11.aj = aby();
		c11.ak = abz();
		c11.al = zm();
		c11.an = zl();
		c11.am = z6();
		c11.ao = ab1();
		c11.ap = ij.HasRtc != 0;
		c11.aq = ab2();
		c11.ar = ij.RtcDiscrepancy;
		c11.@as = zj();
		c11.at = aa1();
		c11.bf = aa3();
		c11.au = zn();
		c11.av = zp();
		c11.a1 = zr();
		c11.a2 = zt();
		c11.a3 = sj();
		c11.aw = zw();
		c11.ay = z1();
		c11.ax = zx();
		c11.t = aad();
		c11.y = y6();
		c11.z = y7();
		c11.q = yz();
		c11.n = yt();
		c11.r = y0();
		c11.s = y1();
		c11.u = y2();
		c11.v = y3();
		c11.ae = ij.FWF50XYDkMirX;
		c11.af = ij.FWF50XYDkMirY;
		c11.az = zz();
		c11.a0 = z3();
		c11.ba = aae();
		c11.a4 = aag();
		c11.a5 = aai();
		c11.a6 = aaj();
		c11.a7 = aak();
		c11.a8 = aal();
		c11.a9 = aam();
		c11.bb = aab();
		c11.bc = z9();
		c11.bd = aan();
		c11.be = aap();
		c11.bg = aar();
		c11.bh = aat();
		c11.bi = aav();
		c11.bj = aax();
		c11.bk = aay();
		c11.bl = !abx() || (abx() && qh() && !p9());
		c11.bm = b();
		c11.bn = ij.FWOemCode;
		c11.bo = c();
		c11.bq = ij.FWDefRefMatID;
		c11.bp = abu();
		c11.br = ij.FWDefNumCurves;
		c11.bs = ij.FWDefOpticConfig;
		c11.bz = abf();
		c11.b0 = abg();
		c11.bx = abi();
		c11.by = abj();
		c11.bt = ij.FWSubsystemIdx;
		c11.bu = ij.FWBoxTotalSubsystems;
		c11.bv = ij.FWSubsysNumControllers;
		c11.bw = ij.FWMeasurementAngle;
		c11.b1 = ij.FWCheckNumSubsystemsAndControllers != 0;
		c11 = null;
		return c10;
	}

	public d abm()
	{
		d d10;
		d result = (d10 = new d());
		d10.b = ij.eControllerType == FMUSBDeviceType.FIUSB2DeviceController;
		if (d10.b)
		{
			d10.a = "USB2Controller";
		}
		else
		{
			d10.a = "USBController";
		}
		d10 = null;
		return result;
	}

	[SpecialName]
	public string abn()
	{
		return l0;
	}

	[SpecialName]
	public string abo()
	{
		return l1;
	}

	[SpecialName]
	public void sm(string A_0)
	{
		l1 = A_0;
	}

	[SpecialName]
	public override FMLegacyAllSystemTypes b()
	{
		FMLegacyAllSystemTypes result;
		try
		{
			result = (FMLegacyAllSystemTypes)ij.FWInstTypeCode;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			result = FMLegacyAllSystemTypes.kTypeF10;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[SpecialName]
	public override byte c()
	{
		return ij.FWSystemSubtype;
	}

	[SpecialName]
	public string abp()
	{
		return p9(b());
	}

	[SpecialName]
	public bool abq()
	{
		return m2(b());
	}

	[SpecialName]
	public static bool m2(FMLegacyAllSystemTypes A_0)
	{
		if (A_0 != FMLegacyAllSystemTypes.kTypeUVSource && A_0 != FMLegacyAllSystemTypes.kTypeHnl)
		{
			return A_0 == FMLegacyAllSystemTypes.kTypeOpticalAcc;
		}
		return true;
	}

	public static byte sm(bool A_0, bool A_1, bool A_2, bool A_3, bool A_4, bool A_5, bool A_6, bool A_7)
	{
		checked
		{
			return (byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)((1 & (byte)(0 - (A_7 ? 1 : 0))) + (2 & (byte)(0 - (A_6 ? 1 : 0)))))) + (4 & (byte)(0 - (A_5 ? 1 : 0)))))) + (8 & (byte)(0 - (A_4 ? 1 : 0)))))) + (0x10 & (byte)(0 - (A_3 ? 1 : 0)))))) + (0x20 & (byte)(0 - (A_2 ? 1 : 0)))))) + (0x40 & (byte)(0 - (A_1 ? 1 : 0)))))) + (0x80 & (byte)(0 - (A_0 ? 1 : 0)))));
		}
	}

	public static byte m2(bool A_0, bool A_1, bool A_2, bool A_3, bool A_4, bool A_5)
	{
		checked
		{
			return (byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)((4 & (byte)(0 - (A_5 ? 1 : 0))) + (8 & (byte)(0 - (A_4 ? 1 : 0)))))) + (0x10 & (byte)(0 - (A_3 ? 1 : 0)))))) + (0x20 & (byte)(0 - (A_2 ? 1 : 0)))))) + (0x40 & (byte)(0 - (A_1 ? 1 : 0)))))) + (0x80 & (byte)(0 - (A_0 ? 1 : 0)))));
		}
	}

	public static byte sj(bool A_0, bool A_1, bool A_2, bool A_3, bool A_4, bool A_5, bool A_6, bool A_7)
	{
		checked
		{
			return (byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)((0x10 & (byte)(0 - (A_3 ? 1 : 0))) + (0x20 & (byte)(0 - (A_2 ? 1 : 0)))))) + (0x40 & (byte)(0 - (A_1 ? 1 : 0)))))) + (0x80 & (byte)(0 - (A_0 ? 1 : 0)))))) + (8 & (byte)(0 - (A_4 ? 1 : 0)))))) + (4 & (byte)(0 - (A_5 ? 1 : 0)))))) + (2 & (byte)(0 - (A_6 ? 1 : 0)))))) + (1 & (byte)(0 - (A_7 ? 1 : 0)))));
		}
	}

	public static byte qh(bool A_0, bool A_1, bool A_2, bool A_3, bool A_4, bool A_5, bool A_6, bool A_7)
	{
		checked
		{
			return (byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)((0x10 & (byte)(0 - (A_3 ? 1 : 0))) + (0x20 & (byte)(0 - (A_2 ? 1 : 0)))))) + (0x40 & (byte)(0 - (A_1 ? 1 : 0)))))) + (0x80 & (byte)(0 - (A_0 ? 1 : 0)))))) + (8 & (byte)(0 - (A_4 ? 1 : 0)))))) + (4 & (byte)(0 - (A_5 ? 1 : 0)))))) + (2 & (byte)(0 - (A_6 ? 1 : 0)))))) + (1 & (byte)(0 - (A_7 ? 1 : 0)))));
		}
	}

	public static byte m2(bool A_0, bool A_1, bool A_2, bool A_3, bool A_4, bool A_5, bool A_6, bool A_7, bool A_8)
	{
		checked
		{
			return (byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)((1 & (byte)(0 - (A_0 ? 1 : 0))) + (2 & (byte)(0 - (A_1 ? 1 : 0)))))) + (8 & (byte)(0 - ((A_3 || !A_4) ? 1 : 0)))))) + (0x10 & (byte)(0 - (A_5 ? 1 : 0)))))) + (4 & (byte)(0 - (A_2 ? 1 : 0)))))) + (0x20 & (byte)(0 - (A_6 ? 1 : 0)))))) + (0x40 & (byte)(0 - (A_7 ? 1 : 0)))))) + (0x80 & (byte)(0 - (A_8 ? 1 : 0)))));
		}
	}

	public static byte p9(bool A_0, bool A_1, bool A_2, bool A_3, bool A_4, bool A_5, bool A_6, bool A_7)
	{
		checked
		{
			return (byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)((1 & (byte)(0 - (A_0 ? 1 : 0))) + (2 & (byte)(0 - (A_1 ? 1 : 0)))))) + (4 & (byte)(0 - (A_2 ? 1 : 0)))))) + (8 & (byte)(0 - (A_3 ? 1 : 0)))))) + (0x10 & (byte)(0 - (A_4 ? 1 : 0)))))) + (0x20 & (byte)(0 - (A_5 ? 1 : 0)))))) + (0x40 & (byte)(0 - (A_6 ? 1 : 0)))))) + (0x80 & (byte)(0 - (A_7 ? 1 : 0)))));
		}
	}

	public static byte m2(bool A_0, bool A_1, bool A_2, bool A_3, bool A_4, bool A_5, bool A_6, bool A_7)
	{
		checked
		{
			return (byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)((1 & (byte)(0 - (A_0 ? 1 : 0))) + (2 & (byte)(0 - (A_1 ? 1 : 0)))))) + (4 & (byte)(0 - (A_2 ? 1 : 0)))))) + (8 & (byte)(0 - (A_3 ? 1 : 0)))))) + (0x10 & (byte)(0 - (A_4 ? 1 : 0)))))) + (0x20 & (byte)(0 - (A_5 ? 1 : 0)))))) + (0x40 & (byte)(0 - (A_6 ? 1 : 0)))))) + (0x80 & (byte)(0 - (A_7 ? 1 : 0)))));
		}
	}

	public static byte m2(bool A_0, bool A_1, bool A_2, LinearActuatorType A_3, bool A_4, bool A_5, bool A_6)
	{
		checked
		{
			return (byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)((1 & (byte)(0 - (A_0 ? 1 : 0))) + (2 & (byte)(0 - (A_1 ? 1 : 0)))))) + (4 & (byte)(0 - (A_2 ? 1 : 0)))))) + (8 & (byte)((uint)A_3 << 3))))) + (0x10 & (byte)((uint)A_3 << 3))))) + (0x20 & (byte)(0 - (A_4 ? 1 : 0)))))) + (0x40 & (byte)(0 - (A_5 ? 1 : 0)))))) + (0x80 & (byte)(0 - (A_6 ? 1 : 0)))));
		}
	}

	public static byte m2(bool A_0)
	{
		checked
		{
			return (byte)unchecked((uint)(1 + (2 & (byte)(0 - ((!A_0) ? 1 : 0)))));
		}
	}

	[SpecialName]
	public byte t5(int A_0)
	{
		return ((IFIUsbController)ij).get_FWBitPatt(A_0);
	}

	[SpecialName]
	public byte abr()
	{
		return ij.FWCodeMajorVer;
	}

	[SpecialName]
	public byte abs()
	{
		return ij.FWCodeMinorVer;
	}

	[SpecialName]
	public float abt()
	{
		return ij.FWF50Threshold;
	}

	[SpecialName]
	public FMRefMatEnums abu()
	{
		return ij.FWDefRefMat;
	}

	[SpecialName]
	public int abv()
	{
		return ij.FWDefRefMatID;
	}

	[SpecialName]
	public bool abw()
	{
		return (t5(3) & 4) != 0;
	}

	[SpecialName]
	public bool abx()
	{
		return sj(ij);
	}

	[SpecialName]
	public static bool sj(FIUsbController A_0)
	{
		return (A_0.FWBitPatt6 & 8) != 0;
	}

	[SpecialName]
	public bool aby()
	{
		return qh(ij);
	}

	[SpecialName]
	public static bool qh(FIUsbController A_0)
	{
		return (A_0.FWBitPatt6 & 0x10) != 0;
	}

	[SpecialName]
	public bool abz()
	{
		return p9(ij);
	}

	[SpecialName]
	public static bool p9(FIUsbController A_0)
	{
		return (A_0.FWBitPatt7 & 2) != 0;
	}

	[SpecialName]
	public bool ab0()
	{
		return ij.HasLowPowerLightSource != 0;
	}

	[SpecialName]
	public static bool m2(FIUsbController A_0)
	{
		return p9(A_0.FWBitPatt5);
	}

	[SpecialName]
	public static bool p9(byte A_0)
	{
		return (A_0 & 8) != 0;
	}

	[SpecialName]
	public bool ab1()
	{
		return p9(t5(5));
	}

	[SpecialName]
	public static bool m2(byte A_0)
	{
		return (A_0 & 4) != 0;
	}

	[SpecialName]
	public bool ab2()
	{
		return m2(t5(5));
	}

	public static string m2(FMRefMatEnums A_0)
	{
		return A_0 switch
		{
			FMRefMatEnums.kRefMatBk7 => "BK7", 
			FMRefMatEnums.kRefMatSi => "Si", 
			FMRefMatEnums.kRefMatFusedSilica2Sided => "FusedSilica(2Sided)", 
			FMRefMatEnums.kRefMatALREF => "ALREF-", 
			_ => "Unknown RefMat", 
		};
	}

	protected virtual void bd()
	{
	}

	protected virtual string be()
	{
		return null;
	}
}
