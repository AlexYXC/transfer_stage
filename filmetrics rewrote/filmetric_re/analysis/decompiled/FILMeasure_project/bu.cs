using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using Microsoft.VisualBasic.CompilerServices;

internal class bu : IDisposable
{
	public class a
	{
		public enum a
		{
			a,
			b,
			c
		}

		public a a;

		public string b;

		public a(a A_0)
		{
			this.a = A_0;
		}

		public a(a A_0, string A_1)
		{
			this.a = A_0;
			b = A_1;
		}
	}

	private int m_a;

	private int m_b;

	private HttpWebRequest m_c;

	private AutoResetEvent d;

	[CompilerGenerated]
	private System.Timers.Timer e;

	private a f;

	private string g;

	private int h;

	private int i;

	private bool j;

	public bu()
	{
		d = null;
		h = 5000;
		i = 10240;
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer b()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = a;
		System.Timers.Timer timer = e;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		e = A_0;
		timer = e;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	public void a(string A_0, string A_1, string A_2, fz A_3)
	{
		try
		{
			a();
			string path = Path.ChangeExtension(A_1, ".fidlver");
			bool flag = File.Exists(path);
			if (flag)
			{
				string text = null;
				text = File.ReadAllText(path);
				if (string.IsNullOrEmpty(A_2) || Operators.CompareString(A_2, text, TextCompare: false) != 0)
				{
					File.Delete(A_1);
					flag = false;
				}
			}
			else
			{
				File.WriteAllText(path, A_2);
			}
			b().Start();
			a(A_0, A_1, flag);
			while (true)
			{
				d.WaitOne();
				switch (f.a)
				{
				case bu.a.a.c:
					b().Dispose();
					a((System.Timers.Timer)null);
					File.Delete(path);
					return;
				case bu.a.a.b:
				{
					string left = "Error attempting to download " + A_0 + ". Error is " + f.b;
					if (Operators.CompareString(left, g, TextCompare: false) != 0)
					{
						g = left;
						A_3.c(fz.b.a, g);
					}
					Thread.Sleep(5000);
					b().Start();
					a(A_0, A_1, A_2: true);
					break;
				}
				}
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	private void a()
	{
		this.m_a = 0;
		this.m_b = 0;
		if (d != null)
		{
			d.Dispose();
		}
		d = new AutoResetEvent(initialState: false);
		if (b() != null)
		{
			b().Dispose();
		}
		a(new System.Timers.Timer());
		b().Interval = h;
		b().AutoReset = false;
		f = new a(bu.a.a.a);
	}

	private void a(object A_0, ElapsedEventArgs A_1)
	{
		int num = checked(this.m_a - this.m_b);
		this.m_b = this.m_a;
		if (f.a != bu.a.a.b)
		{
			if (num > i)
			{
				b().Start();
			}
			else
			{
				this.m_c.Abort();
			}
		}
	}

	private void a(string A_0, string A_1, bool A_2)
	{
		Uri requestUri = new Uri(A_0);
		this.m_c = (HttpWebRequest)WebRequest.Create(requestUri);
		if (A_2)
		{
			FileInfo fileInfo = new FileInfo(A_1);
			if (fileInfo.Exists)
			{
				this.m_c.AddRange(checked((int)fileInfo.Length));
			}
		}
		bv state = new bv(A_1, this.m_c, A_2);
		this.m_c.BeginGetResponse(a, state);
	}

	private void a(IAsyncResult A_0)
	{
		bv bv2 = (bv)A_0.AsyncState;
		FileStream fileStream = null;
		byte[] array = new byte[8192];
		int num = 0;
		int num2 = 0;
		checked
		{
			try
			{
				f = new a(bu.a.a.a);
				HttpWebResponse obj = (HttpWebResponse)bv2.e().EndGetResponse(A_0);
				fileStream = ((!bv2.f()) ? new FileStream(bv2.d(), FileMode.Create, FileAccess.Write) : new FileStream(bv2.d(), FileMode.Append, FileAccess.Write));
				using (Stream stream = obj.GetResponseStream())
				{
					do
					{
						num = stream.Read(array, 0, array.Length);
						if (num > 0)
						{
							fileStream.Write(array, 0, num);
							this.m_a += num;
							num2 += num;
						}
					}
					while (num != 0);
				}
				a(new a(bu.a.a.c));
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				a(new a(bu.a.a.b, ex3.Message.ToString()));
				ProjectData.ClearProjectError();
			}
			finally
			{
				if (fileStream != null)
				{
					fileStream.Flush();
					fileStream.Close();
					fileStream = null;
				}
			}
		}
	}

	protected void a(a A_0)
	{
		f = A_0;
		d.Set();
	}

	protected virtual void a(bool A_0)
	{
		if (!j && A_0)
		{
			if (d != null)
			{
				d.Dispose();
			}
			if (b() != null)
			{
				b().Dispose();
			}
		}
		j = true;
	}

	public void c()
	{
		a(A_0: true);
		GC.SuppressFinalize(this);
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in c
		this.c();
	}
}
