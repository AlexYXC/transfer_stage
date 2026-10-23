using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Filmetrics.FIMatFileDBService;

[GeneratedCode("System.Web.Services", "4.0.30319.1")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class GetDeletedFilesCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] a;

	public string[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (string[])a[0];
		}
	}

	internal GetDeletedFilesCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3)
		: base(A_1, A_2, RuntimeHelpers.GetObjectValue(A_3))
	{
		a = A_0;
	}
}
