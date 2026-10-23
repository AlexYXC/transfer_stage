using System;
using System.Runtime.CompilerServices;
using FIUsbIntLib;

internal abstract class f0 : q
{
	public enum FIDeviceErr
	{
		None,
		Generic,
		USBEnumError,
		USBInitError,
		USBSpecAcquisitionError,
		USBNoDevices,
		USBCorruptedDevice,
		StageInitError,
		USBFirmwareNeedsUpdate,
		USBDeviceHardwareFailure,
		FiberMuxInitError,
		FIUsbIntCOMError,
		FIUsbIntTooOld,
		FIUsbIntXPVerError,
		FIUsbIntFileNotFoundError,
		WaferHandlerInitError,
		USBSpecConflict
	}

	public enum a
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g
	}

	private a fs;

	protected bool ft;

	private Guid fu;

	public f0(a A_0, fz A_1)
		: base(ref A_1)
	{
		fs = A_0;
		ft = false;
		fu = Guid.NewGuid();
	}

	[SpecialName]
	public string ab3()
	{
		return b3.a(fu);
	}

	[SpecialName]
	public abstract FMLegacyAllSystemTypes b();

	[SpecialName]
	public abstract byte c();

	public abstract void e();

	[SpecialName]
	public a ab4()
	{
		return fs;
	}

	[SpecialName]
	public string ab5()
	{
		string empty = string.Empty;
		switch (fs)
		{
		case a.b:
		{
			string A_ = "DeviceUSBController";
			return hu.a(ref A_);
		}
		case a.c:
		{
			string A_ = "DeviceUSBSpectrometer";
			return hu.a(ref A_);
		}
		case a.e:
		{
			string A_ = "DeviceImagingMonochrometer";
			return hu.a(ref A_);
		}
		case a.f:
			return "Photodiode/LED";
		default:
		{
			string A_ = "Unknown";
			return hu.a(ref A_);
		}
		}
	}

	[SpecialName]
	public bool ab6()
	{
		return ft;
	}

	[SpecialName]
	public bool ab7()
	{
		if ((ab4() == a.b) | (ab4() == a.c) | (ab4() == a.d))
		{
			return true;
		}
		return false;
	}

	protected abstract FIDeviceErr d();
}
