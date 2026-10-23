using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Filmetrics.FIMatFileDBService;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class e7 : Form
{
	private class a
	{
		public string a;

		public string b;

		public int c;

		public DateTime d;

		public a(string A_0, string A_1, int A_2)
		{
			a = A_0;
			b = A_1;
			c = A_2;
		}
	}

	private class b
	{
		public fz a;

		public bool b;

		public c1 c;

		public b(fz A_0, c1 A_1)
		{
			a = A_0;
			c = A_1;
		}
	}

	private enum c
	{
		a,
		b,
		c,
		d
	}

	private enum d
	{
		a,
		b
	}

	private delegate void e(object A_0, ElapsedEventArgs A_1);

	private delegate void f(object A_0, ElapsedEventArgs A_1);

	private IContainer m_a;

	[CompilerGenerated]
	private Button m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private Button m_d;

	[CompilerGenerated]
	private Button m_e;

	[CompilerGenerated]
	private Button m_f;

	[CompilerGenerated]
	private GroupBox m_g;

	[CompilerGenerated]
	private RadioButton m_h;

	[CompilerGenerated]
	private RadioButton m_i;

	[CompilerGenerated]
	private Button m_j;

	[CompilerGenerated]
	private GroupBox m_k;

	[CompilerGenerated]
	private RadioButton m_l;

	[CompilerGenerated]
	private RadioButton m_m;

	[CompilerGenerated]
	private RadioButton m_n;

	[CompilerGenerated]
	private RadioButton m_o;

	[CompilerGenerated]
	private RadioButton m_p;

	[CompilerGenerated]
	private Label m_q;

	[CompilerGenerated]
	private TabControl m_r;

	[CompilerGenerated]
	private TabPage m_s;

	[CompilerGenerated]
	private TabPage m_t;

	[CompilerGenerated]
	private DataGridView m_u;

	[CompilerGenerated]
	private fl m_v;

	[CompilerGenerated]
	private TabPage m_w;

	[CompilerGenerated]
	private Label m_x;

	[CompilerGenerated]
	private Label m_y;

	[CompilerGenerated]
	private Label m_z;

	[CompilerGenerated]
	private Label m_aa;

	[CompilerGenerated]
	private Label m_ab;

	[CompilerGenerated]
	private Label m_ac;

	[CompilerGenerated]
	private Label m_ad;

	[CompilerGenerated]
	private Label m_ae;

	[CompilerGenerated]
	private Label m_af;

	[CompilerGenerated]
	private Label m_ag;

	[CompilerGenerated]
	private TabPage m_ah;

	[CompilerGenerated]
	private TextBox m_ai;

	[CompilerGenerated]
	private TextBox m_aj;

	[CompilerGenerated]
	private Label m_ak;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_al;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_am;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_an;

	[CompilerGenerated]
	private CheckBox m_ao;

	[CompilerGenerated]
	private Button m_ap;

	[CompilerGenerated]
	private LinkLabel m_aq;

	[CompilerGenerated]
	private DataGridView m_ar;

	[CompilerGenerated]
	private Button m_as;

	[CompilerGenerated]
	private Button m_at;

	[CompilerGenerated]
	private Button m_au;

	[CompilerGenerated]
	private Button m_av;

	[CompilerGenerated]
	private TabPage m_aw;

	[CompilerGenerated]
	private DataGridView m_ax;

	[CompilerGenerated]
	private Label m_ay;

	[CompilerGenerated]
	private Button m_az;

	[CompilerGenerated]
	private TableLayoutPanel m_a0;

	[CompilerGenerated]
	private Button m_a1;

	[CompilerGenerated]
	private CheckBox m_a2;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_a3;

	[CompilerGenerated]
	private DataGridViewButtonColumn m_a4;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_a5;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_a6;

	[CompilerGenerated]
	private DataGridViewCheckBoxColumn m_a7;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_a8;

	[CompilerGenerated]
	private Label m_a9;

	[CompilerGenerated]
	private ComboBox m_ba;

	[CompilerGenerated]
	private ComboBox m_bb;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_bc;

	[CompilerGenerated]
	private DataGridViewComboBoxColumn m_bd;

	[CompilerGenerated]
	private Button m_be;

	[CompilerGenerated]
	private Button m_bf;

	[CompilerGenerated]
	private ComboBox m_bg;

	[CompilerGenerated]
	private RadioButton m_bh;

	[CompilerGenerated]
	private RadioButton m_bi;

	[CompilerGenerated]
	private ToolTip m_bj;

	private const short m_bk = 20000;

	private short m_bl;

	private short m_bm;

	private short m_bn;

	private bool m_bo;

	private int m_bp;

	private string[,] m_bq;

	private double[] m_br;

	private short[] m_bs;

	private short m_bt;

	private float[] m_bu;

	private string m_bv;

	private string m_bw;

	private string m_bx;

	private bool m_by;

	private LicenseLevel m_bz;

	private eb.a m_b0;

	private int m_b1;

	private double[] m_b2;

	private double[] b3;

	private bool b4;

	private bool b5;

	private double[] b6;

	private bool b7;

	private bool b8;

	private bool b9;

	private int ca;

	private string cb;

	private string[] cc;

	private string[] cd;

	private int[] ce;

	private bool cf;

	private List<string> cg;

	private List<jb.d> ch;

	private jb.f ci;

	private string cj;

	private string ck;

	private string cl;

	private je cm;

	private je cn;

	private bool co;

	private bool cp;

	private const int cq = 2;

	private const int cr = 1;

	private const int cs = 1;

	private bool ct;

	private bool cu;

	private gn cv;

	private go cw;

	private const short cx = 0;

	private const short cy = 1;

	private const short cz = 2;

	private fz c0;

	private f1 c1;

	private f4 c2;

	private hd c3;

	private fd c4;

	private eo c5;

	private eo.a c6;

	private bool c7;

	private bool c8;

	private TabPage c9;

	private bool da;

	private bool db;

	private bool dc;

	private float dd;

	private float de;

	private ew.a df;

	[CompilerGenerated]
	private System.Timers.Timer dg;

	private c dh;

	[CompilerGenerated]
	private System.Timers.Timer di;

	private jb.d dj;

	private const string dk = "DialogEditLibrary";

	private const string dl = "Untitled";

	private int dm;

	private const string dn = "Invalid Entry";

	private const string @do = "\"";

	private const string dp = "\"\"";

	private const string dq = "\\NotViewable\\";

	private const string dr = ";";

	[SpecialName]
	private bool ds;

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
	private void q()
	{
		this.m_a = new Container();
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(e7));
		DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
		a(new Button());
		b(new Button());
		c(new Button());
		d(new Button());
		e(new Button());
		a(new GroupBox());
		a(new RadioButton());
		b(new RadioButton());
		f(new Button());
		b(new GroupBox());
		c(new RadioButton());
		d(new RadioButton());
		e(new RadioButton());
		f(new RadioButton());
		g(new RadioButton());
		a(new Label());
		a(new TabControl());
		e(new TabPage());
		n(new Label());
		a(new ComboBox());
		a(new TableLayoutPanel());
		m(new Button());
		l(new Button());
		c(new DataGridView());
		d(new DataGridViewTextBoxColumn());
		a(new DataGridViewButtonColumn());
		e(new DataGridViewTextBoxColumn());
		f(new DataGridViewTextBoxColumn());
		a(new DataGridViewCheckBoxColumn());
		g(new DataGridViewTextBoxColumn());
		b(new TabPage());
		h(new Label());
		a(new DataGridView());
		a(new DataGridViewTextBoxColumn());
		b(new DataGridViewTextBoxColumn());
		c(new DataGridViewTextBoxColumn());
		a(new TabPage());
		c(new TabPage());
		i(new Label());
		j(new Label());
		k(new Label());
		d(new Label());
		e(new Label());
		f(new Label());
		g(new Label());
		b(new Label());
		c(new Label());
		d(new TabPage());
		h(new RadioButton());
		i(new RadioButton());
		c(new ComboBox());
		n(new Button());
		o(new Button());
		b(new ComboBox());
		h(new Button());
		i(new Button());
		b(new DataGridView());
		h(new DataGridViewTextBoxColumn());
		a(new DataGridViewComboBoxColumn());
		a(new LinkLabel());
		g(new Button());
		a(new CheckBox());
		b(new TextBox());
		l(new Label());
		a(new TextBox());
		j(new Button());
		k(new Button());
		m(new Label());
		b(new CheckBox());
		a(new ToolTip(this.m_a));
		a(new fl());
		w().SuspendLayout();
		aa().SuspendLayout();
		ah().SuspendLayout();
		bc().SuspendLayout();
		bg().SuspendLayout();
		((ISupportInitialize)bd()).BeginInit();
		aj().SuspendLayout();
		((ISupportInitialize)ak()).BeginInit();
		ai().SuspendLayout();
		am().SuspendLayout();
		ax().SuspendLayout();
		((ISupportInitialize)a7()).BeginInit();
		SuspendLayout();
		r().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		r().Location = new Point(443, 394);
		r().Name = "ButtonSaveAs";
		r().Size = new Size(90, 35);
		r().TabIndex = 18;
		r().Text = "Save As...";
		r().UseVisualStyleBackColor = true;
		s().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		s().Location = new Point(347, 394);
		s().Name = "ButtonSave";
		s().Size = new Size(90, 35);
		s().TabIndex = 17;
		s().Text = "Save";
		s().UseVisualStyleBackColor = true;
		t().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		t().Location = new Point(251, 394);
		t().Name = "ButtonOpen";
		t().Size = new Size(90, 35);
		t().TabIndex = 16;
		t().Text = "Open...";
		t().UseVisualStyleBackColor = true;
		u().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		u().Location = new Point(155, 394);
		u().Name = "ButtonNew";
		u().Size = new Size(90, 35);
		u().TabIndex = 15;
		u().Text = "New...";
		u().UseVisualStyleBackColor = true;
		v().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		v().Location = new Point(19, 350);
		v().Name = "ButtonStripPoints";
		v().Size = new Size(119, 35);
		v().TabIndex = 14;
		v().Text = "Strip Points...";
		v().UseVisualStyleBackColor = true;
		w().Controls.Add(x());
		w().Controls.Add(y());
		w().Controls.Add(z());
		w().Location = new Point(13, 176);
		w().Margin = new Padding(4);
		w().Name = "GroupModel";
		w().Padding = new Padding(4);
		w().Size = new Size(128, 124);
		w().TabIndex = 13;
		w().TabStop = false;
		w().Text = "Model";
		x().AutoSize = true;
		x().Location = new Point(10, 48);
		x().Name = "RadioCustom";
		x().Size = new Size(71, 20);
		x().TabIndex = 12;
		x().Text = "Custom";
		x().UseVisualStyleBackColor = true;
		y().AutoSize = true;
		y().Checked = true;
		y().Location = new Point(10, 22);
		y().Name = "RadioDefault";
		y().Size = new Size(68, 20);
		y().TabIndex = 11;
		y().TabStop = true;
		y().Text = "Default";
		y().UseVisualStyleBackColor = true;
		z().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		z().Location = new Point(19, 76);
		z().Name = "ButtonModel";
		z().Size = new Size(90, 35);
		z().TabIndex = 4;
		z().Text = "Details...";
		z().UseVisualStyleBackColor = true;
		aa().Controls.Add(ab());
		aa().Controls.Add(ac());
		aa().Controls.Add(ad());
		aa().Controls.Add(ae());
		aa().Controls.Add(af());
		aa().Location = new Point(13, 21);
		aa().Margin = new Padding(4);
		aa().Name = "GroupMaterial";
		aa().Padding = new Padding(4);
		aa().Size = new Size(128, 146);
		aa().TabIndex = 12;
		aa().TabStop = false;
		aa().Text = "Material Type";
		ab().AutoSize = true;
		ab().Location = new Point(10, 93);
		ab().Name = "RadioMetal";
		ab().Size = new Size(59, 20);
		ab().TabIndex = 6;
		ab().Text = "Metal";
		ab().UseVisualStyleBackColor = true;
		ac().AutoSize = true;
		ac().Location = new Point(10, 68);
		ac().Name = "RadioSemi";
		ac().Size = new Size(116, 20);
		ac().TabIndex = 7;
		ac().Text = "Semiconductor";
		ac().UseVisualStyleBackColor = true;
		ad().AutoSize = true;
		ad().Location = new Point(10, 118);
		ad().Name = "RadioOther";
		ad().Size = new Size(58, 20);
		ad().TabIndex = 10;
		ad().Text = "Other";
		ad().UseVisualStyleBackColor = true;
		ae().AutoSize = true;
		ae().Checked = true;
		ae().Location = new Point(10, 18);
		ae().Name = "RadioInsulator";
		ae().Size = new Size(82, 20);
		ae().TabIndex = 8;
		ae().TabStop = true;
		ae().Text = "Dielectric";
		ae().UseVisualStyleBackColor = true;
		af().AutoSize = true;
		af().Location = new Point(10, 43);
		af().Name = "RadioPhotoresist";
		af().Size = new Size(93, 20);
		af().TabIndex = 9;
		af().Text = "Photoresist";
		af().UseVisualStyleBackColor = true;
		ag().BorderStyle = BorderStyle.FixedSingle;
		ag().Location = new Point(155, 80);
		ag().Name = "TextMaterialPrompt";
		ag().Size = new Size(229, 41);
		ag().TabIndex = 20;
		ag().Text = "Click a Radio button to select a material type.";
		ah().Controls.Add(bc());
		ah().Controls.Add(aj());
		ah().Controls.Add(ai());
		ah().Controls.Add(am());
		ah().Controls.Add(ax());
		ah().Location = new Point(155, 3);
		ah().Name = "TabIndexData";
		ah().SelectedIndex = 0;
		ah().Size = new Size(685, 385);
		ah().TabIndex = 21;
		bc().Controls.Add(bp());
		bc().Controls.Add(bq());
		bc().Controls.Add(bg());
		bc().Controls.Add(bd());
		bc().Location = new Point(4, 25);
		bc().Name = "TabPageMixture";
		bc().Padding = new Padding(3);
		bc().Size = new Size(677, 356);
		bc().TabIndex = 4;
		bc().Text = "Mixture Information";
		bc().UseVisualStyleBackColor = true;
		bp().AutoSize = true;
		bp().Location = new Point(181, 264);
		bp().Name = "LabelMixtureCustomModel";
		bp().Size = new Size(97, 16);
		bp().TabIndex = 13;
		bp().Text = "Custom Model:";
		bq().DropDownStyle = ComboBoxStyle.DropDownList;
		bq().Enabled = false;
		bq().FormattingEnabled = true;
		bq().Location = new Point(282, 261);
		bq().Name = "ComboBoxModel";
		bq().Size = new Size(213, 24);
		bq().TabIndex = 12;
		bg().AutoSize = true;
		bg().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		bg().ColumnCount = 1;
		bg().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		bg().Controls.Add(bh(), 0, 1);
		bg().Controls.Add(bf(), 0, 0);
		bg().Location = new Point(591, 42);
		bg().Name = "TableLayoutPanel1";
		bg().RowCount = 2;
		bg().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		bg().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		bg().Size = new Size(73, 64);
		bg().TabIndex = 11;
		bh().AutoSize = true;
		bh().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		bh().Dock = DockStyle.Fill;
		bh().Enabled = false;
		bh().Location = new Point(3, 35);
		bh().Name = "ButtonMixtureDelete";
		bh().Size = new Size(67, 26);
		bh().TabIndex = 10;
		bh().Text = "Delete...";
		bh().UseVisualStyleBackColor = true;
		bf().AutoSize = true;
		bf().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		bf().Dock = DockStyle.Fill;
		bf().Location = new Point(3, 3);
		bf().Name = "ButtonMixtureAdd";
		bf().Size = new Size(67, 26);
		bf().TabIndex = 9;
		bf().Text = "Add...";
		bf().UseVisualStyleBackColor = true;
		bd().AllowUserToAddRows = false;
		bd().AllowUserToDeleteRows = false;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		bd().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		bd().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		bd().Columns.AddRange(bj(), bk(), bl(), bm(), bn(), bo());
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = SystemColors.Window;
		dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
		bd().DefaultCellStyle = dataGridViewCellStyle2;
		bd().Location = new Point(3, 3);
		bd().Name = "DataGridViewMixture";
		bd().Size = new Size(574, 187);
		bd().TabIndex = 7;
		bj().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle3.BackColor = Color.White;
		bj().DefaultCellStyle = dataGridViewCellStyle3;
		bj().HeaderText = "Material Name";
		bj().Name = "MixGridColumnMatName";
		bj().ReadOnly = true;
		bj().Resizable = DataGridViewTriState.False;
		bj().SortMode = DataGridViewColumnSortMode.NotSortable;
		bk().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		bk().HeaderText = "";
		bk().Name = "MixGridColumnBrowse";
		bk().Resizable = DataGridViewTriState.False;
		bk().Text = "Browse...";
		bk().ToolTipText = "Click to browse for material file";
		bk().UseColumnTextForButtonValue = true;
		bk().Width = 5;
		bl().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
		bl().DefaultCellStyle = dataGridViewCellStyle4;
		bl().HeaderText = "%";
		bl().Name = "MixGridColumnPercentage";
		bl().Resizable = DataGridViewTriState.False;
		bl().SortMode = DataGridViewColumnSortMode.NotSortable;
		bl().Width = 26;
		bm().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		bm().HeaderText = "# Grid Pts";
		bm().Name = "MixGridColumnNumGridPts";
		bm().Resizable = DataGridViewTriState.False;
		bm().SortMode = DataGridViewColumnSortMode.NotSortable;
		bm().Width = 64;
		bn().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		bn().HeaderText = "Fixed";
		bn().Name = "MixGridColumnFixed";
		bn().Width = 47;
		bo().AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		bo().HeaderText = "Current Grid Pt";
		bo().Name = "MixGridColumnCurrGridPt";
		bo().Resizable = DataGridViewTriState.False;
		bo().SortMode = DataGridViewColumnSortMode.NotSortable;
		bo().Width = 78;
		aj().Controls.Add(at());
		aj().Controls.Add(ak());
		aj().Location = new Point(4, 25);
		aj().Name = "TabPageTable";
		aj().Padding = new Padding(3);
		aj().Size = new Size(677, 356);
		aj().TabIndex = 0;
		aj().Text = "Table";
		aj().UseVisualStyleBackColor = true;
		at().AutoSize = true;
		at().Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		at().Location = new Point(93, 145);
		at().Name = "LabelUpdating";
		at().Size = new Size(381, 31);
		at().TabIndex = 12;
		at().Text = "Updating Table. Please Wait...";
		at().Visible = false;
		ak().AllowUserToAddRows = false;
		ak().AllowUserToDeleteRows = false;
		dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopCenter;
		dataGridViewCellStyle5.BackColor = SystemColors.Control;
		dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
		ak().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
		ak().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		ak().Columns.AddRange(a1(), a2(), a3());
		dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle6.BackColor = SystemColors.Window;
		dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
		ak().DefaultCellStyle = dataGridViewCellStyle6;
		ak().Location = new Point(0, 0);
		ak().Margin = new Padding(4);
		ak().Name = "TheGrid2";
		ak().RowHeadersVisible = false;
		ak().Size = new Size(425, 356);
		ak().TabIndex = 11;
		a1().HeaderText = "Wavelength";
		a1().Name = "EditLibWavelength";
		a1().Resizable = DataGridViewTriState.False;
		a1().SortMode = DataGridViewColumnSortMode.NotSortable;
		a1().Width = 115;
		a2().HeaderText = "n";
		a2().Name = "EditLibNorK";
		a2().Resizable = DataGridViewTriState.False;
		a2().SortMode = DataGridViewColumnSortMode.NotSortable;
		a2().Width = 115;
		a3().HeaderText = "k";
		a3().Name = "EditLibK";
		a3().Resizable = DataGridViewTriState.False;
		a3().SortMode = DataGridViewColumnSortMode.NotSortable;
		ai().Controls.Add(al());
		ai().Location = new Point(4, 25);
		ai().Name = "TabPageGraph";
		ai().Padding = new Padding(3);
		ai().Size = new Size(677, 356);
		ai().TabIndex = 1;
		ai().Text = "Graph";
		ai().UseVisualStyleBackColor = true;
		am().Controls.Add(au());
		am().Controls.Add(av());
		am().Controls.Add(aw());
		am().Controls.Add(ap());
		am().Controls.Add(aq());
		am().Controls.Add(ar());
		am().Controls.Add(@as());
		am().Controls.Add(an());
		am().Controls.Add(ao());
		am().Location = new Point(4, 25);
		am().Name = "TabPageSelectedValues";
		am().Size = new Size(677, 356);
		am().TabIndex = 2;
		am().Text = "Selected Values";
		am().UseVisualStyleBackColor = true;
		am().Visible = false;
		au().AutoSize = true;
		au().Location = new Point(453, 180);
		au().Name = "LabelValueK1";
		au().Size = new Size(46, 16);
		au().TabIndex = 8;
		au().Text = "1.4547";
		au().Visible = false;
		av().AutoSize = true;
		av().Location = new Point(453, 152);
		av().Name = "LabelValueK0";
		av().Size = new Size(46, 16);
		av().TabIndex = 7;
		av().Text = "1.4612";
		av().Visible = false;
		aw().AutoSize = true;
		aw().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		aw().Location = new Point(466, 121);
		aw().Name = "LabelSelectedValueK";
		aw().Size = new Size(16, 16);
		aw().TabIndex = 6;
		aw().Text = "k";
		aw().Visible = false;
		ap().AutoSize = true;
		ap().Location = new Point(367, 180);
		ap().Name = "LabelValueNorK1";
		ap().Size = new Size(46, 16);
		ap().TabIndex = 5;
		ap().Text = "1.4547";
		aq().AutoSize = true;
		aq().Location = new Point(258, 180);
		aq().Name = "LabelWavelength1";
		aq().Size = new Size(39, 16);
		aq().TabIndex = 4;
		aq().Text = "632.8";
		ar().AutoSize = true;
		ar().Location = new Point(367, 152);
		ar().Name = "LabelValueNorK0";
		ar().Size = new Size(46, 16);
		ar().TabIndex = 3;
		ar().Text = "1.4612";
		@as().AutoSize = true;
		@as().Location = new Point(258, 152);
		@as().Name = "LabelWavelength0";
		@as().Size = new Size(39, 16);
		@as().TabIndex = 2;
		@as().Text = "435.8";
		an().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		an().Location = new Point(367, 121);
		an().Name = "LabelSelectedValueNorK";
		an().Size = new Size(48, 16);
		an().TabIndex = 1;
		an().Text = "Value";
		an().TextAlign = ContentAlignment.MiddleCenter;
		ao().AutoSize = true;
		ao().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ao().Location = new Point(215, 121);
		ao().Name = "Label1";
		ao().Size = new Size(124, 16);
		ao().TabIndex = 0;
		ao().Text = "Wavelength (nm)";
		ax().Controls.Add(bx());
		ax().Controls.Add(by());
		ax().Controls.Add(bw());
		ax().Controls.Add(bu());
		ax().Controls.Add(bv());
		ax().Controls.Add(br());
		ax().Controls.Add(a8());
		ax().Controls.Add(a9());
		ax().Controls.Add(a7());
		ax().Controls.Add(a6());
		ax().Controls.Add(a5());
		ax().Controls.Add(a4());
		ax().Controls.Add(az());
		ax().Controls.Add(a0());
		ax().Controls.Add(ay());
		ax().Location = new Point(4, 25);
		ax().Name = "TabPageInfo";
		ax().Size = new Size(677, 356);
		ax().TabIndex = 3;
		ax().Text = "File Information";
		ax().UseVisualStyleBackColor = true;
		bx().AutoSize = true;
		bx().Location = new Point(617, 61);
		bx().Name = "RadioButtonHtml";
		bx().Size = new Size(53, 20);
		bx().TabIndex = 14;
		bx().Text = "Html";
		bx().UseVisualStyleBackColor = true;
		by().AutoSize = true;
		by().Checked = true;
		by().Location = new Point(617, 35);
		by().Name = "RadioButtonText";
		by().Size = new Size(52, 20);
		by().TabIndex = 13;
		by().TabStop = true;
		by().Text = "Text";
		by().UseVisualStyleBackColor = true;
		bw().DropDownStyle = ComboBoxStyle.DropDownList;
		bw().FormattingEnabled = true;
		bw().Location = new Point(19, 325);
		bw().Name = "ComboBoxAttrStringLanguage";
		bw().Size = new Size(123, 24);
		bw().TabIndex = 12;
		bw().Visible = false;
		bu().AutoSize = true;
		bu().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		bu().Enabled = false;
		bu().Location = new Point(582, 209);
		bu().Name = "ButtonAttrMoveDown";
		bu().Size = new Size(87, 26);
		bu().TabIndex = 11;
		bu().Text = "Move down";
		bu().UseVisualStyleBackColor = true;
		bu().Visible = false;
		bv().AutoSize = true;
		bv().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		bv().Enabled = false;
		bv().Location = new Point(582, 177);
		bv().Name = "ButtonAttrMoveUp";
		bv().Size = new Size(70, 26);
		bv().TabIndex = 10;
		bv().Text = "Move up";
		bv().UseVisualStyleBackColor = true;
		bv().Visible = false;
		br().DropDownStyle = ComboBoxStyle.DropDownList;
		br().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		br().FormattingEnabled = true;
		br().Items.AddRange(new object[3] { "UnencryptedAll", "UnencryptedAllwithPermission", "EncryptedCustomerWithPermission" });
		br().Location = new Point(342, 240);
		br().Name = "ComboBoxAccessType";
		br().Size = new Size(171, 24);
		br().TabIndex = 9;
		bz().SetToolTip(br(), componentResourceManager.GetString("ComboBoxAccessType.ToolTip"));
		br().Visible = false;
		a8().AutoSize = true;
		a8().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		a8().Location = new Point(582, 145);
		a8().Name = "ButtonAttrAdd";
		a8().Size = new Size(52, 26);
		a8().TabIndex = 8;
		a8().Text = "Add...";
		a8().UseVisualStyleBackColor = true;
		a9().AutoSize = true;
		a9().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		a9().Location = new Point(582, 113);
		a9().Name = "ButtonAttrDeleteAll";
		a9().Size = new Size(85, 26);
		a9().TabIndex = 7;
		a9().Text = "Delete All...";
		a9().UseVisualStyleBackColor = true;
		dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle7.BackColor = SystemColors.Control;
		dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
		a7().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
		a7().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		a7().Columns.AddRange(bs(), bt());
		a7().Location = new Point(20, 107);
		a7().Name = "DataGridViewAttributes";
		a7().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		a7().Size = new Size(553, 133);
		a7().TabIndex = 6;
		bs().AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		bs().HeaderText = "Attribute Value";
		bs().Name = "AttributeData";
		bs().SortMode = DataGridViewColumnSortMode.NotSortable;
		bt().DropDownWidth = 2;
		bt().HeaderText = "Type";
		bt().Name = "AttributeType";
		bt().Width = 200;
		a6().AutoSize = true;
		a6().Location = new Point(523, 329);
		a6().Name = "LinkManagePermissions";
		a6().Size = new Size(135, 16);
		a6().TabIndex = 5;
		a6().TabStop = true;
		a6().Text = "Manage Permissions";
		a5().Location = new Point(198, 326);
		a5().Name = "ButtonAddToViewableDB";
		a5().Size = new Size(281, 23);
		a5().TabIndex = 4;
		a5().Text = "Add to End-User Viewable Files database";
		a5().UseVisualStyleBackColor = true;
		a5().Visible = false;
		a4().AutoSize = true;
		a4().Location = new Point(157, 328);
		a4().Name = "CheckBoxRequestEndUserView";
		a4().Size = new Size(365, 20);
		a4().TabIndex = 3;
		a4().Text = "Automatically obtain permission to view Table and Graph";
		a4().UseVisualStyleBackColor = true;
		a4().Visible = false;
		az().AcceptsReturn = true;
		az().Location = new Point(19, 258);
		az().Multiline = true;
		az().Name = "TextBoxPrivateInfo";
		az().Size = new Size(638, 59);
		az().TabIndex = 2;
		az().Visible = false;
		a0().AutoSize = true;
		a0().Location = new Point(16, 240);
		a0().Name = "LabelPrivateInfo";
		a0().Size = new Size(135, 16);
		a0().TabIndex = 1;
		a0().Text = "FI Private Information:";
		a0().Visible = false;
		ay().AcceptsReturn = true;
		ay().Location = new Point(19, 17);
		ay().Multiline = true;
		ay().Name = "TextBoxFileInfo";
		ay().ScrollBars = ScrollBars.Vertical;
		ay().Size = new Size(592, 81);
		ay().TabIndex = 0;
		ba().AutoSize = true;
		ba().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ba().Location = new Point(702, 394);
		ba().Name = "ButtonCreateSummary";
		ba().Size = new Size(138, 34);
		ba().TabIndex = 22;
		ba().Text = "Create Summary";
		bz().SetToolTip(ba(), "Create .txt summary files for each language. Files are written\r\ninto the Material folder.");
		ba().UseVisualStyleBackColor = true;
		bb().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		bb().Location = new Point(559, 394);
		bb().Name = "ButtonUpdateFiles";
		bb().Size = new Size(137, 34);
		bb().TabIndex = 23;
		bb().Text = "Update Files...";
		bz().SetToolTip(bb(), componentResourceManager.GetString("ButtonUpdateFiles.ToolTip"));
		bb().UseVisualStyleBackColor = true;
		be().BorderStyle = BorderStyle.FixedSingle;
		be().Location = new Point(155, 221);
		be().Name = "LabelModelPrompt";
		be().Size = new Size(229, 41);
		be().TabIndex = 24;
		be().Text = "Click a Radio button to select a model type.";
		be().Visible = false;
		bi().AutoSize = true;
		bi().Location = new Point(23, 316);
		bi().Name = "CheckBoxMixture";
		bi().Size = new Size(69, 20);
		bi().TabIndex = 25;
		bi().Text = "Mixture";
		bi().UseVisualStyleBackColor = true;
		bz().AutoPopDelay = 10000;
		bz().InitialDelay = 500;
		bz().ReshowDelay = 100;
		al().o((gq)null);
		al().v(A_0: false);
		al().AllowDrop = true;
		al().u(A_0: false);
		al().AutoSizeMode = AutoSizeMode.GrowAndShrink;
		al().BackColor = Color.Transparent;
		al().BackgroundImageLayout = ImageLayout.None;
		al().w(A_0: false);
		al().al(A_0: false);
		al().x(A_0: true);
		al().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		al().ah(A_0: false);
		al().r("Double-click to adjust graph limits.\r\nRight-click to access cursor settings.");
		al().y(A_0: true);
		al().z(A_0: false);
		al().aa(A_0: false);
		al().ac(A_0: false);
		al().ab(A_0: false);
		al().Location = new Point(0, 0);
		al().o((fz)null);
		al().Margin = new Padding(4);
		al().ad(A_0: false);
		al().Name = "GraphIndexData";
		al().q("SiO2 on Si Spectrum taken 01/31/2007 12:34 PM ");
		al().q(1);
		al().t(A_0: false);
		al().am(A_0: false);
		al().t((string)null);
		al().an(A_0: true);
		al().ae(A_0: false);
		al().af(A_0: false);
		al().ag(A_0: true);
		al().Size = new Size(677, 356);
		al().TabIndex = 0;
		al().o((fu)null);
		al().aj(A_0: false);
		al().ai(A_0: false);
		al().s((string)null);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(845, 436);
		base.Controls.Add(bi());
		base.Controls.Add(be());
		base.Controls.Add(bb());
		base.Controls.Add(ba());
		base.Controls.Add(ag());
		base.Controls.Add(ah());
		base.Controls.Add(r());
		base.Controls.Add(s());
		base.Controls.Add(t());
		base.Controls.Add(u());
		base.Controls.Add(v());
		base.Controls.Add(w());
		base.Controls.Add(aa());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogEditLibrary";
		base.ShowInTaskbar = false;
		Text = "Edit Library File";
		w().ResumeLayout(performLayout: false);
		w().PerformLayout();
		aa().ResumeLayout(performLayout: false);
		aa().PerformLayout();
		ah().ResumeLayout(performLayout: false);
		bc().ResumeLayout(performLayout: false);
		bc().PerformLayout();
		bg().ResumeLayout(performLayout: false);
		bg().PerformLayout();
		((ISupportInitialize)bd()).EndInit();
		aj().ResumeLayout(performLayout: false);
		aj().PerformLayout();
		((ISupportInitialize)ak()).EndInit();
		ai().ResumeLayout(performLayout: false);
		am().ResumeLayout(performLayout: false);
		am().PerformLayout();
		ax().ResumeLayout(performLayout: false);
		ax().PerformLayout();
		((ISupportInitialize)a7()).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button r()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = y;
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
	internal virtual Button s()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = aa;
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
	internal virtual Button t()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = ab;
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
	internal virtual Button u()
	{
		return this.m_e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Button A_0)
	{
		EventHandler value = z;
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
	internal virtual Button v()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Button A_0)
	{
		EventHandler value = x;
		Button button = this.m_f;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_f = A_0;
		button = this.m_f;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox w()
	{
		return this.m_g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(GroupBox A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton x()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(RadioButton A_0)
	{
		EventHandler value = v;
		RadioButton radioButton = this.m_h;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_h = A_0;
		radioButton = this.m_h;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton y()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(RadioButton A_0)
	{
		EventHandler value = t;
		RadioButton radioButton = this.m_i;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_i = A_0;
		radioButton = this.m_i;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button z()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Button A_0)
	{
		EventHandler value = w;
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
	internal virtual GroupBox aa()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(GroupBox A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ab()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(RadioButton A_0)
	{
		EventHandler value = s;
		RadioButton radioButton = this.m_l;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_l = A_0;
		radioButton = this.m_l;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ac()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(RadioButton A_0)
	{
		EventHandler value = s;
		RadioButton radioButton = this.m_m;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_m = A_0;
		radioButton = this.m_m;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ad()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(RadioButton A_0)
	{
		EventHandler value = s;
		RadioButton radioButton = this.m_n;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_n = A_0;
		radioButton = this.m_n;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton ae()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(RadioButton A_0)
	{
		EventHandler value = s;
		RadioButton radioButton = this.m_o;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_o = A_0;
		radioButton = this.m_o;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton af()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(RadioButton A_0)
	{
		EventHandler value = s;
		RadioButton radioButton = this.m_p;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_p = A_0;
		radioButton = this.m_p;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ag()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabControl ah()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TabControl A_0)
	{
		EventHandler value = p;
		TabControl tabControl = this.m_r;
		if (tabControl != null)
		{
			tabControl.SelectedIndexChanged -= value;
		}
		this.m_r = A_0;
		tabControl = this.m_r;
		if (tabControl != null)
		{
			tabControl.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage ai()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TabPage A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage aj()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TabPage A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridView ak()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridView A_0)
	{
		DataGridViewCellEventHandler value = g;
		KeyEventHandler value2 = a;
		PreviewKeyDownEventHandler value3 = a;
		DataGridView dataGridView = this.m_u;
		if (dataGridView != null)
		{
			dataGridView.CellValueChanged -= value;
			dataGridView.KeyDown -= value2;
			dataGridView.PreviewKeyDown -= value3;
		}
		this.m_u = A_0;
		dataGridView = this.m_u;
		if (dataGridView != null)
		{
			dataGridView.CellValueChanged += value;
			dataGridView.KeyDown += value2;
			dataGridView.PreviewKeyDown += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual fl al()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(fl A_0)
	{
		this.m_v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage am()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(TabPage A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label an()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Label A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ao()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Label A_0)
	{
		this.m_y = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ap()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Label A_0)
	{
		this.m_z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aq()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Label A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ar()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(Label A_0)
	{
		this.m_ab = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label @as()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Label A_0)
	{
		this.m_ac = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label at()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Label A_0)
	{
		this.m_ad = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label au()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Label A_0)
	{
		this.m_ae = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label av()
	{
		return this.m_af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Label A_0)
	{
		this.m_af = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label aw()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Label A_0)
	{
		this.m_ag = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage ax()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(TabPage A_0)
	{
		this.m_ah = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox ay()
	{
		return this.m_ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TextBox A_0)
	{
		this.m_ai = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TextBox az()
	{
		return this.m_aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TextBox A_0)
	{
		this.m_aj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a0()
	{
		return this.m_ak;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(Label A_0)
	{
		this.m_ak = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn a1()
	{
		return this.m_al;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridViewTextBoxColumn A_0)
	{
		this.m_al = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn a2()
	{
		return this.m_am;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(DataGridViewTextBoxColumn A_0)
	{
		this.m_am = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn a3()
	{
		return this.m_an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(DataGridViewTextBoxColumn A_0)
	{
		this.m_an = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox a4()
	{
		return this.m_ao;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(CheckBox A_0)
	{
		EventHandler value = o;
		CheckBox checkBox = this.m_ao;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_ao = A_0;
		checkBox = this.m_ao;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button a5()
	{
		return this.m_ap;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(Button A_0)
	{
		EventHandler value = n;
		Button button = this.m_ap;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ap = A_0;
		button = this.m_ap;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual LinkLabel a6()
	{
		return this.m_aq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(LinkLabel A_0)
	{
		LinkLabelLinkClickedEventHandler value = a;
		LinkLabel linkLabel = this.m_aq;
		if (linkLabel != null)
		{
			linkLabel.LinkClicked -= value;
		}
		this.m_aq = A_0;
		linkLabel = this.m_aq;
		if (linkLabel != null)
		{
			linkLabel.LinkClicked += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridView a7()
	{
		return this.m_ar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(DataGridView A_0)
	{
		DataGridViewCellEventHandler value = d;
		DataGridViewCellEventHandler value2 = c;
		DataGridViewCellEventHandler value3 = b;
		DataGridViewCellFormattingEventHandler value4 = a;
		DataGridViewEditingControlShowingEventHandler value5 = a;
		DataGridViewCellEventHandler value6 = a;
		DataGridViewRowsRemovedEventHandler value7 = a;
		ScrollEventHandler value8 = a;
		DataGridViewCellCancelEventHandler value9 = a;
		DataGridView dataGridView = this.m_ar;
		if (dataGridView != null)
		{
			dataGridView.CellClick -= value;
			dataGridView.CellEnter -= value2;
			dataGridView.CellContentDoubleClick -= value3;
			dataGridView.CellFormatting -= value4;
			dataGridView.EditingControlShowing -= value5;
			dataGridView.CellEndEdit -= value6;
			dataGridView.RowsRemoved -= value7;
			dataGridView.Scroll -= value8;
			dataGridView.CellBeginEdit -= value9;
		}
		this.m_ar = A_0;
		dataGridView = this.m_ar;
		if (dataGridView != null)
		{
			dataGridView.CellClick += value;
			dataGridView.CellEnter += value2;
			dataGridView.CellContentDoubleClick += value3;
			dataGridView.CellFormatting += value4;
			dataGridView.EditingControlShowing += value5;
			dataGridView.CellEndEdit += value6;
			dataGridView.RowsRemoved += value7;
			dataGridView.Scroll += value8;
			dataGridView.CellBeginEdit += value9;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button a8()
	{
		return this.m_as;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(Button A_0)
	{
		EventHandler value = l;
		Button button = this.m_as;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_as = A_0;
		button = this.m_as;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button a9()
	{
		return this.m_at;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(Button A_0)
	{
		EventHandler value = m;
		Button button = this.m_at;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_at = A_0;
		button = this.m_at;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button ba()
	{
		return this.m_au;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void j(Button A_0)
	{
		EventHandler value = j;
		Button button = this.m_au;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_au = A_0;
		button = this.m_au;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button bb()
	{
		return this.m_av;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void k(Button A_0)
	{
		EventHandler value = k;
		Button button = this.m_av;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_av = A_0;
		button = this.m_av;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage bc()
	{
		return this.m_aw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(TabPage A_0)
	{
		this.m_aw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridView bd()
	{
		return this.m_ax;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(DataGridView A_0)
	{
		DataGridViewCellEventHandler value = f;
		DataGridViewCellEventHandler value2 = f;
		DataGridViewCellEventHandler value3 = e;
		DataGridView dataGridView = this.m_ax;
		if (dataGridView != null)
		{
			dataGridView.CellContentClick -= value;
			dataGridView.CellContentDoubleClick -= value2;
			dataGridView.CellValueChanged -= value3;
		}
		this.m_ax = A_0;
		dataGridView = this.m_ax;
		if (dataGridView != null)
		{
			dataGridView.CellContentClick += value;
			dataGridView.CellContentDoubleClick += value2;
			dataGridView.CellValueChanged += value3;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label be()
	{
		return this.m_ay;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(Label A_0)
	{
		this.m_ay = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button bf()
	{
		return this.m_az;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void l(Button A_0)
	{
		EventHandler value = i;
		Button button = this.m_az;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_az = A_0;
		button = this.m_az;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel bg()
	{
		return this.m_a0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TableLayoutPanel A_0)
	{
		this.m_a0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button bh()
	{
		return this.m_a1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void m(Button A_0)
	{
		EventHandler value = h;
		Button button = this.m_a1;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_a1 = A_0;
		button = this.m_a1;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual CheckBox bi()
	{
		return this.m_a2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(CheckBox A_0)
	{
		EventHandler value = u;
		CheckBox checkBox = this.m_a2;
		if (checkBox != null)
		{
			checkBox.CheckedChanged -= value;
		}
		this.m_a2 = A_0;
		checkBox = this.m_a2;
		if (checkBox != null)
		{
			checkBox.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn bj()
	{
		return this.m_a3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(DataGridViewTextBoxColumn A_0)
	{
		this.m_a3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewButtonColumn bk()
	{
		return this.m_a4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridViewButtonColumn A_0)
	{
		this.m_a4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn bl()
	{
		return this.m_a5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(DataGridViewTextBoxColumn A_0)
	{
		this.m_a5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn bm()
	{
		return this.m_a6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(DataGridViewTextBoxColumn A_0)
	{
		this.m_a6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewCheckBoxColumn bn()
	{
		return this.m_a7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridViewCheckBoxColumn A_0)
	{
		this.m_a7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn bo()
	{
		return this.m_a8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void g(DataGridViewTextBoxColumn A_0)
	{
		this.m_a8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label bp()
	{
		return this.m_a9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(Label A_0)
	{
		this.m_a9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox bq()
	{
		return this.m_ba;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
	{
		EventHandler value = g;
		ComboBox comboBox = this.m_ba;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_ba = A_0;
		comboBox = this.m_ba;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox br()
	{
		return this.m_bb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ComboBox A_0)
	{
		EventHandler value = f;
		ComboBox comboBox = this.m_bb;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_bb = A_0;
		comboBox = this.m_bb;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn bs()
	{
		return this.m_bc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(DataGridViewTextBoxColumn A_0)
	{
		this.m_bc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewComboBoxColumn bt()
	{
		return this.m_bd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridViewComboBoxColumn A_0)
	{
		this.m_bd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button bu()
	{
		return this.m_be;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void n(Button A_0)
	{
		EventHandler value = b;
		Button button = this.m_be;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_be = A_0;
		button = this.m_be;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button bv()
	{
		return this.m_bf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void o(Button A_0)
	{
		EventHandler value = c;
		Button button = this.m_bf;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_bf = A_0;
		button = this.m_bf;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox bw()
	{
		return this.m_bg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ComboBox A_0)
	{
		EventHandler value = d;
		ComboBox comboBox = this.m_bg;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_bg = A_0;
		comboBox = this.m_bg;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton bx()
	{
		return this.m_bh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void h(RadioButton A_0)
	{
		this.m_bh = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RadioButton by()
	{
		return this.m_bi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void i(RadioButton A_0)
	{
		EventHandler value = a;
		RadioButton radioButton = this.m_bi;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		this.m_bi = A_0;
		radioButton = this.m_bi;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolTip bz()
	{
		return this.m_bj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolTip A_0)
	{
		this.m_bj = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer b0()
	{
		return dg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = b;
		System.Timers.Timer timer = dg;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		dg = A_0;
		timer = dg;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer b1()
	{
		return di;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void b(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = a;
		System.Timers.Timer timer = di;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		di = A_0;
		timer = di;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	public void a(fz A_0, f1 A_1, f4 A_2, ref hd A_3, eo A_4, eo.a A_5, bool A_6, float A_7, float A_8, ew.a A_9, hr A_10)
	{
		this.m_b2 = new double[20000];
		b3 = new double[20000];
		b6 = new double[20000];
		c0 = A_0;
		c1 = A_1;
		c2 = A_2;
		c3 = A_3;
		c5 = A_4;
		c6 = A_5;
		if (!c5.a8() && !c5.a3())
		{
			df = A_9;
			db = true;
			dd = A_7;
			de = A_8;
		}
		c4 = new fd();
		c4.a(c3, A_4, A_5);
		cw = new go(go.a.g);
		cv = new gn(cw, gn.a.c);
		cv.am(A_0: true);
		cv.an(A_0: false);
		al().o(c0);
		gp.a(al());
		al().f7 = false;
		al().o(cv);
		c9 = ah().SelectedTab;
		this.m_bq = new string[20001, 3];
		this.m_bo = true;
		o();
		y().Checked = true;
		this.m_bt = 2;
		this.m_b1 = 0;
		a(A_0: true, aj());
		DataGridView dataGridView = ak();
		dataGridView.AutoSize = false;
		dataGridView.AllowUserToAddRows = true;
		dataGridView.AllowUserToDeleteRows = false;
		dataGridView.AllowUserToResizeRows = false;
		dataGridView.AllowUserToResizeColumns = false;
		dataGridView.AllowUserToOrderColumns = false;
		dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
		dataGridView.MultiSelect = false;
		dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
		_ = null;
		bool A_11 = false;
		a(ref A_11);
		if (!c5.a8())
		{
			ay().Height = checked(az().Bottom - ay().Top);
			by().Visible = false;
			bx().Visible = false;
			ay().Width = az().Width;
			a6().Visible = false;
			a5().Visible = false;
			a7().Visible = false;
			a9().Visible = false;
			a8().Visible = false;
			ba().Visible = false;
			bb().Visible = false;
		}
		else
		{
			a0().Visible = true;
			az().Visible = true;
			a6().Visible = true;
			a5().Visible = true;
			bv().Visible = true;
			bu().Visible = true;
			bw().Visible = true;
		}
		p();
		a(new System.Timers.Timer());
		System.Timers.Timer timer = b0();
		timer.Interval = 1.0;
		timer.AutoReset = false;
		_ = null;
		b(new System.Timers.Timer());
		System.Timers.Timer timer2 = b1();
		timer2.Interval = 1.0;
		timer2.AutoReset = false;
		_ = null;
		DataGridViewComboBoxColumn dataGridViewComboBoxColumn = (DataGridViewComboBoxColumn)a7().Columns[1];
		foreach (object value in Enum.GetValues(typeof(jb.d)))
		{
			jb.d d10 = (jb.d)Conversions.ToShort(value);
			if (d10 != jb.d.k && d10 != jb.d.m)
			{
				dataGridViewComboBoxColumn.Items.Add(jb.d(d10));
			}
		}
		dataGridViewComboBoxColumn = null;
		checked
		{
			if (c5.bl())
			{
				this.m_by = d9.a(c0, c5.bb(), new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)), ref this.m_bz);
			}
			else
			{
				this.m_by = false;
				this.m_bz = LicenseLevel.Unlicensed;
			}
			c3.i(bq(), c5, c6, A_3: false, A_4: true);
			br().Items.Clear();
			br().Items.Add(jb.b(jb.g.a));
			br().Items.Add(jb.b(jb.g.b));
			br().Items.Add(jb.b(jb.g.c));
			br().Items.Add(jb.b(jb.g.d));
			br().Items.Add(jb.b(jb.g.e));
			bw().Items.Clear();
		}
		foreach (object value2 in Enum.GetValues(typeof(jb.f)))
		{
			jb.f a_ = (jb.f)Conversions.ToShort(value2);
			bw().Items.Add(jb.a(a_));
		}
		bw().SelectedIndex = 0;
		ShowDialog();
	}

	private void p()
	{
		if (c5.a8())
		{
			a5().Enabled = false;
			return;
		}
		a4().Visible = false;
		try
		{
			c7 = true;
			a4().Checked = false;
		}
		finally
		{
			c7 = false;
		}
	}

	private void b(ref double[] A_0, ref double[] A_1, ref double[] A_2, ref int A_3)
	{
		bool flag = !b4 || c5.a8() || c5.a3();
		bool flag2 = !b7 || c5.a8() || c5.a3();
		A_3 = 0;
		A_0 = new double[20000];
		A_1 = new double[20000];
		A_2 = new double[20000];
		if (flag)
		{
			A_1 = new double[20000];
		}
		checked
		{
			while (Operators.CompareString(this.m_bq[A_3, 0].Trim(), "", TextCompare: false) != 0 && Operators.CompareString(this.m_bq[A_3, 1].Trim(), "", TextCompare: false) != 0)
			{
				A_0[A_3] = iz.e(this.m_bq[A_3, 0]);
				if (flag)
				{
					A_1[A_3] = iz.e(this.m_bq[A_3, 1]);
				}
				if (flag2 && this.m_bq[A_3, 2] != null && Operators.CompareString(this.m_bq[A_3, 2].Trim(), "", TextCompare: false) != 0)
				{
					if (A_2 == null)
					{
						A_2 = new double[20000];
					}
					A_2[A_3] = iz.e(this.m_bq[A_3, 2]);
				}
				A_3++;
			}
		}
	}

	private void a(List<string> A_0, List<jb.d> A_1, List<string> A_2, List<jb.d> A_3, ref int A_4, ref jb.d[] A_5, ref string[] A_6)
	{
		int count = A_0.Count;
		int count2 = A_2.Count;
		checked
		{
			int num = count + count2 - 1;
			A_4 = num + 1;
			A_5 = new jb.d[num + 1];
			A_6 = new string[num + 1];
			int num2 = count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				A_6[num3] = A_0[num3];
				A_5[num3] = A_1[num3];
			}
			int num4 = count2 - 1;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				A_6[count + num5] = A_2[num5];
				A_5[count + num5] = A_3[num5];
			}
		}
	}

	private void a(jb.f A_0, ref List<string> A_1, ref List<jb.d> A_2, ref string A_3)
	{
		jb.f f10 = A_0;
		A_1 = new List<string>();
		A_2 = new List<jb.d>();
		int num = checked(a7().Rows.Count - 2);
		for (int num2 = 0; num2 <= num; num2 = checked(num2 + 1))
		{
			DataGridViewCellCollection cells = a7().Rows[num2].Cells;
			jb.d d10 = jb.al(cells[1].Value.ToString());
			string text = ((cells[0].Value != null) ? cells[0].Value.ToString().Trim() : string.Empty);
			if (f10 == jb.f.a)
			{
				A_2.Add(d10);
				if (jb.c(A_2[num2]))
				{
					A_1.Add(i6.a(text));
				}
				else if (A_2[num2] == jb.d.e)
				{
					A_1.Add(((short)jb.ak(text)).ToString());
				}
				else
				{
					A_1.Add(text);
				}
			}
			else
			{
				A_2.Add(jb.d.k);
				A_1.Add(jb.a(f10, jb.a(d10), text));
			}
			cells = null;
		}
		string text2 = ay().Text.Trim();
		string text3;
		string text4;
		if (by().Checked)
		{
			text3 = text2;
			text4 = cl;
		}
		else
		{
			text3 = ck;
			text4 = text2;
		}
		if (f10 == jb.f.a)
		{
			A_3 = text3;
			if (!string.IsNullOrEmpty(text4))
			{
				A_2.Add(jb.d.m);
				A_1.Add(text4);
			}
			return;
		}
		if (!string.IsNullOrEmpty(text3))
		{
			A_2.Add(jb.d.k);
			A_1.Add(jb.a(f10, jb.e.d, text3));
		}
		if (!string.IsNullOrEmpty(text4))
		{
			A_2.Add(jb.d.k);
			A_1.Add(jb.a(f10, jb.e.e, text4));
		}
	}

	private void a(ref bool A_0, ref string[] A_1, ref float[] A_2, ref int[] A_3, ref bool[] A_4, ref int[] A_5)
	{
		A_0 = false;
		DataGridViewRowCollection rows = bd().Rows;
		checked
		{
			int num = rows.Count - 1;
			int num2 = num - 1;
			int index = bd().Columns.IndexOf(bj());
			int index2 = bd().Columns.IndexOf(bl());
			int index3 = bd().Columns.IndexOf(bm());
			int index4 = bd().Columns.IndexOf(bn());
			int index5 = bd().Columns.IndexOf(bo());
			A_1 = new string[num + 1];
			A_2 = new float[num2 + 1];
			A_4 = new bool[num2 + 1];
			A_3 = new int[num2 + 1];
			A_5 = new int[num2 + 1];
			int num3 = num;
			int num4 = 0;
			bool flag = default(bool);
			while (true)
			{
				if (num4 <= num3)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(rows[num4].Cells[index].Value);
					if (objectValue != null)
					{
						A_1[num4] = objectValue.ToString();
						num4++;
						continue;
					}
					break;
				}
				int num5 = num2;
				int num6 = 0;
				while (true)
				{
					if (num6 <= num5)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(rows[num6].Cells[index2].Value);
						if (objectValue == null || !float.TryParse(objectValue.ToString(), out var result) || !(result >= 0f))
						{
							break;
						}
						A_2[num6] = 0.01f * result;
						objectValue = RuntimeHelpers.GetObjectValue(rows[num6].Cells[index4].Value);
						A_4[num6] = objectValue != null && Conversions.ToBoolean(objectValue);
						if (!A_4[num6])
						{
							objectValue = RuntimeHelpers.GetObjectValue(rows[num6].Cells[index3].Value);
							if (objectValue == null || !int.TryParse(objectValue.ToString(), out var result2) || result2 < 0)
							{
								break;
							}
							A_3[num6] = result2;
							if (flag)
							{
								A_5[num6] = -1;
							}
							else
							{
								objectValue = RuntimeHelpers.GetObjectValue(rows[num6].Cells[index5].Value);
								if (objectValue == null || !int.TryParse(objectValue.ToString(), out result2) || result2 < 0)
								{
									break;
								}
								A_5[num6] = result2;
								flag = A_5[num6] == A_3[num6];
							}
						}
						num6++;
						continue;
					}
					rows = null;
					A_0 = true;
					break;
				}
				break;
			}
		}
	}

	private void a(ref bool A_0, ref float A_1)
	{
		int index = bd().Columns.IndexOf(bl());
		checked
		{
			int num = bd().Rows.Count - 2;
			double num2 = 0.0;
			int num3 = num;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(bd().Rows[num4].Cells[index].Value);
				if (objectValue != null && float.TryParse(objectValue.ToString(), out var result) && result >= 0f)
				{
					num2 += (double)result;
					continue;
				}
				A_0 = false;
				return;
			}
			if (jf.c(num2, 100f))
			{
				A_0 = true;
				A_1 = (float)num2;
			}
			else
			{
				A_0 = false;
			}
		}
	}

	private void a(ref int A_0, ref jb.d[] A_1, ref string[] A_2, ref string A_3)
	{
		List<string> A_4 = null;
		List<jb.d> A_5 = null;
		a(ci, ref A_4, ref A_5, ref A_3);
		if (ci != jb.f.a)
		{
			A_3 = cj;
		}
		a(A_4, A_5, cg, ch, ref A_0, ref A_1, ref A_2);
	}

	private jb.a a(string A_0, double[] A_1, double[] A_2, double[] A_3, double A_4, int A_5, short A_6, int A_7, double[] A_8, short[] A_9, bool A_10)
	{
		jb.d[] A_11 = null;
		string[] A_12 = null;
		string A_13 = string.Empty;
		int A_14 = default(int);
		a(ref A_14, ref A_11, ref A_12, ref A_13);
		return checked(jb.a(A_0, A_1, A_2, A_3, (short)Math.Round(A_4), (short)A_5, A_6, (short)A_7, A_8, A_9, A_13, az().Text.Trim(), A_14, A_11, A_12, A_10));
	}

	private void a(ref double[] A_0, ref double[] A_1, ref double[] A_2, ref int A_3)
	{
		if (!c8)
		{
			b(ref A_0, ref A_1, ref A_2, ref A_3);
			return;
		}
		A_0 = this.m_b2;
		A_1 = b3;
		A_2 = b6;
		A_3 = this.m_b1;
	}

	private void a(bool A_0, bool A_1, bool A_2, ref bool A_3)
	{
		double[] A_4 = null;
		double[] A_5 = null;
		double[] A_6 = null;
		A_3 = false;
		if (jb.q(this.m_bv) && jb.q(this.m_bw) && !A_0)
		{
			fz a_ = c0;
			string A_7 = "EditMaterialLibraryInvalidFileType";
			fe.b(a_, hu.a(ref A_7), i6.a(this));
			return;
		}
		gr.d d10 = b2();
		string text;
		bool flag = default(bool);
		if (A_1)
		{
			text = jb.g() + "\\" + this.m_bv;
			flag = true;
		}
		else
		{
			if (string.Compare(this.m_bx, jb.d(), ignoreCase: true) == 0 && A_2)
			{
				dm obj = new dm();
				bool A_8 = default(bool);
				obj.a(c5.bb(), eb.b.a, Path.GetFileNameWithoutExtension(this.m_bv), this.m_b0, this.m_b0, i6.a(this), ref A_8);
				if (obj.DialogResult == DialogResult.Cancel)
				{
					fe.b(c0, "Save operation cancelled by user", "Information", i6.a(this));
					return;
				}
				if (!A_8)
				{
					c0.c(fz.b.a, "Failed attempting to save material file " + Path.GetFileNameWithoutExtension(this.m_bv) + " as local file in DialogEditLibrary.DoSave. Operation to change file status in database to deleted has failed.");
					fe.b(c0, "Failed trying to delete file from database. Save operation aborted.", i6.a(this));
					return;
				}
				jb.a(jb.h() + "\\" + Path.GetFileName(this.m_bv), eb.b.a);
				flag = true;
			}
			text = this.m_bx + "\\" + this.m_bv;
		}
		checked
		{
			if (bi().Checked)
			{
				float A_9 = 0f;
				bool A_10 = default(bool);
				a(ref A_10, ref A_9);
				if (!A_10)
				{
					fe.b(c0, "EditMaterialLibraryInvalidMixturePercentages", i6.a(this));
					return;
				}
				string[] A_11 = null;
				float[] A_12 = null;
				int[] A_13 = null;
				bool[] A_14 = null;
				int[] A_15 = null;
				bool A_16 = default(bool);
				a(ref A_16, ref A_11, ref A_12, ref A_13, ref A_14, ref A_15);
				if (!A_16)
				{
					throw new ApplicationException("Invalid mixture information");
				}
				bool A_17 = false;
				c(ref A_17);
				if (x().Checked && this.m_bu == null)
				{
					fe.b(c0, "Model coefficients were not calculated. File was not saved.", "Information", i6.a(this));
					return;
				}
				jb.d[] A_18 = null;
				string[] A_19 = null;
				string A_20 = null;
				int A_21 = default(int);
				a(ref A_21, ref A_18, ref A_19, ref A_20);
				if (A_0)
				{
					jb.a(text, (short)d10, A_11, A_12, A_13, A_14, A_20, x().Checked, this.m_bt, this.m_bp, this.m_bu, az().Text, A_21, A_18, A_19);
				}
				else
				{
					jb.a(text, (short)d10, A_11, A_12, A_13, A_14, x().Checked, this.m_bt, this.m_bp, this.m_bu, ay().Text);
				}
				co = A_0;
			}
			else
			{
				int A_22 = default(int);
				a(ref A_4, ref A_5, ref A_6, ref A_22);
				if (A_22 < 1)
				{
					fz a_2 = c0;
					string A_7 = "EditMaterialLibraryInsufficientPoints";
					fe.b(a_2, hu.a(ref A_7), i6.a(this));
					return;
				}
				int num = A_22 - 1;
				for (int num2 = 1; num2 <= num; num2++)
				{
					if (jf.c(A_4[num2], A_4[num2 - 1]))
					{
						fz a_3 = c0;
						string A_7 = "EditMaterialLibraryInvalidWavelengths";
						fe.b(a_3, hu.a(ref A_7), i6.a(this));
						return;
					}
				}
				bool flag2 = !jb.p(this.m_bv);
				if (A_6 == null)
				{
					A_6 = new double[A_22 + 1];
				}
				if (!b4 || c5.a8())
				{
					if (flag2)
					{
						text = Path.ChangeExtension(text, jb.i(this.m_bv));
					}
					if (a(text, A_4, A_5, A_6, A_22, unchecked((int)d10), this.m_bt, this.m_bp, this.m_br, this.m_bs, x().Checked) != jb.a.a)
					{
						fe.b(c0, "EditMaterialLibraryFileSaveError", i6.a(this));
						return;
					}
				}
				if (flag2 && (!b7 || c5.a8()) && !string.IsNullOrEmpty(this.m_bw))
				{
					text = Path.ChangeExtension(text, jb.g(this.m_bw));
					if (jf.a(A_6, A_22))
					{
						if (jb.a(text, A_4, A_6, null, (short)A_22, (short)d10, this.m_bt, (short)this.m_bp, this.m_br, this.m_bs, "", "", 0, null, null, x().Checked) != jb.a.a)
						{
							fe.b(c0, "EditMaterialLibraryFileSaveError", i6.a(this));
							return;
						}
					}
					else if (File.Exists(text))
					{
						FileInfo fileInfo = global::c.e().FileSystem.GetFileInfo(text);
						if ((fileInfo.Attributes & FileAttributes.ReadOnly) != 0)
						{
							File.SetAttributes(text, fileInfo.Attributes & ~FileAttributes.ReadOnly);
						}
						fileInfo = null;
						File.Delete(text);
					}
				}
			}
			if (A_1)
			{
				dl obj2 = new dl();
				if (!jb.n(text))
				{
					text = Path.ChangeExtension(text, jb.i(text));
				}
				bool A_23 = default(bool);
				obj2.a(c5.bb(), eb.b.a, text, this.m_b0, i6.a(this), ref A_23);
				if (!A_23)
				{
					c0.c(fz.b.a, "File Update in DB failed in DialogEditLibrary.DoSave");
					fe.b(c0, "Failed to save file. Error occurred while trying to update database", i6.a(this));
					return;
				}
				string text2 = this.m_bx + "\\" + this.m_bv;
				if (File.Exists(text2))
				{
					File.Delete(text2);
				}
				File.Copy(text, text2);
				File.Delete(text);
				jb.a(jb.d() + "\\" + Path.GetFileName(text), eb.b.a);
			}
			if (flag)
			{
				dn obj3 = new dn();
				obj3.a(c5.bb(), eb.b.a, i6.a(this));
				if (obj3.DialogResult == DialogResult.Cancel)
				{
					fe.b(c0, "Database summary file update process cancelled by user.\r\nOffline materials database usage may lead to errors.", "Information", i6.a(this));
					return;
				}
			}
			a(Path.GetFileName(this.m_bx));
			s().Enabled = this.m_bx.StartsWith(jb.d());
			A_3 = true;
			ct = true;
		}
	}

	public void a(bool A_0, bool A_1)
	{
		string text = "";
		string text2 = "";
		string a_ = this.m_bv;
		string text3 = this.m_bw;
		bool flag = cu;
		eb.a a10 = this.m_b0;
		bool A_2 = false;
		bool flag2 = false;
		double[] A_3 = null;
		double[] A_4 = null;
		double[] A_5 = null;
		checked
		{
			bool flag3;
			if (bi().Checked)
			{
				flag3 = true;
			}
			else
			{
				if (b9 && !cf)
				{
					throw new ApplicationException("Attempt to decrypt NK data which is not decryptable");
				}
				flag3 = false;
				int A_6 = default(int);
				a(ref A_3, ref A_4, ref A_5, ref A_6);
				if (A_5 != null)
				{
					int num = A_6 - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						if (A_5[num2] != 0.0)
						{
							flag2 = true;
							break;
						}
					}
				}
			}
			eb.a A_7 = default(eb.a);
			bool A_8 = default(bool);
			string text4 = jb.a(c0, c1, c2, this.m_by, this.m_bz, b4, b7, A_0, A_1, flag2, "", eb.b.a, null, c5.bh(), flag3, i6.a(this), ref A_7, ref A_2, ref A_8);
			if (string.IsNullOrEmpty(text4) || b(A_7))
			{
				return;
			}
			if (A_2 && !jb.n(text4) && flag2)
			{
				fz a_2 = c0;
				string A_9 = "MatFileWithKDBRequiresCombinedType";
				fe.b(a_2, hu.a(ref A_9), i6.a(this));
				return;
			}
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			if (!flag3)
			{
				if (b4 && !c5.a8())
				{
					flag4 = true;
					text = this.m_bx + "\\" + this.m_bv;
				}
				if (b7 && b6 != null && !c5.a8())
				{
					flag5 = true;
					text2 = this.m_bx + "\\" + this.m_bw;
				}
			}
			jb.a(text4, eb.b.a, text, text2);
			if (flag4)
			{
				c(Path.GetFileNameWithoutExtension(text4) + ".fmnnn");
				string text5 = Path.GetDirectoryName(text4) + "\\" + this.m_bv;
				if (Operators.CompareString(text.ToLower(), text5.ToLower(), TextCompare: false) != 0)
				{
					global::c.e().FileSystem.CopyFile(text, text5);
				}
			}
			else
			{
				c(Path.GetFileName(text4));
			}
			if (flag5)
			{
				this.m_bw = Path.GetFileNameWithoutExtension(text4) + ".fmkkk";
				string text5 = Path.GetDirectoryName(text4) + "\\" + this.m_bw;
				if (Operators.CompareString(text2.ToLower(), text5.ToLower(), TextCompare: false) != 0)
				{
					global::c.e().FileSystem.CopyFile(text2, text5);
				}
			}
			else if (jb.n(this.m_bv))
			{
				this.m_bw = "";
			}
			else
			{
				this.m_bw = Path.ChangeExtension(text4, jb.g(text4));
			}
			this.m_bx = Path.GetDirectoryName(text4);
			cu = A_2;
			this.m_b0 = A_7;
			string text6 = this.m_bv.ToLower();
			bool a_3 = A_0 && (text6.EndsWith(".fmnnn") || text6.EndsWith(".fmkkk") || text6.EndsWith(".fibnk") || text6.EndsWith(".fibnx"));
			text6 = null;
			bool flag6 = jb.n(this.m_bv);
			bool flag7 = !jb.q(this.m_bv);
			bool num3 = ((bi().Checked && co) || (!bi().Checked && b4)) && flag7;
			bool flag8 = (flag6 && flag7) || (!flag6 && !jb.q(this.m_bw));
			bool flag9 = !bi().Checked && b7 && flag8;
			if (num3 || flag9)
			{
				bool A_10 = false;
				string[] array;
				int[] array2;
				if (!bi().Checked && b9)
				{
					array = cc;
					array2 = ce;
				}
				else
				{
					array = new string[1] { cb };
					array2 = new int[1] { ca };
				}
				int num4 = array.Length - 1;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					string a_4 = array[num5];
					int a_5 = array2[num5];
					if (!string.IsNullOrEmpty(c5.a9()))
					{
						new @do().a(c5.a9(), a_4, a_5, this.m_bv, i6.a(ah()), ref A_10);
					}
					else
					{
						A_10 = false;
					}
					if (A_10)
					{
						continue;
					}
					string text7 = this.m_bx + "\\" + this.m_bv;
					bool num6 = !jb.n(this.m_bv);
					if (File.Exists(text7))
					{
						File.Delete(text7);
					}
					if (num6)
					{
						string path = Path.ChangeExtension(text7, jb.g(text7));
						if (File.Exists(path))
						{
							File.Delete(path);
						}
					}
					c(a_);
					this.m_bw = text3;
					cu = flag;
					this.m_b0 = a10;
					b1().Start();
					return;
				}
			}
			bool A_11 = default(bool);
			a(a_3, A_2, A_8, ref A_11);
			if (!A_11)
			{
				this.m_bv = a_;
				this.m_bw = text3;
				cu = flag;
				this.m_b0 = a10;
			}
		}
	}

	private void o()
	{
		this.m_bx = jb.d();
		c("Untitled");
		ak().Columns[0].HeaderText = "Wavelength(nm)";
		ak().Columns[1].HeaderText = "n";
		ad().Checked = true;
		short num = 0;
		checked
		{
			do
			{
				this.m_bq[num, 0] = "";
				this.m_bq[num, 1] = "";
				num = (short)unchecked(num + 1);
			}
			while (num <= 20000);
			b4 = false;
			b7 = false;
			co = false;
			cp = false;
			ct = false;
			b9 = false;
			ak().Rows.Clear();
			ak().Refresh();
			this.m_bp = 0;
			this.m_b1 = 0;
			c8 = true;
			c("Untitled");
			try
			{
				c7 = true;
				bi().Checked = false;
				y().Checked = false;
				x().Checked = false;
			}
			finally
			{
				c7 = false;
			}
			a(A_0: true, aj());
			n();
			a7().Rows.Clear();
			ay().Text = null;
			az().Text = null;
			cg = new List<string>();
			ch = new List<jb.d>();
			cj = null;
		}
	}

	private void n()
	{
		if (x().Checked)
		{
			z().Enabled = c5.a8() || c3.i(this.m_bt, c5, c6, A_3: true);
			fd obj = c4;
			ref short a_ = ref this.m_bt;
			ref int a_2 = ref this.m_bp;
			ref double[] a_3 = ref this.m_br;
			ref short[] a_4 = ref this.m_bs;
			bool A_ = true;
			obj.a(ref a_, ref a_2, ref a_3, ref a_4, ref A_);
		}
		else
		{
			z().Enabled = false;
		}
	}

	public void a(ref double[] A_0, ref short[] A_1, ref int A_2, ref short A_3)
	{
		checked
		{
			int num = A_2 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				this.m_br[num2] = A_0[num2];
				this.m_bs[num2] = A_1[num2];
			}
			this.m_bp = A_2;
			x().Checked = A_2 > 0;
			this.m_bt = A_3;
		}
	}

	private void a(ref short A_0)
	{
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		switch (A_0)
		{
		case 0:
			ah().Visible = true;
			aa().Visible = true;
			w().Visible = true;
			ag().Visible = false;
			be().Visible = false;
			if (ab().Checked)
			{
				flag = true;
			}
			if (ac().Checked)
			{
				flag2 = true;
			}
			if (ae().Checked)
			{
				flag3 = true;
			}
			if (af().Checked)
			{
				flag4 = true;
			}
			if (ad().Checked)
			{
				flag5 = true;
			}
			break;
		case 1:
			ah().Visible = false;
			w().Visible = false;
			ag().Visible = true;
			ab().Checked = false;
			ac().Checked = false;
			ae().Checked = false;
			af().Checked = false;
			ad().Checked = false;
			break;
		case 2:
			ag().Visible = false;
			be().Visible = true;
			w().Visible = true;
			y().Checked = false;
			bi().Checked = false;
			x().Checked = false;
			break;
		}
		if (flag)
		{
			ab().Checked = true;
		}
		if (flag2)
		{
			ac().Checked = true;
		}
		if (flag3)
		{
			ae().Checked = true;
		}
		if (flag4)
		{
			af().Checked = true;
		}
		if (flag5)
		{
			ad().Checked = true;
		}
		this.m_bn = A_0;
	}

	public void b(double[] A_0, int A_1, double[] A_2, double[] A_3)
	{
		if (A_1 > 20000)
		{
			A_1 = 20000;
		}
		a(A_0, A_1, A_2, A_3);
	}

	public void a(short A_0, ref double[,] A_1, ref double[,] A_2)
	{
		if (A_0 > 20000)
		{
			A_0 = 20000;
		}
		checked
		{
			int num = A_0 - 1;
			double[] array = new double[num + 1];
			double[] array2 = new double[num + 1];
			double[] array3 = new double[num + 1];
			int num2 = num;
			bool flag = default(bool);
			for (int num3 = 0; num3 <= num2; num3++)
			{
				array[num3] = A_1[num3, 0];
				array2[num3] = A_1[num3, 1];
				array3[num3] = A_2[num3, 1];
				if (array3[num3] != 0.0)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				array3 = null;
			}
			a(array, A_0, array2, array3);
		}
	}

	private void a(double[] A_0, int A_1, double[] A_2, double[] A_3)
	{
		this.m_b2 = A_0;
		b3 = A_2;
		b6 = A_3;
		this.m_b1 = A_1;
		checked
		{
			int num = A_1 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				this.m_bq[num2, 0] = this.m_b2[num2].ToString("0.00");
				this.m_bq[num2, 1] = b3[num2].ToString("0.0000");
				if (A_3 != null)
				{
					this.m_bq[num2, 2] = A_3[num2].ToString("0.0000");
				}
				else
				{
					this.m_bq[num2, 2] = string.Empty;
				}
			}
			for (int num3 = A_1; num3 <= 20000; num3++)
			{
				this.m_bq[num3, 0] = string.Empty;
				this.m_bq[num3, 1] = string.Empty;
				this.m_bq[num3, 2] = string.Empty;
			}
			b4 = false;
			b7 = false;
			b9 = false;
			c8 = true;
			bool A_4 = false;
			f(ref A_4);
		}
	}

	public gr.d b2()
	{
		if (ab().Checked)
		{
			return gr.d.a;
		}
		if (ac().Checked)
		{
			return gr.d.b;
		}
		if (ae().Checked)
		{
			return gr.d.c;
		}
		if (af().Checked)
		{
			return gr.d.f;
		}
		return gr.d.d;
	}

	public void a(gr.d A_0)
	{
		switch (A_0)
		{
		case gr.d.a:
			ab().Checked = true;
			break;
		case gr.d.b:
			ac().Checked = true;
			break;
		case gr.d.c:
			ae().Checked = true;
			break;
		case gr.d.f:
			af().Checked = true;
			break;
		case gr.d.d:
			ad().Checked = true;
			break;
		case gr.d.e:
			break;
		}
	}

	private void ab(object A_0, EventArgs A_1)
	{
		string A_2 = "";
		try
		{
			string A_3 = "";
			a(ref A_3, A_1: true, ref A_2);
			if (!string.IsNullOrEmpty(A_2))
			{
				a(A_2, A_3);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			ref fz a_2 = ref c0;
			Point A_4 = i6.a(t());
			fe.b(ref a_2, "Error trying to open material file.", ref A_4);
			c0.c(fz.b.b, "Error trying to open material file. Error is: ", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(ref string A_0, bool A_1, ref string A_2)
	{
		if (Directory.Exists(jb.h()))
		{
			c4 obj = new c4();
			fz a_ = c0;
			f1 a_2 = c1;
			f4 a_3 = c2;
			bool a_4 = c5.bh();
			string a_5 = c5.bb();
			LicenseLevel a_6 = this.m_bz;
			bool a_7 = this.m_by;
			bool a_8 = c5.bh();
			eb.a A_3 = eb.a.a;
			bool A_4 = false;
			bool A_5 = false;
			obj.a(a_, a_2, a_3, global::c4.a.a, a_4, A_5: true, A_1, A_7: false, a_5, a_6, eb.b.a, A_11: false, a_7, null, a_8, ref A_2, ref A_3, ref A_4, A_18: false, A_19: false, ref A_5);
			if (obj.DialogResult == DialogResult.OK)
			{
				if (jb.q(A_2))
				{
					A_0 = "Encrypted Material File";
				}
				else
				{
					A_0 = "Material File";
				}
			}
		}
		else
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Open Library File";
			openFileDialog.InitialDirectory = jb.d();
			openFileDialog.Filter = jb.a(c5.bh());
			openFileDialog.FilterIndex = global::e.a().LastUsedOpenMaterialIndex;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				global::e.a().LastUsedOpenMaterialIndex = openFileDialog.FilterIndex;
				A_2 = openFileDialog.FileName;
				A_0 = openFileDialog.Filter.Split(';')[openFileDialog.FilterIndex].Split('|')[0];
			}
		}
	}

	private void a(ref int A_0, List<string> A_1, jb.d A_2)
	{
		checked
		{
			foreach (string item in A_1)
			{
				DataGridViewCellCollection cells = a7().Rows[A_0].Cells;
				cells[0].Value = item;
				cells[1].Value = jb.d(A_2);
				_ = null;
				A_0++;
			}
		}
	}

	private void a(jb.d A_0, string A_1, List<string> A_2, List<string> A_3, List<string> A_4, List<string> A_5, List<string> A_6, List<string> A_7, List<string> A_8, List<string> A_9, List<string> A_10, List<string> A_11, List<string> A_12)
	{
		switch (A_0)
		{
		case jb.d.a:
			A_2.Add(A_1);
			break;
		case jb.d.b:
			A_3.Add(A_1);
			break;
		case jb.d.c:
			A_4.Add(A_1);
			break;
		case jb.d.d:
			A_5.Add(A_1);
			break;
		case jb.d.e:
			A_6.Add(jb.b((jb.g)Conversions.ToShort(A_1)));
			break;
		case jb.d.f:
			A_7.Add(i6.a(A_1, "0.##"));
			break;
		case jb.d.g:
			A_8.Add(i6.a(A_1, "0.##"));
			break;
		case jb.d.h:
			A_9.Add(i6.a(A_1, "0.##"));
			break;
		case jb.d.i:
			A_10.Add(i6.a(A_1, "0.##"));
			break;
		case jb.d.j:
			A_11.Add(A_1);
			break;
		case jb.d.l:
			A_12.Add(A_1);
			break;
		case jb.d.k:
			break;
		}
	}

	private void a(List<string> A_0, List<jb.d> A_1, string A_2)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		List<string> list3 = new List<string>();
		List<string> list4 = new List<string>();
		List<string> list5 = new List<string>();
		List<string> list6 = new List<string>();
		List<string> list7 = new List<string>();
		List<string> list8 = new List<string>();
		List<string> list9 = new List<string>();
		List<string> list10 = new List<string>();
		List<string> list11 = new List<string>();
		string text = null;
		string text2 = null;
		int num = 0;
		if (jb.ai(bw().SelectedItem.ToString()) == jb.f.a)
		{
			text = A_2;
		}
		checked
		{
			int num2 = A_0.Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (A_1[num3] == jb.d.k)
				{
					jb.e e10 = jb.ag(A_0[num3]);
					switch (e10)
					{
					case jb.e.d:
						text = jb.af(A_0[num3]);
						break;
					case jb.e.e:
						text2 = jb.af(A_0[num3]);
						break;
					default:
						a(jb.a(e10), jb.af(A_0[num3]), list, list2, list3, list4, list5, list6, list7, list8, list9, list10, list11);
						num++;
						break;
					}
				}
				else if (A_1[num3] == jb.d.m)
				{
					text2 = A_0[num3];
				}
				else
				{
					a(A_1[num3], A_0[num3], list, list2, list3, list4, list5, list6, list7, list8, list9, list10, list11);
					num++;
				}
			}
			list.Sort();
			list2.Sort();
			list3.Sort();
			list4.Sort();
			list5.Sort();
			list6.Sort();
			list7.Sort();
			list8.Sort();
			list9.Sort();
			DataGridViewRowCollection rows = a7().Rows;
			rows.Clear();
			if (num > 0)
			{
				rows.Add(num);
				int num3 = 0;
				a(ref num3, list, jb.d.a);
				a(ref num3, list2, jb.d.b);
				a(ref num3, list3, jb.d.c);
				a(ref num3, list4, jb.d.d);
				a(ref num3, list5, jb.d.e);
				a(ref num3, list6, jb.d.f);
				a(ref num3, list7, jb.d.g);
				a(ref num3, list8, jb.d.h);
				a(ref num3, list9, jb.d.i);
				a(ref num3, list10, jb.d.j);
				a(ref num3, list11, jb.d.l);
			}
			rows = null;
			if (by().Checked)
			{
				ay().Text = text;
				cl = text2;
				ck = null;
			}
			else
			{
				ay().Text = text2;
				ck = text;
				cl = null;
			}
		}
	}

	private void a(string A_0, string A_1)
	{
		string A_2 = "";
		double[] A_3 = null;
		double[] A_4 = null;
		string A_5 = "";
		string A_6 = "";
		jb.d[] A_7 = null;
		string[] A_8 = null;
		string A_9 = null;
		string A_10 = "";
		string a_ = Path.GetExtension(A_0).ToLower();
		bool flag = c5.bh();
		short A_12 = default(short);
		checked
		{
			int A_13 = default(int);
			int A_14 = default(int);
			bool flag2;
			int A_32;
			if (jb.m(a_))
			{
				jc A_11 = null;
				A_9 = A_0;
				jb.b(A_9, A_1: false, ref A_11, ref A_12, ref A_5, ref A_10, ref A_13, ref A_6, ref A_14, ref A_7, ref A_8);
				jc jc2 = A_11;
				if (!flag && jc2.a)
				{
					fz a_2 = c0;
					string A_15 = "ErrorMessageInvalidFileOpenTypeSASWFmt";
					fe.b(a_2, string.Format(hu.a(ref A_15), A_1), i6.a(t()));
					return;
				}
				if (string.IsNullOrEmpty(A_10) && jc2.a)
				{
					A_10 = "\\NotViewable\\";
				}
				if (jc2.k && jc2.m != c3.j(jc2.l))
				{
					throw new av("Num model coefficients is incorrect for given model type. fileModelID=" + jc2.l + "; fileModelNumCoeffs =" + jc2.m);
				}
				a(jc2.b, jc2.h, jc2.i, jc2.j);
				co = jc2.a;
				this.m_bt = (short)jc2.l;
				cp = true;
				this.m_bw = string.Empty;
				this.m_b1 = 0;
				try
				{
					c7 = true;
					bi().Checked = true;
					if (jc2.k)
					{
						x().Checked = true;
						iz.b(bq(), this.m_bt);
						this.m_bt = (short)jc2.l;
						this.m_bp = jc2.m;
					}
					else
					{
						y().Checked = true;
						this.m_bp = 0;
					}
				}
				finally
				{
					c7 = false;
				}
				this.m_bu = jc2.n;
				jc2 = null;
				flag2 = !co || ((c5.a8() || c5.a3()) && Operators.CompareString(A_10, "\\NotViewable\\", TextCompare: false) != 0);
			}
			else
			{
				if (!jb.p(a_))
				{
					A_0 = Path.ChangeExtension(A_0, jb.i(a_));
					if (!File.Exists(A_0))
					{
						A_0 = Path.ChangeExtension(A_0, jb.h(a_));
					}
				}
				double[] A_16 = null;
				double[] A_17 = null;
				double[] A_18 = null;
				short[] A_19 = null;
				double[] A_20 = null;
				bool A_21 = false;
				string text = null;
				string a_3 = A_0;
				hd a_4 = c3;
				eo a_5 = c5;
				jc A_22 = null;
				int A_23 = default(int);
				short A_24 = default(short);
				int A_25 = default(int);
				bool A_26 = default(bool);
				bool A_27 = default(bool);
				bool A_28 = default(bool);
				jb.a a10 = jb.a(a_3, A_1: false, ref A_16, ref A_17, ref A_18, A_5: true, A_6: true, ref A_23, a_4, ref A_12, ref A_24, ref A_25, ref A_19, ref A_20, a_5, ref A_2, ref A_26, ref A_27, ref A_28, ref A_5, ref A_6, ref A_13, ref A_10, ref A_14, ref A_7, ref A_8, ref A_21, ref A_9, ref A_22, c6);
				if (a10 != jb.a.a)
				{
					if (a10 == jb.a.f && jb.k(a_))
					{
						fz a_6 = c0;
						string A_15 = "ErrorMissingNFile";
						fe.b(a_6, hu.a(ref A_15), i6.a(this));
					}
					else
					{
						fe.b(c0, A_2, i6.a(this));
					}
					return;
				}
				if (!flag && (A_26 || A_27))
				{
					fz a_7 = c0;
					string A_15 = "ErrorMessageInvalidFileOpenTypeSASWFmt";
					fe.b(a_7, string.Format(hu.a(ref A_15), A_1), i6.a(this));
					return;
				}
				if (jb.j(A_0))
				{
					text = Path.ChangeExtension(A_0, jb.g(A_0));
					if (!File.Exists(text))
					{
						text = Path.ChangeExtension(A_0, jb.f(A_0));
					}
					string a_8 = text;
					double[] A_29 = null;
					short A_30 = 0;
					short A_31 = 0;
					A_32 = 0;
					short[] A_33 = null;
					double[] A_34 = null;
					eo a_9 = c5;
					bool A_35 = false;
					string A_15 = "";
					string A_36 = "";
					int A_37 = 0;
					string A_38 = null;
					int A_39 = 0;
					jb.d[] A_40 = null;
					string[] A_41 = null;
					bool A_42 = false;
					string A_43 = null;
					A_22 = null;
					int A_44 = default(int);
					if (jb.a(a_8, A_1: false, ref A_3, ref A_4, ref A_29, A_5: false, A_6: false, ref A_44, null, ref A_30, ref A_31, ref A_32, ref A_33, ref A_34, a_9, ref A_2, ref A_27, ref A_35, ref A_28, ref A_15, ref A_36, ref A_37, ref A_38, ref A_39, ref A_40, ref A_41, ref A_42, ref A_43, ref A_22, c6) == jb.a.a && A_28)
					{
						A_18 = new double[A_23 - 1 + 1];
						jf.a(ref A_3, ref A_4, A_44, ref A_16, ref A_18, A_23);
					}
					else
					{
						text = "";
						A_18 = null;
						A_27 = A_26;
					}
				}
				if (!flag && (A_26 || A_27))
				{
					fz a_10 = c0;
					string A_43 = "ErrorMessageInvalidFileOpenTypeSASWFmt";
					fe.b(a_10, string.Format(hu.a(ref A_43), A_1), i6.a(t()));
					return;
				}
				if (A_23 > 0)
				{
					int num = A_23 - 1;
					double[] array = new double[num + 1];
					double[] array2 = new double[num + 1];
					double[] array3 = null;
					array[0] = A_16[0];
					array2[0] = A_17[0];
					if (A_18 != null)
					{
						array3 = new double[num + 1];
						array3[0] = A_18[0];
					}
					int num2 = 1;
					int A_39 = num;
					for (int num3 = 1; num3 <= A_39; num3++)
					{
						if (jf.b(A_16[num3], array[num2 - 1]))
						{
							array[num2] = A_16[num3];
							array2[num2] = A_17[num3];
							if (A_18 != null)
							{
								array3[num2] = A_18[num3];
							}
							num2++;
						}
						else if (!jf.e(A_16[num3], array[num2 - 1]))
						{
							fz a_11 = c0;
							string A_43 = "EditMaterialLibraryInvalidWavelengths";
							fe.b(a_11, hu.a(ref A_43), i6.a(t()));
							return;
						}
					}
					A_16 = array;
					A_17 = array2;
					A_18 = array3;
					A_23 = num2;
				}
				bi().Checked = false;
				this.m_b2 = A_16;
				b3 = A_17;
				if (A_18 == null)
				{
					b6 = new double[b3.GetUpperBound(0) + 1];
				}
				else
				{
					b6 = A_18;
				}
				this.m_b1 = A_23;
				try
				{
					c7 = true;
					y().Checked = true;
				}
				finally
				{
					c7 = false;
				}
				x().Checked = !A_21;
				this.m_bt = A_24;
				this.m_bp = A_25;
				this.m_bs = A_19;
				this.m_br = A_20;
				b4 = A_26;
				b7 = A_27;
				this.m_bw = Path.GetFileName(text);
				b9 = false;
				if (string.IsNullOrEmpty(A_10))
				{
					if (c5.a8())
					{
						bool flag3 = false;
						int A_37 = this.m_b1 - 1;
						double num5 = default(double);
						double num6 = default(double);
						double num7 = default(double);
						for (int num4 = 0; num4 <= A_37; num4++)
						{
							if (this.m_b2[num4] > 10000.0 || this.m_b2[num4] < 0.0 || b3[num4] > 100.0 || b3[num4] < 0.0 || b6[num4] > 1000.0 || b6[num4] < 0.0)
							{
								flag3 = true;
								break;
							}
							num5 += this.m_b2[num4];
							num6 += b3[num4];
							num7 += b6[num4];
						}
						A_10 = ((!flag3) ? (((int)Math.Round(num5)).ToString() + (int)Math.Round(num6) + (int)Math.Round(num7)) : "\\NotViewable\\");
					}
					else
					{
						A_10 = "\\NotViewable\\";
					}
				}
				flag2 = !b4 || !b7 || ((c5.a8() || c5.a3()) && Operators.CompareString(A_10, "\\NotViewable\\", TextCompare: false) != 0);
			}
			cb = A_10;
			ca = A_13;
			c8 = true;
			this.m_bx = Path.GetDirectoryName(A_9);
			c(Path.GetFileName(A_9));
			az().Text = A_6;
			List<int> list = new List<int>();
			A_32 = A_14 - 1;
			for (int num8 = 0; num8 <= A_32; num8++)
			{
				jb.d d10 = A_7[num8];
				if (d10 < jb.d.a || unchecked((int)d10) > Enum.GetValues(typeof(jb.d)).GetUpperBound(0))
				{
					list.Add(num8);
				}
			}
			if (list.Count > 0)
			{
				int num9 = A_14 - list.Count - 1;
				jb.d[] array4 = null;
				string[] array5 = null;
				if (num9 >= 0)
				{
					array4 = new jb.d[num9 + 1];
					array5 = new string[num9 + 1];
					int num10 = 0;
					int num11 = list[0];
					int num12 = 0;
					int num13 = A_14 - 1;
					for (int num14 = 0; num14 <= num13; num14++)
					{
						if (num14 != num11)
						{
							array5[num12] = A_8[num14];
							array4[num12] = A_7[num14];
							num12++;
							continue;
						}
						num10++;
						if (num10 < list.Count)
						{
							num11 = list[num10];
						}
					}
				}
				A_14 = num9 + 1;
				A_8 = array5;
				A_7 = array4;
				ref fz a_12 = ref c0;
				string A_43 = "EditLibraryUnknownAttributes";
				string a_13 = hu.a(ref A_43);
				Point A_45 = i6.a(this);
				fe.b(ref a_12, a_13, ref A_45);
			}
			cj = A_5;
			List<string> A_46 = null;
			List<jb.d> A_47 = null;
			a(A_14, A_8, A_7, jb.ai(bw().SelectedItem.ToString()), ref A_46, ref A_47, ref cg, ref ch, ref ci);
			a(A_46, A_47, cj);
			r().Enabled = flag2;
			a(A_10);
			v().Enabled = flag2;
			n();
			da = false;
			if (((bi().Checked && co) || (!bi().Checked && b4)) && Operators.CompareString(cb, "\\NotViewable\\", TextCompare: false) != 0)
			{
				if (c5.a8() || c5.a3())
				{
					a5().Enabled = c5.a8();
				}
				else
				{
					da = true;
					a4().Visible = true;
					try
					{
						c7 = true;
						a4().Checked = File.Exists(Path.ChangeExtension(jb.d() + "\\" + Path.GetFileName(A_0), ".fivrq"));
					}
					finally
					{
						c7 = false;
					}
					if (!flag2)
					{
						flag2 = a4().Checked;
					}
				}
			}
			else
			{
				p();
			}
			a(flag2, am());
			k();
		}
		if (A_12 == 0)
		{
			short A_31 = 1;
			a(ref A_31);
			ref fz a_14 = ref c0;
			Point A_45 = i6.a(t());
			fe.b(ref a_14, "File does not specify material type, click an option to select type", ref A_45);
		}
		else
		{
			short A_31 = 0;
			a(ref A_31);
			a((gr.d)A_12);
		}
		ct = true;
	}

	private void c(string A_0)
	{
		this.m_bv = A_0;
		Text = "Edit File: " + this.m_bv;
	}

	private void m()
	{
		TabControl.TabPageCollection tabPages = ah().TabPages;
		if (!tabPages.Contains(aj()))
		{
			tabPages.Insert(0, aj());
		}
		if (!tabPages.Contains(ai()))
		{
			tabPages.Insert(1, ai());
		}
		tabPages = null;
	}

	private bool b(string A_0)
	{
		if (co)
		{
			if (c5.a8() || c5.a3())
			{
				return Operators.CompareString(A_0, "\\NotViewable\\", TextCompare: false) != 0;
			}
			return false;
		}
		return true;
	}

	private void a(string A_0)
	{
		s().Enabled = b(A_0) && this.m_bx.StartsWith(jb.d()) && (string.Compare(this.m_bx, jb.h(), ignoreCase: true) != 0 || (this.m_by && this.m_bz > LicenseLevel.ReadOnly && (this.m_b0 < eb.a.f || this.m_bz >= LicenseLevel.ShippingReadWrite)));
	}

	private void l()
	{
		checked
		{
			short num = (short)(this.m_b1 - 1);
			short num2;
			for (num2 = 0; num2 <= num; num2 = (short)unchecked(num2 + 1))
			{
				this.m_bq[num2, 0] = this.m_b2[num2].ToString("####.00");
				this.m_bq[num2, 1] = b3[num2].ToString("0.0000");
				if (b6 != null)
				{
					this.m_bq[num2, 2] = ((float)b6[num2]).ToString();
				}
				else
				{
					this.m_bq[num2, 2] = "";
				}
			}
			if (num2 >= 20000)
			{
				ref fz a_ = ref c0;
				Point A_ = i6.a(this);
				fe.b(ref a_, "Too many data points, data truncated", ref A_);
			}
			for (short num3 = num2; num3 <= 20000; num3 = (short)unchecked(num3 + 1))
			{
				this.m_bq[num3, 0] = "";
				this.m_bq[num3, 1] = "";
				this.m_bq[num3, 2] = "";
			}
		}
	}

	private void a(bool A_0, TabPage A_1)
	{
		TabControl tabControl = ah();
		if (A_0)
		{
			TabControl.TabPageCollection tabPages = tabControl.TabPages;
			m();
			if (bi().Checked && !tabPages.Contains(bc()))
			{
				tabPages.Insert(0, bc());
			}
			else if (!bi().Checked && tabPages.Contains(bc()))
			{
				tabPages.Remove(bc());
			}
			tabPages = null;
			l();
			if (A_1 != null)
			{
				tabControl.SelectedTab = A_1;
			}
			fd obj = c4;
			ref short a_ = ref this.m_bt;
			ref int a_2 = ref this.m_bp;
			ref double[] a_3 = ref this.m_br;
			ref short[] a_4 = ref this.m_bs;
			bool A_2 = true;
			obj.a(ref a_, ref a_2, ref a_3, ref a_4, ref A_2);
		}
		else
		{
			TabControl.TabPageCollection tabPages2 = tabControl.TabPages;
			if (tabPages2.Contains(ai()))
			{
				tabPages2.Remove(ai());
			}
			if (tabPages2.Contains(aj()))
			{
				tabPages2.Remove(aj());
			}
			if (tabPages2.Contains(bc()))
			{
				tabPages2.Remove(bc());
			}
			tabPages2 = null;
		}
		tabControl = null;
	}

	private void k()
	{
		j();
		i();
	}

	private void j()
	{
		if (ah().SelectedTab == aj())
		{
			bool A_ = false;
			f(ref A_);
		}
	}

	private void i()
	{
		bool A_;
		if (ah().TabPages.Contains(ai()))
		{
			A_ = false;
			b(ref A_);
		}
		A_ = false;
		a(ref A_);
	}

	private void f(ref bool A_0)
	{
		if (!c8)
		{
			return;
		}
		checked
		{
			try
			{
				c7 = true;
				e(ref A_0);
				bool A_1 = default(bool);
				if (b4 || b7)
				{
					a(e7.d.a, ref A_1);
				}
				DataGridView dataGridView = ak();
				dataGridView.Rows.Clear();
				Cursor = Cursors.WaitCursor;
				int num = ((b6 != null || this.m_b1 <= 0) ? 3 : 2);
				dataGridView.Columns[2].Visible = b6 != null;
				if (this.m_b1 != 0)
				{
					at().Visible = true;
					Refresh();
					bool flag = !b4 || A_1;
					bool flag2 = !b7 || A_1;
					double[] A_2 = null;
					double[] A_3 = null;
					double[] A_4 = null;
					int A_5 = default(int);
					a(ref A_2, ref A_3, ref A_5, ref A_4);
					if (A_5 == 0)
					{
						return;
					}
					dataGridView.Rows.Add(A_5);
					string[] array = new string[num - 1 + 1];
					int num2 = A_5 - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						array[0] = A_2[num3].ToString();
						if (flag)
						{
							array[1] = A_3[num3].ToString();
						}
						else
						{
							array[1] = "*****";
						}
						if (num == 3)
						{
							if (flag2)
							{
								array[2] = A_4[num3].ToString();
							}
							else
							{
								array[2] = "*****";
							}
						}
						dataGridView.Rows[num3].SetValues(array);
					}
					dataGridView.Columns[1].ReadOnly = !flag;
					dataGridView.Columns[2].ReadOnly = !flag2;
				}
				if (bi().Checked)
				{
					dataGridView.ReadOnly = true;
					dataGridView.ForeColor = SystemColors.InactiveCaptionText;
					dataGridView.BackColor = SystemColors.InactiveCaption;
				}
				else
				{
					dataGridView.ReadOnly = false;
					dataGridView.ForeColor = Color.Black;
					dataGridView.BackColor = SystemColors.Window;
				}
				dataGridView = null;
			}
			finally
			{
				c7 = false;
				c8 = false;
				at().Visible = false;
				Cursor = Cursors.Default;
			}
		}
	}

	private void a(ref double[] A_0, ref double[] A_1, ref int A_2, ref double[] A_3)
	{
		checked
		{
			if (da)
			{
				int num = this.m_b1 - 1;
				double num2 = dd;
				double num3 = de;
				int num4;
				for (num4 = 0; num4 <= num && this.m_b2[num4] < num2; num4++)
				{
				}
				int num5;
				for (num5 = num4; num5 < num && this.m_b2[num5] < num3; num5++)
				{
				}
				if (this.m_b2[num5] > num3)
				{
					num5--;
				}
				int num6 = num5 - num4;
				A_2 = num6 + 1;
				A_0 = new double[num6 + 1];
				A_1 = new double[num6 + 1];
				if (b6 != null)
				{
					A_3 = new double[num6 + 1];
				}
				int num7 = 0;
				int num8 = num4;
				int num9 = num5;
				for (int num10 = num8; num10 <= num9; num10++)
				{
					A_0[num7] = this.m_b2[num10];
					A_1[num7] = b3[num10];
					if (A_3 != null)
					{
						A_3[num7] = b6[num10];
					}
					num7++;
				}
			}
			else
			{
				A_0 = this.m_b2;
				A_1 = b3;
				A_2 = this.m_b1;
				A_3 = b6;
			}
		}
	}

	private void e(ref bool A_0)
	{
		if (bi().Checked)
		{
			d(ref A_0);
		}
	}

	private void d(ref bool A_0)
	{
		if (cp)
		{
			ref double[] a_ = ref this.m_b2;
			ref double[] a_2 = ref b3;
			ref double[] a_3 = ref b6;
			ref bool a_4 = ref b4;
			ref bool a_5 = ref b7;
			ref string[] a_6 = ref cc;
			ref string[] a_7 = ref cd;
			ref int[] a_8 = ref ce;
			ref bool a_9 = ref cf;
			string A_1 = null;
			bool A_2 = default(bool);
			a(ref A_2, ref a_, ref a_2, ref a_3, ref a_4, ref a_5, ref a_6, ref a_7, ref a_8, ref a_9, ref A_0, ref A_1);
			if (A_2)
			{
				this.m_b1 = this.m_b2.Length;
				b9 = true;
			}
			else
			{
				this.m_b1 = 0;
				b9 = false;
			}
			if (!A_0)
			{
				cp = false;
			}
		}
	}

	private void c(ref bool A_0)
	{
		if (bi().Checked && x().Checked && this.m_bu == null)
		{
			c1 c10 = new c1();
			c10.a(A_0: true);
			b b10 = new b(c0, c10);
			ThreadPool.QueueUserWorkItem(a, b10);
			c10.StartPosition = FormStartPosition.Manual;
			i6.a(i6.a(this), c10);
			c10.b("Computing nk model grid point coefficients...");
			Monitor.Enter(b10);
			try
			{
				A_0 = b10.b || c10.DialogResult == DialogResult.Cancel;
			}
			finally
			{
				Monitor.Exit(b10);
			}
			if (this.m_bu == null && !A_0)
			{
				throw new ApplicationException("Failed to update Grid Point Custom Model Coefficients. See log file for details.");
			}
		}
	}

	private void a(int A_0, double[] A_1, int A_2, double[] A_3, double[] A_4, int A_5, string A_6, double[] A_7, double[] A_8, double[] A_9, double[] A_10, fz A_11, ref double A_12, ref double A_13)
	{
		StreamWriter streamWriter = null;
		checked
		{
			int num = A_2 - 1;
			try
			{
				streamWriter = new StreamWriter(A_6 + "Grid Pt Idx=" + Conversions.ToString(A_0) + ".csv");
				streamWriter.WriteLine("\"Wavelen(nm)\", \"nTarget\", \"kTarget\", \"nResult\", \"kResult\", \"InitGuessnkCoeffs\", \"Result nkCoeffs\"");
				int num2 = ((A_2 <= A_5) ? (A_5 - 1) : num);
				int num3 = num2;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (num4 < A_2)
					{
						streamWriter.Write(A_1[num4] + ", " + A_3[num4] + ", " + A_4[num4] + ", " + A_8[A_2 + num4] + ", " + A_9[A_2 + num4]);
					}
					else
					{
						streamWriter.Write(", , , ,");
					}
					if (num4 < A_5)
					{
						streamWriter.WriteLine(", " + A_7[num4 + 1] + ", " + A_10[num4 + 1]);
					}
					else
					{
						streamWriter.WriteLine();
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				A_11.c(fz.b.a, "Error in WriteGridPtCoeffDebugDetails", a_);
				ProjectData.ClearProjectError();
			}
			finally
			{
				streamWriter?.Close();
			}
			int num5 = num;
			double num8 = default(double);
			double num9 = default(double);
			for (int num6 = 0; num6 <= num5; num6++)
			{
				double num7 = A_3[num6] - A_8[num6];
				num8 += num7 * num7;
				num7 = A_4[num6] - A_9[num6];
				num9 += num7 * num7;
			}
			A_12 = Math.Sqrt(num8 / (double)A_2);
			A_13 = Math.Sqrt(num9 / (double)A_2);
		}
	}

	private void a(object A_0)
	{
		string[] A_1 = null;
		int[] A_2 = null;
		bool[] A_3 = null;
		float[] A_4 = null;
		b b10 = (b)A_0;
		checked
		{
			try
			{
				this.m_bu = null;
				int[] A_5 = null;
				bool A_6 = default(bool);
				a(ref A_6, ref A_1, ref A_4, ref A_2, ref A_3, ref A_5);
				if (!A_6)
				{
					return;
				}
				int num = A_1.Length - 1;
				int num2 = num - 1;
				int num3 = jb.a(num2, A_3, A_2);
				int num4 = num3 - 1;
				int num5 = this.m_bp - 1;
				bool[] array = new bool[num + 1];
				bool[] array2 = new bool[num + 1];
				bool flag = true;
				bool flag2 = true;
				float num6 = 1f;
				int num7 = num2;
				bool flag3 = default(bool);
				int num8;
				for (num8 = 0; num8 <= num7; num8++)
				{
					if (A_3[num8])
					{
						flag3 = jf.e(A_4[num8], 1f);
						if (!jf.e(A_4[num8], 0f) && !flag3)
						{
							flag = false;
						}
					}
					else
					{
						flag2 = false;
					}
					num6 -= A_4[num8];
				}
				float[][] array3 = new float[num + 1][];
				int A_11;
				if (flag)
				{
					double[] A_7 = null;
					int num9 = num;
					short A_28 = default(short);
					bool A_29 = default(bool);
					for (num8 = 0; num8 <= num9; num8++)
					{
						bool flag4;
						if (num8 == num)
						{
							flag4 = flag2;
							if (flag2)
							{
								flag3 = jf.e(num6, 1f);
							}
						}
						else
						{
							flag4 = A_3[num8];
							flag3 = jf.e(A_4[num8], 1f);
						}
						array[num8] = flag4 && flag3;
						array2[num8] = flag4;
						if ((!flag4 || !flag3) && flag4)
						{
							continue;
						}
						string a_ = A_1[num8];
						double[] A_8 = null;
						double[] A_9 = null;
						double[] A_10 = null;
						A_11 = 0;
						hd a_2 = c3;
						short A_12 = 0;
						int A_13 = 0;
						short[] A_14 = null;
						eo a_3 = c5;
						string A_15 = null;
						bool A_16 = false;
						bool A_17 = false;
						bool A_18 = false;
						string A_19 = null;
						string A_20 = null;
						int A_21 = 0;
						string A_22 = null;
						int A_23 = 0;
						jb.d[] A_24 = null;
						string[] A_25 = null;
						string A_26 = null;
						jc A_27 = null;
						if (jb.a(a_, A_1: false, ref A_8, ref A_9, ref A_10, A_5: true, A_6: true, ref A_11, a_2, ref A_12, ref A_28, ref A_13, ref A_14, ref A_7, a_3, ref A_15, ref A_16, ref A_17, ref A_18, ref A_19, ref A_20, ref A_21, ref A_22, ref A_23, ref A_24, ref A_25, ref A_29, ref A_26, ref A_27, c6) != jb.a.a)
						{
							return;
						}
						if (!A_29 && hd.i(A_28, this.m_bt))
						{
							float[] array4 = new float[num5 + 1];
							A_23 = num5;
							for (int num10 = 0; num10 <= A_23; num10++)
							{
								array4[num10] = (float)A_7[num10];
							}
							array3[num8] = array4;
						}
					}
				}
				b10.c.a(num3);
				double[] A_30 = null;
				double[] array5 = null;
				double[] array6 = new double[2];
				double[] array7 = new double[2];
				double[] array8 = new double[2];
				short[] array9 = new short[12];
				double[] array10 = new double[16];
				short[] array11 = new short[3];
				short[] array12 = new short[3];
				double[] array13 = new double[3];
				short[] array14 = new short[3];
				short[] array15 = new short[3];
				float[] array16 = new float[3];
				short[] array17 = new short[3];
				double[] array18 = null;
				short[] array19 = null;
				float[] array20 = new float[num3 * this.m_bp - 1 + 1];
				short[] array21 = null;
				double[] array22 = null;
				double[] array23 = null;
				double[] array24 = null;
				double[] array25 = null;
				double[] A_31 = null;
				double[] A_32 = null;
				float[] array26 = new float[num2 + 1];
				string text = i3.o() + "\\MixGridDebug\\";
				double[] array27 = new double[num3 + 1];
				double[] array28 = new double[num3 + 1];
				try
				{
					if (Directory.Exists(text))
					{
						Directory.Delete(text, recursive: true);
					}
					Directory.CreateDirectory(text);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception a_4 = ex2;
					b10.a.c(fz.b.a, "Error attempting to delete and create empty folder for MixtureGridPtsDebugging", a_4);
					ProjectData.ClearProjectError();
				}
				bool flag5 = false;
				if (!flag2)
				{
					int A_21 = num2;
					for (num8 = 0; num8 <= A_21; num8++)
					{
						if (!A_3[num8] && A_2[num8] > 2)
						{
							flag5 = true;
							break;
						}
					}
				}
				bool flag6 = default(bool);
				if (flag && !flag5)
				{
					int A_13 = num;
					for (num8 = 0; num8 <= A_13; num8++)
					{
						if ((array[num8] || !array2[num8]) && array3[num8] == null)
						{
							flag6 = true;
							break;
						}
					}
				}
				else
				{
					flag6 = true;
				}
				A_11 = num2;
				bool flag7 = default(bool);
				for (num8 = 0; num8 <= A_11; num8++)
				{
					if (!jf.e(A_4[num8], 0f) && (!jf.e(A_4[num8], 1f) || array3[num8] == null))
					{
						flag7 = true;
						break;
					}
				}
				if (!flag7)
				{
					flag7 = jf.e(num6, 1f) && array3[num8] == null;
				}
				bool A_33 = flag6;
				if (!A_33 && flag7)
				{
					a(num, A_4, array3, num5, ref A_33, array18);
				}
				bool A_38 = default(bool);
				int num15 = default(int);
				int num16 = default(int);
				long a_5 = default(long);
				bool A_39 = default(bool);
				double A_43 = default(double);
				double A_44 = default(double);
				if (A_33)
				{
					float num11 = 1f;
					int num12 = 0;
					int num13 = num2;
					for (num8 = 0; num8 <= num13; num8++)
					{
						if (A_3[num8])
						{
							num11 -= A_4[num8];
						}
						else
						{
							num12++;
						}
					}
					if (!flag2)
					{
						num12++;
					}
					int num14 = num2;
					for (num8 = 0; num8 <= num14; num8++)
					{
						if (A_3[num8])
						{
							array26[num8] = A_4[num8];
						}
						else
						{
							array26[num8] = num11 / (float)num12;
						}
					}
					string A_34 = null;
					bool A_18 = false;
					bool A_17 = false;
					string[] A_25 = null;
					string[] A_35 = null;
					A_5 = null;
					bool A_16 = false;
					float[] A_36 = null;
					bool A_37 = false;
					a(null, A_1: false, A_2: true, array26, ref A_38, ref A_30, ref A_31, ref A_32, ref A_18, ref A_17, ref A_25, ref A_35, ref A_5, ref A_16, ref A_36, ref A_37, ref A_34);
					if (!A_38)
					{
						throw new ApplicationException("Failed to get valid data when attempting to get mixture data for evenly divided composition. " + A_34);
					}
					num15 = A_30.Length;
					num16 = num15 - 1;
					array5 = new double[num16 + 1];
					array24 = new double[2 * num15 - 1 + 1];
					array25 = new double[2 * num15 - 1 + 1];
					int num17 = num16;
					for (int num18 = 0; num18 <= num17; num18++)
					{
						array24[num18] = 1.0;
					}
					array10[11] = 10.0;
					array10[13] = 10.0;
					array9[7] = this.m_bt;
					if (this.m_bt != 2 || A_32 != null)
					{
						array9[8] = this.m_bt;
					}
					array11[1] = -1;
					array18 = new double[this.m_bp + 1];
					array19 = new short[this.m_bp + 1];
					a_5 = f6.UniqueMeasEngineID();
					array21 = new short[num16 + 1];
					short num19 = (short)num16;
					array22 = new double[num16 + 1];
					short A_12 = num19;
					for (short num20 = 0; num20 <= A_12; num20 = (short)unchecked(num20 + 1))
					{
						array21[num20] = num20;
					}
					int num21 = num16;
					for (int num22 = 0; num22 <= num21; num22++)
					{
						array22[num22] = A_30[num22] * 9.999999717180685E-10;
						array24[num15 + num22] = A_31[num22];
						if (A_32 != null)
						{
							array25[num15 + num22] = A_32[num22];
						}
					}
					a(num, array26, array3, num5, ref A_39, array18);
					double[] a_6;
					if (A_39)
					{
						array11[1] = 1;
						int num23 = num5;
						for (int num24 = 0; num24 <= num23; num24++)
						{
							array19[num24 + 1] = 1;
						}
						a_6 = (double[])array18.Clone();
					}
					else
					{
						a_6 = new double[num5 + 1];
					}
					short a_7 = (short)num15;
					ref double a_8 = ref array22[0];
					short a_9 = (short)num15;
					ref short a_10 = ref array21[0];
					double A_40 = 0.0;
					IntPtr zero = IntPtr.Zero;
					ref double a_11 = ref array5[0];
					ref double a_12 = ref array6[0];
					ref double a_13 = ref array7[0];
					ref double a_14 = ref array8[0];
					ref short a_15 = ref array9[0];
					ref double a_16 = ref array24[0];
					ref double a_17 = ref array25[0];
					ref double a_18 = ref array10[0];
					ref short a_19 = ref array11[0];
					ref double a_20 = ref array18[0];
					ref short a_21 = ref array19[0];
					ref short a_22 = ref array12[0];
					float A_41 = 0f;
					float A_42 = 1f;
					int num25 = f6.Solve20(1, -6000, 0.999f, 0.001f, 1, 1, a_7, ref a_8, a_9, ref a_10, ref A_40, zero, ref a_11, 2, ref a_12, ref a_13, ref a_14, ref a_15, ref a_16, ref a_17, ref a_18, ref a_19, ref a_20, ref a_21, ref a_22, ref A_41, ref A_42, 1, ref array13[0], IntPtr.Zero, ref array14[0], ref array15[0], ref array16[0], ref array17[0], a_5);
					if (num25 != 0)
					{
						throw new ApplicationException("Solver error while trying to update Mixture Model Coeffs on center comp data point. Error code is " + num25 + ".");
					}
					array23 = new double[num5 + 1];
					int num26 = num5;
					for (int num27 = 0; num27 <= num26; num27++)
					{
						array23[num27] = (float)array18[num27 + 1];
					}
					a(-1, A_30, num15, A_31, A_32, this.m_bp, text, a_6, array24, array25, array18, b10.a, ref A_43, ref A_44);
					if (b10.c.DialogResult == DialogResult.Cancel)
					{
						return;
					}
				}
				if (flag7)
				{
					string A_45 = null;
					a(ref A_38, ref A_30, ref A_31, ref A_32, ref A_45);
					if (!A_38)
					{
						throw new ApplicationException("Failed to get valid data when attempting to get mixture data for Grid Point Zero. " + A_45);
					}
					int num28 = num16;
					for (int num29 = 0; num29 <= num28; num29++)
					{
						array24[num15 + num29] = A_31[num29];
						if (A_32 != null)
						{
							array25[num15 + num29] = A_32[num29];
						}
						else
						{
							array25[num15 + num29] = 0.0;
						}
					}
					a(num, A_4, array3, num5, ref A_39, array18);
					array11[1] = 1;
					double[] a_6 = (double[])array18.Clone();
					short a_23 = (short)num15;
					ref double a_24 = ref array22[0];
					short a_25 = (short)num15;
					ref short a_26 = ref array21[0];
					double A_40 = 0.0;
					IntPtr zero2 = IntPtr.Zero;
					ref double a_27 = ref array5[0];
					ref double a_28 = ref array6[0];
					ref double a_29 = ref array7[0];
					ref double a_30 = ref array8[0];
					ref short a_31 = ref array9[0];
					ref double a_32 = ref array24[0];
					ref double a_33 = ref array25[0];
					ref double a_34 = ref array10[0];
					ref short a_35 = ref array11[0];
					ref double a_36 = ref array18[0];
					ref short a_37 = ref array19[0];
					ref short a_38 = ref array12[0];
					float A_42 = 0f;
					float A_41 = 1f;
					int num25 = f6.Solve20(1, -6000, 0.999f, 0.001f, 1, 1, a_23, ref a_24, a_25, ref a_26, ref A_40, zero2, ref a_27, 2, ref a_28, ref a_29, ref a_30, ref a_31, ref a_32, ref a_33, ref a_34, ref a_35, ref a_36, ref a_37, ref a_38, ref A_42, ref A_41, 1, ref array13[0], IntPtr.Zero, ref array14[0], ref array15[0], ref array16[0], ref array17[0], a_5);
					if (num25 != 0)
					{
						throw new ApplicationException("Solver error while trying to update Mixture Model Coeffs on fixed comp data point. Error code is " + num25 + ".");
					}
					int num30 = num5;
					for (int num31 = 0; num31 <= num30; num31++)
					{
						array20[num31] = (float)array18[num31 + 1];
					}
					a(0, A_30, num15, A_31, A_32, this.m_bp, text, a_6, array24, array25, array18, b10.a, ref array27[0], ref array28[0]);
				}
				else
				{
					int num32 = num2;
					bool flag8 = default(bool);
					for (num8 = 0; num8 <= num32; num8++)
					{
						if (jf.e(A_4[num8], 1f))
						{
							flag8 = true;
							break;
						}
					}
					if (!flag8)
					{
						num8 = num;
					}
					int num33 = num5;
					for (int num34 = 0; num34 <= num33; num34++)
					{
						array20[num34] = array3[num8][num34];
					}
				}
				int num35 = 1;
				int[] array29 = new int[num2 + 1];
				float[] A_46 = null;
				int num36 = num2 - 1;
				for (num8 = 0; num8 <= num36; num8++)
				{
					array29[num8] = 1;
				}
				do
				{
					if (b10.c.DialogResult == DialogResult.Cancel)
					{
						return;
					}
					b10.c.b(num35);
					jb.a(A_2, A_3, array29);
					bool flag9;
					if (flag)
					{
						flag9 = true;
						flag3 = false;
						int num37 = num2;
						for (num8 = 0; num8 <= num37; num8++)
						{
							if (A_3[num8])
							{
								flag3 = jf.e(A_4[num8], 1f);
								if (!jf.e(A_4[num8], 0f) && !flag3)
								{
									flag9 = false;
									break;
								}
								if (flag3)
								{
									break;
								}
							}
						}
						if (flag9 && !flag3)
						{
							int num38 = num2;
							for (num8 = 0; num8 <= num38; num8++)
							{
								if (!A_3[num8])
								{
									flag3 = array29[num8] == A_2[num8];
									if (array29[num8] != 1 && !flag3)
									{
										flag9 = false;
										break;
									}
									if (flag3)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						flag9 = false;
					}
					if (flag9 && !flag3)
					{
						num8 = num;
					}
					if (flag9 && array3[num8] != null)
					{
						int num39 = num5;
						for (int num40 = 0; num40 <= num39; num40++)
						{
							array20[num35 * this.m_bp + num40] = array3[num8][num40];
						}
					}
					else
					{
						string A_47 = null;
						bool A_37 = false;
						bool A_16 = false;
						string[] A_35 = null;
						string[] A_25 = null;
						A_5 = null;
						bool A_17 = false;
						bool A_18 = false;
						a(array29, A_1: false, A_2: true, null, ref A_38, ref A_30, ref A_31, ref A_32, ref A_37, ref A_16, ref A_35, ref A_25, ref A_5, ref A_17, ref A_46, ref A_18, ref A_47);
						if (!A_38)
						{
							throw new ApplicationException("Invalid data obtained while trying to update Mixture Model Coeffs at Grid Point #" + num35 + ". " + A_47);
						}
						int num41 = num16;
						for (int num42 = 0; num42 <= num41; num42++)
						{
							array24[num15 + num42] = A_31[num42];
							if (A_32 != null)
							{
								array25[num15 + num42] = A_32[num42];
							}
							else
							{
								array25[num15 + num42] = 0.0;
							}
						}
						a(num, A_46, array3, num5, ref A_39, array18);
						if (!A_39)
						{
							int num43 = num5;
							for (int num44 = 0; num44 <= num43; num44++)
							{
								array18[num44 + 1] = array23[num44];
							}
						}
						double[] a_6 = (double[])array18.Clone();
						short a_39 = (short)num15;
						ref double a_40 = ref array22[0];
						short a_41 = (short)num15;
						ref short a_42 = ref array21[0];
						double A_40 = 0.0;
						IntPtr zero3 = IntPtr.Zero;
						ref double a_43 = ref array5[0];
						ref double a_44 = ref array6[0];
						ref double a_45 = ref array7[0];
						ref double a_46 = ref array8[0];
						ref short a_47 = ref array9[0];
						ref double a_48 = ref array24[0];
						ref double a_49 = ref array25[0];
						ref double a_50 = ref array10[0];
						ref short a_51 = ref array11[0];
						ref double a_52 = ref array18[0];
						ref short a_53 = ref array19[0];
						ref short a_54 = ref array12[0];
						float A_41 = 0f;
						float A_42 = 1f;
						int num25 = f6.Solve20(1, -6000, 0.999f, 0.001f, 1, 1, a_39, ref a_40, a_41, ref a_42, ref A_40, zero3, ref a_43, 2, ref a_44, ref a_45, ref a_46, ref a_47, ref a_48, ref a_49, ref a_50, ref a_51, ref a_52, ref a_53, ref a_54, ref A_41, ref A_42, 1, ref array13[0], IntPtr.Zero, ref array14[0], ref array15[0], ref array16[0], ref array17[0], a_5);
						if (num25 != 0)
						{
							throw new ApplicationException("Solver error while trying to update Mixture Model Coeffs on fixed comp data point #" + num35 + ". Error code is " + num25);
						}
						int num45 = num5;
						for (int num46 = 0; num46 <= num45; num46++)
						{
							array20[num35 * this.m_bp + num46] = (float)array18[num46 + 1];
						}
						a(num35, A_30, num15, A_31, A_32, this.m_bp, text, a_6, array24, array25, array18, b10.a, ref array27[num35], ref array28[num35]);
					}
					num35++;
				}
				while (num35 <= num4);
				b10.c.b(num35);
				this.m_bu = array20;
				StreamWriter streamWriter = null;
				string text2 = text + "ErrorSum.csv";
				try
				{
					streamWriter = new StreamWriter(text2);
					streamWriter.WriteLine("Grid Pt, N (rms Error), K (rms Error)");
					streamWriter.WriteLine("Nominal, " + A_43 + ", " + A_44);
					int num47 = num4;
					for (int num48 = 0; num48 <= num47; num48++)
					{
						streamWriter.WriteLine(num48 + ", " + array27[num48] + ", " + array28[num48]);
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception a_55 = ex3;
					b10.a.c(fz.b.b, "Error in DialogEditLibrary.UpdateMixtureGridPtCoeffs attempting to write summary.", a_55);
					ProjectData.ClearProjectError();
				}
				finally
				{
					streamWriter?.Close();
				}
				if (c1.ui())
				{
					Process.Start(text2);
				}
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception a_56 = ex4;
				b10.a.c(fz.b.b, "Error in DialogEditLibrary.UpdateMixtureGridPtCoeffs.", a_56);
				ProjectData.ClearProjectError();
			}
			finally
			{
				Monitor.Enter(b10);
				try
				{
					b10.b = b10.c.DialogResult == DialogResult.Cancel;
					b10.c.i();
				}
				finally
				{
					Monitor.Exit(b10);
				}
			}
		}
	}

	private void a(int A_0, float[] A_1, float[][] A_2, int A_3, ref bool A_4, double[] A_5)
	{
		checked
		{
			int num = A_0 - 1;
			float[] array = new float[A_0 + 1];
			int[] array2 = new int[A_0 + 1];
			float num2 = 1f;
			int num3 = num;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				array[num4] = A_1[num4];
				array2[num4] = num4;
				num2 -= array[num4];
			}
			array[A_0] = num2;
			array2[A_0] = A_0;
			for (int num5 = A_0; num5 >= 1; num5 += -1)
			{
				int num6 = num5 - 1;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					if (array[num7] < array[num5])
					{
						float num8 = array[num7];
						array[num7] = array[num5];
						array[num5] = num8;
						int num9 = array2[num7];
						array2[num7] = array2[num5];
						array2[num5] = num9;
					}
				}
			}
			A_4 = false;
			for (int num10 = 0; num10 <= A_0; num10++)
			{
				if (A_2[array2[num10]] != null && A_1[array2[num10]] > 0.01f)
				{
					A_4 = true;
					for (int num11 = 0; num11 <= A_3; num11++)
					{
						A_5[num11 + 1] = A_2[array2[num10]][num11];
					}
					break;
				}
			}
		}
	}

	private void b(ref bool A_0)
	{
		if (ah().SelectedTab != ai())
		{
			return;
		}
		double[] A_1 = null;
		double[] A_2 = null;
		double[] A_3 = null;
		e(ref A_0);
		int A_4 = default(int);
		a(ref A_1, ref A_2, ref A_4, ref A_3);
		al().g1();
		al().ae(A_0: true);
		if (A_4 != 0)
		{
			bool A_5 = default(bool);
			if (b4)
			{
				a(e7.d.a, ref A_5);
			}
			else
			{
				A_5 = true;
			}
			if (A_5)
			{
				al().o(A_1, A_2, A_4, 0L, 0L, 0.0, "n - Refractive Index", "nk", A_8: false, A_9: false, A_10: false, Color.Blue);
			}
			if (A_3 != null && (!b7 || (b4 && A_5)))
			{
				al().o(A_1, A_3, A_4, 1L, 1L, 1.0, "k - Extinction Coefficient", "nk", A_8: false, A_9: false, A_10: false, Color.Navy);
			}
			al().q(0.2f, 0.5f);
			al().gi().a2().an(al().fa());
			al().gi().a2().am(al().fb());
			al().g6();
		}
	}

	private void a(ref bool A_0, ref double[] A_1, ref double[] A_2, ref double[] A_3, ref bool A_4, ref bool A_5, ref string[] A_6, ref string[] A_7, ref int[] A_8, ref bool A_9, ref bool A_10, ref string A_11)
	{
		float[] A_12 = null;
		a(null, A_1: false, A_2: false, null, ref A_0, ref A_1, ref A_2, ref A_3, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8, ref A_9, ref A_12, ref A_10, ref A_11);
	}

	private void a(ref bool A_0, ref double[] A_1, ref double[] A_2, ref double[] A_3, ref string A_4)
	{
		bool A_5 = false;
		bool A_6 = false;
		string[] A_7 = null;
		string[] A_8 = null;
		int[] A_9 = null;
		bool A_10 = false;
		float[] A_11 = null;
		bool A_12 = false;
		a(null, A_1: true, A_2: false, null, ref A_0, ref A_1, ref A_2, ref A_3, ref A_5, ref A_6, ref A_7, ref A_8, ref A_9, ref A_10, ref A_11, ref A_12, ref A_4);
	}

	private void a(int[] A_0, bool A_1, bool A_2, float[] A_3, ref bool A_4, ref double[] A_5, ref double[] A_6, ref double[] A_7, ref bool A_8, ref bool A_9, ref string[] A_10, ref string[] A_11, ref int[] A_12, ref bool A_13, ref float[] A_14, ref bool A_15, ref string A_16)
	{
		int[] A_17 = null;
		A_4 = false;
		A_13 = true;
		jc jc2 = new jc();
		jc jc3 = jc2;
		bool A_18 = default(bool);
		a(ref A_18, ref jc3.b, ref jc3.h, ref jc3.i, ref jc3.j, ref A_17);
		if (!A_18)
		{
			return;
		}
		if (!jb.a(jc3.j) && x().Checked && !A_2 && A_3 == null && !A_1)
		{
			c(ref A_15);
			if (A_15)
			{
				return;
			}
		}
		jc3.k = x().Checked;
		jc3.n = this.m_bu;
		jc3.l = this.m_bt;
		jc3.m = this.m_bp;
		jc3 = null;
		int[] a_ = A_17;
		eo a_2 = c5;
		hd a_3 = c3;
		double[] A_19 = null;
		short[] A_20 = null;
		short A_21 = 0;
		short A_22 = 0;
		jb.a(A_0, A_1, jc2, a_, A_2, A_3, a_2, a_3, null, ref A_4, ref A_8, ref A_9, ref A_13, ref A_5, ref A_6, ref A_7, ref A_19, ref A_20, ref A_21, ref A_22, ref A_14, ref A_16, c6);
	}

	private void a(ref bool A_0)
	{
		double[] A_1 = new double[2] { 435.8, 632.8 };
		checked
		{
			double[] A_2 = new double[A_1.GetUpperBound(0) + 1];
			double[] A_3 = null;
			double[] A_4 = null;
			double[] A_5 = null;
			int num;
			if (bi().Checked)
			{
				bool A_6 = false;
				bool A_7 = false;
				string[] A_8 = null;
				string[] A_9 = null;
				int[] A_10 = null;
				bool A_11 = false;
				string A_12 = null;
				bool A_13 = default(bool);
				a(ref A_13, ref A_3, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8, ref A_9, ref A_10, ref A_11, ref A_0, ref A_12);
				num = (A_13 ? A_3.Length : 0);
			}
			else
			{
				num = this.m_b1;
				A_3 = this.m_b2;
				A_4 = b3;
				A_5 = b6;
			}
			bool flag = A_5 != null;
			if (num > 0)
			{
				jf.a(ref A_3, ref A_4, num, ref A_1, ref A_2, A_1.GetUpperBound(0) + 1);
				ar().Text = A_2[0].ToString("0.0000");
				ap().Text = A_2[1].ToString("0.0000");
				if (flag)
				{
					jf.a(ref A_3, ref A_5, num, ref A_1, ref A_2, A_1.GetUpperBound(0) + 1);
					av().Text = A_2[0].ToString("0.0000");
					au().Text = A_2[1].ToString("0.0000");
					an().Text = "n";
				}
				else
				{
					an().Text = "Value";
				}
			}
			else
			{
				ar().Text = "";
				ap().Text = "";
				av().Text = "";
				au().Text = "";
			}
			av().Visible = flag;
			au().Visible = flag;
			aw().Visible = flag;
			@as().Text = Conversions.ToString((float)A_1[0]);
			aq().Text = Conversions.ToString((float)A_1[1]);
		}
	}

	private void aa(object A_0, EventArgs A_1)
	{
		try
		{
			if (b() && !a())
			{
				if (!ct)
				{
					a(c5.a8(), c5.a8() || (!b4 && !b7));
					return;
				}
				bool a_ = (bi().Checked && co) || (!bi().Checked && (b4 || b7));
				bool a_2 = cu;
				bool a_3 = cu;
				bool A_2 = false;
				a(a_, a_2, a_3, ref A_2);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_4 = ex2;
			i5.a(c0, c1, c2, i6.a(ah()), "DialogEditLibrary.ButtonSave_Click", a_4);
			ProjectData.ClearProjectError();
		}
	}

	private void z(object A_0, EventArgs A_1)
	{
		try
		{
			al().g1();
			o();
			short A_2 = 1;
			a(ref A_2);
			m();
			ah().SelectedTab = aj();
			r().Enabled = true;
			s().Enabled = true;
			v().Enabled = true;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(z()), "DialogEditLibrary.ButtonNew_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void y(object A_0, EventArgs A_1)
	{
		try
		{
			if (b())
			{
				a(c5.a8(), c5.a8() || (!b4 && !b7));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(z()), "DialogEditLibrary.ButtonSaveAs_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void x(object A_0, EventArgs A_1)
	{
		new fe(c0);
		fe.a a10 = new fe.a();
		try
		{
			if (this.m_b1 == 0)
			{
				return;
			}
			fe obj = new fe(c0);
			a10 = new fe.a();
			a10.w("Enter # of data points to delete for each data point kept:");
			a10.x("NumberOfSpectra");
			short result = default(short);
			a10.ad(Conversions.ToString((int)result));
			a10.w(MsgBoxStyle.OkCancel);
			a10.w(fe.b.a);
			a10.w(1.0);
			checked
			{
				a10.x(this.m_b1 - 1);
				a10.x(fe.b.c);
				a10.w(this);
				if (obj.b(a10) == DialogResult.OK && !short.TryParse(a10.ag(), out result))
				{
					result = Conversions.ToShort(a10.ag());
				}
				if (result > 0)
				{
					double[] A_2 = null;
					double[] A_3 = null;
					double[] A_4 = null;
					int A_5 = default(int);
					a(ref A_2, ref A_3, ref A_4, ref A_5);
					int num = A_5 - 1;
					int num2 = result + 1;
					bool flag = unchecked(num % num2) != 0;
					int num3 = 1 + (int)Math.Round(Math.Floor((double)num / (double)num2)) + Conversions.ToInteger(Interaction.IIf(flag, 1, 0));
					this.m_b2 = new double[num3 - 1 + 1];
					b3 = new double[num3 - 1 + 1];
					b6 = new double[num3 - 1 + 1];
					int num4 = 0;
					int num5 = num;
					int num6 = num2;
					for (int num7 = 0; ((num6 >> 31) ^ num7) <= ((num6 >> 31) ^ num5); num7 += num6)
					{
						this.m_b2[num4] = A_2[num7];
						b3[num4] = A_3[num7];
						b6[num4] = A_4[num7];
						num4++;
					}
					if (flag)
					{
						this.m_b2[num4] = A_2[num];
						b3[num4] = A_3[num];
						b6[num4] = A_4[num];
					}
					this.m_b1 = num3;
					c8 = true;
					l();
					k();
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(z()), "DialogEditLibrary.ButtonStripPoints_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void w(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (!cn.b(cb, ca) && !cm.b(cb, ca) && (b4 || b7))
				{
					bool A_2 = default(bool);
					a(e7.d.b, ref A_2);
					if (!A_2)
					{
						b0().Start();
						return;
					}
				}
				bool A_3 = false;
				c(ref A_3);
				if (bi().Checked && this.m_bu == null)
				{
					fe.b(c0, "Unable to display model details because coefficients do not exist", i6.a(z()));
					return;
				}
				if (bi().Checked)
				{
					int[] A_4 = null;
					int[] A_5 = null;
					bool[] A_6 = null;
					string[] A_7 = null;
					float[] A_8 = null;
					bool A_9 = default(bool);
					a(ref A_9, ref A_7, ref A_8, ref A_4, ref A_6, ref A_5);
					int num = jb.a(A_5, A_4, A_6);
					int num2 = this.m_bp - 1;
					double[] A_10 = new double[num2 + 1];
					short[] A_11 = new short[num2 + 1];
					int num3 = num * this.m_bp;
					int num4 = num2;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						A_10[num5] = this.m_bu[num3 + num5];
						A_11[num5] = 1;
					}
					fd obj = c4;
					ref short a_ = ref this.m_bt;
					ref int a_2 = ref this.m_bp;
					A_3 = true;
					obj.a(ref a_, ref a_2, ref A_10, ref A_11, ref A_3, A_5: true);
				}
				else
				{
					this.m_bo = false;
					if (this.m_bp > 0)
					{
						if (this.m_bt == 0)
						{
							this.m_bt = 2;
						}
						fd obj2 = c4;
						ref short a_3 = ref this.m_bt;
						ref int a_4 = ref this.m_bp;
						ref double[] a_5 = ref this.m_br;
						ref short[] a_6 = ref this.m_bs;
						A_3 = true;
						obj2.a(ref a_3, ref a_4, ref a_5, ref a_6, ref A_3);
					}
				}
				c4.a(this, c0, c1, this.m_b2, this.m_b1, b3, b6);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_7 = ex2;
				i5.a(c0, c1, c2, i6.a(z()), "DialogEditLibrary.ButtonModel_Click", a_7);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void v(object A_0, EventArgs A_1)
	{
		try
		{
			bq().Enabled = x().Checked;
			if (c7)
			{
				return;
			}
			if (x().Checked)
			{
				cp = true;
				this.m_bu = null;
				this.m_bp = 0;
			}
			if (x().Checked && this.m_bp == 0)
			{
				this.m_br[0] = 1.446;
				this.m_br[1] = 3.74E-15;
				this.m_br[2] = 7.297E-30;
				this.m_br[3] = 0.0;
				this.m_br[4] = 0.0;
				this.m_br[5] = 0.0;
				this.m_bs[0] = 1;
				this.m_bs[1] = 1;
				this.m_bs[2] = 1;
				this.m_bs[3] = 1;
				this.m_bs[4] = 1;
				this.m_bs[5] = 1;
				this.m_bt = 2;
				this.m_bp = checked((short)c3.j(this.m_bt));
				if (this.m_bt != 2)
				{
					ref fz a_ = ref c0;
					Point A_2 = i6.a(x());
					fe.b(ref a_, "Software bug: Invalid default coefficients", ref A_2);
				}
				fd obj = c4;
				ref short a_2 = ref this.m_bt;
				ref int a_3 = ref this.m_bp;
				ref double[] a_4 = ref this.m_br;
				ref short[] a_5 = ref this.m_bs;
				bool A_3 = false;
				obj.a(ref a_2, ref a_3, ref a_4, ref a_5, ref A_3);
				iz.b(bq(), this.m_bt);
			}
			else if (!x().Checked)
			{
				this.m_bp = 0;
			}
			n();
			if (this.m_bn == 2)
			{
				short A_4 = 0;
				a(ref A_4);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_6 = ex2;
			i5.a(c0, c1, c2, i6.a(x()), "DialogEditLibrary.RadioCustom_CheckedChanged", a_6);
			ProjectData.ClearProjectError();
		}
	}

	private void u(object A_0, EventArgs A_1)
	{
		try
		{
			if (c7)
			{
				return;
			}
			TabPage a_ = null;
			if (this.m_bn == 2)
			{
				short A_2 = 0;
				a(ref A_2);
			}
			this.m_b1 = 0;
			c8 = true;
			b9 = false;
			b4 = false;
			b7 = false;
			co = false;
			ct = false;
			y().Checked = true;
			c("Untitled");
			if (bi().Checked)
			{
				this.m_bu = null;
				a(new string[2], new float[2] { 0.5f, 0.5f }, new int[2] { 2, 2 }, new bool[2]);
				k();
				a_ = bc();
				iz.b(bq(), 2);
			}
			else
			{
				bool A_3 = false;
				d(ref A_3);
				if (ah().SelectedTab == aj())
				{
					A_3 = false;
					f(ref A_3);
				}
			}
			a(A_0: true, a_);
			n();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			i5.a(c0, c1, c2, i6.a(bi()), "DialogEditLibrary.CheckBoxMixture_CheckedChanged", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void t(object A_0, EventArgs A_1)
	{
		try
		{
			n();
			if (!c7)
			{
				if (y().Checked)
				{
					cp = true;
				}
				if (this.m_bn == 2)
				{
					short A_2 = 0;
					a(ref A_2);
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(z()), "DialogEditLibrary.RadioDefault_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void s(object A_0, EventArgs A_1)
	{
		try
		{
			if (this.m_bn == 1)
			{
				short A_2 = 2;
				a(ref A_2);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(aa()), "DialogEditLibrary.ButtonAttrDeleteAll_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void r(object A_0, EventArgs A_1)
	{
		if (this.m_bo)
		{
			short A_2 = 0;
			a(ref A_2);
		}
		else
		{
			this.m_bo = true;
		}
	}

	private void q(object A_0, EventArgs A_1)
	{
		_ = this.m_bo;
	}

	private void g(object A_0, DataGridViewCellEventArgs A_1)
	{
		if (!c7)
		{
			int rowIndex = A_1.RowIndex;
			int columnIndex = A_1.ColumnIndex;
			_ = null;
			if (rowIndex >= 0 && columnIndex >= 0)
			{
				DataGridViewCell dataGridViewCell = ak().Rows[rowIndex].Cells[columnIndex];
				string text = ((dataGridViewCell.Value != null) ? dataGridViewCell.Value.ToString() : string.Empty);
				dataGridViewCell = null;
				this.m_bq[rowIndex, columnIndex] = text;
			}
			c8 = false;
		}
	}

	protected override bool ProcessDialogKey(Keys keydata)
	{
		if (ah().SelectedTab == aj())
		{
			if ((keydata >= Keys.D0 && keydata <= Keys.D9) || (keydata >= Keys.NumPad0 && keydata <= Keys.NumPad9) || keydata == Keys.Decimal || keydata == Keys.OemPeriod || keydata == Keys.Oemcomma || keydata == Keys.E || keydata == Keys.OemMinus || keydata == Keys.Subtract)
			{
				return base.ProcessDialogKey(keydata);
			}
			if (keydata > (Keys.LineFeed | Keys.ShiftKey))
			{
				return true;
			}
			return false;
		}
		bool result = default(bool);
		return result;
	}

	private void a(d A_0, ref bool A_1)
	{
		Collection<a> collection = new Collection<a>();
		dh = e7.c.c;
		checked
		{
			if ((bi().Checked || b9) && A_0 == e7.d.a)
			{
				string[] A_2 = null;
				string A_3 = null;
				if (bi().Checked)
				{
					bool[] A_4 = null;
					float[] A_5 = null;
					int[] A_6 = null;
					int[] A_7 = null;
					bool A_8 = default(bool);
					a(ref A_8, ref A_2, ref A_5, ref A_6, ref A_4, ref A_7);
					if (!A_8)
					{
						A_1 = false;
						return;
					}
					bool[] array = A_4;
					for (int num = 0; num < array.Length && array[num]; num++)
					{
					}
					string A_9 = null;
					string[] array2 = A_2;
					bool A_27 = default(bool);
					bool A_28 = default(bool);
					bool A_29 = default(bool);
					int A_30 = default(int);
					foreach (string a_ in array2)
					{
						double[] A_10 = null;
						double[] A_11 = null;
						double[] A_12 = null;
						int A_13 = 0;
						hd a_2 = c3;
						short A_14 = 0;
						short A_15 = 0;
						int A_16 = 0;
						short[] A_17 = null;
						double[] A_18 = null;
						eo a_3 = c5;
						string A_19 = null;
						string A_20 = null;
						string A_21 = null;
						int A_22 = 0;
						jb.d[] A_23 = null;
						string[] A_24 = null;
						bool A_25 = false;
						jc A_26 = null;
						if (jb.a(a_, A_1: false, ref A_10, ref A_11, ref A_12, A_5: true, A_6: true, ref A_13, a_2, ref A_14, ref A_15, ref A_16, ref A_17, ref A_18, a_3, ref A_19, ref A_27, ref A_28, ref A_29, ref A_20, ref A_21, ref A_30, ref A_3, ref A_22, ref A_23, ref A_24, ref A_25, ref A_9, ref A_26, c6) != jb.a.a)
						{
							A_1 = false;
							return;
						}
						if ((A_27 || A_28) && !cm.b(A_3, A_30))
						{
							collection.Add(new a(A_3, Path.GetFileName(A_9), A_30));
						}
					}
				}
				else
				{
					if (!cf)
					{
						A_1 = false;
						return;
					}
					if (cc == null)
					{
						A_1 = true;
						return;
					}
					int A_22 = cc.Length - 1;
					for (int num3 = 0; num3 <= A_22; num3++)
					{
						A_3 = cc[num3];
						int A_30 = ce[num3];
						if (!cm.b(A_3, A_30))
						{
							collection.Add(new a(A_3, cd[num3], A_30));
						}
					}
				}
			}
			else
			{
				bool flag = cm.b(cb, ca);
				if (A_0 == e7.d.b && !flag)
				{
					if (!cn.b(cb, ca))
					{
						collection.Add(new a(cb, this.m_bv, ca));
					}
				}
				else
				{
					bool flag2 = c5.a8() || c5.a3() || db || A_0 == e7.d.b;
					if (!flag && (!flag2 || !cn.b(cb, ca)))
					{
						collection.Add(new a(cb, this.m_bv, ca));
					}
				}
			}
			if (collection.Count == 0)
			{
				A_1 = true;
				return;
			}
			foreach (a item in collection)
			{
				a a10 = item;
				if (c5.a8() || c5.a3())
				{
					string text = c5.bb();
					if (!string.IsNullOrEmpty(text))
					{
						new dp().a(text, a10.a, a10.c, a10.b, i6.a(ah()), "Obtaining permission to view " + a10.b + "...", c0, ref A_1);
						if (!A_1)
						{
							break;
						}
						cm.a(a10.a, a10.c);
					}
				}
				else if (db || A_0 == e7.d.b)
				{
					dg obj = new dg();
					eo eo2 = c5;
					obj.a(eo2.ba(), eo2.bd(), eo2.be(), eo2.bf(), item.a, item.c, item.b, i6.a(ah()), "Requesting View permission", ref A_1);
					eo2 = null;
					if (!A_1)
					{
						break;
					}
					if (A_0 == e7.d.b)
					{
						cn.a(a10.a, a10.c);
					}
					else
					{
						cm.a(a10.a, a10.c);
					}
				}
				else if (dc)
				{
					dh = e7.c.a;
				}
				else
				{
					dh = e7.c.b;
				}
				a10 = null;
			}
		}
	}

	private void p(object A_0, EventArgs A_1)
	{
		try
		{
			if (ds)
			{
				return;
			}
			TabPage selectedTab = ah().SelectedTab;
			if (c9 == aj() && selectedTab != aj() && !bi().Checked)
			{
				b(ref this.m_b2, ref b3, ref b6, ref this.m_b1);
			}
			bool A_2 = default(bool);
			bool A_4 = default(bool);
			if (selectedTab == bc())
			{
				if (co)
				{
					a(e7.d.b, ref A_2);
				}
				else
				{
					A_2 = true;
				}
			}
			else if (selectedTab == aj() || selectedTab == ai())
			{
				bool flag = default(bool);
				if (bi().Checked)
				{
					if (co)
					{
						bool A_3 = default(bool);
						a(e7.d.b, ref A_3);
						if (!A_3)
						{
							flag = true;
						}
					}
					if (!flag)
					{
						e(ref A_4);
					}
				}
				if (flag)
				{
					A_2 = false;
				}
				else if (b4 || b7)
				{
					a(e7.d.a, ref A_2);
				}
				else
				{
					A_2 = true;
				}
			}
			else
			{
				A_2 = true;
			}
			if (!A_2 || A_4)
			{
				if (A_4)
				{
					dh = e7.c.d;
					ds = true;
					ah().SelectedTab = c9;
				}
				else
				{
					ah().SelectedTab = am();
				}
				Refresh();
				b0().Start();
				return;
			}
			if (selectedTab == ai())
			{
				b(ref A_4);
			}
			else if (selectedTab == am())
			{
				a(ref A_4);
			}
			else if (selectedTab == aj())
			{
				f(ref A_4);
			}
			if (A_4)
			{
				ds = true;
				ah().SelectedTab = c9;
				Refresh();
				dh = e7.c.d;
				b0().Start();
			}
			else
			{
				c9 = selectedTab;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(ah()), "DialogEditLibrary.TabIndexData_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
		finally
		{
			ds = false;
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		try
		{
			if (c7)
			{
				return;
			}
			string path = Path.ChangeExtension(jb.d() + "\\" + this.m_bv, ".fivrq");
			bool flag = File.Exists(path);
			if (a4().Checked)
			{
				if (!flag)
				{
					File.WriteAllText(path, "");
				}
			}
			else if (flag)
			{
				File.Delete(path);
			}
			a(a4().Checked, ax());
			ah().SelectedTab = ax();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(ah()), "DialogEditLibrary.CheckBoxRequestEndUserView_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void n(object A_0, EventArgs A_1)
	{
		try
		{
			df obj = new df();
			Point point = i6.a(a5());
			if (b9 && !bi().Checked)
			{
				throw new ApplicationException("Unable to make viewable because data is not associated with file");
			}
			bool A_2 = default(bool);
			obj.a(cb, ca, this.m_bv, point, ref A_2);
			if (A_2)
			{
				fe.b(c0, "The file has been added to database of End-User Viewable files as " + cb + ".", "Information", point);
			}
			else
			{
				fe.b(c0, "Operation failed. Material file was not added to the database of End-User Viewable files.", point);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(ah()), "DialogEditLibrary.ButtonAddToViewableDB_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, LinkLabelLinkClickedEventArgs A_1)
	{
		try
		{
			Process.Start("https://www.ficorpserv.com/MemberPages/MatFileEndUsersManage.aspx?UserName=" + c5.a9());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(ah()), "DialogEditLibrary.LinkManagePermissions_LinkClicked", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, ElapsedEventArgs A_1)
	{
		try
		{
			if (base.InvokeRequired)
			{
				e method = b;
				Invoke(method, A_0, A_1);
			}
			else
			{
				if (dh == e7.c.d)
				{
					return;
				}
				if (c5.a8() || c5.a3())
				{
					fz a_ = c0;
					string A_2 = "MatFileProtectInfoViewDeniedInternal";
					fe.b(a_, hu.a(ref A_2), i6.a(this));
					return;
				}
				switch (dh)
				{
				case e7.c.c:
				{
					fz a_4 = c0;
					string A_2 = "MatFileProtectInfoViewDenied";
					fe.b(a_4, hu.a(ref A_2), i6.a(this));
					break;
				}
				case e7.c.a:
				{
					fz a_3 = c0;
					string A_2 = "MatFileProtectNoSpectrumError";
					fe.b(a_3, hu.a(ref A_2), i6.a(ah()));
					break;
				}
				case e7.c.b:
				{
					fz a_2 = c0;
					string A_2 = "MatFileProtectBadSpectrumErrorFmt";
					fe.b(a_2, string.Format(hu.a(ref A_2), ew.b(df)), i6.a(ah()));
					break;
				}
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_5 = ex2;
			c0.c(fz.b.b, "Error in DialogEditLibrary.mViewDeniedTriggerTimer_Elapsed", a_5);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, ElapsedEventArgs A_1)
	{
		try
		{
			if (base.InvokeRequired)
			{
				f method = a;
				Invoke(method, A_0, A_1);
			}
			else
			{
				fz a_ = c0;
				string A_2 = "MatFileProtectDecryptionDenied";
				fe.b(a_, hu.a(ref A_2), i6.a(this));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			c0.c(fz.b.b, "Error in DialogEditLibrary.mDecryptionDeniedTriggerTimer_Elapsed", a_2);
			ProjectData.ClearProjectError();
		}
	}

	private void m(object A_0, EventArgs A_1)
	{
		try
		{
			if (fe.b(ref c0, "Are you sure you want to Delete all Attributes?", "Warning", "Yes", "No", i6.a(a9())))
			{
				DataGridViewRowCollection rows = a7().Rows;
				while (rows.Count > 1)
				{
					rows.RemoveAt(checked(rows.Count - 2));
				}
				rows = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(a9()), "DialogEditLibrary.ButtonAttrDeleteAll_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				ck obj = new ck();
				string[] A_2 = null;
				jb.f f10 = jb.ai(bw().SelectedItem.ToString());
				jb.d A_3 = default(jb.d);
				obj.a(dj, f10 == jb.f.a, ref A_2, ref A_3);
				if (obj.DialogResult != DialogResult.OK)
				{
					return;
				}
				dj = A_3;
				if (A_2 == null)
				{
					return;
				}
				jb.d[] A_4 = null;
				string[] A_5 = null;
				List<string> A_6 = null;
				List<string> A_7 = null;
				List<string> A_8 = null;
				List<string> list = null;
				int A_9 = default(int);
				a(ref A_9, ref A_4, ref A_5, ref cj);
				if (f10 == jb.f.a)
				{
					a(A_9, A_4, A_5, f10, ref A_6, ref A_7, ref A_8);
					switch (A_3)
					{
					case jb.d.a:
						list = A_6;
						break;
					case jb.d.b:
						list = A_7;
						break;
					case jb.d.c:
						list = A_8;
						break;
					}
					string[] array = A_2;
					foreach (string item in array)
					{
						list.Add(item);
					}
					list.Sort();
					a(A_6, A_7, A_8, ref A_9, ref A_4, ref A_5);
				}
				else if ((A_3 == jb.d.b) & (A_2.Length > 0))
				{
					int num2 = A_9;
					A_9 += A_2.Length;
					A_4 = (jb.d[])Utils.CopyArray(A_4, new jb.d[A_9 - 1 + 1]);
					A_5 = (string[])Utils.CopyArray(A_5, new string[A_9 - 1 + 1]);
					string[] array2 = A_2;
					foreach (string a_ in array2)
					{
						A_4[num2] = jb.d.k;
						A_5[num2] = jb.a(f10, jb.e.a, a_);
						num2++;
					}
				}
				List<string> A_10 = null;
				List<jb.d> A_11 = null;
				a(A_9, A_5, A_4, jb.ai(bw().SelectedItem.ToString()), ref A_10, ref A_11, ref cg, ref ch, ref ci);
				a(A_10, A_11, cj);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				i5.a(c0, c1, c2, i6.a(a9()), "DialogEditLibrary.ButtonAttrAdd_Click", a_2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private bool a(List<string> A_0, List<string> A_1)
	{
		if (A_0 == null || A_1 == null)
		{
			return A_0 == null && A_1 == null;
		}
		if (A_0.Count != A_1.Count)
		{
			return false;
		}
		checked
		{
			int num = A_0.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (Operators.CompareString(A_0[num2], A_1[num2], TextCompare: false) != 0)
				{
					return false;
				}
			}
			return true;
		}
	}

	private void a(string A_0, ref List<string> A_1)
	{
		A_1 = new List<string>();
		if (string.IsNullOrEmpty(A_0))
		{
			return;
		}
		string[] array = A_0.Split(";".ToCharArray());
		for (int num = 0; num < array.Length; num = checked(num + 1))
		{
			string text = array[num].Trim();
			if (!string.IsNullOrEmpty(text))
			{
				A_1.Add(text);
			}
		}
		A_1.Sort();
	}

	private void a(int A_0, string[] A_1, jb.d[] A_2, jb.f A_3, ref List<string> A_4, ref List<jb.d> A_5, ref List<string> A_6, ref List<jb.d> A_7, ref jb.f A_8)
	{
		A_4 = new List<string>();
		A_5 = new List<jb.d>();
		A_6 = new List<string>();
		A_7 = new List<jb.d>();
		A_8 = A_3;
		if (A_2 == null)
		{
			return;
		}
		checked
		{
			int num = A_0 - 1;
			jb.f f10 = default(jb.f);
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (A_8 != jb.f.a && A_2[num2] == jb.d.k)
				{
					f10 = jb.ah(A_1[num2]);
				}
				if ((A_2[num2] != jb.d.k && A_8 == jb.f.a) || (A_2[num2] == jb.d.k && f10 == A_8 && A_8 != jb.f.a))
				{
					A_4.Add(A_1[num2]);
					A_5.Add(A_2[num2]);
				}
				else
				{
					A_6.Add(A_1[num2]);
					A_7.Add(A_2[num2]);
				}
			}
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (!h())
				{
					return;
				}
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.InitialDirectory = jb.d();
				openFileDialog.Filter = "Material Summary File *.txt|*.txt";
				openFileDialog.Title = "Select Material Summary File";
				if (openFileDialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				string A_2 = "";
				string A_3 = null;
				string text = null;
				string A_4 = null;
				jb.d[] A_5 = null;
				string[] A_6 = null;
				List<string> A_7 = null;
				List<string> A_8 = null;
				List<string> A_9 = null;
				string A_10 = null;
				string A_11 = null;
				string A_12 = null;
				string A_13 = null;
				string A_14 = null;
				string A_15 = null;
				List<string> A_16 = null;
				List<string> A_17 = null;
				List<string> A_18 = null;
				string A_19 = null;
				List<string> A_20 = null;
				int num = 0;
				string text2 = "";
				string text3 = "";
				string text4 = "";
				string text5 = "";
				Collection<eb.c> A_21 = null;
				string text6 = "";
				string A_22 = null;
				string A_23 = null;
				string A_24 = null;
				string A_25 = null;
				string A_26 = null;
				string A_27 = null;
				List<string> A_28 = null;
				List<string> A_29 = null;
				List<string> A_30 = null;
				string A_31 = null;
				string A_32 = null;
				string A_33 = null;
				string A_34 = null;
				string A_35 = null;
				string A_36 = null;
				string A_37 = null;
				string A_38 = null;
				string A_39 = null;
				string A_40 = null;
				string A_41 = null;
				if (jb.i())
				{
					DateTime A_42 = DateTime.MinValue;
					DateTime A_43 = DateTime.MinValue;
					LicenseLevel A_44 = LicenseLevel.Unlicensed;
					d9.a(eb.b.a, ref A_42, ref A_43, ref A_44, ref A_21);
				}
				bb().Cursor = Cursors.WaitCursor;
				string text7;
				try
				{
					text7 = File.ReadAllText(openFileDialog.FileName, Encoding.UTF8) + "\r\n";
				}
				catch (IOException ex2)
				{
					ProjectData.SetProjectError(ex2);
					IOException ex3 = ex2;
					fe.b(c0, "Unable to open input file. Error is: \r\r" + ex3.Message, i6.a(ba()));
					ProjectData.ClearProjectError();
					return;
				}
				int A_45 = 0;
				i3.a(ref A_45, text7, "\t", ref A_40);
				i3.a(ref A_45, text7);
				jb.f f10;
				bool flag = default(bool);
				if (!string.IsNullOrEmpty(A_40.Trim()))
				{
					f10 = jb.ai(A_40.Trim());
					flag = true;
				}
				else
				{
					f10 = jb.f.a;
					i3.a(ref A_45, text7);
					i3.a(ref A_45, text7);
					i3.a(ref A_45, text7);
					i3.a(ref A_45, text7);
				}
				i3.a(ref A_45, text7);
				i3.a(ref A_45, text7);
				short A_60 = default(short);
				short A_61 = default(short);
				int A_62 = default(int);
				int A_63 = default(int);
				bool A_64 = default(bool);
				bool A_66 = default(bool);
				bool flag3 = default(bool);
				bool flag5 = default(bool);
				bool flag6 = default(bool);
				bool flag9 = default(bool);
				eb.a a10 = default(eb.a);
				bool A_75 = default(bool);
				while (A_45 < text7.Length)
				{
					i3.a(ref A_45, text7, ref A_2, A_3: true, "\t");
					if (string.IsNullOrEmpty(A_2.Trim()))
					{
						break;
					}
					string text8 = jb.a(new string[1] { A_2 });
					bool flag2 = !string.IsNullOrEmpty(text8);
					double[] A_46 = null;
					double[] A_47 = null;
					double[] A_48 = null;
					int A_49 = 0;
					short[] A_50 = null;
					double[] A_51 = null;
					string A_58;
					if (flag2)
					{
						string a_ = text8;
						hd a_2 = c3;
						eo a_3 = c5;
						string A_52 = null;
						bool A_53 = false;
						bool A_54 = false;
						bool A_55 = false;
						int A_56 = 0;
						string A_57 = null;
						A_58 = null;
						jc A_59 = null;
						if (jb.a(a_, A_1: false, ref A_46, ref A_47, ref A_48, A_5: true, A_6: true, ref A_49, a_2, ref A_60, ref A_61, ref A_62, ref A_50, ref A_51, a_3, ref A_52, ref A_53, ref A_54, ref A_55, ref A_3, ref A_4, ref A_56, ref A_57, ref A_63, ref A_5, ref A_6, ref A_64, ref A_58, ref A_59, c6) != jb.a.a)
						{
							ref fz a_4 = ref c0;
							string a_5 = "Error attempting to read material file '" + A_2 + ".";
							Point A_65 = i6.a(bb());
							fe.b(ref a_4, a_5, ref A_65);
							continue;
						}
					}
					a(A_63, A_5, A_6, f10, ref A_7, ref A_8, ref A_9);
					a(A_63, A_5, A_6, f10, ref A_22, ref A_23, ref A_24, ref A_25, ref A_26, ref A_27, ref A_28, ref A_29, ref A_30);
					List<string> list = new List<string>();
					List<string> list2 = new List<string>();
					A_58 = null;
					i3.a(ref A_45, text7, ref A_58, A_3: true, "\t");
					i3.a(ref A_45, text7, ref A_41, A_3: true, "\t");
					DateTime dateTime = DateTime.Parse(A_41, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal).ToUniversalTime();
					if (!flag)
					{
						A_58 = null;
						i3.a(ref A_45, text7, ref A_58, A_3: true, "\t");
						A_58 = null;
						i3.a(ref A_45, text7, ref A_58, A_3: true, "\t");
					}
					i3.a(ref A_45, text7, ref A_10, A_3: true, "\t");
					A_10 = A_10.Trim();
					i3.a(ref A_45, text7, ref A_11, A_3: true, "\t");
					A_11 = A_11.Trim();
					if (!flag)
					{
						i3.a(ref A_45, text7, ref A_12, A_3: true, "\t");
						A_12 = A_12.Trim();
						i3.a(ref A_45, text7, ref A_13, A_3: true, "\t");
						a(A_13, ref A_16);
					}
					i3.a(ref A_45, text7, ref A_14, A_3: true, "\t");
					a(A_14, ref A_17);
					if (!flag)
					{
						i3.a(ref A_45, text7, ref A_15, A_3: true, "\t");
						a(A_15, ref A_18);
						A_58 = null;
						i3.a(ref A_45, text7, ref A_58, A_3: true, "\t");
						A_58 = null;
						i3.a(ref A_45, text7, ref A_58, A_3: true, "\t");
					}
					i3.a(ref A_45, text7, ref A_31, A_3: true, "\t");
					int num3;
					if (!flag)
					{
						i3.a(ref A_45, text7, ref A_32, A_3: true, "\t");
						i3.a(ref A_45, text7, ref A_33, A_3: true, "\t", ref A_66);
						if (!A_66)
						{
							i3.a(ref A_45, text7, ref A_34, A_3: true, "\t", ref A_66);
							if (!string.IsNullOrEmpty(A_34))
							{
								int num2 = (short)Math.Round(iz.e(A_34));
								A_34 = ((num2 >= 0 && num2 <= 4) ? num2.ToString() : 0.ToString());
							}
						}
						else
						{
							A_34 = string.Empty;
						}
						if (!A_66)
						{
							i3.a(ref A_45, text7, ref A_35, A_3: true, "\t", ref A_66);
						}
						else
						{
							A_35 = string.Empty;
						}
						if (!A_66)
						{
							i3.a(ref A_45, text7, ref A_36, A_3: true, "\t", ref A_66);
						}
						else
						{
							A_36 = string.Empty;
						}
						if (!A_66)
						{
							i3.a(ref A_45, text7, ref A_37, A_3: true, "\t", ref A_66);
						}
						else
						{
							A_37 = string.Empty;
						}
						if (!A_66)
						{
							i3.a(ref A_45, text7, ref A_38, A_3: true, "\t", ref A_66);
						}
						else
						{
							A_38 = string.Empty;
						}
						if (!A_66)
						{
							i3.a(ref A_45, text7, ref A_19, A_3: true, "\t");
							a(A_19, ref A_20);
						}
						else
						{
							A_20 = new List<string>();
						}
						if (!A_66)
						{
							i3.a(ref A_45, text7, ref A_39, A_3: true, "\t", ref A_66);
							num3 = Conversions.ToInteger(A_39);
						}
						else
						{
							num3 = 0;
						}
					}
					else
					{
						num3 = 0;
						A_66 = false;
					}
					int num4;
					if (!A_66)
					{
						i3.a(ref A_45, text7, ref A_39, A_3: true, "\t", ref A_66);
						num4 = Conversions.ToInteger(A_39);
					}
					else
					{
						num4 = 0;
					}
					if (!A_66)
					{
						int A_56 = num3;
						for (int num5 = 1; num5 <= A_56; num5++)
						{
							i3.a(ref A_45, text7, ref A_39, A_3: true, "\t", ref A_66);
							list2.Add(jg.c(A_39).Replace("\"\"", "\""));
						}
						int num6 = num4;
						for (int num7 = 1; num7 <= num6; num7++)
						{
							i3.a(ref A_45, text7, ref A_39, A_3: true, "\t", ref A_66);
							list.Add(jg.c(A_39).Replace("\"\"", "\""));
						}
						if (!A_66)
						{
							i3.a(ref A_45, text7);
						}
					}
					bool flag4;
					if (flag2 && jb.n(text8))
					{
						DateTime lastWriteTimeUtc = File.GetLastWriteTimeUtc(text8);
						flag3 = Math.Abs(dateTime.Subtract(lastWriteTimeUtc).TotalSeconds) > 1.0;
						A_10 = jg.c(A_10).Replace("\"\"", "\"");
						A_11 = jg.c(A_11).Replace("\"\"", "\"");
						if (!flag || f10 == jb.f.a)
						{
							flag4 = Operators.CompareString(A_10.Trim(), A_3.Trim(), TextCompare: false) != 0;
							int num8 = 0;
							text = string.Empty;
							for (; num8 < A_63; num8++)
							{
								if (A_5[num8] == jb.d.m)
								{
									text = A_6[num8];
									break;
								}
							}
							if (!flag4)
							{
								flag4 = Operators.CompareString(A_11, text, TextCompare: false) != 0;
							}
						}
						else
						{
							int num9 = 0;
							flag4 = false;
							for (; num9 < A_63; num9++)
							{
								if (flag5 && flag6)
								{
									break;
								}
								if (flag4)
								{
									break;
								}
								if (A_5[num9] == jb.d.k && jb.ah(A_6[num9]) == f10)
								{
									switch (jb.ag(A_6[num9]))
									{
									case jb.e.d:
										flag4 = Operators.CompareString(A_10, jb.af(A_6[num9]), TextCompare: false) != 0;
										flag5 = true;
										break;
									case jb.e.e:
										flag4 = Operators.CompareString(A_11, jb.af(A_6[num9]), TextCompare: false) != 0;
										flag6 = true;
										break;
									}
								}
							}
						}
						if (!flag4 && jb.q(text8))
						{
							if (!flag)
							{
								A_12 = jg.c(A_12).Replace("\"\"", "\"");
								flag4 = Operators.CompareString(A_12, A_4, TextCompare: false) != 0;
								if (!flag4)
								{
									flag4 = !a(A_16, A_7);
								}
								if (!flag4)
								{
									flag4 = !a(A_18, A_9);
								}
								if (!flag4)
								{
									flag4 = !a(A_20, A_30);
								}
								if (!flag4)
								{
									flag4 = !a(list2, A_29);
								}
								if (!flag4)
								{
									A_34 = A_34.Replace("\"\"", "\"");
									flag4 = Operators.CompareString(A_34, A_23, TextCompare: false) != 0;
								}
								if (!flag4)
								{
									flag4 = !jf.e(iz.e(A_35), iz.e(A_24));
								}
								if (!flag4)
								{
									flag4 = !jf.e(iz.e(A_36), iz.e(A_25));
								}
								if (!flag4)
								{
									flag4 = !jf.e(iz.e(A_37), iz.e(A_26));
								}
								if (!flag4)
								{
									flag4 = !jf.e(iz.e(A_38), iz.e(A_27));
								}
							}
							if (!flag4)
							{
								flag4 = !a(A_17, A_8);
							}
							if (!flag4)
							{
								flag4 = !a(list, A_28);
							}
							if (!flag4)
							{
								A_31 = jg.c(A_31).Replace("\"\"", "\"");
								flag4 = Operators.CompareString(A_31, A_22, TextCompare: false) != 0;
							}
						}
					}
					else
					{
						flag4 = false;
					}
					if (!flag4)
					{
						continue;
					}
					bool flag7 = string.Compare(jb.h(), Path.GetDirectoryName(text8), ignoreCase: true) == 0;
					bool flag8;
					if (flag3)
					{
						text4 = A_2 + " was not updated because the target file has changed since the update file was created.";
						flag8 = false;
					}
					else if (flag7)
					{
						text4 = A_2;
						if (flag9)
						{
							flag8 = false;
							text4 += " was not updated because user cancelled Database update attempts";
						}
						else
						{
							a10 = d9.a(A_21, Path.GetFileNameWithoutExtension(A_2));
							if (a10 != eb.a.a)
							{
								if (this.m_by)
								{
									if (this.m_bz >= LicenseLevel.ReadWrite)
									{
										if (a10 < eb.a.f || this.m_bz >= LicenseLevel.ShippingReadWrite)
										{
											if (Operators.CompareString(A_34, A_23, TextCompare: false) != 0 && !a(A_21, A_2))
											{
												flag8 = false;
												text4 = text4 + " was not updated because file release level (" + eb.a(a10) + ") does not permit override.";
											}
											else
											{
												flag8 = true;
											}
										}
										else
										{
											flag8 = false;
											text4 += " was not updated because its Release Level is Shipping and user's license level does not permit modification of Shipping files.";
										}
									}
									else
									{
										flag8 = false;
										text4 += " was not updated because user's license level restricts Material File Database access to Read Only.";
									}
								}
								else
								{
									flag8 = false;
									text4 += " was not updated because no live connection to the Material File Database service was established.";
								}
							}
							else
							{
								flag8 = false;
								text4 += " was not updated because it is not properly listed in the latest release level summary file.";
							}
						}
					}
					else if (Operators.CompareString(A_34, A_23, TextCompare: false) != 0 && !a(A_21, A_2))
					{
						flag8 = false;
						text4 = A_2 + " was not updated because file release level is local and access level of local files may not be overridden.";
					}
					else
					{
						flag8 = true;
					}
					if (flag8 && jb.m(A_2))
					{
						text4 = A_2 + " was not updated because mixture files cannot be updated using this process.";
						flag8 = false;
					}
					if (flag8)
					{
						if (flag7)
						{
							text6 = text8;
							text8 = jb.g() + "\\" + A_2;
						}
						int A_67 = 0;
						jb.d[] A_68 = null;
						string[] A_69 = null;
						if (flag)
						{
							List<string> A_70 = null;
							List<jb.d> A_71 = null;
							int a_6 = A_63;
							string[] a_7 = A_6;
							jb.d[] a_8 = A_5;
							jb.f a_9 = f10;
							List<string> A_72 = null;
							List<jb.d> A_73 = null;
							jb.f A_74 = jb.f.a;
							a(a_6, a_7, a_8, a_9, ref A_72, ref A_73, ref A_70, ref A_71, ref A_74);
							A_67 = A_70.Count;
							A_69 = A_70.ToArray();
							A_68 = A_71.ToArray();
							int num10 = A_67;
							a(null, A_17, null, ref A_67, ref A_68, ref A_69);
							if (f10 != jb.f.a)
							{
								int num11 = num10;
								int num12 = A_67 - 1;
								for (num11 = num10; num11 <= num12; num11++)
								{
									A_68[num11] = jb.d.k;
									A_69[num11] = jb.a(f10, jb.e.a, A_69[num11]);
								}
								if (!string.IsNullOrEmpty(A_10))
								{
									A_69 = (string[])Utils.CopyArray(A_69, new string[A_67 + 1]);
									A_68 = (jb.d[])Utils.CopyArray(A_68, new jb.d[A_67 + 1]);
									A_68[A_67] = jb.d.k;
									A_69[A_67] = jb.a(f10, jb.e.d, A_10);
									A_67++;
								}
								if (!string.IsNullOrEmpty(A_11))
								{
									A_69 = (string[])Utils.CopyArray(A_69, new string[A_67 + 1]);
									A_68 = (jb.d[])Utils.CopyArray(A_68, new jb.d[A_67 + 1]);
									A_68[A_67] = jb.d.k;
									A_69[A_67] = jb.a(f10, jb.e.e, A_11);
									A_67++;
								}
								A_10 = A_3;
							}
						}
						else
						{
							a(A_16, A_17, A_18, ref A_67, ref A_68, ref A_69);
						}
						if (flag)
						{
							if (!string.IsNullOrEmpty(A_35))
							{
								A_35 = iz.e(A_35).ToString(CultureInfo.InvariantCulture);
							}
							if (!string.IsNullOrEmpty(A_36))
							{
								A_36 = iz.e(A_36).ToString(CultureInfo.InvariantCulture);
							}
							if (!string.IsNullOrEmpty(A_37))
							{
								A_37 = iz.e(A_37).ToString(CultureInfo.InvariantCulture);
							}
							if (!string.IsNullOrEmpty(A_38))
							{
								A_38 = iz.e(A_38).ToString(CultureInfo.InvariantCulture);
							}
						}
						else
						{
							if (!string.IsNullOrEmpty(A_24))
							{
								A_35 = iz.e(A_24).ToString(CultureInfo.InvariantCulture);
							}
							if (!string.IsNullOrEmpty(A_25))
							{
								A_36 = iz.e(A_25).ToString(CultureInfo.InvariantCulture);
							}
							if (!string.IsNullOrEmpty(A_26))
							{
								A_37 = iz.e(A_26).ToString(CultureInfo.InvariantCulture);
							}
							if (!string.IsNullOrEmpty(A_27))
							{
								A_38 = iz.e(A_27).ToString(CultureInfo.InvariantCulture);
							}
						}
						a(A_31, A_34, A_35, A_36, A_37, A_38, A_20, list2, list, flag, f10, ref A_67, ref A_68, ref A_69);
						if (((flag && f10 == jb.f.a) || !flag) && !string.IsNullOrEmpty(A_11))
						{
							A_69 = (string[])Utils.CopyArray(A_69, new string[A_67 + 1]);
							A_68 = (jb.d[])Utils.CopyArray(A_68, new jb.d[A_67 + 1]);
							A_68[A_67] = jb.d.m;
							A_69[A_67] = A_11;
							A_67++;
						}
						jb.a(text8, A_46, A_47, A_48, (short)A_49, A_60, A_61, (short)A_62, A_51, A_50, A_10, A_12, A_67, A_68, A_69, !A_64);
						if (flag7)
						{
							dl obj = new dl();
							obj.a(c5.bb(), eb.b.a, text8, a10, i6.a(this), ref A_75);
							if (obj.DialogResult == DialogResult.Cancel)
							{
								flag9 = true;
								text4 += " was skipped due to user cancellation of database Update task.";
							}
							else if (A_75)
							{
								if (File.Exists(text6))
								{
									File.Delete(text6);
								}
								File.Copy(text8, text6);
							}
							else
							{
								text4 += " was skipped due to failure of Database Update task.";
							}
							File.Delete(text8);
						}
						if (!flag7 || A_75)
						{
							if (num < 15)
							{
								if (!string.IsNullOrEmpty(text2))
								{
									text2 += "\r\n";
								}
								text2 += A_2;
							}
							else if (num == 15)
							{
								text2 += "\r\nAdditional files noted in log...";
							}
							if (!string.IsNullOrEmpty(text3))
							{
								text3 += "\r\n";
							}
							text3 += A_2;
							num++;
						}
					}
					if (!flag8 || (flag7 && !A_75))
					{
						if (!string.IsNullOrEmpty(text3))
						{
							text3 += "\r\n";
						}
						text3 += text4;
						if (string.IsNullOrEmpty(text5))
						{
							text5 = "One or more Database files was skipped due to communication or license issues. Details are noted in log...";
						}
					}
				}
				if (!string.IsNullOrEmpty(text5))
				{
					if (!string.IsNullOrEmpty(text2))
					{
						text2 += "\r\n";
					}
					text2 += text5;
				}
				SystemSounds.Exclamation.Play();
				if (string.IsNullOrEmpty(text2))
				{
					fe.b(c0, "No differences detected. No files have been altered.", "Information", i6.a(bb()));
					return;
				}
				StreamWriter streamWriter = null;
				string text9 = jb.d() + "\\UpdateLog.txt";
				try
				{
					streamWriter = new StreamWriter(text9, append: true, Encoding.ASCII);
					streamWriter.WriteLine("****File Update Event " + DateTime.Now.ToString());
					streamWriter.WriteLine(text3);
				}
				finally
				{
					streamWriter?.Close();
				}
				fe.b(c0, "File update activity logged in: " + text9 + "\r\n\r\n" + num + " files were updated, including:\r\n" + text2, "Information", i6.a(bb()));
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception a_10 = ex4;
				i5.a(c0, c1, c2, i6.a(bb()), "DialogEditLibrary.ButtonUpdateFiles_Click", a_10);
				ProjectData.ClearProjectError();
			}
			finally
			{
				bb().Cursor = Cursors.Default;
			}
		}
	}

	private void a(int A_0, jb.d[] A_1, string[] A_2, jb.f A_3, ref List<string> A_4, ref List<string> A_5, ref List<string> A_6)
	{
		A_4 = new List<string>();
		A_5 = new List<string>();
		A_6 = new List<string>();
		checked
		{
			int num = A_0 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				string text = A_2[num2];
				if (string.IsNullOrEmpty(text))
				{
					continue;
				}
				switch (A_1[num2])
				{
				case jb.d.a:
					if (A_3 == jb.f.a)
					{
						A_4.Add(text);
					}
					break;
				case jb.d.b:
					if (A_3 == jb.f.a)
					{
						A_5.Add(text);
					}
					break;
				case jb.d.c:
					if (A_3 == jb.f.a)
					{
						A_6.Add(text);
					}
					break;
				case jb.d.k:
					if (A_3 != jb.f.a && jb.ah(text) == A_3 && jb.ag(text) == jb.e.a)
					{
						A_5.Add(jb.af(text));
					}
					break;
				}
			}
			A_4.Sort();
			A_5.Sort();
			A_6.Sort();
		}
	}

	private void a(int A_0, jb.d[] A_1, string[] A_2, jb.f A_3, ref string A_4, ref string A_5, ref string A_6, ref string A_7, ref string A_8, ref string A_9, ref List<string> A_10, ref List<string> A_11, ref List<string> A_12)
	{
		A_4 = null;
		A_5 = null;
		A_6 = null;
		A_7 = null;
		A_8 = null;
		A_9 = null;
		A_10 = new List<string>();
		A_11 = new List<string>();
		A_12 = new List<string>();
		checked
		{
			int num = A_0 - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (string.IsNullOrEmpty(A_2[num2]))
				{
					continue;
				}
				if (A_3 == jb.f.a)
				{
					switch (A_1[num2])
					{
					case jb.d.d:
						A_4 = A_2[num2];
						break;
					case jb.d.e:
						A_5 = A_2[num2];
						break;
					case jb.d.f:
						A_6 = A_2[num2];
						break;
					case jb.d.g:
						A_7 = A_2[num2];
						break;
					case jb.d.h:
						A_8 = A_2[num2];
						break;
					case jb.d.i:
						A_9 = A_2[num2];
						break;
					case jb.d.j:
						A_10.Add(A_2[num2]);
						break;
					case jb.d.k:
						A_11.Add(A_2[num2]);
						break;
					case jb.d.l:
						A_12.Add(A_2[num2]);
						break;
					}
				}
				else if (A_1[num2] == jb.d.k)
				{
					switch (jb.ag(A_2[num2]))
					{
					case jb.e.b:
						A_4 = jb.af(A_2[num2]);
						break;
					case jb.e.c:
						A_10.Add(jb.af(A_2[num2]));
						break;
					}
				}
			}
		}
	}

	private void a(jb.d A_0, List<string> A_1, ref int A_2, jb.d[] A_3, string[] A_4)
	{
		if (A_1 == null)
		{
			return;
		}
		checked
		{
			foreach (string item in A_1)
			{
				A_3[A_2] = A_0;
				A_4[A_2] = item;
				A_2++;
			}
		}
	}

	private void a(List<string> A_0, List<string> A_1, List<string> A_2, ref int A_3, ref jb.d[] A_4, ref string[] A_5)
	{
		int A_6 = A_3;
		checked
		{
			if (A_0 != null)
			{
				A_3 += A_0.Count;
			}
			if (A_1 != null)
			{
				A_3 += A_1.Count;
			}
			if (A_2 != null)
			{
				A_3 += A_2.Count;
			}
			A_4 = (jb.d[])Utils.CopyArray(A_4, new jb.d[A_3 - 1 + 1]);
			A_5 = (string[])Utils.CopyArray(A_5, new string[A_3 - 1 + 1]);
			a(jb.d.a, A_0, ref A_6, A_4, A_5);
			a(jb.d.b, A_1, ref A_6, A_4, A_5);
			a(jb.d.c, A_2, ref A_6, A_4, A_5);
		}
	}

	private void a(string A_0, string A_1, string A_2, string A_3, string A_4, string A_5, List<string> A_6, List<string> A_7, List<string> A_8, bool A_9, jb.f A_10, ref int A_11, ref jb.d[] A_12, ref string[] A_13)
	{
		int num = A_11;
		checked
		{
			if (!string.IsNullOrEmpty(A_0))
			{
				A_11++;
			}
			if (!string.IsNullOrEmpty(A_1))
			{
				A_11++;
			}
			if (!string.IsNullOrEmpty(A_2))
			{
				A_11++;
			}
			if (!string.IsNullOrEmpty(A_3))
			{
				A_11++;
			}
			if (!string.IsNullOrEmpty(A_4))
			{
				A_11++;
			}
			if (!string.IsNullOrEmpty(A_5))
			{
				A_11++;
			}
			if (A_8 != null && A_8.Count > 0)
			{
				A_11 += A_8.Count;
			}
			A_12 = (jb.d[])Utils.CopyArray(A_12, new jb.d[A_11 - 1 + 1]);
			A_13 = (string[])Utils.CopyArray(A_13, new string[A_11 - 1 + 1]);
			if (!string.IsNullOrEmpty(A_0))
			{
				if (A_9)
				{
					A_12[num] = jb.d.k;
					A_13[num] = jb.a(A_10, jb.e.b, A_0);
				}
				else
				{
					A_12[num] = jb.d.d;
					A_13[num] = A_0;
				}
				num++;
			}
			if (!string.IsNullOrEmpty(A_1))
			{
				if (A_9)
				{
					throw new ax("AccessType not allowed if updating only localizable strings");
				}
				A_12[num] = jb.d.e;
				A_13[num] = A_1;
				num++;
			}
			if (!string.IsNullOrEmpty(A_2))
			{
				if (A_9)
				{
					throw new ax("unencryptedMinWave not allowed if updating only localizable strings");
				}
				A_12[num] = jb.d.f;
				A_13[num] = A_2;
				num++;
			}
			if (!string.IsNullOrEmpty(A_3))
			{
				if (A_9)
				{
					throw new ax("unencryptedMaxWave not allowed if updating only localizable strings");
				}
				A_12[num] = jb.d.g;
				A_13[num] = A_3;
				num++;
			}
			if (!string.IsNullOrEmpty(A_4))
			{
				if (A_9)
				{
					throw new ax("unencryptedPermMinWave not allowed if updating only localizable strings");
				}
				A_12[num] = jb.d.h;
				A_13[num] = A_4;
				num++;
			}
			if (!string.IsNullOrEmpty(A_5))
			{
				if (A_9)
				{
					throw new ax("unencryptedPermMaxWave not allowed if updating only localizable strings");
				}
				A_12[num] = jb.d.i;
				A_13[num] = A_5;
				num++;
			}
			if (A_6 != null && A_6.Count > 0)
			{
				if (A_9)
				{
					throw new ax("recommendedEquipment not allowed if updating only localizable strings");
				}
				foreach (string item in A_6)
				{
					A_12[num] = jb.d.l;
					A_13[num] = item;
					num++;
				}
			}
			if (A_7 != null && A_7.Count > 0)
			{
				if (A_9)
				{
					throw new ax("localizedStrings not allowed if updating only localizable strings");
				}
				foreach (string item2 in A_7)
				{
					A_12[num] = jb.d.k;
					A_13[num] = item2;
					num++;
				}
			}
			if (A_8 == null || A_8.Count <= 0)
			{
				return;
			}
			foreach (string item3 in A_8)
			{
				if (A_9)
				{
					A_12[num] = jb.d.k;
					A_13[num] = jb.a(A_10, jb.e.c, item3);
				}
				else
				{
					A_12[num] = jb.d.j;
					A_13[num] = item3;
				}
				num++;
			}
		}
	}

	private void a(string A_0, List<string> A_1, StreamWriter A_2)
	{
		string text = string.Empty;
		foreach (string item in A_1)
		{
			if (!string.IsNullOrEmpty(text))
			{
				text += "; ";
			}
			text += item;
		}
		A_2.Write(A_0 + "\"" + text.Replace("\"", "\"\"") + "\"");
	}

	private bool h()
	{
		if (Operators.CompareString(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator, ".", TextCompare: false) != 0)
		{
			fe.b(c0, "The summary file cannot be created if the decimal separator is not set to '.'.\r\nThe resulting file can only be read by Excel when the regional settings on your computer are configured with the\r\ndecimal separator set to '.'.", i6.a(ba()));
			return false;
		}
		return true;
	}

	private void j(object A_0, EventArgs A_1)
	{
		try
		{
			if (!h())
			{
				return;
			}
			ba().Cursor = Cursors.WaitCursor;
			List<string> list = new List<string>();
			string text = "";
			Collection<string> collection = jb.k();
			Collection<FileInfo[]> collection2 = new Collection<FileInfo[]>();
			string A_2;
			string A_3;
			jb.d[] A_4;
			string[] A_5;
			FileInfo fileInfo;
			List<string> A_6;
			List<string> A_7;
			List<string> A_8;
			StreamWriter streamWriter;
			jc A_9;
			Collection<eb.c> A_10;
			string text2;
			checked
			{
				foreach (string item in collection)
				{
					collection2.Add(new DirectoryInfo(item).GetFiles("*.*"));
					FileInfo[] array = collection2[collection2.Count - 1];
					for (int num = 0; num < array.Length; num++)
					{
						text = array[num].FullName;
						if (jb.n(text) || jb.j(text))
						{
							list.Add(Path.GetFileNameWithoutExtension(text));
						}
					}
				}
				list.Sort();
				A_2 = null;
				A_3 = null;
				A_4 = null;
				A_5 = null;
				fileInfo = null;
				A_6 = null;
				A_7 = null;
				A_8 = null;
				streamWriter = null;
				A_9 = null;
				A_10 = null;
				text2 = jb.d() + "\\Material Files Info";
			}
			jb.f f10 = (jb.f)checked((short)Enum.GetValues(typeof(jb.f)).GetUpperBound(0));
			bool flag = default(bool);
			string text4;
			jb.f f11 = default(jb.f);
			int A_27 = default(int);
			short A_28 = default(short);
			short A_29 = default(short);
			int A_30 = default(int);
			int A_31 = default(int);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			do
			{
				string text3;
				jb.f a_;
				if (flag)
				{
					text3 = string.Empty;
					a_ = jb.f.a;
					text4 = text2 + ".txt";
				}
				else
				{
					text3 = jb.a(f11);
					a_ = f11;
					text4 = text2 + " - " + text3 + ".txt";
				}
				checked
				{
					try
					{
						DateTime A_11 = DateTime.MinValue;
						DateTime A_12 = DateTime.MinValue;
						LicenseLevel A_13 = LicenseLevel.Unlicensed;
						d9.a(eb.b.a, ref A_11, ref A_12, ref A_13, ref A_10);
						try
						{
							streamWriter = new StreamWriter(text4, append: false, Encoding.UTF8);
						}
						catch (IOException ex2)
						{
							ProjectData.SetProjectError(ex2);
							IOException ex3 = ex2;
							fe.b(c0, "Unable to open output file. Error is: \r\r" + ex3.Message, i6.a(ba()));
							ProjectData.ClearProjectError();
							return;
						}
						if (flag)
						{
							streamWriter.WriteLine("\"" + text3 + "\"\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\"0-Unreleased\"");
							streamWriter.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\"1-UnencryptedAll\"");
							streamWriter.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\"2-UnencryptedAllWithPermission\"");
							streamWriter.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\"3-EncryptedCustomerWithPermission\"");
							streamWriter.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\"4-CustomerSpecific\"");
							streamWriter.WriteLine("\"(Read Only)\"\t\"(Read Only)\"\t\"(Read Only)\"\t\"(Read Only)\"\t\"(Read Only)\"\t\"\"\t\"\"\t\"\"\t\"\"\t\"\"\t\"(Read Only)\"\t\"(Read Only)\"\t\"\"\t\"(Read Only)\"\t\"(Read Only)\"\t\"\"");
							streamWriter.WriteLine("\"Filename\"\t\"Where\"\t\"Date-Time (UTC)\"\t\"Start Wave\"\t\"End Wave\"\t\"Information\"\t\"HtmlInformation\"\t\"Private Information\"\t\"Synonyms\"\t\"Keywords\"\t\"Similar Materials\"\t\"Custom Model?\"\t\"Model Type\"\t\"" + jb.d(jb.d.d) + "\"\t\"OMDB Release Level\"\t\"Auto Access Type\"\t\"" + jb.d(jb.d.e) + "\"\t\"" + jb.d(jb.d.f) + "\"\t\"" + jb.d(jb.d.g) + "\"\t\"" + jb.d(jb.d.h) + "\"\t\"" + jb.d(jb.d.i) + "\"\t\"Rec. Equip.\"\t\"#Local. Strings\"\t\"# Html Links\"\t\"Variable Fields (from here to the end of the row)\"");
						}
						else
						{
							streamWriter.WriteLine("\"" + text3 + "\"");
							streamWriter.WriteLine("\"(Read Only)\"\t\"(Read Only)\"\t\"(Read Only)\"\t\t\t\t\"(Read Only)\"");
							streamWriter.WriteLine("\"Filename\"\t\"Where\"\t\"Date-Time (UTC)\"\t\"Information\"\t\"HtmlInformation\"\t\"Keywords\"\t\"" + jb.d(jb.d.d) + "\"\t\"# Html Links\"\t\"Variable Fields (from here to the end of the row)\"");
						}
						foreach (string item2 in list)
						{
							double[] A_14 = null;
							double[] A_15 = null;
							double[] A_16 = null;
							hd a_2 = c3;
							short[] A_17 = null;
							double[] A_18 = null;
							eo a_3 = c5;
							string A_19 = null;
							bool A_20 = false;
							bool A_21 = false;
							bool A_22 = false;
							int A_23 = 0;
							string A_24 = null;
							bool A_25 = false;
							string A_26 = null;
							if (jb.a(item2, A_1: false, ref A_14, ref A_15, ref A_16, A_5: true, A_6: true, ref A_27, a_2, ref A_28, ref A_29, ref A_30, ref A_17, ref A_18, a_3, ref A_19, ref A_20, ref A_21, ref A_22, ref A_2, ref A_3, ref A_23, ref A_24, ref A_31, ref A_4, ref A_5, ref A_25, ref A_26, ref A_9, c6) != jb.a.a)
							{
								A_27 = 0;
								A_2 = "";
								A_3 = "";
								A_31 = 0;
							}
							bool flag2 = false;
							foreach (FileInfo[] item3 in collection2)
							{
								for (A_23 = 0; A_23 < item3.Length; A_23++)
								{
									fileInfo = item3[A_23];
									text = fileInfo.FullName;
									if (Operators.CompareString(Path.GetFileNameWithoutExtension(text), item2, TextCompare: false) == 0 && (jb.n(text) || jb.j(text)))
									{
										flag2 = true;
										break;
									}
								}
								if (flag2)
								{
									break;
								}
							}
							if (!flag2)
							{
								text = item2 + ".badfile";
							}
							streamWriter.Write("\"" + Path.GetFileName(text).Replace("\"", "\"\"") + "\"");
							streamWriter.Write("\t\"Material\"");
							streamWriter.Write("\t\"" + fileInfo.LastWriteTimeUtc.ToString("u", CultureInfo.InvariantCulture) + "\"");
							if (flag)
							{
								if (A_9 == null)
								{
									if (A_27 > 0)
									{
										streamWriter.Write("\t" + Conversions.ToString((int)Math.Round(A_14[0])));
										streamWriter.Write("\t" + Conversions.ToString((int)Math.Round(A_14[A_27 - 1])));
									}
									else
									{
										streamWriter.Write("\t\"Bad File\"");
										streamWriter.Write("\t\"Bad File\"");
									}
								}
								else
								{
									streamWriter.Write("\t\"N/A\"");
									streamWriter.Write("\t\"N/A\"");
								}
							}
							string text5 = string.Empty;
							string text6;
							if (flag || f11 == jb.f.a)
							{
								text6 = A_2;
								for (int num2 = 0; num2 < A_31; num2++)
								{
									if (A_4[num2] == jb.d.m)
									{
										text5 = A_5[num2];
										break;
									}
								}
							}
							else
							{
								text6 = string.Empty;
								for (int num3 = 0; num3 < A_31; num3++)
								{
									if (flag3 && flag4)
									{
										break;
									}
									if (A_4[num3] == jb.d.k && jb.ah(A_5[num3]) == f11)
									{
										switch (jb.ag(A_5[num3]))
										{
										case jb.e.d:
											text6 = jb.af(A_5[num3]);
											flag3 = true;
											break;
										case jb.e.e:
											text5 = jb.af(A_5[num3]);
											flag4 = true;
											break;
										}
									}
								}
							}
							streamWriter.Write("\t\"" + jg.d(text6.Replace("\"", "\"\"")) + "\"");
							streamWriter.Write("\t\"" + jg.d(text5.Replace("\"", "\"\"")) + "\"");
							if (flag)
							{
								streamWriter.Write("\t\"" + jg.d(A_3.Replace("\"", "\"\"")) + "\"");
							}
							a(A_31, A_4, A_5, a_, ref A_6, ref A_7, ref A_8);
							if (flag)
							{
								a("\t", A_6, streamWriter);
							}
							a("\t", A_7, streamWriter);
							if (flag)
							{
								a("\t", A_8, streamWriter);
								if (A_30 > 0)
								{
									streamWriter.Write("\t\"Yes\"");
									streamWriter.Write("\t\"" + c3.j(A_29, c5, c6).Replace("\"", "\"\"") + "\"");
								}
								else
								{
									streamWriter.Write("\t\"No\"");
									streamWriter.Write("\t");
								}
							}
							string A_32 = string.Empty;
							string A_33 = string.Empty;
							string A_34 = string.Empty;
							string A_35 = string.Empty;
							string A_36 = string.Empty;
							string A_37 = string.Empty;
							List<string> A_38 = null;
							List<string> A_39 = null;
							List<string> A_40 = null;
							a(A_31, A_4, A_5, a_, ref A_33, ref A_32, ref A_35, ref A_34, ref A_37, ref A_36, ref A_38, ref A_39, ref A_40);
							string empty = string.Empty;
							string empty2 = string.Empty;
							eb.a a10 = d9.a(A_10, item2);
							if (a10 != eb.a.a)
							{
								empty2 = eb.a(a10);
								if (string.Compare(item2, "Insulator", ignoreCase: true) != 0)
								{
									empty = jb.a(a10);
									if (a10 == eb.a.c)
									{
										A_32 = string.Empty;
									}
								}
								else
								{
									empty = jb.a(eb.a.b);
									if (!string.IsNullOrEmpty(A_32) && int.Parse(A_32) != 0)
									{
										A_32 = string.Empty;
									}
								}
							}
							else
							{
								empty2 = eb.a(eb.a.a);
								empty = jb.a(eb.a.a);
								A_32 = string.Empty;
							}
							if (string.IsNullOrEmpty(A_33))
							{
								streamWriter.Write("\t");
							}
							else
							{
								streamWriter.Write("\t\"" + jg.d(A_33.Replace("\"", "\"\"")) + "\"");
							}
							if (flag)
							{
								streamWriter.Write("\t\"" + empty2.Replace("\"", "\"\"") + "\"");
								streamWriter.Write("\t\"" + empty.Replace("\"", "\"\"") + "\"");
								if (string.IsNullOrEmpty(A_32))
								{
									streamWriter.Write("\t");
								}
								else
								{
									streamWriter.Write("\t\"" + A_32.Replace("\"", "\"\"") + "\"");
								}
								if (string.IsNullOrEmpty(A_35))
								{
									streamWriter.Write("\t");
								}
								else
								{
									streamWriter.Write("\t" + A_35);
								}
								if (string.IsNullOrEmpty(A_34))
								{
									streamWriter.Write("\t");
								}
								else
								{
									streamWriter.Write("\t" + A_34);
								}
								if (string.IsNullOrEmpty(A_37))
								{
									streamWriter.Write("\t");
								}
								else
								{
									streamWriter.Write("\t" + A_37);
								}
								if (string.IsNullOrEmpty(A_36))
								{
									streamWriter.Write("\t");
								}
								else
								{
									streamWriter.Write("\t" + A_36);
								}
								a("\t", A_40, streamWriter);
								streamWriter.Write("\t" + A_39.Count.ToString(CultureInfo.InvariantCulture));
							}
							streamWriter.Write("\t" + A_38.Count.ToString(CultureInfo.InvariantCulture));
							if (flag)
							{
								int num4 = A_39.Count - 1;
								for (int num5 = 0; num5 <= num4; num5++)
								{
									streamWriter.Write("\t\"" + jg.d(A_39[num5].Replace("\"", "\"\"")) + "\"");
								}
							}
							int num6 = A_38.Count - 1;
							for (int num7 = 0; num7 <= num6; num7++)
							{
								streamWriter.Write("\t\"" + jg.d(A_38[num7].Replace("\"", "\"\"")) + "\"");
							}
							streamWriter.WriteLine();
						}
					}
					finally
					{
						streamWriter?.Close();
					}
				}
				if (f11 < f10)
				{
					f11 = (jb.f)checked((short)unchecked(f11 + 1));
				}
				else if (flag)
				{
					flag5 = true;
				}
				else
				{
					flag = true;
				}
			}
			while (!flag5);
			Process.Start(text4);
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception a_4 = ex4;
			i5.a(c0, c1, c2, i6.a(ba()), "DialogEditLibrary.ButtonCreateSummary_Click", a_4);
			ProjectData.ClearProjectError();
		}
		finally
		{
			ba().Cursor = Cursors.Default;
		}
	}

	private void f(object A_0, DataGridViewCellEventArgs A_1)
	{
		try
		{
			bool num = A_1.ColumnIndex == bd().Columns.IndexOf(bk());
			bool flag = A_1.ColumnIndex == bd().Columns.IndexOf(bn());
			if (num)
			{
				string A_2 = string.Empty;
				object objectValue = RuntimeHelpers.GetObjectValue(bd().Rows[A_1.RowIndex].Cells[0].Value);
				if (objectValue != null)
				{
					A_2 = objectValue.ToString();
				}
				string A_3 = null;
				a(ref A_3, A_1: false, ref A_2);
				if (!string.IsNullOrEmpty(A_2))
				{
					bd().Rows[A_1.RowIndex].Cells[0].Value = Path.GetFileNameWithoutExtension(A_2);
					this.m_bu = null;
				}
			}
			else if (flag)
			{
				bd().EndEdit();
				f();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(x()), "DialogEditLibrary.DataGridViewMixture_CellContentClick", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(string[] A_0, float[] A_1, int[] A_2, bool[] A_3)
	{
		checked
		{
			int num = A_0.Length - 2;
			DataGridView dataGridView = bd();
			int index = dataGridView.Columns.IndexOf(bl());
			int index2 = dataGridView.Columns.IndexOf(bn());
			int index3 = dataGridView.Columns.IndexOf(bm());
			int index4 = dataGridView.Columns.IndexOf(bo());
			dataGridView.Rows.Clear();
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				dataGridView.Rows.Add(A_0[num3], null, 100f * A_1[num3], A_2[num3], A_3[num3], 1);
			}
			string A_4 = "NotApplicableAbbrev";
			string text = hu.a(ref A_4);
			dataGridView.Rows.Add(A_0[A_0.Length - 1], null, null, text, null, text);
			DataGridViewCellCollection cells = dataGridView.Rows[dataGridView.Rows.Count - 1].Cells;
			DataGridViewCell dataGridViewCell = cells[index];
			dataGridViewCell.ReadOnly = true;
			dataGridViewCell.Style.ForeColor = SystemColors.InactiveCaptionText;
			dataGridViewCell.Style.BackColor = SystemColors.InactiveCaption;
			_ = null;
			DataGridViewCell dataGridViewCell2 = cells[index3];
			dataGridViewCell2.ReadOnly = true;
			dataGridViewCell2.Style.ForeColor = SystemColors.InactiveCaptionText;
			dataGridViewCell2.Style.BackColor = SystemColors.InactiveCaption;
			_ = null;
			DataGridViewCell dataGridViewCell3 = cells[index2];
			dataGridViewCell3.ReadOnly = true;
			dataGridViewCell3.Style.ForeColor = SystemColors.InactiveCaptionText;
			dataGridViewCell3.Style.BackColor = SystemColors.InactiveCaption;
			_ = null;
			DataGridViewCell dataGridViewCell4 = cells[index4];
			dataGridViewCell4.ReadOnly = true;
			dataGridViewCell4.Style.ForeColor = SystemColors.InactiveCaptionText;
			dataGridViewCell4.Style.BackColor = SystemColors.InactiveCaption;
			_ = null;
			_ = null;
			dataGridView = null;
			g();
			f();
			d();
		}
	}

	private void g()
	{
		float A_ = 0f;
		bool A_2 = default(bool);
		a(ref A_2, ref A_);
		DataGridViewRowCollection rows = bd().Rows;
		DataGridViewCell dataGridViewCell = rows[checked(rows.Count - 1)].Cells[bd().Columns.IndexOf(bl())];
		if (A_2)
		{
			dataGridViewCell.Value = 100f - A_;
		}
		else
		{
			dataGridViewCell.Value = "Invalid";
		}
		dataGridViewCell = null;
		_ = null;
	}

	private void f()
	{
		DataGridViewRowCollection rows = bd().Rows;
		int index = bd().Columns.IndexOf(bn());
		int index2 = bd().Columns.IndexOf(bm());
		int index3 = bd().Columns.IndexOf(bo());
		bool flag = true;
		string A_ = "NotApplicableAbbrev";
		string value = hu.a(ref A_);
		checked
		{
			int num = rows.Count - 2;
			for (int num2 = 0; num2 <= num; num2++)
			{
				DataGridViewCellCollection cells = rows[num2].Cells;
				bool flag2 = Conversions.ToBoolean(cells[index].Value);
				if (!flag2)
				{
					flag = false;
				}
				DataGridViewCell dataGridViewCell = cells[index2];
				dataGridViewCell.ReadOnly = flag2;
				if (flag2)
				{
					dataGridViewCell.Style.ForeColor = SystemColors.InactiveCaptionText;
					dataGridViewCell.Style.BackColor = SystemColors.InactiveCaption;
					dataGridViewCell.Value = value;
				}
				else
				{
					dataGridViewCell.Style.ForeColor = Color.Black;
					dataGridViewCell.Style.BackColor = SystemColors.Window;
					string obj = dataGridViewCell.Value.ToString();
					int result = 0;
					if (!int.TryParse(obj, out result))
					{
						dataGridViewCell.Value = 2.ToString();
					}
				}
				dataGridViewCell = null;
				DataGridViewCell dataGridViewCell2 = cells[index3];
				dataGridViewCell2.ReadOnly = flag2;
				if (flag2)
				{
					dataGridViewCell2.Style.ForeColor = SystemColors.InactiveCaptionText;
					dataGridViewCell2.Style.BackColor = SystemColors.InactiveCaption;
					dataGridViewCell2.Value = value;
				}
				else
				{
					dataGridViewCell2.Style.ForeColor = Color.Black;
					dataGridViewCell2.Style.BackColor = SystemColors.Window;
					string obj2 = dataGridViewCell2.Value.ToString();
					int result = 0;
					if (!int.TryParse(obj2, out result))
					{
						dataGridViewCell2.Value = 1.ToString();
					}
				}
				dataGridViewCell2 = null;
				_ = null;
			}
			rows[rows.Count - 1].Cells[index].Value = flag;
			rows = null;
		}
	}

	private void e()
	{
		DataGridViewRowCollection rows = bd().Rows;
		int index = bd().Columns.IndexOf(bn());
		int index2 = bd().Columns.IndexOf(bm());
		int index3 = bd().Columns.IndexOf(bo());
		string A_ = "NotApplicableAbbrev";
		string value = hu.a(ref A_);
		checked
		{
			int num = rows.Count - 2;
			bool flag = default(bool);
			for (int num2 = 0; num2 <= num; num2++)
			{
				DataGridViewCellCollection cells = rows[num2].Cells;
				if (!Conversions.ToBoolean(cells[index].Value))
				{
					int num3 = int.Parse(cells[index2].Value.ToString());
					DataGridViewCell dataGridViewCell = cells[index3];
					dataGridViewCell.ReadOnly = flag;
					if (flag)
					{
						dataGridViewCell.Style.ForeColor = SystemColors.InactiveCaptionText;
						dataGridViewCell.Style.BackColor = SystemColors.InactiveCaption;
						dataGridViewCell.Value = value;
					}
					else
					{
						dataGridViewCell.Style.ForeColor = Color.Black;
						dataGridViewCell.Style.BackColor = SystemColors.Window;
						if (!int.TryParse(dataGridViewCell.Value.ToString(), out var result))
						{
							dataGridViewCell.Value = 1.ToString();
							result = 1;
						}
						flag = result == num3;
					}
					dataGridViewCell = null;
				}
				cells = null;
			}
			rows = null;
		}
	}

	private void d()
	{
		bh().Enabled = bd().Rows.Count > 2;
	}

	private void e(object A_0, DataGridViewCellEventArgs A_1)
	{
		try
		{
			DataGridViewRowCollection rows = bd().Rows;
			if (rows.Count == 0)
			{
				return;
			}
			int num = bd().Columns.IndexOf(bo());
			if (!c7)
			{
				int num2 = checked(rows.Count - 1);
				if (A_1.RowIndex == num2)
				{
					return;
				}
				bool flag = Conversions.ToBoolean(rows[A_1.RowIndex].Cells[bd().Columns.IndexOf(bn())].Value);
				if (A_1.ColumnIndex == bd().Columns.IndexOf(bl()))
				{
					g();
				}
				else if (A_1.ColumnIndex == bd().Columns.IndexOf(bn()))
				{
					f();
				}
				else if (A_1.ColumnIndex == bd().Columns.IndexOf(bm()))
				{
					if (!flag)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(bd().Rows[A_1.RowIndex].Cells[A_1.ColumnIndex].Value);
						if (objectValue == null || !int.TryParse(objectValue.ToString(), out var result) || result < 2)
						{
							fe.b(c0, "Minimum # GridPts is " + 2, i6.a(bd()));
							result = 2;
							try
							{
								c7 = true;
								bd().Rows[A_1.RowIndex].Cells[A_1.ColumnIndex].Value = result;
							}
							finally
							{
								c7 = false;
							}
						}
						objectValue = RuntimeHelpers.GetObjectValue(bd().Rows[A_1.RowIndex].Cells[num].Value);
						int result2 = default(int);
						if (objectValue == null || !int.TryParse(objectValue.ToString(), out result2) || result2 < 1 || result2 > result)
						{
							result2 = ((result2 < 1) ? 1 : result);
							try
							{
								c7 = true;
								bd().Rows[A_1.RowIndex].Cells[num].Value = result2;
							}
							finally
							{
								c7 = false;
							}
						}
						try
						{
							c7 = true;
							e();
						}
						finally
						{
							c7 = false;
						}
					}
				}
				else if (A_1.ColumnIndex == num && !flag)
				{
					int index = bd().Columns.IndexOf(bm());
					object objectValue = RuntimeHelpers.GetObjectValue(bd().Rows[A_1.RowIndex].Cells[index].Value);
					int num3 = Conversions.ToInteger(objectValue.ToString());
					objectValue = RuntimeHelpers.GetObjectValue(bd().Rows[A_1.RowIndex].Cells[A_1.ColumnIndex].Value);
					int result3 = default(int);
					if (objectValue == null || !int.TryParse(objectValue.ToString(), out result3) || result3 < 1 || result3 > num3)
					{
						fe.b(c0, "Current Grid Pt may not be less than 1 or greater than " + num3, i6.a(bd()));
						result3 = ((result3 < 1) ? 1 : num3);
						try
						{
							c7 = true;
							bd().Rows[A_1.RowIndex].Cells[A_1.ColumnIndex].Value = result3;
						}
						finally
						{
							c7 = false;
						}
					}
					try
					{
						c7 = true;
						e();
					}
					finally
					{
						c7 = false;
					}
				}
				if (A_1.ColumnIndex != num)
				{
					this.m_bu = null;
				}
			}
			c8 = true;
			cp = true;
			rows = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(x()), "DialogEditLibrary.DataGridViewMixture_CellValueChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		try
		{
			string A_2 = string.Empty;
			string A_3 = null;
			a(ref A_3, A_1: false, ref A_2);
			if (!string.IsNullOrEmpty(A_2))
			{
				bd().Rows.Insert(0, Path.GetFileNameWithoutExtension(A_2), null, "0", 2, false, 1);
			}
			d();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(x()), "DialogEditLibrary.RadioCustom_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (bd().SelectedRows.Count == 0)
				{
					if (bd().SelectedCells.Count > 0)
					{
						List<int> list = new List<int>();
						foreach (DataGridViewCell selectedCell in bd().SelectedCells)
						{
							if (!list.Contains(selectedCell.RowIndex))
							{
								list.Add(selectedCell.RowIndex);
							}
						}
						if (bd().Rows.Count - list.Count < 2)
						{
							fz a_ = c0;
							string A_2 = "EditMaterialLibraryMixtureDeleteError";
							fe.b(a_, hu.a(ref A_2), i6.a(bh()));
							return;
						}
						list.Sort();
						for (int num = list.Count - 1; num >= 0; num += -1)
						{
							bd().Rows.RemoveAt(list[num]);
						}
					}
				}
				else
				{
					if (bd().Rows.Count - bd().SelectedRows.Count < 2)
					{
						fz a_2 = c0;
						string A_2 = "EditMaterialLibraryMixtureDeleteError";
						fe.b(a_2, hu.a(ref A_2), i6.a(bh()));
						return;
					}
					foreach (DataGridViewRow selectedRow in bd().SelectedRows)
					{
						bd().Rows.Remove(selectedRow);
					}
				}
				g();
				d();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				i5.a(c0, c1, c2, i6.a(x()), "DialogEditLibrary.ButtonMixtureDelete_Click", a_3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		try
		{
			if (!c7)
			{
				this.m_bt = checked((short)((iz.a)bq().SelectedItem).b);
				this.m_bp = c3.j(this.m_bt);
				this.m_bu = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(x()), "DialogEditLibrary.ComboBoxModel_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	public e7()
	{
		base.Activated += r;
		base.Deactivate += q;
		base.FormClosing += a;
		this.m_br = new double[17];
		this.m_bs = new short[17];
		cg = new List<string>();
		ch = new List<jb.d>();
		cm = new je();
		cn = new je();
		q();
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
		{
			if (!c7)
			{
				DataGridViewCell dataGridViewCell = a7()[0, dm];
				dataGridViewCell.Value = br().Text;
				dataGridViewCell.ErrorText = string.Empty;
				_ = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(x()), "DialogEditLibrary.ComboBoxAccessType_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, DataGridViewCellEventArgs A_1)
	{
		try
		{
			a(A_1.ColumnIndex, A_1.RowIndex);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(x()), "DialogEditLibrary.DataGridViewAttributes_CellClick", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c(object A_0, DataGridViewCellEventArgs A_1)
	{
		try
		{
			a(A_1.RowIndex);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(x()), "DialogEditLibrary.DataGridViewAttributes_CellEnter", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, DataGridViewCellEventArgs A_1)
	{
		try
		{
			if (A_1.ColumnIndex == 0 && a7()[1, A_1.RowIndex].Value != null && Operators.CompareString(a7()[1, A_1.RowIndex].Value.ToString(), jb.d(jb.d.j), TextCompare: false) == 0)
			{
				DataGridViewCell dataGridViewCell = a7()[0, A_1.RowIndex];
				a(this.m_bv, 0, dataGridViewCell.EditedFormattedValue.ToString());
				dataGridViewCell = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(x()), "DialogEditLibrary.DataGridViewAttributes_CellContentDoubleClick", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, DataGridViewCellFormattingEventArgs A_1)
	{
		try
		{
			DataGridViewCell dataGridViewCell = a7().Rows[A_1.RowIndex].Cells[A_1.ColumnIndex];
			if (A_1.ColumnIndex == 0 && a7()[1, A_1.RowIndex].Value != null && Operators.CompareString(a7()[1, A_1.RowIndex].Value.ToString(), jb.d(jb.d.j), TextCompare: false) == 0)
			{
				if (dataGridViewCell.Value != null)
				{
					dataGridViewCell.ToolTipText = dataGridViewCell.Value.ToString() + "\r\n(Double-Click to open browser window showing link for testing)";
				}
			}
			else
			{
				dataGridViewCell.ToolTipText = string.Empty;
			}
			dataGridViewCell = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			c0.c(fz.b.b, "Error in DialogEditLibrary.DataGridViewAttributes_CellFormatting", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, DataGridViewEditingControlShowingEventArgs A_1)
	{
		try
		{
			if (A_1.Control is DataGridViewComboBoxEditingControl)
			{
				DataGridViewComboBoxEditingControl obj = (DataGridViewComboBoxEditingControl)A_1.Control;
				obj.SelectedIndexChanged -= e;
				obj.SelectedIndexChanged += e;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			c0.c(fz.b.b, "Error in DialogEditLibrary.DataGridViewAttributes_EditingControlShowing", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			DataGridViewComboBoxEditingControl dataGridViewComboBoxEditingControl = (DataGridViewComboBoxEditingControl)A_0;
			if (jb.al(dataGridViewComboBoxEditingControl.SelectedItem.ToString()) == jb.d.j && (a7()[0, dataGridViewComboBoxEditingControl.EditingControlRowIndex].Value == null || string.IsNullOrEmpty(a7()[0, dataGridViewComboBoxEditingControl.EditingControlRowIndex].Value.ToString().Trim())))
			{
				a7()[0, dataGridViewComboBoxEditingControl.EditingControlRowIndex].Value = "<a href=\"http://www.filmetrics.com/\" title=\"The title\">FI Site</a>";
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			c0.c(fz.b.b, "Error in DialogEditLibrary.DataGridViewAttributesTypeCombo_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void c()
	{
		Collection<int> collection = new Collection<int>();
		checked
		{
			int num = a7().RowCount - 2;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (a7()[1, num2].Value == null || string.IsNullOrEmpty(a7()[1, num2].Value.ToString()))
				{
					collection.Add(num2);
					continue;
				}
				string left = a7()[1, num2].Value.ToString();
				int num3 = num2 + 1;
				int num4 = a7().RowCount - 2;
				for (int num5 = num3; num5 <= num4; num5++)
				{
					if (Operators.CompareString(left, jb.d(jb.d.b), TextCompare: false) != 0 && Operators.CompareString(left, jb.d(jb.d.a), TextCompare: false) != 0 && Operators.CompareString(left, jb.d(jb.d.c), TextCompare: false) != 0 && Operators.CompareString(left, jb.d(jb.d.j), TextCompare: false) != 0 && a7()[1, num5].Value != null && !string.IsNullOrEmpty(a7()[1, num5].Value.ToString()) && Operators.CompareString(left, a7()[1, num5].Value.ToString(), TextCompare: false) == 0)
					{
						if (!collection.Contains(num2))
						{
							collection.Add(num2);
						}
						if (!collection.Contains(num5))
						{
							collection.Add(num5);
						}
					}
				}
			}
			int num6 = a7().RowCount - 2;
			for (int num7 = 0; num7 <= num6; num7++)
			{
				if (collection.Contains(num7))
				{
					if (a7()[1, num7].Value == null || string.IsNullOrEmpty(a7()[1, num7].Value.ToString()))
					{
						a7()[1, num7].ErrorText = "Attribute type is not specified";
					}
					else
					{
						a7()[1, num7].ErrorText = "This attribute is in the table already";
					}
				}
				else
				{
					a7()[1, num7].ErrorText = string.Empty;
				}
			}
		}
	}

	private bool a(int A_0, ref int A_1)
	{
		jf.b b10 = null;
		jf.b b11 = null;
		if (a7()[1, A_0].Value == null)
		{
			return true;
		}
		DataGridViewCell dataGridViewCell = a7()[0, A_0];
		if (dataGridViewCell.Value == null || Operators.CompareString(dataGridViewCell.Value.ToString().Trim(), string.Empty, TextCompare: false) == 0)
		{
			return false;
		}
		jb.d a_;
		double a_2;
		switch (jb.al(a7()[1, A_0].Value.ToString()))
		{
		case jb.d.f:
			b10 = jf.d;
			b11 = jf.a;
			a_ = jb.d.g;
			a_2 = 0.0;
			break;
		case jb.d.g:
			b10 = jf.b;
			b11 = jf.c;
			a_ = jb.d.f;
			a_2 = 10000.0;
			break;
		case jb.d.h:
			b10 = jf.d;
			b11 = jf.a;
			a_ = jb.d.i;
			a_2 = 0.0;
			break;
		case jb.d.i:
			b10 = jf.b;
			b11 = jf.c;
			a_ = jb.d.h;
			a_2 = 10000.0;
			break;
		case jb.d.e:
		{
			object objectValue = RuntimeHelpers.GetObjectValue(a7()[0, A_0].Value);
			if (objectValue == null)
			{
				return false;
			}
			return jb.aj(objectValue.ToString());
		}
		default:
			return true;
		}
		string right = jb.d(a_);
		if (!double.TryParse(dataGridViewCell.Value.ToString(), out var result))
		{
			return false;
		}
		if (b10(result, a_2))
		{
			return false;
		}
		dataGridViewCell = null;
		A_1 = -1;
		checked
		{
			int num = a7().RowCount - 2;
			for (int num2 = 0; num2 <= num; num2++)
			{
				DataGridViewCell dataGridViewCell2 = a7()[1, num2];
				if (dataGridViewCell2.Value != null && Operators.CompareString(dataGridViewCell2.Value.ToString(), right, TextCompare: false) == 0)
				{
					A_1 = num2;
					break;
				}
				dataGridViewCell2 = null;
			}
			if (A_1 == -1)
			{
				return true;
			}
			if (b11(result, iz.e(a7()[0, A_1].Value.ToString())))
			{
				return false;
			}
			return true;
		}
	}

	private void a(object A_0, DataGridViewCellEventArgs A_1)
	{
		try
		{
			int A_2 = -1;
			DataGridViewCell dataGridViewCell = a7()[1, A_1.RowIndex];
			if (dataGridViewCell.Value != null && Operators.CompareString(dataGridViewCell.Value.ToString(), jb.d(jb.d.e), TextCompare: false) == 0 && A_1.ColumnIndex == 0)
			{
				a7()[0, A_1.RowIndex].Value = br().Text;
			}
			dataGridViewCell = null;
			if (!a(A_1.RowIndex, ref A_2))
			{
				a7()[0, A_1.RowIndex].ErrorText = "Invalid Entry";
				if (A_2 > -1)
				{
					a7()[0, A_2].ErrorText = "Invalid Entry";
				}
			}
			else
			{
				a7()[0, A_1.RowIndex].ErrorText = string.Empty;
				if (A_2 > -1)
				{
					a7()[0, A_2].ErrorText = string.Empty;
				}
			}
			c();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(x()), "DialogEditLibrary.DataGridViewAttributes_CellEndEdit", a_);
			ProjectData.ClearProjectError();
		}
	}

	private bool b()
	{
		bool flag = true;
		checked
		{
			int num = a7().RowCount - 2;
			for (int num2 = 0; num2 <= num; num2++)
			{
				int num3 = a7().ColumnCount - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (!string.IsNullOrEmpty(a7()[num4, num2].ErrorText))
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				ref fz a_ = ref c0;
				Point A_ = i6.a(this);
				fe.b(ref a_, "One or more Invalid Attribute Items are present (File Information tab).\r\nErrors must be fixed before file can be saved", ref A_);
			}
			return flag;
		}
	}

	private bool a()
	{
		return a(A_0: false, eb.a.a);
	}

	private bool b(eb.a A_0)
	{
		return a(A_0: true, A_0);
	}

	private bool a(bool A_0, eb.a A_1)
	{
		bool flag = false;
		Collection<eb.c> A_2 = null;
		checked
		{
			if (jb.i())
			{
				if (A_0)
				{
					if (a(A_1))
					{
						return false;
					}
				}
				else
				{
					DateTime A_3 = DateTime.MinValue;
					DateTime A_4 = DateTime.MinValue;
					LicenseLevel A_5 = LicenseLevel.Unlicensed;
					d9.a(eb.b.a, ref A_3, ref A_4, ref A_5, ref A_2);
					if (a(A_2, this.m_bv))
					{
						return false;
					}
				}
				int num = a7().RowCount - 2;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (Operators.CompareString(a7()[1, num2].Value.ToString(), jb.d(jb.d.e), TextCompare: false) == 0)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					ref fz a_ = ref c0;
					Point A_6 = i6.a(this);
					fe.b(ref a_, "Access Type attribute is not allowed for this file.\r\nYou must delete the Access Type attribute before the file can be saved.", ref A_6);
				}
			}
			return flag;
		}
	}

	private bool a(Collection<eb.c> A_0, string A_1)
	{
		eb.a a_ = d9.a(A_0, Path.GetFileNameWithoutExtension(A_1));
		return a(a_);
	}

	private bool a(eb.a A_0)
	{
		if (A_0 != eb.a.a)
		{
			return A_0 != eb.a.a && A_0 != eb.a.b && A_0 != eb.a.c;
		}
		return false;
	}

	private void a(object A_0, DataGridViewRowsRemovedEventArgs A_1)
	{
		checked
		{
			try
			{
				Collection<int> collection = new Collection<int>();
				int num = a7().RowCount - 2;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (!string.IsNullOrEmpty(a7()[0, num2].ErrorText))
					{
						collection.Add(num2);
					}
				}
				int num3 = a7().RowCount - 2;
				int A_2 = default(int);
				for (int num4 = 0; num4 <= num3; num4++)
				{
					int num5 = collection.IndexOf(num4);
					if (num5 >= 0)
					{
						if (!a(collection[num5], ref A_2))
						{
							a7()[0, collection[num5]].ErrorText = "Invalid Entry";
							if (A_2 > -1)
							{
								a7()[0, A_2].ErrorText = "Invalid Entry";
							}
						}
					}
					else
					{
						a7()[0, num4].ErrorText = string.Empty;
					}
				}
				c();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(c0, c1, c2, i6.a(x()), "DialogEditLibrary.DataGridViewAttributes_RowsRemoved", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void a(object A_0, ScrollEventArgs A_1)
	{
		try
		{
			br().Visible = false;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(x()), "DialogEditLibrary.DataGridViewAttributes_Scroll", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, DataGridViewCellCancelEventArgs A_1)
	{
		try
		{
			a(A_1.ColumnIndex, A_1.RowIndex);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(x()), "DialogEditLibrary.DataGridViewAttributes_CellBeginEdit", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(int A_0, int A_1)
	{
		dm = A_1;
		Rectangle cellDisplayRectangle = a7().GetCellDisplayRectangle(0, A_1, cutOverflow: false);
		checked
		{
			int num = cellDisplayRectangle.Left + a7().Left;
			int num2 = cellDisplayRectangle.Top + a7().Top;
			if (A_1 <= -1)
			{
				return;
			}
			if (a7()[1, A_1].Value != null && Operators.CompareString(a7()[1, A_1].Value.ToString(), jb.d(jb.d.e), TextCompare: false) == 0 && A_0 == 0)
			{
				br().Location = new Point(num, num2);
				br().Size = new Size(cellDisplayRectangle.Width, cellDisplayRectangle.Height);
				br().Visible = true;
				try
				{
					c7 = true;
					if (a7()[0, A_1].Value != null)
					{
						br().Text = a7()[0, A_1].Value.ToString();
						return;
					}
					br().SelectedIndex = 0;
					a7()[0, A_1].Value = br().Text;
					a7()[0, A_1].ErrorText = string.Empty;
					return;
				}
				finally
				{
					c7 = false;
				}
			}
			br().Visible = false;
		}
	}

	private void a(int A_0)
	{
		DataGridViewCell dataGridViewCell = a7()[1, A_0];
		bool flag = dataGridViewCell.Value != null && !string.IsNullOrEmpty(dataGridViewCell.Value.ToString());
		dataGridViewCell = null;
		bool flag2 = A_0 == 0;
		bool flag3 = A_0 >= checked(a7().RowCount - 2);
		bv().Enabled = flag && !flag2;
		bu().Enabled = flag && !flag3;
	}

	private void a(string A_0, int A_1, string A_2)
	{
		string a_ = string.Concat("<html>\r\n<head>\r\n<title>" + A_0 + "</title>\r\n", "</head>\r\n<body>\r\n<p>The html renders as (the line below, including any subsequent lines up until the Note paragraph at the bottom): <br />\r\n", A_2, "\r\n</p>\r\n<p>Note:<br />\r\nBe sure to check the title by hovering the mouse pointer over the link.<br />\r\nYou should also click the link to make sure it sends you where you expect it to.<br />\r\nIf your link is not appearing the way you expected it to check for the presence of extra quotation marks.<br />\r\nIn order to embed a literal quotation mark in an html string, you can use the escape code &amp;quot<br />\r\n<br />\r\nExample links:<br />\r\nLink html: &lt;a href=&quot;http://www.filmetrics.com/&quot; title=&quot;The title&quot;&gt;FI Site&lt;/a&gt;<br />\r\nRendered link: <a href=\"http://www.filmetrics.com/\" title=\"The title\">FI Site</a><br />\r\n<br />\r\nLink html: Chisholm, Hugh, ed (1911). &lt;a href=&quot;http://en.wikisource.org/wiki/1911_Encyclop%C3%A6dia_Britannica/Silica&quot; title=&quot;wikisource:1911Encyclop&amp;#230;dia_Britannica/Silica&quot;&gt;&amp;quot;Silica&amp;quot;&lt;/a&gt; &lt;a href=&quot;http://en.wikipedia.org/wiki/Encyclop%C3%A6dia_Britannica_Eleventh_Edition&quot; title=&quot;Encyclop&amp;#230;dia Britannica Eleventh Edition&quot;&gt;Encyclop&amp;#230;dia Britannica;&lt;/a&gt (Eleventh ed.). Cambridge University Press.<br />\r\nRendered link: Chisholm, Hugh, ed (1911). <a href=\"http://en.wikisource.org/wiki/1911_Encyclop%C3%A6dia_Britannica/Silica\" title=\"wikisource:1911Encyclop&#230;dia_Britannica/Silica\">\"Silica\"</a> <a href=\"http://en.wikipedia.org/wiki/Encyclop%C3%A6dia_Britannica_Eleventh_Edition\" title=\"Encyclop&#230;dia Britannica Eleventh Edition\">Encyclop&#230;dia Britannica</a> (Eleventh ed.). Cambridge University Press.<br />\r\n<br />\r\n</p>\r\n</body>\r\n</html>\r\n");
		new ds().a(c0, c1, c2, a_);
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			if (bw().SelectedIndex < 0)
			{
				return;
			}
			jb.f f10 = jb.ai(bw().SelectedItem.ToString());
			DataGridViewComboBoxCell.ObjectCollection items = ((DataGridViewComboBoxColumn)a7().Columns[1]).Items;
			items.Clear();
			jb.d d10 = (jb.d)checked((short)Enum.GetValues(typeof(jb.d)).GetUpperBound(0));
			for (jb.d d11 = jb.d.a; d11 <= d10; d11++)
			{
				if (d11 != jb.d.k && d11 != jb.d.m && (f10 == jb.f.a || jb.b(d11)))
				{
					items.Add(jb.d(d11));
				}
			}
			items = null;
			az().Visible = c5.a8() && f10 == jb.f.a;
			a0().Visible = c5.a8() && f10 == jb.f.a;
			jb.d[] A_2 = null;
			string[] A_3 = null;
			int A_4 = default(int);
			a(ref A_4, ref A_2, ref A_3, ref cj);
			List<string> A_5 = null;
			List<jb.d> A_6 = null;
			a(A_4, A_3, A_2, f10, ref A_5, ref A_6, ref cg, ref ch, ref ci);
			a(A_5, A_6, cj);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(z()), "DialogEditLibrary.ComboBoxAttrStringLanguage_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(bool A_0)
	{
		List<string> A_1 = null;
		List<jb.d> A_2 = null;
		string A_3 = null;
		a(jb.ai(bw().SelectedItem.ToString()), ref A_1, ref A_2, ref A_3);
		DataGridViewSelectedRowCollection selectedRows = a7().SelectedRows;
		checked
		{
			int num;
			int num2;
			int num3;
			if (A_0)
			{
				num = -1;
				num2 = selectedRows.Count - 1;
				num3 = 0;
			}
			else
			{
				num = 1;
				num2 = 0;
				num3 = selectedRows.Count - 1;
			}
			int num4 = num2;
			int num5 = num3;
			int num6 = num;
			for (int num7 = num4; ((num6 >> 31) ^ num7) <= ((num6 >> 31) ^ num5); num7 += num6)
			{
				int rowIndex = selectedRows[num7].Cells[0].RowIndex;
				jb.d value = A_2[rowIndex];
				string value2 = A_1[rowIndex];
				A_2[rowIndex] = A_2[rowIndex - num];
				A_1[rowIndex] = A_1[rowIndex - num];
				A_2[rowIndex - num] = value;
				A_1[rowIndex - num] = value2;
			}
			selectedRows = null;
			int firstDisplayedScrollingRowIndex = a7().FirstDisplayedScrollingRowIndex;
			a(A_1, A_2, A_3);
			a7().FirstDisplayedScrollingRowIndex = firstDisplayedScrollingRowIndex;
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			a(A_0: false);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(z()), "DialogEditLibrary.ButtonAttrMoveUp_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		try
		{
			a(A_0: true);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(z()), "DialogEditLibrary.ButtonAttrMoveDown_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		try
		{
			if (by().Checked)
			{
				cl = ay().Text.Trim();
				ay().Text = ck;
				ck = null;
			}
			else
			{
				ck = ay().Text.Trim();
				ay().Text = cl;
				cl = null;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(c0, c1, c2, i6.a(z()), "DialogEditLibrary.RadioButtonText_CheckedChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		al().o((fu)null);
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
	}

	private void a(object A_0, PreviewKeyDownEventArgs A_1)
	{
		checked
		{
			try
			{
				if (!A_1.Control || A_1.KeyCode != Keys.V)
				{
					return;
				}
				string text = Clipboard.GetText();
				if (string.IsNullOrEmpty(text))
				{
					return;
				}
				string[] array = new string[1];
				char[] array2 = new char[1];
				DataGridView dataGridView = ak();
				int num = dataGridView.CurrentCell.RowIndex;
				array[0] = "\r\n";
				array2[0] = '\t';
				string[] array3 = text.Split(array, StringSplitOptions.None);
				_ = array3.Length - 1;
				string[] array4 = array3[0].Split(array2);
				int num2 = array4.Length;
				if (num2 > 1)
				{
					if (num2 != dataGridView.Columns.Count)
					{
						i5.a(c0, c1, c2, i6.a(z()), "DialogEditLibrary.TheGrid2_KeyDown", "If selecting more than once cell to paste you must select 3 columns of data");
						return;
					}
					if (num < dataGridView.Rows.Count - 1)
					{
						string empty = string.Empty;
						if (!fe.b(A_1: ((num == 0) ? "All data" : ((num != dataGridView.Rows.Count - 2) ? ("Data from row " + Conversions.ToString(num + 1) + " down") : "The last row of data")) + " will be deleted and clipboard data will be appended. Would you like to proceed?", A_0: ref c0, A_2: "Warning", A_3: "Yes", A_4: "No", A_5: i6.a(ak())))
						{
							return;
						}
					}
					int num3 = dataGridView.Rows.Count - num;
					int num4 = array3.Length - num3;
					if (num4 > 0)
					{
						dataGridView.Rows.Add(num4);
					}
					else if (num4 < 0)
					{
						int num5 = dataGridView.Rows.Count - 2;
						int num6 = array3.Length + num - 1;
						for (int num7 = num5; num7 >= num6; num7 += -1)
						{
							dataGridView.Rows.RemoveAt(num7);
						}
					}
					string[] array5 = array3;
					int num10 = default(int);
					foreach (string text2 in array5)
					{
						if (num > dataGridView.Rows.Count - 1)
						{
							continue;
						}
						array4 = text2.Split(array2);
						int num9 = num10;
						int num11 = array4.Length - 1;
						for (int num12 = 0; num12 <= num11; num12++)
						{
							if (num9 <= dataGridView.Columns.Count - 1)
							{
								ak()[num9, num].Value = array4[num12];
								num9++;
							}
						}
						num++;
					}
					dataGridView = null;
				}
				else
				{
					ak()[dataGridView.CurrentCell.ColumnIndex, dataGridView.CurrentCell.RowIndex].Value = array4[0];
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(c0, c1, c2, i6.a(z()), "DialogEditLibrary.TheGrid2_KeyDown", a_);
				ProjectData.ClearProjectError();
			}
		}
	}
}
