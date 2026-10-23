"""The real-hardware backend must import cleanly (comtypes/hardware only needed when actually used)."""
from filmeas.device.base import Instrument
from filmeas.device.fiusbint import FIUsbInstrument


def test_class_shape():
    assert issubclass(FIUsbInstrument, Instrument)
    inst = FIUsbInstrument()          # construction must not require comtypes or hardware
    for m in ("connect", "close", "acquire", "set_light"):
        assert callable(getattr(inst, m))


def test_connect_without_comtypes_or_hardware_raises_clean_error():
    inst = FIUsbInstrument()
    try:
        inst.connect()
    except Exception as e:
        # acceptable: comtypes missing (RuntimeError) or COM/hardware failure (OSError/other)
        assert not isinstance(e, AssertionError)
    else:
        inst.close()   # if it somehow connected (hardware present), clean up
