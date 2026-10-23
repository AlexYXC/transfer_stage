using System;
using System.Globalization;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class ho
{
	public enum a
	{
		a,
		b
	}

	private const string m_a = "Precision";

	private const int m_b = 2;

	private const int c = 1;

	public const string d = "FI Precision File";

	public const string e = ".fiprc";

	public static string f = i3.m() + "\\Precision";

	public int g;

	public int h;

	public float i;

	public long j;

	public long k;

	public string l;

	public double m;

	public float n;

	public float o;

	public float p;

	public float q;

	public float r;

	public double s;

	public bool t;

	public bool u;

	public bool v;

	public float w;

	public bool x;

	public float y;

	public void a(string A_0)
	{
		StreamWriter streamWriter = new StreamWriter(A_0);
		try
		{
			streamWriter.WriteLine("\"Version: \"," + Conversions.ToString(2));
			streamWriter.WriteLine("\"Compatible: \"," + Conversions.ToString(1));
			streamWriter.WriteLine("\"# Iterations: \"," + g.ToString(CultureInfo.InvariantCulture));
			streamWriter.WriteLine("\"#Integration Cycles: \"," + h.ToString(CultureInfo.InvariantCulture));
			streamWriter.WriteLine("\"Spectrometer Resolution: \"," + i.ToString(CultureInfo.InvariantCulture));
			streamWriter.WriteLine("\"Shot Noise Full Scale: \"," + j.ToString(CultureInfo.InvariantCulture));
			streamWriter.WriteLine("\"Shot Noise Well Depth: \"," + k.ToString(CultureInfo.InvariantCulture));
			streamWriter.WriteLine("\"Raw Intensity File Name: \"," + Path.GetFileName(l));
			streamWriter.WriteLine("\"Peak Signal Intensity: \"," + m.ToString(CultureInfo.InvariantCulture));
			streamWriter.WriteLine("\"Pixel-by-Pixel Noise: \"," + n.ToString(CultureInfo.InvariantCulture));
			streamWriter.WriteLine("\"DC Noise: \"," + o.ToString(CultureInfo.InvariantCulture));
			streamWriter.WriteLine("\"DC Amplitude Uncertainty: \"," + p.ToString(CultureInfo.InvariantCulture));
			streamWriter.WriteLine("\"Sample Height Uncertainty: \"," + q.ToString(CultureInfo.InvariantCulture));
			streamWriter.WriteLine("\"Wavelength Calibration Noise: \"," + r.ToString(CultureInfo.InvariantCulture));
			streamWriter.WriteLine("\"Integration Time: \"," + s.ToString(CultureInfo.InvariantCulture));
			streamWriter.WriteLine("\"Acq Settings From Spectrum: \"," + t.ToString(CultureInfo.InvariantCulture));
		}
		finally
		{
			streamWriter.Close();
		}
	}

	internal void a(ref ho A_0, bool A_1)
	{
		if (this != A_0)
		{
			if (A_0 == null)
			{
				A_0 = new ho();
			}
			A_0.g = g;
			A_0.h = h;
			A_0.i = i;
			A_0.j = j;
			A_0.k = k;
			A_0.l = l;
			A_0.m = m;
			A_0.n = n;
			A_0.o = o;
			A_0.p = p;
			A_0.q = q;
			A_0.r = r;
			A_0.s = s;
			A_0.t = t;
			if (A_1)
			{
				A_0.u = u;
				A_0.v = v;
				A_0.w = w;
				A_0.x = x;
				A_0.y = y;
			}
		}
	}

	internal void b(string A_0)
	{
		StreamReader streamReader = new StreamReader(A_0);
		try
		{
			int num = Convert.ToInt32(Strings.Split(streamReader.ReadLine(), ",")[1]);
			Convert.ToInt32(Strings.Split(streamReader.ReadLine(), ",")[1]);
			g = int.Parse(Strings.Split(streamReader.ReadLine(), ",")[1], CultureInfo.InvariantCulture);
			h = int.Parse(Strings.Split(streamReader.ReadLine(), ",")[1], CultureInfo.InvariantCulture);
			i = float.Parse(Strings.Split(streamReader.ReadLine(), ",")[1], CultureInfo.InvariantCulture);
			j = long.Parse(Strings.Split(streamReader.ReadLine(), ",")[1], CultureInfo.InvariantCulture);
			k = long.Parse(Strings.Split(streamReader.ReadLine(), ",")[1], CultureInfo.InvariantCulture);
			string text = streamReader.ReadLine();
			l = string.Concat(str2: Strings.Trim(text.Substring(checked(text.IndexOf(",") + 1))), str0: f, str1: "\\");
			m = double.Parse(Strings.Split(streamReader.ReadLine(), ",")[1], CultureInfo.InvariantCulture);
			n = float.Parse(Strings.Split(streamReader.ReadLine(), ",")[1], CultureInfo.InvariantCulture);
			o = float.Parse(Strings.Split(streamReader.ReadLine(), ",")[1], CultureInfo.InvariantCulture);
			p = float.Parse(Strings.Split(streamReader.ReadLine(), ",")[1], CultureInfo.InvariantCulture);
			q = float.Parse(Strings.Split(streamReader.ReadLine(), ",")[1], CultureInfo.InvariantCulture);
			r = float.Parse(Strings.Split(streamReader.ReadLine(), ",")[1], CultureInfo.InvariantCulture);
			if (num > 1)
			{
				s = double.Parse(Strings.Split(streamReader.ReadLine(), ",")[1], CultureInfo.InvariantCulture);
				t = bool.Parse(Strings.Trim(Strings.Split(streamReader.ReadLine(), ",")[1]));
			}
			else
			{
				s = 0.0;
				t = false;
			}
		}
		finally
		{
			streamReader.Close();
		}
	}

	internal ho()
	{
	}

	internal ho(int A_0, int A_1, float A_2, long A_3, long A_4, string A_5, double A_6, float A_7, float A_8, float A_9, float A_10, float A_11, bool A_12, bool A_13, float A_14, bool A_15, float A_16, double A_17, bool A_18)
	{
		g = A_0;
		h = A_1;
		i = A_2;
		j = A_3;
		k = A_4;
		l = A_5;
		m = A_6;
		n = A_7;
		o = A_8;
		p = A_9;
		q = A_10;
		r = A_11;
		u = A_12;
		v = A_13;
		w = A_14;
		x = A_15;
		y = A_16;
		s = A_17;
		t = A_18;
	}
}
