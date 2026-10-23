internal class ix
{
	public enum a
	{
		a,
		b,
		c
	}

	public class b
	{
		public bool a;
	}

	public class c
	{
		public float a;

		public c(float A_0)
		{
			a = A_0;
		}
	}

	public class d
	{
		public double a;

		public d(double A_0)
		{
			a = A_0;
		}
	}

	public class e
	{
		public string a;

		public e()
		{
		}

		public e(string A_0)
		{
			a = A_0;
		}
	}

	public static a a(object A_0, object A_1)
	{
		if (A_0 == null && A_1 == null)
		{
			return ix.a.a;
		}
		if (A_0 == null && A_1 != null)
		{
			return ix.a.b;
		}
		if (A_0 != null && A_1 == null)
		{
			return ix.a.b;
		}
		return ix.a.c;
	}

	public static bool a<a>(a[] A_0, a[] A_1)
	{
		checked
		{
			switch (ix.a((object)A_0, (object)A_1))
			{
			case ix.a.a:
				return false;
			case ix.a.b:
				return true;
			default:
			{
				if (A_0.Length != A_1.Length)
				{
					return true;
				}
				int num = A_0.Length - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					ref readonly a reference = ref A_0[num2];
					object obj = A_1[num2];
					if (!reference.Equals(obj))
					{
						return true;
					}
				}
				return false;
			}
			}
		}
	}
}
