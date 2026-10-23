using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Filmetrics.FIMatFileDBService;

[Serializable]
[XmlType(Namespace = "http://www.ficorpserv.com/")]
[GeneratedCode("System.Xml", "4.0.30319.233")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class MatFileDBEvent
{
	private int eventIDField;

	private string userNameField;

	private ReleaseLevel newLevelField;

	private DateTime eventDateUTCField;

	private DateTime fileDataModDateUTCField;

	private string fileExtField;

	public int EventID
	{
		get
		{
			return eventIDField;
		}
		set
		{
			eventIDField = value;
		}
	}

	public string UserName
	{
		get
		{
			return userNameField;
		}
		set
		{
			userNameField = value;
		}
	}

	public ReleaseLevel NewLevel
	{
		get
		{
			return newLevelField;
		}
		set
		{
			newLevelField = value;
		}
	}

	public DateTime EventDateUTC
	{
		get
		{
			return eventDateUTCField;
		}
		set
		{
			eventDateUTCField = value;
		}
	}

	public DateTime FileDataModDateUTC
	{
		get
		{
			return fileDataModDateUTCField;
		}
		set
		{
			fileDataModDateUTCField = value;
		}
	}

	public string FileExt
	{
		get
		{
			return fileExtField;
		}
		set
		{
			fileExtField = value;
		}
	}
}
