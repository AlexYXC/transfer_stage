using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Filmetrics.FIMatFileDBService;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class c3 : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Label m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private TableLayoutPanel m_e;

	[CompilerGenerated]
	private TableLayoutPanel m_f;

	[CompilerGenerated]
	private DataGridView m_g;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_h;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_i;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_j;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_k;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_l;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_m;

	private fz n;

	private f1 o;

	private f4 p;

	private string q;

	private LicenseLevel r;

	private string s;

	private eb.b t;

	private Collection<dj.a> u;

	private bool v;

	private bool w;

	public c3()
	{
		base.Activated += b;
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
		a(new Label());
		a(new Button());
		b(new Button());
		a(new TableLayoutPanel());
		a(new DataGridView());
		a(new DataGridViewTextBoxColumn());
		b(new DataGridViewTextBoxColumn());
		c(new DataGridViewTextBoxColumn());
		d(new DataGridViewTextBoxColumn());
		e(new DataGridViewTextBoxColumn());
		f(new DataGridViewTextBoxColumn());
		b(new TableLayoutPanel());
		e().SuspendLayout();
		((ISupportInitialize)g()).BeginInit();
		f().SuspendLayout();
		SuspendLayout();
		b().AutoSize = true;
		b().Location = new Point(3, 0);
		b().Name = "Label1";
		b().Size = new Size(149, 16);
		b().TabIndex = 1;
		b().Text = "Available File Versions:";
		c().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c().Location = new Point(3, 3);
		c().Name = "ButtonGetVersion";
		c().Size = new Size(106, 29);
		c().TabIndex = 2;
		c().Text = "Get File...";
		c().UseVisualStyleBackColor = true;
		d().DialogResult = DialogResult.Cancel;
		d().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		d().Location = new Point(115, 3);
		d().Name = "ButtonClose";
		d().Size = new Size(106, 29);
		d().TabIndex = 3;
		d().Text = "Close";
		d().UseVisualStyleBackColor = true;
		e().AutoSize = true;
		e().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		e().ColumnCount = 1;
		e().ColumnStyles.Add(new ColumnStyle());
		e().Controls.Add(g(), 0, 1);
		e().Controls.Add(f(), 0, 2);
		e().Controls.Add(b(), 0, 0);
		e().Location = new Point(0, 0);
		e().Name = "TableLayoutPanel1";
		e().RowCount = 3;
		e().RowStyles.Add(new RowStyle());
		e().RowStyles.Add(new RowStyle());
		e().RowStyles.Add(new RowStyle());
		e().Size = new Size(675, 132);
		e().TabIndex = 4;
		g().AllowUserToAddRows = false;
		g().AllowUserToDeleteRows = false;
		g().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		g().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		g().Columns.AddRange(h(), i(), j(), k(), l(), m());
		g().Location = new Point(3, 19);
		g().Name = "DataGridViewVersions";
		g().ReadOnly = true;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
		g().RowsDefaultCellStyle = dataGridViewCellStyle2;
		g().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		g().ShowCellToolTips = false;
		g().ShowEditingIcon = false;
		g().Size = new Size(669, 62);
		g().TabIndex = 5;
		h().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		h().HeaderText = "Event Date";
		h().Name = "EventDate";
		h().ReadOnly = true;
		h().Width = 99;
		i().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		i().HeaderText = "Release Level";
		i().Name = "ReleaseLevel";
		i().ReadOnly = true;
		i().Width = 121;
		j().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		j().HeaderText = "User Name";
		j().Name = "UserName";
		j().ReadOnly = true;
		j().Width = 102;
		k().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		k().HeaderText = "Data Modified Date";
		k().Name = "ModDate";
		k().ReadOnly = true;
		k().Width = 149;
		l().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		l().HeaderText = "File Ext";
		l().Name = "FileExt";
		l().ReadOnly = true;
		l().Width = 76;
		m().HeaderText = "Event ID";
		m().Name = "EventID";
		m().ReadOnly = true;
		m().Visible = false;
		m().Width = 83;
		f().Anchor = AnchorStyles.None;
		f().AutoSize = true;
		f().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		f().ColumnCount = 2;
		f().ColumnStyles.Add(new ColumnStyle());
		f().ColumnStyles.Add(new ColumnStyle());
		f().Controls.Add(c(), 0, 0);
		f().Controls.Add(d(), 1, 0);
		f().Location = new Point(225, 94);
		f().Margin = new Padding(3, 10, 3, 3);
		f().Name = "TableLayoutPanel2";
		f().RowCount = 1;
		f().RowStyles.Add(new RowStyle());
		f().Size = new Size(224, 35);
		f().TabIndex = 5;
		base.AcceptButton = d();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = d();
		base.ClientSize = new Size(892, 567);
		base.Controls.Add(e());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogMatDBHistory";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Online Material Database File History";
		e().ResumeLayout(performLayout: false);
		e().PerformLayout();
		((ISupportInitialize)g()).EndInit();
		f().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label b()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_b = A_0;
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
	internal virtual TableLayoutPanel e()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_e = A_0;
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
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridView g()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridView A_0)
	{
		EventHandler value = a;
		DataGridView dataGridView = this.m_g;
		if (dataGridView != null)
		{
			dataGridView.SelectionChanged -= value;
		}
		this.m_g = A_0;
		dataGridView = this.m_g;
		if (dataGridView != null)
		{
			dataGridView.SelectionChanged += value;
		}
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
	internal virtual DataGridViewTextBoxColumn i()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(DataGridViewTextBoxColumn A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn j()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(DataGridViewTextBoxColumn A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn k()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(DataGridViewTextBoxColumn A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn l()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(DataGridViewTextBoxColumn A_0)
	{
		this.m_l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn m()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(DataGridViewTextBoxColumn A_0)
	{
		this.m_m = A_0;
	}

	public void a(fz A_0, f1 A_1, f4 A_2, string A_3, eb.b A_4, string A_5, Point A_6, ref bool A_7)
	{
		dj obj = new dj();
		n = A_0;
		o = A_1;
		p = A_2;
		q = A_3;
		t = A_4;
		s = A_5;
		v = false;
		w = false;
		bool A_8 = default(bool);
		obj.a(A_3, A_4, A_5, A_6, ref r, ref u, ref A_8);
		if (obj.DialogResult == DialogResult.Cancel)
		{
			return;
		}
		string text = u[0].d;
		bool flag = true;
		foreach (dj.a item in u)
		{
			if (string.Compare(item.d, text, ignoreCase: true) != 0)
			{
				flag = false;
				break;
			}
		}
		g().Rows.Add(u.Count);
		checked
		{
			int num = u.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				dj.a a10 = u[num2];
				g().Rows[num2].Cells[0].Value = a10.a.ToString("G");
				g().Rows[num2].Cells[1].Value = eb.a(a10.c);
				g().Rows[num2].Cells[2].Value = a10.f;
				g().Rows[num2].Cells[3].Value = a10.e.ToString("G");
				g().Rows[num2].Cells[4].Value = a10.d;
				g().Rows[num2].Cells[5].Value = a10.b;
				a10 = null;
			}
			g().Columns[4].Visible = !flag;
			Text = Text + " - " + A_5;
			if (flag)
			{
				Text += text;
			}
			ShowDialog();
			A_7 = v;
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				int num = g().SelectedRows.Count - 1;
				bool A_4 = default(bool);
				bool A_5 = default(bool);
				for (int num2 = 0; num2 <= num; num2++)
				{
					int a_ = Conversions.ToInteger(g().SelectedRows[num2].Cells[5].Value);
					string text = g().SelectedRows[num2].Cells[4].Value.ToString();
					string text2 = s + "-" + a_ + text;
					bool a_2 = jb.m(text);
					fz a_3 = n;
					f1 a_4 = o;
					f4 a_5 = p;
					bool a_6 = r != LicenseLevel.Unlicensed;
					LicenseLevel a_7 = r;
					string a_8 = text2;
					eb.b a_9 = t;
					Point a_10 = i6.a(c());
					eb.a A_2 = eb.a.a;
					bool A_3 = false;
					text2 = jb.a(a_3, a_4, a_5, a_6, a_7, A_5: true, A_6: true, A_7: true, A_8: true, A_9: true, a_8, a_9, text, A_13: true, a_2, a_10, ref A_2, ref A_3, ref A_4);
					if (string.IsNullOrEmpty(text2))
					{
						break;
					}
					new di().a(q, t, s, a_, text2, i6.a(c()), ref A_5);
					if (!A_5)
					{
						fe.b(n, "Failed to get file.", i6.a(c()));
						break;
					}
					v = true;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_11 = ex2;
				i5.a(n, o, p, i6.a(c()), "DialogMatDBRecoverFile.ButtonGetVersion_Click", a_11);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (w)
				{
					return;
				}
				w = true;
				DataGridView dataGridView = g();
				if (u.Count > 0)
				{
					int num = dataGridView.Rows[0].Height + 3;
					int num2 = u.Count;
					if (num2 > 20)
					{
						num2 = 20;
					}
					dataGridView.Rows[0].Selected = true;
					dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
					dataGridView.Height = dataGridView.Rows[0].Height * num2 + num;
					dataGridView.Width = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + dataGridView.RowHeadersWidth + 2;
				}
				dataGridView = null;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(n, o, p, i6.a(this), "DialogMatDBRecoverFile.DialogMatDBHistory_Activated", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			c().Enabled = g().SelectedRows.Count != 0;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(n, o, p, i6.a(this), "DialogMatDBRecoverFile.DataGridViewVersions_SelectionChanged", a_);
			ProjectData.ClearProjectError();
		}
	}
}
