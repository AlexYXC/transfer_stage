import numpy as np

from filmeas.io import material
from filmeas.device.simulated import SimulatedInstrument
from filmeas.device.baseline import Baseline, reference_reflectance
from filmeas.optics import tmm

AIR, SIO2, SI = material.get("Air"), material.get("SiO2"), material.get("Si")


def test_baseline_recovers_true_reflectance():
    inst = SimulatedInstrument(seed=7)
    wl = inst.wavelengths_nm

    # reference = bare Si standard (light on); background = light off
    inst.mount([(AIR, 0.0), (SI, 0.0)])
    inst.set_light(True)
    ref = inst.acquire(averages=25)
    inst.set_light(False)
    bkg = inst.acquire(averages=25)

    base = Baseline(wl, ref.counts, bkg.counts, reference_reflectance(wl, SI))

    # sample = 500 nm SiO2 on Si
    sample_stack = [(AIR, 0.0), (SIO2, 500.0), (SI, 0.0)]
    inst.mount(sample_stack)
    inst.set_light(True)
    samp = inst.acquire(averages=25)

    recovered = base.reflectance(samp.counts)
    truth = tmm.reflectance(wl, sample_stack)

    # compare over the well-illuminated middle band (edges are noisy after division)
    mid = (wl > 450) & (wl < 900)
    assert np.median(np.abs(recovered[mid] - truth[mid])) < 0.01


def test_baseline_rejects_bad_reference():
    wl = np.linspace(400, 900, 50)
    ref = np.ones_like(wl) * 100
    bkg = np.ones_like(wl) * 100      # ref == bkg -> denominator zero
    try:
        Baseline(wl, ref, bkg, np.ones_like(wl) * 0.3)
        assert False, "should have raised"
    except ValueError:
        pass
