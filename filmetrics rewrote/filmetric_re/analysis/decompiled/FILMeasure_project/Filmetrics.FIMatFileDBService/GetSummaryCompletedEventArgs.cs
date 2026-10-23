using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Filmetrics.FIMatFileDBService;

[GeneratedCode("System.Web.Services", "4.0.30319.1")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class GetSummaryCompletedEventArgs : AsyncCompletedEventArgs
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

	public DateTime lastIncrementalModUtc
	{
		get
		{
			RaiseExceptionIfNecessary();
			return Conversions.ToDate(a[1]);
		}
	}

	public DateTime lastNonIncrementalModUtc
	{
		get
		{
			RaiseExceptionIfNecessary();
			return Conversions.ToDate(a[2]);
		}
	}

	public FileData[] fileData
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (FileData[])a[3];
		}
	}

	internal GetSummaryCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3)
		: base(A_1, A_2, RuntimeHelpers.GetObjectValue(A_3))
	{
		a = A_0;
	}
}
