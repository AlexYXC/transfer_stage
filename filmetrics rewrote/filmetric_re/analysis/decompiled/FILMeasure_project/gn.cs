using System.Globalization;
using Filmetrics.My;

internal class gn : fu
{
	public new enum a
	{
		a,
		b,
		c,
		d,
		e,
		f
	}

	public a ak;

	public gn(go A_0, a A_1)
		: base(A_0)
	{
		am(A_1);
	}

	public gn(go A_0, ft A_1, fs A_2, a A_3)
		: base(A_0, A_1, A_2)
	{
		am(A_3);
	}

	private void am(a A_0)
	{
		ak = A_0;
		((fp)this).a = false;
		am();
		((fp)this).a = true;
		am(an);
	}

	private void am()
	{
		MySettings mySettings = e.a();
		@as(bool.Parse(mySettings.GraphMeasShowGrid[(int)ak]));
		ar(bool.Parse(mySettings.GraphMeasYLabelPercent[(int)ak]));
		am(double.Parse(mySettings.GraphMeasYMin[(int)ak], CultureInfo.InvariantCulture));
		am(A_0: false, double.Parse(mySettings.GraphMeasYMax[(int)ak], CultureInfo.InvariantCulture));
		an(double.Parse(mySettings.GraphMeasY2Min[(int)ak], CultureInfo.InvariantCulture));
		an(A_0: false, double.Parse(mySettings.GraphMeasY2Max[(int)ak], CultureInfo.InvariantCulture));
		am(float.Parse(mySettings.GraphMeasDotSize[(int)ak], CultureInfo.InvariantCulture));
		am(bool.Parse(mySettings.GraphMeasAutoScaleYMax[(int)ak]));
		an(bool.Parse(mySettings.GraphMeasAutoScaleYMin[(int)ak]));
		ao(bool.Parse(mySettings.GraphMeasAutoScaleY2Max[(int)ak]));
		ap(bool.Parse(mySettings.GraphMeasAutoScaleY2Min[(int)ak]));
		mySettings = null;
	}

	public void an()
	{
		MySettings mySettings = e.a();
		mySettings.GraphMeasShowGrid[(int)ak] = av().ToString();
		mySettings.GraphMeasYLabelPercent[(int)ak] = at().ToString();
		mySettings.GraphMeasYMin[(int)ak] = a0().ToString(CultureInfo.InvariantCulture);
		mySettings.GraphMeasYMax[(int)ak] = at(false).ToString(CultureInfo.InvariantCulture);
		mySettings.GraphMeasAutoScaleYMax[(int)ak] = ao().ToString();
		mySettings.GraphMeasAutoScaleYMin[(int)ak] = ap().ToString();
		mySettings.GraphMeasY2Min[(int)ak] = a1().ToString(CultureInfo.InvariantCulture);
		mySettings.GraphMeasY2Max[(int)ak] = au(false).ToString(CultureInfo.InvariantCulture);
		mySettings.GraphMeasAutoScaleY2Max[(int)ak] = aq().ToString();
		mySettings.GraphMeasAutoScaleY2Min[(int)ak] = ar().ToString();
		_ = null;
		((go)a2()).ao();
	}

	public gn am(go A_0, ft A_1, fs A_2)
	{
		return new gn(A_0, A_1, A_2, ak);
	}
}
