using System;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

internal class o
{
	public string a;

	public string b;

	public string c;

	private const int m_d = 1;

	private const string e = "File Version";

	public o(string A_0)
	{
		string A_1 = "";
		string A_2 = "";
		A_0 += "\r\n";
		int A_3 = default(int);
		i3.a(ref A_3, A_0, ref A_1);
		string A_4;
		if (Operators.CompareString(A_1, "File Version", TextCompare: false) == 0)
		{
			i3.a(ref A_3, A_0, ref A_2);
			Conversions.ToInteger(A_2);
			string a_ = A_0;
			A_4 = null;
			i3.a(ref A_3, a_, ref A_4);
			i3.a(ref A_3, A_0, ref A_2);
			if (Conversions.ToInteger(A_2) > 1)
			{
				throw new ApplicationException("File format is too new. You must update program in order to edit this file.");
			}
			string a_2 = A_0;
			A_4 = null;
			i3.a(ref A_3, a_2, ref A_4);
		}
		i3.a(ref A_3, A_0, ref a);
		string a_3 = A_0;
		A_4 = null;
		i3.a(ref A_3, a_3, ref A_4);
		i3.a(ref A_3, A_0, ref b);
		b = jg.e(b);
		try
		{
			string a_4 = A_0;
			A_4 = null;
			i3.a(ref A_3, a_4, ref A_4);
			i3.a(ref A_3, A_0, ref c);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			c = "";
			ProjectData.ClearProjectError();
		}
		c = jg.e(jg.c(c));
	}

	public void d(string A_0)
	{
		StreamWriter streamWriter = null;
		try
		{
			streamWriter = new StreamWriter(A_0);
			streamWriter.WriteLine("File Version, " + Conversions.ToString(1));
			streamWriter.WriteLine("Compatible Version, " + Conversions.ToString(1));
			streamWriter.WriteLine("Current Release Version, " + a);
			streamWriter.WriteLine("Filename, \"" + jg.f(b) + "\"");
			c = jg.d(jg.f(c));
			streamWriter.WriteLine("Notes, \"" + c + "\"");
		}
		finally
		{
			streamWriter?.Close();
		}
	}
}
