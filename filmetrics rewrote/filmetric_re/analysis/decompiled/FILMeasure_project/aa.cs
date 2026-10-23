using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class aa : Form
{
	private IContainer m_a;

	[CompilerGenerated]
	private TableLayoutPanel m_b;

	[CompilerGenerated]
	private Button m_c;

	[CompilerGenerated]
	private DataGridView d;

	[CompilerGenerated]
	private Button e;

	[CompilerGenerated]
	private TextBox f;

	[CompilerGenerated]
	private CheckBox g;

	[CompilerGenerated]
	private GroupBox m_h;

	[CompilerGenerated]
	private ComboBox m_i;

	[CompilerGenerated]
	private Label j;

	[CompilerGenerated]
	private Label k;

	[CompilerGenerated]
	private Label l;

	[CompilerGenerated]
	private Label m;

	[CompilerGenerated]
	private Label n;

	[CompilerGenerated]
	private Label o;

	[CompilerGenerated]
	private Label p;

	[CompilerGenerated]
	private Label q;

	[CompilerGenerated]
	private Label r;

	[CompilerGenerated]
	private Button s;

	[CompilerGenerated]
	private GroupBox t;

	[CompilerGenerated]
	private Button u;

	[CompilerGenerated]
	private Label v;

	[CompilerGenerated]
	private Label w;

	[CompilerGenerated]
	private Label x;

	[CompilerGenerated]
	private Label y;

	[CompilerGenerated]
	private Label z;

	[CompilerGenerated]
	private Label m_aa;

	[CompilerGenerated]
	private Label ab;

	[CompilerGenerated]
	private Label ac;

	[CompilerGenerated]
	private Button m_ad;

	[CompilerGenerated]
	private ComboBox m_ae;

	[CompilerGenerated]
	private Label af;

	[CompilerGenerated]
	private Button m_ag;

	private fz m_ah;

	private f1 m_ai;

	private a4.a m_aj;

	private y m_ak;

	private y m_al;

	private string m_am;

	private int m_an;

	private int m_ao;

	private const short m_ap = 167;

	private const short m_aq = 110;

	private const int m_ar = 100;

	private const string m_as = "YI D1925";

	public aa()
	{
		this.m_am = "DialogColorCorrelation";
		h();
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
	private void h()
	{
		a(new TableLayoutPanel());
		a(new Button());
		a(new DataGridView());
		b(new Button());
		a(new TextBox());
		a(new CheckBox());
		a(new GroupBox());
		ad(new Button());
		b(new Label());
		c(new Label());
		h(new Label());
		i(new Label());
		ad(new Label());
		ae(new Label());
		ag(new Label());
		ah(new Label());
		a(new ComboBox());
		a(new Label());
		c(new Button());
		b(new GroupBox());
		ai(new Label());
		aj(new Label());
		ak(new Label());
		al(new Label());
		am(new Label());
		an(new Label());
		ao(new Label());
		ap(new Label());
		h(new Button());
		i(new Button());
		b(new ComboBox());
		aq(new Label());
		i().SuspendLayout();
		((ISupportInitialize)ae()).BeginInit();
		aj().SuspendLayout();
		av().SuspendLayout();
		SuspendLayout();
		i().Anchor = AnchorStyles.Bottom;
		i().ColumnCount = 1;
		i().ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		i().Controls.Add(ad(), 0, 0);
		i().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		i().Location = new Point(292, 575);
		i().Margin = new Padding(4);
		i().Name = "TableLayoutPanel1";
		i().RowCount = 1;
		i().RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
		i().Size = new Size(195, 36);
		i().TabIndex = 0;
		ad().Anchor = AnchorStyles.None;
		ad().DialogResult = DialogResult.Cancel;
		ad().Location = new Point(53, 4);
		ad().Margin = new Padding(4);
		ad().Name = "OK_Button";
		ad().Size = new Size(89, 28);
		ad().TabIndex = 0;
		ad().Text = "Close";
		ad().UseVisualStyleBackColor = true;
		ae().AllowUserToAddRows = false;
		ae().AllowUserToDeleteRows = false;
		ae().AllowUserToResizeColumns = false;
		ae().AllowUserToResizeRows = false;
		ae().ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		ae().EnableHeadersVisualStyles = false;
		ae().Location = new Point(13, 171);
		ae().Margin = new Padding(4, 3, 4, 3);
		ae().Name = "DataGridCorrelation";
		ae().RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		ae().Size = new Size(446, 387);
		ae().TabIndex = 66;
		ag().Cursor = Cursors.Default;
		ag().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ag().ForeColor = SystemColors.ControlText;
		ag().Location = new Point(238, 133);
		ag().Margin = new Padding(4, 3, 4, 3);
		ag().Name = "btnDeleteGrid";
		ag().RightToLeft = RightToLeft.No;
		ag().Size = new Size(136, 31);
		ag().TabIndex = 64;
		ag().Text = "Delete Row";
		ag().UseVisualStyleBackColor = true;
		ah().AcceptsReturn = true;
		ah().Cursor = Cursors.IBeam;
		ah().Enabled = false;
		ah().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ah().ForeColor = SystemColors.WindowText;
		ah().Location = new Point(13, 12);
		ah().Margin = new Padding(4, 3, 4, 3);
		ah().MaxLength = 0;
		ah().Multiline = true;
		ah().Name = "Text2";
		ah().RightToLeft = RightToLeft.No;
		ah().Size = new Size(448, 61);
		ah().TabIndex = 63;
		ah().Text = "          Target Param. (Y) = Measured Param. (X) * A + B\r\nUse various samples with significant difference in color for \r\nbetter coefficient calculation.\r\n";
		ai().AutoSize = true;
		ai().Cursor = Cursors.Default;
		ai().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ai().ForeColor = SystemColors.ControlText;
		ai().Location = new Point(526, 14);
		ai().Margin = new Padding(4, 3, 4, 3);
		ai().Name = "ckUseCorrCoef";
		ai().RightToLeft = RightToLeft.No;
		ai().Size = new Size(192, 20);
		ai().TabIndex = 62;
		ai().Text = "Use Correlative Coefficients";
		ai().UseVisualStyleBackColor = false;
		aj().Controls.Add(a8());
		aj().Controls.Add(am());
		aj().Controls.Add(an());
		aj().Controls.Add(ao());
		aj().Controls.Add(ap());
		aj().Controls.Add(aq());
		aj().Controls.Add(ar());
		aj().Controls.Add(@as());
		aj().Controls.Add(at());
		aj().ForeColor = SystemColors.ControlText;
		aj().Location = new Point(469, 119);
		aj().Margin = new Padding(4, 3, 4, 3);
		aj().Name = "Frame2";
		aj().Padding = new Padding(4, 3, 4, 3);
		aj().RightToLeft = RightToLeft.No;
		aj().Size = new Size(299, 173);
		aj().TabIndex = 61;
		aj().TabStop = false;
		aj().Text = "Current Correlative Coefficients";
		a8().Cursor = Cursors.Default;
		a8().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a8().ForeColor = SystemColors.ControlText;
		a8().Location = new Point(33, 126);
		a8().Margin = new Padding(4, 3, 4, 3);
		a8().Name = "ButtonClearSelectedCoeffs";
		a8().RightToLeft = RightToLeft.No;
		a8().Size = new Size(240, 38);
		a8().TabIndex = 25;
		a8().Text = "Clear Selected Coefficients";
		a8().UseVisualStyleBackColor = true;
		am().BorderStyle = BorderStyle.Fixed3D;
		am().Cursor = Cursors.Default;
		am().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		am().ForeColor = SystemColors.ControlText;
		am().Location = new Point(121, 24);
		am().Margin = new Padding(4, 0, 4, 0);
		am().Name = "lblCurrentMin";
		am().RightToLeft = RightToLeft.No;
		am().Size = new Size(160, 21);
		am().TabIndex = 24;
		an().BorderStyle = BorderStyle.Fixed3D;
		an().Cursor = Cursors.Default;
		an().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		an().ForeColor = SystemColors.ControlText;
		an().Location = new Point(121, 48);
		an().Margin = new Padding(4, 0, 4, 0);
		an().Name = "lblCurrentMax";
		an().RightToLeft = RightToLeft.No;
		an().Size = new Size(157, 21);
		an().TabIndex = 23;
		ao().Cursor = Cursors.Default;
		ao().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ao().ForeColor = SystemColors.ControlText;
		ao().Location = new Point(17, 48);
		ao().Margin = new Padding(4, 0, 4, 0);
		ao().Name = "Label12";
		ao().RightToLeft = RightToLeft.No;
		ao().Size = new Size(101, 19);
		ao().TabIndex = 22;
		ao().Text = "Meas. Max:";
		ap().Cursor = Cursors.Default;
		ap().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ap().ForeColor = SystemColors.ControlText;
		ap().Location = new Point(17, 24);
		ap().Margin = new Padding(4, 0, 4, 0);
		ap().Name = "Label10";
		ap().RightToLeft = RightToLeft.No;
		ap().Size = new Size(101, 19);
		ap().TabIndex = 21;
		ap().Text = "Meas. Min:";
		aq().Cursor = Cursors.Default;
		aq().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aq().ForeColor = SystemColors.ControlText;
		aq().Location = new Point(21, 75);
		aq().Margin = new Padding(4, 0, 4, 0);
		aq().Name = "Label9";
		aq().RightToLeft = RightToLeft.No;
		aq().Size = new Size(115, 17);
		aq().TabIndex = 20;
		aq().Text = "Coefficient A:";
		ar().BorderStyle = BorderStyle.Fixed3D;
		ar().Cursor = Cursors.Default;
		ar().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ar().ForeColor = SystemColors.ControlText;
		ar().Location = new Point(20, 97);
		ar().Margin = new Padding(4, 0, 4, 0);
		ar().Name = "lblCurrentCoefA";
		ar().RightToLeft = RightToLeft.No;
		ar().Size = new Size(116, 21);
		ar().TabIndex = 19;
		@as().Cursor = Cursors.Default;
		@as().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		@as().ForeColor = SystemColors.ControlText;
		@as().Location = new Point(167, 75);
		@as().Margin = new Padding(4, 0, 4, 0);
		@as().Name = "Label4";
		@as().RightToLeft = RightToLeft.No;
		@as().Size = new Size(115, 19);
		@as().TabIndex = 18;
		@as().Text = "Coefficient B:";
		at().BorderStyle = BorderStyle.Fixed3D;
		at().Cursor = Cursors.Default;
		at().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		at().ForeColor = SystemColors.ControlText;
		at().Location = new Point(167, 97);
		at().Margin = new Padding(4, 0, 4, 0);
		at().Name = "lblCurrentCoefB";
		at().RightToLeft = RightToLeft.No;
		at().Size = new Size(121, 21);
		at().TabIndex = 17;
		ak().DropDownStyle = ComboBoxStyle.DropDownList;
		ak().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ak().FormattingEnabled = true;
		ak().Location = new Point(570, 63);
		ak().Margin = new Padding(4, 3, 4, 3);
		ak().Name = "ComboDisplayedParamInfo";
		ak().Size = new Size(198, 24);
		ak().TabIndex = 45;
		al().AutoSize = true;
		al().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		al().Location = new Point(466, 67);
		al().Margin = new Padding(4, 0, 4, 0);
		al().Name = "LabelParams";
		al().Size = new Size(102, 16);
		al().TabIndex = 44;
		al().Text = "Display Info for: ";
		au().Cursor = Cursors.Default;
		au().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		au().ForeColor = SystemColors.ControlText;
		au().Location = new Point(104, 133);
		au().Margin = new Padding(4, 3, 4, 3);
		au().Name = "btnAddGrid";
		au().RightToLeft = RightToLeft.No;
		au().Size = new Size(125, 31);
		au().TabIndex = 60;
		au().Text = "Add Row";
		au().UseVisualStyleBackColor = true;
		av().Controls.Add(ax());
		av().Controls.Add(ay());
		av().Controls.Add(az());
		av().Controls.Add(a0());
		av().Controls.Add(a1());
		av().Controls.Add(a2());
		av().Controls.Add(a3());
		av().Controls.Add(a4());
		av().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		av().ForeColor = SystemColors.ControlText;
		av().Location = new Point(469, 309);
		av().Margin = new Padding(4, 3, 4, 3);
		av().Name = "Frame1";
		av().Padding = new Padding(4, 3, 4, 3);
		av().RightToLeft = RightToLeft.No;
		av().Size = new Size(299, 131);
		av().TabIndex = 58;
		av().TabStop = false;
		av().Text = "Updated Correlative Coefficients";
		ax().BorderStyle = BorderStyle.Fixed3D;
		ax().Cursor = Cursors.Default;
		ax().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ax().ForeColor = SystemColors.ControlText;
		ax().Location = new Point(124, 50);
		ax().Margin = new Padding(4, 0, 4, 0);
		ax().Name = "lblCalcMax";
		ax().RightToLeft = RightToLeft.No;
		ax().Size = new Size(140, 21);
		ax().TabIndex = 15;
		ax().Text = "0";
		ay().Cursor = Cursors.Default;
		ay().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ay().ForeColor = SystemColors.ControlText;
		ay().Location = new Point(20, 48);
		ay().Margin = new Padding(4, 0, 4, 0);
		ay().Name = "Label6";
		ay().RightToLeft = RightToLeft.No;
		ay().Size = new Size(104, 19);
		ay().TabIndex = 14;
		ay().Text = "Meas. Max:";
		az().BorderStyle = BorderStyle.Fixed3D;
		az().Cursor = Cursors.Default;
		az().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		az().ForeColor = SystemColors.ControlText;
		az().Location = new Point(125, 25);
		az().Margin = new Padding(4, 0, 4, 0);
		az().Name = "lblCalcMin";
		az().RightToLeft = RightToLeft.No;
		az().Size = new Size(140, 21);
		az().TabIndex = 13;
		az().Text = "9999999";
		a0().Cursor = Cursors.Default;
		a0().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a0().ForeColor = SystemColors.ControlText;
		a0().Location = new Point(21, 25);
		a0().Margin = new Padding(4, 0, 4, 0);
		a0().Name = "Label3";
		a0().RightToLeft = RightToLeft.No;
		a0().Size = new Size(96, 19);
		a0().TabIndex = 12;
		a0().Text = "Meas. Min:";
		a1().BorderStyle = BorderStyle.Fixed3D;
		a1().Cursor = Cursors.Default;
		a1().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a1().ForeColor = SystemColors.ControlText;
		a1().Location = new Point(167, 98);
		a1().Margin = new Padding(4, 0, 4, 0);
		a1().Name = "lblCalcCoefB";
		a1().RightToLeft = RightToLeft.No;
		a1().Size = new Size(115, 21);
		a1().TabIndex = 11;
		a2().Cursor = Cursors.Default;
		a2().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a2().ForeColor = SystemColors.ControlText;
		a2().Location = new Point(167, 77);
		a2().Margin = new Padding(4, 0, 4, 0);
		a2().Name = "Label7";
		a2().RightToLeft = RightToLeft.No;
		a2().Size = new Size(115, 19);
		a2().TabIndex = 10;
		a2().Text = "Coefficient B:";
		a2().TextAlign = ContentAlignment.MiddleCenter;
		a3().BorderStyle = BorderStyle.Fixed3D;
		a3().Cursor = Cursors.Default;
		a3().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a3().ForeColor = SystemColors.ControlText;
		a3().Location = new Point(20, 98);
		a3().Margin = new Padding(4, 0, 4, 0);
		a3().Name = "lblCalcCoefA";
		a3().RightToLeft = RightToLeft.No;
		a3().Size = new Size(115, 21);
		a3().TabIndex = 9;
		a4().Cursor = Cursors.Default;
		a4().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a4().ForeColor = SystemColors.ControlText;
		a4().Location = new Point(20, 77);
		a4().Margin = new Padding(4, 0, 4, 0);
		a4().Name = "Label5";
		a4().RightToLeft = RightToLeft.No;
		a4().Size = new Size(119, 19);
		a4().TabIndex = 8;
		a4().Text = "Coefficient A:";
		a4().TextAlign = ContentAlignment.MiddleCenter;
		aw().Cursor = Cursors.Default;
		aw().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aw().ForeColor = SystemColors.ControlText;
		aw().Location = new Point(469, 458);
		aw().Margin = new Padding(4, 3, 4, 3);
		aw().Name = "btnCalcCoef";
		aw().RightToLeft = RightToLeft.No;
		aw().Size = new Size(299, 45);
		aw().TabIndex = 7;
		aw().Text = "Calculate Coefficients";
		aw().UseVisualStyleBackColor = true;
		a5().Cursor = Cursors.Default;
		a5().Enabled = false;
		a5().Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a5().ForeColor = SystemColors.ControlText;
		a5().Location = new Point(469, 514);
		a5().Margin = new Padding(4, 3, 4, 3);
		a5().Name = "btnApply";
		a5().RightToLeft = RightToLeft.No;
		a5().Size = new Size(299, 45);
		a5().TabIndex = 57;
		a5().Text = "Apply Updated Coefficients";
		a5().UseVisualStyleBackColor = true;
		a6().DropDownStyle = ComboBoxStyle.DropDownList;
		a6().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a6().FormattingEnabled = true;
		a6().Location = new Point(234, 94);
		a6().Margin = new Padding(4, 3, 4, 3);
		a6().Name = "ComboMeasuredParam";
		a6().Size = new Size(183, 24);
		a6().TabIndex = 68;
		a7().AutoSize = true;
		a7().Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		a7().Location = new Point(53, 97);
		a7().Margin = new Padding(4, 0, 4, 0);
		a7().Name = "Label1";
		a7().Size = new Size(179, 16);
		a7().TabIndex = 67;
		a7().Text = "Select Measured Parameter:";
		base.AcceptButton = ad();
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = SystemColors.Window;
		base.CancelButton = ad();
		base.ClientSize = new Size(779, 626);
		base.Controls.Add(aw());
		base.Controls.Add(a6());
		base.Controls.Add(a7());
		base.Controls.Add(ak());
		base.Controls.Add(al());
		base.Controls.Add(ae());
		base.Controls.Add(ag());
		base.Controls.Add(ah());
		base.Controls.Add(ai());
		base.Controls.Add(aj());
		base.Controls.Add(au());
		base.Controls.Add(av());
		base.Controls.Add(a5());
		base.Controls.Add(i());
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogColorCorrelation";
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Color Correlation";
		i().ResumeLayout(performLayout: false);
		((ISupportInitialize)ae()).EndInit();
		aj().ResumeLayout(performLayout: false);
		av().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual TableLayoutPanel i()
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
	internal virtual Button ad()
	{
		return this.m_c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Button A_0)
	{
		EventHandler value = ae;
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
	internal virtual DataGridView ae()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(DataGridView A_0)
	{
		d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ag()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b(Button A_0)
	{
		EventHandler value = i;
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
	public virtual TextBox ah()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a(TextBox A_0)
	{
		f = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual CheckBox ai()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a(CheckBox A_0)
	{
		g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox aj()
	{
		return this.m_h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void a(GroupBox A_0)
	{
		this.m_h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox ak()
	{
		return this.m_i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(ComboBox A_0)
	{
		EventHandler value = c;
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
	internal virtual Label al()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void a(Label A_0)
	{
		j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label am()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b(Label A_0)
	{
		k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label an()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c(Label A_0)
	{
		l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ao()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void h(Label A_0)
	{
		m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ap()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void i(Label A_0)
	{
		n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label aq()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ad(Label A_0)
	{
		o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ar()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ae(Label A_0)
	{
		p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label @as()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ag(Label A_0)
	{
		q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label at()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ah(Label A_0)
	{
		r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button au()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void c(Button A_0)
	{
		EventHandler value = ad;
		Button button = s;
		if (button != null)
		{
			button.Click -= value;
		}
		s = A_0;
		button = s;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox av()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void b(GroupBox A_0)
	{
		t = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button aw()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void h(Button A_0)
	{
		EventHandler value = h;
		Button button = u;
		if (button != null)
		{
			button.Click -= value;
		}
		u = A_0;
		button = u;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ax()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ai(Label A_0)
	{
		v = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ay()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aj(Label A_0)
	{
		w = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label az()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ak(Label A_0)
	{
		x = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label a0()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void al(Label A_0)
	{
		y = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label a1()
	{
		return z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void am(Label A_0)
	{
		z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label a2()
	{
		return m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void an(Label A_0)
	{
		m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label a3()
	{
		return ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ao(Label A_0)
	{
		ab = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label a4()
	{
		return ac;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ap(Label A_0)
	{
		ac = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button a5()
	{
		return this.m_ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void i(Button A_0)
	{
		EventHandler value = a;
		Button button = this.m_ad;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ad = A_0;
		button = this.m_ad;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual ComboBox a6()
	{
		return this.m_ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void b(ComboBox A_0)
	{
		this.m_ae = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label a7()
	{
		return af;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void aq(Label A_0)
	{
		af = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button a8()
	{
		return this.m_ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ad(Button A_0)
	{
		EventHandler value = b;
		Button button = this.m_ag;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_ag = A_0;
		button = this.m_ag;
		if (button != null)
		{
			button.Click += value;
		}
	}

	public void a(fz A_0, f1 A_1, a4.a A_2, bool A_3, y A_4)
	{
		this.m_ah = A_0;
		this.m_ai = A_1;
		this.m_aj = A_2;
		this.m_ak = A_4;
		ae().RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
		ae().RowHeadersWidth = 110;
		ae().MultiSelect = false;
		ae().SelectionMode = DataGridViewSelectionMode.CellSelect;
		ae().Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular);
		DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
		DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
		dataGridViewButtonColumn.HeaderText = "X:Meas. Param.";
		dataGridViewButtonColumn.Name = "ColorParam-X";
		dataGridViewButtonColumn.Width = 167;
		dataGridViewButtonColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		_ = null;
		ae().Columns.Add(dataGridViewButtonColumn);
		dataGridViewButtonColumn2.HeaderText = "Y:Target Param.";
		dataGridViewButtonColumn2.Name = "ColorParam-Y";
		dataGridViewButtonColumn2.Width = 167;
		dataGridViewButtonColumn2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		_ = null;
		ae().Columns.Add(dataGridViewButtonColumn2);
		string A_5 = null;
		string A_6 = null;
		string A_7 = null;
		hg.bu(this.m_aj, ref A_5, ref A_6, ref A_7);
		a6().Items.Add(A_5);
		a6().Items.Add(A_6);
		a6().Items.Add(A_7);
		a6().Items.Add("All " + global::a4.a(this.m_aj));
		ak().Items.Add(A_5);
		ak().Items.Add(A_6);
		ak().Items.Add(A_7);
		if (A_3)
		{
			hg.bu(global::a4.a.d, ref A_5, ref A_6, ref A_7);
			a6().Items.Add(A_5);
			a6().Items.Add(A_6);
			a6().Items.Add(A_7);
			a6().Items.Add("All " + global::a4.a(global::a4.a.d));
			ak().Items.Add(A_5);
			ak().Items.Add(A_6);
			ak().Items.Add(A_7);
		}
		a6().Items.Add("YI D1925");
		checked
		{
			this.m_an = a6().Items.Count - 1;
			ak().Items.Add("YI D1925");
			this.m_ao = ak().Items.Count - 1;
			a6().SelectedIndex = 0;
			ak().SelectedIndex = 0;
			ai().Checked = this.m_ak.b;
			ShowDialog();
			if (base.DialogResult == DialogResult.OK && this.m_ak.b != ai().Checked)
			{
				this.m_ak.b = ai().Checked;
				this.m_ak.c();
			}
		}
	}

	private void a(u.a A_0, a4.a A_1, int A_2)
	{
		DataGridViewRow dataGridViewRow = new DataGridViewRow();
		DataGridViewCell dataGridViewCell = new DataGridViewTextBoxCell();
		dataGridViewCell.Value = "";
		dataGridViewRow.Cells.Add(dataGridViewCell);
		dataGridViewCell = new DataGridViewTextBoxCell();
		dataGridViewCell.Value = "";
		dataGridViewRow.Cells.Add(dataGridViewCell);
		dataGridViewRow.Tag = new u(A_0, A_1, A_2);
		ae().Rows.Add(dataGridViewRow);
		a();
	}

	private float a(int A_0, int A_1, ref bool A_2)
	{
		DataGridViewCell dataGridViewCell = ae().Rows[A_0].Cells[A_1];
		string text = dataGridViewCell.EditedFormattedValue.ToString();
		if (!jg.b(text))
		{
			if (!string.IsNullOrEmpty(text))
			{
				dataGridViewCell.ErrorText = "This cell must contain a number.";
			}
			A_2 = true;
		}
		else
		{
			dataGridViewCell.ErrorText = string.Empty;
		}
		return iz.d(text);
	}

	private List<w> c()
	{
		bool A_ = false;
		List<u> list = new List<u>();
		checked
		{
			int num = ae().Rows.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				u item = (u)ae().Rows[num2].Tag;
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
			List<w> list2 = new List<w>();
			foreach (u item2 in list)
			{
				w w2 = new w(item2);
				list2.Add(w2);
				int num3 = ae().Rows.Count - 1;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					if (global::u.d((u)ae().Rows[num4].Tag, item2))
					{
						float a_ = a(num4, 0, ref A_);
						float a_2 = a(num4, 1, ref A_);
						w2.b.Add(new v(a_, a_2));
					}
				}
			}
			if (A_)
			{
				return null;
			}
			return list2;
		}
	}

	private u b()
	{
		if (ak().SelectedIndex == this.m_ao)
		{
			return new u(global::u.a.b, global::a4.a.a, 0);
		}
		a4.a a_ = ((ak().SelectedIndex >= 3) ? global::a4.a.d : this.m_aj);
		return new u(global::u.a.a, a_, ak().SelectedIndex % 3);
	}

	private void a(Label A_0, Label A_1, Label A_2, Label A_3, y A_4)
	{
		x x2 = null;
		if (A_4 != null)
		{
			u a_ = b();
			foreach (x item in A_4.a)
			{
				if (global::u.d(item.a, a_))
				{
					x2 = item;
					break;
				}
			}
		}
		if (x2 != null)
		{
			A_2.Text = x2.d.ToString();
			A_3.Text = x2.e.ToString();
			A_0.Text = x2.b.ToString();
			A_1.Text = x2.c.ToString();
			a8().Enabled = true;
		}
		else
		{
			a8().Enabled = false;
			A_2.Text = "None";
			A_3.Text = "None";
			A_0.Text = null;
			A_1.Text = null;
		}
	}

	private void a()
	{
		checked
		{
			int num = ae().RowCount - 1;
			a4.a a10 = default(a4.a);
			int num3 = default(int);
			for (int num2 = 0; num2 <= num; num2++)
			{
				DataGridViewRow dataGridViewRow = ae().Rows[num2];
				u u2 = (u)dataGridViewRow.Tag;
				string text;
				bool flag;
				if (u2.a == global::u.a.b)
				{
					text = "YI D1925";
					flag = true;
				}
				else
				{
					string A_ = null;
					string A_2 = null;
					string A_3 = null;
					a10 = u2.b;
					num3 = u2.c;
					hg.bu(a10, ref A_, ref A_2, ref A_3);
					text = num3 switch
					{
						0 => A_, 
						1 => A_2, 
						_ => A_3, 
					};
					flag = false;
				}
				u2 = null;
				int num4 = 0;
				int num5 = num2 - 1;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					u u3 = (u)ae().Rows[num6].Tag;
					if (flag)
					{
						if (u3.a == global::u.a.b)
						{
							num4++;
						}
					}
					else if (u3.a == global::u.a.a && u3.b == a10 && u3.c == num3)
					{
						num4++;
					}
					u3 = null;
				}
				dataGridViewRow.HeaderCell.Value = text + " " + (num4 + 1);
			}
		}
	}

	private void ae(object A_0, EventArgs A_1)
	{
		base.DialogResult = DialogResult.OK;
	}

	private void ad(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				int num = 1;
				if (a6().SelectedIndex == this.m_an)
				{
					if (ae().RowCount + num <= 100)
					{
						a(global::u.a.b, global::a4.a.a, 0);
					}
					else
					{
						fe.b(this.m_ah, "Maximum number of measurements is" + Conversion.Str(100), new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
					}
					return;
				}
				if (unchecked(a6().SelectedIndex % 4) == 3)
				{
					num = 3;
				}
				if (ae().RowCount + num <= 100)
				{
					a4.a a_ = ((a6().SelectedIndex <= 3) ? this.m_aj : global::a4.a.d);
					if (num > 1)
					{
						int num2 = num - 1;
						for (int num3 = 0; num3 <= num2; num3++)
						{
							a(global::u.a.a, a_, num3);
						}
					}
					else
					{
						a(global::u.a.a, a_, unchecked(a6().SelectedIndex % 4));
					}
				}
				else
				{
					fe.b(this.m_ah, "Maximum number of measurements is" + Conversion.Str(100), new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				i5.a(this.m_ah, this.m_ai, null, i6.a(this), this.m_am + ".btnAddGrid_Click", a_2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void i(object A_0, EventArgs A_1)
	{
		try
		{
			if (ae().SelectedCells.Count > 0)
			{
				ae().Rows.RemoveAt(ae().SelectedCells[0].RowIndex);
				a();
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_ah, this.m_ai, null, i6.a(this), this.m_am + ".btnDeleteGrid_Click", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				List<w> list = c();
				if (list == null)
				{
					return;
				}
				this.m_al = new y();
				double A_2 = default(double);
				double A_3 = default(double);
				foreach (w item in list)
				{
					double[] array = new double[item.b.Count - 1 + 1];
					double[] array2 = new double[item.b.Count - 1 + 1];
					double num = double.MaxValue;
					double num2 = double.MinValue;
					int num3 = item.b.Count - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						array[num4] = item.b[num4].a;
						if (array[num4] < num)
						{
							num = array[num4];
						}
						else if (array[num4] > num2)
						{
							num2 = array[num4];
						}
						array2[num4] = item.b[num4].b;
					}
					jf.a(array, array2, item.b.Count, ref A_2, ref A_3);
					this.m_al.a.Add(new x(item.a, (float)num, (float)num2, (float)A_3, (float)A_2));
				}
				a5().Enabled = true;
				a(az(), ax(), a3(), a1(), this.m_al);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_ah, this.m_ai, null, i6.a(this), this.m_am + ".btnCalcCoef_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		try
		{
			a(az(), ax(), a3(), a1(), this.m_al);
			a(am(), an(), ar(), at(), this.m_ak);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(this.m_ah, this.m_ai, null, i6.a(this), this.m_am + ".ComboDisplayedParamInfo_SelectedIndexChanged", a_);
			ProjectData.ClearProjectError();
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				int num = -1;
				if (this.m_ak == null)
				{
					return;
				}
				u a_ = b();
				int num2 = this.m_ak.a.Count - 1;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					if (global::u.d(this.m_ak.a[num3].a, a_))
					{
						num = num3;
						break;
					}
				}
				if (num > -1)
				{
					this.m_ak.a.RemoveAt(num);
					a(am(), an(), ar(), at(), this.m_ak);
					this.m_ak.c();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_2 = ex2;
				i5.a(this.m_ah, this.m_ai, null, i6.a(this), this.m_am + ".ButtonClearSelectedCoeffs_Click", a_2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (this.m_al != null)
				{
					foreach (x item in this.m_al.a)
					{
						int num = this.m_ak.a.Count - 1;
						for (int num2 = 0; num2 <= num; num2++)
						{
							if (global::u.d(this.m_ak.a[num2].a, item.a))
							{
								this.m_ak.a.RemoveAt(num2);
								break;
							}
						}
						this.m_ak.a.Add(item);
					}
					this.m_al.a.Clear();
					ai().Checked = true;
					this.m_ak.b = true;
					this.m_ak.c();
					a(az(), ax(), a3(), a1(), this.m_al);
					a(am(), an(), ar(), at(), this.m_ak);
				}
				a5().Enabled = false;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				i5.a(this.m_ah, this.m_ai, null, i6.a(this), this.m_am + ".btnApply_Click", a_);
				ProjectData.ClearProjectError();
			}
		}
	}
}
