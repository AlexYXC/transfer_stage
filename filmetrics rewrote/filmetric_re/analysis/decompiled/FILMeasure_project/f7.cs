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
internal class f7 : Form
{
	private enum a
	{
		a,
		b,
		c,
		d
	}

	private IContainer m_a;

	public ToolTip b;

	public SaveFileDialog c;

	[CompilerGenerated]
	private Button d;

	[CompilerGenerated]
	private Button e;

	[CompilerGenerated]
	private RadioButton f;

	[CompilerGenerated]
	private Button g;

	[CompilerGenerated]
	private Button h;

	[CompilerGenerated]
	private Button i;

	[CompilerGenerated]
	private RadioButton j;

	[CompilerGenerated]
	private RadioButton k;

	[CompilerGenerated]
	private RadioButton l;

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
	private GroupBox m_s;

	[CompilerGenerated]
	private PictureBox m_t;

	[CompilerGenerated]
	private Panel u;

	[CompilerGenerated]
	private Button v;

	[CompilerGenerated]
	private Button w;

	[CompilerGenerated]
	private Button x;

	[CompilerGenerated]
	private Button m_y;

	[CompilerGenerated]
	private Label m_z;

	[CompilerGenerated]
	private Label m_aa;

	[CompilerGenerated]
	private Label ab;

	private fz m_ac;

	private f1 m_ad;

	private gq m_ae;

	private f4 m_af;

	private e4 m_ag;

	private a m_ah;

	private string m_ai;

	private bool m_aj;

	private bool m_ak;

	private short m_al;

	private string m_am;

	private bool m_an;

	private bool m_ao;

	private bool m_ap;

	private float m_aq;

	private float m_ar;

	private bool m_as;

	private bool m_at;

	private bool m_au;

	private string m_av;

	private bool m_aw;

	private const float m_ax = 4f;

	private const float m_ay = 300f;

	private const float m_az = 415f;

	private const short m_a0 = 5;

	private const short a1 = 100;

	[DebuggerNonUserCode]
	public f7(fz A_0)
	{
		base.Activated += s;
		z();
		this.m_ac = A_0;
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool Disposing)
	{
		if (Disposing && this.m_a != null)
		{
			this.m_a.Dispose();
		}
		base.Dispose(Disposing);
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button aa()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void s(Button A_0)
	{
		EventHandler value = ak;
		Button button = d;
		if (button != null)
		{
			button.Click -= value;
		}
		d = A_0;
		button = d;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ac()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void t(Button A_0)
	{
		EventHandler value = am;
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
	public virtual RadioButton ad()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void s(RadioButton A_0)
	{
		EventHandler value = z;
		RadioButton radioButton = f;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		f = A_0;
		radioButton = f;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ae()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void y(Button A_0)
	{
		EventHandler value = aj;
		Button button = g;
		if (button != null)
		{
			button.Click -= value;
		}
		g = A_0;
		button = g;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button af()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void z(Button A_0)
	{
		EventHandler value = ai;
		Button button = h;
		if (button != null)
		{
			button.Click -= value;
		}
		h = A_0;
		button = h;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button ag()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aa(Button A_0)
	{
		EventHandler value = al;
		Button button = i;
		if (button != null)
		{
			button.Click -= value;
		}
		i = A_0;
		button = i;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton ah()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void t(RadioButton A_0)
	{
		EventHandler value = t;
		RadioButton radioButton = j;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		j = A_0;
		radioButton = j;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton ai()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void y(RadioButton A_0)
	{
		EventHandler value = aa;
		RadioButton radioButton = k;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		k = A_0;
		radioButton = k;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual RadioButton aj()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void z(RadioButton A_0)
	{
		EventHandler value = y;
		RadioButton radioButton = l;
		if (radioButton != null)
		{
			radioButton.CheckedChanged -= value;
		}
		l = A_0;
		radioButton = l;
		if (radioButton != null)
		{
			radioButton.CheckedChanged += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ak()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void s(Label A_0)
	{
		EventHandler value = ad;
		Label label = m;
		if (label != null)
		{
			label.Click -= value;
		}
		m = A_0;
		label = m;
		if (label != null)
		{
			label.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label al()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void t(Label A_0)
	{
		n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label am()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void y(Label A_0)
	{
		o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label an()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void z(Label A_0)
	{
		p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ao()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void aa(Label A_0)
	{
		q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Label ap()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ac(Label A_0)
	{
		EventHandler value = ac;
		Label label = r;
		if (label != null)
		{
			label.Click -= value;
		}
		r = A_0;
		label = r;
		if (label != null)
		{
			label.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual GroupBox aq()
	{
		return this.m_s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void s(GroupBox A_0)
	{
		this.m_s = A_0;
	}

	[DebuggerStepThrough]
	private void z()
	{
		this.m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(f7));
		b = new ToolTip(this.m_a);
		s(new Button());
		t(new Button());
		c = new SaveFileDialog();
		s(new PictureBox());
		s(new GroupBox());
		ad(new Label());
		s(new RadioButton());
		y(new Button());
		z(new Button());
		aa(new Button());
		t(new RadioButton());
		y(new RadioButton());
		z(new RadioButton());
		s(new Label());
		t(new Label());
		y(new Label());
		z(new Label());
		aa(new Label());
		ac(new Label());
		s(new Panel());
		ac(new Button());
		ad(new Button());
		ae(new Button());
		af(new Button());
		af(new Label());
		ae(new Label());
		((ISupportInitialize)ar()).BeginInit();
		aq().SuspendLayout();
		@as().SuspendLayout();
		SuspendLayout();
		aa().Cursor = Cursors.Default;
		aa().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aa().ForeColor = SystemColors.ControlText;
		aa().Image = (Image)componentResourceManager.GetObject("cmdDeleteBackgroundImg.Image");
		aa().Location = new Point(52, 77);
		aa().Name = "cmdDeleteBackgroundImg";
		aa().RightToLeft = RightToLeft.No;
		aa().Size = new Size(31, 30);
		aa().TabIndex = 22;
		aa().TextAlign = ContentAlignment.BottomCenter;
		b.SetToolTip(aa(), "Delete Background Image");
		ac().Cursor = Cursors.Default;
		ac().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ac().ForeColor = SystemColors.ControlText;
		ac().Image = (Image)componentResourceManager.GetObject("cmdAddBackgroundImg.Image");
		ac().Location = new Point(15, 77);
		ac().Name = "cmdAddBackgroundImg";
		ac().RightToLeft = RightToLeft.No;
		ac().Size = new Size(31, 30);
		ac().TabIndex = 21;
		ac().TextAlign = ContentAlignment.BottomCenter;
		b.SetToolTip(ac(), "Insert Background Image");
		ar().BackColor = SystemColors.Control;
		ar().BorderStyle = BorderStyle.Fixed3D;
		ar().Cursor = Cursors.Default;
		ar().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ar().ForeColor = SystemColors.ControlText;
		ar().InitialImage = null;
		ar().Location = new Point(0, 118);
		ar().Name = "picTemplate";
		ar().RightToLeft = RightToLeft.No;
		ar().Size = new Size(716, 406);
		ar().TabIndex = 14;
		ar().TabStop = false;
		aq().BackColor = SystemColors.Control;
		aq().Controls.Add(ay());
		aq().Controls.Add(az());
		aq().Controls.Add(ax());
		aq().Controls.Add(aa());
		aq().Controls.Add(ac());
		aq().Controls.Add(ad());
		aq().Controls.Add(ae());
		aq().Controls.Add(af());
		aq().Controls.Add(ag());
		aq().Controls.Add(ah());
		aq().Controls.Add(ai());
		aq().Controls.Add(aj());
		aq().Controls.Add(ak());
		aq().Controls.Add(al());
		aq().Controls.Add(am());
		aq().Controls.Add(an());
		aq().Controls.Add(ao());
		aq().Controls.Add(ap());
		aq().Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aq().ForeColor = SystemColors.ControlText;
		aq().Location = new Point(0, 0);
		aq().Name = "fmeEditControls";
		aq().RightToLeft = RightToLeft.No;
		aq().Size = new Size(718, 114);
		aq().TabIndex = 0;
		aq().TabStop = false;
		ax().Font = new Font("Arial", 9.75f);
		ax().Location = new Point(309, 14);
		ax().Name = "LabelAuthorName";
		ax().Size = new Size(46, 19);
		ax().TabIndex = 24;
		ax().Text = "Author:";
		ad().Appearance = Appearance.Button;
		ad().Cursor = Cursors.Default;
		ad().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ad().ForeColor = SystemColors.ControlText;
		ad().Location = new Point(454, 77);
		ad().Name = "optMovePoints";
		ad().RightToLeft = RightToLeft.No;
		ad().Size = new Size(118, 30);
		ad().TabIndex = 20;
		ad().TabStop = true;
		ad().Text = "Move Points";
		ad().TextAlign = ContentAlignment.MiddleCenter;
		ae().Cursor = Cursors.Default;
		ae().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ae().ForeColor = SystemColors.ControlText;
		ae().Image = (Image)componentResourceManager.GetObject("cmdGetRecipe.Image");
		ae().Location = new Point(576, 45);
		ae().Name = "cmdGetRecipe";
		ae().RightToLeft = RightToLeft.No;
		ae().Size = new Size(16, 18);
		ae().TabIndex = 17;
		ae().TextAlign = ContentAlignment.BottomCenter;
		af().Cursor = Cursors.Default;
		af().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		af().ForeColor = SystemColors.ControlText;
		af().Image = (Image)componentResourceManager.GetObject("cmdGetTemplate.Image");
		af().Location = new Point(282, 45);
		af().Name = "cmdGetTemplate";
		af().RightToLeft = RightToLeft.No;
		af().Size = new Size(16, 18);
		af().TabIndex = 7;
		af().TextAlign = ContentAlignment.BottomCenter;
		ag().Cursor = Cursors.Default;
		ag().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ag().ForeColor = SystemColors.ControlText;
		ag().Location = new Point(592, 77);
		ag().Name = "cmdClearAllPoints";
		ag().RightToLeft = RightToLeft.No;
		ag().Size = new Size(118, 30);
		ag().TabIndex = 6;
		ag().Text = "Clear Points";
		ah().Appearance = Appearance.Button;
		ah().Cursor = Cursors.Default;
		ah().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ah().ForeColor = SystemColors.ControlText;
		ah().Location = new Point(336, 77);
		ah().Name = "optRemovePoints";
		ah().RightToLeft = RightToLeft.No;
		ah().Size = new Size(118, 30);
		ah().TabIndex = 3;
		ah().TabStop = true;
		ah().Text = "Remove Points";
		ah().TextAlign = ContentAlignment.MiddleCenter;
		ai().Appearance = Appearance.Button;
		ai().Cursor = Cursors.Default;
		ai().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ai().ForeColor = SystemColors.ControlText;
		ai().Location = new Point(218, 77);
		ai().Name = "optAddPoint";
		ai().RightToLeft = RightToLeft.No;
		ai().Size = new Size(118, 30);
		ai().TabIndex = 2;
		ai().TabStop = true;
		ai().Text = "Add Points";
		ai().TextAlign = ContentAlignment.MiddleCenter;
		aj().Appearance = Appearance.Button;
		aj().Checked = true;
		aj().Cursor = Cursors.Default;
		aj().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aj().ForeColor = SystemColors.ControlText;
		aj().Location = new Point(100, 77);
		aj().Name = "optMoveTemplate";
		aj().RightToLeft = RightToLeft.No;
		aj().Size = new Size(118, 28);
		aj().TabIndex = 1;
		aj().TabStop = true;
		aj().Text = "Move Outline";
		aj().TextAlign = ContentAlignment.MiddleCenter;
		ak().BackColor = Color.White;
		ak().BorderStyle = BorderStyle.Fixed3D;
		ak().Cursor = Cursors.Default;
		ak().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ak().ForeColor = SystemColors.ControlText;
		ak().Location = new Point(405, 43);
		ak().Name = "lblRecipeName";
		ak().RightToLeft = RightToLeft.No;
		ak().Size = new Size(190, 22);
		ak().TabIndex = 16;
		ak().Text = "DefaultRecipe";
		al().BackColor = SystemColors.WindowText;
		al().Location = new Point(0, 330);
		al().Name = "Line1";
		al().Size = new Size(4667, 1);
		al().TabIndex = 23;
		am().BackColor = SystemColors.Control;
		am().BorderStyle = BorderStyle.Fixed3D;
		am().Cursor = Cursors.Default;
		am().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		am().ForeColor = SystemColors.ControlText;
		am().Location = new Point(577, 12);
		am().Name = "lblDate";
		am().RightToLeft = RightToLeft.No;
		am().Size = new Size(133, 22);
		am().TabIndex = 13;
		am().Text = "Modify Date Label Box";
		an().BackColor = SystemColors.Control;
		an().BorderStyle = BorderStyle.Fixed3D;
		an().Cursor = Cursors.Default;
		an().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		an().ForeColor = SystemColors.ControlText;
		an().Location = new Point(358, 12);
		an().Name = "lblAuthor";
		an().RightToLeft = RightToLeft.No;
		an().Size = new Size(133, 22);
		an().TabIndex = 12;
		an().Text = "Author Display Box";
		ao().BackColor = SystemColors.Control;
		ao().Cursor = Cursors.Default;
		ao().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ao().ForeColor = SystemColors.ControlText;
		ao().Location = new Point(507, 14);
		ao().Name = "lblModDate";
		ao().RightToLeft = RightToLeft.No;
		ao().Size = new Size(67, 19);
		ao().TabIndex = 11;
		ao().Text = "Mod. Date:";
		ao().TextAlign = ContentAlignment.TopRight;
		ap().BackColor = Color.White;
		ap().BorderStyle = BorderStyle.Fixed3D;
		ap().Cursor = Cursors.Default;
		ap().Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ap().ForeColor = SystemColors.ControlText;
		ap().Location = new Point(110, 43);
		ap().Name = "lblTemplateName";
		ap().RightToLeft = RightToLeft.No;
		ap().Size = new Size(190, 22);
		ap().TabIndex = 9;
		ap().Text = "DefaultTemplate";
		@as().Controls.Add(at());
		@as().Controls.Add(au());
		@as().Controls.Add(av());
		@as().Controls.Add(aw());
		@as().Location = new Point(3, 528);
		@as().Name = "Panel1";
		@as().Size = new Size(713, 34);
		@as().TabIndex = 20;
		at().Cursor = Cursors.Default;
		at().DialogResult = DialogResult.Cancel;
		at().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		at().ForeColor = SystemColors.ControlText;
		at().Location = new Point(621, 4);
		at().Name = "cmdTemplateCancel";
		at().RightToLeft = RightToLeft.No;
		at().Size = new Size(89, 30);
		at().TabIndex = 23;
		at().Text = "Cancel";
		au().Cursor = Cursors.Default;
		au().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		au().ForeColor = SystemColors.ControlText;
		au().Location = new Point(521, 4);
		au().Name = "cmdTemplateOK";
		au().RightToLeft = RightToLeft.No;
		au().Size = new Size(89, 30);
		au().TabIndex = 22;
		au().Text = "OK";
		av().Cursor = Cursors.Default;
		av().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		av().ForeColor = SystemColors.ControlText;
		av().Location = new Point(307, 4);
		av().Name = "cmdSave";
		av().RightToLeft = RightToLeft.No;
		av().Size = new Size(89, 30);
		av().TabIndex = 21;
		av().Text = "Save";
		aw().Cursor = Cursors.Default;
		aw().Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		aw().ForeColor = SystemColors.ControlText;
		aw().Location = new Point(407, 4);
		aw().Name = "cmdSaveAs";
		aw().RightToLeft = RightToLeft.No;
		aw().Size = new Size(89, 30);
		aw().TabIndex = 20;
		aw().Text = "Save As...";
		az().Font = new Font("Arial", 9.75f);
		az().Location = new Point(6, 45);
		az().Name = "LabelTemplateName";
		az().Size = new Size(102, 19);
		az().TabIndex = 25;
		az().Text = "Template Name:";
		ay().Font = new Font("Arial", 9.75f);
		ay().Location = new Point(316, 45);
		ay().Name = "LabelRecipeName";
		ay().Size = new Size(91, 19);
		ay().TabIndex = 26;
		ay().Text = "Recipe Name:";
		base.AutoScaleDimensions = new SizeF(6f, 14f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoValidate = AutoValidate.Disable;
		BackColor = SystemColors.Control;
		base.ClientSize = new Size(718, 566);
		base.ControlBox = false;
		base.Controls.Add(@as());
		base.Controls.Add(ar());
		base.Controls.Add(aq());
		Cursor = Cursors.Default;
		DoubleBuffered = true;
		Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Location = new Point(4, 30);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogEditTemplate";
		RightToLeft = RightToLeft.No;
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Template Structure";
		((ISupportInitialize)ar()).EndInit();
		aq().ResumeLayout(performLayout: false);
		@as().ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual PictureBox ar()
	{
		return this.m_t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(PictureBox A_0)
	{
		MouseEventHandler value = y;
		MouseEventHandler value2 = t;
		MouseEventHandler value3 = s;
		PaintEventHandler value4 = s;
		PictureBox pictureBox = this.m_t;
		if (pictureBox != null)
		{
			pictureBox.MouseDown -= value;
			pictureBox.MouseMove -= value2;
			pictureBox.MouseUp -= value3;
			pictureBox.Paint -= value4;
		}
		this.m_t = A_0;
		pictureBox = this.m_t;
		if (pictureBox != null)
		{
			pictureBox.MouseDown += value;
			pictureBox.MouseMove += value2;
			pictureBox.MouseUp += value3;
			pictureBox.Paint += value4;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Panel @as()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void s(Panel A_0)
	{
		u = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button at()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ac(Button A_0)
	{
		EventHandler value = af;
		Button button = v;
		if (button != null)
		{
			button.Click -= value;
		}
		v = A_0;
		button = v;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button au()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ad(Button A_0)
	{
		EventHandler value = ae;
		Button button = w;
		if (button != null)
		{
			button.Click -= value;
		}
		w = A_0;
		button = w;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button av()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void ae(Button A_0)
	{
		EventHandler value = ah;
		Button button = x;
		if (button != null)
		{
			button.Click -= value;
		}
		x = A_0;
		button = x;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public virtual Button aw()
	{
		return this.m_y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	public virtual void af(Button A_0)
	{
		EventHandler value = ag;
		Button button = this.m_y;
		if (button != null)
		{
			button.Click -= value;
		}
		this.m_y = A_0;
		button = this.m_y;
		if (button != null)
		{
			button.Click += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ax()
	{
		return this.m_z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ad(Label A_0)
	{
		this.m_z = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label ay()
	{
		return this.m_aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void ae(Label A_0)
	{
		this.m_aa = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Label az()
	{
		return ab;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void af(Label A_0)
	{
		ab = A_0;
	}

	[SpecialName]
	public bool a0()
	{
		return this.m_as;
	}

	private void y()
	{
		checked
		{
			if (this.m_ag.al())
			{
				aj().Visible = false;
				ai().Left = aj().Left;
				ah().Left = ai().Left + ai().Width;
				ad().Left = ah().Left + ah().Width;
				ag().Left = ad().Left + ad().Width;
			}
			else
			{
				aj().Visible = true;
				ai().Left = aj().Left + aj().Width;
				ah().Left = ai().Left + ai().Width;
				ad().Left = ah().Left + ah().Width;
				ag().Left = ad().Left + ad().Width;
			}
			ar().Invalidate();
		}
	}

	private void t()
	{
		if (!this.m_ao)
		{
			this.m_ap = false;
			this.m_ag.ab(Guid.NewGuid().ToString());
			s();
		}
	}

	private void s()
	{
		DateTime now = DateAndTime.Now;
		am().Text = now.ToString("d") + " " + now.ToString("T");
		this.m_ag.a(now.ToOADate());
		this.m_ag.aa(this.m_ai);
		an().Text = this.m_ag.af();
	}

	public void s(hg A_0)
	{
		hi hi2 = A_0.ed();
		this.m_ag.aa(checked((short)hi2.g7()));
		this.m_ag.b(hi2.g5());
		this.m_ag.b(A_0.c1().Substring(hg.bz().Length));
		hi2 = null;
	}

	public void s(f1 A_0, f4 A_1, ref string A_2, string A_3, bool A_4, bool A_5, bool A_6, ref bool A_7)
	{
		string A_8 = "";
		string A_9 = "";
		this.m_ad = A_0;
		this.m_af = A_1;
		this.m_av = "DefaultRecipe";
		this.m_aw = A_6;
		this.m_ag = new e4(this.m_ac, ar().CreateGraphics(), e4.b.a);
		this.m_am = A_2;
		this.m_an = false;
		float A_10 = default(float);
		double A_11 = default(double);
		if (Operators.CompareString(Path.GetFileNameWithoutExtension(A_2.Substring(checked(A_2.LastIndexOf("\\") + 1))).ToLower(), "DefaultTemplate".ToLower(), TextCompare: false) != 0 && !this.m_ag.a(A_2, A_1: false, ref A_10, ref A_10, ref A_10, ref A_10, ref A_8, ref A_9, ref A_11))
		{
			ref fz a_ = ref this.m_ac;
			string A_12 = "TemplateLoadErrFmt2";
			string a_2 = string.Format(hu.a(ref A_12), Strings.LCase("Template"), A_2);
			Point A_13 = i6.a(this);
			fe.b(ref a_, a_2, ref A_13);
		}
		hg hg2 = this.m_ad.t0(this.m_af.hb());
		s(hg2);
		this.m_ag.a(A_2);
		ap().Text = Path.GetFileNameWithoutExtension(A_2);
		an().Text = this.m_ag.af();
		am().Text = DateTime.FromOADate(this.m_ag.ag()).ToString();
		this.m_ap = true;
		ak().Text = hg2.ci();
		if (this.m_ag.al() && !File.Exists(this.m_ag.am()))
		{
			ref fz a_3 = ref this.m_ac;
			string a_4 = "The background image associated with the template " + this.m_ag.am() + " does not exist.";
			Point A_13 = i6.a(this);
			fe.b(ref a_3, a_4, ref A_13);
			this.m_ag.aa(A_0: false);
			this.m_ag.ac("");
		}
		this.m_ai = A_3;
		this.m_at = A_5;
		this.m_au = A_4;
		ShowDialog();
		A_2 = this.m_ag.ab();
		A_7 = this.m_an;
	}

	private void am(object A_0, EventArgs A_1)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		checked
		{
			try
			{
				openFileDialog.Filter = "JPG (*.jpg)|*.jpg|Bitmaps (*.bmp; *.dib)|*.bmp; *.dib|GIF Images (*.gif)|*.gif";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					if (File.Exists(openFileDialog.FileName))
					{
						this.m_ag.aa(A_0: true);
						this.m_ag.ac(openFileDialog.FileName);
						t();
					}
					else
					{
						ref fz a_ = ref this.m_ac;
						string a_2 = "Error loading Background Image File: " + openFileDialog.FileName + " does not exist.";
						Point A_2 = i6.a(this);
						fe.b(ref a_, a_2, ref A_2);
					}
					y();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_3 = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule cmdAddBackgroundImg_Click.", a_3);
				string[] array = new string[6];
				string A_3 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_3);
				array[1] = " FIControlPanelMeasModule cmdAddBackgroundImg_Click.\r\n";
				A_3 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_3);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_4 = string.Concat(array);
				fe.b(this.m_ac, a_4, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void al(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				this.m_ag.b(ar().CreateGraphics());
				t();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule cmdClearAllPoints_Click.", a_);
				string[] array = new string[6];
				string A_2 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_2);
				array[1] = " FIControlPanelMeasModule cmdClearAllPoints_Click.\r\n";
				A_2 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_2);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_2 = string.Concat(array);
				fe.b(this.m_ac, a_2, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ak(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				this.m_ag.aa(A_0: false);
				this.m_ag.ac("");
				y();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule cmdDeleteBackgroundImg_Click.", a_);
				string[] array = new string[6];
				string A_2 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_2);
				array[1] = " FIControlPanelMeasModule cmdDeleteBackgroundImg_Click.\r\n";
				A_2 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_2);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_2 = string.Concat(array);
				fe.b(this.m_ac, a_2, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void aj(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				hg hg2 = this.m_ad.t0(this.m_af.hb());
				hg hg3 = new hg(hg2.dh(), hg2.cd());
				string extension = Path.GetExtension(hg2.c1());
				List<string> a_ = null;
				if (this.m_ae != null && this.m_ae.k() && this.m_ae.g() && this.m_ae.h() <= gq.a.b)
				{
					a_ = this.m_ae.l();
				}
				fk fk2 = new fk(this.m_ac, hg.b0(), hg.bz() + this.m_ag.ae(), extension, fk.a.a, this.m_av, A_6: false, a_);
				Point a_2 = new Point(ae().Left, ae().Top + ae().Height);
				fk2.a(a_2);
				if (!fk2.k())
				{
					Guid a_3 = this.m_af.hc();
					if (hg3.bu(fk2.q(), hg.b4(), null, global::r.d.a.b.a, A_4: true, A_5: true, i6.a(ae()), global::e.a().OperatorID, this.m_ad.w9(a_3), !this.m_ad.w6(a_3), this.m_ac, this.m_ad.xk(a_3), A_12: false, A_13: false, null, A_15: false))
					{
						this.m_an = true;
					}
					else
					{
						fz a_4 = this.m_ac;
						string A_2 = "RecipeLoadErrFmt2";
						fe.b(a_4, string.Format(hu.a(ref A_2), Strings.LCase("Recipe"), fk2.q()), "RecipeLoadTitle", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
					}
					int length = (i3.m() + "\\" + fk2.m()).Length;
					this.m_ag.b(hg3.c1().Substring(length, hg3.c1().Length - length));
					this.m_ag.aa((short)hg3.ed().g7());
					this.m_ag.b(hg3.ed().g5());
					ak().Text = Path.GetFileNameWithoutExtension(hg3.c1());
					t();
					hg3.b5(A_0: true);
				}
				y();
				hg3 = null;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_5 = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule ButtonGetRecipe_Click.", a_5);
				string[] array = new string[6];
				string A_2 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_2);
				array[1] = " FIControlPanelMeasModule ButtonGetRecipe_Click.\r\n";
				A_2 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_2);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_6 = string.Concat(array);
				fe.b(this.m_ac, a_6, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ai(object A_0, EventArgs A_1)
	{
		string A_2 = "";
		string A_3 = "";
		checked
		{
			try
			{
				bool flag = default(bool);
				if ((!this.m_ap & !this.m_ag.ab().Contains("DefaultTemplate")) && !fe.b(ref this.m_ac, "Changes in the current " + Strings.LCase("Template") + " will be discarded.", "LoadingTemplateString", "OKString", "CancelString", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2))))
				{
					flag = true;
				}
				if (!flag)
				{
					List<string> a_ = null;
					if (this.m_ae != null && this.m_ae.k() && this.m_ae.g() && this.m_ae.h() <= gq.a.b)
					{
						a_ = this.m_ae.l();
					}
					fk fk2 = new fk(this.m_ac, e4.aa(), this.m_ag.ab(), Path.GetExtension(this.m_ag.ab()), fk.a.b, "DefaultTemplate", A_6: false, a_);
					Point a_2 = new Point(af().Left, af().Top + af().Height);
					fk2.a(a_2);
					float A_4 = default(float);
					double A_5 = default(double);
					if (!fk2.k() && this.m_ag.a(fk2.q(), A_1: false, ref A_4, ref A_4, ref A_4, ref A_4, ref A_3, ref A_3, ref A_5))
					{
						this.m_ag.a(fk2.q());
						ap().Text = fk2.p();
						string A_6;
						if (e4.a(fk2.q(), ref A_2))
						{
							A_6 = hg.bz() + A_2;
						}
						else
						{
							if (Operators.CompareString(fk2.o(), "DefaultTemplate", TextCompare: false) != 0)
							{
								ref fz a_3 = ref this.m_ac;
								string a_4 = "The Recipe related with template: " + fk2.o() + " is corrupt or does not exist. Loading default Recipe";
								Point A_7 = i6.a(this);
								fe.b(ref a_3, a_4, ref A_7);
							}
							A_6 = hg.b0() + "DefaultRecipe.fitrp";
						}
						Guid a_5 = this.m_af.hc();
						hg A_8 = new hg(this.m_ad.wq(a_5).dh(), hg.b4());
						hg.bu(ref A_8, ref A_6, hg.b4(), this.m_ag.@as(), null, global::r.d.a.b.a, this.m_ac, A_7: true, i6.a(af()), this.m_ai, this.m_ad.w9(a_5), !this.m_ad.w6(a_5), this.m_ad.xk(a_5), A_13: false);
						s(A_8);
						this.m_an = true;
						ak().Text = Path.GetFileNameWithoutExtension(A_6);
						this.m_ap = true;
					}
				}
				y();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_6 = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule cmdGetTemplate_Click.", a_6);
				string[] array = new string[6];
				string A_9 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_9);
				array[1] = " FIControlPanelMeasModule cmdGetTemplate_Click.\r\n";
				A_9 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_9);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_7 = string.Concat(array);
				fe.b(this.m_ac, a_7, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ah(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (Operators.CompareString(ap().Text, "DefaultTemplate", TextCompare: false) == 0)
				{
					ref fz a_ = ref this.m_ac;
					Point A_2 = i6.a(this);
					fe.b(ref a_, "Cannot modify default template!", ref A_2);
				}
				else if (this.m_ag.a(this.m_ag.ab(), A_1: false, 1f, 1f, 1f, 1f, 1.0))
				{
					this.m_ap = true;
				}
				else
				{
					ref fz a_2 = ref this.m_ac;
					string a_3 = "Failed to save " + Strings.LCase("Template") + " file : " + this.m_ag.ab();
					Point A_2 = i6.a(this);
					fe.b(ref a_2, a_3, ref A_2);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_4 = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule cmdSave_Click.", a_4);
				string[] array = new string[6];
				string A_3 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_3);
				array[1] = " FIControlPanelMeasModule cmdSave_Click.\r\n";
				A_3 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_3);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_5 = string.Concat(array);
				fe.b(this.m_ac, a_5, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ag(object A_0, EventArgs A_1)
	{
		string text = "";
		checked
		{
			try
			{
				c.OverwritePrompt = true;
				text = ((!this.m_aw) ? "Filmetrics Template Files (.fmtpe)|*.fmtpe" : "Filmetrics Template Files (.fmtpa)|*.fmtpa");
				c.Filter = text;
				e4.a();
				c.InitialDirectory = e4.aa();
				if (c.ShowDialog() == DialogResult.Cancel)
				{
					return;
				}
				string fileName = c.FileName;
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
				if (string.Compare(Path.GetDirectoryName(Path.GetDirectoryName(fileName) + "\\"), e4.aa(), ignoreCase: true) != 0)
				{
					fe.b(this.m_ac, "Template file must be saved within [" + e4.aa() + "]", "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
					return;
				}
				if (Operators.CompareString(fileNameWithoutExtension, "DefaultTemplate", TextCompare: false) == 0)
				{
					ref fz a_ = ref this.m_ac;
					Point A_2 = i6.a(this);
					fe.b(ref a_, "Cannot modify default template!", ref A_2);
					return;
				}
				ap().Text = Strings.Trim(fileNameWithoutExtension);
				t();
				if (!this.m_ag.a(fileName, A_1: false, 1f, 1f, 1f, 1f, 1.0))
				{
					ref fz a_2 = ref this.m_ac;
					string a_3 = "Failed to save " + Strings.LCase("Template") + " file : " + fileName + "\r\nError : " + Conversions.ToString(Information.Err().Number) + "-" + Information.Err().Description + "\r\n";
					Point A_2 = i6.a(this);
					fe.b(ref a_2, a_3, ref A_2);
					this.m_ap = false;
				}
				else
				{
					this.m_ag.a(fileName);
					this.m_ap = true;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_4 = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule cmdSaveAs_Click.", a_4);
				string[] array = new string[6];
				string A_3 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_3);
				array[1] = " FIControlPanelMeasModule cmdSaveAs_Click.\r\n";
				A_3 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_3);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_5 = string.Concat(array);
				fe.b(this.m_ac, a_5, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void af(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				this.m_as = true;
				Close();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule cmdTemplateCancel_Click.", a_);
				string[] array = new string[6];
				string A_2 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_2);
				array[1] = " FIControlPanelMeasModule cmdTemplateCancel_Click.\r\n";
				A_2 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_2);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_2 = string.Concat(array);
				fe.b(this.m_ac, a_2, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ae(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (!this.m_ap && fe.b(ref this.m_ac, "Changes in the current " + Strings.LCase("Template") + " will be discarded.\r\nDo you want to save these changes?", "SavingTemplateString", "SaveString", "DiscardString", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2))))
				{
					av().PerformClick();
				}
				hg hg2 = this.m_ad.t0(this.m_af.hb());
				if ((!this.m_an && Operators.CompareString(hg2.c1().Substring(hg.bz().Length), this.m_ag.ae(), TextCompare: false) == 0) || hg2.c9() || Operators.CompareString(hg2.ci(), this.m_av, TextCompare: false) == 0 || fe.b(ref this.m_ac, "Existing measurement recipe has been modified, but not saved. Changes in the current " + Strings.LCase("Recipe") + " will be discarded.", "LoadingTemplateString", "OKString", "CancelString", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2))))
				{
					this.m_as = false;
					Close();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule cmdTemplateOK_Click.", a_);
				string[] array = new string[6];
				string A_2 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_2);
				array[1] = " FIControlPanelMeasModule cmdTemplateOK_Click.\r\n";
				A_2 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_2);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_2 = string.Concat(array);
				fe.b(this.m_ac, a_2, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ad(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				ae().PerformClick();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule lblRecipeName_Click.", a_);
				string[] array = new string[6];
				string A_2 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_2);
				array[1] = " FIControlPanelMeasModule lblRecipeName_Click.\r\n";
				A_2 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_2);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_2 = string.Concat(array);
				fe.b(this.m_ac, a_2, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ac(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				af().PerformClick();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule lblTemplateName_Click.", a_);
				string[] array = new string[6];
				string A_2 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_2);
				array[1] = " FIControlPanelMeasModule lblTemplateName_Click.\r\n";
				A_2 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_2);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_2 = string.Concat(array);
				fe.b(this.m_ac, a_2, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void aa(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (Conversions.ToBoolean(NewLateBinding.LateGet(A_0, null, "Checked", new object[0], null, null, null)))
				{
					this.m_ah = f7.a.b;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule optAddPoint_CheckedChanged.", a_);
				string[] array = new string[6];
				string A_2 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_2);
				array[1] = " FIControlPanelMeasModule optAddPoint_CheckedChanged.\r\n";
				A_2 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_2);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_2 = string.Concat(array);
				fe.b(this.m_ac, a_2, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void z(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (Conversions.ToBoolean(NewLateBinding.LateGet(A_0, null, "Checked", new object[0], null, null, null)))
				{
					this.m_ah = f7.a.d;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule optMovePoints_CheckedChanged.", a_);
				string[] array = new string[6];
				string A_2 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_2);
				array[1] = " FIControlPanelMeasModule optMovePoints_CheckedChanged.\r\n";
				A_2 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_2);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_2 = string.Concat(array);
				fe.b(this.m_ac, a_2, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void y(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (Conversions.ToBoolean(NewLateBinding.LateGet(A_0, null, "Checked", new object[0], null, null, null)))
				{
					this.m_ah = f7.a.a;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule optMoveTemplate_CheckedChanged.", a_);
				string[] array = new string[6];
				string A_2 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_2);
				array[1] = " FIControlPanelMeasModule optMoveTemplate_CheckedChanged.\r\n";
				A_2 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_2);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_2 = string.Concat(array);
				fe.b(this.m_ac, a_2, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void t(object A_0, EventArgs A_1)
	{
		checked
		{
			try
			{
				if (Conversions.ToBoolean(NewLateBinding.LateGet(A_0, null, "Checked", new object[0], null, null, null)))
				{
					this.m_ah = f7.a.c;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule optRemovePoints_CheckedChanged.", a_);
				string[] array = new string[6];
				string A_2 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_2);
				array[1] = " FIControlPanelMeasModule optRemovePoints_CheckedChanged.\r\n";
				A_2 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_2);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_2 = string.Concat(array);
				fe.b(this.m_ac, a_2, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void y(object A_0, MouseEventArgs A_1)
	{
		checked
		{
			try
			{
				_ = (short)unchecked((int)A_1.Button / 1048576);
				_ = (short)unchecked((int)Control.ModifierKeys / 65536);
				_ = (float)A_1.X;
				_ = (float)A_1.Y;
				if ((this.m_ah == f7.a.a) & ((object)ar().Cursor == Cursors.SizeAll))
				{
					this.m_aj = true;
				}
				else if ((this.m_ah == f7.a.d) & ((object)ar().Cursor == Cursors.Cross))
				{
					this.m_ak = true;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule picTemplate_MouseDown.", a_);
				string[] array = new string[6];
				string A_2 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_2);
				array[1] = " FIControlPanelMeasModule picTemplate_MouseDown.\r\n";
				A_2 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_2);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_2 = string.Concat(array);
				fe.b(this.m_ac, a_2, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void t(object A_0, MouseEventArgs A_1)
	{
		checked
		{
			try
			{
				_ = (short)unchecked((int)A_1.Button / 1048576);
				_ = (short)unchecked((int)Control.ModifierKeys / 65536);
				int num = A_1.X;
				int num2 = A_1.Y;
				switch (this.m_ah)
				{
				case f7.a.a:
					if (this.m_aj)
					{
						if (!(((float)num < 4f) | ((float)num2 < 4f) | ((float)num > (float)ar().ClientRectangle.Width - 4f) | ((float)num2 > (float)ar().ClientRectangle.Height - 4f)))
						{
							this.m_ag.a(ar().CreateGraphics(), this.m_al, num, num2);
							t();
						}
					}
					else if (this.m_ag.a(num, num2, 4.0, ref this.m_al))
					{
						ar().Cursor = Cursors.SizeAll;
					}
					else
					{
						ar().Cursor = Cursors.Default;
					}
					break;
				case f7.a.c:
					if (this.m_ag.b(num, num2, 4.0, ref this.m_al))
					{
						ar().Cursor = Cursors.Cross;
					}
					else
					{
						ar().Cursor = Cursors.Default;
					}
					break;
				case f7.a.d:
					if (this.m_ak)
					{
						if (!(((float)num < 4f) | ((float)num2 < 4f) | ((float)num > (float)ar().ClientRectangle.Width - 4f) | ((float)num2 > (float)ar().ClientRectangle.Height - 4f)))
						{
							this.m_ag.a(ar().CreateGraphics(), this.m_al, (float)num, (float)num2);
							t();
						}
					}
					else if (this.m_ag.b(num, num2, 4.0, ref this.m_al))
					{
						ar().Cursor = Cursors.Cross;
					}
					else
					{
						ar().Cursor = Cursors.Default;
					}
					break;
				case f7.a.b:
					break;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule picTemplate_MouseMove.", a_);
				string[] array = new string[6];
				string A_2 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_2);
				array[1] = " FIControlPanelMeasModule picTemplate_MouseMove.\r\n";
				A_2 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_2);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_2 = string.Concat(array);
				fe.b(this.m_ac, a_2, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void s(object A_0, MouseEventArgs A_1)
	{
		checked
		{
			_ = (short)unchecked((int)A_1.Button / 1048576);
			_ = (short)unchecked((int)Control.ModifierKeys / 65536);
			float num = A_1.X;
			float num2 = A_1.Y;
			try
			{
				switch (this.m_ah)
				{
				case f7.a.a:
					this.m_aj = false;
					break;
				case f7.a.b:
					this.m_ag.a(ar().CreateGraphics(), num, num2);
					t();
					break;
				case f7.a.c:
					if (this.m_ag.b(num, num2, 4.0, ref this.m_al))
					{
						this.m_ag.a(ar().CreateGraphics(), this.m_al);
						t();
					}
					break;
				case f7.a.d:
					this.m_ak = false;
					break;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule picTemplate_MouseUp.", a_);
				string[] array = new string[6];
				string A_2 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_2);
				array[1] = " FIControlPanelMeasModule picTemplate_MouseUp.\r\n";
				A_2 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_2);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_2 = string.Concat(array);
				fe.b(this.m_ac, a_2, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void s(object A_0, PaintEventArgs A_1)
	{
		checked
		{
			try
			{
				if (this.m_ag != null)
				{
					this.m_ag.a(A_1.Graphics, 1f, 1f, e4.c.a);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception a_ = ex2;
				this.m_ac.c(fz.b.b, "Error in FIControlPanelMeasModule picTemplate_Paint.", a_);
				string[] array = new string[6];
				string A_2 = "GeneralFunctionErrIn";
				array[0] = hu.a(ref A_2);
				array[1] = " FIControlPanelMeasModule picTemplate_Paint.\r\n";
				A_2 = "GeneralFunctionErrIs";
				array[2] = hu.a(ref A_2);
				array[3] = Information.Err().Description;
				array[4] = ", ";
				array[5] = DateAndTime.Now.ToString();
				string a_2 = string.Concat(array);
				fe.b(this.m_ac, a_2, "Information", new Point(base.Left + unchecked(base.Width / 2), base.Top + unchecked(base.Height / 2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	private void s(object A_0, EventArgs A_1)
	{
		y();
	}
}
