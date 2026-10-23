using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Filmetrics.FIMatFileDBService;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class dj : co
{
	public new class a
	{
		public DateTime a;

		public int b;

		public eb.a c;

		public string d;

		public DateTime e;

		public string f;

		public a(DateTime A_0, int A_1, eb.a A_2, string A_3, DateTime A_4, string A_5)
		{
			a = A_0;
			b = A_1;
			c = A_2;
			d = A_3;
			e = A_4;
			f = A_5;
		}
	}

	private new IContainer m_a;

	private new FIMatFileDB b;

	private new string c;

	private new eb.b d;

	private new string e;

	private new Collection<a> f;

	private bool g;

	public dj()
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

	public void a(string A_0, eb.b A_1, string A_2, Point A_3, ref LicenseLevel A_4, ref Collection<a> A_5, ref bool A_6)
	{
		e().Text = "Acquiring file history information for " + e + "...";
		Text = "Querying Filmetrics Online Materials Database";
		b = new FIMatFileDB();
		c = A_0;
		d = A_1;
		e = A_2;
		f = null;
		g = false;
		b.GetServerDateUtcCompleted += a;
		b.GetServerDateUtcAsync(A_0, LicenseLevel.Unlicensed, null);
		f().Start();
		d().Value = 0;
		i6.a(A_3, this);
		ShowDialog();
		f().Stop();
		A_6 = g;
		A_5 = f;
	}

	private void a(object A_0, GetServerDateUtcCompletedEventArgs A_1)
	{
		try
		{
			string text = ea.a(A_1.Result);
			string responseKey = null;
			string right = ea.a(c, text, A_2: true);
			if (Operators.CompareString(A_1.responseKey, right, TextCompare: false) == 0 && A_1.userDBLicenseLevel >= LicenseLevel.ReadWrite)
			{
				MatFileDBEvent[] history = b.GetHistory(c, d9.a(d), e, text, ea.a(c, text, ea.a.a, d, e), ref responseKey);
				g = Operators.CompareString(responseKey, right, TextCompare: false) == 0;
				if (g)
				{
					f = new Collection<a>();
					MatFileDBEvent[] array = history;
					for (int num = 0; num < array.Length; num = checked(num + 1))
					{
						MatFileDBEvent matFileDBEvent = array[num];
						f.Add(new a(matFileDBEvent.EventDateUTC.ToLocalTime(), matFileDBEvent.EventID, d9.a(matFileDBEvent.NewLevel), matFileDBEvent.FileExt, matFileDBEvent.FileDataModDateUTC.ToLocalTime(), matFileDBEvent.UserName));
						matFileDBEvent = null;
					}
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
