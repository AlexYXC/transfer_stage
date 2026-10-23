using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

internal class y
{
	public List<x> a;

	public bool b;

	private const string m_c = "ColorCorr.xml";

	private const string d = "Settings";

	private const string e = "UseCorr";

	private const string f = "Correlations";

	private const string g = "CorrelationForParam";

	private const string h = "ParamType";

	private const string i = "ColorSpace";

	private const string j = "ParamIdx";

	private const string k = "Min";

	private const string l = "Max";

	private const string m = "A";

	private const string n = "B";

	public y()
	{
		a = new List<x>();
	}

	public static float[] c(a4.a A_0, float[] A_1, y A_2, ref bool A_3)
	{
		float[] array = new float[3]
		{
			A_1[0],
			A_1[1],
			A_1[2]
		};
		A_3 = false;
		if (A_2 != null && A_2.b)
		{
			foreach (x item in A_2.a)
			{
				int num = 0;
				do
				{
					u a_ = new u(u.a.a, A_0, num);
					if (u.d(item.a, a_))
					{
						array[num] = item.e + item.d * array[num];
						A_3 = true;
					}
					num = checked(num + 1);
				}
				while (num <= 2);
			}
		}
		return array;
	}

	public static float c(u.a A_0, float A_1, y A_2, ref bool A_3)
	{
		float num = A_1;
		A_3 = false;
		if (A_2 != null && A_2.b)
		{
			foreach (x item in A_2.a)
			{
				u a_ = new u(A_0, a4.a.a, 0);
				if (u.d(item.a, a_))
				{
					num = item.e + item.d * num;
					A_3 = true;
				}
			}
		}
		return num;
	}

	public void c(fz A_0)
	{
		string text = Path.Combine(i3.o(), "ColorCorr.xml");
		if (!File.Exists(text))
		{
			return;
		}
		XmlReader xmlReader = null;
		try
		{
			xmlReader = new XmlTextReader(File.Open(text, FileMode.Open, FileAccess.Read, FileShare.Read));
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			u.a a_ = default(u.a);
			a4.a a_2 = default(a4.a);
			int a_3 = default(int);
			float a_4 = default(float);
			float a_5 = default(float);
			float a_6 = default(float);
			float a_7 = default(float);
			while (xmlReader.Read())
			{
				if (xmlReader.NodeType == XmlNodeType.Element && Operators.CompareString(xmlReader.Name, "Settings", TextCompare: false) == 0)
				{
					bool flag = false;
					do
					{
						xmlReader.Read();
						flag = xmlReader.NodeType == XmlNodeType.EndElement;
						if (Operators.CompareString(xmlReader.Name, "UseCorr", TextCompare: false) == 0)
						{
							flag2 = bool.Parse(xmlReader.ReadInnerXml());
							flag3 = true;
						}
					}
					while (!flag);
					if (flag3)
					{
						b = flag2;
					}
				}
				if (xmlReader.NodeType != XmlNodeType.Element || Operators.CompareString(xmlReader.Name, "CorrelationForParam", TextCompare: false) != 0)
				{
					continue;
				}
				bool flag4 = false;
				bool flag5 = false;
				bool flag6 = false;
				bool flag7 = false;
				bool flag8 = false;
				bool flag9 = false;
				bool flag10 = false;
				bool flag11 = false;
				do
				{
					xmlReader.Read();
					flag11 = xmlReader.NodeType == XmlNodeType.EndElement;
					if (Operators.CompareString(xmlReader.Name, "ParamType", TextCompare: false) == 0)
					{
						a_ = (u.a)int.Parse(xmlReader.ReadInnerXml(), CultureInfo.InvariantCulture);
						flag4 = true;
					}
					else if (Operators.CompareString(xmlReader.Name, "ColorSpace", TextCompare: false) == 0)
					{
						a_2 = (a4.a)int.Parse(xmlReader.ReadInnerXml(), CultureInfo.InvariantCulture);
						flag5 = true;
					}
					else if (Operators.CompareString(xmlReader.Name, "ParamIdx", TextCompare: false) == 0)
					{
						a_3 = int.Parse(xmlReader.ReadInnerXml(), CultureInfo.InvariantCulture);
						flag6 = true;
					}
					else if (Operators.CompareString(xmlReader.Name, "Min", TextCompare: false) == 0)
					{
						a_4 = float.Parse(xmlReader.ReadInnerXml(), CultureInfo.InvariantCulture);
						flag7 = true;
					}
					else if (Operators.CompareString(xmlReader.Name, "Max", TextCompare: false) == 0)
					{
						a_5 = float.Parse(xmlReader.ReadInnerXml(), CultureInfo.InvariantCulture);
						flag8 = true;
					}
					else if (Operators.CompareString(xmlReader.Name, "A", TextCompare: false) == 0)
					{
						a_6 = float.Parse(xmlReader.ReadInnerXml(), CultureInfo.InvariantCulture);
						flag9 = true;
					}
					else if (Operators.CompareString(xmlReader.Name, "B", TextCompare: false) == 0)
					{
						a_7 = float.Parse(xmlReader.ReadInnerXml(), CultureInfo.InvariantCulture);
						flag10 = true;
					}
				}
				while (!flag11);
				if (!flag4)
				{
					a_ = u.a.a;
				}
				if (flag5 && flag6 && flag7 && flag8 && flag9 && flag10)
				{
					a.Add(new x(new u(a_, a_2, a_3), a_4, a_5, a_6, a_7));
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_8 = ex2;
			A_0.c(fz.b.a, "Error reading file " + text + ".", a_8);
			if (xmlReader != null)
			{
				xmlReader.Close();
				xmlReader = null;
			}
			File.Move(text, Path.Combine(Path.GetDirectoryName(text), i3.a(text, DateTime.Now)));
			ProjectData.ClearProjectError();
		}
		finally
		{
			xmlReader?.Close();
		}
	}

	public void c()
	{
		XmlTextWriter xmlTextWriter = null;
		try
		{
			string path = Path.Combine(i3.o(), "ColorCorr.xml");
			xmlTextWriter = new XmlTextWriter(File.Open(path, FileMode.Create), new UnicodeEncoding());
			xmlTextWriter.Formatting = Formatting.Indented;
			xmlTextWriter.Indentation = 3;
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("Correlations");
			xmlTextWriter.WriteStartElement("Settings");
			xmlTextWriter.WriteElementString("UseCorr", b.ToString(CultureInfo.InvariantCulture));
			xmlTextWriter.WriteEndElement();
			int num = checked(a.Count - 1);
			for (int num2 = 0; num2 <= num; num2 = checked(num2 + 1))
			{
				xmlTextWriter.WriteStartElement("CorrelationForParam");
				XmlTextWriter xmlTextWriter2 = xmlTextWriter;
				int num3 = (int)a[num2].a.a;
				xmlTextWriter2.WriteElementString("ParamType", num3.ToString());
				XmlTextWriter xmlTextWriter3 = xmlTextWriter;
				num3 = (int)a[num2].a.b;
				xmlTextWriter3.WriteElementString("ColorSpace", num3.ToString());
				xmlTextWriter.WriteElementString("ParamIdx", a[num2].a.c.ToString());
				xmlTextWriter.WriteElementString("Min", a[num2].b.ToString(CultureInfo.InvariantCulture));
				xmlTextWriter.WriteElementString("Max", a[num2].c.ToString(CultureInfo.InvariantCulture));
				xmlTextWriter.WriteElementString("A", a[num2].d.ToString(CultureInfo.InvariantCulture));
				xmlTextWriter.WriteElementString("B", a[num2].e.ToString(CultureInfo.InvariantCulture));
				xmlTextWriter.WriteEndElement();
			}
			xmlTextWriter.WriteEndElement();
		}
		finally
		{
			xmlTextWriter?.Close();
		}
	}
}
