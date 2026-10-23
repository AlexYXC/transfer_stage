using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Filmetrics.FIMatFileSecurityService;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class @do : co
{
	private new IContainer m_a;

	private new string b;

	private new string c;

	public @do()
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

	public void a(string A_0, string A_1, int A_2, string A_3, Point A_4, ref bool A_5)
	{
		FIMatFileSecurity fIMatFileSecurity = new FIMatFileSecurity();
		int num = checked((int)Math.Round((double)DateTime.Now.Ticks / 2500.0 % 2000000000.0));
		e().Text = "Obtaining permission to unencrypt data...";
		Text = "Obtaining View Permission";
		fIMatFileSecurity.RequestDecryptKeyCompleted += a;
		fIMatFileSecurity.RequestDecryptKeyAsync(A_0, A_1, A_2, num, A_3);
		i6.a(A_4, this);
		b = ec.b(A_0: true, A_1, A_2, num);
		f().Start();
		ShowDialog();
		A_5 = Operators.CompareString(c, b, TextCompare: false) == 0;
	}

	private void a(object A_0, RequestDecryptKeyCompletedEventArgs A_1)
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
