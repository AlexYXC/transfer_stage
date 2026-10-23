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
public class GetServerDateUtcCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] a;

	public DateTime Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return Conversions.ToDate(a[0]);
		}
	}

	public LicenseLevel userDBLicenseLevel
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (LicenseLevel)Conversions.ToInteger(a[1]);
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

	internal GetServerDateUtcCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3)
		: base(A_1, A_2, RuntimeHelpers.GetObjectValue(A_3))
	{
		a = A_0;
	}
}
