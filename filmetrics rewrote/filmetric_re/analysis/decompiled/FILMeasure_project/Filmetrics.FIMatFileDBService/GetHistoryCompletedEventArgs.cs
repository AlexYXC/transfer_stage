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
public class GetHistoryCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] a;

	public MatFileDBEvent[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (MatFileDBEvent[])a[0];
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

	internal GetHistoryCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3)
		: base(A_1, A_2, RuntimeHelpers.GetObjectValue(A_3))
	{
		a = A_0;
	}
}
