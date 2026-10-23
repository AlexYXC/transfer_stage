using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class i5
{
	public const int a = 4;

	private const string b = "UtilFILMeasure";

	private const int c = 45;

	private const int d = 189;

	private const int e = 96;

	private const double f = 4.2;

	public static bool a(fz A_0, Collection<string> A_1, bool A_2, Point A_3)
	{
		checked
		{
			string a_;
			if (A_1.Count > 1)
			{
				string text = "";
				if (A_1.Count <= 4)
				{
					int num = A_1.Count - 2;
					for (int num2 = 0; num2 <= num; num2++)
					{
						text += A_1[num2];
						if (A_1.Count > 2)
						{
							text += ", ";
						}
					}
					text = text + " and " + A_1[A_1.Count - 1];
				}
				else
				{
					int num3 = 3;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						text += A_1[num4];
						if (A_1.Count > 2)
						{
							text += ", ";
						}
					}
					text = (A_2 ? (text + " and additional files") : ((A_1.Count - 4 <= 1) ? (text + " and " + (A_1.Count - 4) + " additional file") : (text + " and " + (A_1.Count - 4) + " additional files")));
				}
				string A_4 = "OverwritePromptMultFmt1";
				a_ = string.Format(hu.a(ref A_4), text);
			}
			else
			{
				string A_4 = "OverwritePromptFmt1";
				a_ = string.Format(hu.a(ref A_4), A_1[0]);
			}
			SystemSounds.Exclamation.Play();
			return fe.b(ref A_0, a_, "Warning", "Yes", "No", A_3);
		}
	}

	public static void a(fz A_0, f1 A_1, object A_2, Point A_3, string A_4, string A_5)
	{
		a(A_0, A_1, RuntimeHelpers.GetObjectValue(A_2), A_3, A_4, A_5, null);
	}

	public static void a(fz A_0, f1 A_1, object A_2, Point A_3, string A_4, Exception A_5)
	{
		a(A_0, A_1, RuntimeHelpers.GetObjectValue(A_2), A_3, A_4, null, A_5);
	}

	public static void a(fz A_0, f1 A_1, object A_2, Point A_3, string A_4, string A_5, Exception A_6)
	{
		Guid a_ = default(Guid);
		if (A_2 != null)
		{
			if (A_2 is f4)
			{
				a_ = ((f4)A_2).hc();
			}
			else if (A_2 is by)
			{
				a_ = ((by)A_2).ca();
			}
		}
		a(A_0, A_1, a_, RuntimeHelpers.GetObjectValue(A_2), A_3, A_4, A_5, A_6, null, null);
	}

	public static void a(fz A_0, f1 A_1, Guid A_2, object A_3, Point A_4, string A_5, string A_6)
	{
		a(A_0, A_1, A_2, RuntimeHelpers.GetObjectValue(A_3), A_4, A_5, A_6, null, null, null);
	}

	public static void a(fz A_0, f1 A_1, Point A_2, string A_3, string A_4)
	{
		a(A_0, A_1, default(Guid), null, A_2, null, null, null, A_3, A_4);
	}

	public static void a(fz A_0, f1 A_1, Point A_2, string A_3, string A_4, string A_5, string A_6)
	{
		a(A_0, A_1, default(Guid), null, A_2, A_3, A_4, null, A_5, A_6);
	}

	public static void a(fz A_0, f1 A_1, Guid A_2, object A_3, Point A_4, string A_5, string A_6, Exception A_7, string A_8, string A_9)
	{
		try
		{
			string text;
			if (A_7 == null)
			{
				if (!string.IsNullOrEmpty(A_8))
				{
					A_0.c(fz.b.b, A_8);
					text = A_8;
				}
				else
				{
					text = "Error in " + A_5;
					A_0.c(fz.b.b, text, A_6);
				}
			}
			else
			{
				text = "Error in " + A_5;
				A_0.c(fz.b.b, text, A_7);
				if (string.IsNullOrEmpty(A_6))
				{
					A_6 = A_7.Message;
				}
			}
			bool flag = default(bool);
			foreach (Form openForm in global::c.d().OpenForms)
			{
				if (openForm.TopMost)
				{
					flag = true;
					break;
				}
			}
			SystemSounds.Exclamation.Play();
			string a_;
			if (!string.IsNullOrEmpty(A_8))
			{
				a_ = A_8;
			}
			else
			{
				string A_10 = "GeneralFunctionErrFmt";
				a_ = string.Format(hu.a(ref A_10), A_5 + ". Error is: " + A_6);
			}
			if (fe.b(ref A_0, a_, "SoftwareErrorReportTitle", "RequestSupport", "Close", A_4))
			{
				dw dw2 = new dw(A_0);
				object obj = null;
				bool a_2 = default(bool);
				if (A_3 is f4)
				{
					obj = ((f4)A_3).h1();
				}
				else if (A_3 is by)
				{
					obj = ((by)A_3).cb();
					a_2 = true;
				}
				if (flag)
				{
					dw2.TopMost = true;
				}
				dw2.a(A_1, A_2, RuntimeHelpers.GetObjectValue(obj), text, a_2);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			Interaction.MsgBox("Error in UtilFILMeasure.ProcessErrorInUserInitiatedEvent. Exception is:\r\n" + ex3.ToString());
			try
			{
				if (A_7 == null)
				{
					A_0.c(fz.b.b, "Error in UtilFILMeasure.ProcessErrorInUserInitiatedEvent message version", ex3);
				}
				else
				{
					A_0.c(fz.b.b, "Error in UtilFILMeasure.ProcessErrorInUserInitiatedEvent ex version", ex3);
				}
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex5 = ex4;
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	public static void a(ew.a A_0, PictureBox A_1)
	{
		Bitmap bitmap = a(A_0);
		A_1.Size = bitmap.Size;
		A_1.Image = bitmap;
	}

	public static Bitmap a(ew.a A_0, bool A_1 = false)
	{
		ResourceManager resourceManager = new ResourceManager("Filmetrics.Resources", Assembly.GetExecutingAssembly());
		checked
		{
			Bitmap bitmap;
			float num = default(float);
			switch (A_0)
			{
			case ew.a.a:
				bitmap = ((!A_1) ? ((Bitmap)resourceManager.GetObject("FilmLogoLrg")) : ((Bitmap)resourceManager.GetObject("FilmLogoLrgWht")));
				num = (float)((double)bitmap.Height / 45.0 * 96.0);
				break;
			case ew.a.b:
				bitmap = (Bitmap)resourceManager.GetObject("LeyboldLogo");
				num = (float)((double)(96 * bitmap.Height) / 45.0 / 0.8999999761581421);
				break;
			case ew.a.c:
				bitmap = (Bitmap)resourceManager.GetObject("Allied_Logo_2013_Small");
				num = (float)((double)(96 * bitmap.Height) / 45.0);
				break;
			default:
				bitmap = null;
				break;
			}
			bitmap.SetResolution(num, num);
			return bitmap;
		}
	}

	public static Bitmap a()
	{
		string text = global::e.a().CustomPrintedLogoFullPath;
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		if (!File.Exists(text))
		{
			return null;
		}
		Bitmap bitmap = new Bitmap(text);
		float num = ((!((double)bitmap.Width / (double)bitmap.Height > 4.2)) ? ((float)((double)bitmap.Height / 45.0 * 96.0)) : ((float)((double)bitmap.Width / 189.0 * 96.0)));
		bitmap.SetResolution(num, num);
		return bitmap;
	}

	public static void a(Image A_0, ref float A_1, ref float A_2)
	{
		checked
		{
			A_1 = (float)(A_0.Width * 96) / A_0.HorizontalResolution;
			A_2 = (float)(A_0.Height * 96) / A_0.VerticalResolution;
		}
	}
}
