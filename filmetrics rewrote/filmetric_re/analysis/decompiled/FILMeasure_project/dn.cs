using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Filmetrics.FIMatFileDBService;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class dn : co
{
	private new IContainer m_a;

	private new FIMatFileDB b;

	private new string c;

	private new eb.b d;

	private new string e;

	private new DateTime f;

	public dn()
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

	public void a(string A_0, eb.b A_1, Point A_2)
	{
		e().Text = "Attempting to update OMDB Folder";
		Text = "Updating from Filmetrics Online Materials Database";
		b = new FIMatFileDB();
		c = A_0;
		d = A_1;
		b.GetServerDateUtcCompleted += a;
		b.GetServerDateUtcAsync(A_0, LicenseLevel.Unlicensed, null);
		f().Start();
		d().Value = 0;
		i6.a(A_2, this);
		ShowDialog();
	}

	private void a(object A_0, GetServerDateUtcCompletedEventArgs A_1)
	{
		try
		{
			string a_ = ea.a(A_1.Result);
			string right = ea.a(c, a_, A_2: true);
			if (Operators.CompareString(A_1.responseKey, right, TextCompare: false) == 0)
			{
				jd.a(c, b, A_1.Result, DateTime.UtcNow, A_1.userDBLicenseLevel, A_5: true, d);
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
