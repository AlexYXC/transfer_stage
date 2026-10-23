using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic.MyServices;

[DesignerGenerated]
internal class bn : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Label m_d;

	[CompilerGenerated]
	private TableLayoutPanel m_e;

	[CompilerGenerated]
	private TableLayoutPanel m_f;

	private const string g = "MeasModConfig.bin";

	private const string h = "_BU";

	private const string i = "MeasModConfig_BU.bin";

	private const string j = "\\Filmetrics\\";

	public bn()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(bn));
		a(new Button());
		b(new Button());
		a(new Label());
		a(new TableLayoutPanel());
		b(new TableLayoutPanel());
		e().SuspendLayout();
		f().SuspendLayout();
		SuspendLayout();
		b().Anchor = AnchorStyles.None;
		b().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		b().Location = new Point(4, 4);
		b().Margin = new Padding(4);
		b().Name = "ButtonRevertSettings";
		b().Size = new Size(177, 32);
		b().TabIndex = 1;
		b().Text = "Revert Settings";
		b().UseVisualStyleBackColor = true;
		c().Anchor = AnchorStyles.None;
		c().DialogResult = DialogResult.Cancel;
		c().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		c().Location = new Point(189, 4);
		c().Margin = new Padding(4);
		c().Name = "ButtonCancel";
		c().Size = new Size(100, 32);
		c().TabIndex = 0;
		c().Text = "Cancel";
		c().UseVisualStyleBackColor = true;
		d().AutoSize = true;
		d().Location = new Point(4, 0);
		d().Margin = new Padding(4, 0, 4, 0);
		d().Name = "LabelMessage";
		d().Size = new Size(391, 240);
		d().TabIndex = 2;
		d().Text = componentResourceManager.GetString("LabelMessage.Text");
		e().AutoSize = true;
		e().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		e().ColumnCount = 1;
		e().ColumnStyles.Add(new ColumnStyle());
		e().Controls.Add(f(), 0, 1);
		e().Controls.Add(d(), 0, 0);
		e().Location = new Point(12, 12);
		e().Margin = new Padding(10);
		e().Name = "TableLayoutPanel1";
		e().RowCount = 2;
		e().RowStyles.Add(new RowStyle());
		e().RowStyles.Add(new RowStyle());
		e().Size = new Size(399, 293);
		e().TabIndex = 3;
		f().Anchor = AnchorStyles.None;
		f().AutoSize = true;
		f().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		f().ColumnCount = 2;
		f().ColumnStyles.Add(new ColumnStyle());
		f().ColumnStyles.Add(new ColumnStyle());
		f().Controls.Add(b(), 0, 0);
		f().Controls.Add(c(), 1, 0);
		f().Location = new Point(53, 250);
		f().Margin = new Padding(3, 10, 3, 3);
		f().Name = "TableLayoutPanel2";
		f().RowCount = 1;
		f().RowStyles.Add(new RowStyle());
		f().Size = new Size(293, 40);
		f().TabIndex = 4;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		base.CancelButton = c();
		base.ClientSize = new Size(459, 306);
		base.Controls.Add(e());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogRevertSettings";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Error Report";
		e().ResumeLayout(performLayout: false);
		e().PerformLayout();
		f().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button b()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = a;
		Button button = this.m_b;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_b = A_0;
		button = this.m_b;
		if (button != null)
		{
			button.Click += value;
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
	internal virtual void b(Button A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label d()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
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

	public void a(string A_0, bool A_1)
	{
		Label label = d();
		string text = string.Empty;
		if (!A_1)
		{
			text = " The\r\nsoftware will exit immediately when you click Revert Settings.";
		}
		label.Text = string.Concat(str2: text + "\r\n\r\n", str0: $"{A_0}\r\n\r\nIf you would like to reset the configuration of the software\r\nback to the initial default settings, click Revert Settings.\r\nIt is sometimes necessary to revert the settings in cases of file\r\ncorruption.", str1: " If you are experiencing an error, you may wish to try\r\nexiting the software and cycling power on the instrument first, to\r\nsee if the error condition can be cleared in this way.\r\n\r\nWarning:\r\nBy clicking Revert Settings all user settings in the software will be \r\ndeleted and replaced with the software default settings.", str3: "Recipes, material files, etc. will not be changed if you click Revert.");
		_ = null;
		if (A_1)
		{
			c().Text = "Close";
		}
		ShowDialog();
	}

	private void a(object A_0, EventArgs A_1)
	{
		string text = i3.o() + "\\MeasModConfig.bin";
		string text2 = i3.o() + "\\MeasModConfig_BU.bin";
		if (File.Exists(text))
		{
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			File.Move(text, text2);
		}
		string A_2 = null;
		a(@is.b(), ref A_2);
		a(A_2, @is.b());
		global::e.a().Reset();
		s.a = true;
		Environment.Exit(0);
	}

	private void a(string A_0, string A_1)
	{
		foreach (object value in Enum.GetValues(typeof(@is.a)))
		{
			@is.a a_ = (@is.a)Conversions.ToInteger(value);
			@is obj = new @is(a_);
			if (obj.g())
			{
				Collection<FileInfo> A_2 = null;
				obj.b(A_0, ref A_2);
				obj.b(A_2, A_1);
			}
		}
	}

	private void a(string A_0, ref string A_1)
	{
		if (A_0.EndsWith("\\"))
		{
			A_0 = A_0.Substring(0, checked(A_0.Length - 1));
		}
		A_1 = A_0 + "_BU";
		FileSystemProxy fileSystem = global::c.e().FileSystem;
		if (fileSystem.DirectoryExists(A_0))
		{
			string newName = new DirectoryInfo(A_0).Name + "_BU";
			if (fileSystem.DirectoryExists(A_1))
			{
				fileSystem.DeleteDirectory(A_1, DeleteDirectoryOption.DeleteAllContents);
			}
			fileSystem.RenameDirectory(A_0, newName);
		}
		fileSystem = null;
	}
}
