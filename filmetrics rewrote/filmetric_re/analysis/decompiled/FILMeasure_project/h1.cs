using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Filmetrics.TmcmControllerEnums;
using Microsoft.VisualBasic.CompilerServices;

internal class h1
{
	public enum PublicErrors
	{
		None,
		Failure,
		LimitAlwaysAsserted,
		RightLimitNonAvailable,
		TimeoutWaitFinishMove,
		BrakeFailure
	}

	private const double a = 1.0 / (2.0 * Math.PI);

	private const double b = 0.1;

	private const double c = 2.0;

	private h0 d;

	private short e;

	private short f;

	private int g;

	private int h;

	private short m_i;

	private short j;

	private int m_k;

	private int l;

	private bool m;

	private bool m_n;

	private float o;

	private float m_p;

	private bool m_q;

	private bool m_r;

	private short m_s;

	private float m_t;

	private float m_u;

	private float m_v;

	private float m_w;

	private float m_x;

	public short y;

	private h2 m_z;

	public PublicErrors i(h0 A_0, short A_1, bool A_2, string A_3)
	{
		d = A_0;
		e = A_1;
		d.l(this);
		if (d.l(e) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		if (d.o(A_0: true, e) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		if (d.p(A_0: true, e) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		if (A_2)
		{
			this.m_s = -1;
		}
		else
		{
			this.m_s = 1;
		}
		return PublicErrors.None;
	}

	[SpecialName]
	public void i(string A_0, bool A_1)
	{
		d.l(A_0, A_1);
	}

	[SpecialName]
	public bool q()
	{
		return d.r();
	}

	public PublicErrors n(bool A_0)
	{
		return (PublicErrors)d.m(A_0, e);
	}

	public PublicErrors p(bool A_0)
	{
		return (PublicErrors)d.n(A_0, e);
	}

	public void i(int A_0, float A_1, float A_2, bool A_3)
	{
		m = true;
		this.m_n = A_3;
		l = A_0;
		this.m_t = A_1;
		this.m_u = A_2;
		this.m_r = false;
	}

	public void i(int A_0, float A_1, float A_2, float A_3, bool A_4)
	{
		m = false;
		l = A_0;
		this.m_v = A_1;
		this.m_x = A_2;
		this.m_w = A_3;
		this.m_r = A_4;
	}

	internal PublicErrors i(h3.f A_0)
	{
		if (!d.r())
		{
			return PublicErrors.Failure;
		}
		if (d.l(A_0, e) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	internal PublicErrors i(int A_0)
	{
		if (d.q(A_0, e) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	[SpecialName]
	public double r()
	{
		return this.m_w;
	}

	[SpecialName]
	public double s()
	{
		if (m)
		{
			return 0.0;
		}
		double num = this.m_k;
		double A_ = 1.0;
		return num / i(ref A_);
	}

	[SpecialName]
	public double t()
	{
		if (m)
		{
			double num = this.m_k;
			double A_ = 1.0;
			return num / i(ref A_);
		}
		return 0.0;
	}

	[SpecialName]
	public int u()
	{
		if (m)
		{
			return this.m_k;
		}
		return 0;
	}

	[SpecialName]
	public double v()
	{
		if (m)
		{
			return 0.0;
		}
		double A_ = 1.0;
		return 1.0 / i(ref A_);
	}

	[SpecialName]
	public double w()
	{
		if (m)
		{
			double A_ = 1.0;
			return 1.0 / i(ref A_);
		}
		return 0.0;
	}

	[SpecialName]
	private float p()
	{
		return (float)((double)o * 1.1 + 2.0);
	}

	[SpecialName]
	public float x()
	{
		double A_ = 1.0;
		double num = i(ref A_);
		return (float)((double)n() / num);
	}

	[SpecialName]
	private float n()
	{
		return d.l(g, j);
	}

	[SpecialName]
	public float z()
	{
		return this.m_p;
	}

	public float i(short A_0, short A_1)
	{
		double A_2 = 1.0;
		double num = i(ref A_2);
		return (float)((double)d.l((int)A_0, A_1) / num);
	}

	public float i(short A_0, short A_1, short A_2)
	{
		double A_3 = 1.0;
		double num = i(ref A_3);
		return (float)((double)d.l(A_0, A_1, A_2) / num);
	}

	[SpecialName]
	public float aa()
	{
		double A_ = 1.0;
		double num = i(ref A_);
		return (float)((double)k() / num);
	}

	[SpecialName]
	private float k()
	{
		return d.l(h, j, this.m_i);
	}

	[SpecialName]
	public bool ab()
	{
		return d.x();
	}

	public PublicErrors i(ref h0.d A_0)
	{
		A_0 = h0.d.a;
		h0 obj = d;
		int A_1 = 0;
		if (obj.l(ref A_0, ref A_1) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	public PublicErrors i(ref h0.c A_0)
	{
		A_0 = h0.c.a;
		h0 obj = d;
		byte A_1 = 0;
		int A_2 = 0;
		if (obj.l(ref A_0, ref A_1, ref A_2) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	public PublicErrors i(ref h0.f A_0)
	{
		h0 obj = d;
		int A_1 = 0;
		if (obj.l(ref A_0, ref A_1) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	public PublicErrors i(ref bool A_0)
	{
		A_0 = false;
		h0 obj = d;
		int A_1 = 0;
		if (obj.o(ref A_0, ref A_1) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	public PublicErrors i(ref hg.b A_0)
	{
		A_0 = hg.b.a;
		h0 obj = d;
		int A_1 = 0;
		if (obj.l(ref A_0, ref A_1) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	public PublicErrors k(ref bool A_0)
	{
		h0 obj = d;
		int A_1 = 0;
		if (obj.n(ref A_0, ref A_1) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	public PublicErrors n(ref bool A_0)
	{
		h0 obj = d;
		int A_1 = 0;
		if (obj.q(ref A_0, ref A_1) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	public PublicErrors i(ref float A_0, ref float A_1)
	{
		if (d.m(ref A_0, ref A_1) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	public PublicErrors i(float A_0, float A_1)
	{
		if (d.m(A_0, A_1) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	public PublicErrors i(short A_0)
	{
		if (A_0 != f)
		{
			if (d.l(A_0, e) != h0.a.a)
			{
				return PublicErrors.Failure;
			}
			f = A_0;
		}
		PublicErrors result = default(PublicErrors);
		return result;
	}

	public void i(double A_0, double A_1, bool A_2, ref short A_3, ref short A_4, ref short A_5, ref short A_6)
	{
		d.l((float)i(ref A_0), (float)i(ref A_1), A_2, ref A_3, ref A_4, ref A_5, ref A_6);
	}

	public short i(double A_0, short A_1)
	{
		h0 obj = d;
		double A_2 = 1.0;
		return obj.l((float)(A_0 * i(ref A_2)), A_1);
	}

	public int i(double A_0)
	{
		return checked(this.m_s * (int)Math.Round((double)this.m_k + i(ref A_0)));
	}

	public byte i(byte A_0, ref int A_1, bool A_2 = false)
	{
		return d.l(A_0, ref A_1, A_2, 0, 2);
	}

	public byte k(byte A_0, ref int A_1, bool A_2 = false)
	{
		return d.l(A_0, A_1, A_2, 0, 2);
	}

	public PublicErrors i(double A_0, double A_1)
	{
		if (d.x())
		{
			return checked(i((int)Math.Round(i(ref A_0)), (int)Math.Round(i(ref A_1))));
		}
		short A_2 = default(short);
		short A_3 = default(short);
		short A_4 = default(short);
		short A_5 = default(short);
		d.l((float)i(ref A_0), (float)i(ref A_1), A_2: false, ref A_2, ref A_3, ref A_4, ref A_5);
		return i(A_2, A_3, A_4, A_5);
	}

	public PublicErrors k(double A_0)
	{
		if (k(checked((int)Math.Round(i(ref A_0)))) != PublicErrors.None)
		{
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	public bool ac()
	{
		bool A_ = default(bool);
		h0.a a10 = d.l(e, ref A_);
		if (a10 != h0.a.a)
		{
			int num = (int)a10;
			throw new at("Error in IsHomeSwitchAsserted. Error code = " + num);
		}
		return A_;
	}

	public string ad()
	{
		string A_ = default(string);
		h0.a a10 = d.n(ref A_);
		if (a10 != h0.a.a)
		{
			int num = (int)a10;
			throw new at("Error in ReadSNFromController. Error code = " + num);
		}
		return A_;
	}

	public PublicErrors i(float A_0, float A_1, bool A_2, bool A_3, ref bool A_4, ref string A_5, ref bool A_6)
	{
		A_5 = null;
		A_4 = false;
		if (A_3 && k(0) != PublicErrors.None)
		{
			A_5 = "Failed to SetCurrentPositionMicroSteps in StartMoveTowardHomeSwitch.";
			return PublicErrors.Failure;
		}
		if (i((double)A_0, (double)A_1) != PublicErrors.None)
		{
			A_5 = "Failed to SetSpeedAndAcceleration in StartMoveTowardHomeSwitch.";
			return PublicErrors.Failure;
		}
		if (d.l(e, ref A_4) != h0.a.a)
		{
			A_5 = "Failed to GetHomeLimitSwitchStatus in StartMoveTowardHomeSwitch.";
			return PublicErrors.Failure;
		}
		if (i(!A_2, A_1: false) != PublicErrors.None)
		{
			A_5 = "Failed to DisableLimitSwitch in StartMoveTowardHomeSwitch.";
			return PublicErrors.Failure;
		}
		if (A_4)
		{
			return PublicErrors.None;
		}
		checked
		{
			if (A_2)
			{
				if (i((int)Math.Round(i(1, false)), false, true) != PublicErrors.None)
				{
					A_5 = "Failed to StartAbsoluteMoveMicrosteps in StartMoveTowardHomeSwitch.";
					return PublicErrors.Failure;
				}
			}
			else if (i((int)Math.Round(i(-1, false)), false, true) != PublicErrors.None)
			{
				A_5 = "Failed to StartAbsoluteMoveMicrosteps in StartMoveTowardHomeSwitch.";
				return PublicErrors.Failure;
			}
			return PublicErrors.None;
		}
	}

	public PublicErrors i(float A_0, float A_1, ref string A_2, ref bool A_3, bool A_4 = true, bool A_5 = false, bool A_6 = true)
	{
		PublicErrors publicErrors;
		if (A_6)
		{
			publicErrors = k(0);
			if (publicErrors != PublicErrors.None)
			{
				A_2 = "Failed to SetCurrentPositionMicroSteps within StartMoveTowardLimit";
				goto IL_00ba;
			}
		}
		if (i((double)A_0, (double)A_1) != PublicErrors.None)
		{
			publicErrors = PublicErrors.Failure;
			A_2 = "Failed to SetSpeedAndAcceleration within StartMoveTowardLimit";
		}
		else
		{
			short num = (short)((this.m_s == -1) ? 1 : (-1));
			checked
			{
				if (A_4)
				{
					if (!A_5)
					{
						i(A_0: true, A_1: false);
					}
					if (i((int)Math.Round(i(num, false)), A_1: false, A_2: false) == PublicErrors.None)
					{
						goto IL_00b8;
					}
					publicErrors = PublicErrors.Failure;
					A_2 = "Failed to StartAbsoluteMoveMicrosteps within StartMoveTowardLimit";
				}
				else if (!A_5 && i(A_0: false, A_1: false) != PublicErrors.None)
				{
					publicErrors = PublicErrors.Failure;
					A_2 = "Failed to SetLeftLimitDisableState on right limit switch within StartMoveTowardLimit";
				}
				else
				{
					if (i((int)Math.Round(i((short)unchecked(-num), false)), A_1: false, A_2: false) == PublicErrors.None)
					{
						goto IL_00b8;
					}
					publicErrors = PublicErrors.Failure;
					A_2 = "Failed to StartAbsoluteMoveMicrosteps within StartMoveTowardLimit";
				}
			}
		}
		goto IL_00ba;
		IL_00ba:
		return publicErrors;
		IL_00b8:
		publicErrors = PublicErrors.None;
		goto IL_00ba;
	}

	public static PublicErrors k(h1 A_0, h1 A_1, float A_2, float A_3)
	{
		PublicErrors publicErrors = A_0.k(0);
		if (publicErrors != PublicErrors.None)
		{
			return publicErrors;
		}
		publicErrors = A_1.k(0);
		if (publicErrors != PublicErrors.None)
		{
			return publicErrors;
		}
		int a_ = checked(-(int)Math.Round(A_0.i(1, A_1: true)));
		if (A_0.i((double)A_2, (double)A_3) != PublicErrors.None)
		{
			return PublicErrors.Failure;
		}
		if (A_1.i((double)A_2, (double)A_3) != PublicErrors.None)
		{
			return PublicErrors.Failure;
		}
		if (A_0.i(a_, true, true) != PublicErrors.None)
		{
			return PublicErrors.Failure;
		}
		if (A_1.i(a_, true, true) != PublicErrors.None)
		{
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	public static PublicErrors i(h1 A_0, h1 A_1, float A_2, float A_3)
	{
		if (A_0.af() != PublicErrors.None)
		{
			return PublicErrors.Failure;
		}
		if (A_1.af() != PublicErrors.None)
		{
			return PublicErrors.Failure;
		}
		int a_ = checked((int)Math.Round(A_0.i(1, A_1: true)));
		if (A_0.i((double)A_2, (double)A_3) != PublicErrors.None)
		{
			return PublicErrors.Failure;
		}
		if (A_1.i((double)A_2, (double)A_3) != PublicErrors.None)
		{
			return PublicErrors.Failure;
		}
		if (A_0.i(a_, true, true) != PublicErrors.None)
		{
			return PublicErrors.Failure;
		}
		if (A_1.i(a_, true, true) != PublicErrors.None)
		{
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	public void i(float A_0, float A_1, float A_2, float A_3, bool A_4, ref float A_5, ref float A_6, ref string A_7, ref bool A_8)
	{
		if (k(0.0) != PublicErrors.None)
		{
			A_7 = "Error in CalibrateHomeSwitchInMiddle. - Motor communication error.";
			return;
		}
		if (i((double)A_0, (double)A_2) != PublicErrors.None)
		{
			A_7 = "Error in CalibrateHomeSwitchInMiddle. - Motor communication error.";
			return;
		}
		if (r(0f - this.m_w) != PublicErrors.None)
		{
			A_7 = "Error in CalibrateHomeSwitchInMiddle. - Motor communication error.";
			return;
		}
		if (af() != PublicErrors.None)
		{
			A_7 = "Error in CalibrateHomeSwitchInMiddle. - Motor communication error.";
			return;
		}
		bool A_9 = false;
		bool flag = true;
		if (i(A_0, A_2, flag, A_3: true, ref A_9, ref A_7, ref A_8) != PublicErrors.None)
		{
			A_7 = "Error in CalibrateHomeSwitchInMiddle. - " + A_7;
			return;
		}
		if (i(A_0, A_2, flag, A_9, ref A_7, ref A_8) != PublicErrors.None)
		{
			A_7 = "Error in CalibrateHomeSwitchInMiddle. - " + A_7;
			return;
		}
		if (i(flag, A_4, ref A_7) != PublicErrors.None)
		{
			A_7 = "Error in CalibrateHomeSwitchInMiddle. - " + A_7;
			return;
		}
		if (k(A_1, A_3, flag, A_4, ref A_7, ref A_8) != PublicErrors.None)
		{
			A_7 = "Error in CalibrateHomeSwitchInMiddle. - " + A_7;
			return;
		}
		if (i(ref A_7) != PublicErrors.None)
		{
			A_7 = "Error in CalibrateHomeSwitchInMiddle. - " + A_7;
			return;
		}
		A_6 = (float)s();
		if (i((double)A_0, (double)A_2) != PublicErrors.None)
		{
			A_7 = "Error in CalibrateHomeSwitchInMiddle. - Motor communication error.";
			return;
		}
		if (r(this.m_w) != PublicErrors.None)
		{
			A_7 = "Error in CalibrateHomeSwitchInMiddle. - Motor communication error.";
			return;
		}
		if (af() != PublicErrors.None)
		{
			A_7 = "Error in CalibrateHomeSwitchInMiddle. - Motor communication error.";
			return;
		}
		flag = false;
		if (i(A_0, A_2, flag, A_3: true, ref A_9, ref A_7, ref A_8) != PublicErrors.None)
		{
			A_7 = "Error in CalibrateHomeSwitchInMiddle. - " + A_7;
		}
		else if (i(A_0, A_2, flag, A_9, ref A_7, ref A_8) != PublicErrors.None)
		{
			A_7 = "Error in CalibrateHomeSwitchInMiddle. - " + A_7;
		}
		else if (i(flag, !A_4, ref A_7) != PublicErrors.None)
		{
			A_7 = "Error in CalibrateHomeSwitchInMiddle. - " + A_7;
		}
		else if (k(A_1, A_3, flag, !A_4, ref A_7, ref A_8) != PublicErrors.None)
		{
			A_7 = "Error in CalibrateHomeSwitchInMiddle. - " + A_7;
		}
		else if (i(ref A_7) != PublicErrors.None)
		{
			A_7 = "Error in CalibrateHomeSwitchInMiddle. - " + A_7;
		}
		else
		{
			A_5 = (float)(0.0 - s());
		}
	}

	public void i(float A_0, float A_1, float A_2, float A_3, bool A_4, ref float A_5, ref string A_6, ref bool A_7)
	{
		bool A_8 = default(bool);
		if (i((double)A_0, (double)A_2) != PublicErrors.None)
		{
			A_6 = "Error in CalibrateHomeSwitchEnd. - Motor communication error.";
		}
		else if (r(A_4 ? this.m_w : (0f - this.m_w)) != PublicErrors.None)
		{
			A_6 = "Error in CalibrateHomeSwitchEnd. - Motor communication error.";
		}
		else if (af() != PublicErrors.None)
		{
			A_6 = "Error in CalibrateHomeSwitchEnd. - Motor communication error.";
		}
		else if (i(A_0, A_2, !A_4, A_3: true, ref A_8, ref A_6, ref A_7) != PublicErrors.None)
		{
			A_6 = "Error in CalibrateHomeSwitchEnd. - " + A_6;
		}
		else if (i(A_0, A_2, !A_4, A_8, ref A_6, ref A_7) != PublicErrors.None)
		{
			A_6 = "Error in CalibrateHomeSwitchEnd. - " + A_6;
		}
		else if (i(!A_4, A_1: false, ref A_6) != PublicErrors.None)
		{
			A_6 = "Error in CalibrateHomeSwitchEnd. - " + A_6;
		}
		else if (k(A_1, A_3, !A_4, A_3: false, ref A_6, ref A_7) != PublicErrors.None)
		{
			A_6 = "Error in CalibrateHomeSwitchEnd. - " + A_6;
		}
		else if (i(ref A_6) != PublicErrors.None)
		{
			A_6 = "Error in CalibrateHomeSwitchEnd. - " + A_6;
		}
		else
		{
			A_5 = (float)Math.Abs(s());
		}
	}

	public PublicErrors i(float A_0, float A_1, bool A_2, bool A_3, ref string A_4, ref bool A_5)
	{
		A_4 = null;
		if (!A_3)
		{
			PublicErrors publicErrors = i();
			if (publicErrors != PublicErrors.None)
			{
				A_4 = "Failed to WaitToReachHomeSwitch in HomeOnHomeSwitchPart1.";
				return publicErrors;
			}
		}
		if (i(!A_2, A_1: true) != PublicErrors.None)
		{
			A_4 = "Failed to DisableLimitSwitch in HomeOnHomeSwitchPart1.";
			return PublicErrors.Failure;
		}
		if (i((double)A_0, (double)A_1) != PublicErrors.None)
		{
			A_4 = "Failed to SetSpeedAndAcceleration in HomeOnHomeSwitchPart1.";
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	public PublicErrors i(bool A_0, bool A_1, ref string A_2)
	{
		A_2 = null;
		int num = ((!(A_0 ^ A_1)) ? 1 : (-1));
		int num2 = 0;
		float num3 = (m ? this.m_u : this.m_x);
		float num4 = (float)((double)((float)num * num3) * (A_1 ? 0.2 : 0.1));
		checked
		{
			int num5 = (int)Math.Round(Math.Ceiling(num3 / Math.Abs(num4)));
			bool A_3 = default(bool);
			do
			{
				if (m)
				{
					if (d.l())
					{
						d.m("HomeOnHomeSwitchPart2.RelativeRotationalMove 1 - stepSize = " + num4);
					}
					if (i(num4) != PublicErrors.None)
					{
						A_2 = "Failed to RelativeRotationalMove 1 in HomeOnHomeSwitchPart2. num = " + num2;
						return PublicErrors.Failure;
					}
				}
				else
				{
					if (d.l())
					{
						d.m("HomeOnHomeSwitchPart2.RelativeLinearMove 1 - stepSize = " + num4);
					}
					if (k(num4) != PublicErrors.None)
					{
						A_2 = "Failed to RelativeLinearMove 1 in HomeOnHomeSwitchPart2. num = " + num2;
						return PublicErrors.Failure;
					}
				}
				if (d.l())
				{
					d.m("HomeOnHomeSwitchPart2.GetLeftLimitSwitchStatus");
				}
				if (d.l(e, ref A_3) != h0.a.a)
				{
					A_2 = "Failed to GetHomeLimitSwitchStatus in HomeOnHomeSwitchPart2.";
					return PublicErrors.Failure;
				}
				num2++;
			}
			while (A_3 && num2 < num5);
			if (A_3)
			{
				A_2 = "Home switch is always asserted in HomeOnHomeSwitchPart2.";
				return PublicErrors.LimitAlwaysAsserted;
			}
			if (m)
			{
				if (d.l())
				{
					d.m("HomeOnHomeSwitchPart2.RelativeRotationalMove 2 stepSize = " + (float)((double)num4 * 0.5));
				}
				if (i((float)((double)num4 * 0.5)) != PublicErrors.None)
				{
					A_2 = "Failed to RelativeRotationalMove 2 in HomeOnHomeSwitchPart2.";
					return PublicErrors.Failure;
				}
			}
			else
			{
				if (d.l())
				{
					d.m("HomeOnHomeSwitchPart2.RelativeLinearMove 2 stepSize = " + (float)((double)num4 * 0.5));
				}
				float a_ = (A_1 ? ((float)((double)num4 * 0.5)) : (num4 * 2f));
				if (k(a_) != PublicErrors.None)
				{
					A_2 = "Failed to RelativeLinearMove 2 in HomeOnHomeSwitchPart2.";
					return PublicErrors.Failure;
				}
			}
			return PublicErrors.None;
		}
	}

	public PublicErrors k(float A_0, float A_1, bool A_2, bool A_3, ref string A_4, ref bool A_5)
	{
		A_4 = null;
		bool A_6 = default(bool);
		if (d.l(e, ref A_6) != h0.a.a)
		{
			A_4 = "Failed to GetHomeLimitSwitchStatus in HomeOnHomeSwitchPart3.";
			return PublicErrors.Failure;
		}
		if (A_6)
		{
			A_4 = "Error: limit switch asserted inHomeOnHomeSwitchPart3.";
			return PublicErrors.Failure;
		}
		bool a_ = (A_3 ? (!A_2) : A_2);
		bool A_7 = false;
		if (i(A_0, A_1, a_, A_3: false, ref A_7, ref A_4, ref A_5) != PublicErrors.None)
		{
			A_4 = "Failed to StartMoveTowardHomeSwitch in HomeOnHomeSwitchPart3.";
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	public PublicErrors i(ref string A_0)
	{
		A_0 = null;
		if (i() != PublicErrors.None)
		{
			A_0 = "Failed to WaitToReachHomeSwitch in HomeOnHomeSwitchPart4.";
			return PublicErrors.Failure;
		}
		if (i(A_0: true, A_1: true) != PublicErrors.None)
		{
			A_0 = "Failed to DisableLimitSwitch in HomeOnHomeSwitchPart4.";
			return PublicErrors.Failure;
		}
		if (i(A_0: false, A_1: true) != PublicErrors.None)
		{
			A_0 = "Failed to DisableLimitSwitch in HomeOnHomeSwitchPart4.";
			return PublicErrors.Failure;
		}
		PublicErrors result = default(PublicErrors);
		return result;
	}

	public PublicErrors i(float A_0, float A_1, bool A_2)
	{
		if (m)
		{
			return PublicErrors.Failure;
		}
		string A_3 = null;
		bool A_4 = false;
		PublicErrors publicErrors = i(A_0, A_1, ref A_3, ref A_4, A_2, A_5: false, A_6: false);
		if (publicErrors != PublicErrors.None)
		{
			return publicErrors;
		}
		publicErrors = k(A_2);
		if (publicErrors != PublicErrors.None)
		{
			return publicErrors;
		}
		PublicErrors result = default(PublicErrors);
		return result;
	}

	public PublicErrors i(float A_0, float A_1, float A_2, float A_3, bool A_4, bool A_5, ref string A_6, ref bool A_7)
	{
		string text = (A_5 ? "Left Limit Switch" : "Right Limit Switch");
		PublicErrors result;
		if (m & !A_5)
		{
			result = PublicErrors.RightLimitNonAvailable;
			A_7 = false;
			A_6 = "Linear Motor has only the right limit switch enabled. - " + result;
			return result;
		}
		result = k(A_5);
		if (result != PublicErrors.None)
		{
			A_7 = false;
			A_6 = "Failed WaitToReachLimit trying to reach " + text + " - " + result;
			return result;
		}
		if (this.m_r)
		{
			i(A_5);
		}
		result = i((double)A_0, (double)A_2);
		if (result != PublicErrors.None)
		{
			A_7 = false;
			A_6 = "Failed SetSpeedAndAcceleration before moving off limit switch. - " + result;
			return result;
		}
		if (A_4)
		{
			result = k(0);
			if (result != PublicErrors.None)
			{
				A_7 = false;
				A_6 = "Failed SetCurrentPositionMicroSteps(0) - " + result;
				return result;
			}
		}
		int num = 0;
		bool A_8 = default(bool);
		do
		{
			if (m)
			{
				result = i(this.m_u / 4f);
				if (result != PublicErrors.None)
				{
					A_7 = false;
					A_6 = "RelativeRotationalMove(mRotaryLimitAssertedAngleRadians)" + result;
					return result;
				}
			}
			else
			{
				float a_ = ((!A_5) ? this.m_x : (0f - this.m_x));
				result = k(a_);
				if (result != PublicErrors.None)
				{
					A_7 = false;
					A_6 = "Failed RelativeLinearMove moving toward " + text;
					return result;
				}
			}
			if (A_5)
			{
				if (d.l(e, ref A_8) != h0.a.a)
				{
					result = PublicErrors.Failure;
					A_7 = false;
					A_6 = "Failed to Get Left Limit Switch Status";
					return result;
				}
			}
			else if (d.m(e, ref A_8) != h0.a.a)
			{
				result = PublicErrors.Failure;
				A_7 = false;
				A_6 = "Failed to Get Right Limit Switch Status";
				return result;
			}
			num = checked(num + 1);
		}
		while (A_8 && num < 4);
		if (A_8)
		{
			result = PublicErrors.LimitAlwaysAsserted;
			throw new Exception(text + " reamins asserted");
		}
		result = i((double)A_1, (double)A_3);
		if (result != PublicErrors.None)
		{
			A_7 = false;
			A_6 = "Failed SetSpeedAndAcceleration (homingSpeedMmOrRadiansPerSec=" + A_1 + ", homingAccelerationMmOrRadiansPerSec=" + A_3 + ")";
			return result;
		}
		short num2 = (short)((this.m_s == -1) ? 1 : (-1));
		checked
		{
			float num3 = ((!A_5) ? i((short)unchecked(-num2), false) : i(num2, false));
			result = i((int)Math.Round(num3), A_1: false, A_2: false);
			if (result != PublicErrors.None)
			{
				A_7 = false;
				A_6 = "Failed StartAbsoluteMoveMicrosteps (distanceToReachLimitMm=" + num3 + ")";
				return result;
			}
			result = k(A_5);
			if (result != PublicErrors.None)
			{
				A_7 = false;
				A_6 = "Failed WaitToReachLimit trying to reach " + text;
				return result;
			}
			if (A_4)
			{
				result = k(0);
				if (result != PublicErrors.None)
				{
					A_7 = false;
					A_6 = "Failed SetCurrentPositionMicroSteps";
					return result;
				}
			}
			if (m)
			{
				result = i(A_0: true, A_1: true);
				if (result != PublicErrors.None)
				{
					A_7 = false;
					A_6 = "Failed to DisableLimitSwitch (Rotary Left)";
					return result;
				}
			}
			else
			{
				i(A_5, A_1: true);
			}
			PublicErrors result2 = default(PublicErrors);
			return result2;
		}
	}

	public PublicErrors i(bool A_0, bool A_1)
	{
		if (A_0)
		{
			return (PublicErrors)d.o(A_1, e);
		}
		if (m && !this.m_n)
		{
			return PublicErrors.RightLimitNonAvailable;
		}
		return (PublicErrors)d.p(A_1, e);
	}

	public PublicErrors i(float A_0, bool A_1)
	{
		PublicErrors publicErrors = i(A_0, A_1, true);
		if (publicErrors == PublicErrors.None)
		{
			publicErrors = af();
		}
		return publicErrors;
	}

	public PublicErrors i(float A_0)
	{
		PublicErrors publicErrors = n((double)A_0);
		if (publicErrors == PublicErrors.None)
		{
			publicErrors = af();
		}
		return publicErrors;
	}

	public PublicErrors n(double A_0)
	{
		if (!m)
		{
			return PublicErrors.Failure;
		}
		int a_ = checked((int)Math.Round((double)this.m_k + i(ref A_0)));
		return i(a_, A_1: false, A_2: false);
	}

	public PublicErrors i(double A_0, bool A_1, bool A_2 = true)
	{
		if (!m)
		{
			return PublicErrors.Failure;
		}
		return i(checked((int)Math.Round(i(ref A_0))), A_1, A_2);
	}

	public PublicErrors k(float A_0)
	{
		PublicErrors publicErrors = p(A_0);
		if (publicErrors == PublicErrors.None)
		{
			publicErrors = af();
		}
		return publicErrors;
	}

	public PublicErrors p(double A_0)
	{
		if (!m)
		{
			int a_ = checked((int)Math.Round((double)this.m_k + i(ref A_0)));
			return i(a_, true, true);
		}
		return PublicErrors.Failure;
	}

	public bool q(double A_0)
	{
		return checked((int)Math.Round(i(ref A_0))) == this.m_k;
	}

	public PublicErrors r(double A_0)
	{
		if (m)
		{
			return PublicErrors.Failure;
		}
		return i(checked((int)Math.Round(i(ref A_0))), true, true);
	}

	public PublicErrors i(int A_0, short A_1)
	{
		if (d.p(A_0, A_1) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	public PublicErrors i(bool A_0, short A_1)
	{
		if (d.l(A_0, A_1) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	public void ae()
	{
		int A_ = default(int);
		if (i(ref A_) != PublicErrors.Failure)
		{
			this.m_k = A_;
		}
	}

	public PublicErrors af()
	{
		if (this.m_q)
		{
			if (d.l(e, p()) != h0.a.a)
			{
				if (d.t() && d.u() == InterlockInput.DIN6)
				{
					bool A_ = default(bool);
					bool A_2 = default(bool);
					d.l(ref A_, ref A_2);
					if (A_)
					{
						ae();
					}
				}
				return PublicErrors.Failure;
			}
			this.m_q = false;
			if (d.w() && m && d.m(A_0: true) != 100)
			{
				return PublicErrors.BrakeFailure;
			}
			return PublicErrors.None;
		}
		return PublicErrors.None;
	}

	public PublicErrors ag()
	{
		PublicErrors publicErrors = i(0, true, true);
		if (publicErrors == PublicErrors.None)
		{
			publicErrors = af();
			if (publicErrors == PublicErrors.None)
			{
				publicErrors = k(0);
			}
		}
		return publicErrors;
	}

	public int ah()
	{
		int result = default(int);
		try
		{
			if (d != null)
			{
				if (!d.x())
				{
					result = (int)d.l(A_0: false);
				}
				d.m(this);
			}
		}
		catch (NullReferenceException ex2)
		{
			ProjectData.SetProjectError(ex2);
			NullReferenceException ex3 = ex2;
			ProjectData.ClearProjectError();
		}
		d = null;
		GC.Collect();
		return result;
	}

	public PublicErrors k(int A_0)
	{
		PublicErrors result = ((d.m(checked(this.m_s * A_0), e) != h0.a.a) ? PublicErrors.Failure : PublicErrors.None);
		this.m_k = A_0;
		return result;
	}

	private PublicErrors i(ref int A_0)
	{
		if (d.l(ref A_0, e) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		A_0 = checked(this.m_s * A_0);
		return PublicErrors.None;
	}

	public PublicErrors i(ref float A_0)
	{
		PublicErrors publicErrors;
		if (m)
		{
			publicErrors = PublicErrors.Failure;
		}
		else
		{
			int A_1 = default(int);
			publicErrors = i(ref A_1);
			if (publicErrors == PublicErrors.None)
			{
				double num = A_1;
				double A_2 = 1.0;
				A_0 = (float)(num / i(ref A_2));
			}
		}
		return publicErrors;
	}

	public PublicErrors k(ref float A_0)
	{
		PublicErrors publicErrors;
		if (m)
		{
			int A_1 = default(int);
			publicErrors = i(ref A_1);
			if (publicErrors == PublicErrors.None)
			{
				double num = A_1;
				double A_2 = 1.0;
				A_0 = (float)(num / i(ref A_2));
			}
		}
		else
		{
			publicErrors = PublicErrors.Failure;
		}
		return publicErrors;
	}

	public PublicErrors k(ref int A_0)
	{
		if (d.m(ref A_0, e) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		return PublicErrors.None;
	}

	private PublicErrors i(int A_0, bool A_1 = true, bool A_2 = true)
	{
		h2.c(this.m_z);
		short num = (short)((!d.t()) ? 5 : 0);
		checked
		{
			if (m && A_1)
			{
				int num2 = (int)Math.Round((float)(l * f) / this.m_t);
				if ((double)Math.Abs(A_0 - this.m_k) > 0.5 * (double)num2)
				{
					A_0 = (int)Math.Round((double)A_0 - (double)num2 * Math.Round((double)(A_0 - this.m_k) / (double)num2));
				}
			}
			PublicErrors publicErrors;
			if (d.w() && m && d.m(A_0: false) != 100)
			{
				publicErrors = PublicErrors.BrakeFailure;
			}
			if (d.r(this.m_s * A_0, e) != h0.a.a)
			{
				publicErrors = PublicErrors.Failure;
			}
			else
			{
				this.m_p = i(Math.Abs(A_0 - this.m_k), n(), k());
				o = this.m_p + (float)num;
				this.m_k = A_0;
				publicErrors = PublicErrors.None;
				this.m_q = true;
			}
			return publicErrors;
		}
	}

	public PublicErrors i(bool A_0, ref bool A_1)
	{
		if (A_0)
		{
			if (d.l(e, ref A_1) != h0.a.a)
			{
				return PublicErrors.Failure;
			}
		}
		else if (d.m(e, ref A_1) != h0.a.a)
		{
			return PublicErrors.Failure;
		}
		PublicErrors result = default(PublicErrors);
		return result;
	}

	private PublicErrors i()
	{
		DateTime now = DateTime.Now;
		bool A_ = default(bool);
		bool A_2 = default(bool);
		do
		{
			if (d.l(e, ref A_) != h0.a.a)
			{
				return PublicErrors.Failure;
			}
			if (!A_)
			{
				d.n(e, ref A_2);
				if (!A_2)
				{
					Application.DoEvents();
					Thread.Sleep(2);
				}
			}
		}
		while (jh.a(now) < (double)p() && !A_ && !A_2);
		if (A_)
		{
			if (d.l(e, false) != PublicErrors.None)
			{
				return PublicErrors.Failure;
			}
			int A_3 = default(int);
			if (i(ref A_3) != PublicErrors.Failure)
			{
				this.m_k = A_3;
			}
			return PublicErrors.None;
		}
		return PublicErrors.TimeoutWaitFinishMove;
	}

	private PublicErrors k(bool A_0)
	{
		DateTime now = DateTime.Now;
		bool A_1 = default(bool);
		do
		{
			if (A_0)
			{
				if (d.l(e, ref A_1) != h0.a.a)
				{
					return PublicErrors.Failure;
				}
			}
			else if (d.m(e, ref A_1) != h0.a.a)
			{
				return PublicErrors.Failure;
			}
			if (!A_1)
			{
				Application.DoEvents();
				Thread.Sleep(2);
			}
		}
		while ((jh.a(now) < (double)p()) & !A_1);
		PublicErrors result;
		if (!A_1)
		{
			result = PublicErrors.Failure;
		}
		else if (d.l(e, false) != PublicErrors.None)
		{
			result = PublicErrors.RightLimitNonAvailable;
		}
		else
		{
			int A_2 = default(int);
			if (i(ref A_2) != PublicErrors.Failure)
			{
				this.m_k = A_2;
			}
			result = PublicErrors.None;
		}
		return result;
	}

	private float i(int A_0, float A_1, float A_2)
	{
		float num = A_1 / A_2;
		float num2 = A_1 * A_1 / (2f * A_2);
		float num3 = (float)A_0 - num2 * 2f;
		if (num3 < 0f)
		{
			num3 = 0f;
			num = (float)Math.Sqrt((float)A_0 / A_2);
		}
		float num4 = num3 / A_1;
		return num * 2f + num4;
	}

	private double i(ref double A_0)
	{
		float num = ((!m) ? ((float)(A_0 / (double)this.m_v)) : ((float)(A_0 * (1.0 / (2.0 * Math.PI)) / (double)this.m_t)));
		double num2 = num * (float)l * (float)f;
		checked
		{
			if (this.m_r)
			{
				short num3 = (short)Math.Round(Math.Abs(num2 % (double)f));
				num2 = ((!((double)num3 >= (double)f / 2.0)) ? (num2 - (double)(Math.Sign(num2) * num3)) : (num2 + (double)(Math.Sign(num2) * (short)unchecked(f - num3))));
				A_0 = num2 / (double)(l * f) * (double)this.m_v;
			}
			return num2;
		}
	}

	private void i(bool A_0)
	{
		int A_1 = default(int);
		if (i(ref A_1) != PublicErrors.None)
		{
			return;
		}
		int num = Math.Abs(A_1 % f);
		checked
		{
			if (num != 0)
			{
				double num2 = (A_0 ? ((double)(A_1 - Math.Sign(A_1) * num)) : ((double)(A_1 + num)));
				if (i((int)Math.Round(num2), true, true) == PublicErrors.None)
				{
					af();
				}
			}
		}
	}

	public PublicErrors i(short A_0, short A_1, short A_2, short A_3)
	{
		bool flag = default(bool);
		if (A_1 != j)
		{
			if (d.m(A_1, e) != h0.a.a)
			{
				return PublicErrors.Failure;
			}
			flag = true;
			j = A_1;
		}
		if (A_3 != this.m_i)
		{
			if (d.n(A_3, e) != h0.a.a)
			{
				return PublicErrors.Failure;
			}
			flag = true;
			this.m_i = A_3;
		}
		if (A_0 != g)
		{
			if (d.n((int)A_0, e) != h0.a.a)
			{
				return PublicErrors.Failure;
			}
			g = A_0;
		}
		if ((A_2 != h) | flag)
		{
			if (d.o((int)A_2, e) != h0.a.a)
			{
				return PublicErrors.Failure;
			}
			h = A_2;
			bool A_5 = default(bool);
			int A_4 = default(int);
			if (d.l(ref A_4, e, ref A_5) != PublicErrors.None)
			{
				return PublicErrors.Failure;
			}
			if (A_5)
			{
				return PublicErrors.None;
			}
			checked
			{
				A_4 = ((!m) ? (A_4 + y) : (A_4 - 1));
				if (d.o((short)A_4, e) != PublicErrors.None)
				{
					return PublicErrors.Failure;
				}
			}
		}
		PublicErrors result = default(PublicErrors);
		return result;
	}

	private PublicErrors i(int A_0, int A_1)
	{
		if (A_0 != g)
		{
			if (d.n(A_0, e) != h0.a.a)
			{
				return PublicErrors.Failure;
			}
			g = A_0;
		}
		bool flag = default(bool);
		if ((A_1 != h) | flag)
		{
			if (d.o(A_1, e) != h0.a.a)
			{
				return PublicErrors.Failure;
			}
			h = A_1;
		}
		PublicErrors result = default(PublicErrors);
		return result;
	}

	private float i(int A_0, bool A_1 = false)
	{
		int A_2 = default(int);
		if (!A_1)
		{
			i(ref A_2);
		}
		double A_3;
		if (m)
		{
			double num = A_0;
			A_3 = 7.853981633974483;
			return (float)(num * i(ref A_3) + (double)A_2);
		}
		double num2 = A_0;
		A_3 = this.m_w;
		return (float)(num2 * i(ref A_3) + (double)A_2);
	}

	public int n(float A_0)
	{
		return d.l(A_0, A_1: true, ref e);
	}

	public void ai()
	{
		d.l(e, A_1: true);
	}

	public void i(ref string A_0, ref bool A_1)
	{
		if (d.l(e, false) != PublicErrors.None)
		{
			A_1 = false;
			A_0 = "Error when attempting to stop motor in TmcmMotor.StopMotor";
			throw new at(A_0);
		}
		int A_2 = default(int);
		if (i(ref A_2) != PublicErrors.Failure)
		{
			this.m_k = A_2;
		}
		this.m_q = false;
		if (d.w() && m && d.m(A_0: true) != 100)
		{
			A_0 = "Error when attempting to enable rotary motor brake";
			throw new at(A_0);
		}
	}

	public h1()
	{
		y = 2;
		this.m_z = null;
	}

	public h1(h2 A_0)
	{
		y = 2;
		this.m_z = A_0;
	}

	~h1()
	{
		ah();
		base.Finalize();
	}
}
