using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Filmetrics;
using Microsoft.VisualBasic.CompilerServices;

internal abstract class r : q
{
	public enum a
	{
		a,
		b,
		c
	}

	private enum b
	{
		a,
		b
	}

	public class c
	{
		public delegate void a(c A_0);

		public delegate void b(c A_0, bool A_1);

		public bool a;

		private float m_b;

		private float m_c;

		private string d;

		private string e;

		private string f;

		private string g;

		private string h;

		private bool i;

		private AutoResetEvent j;

		private d.a.b k;

		private int l;

		public int m;

		public bool n;

		private int o;

		private int p;

		private float q;

		private DateTime r;

		[CompilerGenerated]
		private b s;

		[CompilerGenerated]
		private a m_t;

		[CompilerGenerated]
		private a m_u;

		public c()
		{
			j = new AutoResetEvent(initialState: true);
		}

		[SpecialName]
		[CompilerGenerated]
		public void t(b A_0)
		{
			b b10 = s;
			b b11;
			do
			{
				b11 = b10;
				b value = (b)Delegate.Combine(b11, A_0);
				b10 = Interlocked.CompareExchange(ref s, value, b11);
			}
			while ((object)b10 != b11);
		}

		[SpecialName]
		[CompilerGenerated]
		public void u(b A_0)
		{
			b b10 = s;
			b b11;
			do
			{
				b11 = b10;
				b value = (b)Delegate.Remove(b11, A_0);
				b10 = Interlocked.CompareExchange(ref s, value, b11);
			}
			while ((object)b10 != b11);
		}

		[SpecialName]
		[CompilerGenerated]
		public void t(a A_0)
		{
			a a10 = this.m_t;
			a a11;
			do
			{
				a11 = a10;
				a value = (a)Delegate.Combine(a11, A_0);
				a10 = Interlocked.CompareExchange(ref this.m_t, value, a11);
			}
			while ((object)a10 != a11);
		}

		[SpecialName]
		[CompilerGenerated]
		public void u(a A_0)
		{
			a a10 = this.m_t;
			a a11;
			do
			{
				a11 = a10;
				a value = (a)Delegate.Remove(a11, A_0);
				a10 = Interlocked.CompareExchange(ref this.m_t, value, a11);
			}
			while ((object)a10 != a11);
		}

		[SpecialName]
		[CompilerGenerated]
		public void v(a A_0)
		{
			a a10 = this.m_u;
			a a11;
			do
			{
				a11 = a10;
				a value = (a)Delegate.Combine(a11, A_0);
				a10 = Interlocked.CompareExchange(ref this.m_u, value, a11);
			}
			while ((object)a10 != a11);
		}

		[SpecialName]
		[CompilerGenerated]
		public void w(a A_0)
		{
			a a10 = this.m_u;
			a a11;
			do
			{
				a11 = a10;
				a value = (a)Delegate.Remove(a11, A_0);
				a10 = Interlocked.CompareExchange(ref this.m_u, value, a11);
			}
			while ((object)a10 != a11);
		}

		[SpecialName]
		public float t()
		{
			return m_c;
		}

		public void t(float A_0)
		{
			m_c = A_0;
			o = 0;
			s?.Invoke(this, A_1: false);
		}

		[SpecialName]
		public string u()
		{
			return d;
		}

		[SpecialName]
		public int v()
		{
			return o;
		}

		[SpecialName]
		public int w()
		{
			return p;
		}

		[SpecialName]
		public DateTime x()
		{
			return r;
		}

		[SpecialName]
		public float y()
		{
			return q;
		}

		public void t(string A_0)
		{
			d = A_0;
			s?.Invoke(this, A_1: false);
		}

		public bool t(string A_0, string A_1, string A_2, string A_3)
		{
			e = A_0;
			f = A_1;
			g = A_2;
			h = A_3;
			j.Reset();
			s?.Invoke(this, A_1: true);
			j.WaitOne();
			return i;
		}

		public bool t(string A_0, string A_1)
		{
			e = A_0;
			f = A_1;
			g = "OK";
			h = null;
			j.Reset();
			s?.Invoke(this, A_1: true);
			j.WaitOne();
			return true;
		}

		public void t(bool A_0)
		{
			i = A_0;
			j.Set();
		}

		public void t(int A_0)
		{
			l = A_0;
			s?.Invoke(this, A_1: false);
		}

		public void t(float A_0, d.a.b A_1)
		{
			this.m_b = A_0;
			k = A_1;
			m_c = 0f;
			this.m_t?.Invoke(this);
			n = true;
		}

		public void z()
		{
			this.m_u?.Invoke(this);
			n = false;
		}

		public void u(int A_0)
		{
			o = A_0;
			p = 0;
			s?.Invoke(this, A_1: false);
		}

		public void t(int A_0, DateTime A_1, float A_2)
		{
			p = A_0;
			r = A_1;
			q = A_2;
			s?.Invoke(this, A_1: false);
		}

		[SpecialName]
		public d.a.b aa()
		{
			return k;
		}

		[SpecialName]
		public float ab()
		{
			return this.m_b;
		}

		[SpecialName]
		public int ac()
		{
			return l;
		}

		[SpecialName]
		public string ad()
		{
			return e;
		}

		[SpecialName]
		public string ae()
		{
			return f;
		}

		[SpecialName]
		public string af()
		{
			return g;
		}

		[SpecialName]
		public string ag()
		{
			return h;
		}
	}

	internal class d
	{
		public class a : EventArgs
		{
			public enum a
			{
				a,
				b
			}

			public enum b
			{
				a,
				b
			}

			public a a;

			public string b;

			public Guid c;

			public object d;

			private b e;

			private long f;

			protected bool g;

			public a(b A_0, long A_1)
			{
				e = A_0;
				f = A_1;
			}

			public override bool Equals(object obj)
			{
				d.a a10 = (d.a)obj;
				if (this.a != a10.a)
				{
					return false;
				}
				if (Operators.CompareString(this.b, a10.b, TextCompare: false) != 0)
				{
					return false;
				}
				if (e != a10.e)
				{
					return false;
				}
				a10 = null;
				return true;
			}

			public virtual void a(d.a A_0)
			{
				if (!g)
				{
					g = true;
				}
				if (A_0.a != global::r.d.a.a.a)
				{
					a a10 = A_0.a;
					if (a10 != global::r.d.a.a.b)
					{
						throw new ApplicationException("Unhandled TaskCompletion.EventArgs.Result");
					}
					this.a = global::r.d.a.a.b;
					if (!string.IsNullOrEmpty(this.b) && !string.IsNullOrEmpty(A_0.b))
					{
						this.b += "\r\n";
					}
					this.b += A_0.b;
				}
			}

			[SpecialName]
			public long a7()
			{
				return f;
			}

			[SpecialName]
			public b a8()
			{
				return e;
			}
		}

		public delegate void b(a A_0);

		public delegate void c(a A_0);

		private long m_a;

		[CompilerGenerated]
		private b m_b;

		[CompilerGenerated]
		private c m_c;

		[SpecialName]
		[CompilerGenerated]
		public void d(b A_0)
		{
			b b10 = this.m_b;
			b b11;
			do
			{
				b11 = b10;
				b value = (b)Delegate.Combine(b11, A_0);
				b10 = Interlocked.CompareExchange(ref this.m_b, value, b11);
			}
			while ((object)b10 != b11);
		}

		[SpecialName]
		[CompilerGenerated]
		public void e(b A_0)
		{
			b b10 = this.m_b;
			b b11;
			do
			{
				b11 = b10;
				b value = (b)Delegate.Remove(b11, A_0);
				b10 = Interlocked.CompareExchange(ref this.m_b, value, b11);
			}
			while ((object)b10 != b11);
		}

		public void d(Guid A_0, a A_1)
		{
			if (A_1 != null)
			{
				A_1.c = A_0;
			}
			this.m_b?.Invoke(A_1);
		}

		[SpecialName]
		[CompilerGenerated]
		public void d(c A_0)
		{
			c c10 = this.m_c;
			c c11;
			do
			{
				c11 = c10;
				c value = (c)Delegate.Combine(c11, A_0);
				c10 = Interlocked.CompareExchange(ref this.m_c, value, c11);
			}
			while ((object)c10 != c11);
		}

		[SpecialName]
		[CompilerGenerated]
		public void e(c A_0)
		{
			c c10 = this.m_c;
			c c11;
			do
			{
				c11 = c10;
				c value = (c)Delegate.Remove(c11, A_0);
				c10 = Interlocked.CompareExchange(ref this.m_c, value, c11);
			}
			while ((object)c10 != c11);
		}

		public void e(Guid A_0, a A_1)
		{
			A_1.c = A_0;
			this.m_c?.Invoke(A_1);
		}

		public d()
		{
		}

		public d(long A_0)
		{
			this.m_a = A_0;
		}

		[SpecialName]
		public long d()
		{
			return this.m_a;
		}
	}

	internal class e : d
	{
		public new class a : d.a
		{
			public new class a
			{
				public Collection<b> a;

				public Collection<string> b;
			}

			public new enum b
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
				m,
				n,
				o,
				p,
				q,
				r,
				s,
				t,
				u,
				v,
				w,
				x,
				y,
				z,
				aa,
				ab,
				ac,
				ad,
				ae,
				af,
				ag,
				ah,
				ai,
				aj,
				ak,
				al,
				am,
				an,
				ao,
				ap,
				aq,
				ar
			}

			public new b g;

			public a(d.a.b A_0, long A_1)
				: base(A_0, A_1)
			{
			}

			public override void a(d.a A_0)
			{
				base.a(A_0);
				e.a a10 = (e.a)A_0;
				if (a10.g != b.a)
				{
					g = a10.g;
				}
				a10 = null;
			}

			public string a6(bool A_0)
			{
				return a6(g, A_0);
			}

			public static string a6(b A_0, bool A_1)
			{
				if (!A_1 && (A_0 == b.ac || A_0 == b.ab))
				{
					string A_2 = "NonProprietarySystemFailure";
					return hu.a(ref A_2);
				}
				switch (A_0)
				{
				case b.b:
				{
					string A_2 = "ErrInitializationNoSystemsDetected";
					return hu.a(ref A_2);
				}
				case b.d:
				{
					string A_2 = "ErrInitializationDllTooOldFmt";
					return string.Format(hu.a(ref A_2), "FIUsbInt");
				}
				case b.e:
				{
					string A_2 = "DllUnregisteredFmt";
					return string.Format(hu.a(ref A_2), "FIUsbInt");
				}
				case b.f:
				{
					string A_2 = "DllXPVersionErrorFmt";
					return string.Format(hu.a(ref A_2), "FIUsbInt");
				}
				case b.g:
				{
					string A_2 = "DllFileNotFoundErrorFmt";
					return string.Format(hu.a(ref A_2), "FIUsbInt");
				}
				case b.h:
				{
					string A_2 = "DllUnknownErrorFmt";
					return string.Format(hu.a(ref A_2), "FIUsbInt");
				}
				case b.i:
				{
					string A_2 = "ErrInitializationDllTooOldFmt";
					return string.Format(hu.a(ref A_2), "FMSolve");
				}
				case b.j:
				{
					string A_2 = "ErrInitializationDllTooOldFmt";
					return string.Format(hu.a(ref A_2), "FIImage");
				}
				case b.k:
				{
					string A_2 = "ErrInitializationSystemsIncompatible";
					string text = hu.a(ref A_2) + ":" + Environment.NewLine;
					A_2 = "ErrInitializationF10VCIncompatible";
					string text2 = text + "   " + hu.a(ref A_2) + Environment.NewLine;
					A_2 = "ErrInitializationF10ARIncompatible";
					return text2 + "   " + hu.a(ref A_2);
				}
				case b.v:
				{
					string A_2 = "ErrInitializationConFWNeedsUpdate";
					return hu.a(ref A_2);
				}
				case b.w:
				{
					string A_2 = "ErrControllerWithoutDevices";
					return hu.a(ref A_2);
				}
				case b.y:
				{
					string A_2 = "ErrAccessoryWithoutSystem";
					return hu.a(ref A_2);
				}
				case b.x:
				{
					string A_2 = "ErrMissingLightSource";
					return hu.a(ref A_2);
				}
				case b.z:
				{
					string A_2 = "ErrMissingSubSystem";
					return hu.a(ref A_2);
				}
				case b.aa:
				{
					string A_2 = "ErrConflictingSubSystems";
					return hu.a(ref A_2);
				}
				case b.ab:
				{
					string A_2 = "ErrDeviceValidationFailure";
					return hu.a(ref A_2);
				}
				case b.ac:
				{
					string A_2 = "ErrControllerValidationFailure";
					return hu.a(ref A_2);
				}
				case b.l:
				{
					string A_2 = "WarnStartupRecipeLoadError";
					return hu.a(ref A_2);
				}
				case b.ae:
				{
					string A_2 = "ErrScatterStationMissingOrTooManySystems";
					return hu.a(ref A_2);
				}
				case b.af:
				{
					string A_2 = "ErrScatterStationTooManyStations";
					return hu.a(ref A_2);
				}
				case b.ag:
				{
					string A_2 = "WarnScatterStationTooFewControllers";
					return hu.a(ref A_2);
				}
				case b.ah:
				{
					string A_2 = "WarnScatterStationTooManyControllers";
					return hu.a(ref A_2);
				}
				case b.ai:
				{
					string A_2 = "ErrUSBDeviceHardwareFailure";
					return hu.a(ref A_2);
				}
				case b.aj:
				{
					string A_2 = "ErrUSBDeviceMisProgrammedMinIntTime";
					return hu.a(ref A_2);
				}
				case b.ak:
				{
					string A_2 = "WarnModuleControllersFWOutOfSynch";
					return hu.a(ref A_2);
				}
				case b.al:
				{
					string A_2;
					if (A_1)
					{
						A_2 = "WarnNumExpectedControllersNotFoundInternal";
						return hu.a(ref A_2);
					}
					A_2 = "WarnNumExpectedControllersOrSubmodulesNotFound";
					return hu.a(ref A_2);
				}
				case b.am:
				{
					string A_2;
					if (A_1)
					{
						A_2 = "WarnNumExpectedSubmodulesNotFoundInternal";
						return hu.a(ref A_2);
					}
					A_2 = "WarnNumExpectedControllersOrSubmodulesNotFound";
					return hu.a(ref A_2);
				}
				case b.ao:
				{
					string A_2;
					if (A_1)
					{
						A_2 = "WarnNotchFlatFindSpectrometerNotFoundInternal";
						return hu.a(ref A_2);
					}
					A_2 = "WarnNumExpectedControllersOrSubmodulesNotFound";
					return hu.a(ref A_2);
				}
				case b.ap:
				{
					string A_2;
					if (A_1)
					{
						A_2 = "WarnNotchFlatFindSpectrometerUnexpectedInternal";
						return hu.a(ref A_2);
					}
					A_2 = "WarnSpectrometerUnKnown";
					return hu.a(ref A_2);
				}
				case b.aq:
				{
					string A_2;
					if (A_1)
					{
						A_2 = "WarnNotchFlatFindSpectrometerUsedForMeasInternal";
						return hu.a(ref A_2);
					}
					A_2 = "WarnSpectrometerInitError";
					return hu.a(ref A_2);
				}
				case b.u:
				{
					string A_2 = "ErrMissingHardware";
					return hu.a(ref A_2);
				}
				case b.ar:
				{
					string A_2 = "ErrMisprogrammedControllerSN";
					return hu.a(ref A_2);
				}
				default:
				{
					string A_2 = "UnknownErrFmt";
					string format = hu.a(ref A_2);
					A_2 = "SystemInitialization";
					return string.Format(format, hu.a(ref A_2));
				}
				}
			}
		}
	}

	internal class f : d
	{
		public new class a : d.a
		{
			public Guid h;

			public f.a i;

			public a(b A_0, long A_1)
				: base(A_0, A_1)
			{
			}

			public override bool Equals(object obj)
			{
				if (!base.Equals(RuntimeHelpers.GetObjectValue(obj)))
				{
					return false;
				}
				f.a a10 = (f.a)obj;
				if (h != a10.h)
				{
					return false;
				}
				a10 = null;
				return true;
			}
		}
	}

	internal class g : f
	{
		public new class a : f.a
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
				m,
				n,
				o,
				p,
				q,
				r,
				s,
				t,
				u
			}

			public a j;

			public float k;

			public float l;

			public float m;

			public float n;

			public string o;

			public bool p;

			public bool q;

			public global::h.f r;

			public bool s;

			public byte t;

			public bool u;

			public bool v;

			public a(b A_0, long A_1)
				: base(A_0, A_1)
			{
			}

			public override bool Equals(object obj)
			{
				if (!base.Equals(RuntimeHelpers.GetObjectValue(obj)))
				{
					return false;
				}
				g.a a10 = (g.a)obj;
				if (j != a10.j)
				{
					return false;
				}
				if (k != a10.k)
				{
					return false;
				}
				if (l != a10.l)
				{
					return false;
				}
				if (m != a10.m)
				{
					return false;
				}
				if (Operators.CompareString(o, a10.o, TextCompare: false) != 0)
				{
					return false;
				}
				if (p != a10.p)
				{
					return false;
				}
				if (q != a10.q)
				{
					return false;
				}
				if (r != a10.r)
				{
					return false;
				}
				if (s != a10.s)
				{
					return false;
				}
				a10 = null;
				return true;
			}

			public override void a(d.a A_0)
			{
				base.a(A_0);
				g.a a10 = (g.a)A_0;
				if (a10.j != global::r.g.a.a.a)
				{
					j = a10.j;
					k = a10.k;
					l = a10.l;
					m = a10.m;
					o = a10.o;
					p = a10.p;
					q = a10.q;
					r = a10.r;
					s = a10.s;
				}
				a10 = null;
			}

			public static bool a6(a A_0)
			{
				switch (A_0)
				{
				case global::r.g.a.a.i:
				case global::r.g.a.a.j:
				case global::r.g.a.a.k:
				case global::r.g.a.a.q:
				case global::r.g.a.a.r:
					return true;
				default:
					return false;
				}
			}

			public string a6()
			{
				if (j == global::r.g.a.a.t)
				{
					return ((d.a)this).b;
				}
				if (j == global::r.g.a.a.a && !string.IsNullOrEmpty(((d.a)this).b))
				{
					return ((d.a)this).b;
				}
				return a6(j, o, k, l, p, q, r, s, u, v);
			}

			public static string a6(a A_0, string A_1, float A_2, float A_3, bool A_4, bool A_5, global::h.f A_6, bool A_7, bool A_8, bool A_9)
			{
				switch (A_0)
				{
				case global::r.g.a.a.b:
				{
					string A_10 = "ErrAutoRefLampIsOff";
					return hu.a(ref A_10);
				}
				case global::r.g.a.a.c:
				{
					string text;
					if (A_7)
					{
						if (A_6 == global::h.f.b)
						{
							string A_10 = "AutoBaselineErrorNoLightRAndTTrans";
							text = hu.a(ref A_10);
						}
						else
						{
							string A_10 = "AutoBaselineErrorNoLightRAndTRefl";
							text = hu.a(ref A_10);
						}
					}
					else
					{
						string A_10 = "AutoBaselineErrorNoLight";
						text = hu.a(ref A_10);
					}
					if (A_9 && A_2 < 100f)
					{
						string text2 = text;
						string A_10 = "MasterLevelLightOutputPct";
						text = text2 + "\r\n" + string.Format(hu.a(ref A_10), A_2.ToString(CultureInfo.CurrentCulture));
					}
					return text;
				}
				case global::r.g.a.a.d:
				{
					string A_10 = "ErrAutoRefStableInvalid";
					return hu.a(ref A_10);
				}
				case global::r.g.a.a.e:
				{
					string A_10 = "AutoscaleLightTooBright";
					return hu.a(ref A_10);
				}
				case global::r.g.a.a.f:
				{
					string A_10 = "USBSpecSignalNotProportionalToIntError";
					return hu.a(ref A_10);
				}
				case global::r.g.a.a.h:
				{
					string A_10 = "USBSpecHardwareFailureNoSat";
					return hu.a(ref A_10);
				}
				case global::r.g.a.a.m:
				{
					string A_10 = "ErrIntTimeSettingFailure";
					return hu.a(ref A_10);
				}
				case global::r.g.a.a.o:
				{
					string A_10 = "ErrAcqNotPossibleWithCurrentSettings";
					return hu.a(ref A_10);
				}
				case global::r.g.a.a.p:
				{
					string A_10 = "ErrRefAmplDriftFmt2";
					return string.Format(hu.a(ref A_10), A_2.ToString("0.00%"), A_3.ToString("0.00%"));
				}
				case global::r.g.a.a.i:
				{
					string A_10 = "USBSpecAcquireSatAtFixedIntTimeError";
					return hu.a(ref A_10);
				}
				case global::r.g.a.a.j:
				{
					string A_10 = "USBSpecAcquireSatAtFixedIntTimeErrorFmt";
					return string.Format(hu.a(ref A_10), a6(A_4, A_5, A_6, A_7));
				}
				case global::r.g.a.a.k:
				{
					string A_10 = "USBSpecAcquireSatAtMinIntTimeError";
					return hu.a(ref A_10);
				}
				case global::r.g.a.a.l:
				{
					string A_10 = "ErrZeroDuringMeas";
					return hu.a(ref A_10);
				}
				case global::r.g.a.a.q:
				{
					string A_10;
					if (A_6 == global::h.f.b)
					{
						A_10 = "USBSpecAcquireTSatDuringAcquireRecOrMaxTint";
						return hu.a(ref A_10);
					}
					if (A_8)
					{
						A_10 = "USBSpecAcquireSatDuringAcquireRecOrMaxTintHctFmt";
						return string.Format(hu.a(ref A_10), a6(A_4, A_5, A_6, A_7));
					}
					A_10 = "USBSpecAcquireSatDuringAcquireRecOrMaxTintFmt";
					return string.Format(hu.a(ref A_10), a6(A_4, A_5, A_6, A_7));
				}
				case global::r.g.a.a.n:
				{
					string A_10 = "USBSpecAcquireErrorFmt";
					return string.Format(hu.a(ref A_10), A_1);
				}
				case global::r.g.a.a.s:
				{
					string A_10 = "AbbrevBaselineLastTIntTimeSaturation";
					return hu.a(ref A_10);
				}
				case global::r.g.a.a.t:
					return A_1;
				case global::r.g.a.a.u:
				{
					string A_10 = "USBSpecAcquireErrorUnknown";
					return hu.a(ref A_10);
				}
				default:
				{
					string A_10 = "USBSpecAcquireErrorUnknown";
					return hu.a(ref A_10);
				}
				}
			}

			public static string a6(bool A_0, bool A_1, global::h.f A_2, bool A_3)
			{
				string arg = string.Empty;
				string arg2 = string.Empty;
				string A_4;
				if (A_1)
				{
					if (A_0)
					{
						A_4 = "SpectrometerIdentificationShortWave";
						arg2 = hu.a(ref A_4);
					}
					else
					{
						A_4 = "SpectrometerIdentificationLongWave";
						arg2 = hu.a(ref A_4);
					}
				}
				if (A_3)
				{
					switch (A_2)
					{
					case global::h.f.a:
						A_4 = "SubmoduleIDReflectance";
						arg = hu.a(ref A_4);
						break;
					case global::h.f.b:
						A_4 = "SubmoduleIDTransmittance";
						arg = hu.a(ref A_4);
						break;
					case global::h.f.c:
						A_4 = "SubmoduleIDReflectanceAtAngle";
						arg = hu.a(ref A_4);
						break;
					}
				}
				A_4 = "SpectrometerIdentificationFmt2";
				return string.Format(hu.a(ref A_4), arg2, arg);
			}
		}
	}

	internal class h : f
	{
		public new class a : f.a
		{
			public hr w;

			public bool x;

			public bool y;

			public hc z;

			public bool aa;

			public a(b A_0, long A_1, eo.a A_2)
				: base(A_0, A_1)
			{
				w = new hr(A_2);
			}
		}
	}

	internal class i : f
	{
		public new enum a
		{
			a,
			b,
			c
		}

		public new class b : f.a
		{
			public hc ab;

			public cb ac;

			public i.a ad;

			public bool ae;

			public bool af;

			public b(b A_0, long A_1)
				: base(A_0, A_1)
			{
			}
		}
	}

	internal class j : f
	{
		public new class a : f.a
		{
			public float ag;

			public bool ah;

			public bool ai;

			public bool aj;

			public float ak;

			public bool al;

			public bool am;

			public bool an;

			public a(b A_0, long A_1)
				: base(A_0, A_1)
			{
			}
		}
	}

	internal class k : d
	{
		public new class a : d.a
		{
			public int ao;

			public string ap;

			public float aq;

			public float ar;

			public bool @as;

			public bool at;

			public global::h.f au;

			public bool av;

			public a(b A_0, long A_1)
				: base(A_0, A_1)
			{
			}

			public override void a(d.a A_0)
			{
				base.a(A_0);
			}
		}
	}

	internal class l
	{
		private bool a;

		private int b;

		private string c;

		private float d;

		private float e;

		private bool f;

		private bool g;

		private global::h.f h;

		private bool i;

		public bool j;

		private d.a.a k;

		public bool l;

		public d m;

		[SpecialName]
		public bool q()
		{
			return a;
		}

		[SpecialName]
		public void q(bool A_0)
		{
			a = A_0;
			b = 0;
			k = global::r.d.a.a.a;
		}

		[SpecialName]
		public void q(int A_0, d.a.a A_1, bool A_2)
		{
			a = A_2;
			b = A_0;
			k = A_1;
		}

		[SpecialName]
		public void q(int A_0, d.a.a A_1, string A_2, float A_3, float A_4, bool A_5)
		{
			a = A_5;
			b = A_0;
			c = A_2;
			d = A_3;
			e = A_4;
			k = A_1;
		}

		[SpecialName]
		public void q(int A_0, d.a.a A_1, string A_2, float A_3, float A_4, bool A_5, bool A_6, global::h.f A_7, bool A_8, bool A_9)
		{
			a = A_9;
			b = A_0;
			c = A_2;
			d = A_3;
			e = A_4;
			k = A_1;
			f = A_5;
			g = A_6;
			h = A_7;
			i = A_8;
		}

		[SpecialName]
		public bool r()
		{
			return f;
		}

		[SpecialName]
		public bool s()
		{
			return g;
		}

		[SpecialName]
		public global::h.f t()
		{
			return h;
		}

		[SpecialName]
		public bool u()
		{
			return i;
		}

		[SpecialName]
		public int v()
		{
			return b;
		}

		[SpecialName]
		public string w()
		{
			return c;
		}

		[SpecialName]
		public float x()
		{
			return d;
		}

		[SpecialName]
		public float y()
		{
			return e;
		}

		[SpecialName]
		public d.a.a z()
		{
			return k;
		}
	}

	internal class m
	{
		public enum a
		{
			a = 1,
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
			m,
			n,
			o,
			p,
			q,
			r,
			s,
			t,
			u,
			v,
			w,
			x,
			y,
			z,
			aa,
			ab,
			ac,
			ad,
			ae,
			af,
			ag,
			ah,
			ai,
			aj,
			ak,
			al,
			am,
			an,
			ao,
			ap,
			aq,
			ar,
			@as,
			at,
			au,
			av,
			aw,
			ax,
			ay,
			az,
			a0,
			a1,
			a2,
			a3,
			a4,
			a5,
			a6,
			a7,
			a8,
			a9,
			ba,
			bb,
			bc,
			bd,
			be,
			bf,
			bg,
			bh,
			bi,
			bj,
			bk,
			bl,
			bm,
			bn,
			bo,
			bp,
			bq,
			br,
			bs,
			bt,
			bu,
			bv,
			bw,
			bx,
			by,
			bz,
			b0,
			b1,
			b2,
			b3,
			b4
		}

		public enum TaskExecutionType
		{
			None,
			All,
			Spectrometer,
			SpectrometerNonSpectrum,
			SpectrometerTestAndCal,
			MeasEngine,
			Setup,
			Camera,
			Execution,
			VideoCamera,
			StageSpec,
			System,
			Photodiode,
			ZStageSpec,
			ScatterBox,
			WaferHandler,
			LightTower,
			CassetteBarcodeReader,
			Secs_GEM
		}

		public a a;

		public bool b;

		public bool c;

		public TaskExecutionType d;

		public Guid e;

		public string f;

		public d g;

		public c h;

		public bool i;

		public object j;

		private d.a.b k;

		public l l;

		public m(d.a.b A_0)
		{
			k = A_0;
			f = "";
			d = TaskExecutionType.All;
		}

		[SpecialName]
		public d.a.b d3()
		{
			return k;
		}
	}

	public enum n
	{
		a = -1,
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
		m,
		n,
		o
	}

	public enum o
	{
		a = -1,
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

	protected class p : m
	{
		public bool m;

		public n[] n;

		public double o;

		public short p;

		public bool q;

		public bool r;

		public bool s;

		public int t;

		public int u;

		public string v;

		public string w;

		public bool x;

		public bool y;

		public bool[] z;

		public bool aa;

		public float[] ab;

		public bool ac;

		public bool ad;

		public bool ae;

		public bool af;

		public bool ag;

		public int ah;

		public short ai;

		public bool aj;

		public bool ak;

		public bool al;

		public t am;

		public int an;

		public bool ao;

		public int ap;

		public string aq;

		public bool ar;

		public bool @as;

		public bool at;

		public bool au;

		public double av;

		public bool aw;

		public bool ax;

		public double ay;

		public bool az;

		public h6.b a0;

		private o a1;

		private long a2;

		private long a3;

		public p(long A_0, d.a.b A_1)
			: base(A_1)
		{
			ab = new float[checked(Enum.GetValues(typeof(global::h.h)).GetUpperBound(0) + 1)];
			a2 = A_0;
			a3 = 0L;
			d = TaskExecutionType.Spectrometer;
			d0(global::r.o.a);
		}

		[SpecialName]
		public long d0()
		{
			return a2;
		}

		[SpecialName]
		public void d0(long A_0)
		{
			a2 = A_0;
			a3 = 0L;
		}

		[SpecialName]
		public long d1()
		{
			return a3;
		}

		[SpecialName]
		public void d1(long A_0)
		{
			a3 = A_0;
		}

		[SpecialName]
		public o d2()
		{
			return a1;
		}

		[SpecialName]
		public void d0(o A_0)
		{
			a1 = A_0;
		}

		[SpecialName]
		public bool d0(n A_0)
		{
			n[] array = n;
			for (int num = 0; num < array.Length; num = checked(num + 1))
			{
				if (array[num] == A_0)
				{
					return false;
				}
			}
			return true;
		}

		[SpecialName]
		public bool d1(n A_0)
		{
			n[] array = n;
			for (int num = 0; num < array.Length; num = checked(num + 1))
			{
				if (array[num] == A_0)
				{
					return true;
				}
			}
			return false;
		}
	}

	protected class q : m
	{
		public int a6;

		public global::f.b a7;

		public h6.a a8;

		public byte a9;

		public short ba;

		public short bb;

		public Collection<cf> bc;

		public bool bd;

		public bool be;

		public float bf;

		public int bg;

		public bool bh;

		public h6.b bi;

		public q(d.a.b A_0)
			: base(A_0)
		{
			d = TaskExecutionType.SpectrometerNonSpectrum;
		}
	}

	protected class r : m
	{
		public bool bj;

		public bool bk;

		public bool bl;

		public hr bm;

		public Collection<hr> bn;

		public string[] bo;

		public string bp;

		public ho bq;

		public short br;

		public bool bs;

		public a6 bt;

		public bool bu;

		public r(d.a.b A_0)
			: base(A_0)
		{
		}
	}

	protected class s : m
	{
		public hg bv;

		public es bw;

		public string bx;

		public bool by;

		public bool bz;

		public bool b0;

		public bool b1;

		public g2 b2;

		public string b3;

		public string b4;

		public string b5;

		public bool b6;

		public string b7;

		public jf.a b8;

		public long b9;

		public bool ca;

		public bool cb;

		public bool cc;

		public bool cd;

		public s(d.a.b A_0)
			: base(A_0)
		{
		}
	}

	protected class t : m
	{
		public DateTime ce;

		public float cf;

		public t(d.a.b A_0)
			: base(A_0)
		{
		}
	}

	protected class u : m
	{
		public enum CameraVideoTaskType
		{
			SetFocus,
			SetZoom,
			SetScroll,
			InitCamera,
			StartVideo,
			StopVideo,
			SettingsFromDialog,
			CalibrateSpot,
			ConfigVideoSettingFromUI,
			DeAllocation,
			ChangeVideoImageRotation,
			ContinuousImage,
			ReinitCamera,
			TestCanRunVideo
		}

		public CameraVideoTaskType cg;

		public int ch;

		public int ci;

		public float cj;

		public float ck;

		public IntPtr cl;

		public bool cm;

		public ScrollOrientation cn;

		public ej.b co;

		public int cp;

		public int cq;

		public string cr;

		public d4.e cs;

		public d4.c ct;

		public u(d.a.b A_0)
			: base(A_0)
		{
		}
	}

	public enum v
	{
		a = -1,
		b,
		c,
		d,
		e
	}

	protected class w : m
	{
		public bool cu;

		public bool cv;

		public v cw;

		public float[] cx;

		public int cy;

		public @in.b cz;

		public int c0;

		public string c1;

		public string c2;

		public w(d.a.b A_0)
			: base(A_0)
		{
			cx = new float[checked(Enum.GetValues(typeof(global::h.h)).GetUpperBound(0) + 1)];
		}
	}

	internal class x : d
	{
		public new class a : f.a
		{
			public new enum a
			{
				a,
				b,
				c,
				d
			}

			public a aw;

			public string ax;

			public a(b A_0, long A_1)
				: base(A_0, A_1)
			{
			}

			public string a6()
			{
				return a6(aw, ax);
			}

			public static string a6(a A_0, string A_1)
			{
				switch (A_0)
				{
				case a.b:
				{
					string A_2 = "USBPhotodiodeAcquireErrorFmt";
					return string.Format(hu.a(ref A_2), A_1);
				}
				case a.c:
				{
					string A_2 = "USBPhotodiodeUnstableSignalFmt";
					return string.Format(hu.a(ref A_2), A_1);
				}
				default:
				{
					string A_2 = "USBPhotodiodeAcquireErrorUnknown";
					return hu.a(ref A_2);
				}
				}
			}
		}
	}

	protected class y : m
	{
		public double c3;

		public FiberMuxChannel c4;

		public y(d.a.b A_0)
			: base(A_0)
		{
		}
	}

	protected class z : m
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
			h
		}

		public a c5;

		public double c6;

		public double c7;

		public double c8;

		public bool c9;

		public bool da;

		public bool db;

		public bool dc;

		public bool dd;

		public bool de;

		public double df;

		public bool dg;

		public bool dh;

		public bool di;

		public string dj;

		public string dk;

		public bool dl;

		public bool dm;

		public bool dn;

		public double @do;

		public z(d.a.b A_0)
			: base(A_0)
		{
		}
	}

	internal class aa : d
	{
		public new class a : f.a
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
				h
			}

			public a ay;

			public double az;

			public a(b A_0, long A_1)
				: base(A_0, A_1)
			{
			}

			public string a6()
			{
				return a6(ay);
			}

			public static string a6(a A_0)
			{
				return A_0 switch
				{
					a.f => "ExpectedPeaksNotFoundError", 
					a.d => "SpectrometerError", 
					a.e => "AnalysisError", 
					a.c => "PositioningError", 
					a.g => "WarningTargetNotFound", 
					a.h => "EstablishZAborted", 
					_ => "UnknownError", 
				};
			}
		}
	}

	private Collection<m> m_a;

	private Collection<m> m_b;

	private int m_c;

	private Thread m_d;

	private string m_e;

	private bool m_f;

	private bool m_g;

	private bool m_h;

	private bool m_i;

	private bool m_j;

	public static bool qh(n A_0)
	{
		if (A_0 != n.c && A_0 != n.f && A_0 != n.g && A_0 != n.k)
		{
			return A_0 == n.o;
		}
		return true;
	}

	public static bool p9(n A_0)
	{
		if (A_0 != n.c && A_0 != n.d && A_0 != n.e && A_0 != n.m && A_0 != n.n && A_0 != n.k)
		{
			return A_0 == n.o;
		}
		return true;
	}

	public static bool m2(n A_0)
	{
		if (A_0 != n.c && A_0 != n.d && A_0 != n.e && A_0 != n.g && A_0 != n.h)
		{
			return A_0 == n.f;
		}
		return true;
	}

	[SpecialName]
	protected Collection<m> zy()
	{
		return this.m_a;
	}

	[SpecialName]
	protected Collection<m> zz()
	{
		return this.m_b;
	}

	public r(fz A_0, string A_1)
		: base(ref A_0)
	{
		this.m_a = new Collection<m>();
		this.m_b = new Collection<m>();
		this.m_c = 0;
		this.m_g = false;
		this.m_e = A_1;
	}

	protected a z0()
	{
		a result = global::r.a.a;
		try
		{
			this.m_d = new Thread(m2);
			this.m_d.CurrentUICulture = Thread.CurrentThread.CurrentUICulture;
			this.m_d.Name = this.m_e;
			this.m_f = true;
			this.m_d.Start();
			DateTime now = DateTime.Now;
			do
			{
				Thread.Sleep(2);
			}
			while (jh.a(now) < 0.5 && !this.m_d.IsAlive);
			if (!this.m_d.IsAlive)
			{
				result = global::r.a.b;
				ab8().c(fz.b.b, "BaseThreadable.Shutdown: Error Initializing Thread '" + this.m_e + "' ");
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			result = global::r.a.c;
			ab8().c(fz.b.b, "BaseThreadable.Shutdown: Exception caught while initializing thread '" + this.m_e + "' ", a_);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public virtual a i(bool A_0)
	{
		if (this.m_h)
		{
			return global::r.a.a;
		}
		a result = global::r.a.a;
		try
		{
			this.m_f = false;
			if (this.m_d != null && this.m_d.IsAlive)
			{
				this.m_d.Interrupt();
				DateTime now = DateTime.Now;
				do
				{
					Thread.Sleep(2);
				}
				while (this.m_d.IsAlive && jh.a(now) < 0.30000001192092896);
				if (this.m_d.IsAlive)
				{
					ab8().c(fz.b.b, "BaseThreadable.Shutdown: Timed out waiting for thread to exit after interrupt - this may indicate that a procedure was interrupted before it had time to complete. This will sometimes happen if the user shuts down the program during startup.", Environment.StackTrace);
					this.m_d.Abort();
					now = DateTime.Now;
					do
					{
						Thread.Sleep(2);
					}
					while ((this.m_d.IsAlive && A_0) || jh.a(now) < 0.30000001192092896);
					if (this.m_d.IsAlive)
					{
						ab8().c(fz.b.b, "BaseThreadable.Shutdown: Timed out waiting for thread to exit after abort", Environment.StackTrace);
					}
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ab8().c(fz.b.b, "Exception caught in BaseThreadable.Shutdown(). ", a_);
			result = global::r.a.c;
			ProjectData.ClearProjectError();
		}
		this.m_h = true;
		return result;
	}

	[SpecialName]
	public bool z1()
	{
		return this.m_i;
	}

	[SpecialName]
	public void t6(bool A_0)
	{
		this.m_j = A_0;
		if (this.m_g)
		{
			this.m_i = A_0;
		}
	}

	private void m2()
	{
		checked
		{
			long a_ = default(long);
			bool flag2 = default(bool);
			long a_2 = default(long);
			do
			{
				try
				{
					if ((this.m_a.Count > 0 || this.m_b.Count > 0) && !this.m_j && !this.m_i)
					{
						if (this.m_a.Count > 0)
						{
							try
							{
								m m2 = this.m_a[0];
								if (m2.l == null || !m2.l.q())
								{
									if (m2.l != null)
									{
										this.m_b.Add(this.m_a[0]);
										if (m2.g != null)
										{
											a_ = m2.g.d();
										}
										d.a a10 = new d.a(m2.d3(), a_);
										a10.a = global::r.d.a.a.a;
										m2.l.m.e(m2.e, a10);
									}
									if (ah(this.m_a[0]))
									{
										f(this.m_a[0]);
									}
								}
							}
							finally
							{
								this.m2(this.m_a, 0);
							}
							if (!this.m_f)
							{
								break;
							}
						}
						else if (this.m_b.Count > 0 && !this.m_j && !this.m_i)
						{
							if (this.m_c >= this.m_b.Count)
							{
								this.m_c = 0;
							}
							m m2 = this.m_b[this.m_c];
							if (m2.l != null)
							{
								if (!m2.l.q())
								{
									if (ah(m2))
									{
										f(m2);
									}
									this.m_c++;
									if (this.m_c >= this.m_b.Count)
									{
										this.m_c = 0;
									}
								}
								else
								{
									g(m2);
									m2.l.l = false;
									this.m2(this.m_b, this.m_c);
									bool flag = false;
									try
									{
										flag2 = Monitor.TryEnter(this.m_a, 300);
										if (flag2)
										{
											foreach (m item in this.m_a)
											{
												if (item.l == m2.l)
												{
													flag = true;
													break;
												}
											}
										}
										else
										{
											ab8().c(fz.b.a, "Timeout checking otherTasksUseThisTerminator in mTaskQueue in BaseThreadable.TaskLoop");
										}
									}
									finally
									{
										if (flag2)
										{
											Monitor.Exit(this.m_a);
										}
									}
									if (!flag)
									{
										foreach (m item2 in this.m_b)
										{
											if (item2 != m2 && item2.l == m2.l)
											{
												flag = true;
												break;
											}
										}
									}
									if (!flag)
									{
										if (m2.g != null)
										{
											a_2 = m2.g.d();
										}
										k.a a11 = new k.a(m2.d3(), a_2);
										l l2 = m2.l;
										((d.a)a11).a = l2.z();
										a11.ao = l2.v();
										a11.ap = l2.w();
										a11.aq = l2.x();
										a11.ar = l2.y();
										a11.@as = l2.r();
										a11.au = l2.t();
										a11.at = l2.s();
										a11.av = l2.u();
										l2.m.d(m2.e, a11);
										h(m2);
										l2 = null;
									}
								}
							}
							if (!this.m_f)
							{
								break;
							}
						}
					}
					try
					{
						flag2 = Monitor.TryEnter(this.m_a, 100);
						if (flag2)
						{
							if ((this.m_a.Count == 0) & (this.m_b.Count == 0))
							{
								this.m_g = true;
							}
						}
						else
						{
							ab8().c(fz.b.a, "Timeout checking worker plan to sleep in mTaskQueue in BaseThreadable.TaskLoop");
						}
					}
					finally
					{
						if (flag2)
						{
							Monitor.Exit(this.m_a);
						}
					}
					this.m_i = this.m_j;
					if (this.m_g)
					{
						try
						{
							Thread.Sleep(-1);
						}
						catch (ThreadInterruptedException ex2)
						{
							ProjectData.SetProjectError(ex2);
							ThreadInterruptedException ex3 = ex2;
							ProjectData.ClearProjectError();
						}
						this.m_g = false;
						this.m_i = this.m_j;
					}
				}
				catch (ThreadAbortException ex4)
				{
					ProjectData.SetProjectError(ex4);
					ThreadAbortException a_3 = ex4;
					ab8().c(fz.b.a, "In BaseThreadable.TaskLoop, Thread '" + this.m_d.Name + "' - caught ThreadAbortException - resetting.", a_3);
					Thread.ResetAbort();
					ProjectData.ClearProjectError();
				}
				catch (ThreadInterruptedException ex5)
				{
					ProjectData.SetProjectError(ex5);
					ThreadInterruptedException a_4 = ex5;
					if (this.m_f)
					{
						ab8().c(fz.b.a, "ThreadInterruptedException in Worker thread in BaseThreadable.TaskLoop", a_4);
					}
					ProjectData.ClearProjectError();
				}
				catch (Exception ex6)
				{
					ProjectData.SetProjectError(ex6);
					Exception a_5 = ex6;
					ab8().c(fz.b.a, "Unhandled exception in BaseThreadable.TaskLoop", a_5);
					ProjectData.ClearProjectError();
				}
			}
			while (this.m_f);
		}
	}

	protected void z2()
	{
		bool flag = default(bool);
		try
		{
			flag = Monitor.TryEnter(this.m_b, 300);
			if (!flag)
			{
				ab8().c(fz.b.b, "Could not obtain lock on mExecutingTasks in BaseThreadable.TerminateAllTasks");
				return;
			}
			foreach (m item in this.m_b)
			{
				if (item.l != null)
				{
					item.l.q(A_0: true);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ab8().c(fz.b.b, "Exception caught and re-thrown in BaseThreadable.TerminateAllTasks.", ex3);
			throw ex3;
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(this.m_b);
			}
		}
		DateTime now = DateTime.Now;
		while (this.m_a.Count > 0 && this.m_b.Count > 0 && DateTime.Now.Subtract(now).TotalSeconds < 30.0)
		{
			Thread.Sleep(5);
		}
	}

	protected abstract void f(m A_0);

	protected abstract void g(m A_0);

	protected abstract void h(m A_0);

	protected virtual bool ah(m A_0)
	{
		return true;
	}

	protected a sj(m A_0)
	{
		bool flag = default(bool);
		if (this.m_f)
		{
			try
			{
				flag = Monitor.TryEnter(this.m_a, 100);
				if (flag)
				{
					if (A_0.l != null)
					{
						A_0.l.l = true;
						A_0.l.q(A_0: false);
					}
					this.m_a.Add(A_0);
					if (this.m_g & (this.m_a.Count == 1))
					{
						this.m_d.Interrupt();
					}
					return global::r.a.a;
				}
				ab8().c(fz.b.b, "Task not added due to failure to obtain lock on TaskQueue in BaseThreadable.AddTask", Environment.StackTrace);
				return global::r.a.b;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				ab8().c(fz.b.b, "Exception caught and re-thrown in BaseThreadable.AddTask.", ex3);
				throw ex3;
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(this.m_a);
				}
			}
		}
		ab8().c(fz.b.b, "Error while adding task to thread in BaseThreadable.AddTask'" + this.m_e + "': Thread not properly initialized.");
		return global::r.a.a;
	}

	private void m2(Collection<m> A_0, int A_1)
	{
		bool flag = default(bool);
		try
		{
			flag = Monitor.TryEnter(A_0, 100);
			if (!flag)
			{
				ab8().c(fz.b.b, "Failed to obtain lock on task queue in BaseThreadable.RemoveATask. Attempting to remove task anyway.");
			}
			A_0.RemoveAt(A_1);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ab8().c(fz.b.b, "Exception caught and re-thrown in BaseThreadable.RemoveATask.", ex3);
			throw ex3;
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(A_0);
			}
		}
	}
}
