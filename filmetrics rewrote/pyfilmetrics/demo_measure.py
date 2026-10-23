"""End-to-end device pipeline demo (no hardware) — simulated instrument -> baseline -> measure -> fit.

Uses the SAME MeasureController that will drive the real FIUsbInt.dll instrument once hardware is present;
only the Instrument backend differs (SimulatedInstrument here, FIUsbInstrument later).

Run from project root:  python demo_measure.py
"""
import os

import numpy as np

from filmeas.app.controller import MeasureController
from filmeas.device.simulated import SimulatedInstrument
from filmeas.io import material
from filmeas.io.recipe import Recipe

RECIPES = r"C:\ProgramData\Filmetrics\FILMeasure\Recipes"
HERE = os.path.dirname(os.path.abspath(__file__))
AIR, SIO2, SI = material.get("Air"), material.get("SiO2"), material.get("Si")


def main():
    recipe = Recipe.load(os.path.join(RECIPES, "SiO2 on Si.fitrp"))
    true_nm = recipe.layers[1].thickness_nm            # 9000 A nominal

    inst = SimulatedInstrument(seed=5)
    ctrl = MeasureController(inst)

    print("1) baseline: reference = bare Si (light on), background (light off)")
    ctrl.take_baseline("Si", averages=9,
                       mount_reference=lambda: inst.mount([(AIR, 0.0), (SI, 0.0)]))

    print("2) measure sample: SiO2 on Si")
    res = ctrl.measure(recipe, averages=9,
                       mount_sample=lambda: inst.mount([(AIR, 0.0), (SIO2, true_nm), (SI, 0.0)]))

    print(f"\n   instrument     : {inst.model}, {inst.num_pixels} px, "
          f"{inst.wavelengths_nm[0]:.0f}-{inst.wavelengths_nm[-1]:.0f} nm")
    print(f"   nominal        : {true_nm*10:.0f} A")
    print(f"   MEASURED       : {res.thickness_A[0]:.0f} A   (GOF {res.gof:.4f})")

    try:
        import matplotlib
        matplotlib.use("Agg")
        import matplotlib.pyplot as plt
        fig, ax = plt.subplots(figsize=(8, 4.5))
        ax.plot(res.wavelength_nm, res.measured_R, ".", ms=3, alpha=0.5,
                label="measured R (baselined)")
        ax.plot(res.wavelength_nm, res.modeled_R, "-", lw=1.6, label="fitted model")
        ax.set_xlabel("wavelength (nm)"); ax.set_ylabel("reflectance")
        ax.set_ylim(0, 1)
        ax.set_title(f"Simulated instrument → measure → fit: "
                     f"{res.thickness_A[0]:.0f} A SiO2 on Si  (GOF {res.gof:.4f})")
        ax.legend(); fig.tight_layout()
        png = os.path.join(HERE, "demo_measure.png")
        fig.savefig(png, dpi=120)
        print(f"\n   plot saved: {png}")
    except Exception as e:
        print(f"(plot skipped: {e})")


if __name__ == "__main__":
    main()
