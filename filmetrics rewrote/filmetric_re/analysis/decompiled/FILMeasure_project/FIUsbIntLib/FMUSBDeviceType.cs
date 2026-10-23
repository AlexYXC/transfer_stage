using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FIUsbIntLib;

[TypeIdentifier("a44d02b9-a07d-489f-a4ac-9b49e8646871", "FIUsbIntLib.FMUSBDeviceType")]
[CompilerGenerated]
public enum FMUSBDeviceType
{
	FMUSBDeviceVisHama = 0,
	FMUSBDeviceIRHama = 1,
	FMUSBDeviceSony = 2,
	FMUSBDevicePhotodiode = 3,
	FMUSBDeviceController = 255,
	FMUSBDeviceF80Base = 257,
	FMUSBDeviceF80Head = 258,
	FIUSB2Device = 512,
	FIUSB2DeviceSpecUvVis = 513,
	FIUSB2DeviceSpecNIR2 = 514,
	FIUSB2DeviceSpecLC = 515,
	FIUSB2DeviceSpecUvVis2 = 516,
	FIUSB2DevicePDLED = 517,
	FIUSB2DeviceSpecTCNIR = 518,
	FIUSB2DeviceOptProf = 519,
	FIUSB2DeviceController = 767,
	FIUSBEmbDevice = 768,
	FIUSBEmbDeviceController = 1023
}
