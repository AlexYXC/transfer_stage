using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using FIUsbIntLib;
using Microsoft.VisualBasic.CompilerServices;

namespace Filmetrics;

public sealed class FIRemote : IDisposable
{
	public sealed class FIMeasResultParam
	{
		public float mValue;

		public bool mCorrelationOn;

		public float Value => mValue;

		public bool CorrelationOn => mCorrelationOn;

		public FIMeasResultParam(float theValue, bool theCorrOn)
		{
			mValue = theValue;
			mCorrelationOn = theCorrOn;
		}
	}

	public sealed class FIMeasResults
	{
		public enum AcqSpectrumType
		{
			ReflectanceRaw = 1,
			ReflectanceMeas,
			TransmittanceRaw,
			TransmittanceMeas,
			CTMSignalRaw,
			CTMSignalMeas
		}

		public enum CalcDataType
		{
			Reflectance,
			Transmittance,
			FFT
		}

		public sealed class ColorResults
		{
			public enum CoordinateType
			{
				Lab,
				Luv,
				LCH,
				XYZ
			}

			public enum IlluminantType
			{
				D65
			}

			public enum ObserverType
			{
				TwoDegree,
				TenDegree
			}

			private CoordinateType m_a;

			private IlluminantType b;

			private ObserverType c;

			private float d;

			private float e;

			private float f;

			private bool g;

			public CoordinateType Coordinate => this.m_a;

			public IlluminantType Illuminant => b;

			public ObserverType Angle => c;

			public float Coord1 => d;

			public float Coord2 => e;

			public float Coord3 => f;

			public bool CorrelationOn => g;

			internal void a(a4.a A_0, a4.c A_1, a4.b A_2, float A_3, float A_4, float A_5, bool A_6)
			{
				this.m_a = a(A_0);
				b = a(A_1);
				c = a(A_2);
				d = A_3;
				e = A_4;
				f = A_5;
				g = A_6;
			}

			private static CoordinateType a(a4.a A_0)
			{
				return A_0 switch
				{
					global::a4.a.a => CoordinateType.Lab, 
					global::a4.a.c => CoordinateType.LCH, 
					global::a4.a.b => CoordinateType.Luv, 
					global::a4.a.d => CoordinateType.XYZ, 
					_ => throw new ArgumentException("Unknown color coordinate type", "theType"), 
				};
			}

			internal static string[] a(CoordinateType A_0)
			{
				return A_0 switch
				{
					CoordinateType.Lab => new string[3] { "L", "a", "b" }, 
					CoordinateType.LCH => new string[3] { "L", "C", "H" }, 
					CoordinateType.Luv => new string[3] { "L", "u", "v" }, 
					CoordinateType.XYZ => new string[3] { "X", "Y", "Z" }, 
					_ => throw new ArgumentException("Unknown color coordinate type", "theType"), 
				};
			}

			private static IlluminantType a(a4.c A_0)
			{
				if (A_0 == global::a4.c.a)
				{
					return IlluminantType.D65;
				}
				throw new ArgumentException("Unknown illuminant type", "theType");
			}

			private static ObserverType a(a4.b A_0)
			{
				return A_0 switch
				{
					global::a4.b.a => ObserverType.TwoDegree, 
					global::a4.b.b => ObserverType.TenDegree, 
					_ => throw new ArgumentException("Unknown observer type", "theType"), 
				};
			}
		}

		private float[] a;

		private float[] b;

		private AcqSpectrumType c;

		private Image d;

		private float[] e;

		private float[] f;

		private bool g;

		private float[] h;

		private float[] i;

		private CalcDataType j;

		private float[] k;

		private float[] l;

		private string m;

		private float n;

		private bool o;

		private bool p;

		private List<ColorResults> q;

		private float[] r;

		private float[] s;

		private float[] t;

		private float[] u;

		private FIMeasResultParam v;

		private FIMeasResultParam w;

		private FIMeasResultParam x;

		private FIMeasResultParam y;

		private FIMeasResultParam z;

		private DateTime aa;

		public float[] PrimaryWavelengths => a;

		public float[] PrimarySpectrum => b;

		public float[] PrimaryCalcWavelengths => h;

		public float[] PrimaryCalcSpectrum => i;

		public List<ColorResults> PrimaryColorResults => q;

		public AcqSpectrumType MeasPrimaryType => c;

		public float[] MeasFFTThickness => e;

		public float[] MeasFFTIntensity => f;

		public float[] LayerRoughnesses => l;

		public float[] LayerThicknesses => k;

		public float GOF => n;

		public float[] CTMPeakPositions => u;

		public DateTime MeasureTime => aa;

		public string ResultsSummary => m;

		public bool AlarmTriggered => o;

		public bool GofIsOK => p;

		public Image SampleImage => d;

		public float[] SpectrumAnalysisMeanValues => r;

		public float[] SpectrumAnalysisExtremaWavelengthes => s;

		public float[] SpectrumAnalysisExtremaValues => t;

		public FIMeasResultParam SolarUVA => v;

		public FIMeasResultParam SolarUVB => w;

		public FIMeasResultParam SolarUVAB => x;

		public FIMeasResultParam LuminousReflectance => y;

		public FIMeasResultParam YID1925 => z;

		internal FIMeasResults(float[] A_0, float[] A_1, AcqSpectrumType A_2, Image A_3, float[] A_4, float[] A_5, float[] A_6, float A_7, string A_8, List<ColorResults> A_9)
			: this(A_0, A_1, A_2, A_3, A_8, A_9)
		{
			e = A_4;
			f = A_5;
			k = A_6;
			n = A_7;
		}

		internal FIMeasResults(float[] A_0, float[] A_1, AcqSpectrumType A_2, Image A_3, string A_4, List<ColorResults> A_5)
		{
			q = new List<ColorResults>();
			d = A_3;
			a = A_0;
			b = A_1;
			c = A_2;
			m = A_4;
			q = A_5;
		}

		internal FIMeasResults(float[] A_0, float[] A_1, AcqSpectrumType A_2, Image A_3, string A_4, List<ColorResults> A_5, float[] A_6, cc.a[] A_7, FIMeasResultParam A_8, FIMeasResultParam A_9, FIMeasResultParam A_10, FIMeasResultParam A_11, FIMeasResultParam A_12)
			: this(A_0, A_1, A_2, A_3, A_4, A_5)
		{
			r = A_6;
			checked
			{
				s = new float[A_7.Length - 1 + 1];
				t = new float[A_7.Length - 1 + 1];
				int num = t.Length - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					ref cc.a reference = ref A_7[num2];
					s[num2] = reference.a;
					t[num2] = reference.b;
				}
				v = A_8;
				w = A_9;
				x = A_10;
				y = A_11;
				z = A_12;
			}
		}

		internal FIMeasResults(float[] A_0, float[] A_1, AcqSpectrumType A_2, Image A_3, float[] A_4, float A_5, float[] A_6, float[] A_7, float[] A_8, string A_9, bool A_10, bool A_11, List<ColorResults> A_12, float[] A_13, DateTime A_14)
			: this(A_0, A_1, A_2, A_3, A_9, A_12)
		{
			h = A_6;
			i = A_7;
			k = A_4;
			l = A_8;
			n = A_5;
			p = A_10;
			o = A_11;
			u = A_13;
			aa = A_14;
		}
	}

	public sealed class FIMeasResultValuesOnly
	{
		private float a;

		private int[] b;

		private string[] c;

		private Collection<float[]> d;

		private string e;

		public float ElapsedTime => a;

		public string[] ParamDescriptions => c;

		public int[] ParamIDs => b;

		public Collection<float[]> ParamValues => d;

		public string EventOrErrorMsg => e;

		public FIMeasResultValuesOnly(float elapsedTime, int[] paramIDs, string[] paramDescrips, Collection<float[]> paramValues, string eventOrErrorMsg)
		{
			a = elapsedTime;
			b = paramIDs;
			c = paramDescrips;
			d = paramValues;
			e = eventOrErrorMsg;
		}

		public string GetResultsSummary(bool formatAsRtf)
		{
			string text;
			string text3;
			string text4;
			string text5;
			if (formatAsRtf)
			{
				text = "{\\rtf1\\ansi\\deff0{\\fonttbl{\\f0\\fswiss MS Sans Serif;}{\\f1\\froman\\fcharset2 Symbol;}{\\f2\\froman Times New Roman;}{\\f3\\farial Arial;}}{\\colortbl ;\\red255\\green0\\blue0; \\red0\\green0\\blue255;}";
				string text2 = "\\plain\\tx500\\tx2000\\tx3500\\f3\\fs20 ";
				text += text2;
				text3 = "\\par ";
				text4 = "\\tab ";
				text5 = "}";
			}
			else
			{
				text = "";
				string text2 = "";
				text3 = "\r\n";
				text4 = "\t";
				text5 = "";
			}
			checked
			{
				int num = c.Length - 1;
				int num2 = d.Count - 1;
				string text6 = "Ch #";
				int num3 = num;
				for (int num4 = 0; num4 <= num3; num4++)
				{
					text6 = text6 + text4 + c[num4];
				}
				text6 += text3;
				int num5 = num2;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					text6 += num6 + 1;
					int num7 = num;
					for (int num8 = 0; num8 <= num7; num8++)
					{
						text6 = text6 + text4 + d[num6][num8];
					}
					if (num6 != num2)
					{
						text6 += text3;
					}
				}
				return text + text6 + text5;
			}
		}
	}

	public sealed class FISpecDiagnosticsInfo
	{
		public double IntegrationTime_ms;

		public double IntegrationTimeSample_ms;

		public int NumberOfCyclesToAverage;

		public float PeakRawBackground;

		public float PeakRawBackgroundWave;

		public float[] PeakRawReference;

		public float[] PeakRawReferenceWave;

		public float PeakRawTransCurvedR;

		public float PeakRawTransCurvedRWave;

		public float PeakRawSample;

		public float PeakRawSampleWave;

		public string ReferenceMaterial;

		public bool HasDetectorTemperatureSensor;

		public float DetectorTemperature;

		public bool HasSpectrometerTemperatureSensor;

		public float SpectrometerTemperature;
	}

	public sealed class FIRecipeInfo
	{
		public string Name;

		public string FullPath;

		public int FilmStackNumLayers;

		public List<string> FilmStackLayerMats;

		public List<float> FilmStackLayerThicknesses_nm;

		public bool TypeIsSpectrumAnalysis;

		public FIRecipeInfo()
		{
			FilmStackLayerMats = new List<string>();
			FilmStackLayerThicknesses_nm = new List<float>();
		}

		public override string ToString()
		{
			float num = default(float);
			num.ToString(CultureInfo.CurrentCulture);
			return ToString(CultureInfo.CurrentCulture);
		}

		public string ToString(IFormatProvider provider)
		{
			string text = "Name=" + Name + "\r\n";
			text = text + "FullPath=" + FullPath + "\r\n";
			text = text + "TypeIsSpectrumAnalysis=" + Conversions.ToString(TypeIsSpectrumAnalysis) + "\r\n";
			checked
			{
				if (!TypeIsSpectrumAnalysis)
				{
					text = text + "FilmStackNumLayers=" + FilmStackNumLayers + "\r\n";
					int num = FilmStackNumLayers - 1;
					for (int num2 = 0; num2 <= num; num2++)
					{
						text = text + "FilmStackLayerMats(" + num2 + ")=" + FilmStackLayerMats[num2].ToString() + "\r\n";
						text = text + "FilmStackLayerThicknesses_nm(" + num2 + ")=" + FilmStackLayerThicknesses_nm[num2].ToString(provider) + "\r\n";
					}
				}
				return text;
			}
		}
	}

	public sealed class AcquisitionException : ApplicationException
	{
		public enum ExceptionType
		{
			Saturation,
			InvalidAcquisitionSettings,
			Unknown
		}

		private ExceptionType a;

		public ExceptionType Type => a;

		public AcquisitionException(string message, ExceptionType type)
			: base(message)
		{
			a = type;
		}
	}

	public sealed class AmbiguousMeasModuleException : ApplicationException
	{
		public AmbiguousMeasModuleException(string message)
			: base(message)
		{
		}
	}

	public sealed class ArgumentException : ApplicationException
	{
		private string a;

		public string ParamName => a;

		public ArgumentException(string message, string theParamName)
			: base(message)
		{
			a = theParamName;
		}
	}

	public sealed class IllegalCommandException : ApplicationException
	{
		public IllegalCommandException(string message)
			: base(message)
		{
		}
	}

	public sealed class InitializationFailureException : ApplicationException
	{
		public InitializationFailureException(string message)
			: base(message)
		{
		}
	}

	public sealed class InitializationNotCompletedException : ApplicationException
	{
		public InitializationNotCompletedException(string message)
			: base(message)
		{
		}
	}

	public sealed class InvalidBackgroundException : ApplicationException
	{
		public InvalidBackgroundException(string message)
			: base(message)
		{
		}
	}

	public sealed class NoHardwareException : ApplicationException
	{
		public NoHardwareException(string message)
			: base(message)
		{
		}
	}

	public sealed class NonFatalWarningException : ApplicationException
	{
		public NonFatalWarningException(string message)
			: base(message)
		{
		}
	}

	public sealed class IncompatibleHardwareException : ApplicationException
	{
		public IncompatibleHardwareException(string message)
			: base(message)
		{
		}
	}

	public sealed class OperationFailedException : ApplicationException
	{
		public OperationFailedException(string message)
			: base(message)
		{
		}
	}

	public sealed class SetupFailureException : ApplicationException
	{
		public SetupFailureException(string message)
			: base(message)
		{
		}
	}

	public sealed class SpectrumAnalysisException : ApplicationException
	{
		public SpectrumAnalysisException(string message)
			: base(message)
		{
		}
	}

	public sealed class TaskAttemptFailureException : ApplicationException
	{
		public TaskAttemptFailureException(string message)
			: base(message)
		{
		}
	}

	public sealed class TimeOutException : ApplicationException
	{
		private int a;

		public int TimeElapsed_ms => a;

		public TimeOutException(string message, int timeElapsed_ms)
			: base(message)
		{
			a = timeElapsed_ms;
		}
	}

	public sealed class FileNotFoundException : ApplicationException
	{
		public FileNotFoundException(string message)
			: base(message)
		{
		}
	}

	public sealed class FileWriteFailure : ApplicationException
	{
		public FileWriteFailure(string message)
			: base(message)
		{
		}
	}

	public enum OpticsConfigSystemTypes
	{
		ReflectanceAndTransmittanceAutoBaseline = -2,
		ReflectanceAndTransmittance,
		ReflectanceProbe,
		TransmissionStage,
		MicroscopeObjectiveReflectance,
		MicroscopeObjectiveTransmittance,
		ContactProbeHandHeld,
		ContactProbeHandHeldAutoBaseline,
		ContactStage,
		ContactStageAutoBaseline,
		CTMProbe,
		TransCurved
	}

	public enum ConstructorWarning
	{
		None,
		StartupRecipeLoadFailure,
		Generic
	}

	public enum GraphicalUserInterfaceType
	{
		Standard,
		None
	}

	public enum GraphicalUserInterfaceStartupState
	{
		Shown,
		Hidden
	}

	private delegate void a();

	public class BaselineHardwareAdjustStatus
	{
		public bool NeedsPeriodicAdjustment;

		public bool AdjustmentRequiredNow;

		public bool AdjustmentRecommendedNow;

		public float AdjustmentPeriodHours;

		public float TimeToNextRecommendedAdjustmentHours;
	}

	private delegate void b(Guid A_0, string A_1);

	private delegate void c(Guid A_0, string A_1);

	public enum MeasurementTimingModes
	{
		Recommended,
		Maximum,
		Manual
	}

	public enum SpectrometerTypes
	{
		All,
		ShortWavelengthsOnly,
		LongWavelengthsOnly,
		ExtendedWavelengths
	}

	public enum SubsystemMeasType
	{
		Reflectance,
		Transmittance,
		ReflAtFirstAngle
	}

	public enum SpectrometerIndex
	{
		ShortWavelength,
		LongWavelength
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public delegate void SystemMeasurementCompletedEventHandler(Guid systemGuid, FIMeasResultValuesOnly theResults);

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public delegate void ShutdownRequestedHandler(FormClosingEventArgs e);

	public delegate void ShuttingDownEventHandler();

	private delegate void d(bool A_0);

	[CompilerGenerated]
	[AccessedThroughProperty("mSystemInitializeCompletionTask")]
	private r.d m_a;

	[CompilerGenerated]
	[AccessedThroughProperty("mMeasTerminatorCompletionTask")]
	private r.d m_b;

	[CompilerGenerated]
	[AccessedThroughProperty("mAcqTerminatorCompletionTask")]
	private r.d m_c;

	[AccessedThroughProperty("mSpecCompletionTask")]
	[CompilerGenerated]
	private r.d m_d;

	[AccessedThroughProperty("mSystemSpecCompletionTask")]
	[CompilerGenerated]
	private r.d m_e;

	[CompilerGenerated]
	[AccessedThroughProperty("mSetupCompletionTask")]
	private r.d m_f;

	[CompilerGenerated]
	[AccessedThroughProperty("mSystemSetupCompletionTask")]
	private r.d m_g;

	[CompilerGenerated]
	[AccessedThroughProperty("mSpecAnalysisCompletionTask")]
	private r.d m_h;

	[CompilerGenerated]
	[AccessedThroughProperty("mIOCompletionTask")]
	private r.d m_i;

	[CompilerGenerated]
	[AccessedThroughProperty("mSpecTemperatureUpdateTask")]
	private r.d m_j;

	private f1 m_k;

	[AccessedThroughProperty("mInitStatus")]
	[CompilerGenerated]
	private r.c m_l;

	private bool m_m;

	private r.l m_n;

	private bool o;

	private r.l p;

	private hd q;

	private hc r;

	private Dictionary<Guid, r.g.a> s;

	private Dictionary<Guid, r.g.a> t;

	private r.i.b u;

	private hr v;

	private Dictionary<Guid, AutoResetEvent> w;

	private Dictionary<Guid, AutoResetEvent> x;

	private Dictionary<Guid, AutoResetEvent> y;

	private Dictionary<Guid, AutoResetEvent> z;

	private Dictionary<Guid, AutoResetEvent> aa;

	private Dictionary<Guid, AutoResetEvent> ab;

	private Dictionary<Guid, AutoResetEvent> ac;

	private Dictionary<Guid, AutoResetEvent> ad;

	private Dictionary<Guid, AutoResetEvent> ae;

	private Dictionary<Guid, AutoResetEvent> af;

	private AutoResetEvent ag;

	[CompilerGenerated]
	[AccessedThroughProperty("mHCTBaselineTask")]
	private r.d ah;

	private AutoResetEvent ai;

	private bool aj;

	private string ak;

	private bool al;

	private bool am;

	private bool an;

	private Thread ao;

	private gg ap;

	private bool aq;

	private FormWindowState ar;

	private bool @as;

	private r.g.a at;

	private r.d.a au;

	private string av;

	private r.d.a.a aw;

	private string ax;

	private FIMeasResultValuesOnly ay;

	private gr az;

	private Collection<r.d> a0;

	private Collection<r.d> a1;

	private Collection<r.d> a2;

	private Collection<r.d> a3;

	private float[] a4;

	private const int a5 = 80000;

	private const int a6 = 2000;

	private const int a7 = 2000;

	private const float a8 = 2.5f;

	private const int a9 = 20000;

	private const int ba = 60000;

	private const int bb = 120000;

	private const int bc = 7;

	[CompilerGenerated]
	private SystemMeasurementCompletedEventHandler bd;

	[CompilerGenerated]
	private ShutdownRequestedHandler be;

	[CompilerGenerated]
	private ShuttingDownEventHandler bf;

	private r.d.a bg;

	private virtual r.d mSystemInitializeCompletionTask
	{
		[CompilerGenerated]
		get
		{
			return this.m_a;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			r.d.b a_ = n;
			this.m_a?.e(a_);
			this.m_a = value;
			this.m_a?.d(a_);
		}
	}

	private virtual r.d mMeasTerminatorCompletionTask
	{
		[CompilerGenerated]
		get
		{
			return this.m_b;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			r.d.b a_ = c;
			this.m_b?.e(a_);
			this.m_b = value;
			this.m_b?.d(a_);
		}
	}

	private virtual r.d mAcqTerminatorCompletionTask
	{
		[CompilerGenerated]
		get
		{
			return this.m_c;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			r.d.b a_ = m;
			this.m_c?.e(a_);
			this.m_c = value;
			this.m_c?.d(a_);
		}
	}

	private virtual r.d mSpecCompletionTask
	{
		[CompilerGenerated]
		get
		{
			return this.m_d;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			r.d.b a_ = j;
			this.m_d?.e(a_);
			this.m_d = value;
			this.m_d?.d(a_);
		}
	}

	private virtual r.d mSystemSpecCompletionTask
	{
		[CompilerGenerated]
		get
		{
			return this.m_e;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			r.d.b a_ = g;
			this.m_e?.e(a_);
			this.m_e = value;
			this.m_e?.d(a_);
		}
	}

	private virtual r.d mSetupCompletionTask
	{
		[CompilerGenerated]
		get
		{
			return this.m_f;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			r.d.b a_ = e;
			this.m_f?.e(a_);
			this.m_f = value;
			this.m_f?.d(a_);
		}
	}

	private virtual r.d mSystemSetupCompletionTask
	{
		[CompilerGenerated]
		get
		{
			return this.m_g;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			r.d.b a_ = d;
			this.m_g?.e(a_);
			this.m_g = value;
			this.m_g?.d(a_);
		}
	}

	private virtual r.d mSpecAnalysisCompletionTask
	{
		[CompilerGenerated]
		get
		{
			return this.m_h;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			r.d.b a_ = k;
			this.m_h?.e(a_);
			this.m_h = value;
			this.m_h?.d(a_);
		}
	}

	private virtual r.d mIOCompletionTask
	{
		[CompilerGenerated]
		get
		{
			return this.m_i;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			r.d.b a_ = l;
			this.m_i?.e(a_);
			this.m_i = value;
			this.m_i?.d(a_);
		}
	}

	private virtual r.d mSpecTemperatureUpdateTask
	{
		[CompilerGenerated]
		get
		{
			return this.m_j;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			r.d.b a_ = i;
			this.m_j?.e(a_);
			this.m_j = value;
			this.m_j?.d(a_);
		}
	}

	private virtual r.c mInitStatus
	{
		[CompilerGenerated]
		get
		{
			return this.m_l;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			r.c.b a_ = a;
			this.m_l?.u(a_);
			this.m_l = value;
			this.m_l?.t(a_);
		}
	}

	private virtual r.d mHCTBaselineTask
	{
		[CompilerGenerated]
		get
		{
			return ah;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			r.d.b a_ = h;
			ah?.e(a_);
			ah = value;
			ah?.d(a_);
		}
	}

	public bool BaselineHardwareAdjustInhibit
	{
		get
		{
			return this.get_BaselineHardwareAdjustInhibit(ActiveMeasModuleOrSystemGuid);
		}
		set
		{
			this.set_BaselineHardwareAdjustInhibit(ActiveMeasModuleOrSystemGuid, value);
		}
	}

	// C# has no syntax for parameterized property 'BaselineHardwareAdjustInhibit'.
	public bool get_BaselineHardwareAdjustInhibit(Guid measChannelOrSystemGuid)
	{
		bool A_ = false;
		a(measChannelOrSystemGuid, ref A_);
		return this.m_k.ur(measChannelOrSystemGuid);
	}

	public void set_BaselineHardwareAdjustInhibit(Guid measChannelOrSystemGuid, bool value)
	{
		bool A_ = false;
		a(measChannelOrSystemGuid, ref A_);
		this.m_k.p9(measChannelOrSystemGuid, value);
	}

	public bool BaselineHardwareAdjustRequested
	{
		get
		{
			return this.get_BaselineHardwareAdjustRequested(ActiveMeasModuleOrSystemGuid);
		}
		set
		{
			this.set_BaselineHardwareAdjustRequested(ActiveMeasModuleOrSystemGuid, value);
		}
	}

	// C# has no syntax for parameterized property 'BaselineHardwareAdjustRequested'.
	public bool get_BaselineHardwareAdjustRequested(Guid measChannelOrSystemGuid)
	{
		bool A_ = false;
		a(measChannelOrSystemGuid, ref A_);
		return this.m_k.us(measChannelOrSystemGuid);
	}

	public void set_BaselineHardwareAdjustRequested(Guid measChannelOrSystemGuid, bool value)
	{
		bool A_ = false;
		a(measChannelOrSystemGuid, ref A_);
		this.m_k.qh(measChannelOrSystemGuid, value);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public bool GeneralPurposeIOIsSupported => f(ActiveMeasModuleOnlyGuid);

	// C# has no syntax for parameterized property 'GeneralPurposeIOIsSupported'.
	private bool f(Guid A_0)
	{
		a(A_0, 0);
		return this.m_k.uw(A_0);
	}

	public bool GUIVisible
	{
		get
		{
			return aq;
		}
		set
		{
			if (ap == null)
			{
				throw new IllegalCommandException("GUI cannot be displayed if FIRemote class was constructed with no GUI");
			}
			b(value);
		}
	}

	public string MaterialPath => jb.d();

	public string MaterialPathCustom
	{
		get
		{
			return jb.e();
		}
		set
		{
			global::e.a().CustomMaterialPath = value;
			jb.w(value);
		}
	}

	// C# has no syntax for parameterized property 'MeasChannelName'.
	public string get_MeasChannelName(Guid measChannelGuid)
	{
		c(measChannelGuid);
		return this.m_k.m2(measChannelGuid.ToString());
	}

	// C# has no syntax for parameterized property 'MeasChannelHWName'.
	public string get_MeasChannelHWName(Guid measChannelGuid)
	{
		c(measChannelGuid);
		return this.m_k.p9(measChannelGuid.ToString());
	}

	// C# has no syntax for parameterized property 'MeasChannelHWSerialNumber'.
	public string get_MeasChannelHWSerialNumber(Guid measChannelGuid)
	{
		return this.get_MeasChannelHWSerialNumber(measChannelGuid, 0);
	}

	// C# has no syntax for parameterized property 'MeasChannelHWSerialNumber'.
	public string get_MeasChannelHWSerialNumber(Guid measChannelGuid, int spectrometerIndex)
	{
		return this.get_MeasChannelHWSerialNumber(measChannelGuid, 0, spectrometerIndex);
	}

	// C# has no syntax for parameterized property 'MeasChannelHWSerialNumber'.
	public string get_MeasChannelHWSerialNumber(Guid measChannelGuid, int subsystemIndex, int spectrometerIndex)
	{
		a(measChannelGuid, subsystemIndex);
		int num = this.get_NumberOfSpectrometers(measChannelGuid, subsystemIndex);
		if (spectrometerIndex < 0 || spectrometerIndex >= num)
		{
			throw new ArgumentException("spectrometerIndex must be >=0 and < " + Conversions.ToString(num), "spectrometerIndex");
		}
		return this.m_k.p9(measChannelGuid, subsystemIndex, spectrometerIndex);
	}

	public int NumberOfChannels
	{
		get
		{
			if (!al)
			{
				throw new InitializationNotCompletedException("Initialization not complete");
			}
			return this.m_k.t0();
		}
	}

	// C# has no syntax for parameterized property 'NumberOfSubSystems'.
	public int get_NumberOfSubSystems(Guid measChannelGuid)
	{
		c(measChannelGuid);
		int[] array = this.m_k.un(measChannelGuid);
		if (array == null)
		{
			return 0;
		}
		return array.Length;
	}

	// C# has no syntax for parameterized property 'NumberOfSpectrometers'.
	public int get_NumberOfSpectrometers(Guid measChannelGuid)
	{
		return this.get_NumberOfSpectrometers(measChannelGuid, 0);
	}

	// C# has no syntax for parameterized property 'NumberOfSpectrometers'.
	public int get_NumberOfSpectrometers(Guid measChannelGuid, int subsystemIndex)
	{
		a(measChannelGuid, subsystemIndex);
		return this.m_k.un(measChannelGuid)[subsystemIndex];
	}

	// C# has no syntax for parameterized property 'MeasChannelGuid'.
	public Guid get_MeasChannelGuid(int measChannelIndex)
	{
		b(measChannelIndex);
		return this.m_k.tj()[measChannelIndex];
	}

	// C# has no syntax for parameterized property 'MeasChannelGuid'.
	public Guid get_MeasChannelGuid(Guid measSystemGuid, int measChannelIndex)
	{
		b(measSystemGuid);
		gx obj = this.m_k.ua(measSystemGuid);
		int count = obj.o.Count;
		if (measChannelIndex < 0 || measChannelIndex >= count)
		{
			throw new ArgumentException("measChannelIndex must be >=0 and < " + Conversions.ToString(count), "measChannelIndex");
		}
		return obj.o[measChannelIndex];
	}

	public Collection<Guid> MeasChannelGuids
	{
		get
		{
			if (!al)
			{
				throw new InitializationNotCompletedException("Attempt to get MeasChannelGuids before initialization completed");
			}
			return this.m_k.tj();
		}
	}

	// C# has no syntax for parameterized property 'MeasSystemGuid'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: EditorBrowsable(EditorBrowsableState.Advanced)]
	public Guid get_MeasSystemGuid(int measSystemIndex)
	{
		a(measSystemIndex);
		return this.m_k.tl()[measSystemIndex];
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public Collection<Guid> MeasSystemGuids
	{
		get
		{
			if (!al)
			{
				throw new InitializationNotCompletedException("Attempt to get MeasSystemGuids before initialization completed");
			}
			return this.m_k.tl();
		}
	}

	// C# has no syntax for parameterized property 'MeasSystemHWName'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: EditorBrowsable(EditorBrowsableState.Advanced)]
	public string get_MeasSystemHWName(Guid systemGuid)
	{
		b(systemGuid);
		return this.m_k.vz(systemGuid);
	}

	// C# has no syntax for parameterized property 'MeasSystemName'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: EditorBrowsable(EditorBrowsableState.Advanced)]
	public string get_MeasSystemName(Guid systemGuid)
	{
		b(systemGuid);
		return this.m_k.vy(systemGuid);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public int NumberOfSystems
	{
		get
		{
			if (!al)
			{
				throw new InitializationNotCompletedException("Initialization not complete");
			}
			return this.m_k.t5();
		}
	}

	public OpticsConfigSystemTypes OpticsConfiguration
	{
		get
		{
			return this.get_OpticsConfiguration(ActiveMeasModuleOrSystemGuid);
		}
		set
		{
			this.set_OpticsConfiguration(ActiveMeasModuleOrSystemGuid, value);
		}
	}

	// C# has no syntax for parameterized property 'OpticsConfiguration'.
	public OpticsConfigSystemTypes get_OpticsConfiguration(Guid measChannelOrSystemGuid)
	{
		bool A_ = false;
		a(measChannelOrSystemGuid, ref A_);
		return this.m_k.u8(measChannelOrSystemGuid) switch
		{
			g2.a.b => OpticsConfigSystemTypes.ReflectanceAndTransmittanceAutoBaseline, 
			g2.a.c => OpticsConfigSystemTypes.ReflectanceAndTransmittance, 
			g2.a.d => OpticsConfigSystemTypes.ReflectanceProbe, 
			g2.a.e => OpticsConfigSystemTypes.TransmissionStage, 
			g2.a.f => OpticsConfigSystemTypes.MicroscopeObjectiveReflectance, 
			g2.a.g => OpticsConfigSystemTypes.MicroscopeObjectiveTransmittance, 
			g2.a.h => OpticsConfigSystemTypes.ContactProbeHandHeld, 
			g2.a.i => OpticsConfigSystemTypes.ContactProbeHandHeldAutoBaseline, 
			g2.a.j => OpticsConfigSystemTypes.ContactStage, 
			g2.a.k => OpticsConfigSystemTypes.ContactStageAutoBaseline, 
			g2.a.m => OpticsConfigSystemTypes.CTMProbe, 
			g2.a.n => OpticsConfigSystemTypes.TransCurved, 
			_ => throw new ApplicationException("Unknown Optics configuration"), 
		};
	}

	public void set_OpticsConfiguration(Guid measChannelOrSystemGuid, OpticsConfigSystemTypes newOpticsConfig)
	{
		Guid guid = e(measChannelOrSystemGuid);
		c(guid);
		bool flag = true;
		bool flag2 = true;
		bool flag3 = false;
		g2.a a10 = default(g2.a);
		switch (value)
		{
		case OpticsConfigSystemTypes.ReflectanceAndTransmittanceAutoBaseline:
			a10 = g2.a.b;
			break;
		case OpticsConfigSystemTypes.ReflectanceAndTransmittance:
			a10 = g2.a.c;
			break;
		case OpticsConfigSystemTypes.ReflectanceProbe:
			a10 = g2.a.d;
			break;
		case OpticsConfigSystemTypes.TransmissionStage:
			a10 = g2.a.e;
			flag = false;
			break;
		case OpticsConfigSystemTypes.MicroscopeObjectiveReflectance:
			a10 = g2.a.f;
			break;
		case OpticsConfigSystemTypes.MicroscopeObjectiveTransmittance:
			a10 = g2.a.g;
			flag2 = false;
			break;
		case OpticsConfigSystemTypes.ContactProbeHandHeld:
			a10 = g2.a.h;
			break;
		case OpticsConfigSystemTypes.ContactProbeHandHeldAutoBaseline:
			a10 = g2.a.i;
			break;
		case OpticsConfigSystemTypes.ContactStage:
			a10 = g2.a.j;
			break;
		case OpticsConfigSystemTypes.ContactStageAutoBaseline:
			a10 = g2.a.k;
			break;
		case OpticsConfigSystemTypes.CTMProbe:
			a10 = g2.a.m;
			break;
		case OpticsConfigSystemTypes.TransCurved:
			a10 = g2.a.n;
			break;
		}
		if (this.m_k.vl(guid))
		{
			throw new IncompatibleHardwareException("The Optics Configuration for the current hardware cannot be changed by software");
		}
		if (a10 == g2.a.c || a10 == g2.a.b)
		{
			flag3 = true;
		}
		if (g2.c(a10))
		{
			if (!this.m_k.w0(guid))
			{
				flag3 = true;
			}
		}
		else if (!this.m_k.wz(guid))
		{
			flag3 = true;
		}
		if (g2.j(a10) && !this.m_k.w7(guid))
		{
			flag3 = true;
		}
		if (flag3)
		{
			throw new IncompatibleHardwareException("The selected Optics Configuration is incompatible with the Hardware");
		}
		g2 g10 = this.m_k.u9(guid);
		g10.o(a10);
		if (a10 == g2.a.d || a10 == g2.a.e)
		{
			g10.x = flag;
		}
		if (g2.c(a10))
		{
			g10.aa = flag2;
		}
		g10 = null;
		hg obj = this.m_k.wq(guid);
		obj.bu(this.m_k.u9(guid));
		obj.bv(global::e.a().OperatorID, DateTime.Now);
		obj.bv(mSetupCompletionTask, A_1: true);
		_ = null;
		if (!ac[guid].WaitOne(2000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for optics configuration setting to be applied", 2000);
		}
		if (aw != global::r.d.a.a.a)
		{
			throw new SetupFailureException(ax);
		}
	}

	public string OperatorID
	{
		get
		{
			return global::e.a().OperatorID;
		}
		set
		{
			if (ap == null)
			{
				throw new IllegalCommandException("OperatorID cannot be set if user interface is permanently hidden");
			}
			Guid a_ = e(ActiveMeasModuleOrSystemGuid);
			c(a_);
			global::e.a().OperatorID = value;
			c(a_, value);
		}
	}

	public string SampleID
	{
		get
		{
			return global::e.a().SampleID;
		}
		set
		{
			if (ap == null)
			{
				throw new IllegalCommandException("SampleID cannot be set if user interface is permanently hidden");
			}
			Guid a_ = e(ActiveMeasModuleOrSystemGuid);
			c(a_);
			global::e.a().SampleID = value;
			b(a_, value);
		}
	}

	public FIRecipeInfo RecipeInfo => this.get_RecipeInfo(ActiveMeasModuleOrSystemGuid);

	// C# has no syntax for parameterized property 'RecipeInfo'.
	public FIRecipeInfo get_RecipeInfo(Guid measChannelOrSystemGuid)
	{
		FIRecipeInfo fIRecipeInfo = new FIRecipeInfo();
		hg hg2 = this.m_k.wq(measChannelOrSystemGuid);
		hi hi2 = hg2.ed();
		checked
		{
			int num = hg2.b4(0) + 1;
			FIRecipeInfo fIRecipeInfo2 = fIRecipeInfo;
			fIRecipeInfo2.Name = hg2.ci();
			fIRecipeInfo2.FullPath = hg2.c1();
			fIRecipeInfo2.FilmStackNumLayers = num + 1;
			fIRecipeInfo2.TypeIsSpectrumAnalysis = hg2.b5();
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				gc gc2 = hi2.et(num3);
				string text = gc2.ag();
				if (num3 == 0 || num3 == num || gd.l(text))
				{
					fIRecipeInfo2.FilmStackLayerThicknesses_nm.Add(0f);
				}
				else
				{
					fIRecipeInfo2.FilmStackLayerThicknesses_nm.Add((float)gc2.ai());
				}
				fIRecipeInfo2.FilmStackLayerMats.Add(text);
			}
			fIRecipeInfo2 = null;
			return fIRecipeInfo;
		}
	}

	public string RecipePath => hg.bv();

	public string RecipePathCustom
	{
		get
		{
			return hg.bx();
		}
		set
		{
			global::e.a().CustomRecipePath = value;
			hg.bw(value);
		}
	}

	public FISpecDiagnosticsInfo[] SpectrometerDiagnostics => this.get_SpectrometerDiagnostics(ActiveMeasModuleOnlyGuid);

	// C# has no syntax for parameterized property 'SpectrometerDiagnostics'.
	public FISpecDiagnosticsInfo[] get_SpectrometerDiagnostics(Guid measChannelGuid)
	{
		return this.get_SpectrometerDiagnostics(measChannelGuid, 0);
	}

	// C# has no syntax for parameterized property 'SpectrometerDiagnostics'.
	public FISpecDiagnosticsInfo[] get_SpectrometerDiagnostics(Guid measChannelGuid, int subsystemIndex)
	{
		a(measChannelGuid, subsystemIndex);
		checked
		{
			int num = this.m_k.un(measChannelGuid)[subsystemIndex] - 1;
			FISpecDiagnosticsInfo[] array = new FISpecDiagnosticsInfo[num + 1];
			a9 a10 = new a9();
			a9 a11 = a10;
			f1 obj = this.m_k;
			ref double a_ = ref a11.d;
			ref int a_2 = ref a11.e;
			ref double a_3 = ref a11.q;
			ref int a_4 = ref a11.r;
			int A_ = 0;
			obj.m2(measChannelGuid, subsystemIndex, ref a_, ref a_2, ref a_3, ref a_4, ref A_);
			this.m_k.m2(measChannelGuid, subsystemIndex, ref a11.f, ref a11.g, ref a11.s, ref a11.t, ref a11.h, ref a11.i, ref a11.u, ref a11.v, ref a11.j, ref a11.k, ref a11.w, ref a11.x, ref a11.l, ref a11.m, ref a11.y, ref a11.z, ref a11.n, ref a11.aa);
			a11 = null;
			array[0] = new FISpecDiagnosticsInfo();
			FISpecDiagnosticsInfo fISpecDiagnosticsInfo = array[0];
			fISpecDiagnosticsInfo.IntegrationTime_ms = a10.d;
			fISpecDiagnosticsInfo.IntegrationTimeSample_ms = a10.n;
			fISpecDiagnosticsInfo.NumberOfCyclesToAverage = a10.e;
			fISpecDiagnosticsInfo.PeakRawBackground = a10.j;
			fISpecDiagnosticsInfo.PeakRawBackgroundWave = a10.k;
			fISpecDiagnosticsInfo.PeakRawReference = a10.f;
			fISpecDiagnosticsInfo.PeakRawReferenceWave = a10.g;
			fISpecDiagnosticsInfo.PeakRawSample = a10.l;
			fISpecDiagnosticsInfo.PeakRawSampleWave = a10.m;
			fISpecDiagnosticsInfo.PeakRawTransCurvedR = a10.h;
			fISpecDiagnosticsInfo.PeakRawTransCurvedRWave = a10.i;
			fISpecDiagnosticsInfo.ReferenceMaterial = this.m_k.m2(measChannelGuid, global::f.b.b, subsystemIndex);
			a(measChannelGuid, subsystemIndex, global::f.b.b, ref fISpecDiagnosticsInfo.HasDetectorTemperatureSensor, ref fISpecDiagnosticsInfo.DetectorTemperature, ref fISpecDiagnosticsInfo.HasSpectrometerTemperatureSensor, ref fISpecDiagnosticsInfo.SpectrometerTemperature);
			fISpecDiagnosticsInfo = null;
			if (num > 0)
			{
				array[1] = new FISpecDiagnosticsInfo();
				FISpecDiagnosticsInfo fISpecDiagnosticsInfo2 = array[1];
				fISpecDiagnosticsInfo2.IntegrationTime_ms = a10.q;
				fISpecDiagnosticsInfo2.IntegrationTimeSample_ms = a10.aa;
				fISpecDiagnosticsInfo2.NumberOfCyclesToAverage = a10.r;
				fISpecDiagnosticsInfo2.PeakRawBackground = a10.w;
				fISpecDiagnosticsInfo2.PeakRawBackgroundWave = a10.x;
				fISpecDiagnosticsInfo2.PeakRawReference = a10.s;
				fISpecDiagnosticsInfo2.PeakRawReferenceWave = a10.t;
				fISpecDiagnosticsInfo2.PeakRawSample = a10.y;
				fISpecDiagnosticsInfo2.PeakRawSampleWave = a10.z;
				fISpecDiagnosticsInfo2.PeakRawTransCurvedR = a10.u;
				fISpecDiagnosticsInfo2.PeakRawTransCurvedRWave = a10.v;
				fISpecDiagnosticsInfo2.ReferenceMaterial = this.m_k.m2(measChannelGuid, global::f.b.c, subsystemIndex);
				a(measChannelGuid, subsystemIndex, global::f.b.c, ref fISpecDiagnosticsInfo2.HasDetectorTemperatureSensor, ref fISpecDiagnosticsInfo2.DetectorTemperature, ref fISpecDiagnosticsInfo2.HasSpectrometerTemperatureSensor, ref fISpecDiagnosticsInfo2.SpectrometerTemperature);
				fISpecDiagnosticsInfo2 = null;
			}
			return array;
		}
	}

	public MeasurementTimingModes MeasurementTimingMode
	{
		get
		{
			return this.get_MeasurementTimingMode(ActiveMeasModuleOrSystemGuid);
		}
		set
		{
			this.set_MeasurementTimingMode(ActiveMeasModuleOrSystemGuid, value);
		}
	}

	// C# has no syntax for parameterized property 'MeasurementTimingMode'.
	public MeasurementTimingModes get_MeasurementTimingMode(Guid measChannelOrSystemGuid)
	{
		Guid a_ = e(measChannelOrSystemGuid);
		c(a_);
		return this.m_k.wq(a_).b8().n(this.m_k.sm(a_)) switch
		{
			global::h.MeasurementTimingType.Manual => MeasurementTimingModes.Manual, 
			global::h.MeasurementTimingType.Maximum => MeasurementTimingModes.Maximum, 
			_ => MeasurementTimingModes.Recommended, 
		};
	}

	public void set_MeasurementTimingMode(Guid measChannelOrSystemGuid, MeasurementTimingModes value)
	{
		Guid guid = e(measChannelOrSystemGuid);
		c(guid);
		a(guid, "MeasurementTimingMode");
		if (value != MeasurementTimingModes.Manual && this.m_k.sm(guid))
		{
			throw new ArgumentException("Only Manual is permitted", "MeasurementTimingMode");
		}
		h.MeasurementTimingType a_ = value switch
		{
			MeasurementTimingModes.Manual => global::h.MeasurementTimingType.Manual, 
			MeasurementTimingModes.Maximum => global::h.MeasurementTimingType.Maximum, 
			_ => global::h.MeasurementTimingType.Recommended, 
		};
		hg obj = this.m_k.wq(guid);
		obj.b8().b(a_);
		obj.bv(mSetupCompletionTask, A_1: true);
		if (!ac[guid].WaitOne(2000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for MeasurementTimingMode setting to be applied", 2000);
		}
		if (aw != global::r.d.a.a.a)
		{
			throw new SetupFailureException(ax);
		}
	}

	public double MaximumSamplingTime
	{
		get
		{
			return this.get_MaximumSamplingTime(ActiveMeasModuleOrSystemGuid);
		}
		set
		{
			this.set_MaximumSamplingTime(ActiveMeasModuleOrSystemGuid, value);
		}
	}

	// C# has no syntax for parameterized property 'MaximumSamplingTime'.
	public double get_MaximumSamplingTime(Guid measChannelOrSystemGuid)
	{
		Guid a_ = e(measChannelOrSystemGuid);
		c(a_);
		return this.m_k.wq(a_).b8().ar();
	}

	public void set_MaximumSamplingTime(Guid measChannelOrSystemGuid, double value)
	{
		Guid guid = e(measChannelOrSystemGuid);
		c(guid);
		a(guid, "MaximumSamplingTime");
		if (value < 1.0)
		{
			throw new ArgumentException("Minimum value is " + 1.0, "IntegrationCycles");
		}
		if (value > 60000.0)
		{
			throw new ArgumentException("Maximum value is " + 60000.0, "IntegrationCycles");
		}
		hg obj = this.m_k.wq(guid);
		obj.b8().a(value);
		obj.bv(mSetupCompletionTask, A_1: true);
		if (!ac[guid].WaitOne(2000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for MaximumSamplingTime setting to be applied", 2000);
		}
		if (aw != global::r.d.a.a.a)
		{
			throw new SetupFailureException(ax);
		}
	}

	public int IntegrationCycles
	{
		get
		{
			return this.get_IntegrationCycles(ActiveMeasModuleOnlyGuid);
		}
		set
		{
			this.set_IntegrationCycles(ActiveMeasModuleOrSystemGuid, value);
		}
	}

	// C# has no syntax for parameterized property 'IntegrationCycles'.
	public int get_IntegrationCycles(Guid measChannelGuid)
	{
		return this.get_IntegrationCycles(measChannelGuid, SubsystemMeasType.Reflectance, SpectrometerIndex.ShortWavelength);
	}

	public void set_IntegrationCycles(Guid measChannelGuid, int value)
	{
		this.set_IntegrationCycles(measChannelGuid, SubsystemMeasType.Reflectance, SpectrometerIndex.ShortWavelength, value);
	}

	// C# has no syntax for parameterized property 'IntegrationCycles'.
	public int get_IntegrationCycles(SpectrometerIndex specIndex)
	{
		return this.get_IntegrationCycles(ActiveMeasModuleOrSystemGuid, specIndex);
	}

	public void set_IntegrationCycles(SpectrometerIndex specIndex, int value)
	{
		this.set_IntegrationCycles(ActiveMeasModuleOrSystemGuid, specIndex, value);
	}

	// C# has no syntax for parameterized property 'IntegrationCycles'.
	public int get_IntegrationCycles(SubsystemMeasType measType)
	{
		return this.get_IntegrationCycles(ActiveMeasModuleOnlyGuid, measType, SpectrometerIndex.ShortWavelength);
	}

	public void set_IntegrationCycles(SubsystemMeasType measType, int value)
	{
		this.set_IntegrationCycles(ActiveMeasModuleOnlyGuid, measType, SpectrometerIndex.ShortWavelength, value);
	}

	// C# has no syntax for parameterized property 'IntegrationCycles'.
	public int get_IntegrationCycles(Guid measChannelGuid, SpectrometerIndex specIndex)
	{
		return this.get_IntegrationCycles(measChannelGuid, SubsystemMeasType.Reflectance, specIndex);
	}

	public void set_IntegrationCycles(Guid measChannelGuid, SpectrometerIndex specIndex, int value)
	{
		this.set_IntegrationCycles(measChannelGuid, SubsystemMeasType.Reflectance, specIndex, value);
	}

	// C# has no syntax for parameterized property 'IntegrationCycles'.
	public int get_IntegrationCycles(Guid systemOrMeasChannelGuid, SubsystemMeasType measType, SpectrometerIndex specIndex)
	{
		Guid a_ = d(systemOrMeasChannelGuid);
		c(a_);
		hg obj = this.m_k.wq(a_);
		h.f a_2 = a(measType);
		f.b a_3 = a(specIndex);
		return obj.b8().a((int)a_2).h(a_3);
	}

	public void set_IntegrationCycles(Guid systemOrMeasChannelGuid, SubsystemMeasType measType, SpectrometerIndex specIndex, int value)
	{
		Guid guid = d(systemOrMeasChannelGuid);
		c(guid);
		a(guid, "IntegrationCycles");
		hg obj = this.m_k.wq(guid);
		h.f a_ = a(measType);
		f.b a_2 = a(specIndex);
		if (value < 1)
		{
			throw new ArgumentException("Minimum value is " + 1, "IntegrationCycles");
		}
		if (value > 5000)
		{
			throw new ArgumentException("Maximum value is " + 5000, "IntegrationCycles");
		}
		obj.b8().a((int)a_).b(a_2, value);
		obj.bv(mSetupCompletionTask, A_1: true);
		if (!ac[guid].WaitOne(2000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for IntegrationCycles setting to be applied", 2000);
		}
		if (aw != global::r.d.a.a.a)
		{
			throw new SetupFailureException(ax);
		}
	}

	public double IntegrationTime_ms
	{
		get
		{
			return this.get_IntegrationTime_ms(ActiveMeasModuleOnlyGuid);
		}
		set
		{
			this.set_IntegrationTime_ms(ActiveMeasModuleOrSystemGuid, value);
		}
	}

	// C# has no syntax for parameterized property 'IntegrationTime_ms'.
	public double get_IntegrationTime_ms(Guid measChannelGuid)
	{
		return this.get_IntegrationTime_ms(measChannelGuid, SubsystemMeasType.Reflectance, SpectrometerIndex.ShortWavelength);
	}

	public void set_IntegrationTime_ms(Guid measChannelGuid, double value)
	{
		this.set_IntegrationTime_ms(measChannelGuid, SubsystemMeasType.Reflectance, SpectrometerIndex.ShortWavelength, value);
	}

	// C# has no syntax for parameterized property 'IntegrationTime_ms'.
	public double get_IntegrationTime_ms(SpectrometerIndex specIndex)
	{
		return this.get_IntegrationTime_ms(ActiveMeasModuleOrSystemGuid, specIndex);
	}

	public void set_IntegrationTime_ms(SpectrometerIndex specIndex, double value)
	{
		this.set_IntegrationTime_ms(ActiveMeasModuleOrSystemGuid, specIndex, value);
	}

	// C# has no syntax for parameterized property 'IntegrationTime_ms'.
	public double get_IntegrationTime_ms(SubsystemMeasType measType)
	{
		return this.get_IntegrationTime_ms(ActiveMeasModuleOnlyGuid, measType, SpectrometerIndex.ShortWavelength);
	}

	public void set_IntegrationTime_ms(SubsystemMeasType measType, double value)
	{
		this.set_IntegrationTime_ms(ActiveMeasModuleOnlyGuid, measType, SpectrometerIndex.ShortWavelength, value);
	}

	// C# has no syntax for parameterized property 'IntegrationTime_ms'.
	public double get_IntegrationTime_ms(Guid measChannelGuid, SpectrometerIndex specIndex)
	{
		return this.get_IntegrationTime_ms(measChannelGuid, SubsystemMeasType.Reflectance, specIndex);
	}

	public void set_IntegrationTime_ms(Guid measChannelGuid, SpectrometerIndex specIndex, double value)
	{
		this.set_IntegrationTime_ms(measChannelGuid, SubsystemMeasType.Reflectance, specIndex, value);
	}

	// C# has no syntax for parameterized property 'IntegrationTime_ms'.
	public double get_IntegrationTime_ms(Guid systemOrMeasChannelGuid, SubsystemMeasType measType, SpectrometerIndex specIndex)
	{
		Guid a_ = d(systemOrMeasChannelGuid);
		c(a_);
		h.f a_2 = a(measType);
		f.b a_3 = a(specIndex);
		return this.m_k.wq(a_).b8().a((int)a_2)
			.b(a_3);
	}

	public void set_IntegrationTime_ms(Guid systemOrMeasChannelGuid, SubsystemMeasType measType, SpectrometerIndex specIndex, double value)
	{
		Guid guid = d(systemOrMeasChannelGuid);
		c(guid);
		a(guid, "IntegrationTime_ms");
		h.f f10 = a(measType);
		f.b b10 = a(specIndex);
		int a_ = this.m_k.m2(guid, f10);
		double num = this.m_k.p9(guid, h6.b.b, a_, b10);
		double num2 = this.m_k.m2(guid, h6.b.b, a_, b10);
		if (value < num)
		{
			throw new ArgumentException("Minimum value is " + num, "IntegrationTime_ms");
		}
		if (value > num2)
		{
			throw new ArgumentException("Maximum value is " + num2, "IntegrationTime_ms");
		}
		hg obj = this.m_k.wq(guid);
		obj.b8().a((int)f10).b(b10, value);
		obj.bv(mSetupCompletionTask, A_1: true);
		if (!ac[guid].WaitOne(2000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for IntegrationTime_ms setting to be applied", 2000);
		}
		if (aw != global::r.d.a.a.a)
		{
			throw new SetupFailureException(ax);
		}
	}

	public SpectrometerTypes SpectrometerType
	{
		get
		{
			return this.get_SpectrometerType(ActiveMeasModuleOrSystemGuid);
		}
		set
		{
			this.set_SpectrometerType(ActiveMeasModuleOrSystemGuid, value);
		}
	}

	// C# has no syntax for parameterized property 'SpectrometerType'.
	public SpectrometerTypes get_SpectrometerType(Guid measChannelOrSystemGuid)
	{
		return this.get_SpectrometerType(measChannelOrSystemGuid, SubsystemMeasType.Reflectance);
	}

	public void set_SpectrometerType(Guid measChannelOrSystemGuid, SpectrometerTypes value)
	{
		this.set_SpectrometerType(measChannelOrSystemGuid, SubsystemMeasType.Reflectance, value);
	}

	// C# has no syntax for parameterized property 'SpectrometerType'.
	public SpectrometerTypes get_SpectrometerType(SubsystemMeasType measType)
	{
		return this.get_SpectrometerType(ActiveMeasModuleOrSystemGuid, measType);
	}

	public void set_SpectrometerType(SubsystemMeasType measType, SpectrometerTypes value)
	{
		this.set_SpectrometerType(ActiveMeasModuleOrSystemGuid, measType, value);
	}

	// C# has no syntax for parameterized property 'SpectrometerType'.
	public SpectrometerTypes get_SpectrometerType(Guid measChannelOrSystemGuid, SubsystemMeasType measType)
	{
		Guid a_ = e(measChannelOrSystemGuid);
		c(a_);
		hg hg2 = this.m_k.wq(a_);
		h.f f10 = a(hg2, measType);
		f f11 = hg2.b8().a((int)f10);
		bool a_2;
		if (f11.h() == global::f.a.a || f11.h() == global::f.a.d)
		{
			bool[] array = this.m_k.uo(a_);
			int num = this.m_k.m2(a_, f10);
			if (num < 0)
			{
				throw new IncompatibleHardwareException("Specified measType does not exist");
			}
			a_2 = array[num];
		}
		else
		{
			a_2 = true;
		}
		return hg2.b8().a((int)f10).b(a_2) switch
		{
			global::f.a.d => SpectrometerTypes.ExtendedWavelengths, 
			global::f.a.b => SpectrometerTypes.ShortWavelengthsOnly, 
			global::f.a.c => SpectrometerTypes.LongWavelengthsOnly, 
			_ => SpectrometerTypes.All, 
		};
	}

	public void set_SpectrometerType(Guid measChannelOrSystemGuid, SubsystemMeasType measType, SpectrometerTypes value)
	{
		Guid guid = e(measChannelOrSystemGuid);
		c(guid);
		a(guid, "SpectrometerType");
		hg hg2 = this.m_k.wq(guid);
		h.f f10 = a(hg2, measType);
		if (value == SpectrometerTypes.All || value == SpectrometerTypes.ExtendedWavelengths)
		{
			bool[] array = this.m_k.uo(guid);
			int num = this.m_k.m2(guid, f10);
			if (num < 0)
			{
				throw new IncompatibleHardwareException("Specified measType does not exist");
			}
			if (!array[num])
			{
				throw new IncompatibleHardwareException("Specified SpectrometerType setting is not permitted by hardware");
			}
		}
		f f11 = hg2.b8().a((int)f10);
		switch (value)
		{
		case SpectrometerTypes.ExtendedWavelengths:
			f11.h(global::f.a.d);
			break;
		case SpectrometerTypes.ShortWavelengthsOnly:
			f11.h(global::f.a.b);
			break;
		case SpectrometerTypes.LongWavelengthsOnly:
			f11.h(global::f.a.c);
			break;
		default:
			f11.h(global::f.a.a);
			break;
		}
		f11 = null;
		hg2.bv(mSetupCompletionTask, A_1: true);
		if (!ac[guid].WaitOne(2000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for SpectrometerType setting to be applied", 2000);
		}
		if (aw != global::r.d.a.a.a)
		{
			throw new SetupFailureException(ax);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public bool SystemAutoSave
	{
		get
		{
			return this.get_SystemAutoSave(ActiveSystemGuid);
		}
		set
		{
			this.set_SystemAutoSave(ActiveSystemGuid, value);
		}
	}

	// C# has no syntax for parameterized property 'SystemAutoSave'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: EditorBrowsable(EditorBrowsableState.Advanced)]
	public bool get_SystemAutoSave(Guid systemGuid)
	{
		b(systemGuid);
		return this.m_k.we(systemGuid);
	}

	public void set_SystemAutoSave(Guid systemGuid, bool value)
	{
		b(systemGuid);
		this.m_k.sm(systemGuid, value);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public string SystemAutoSaveBaseFileNameAndPath
	{
		get
		{
			return this.get_SystemAutoSaveBaseFileNameAndPath(ActiveSystemGuid);
		}
		set
		{
			string A_ = string.Empty;
			if (!gx.j(value, ref A_))
			{
				throw new FileWriteFailure(A_);
			}
			this.set_SystemAutoSaveBaseFileNameAndPath(ActiveSystemGuid, value);
		}
	}

	// C# has no syntax for parameterized property 'SystemAutoSaveBaseFileNameAndPath'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: EditorBrowsable(EditorBrowsableState.Advanced)]
	public string get_SystemAutoSaveBaseFileNameAndPath(Guid systemGuid)
	{
		b(systemGuid);
		return this.m_k.wf(systemGuid);
	}

	public void set_SystemAutoSaveBaseFileNameAndPath(Guid systemGuid, string value)
	{
		b(systemGuid);
		this.m_k.m2(systemGuid, value);
	}

	private Guid ActiveMeasModuleOnlyGuid
	{
		get
		{
			if (!al)
			{
				throw new InitializationNotCompletedException("Attempt to get Channel or System Guid before initialization completed.");
			}
			Collection<Guid> measSystemGuids = MeasSystemGuids;
			Collection<Guid> measChannelGuids = MeasChannelGuids;
			if (measChannelGuids.Count <= 1 && measSystemGuids.Count == 0)
			{
				if (measChannelGuids.Count == 0)
				{
					throw new NoHardwareException("No measurement modules present");
				}
				return measChannelGuids[0];
			}
			if (measChannelGuids.Count == 1)
			{
				return measChannelGuids[0];
			}
			if (ap == null)
			{
				throw new AmbiguousMeasModuleException("Channel Guid must be specified if more than one channel exists and FilmeasureGUI is hidden.");
			}
			if (!ap.ei())
			{
				throw new AmbiguousMeasModuleException("Channel guid must be specified if more than one channel exists and no Measure tab is active.");
			}
			return ap.eh();
		}
	}

	private Guid ActiveMeasModuleOrSystemGuid
	{
		get
		{
			if (!al)
			{
				throw new InitializationNotCompletedException("Attempt to get Channel or System Guid before initialization completed.");
			}
			Collection<Guid> measSystemGuids = MeasSystemGuids;
			Collection<Guid> measChannelGuids = MeasChannelGuids;
			if (measChannelGuids.Count <= 1 && measSystemGuids.Count == 0)
			{
				if (measChannelGuids.Count == 0)
				{
					throw new NoHardwareException("No measurement modules present.");
				}
				return measChannelGuids[0];
			}
			if (ap == null)
			{
				throw new AmbiguousMeasModuleException("Channel or system Guid must be specified if more than one channel exists or a system exists and FilmeasureGUI is hidden.");
			}
			if (ap.ej())
			{
				return ap.c((ix.b)null);
			}
			if (ap.ei())
			{
				return ap.eh();
			}
			throw new AmbiguousMeasModuleException("Channel or system Guid must be specified if more than one channel exists or a system exists and FilmeasureGUI is hidden.");
		}
	}

	private Guid ActiveSystemGuid
	{
		get
		{
			if (!al)
			{
				throw new InitializationNotCompletedException("Attempt to get System Guid before initialization completed");
			}
			Collection<Guid> measSystemGuids = MeasSystemGuids;
			if (measSystemGuids.Count > 1)
			{
				if (ap == null)
				{
					throw new AmbiguousMeasModuleException("System Guid must be specified if more than one System exists and FilmeasureGUI is hidden");
				}
				ix.b b10 = new ix.b();
				Guid result = ap.c(b10);
				if (b10.a)
				{
					throw new IllegalCommandException("If History tab is active and more than one system exists, then systemGuid must be specified");
				}
				return result;
			}
			if (measSystemGuids.Count == 0)
			{
				throw new NoHardwareException("No System present");
			}
			return measSystemGuids[0];
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public event SystemMeasurementCompletedEventHandler SystemMeasurementCompleted
	{
		[CompilerGenerated]
		add
		{
			SystemMeasurementCompletedEventHandler systemMeasurementCompletedEventHandler = bd;
			SystemMeasurementCompletedEventHandler systemMeasurementCompletedEventHandler2;
			do
			{
				systemMeasurementCompletedEventHandler2 = systemMeasurementCompletedEventHandler;
				SystemMeasurementCompletedEventHandler value2 = (SystemMeasurementCompletedEventHandler)Delegate.Combine(systemMeasurementCompletedEventHandler2, value);
				systemMeasurementCompletedEventHandler = Interlocked.CompareExchange(ref bd, value2, systemMeasurementCompletedEventHandler2);
			}
			while ((object)systemMeasurementCompletedEventHandler != systemMeasurementCompletedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			SystemMeasurementCompletedEventHandler systemMeasurementCompletedEventHandler = bd;
			SystemMeasurementCompletedEventHandler systemMeasurementCompletedEventHandler2;
			do
			{
				systemMeasurementCompletedEventHandler2 = systemMeasurementCompletedEventHandler;
				SystemMeasurementCompletedEventHandler value2 = (SystemMeasurementCompletedEventHandler)Delegate.Remove(systemMeasurementCompletedEventHandler2, value);
				systemMeasurementCompletedEventHandler = Interlocked.CompareExchange(ref bd, value2, systemMeasurementCompletedEventHandler2);
			}
			while ((object)systemMeasurementCompletedEventHandler != systemMeasurementCompletedEventHandler2);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public event ShutdownRequestedHandler ShutdownRequested
	{
		[CompilerGenerated]
		add
		{
			ShutdownRequestedHandler shutdownRequestedHandler = be;
			ShutdownRequestedHandler shutdownRequestedHandler2;
			do
			{
				shutdownRequestedHandler2 = shutdownRequestedHandler;
				ShutdownRequestedHandler value2 = (ShutdownRequestedHandler)Delegate.Combine(shutdownRequestedHandler2, value);
				shutdownRequestedHandler = Interlocked.CompareExchange(ref be, value2, shutdownRequestedHandler2);
			}
			while ((object)shutdownRequestedHandler != shutdownRequestedHandler2);
		}
		[CompilerGenerated]
		remove
		{
			ShutdownRequestedHandler shutdownRequestedHandler = be;
			ShutdownRequestedHandler shutdownRequestedHandler2;
			do
			{
				shutdownRequestedHandler2 = shutdownRequestedHandler;
				ShutdownRequestedHandler value2 = (ShutdownRequestedHandler)Delegate.Remove(shutdownRequestedHandler2, value);
				shutdownRequestedHandler = Interlocked.CompareExchange(ref be, value2, shutdownRequestedHandler2);
			}
			while ((object)shutdownRequestedHandler != shutdownRequestedHandler2);
		}
	}

	public event ShuttingDownEventHandler ShuttingDown
	{
		[CompilerGenerated]
		add
		{
			ShuttingDownEventHandler shuttingDownEventHandler = bf;
			ShuttingDownEventHandler shuttingDownEventHandler2;
			do
			{
				shuttingDownEventHandler2 = shuttingDownEventHandler;
				ShuttingDownEventHandler value2 = (ShuttingDownEventHandler)Delegate.Combine(shuttingDownEventHandler2, value);
				shuttingDownEventHandler = Interlocked.CompareExchange(ref bf, value2, shuttingDownEventHandler2);
			}
			while ((object)shuttingDownEventHandler != shuttingDownEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			ShuttingDownEventHandler shuttingDownEventHandler = bf;
			ShuttingDownEventHandler shuttingDownEventHandler2;
			do
			{
				shuttingDownEventHandler2 = shuttingDownEventHandler;
				ShuttingDownEventHandler value2 = (ShuttingDownEventHandler)Delegate.Remove(shuttingDownEventHandler2, value);
				shuttingDownEventHandler = Interlocked.CompareExchange(ref bf, value2, shuttingDownEventHandler2);
			}
			while ((object)shuttingDownEventHandler != shuttingDownEventHandler2);
		}
	}

	private static GraphicalUserInterfaceType d(bool A_0)
	{
		if (A_0)
		{
			return GraphicalUserInterfaceType.Standard;
		}
		return GraphicalUserInterfaceType.None;
	}

	private static GraphicalUserInterfaceStartupState c(bool A_0)
	{
		if (A_0)
		{
			return GraphicalUserInterfaceStartupState.Shown;
		}
		return GraphicalUserInterfaceStartupState.Hidden;
	}

	public FIRemote()
	{
		a0 = new Collection<r.d>();
		a1 = new Collection<r.d>();
		a2 = new Collection<r.d>();
		a3 = new Collection<r.d>();
		a4 = new float[checked(Enum.GetValues(typeof(h.h)).GetUpperBound(0) + 1)];
		GraphicalUserInterfaceType a_ = d(A_0: true);
		GraphicalUserInterfaceStartupState a_2 = c(A_0: true);
		ConstructorWarning A_ = ConstructorWarning.None;
		string A_2 = null;
		a(a_, a_2, FormWindowState.Maximized, A_3: false, ref A_, ref A_2);
	}

	public FIRemote(bool showGUI)
	{
		a0 = new Collection<r.d>();
		a1 = new Collection<r.d>();
		a2 = new Collection<r.d>();
		a3 = new Collection<r.d>();
		a4 = new float[checked(Enum.GetValues(typeof(h.h)).GetUpperBound(0) + 1)];
		GraphicalUserInterfaceType a_ = d(showGUI);
		GraphicalUserInterfaceStartupState a_2 = c(showGUI);
		ConstructorWarning A_ = ConstructorWarning.None;
		string A_2 = null;
		a(a_, a_2, FormWindowState.Maximized, A_3: false, ref A_, ref A_2);
	}

	public FIRemote(bool showGUI, ref ConstructorWarning theConstructorWarning, ref string warningMessage)
	{
		a0 = new Collection<r.d>();
		a1 = new Collection<r.d>();
		a2 = new Collection<r.d>();
		a3 = new Collection<r.d>();
		a4 = new float[checked(Enum.GetValues(typeof(h.h)).GetUpperBound(0) + 1)];
		a(d(showGUI), c(showGUI), FormWindowState.Maximized, A_3: true, ref theConstructorWarning, ref warningMessage);
	}

	public FIRemote(GraphicalUserInterfaceType guiType, GraphicalUserInterfaceStartupState guiStartupState, FormWindowState guiWindowStartupState, ref ConstructorWarning theConstructorWarning, ref string warningMessage)
	{
		a0 = new Collection<r.d>();
		a1 = new Collection<r.d>();
		a2 = new Collection<r.d>();
		a3 = new Collection<r.d>();
		a4 = new float[checked(Enum.GetValues(typeof(h.h)).GetUpperBound(0) + 1)];
		a(guiType, guiStartupState, guiWindowStartupState, A_3: true, ref theConstructorWarning, ref warningMessage);
	}

	private void a(GraphicalUserInterfaceType A_0, GraphicalUserInterfaceStartupState A_1, FormWindowState A_2, bool A_3, ref ConstructorWarning A_4, ref string A_5)
	{
		string A_6 = null;
		A_4 = ConstructorWarning.None;
		am = false;
		w = new Dictionary<Guid, AutoResetEvent>();
		x = new Dictionary<Guid, AutoResetEvent>();
		y = new Dictionary<Guid, AutoResetEvent>();
		z = new Dictionary<Guid, AutoResetEvent>();
		aa = new Dictionary<Guid, AutoResetEvent>();
		ab = new Dictionary<Guid, AutoResetEvent>();
		ac = new Dictionary<Guid, AutoResetEvent>();
		ad = new Dictionary<Guid, AutoResetEvent>();
		ag = new AutoResetEvent(initialState: false);
		ae = new Dictionary<Guid, AutoResetEvent>();
		af = new Dictionary<Guid, AutoResetEvent>();
		mSpecCompletionTask = new r.d();
		mSystemSpecCompletionTask = new r.d();
		mSpecAnalysisCompletionTask = new r.d();
		mSetupCompletionTask = new r.d();
		mSystemSetupCompletionTask = new r.d();
		mIOCompletionTask = new r.d();
		s = new Dictionary<Guid, r.g.a>();
		mSpecTemperatureUpdateTask = new r.d();
		t = new Dictionary<Guid, r.g.a>();
		mHCTBaselineTask = new r.d();
		ai = new AutoResetEvent(initialState: false);
		bool flag = default(bool);
		if (A_0 != GraphicalUserInterfaceType.None)
		{
			ar = A_2;
			@as = A_1 == GraphicalUserInterfaceStartupState.Shown;
			ao = new Thread(g);
			ao.SetApartmentState(ApartmentState.STA);
			ao.Start();
		}
		else
		{
			this.m_m = false;
			mMeasTerminatorCompletionTask = new r.d();
			this.m_n = new r.l();
			this.m_n.m = mMeasTerminatorCompletionTask;
			o = false;
			mAcqTerminatorCompletionTask = new r.d();
			p = new r.l();
			p.m = mAcqTerminatorCompletionTask;
			if (!global::c.d().t())
			{
				throw new Exception("Hardware is not accessible because another application is using it");
			}
			global::c.d().ab();
			fz A_7 = null;
			this.m_k = new f1(ref A_7, ref A_6);
			global::c.d().c(A_7);
			flag = !string.IsNullOrEmpty(A_6);
			fz a_ = A_7;
			bool a_2 = this.m_k.ug();
			hd a_3 = q;
			string A_8 = null;
			az = new gr(a_, a_2, A_2: false, a_3, ref A_8);
			mSystemInitializeCompletionTask = new r.d();
			mInitStatus = new r.c();
			string A_9 = "";
			f1 obj = this.m_k;
			A_8 = "SystemInitialization";
			if (obj.m2(null, hu.a(ref A_8), ref A_9, mSystemInitializeCompletionTask, mInitStatus, global::r.d.a.b.b) != ce.ErrPublic.None)
			{
				throw new Exception("Error Initializing the FIRemote: " + A_9);
			}
		}
		if (!ag.WaitOne(80000, exitContext: false))
		{
			throw new TimeOutException("Error Initializing FIRemote: timed-out waiting for the application to initialize!", 80000);
		}
		if (!string.IsNullOrEmpty(ak))
		{
			throw new InitializationFailureException(ak);
		}
		A_5 = null;
		if (!aj && !flag && string.IsNullOrEmpty(ax))
		{
			return;
		}
		if (aj)
		{
			A_5 = "Warning: Error loading Startup Recipe. A different recipe may have been loaded";
		}
		if (!string.IsNullOrEmpty(A_6))
		{
			if (string.IsNullOrEmpty(A_5))
			{
				A_5 += "\r\n";
			}
			A_5 += A_6;
		}
		if (!string.IsNullOrEmpty(ak))
		{
			if (string.IsNullOrEmpty(A_5))
			{
				A_5 += "\r\n";
			}
			A_5 += ak;
		}
		if (!string.IsNullOrEmpty(ax))
		{
			if (string.IsNullOrEmpty(A_5))
			{
				A_5 += "\r\n";
			}
			A_5 += ax;
		}
		if (A_3)
		{
			if (aj)
			{
				A_4 = ConstructorWarning.StartupRecipeLoadFailure;
			}
			else if ((flag || !string.IsNullOrEmpty(ax)) && A_4 == ConstructorWarning.None)
			{
				A_4 = ConstructorWarning.Generic;
			}
			return;
		}
		throw new NonFatalWarningException(A_5);
	}

	protected void Dispose(bool disposing)
	{
		if (!am && disposing)
		{
			if (ap != null)
			{
				h();
			}
			else
			{
				this.m_k.tb();
				global::e.a().Save();
				bf?.Invoke();
			}
		}
		am = true;
	}

	private void h()
	{
		if (!an)
		{
			if (ap.InvokeRequired)
			{
				ap.Invoke(new a(h));
				return;
			}
			an = true;
			this.m_k.m2(A_0: true);
			ap.Close();
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void AcquireSpectrum(Guid measChannelGuid, ref float[] spectrumWavelengths, ref float[] spectrumData)
	{
		string a_ = global::a.l();
		string a_2 = global::e.a().OperatorID;
		Image A_ = null;
		float[] A_2 = null;
		float[] A_3 = null;
		bool A_4 = false;
		a(measChannelGuid, a_, a_2, A_3: true, ref spectrumWavelengths, ref spectrumData, ref A_, ref A_2, ref A_3, ref A_4);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void AcquireSpectrum(Guid measChannelGuid, ref float[] spectrumWavelengths, ref float[] spectrumData, ref Image sampleImage)
	{
		string a_ = global::a.l();
		string a_2 = global::e.a().OperatorID;
		float[] A_ = null;
		float[] A_2 = null;
		bool A_3 = false;
		a(measChannelGuid, a_, a_2, A_3: true, ref spectrumWavelengths, ref spectrumData, ref sampleImage, ref A_, ref A_2, ref A_3);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void AcquireSpectrum(Guid measChannelGuid, ref bool primarySpecIsReflectance, ref float[] spectrumWavelengths, ref float[] spectrumData)
	{
		string a_ = global::a.l();
		string a_2 = global::e.a().OperatorID;
		Image A_ = null;
		float[] A_2 = null;
		float[] A_3 = null;
		a(measChannelGuid, a_, a_2, A_3: true, ref spectrumWavelengths, ref spectrumData, ref A_, ref A_2, ref A_3, ref primarySpecIsReflectance);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void AcquireSpectrum(Guid measChannelGuid, ref float[] spectrumWavelengths, ref float[] spectrumData, bool flushPipeline)
	{
		string a_ = global::a.l();
		string a_2 = global::e.a().OperatorID;
		Image A_ = null;
		float[] A_2 = null;
		float[] A_3 = null;
		bool A_4 = false;
		a(measChannelGuid, a_, a_2, flushPipeline, ref spectrumWavelengths, ref spectrumData, ref A_, ref A_2, ref A_3, ref A_4);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void AcquireSpectrum(Guid measChannelGuid, ref float[] spectrumWavelengths, ref float[] spectrumData, bool flushPipeline, ref bool primarySpecIsReflectance)
	{
		string a_ = global::a.l();
		string a_2 = global::e.a().OperatorID;
		Image A_ = null;
		float[] A_2 = null;
		float[] A_3 = null;
		a(measChannelGuid, a_, a_2, flushPipeline, ref spectrumWavelengths, ref spectrumData, ref A_, ref A_2, ref A_3, ref primarySpecIsReflectance);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void AcquireSpectrum(Guid measChannelGuid, ref float[] spectrumWavelengths, ref float[] spectrumData, ref Image sampleImage, bool flushPipeline, ref bool primarySpecIsReflectance)
	{
		string a_ = global::a.l();
		string a_2 = global::e.a().OperatorID;
		float[] A_ = null;
		float[] A_2 = null;
		a(measChannelGuid, a_, a_2, flushPipeline, ref spectrumWavelengths, ref spectrumData, ref sampleImage, ref A_, ref A_2, ref primarySpecIsReflectance);
	}

	[EditorBrowsable(EditorBrowsableState.Always)]
	public void AcquireSpectrum(ref float[] spectrumWavelengths, ref float[] spectrumData)
	{
		string a_ = global::a.l();
		string a_2 = global::e.a().OperatorID;
		Image A_ = null;
		float[] A_2 = null;
		float[] A_3 = null;
		bool A_4 = false;
		a(a_, a_2, A_2: true, ref spectrumWavelengths, ref spectrumData, ref A_, ref A_2, ref A_3, ref A_4);
	}

	[EditorBrowsable(EditorBrowsableState.Always)]
	public void AcquireSpectrum(ref float[] spectrumWavelengths, ref float[] spectrumData, ref Image sampleImage)
	{
		string a_ = global::a.l();
		string a_2 = global::e.a().OperatorID;
		float[] A_ = null;
		float[] A_2 = null;
		bool A_3 = false;
		a(a_, a_2, A_2: true, ref spectrumWavelengths, ref spectrumData, ref sampleImage, ref A_, ref A_2, ref A_3);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void AcquireSpectrum(ref float[] spectrumWavelengths, ref float[] spectrumData, bool flushPipeline)
	{
		string a_ = global::a.l();
		string a_2 = global::e.a().OperatorID;
		Image A_ = null;
		float[] A_2 = null;
		float[] A_3 = null;
		bool A_4 = false;
		a(a_, a_2, flushPipeline, ref spectrumWavelengths, ref spectrumData, ref A_, ref A_2, ref A_3, ref A_4);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void AcquireSpectrum(ref float[] spectrumWavelengths, ref float[] spectrumData, ref float[] secondarySpecWavelengths, ref float[] secondarySpecData, ref bool primarySpecIsReflectance)
	{
		string a_ = global::a.l();
		string a_2 = global::e.a().OperatorID;
		Image A_ = null;
		a(a_, a_2, A_2: true, ref spectrumWavelengths, ref spectrumData, ref A_, ref secondarySpecWavelengths, ref secondarySpecData, ref primarySpecIsReflectance);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void AcquireSpectrum(ref float[] spectrumWavelengths, ref float[] spectrumData, float[] secondarySpecWavelengths, ref float[] secondarySpecData, bool flushPipeline, ref bool primarySpecIsReflectance)
	{
		string a_ = global::a.l();
		string a_2 = global::e.a().OperatorID;
		Image A_ = null;
		a(a_, a_2, flushPipeline, ref spectrumWavelengths, ref spectrumData, ref A_, ref secondarySpecWavelengths, ref secondarySpecData, ref primarySpecIsReflectance);
	}

	public void AcquireSpectrum(ref float[] spectrumWavelengths, ref float[] spectrumData, ref Image sampleImage, float[] secondarySpecWavelengths, ref float[] secondarySpecData, bool flushPipeline, ref bool primarySpecIsReflectance)
	{
		a(global::a.l(), global::e.a().OperatorID, flushPipeline, ref spectrumWavelengths, ref spectrumData, ref sampleImage, ref secondarySpecWavelengths, ref secondarySpecData, ref primarySpecIsReflectance);
	}

	public void ActivateChannelDisplayTab(Guid measChannelGuid)
	{
		if (ap != null)
		{
			ap.c(measChannelGuid.ToString());
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void ActivateMonitorDisplayTab()
	{
		if (ap == null)
		{
			return;
		}
		Collection<Guid> measSystemGuids = MeasSystemGuids;
		if (measSystemGuids.Count == 0)
		{
			throw new IllegalCommandException("No monitor tab is present");
		}
		if (measSystemGuids.Count == 1)
		{
			ap.b(measSystemGuids[0]);
			return;
		}
		ix.b b10 = new ix.b();
		Guid a_ = ap.c(b10);
		if (b10.a)
		{
			throw new IllegalCommandException("If History tab is active and more than one system exists, then systemGuid must be specified");
		}
		ap.b(a_);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void ActivateMonitorDisplayTab(Guid measSystemGuid)
	{
		if (ap != null)
		{
			ap.b(measSystemGuid);
		}
	}

	public FIMeasResults AnalyzeSpectrum(Guid measChannelGuid, bool formatSummaryAsRtf)
	{
		return AnalyzeSpectrum(measChannelGuid, formatSummaryAsRtf, addToHistory: true);
	}

	public FIMeasResults AnalyzeSpectrum(bool formatSummaryAsRtf)
	{
		return AnalyzeSpectrum(ActiveMeasModuleOnlyGuid, formatSummaryAsRtf, addToHistory: true);
	}

	public FIMeasResults AnalyzeSpectrum(bool formatSummaryAsRtf, bool addToHistory)
	{
		return AnalyzeSpectrum(ActiveMeasModuleOnlyGuid, formatSummaryAsRtf, addToHistory);
	}

	public FIMeasResults AnalyzeSpectrum(Guid measChannelGuid, bool formatSummaryAsRtf, bool addToHistory)
	{
		string A_ = "";
		string a_ = measChannelGuid.ToString();
		c(measChannelGuid);
		if (v == null)
		{
			throw new IllegalCommandException("There is no spectrum to analyze. You must call AcquireSpectrum or Measure before calling AnalyzeSpectrum");
		}
		f();
		e();
		ce.ErrPublic errPublic = this.m_k.m2(a_, "Analyzing Spectrum...", ref A_, mSpecAnalysisCompletionTask, null, v, 7, global::r.d.a.b.b, addToHistory, A_9: false);
		if (errPublic != ce.ErrPublic.None)
		{
			int num = (int)errPublic;
			throw new TaskAttemptFailureException("Error code=" + num);
		}
		if (!aa[measChannelGuid].WaitOne(60000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for spectrum analysis", 60000);
		}
		if (au.a != global::r.d.a.a.a)
		{
			throw new SpectrumAnalysisException(au.b);
		}
		return d(measChannelGuid, formatSummaryAsRtf);
	}

	public void AuthenticateRefBac()
	{
		AuthenticateRefBac(ActiveMeasModuleOrSystemGuid);
	}

	public void AuthenticateRefBac(Guid measChannelOrSystemGuid)
	{
		c(measChannelOrSystemGuid, A_1: false);
	}

	public void BaselineAcquireSpectrumFromSample()
	{
		BaselineAcquireSpectrumFromSample(ActiveMeasModuleOrSystemGuid);
	}

	public void BaselineAcquireSpectrumFromSample(Guid measChannelOrSystemGuid)
	{
		b(measChannelOrSystemGuid, A_1: false);
	}

	public bool BaselineExistsAndIsAuthenticated(ref bool authenticationIsPossible)
	{
		return BaselineExistsAndIsAuthenticated(ActiveMeasModuleOrSystemGuid, ref authenticationIsPossible);
	}

	public bool BaselineExistsAndIsAuthenticated(Guid measChannelOrSystemGuid, ref bool authenticationIsPossible)
	{
		bool A_ = false;
		a(measChannelOrSystemGuid, ref A_);
		if (!this.m_k.so(measChannelOrSystemGuid, A_1: false) || !this.m_k.s8(measChannelOrSystemGuid, A_1: false) || !this.m_k.sn(measChannelOrSystemGuid, A_1: false) || !this.m_k.s6(measChannelOrSystemGuid, A_1: false) || !this.m_k.s4(measChannelOrSystemGuid, A_1: false) || !this.m_k.s3(measChannelOrSystemGuid, A_1: false))
		{
			if (this.m_k.s3(measChannelOrSystemGuid, A_1: false) && this.m_k.s8(measChannelOrSystemGuid, A_1: false) && this.m_k.s4(measChannelOrSystemGuid, A_1: false) && this.m_k.s6(measChannelOrSystemGuid, A_1: false))
			{
				return true;
			}
			return false;
		}
		return true;
	}

	public void BaselineAcquireReference()
	{
		b(ActiveMeasModuleOrSystemGuid, 0, A_2: false, A_3: false, a4, "BaselineAcquireReference", A_6: false);
	}

	public void BaselineAcquireReference(Guid measChannelOrSystemGuid)
	{
		b(measChannelOrSystemGuid, 0, A_2: false, A_3: false, a4, "BaselineAcquireReference", A_6: false);
	}

	public void BaselineAcquireReference(float userSuppliedReflectance)
	{
		float[] array = new float[checked(Enum.GetValues(typeof(h.h)).GetUpperBound(0) + 1)];
		array[0] = userSuppliedReflectance;
		array[1] = userSuppliedReflectance;
		b(ActiveMeasModuleOrSystemGuid, 0, A_2: true, A_3: false, array, "BaselineAcquireReference", A_6: false);
	}

	public void BaselineAcquireReference(Guid measChannelOrSystemGuid, float userSuppliedReflectance)
	{
		float[] array = new float[checked(Enum.GetValues(typeof(h.h)).GetUpperBound(0) + 1)];
		array[0] = userSuppliedReflectance;
		array[1] = userSuppliedReflectance;
		b(measChannelOrSystemGuid, 0, A_2: true, A_3: false, array, "BaselineAcquireReference", A_6: false);
	}

	public void BaselineAcquireReference(int referenceNumber)
	{
		b(ActiveMeasModuleOrSystemGuid, checked(referenceNumber - 1), A_2: false, A_3: false, a4, "BaselineAcquireReference", A_6: false);
	}

	public void BaselineAcquireReference(Guid measChannelOrSystemGuid, int referenceNumber)
	{
		b(measChannelOrSystemGuid, checked(referenceNumber - 1), A_2: false, A_3: false, a4, "BaselineAcquireReference", A_6: false);
	}

	public void BaselineAcquireReference(float userSuppliedReflectance, int referenceNumber)
	{
		checked
		{
			float[] array = new float[Enum.GetValues(typeof(h.h)).GetUpperBound(0) + 1];
			array[0] = userSuppliedReflectance;
			array[1] = userSuppliedReflectance;
			b(ActiveMeasModuleOrSystemGuid, referenceNumber - 1, A_2: true, A_3: false, array, "BaselineAcquireReference", A_6: false);
		}
	}

	public void BaselineAcquireReference(Guid measChannelOrSystemGuid, float userSuppliedReflectance, int referenceNumber)
	{
		checked
		{
			float[] array = new float[Enum.GetValues(typeof(h.h)).GetUpperBound(0) + 1];
			array[0] = userSuppliedReflectance;
			array[1] = userSuppliedReflectance;
			b(measChannelOrSystemGuid, referenceNumber - 1, A_2: true, A_3: false, array, "BaselineAcquireReference", A_6: false);
		}
	}

	public void BaselineAcquireReferenceT()
	{
		BaselineAcquireReferenceT(ActiveMeasModuleOrSystemGuid);
	}

	public void BaselineAcquireReferenceT(Guid measChannelOrSystemGuid)
	{
		if (this.m_k.vl(measChannelOrSystemGuid))
		{
			if (this.m_k.vo(measChannelOrSystemGuid).a(this.m_k.va(measChannelOrSystemGuid)) == global::h.e.c)
			{
				BaselineAcquireReference(measChannelOrSystemGuid);
			}
			else
			{
				a(measChannelOrSystemGuid, A_1: true, A_2: false);
			}
			return;
		}
		throw new IncompatibleHardwareException("The BaselineAcquireReferenceT method cannot be called for the currently selected hardware");
	}

	public void BaselineAcquireReferenceUsingOldSampleReflectance(Guid measChannelOrSystemGuid)
	{
		b(measChannelOrSystemGuid, 0, A_2: true, A_3: true, a4, "BaselineAcquireReferenceUsingOldSampleReflectance", A_6: false);
	}

	public void BaselineAcquireReferenceUsingOldSampleReflectance()
	{
		b(ActiveMeasModuleOrSystemGuid, 0, A_2: true, A_3: true, a4, "BaselineAcquireReferenceUsingOldSampleReflectance", A_6: false);
	}

	public void BaselineAcquireReferenceUsingOldSampleReflectance(Guid measChannelOrSystemGuid, int referenceNumber)
	{
		b(measChannelOrSystemGuid, checked(referenceNumber - 1), A_2: true, A_3: true, a4, "BaselineAcquireReferenceUsingOldSampleReflectance", A_6: false);
	}

	public void BaselineAcquireReferenceUsingOldSampleReflectance(int referenceNumber)
	{
		b(ActiveMeasModuleOrSystemGuid, checked(referenceNumber - 1), A_2: true, A_3: true, a4, "BaselineAcquireReferenceUsingOldSampleReflectance", A_6: false);
	}

	public void BaselineAcquireBackgroundAfterRef()
	{
		a(ActiveMeasModuleOrSystemGuid, A_1: false, A_2: true);
	}

	public void BaselineAcquireBackgroundAfterRef(Guid measChannelOrSystemGuid)
	{
		a(measChannelOrSystemGuid, A_1: false, A_2: true);
	}

	public void BaselineCommit()
	{
		BaselineCommit(ActiveMeasModuleOrSystemGuid);
	}

	public void BaselineCommit(Guid measChannelOrSystemGuid)
	{
		a(measChannelOrSystemGuid, A_1: false);
	}

	public void BaselineSetRefMat(string theRefMat)
	{
		BaselineSetRefMat(ActiveMeasModuleOrSystemGuid, theRefMat);
	}

	public void BaselineSetRefMat(Guid measChannelOrSystemGuid, string theRefMat)
	{
		if (this.m_k.u8(measChannelOrSystemGuid) == g2.a.m)
		{
			throw new IncompatibleHardwareException("The BaselineSetRefMat method cannot be called for the currently selected optics config");
		}
		bool A_ = false;
		a(measChannelOrSystemGuid, ref A_);
		bool A_2 = default(bool);
		this.m_k.m2(measChannelOrSystemGuid, theRefMat, A_2: false, global::r.d.a.b.b, ref A_2);
		if (A_2)
		{
			throw new ArgumentException("Bad reference material. File may be missing or corrupted.", "theRefMat");
		}
	}

	public void BaselineShowDialog(ref bool dialogCanceled)
	{
		Guid guid = ActiveMeasModuleOnlyGuid;
		f4 a_ = ap.c(guid);
		ix.b b10 = new ix.b();
		if (false)
		{
			ActivateChannelDisplayTab(guid);
		}
		ix.b b11 = new ix.b();
		ix.e e10 = new ix.e();
		this.m_k.m2(guid, az, a_, new Point(0, 0), b10, A_5: false, global::r.d.a.b.b, b11, e10);
		if (b11.a)
		{
			throw new IllegalCommandException(e10.a);
		}
		dialogCanceled = b10.a;
	}

	public BaselineHardwareAdjustStatus GetBaselineHardwareAdjustStatus()
	{
		return GetBaselineHardwareAdjustStatus(ActiveMeasModuleOrSystemGuid);
	}

	public BaselineHardwareAdjustStatus GetBaselineHardwareAdjustStatus(Guid measChannelOrSystemGuid)
	{
		BaselineHardwareAdjustStatus baselineHardwareAdjustStatus = new BaselineHardwareAdjustStatus();
		bool A_ = false;
		a(measChannelOrSystemGuid, ref A_);
		BaselineHardwareAdjustStatus baselineHardwareAdjustStatus2 = baselineHardwareAdjustStatus;
		this.m_k.m2(measChannelOrSystemGuid, ref baselineHardwareAdjustStatus2.NeedsPeriodicAdjustment, ref baselineHardwareAdjustStatus2.AdjustmentRequiredNow, ref baselineHardwareAdjustStatus2.AdjustmentRecommendedNow, ref baselineHardwareAdjustStatus2.AdjustmentPeriodHours, ref baselineHardwareAdjustStatus2.TimeToNextRecommendedAdjustmentHours);
		baselineHardwareAdjustStatus2 = null;
		return baselineHardwareAdjustStatus;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void GeneralPurposeIOSetValue(byte newValue)
	{
		a(ActiveMeasModuleOnlyGuid, newValue);
	}

	private void a(Guid A_0, byte A_1)
	{
		a(A_0, 0);
		if (!this.GeneralPurposeIOIsSupported)
		{
			throw new IllegalCommandException("General Purpose IO not supported by hardware");
		}
		lock (ae[A_0])
		{
			this.m_k.m2(A_0, A_1, mIOCompletionTask, global::r.d.a.b.b);
			ae[A_0].WaitOne();
			try
			{
				if (((r.d.a)s[A_0]).a != global::r.d.a.a.a)
				{
					throw new OperationFailedException("Failure attempting GeneralPurposeIOReadValue");
				}
				_ = null;
			}
			finally
			{
				s.Remove(A_0);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public byte GeneralPurposeIOReadValue()
	{
		return g(ActiveMeasModuleOnlyGuid);
	}

	private byte g(Guid A_0)
	{
		a(A_0, 0);
		if (!this.GeneralPurposeIOIsSupported)
		{
			throw new IllegalCommandException("General Purpose IO not supported by hardware");
		}
		lock (ae[A_0])
		{
			this.m_k.s3(A_0, mIOCompletionTask, global::r.d.a.b.b);
			ae[A_0].WaitOne();
			try
			{
				if (((r.d.a)s[A_0]).a != global::r.d.a.a.a)
				{
					throw new OperationFailedException("Failure attempting GeneralPurposeIOReadValue");
				}
				return s[A_0].t;
			}
			finally
			{
				s.Remove(A_0);
			}
		}
	}

	public void HistoryDeleteAllResults()
	{
		if (ap != null)
		{
			ap.ef();
		}
	}

	public FIMeasResults Measure(Guid measChannelGuid, bool formatSummaryAsRtf)
	{
		return b(measChannelGuid, global::a.l(), global::e.a().OperatorID, formatSummaryAsRtf, A_4: true, A_5: true);
	}

	public FIMeasResults Measure(bool formatSummaryAsRtf)
	{
		return b(ActiveMeasModuleOnlyGuid, global::a.l(), global::e.a().OperatorID, formatSummaryAsRtf, A_4: true, A_5: true);
	}

	public FIMeasResults Measure(bool formatSummaryAsRtf, bool addToHistory, bool flushPipeline)
	{
		return b(ActiveMeasModuleOnlyGuid, global::a.l(), global::e.a().OperatorID, formatSummaryAsRtf, A_4: true, flushPipeline);
	}

	public FIMeasResults Measure(Guid measChannelGuid, bool formatSummaryAsRtf, bool addToHistory)
	{
		return b(measChannelGuid, global::a.l(), global::e.a().OperatorID, formatSummaryAsRtf, addToHistory, A_5: true);
	}

	public FIMeasResults Measure(Guid measChannelGuid, bool formatSummaryAsRtf, bool addToHistory, bool flushPipeline)
	{
		return b(measChannelGuid, global::a.l(), global::e.a().OperatorID, formatSummaryAsRtf, addToHistory, A_5: true);
	}

	public FIMeasResults Measure(bool formatSummaryAsRtf, bool addToHistory)
	{
		return b(ActiveMeasModuleOnlyGuid, global::a.l(), global::e.a().OperatorID, formatSummaryAsRtf, addToHistory, A_5: true);
	}

	public void OpenSpectrum(string filenameAndPath)
	{
		OpenSpectrum(filenameAndPath, ActiveMeasModuleOnlyGuid);
	}

	public void OpenSpectrum(string filenameAndPath, Guid measChannelGuid)
	{
		hr hr2 = this.m_k.m2(filenameAndPath, global::e.a().OperatorID, null);
		f1 obj = this.m_k;
		string a_ = hr2.b5();
		string a_2 = global::e.a().OperatorID;
		string A_ = null;
		obj.m2(measChannelGuid, a_, a_2, null, ref A_, new r.d(), null, global::r.d.a.b.b, 0, hr2);
	}

	public void OpenSpectrumFromBuffer(byte[] theBuffer)
	{
		OpenSpectrumFromBuffer(theBuffer, ActiveMeasModuleOnlyGuid);
	}

	public void OpenSpectrumFromBuffer(byte[] theBuffer, Guid measChannelGuid)
	{
		hr hr2 = new hr(null);
		MemoryStream memoryStream = null;
		BinaryReader A_ = null;
		try
		{
			memoryStream = new MemoryStream(theBuffer);
			A_ = new BinaryReader(memoryStream);
			hr2.l(ref A_);
			f1 obj = this.m_k;
			string a_ = hr2.b5();
			string a_2 = global::e.a().OperatorID;
			string A_2 = null;
			obj.m2(measChannelGuid, a_, a_2, null, ref A_2, new r.d(), null, global::r.d.a.b.b, 0, hr2);
		}
		finally
		{
			A_?.Close();
			memoryStream?.Close();
		}
	}

	private void c(Guid A_0, string A_1)
	{
		if (ap.InvokeRequired)
		{
			ap.Invoke(new b(c), A_0, A_1);
		}
		else
		{
			ap.e(A_0, A_1, A_2: false);
			ap.d(A_0, A_1, A_2: false);
		}
	}

	private void b(Guid A_0, string A_1)
	{
		if (ap.InvokeRequired)
		{
			ap.Invoke(new c(b), A_0, A_1);
		}
		else
		{
			ap.e(A_0, A_1, A_2: true);
			ap.d(A_0, A_1, A_2: true);
		}
	}

	public void SetAutoFocus(bool value)
	{
		Guid guid = e(ActiveMeasModuleOnlyGuid);
		c(guid);
		a(guid, "SetAutoFocus");
		hg obj = this.m_k.t0(guid.ToString());
		obj.b8().d().a = value;
		obj.bv(mSetupCompletionTask, A_1: true);
		if (!ac[guid].WaitOne(2000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for SetAutoFocus setting to be applied", 2000);
		}
		if (aw != global::r.d.a.a.a)
		{
			throw new SetupFailureException(ax);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void SaveImage(string filenameAndPath)
	{
		a("SaveImage");
		if (v.bp() == null)
		{
			throw new IllegalCommandException("The spectrum has no image. You must call acquire a spectrum with an image before calling SaveImage");
		}
		Image image = v.bp().l();
		new Bitmap(image, image.Width, image.Height).Save(filenameAndPath);
	}

	public void SaveSpectrum(string filenameAndPath)
	{
		SaveSpectrum(filenameAndPath, ifTextFormatWriteYDataAsPercent: true);
	}

	public void SaveSpectrum(string filenameAndPath, bool ifTextFormatWriteYDataAsPercent)
	{
		a("SaveSpectrum");
		string text = Path.GetExtension(filenameAndPath).ToLower();
		if ((Operators.CompareString(text, ".fmdmo", TextCompare: false) != 0 || this.m_k.ui()) && (Operators.CompareString(text, ".dat", TextCompare: false) != 0 || this.m_k.ui() || this.m_k.uq()))
		{
			switch (text)
			{
			case ".fmspe":
			case ".spe":
			case ".txt":
			case ".csv":
			case ".fmdmo":
			case ".dat":
			{
				hr hr2 = v;
				string A_ = null;
				Collection<string> A_2 = null;
				Collection<string> A_3 = null;
				hr2.r(ref A_, ref A_2, ref A_3);
				hr2.r(ref filenameAndPath, hr2.bz(), hr2.by(), A_, A_2, A_3, ifTextFormatWriteYDataAsPercent, global::e.a().UniformSpectrumDataPointSpacing, global::e.a().UniformSpectrumDataFinePointSpacing);
				hr2 = null;
				return;
			}
			}
		}
		throw new IllegalCommandException(text + " is not a valid spectrum file type.");
	}

	public byte[] SaveSpectrumToBuffer()
	{
		a("SaveSpectrumToBuffer");
		hr hr2 = v;
		MemoryStream memoryStream = null;
		BinaryWriter A_ = null;
		byte[] result;
		try
		{
			memoryStream = new MemoryStream();
			A_ = new BinaryWriter(memoryStream);
			hr2.m(ref A_);
			result = memoryStream.ToArray();
		}
		finally
		{
			A_?.Close();
			memoryStream?.Close();
		}
		hr2 = null;
		return result;
	}

	public void SetN(int layerNumber, float refractiveIndex)
	{
		SetN(ActiveMeasModuleOrSystemGuid, layerNumber, refractiveIndex);
	}

	public void SetN(Guid measChannelOrSystemGuid, int layerNumber, float refractiveIndex)
	{
		a(measChannelOrSystemGuid, layerNumber, "Generic, n=" + refractiveIndex.ToString(CultureInfo.InvariantCulture), "SetN");
	}

	public void SetMaterial(int layerNumber, string materialName)
	{
		SetMaterial(ActiveMeasModuleOrSystemGuid, layerNumber, materialName);
	}

	public void SetMaterial(Guid measChannelOrSystemGuid, int layerNumber, string materialName)
	{
		a(measChannelOrSystemGuid, layerNumber, materialName, "SetMaterial");
	}

	public void SetRecipe(string recipeName)
	{
		SetRecipe(ActiveMeasModuleOrSystemGuid, recipeName);
	}

	public void SetRecipe(Guid measChannelOrSystemGuid, string recipeName)
	{
		a(measChannelOrSystemGuid, recipeName, A_2: false, A_3: false);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void SetRecipeThickness(string recipeName)
	{
		a(ActiveMeasModuleOrSystemGuid, recipeName, A_2: true, A_3: false);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void SetRecipeThickness(Guid measChannelOrSystemGuid, string recipeName)
	{
		a(measChannelOrSystemGuid, recipeName, A_2: true, A_3: false);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void SetRecipeSpectrumAnalysis(string recipeName)
	{
		a(ActiveMeasModuleOrSystemGuid, recipeName, A_2: true, A_3: true);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void SetRecipeSpectrumAnalysis(Guid measChannelOrSystemGuid, string recipeName)
	{
		a(measChannelOrSystemGuid, recipeName, A_2: true, A_3: true);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void SetRecipeModeToSpectrumAnalysis()
	{
		SetRecipeModeToSpectrumAnalysis(ActiveMeasModuleOrSystemGuid);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void SetRecipeModeToSpectrumAnalysis(Guid measChannelOrSystemGuid)
	{
		e(measChannelOrSystemGuid, A_1: true);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void SetRecipeModeToThickness()
	{
		SetRecipeModeToThickness(ActiveMeasModuleOrSystemGuid);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void SetRecipeModeToThickness(Guid measChannelOrSystemGuid)
	{
		e(measChannelOrSystemGuid, A_1: false);
	}

	private void e(Guid A_0, bool A_1)
	{
		if (this.get_RecipeInfo(A_0).TypeIsSpectrumAnalysis != A_1)
		{
			string text = this.m_k.m2(A_0, A_1, A_2: false);
			int length = hg.b0().Length;
			string a_ = text.Substring(length, checked(text.Length - length - Path.GetExtension(text).Length));
			a(A_0, a_, A_2: true, A_1);
		}
	}

	private void a(Guid A_0, string A_1, bool A_2, bool A_3)
	{
		Guid guid = e(A_0);
		c(guid);
		a(guid, "SetRecipe");
		hg hg2 = this.m_k.wq(guid);
		bool flag;
		if (A_2)
		{
			a(A_3);
			flag = A_3;
		}
		else
		{
			flag = hg2.b5();
		}
		string text = ((!flag) ? (hg.b0() + A_1 + ".fitrp") : (hg.b0() + A_1 + ".fitra"));
		if (!File.Exists(text))
		{
			throw new FileNotFoundException(A_1);
		}
		hg A_4 = null;
		hg2.bu(ref A_4);
		if (!A_4.bu(text, hg.b4(), mSetupCompletionTask, global::r.d.a.b.b, A_4: true, A_5: false, default(Point), null, this.m_k.w9(guid), !this.m_k.w6(guid), null, this.m_k.xk(guid), A_12: false, A_13: false, null, A_15: false))
		{
			throw new ApplicationException("Error attempting to load " + A_1);
		}
		this.m_k.m2(guid, A_4, mSetupCompletionTask, A_3: true);
		if (!ac[guid].WaitOne(2000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for SetRecipe to complete", 2000);
		}
		if (aw != global::r.d.a.a.a)
		{
			throw new SetupFailureException(ax);
		}
	}

	public void SetRoughness(int layerNumber, float roughness_nm)
	{
		SetRoughness(ActiveMeasModuleOrSystemGuid, layerNumber, roughness_nm);
	}

	public void SetRoughness(Guid measChannelOrSystemGuid, int layerNumber, float roughness_nm)
	{
		Guid guid = e(measChannelOrSystemGuid);
		c(guid);
		a(guid, "SetRoughness");
		hg obj = this.m_k.t0(guid.ToString());
		int num = checked(obj.ed().hh() - 2);
		if (layerNumber <= 0 || layerNumber > num)
		{
			throw new ArgumentException("Layer Number must be >0 and <= " + num, "layerNumber");
		}
		if (roughness_nm < 0f)
		{
			throw new ArgumentException("Roughness must be >=0", "roughness_nm");
		}
		obj.ed().et(layerNumber).aj(roughness_nm);
		obj.bu(mSetupCompletionTask, A_1: false);
		if (!ac[guid].WaitOne(2000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for layer roughness setting to be applied", 2000);
		}
		if (aw != global::r.d.a.a.a)
		{
			throw new SetupFailureException(ax);
		}
	}

	public void SetThickness(int layerNumber, float thickness_nm)
	{
		SetThickness(ActiveMeasModuleOrSystemGuid, layerNumber, thickness_nm);
	}

	public void SetThickness(Guid measChannelOrSystemGuid, int layerNumber, float thickness_nm)
	{
		Guid guid = e(measChannelOrSystemGuid);
		c(guid);
		a(guid, "SetThickness");
		hg hg2 = this.m_k.t0(guid.ToString());
		int num = checked(hg2.ed().hh() - 2);
		if (layerNumber <= 0 || layerNumber > num)
		{
			throw new ArgumentException("Layer Number must be >0 and <= " + num, "layerNumber");
		}
		if (thickness_nm < 0f)
		{
			throw new ArgumentException("Thickness must be >=0", "thickness_nm");
		}
		hg2.ed().et(layerNumber).af(hg2.co(), hg2.cp(), thickness_nm);
		hg2.bu(mSetupCompletionTask, A_1: false);
		if (!ac[guid].WaitOne(2000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for layer thickness setting to be applied", 2000);
		}
		if (aw != global::r.d.a.a.a)
		{
			throw new SetupFailureException(ax);
		}
	}

	public void SetThicknessRange(int layerNumber, double thicknessRangePercent)
	{
		SetThicknessRange(ActiveMeasModuleOrSystemGuid, layerNumber, thicknessRangePercent);
	}

	public void SetThicknessRange(Guid measChannelOrSystemGuid, int layerNumber, double thicknessRangePercent)
	{
		Guid guid = e(measChannelOrSystemGuid);
		c(guid);
		a(guid, "SetThicknessRange");
		hg obj = this.m_k.t0(guid.ToString());
		int num = checked(obj.ed().hh() - 2);
		if (layerNumber <= 0 || layerNumber > num)
		{
			throw new ArgumentException("Layer Number must be >0 and <= " + num, "layerNumber");
		}
		if (thicknessRangePercent < 0.0)
		{
			throw new ArgumentException("Thickness Range must be >=0", "thicknessRangePercent");
		}
		obj.ed().et(layerNumber).ak(thicknessRangePercent);
		obj.bu(mSetupCompletionTask, A_1: false);
		if (!ac[guid].WaitOne(2000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for layer thickness setting to be applied", 2000);
		}
		if (aw != global::r.d.a.a.a)
		{
			throw new SetupFailureException(ax);
		}
	}

	public void SetAnalysisWavelengthRange(float startWavelength_nm, float endWavelength_nm)
	{
		SetAnalysisWavelengthRange(ActiveMeasModuleOrSystemGuid, startWavelength_nm, endWavelength_nm);
	}

	public void SetAnalysisWavelengthRange(Guid measChannelOrSystemGuid, float startWavelength_nm, float endWavelength_nm)
	{
		Guid guid = e(measChannelOrSystemGuid);
		c(guid);
		a(guid, "SetThickness");
		hg obj = this.m_k.t0(guid.ToString());
		if (startWavelength_nm >= endWavelength_nm)
		{
			throw new ArgumentException("startWavelength_nm must be <= endWavelength_nm", "startWavelength/endWavelength");
		}
		hi obj2 = obj.ed();
		obj2.d7((double)startWavelength_nm);
		obj2.d6((double)endWavelength_nm);
		obj2.el(A_0: true);
		_ = null;
		obj.bv(mSetupCompletionTask, A_1: true);
		if (!ac[guid].WaitOne(2000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for start/end wavelength setting to be applied", 2000);
		}
		if (aw != global::r.d.a.a.a)
		{
			throw new SetupFailureException(ax);
		}
	}

	public void SetUseStandardAndBackground(bool useStandard, bool subtractBackground)
	{
		SetUseStandardAndBackground(ActiveMeasModuleOnlyGuid, useStandard, subtractBackground);
	}

	public void SetUseStandardAndBackground(Guid measChannelGuid, bool useStandard, bool subtractBackground)
	{
		c(measChannelGuid);
		a(measChannelGuid, "SetUseReferenceAndBackground");
		this.m_k.m2(measChannelGuid, useStandard, subtractBackground, A_3: false, A_4: false, mSetupCompletionTask, global::r.d.a.b.b);
		if (!ac[measChannelGuid].WaitOne(2000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for SetUseStandardAndBackground setting to be applied", 2000);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public FIMeasResultValuesOnly SystemMeasure()
	{
		return SystemMeasure(ActiveSystemGuid);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public FIMeasResultValuesOnly SystemMeasure(bool deleteAccumulatedDataBeforeMeasure)
	{
		return a(ActiveSystemGuid, "Unknown", "Unknown", A_3: true, A_4: true, deleteAccumulatedDataBeforeMeasure);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public FIMeasResultValuesOnly SystemMeasure(Guid systemGuid)
	{
		return a(systemGuid, "Unknown", "Unknown", A_3: true, A_4: true, A_5: false);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public FIMeasResultValuesOnly SystemMeasure(Guid systemGuid, bool deleteAccumulatedDataBeforeMeasure)
	{
		return a(systemGuid, "Unknown", "Unknown", A_3: true, A_4: true, deleteAccumulatedDataBeforeMeasure);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void SystemStartMonitoring()
	{
		SystemStartMonitoring(ActiveSystemGuid);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void SystemStartMonitoring(Guid systemGuid)
	{
		b(systemGuid);
		if (this.m_k.vx(systemGuid))
		{
			throw new IllegalCommandException("SystemStartMonitoring is not valid if monitoring is already active.");
		}
		if (this.m_k.u7(systemGuid))
		{
			throw new IllegalCommandException("SystemStartMonitoring is not valid if optics configuration mode includes AutoMeasure.");
		}
		this.m_k.m2(systemGuid, "Unknown", "Unknown", 7, global::r.d.a.b.b, A_5: true);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void SystemStopMonitoring()
	{
		SystemStopMonitoring(ActiveSystemGuid);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void SystemStopMonitoring(Guid systemGuid)
	{
		b(systemGuid);
		this.m_k.u3(systemGuid);
	}

	private void n(r.d.a A_0)
	{
		try
		{
			r.e.a a10 = (r.e.a)A_0;
			aj = a10.g == global::r.e.a.b.l;
			a10 = null;
			if (A_0.a != global::r.d.a.a.a)
			{
				return;
			}
			Collection<Guid> A_1 = null;
			a(ref A_1);
			if (A_1.Count == 0)
			{
				throw new InitializationFailureException("No Measurement Modules Present");
			}
			foreach (Guid item in A_1)
			{
				r.d a_ = new r.d();
				PictureBox pictureBox = new PictureBox();
				this.m_k.m2(item.ToString(), pictureBox.Handle, a_, global::r.d.a.b.b, this.m_k.t7(item.ToString()).ah());
			}
			this.m_k.p9(global::r.d.a.b.b);
			al = true;
		}
		finally
		{
			ag.Set();
		}
	}

	private void a(r.c A_0, bool A_1)
	{
	}

	private void a(ref Collection<Guid> A_0)
	{
		A_0 = this.m_k.tj();
		if (A_0.Count == 0)
		{
			throw new InitializationFailureException("No Measurement Modules Present");
		}
		foreach (Guid item in A_0)
		{
			w.Add(item, new AutoResetEvent(initialState: false));
			r.d d10 = this.m_k.v4(item);
			a0.Add(d10);
			d10.d((r.d.b)b);
			ab.Add(item, new AutoResetEvent(initialState: false));
			d10 = this.m_k.v8(item);
			a1.Add(d10);
			d10.d((r.d.b)a);
			x.Add(item, new AutoResetEvent(initialState: false));
			aa.Add(item, new AutoResetEvent(initialState: false));
			ac.Add(item, new AutoResetEvent(initialState: false));
			d10 = this.m_k.wb(item);
			a3.Add(d10);
			ae.Add(item, new AutoResetEvent(initialState: false));
			af.Add(item, new AutoResetEvent(initialState: false));
		}
		foreach (Guid item2 in this.m_k.tl())
		{
			this.m_k.m2(item2, a);
			y.Add(item2, new AutoResetEvent(initialState: false));
			ad.Add(item2, new AutoResetEvent(initialState: false));
			z.Add(item2, new AutoResetEvent(initialState: false));
			r.d d10 = this.m_k.wg(item2);
			a2.Add(d10);
			d10.d((r.d.b)f);
		}
		q = this.m_k.u8();
		this.m_k.tf("");
	}

	private void a(gg.b A_0, bool A_1, string A_2, gr A_3)
	{
		try
		{
			if (!string.IsNullOrEmpty(A_2))
			{
				return;
			}
			this.m_k = A_0.d();
			try
			{
				Collection<Guid> A_4 = null;
				a(ref A_4);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				if (string.IsNullOrEmpty(A_2))
				{
					A_2 = ex3.Message;
				}
				ProjectData.ClearProjectError();
			}
			mMeasTerminatorCompletionTask = new r.d();
			this.m_n = new r.l();
			this.m_n.m = mMeasTerminatorCompletionTask;
			mAcqTerminatorCompletionTask = new r.d();
			p = new r.l();
			p.m = mAcqTerminatorCompletionTask;
			q = A_0.f();
			aj = A_1;
			az = A_3;
			if (@as)
			{
				aq = true;
			}
			else
			{
				GUIVisible = false;
			}
			ap.c(a);
			ap.b(a);
		}
		finally
		{
			ak = A_2;
			al = true;
			ag.Set();
		}
	}

	private void g()
	{
		ap = new gg();
		if (@as)
		{
			ap.WindowState = ar;
		}
		else
		{
			ap.WindowState = FormWindowState.Minimized;
			ap.Opacity = 0.0;
			ap.ShowInTaskbar = false;
		}
		ap.c(A_0: true);
		bool A_ = default(bool);
		ap.b(a, ref A_);
		if (!A_)
		{
			global::c.d().j(A_0: true);
			Application.Run(ap);
		}
	}

	private void a(FormClosingEventArgs A_0)
	{
		if (!an)
		{
			be?.Invoke(A_0);
		}
		if (!A_0.Cancel)
		{
			an = true;
			bf?.Invoke();
		}
	}

	private h.f a(hg A_0, SubsystemMeasType A_1)
	{
		if (A_0.b8().t())
		{
			return global::h.f.a;
		}
		return a(A_1);
	}

	private h.f a(SubsystemMeasType A_0)
	{
		return A_0 switch
		{
			SubsystemMeasType.Transmittance => global::h.f.b, 
			SubsystemMeasType.ReflAtFirstAngle => global::h.f.c, 
			_ => global::h.f.a, 
		};
	}

	private string a(string A_0, string A_1, bool A_2)
	{
		string A_3 = null;
		string A_4 = null;
		string A_5 = null;
		string A_6 = null;
		string A_7 = null;
		string A_8 = null;
		cc.cf(ref A_4, ref A_5, ref A_6, ref A_3, ref A_7, ref A_8, ref A_2);
		if (A_2)
		{
			return A_0.Substring(0, checked(A_0.Length - 1)) + A_3 + A_1;
		}
		return A_0 + A_3 + A_1;
	}

	private FIMeasResults d(Guid A_0, bool A_1)
	{
		GC.Collect();
		GC.WaitForPendingFinalizers();
		if (u == null)
		{
			throw new SpectrumAnalysisException("Analysis completed with no results");
		}
		if (u.ad != global::r.i.a.a)
		{
			if (u.ad == global::r.i.a.c)
			{
				throw new SpectrumAnalysisException(u.ab.b9);
			}
			throw new SpectrumAnalysisException("Unknown failure in mLastSpectrumCalculatedTaskCompletionArgs.Result");
		}
		if (at != null && ((r.d.a)at).a != global::r.d.a.a.a)
		{
			throw new SpectrumAnalysisException(((r.d.a)at).b);
		}
		float[] A_2 = new float[1];
		float[] A_3 = new float[1];
		Image A_4 = null;
		hr hr2 = r.cn();
		FIMeasResults.AcqSpectrumType acqSpectrumType = (hr2.af() ? ((!hr2.ah()) ? FIMeasResults.AcqSpectrumType.CTMSignalRaw : FIMeasResults.AcqSpectrumType.CTMSignalMeas) : (hr2.ap() ? ((!hr2.ah()) ? FIMeasResults.AcqSpectrumType.TransmittanceRaw : FIMeasResults.AcqSpectrumType.TransmittanceMeas) : ((!hr2.ah()) ? FIMeasResults.AcqSpectrumType.ReflectanceRaw : FIMeasResults.AcqSpectrumType.ReflectanceMeas)));
		hr2 = null;
		a(r.cn(), ref A_2, ref A_3, ref A_4);
		List<FIMeasResults.ColorResults> list = null;
		if (r.co() != null)
		{
			list = new List<FIMeasResults.ColorResults>();
			foreach (cc.d item in r.co().e())
			{
				if ((global::a.n() == 0 && item.h() == global::a4.a.a) || (global::a.n() == 2 && item.h() == global::a4.a.c) || (global::a.n() == 1 && item.h() == global::a4.a.b) || ((global::a.n() == 3 || global::a.m()) && item.h() == global::a4.a.d))
				{
					FIMeasResults.ColorResults colorResults = new FIMeasResults.ColorResults();
					cc.d d10 = item;
					colorResults.a(d10.h(), d10.i(), d10.j(), d10.k(), d10.l(), d10.m(), d10.n());
					d10 = null;
					list.Add(colorResults);
				}
			}
		}
		checked
		{
			if (r.cu() != null)
			{
				hc obj = r;
				int num = obj.cu().c2() - 1;
				double[] array = obj.cu().cz();
				double[] array2 = obj.cu().c0();
				float[] a_ = obj.di();
				float a_2 = obj.c2();
				float[] array3 = new float[num + 1];
				float[] array4 = new float[num + 1];
				int num2 = num;
				for (int num3 = 0; num3 <= num2; num3++)
				{
					array3[num3] = (float)array[num3];
					array4[num3] = (float)array2[num3];
				}
				hc obj2 = r;
				byte a_3 = global::a.o();
				bool a_4 = Conversions.ToBoolean(global::a.c(0));
				bool A_5 = false;
				string A_6 = null;
				Color A_7 = default(Color);
				BorderStyle A_8 = BorderStyle.None;
				string A_9 = null;
				Color A_10 = default(Color);
				Color A_11 = default(Color);
				Color A_12 = default(Color);
				string A_13 = null;
				string A_14 = null;
				string A_15 = null;
				string a_5 = obj2.cf(A_1, a_3, a_4, null, ref A_5, ref A_6, ref A_7, ref A_8, ref A_9, ref A_10, ref A_11, ref A_12, ref A_13, ref A_14, ref A_15);
				a_5 = a(a_5, a(list, A_1), A_1);
				return new FIMeasResults(A_2, A_3, acqSpectrumType, A_4, array3, array4, a_, a_2, a_5, list);
			}
			if (r.cs() != null)
			{
				hc hc2 = r;
				int num4 = hc2.cs().c2() - 1;
				float[] array5 = new float[num4 + 1];
				float[] array6 = new float[num4 + 1];
				double[] array7 = hc2.cs().cz();
				double[] array8 = hc2.cs().c0();
				int num5 = num4;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					array5[num6] = (float)array7[num6];
					array6[num6] = (float)array8[num6];
				}
				byte a_6 = global::a.o();
				bool a_7 = Conversions.ToBoolean(global::a.c(0));
				bool A_5 = false;
				string A_15 = null;
				Color A_12 = default(Color);
				BorderStyle A_8 = BorderStyle.None;
				string A_14 = null;
				Color A_11 = default(Color);
				Color A_10 = default(Color);
				Color A_7 = default(Color);
				string A_13 = null;
				string A_9 = null;
				string A_6 = null;
				string a_5 = hc2.cf(A_1, a_6, a_7, null, ref A_5, ref A_15, ref A_12, ref A_8, ref A_14, ref A_11, ref A_10, ref A_7, ref A_13, ref A_9, ref A_6);
				a_5 = a(a_5, a(list, A_1), A_1);
				float[] array9 = null;
				if (acqSpectrumType == FIMeasResults.AcqSpectrumType.CTMSignalMeas && hc2.c7() > 0)
				{
					int num7 = hc2.c7() - 1;
					array9 = new float[num7 + 1];
					int num8 = num7;
					for (int num9 = 0; num9 <= num8; num9++)
					{
						array9[num9] = (float)hc2.cv(num9);
					}
				}
				return new FIMeasResults(A_2, A_3, acqSpectrumType, A_4, hc2.di(), hc2.c2(), array5, array6, hc2.@do(), a_5, (double)hc2.c2() >= this.m_k.wq(A_0).ed().gq(), hc2.dd() == cc.n.c, list, array9, hc2.cn().cb());
			}
			if (r.cy().b5())
			{
				FIMeasResultParam a_8 = null;
				FIMeasResultParam a_9 = null;
				FIMeasResultParam a_10 = null;
				FIMeasResultParam a_11 = null;
				FIMeasResultParam a_12 = null;
				hc hc3 = r;
				if (hc3.cf(hi.c.a) != null)
				{
					a_8 = new FIMeasResultParam((float)hc3.cf(hi.c.a).d(), theCorrOn: false);
				}
				if (hc3.cf(hi.c.b) != null)
				{
					a_9 = new FIMeasResultParam((float)hc3.cf(hi.c.b).d(), theCorrOn: false);
				}
				if (hc3.cf(hi.c.c) != null)
				{
					a_10 = new FIMeasResultParam((float)hc3.cf(hi.c.c).d(), theCorrOn: false);
				}
				if (hc3.ea() != null)
				{
					a_11 = new FIMeasResultParam(hc3.ea().a, theCorrOn: false);
				}
				if (hc3.eb() != null)
				{
					a_12 = new FIMeasResultParam(hc3.eb().a, hc3.ec());
				}
				hc obj3 = hc3;
				byte a_13 = global::a.o();
				bool a_14 = Conversions.ToBoolean(global::a.c(0));
				bool A_5 = false;
				string A_6 = null;
				Color A_7 = default(Color);
				BorderStyle A_8 = BorderStyle.None;
				string A_9 = null;
				Color A_10 = default(Color);
				Color A_11 = default(Color);
				Color A_12 = default(Color);
				string A_13 = null;
				string A_14 = null;
				string A_15 = null;
				string a_5 = obj3.cf(A_1, a_13, a_14, null, ref A_5, ref A_6, ref A_7, ref A_8, ref A_9, ref A_10, ref A_11, ref A_12, ref A_13, ref A_14, ref A_15);
				a_5 = a(a_5, a(list, A_1), A_1);
				hc3 = null;
				return new FIMeasResults(A_2, A_3, acqSpectrumType, A_4, a_5, list, r.ci(), r.ck(), a_8, a_9, a_10, a_11, a_12);
			}
			return new FIMeasResults(A_2, A_3, acqSpectrumType, A_4, a(list, A_1), list);
		}
	}

	private string a(List<FIMeasResults.ColorResults> A_0, bool A_1)
	{
		if (A_0 == null || A_0.Count == 0)
		{
			return null;
		}
		string A_2 = null;
		string A_3 = null;
		string A_4 = null;
		string A_5 = null;
		string A_6 = null;
		string A_7 = null;
		cc.cf(ref A_4, ref A_5, ref A_6, ref A_2, ref A_7, ref A_3, ref A_1);
		bool flag = false;
		foreach (FIMeasResults.ColorResults item in A_0)
		{
			if (item.CorrelationOn)
			{
				flag = true;
				break;
			}
		}
		string text = null;
		if (flag)
		{
			text = " (Corr On)";
		}
		string text2 = "Color Results" + text + ":" + A_2;
		foreach (FIMeasResults.ColorResults item2 in A_0)
		{
			string[] array = FIMeasResults.ColorResults.a(item2.Coordinate);
			text2 = text2 + array[0] + "= " + item2.Coord1 + A_2;
			text2 = text2 + array[1] + "= " + item2.Coord2 + A_2;
			text2 = text2 + array[2] + "= " + item2.Coord3 + A_2;
		}
		return text2 + A_3;
	}

	private Guid e(Guid A_0)
	{
		if (this.m_k.vv(A_0))
		{
			return this.m_k.vw(A_0);
		}
		return A_0;
	}

	private void b(Guid A_0, bool A_1, ref r.d A_2, ref AutoResetEvent A_3)
	{
		if (A_1)
		{
			A_2 = mSystemSpecCompletionTask;
			A_3 = y[A_0];
		}
		else
		{
			A_2 = mSpecCompletionTask;
			A_3 = x[A_0];
		}
	}

	private void a(Guid A_0, bool A_1, ref r.d A_2, ref AutoResetEvent A_3)
	{
		if (A_1)
		{
			A_2 = mSystemSetupCompletionTask;
			A_3 = ad[A_0];
		}
		else
		{
			A_2 = mSetupCompletionTask;
			A_3 = ac[A_0];
		}
	}

	private void a(hr A_0, ref float[] A_1, ref float[] A_2, ref Image A_3)
	{
		if (A_0 == null)
		{
			A_1 = null;
			A_2 = null;
			A_3 = null;
			return;
		}
		hr hr2 = A_0;
		checked
		{
			int num = hr2.c2() - 1;
			double[] array = hr2.cz();
			double[] array2 = hr2.c0();
			A_1 = new float[num + 1];
			A_2 = new float[num + 1];
			int num2 = num;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				A_1[num3] = (float)array[num3];
				A_2[num3] = (float)array2[num3];
			}
			if (hr2.bp() != null)
			{
				A_3 = hr2.bp().l();
			}
			hr2 = null;
		}
	}

	private void a(hr A_0, ref float[] A_1, ref float[] A_2)
	{
		hr hr2 = null;
		if (A_0 != null)
		{
			hr2 = A_0.bl();
		}
		hr a_ = hr2;
		Image A_3 = null;
		a(a_, ref A_1, ref A_2, ref A_3);
	}

	private void f()
	{
		au = null;
	}

	private void e()
	{
		u = null;
		r = null;
	}

	private void a(Guid A_0, int A_1, string A_2, string A_3)
	{
		Guid guid = e(A_0);
		c(guid);
		a(guid, A_3);
		hg obj = this.m_k.t0(guid.ToString());
		int num = checked(obj.ed().hh() - 1);
		if (A_1 < 0 || A_1 > num)
		{
			throw new ArgumentException("Layer Number must be >=0 and <= " + num, "layerNumber");
		}
		if (jb.y(A_2))
		{
			if (string.IsNullOrEmpty(jb.s(A_2)))
			{
				throw new ArgumentException("Material does not exist", "materialName");
			}
		}
		else if (jb.z(A_2))
		{
			string A_4 = null;
			float A_5 = 0f;
			bool A_6 = default(bool);
			jb.a(A_2, ref A_6, ref A_5, ref A_4);
			if (!A_6)
			{
				throw new ArgumentException(A_4, "materialName");
			}
		}
		obj.ed().et(A_1).af(A_2);
		obj.bu(mSetupCompletionTask, A_1: false);
		if (!ac[guid].WaitOne(2000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for layer material setting to be applied", 2000);
		}
		if (aw != global::r.d.a.a.a)
		{
			throw new SetupFailureException(ax);
		}
	}

	private f.b a(SpectrometerIndex A_0)
	{
		if (A_0 == SpectrometerIndex.LongWavelength)
		{
			return global::f.b.c;
		}
		return global::f.b.b;
	}

	private void b(bool A_0)
	{
		if (ap.InvokeRequired)
		{
			ap.Invoke(new d(b), A_0);
			return;
		}
		if (A_0)
		{
			if (ar == FormWindowState.Minimized)
			{
				ar = FormWindowState.Maximized;
			}
			ap.Visible = true;
			ap.WindowState = ar;
			if (!ap.ShowInTaskbar)
			{
				ap.ShowInTaskbar = true;
				ap.Opacity = 1.0;
			}
		}
		else
		{
			if (al)
			{
				ar = ap.WindowState;
			}
			ap.Visible = false;
		}
		aq = A_0;
	}

	private Guid d(Guid A_0)
	{
		Guid result = A_0;
		bool A_1 = default(bool);
		a(A_0, ref A_1);
		if (A_1)
		{
			result = this.get_MeasChannelGuid(A_0, 0);
		}
		return result;
	}

	private void a(bool A_0)
	{
		f1 f10 = this.m_k;
		eo.a a_ = null;
		bool flag = A_0 && !f10.sj((eo.a)null);
		bool flag2 = !A_0 && !f10.st(a_) && !f10.sn(a_) && !f10.sm();
		if (flag || flag2)
		{
			if (flag)
			{
				throw new IllegalCommandException("Spectrum Analysis mode is not supported by currently connected hardware or licenses");
			}
			throw new IllegalCommandException("Thickness mode is not supported by currently connected hardware or licenses");
		}
		f10 = null;
	}

	private void a(Guid A_0, ref bool A_1)
	{
		if (!al)
		{
			throw new InitializationNotCompletedException("Initialization not complete");
		}
		if (this.m_k.vv(A_0))
		{
			b(A_0);
			A_1 = true;
		}
		else
		{
			c(A_0);
			A_1 = false;
		}
	}

	private void c(Guid A_0)
	{
		if (!al)
		{
			throw new InitializationNotCompletedException("Initialization not complete");
		}
		if (!this.m_k.uh(A_0))
		{
			throw new ArgumentException("Nonexistent MeasModule", "measModuleGuid");
		}
	}

	private void a(Guid A_0, int A_1)
	{
		c(A_0);
		int num = this.get_NumberOfSubSystems(A_0);
		if (A_1 < 0 || A_1 >= num)
		{
			throw new ArgumentException("subSystemIndex must be >=0 and < " + Conversions.ToString(num), "subSystemIndex");
		}
	}

	private void b(int A_0)
	{
		int numberOfChannels = NumberOfChannels;
		if (A_0 < 0 || A_0 >= numberOfChannels)
		{
			throw new ArgumentException("measChannelIndex must be >=0 and < " + Conversions.ToString(numberOfChannels), "measChannelIndex");
		}
	}

	private void a(string A_0)
	{
		if (v == null)
		{
			throw new IllegalCommandException("There is no spectrum to save. You must call AcquireSpectrum, Measure, or OpenSpectrum before calling " + A_0);
		}
	}

	private void a(int A_0)
	{
		int numberOfSystems = NumberOfSystems;
		if (A_0 < 0 || A_0 >= numberOfSystems)
		{
			throw new ArgumentException("systemIndex must be >=0 and < " + Conversions.ToString(numberOfSystems), "measSystemIndex");
		}
	}

	private void b(Guid A_0)
	{
		if (!al)
		{
			throw new InitializationNotCompletedException("Initialization not complete");
		}
		if (!this.m_k.vv(A_0))
		{
			throw new ArgumentException("Nonexistent System", "systemGuid");
		}
	}

	private void a(Guid A_0, bool A_1, string A_2)
	{
		bool flag;
		if (A_1)
		{
			if (this.m_k.u7(A_0))
			{
				throw new IllegalCommandException(A_2 + " is not valid if optics configuration mode includes AutoMeasure.");
			}
			flag = this.m_k.vx(A_0);
		}
		else
		{
			Guid A_3 = default(Guid);
			flag = this.m_k.m2(A_0, ref A_3) && this.m_k.vx(A_3);
		}
		if (flag)
		{
			throw new IllegalCommandException(A_2 + " is not permitted while Monitoring task is active");
		}
	}

	private void a(Guid A_0, string A_1)
	{
		if (!this.m_k.v3(A_0))
		{
			throw new IllegalCommandException(A_1 + " is not permitted while certain operations such as a Monitor task are running.");
		}
	}

	private void a(string A_0, string A_1, bool A_2, ref float[] A_3, ref float[] A_4, ref Image A_5, ref float[] A_6, ref float[] A_7, ref bool A_8)
	{
		a(ActiveMeasModuleOnlyGuid, A_0, A_1, A_2, ref A_3, ref A_4, ref A_5, ref A_6, ref A_7, ref A_8);
	}

	private void a(Guid A_0, string A_1, string A_2, bool A_3, ref float[] A_4, ref float[] A_5, ref Image A_6, ref float[] A_7, ref float[] A_8, ref bool A_9)
	{
		string A_10 = "";
		int a_ = 0;
		if (A_3)
		{
			a_ = 1;
		}
		A_4 = null;
		A_5 = null;
		c(A_0);
		a(A_0, A_1: true, "AcquireSpectrum");
		f();
		x[A_0].Reset();
		this.m_k.m2(A_0, A_1, A_2, "Acquiring Spectrum...", ref A_10, mSpecCompletionTask, null, global::r.d.a.b.b, a_, null);
		if (this.m_k.u8(A_0) == g2.a.m)
		{
			a(A_0, x[A_0], 20000);
		}
		else
		{
			a(A_0, x[A_0]);
		}
		a(v, ref A_4, ref A_5, ref A_6);
		a(v, ref A_7, ref A_8);
		A_9 = v.ao();
	}

	private FIMeasResults b(Guid A_0, string A_1, string A_2, bool A_3, bool A_4, bool A_5)
	{
		int a_ = 0;
		if (A_5)
		{
			a_ = 1;
		}
		c(A_0);
		a(A_0, A_1: false, "Measure");
		f();
		e();
		x[A_0].Reset();
		this.m_k.m2(A_0, A_1, A_2, mSpecCompletionTask, null, 7, global::r.d.a.b.b, A_4, a_);
		a(A_0, x[A_0], 60000);
		if (r != null)
		{
			v = r.cn();
		}
		else
		{
			v = null;
		}
		return d(A_0, A_3);
	}

	private void a(Guid A_0, int A_1, f.b A_2, ref bool A_3, ref float A_4, ref bool A_5, ref float A_6)
	{
		if (this.m_k.m2(A_0, h6.b.b, A_1, A_2, SpectromTempSensorLoc.kFMTSLocDetectorInternal))
		{
			A_3 = true;
			A_4 = a(A_0, A_1, A_2, SpectromTempSensorLoc.kFMTSLocDetectorInternal);
		}
		if (this.m_k.m2(A_0, h6.b.b, A_1, A_2, SpectromTempSensorLoc.kFMTSLocSpectrometer))
		{
			A_5 = true;
			A_6 = a(A_0, A_1, A_2, SpectromTempSensorLoc.kFMTSLocSpectrometer);
		}
	}

	private float a(Guid A_0, int A_1, f.b A_2, SpectromTempSensorLoc A_3)
	{
		lock (af[A_0])
		{
			f1 obj = this.m_k;
			string A_4 = null;
			obj.m2(A_0, A_1, A_2, A_3, "Reading Short Wavelength detector temperature", ref A_4, mSpecTemperatureUpdateTask, global::r.d.a.b.b);
			af[A_0].WaitOne();
			try
			{
				r.g.a obj2 = t[A_0];
				if (((r.d.a)obj2).a != global::r.d.a.a.a)
				{
					throw new OperationFailedException("Failure attempting ReadTemperature");
				}
				return obj2.n;
			}
			finally
			{
				t.Remove(A_0);
			}
		}
	}

	private FIMeasResultValuesOnly a(Guid A_0, string A_1, string A_2, bool A_3, bool A_4, bool A_5)
	{
		int a_ = 0;
		if (A_4)
		{
			a_ = 1;
		}
		b(A_0);
		a(A_0, A_1: true, "SystemMeasure");
		f();
		e();
		AutoResetEvent autoResetEvent = z[A_0];
		autoResetEvent.Reset();
		this.m_k.m2(A_0, A_1, A_2, this.m_k.wg(A_0), null, 7, global::r.d.a.b.b, A_3, a_);
		autoResetEvent.WaitOne(600000, exitContext: false);
		if (bg.a == global::r.d.a.a.b)
		{
			if (bg is r.g.a)
			{
				r.g.a a10 = (r.g.a)bg;
				if (a10.j == global::r.g.a.a.a)
				{
					if (!string.IsNullOrEmpty(((r.d.a)a10).b))
					{
						throw new SpectrumAnalysisException(((r.d.a)a10).b);
					}
				}
				else
				{
					if (a10.j == global::r.g.a.a.t)
					{
						throw new AcquisitionException(((r.d.a)a10).b, AcquisitionException.ExceptionType.Unknown);
					}
					r.g.a a11 = a10;
					bool a_2 = false;
					string value = global::r.g.a.a6(a11.j, "", a11.k, a11.l, a11.p, a11.q, a11.r, a11.s, a_2, this.m_k.ti(A_0));
					a11 = null;
					if (!string.IsNullOrEmpty(value))
					{
						throw new AcquisitionException(((r.d.a)a10).b, AcquisitionException.ExceptionType.Unknown);
					}
				}
			}
			string A_6 = "ErrSingleMeas";
			throw new SpectrumAnalysisException(hu.a(ref A_6));
		}
		return ay;
	}

	private void c(Guid A_0, bool A_1)
	{
		bool A_2 = false;
		a(A_0, ref A_2);
		f1 obj = this.m_k;
		bool A_3 = default(bool);
		if (obj.m2(A_0, A_1: false, ref A_3))
		{
			throw new IllegalCommandException("Baseline is already authenticated");
		}
		if (!A_3)
		{
			throw new IllegalCommandException("Authentication of old Reference and Background data is not possible");
		}
		obj.m2(A_0, global::r.d.a.b.b, A_1);
		_ = null;
	}

	private void b(Guid A_0, int A_1, bool A_2, bool A_3, float[] A_4, string A_5, bool A_6)
	{
		if (this.m_k.u8(A_0) == g2.a.m)
		{
			throw new IncompatibleHardwareException("The BaselineAcquireReference method cannot be called for the currently selected optics config");
		}
		a(A_0, A_1, A_2, A_3, A_4, A_5, A_6);
	}

	private void d()
	{
		a(ActiveMeasModuleOrSystemGuid, A_1: false, A_2: false);
	}

	private void a(Guid A_0)
	{
		a(A_0, A_1: false, A_2: false);
	}

	private void a(bool A_0, bool A_1)
	{
		a(ActiveMeasModuleOrSystemGuid, A_0, A_1);
	}

	private void a(Guid A_0, bool A_1, bool A_2)
	{
		a(A_0, A_1, A_2, A_3: false, "BaselineAcquireBackground");
	}

	private void a(Guid A_0, bool A_1, bool A_2, bool A_3, string A_4)
	{
		bool a_ = this.m_k.wq(A_0).b8().n();
		bool A_5 = default(bool);
		a(A_0, ref A_5);
		f();
		r.d A_6 = null;
		AutoResetEvent A_7 = null;
		b(A_0, A_5, ref A_6, ref A_7);
		if (this.m_k.u6(A_0))
		{
			this.m_k.p9(A_0, A_6, global::r.d.a.b.b, null);
		}
		else if (A_1)
		{
			this.m_k.m2(A_0, A_6, A_2, a_, global::r.d.a.b.b, null);
		}
		else if (this.m_k.u8(A_0) == g2.a.m)
		{
			if (!this.m_k.s3(A_0, A_1: false))
			{
				throw new TaskAttemptFailureException("A reference must first be acquired prior to attempting to aquire a background. A reference can be acquired through the Filmetrics software user interface (Setup->Reference/Background).");
			}
			this.m_k.m2(A_0, A_6, A_2, global::r.d.a.b.b, A_4: true, new r.c());
		}
		else
		{
			this.m_k.p9(A_0, A_6, A_2, A_3, global::r.d.a.b.b, null);
		}
		if (!A_7.WaitOne(120000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for " + A_4 + " completion", 120000);
		}
		if (((r.d.a)at).a != global::r.d.a.a.a)
		{
			throw new AcquisitionException(at.a6(), AcquisitionException.ExceptionType.Unknown);
		}
		if (A_2 && this.m_k.u8(A_0) != g2.a.m)
		{
			bool A_8 = false;
			string A_9 = null;
			this.m_k.m2(A_0, ref A_8, !A_1, A_1, ref A_9);
			if (A_8)
			{
				this.m_k.wl(A_0);
				string A_10 = "BaselineRefBacTooSimilarFmt";
				throw new InvalidBackgroundException(string.Format(hu.a(ref A_10), A_9));
			}
		}
	}

	private void a(Guid A_0, int A_1, bool A_2, bool A_3, float[] A_4, string A_5, bool A_6)
	{
		bool flag = this.m_k.wq(A_0).b8().n();
		bool A_7 = default(bool);
		a(A_0, ref A_7);
		f();
		if (flag)
		{
			if (A_2)
			{
				if (this.m_k.te(A_0, A_6))
				{
					throw new IllegalCommandException(A_5 + " is not valid if a sample reflectance spectrum has been measured, but not committed, recipe measurement timing is set to Recommended or Maximum modes, and useOldSampleReflectance or userSuppliedReflectance is specified. Call BaselineCommit to clear a pending sample reflectance spectrum");
				}
				if (A_3)
				{
					if (!this.m_k.wp(A_0))
					{
						throw new IllegalCommandException(A_5 + " is only valid after first measuring a representative test sample or specifying the use of an oldSampleReflectance spectrum if recipe measurement timing is set to Recommended or Maximum modes");
					}
					A_4[0] = 0f;
					A_4[1] = 0f;
				}
				else if (A_4[0] <= 0f || A_4[0] >= 2f || A_4[1] <= 0f || A_4[1] >= 2f)
				{
					throw new ArgumentException("Invalid parameter value. Must be between " + 0f + " and " + 2f, "userSuppliedReflectance");
				}
			}
			else if (!this.m_k.te(A_0, A_6))
			{
				throw new IllegalCommandException(A_5 + " is only valid after first measuring a representative test sample if recipe measurement timing is set to Recommended or Maximum modes");
			}
		}
		else if (A_2)
		{
			throw new IllegalCommandException(A_5 + " is only valid if recipe measurement timing is set to Recommended or Maximum modes");
		}
		r.d A_8 = null;
		AutoResetEvent A_9 = null;
		b(A_0, A_7, ref A_8, ref A_9);
		Rectangle workingArea = global::c.e().Screen.WorkingArea;
		this.m_k.m2(A_0, A_8, A_4, flag, global::r.d.a.b.b, A_1, A_6, null, new Point(workingArea.Width / 2, workingArea.Height / 2), A_9: true);
		if (!A_9.WaitOne(240000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for " + A_5 + " completion", 240000);
		}
		if (((r.d.a)at).a != global::r.d.a.a.a)
		{
			throw new AcquisitionException(at.a6(), AcquisitionException.ExceptionType.Unknown);
		}
	}

	private void b(Guid A_0, bool A_1)
	{
		bool A_2 = default(bool);
		a(A_0, ref A_2);
		if (!this.m_k.wq(A_0).b8().n())
		{
			throw new IllegalCommandException("BaselineAcquireSpectrumFromSample is only valid if recipe measurement timing is set to Recommended or Maximum modes");
		}
		if (this.m_k.u8(A_0) == g2.a.m)
		{
			throw new IncompatibleHardwareException("The BaselineAcquireSpectrumFromSample method cannot be called for the currently selected optics config");
		}
		f();
		r.d A_3 = null;
		AutoResetEvent A_4 = null;
		b(A_0, A_2, ref A_3, ref A_4);
		Rectangle workingArea = global::c.e().Screen.WorkingArea;
		this.m_k.m2(A_0, A_3, A_1, global::r.d.a.b.b, null, new Point(workingArea.Width / 2, workingArea.Height / 2));
		if (!A_4.WaitOne(240000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for BaselineAcquireSpectrumFromSample completion", 240000);
		}
		if (((r.d.a)at).a != global::r.d.a.a.a)
		{
			throw new AcquisitionException(at.a6(), AcquisitionException.ExceptionType.Unknown);
		}
	}

	private void a(Guid A_0, bool A_1)
	{
		bool A_2 = default(bool);
		a(A_0, ref A_2);
		r.d A_3 = null;
		AutoResetEvent A_4 = null;
		a(A_0, A_2, ref A_3, ref A_4);
		this.m_k.m2(A_0, A_1: true, A_2: true, A_3, A_1, global::r.d.a.b.b);
		if (!A_4.WaitOne(2000, exitContext: false))
		{
			throw new TimeOutException("Timeout waiting for BaselineCommit to complete", 2000);
		}
		if (aw != global::r.d.a.a.a)
		{
			throw new SetupFailureException(ax);
		}
	}

	private void a(Guid A_0, AutoResetEvent A_1, int A_2 = 0)
	{
		checked
		{
			int num = (int)Math.Round(this.m_k.xd(A_0) * 2.5f) + A_2;
			if (num <= 2000)
			{
				num = 2000;
			}
			DateTime now = DateTime.Now;
			int num2 = (int)Math.Round((double)num - DateTime.Now.Subtract(now).TotalMilliseconds);
			if (!A_1.WaitOne(num2, exitContext: false))
			{
				throw new TimeOutException("Timeout waiting for spectrum acquire completion", num2);
			}
			if (((r.d.a)at).a != global::r.d.a.a.a)
			{
				AcquisitionException.ExceptionType type;
				switch (at.j)
				{
				case global::r.g.a.a.q:
				case global::r.g.a.a.r:
					type = AcquisitionException.ExceptionType.Saturation;
					break;
				case global::r.g.a.a.o:
					type = AcquisitionException.ExceptionType.InvalidAcquisitionSettings;
					break;
				default:
					type = AcquisitionException.ExceptionType.Unknown;
					break;
				}
				throw new AcquisitionException(at.a6(), type);
			}
			if (au != null && au.a != global::r.d.a.a.a)
			{
				throw new SpectrumAnalysisException(au.b);
			}
		}
	}

	private void m(r.d.a A_0)
	{
		o = false;
	}

	private void l(r.d.a A_0)
	{
		try
		{
			_ = (r.g.a)A_0;
			s[A_0.c] = (r.g.a)A_0;
		}
		finally
		{
			ae[A_0.c].Set();
		}
	}

	private void k(r.d.a A_0)
	{
		au = A_0;
		aa[au.c].Set();
	}

	private void j(r.d.a A_0)
	{
		bool flag = false;
		try
		{
			if (A_0 is r.g.a)
			{
				flag = true;
				at = (r.g.a)A_0;
			}
			else
			{
				au = A_0;
			}
		}
		finally
		{
			if (flag)
			{
				x[at.h].Set();
			}
		}
	}

	private void i(r.d.a A_0)
	{
		try
		{
			_ = (r.g.a)A_0;
			t[A_0.c] = (r.g.a)A_0;
		}
		finally
		{
			af[A_0.c].Set();
		}
	}

	private void h(r.d.a A_0)
	{
		ai.Set();
	}

	private void g(r.d.a A_0)
	{
		bool flag = false;
		try
		{
			if (A_0 is r.g.a)
			{
				flag = true;
				at = (r.g.a)A_0;
			}
			else
			{
				au = A_0;
			}
		}
		finally
		{
			if (flag)
			{
				y[at.c].Set();
			}
		}
	}

	private void f(r.d.a A_0)
	{
		bg = A_0;
		z[A_0.c].Set();
	}

	private void e(r.d.a A_0)
	{
		r.f.a a10 = (r.f.a)A_0;
		aw = A_0.a;
		ax = A_0.b;
		ac[a10.h].Set();
	}

	private void d(r.d.a A_0)
	{
		r.f.a a10 = (r.f.a)A_0;
		aw = A_0.a;
		ax = A_0.b;
		ad[a10.c].Set();
	}

	private void c(r.d.a A_0)
	{
		this.m_m = false;
	}

	private void b(r.d.a A_0)
	{
		r.h.a a10 = null;
		try
		{
			a10 = (r.h.a)A_0;
			if (((r.d.a)a10).a == global::r.d.a.a.a)
			{
				v = a10.w;
			}
			else
			{
				v = null;
			}
		}
		finally
		{
			w[a10.h].Set();
		}
	}

	private void a(r.d.a A_0)
	{
		try
		{
			u = (r.i.b)A_0;
			r = u.ab;
		}
		finally
		{
			ab[u.h].Set();
		}
	}

	private void a(Guid A_0, float A_1, int[] A_2, string[] A_3, int[] A_4, Collection<Collection<float[]>> A_5, string A_6)
	{
		checked
		{
			int num = A_4.Length - 1;
			Collection<float[]> collection = new Collection<float[]>();
			int num2 = A_5.Count - 1;
			_ = new int[num + 1];
			int num3 = num2;
			for (int num4 = 0; num4 <= num3; num4++)
			{
				float[] array = new float[num + 1];
				Collection<float[]> collection2 = A_5[num4];
				int num5 = num;
				for (int num6 = 0; num6 <= num5; num6++)
				{
					array[num6] = collection2[A_4[num6]][0];
				}
				collection.Add(array);
			}
			ay = new FIMeasResultValuesOnly(A_1, A_2, A_3, collection, A_6);
			bd?.Invoke(A_0, ay);
		}
	}
}
