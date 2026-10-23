using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

internal class e9 : IDisposable
{
	private fz m_a;

	[CompilerGenerated]
	private Timer m_b;

	private e8 m_c;

	private bool d;

	[SpecialName]
	[CompilerGenerated]
	private virtual Timer a()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(Timer A_0)
	{
		EventHandler value = a;
		Timer timer = this.m_b;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		this.m_b = A_0;
		timer = this.m_b;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	public e9(fz A_0)
	{
		a(new Timer());
		d = false;
		this.m_a = A_0;
		a().Interval = 300000;
		_ = null;
	}

	public void b()
	{
		a(A_0: true);
		GC.SuppressFinalize(this);
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in b
		this.b();
	}

	private void a(bool A_0)
	{
		if (!d)
		{
			if (A_0)
			{
				a().Dispose();
			}
			d = true;
		}
	}

	~e9()
	{
		a(A_0: false);
		base.Finalize();
	}

	public void a(f1 A_0, gq A_1, Guid A_2, hg A_3, bool A_4, string A_5, gr A_6, ge A_7, f4 A_8, bool A_9, e8.a A_10, bool A_11, e8.f A_12)
	{
		a(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, A_10, A_11, e8.e.a, A_12);
	}

	public void a(f1 A_0, gq A_1, Guid A_2, hg A_3, bool A_4, string A_5, gr A_6, ge A_7, f4 A_8, bool A_9, e8.a A_10, bool A_11, e8.e A_12, e8.f A_13)
	{
		if (this.m_c == null)
		{
			this.m_c = new e8(this.m_a);
		}
		a().Stop();
		e8.d A_14 = default(e8.d);
		A_14.a = e.a().EditRecipeOutlineCompositionIsCollapsed;
		A_14.b = e.a().EditRecipeOutlineThicknessIsCollapsed;
		A_14.c = e.a().EditRecipeOutlineNonuniformityIsCollapsed;
		this.m_c.a(A_3, A_4, A_6, A_5, A_0, A_1, A_8, A_2, A_7, ref A_14, A_9, A_10, A_11, A_12, A_13);
		e.a().EditRecipeOutlineCompositionIsCollapsed = A_14.a;
		e.a().EditRecipeOutlineThicknessIsCollapsed = A_14.b;
		e.a().EditRecipeOutlineNonuniformityIsCollapsed = A_14.c;
		a().Start();
	}

	public void a(f1 A_0, gq A_1, Guid A_2, bool A_3, string A_4, gr A_5, ge A_6, f4 A_7, e8.a A_8, bool A_9, e8.f A_10)
	{
		hg hg2 = A_0.wq(A_2);
		if (A_0.ws(A_2))
		{
			he a_ = A_0.wr(A_2);
			using ct ct2 = new ct(this.m_a);
			ct2.a(a_, hg2.c1(), A_4, A_0, A_7, A_5, A_6, A_8.h());
			return;
		}
		a(A_0, A_1, A_2, hg2, A_3, A_4, A_5, A_6, A_7, A_9: false, A_8, A_9, A_10);
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			a().Stop();
			c();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_a.c(fz.b.b, "Exception caught in EditRecipeHelper.mEditRecipeDispose_Elapsed", a_);
			ProjectData.ClearProjectError();
		}
	}

	public void c()
	{
		this.m_c.Dispose();
		this.m_c = null;
	}
}
