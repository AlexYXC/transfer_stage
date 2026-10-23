using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Filmetrics.FIMatFileDBService;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class di : co
{
	private new IContainer m_a;

	private new FIMatFileDB b;

	private new string c;

	private new eb.b d;

	private new string e;

	private new string f;

	private int g;

	private new bool h;

	public di()
	{
		a();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.m_a != null)
			{
				this.m_a.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void a()
	{
		this.m_a = new Container();
		SuspendLayout();
		base.Name = "DialogMatDBRequestFileSave";
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public void a(string A_0, eb.b A_1, string A_2, int A_3, string A_4, Point A_5, ref bool A_6)
	{
		e().Text = "Attempting to update database...";
		Text = "Updating Filmetrics Online Materials Database";
		b = new FIMatFileDB();
		c = A_0;
		e = A_2;
		g = A_3;
		d = A_1;
		f = A_4;
		h = false;
		b.GetServerDateUtcCompleted += a;
		b.GetServerDateUtcAsync(A_0, LicenseLevel.Unlicensed, null);
		f().Start();
		i6.a(A_5, this);
		d().Value = 0;
		ShowDialog();
		f().Stop();
		A_6 = h;
	}

	private void a(object A_0, GetServerDateUtcCompletedEventArgs A_1)
	{
		try
		{
			string text = ea.a(A_1.Result);
			string fileNameWithExt = null;
			byte[] fileContents = null;
			string right = ea.a(c, text, A_2: true);
			if (Operators.CompareString(A_1.responseKey, right, TextCompare: false) == 0 && A_1.userDBLicenseLevel >= LicenseLevel.ReadWrite)
			{
				FIMatFileDB fIMatFileDB = b;
				string userName = c;
				string executionKey = ea.a(c, text, ea.a.j, d, e);
				FileType fileType = d9.a(d);
				string matName = e;
				int oldFileEventID = g;
				ReleaseLevel fileReleaseLevel = ReleaseLevel.Local;
				DateTime fileDataModDateUtc = default(DateTime);
				fIMatFileDB.GetMatFile(userName, text, executionKey, fileType, matName, getLatestFile: false, oldFileEventID, ref fileNameWithExt, ref fileReleaseLevel, ref fileDataModDateUtc, ref fileContents);
				if (string.Compare(Path.GetExtension(fileNameWithExt), Path.GetExtension(f), ignoreCase: true) == 0)
				{
					jb.a(f, d);
					File.WriteAllBytes(f, fileContents);
					File.SetLastWriteTimeUtc(f, fileDataModDateUtc);
					h = true;
				}
			}
			base.DialogResult = DialogResult.OK;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			base.DialogResult = DialogResult.Cancel;
			ProjectData.ClearProjectError();
		}
	}
}
