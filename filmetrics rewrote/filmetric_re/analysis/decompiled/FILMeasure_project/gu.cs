using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading;
using FIUsbIntLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal abstract class gu : r
{
	public new class a
	{
		public enum a
		{
			a,
			b
		}

		public Guid a;

		public a b;

		public string c;

		public gv d;

		public a()
		{
			b = gu.a.a.a;
			c = "";
		}
	}

	public enum ErrPublic
	{
		None,
		Generic,
		Initialization,
		SpecAcquisition,
		SpecAnalysis,
		SpecAnalysisSetup,
		SpecAnalysisFFTNoLayersSelectedForMeasure,
		LockUnlock,
		WavelengthRange,
		NoLight,
		LightTooBright,
		SignalNotProportionalToIntTime,
		LowSaturationIntensity,
		SolvingAbortFailure,
		SolvingAbortSuccess,
		InitNKCoeffsInvalid,
		InvalidDConstraints,
		InvalidNConstraints,
		InvalidKConstraints,
		NoDataWithinRange,
		InsufficientData,
		CompositeRecipeInconsistantWithNumSpectra,
		OutOfCorrelativeRange,
		ModelCoeffIncompatibleWithInitialN,
		ModelCoeffIncompatibleWithInitialK,
		OnlyExactSpectrumAnalysisPermittedForRAtAngle,
		ZAREModelUsedInMultipleLayersWithinSingleStack,
		ZAREAttemptToSolveForKWithoutTrans,
		ZAREAttemptToSolveForXKWithoutReflTrans,
		ZAREAttemptToSolveForNWithoutRAngle,
		ZAREAttemptToSolveForDNWithoutRAngle,
		ZAREAttemptToSolveForDNWithoutR0OrT,
		ZAREAttemptToSolveForDNKWithoutDoubleRefl,
		ZAREInsufficientWavelengthOverlapBetweenSpectrumTypes,
		ZAREMismatchedSolveForDInSameLayers,
		ZAREIndependentDForSameNorK,
		ZAREDesignError,
		InvalidSolarData,
		InvalidIlluminanceData,
		RegMarkNotFound
	}

	public delegate void b(string A_0);

	protected Guid gt;

	protected string g6;

	private float g7;

	private float g8;

	private byte g9;

	protected hd ha;

	protected hg hb;

	protected hg hc;

	protected bool hd;

	protected g2 he;

	protected Collection hf;

	protected hc hg;

	protected cb hh;

	protected gs hi;

	protected gt hj;

	protected b5 hk;

	protected he hl;

	public gv hm;

	private const short hn = 8;

	public gu(fz A_0, Guid A_1, gt A_2, hg A_3, hd A_4, b5 A_5, g2 A_6, he A_7, bool A_8)
		: base(A_0, "MeasMod Standalone")
	{
		hm = new gv();
		gt gt2 = A_2;
		string a_ = h6.m2(gt2.ao(), gt2.an(), gt2.am(), gt2.af());
		switch (gt2.ao())
		{
		case FMLegacyAllSystemTypes.kTypeS3:
			g7 = 950f;
			g8 = 1700f;
			g9 = 4;
			break;
		case FMLegacyAllSystemTypes.kTypeF2:
		case FMLegacyAllSystemTypes.kTypeF3:
			g7 = 380f;
			g8 = 1050f;
			g9 = 4;
			break;
		case FMLegacyAllSystemTypes.kTypeF10:
			if (gt2.af())
			{
				if (gt2.ai())
				{
					g7 = 380f;
					if (A_2.aw())
					{
						g8 = 1000f;
					}
					else
					{
						g8 = 800f;
					}
				}
				else
				{
					g7 = 380f;
					g8 = 800f;
				}
			}
			else if (gt2.ai())
			{
				g7 = 400f;
				g8 = 1000f;
			}
			else
			{
				g7 = 400f;
				g8 = 1000f;
			}
			g9 = 4;
			break;
		case FMLegacyAllSystemTypes.kTypeF20:
			g7 = 200f;
			g8 = 1700f;
			g9 = 5;
			break;
		case FMLegacyAllSystemTypes.kTypeF30:
			g7 = 380f;
			g8 = 1100f;
			g9 = 5;
			break;
		case FMLegacyAllSystemTypes.kTypeF50_300B:
			g7 = 200f;
			g8 = 1700f;
			g9 = 5;
			break;
		case FMLegacyAllSystemTypes.kTypeF50_450B:
			g7 = 200f;
			g8 = 1700f;
			g9 = 5;
			break;
		case FMLegacyAllSystemTypes.kTypeF70:
			g7 = 420f;
			g8 = 800f;
			g9 = 5;
			break;
		default:
			throw new ArgumentException("Invalid standalone settings combination - Unacceptable product type");
		}
		gt2 = null;
		m2(A_1, a_, A_3, A_4, A_2, A_5, A_6, A_7);
	}

	public gu(fz A_0, Guid A_1, string A_2, hg A_3, hd A_4, b5 A_5, g2 A_6, he A_7, bool A_8)
		: base(A_0, A_2)
	{
		hm = new gv();
		m2(A_1, A_2, A_3, A_4, null, A_5, A_6, A_7);
	}

	private void m2(Guid A_0, string A_1, hg A_2, hd A_3, gt A_4, b5 A_5, g2 A_6, he A_7)
	{
		hb = A_2;
		ha = A_3;
		gt = A_0;
		g6 = A_1;
		hf = new Collection();
		he = new g2();
		A_6.a(ref he);
		hb.bu(new g2());
		hg hg2;
		g2 A_8 = (hg2 = hb).d0();
		A_6.a(ref A_8);
		hg2.bu(A_8);
		hi = new gs(ab8());
		hg = new hc();
		hh = new cb();
		hj = A_4;
		hk = A_5;
		hl = A_7;
	}

	[SpecialName]
	public gt zc()
	{
		return hj;
	}

	[SpecialName]
	public float zd()
	{
		return g7;
	}

	[SpecialName]
	public float ze()
	{
		return g8;
	}

	[SpecialName]
	public byte zf()
	{
		return g9;
	}

	[SpecialName]
	public hg zg()
	{
		return hb;
	}

	[SpecialName]
	public he zh()
	{
		return hl;
	}

	[SpecialName]
	public bool zi()
	{
		return hb.ei();
	}

	[SpecialName]
	public string zj()
	{
		return gt.ToString();
	}

	public Guid zk()
	{
		return gt;
	}

	[SpecialName]
	public string zl()
	{
		return g6;
	}

	[SpecialName]
	public void sm(string A_0)
	{
		g6 = A_0;
	}

	public global::r.a zm()
	{
		global::r.a result;
		try
		{
			result = z0();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			result = global::r.a.c;
			ab8().c(fz.b.b, "Exception caught in HwMgr.Init(). Exception is: " + ex3.Message);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[SpecialName]
	public bool zn()
	{
		return hb.d0().n();
	}

	[SpecialName]
	public bool zo()
	{
		return hb.d0().o();
	}

	[SpecialName]
	public g2.a zp()
	{
		return hb.d0().c();
	}

	[SpecialName]
	public g2 zq()
	{
		return hb.d0();
	}

	[SpecialName]
	public es zr()
	{
		es es2 = null;
		g2 g10 = hb.d0();
		if (g10.r() == null)
		{
			return null;
		}
		if (g10.r() is et)
		{
			es2 = new et();
			((et)g10.r()).ad(es2);
			g10 = null;
			return es2;
		}
		throw new Exception("Unknown objective type");
	}

	[SpecialName]
	public cf zs()
	{
		g2 g10 = hb.d0();
		if (g10.s() == null)
		{
			return null;
		}
		return g10.s();
	}

	[SpecialName]
	public string zt()
	{
		return hb.d0().w;
	}

	[SpecialName]
	public global::h zu()
	{
		return hb.b8();
	}

	public bool zv()
	{
		Collection<m> collection = new Collection<m>();
		Collection<m> collection2 = new Collection<m>();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool result;
		try
		{
			flag2 = Monitor.TryEnter(zy(), 300);
			if (flag2)
			{
				collection = zy();
			}
			flag3 = Monitor.TryEnter(zz(), 300);
			if (flag3)
			{
				collection2 = zz();
			}
			if (!((collection.Count == 0) & (collection2.Count == 0)))
			{
				foreach (m item in collection)
				{
					m.TaskExecutionType taskExecutionType = item.d;
					if (taskExecutionType != m.TaskExecutionType.Spectrometer || item.a != m.a.f || item.l.q())
					{
						continue;
					}
					result = true;
					goto end_IL_0014;
				}
				foreach (m item2 in collection2)
				{
					m.TaskExecutionType taskExecutionType2 = item2.d;
					if (taskExecutionType2 != m.TaskExecutionType.Spectrometer || item2.a != m.a.f || item2.l.q())
					{
						continue;
					}
					result = true;
					goto end_IL_0014;
				}
				goto IL_015c;
			}
			result = false;
			end_IL_0014:;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ab8().c(fz.b.b, "Error in MeasModule.IsContactProbeStopMeasurePermissible.", a_);
			result = false;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (flag2)
			{
				Monitor.Exit(zy());
			}
			if (flag3)
			{
				Monitor.Exit(zz());
			}
		}
		goto IL_015e;
		IL_015c:
		result = flag;
		goto IL_015e;
		IL_015e:
		return result;
	}

	public bool zw()
	{
		bool flag = false;
		bool flag2 = false;
		try
		{
			if (!Monitor.TryEnter(zy(), 300))
			{
				return true;
			}
			flag = true;
			Collection<m> collection = zy();
			if (!Monitor.TryEnter(zz(), 300))
			{
				return true;
			}
			flag2 = true;
			Collection<m> collection2 = zz();
			if (collection.Count == 0 && collection2.Count == 0)
			{
				return false;
			}
			foreach (m item in collection)
			{
				m.TaskExecutionType taskExecutionType = item.d;
				if (taskExecutionType == m.TaskExecutionType.Spectrometer)
				{
					if (item.a == m.a.f && !item.l.q())
					{
						return true;
					}
					if (item.a == m.a.c && item.l != null && !item.l.q())
					{
						return true;
					}
				}
			}
			foreach (m item2 in collection2)
			{
				m.TaskExecutionType taskExecutionType2 = item2.d;
				if (taskExecutionType2 == m.TaskExecutionType.Spectrometer)
				{
					if (item2.a == m.a.f && !item2.l.q())
					{
						return true;
					}
					if (item2.a == m.a.c && item2.l != null && !item2.l.q())
					{
						return true;
					}
				}
			}
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(zy());
			}
			if (flag2)
			{
				Monitor.Exit(zz());
			}
		}
		return false;
	}

	public bool zx()
	{
		Collection<m> collection = new Collection<m>();
		Collection<m> collection2 = new Collection<m>();
		bool result = true;
		bool flag = false;
		bool flag2 = false;
		try
		{
			flag = Monitor.TryEnter(zy(), 300);
			if (flag)
			{
				collection = zy();
			}
			flag2 = Monitor.TryEnter(zz(), 300);
			if (flag2)
			{
				collection2 = zz();
			}
			if ((collection.Count == 0) & (collection2.Count == 0))
			{
				return true;
			}
			foreach (m item in collection)
			{
				m.TaskExecutionType taskExecutionType = item.d;
				if (taskExecutionType != m.TaskExecutionType.Spectrometer)
				{
					continue;
				}
				p p2 = (p)item;
				if (item.a == m.a.f)
				{
					if (zp() != g2.a.b && !item.l.q())
					{
						result = true;
					}
					if (zp() == g2.a.b && (p2.d2() == o.h || p2.d2() == o.e || p2.d2() == o.i || p2.d2() == o.f))
					{
						return false;
					}
				}
				if (item.a == m.a.c && item.l != null && !item.l.q())
				{
					return false;
				}
				if (item.a == m.a.ap && item.l != null && !item.l.q())
				{
					return false;
				}
			}
			foreach (m item2 in collection2)
			{
				m.TaskExecutionType taskExecutionType2 = item2.d;
				if (taskExecutionType2 != m.TaskExecutionType.Spectrometer)
				{
					continue;
				}
				p p3 = (p)item2;
				if (item2.a == m.a.f)
				{
					if (zp() != g2.a.b && !item2.l.q())
					{
						result = true;
					}
					if (zp() == g2.a.b && (p3.d2() == o.h || p3.d2() == o.e || p3.d2() == o.i || p3.d2() == o.f))
					{
						return false;
					}
				}
				if (item2.a == m.a.c && item2.l != null && !item2.l.q())
				{
					return false;
				}
				if (item2.a == m.a.ap && item2.l != null && !item2.l.q())
				{
					return false;
				}
			}
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(zy());
			}
			if (flag2)
			{
				Monitor.Exit(zz());
			}
		}
		return result;
	}

	public bool t5(bool A_0)
	{
		Collection<m> collection = new Collection<m>();
		Collection<m> collection2 = new Collection<m>();
		bool flag = true;
		bool flag2 = false;
		bool flag3 = false;
		bool result;
		try
		{
			flag2 = Monitor.TryEnter(zy(), 300);
			if (flag2)
			{
				collection = zy();
			}
			flag3 = Monitor.TryEnter(zz(), 300);
			if (flag3)
			{
				collection2 = zz();
			}
			if (!((collection.Count == 0) & (collection2.Count == 0)))
			{
				foreach (m item in collection)
				{
					switch (item.d)
					{
					case m.TaskExecutionType.Spectrometer:
						if (A_0 || item.a != m.a.f || item.l == null || item.l.q() || zp() == g2.a.b)
						{
							break;
						}
						result = false;
						goto end_IL_0014;
					case m.TaskExecutionType.Photodiode:
						if (!A_0 || item.a != m.a.ap || item.l == null || item.l.q())
						{
							break;
						}
						result = false;
						goto end_IL_0014;
					}
				}
				foreach (m item2 in collection2)
				{
					switch (item2.d)
					{
					case m.TaskExecutionType.Spectrometer:
						if (A_0 || item2.a != m.a.f || item2.l.q() || zp() == g2.a.b)
						{
							break;
						}
						result = false;
						goto end_IL_0014;
					case m.TaskExecutionType.Photodiode:
						if (!A_0 || item2.a != m.a.ap || item2.l.q())
						{
							break;
						}
						result = false;
						goto end_IL_0014;
					}
				}
				goto IL_01e1;
			}
			result = true;
			end_IL_0014:;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ab8().c(fz.b.b, "Error in MeasModule.IsContinuousAcquirePermissibleNewTasks.", a_);
			result = false;
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (flag2)
			{
				Monitor.Exit(zy());
			}
			if (flag3)
			{
				Monitor.Exit(zz());
			}
		}
		goto IL_01e3;
		IL_01e1:
		result = flag;
		goto IL_01e3;
		IL_01e3:
		return result;
	}
}
