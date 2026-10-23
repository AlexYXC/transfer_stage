using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Filmetrics.FIMatFileDBService;

[DesignerCategory("code")]
[GeneratedCode("System.Web.Services", "4.0.30319.1")]
[DebuggerStepThrough]
public class GetMatFileCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] a;

	public string Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return Conversions.ToString(a[0]);
		}
	}

	public string fileNameWithExt
	{
		get
		{
			RaiseExceptionIfNecessary();
			return Conversions.ToString(a[1]);
		}
	}

	public ReleaseLevel fileReleaseLevel
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (ReleaseLevel)Conversions.ToInteger(a[2]);
		}
	}

	public DateTime fileDataModDateUtc
	{
		get
		{
			RaiseExceptionIfNecessary();
			return Conversions.ToDate(a[3]);
		}
	}

	public byte[] fileContents
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (byte[])a[4];
		}
	}

	internal GetMatFileCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3)
		: base(A_1, A_2, RuntimeHelpers.GetObjectValue(A_3))
	{
		a = A_0;
	}
}
