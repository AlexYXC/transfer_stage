using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

internal class f2
{
	private class a : IComparable
	{
		public string a;

		public Version b;

		public a(string A_0, int A_1, int A_2, int A_3, int A_4)
		{
			a = A_0;
			b = new Version(A_1, A_2, A_3, A_4);
		}

		public int c(object A_0)
		{
			if (!(A_0 is a))
			{
				throw new Exception();
			}
			a a10 = (a)A_0;
			if ((object)b == null)
			{
				if ((object)a10.b == null)
				{
					return 0;
				}
				return 1;
			}
			if ((object)a10.b == null)
			{
				return -1;
			}
			if (b == a10.b)
			{
				return 0;
			}
			if (b > a10.b)
			{
				return 1;
			}
			return -1;
		}

		int IComparable.CompareTo(object A_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in c
			return this.c(A_0);
		}
	}

	private bool m_a;

	private string b;

	private const string m_c = "FILMeasMapSharing.settings";

	private const string m_d = "FILMeasMapSharedLocal";

	private const string m_e = "FILMeasMapSharedLocalAndRoam";

	private const string m_f = ".config";

	private const string m_g = "AllUsersShareSettings";

	private const string m_h = "SharedSettingsFolder";

	public f2()
	{
		try
		{
			d();
			string path = g();
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_a = false;
			b = null;
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	public bool f()
	{
		return this.m_a;
	}

	[SpecialName]
	public string g()
	{
		if (string.IsNullOrEmpty(b))
		{
			return i3.i();
		}
		return b;
	}

	public void h()
	{
		c();
	}

	public bool i()
	{
		return File.Exists(f(ConfigurationUserLevel.PerUserRoamingAndLocal));
	}

	public bool c(string A_0)
	{
		string text = c(ConfigurationUserLevel.PerUserRoamingAndLocal, A_0);
		string text2 = f(ConfigurationUserLevel.PerUserRoamingAndLocal);
		if (string.Compare(text, text2, ignoreCase: true) == 0)
		{
			return false;
		}
		bool flag = File.Exists(text);
		bool flag2 = File.Exists(text2);
		if (!flag)
		{
			return false;
		}
		if (flag && !flag2)
		{
			return true;
		}
		byte[] array = File.ReadAllBytes(text2);
		byte[] array2 = File.ReadAllBytes(text);
		if (array.Length != array2.Length)
		{
			return true;
		}
		checked
		{
			int num = array.Length - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (array[num2] != array2[num2])
				{
					return true;
				}
			}
			return false;
		}
	}

	public void c(bool A_0, ref bool A_1)
	{
		if (this.m_a != A_0)
		{
			this.m_a = A_0;
			if (this.m_a)
			{
				c(ConfigurationUserLevel.PerUserRoamingAndLocal, ref A_1);
			}
			c();
		}
	}

	public void c(string A_0, ref bool A_1, ref bool A_2)
	{
		A_1 = c(A_0);
		string text = c(ConfigurationUserLevel.PerUserRoamingAndLocal, A_0);
		bool flag = default(bool);
		if (!File.Exists(text))
		{
			string text2 = f(ConfigurationUserLevel.PerUserRoamingAndLocal);
			if (File.Exists(text2))
			{
				File.Copy(text2, text);
			}
			else
			{
				flag = true;
			}
		}
		b = A_0;
		if (flag)
		{
			j();
		}
		else if (A_1)
		{
			c(ref A_2);
		}
		c();
	}

	public void j()
	{
		g(ConfigurationUserLevel.PerUserRoamingAndLocal);
	}

	private void g(ConfigurationUserLevel A_0)
	{
		int num = 0;
		bool flag = default(bool);
		do
		{
			try
			{
				if (File.Exists(c(A_0)))
				{
					File.Copy(c(A_0), f(A_0), overwrite: true);
				}
				flag = true;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				Thread.Sleep(100);
				ProjectData.ClearProjectError();
			}
			num = checked(num + 1);
		}
		while (!flag && num < 3);
	}

	public void c(ref bool A_0)
	{
		d(ConfigurationUserLevel.PerUserRoamingAndLocal, ref A_0);
	}

	public void d(ConfigurationUserLevel A_0, ref bool A_1)
	{
		string text = f(A_0);
		string A_2 = c(A_0);
		if (!File.Exists(text))
		{
			string[] files = Directory.GetFiles(g(), d(A_0) + "*");
			List<a> list = new List<a>();
			Version version = Assembly.GetExecutingAssembly().GetName().Version;
			string[] array = files;
			foreach (string text2 in array)
			{
				string A_3 = Path.GetFileNameWithoutExtension(text2);
				int a_ = c(ref A_3);
				int a_2 = c(ref A_3);
				int a_3 = c(ref A_3);
				int a_4 = c(ref A_3);
				a a10 = new a(text2, a_4, a_3, a_2, a_);
				if (a10.b <= version)
				{
					list.Add(a10);
				}
			}
			if (list.Count > 0)
			{
				list.Sort();
				a obj = list[checked(list.Count - 1)];
				Version version2 = obj.b;
				c(0, ref A_2, version2.Revision);
				c(1, ref A_2, version2.Build);
				c(2, ref A_2, version2.Minor);
				c(3, ref A_2, version2.Major);
				version2 = null;
				text = obj.a;
				_ = null;
				A_1 = true;
			}
			else
			{
				text = null;
			}
		}
		if (!string.IsNullOrEmpty(text) && File.Exists(text))
		{
			string directoryName = Path.GetDirectoryName(A_2);
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
			File.Copy(text, A_2, overwrite: true);
		}
	}

	private int c(ref string A_0)
	{
		checked
		{
			int num = A_0.Length - 1;
			while (num > 0 && char.IsDigit(A_0[num]))
			{
				num--;
			}
			int result = ((num == 0 && char.IsDigit(A_0[num])) ? Conversions.ToInteger(A_0.Substring(num)) : ((num + 1 < A_0.Length && char.IsDigit(A_0[num])) ? Conversions.ToInteger(A_0.Substring(num + 1)) : 0));
			A_0 = A_0.Substring(0, num);
			return result;
		}
	}

	private void c(int A_0, ref string A_1, int A_2)
	{
		checked
		{
			int num = A_1.Length - 1;
			int num2 = -1;
			int num3 = -1;
			bool flag;
			do
			{
				flag = false;
				num2++;
				while (num > 0 && !char.IsDigit(A_1[num]))
				{
					num--;
				}
				if (char.IsDigit(A_1[num]))
				{
					flag = true;
					num3 = num;
				}
				while (num > 0 && char.IsDigit(A_1[num]))
				{
					num--;
				}
			}
			while (num2 < A_0);
			if (flag)
			{
				string text = null;
				string text2 = null;
				if (!char.IsDigit(A_1[num]))
				{
					text = A_1.Substring(0, num + 1);
				}
				if (num3 < A_1.Length - 1)
				{
					text2 = A_1.Substring(num3 + 1);
				}
				A_1 = text + A_2 + text2;
			}
		}
	}

	private string f(ConfigurationUserLevel A_0)
	{
		return c(A_0, g());
	}

	private string c(ConfigurationUserLevel A_0, string A_1)
	{
		return Path.Combine(A_1, e(A_0));
	}

	private string e(ConfigurationUserLevel A_0)
	{
		string text = "_" + Path.GetFileName(Path.GetDirectoryName(ConfigurationManager.OpenExeConfiguration(A_0).FilePath));
		return d(A_0) + text + ".config";
	}

	private string d(ConfigurationUserLevel A_0)
	{
		return A_0 switch
		{
			ConfigurationUserLevel.PerUserRoaming => "FILMeasMapSharedLocalAndRoam", 
			ConfigurationUserLevel.PerUserRoamingAndLocal => "FILMeasMapSharedLocal", 
			_ => throw new Exception("Unsupported userLevel"), 
		};
	}

	private string c(ConfigurationUserLevel A_0)
	{
		return ConfigurationManager.OpenExeConfiguration(A_0).FilePath;
	}

	public void d(ref bool A_0)
	{
		c(ConfigurationUserLevel.PerUserRoamingAndLocal, ref A_0);
	}

	private void c(ConfigurationUserLevel A_0, ref bool A_1)
	{
		if (File.Exists(f(A_0)))
		{
			d(ConfigurationUserLevel.PerUserRoamingAndLocal, ref A_1);
		}
		else
		{
			g(ConfigurationUserLevel.PerUserRoamingAndLocal);
		}
	}

	private string e()
	{
		return i3.i() + "\\FILMeasMapSharing.settings";
	}

	private void d()
	{
		string path = e();
		if (!File.Exists(path))
		{
			return;
		}
		XmlReader xmlReader = new XmlTextReader(File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read));
		try
		{
			while (xmlReader.Read())
			{
				XmlNodeType nodeType = xmlReader.NodeType;
				if (nodeType == XmlNodeType.Element)
				{
					if (Operators.CompareString(xmlReader.Name, "AllUsersShareSettings", TextCompare: false) == 0)
					{
						this.m_a = Conversions.ToBoolean(xmlReader.ReadInnerXml());
					}
					else if (Operators.CompareString(xmlReader.Name, "SharedSettingsFolder", TextCompare: false) == 0)
					{
						b = xmlReader.ReadInnerXml();
					}
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
		finally
		{
			xmlReader.Close();
		}
	}

	private void c()
	{
		XmlTextWriter xmlTextWriter = null;
		int num = 0;
		do
		{
			try
			{
				xmlTextWriter = new XmlTextWriter(File.Open(e(), FileMode.Create, FileAccess.ReadWrite, FileShare.Read), Encoding.UTF8);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				xmlTextWriter = null;
				Thread.Sleep(100);
				ProjectData.ClearProjectError();
			}
			num = checked(num + 1);
		}
		while (xmlTextWriter == null && num < 3);
		if (xmlTextWriter != null)
		{
			xmlTextWriter.Formatting = Formatting.Indented;
			xmlTextWriter.Indentation = 3;
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("Settings");
			xmlTextWriter.WriteElementString("AllUsersShareSettings", this.m_a.ToString());
			xmlTextWriter.WriteElementString("SharedSettingsFolder", b);
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteEndDocument();
			xmlTextWriter.Close();
		}
	}
}
