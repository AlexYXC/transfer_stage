using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Filmetrics.FIMatFileDBService;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class dk : co
{
	private new IContainer m_a;

	private new FIMatFileDB m_b;

	private new string c;

	private new eb.b d;

	private new string e;

	private new LicenseLevel f;

	private eb.a g;

	private new bool h;

	private bool i;

	private bool j;

	[CompilerGenerated]
	private Timer k;

	private fz l;

	public dk()
	{
		a(new Timer());
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

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer b()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Timer A_0)
	{
		EventHandler value = a;
		Timer timer = k;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		k = A_0;
		timer = k;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	public void a(string A_0, eb.b A_1, string A_2, Point A_3, ref LicenseLevel A_4, ref eb.a A_5, ref bool A_6, ref bool A_7, ref bool A_8, fz A_9)
	{
		bool A_10 = false;
		a(A_0, A_1, A_2, -1, A_3, "", ref A_4, ref A_5, ref A_6, ref A_7, ref A_8, ref A_10, A_9);
	}

	public void a(string A_0, eb.b A_1, string A_2, int A_3, Point A_4, string A_5, ref LicenseLevel A_6, ref eb.a A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, fz A_12)
	{
		if (!string.IsNullOrEmpty(A_5))
		{
			e().Text = A_5;
		}
		else
		{
			e().Text = "Attempting to acquire information about " + e + "...";
		}
		Text = "Querying Filmetrics Online Materials Database";
		this.m_b = new FIMatFileDB();
		c = A_0;
		d = A_1;
		e = A_2;
		g = eb.a.a;
		f = LicenseLevel.Unlicensed;
		i = false;
		h = false;
		A_10 = false;
		j = false;
		l = A_12;
		this.m_b.GetServerDateUtcCompleted += a;
		try
		{
			this.m_b.GetServerDateUtcAsync(A_0, LicenseLevel.Unlicensed, null);
			f().Start();
			if (A_3 > 0)
			{
				b().Interval = A_3;
				b().Start();
			}
			i6.a(A_4, this);
			d().Value = 0;
			ShowDialog();
		}
		catch (TargetInvocationException ex2)
		{
			ProjectData.SetProjectError(ex2);
			TargetInvocationException ex3 = ex2;
			A_10 = true;
			ProjectData.ClearProjectError();
		}
		b().Stop();
		A_7 = g;
		A_9 = i;
		A_8 = h;
		A_6 = f;
		A_11 = j;
	}

	private void a(object A_0, GetServerDateUtcCompletedEventArgs A_1)
	{
		try
		{
			string text = ea.a(A_1.Result);
			string responseKey = null;
			string right = ea.a(c, text, A_2: true);
			if (Operators.CompareString(A_1.responseKey, right, TextCompare: false) == 0 && A_1.userDBLicenseLevel > LicenseLevel.Unlicensed)
			{
				f = A_1.userDBLicenseLevel;
				ReleaseLevel releaseLevel = this.m_b.GetReleaseLevel(c, text, ea.a(c, text, ea.a.c, d, e), d9.a(d), e, ref i, ref responseKey);
				g = d9.a(releaseLevel);
				h = Operators.CompareString(responseKey, right, TextCompare: false) == 0;
			}
			base.DialogResult = DialogResult.OK;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			if (!base.h)
			{
				l.c(fz.b.b, "Exception caught in DialogRequestMatViewKey.RequestViewKeyCompleted");
			}
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		j = true;
		base.DialogResult = DialogResult.Cancel;
	}
}
