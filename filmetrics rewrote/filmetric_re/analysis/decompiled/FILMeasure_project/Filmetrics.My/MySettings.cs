using System;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Filmetrics.My;

[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings m_a;

	private static bool b;

	private static object c;

	public static MySettings Default
	{
		get
		{
			if (!b)
			{
				object obj = c;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					if (!b)
					{
						global::c.d().Shutdown += a;
						b = true;
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
			return MySettings.m_a;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("BK7")]
	public string LastUsedReflReferenceMaterial
	{
		get
		{
			return Conversions.ToString(this["LastUsedReflReferenceMaterial"]);
		}
		set
		{
			this["LastUsedReflReferenceMaterial"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("40")]
	public double LastSetIntegrationTime
	{
		get
		{
			return Conversions.ToDouble(this["LastSetIntegrationTime"]);
		}
		set
		{
			this["LastSetIntegrationTime"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool UseAutoScaleIntTime
	{
		get
		{
			return Conversions.ToBoolean(this["UseAutoScaleIntTime"]);
		}
		set
		{
			this["UseAutoScaleIntTime"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("3")]
	public short GraphMeasUserDefinedMaxCurves
	{
		get
		{
			return Conversions.ToShort(this["GraphMeasUserDefinedMaxCurves"]);
		}
		set
		{
			this["GraphMeasUserDefinedMaxCurves"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("1")]
	[DebuggerNonUserCode]
	public short NumSpectraToAverage
	{
		get
		{
			return Conversions.ToShort(this["NumSpectraToAverage"]);
		}
		set
		{
			this["NumSpectraToAverage"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("3")]
	public short NumPointsToSmooth
	{
		get
		{
			return Conversions.ToShort(this["NumPointsToSmooth"]);
		}
		set
		{
			this["NumPointsToSmooth"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.33")]
	public double UserSuppliedReflectance
	{
		get
		{
			return Conversions.ToDouble(this["UserSuppliedReflectance"]);
		}
		set
		{
			this["UserSuppliedReflectance"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SetSensitivityRadioOption
	{
		get
		{
			return Conversions.ToInteger(this["SetSensitivityRadioOption"]);
		}
		set
		{
			this["SetSensitivityRadioOption"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("400")]
	[DebuggerNonUserCode]
	public double MinSamplingTimeTotal
	{
		get
		{
			return Conversions.ToDouble(this["MinSamplingTimeTotal"]);
		}
		set
		{
			this["MinSamplingTimeTotal"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	public bool ShowSpectrumColor
	{
		get
		{
			return Conversions.ToBoolean(this["ShowSpectrumColor"]);
		}
		set
		{
			this["ShowSpectrumColor"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public short ShowSpectrumCoordOption
	{
		get
		{
			return Conversions.ToShort(this["ShowSpectrumCoordOption"]);
		}
		set
		{
			this["ShowSpectrumCoordOption"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	[UserScopedSetting]
	public int LastUsedOpenSpectrumFilter
	{
		get
		{
			return Conversions.ToInteger(this["LastUsedOpenSpectrumFilter"]);
		}
		set
		{
			this["LastUsedOpenSpectrumFilter"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int LastUsedOpenMaterialIndex
	{
		get
		{
			return Conversions.ToInteger(this["LastUsedOpenMaterialIndex"]);
		}
		set
		{
			this["LastUsedOpenMaterialIndex"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("70")]
	public float SpectrumColorLumValue
	{
		get
		{
			return Conversions.ToSingle(this["SpectrumColorLumValue"]);
		}
		set
		{
			this["SpectrumColorLumValue"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	[UserScopedSetting]
	public bool SpectrumColorFixLuminance
	{
		get
		{
			return Conversions.ToBoolean(this["SpectrumColorFixLuminance"]);
		}
		set
		{
			this["SpectrumColorFixLuminance"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>200</string>\r\n  <string>0</string>\r\n  <string>0</string>\r\n  <string>0</string>\r\n  <string>0</string>\r\n  <string>200</string>\r\n</ArrayOfString>")]
	public StringCollection GraphMeasXMin
	{
		get
		{
			return (StringCollection)this["GraphMeasXMin"];
		}
		set
		{
			this["GraphMeasXMin"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>1700</string>\r\n  <string>2000</string>\r\n  <string>50</string>\r\n  <string>50</string>\r\n  <string>100</string>\r\n  <string>1700</string>\r\n</ArrayOfString>")]
	[DebuggerNonUserCode]
	public StringCollection GraphMeasXMax
	{
		get
		{
			return (StringCollection)this["GraphMeasXMax"];
		}
		set
		{
			this["GraphMeasXMax"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>0</string>\r\n  <string>0</string>\r\n  <string>0</string>\r\n  <string>0</string>\r\n  <string>0</string>\r\n  <string>0</string>\r\n</ArrayOfString>")]
	[DebuggerNonUserCode]
	public StringCollection GraphMeasYMin
	{
		get
		{
			return (StringCollection)this["GraphMeasYMin"];
		}
		set
		{
			this["GraphMeasYMin"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>1.0</string>\r\n  <string>1.0</string>\r\n  <string>1.0</string>\r\n  <string>1.0</string>\r\n  <string>1.0</string>\r\n  <string>1.0</string>\r\n</ArrayOfString>")]
	public StringCollection GraphMeasYMax
	{
		get
		{
			return (StringCollection)this["GraphMeasYMax"];
		}
		set
		{
			this["GraphMeasYMax"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>True</string>\r\n  <string>True</string>\r\n  <string>True</string>\r\n  <string>True</string>\r\n  <string>True</string>\r\n  <string>True</string>\r\n</ArrayOfString>")]
	[DebuggerNonUserCode]
	public StringCollection GraphMeasAutoScaleYMax
	{
		get
		{
			return (StringCollection)this["GraphMeasAutoScaleYMax"];
		}
		set
		{
			this["GraphMeasAutoScaleYMax"] = value;
		}
	}

	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n</ArrayOfString>")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public StringCollection GraphMeasAutoScaleYMin
	{
		get
		{
			return (StringCollection)this["GraphMeasAutoScaleYMin"];
		}
		set
		{
			this["GraphMeasAutoScaleYMin"] = value;
		}
	}

	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>False</string>\r\n  <string>True</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n</ArrayOfString>")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public StringCollection GraphMeasAutoScaleXMax
	{
		get
		{
			return (StringCollection)this["GraphMeasAutoScaleXMax"];
		}
		set
		{
			this["GraphMeasAutoScaleXMax"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n</ArrayOfString>")]
	public StringCollection GraphMeasAutoScaleXMin
	{
		get
		{
			return (StringCollection)this["GraphMeasAutoScaleXMin"];
		}
		set
		{
			this["GraphMeasAutoScaleXMin"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>True</string>\r\n  <string>True</string>\r\n  <string>True</string>\r\n  <string>True</string>\r\n  <string>True</string>\r\n  <string>True</string>\r\n</ArrayOfString>")]
	[DebuggerNonUserCode]
	public StringCollection GraphMeasShowGrid
	{
		get
		{
			return (StringCollection)this["GraphMeasShowGrid"];
		}
		set
		{
			this["GraphMeasShowGrid"] = value;
		}
	}

	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>3</string>\r\n  <string>3</string>\r\n  <string>3</string>\r\n  <string>3</string>\r\n  <string>3</string>\r\n  <string>3</string>\r\n</ArrayOfString>")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public StringCollection GraphMeasDotSize
	{
		get
		{
			return (StringCollection)this["GraphMeasDotSize"];
		}
		set
		{
			this["GraphMeasDotSize"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	[UserScopedSetting]
	public short GraphBackColor
	{
		get
		{
			return Conversions.ToShort(this["GraphBackColor"]);
		}
		set
		{
			this["GraphBackColor"] = value;
		}
	}

	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>True</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n</ArrayOfString>")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public StringCollection GraphMeasYLabelPercent
	{
		get
		{
			return (StringCollection)this["GraphMeasYLabelPercent"];
		}
		set
		{
			this["GraphMeasYLabelPercent"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public short SpectrumColorObserver
	{
		get
		{
			return Conversions.ToShort(this["SpectrumColorObserver"]);
		}
		set
		{
			this["SpectrumColorObserver"] = value;
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public short SpectrumColorIlluminant
	{
		get
		{
			return Conversions.ToShort(this["SpectrumColorIlluminant"]);
		}
		set
		{
			this["SpectrumColorIlluminant"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("-1")]
	public int HistoryLastTrendParam
	{
		get
		{
			return Conversions.ToInteger(this["HistoryLastTrendParam"]);
		}
		set
		{
			this["HistoryLastTrendParam"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string OperatorID
	{
		get
		{
			return Conversions.ToString(this["OperatorID"]);
		}
		set
		{
			this["OperatorID"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("1")]
	public string LastUsedTransReferenceMaterial
	{
		get
		{
			return Conversions.ToString(this["LastUsedTransReferenceMaterial"]);
		}
		set
		{
			this["LastUsedTransReferenceMaterial"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>True</string>\r\n  <string>True</string>\r\n  <string>True</string>\r\n  <string>True</string>\r\n  <string>True</string>\r\n  <string>True</string>\r\n</ArrayOfString>")]
	[UserScopedSetting]
	public StringCollection GraphMeasAutoScaleY2Max
	{
		get
		{
			return (StringCollection)this["GraphMeasAutoScaleY2Max"];
		}
		set
		{
			this["GraphMeasAutoScaleY2Max"] = value;
		}
	}

	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>0</string>\r\n  <string>0</string>\r\n  <string>0</string>\r\n  <string>0</string>\r\n  <string>0</string>\r\n  <string>0</string>\r\n</ArrayOfString>")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public StringCollection GraphMeasY2Min
	{
		get
		{
			return (StringCollection)this["GraphMeasY2Min"];
		}
		set
		{
			this["GraphMeasY2Min"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>1.0</string>\r\n  <string>1.0</string>\r\n  <string>1.0</string>\r\n  <string>1.0</string>\r\n  <string>1.0</string>\r\n  <string>1.0</string>\r\n</ArrayOfString>")]
	[DebuggerNonUserCode]
	public StringCollection GraphMeasY2Max
	{
		get
		{
			return (StringCollection)this["GraphMeasY2Max"];
		}
		set
		{
			this["GraphMeasY2Max"] = value;
		}
	}

	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n</ArrayOfString>")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public StringCollection GraphMeasAutoScaleY2Min
	{
		get
		{
			return (StringCollection)this["GraphMeasAutoScaleY2Min"];
		}
		set
		{
			this["GraphMeasAutoScaleY2Min"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("5")]
	[DebuggerNonUserCode]
	public byte DisplaySignificantDigits
	{
		get
		{
			return Conversions.ToByte(this["DisplaySignificantDigits"]);
		}
		set
		{
			this["DisplaySignificantDigits"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string LastOpenSaveExportTargetImportSourcePath
	{
		get
		{
			return Conversions.ToString(this["LastOpenSaveExportTargetImportSourcePath"]);
		}
		set
		{
			this["LastOpenSaveExportTargetImportSourcePath"] = value;
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string LastSaveHistPath
	{
		get
		{
			return Conversions.ToString(this["LastSaveHistPath"]);
		}
		set
		{
			this["LastSaveHistPath"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	[UserScopedSetting]
	public float WhiteR
	{
		get
		{
			return Conversions.ToSingle(this["WhiteR"]);
		}
		set
		{
			this["WhiteR"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("1")]
	public float WhiteG
	{
		get
		{
			return Conversions.ToSingle(this["WhiteG"]);
		}
		set
		{
			this["WhiteG"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	[UserScopedSetting]
	public float WhiteB
	{
		get
		{
			return Conversions.ToSingle(this["WhiteB"]);
		}
		set
		{
			this["WhiteB"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("320")]
	public int CameraImageCenterCol
	{
		get
		{
			return Conversions.ToInteger(this["CameraImageCenterCol"]);
		}
		set
		{
			this["CameraImageCenterCol"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("256")]
	[UserScopedSetting]
	public int CameraImageCenterRow
	{
		get
		{
			return Conversions.ToInteger(this["CameraImageCenterRow"]);
		}
		set
		{
			this["CameraImageCenterRow"] = value;
		}
	}

	[DefaultSettingValue("0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int LastUsedSpecAnalysisTabIndex
	{
		get
		{
			return Conversions.ToInteger(this["LastUsedSpecAnalysisTabIndex"]);
		}
		set
		{
			this["LastUsedSpecAnalysisTabIndex"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string TechSupportUserName
	{
		get
		{
			return Conversions.ToString(this["TechSupportUserName"]);
		}
		set
		{
			this["TechSupportUserName"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string TechSupportUserEmail
	{
		get
		{
			return Conversions.ToString(this["TechSupportUserEmail"]);
		}
		set
		{
			this["TechSupportUserEmail"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string TechSupportUserCity
	{
		get
		{
			return Conversions.ToString(this["TechSupportUserCity"]);
		}
		set
		{
			this["TechSupportUserCity"] = value;
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string TechSupportUserState
	{
		get
		{
			return Conversions.ToString(this["TechSupportUserState"]);
		}
		set
		{
			this["TechSupportUserState"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string TechSupportUserCountry
	{
		get
		{
			return Conversions.ToString(this["TechSupportUserCountry"]);
		}
		set
		{
			this["TechSupportUserCountry"] = value;
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string TechSupportUserPhone
	{
		get
		{
			return Conversions.ToString(this["TechSupportUserPhone"]);
		}
		set
		{
			this["TechSupportUserPhone"] = value;
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string TechSupportUserCountryCode
	{
		get
		{
			return Conversions.ToString(this["TechSupportUserCountryCode"]);
		}
		set
		{
			this["TechSupportUserCountryCode"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string TechSupportUserCompany
	{
		get
		{
			return Conversions.ToString(this["TechSupportUserCompany"]);
		}
		set
		{
			this["TechSupportUserCompany"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool Upgraded
	{
		get
		{
			return Conversions.ToBoolean(this["Upgraded"]);
		}
		set
		{
			this["Upgraded"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string TechSupportFilesRootPath
	{
		get
		{
			return Conversions.ToString(this["TechSupportFilesRootPath"]);
		}
		set
		{
			this["TechSupportFilesRootPath"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string TechSupportRecipesRootPath
	{
		get
		{
			return Conversions.ToString(this["TechSupportRecipesRootPath"]);
		}
		set
		{
			this["TechSupportRecipesRootPath"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	[UserScopedSetting]
	public bool TechSupportOpenFolderInExplorer
	{
		get
		{
			return Conversions.ToBoolean(this["TechSupportOpenFolderInExplorer"]);
		}
		set
		{
			this["TechSupportOpenFolderInExplorer"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string TechSupportProvider
	{
		get
		{
			return Conversions.ToString(this["TechSupportProvider"]);
		}
		set
		{
			this["TechSupportProvider"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	[UserScopedSetting]
	public bool AlwayShowSpectrumCoordXYZ
	{
		get
		{
			return Conversions.ToBoolean(this["AlwayShowSpectrumCoordXYZ"]);
		}
		set
		{
			this["AlwayShowSpectrumCoordXYZ"] = value;
		}
	}

	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool AutoAppendResults
	{
		get
		{
			return Conversions.ToBoolean(this["AutoAppendResults"]);
		}
		set
		{
			this["AutoAppendResults"] = value;
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string AutoAppendResultsPath
	{
		get
		{
			return Conversions.ToString(this["AutoAppendResultsPath"]);
		}
		set
		{
			this["AutoAppendResultsPath"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("False")]
	public bool SaveOncePerSpectrum
	{
		get
		{
			return Conversions.ToBoolean(this["SaveOncePerSpectrum"]);
		}
		set
		{
			this["SaveOncePerSpectrum"] = value;
		}
	}

	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool ConfirmBeforeSaving
	{
		get
		{
			return Conversions.ToBoolean(this["ConfirmBeforeSaving"]);
		}
		set
		{
			this["ConfirmBeforeSaving"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("2")]
	public int LastUsedOpenHistoryFilter
	{
		get
		{
			return Conversions.ToInteger(this["LastUsedOpenHistoryFilter"]);
		}
		set
		{
			this["LastUsedOpenHistoryFilter"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("True")]
	public bool ConfirmBeforeClearingGraph
	{
		get
		{
			return Conversions.ToBoolean(this["ConfirmBeforeClearingGraph"]);
		}
		set
		{
			this["ConfirmBeforeClearingGraph"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	[UserScopedSetting]
	public bool ScreenShotIncludesMenuBar
	{
		get
		{
			return Conversions.ToBoolean(this["ScreenShotIncludesMenuBar"]);
		}
		set
		{
			this["ScreenShotIncludesMenuBar"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string TechSupportFIEmployee
	{
		get
		{
			return Conversions.ToString(this["TechSupportFIEmployee"]);
		}
		set
		{
			this["TechSupportFIEmployee"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string AutoUpdateLastPromptVer
	{
		get
		{
			return Conversions.ToString(this["AutoUpdateLastPromptVer"]);
		}
		set
		{
			this["AutoUpdateLastPromptVer"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("2009-03-12")]
	public DateTime AutoUpdateLastReminderDateTime
	{
		get
		{
			return Conversions.ToDate(this["AutoUpdateLastReminderDateTime"]);
		}
		set
		{
			this["AutoUpdateLastReminderDateTime"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("2")]
	[DebuggerNonUserCode]
	public double AutoUpdateReminderPeriod
	{
		get
		{
			return Conversions.ToDouble(this["AutoUpdateReminderPeriod"]);
		}
		set
		{
			this["AutoUpdateReminderPeriod"] = value;
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string SampleID
	{
		get
		{
			return Conversions.ToString(this["SampleID"]);
		}
		set
		{
			this["SampleID"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	[UserScopedSetting]
	public int LastSaveScreenshotFileTypeIdx
	{
		get
		{
			return Conversions.ToInteger(this["LastSaveScreenshotFileTypeIdx"]);
		}
		set
		{
			this["LastSaveScreenshotFileTypeIdx"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("50")]
	public float ReferenceMinIntenWRTHist
	{
		get
		{
			return Conversions.ToSingle(this["ReferenceMinIntenWRTHist"]);
		}
		set
		{
			this["ReferenceMinIntenWRTHist"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	public bool VideoShowSpot
	{
		get
		{
			return Conversions.ToBoolean(this["VideoShowSpot"]);
		}
		set
		{
			this["VideoShowSpot"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("150")]
	public float ReferenceMaxIntenWRTHist
	{
		get
		{
			return Conversions.ToSingle(this["ReferenceMaxIntenWRTHist"]);
		}
		set
		{
			this["ReferenceMaxIntenWRTHist"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("40")]
	public float PrecSimPixToPixNoisePkToPkRaw
	{
		get
		{
			return Conversions.ToSingle(this["PrecSimPixToPixNoisePkToPkRaw"]);
		}
		set
		{
			this["PrecSimPixToPixNoisePkToPkRaw"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("10")]
	[DebuggerNonUserCode]
	public float PrecSimDCNoisePkToPkRaw
	{
		get
		{
			return Conversions.ToSingle(this["PrecSimDCNoisePkToPkRaw"]);
		}
		set
		{
			this["PrecSimDCNoisePkToPkRaw"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50")]
	public int PrecSimNumIterations
	{
		get
		{
			return Conversions.ToInteger(this["PrecSimNumIterations"]);
		}
		set
		{
			this["PrecSimNumIterations"] = value;
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string PrecSimRawFile
	{
		get
		{
			return Conversions.ToString(this["PrecSimRawFile"]);
		}
		set
		{
			this["PrecSimRawFile"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("4096")]
	public long PrecSimFullScaleCounts
	{
		get
		{
			return Conversions.ToLong(this["PrecSimFullScaleCounts"]);
		}
		set
		{
			this["PrecSimFullScaleCounts"] = value;
		}
	}

	[DefaultSettingValue("140000")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public long PrecSimShotNoiseWellDepthElectrons
	{
		get
		{
			return Conversions.ToLong(this["PrecSimShotNoiseWellDepthElectrons"]);
		}
		set
		{
			this["PrecSimShotNoiseWellDepthElectrons"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public float PrecSimWavelenCalNoise_nm
	{
		get
		{
			return Conversions.ToSingle(this["PrecSimWavelenCalNoise_nm"]);
		}
		set
		{
			this["PrecSimWavelenCalNoise_nm"] = value;
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int PrecSimSetupMethod
	{
		get
		{
			return Conversions.ToInteger(this["PrecSimSetupMethod"]);
		}
		set
		{
			this["PrecSimSetupMethod"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("1")]
	public float PrecSimSpectrometerResolution_nm
	{
		get
		{
			return Conversions.ToSingle(this["PrecSimSpectrometerResolution_nm"]);
		}
		set
		{
			this["PrecSimSpectrometerResolution_nm"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string PrecSimConfigFile
	{
		get
		{
			return Conversions.ToString(this["PrecSimConfigFile"]);
		}
		set
		{
			this["PrecSimConfigFile"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("1")]
	[DebuggerNonUserCode]
	public int PrecSimNumIntegrationCycles
	{
		get
		{
			return Conversions.ToInteger(this["PrecSimNumIntegrationCycles"]);
		}
		set
		{
			this["PrecSimNumIntegrationCycles"] = value;
		}
	}

	[DefaultSettingValue("3000")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public double PrecSimPeakSignalIntensity
	{
		get
		{
			return Conversions.ToDouble(this["PrecSimPeakSignalIntensity"]);
		}
		set
		{
			this["PrecSimPeakSignalIntensity"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("0.5")]
	[UserScopedSetting]
	public float PrecSimDCAmplitudeUncertaintyPkToPkPct
	{
		get
		{
			return Conversions.ToSingle(this["PrecSimDCAmplitudeUncertaintyPkToPkPct"]);
		}
		set
		{
			this["PrecSimDCAmplitudeUncertaintyPkToPkPct"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("0.5")]
	[UserScopedSetting]
	public float PrecSimSampleHeightUncertainty_mm
	{
		get
		{
			return Conversions.ToSingle(this["PrecSimSampleHeightUncertainty_mm"]);
		}
		set
		{
			this["PrecSimSampleHeightUncertainty_mm"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	[UserScopedSetting]
	public bool PrecSimUseCustomIntegrationCycles
	{
		get
		{
			return Conversions.ToBoolean(this["PrecSimUseCustomIntegrationCycles"]);
		}
		set
		{
			this["PrecSimUseCustomIntegrationCycles"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PrecSimUseCustomPeakSignalIntensity
	{
		get
		{
			return Conversions.ToBoolean(this["PrecSimUseCustomPeakSignalIntensity"]);
		}
		set
		{
			this["PrecSimUseCustomPeakSignalIntensity"] = value;
		}
	}

	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool PrecSimUseCustomDCAmplUncert
	{
		get
		{
			return Conversions.ToBoolean(this["PrecSimUseCustomDCAmplUncert"]);
		}
		set
		{
			this["PrecSimUseCustomDCAmplUncert"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	public bool PrecSimOverrideSpecAmplitudeUncertainty
	{
		get
		{
			return Conversions.ToBoolean(this["PrecSimOverrideSpecAmplitudeUncertainty"]);
		}
		set
		{
			this["PrecSimOverrideSpecAmplitudeUncertainty"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("0.5")]
	[UserScopedSetting]
	public float PrecSimDCAmplitudeUncertaintyPkToPkPctSpecOverride
	{
		get
		{
			return Conversions.ToSingle(this["PrecSimDCAmplitudeUncertaintyPkToPkPctSpecOverride"]);
		}
		set
		{
			this["PrecSimDCAmplitudeUncertaintyPkToPkPctSpecOverride"] = value;
		}
	}

	[DefaultSettingValue("True")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool PrecSimDoWavelengthRangeStabilityCheck
	{
		get
		{
			return Conversions.ToBoolean(this["PrecSimDoWavelengthRangeStabilityCheck"]);
		}
		set
		{
			this["PrecSimDoWavelengthRangeStabilityCheck"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public float PrecSimWavelengthRangeReductionAmount
	{
		get
		{
			return Conversions.ToSingle(this["PrecSimWavelengthRangeReductionAmount"]);
		}
		set
		{
			this["PrecSimWavelengthRangeReductionAmount"] = value;
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string StandaloneConfiguration
	{
		get
		{
			return Conversions.ToString(this["StandaloneConfiguration"]);
		}
		set
		{
			this["StandaloneConfiguration"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("60")]
	public double GraphStripChartDurationSecs
	{
		get
		{
			return Conversions.ToDouble(this["GraphStripChartDurationSecs"]);
		}
		set
		{
			this["GraphStripChartDurationSecs"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool MonitorAutoSave
	{
		get
		{
			return Conversions.ToBoolean(this["MonitorAutoSave"]);
		}
		set
		{
			this["MonitorAutoSave"] = value;
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string MonitorAutoSaveBase
	{
		get
		{
			return Conversions.ToString(this["MonitorAutoSaveBase"]);
		}
		set
		{
			this["MonitorAutoSaveBase"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("5")]
	public int LastBatchAcqQuantity
	{
		get
		{
			return Conversions.ToInteger(this["LastBatchAcqQuantity"]);
		}
		set
		{
			this["LastBatchAcqQuantity"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string LastBatchAcqSaveFilenamePath
	{
		get
		{
			return Conversions.ToString(this["LastBatchAcqSaveFilenamePath"]);
		}
		set
		{
			this["LastBatchAcqSaveFilenamePath"] = value;
		}
	}

	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool LastBatchAcqSaveSetting
	{
		get
		{
			return Conversions.ToBoolean(this["LastBatchAcqSaveSetting"]);
		}
		set
		{
			this["LastBatchAcqSaveSetting"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	public bool PrecSimAcqSettingsFromSpectrumIfAvailable
	{
		get
		{
			return Conversions.ToBoolean(this["PrecSimAcqSettingsFromSpectrumIfAvailable"]);
		}
		set
		{
			this["PrecSimAcqSettingsFromSpectrumIfAvailable"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("5")]
	public double PrecSimIntegrationTime
	{
		get
		{
			return Conversions.ToDouble(this["PrecSimIntegrationTime"]);
		}
		set
		{
			this["PrecSimIntegrationTime"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	[UserScopedSetting]
	public bool SASWRecomputeShowColorSetting
	{
		get
		{
			return Conversions.ToBoolean(this["SASWRecomputeShowColorSetting"]);
		}
		set
		{
			this["SASWRecomputeShowColorSetting"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public int VideoOpacity
	{
		get
		{
			return Conversions.ToInteger(this["VideoOpacity"]);
		}
		set
		{
			this["VideoOpacity"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string ReportOutputPath
	{
		get
		{
			return Conversions.ToString(this["ReportOutputPath"]);
		}
		set
		{
			this["ReportOutputPath"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	[UserScopedSetting]
	public bool EditRecipeOutlineCompositionIsCollapsed
	{
		get
		{
			return Conversions.ToBoolean(this["EditRecipeOutlineCompositionIsCollapsed"]);
		}
		set
		{
			this["EditRecipeOutlineCompositionIsCollapsed"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("True")]
	public bool EditRecipeOutlineThicknessIsCollapsed
	{
		get
		{
			return Conversions.ToBoolean(this["EditRecipeOutlineThicknessIsCollapsed"]);
		}
		set
		{
			this["EditRecipeOutlineThicknessIsCollapsed"] = value;
		}
	}

	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool EditRecipeOutlineNonuniformityIsCollapsed
	{
		get
		{
			return Conversions.ToBoolean(this["EditRecipeOutlineNonuniformityIsCollapsed"]);
		}
		set
		{
			this["EditRecipeOutlineNonuniformityIsCollapsed"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	public bool ReportDontPromptBeforeMarkOverwrite
	{
		get
		{
			return Conversions.ToBoolean(this["ReportDontPromptBeforeMarkOverwrite"]);
		}
		set
		{
			this["ReportDontPromptBeforeMarkOverwrite"] = value;
		}
	}

	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool ReportDontPromptBeforeClose
	{
		get
		{
			return Conversions.ToBoolean(this["ReportDontPromptBeforeClose"]);
		}
		set
		{
			this["ReportDontPromptBeforeClose"] = value;
		}
	}

	[DefaultSettingValue("True")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool WaferShowColorMap
	{
		get
		{
			return Conversions.ToBoolean(this["WaferShowColorMap"]);
		}
		set
		{
			this["WaferShowColorMap"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	public bool WaferShowValue
	{
		get
		{
			return Conversions.ToBoolean(this["WaferShowValue"]);
		}
		set
		{
			this["WaferShowValue"] = value;
		}
	}

	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool WaferShowPoints
	{
		get
		{
			return Conversions.ToBoolean(this["WaferShowPoints"]);
		}
		set
		{
			this["WaferShowPoints"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	[UserScopedSetting]
	public bool WaferManualColorScale
	{
		get
		{
			return Conversions.ToBoolean(this["WaferManualColorScale"]);
		}
		set
		{
			this["WaferManualColorScale"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public float WaferManualMin
	{
		get
		{
			return Conversions.ToSingle(this["WaferManualMin"]);
		}
		set
		{
			this["WaferManualMin"] = value;
		}
	}

	[DefaultSettingValue("100")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public float WaferManualMax
	{
		get
		{
			return Conversions.ToSingle(this["WaferManualMax"]);
		}
		set
		{
			this["WaferManualMax"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	public bool WaferDiscreteColorMapping
	{
		get
		{
			return Conversions.ToBoolean(this["WaferDiscreteColorMapping"]);
		}
		set
		{
			this["WaferDiscreteColorMapping"] = value;
		}
	}

	[DefaultSettingValue("False")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool WaferUseRainbowColorScheme
	{
		get
		{
			return Conversions.ToBoolean(this["WaferUseRainbowColorScheme"]);
		}
		set
		{
			this["WaferUseRainbowColorScheme"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	[UserScopedSetting]
	public bool SASWPromptForConfiguration
	{
		get
		{
			return Conversions.ToBoolean(this["SASWPromptForConfiguration"]);
		}
		set
		{
			this["SASWPromptForConfiguration"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	public bool WaferPlotOnlyValidPoints
	{
		get
		{
			return Conversions.ToBoolean(this["WaferPlotOnlyValidPoints"]);
		}
		set
		{
			this["WaferPlotOnlyValidPoints"] = value;
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public byte WaferEtchDepTimeUnits
	{
		get
		{
			return Conversions.ToByte(this["WaferEtchDepTimeUnits"]);
		}
		set
		{
			this["WaferEtchDepTimeUnits"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public float WaferEtchDepTime
	{
		get
		{
			return Conversions.ToSingle(this["WaferEtchDepTime"]);
		}
		set
		{
			this["WaferEtchDepTime"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("9.75")]
	public float WaferMapFontSize
	{
		get
		{
			return Conversions.ToSingle(this["WaferMapFontSize"]);
		}
		set
		{
			this["WaferMapFontSize"] = value;
		}
	}

	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool PaperOrientationLandscape
	{
		get
		{
			return Conversions.ToBoolean(this["PaperOrientationLandscape"]);
		}
		set
		{
			this["PaperOrientationLandscape"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool PaperOrientationUpgraded
	{
		get
		{
			return Conversions.ToBoolean(this["PaperOrientationUpgraded"]);
		}
		set
		{
			this["PaperOrientationUpgraded"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	[UserScopedSetting]
	public bool WriteMarkedResultsOnly
	{
		get
		{
			return Conversions.ToBoolean(this["WriteMarkedResultsOnly"]);
		}
		set
		{
			this["WriteMarkedResultsOnly"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0.33")]
	public double UserSuppliedReferenceAngle1
	{
		get
		{
			return Conversions.ToDouble(this["UserSuppliedReferenceAngle1"]);
		}
		set
		{
			this["UserSuppliedReferenceAngle1"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	[UserScopedSetting]
	public bool ShowOpticsAndSpecStatus
	{
		get
		{
			return Conversions.ToBoolean(this["ShowOpticsAndSpecStatus"]);
		}
		set
		{
			this["ShowOpticsAndSpecStatus"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool AutoPositionLegends
	{
		get
		{
			return Conversions.ToBoolean(this["AutoPositionLegends"]);
		}
		set
		{
			this["AutoPositionLegends"] = value;
		}
	}

	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool ShowSpectrumColorDefaultHasBeenSet
	{
		get
		{
			return Conversions.ToBoolean(this["ShowSpectrumColorDefaultHasBeenSet"]);
		}
		set
		{
			this["ShowSpectrumColorDefaultHasBeenSet"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	public bool ContMeasPromptUserReAddToHistInclusion
	{
		get
		{
			return Conversions.ToBoolean(this["ContMeasPromptUserReAddToHistInclusion"]);
		}
		set
		{
			this["ContMeasPromptUserReAddToHistInclusion"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	public bool ContMeasAddAllToHist
	{
		get
		{
			return Conversions.ToBoolean(this["ContMeasAddAllToHist"]);
		}
		set
		{
			this["ContMeasAddAllToHist"] = value;
		}
	}

	[DefaultSettingValue("0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public byte SpectrumAutoSaveFileType
	{
		get
		{
			return Conversions.ToByte(this["SpectrumAutoSaveFileType"]);
		}
		set
		{
			this["SpectrumAutoSaveFileType"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	public bool WaferMapUseOptimalPath
	{
		get
		{
			return Conversions.ToBoolean(this["WaferMapUseOptimalPath"]);
		}
		set
		{
			this["WaferMapUseOptimalPath"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool VideoCollapseControl
	{
		get
		{
			return Conversions.ToBoolean(this["VideoCollapseControl"]);
		}
		set
		{
			this["VideoCollapseControl"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string WaferMapResultsPath
	{
		get
		{
			return Conversions.ToString(this["WaferMapResultsPath"]);
		}
		set
		{
			this["WaferMapResultsPath"] = value;
		}
	}

	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool PrintActiveCurveOnly
	{
		get
		{
			return Conversions.ToBoolean(this["PrintActiveCurveOnly"]);
		}
		set
		{
			this["PrintActiveCurveOnly"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	[UserScopedSetting]
	public bool WaferMapUseLinearInterpolation
	{
		get
		{
			return Conversions.ToBoolean(this["WaferMapUseLinearInterpolation"]);
		}
		set
		{
			this["WaferMapUseLinearInterpolation"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	public bool FICPMMMeasDetailsIsCollapsed
	{
		get
		{
			return Conversions.ToBoolean(this["FICPMMMeasDetailsIsCollapsed"]);
		}
		set
		{
			this["FICPMMMeasDetailsIsCollapsed"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	public bool FICPMMMeasRecipeIsCollapsed
	{
		get
		{
			return Conversions.ToBoolean(this["FICPMMMeasRecipeIsCollapsed"]);
		}
		set
		{
			this["FICPMMMeasRecipeIsCollapsed"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	[UserScopedSetting]
	public bool FICPMMMeasurementResultIsCollapsed
	{
		get
		{
			return Conversions.ToBoolean(this["FICPMMMeasurementResultIsCollapsed"]);
		}
		set
		{
			this["FICPMMMeasurementResultIsCollapsed"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	[UserScopedSetting]
	public bool FICPMMOperationIsCollapsed
	{
		get
		{
			return Conversions.ToBoolean(this["FICPMMOperationIsCollapsed"]);
		}
		set
		{
			this["FICPMMOperationIsCollapsed"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool FICPMMSampleInfoIsCollapsed
	{
		get
		{
			return Conversions.ToBoolean(this["FICPMMSampleInfoIsCollapsed"]);
		}
		set
		{
			this["FICPMMSampleInfoIsCollapsed"] = value;
		}
	}

	[DefaultSettingValue("False")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool FICPMMSecondaryColorIsCollapsed
	{
		get
		{
			return Conversions.ToBoolean(this["FICPMMSecondaryColorIsCollapsed"]);
		}
		set
		{
			this["FICPMMSecondaryColorIsCollapsed"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	[UserScopedSetting]
	public bool FICPMMSpectrumColorIsCollapsed
	{
		get
		{
			return Conversions.ToBoolean(this["FICPMMSpectrumColorIsCollapsed"]);
		}
		set
		{
			this["FICPMMSpectrumColorIsCollapsed"] = value;
		}
	}

	[DefaultSettingValue("False")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool FICPMMTemplateIsCollapsed
	{
		get
		{
			return Conversions.ToBoolean(this["FICPMMTemplateIsCollapsed"]);
		}
		set
		{
			this["FICPMMTemplateIsCollapsed"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("False")]
	public bool FICPMMTabPanelARHCIsCollapsed
	{
		get
		{
			return Conversions.ToBoolean(this["FICPMMTabPanelARHCIsCollapsed"]);
		}
		set
		{
			this["FICPMMTabPanelARHCIsCollapsed"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	public bool DisplayMeasStatusControls
	{
		get
		{
			return Conversions.ToBoolean(this["DisplayMeasStatusControls"]);
		}
		set
		{
			this["DisplayMeasStatusControls"] = value;
		}
	}

	[DefaultSettingValue("True")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool DisplayRecipeControls
	{
		get
		{
			return Conversions.ToBoolean(this["DisplayRecipeControls"]);
		}
		set
		{
			this["DisplayRecipeControls"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool DisplaySpectrumColorControls
	{
		get
		{
			return Conversions.ToBoolean(this["DisplaySpectrumColorControls"]);
		}
		set
		{
			this["DisplaySpectrumColorControls"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool DisplayTransmittanceColorControls
	{
		get
		{
			return Conversions.ToBoolean(this["DisplayTransmittanceColorControls"]);
		}
		set
		{
			this["DisplayTransmittanceColorControls"] = value;
		}
	}

	[DefaultSettingValue("True")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool DisplayMeasResultsControls
	{
		get
		{
			return Conversions.ToBoolean(this["DisplayMeasResultsControls"]);
		}
		set
		{
			this["DisplayMeasResultsControls"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("True")]
	public bool DisplayTemplateControls
	{
		get
		{
			return Conversions.ToBoolean(this["DisplayTemplateControls"]);
		}
		set
		{
			this["DisplayTemplateControls"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool WaferMapClearMeasAtFinish
	{
		get
		{
			return Conversions.ToBoolean(this["WaferMapClearMeasAtFinish"]);
		}
		set
		{
			this["WaferMapClearMeasAtFinish"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool WaferMapClearHistAtStart
	{
		get
		{
			return Conversions.ToBoolean(this["WaferMapClearHistAtStart"]);
		}
		set
		{
			this["WaferMapClearHistAtStart"] = value;
		}
	}

	[DefaultSettingValue("True")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool HistoryConfirmBeforeDelete
	{
		get
		{
			return Conversions.ToBoolean(this["HistoryConfirmBeforeDelete"]);
		}
		set
		{
			this["HistoryConfirmBeforeDelete"] = value;
		}
	}

	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool AutoTrackCalcCurve
	{
		get
		{
			return Conversions.ToBoolean(this["AutoTrackCalcCurve"]);
		}
		set
		{
			this["AutoTrackCalcCurve"] = value;
		}
	}

	[DefaultSettingValue("True")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool AutoTrackActiveCurve
	{
		get
		{
			return Conversions.ToBoolean(this["AutoTrackActiveCurve"]);
		}
		set
		{
			this["AutoTrackActiveCurve"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("True")]
	public bool WavelenCalEnable
	{
		get
		{
			return Conversions.ToBoolean(this["WavelenCalEnable"]);
		}
		set
		{
			this["WavelenCalEnable"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int WavelenCalMode
	{
		get
		{
			return Conversions.ToInteger(this["WavelenCalMode"]);
		}
		set
		{
			this["WavelenCalMode"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("10")]
	public float WavelenCalPeriodMinutes
	{
		get
		{
			return Conversions.ToSingle(this["WavelenCalPeriodMinutes"]);
		}
		set
		{
			this["WavelenCalPeriodMinutes"] = value;
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int DisplayedSpectrumTransformation
	{
		get
		{
			return Conversions.ToInteger(this["DisplayedSpectrumTransformation"]);
		}
		set
		{
			this["DisplayedSpectrumTransformation"] = value;
		}
	}

	[DefaultSettingValue("60")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public float BaselineRemindTimeMinutes
	{
		get
		{
			return Conversions.ToSingle(this["BaselineRemindTimeMinutes"]);
		}
		set
		{
			this["BaselineRemindTimeMinutes"] = value;
		}
	}

	[DefaultSettingValue("True")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool PromptForBaselineReminder
	{
		get
		{
			return Conversions.ToBoolean(this["PromptForBaselineReminder"]);
		}
		set
		{
			this["PromptForBaselineReminder"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	[UserScopedSetting]
	public bool PromptForDisconnectOK
	{
		get
		{
			return Conversions.ToBoolean(this["PromptForDisconnectOK"]);
		}
		set
		{
			this["PromptForDisconnectOK"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	public bool DisplaySampleInfoControls
	{
		get
		{
			return Conversions.ToBoolean(this["DisplaySampleInfoControls"]);
		}
		set
		{
			this["DisplaySampleInfoControls"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("False")]
	public bool SASWShowARHCIfNoSpectrum
	{
		get
		{
			return Conversions.ToBoolean(this["SASWShowARHCIfNoSpectrum"]);
		}
		set
		{
			this["SASWShowARHCIfNoSpectrum"] = value;
		}
	}

	[DefaultSettingValue("False")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool SaveHistoryIfAutoSaveMap
	{
		get
		{
			return Conversions.ToBoolean(this["SaveHistoryIfAutoSaveMap"]);
		}
		set
		{
			this["SaveHistoryIfAutoSaveMap"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n</ArrayOfString>")]
	public StringCollection GraphMeasCursorShowXValue
	{
		get
		{
			return (StringCollection)this["GraphMeasCursorShowXValue"];
		}
		set
		{
			this["GraphMeasCursorShowXValue"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n  <string>False</string>\r\n</ArrayOfString>")]
	[UserScopedSetting]
	public StringCollection GraphMeasCursorShowVertLine
	{
		get
		{
			return (StringCollection)this["GraphMeasCursorShowVertLine"];
		}
		set
		{
			this["GraphMeasCursorShowVertLine"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>True</string>\r\n  <string>True</string>\r\n  <string>True</string>\r\n  <string>True</string>\r\n  <string>True</string>\r\n  <string>True</string>\r\n</ArrayOfString>")]
	[UserScopedSetting]
	public StringCollection GraphMeasCursorShowDot
	{
		get
		{
			return (StringCollection)this["GraphMeasCursorShowDot"];
		}
		set
		{
			this["GraphMeasCursorShowDot"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string QCTechnician
	{
		get
		{
			return Conversions.ToString(this["QCTechnician"]);
		}
		set
		{
			this["QCTechnician"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int MapUniformityCalcMethod
	{
		get
		{
			return Conversions.ToInteger(this["MapUniformityCalcMethod"]);
		}
		set
		{
			this["MapUniformityCalcMethod"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int SampleReflOption
	{
		get
		{
			return Conversions.ToInteger(this["SampleReflOption"]);
		}
		set
		{
			this["SampleReflOption"] = value;
		}
	}

	[DefaultSettingValue("-1")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int HistoryLastSavedResultIdx
	{
		get
		{
			return Conversions.ToInteger(this["HistoryLastSavedResultIdx"]);
		}
		set
		{
			this["HistoryLastSavedResultIdx"] = value;
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string HistoryAutoSavePath
	{
		get
		{
			return Conversions.ToString(this["HistoryAutoSavePath"]);
		}
		set
		{
			this["HistoryAutoSavePath"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	public bool HistoryArchiveAutomatically
	{
		get
		{
			return Conversions.ToBoolean(this["HistoryArchiveAutomatically"]);
		}
		set
		{
			this["HistoryArchiveAutomatically"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int HistoryArchiveMaxDiskSpaceMB
	{
		get
		{
			return Conversions.ToInteger(this["HistoryArchiveMaxDiskSpaceMB"]);
		}
		set
		{
			this["HistoryArchiveMaxDiskSpaceMB"] = value;
		}
	}

	[DefaultSettingValue("False")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool HistoryArchiveClearAfterWrite
	{
		get
		{
			return Conversions.ToBoolean(this["HistoryArchiveClearAfterWrite"]);
		}
		set
		{
			this["HistoryArchiveClearAfterWrite"] = value;
		}
	}

	[DefaultSettingValue("False")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool UniformSpectrumDataPointSpacing
	{
		get
		{
			return Conversions.ToBoolean(this["UniformSpectrumDataPointSpacing"]);
		}
		set
		{
			this["UniformSpectrumDataPointSpacing"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	[UserScopedSetting]
	public bool UniformSpectrumDataFinePointSpacing
	{
		get
		{
			return Conversions.ToBoolean(this["UniformSpectrumDataFinePointSpacing"]);
		}
		set
		{
			this["UniformSpectrumDataFinePointSpacing"] = value;
		}
	}

	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool SASWShowUVAnalysisFeaturesIfNoSpectrum
	{
		get
		{
			return Conversions.ToBoolean(this["SASWShowUVAnalysisFeaturesIfNoSpectrum"]);
		}
		set
		{
			this["SASWShowUVAnalysisFeaturesIfNoSpectrum"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShareSettingsWithSelectedUsers
	{
		get
		{
			return Conversions.ToBoolean(this["ShareSettingsWithSelectedUsers"]);
		}
		set
		{
			this["ShareSettingsWithSelectedUsers"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	[UserScopedSetting]
	public bool ConfirmBeforeAutoIncreaseGraphMaxCurves
	{
		get
		{
			return Conversions.ToBoolean(this["ConfirmBeforeAutoIncreaseGraphMaxCurves"]);
		}
		set
		{
			this["ConfirmBeforeAutoIncreaseGraphMaxCurves"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("True")]
	public bool AutoIncreaseGraphMaxCurves
	{
		get
		{
			return Conversions.ToBoolean(this["AutoIncreaseGraphMaxCurves"]);
		}
		set
		{
			this["AutoIncreaseGraphMaxCurves"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("False")]
	public bool SASWShowCompositeRecipeIfNoSpectrum
	{
		get
		{
			return Conversions.ToBoolean(this["SASWShowCompositeRecipeIfNoSpectrum"]);
		}
		set
		{
			this["SASWShowCompositeRecipeIfNoSpectrum"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	[UserScopedSetting]
	public bool MapClickMovesToClickLocation
	{
		get
		{
			return Conversions.ToBoolean(this["MapClickMovesToClickLocation"]);
		}
		set
		{
			this["MapClickMovesToClickLocation"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("False")]
	public bool SASWShowLuminousReflectanceIfNoSpectrum
	{
		get
		{
			return Conversions.ToBoolean(this["SASWShowLuminousReflectanceIfNoSpectrum"]);
		}
		set
		{
			this["SASWShowLuminousReflectanceIfNoSpectrum"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	public bool WaferHandlerPrealignerEnabled
	{
		get
		{
			return Conversions.ToBoolean(this["WaferHandlerPrealignerEnabled"]);
		}
		set
		{
			this["WaferHandlerPrealignerEnabled"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	[UserScopedSetting]
	public int CassetteDisplayUnits
	{
		get
		{
			return Conversions.ToInteger(this["CassetteDisplayUnits"]);
		}
		set
		{
			this["CassetteDisplayUnits"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string LastShippingRecPath
	{
		get
		{
			return Conversions.ToString(this["LastShippingRecPath"]);
		}
		set
		{
			this["LastShippingRecPath"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("False")]
	public bool DualSpectrumGraphs
	{
		get
		{
			return Conversions.ToBoolean(this["DualSpectrumGraphs"]);
		}
		set
		{
			this["DualSpectrumGraphs"] = value;
		}
	}

	[DefaultSettingValue("0.0.0.0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string LastAssyVer
	{
		get
		{
			return Conversions.ToString(this["LastAssyVer"]);
		}
		set
		{
			this["LastAssyVer"] = value;
		}
	}

	[DefaultSettingValue("True")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool ShowWarningSwitchingMeasureTabs
	{
		get
		{
			return Conversions.ToBoolean(this["ShowWarningSwitchingMeasureTabs"]);
		}
		set
		{
			this["ShowWarningSwitchingMeasureTabs"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	[UserScopedSetting]
	public bool DetectGrayImageFromCamera
	{
		get
		{
			return Conversions.ToBoolean(this["DetectGrayImageFromCamera"]);
		}
		set
		{
			this["DetectGrayImageFromCamera"] = value;
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string CustomRecipePath
	{
		get
		{
			return Conversions.ToString(this["CustomRecipePath"]);
		}
		set
		{
			this["CustomRecipePath"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	public bool LightSourceAutoStandby
	{
		get
		{
			return Conversions.ToBoolean(this["LightSourceAutoStandby"]);
		}
		set
		{
			this["LightSourceAutoStandby"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("60")]
	public double LightSourceAutoStandbyDelayMinutes
	{
		get
		{
			return Conversions.ToDouble(this["LightSourceAutoStandbyDelayMinutes"]);
		}
		set
		{
			this["LightSourceAutoStandbyDelayMinutes"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string CustomMaterialPath
	{
		get
		{
			return Conversions.ToString(this["CustomMaterialPath"]);
		}
		set
		{
			this["CustomMaterialPath"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int OemSettingsCode
	{
		get
		{
			return Conversions.ToInteger(this["OemSettingsCode"]);
		}
		set
		{
			this["OemSettingsCode"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	[UserScopedSetting]
	public double LastWavelengthMinActiveSpec
	{
		get
		{
			return Conversions.ToDouble(this["LastWavelengthMinActiveSpec"]);
		}
		set
		{
			this["LastWavelengthMinActiveSpec"] = value;
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public double LastWavelengthMaxActiveSpec
	{
		get
		{
			return Conversions.ToDouble(this["LastWavelengthMaxActiveSpec"]);
		}
		set
		{
			this["LastWavelengthMaxActiveSpec"] = value;
		}
	}

	[DefaultSettingValue("True")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool ConfirmBeforeKeepingRemeasuredLocation
	{
		get
		{
			return Conversions.ToBoolean(this["ConfirmBeforeKeepingRemeasuredLocation"]);
		}
		set
		{
			this["ConfirmBeforeKeepingRemeasuredLocation"] = value;
		}
	}

	[DefaultSettingValue("False")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool ForceBaselineIfIntervalExceeded
	{
		get
		{
			return Conversions.ToBoolean(this["ForceBaselineIfIntervalExceeded"]);
		}
		set
		{
			this["ForceBaselineIfIntervalExceeded"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("Yellow")]
	[DebuggerNonUserCode]
	public Color MeasureSpotColor
	{
		get
		{
			object obj = this["MeasureSpotColor"];
			if (obj == null)
			{
				return default(Color);
			}
			return (Color)obj;
		}
		set
		{
			this["MeasureSpotColor"] = value;
		}
	}

	[DefaultSettingValue("True")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool PreferMicrosoftPrintToPDF
	{
		get
		{
			return Conversions.ToBoolean(this["PreferMicrosoftPrintToPDF"]);
		}
		set
		{
			this["PreferMicrosoftPrintToPDF"] = value;
		}
	}

	[DefaultSettingValue("False")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool RestrictColorWavelength
	{
		get
		{
			return Conversions.ToBoolean(this["RestrictColorWavelength"]);
		}
		set
		{
			this["RestrictColorWavelength"] = value;
		}
	}

	[DefaultSettingValue("360")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public float ColorWavelengthLowerLimitNm
	{
		get
		{
			return Conversions.ToSingle(this["ColorWavelengthLowerLimitNm"]);
		}
		set
		{
			this["ColorWavelengthLowerLimitNm"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("830")]
	[DebuggerNonUserCode]
	public float ColorWavelengthUpperLimitNm
	{
		get
		{
			return Conversions.ToSingle(this["ColorWavelengthUpperLimitNm"]);
		}
		set
		{
			this["ColorWavelengthUpperLimitNm"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string CustomPrintedLogoFullPath
	{
		get
		{
			return Conversions.ToString(this["CustomPrintedLogoFullPath"]);
		}
		set
		{
			this["CustomPrintedLogoFullPath"] = value;
		}
	}

	static MySettings()
	{
		MySettings.m_a = (MySettings)SettingsBase.Synchronized(new MySettings());
		c = RuntimeHelpers.GetObjectValue(new object());
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerNonUserCode]
	private static void a(object A_0, EventArgs A_1)
	{
		if (global::c.d().SaveMySettingsOnExit)
		{
			e.a().Save();
		}
	}
}
