using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using DirectShowLib;
using Microsoft.VisualBasic.CompilerServices;

internal class d4 : ISampleGrabberCB, IDisposable
{
	public class a
	{
		private bool m_a;

		private int b;

		private int c;

		private Rectangle[] d;

		private float e;

		private float f;

		private Size g;

		private ej.b h;

		private e i;

		public a()
		{
			d = new Rectangle[2];
		}

		public a o(bool A_0)
		{
			a obj = (a)MemberwiseClone();
			obj.p(A_0);
			return obj;
		}

		protected void p(bool A_0)
		{
			m_a = A_0;
		}

		public a o(int A_0)
		{
			a obj = (a)MemberwiseClone();
			obj.p(A_0);
			return obj;
		}

		protected void p(int A_0)
		{
			b = A_0;
		}

		public a q(int A_0)
		{
			a obj = (a)MemberwiseClone();
			obj.r(A_0);
			return obj;
		}

		protected void r(int A_0)
		{
			c = A_0;
		}

		public a o(Rectangle A_0)
		{
			a obj = (a)MemberwiseClone();
			obj.p(A_0);
			return obj;
		}

		protected void p(Rectangle A_0)
		{
			d[(int)h] = A_0;
		}

		public a o(Rectangle A_0, ej.b A_1)
		{
			a obj = (a)MemberwiseClone();
			obj.p(A_0, A_1);
			return obj;
		}

		protected void p(Rectangle A_0, ej.b A_1)
		{
			d[(int)A_1] = A_0;
		}

		public a o(float A_0)
		{
			a obj = (a)MemberwiseClone();
			obj.p(A_0);
			return obj;
		}

		protected void p(float A_0)
		{
			e = A_0;
		}

		public a q(float A_0)
		{
			a obj = (a)MemberwiseClone();
			obj.r(A_0);
			return obj;
		}

		protected void r(float A_0)
		{
			f = A_0;
		}

		public a o(Size A_0)
		{
			a obj = (a)MemberwiseClone();
			obj.p(A_0);
			return obj;
		}

		protected void p(Size A_0)
		{
			g = A_0;
		}

		public a o(ej.b A_0)
		{
			a obj = (a)MemberwiseClone();
			obj.p(A_0);
			return obj;
		}

		public a o(e A_0)
		{
			a obj = (a)MemberwiseClone();
			obj.p(A_0);
			return obj;
		}

		protected void p(ej.b A_0)
		{
			h = A_0;
		}

		protected void p(e A_0)
		{
			i = A_0;
		}

		[SpecialName]
		public bool o()
		{
			ref Rectangle reference = ref d[(int)h];
			if (reference.X == 0 && reference.Y == 0 && reference.Width == 0 && reference.Height == 0)
			{
				return false;
			}
			return true;
		}

		[SpecialName]
		public bool p()
		{
			return m_a;
		}

		[SpecialName]
		public ej.b q()
		{
			return h;
		}

		[SpecialName]
		public int r()
		{
			return c;
		}

		[SpecialName]
		public int s()
		{
			return b;
		}

		[SpecialName]
		public float t()
		{
			return ej.a(b);
		}

		[SpecialName]
		public float u()
		{
			return e;
		}

		[SpecialName]
		public float v()
		{
			return f;
		}

		[SpecialName]
		public Rectangle w()
		{
			return d[(int)h];
		}

		[SpecialName]
		public Rectangle x()
		{
			ej.b b10 = ((h == ej.b.a) ? ej.b.b : ej.b.a);
			return d[(int)b10];
		}

		[SpecialName]
		public Rectangle[] y()
		{
			Rectangle[] array = new Rectangle[checked(d.Length - 1 + 1)];
			Array.Copy(d, array, d.Length);
			return array;
		}

		[SpecialName]
		public int z()
		{
			return g.Width;
		}

		[SpecialName]
		public int aa()
		{
			return g.Height;
		}

		[SpecialName]
		public e ab()
		{
			return i;
		}
	}

	private class b
	{
		private static Collection<string> m_a;

		static b()
		{
			d4.b.m_a = new Collection<string>();
		}

		public static void a(string A_0)
		{
			d4.b.m_a.Remove(A_0);
		}

		public static void a(string A_0, ref bool A_1)
		{
			if (!d4.b.m_a.Contains(A_0))
			{
				d4.b.m_a.Add(A_0);
				A_1 = true;
			}
			else
			{
				A_1 = false;
			}
		}

		public static void a()
		{
			d4.b.m_a.Clear();
		}
	}

	public delegate void c(d5 A_0);

	private enum d
	{
		a,
		b,
		c
	}

	public enum e
	{
		a,
		b,
		c,
		d
	}

	private fz m_a;

	private bool m_b;

	private bool m_c;

	private IGraphBuilder m_d;

	private IFilterGraph2 m_e;

	private IBaseFilter f;

	private IMediaControl g;

	private IBaseFilter h;

	private ISampleGrabber i;

	private IBaseFilter j;

	private IVMRWindowlessControl9 k;

	private ICaptureGraphBuilder2 l;

	private IVMRMixerBitmap9 m;

	private Bitmap n;

	private Color o;

	private const int p = 240;

	private const int q = 120;

	private const int m_r = 40;

	private const int m_s = 70;

	private const int m_t = 40;

	private const int m_u = 100;

	private bool m_v;

	private IAMCameraControl m_w;

	private IAMVideoProcAmp m_x;

	private string m_y;

	private string m_z;

	private IVMRFilterConfig9 m_aa;

	private AMMediaType m_ab;

	private float m_ac;

	private float m_ad;

	private int m_ae;

	private int m_af;

	private int m_ag;

	private int m_ah;

	private a m_ai;

	private bool m_aj;

	private Bitmap m_ak;

	private bool m_al;

	private bool m_am;

	private bool m_an;

	[CompilerGenerated]
	private c m_ao;

	private IAMStreamConfig m_ap;

	private bool m_aq;

	public const string ar = "CameraData\\";

	private const string m_as = "Cam_";

	private const string m_at = ".fibcd";

	private const int m_au = 3;

	private const int m_av = 1;

	private int[] m_aw;

	private int[] m_ax;

	private int[] m_ay;

	private int[] m_az;

	private bool m_a0;

	private bool a1;

	private int a2;

	private int a3;

	private int a4;

	private const int a5 = 4;

	private const string a6 = "vid_046d";

	private const string a7 = "pid_0990";

	private const string a8 = "pid_0809";

	private const string a9 = "vid_2560";

	private const string ba = "pid_c051";

	private const string bb = "pid_c05a";

	private const string bc = "pid_c151";

	private const string bd = "vid_203a";

	private const string be = "pid_fff9";

	private d bf;

	private const string bg = "Camera (S/N ";

	public const string bh = "None";

	private Guid bi;

	private Guid bj;

	private Guid bk;

	private Guid bl;

	private Guid bm;

	private Guid bn;

	private Guid bo;

	private const string bp = "FIRotateVideoImage";

	private IBaseFilter bq;

	private bool br;

	private IntPtr bs;

	private bool bt;

	private DateTime bu;

	private const int bv = 2000;

	private const int bw = 5;

	[CompilerGenerated]
	private System.Timers.Timer bx;

	private int by;

	private int bz;

	private const int b0 = 3000;

	[CompilerGenerated]
	private System.Timers.Timer b1;

	private bool b2;

	[SpecialName]
	[CompilerGenerated]
	private void b(c A_0)
	{
		c c10 = this.m_ao;
		c c11;
		do
		{
			c11 = c10;
			c value = (c)Delegate.Combine(c11, A_0);
			c10 = Interlocked.CompareExchange(ref this.m_ao, value, c11);
		}
		while ((object)c10 != c11);
	}

	[SpecialName]
	[CompilerGenerated]
	private void a(c A_0)
	{
		c c10 = this.m_ao;
		c c11;
		do
		{
			c11 = c10;
			c value = (c)Delegate.Remove(c11, A_0);
			c10 = Interlocked.CompareExchange(ref this.m_ao, value, c11);
		}
		while ((object)c10 != c11);
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer z()
	{
		return bx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void a(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = b;
		System.Timers.Timer timer = bx;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		bx = A_0;
		timer = bx;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual System.Timers.Timer aa()
	{
		return b1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void b(System.Timers.Timer A_0)
	{
		ElapsedEventHandler value = a;
		System.Timers.Timer timer = b1;
		if (timer != null)
		{
			timer.Elapsed -= value;
		}
		b1 = A_0;
		timer = b1;
		if (timer != null)
		{
			timer.Elapsed += value;
		}
	}

	private void b(object A_0, ElapsedEventArgs A_1)
	{
		if ((!al() && !ak()) || h == null)
		{
			return;
		}
		((IQualProp)h).get_FramesDrawn(out var pcFramesDrawn);
		checked
		{
			if (pcFramesDrawn == by)
			{
				if (bz >= 5)
				{
					lock (this)
					{
						bz = 0;
						this.m_a.c(fz.b.b, "Video stream frozen detected. Total frames: " + pcFramesDrawn);
						a(null, global::r.d.a.b.a);
						return;
					}
				}
				bz++;
			}
			else
			{
				bz = 0;
				by = pcFramesDrawn;
			}
		}
	}

	private void a(object A_0, ElapsedEventArgs A_1)
	{
		b2 = false;
	}

	[DllImport("gdi32.dll")]
	public static extern IntPtr CreateCompatibleDC(IntPtr A_0);

	[DllImport("gdi32.dll")]
	public static extern bool DeleteDC(IntPtr A_0);

	[DllImport("gdi32.dll")]
	public static extern bool DeleteObject(IntPtr A_0);

	[DllImport("gdi32.dll")]
	public static extern IntPtr SelectObject(IntPtr A_0, IntPtr A_1);

	public d4(fz A_0, bool A_1, bool A_2, bool A_3, bool A_4)
	{
		this.m_d = (IGraphBuilder)new FilterGraph();
		this.m_e = (IFilterGraph2)new FilterGraph();
		f = null;
		g = null;
		j = (IBaseFilter)i;
		k = null;
		l = null;
		m = null;
		this.m_w = null;
		this.m_x = null;
		this.m_ai = new a();
		this.m_al = false;
		this.m_aw = new int[1] { 640 };
		this.m_ax = new int[1] { 480 };
		this.m_ay = new int[9] { 1280, 1024, 960, 768, 720, 640, 480, 320, 240 };
		this.m_az = new int[9] { 1280, 1024, 960, 768, 720, 640, 480, 320, 240 };
		bf = d4.d.a;
		bi = new Guid("27FCD9F4-5C38-494D-80FF-C09475F2E718");
		bj = new Guid("53226FB8-3061-4242-8C7B-5575B17F0DB1");
		bk = new Guid("113CE559-C96E-452B-A6B8-77A5591D7A51");
		bl = new Guid("913AF6A5-82C5-45F1-A903-AE9E3B756970");
		bm = new Guid("DBDD71B1-B451-4A83-ADD0-5FAFA399AF01");
		bn = new Guid("26259A4E-B782-49D2-BAC0-43BAEB65B285");
		bo = new Guid("64A10C89-D6FD-41BF-AEC5-58C6959DCB1D");
		bq = null;
		this.m_a = A_0;
		br = A_1;
		this.m_b = A_2;
		this.m_c = A_2;
		this.m_v = A_3;
		bt = A_4;
		a(new System.Timers.Timer(2000.0));
		b(new System.Timers.Timer(3000.0));
	}

	public static void a(Bitmap A_0, ref byte[] A_1)
	{
		BitmapData bitmapData = null;
		Rectangle rect = new Rectangle(0, 0, A_0.Width, A_0.Height);
		checked
		{
			try
			{
				bitmapData = A_0.LockBits(rect, ImageLockMode.ReadWrite, A_0.PixelFormat);
				int num = Math.Abs(bitmapData.Stride) * bitmapData.Height;
				A_1 = new byte[num - 1 + 1];
				Marshal.Copy(bitmapData.Scan0, A_1, 0, num);
			}
			finally
			{
				if (bitmapData != null)
				{
					A_0.UnlockBits(bitmapData);
				}
			}
		}
	}

	[SpecialName]
	public a ab()
	{
		lock (this)
		{
			return this.m_ai;
		}
	}

	[SpecialName]
	public bool ac()
	{
		return false;
	}

	[SpecialName]
	public short ad()
	{
		return 0;
	}

	[SpecialName]
	public short ae()
	{
		return 0;
	}

	[SpecialName]
	public short af()
	{
		return 0;
	}

	[SpecialName]
	public void a(short A_0)
	{
	}

	[SpecialName]
	public uint ag()
	{
		return 0u;
	}

	[SpecialName]
	public uint ah()
	{
		return 0u;
	}

	[SpecialName]
	public uint ai()
	{
		return 0u;
	}

	[SpecialName]
	public void a(uint A_0)
	{
	}

	[SpecialName]
	public bool aj()
	{
		return false;
	}

	[SpecialName]
	public void r(bool A_0)
	{
	}

	[SpecialName]
	public bool ak()
	{
		lock (this)
		{
			return this.m_am;
		}
	}

	[SpecialName]
	public bool al()
	{
		lock (this)
		{
			return this.m_an;
		}
	}

	public void r(c A_0)
	{
		lock (this)
		{
			a(A_0);
			b(A_0);
		}
	}

	[SpecialName]
	public string am()
	{
		lock (this)
		{
			return this.m_y;
		}
	}

	[SpecialName]
	public int an()
	{
		return a2;
	}

	[SpecialName]
	public int ao()
	{
		return a3;
	}

	[SpecialName]
	public int ap()
	{
		return a4;
	}

	private IBaseFilter a(e A_0, bool A_1, bool A_2)
	{
		return (IBaseFilter)Activator.CreateInstance(Type.GetTypeFromCLSID(A_0 switch
		{
			d4.e.c => (!A_1) ? bk : (A_2 ? bm : bn), 
			d4.e.b => (!A_1) ? bj : (A_2 ? bn : bm), 
			d4.e.d => bi, 
			_ => (!A_1) ? default(Guid) : (A_2 ? bo : bl), 
		}));
	}

	public bool a(IntPtr A_0, r.d A_1, ej.b A_2, string A_3, bool A_4, bool A_5, bool A_6, bool A_7, bool A_8, r.d.a.b A_9)
	{
		bool result;
		lock (this)
		{
			object ppint = null;
			r.d.a a10 = null;
			bool flag = default(bool);
			try
			{
				a10 = new r.d.a(A_9, 0L);
				a10.a = global::r.d.a.a.b;
				DsDevice[] array = b((fz)null);
				DsDevice dsDevice;
				if (array.Length == 0)
				{
					result = false;
				}
				else
				{
					dsDevice = a(array, A_3);
					if (dsDevice == null)
					{
						dsDevice = array[0];
					}
					this.m_y = a(dsDevice.DevicePath);
					a1 = dsDevice.DevicePath.Contains("pid_c051") || dsDevice.DevicePath.Contains("pid_c05a") || dsDevice.DevicePath.Contains("pid_c151");
					if (A_4)
					{
						goto IL_0119;
					}
					string text = s(dsDevice.DevicePath);
					this.m_a.c(fz.b.a, "Camera detected: " + text);
					bool A_10 = default(bool);
					d4.b.a(this.m_y, ref A_10);
					if (A_10)
					{
						flag = true;
						goto IL_0119;
					}
					r.d.a obj = a10;
					string A_11 = "VideoCameraAllocationConflictFmt";
					obj.b = string.Format(hu.a(ref A_11), this.m_y);
					this.m_z = null;
					this.m_y = string.Empty;
					result = false;
				}
				goto end_IL_0012;
				IL_0119:
				this.m_z = r(dsDevice.DevicePath);
				bs = A_0;
				a(A_2, A_7);
				string path = i3.o() + "\\CameraData\\EdgesToUse.txt";
				int result2 = 0;
				if (File.Exists(path))
				{
					try
					{
						bf = d4.d.a;
						using StreamReader streamReader = new StreamReader(path);
						if (int.TryParse(streamReader.ReadLine(), out result2))
						{
							bf = (d)result2;
						}
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2);
						Exception ex3 = ex2;
						this.m_a.c(fz.b.b, "Error trying to read edges to use for focus from file");
						ProjectData.ClearProjectError();
					}
				}
				string text2 = null;
				switch (bf)
				{
				case d4.d.a:
					text2 = "Both";
					break;
				case d4.d.b:
					text2 = "Bottom";
					break;
				case d4.d.c:
					text2 = "Top";
					break;
				default:
					text2 = "Both";
					bf = d4.d.a;
					this.m_a.c(fz.b.b, "Unrecognized edges for focus type -- must be 0: Both, 1: Bottom, 2: Top");
					break;
				}
				this.m_a.c(fz.b.a, "Edges to use for focus = " + text2);
				if (this.m_ai.q() == ej.b.b && !A_5)
				{
					this.m_ai = this.m_ai.o(ej.b.a);
				}
				else if (this.m_ai.q() == ej.b.a && !A_6)
				{
					this.m_ai = this.m_ai.o(ej.b.b);
				}
				this.m_c = this.m_c && a1;
				this.m_a0 = a1;
				e e10 = this.m_ai.ab();
				this.m_e = (IFilterGraph2)new FilterGraph();
				g = (IMediaControl)this.m_e;
				l = (ICaptureGraphBuilder2)new CaptureGraphBuilder2();
				i = (ISampleGrabber)new SampleGrabber();
				int num = l.SetFiltergraph(this.m_e);
				DsError.ThrowExceptionForHR(num);
				num = this.m_e.AddSourceFilterForMoniker(dsDevice.Mon, null, "FISource", out f);
				DsError.ThrowExceptionForHR(num);
				this.m_w = (IAMCameraControl)f;
				j = (IBaseFilter)i;
				if (this.m_ab == null)
				{
					this.m_ab = new AMMediaType();
				}
				this.m_ab.majorType = MediaType.Video;
				this.m_ab.subType = MediaSubType.RGB24;
				this.m_ab.formatType = FormatType.VideoInfo;
				num = i.SetMediaType(this.m_ab);
				DsError.ThrowExceptionForHR(num);
				num = i.SetOneShot(OneShot: false);
				DsError.ThrowExceptionForHR(num);
				num = i.SetBufferSamples(BufferThem: true);
				DsError.ThrowExceptionForHR(num);
				num = l.FindInterface(PinCategory.Capture, MediaType.Video, f, typeof(IAMStreamConfig).GUID, out ppint);
				DsError.ThrowExceptionForHR(num);
				this.m_ap = ppint as IAMStreamConfig;
				if (this.m_ap == null)
				{
					throw new Exception("Failed to get IAMStreamConfig");
				}
				num = this.m_ap.GetFormat(out this.m_ab);
				DsError.ThrowExceptionForHR(num);
				int A_12 = default(int);
				int A_13 = default(int);
				if (!a(ref A_12, ref A_13))
				{
					this.m_a.c(fz.b.a, "Cannot find acceptable camera resolution in FICameraStage.InitVideo");
					result = false;
				}
				else
				{
					if (e10 != d4.e.a || this.m_b)
					{
						switch (e10)
						{
						case d4.e.d:
							this.m_ai = this.m_ai.o(new Size(A_12, A_13));
							break;
						default:
							this.m_ai = this.m_ai.o(new Size(A_13, A_12));
							break;
						case d4.e.a:
							this.m_ai = this.m_ai.o(new Size(A_12, A_13));
							break;
						}
						try
						{
							bq = a(e10, this.m_b, this.m_c);
						}
						catch (COMException ex4)
						{
							ProjectData.SetProjectError(ex4);
							COMException ex5 = ex4;
							if (ex5.Message.Contains("80040154"))
							{
								string text3 = global::c.d().Info.DirectoryPath + "\\FIRotateVideoImage.dll";
								if (!File.Exists(text3))
								{
									throw new ApplicationException("Missing FIRotateVideoImage.dll file. File should be located in My.Application.Info.DirectoryPath. Live video is disabled.");
								}
								if (!Process.Start(new ProcessStartInfo
								{
									FileName = "regsvr32.exe",
									WindowStyle = ProcessWindowStyle.Hidden,
									Arguments = "-s \"" + text3 + "\""
								}).WaitForExit(3000))
								{
									throw new ApplicationException("Video not initialized due to failure to find FIRotateVideoImage.dll.");
								}
								bq = a(e10, this.m_b, this.m_c);
							}
							ProjectData.ClearProjectError();
						}
						num = this.m_e.AddFilter(bq, "Rotate Video Image");
						DsError.ThrowExceptionForHR(num);
					}
					else
					{
						this.m_ai = this.m_ai.o(new Size(A_12, A_13));
					}
					num = this.m_e.AddFilter(j, "Filmetrics Grabber");
					DsError.ThrowExceptionForHR(num);
					if (h == null)
					{
						h = (IBaseFilter)new VideoMixingRenderer9();
					}
					this.m_aa = (IVMRFilterConfig9)h;
					num = this.m_aa.SetRenderingMode(VMR9Mode.Windowless);
					DsError.ThrowExceptionForHR(num);
					num = this.m_e.AddFilter(h, "Filmetrics Renderer");
					DsError.ThrowExceptionForHR(num);
					k = (IVMRWindowlessControl9)h;
					num = k.SetVideoClippingWindow(A_0);
					DsError.ThrowExceptionForHR(num);
					num = k.SetVideoPosition(null, checked(new Rectangle(0, 0, (int)Math.Round((float)this.m_ag * this.m_ac), (int)Math.Round((float)this.m_ah * this.m_ad))));
					DsError.ThrowExceptionForHR(num);
					num = k.SetAspectRatioMode(VMR9AspectRatioMode.LetterBox);
					DsError.ThrowExceptionForHR(num);
					if (e10 == d4.e.a && !this.m_b)
					{
						num = l.RenderStream(null, null, f, j, h);
					}
					else
					{
						IPin ppinOut = DsFindPin.ByDirection(f, PinDirection.Output, 0);
						IPin ppinIn = DsFindPin.ByDirection(bq, PinDirection.Input, 0);
						IPin ppinOut2 = DsFindPin.ByDirection(bq, PinDirection.Output, 0);
						IPin ppinIn2 = DsFindPin.ByDirection(j, PinDirection.Input, 0);
						IPin ppinOut3 = DsFindPin.ByDirection(j, PinDirection.Output, 0);
						IPin ppinIn3 = DsFindPin.ByDirection(h, PinDirection.Input, 0);
						num = this.m_e.Connect(ppinOut, ppinIn);
						if (num < 0)
						{
							Marshal.ThrowExceptionForHR(num);
						}
						num = this.m_e.Connect(ppinOut2, ppinIn2);
						if (num < 0)
						{
							Marshal.ThrowExceptionForHR(num);
						}
						num = this.m_e.Connect(ppinOut3, ppinIn3);
						if (num < 0)
						{
							Marshal.ThrowExceptionForHR(num);
						}
						Marshal.ReleaseComObject(ppinOut);
						Marshal.ReleaseComObject(ppinIn);
						Marshal.ReleaseComObject(ppinOut2);
						Marshal.ReleaseComObject(ppinIn2);
						Marshal.ReleaseComObject(ppinOut3);
						Marshal.ReleaseComObject(ppinIn3);
					}
					m = (IVMRMixerBitmap9)h;
					this.m_ab = new AMMediaType();
					num = i.GetConnectedMediaType(this.m_ab);
					if (num < 0)
					{
						Marshal.ThrowExceptionForHR(num);
					}
					if (this.m_ab.formatType != FormatType.VideoInfo || this.m_ab.formatPtr == IntPtr.Zero)
					{
						throw new NotSupportedException("Unknown Grabber Media Format");
					}
					Marshal.FreeCoTaskMem(this.m_ab.formatPtr);
					this.m_ab.formatPtr = IntPtr.Zero;
					this.m_ab = null;
					if (A_8)
					{
						v();
						u();
					}
					a(ref a2, ref a3, ref a4);
					a10.a = global::r.d.a.a.a;
					b2 = true;
					aa().Start();
					result = true;
				}
				end_IL_0012:;
			}
			catch (Exception ex6)
			{
				ProjectData.SetProjectError(ex6);
				Exception ex7 = ex6;
				if (flag)
				{
					d4.b.a(this.m_y);
				}
				bool flag2 = default(bool);
				try
				{
					if (ex7.ToString().Contains("80040273"))
					{
						ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
						if (managementObjectSearcher.Get().Count != 0)
						{
							foreach (ManagementObject item in managementObjectSearcher.Get())
							{
								if (item["Name"].ToString().Contains("VGA"))
								{
									flag2 = true;
								}
							}
						}
						else
						{
							flag2 = true;
						}
					}
				}
				catch (Exception ex8)
				{
					ProjectData.SetProjectError(ex8);
					Exception ex9 = ex8;
					this.m_a.c(fz.b.a, "Exception thrown in InitOrReinitVideo while attempting to check video controller.");
					a10.b = "Unknown error while attempting to initialize video.\r\nPossible causes include incompatible graphic card or graphic card driver not properly installed.";
					ProjectData.ClearProjectError();
				}
				if (flag2)
				{
					a10.b = "No compatible graphic card or graphic card driver not properly installed.";
				}
				this.m_a.c(fz.b.b, "Error attempting to initialize video in FICameraStage.InitVideo", ex7);
				ax();
				result = false;
				ProjectData.ClearProjectError();
			}
			finally
			{
				A_1?.d(default(Guid), a10);
			}
		}
		return result;
	}

	private string s(string A_0)
	{
		string empty = string.Empty;
		if (A_0.Contains("vid_046d"))
		{
			if (A_0.Contains("pid_0990"))
			{
				return "Lo1";
			}
			if (A_0.Contains("pid_0809"))
			{
				return "Lo2";
			}
			return "Lo?";
		}
		if (A_0.Contains("vid_2560"))
		{
			if (A_0.Contains("pid_c051"))
			{
				return "Ec1";
			}
			if (A_0.Contains("pid_c151"))
			{
				return "Ec2";
			}
			if (A_0.Contains("pid_c05a"))
			{
				return "Ec3";
			}
			return "Ec?";
		}
		if (A_0.Contains("vid_203a"))
		{
			if (A_0.Contains("pid_fff9"))
			{
				return "EcTest";
			}
			return "EcTest?";
		}
		return "Unknown";
	}

	private bool a(ref int A_0, ref int A_1)
	{
		int[] array;
		int[] array2;
		if (this.m_a0)
		{
			array = this.m_aw;
			array2 = this.m_ax;
		}
		else
		{
			array = this.m_ay;
			array2 = this.m_az;
		}
		checked
		{
			try
			{
				int num = array.Length - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					int num3 = array2.Length - 1;
					for (int num4 = 0; num4 <= num3; num4++)
					{
						if (array[num2] < 2 * array2[num4])
						{
							VideoInfoHeader videoInfoHeader = new VideoInfoHeader();
							Marshal.PtrToStructure(this.m_ab.formatPtr, (object)videoInfoHeader);
							videoInfoHeader.BmiHeader.Width = array[num2];
							videoInfoHeader.BmiHeader.Height = array2[num4];
							Marshal.StructureToPtr((object)videoInfoHeader, this.m_ab.formatPtr, false);
							if (this.m_ap.SetFormat(this.m_ab) == 0)
							{
								A_0 = array[num2];
								A_1 = array2[num4];
								return true;
							}
						}
					}
				}
			}
			finally
			{
				DsUtils.FreeAMMediaType(this.m_ab);
				this.m_ab = null;
			}
			return false;
		}
	}

	private int a(double A_0, IntPtr A_1, int A_2)
	{
		return 0;
	}

	int ISampleGrabberCB.BufferCB(double A_0, IntPtr A_1, int A_2)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		return this.a(A_0, A_1, A_2);
	}

	private int a(double A_0, IMediaSample A_1)
	{
		this.m_aq = true;
		return 0;
	}

	int ISampleGrabberCB.SampleCB(double A_0, IMediaSample A_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		return this.a(A_0, A_1);
	}

	private static DsDevice[] b(fz A_0)
	{
		List<DsDevice> list = new List<DsDevice>();
		DsDevice[] devicesOfCat = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
		bool flag = false;
		List<string> list2 = new List<string>();
		DsDevice[] array = devicesOfCat;
		foreach (DsDevice dsDevice in array)
		{
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = false;
			bool flag8 = false;
			bool flag9 = false;
			bool flag10 = false;
			string devicePath = dsDevice.DevicePath;
			flag2 = devicePath.Contains("vid_046d");
			if (flag2)
			{
				flag4 = devicePath.Contains("pid_0990");
				flag5 = devicePath.Contains("pid_0809");
			}
			flag3 = devicePath.Contains("vid_2560");
			if (flag3)
			{
				flag6 = devicePath.Contains("pid_c051");
				flag7 = devicePath.Contains("pid_c151");
				flag8 = devicePath.Contains("pid_c05a");
			}
			flag9 = devicePath.Contains("vid_203a");
			if (flag9)
			{
				flag10 = devicePath.Contains("pid_fff9");
			}
			if ((flag2 && (flag4 || flag5)) || (flag3 && (flag6 || flag7 || flag8)) || (flag9 && flag10))
			{
				list.Add(dsDevice);
			}
			devicePath = null;
			if (flag)
			{
				string item = (0 - (flag2 ? 1 : 0)).ToString() + (0 - (flag4 ? 1 : 0)) + (0 - (flag5 ? 1 : 0)) + (0 - (flag3 ? 1 : 0)) + (0 - (flag6 ? 1 : 0)) + (0 - (flag7 ? 1 : 0)) + Conversions.ToString(0 - (flag8 ? 1 : 0)) + (0 - (flag9 ? 1 : 0)) + (0 - (flag10 ? 1 : 0)) + "    " + dsDevice.DevicePath;
				list2.Add(item);
			}
		}
		if (flag)
		{
			A_0.c(fz.b.a, "Total DS devices: " + list2.Count);
			foreach (string item2 in list2)
			{
				A_0.c(fz.b.a, item2);
			}
		}
		return list.ToArray();
	}

	public static List<string> a(fz A_0)
	{
		List<string> list = new List<string>();
		DsDevice[] array = b(A_0);
		foreach (DsDevice dsDevice in array)
		{
			list.Add(a(dsDevice.DevicePath));
		}
		return list;
	}

	public static void y()
	{
		d4.b.a();
	}

	public void a(bool A_0, int A_1, ej.b A_2)
	{
		lock (this)
		{
			a a10 = this.m_ai;
			if (this.m_ai.r() != A_1)
			{
				a10 = a10.q(A_1);
			}
			if (this.m_ai.q() != A_2)
			{
				a10 = a10.o(A_2);
			}
			this.m_ai = a10;
			this.m_aj = A_0;
			if (this.m_ai.p())
			{
				u();
			}
		}
	}

	public void b(ej.b A_0, bool A_1)
	{
		lock (this)
		{
			bool flag = this.m_ai.q() != A_0;
			bool flag2 = A_1 != this.m_aj;
			if (flag)
			{
				this.m_ai = this.m_ai.o(A_0);
			}
			if (flag2)
			{
				this.m_aj = A_1;
			}
			if (this.m_ai.p() && (flag || flag2))
			{
				u();
			}
		}
	}

	public void a(int A_0, int A_1, int A_2)
	{
		lock (this)
		{
			this.m_ag = A_0;
			this.m_ah = A_1;
			this.m_ai = this.m_ai.o(A_2);
			t();
		}
	}

	public void aq()
	{
		checked
		{
			lock (this)
			{
				int num = this.m_ai.z();
				int num2 = this.m_ai.aa();
				byte[] A_ = null;
				int A_2 = default(int);
				int A_3 = default(int);
				int A_4 = default(int);
				int A_5 = default(int);
				if (br)
				{
					int lValue = this.m_ai.r();
					this.m_w.Set(CameraControlProperty.Focus, 0, CameraControlFlags.Manual);
					Thread.Sleep(500);
					au();
					a(this.m_ak, ref A_);
					a(num, num2, A_, ref A_2, ref A_3, ref A_4, ref A_5);
					this.m_w.Set(CameraControlProperty.Focus, lValue, CameraControlFlags.Manual);
				}
				else
				{
					au();
					a(this.m_ak, ref A_);
					int num3;
					int num4;
					bool flag;
					List<Rectangle> list;
					unchecked
					{
						num3 = num2 / 2;
						num4 = num / 2;
						int num5 = 0;
						flag = this.m_ai.q() == ej.b.b;
						new List<int>();
						new List<int>();
						list = new List<Rectangle>();
					}
					int num6 = ((!bt || flag) ? unchecked(Math.Min(num, num2) / 4) : (unchecked(Math.Min(num, num2) / 2) - 1));
					int a_ = unchecked(num2 / 2) - num6;
					int a_2 = unchecked(num2 / 2) + num6;
					int a_3 = unchecked(num / 2) - num6;
					int a_4 = unchecked(num / 2) + num6;
					bool flag2 = flag && !this.m_v;
					int num7 = 0;
					int A_6 = default(int);
					int A_7 = default(int);
					double A_8 = default(double);
					double A_9 = default(double);
					double A_10 = default(double);
					int A_11 = default(int);
					int A_12 = default(int);
					int A_13 = default(int);
					int A_14 = default(int);
					int A_15 = default(int);
					int A_16 = default(int);
					bool A_17 = default(bool);
					do
					{
						if (list.Count > 0)
						{
							list.Clear();
						}
						int num8;
						int a_5;
						if (flag)
						{
							if (this.m_v)
							{
								num8 = 120;
								a_5 = 300;
							}
							else
							{
								a(num6, num, num3, num4, A_, ref A_6, ref A_7, ref A_8, ref A_9, ref A_10);
								double num9 = 2.5 * A_8 - 1.5 * A_10;
								num8 = 120;
								a_5 = ((!(num9 < (double)num8)) ? ((int)Math.Round(num9)) : num8);
							}
						}
						else
						{
							num8 = ((!bt) ? 720 : 360);
							a_5 = num8;
						}
						int num10 = num6;
						for (int num5 = 1; num5 <= num10; num5++)
						{
							if (a(num5, num, num3, num4, flag, num8, ref A_11, ref A_12, A_) && !a(A_12, A_11, list))
							{
								a(num, num2, a_, a_2, a_3, a_4, flag, a_5, A_11, A_12, ref A_13, ref A_14, ref A_15, ref A_16, ref A_17, A_);
								if (!A_17 && !a(A_15 + unchecked(checked(A_16 - A_15) / 2), A_13 + unchecked(checked(A_14 - A_13) / 2), list))
								{
									list.Add(new Rectangle(A_15, A_13, A_16 - A_15, A_14 - A_13));
								}
							}
						}
						if (list.Count > 0)
						{
							int num11 = list.Count - 1;
							for (int num5 = 0; num5 <= num11; num5++)
							{
								if (list[num5].Width * list[num5].Height > (A_3 - A_2) * (A_5 - A_4))
								{
									A_2 = list[num5].Y;
									A_3 = A_2 + list[num5].Height;
									A_4 = list[num5].X;
									A_5 = A_4 + list[num5].Width;
								}
							}
						}
						num7++;
						if (flag2 && num7 < 2)
						{
							unchecked
							{
								num4 = checked(A_4 + A_5) / 2;
								num3 = checked(A_2 + A_3) / 2;
								num6 /= 2;
							}
							a_ = num3 - num6;
							a_2 = num3 + num6;
							a_3 = num4 - num6;
							a_4 = num4 + num6;
							flag2 = true;
						}
						else
						{
							flag2 = false;
						}
					}
					while (flag2);
				}
				Rectangle a_6 = default(Rectangle);
				a_6.X = A_4;
				a_6.Y = A_2;
				a_6.Width = A_5 - A_4;
				a_6.Height = A_3 - A_2;
				this.m_ai = this.m_ai.o(a_6);
				a();
				A_ = null;
			}
		}
	}

	private void a(int A_0, int A_1, int A_2, int A_3, byte[] A_4, ref int A_5, ref int A_6, ref double A_7, ref double A_8, ref double A_9)
	{
		checked
		{
			int num = 2 * A_0 + 1;
			_ = (A_2 - A_0) * A_1 + A_3 - A_0;
			int num2 = 0;
			int num3 = num * num;
			int[] array = new int[num3 - 1 + 1];
			A_5 = int.MaxValue;
			A_6 = int.MinValue;
			int num4 = A_2 - A_0;
			int num5 = A_2 + A_0;
			for (int num6 = num4; num6 <= num5; num6++)
			{
				int num7 = 3 * num6 * A_1;
				int num8 = A_3 - A_0;
				int num9 = A_3 + A_0;
				for (int num10 = num8; num10 <= num9; num10++)
				{
					int num11 = num7 + 3 * num10;
					array[num2] = A_4[num11] + A_4[num11 + 1] + A_4[num11 + 2];
					if (array[num2] > A_6)
					{
						A_6 = array[num2];
					}
					if (array[num2] < A_5)
					{
						A_5 = array[num2];
					}
					num2++;
				}
			}
			jf.a(array, num3, ref A_7, ref A_8, ref A_9);
		}
	}

	private bool a(int A_0, int A_1, int A_2, int A_3, bool A_4, int A_5, ref int A_6, ref int A_7, byte[] A_8)
	{
		int num = 1;
		int num2 = 1;
		checked
		{
			int a_ = (A_2 - A_0) * A_1 + A_3 - A_0;
			int a_2 = (A_2 - A_0) * A_1 + A_3 + A_0;
			int A_9 = default(int);
			bool flag = a(a_, a_2, A_5, ref A_9, A_4, A_8);
			int A_10 = default(int);
			if (!flag)
			{
				int a_3 = (A_2 + A_0) * A_1 + A_3 - A_0;
				a_2 = (A_2 + A_0) * A_1 + A_3 + A_0;
				flag = a(a_3, a_2, A_5, ref A_9, A_4, A_8);
				if (flag)
				{
					num = -1;
				}
				else
				{
					flag = a((A_2 - A_0) * A_1 + A_3 - A_0, 2 * A_0, A_5, A_1, ref A_10, A_4, A_8);
					if (!flag)
					{
						flag = a((A_2 - A_0) * A_1 + A_3 + A_0, 2 * A_0, A_5, A_1, ref A_10, A_4, A_8);
						if (flag)
						{
							num2 = -1;
						}
					}
				}
			}
			if (flag)
			{
				A_6 = A_2 - A_0 * num + A_10;
				A_7 = A_3 - A_0 * num2 + A_9;
			}
			return flag;
		}
	}

	private void a(int A_0, int A_1, int A_2, int A_3, int A_4, int A_5, bool A_6, int A_7, int A_8, int A_9, ref int A_10, ref int A_11, ref int A_12, ref int A_13, ref bool A_14, byte[] A_15)
	{
		A_14 = false;
		int A_16 = default(int);
		a(A_8, A_9, A_0, A_4, A_5, A_7, A_6: true, ref A_16, ref A_14, A_6, A_15);
		if (A_14)
		{
			return;
		}
		int A_17 = default(int);
		a(A_8, A_9, A_0, A_4, A_5, A_7, A_6: false, ref A_17, ref A_14, A_6, A_15);
		if (A_14)
		{
			return;
		}
		checked
		{
			int a_ = A_16 + unchecked(checked(A_17 - A_16) / 2);
			a(A_8, a_, A_0, A_1, A_2, A_3, A_7, A_7: true, ref A_10, ref A_14, A_6, A_15);
			if (A_14)
			{
				return;
			}
			a(A_8, a_, A_0, A_1, A_2, A_3, A_7, A_7: false, ref A_11, ref A_14, A_6, A_15);
			if (A_14)
			{
				return;
			}
			int a_2 = A_10 + unchecked(checked(A_11 - A_10) / 2);
			a(a_2, a_, A_0, A_4, A_5, A_7, A_6: true, ref A_12, ref A_14, A_6, A_15);
			if (A_14)
			{
				return;
			}
			a(a_2, a_, A_0, A_4, A_5, A_7, A_6: false, ref A_13, ref A_14, A_6, A_15);
			if (!A_14)
			{
				a_ = A_12 + unchecked(checked(A_13 - A_12) / 2);
				a(a_2, a_, A_0, A_1, A_2, A_3, A_7, A_7: true, ref A_10, ref A_14, A_6, A_15);
				if (!A_14)
				{
					a(a_2, a_, A_0, A_1, A_2, A_3, A_7, A_7: false, ref A_11, ref A_14, A_6, A_15);
					_ = A_14;
				}
			}
		}
	}

	private static bool a(int A_0, int A_1, List<Rectangle> A_2)
	{
		foreach (Rectangle item in A_2)
		{
			if (checked(A_0 >= item.X && A_0 <= item.X + item.Width && A_1 >= item.Y && A_1 <= item.Y + item.Height))
			{
				return true;
			}
		}
		return false;
	}

	private static bool a(int A_0, int A_1, int A_2, ref int A_3, bool A_4, byte[] A_5)
	{
		checked
		{
			if (!A_4)
			{
				int num = A_1 - A_0;
				for (int num2 = 0; num2 <= num; num2++)
				{
					int num3 = 3 * (A_0 + num2);
					if (A_5[num3 + 0] + A_5[num3 + 1] + A_5[num3 + 2] > A_2)
					{
						A_3 = num2;
						return true;
					}
				}
			}
			else
			{
				int num4 = A_1 - A_0;
				for (int num2 = 0; num2 <= num4; num2++)
				{
					int num3 = 3 * (A_0 + num2);
					if (A_5[num3 + 0] + A_5[num3 + 1] + A_5[num3 + 2] < A_2)
					{
						A_3 = num2;
						return true;
					}
				}
			}
			return false;
		}
	}

	private static bool a(int A_0, int A_1, int A_2, int A_3, ref int A_4, bool A_5, byte[] A_6)
	{
		checked
		{
			if (!A_5)
			{
				for (int num = 0; num <= A_1; num++)
				{
					int num2 = 3 * (A_0 + num * A_3);
					if (A_6[num2 + 0] + A_6[num2 + 1] + A_6[num2 + 2] > A_2)
					{
						A_4 = num;
						return true;
					}
				}
			}
			else
			{
				for (int num = 0; num <= A_1; num++)
				{
					int num2 = 3 * (A_0 + num * A_3);
					if (A_6[num2 + 0] + A_6[num2 + 1] + A_6[num2 + 2] < A_2)
					{
						A_4 = num;
						return true;
					}
				}
			}
			return false;
		}
	}

	private static void a(int A_0, int A_1, int A_2, int A_3, int A_4, int A_5, bool A_6, ref int A_7, ref bool A_8, bool A_9, byte[] A_10)
	{
		bool flag = false;
		int num = 1;
		checked
		{
			int num2 = A_0 * A_2;
			A_8 = false;
			if (A_6)
			{
				num = -1;
			}
			A_3 += 4;
			A_4 -= 4;
			int num4 = default(int);
			if (!A_9)
			{
				do
				{
					int num3 = A_1 + num4 * num;
					if ((A_6 && num3 < A_3) || (!A_6 && num3 > A_4))
					{
						A_8 = true;
						break;
					}
					int num5 = 3 * (num2 + num3);
					if (A_10[num5 + 0] + A_10[num5 + 1] + A_10[num5 + 2] < A_5)
					{
						flag = true;
						A_7 = num3;
					}
					else
					{
						num4++;
					}
				}
				while (!flag);
				return;
			}
			int num6 = 5 * A_5;
			int[] array = new int[5];
			if (A_6)
			{
				int num7 = 0;
				do
				{
					array[num7] = -num7 * 3;
					num7++;
				}
				while (num7 <= 4);
			}
			else
			{
				int num7 = 0;
				do
				{
					array[num7] = num7 * 3;
					num7++;
				}
				while (num7 <= 4);
			}
			do
			{
				int num3 = A_1 + num4 * num;
				if ((A_6 && num3 < A_3) || (!A_6 && num3 > A_4))
				{
					A_8 = true;
					break;
				}
				int num5 = 3 * (num2 + num3);
				int num8 = 0;
				int num7 = 0;
				do
				{
					num8 += A_10[num5 + array[num7] + 0] + A_10[num5 + array[num7] + 1] + A_10[num5 + array[num7] + 2];
					num7++;
				}
				while (num7 <= 4);
				if (num8 > num6)
				{
					flag = true;
					A_7 = num3;
				}
				else
				{
					num4++;
				}
			}
			while (!flag);
		}
	}

	private static void a(int A_0, int A_1, int A_2, int A_3, int A_4, int A_5, int A_6, bool A_7, ref int A_8, ref bool A_9, bool A_10, byte[] A_11)
	{
		bool flag = false;
		int num = 1;
		A_9 = false;
		if (A_7)
		{
			num = -1;
		}
		checked
		{
			A_4 += 4;
			A_5 -= 4;
			int num3 = default(int);
			if (!A_10)
			{
				do
				{
					int num2 = A_0 + num3 * num;
					if ((A_7 && num2 < A_4) || (!A_7 && num2 > A_5))
					{
						A_9 = true;
						break;
					}
					int num4 = 3 * (num2 * A_2 + A_1);
					if (A_11[num4 + 0] + A_11[num4 + 1] + A_11[num4 + 2] < A_6)
					{
						flag = true;
						A_8 = num2;
					}
					else
					{
						num3++;
					}
				}
				while (!flag);
				return;
			}
			int num5 = 5 * A_6;
			int[] array = new int[5];
			if (A_7)
			{
				int num6 = 0;
				do
				{
					array[num6] = -num6 * A_2 * 3;
					num6++;
				}
				while (num6 <= 4);
			}
			else
			{
				int num6 = 0;
				do
				{
					array[num6] = num6 * A_2 * 3;
					num6++;
				}
				while (num6 <= 4);
			}
			do
			{
				int num2 = A_0 + num3 * num;
				if ((A_7 && num2 < A_4) || (!A_7 && num2 > A_5))
				{
					A_9 = true;
					break;
				}
				int num4 = 3 * (num2 * A_2 + A_1);
				int num7 = 0;
				int num6 = 0;
				do
				{
					num7 += A_11[num4 + array[num6] + 0] + A_11[num4 + array[num6] + 1] + A_11[num4 + array[num6] + 2];
					num6++;
				}
				while (num6 <= 4);
				if (num7 > num5)
				{
					flag = true;
					A_8 = num2;
				}
				else
				{
					num3++;
				}
			}
			while (!flag);
		}
	}

	private static void a(int A_0, int A_1, byte[] A_2, ref int A_3, ref int A_4, ref int A_5, ref int A_6)
	{
		checked
		{
			int num = (int)Math.Round((double)A_1 * 0.25);
			int num2 = (int)Math.Round((double)A_0 * 0.25);
			int num3 = (int)Math.Round((double)A_1 * 0.5);
			int num4 = (int)Math.Round((double)A_0 * 0.5);
			int num5 = (A_0 * num + num2) * 3;
			int[] array = new int[num3 - 1 + 1];
			int[] array2 = new int[num4 - 1 + 1];
			int num6 = num3 - 1;
			for (int num7 = 0; num7 <= num6; num7++)
			{
				int num8 = num7 * A_0 * 3;
				int num9 = (num7 + 4) * A_0 * 3;
				int num10 = 0;
				int num11 = num4 - 1;
				for (int num12 = 0; num12 <= num11; num12++)
				{
					int num13 = 0;
					int num14 = 0;
					do
					{
						int num15 = num5 + num8 + num12 * 3 + 3 * num14;
						num13 += A_2[num15] + A_2[num15 + 1] + A_2[num15 + 2];
						num14++;
					}
					while (num14 <= 12);
					int num16 = 0;
					num14 = 0;
					do
					{
						int num15 = num5 + num9 + num12 * 3 + 3 * num14;
						num16 += A_2[num15] + A_2[num15 + 1] + A_2[num15 + 2];
						num14++;
					}
					while (num14 <= 12);
					int num17 = Math.Abs(num16 - num13);
					if (num17 > num10)
					{
						num10 = num17;
					}
				}
				array[num7] = num10;
			}
			int num18 = num4 - 1;
			for (int num12 = 0; num12 <= num18; num12++)
			{
				int num10 = 0;
				int num19 = num3 - 1;
				for (int num7 = 0; num7 <= num19; num7++)
				{
					int num8 = num7 * A_0 * 3;
					int num9 = num8 + 12;
					int num13 = 0;
					int num14 = 0;
					do
					{
						int num15 = num5 + num8 + num12 * 3 + num14 * A_0 * 3;
						num13 += A_2[num15] + A_2[num15 + 1] + A_2[num15 + 2];
						num14++;
					}
					while (num14 <= 12);
					int num16 = 0;
					num14 = 0;
					do
					{
						int num15 = num5 + num9 + num12 * 3 + num14 * A_0 * 3;
						num16 += A_2[num15] + A_2[num15 + 1] + A_2[num15 + 2];
						num14++;
					}
					while (num14 <= 12);
					int num17 = Math.Abs(num16 - num13);
					if (num17 > num10)
					{
						num10 = num17;
					}
				}
				array2[num12] = num10;
			}
			a(array2, array, ref A_5, ref A_6, ref A_3, ref A_4);
		}
	}

	private static void a(int[] A_0, int[] A_1, ref int A_2, ref int A_3, ref int A_4, ref int A_5)
	{
		checked
		{
			int num = (int)Math.Round((float)a(A_0) * 0.5f);
			int num2 = (int)Math.Round((float)a(A_1) * 0.5f);
			int num3 = A_0.Length - 1;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				if (A_0[num4] > num)
				{
					A_2 = num4 + unchecked(A_0.Length / 2);
					break;
				}
			}
			A_2 += 2;
			for (int num5 = A_0.Length - 1; num5 >= 0; num5 += -1)
			{
				if (A_0[num5] > num)
				{
					A_3 = num5 + unchecked(A_0.Length / 2);
					break;
				}
			}
			A_3 -= 2;
			int num6 = A_1.Length - 1;
			for (int num7 = 0; num7 <= num6; num7++)
			{
				if (A_1[num7] > num2)
				{
					A_4 = num7 + unchecked(A_1.Length / 2);
					break;
				}
			}
			A_4 += 2;
			for (int num8 = A_1.Length - 1; num8 >= 0; num8 += -1)
			{
				if (A_1[num8] > num2)
				{
					A_5 = num8 + unchecked(A_1.Length / 2);
					break;
				}
			}
			A_5 -= 2;
		}
	}

	private static int a(int[] A_0)
	{
		int upperBound = A_0.GetUpperBound(0);
		int num3 = default(int);
		for (int num = 0; num <= upperBound; num = checked(num + 1))
		{
			int num2 = A_0[num];
			if (num2 > num3)
			{
				num3 = num2;
			}
		}
		return num3;
	}

	public static int a(float A_0, int A_1)
	{
		checked
		{
			int num = A_1 - 1;
			return Math.Min(Math.Max((int)Math.Round((float)num * A_0 / 100f), 0), num);
		}
	}

	public int a(byte[][] A_0, Rectangle A_1, double[] A_2)
	{
		checked
		{
			lock (this)
			{
				int a_ = this.m_ai.z();
				int num = this.m_ai.aa();
				int left = A_1.Left;
				int width = A_1.Width;
				int top = A_1.Top;
				int height = A_1.Height;
				int num2 = A_2.Length;
				int num3 = num2 - 1;
				IntPtr[] array = new IntPtr[num3 + 1];
				Collection<GCHandle> collection = new Collection<GCHandle>();
				try
				{
					int num4 = num3;
					for (int num5 = 0; num5 <= num4; num5++)
					{
						GCHandle item = GCHandle.Alloc(A_0[num5], GCHandleType.Pinned);
						collection.Add(item);
						array[num5] = item.AddrOfPinnedObject();
					}
					if (true && this.m_ai.w() != default(Rectangle))
					{
						int a_2 = this.m_ai.w().X - 5;
						int a_3 = num - this.m_ai.w().Y + 5;
						int a_4 = this.m_ai.w().X + this.m_ai.w().Width + 5;
						int a_5 = num - (this.m_ai.w().Y + this.m_ai.w().Height) - 5;
						return global::b1.ImageFocusGoodnessWithExclusionZone(ref array[0], left, width, a_, top, height, num, a_2, a_4, a_5, a_3, num2, ref A_2[0]);
					}
					return global::b1.ImageFocusGoodness(ref array[0], left, width, a_, top, height, num, num2, ref A_2[0]);
				}
				finally
				{
					foreach (GCHandle item2 in collection)
					{
						item2.Free();
					}
				}
			}
		}
	}

	private Bitmap a(Color A_0, int A_1, int A_2, int A_3, int A_4)
	{
		Brush brush = new SolidBrush(global::e.a().MeasureSpotColor);
		Bitmap bitmap = new Bitmap(this.m_ai.z(), this.m_ai.aa(), PixelFormat.Format24bppRgb);
		Graphics graphics = Graphics.FromImage(bitmap);
		graphics.Clear(A_0);
		graphics.FillEllipse(brush, A_1, A_2, A_3, A_4);
		brush.Dispose();
		graphics.Dispose();
		return bitmap;
	}

	private void b(bool A_0)
	{
		Graphics graphics = null;
		IntPtr zero = IntPtr.Zero;
		IntPtr intPtr = default(IntPtr);
		IntPtr hbitmap = default(IntPtr);
		try
		{
			graphics = Graphics.FromImage(n);
			intPtr = CreateCompatibleDC(zero);
			hbitmap = n.GetHbitmap();
			SelectObject(intPtr, hbitmap);
			VMR9AlphaBitmap pBmpParms = new VMR9AlphaBitmap
			{
				dwFlags = (VMR9AlphaBitmapFlags.hDC | VMR9AlphaBitmapFlags.SrcColorKey | VMR9AlphaBitmapFlags.FilterMode),
				hdc = intPtr,
				rSrc = new DsRect(0, 0, n.Size.Width, n.Size.Height),
				rDest = x(),
				clrSrcKey = ColorTranslator.ToWin32(o),
				dwFilterMode = VMRMixerPrefs.PointFiltering
			};
			if (A_0)
			{
				pBmpParms.fAlpha = (float)((double)global::e.a().VideoOpacity / 100.0);
			}
			else
			{
				pBmpParms.fAlpha = 0f;
			}
			m.SetAlphaBitmap(ref pBmpParms);
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_a.c(fz.b.a, ex3.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			DeleteObject(hbitmap);
			DeleteDC(intPtr);
			if (graphics != null && zero != IntPtr.Zero)
			{
				graphics.ReleaseHdc(zero);
				graphics.Dispose();
			}
		}
	}

	private NormalizedRect x()
	{
		NormalizedRect result = default(NormalizedRect);
		DsError.ThrowExceptionForHR(k.GetNativeVideoSize(out var _, out var _, out var _, out var _));
		result.top = 0f;
		result.left = 0f;
		result.bottom = 1f;
		result.right = 1f;
		return result;
	}

	private void w()
	{
		if (z() != null)
		{
			z().Stop();
		}
		g.Stop();
		f.Stop();
		by = 0;
		bz = 0;
		GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
	}

	private void v()
	{
		g.Run();
		z().Start();
	}

	public void s(bool A_0)
	{
		lock (this)
		{
			if (this.m_an)
			{
				this.m_a.c(fz.b.b, "Attempt to StartVideoFromUI when it is already live for UI");
				return;
			}
			this.m_an = true;
			this.m_ai = this.m_ai.o(A_0: true);
			this.m_aq = false;
			if (!this.m_am)
			{
				v();
				k.SetVideoPosition(null, checked(new Rectangle(0, 0, (int)Math.Round((float)this.m_ag * this.m_ac), (int)Math.Round((float)this.m_ah * this.m_ad))));
			}
			this.m_aj = A_0;
			u();
			d5 d10 = new d5();
			d10.a = false;
			this.m_ao?.Invoke(d10);
		}
	}

	public void ar()
	{
		lock (this)
		{
			if (!this.m_an)
			{
				this.m_a.c(fz.b.b, "Attempt to StopVideoFromUI when it is already stopped for UI");
				return;
			}
			this.m_an = false;
			au();
			d5 d10 = new d5();
			d10.a = true;
			d10.b = this.m_ak;
			this.m_ak = null;
			if (this.m_am)
			{
				k.SetVideoPosition(null, new Rectangle(0, 0, 0, 0));
				this.m_ao?.Invoke(d10);
			}
			else
			{
				this.m_ai = this.m_ai.o(A_0: false);
				this.m_ao?.Invoke(d10);
				w();
			}
		}
	}

	public void @as()
	{
		lock (this)
		{
			if (this.m_am)
			{
				this.m_a.c(fz.b.b, "Attempt to StartVideoBackground when it is already running for Background");
				return;
			}
			if (!this.m_an)
			{
				this.m_aq = false;
				this.m_ai = this.m_ai.o(A_0: true);
				v();
			}
			this.m_am = true;
		}
	}

	public void at()
	{
		lock (this)
		{
			if (!this.m_am)
			{
				this.m_a.c(fz.b.b, "Attempt to StopVideoForBackground when it is already stopped for Background");
				return;
			}
			this.m_am = false;
			if (!this.m_an)
			{
				this.m_ai = this.m_ai.o(A_0: false);
				w();
			}
		}
	}

	public void a(int A_0)
	{
		lock (this)
		{
			int milliseconds = bu.AddMilliseconds(A_0).Subtract(DateTime.UtcNow).Milliseconds;
			if (milliseconds > 0)
			{
				Thread.Sleep(milliseconds);
			}
		}
	}

	public void b(bool A_0, int A_1)
	{
		a(A_0, A_1);
		bu = DateTime.UtcNow;
	}

	private void a(bool A_0, int A_1)
	{
		CameraControlFlags flags = (A_0 ? CameraControlFlags.Auto : CameraControlFlags.Manual);
		this.m_w.Set(CameraControlProperty.Exposure, A_1, flags);
	}

	private void a(ref int A_0, ref int A_1, ref int A_2)
	{
		this.m_w.GetRange(CameraControlProperty.Exposure, out A_0, out A_1, out A_2, out var _, out var _);
	}

	public void a(ref bool A_0, ref int A_1)
	{
		this.m_w.Get(CameraControlProperty.Exposure, out A_1, out var Flags);
		A_0 = Flags == CameraControlFlags.Auto;
	}

	public void b(int A_0)
	{
		lock (this)
		{
			this.m_w.Set(CameraControlProperty.Focus, A_0, CameraControlFlags.Manual);
			this.m_ai = this.m_ai.q(A_0);
		}
	}

	public void a(int A_0, float A_1, float A_2)
	{
		checked
		{
			lock (this)
			{
				if (k != null)
				{
					a a10 = this.m_ai;
					a10 = a10.o(A_0);
					a10 = a10.o(A_1);
					this.m_ai = a10.q(A_2);
					float num = ej.a(this.m_ai.s());
					int num2 = (int)Math.Round((double)((float)(this.m_ai.aa() - 1) * num * A_2) - 0.5 * (double)this.m_ah);
					int num3 = (int)Math.Round((double)((float)(this.m_ai.z() - 1) * num * A_1) - 0.5 * (double)this.m_ag);
					if (num3 < 0)
					{
						num3 = 0;
					}
					if (num2 < 0)
					{
						num2 = 0;
					}
					k.SetVideoPosition(null, new Rectangle(-num3, -num2, (int)Math.Round((float)this.m_ai.z() * num), (int)Math.Round((float)this.m_ai.aa() * num)));
					this.m_ao?.Invoke(new d5());
				}
			}
		}
	}

	public void a(float A_0, float A_1, ScrollOrientation A_2)
	{
		checked
		{
			lock (this)
			{
				if (k == null)
				{
					return;
				}
				float num = ej.a(ab().s());
				int num2 = (int)Math.Round((double)((float)(this.m_ai.aa() - 1) * num * A_1) - 0.5 * (double)this.m_ah);
				int num3 = (int)Math.Round((double)((float)(this.m_ai.z() - 1) * num * A_0) - 0.5 * (double)this.m_ag);
				if (num3 < 0)
				{
					num3 = 0;
				}
				if (num2 < 0)
				{
					num2 = 0;
				}
				if (A_2 == ScrollOrientation.HorizontalScroll)
				{
					if (this.m_ad == 1f)
					{
						k.SetVideoPosition(null, new Rectangle(-num3, (int)Math.Round((float)(-num2) - (float)this.m_af * num), (int)Math.Round((float)this.m_ai.z() * num), (int)Math.Round((float)this.m_ai.aa() * num)));
					}
					else
					{
						k.SetVideoPosition(null, new Rectangle(-num3, -num2, (int)Math.Round((float)this.m_ai.z() * num), (int)Math.Round((float)this.m_ai.aa() * num)));
					}
				}
				else if (this.m_ac == 1f)
				{
					k.SetVideoPosition(null, new Rectangle(-num3, (int)Math.Round((float)(-num2) - (float)this.m_ae * num), (int)Math.Round((float)this.m_ai.z() * num), (int)Math.Round((float)this.m_ai.aa() * num)));
				}
				else
				{
					k.SetVideoPosition(null, new Rectangle(-num3, -num2, (int)Math.Round((float)this.m_ai.z() * num), (int)Math.Round((float)this.m_ai.aa() * num)));
				}
				a a10 = this.m_ai;
				a10 = a10.o(A_0);
				this.m_ai = a10.q(A_1);
			}
		}
	}

	public void au()
	{
		byte[] A_ = null;
		a(ref A_, A_1: false);
	}

	public void a(ref byte[] A_0, bool A_1)
	{
		checked
		{
			lock (this)
			{
				while (b2)
				{
					Thread.Sleep(100);
				}
				int num = 50;
				GCHandle gCHandle = default(GCHandle);
				bool flag2 = default(bool);
				try
				{
					if (A_1 || !this.m_aq)
					{
						try
						{
							if (A_1)
							{
								num = 2;
								this.m_aq = false;
							}
							int num2;
							bool flag;
							int num3 = default(int);
							do
							{
								i.SetCallback(this, 0);
								num2 = 0;
								flag = false;
								while (!this.m_aq && num2 < 5000)
								{
									Thread.Sleep(num);
									num2 += num;
								}
								if (!this.m_aq)
								{
									num3++;
									i.SetCallback(null, 0);
									w();
									v();
								}
								else
								{
									flag = true;
								}
							}
							while (num3 < 2 && !flag);
							if (!flag)
							{
								if (this.m_ak != null)
								{
									this.m_ak.Dispose();
								}
								this.m_ak = null;
								this.m_a.c(fz.b.a, "Timeout attempting to grab image. We waited " + num2 + " ms, but this exceeded the timeout time of " + Conversions.ToString(5000) + " ms");
							}
						}
						finally
						{
							i.SetCallback(null, 0);
							GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
						}
					}
					int pBufferSize = default(int);
					i.GetCurrentBuffer(ref pBufferSize, IntPtr.Zero);
					int stride = this.m_ai.z() * 3;
					if (A_0 == null)
					{
						gCHandle = GCHandle.Alloc(new byte[pBufferSize - 1 + 1], GCHandleType.Pinned);
					}
					else
					{
						A_0 = new byte[pBufferSize - 1 + 1];
						gCHandle = GCHandle.Alloc(A_0, GCHandleType.Pinned);
					}
					flag2 = true;
					int value = (int)gCHandle.AddrOfPinnedObject();
					IntPtr intPtr = new IntPtr(value);
					i.GetCurrentBuffer(ref pBufferSize, intPtr);
					if (A_0 != null)
					{
						return;
					}
					BitmapData bitmapData = null;
					int height = this.m_ai.aa();
					int width = this.m_ai.z();
					Rectangle rect = new Rectangle(0, 0, width, height);
					Bitmap bitmap = new Bitmap(width, height, stride, PixelFormat.Format24bppRgb, intPtr);
					int num4;
					byte[] array;
					try
					{
						bitmapData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, bitmap.PixelFormat);
						num4 = Math.Abs(bitmapData.Stride) * bitmapData.Height;
						array = new byte[num4 - 1 + 1];
						Marshal.Copy(bitmapData.Scan0, array, 0, num4);
					}
					finally
					{
						if (bitmapData != null)
						{
							bitmap.UnlockBits(bitmapData);
						}
					}
					BitmapData bitmapData2 = null;
					Bitmap bitmap2 = null;
					try
					{
						bitmap2 = new Bitmap(width, height, bitmapData.PixelFormat);
						bitmapData2 = bitmap2.LockBits(rect, ImageLockMode.WriteOnly, bitmap2.PixelFormat);
						Marshal.Copy(array, 0, bitmapData2.Scan0, num4);
					}
					finally
					{
						if (bitmapData2 != null)
						{
							bitmap2.UnlockBits(bitmapData2);
						}
					}
					bitmap2.RotateFlip(RotateFlipType.Rotate180FlipX);
					if (this.m_ak != null)
					{
						this.m_ak.Dispose();
					}
					this.m_ak = bitmap2;
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex3 = ex2;
					this.m_a.c(fz.b.a, ex3.ToString());
					ProjectData.ClearProjectError();
				}
				finally
				{
					if (flag2)
					{
						gCHandle.Free();
					}
				}
			}
		}
	}

	public void av()
	{
		lock (this)
		{
			au();
			u();
		}
	}

	private void u()
	{
		Color color = global::e.a().MeasureSpotColor;
		o = checked(Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B));
		if (this.m_aj)
		{
			Rectangle rectangle = this.m_ai.w();
			n = a(o, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
			b(A_0: true);
		}
		else if (n != null)
		{
			b(A_0: false);
		}
	}

	private void t()
	{
		float num = (float)((double)this.m_ah / (double)this.m_ai.aa());
		checked
		{
			float num2;
			if ((int)Math.Round(num * (float)this.m_ai.z()) == this.m_ag)
			{
				num = 1f;
				num2 = 1f;
				this.m_ae = 0;
				this.m_af = 0;
			}
			else if ((int)Math.Round(num * (float)this.m_ai.z()) < this.m_ag)
			{
				num2 = 1f;
				num = (float)this.m_ag / num / (float)this.m_ai.z();
				this.m_ae = 0;
				this.m_af = (int)Math.Round((float)this.m_ah * (num - 1f) / 2f);
			}
			else
			{
				num = 1f;
				num2 = (float)((double)(this.m_ah * this.m_ai.z()) / (double)this.m_ag / (double)this.m_ai.aa());
				this.m_ae = (int)Math.Round((float)this.m_ag * Math.Abs(num2 - 1f) / 2f);
				this.m_af = 0;
			}
			this.m_ac = num2;
			this.m_ad = num;
		}
	}

	public Bitmap aw()
	{
		lock (this)
		{
			if (!this.m_an)
			{
				s();
			}
			Bitmap result = this.m_ak;
			this.m_ak = null;
			return result;
		}
	}

	private void s()
	{
		int num = 1;
		while (r())
		{
			Thread.Sleep(100);
			av();
			num = checked(num + 1);
			if (num > 4)
			{
				break;
			}
		}
	}

	private bool r()
	{
		int num = this.m_ak.Width / 4;
		int num2 = this.m_ak.Height / 4;
		long num3 = 0L;
		checked
		{
			int num4 = this.m_ak.Width - 1;
			for (int num5 = 0; num5 <= num4; num5 += 4)
			{
				int num6 = this.m_ak.Height - 1;
				for (int num7 = 0; num7 <= num6; num7 += 4)
				{
					Color pixel = this.m_ak.GetPixel(num5, num7);
					num3 += pixel.R;
					num3 += pixel.G;
					num3 += pixel.B;
					pixel = default(Color);
				}
			}
			if ((double)num3 / ((double)(num * num2) * 3.0 * 255.0) > 0.699999988079071)
			{
				return true;
			}
			return false;
		}
	}

	public static string b()
	{
		return i3.o() + "\\CameraData\\";
	}

	private static string r(string A_0)
	{
		return "Cam_" + b(A_0) + ".fibcd";
	}

	private static string b(string A_0)
	{
		if (Operators.CompareString(A_0, string.Empty, TextCompare: false) == 0)
		{
			return string.Empty;
		}
		checked
		{
			string text = A_0.Substring(A_0.IndexOf("&") + 1);
			text = text.Substring(text.IndexOf("&") + 1);
			text = text.Substring(text.IndexOf("&") + 1);
			return text.Substring(0, text.IndexOf("&"));
		}
	}

	private static string a(string A_0)
	{
		return "Camera (S/N " + b(A_0) + ")";
	}

	private void a()
	{
		BinaryWriter binaryWriter = null;
		try
		{
			if (!Directory.Exists(b()))
			{
				Directory.CreateDirectory(b());
			}
			if (!string.IsNullOrEmpty(this.m_y) && !string.IsNullOrEmpty(this.m_z))
			{
				string path = b() + this.m_z;
				binaryWriter = new BinaryWriter(File.Open(path, FileMode.Create));
				binaryWriter.Write(3);
				binaryWriter.Write(1);
				binaryWriter.Write(this.m_ai.w().X);
				binaryWriter.Write(this.m_ai.w().Y);
				binaryWriter.Write(this.m_ai.w().Width);
				binaryWriter.Write(this.m_ai.w().Height);
				binaryWriter.Write(this.m_ai.s());
				binaryWriter.Write(this.m_ai.r());
				binaryWriter.Write(this.m_ai.u());
				binaryWriter.Write(this.m_ai.v());
				binaryWriter.Write((int)this.m_ai.q());
				binaryWriter.Write((int)this.m_ai.ab());
				binaryWriter.Write(this.m_ai.x().X);
				binaryWriter.Write(this.m_ai.x().Y);
				binaryWriter.Write(this.m_ai.x().Width);
				binaryWriter.Write(this.m_ai.x().Height);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_ = ex2;
			this.m_a.c(fz.b.b, "Exception in FICameraStage.WriteCamSettingsFile", a_);
			ProjectData.ClearProjectError();
		}
		finally
		{
			binaryWriter?.Close();
		}
	}

	private void a(ej.b A_0, bool A_1)
	{
		BinaryReader binaryReader = null;
		int num = 0;
		e e10 = a(A_0);
		try
		{
			string text = b() + this.m_z;
			bool flag = default(bool);
			if (File.Exists(text))
			{
				flag = true;
			}
			else
			{
				string text2 = i3.o() + "\\Optics\\Cam_default.fibcd";
				if (File.Exists(text2))
				{
					string directoryName = Path.GetDirectoryName(text);
					if (!Directory.Exists(directoryName))
					{
						Directory.CreateDirectory(directoryName);
					}
					File.Copy(text2, text);
					flag = true;
				}
			}
			if (flag)
			{
				binaryReader = new BinaryReader(File.Open(text, FileMode.Open, FileAccess.Read, FileShare.Read));
				num = binaryReader.ReadInt32();
				if (binaryReader.ReadInt32() > 3)
				{
					a(A_0, e10);
					return;
				}
				Rectangle a_ = default(Rectangle);
				a_.X = binaryReader.ReadInt32();
				a_.Y = binaryReader.ReadInt32();
				a_.Width = binaryReader.ReadInt32();
				a_.Height = binaryReader.ReadInt32();
				int num2 = binaryReader.ReadInt32();
				if (num2 < ej.b())
				{
					num2 = ej.b();
				}
				else if (num2 > ej.a())
				{
					num2 = ej.a();
				}
				this.m_ai = this.m_ai.o(num2);
				this.m_ai = this.m_ai.q(binaryReader.ReadInt32());
				this.m_ai = this.m_ai.o(binaryReader.ReadSingle());
				this.m_ai = this.m_ai.q(binaryReader.ReadSingle());
				ej.b b10 = (ej.b)binaryReader.ReadInt32();
				this.m_ai = this.m_ai.o(b10);
				this.m_ai = this.m_ai.o(a_, b10);
				if (num >= 2)
				{
					this.m_ai = this.m_ai.o((e)binaryReader.ReadInt32());
				}
				else
				{
					this.m_ai = this.m_ai.o(e10);
				}
				if (num >= 3)
				{
					ej.b a_2 = ((b10 == ej.b.a) ? ej.b.b : ej.b.a);
					Rectangle a_3 = default(Rectangle);
					a_3.X = binaryReader.ReadInt32();
					a_3.Y = binaryReader.ReadInt32();
					a_3.Width = binaryReader.ReadInt32();
					a_3.Height = binaryReader.ReadInt32();
					this.m_ai = this.m_ai.o(a_3, a_2);
				}
				if (A_1)
				{
					this.m_ai = this.m_ai.o(A_0);
				}
			}
			else
			{
				a(A_0, e10);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception a_4 = ex2;
			this.m_a.c(fz.b.b, "Exception in FICameraStage.ReadCamSettingsFile", a_4);
			a(A_0, e10);
			ProjectData.ClearProjectError();
		}
		finally
		{
			binaryReader?.Close();
		}
	}

	private void a(ej.b A_0, e A_1)
	{
		this.m_ai = this.m_ai.o(1);
		this.m_ai = this.m_ai.o(A_0);
		this.m_ai = this.m_ai.o(A_1);
	}

	private static DsDevice a(DsDevice[] A_0, string A_1)
	{
		if (string.IsNullOrEmpty(A_1))
		{
			return A_0[0];
		}
		if (Operators.CompareString(A_1, "None", TextCompare: false) == 0)
		{
			return null;
		}
		string right = string.Empty;
		if (A_1.Contains("Camera (S/N "))
		{
			right = A_1.Substring("Camera (S/N ".Length, checked(A_1.Length - "Camera (S/N ".Length - 1));
		}
		if (A_0.Length > 0)
		{
			foreach (DsDevice dsDevice in A_0)
			{
				if (Operators.CompareString(b(dsDevice.DevicePath), right, TextCompare: false) == 0)
				{
					return dsDevice;
				}
			}
			return null;
		}
		return null;
	}

	public void ax()
	{
		lock (this)
		{
			if (g != null)
			{
				w();
			}
			if (h != null)
			{
				Marshal.ReleaseComObject(h);
				h = null;
				k = null;
				this.m_aa = null;
				m = null;
			}
			if (i != null)
			{
				Marshal.ReleaseComObject(i);
				i = null;
				j = null;
			}
			if (f != null)
			{
				int num = this.m_e.RemoveFilter(f);
				if (num < 0)
				{
					Marshal.ThrowExceptionForHR(num);
				}
				Marshal.ReleaseComObject(f);
				f = null;
				this.m_w = null;
			}
			if (bq != null)
			{
				bq.Stop();
				int num = this.m_e.RemoveFilter(bq);
				if (num < 0)
				{
					Marshal.ThrowExceptionForHR(num);
				}
				Marshal.ReleaseComObject(bq);
				bq = null;
			}
			if (this.m_e != null)
			{
				Marshal.ReleaseComObject(this.m_e);
				g = null;
				this.m_e = null;
			}
			if (l != null)
			{
				Marshal.ReleaseComObject(this.m_ap);
				this.m_ap = null;
				Marshal.ReleaseComObject(l);
				l = null;
			}
		}
	}

	private e a(ej.b A_0)
	{
		switch (A_0)
		{
		case ej.b.b:
			return d4.e.c;
		case ej.b.a:
			if (a1)
			{
				return d4.e.d;
			}
			return d4.e.b;
		default:
		{
			e result = default(e);
			return result;
		}
		}
	}

	private void a(e A_0)
	{
		a a10 = this.m_ai;
		checked
		{
			int num = a10.aa() - a10.w().Y - a10.w().Height;
			int num2 = a10.w().X;
			int num3 = a10.w().Y;
			int num4 = a10.z() - a10.w().X - a10.w().Width;
			if (a10.ab() == d4.e.a)
			{
				switch (A_0)
				{
				case d4.e.b:
					this.m_ai = a10.o(new Rectangle(num, num2, a10.w().Height, a10.w().Width));
					break;
				case d4.e.c:
					this.m_ai = a10.o(new Rectangle(num3, num4, a10.w().Height, a10.w().Width));
					break;
				case d4.e.d:
					this.m_ai = a10.o(new Rectangle(num4, num, a10.w().Width, a10.w().Height));
					break;
				}
			}
			else if (a10.ab() == d4.e.b)
			{
				switch (A_0)
				{
				case d4.e.a:
					this.m_ai = a10.o(new Rectangle(num3, num4, a10.w().Height, a10.w().Width));
					break;
				case d4.e.c:
					this.m_ai = a10.o(new Rectangle(num4, num, a10.w().Width, a10.w().Height));
					break;
				case d4.e.d:
					this.m_ai = a10.o(new Rectangle(num, num2, a10.w().Height, a10.w().Width));
					break;
				}
			}
			else if (a10.ab() == d4.e.c)
			{
				switch (A_0)
				{
				case d4.e.a:
					this.m_ai = a10.o(new Rectangle(num, num2, a10.w().Height, a10.w().Width));
					break;
				case d4.e.b:
					this.m_ai = a10.o(new Rectangle(num4, num, a10.w().Width, a10.w().Height));
					break;
				case d4.e.d:
					this.m_ai = a10.o(new Rectangle(num3, num4, a10.w().Height, a10.w().Width));
					break;
				}
			}
			else if (a10.ab() == d4.e.d)
			{
				switch (A_0)
				{
				case d4.e.a:
					this.m_ai = a10.o(new Rectangle(num4, num, a10.w().Width, a10.w().Height));
					break;
				case d4.e.b:
					this.m_ai = a10.o(new Rectangle(num3, num4, a10.w().Height, a10.w().Width));
					break;
				case d4.e.c:
					this.m_ai = a10.o(new Rectangle(num, num2, a10.w().Height, a10.w().Width));
					break;
				}
			}
			a10 = null;
		}
	}

	public void a(r.d A_0, e A_1, r.d.a.b A_2)
	{
		lock (this)
		{
			if (this.m_ai.ab() != A_1)
			{
				a(A_1);
				this.m_ai = this.m_ai.o(A_1);
			}
			a();
			a(A_0, A_2);
		}
	}

	public bool ay()
	{
		if (g == null)
		{
			return false;
		}
		FilterState pfs;
		if (al() || ak())
		{
			Thread.Sleep(400);
			g.GetState(100, out pfs);
			if (pfs == FilterState.Running)
			{
				return true;
			}
			return false;
		}
		bool result = default(bool);
		try
		{
			@as();
			Thread.Sleep(800);
			g.GetState(100, out pfs);
			if (pfs == FilterState.Running)
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Exception ex3 = ex2;
			this.m_a.c(fz.b.b, "Error in CanRunLiveVideo. ", ex3.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			at();
		}
		return result;
	}

	public void a(r.d A_0, r.d.a.b A_1)
	{
		ax();
		a(bs, A_0, this.m_ai.q(), this.m_y, A_4: true, A_5: true, A_6: true, A_7: false, A_8: true, A_1);
	}

	public void az()
	{
		lock (this)
		{
			d4.b.a(this.m_y);
			ax();
		}
	}

	public void a0()
	{
		lock (this)
		{
			a(A_0: true);
			GC.SuppressFinalize(this);
		}
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in a0
		this.a0();
	}

	private void a(bool A_0)
	{
		if (this.m_al)
		{
			return;
		}
		if (A_0)
		{
			if (z() != null)
			{
				z().Stop();
				z().Dispose();
				a((System.Timers.Timer)null);
			}
			if (aa() != null)
			{
				aa().Stop();
				aa().Dispose();
				b((System.Timers.Timer)null);
			}
		}
		ax();
		if (!global::s.a)
		{
			a();
		}
		this.m_al = true;
	}

	~d4()
	{
		a(A_0: false);
		base.Finalize();
	}
}
