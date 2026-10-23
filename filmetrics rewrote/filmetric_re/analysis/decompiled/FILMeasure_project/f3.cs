using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class f3 : UserControl
{
	public class a
	{
		public delegate void a(int A_0);

		[CompilerGenerated]
		private a m_a;

		[SpecialName]
		[CompilerGenerated]
		public void b(a A_0)
		{
			a a10 = this.m_a;
			a a11;
			do
			{
				a11 = a10;
				a value = (a)Delegate.Combine(a11, A_0);
				a10 = Interlocked.CompareExchange(ref this.m_a, value, a11);
			}
			while ((object)a10 != a11);
		}

		[SpecialName]
		[CompilerGenerated]
		public void c(a A_0)
		{
			a a10 = this.m_a;
			a a11;
			do
			{
				a11 = a10;
				a value = (a)Delegate.Remove(a11, A_0);
				a10 = Interlocked.CompareExchange(ref this.m_a, value, a11);
			}
			while ((object)a10 != a11);
		}

		public void b(int A_0)
		{
			this.m_a?.Invoke(A_0);
		}
	}

	public class b
	{
		public delegate void a(hc A_0, ref ek A_1, ref int A_2, ref int A_3, ref int A_4, ref List<ek> A_5);

		public delegate void b(hc A_0);

		[CompilerGenerated]
		private a m_a;

		[CompilerGenerated]
		private b m_b;

		[SpecialName]
		[CompilerGenerated]
		public void c(a A_0)
		{
			a a10 = this.m_a;
			a a11;
			do
			{
				a11 = a10;
				a value = (a)Delegate.Combine(a11, A_0);
				a10 = Interlocked.CompareExchange(ref this.m_a, value, a11);
			}
			while ((object)a10 != a11);
		}

		[SpecialName]
		[CompilerGenerated]
		public void d(a A_0)
		{
			a a10 = this.m_a;
			a a11;
			do
			{
				a11 = a10;
				a value = (a)Delegate.Remove(a11, A_0);
				a10 = Interlocked.CompareExchange(ref this.m_a, value, a11);
			}
			while ((object)a10 != a11);
		}

		[SpecialName]
		[CompilerGenerated]
		public void c(b A_0)
		{
			b b10 = this.m_b;
			b b11;
			do
			{
				b11 = b10;
				b value = (b)Delegate.Combine(b11, A_0);
				b10 = Interlocked.CompareExchange(ref this.m_b, value, b11);
			}
			while ((object)b10 != b11);
		}

		[SpecialName]
		[CompilerGenerated]
		public void d(b A_0)
		{
			b b10 = this.m_b;
			b b11;
			do
			{
				b11 = b10;
				b value = (b)Delegate.Remove(b11, A_0);
				b10 = Interlocked.CompareExchange(ref this.m_b, value, b11);
			}
			while ((object)b10 != b11);
		}

		public void c(hc A_0, ref ek A_1, ref int A_2, ref int A_3, ref int A_4, ref List<ek> A_5)
		{
			A_1 = null;
			if (A_5 == null)
			{
				A_5 = new List<ek>();
			}
			this.m_a?.Invoke(A_0, ref A_1, ref A_2, ref A_3, ref A_4, ref A_5);
		}

		public void c(hc A_0)
		{
			this.m_b?.Invoke(A_0);
		}
	}

	internal class c
	{
		private float a;

		private string b;

		private int m_c;

		public c(float A_0, string A_1, int A_2)
		{
			a = A_0;
			b = A_1;
			m_c = A_2;
		}

		[SpecialName]
		public int d()
		{
			return m_c;
		}

		[SpecialName]
		public float e()
		{
			return a;
		}

		[SpecialName]
		public string f()
		{
			return b;
		}
	}

	public class d
	{
		public enum ResGridColumnType : short
		{
			Param = 0,
			Number = -1,
			MMGuid = -2,
			Sample = -3,
			Location = -4,
			Res = -5,
			SS = -6
		}

		public enum a : short
		{
			a,
			b,
			c,
			d,
			e
		}

		public const string a = "Sample";

		public const string b = "Location";

		public const string c = "Res";

		public const string d = "SS";

		public ResGridColumnType e;

		public int f;

		public bool g;

		public d(ResGridColumnType A_0, int A_1, bool A_2)
		{
			e = A_0;
			f = A_1;
			g = A_2;
		}

		public d(DataGridViewColumn A_0, DataGridViewColumn A_1, DataGridViewColumn A_2)
		{
			int A_3 = default(int);
			if (h(A_0.Name, ref A_3))
			{
				e = ResGridColumnType.Param;
				f = A_3;
			}
			else
			{
				e = h(A_0, A_1, A_2);
				f = -1;
			}
			g = false;
		}

		public void h(ref d A_0)
		{
			if (A_0 == null)
			{
				A_0 = new d(e, f, g);
				return;
			}
			d obj = A_0;
			obj.e = e;
			obj.f = f;
			obj.g = g;
			_ = null;
		}

		[SpecialName]
		public static bool i(d A_0, d A_1)
		{
			return !h(A_0, A_1);
		}

		[SpecialName]
		public static bool h(d A_0, d A_1)
		{
			return ix.a(A_0, A_1) switch
			{
				ix.a.a => false, 
				ix.a.b => true, 
				_ => A_0.e != A_1.e || A_0.f != A_1.f, 
			};
		}

		[SpecialName]
		public bool i(DataGridViewColumn A_0, DataGridViewColumn A_1, DataGridViewColumn A_2)
		{
			int A_3 = default(int);
			if (h(A_0.Name, ref A_3))
			{
				return e == ResGridColumnType.Param && f == A_3;
			}
			return e == h(A_0, A_1, A_2);
		}

		[SpecialName]
		public a h()
		{
			switch (e)
			{
			case ResGridColumnType.Param:
				if (f < 11)
				{
					return f3.d.a.c;
				}
				return f3.d.a.b;
			case ResGridColumnType.Number:
				return f3.d.a.a;
			case ResGridColumnType.MMGuid:
				return f3.d.a.d;
			default:
				return f3.d.a.e;
			}
		}

		[SpecialName]
		public bool h(d A_0)
		{
			a a10 = h();
			a a11 = A_0.h();
			if (a10 == a11)
			{
				return i(A_0);
			}
			return a10 < a11;
		}

		[SpecialName]
		public bool i(d A_0)
		{
			switch (h())
			{
			case f3.d.a.b:
			case f3.d.a.c:
				return f <= A_0.f;
			case f3.d.a.e:
				return e >= A_0.e;
			default:
			{
				bool result = default(bool);
				return result;
			}
			}
		}

		public static ResGridColumnType h(DataGridViewColumn A_0, DataGridViewColumn A_1, DataGridViewColumn A_2)
		{
			if (A_0 != null)
			{
				if (A_0 == A_1)
				{
					return ResGridColumnType.Number;
				}
				if (A_0 == A_2)
				{
					return ResGridColumnType.MMGuid;
				}
				if (Operators.CompareString(A_0.Name, "Sample", TextCompare: false) == 0)
				{
					return ResGridColumnType.Sample;
				}
				if (Operators.CompareString(A_0.Name, "Location", TextCompare: false) == 0)
				{
					return ResGridColumnType.Location;
				}
				if (Operators.CompareString(A_0.Name, "Res", TextCompare: false) == 0)
				{
					return ResGridColumnType.Res;
				}
				if (Operators.CompareString(A_0.Name, "SS", TextCompare: false) == 0)
				{
					return ResGridColumnType.SS;
				}
				throw new Exception("No matched column type found.");
			}
			throw new Exception("Column cannot be Nothing.");
		}

		public static bool h(string A_0, ref int A_1)
		{
			if (int.TryParse(A_0, out A_1))
			{
				return true;
			}
			return false;
		}

		public static d h(Collection<d> A_0)
		{
			d d10 = A_0[0];
			checked
			{
				int num = A_0.Count - 1;
				for (int num2 = 1; num2 <= num; num2++)
				{
					if (A_0[num2].h(d10))
					{
						d10 = A_0[num2];
					}
				}
				return d10;
			}
		}
	}

	private delegate void e(ref ji.a A_0);

	private IContainer m_a;

	[CompilerGenerated]
	private TabPage m_b;

	[CompilerGenerated]
	private RichTextBox m_c;

	[CompilerGenerated]
	private TabPage m_d;

	[CompilerGenerated]
	private Label m_e;

	[CompilerGenerated]
	private ComboBox m_f;

	[CompilerGenerated]
	private GroupBox m_g;

	[CompilerGenerated]
	private Label m_h;

	[CompilerGenerated]
	private ComboBox m_i;

	[CompilerGenerated]
	private Button m_j;

	[CompilerGenerated]
	private DataGridView m_k;

	[CompilerGenerated]
	private DataGridView m_l;

	[CompilerGenerated]
	private Button m_m;

	[CompilerGenerated]
	private GroupBox m_n;

	[CompilerGenerated]
	private Button m_o;

	[CompilerGenerated]
	private Button m_p;

	[CompilerGenerated]
	private Button m_q;

	[CompilerGenerated]
	private fl m_r;

	[CompilerGenerated]
	private fl m_s;

	[CompilerGenerated]
	private fl m_t;

	[CompilerGenerated]
	private PictureBox m_u;

	[CompilerGenerated]
	private System.Windows.Forms.Timer m_v;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_w;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_x;

	[CompilerGenerated]
	private TabControl m_y;

	[CompilerGenerated]
	private fl m_z;

	[CompilerGenerated]
	private ComboBox m_aa;

	[CompilerGenerated]
	private ContextMenuStrip m_ab;

	[CompilerGenerated]
	private ToolStripMenuItem m_ac;

	[CompilerGenerated]
	private ToolStripMenuItem m_ad;

	[CompilerGenerated]
	private ToolStripMenuItem m_ae;

	[CompilerGenerated]
	private ToolStripMenuItem m_af;

	[CompilerGenerated]
	private DataGridViewTextBoxColumn m_ag;

	[CompilerGenerated]
	private ToolStripMenuItem m_ah;

	[CompilerGenerated]
	private ToolStripMenuItem m_ai;

	private bool aj;

	private bool ak;

	private fz al;

	private f1 am;

	private bool an;

	private bool ao;

	private float ap;

	private float aq;

	private float ar;

	private float m_as;

	private float m_at;

	private float m_au;

	private Collection<Collection<hc>> m_av;

	private Collection<hc> m_aw;

	private Collection<hc> m_ax;

	private Collection<cb> m_ay;

	private Collection<hg> m_az;

	private object m_a0;

	private Collection m_a1;

	private hr m_a2;

	private DateTime m_a3;

	private int m_a4;

	private bool m_a5;

	private int[] m_a6;

	private int[] m_a7;

	private bool m_a8;

	private int m_a9;

	private string m_ba;

	private bool m_bb;

	private int m_bc;

	private int m_bd;

	private hc m_be;

	private fh.b m_bf;

	private je m_bg;

	private bool m_bh;

	private bool m_bi;

	private bool m_bj;

	private bool m_bk;

	private bool m_bl;

	private bool m_bm;

	private bool m_bn;

	private Collection<string> m_bo;

	private string m_bp;

	private string m_bq;

	private Collection<string> m_br;

	private bool m_bs;

	private bool m_bt;

	private long m_bu;

	private bool m_bv;

	[CompilerGenerated]
	private r.d m_bw;

	private Collection<hc> m_bx;

	private c1 m_by;

	private string m_bz;

	private gg.c m_b0;

	private List<ToolStripMenuItem> m_b1;

	private hc m_b2;

	private object m_b3;

	private const int m_b4 = 1;

	private const int m_b5 = 2;

	private const int b6 = 10;

	private const int b7 = 1;

	private const int b8 = 2;

	private const int b9 = 3;

	private const int ca = 24;

	private const int cb = 3;

	private const string cc = "FIControlPanelHistory";

	private const string cd = "#.00000";

	private const string ce = "0.#####";

	private const string cf = ".fibhi";

	public const int cg = 1;

	public const int ch = 2;

	public const int ci = 3;

	private const string cj = "\\History";

	private const string ck = "History";

	private const int cl = 2;

	private a cm;

	private gk cn;

	private b co;

	private bool cp;

	private DataGridViewColumn cq;

	private DataGridViewColumn cr;

	private DataGridViewColumn cs;

	private DataGridViewColumn ct;

	private d1 cu;

	private d1 cv;

	private d1 cw;

	private Collection<d> cx;

	private bool cy;

	private string cz;

	private string c0;

	private const int c1 = 1;

	private const int c2 = 1;

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
	private void ai()
	{
		this.m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(f3));
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
		a(new TabControl());
		a(new TabPage());
		c(new ComboBox());
		d(new fl());
		b(new fl());
		a(new fl());
		a(new RichTextBox());
		b(new TabPage());
		c(new fl());
		a(new Label());
		a(new ComboBox());
		a(new GroupBox());
		a(new Button());
		b(new GroupBox());
		c(new Button());
		d(new Button());
		e(new Button());
		b(new Button());
		b(new Label());
		b(new ComboBox());
		a(new DataGridView());
		d(new DataGridViewTextBoxColumn());
		b(new DataGridView());
		b(new DataGridViewTextBoxColumn());
		c(new DataGridViewTextBoxColumn());
		a(new PictureBox());
		a(new System.Windows.Forms.Timer(this.m_a));
		a(new ContextMenuStrip(this.m_a));
		c(new ToolStripMenuItem());
		a(new ToolStripMenuItem());
		b(new ToolStripMenuItem());
		d(new ToolStripMenuItem());
		e(new ToolStripMenuItem());
		f(new ToolStripMenuItem());
		bf().SuspendLayout();
		@as().SuspendLayout();
		au().SuspendLayout();
		ax().SuspendLayout();
		a4().SuspendLayout();
		((ISupportInitialize)a1()).BeginInit();
		((ISupportInitialize)a2()).BeginInit();
		((ISupportInitialize)bb()).BeginInit();
		bi().SuspendLayout();
		SuspendLayout();
		componentResourceManager.ApplyResources(bf(), "TabControlHistory");
		bf().Controls.Add(@as());
		bf().Controls.Add(au());
		bf().Name = "TabControlHistory";
		bf().SelectedIndex = 0;
		componentResourceManager.ApplyResources(@as(), "TabPageSingleMeas");
		@as().BackColor = SystemColors.ButtonFace;
		@as().Controls.Add(bh());
		@as().Controls.Add(bg());
		@as().Controls.Add(a9());
		@as().Controls.Add(a8());
		@as().Controls.Add(at());
		@as().Name = "TabPageSingleMeas";
		componentResourceManager.ApplyResources(bh(), "ComboHistoryIndex");
		bh().DropDownStyle = ComboBoxStyle.DropDownList;
		bh().FormattingEnabled = true;
		bh().Name = "ComboHistoryIndex";
		bg().o((gq)null);
		componentResourceManager.ApplyResources(bg(), "GraphHistoryIndex");
		bg().v(A_0: false);
		bg().AllowDrop = true;
		bg().u(A_0: false);
		bg().BackColor = Color.Transparent;
		bg().w(A_0: false);
		bg().al(A_0: true);
		bg().x(A_0: false);
		bg().ah(A_0: false);
		bg().r("Right-click activates/deactivates Cursor");
		bg().y(A_0: true);
		bg().z(A_0: false);
		bg().aa(A_0: false);
		bg().ac(A_0: false);
		bg().ab(A_0: false);
		bg().o((fz)null);
		bg().ad(A_0: false);
		bg().Name = "GraphHistoryIndex";
		bg().q("SiO2 on Si Spectrum taken 01/31/2007 12:34 PM ");
		bg().q(1);
		bg().t(A_0: false);
		bg().am(A_0: false);
		bg().t((string)null);
		bg().an(A_0: false);
		bg().ae(A_0: false);
		bg().af(A_0: false);
		bg().ag(A_0: true);
		bg().o((fu)null);
		bg().aj(A_0: false);
		bg().ai(A_0: false);
		bg().s((string)null);
		a9().o((gq)null);
		componentResourceManager.ApplyResources(a9(), "GraphHistoryFFTThickness");
		a9().v(A_0: false);
		a9().AllowDrop = true;
		a9().u(A_0: false);
		a9().BackColor = Color.Transparent;
		a9().w(A_0: false);
		a9().al(A_0: false);
		a9().x(A_0: false);
		a9().ah(A_0: false);
		a9().r("Right-click activates/deactivates Cursor");
		a9().y(A_0: true);
		a9().z(A_0: false);
		a9().aa(A_0: false);
		a9().ac(A_0: false);
		a9().ab(A_0: false);
		a9().o((fz)null);
		a9().ad(A_0: false);
		a9().Name = "GraphHistoryFFTThickness";
		a9().q("SiO2 on Si Spectrum taken 01/31/2007 12:34 PM ");
		a9().q(1);
		a9().t(A_0: false);
		a9().am(A_0: false);
		a9().t((string)null);
		a9().an(A_0: false);
		a9().ae(A_0: false);
		a9().af(A_0: false);
		a9().ag(A_0: true);
		a9().o((fu)null);
		a9().aj(A_0: false);
		a9().ai(A_0: false);
		a9().s((string)null);
		a8().o((gq)null);
		componentResourceManager.ApplyResources(a8(), "GraphHistoryThickness");
		a8().v(A_0: false);
		a8().AllowDrop = true;
		a8().u(A_0: false);
		a8().BackColor = Color.Transparent;
		a8().w(A_0: false);
		a8().al(A_0: false);
		a8().x(A_0: false);
		a8().ah(A_0: false);
		a8().r("Right-click activates/deactivates Cursor");
		a8().y(A_0: true);
		a8().z(A_0: false);
		a8().aa(A_0: false);
		a8().ac(A_0: false);
		a8().ab(A_0: false);
		a8().o((fz)null);
		a8().ad(A_0: false);
		a8().Name = "GraphHistoryThickness";
		a8().q("SiO2 on Si Spectrum taken 01/31/2007 12:34 PM ");
		a8().q(1);
		a8().t(A_0: false);
		a8().am(A_0: false);
		a8().t((string)null);
		a8().an(A_0: false);
		a8().ae(A_0: false);
		a8().af(A_0: false);
		a8().ag(A_0: true);
		a8().o((fu)null);
		a8().aj(A_0: false);
		a8().ai(A_0: false);
		a8().s((string)null);
		componentResourceManager.ApplyResources(at(), "RichTextBoxHistory");
		at().BackColor = Color.White;
		at().Name = "RichTextBoxHistory";
		at().ReadOnly = true;
		componentResourceManager.ApplyResources(au(), "TabPageTrend");
		au().BackColor = SystemColors.ButtonFace;
		au().Controls.Add(ba());
		au().Controls.Add(av());
		au().Controls.Add(aw());
		au().Name = "TabPageTrend";
		ba().o((gq)null);
		componentResourceManager.ApplyResources(ba(), "GraphHistoryParam");
		ba().v(A_0: false);
		ba().AllowDrop = true;
		ba().u(A_0: false);
		ba().BackColor = Color.Transparent;
		ba().w(A_0: false);
		ba().al(A_0: false);
		ba().x(A_0: false);
		ba().ah(A_0: false);
		ba().r("Right-click activates/deactivates Cursor");
		ba().y(A_0: true);
		ba().z(A_0: false);
		ba().aa(A_0: false);
		ba().ac(A_0: false);
		ba().ab(A_0: false);
		ba().o((fz)null);
		ba().ad(A_0: false);
		ba().Name = "GraphHistoryParam";
		ba().q("SiO2 on Si Spectrum taken 01/31/2007 12:34 PM ");
		ba().q(1);
		ba().t(A_0: false);
		ba().am(A_0: false);
		ba().t((string)null);
		ba().an(A_0: false);
		ba().ae(A_0: false);
		ba().af(A_0: false);
		ba().ag(A_0: true);
		ba().o((fu)null);
		ba().aj(A_0: false);
		ba().ai(A_0: false);
		ba().s((string)null);
		componentResourceManager.ApplyResources(av(), "LabelHistoryParam");
		av().Name = "LabelHistoryParam";
		componentResourceManager.ApplyResources(aw(), "ComboBoxHistoryParam");
		aw().DropDownStyle = ComboBoxStyle.DropDownList;
		aw().FormattingEnabled = true;
		aw().Name = "ComboBoxHistoryParam";
		componentResourceManager.ApplyResources(ax(), "GroupHistoryMeas");
		ax().Controls.Add(a0());
		ax().Controls.Add(a4());
		ax().Controls.Add(a3());
		ax().Controls.Add(ay());
		ax().Controls.Add(az());
		ax().Controls.Add(a1());
		ax().Controls.Add(a2());
		ax().Name = "GroupHistoryMeas";
		ax().TabStop = false;
		componentResourceManager.ApplyResources(a0(), "ButtonHistorySelected");
		a0().Name = "ButtonHistorySelected";
		a0().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(a4(), "GroupHistoryMeasActions");
		a4().Controls.Add(a5());
		a4().Controls.Add(a6());
		a4().Controls.Add(a7());
		a4().Name = "GroupHistoryMeasActions";
		a4().TabStop = false;
		componentResourceManager.ApplyResources(a5(), "ButtonHistoryCopy");
		a5().Name = "ButtonHistoryCopy";
		a5().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(a6(), "ButtonHistoryClear");
		a6().Name = "ButtonHistoryClear";
		a6().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(a7(), "ButtonHistorySave");
		a7().Name = "ButtonHistorySave";
		a7().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(a3(), "ButtonHistoryDelete");
		a3().Name = "ButtonHistoryDelete";
		a3().UseVisualStyleBackColor = true;
		componentResourceManager.ApplyResources(ay(), "LabelHistoryChannel");
		ay().Name = "LabelHistoryChannel";
		componentResourceManager.ApplyResources(az(), "ComboHistoryChannel");
		az().DropDownStyle = ComboBoxStyle.DropDownList;
		az().FormattingEnabled = true;
		az().Items.AddRange(new object[3]
		{
			componentResourceManager.GetString("ComboHistoryChannel.Items"),
			componentResourceManager.GetString("ComboHistoryChannel.Items1"),
			componentResourceManager.GetString("ComboHistoryChannel.Items2")
		});
		az().Name = "ComboHistoryChannel";
		componentResourceManager.ApplyResources(a1(), "DataGridHistoryStats");
		a1().AllowUserToAddRows = false;
		a1().AllowUserToDeleteRows = false;
		a1().AllowUserToResizeColumns = false;
		a1().AllowUserToResizeRows = false;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		a1().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		a1().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		a1().Columns.AddRange(bn());
		a1().Name = "DataGridHistoryStats";
		a1().ReadOnly = true;
		a1().RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
		a1().RowHeadersVisible = false;
		a1().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
		bn().DefaultCellStyle = dataGridViewCellStyle2;
		componentResourceManager.ApplyResources(bn(), "Stats");
		bn().Name = "Stats";
		bn().ReadOnly = true;
		componentResourceManager.ApplyResources(a2(), "DataGridHistoryMeas");
		a2().AllowUserToAddRows = false;
		a2().AllowUserToDeleteRows = false;
		a2().AllowUserToOrderColumns = true;
		a2().AllowUserToResizeColumns = false;
		a2().AllowUserToResizeRows = false;
		dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle3.BackColor = SystemColors.Control;
		dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75f);
		dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
		a2().ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
		a2().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		a2().Columns.AddRange(bd(), be());
		a2().EditMode = DataGridViewEditMode.EditOnEnter;
		a2().Name = "DataGridHistoryMeas";
		a2().RowHeadersVisible = false;
		a2().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
		bd().DefaultCellStyle = dataGridViewCellStyle4;
		componentResourceManager.ApplyResources(bd(), "Number");
		bd().Name = "Number";
		componentResourceManager.ApplyResources(be(), "MeasModuleGUID");
		be().Name = "MeasModuleGUID";
		componentResourceManager.ApplyResources(bb(), "PictureBoxLogo");
		bb().Image = global::d.pd();
		bb().Name = "PictureBoxLogo";
		bb().TabStop = false;
		bc().Interval = 500;
		componentResourceManager.ApplyResources(bi(), "ResultsGridRightClickMenu");
		bi().Items.AddRange(new ToolStripItem[6]
		{
			bl(),
			bj(),
			bk(),
			bm(),
			bo(),
			bp()
		});
		bi().Name = "ResultsGridRightClickMenu";
		componentResourceManager.ApplyResources(bl(), "ResultsGridMenuItemDelete");
		bl().Name = "ResultsGridMenuItemDelete";
		componentResourceManager.ApplyResources(bj(), "ResultsGridMenuItemReanalyze");
		bj().Name = "ResultsGridMenuItemReanalyze";
		componentResourceManager.ApplyResources(bk(), "ResultsGridMenuItemDeleteAndReanalyze");
		bk().Name = "ResultsGridMenuItemDeleteAndReanalyze";
		componentResourceManager.ApplyResources(bm(), "ResultsGridMenuItemExportSpectra");
		bm().Name = "ResultsGridMenuItemExportSpectra";
		componentResourceManager.ApplyResources(bo(), "ResultsGridMenuItemEditColumns");
		bo().Name = "ResultsGridMenuItemEditColumns";
		componentResourceManager.ApplyResources(bp(), "ResultsGridMenuItemSetSampleAndLoc");
		bp().Name = "ResultsGridMenuItemSetSampleAndLoc";
		componentResourceManager.ApplyResources(this, "$this");
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(bb());
		base.Controls.Add(bf());
		base.Controls.Add(ax());
		MinimumSize = new Size(900, 530);
		base.Name = "FIControlPanelHistory";
		bf().ResumeLayout(performLayout: false);
		@as().ResumeLayout(performLayout: false);
		au().ResumeLayout(performLayout: false);
		au().PerformLayout();
		ax().ResumeLayout(performLayout: false);
		ax().PerformLayout();
		a4().ResumeLayout(performLayout: false);
		((ISupportInitialize)a1()).EndInit();
		((ISupportInitialize)a2()).EndInit();
		((ISupportInitialize)bb()).EndInit();
		bi().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage @as()
	{
		return this.m_b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TabPage A_0)
	{
		this.m_b = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual RichTextBox at()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(RichTextBox A_0)
	{
		this.m_c = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabPage au()
	{
		return this.m_d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(TabPage A_0)
	{
		this.m_d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label av()
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
	internal virtual ComboBox aw()
	{
		return this.m_f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
	{
		EventHandler value = i;
		ComboBox comboBox = this.m_f;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_f = A_0;
		comboBox = this.m_f;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual GroupBox ax()
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
	internal virtual Label ay()
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
	internal virtual ComboBox az()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ComboBox A_0)
	{
		EventHandler value = f;
		ComboBox comboBox = this.m_i;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_i = A_0;
		comboBox = this.m_i;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button a0()
	{
		return this.m_j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = g;
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
	internal virtual DataGridView a1()
	{
		return this.m_k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridView A_0)
	{
		this.m_k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridView a2()
	{
		return this.m_l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(DataGridView A_0)
	{
		DataGridViewColumnEventHandler value = a;
		EventHandler value2 = o;
		DataGridViewCellEventHandler value3 = a;
		EventHandler value4 = n;
		DataGridViewCellMouseEventHandler value5 = a;
		DataGridViewSortCompareEventHandler value6 = a;
		DataGridView dataGridView = this.m_l;
		if (dataGridView != null)
		{
			dataGridView.ColumnDisplayIndexChanged -= value;
			dataGridView.CurrentCellChanged -= value2;
			dataGridView.CellValueChanged -= value3;
			dataGridView.CurrentCellDirtyStateChanged -= value4;
			dataGridView.CellMouseUp -= value5;
			dataGridView.SortCompare -= value6;
		}
		this.m_l = A_0;
		dataGridView = this.m_l;
		if (dataGridView != null)
		{
			dataGridView.ColumnDisplayIndexChanged += value;
			dataGridView.CurrentCellChanged += value2;
			dataGridView.CellValueChanged += value3;
			dataGridView.CurrentCellDirtyStateChanged += value4;
			dataGridView.CellMouseUp += value5;
			dataGridView.SortCompare += value6;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button a3()
	{
		return this.m_m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(Button A_0)
	{
		EventHandler value = k;
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
	internal virtual GroupBox a4()
	{
		return this.m_n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(GroupBox A_0)
	{
		this.m_n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button a5()
	{
		return this.m_o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(Button A_0)
	{
		EventHandler value = l;
		Button button = this.m_o;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_o = A_0;
		button = this.m_o;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button a6()
	{
		return this.m_p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(Button A_0)
	{
		EventHandler value = q;
		Button button = this.m_p;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_p = A_0;
		button = this.m_p;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Button a7()
	{
		return this.m_q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(Button A_0)
	{
		EventHandler value = m;
		Button button = this.m_q;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_q = A_0;
		button = this.m_q;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual fl a8()
	{
		return this.m_r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(fl A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual fl a9()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(fl A_0)
	{
		this.m_s = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual fl ba()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(fl A_0)
	{
		this.m_t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox bb()
	{
		return this.m_u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(PictureBox A_0)
	{
		this.m_u = A_0;
	}

	public f3()
	{
		base.Load += r;
		this.m_av = null;
		this.m_aw = null;
		this.m_ax = null;
		this.m_ay = null;
		this.m_az = null;
		this.m_a0 = RuntimeHelpers.GetObjectValue(new object());
		this.m_a1 = null;
		this.m_a9 = -1;
		this.m_bi = false;
		this.m_bj = false;
		this.m_bk = false;
		this.m_bl = false;
		this.m_bu = 0L;
		a(new r.d());
		this.m_bx = new Collection<hc>();
		this.m_b1 = new List<ToolStripMenuItem>();
		this.m_b3 = RuntimeHelpers.GetObjectValue(new object());
		cy = false;
		cz = "MostRecentResGridParamOrder";
		c0 = ".fibhc";
		ai();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual System.Windows.Forms.Timer bc()
	{
		return this.m_v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(System.Windows.Forms.Timer A_0)
	{
		EventHandler value = p;
		System.Windows.Forms.Timer timer = this.m_v;
		if (timer != null)
		{
			timer.Tick -= value;
		}
		this.m_v = A_0;
		timer = this.m_v;
		if (timer != null)
		{
			timer.Tick += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn bd()
	{
		return this.m_w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(DataGridViewTextBoxColumn A_0)
	{
		this.m_w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn be()
	{
		return this.m_x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(DataGridViewTextBoxColumn A_0)
	{
		this.m_x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TabControl bf()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(TabControl A_0)
	{
		EventHandler value = j;
		TabControl tabControl = this.m_y;
		if (tabControl != null)
		{
			tabControl.SelectedIndexChanged -= value;
		}
		this.m_y = A_0;
		tabControl = this.m_y;
		if (tabControl != null)
		{
			tabControl.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual fl bg()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(fl A_0)
	{
		this.m_z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox bh()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ComboBox A_0)
	{
		EventHandler value = h;
		ComboBox comboBox = this.m_aa;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged -= value;
		}
		this.m_aa = A_0;
		comboBox = this.m_aa;
		if (comboBox != null)
		{
			comboBox.SelectedIndexChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ContextMenuStrip bi()
	{
		return this.m_ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ContextMenuStrip A_0)
	{
		this.m_ab = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem bj()
	{
		return this.m_ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ToolStripMenuItem A_0)
	{
		EventHandler value = b;
		ToolStripMenuItem toolStripMenuItem = this.m_ac;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_ac = A_0;
		toolStripMenuItem = this.m_ac;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem bk()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ToolStripMenuItem A_0)
	{
		EventHandler value = b;
		ToolStripMenuItem toolStripMenuItem = this.m_ad;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_ad = A_0;
		toolStripMenuItem = this.m_ad;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem bl()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void c(ToolStripMenuItem A_0)
	{
		EventHandler value = e;
		ToolStripMenuItem toolStripMenuItem = this.m_ae;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_ae = A_0;
		toolStripMenuItem = this.m_ae;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem bm()
	{
		return this.m_af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(ToolStripMenuItem A_0)
	{
		EventHandler value = d;
		ToolStripMenuItem toolStripMenuItem = this.m_af;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_af = A_0;
		toolStripMenuItem = this.m_af;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual DataGridViewTextBoxColumn bn()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void d(DataGridViewTextBoxColumn A_0)
	{
		this.m_ag = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem bo()
	{
		return this.m_ah;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void e(ToolStripMenuItem A_0)
	{
		EventHandler value = c;
		ToolStripMenuItem toolStripMenuItem = this.m_ah;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_ah = A_0;
		toolStripMenuItem = this.m_ah;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ToolStripMenuItem bp()
	{
		return this.m_ai;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void f(ToolStripMenuItem A_0)
	{
		EventHandler value = a;
		ToolStripMenuItem toolStripMenuItem = this.m_ai;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click -= value;
		}
		this.m_ai = A_0;
		toolStripMenuItem = this.m_ai;
		if (toolStripMenuItem != null)
		{
			toolStripMenuItem.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual r.d bq()
	{
		return this.m_bw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(r.d A_0)
	{
		r.d.b a_ = a;
		this.m_bw?.e(a_);
		this.m_bw = A_0;
		this.m_bw?.d(a_);
	}

	public f3(ref fz A_0, f1 A_1, Collection<gn> A_2, ew.a A_3, gh A_4, gq A_5, bool A_6, je A_7, gg.c A_8)
		: this()
	{
		bd().Tag = global::cc.q.b;
		ao = A_6;
		al = A_0;
		am = A_1;
		this.m_bg = A_7;
		this.m_b0 = A_8;
		bm().Visible = !A_1.u2() || A_1.u3();
		cu = new d1();
		cu.e((d1.c)b);
		cv = new d1();
		cv.e((d1.b)a);
		if (!A_6)
		{
			a6().Text = "Close Tab";
		}
		fl obj = a9();
		obj.o(al);
		obj.o(A_2[1]);
		obj.o(A_5);
		obj.gn = true;
		_ = null;
		fl fl2 = a8();
		fl2.o(al);
		fl2.o(A_2[0]);
		this.m_bi = fl2.gi().at();
		fl2.gi().am(s);
		fl2.o(A_5);
		fl2.ek = true;
		fl2 = null;
		fl obj2 = bg();
		obj2.o(al);
		obj2.o(A_2[2]);
		obj2.o(A_5);
		obj2.ek = true;
		_ = null;
		fl obj3 = ba();
		obj3.o(al);
		obj3.o(A_2[3]);
		obj3.o(A_5);
		obj3.gi().am(s);
		_ = null;
		cm = new a();
		cn = new gk();
		ad();
		co = new b();
		ac();
		i5.a(A_3, bb());
		A_4.b(f);
		db.b((db.a)b);
		if (A_6)
		{
			c6.b(q);
		}
		b();
		foreach (ToolStripMenuItem item in bi().Items)
		{
			this.m_b1.Add(item);
		}
		this.m_bz = global::cc.cg(6, A_1: false, null, A_3: false);
	}

	[SpecialName]
	public bool br()
	{
		return an;
	}

	[SpecialName]
	public void a(bool A_0)
	{
		an = A_0;
		k();
		if (this.m_aw.Count > 0)
		{
			return;
		}
		Collection<gu.a> A_1 = null;
		if (am.m2(ref A_1) == global::ce.ErrPublic.None && A_1 != null && A_1.Count > 0)
		{
			Guid a_ = A_1[0].a;
			hg hg2 = am.wq(a_);
			if (!hg2.b5() && hg2.bz((eo.a)null))
			{
				c(A_0: true);
				b(A_0: false);
			}
			else if (hg2.by((eo.a)null))
			{
				c(A_0: false);
				b(A_0: true);
			}
			else
			{
				c(A_0: false);
				b(A_0: false);
			}
		}
	}

	private void r(object A_0, EventArgs A_1)
	{
		this.m_be = null;
		this.m_bo = new Collection<string>();
		this.m_br = new Collection<string>();
		this.m_bq = Guid.NewGuid().ToString();
		w();
		Label label = ay();
		string A_2 = "SelectChannel";
		label.Text = hu.a(ref A_2);
		DataGridViewColumn dataGridViewColumn = a1().Columns[0];
		A_2 = "Stats";
		dataGridViewColumn.HeaderText = hu.a(ref A_2);
		DataGridViewColumn dataGridViewColumn2 = a2().Columns[0];
		A_2 = "MeasNum";
		dataGridViewColumn2.HeaderText = hu.a(ref A_2);
		try
		{
			if (ao)
			{
				GC.Collect();
				GC.WaitForPendingFinalizers();
				try
				{
					b4();
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception a_ = ex2;
					al.c(fz.b.b, "Exception caught in FIControlPanelHistory.FIControlPanelHistory_Load - Error attempting to read complete history file. File not read.", a_);
					w();
					ProjectData.ClearProjectError();
				}
			}
			e();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception a_2 = ex3;
			al.c(fz.b.b, "Exception caught in FIControlPanelHistory.FIControlPanelHistory_Load", a_2);
			w();
			ProjectData.ClearProjectError();
		}
		bc().Start();
		this.m_bv = true;
	}

	[SpecialName]
	public bool bs()
	{
		return ak;
	}

	[SpecialName]
	public void b(bool A_0)
	{
		if (ak != A_0)
		{
			ak = A_0;
			bg().Visible = ak;
			bh().BringToFront();
			ah();
		}
	}

	[SpecialName]
	public bool bt()
	{
		return aj;
	}

	[SpecialName]
	public void c(bool A_0)
	{
		if (aj != A_0)
		{
			aj = A_0;
			a9().Visible = aj;
			ah();
		}
	}

	public static void a(string A_0, int A_1)
	{
		try
		{
			string[] array = i3.b(A_0);
			int num = 0;
			while (i3.a(A_0, A_1: false) > (double)A_1 && num <= array.GetUpperBound(0))
			{
				File.Delete(array[num]);
				num = checked(num + 1);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	private void ah()
	{
		if (aj || ak)
		{
			a8().Height = ag() / 2;
		}
		else
		{
			a8().Height = ag();
		}
	}

	private void b(int A_0)
	{
		Collection<hc> collection = this.m_av[A_0];
		bool A_2 = default(bool);
		bool A_3 = default(bool);
		while (collection.Count > 0)
		{
			hc a_ = collection[0];
			bool A_1 = false;
			a(a_, ref A_2, A_2: true, A_3: true, ref A_1, ref A_3);
			if (A_3)
			{
				collection.RemoveAt(0);
			}
		}
		this.m_a8 = true;
		this.m_a7 = new int[0];
		if (A_2)
		{
			ab();
		}
	}

	public void a(ref f5 A_0)
	{
		if (this.m_bb)
		{
			A_0.a(1);
			A_0.a(0, ba());
		}
		else
		{
			A_0.a(0, a8());
			if (bs())
			{
				A_0.a(2);
				A_0.a(1, bg());
			}
			else if (bt())
			{
				A_0.a(2);
				A_0.a(1, a9());
			}
			else
			{
				A_0.a(1);
			}
		}
		Bitmap bitmap = null;
		if (am.uk())
		{
			bitmap = i5.a();
		}
		if (bitmap == null)
		{
			A_0.a(i5.a(ew.a.a, A_1: true));
		}
		else
		{
			A_0.a(bitmap);
		}
		f5.c c10 = new f5.c();
		f5.c c11 = c10;
		if (az().Enabled)
		{
			c11.a = az().SelectedItem.ToString();
		}
		else
		{
			c11.a = az().Items[1].ToString();
		}
		if (this.m_bb)
		{
			c11.d = true;
			c11.b = aw().SelectedItem.ToString();
		}
		else
		{
			c11.d = false;
			f5.c obj = c11;
			hc obj2 = this.m_be;
			byte a_ = global::e.a().DisplaySignificantDigits;
			bool a_2 = Conversions.ToBoolean(global::e.a().GraphMeasYLabelPercent[0]);
			cb a_3 = a(this.m_be);
			bool A_1 = false;
			string A_2 = null;
			Color A_3 = default(Color);
			BorderStyle A_4 = BorderStyle.None;
			string A_5 = null;
			Color A_6 = default(Color);
			Color A_7 = default(Color);
			Color A_8 = default(Color);
			string A_9 = null;
			string A_10 = null;
			string A_11 = null;
			obj.c = obj2.cf(A_0: false, a_, a_2, a_3, ref A_1, ref A_2, ref A_3, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8, ref A_9, ref A_10, ref A_11);
		}
		Control control = a1();
		Graphics graphics = control.CreateGraphics();
		Bitmap bitmap2 = new Bitmap(control.ClientSize.Width, control.ClientSize.Height, graphics);
		Rectangle targetBounds = new Rectangle(0, 0, control.ClientSize.Width, control.ClientSize.Height);
		i6.a(control, 0, 0);
		control.DrawToBitmap(bitmap2, targetBounds);
		c11.e = bitmap2;
		graphics.Dispose();
		control = a2();
		graphics = control.CreateGraphics();
		bitmap2 = new Bitmap(control.ClientSize.Width, control.ClientSize.Height, graphics);
		targetBounds = new Rectangle(0, 0, control.ClientSize.Width, control.ClientSize.Height);
		i6.a(control, 0, 0);
		control.DrawToBitmap(bitmap2, targetBounds);
		c11.f = bitmap2;
		graphics.Dispose();
		c11 = null;
		A_0.a(c10);
	}

	private int ag()
	{
		return checked(bf().Height - 48 - (at().Top + at().Height) - 6);
	}

	public void a(int A_0, int A_1)
	{
		checked
		{
			try
			{
				ax().SuspendLayout();
				bf().SuspendLayout();
				bb().SuspendLayout();
				_ = A_0 - base.Width;
				_ = A_1 - base.Height;
				int num = 9 + a7().Width + 29 + a6().Width + 29 + a5().Width + 9;
				base.Width = A_0;
				base.Height = A_1;
				int num2 = base.Width - 6;
				int num3 = base.Height - 6;
				int num4 = (int)Math.Round((double)num2 / 2.0 - 6.0);
				ax().Left = 3;
				ax().Top = 3;
				if (num > num4)
				{
					ax().Width = num;
				}
				else
				{
					ax().Width = num4;
				}
				ax().Height = num3 - 3;
				az().Left = ax().Width - az().Width - 6;
				az().Top = 12;
				ay().Left = az().Left - ay().Width;
				ay().Top = az().Top + unchecked(az().Height / 2) - unchecked(ay().Height / 2);
				a1().Left = ax().Left + 3;
				a1().Top = az().Top + az().Height + 3;
				a1().Width = ax().Width - 12;
				a4().Left = (int)Math.Round((double)(ax().Width - a4().Width) / 2.0);
				a4().Top = ax().Height - a4().Height - a3().Height - 9;
				a3().Left = a4().Left + 3;
				a3().Top = a4().Top + a4().Height + 3;
				a0().Left = a3().Left + a4().Width - a0().Width - 6;
				a0().Top = a3().Top;
				a2().Left = a1().Left;
				a2().Top = a1().Top + a1().Height + 3;
				a2().Width = a1().Width;
				a2().Height = a4().Top - a2().Top - 6;
				bb().Left = base.ClientSize.Width - bb().Width - 9;
				bb().Top = 9;
				bf().Left = ax().Left + ax().Width + 6;
				bf().Top = bb().Top + bb().Height;
				bf().Width = num2 - ax().Width - 9;
				bf().Height = base.Height - bf().Top - 24 - 3;
				if (bf().Width < 437)
				{
					at().Width = bf().Width - 6 - 20;
				}
				else
				{
					at().Width = 431;
				}
				at().Left = (int)Math.Round((double)(bf().Width - at().Width) / 2.0);
				at().Top = 6;
				af();
			}
			finally
			{
				ax().ResumeLayout();
				bf().ResumeLayout();
				bb().ResumeLayout();
			}
		}
	}

	private void af()
	{
		int num = bf().Width;
		int num2 = ag();
		int num3 = 1;
		if (bt() | bs())
		{
			num3 = 2;
		}
		checked
		{
			if (num3 == 1)
			{
				a8().Left = 3;
				a8().Top = at().Top + at().Height + 6;
				a8().Width = num - 20;
				a8().Height = num2;
			}
			else
			{
				a8().Left = 3;
				a8().Top = at().Top + at().Height + 6;
				a8().Width = num - 20;
				a8().Height = (int)Math.Round((double)num2 / 2.0 - 6.0);
				a9().Left = 3;
				a9().Top = a8().Top + a8().Height + 6;
				a9().Width = a8().Width;
				a9().Height = (int)Math.Round((double)num2 / 2.0 - 6.0);
				bg().Left = a9().Left;
				bg().Top = a9().Top;
				bg().Width = a9().Width - (a9().fw().Width - a8().fw().Width);
				bg().Height = a9().Height;
			}
			ae();
			ba().Left = 3;
			ba().Top = at().Top + at().Height + 6;
			ba().Width = num - 20;
			ba().Height = num2;
		}
	}

	private void ae()
	{
		Rectangle rectangle = bg().fw();
		checked
		{
			bh().Left = bg().Left + rectangle.Right - bh().Width;
			bh().Top = bg().Top + rectangle.Top;
		}
	}

	public void bu()
	{
		if (aj)
		{
			a9().g7();
		}
	}

	private void f(hc A_0)
	{
		this.m_bl = true;
		bool flag = false;
		if (this.m_aw != null)
		{
			foreach (hc item in this.m_aw)
			{
				if (item == A_0)
				{
					flag = true;
					break;
				}
			}
		}
		if (flag)
		{
			d(A_0);
		}
	}

	public void a(d1 A_0)
	{
		cw = A_0;
	}

	public void a(Collection<gn> A_0)
	{
		a9().o(A_0[1]);
		a8().o(A_0[0]);
		ba().o(A_0[3]);
		bg().o(A_0[2]);
	}

	public void bv()
	{
		a9().o((fu)null);
		a8().gi().an(s);
		a8().o((fu)null);
		ba().gi().an(s);
		ba().o((fu)null);
		bg().o((fu)null);
		db.a((db.a)b);
		if (ao)
		{
			c6.a(q);
		}
	}

	public void b(r.d A_0)
	{
		if (A_0 != null)
		{
			A_0.d((r.d.b)b);
		}
		else
		{
			al.c(fz.b.b, "Error in FIControlPanelMeasModule.AddSpectrumCalculatedHandler(): spectrumCalculatedStatus is Nothing. ");
		}
	}

	private void a(ref ji.a A_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new e(a), A_0);
				return;
			}
			ji.a obj = A_0;
			ref fz a_ = ref al;
			string A_1 = "AutoSaveConfirmPrompt";
			string a_2 = hu.a(ref A_1);
			A_1 = "Yes";
			string a_3 = hu.a(ref A_1);
			A_1 = "No";
			obj.a = fe.b(ref a_, a_2, "AutoSaveConfirmTitle", a_3, hu.a(ref A_1), i6.a(this));
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_4 = ex2;
			al.c(fz.b.b, "Error in FIControlPanelHistory.AskUserIfResultsShouldBeSaved", a_4);
			ProjectData.ClearProjectError();
		}
	}

	private void a(hc A_0, r.d.a A_1)
	{
		StreamWriter streamWriter = null;
		string text = string.Empty;
		checked
		{
			bool flag = default(bool);
			try
			{
				if (!A_0.db() || !global::e.a().AutoAppendResults)
				{
					return;
				}
				flag = true;
				if (global::e.a().SaveOncePerSpectrum && A_0.cn().bn())
				{
					flag = false;
				}
				if (flag && global::e.a().ConfirmBeforeSaving && A_1.a8() == global::r.d.a.b.a)
				{
					ji.a A_2 = new ji.a();
					A_2.a = flag;
					a(ref A_2);
					flag = A_2.a;
					A_0.cn().ag(A_0: true);
				}
				if (!flag)
				{
					return;
				}
				object obj = this.m_b3;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					string empty = string.Empty;
					text = global::e.a().AutoAppendResultsPath;
					string text2 = Path.GetDirectoryName(text) + "\\" + Path.GetFileNameWithoutExtension(text) + "~FILH.csv";
					string text3 = Conversions.ToString(i3.h(text));
					string text4 = string.Empty;
					A_0.cn().ag(A_0: true);
					empty = "Meas #" + text3 + a(A_0.er(), text3, A_0).Replace("Å", "A").Replace("µ", "u");
					try
					{
						if (a(text2, empty))
						{
							streamWriter = new StreamWriter(File.Open(text2, FileMode.Create, FileAccess.Write), Encoding.UTF8);
							streamWriter.WriteLine(empty);
							streamWriter.Close();
							streamWriter = new StreamWriter(File.Open(text, FileMode.Append, FileAccess.Write), Encoding.UTF8);
							streamWriter.WriteLine(empty);
						}
						string[] array = a(A_0, this.m_bu);
						int num = array.Length - 2;
						int num2 = num;
						for (int num3 = 0; num3 <= num2; num3++)
						{
							string text5 = array[num3];
							if (text5.Contains(text3) || text5.Contains("\""))
							{
								text5 = "\"" + text5.Replace("\"", "\"\"") + "\"";
							}
							text4 = ((num3 != num) ? (text4 + text5 + text3) : (text4 + text5));
						}
						if (streamWriter == null)
						{
							streamWriter = new StreamWriter(File.Open(text, FileMode.Append, FileAccess.Write), Encoding.UTF8);
						}
						streamWriter.WriteLine(text4);
					}
					finally
					{
						streamWriter?.Close();
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				al.c(fz.b.b, "Error in FIControlPanelHistory.SaveDataToFileIfNeeded. Most common cause is improper filename. saveTheData=" + flag + ", autoSaveFilePath=\"" + text + "\"", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void b(r.d.a A_0)
	{
		checked
		{
			try
			{
				r.i.b b10 = (r.i.b)A_0;
				if (b10.ac == null)
				{
					if (b10.ab != null)
					{
						hc hc2 = b10.ab;
						hc a_ = hc2;
						bool A_1 = false;
						a(a_, A_1: true, A_2: true, A_3: true, ref A_1);
						a(hc2, A_0);
						return;
					}
					throw new ApplicationException("There is no MeasResult or CompositeMeasResult to add.");
				}
				cb cb2 = b10.ac;
				he A_2 = new he(string.Empty, string.Empty, string.Empty);
				cb2.k().s(ref A_2);
				cb2.g(A_2);
				int num = cb2.g() - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					hc hc2 = cb2.h()[num2];
					hc a_2 = hc2;
					bool A_1 = false;
					a(a_2, A_1: true, A_2: true, A_3: true, ref A_1);
					cb2.k().ad().Add(hc2.cy());
					a(hc2, A_0);
				}
				this.m_ay.Add(cb2);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				al.c(fz.b.b, "Exception Thrown", a_3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void e(hc A_0)
	{
		d7.a(A_0, am, a8(), a9(), bg(), ref this.m_bf);
	}

	private void ad()
	{
		d7.a(am, a8(), a9(), bg());
	}

	private void ac()
	{
		Collection<gu.a> A_ = null;
		if (am.m2(ref A_) == global::ce.ErrPublic.None)
		{
			gp.c(ba(), "", A_2: true);
		}
	}

	private void d(hc A_0)
	{
		float num = jh.a(this.m_a3, A_0.cn().cb());
		A_0.es()[4] = num.ToString("0.00");
	}

	private void ab()
	{
		foreach (hc item in this.m_aw)
		{
			d(item);
		}
	}

	public void a(hc A_0, bool A_1, bool A_2, bool A_3, ref bool A_4, bool A_5 = false)
	{
		bool flag = false;
		checked
		{
			try
			{
				if (A_0 == null || !A_0.db())
				{
					return;
				}
				if (Monitor.TryEnter(RuntimeHelpers.GetObjectValue(this.m_a0), 2000))
				{
					flag = true;
					this.m_bh = true;
					if (A_5)
					{
						foreach (hc item2 in this.m_ax)
						{
							if (A_0 == item2)
							{
								return;
							}
						}
					}
					bool flag2 = default(bool);
					int index = default(int);
					if (A_0.d5())
					{
						for (int num = this.m_aw.Count - 1; num >= 0; num += -1)
						{
							if (this.m_aw[num].cf(A_0) && this.m_aw[num].cn() == A_0.cn())
							{
								flag2 = true;
								index = num;
								break;
							}
						}
					}
					A_0.cg(A_0: false);
					bool A_6 = default(bool);
					if (this.m_aw.Count == 0)
					{
						this.m_a2 = A_0.cn();
						this.m_a3 = this.m_a2.cb();
					}
					else if (!flag2 && DateTime.Compare(A_0.cn().cb(), this.m_a2.cb()) < 0)
					{
						this.m_a2 = A_0.cn();
						if (DateTime.Compare(this.m_a3, this.m_a2.cb()) > 0)
						{
							this.m_a3 = this.m_a2.cb();
							A_6 = true;
						}
					}
					if (flag2)
					{
						A_0.cf(unchecked((a4.a)global::e.a().ShowSpectrumCoordOption), global::e.a().AlwayShowSpectrumCoordXYZ);
						d(A_0);
						hc item = this.m_aw[index];
						this.m_aw.RemoveAt(index);
						this.m_aw.Insert(index, A_0);
						int index2 = this.m_bo.IndexOf(A_0.c1()) - 1;
						index = this.m_av[index2].IndexOf(item);
						this.m_av[index2].RemoveAt(index);
						this.m_av[index2].Insert(index, A_0);
					}
					else
					{
						if (!this.m_bj && this.m_az.Count > 0 && h4.f(this.m_az[this.m_az.Count - 1].ca(), A_0.cy().ca()))
						{
							this.m_bk = true;
						}
						A_0.cg(b(A_0.cy()));
						if (A_0.cb != null)
						{
							A_0.cb = b(A_0.cb);
						}
						A_0.cf(unchecked((a4.a)global::e.a().ShowSpectrumCoordOption), global::e.a().AlwayShowSpectrumCoordXYZ);
						int[] a_ = A_0.er();
						if (this.m_aw.Count >= 1000)
						{
							hr hr2 = this.m_aw[0].cn();
							bool num2 = hr2 != null && hr2.bp() != null;
							hc a_2 = this.m_aw[0];
							bool A_7 = false;
							a(a_2, ref A_6, A_2, A_3, ref A_4, ref A_7);
							if (num2)
							{
								GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
							}
						}
						a(a_);
						this.m_bu++;
						this.m_aw.Add(A_0);
						if (this.m_a2 == null)
						{
							this.m_a2 = A_0.cn();
							this.m_a3 = this.m_a2.cb();
						}
						d(A_0);
						if (A_1 && (!A_2 || A_4))
						{
							this.m_b2 = A_0;
						}
						string text = ((Operators.CompareString(A_0.d8(), string.Empty, TextCompare: false) == 0) ? A_0.d9() : (A_0.d8() + " - " + A_0.d9()));
						int num3 = this.m_bo.IndexOf(A_0.c1());
						if (num3 < 0)
						{
							this.m_bo.Add(A_0.c1());
							this.m_br.Add(text);
							this.m_av.Add(new Collection<hc>());
							num3 = this.m_av.Count - 1;
							this.m_bt = true;
							if (Operators.CompareString(this.m_bp, A_0.c1(), TextCompare: false) == 0)
							{
								this.m_ax = this.m_av[num3];
							}
						}
						else
						{
							if (Operators.CompareString(this.m_br[num3], text, TextCompare: false) != 0)
							{
								this.m_br[num3] = text;
								this.m_bt = true;
							}
							num3--;
						}
						this.m_av[num3].Add(A_0);
						cm.b(this.m_aw.Count);
					}
					if (A_6)
					{
						ab();
						this.m_bn = true;
					}
				}
				else
				{
					al.c(fz.b.b, "Unable to acquire lock on the Data Collections.");
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				al.c(fz.b.b, "Unable to add measResult object to collection. Error is: ", a_3);
				ProjectData.ClearProjectError();
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(RuntimeHelpers.GetObjectValue(this.m_a0));
				}
			}
		}
	}

	private hg b(hg A_0)
	{
		bool flag = false;
		string right = A_0.cl();
		checked
		{
			int num = this.m_az.Count - 1;
			int num2;
			for (num2 = 0; num2 <= num; num2++)
			{
				if (Operators.CompareString(this.m_az[num2].cl(), right, TextCompare: false) == 0)
				{
					flag = true;
					break;
				}
			}
			bool flag2 = default(bool);
			if (flag)
			{
				flag2 = hg.bu(A_0.ed().cr, this.m_az[num2].ed().cr);
			}
			if (flag && flag2)
			{
				return this.m_az[num2];
			}
			A_0.ca(A_0: false);
			this.m_az.Add(A_0);
			return A_0;
		}
	}

	private void aa()
	{
		if (this.m_aw.Count > 0)
		{
			this.m_a2 = this.m_aw[0].cn();
		}
		checked
		{
			int num = this.m_aw.Count - 1;
			for (int num2 = 1; num2 <= num; num2++)
			{
				hc hc2 = this.m_aw[num2];
				if (DateTime.Compare(hc2.cn().cb(), this.m_a2.cb()) < 0)
				{
					this.m_a2 = hc2.cn();
				}
				hc2 = null;
			}
			if (DateTime.Compare(this.m_a3, DateTime.MinValue) == 0 && this.m_a2 != null)
			{
				this.m_a3 = this.m_a2.cb();
			}
		}
	}

	private void a(hc A_0, ref bool A_1, bool A_2, bool A_3, ref bool A_4, ref bool A_5)
	{
		A_5 = false;
		cb cb2 = a(A_0);
		checked
		{
			Collection<hc> collection;
			if (cb2 != null)
			{
				_ = cb2.g() - 1;
				this.m_ay.Remove(cb2);
				collection = cb2.h();
			}
			else
			{
				collection = new Collection<hc>();
				collection.Add(A_0);
			}
			this.m_bt = true;
			foreach (hc item in collection)
			{
				int num = this.m_bo.IndexOf(item.c1()) - 1;
				if (num < -1)
				{
					A_5 = true;
					return;
				}
				if (this.m_a4 > 0 && (Operators.CompareString(this.m_bp, this.m_bq, TextCompare: false) == 0 || Operators.CompareString(item.c1(), this.m_bp, TextCompare: false) == 0))
				{
					this.m_a4--;
					this.m_bn = true;
					this.m_a5 = true;
				}
				if (A_2 && ao && global::e.a().HistoryArchiveAutomatically)
				{
					if (this.m_b2 == null)
					{
						string a_ = i3.i(global::e.a().HistoryAutoSavePath + "\\" + DateAndTime.Now.Year + "-" + DateAndTime.Now.Month + "-" + DateAndTime.Now.Day + ".fibhi");
						a(a_, A_3);
						A_4 = true;
					}
					else if (this.m_b2 == item)
					{
						this.m_b2 = null;
					}
				}
				if (this.m_aw.Count > 0)
				{
					this.m_aw.Remove(item);
					this.m_av[num].Remove(item);
					if (this.m_av[num].Count == 0)
					{
						this.m_av.RemoveAt(num);
						this.m_bo.RemoveAt(num + 1);
						this.m_br.RemoveAt(num + 1);
					}
				}
				if (item.cn() == this.m_a2)
				{
					this.m_a2 = null;
				}
			}
			if (this.m_aw.Count > 0)
			{
				foreach (hc item2 in collection)
				{
					c(item2);
				}
				if (this.m_a2 == null)
				{
					aa();
					A_1 = true;
				}
			}
			else
			{
				this.m_az.Clear();
			}
		}
	}

	private void c(hc A_0)
	{
		a(A_0.cy());
		if (A_0.cb != null)
		{
			a(A_0.cb);
		}
	}

	private void a(hg A_0)
	{
		bool flag = false;
		foreach (hc item in this.m_aw)
		{
			if (item.cy() == A_0)
			{
				flag = true;
				break;
			}
			if (item.cb == A_0)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			this.m_az.Remove(A_0);
		}
	}

	private void z()
	{
		bool flag = this.m_aw.Count > 0 && (az().Items.Count > 2 || am.t0() > 1);
		if (!flag && this.m_bo.Count > 1 && Operators.CompareString(this.m_bo[1], am.tj()[0].ToString(), TextCompare: false) != 0)
		{
			flag = true;
		}
		az().Enabled = flag;
		ay().Enabled = az().Enabled;
	}

	private void a(int[] A_0)
	{
		if (!global::cc.cf(this.m_a7, A_0))
		{
			this.m_a7 = global::cc.cg((int[])this.m_a7.Clone(), A_0);
			this.m_a8 = true;
		}
	}

	private void b(r.d.a.b A_0)
	{
		if (!this.m_bv || (A_0 == global::r.d.a.b.a && global::e.a().HistoryConfirmBeforeDelete && ao && !a()))
		{
			return;
		}
		object obj = this.m_a0;
		ObjectFlowControl.CheckForSyncLockOnValueType(obj);
		bool lockTaken = false;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			y();
			w();
			this.m_be = null;
			this.m_b2 = null;
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	private void a(ref long A_0)
	{
		bool flag = false;
		try
		{
			if (Monitor.TryEnter(RuntimeHelpers.GetObjectValue(this.m_a0), 300))
			{
				flag = true;
				if (this.m_a4 > 0)
				{
					hc a_ = (hc)a2().SelectedRows[0].Tag;
					b(a_);
				}
				A_0 = this.m_aw.Count;
			}
			else
			{
				al.c(fz.b.b, "Unable to acquire lock on the Meas and/or Recipe Collection.");
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_2 = ex2;
			al.c(fz.b.b, "Error in RedisplayHistoryAndReturnMeasNumber. Error is: ", a_2);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(RuntimeHelpers.GetObjectValue(this.m_a0));
			}
		}
	}

	private void q(object A_0, EventArgs A_1)
	{
		try
		{
			if (ao)
			{
				b(global::r.d.a.b.a);
				return;
			}
			d1 obj = cw;
			long A_2 = Convert.ToInt64(value: false);
			obj.e(ref A_2);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			al.c(fz.b.b, "Error in ButtonHistoryClear_Click. Error is: ", a_);
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	public d1 bw()
	{
		return cu;
	}

	[SpecialName]
	public d1 bx()
	{
		return cv;
	}

	private void y()
	{
		a1().Rows.Clear();
		checked
		{
			for (int num = a1().Columns.Count - 1; num >= 1; num += -1)
			{
				a1().Columns.RemoveAt(num);
			}
			a1().Refresh();
			a2().Rows.Clear();
			if (am.uj())
			{
				this.m_b0.b();
			}
			for (int num = a2().Columns.Count - 1; num >= 0; num += -1)
			{
				DataGridViewColumn dataGridViewColumn = a2().Columns[num];
				if (dataGridViewColumn != bd() && dataGridViewColumn != be())
				{
					a2().Columns.RemoveAt(num);
				}
			}
			cq = null;
			cr = null;
			cs = null;
			ct = null;
			a2().Refresh();
		}
	}

	private void x()
	{
		if (am.uj() && this.m_aw != null)
		{
			object obj = this.m_a0;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				foreach (hc item in this.m_aw)
				{
					co.c(item);
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
				}
			}
		}
		this.m_bu = 0L;
		this.m_aw = new Collection<hc>();
		this.m_av = new Collection<Collection<hc>>();
		this.m_az = new Collection<hg>();
		this.m_ay = new Collection<cb>();
		b5();
		this.m_a7 = new int[0];
		this.m_a2 = null;
		this.m_a3 = DateTime.MinValue;
		this.m_b2 = null;
	}

	private void w()
	{
		x();
		u();
		m();
	}

	public void by()
	{
		bool flag = false;
		try
		{
			if (Monitor.TryEnter(RuntimeHelpers.GetObjectValue(this.m_a0), 300))
			{
				flag = true;
				x();
				this.m_bn = true;
				return;
			}
			throw new Exception("Timeout attempting to clear History.");
		}
		finally
		{
			if (flag)
			{
				Monitor.Exit(RuntimeHelpers.GetObjectValue(this.m_a0));
			}
		}
	}

	private void v()
	{
		this.m_a4 = 0;
		this.m_a5 = false;
		this.m_a8 = true;
		this.m_a6 = new int[0];
		this.m_a1 = new Collection();
		aw().Items.Clear();
		ba().g1();
		this.m_bc = -1;
		this.m_be = null;
	}

	private void u()
	{
		a9().g1();
		bg().g1();
		a8().g1();
		at().Clear();
		v();
	}

	private void p(object A_0, EventArgs A_1)
	{
		try
		{
			bc().Stop();
			t();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			al.c(fz.b.b, "Exception caught in TimerUpdateStats_Tick(). ", a_);
			ProjectData.ClearProjectError();
		}
		finally
		{
			bc().Start();
		}
	}

	public Collection<hc> c(string A_0)
	{
		if (Operators.CompareString(A_0, this.m_bq, TextCompare: false) == 0)
		{
			return this.m_aw;
		}
		int num = checked(this.m_bo.IndexOf(A_0) - 1);
		if (num >= 0)
		{
			return this.m_av[num];
		}
		return null;
	}

	private void t()
	{
		bool flag = false;
		if (!br() || az().DroppedDown)
		{
			return;
		}
		checked
		{
			try
			{
				if (!Monitor.TryEnter(RuntimeHelpers.GetObjectValue(this.m_a0), 300))
				{
					return;
				}
				flag = true;
				if (this.m_bt)
				{
					az().Items.Clear();
					int num = this.m_bo.Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						az().Items.Add(this.m_br[num2]);
					}
					z();
					int num3 = this.m_bo.IndexOf(this.m_bp);
					if (num3 < 0)
					{
						az().SelectedIndex = 0;
					}
					else
					{
						az().SelectedIndex = num3;
					}
					this.m_bt = false;
				}
				if (this.m_bj || this.m_bk || this.m_bl || this.m_bs || this.m_bn)
				{
					y();
					v();
					at().Clear();
					this.m_bj = false;
					this.m_bk = false;
					this.m_a8 = true;
					this.m_bl = false;
					this.m_bn = false;
				}
				int num4 = default(int);
				if (this.m_ax != null)
				{
					num4 = this.m_ax.Count - 1;
				}
				if (this.m_ax != null && this.m_a4 <= num4)
				{
					if (this.m_a8)
					{
						if (this.m_bs)
						{
							this.m_a7 = new int[0];
							this.m_a6 = (int[])this.m_a7.Clone();
							int num5 = num4;
							for (int num6 = 0; num6 <= num5; num6++)
							{
								a(this.m_ax[num6].er());
							}
						}
						a(this.m_a6, this.m_a7, this.m_ax, p(), ref this.m_a9);
						this.m_a8 = false;
						this.m_a6 = (int[])this.m_a7.Clone();
						if (this.m_bb)
						{
							i();
						}
					}
					DataGridViewRowCollection rows = a2().Rows;
					int num7 = this.m_a4;
					int num8 = num4;
					for (int num6 = num7; num6 <= num8; num6++)
					{
						this.m_a4++;
						rows.Add(a(this.m_ax[num6], this.m_a4, this.m_ax));
						rows[rows.Count - 1].Tag = this.m_ax[num6];
					}
					rows = null;
					o();
					a2().ClearSelection();
					a2().Rows[a2().RowCount - 1].Selected = true;
					r();
					b(this.m_ax);
					if (this.m_bb)
					{
						j();
					}
					int num9 = a2().ColumnCount - 1;
					int num10;
					for (num10 = 0; num10 <= num9 && !a2()[num10, this.m_a4 - 1].Visible; num10++)
					{
					}
					a2().CurrentCell = a2()[num10, this.m_a4 - 1];
				}
				else if (this.m_bm)
				{
					o();
				}
				DataGridView dataGridView = a2();
				if (dataGridView.SelectedRows.Count == 0 && dataGridView.Rows.Count > 0)
				{
					dataGridView.Rows[dataGridView.Rows.Count - 1].Selected = true;
				}
				int num11;
				if (dataGridView.SelectedRows.Count == 1)
				{
					num11 = dataGridView.SelectedRows[0].Index;
				}
				else if (dataGridView.SelectedRows.Count > 1 && dataGridView.CurrentRow.Index != -1)
				{
					num11 = ((!dataGridView.Rows[dataGridView.CurrentRow.Index].Selected) ? dataGridView.SelectedRows[dataGridView.SelectedRows.Count - 1].Index : dataGridView.CurrentRow.Index);
				}
				else
				{
					num11 = -1;
					this.m_be = null;
				}
				dataGridView = null;
				hc hc2 = null;
				if (num11 >= 0)
				{
					hc2 = (hc)a2().Rows[num11].Tag;
				}
				if (num11 >= 0 && (this.m_be == null || hc2 != this.m_be || this.m_bs || this.m_bf != unchecked((fh.b)global::e.a().DisplayedSpectrumTransformation)))
				{
					TabPage tabPage = bf().TabPages[0];
					string A_ = "HistorySingleMeasurementTabTextFmt";
					tabPage.Text = string.Format(hu.a(ref A_), (num11 + 1).ToString());
					this.m_be = hc2;
					if (this.m_be != null)
					{
						e(this.m_be);
						c(this.m_be.cu() != null);
						a9().gm = this.m_be.cx();
						b(this.m_be.cy().by(this.m_be.cz()));
						hg.bu(bh(), this.m_be.cy(), this.m_be.cf(), this.m_be.cz());
						ae();
						b(this.m_be);
					}
				}
				else
				{
					string A_ = "HistorySingleMeasurementTabTextFmt";
					string right = string.Format(hu.a(ref A_), 1.ToString());
					if (this.m_be == null)
					{
						u();
					}
					if (this.m_be == null && Operators.CompareString(bf().TabPages[0].Text, right, TextCompare: false) != 0)
					{
						bf().TabPages[0].Text = right;
					}
				}
				if (ba().fg() == 0)
				{
					ac();
				}
				if (bg().fg() == 0 || a8().fg() == 0 || a9().fg() == 0)
				{
					ad();
				}
				af();
			}
			finally
			{
				this.m_bs = false;
				if (flag)
				{
					Monitor.Exit(RuntimeHelpers.GetObjectValue(this.m_a0));
				}
			}
		}
	}

	private void s()
	{
		int index;
		if (this.m_bb && an)
		{
			index = 3;
			a8().gi().ar(ba().gi().at());
		}
		else
		{
			index = 0;
			ba().gi().ar(a8().gi().at());
		}
		bool flag = Conversions.ToBoolean(global::e.a().GraphMeasYLabelPercent[index]);
		this.m_bj = this.m_bj || flag != this.m_bi;
		this.m_bi = flag;
	}

	private void r()
	{
		if (this.m_a5)
		{
			int num = checked(this.m_a4 - 1);
			for (int num2 = 0; num2 <= num; num2 = checked(num2 + 1))
			{
				a2()["Number", num2].Value = a((long)checked(num2 + 1));
			}
			this.m_a5 = false;
		}
	}

	private string a(long A_0)
	{
		string text = "";
		if (A_0 <= 9)
		{
			return "   " + Conversions.ToString(A_0);
		}
		if (this.m_a4 <= 99)
		{
			return "  " + Conversions.ToString(A_0);
		}
		if (this.m_a4 <= 999)
		{
			return " " + Conversions.ToString(A_0);
		}
		return Conversions.ToString(A_0);
	}

	private void b(hc A_0)
	{
		if (A_0 != null)
		{
			at().Clear();
			at().Visible = true;
			RichTextBox richTextBox = at();
			byte a_ = global::e.a().DisplaySignificantDigits;
			bool a_2 = Conversions.ToBoolean(global::e.a().GraphMeasYLabelPercent[0]);
			cb a_3 = a(A_0);
			bool A_1 = false;
			string A_2 = null;
			Color A_3 = default(Color);
			BorderStyle A_4 = BorderStyle.None;
			string A_5 = null;
			Color A_6 = default(Color);
			Color A_7 = default(Color);
			Color A_8 = default(Color);
			string A_9 = null;
			string A_10 = null;
			string A_11 = null;
			richTextBox.Rtf = A_0.cf(A_0: true, a_, a_2, a_3, ref A_1, ref A_2, ref A_3, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8, ref A_9, ref A_10, ref A_11);
		}
	}

	private void b(Collection<hc> A_0)
	{
		checked
		{
			int num = this.m_a7.Length - this.m_a9 + 2;
			string[] array = new string[num + 1];
			string[] array2 = new string[num + 1];
			string[] array3 = new string[num + 1];
			string[] array4 = new string[num + 1];
			string[] array5 = new string[num + 1];
			string[] array6 = new string[num + 1];
			int num2 = 0;
			if (A_0 == null)
			{
				return;
			}
			string A_1 = "Mean";
			array[0] = hu.a(ref A_1);
			A_1 = "Median";
			array2[0] = hu.a(ref A_1);
			A_1 = "StdDev";
			array3[0] = hu.a(ref A_1);
			A_1 = "Min";
			array4[0] = hu.a(ref A_1);
			A_1 = "Max";
			array5[0] = hu.a(ref A_1);
			A_1 = "Range";
			array6[0] = hu.a(ref A_1);
			int num3 = this.m_a7.Length - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				int num5 = this.m_a7[num4];
				if (num5 == 0 || num5 == 10 || num5 > 10)
				{
					switch (num5)
					{
					case 0:
						num2 = num - 1;
						a2().Columns[Conversions.ToString(num5)].Width = a1().Columns[Conversions.ToString(num5)].Width;
						break;
					case 10:
						num2 = num;
						break;
					default:
						num2 = num4 - this.m_a9 + 1;
						break;
					}
					a(A_0, num5, num2, array, array2, array3, array4, array5, array6);
				}
			}
			a1().Rows.Clear();
			a1().Refresh();
			a1().Rows.Add(array);
			a1().Rows.Add(array2);
			a1().Rows.Add(array3);
			a1().Rows.Add(array4);
			a1().Rows.Add(array5);
			a1().Rows.Add(array6);
		}
	}

	private void a(Collection<hc> A_0, int A_1, int A_2, string[] A_3, string[] A_4, string[] A_5, string[] A_6, string[] A_7, string[] A_8)
	{
		short a_;
		short num2;
		float[] array2;
		h4 h10;
		float num6;
		float num7;
		float num8;
		checked
		{
			_ = this.m_a7.Length - this.m_a9 + 1;
			a_ = global::e.a().DisplaySignificantDigits;
			if (!this.m_a1.Contains(Conversions.ToString(A_1)))
			{
				return;
			}
			c[] array = (c[])this.m_a1[Conversions.ToString(A_1)];
			int num = Array.IndexOf(array, null);
			array2 = new float[num - 1 + 1];
			num2 = 0;
			int num3 = 0;
			int num4 = num - 1;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				if (A_1 <= 66 || Conversions.ToBoolean(A_0[num5].es()[7]))
				{
					array2[num3] = array[num5].e();
					num2 = (short)unchecked(num2 + 1);
					num3++;
				}
			}
			if (num2 <= 0)
			{
				return;
			}
			array2 = (float[])Utils.CopyArray(array2, new float[num2 - 1 + 1]);
			h10 = A_0[A_0.Count - 1].cy().ca();
			num6 = jf.b(array2, num2);
			num7 = jf.a(array2, num2);
			num8 = jf.c(array2, num2);
		}
		if (global::cc.cn(A_1))
		{
			hg.o a_2 = hg.o.a;
			A_3[A_2] = hg.bu((int)a_2, num6, h10, a_);
			A_4[A_2] = hg.bu((int)a_2, jf.a(ref array2, num2), h10, a_);
			A_5[A_2] = Conversions.ToString(h4.e((int)a_2, jf.a(ref array2, num2, num6), h10, a_, new h4(h4.a.b), A_5: false, 1));
			A_6[A_2] = hg.bu((int)a_2, num7, h10, a_);
			A_7[A_2] = hg.bu((int)a_2, num8, h10, a_);
			A_8[A_2] = hg.bu((int)a_2, num8 - num7, h10, a_);
			return;
		}
		if ((A_1 >= 11) & (A_1 < 66))
		{
			A_3[A_2] = global::cc.cf(num6, A_1, h10, a_);
			A_4[A_2] = global::cc.cf(jf.a(ref array2, num2), A_1, h10, a_);
			A_5[A_2] = global::cc.cf((float)jf.a(ref array2, num2, num6), A_1, h10, a_);
			A_6[A_2] = global::cc.cf(num7, A_1, h10, a_);
			A_7[A_2] = global::cc.cf(num8, A_1, h10, a_);
			A_8[A_2] = global::cc.cf(num8 - num7, A_1, h10, a_);
			return;
		}
		switch (A_1)
		{
		case 0:
			A_3[A_2] = Strings.Format(num6, "#.00000");
			A_4[A_2] = Strings.Format(jf.a(ref array2, num2), "#.00000");
			A_5[A_2] = Strings.Format((float)jf.a(ref array2, num2, num6), "#.00000");
			A_6[A_2] = Strings.Format(num7, "#.00000");
			A_7[A_2] = Strings.Format(num8, "#.00000");
			A_8[A_2] = Strings.Format(num8 - num7, "#.00000");
			break;
		case 10:
			A_3[A_2] = Strings.Format(num6, "0.#####");
			A_4[A_2] = Strings.Format(jf.a(ref array2, num2), "0.#####");
			A_5[A_2] = Strings.Format((float)jf.a(ref array2, num2, num6), "0.#####");
			A_6[A_2] = Strings.Format(num7, "0.#####");
			A_7[A_2] = Strings.Format(num8, "0.#####");
			A_8[A_2] = Strings.Format(num8 - num7, "0.#####");
			break;
		default:
		{
			hg.o a_2 = hg.o.c;
			A_3[A_2] = hg.bu(a_2, h10, num6, a_, new h4(h4.a.b), 0);
			A_4[A_2] = hg.bu(a_2, h10, jf.a(ref array2, num2), a_, new h4(h4.a.b), 0);
			A_5[A_2] = hg.bu(a_2, h10, jf.a(ref array2, num2, num6), a_, new h4(h4.a.b), 1);
			A_6[A_2] = hg.bu(a_2, h10, num7, a_, new h4(h4.a.b), 0);
			A_7[A_2] = hg.bu(a_2, h10, num8, a_, new h4(h4.a.b), 0);
			A_8[A_2] = hg.bu(a_2, h10, num8 - num7, a_, new h4(h4.a.b), 0);
			break;
		}
		}
	}

	private h4 a(Collection<hc> A_0)
	{
		return A_0[checked(A_0.Count - 1)].cy().ca();
	}

	private DataGridViewTextBoxColumn a(int A_0, h4 A_1)
	{
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		dataGridViewTextBoxColumn.HeaderText = global::cc.cg(A_0, A_1: true, A_1, A_3: true);
		dataGridViewTextBoxColumn.HeaderCell.ToolTipText = global::cc.cf(A_0, A_1: true, A_1, A_3: true);
		dataGridViewTextBoxColumn.Name = Conversions.ToString(A_0);
		dataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewTextBoxColumn.ReadOnly = true;
		dataGridViewTextBoxColumn.Tag = global::cc.co(A_0);
		_ = null;
		return dataGridViewTextBoxColumn;
	}

	private void q()
	{
		this.m_bm = true;
	}

	private bool p()
	{
		if (am.uj())
		{
			List<ek> A_ = null;
			b obj = co;
			ek A_2 = null;
			int A_3 = 0;
			int A_4 = 0;
			int A_5 = 0;
			obj.c(null, ref A_2, ref A_3, ref A_4, ref A_5, ref A_);
			return A_.Count > 0;
		}
		return false;
	}

	private void o()
	{
		this.m_bm = false;
		if (!am.uj())
		{
			return;
		}
		bool flag = p();
		ek A_ = null;
		el el2 = null;
		em em2 = null;
		en en2 = null;
		int num = -1;
		DataGridView dataGridView = a2();
		checked
		{
			int num2 = dataGridView.ColumnCount - 1;
			int num3 = num2 - 1;
			int num4 = num3 - 1;
			int index = num4 - 1;
			cp = true;
			try
			{
				List<ek> A_2 = null;
				ek ek2 = null;
				b obj = co;
				ek A_3 = null;
				int A_4 = 0;
				int A_5 = 0;
				int A_6 = 0;
				obj.c(null, ref A_3, ref A_4, ref A_5, ref A_6, ref A_2);
				if (A_2.Count == 1)
				{
					ek2 = A_2[0];
				}
				A_6 = dataGridView.RowCount - 1;
				int A_8 = default(int);
				int A_9 = default(int);
				int A_10 = default(int);
				for (num = 0; num <= A_6; num++)
				{
					DataGridViewRow dataGridViewRow = dataGridView.Rows[num];
					b obj2 = co;
					hc a_ = (hc)dataGridViewRow.Tag;
					List<ek> A_7 = null;
					obj2.c(a_, ref A_, ref A_8, ref A_9, ref A_10, ref A_7);
					if (num == dataGridView.RowCount)
					{
						throw new Exception("HistoryID and row tag don't match.");
					}
					DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)dataGridViewRow.Cells[index];
					DataGridViewComboBoxCell dataGridViewComboBoxCell2 = (DataGridViewComboBoxCell)dataGridViewRow.Cells[num4];
					DataGridViewCheckBoxCell dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)dataGridViewRow.Cells[num3];
					DataGridViewCheckBoxCell dataGridViewCheckBoxCell2 = (DataGridViewCheckBoxCell)dataGridViewRow.Cells[num2];
					dataGridViewComboBoxCell.Value = null;
					dataGridViewComboBoxCell.Items.Clear();
					dataGridViewComboBoxCell2.Value = null;
					dataGridViewComboBoxCell2.Items.Clear();
					if (A_ != null || ek2 != null)
					{
						ek ek3;
						if (A_ == null)
						{
							el2 = null;
							em2 = null;
							en2 = null;
							ek3 = ek2;
						}
						else
						{
							el2 = ek2.c[A_8];
							em2 = el2.b[A_9];
							en2 = em2.b[A_10];
							ek3 = A_;
						}
						DataGridViewComboBoxCell dataGridViewComboBoxCell3 = dataGridViewComboBoxCell;
						dataGridViewComboBoxCell3.Items.Add("");
						foreach (el item in ek3.c)
						{
							dataGridViewComboBoxCell3.Items.Add(item.d());
						}
						dataGridViewComboBoxCell3 = null;
						DataGridViewComboBoxCell dataGridViewComboBoxCell4 = dataGridViewComboBoxCell2;
						if (A_ != null)
						{
							foreach (em item2 in el2.b)
							{
								dataGridViewComboBoxCell4.Items.Add(item2.f());
							}
						}
						dataGridViewComboBoxCell4 = null;
						if (A_ == null)
						{
							dataGridViewCheckBoxCell2.Value = false;
							dataGridViewCheckBoxCell.Value = false;
							dataGridViewComboBoxCell.Value = null;
							dataGridViewComboBoxCell2.Value = null;
						}
						else
						{
							dataGridViewCheckBoxCell2.Value = en2.l();
							dataGridViewCheckBoxCell.Value = en2.k();
							dataGridViewComboBoxCell.Value = el2.d();
							dataGridViewComboBoxCell2.Value = em2.f();
						}
					}
					else
					{
						dataGridViewCheckBoxCell2.Value = false;
						dataGridViewCheckBoxCell.Value = false;
					}
				}
			}
			finally
			{
				cp = false;
			}
			if (Operators.CompareString(dataGridView.Columns[dataGridView.ColumnCount - 1].Name, f3.d.ResGridColumnType.SS.ToString(), TextCompare: false) == 0)
			{
				if (flag)
				{
					d A_11 = null;
					int num5 = dataGridView.Columns.Count - 1;
					int A_5 = dataGridView.Columns.Count - 4;
					for (int num6 = num5; num6 >= A_5; num6 += -1)
					{
						DataGridViewColumn a_2 = dataGridView.Columns[num6];
						a(a_2, ref A_11);
						a(a_2, A_11.g, p());
					}
				}
				else
				{
					int num7 = dataGridView.Columns.Count - 1;
					int A_4 = dataGridView.Columns.Count - 4;
					for (int num8 = num7; num8 >= A_4; num8 += -1)
					{
						dataGridView.Columns[num8].Visible = false;
					}
				}
			}
			dataGridView = null;
		}
	}

	private DataGridViewComboBoxColumn b(string A_0, string A_1, string A_2)
	{
		DataGridViewComboBoxColumn dataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
		dataGridViewComboBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		dataGridViewComboBoxColumn.HeaderText = A_1;
		dataGridViewComboBoxColumn.HeaderCell.ToolTipText = A_2;
		dataGridViewComboBoxColumn.Name = A_0;
		dataGridViewComboBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		dataGridViewComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
		dataGridViewComboBoxColumn.ReadOnly = false;
		dataGridViewComboBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
		_ = null;
		return dataGridViewComboBoxColumn;
	}

	private DataGridViewCheckBoxColumn a(string A_0, string A_1, string A_2)
	{
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		dataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		dataGridViewCheckBoxColumn.HeaderText = A_1;
		dataGridViewCheckBoxColumn.HeaderCell.ToolTipText = A_2;
		dataGridViewCheckBoxColumn.Name = A_0;
		dataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		dataGridViewCheckBoxColumn.ReadOnly = false;
		dataGridViewCheckBoxColumn.Width = 50;
		dataGridViewCheckBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
		_ = null;
		return dataGridViewCheckBoxColumn;
	}

	private DataGridViewTextBoxColumn a(DataGridViewTextBoxColumn A_0)
	{
		return new DataGridViewTextBoxColumn
		{
			AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
			HeaderText = A_0.HeaderText,
			HeaderCell = 
			{
				ToolTipText = A_0.HeaderCell.ToolTipText
			},
			Name = A_0.Name,
			DefaultCellStyle = 
			{
				Alignment = DataGridViewContentAlignment.MiddleCenter
			}
		};
	}

	private void a(int[] A_0, int[] A_1, Collection<hc> A_2, bool A_3, ref int A_4)
	{
		int num = global::cc.cf(A_0);
		int num2 = 1;
		int num3 = global::cc.cf(A_1);
		int num4 = num3;
		h4 a_ = a(A_2);
		checked
		{
			int num5 = ((A_0 != null) ? (A_0.Length - 1) : (-1));
			int num6 = num5;
			int num10 = default(int);
			for (int num7 = num; num7 <= num6; num7++)
			{
				int num8 = num4;
				int num9 = A_1.Length - 1;
				for (num10 = num8; num10 <= num9; num10++)
				{
					if (A_0[num7] != A_1[num10])
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = a(A_1[num10], a_);
						a(num2, dataGridViewTextBoxColumn, A_3);
						a1().Columns.Insert(num2, a(dataGridViewTextBoxColumn));
						num2++;
						num4++;
						continue;
					}
					num4++;
					num2++;
					break;
				}
			}
			if (num10 < A_1.Length - 1)
			{
				int num11 = num4;
				int num12 = A_1.Length - 1;
				for (num10 = num11; num10 <= num12; num10++)
				{
					DataGridViewTextBoxColumn dataGridViewTextBoxColumn = a(A_1[num10], a_);
					a(num2, dataGridViewTextBoxColumn, A_3);
					a1().Columns.Insert(num2, a(dataGridViewTextBoxColumn));
					num2++;
				}
			}
			num4 = 0;
			int num13 = num3 - 1;
			for (int num7 = 0; num7 <= num13; num7++)
			{
				int num14 = num4;
				int num15 = num3 - 1;
				for (num10 = num14; num10 <= num15; num10++)
				{
					if (A_0 == null || num7 >= A_0.Length || A_0[num7] != A_1[num10])
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = a(A_1[num10], a_);
						a(num2, dataGridViewTextBoxColumn, A_3);
						if (global::cc.cl(A_1[num10]) && (global::cc.cg(A_1[num10]) == global::cc.k.a || global::cc.cg(A_1[num10]) == global::cc.k.k))
						{
							a1().Columns.Add(a(dataGridViewTextBoxColumn));
						}
						num4++;
						num2++;
						continue;
					}
					num4++;
					num2++;
					break;
				}
			}
			A_4 = num4;
			DataGridView dataGridView = a2();
			if (am.uj() && ct == null)
			{
				DataGridViewColumn a_2 = b("Sample", "Sample", "Meas. Report Sample Name");
				a(dataGridView.Columns.Count, a_2, A_3);
				cq = a_2;
				a_2 = b("Location", "Location", "Meas. Report Location Name");
				a(dataGridView.Columns.Count, a_2, A_3);
				cr = a_2;
				a_2 = a("Res", "Res", "Meas. Report Mark as Result");
				a(dataGridView.Columns.Count, a_2, A_3);
				cs = a_2;
				a_2 = a("SS", "SS", "Meas. Report Mark as Screenshot");
				a(dataGridView.Columns.Count, a_2, A_3);
				ct = a_2;
			}
			dataGridView = null;
			d A_5 = null;
			DataGridViewColumn a_3 = a2().Columns[0];
			a(a_3, ref A_5);
			a(a_3, A_5.g, A_2: false);
		}
	}

	[SpecialName]
	public ek bz()
	{
		if (!am.uj())
		{
			return null;
		}
		List<ek> A_ = null;
		b obj = co;
		ek A_2 = null;
		int A_3 = 0;
		int A_4 = 0;
		int A_5 = 0;
		obj.c(null, ref A_2, ref A_3, ref A_4, ref A_5, ref A_);
		if (A_.Count == 1)
		{
			return A_[0];
		}
		ek A_6 = null;
		DataGridView dataGridView = a2();
		if (dataGridView.SelectedRows.Count == 0)
		{
			return null;
		}
		if (dataGridView.SelectedRows.Count == 1)
		{
			hc hc2 = (hc)dataGridView.SelectedRows[0].Tag;
			if (hc2 == null)
			{
				throw new Exception("Cannot find a result for the row.");
			}
			b obj2 = co;
			A_5 = 0;
			A_4 = 0;
			A_3 = 0;
			List<ek> A_7 = null;
			obj2.c(hc2, ref A_6, ref A_5, ref A_4, ref A_3, ref A_7);
			return A_6;
		}
		ek A_8 = null;
		ek A_9 = null;
		Collection<hc> collection = new Collection<hc>();
		checked
		{
			A_3 = dataGridView.SelectedRows.Count - 1;
			int num;
			for (num = 0; num <= A_3; num++)
			{
				collection.Add((hc)dataGridView.SelectedRows[num].Tag);
				if (collection[num] == null)
				{
					throw new Exception("Cannot find a result for the row.");
				}
			}
			A_4 = collection.Count - 1;
			for (num = 0; num <= A_4; num++)
			{
				b obj3 = co;
				hc a_ = collection[num];
				A_5 = 0;
				int A_10 = 0;
				int A_11 = 0;
				List<ek> A_7 = null;
				obj3.c(a_, ref A_8, ref A_5, ref A_10, ref A_11, ref A_7);
				if (A_8 != null)
				{
					break;
				}
			}
			A_6 = A_8;
			if (A_8 != null && num < collection.Count - 1)
			{
				int num2 = num;
				int A_11 = collection.Count - 1;
				for (num = num2; num <= A_11; num++)
				{
					b obj4 = co;
					hc a_2 = collection[num];
					int A_10 = 0;
					A_5 = 0;
					int A_12 = 0;
					List<ek> A_7 = null;
					obj4.c(a_2, ref A_9, ref A_10, ref A_5, ref A_12, ref A_7);
					if (A_9 != null && A_9 != A_8)
					{
						return null;
					}
				}
			}
			return A_6;
		}
	}

	private void a(int A_0, DataGridViewColumn A_1, bool A_2)
	{
		cy = true;
		a2().Columns.Insert(A_0, A_1);
		A_1.DisplayIndex = a(A_1);
		cy = false;
		a(null, new DataGridViewColumnEventArgs(A_1));
		d A_3 = null;
		a(A_1, ref A_3);
		a(A_1, A_3.g, A_2);
	}

	private int a(DataGridViewColumn A_0)
	{
		d a_ = null;
		checked
		{
			d[] array = new d[a2().Columns.Count - 1 + 1];
			int num = array.Length - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				array[num2] = new d(a2().Columns[num2], bd(), be());
				if (A_0 == a2().Columns[num2])
				{
					a_ = array[num2];
				}
			}
			int num3 = a(a_, A_0.DisplayIndex, array);
			if (num3 == -1)
			{
				num3 = b(a_, A_0.DisplayIndex, array);
			}
			return num3;
		}
	}

	private int b(d A_0, int A_1, d[] A_2)
	{
		Collection<d> collection = new Collection<d>();
		checked
		{
			switch (A_0.h())
			{
			case f3.d.a.a:
				return 0;
			case f3.d.a.b:
			case f3.d.a.c:
			case f3.d.a.e:
			{
				int num = A_2.Length - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (A_2[num2].h() == A_0.h())
					{
						collection.Add(A_2[num2]);
					}
				}
				if (collection.Count > 1)
				{
					return a(A_1, A_0, collection, A_2);
				}
				return a(A_1, A_0, A_2);
			}
			case f3.d.a.d:
				return a(A_1, A_0, A_2);
			default:
				throw new Exception("Should not reach here.");
			}
		}
	}

	private int a(int A_0, d A_1, Collection<d> A_2, d[] A_3)
	{
		d d10;
		d d11;
		if (A_2[0] == A_1)
		{
			d10 = A_2[1];
			d11 = A_2[1];
		}
		else
		{
			d10 = A_2[0];
			d11 = A_2[0];
		}
		bool flag = default(bool);
		foreach (d item in A_2)
		{
			if (item == A_1)
			{
				continue;
			}
			if (item.i(A_1))
			{
				if (d10.i(item))
				{
					d10 = item;
					flag = true;
				}
			}
			else if (item.i(d11))
			{
				d11 = item;
			}
		}
		checked
		{
			int displayIndex;
			if (flag)
			{
				displayIndex = a2().Columns[Array.IndexOf(A_3, d10)].DisplayIndex;
				if (A_0 < displayIndex)
				{
					return displayIndex;
				}
				return displayIndex + 1;
			}
			displayIndex = a2().Columns[Array.IndexOf(A_3, d11)].DisplayIndex;
			if (A_0 < displayIndex)
			{
				return displayIndex - 1;
			}
			return displayIndex;
		}
	}

	private int a(int A_0, d A_1, d[] A_2)
	{
		int num = -1;
		int num2 = -1;
		do
		{
			num = b(A_1, A_2);
			if (num != -1)
			{
				break;
			}
			num2 = a(A_1, A_2);
		}
		while (num2 == -1);
		checked
		{
			if (num != -1)
			{
				if (A_0 < num)
				{
					return num;
				}
				return num + 1;
			}
			if (A_0 < num2)
			{
				return num2 - 1;
			}
			return num2;
		}
	}

	private int b(d A_0, d[] A_1)
	{
		checked
		{
			switch (A_0.h())
			{
			case f3.d.a.a:
				return 0;
			case f3.d.a.b:
			{
				int num3 = A_1.Length - 1;
				for (int num2 = 0; num2 <= num3; num2++)
				{
					if (A_1[num2].h() == f3.d.a.a)
					{
						return a2().Columns[num2].DisplayIndex;
					}
				}
				break;
			}
			case f3.d.a.c:
			case f3.d.a.d:
			{
				d.a a10;
				d d10;
				unchecked
				{
					a10 = (d.a)checked((short)(A_0.h() - 1));
					d10 = null;
				}
				int num4 = A_1.Length - 1;
				int num2;
				for (num2 = 0; num2 <= num4; num2++)
				{
					if (A_1[num2].h() == a10)
					{
						d10 = A_1[num2];
						num2--;
						break;
					}
				}
				if (d10 == null)
				{
					break;
				}
				int num5 = num2;
				int num6 = A_1.Length - 1;
				for (num2 = num5; num2 <= num6; num2++)
				{
					d d11 = A_1[num2];
					if (d11.h() == a10 && d10.i(d11))
					{
						d10 = d11;
					}
				}
				return a2().Columns[Array.IndexOf(A_1, d10)].DisplayIndex;
			}
			case f3.d.a.e:
			{
				int num = A_1.Length - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (A_1[num2].h() == f3.d.a.d)
					{
						return a2().Columns[num2].DisplayIndex;
					}
				}
				break;
			}
			}
			return -1;
		}
	}

	private int a(d A_0, d[] A_1)
	{
		checked
		{
			switch (A_0.h())
			{
			case f3.d.a.e:
				return A_1.Length - 1;
			case f3.d.a.d:
			{
				Collection<d> collection = new Collection<d>();
				d d12 = null;
				int num5 = A_1.Length - 1;
				for (int num2 = 0; num2 <= num5; num2++)
				{
					if (A_1[num2].h() == f3.d.a.e)
					{
						collection.Add(A_1[num2]);
					}
				}
				if (collection.Count <= 0)
				{
					break;
				}
				d12 = collection[0];
				foreach (d item in collection)
				{
					if (item.e > d12.e)
					{
						d12 = item;
					}
				}
				return a2().Columns[Array.IndexOf(A_1, d12)].DisplayIndex;
			}
			case f3.d.a.c:
			{
				int num6 = A_1.Length - 1;
				for (int num2 = 0; num2 <= num6; num2++)
				{
					if (A_1[num2].h() == f3.d.a.d)
					{
						return a2().Columns[num2].DisplayIndex;
					}
				}
				break;
			}
			case f3.d.a.a:
			case f3.d.a.b:
			{
				d.a a10;
				d d10;
				unchecked
				{
					a10 = (d.a)checked((short)(A_0.h() + 1));
					d10 = null;
				}
				int num = A_1.Length - 1;
				int num2;
				for (num2 = 0; num2 <= num; num2++)
				{
					if (A_1[num2].h() == a10)
					{
						d10 = A_1[num2];
						num2--;
						break;
					}
				}
				if (d10 == null)
				{
					break;
				}
				int num3 = num2;
				int num4 = A_1.Length - 1;
				for (num2 = num3; num2 <= num4; num2++)
				{
					d d11 = A_1[num2];
					if (d11.h() == a10 && d11.i(d10))
					{
						d10 = d11;
					}
				}
				return a2().Columns[Array.IndexOf(A_1, d10)].DisplayIndex;
			}
			}
			return -1;
		}
	}

	private int a(d A_0, int A_1, d[] A_2)
	{
		int num = -1;
		checked
		{
			int num2 = cx.Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				if (f3.d.i(A_0, cx[num3]))
				{
					num = num3;
					break;
				}
			}
			if (num == -1)
			{
				return -1;
			}
			int displayIndex = default(int);
			bool flag = default(bool);
			for (int num3 = num - 1; num3 >= 0; num3 += -1)
			{
				d a_ = cx[num3];
				int num4 = A_2.Length - 1;
				for (int num5 = 0; num5 <= num4; num5++)
				{
					if (f3.d.i(a_, A_2[num5]))
					{
						displayIndex = a2().Columns[num5].DisplayIndex;
						flag = true;
						break;
					}
				}
				if (flag)
				{
					break;
				}
			}
			bool flag2 = default(bool);
			if (!flag)
			{
				int num6 = num + 1;
				int num7 = cx.Count - 1;
				for (int num3 = num6; num3 <= num7; num3++)
				{
					d a_ = cx[num3];
					int num8 = A_2.Length - 1;
					for (int num5 = 0; num5 <= num8; num5++)
					{
						if (f3.d.i(a_, A_2[num5]))
						{
							displayIndex = a2().Columns[num5].DisplayIndex;
							flag2 = true;
							break;
						}
					}
					if (flag2)
					{
						break;
					}
				}
			}
			if (flag)
			{
				if (A_1 < displayIndex)
				{
					return displayIndex;
				}
				return displayIndex + 1;
			}
			if (flag2)
			{
				if (A_1 < displayIndex)
				{
					return displayIndex - 1;
				}
				return displayIndex;
			}
			return -1;
		}
	}

	private DataGridViewColumn a(int A_0)
	{
		foreach (DataGridViewColumn column in a2().Columns)
		{
			if (column.DisplayIndex == A_0)
			{
				return column;
			}
		}
		return null;
	}

	private void a(object A_0, DataGridViewColumnEventArgs A_1)
	{
		if (cy)
		{
			return;
		}
		DataGridViewColumn dataGridViewColumn = null;
		d A_2 = null;
		DataGridViewColumn dataGridViewColumn2 = null;
		d A_3 = null;
		DataGridViewColumn dataGridViewColumn3 = null;
		d A_4 = null;
		dataGridViewColumn = A_1.Column;
		int displayIndex = dataGridViewColumn.DisplayIndex;
		checked
		{
			int a_ = displayIndex - 1;
			int a_2 = displayIndex + 1;
			dataGridViewColumn2 = a(a_);
			dataGridViewColumn3 = a(a_2);
			a(dataGridViewColumn, ref A_2);
			if (dataGridViewColumn2 != null)
			{
				a(dataGridViewColumn2, ref A_3);
				if (dataGridViewColumn3 != null)
				{
					a(dataGridViewColumn3, ref A_4);
					if (A_3 != null)
					{
						if (A_4 != null)
						{
							int num = cx.IndexOf(A_3);
							int num2 = cx.IndexOf(A_4);
							if (A_2 == null)
							{
								A_2 = new d(dataGridViewColumn, bd(), be());
								cx.Insert(num + 1, A_2);
								return;
							}
							int num3 = cx.IndexOf(A_2);
							if (num3 < num)
							{
								cx.RemoveAt(num3);
								cx.Insert(num, A_2);
							}
							else if (num3 > num2)
							{
								cx.RemoveAt(num3);
								cx.Insert(num + 1, A_2);
							}
							return;
						}
						int num4 = cx.IndexOf(A_3);
						if (A_2 == null)
						{
							A_2 = new d(dataGridViewColumn, bd(), be());
							cx.Insert(num4 + 1, A_2);
							return;
						}
						int num5 = cx.IndexOf(A_2);
						if (num5 < num4)
						{
							cx.RemoveAt(num5);
							cx.Insert(num4, A_2);
						}
						return;
					}
					if (A_4 != null)
					{
						int num6 = cx.IndexOf(A_4);
						if (A_2 == null)
						{
							A_2 = new d(dataGridViewColumn, bd(), be());
							cx.Insert(num6, A_2);
							return;
						}
						int num7 = cx.IndexOf(A_2);
						if (num7 > num6)
						{
							cx.RemoveAt(num7);
							cx.Insert(num6, A_2);
						}
						return;
					}
					throw new Exception("should not reach here.");
				}
				a(dataGridViewColumn2, ref A_3);
				if (A_3 != null)
				{
					if (A_2 != null)
					{
						int num8 = cx.IndexOf(A_2);
						int num9 = cx.IndexOf(A_3);
						if (num8 < num9)
						{
							cx.RemoveAt(num8);
							cx.Insert(num9, A_2);
						}
					}
					else
					{
						A_2 = new d(dataGridViewColumn, bd(), be());
						cx.Insert(cx.IndexOf(A_3) + 1, A_2);
					}
				}
				else
				{
					if (A_2 == null)
					{
						A_2 = new d(dataGridViewColumn, bd(), be());
					}
					else
					{
						cx.Remove(A_2);
					}
					cx.Add(A_2);
				}
				return;
			}
			if (dataGridViewColumn3 != null)
			{
				a(dataGridViewColumn3, ref A_4);
				if (A_4 != null)
				{
					if (A_2 != null)
					{
						int num10 = cx.IndexOf(A_2);
						int num11 = cx.IndexOf(A_4);
						if (num10 > num11)
						{
							cx.RemoveAt(num10);
							cx.Insert(num11, A_2);
						}
					}
					else
					{
						A_2 = new d(dataGridViewColumn, bd(), be());
						cx.Insert(cx.IndexOf(A_4), A_2);
					}
				}
				else
				{
					if (A_2 == null)
					{
						A_2 = new d(dataGridViewColumn, bd(), be());
					}
					else
					{
						cx.Remove(A_2);
					}
					cx.Insert(0, A_2);
				}
				return;
			}
			throw new Exception("should not reach here.");
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		try
		{
			if (am.uj())
			{
				this.m_b0.b();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			al.c(fz.b.b, "Error in FIControlPanelHistory.DataGridHistoryMeas_CurrentCellChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(ek A_0, en A_1)
	{
		hc hc2 = A_0.g;
		int a_ = A_0.l();
		int a_2 = A_0.m();
		int a_3 = A_0.n();
		A_0.g = A_1.b;
		A_0.l(A_1);
		A_0.g = hc2;
		A_0.l(a_);
		A_0.m(a_2);
		A_0.n(a_3);
		_ = null;
	}

	private void a(object A_0, DataGridViewCellEventArgs A_1)
	{
		try
		{
			if (A_1.RowIndex < 0 || A_1.ColumnIndex < 0 || cp)
			{
				return;
			}
			DataGridViewCell dataGridViewCell = a2().Rows[A_1.RowIndex].Cells[A_1.ColumnIndex];
			hc hc2 = (hc)a2().Rows[A_1.RowIndex].Tag;
			ek A_2 = null;
			em em2 = null;
			List<ek> A_3 = null;
			ek ek2 = null;
			int A_6 = default(int);
			int A_4 = default(int);
			int A_5 = default(int);
			co.c(hc2, ref A_2, ref A_4, ref A_5, ref A_6, ref A_3);
			if (A_2 == null)
			{
				if (A_3.Count != 1)
				{
					return;
				}
				ek2 = A_3[0];
			}
			if (A_2 != null)
			{
				em2 = A_2.c[A_4].b[A_5];
			}
			DataGridViewColumn dataGridViewColumn = a2().Columns[A_1.ColumnIndex];
			if (dataGridViewColumn == ct)
			{
				if (em2 == null)
				{
					cp = true;
					((DataGridViewCheckBoxCell)dataGridViewCell).Value = false;
					cp = false;
				}
				else
				{
					bool flag = Conversions.ToBoolean(((DataGridViewCheckBoxCell)dataGridViewCell).Value);
					if (flag)
					{
						foreach (en item in em2.b)
						{
							item.j(A_0: false);
						}
					}
					en en2 = em2.b[A_6];
					en2.j(flag);
					if (flag)
					{
						a(A_2, en2);
					}
				}
			}
			else if (dataGridViewColumn == cs)
			{
				if (em2 == null)
				{
					cp = true;
					((DataGridViewCheckBoxCell)dataGridViewCell).Value = false;
					cp = false;
				}
				else
				{
					bool flag2 = Conversions.ToBoolean(((DataGridViewCheckBoxCell)dataGridViewCell).Value);
					if (flag2)
					{
						foreach (en item2 in em2.b)
						{
							item2.i(A_0: false);
						}
					}
					em2.b[A_6].i(flag2);
				}
			}
			else if (dataGridViewColumn == cr)
			{
				if (A_2 == null)
				{
					return;
				}
				string right = Conversions.ToString(((DataGridViewComboBoxCell)dataGridViewCell).Value);
				foreach (em item3 in A_2.c[A_4].b)
				{
					if (Operators.CompareString(item3.f(), right, TextCompare: false) == 0)
					{
						a(item3, A_2.c[A_4], A_2, A_4, A_5, A_6, A_1.RowIndex);
						break;
					}
				}
			}
			else
			{
				if (dataGridViewColumn != cq)
				{
					return;
				}
				string text = Conversions.ToString(((DataGridViewComboBoxCell)dataGridViewCell).Value);
				Collection<el> collection = ((A_2 != null) ? A_2.c : A_3[0].c);
				if (!string.IsNullOrEmpty(text))
				{
					bool flag3 = default(bool);
					bool flag4 = default(bool);
					foreach (el item4 in collection)
					{
						if (Operators.CompareString(item4.d(), text, TextCompare: false) != 0)
						{
							continue;
						}
						em em3 = null;
						Collection<em> collection2 = new Collection<em>();
						foreach (em item5 in item4.b)
						{
							collection2.Add(item5);
						}
						ek ek3 = A_2;
						if (ek3 == null)
						{
							ek3 = ek2;
						}
						foreach (el item6 in ek3.c)
						{
							if (item6 != item4)
							{
								continue;
							}
							foreach (em item7 in item6.b)
							{
								if (item7.b.Count > 0)
								{
									collection2.Remove(item7);
								}
							}
						}
						em em4;
						en en3;
						if (A_2 == null)
						{
							A_4 = collection.IndexOf(item4);
							em4 = ((collection2.Count > 0) ? collection2[0] : ((ek2.l() != A_4 || ek2.m() >= item4.b.Count) ? item4.b[0] : item4.b[ek2.m()]));
							A_5 = item4.b.IndexOf(em4);
							ek2.l(hc2.cn(), A_4, A_5);
							A_6 = checked(em4.b.Count - 1);
							en3 = em4.b[A_6];
							en3.b = hc2;
							em4.b.RemoveAt(A_6);
						}
						else
						{
							em3 = A_2.c[A_4].b[A_5];
							en3 = em3.b[A_6];
							em4 = ((collection2.Count <= 0) ? item4.b[0] : collection2[0]);
							foreach (em item8 in item4.b)
							{
								if (Operators.CompareString(item8.f(), em3.f(), TextCompare: false) == 0)
								{
									em4 = item8;
									break;
								}
							}
						}
						foreach (en item9 in em4.b)
						{
							if (item9.k())
							{
								en3.i(A_0: false);
								flag3 = true;
							}
							if (item9.l())
							{
								en3.j(A_0: false);
								flag4 = true;
							}
							if (flag3 && flag4)
							{
								break;
							}
						}
						if (A_2 == null)
						{
							ek2.l(en3, item4, em4);
						}
						else
						{
							A_2.l(en3, item4, em4);
						}
						em3?.b.RemoveAt(A_6);
						a(en3.b, a2().Rows[A_1.RowIndex]);
						if (en3.l())
						{
							a(A_2, en3);
						}
						break;
					}
				}
				else if (A_2 != null)
				{
					en en4 = A_2.c[A_4].b[A_5].b[A_6];
					A_2.c[A_4].b[A_5].b.RemoveAt(A_6);
					if (A_2.g == en4.b)
					{
						A_2.g = null;
					}
				}
			}
			o();
			a2().RefreshEdit();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			al.c(fz.b.b, "Error in FIControlPanelHistory.DataGridHistoryMeas_CellValueChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(em A_0, el A_1, ek A_2, int A_3, int A_4, int A_5, int A_6)
	{
		em em2 = A_2.c[A_3].b[A_4];
		en en2 = em2.b[A_5];
		if (A_0 == em2)
		{
			return;
		}
		bool flag = default(bool);
		bool flag2 = default(bool);
		foreach (en item in A_0.b)
		{
			if (item.k())
			{
				en2.i(A_0: false);
				flag = true;
			}
			if (item.l())
			{
				en2.j(A_0: false);
				flag2 = true;
			}
			if (flag && flag2)
			{
				break;
			}
		}
		A_2.l(en2, A_1, A_0);
		em2.b.RemoveAt(A_5);
		a(en2.b, a2().Rows[A_6]);
		if (en2.l())
		{
			a(A_2, en2);
		}
	}

	private void a(hc A_0, DataGridViewRow A_1)
	{
		((DataGridViewTextBoxCell)A_1.Cells[n()]).Value = A_0.cn().b5();
	}

	private int n()
	{
		int num = -1;
		foreach (DataGridViewColumn column in a2().Columns)
		{
			num = checked(num + 1);
			if (Operators.CompareString(column.HeaderText, this.m_bz, TextCompare: false) == 0)
			{
				break;
			}
		}
		return num;
	}

	private void n(object A_0, EventArgs A_1)
	{
		try
		{
			if (a2().IsCurrentCellDirty)
			{
				a2().CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			al.c(fz.b.b, "Error in FIControlPanelHistory.DataGridHistoryMeas_CurrentCellDirtyStateChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	public b b0()
	{
		return co;
	}

	private string a(string[] A_0, int A_1, int A_2, h4 A_3, short A_4)
	{
		if (Conversions.ToBoolean(A_0[7]))
		{
			if (global::cc.cn(A_2))
			{
				return hg.bu(1, Conversions.ToSingle(A_0[A_1]), A_3, A_4);
			}
			return hg.bu(hg.o.c, A_3, Conversions.ToSingle(A_0[A_1]), A_4, new h4(h4.a.b), 0);
		}
		string A_5 = "HistoryDataTableInvalidValue";
		return hu.a(ref A_5);
	}

	private string[] a(hc A_0, long A_1)
	{
		if (this.m_a9 == -1)
		{
			a(A_0.er());
			this.m_a9 = global::cc.cf(this.m_a7);
		}
		checked
		{
			string[] array = new string[A_0.es().Length + 1 + 1];
			int[] array2 = A_0.er();
			string[] array3 = A_0.es();
			int num = A_0.es().Length - this.m_a9;
			string text = null;
			short num2 = global::e.a().DisplaySignificantDigits;
			h4 a_ = A_0.cy().ca();
			array[0] = a(A_1);
			array[A_0.es().Length + 1] = A_0.c1();
			int num3 = A_0.es().Length - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				int num5 = array2[num4];
				int num6 = ((num5 < 0 || num5 >= 11) ? (num4 - this.m_a9 + 1) : (num4 + num + 1));
				text = ((num5 != 0) ? ((num5 != 10) ? ((num5 >= 11) ? ((num5 < 11 || num5 >= 66) ? a(array3, num4, array2[num4], a_, num2) : global::cc.cf(Conversions.ToSingle(array3[num4]), array2[num4], A_0.cy().ca(), num2)) : array3[num4]) : Strings.Format(Conversions.ToSingle(array3[num4]), "0.#####")) : Strings.Format(Conversions.ToSingle(array3[num4]), "#.00000"));
				array[num6] = text;
			}
			return array;
		}
	}

	private string[] a(hc A_0, int A_1, Collection<hc> A_2)
	{
		checked
		{
			string[] array = new string[this.m_a7.Length + 1 + 1];
			int[] array2 = A_0.er();
			string[] array3 = A_0.es();
			int num = this.m_a7.Length - this.m_a9;
			string text = null;
			short a_ = global::e.a().DisplaySignificantDigits;
			array[0] = a(unchecked((long)A_1));
			array[this.m_a7.Length + 1] = A_0.c1();
			int num2 = this.m_a7.Length - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				bool flag = false;
				int num4;
				if (num3 >= 0 && num3 < this.m_a9)
				{
					num4 = num3 + num + 1;
					if (this.m_a7[num3] == 0 || this.m_a7[num3] == 10)
					{
						flag = true;
					}
				}
				else
				{
					num4 = num3 - this.m_a9 + 1;
					flag = true;
				}
				array[num4] = " ";
				int num5 = this.m_a7[num3];
				int num6 = array2.Length - 1;
				for (int num7 = 0; num7 <= num6; num7++)
				{
					if (array2[num7] != num5)
					{
						continue;
					}
					if (flag)
					{
						string key = Conversions.ToString(num5);
						c value = new c(float.Parse(array3[num7]), A_0.c1(), this.m_a4);
						if (this.m_a1.Contains(key))
						{
							c[] array4 = (c[])this.m_a1[key];
							int num8 = Array.IndexOf(array4, null);
							if (num8 + 1 >= array4.Length)
							{
								Array.Resize(ref array4, array4.Length + 500);
							}
							array4.SetValue(value, num8);
						}
						else
						{
							c[] array5 = new c[1001];
							array5.SetValue(value, 0);
							this.m_a1.Add(array5, key);
						}
					}
					switch (num5)
					{
					case 0:
						text = Strings.Format(Conversions.ToSingle(array3[num7]), "#.00000");
						break;
					case 10:
						text = Strings.Format(Conversions.ToSingle(array3[num7]), "0.#####");
						break;
					default:
						if ((num5 >= 11) & (num5 < 66))
						{
							text = global::cc.cf(Conversions.ToSingle(array3[num7]), num5, A_0.cy().ca(), a_);
						}
						else if (flag)
						{
							if (Conversions.ToBoolean(array3[7]))
							{
								text = ((!global::cc.cn(num5)) ? hg.bu(hg.o.c, A_2[A_2.Count - 1].cy().ca(), Conversions.ToSingle(array3[num7]), a_, new h4(h4.a.b), 0) : hg.bu(1, Conversions.ToSingle(array3[num7]), A_2[A_2.Count - 1].cy().ca(), a_));
								break;
							}
							string A_3 = "HistoryDataTableInvalidValue";
							text = hu.a(ref A_3);
						}
						else
						{
							text = array3[num7];
						}
						break;
					}
					array[num4] = text;
					break;
				}
			}
			return array;
		}
	}

	private void m()
	{
		az().Items.Clear();
		h();
		ComboBox.ObjectCollection items = az().Items;
		string A_ = "IncludeAllChannels";
		items.Add(hu.a(ref A_));
		az().SelectedIndex = 0;
		z();
	}

	private void m(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				b2 b10 = new b2();
				StreamWriter streamWriter = null;
				try
				{
					if (string.IsNullOrEmpty(global::e.a().LastSaveHistPath))
					{
						saveFileDialog.InitialDirectory = i3.b();
					}
					else
					{
						saveFileDialog.InitialDirectory = global::e.a().LastSaveHistPath;
					}
					b10.a("Comma Separated Values (*.csv)", "*.csv", 1);
					b10.a("Complete History File (*.fibhi)", "*.fibhi", 2);
					if (Operators.CompareString(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator, ".", TextCompare: false) == 0)
					{
						b10.a("FILMeasure Stat File (*.mls)", "*.mls", 3);
					}
					saveFileDialog.Filter = b10.b();
					saveFileDialog.FilterIndex = global::e.a().LastUsedOpenHistoryFilter;
					if (saveFileDialog.ShowDialog() != DialogResult.OK)
					{
						return;
					}
					string text = b10.a(saveFileDialog.FileName, saveFileDialog.FilterIndex);
					global::e.a().LastUsedOpenHistoryFilter = saveFileDialog.FilterIndex;
					global::e.a().LastSaveHistPath = Path.GetDirectoryName(text);
					if (saveFileDialog.FilterIndex == 2)
					{
						b(text);
						return;
					}
					string value = Conversions.ToString(i3.h(text));
					streamWriter = new StreamWriter(text, append: false, Encoding.UTF8);
					streamWriter.WriteLine("Date: " + DateAndTime.DateString);
					int num = a1().Columns.Count - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						if (num2 > 0)
						{
							streamWriter.Write(value);
						}
						streamWriter.Write(a1().Columns[num2].HeaderText.Replace("Å", "A").Replace("µ", "u"));
					}
					streamWriter.WriteLine();
					int num3 = a1().Rows.Count - 1;
					for (int num2 = 0; num2 <= num3; num2++)
					{
						bool flag = false;
						int num4 = a1().Columns.Count - 1;
						for (int num5 = 0; num5 <= num4; num5++)
						{
							if (a1().Columns[num5].Width > 1)
							{
								if (flag)
								{
									streamWriter.Write(value);
								}
								object objectValue = RuntimeHelpers.GetObjectValue(a1()[num5, num2].Value);
								streamWriter.Write((objectValue == null) ? string.Empty : objectValue.ToString());
								flag = true;
							}
						}
						streamWriter.WriteLine();
					}
					int num6 = a2().Columns.Count - 1;
					for (int num2 = 0; num2 <= num6; num2++)
					{
						if (num2 > 0)
						{
							streamWriter.Write(value);
						}
						streamWriter.Write(a2().Columns[num2].HeaderText.Replace("Å", "A").Replace("µ", "u"));
					}
					streamWriter.WriteLine();
					int num7 = a2().Rows.Count - 1;
					for (int num2 = 0; num2 <= num7; num2++)
					{
						bool flag = false;
						int num8 = a2().Columns.Count - 1;
						for (int num5 = 0; num5 <= num8; num5++)
						{
							if (a2().Columns[num5].Width <= 1)
							{
								continue;
							}
							if (flag)
							{
								streamWriter.Write(value);
							}
							if (a2()[num5, num2].Value == null)
							{
								streamWriter.Write(" ");
							}
							else
							{
								string text2 = a2()[num5, num2].Value.ToString();
								if (text2.Contains(value) || text2.Contains("\""))
								{
									text2 = "\"" + text2.Replace("\"", "\"\"") + "\"";
								}
								streamWriter.Write(text2);
							}
							flag = true;
						}
						streamWriter.WriteLine();
					}
				}
				finally
				{
					streamWriter?.Close();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				al.c(fz.b.b, "Error trying to save the measurement data into the file. Error is: ", a_);
				fe.b(al, "Error in ButtonHistorySave. Data has not been saved.", i6.a(a7()));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		string text = null;
		string text2 = null;
		checked
		{
			try
			{
				text = text + "Date: " + DateAndTime.DateString + "\r\n";
				int num = a1().Columns.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					text = text + a1().Columns[num2].HeaderText + "\t";
				}
				text += "\r\n";
				int num3 = a1().Rows.Count - 1;
				for (int num2 = 0; num2 <= num3; num2++)
				{
					bool flag = false;
					int num4 = a1().Columns.Count - 1;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						if (a1().Columns[num5].Width > 1)
						{
							if (flag)
							{
								text += "\t";
							}
							text += a1()[num5, num2].Value.ToString();
							flag = true;
						}
					}
					text += "\r\n";
				}
				int num6 = a2().Columns.Count - 1;
				for (int num2 = 0; num2 <= num6; num2++)
				{
					text = text + a2().Columns[num2].HeaderText + "\t";
				}
				text += "\r\n";
				int num7 = a2().Rows.Count - 1;
				for (int num2 = 0; num2 <= num7; num2++)
				{
					bool flag = false;
					int num8 = a2().Columns.Count - 1;
					for (int num5 = 0; num5 <= num8; num5++)
					{
						if (a2().Columns[num5].Width > 1)
						{
							if (flag)
							{
								text += "\t";
							}
							text2 = ((a2()[num5, num2].Value != null) ? a2()[num5, num2].Value.ToString() : " ");
							text += text2;
							flag = true;
						}
					}
					text += "\r\n";
				}
				global::c.e().Clipboard.Clear();
				global::c.e().Clipboard.SetText(text);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(al, am, null, i6.a(a5()), "FIControlPanelHistory.ButtonHistoryCopy_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void k(object A_0, EventArgs A_1)
	{
		bool flag = am.uj();
		checked
		{
			try
			{
				if ((A_0 != bk() && global::e.a().HistoryConfirmBeforeDelete && !a()) || a2().SelectedRows.Count == 0)
				{
					return;
				}
				List<hc> list = new List<hc>();
				int num = -1;
				int num2 = -1;
				hc hc2 = null;
				foreach (DataGridViewRow selectedRow in a2().SelectedRows)
				{
					hc2 = (hc)selectedRow.Tag;
					if (ao && this.m_b2 != null && this.m_b2 == hc2)
					{
						num = this.m_aw.IndexOf(hc2);
						this.m_b2 = null;
						break;
					}
				}
				num2 = num;
				foreach (DataGridViewRow selectedRow2 in a2().SelectedRows)
				{
					hc2 = (hc)selectedRow2.Tag;
					list.Add(hc2);
					if (this.m_aw.IndexOf(hc2) < num)
					{
						num2--;
					}
				}
				bool flag2 = false;
				bool flag3 = false;
				try
				{
					if (Monitor.TryEnter(RuntimeHelpers.GetObjectValue(this.m_a0), 2000))
					{
						flag2 = true;
						foreach (hc item2 in list)
						{
							string item = item2.c1();
							int num3 = this.m_bo.IndexOf(item) - 1;
							cb cb2 = a(item2);
							if (cb2 == null)
							{
								this.m_aw.Remove(item2);
								this.m_av[num3].Remove(item2);
								c(item2);
								if (item2.cn() == this.m_a2)
								{
									if (DateTime.Compare(this.m_a3, this.m_a2.cb()) == 0)
									{
										this.m_a3 = DateTime.MinValue;
									}
									this.m_a2 = null;
								}
							}
							else
							{
								foreach (hc item3 in cb2.h())
								{
									this.m_aw.Remove(item3);
									this.m_av[num3].Remove(item3);
									c(item3);
									if (item2.cn() == this.m_a2)
									{
										if (DateTime.Compare(this.m_a3, this.m_a2.cb()) == 0)
										{
											this.m_a3 = DateTime.MinValue;
										}
										this.m_a2 = null;
									}
								}
								this.m_ay.Remove(cb2);
							}
							if (flag)
							{
								co.c(item2);
							}
							if (this.m_av[num3].Count == 0)
							{
								this.m_av.RemoveAt(num3);
								this.m_bo.RemoveAt(num3 + 1);
								this.m_br.RemoveAt(num3 + 1);
								az().Items.RemoveAt(num3 + 1);
								z();
								flag3 = true;
							}
						}
						if (ao && global::e.a().HistoryArchiveAutomatically && num2 > 0)
						{
							this.m_b2 = this.m_aw[num2 - 1];
						}
					}
				}
				finally
				{
					if (flag2)
					{
						Monitor.Exit(RuntimeHelpers.GetObjectValue(this.m_a0));
					}
				}
				DateTime t2 = this.m_a3;
				if (this.m_a2 == null)
				{
					aa();
				}
				if (DateTime.Compare(t2, this.m_a3) != 0)
				{
					ab();
				}
				if (flag3 && az().SelectedIndex < 0)
				{
					az().SelectedIndex = 0;
				}
				else
				{
					l();
					t();
				}
				b5();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(al, am, null, i6.a(a3()), "FIControlPanelHistory.ButtonHistoryDelete_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void l()
	{
		this.m_a5 = true;
		this.m_a8 = true;
		y();
		v();
		this.m_a7 = new int[0];
		checked
		{
			int num = this.m_ax.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				a(this.m_ax[num2].er());
			}
			this.m_be = null;
		}
	}

	private void j(object A_0, EventArgs A_1)
	{
		try
		{
			this.m_bb = bf().SelectedTab == au();
			if (this.m_bb)
			{
				ba().gi().ar(a8().gi().at());
				i();
				if (aw().Items.Count > 0 && aw().SelectedIndex == -1)
				{
					aw().SelectedIndex = 0;
				}
				if (this.m_bh)
				{
					j();
				}
			}
			else
			{
				a8().gi().ar(ba().gi().at());
			}
			k();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(al, am, null, i6.a(bf()), "FIControlPanelHistory.TabControlHistory_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void k()
	{
		bool a_ = !an || bf().SelectedTab != @as();
		a8().w(a_);
		bg().w(a_);
		a9().w(a_);
		bool a_2 = !an || bf().SelectedTab != au();
		ba().w(a_2);
	}

	private void j()
	{
		if (this.m_ax.Count == 0)
		{
			return;
		}
		bool flag = global::cc.cn(this.m_bc);
		string A_ = "MeasThicknessTitle";
		checked
		{
			_ = hu.a(ref A_) + " (" + h4.e(this.m_ax[this.m_ax.Count - 1].cy().ca(), false, false) + ")";
			string key = Conversions.ToString(this.m_bc);
			if (this.m_a1.Contains(key))
			{
				fl obj = ba();
				A_ = "MeasTrend";
				obj.s(hu.a(ref A_));
				ba().o(global::cc.cf(this.m_bc, A_1: true, a(this.m_ax), A_3: false), global::cc.cg(this.m_bc, A_1: true, a(this.m_ax), A_3: false), global::cc.cm(this.m_bc));
				c[] array = (c[])this.m_a1[key];
				int num = Array.IndexOf(array, null);
				double[] A_2 = new double[num - 1 + 1];
				double[] A_3 = new double[num - 1 + 1];
				int num2 = 0;
				int num3 = this.m_bd;
				int num4 = num - 1;
				int num5;
				for (num5 = num3; num5 <= num4; num5++)
				{
					if (this.m_bc <= 66 || Conversions.ToBoolean(this.m_ax[array[num5].d() - 1].es()[7]))
					{
						if (flag)
						{
							A_2[num2] = h4.e(1, array[num5].e(), this.m_ax[this.m_ax.Count - 1].cy().ca());
						}
						else
						{
							A_2[num2] = array[num5].e();
						}
						A_3[num2] = array[num5].d();
						num2++;
					}
				}
				this.m_bd = num5;
				ba().gi().am(5f);
				ba().o(ref A_3, ref A_2, num2, this.m_bc, 0L, 0.0, aw().Text, aw().Text, A_8: false, global::cc.cm(this.m_bc));
			}
			ac();
			this.m_bh = false;
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		try
		{
			if (aw().SelectedIndex != -1)
			{
				this.m_bc = ((iz.a)aw().Items[aw().SelectedIndex]).b;
				global::e.a().HistoryLastTrendParam = this.m_bc;
				ba().g1();
				this.m_bd = 0;
				j();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(al, am, null, i6.a(aw()), "FIControlPanelHistory.ComboBoxHistoryParam_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void i()
	{
		int num = 0;
		checked
		{
			int num2 = this.m_a7.Length - 1;
			if (num2 < 0)
			{
				return;
			}
			int num3 = this.m_a9;
			int num4 = num2;
			for (int num5 = num3; num5 <= num4; num5++)
			{
				string text = global::cc.cf(this.m_a7[num5], A_1: false, null, A_3: true);
				iz.a a10 = new iz.a(text, this.m_a7[num5]);
				bool flag = false;
				foreach (iz.a item in aw().Items)
				{
					if (item.b == a10.b && Operators.CompareString(item.a, text, TextCompare: false) == 0)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					aw().Items.Insert(num, a10);
				}
				num++;
			}
			if (aw().SelectedIndex != -1 || aw().Items.Count <= 0)
			{
				return;
			}
			int num6 = global::e.a().HistoryLastTrendParam;
			bool flag2 = false;
			int num7 = aw().Items.Count - 1;
			for (int num5 = 0; num5 <= num7; num5++)
			{
				if (num6 == ((iz.a)aw().Items[num5]).b)
				{
					aw().SelectedIndex = num5;
					flag2 = true;
					break;
				}
			}
			if (!flag2 && aw().Items.Count > 0)
			{
				aw().SelectedIndex = 0;
			}
		}
	}

	[SpecialName]
	public a b1()
	{
		return cm;
	}

	[SpecialName]
	public gk b2()
	{
		return cn;
	}

	private void h(object A_0, EventArgs A_1)
	{
		if (ak && bh().Items.Count > 0 && this.m_be != null)
		{
			eo.a a_ = null;
			if (this.m_be != null)
			{
				a_ = this.m_be.cz();
			}
			fl A_2 = bg();
			hc a_2 = this.m_be;
			ComboBox A_3 = bh();
			int a_3 = hg.bu(ref A_3);
			c(A_3);
			jb.a(ref A_2, a_2, a_3, A_3: false, this.m_bg, al, a_);
			d(A_2);
		}
	}

	private cb a(hc A_0)
	{
		foreach (cb item in this.m_ay)
		{
			if (item.h().Contains(A_0))
			{
				return item;
			}
		}
		return null;
	}

	private void g(object A_0, EventArgs A_1)
	{
		hc hc2 = null;
		cb cb2 = null;
		try
		{
			if (this.m_a4 == 0)
			{
				return;
			}
			if (a2().SelectedRows.Count > 1)
			{
				fz a_ = al;
				string A_2 = "HistoryMultipleRowsSelectedError";
				fe.b(a_, hu.a(ref A_2), i6.a(a0()));
				return;
			}
			if (a2().SelectedRows.Count == 0)
			{
				fz a_2 = al;
				string A_2 = "HistoryNoRowSelectedError";
				fe.b(a_2, hu.a(ref A_2), i6.a(a0()));
				return;
			}
			hc2 = (hc)a2().SelectedRows[0].Tag;
			cb2 = a(hc2);
			if (hc2 == null)
			{
				throw new ApplicationException("The result was not found in the measurement collection");
			}
			Guid A_3 = default(Guid);
			bool A_4 = default(bool);
			am.m2(hc2, i6.a(a0()), ref A_3, ref A_4);
			if (A_4 && !am.wq(A_3).fy)
			{
				return;
			}
			if (cb2 == null)
			{
				bool A_5 = default(bool);
				cn.b(hc2, null, A_3, !A_4, ref A_5);
				if (A_5)
				{
					o(a2(), null);
					a(hc2, a2().SelectedRows[0]);
				}
			}
			else if (cb2.h()[0].cy().dh().a8())
			{
				gk obj = cn;
				cb a_3 = cb2;
				Guid a_4 = A_3;
				bool a_5 = !A_4;
				bool A_6 = false;
				obj.b(null, a_3, a_4, a_5, ref A_6);
			}
			else
			{
				fe.b(al, "Only internal users may send Composite Measurement Results to the Measurement Panel.", i6.a(a0()));
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_6 = ex2;
			al.c(fz.b.b, "Error trying to send selected measurement to meas module. Error is: ", a_6);
			fe.b(al, "Error trying to send selected measurement to measure.", i6.a(a0()));
			ProjectData.ClearProjectError();
		}
	}

	private bool a(string A_0, string A_1)
	{
		StreamReader streamReader = null;
		if (File.Exists(A_0))
		{
			string left;
			try
			{
				streamReader = new StreamReader(File.OpenRead(A_0));
				left = streamReader.ReadLine();
			}
			finally
			{
				streamReader.Close();
			}
			return Operators.CompareString(left, A_1, TextCompare: false) != 0;
		}
		return true;
	}

	private string a(int[] A_0, string A_1, hc A_2)
	{
		if (this.m_a9 == -1)
		{
			a(A_0);
			this.m_a9 = global::cc.cf(this.m_a7);
		}
		string text = null;
		string text2 = "Valid";
		h4 a_ = A_2.cy().ca();
		int num = this.m_a9;
		checked
		{
			int num2 = A_0.Length - 1;
			for (int num3 = num; num3 <= num2; num3++)
			{
				text = text + global::cc.cg(A_0[num3], A_1: true, a_, A_3: true) + A_1;
			}
			int num4 = this.m_a9 - 1;
			for (int num5 = 0; num5 <= num4; num5++)
			{
				text = ((A_0[num5] != 7) ? (text + global::cc.cg(A_0[num5], A_1: true, a_, A_3: true) + A_1) : (text + text2 + A_1));
			}
			if (!string.IsNullOrEmpty(text))
			{
				text.Remove(0, text.Length - 1);
			}
			return text;
		}
	}

	private void a(string A_0, bool A_1)
	{
		global::cc.cf(A_0, 2, this.m_aw, this.m_ay, this.m_a3, A_5: false, 0, ref this.m_b2);
		a(global::e.a().HistoryAutoSavePath, global::e.a().HistoryArchiveMaxDiskSpaceMB);
		if (global::e.a().HistoryArchiveClearAfterWrite && A_1)
		{
			lock (this.m_aw)
			{
				x();
				h();
				this.m_bt = true;
				this.m_bn = true;
				this.m_a8 = true;
				this.m_bs = true;
			}
		}
	}

	private void h()
	{
		this.m_bo.Clear();
		this.m_br.Clear();
		Collection<string> collection = this.m_br;
		string A_ = "IncludeAllChannels";
		collection.Add(hu.a(ref A_));
		this.m_bo.Add(this.m_bq);
		this.m_ax = this.m_aw;
	}

	private void a(string A_0, string A_1, bool A_2, int A_3)
	{
		Collection<hc> collection = c(A_1);
		Collection<cb> collection2 = new Collection<cb>();
		DateTime dateTime = DateTime.MaxValue;
		foreach (hc item in collection)
		{
			if (DateTime.Compare(item.cn().cb(), dateTime) < 0)
			{
				dateTime = item.cn().cb();
			}
		}
		if (this.m_ay != null && this.m_ay.Count > 0)
		{
			foreach (hc item2 in collection)
			{
				cb cb2 = a(item2);
				if (cb2 != null && !collection2.Contains(cb2))
				{
					collection2.Add(cb2);
				}
			}
		}
		DateTime a_ = dateTime;
		hc A_4 = null;
		global::cc.cf(A_0, 2, collection, collection2, a_, A_2, A_3, ref A_4);
	}

	private void b(string A_0)
	{
		Collection<hc> a_ = this.m_aw;
		Collection<cb> a_2 = this.m_ay;
		DateTime a_3 = this.m_a3;
		hc A_1 = null;
		global::cc.cf(A_0, 2, a_, a_2, a_3, A_5: false, 0, ref A_1);
	}

	private void g()
	{
		string text = null;
		BinaryWriter binaryWriter = null;
		try
		{
			text = i3.i() + "\\" + cz + c0;
			binaryWriter = new BinaryWriter(File.Open(text, FileMode.Create));
			i3.a(binaryWriter, a, 1, 1);
		}
		finally
		{
			binaryWriter.Close();
		}
	}

	private void a(BinaryWriter A_0)
	{
		BinaryWriter binaryWriter = A_0;
		if (cx == null || cx.Count == 0)
		{
			binaryWriter.Write(0);
		}
		else
		{
			binaryWriter.Write(cx.Count);
			foreach (d item in cx)
			{
				binaryWriter.Write((short)item.e);
				binaryWriter.Write(item.f);
				binaryWriter.Write(item.g);
			}
		}
		binaryWriter = null;
	}

	private void f()
	{
		string text = null;
		BinaryReader binaryReader = null;
		bool flag = default(bool);
		try
		{
			cx = new Collection<d>();
			text = i3.i() + "\\" + cz + c0;
			flag = File.Exists(text);
			if (flag)
			{
				binaryReader = new BinaryReader(File.Open(text, FileMode.Open, FileAccess.Read, FileShare.Read));
				i3.a(binaryReader, a, "ResGridParamOrder", 1);
			}
		}
		finally
		{
			if (flag)
			{
				binaryReader.Close();
			}
		}
	}

	private void a(BinaryReader A_0, int A_1)
	{
		BinaryReader binaryReader = A_0;
		int num = binaryReader.ReadInt32();
		if (num > 0)
		{
			int num2 = checked(num - 1);
			for (int num3 = 0; num3 <= num2; num3 = checked(num3 + 1))
			{
				d item = new d((d.ResGridColumnType)binaryReader.ReadInt16(), binaryReader.ReadInt32(), binaryReader.ReadBoolean());
				cx.Add(item);
			}
		}
		binaryReader = null;
	}

	private void e()
	{
		try
		{
			f();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			al.c(fz.b.b, "Error in FIControlPanelHistory.InitResGridParamOrder.", a_);
			cx.Clear();
			ProjectData.ClearProjectError();
		}
		if (cx.Count != 0)
		{
			return;
		}
		foreach (DataGridViewColumn column in a2().Columns)
		{
			cx.Add(new d(column, bd(), be()));
		}
	}

	private bool a(DataGridViewColumn A_0, ref d A_1)
	{
		foreach (d item in cx)
		{
			if (item.i(A_0, bd(), be()))
			{
				A_1 = item;
				return true;
			}
		}
		A_1 = null;
		return false;
	}

	public void b(string A_0, bool A_1)
	{
		BinaryReader binaryReader = null;
		int A_2 = 0;
		int A_3 = 0;
		bool flag = false;
		int num = -1;
		bool A_4 = false;
		checked
		{
			try
			{
				eo a_ = am.ut();
				binaryReader = new BinaryReader(File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read));
				long A_5 = default(long);
				int A_6 = default(int);
				DateTime A_7 = default(DateTime);
				global::cc.cf(binaryReader, ref A_5, ref A_3, ref A_2, ref A_6, ref A_7);
				if (2 >= A_2)
				{
					GC.Collect();
					GC.WaitForPendingFinalizers();
					Collection<hc> collection = new Collection<hc>();
					int num2 = A_6;
					bool flag2 = default(bool);
					for (int num3 = 0; num3 <= num2; num3++)
					{
						hc hc2 = new hc();
						hc2.cf(binaryReader, a_, hg.b4());
						collection.Add(hc2);
						if (this.m_a2 == null)
						{
							this.m_a2 = hc2.cn();
						}
						else if (DateTime.Compare(hc2.cn().cb(), this.m_a2.cb()) < 0)
						{
							this.m_a2 = hc2.cn();
							flag2 = true;
						}
					}
					if (this.m_a2 != null && (DateTime.Compare(this.m_a3, DateTime.MinValue) == 0 || DateTime.Compare(this.m_a3, this.m_a2.cb()) > 0))
					{
						this.m_a3 = this.m_a2.cb();
					}
					if (DateTime.Compare(A_7, this.m_a3) < 0 && DateTime.Compare(A_7, DateTime.MinValue) != 0)
					{
						this.m_a3 = A_7;
					}
					object obj = this.m_a0;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					bool lockTaken = false;
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						if (this.m_aw.Count > 0)
						{
							if (flag2)
							{
								Collection<hc> collection2 = this.m_aw;
								y();
								w();
								foreach (hc item in collection2)
								{
									bool A_8 = false;
									a(item, A_1: false, A_2: false, A_3: false, ref A_8);
								}
							}
							num = this.m_aw.IndexOf(this.m_b2);
							flag = this.m_aw.Count - 1 > num;
						}
					}
					finally
					{
						if (lockTaken)
						{
							Monitor.Exit(obj);
						}
					}
					foreach (hc item2 in collection)
					{
						a(item2, A_1, flag && !A_4, A_3: false, ref A_4);
					}
				}
				if (A_3 > 1)
				{
					int num4 = binaryReader.ReadInt32() - 1;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						cb cb2 = new cb();
						cb2.g(binaryReader);
						foreach (string item3 in cb2.i())
						{
							foreach (hc item4 in this.m_aw)
							{
								if (Operators.CompareString(item4.et(), item3, TextCompare: false) == 0)
								{
									cb2.h().Add(item4);
									break;
								}
							}
						}
						this.m_ay.Add(cb2);
					}
				}
				binaryReader.BaseStream.Seek(A_5, SeekOrigin.Begin);
			}
			finally
			{
				binaryReader.Close();
			}
		}
	}

	public void b3()
	{
		string text = i3.o() + "\\History";
		try
		{
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			if (ao)
			{
				b(text + "\\History.fibhi");
				g();
				global::e.a().HistoryLastSavedResultIdx = d();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			al.c(fz.b.b, "Exception caught in FIControlPanelHistory.Shutdown - trying to save history data", a_);
			ProjectData.ClearProjectError();
		}
	}

	public void b4()
	{
		string text = i3.o() + "\\History\\History.fibhi";
		if (File.Exists(text))
		{
			b(text, A_1: false);
			if (this.m_aw.Count > 0 && global::e.a().HistoryLastSavedResultIdx >= 0 && global::e.a().HistoryLastSavedResultIdx < this.m_aw.Count)
			{
				this.m_b2 = this.m_aw[global::e.a().HistoryLastSavedResultIdx];
			}
		}
	}

	public void b5()
	{
		cm.b(this.m_aw.Count);
	}

	private int d()
	{
		checked
		{
			if (global::e.a().HistoryArchiveAutomatically)
			{
				int num = this.m_aw.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					if (this.m_b2 == this.m_aw[num2])
					{
						return num2;
					}
				}
			}
			return -1;
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		try
		{
			if (this.m_bo != null && Operators.CompareString(this.m_bo[az().SelectedIndex], this.m_bp, TextCompare: false) != 0)
			{
				this.m_bp = this.m_bo[az().SelectedIndex];
				this.m_ax = c(this.m_bp);
				this.m_bs = true;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(al, am, null, i6.a(az()), "FIControlPanelHistory.ComboHistoryChannel_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(object A_0, DataGridViewCellMouseEventArgs A_1)
	{
		checked
		{
			try
			{
				if (A_1.Button != MouseButtons.Right)
				{
					return;
				}
				Point location = a2().GetCellDisplayRectangle(A_1.ColumnIndex, A_1.RowIndex, cutOverflow: true).Location;
				bi().Items.Clear();
				if (A_1.RowIndex >= 0 && a2().SelectedRows.Contains(a2().Rows[A_1.RowIndex]))
				{
					hc hc2 = null;
					hc2 = (hc)a2().Rows[A_1.RowIndex].Tag;
					if (hc2 == null)
					{
						throw new ApplicationException("The result was not found in the measurement collection");
					}
					f1 obj = am;
					hc a_ = hc2;
					bool A_2 = false;
					Guid A_3 = default(Guid);
					obj.m2(a_, ref A_3, ref A_2);
					if (am.ws(A_3))
					{
						bj().Enabled = false;
						bk().Enabled = false;
					}
					else
					{
						bj().Enabled = true;
						bk().Enabled = true;
						if (am.sm(A_3))
						{
							bj().Text = "Reprocess";
							bk().Text = "Delete and Reprocess";
						}
						else
						{
							bj().Text = "Reanalyze";
							bk().Text = "Delete and Reanalyze";
						}
					}
					foreach (ToolStripMenuItem item in this.m_b1)
					{
						bi().Items.Add(item);
					}
					if (!am.uj() || bz() == null)
					{
						bi().Items.Remove(bp());
					}
				}
				else
				{
					bi().Items.Add(bo());
				}
				bi().Show(a2(), location.X + A_1.X, location.Y + A_1.Y);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				i5.a(al, am, null, i6.a(az()), "FIControlPanelHistory.DataGridHistoryMeas_CellMouseUp", a_2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void a(object A_0, DataGridViewSortCompareEventArgs A_1)
	{
		DataGridViewSortCompareEventArgs e10 = A_1;
		string text = e10.CellValue1 as string;
		string text2 = e10.CellValue2 as string;
		switch ((cc.q)e10.Column.Tag)
		{
		case global::cc.q.b:
		{
			if (double.TryParse(text, out var result3) && double.TryParse(text2, out var result4))
			{
				if (result3 > result4)
				{
					e10.SortResult = 1;
				}
				else if (result3 == result4)
				{
					e10.SortResult = 0;
				}
				else
				{
					e10.SortResult = -1;
				}
				e10.Handled = true;
			}
			break;
		}
		case global::cc.q.a:
			e10.SortResult = jg.a(text.Trim(), text2.Trim());
			e10.Handled = true;
			break;
		case global::cc.q.c:
		{
			if (DateTime.TryParse(text, out var result) && DateTime.TryParse(text2, out var result2))
			{
				if (DateTime.Compare(result, result2) > 0)
				{
					e10.SortResult = 1;
				}
				else if (DateTime.Compare(result, result2) == 0)
				{
					e10.SortResult = 0;
				}
				else
				{
					e10.SortResult = -1;
				}
				e10.Handled = true;
			}
			break;
		}
		default:
			al.c(fz.b.b, "Unhandled ParamSortMode");
			break;
		}
		e10 = null;
	}

	private void e(object A_0, EventArgs A_1)
	{
		try
		{
			k(RuntimeHelpers.GetObjectValue(A_0), new EventArgs());
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(al, am, null, i6.a(az()), "FIControlPanelHistory.ResultsGridMenuItemDelete_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		try
		{
			List<hc> list = new List<hc>();
			foreach (DataGridViewRow selectedRow in a2().SelectedRows)
			{
				list.Add((hc)selectedRow.Tag);
			}
			bool a_ = true;
			foreach (hc item in list)
			{
				if (item.cn().cu().q() != null)
				{
					a_ = false;
					break;
				}
			}
			string A_2 = null;
			bp obj = new bp();
			obj.a(am.ui(), am.uq(), a_, ref A_2);
			if (obj.DialogResult == DialogResult.Cancel)
			{
				return;
			}
			ay ay2 = new ay();
			ay2.g(i3.d(global::e.a().LastOpenSaveExportTargetImportSourcePath));
			ay obj2 = ay2;
			string A_3 = "ExportSpectraTargetFolder";
			obj2.h(hu.a(ref A_3));
			if (ay2.g(base.Parent.Parent.Parent) != DialogResult.OK)
			{
				return;
			}
			global::e.a().LastOpenSaveExportTargetImportSourcePath = ay2.f();
			string a_2 = string.Empty;
			Collection<string> collection = null;
			Collection<string> collection2 = null;
			foreach (hc item2 in list)
			{
				hr hr2 = item2.cn();
				int num = 0;
				string text = string.Empty;
				string text2 = ((!string.IsNullOrEmpty(hr2.b5())) ? (ay2.f() + "\\" + i3.g(hr2.b5())) : (ay2.f() + "\\" + i3.g(this.m_aw.IndexOf(item2).ToString())));
				while (File.Exists(text2 + text + A_2))
				{
					num = checked(num + 1);
					text = "-" + num;
				}
				hr hr3 = hr2;
				if (hr3.bl() != null)
				{
					a_2 = hr3.bl().by();
				}
				if (hr3.c4() != null)
				{
					collection = new Collection<string>();
					collection2 = new Collection<string>();
					foreach (hr item3 in hr3.c4())
					{
						collection.Add(item3.by());
						if (item3.c3() != null)
						{
							collection2.Add(((hr)item3.c3()).by());
						}
						else
						{
							collection2.Add(null);
						}
					}
				}
				hr obj3 = hr3;
				A_3 = text2 + text + A_2;
				obj3.r(ref A_3, hr3.bz(), hr3.by(), a_2, collection, collection2, a8().gi().at(), global::e.a().UniformSpectrumDataPointSpacing, global::e.a().UniformSpectrumDataFinePointSpacing);
				hr3 = null;
			}
			ay2 = null;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_3 = ex2;
			i5.a(al, am, null, i6.a(az()), "FIControlPanelHistory.ResultsGridMenuItemExportSpectra", a_3);
			ProjectData.ClearProjectError();
		}
	}

	public void a(Point A_0)
	{
		b4 obj = new b4();
		obj.a(cx, am, this, al, A_0);
		if (obj.DialogResult == DialogResult.Cancel)
		{
			return;
		}
		if (cx.Count <= 2)
		{
			c();
			return;
		}
		d A_1 = null;
		bool a_ = p();
		foreach (DataGridViewColumn column in a2().Columns)
		{
			a(column, ref A_1);
			a(column, A_1.g, a_);
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			a(new Point(bi().Left, bi().Top));
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(al, am, null, i6.a(az()), "FIControlPanelHistory.ResultsGridMenuItemEditColumns", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void a(DataGridViewColumn A_0, bool A_1, bool A_2)
	{
		switch (new d(A_0, bd(), be()).h())
		{
		case f3.d.a.e:
			if (A_2)
			{
				A_0.Visible = !A_1;
			}
			else
			{
				A_0.Visible = false;
			}
			break;
		default:
			A_0.Visible = !A_1;
			break;
		case f3.d.a.d:
			break;
		}
	}

	private void c()
	{
		Collection<d> collection = new Collection<d>();
		DataGridView dataGridView = a2();
		checked
		{
			d[] array = new d[dataGridView.Columns.Count - 1 + 1];
			int num = dataGridView.Columns.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				array[num2] = new d(dataGridView.Columns[num2], bd(), be());
				collection.Add(array[num2]);
			}
			cx.Clear();
			cy = true;
			int num3 = dataGridView.Columns.Count - 1;
			for (int num2 = 0; num2 <= num3; num2++)
			{
				d d10 = f3.d.h(collection);
				collection.Remove(d10);
				cx.Add(d10);
				DataGridViewColumn dataGridViewColumn = dataGridView.Columns[Array.IndexOf(array, d10)];
				dataGridViewColumn.DisplayIndex = num2;
				if (d10.e > f3.d.ResGridColumnType.MMGuid)
				{
					dataGridViewColumn.Visible = true;
				}
			}
			cy = false;
			dataGridView = null;
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				string A_2;
				if (a2().SelectedRows.Count == 0)
				{
					fz a_ = al;
					A_2 = "HistoryNoRowSelectedError";
					fe.b(a_, hu.a(ref A_2), i6.a(a2()));
					return;
				}
				Collection<Guid> collection = new Collection<Guid>();
				Collection<gu.a> A_3 = null;
				List<int> list = new List<int>();
				this.m_bx.Clear();
				foreach (DataGridViewRow selectedRow in a2().SelectedRows)
				{
					hc item = (hc)selectedRow.Tag;
					int num = this.m_ax.IndexOf(item);
					bool flag = false;
					int num2 = list.Count - 1;
					for (int num3 = 0; num3 <= num2; num3++)
					{
						if (list[num3] >= num)
						{
							this.m_bx.Insert(num3, item);
							list.Insert(num3, num);
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						this.m_bx.Add(item);
						list.Add(num);
					}
				}
				bool A_4 = default(bool);
				foreach (hc item3 in this.m_bx)
				{
					Guid item2 = a(item3.c1(), ref A_4, ref A_3);
					if (!collection.Contains(item2))
					{
						collection.Add(item2);
						if (A_4)
						{
							fz a_2 = al;
							A_2 = "HistoryTargetRecipePromptFmt";
							fe.b(a_2, string.Format(hu.a(ref A_2), A_3[0].c), "Information", i6.a(a2()));
						}
					}
				}
				this.m_by = new c1();
				this.m_by.a(A_0: true);
				c1 obj = this.m_by;
				int count = this.m_bx.Count;
				A_2 = "HistoryReanalyzingMessage";
				obj.a(count, hu.a(ref A_2));
				if (A_0 == bk())
				{
					k(RuntimeHelpers.GetObjectValue(A_0), new EventArgs());
				}
				a(global::r.d.a.b.a);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				i5.a(al, am, null, i6.a(az()), "FIControlPanelHistory.ResultsGridMenuItemReanalyze_Click", a_3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private Guid a(string A_0)
	{
		bool A_1 = false;
		Collection<gu.a> A_2 = null;
		return a(A_0, ref A_1, ref A_2);
	}

	private Guid a(string A_0, ref bool A_1, ref Collection<gu.a> A_2)
	{
		am.m2(ref A_2);
		A_1 = A_2.Count > 1;
		foreach (gu.a item in A_2)
		{
			if (Operators.CompareString(A_0, item.a.ToString(), TextCompare: false) == 0)
			{
				A_1 = false;
				return item.a;
			}
		}
		return A_2[0].a;
	}

	private void a(r.d.a.b A_0)
	{
		hc obj = this.m_bx[0];
		this.m_bx.RemoveAt(0);
		hc hc2 = obj;
		Guid a_ = a(hc2.c1());
		hr a_2 = ((!hg.bu(hc2.cn(), am.wq(a_), am.sm(a_), am.sn(a_), A_4: false)) ? hc2.cn() : am.m2(a_.ToString(), hc2.cn(), 0, A_3: false, A_0, A_5: false));
		f1 obj2 = am;
		string a_3 = a_.ToString();
		string empty = string.Empty;
		string A_1 = string.Empty;
		obj2.m2(a_3, empty, ref A_1, bq(), null, a_2, global::e.a().DisplaySignificantDigits, global::r.d.a.b.a, A_8: true, A_9: true);
		hc2 = null;
	}

	private void a(r.d.a A_0)
	{
		if (this.m_bx.Count > 0)
		{
			if (this.m_by.DialogResult == DialogResult.Cancel)
			{
				this.m_bx.Clear();
				return;
			}
			this.m_by.b(checked(this.m_by.c().Maximum - this.m_bx.Count));
			a(A_0.a8());
		}
		else
		{
			this.m_by.i();
		}
	}

	private void b()
	{
		string text = "...";
		checked
		{
			if (global::e.a().HistoryConfirmBeforeDelete)
			{
				if (!a3().Text.EndsWith(text))
				{
					a3().Text += text;
				}
				if (ao && !a6().Text.EndsWith(text))
				{
					a6().Text += text;
				}
			}
			else
			{
				if (a3().Text.EndsWith(text))
				{
					a3().Text = a3().Text.Substring(0, a3().Text.Length - text.Length);
				}
				if (ao && a6().Text.EndsWith(text))
				{
					a6().Text = a6().Text.Substring(0, a6().Text.Length - text.Length);
				}
			}
		}
	}

	private bool a()
	{
		ref fz a_ = ref al;
		string A_ = "DeleteHistoryConfirmPrompt";
		string a_2 = hu.a(ref A_);
		A_ = "Yes";
		string a_3 = hu.a(ref A_);
		A_ = "No";
		string a_4 = hu.a(ref A_);
		Point a_5 = i6.a(this);
		A_ = "DontAskMeThisAgain";
		bool A_2 = default(bool);
		if (!fe.b(ref a_, a_2, "DeleteHistoryConfirmTitle", a_3, a_4, a_5, hu.a(ref A_), ref A_2))
		{
			return false;
		}
		global::e.a().HistoryConfirmBeforeDelete = !A_2;
		b();
		return true;
	}

	private void a(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				a7 a10 = new a7();
				ek ek2 = bz();
				a10.a(ek2, am, al, new Point(bi().Left, bi().Top));
				if (a10.DialogResult != DialogResult.OK)
				{
					return;
				}
				el el2 = a10.i();
				em em2 = a10.j();
				Collection<hc> collection = new Collection<hc>();
				ek A_2 = null;
				cp = true;
				DataGridView dataGridView = a2();
				int num = dataGridView.SelectedRows.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					collection.Add((hc)dataGridView.SelectedRows[num2].Tag);
					if (collection[num2] == null)
					{
						throw new Exception("Cannot find a result for the row.");
					}
				}
				if (el2 != null)
				{
					int num3 = collection.Count - 1;
					int A_4 = default(int);
					int A_5 = default(int);
					int A_6 = default(int);
					for (int num2 = 0; num2 <= num3; num2++)
					{
						b obj = co;
						hc a_ = collection[num2];
						List<ek> A_3 = null;
						obj.c(a_, ref A_2, ref A_4, ref A_5, ref A_6, ref A_3);
						if (A_2 == null)
						{
							A_4 = ek2.c.IndexOf(el2);
							A_5 = el2.b.IndexOf(em2);
							ek2.l(collection[num2].cn(), A_4, A_5);
							em2.b[em2.b.Count - 1].b = collection[num2];
							a(collection[num2], a2().Rows[dataGridView.Rows.IndexOf(dataGridView.SelectedRows[num2])]);
						}
						else
						{
							a(em2, el2, ek2, A_4, A_5, A_6, dataGridView.Rows.IndexOf(dataGridView.SelectedRows[num2]));
						}
					}
				}
				dataGridView = null;
				cp = false;
				o();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				i5.a(al, am, null, i6.a(az()), "FIControlPanelHistoryResultsGridMenuItemSetSampleAndLoc.Click", a_2);
				ProjectData.ClearProjectError();
			}
		}
	}
}
