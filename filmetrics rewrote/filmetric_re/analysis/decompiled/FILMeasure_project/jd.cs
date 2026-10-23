using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Filmetrics.FIMatFileDBService;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

internal class jd
{
	public class a
	{
		public fz a;

		public string b;

		public a(fz A_0, string A_1)
		{
			a = A_0;
			b = A_1;
		}
	}

	public const string a = "Deleted Local Files";

	[SpecialName]
	public static string a()
	{
		return jb.d() + "\\Deleted Local Files";
	}

	public static void a(object A_0)
	{
		bool a_ = false;
		string responseKey = null;
		a obj = (a)A_0;
		string text = obj.b;
		_ = obj.a;
		_ = null;
		LicenseLevel userDBLicenseLevel = default(LicenseLevel);
		while (true)
		{
			try
			{
				FIMatFileDB fIMatFileDB = new FIMatFileDB();
				DateTime serverDateUtc = fIMatFileDB.GetServerDateUtc(text, ref userDBLicenseLevel, ref responseKey);
				string right = ea.a(text, ea.a(serverDateUtc), A_2: true);
				if (Operators.CompareString(responseKey, right, TextCompare: false) == 0)
				{
					DateTime utcNow = DateTime.UtcNow;
					a(text, fIMatFileDB, serverDateUtc, utcNow, userDBLicenseLevel, a_, eb.b.a);
					a(text, fIMatFileDB, serverDateUtc, utcNow, userDBLicenseLevel, a_, eb.b.b);
					a(text, fIMatFileDB, serverDateUtc, utcNow, userDBLicenseLevel, a_, eb.b.c);
					a_ = true;
					fIMatFileDB = null;
				}
				Thread.Sleep(216000000);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void a(string A_0, FIMatFileDB A_1, DateTime A_2, DateTime A_3, LicenseLevel A_4, bool A_5, eb.b A_6)
	{
		string fileNameWithExt = "";
		byte[] fileContents = null;
		string text = jb.h() + "\\";
		Collection<string> A_7 = null;
		string text2 = "";
		Collection<string> collection = new Collection<string>();
		string text3 = jb.d() + "\\";
		FileData[] fileData = null;
		string text4 = ea.a(A_2.Add(DateTime.UtcNow.Subtract(A_3)));
		string right = ea.a(A_0, text4, A_2: true);
		DateTime lastIncrementalModUtc = default(DateTime);
		DateTime lastNonIncrementalModUtc = default(DateTime);
		if (Operators.CompareString(A_1.GetSummary(A_0, text4, ea.a(A_0, text4, ea.a.b, A_6), d9.a(A_6), ref lastIncrementalModUtc, ref lastNonIncrementalModUtc, ref fileData), right, TextCompare: false) != 0)
		{
			return;
		}
		string text5 = text3 + "Deleted Local Files";
		if (!Directory.Exists(text5))
		{
			Directory.CreateDirectory(text5);
		}
		DateTime refDateUtc = new DateTime(1990, 1, 1);
		if (A_5)
		{
			DateTime A_8 = default(DateTime);
			DateTime A_9 = default(DateTime);
			d9.a(A_6, ref A_8, ref A_9);
			if (DateTime.Compare(lastNonIncrementalModUtc, A_9) > 0)
			{
				A_5 = false;
			}
			else
			{
				refDateUtc = A_8;
			}
		}
		if (!A_5)
		{
			ReadOnlyCollection<string> files = c.e().FileSystem.GetFiles(text, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, jb.c(A_6));
			foreach (string item in files)
			{
				collection.Add(Path.GetFileName(item));
			}
		}
		FileModData[] updatedFilesInfo = A_1.GetUpdatedFilesInfo(A_0, refDateUtc, text4, ea.a(A_0, text4, ea.a.d, A_6), d9.a(A_6));
		eb.a a10 = default(eb.a);
		ReleaseLevel fileReleaseLevel = default(ReleaseLevel);
		DateTime fileDataModDateUtc = default(DateTime);
		foreach (FileModData fileModData in updatedFilesInfo)
		{
			bool flag = false;
			FileData[] array = fileData;
			for (int num2 = 0; num2 < array.Length; num2 = checked(num2 + 1))
			{
				FileData fileData2 = array[num2];
				if (string.Compare(fileData2.MatName, fileModData.MatName, ignoreCase: true) == 0)
				{
					a10 = d9.a(fileData2.MatReleaseLevel);
					text2 = fileData2.MatExt;
					flag = true;
					break;
				}
				fileData2 = null;
			}
			if (!flag || (a10 != eb.a.f && a10 != eb.a.g && A_4 < LicenseLevel.ReadOnly))
			{
				continue;
			}
			string text6 = fileModData.MatName + text2;
			if (a10 == eb.a.g)
			{
				if (A_5 && File.Exists(text + text6))
				{
					File.Delete(text + text6);
				}
				continue;
			}
			bool flag2 = false;
			bool flag3 = true;
			if (i3.a(text + text6, jb.d(A_6), ref A_7))
			{
				foreach (string item2 in A_7)
				{
					if (string.Compare(item2, text6, ignoreCase: true) == 0)
					{
						flag3 = i3.a(File.GetLastWriteTimeUtc(text + text6), fileModData.FileModDateUtc);
						flag2 = true;
						break;
					}
				}
			}
			if (flag3)
			{
				text4 = ea.a(A_2.Add(DateTime.UtcNow.Subtract(A_3)));
				A_1.GetNewestMatFile(A_0, text4, ea.a(A_0, text4, ea.a.i, A_6, fileModData.MatName), d9.a(A_6), fileModData.MatName, ref fileNameWithExt, ref fileReleaseLevel, ref fileDataModDateUtc, ref fileContents);
				File.WriteAllBytes(text + fileNameWithExt, fileContents);
				File.SetLastWriteTimeUtc(text + fileNameWithExt, fileDataModDateUtc);
			}
			if (flag2 && !A_5)
			{
				collection.Remove(text6);
			}
			if (a10 != eb.a.g)
			{
				jb.a(text3 + text6, A_6, text5);
			}
		}
		foreach (string item3 in collection)
		{
			File.Delete(text + item3);
		}
		d9.a(A_6, lastIncrementalModUtc, lastNonIncrementalModUtc, A_4, fileData);
	}
}
