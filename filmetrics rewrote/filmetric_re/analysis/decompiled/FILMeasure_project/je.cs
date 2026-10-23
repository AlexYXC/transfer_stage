using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

internal class je
{
	private class a
	{
		private string m_a;

		private int b;

		private DateTime c;

		public a(string A_0, int A_1)
		{
			m_a = A_0;
			b = A_1;
			c = DateTime.Now;
		}

		[SpecialName]
		public string d()
		{
			return m_a;
		}

		[SpecialName]
		public int e()
		{
			return b;
		}

		[SpecialName]
		public DateTime f()
		{
			return c;
		}
	}

	private Collection<a> m_a;

	private const int m_b = 3600;

	public je()
	{
		this.m_a = new Collection<a>();
	}

	public void a(string A_0, int A_1)
	{
		this.m_a.Add(new a(A_0, A_1));
	}

	public bool b(string A_0, int A_1)
	{
		bool result = false;
		DateTime now = DateTime.Now;
		foreach (a item in this.m_a)
		{
			if (Operators.CompareString(item.d(), A_0, TextCompare: false) == 0 && item.e() == A_1 && now.Subtract(item.f()).TotalSeconds < 3600.0)
			{
				result = true;
				break;
			}
			a current = null;
		}
		checked
		{
			for (int num = this.m_a.Count - 1; num >= 0; num += -1)
			{
				if (now.Subtract(this.m_a[num].f()).TotalSeconds > 3600.0)
				{
					this.m_a.RemoveAt(num);
				}
			}
			return result;
		}
	}
}
