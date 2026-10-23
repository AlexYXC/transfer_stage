using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Filmetrics.FIMatFileDBService;

[GeneratedCode("System.Web.Services", "4.0.30319.1")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class GetUpdatedFilesInfoCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] a;

	public FileModData[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (FileModData[])a[0];
		}
	}

	internal GetUpdatedFilesInfoCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3)
		: base(A_1, A_2, RuntimeHelpers.GetObjectValue(A_3))
	{
		a = A_0;
	}
}
