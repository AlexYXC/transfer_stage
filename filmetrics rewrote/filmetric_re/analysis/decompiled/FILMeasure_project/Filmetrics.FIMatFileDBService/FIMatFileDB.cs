using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace Filmetrics.FIMatFileDBService;

[WebServiceBinding(Name = "FIMatFileDBSoap", Namespace = "http://www.ficorpserv.com/")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Web.Services", "4.0.30319.1")]
public class FIMatFileDB : SoapHttpClientProtocol
{
	private SendOrPostCallback m_a;

	private SendOrPostCallback m_b;

	private SendOrPostCallback m_c;

	private SendOrPostCallback m_d;

	private SendOrPostCallback m_e;

	private SendOrPostCallback m_f;

	private SendOrPostCallback m_g;

	private SendOrPostCallback m_h;

	private SendOrPostCallback m_i;

	private SendOrPostCallback m_j;

	private SendOrPostCallback m_k;

	private bool l;

	[CompilerGenerated]
	private GetServerDateUtcCompletedEventHandler m;

	[CompilerGenerated]
	private GetHistoryCompletedEventHandler n;

	[CompilerGenerated]
	private GetSummaryCompletedEventHandler o;

	[CompilerGenerated]
	private GetReleaseLevelCompletedEventHandler p;

	[CompilerGenerated]
	private GetUpdatedFilesInfoCompletedEventHandler q;

	[CompilerGenerated]
	private GetDeletedFilesCompletedEventHandler r;

	[CompilerGenerated]
	private ChangeReleaseLevelCompletedEventHandler s;

	[CompilerGenerated]
	private DestroyFileCompletedEventHandler t;

	[CompilerGenerated]
	private UpdateMatFileCompletedEventHandler u;

	[CompilerGenerated]
	private GetNewestMatFileCompletedEventHandler v;

	[CompilerGenerated]
	private GetMatFileCompletedEventHandler w;

	public new string Url
	{
		get
		{
			return base.Url;
		}
		set
		{
			if (a(base.Url) && !l && !a(value))
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
			l = true;
		}
	}

	public event GetServerDateUtcCompletedEventHandler GetServerDateUtcCompleted
	{
		[CompilerGenerated]
		add
		{
			GetServerDateUtcCompletedEventHandler getServerDateUtcCompletedEventHandler = m;
			GetServerDateUtcCompletedEventHandler getServerDateUtcCompletedEventHandler2;
			do
			{
				getServerDateUtcCompletedEventHandler2 = getServerDateUtcCompletedEventHandler;
				GetServerDateUtcCompletedEventHandler value2 = (GetServerDateUtcCompletedEventHandler)Delegate.Combine(getServerDateUtcCompletedEventHandler2, value);
				getServerDateUtcCompletedEventHandler = Interlocked.CompareExchange(ref m, value2, getServerDateUtcCompletedEventHandler2);
			}
			while ((object)getServerDateUtcCompletedEventHandler != getServerDateUtcCompletedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			GetServerDateUtcCompletedEventHandler getServerDateUtcCompletedEventHandler = m;
			GetServerDateUtcCompletedEventHandler getServerDateUtcCompletedEventHandler2;
			do
			{
				getServerDateUtcCompletedEventHandler2 = getServerDateUtcCompletedEventHandler;
				GetServerDateUtcCompletedEventHandler value2 = (GetServerDateUtcCompletedEventHandler)Delegate.Remove(getServerDateUtcCompletedEventHandler2, value);
				getServerDateUtcCompletedEventHandler = Interlocked.CompareExchange(ref m, value2, getServerDateUtcCompletedEventHandler2);
			}
			while ((object)getServerDateUtcCompletedEventHandler != getServerDateUtcCompletedEventHandler2);
		}
	}

	public event GetHistoryCompletedEventHandler GetHistoryCompleted
	{
		[CompilerGenerated]
		add
		{
			GetHistoryCompletedEventHandler getHistoryCompletedEventHandler = n;
			GetHistoryCompletedEventHandler getHistoryCompletedEventHandler2;
			do
			{
				getHistoryCompletedEventHandler2 = getHistoryCompletedEventHandler;
				GetHistoryCompletedEventHandler value2 = (GetHistoryCompletedEventHandler)Delegate.Combine(getHistoryCompletedEventHandler2, value);
				getHistoryCompletedEventHandler = Interlocked.CompareExchange(ref n, value2, getHistoryCompletedEventHandler2);
			}
			while ((object)getHistoryCompletedEventHandler != getHistoryCompletedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			GetHistoryCompletedEventHandler getHistoryCompletedEventHandler = n;
			GetHistoryCompletedEventHandler getHistoryCompletedEventHandler2;
			do
			{
				getHistoryCompletedEventHandler2 = getHistoryCompletedEventHandler;
				GetHistoryCompletedEventHandler value2 = (GetHistoryCompletedEventHandler)Delegate.Remove(getHistoryCompletedEventHandler2, value);
				getHistoryCompletedEventHandler = Interlocked.CompareExchange(ref n, value2, getHistoryCompletedEventHandler2);
			}
			while ((object)getHistoryCompletedEventHandler != getHistoryCompletedEventHandler2);
		}
	}

	public event GetSummaryCompletedEventHandler GetSummaryCompleted
	{
		[CompilerGenerated]
		add
		{
			GetSummaryCompletedEventHandler getSummaryCompletedEventHandler = o;
			GetSummaryCompletedEventHandler getSummaryCompletedEventHandler2;
			do
			{
				getSummaryCompletedEventHandler2 = getSummaryCompletedEventHandler;
				GetSummaryCompletedEventHandler value2 = (GetSummaryCompletedEventHandler)Delegate.Combine(getSummaryCompletedEventHandler2, value);
				getSummaryCompletedEventHandler = Interlocked.CompareExchange(ref o, value2, getSummaryCompletedEventHandler2);
			}
			while ((object)getSummaryCompletedEventHandler != getSummaryCompletedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			GetSummaryCompletedEventHandler getSummaryCompletedEventHandler = o;
			GetSummaryCompletedEventHandler getSummaryCompletedEventHandler2;
			do
			{
				getSummaryCompletedEventHandler2 = getSummaryCompletedEventHandler;
				GetSummaryCompletedEventHandler value2 = (GetSummaryCompletedEventHandler)Delegate.Remove(getSummaryCompletedEventHandler2, value);
				getSummaryCompletedEventHandler = Interlocked.CompareExchange(ref o, value2, getSummaryCompletedEventHandler2);
			}
			while ((object)getSummaryCompletedEventHandler != getSummaryCompletedEventHandler2);
		}
	}

	public event GetReleaseLevelCompletedEventHandler GetReleaseLevelCompleted
	{
		[CompilerGenerated]
		add
		{
			GetReleaseLevelCompletedEventHandler getReleaseLevelCompletedEventHandler = p;
			GetReleaseLevelCompletedEventHandler getReleaseLevelCompletedEventHandler2;
			do
			{
				getReleaseLevelCompletedEventHandler2 = getReleaseLevelCompletedEventHandler;
				GetReleaseLevelCompletedEventHandler value2 = (GetReleaseLevelCompletedEventHandler)Delegate.Combine(getReleaseLevelCompletedEventHandler2, value);
				getReleaseLevelCompletedEventHandler = Interlocked.CompareExchange(ref p, value2, getReleaseLevelCompletedEventHandler2);
			}
			while ((object)getReleaseLevelCompletedEventHandler != getReleaseLevelCompletedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			GetReleaseLevelCompletedEventHandler getReleaseLevelCompletedEventHandler = p;
			GetReleaseLevelCompletedEventHandler getReleaseLevelCompletedEventHandler2;
			do
			{
				getReleaseLevelCompletedEventHandler2 = getReleaseLevelCompletedEventHandler;
				GetReleaseLevelCompletedEventHandler value2 = (GetReleaseLevelCompletedEventHandler)Delegate.Remove(getReleaseLevelCompletedEventHandler2, value);
				getReleaseLevelCompletedEventHandler = Interlocked.CompareExchange(ref p, value2, getReleaseLevelCompletedEventHandler2);
			}
			while ((object)getReleaseLevelCompletedEventHandler != getReleaseLevelCompletedEventHandler2);
		}
	}

	public event GetUpdatedFilesInfoCompletedEventHandler GetUpdatedFilesInfoCompleted
	{
		[CompilerGenerated]
		add
		{
			GetUpdatedFilesInfoCompletedEventHandler getUpdatedFilesInfoCompletedEventHandler = q;
			GetUpdatedFilesInfoCompletedEventHandler getUpdatedFilesInfoCompletedEventHandler2;
			do
			{
				getUpdatedFilesInfoCompletedEventHandler2 = getUpdatedFilesInfoCompletedEventHandler;
				GetUpdatedFilesInfoCompletedEventHandler value2 = (GetUpdatedFilesInfoCompletedEventHandler)Delegate.Combine(getUpdatedFilesInfoCompletedEventHandler2, value);
				getUpdatedFilesInfoCompletedEventHandler = Interlocked.CompareExchange(ref q, value2, getUpdatedFilesInfoCompletedEventHandler2);
			}
			while ((object)getUpdatedFilesInfoCompletedEventHandler != getUpdatedFilesInfoCompletedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			GetUpdatedFilesInfoCompletedEventHandler getUpdatedFilesInfoCompletedEventHandler = q;
			GetUpdatedFilesInfoCompletedEventHandler getUpdatedFilesInfoCompletedEventHandler2;
			do
			{
				getUpdatedFilesInfoCompletedEventHandler2 = getUpdatedFilesInfoCompletedEventHandler;
				GetUpdatedFilesInfoCompletedEventHandler value2 = (GetUpdatedFilesInfoCompletedEventHandler)Delegate.Remove(getUpdatedFilesInfoCompletedEventHandler2, value);
				getUpdatedFilesInfoCompletedEventHandler = Interlocked.CompareExchange(ref q, value2, getUpdatedFilesInfoCompletedEventHandler2);
			}
			while ((object)getUpdatedFilesInfoCompletedEventHandler != getUpdatedFilesInfoCompletedEventHandler2);
		}
	}

	public event GetDeletedFilesCompletedEventHandler GetDeletedFilesCompleted
	{
		[CompilerGenerated]
		add
		{
			GetDeletedFilesCompletedEventHandler getDeletedFilesCompletedEventHandler = r;
			GetDeletedFilesCompletedEventHandler getDeletedFilesCompletedEventHandler2;
			do
			{
				getDeletedFilesCompletedEventHandler2 = getDeletedFilesCompletedEventHandler;
				GetDeletedFilesCompletedEventHandler value2 = (GetDeletedFilesCompletedEventHandler)Delegate.Combine(getDeletedFilesCompletedEventHandler2, value);
				getDeletedFilesCompletedEventHandler = Interlocked.CompareExchange(ref r, value2, getDeletedFilesCompletedEventHandler2);
			}
			while ((object)getDeletedFilesCompletedEventHandler != getDeletedFilesCompletedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			GetDeletedFilesCompletedEventHandler getDeletedFilesCompletedEventHandler = r;
			GetDeletedFilesCompletedEventHandler getDeletedFilesCompletedEventHandler2;
			do
			{
				getDeletedFilesCompletedEventHandler2 = getDeletedFilesCompletedEventHandler;
				GetDeletedFilesCompletedEventHandler value2 = (GetDeletedFilesCompletedEventHandler)Delegate.Remove(getDeletedFilesCompletedEventHandler2, value);
				getDeletedFilesCompletedEventHandler = Interlocked.CompareExchange(ref r, value2, getDeletedFilesCompletedEventHandler2);
			}
			while ((object)getDeletedFilesCompletedEventHandler != getDeletedFilesCompletedEventHandler2);
		}
	}

	public event ChangeReleaseLevelCompletedEventHandler ChangeReleaseLevelCompleted
	{
		[CompilerGenerated]
		add
		{
			ChangeReleaseLevelCompletedEventHandler changeReleaseLevelCompletedEventHandler = s;
			ChangeReleaseLevelCompletedEventHandler changeReleaseLevelCompletedEventHandler2;
			do
			{
				changeReleaseLevelCompletedEventHandler2 = changeReleaseLevelCompletedEventHandler;
				ChangeReleaseLevelCompletedEventHandler value2 = (ChangeReleaseLevelCompletedEventHandler)Delegate.Combine(changeReleaseLevelCompletedEventHandler2, value);
				changeReleaseLevelCompletedEventHandler = Interlocked.CompareExchange(ref s, value2, changeReleaseLevelCompletedEventHandler2);
			}
			while ((object)changeReleaseLevelCompletedEventHandler != changeReleaseLevelCompletedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			ChangeReleaseLevelCompletedEventHandler changeReleaseLevelCompletedEventHandler = s;
			ChangeReleaseLevelCompletedEventHandler changeReleaseLevelCompletedEventHandler2;
			do
			{
				changeReleaseLevelCompletedEventHandler2 = changeReleaseLevelCompletedEventHandler;
				ChangeReleaseLevelCompletedEventHandler value2 = (ChangeReleaseLevelCompletedEventHandler)Delegate.Remove(changeReleaseLevelCompletedEventHandler2, value);
				changeReleaseLevelCompletedEventHandler = Interlocked.CompareExchange(ref s, value2, changeReleaseLevelCompletedEventHandler2);
			}
			while ((object)changeReleaseLevelCompletedEventHandler != changeReleaseLevelCompletedEventHandler2);
		}
	}

	public event DestroyFileCompletedEventHandler DestroyFileCompleted
	{
		[CompilerGenerated]
		add
		{
			DestroyFileCompletedEventHandler destroyFileCompletedEventHandler = t;
			DestroyFileCompletedEventHandler destroyFileCompletedEventHandler2;
			do
			{
				destroyFileCompletedEventHandler2 = destroyFileCompletedEventHandler;
				DestroyFileCompletedEventHandler value2 = (DestroyFileCompletedEventHandler)Delegate.Combine(destroyFileCompletedEventHandler2, value);
				destroyFileCompletedEventHandler = Interlocked.CompareExchange(ref t, value2, destroyFileCompletedEventHandler2);
			}
			while ((object)destroyFileCompletedEventHandler != destroyFileCompletedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			DestroyFileCompletedEventHandler destroyFileCompletedEventHandler = t;
			DestroyFileCompletedEventHandler destroyFileCompletedEventHandler2;
			do
			{
				destroyFileCompletedEventHandler2 = destroyFileCompletedEventHandler;
				DestroyFileCompletedEventHandler value2 = (DestroyFileCompletedEventHandler)Delegate.Remove(destroyFileCompletedEventHandler2, value);
				destroyFileCompletedEventHandler = Interlocked.CompareExchange(ref t, value2, destroyFileCompletedEventHandler2);
			}
			while ((object)destroyFileCompletedEventHandler != destroyFileCompletedEventHandler2);
		}
	}

	public event UpdateMatFileCompletedEventHandler UpdateMatFileCompleted
	{
		[CompilerGenerated]
		add
		{
			UpdateMatFileCompletedEventHandler updateMatFileCompletedEventHandler = u;
			UpdateMatFileCompletedEventHandler updateMatFileCompletedEventHandler2;
			do
			{
				updateMatFileCompletedEventHandler2 = updateMatFileCompletedEventHandler;
				UpdateMatFileCompletedEventHandler value2 = (UpdateMatFileCompletedEventHandler)Delegate.Combine(updateMatFileCompletedEventHandler2, value);
				updateMatFileCompletedEventHandler = Interlocked.CompareExchange(ref u, value2, updateMatFileCompletedEventHandler2);
			}
			while ((object)updateMatFileCompletedEventHandler != updateMatFileCompletedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			UpdateMatFileCompletedEventHandler updateMatFileCompletedEventHandler = u;
			UpdateMatFileCompletedEventHandler updateMatFileCompletedEventHandler2;
			do
			{
				updateMatFileCompletedEventHandler2 = updateMatFileCompletedEventHandler;
				UpdateMatFileCompletedEventHandler value2 = (UpdateMatFileCompletedEventHandler)Delegate.Remove(updateMatFileCompletedEventHandler2, value);
				updateMatFileCompletedEventHandler = Interlocked.CompareExchange(ref u, value2, updateMatFileCompletedEventHandler2);
			}
			while ((object)updateMatFileCompletedEventHandler != updateMatFileCompletedEventHandler2);
		}
	}

	public event GetNewestMatFileCompletedEventHandler GetNewestMatFileCompleted
	{
		[CompilerGenerated]
		add
		{
			GetNewestMatFileCompletedEventHandler getNewestMatFileCompletedEventHandler = v;
			GetNewestMatFileCompletedEventHandler getNewestMatFileCompletedEventHandler2;
			do
			{
				getNewestMatFileCompletedEventHandler2 = getNewestMatFileCompletedEventHandler;
				GetNewestMatFileCompletedEventHandler value2 = (GetNewestMatFileCompletedEventHandler)Delegate.Combine(getNewestMatFileCompletedEventHandler2, value);
				getNewestMatFileCompletedEventHandler = Interlocked.CompareExchange(ref v, value2, getNewestMatFileCompletedEventHandler2);
			}
			while ((object)getNewestMatFileCompletedEventHandler != getNewestMatFileCompletedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			GetNewestMatFileCompletedEventHandler getNewestMatFileCompletedEventHandler = v;
			GetNewestMatFileCompletedEventHandler getNewestMatFileCompletedEventHandler2;
			do
			{
				getNewestMatFileCompletedEventHandler2 = getNewestMatFileCompletedEventHandler;
				GetNewestMatFileCompletedEventHandler value2 = (GetNewestMatFileCompletedEventHandler)Delegate.Remove(getNewestMatFileCompletedEventHandler2, value);
				getNewestMatFileCompletedEventHandler = Interlocked.CompareExchange(ref v, value2, getNewestMatFileCompletedEventHandler2);
			}
			while ((object)getNewestMatFileCompletedEventHandler != getNewestMatFileCompletedEventHandler2);
		}
	}

	public event GetMatFileCompletedEventHandler GetMatFileCompleted
	{
		[CompilerGenerated]
		add
		{
			GetMatFileCompletedEventHandler getMatFileCompletedEventHandler = w;
			GetMatFileCompletedEventHandler getMatFileCompletedEventHandler2;
			do
			{
				getMatFileCompletedEventHandler2 = getMatFileCompletedEventHandler;
				GetMatFileCompletedEventHandler value2 = (GetMatFileCompletedEventHandler)Delegate.Combine(getMatFileCompletedEventHandler2, value);
				getMatFileCompletedEventHandler = Interlocked.CompareExchange(ref w, value2, getMatFileCompletedEventHandler2);
			}
			while ((object)getMatFileCompletedEventHandler != getMatFileCompletedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			GetMatFileCompletedEventHandler getMatFileCompletedEventHandler = w;
			GetMatFileCompletedEventHandler getMatFileCompletedEventHandler2;
			do
			{
				getMatFileCompletedEventHandler2 = getMatFileCompletedEventHandler;
				GetMatFileCompletedEventHandler value2 = (GetMatFileCompletedEventHandler)Delegate.Remove(getMatFileCompletedEventHandler2, value);
				getMatFileCompletedEventHandler = Interlocked.CompareExchange(ref w, value2, getMatFileCompletedEventHandler2);
			}
			while ((object)getMatFileCompletedEventHandler != getMatFileCompletedEventHandler2);
		}
	}

	public FIMatFileDB()
	{
		Url = "https://ficorpserv.com/FIWebServices/FIMatFileDB.asmx";
		if (a(Url))
		{
			UseDefaultCredentials = true;
			l = false;
		}
		else
		{
			l = true;
		}
	}

	[SoapDocumentMethod("http://www.ficorpserv.com/GetServerDateUtc", RequestNamespace = "http://www.ficorpserv.com/", ResponseNamespace = "http://www.ficorpserv.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public DateTime GetServerDateUtc(string userName, ref LicenseLevel userDBLicenseLevel, ref string responseKey)
	{
		object[] array = Invoke("GetServerDateUtc", new object[3] { userName, userDBLicenseLevel, responseKey });
		userDBLicenseLevel = (LicenseLevel)Conversions.ToInteger(array[1]);
		responseKey = Conversions.ToString(array[2]);
		return Conversions.ToDate(array[0]);
	}

	public void GetServerDateUtcAsync(string userName, LicenseLevel userDBLicenseLevel, string responseKey)
	{
		GetServerDateUtcAsync(userName, userDBLicenseLevel, responseKey, null);
	}

	public void GetServerDateUtcAsync(string userName, LicenseLevel userDBLicenseLevel, string responseKey, object userState)
	{
		if (this.m_a == null)
		{
			this.m_a = k;
		}
		InvokeAsync("GetServerDateUtc", new object[3] { userName, userDBLicenseLevel, responseKey }, this.m_a, RuntimeHelpers.GetObjectValue(userState));
	}

	private void k(object A_0)
	{
		if (m != null)
		{
			InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)A_0;
			m?.Invoke(this, new GetServerDateUtcCompletedEventArgs(e.Results, e.Error, e.Cancelled, RuntimeHelpers.GetObjectValue(e.UserState)));
		}
	}

	[SoapDocumentMethod("http://www.ficorpserv.com/GetHistory", RequestNamespace = "http://www.ficorpserv.com/", ResponseNamespace = "http://www.ficorpserv.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public MatFileDBEvent[] GetHistory(string userName, FileType fileType, string matName, string instanceCode, string executionKey, ref string responseKey)
	{
		object[] array = Invoke("GetHistory", new object[6] { userName, fileType, matName, instanceCode, executionKey, responseKey });
		responseKey = Conversions.ToString(array[1]);
		return (MatFileDBEvent[])array[0];
	}

	public void GetHistoryAsync(string userName, FileType fileType, string matName, string instanceCode, string executionKey, string responseKey)
	{
		GetHistoryAsync(userName, fileType, matName, instanceCode, executionKey, responseKey, null);
	}

	public void GetHistoryAsync(string userName, FileType fileType, string matName, string instanceCode, string executionKey, string responseKey, object userState)
	{
		if (this.m_b == null)
		{
			this.m_b = j;
		}
		InvokeAsync("GetHistory", new object[6] { userName, fileType, matName, instanceCode, executionKey, responseKey }, this.m_b, RuntimeHelpers.GetObjectValue(userState));
	}

	private void j(object A_0)
	{
		if (n != null)
		{
			InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)A_0;
			n?.Invoke(this, new GetHistoryCompletedEventArgs(e.Results, e.Error, e.Cancelled, RuntimeHelpers.GetObjectValue(e.UserState)));
		}
	}

	[SoapDocumentMethod("http://www.ficorpserv.com/GetSummary", RequestNamespace = "http://www.ficorpserv.com/", ResponseNamespace = "http://www.ficorpserv.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public string GetSummary(string userName, string instanceCode, string executionKey, FileType fileType, ref DateTime lastIncrementalModUtc, ref DateTime lastNonIncrementalModUtc, ref FileData[] fileData)
	{
		object[] array = Invoke("GetSummary", new object[7] { userName, instanceCode, executionKey, fileType, lastIncrementalModUtc, lastNonIncrementalModUtc, fileData });
		lastIncrementalModUtc = Conversions.ToDate(array[1]);
		lastNonIncrementalModUtc = Conversions.ToDate(array[2]);
		fileData = (FileData[])array[3];
		return Conversions.ToString(array[0]);
	}

	public void GetSummaryAsync(string userName, string instanceCode, string executionKey, FileType fileType, DateTime lastIncrementalModUtc, DateTime lastNonIncrementalModUtc, FileData[] fileData)
	{
		GetSummaryAsync(userName, instanceCode, executionKey, fileType, lastIncrementalModUtc, lastNonIncrementalModUtc, fileData, null);
	}

	public void GetSummaryAsync(string userName, string instanceCode, string executionKey, FileType fileType, DateTime lastIncrementalModUtc, DateTime lastNonIncrementalModUtc, FileData[] fileData, object userState)
	{
		if (this.m_c == null)
		{
			this.m_c = i;
		}
		InvokeAsync("GetSummary", new object[7] { userName, instanceCode, executionKey, fileType, lastIncrementalModUtc, lastNonIncrementalModUtc, fileData }, this.m_c, RuntimeHelpers.GetObjectValue(userState));
	}

	private void i(object A_0)
	{
		if (o != null)
		{
			InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)A_0;
			o?.Invoke(this, new GetSummaryCompletedEventArgs(e.Results, e.Error, e.Cancelled, RuntimeHelpers.GetObjectValue(e.UserState)));
		}
	}

	[SoapDocumentMethod("http://www.ficorpserv.com/GetReleaseLevel", RequestNamespace = "http://www.ficorpserv.com/", ResponseNamespace = "http://www.ficorpserv.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public ReleaseLevel GetReleaseLevel(string userName, string instanceCode, string executionKey, FileType fileType, string matName, ref bool credentialsOK, ref string responseKey)
	{
		object[] array = Invoke("GetReleaseLevel", new object[7] { userName, instanceCode, executionKey, fileType, matName, credentialsOK, responseKey });
		credentialsOK = Conversions.ToBoolean(array[1]);
		responseKey = Conversions.ToString(array[2]);
		return (ReleaseLevel)Conversions.ToInteger(array[0]);
	}

	public void GetReleaseLevelAsync(string userName, string instanceCode, string executionKey, FileType fileType, string matName, bool credentialsOK, string responseKey)
	{
		GetReleaseLevelAsync(userName, instanceCode, executionKey, fileType, matName, credentialsOK, responseKey, null);
	}

	public void GetReleaseLevelAsync(string userName, string instanceCode, string executionKey, FileType fileType, string matName, bool credentialsOK, string responseKey, object userState)
	{
		if (this.m_d == null)
		{
			this.m_d = h;
		}
		InvokeAsync("GetReleaseLevel", new object[7] { userName, instanceCode, executionKey, fileType, matName, credentialsOK, responseKey }, this.m_d, RuntimeHelpers.GetObjectValue(userState));
	}

	private void h(object A_0)
	{
		if (p != null)
		{
			InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)A_0;
			p?.Invoke(this, new GetReleaseLevelCompletedEventArgs(e.Results, e.Error, e.Cancelled, RuntimeHelpers.GetObjectValue(e.UserState)));
		}
	}

	[SoapDocumentMethod("http://www.ficorpserv.com/GetUpdatedFilesInfo", RequestNamespace = "http://www.ficorpserv.com/", ResponseNamespace = "http://www.ficorpserv.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public FileModData[] GetUpdatedFilesInfo(string userName, DateTime refDateUtc, string instanceCode, string executionKey, FileType fileType)
	{
		return (FileModData[])Invoke("GetUpdatedFilesInfo", new object[5] { userName, refDateUtc, instanceCode, executionKey, fileType })[0];
	}

	public void GetUpdatedFilesInfoAsync(string userName, DateTime refDateUtc, string instanceCode, string executionKey, FileType fileType)
	{
		GetUpdatedFilesInfoAsync(userName, refDateUtc, instanceCode, executionKey, fileType, null);
	}

	public void GetUpdatedFilesInfoAsync(string userName, DateTime refDateUtc, string instanceCode, string executionKey, FileType fileType, object userState)
	{
		if (this.m_e == null)
		{
			this.m_e = g;
		}
		InvokeAsync("GetUpdatedFilesInfo", new object[5] { userName, refDateUtc, instanceCode, executionKey, fileType }, this.m_e, RuntimeHelpers.GetObjectValue(userState));
	}

	private void g(object A_0)
	{
		if (q != null)
		{
			InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)A_0;
			q?.Invoke(this, new GetUpdatedFilesInfoCompletedEventArgs(e.Results, e.Error, e.Cancelled, RuntimeHelpers.GetObjectValue(e.UserState)));
		}
	}

	[SoapDocumentMethod("http://www.ficorpserv.com/GetDeletedFiles", RequestNamespace = "http://www.ficorpserv.com/", ResponseNamespace = "http://www.ficorpserv.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public string[] GetDeletedFiles(string userName, DateTime refDateUtc, string instanceCode, string executionKey, FileType fileType)
	{
		return (string[])Invoke("GetDeletedFiles", new object[5] { userName, refDateUtc, instanceCode, executionKey, fileType })[0];
	}

	public void GetDeletedFilesAsync(string userName, DateTime refDateUtc, string instanceCode, string executionKey, FileType fileType)
	{
		GetDeletedFilesAsync(userName, refDateUtc, instanceCode, executionKey, fileType, null);
	}

	public void GetDeletedFilesAsync(string userName, DateTime refDateUtc, string instanceCode, string executionKey, FileType fileType, object userState)
	{
		if (this.m_f == null)
		{
			this.m_f = f;
		}
		InvokeAsync("GetDeletedFiles", new object[5] { userName, refDateUtc, instanceCode, executionKey, fileType }, this.m_f, RuntimeHelpers.GetObjectValue(userState));
	}

	private void f(object A_0)
	{
		if (r != null)
		{
			InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)A_0;
			r?.Invoke(this, new GetDeletedFilesCompletedEventArgs(e.Results, e.Error, e.Cancelled, RuntimeHelpers.GetObjectValue(e.UserState)));
		}
	}

	[SoapDocumentMethod("http://www.ficorpserv.com/ChangeReleaseLevel", RequestNamespace = "http://www.ficorpserv.com/", ResponseNamespace = "http://www.ficorpserv.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public string ChangeReleaseLevel(string userName, string instanceCode, string executionKey, FileType fileType, string matName, ReleaseLevel newLevel)
	{
		return Conversions.ToString(Invoke("ChangeReleaseLevel", new object[6] { userName, instanceCode, executionKey, fileType, matName, newLevel })[0]);
	}

	public void ChangeReleaseLevelAsync(string userName, string instanceCode, string executionKey, FileType fileType, string matName, ReleaseLevel newLevel)
	{
		ChangeReleaseLevelAsync(userName, instanceCode, executionKey, fileType, matName, newLevel, null);
	}

	public void ChangeReleaseLevelAsync(string userName, string instanceCode, string executionKey, FileType fileType, string matName, ReleaseLevel newLevel, object userState)
	{
		if (this.m_g == null)
		{
			this.m_g = e;
		}
		InvokeAsync("ChangeReleaseLevel", new object[6] { userName, instanceCode, executionKey, fileType, matName, newLevel }, this.m_g, RuntimeHelpers.GetObjectValue(userState));
	}

	private void e(object A_0)
	{
		if (s != null)
		{
			InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)A_0;
			s?.Invoke(this, new ChangeReleaseLevelCompletedEventArgs(e.Results, e.Error, e.Cancelled, RuntimeHelpers.GetObjectValue(e.UserState)));
		}
	}

	[SoapDocumentMethod("http://www.ficorpserv.com/DestroyFile", RequestNamespace = "http://www.ficorpserv.com/", ResponseNamespace = "http://www.ficorpserv.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public string DestroyFile(string userName, string instanceCode, string executionKey, FileType fileType, string matName)
	{
		return Conversions.ToString(Invoke("DestroyFile", new object[5] { userName, instanceCode, executionKey, fileType, matName })[0]);
	}

	public void DestroyFileAsync(string userName, string instanceCode, string executionKey, FileType fileType, string matName)
	{
		DestroyFileAsync(userName, instanceCode, executionKey, fileType, matName, null);
	}

	public void DestroyFileAsync(string userName, string instanceCode, string executionKey, FileType fileType, string matName, object userState)
	{
		if (this.m_h == null)
		{
			this.m_h = d;
		}
		InvokeAsync("DestroyFile", new object[5] { userName, instanceCode, executionKey, fileType, matName }, this.m_h, RuntimeHelpers.GetObjectValue(userState));
	}

	private void d(object A_0)
	{
		if (t != null)
		{
			InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)A_0;
			t?.Invoke(this, new DestroyFileCompletedEventArgs(e.Results, e.Error, e.Cancelled, RuntimeHelpers.GetObjectValue(e.UserState)));
		}
	}

	[SoapDocumentMethod("http://www.ficorpserv.com/UpdateMatFile", RequestNamespace = "http://www.ficorpserv.com/", ResponseNamespace = "http://www.ficorpserv.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public void UpdateMatFile(string userName, string instanceCode, string executionKey, FileType fileType, string fileNameWithExt, ReleaseLevel newLevel, [XmlElement(DataType = "base64Binary")] byte[] fileContents, ref DateTime officialDataModDateUtc, ref string responseKey)
	{
		object[] array = Invoke("UpdateMatFile", new object[9] { userName, instanceCode, executionKey, fileType, fileNameWithExt, newLevel, fileContents, officialDataModDateUtc, responseKey });
		officialDataModDateUtc = Conversions.ToDate(array[0]);
		responseKey = Conversions.ToString(array[1]);
	}

	public void UpdateMatFileAsync(string userName, string instanceCode, string executionKey, FileType fileType, string fileNameWithExt, ReleaseLevel newLevel, byte[] fileContents, DateTime officialDataModDateUtc, string responseKey)
	{
		UpdateMatFileAsync(userName, instanceCode, executionKey, fileType, fileNameWithExt, newLevel, fileContents, officialDataModDateUtc, responseKey, null);
	}

	public void UpdateMatFileAsync(string userName, string instanceCode, string executionKey, FileType fileType, string fileNameWithExt, ReleaseLevel newLevel, byte[] fileContents, DateTime officialDataModDateUtc, string responseKey, object userState)
	{
		if (this.m_i == null)
		{
			this.m_i = c;
		}
		InvokeAsync("UpdateMatFile", new object[9] { userName, instanceCode, executionKey, fileType, fileNameWithExt, newLevel, fileContents, officialDataModDateUtc, responseKey }, this.m_i, RuntimeHelpers.GetObjectValue(userState));
	}

	private void c(object A_0)
	{
		if (u != null)
		{
			InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)A_0;
			u?.Invoke(this, new UpdateMatFileCompletedEventArgs(e.Results, e.Error, e.Cancelled, RuntimeHelpers.GetObjectValue(e.UserState)));
		}
	}

	[SoapDocumentMethod("http://www.ficorpserv.com/GetNewestMatFile", RequestNamespace = "http://www.ficorpserv.com/", ResponseNamespace = "http://www.ficorpserv.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public string GetNewestMatFile(string userName, string instanceCode, string executionKey, FileType fileType, string matName, ref string fileNameWithExt, ref ReleaseLevel fileReleaseLevel, ref DateTime fileDataModDateUtc, [XmlElement(DataType = "base64Binary")] ref byte[] fileContents)
	{
		object[] array = Invoke("GetNewestMatFile", new object[9] { userName, instanceCode, executionKey, fileType, matName, fileNameWithExt, fileReleaseLevel, fileDataModDateUtc, fileContents });
		fileNameWithExt = Conversions.ToString(array[1]);
		fileReleaseLevel = (ReleaseLevel)Conversions.ToInteger(array[2]);
		fileDataModDateUtc = Conversions.ToDate(array[3]);
		fileContents = (byte[])array[4];
		return Conversions.ToString(array[0]);
	}

	public void GetNewestMatFileAsync(string userName, string instanceCode, string executionKey, FileType fileType, string matName, string fileNameWithExt, ReleaseLevel fileReleaseLevel, DateTime fileDataModDateUtc, byte[] fileContents)
	{
		GetNewestMatFileAsync(userName, instanceCode, executionKey, fileType, matName, fileNameWithExt, fileReleaseLevel, fileDataModDateUtc, fileContents, null);
	}

	public void GetNewestMatFileAsync(string userName, string instanceCode, string executionKey, FileType fileType, string matName, string fileNameWithExt, ReleaseLevel fileReleaseLevel, DateTime fileDataModDateUtc, byte[] fileContents, object userState)
	{
		if (this.m_j == null)
		{
			this.m_j = b;
		}
		InvokeAsync("GetNewestMatFile", new object[9] { userName, instanceCode, executionKey, fileType, matName, fileNameWithExt, fileReleaseLevel, fileDataModDateUtc, fileContents }, this.m_j, RuntimeHelpers.GetObjectValue(userState));
	}

	private void b(object A_0)
	{
		if (v != null)
		{
			InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)A_0;
			v?.Invoke(this, new GetNewestMatFileCompletedEventArgs(e.Results, e.Error, e.Cancelled, RuntimeHelpers.GetObjectValue(e.UserState)));
		}
	}

	[SoapDocumentMethod("http://www.ficorpserv.com/GetMatFile", RequestNamespace = "http://www.ficorpserv.com/", ResponseNamespace = "http://www.ficorpserv.com/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
	public string GetMatFile(string userName, string instanceCode, string executionKey, FileType fileType, string matName, bool getLatestFile, int oldFileEventID, ref string fileNameWithExt, ref ReleaseLevel fileReleaseLevel, ref DateTime fileDataModDateUtc, [XmlElement(DataType = "base64Binary")] ref byte[] fileContents)
	{
		object[] array = Invoke("GetMatFile", new object[11]
		{
			userName, instanceCode, executionKey, fileType, matName, getLatestFile, oldFileEventID, fileNameWithExt, fileReleaseLevel, fileDataModDateUtc,
			fileContents
		});
		fileNameWithExt = Conversions.ToString(array[1]);
		fileReleaseLevel = (ReleaseLevel)Conversions.ToInteger(array[2]);
		fileDataModDateUtc = Conversions.ToDate(array[3]);
		fileContents = (byte[])array[4];
		return Conversions.ToString(array[0]);
	}

	public void GetMatFileAsync(string userName, string instanceCode, string executionKey, FileType fileType, string matName, bool getLatestFile, int oldFileEventID, string fileNameWithExt, ReleaseLevel fileReleaseLevel, DateTime fileDataModDateUtc, byte[] fileContents)
	{
		GetMatFileAsync(userName, instanceCode, executionKey, fileType, matName, getLatestFile, oldFileEventID, fileNameWithExt, fileReleaseLevel, fileDataModDateUtc, fileContents, null);
	}

	public void GetMatFileAsync(string userName, string instanceCode, string executionKey, FileType fileType, string matName, bool getLatestFile, int oldFileEventID, string fileNameWithExt, ReleaseLevel fileReleaseLevel, DateTime fileDataModDateUtc, byte[] fileContents, object userState)
	{
		if (this.m_k == null)
		{
			this.m_k = a;
		}
		InvokeAsync("GetMatFile", new object[11]
		{
			userName, instanceCode, executionKey, fileType, matName, getLatestFile, oldFileEventID, fileNameWithExt, fileReleaseLevel, fileDataModDateUtc,
			fileContents
		}, this.m_k, RuntimeHelpers.GetObjectValue(userState));
	}

	private void a(object A_0)
	{
		if (w != null)
		{
			InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)A_0;
			w?.Invoke(this, new GetMatFileCompletedEventArgs(e.Results, e.Error, e.Cancelled, RuntimeHelpers.GetObjectValue(e.UserState)));
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
