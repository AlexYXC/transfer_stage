using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Filmetrics.FIMatFileDBService;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class dl : co
{
	private new IContainer m_a;

	private new FIMatFileDB b;

	private new string c;

	private new eb.a d;

	private new eb.b e;

	private new string f;

	private bool g;

	public dl()
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

	public void a(string A_0, eb.b A_1, string A_2, eb.a A_3, Point A_4, ref bool A_5)
	{
		e().Text = "Attempting to update database...";
		Text = "Updating Filmetrics Online Materials Database";
		b = new FIMatFileDB();
		c = A_0;
		d = A_3;
		e = A_1;
		f = A_2;
		g = false;
		b.GetServerDateUtcCompleted += a;
		b.GetServerDateUtcAsync(A_0, LicenseLevel.Unlicensed, null);
		f().Start();
		i6.a(A_4, this);
		d().Value = 0;
		ShowDialog();
		A_5 = g;
	}

	private void a(object A_0, GetServerDateUtcCompletedEventArgs A_1)
	{
		try
		{
			string text = ea.a(A_1.Result);
			string fileName = Path.GetFileName(f);
			byte[] fileContents = File.ReadAllBytes(f);
			string responseKey = null;
			string right = ea.a(c, text, A_2: true);
			if (Operators.CompareString(A_1.responseKey, right, TextCompare: false) == 0 && A_1.userDBLicenseLevel >= LicenseLevel.ReadWrite)
			{
				DateTime officialDataModDateUtc = default(DateTime);
				b.UpdateMatFile(c, text, ea.a(c, text, ea.a.h, e, fileName), d9.a(e), fileName, d9.a(d), fileContents, ref officialDataModDateUtc, ref responseKey);
				File.SetLastWriteTimeUtc(f, officialDataModDateUtc);
				g = Operators.CompareString(responseKey, right, TextCompare: false) == 0;
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
