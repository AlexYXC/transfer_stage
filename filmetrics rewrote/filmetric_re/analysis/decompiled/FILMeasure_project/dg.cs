using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Filmetrics.FIMatFileSecurityService;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class dg : co
{
	private new IContainer m_a;

	private new string b;

	private new string c;

	public dg()
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
		base.Name = "DialogRequestEndUserViewKey";
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public void a(string A_0, string A_1, string A_2, string A_3, string A_4, int A_5, string A_6, Point A_7, string A_8, ref bool A_9)
	{
		try
		{
			A_9 = false;
			FIMatFileSecurity fIMatFileSecurity = new FIMatFileSecurity();
			int num = checked((int)Math.Round((double)DateTime.Now.Ticks / 2500.0 % 2000000000.0));
			e().Text = A_8;
			Text = "Obtain View Permission";
			fIMatFileSecurity.RequestEndUserViewKeyCompleted += a;
			fIMatFileSecurity.RequestEndUserViewKeyAsync(A_0, A_1, A_2, A_3, A_4, A_5, num, A_6);
			string left = ec.a(A_0: true, A_4, A_5, num);
			i6.a(A_7, this);
			f().Start();
			ShowDialog();
			string[] array = c.Split('.');
			string a_ = array[0];
			string right = array[1];
			int A_10 = default(int);
			string left2 = i7.c(a_, i7.e.l, ref A_10);
			string right2 = i7.c(a_, A_10);
			A_9 = Operators.CompareString(left2, right2, TextCompare: false) == 0 && Operators.CompareString(left, right, TextCompare: false) == 0;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, RequestEndUserViewKeyCompletedEventArgs A_1)
	{
		try
		{
			c = A_1.Result;
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
