using System.Globalization;
using System.Runtime.CompilerServices;
using Filmetrics.My;

internal class go : fr
{
	public new enum a
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g
	}

	private a al;

	public go(a A_0)
	{
		al = A_0;
		am();
	}

	[SpecialName]
	public a an()
	{
		return al;
	}

	private void am()
	{
		if (al != a.g)
		{
			MySettings mySettings = global::e.a();
			am(double.Parse(mySettings.GraphMeasXMin[(int)al], CultureInfo.InvariantCulture));
			an(double.Parse(mySettings.GraphMeasXMax[(int)al], CultureInfo.InvariantCulture));
			am(bool.Parse(mySettings.GraphMeasAutoScaleXMax[(int)al]));
			an(bool.Parse(mySettings.GraphMeasAutoScaleXMin[(int)al]));
			aq(bool.Parse(mySettings.GraphMeasCursorShowXValue[(int)al]));
			ap(bool.Parse(mySettings.GraphMeasCursorShowVertLine[(int)al]));
			ao(bool.Parse(mySettings.GraphMeasCursorShowDot[(int)al]));
			mySettings = null;
		}
	}

	public void ao()
	{
		if (al != a.g)
		{
			MySettings mySettings = global::e.a();
			mySettings.GraphMeasXMin[(int)al] = ap().ToString(CultureInfo.InvariantCulture);
			mySettings.GraphMeasXMax[(int)al] = aq().ToString(CultureInfo.InvariantCulture);
			mySettings.GraphMeasAutoScaleXMax[(int)al] = ar().ToString();
			mySettings.GraphMeasAutoScaleXMin[(int)al] = @as().ToString();
			mySettings.GraphMeasCursorShowXValue[(int)al] = av().ToString();
			mySettings.GraphMeasCursorShowVertLine[(int)al] = au().ToString();
			mySettings.GraphMeasCursorShowDot[(int)al] = at().ToString();
			_ = null;
		}
	}
}
