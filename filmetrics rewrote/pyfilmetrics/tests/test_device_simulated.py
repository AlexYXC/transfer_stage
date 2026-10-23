import numpy as np
import pytest

from filmeas.io import material
from filmeas.device.simulated import SimulatedInstrument

AIR, SIO2, SI = material.get("Air"), material.get("SiO2"), material.get("Si")


def test_connect_and_static_props():
    inst = SimulatedInstrument()
    inst.connect()
    assert inst.num_pixels == len(inst.wavelengths_nm)
    assert np.all(np.diff(inst.wavelengths_nm) > 0)
    assert inst.model == "Simulated"


def test_integration_time_get_set_clamped():
    inst = SimulatedInstrument()
    inst.integration_time_ms = 25.0
    assert inst.integration_time_ms == 25.0
    inst.integration_time_ms = 10 ** 9         # clamps to max
    assert inst.integration_time_ms == inst.max_integration_time_ms


def test_light_off_reads_dark_light_on_reads_signal():
    inst = SimulatedInstrument(seed=1)
    inst.mount([(AIR, 0.0), (SIO2, 500.0), (SI, 0.0)])
    inst.set_light(False)
    dark = inst.acquire()
    inst.set_light(True)
    lit = inst.acquire()
    assert lit.counts.max() > dark.counts.max() * 3      # clear signal above dark
    assert dark.counts.max() < 250                       # dark read stays near the dark floor (~120)


def test_longer_integration_increases_signal():
    inst = SimulatedInstrument(seed=2)
    inst.mount([(AIR, 0.0), (SIO2, 500.0), (SI, 0.0)])
    inst.integration_time_ms = 20.0
    a = inst.acquire()
    inst.integration_time_ms = 80.0
    b = inst.acquire()
    assert (b.counts.mean() - 120) > 3 * (a.counts.mean() - 120)  # ~4x signal above dark


def test_saturation_flag():
    inst = SimulatedInstrument(seed=3, full_scale=1000.0)
    inst.mount([(AIR, 0.0), (SI, 0.0)])
    inst.integration_time_ms = 500.0
    acq = inst.acquire()
    assert acq.saturated is True
    assert acq.counts.max() <= 1000.0
