"""Transfer-matrix (Abeles characteristic-matrix) reflectance of a thin-film stack.

reflectance(wavelength_nm, layers, angle_deg, pol) -> R(lambda)

``layers`` = ``[(dispersion, thickness_nm), ...]``: the first entry is the ambient and the last is the
substrate (both treated as semi-infinite; their thickness is ignored). Interior entries are finite films.
``dispersion`` is any callable returning complex n+ik for an array of wavelengths (see optics.dispersion).
Vectorized over wavelength; supports oblique incidence and TE/TM polarization.
"""
from __future__ import annotations

import numpy as np


def reflectance(wavelength_nm, layers, angle_deg: float = 0.0, pol: str = "TE"):
    wl = np.asarray(wavelength_nm, dtype=float)
    n = [np.asarray(disp(wl), dtype=complex) for (disp, _d) in layers]
    d = [d for (_disp, d) in layers]

    theta0 = np.deg2rad(angle_deg)
    n0_sin = n[0] * np.sin(theta0)                     # invariant across interfaces (Snell)

    def cos_theta(nj):
        return np.sqrt(1.0 - (n0_sin / nj) ** 2)

    ct = [cos_theta(nj) for nj in n]

    te = pol.upper() == "TE"
    def admittance(nj, ctj):
        return nj * ctj if te else nj / ctj

    eta = [admittance(n[j], ct[j]) for j in range(len(n))]

    # characteristic matrix product over finite (interior) layers
    m00 = np.ones_like(wl, dtype=complex)
    m01 = np.zeros_like(wl, dtype=complex)
    m10 = np.zeros_like(wl, dtype=complex)
    m11 = np.ones_like(wl, dtype=complex)
    for j in range(1, len(layers) - 1):
        delta = 2.0 * np.pi / wl * n[j] * d[j] * ct[j]      # d and wl both in nm
        cosd = np.cos(delta)
        sind = np.sin(delta)
        a00, a01 = cosd, 1j * sind / eta[j]
        a10, a11 = 1j * eta[j] * sind, cosd
        m00, m01, m10, m11 = (
            m00 * a00 + m01 * a10,
            m00 * a01 + m01 * a11,
            m10 * a00 + m11 * a10,
            m10 * a01 + m11 * a11,
        )

    eta_sub = eta[-1]
    eta_amb = eta[0]
    B = m00 + m01 * eta_sub
    C = m10 + m11 * eta_sub
    Y = C / B
    r = (eta_amb - Y) / (eta_amb + Y)
    return np.abs(r) ** 2
