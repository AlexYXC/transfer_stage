using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class er : Panel
{
	private IContainer a;

	[DebuggerNonUserCode]
	public er(IContainer A_0)
		: this()
	{
		A_0?.Add(this);
	}

	[DebuggerNonUserCode]
	public er()
	{
		b();
		DoubleBuffered = true;
		UpdateStyles();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && a != null)
			{
				a.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void b()
	{
		a = new Container();
	}

	[SpecialName]
	public bool c()
	{
		return DoubleBuffered;
	}

	[SpecialName]
	public void b(bool A_0)
	{
		DoubleBuffered = A_0;
	}
}
