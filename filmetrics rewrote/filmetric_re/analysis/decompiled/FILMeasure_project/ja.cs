using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

internal class ja
{
	public static string a(Exception A_0, int A_1)
	{
		string text = "Error attempting to send test message. Error is: " + A_0.Message + "\r\n\r\nThere may be a problem connecting to the Internet. If you wish to submit your request via the Internet the computer must have Internet access";
		if (A_1 != 0)
		{
			return text + " and must be permitted to communicate via port " + A_1 + ".";
		}
		return text + ".";
	}

	public static void a(string A_0, string A_1, string A_2, [Optional][DefaultParameterValue(null)] Collection<string> A_3, [Optional][DefaultParameterValue(null)] MailAddress A_4, [Optional][DefaultParameterValue("")] string A_5, [Optional][DefaultParameterValue("")] string A_6, [Optional][DefaultParameterValue("")] string A_7, [Optional][DefaultParameterValue(0)] ref int A_8)
	{
		MailMessage mailMessage = null;
		SmtpClient smtpClient = null;
		WebClient webClient = null;
		try
		{
			mailMessage = new MailMessage();
			webClient = new WebClient();
			webClient.Credentials = new NetworkCredential("anonymous@filmetricsftp.com", A_7);
			byte[] a_ = webClient.DownloadData("ftp://ftp.filmetricsftp.com/downloads/Private/Config/TechSupportMSData.fibms");
			e3.b b10 = new e3.b(A_0: false);
			b10.a(a_);
			A_8 = b10.h;
			MailMessage mailMessage2 = mailMessage;
			mailMessage2.To.Add(A_0);
			mailMessage2.From = new MailAddress(b10.j, b10.k);
			if (A_4 == null)
			{
				A_4 = new MailAddress(b10.n, b10.o);
			}
			mailMessage2.Subject = A_1;
			mailMessage2.Body = A_2;
			mailMessage2.IsBodyHtml = false;
			mailMessage2.ReplyToList.Add(A_4);
			mailMessage2.Sender = mailMessage2.From;
			if (Operators.CompareString(A_5, "", TextCompare: false) != 0)
			{
				mailMessage2.CC.Add(A_5);
			}
			if (Operators.CompareString(A_6, "", TextCompare: false) != 0)
			{
				mailMessage2.Bcc.Add(A_6);
			}
			if (A_3 != null)
			{
				foreach (string item in A_3)
				{
					if (c.e().FileSystem.FileExists(item))
					{
						mailMessage2.Attachments.Add(new Attachment(item));
					}
				}
			}
			mailMessage2 = null;
			string host = b10.i;
			smtpClient = new SmtpClient(host);
			smtpClient = new SmtpClient(host, b10.h);
			smtpClient.Credentials = new NetworkCredential(b10.l, b10.m);
			smtpClient.Send(mailMessage);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			throw ex3;
		}
		finally
		{
			webClient?.Dispose();
			mailMessage?.Dispose();
			smtpClient?.Dispose();
		}
	}

	public static void a(string A_0, string A_1)
	{
		MailMessage mailMessage = null;
		SmtpClient smtpClient = null;
		WebClient webClient = null;
		try
		{
			mailMessage = new MailMessage();
			webClient = new WebClient();
			byte[] a_ = webClient.DownloadData("https://files.filmetrics.com/FI_SW/FilmMSData.fibms");
			e3.b b10 = new e3.b(A_0: true);
			b10.a(a_);
			mailMessage.To.Add("ProductionTesting@filmetrics.com");
			mailMessage.From = new MailAddress(b10.j, b10.k);
			mailMessage.Subject = A_0;
			mailMessage.Body = A_1;
			mailMessage.IsBodyHtml = false;
			mailMessage.ReplyToList.Add(new MailAddress(b10.n, b10.o));
			mailMessage.Sender = mailMessage.From;
			string host = b10.i;
			smtpClient = new SmtpClient(host, b10.h);
			smtpClient.Credentials = new NetworkCredential(b10.l, b10.m);
			smtpClient.Send(mailMessage);
		}
		finally
		{
			webClient?.Dispose();
			mailMessage?.Dispose();
			smtpClient?.Dispose();
		}
	}
}
