internal class g3
{
	private long m_a;

	public g3()
	{
		this.m_a = 1L;
	}

	public long a()
	{
		long result = this.m_a;
		checked
		{
			if (this.m_a < long.MaxValue)
			{
				this.m_a++;
				return result;
			}
			this.m_a = 1L;
			return result;
		}
	}
}
