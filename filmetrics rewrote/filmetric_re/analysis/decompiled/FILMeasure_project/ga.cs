using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class ga : fy
{
	protected new gr.d j;

	protected new bool k;

	private new const int r = 2;

	protected const int s = 2100;

	public ga()
	{
		this.j = gr.d.d;
	}

	public ga(double[] A_0, double[] A_1, gr.d A_2, bool A_3)
		: base(A_0, A_1)
	{
		this.j = A_2;
		this.k = A_3;
		base.ar = this.k;
	}

	[SpecialName]
	public bool bk()
	{
		return this.k;
	}

	[SpecialName]
	public gr.d bl()
	{
		return this.j;
	}

	public override void ag(ref string A_0, string A_1)
	{
		throw new Exception("Cannot read '" + A_0 + "' use the constructor to load data from file. " + Environment.StackTrace);
	}

	public new virtual void j(string A_0)
	{
		k(ref A_0, "", "");
	}

	public override void k(ref string A_0, string A_1, string A_2)
	{
		double[] a_ = new double[1];
		short[] a_2 = new short[1];
		checked
		{
			jb.a(A_0, base.j, c0(), null, (short)base.j.Length, (short)this.j, 0, 0, a_, a_2, "", "", 0, null, null, A_15: false);
		}
	}

	public override void l(ref BinaryReader A_0)
	{
		int num = 0;
		int num2 = 0;
		long offset = A_0.ReadInt64();
		num2 = A_0.ReadInt32();
		num = A_0.ReadInt32();
		if (num <= 2)
		{
			A_0.ReadBoolean();
			this.j = (gr.d)A_0.ReadInt32();
			A_0.ReadBoolean();
			if (num2 >= 2)
			{
				this.k = A_0.ReadBoolean();
			}
			else
			{
				this.k = true;
			}
			base.ar = this.k;
			A_0.BaseStream.Seek(offset, SeekOrigin.Begin);
			base.l(ref A_0);
			return;
		}
		throw new au("DataXYIndex maximum compatible block file version is " + 2 + " compatible version in file we are attempting to read is " + num);
	}

	public override void m(ref BinaryWriter A_0)
	{
		long position = A_0.BaseStream.Position;
		A_0.Write(position);
		A_0.Write(2);
		A_0.Write(1);
		A_0.Write(value: false);
		A_0.Write((int)this.j);
		A_0.Write(value: false);
		A_0.Write(this.k);
		long position2 = A_0.BaseStream.Position;
		A_0.BaseStream.Seek(position, SeekOrigin.Begin);
		A_0.Write(position2);
		A_0.BaseStream.Seek(position2, SeekOrigin.Begin);
		base.m(ref A_0);
	}
}
