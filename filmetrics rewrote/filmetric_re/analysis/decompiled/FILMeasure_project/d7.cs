using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class d7
{
	private class a
	{
		public hr a;

		public fz b;

		public Point c;

		public object d;

		public f1 e;
	}

	private static void a(hr A_0, g2.a A_1, h.e A_2, ref bool A_3, ref bool A_4)
	{
		if (A_0 != null)
		{
			hr hr2 = A_0;
			A_3 = hr2.ao();
			A_4 = hr2.bl() != null;
			hr2 = null;
		}
		else if (A_1 != g2.a.c && A_1 != g2.a.b)
		{
			A_3 = g2.j(A_1, h.f.a);
			A_4 = false;
		}
		else
		{
			A_3 = A_2 != h.e.c;
			A_4 = h.n(A_2);
		}
	}

	public static void a(fl A_0, hr A_1, hg A_2, g2.a A_3, h.e A_4)
	{
		int a_ = 0;
		int a_2 = 0;
		hi hi2 = A_2.ed();
		bool A_5 = default(bool);
		bool A_6 = default(bool);
		a(A_1, A_3, A_4, ref A_5, ref A_6);
		if (A_2.b5())
		{
			a_ = hi2.e3();
			a_2 = hi2.e9();
		}
		hi hi3 = hi2;
		A_0.o((float[])null, 0);
		A_0.o((cc.a[])null, 0);
		A_0.o(hi3.e4(), hi3.e5(), hi3.e6(), hi3.e7(), hi3.au(A_3, A_5, A_6, A_3: true), hi3.au(A_3, A_5, A_6, A_3: false), a_);
		A_0.p(hi3.fa(), hi3.fb(), hi3.fc(), hi3.fd(), hi3.d5(A_3, A_5, A_6, A_3: true), hi3.d5(A_3, A_5, A_6, A_3: false), a_2);
		hi3 = null;
	}

	public static fl.h a(hc A_0)
	{
		hi hi2 = A_0.cy().b3(A_0.cf());
		if ((hi2.d6(0, A_0.cn()) && A_0.cn().cj() == hr.b.c && jf.e(A_0.cn().cu().m(), 0f)) || A_0.cn().cj() == hr.b.n)
		{
			return fl.h.a;
		}
		if (hi2.gm() > 1 && hi2.d6(1, A_0.cn()) && (!jf.e(A_0.cn().cu().m(), 0f) || (A_0.cn().bm() != null && A_0.cn().bm().Count > 0)))
		{
			return fl.h.c;
		}
		if (hi2.d5(0, A_0.cn()) && (A_0.cn().cj() == hr.b.j || A_0.cn().bl() != null))
		{
			return fl.h.b;
		}
		throw new ax("theMeasResult does not contain a known calculated curve priority");
	}

	public static fl.n a(fy A_0)
	{
		fl.n n2 = new fl.n();
		fy fy2 = A_0;
		fl.o a_ = ((fy2.c3() != null) ? new fl.o(fy2.cz(), fy2.c0(), fy2.c2(), fy2.c3().cz(), fy2.c3().c0(), fy2.c3().c2()) : new fl.o(fy2.cz(), fy2.c0(), fy2.c2(), null, null, 0));
		n2.e(a_);
		if (fy2.c4() != null)
		{
			foreach (fy item in fy2.c4())
			{
				a_ = ((item.c3() != null) ? new fl.o(item.cz(), item.c0(), item.c2(), item.c3().cz(), item.c3().c0(), item.c3().c2()) : new fl.o(item.cz(), item.c0(), item.c2(), null, null, 0));
				n2.e(a_);
			}
		}
		fy2 = null;
		return n2;
	}

	public static fl.h a(hr A_0)
	{
		if (A_0.cj() == hr.b.j || A_0.cj() == hr.b.k)
		{
			return fl.h.b;
		}
		if (!jf.e(A_0.cu().m(), 0.0))
		{
			return fl.h.c;
		}
		return fl.h.a;
	}

	public static void a(fl A_0, hr.b[] A_1)
	{
		bool a_ = false;
		if (A_0.fg() != 0)
		{
			return;
		}
		fh.b b10 = (fh.b)e.a().DisplayedSpectrumTransformation;
		if (A_1.Length == 2 && b10 != fh.b.a)
		{
			hr.b b11 = default(hr.b);
			switch (b10)
			{
			case fh.b.b:
				b11 = hr.b.m;
				break;
			case fh.b.c:
				b11 = hr.b.p;
				break;
			}
			A_0.o(fl.h.c, null, null);
			A_0.o(fl.h.b, null, null);
			gp.a(fl.h.a, A_0, b11, hr.af(b11));
			return;
		}
		int num = -1;
		int num2 = -1;
		int upperBound = A_1.GetUpperBound(0);
		checked
		{
			for (int num3 = 0; num3 <= upperBound; num3++)
			{
				if (A_1[num3] == hr.b.c || A_1[num3] == hr.b.n || A_1[num3] == hr.b.r)
				{
					num = num3;
					break;
				}
			}
			int upperBound2 = A_1.GetUpperBound(0);
			for (int num4 = 0; num4 <= upperBound2; num4++)
			{
				if (A_1[num4] == hr.b.j)
				{
					num2 = num4;
					break;
				}
			}
			int upperBound3 = A_1.GetUpperBound(0);
			for (int num5 = 0; num5 <= upperBound3; num5++)
			{
				if (hr.af(A_1[num5]))
				{
					a_ = true;
					break;
				}
			}
			if (num >= 0)
			{
				gp.a(fl.h.a, A_0, A_1[num], a_);
				if (num2 >= 0)
				{
					gp.a(fl.h.b, A_0, A_1[num2], a_);
				}
				else
				{
					gp.a(fl.h.b, A_0, hr.b.a, a_);
				}
			}
			else
			{
				if (num2 >= 0)
				{
					gp.a(fl.h.a, A_0, A_1[num2], a_);
				}
				else
				{
					gp.a(fl.h.a, A_0, hr.b.a, a_);
				}
				gp.a(fl.h.b, A_0, hr.b.a, a_);
			}
		}
	}

	public static fl.o a(fy A_0, hr A_1, hr.b A_2)
	{
		if (A_1.cj() == A_2)
		{
			return new fl.o(A_0.cz(), A_0.c0(), A_0.c2(), null, null, 0);
		}
		if (A_0.c3() != null && A_1.cu().m() == A_1.bl().cu().m())
		{
			double[] A_3 = null;
			double[] A_4 = null;
			hr hr2 = A_1;
			int A_5 = default(int);
			int A_6 = default(int);
			hr.r(hr2.cz(), hr2.c0(), hr2.c2(), hr2.bl().cz(), hr2.bl().c0(), hr2.bl().c2(), ref A_5, ref A_6);
			int A_7 = default(int);
			hr.r(A_5, A_6, hr2.cz(), hr2.c0(), hr2.bl().cz(), hr2.bl().c0(), hr2.bl().c2(), ref A_3, ref A_4, ref A_7);
			hr2 = null;
			if (A_2 == hr.b.p)
			{
				return new fl.o(A_3, hr.r(A_3, A_4, A_7), A_7, null, null, 0);
			}
			return new fl.o(A_3, A_4, A_7, null, null, 0);
		}
		checked
		{
			double[] array = new double[A_0.c2() - 1 + 1];
			if (A_2 == hr.b.m)
			{
				int num = A_0.c2() - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					array[num2] = 1.0;
				}
			}
			return new fl.o(A_0.cz(), array, A_0.c2(), null, null, 0);
		}
	}

	public static void a(f1 A_0, fl A_1, hr A_2, fh.b A_3, hr.b A_4)
	{
		fl.n n2 = new fl.n();
		hr hr2 = A_2;
		A_1.o(hr2.cz()[0], hr2.cz()[checked(hr2.c2() - 1)]);
		if (A_3 == fh.b.a)
		{
			fl.h h10 = a(A_2);
			fl.o a_;
			if (hr2.bl() == null)
			{
				a_ = new fl.o(hr2.cz(), hr2.c0(), hr2.c2(), null, null, 0);
			}
			else
			{
				a_ = new fl.o(hr2.cz(), hr2.c0(), hr2.c2(), hr2.bl().cz(), hr2.bl().c0(), hr2.bl().c2());
				A_1.o(fl.h.b, hr2.bl().bw(), hr2.bl().bx());
			}
			switch (h10)
			{
			case fl.h.b:
				A_1.o(fl.h.b, hr2.bw(), hr2.bx(), hr2.am());
				break;
			case fl.h.c:
				A_1.o(fl.h.c, hr2.bw(), hr2.bx(), hr2.am());
				break;
			default:
				A_1.o(hr2.bw(), hr2.bx(), hr2.am());
				break;
			}
			n2.e(a_);
			if (hr2.bm() != null)
			{
				foreach (hr item in hr2.bm())
				{
					A_1.o(fl.h.c, item.bw(), item.bx());
					a_ = ((item.bl() != null) ? new fl.o(item.cz(), item.c0(), item.c2(), item.bl().cz(), item.bl().c0(), item.bl().c2()) : new fl.o(item.cz(), item.c0(), item.c2(), null, null, 0));
					n2.e(a_);
				}
			}
			A_1.o(n2, hr2.b9(), hr2.ca(), hr2.cf, hr2.b5(), ey.ai(), A_6: true, hr2.am(), !A_0.u2() || A_0.u3(), A_9: false, default(Color), h10);
		}
		else
		{
			fl.o a_ = a(A_2, A_2, A_4);
			n2.e(a_);
			hr hr3 = A_2;
			A_1.o(n2, hr3.b9(), hr3.ca(), hr3.cf, hr3.b5(), ey.ai(), A_6: true, hr3.am(), !A_0.u2() || A_0.u3(), A_9: false, default(Color), fl.h.a);
			A_1.o(hr.t(A_4, 0f), hr.r(A_4, 0f), hr.af(A_4));
			hr3 = null;
		}
		hr2 = null;
	}

	private static bool a(hr A_0, hr.b A_1)
	{
		if (A_0.cj() != A_1 && A_0.bl() != null)
		{
			return A_0.cu().m() == A_0.bl().cu().m();
		}
		return false;
	}

	public static void a(Collection<hr> A_0, hr A_1, ref fh.b A_2, ref hr.b A_3)
	{
		fh.b b10 = (fh.b)e.a().DisplayedSpectrumTransformation;
		A_2 = fh.b.a;
		switch (b10)
		{
		case fh.b.b:
			A_3 = hr.b.m;
			break;
		case fh.b.c:
			A_3 = hr.b.p;
			break;
		case fh.b.a:
			return;
		}
		if (A_0 != null)
		{
			foreach (hr item in A_0)
			{
				if (a(item, A_3))
				{
					A_2 = b10;
					break;
				}
			}
		}
		if (A_2 != b10 && A_1 != null && a(A_1, A_3))
		{
			A_2 = b10;
		}
	}

	public static void a(f1 A_0, fl A_1, hc A_2, fh.b A_3, hr.b A_4)
	{
		hc hc2 = A_2;
		if (A_3 == fh.b.a)
		{
			fl.n n2 = a(hc2.cs());
			if (n2 != null && n2.e().Count > 0)
			{
				A_1.o(n2, hc2.cn().b9(), hc2.cn().ca(), hc2.cy().cl(), string.Format(ey.at(), hc2.cn().b5()), ey.ar(), A_6: true, a(A_2), A_8: false);
			}
		}
		else
		{
			fl.n n2 = new fl.n();
			n2.e(a(hc2.cs(), hc2.cn(), A_4));
			A_1.o(n2, hc2.cn().b9(), hc2.cn().ca(), hc2.cy().cl(), string.Format(ey.at(), hc2.cn().b5()), ey.ar(), A_6: true, fl.h.a, A_8: false);
		}
		hc2 = null;
	}

	private static void a(object A_0, CancelEventArgs A_1)
	{
		SaveFileDialog saveFileDialog = (SaveFileDialog)A_0;
		a a10 = (a)saveFileDialog.Tag;
		try
		{
			string fileName = saveFileDialog.FileName;
			hr hr2 = a10.a;
			string path = hr2.ay(fileName);
			string text = hr.ah(fileName);
			string text2 = hr.ag(fileName);
			string text3 = hr.af(fileName);
			string text4 = hr.t(fileName);
			Collection<string> collection = new Collection<string>();
			if (File.Exists(path))
			{
				collection.Add(Path.GetFileName(path));
			}
			if (hr2.c3() != null && !string.IsNullOrEmpty(text) && File.Exists(text))
			{
				collection.Add(Path.GetFileName(text));
			}
			if (hr2.c4() != null && hr2.c4().Count > 0 && !string.IsNullOrEmpty(text4) && File.Exists(text4))
			{
				collection.Add(Path.GetFileName(text4));
			}
			if (hr2.c3() != null && !string.IsNullOrEmpty(text2) && File.Exists(text2))
			{
				collection.Add(Path.GetFileName(text2));
			}
			if (hr2.c3() != null && !string.IsNullOrEmpty(text3) && File.Exists(text3))
			{
				collection.Add(Path.GetFileName(text3));
			}
			if (collection.Count > 0)
			{
				A_1.Cancel = !i5.a(a10.b, collection, A_2: false, a10.c);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			i5.a(a10.b, a10.e, RuntimeHelpers.GetObjectValue(a10.d), a10.c, "FIGraphHelper.VerifySpectrumWithSecondaryOrAdditionalDataSaveOverwriteOK", a_);
			ProjectData.ClearProjectError();
		}
	}

	public static void a(hr A_0, f1 A_1, object A_2, Point A_3, bool A_4, fz A_5, ref string A_6)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		string A_7 = string.Empty;
		Collection<string> A_8 = null;
		Collection<string> A_9 = null;
		if (A_0 == null)
		{
			return;
		}
		b2 b10 = hr.af(A_1.ui(), A_1.uq(), A_0.cu().q() == null);
		if (i3.f(A_0.b5()))
		{
			saveFileDialog.FileName = A_0.b5();
		}
		else
		{
			saveFileDialog.FileName = "Spectrum";
		}
		saveFileDialog.Filter = b10.b();
		saveFileDialog.InitialDirectory = i3.d(e.a().LastOpenSaveExportTargetImportSourcePath);
		if (A_0.bl() != null || (A_0.bm() != null && A_0.bm().Count > 0))
		{
			saveFileDialog.FileOk += a;
			saveFileDialog.OverwritePrompt = false;
		}
		try
		{
			a a10 = new a();
			a10.a = A_0;
			a10.b = A_5;
			a10.e = A_1;
			a10.d = RuntimeHelpers.GetObjectValue(A_2);
			a10.c = A_3;
			saveFileDialog.Tag = a10;
			if (saveFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			e.a().LastOpenSaveExportTargetImportSourcePath = Path.GetDirectoryName(saveFileDialog.FileName);
			A_6 = b10.a(saveFileDialog.FileName, saveFileDialog.FilterIndex);
			hr hr2 = A_0;
			try
			{
				string a_ = "";
				bool flag = default(bool);
				if (saveFileDialog.FilterIndex == hr2.ah(A_1.ui()))
				{
					flag = true;
					a_ = hr2.cn();
					hr2.ao(hr2.bk());
				}
				hr2.r(ref A_7, ref A_8, ref A_9);
				hr2.r(ref A_6, hr2.bz(), hr2.by(), A_7, A_8, A_9, A_4, e.a().UniformSpectrumDataPointSpacing, e.a().UniformSpectrumDataFinePointSpacing);
				if (flag)
				{
					hr2.ao(a_);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				A_5.c(fz.b.b, "Error in FIGraphHelper.SaveGraphHandler", ex3);
				fe.b(A_5, "Error saving spectrum. Failed to write file. Error is " + ex3.Message, "Information", A_3);
				ProjectData.ClearProjectError();
			}
			hr2 = null;
		}
		finally
		{
			if (A_0.bl() != null || (A_0.bm() != null && A_0.bm().Count > 0))
			{
				saveFileDialog.FileOk -= a;
			}
		}
	}

	public static void a(hg A_0, hr.b[] A_1, fl A_2, fl A_3, fl A_4)
	{
		a(A_2, A_1);
		gp.a(A_3, A_0);
		gp.a(A_4);
	}

	public static void a(f1 A_0, fl A_1, fl A_2, fl A_3)
	{
		Collection<gu.a> A_4 = null;
		if (A_0.m2(ref A_4) == ce.ErrPublic.None)
		{
			Guid a_ = A_4[0].a;
			hg a_2 = A_0.wq(a_);
			hr.b[] a_3 = A_0.wh(a_);
			a(a_2, a_3, A_1, A_2, A_3);
		}
	}

	public static void a(hc A_0, f1 A_1, fl A_2, fl A_3, fl A_4, ref fh.b A_5)
	{
		hc hc2 = A_0;
		fh.b A_6 = default(fh.b);
		hr.b A_7 = default(hr.b);
		a(null, hc2.cn(), ref A_6, ref A_7);
		A_5 = (fh.b)e.a().DisplayedSpectrumTransformation;
		A_2.g1();
		a(A_1, A_2, hc2.cn(), A_6, A_7);
		A_2.s(ey.a8());
		if ((hc2.cu() != null) & (hc2.cv() != null))
		{
			A_3.s(ey.aw() + " (" + h4.e(hc2.cy().ca(), false, false) + ")");
			A_3.o(ey.av(), ey.au(), hr.af(hr.b.f));
			A_3.p(hc2.cu().cz(), hc2.cu().c0(), hc2.cu().c2(), hc2.cn().b9(), hc2.cn().ca(), 0.0, hc2.cn().b5() + " FFT", ey.@as() + " FFT", A_8: true, A_9: false);
			A_3.o(hc2.cv().cz(), hc2.cv().c0(), hc2.cv().c2(), hc2.cn().b9(), hc2.cn().ca(), hc2.ca, hc2.cn().b5() + " FFT", ey.ap() + " FFT", A_8: true, A_9: true);
			A_3.gi().a2().am(0.0);
			A_3.gm = hc2.cx();
			A_3.g7();
			A_3.gi().am(0.0);
		}
		else if (hc2.ch() == cc.j.a && hc2.cs() != null)
		{
			a(A_1, A_2, A_0, A_6, A_7);
		}
		a(A_1, A_2, A_3, A_4);
		hc2 = null;
	}

	public static void a(fz A_0, int A_1, string A_2, string A_3, Point A_4)
	{
		if (!e.a().AutoIncreaseGraphMaxCurves)
		{
			return;
		}
		int num = e.a().GraphMeasUserDefinedMaxCurves;
		A_2 = A_2.ToLower();
		A_3 = A_3.ToLower();
		if (num >= A_1 || num >= 10)
		{
			return;
		}
		bool A_5 = !e.a().ConfirmBeforeAutoIncreaseGraphMaxCurves;
		if (A_1 > 10)
		{
			string text;
			if (num == 1)
			{
				text = A_2;
			}
			else
			{
				string A_6 = "NumberOfItemsFmt";
				text = string.Format(hu.a(ref A_6), num, A_3);
			}
			if (!A_5)
			{
				string A_6 = "GraphIncreaseNumCurvesToMaxPromptFmt4";
				string a_ = string.Format(hu.a(ref A_6), A_3, (short)10, A_1, text);
				A_6 = "DontAskMeThisAgain";
				if (!fe.b(ref A_0, a_, "AutomaticSettingChangeConfirmationTitle", "Yes", "No", A_4, hu.a(ref A_6), ref A_5))
				{
					if (A_5)
					{
						e.a().AutoIncreaseGraphMaxCurves = false;
						e.a().ConfirmBeforeAutoIncreaseGraphMaxCurves = false;
					}
					return;
				}
			}
			e.a().GraphMeasUserDefinedMaxCurves = 10;
			return;
		}
		if (e.a().ConfirmBeforeAutoIncreaseGraphMaxCurves)
		{
			string A_6 = "GraphIncreaseNumCurvesPromptFmt3";
			string a_2 = string.Format(hu.a(ref A_6), A_3, A_1, num);
			A_6 = "DontAskMeThisAgain";
			if (!fe.b(ref A_0, a_2, "AutomaticSettingChangeConfirmationTitle", "Yes", "No", A_4, hu.a(ref A_6), ref A_5))
			{
				if (A_5)
				{
					e.a().AutoIncreaseGraphMaxCurves = false;
					e.a().ConfirmBeforeAutoIncreaseGraphMaxCurves = false;
				}
				return;
			}
		}
		if (A_5)
		{
			e.a().ConfirmBeforeAutoIncreaseGraphMaxCurves = false;
		}
		e.a().GraphMeasUserDefinedMaxCurves = checked((short)A_1);
	}
}
