using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FIUsbIntLib;

[CompilerGenerated]
[TypeIdentifier("a44d02b9-a07d-489f-a4ac-9b49e8646871", "FIUsbIntLib.FMUSBIntErr")]
public enum FMUSBIntErr
{
	kFMUSBIntErrNoErr = 0,
	kFMUSBIntErrDevNotFound = -100,
	kFMUSBIntErrMemAllocFail = -101,
	kFMUSBIntErrDevListCreateFail = -102,
	kFMUSBIntErrDevListMissing = -103,
	kFMUSBIntErrNoMoreControllersInList = -104,
	kFMUSBIntErrFailedToOpenDevice = -105,
	kFMUSBIntErrFailedI2COperation = -106,
	kFMUSBIntErrControllerFWIncompatible = -107,
	kFMUSBIntErrDevDeviceFWIncompatible = -108,
	kFMUSBIntErrDevSpecificFWIncompatible = -109,
	kFMUSBIntErrObjectNotInstantiated = -110,
	kFMUSBIntErrCreateEventFailure = -111,
	kFMUSBIntErrTimeout = -112,
	kFMUSBIntErrTriedToOpenDeviceAlreadyOpen = -113,
	kFMUSBIntErrDCVoltZeroStuck = -114,
	kFMUSBIntErrDCVoltZeroStuck2 = -115,
	kFMUSBIntErrDCVoltZeroTooLow = -116,
	kFMUSBIntErrStringBufTooSmall = -117,
	kFMUSBIntErrUnrecognizedDevType = -118,
	kFMUSBIntErrInvalidPDIdx = -119,
	kFMUSBIntErrBufferTooSmall = -120,
	kFMUSBIntErrISOPacketSpaceTooSmall = -121,
	kFMUSBIntErrISOPacketDescrSizeDefIncorrect = -122,
	kFMUSBIntErrDeviceConnectNotDone = -123,
	kFMUSBIntErrAnalogChipFailure = -124,
	kFMUSBIntErrFileMutexFailure = -125,
	kFMUSBIntErrLockUnlockSafeArray = -126,
	kFMUSBIntErrIntegrationTimeChanged = -127,
	kFMUSBIntErrOverlappedStateMismatch = -128,
	kFMUSBIntErrWorkerThreadCreatedWhenItShouldHavePreExisted = -129,
	kFMUSBIntErrAttempToOpenLastWhenSymNameIsEmpty = -130,
	kFMUSBIntErrUnrecognizedPDType = -131,
	kFMUSBIntErrRequestedPDChannelNotConnected = -132,
	kFMUSBIntErrAcqAttemptWillCauseFIFOOverrun = -133,
	kFMUSBIntErrAttemptToOverWriteFW = -134,
	kFMUSBIntErrSignalTooSmall = -135,
	kFMUSBIntErrCannotOpenCalibSourceFile = -136,
	kFMUSBIntErrControllerFWOutOfDate = -137,
	kFMUSBIntErrControllerFWOutOfDateFWFlushSupported = -138,
	kFMUSBIntErrCannotOpenCalibLogFile = -139,
	kFMUSBIntErrControllerBareFWOutOfDateFWFlushSupported = -140,
	kFMUSBIntErrDateConversionFailure = -141,
	kFMUSBIntErrRtcMemBlockReadFail = -142,
	kFMUSBIntErrGettingGainProgress = -143,
	kFMUSBIntErrMissingLSOnTimer = -144,
	kFMUSBIntErrMissingSecondaryLSOnTimer = -145,
	kFMUSBIntErrCommandNotSupportedByHW = -146,
	kFMUSBIntErrCommandNotAllowed = -147
}
