using System;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

internal class g8
{
	private const string a = "LightTimer\\";

	private const string b = ".fibls";

	private const string m_c = ".fiblo";

	private const short m_d = 1;

	private const short m_e = 1;

	private static string m_f;

	private Guid g;

	private float h;

	private string i;

	private string j;

	private DateTime k;

	private float l;

	private bool m;

	public g8(Guid A_0, float A_1)
	{
		g = A_0;
		h = A_1;
		if (g8.m_f == null)
		{
			g8.m_f = i3.m() + "\\LightTimer\\";
		}
		if (!Directory.Exists(g8.m_f))
		{
			Directory.CreateDirectory(g8.m_f);
		}
		string text = g8.m_f + g.ToString("N");
		i = text + ".fibls";
		j = text + ".fiblo";
		c(ref l);
	}

	public void e(DateTime A_0)
	{
		if (!m)
		{
			d(A_0);
			c(A_0);
			k = A_0;
			m = true;
		}
	}

	public void f(DateTime A_0)
	{
		if (m)
		{
			d(A_0);
			m = false;
		}
	}

	public void c()
	{
		if (File.Exists(i))
		{
			File.Delete(i);
		}
		if (File.Exists(j))
		{
			File.Delete(j);
		}
		l = 0f;
		if (m)
		{
			c(DateAndTime.Now);
		}
	}

	[SpecialName]
	public float d()
	{
		if (m)
		{
			return l + (float)(DateAndTime.Now - k).TotalHours;
		}
		return l;
	}

	[SpecialName]
	public float e()
	{
		float num = h - d();
		if (num < 0f)
		{
			num = 0f;
		}
		return num;
	}

	private void d(DateTime A_0)
	{
		if (File.Exists(i))
		{
			float A_1 = default(float);
			c(ref A_1);
			bool A_2 = false;
			DateTime A_3 = default(DateTime);
			c(ref A_2, ref A_3);
			float value = (l = A_1 + (float)(A_0 - A_3).TotalHours);
			BinaryWriter binaryWriter = null;
			try
			{
				binaryWriter = new BinaryWriter(File.Open(j, FileMode.Create));
				binaryWriter.Write((short)1);
				binaryWriter.Write(value);
			}
			finally
			{
				binaryWriter?.Close();
			}
			File.Delete(i);
		}
	}

	private void c(DateTime A_0)
	{
		BinaryWriter binaryWriter = null;
		try
		{
			binaryWriter = new BinaryWriter(File.Open(i, FileMode.Create));
			binaryWriter.Write((short)1);
			binaryWriter.Write(A_0.ToBinary());
		}
		finally
		{
			binaryWriter?.Close();
		}
	}

	private void c(ref bool A_0, ref DateTime A_1)
	{
		if (File.Exists(i))
		{
			BinaryReader binaryReader = null;
			try
			{
				binaryReader = new BinaryReader(File.Open(i, FileMode.Open));
				binaryReader.ReadInt16();
				long dateData = binaryReader.ReadInt64();
				A_1 = DateTime.FromBinary(dateData);
			}
			finally
			{
				binaryReader?.Close();
			}
			A_0 = true;
		}
		else
		{
			A_0 = false;
		}
	}

	private void c(ref float A_0)
	{
		if (File.Exists(j))
		{
			BinaryReader binaryReader = null;
			try
			{
				binaryReader = new BinaryReader(File.Open(j, FileMode.Open));
				binaryReader.ReadInt16();
				A_0 = binaryReader.ReadSingle();
				return;
			}
			finally
			{
				binaryReader?.Close();
			}
		}
		A_0 = 0f;
	}
}
