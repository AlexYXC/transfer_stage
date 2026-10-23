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

namespace Filmetrics.FIUserRegistrationService;

[WebServiceBinding(Name = "FIUserRegistrationSoap", Namespace = "http://www.ficorpserv.com/")]
[GeneratedCode("System.Web.Services", "4.0.30319.1")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class FIUserRegistration : SoapHttpClientProtocol
{
	private SendOrPostCallback m_a;

	private bool b;

	[CompilerGenerated]
	private RegisterUserCompletedEventHandler c;

	public new string Url
	{
		get
		{
			return base.Url;
		}
		set
		{
			if (a(base.Url) && !b && !a(value))
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
			b = true;
		}
	}

	public event RegisterUserCompletedEventHandler RegisterUserCompleted
	{
		[CompilerGenerated]
		add
		{
			RegisterUserCompletedEventHandler registerUserCompletedEventHandler = c;
			RegisterUserCompletedEventHandler registerUserCompletedEventHandler2;
			do
			{
				registerUserCompletedEventHandler2 = registerUserCompletedEventHandler;
				RegisterUserCompletedEventHandler value2 = (RegisterUserCompletedEventHandler)Delegate.Combine(registerUserCompletedEventHandler2, value);
				registerUserCompletedEventHandler = Interlocked.CompareExchange(ref c, value2, registerUserCompletedEventHandler2);
			}
			while ((object)registerUserCompletedEventHandler != registerUserCompletedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			RegisterUserCompletedEventHandler registerUserCompletedEventHandler = c;
			RegisterUserCompletedEventHandler registerUserCompletedEventHandler2;
			do
			{
				registerUserCompletedEventHandler2 = registerUserCompletedEventHandler;
				RegisterUserCompletedEventHandler value2 = (RegisterUserCompletedEventHandler)Delegate.Remove(registerUserCompletedEventHandler2, value);
				registerUserCompletedEventHandler = Interlocked.CompareExchange(ref c, value2, registerUserCompletedEventHandler2);
			}
			while ((object)registerUserCompletedEventHandler != registerUserCompletedEventHandler2);
		}
	}

	public FIUserRegistration()
	{
		Url = "https://ficorpserv.com/FIWebServices/FIUserRegistration.asmx";
		if (a(Url))
		{
			UseDefaultCredentials = true;
			b = false;
		}
		else
		{
			b = true;
		}
	}

	[SoapDocumentMethod("http://www.ficorpserv.com/RegisterUser", RequestNamespace = "http://www.ficorpserv.com/", ResponseNamespace = "http://www.ficorpserv.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public bool RegisterUser(string userName, string emailAddress, string companyName, string stationName, string siteCode, string systemID, string systemSN, string theKey)
	{
		return Conversions.ToBoolean(Invoke("RegisterUser", new object[8] { userName, emailAddress, companyName, stationName, siteCode, systemID, systemSN, theKey })[0]);
	}

	public void RegisterUserAsync(string userName, string emailAddress, string companyName, string stationName, string siteCode, string systemID, string systemSN, string theKey)
	{
		RegisterUserAsync(userName, emailAddress, companyName, stationName, siteCode, systemID, systemSN, theKey, null);
	}

	public void RegisterUserAsync(string userName, string emailAddress, string companyName, string stationName, string siteCode, string systemID, string systemSN, string theKey, object userState)
	{
		if (this.m_a == null)
		{
			this.m_a = a;
		}
		InvokeAsync("RegisterUser", new object[8] { userName, emailAddress, companyName, stationName, siteCode, systemID, systemSN, theKey }, this.m_a, RuntimeHelpers.GetObjectValue(userState));
	}

	private void a(object A_0)
	{
		if (c != null)
		{
			InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)A_0;
			c?.Invoke(this, new RegisterUserCompletedEventArgs(e.Results, e.Error, e.Cancelled, RuntimeHelpers.GetObjectValue(e.UserState)));
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
