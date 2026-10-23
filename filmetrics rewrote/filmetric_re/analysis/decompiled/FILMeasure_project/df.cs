using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Filmetrics.FIMatFileSecurityService;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class df : co
{
	private new IContainer m_a;

	private new bool b;

	public df()
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
		base.Name = "DialogRequestAddMatToEndUserViewDB";
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public void a(string A_0, int A_1, string A_2, Point A_3, ref bool A_4)
	{
		FIMatFileSecurity fIMatFileSecurity = new FIMatFileSecurity();
		int num = checked((int)Math.Round((double)DateTime.Now.Ticks / 2500.0 % 2000000000.0));
		string executionKey = ec.a(num);
		e().Text = "Requesting addition of file to database...";
		Text = "Add File to End-User Viewable Database";
		fIMatFileSecurity.RequestAddViewableMatFileCompleted += a;
		fIMatFileSecurity.RequestAddViewableMatFileAsync(A_0, A_1, A_2, num, executionKey);
		i6.a(A_3, this);
		f().Start();
		ShowDialog();
		A_4 = b;
	}

	private void a(object A_0, RequestAddViewableMatFileCompletedEventArgs A_1)
	{
		try
		{
			b = A_1.Result;
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
