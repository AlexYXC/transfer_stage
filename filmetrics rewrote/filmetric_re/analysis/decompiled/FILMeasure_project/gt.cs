using System.IO;
using System.Runtime.CompilerServices;
using FIUsbIntLib;

internal class gt
{
	private string a;

	private FMLegacyAllSystemTypes b;

	private byte c;

	private ew.a d;

	private bool e;

	private bool f;

	private bool g;

	private short h;

	private bool i;

	private bool j;

	private bool k;

	private bool l;

	private bool m;

	private bool n;

	private bool o;

	private bool p;

	private bool q;

	private bool r;

	private bool s;

	private bool t;

	private bool u;

	private bool v;

	private bool w;

	private bool x;

	private bool y;

	private bool z;

	private string[] aa;

	private const int ab = 8;

	private const int m_ac = 1;

	private const int m_ad = 21;

	private const int m_ae = 27;

	private const int m_af = 32;

	private const int m_ag = 33;

	private const int m_ah = 35;

	private const int m_ai = 37;

	private const int m_aj = 39;

	private const int m_ak = 41;

	private void ac()
	{
		a = h6.p9(b);
		FMLegacyAllSystemTypes fMLegacyAllSystemTypes = b;
		if (fMLegacyAllSystemTypes == FMLegacyAllSystemTypes.kTypeF10 && f)
		{
			a += "-AR";
			c = 1;
		}
	}

	[SpecialName]
	public g2.a ad()
	{
		switch (b)
		{
		case FMLegacyAllSystemTypes.kTypeF10:
			switch ((FMF10Subtypes)c)
			{
			case FMF10Subtypes.kFMF10SubtypeARc:
				return g2.a.i;
			case FMF10Subtypes.kFMF10SubtypeAR:
				return g2.a.i;
			case FMF10Subtypes.kFMF10SubtypePA:
				return g2.a.j;
			case FMF10Subtypes.kFMF10SubtypeVC:
			case FMF10Subtypes.kFMF10SubtypeRT:
				return g2.a.c;
			case FMF10Subtypes.kFMF10SubtypeHC:
				return g2.a.i;
			case FMF10Subtypes.kFMF10SubtypePV:
				return g2.a.d;
			case FMF10Subtypes.kFMF10SubtypeRTA:
				return g2.a.c;
			default:
				return g2.a.d;
			}
		case FMLegacyAllSystemTypes.kTypePARTS:
			return g2.a.c;
		case FMLegacyAllSystemTypes.kTypeF2:
			return g2.a.b;
		case FMLegacyAllSystemTypes.kTypeF50_300B:
			return (FMF50Subtypes)c switch
			{
				FMF50Subtypes.kFMF50SubtypeF54 => g2.a.f, 
				FMF50Subtypes.kFMF50SubtypeF57 => g2.a.m, 
				_ => g2.a.d, 
			};
		default:
			return g2.a.d;
		}
	}

	[SpecialName]
	public bool ae()
	{
		return e;
	}

	[SpecialName]
	public bool af()
	{
		return f;
	}

	[SpecialName]
	public bool ag()
	{
		return g;
	}

	[SpecialName]
	public short ah()
	{
		return h;
	}

	[SpecialName]
	public bool ai()
	{
		return i;
	}

	[SpecialName]
	public ew.a aj()
	{
		return d;
	}

	[SpecialName]
	public bool ak()
	{
		return q;
	}

	[SpecialName]
	public bool al()
	{
		return r;
	}

	[SpecialName]
	public string am()
	{
		return a;
	}

	[SpecialName]
	public byte an()
	{
		return c;
	}

	[SpecialName]
	public FMLegacyAllSystemTypes ao()
	{
		return b;
	}

	[SpecialName]
	public bool ap()
	{
		return j;
	}

	[SpecialName]
	public bool aq()
	{
		return k;
	}

	[SpecialName]
	public bool ar()
	{
		return l;
	}

	[SpecialName]
	public bool @as()
	{
		return m;
	}

	[SpecialName]
	public bool at()
	{
		return n;
	}

	[SpecialName]
	public bool au()
	{
		return o;
	}

	[SpecialName]
	public bool av()
	{
		return p;
	}

	[SpecialName]
	public bool aw()
	{
		return s;
	}

	[SpecialName]
	public bool ax()
	{
		return t;
	}

	[SpecialName]
	public bool ay()
	{
		return u;
	}

	[SpecialName]
	public bool az()
	{
		return v;
	}

	[SpecialName]
	public bool a0()
	{
		return w;
	}

	[SpecialName]
	public bool a1()
	{
		return x;
	}

	[SpecialName]
	public bool a2()
	{
		return y;
	}

	[SpecialName]
	public bool a3()
	{
		return b == FMLegacyAllSystemTypes.kTypeS3;
	}

	public gt(BinaryReader A_0)
	{
		ac(A_0);
	}

	public gt(fz A_0)
	{
	}

	public void ac(BinaryWriter A_0)
	{
		A_0.Write(8);
		A_0.Write(1);
		A_0.Write(checked(41 + a.Length));
		A_0.Write((int)b);
		A_0.Write((byte)d);
		A_0.Write(f);
		A_0.Write(i);
		A_0.Write(n);
		A_0.Write(j);
		A_0.Write(g);
		A_0.Write(h);
		A_0.Write(e);
		A_0.Write(s);
		A_0.Write(t);
		A_0.Write(c);
		A_0.Write(a);
		A_0.Write(k);
		A_0.Write(q);
		A_0.Write(r);
		A_0.Write(o);
		A_0.Write(p);
		A_0.Write(l);
		A_0.Write(m);
		A_0.Write(v);
		_ = null;
	}

	private void ac(BinaryReader A_0)
	{
		BinaryReader binaryReader = A_0;
		int num = binaryReader.ReadInt32();
		if (binaryReader.ReadInt32() > 1)
		{
			throw new au("Standalone Settings section is an incompatible version number");
		}
		int num2 = binaryReader.ReadInt32();
		b = (FMLegacyAllSystemTypes)binaryReader.ReadInt32();
		d = (ew.a)binaryReader.ReadByte();
		f = binaryReader.ReadBoolean();
		i = binaryReader.ReadBoolean();
		n = binaryReader.ReadBoolean();
		j = binaryReader.ReadBoolean();
		checked
		{
			int count;
			if (num == 1)
			{
				ac();
				count = num2 - 21;
			}
			else
			{
				g = binaryReader.ReadBoolean();
				h = binaryReader.ReadInt16();
				e = binaryReader.ReadBoolean();
				s = binaryReader.ReadBoolean();
				t = binaryReader.ReadBoolean();
				if (num == 2)
				{
					ac();
					count = num2 - 27;
				}
				else
				{
					c = binaryReader.ReadByte();
					a = binaryReader.ReadString();
					num2 -= a.Length;
					if (num == 3)
					{
						count = num2 - 32;
					}
					else
					{
						k = binaryReader.ReadBoolean();
						if (num == 4)
						{
							count = num2 - 33;
						}
						else
						{
							q = binaryReader.ReadBoolean();
							r = binaryReader.ReadBoolean();
							if (num == 5)
							{
								count = num2 - 35;
							}
							else
							{
								o = binaryReader.ReadBoolean();
								p = binaryReader.ReadBoolean();
								if (num == 6)
								{
									count = num2 - 37;
								}
								else
								{
									l = binaryReader.ReadBoolean();
									m = binaryReader.ReadBoolean();
									if (num == 7)
									{
										count = num2 - 39;
									}
									else
									{
										v = binaryReader.ReadBoolean();
										count = num2 - 41;
									}
								}
							}
						}
					}
				}
			}
			binaryReader.ReadBytes(count);
			binaryReader = null;
		}
	}

	[SpecialName]
	public static bool ad(gt A_0, gt A_1)
	{
		switch (ix.a(A_0, A_1))
		{
		case ix.a.a:
			return false;
		case ix.a.b:
			return true;
		default:
		{
			gt gt2 = A_0;
			if (gt2.ao() != A_1.ao())
			{
				return true;
			}
			if (gt2.an() != A_1.an())
			{
				return true;
			}
			if (gt2.aj() != A_1.aj())
			{
				return true;
			}
			if (gt2.af() != A_1.af())
			{
				return true;
			}
			if (gt2.ai() != A_1.ai())
			{
				return true;
			}
			if (gt2.ap() != A_1.ap())
			{
				return true;
			}
			if (gt2.at() != A_1.at())
			{
				return true;
			}
			if (gt2.ag() != A_1.ag())
			{
				return true;
			}
			if (gt2.ah() != A_1.ah())
			{
				return true;
			}
			if (gt2.ae() != A_1.ae())
			{
				return true;
			}
			if (gt2.aw() != A_1.aw())
			{
				return true;
			}
			if (gt2.ax() != A_1.ax())
			{
				return true;
			}
			if (gt2.aq() != A_1.aq())
			{
				return true;
			}
			if (gt2.ak() != A_1.ak())
			{
				return true;
			}
			if (gt2.al() != A_1.al())
			{
				return true;
			}
			if (gt2.ar() != A_1.ar())
			{
				return true;
			}
			if (gt2.@as() != A_1.@as())
			{
				return true;
			}
			if (gt2.au() != A_1.au())
			{
				return true;
			}
			if (gt2.av() != A_1.av())
			{
				return true;
			}
			if (gt2.az() != A_1.az())
			{
				return true;
			}
			gt2 = null;
			return false;
		}
		}
	}

	[SpecialName]
	public static bool ac(gt A_0, gt A_1)
	{
		return !ad(A_0, A_1);
	}

	[SpecialName]
	public bool a4()
	{
		return z;
	}

	public void ac(string A_0)
	{
		z = global::a2.a.c(A_0, ref aa);
	}

	public string ac(ref int A_0, ref int A_1)
	{
		return i7.c(aa, i7.e.l, ref A_0, ref A_1);
	}

	public string ac(int A_0, int A_1)
	{
		string a_ = string.Empty;
		if (aa != null && aa.GetUpperBound(0) >= A_0)
		{
			a_ = aa[A_0];
		}
		return i7.c(a_, A_1);
	}
}
