using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class cz : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private ListBox m_b;

	[CompilerGenerated]
	private Label m_c;

	[CompilerGenerated]
	private TableLayoutPanel m_d;

	[CompilerGenerated]
	private Button m_e;

	[CompilerGenerated]
	private Button m_f;

	[CompilerGenerated]
	private TableLayoutPanel m_g;

	private fz h;

	private bool i;

	private f1 j;

	private Guid k;

	private List<it> l;

	private List<it> m;

	private Collection<bool> n;

	private @is o;

	private @is p;

	public cz()
	{
		n = new Collection<bool>();
		o = new @is(@is.a.a);
		p = new @is(@is.a.b);
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
		a(new ListBox());
		a(new Label());
		a(new TableLayoutPanel());
		a(new Button());
		b(new Button());
		b(new TableLayoutPanel());
		d().SuspendLayout();
		g().SuspendLayout();
		SuspendLayout();
		b().Anchor = AnchorStyles.None;
		b().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b().FormattingEnabled = true;
		b().ItemHeight = 16;
		b().Location = new Point(3, 29);
		b().Margin = new Padding(3, 13, 3, 3);
		b().Name = "ListBoxBaselineFile";
		b().SelectionMode = SelectionMode.MultiSimple;
		b().Size = new Size(240, 180);
		b().TabIndex = 1;
		c().Anchor = AnchorStyles.None;
		c().AutoSize = true;
		c().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c().Location = new Point(29, 0);
		c().Name = "LabelText";
		c().Size = new Size(187, 16);
		c().TabIndex = 2;
		c().Text = "Select Baseline files for Import";
		d().Anchor = AnchorStyles.None;
		d().AutoSize = true;
		d().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		d().ColumnCount = 2;
		d().ColumnStyles.Add(new ColumnStyle());
		d().ColumnStyles.Add(new ColumnStyle());
		d().Controls.Add(e(), 0, 0);
		d().Controls.Add(f(), 1, 0);
		d().Location = new Point(46, 215);
		d().Name = "TableLayoutPanel2";
		d().RowCount = 1;
		d().RowStyles.Add(new RowStyle());
		d().Size = new Size(154, 36);
		d().TabIndex = 6;
		e().Anchor = AnchorStyles.None;
		e().AutoSize = true;
		e().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		e().Location = new Point(3, 3);
		e().Margin = new Padding(3, 3, 6, 3);
		e().Name = "ButtonOK";
		e().Size = new Size(68, 30);
		e().TabIndex = 3;
		e().Text = "OK";
		e().UseVisualStyleBackColor = true;
		f().Anchor = AnchorStyles.None;
		f().AutoSize = true;
		f().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		f().DialogResult = DialogResult.Cancel;
		f().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		f().Location = new Point(83, 3);
		f().Margin = new Padding(6, 3, 3, 3);
		f().Name = "ButtonCancel";
		f().Size = new Size(68, 30);
		f().TabIndex = 4;
		f().Text = "Cancel";
		f().UseVisualStyleBackColor = true;
		g().AutoSize = true;
		g().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		g().ColumnCount = 1;
		g().ColumnStyles.Add(new ColumnStyle());
		g().Controls.Add(d(), 0, 2);
		g().Controls.Add(c(), 0, 0);
		g().Controls.Add(b(), 0, 1);
		g().Location = new Point(3, 12);
		g().Name = "TableLayoutPanel1";
		g().RowCount = 3;
		g().RowStyles.Add(new RowStyle());
		g().RowStyles.Add(new RowStyle());
		g().RowStyles.Add(new RowStyle());
		g().Size = new Size(246, 254);
		g().TabIndex = 5;
		base.AcceptButton = e();
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = f();
		base.ClientSize = new Size(271, 285);
		base.Controls.Add(g());
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogBaselineSelectFiles";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Baseline File Import";
		d().ResumeLayout(performLayout: false);
		d().PerformLayout();
		g().ResumeLayout(performLayout: false);
		g().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ListBox b()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ListBox A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel d()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
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
	internal virtual void a(Button A_0)
	{
		EventHandler value = a;
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
	internal virtual Button f()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
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

	public void a(fz A_0, string A_1, f1 A_2, Guid A_3, bool A_4, bool A_5, Point A_6)
	{
		h = A_0;
		i = A_4;
		j = A_2;
		k = A_3;
		l = j.up(k);
		m = j.tc(k);
		string text;
		if (A_4)
		{
			text = A_1;
		}
		else
		{
			text = @is.b();
			Text = "Baseline File Export";
			c().Text = "Select Baseline files for Export";
		}
		if (Directory.Exists(text))
		{
			DirectoryInfo a_ = new DirectoryInfo(text);
			a(text, a_, l, o);
			a(text, a_, m, p);
		}
		if (b().Items.Count > 0)
		{
			ShowDialog();
			return;
		}
		if (i)
		{
			fe.b(h, "There are no suitable Baseline data files in\r\n" + A_1, A_6);
		}
		else
		{
			fe.b(ref h, "There are no Baseline data files available for Export.", ref A_6);
		}
		base.DialogResult = DialogResult.Cancel;
	}

	private void a(string A_0, DirectoryInfo A_1, List<it> A_2, @is A_3)
	{
		if (A_2 == null)
		{
			return;
		}
		checked
		{
			int num = A_2.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				string searchPattern = "*" + A_2[num2].e() + "*" + A_3.e();
				FileInfo[] files = A_1.GetFiles(searchPattern);
				foreach (FileInfo fileInfo in files)
				{
					string text = "";
					bool flag;
					if (fileInfo.Name.Split('_').Length == 3)
					{
						flag = true;
						text = "<Default>";
					}
					else
					{
						text = fileInfo.Name.Substring(0, fileInfo.Name.LastIndexOf("_"));
						text = text.Substring(text.LastIndexOf("_") + 1);
						flag = false;
					}
					Collection<FileInfo> A_4 = null;
					A_3.b(A_2[num2].e().ToString(), text, A_0, flag, ref A_4);
					if (A_4.Count > 0 && !b().Items.Contains(text))
					{
						b().Items.Add(text);
						n.Add(flag);
					}
				}
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			base.DialogResult = DialogResult.OK;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(h, j, null, i6.a(this), "DialogBaselineSelectFiles.ButtonOK_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	public void a(string A_0)
	{
		new Collection<string>();
		new Collection<string>();
		string a_;
		string text;
		if (i)
		{
			a_ = A_0;
			text = @is.b();
		}
		else
		{
			string obj = A_0 + "\\";
			a_ = @is.b();
			text = obj;
		}
		foreach (object selectedIndex in b().SelectedIndices)
		{
			int index = Conversions.ToInteger(selectedIndex);
			string text2 = b().Items[index].ToString();
			Collection<FileInfo> A_1 = null;
			Collection<FileInfo> A_2 = null;
			o.b(text2, a_, n[index], l, ref A_1);
			o.b(text2, text, n[index], l, ref A_2);
			if (a(A_1, A_2, text2, i, text))
			{
				o.b(A_1, text);
			}
			A_1 = null;
			A_2 = null;
			p.b(text2, a_, n[index], m, ref A_1);
			p.b(text2, text, n[index], m, ref A_2);
			if (a(A_1, A_2, text2, i, text))
			{
				p.b(A_1, text);
			}
		}
	}

	private bool a(Collection<FileInfo> A_0, Collection<FileInfo> A_1, string A_2, bool A_3, string A_4)
	{
		string text = a(A_0);
		string text2 = a(A_1);
		if (A_1.Count == 0)
		{
			return true;
		}
		string text3 = "";
		text3 = ((!A_3) ? "Export target folder already contains Baseline" : (global::c.d().Info.Title + " Baseline data folder already contains"));
		string a_ = text3 + " data named '" + A_2 + "'.\r\n\r\nWould you like to replace the existing data dated\r\n[" + text2 + "]\r\n\r\nwith data dated as shown below?\r\n[" + text + "]";
		SystemSounds.Exclamation.Play();
		if (fe.b(ref h, a_, "Warning", "Yes", "No", i6.a(this)))
		{
			return true;
		}
		return false;
	}

	private string a(Collection<FileInfo> A_0)
	{
		if (A_0.Count == 0)
		{
			return string.Empty;
		}
		DateTime lastWriteTime = A_0[0].LastWriteTime;
		DateTime lastWriteTime2 = A_0[0].LastWriteTime;
		foreach (FileInfo item in A_0)
		{
			if (DateTime.Compare(item.LastWriteTime, lastWriteTime2) > 0)
			{
				lastWriteTime2 = item.LastWriteTime;
			}
			if (DateTime.Compare(item.LastWriteTime, lastWriteTime) < 0)
			{
				lastWriteTime = item.LastWriteTime;
			}
		}
		if (i3.a(lastWriteTime, lastWriteTime2))
		{
			return lastWriteTime.ToString() + " to " + lastWriteTime2.ToString();
		}
		return lastWriteTime.ToString();
	}
}
