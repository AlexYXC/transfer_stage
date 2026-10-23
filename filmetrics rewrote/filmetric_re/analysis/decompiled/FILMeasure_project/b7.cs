using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class b7
{
	private const string a = "\\Solar\\Illuminance.txt";

	private double[] b;

	private double[] m_c;

	private const float m_d = 390f;

	private const float m_e = 770f;

	public static bool c(double A_0, double A_1)
	{
		if (jf.c((float)A_0, 390f))
		{
			return jf.a((float)A_1, 770f);
		}
		return false;
	}

	[SpecialName]
	public double[] c()
	{
		return b;
	}

	[SpecialName]
	public double[] d()
	{
		return this.m_c;
	}

	public void e()
	{
		i3.a(Application.StartupPath + "\\Solar\\Illuminance.txt", ref b, ref this.m_c);
	}
}
