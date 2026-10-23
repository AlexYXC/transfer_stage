"""Refractive-index dispersion models. Each model is callable: ``model(wavelength_nm) -> complex n+ik``."""
from __future__ import annotations

import numpy as np


class Dispersion:
    def nk(self, wavelength_nm):
        raise NotImplementedError

    def __call__(self, wavelength_nm):
        return self.nk(wavelength_nm)


class Constant(Dispersion):
    def __init__(self, n: float, k: float = 0.0):
        self.n = float(n); self.k = float(k)

    def nk(self, wavelength_nm):
        w = np.asarray(wavelength_nm, dtype=float)
        return np.full(w.shape, self.n + 1j * self.k)


class Cauchy(Dispersion):
    """n(lambda) = A + B/um^2 + C/um^4 ; k = 0.  (Coefficients in micrometers, FILMeasure convention.)"""
    def __init__(self, A: float, B: float = 0.0, C: float = 0.0):
        self.A, self.B, self.C = float(A), float(B), float(C)

    def nk(self, wavelength_nm):
        um = np.asarray(wavelength_nm, dtype=float) / 1000.0
        n = self.A + self.B / um**2 + self.C / um**4
        return n + 0j


class Sellmeier(Dispersion):
    """n^2 = 1 + sum_j Bj*um^2 / (um^2 - Cj) ;  k = 0.  terms = [(Bj, Cj_um2), ...] (wavelength in um)."""
    def __init__(self, terms):
        self.terms = [(float(b), float(c)) for b, c in terms]

    def nk(self, wavelength_nm):
        um2 = (np.asarray(wavelength_nm, dtype=float) / 1000.0) ** 2
        n2 = np.ones_like(um2)
        for b, c in self.terms:
            n2 = n2 + b * um2 / (um2 - c)
        return np.sqrt(np.maximum(n2, 1e-9)) + 0j


class CauchyUrbach(Dispersion):
    """Cauchy n(A,B,C in um) with an Urbach absorption tail k = k_amp * exp(k_beta / um)."""
    def __init__(self, A, B=0.0, C=0.0, k_amp=0.0, k_beta=0.0):
        self.A, self.B, self.C = float(A), float(B), float(C)
        self.k_amp, self.k_beta = float(k_amp), float(k_beta)

    def nk(self, wavelength_nm):
        um = np.asarray(wavelength_nm, dtype=float) / 1000.0
        n = self.A + self.B / um**2 + self.C / um**4
        k = self.k_amp * np.exp(self.k_beta / um)
        return n + 1j * k


_HC_EV_NM = 1239.841984   # h*c in eV*nm


class Lorentz(Dispersion):
    """Sum of Lorentz oscillators. eps = eps_inf + sum f/(E0^2 - E^2 - i*gamma*E), E in eV.

    oscillators = [(strength_f_eV2, E0_eV, gamma_eV), ...].  Returns n + i k with k >= 0.
    """
    def __init__(self, eps_inf=1.0, oscillators=()):
        self.eps_inf = float(eps_inf)
        self.osc = [(float(f), float(e0), float(g)) for f, e0, g in oscillators]

    def nk(self, wavelength_nm):
        E = _HC_EV_NM / np.asarray(wavelength_nm, dtype=float)
        eps = np.full(E.shape, self.eps_inf, dtype=complex)
        for f, e0, g in self.osc:
            eps = eps + f / (e0**2 - E**2 - 1j * g * E)
        nc = np.sqrt(eps)
        nc = np.where(nc.imag < 0, np.conj(nc), nc)   # physical branch: k >= 0
        return nc


class Tabulated(Dispersion):
    """Linear interpolation of tabulated (wavelength_nm, n, k); clamps outside the range."""
    def __init__(self, wavelength_nm, n, k=None):
        self.w = np.asarray(wavelength_nm, dtype=float)
        order = np.argsort(self.w)
        self.w = self.w[order]
        self.n = np.asarray(n, dtype=float)[order]
        self.k = (np.zeros_like(self.w) if k is None
                  else np.asarray(k, dtype=float)[order])

    def nk(self, wavelength_nm):
        w = np.asarray(wavelength_nm, dtype=float)
        n = np.interp(w, self.w, self.n)
        k = np.interp(w, self.w, self.k)
        return n + 1j * k
