using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class i1
{
	[CompilerGenerated]
	private static ContextMenuStrip m_a;

	[CompilerGenerated]
	private static ToolStripMenuItem m_b;

	[CompilerGenerated]
	private static ToolStripMenuItem m_c;

	[CompilerGenerated]
	private static ToolStripMenuItem m_d;

	[CompilerGenerated]
	private static ToolStripMenuItem m_e;

	[CompilerGenerated]
	private static ToolStripMenuItem m_f;

	[CompilerGenerated]
	private static ToolStripMenuItem m_g;

	static i1()
	{
		string A_ = "UndoStr";
		f(new ToolStripMenuItem(hu.a(ref A_)));
		A_ = "CutStr";
		e(new ToolStripMenuItem(hu.a(ref A_)));
		A_ = "CopyStr";
		d(new ToolStripMenuItem(hu.a(ref A_)));
		A_ = "PasteStr";
		c(new ToolStripMenuItem(hu.a(ref A_)));
		A_ = "DeleteStr";
		b(new ToolStripMenuItem(hu.a(ref A_)));
		A_ = "SelectAllStr";
		a(new ToolStripMenuItem(hu.a(ref A_)));
	}

	[SpecialName]
	[CompilerGenerated]
	private static ContextMenuStrip i()
	{
		return i1.m_a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private static void a(ContextMenuStrip A_0)
	{
		ToolStripDropDownClosingEventHandler value = a;
		CancelEventHandler value2 = a;
		ContextMenuStrip contextMenuStrip = i1.m_a;
		if (contextMenuStrip != null)
		{
			contextMenuStrip.Closing -= value;
			contextMenuStrip.Opening -= value2;
		}
		i1.m_a = A_0;
		contextMenuStrip = i1.m_a;
		if (contextMenuStrip != null)
		{
			contextMenuStrip.Closing += value;
			contextMenuStrip.Opening += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private static ToolStripMenuItem h()
	{
		return i1.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private static void f(ToolStripMenuItem A_0)
	{
		EventHandler value = f;
		ToolStripMenuItem toolStripMenuItem = i1.m_b;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		i1.m_b = A_0;
		toolStripMenuItem = i1.m_b;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private static ToolStripMenuItem g()
	{
		return i1.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private static void e(ToolStripMenuItem A_0)
	{
		EventHandler value = e;
		ToolStripMenuItem toolStripMenuItem = i1.m_c;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		i1.m_c = A_0;
		toolStripMenuItem = i1.m_c;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private static ToolStripMenuItem f()
	{
		return i1.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private static void d(ToolStripMenuItem A_0)
	{
		EventHandler value = d;
		ToolStripMenuItem toolStripMenuItem = i1.m_d;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		i1.m_d = A_0;
		toolStripMenuItem = i1.m_d;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private static ToolStripMenuItem e()
	{
		return i1.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private static void c(ToolStripMenuItem A_0)
	{
		EventHandler value = c;
		ToolStripMenuItem toolStripMenuItem = i1.m_e;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		i1.m_e = A_0;
		toolStripMenuItem = i1.m_e;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private static ToolStripMenuItem d()
	{
		return i1.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private static void b(ToolStripMenuItem A_0)
	{
		EventHandler value = b;
		ToolStripMenuItem toolStripMenuItem = i1.m_f;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		i1.m_f = A_0;
		toolStripMenuItem = i1.m_f;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private static ToolStripMenuItem c()
	{
		return i1.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private static void a(ToolStripMenuItem A_0)
	{
		EventHandler value = a;
		ToolStripMenuItem toolStripMenuItem = i1.m_g;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		i1.m_g = A_0;
		toolStripMenuItem = i1.m_g;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	public static void a(i2 A_0)
	{
		if (i() == null || i().IsDisposed)
		{
			a(new ContextMenuStrip());
			ToolStripMenuItem toolStripMenuItem = h();
			string A_1 = "Undo";
			toolStripMenuItem.Image = hv.a(ref A_1);
			ToolStripMenuItem toolStripMenuItem2 = g();
			A_1 = "Cut";
			toolStripMenuItem2.Image = hv.a(ref A_1);
			ToolStripMenuItem toolStripMenuItem3 = f();
			A_1 = "Copy";
			toolStripMenuItem3.Image = hv.a(ref A_1);
			ToolStripMenuItem toolStripMenuItem4 = e();
			A_1 = "Paste";
			toolStripMenuItem4.Image = hv.a(ref A_1);
			ToolStripMenuItem toolStripMenuItem5 = d();
			A_1 = "DeleteMono";
			toolStripMenuItem5.Image = hv.a(ref A_1);
			c().ShortcutKeys = Keys.A | Keys.Control;
			ContextMenuStrip contextMenuStrip = i();
			contextMenuStrip.Items.Add(h());
			contextMenuStrip.Items.Add("-");
			contextMenuStrip.Items.Add(g());
			contextMenuStrip.Items.Add(f());
			contextMenuStrip.Items.Add(e());
			contextMenuStrip.Items.Add(d());
			contextMenuStrip.Items.Add("-");
			contextMenuStrip.Items.Add(c());
			_ = null;
		}
		A_0.ContextMenuStrip = i();
	}

	private static void b()
	{
		h().ShortcutKeys = Keys.Z | Keys.Control;
		g().ShortcutKeys = Keys.X | Keys.Control;
		f().ShortcutKeys = Keys.C | Keys.Control;
		e().ShortcutKeys = Keys.V | Keys.Control;
		c().ShortcutKeys = Keys.A | Keys.Control;
	}

	private static void a()
	{
		h().ShortcutKeys = Keys.None;
		g().ShortcutKeys = Keys.None;
		f().ShortcutKeys = Keys.None;
		e().ShortcutKeys = Keys.None;
		c().ShortcutKeys = Keys.None;
	}

	private static void a(object A_0, ToolStripDropDownClosingEventArgs A_1)
	{
		try
		{
			a();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	private static void a(object A_0, CancelEventArgs A_1)
	{
		try
		{
			i2 i10 = (i2)((ContextMenuStrip)A_0).SourceControl;
			i2 i11 = i10;
			bool flag = i11.SelectionLength > 0;
			bool enabled = flag && !i11.a5(a((TextBox)i10));
			bool enabled2 = global::c.e().Clipboard.GetText().Length > 0 && !i11.a5(b(i10));
			h().Enabled = i11.CanUndo;
			g().Enabled = enabled;
			f().Enabled = flag;
			e().Enabled = enabled2;
			d().Enabled = enabled;
			c().Enabled = i11.SelectionLength != i11.TextLength && i11.TextLength > 0;
			b();
			i11 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	private static void f(object A_0, EventArgs A_1)
	{
		try
		{
			a(RuntimeHelpers.GetObjectValue(A_0)).Undo();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	private static void e(object A_0, EventArgs A_1)
	{
		try
		{
			i2 i10 = a(RuntimeHelpers.GetObjectValue(A_0));
			i2 i11 = i10;
			if (!i11.a5(a((TextBox)i10)))
			{
				i11.Cut();
				i11 = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	private static void d(object A_0, EventArgs A_1)
	{
		try
		{
			a(RuntimeHelpers.GetObjectValue(A_0)).Copy();
			_ = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	private static void c(object A_0, EventArgs A_1)
	{
		try
		{
			i2 a_ = a(RuntimeHelpers.GetObjectValue(A_0));
			i2 i10 = a(RuntimeHelpers.GetObjectValue(A_0));
			if (!i10.a5(b(a_)))
			{
				i10.Paste();
				i10 = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	private static void b(object A_0, EventArgs A_1)
	{
		try
		{
			i2 i10 = a(RuntimeHelpers.GetObjectValue(A_0));
			if (!i10.a5(a((TextBox)i10)))
			{
				SendKeys.Send("{DELETE}");
				_ = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	private static void a(object A_0, EventArgs A_1)
	{
		try
		{
			a(RuntimeHelpers.GetObjectValue(A_0)).SelectAll();
			_ = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	private static i2 a(object A_0)
	{
		return (i2)((ContextMenuStrip)((ToolStripMenuItem)A_0).GetCurrentParent()).SourceControl;
	}

	public static string b(TextBox A_0)
	{
		return A_0.Text.Substring(0, A_0.SelectionStart) + global::c.e().Clipboard.GetText() + A_0.Text.Substring(checked(A_0.SelectionStart + A_0.SelectionLength));
	}

	public static string a(TextBox A_0)
	{
		return A_0.Text.Remove(A_0.SelectionStart, A_0.SelectionLength);
	}
}
