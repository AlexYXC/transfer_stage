using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class f5
{
	public enum a
	{
		a,
		b,
		c,
		d,
		e,
		f
	}

	public class b
	{
		public string a;

		public float b;

		public float c;

		public float d;

		public float e;

		public bool f;

		public b(string A_0, float A_1, float A_2, float A_3, float A_4, bool A_5)
		{
			a = A_0;
			b = A_1;
			c = A_2;
			d = A_3;
			e = A_4;
			f = A_5;
		}
	}

	public class c
	{
		public string a;

		public string b;

		public string c;

		public bool d;

		public Bitmap e;

		public Bitmap f;
	}

	private enum d
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

	private enum e
	{
		a,
		b,
		c
	}

	public const string a = "Adobe PDF";

	public const string b = "Microsoft XPS Document Writer";

	public const string c = "Microsoft Print to PDF";

	private static PrintDocument m_d;

	private static f5 m_e;

	private const string f = "\\BMPFiles\\yLabel_";

	private bool m_g;

	private const short h = 7;

	private a i;

	private Collection<hc> j;

	private Collection<hr> k;

	private hg l;

	private string m;

	private b n;

	private string o;

	private string p;

	private string q;

	private string r;

	private string s;

	private long m_t;

	private long m_u;

	private Image m_v;

	private string m_w;

	private string m_x;

	private string m_y;

	private DateTime z;

	private bool aa;

	private short ab;

	private const short ac = 2;

	private fl[] ad;

	private c ae;

	[CompilerGenerated]
	private System.Timers.Timer af;

	private bool ag;

	private bool ah;

	private string ai;

	private string aj;

	private const float ak = 5f;

	private const int al = 280;

	private const int am = 40;

	private const int an = 28;

	private const int ao = 40;

	private const int ap = 60;

	private const int aq = 80;

	private const int ar = 92;

	private const int @as = 92;

	private const int at = 80;

	private const int au = 92;

	public f5()
	{
		ad = new fl[2];
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer g()
	{
		return af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = a;
		System.Timers.Timer timer = af;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		af = A_0;
		timer = af;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	public static void a(PrintDocument A_0, string A_1, string A_2, ref bool A_3, ref bool A_4, ref string A_5, ref string A_6)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		b2 b10 = new b2();
		b10.a("PDF Document (*.pdf)", "*.pdf", 1);
		saveFileDialog.Filter = b10.b();
		saveFileDialog.InitialDirectory = A_2;
		saveFileDialog.FileName = A_1 + ".pdf";
		_ = null;
		if (saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			if (saveFileDialog.FileName.Contains(","))
			{
				A_4 = true;
				A_5 = saveFileDialog.FileName;
				A_6 = i3.g() + "\\TempPrintingFile" + Path.GetExtension(saveFileDialog.FileName);
				File.Delete(A_6);
				A_0.PrinterSettings.PrintFileName = A_6;
			}
			else
			{
				A_4 = false;
				A_5 = null;
				A_6 = null;
				A_0.PrinterSettings.PrintFileName = saveFileDialog.FileName;
			}
			A_3 = true;
			A_0.PrinterSettings.PrintToFile = true;
		}
		else
		{
			A_3 = false;
		}
	}

	[SpecialName]
	public void a(long A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	public void g(long A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	public void a(string A_0)
	{
		m = A_0;
	}

	[SpecialName]
	public void g(string A_0)
	{
		s = A_0;
	}

	[SpecialName]
	public void a(short A_0)
	{
		ab = A_0;
	}

	[SpecialName]
	internal void a(short A_0, fl A_1)
	{
		ad[A_0] = A_1;
	}

	[SpecialName]
	public void a(Image A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	public void t(string A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	public void u(string A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	public void a(DateTime A_0)
	{
		z = A_0;
	}

	[SpecialName]
	public void a(bool A_0)
	{
		aa = A_0;
	}

	[SpecialName]
	public void a(b A_0)
	{
		n = A_0;
	}

	[SpecialName]
	public void v(string A_0)
	{
		o = A_0;
	}

	[SpecialName]
	public void w(string A_0)
	{
		p = A_0;
	}

	[SpecialName]
	public void x(string A_0)
	{
		q = A_0;
	}

	[SpecialName]
	public void y(string A_0)
	{
		r = A_0;
	}

	[SpecialName]
	public void a(hg A_0)
	{
		l = A_0;
	}

	[SpecialName]
	public void a(c A_0)
	{
		ae = A_0;
	}

	public void a(ref PrintDocument A_0, Collection<hc> A_1, Collection<hr> A_2, a A_3, bool A_4, bool A_5, string A_6, string A_7)
	{
		a(ref A_0, A_1, A_2, A_3, null, A_4, A_5, A_6, A_7);
	}

	public void a(ref PrintDocument A_0, Collection<hc> A_1, Collection<hr> A_2, a A_3, Bitmap A_4, bool A_5, bool A_6, string A_7, string A_8)
	{
		i = A_3;
		j = A_1;
		k = A_2;
		ag = A_5;
		ah = A_6;
		ai = A_7;
		aj = A_8;
		if (f5.m_e != null)
		{
			f5.m_d.PrintPage -= f5.m_e.a;
			f5.m_d.EndPrint -= f5.m_e.a;
		}
		f5.m_d = A_0;
		f5.m_e = this;
		f5.m_d.PrintPage += a;
		f5.m_d.EndPrint += a;
		f5.m_d.Print();
	}

	protected void a(object A_0, PrintPageEventArgs A_1)
	{
		try
		{
			switch (i)
			{
			case f5.a.c:
				g(A_1);
				break;
			case f5.a.a:
				a(A_1, A_1: false);
				break;
			case f5.a.e:
				a(A_1, A_1: true);
				break;
			case f5.a.f:
				a(A_1);
				break;
			case f5.a.b:
			case f5.a.d:
				break;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			A_1.Cancel = true;
			ProjectData.ClearProjectError();
		}
	}

	protected void a(object A_0, PrintEventArgs A_1)
	{
		a(new System.Timers.Timer(1000.0));
		g().AutoReset = false;
		g().Start();
	}

	private void a(object A_0, ElapsedEventArgs A_1)
	{
		bool flag = false;
		if (!ah && !ag)
		{
			return;
		}
		try
		{
			int num = 0;
			do
			{
				if (File.Exists(f5.m_d.PrinterSettings.PrintFileName))
				{
					if (ah)
					{
						File.Move(aj, ai);
					}
					flag = true;
					break;
				}
				Thread.Sleep(200);
				num = checked(num + 1);
			}
			while (num <= 20);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
		if (flag && ag)
		{
			Process.Start(ah ? ai : f5.m_d.PrinterSettings.PrintFileName);
		}
	}

	private void a(PrintPageEventArgs A_0, bool A_1)
	{
		string text = "                    ?? = ";
		string A_2 = "ThicknessLimitViolation";
		string text2 = "**####.#** = " + hu.a(ref A_2);
		_ = new bool[2];
		Font font = new Font("Verdana", 16f, FontStyle.Bold);
		Font font2 = new Font("Arial", 11f, FontStyle.Regular);
		Font font3 = new Font("Arial", 10f, FontStyle.Regular);
		Font font4 = new Font("Arial", 10f, FontStyle.Bold);
		Font font5 = new Font("Arial", 9f, FontStyle.Bold);
		Font font6 = new Font("Arial", 9f, FontStyle.Regular);
		new Font("Arial", 9f, FontStyle.Italic);
		Font font7 = new Font("Arial", 9f, FontStyle.Regular);
		Font font8 = new Font("Arial", 9f, FontStyle.Bold);
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
		bool flag7 = false;
		short a_ = global::e.a().DisplaySignificantDigits;
		gc gc2 = null;
		hc hc2 = a();
		if (hc2 == null)
		{
			return;
		}
		hg hg2 = hc2.cy();
		bool a_2 = hg2.dh().ax(hc2.cz());
		bool a_3 = hg2.dh().az(hc2.cz());
		eo.b a_4 = hg2.dh().at(hc2.cz(), hc2.cn().af());
		PageSettings defaultPageSettings = f5.m_d.DefaultPageSettings;
		checked
		{
			int num = (int)Math.Round(defaultPageSettings.PrintableArea.Height);
			int num2 = (int)Math.Round(defaultPageSettings.PrintableArea.Width);
			if (defaultPageSettings.Landscape)
			{
				int num3 = num;
				num = num2;
				num2 = num3;
			}
			_ = null;
			string[] array = new string[7];
			float num4 = 20f;
			float num5 = 200f;
			A_0.Graphics.Clear(Color.White);
			float num6 = 0f;
			float num7 = (float)((double)num4 * 0.5);
			Graphics graphics = A_0.Graphics;
			A_2 = "MeasurementReport";
			graphics.DrawString(hu.a(ref A_2), font, Brushes.Black, num6, num7);
			float A_3 = default(float);
			float A_4 = default(float);
			i5.a(this.m_v, ref A_3, ref A_4);
			A_0.Graphics.DrawImage(this.m_v, (float)(num2 - 10) - A_3, 10f);
			num7 = Math.Max((float)font.Height + (float)((double)num4 * 0.5), A_4 + 10f + 4f);
			A_0.Graphics.DrawLine(Pens.Black, 0f, (int)Math.Round(num7), (float)num2 - 5f, (int)Math.Round(num7));
			num7 += num4 * 0.3f;
			num6 = (int)Math.Round((double)num4 * 1.5);
			Graphics graphics2 = A_0.Graphics;
			A_2 = "SystemID";
			graphics2.DrawString(hu.a(ref A_2) + ": ", font2, Brushes.Black, num6, num7);
			A_0.Graphics.DrawString(s, font2, Brushes.Black, num5, num7);
			num7 += (float)font2.Height + num4 * 0.3f;
			num6 = (int)Math.Round((double)num4 * 1.5);
			Graphics graphics3 = A_0.Graphics;
			A_2 = "SampleID";
			graphics3.DrawString(hu.a(ref A_2) + ": ", font2, Brushes.Black, num6, num7);
			A_0.Graphics.DrawString(this.m_w, font2, Brushes.Black, num5, num7);
			num7 += (float)font2.Height + num4 * 0.3f;
			num6 = (int)Math.Round((double)num4 * 1.5);
			Graphics graphics4 = A_0.Graphics;
			A_2 = "OperatorID";
			graphics4.DrawString(hu.a(ref A_2) + ": ", font2, Brushes.Black, num6, num7);
			A_0.Graphics.DrawString(this.m_x, font2, Brushes.Black, num5, num7);
			num7 += (float)font2.Height + num4 * 0.3f;
			num6 = (int)Math.Round((double)num4 * 1.5);
			Graphics graphics5 = A_0.Graphics;
			A_2 = "StructureName";
			graphics5.DrawString(hu.a(ref A_2) + ": ", font2, Brushes.Black, num6, num7);
			A_0.Graphics.DrawString(hc2.cy().ci(), font2, Brushes.Black, num5, num7);
			num7 += (float)font2.Height + num4 * 0.3f;
			num6 = (int)Math.Round((double)num4 * 1.5);
			Graphics graphics6 = A_0.Graphics;
			A_2 = "DateTime";
			graphics6.DrawString(hu.a(ref A_2) + ": ", font2, Brushes.Black, num6, num7);
			A_0.Graphics.DrawString(Strings.Format(hc2.da(), "General Date"), font2, Brushes.Black, num5, num7);
			num7 += (float)font2.Height + num4 * 0.3f;
			A_0.Graphics.DrawLine(Pens.Black, 0f, (int)Math.Round(num7), (float)num2 - 5f, (int)Math.Round(num7));
			if (!A_1)
			{
				num7 = (float)((double)num7 + (double)num4 * 0.5);
				A_2 = "GOFResultLabel";
				string text3 = hu.a(ref A_2) + " = " + hc2.c2().ToString("N3");
				Font font9;
				Brush brush;
				bool flag8;
				if ((double)hc2.c2() >= hg2.b3(hc2.cf()).gq())
				{
					font9 = font3;
					brush = Brushes.Black;
					flag8 = false;
				}
				else
				{
					font9 = font4;
					brush = Brushes.Red;
					flag8 = true;
				}
				SizeF sizeF = A_0.Graphics.MeasureString(text3, font9);
				bool flag9 = hc2.cy().bz((eo.a)null);
				string text4;
				Font font10;
				Brush brush2;
				bool flag10;
				SizeF sizeF2;
				if (flag9)
				{
					A_2 = "FFTResultLabel";
					text4 = " " + hu.a(ref A_2) + " = " + hc2.c3().ToString("0.###");
					if (hc2.c3() >= hg2.b3(hc2.cf()).gr())
					{
						font10 = font3;
						brush2 = Brushes.Black;
						flag10 = false;
					}
					else
					{
						font10 = font4;
						brush2 = Brushes.Red;
						flag10 = true;
					}
					sizeF2 = A_0.Graphics.MeasureString(text4, font10);
				}
				else
				{
					text4 = null;
					sizeF2 = new SizeF(0f, 0f);
					font10 = null;
					brush2 = null;
					flag10 = false;
				}
				num6 = (float)((double)(float)((double)((float)num2 - 5f) * 0.5) - (double)(sizeF.Width + sizeF2.Width) * 0.5);
				A_0.Graphics.DrawString(text3, font9, brush, num6, num7);
				if (flag9)
				{
					num6 += sizeF.Width;
					A_0.Graphics.DrawString(text4, font10, brush2, num6, num7);
				}
				num7 = (float)((double)(num7 + (float)(flag9 ? Math.Max(font9.Height, font10.Height) : font9.Height)) + (double)num4 * 0.5);
				A_0.Graphics.DrawLine(Pens.Black, 0f, (int)Math.Round(num7), (float)num2 - 5f, (int)Math.Round(num7));
				A_2 = "LayerMaterial";
				array[0] = hu.a(ref A_2);
				hi hi2 = hg2.b3(hc2.cf());
				short num8 = (short)(hi2.g7() + 1);
				string[] array2 = new string[num8 + 1];
				short num9 = num8;
				for (short num10 = 0; num10 <= num9; num10 = (short)unchecked(num10 + 1))
				{
					gc2 = hi2.eu(num10);
					array2[num10] = gc2.ag();
					if (gc2.af(a_4))
					{
						flag = true;
					}
					if (gc2.ah(a_2))
					{
						flag3 = true;
					}
					if (gc2.aj(a_2))
					{
						flag4 = true;
					}
					if (gc2.al(a_2))
					{
						flag5 = true;
					}
					bool flag11 = num10 > 0 && num10 < num8;
					if (gc2.ap(a_3) && flag11)
					{
						flag2 = true;
					}
					if (gc2.ah(a_2) || gc2.aj(a_2))
					{
						if (hc2.cz(num10).af() == hd.a.n)
						{
							flag7 = true;
						}
						else if (hc2.cz(num10).af() == hd.a.k)
						{
							flag6 = true;
						}
					}
				}
				short num11 = 1;
				if (flag)
				{
					A_2 = "LayerThickness";
					array[1] = hu.a(ref A_2);
					num11 = (short)unchecked(num11 + 1);
				}
				if (flag2)
				{
					A_2 = "LayerThicknessNonuniformity";
					array[2] = hu.a(ref A_2);
					num11 = (short)unchecked(num11 + 1);
				}
				if (flag5)
				{
					A_2 = "LayerRoughness";
					array[3] = hu.a(ref A_2);
					num11 = (short)unchecked(num11 + 1);
				}
				if (flag3)
				{
					array[4] = "n(" + Conversions.ToString(hi2.f6()) + " nm)";
					num11 = (short)unchecked(num11 + 1);
				}
				if (flag4)
				{
					array[5] = "k(" + Conversions.ToString(hi2.f6()) + " nm)";
					num11 = (short)unchecked(num11 + 1);
				}
				if (flag6)
				{
					A_2 = "Crystallinity";
					array[7] = hu.a(ref A_2);
					num11 = (short)unchecked(num11 + 1);
				}
				if (flag7)
				{
					A_2 = "Porosity";
					array[6] = hu.a(ref A_2);
					num11 = (short)unchecked(num11 + 1);
				}
				hi2 = null;
				Rectangle rect = new Rectangle
				{
					Width = (short)Math.Round((double)num2 / 7.0),
					Height = 20
				};
				float num12 = (float)((double)(num2 - rect.Width * num11) * 0.5);
				float num13 = (int)Math.Round((double)num7 + (double)num4 * 0.5);
				string text5 = "";
				num11 = 0;
				short num14 = 0;
				do
				{
					bool flag12 = false;
					switch (num14)
					{
					case 0:
						flag12 = true;
						text5 = array[0];
						break;
					case 1:
						if (flag)
						{
							flag12 = true;
							text5 = array[1];
						}
						break;
					case 2:
						if (flag2)
						{
							flag12 = true;
							text5 = array[2];
						}
						break;
					case 4:
						if (flag3)
						{
							flag12 = true;
							text5 = array[4];
						}
						break;
					case 5:
						if (flag4)
						{
							flag12 = true;
							text5 = array[5];
						}
						break;
					case 3:
						if (flag5)
						{
							flag12 = true;
							text5 = array[3];
						}
						break;
					case 7:
						if (flag6)
						{
							flag12 = true;
							text5 = array[7];
						}
						break;
					case 6:
						if (flag7)
						{
							flag12 = true;
							text5 = array[6];
						}
						break;
					}
					if (flag12)
					{
						rect.X = (int)Math.Round(num12 + (float)(num11 * rect.Width));
						rect.Y = (int)Math.Round(num13);
						A_0.Graphics.DrawRectangle(Pens.Black, rect);
						num6 = (float)((double)rect.X + (double)((float)rect.Width - A_0.Graphics.MeasureString(text5, font5).Width) * 0.5);
						num7 = (float)((double)rect.Y + (double)((float)rect.Height - A_0.Graphics.MeasureString(text5, font5).Height) * 0.5);
						A_0.Graphics.DrawString(text5, font5, Brushes.Black, num6, num7);
						num11 = (short)unchecked(num11 + 1);
					}
					num14 = (short)unchecked(num14 + 1);
				}
				while (num14 <= 6);
				bool flag13 = false;
				bool flag14 = false;
				int num15 = 0;
				hc hc3 = hc2;
				hc3.dk();
				float[] array3 = hc3.di();
				float[] array4 = hc3.dj();
				float[] array5 = hc3.dm();
				float[] array6 = hc3.dn();
				float[] array7 = hc3.@do();
				float[] array8 = hc3.dp();
				float[] array9 = hc3.dq();
				short num16 = (short)(hc3.cm() - 1);
				for (short num10 = 0; num10 <= num16; num10 = (short)unchecked(num10 + 1))
				{
					gc2 = hc3.cy().b3(hc3.cf()).eu(num10);
					bool flag11 = num10 > 0 && num10 < num8;
					if (gc2.ah(a_2) || (num10 > 0 && (gc2.aj(a_2) || gc2.al(a_2))) || (flag11 && (gc2.af(a_4) || gc2.an(a_2) || gc2.ap(a_3))))
					{
						if ((num10 == hc3.cm() - 1) & (array3[num10] == -1f))
						{
							break;
						}
						rect.Y = (int)Math.Round(num13 + (float)((num15 + 1) * rect.Height));
						num11 = 0;
						num14 = 0;
						do
						{
							Font font11 = font6;
							bool flag12 = false;
							switch (num14)
							{
							case 0:
								flag12 = true;
								text5 = gc2.ag();
								break;
							case 1:
								if (!flag)
								{
									break;
								}
								flag12 = true;
								if (!gc2.af(a_4))
								{
									text5 = "";
									break;
								}
								text5 = hg.bu(hg.o.a, hc3.cy().ca(), array3[num10], a_, new h4(h4.a.b), 0);
								if (hc3.dd() == cc.n.c)
								{
									font11 = font7;
									flag14 = true;
									text5 = "**" + text5 + "**";
								}
								else
								{
									font11 = font8;
								}
								if (flag8)
								{
									text5 += "??";
									flag13 = true;
								}
								break;
							case 2:
								if (!flag2)
								{
									break;
								}
								flag12 = true;
								if (gc2.ap(a_3) && flag11)
								{
									text5 = "+/-" + hg.bu(hg.o.a, hc3.cy().ca(), array4[num10], a_, new h4(h4.a.b), 0);
									if (flag8)
									{
										text5 += "??";
									}
								}
								else
								{
									text5 = "";
								}
								break;
							case 4:
								if (flag3)
								{
									flag12 = true;
									text5 = ((!gc2.ah(a_2)) ? "" : cc.cf((double)array5[num10]));
								}
								break;
							case 5:
								if (flag4)
								{
									flag12 = true;
									text5 = ((!gc2.aj(a_2)) ? "" : cc.cf((double)array6[num10]));
								}
								break;
							case 3:
								if (flag5)
								{
									flag12 = true;
									text5 = ((!gc2.al(a_2)) ? "" : hg.bu(hg.o.a, hc3.cy().ca(), array7[num10], a_, new h4(h4.a.b), 0));
								}
								break;
							case 7:
								if (flag6)
								{
									flag12 = true;
									gc gc4 = hc3.cy().b3(hc3.cf()).eu(num10);
									text5 = ((!gc4.ah(a_2) || !gc4.aj(a_2) || hc2.cz(num10).af() != hd.a.k) ? "" : hg.bu(2, array8[num10], hc2.cy().ca()));
									gc4 = null;
								}
								break;
							case 6:
								if (flag6)
								{
									flag12 = true;
									gc gc3 = hc3.cy().b3(hc3.cf()).eu(num10);
									text5 = ((!gc3.ah(a_2) || !gc3.aj(a_2) || hc2.cz(num10).af() != hd.a.n) ? "" : hg.bu(2, array9[num10], hc2.cy().ca()));
									gc3 = null;
								}
								break;
							}
							if (flag12)
							{
								rect.X = (int)Math.Round(num12 + (float)(num11 * rect.Width));
								A_0.Graphics.DrawRectangle(Pens.Black, rect);
								num6 = (float)((double)rect.X + (double)((float)rect.Width - A_0.Graphics.MeasureString(text5, font11).Width) * 0.5);
								num7 = (float)((double)rect.Y + (double)((float)rect.Height - A_0.Graphics.MeasureString(text5, font11).Height) * 0.5);
								A_0.Graphics.DrawString(text5, font11, Brushes.Black, num6, num7);
								num11 = (short)unchecked(num11 + 1);
							}
							num14 = (short)unchecked(num14 + 1);
						}
						while (num14 <= 6);
						num15++;
					}
				}
				hc3 = null;
				num7 += 10f;
				if (flag14)
				{
					num6 = (float)num2 - A_0.Graphics.MeasureString(text2, font8).Width;
					num7 += 5f;
					A_0.Graphics.DrawString(text2, font8, Brushes.Black, num6, num7);
					num7 += A_0.Graphics.MeasureString(text2, font6).Height;
				}
				string text6 = null;
				if (flag13)
				{
					if (flag10)
					{
						A_2 = "GOFViolation";
						string text7 = hu.a(ref A_2);
						A_2 = "FFTViolation";
						text6 = text + text7 + ", " + hu.a(ref A_2);
					}
					else
					{
						A_2 = "GOFViolation";
						text6 = text + hu.a(ref A_2);
					}
				}
				else if (flag10)
				{
					A_2 = "FFTViolation";
					text6 = text + hu.a(ref A_2);
				}
				if (flag13 || flag10)
				{
					num6 = (float)num2 - A_0.Graphics.MeasureString(text6, font8).Width;
					num7 += 5f;
					A_0.Graphics.DrawString(text6, font8, Brushes.Black, num6, num7);
					num7 += A_0.Graphics.MeasureString(text6, font6).Height;
				}
				hc hc4 = hc2;
				cc.h h10 = hc4.dg();
				unchecked
				{
					if (h10 != null)
					{
						string text8 = "FPDip Results: " + cc.h.g() + h10.h() + cc.h.d() + ", " + cc.h.f() + h10.i() + cc.h.d() + ", " + cc.h.e() + h10.j() + cc.h.d();
						num6 = (float)(num2 / 2) - A_0.Graphics.MeasureString(text8, font8).Width / 2f;
						num7 += 10f;
						A_0.Graphics.DrawString(text8, font8, Brushes.Black, num6, num7);
						num7 += A_0.Graphics.MeasureString(text8, font8).Height;
					}
					if (hc4.dh() != null)
					{
						string text9 = "DBRCenter Results: " + cc.i.g() + h10.h() + cc.h.d() + ", " + cc.i.f() + h10.i() + cc.h.d() + ", " + cc.i.e() + h10.j() + cc.h.d();
						num6 = (float)(num2 / 2) - A_0.Graphics.MeasureString(text9, font8).Width / 2f;
						num7 += 10f;
						A_0.Graphics.DrawString(text9, font8, Brushes.Black, num6, num7);
						num7 += A_0.Graphics.MeasureString(text9, font8).Height;
					}
					hc4 = null;
				}
			}
			num6 = 0f;
			num7 += 5f;
			ad[0].ak(global::e.a().PrintActiveCurveOnly);
			if (ab == 1)
			{
				int num17 = (int)Math.Round(num6);
				int num18 = (int)Math.Round(num7);
				int num19 = (int)Math.Round((float)num2 - 5f - (float)num17);
				int num20 = (int)Math.Round((float)num - 5f - num7);
				ad[0].g3();
				ad[0].r((short)num20);
				ad[0].q((short)num19);
				ad[0].p((short)num17);
				ad[0].o((short)num18);
				ad[0].s((short)num);
				ad[0].u(A_0.Graphics, A_1: true);
			}
			else
			{
				int num17 = (int)Math.Round(num6);
				int num18 = (int)Math.Round(num7);
				int num19 = (int)Math.Round((float)num2 - 5f - (float)num17);
				int num20 = (int)Math.Round((double)((float)num - num7 - 10f) * 0.5);
				ad[0].g3();
				ad[0].r((short)num20);
				ad[0].q((short)num19);
				ad[0].p((short)num17);
				ad[0].o((short)num18);
				ad[0].s((short)Math.Round(num7 + (float)num20));
				ad[0].u(A_0.Graphics, A_1: true);
				num6 = 0f;
				num7 += (float)num20;
				num6 = 0f;
				ad[1].r((short)num20);
				ad[1].o((short)Math.Round(num7));
				num6 = 0f;
				num17 = (int)Math.Round(num6);
				num2 = (int)Math.Round((float)num2 - 5f - (float)num17);
				ad[1].g3();
				ad[1].q((short)num2);
				ad[1].p((short)num17);
				ad[1].s((short)num);
				ad[1].u(A_0.Graphics, A_1: true);
			}
			if (n != null)
			{
				b b10 = n;
				string[] array10 = b10.a.Replace("\n", "").Split('\r');
				num7 = b10.c;
				List<float> list = new List<float>();
				List<float> list2 = new List<float>();
				string[] array11 = array10;
				foreach (string text10 in array11)
				{
					SizeF sizeF3 = A_0.Graphics.MeasureString(text10, font2);
					list.Add(sizeF3.Width);
					list2.Add(sizeF3.Height);
				}
				float num22 = ((!b10.f) ? b10.b : ((float)num2 - b10.b));
				int num23 = array10.Length - 1;
				for (int num24 = 0; num24 <= num23; num24++)
				{
					A_0.Graphics.DrawString(array10[num24], font2, Brushes.Black, num22 + (b10.d - list[num24]) / 2f, num7);
					num7 += list2[num24];
				}
				A_0.Graphics.DrawRectangle(Pens.Black, num22, num7, b10.d, b10.e);
				b10 = null;
			}
			ad[0].ak(A_0: false);
			A_0.HasMorePages = false;
		}
	}

	private void g(PrintPageEventArgs A_0)
	{
		string text = "h(" + Conversions.ToString(Strings.Chr(176)) + ")";
		string text2 = "c";
		string text3 = "h";
		Font font = new Font("Arial", 12f, FontStyle.Bold);
		Font font2 = new Font("Arial", 10f, FontStyle.Bold);
		Font font3 = new Font("Arial", 9f, FontStyle.Regular);
		Font font4 = new Font("Arial", 9f, FontStyle.Bold);
		Font font5 = new Font("Arial", 8f, FontStyle.Regular);
		new Font("Arial", 8f, FontStyle.Bold);
		Font font6 = new Font("Arial", 10f, FontStyle.Regular);
		hc hc2 = null;
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		float num5 = 0f;
		float num6 = 0f;
		float num7 = 0f;
		float num8 = 0f;
		float num9 = 0f;
		float num10 = 0f;
		float num11 = 0f;
		float num12 = 0f;
		float num13 = 0f;
		float num14 = 0f;
		float num15 = 0f;
		int num16 = 0;
		if (global::e.a().ShowSpectrumCoordOption == 1)
		{
			text2 = "u";
			text3 = "v";
		}
		else
		{
			text2 = "a";
			text3 = "b";
		}
		PageSettings defaultPageSettings = f5.m_d.DefaultPageSettings;
		checked
		{
			int num17 = (int)Math.Round(defaultPageSettings.PrintableArea.Height);
			int num18 = (int)Math.Round(defaultPageSettings.PrintableArea.Width);
			if (defaultPageSettings.Landscape)
			{
				int num19 = num17;
				num17 = num18;
				num18 = num19;
			}
			_ = null;
			Graphics graphics = A_0.Graphics;
			graphics.Clear(Color.White);
			SizeF sizeF = graphics.MeasureString(o, font2);
			float num20 = 20f;
			float num21 = 20f;
			graphics.DrawString(o, font2, Brushes.Black, num20, num21);
			num21 = 20f + sizeF.Height;
			graphics.DrawString(p, font2, Brushes.Black, num20, num21);
			string text4 = Strings.Format(DateAndTime.Now, "General Date");
			num20 = (float)num18 - graphics.MeasureString(text4, font5).Width - 40f;
			num21 = 20f;
			graphics.DrawString(text4, font5, Brushes.Black, num20, num21);
			string text5;
			string A_1;
			if (k.Count > 1)
			{
				A_1 = "SpectrumPluralString";
				text5 = hu.a(ref A_1);
			}
			else
			{
				A_1 = "SpectrumSingularString";
				text5 = hu.a(ref A_1);
			}
			sizeF = graphics.MeasureString(text5, font3);
			num20 = (float)((double)num18 * 0.5 - (double)sizeF.Width * 0.5);
			num21 += sizeF.Height + 5f;
			graphics.DrawString(text5, font3, Brushes.Black, num20, num21);
			sizeF = graphics.MeasureString(Strings.UCase(this.m_w), font);
			num20 = (float)((double)num18 * 0.5 - (double)sizeF.Width * 0.5);
			num21 += 20f + sizeF.Height;
			graphics.DrawString(Strings.UCase(this.m_w), font, Brushes.Black, num20, num21);
			Graphics graphics2 = graphics;
			A_1 = "Comment";
			sizeF = graphics2.MeasureString(hu.a(ref A_1), font4);
			num20 = 80f;
			num21 += sizeF.Height * 2f;
			Graphics graphics3 = graphics;
			A_1 = "Comment";
			graphics3.DrawString(hu.a(ref A_1), font4, Brushes.Black, num20, num21);
			num20 += 40f + sizeF.Width;
			graphics.DrawString(q, font3, Brushes.Black, num20, num21);
			Rectangle rect = new Rectangle(40, (int)Math.Round((double)num21 - (double)sizeF.Height * 0.5), num18 - 80, (int)Math.Round(sizeF.Height * 2f));
			graphics.DrawRectangle(Pens.Black, rect);
			num20 = 80f;
			num21 += sizeF.Height * 2f;
			Graphics graphics4 = graphics;
			A_1 = "Coating";
			graphics4.DrawString(hu.a(ref A_1), font4, Brushes.Black, num20, num21);
			num20 += 40f + sizeF.Width;
			graphics.DrawString(r, font3, Brushes.Black, num20, num21);
			num20 = (float)((double)num18 * 0.5 + (double)sizeF.Width);
			Graphics graphics5 = graphics;
			A_1 = "ReferenceMaterial";
			graphics5.DrawString(hu.a(ref A_1), font4, Brushes.Black, num20, num21);
			Graphics graphics6 = graphics;
			A_1 = "ReferenceMaterial";
			sizeF = graphics6.MeasureString(hu.a(ref A_1), font4);
			num20 += 40f + sizeF.Width;
			if (k != null && k.Count > 0 && k[0] != null)
			{
				string text6 = null;
				hr hr2 = k[0];
				if (hr2.br() != null && hr2.br().Count > 0 && hr2.br()[0].q() != null)
				{
					text6 = hr2.br()[0].q().i();
					if (Operators.CompareString(text6, "FiberTip", TextCompare: false) == 0)
					{
						text6 = "BK7";
					}
				}
				else
				{
					A_1 = "Unknown";
					text6 = hu.a(ref A_1);
				}
				hr2 = null;
				graphics.DrawString(text6, font3, Brushes.Black, num20, num21);
			}
			rect.Y = (int)Math.Round((double)num21 - (double)sizeF.Height * 0.5);
			rect.Height = (int)Math.Round(sizeF.Height * 2f);
			rect.Width = num18 - 80;
			graphics.DrawRectangle(Pens.Black, rect);
			num21 = rect.Y + rect.Height;
			int num22 = j.Count + 1;
			int num23 = j.Count - 1;
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			int num25 = default(int);
			for (int num24 = 0; num24 <= num23; num24++)
			{
				hc hc3 = j[num24];
				if (hc3.cp() != null && global::e.a().ShowSpectrumColor)
				{
					num16++;
					num22++;
				}
				if (hc3.ea() != null || hc3.cf(hi.c.a) != null || hc3.cf(hi.c.a) != null || hc3.cf(hi.c.a) != null || hc3.eb() != null)
				{
					flag = flag || hc3.ea() != null;
					flag2 = flag2 || hc3.cf(hi.c.a) != null;
					flag3 = flag3 || hc3.cf(hi.c.b) != null;
					flag4 = flag4 || hc3.cf(hi.c.c) != null;
					flag5 = hc3.eb() != null;
					num25++;
				}
				hc3 = null;
			}
			if (num25 > 0)
			{
				num25++;
			}
			bool flag6 = num25 > 2;
			if (flag6)
			{
				num25++;
			}
			bool flag7 = j.Count > 1;
			if (flag7)
			{
				num22++;
			}
			bool flag8 = num16 > 1;
			if (flag8)
			{
				num22++;
			}
			int num26 = default(int);
			int num27 = default(int);
			if (num25 > 0)
			{
				num26 = (num25 - 1) * 28 + 40;
				num27 = 5;
			}
			if (global::e.a().ShowSpectrumColor)
			{
				num26 += (num22 - 1) * 28 + 40;
				if (num22 > 0 && num25 > 0)
				{
					num26 += 5;
				}
				num27 = 5;
			}
			int num28 = num17 - num26 - 40;
			int num29 = num28 - num27 - ((int)Math.Round(num21) + 5);
			int num30 = num18 - 80;
			ad[0].g3();
			ad[0].r((short)num29);
			ad[0].q((short)num30);
			ad[0].p(40);
			ad[0].o((short)Math.Round(num21 + 5f));
			ad[0].s((short)Math.Round(num21 + (float)num29));
			ad[0].u(A_0.Graphics, A_1: true);
			if (global::e.a().ShowSpectrumColor)
			{
				int num31 = 540;
				int num32 = (int)Math.Round(0.5 * (double)num18 - 0.5 * (double)num31);
				int num33 = num28;
				int num34 = num22 - 1;
				int num35;
				for (num35 = 0; num35 <= num34; num35++)
				{
					float height;
					if (num35 == 0)
					{
						height = 40f;
						num21 = num33;
					}
					else
					{
						height = 28f;
						num21 = num33 + 40 + (num35 - 1) * 28;
					}
					num20 = num32;
					graphics.DrawRectangle(Pens.Black, num20, num21, 280f, height);
					num20 += 280f;
					graphics.DrawRectangle(Pens.Black, num20, num21, 40f, height);
					num20 += 40f;
					graphics.DrawRectangle(Pens.Black, num20, num21, 40f, height);
					num20 += 40f;
					graphics.DrawRectangle(Pens.Black, num20, num21, 60f, height);
					num20 += 60f;
					graphics.DrawRectangle(Pens.Black, num20, num21, 60f, height);
					num20 += 60f;
					graphics.DrawRectangle(Pens.Black, num20, num21, 60f, height);
				}
				float num36 = num33;
				Graphics graphics7 = graphics;
				A_1 = "SpecLabelHdr";
				num21 = num36 + (float)(20.0 - (double)graphics7.MeasureString(hu.a(ref A_1), font4).Height * 0.5);
				double num37 = (double)num32 + 140.0;
				Graphics graphics8 = graphics;
				A_1 = "SpecLabelHdr";
				num20 = (float)(num37 - (double)graphics8.MeasureString(hu.a(ref A_1), font4).Width * 0.5);
				Graphics graphics9 = graphics;
				A_1 = "SpecLabelHdr";
				graphics9.DrawString(hu.a(ref A_1), font4, Brushes.Black, num20, num21);
				num20 = (float)((double)(num32 + 280) + 20.0 - (double)graphics.MeasureString(text, font4).Width * 0.5);
				graphics.DrawString(text, font4, Brushes.Black, num20, num21);
				num20 = (float)((double)(num32 + 280 + 40) + 20.0 - (double)graphics.MeasureString("C", font4).Width * 0.5);
				graphics.DrawString("C", font4, Brushes.Black, num20, num21);
				num20 = (float)((double)(num32 + 280 + 40 + 40) + 30.0 - (double)graphics.MeasureString("L", font4).Width * 0.5);
				graphics.DrawString("L", font4, Brushes.Black, num20, num21);
				num20 = (float)((double)(num32 + 280 + 40 + 40 + 60) + 30.0 - (double)graphics.MeasureString(text2, font4).Width * 0.5);
				graphics.DrawString(text2, font4, Brushes.Black, num20, num21);
				num20 = (float)((double)(num32 + 280 + 40 + 40 + 60 + 60) + 30.0 - (double)graphics.MeasureString(text3, font4).Width * 0.5);
				graphics.DrawString(text3, font4, Brushes.Black, num20, num21);
				bool flag9 = true;
				int num38 = 0;
				int num39 = j.Count + num16;
				for (num35 = 1; num35 <= num39; num35++)
				{
					hc2 = j[num38];
					cc.f f10 = ((!flag9) ? hc2.cp() : hc2.co());
					if (f10 != null)
					{
						bool flag10 = global::e.a().ShowSpectrumCoordOption == 1;
						foreach (cc.d item in f10.e())
						{
							switch (item.h())
							{
							case a4.a.a:
								if (!flag10)
								{
									num4 = item.l();
									num5 = item.m();
								}
								break;
							case a4.a.c:
								num3 = item.k();
								num2 = item.l();
								num = item.m();
								break;
							case a4.a.b:
								if (flag10)
								{
									num4 = item.l();
									num5 = item.m();
								}
								break;
							}
						}
						string text7 = hc2.cn().b5();
						string format;
						if (flag9)
						{
							format = "{0}";
						}
						else
						{
							A_1 = "ColorTransLabelFmt";
							format = hu.a(ref A_1);
						}
						while (text7.Length > 0 && graphics.MeasureString(string.Format(format, text7), font6).Width > 280f)
						{
							text7 = text7.Substring(0, text7.Length - 1);
						}
						a(num32, num33, A_0.Graphics, font6, string.Format(format, text7), num35, num, num2, num3, num4, num5);
						if (flag9)
						{
							num6 += num;
							num7 += num2;
							num8 += num3;
							num9 += num4;
							num10 += num5;
						}
						else
						{
							num11 += num;
							num12 += num2;
							num13 += num3;
							num14 += num4;
							num15 += num5;
						}
					}
					if (flag9 && hc2.cp() != null)
					{
						flag9 = false;
						continue;
					}
					flag9 = true;
					num38++;
				}
				if (flag7)
				{
					float a_ = num32;
					float a_2 = num33;
					Graphics graphics10 = A_0.Graphics;
					A_1 = "RegionMeanLabelSuffix";
					a(a_, a_2, graphics10, font6, hu.a(ref A_1), num35, num6 / (float)j.Count, num7 / (float)j.Count, num8 / (float)j.Count, num9 / (float)j.Count, num10 / (float)j.Count);
				}
				if (flag8)
				{
					float a_3 = num32;
					float a_4 = num33;
					Graphics graphics11 = A_0.Graphics;
					A_1 = "ColorTransRegionMeanLabel";
					a(a_3, a_4, graphics11, font6, hu.a(ref A_1), num35 + 1, num11 / (float)num16, num12 / (float)num16, num13 / (float)num16, num14 / (float)num16, num15 / (float)num16);
				}
				num21 = num33 + 40 + (num22 - 1) * 28;
			}
			else
			{
				num21 = num17 - 40 - num26;
			}
			if (num25 > 0)
			{
				int num40 = 280;
				if (flag)
				{
					num40 += 92;
				}
				if (flag2)
				{
					num40 += 80;
				}
				if (flag3)
				{
					num40 += 80;
				}
				if (flag4)
				{
					num40 += 80;
				}
				if (flag5)
				{
					num40 += 92;
				}
				int num41 = (int)Math.Round((double)num18 * 0.5 - (double)num40 * 0.5);
				int num42 = (int)Math.Round(num21 + 5f);
				int num43 = num25 - 1;
				int num35;
				for (num35 = 0; num35 <= num43; num35++)
				{
					float height;
					if (num35 == 0)
					{
						height = 40f;
						num21 = num42;
					}
					else
					{
						height = 28f;
						num21 = num42 + 40 + (num35 - 1) * 28;
					}
					graphics.DrawRectangle(Pens.Black, num41, num21, 280f, height);
					num20 = num41 + 280;
					if (flag)
					{
						graphics.DrawRectangle(Pens.Black, num20, num21, 92f, height);
						num20 += 92f;
					}
					if (flag5)
					{
						graphics.DrawRectangle(Pens.Black, num20, num21, 92f, height);
						num20 += 92f;
					}
					if (flag2)
					{
						graphics.DrawRectangle(Pens.Black, num20, num21, 80f, height);
						num20 += 80f;
					}
					if (flag3)
					{
						graphics.DrawRectangle(Pens.Black, num20, num21, 80f, height);
						num20 += 80f;
					}
					if (flag4)
					{
						graphics.DrawRectangle(Pens.Black, num20, num21, 80f, height);
					}
				}
				float a_5 = num41;
				float a_6 = num42;
				Graphics graphics12 = A_0.Graphics;
				A_1 = "SpecLabelHdr";
				a(a_5, a_6, graphics12, font4, 0, 0f, 280f, hu.a(ref A_1), f5.e.b);
				int num44 = 280;
				if (flag)
				{
					a(num41, num42, A_0.Graphics, font4, 0, num44, 92f, cc.cg(58, A_1: false, null, A_3: true), f5.e.b);
					num44 += 92;
				}
				if (flag5)
				{
					a(num41, num42, A_0.Graphics, font4, 0, num44, 92f, cc.cg(65, A_1: false, null, A_3: true), f5.e.b);
					num44 += 92;
				}
				if (flag2)
				{
					a(num41, num42, A_0.Graphics, font4, 0, num44, 80f, cc.cg(55, A_1: false, null, A_3: true), f5.e.b);
					num44 += 80;
				}
				int A_2 = default(int);
				if (flag3)
				{
					a(num41, num42, A_0.Graphics, font4, 0, num44, 80f, cc.cg(56, A_1: false, null, A_3: true), f5.e.b);
					num44 += 80;
					A_2++;
				}
				int A_3 = default(int);
				if (flag4)
				{
					a(num41, num42, A_0.Graphics, font4, 0, num44, 80f, cc.cg(57, A_1: false, null, A_3: true), f5.e.b);
					A_3++;
				}
				num35 = 1;
				float num45;
				string text8;
				if (Conversions.ToBoolean(global::e.a().GraphMeasYLabelPercent[0]))
				{
					num45 = 100f;
					text8 = "0.00";
				}
				else
				{
					num45 = 1f;
					text8 = "0.0000";
				}
				int num46 = j.Count - 1;
				int A_4 = default(int);
				float A_5 = default(float);
				int A_6 = default(int);
				float A_7 = default(float);
				int A_8 = default(int);
				double A_9 = default(double);
				double A_10 = default(double);
				double A_11 = default(double);
				for (int num47 = 0; num47 <= num46; num47++)
				{
					hc hc4 = j[num47];
					ix.c a_7 = hc4.ea();
					ix.c a_8 = hc4.eb();
					a(A_15: (hc4.cf(hi.c.a) == null) ? null : new ix.d(hc4.cf(hi.c.a).d()), A_16: (hc4.cf(hi.c.b) == null) ? null : new ix.d(hc4.cf(hi.c.b).d()), A_17: (hc4.cf(hi.c.c) == null) ? null : new ix.d(hc4.cf(hi.c.c).d()), A_0: font6, A_1: A_0.Graphics, A_2: num41, A_3: num42, A_4: ref num35, A_5: flag, A_6: flag5, A_7: flag2, A_8: flag3, A_9: flag4, A_10: num45, A_11: text8, A_12: hc4.cn().b5(), A_13: a_7, A_14: a_8, A_18: ref A_4, A_19: ref A_5, A_20: ref A_6, A_21: ref A_7, A_22: ref A_8, A_23: ref A_9, A_24: ref A_2, A_25: ref A_10, A_26: ref A_3, A_27: ref A_11);
					hc4 = null;
				}
				if (flag6)
				{
					ix.c c10 = null;
					ix.c c11 = null;
					ix.d d10 = null;
					ix.d d11 = null;
					ix.d d12 = null;
					if (A_4 > 0)
					{
						c10 = new ix.c(A_5 / (float)A_4);
					}
					if (A_6 > 0)
					{
						c11 = new ix.c(A_7 / (float)A_6);
					}
					if (A_8 > 0)
					{
						d10 = new ix.d(A_9 / (double)A_8);
					}
					if (A_2 > 0)
					{
						d11 = new ix.d(A_10 / (double)A_2);
					}
					if (A_3 > 0)
					{
						d12 = new ix.d(A_11 / (double)A_3);
					}
					Graphics graphics13 = A_0.Graphics;
					bool a_9 = flag;
					bool a_10 = flag5;
					bool a_11 = flag2;
					bool a_12 = flag3;
					bool a_13 = flag4;
					float a_14 = num45;
					string a_15 = text8;
					A_1 = "RegionMeanLabelSuffix";
					string a_16 = hu.a(ref A_1);
					ix.c a_17 = c10;
					ix.c a_18 = c11;
					ix.d a_19 = d10;
					ix.d a_20 = d11;
					ix.d a_21 = d12;
					int A_12 = 0;
					float A_13 = 0f;
					int A_14 = 0;
					float A_15 = 0f;
					int A_16 = 0;
					double A_17 = 0.0;
					int A_18 = 0;
					double A_19 = 0.0;
					int A_20 = 0;
					double A_21 = 0.0;
					a(font6, graphics13, num41, num42, ref num35, a_9, a_10, a_11, a_12, a_13, a_14, a_15, a_16, a_17, a_18, a_19, a_20, a_21, ref A_12, ref A_13, ref A_14, ref A_15, ref A_16, ref A_17, ref A_18, ref A_19, ref A_20, ref A_21);
				}
			}
			graphics = null;
			A_0.HasMorePages = false;
		}
	}

	private void a(PrintPageEventArgs A_0)
	{
		Font font = new Font("Arial", 10f, FontStyle.Regular);
		Font font2 = new Font("Arial", 9f, FontStyle.Regular);
		Font font3 = new Font("Verdana", 16f, FontStyle.Bold);
		float num = 20f;
		A_0.Graphics.Clear(Color.White);
		PageSettings defaultPageSettings = f5.m_d.DefaultPageSettings;
		checked
		{
			int num2 = (int)Math.Round(defaultPageSettings.PrintableArea.Height);
			int num3 = (int)Math.Round(defaultPageSettings.PrintableArea.Width);
			if (defaultPageSettings.Landscape)
			{
				int num4 = num2;
				num2 = num3;
				num3 = num4;
			}
			_ = null;
			float num5 = (float)num3 * 0.5f;
			float num6 = 0f;
			float num7 = (float)((double)num * 0.5);
			Graphics graphics = A_0.Graphics;
			string A_1 = "MeasurementHistory";
			graphics.DrawString(hu.a(ref A_1), font3, Brushes.Black, num6, num7);
			float A_2 = default(float);
			float A_3 = default(float);
			i5.a(this.m_v, ref A_2, ref A_3);
			A_0.Graphics.DrawImage(this.m_v, (float)(num3 - 10) - A_2, 10f);
			num7 = A_3 + 10f + 4f;
			A_0.Graphics.DrawLine(Pens.Black, 0f, (int)Math.Round(num7), (float)num3 - 5f, (int)Math.Round(num7));
			num7 += num * 0.3f;
			float num8 = num7;
			float num9 = (float)num2 - num8;
			num6 = 5f;
			string text = "Channel: " + ae.a;
			SizeF sizeF = A_0.Graphics.MeasureString(text, font);
			A_0.Graphics.DrawString(text, font, Brushes.Black, num6, num7);
			num7 += sizeF.Height + 5f;
			float num10 = num5 - 5f;
			int num11 = ae.e.Height + ae.f.Height;
			int num12 = Math.Max(ae.e.Width, ae.f.Width);
			float num13 = num9 - (sizeF.Height + 5f);
			float num14;
			if ((double)(num13 / num10) > (double)num11 / (double)num12)
			{
				num14 = num10 / (float)num12;
				num7 += (num13 / num14 - (float)ae.e.Height - (float)ae.f.Height - 5f) * 0.5f;
			}
			else
			{
				num14 = num13 / (float)num12;
				num7 += 5f / num14;
			}
			A_0.Graphics.ScaleTransform(num14, num14);
			A_0.Graphics.DrawImage(ae.e, 5f / num14, num7, ae.e.Width, ae.e.Height);
			A_0.Graphics.DrawImage(ae.f, 5f / num14, num7 + (float)ae.e.Height + 5f / num14, ae.f.Width, ae.f.Height);
			A_0.Graphics.ScaleTransform(1f / num14, 1f / num14);
			num7 = num8 + 5f;
			if (ae.d)
			{
				text = "Parameter: " + ae.b;
				sizeF = A_0.Graphics.MeasureString(text, font);
				num6 = num5 + (num5 - sizeF.Width) * 0.5f;
				A_0.Graphics.DrawString(text, font, Brushes.Black, num6, num7);
				num7 += sizeF.Height;
				num6 = num5;
				int num15 = (int)Math.Round(num6);
				int num16 = (int)Math.Round(num7);
				int num17 = (int)Math.Round((float)num3 - 5f - (float)num15);
				int num18 = (int)Math.Round((float)num2 - 10f - num7);
				ad[0].g3();
				ad[0].r((short)num18);
				ad[0].q((short)num17);
				ad[0].p((short)num15);
				ad[0].o((short)num16);
				ad[0].s((short)num2);
				ad[0].u(A_0.Graphics, A_1: true);
				num7 += (float)num18;
				return;
			}
			if (!string.IsNullOrEmpty(ae.c))
			{
				sizeF = A_0.Graphics.MeasureString(ae.c, font2);
				num6 = num5 + (num5 - sizeF.Width) * 0.5f;
				A_0.Graphics.DrawString(ae.c, font2, Brushes.Black, num6, num7);
				num7 += sizeF.Height;
			}
			if (ab >= 2)
			{
				num6 = num5;
				int num15 = (int)Math.Round(num6);
				int num16 = (int)Math.Round(num7);
				int num17 = (int)Math.Round((float)num3 - 5f - (float)num15);
				int num18 = (int)Math.Round((double)((float)num2 - 15f - num7) * 0.5);
				ad[0].g3();
				ad[0].r((short)num18);
				ad[0].q((short)num17);
				ad[0].p((short)num15);
				ad[0].o((short)num16);
				ad[0].s((short)num2);
				ad[0].u(A_0.Graphics, A_1: true);
				num7 += (float)num18;
				num7 += 5f;
				num6 = num5;
				num15 = (int)Math.Round(num6);
				num16 = (int)Math.Round(num7);
				ad[1].g3();
				ad[1].r((short)num18);
				ad[1].q((short)num17);
				ad[1].p((short)num15);
				ad[1].o((short)num16);
				ad[1].s((short)num2);
				ad[1].u(A_0.Graphics, A_1: true);
				num7 += (float)num18;
			}
			else
			{
				num6 = num5;
				int num15 = (int)Math.Round(num6);
				int num16 = (int)Math.Round(num7);
				int num17 = (int)Math.Round((float)num3 - 5f - (float)num15);
				int num18 = (int)Math.Round((float)num2 - 5f - num7);
				ad[0].g3();
				ad[0].r((short)num18);
				ad[0].q((short)num17);
				ad[0].p((short)num15);
				ad[0].o((short)num16);
				ad[0].s((short)num2);
				ad[0].u(A_0.Graphics, A_1: true);
				num7 += (float)num18;
			}
		}
	}

	private void a(float A_0, float A_1, Graphics A_2, Font A_3, string A_4, int A_5, float A_6, float A_7, float A_8, float A_9, float A_10)
	{
		Graphics graphics = A_2;
		float num = A_1 + 40f + (float)checked(28 * (A_5 - 1)) + (float)(14.0 - (double)graphics.MeasureString("0", A_3).Height * 0.5);
		float num2 = A_0 + 5f;
		graphics.DrawString(A_4, A_3, Brushes.Black, num2, num);
		num2 = (float)((double)(A_0 + 280f) + 20.0 - (double)graphics.MeasureString(A_6.ToString("0.0"), A_3).Width * 0.5);
		graphics.DrawString(A_6.ToString("0.0"), A_3, Brushes.Black, num2, num);
		num2 = (float)((double)(A_0 + 280f + 40f) + 20.0 - (double)graphics.MeasureString(A_7.ToString("0.0"), A_3).Width * 0.5);
		graphics.DrawString(A_7.ToString("0.0"), A_3, Brushes.Black, num2, num);
		num2 = (float)((double)(A_0 + 280f + 40f + 40f) + 30.0 - (double)graphics.MeasureString(A_8.ToString("0.00"), A_3).Width * 0.5);
		graphics.DrawString(A_8.ToString("0.00"), A_3, Brushes.Black, num2, num);
		num2 = (float)((double)(A_0 + 280f + 40f + 40f + 60f) + 30.0 - (double)graphics.MeasureString(A_9.ToString("0.00"), A_3).Width * 0.5);
		graphics.DrawString(A_9.ToString("0.00"), A_3, Brushes.Black, num2, num);
		num2 = (float)((double)(A_0 + 280f + 40f + 40f + 60f + 60f) + 30.0 - (double)graphics.MeasureString(A_10.ToString("0.00"), A_3).Width * 0.5);
		graphics.DrawString(A_10.ToString("0.00"), A_3, Brushes.Black, num2, num);
		graphics = null;
	}

	private void a(Font A_0, Graphics A_1, int A_2, int A_3, ref int A_4, bool A_5, bool A_6, bool A_7, bool A_8, bool A_9, float A_10, string A_11, string A_12, ix.c A_13, ix.c A_14, ix.d A_15, ix.d A_16, ix.d A_17, ref int A_18, ref float A_19, ref int A_20, ref float A_21, ref int A_22, ref double A_23, ref int A_24, ref double A_25, ref int A_26, ref double A_27)
	{
		Graphics graphics = A_1;
		checked
		{
			if (A_13 != null || A_14 != null || A_15 != null || A_16 != null || A_17 != null)
			{
				string text = A_12;
				while (text.Length > 0 && graphics.MeasureString(text, A_0).Width > 280f)
				{
					text = text.Substring(0, text.Length - 1);
				}
				a(A_2, A_3, A_1, A_0, A_4, 5f, text);
				int num = 280;
				if (A_5)
				{
					if (A_13 != null)
					{
						a(A_2, A_3, A_1, A_0, A_4, num, 92f, A_13.a * A_10, A_11, f5.e.b);
						A_18++;
						A_19 += A_13.a;
					}
					num += 92;
				}
				if (A_6)
				{
					if (A_14 != null)
					{
						a(A_2, A_3, A_1, A_0, A_4, num, 92f, A_14.a, A_11, f5.e.b);
						A_20++;
						A_21 += A_14.a;
					}
					num += 92;
				}
				if (A_7)
				{
					if (A_15 != null)
					{
						a(A_2, A_3, A_1, A_0, A_4, num, 80f, A_15.a * (double)A_10, A_11, f5.e.b);
						A_22++;
						A_23 += A_15.a;
					}
					num += 80;
				}
				if (A_8)
				{
					if (A_16 != null)
					{
						a(A_2, A_3, A_1, A_0, A_4, num, 80f, A_16.a * (double)A_10, A_11, f5.e.b);
						A_24++;
						A_25 += A_16.a;
					}
					num += 80;
				}
				if (A_9 && A_17 != null)
				{
					a(A_2, A_3, A_1, A_0, A_4, num, 80f, A_17.a * (double)A_10, A_11, f5.e.b);
					A_26++;
					A_27 += A_17.a;
				}
				A_4++;
			}
			graphics = null;
		}
	}

	private void a(float A_0, float A_1, Graphics A_2, Font A_3, int A_4, float A_5, float A_6, double A_7, string A_8, e A_9)
	{
		a(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7.ToString(A_8), A_9);
	}

	private void a(float A_0, float A_1, Graphics A_2, Font A_3, int A_4, float A_5, string A_6)
	{
		a(A_0, A_1, A_2, A_3, A_4, A_5, 0f, A_6, f5.e.a);
	}

	private void a(float A_0, float A_1, Graphics A_2, Font A_3, int A_4, float A_5, float A_6, string A_7, e A_8)
	{
		Graphics graphics = A_2;
		float num = ((A_4 != 0) ? (A_1 + 40f + (float)checked(28 * (A_4 - 1)) + (float)(14.0 - (double)graphics.MeasureString("0", A_3).Height * 0.5)) : (A_1 + 20f - 0.5f * graphics.MeasureString("0", A_3).Height));
		float num2 = default(float);
		switch (A_8)
		{
		case f5.e.a:
			num2 = A_0 + A_5;
			break;
		case f5.e.b:
			num2 = (float)((double)(A_0 + A_5) + 0.5 * (double)A_6 - (double)graphics.MeasureString(A_7, A_3).Width * 0.5);
			break;
		case f5.e.c:
			num2 = (float)((double)(A_0 + A_5 + A_6) - (double)graphics.MeasureString(A_7, A_3).Width * 0.5);
			break;
		}
		graphics.DrawString(A_7, A_3, Brushes.Black, num2, num);
		graphics = null;
	}

	private hc a()
	{
		foreach (hc item in j)
		{
			hc hc2 = item;
			if (hc2.cn().b9() == this.m_t && hc2.cn().ca() == this.m_u && Operators.CompareString(hc2.cy().cl(), l.cl(), TextCompare: false) == 0)
			{
				return item;
			}
			hc2 = null;
		}
		foreach (hr item2 in k)
		{
			hr hr2 = item2;
			if (hr2.b9() == this.m_t && hr2.ca() == this.m_u)
			{
				hc obj = new hc();
				eo.a a_ = null;
				obj.cf(item2, item2.b4(), l, m, null, null, null, A_7: false, A_8: false, null, null, null, A_12: false, null, a_);
				return obj;
			}
			hr2 = null;
		}
		return null;
	}
}
