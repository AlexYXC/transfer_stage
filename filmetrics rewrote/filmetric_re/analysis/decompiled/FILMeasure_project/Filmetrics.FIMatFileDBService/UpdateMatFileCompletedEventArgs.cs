using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Filmetrics.FIMatFileDBService;

[DebuggerStepThrough]
[GeneratedCode("System.Web.Services", "4.0.30319.1")]
[DesignerCategory("code")]
public class UpdateMatFileCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] a;

	public DateTime officialDataModDateUtc
	{
		get
		{
			RaiseExceptionIfNecessary();
			return Conversions.ToDate(a[0]);
		}
	}

	public string responseKey
	{
		get
		{
			RaiseExceptionIfNecessary();
			return Conversions.ToString(a[1]);
		}
	}

	internal UpdateMatFileCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3)
		: base(A_1, A_2, RuntimeHelpers.GetObjectValue(A_3))
	{
		a = A_0;
	}
}
