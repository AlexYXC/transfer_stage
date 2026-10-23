"""FILMeasure .fibnk material files — header inspection only.

What we can read (plaintext header, HIGH confidence):
    int32[0]  format version (3 or 4 seen)
    int32[1]  = 1
    int32[2]  model type
    int32[3]  (aux)
    int32[4]  = (num_points << 16) | 0xFFFF     -> num_points

The n,k PAYLOAD is encoded/protected (no plaintext float table; ~28 bytes/point; obfuscated strings), and
FILMeasure ships a key/decrypt service for material files (FIMatFileSecurityService.RequestDecryptKey /
RequestViewKey in the decompiled assembly). Extracting the payload would mean circumventing that content
protection on Filmetrics' proprietary material database — out of scope for this project.

Use materials legitimately instead (see filmeas.io.material):
  * dispersion models: Cauchy / Sellmeier / Constant / tabulated
  * CSV you own or are licensed for: `wavelength_nm,n,k`  (material.load_nk_csv)
  * export n,k from FILMeasure itself (it decrypts under its own license) and load the CSV here
"""
from __future__ import annotations

import struct
from dataclasses import dataclass


class FibnkProtectedError(NotImplementedError):
    """Raised when the encoded/protected n,k payload is requested."""


@dataclass
class FibnkHeader:
    version: int
    model_type: int
    aux: int
    num_points: int
    file_size: int


def read_header(path: str) -> FibnkHeader:
    with open(path, "rb") as f:
        d = f.read(24)
    v0, _one, model_type, aux, marker = struct.unpack_from("<5i", d, 0)
    return FibnkHeader(
        version=v0,
        model_type=model_type,
        aux=aux,
        num_points=(marker >> 16) & 0xFFFF,
        file_size=_filesize(path),
    )


def load_nk(path: str):
    """Not supported: the n,k payload is protected. Use material.load_nk_csv or a dispersion model."""
    hdr = read_header(path)
    raise FibnkProtectedError(
        f"{path}: header OK (version {hdr.version}, model_type {hdr.model_type}, "
        f"{hdr.num_points} pts) but the n,k data is encoded/protected. "
        "Export it from FILMeasure to CSV and use material.load_nk_csv(), or use a dispersion model."
    )


def _filesize(path):
    import os
    return os.path.getsize(path)
