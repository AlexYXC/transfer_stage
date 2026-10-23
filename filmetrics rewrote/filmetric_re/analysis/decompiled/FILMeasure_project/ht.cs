using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;

internal abstract class ht
{
	protected static string d(string A_0, string A_1)
	{
		return new ResourceManager(A_0, Assembly.GetExecutingAssembly()).GetString(A_1, Thread.CurrentThread.CurrentUICulture);
	}

	protected static string c(string A_0, string A_1)
	{
		return new ResourceManager(A_0, Assembly.GetExecutingAssembly()).GetString(A_1, CultureInfo.InvariantCulture);
	}

	protected static int b(string A_0, string A_1)
	{
		int num = 0;
		int num2 = -1;
		checked
		{
			do
			{
				num2 = A_1.IndexOf("{", num2 + 1);
				if (num2 != -1)
				{
					num++;
				}
			}
			while (num2 != -1);
			return num;
		}
	}

	protected static int a(string A_0, string A_1)
	{
		string a_ = d(A_0, A_1);
		return b(A_0, a_);
	}
}
