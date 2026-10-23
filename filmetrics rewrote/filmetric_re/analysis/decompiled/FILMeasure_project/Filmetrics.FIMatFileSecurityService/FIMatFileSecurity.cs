using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using Microsoft.VisualBasic.CompilerServices;

namespace Filmetrics.FIMatFileSecurityService;

[GeneratedCode("System.Web.Services", "4.0.30319.1")]
[DebuggerStepThrough]
[WebServiceBinding(Name = "FIMatFileSecuritySoap", Namespace = "http://www.ficorpserv.com/")]
[DesignerCategory("code")]
public class FIMatFileSecurity : SoapHttpClientProtocol
{
	private SendOrPostCallback m_a;

	private SendOrPostCallback m_b;

	private SendOrPostCallback m_c;

	private SendOrPostCallback m_d;

	private bool e;

	[CompilerGenerated]
	private RequestViewKeyCompletedEventHandler f;

	[CompilerGenerated]
	private RequestDecryptKeyCompletedEventHandler g;

	[CompilerGenerated]
	private RequestAddViewableMatFileCompletedEventHandler h;

	[CompilerGenerated]
	private RequestEndUserViewKeyCompletedEventHandler i;

	public new string Url
	{
		get
		{
			return base.Url;
		}
		set
		{
			if (a(base.Url) && !e && !a(value))
			{
				base.UseDefaultCredentials = false;
			}
			base.Url = value;
		}
	}

	public new bool UseDefaultCredentials
	{
		get
		{
			return base.UseDefaultCredentials;
		}
		set
		{
			base.UseDefaultCredentials = value;
			e = true;
		}
	}

	public event RequestViewKeyCompletedEventHandler RequestViewKeyCompleted
	{
		[CompilerGenerated]
		add
		{
			RequestViewKeyCompletedEventHandler requestViewKeyCompletedEventHandler = f;
			RequestViewKeyCompletedEventHandler requestViewKeyCompletedEventHandler2;
			do
			{
				requestViewKeyCompletedEventHandler2 = requestViewKeyCompletedEventHandler;
				RequestViewKeyCompletedEventHandler value2 = (RequestViewKeyCompletedEventHandler)Delegate.Combine(requestViewKeyCompletedEventHandler2, value);
				requestViewKeyCompletedEventHandler = Interlocked.CompareExchange(ref f, value2, requestViewKeyCompletedEventHandler2);
			}
			while ((object)requestViewKeyCompletedEventHandler != requestViewKeyCompletedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			RequestViewKeyCompletedEventHandler requestViewKeyCompletedEventHandler = f;
			RequestViewKeyCompletedEventHandler requestViewKeyCompletedEventHandler2;
			do
			{
				requestViewKeyCompletedEventHandler2 = requestViewKeyCompletedEventHandler;
				RequestViewKeyCompletedEventHandler value2 = (RequestViewKeyCompletedEventHandler)Delegate.Remove(requestViewKeyCompletedEventHandler2, value);
				requestViewKeyCompletedEventHandler = Interlocked.CompareExchange(ref f, value2, requestViewKeyCompletedEventHandler2);
			}
			while ((object)requestViewKeyCompletedEventHandler != requestViewKeyCompletedEventHandler2);
		}
	}

	public event RequestDecryptKeyCompletedEventHandler RequestDecryptKeyCompleted
	{
		[CompilerGenerated]
		add
		{
			RequestDecryptKeyCompletedEventHandler requestDecryptKeyCompletedEventHandler = g;
			RequestDecryptKeyCompletedEventHandler requestDecryptKeyCompletedEventHandler2;
			do
			{
				requestDecryptKeyCompletedEventHandler2 = requestDecryptKeyCompletedEventHandler;
				RequestDecryptKeyCompletedEventHandler value2 = (RequestDecryptKeyCompletedEventHandler)Delegate.Combine(requestDecryptKeyCompletedEventHandler2, value);
				requestDecryptKeyCompletedEventHandler = Interlocked.CompareExchange(ref g, value2, requestDecryptKeyCompletedEventHandler2);
			}
			while ((object)requestDecryptKeyCompletedEventHandler != requestDecryptKeyCompletedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			RequestDecryptKeyCompletedEventHandler requestDecryptKeyCompletedEventHandler = g;
			RequestDecryptKeyCompletedEventHandler requestDecryptKeyCompletedEventHandler2;
			do
			{
				requestDecryptKeyCompletedEventHandler2 = requestDecryptKeyCompletedEventHandler;
				RequestDecryptKeyCompletedEventHandler value2 = (RequestDecryptKeyCompletedEventHandler)Delegate.Remove(requestDecryptKeyCompletedEventHandler2, value);
				requestDecryptKeyCompletedEventHandler = Interlocked.CompareExchange(ref g, value2, requestDecryptKeyCompletedEventHandler2);
			}
			while ((object)requestDecryptKeyCompletedEventHandler != requestDecryptKeyCompletedEventHandler2);
		}
	}

	public event RequestAddViewableMatFileCompletedEventHandler RequestAddViewableMatFileCompleted
	{
		[CompilerGenerated]
		add
		{
			RequestAddViewableMatFileCompletedEventHandler requestAddViewableMatFileCompletedEventHandler = h;
			RequestAddViewableMatFileCompletedEventHandler requestAddViewableMatFileCompletedEventHandler2;
			do
			{
				requestAddViewableMatFileCompletedEventHandler2 = requestAddViewableMatFileCompletedEventHandler;
				RequestAddViewableMatFileCompletedEventHandler value2 = (RequestAddViewableMatFileCompletedEventHandler)Delegate.Combine(requestAddViewableMatFileCompletedEventHandler2, value);
				requestAddViewableMatFileCompletedEventHandler = Interlocked.CompareExchange(ref h, value2, requestAddViewableMatFileCompletedEventHandler2);
			}
			while ((object)requestAddViewableMatFileCompletedEventHandler != requestAddViewableMatFileCompletedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			RequestAddViewableMatFileCompletedEventHandler requestAddViewableMatFileCompletedEventHandler = h;
			RequestAddViewableMatFileCompletedEventHandler requestAddViewableMatFileCompletedEventHandler2;
			do
			{
				requestAddViewableMatFileCompletedEventHandler2 = requestAddViewableMatFileCompletedEventHandler;
				RequestAddViewableMatFileCompletedEventHandler value2 = (RequestAddViewableMatFileCompletedEventHandler)Delegate.Remove(requestAddViewableMatFileCompletedEventHandler2, value);
				requestAddViewableMatFileCompletedEventHandler = Interlocked.CompareExchange(ref h, value2, requestAddViewableMatFileCompletedEventHandler2);
			}
			while ((object)requestAddViewableMatFileCompletedEventHandler != requestAddViewableMatFileCompletedEventHandler2);
		}
	}

	public event RequestEndUserViewKeyCompletedEventHandler RequestEndUserViewKeyCompleted
	{
		[CompilerGenerated]
		add
		{
			RequestEndUserViewKeyCompletedEventHandler requestEndUserViewKeyCompletedEventHandler = i;
			RequestEndUserViewKeyCompletedEventHandler requestEndUserViewKeyCompletedEventHandler2;
			do
			{
				requestEndUserViewKeyCompletedEventHandler2 = requestEndUserViewKeyCompletedEventHandler;
				RequestEndUserViewKeyCompletedEventHandler value2 = (RequestEndUserViewKeyCompletedEventHandler)Delegate.Combine(requestEndUserViewKeyCompletedEventHandler2, value);
				requestEndUserViewKeyCompletedEventHandler = Interlocked.CompareExchange(ref i, value2, requestEndUserViewKeyCompletedEventHandler2);
			}
			while ((object)requestEndUserViewKeyCompletedEventHandler != requestEndUserViewKeyCompletedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			RequestEndUserViewKeyCompletedEventHandler requestEndUserViewKeyCompletedEventHandler = i;
			RequestEndUserViewKeyCompletedEventHandler requestEndUserViewKeyCompletedEventHandler2;
			do
			{
				requestEndUserViewKeyCompletedEventHandler2 = requestEndUserViewKeyCompletedEventHandler;
				RequestEndUserViewKeyCompletedEventHandler value2 = (RequestEndUserViewKeyCompletedEventHandler)Delegate.Remove(requestEndUserViewKeyCompletedEventHandler2, value);
				requestEndUserViewKeyCompletedEventHandler = Interlocked.CompareExchange(ref i, value2, requestEndUserViewKeyCompletedEventHandler2);
			}
			while ((object)requestEndUserViewKeyCompletedEventHandler != requestEndUserViewKeyCompletedEventHandler2);
		}
	}

	public FIMatFileSecurity()
	{
		Url = "https://ficorpserv.com/FIWebServices/FIMatFileSecurity.asmx";
		if (a(Url))
		{
			UseDefaultCredentials = true;
			e = false;
		}
		else
		{
			e = true;
		}
	}

	[SoapDocumentMethod("http://www.ficorpserv.com/RequestViewKey", RequestNamespace = "http://www.ficorpserv.com/", ResponseNamespace = "http://www.ficorpserv.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public string RequestViewKey(string userName, string origMatFileName, int matFileSignature, int instanceCode, string currentMatFileName)
	{
		return Conversions.ToString(Invoke("RequestViewKey", new object[5] { userName, origMatFileName, matFileSignature, instanceCode, currentMatFileName })[0]);
	}

	public void RequestViewKeyAsync(string userName, string origMatFileName, int matFileSignature, int instanceCode, string currentMatFileName)
	{
		RequestViewKeyAsync(userName, origMatFileName, matFileSignature, instanceCode, currentMatFileName, null);
	}

	public void RequestViewKeyAsync(string userName, string origMatFileName, int matFileSignature, int instanceCode, string currentMatFileName, object userState)
	{
		if (this.m_a == null)
		{
			this.m_a = d;
		}
		InvokeAsync("RequestViewKey", new object[5] { userName, origMatFileName, matFileSignature, instanceCode, currentMatFileName }, this.m_a, RuntimeHelpers.GetObjectValue(userState));
	}

	private void d(object A_0)
	{
		if (f != null)
		{
			InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)A_0;
			f?.Invoke(this, new RequestViewKeyCompletedEventArgs(e.Results, e.Error, e.Cancelled, RuntimeHelpers.GetObjectValue(e.UserState)));
		}
	}

	[SoapDocumentMethod("http://www.ficorpserv.com/RequestDecryptKey", RequestNamespace = "http://www.ficorpserv.com/", ResponseNamespace = "http://www.ficorpserv.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public string RequestDecryptKey(string userName, string origMatFileName, int matFileSignature, int instanceCode, string currentMatFileName)
	{
		return Conversions.ToString(Invoke("RequestDecryptKey", new object[5] { userName, origMatFileName, matFileSignature, instanceCode, currentMatFileName })[0]);
	}

	public void RequestDecryptKeyAsync(string userName, string origMatFileName, int matFileSignature, int instanceCode, string currentMatFileName)
	{
		RequestDecryptKeyAsync(userName, origMatFileName, matFileSignature, instanceCode, currentMatFileName, null);
	}

	public void RequestDecryptKeyAsync(string userName, string origMatFileName, int matFileSignature, int instanceCode, string currentMatFileName, object userState)
	{
		if (this.m_b == null)
		{
			this.m_b = c;
		}
		InvokeAsync("RequestDecryptKey", new object[5] { userName, origMatFileName, matFileSignature, instanceCode, currentMatFileName }, this.m_b, RuntimeHelpers.GetObjectValue(userState));
	}

	private void c(object A_0)
	{
		if (g != null)
		{
			InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)A_0;
			g?.Invoke(this, new RequestDecryptKeyCompletedEventArgs(e.Results, e.Error, e.Cancelled, RuntimeHelpers.GetObjectValue(e.UserState)));
		}
	}

	[SoapDocumentMethod("http://www.ficorpserv.com/RequestAddViewableMatFile", RequestNamespace = "http://www.ficorpserv.com/", ResponseNamespace = "http://www.ficorpserv.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public bool RequestAddViewableMatFile(string origMatFileName, int matFileSignature, string actualFileName, int instanceCode, string executionKey)
	{
		return Conversions.ToBoolean(Invoke("RequestAddViewableMatFile", new object[5] { origMatFileName, matFileSignature, actualFileName, instanceCode, executionKey })[0]);
	}

	public void RequestAddViewableMatFileAsync(string origMatFileName, int matFileSignature, string actualFileName, int instanceCode, string executionKey)
	{
		RequestAddViewableMatFileAsync(origMatFileName, matFileSignature, actualFileName, instanceCode, executionKey, null);
	}

	public void RequestAddViewableMatFileAsync(string origMatFileName, int matFileSignature, string actualFileName, int instanceCode, string executionKey, object userState)
	{
		if (this.m_c == null)
		{
			this.m_c = b;
		}
		InvokeAsync("RequestAddViewableMatFile", new object[5] { origMatFileName, matFileSignature, actualFileName, instanceCode, executionKey }, this.m_c, RuntimeHelpers.GetObjectValue(userState));
	}

	private void b(object A_0)
	{
		if (h != null)
		{
			InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)A_0;
			h?.Invoke(this, new RequestAddViewableMatFileCompletedEventArgs(e.Results, e.Error, e.Cancelled, RuntimeHelpers.GetObjectValue(e.UserState)));
		}
	}

	[SoapDocumentMethod("http://www.ficorpserv.com/RequestEndUserViewKey", RequestNamespace = "http://www.ficorpserv.com/", ResponseNamespace = "http://www.ficorpserv.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public string RequestEndUserViewKey(string userName, string emailAddress, string companyName, string stationName, string origMatFileName, int matFileSignature, int instanceCode, string currentMatFileName)
	{
		return Conversions.ToString(Invoke("RequestEndUserViewKey", new object[8] { userName, emailAddress, companyName, stationName, origMatFileName, matFileSignature, instanceCode, currentMatFileName })[0]);
	}

	public void RequestEndUserViewKeyAsync(string userName, string emailAddress, string companyName, string stationName, string origMatFileName, int matFileSignature, int instanceCode, string currentMatFileName)
	{
		RequestEndUserViewKeyAsync(userName, emailAddress, companyName, stationName, origMatFileName, matFileSignature, instanceCode, currentMatFileName, null);
	}

	public void RequestEndUserViewKeyAsync(string userName, string emailAddress, string companyName, string stationName, string origMatFileName, int matFileSignature, int instanceCode, string currentMatFileName, object userState)
	{
		if (this.m_d == null)
		{
			this.m_d = a;
		}
		InvokeAsync("RequestEndUserViewKey", new object[8] { userName, emailAddress, companyName, stationName, origMatFileName, matFileSignature, instanceCode, currentMatFileName }, this.m_d, RuntimeHelpers.GetObjectValue(userState));
	}

	private void a(object A_0)
	{
		if (i != null)
		{
			InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)A_0;
			i?.Invoke(this, new RequestEndUserViewKeyCompletedEventArgs(e.Results, e.Error, e.Cancelled, RuntimeHelpers.GetObjectValue(e.UserState)));
		}
	}

	public new void CancelAsync(object userState)
	{
		base.CancelAsync(RuntimeHelpers.GetObjectValue(userState));
	}

	private bool a(string A_0)
	{
		if (A_0 == null || (object)A_0 == string.Empty)
		{
			return false;
		}
		Uri uri = new Uri(A_0);
		if (uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		return false;
	}
}
