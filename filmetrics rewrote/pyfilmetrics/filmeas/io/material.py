"""Material (n,k) sources.

- ``load_nk_csv``  : generic ``wavelength_nm,n,k`` CSV -> Tabulated dispersion.
- built-in ``MATERIALS`` : a small library (Air, SiO2, Si) so the optics core + tests run without .fibnk.
- ``.fibnk`` : FILMeasure's binary material bank (int32 header + packed n,k). DEFERRED — decode later or
  reuse fmsolve.dll ReadFIBNKFile3. See filmetric_re/findings.md.

Built-in n,k are approximate literature values, adequate for validating the modelling/fit pipeline;
swap in real .fibnk/CSV data for production accuracy.
"""
from __future__ import annotations

import numpy as np

from ..optics.dispersion import Cauchy, CauchyUrbach, Constant, Lorentz, Sellmeier, Tabulated


def load_nk_csv(path: str) -> Tabulated:
    w, n, k = [], [], []
    with open(path, "r", encoding="utf-8") as f:
        for line in f:
            parts = line.strip().split(",")
            if len(parts) < 2:
                continue
            try:
                w.append(float(parts[0]))
                n.append(float(parts[1]))
                k.append(float(parts[2]) if len(parts) > 2 else 0.0)
            except ValueError:
                continue  # header
    return Tabulated(w, n, k)


# --- small built-in library (approximate literature n,k) -------------------
_SI_W = [400, 450, 500, 550, 600, 650, 700, 750, 800, 900, 1000, 1100]
_SI_N = [5.57, 4.68, 4.30, 4.08, 3.94, 3.85, 3.79, 3.74, 3.69, 3.60, 3.57, 3.53]
_SI_K = [0.39, 0.15, 0.073, 0.038, 0.025, 0.016, 0.012, 0.009, 0.006, 0.003, 0.001, 0.0]

# Published dispersion (public-domain optical constants):
#  fused silica & BK7: Sellmeier (Malitson / Schott); sapphire: Sellmeier (Malitson, ordinary ray).
MATERIALS = {
    "Air": Constant(1.0, 0.0),
    "Vacuum": Constant(1.0, 0.0),
    # Fused silica (Malitson 1965), C in um^2:
    "SiO2": Sellmeier([(0.6961663, 0.0684043**2), (0.4079426, 0.1162414**2), (0.8974794, 9.896161**2)]),
    "Fused Silica": Sellmeier([(0.6961663, 0.0684043**2), (0.4079426, 0.1162414**2), (0.8974794, 9.896161**2)]),
    # Schott BK7 (default reflectance reference material):
    "BK7": Sellmeier([(1.03961212, 0.00600069867), (0.231792344, 0.0200179144), (1.01046945, 103.560653)]),
    # Sapphire Al2O3, ordinary ray (Malitson 1962):
    "Al2O3": Sellmeier([(1.4313493, 0.0726631**2), (0.65054713, 0.1193242**2), (5.3414021, 18.028251**2)]),
    "Si": Tabulated(_SI_W, _SI_N, _SI_K),
    # Approximate Cauchy dielectrics (swap for measured CSV for production accuracy):
    "Si3N4": Cauchy(2.008, 0.01075, 0.0),         # ~2.02 @ 600 nm
    "SiON": Cauchy(1.72, 0.006, 0.0),
    "PMMA": Cauchy(1.4894, 0.00418, 0.0),         # acrylic
    "Acrylic": Cauchy(1.4894, 0.00418, 0.0),
    "TiO2": Cauchy(2.35, 0.03, 0.0),              # rough amorphous approx
    "Water": Sellmeier([(0.75831, 0.01007), (0.08495, 8.91377)]),
}


def get(name: str):
    """Look up a material by name from the built-in library (case-insensitive)."""
    if name in MATERIALS:
        return MATERIALS[name]
    for key in MATERIALS:
        if key.lower() == name.lower():
            return MATERIALS[key]
    raise KeyError(f"material {name!r} not in built-in library {list(MATERIALS)}; "
                   f"load it from CSV/.fibnk instead")
