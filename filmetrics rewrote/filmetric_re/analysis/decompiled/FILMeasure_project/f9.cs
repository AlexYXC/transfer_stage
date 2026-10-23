using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Timers;
using FIUsbIntLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class f9 : r
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
		l
	}

	private Collection<f0> gt;

	private string gu;

	private d gv;

	[CompilerGenerated]
	private Timer gw;

	private gt gx;

	private bool gy;

	private bool gz;

	private string g0;

	private int g1;

	private int g2;

	private bool g3;

	private h6.InternalFWLicenseRequiredReason g4;

	private bool g5;

	private string g6;

	[CompilerGenerated]
	private c g7;

	private bool g8;

	private const int g9 = 10000;

	private const string ha = "HwMgr";

	[SpecialName]
	[CompilerGenerated]
	private virtual Timer p9()
	{
		return gw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void m2(Timer A_0)
	{
		ElapsedEventHandler value = m2;
		Timer timer = gw;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		gw = A_0;
		timer = gw;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual c qh()
	{
		return g7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void m2(c A_0)
	{
		g7 = A_0;
	}

	public f9(fz A_0)
		: base(A_0, "HwMgr")
	{
		gt = new Collection<f0>();
		m2(new Timer());
		gx = null;
		gy = false;
		gz = false;
		string A_1 = DateAndTime.Now.ToString();
		g0 = hh.b(ref A_1);
	}

	public global::r.a m2(gt A_0, string A_1, ref string A_2, d A_3, c A_4, d.a.b A_5)
	{
		global::r.a a10;
		try
		{
			try
			{
				FMusbEnum obj = (FMusbEnum)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("BB8E1A15-4E65-45FA-9DE6-876792487AF7")));
				gu = i7.e();
				short VerMSH = default(short);
				short VerMSL = default(short);
				short VerLSH = default(short);
				short VerLSL = default(short);
				obj.GetVersion(ref VerMSH, ref VerMSL, ref VerLSH, ref VerLSL);
				i7.c(VerMSH, VerMSL, VerLSH, VerLSL, jg.a(f6.FMSolveVer(1)), null, null, gu);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				ab8().c(fz.b.a, "Error collecting system configuration information", a_);
				ProjectData.ClearProjectError();
			}
			A_0?.ac(gu);
			m2(A_4);
			a10 = z0();
			if (a10 == global::r.a.a)
			{
				if (m2(A_0, ref A_1, ref A_2, A_3, A_5, A_5: false) != a.a)
				{
					a10 = global::r.a.c;
				}
				else
				{
					gx = A_0;
					gv = A_3;
					p9().Interval = 10000.0;
					p9().AutoReset = true;
					p9().Stop();
					_ = gx;
				}
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception a_2 = ex3;
			a10 = global::r.a.c;
			ab8().c(fz.b.b, "Exception caught in HwMgr.Init(). ", a_2);
			ProjectData.ClearProjectError();
		}
		return a10;
	}

	[SpecialName]
	public int sj()
	{
		return g2;
	}

	[SpecialName]
	public int sm()
	{
		return g1;
	}

	public void sn()
	{
		foreach (f0 item in gt)
		{
			item.e();
		}
	}

	public void so()
	{
		p9().Stop();
	}

	public override global::r.a i(bool A_0)
	{
		if (g8)
		{
			return global::r.a.a;
		}
		global::r.a result = global::r.a.a;
		try
		{
			sn();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = global::r.a.c;
			ab8().c(fz.b.b, "Exception caught while shutting-down measurement modules. ", a_);
			ProjectData.ClearProjectError();
		}
		finally
		{
			base.i(A_0);
			g8 = true;
		}
		return result;
	}

	[SpecialName]
	public bool st()
	{
		return g3;
	}

	[SpecialName]
	public h6.InternalFWLicenseRequiredReason s3()
	{
		return g4;
	}

	[SpecialName]
	public bool s4()
	{
		return g5;
	}

	private a m2(bool A_0)
	{
		checked
		{
			a result;
			try
			{
				f0.FIDeviceErr fIDeviceErr = f0.FIDeviceErr.None;
				gy = true;
				Collection<f0> collection = new Collection<f0>();
				if (!A_0)
				{
					foreach (f0 item in gt)
					{
						if (item.ab7())
						{
							collection.Add((h6)item);
						}
					}
				}
				else
				{
					gt.Clear();
				}
				switch (h6.m2(ab8(), ref g3, ref g4, ref g5, ref g6))
				{
				case f0.FIDeviceErr.None:
				case f0.FIDeviceErr.USBCorruptedDevice:
				{
					Collection<f0> collection2 = new Collection<f0>();
					switch (h6.m2(collection, collection2, ab8(), ref g3, ref g4, ref g5, ref g6, qh()))
					{
					case f0.FIDeviceErr.Generic:
						result = a.b;
						break;
					case f0.FIDeviceErr.StageInitError:
						result = a.h;
						break;
					case f0.FIDeviceErr.FiberMuxInitError:
						result = a.k;
						break;
					case f0.FIDeviceErr.USBFirmwareNeedsUpdate:
						result = a.i;
						break;
					case f0.FIDeviceErr.WaferHandlerInitError:
						result = a.l;
						break;
					default:
						result = a.b;
						break;
					case f0.FIDeviceErr.None:
					{
						gt.Clear();
						foreach (f0 item2 in collection2)
						{
							gt.Add(item2);
						}
						string left = null;
						string text = "";
						int num = gt.Count - 1;
						int num2 = 0;
						bool flag6 = default(bool);
						bool flag2 = default(bool);
						bool flag3 = default(bool);
						bool flag7 = default(bool);
						bool flag5 = default(bool);
						bool flag = default(bool);
						bool flag4 = default(bool);
						bool flag8 = default(bool);
						TimeSpan timeSpan = default(TimeSpan);
						bool A_3 = default(bool);
						while (true)
						{
							if (num2 <= num)
							{
								if (gt[num2] is ip)
								{
									ip ip2 = (ip)gt[num2];
									switch (ip2.b())
									{
									case FMLegacyAllSystemTypes.kTypeF10:
										if (ip2.c() == 1)
										{
											if (!flag6 && !flag2 && !flag3 && !flag7 && !flag5)
											{
												flag = true;
												break;
											}
											fz obj = ab8();
											string A_1 = "ErrInitializationF10ARIncompatible";
											obj.c(fz.b.a, hu.a(ref A_1));
											result = a.d;
										}
										else if (ip2.c() == 3 || ip2.c() == 6 || ip2.c() == 8)
										{
											if (!flag6 && !flag && !flag3 && !flag7 && !flag5)
											{
												flag2 = true;
												break;
											}
											fz obj2 = ab8();
											string A_1 = "ErrInitializationF10VCIncompatible";
											obj2.c(fz.b.a, hu.a(ref A_1));
											result = a.d;
										}
										else
										{
											if (m2(flag, flag2) != a.d)
											{
												flag6 = true;
												break;
											}
											result = a.d;
										}
										goto end_IL_056e;
									case FMLegacyAllSystemTypes.kTypeF40:
									case FMLegacyAllSystemTypes.kTypeF40NSR:
										if (m2(flag, flag2) == a.d)
										{
											result = a.d;
											goto end_IL_056e;
										}
										flag5 = true;
										break;
									case FMLegacyAllSystemTypes.kTypeF20_F40:
										if (m2(flag, flag2) == a.d)
										{
											result = a.d;
											goto end_IL_056e;
										}
										flag7 = true;
										break;
									case FMLegacyAllSystemTypes.kTypeF50_200:
									case FMLegacyAllSystemTypes.kTypeF50_300:
									case FMLegacyAllSystemTypes.kTypeF50XY_450:
									case FMLegacyAllSystemTypes.kTypeF50XY_200:
									case FMLegacyAllSystemTypes.kTypeF50_200B:
									case FMLegacyAllSystemTypes.kTypeF50_300B:
									case FMLegacyAllSystemTypes.kTypeF80SS:
									case FMLegacyAllSystemTypes.kTypeF50_450B:
										if (flag4 && gt[num2] is h6 && Operators.CompareString(left, ((h6)gt[num2]).abo(), TextCompare: false) != 0)
										{
											if (ip2.b() == FMLegacyAllSystemTypes.kTypeF80SS)
											{
												ab8().c(fz.b.a, "Only one F80 system may be connected to a computer at a time. Please disconnect all but one F80.");
											}
											else
											{
												ab8().c(fz.b.a, "Only one F50 system may be connected to a computer at a time. Please disconnect all but one F50.");
											}
											result = a.d;
											goto end_IL_056e;
										}
										if (!flag4)
										{
											if (m2(flag, flag2) == a.d)
											{
												result = a.d;
												goto end_IL_056e;
											}
											flag4 = true;
											if (gt[num2] is h6)
											{
												left = ((h6)gt[num2]).abo();
											}
											flag3 = true;
											text = ip2.abp();
										}
										if (ip2.b() == FMLegacyAllSystemTypes.kTypeF50_300B && ip2.c() == 1)
										{
											if (m2(flag, flag2) == a.d)
											{
												result = a.d;
												goto end_IL_056e;
											}
											flag5 = true;
										}
										break;
									case FMLegacyAllSystemTypes.kTypeF42:
									case FMLegacyAllSystemTypes.kTypeF42Oxford:
										if (flag8)
										{
											ab8().c(fz.b.a, "Only one F42 system may be connected to a computer at a time. Please disconnect all but one F42.");
											result = a.d;
											goto end_IL_056e;
										}
										flag8 = true;
										break;
									case FMLegacyAllSystemTypes.kTypePARTS:
										if (flag6 || flag || flag3 || flag7 || flag5)
										{
											fz obj3 = ab8();
											string A_1 = "ErrInitializationF10VCIncompatible";
											obj3.c(fz.b.a, hu.a(ref A_1));
											result = a.d;
											goto end_IL_056e;
										}
										flag2 = true;
										break;
									default:
										if (m2(flag, flag2) == a.d)
										{
											result = a.d;
											goto end_IL_056e;
										}
										flag3 = true;
										text = ip2.abp();
										break;
									}
									if ((flag3 && flag8) || (flag8 & flag6) || (flag8 & flag7))
									{
										if (flag8)
										{
											if (flag8 & flag6)
											{
												ab8().c(fz.b.a, "Software has detected an F10 and an F42. Please disconnect one of them.");
											}
											else if (flag8 & flag7)
											{
												ab8().c(fz.b.a, "Software has detected an F20_F40 and an F42. Please disconnect one of them.");
											}
											else
											{
												ab8().c(fz.b.a, "Software has detected a " + text + " and an F42. Please disconnect one of them.");
											}
										}
										else if (flag7)
										{
											if (flag6 & flag7)
											{
												ab8().c(fz.b.a, "Software has detected an F10 and an F20_F40. Please disconnect one of them.");
											}
											else
											{
												ab8().c(fz.b.a, "Software has detected a " + text + " and an F20_F40. Please disconnect one of them.");
											}
										}
										else
										{
											ab8().c(fz.b.a, "Software has detected a " + text + " and an F40. Please disconnect one of them.");
										}
										result = a.d;
										break;
									}
									ip2 = null;
								}
								num2++;
								continue;
							}
							List<string> list = new List<string>();
							foreach (f0 item3 in gt)
							{
								if (!(item3 is h6))
								{
									continue;
								}
								FIUsbController fIUsbController = ((h6)item3).abk();
								if (fIUsbController.HasRtc != 0 && h6.m2(fIUsbController.FWBitPatt5) && !list.Contains(fIUsbController.SerialNumber))
								{
									double num3 = Math.Abs(fIUsbController.RtcDiscrepancy);
									try
									{
										if (num3 * 10000000.0 < 9.223372036854776E+18)
										{
											timeSpan = TimeSpan.FromSeconds(Math.Abs(fIUsbController.RtcDiscrepancy));
										}
										else
										{
											ab8().c(fz.b.a, "RTC Time Discrepancy very large");
										}
									}
									catch (Exception ex2)
									{
										ProjectData.SetProjectError(ex2);
										Exception ex3 = ex2;
										timeSpan = default(TimeSpan);
										ab8().c(fz.b.a, "RTC Time Discrepancy unrecognizable");
										ProjectData.ClearProjectError();
									}
									_ = fIUsbController.RtcDiscrepancy;
									string A_2 = null;
									int num4;
									int num5;
									int num6;
									unchecked
									{
										num4 = checked((int)Math.Round(Math.Floor(timeSpan.TotalSeconds))) % 60;
										num5 = checked((int)Math.Round(Math.Floor(timeSpan.TotalMinutes))) % 60;
										num6 = checked((int)Math.Round(Math.Floor(timeSpan.TotalHours))) % 24;
									}
									int num7 = (int)Math.Round(Math.Floor(timeSpan.TotalDays));
									int a_ = -unchecked(0 - ((num4 != 0) ? 1 : 0)) + -unchecked(0 - ((num5 != 0) ? 1 : 0)) + -unchecked(0 - ((num6 != 0) ? 1 : 0)) + -unchecked(0 - ((num7 != 0) ? 1 : 0));
									m2(a_, num4, "s", "\\s\\e\\c\\o\\n\\d", ref A_2, ref A_3);
									m2(a_, num5, "m", "\\m\\i\\n\\u\\t\\e", ref A_2, ref A_3);
									m2(a_, num6, "h", "\\h\\o\\u\\r", ref A_2, ref A_3);
									m2(a_, num7, "d", "\\d\\a\\y", ref A_2, ref A_3);
									string text2;
									if (fIUsbController.RtcDiscrepancy == 0.0)
									{
										text2 = "the same as computer time.";
									}
									else
									{
										text2 = ((!(fIUsbController.RtcDiscrepancy > 0.0)) ? "behind computer time by " : "ahead of computer time by ");
										text2 += timeSpan.ToString(A_2, CultureInfo.InvariantCulture);
									}
									list.Add(fIUsbController.SerialNumber);
									ab8().c(fz.b.a, "RTC Detected in controller " + fIUsbController.FriendlySN + "; time in rtc is " + text2);
								}
								fIUsbController = null;
							}
							result = a.a;
							break;
							continue;
							end_IL_056e:
							break;
						}
						break;
					}
					}
					break;
				}
				case f0.FIDeviceErr.USBNoDevices:
					result = a.g;
					break;
				case f0.FIDeviceErr.USBDeviceHardwareFailure:
					result = a.j;
					break;
				default:
					result = a.f;
					break;
				}
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception a_2 = ex4;
				ab8().c(fz.b.b, "Exception caught in HwMgr.InitializeDevices(). ", a_2);
				result = a.b;
				ProjectData.ClearProjectError();
			}
			finally
			{
				gy = false;
			}
			return result;
		}
	}

	private void m2(int A_0, int A_1, string A_2, string A_3, ref string A_4, ref bool A_5)
	{
		if (A_1 == 0)
		{
			return;
		}
		if (!string.IsNullOrEmpty(A_4))
		{
			if (!A_5)
			{
				A_4 = "\\ \\a\\n\\d\\ " + A_4;
				A_5 = true;
			}
			if (A_0 > 2)
			{
				A_4 = "\\," + A_4;
			}
		}
		if (A_1 > 1)
		{
			A_3 += "\\s";
		}
		A_4 = A_2 + "\\ " + A_3 + A_4;
	}

	private a m2(bool A_0, bool A_1)
	{
		if (A_0)
		{
			fz obj = ab8();
			string A_2 = "ErrInitializationF10ARIncompatible";
			obj.c(fz.b.a, hu.a(ref A_2));
			return a.d;
		}
		if (A_1)
		{
			fz obj2 = ab8();
			string A_2 = "ErrInitializationF10VCIncompatible";
			obj2.c(fz.b.a, hu.a(ref A_2));
			return a.d;
		}
		return a.a;
	}

	public a m2(ref Collection<f0> A_0)
	{
		A_0 = gt;
		return a.a;
	}

	[SpecialName]
	public string s6()
	{
		return g0;
	}

	[SpecialName]
	public string s8()
	{
		return gu;
	}

	[SpecialName]
	public float tb()
	{
		return 3f;
	}

	public a m2(gt A_0, ref string A_1, ref string A_2, d A_3, d.a.b A_4, bool A_5)
	{
		m m2 = new m(A_4);
		m2.a = m.a.a;
		m2.b = A_0 != null;
		m2.c = A_0?.a4() ?? false;
		m2.d = m.TaskExecutionType.All;
		m2.f = A_1;
		m2.g = A_3;
		m2.h = qh();
		m2.j = A_5;
		_ = null;
		return this.m2(ref A_1, ref A_2, m2);
	}

	private a m2(ref string A_0, ref string A_1, m A_2)
	{
		_ = null;
		if (sj(A_2) != global::r.a.a)
		{
			return a.b;
		}
		return a.a;
	}

	protected override void f(m A_0)
	{
		switch (A_0.d)
		{
		case m.TaskExecutionType.Spectrometer:
			m2((p)A_0);
			break;
		case m.TaskExecutionType.All:
			m2(A_0);
			break;
		}
	}

	protected override void g(m A_0)
	{
	}

	protected override void h(m A_0)
	{
	}

	private a m2(ref ip A_0, string A_1)
	{
		a result = a.a;
		try
		{
			foreach (f0 item in gt)
			{
				if (Operators.CompareString(item.ab3(), A_1, TextCompare: false) == 0)
				{
					if (item.ab4() == f0.a.c)
					{
						A_0 = (ip)item;
						break;
					}
					result = a.b;
					ab8().c(fz.b.b, "The device selected for the task is not a USB-spectrometer device.", Environment.StackTrace);
					break;
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = a.b;
			ab8().c(fz.b.b, "Exception caught in FindDevice(USB-spectrometer). Exception is: ", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void m2(p A_0)
	{
	}

	private void m2(m A_0)
	{
		d.a a10 = null;
		d.a a11 = new d.a(A_0.d3(), 0L);
		try
		{
			a11.a = d.a.a.a;
			if (A_0.g != null)
			{
				A_0.g.e(default(Guid), a11);
			}
			m.a a12 = A_0.a;
			if (a12 != m.a.a)
			{
				return;
			}
			d.a obj = (a10 = new e.a(A_0.d3(), 0L));
			a10.a = d.a.a.b;
			e.a a13 = (e.a)obj;
			int num = f6.FMSolveVer(0);
			if (num < 720)
			{
				a13.g = e.a.b.i;
				ab8().c(fz.b.a, "FMSolve version is too old. Minimum version is " + Conversions.ToString(720) + ". Currently installed version is " + Conversions.ToString(num) + ". Software is unable to run.");
				return;
			}
			short A_1 = default(short);
			short A_2 = default(short);
			short A_3 = default(short);
			short A_4 = default(short);
			b1.FIImageVer(ref A_1, ref A_2, ref A_3, ref A_4);
			Version version = new Version(A_1, A_2, A_3, A_4);
			Version version2 = new Version("1.3.0.0");
			if (version < version2)
			{
				a13.g = e.a.b.j;
				ab8().c(fz.b.a, "FIImage version is too old. Minimum version is " + version2.ToString() + ". Currently installed version is " + version.ToString() + ". Software is unable to run.");
				return;
			}
			if (A_0.b)
			{
				if (A_0.c)
				{
					a10.a = d.a.a.a;
				}
				else
				{
					a13.g = e.a.b.c;
				}
				g0 = gx.ac(ref g2, ref g1);
			}
			else
			{
				short A_5 = default(short);
				short A_6 = default(short);
				short A_7 = default(short);
				short A_8 = default(short);
				switch (h6.m2(ref A_5, ref A_6, ref A_7, ref A_8, ab8()))
				{
				case f0.FIDeviceErr.FIUsbIntCOMError:
					a13.g = e.a.b.e;
					return;
				case f0.FIDeviceErr.FIUsbIntTooOld:
					a13.g = e.a.b.d;
					return;
				case f0.FIDeviceErr.FIUsbIntXPVerError:
					a13.g = e.a.b.f;
					return;
				case f0.FIDeviceErr.FIUsbIntFileNotFoundError:
					a13.g = e.a.b.g;
					return;
				default:
					a13.g = e.a.b.h;
					return;
				case f0.FIDeviceErr.None:
					break;
				}
				switch (m2(Conversions.ToBoolean(A_0.j)))
				{
				case a.a:
					a10.a = d.a.a.a;
					break;
				case a.g:
					a13.g = e.a.b.b;
					break;
				case a.d:
					a13.g = e.a.b.k;
					break;
				case a.i:
					a13.g = e.a.b.v;
					break;
				case a.j:
					a13.g = e.a.b.ai;
					((d.a)a13).b = g6;
					break;
				case a.k:
					if (g3)
					{
						a13.g = tc();
					}
					else
					{
						a13.g = e.a.b.an;
					}
					break;
				}
			}
			a13 = null;
		}
		finally
		{
			if (A_0.g != null)
			{
				A_0.g.d(default(Guid), a10);
			}
		}
	}

	private void m2(object A_0, EventArgs A_1)
	{
		if (!gy & !gz)
		{
			m2();
		}
	}

	private void m2()
	{
		string A_ = "";
		try
		{
			if (!gz)
			{
				gz = true;
				gt a_ = gx;
				string A_2 = "HwConfigCheck";
				string A_3 = hu.a(ref A_2);
				m2(a_, ref A_3, ref A_, gv, d.a.b.a, A_5: false);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			ab8().c(fz.b.b, "Exception caught in CheckHwConfig(). ", a_2);
			ProjectData.ClearProjectError();
		}
		finally
		{
			gz = false;
		}
	}

	public e.a.b tc()
	{
		return g4 switch
		{
			h6.InternalFWLicenseRequiredReason.ControllerWithMissingDevices => e.a.b.w, 
			h6.InternalFWLicenseRequiredReason.AccessoryOnly => e.a.b.y, 
			h6.InternalFWLicenseRequiredReason.MissingLightSource => e.a.b.x, 
			h6.InternalFWLicenseRequiredReason.MissingSubSystem => e.a.b.z, 
			h6.InternalFWLicenseRequiredReason.DeviceValidationFailure => e.a.b.ab, 
			h6.InternalFWLicenseRequiredReason.ControllerValidationFailure => e.a.b.ac, 
			h6.InternalFWLicenseRequiredReason.MisProgrammedMinIntTime => e.a.b.aj, 
			h6.InternalFWLicenseRequiredReason.InitializingMotorController => e.a.b.n, 
			h6.InternalFWLicenseRequiredReason.MotorBaudRateModified => e.a.b.o, 
			h6.InternalFWLicenseRequiredReason.TestingDOUTToDINConnection => e.a.b.p, 
			h6.InternalFWLicenseRequiredReason.InitializingRotaryMotor => e.a.b.q, 
			h6.InternalFWLicenseRequiredReason.SettingRotaryMicrostepResolution => e.a.b.r, 
			h6.InternalFWLicenseRequiredReason.SettingRotarySoftStopFlag => e.a.b.s, 
			h6.InternalFWLicenseRequiredReason.EnergizingMotors => e.a.b.t, 
			h6.InternalFWLicenseRequiredReason.MissingHardware => e.a.b.u, 
			h6.InternalFWLicenseRequiredReason.NotchFlatFindSpectrometerNotFound => e.a.b.ao, 
			h6.InternalFWLicenseRequiredReason.NotchFlatFindSpectrometerUnexpected => e.a.b.ap, 
			h6.InternalFWLicenseRequiredReason.NotchFlatFindSpectrometerOrphan => e.a.b.aq, 
			h6.InternalFWLicenseRequiredReason.MisprogrammedControllerSN => e.a.b.ar, 
			_ => e.a.b.b, 
		};
	}
}
