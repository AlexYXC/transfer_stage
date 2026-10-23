using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Filmetrics.FIMatFileDBService;
using Filmetrics.FIMatFileSecurityService;
using Filmetrics.FIUserRegistrationService;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
internal sealed class c
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class a
	{
		[ThreadStatic]
		private static Hashtable m_a;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ci b;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cj c;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ck d;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z e;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public a7 f;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cl g;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cm h;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public a8 i;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ba j;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public bb k;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cz l;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cn m;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public bc n;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public co o;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public aa p;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cp q;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public bd r;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cr s;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cs t;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public be u;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ct v;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cu w;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public bf x;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cv y;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public e7 z;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cw aa;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public e8 ab;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public b4 ac;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public fa ad;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cx ae;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cy af;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public fc ag;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c0 ah;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public bh ai;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public bi aj;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ab ak;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c1 al;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c2 am;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c3 an;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c4 ao;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c5 ap;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c7 aq;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c8 ar;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public fd @as;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ff at;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public db au;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public dc av;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public dd aw;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public bm ax;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public de ay;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public df az;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public dg a0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public dh a1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public di a2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public dj a3;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public dk a4;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public dl a5;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public dm a6;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public dn a7;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public @do a8;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public dp a9;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public dq ba;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public bn bb;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public fg bc;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ez bd;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public dr be;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public bo bf;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public fh bg;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public fi bh;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ds bi;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public dt bj;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public bp bk;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public du bl;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public dv bm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public dw bn;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public dx bo;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public fj bp;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public dy bq;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public bq br;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public br bs;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public bs bt;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d2 bu;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public bt bv;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public gg bw;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public e2 bx;

		[DebuggerHidden]
		private static a ea<a>(a A_0) where a : Form, new()
		{
			if (A_0 == null || A_0.IsDisposed)
			{
				if (global::c.a.m_a != null)
				{
					if (global::c.a.m_a.ContainsKey(typeof(a)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
					}
				}
				else
				{
					global::c.a.m_a = new Hashtable();
				}
				global::c.a.m_a.Add(typeof(a), null);
				try
				{
					return new a();
				}
				catch (TargetInvocationException ex2) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError(ex2);
					return ex2.InnerException != null;
				}).Invoke())
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex2.InnerException.Message), ex2.InnerException);
				}
				finally
				{
					global::c.a.m_a.Remove(typeof(a));
				}
			}
			return A_0;
		}

		[DebuggerHidden]
		private void ea<a>(ref a A_0) where a : Form
		{
			A_0.Dispose();
			A_0 = null;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public a()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type ea()
		{
			return typeof(a);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[SpecialName]
		public ci eb()
		{
			b = ea<ci>(b);
			return b;
		}

		[SpecialName]
		public cj ec()
		{
			c = ea<cj>(c);
			return c;
		}

		[SpecialName]
		public ck ed()
		{
			d = ea<ck>(d);
			return d;
		}

		[SpecialName]
		public z ee()
		{
			e = ea<z>(e);
			return e;
		}

		[SpecialName]
		public a7 ef()
		{
			f = ea<a7>(f);
			return f;
		}

		[SpecialName]
		public cl eg()
		{
			g = ea<cl>(g);
			return g;
		}

		[SpecialName]
		public cm eh()
		{
			h = ea<cm>(h);
			return h;
		}

		[SpecialName]
		public a8 ei()
		{
			i = ea<a8>(i);
			return i;
		}

		[SpecialName]
		public ba ej()
		{
			j = ea<ba>(j);
			return j;
		}

		[SpecialName]
		public bb ek()
		{
			k = ea<bb>(k);
			return k;
		}

		[SpecialName]
		public cz el()
		{
			l = ea<cz>(l);
			return l;
		}

		[SpecialName]
		public cn em()
		{
			m = ea<cn>(m);
			return m;
		}

		[SpecialName]
		public bc en()
		{
			n = ea<bc>(n);
			return n;
		}

		[SpecialName]
		public co eo()
		{
			o = ea<co>(o);
			return o;
		}

		[SpecialName]
		public aa ep()
		{
			p = ea<aa>(p);
			return p;
		}

		[SpecialName]
		public cp eq()
		{
			q = ea<cp>(q);
			return q;
		}

		[SpecialName]
		public bd er()
		{
			r = ea<bd>(r);
			return r;
		}

		[SpecialName]
		public cr es()
		{
			s = ea<cr>(s);
			return s;
		}

		[SpecialName]
		public cs et()
		{
			t = ea<cs>(t);
			return t;
		}

		[SpecialName]
		public be eu()
		{
			u = ea<be>(u);
			return u;
		}

		[SpecialName]
		public ct ev()
		{
			v = ea<ct>(v);
			return v;
		}

		[SpecialName]
		public cu ew()
		{
			w = ea<cu>(w);
			return w;
		}

		[SpecialName]
		public bf ex()
		{
			x = ea<bf>(x);
			return x;
		}

		[SpecialName]
		public cv ey()
		{
			y = ea<cv>(y);
			return y;
		}

		[SpecialName]
		public e7 ez()
		{
			z = ea<e7>(z);
			return z;
		}

		[SpecialName]
		public cw e0()
		{
			aa = ea<cw>(aa);
			return aa;
		}

		[SpecialName]
		public e8 e1()
		{
			ab = ea<e8>(ab);
			return ab;
		}

		[SpecialName]
		public b4 e2()
		{
			ac = ea<b4>(ac);
			return ac;
		}

		[SpecialName]
		public fa e3()
		{
			ad = ea<fa>(ad);
			return ad;
		}

		[SpecialName]
		public cx e4()
		{
			ae = ea<cx>(ae);
			return ae;
		}

		[SpecialName]
		public cy e5()
		{
			af = ea<cy>(af);
			return af;
		}

		[SpecialName]
		public fc e6()
		{
			ag = ea<fc>(ag);
			return ag;
		}

		[SpecialName]
		public c0 e7()
		{
			ah = ea<c0>(ah);
			return ah;
		}

		[SpecialName]
		public bh e8()
		{
			ai = ea<bh>(ai);
			return ai;
		}

		[SpecialName]
		public bi e9()
		{
			aj = ea<bi>(aj);
			return aj;
		}

		[SpecialName]
		public ab fa()
		{
			ak = ea<ab>(ak);
			return ak;
		}

		[SpecialName]
		public c1 fb()
		{
			al = ea<c1>(al);
			return al;
		}

		[SpecialName]
		public c2 fc()
		{
			am = ea<c2>(am);
			return am;
		}

		[SpecialName]
		public c3 fd()
		{
			an = ea<c3>(an);
			return an;
		}

		[SpecialName]
		public c4 fe()
		{
			ao = ea<c4>(ao);
			return ao;
		}

		[SpecialName]
		public c5 ff()
		{
			ap = ea<c5>(ap);
			return ap;
		}

		[SpecialName]
		public c7 fg()
		{
			aq = ea<c7>(aq);
			return aq;
		}

		[SpecialName]
		public c8 fh()
		{
			ar = ea<c8>(ar);
			return ar;
		}

		[SpecialName]
		public fd fi()
		{
			@as = ea<fd>(@as);
			return @as;
		}

		[SpecialName]
		public ff fj()
		{
			at = ea<ff>(at);
			return at;
		}

		[SpecialName]
		public db fk()
		{
			au = ea<db>(au);
			return au;
		}

		[SpecialName]
		public dc fl()
		{
			av = ea<dc>(av);
			return av;
		}

		[SpecialName]
		public dd fm()
		{
			aw = ea<dd>(aw);
			return aw;
		}

		[SpecialName]
		public bm fn()
		{
			ax = ea<bm>(ax);
			return ax;
		}

		[SpecialName]
		public de fo()
		{
			ay = ea<de>(ay);
			return ay;
		}

		[SpecialName]
		public df fp()
		{
			az = ea<df>(az);
			return az;
		}

		[SpecialName]
		public dg fq()
		{
			a0 = ea<dg>(a0);
			return a0;
		}

		[SpecialName]
		public dh fr()
		{
			a1 = ea<dh>(a1);
			return a1;
		}

		[SpecialName]
		public di fs()
		{
			a2 = ea<di>(a2);
			return a2;
		}

		[SpecialName]
		public dj ft()
		{
			a3 = ea<dj>(a3);
			return a3;
		}

		[SpecialName]
		public dk fu()
		{
			a4 = ea<dk>(a4);
			return a4;
		}

		[SpecialName]
		public dl fv()
		{
			a5 = ea<dl>(a5);
			return a5;
		}

		[SpecialName]
		public dm fw()
		{
			a6 = ea<dm>(a6);
			return a6;
		}

		[SpecialName]
		public dn fx()
		{
			a7 = ea<dn>(a7);
			return a7;
		}

		[SpecialName]
		public @do fy()
		{
			a8 = ea<@do>(a8);
			return a8;
		}

		[SpecialName]
		public dp fz()
		{
			a9 = ea<dp>(a9);
			return a9;
		}

		[SpecialName]
		public dq f0()
		{
			ba = ea<dq>(ba);
			return ba;
		}

		[SpecialName]
		public bn f1()
		{
			bb = ea<bn>(bb);
			return bb;
		}

		[SpecialName]
		public fg f2()
		{
			bc = ea<fg>(bc);
			return bc;
		}

		[SpecialName]
		public ez f3()
		{
			bd = ea<ez>(bd);
			return bd;
		}

		[SpecialName]
		public dr f4()
		{
			be = ea<dr>(be);
			return be;
		}

		[SpecialName]
		public bo f5()
		{
			bf = ea<bo>(bf);
			return bf;
		}

		[SpecialName]
		public fh f6()
		{
			bg = ea<fh>(bg);
			return bg;
		}

		[SpecialName]
		public fi f7()
		{
			bh = ea<fi>(bh);
			return bh;
		}

		[SpecialName]
		public ds f8()
		{
			bi = ea<ds>(bi);
			return bi;
		}

		[SpecialName]
		public dt f9()
		{
			bj = ea<dt>(bj);
			return bj;
		}

		[SpecialName]
		public bp ga()
		{
			bk = ea<bp>(bk);
			return bk;
		}

		[SpecialName]
		public du gb()
		{
			bl = ea<du>(bl);
			return bl;
		}

		[SpecialName]
		public dv gc()
		{
			bm = ea<dv>(bm);
			return bm;
		}

		[SpecialName]
		public dw gd()
		{
			bn = ea<dw>(bn);
			return bn;
		}

		[SpecialName]
		public dx ge()
		{
			bo = ea<dx>(bo);
			return bo;
		}

		[SpecialName]
		public fj gf()
		{
			bp = ea<fj>(bp);
			return bp;
		}

		[SpecialName]
		public dy gg()
		{
			bq = ea<dy>(bq);
			return bq;
		}

		[SpecialName]
		public bq gh()
		{
			br = ea<bq>(br);
			return br;
		}

		[SpecialName]
		public br gi()
		{
			bs = ea<br>(bs);
			return bs;
		}

		[SpecialName]
		public bs gj()
		{
			bt = ea<bs>(bt);
			return bt;
		}

		[SpecialName]
		public d2 gk()
		{
			bu = ea<d2>(bu);
			return bu;
		}

		[SpecialName]
		public bt gl()
		{
			bv = ea<bt>(bv);
			return bv;
		}

		[SpecialName]
		public gg gm()
		{
			bw = ea<gg>(bw);
			return bw;
		}

		[SpecialName]
		public e2 gn()
		{
			bx = ea<e2>(bx);
			return bx;
		}

		[SpecialName]
		public void ea(ci A_0)
		{
			if (A_0 != b)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref b);
			}
		}

		[SpecialName]
		public void ea(cj A_0)
		{
			if (A_0 != c)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref c);
			}
		}

		[SpecialName]
		public void ea(ck A_0)
		{
			if (A_0 != d)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref d);
			}
		}

		[SpecialName]
		public void ea(z A_0)
		{
			if (A_0 != e)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref e);
			}
		}

		[SpecialName]
		public void ea(a7 A_0)
		{
			if (A_0 != f)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref f);
			}
		}

		[SpecialName]
		public void ea(cl A_0)
		{
			if (A_0 != g)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref g);
			}
		}

		[SpecialName]
		public void ea(cm A_0)
		{
			if (A_0 != h)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref h);
			}
		}

		[SpecialName]
		public void ea(a8 A_0)
		{
			if (A_0 != i)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref i);
			}
		}

		[SpecialName]
		public void ea(ba A_0)
		{
			if (A_0 != j)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref j);
			}
		}

		[SpecialName]
		public void ea(bb A_0)
		{
			if (A_0 != k)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref k);
			}
		}

		[SpecialName]
		public void ea(cz A_0)
		{
			if (A_0 != l)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref l);
			}
		}

		[SpecialName]
		public void ea(cn A_0)
		{
			if (A_0 != m)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref m);
			}
		}

		[SpecialName]
		public void ea(bc A_0)
		{
			if (A_0 != n)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref n);
			}
		}

		[SpecialName]
		public void ea(co A_0)
		{
			if (A_0 != o)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref o);
			}
		}

		[SpecialName]
		public void ea(aa A_0)
		{
			if (A_0 != p)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref p);
			}
		}

		[SpecialName]
		public void ea(cp A_0)
		{
			if (A_0 != q)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref q);
			}
		}

		[SpecialName]
		public void ea(bd A_0)
		{
			if (A_0 != r)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref r);
			}
		}

		[SpecialName]
		public void ea(cr A_0)
		{
			if (A_0 != s)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref s);
			}
		}

		[SpecialName]
		public void ea(cs A_0)
		{
			if (A_0 != t)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref t);
			}
		}

		[SpecialName]
		public void ea(be A_0)
		{
			if (A_0 != u)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref u);
			}
		}

		[SpecialName]
		public void ea(ct A_0)
		{
			if (A_0 != v)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref v);
			}
		}

		[SpecialName]
		public void ea(cu A_0)
		{
			if (A_0 != w)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref w);
			}
		}

		[SpecialName]
		public void ea(bf A_0)
		{
			if (A_0 != x)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref x);
			}
		}

		[SpecialName]
		public void ea(cv A_0)
		{
			if (A_0 != y)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref y);
			}
		}

		[SpecialName]
		public void ea(e7 A_0)
		{
			if (A_0 != z)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref z);
			}
		}

		[SpecialName]
		public void ea(cw A_0)
		{
			if (A_0 != aa)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref aa);
			}
		}

		[SpecialName]
		public void ea(e8 A_0)
		{
			if (A_0 != ab)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref ab);
			}
		}

		[SpecialName]
		public void ea(b4 A_0)
		{
			if (A_0 != ac)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref ac);
			}
		}

		[SpecialName]
		public void ea(fa A_0)
		{
			if (A_0 != ad)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref ad);
			}
		}

		[SpecialName]
		public void ea(cx A_0)
		{
			if (A_0 != ae)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref ae);
			}
		}

		[SpecialName]
		public void ea(cy A_0)
		{
			if (A_0 != af)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref af);
			}
		}

		[SpecialName]
		public void ea(fc A_0)
		{
			if (A_0 != ag)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref ag);
			}
		}

		[SpecialName]
		public void ea(c0 A_0)
		{
			if (A_0 != ah)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref ah);
			}
		}

		[SpecialName]
		public void ea(bh A_0)
		{
			if (A_0 != ai)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref ai);
			}
		}

		[SpecialName]
		public void ea(bi A_0)
		{
			if (A_0 != aj)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref aj);
			}
		}

		[SpecialName]
		public void ea(ab A_0)
		{
			if (A_0 != ak)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref ak);
			}
		}

		[SpecialName]
		public void ea(c1 A_0)
		{
			if (A_0 != al)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref al);
			}
		}

		[SpecialName]
		public void ea(c2 A_0)
		{
			if (A_0 != am)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref am);
			}
		}

		[SpecialName]
		public void ea(c3 A_0)
		{
			if (A_0 != an)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref an);
			}
		}

		[SpecialName]
		public void ea(c4 A_0)
		{
			if (A_0 != ao)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref ao);
			}
		}

		[SpecialName]
		public void ea(c5 A_0)
		{
			if (A_0 != ap)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref ap);
			}
		}

		[SpecialName]
		public void ea(c7 A_0)
		{
			if (A_0 != aq)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref aq);
			}
		}

		[SpecialName]
		public void ea(c8 A_0)
		{
			if (A_0 != ar)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref ar);
			}
		}

		[SpecialName]
		public void ea(fd A_0)
		{
			if (A_0 != @as)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref @as);
			}
		}

		[SpecialName]
		public void ea(ff A_0)
		{
			if (A_0 != at)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref at);
			}
		}

		[SpecialName]
		public void ea(db A_0)
		{
			if (A_0 != au)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref au);
			}
		}

		[SpecialName]
		public void ea(dc A_0)
		{
			if (A_0 != av)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref av);
			}
		}

		[SpecialName]
		public void ea(dd A_0)
		{
			if (A_0 != aw)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref aw);
			}
		}

		[SpecialName]
		public void ea(bm A_0)
		{
			if (A_0 != ax)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref ax);
			}
		}

		[SpecialName]
		public void ea(de A_0)
		{
			if (A_0 != ay)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref ay);
			}
		}

		[SpecialName]
		public void ea(df A_0)
		{
			if (A_0 != az)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref az);
			}
		}

		[SpecialName]
		public void ea(dg A_0)
		{
			if (A_0 != a0)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref a0);
			}
		}

		[SpecialName]
		public void ea(dh A_0)
		{
			if (A_0 != a1)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref a1);
			}
		}

		[SpecialName]
		public void ea(di A_0)
		{
			if (A_0 != a2)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref a2);
			}
		}

		[SpecialName]
		public void ea(dj A_0)
		{
			if (A_0 != a3)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref a3);
			}
		}

		[SpecialName]
		public void ea(dk A_0)
		{
			if (A_0 != a4)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref a4);
			}
		}

		[SpecialName]
		public void ea(dl A_0)
		{
			if (A_0 != a5)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref a5);
			}
		}

		[SpecialName]
		public void ea(dm A_0)
		{
			if (A_0 != a6)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref a6);
			}
		}

		[SpecialName]
		public void ea(dn A_0)
		{
			if (A_0 != a7)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref a7);
			}
		}

		[SpecialName]
		public void ea(@do A_0)
		{
			if (A_0 != a8)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref a8);
			}
		}

		[SpecialName]
		public void ea(dp A_0)
		{
			if (A_0 != a9)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref a9);
			}
		}

		[SpecialName]
		public void ea(dq A_0)
		{
			if (A_0 != ba)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref ba);
			}
		}

		[SpecialName]
		public void ea(bn A_0)
		{
			if (A_0 != bb)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bb);
			}
		}

		[SpecialName]
		public void ea(fg A_0)
		{
			if (A_0 != bc)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bc);
			}
		}

		[SpecialName]
		public void ea(ez A_0)
		{
			if (A_0 != bd)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bd);
			}
		}

		[SpecialName]
		public void ea(dr A_0)
		{
			if (A_0 != be)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref be);
			}
		}

		[SpecialName]
		public void ea(bo A_0)
		{
			if (A_0 != bf)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bf);
			}
		}

		[SpecialName]
		public void ea(fh A_0)
		{
			if (A_0 != bg)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bg);
			}
		}

		[SpecialName]
		public void ea(fi A_0)
		{
			if (A_0 != bh)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bh);
			}
		}

		[SpecialName]
		public void ea(ds A_0)
		{
			if (A_0 != bi)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bi);
			}
		}

		[SpecialName]
		public void ea(dt A_0)
		{
			if (A_0 != bj)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bj);
			}
		}

		[SpecialName]
		public void ea(bp A_0)
		{
			if (A_0 != bk)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bk);
			}
		}

		[SpecialName]
		public void ea(du A_0)
		{
			if (A_0 != bl)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bl);
			}
		}

		[SpecialName]
		public void ea(dv A_0)
		{
			if (A_0 != bm)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bm);
			}
		}

		[SpecialName]
		public void ea(dw A_0)
		{
			if (A_0 != bn)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bn);
			}
		}

		[SpecialName]
		public void ea(dx A_0)
		{
			if (A_0 != bo)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bo);
			}
		}

		[SpecialName]
		public void ea(fj A_0)
		{
			if (A_0 != bp)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bp);
			}
		}

		[SpecialName]
		public void ea(dy A_0)
		{
			if (A_0 != bq)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bq);
			}
		}

		[SpecialName]
		public void ea(bq A_0)
		{
			if (A_0 != br)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref br);
			}
		}

		[SpecialName]
		public void ea(br A_0)
		{
			if (A_0 != bs)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bs);
			}
		}

		[SpecialName]
		public void ea(bs A_0)
		{
			if (A_0 != bt)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bt);
			}
		}

		[SpecialName]
		public void ea(d2 A_0)
		{
			if (A_0 != bu)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bu);
			}
		}

		[SpecialName]
		public void ea(bt A_0)
		{
			if (A_0 != bv)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bv);
			}
		}

		[SpecialName]
		public void ea(gg A_0)
		{
			if (A_0 != bw)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bw);
			}
		}

		[SpecialName]
		public void ea(e2 A_0)
		{
			if (A_0 != bx)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				ea(ref bx);
			}
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class b
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public FIMatFileDB a;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public FIMatFileSecurity b;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public FIUserRegistration c;

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type g()
		{
			return typeof(b);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static a g<a>(a A_0) where a : new()
		{
			if (A_0 == null)
			{
				return new a();
			}
			return A_0;
		}

		[DebuggerHidden]
		private void g<a>(ref a A_0)
		{
			A_0 = default(a);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public b()
		{
		}

		[SpecialName]
		public FIMatFileDB h()
		{
			a = g<FIMatFileDB>(a);
			return a;
		}

		[SpecialName]
		public FIMatFileSecurity i()
		{
			b = g<FIMatFileSecurity>(b);
			return b;
		}

		[SpecialName]
		public FIUserRegistration j()
		{
			c = g<FIUserRegistration>(c);
			return c;
		}

		[SpecialName]
		public void g(FIMatFileDB A_0)
		{
			if (A_0 != a)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				g(ref a);
			}
		}

		[SpecialName]
		public void g(FIMatFileSecurity A_0)
		{
			if (A_0 != b)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				g(ref b);
			}
		}

		[SpecialName]
		public void g(FIUserRegistration A_0)
		{
			if (A_0 != c)
			{
				if (A_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				g(ref c);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class c<a> where a : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static a m_a;

		[SpecialName]
		[DebuggerHidden]
		internal a a()
		{
			if (c<a>.a == null)
			{
				c<a>.a = new a();
			}
			return c<a>.a;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public c()
		{
		}
	}

	private static readonly c<global::b> m_a;

	private static readonly c<global::a> m_b;

	private static readonly c<User> m_c;

	private static c<a> m_d;

	private static readonly c<b> m_e;

	static c()
	{
		global::c.m_a = new c<global::b>();
		global::c.m_b = new c<global::a>();
		global::c.m_c = new c<User>();
		global::c.m_d = new c<a>();
		global::c.m_e = new c<b>();
	}

	[SpecialName]
	[DebuggerHidden]
	internal static global::b e()
	{
		return global::c.m_a.a();
	}

	[SpecialName]
	[DebuggerHidden]
	internal static global::a d()
	{
		return global::c.m_b.a();
	}

	[SpecialName]
	[DebuggerHidden]
	internal static User c()
	{
		return global::c.m_c.a();
	}

	[SpecialName]
	[DebuggerHidden]
	internal static a b()
	{
		return global::c.m_d.a();
	}

	[SpecialName]
	[DebuggerHidden]
	internal static b a()
	{
		return global::c.m_e.a();
	}
}
