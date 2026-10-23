using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class fi : Form
{
	private enum a
	{
		a,
		b,
		c
	}

	private class b
	{
		public string a;

		public string b;
	}

	private IContainer m_a;

	[CompilerGenerated]
	private TableLayoutPanel m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private Panel m_e;

	[CompilerGenerated]
	private DataGridView m_f;

	[CompilerGenerated]
	private Label m_g;

	[CompilerGenerated]
	private Label m_h;

	[CompilerGenerated]
	private Label m_i;

	[CompilerGenerated]
	private Label m_j;

	[CompilerGenerated]
	private Label m_k;

	private int m_l;

	private ContextMenuStrip m_m;

	private Collection<a3> m_n;

	private Collection<a3> o;

	private int p;

	private bool q;

	private gz r;

	private eo s;

	private DataGridViewCheckBoxCell t;

	private fz u;

	private f1 v;

	private const string w = "DialogSetupMeasMod";

	public fi()
	{
		base.Shown += b;
		d();
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
	private void d()
	{
		a(new TableLayoutPanel());
		a(new Button());
		b(new Button());
		a(new Panel());
		a(new DataGridView());
		a(new Label());
		b(new Label());
		c(new Label());
		d(new Label());
		e(new Label());
		e().SuspendLayout();
		h().SuspendLayout();
		((ISupportInitialize)i()).BeginInit();
		SuspendLayout();
		e().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		e().ColumnCount = 2;
		e().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		e().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		e().Controls.Add(f(), 0, 0);
		e().Controls.Add(g(), 1, 0);
		e().Location = new Point(734, 375);
		e().Margin = new Padding(4);
		e().Name = "TableLayoutPanel1";
		e().RowCount = 1;
		e().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		e().Size = new Size(195, 36);
		e().TabIndex = 0;
		f().Anchor = AnchorStyles.None;
		f().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f().Location = new Point(4, 4);
		f().Margin = new Padding(4);
		f().Name = "OK_Button";
		f().Size = new Size(89, 28);
		f().TabIndex = 0;
		f().Text = "OK";
		g().Anchor = AnchorStyles.None;
		g().DialogResult = DialogResult.Cancel;
		g().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		g().Location = new Point(101, 4);
		g().Margin = new Padding(4);
		g().Name = "Cancel_Button";
		g().Size = new Size(89, 28);
		g().TabIndex = 1;
		g().Text = "Cancel";
		h().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		h().BorderStyle = BorderStyle.Fixed3D;
		h().Controls.Add(i());
		h().Location = new Point(17, 46);
		h().Margin = new Padding(5);
		h().Name = "PanelGridView";
		h().Size = new Size(912, 296);
		h().TabIndex = 3;
		i().AllowUserToAddRows = false;
		i().AllowUserToDeleteRows = false;
		i().Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		i().BorderStyle = BorderStyle.Fixed3D;
		i().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		i().Location = new Point(5, 5);
		i().Margin = new Padding(5);
		i().Name = "DataGridViewMeasMods";
		i().Size = new Size(932, 282);
		i().TabIndex = 1;
		j().BackColor = SystemColors.ControlDarkDark;
		j().Location = new Point(47, 375);
		j().Name = "LabelLine";
		j().Size = new Size(392, 2);
		j().TabIndex = 4;
		k().AutoSize = true;
		k().Location = new Point(154, 367);
		k().Name = "LabelChannels";
		k().Size = new Size(149, 16);
		k().TabIndex = 5;
		k().Text = "Measurement Channels";
		l().BackColor = SystemColors.ControlDarkDark;
		l().Location = new Point(71, 401);
		l().Name = "LabelLine2";
		l().Size = new Size(368, 2);
		l().TabIndex = 6;
		m().AutoSize = true;
		m().Location = new Point(163, 392);
		m().Name = "LabelDevice";
		m().Size = new Size(91, 16);
		m().TabIndex = 7;
		m().Text = "Device Name";
		n().BackColor = SystemColors.ControlDarkDark;
		n().Location = new Point(505, 367);
		n().Name = "LabelSeperator";
		n().Size = new Size(2, 16);
		n().TabIndex = 8;
		base.AcceptButton = f();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = SystemColors.Control;
		base.CancelButton = g();
		base.ClientSize = new Size(944, 426);
		base.Controls.Add(n());
		base.Controls.Add(m());
		base.Controls.Add(l());
		base.Controls.Add(k());
		base.Controls.Add(j());
		base.Controls.Add(h());
		base.Controls.Add(e());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogSetupMeasMod";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Measurement Channel Configuration";
		e().ResumeLayout(performLayout: false);
		h().ResumeLayout(performLayout: false);
		((ISupportInitialize)i()).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel e()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button f()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = g;
		Button button = this.m_c;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_c = A_0;
		button = this.m_c;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button g()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel h()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Panel A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridView i()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridView A_0)
	{
		DataGridViewCellEventHandler value = b;
		DataGridViewCellEventHandler value2 = a;
		DataGridViewCellMouseEventHandler value3 = a;
		EventHandler value4 = a;
		ScrollEventHandler value5 = a;
		DataGridView dataGridView = this.m_f;
		if (dataGridView != null)
		{
			dataGridView.CellContentClick -= value;
			dataGridView.CellValueChanged -= value2;
			dataGridView.ColumnHeaderMouseClick -= value3;
			dataGridView.CurrentCellDirtyStateChanged -= value4;
			dataGridView.Scroll -= value5;
		}
		this.m_f = A_0;
		dataGridView = this.m_f;
		if (dataGridView != null)
		{
			dataGridView.CellContentClick += value;
			dataGridView.CellValueChanged += value2;
			dataGridView.ColumnHeaderMouseClick += value3;
			dataGridView.CurrentCellDirtyStateChanged += value4;
			dataGridView.Scroll += value5;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label j()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label k()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label l()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label m()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label n()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_k = A_0;
	}

	private void g(object A_0, EventArgs A_1)
	{
		try
		{
			if (a())
			{
				base.DialogResult = DialogResult.OK;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(u, v, null, i6.a(this), "DialogSetupMeasMod.OK_Button_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	public void a(fz A_0, f1 A_1, gz A_2, eo A_3)
	{
		u = A_0;
		v = A_1;
		p = 0;
		q = false;
		r = A_2;
		s = A_3;
		t = new DataGridViewCheckBoxCell();
		t.FalseValue = false;
		t.TrueValue = true;
		t.Value = false;
		t.ValueType = typeof(bool);
		if (this.m_a == null)
		{
			this.m_a = new Container();
		}
		this.m_m = new ContextMenuStrip(this.m_a);
		string A_4 = "EditMeasModName";
		string text = hu.a(ref A_4);
		ToolStripMenuItem value = new ToolStripMenuItem(text, null, f);
		this.m_m.Items.Add(value);
		A_4 = "InsertNewMeasModuleBefore";
		text = hu.a(ref A_4);
		value = new ToolStripMenuItem(text, null, e);
		this.m_m.Items.Add(value);
		A_4 = "InsertNewMeasModuleAfter";
		text = hu.a(ref A_4);
		value = new ToolStripMenuItem(text, null, d);
		this.m_m.Items.Add(value);
		A_4 = "RemoveMeasModule";
		text = hu.a(ref A_4);
		value = new ToolStripMenuItem(text, null, c);
		this.m_m.Items.Add(value);
		h().Dock = DockStyle.None;
		DataGridView dataGridView = i();
		dataGridView.BackgroundColor = BackColor;
		dataGridView.Dock = DockStyle.Fill;
		dataGridView.AllowUserToAddRows = false;
		dataGridView.AllowUserToDeleteRows = false;
		dataGridView.AllowUserToResizeRows = false;
		dataGridView.AllowUserToResizeColumns = false;
		dataGridView.AllowUserToOrderColumns = false;
		dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
		dataGridView.MultiSelect = false;
		dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
		dataGridView.Location = new Point(0, 240);
		foreach (gy item in r.i())
		{
			a(item, i().ColumnCount);
		}
		foreach (gy item2 in r.i())
		{
			foreach (ip.a item3 in item2.ak())
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				dataGridViewRow.HeaderCell.ValueType = typeof(string);
				dataGridViewRow.HeaderCell.Value = item3.w();
				dataGridViewRow.Tag = item3;
				dataGridView.Rows.Add(dataGridViewRow);
			}
			foreach (@in.a item4 in item2.aj())
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				dataGridViewRow.HeaderCell.ValueType = typeof(string);
				dataGridViewRow.HeaderCell.Value = item4.m();
				dataGridViewRow.Tag = item4;
				dataGridView.Rows.Add(dataGridViewRow);
			}
			foreach (h5.a item5 in item2.ai())
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				dataGridViewRow.HeaderCell.ValueType = typeof(string);
				dataGridViewRow.HeaderCell.Value = item5.i();
				dataGridViewRow.Tag = item5;
				dataGridView.Rows.Add(dataGridViewRow);
			}
		}
		foreach (ip.a item6 in r.k())
		{
			DataGridViewRow dataGridViewRow = new DataGridViewRow();
			dataGridViewRow.HeaderCell.ValueType = typeof(string);
			dataGridViewRow.HeaderCell.Value = item6.w();
			dataGridViewRow.Tag = item6;
			dataGridView.Rows.Add(dataGridViewRow);
		}
		foreach (h5.a item7 in r.l())
		{
			DataGridViewRow dataGridViewRow = new DataGridViewRow();
			dataGridViewRow.HeaderCell.ValueType = typeof(string);
			dataGridViewRow.HeaderCell.Value = item7.i();
			dataGridViewRow.Tag = item7;
			dataGridView.Rows.Add(dataGridViewRow);
		}
		dataGridView = null;
		a a_ = fi.a.c;
		this.m_n = new Collection<a3>();
		o = new Collection<a3>();
		int count = i().Columns.Count;
		for (int num = 0; num <= count; num = checked(num + 1))
		{
			if (num == i().Columns.Count)
			{
				a_ = fi.a.a;
			}
			a(num, this, a_);
		}
		ShowDialog();
		if (base.DialogResult == DialogResult.OK)
		{
			b();
		}
	}

	private void a(int A_0, Control A_1, a A_2)
	{
		ToolTip toolTip = new ToolTip();
		toolTip.ShowAlways = true;
		if ((A_2 == fi.a.a) | (A_2 == fi.a.c))
		{
			a3 a10 = new a3(A_0, a3.a.a);
			a3 control = a10;
			string A_3 = "InsertNewMeasModuleBefore";
			toolTip.SetToolTip(control, hu.a(ref A_3));
			a10.Size = new Size(20, 20);
			a10.UseVisualStyleBackColor = true;
			a10.Click += e;
			this.m_n.Add(a10);
			A_1.Controls.Add(a10);
		}
		if ((A_2 == fi.a.b) | (A_2 == fi.a.c))
		{
			a3 a10 = new a3(A_0, a3.a.b);
			a3 control2 = a10;
			string A_3 = "RemoveMeasModule";
			toolTip.SetToolTip(control2, hu.a(ref A_3));
			a10.Size = new Size(20, 20);
			a10.UseVisualStyleBackColor = true;
			a10.Click += c;
			o.Add(a10);
			A_1.Controls.Add(a10);
		}
		c();
	}

	private void a(Control A_0)
	{
		checked
		{
			a3 a10 = this.m_n[this.m_n.Count - 1];
			this.m_n.Remove(a10);
			A_0.Controls.Remove(a10);
			a10 = o[o.Count - 1];
			o.Remove(a10);
			A_0.Controls.Remove(a10);
			c();
		}
	}

	private void c()
	{
		if (!q)
		{
			return;
		}
		checked
		{
			int num = h().Location.X + i().Location.X + i().RowHeadersWidth;
			int num2 = h().Location.X + h().Width;
			int num3 = num;
			int num4 = this.m_n.Count - 1;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				a3 a10 = this.m_n[num5];
				a10.Location = new Point(num3 - p - unchecked(a10.Width / 2), h().Location.Y - 20);
				if ((a10.Location.X + unchecked(a10.Width / 2) < num) | (a10.Location.X + unchecked(a10.Width / 2) > num2))
				{
					a10.Visible = false;
				}
				else
				{
					a10.Visible = true;
				}
				if (num5 < i().Columns.Count)
				{
					num3 += i().Columns[num5].Width;
				}
			}
			num3 = num;
			int num6 = o.Count - 1;
			for (int num7 = 0; num7 <= num6; num7++)
			{
				if (num7 < i().Columns.Count)
				{
					num3 += unchecked(i().Columns[num7].Width / 2);
					a3 a10 = o[num7];
					a10.Location = new Point(num3 - p - unchecked(a10.Width / 2), h().Location.Y - 20);
					if ((a10.Location.X + unchecked(a10.Width / 2) < num) | (a10.Location.X + unchecked(a10.Width / 2) > num2))
					{
						a10.Visible = false;
					}
					else
					{
						a10.Visible = true;
					}
					num3 += unchecked(i().Columns[num7].Width / 2);
				}
			}
			if (o.Count == 1)
			{
				o[0].Enabled = false;
			}
			else if (o.Count > 1)
			{
				o[0].Enabled = true;
			}
			j().Width = h().Right - this.m_n[0].Right + 20;
			j().Left = this.m_n[0].Left;
			j().Top = this.m_n[0].Top - 10;
			k().Left = j().Left + unchecked(checked(j().Width - k().Width) / 2);
			k().Top = j().Top - unchecked(k().Height / 2);
			l().Width = this.m_n[0].Left - i().Left - 20 + unchecked(this.m_n[0].Width / 2);
			l().Left = i().Left + 20;
			l().Top = j().Top;
			m().Left = l().Left + unchecked(checked(l().Width - m().Width) / 2);
			m().Top = k().Top;
			n().Left = j().Left + unchecked(this.m_n[0].Width / 2) - 1;
			n().Top = k().Top;
		}
	}

	private DataGridViewCheckBoxColumn a(string A_0, b A_1)
	{
		DataGridViewCheckBoxColumn obj = new DataGridViewCheckBoxColumn
		{
			HeaderCell = 
			{
				Style = 
				{
					WrapMode = DataGridViewTriState.False
				}
			},
			AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
			TrueValue = true,
			FalseValue = false,
			Name = A_0,
			Tag = A_1
		};
		string A_2 = "RightClickForOptions";
		obj.ToolTipText = hu.a(ref A_2);
		obj.CellTemplate = t;
		return obj;
	}

	private void a(gy A_0, int A_1)
	{
		string a_;
		b b10;
		if (A_0 == null)
		{
			a_ = "Untitled";
			b10 = new b
			{
				a = Guid.NewGuid().ToString(),
				b = string.Empty
			};
		}
		else
		{
			a_ = ((!string.IsNullOrEmpty(A_0.u())) ? A_0.u() : "Untitled");
			b10 = new b();
			b10.b = A_0.u();
			b10.a = A_0.x();
		}
		i().Columns.Insert(A_1, a(a_, b10));
	}

	private void a(int A_0, DataGridView A_1)
	{
		A_1.Columns.RemoveAt(A_0);
	}

	private void b(object A_0, DataGridViewCellEventArgs A_1)
	{
		DataGridViewCheckBoxCell dataGridViewCheckBoxCell = null;
		DataGridViewRow dataGridViewRow = null;
		DataGridViewRow dataGridViewRow2 = null;
		checked
		{
			try
			{
				if (!((A_1.RowIndex >= 0) & (A_1.ColumnIndex >= 0)))
				{
					return;
				}
				bool flag = Conversions.ToBoolean(i().Rows[A_1.RowIndex].Cells[A_1.ColumnIndex].Value);
				int num = i().Rows.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (num2 == A_1.RowIndex)
					{
						continue;
					}
					dataGridViewRow = i().Rows[A_1.RowIndex];
					dataGridViewRow2 = i().Rows[num2];
					if (!(dataGridViewRow.Tag is ip.a) || !(dataGridViewRow2.Tag is ip.a))
					{
						continue;
					}
					ip.a a10 = (ip.a)dataGridViewRow.Tag;
					ip.a a11 = (ip.a)dataGridViewRow2.Tag;
					if (string.Compare(a10.o(), a11.o()) == 0 && a10.l() == a11.l() && a10.u() && a11.u())
					{
						dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)i().Rows[num2].Cells[A_1.ColumnIndex];
						dataGridViewCheckBoxCell.Value = flag;
					}
					else if (string.Compare(a10.p(), a11.p()) == 0)
					{
						dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)i().Rows[num2].Cells[A_1.ColumnIndex];
						if (flag)
						{
							dataGridViewCheckBoxCell.Value = true;
						}
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(u, v, null, i6.a(this), "DialogSetupMeasMod.DataGridViewMeasMods_CellContentClick", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void a(object A_0, DataGridViewCellEventArgs A_1)
	{
		DataGridViewCheckBoxCell dataGridViewCheckBoxCell = null;
		DataGridViewRow dataGridViewRow = null;
		DataGridViewRow dataGridViewRow2 = null;
		checked
		{
			try
			{
				if (!((A_1.RowIndex >= 0) & (A_1.ColumnIndex >= 0)))
				{
					return;
				}
				bool flag = Conversions.ToBoolean(i().Rows[A_1.RowIndex].Cells[A_1.ColumnIndex].Value);
				if (flag)
				{
					int num = i().Columns.Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						if (num2 != A_1.ColumnIndex)
						{
							dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)i().Rows[A_1.RowIndex].Cells[num2];
							dataGridViewCheckBoxCell.Value = false;
						}
					}
				}
				int num3 = i().Rows.Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (num4 == A_1.RowIndex)
					{
						continue;
					}
					dataGridViewRow = i().Rows[A_1.RowIndex];
					dataGridViewRow2 = i().Rows[num4];
					if (!(dataGridViewRow.Tag is ip.a) || !(dataGridViewRow2.Tag is ip.a))
					{
						continue;
					}
					ip.a a10 = (ip.a)dataGridViewRow.Tag;
					ip.a a11 = (ip.a)dataGridViewRow2.Tag;
					if (Operators.CompareString(a11.o(), a10.o(), TextCompare: false) == 0 && a11.l() == a10.l() && a11.u() && a10.u())
					{
						dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)i().Rows[num4].Cells[A_1.ColumnIndex];
						dataGridViewCheckBoxCell.Value = flag;
					}
					else if (!ip.m2(a10.q(), a10.r(), a11.q(), a11.r(), Operators.CompareString(a10.p(), a11.p(), TextCompare: false) == 0))
					{
						dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)i().Rows[num4].Cells[A_1.ColumnIndex];
						if (flag)
						{
							dataGridViewCheckBoxCell.Value = false;
						}
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(u, v, null, i6.a(this), "DialogSetupMeasMod.DataGridViewMeasMods_CellValueChanged", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void a(object A_0, DataGridViewCellMouseEventArgs A_1)
	{
		DataGridViewColumn dataGridViewColumn = null;
		checked
		{
			try
			{
				if (A_1.Button == MouseButtons.Right)
				{
					this.m_l = A_1.ColumnIndex;
					int num = i().RowHeadersWidth;
					int num2 = this.m_l - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						dataGridViewColumn = i().Columns[num3];
						num += dataGridViewColumn.Width;
					}
					this.m_m.Items[3].Enabled = i().Columns.Count > 1;
					this.m_m.Show(i(), num + A_1.X - p, A_1.Y);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(u, v, null, i6.a(this), "DialogSetupMeasMod.DataGridViewMeasMods_ColumnHeaderMouseClick", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		string A_2 = null;
		try
		{
			fz a_ = u;
			string A_3 = "EnterNewNameForMeasModule";
			if (fe.b(a_, hu.a(ref A_3), "EditMeasModule", i6.a(this), ref A_2))
			{
				DataGridViewColumn dataGridViewColumn = i().Columns[this.m_l];
				if (!string.IsNullOrEmpty(A_2))
				{
					dataGridViewColumn.Name = A_2;
					((b)dataGridViewColumn.Tag).b = A_2;
					c();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(u, v, null, i6.a(this), "DialogSetupMeasMod.OnEditMeasModName", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			int a_ = default(int);
			if (Operators.CompareString(A_0.GetType().Name, typeof(ToolStripMenuItem).Name, TextCompare: false) == 0)
			{
				a_ = this.m_l;
			}
			else if (Operators.CompareString(A_0.GetType().Name, typeof(a3).Name, TextCompare: false) == 0)
			{
				a_ = ((a3)A_0).d();
			}
			new b
			{
				a = Guid.NewGuid().ToString(),
				b = string.Empty
			};
			a(null, a_);
			a(checked(i().Columns.Count - 1), this, fi.a.b);
			a(i().Columns.Count, this, fi.a.a);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(u, v, null, i6.a(this), "DialogSetupMeasMod.OnInsertMeasModBefore", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				int a_ = default(int);
				if (Operators.CompareString(A_0.GetType().Name, typeof(ToolStripMenuItem).Name, TextCompare: false) == 0)
				{
					a_ = this.m_l + 1;
				}
				else if (Operators.CompareString(A_0.GetType().Name, typeof(a3).Name, TextCompare: false) == 0)
				{
					a_ = ((a3)A_0).d() + 1;
				}
				a(null, a_);
				a(i().Columns.Count - 1, this, fi.a.b);
				a(i().Columns.Count, this, fi.a.a);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				i5.a(u, v, null, i6.a(this), "DialogSetupMeasMod.OnInsertMeasModAfter", a_2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			string A_2 = "AskRemoveMeasModule";
			if (Interaction.MsgBox(hu.a(ref A_2), MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
			{
				int a_ = default(int);
				if (Operators.CompareString(A_0.GetType().Name, typeof(ToolStripMenuItem).Name, TextCompare: false) == 0)
				{
					a_ = this.m_l;
				}
				else if (Operators.CompareString(A_0.GetType().Name, typeof(a3).Name, TextCompare: false) == 0)
				{
					a_ = ((a3)A_0).d();
				}
				a(a_, i());
				a(this);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(u, v, null, i6.a(this), "DialogSetupMeasMod.OnRemoveMeasMod", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			q = true;
			int num = 0;
			foreach (gy item in r.i())
			{
				foreach (ip.a item2 in item.ak())
				{
					foreach (DataGridViewRow item3 in (IEnumerable)i().Rows)
					{
						if (item3.Tag == item2)
						{
							item3.Cells[num].Value = true;
							break;
						}
					}
				}
				foreach (@in.a item4 in item.aj())
				{
					foreach (DataGridViewRow item5 in (IEnumerable)i().Rows)
					{
						if (item5.Tag == item4)
						{
							item5.Cells[num].Value = true;
							break;
						}
					}
				}
				foreach (h5.a item6 in item.ai())
				{
					foreach (DataGridViewRow item7 in (IEnumerable)i().Rows)
					{
						if (item7.Tag == item6)
						{
							item7.Cells[num].Value = true;
							break;
						}
					}
				}
				num = checked(num + 1);
			}
			c();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(u, v, null, i6.a(this), "DialogSetupMeasMod.DialogSetupMeasMod_Shown", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			i().CommitEdit(DataGridViewDataErrorContexts.Commit);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(u, v, null, i6.a(this), "DialogSetupMeasMod.DataGridViewMeasMods_CurrentCellDirtyStateChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, ScrollEventArgs A_1)
	{
		try
		{
			if (A_1.ScrollOrientation == ScrollOrientation.HorizontalScroll)
			{
				p = A_1.NewValue;
				c();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(u, v, null, i6.a(this), "DialogSetupMeasMod.DataGridViewMeasMods_Scroll", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b()
	{
		int num = 0;
		foreach (gy item in r.i())
		{
			r.g(item);
		}
		checked
		{
			bool A_4 = default(bool);
			foreach (DataGridViewColumn column in i().Columns)
			{
				bool flag = false;
				foreach (gy item2 in r.i())
				{
					if (string.Compare(((b)column.Tag).a, item2.x()) == 0)
					{
						flag = true;
						item2.s(((b)column.Tag).b);
						a(num, item2);
						break;
					}
				}
				if (!flag)
				{
					gy gy2 = new gy(u, gu.a.a.a, new Guid(((b)column.Tag).a), ((b)column.Tag).b, string.Empty);
					string A_ = null;
					string A_2 = null;
					string A_3 = null;
					hg.bu(s, ref A_, ref A_2, ref A_3, ref A_4);
					gy2.s(A_4);
					gy2.u("\\" + i3.d(A_3, hg.b0()));
					if (A_4)
					{
						if (A_2 != null)
						{
							gy2.s(A_0: false);
							gy2.u("\\" + i3.d(A_2, hg.b0()));
						}
					}
					else if (A_ != null)
					{
						gy2.s(A_0: true);
						gy2.u("\\" + i3.d(A_, hg.b0()));
					}
					gy2.s(A_4);
					a(num, gy2);
					r.f(gy2, num);
				}
				num++;
			}
			num = 0;
			Collection<gy> collection = new Collection<gy>();
			foreach (gy item3 in r.i())
			{
				bool flag = false;
				foreach (DataGridViewColumn column2 in i().Columns)
				{
					if (string.Compare(((b)column2.Tag).a, item3.x()) == 0)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					collection.Add(item3);
				}
				num++;
			}
			foreach (gy item4 in collection)
			{
				r.f(item4);
			}
		}
	}

	private void a(int A_0, gy A_1)
	{
		foreach (DataGridViewRow item in (IEnumerable)i().Rows)
		{
			if (Conversions.ToBoolean(item.Cells[A_0].Value))
			{
				if (item.Tag is ip.a)
				{
					r.f(A_1, (ip.a)item.Tag);
				}
				else if (item.Tag is @in)
				{
					r.f(A_1, (@in.a)item.Tag);
				}
				else if (item.Tag is h5.a)
				{
					r.f(A_1, (h5.a)item.Tag);
				}
			}
		}
	}

	private bool a()
	{
		bool flag = true;
		int num = 0;
		Collection<int> collection = new Collection<int>();
		DataGridViewRow dataGridViewRow = null;
		DataGridViewRow dataGridViewRow2 = null;
		checked
		{
			foreach (DataGridViewColumn column in i().Columns)
			{
				_ = column;
				bool flag2 = false;
				foreach (DataGridViewRow item in (IEnumerable)i().Rows)
				{
					if (Conversions.ToBoolean(item.Cells[num].Value))
					{
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					collection.Add(num);
				}
				num++;
			}
			if (collection.Count == i().Columns.Count)
			{
				fz a_ = u;
				string A_ = "MeasModAtLeast1SpecFmt1";
				fe.b(a_, string.Format(hu.a(ref A_), i().Columns[0].Name), i6.a(this));
				flag = false;
			}
			if (flag)
			{
				bool[] array = new bool[i().Rows.Count - 1 + 1];
				int num2 = 0;
				foreach (DataGridViewRow item2 in (IEnumerable)i().Rows)
				{
					array[num2] = true;
					int num3 = i().Rows.Count - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						if (item2.Tag is h5.a || item2.Tag is @in.a || array[num4])
						{
							continue;
						}
						dataGridViewRow2 = i().Rows[num4];
						ip.a a10 = (ip.a)item2.Tag;
						if (dataGridViewRow2.Tag is h5.a || dataGridViewRow2.Tag is @in.a)
						{
							continue;
						}
						ip.a a11 = (ip.a)dataGridViewRow2.Tag;
						int num5 = -1;
						int num6 = -1;
						if (string.Compare(a10.p(), a11.p()) != 0)
						{
							continue;
						}
						array[num4] = true;
						int num7 = i().Columns.Count - 1;
						for (int num8 = 0; num8 <= num7; num8++)
						{
							if (Conversions.ToBoolean(item2.Cells[num8].Value))
							{
								num5 = num8;
							}
							if (Conversions.ToBoolean(dataGridViewRow2.Cells[num8].Value))
							{
								num6 = num8;
							}
						}
						if (num5 != -1 && num6 != -1 && num5 != num6)
						{
							fz a_2 = u;
							string A_ = "CoupledSpecInDiffMeasModFmt2";
							fe.b(a_2, string.Format(hu.a(ref A_), a10.w(), a11.w()), i6.a(this));
							flag = false;
							return flag;
						}
					}
					num2++;
				}
				if (flag)
				{
					string A_ = "Unknown";
					string A_2 = hu.a(ref A_);
					A_ = "Unknown";
					string A_3 = hu.a(ref A_);
					int num9 = i().Columns.Count - 1;
					for (num = 0; num <= num9; num++)
					{
						if (!a(num, ref A_2, ref A_3))
						{
							fz a_3 = u;
							A_ = "IncompatibleSpecInSameMeasModFmt3";
							fe.b(a_3, string.Format(hu.a(ref A_), A_2, A_3, i().Columns[num].Name), i6.a(this));
							return false;
						}
					}
					for (int num10 = collection.Count - 1; num10 >= 0; num10 += -1)
					{
						int a_4 = collection[num10];
						a(a_4, i());
						a(this);
					}
				}
			}
			return flag;
		}
	}

	private bool a(int A_0, [Optional][DefaultParameterValue("Unknown")] ref string A_1, [Optional][DefaultParameterValue("Unknown")] ref string A_2)
	{
		bool result = true;
		checked
		{
			try
			{
				bool[] array = new bool[i().Rows.Count - 1 + 1];
				int num = 0;
				foreach (DataGridViewRow item in (IEnumerable)i().Rows)
				{
					if (item.Tag is h5.a || item.Tag is @in.a)
					{
						continue;
					}
					if (Conversions.ToBoolean(item.Cells[A_0].Value))
					{
						array[num] = true;
						int num2 = i().Rows.Count - 1;
						for (int num3 = 0; num3 <= num2; num3++)
						{
							if (i().Rows[num3].Tag is h5.a || i().Rows[num3].Tag is @in.a || array[num3])
							{
								continue;
							}
							DataGridViewRow dataGridViewRow2 = i().Rows[num3];
							if (Conversions.ToBoolean(dataGridViewRow2.Cells[A_0].Value))
							{
								array[num3] = true;
								ip.a a10 = (ip.a)item.Tag;
								ip.a a11 = (ip.a)dataGridViewRow2.Tag;
								if (item.Index != dataGridViewRow2.Index && (Operators.CompareString(a10.o(), a11.o(), TextCompare: false) != 0 || a10.l() != a11.l() || !a10.u() || !a11.u()) && !ip.m2(a10.q(), a10.r(), a11.q(), a11.r(), Operators.CompareString(a10.p(), a11.p(), TextCompare: false) == 0))
								{
									result = false;
									A_1 = a10.w();
									A_2 = a11.w();
									return result;
								}
							}
						}
					}
					num++;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}
}
