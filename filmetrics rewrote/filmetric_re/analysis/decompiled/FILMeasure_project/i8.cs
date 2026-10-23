using System.Drawing;

internal class i8
{
	private static void a(string[] A_0, ref string A_1, ref string A_2)
	{
		checked
		{
			int num = A_0.Length - 2;
			A_1 = A_0[0];
			int num2 = num;
			for (int num3 = 1; num3 <= num2; num3++)
			{
				A_1 = A_1 + ", " + A_0[num3];
			}
			if (num > 0)
			{
				A_1 += ", ";
			}
			A_2 = A_0[num + 1];
		}
	}

	public static void b(string[] A_0, fz A_1, Point A_2)
	{
		string A_3;
		if (A_0.Length == 1)
		{
			A_3 = "ImportLicenseDuplicateCompletionFmt";
			fe.b(A_1, string.Format(hu.a(ref A_3), A_0[0]), "Information", A_2);
			return;
		}
		string A_4 = null;
		string A_5 = null;
		a(A_0, ref A_4, ref A_5);
		A_3 = "ImportLicenseManyDuplicatesCompletionFmt2";
		fe.b(A_1, string.Format(hu.a(ref A_3), A_4, A_5), "Information", A_2);
	}

	public static void a(string[] A_0, fz A_1, Point A_2)
	{
		string A_3;
		if (A_0.Length == 1)
		{
			A_3 = "ImportLicenseCompletionPromptFmt2";
			fe.b(A_1, string.Format(hu.a(ref A_3), A_0[0], c.d().Info.Title), "Information", A_2);
			return;
		}
		string A_4 = null;
		string A_5 = null;
		a(A_0, ref A_4, ref A_5);
		A_3 = "ImportLicenseMultCompletionPromptFmt3";
		fe.b(A_1, string.Format(hu.a(ref A_3), A_4, A_5, c.d().Info.Title), "Information", A_2);
	}
}
