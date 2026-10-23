using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Filmetrics.FIMatFileDBService;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class dh : co
{
	private new IContainer m_a;

	private new FIMatFileDB b;

	private new string c;

	private new eb.b d;

	private new string e;

	private new bool f;

	public dh()
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

	public void a(string A_0, eb.b A_1, string A_2, Point A_3, ref bool A_4)
	{
		e().Text = "Attempting to update database...";
		Text = "Updating Filmetrics Online Materials Database";
		b = new FIMatFileDB();
		c = A_0;
		e = A_2;
		d = A_1;
		f = false;
		b.GetServerDateUtcCompleted += a;
		b.GetServerDateUtcAsync(A_0, LicenseLevel.Unlicensed, null);
		f().Start();
		i6.a(A_3, this);
		d().Value = 0;
		ShowDialog();
		f().Stop();
		A_4 = f;
	}

	private void a(object A_0, GetServerDateUtcCompletedEventArgs A_1)
	{
		try
		{
			string text = ea.a(A_1.Result);
			string text2 = null;
			string right = ea.a(c, text, A_2: true);
			if (Operators.CompareString(A_1.responseKey, right, TextCompare: false) == 0 && A_1.userDBLicenseLevel >= LicenseLevel.ReadWriteAdmin)
			{
				text2 = b.DestroyFile(c, text, ea.a(c, text, ea.a.g, d, e), d9.a(d), e);
				jb.a(string.Concat(jb.h() + "\\" + e, jb.d(d)[0]), d);
				f = Operators.CompareString(text2, right, TextCompare: false) == 0;
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
