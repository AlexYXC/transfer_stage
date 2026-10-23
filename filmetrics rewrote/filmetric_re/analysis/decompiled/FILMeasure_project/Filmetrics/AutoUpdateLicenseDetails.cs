namespace Filmetrics;

public class AutoUpdateLicenseDetails
{
	public enum AutoUpdateLevel
	{
		Alpha = 1,
		Beta,
		Release
	}

	public const string kAutoUpdateLevelAlphaName = "Alpha";

	public const string kAutoUpdateLevelBetaName = "Beta";

	public const string kAutoUpdateLevelReleaseName = "Release";

	// C# has no syntax for parameterized property 'AutoUpdateLevelString'.
	public static string get_AutoUpdateLevelString(AutoUpdateLevel aLevel)
	{
		switch (aLevel)
		{
		case AutoUpdateLevel.Alpha:
			return "Alpha";
		case AutoUpdateLevel.Beta:
			return "Beta";
		case AutoUpdateLevel.Release:
			return "Release";
		default:
		{
			int num = (int)aLevel;
			throw new ax("Invalid AutoUpdateLevel - " + num);
		}
		}
	}
}
