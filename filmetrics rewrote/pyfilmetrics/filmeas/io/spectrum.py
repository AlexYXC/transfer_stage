"""Spectrum I/O.

`.fmspe` (FILMeasure stored spectrum) is a .NET-BinaryWriter-serialized file:
    int32 version, int32 version2, int32 dataOffset, int32 pad
    <7-bit-len string> 40-char SHA1 hash
    <7-bit-len string> instrument serial / "Unknown"
    <7-bit-len string> label (e.g. "Si_F20", "Si_F42 raw minus dark")
    ...
    @dataOffset:  int32 K, then K * (double wavelength_nm, double value)
The value is intensity/counts for a "raw" spectrum, or reflectance for a measured one.
Also supports simple CSV (`wavelength_nm,value`) and FILMeasure `.rrr` (`Wavelength(nm),R`).
"""
from __future__ import annotations

import struct
from dataclasses import dataclass

import numpy as np


@dataclass
class Spectrum:
    wavelength_nm: np.ndarray
    value: np.ndarray
    label: str = ""
    kind: str = "raw"          # "raw" | "reflectance" | "transmittance"

    def __post_init__(self):
        self.wavelength_nm = np.asarray(self.wavelength_nm, dtype=float)
        self.value = np.asarray(self.value, dtype=float)
        if self.wavelength_nm.shape != self.value.shape:
            raise ValueError("wavelength and value must have the same shape")

    def __len__(self):
        return len(self.wavelength_nm)

    # ---- CSV ----------------------------------------------------------
    def save_csv(self, path: str) -> None:
        with open(path, "w", encoding="utf-8", newline="") as f:
            f.write("wavelength_nm,value\r\n")
            for w, v in zip(self.wavelength_nm, self.value):
                f.write(f"{w},{v}\r\n")

    @classmethod
    def load_csv(cls, path: str, kind: str = "raw") -> "Spectrum":
        w, v = [], []
        with open(path, "r", encoding="utf-8") as f:
            for line in f:
                line = line.strip()
                if not line:
                    continue
                a, b = line.split(",")[:2]
                try:
                    w.append(float(a)); v.append(float(b))
                except ValueError:
                    continue  # header line
        return cls(np.array(w), np.array(v), label=path, kind=kind)


def _net_string(d: bytes, off: int):
    shift = length = 0
    while True:
        b = d[off]; off += 1
        length |= (b & 0x7F) << shift
        if not (b & 0x80):
            break
        shift += 7
    s = d[off:off + length].decode("latin-1")
    return s, off + length


def load_fmspe(path: str) -> Spectrum:
    with open(path, "rb") as f:
        d = f.read()
    data_off = struct.unpack_from("<i", d, 8)[0]   # int32[2] = offset of the (wl,value) array
    if not (0 < data_off < len(d)):
        raise ValueError(f"{path}: implausible data offset {data_off}")
    k = struct.unpack_from("<i", d, data_off)[0]
    if k <= 0 or data_off + 4 + k * 16 > len(d):
        raise ValueError(f"{path}: bad point count {k}")
    flat = struct.unpack_from("<" + "d" * (2 * k), d, data_off + 4)
    wl = np.array(flat[0::2]); val = np.array(flat[1::2])

    # recover the label: the header holds three .NET strings (SHA1 hash, serial, label) before the
    # numeric arrays. Scan only the header region, advancing past each string, and take the last
    # readable one (>=5 chars, not the 40-char hex hash). Beyond ~200 bytes lie the float arrays,
    # whose bytes can look like short strings, so we cap the scan.
    label = ""
    off = 16
    limit = min(data_off, 220)
    while off < limit:
        try:
            s, nxt = _net_string(d, off)
        except Exception:
            off += 1
            continue
        printable = bool(s) and all(32 <= ord(c) < 127 for c in s)
        is_hash = len(s) == 40 and all(c in "0123456789ABCDEFabcdef" for c in s)
        if printable and len(s) >= 5 and not is_hash:
            label = s
            off = nxt          # advance past a good string to avoid mid-string false hits
        else:
            off += 1
    kind = "reflectance" if "refl" in label.lower() else "raw"
    return Spectrum(wl, val, label=label, kind=kind)
