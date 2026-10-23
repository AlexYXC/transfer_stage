using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Filmetrics.FIMatFileDBService;

internal class d9
{
	private const string m_a = "FileStatus";

	public const string b = ".fibfs";

	private const int c = 1;

	public static eb.a a(ReleaseLevel A_0)
	{
		return A_0 switch
		{
			ReleaseLevel.Local => eb.a.a, 
			ReleaseLevel.Unreleased => eb.a.b, 
			ReleaseLevel.Customer => eb.a.c, 
			ReleaseLevel.Released => eb.a.d, 
			ReleaseLevel.Shipping => eb.a.f, 
			ReleaseLevel.Deleted => eb.a.g, 
			_ => throw new ApplicationException("Unknown ReleaseLevel"), 
		};
	}

	public static ReleaseLevel a(eb.a A_0)
	{
		return A_0 switch
		{
			eb.a.a => ReleaseLevel.Local, 
			eb.a.b => ReleaseLevel.Unreleased, 
			eb.a.c => ReleaseLevel.Customer, 
			eb.a.d => ReleaseLevel.Released, 
			eb.a.f => ReleaseLevel.Shipping, 
			eb.a.g => ReleaseLevel.Deleted, 
			_ => throw new ApplicationException("Unknown ReleaseLevel"), 
		};
	}

	public static FileType a(eb.b A_0)
	{
		FileType fileType = default(FileType);
		return A_0 switch
		{
			eb.b.a => FileType.NK, 
			eb.b.b => FileType.RRR, 
			eb.b.c => FileType.TTT, 
			_ => fileType, 
		};
	}

	public static bool a(fz A_0, string A_1, Point A_2, ref LicenseLevel A_3)
	{
		dk dk2 = new dk();
		eb.a A_4 = eb.a.a;
		bool A_5 = false;
		bool A_6 = default(bool);
		bool A_7 = default(bool);
		bool A_8 = default(bool);
		dk2.a(A_1, eb.b.a, "", 10000, A_2, "Validating Filmetrics Online Material Database communications...", ref A_3, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8, A_0);
		if (!A_6 && (A_7 || A_8 || dk2.DialogResult != DialogResult.Cancel))
		{
			fe.b(A_0, "Communications failure - no Internet access to Filmetrics Online Material Database Service. \r\nAccess to files in the database will be on a ReadOnly basis.", "Information", A_2);
		}
		else if (!A_6)
		{
			fe.b(A_0, "Access to Filmetrics Online Material Database cancelled by user. \r\nAccess to files in the database will be on a ReadOnly basis.", "Information", A_2);
		}
		return A_6;
	}

	public static void a(eb.b A_0, ref DateTime A_1, ref DateTime A_2)
	{
		LicenseLevel A_3 = LicenseLevel.Unlicensed;
		Collection<eb.c> A_4 = null;
		a(A_0: true, A_0, ref A_1, ref A_2, ref A_3, ref A_4);
	}

	public static void a(eb.b A_0, ref DateTime A_1, ref DateTime A_2, ref LicenseLevel A_3, ref Collection<eb.c> A_4)
	{
		a(A_0: false, A_0, ref A_1, ref A_2, ref A_3, ref A_4);
	}

	private static void a(bool A_0, eb.b A_1, ref DateTime A_2, ref DateTime A_3, ref LicenseLevel A_4, ref Collection<eb.c> A_5)
	{
		BinaryReader binaryReader = null;
		string path = jb.k()[0] + "\\FileStatus" + eb.a(A_1) + ".fibfs";
		A_5 = new Collection<eb.c>();
		if (!File.Exists(path))
		{
			return;
		}
		try
		{
			binaryReader = new BinaryReader(File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read));
			binaryReader.ReadInt32();
			if (binaryReader.ReadInt32() > 1)
			{
				throw new ApplicationException("Unreadable file format in FIMatFileDBServiceHelper.GetDBFilesStatus");
			}
			A_2 = DateTime.FromBinary(binaryReader.ReadInt64());
			A_3 = DateTime.FromBinary(binaryReader.ReadInt64());
			A_4 = (LicenseLevel)binaryReader.ReadInt32();
			if (!A_0)
			{
				int num = checked(binaryReader.ReadInt32() - 1);
				for (int num2 = 0; num2 <= num; num2 = checked(num2 + 1))
				{
					A_5.Add(new eb.c(binaryReader.ReadString(), binaryReader.ReadString(), (eb.a)binaryReader.ReadByte()));
				}
			}
		}
		finally
		{
			binaryReader?.Close();
		}
	}

	public static eb.a a(Collection<eb.c> A_0, string A_1)
	{
		foreach (eb.c item in A_0)
		{
			if (string.Compare(item.a, A_1, ignoreCase: true) == 0)
			{
				return item.c;
			}
			eb.c current = null;
		}
		return eb.a.a;
	}

	public static void a(eb.b A_0, DateTime A_1, DateTime A_2, LicenseLevel A_3, FileData[] A_4)
	{
		BinaryWriter binaryWriter = null;
		string path = jb.h() + "\\FileStatus" + eb.a(A_0) + ".fibfs";
		try
		{
			if (A_4 == null || A_4.Length == 0)
			{
				if (File.Exists(path))
				{
					File.Delete(path);
				}
				return;
			}
			binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create, FileAccess.ReadWrite));
			binaryWriter.Write(1);
			binaryWriter.Write(1);
			binaryWriter.Write(A_1.ToBinary());
			binaryWriter.Write(A_2.ToBinary());
			binaryWriter.Write((int)A_3);
			binaryWriter.Write(A_4.Length);
			foreach (FileData fileData in A_4)
			{
				binaryWriter.Write(fileData.MatName);
				binaryWriter.Write(fileData.MatExt);
				binaryWriter.Write((byte)a(fileData.MatReleaseLevel));
			}
		}
		finally
		{
			binaryWriter?.Close();
		}
	}
}
