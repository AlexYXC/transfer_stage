using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Filmetrics.FIUserRegistrationService;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class dq : co
{
	private new IContainer m_a;

	private new bool b;

	public dq()
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
		base.AutoScaleMode = AutoScaleMode.Font;
		Text = "DialogRequestRegistration";
	}

	public void a(string A_0, string A_1, string A_2, string A_3, string A_4, string A_5, string A_6, Point A_7, ref bool A_8)
	{
		try
		{
			FIUserRegistration fIUserRegistration = new FIUserRegistration();
			string theKey = eh.a(A_0: true, A_0 + A_1 + A_2 + A_3 + A_4 + A_5);
			e().Text = "Attempting to register software...";
			Text = "Registering Software";
			fIUserRegistration.RegisterUserCompleted += a;
			fIUserRegistration.RegisterUserAsync(A_0, A_1, A_2, A_3, A_4, A_5, A_6, theKey);
			i6.a(A_7, this);
			f().Start();
			ShowDialog();
			A_8 = b;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	public void a(object A_0, RegisterUserCompletedEventArgs A_1)
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
