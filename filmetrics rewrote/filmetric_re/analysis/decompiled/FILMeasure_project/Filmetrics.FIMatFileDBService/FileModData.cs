using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Filmetrics.FIMatFileDBService;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.233")]
[XmlType(Namespace = "http://www.ficorpserv.com/")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class FileModData
{
	private string matNameField;

	private DateTime fileModDateUtcField;

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

	public DateTime FileModDateUtc
	{
		get
		{
			return fileModDateUtcField;
		}
		set
		{
			fileModDateUtcField = value;
		}
	}
}
