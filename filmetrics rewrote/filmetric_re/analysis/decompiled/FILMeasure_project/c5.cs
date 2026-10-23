using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Filmetrics.My.Resources;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

[DesignerGenerated]
internal class c5 : Form
{
	public delegate void a(en A_0, Guid A_1, bool A_2);

	public delegate void b(int A_0, int A_1, int A_2, ek A_3);

	public class c
	{
		[CompilerGenerated]
		private Label a;

		[CompilerGenerated]
		private TextBox b;

		[CompilerGenerated]
		private ComboBox m_c;

		[CompilerGenerated]
		private Button d;

		[CompilerGenerated]
		private Button e;

		[CompilerGenerated]
		private Button f;

		[CompilerGenerated]
		private TableLayoutPanel g;

		public em h;

		private f1 m_i;

		private ToolTip m_j;

		[SpecialName]
		[CompilerGenerated]
		public virtual Label j()
		{
			return a;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		[CompilerGenerated]
		public virtual void i(Label A_0)
		{
			a = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public virtual TextBox k()
		{
			return b;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		[CompilerGenerated]
		public virtual void i(TextBox A_0)
		{
			EventHandler value = k;
			TextBox textBox = b;
			if (textBox != null)
			{
				textBox.TextChanged -= value;
			}
			b = A_0;
			textBox = b;
			if (textBox != null)
			{
				textBox.TextChanged += value;
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public virtual ComboBox l()
		{
			return m_c;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		[CompilerGenerated]
		public virtual void i(ComboBox A_0)
		{
			m_c = A_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public virtual Button m()
		{
			return d;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		[CompilerGenerated]
		public virtual void i(Button A_0)
		{
			EventHandler value = j;
			Button button = d;
			if (button != null)
			{
				button.Click -= value;
			}
			d = A_0;
			button = d;
			if (button != null)
			{
				button.Click += value;
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public virtual Button n()
		{
			return e;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		[CompilerGenerated]
		public virtual void j(Button A_0)
		{
			EventHandler value = l;
			Button button = e;
			if (button != null)
			{
				button.Click -= value;
			}
			e = A_0;
			button = e;
			if (button != null)
			{
				button.Click += value;
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public virtual Button o()
		{
			return f;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		[CompilerGenerated]
		public virtual void k(Button A_0)
		{
			EventHandler value = i;
			Button button = f;
			if (button != null)
			{
				button.Click -= value;
			}
			f = A_0;
			button = f;
			if (button != null)
			{
				button.Click += value;
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public virtual TableLayoutPanel p()
		{
			return g;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		[CompilerGenerated]
		public virtual void i(TableLayoutPanel A_0)
		{
			g = A_0;
		}

		public c(f1 A_0, ToolTip A_1)
		{
			this.m_j = A_1;
			this.m_i = A_0;
		}

		public c(c A_0, f1 A_1, ToolTip A_2)
			: this(A_0, new em(), A_1, A_2)
		{
		}

		public c(c A_0, em A_1, f1 A_2, ToolTip A_3)
			: this(A_2, A_3)
		{
			i(A_0);
			h = A_1;
			q();
		}

		private void l(object A_0, EventArgs A_1)
		{
			try
			{
				ComboBox comboBox = l();
				if (l().Items.Count > 0)
				{
					h.b.RemoveAt(l().SelectedIndex);
					comboBox.Items.RemoveAt(l().SelectedIndex);
				}
				l().Enabled = l().Items.Count > 0;
				if (l().Items.Count <= 0)
				{
					comboBox.SelectedIndex = -1;
				}
				else
				{
					comboBox.SelectedIndex = 0;
				}
				comboBox = null;
				i();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(c5.m_av, this.m_i, null, i6.a((Button)A_0), "GUIMeasLoc.DelButton_Click", a_);
				ProjectData.ClearProjectError();
			}
		}

		private void k(object A_0, EventArgs A_1)
		{
			try
			{
				h.f(k().Text);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				c5.m_av.c(fz.b.b, "Error in GUIMeasLoc.DelButton_Click", a_);
				ProjectData.ClearProjectError();
			}
		}

		public void q()
		{
			k().Text = h.f();
			this.m_j.SetToolTip(k(), "Name of this Location");
			l().Items.Clear();
			l().Text = string.Empty;
			foreach (en item in h.b)
			{
				l().Items.Add(item.g);
			}
			l().Enabled = l().Items.Count > 0;
			this.m_j.SetToolTip(l(), "List of existing Results for this Location");
			if (l().Items.Count > 0)
			{
				l().SelectedIndex = 0;
			}
			i();
			this.m_j.SetToolTip(m(), "Send selected Result to the Measure Tab for display");
			this.m_j.SetToolTip(n(), "Delete selected Result");
			this.m_j.SetToolTip(o(), "Edit note for this Result");
		}

		private void i(c A_0)
		{
			i(iz.a(A_0.p()));
			p().Visible = true;
			i((TextBox)p().Controls[A_0.p().Controls.IndexOf(A_0.k())]);
			i((ComboBox)p().Controls[A_0.p().Controls.IndexOf(A_0.l())]);
			i((Button)p().Controls[A_0.p().Controls.IndexOf(A_0.m())]);
			j((Button)p().Controls[A_0.p().Controls.IndexOf(A_0.n())]);
			k((Button)p().Controls[A_0.p().Controls.IndexOf(A_0.o())]);
		}

		private void j(object A_0, EventArgs A_1)
		{
			hc hc2 = null;
			try
			{
				if (l().Items.Count != 0 && l().SelectedIndex != -1)
				{
					hc2 = h.b[l().SelectedIndex].b;
					Guid A_2 = default(Guid);
					bool A_3 = default(bool);
					if (hc2 != null)
					{
						this.m_i.m2(hc2, i6.a(m()), ref A_2, ref A_3);
					}
					else
					{
						A_2 = Guid.NewGuid();
					}
					c6.a(h.b[l().SelectedIndex], A_2, !A_3);
					c6.a(h.d, h.e, l().SelectedIndex);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(c5.m_av, this.m_i, null, i6.a((Button)A_0), "GUIMeasLoc.SendButton_Click", a_);
				ProjectData.ClearProjectError();
			}
		}

		private void i(object A_0, EventArgs A_1)
		{
			try
			{
				c7 c10 = new c7();
				c10.a(h.b[l().SelectedIndex].e);
				if (c10.DialogResult == DialogResult.OK)
				{
					h.b[l().SelectedIndex].e = c10.f().Text;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(c5.m_av, this.m_i, null, i6.a((Button)A_0), "GUIMeasLoc.NoteButton_Click", a_);
				ProjectData.ClearProjectError();
			}
		}

		private void i()
		{
			m().Enabled = l().Items.Count > 0;
			n().Enabled = l().Items.Count > 0;
			o().Enabled = l().Items.Count > 0;
		}
	}

	private class d
	{
		public delegate void a(en A_0, string A_1);

		public class b
		{
			public Label a;

			[CompilerGenerated]
			private TextBox m_b;

			public Label c;

			[CompilerGenerated]
			private TextBox d;

			[CompilerGenerated]
			private TableLayoutPanel e;

			[CompilerGenerated]
			private Button f;

			[CompilerGenerated]
			private EventHandler g;

			public el h;

			private ToolTip m_i;

			[SpecialName]
			private bool m_j;

			[SpecialName]
			[CompilerGenerated]
			public virtual TextBox j()
			{
				return m_b;
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			[SpecialName]
			[CompilerGenerated]
			public virtual void i(TextBox A_0)
			{
				EventHandler value = j;
				TextBox textBox = m_b;
				if (textBox != null)
				{
					textBox.TextChanged -= value;
				}
				m_b = A_0;
				textBox = m_b;
				if (textBox != null)
				{
					textBox.TextChanged += value;
				}
			}

			[SpecialName]
			[CompilerGenerated]
			public virtual TextBox k()
			{
				return d;
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			[SpecialName]
			[CompilerGenerated]
			public virtual void j(TextBox A_0)
			{
				EventHandler value = i;
				TextBox textBox = d;
				if (textBox != null)
				{
					textBox.LostFocus -= value;
				}
				d = A_0;
				textBox = d;
				if (textBox != null)
				{
					textBox.LostFocus += value;
				}
			}

			[SpecialName]
			[CompilerGenerated]
			public virtual TableLayoutPanel l()
			{
				return e;
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			[SpecialName]
			[CompilerGenerated]
			public virtual void i(TableLayoutPanel A_0)
			{
				e = A_0;
			}

			[SpecialName]
			[CompilerGenerated]
			public virtual Button m()
			{
				return f;
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			[SpecialName]
			[CompilerGenerated]
			public virtual void i(Button A_0)
			{
				EventHandler value = i;
				Button button = f;
				if (button != null)
				{
					button.Click -= value;
				}
				f = A_0;
				button = f;
				if (button != null)
				{
					button.Click += value;
				}
			}

			[SpecialName]
			[CompilerGenerated]
			public void i(EventHandler A_0)
			{
				EventHandler eventHandler = g;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
					eventHandler = Interlocked.CompareExchange(ref g, value, eventHandler2);
				}
				while ((object)eventHandler != eventHandler2);
			}

			[SpecialName]
			[CompilerGenerated]
			public void j(EventHandler A_0)
			{
				EventHandler eventHandler = g;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
					eventHandler = Interlocked.CompareExchange(ref g, value, eventHandler2);
				}
				while ((object)eventHandler != eventHandler2);
			}

			public b(ToolTip A_0)
			{
				this.m_i = A_0;
			}

			public b(b A_0, ToolTip A_1)
				: this(A_0, new el(), A_1)
			{
			}

			public b(b A_0, el A_1, ToolTip A_2)
				: this(A_2)
			{
				i(A_0);
				h = A_1;
				i();
			}

			private void j(object A_0, EventArgs A_1)
			{
				h.d(j().Text);
			}

			private void i(b A_0)
			{
				i(iz.a(A_0.l()));
				i((TextBox)l().Controls[A_0.l().Controls.IndexOf(A_0.j())]);
				this.m_i.SetToolTip(j(), "String comprised of any characters that are valid in a File Name");
				j((TextBox)l().Controls[A_0.l().Controls.IndexOf(A_0.k())]);
				this.m_i.SetToolTip(k(), "Number of measurement locations on this Sample");
				i((Button)l().Controls[A_0.l().Controls.IndexOf(A_0.m())]);
				this.m_i.SetToolTip(m(), "Apply change to # Locations, adding or deleting locations");
			}

			private void i()
			{
				if (h != null)
				{
					k().Text = h.b.Count.ToString();
					if (string.IsNullOrEmpty(h.d()))
					{
						h.d("Sample #1");
					}
					j().Text = h.d();
				}
				else
				{
					k().Text = "0";
					j().Text = string.Empty;
				}
			}

			private void i(object A_0, EventArgs A_1)
			{
				if (this.m_j)
				{
					return;
				}
				try
				{
					this.m_j = true;
					g?.Invoke(RuntimeHelpers.GetObjectValue(A_0), A_1);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception a_ = ex2;
					c5.m_av.c(fz.b.b, "Error in GUIMeasSampleHeader.HeaderApplyButton_Click", a_);
					ProjectData.ClearProjectError();
				}
				finally
				{
					this.m_j = false;
				}
			}
		}

		public TableLayoutPanel a;

		public TableLayoutPanel b;

		[CompilerGenerated]
		private b c;

		public TableLayoutPanel d;

		private c e;

		private f1 m_f;

		private ToolTip m_g;

		[CompilerGenerated]
		private a m_h;

		[SpecialName]
		[CompilerGenerated]
		public virtual b g()
		{
			return c;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		[SpecialName]
		[CompilerGenerated]
		public virtual void f(b A_0)
		{
			EventHandler a_ = f;
			c?.j(a_);
			c = A_0;
			c?.i(a_);
		}

		[SpecialName]
		[CompilerGenerated]
		public void f(a A_0)
		{
			a a10 = this.m_h;
			a a11;
			do
			{
				a11 = a10;
				a value = (a)Delegate.Combine(a11, A_0);
				a10 = Interlocked.CompareExchange(ref this.m_h, value, a11);
			}
			while ((object)a10 != a11);
		}

		[SpecialName]
		[CompilerGenerated]
		public void g(a A_0)
		{
			a a10 = this.m_h;
			a a11;
			do
			{
				a11 = a10;
				a value = (a)Delegate.Remove(a11, A_0);
				a10 = Interlocked.CompareExchange(ref this.m_h, value, a11);
			}
			while ((object)a10 != a11);
		}

		public TableLayoutPanel h()
		{
			this.a.SuspendLayout();
			this.a.AutoSize = true;
			this.a.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.a.Margin = new Padding(4);
			this.a.ColumnCount = 1;
			this.a.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			this.a.RowCount = 2;
			this.a.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			this.a.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			this.a.Controls.Add(g().l(), 0, 0);
			this.a.Controls.Add(d, 0, 1);
			this.a.ResumeLayout();
			this.b.SuspendLayout();
			this.b.AutoSize = true;
			this.b.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.b.Margin = new Padding(4);
			this.b.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			this.b.ColumnCount = 1;
			this.b.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			this.b.RowCount = 1;
			this.b.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			this.b.Controls.Add(this.a, 0, 0);
			this.b.ResumeLayout();
			return this.b;
		}

		public d(b A_0, c A_1, f1 A_2, ToolTip A_3)
		{
			this.m_f = A_2;
			this.m_g = A_3;
			f(A_1);
			f(new b(A_0, A_3));
			f();
		}

		public d(b A_0, c A_1, el A_2, f1 A_3, ToolTip A_4)
		{
			this.m_f = A_3;
			this.m_g = A_4;
			f(A_1);
			f(new b(A_0, A_2, A_4));
			f();
		}

		private void f(c A_0)
		{
			e = A_0;
			this.a = new TableLayoutPanel();
			this.b = new TableLayoutPanel();
			d = new TableLayoutPanel();
			d.AutoSize = true;
			d.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		}

		private void f(object A_0, EventArgs A_1)
		{
			int num = iz.c(g().k().Text);
			checked
			{
				if (num > 0 && num >= g().h.b.Count && num <= 99)
				{
					d.SuspendLayout();
					int count = g().h.b.Count;
					int num2 = num - 1;
					for (int num3 = count; num3 <= num2; num3++)
					{
						c c10 = new c(e, this.m_f, this.m_g);
						c10.k().Text = c(num3 + 1);
						c10.h.e = num3;
						c10.h.d = g().h.c;
						d.Controls.Add(c10.p(), 0, num3);
						g().h.b.Insert(g().h.b.Count, c10.h);
					}
					d.ResumeLayout();
				}
				else if (num > 0 && num < g().h.b.Count && num <= 99)
				{
					d.SuspendLayout();
					int num4 = g().h.b.Count - 1;
					int num5 = num;
					for (int num6 = num4; num6 >= num5; num6 += -1)
					{
						d.Controls.RemoveAt(num6);
						g().h.b.RemoveAt(num6);
					}
					d.ResumeLayout();
				}
				else
				{
					fe.b(c5.m_av, "Number of Locations must be >0 and <= " + 99, i6.a((Control)A_0));
					g().k().Text = g().h.b.Count.ToString();
				}
			}
		}

		private void f()
		{
			checked
			{
				try
				{
					d.SuspendLayout();
					int num = g().h.b.Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						c c10 = new c(e, g().h.b[num2], this.m_f, this.m_g);
						c10.h.e = num2;
						c10.h.d = g().h.c;
						d.Controls.Add(c10.p(), 0, num2);
					}
				}
				finally
				{
					d.ResumeLayout();
				}
			}
		}
	}

	private IContainer m_a;

	[CompilerGenerated]
	private TableLayoutPanel m_b;

	[CompilerGenerated]
	private Label m_c;

	[CompilerGenerated]
	private Label m_d;

	[CompilerGenerated]
	private TextBox m_e;

	[CompilerGenerated]
	private Label m_f;

	[CompilerGenerated]
	private TextBox m_g;

	[CompilerGenerated]
	private TableLayoutPanel m_h;

	[CompilerGenerated]
	private hy m_i;

	[CompilerGenerated]
	private TableLayoutPanel m_j;

	[CompilerGenerated]
	private Panel m_k;

	[CompilerGenerated]
	private TableLayoutPanel m_l;

	[CompilerGenerated]
	private Button m_m;

	[CompilerGenerated]
	private Button m_n;

	[CompilerGenerated]
	private TableLayoutPanel m_o;

	[CompilerGenerated]
	private TableLayoutPanel m_p;

	[CompilerGenerated]
	private TableLayoutPanel m_q;

	[CompilerGenerated]
	private Button m_r;

	[CompilerGenerated]
	private ComboBox m_s;

	[CompilerGenerated]
	private TableLayoutPanel m_t;

	[CompilerGenerated]
	private Button m_u;

	[CompilerGenerated]
	private ComboBox m_v;

	[CompilerGenerated]
	private Button m_w;

	[CompilerGenerated]
	private ToolStrip m_x;

	[CompilerGenerated]
	private ToolStripButton m_y;

	[CompilerGenerated]
	private ToolStripButton m_z;

	[CompilerGenerated]
	private ToolStripButton m_aa;

	[CompilerGenerated]
	private ToolStripButton m_ab;

	[CompilerGenerated]
	private TableLayoutPanel m_ac;

	[CompilerGenerated]
	private TableLayoutPanel m_ad;

	[CompilerGenerated]
	private Button m_ae;

	[CompilerGenerated]
	private ComboBox m_af;

	[CompilerGenerated]
	private Button m_ag;

	[CompilerGenerated]
	private Button m_ah;

	[CompilerGenerated]
	private Label m_ai;

	[CompilerGenerated]
	private TextBox m_aj;

	[CompilerGenerated]
	private TableLayoutPanel m_ak;

	[CompilerGenerated]
	private Label m_al;

	[CompilerGenerated]
	private TextBox m_am;

	[CompilerGenerated]
	private Label m_an;

	[CompilerGenerated]
	private hy m_ao;

	[CompilerGenerated]
	private TextBox m_ap;

	[CompilerGenerated]
	private Label m_aq;

	[CompilerGenerated]
	private Button m_ar;

	[CompilerGenerated]
	private Button m_as;

	[CompilerGenerated]
	private ToolTip m_at;

	[CompilerGenerated]
	private CheckBox m_au;

	private static fz m_av;

	private ek m_aw;

	private ek m_ax;

	private f1 m_ay;

	private string m_az;

	private ek m_a0;

	private f4 a1;

	private c a2;

	private d.b a3;

	private bool a4;

	private bool a5;

	private const int a6 = 99;

	private const int a7 = 99;

	[CompilerGenerated]
	private a a8;

	[CompilerGenerated]
	private b a9;

	private int[] ba;

	private int bb;

	[SpecialName]
	private bool bc;

	public c5()
	{
		base.Activated += d;
		g();
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
	private void g()
	{
		this.m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(c5));
		c(new TableLayoutPanel());
		f(new TableLayoutPanel());
		h(new TableLayoutPanel());
		d(new Button());
		c(new Button());
		g(new TableLayoutPanel());
		g(new Button());
		c(new CheckBox());
		c(new Panel());
		e(new TableLayoutPanel());
		d(new TableLayoutPanel());
		g(new TextBox());
		c(new Label());
		c(new TextBox());
		d(new Label());
		d(new TextBox());
		e(new Label());
		c(new hy());
		i(new Label());
		k(new Button());
		i(new TableLayoutPanel());
		e(new Button());
		c(new ComboBox());
		j(new TableLayoutPanel());
		f(new Button());
		d(new ComboBox());
		c(new ToolStrip());
		c(new ToolStripButton());
		d(new ToolStripButton());
		e(new ToolStripButton());
		f(new ToolStripButton());
		k(new TableLayoutPanel());
		l(new TableLayoutPanel());
		h(new Button());
		e(new ComboBox());
		i(new Button());
		j(new Button());
		f(new Label());
		e(new TextBox());
		m(new TableLayoutPanel());
		g(new Label());
		f(new TextBox());
		h(new Label());
		d(new hy());
		l(new Button());
		c(new ToolTip(this.m_a));
		h().SuspendLayout();
		r().SuspendLayout();
		v().SuspendLayout();
		u().SuspendLayout();
		q().SuspendLayout();
		n().SuspendLayout();
		w().SuspendLayout();
		z().SuspendLayout();
		ad().SuspendLayout();
		ai().SuspendLayout();
		aj().SuspendLayout();
		aq().SuspendLayout();
		SuspendLayout();
		h().AutoSize = true;
		h().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		h().CausesValidation = false;
		h().ColumnCount = 1;
		h().ColumnStyles.Add(new ColumnStyle());
		h().Controls.Add(r(), 0, 2);
		h().Controls.Add(q(), 0, 1);
		h().Controls.Add(n(), 0, 0);
		h().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		h().Location = new Point(0, 27);
		h().Margin = new Padding(4, 4, 0, 4);
		h().Name = "TableLayoutPanel1";
		h().RowCount = 3;
		h().RowStyles.Add(new RowStyle());
		h().RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		h().RowStyles.Add(new RowStyle());
		h().Size = new Size(728, 584);
		h().TabIndex = 0;
		r().Anchor = AnchorStyles.Left | AnchorStyles.Right;
		r().AutoSize = true;
		r().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		r().CausesValidation = false;
		r().ColumnCount = 3;
		r().ColumnStyles.Add(new ColumnStyle());
		r().ColumnStyles.Add(new ColumnStyle());
		r().ColumnStyles.Add(new ColumnStyle());
		r().Controls.Add(v(), 2, 0);
		r().Controls.Add(u(), 0, 0);
		r().Controls.Add(a0(), 1, 0);
		r().Location = new Point(4, 536);
		r().Margin = new Padding(4);
		r().Name = "TableLayoutPanel13";
		r().RowCount = 1;
		r().RowStyles.Add(new RowStyle());
		r().Size = new Size(720, 44);
		r().TabIndex = 2;
		v().Anchor = AnchorStyles.Right;
		v().AutoSize = true;
		v().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		v().CausesValidation = false;
		v().ColumnCount = 2;
		v().ColumnStyles.Add(new ColumnStyle());
		v().ColumnStyles.Add(new ColumnStyle());
		v().Controls.Add(t(), 1, 0);
		v().Controls.Add(s(), 0, 0);
		v().Location = new Point(521, 3);
		v().Name = "TableLayoutPanel15";
		v().RowCount = 1;
		v().RowStyles.Add(new RowStyle());
		v().Size = new Size(196, 38);
		v().TabIndex = 3;
		t().CausesValidation = false;
		t().DialogResult = DialogResult.Cancel;
		t().Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		t().Location = new Point(102, 4);
		t().Margin = new Padding(4);
		t().Name = "ButtonCancel";
		t().Size = new Size(90, 30);
		t().TabIndex = 3;
		t().Text = "Cancel";
		az().SetToolTip(t(), "Close dialog, ignoring any changes that have been made");
		t().UseVisualStyleBackColor = true;
		s().Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		s().Location = new Point(4, 4);
		s().Margin = new Padding(4);
		s().Name = "ButtonOK";
		s().Size = new Size(90, 30);
		s().TabIndex = 2;
		s().Text = "OK";
		az().SetToolTip(s(), "Accept changes and Close dialog");
		s().UseVisualStyleBackColor = true;
		u().Anchor = AnchorStyles.Left;
		u().AutoSize = true;
		u().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		u().ColumnCount = 1;
		u().ColumnStyles.Add(new ColumnStyle());
		u().Controls.Add(ac(), 0, 0);
		u().Location = new Point(3, 3);
		u().Name = "TableLayoutPanel14";
		u().RowCount = 1;
		u().RowStyles.Add(new RowStyle());
		u().Size = new Size(242, 38);
		u().TabIndex = 1;
		ac().AutoSize = true;
		ac().Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ac().Location = new Point(4, 4);
		ac().Margin = new Padding(4);
		ac().Name = "ButtonCreateMeasReport";
		ac().Size = new Size(234, 30);
		ac().TabIndex = 0;
		ac().Text = "Generate Report && Files";
		az().SetToolTip(ac(), "Write Excel spreadsheet and all other files to output folder defined in Setup->Options");
		ac().UseVisualStyleBackColor = true;
		a0().Anchor = AnchorStyles.None;
		a0().AutoSize = true;
		a0().Location = new Point(251, 12);
		a0().Name = "ChkWriteMarkedOnly";
		a0().Size = new Size(183, 20);
		a0().TabIndex = 2;
		a0().Text = "Write only Marked Results";
		az().SetToolTip(a0(), componentResourceManager.GetString("ChkWriteMarkedOnly.ToolTip"));
		a0().UseVisualStyleBackColor = true;
		q().Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
		q().AutoScroll = true;
		q().BackColor = SystemColors.Window;
		q().Controls.Add(p());
		q().Location = new Point(4, 73);
		q().Margin = new Padding(4);
		q().Name = "Panel1";
		q().Size = new Size(720, 455);
		q().TabIndex = 1;
		p().AutoSize = true;
		p().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		p().CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
		p().ColumnCount = 1;
		p().ColumnStyles.Add(new ColumnStyle());
		p().Location = new Point(0, 0);
		p().Margin = new Padding(4);
		p().Name = "TableLayoutPanelInner";
		p().RowCount = 2;
		p().RowStyles.Add(new RowStyle());
		p().RowStyles.Add(new RowStyle());
		p().Size = new Size(2, 3);
		p().TabIndex = 3;
		n().Anchor = AnchorStyles.None;
		n().AutoSize = true;
		n().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		n().ColumnCount = 7;
		h().SetColumnSpan(n(), 2);
		n().ColumnStyles.Add(new ColumnStyle());
		n().ColumnStyles.Add(new ColumnStyle());
		n().ColumnStyles.Add(new ColumnStyle());
		n().ColumnStyles.Add(new ColumnStyle());
		n().ColumnStyles.Add(new ColumnStyle());
		n().ColumnStyles.Add(new ColumnStyle());
		n().ColumnStyles.Add(new ColumnStyle());
		n().Controls.Add(av(), 1, 1);
		n().Controls.Add(i(), 0, 0);
		n().Controls.Add(k(), 1, 0);
		n().Controls.Add(j(), 2, 0);
		n().Controls.Add(m(), 3, 0);
		n().Controls.Add(l(), 4, 0);
		n().Controls.Add(o(), 5, 0);
		n().Controls.Add(aw(), 0, 1);
		n().Controls.Add(ax(), 6, 0);
		n().Location = new Point(31, 4);
		n().Margin = new Padding(4);
		n().Name = "TableLayoutPanel2";
		n().RowCount = 2;
		n().RowStyles.Add(new RowStyle());
		n().RowStyles.Add(new RowStyle());
		n().Size = new Size(665, 61);
		n().TabIndex = 2;
		av().Location = new Point(100, 35);
		av().Margin = new Padding(0, 4, 4, 4);
		av().Name = "TextBoxAccount";
		av().Size = new Size(188, 22);
		av().TabIndex = 12;
		az().SetToolTip(av(), "Use Sales and Marketing Account Naming Rules");
		i().Anchor = AnchorStyles.None;
		i().AutoSize = true;
		i().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		i().Location = new Point(4, 7);
		i().Margin = new Padding(4, 4, 3, 4);
		i().Name = "Label1";
		i().Size = new Size(93, 16);
		i().TabIndex = 0;
		i().Text = "Presented To:";
		k().Location = new Point(100, 4);
		k().Margin = new Padding(0, 4, 4, 4);
		k().Name = "TextBoxPresentTo";
		k().Size = new Size(188, 22);
		k().TabIndex = 1;
		az().SetToolTip(k(), "Name of Person Receiving Report");
		j().Anchor = AnchorStyles.None;
		j().AutoSize = true;
		j().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		j().Location = new Point(296, 7);
		j().Margin = new Padding(4, 4, 3, 4);
		j().Name = "Label2";
		j().Size = new Size(40, 16);
		j().TabIndex = 2;
		j().Text = "Date:";
		m().Location = new Point(339, 4);
		m().Margin = new Padding(0, 4, 4, 4);
		m().Name = "TextBoxDate";
		m().Size = new Size(127, 22);
		m().TabIndex = 3;
		az().SetToolTip(m(), "User-editable Report date");
		l().Anchor = AnchorStyles.None;
		l().AutoSize = true;
		l().Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		l().Location = new Point(474, 7);
		l().Margin = new Padding(4, 4, 3, 4);
		l().Name = "Label3";
		l().Size = new Size(75, 16);
		l().TabIndex = 4;
		l().Text = "# Samples:";
		o().f(A_0: false);
		o().Location = new Point(552, 4);
		o().Margin = new Padding(0, 4, 4, 4);
		o().Name = "TextBoxNumericSamples";
		o().e(A_0: false);
		o().Size = new Size(45, 22);
		o().TabIndex = 10;
		o().Text = "0";
		o().TextAlign = HorizontalAlignment.Center;
		az().SetToolTip(o(), "Changing # will add or delete samples");
		aw().Anchor = AnchorStyles.Right;
		aw().AutoSize = true;
		aw().Location = new Point(38, 38);
		aw().Name = "Label4";
		aw().Size = new Size(59, 16);
		aw().TabIndex = 11;
		aw().Text = "Account:";
		ax().Location = new Point(604, 3);
		ax().Name = "ButtonApply";
		ax().Size = new Size(58, 25);
		ax().TabIndex = 13;
		ax().Text = "Apply";
		az().SetToolTip(ax(), "Apply change to # Samples");
		ax().UseVisualStyleBackColor = true;
		w().AutoSize = true;
		w().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		w().ColumnCount = 6;
		w().ColumnStyles.Add(new ColumnStyle());
		w().ColumnStyles.Add(new ColumnStyle());
		w().ColumnStyles.Add(new ColumnStyle());
		w().ColumnStyles.Add(new ColumnStyle());
		w().ColumnStyles.Add(new ColumnStyle());
		w().ColumnStyles.Add(new ColumnStyle());
		w().Controls.Add(x(), 5, 0);
		w().Location = new Point(0, 0);
		w().Name = "TableLayoutPanel8";
		w().RowCount = 1;
		w().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		w().Size = new Size(200, 100);
		w().TabIndex = 0;
		x().AutoSize = true;
		x().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		x().Location = new Point(4, 4);
		x().Margin = new Padding(4);
		x().Name = "Button7";
		x().Size = new Size(49, 23);
		x().TabIndex = 3;
		x().Text = "Note...";
		x().UseVisualStyleBackColor = true;
		y().Anchor = AnchorStyles.None;
		y().FormattingEnabled = true;
		y().Items.AddRange(new object[3] { "2010/04/22-1 (SS), (Result)", "2010/04/22-2", "2010/04/22-3" });
		y().Location = new Point(204, 6);
		y().Margin = new Padding(3, 4, 4, 4);
		y().Name = "ComboBox2";
		y().Size = new Size(186, 21);
		y().TabIndex = 2;
		y().Text = "2010/04/22-1 (SS), (Result)";
		z().AutoSize = true;
		z().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		z().ColumnCount = 6;
		z().ColumnStyles.Add(new ColumnStyle());
		z().ColumnStyles.Add(new ColumnStyle());
		z().ColumnStyles.Add(new ColumnStyle());
		z().ColumnStyles.Add(new ColumnStyle());
		z().ColumnStyles.Add(new ColumnStyle());
		z().ColumnStyles.Add(new ColumnStyle());
		z().Controls.Add(aa(), 5, 0);
		z().Location = new Point(0, 0);
		z().Name = "TableLayoutPanel20";
		z().RowCount = 1;
		z().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		z().Size = new Size(200, 100);
		z().TabIndex = 0;
		aa().AutoSize = true;
		aa().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		aa().Location = new Point(4, 4);
		aa().Margin = new Padding(4);
		aa().Name = "Button32";
		aa().Size = new Size(49, 23);
		aa().TabIndex = 3;
		aa().Text = "Note...";
		aa().UseVisualStyleBackColor = true;
		ab().Anchor = AnchorStyles.None;
		ab().FormattingEnabled = true;
		ab().Items.AddRange(new object[3] { "2010/04/22-1 (SS), (Result)", "2010/04/22-2", "2010/04/22-3" });
		ab().Location = new Point(204, 6);
		ab().Margin = new Padding(3, 4, 4, 4);
		ab().Name = "ComboBox11";
		ab().Size = new Size(186, 21);
		ab().TabIndex = 2;
		ab().Text = "2010/04/22-1 (SS), (Result)";
		ad().GripStyle = ToolStripGripStyle.Hidden;
		ad().Items.AddRange(new ToolStripItem[4]
		{
			ae(),
			af(),
			ag(),
			ah()
		});
		ad().Location = new Point(0, 0);
		ad().Name = "ToolStrip1";
		ad().RenderMode = ToolStripRenderMode.System;
		ad().Size = new Size(820, 25);
		ad().TabIndex = 1;
		ad().Text = "ToolStrip1";
		ae().DisplayStyle = ToolStripItemDisplayStyle.Image;
		ae().Image = Resources.OpenFile;
		ae().ImageTransparentColor = Color.Magenta;
		ae().Name = "ToolStripButtonOpen";
		ae().Size = new Size(23, 22);
		ae().Text = "Open";
		ae().ToolTipText = "Open an existing Report";
		af().DisplayStyle = ToolStripItemDisplayStyle.Image;
		af().Image = Resources.NewFile;
		af().ImageTransparentColor = Color.Magenta;
		af().Name = "ToolStripButtonNew";
		af().Size = new Size(23, 22);
		af().Text = "New";
		af().ToolTipText = "Create a New Report";
		ag().DisplayStyle = ToolStripItemDisplayStyle.Image;
		ag().Image = Resources.Save;
		ag().ImageTransparentColor = Color.Magenta;
		ag().Name = "ToolStripButtonSave";
		ag().Size = new Size(23, 22);
		ag().Text = "Save";
		ag().ToolTipText = "Save Complete Report (Including Spectra, Recipes, Results)";
		ah().DisplayStyle = ToolStripItemDisplayStyle.Image;
		ah().Image = Resources.SaveAs;
		ah().ImageTransparentColor = Color.Magenta;
		ah().Name = "ToolStripButtonSaveAs";
		ah().Size = new Size(23, 22);
		ah().Text = "Save As";
		ah().ToolTipText = "Save As...";
		ah().Visible = false;
		ai().AutoSize = true;
		ai().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ai().ColumnCount = 1;
		ai().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		ai().Controls.Add(aj(), 0, 1);
		ai().Controls.Add(aq(), 0, 0);
		ai().Location = new Point(7, 620);
		ai().Margin = new Padding(4);
		ai().Name = "TemplateSample";
		ai().RowCount = 2;
		ai().RowStyles.Add(new RowStyle());
		ai().RowStyles.Add(new RowStyle());
		ai().RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		ai().Size = new Size(689, 81);
		ai().TabIndex = 4;
		ai().Visible = false;
		aj().AutoSize = true;
		aj().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		aj().ColumnCount = 6;
		aj().ColumnStyles.Add(new ColumnStyle());
		aj().ColumnStyles.Add(new ColumnStyle());
		aj().ColumnStyles.Add(new ColumnStyle());
		aj().ColumnStyles.Add(new ColumnStyle());
		aj().ColumnStyles.Add(new ColumnStyle());
		aj().ColumnStyles.Add(new ColumnStyle());
		aj().Controls.Add(ak(), 5, 0);
		aj().Controls.Add(al(), 2, 0);
		aj().Controls.Add(am(), 4, 0);
		aj().Controls.Add(an(), 3, 0);
		aj().Controls.Add(ao(), 0, 0);
		aj().Controls.Add(ap(), 1, 0);
		aj().Location = new Point(4, 43);
		aj().Margin = new Padding(4);
		aj().Name = "TemplateMeasLoc";
		aj().RowCount = 1;
		aj().RowStyles.Add(new RowStyle());
		aj().Size = new Size(681, 34);
		aj().TabIndex = 3;
		ak().AutoSize = true;
		ak().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ak().Location = new Point(621, 4);
		ak().Margin = new Padding(4);
		ak().Name = "TemplateButtonNote";
		ak().Size = new Size(56, 26);
		ak().TabIndex = 3;
		ak().Text = "Note...";
		ak().UseVisualStyleBackColor = true;
		al().Anchor = AnchorStyles.None;
		al().DropDownStyle = ComboBoxStyle.DropDownList;
		al().FormattingEnabled = true;
		al().Items.AddRange(new object[3] { "2010/04/22-1 (SS), (Result)", "2010/04/22-2", "2010/04/22-3" });
		al().Location = new Point(230, 6);
		al().Margin = new Padding(3, 4, 4, 4);
		al().Name = "TemplateComboBoxMeasItem";
		al().Size = new Size(186, 24);
		al().TabIndex = 2;
		am().AutoSize = true;
		am().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		am().Location = new Point(552, 4);
		am().Margin = new Padding(4);
		am().Name = "TemplateButtonDelete";
		am().Size = new Size(61, 26);
		am().TabIndex = 2;
		am().Text = "Delete ";
		am().UseVisualStyleBackColor = true;
		an().AutoSize = true;
		an().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		an().Location = new Point(424, 4);
		an().Margin = new Padding(4);
		an().Name = "TemplateButtonSend";
		an().Size = new Size(120, 26);
		an().TabIndex = 1;
		an().Text = "Send to Measure";
		an().UseVisualStyleBackColor = true;
		ao().Anchor = AnchorStyles.None;
		ao().AutoSize = true;
		ao().BackColor = Color.Transparent;
		ao().Location = new Point(20, 9);
		ao().Margin = new Padding(20, 0, 2, 0);
		ao().Name = "TemplateLocNameLabel";
		ao().Size = new Size(102, 16);
		ao().TabIndex = 4;
		ao().Text = "Location Name:";
		ap().Anchor = AnchorStyles.None;
		ap().Location = new Point(124, 6);
		ap().Margin = new Padding(0, 3, 3, 3);
		ap().Name = "TemplateTextBoxLocName";
		ap().Size = new Size(100, 22);
		ap().TabIndex = 5;
		ap().TextAlign = HorizontalAlignment.Center;
		aq().AutoSize = true;
		aq().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		aq().ColumnCount = 5;
		aq().ColumnStyles.Add(new ColumnStyle());
		aq().ColumnStyles.Add(new ColumnStyle());
		aq().ColumnStyles.Add(new ColumnStyle());
		aq().ColumnStyles.Add(new ColumnStyle());
		aq().ColumnStyles.Add(new ColumnStyle());
		aq().Controls.Add(ar(), 0, 0);
		aq().Controls.Add(@as(), 1, 0);
		aq().Controls.Add(at(), 2, 0);
		aq().Controls.Add(au(), 3, 0);
		aq().Controls.Add(ay(), 4, 0);
		aq().Location = new Point(4, 4);
		aq().Margin = new Padding(4);
		aq().Name = "TemplateSampleHeader";
		aq().RowCount = 1;
		aq().RowStyles.Add(new RowStyle());
		aq().Size = new Size(502, 31);
		aq().TabIndex = 0;
		ar().Anchor = AnchorStyles.None;
		ar().AutoSize = true;
		ar().BackColor = Color.Transparent;
		ar().Location = new Point(4, 7);
		ar().Margin = new Padding(4, 4, 3, 4);
		ar().Name = "TemplateSampleNameLabel";
		ar().Size = new Size(98, 16);
		ar().TabIndex = 0;
		ar().Text = "Sample Name:";
		@as().Location = new Point(105, 4);
		@as().Margin = new Padding(0, 4, 4, 4);
		@as().Name = "TemplateSampleNameTextBox";
		@as().Size = new Size(203, 22);
		@as().TabIndex = 1;
		@as().TextAlign = HorizontalAlignment.Center;
		at().Anchor = AnchorStyles.None;
		at().AutoSize = true;
		at().BackColor = Color.Transparent;
		at().Location = new Point(316, 7);
		at().Margin = new Padding(4, 4, 3, 4);
		at().Name = "TemplateNumLocationLabel";
		at().Size = new Size(79, 16);
		at().TabIndex = 2;
		at().Text = "# Locations:";
		au().f(A_0: false);
		au().Location = new Point(398, 4);
		au().Margin = new Padding(0, 4, 4, 4);
		au().Name = "TemplateNumLocationTextBox";
		au().e(A_0: false);
		au().Size = new Size(40, 22);
		au().TabIndex = 3;
		au().Text = "0";
		au().TextAlign = HorizontalAlignment.Center;
		ay().Location = new Point(445, 3);
		ay().Name = "ButtonHeaderApply";
		ay().Size = new Size(54, 25);
		ay().TabIndex = 4;
		ay().Text = "Apply";
		ay().UseVisualStyleBackColor = true;
		az().AutoPopDelay = 50000;
		az().InitialDelay = 500;
		az().ReshowDelay = 100;
		az().ShowAlways = true;
		base.AcceptButton = s();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = t();
		base.CausesValidation = false;
		base.ClientSize = new Size(820, 613);
		base.Controls.Add(ai());
		base.Controls.Add(ad());
		base.Controls.Add(h());
		Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogMeasReport";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Edit Report";
		h().ResumeLayout(performLayout: false);
		h().PerformLayout();
		r().ResumeLayout(performLayout: false);
		r().PerformLayout();
		v().ResumeLayout(performLayout: false);
		u().ResumeLayout(performLayout: false);
		u().PerformLayout();
		q().ResumeLayout(performLayout: false);
		q().PerformLayout();
		n().ResumeLayout(performLayout: false);
		n().PerformLayout();
		w().ResumeLayout(performLayout: false);
		w().PerformLayout();
		z().ResumeLayout(performLayout: false);
		z().PerformLayout();
		ad().ResumeLayout(performLayout: false);
		ad().PerformLayout();
		ai().ResumeLayout(performLayout: false);
		ai().PerformLayout();
		aj().ResumeLayout(performLayout: false);
		aj().PerformLayout();
		aq().ResumeLayout(performLayout: false);
		aq().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel h()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TableLayoutPanel A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label i()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label j()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox k()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TextBox A_0)
	{
		EventHandler value = e;
		TextBox textBox = this.m_e;
		if (textBox != null)
		{
			textBox.TextChanged -= value;
		}
		this.m_e = A_0;
		textBox = this.m_e;
		if (textBox != null)
		{
			textBox.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label l()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox m()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TextBox A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel n()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TableLayoutPanel A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy o()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(hy A_0)
	{
		EventHandler value = c;
		hy hy2 = this.m_i;
		if (hy2 != null)
		{
			hy2.LostFocus -= value;
		}
		this.m_i = A_0;
		hy2 = this.m_i;
		if (hy2 != null)
		{
			hy2.LostFocus += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel p()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TableLayoutPanel A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel q()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Panel A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel r()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(TableLayoutPanel A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button s()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = f;
		Button button = this.m_m;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_m = A_0;
		button = this.m_m;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button t()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Button A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel u()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(TableLayoutPanel A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel v()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(TableLayoutPanel A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel w()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(TableLayoutPanel A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button x()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Button A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox y()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ComboBox A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel z()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(TableLayoutPanel A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button aa()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Button A_0)
	{
		this.m_u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox ab()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(ComboBox A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ac()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Button A_0)
	{
		EventHandler value = g;
		Button button = this.m_w;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_w = A_0;
		button = this.m_w;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStrip ad()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ToolStrip A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton ae()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ToolStripButton A_0)
	{
		EventHandler value = k;
		ToolStripButton toolStripButton = this.m_y;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_y = A_0;
		toolStripButton = this.m_y;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton af()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(ToolStripButton A_0)
	{
		EventHandler value = j;
		ToolStripButton toolStripButton = this.m_z;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_z = A_0;
		toolStripButton = this.m_z;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton ag()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(ToolStripButton A_0)
	{
		EventHandler value = i;
		ToolStripButton toolStripButton = this.m_aa;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_aa = A_0;
		toolStripButton = this.m_aa;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripButton ah()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(ToolStripButton A_0)
	{
		EventHandler value = h;
		ToolStripButton toolStripButton = this.m_ab;
		if (toolStripButton != null)
		{
			toolStripButton.Click -= value;
		}
		this.m_ab = A_0;
		toolStripButton = this.m_ab;
		if (toolStripButton != null)
		{
			toolStripButton.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel ai()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(TableLayoutPanel A_0)
	{
		this.m_ac = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel aj()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(TableLayoutPanel A_0)
	{
		this.m_ad = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ak()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Button A_0)
	{
		this.m_ae = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox al()
	{
		return this.m_af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(ComboBox A_0)
	{
		this.m_af = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button am()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Button A_0)
	{
		this.m_ag = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button an()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Button A_0)
	{
		this.m_ah = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ao()
	{
		return this.m_ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_ai = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox ap()
	{
		return this.m_aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TextBox A_0)
	{
		this.m_aj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel aq()
	{
		return this.m_ak;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(TableLayoutPanel A_0)
	{
		this.m_ak = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ar()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Label A_0)
	{
		this.m_al = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox @as()
	{
		return this.m_am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(TextBox A_0)
	{
		this.m_am = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label at()
	{
		return this.m_an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Label A_0)
	{
		this.m_an = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy au()
	{
		return this.m_ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(hy A_0)
	{
		this.m_ao = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox av()
	{
		return this.m_ap;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(TextBox A_0)
	{
		EventHandler value = l;
		TextBox textBox = this.m_ap;
		if (textBox != null)
		{
			textBox.TextChanged -= value;
		}
		this.m_ap = A_0;
		textBox = this.m_ap;
		if (textBox != null)
		{
			textBox.TextChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aw()
	{
		return this.m_aq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Label A_0)
	{
		this.m_aq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ax()
	{
		return this.m_ar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Button A_0)
	{
		EventHandler value = c;
		Button button = this.m_ar;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ar = A_0;
		button = this.m_ar;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ay()
	{
		return this.m_as;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(Button A_0)
	{
		this.m_as = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip az()
	{
		return this.m_at;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ToolTip A_0)
	{
		this.m_at = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox a0()
	{
		return this.m_au;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(CheckBox A_0)
	{
		this.m_au = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void c(a A_0)
	{
		a a10 = a8;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Combine(a11, A_0);
			a10 = Interlocked.CompareExchange(ref a8, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void d(a A_0)
	{
		a a10 = a8;
		a a11;
		do
		{
			a11 = a10;
			a value = (a)Delegate.Remove(a11, A_0);
			a10 = Interlocked.CompareExchange(ref a8, value, a11);
		}
		while ((object)a10 != a11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void c(b A_0)
	{
		b b10 = a9;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Combine(b11, A_0);
			b10 = Interlocked.CompareExchange(ref a9, value, b11);
		}
		while ((object)b10 != b11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void d(b A_0)
	{
		b b10 = a9;
		b b11;
		do
		{
			b11 = b10;
			b value = (b)Delegate.Remove(b11, A_0);
			b10 = Interlocked.CompareExchange(ref a9, value, b11);
		}
		while ((object)b10 != b11);
	}

	public void c(fz A_0, f1 A_1, f4 A_2, gh A_3, string A_4, ref ek A_5)
	{
		try
		{
			a4 = false;
			c5.m_av = A_0;
			this.m_ay = A_1;
			this.m_az = A_4;
			this.m_a0 = A_5;
			a1 = A_2;
			a2 = new c(this.m_ay, az());
			a3 = new d.b(az());
			f();
			e();
			ba = new int[0];
			if (A_5 == null)
			{
				this.m_aw = new ek();
			}
			else
			{
				if (this.m_aw == null)
				{
					this.m_aw = new ek();
				}
				A_5.l(this.m_aw);
			}
			c6.b((c6.a)c);
			c6.b((c6.b)c);
			a0().Checked = global::e.a().WriteMarkedResultsOnly;
			ShowDialog();
			if (base.DialogResult == DialogResult.OK)
			{
				if (A_5 != null && !a5 && c(A_5, this.m_aw, this.m_ax))
				{
					A_3.b((hc)null);
				}
				A_5 = this.m_ax;
			}
			a5 = false;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c5.m_av, this.m_ay, a1, i6.a(this), "DialogMeasReport.InitAndShow", a_);
			ProjectData.ClearProjectError();
		}
		finally
		{
			c6.a((c6.a)c);
			c6.a((c6.b)c);
		}
	}

	private void f(ek A_0)
	{
		foreach (el item in A_0.c)
		{
			foreach (em item2 in item.b)
			{
				foreach (en item3 in item2.b)
				{
					if (item3.b != null && item3.b.cn() != null)
					{
						item3.b.cn().r(this.m_ay.sn(this.m_az));
					}
					en current3 = null;
				}
			}
		}
	}

	private static bool c(ek A_0, ek A_1, ek A_2)
	{
		checked
		{
			int num = Math.Min(A_0.c.Count - 1, A_1.c.Count - 1);
			bool result = default(bool);
			for (int num2 = 0; num2 <= num; num2++)
			{
				el el2 = A_0.c[num2];
				el el3 = A_1.c[num2];
				bool flag = Operators.CompareString(el2.d(), el3.d(), TextCompare: false) != 0;
				int num3 = Math.Min(el2.b.Count - 1, el3.b.Count - 1);
				for (int num4 = 0; num4 <= num3; num4++)
				{
					em obj = el2.b[num4];
					bool flag2 = Operators.CompareString(Right: el3.b[num4].f(), Left: obj.f(), TextCompare: false) != 0;
					if (!flag && !flag2)
					{
						continue;
					}
					el el4 = A_2.c[num2];
					em em2 = el4.b[num4];
					int num5 = 0;
					if (em2.b.Count <= 0)
					{
						continue;
					}
					result = true;
					foreach (en item in em2.b)
					{
						num5++;
						item.b.cn().ak(el4.d() + "-" + em2.f() + "-" + item.b.cn().cb().ToString("yyyy-MM-dd") + "-" + num5);
						item.b.cf(unchecked((a4.a)global::e.a().ShowSpectrumCoordOption), global::e.a().AlwayShowSpectrumCoordXYZ);
					}
				}
			}
			return result;
		}
	}

	private void f()
	{
		a3.i(aq());
		a3.i(@as());
		a3.j(au());
		a3.i(ay());
	}

	private void e()
	{
		a2.i(aj());
		a2.i(ap());
		a2.i(al());
		a2.i(an());
		a2.j(am());
		a2.k(ak());
	}

	private void l(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_aw.a = av().Text.Trim();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c5.m_av, this.m_ay, a1, i6.a(this), "DialogMeasReport.TextBoxAccount_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		try
		{
			if (this.m_aw != null && !global::e.a().ReportDontPromptBeforeClose)
			{
				Point a_ = i6.a(this);
				string A_2 = "DontAskMeThisAgain";
				bool A_3 = default(bool);
				if (!fe.b(ref c5.m_av, "Are you sure you want to open a different Report, losing any unsaved data?", "ReportCloseWarningTitle", "Yes", "No", a_, hu.a(ref A_2), ref A_3))
				{
					return;
				}
				global::e.a().ReportDontPromptBeforeClose = A_3;
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			b2 b10 = new b2();
			openFileDialog.Title = "Open Complete Measurement Document";
			b10.a("Filmetrics Complete Measurement Document (*.fibcm)", "*.fibcm", 1);
			openFileDialog.InitialDirectory = i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
			openFileDialog.Filter = b10.b();
			openFileDialog.Multiselect = false;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(openFileDialog.FileName);
				this.m_aw = new ek();
				this.m_aw.c.Clear();
				this.m_aw.l(openFileDialog.FileName, c5.m_av, this.m_ay.ut(), hg.b4());
				f(this.m_aw);
				d();
				a5 = true;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(c5.m_av, this.m_ay, a1, i6.a(this), "DialogMeasReport.ToolStripButtonOpen_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		try
		{
			if (this.m_aw != null && !global::e.a().ReportDontPromptBeforeClose)
			{
				Point a_ = i6.a(this);
				string A_2 = "DontAskMeThisAgain";
				bool A_3 = default(bool);
				if (!fe.b(ref c5.m_av, "Are you sure you want to create a new Report, losing any unsaved data?", "ReportCloseWarningTitle", "Yes", "No", a_, hu.a(ref A_2), ref A_3))
				{
					return;
				}
				global::e.a().ReportDontPromptBeforeClose = A_3;
			}
			this.m_aw = new ek();
			d();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(c5.m_av, this.m_ay, a1, i6.a(this), "DialogMeasReport.ToolStripButtonNew_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		try
		{
			bool A_2 = default(bool);
			d(ref A_2);
			if (!A_2)
			{
				this.m_aw.l(this.m_aw.d);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c5.m_av, this.m_ay, a1, i6.a(this), "DialogMeasReport.ToolStripButtonSave_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		try
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			b2 b10 = new b2();
			b10.a("Filmetrics Complete Measurement Document (*.fibcm)", "*.fibcm", 1);
			saveFileDialog.Filter = b10.b();
			saveFileDialog.FilterIndex = global::e.a().LastSaveScreenshotFileTypeIdx;
			saveFileDialog.InitialDirectory = i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.m_aw.l(saveFileDialog.FileName);
				if (!ag().Enabled)
				{
					ag().Enabled = true;
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c5.m_av, this.m_ay, a1, i6.a(this), "DialogMeasReport.ToolStripButtonSaveAs_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d()
	{
		checked
		{
			try
			{
				SuspendLayout();
				k().Text = this.m_aw.e;
				av().Text = this.m_aw.a;
				m().Text = this.m_aw.b.ToString("yyyy-MMM-d");
				o().Text = this.m_aw.c.Count.ToString();
				try
				{
					p().SuspendLayout();
					p().Controls.Clear();
					int num = this.m_aw.c.Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						d d10 = new d(a3, a2, this.m_aw.c[num2], this.m_ay, az());
						d10.g().h.c = num2;
						p().Controls.Add(d10.h(), 0, num2);
					}
				}
				finally
				{
					p().ResumeLayout();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(c5.m_av, this.m_ay, a1, i6.a(this), "DialogMeasReport.PopulateGui", a_);
				ProjectData.ClearProjectError();
			}
			finally
			{
				ResumeLayout();
			}
		}
	}

	private void c(en A_0, Guid A_1, bool A_2)
	{
		a8?.Invoke(A_0, A_1, A_2);
	}

	private void c(int A_0, int A_1, int A_2)
	{
		if (c())
		{
			bool A_3 = default(bool);
			c(ref A_3);
			if (!A_3)
			{
				a9?.Invoke(A_0, A_1, A_2, this.m_ax);
			}
		}
	}

	public static void c(string A_0, DateTime A_1, ref string A_2, ref string A_3)
	{
		A_3 = A_0 + " " + A_1.ToString("yyyy-MM-dd");
		if (string.IsNullOrEmpty(global::e.a().ReportOutputPath))
		{
			A_2 = i3.b();
		}
		else
		{
			A_2 = global::e.a().ReportOutputPath;
		}
	}

	public static string e(ek A_0)
	{
		string A_1 = null;
		string A_2 = null;
		c(A_0.a, A_0.b, ref A_1, ref A_2);
		return A_1 + "\\" + A_2 + "\\CompleteMeasDoc.fibcm";
	}

	private bool c(ref DateTime A_0)
	{
		if (!DateTime.TryParse(m().Text, out A_0))
		{
			fe.b(c5.m_av, "Please enter a valid date", i6.a(this));
			return false;
		}
		return true;
	}

	public static string c(int A_0)
	{
		if (A_0 < 1 || A_0 > 702)
		{
			throw new Exception("colNum out of range for converted to valid Excel column name.");
		}
		checked
		{
			if (A_0 < 27)
			{
				return Conversions.ToString(Strings.Chr(64 + A_0));
			}
			int num = A_0 + 64 - 64;
			int num2 = unchecked(num / 26);
			int num3 = num - num2 * 26;
			if (num3 == 0)
			{
				num2--;
				num3 = 26;
			}
			string obj = Conversions.ToString(Strings.Chr(num2 + 64));
			string text = Conversions.ToString(Strings.Chr(num3 + 64));
			return obj + text;
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		try
		{
			if (c())
			{
				if (a0().Checked)
				{
					ek a_ = new ek();
					this.m_aw.l(a_);
					d(a_);
					c(a_);
				}
				else
				{
					c(this.m_aw);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(c5.m_av, this.m_ay, a1, i6.a(this), "DialogMeasReport.ButtonCreateMeasReport_Click", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void d(ref bool A_0)
	{
		string A_1 = null;
		string A_2 = null;
		if (!c())
		{
			A_0 = true;
		}
		else
		{
			DateTime A_3 = default(DateTime);
			if (!c(ref A_3))
			{
				return;
			}
			c(this.m_aw.a, A_3, ref A_1, ref A_2);
			this.m_aw.b = A_3;
			string path = A_1 + "\\" + A_2;
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
				this.m_aw.d = e(this.m_aw);
			}
			else if (Operators.CompareString(this.m_aw.d, e(this.m_aw), TextCompare: false) != 0)
			{
				if (!fe.b(ref c5.m_av, "The folder already exists, do you want to remove all the files in the folder ?", "ConfirmBeforeDeleteTitle", "Yes", "No", i6.a(this)))
				{
					A_0 = true;
					return;
				}
				DirectoryInfo directoryInfo = new DirectoryInfo(path);
				FileInfo[] files = directoryInfo.GetFiles();
				for (int num = 0; num < files.Length; num = checked(num + 1))
				{
					File.Delete(files[num].FullName);
				}
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				foreach (DirectoryInfo directoryInfo2 in directories)
				{
					global::c.e().FileSystem.DeleteDirectory(directoryInfo2.FullName, DeleteDirectoryOption.DeleteAllContents);
				}
				Directory.CreateDirectory(path);
				this.m_aw.d = e(this.m_aw);
			}
			global::e.a().WriteMarkedResultsOnly = a0().Checked;
			c(ref A_0);
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
		{
			bool A_2 = default(bool);
			d(ref A_2);
			if (!A_2)
			{
				base.DialogResult = DialogResult.OK;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c5.m_av, this.m_ay, a1, i6.a(this), "DialogMeasReport.ButtonOK_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(ref bool A_0)
	{
		if (!c())
		{
			A_0 = true;
			return;
		}
		this.m_ax = new ek();
		DateTime.TryParse(m().Text, out this.m_aw.b);
		this.m_aw.l(this.m_ax);
		A_0 = false;
	}

	private bool c()
	{
		List<string> list = new List<string>();
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		for (int num = 0; num < invalidFileNameChars.Length; num = checked(num + 1))
		{
			char c10 = invalidFileNameChars[num];
			if (!char.IsControl(c10))
			{
				list.Add(c10.ToString());
			}
		}
		if (!c(this.m_aw.a))
		{
			fe.b(c5.m_av, "'Account' contains invalid charactors. Characters " + string.Join(", ", list.ToArray()) + " are forbidden.", i6.a(s()));
			return false;
		}
		if (string.IsNullOrEmpty(this.m_aw.a))
		{
			fe.b(c5.m_av, "'Account' must be filled in.", i6.a(this));
			return false;
		}
		if (string.IsNullOrEmpty(this.m_aw.e))
		{
			fe.b(c5.m_av, "'Presented To' must be filled in.", i6.a(this));
			return false;
		}
		string A_ = null;
		if (!c(string.Join(", ", list.ToArray()), ref A_))
		{
			fe.b(c5.m_av, A_, i6.a(s()));
			return false;
		}
		DateTime A_2 = DateTime.MinValue;
		if (!c(ref A_2))
		{
			return false;
		}
		return true;
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_aw.e = k().Text.Trim();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c5.m_av, this.m_ay, a1, i6.a(this), "DialogMeasReport.TextBoxPresentTo_TextChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(int[] A_0)
	{
		if (A_0 != null && !cc.cf(ba, A_0))
		{
			ba = cc.cg((int[])ba.Clone(), A_0);
			bb = cc.cf(ba);
		}
	}

	private h4 c(Collection<hc> A_0)
	{
		return A_0[checked(A_0.Count - 1)].cy().ca();
	}

	private string[] c(hc A_0, List<int> A_1, bool A_2, int A_3, string A_4)
	{
		int[] array = A_0.er();
		checked
		{
			int num = array.Length - 1;
			int[] array2 = new int[num + 1];
			array.CopyTo(array2, 0);
			int[] array3 = new int[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				array3[num3] = num3;
			}
			Array.Sort(array2, array3);
			string[] array4 = A_0.es();
			string[] array5 = new string[num + 1];
			int num4 = num;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				array5[num5] = array4[array3[num5]];
			}
			int num6 = 0;
			int num7 = ba.Length - bb;
			string text = null;
			short a_ = global::e.a().DisplaySignificantDigits;
			int num8 = ba.Length + A_3 * 2 + 2;
			if (A_2)
			{
				num8++;
			}
			string[] array6 = new string[num8 - 1 + 1];
			int num9 = ba.Length - 1;
			for (int num10 = 0; num10 <= num9; num10++)
			{
				int num11 = ((!((num10 >= 0) & (num10 < bb))) ? (num10 - bb) : (num10 + num7));
				int num12 = num6;
				int num13 = array2.Length - 1;
				int num14 = num12;
				if (num14 > num13)
				{
					continue;
				}
				int num15 = array2[num14];
				if (num15 != ba[num10])
				{
					array6[num11] = " ";
					continue;
				}
				text = ((num15 == 0) ? Strings.Format(Conversions.ToSingle(array5[num14]), "#.00000") : (((num15 >= 11) & (num15 < 66)) ? cc.cf(Conversions.ToSingle(array5[num14]), num15, A_0.cy().ca(), a_) : ((!cc.cj(num15) || (cc.ch(num15) != cc.m.a && cc.ch(num15) != cc.m.d)) ? array5[num14] : hg.bu(1, iz.e(array5[num14]), A_0.cy().ca(), a_))));
				if (float.TryParse(text, out var result))
				{
					array6[num11] = result.ToString(CultureInfo.InvariantCulture);
				}
				else
				{
					array6[num11] = text;
				}
				num6++;
			}
			int num16 = ba.Length;
			if (A_2)
			{
				array6[ba.Length] = A_0.cy().ca().l();
				num16++;
			}
			string A_5 = null;
			string A_6 = null;
			int num17 = A_3 - 1;
			for (int num18 = 0; num18 <= num17; num18++)
			{
				if (A_0.cy().b3(A_0.cf()).g7() > num18)
				{
					c(((gc)A_0.cy().b3(A_0.cf()).cp[A_1[num18] + 1]).ag(), ref A_5, ref A_6);
					array6[num16 + 2 * num18] = A_5;
					array6[num16 + 2 * num18 + 1] = A_6;
				}
				else
				{
					array6[num16 + 2 * num18] = string.Empty;
					array6[num16 + 2 * num18 + 1] = string.Empty;
				}
			}
			c(A_4, ref A_5, ref A_6);
			array6[num16 + A_3 * 2] = A_5;
			array6[num16 + A_3 * 2 + 1] = A_6;
			return array6;
		}
	}

	private void c(string A_0, ref string A_1, ref string A_2)
	{
		double[] A_3 = null;
		double[] A_4 = null;
		double[] A_5 = null;
		double[] A_6 = new double[1] { 632.7999877929688 };
		checked
		{
			double[] A_7 = new double[A_6.GetUpperBound(0) + 1];
			int A_8 = default(int);
			if (jb.a(A_0, ref A_3, ref A_4, ref A_5, ref A_8) != jb.a.a)
			{
				return;
			}
			bool flag = A_5 != null;
			if (A_8 > 0)
			{
				jf.a(ref A_3, ref A_4, A_8, ref A_6, ref A_7, A_6.GetUpperBound(0) + 1);
				A_1 = A_7[0].ToString("0.0000");
				if (flag)
				{
					jf.a(ref A_3, ref A_5, A_8, ref A_6, ref A_7, A_6.GetUpperBound(0) + 1);
					A_2 = A_7[0].ToString("0.0000");
				}
				else
				{
					A_2 = $"0.0000";
				}
			}
			else
			{
				A_1 = string.Format(0.ToString("0.0000"));
				A_2 = string.Format(0.ToString("0.0000"));
			}
		}
	}

	private bool c(string A_0)
	{
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		for (int num = 0; num < invalidFileNameChars.Length; num = checked(num + 1))
		{
			string value = Conversions.ToString(invalidFileNameChars[num]);
			if (A_0.Contains(value))
			{
				return false;
			}
		}
		return true;
	}

	private bool c(string A_0, ref string A_1)
	{
		foreach (el item in this.m_aw.c)
		{
			if (string.IsNullOrEmpty(item.d()))
			{
				A_1 = "All Sample Names must be filled in.";
				return false;
			}
			if (!c(item.d()))
			{
				A_1 = "'Sample Name' contains invalid charactors. Characters " + A_0 + " are forbidden.";
				return false;
			}
			foreach (em item2 in item.b)
			{
				if (string.IsNullOrEmpty(item2.f()))
				{
					A_1 = "All Location Names must be filled in.";
					return false;
				}
				if (!c(item2.f()))
				{
					A_1 = "'Location Name' contains invalid charactors. Characters " + A_0 + " are forbidden.";
					return false;
				}
			}
		}
		return true;
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			if (!a4)
			{
				d();
				a4 = true;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			c5.m_av.c(fz.b.b, "Error in DialogMeasReport.DialogMeasReport_Activated", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (bc)
				{
					return;
				}
				bc = true;
				if (string.IsNullOrEmpty(o().Text))
				{
					return;
				}
				int num = iz.c(o().Text);
				SuspendLayout();
				if (this.m_aw == null)
				{
					return;
				}
				if (num > 0 && num >= this.m_aw.c.Count && num <= 99)
				{
					try
					{
						p().SuspendLayout();
						int count = this.m_aw.c.Count;
						int num2 = num - 1;
						for (int num3 = count; num3 <= num2; num3++)
						{
							d d10 = new d(a3, a2, this.m_ay, az());
							d10.g().j().Text = "Sample #" + (num3 + 1);
							d10.g().h.c = num3;
							p().Controls.Add(d10.h(), 0, num3);
							this.m_aw.c.Insert(this.m_aw.c.Count, d10.g().h);
						}
						return;
					}
					finally
					{
						p().ResumeLayout();
					}
				}
				if (num > 0 && num < this.m_aw.c.Count && num <= 99)
				{
					if (!fe.b(ref c5.m_av, "Are you sure you want to delete Sample Numbers " + (num + 1) + " to " + this.m_aw.c.Count + "?", "ConfirmBeforeDeleteTitle", "Yes", "No", i6.a(this)))
					{
						return;
					}
					try
					{
						p().SuspendLayout();
						int num4 = this.m_aw.c.Count - 1;
						int num5 = num;
						for (int num6 = num4; num6 >= num5; num6 += -1)
						{
							p().Controls.RemoveAt(num6);
							this.m_aw.c.RemoveAt(num6);
						}
						return;
					}
					finally
					{
						p().ResumeLayout();
					}
				}
				fe.b(c5.m_av, "The number of Samples must be between 1 and " + 99 + ".", i6.a(this));
				o().Text = this.m_aw.c.Count.ToString();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(c5.m_av, this.m_ay, a1, i6.a(this), "DialogMeasReport.ButtonApply_Click", a_);
				ProjectData.ClearProjectError();
			}
			finally
			{
				ResumeLayout();
				bc = false;
			}
		}
	}

	private void d(ek A_0)
	{
		checked
		{
			for (int num = A_0.c.Count - 1; num >= 0; num += -1)
			{
				for (int num2 = A_0.c[num].b.Count - 1; num2 >= 0; num2 += -1)
				{
					for (int num3 = A_0.c[num].b[num2].b.Count - 1; num3 >= 0; num3 += -1)
					{
						en en2 = A_0.c[num].b[num2].b[num3];
						if (!en2.k() && !en2.l())
						{
							A_0.c[num].b[num2].b.RemoveAt(num3);
						}
					}
				}
			}
		}
	}

	private void c(ek A_0)
	{
		CultureInfo currentCulture = null;
		checked
		{
			try
			{
				int num = 0;
				int num2 = 1;
				string[] array = null;
				Collection<string[]> collection = new Collection<string[]>();
				CultureInfo currentCulture2 = new CultureInfo("en-US");
				DateTime A_1 = default(DateTime);
				try
				{
					ad().Enabled = false;
					if (!c(ref A_1))
					{
						return;
					}
				}
				finally
				{
					ad().Enabled = true;
				}
				string A_2 = null;
				string A_3 = null;
				c(A_0.a, A_1, ref A_2, ref A_3);
				string text = A_2 + "\\" + A_3;
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				Collection<ek.b> a_ = A_0.p();
				A_0.l(text + "\\Recipes.txt", a_);
				A_0.m(text);
				A_0.l(text, a_, i6.a(this), c5.m_av, hg.b4());
				A_0.n(text);
				Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
				currentCulture = Thread.CurrentThread.CurrentCulture;
				Thread.CurrentThread.CurrentCulture = currentCulture2;
				string text2 = i3.i() + "\\MeasReport2.xlt";
				if (this.m_ay.ui())
				{
					if (!this.m_ay.ub())
					{
						string text3;
						string text4;
						if (!File.Exists(text2))
						{
							text3 = "is missing";
							text4 = null;
						}
						else
						{
							text3 = "may be out of date";
							text4 = "newest ";
						}
						fe.b(c5.m_av, "Measurement report template file:\r\n\r\n" + text2 + "\r\n\r\n" + text3 + ". You must have a valid AutoUpdate license installed in order to receive\r\nthe " + text4 + "measurement report template file.", i6.a(this));
						return;
					}
					if (!File.Exists(text2))
					{
						fe.b(c5.m_av, "Measurement report template file:\r\n\r\n" + text2 + "\r\n\r\nis missing. Contact the software group for assistance.", i6.a(this));
						return;
					}
				}
				if (!File.Exists(text2))
				{
					fe.b(c5.m_av, "Measurement report template file:\r\n\r\n" + text2 + "\r\n\r\nis missing. Contact Filmetrics assistance.", i6.a(this));
					return;
				}
				Workbook workbook = application.Workbooks.Open(text2, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				_ = (Worksheet)workbook.Worksheets[1];
				application.DisplayAlerts = false;
				Worksheet worksheet = (Worksheet)workbook.Worksheets[1];
				Worksheet worksheet2 = (Worksheet)workbook.Worksheets[2];
				((_Worksheet)worksheet).get_Range((object)"B12", RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)DateTime.Now.ToString("yyyy-MMM-d"));
				((_Worksheet)worksheet).get_Range((object)"B13", RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)A_0.e);
				int num3 = A_0.a.LastIndexOf("-");
				string a_2 = ((num3 == -1) ? A_0.a : ((!Versioned.IsNumeric(A_0.a.Substring(num3))) ? A_0.a : A_0.a.Substring(0, num3)));
				((_Worksheet)worksheet).get_Range((object)"B14", RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)a_2);
				Collection<hc> collection2 = new Collection<hc>();
				int num4 = A_0.c.Count - 1;
				bool flag = default(bool);
				int num10 = default(int);
				for (int num5 = 0; num5 <= num4; num5++)
				{
					int num6 = A_0.c[num5].b.Count - 1;
					for (int num7 = 0; num7 <= num6; num7++)
					{
						int num8 = A_0.c[num5].b[num7].b.Count - 1;
						for (int num9 = 0; num9 <= num8; num9++)
						{
							en en2 = A_0.c[num5].b[num7].b[num9];
							if (en2.b != null && en2.k())
							{
								collection2.Add(en2.b);
								if (!flag)
								{
									num10 = unchecked((int)en2.b.cy().ca().e());
								}
								flag = true;
							}
							en2 = null;
						}
					}
				}
				bool flag2 = false;
				int num11 = 0;
				List<int> list = new List<int>();
				List<int> list2 = new List<int>();
				List<int> list3 = new List<int>();
				int num12 = collection2.Count - 1;
				for (int num13 = 0; num13 <= num12; num13++)
				{
					unchecked
					{
						if (collection2[num13] != null)
						{
							flag2 = num10 != (int)collection2[num13].cy().ca().e();
							if (collection2[num13].er() == null)
							{
								Thread.CurrentThread.CurrentCulture = currentCulture;
								collection2[num13].cf(A_0: true, (a4.a)global::e.a().ShowSpectrumCoordOption, global::e.a().AlwayShowSpectrumCoordXYZ, A_3: false);
								Thread.CurrentThread.CurrentCulture = currentCulture2;
							}
							c(collection2[num13].er());
						}
					}
				}
				int num14 = bb;
				int num15 = ba.Length - 1;
				for (int num16 = num14; num16 <= num15; num16++)
				{
					if (ba[num16] > 1000 && cc.ch(ba[num16]) == cc.m.a)
					{
						num11++;
						list.Add(cc.cf(ba[num16]));
					}
				}
				int num17 = bb;
				int num18 = ba.Length - 1;
				int num20 = default(int);
				int num21 = default(int);
				for (int num19 = num17; num19 <= num18; num19++)
				{
					if (ba[num19] > 1000 && cc.ch(ba[num19]) == cc.m.b && list.Contains(cc.cf(ba[num19])))
					{
						list2.Add(cc.cf(ba[num19]));
						num20++;
					}
					if (ba[num19] > 1000 && cc.ch(ba[num19]) == cc.m.c && list.Contains(cc.cf(ba[num19])))
					{
						list3.Add(cc.cf(ba[num19]));
						num21++;
					}
				}
				bool[,] array2 = new bool[collection2.Count - 1 + 1, list.Count - 1 + 1];
				bool[,] array3 = new bool[collection2.Count - 1 + 1, list.Count - 1 + 1];
				bool[] array4 = new bool[list.Count - 1 + 1];
				bool[] array5 = new bool[list.Count - 1 + 1];
				bool[] array6 = new bool[list.Count - 1 + 1];
				bool[] array7 = new bool[list.Count - 1 + 1];
				int num22 = collection2.Count - 1;
				for (int num23 = 0; num23 <= num22; num23++)
				{
					hc hc2 = collection2[num23];
					eo obj = hc2.cy().dh();
					bool a_3 = obj.ax(hc2.c0());
					eo.b a_4 = obj.at(hc2.c0(), hc2.cn().af());
					_ = null;
					hi hi2 = hc2.cy().b3(hc2.cf());
					int num24 = list.Count - 1;
					for (int num25 = 0; num25 <= num24; num25++)
					{
						if (list[num25] <= hi2.g7())
						{
							gc obj2 = hi2.eu(list[num25]);
							if (obj2.ah(a_3))
							{
								array2[num23, num25] = true;
							}
							if (obj2.aj(a_3))
							{
								array3[num23, num25] = true;
							}
							if (!obj2.af(a_4))
							{
								array2[num23, num25] = true;
								array3[num23, num25] = true;
							}
							_ = null;
						}
						else
						{
							array2[num23, num25] = true;
							array3[num23, num25] = true;
						}
					}
					hi2 = null;
				}
				int num26 = 0;
				int num27 = list.Count - 1;
				for (int num28 = 0; num28 <= num27; num28++)
				{
					bool flag3 = false;
					int num29 = collection2.Count - 1;
					for (int num30 = 0; num30 <= num29; num30++)
					{
						if (!array2[num30, num28])
						{
							flag3 = true;
							break;
						}
					}
					if (!flag3)
					{
						num26++;
						array4[num28] = true;
					}
				}
				int num31 = list.Count - 1;
				for (int num32 = 0; num32 <= num31; num32++)
				{
					bool flag4 = false;
					int num33 = collection2.Count - 1;
					for (int num34 = 0; num34 <= num33; num34++)
					{
						if (array2[num34, num32])
						{
							flag4 = true;
							break;
						}
					}
					array6[num32] = !flag4;
				}
				int num35 = list.Count - 1;
				for (int num36 = 0; num36 <= num35; num36++)
				{
					bool flag3 = false;
					int num37 = collection2.Count - 1;
					for (int num38 = 0; num38 <= num37; num38++)
					{
						if (!array3[num38, num36])
						{
							flag3 = true;
							break;
						}
					}
					if (!flag3)
					{
						num26++;
						array5[num36] = true;
					}
					else
					{
						array7[num36] = true;
					}
				}
				int num39 = list.Count - 1;
				for (int num40 = 0; num40 <= num39; num40++)
				{
					bool flag4 = false;
					int num41 = collection2.Count - 1;
					for (int num42 = 0; num42 <= num41; num42++)
					{
						if (array3[num42, num40])
						{
							flag4 = true;
							break;
						}
					}
					array7[num40] = !flag4;
				}
				int num43 = A_0.c.Count - 1;
				for (int num44 = 0; num44 <= num43; num44++)
				{
					int num45 = A_0.c[num44].b.Count - 1;
					for (int num46 = 0; num46 <= num45; num46++)
					{
						int num47 = A_0.c[num44].b[num46].b.Count - 1;
						for (int num48 = 0; num48 <= num47; num48++)
						{
							en en3 = A_0.c[num44].b[num46].b[num48];
							if (en3.k() && A_0.c[num44].b[num46].b[num48].b != null)
							{
								Thread.CurrentThread.CurrentCulture = currentCulture;
								Collection collection3 = en3.b.cy().b3(en3.b.cf()).el();
								gc gc2 = (gc)collection3[collection3.Count];
								array = c(en3.b, list, flag2, num11, gc2.ag());
								collection.Add(array);
								Thread.CurrentThread.CurrentCulture = currentCulture2;
							}
						}
					}
				}
				int num49 = Conversions.ToInteger(Interaction.IIf(flag2, 1, 0));
				int num50 = bb + num49 + num11 + num20 + num21;
				bool flag5 = default(bool);
				if (collection.Count <= 1)
				{
					flag5 = false;
				}
				else
				{
					int num51 = num11 * 2 - 1 + num50;
					for (int num52 = num50; num52 <= num51; num52++)
					{
						if (flag5)
						{
							break;
						}
						unchecked
						{
							if (checked(num52 - num50) % 2 == 0 && !array4[checked(num52 - num50) / 2] && !array6[checked(num52 - num50) / 2])
							{
								flag5 = true;
								break;
							}
							if (checked(num52 - num50) % 2 == 1 && !array5[checked(num52 - num50) / 2] && !array7[checked(num52 - num50) / 2])
							{
								flag5 = true;
								break;
							}
						}
						int num53 = collection.Count - 1;
						for (int num54 = 0; num54 <= num53; num54++)
						{
							if (num54 + 1 < collection.Count && string.Compare(collection[num54][num52], collection[num54 + 1][num52]) != 0)
							{
								flag5 = true;
								break;
							}
						}
					}
				}
				if (collection.Count > 0 && !flag5)
				{
					string text5 = string.Empty;
					int num55 = ba.Length - bb;
					int num56 = list.Count - 1;
					for (int num57 = 0; num57 <= num56; num57++)
					{
						if (!list2.Contains(list[num57]))
						{
							text5 = text5 + "Layer " + list[num57] + "n= " + collection[0][bb + num55 + 2 * num57] + "\r\n";
						}
						if (!list3.Contains(list[num57]))
						{
							text5 = text5 + "Layer " + list[num57] + "k= " + collection[0][bb + num55 + 2 * num57 + 1] + "\r\n";
						}
					}
					text5 = text5 + "Substrate n= " + collection[0][collection[0].Length - 2] + "\r\n";
					text5 = text5 + "Substrate k= " + collection[0][collection[0].Length - 1] + "\r\n";
					((_Worksheet)worksheet).get_Range((object)"ResultsSummary", RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)((string)((_Worksheet)worksheet).get_Range((object)"ResultsSummary", RuntimeHelpers.GetObjectValue(Missing.Value)).get_Value(RuntimeHelpers.GetObjectValue(Missing.Value)) + "\r\n\r\n" + text5));
				}
				((_Worksheet)worksheet2).get_Range((object)"D11", RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)"Sample");
				((_Worksheet)worksheet2).get_Range((object)"D11", RuntimeHelpers.GetObjectValue(Missing.Value)).BorderAround(RuntimeHelpers.GetObjectValue(Missing.Value), XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, RuntimeHelpers.GetObjectValue(Missing.Value));
				((_Worksheet)worksheet2).get_Range((object)"D11", RuntimeHelpers.GetObjectValue(Missing.Value)).Interior.ColorIndex = 6;
				((_Worksheet)worksheet2).get_Range((object)"E11", RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)"Location");
				((_Worksheet)worksheet2).get_Range((object)"E11", RuntimeHelpers.GetObjectValue(Missing.Value)).BorderAround(RuntimeHelpers.GetObjectValue(Missing.Value), XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, RuntimeHelpers.GetObjectValue(Missing.Value));
				((_Worksheet)worksheet2).get_Range((object)"E11", RuntimeHelpers.GetObjectValue(Missing.Value)).Interior.ColorIndex = 6;
				int num58 = 0;
				if (ba.Length > 0)
				{
					int num59 = bb;
					int num60 = ba.Length - 1;
					for (int num61 = num59; num61 <= num60; num61++)
					{
						string text6 = cc.cg(ba[num61], A_1: true, c(collection2), A_3: true);
						if (flag2 && cc.cn(ba[num61]))
						{
							text6 = text6.Substring(0, text6.IndexOf("(") - 1);
						}
						((_Worksheet)worksheet2).get_Range((object)(c(6 + num61 - bb) + "11"), RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)text6);
						((_Worksheet)worksheet2).get_Range((object)(c(6 + num61 - bb) + "11"), RuntimeHelpers.GetObjectValue(Missing.Value)).BorderAround(RuntimeHelpers.GetObjectValue(Missing.Value), XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, RuntimeHelpers.GetObjectValue(Missing.Value));
						((_Worksheet)worksheet2).get_Range((object)(c(6 + num61 - bb) + "11"), RuntimeHelpers.GetObjectValue(Missing.Value)).Interior.ColorIndex = 6;
						num58++;
					}
					if (flag2)
					{
						((_Worksheet)worksheet2).get_Range((object)(c(6 + num58) + "11"), RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)"Thickness Units");
						((_Worksheet)worksheet2).get_Range((object)(c(6 + num58) + "11"), RuntimeHelpers.GetObjectValue(Missing.Value)).BorderAround(RuntimeHelpers.GetObjectValue(Missing.Value), XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, RuntimeHelpers.GetObjectValue(Missing.Value));
						((_Worksheet)worksheet2).get_Range((object)(c(6 + num58) + "11"), RuntimeHelpers.GetObjectValue(Missing.Value)).Interior.ColorIndex = 6;
						num58++;
					}
					int num62 = 0;
					do
					{
						string a_5 = cc.cg(ba[num62], A_1: true, c(collection2), A_3: true);
						((_Worksheet)worksheet2).get_Range((object)(c(6 + num58 + num62) + "11"), RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)a_5);
						((_Worksheet)worksheet2).get_Range((object)(c(6 + num58 + num62) + "11"), RuntimeHelpers.GetObjectValue(Missing.Value)).BorderAround(RuntimeHelpers.GetObjectValue(Missing.Value), XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, RuntimeHelpers.GetObjectValue(Missing.Value));
						((_Worksheet)worksheet2).get_Range((object)(c(6 + num58 + num62) + "11"), RuntimeHelpers.GetObjectValue(Missing.Value)).Interior.ColorIndex = 6;
						num58++;
						num62++;
					}
					while (num62 <= 0);
					if (flag5)
					{
						int num63 = list.Count - 1;
						for (int num64 = 0; num64 <= num63; num64++)
						{
							if (!array4[num64])
							{
								Range range = ((_Worksheet)worksheet2).get_Range((object)(c(6 + num58) + "11"), RuntimeHelpers.GetObjectValue(Missing.Value));
								object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
								string A_4 = "LayerNominalLeading";
								range.set_Value(objectValue, (object)(string.Format(hu.a(ref A_4), list[num64]) + "n"));
								((_Worksheet)worksheet2).get_Range((object)(c(6 + num58) + "11"), RuntimeHelpers.GetObjectValue(Missing.Value)).BorderAround(RuntimeHelpers.GetObjectValue(Missing.Value), XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, RuntimeHelpers.GetObjectValue(Missing.Value));
								((_Worksheet)worksheet2).get_Range((object)(c(6 + num58) + "11"), RuntimeHelpers.GetObjectValue(Missing.Value)).Interior.ColorIndex = 6;
								num58++;
							}
							if (!array5[num64])
							{
								Range range2 = ((_Worksheet)worksheet2).get_Range((object)(c(6 + num58) + "11"), RuntimeHelpers.GetObjectValue(Missing.Value));
								object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
								string A_4 = "LayerNominalLeading";
								range2.set_Value(objectValue2, (object)(string.Format(hu.a(ref A_4), list[num64]) + "k"));
								((_Worksheet)worksheet2).get_Range((object)(c(6 + num58) + "11"), RuntimeHelpers.GetObjectValue(Missing.Value)).BorderAround(RuntimeHelpers.GetObjectValue(Missing.Value), XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, RuntimeHelpers.GetObjectValue(Missing.Value));
								((_Worksheet)worksheet2).get_Range((object)(c(6 + num58) + "11"), RuntimeHelpers.GetObjectValue(Missing.Value)).Interior.ColorIndex = 6;
								num58++;
							}
						}
						int num65 = 0;
						do
						{
							string a_6 = ((num65 != 0) ? "Substrate k" : "Substrate n");
							((_Worksheet)worksheet2).get_Range((object)(c(6 + num58) + "11"), RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)a_6);
							((_Worksheet)worksheet2).get_Range((object)(c(6 + num58) + "11"), RuntimeHelpers.GetObjectValue(Missing.Value)).BorderAround(RuntimeHelpers.GetObjectValue(Missing.Value), XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, RuntimeHelpers.GetObjectValue(Missing.Value));
							((_Worksheet)worksheet2).get_Range((object)(c(6 + num58) + "11"), RuntimeHelpers.GetObjectValue(Missing.Value)).Interior.ColorIndex = 6;
							num58++;
							num65++;
						}
						while (num65 <= 1);
					}
				}
				int num66 = A_0.c.Count - 1;
				bool flag6 = default(bool);
				bool flag7 = default(bool);
				for (int num67 = 0; num67 <= num66; num67++)
				{
					int num68 = A_0.c[num67].b.Count - 1;
					for (int num69 = 0; num69 <= num68; num69++)
					{
						int num70 = A_0.c[num67].b[num69].b.Count - 1;
						for (int num71 = 0; num71 <= num70; num71++)
						{
							en en4 = A_0.c[num67].b[num69].b[num71];
							if (en4.k())
							{
								((_Worksheet)worksheet2).get_Range((object)("D" + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)A_0.c[num67].d());
								((_Worksheet)worksheet2).get_Range((object)("D" + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).BorderAround(RuntimeHelpers.GetObjectValue(Missing.Value), XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, RuntimeHelpers.GetObjectValue(Missing.Value));
								((_Worksheet)worksheet2).get_Range((object)("E" + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)A_0.c[num67].b[num69].f());
								((_Worksheet)worksheet2).get_Range((object)("E" + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).BorderAround(RuntimeHelpers.GetObjectValue(Missing.Value), XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, RuntimeHelpers.GetObjectValue(Missing.Value));
								if (en4.b != null)
								{
									Thread.CurrentThread.CurrentCulture = currentCulture;
									Collection collection4 = en4.b.cy().b3(en4.b.cf()).el();
									gc gc3 = (gc)collection4[collection4.Count];
									array = c(en4.b, list, flag2, num11, gc3.ag());
									Thread.CurrentThread.CurrentCulture = currentCulture2;
									int num72 = Conversions.ToInteger(Interaction.IIf(flag2, 1, 0));
									int num73 = ba.Length - bb;
									int num74 = num73 - 1;
									for (int num75 = 0; num75 <= num74; num75++)
									{
										((_Worksheet)worksheet2).get_Range((object)(c(6 + num75) + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)array[num75]);
										((_Worksheet)worksheet2).get_Range((object)(c(6 + num75) + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).BorderAround(RuntimeHelpers.GetObjectValue(Missing.Value), XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, RuntimeHelpers.GetObjectValue(Missing.Value));
									}
									if (flag2)
									{
										((_Worksheet)worksheet2).get_Range((object)(c(6 + num73) + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)array[bb + num73]);
										((_Worksheet)worksheet2).get_Range((object)(c(6 + num73) + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).BorderAround(RuntimeHelpers.GetObjectValue(Missing.Value), XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, RuntimeHelpers.GetObjectValue(Missing.Value));
									}
									((_Worksheet)worksheet2).get_Range((object)(c(6 + num73 + num72) + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)array[num73]);
									((_Worksheet)worksheet2).get_Range((object)(c(6 + num73 + num72) + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).BorderAround(RuntimeHelpers.GetObjectValue(Missing.Value), XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, RuntimeHelpers.GetObjectValue(Missing.Value));
									if (flag5)
									{
										int num76 = bb + num72 + num73;
										int num77 = 0;
										int num78 = num11 - 1;
										for (int num79 = 0; num79 <= num78; num79++)
										{
											en4.b.cy().b3(en4.b.cf());
											if (!array4[num79])
											{
												if (array2[num, num79])
												{
													((_Worksheet)worksheet2).get_Range((object)(c(6 + num73 + num72 + 1 + num77) + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)"");
												}
												else
												{
													((_Worksheet)worksheet2).get_Range((object)(c(6 + num73 + num72 + 1 + num77) + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)array[num76 + num79 * 2]);
												}
												((_Worksheet)worksheet2).get_Range((object)(c(6 + num73 + num72 + 1 + num77) + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).BorderAround(RuntimeHelpers.GetObjectValue(Missing.Value), XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, RuntimeHelpers.GetObjectValue(Missing.Value));
												num77++;
											}
											if (!array5[num79])
											{
												if (array3[num, num79])
												{
													((_Worksheet)worksheet2).get_Range((object)(c(6 + num73 + num72 + 1 + num77) + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)"");
												}
												else
												{
													((_Worksheet)worksheet2).get_Range((object)(c(6 + num73 + num72 + 1 + num77) + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)array[num76 + num79 * 2 + 1]);
												}
												((_Worksheet)worksheet2).get_Range((object)(c(6 + num73 + num72 + 1 + num77) + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).BorderAround(RuntimeHelpers.GetObjectValue(Missing.Value), XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, RuntimeHelpers.GetObjectValue(Missing.Value));
												num77++;
											}
										}
										int num80 = num73 + num72 + (num11 * 2 - num26) + 1;
										((_Worksheet)worksheet2).get_Range((object)(c(6 + num80) + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)array[num76 + num11 * 2]);
										((_Worksheet)worksheet2).get_Range((object)(c(6 + num80) + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).BorderAround(RuntimeHelpers.GetObjectValue(Missing.Value), XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, RuntimeHelpers.GetObjectValue(Missing.Value));
										((_Worksheet)worksheet2).get_Range((object)(c(6 + num80 + 1) + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)array[num76 + num11 * 2 + 1]);
										((_Worksheet)worksheet2).get_Range((object)(c(6 + num80 + 1) + (12 + num)), RuntimeHelpers.GetObjectValue(Missing.Value)).BorderAround(RuntimeHelpers.GetObjectValue(Missing.Value), XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, RuntimeHelpers.GetObjectValue(Missing.Value));
									}
								}
								num++;
							}
							if (en4.l())
							{
								Worksheet worksheet3 = (Worksheet)workbook.Worksheets.Add(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
								string text7 = A_0.c[num67].d() + " - " + A_0.c[num67].b[num69].f();
								try
								{
									worksheet3.Name = text7;
								}
								catch (Exception ex2)
								{
									ProjectData.SetProjectError(ex2);
									Exception ex3 = ex2;
									worksheet3.Name = "ScreenShot" + num2;
									ProjectData.ClearProjectError();
								}
								num2++;
								worksheet3.Select(RuntimeHelpers.GetObjectValue(Missing.Value));
								worksheet3.Move(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(workbook.Worksheets[workbook.Worksheets.Count]));
								((_Worksheet)worksheet3).get_Range((object)"A1", RuntimeHelpers.GetObjectValue(Missing.Value)).Font.Size = 14;
								((_Worksheet)worksheet3).get_Range((object)"A1", RuntimeHelpers.GetObjectValue(Missing.Value)).set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), (object)text7);
								Bitmap bitmap = en4.h;
								if (bitmap != null)
								{
									float num81 = 6.5f * bitmap.HorizontalResolution / (float)bitmap.Width;
									float num82 = 6.5f * bitmap.VerticalResolution / (float)bitmap.Height;
									float factor = (float)Interaction.IIf(num81 < num82, num81, num82);
									Clipboard.SetDataObject(bitmap);
									((_Worksheet)worksheet3).get_Range((object)"A2", RuntimeHelpers.GetObjectValue(Missing.Value)).Select();
									worksheet3.Paste(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
									if (worksheet3.Shapes.Count > 0)
									{
										worksheet3.Shapes.Item(1).ScaleWidth(factor, MsoTriState.msoTrue, RuntimeHelpers.GetObjectValue(Missing.Value));
										worksheet3.Shapes.Item(1).ScaleHeight(factor, MsoTriState.msoTrue, RuntimeHelpers.GetObjectValue(Missing.Value));
									}
								}
							}
							if (en4.k() || en4.l())
							{
								hr hr2 = en4.a;
								if (hr2.cj() == hr.b.n || hr2.cj() == hr.b.o)
								{
									flag6 = true;
								}
								else
								{
									flag7 = true;
								}
								hr2 = null;
							}
						}
					}
				}
				if (!flag6)
				{
					((Worksheet)workbook.Worksheets[4]).Delete();
				}
				if (!flag7)
				{
					((Worksheet)workbook.Worksheets[3]).Delete();
				}
				workbook.Worksheets.Select(1);
				workbook.SaveAs(text + "\\" + A_3 + ".xls", XlFileFormat.xlExcel8, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), XlSaveAsAccessMode.xlNoChange, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				workbook.Close(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				application.Quit();
				fe.b(c5.m_av, "Report and Files have been generated.", "Information", i6.a(ac()), A_4: true);
			}
			catch (COMException ex4) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				ProjectData.SetProjectError(ex4);
				return ex4.ErrorCode == 2147746132u;
			}).Invoke())
			{
				fe.b(c5.m_av, "The measurement report generator requires the full version of Microsoft office.\r\nIt seems that the click-to-run version is currently installed.Contact Filmetrics Information Technology department for assistance to install the regular version.", i6.a(ac()));
				ProjectData.ClearProjectError();
			}
			catch (COMException ex5) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				ProjectData.SetProjectError(ex5);
				return ex5.ErrorCode != 2147746132u;
			}).Invoke())
			{
				fe.b(c5.m_av, "Failed to load Microsoft Excel. It may be missing or not correctly installed.", i6.a(ac()));
				ProjectData.ClearProjectError();
			}
			catch (Exception ex6)
			{
				ProjectData.SetProjectError(ex6);
				Exception a_7 = ex6;
				i5.a(c5.m_av, this.m_ay, a1, i6.a(this), "DialogMeasReport.ButtonCreateMeasReport_Click", a_7);
				ProjectData.ClearProjectError();
			}
			finally
			{
				Thread.CurrentThread.CurrentCulture = currentCulture;
				ad().Enabled = true;
			}
		}
	}
}
