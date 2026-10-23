using System.Collections.ObjectModel;

internal class b2
{
	private class a
	{
		public string a;

		public string b;

		public int c;

		public a(string A_0, string A_1, int A_2)
		{
			a = A_0;
			b = A_1;
			c = A_2;
		}
	}

	private Collection<a> m_a;

	private const string m_b = ";";

	private const string m_c = ".";

	public b2()
	{
		this.m_a = new Collection<a>();
	}

	public void a(string A_0, string A_1, int A_2)
	{
		this.m_a.Add(new a(A_0, A_1, A_2));
	}

	public void a()
	{
		this.m_a.Clear();
	}

	public string b()
	{
		string text = string.Empty;
		checked
		{
			int num = this.m_a.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (!string.IsNullOrEmpty(text))
				{
					text += "|";
				}
				a a10 = this.m_a[num2];
				text = text + a10.a + "|" + a10.b;
				a10 = null;
			}
			return text;
		}
	}

	public int a(int A_0)
	{
		return this.m_a[checked(A_0 - 1)].c;
	}

	public string b(int A_0)
	{
		checked
		{
			string text = this.m_a[A_0 - 1].b;
			return text.Substring(text.IndexOf(".", text.LastIndexOf(";") + 1));
		}
	}

	public string a(string A_0, int A_1)
	{
		string text = b(A_1);
		if (!A_0.ToLower().EndsWith(text))
		{
			A_0 += text;
		}
		return A_0;
	}

	public int c(int A_0)
	{
		checked
		{
			int num = this.m_a.Count - 1;
			for (int num2 = 0; num2 <= num; num2++)
			{
				if (this.m_a[num2].c == A_0)
				{
					return num2;
				}
			}
			return -1;
		}
	}

	public string[] c()
	{
		checked
		{
			int num = this.m_a.Count - 1;
			if (num < 0)
			{
				return null;
			}
			string[] array = new string[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				array[num3] = this.m_a[num3].a;
			}
			return array;
		}
	}
}
