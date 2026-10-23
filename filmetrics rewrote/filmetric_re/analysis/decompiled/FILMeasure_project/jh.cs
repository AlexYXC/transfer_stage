using System;

internal class jh
{
	public const float a = 0.001f;

	public const float b = 1000f;

	public const float c = 1E-06f;

	public const float d = 1000000f;

	public const float e = 60f;

	public static double a(DateTime A_0)
	{
		return DateTime.Now.Subtract(A_0).TotalSeconds;
	}

	public static float a(DateTime A_0, DateTime A_1)
	{
		return (float)A_1.Subtract(A_0).TotalSeconds;
	}

	public static void a(int A_0, int A_1, int A_2, int A_3, ref string A_4, ref string A_5, ref DateTime A_6)
	{
		DateTime now = DateTime.Now;
		checked
		{
			float num = A_1 - A_0;
			DateTime dateTime = now.ToUniversalTime().AddHours(A_2);
			DateTime dateTime2 = dateTime;
			float num2 = A_3;
			while ((double)num2 > 0.1)
			{
				if (dateTime2.DayOfWeek < DayOfWeek.Monday)
				{
					dateTime2 = dateTime2.AddHours((float)new TimeSpan(24, 0, 0).Subtract(dateTime2.TimeOfDay).TotalHours + (float)A_0);
				}
				else if (dateTime2.DayOfWeek <= DayOfWeek.Thursday || (dateTime2.DayOfWeek == DayOfWeek.Friday && dateTime2.TimeOfDay.TotalHours < (double)((float)A_1 - num2)))
				{
					if (dateTime2.TimeOfDay.TotalHours < (double)A_0)
					{
						float num3 = num2;
						if (num3 > num)
						{
							num3 = num;
						}
						dateTime2 = dateTime2.AddHours((float)new TimeSpan(A_0, 0, 0).Subtract(dateTime2.TimeOfDay).TotalHours + num3);
						num2 -= num3;
					}
					else if (dateTime2.TimeOfDay.TotalHours < (double)((float)A_1 - num2))
					{
						dateTime2 = dateTime2.AddHours(num2);
						num2 = 0f;
					}
					else if (dateTime2.TimeOfDay.TotalHours < (double)A_1)
					{
						float num3 = (float)new TimeSpan(A_1, 0, 0).Subtract(dateTime2.TimeOfDay).TotalHours;
						dateTime2 = dateTime2.AddHours(num3);
						num2 -= num3;
					}
					else
					{
						dateTime2 = dateTime2.AddHours((float)new TimeSpan(24, 0, 0).Subtract(dateTime2.TimeOfDay).TotalHours + (float)A_0);
					}
				}
				else if (dateTime2.DayOfWeek == DayOfWeek.Friday)
				{
					if (dateTime2.TimeOfDay.TotalHours < (double)A_1)
					{
						float num3 = (float)new TimeSpan(A_1, 0, 0).Subtract(dateTime2.TimeOfDay).TotalHours;
						dateTime2 = dateTime2.AddHours(num3);
						num2 -= num3;
					}
					else
					{
						dateTime2 = dateTime2.AddHours(48.0);
					}
				}
				else
				{
					dateTime2 = dateTime2.AddHours(24.0);
				}
				if (A_1 - dateTime2.Hour == 1 && dateTime2.Minute == 59 && dateTime2.Second == 59)
				{
					dateTime2 = dateTime2.AddSeconds(1.0);
				}
			}
			A_5 = "You can expect a response by ";
			A_6 = now.AddHours(dateTime2.Subtract(dateTime).TotalHours);
			if (A_6.Second == 59)
			{
				A_6 = A_6.AddSeconds(1.0);
			}
			if (A_6.DayOfWeek != now.DayOfWeek)
			{
				A_4 = "Local date and time when request was sent was " + now.ToString();
				A_5 += A_6.ToString();
			}
			else
			{
				string text = now.TimeOfDay.ToString();
				if (text.Contains("."))
				{
					text = text.Substring(0, text.LastIndexOf("."));
				}
				A_4 = "Local time when request was sent was " + text;
				text = A_6.TimeOfDay.ToString();
				if (text.Contains("."))
				{
					text = text.Substring(0, text.LastIndexOf("."));
				}
				A_5 += text;
			}
			A_4 += ".";
			A_5 += ".";
		}
	}
}
