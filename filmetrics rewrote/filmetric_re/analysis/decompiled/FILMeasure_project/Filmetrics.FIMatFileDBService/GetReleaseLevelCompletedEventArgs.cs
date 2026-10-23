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
public class GetReleaseLevelCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] a;

	public ReleaseLevel Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (ReleaseLevel)Conversions.ToInteger(a[0]);
		}
	}

	public bool credentialsOK
	{
		get
		{
			RaiseExceptionIfNecessary();
			return Conversions.ToBoolean(a[1]);
		}
	}

	public string responseKey
	{
		get
		{
			RaiseExceptionIfNecessary();
			return Conversions.ToString(a[2]);
		}
	}

	internal GetReleaseLevelCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3)
		: base(A_1, A_2, RuntimeHelpers.GetObjectValue(A_3))
	{
		a = A_0;
	}
}
