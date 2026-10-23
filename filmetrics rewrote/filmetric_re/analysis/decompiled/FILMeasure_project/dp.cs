using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Filmetrics.FIMatFileSecurityService;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class dp : co
{
	private new IContainer m_a;

	private new string b;

	private new string c;

	private new fz d;

	public dp()
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
		base.Name = "DialogRequestMatViewKey";
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public void a(string A_0, string A_1, int A_2, string A_3, Point A_4, string A_5, fz A_6, ref bool A_7)
	{
		try
		{
			FIMatFileSecurity fIMatFileSecurity = new FIMatFileSecurity();
			int num = checked((int)Math.Round((double)DateTime.Now.Ticks / 2500.0 % 2000000000.0));
			d = A_6;
			e().Text = A_5;
			Text = "Obtaining View Permission";
			fIMatFileSecurity.RequestViewKeyCompleted += a;
			try
			{
				fIMatFileSecurity.RequestViewKeyAsync(A_0, A_1, A_2, num, A_3);
				i6.a(A_4, this);
				b = ec.c(A_0: true, A_1, A_2, num);
				f().Start();
				ShowDialog();
			}
			catch (TargetInvocationException ex2)
			{
				ProjectData.SetProjectError(ex2);
				TargetInvocationException ex3 = ex2;
				base.DialogResult = DialogResult.Cancel;
				ProjectData.ClearProjectError();
			}
			A_7 = Operators.CompareString(c, b, TextCompare: false) == 0;
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception a_ = ex4;
			d.c(fz.b.a, "Error in DialogRequestMatViewKey.InitAndShow - this error may mean that computer is having a problem using a web service", a_);
			A_7 = false;
			base.DialogResult = DialogResult.Cancel;
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, RequestViewKeyCompletedEventArgs A_1)
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
			if (!h)
			{
				d.c(fz.b.b, "Exception caught in DialogRequestMatViewKey.RequestViewKeyCompleted");
			}
			ProjectData.ClearProjectError();
		}
	}
}
