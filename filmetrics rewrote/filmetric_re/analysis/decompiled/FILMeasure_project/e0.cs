using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Filmetrics;
using Microsoft.VisualBasic.CompilerServices;

internal class e0
{
	private Collection<h5> a;

	private string b;

	private b0 c;

	private double[] d;

	private double[] e;

	private bool m_f;

	private const int m_g = 3;

	private const int m_h = 6;

	[SpecialName]
	public bool f()
	{
		return this.m_f;
	}

	public e0(Collection<h5> A_0, string A_1, b0 A_2, ref string A_3)
	{
		checked
		{
			d = new double[Enum.GetValues(typeof(LEDChannel)).Length - 1 + 1];
			e = new double[Enum.GetValues(typeof(LampChannel)).Length - 1 + 1];
			this.m_f = false;
			A_3 = null;
			a = A_0;
			b = A_1.Trim();
			i();
		}
		foreach (object value in Enum.GetValues(typeof(LEDChannel)))
		{
			LEDChannel a_ = (LEDChannel)Conversions.ToInteger(value);
			f(a_, 100.0);
			f(a_, LightState.LightOff);
		}
		foreach (object value2 in Enum.GetValues(typeof(LampChannel)))
		{
			LampChannel a_2 = (LampChannel)Conversions.ToInteger(value2);
			f(a_2, 100.0);
			f(a_2, LightState.LightOff);
		}
		c = A_2;
		string A_4 = string.Empty;
		bool A_5 = default(bool);
		if (!c.m2(A_0: false, ref A_3, ref A_5))
		{
			return;
		}
		double[] array = null;
		bz bz2 = bz.a;
		bz2 = c.p9(ref A_4);
		checked
		{
			if (bz2 != bz.a)
			{
				int length = Enum.GetValues(typeof(FiberMuxChannel)).Length;
				array = new double[length - 1 + 1];
				int num = length - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					array[num2] = (-3.5 + (double)num2) * (Math.PI / 7.0);
				}
				c.p9(length, array);
				bz2 = c.p9(ref A_3);
			}
			if (bz2 == bz.a)
			{
				this.m_f = true;
			}
		}
	}

	public int f(FiberMuxChannel A_0, ref string A_1)
	{
		return c.m2((int)A_0, ref A_1);
	}

	public int f(double A_0, ref string A_1)
	{
		return (int)c.m2(A_0, ref A_1);
	}

	public int f(ref float A_0)
	{
		return c.m2(ref A_0);
	}

	[SpecialName]
	public double[] g()
	{
		return c.tb();
	}

	[SpecialName]
	public double[] h()
	{
		if (c.tc() == null)
		{
			return null;
		}
		double[] array = new double[checked(c.tc().Length - 1 + 1)];
		c.tc().CopyTo(array, 0);
		return array;
	}

	[SpecialName]
	public void f(double[] A_0)
	{
		c.m2(A_0);
	}

	[SpecialName]
	public double f(LampChannel A_0)
	{
		return e[(int)A_0];
	}

	[SpecialName]
	public double f(LEDChannel A_0)
	{
		return d[(int)A_0];
	}

	public void f(LampChannel A_0, double A_1)
	{
		e[(int)A_0] = A_1;
	}

	public int g(LampChannel A_0, double A_1)
	{
		e[(int)A_0] = A_1;
		h5 h10 = a[(int)A_0];
		checked
		{
			int result = h10.abk().SetLampSetpoint((ushort)Math.Round(unchecked((double)(int)h10.abk().MaxLampSetpoint * e[(int)A_0]) * 0.01));
			h10 = null;
			return result;
		}
	}

	public int f(LampChannel A_0, LightState A_1)
	{
		h5 h10 = a[(int)A_0];
		checked
		{
			int result = ((A_1 != LightState.LightOff) ? h10.abk().SetLampSetpoint((ushort)Math.Round(unchecked((double)(int)h10.abk().MaxLampSetpoint * e[(int)A_0]) * 0.01)) : h10.abk().SetLampSetpoint(0));
			h10 = null;
			return result;
		}
	}

	public void f(LEDChannel A_0, double A_1)
	{
		d[(int)A_0] = A_1;
	}

	public void i()
	{
		foreach (object value in Enum.GetValues(typeof(LEDChannel)))
		{
			LEDChannel a_ = (LEDChannel)Conversions.ToInteger(value);
			f(a_, LightState.LightOff);
		}
		foreach (object value2 in Enum.GetValues(typeof(LampChannel)))
		{
			LampChannel a_2 = (LampChannel)Conversions.ToInteger(value2);
			f(a_2, LightState.LightOff);
		}
		foreach (h5 item in a)
		{
			item.tf();
		}
	}

	public int f(LEDChannel A_0, LightState A_1)
	{
		checked
		{
			byte ledIdx;
			int index;
			if (A_0 < LEDChannel.Red)
			{
				ledIdx = (byte)A_0;
				index = 0;
			}
			else if (A_0 < LEDChannel.SWIR1)
			{
				ledIdx = (byte)(A_0 - 3);
				index = 1;
			}
			else
			{
				ledIdx = (byte)(A_0 - 6);
				index = 2;
			}
			h5 h10 = a[index];
			int result = ((A_1 != LightState.LightOff) ? h10.abk().LsSetLEDSetpoint(ledIdx, (ushort)Math.Round(unchecked((double)(int)h10.abk().MaxLampSetpoint * d[(int)A_0]) * 0.01)) : h10.abk().LsSetLEDSetpoint(ledIdx, 0));
			h10 = null;
			return result;
		}
	}

	public FiberMuxChannel g(LEDChannel A_0)
	{
		FiberMuxChannel fiberMuxChannel = default(FiberMuxChannel);
		return A_0 switch
		{
			LEDChannel.UV => FiberMuxChannel.UV, 
			LEDChannel.Violet => FiberMuxChannel.Violet, 
			LEDChannel.Green => FiberMuxChannel.Green, 
			LEDChannel.Red => FiberMuxChannel.Red, 
			LEDChannel.NIR1 => FiberMuxChannel.NIR1, 
			LEDChannel.NIR2 => FiberMuxChannel.NIR2, 
			LEDChannel.SWIR1 => FiberMuxChannel.SWIR1, 
			LEDChannel.SWIR2 => FiberMuxChannel.SWIR2, 
			LEDChannel.SWIR3 => FiberMuxChannel.SWIR3, 
			_ => fiberMuxChannel, 
		};
	}

	public FiberMuxChannel g(LampChannel A_0)
	{
		FiberMuxChannel fiberMuxChannel = default(FiberMuxChannel);
		return A_0 switch
		{
			LampChannel.HP550 => FiberMuxChannel.FilterHP550, 
			LampChannel.LP700 => FiberMuxChannel.FilterLP700, 
			LampChannel.HP1200 => FiberMuxChannel.FilterHP1200, 
			_ => fiberMuxChannel, 
		};
	}

	public void j()
	{
		c.tg();
	}
}
