using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Filmetrics.FIMatFileDBService;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.233")]
[XmlType(Namespace = "http://www.ficorpserv.com/")]
[DesignerCategory("code")]
public class FileData
{
	private string matNameField;

	private string matExtField;

	private ReleaseLevel matReleaseLevelField;

	public string MatName
	{
		get
		{
			return matNameField;
		}
		set
		{
			matNameField = value;
		}
	}

	public string MatExt
	{
		get
		{
			return matExtField;
		}
		set
		{
			matExtField = value;
		}
	}

	public ReleaseLevel MatReleaseLevel
	{
		get
		{
			return matReleaseLevelField;
		}
		set
		{
			matReleaseLevelField = value;
		}
	}
}
