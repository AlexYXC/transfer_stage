using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Filmetrics.FIMatFileDBService;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class dm : co
{
	private new IContainer m_a;

	private new FIMatFileDB b;

	private new string c;

	private new eb.a d;

	private new eb.a e;

	private new eb.b f;

	private string g;

	private new bool h;

	public dm()
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

	public void a(string A_0, eb.b A_1, string A_2, eb.a A_3, eb.a A_4, Point A_5, ref bool A_6)
	{
		e().Text = "Attempting to update database...";
		Text = "Updating Filmetrics Online Materials Database";
		b = new FIMatFileDB();
		c = A_0;
		f = A_1;
		g = A_2;
		d = A_4;
		e = A_3;
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
			string right = ea.a(c, text, A_2: true);
			if (Operators.CompareString(A_1.responseKey, right, TextCompare: false) == 0 && A_1.userDBLicenseLevel >= LicenseLevel.ReadWrite && (e != eb.a.f || A_1.userDBLicenseLevel >= LicenseLevel.ShippingReadWrite))
			{
				string left = b.ChangeReleaseLevel(c, text, ea.a(c, text, ea.a.f, f, g), d9.a(f), g, d9.a(d));
				h = Operators.CompareString(left, right, TextCompare: false) == 0;
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
