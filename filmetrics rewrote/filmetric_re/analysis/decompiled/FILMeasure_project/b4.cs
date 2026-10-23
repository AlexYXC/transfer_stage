using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class b4 : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private DataGridView m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private Button m_e;

	[CompilerGenerated]
	private TableLayoutPanel m_f;

	[CompilerGenerated]
	private TableLayoutPanel m_g;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_h;

	[CompilerGenerated]
	private DataGridViewCheckBoxColumn m_i;

	private Collection<f3.d> j;

	private Collection<f3.d> k;

	private f1 l;

	private f3 m;

	private fz n;

	private bool o;

	public b4()
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
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		a(new DataGridView());
		a(new Button());
		b(new Button());
		c(new Button());
		a(new TableLayoutPanel());
		b(new TableLayoutPanel());
		a(new DataGridViewTextBoxColumn());
		a(new DataGridViewCheckBoxColumn());
		((ISupportInitialize)b()).BeginInit();
		f().SuspendLayout();
		g().SuspendLayout();
		SuspendLayout();
		b().AllowUserToAddRows = false;
		b().AllowUserToDeleteRows = false;
		b().AllowUserToResizeColumns = false;
		b().AllowUserToResizeRows = false;
		b().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		b().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		b().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		b().Columns.AddRange(h(), i());
		b().Dock = DockStyle.Top;
		b().EditMode = DataGridViewEditMode.EditOnEnter;
		b().Location = new Point(4, 4);
		b().Margin = new Padding(4);
		b().Name = "DGVEditColumns";
		b().RowHeadersVisible = false;
		b().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		b().Size = new Size(215, 450);
		b().TabIndex = 0;
		c().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c().Location = new Point(4, 4);
		c().Margin = new Padding(4);
		c().Name = "ButtonOK";
		c().Size = new Size(100, 30);
		c().TabIndex = 6;
		c().Text = "OK";
		c().UseVisualStyleBackColor = true;
		d().DialogResult = DialogResult.Cancel;
		d().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d().Location = new Point(112, 4);
		d().Margin = new Padding(4);
		d().Name = "ButtonCancel";
		d().Size = new Size(100, 30);
		d().TabIndex = 7;
		d().Text = "Cancel";
		d().UseVisualStyleBackColor = true;
		e().Anchor = AnchorStyles.None;
		e().AutoSize = true;
		e().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		e().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e().Location = new Point(41, 462);
		e().Margin = new Padding(4);
		e().Name = "ButtonRestoreDefault";
		e().Size = new Size(140, 30);
		e().TabIndex = 8;
		e().Text = "Restore Defaults";
		e().UseVisualStyleBackColor = true;
		f().AutoSize = true;
		f().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		f().ColumnCount = 1;
		f().ColumnStyles.Add(new ColumnStyle());
		f().Controls.Add(g(), 0, 2);
		f().Controls.Add(b(), 0, 0);
		f().Controls.Add(e(), 0, 1);
		f().Location = new Point(8, 8);
		f().Margin = new Padding(3, 3, 6, 3);
		f().Name = "TableLayoutPanel1";
		f().RowCount = 3;
		f().RowStyles.Add(new RowStyle());
		f().RowStyles.Add(new RowStyle());
		f().RowStyles.Add(new RowStyle());
		f().Size = new Size(223, 540);
		f().TabIndex = 9;
		g().AutoSize = true;
		g().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		g().ColumnCount = 2;
		g().ColumnStyles.Add(new ColumnStyle());
		g().ColumnStyles.Add(new ColumnStyle());
		g().Controls.Add(c(), 0, 0);
		g().Controls.Add(d(), 1, 0);
		g().Location = new Point(3, 499);
		g().Name = "TableLayoutPanel2";
		g().RowCount = 1;
		g().RowStyles.Add(new RowStyle());
		g().Size = new Size(216, 38);
		g().TabIndex = 10;
		h().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
		h().DefaultCellStyle = dataGridViewCellStyle2;
		h().HeaderText = "Column";
		h().Name = "ClmnHeaderText";
		h().ReadOnly = true;
		h().Width = 78;
		i().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		i().HeaderText = "Show";
		i().Name = "ClmnHide";
		i().SortMode = DataGridViewColumnSortMode.Automatic;
		i().Width = 66;
		base.AcceptButton = c();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = d();
		base.ClientSize = new Size(251, 558);
		base.Controls.Add(f());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogEditResultsGridColumns";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Edit Columns";
		((ISupportInitialize)b()).EndInit();
		f().ResumeLayout(performLayout: false);
		f().PerformLayout();
		g().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridView b()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridView A_0)
	{
		DataGridViewCellEventHandler value = a;
		EventHandler value2 = a;
		DataGridView dataGridView = this.m_b;
		if (dataGridView != null)
		{
			dataGridView.CellValueChanged -= value;
			dataGridView.CurrentCellDirtyStateChanged -= value2;
		}
		this.m_b = A_0;
		dataGridView = this.m_b;
		if (dataGridView != null)
		{
			dataGridView.CellValueChanged += value;
			dataGridView.CurrentCellDirtyStateChanged += value2;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = c;
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
	internal virtual Button d()
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
	internal virtual Button e()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = b;
		Button button = this.m_e;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_e = A_0;
		button = this.m_e;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel f()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel g()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn h()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridViewTextBoxColumn A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewCheckBoxColumn i()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridViewCheckBoxColumn A_0)
	{
		this.m_i = A_0;
	}

	public void a(Collection<f3.d> A_0, f1 A_1, f3 A_2, fz A_3, Point A_4)
	{
		n = A_3;
		l = A_1;
		m = A_2;
		j = A_0;
		k = new Collection<f3.d>();
		f3.d d10 = null;
		foreach (f3.d item in A_0)
		{
			d10 = null;
			item.h(ref d10);
			k.Add(d10);
		}
		a(k);
		i6.a(A_4, this);
		ShowDialog();
	}

	private void a(Collection<f3.d> A_0)
	{
		o = true;
		b().Rows.Clear();
		foreach (f3.d item in A_0)
		{
			b().Rows.Add(a(item));
			if (item.e == f3.d.ResGridColumnType.MMGuid)
			{
				b().Rows[checked(b().Rows.Count - 1)].Visible = false;
			}
		}
		o = false;
	}

	private object[] a(f3.d A_0)
	{
		object[] array = new object[checked(b().Columns.Count - 1 + 1)];
		switch (A_0.e)
		{
		case f3.d.ResGridColumnType.Param:
			array[0] = cc.cg(A_0.f, A_1: false, null, A_3: false);
			break;
		case f3.d.ResGridColumnType.Number:
			array[0] = m.bd().HeaderText;
			break;
		case f3.d.ResGridColumnType.MMGuid:
			array[0] = m.be().HeaderText;
			break;
		case f3.d.ResGridColumnType.Sample:
			array[0] = "Sample";
			break;
		case f3.d.ResGridColumnType.Location:
			array[0] = "Location";
			break;
		case f3.d.ResGridColumnType.Res:
			array[0] = "Res";
			break;
		case f3.d.ResGridColumnType.SS:
			array[0] = "SS";
			break;
		}
		array[1] = !A_0.g;
		return array;
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			j.Clear();
			foreach (f3.d item in k)
			{
				j.Add(item);
			}
			base.DialogResult = DialogResult.OK;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(n, l, null, i6.a(this), "DialogEditResultsGridColumns.ButtonOK_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		f3.d d10 = null;
		f3.d d11 = null;
		foreach (f3.d item in k)
		{
			if (item.e == f3.d.ResGridColumnType.Number)
			{
				d10 = item;
				d10.g = false;
			}
			if (item.e == f3.d.ResGridColumnType.MMGuid)
			{
				d11 = item;
				d11.g = false;
			}
			if (d10 != null && d11 != null)
			{
				break;
			}
		}
		k.Clear();
		if (d10 != null)
		{
			k.Add(d10);
		}
		if (d11 != null)
		{
			k.Add(d11);
		}
		a(k);
	}

	private void a(object A_0, DataGridViewCellEventArgs A_1)
	{
		if (A_1.RowIndex >= 0 && A_1.ColumnIndex >= 0 && !o)
		{
			DataGridViewCell dataGridViewCell = b().Rows[A_1.RowIndex].Cells[A_1.ColumnIndex];
			int columnIndex = A_1.ColumnIndex;
			if (columnIndex == 1)
			{
				bool flag = Conversions.ToBoolean(((DataGridViewCheckBoxCell)dataGridViewCell).Value);
				k[A_1.RowIndex].g = !flag;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		if (b().IsCurrentCellDirty)
		{
			b().CommitEdit(DataGridViewDataErrorContexts.Commit);
		}
	}
}
