"""pyfilmetrics demo — no hardware required.

Runs the whole hardware-free pipeline:
  1. load a real FILMeasure recipe (film stack + settings)
  2. build the optical model, simulate a measured reflectance spectrum (nominal thickness + noise)
  3. fit the spectrum back to a thickness + GOF (this is the core FILMeasure "Measure" math)
  4. demo recipe editing with automatic checksum refresh
  5. read a real stored .fmspe spectrum
Outputs demo_fit.png (if matplotlib is available) and prints results.

Run from the project root:  python demo.py
"""
import os

import numpy as np

from filmeas.io import material
from filmeas.io.recipe import Recipe
from filmeas.io.spectrum import load_fmspe
from filmeas.optics import fit, tmm

RECIPES = r"C:\ProgramData\Filmetrics\FILMeasure\Recipes"
PREC = r"C:\ProgramData\Filmetrics\Precision"
HERE = os.path.dirname(os.path.abspath(__file__))


def build_stack(recipe):
    layers, solve = [], []
    for i, lay in enumerate(recipe.layers):
        layers.append((material.get(lay.material), lay.thickness_nm))
        if lay.solve_d:
            solve.append(i)
    return layers, solve


def main():
    rng = np.random.default_rng(1)
    recipe = Recipe.load(os.path.join(RECIPES, "SiO2 on Si.fitrp"))
    print(f"Recipe: {recipe.name!r}  layers:")
    for lay in recipe.layers:
        flag = " (solve d)" if lay.solve_d else ""
        print(f"   {lay.layer_id:10s} {lay.material:6s} {lay.thickness_A:>8.0f} A{flag}")

    layers, solve = build_stack(recipe)
    true_nm = layers[solve[0]][1]
    wl = np.arange(400.0, 1000.0, 1.0)

    # (no hardware) simulate a measured reflectance from the nominal stack + noise
    measured = tmm.reflectance(wl, layers) + rng.normal(0, 0.004, wl.shape)

    # fit thickness back (start "unknown")
    guess = [(d, 0.0) if i in solve else (d, t) for i, (d, t) in enumerate(layers)]
    res = fit.fit_thickness(wl, measured, guess, solve_idx=solve, bounds_nm=(1.0, 20000.0))
    print(f"\nTrue thickness    : {true_nm*10:.0f} A")
    print(f"Fitted thickness  : {res.thickness_nm[0]*10:.0f} A")
    print(f"GOF               : {res.gof:.4f}")

    # recipe editing + checksum refresh
    recipe.set_layer_thickness(solve[0], 12000)   # A
    out = os.path.join(HERE, "edited_SiO2_on_Si.fitrp")
    recipe.save(out)
    reloaded = Recipe.load(out)
    print(f"\nEdited recipe saved: {os.path.basename(out)} "
          f"(Layer1 -> {reloaded.layers[1].thickness_A:.0f} A, checksum valid: {reloaded.verify()})")

    # read a real stored spectrum
    if os.path.isdir(PREC):
        s = load_fmspe(os.path.join(PREC, "Si_F20.fmspe"))
        print(f"Loaded real spectrum: {s.label!r}  {len(s)} pts  "
              f"{s.wavelength_nm[0]:.0f}-{s.wavelength_nm[-1]:.0f} nm  kind={s.kind}")

    # plot
    try:
        import matplotlib
        matplotlib.use("Agg")
        import matplotlib.pyplot as plt
        fig, ax = plt.subplots(figsize=(8, 4.5))
        ax.plot(wl, measured, ".", ms=3, alpha=0.5, label="measured (simulated)")
        ax.plot(wl, res.modeled_R, "-", lw=1.6, label="fitted model")
        ax.set_xlabel("wavelength (nm)"); ax.set_ylabel("reflectance")
        ax.set_title(f"SiO2 on Si  —  fitted {res.thickness_nm[0]*10:.0f} A  (GOF {res.gof:.4f})")
        ax.legend(); fig.tight_layout()
        png = os.path.join(HERE, "demo_fit.png")
        fig.savefig(png, dpi=120)
        print(f"\nPlot saved: {png}")
    except Exception as e:
        print(f"(plot skipped: {e})")


if __name__ == "__main__":
    main()
