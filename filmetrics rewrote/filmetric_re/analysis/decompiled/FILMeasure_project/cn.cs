using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Filmetrics.My;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class cn : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private TableLayoutPanel m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private Label m_e;

	[CompilerGenerated]
	private hy m_f;

	[CompilerGenerated]
	private CheckBox m_g;

	[CompilerGenerated]
	private TextBox m_h;

	[CompilerGenerated]
	private Label m_i;

	[CompilerGenerated]
	private Button m_j;

	[CompilerGenerated]
	private TableLayoutPanel m_k;

	private fz l;

	private f1 m;

	private f4 n;

	private Guid o;

	private bool p;

	private const string q = "DialogBatch";

	public cn()
	{
		base.Load += a;
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
		a(new TableLayoutPanel());
		a(new Button());
		b(new Button());
		a(new Label());
		a(new CheckBox());
		a(new TextBox());
		b(new Label());
		c(new Button());
		b(new TableLayoutPanel());
		a(new hy());
		b().SuspendLayout();
		k().SuspendLayout();
		SuspendLayout();
		b().Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		b().ColumnCount = 2;
		k().SetColumnSpan(b(), 2);
		b().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		b().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		b().Controls.Add(c(), 0, 0);
		b().Controls.Add(d(), 1, 0);
		b().Location = new Point(341, 122);
		b().Margin = new Padding(4);
		b().Name = "TableLayoutPanel1";
		b().RowCount = 1;
		b().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		b().Size = new Size(195, 36);
		b().TabIndex = 0;
		c().Anchor = AnchorStyles.None;
		c().Location = new Point(4, 4);
		c().Margin = new Padding(4);
		c().Name = "ButtonOK";
		c().Size = new Size(89, 28);
		c().TabIndex = 0;
		c().Text = "OK";
		d().Anchor = AnchorStyles.None;
		d().DialogResult = DialogResult.Cancel;
		d().Location = new Point(101, 4);
		d().Margin = new Padding(4);
		d().Name = "ButtonCancel";
		d().Size = new Size(89, 28);
		d().TabIndex = 1;
		d().Text = "Cancel";
		e().Anchor = AnchorStyles.Right;
		e().AutoSize = true;
		e().Location = new Point(106, 6);
		e().Name = "LabelNumAcqSpectra";
		e().Size = new Size(28, 16);
		e().TabIndex = 1;
		e().Text = "{0}:";
		g().Anchor = AnchorStyles.Left;
		g().AutoSize = true;
		g().Location = new Point(137, 31);
		g().Margin = new Padding(0, 3, 3, 3);
		g().Name = "CheckBoxSave";
		g().Size = new Size(149, 20);
		g().TabIndex = 3;
		g().Text = "Save spectra to disk";
		g().UseVisualStyleBackColor = true;
		h().Anchor = AnchorStyles.Left;
		h().Enabled = false;
		h().Location = new Point(137, 57);
		h().Margin = new Padding(0, 3, 3, 3);
		h().Name = "TextBoxPath";
		h().Size = new Size(400, 22);
		h().TabIndex = 4;
		i().Anchor = AnchorStyles.Right;
		i().AutoSize = true;
		i().Location = new Point(3, 60);
		i().Name = "Label2";
		i().Size = new Size(131, 16);
		i().TabIndex = 5;
		i().Text = "Save base filename:";
		j().Anchor = AnchorStyles.Left;
		j().Location = new Point(137, 86);
		j().Margin = new Padding(0, 4, 4, 4);
		j().Name = "ButtonBrowse";
		j().Size = new Size(89, 28);
		j().TabIndex = 6;
		j().Text = "Browse...";
		k().AutoSize = true;
		k().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		k().ColumnCount = 2;
		k().ColumnStyles.Add(new ColumnStyle());
		k().ColumnStyles.Add(new ColumnStyle());
		k().Controls.Add(e(), 0, 0);
		k().Controls.Add(b(), 0, 4);
		k().Controls.Add(f(), 1, 0);
		k().Controls.Add(h(), 1, 2);
		k().Controls.Add(i(), 0, 2);
		k().Controls.Add(j(), 1, 3);
		k().Controls.Add(g(), 1, 1);
		k().Location = new Point(0, 0);
		k().Name = "TableLayoutPanel2";
		k().RowCount = 5;
		k().RowStyles.Add(new RowStyle());
		k().RowStyles.Add(new RowStyle());
		k().RowStyles.Add(new RowStyle());
		k().RowStyles.Add(new RowStyle());
		k().RowStyles.Add(new RowStyle());
		k().Size = new Size(540, 162);
		k().TabIndex = 7;
		f().Anchor = AnchorStyles.Left;
		f().f(A_0: true);
		f().Location = new Point(137, 3);
		f().Margin = new Padding(0, 3, 3, 3);
		f().Name = "TextBoxNum";
		f().e(A_0: false);
		f().Size = new Size(62, 22);
		f().TabIndex = 2;
		base.AcceptButton = c();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = d();
		base.ClientSize = new Size(547, 166);
		base.Controls.Add(k());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogBatch";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Batch Process";
		b().ResumeLayout(performLayout: false);
		k().ResumeLayout(performLayout: false);
		k().PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel b()
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
	internal virtual Button c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = d;
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
	internal virtual Label e()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_e = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual hy f()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(hy A_0)
	{
		this.m_f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox g()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(CheckBox A_0)
	{
		EventHandler value = b;
		CheckBox checkBox = this.m_g;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_g = A_0;
		checkBox = this.m_g;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox h()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TextBox A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label i()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button j()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = c;
		Button button = this.m_j;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_j = A_0;
		button = this.m_j;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel k()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TableLayoutPanel A_0)
	{
		this.m_k = A_0;
	}

	public void a(fz A_0, f1 A_1, f4 A_2, Guid A_3, bool A_4)
	{
		l = A_0;
		m = A_1;
		n = A_2;
		o = A_3;
		p = A_4;
		MySettings mySettings = global::e.a();
		g().Checked = mySettings.LastBatchAcqSaveSetting;
		h().Text = mySettings.LastBatchAcqSaveFilenamePath;
		f().Text = mySettings.LastBatchAcqQuantity.ToString();
		ShowDialog();
		if (base.DialogResult == DialogResult.OK)
		{
			mySettings.LastBatchAcqSaveSetting = g().Checked;
			mySettings.LastBatchAcqSaveFilenamePath = h().Text;
			mySettings.LastBatchAcqQuantity = int.Parse(f().Text);
		}
		mySettings = null;
	}

	private void a(object A_0, CancelEventArgs A_1)
	{
		Collection<string> collection = i3.a(((SaveFileDialog)A_0).FileName, A_1: true, 5);
		bool a_ = collection.Count > 4;
		if (collection.Count > 0)
		{
			A_1.Cancel = !i5.a(l, collection, a_, i6.a(this));
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		int num = 100000;
		int num2 = 1;
		int num3 = 0;
		int num4 = global::e.a().GraphMeasUserDefinedMaxCurves;
		if (!string.IsNullOrEmpty(f().Text))
		{
			num3 = int.Parse(f().Text);
		}
		List<string> list = hr.ag(m.ui(), m.uq(), !m.wq(o).d0().q());
		checked
		{
			if ((num3 < num2) | (num3 > num))
			{
				fz a_ = l;
				string A_2 = "ValuesBetweenFmt3";
				string format = hu.a(ref A_2);
				A_2 = "NumSpectraToAcquire";
				fe.b(a_, string.Format(format, hu.a(ref A_2), num2.ToString(), num.ToString()), i6.a(c()));
			}
			else if (num3 > num4 && !g().Checked && p)
			{
				if (num4 == 1)
				{
					fz a_2 = l;
					string A_2 = "BatchLostSpectraWarningMax1";
					fe.b(a_2, hu.a(ref A_2), i6.a(c()));
				}
				else
				{
					fz a_3 = l;
					string A_2 = "BatchLostSpectraWarningMaxGT1Fmt";
					fe.b(a_3, string.Format(hu.a(ref A_2), num4.ToString()), i6.a(c()));
				}
			}
			else if (g().CheckState == CheckState.Checked)
			{
				if (string.IsNullOrEmpty(Path.GetDirectoryName(h().Text)) || !global::c.e().FileSystem.DirectoryExists(Path.GetDirectoryName(h().Text)))
				{
					fz a_4 = l;
					string A_2 = "ErrorNotFullPathFmt";
					fe.b(a_4, string.Format(hu.a(ref A_2), "\"" + h().Text + "\""), i6.a(c()));
				}
				else if (string.IsNullOrEmpty(Path.GetExtension(h().Text)) || !list.Contains(Path.GetExtension(h().Text).ToLower()))
				{
					string text = string.Empty;
					int num5 = list.Count - 2;
					for (int num6 = 0; num6 <= num5; num6++)
					{
						text += list[num6];
						if (list.Count > 2)
						{
							text += ", ";
						}
					}
					if (list.Count > 1)
					{
						if (list.Count == 2)
						{
							text += " ";
						}
						text += "or ";
					}
					text += list[list.Count - 1];
					fz a_5 = l;
					string A_2 = "ErrorInvalidExtensionFmt2";
					fe.b(a_5, string.Format(hu.a(ref A_2), "\"" + h().Text + "\"", text), i6.a(c()));
				}
				else
				{
					base.DialogResult = DialogResult.OK;
				}
			}
			else
			{
				base.DialogResult = DialogResult.OK;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			b2 b10 = hr.af(m.ui(), m.uq(), !m.wq(o).d0().q());
			SaveFileDialog saveFileDialog2 = saveFileDialog;
			saveFileDialog2.InitialDirectory = i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath);
			saveFileDialog2.FileName = Path.GetFileName(global::e.a().LastBatchAcqSaveFilenamePath);
			saveFileDialog2.FileOk += a;
			saveFileDialog2.OverwritePrompt = false;
			saveFileDialog2.Filter = b10.b();
			if (saveFileDialog2.ShowDialog() == DialogResult.OK)
			{
				h().Text = b10.a(saveFileDialog2.FileName, saveFileDialog2.FilterIndex);
				global::e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(saveFileDialog2.FileName);
			}
			saveFileDialog2 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(l, m, n, i6.a(this), "DialogBatch.ButtonBrowse_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			h().Enabled = g().Checked;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(l, m, n, i6.a(this), "DialogBatch.CheckBoxSave_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		Label label = e();
		string format = label.Text;
		string A_2 = "NumSpectraToAcquire";
		label.Text = string.Format(format, hu.a(ref A_2));
		_ = null;
	}
}
