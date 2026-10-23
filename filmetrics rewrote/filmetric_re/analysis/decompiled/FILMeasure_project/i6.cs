using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

internal class i6
{
	public static string a(double A_0, string A_1)
	{
		string numberDecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
		string text = ((!string.IsNullOrEmpty(A_1)) ? A_0.ToString(A_1) : A_0.ToString());
		if (text.Contains(numberDecimalSeparator))
		{
			text = text.TrimEnd('0');
		}
		if (text.EndsWith(numberDecimalSeparator))
		{
			text = text.Substring(0, checked(text.Length - 1));
		}
		return text;
	}

	public static string a(string A_0)
	{
		double result = 0.0;
		double.TryParse(A_0, out result);
		return result.ToString(CultureInfo.InvariantCulture);
	}

	public static string a(string A_0, string A_1)
	{
		double result = 0.0;
		double.TryParse(A_0, NumberStyles.Float, CultureInfo.InvariantCulture, out result);
		return a(result, A_1);
	}

	public static int a(int A_0, int A_1)
	{
		if (Screen.AllScreens.GetUpperBound(0) == 0)
		{
			return 0;
		}
		int num = default(int);
		for (; (Screen.AllScreens[num].Bounds.Right < A_0 || Screen.AllScreens[num].Bounds.Left > A_0 || Screen.AllScreens[num].Bounds.Bottom < A_1 || Screen.AllScreens[num].Bounds.Top > A_1) && num < Screen.AllScreens.GetUpperBound(0); num = checked(num + 1))
		{
		}
		return num;
	}

	public static Point a(Rectangle A_0)
	{
		checked
		{
			return new Point(A_0.X + unchecked(A_0.Width / 2), A_0.Y + unchecked(A_0.Height / 2));
		}
	}

	public static Point a(Control A_0)
	{
		Point point = a(A_0, 0, 0);
		checked
		{
			return new Point(point.X + unchecked(A_0.Width / 2), point.Y + unchecked(A_0.Height / 2));
		}
	}

	public static Point a(Control A_0, int A_1, int A_2)
	{
		Point point = ((A_0.Parent != null) ? A_0.Parent.PointToScreen(A_0.Location) : A_0.Location);
		return checked(new Point(point.X + A_1, point.Y + A_2));
	}

	public static void a(Label[] A_0, TextBox[] A_1)
	{
		int num = A_0.Length;
		checked
		{
			int[] array = new int[num - 1 + 1];
			int num2 = int.MinValue;
			int num3 = num - 1;
			int num5 = default(int);
			for (int num4 = 0; num4 <= num3; num4++)
			{
				array[num4] = a(A_1[num4], 0, 0).X - A_0[num4].Width;
				if (array[num4] > num2)
				{
					num2 = array[num4];
					num5 = num4;
				}
			}
			int num6 = num - 1;
			for (int num7 = 0; num7 <= num6; num7++)
			{
				A_0[num7].Width = array[num5] - array[num7];
			}
		}
	}

	public static void a(Point A_0, Form A_1)
	{
		a(A_0, A_1, 0, 0);
	}

	public static void a(Point A_0, Form A_1, int A_2, int A_3)
	{
		Form form = A_1;
		checked
		{
			int num = A_0.X - unchecked(form.Width / 2);
			Rectangle workingArea = Screen.AllScreens[a(A_0.X, A_0.Y)].WorkingArea;
			int num2 = workingArea.Right - 5;
			int num3 = workingArea.Left + 5;
			int num4 = workingArea.Top + 5;
			int num5 = workingArea.Bottom - 5;
			if (num + form.Width > num2)
			{
				num = num2 - form.Width;
			}
			else if (num < 0)
			{
				num = 0;
			}
			if (num < num3)
			{
				num = num3;
			}
			form.Left = num + A_2;
			num = A_0.Y - unchecked(form.Height / 2);
			if (num + form.Height > num5)
			{
				num = num5 - form.Height;
			}
			else if (num < 0)
			{
				num = 0;
			}
			if (num < num4)
			{
				num = num4;
			}
			form.Top = num + A_3;
			form = null;
		}
	}

	public static Point a(Point A_0, Size A_1)
	{
		checked
		{
			int num = A_0.X - unchecked(A_1.Width / 2);
			int right = Screen.AllScreens[a(A_0.X, A_0.Y)].Bounds.Right;
			int left = Screen.AllScreens[a(A_0.X, A_0.Y)].Bounds.Left;
			if (num < left)
			{
				num = left;
			}
			else if (num + A_1.Width > right)
			{
				num = right - A_1.Width;
			}
			int num2 = A_0.Y - unchecked(A_1.Height / 2);
			int bottom = Screen.AllScreens[a(A_0.X, A_0.Y)].Bounds.Bottom;
			int top = Screen.AllScreens[a(A_0.X, A_0.Y)].Bounds.Top;
			if (num2 < top)
			{
				num2 = top;
			}
			else if (num2 + A_1.Height > bottom)
			{
				num2 = bottom - A_1.Height;
			}
			return new Point(num, num2);
		}
	}

	public static void a(IAsyncResult A_0, Control A_1)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		A_1.EndInvoke(A_0);
		stopwatch.Stop();
		if (stopwatch.ElapsedMilliseconds > 0)
		{
			Thread.Sleep(80);
		}
	}
}
