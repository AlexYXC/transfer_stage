using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

internal class fz
{
	public enum a
	{
		a,
		b,
		c
	}

	public enum b
	{
		a = 3,
		b
	}

	private enum c
	{
		a,
		b,
		c,
		d,
		e
	}

	public delegate void d(int A_0, string A_1, string A_2, string A_3);

	private long m_a;

	private long m_b;

	private long m_c;

	private long m_d;

	private long e;

	private string f;

	private string g;

	public const string h = "(>#'<)";

	[CompilerGenerated]
	private d i;

	private object j;

	public fz()
	{
		j = RuntimeHelpers.GetObjectValue(new object());
	}

	public void c(string A_0)
	{
		f = A_0;
		try
		{
			global::c.e().FileSystem.CreateDirectory(A_0);
			DateTime now = DateTime.Now;
			string a_ = b3.a(now.Year) + "-" + b3.a(now.Month, "00");
			c(a_, ref this.m_a, ref this.m_b, ref this.m_c, ref this.m_d, ref e);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	public string d()
	{
		return g;
	}

	public void c(b A_0, string A_1, Exception A_2)
	{
		Thread currentThread = Thread.CurrentThread;
		CultureInfo currentCulture = currentThread.CurrentCulture;
		CultureInfo currentUICulture = currentThread.CurrentUICulture;
		currentThread.CurrentCulture = CultureInfo.InvariantCulture;
		currentThread.CurrentUICulture = CultureInfo.InvariantCulture;
		c((c)A_0, A_1, A_1, b3.a(A_2));
		currentThread.CurrentCulture = currentCulture;
		currentThread.CurrentUICulture = currentUICulture;
		_ = null;
	}

	public void c(b A_0, string A_1, string A_2)
	{
		c((c)A_0, A_1, A_1, A_2);
	}

	public void c(b A_0, string A_1)
	{
		c((c)A_0, A_1, A_1);
	}

	public void c(a A_0, string A_1, Exception A_2, params object[] A_3)
	{
		string a_ = string.Format(hu.a(ref A_1), A_3);
		string a_2 = string.Format(hu.c(A_1), A_3);
		CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
		Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
		c((c)A_0, a_, a_2, A_2.ToString());
		Thread.CurrentThread.CurrentCulture = currentCulture;
	}

	public void c(a A_0, string A_1, params object[] A_2)
	{
		string a_ = string.Format(hu.a(ref A_1), A_2);
		string a_2 = string.Format(hu.c(A_1), A_2);
		c((c)A_0, a_, a_2);
	}

	public void d(a A_0, string A_1, params object[] A_2)
	{
		string a_ = string.Format(hu.a(ref A_1), A_2);
		CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
		Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
		string a_2 = string.Format(hu.c(A_1), A_2);
		Thread.CurrentThread.CurrentCulture = currentCulture;
		c((c)A_0, a_, a_2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void c(d A_0)
	{
		d d10 = i;
		d d11;
		do
		{
			d11 = d10;
			d value = (d)Delegate.Combine(d11, A_0);
			d10 = Interlocked.CompareExchange(ref i, value, d11);
		}
		while ((object)d10 != d11);
	}

	[SpecialName]
	[CompilerGenerated]
	public void d(d A_0)
	{
		d d10 = i;
		d d11;
		do
		{
			d11 = d10;
			d value = (d)Delegate.Remove(d11, A_0);
			d10 = Interlocked.CompareExchange(ref i, value, d11);
		}
		while ((object)d10 != d11);
	}

	private void c(c A_0, string A_1, string A_2, string A_3 = null)
	{
		StreamWriter streamWriter = null;
		if (!Monitor.TryEnter(RuntimeHelpers.GetObjectValue(j), 300))
		{
			return;
		}
		DateTime now = default(DateTime);
		try
		{
			c();
			now = DateTime.Now;
			string text = (g = f + b3.a(now.Year) + "-" + b3.a(now.Month, "00") + ".log");
			bool A_4 = default(bool);
			c(text, ref A_4);
			if (!A_4)
			{
				this.m_a = 0L;
				this.m_b = 0L;
				this.m_c = 0L;
				this.m_d = 0L;
				e = 0L;
			}
			checked
			{
				long value = default(long);
				switch (A_0)
				{
				case fz.c.a:
					this.m_a++;
					value = this.m_a;
					break;
				case fz.c.b:
					this.m_b++;
					value = this.m_b;
					break;
				case fz.c.c:
					this.m_c++;
					value = this.m_c;
					break;
				case fz.c.d:
					this.m_d++;
					value = this.m_d;
					break;
				case fz.c.e:
					e++;
					value = e;
					break;
				}
				streamWriter = new StreamWriter(File.OpenWrite(text));
				streamWriter.Write(b3.a(this.m_a, "000000000000"));
				streamWriter.Write(",");
				streamWriter.Write(b3.a(this.m_b, "000000000000"));
				streamWriter.Write(",");
				streamWriter.Write(b3.a(this.m_c, "000000000000"));
				streamWriter.Write(",");
				streamWriter.Write(b3.a(this.m_d, "000000000000"));
				streamWriter.Write(",");
				streamWriter.Write(b3.a(e, "000000000000"));
				streamWriter.Write(",");
				streamWriter.WriteLine();
				streamWriter.Close();
				streamWriter = File.AppendText(text);
				streamWriter.Write(value);
				streamWriter.Write(",");
			}
			streamWriter.Write((int)A_0);
			streamWriter.Write(",");
			streamWriter.Write(b3.a(now));
			streamWriter.Write(",");
			streamWriter.Write(now.ToUniversalTime());
			streamWriter.Write(",");
			streamWriter.Write(A_1);
			streamWriter.Write(",");
			if (Operators.CompareString(A_2, A_1, TextCompare: false) != 0)
			{
				streamWriter.Write(A_2);
			}
			else
			{
				streamWriter.Write("");
			}
			streamWriter.Write(",");
			if (A_3 == null)
			{
				streamWriter.Write("");
			}
			else
			{
				streamWriter.Write(A_3);
			}
			streamWriter.Write("(>#'<)");
			streamWriter.WriteLine();
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			ex3.ToString();
			ProjectData.ClearProjectError();
		}
		finally
		{
			streamWriter?.Close();
			Monitor.Exit(RuntimeHelpers.GetObjectValue(j));
		}
		i?.Invoke((int)A_0, now.ToString(), A_1, A_3);
	}

	public void c(ref long A_0, ref long A_1, ref long A_2, ref long A_3, ref long A_4)
	{
		A_0 = this.m_a;
		A_1 = this.m_b;
		A_2 = this.m_c;
		A_3 = this.m_d;
		A_4 = e;
	}

	public void c(string A_0, ref long A_1, ref long A_2, ref long A_3, ref long A_4, ref long A_5)
	{
		checked
		{
			try
			{
				string path = f + A_0 + ".log";
				if (File.Exists(path))
				{
					StreamReader streamReader = new StreamReader(File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read));
					string text = streamReader.ReadLine();
					int num = text.IndexOf(",", 0);
					A_1 = Conversions.ToLong(text.Substring(0, num));
					int num2 = text.IndexOf(",", num + 1);
					A_2 = Conversions.ToLong(text.Substring(num + 1, num2 - num - 1));
					num = text.IndexOf(",", num2 + 1);
					A_3 = Conversions.ToLong(text.Substring(num2 + 1, num - num2 - 1));
					num2 = text.IndexOf(",", num + 1);
					A_4 = Conversions.ToLong(text.Substring(num + 1, num2 - num - 1));
					A_5 = Conversions.ToLong(text.Substring(length: text.IndexOf(",", num2 + 1) - num2 - 1, startIndex: num2 + 1));
					streamReader.Close();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void c()
	{
		if (!(i3.a(f, A_1: false) > 10.0))
		{
			return;
		}
		string[] array = i3.b(f);
		if (array.Length > 0)
		{
			int num = 0;
			do
			{
				File.Delete(array[num]);
				num = checked(num + 1);
			}
			while (i3.a(f, A_1: false) > 10.0 && num <= array.GetUpperBound(0));
		}
	}

	private void c(string A_0, ref bool A_1)
	{
		if (!File.Exists(A_0))
		{
			A_1 = false;
		}
		else if (i3.a(new FileInfo(A_0).Length) >= 3.0)
		{
			int num = 1;
			string extension = Path.GetExtension(A_0);
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(A_0);
			string directoryName = Path.GetDirectoryName(A_0);
			while (File.Exists(directoryName + "\\" + fileNameWithoutExtension + "-" + b3.a(num) + extension))
			{
				num = checked(num + 1);
			}
			File.Move(A_0, Path.Combine(Path.GetDirectoryName(A_0), fileNameWithoutExtension + "-" + b3.a(num) + extension));
			A_1 = false;
		}
		else
		{
			A_1 = true;
		}
	}
}
