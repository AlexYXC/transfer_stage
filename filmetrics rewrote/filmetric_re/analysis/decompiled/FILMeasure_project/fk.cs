using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class fk : Form
{
	public enum a
	{
		a,
		b
	}

	private enum b
	{
		a,
		b,
		c
	}

	private IContainer m_a;

	[CompilerGenerated]
	private TreeView m_b;

	[CompilerGenerated]
	private ImageList m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private Button e;

	private TreeNode f;

	private string g;

	private string h;

	private int i;

	private string m_j;

	private string m_k;

	private string m_l;

	private List<string> m_m;

	private string m_n;

	private bool m_o;

	private bool m_p;

	private string m_q;

	private Collection r;

	private string s;

	private bool t;

	private bool u;

	private a v;

	private string w;

	private fz x;

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_a != null)
		{
			this.m_a.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void a()
	{
		this.m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fk));
		a(new TreeView());
		a(new ImageList(this.m_a));
		a(new Button());
		b(new Button());
		SuspendLayout();
		b().ImageIndex = 0;
		b().ImageList = c();
		b().Location = new Point(4, 5);
		b().MaximumSize = new Size(440, 378);
		b().Name = "TreeView1";
		b().SelectedImageIndex = 0;
		b().Size = new Size(440, 378);
		b().TabIndex = 0;
		c().ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
		c().TransparentColor = Color.Transparent;
		c().Images.SetKeyName(0, "CLOSED.BMP");
		c().Images.SetKeyName(1, "OPEN.BMP");
		c().Images.SetKeyName(2, "LEAF.BMP");
		d().DialogResult = DialogResult.Cancel;
		d().Location = new Point(367, 389);
		d().Name = "ButtonCancel";
		d().Size = new Size(75, 25);
		d().TabIndex = 1;
		d().Text = "Cancel";
		d().UseVisualStyleBackColor = true;
		j().Location = new Point(285, 389);
		j().Name = "ButtonOK";
		j().Size = new Size(75, 25);
		j().TabIndex = 2;
		j().Text = "OK";
		j().UseVisualStyleBackColor = true;
		base.AcceptButton = j();
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = d();
		base.ClientSize = new Size(439, 415);
		base.ControlBox = false;
		base.Controls.Add(j());
		base.Controls.Add(d());
		base.Controls.Add(b());
		MaximumSize = new Size(455, 453);
		base.MinimizeBox = false;
		MinimumSize = new Size(455, 453);
		base.Name = "DialogTreeView";
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.Manual;
		Text = "Recipe Selection";
		base.TopMost = true;
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TreeView b()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TreeView A_0)
	{
		TreeViewCancelEventHandler value = b;
		TreeViewCancelEventHandler value2 = a;
		TreeViewEventHandler value3 = a;
		TreeNodeMouseClickEventHandler value4 = a;
		KeyEventHandler value5 = a;
		TreeView treeView = this.m_b;
		if (treeView != null)
		{
			treeView.BeforeExpand -= value;
			treeView.BeforeCollapse -= value2;
			treeView.AfterSelect -= value3;
			treeView.NodeMouseDoubleClick -= value4;
			treeView.KeyUp -= value5;
		}
		this.m_b = A_0;
		treeView = this.m_b;
		if (treeView != null)
		{
			treeView.BeforeExpand += value;
			treeView.BeforeCollapse += value2;
			treeView.AfterSelect += value3;
			treeView.NodeMouseDoubleClick += value4;
			treeView.KeyUp += value5;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ImageList c()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ImageList A_0)
	{
		this.m_c = A_0;
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
	internal virtual void a(Button A_0)
	{
		EventHandler value = a;
		Button button = this.m_d;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_d = A_0;
		button = this.m_d;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button j()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = b;
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
	public bool k()
	{
		return this.m_p;
	}

	[SpecialName]
	public string l()
	{
		return this.m_j;
	}

	[SpecialName]
	public void a(string A_0)
	{
		this.m_j = A_0;
	}

	[SpecialName]
	public string m()
	{
		return this.m_q;
	}

	[SpecialName]
	public void b(string A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	public string n()
	{
		return this.m_l + this.m_q;
	}

	[SpecialName]
	public string o()
	{
		return s;
	}

	private void d(object A_0, EventArgs A_1)
	{
		TreeNode treeNode = new TreeNode();
		checked
		{
			try
			{
				b().Nodes.Clear();
				treeNode.ImageIndex = 0;
				treeNode.SelectedImageIndex = 0;
				treeNode.Text = this.m_q;
				b().Nodes.Add(treeNode);
				treeNode.Nodes.Add("");
				treeNode.Collapse();
				this.m_o = false;
				while (!this.m_o)
				{
					treeNode.Expand();
					if (!this.m_o)
					{
						string right = g.Substring(Strings.Len(this.m_l), Strings.Len(treeNode.FullPath) + g.Substring(Strings.Len(this.m_l) + Strings.Len(treeNode.FullPath) + 1).IndexOf("\\") + 1);
						int num;
						for (num = 0; num <= treeNode.Nodes.Count - 1 && Operators.CompareString(treeNode.Nodes[num].FullPath, right, TextCompare: false) != 0; num++)
						{
						}
						if (num > treeNode.Nodes.Count - 1)
						{
							break;
						}
						treeNode = treeNode.Nodes[num];
						treeNode.Expand();
					}
				}
				j().Enabled = b().SelectedNode != null;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				_ = $"DialogTreeView.DialogTreeView_Load - Cannot create initial node";
				ProjectData.ClearProjectError();
			}
		}
	}

	private void b(object A_0, TreeViewCancelEventArgs A_1)
	{
		if (A_1.Node.ImageIndex == 2)
		{
			return;
		}
		try
		{
			if (A_1.Node.GetNodeCount(includeSubTrees: false) == 1 && Operators.CompareString(A_1.Node.Nodes[0].Text, "", TextCompare: false) == 0)
			{
				A_1.Node.Nodes[0].Remove();
				b(A_1.Node);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			_ = $"DialogTreeView.TreeView1_BeforeExpand - Unable to expand {A_1.Node.FullPath}";
			ProjectData.ClearProjectError();
		}
		if (A_1.Node.GetNodeCount(includeSubTrees: false) > 0)
		{
			A_1.Node.ImageIndex = 1;
			A_1.Node.SelectedImageIndex = 1;
		}
	}

	private void b(TreeNode A_0)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(this.m_l + A_0.FullPath + "\\");
		bool flag = false;
		string text = "";
		string text2 = "";
		try
		{
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				TreeNode treeNode = new TreeNode();
				if (Operators.CompareString((i3.o() + "\\TemplateImages\\").ToLower().TrimEnd("\\".ToCharArray()), directoryInfo2.FullName.ToLower().TrimEnd("\\".ToCharArray()), TextCompare: false) != 0)
				{
					treeNode.Text = directoryInfo2.Name;
					treeNode.ImageIndex = 0;
					treeNode.SelectedImageIndex = 0;
					A_0.Nodes.Add(treeNode);
					treeNode.Nodes.Add("");
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			_ = $"DialogTreeView.EnumerateChildren - Cannot list folders of  {A_0.FullPath}";
			ProjectData.ClearProjectError();
		}
		try
		{
			FileInfo[] files;
			if (v == fk.a.a)
			{
				text = ".fitra";
				text2 = h;
				if (Operators.CompareString(h, text, TextCompare: false) == 0)
				{
					files = directoryInfo.GetFiles("*" + h);
					flag = true;
				}
				else
				{
					files = directoryInfo.GetFiles();
					flag = false;
				}
			}
			else
			{
				text = ".fmtpa";
				text2 = ".fmtpe";
				flag = Operators.CompareString(h, text, TextCompare: false) == 0;
				files = directoryInfo.GetFiles("*" + h);
			}
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				if (Operators.CompareString(fileInfo.Name, "LastRecipe.dat", TextCompare: false) == 0 || Operators.CompareString(fileInfo.Name, "LastTemplate.dat", TextCompare: false) == 0)
				{
					continue;
				}
				string extension = Path.GetExtension(fileInfo.Name);
				if ((!flag || Operators.CompareString(extension, text, TextCompare: false) != 0) && (flag || Operators.CompareString(extension, text2, TextCompare: false) != 0) && (flag || Operators.CompareString(extension, ".ficrp", TextCompare: false) != 0 || !u))
				{
					continue;
				}
				bool flag2;
				if (this.m_m != null)
				{
					flag2 = false;
					foreach (string item in this.m_m)
					{
						if (Operators.CompareString(item.ToLower(), fileInfo.FullName.Substring(checked(n().Length + 1)).ToLower(), TextCompare: false) == 0)
						{
							flag2 = true;
							break;
						}
					}
				}
				else
				{
					flag2 = true;
				}
				if (flag2)
				{
					TreeNode treeNode2 = new TreeNode();
					treeNode2.Text = Path.GetFileNameWithoutExtension(fileInfo.Name);
					if (Operators.CompareString(extension, ".ficrp", TextCompare: false) == 0 && Operators.CompareString(h, ".ficrp", TextCompare: false) != 0)
					{
						treeNode2.Text += " <Composite>";
					}
					treeNode2.ImageIndex = 2;
					treeNode2.SelectedImageIndex = 2;
					A_0.Nodes.Add(treeNode2);
					if (Operators.CompareString(g, fileInfo.FullName, TextCompare: false) == 0)
					{
						treeNode2.ForeColor = Color.Red;
						f = treeNode2;
						this.m_o = true;
					}
				}
			}
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception ex5 = ex4;
			_ = $"DialogTreeView.EnumerateChildren - Cannot list files in  {A_0.FullPath}";
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, TreeViewCancelEventArgs A_1)
	{
		A_1.Node.ImageIndex = 0;
		A_1.Node.SelectedImageIndex = 0;
	}

	private void c(object A_0, EventArgs A_1)
	{
		if (base.WindowState != FormWindowState.Minimized)
		{
			b().Bounds = new Rectangle(0, 0, base.ClientSize.Width, base.ClientSize.Height);
		}
	}

	private void a(object A_0, TreeViewEventArgs A_1)
	{
		try
		{
			if (A_1.Node.SelectedImageIndex == 2)
			{
				if (A_1.Action == TreeViewAction.ByMouse)
				{
					a(A_1.Node);
					if (!global::c.e().FileSystem.FileExists(this.m_j))
					{
						Interaction.MsgBox("Selected file not found.");
					}
					j().Enabled = true;
				}
			}
			else
			{
				j().Enabled = false;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			_ = $"DialogTreeView.TreeView1_AfterSelect - Error";
			ProjectData.ClearProjectError();
		}
	}

	public bool a(ref string A_0)
	{
		bool result = default(bool);
		try
		{
			if (f != null)
			{
				f.ForeColor = Color.Red;
			}
			Path.GetDirectoryName(A_0);
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(A_0);
			f = b().Nodes.Add(A_0, fileNameWithoutExtension, 2);
			f.ForeColor = Color.Red;
			this.m_j = A_0;
			this.m_k = fileNameWithoutExtension;
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

	public void b(ref string A_0)
	{
		if (f != null)
		{
			f.ForeColor = Color.Black;
			b().Nodes.Remove(f);
			f = null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public string c(ref string A_0)
	{
		string text = FileSystem.Dir(A_0 + "\\*" + h);
		bool flag = default(bool);
		while (!flag & (Operators.CompareString(text, "", TextCompare: false) != 0))
		{
			if (Operators.CompareString(Strings.LCase(text), Strings.LCase(w + h), TextCompare: false) == 0)
			{
				text = FileSystem.Dir();
			}
			else
			{
				flag = true;
			}
		}
		if (Operators.CompareString(text, "", TextCompare: false) == 0)
		{
			return text;
		}
		string text2 = A_0 + "\\" + text;
		f = b().Nodes[text2];
		f.ForeColor = Color.Red;
		this.m_j = text2;
		return text2;
	}

	public string p()
	{
		return this.m_k;
	}

	public string q()
	{
		return this.m_j;
	}

	public void a(Point A_0)
	{
		base.Top = A_0.Y;
		base.Left = A_0.X;
		checked
		{
			if (base.Left + base.Width > Screen.PrimaryScreen.Bounds.Width)
			{
				base.Left = Screen.PrimaryScreen.Bounds.Width - base.Width;
			}
			if (base.Top + base.Height > Screen.PrimaryScreen.Bounds.Height)
			{
				base.Top = Screen.PrimaryScreen.Bounds.Height - base.Height;
			}
			ShowDialog();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		this.m_p = false;
		Hide();
	}

	private void a(object A_0, EventArgs A_1)
	{
		this.m_p = true;
		Hide();
	}

	public fk(fz A_0, string A_1, string A_2, string A_3, a A_4, string A_5, bool A_6, List<string> A_7)
	{
		base.Load += d;
		base.Resize += c;
		a();
		x = A_0;
		g = A_2;
		h = A_3;
		i = Strings.Len(A_3);
		v = A_4;
		u = A_6;
		checked
		{
			if (A_1.EndsWith("\\"))
			{
				A_1 = A_1.Substring(0, A_1.Length - 1);
			}
			this.m_l = A_1.Substring(0, A_1.LastIndexOf('\\')) + "\\";
			this.m_m = A_7;
			r = new Collection();
			this.m_q = A_1.Substring(A_1.LastIndexOf("\\") + 1);
			w = A_5;
			f = null;
		}
	}

	private void a(object A_0, TreeNodeMouseClickEventArgs A_1)
	{
		if (A_1.Node.SelectedImageIndex == 2 && Operators.CompareString(b().SelectedNode.Text, A_1.Node.Text, TextCompare: false) == 0)
		{
			a(A_1.Node);
			this.m_p = false;
			Hide();
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		Keys keyCode = A_1.KeyCode;
		if (keyCode == Keys.Up || keyCode == Keys.Down)
		{
			a(b().SelectedNode);
			j().Enabled = f.SelectedImageIndex == 2;
		}
	}

	private void a(TreeNode A_0)
	{
		f = A_0;
		if (f.Text.Contains(" <Composite>"))
		{
			this.m_j = this.m_l + f.FullPath.Replace(" <Composite>", string.Empty) + ".ficrp";
		}
		else
		{
			this.m_j = this.m_l + f.FullPath + h;
		}
		this.m_k = f.Text;
	}
}
