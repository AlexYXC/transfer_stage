using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class b6
{
	private const double a = 315.0;

	private const double b = 380.0;

	private const double m_c = 280.0;

	private const double m_d = 315.0;

	private double[] m_e;

	private double[] f;

	private const string g = "\\Solar\\Irradiance and Effectiveness.txt";

	public static bool c(double A_0, double A_1, hi.c A_2)
	{
		double A_3 = default(double);
		double A_4 = default(double);
		c(A_2, ref A_3, ref A_4);
		if (jf.c((float)A_0, (float)A_3))
		{
			return jf.a((float)A_1, (float)A_4);
		}
		return false;
	}

	public static bool c(double A_0, double A_1)
	{
		if (!c(A_0, A_1, hi.c.a) && !c(A_0, A_1, hi.c.b))
		{
			return c(A_0, A_1, hi.c.c);
		}
		return true;
	}

	[SpecialName]
	public double[] c()
	{
		return this.m_e;
	}

	[SpecialName]
	public double[] d()
	{
		return f;
	}

	public static void c(hi.c A_0, ref double A_1, ref double A_2)
	{
		switch (A_0)
		{
		case hi.c.a:
			A_1 = 315.0;
			A_2 = 380.0;
			break;
		case hi.c.b:
			A_1 = 280.0;
			A_2 = 315.0;
			break;
		case hi.c.c:
			A_1 = 280.0;
			A_2 = 380.0;
			break;
		default:
			A_1 = 0.0;
			A_2 = 0.0;
			break;
		}
	}

	public void e()
	{
		double[] A_ = null;
		double[] A_2 = null;
		i3.a(Application.StartupPath + "\\Solar\\Irradiance and Effectiveness.txt", ref this.m_e, ref A_, ref A_2);
		checked
		{
			int num = this.m_e.Length - 1;
			f = new double[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				f[num3] = A_[num3] * A_2[num3];
			}
		}
	}
}
